Imports EmployeeOnboarding.Data
Imports EmployeeOnboarding.EmployeeOnboarding.Data
Imports EmployeeOnboarding.Models

Public Class frmITProvision

    Private _requestId As Integer
    Private _selectedRequest As OnboardingRequest

    Public Sub New(requestId As Integer)

        InitializeComponent()
        _requestId = requestId

    End Sub

    Private Sub frmITProvision_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadRequestDetails()

    End Sub

    Private Sub LoadRequestDetails()

        _selectedRequest = InMemoryRequestStore.Requests.FirstOrDefault(Function(r) r.RequestId = _requestId)

        If _selectedRequest Is Nothing Then
            MessageBox.Show("Request not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Exit Sub
        End If

        lblEmployeeValue.Text = _selectedRequest.Employee.FirstName & " " & _selectedRequest.Employee.LastName
        lblDepartmentValue.Text = _selectedRequest.Employee.Department
        lblStartDateValue.Text = _selectedRequest.Employee.StartDate.ToShortDateString()

        lstSystems.Items.Clear()

        If _selectedRequest.RequestedSystems IsNot Nothing Then
            For Each systemName In _selectedRequest.RequestedSystems
                lstSystems.Items.Add(systemName)
            Next
        End If

    End Sub

    Private Sub btnProvisionComplete_Click(sender As Object, e As EventArgs) Handles btnProvisionComplete.Click

        If _selectedRequest Is Nothing Then
            MessageBox.Show("Request not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        _selectedRequest.Status = "Completed"

        MessageBox.Show("Provisioning completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Me.Close()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

End Class