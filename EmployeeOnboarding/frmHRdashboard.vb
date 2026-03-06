Imports EmployeeOnboarding.Models
Imports EmployeeOnboarding.Data
Imports EmployeeOnboarding.Business
Imports System.Linq
Imports EmployeeOnboarding.EmployeeOnboarding.Data

Partial Public Class frmHRdashboard

    ' Load the requests into the grid when the dashboard opens
    Private Sub frmHRdashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Create test data if list is empty
        InMemoryRequestStore.SeedTestData()

        LoadRequestsGrid()

    End Sub


    ' Loads all onboarding requests from the in-memory store
    Private Sub LoadRequestsGrid()

        ' Clear existing binding
        dgvRequests.DataSource = Nothing

        ' Create a simplified display list
        Dim displayList = InMemoryRequestStore.Requests.Select(Function(r) New With {
            .RequestId = r.RequestId,
            .EmployeeName = r.Employee.FirstName & " " & r.Employee.LastName,
            .Department = r.Employee.Department,
            .StartDate = r.Employee.StartDate.ToShortDateString(),
            .Status = r.Status
        }).ToList()

        ' Bind the grid
        dgvRequests.DataSource = displayList

    End Sub


    ' Open the Request Details screen
    Private Sub btnViewDetails_Click(sender As Object, e As EventArgs) Handles btnCreateRequest.Click

        ' Ensure a row is selected
        If dgvRequests.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a request first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Get the RequestId from the selected row
        Dim selectedRequestId As Integer = CInt(dgvRequests.CurrentRow.Cells("RequestId").Value)

        ' Open the Request Details form with the selected ID
        Dim detailsForm As New frmRequestDetails(selectedRequestId)
        detailsForm.ShowDialog()

        ' Reload the grid in case status changed
        LoadRequestsGrid()

    End Sub

    ' Logout button: clear session role and return to role selection
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Clear the in-memory session role
        Data.SessionStore.CurrentRole = String.Empty

        ' Show the role selection form so the user can re-enter or choose another role
        Dim roleForm As New frmRoleSelection()
        roleForm.Show()

        ' Close this dashboard
        Me.Close()
    End Sub

End Class