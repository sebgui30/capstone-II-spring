Imports EmployeeOnboarding.Business
Imports EmployeeOnboarding.EmployeeOnboarding.Business

Partial Public Class frmRequestDetails
    ''' <summary>
    ''' Presentation layer for viewing and acting on a single onboarding request.
    ''' UI responsibility:
    ''' - Load request details into controls
    ''' - Call business methods to approve or reject
    ''' - No direct data access or business rules here.
    ''' </summary>

    Private _requestId As Integer

    ' Do not instantiate the service at field declaration to avoid design-time / designer errors.
    ' Instantiate at runtime (form load) instead.
    Private requestService As RequestDetailsService

    ' Parameterless constructor required by the Designer.
    Public Sub New()
        InitializeComponent()
    End Sub

    ' Preferred runtime constructor: supply the RequestId to display.
    Public Sub New(requestId As Integer)
        InitializeComponent()
        _requestId = requestId
    End Sub

    Private Sub frmRequestDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Avoid running runtime-only logic while in the designer.
        If Me.DesignMode Then
            Return
        End If

        ' Instantiate business service at runtime only.
        requestService = New RequestDetailsService()

        ' Load the request details into the UI.
        LoadRequestDetails()
    End Sub

    ''' <summary>
    ''' LoadRequestDetails
    ''' - Uses the business service to retrieve the request.
    ''' - Populates labels and the systems list box.
    ''' - If the request is missing, show a short message and close the form.
    ''' </summary>
    Private Sub LoadRequestDetails()

        ' Step 1: Validate that a request ID was provided
        If _requestId <= 0 Then
            MessageBox.Show("No Request ID was provided to this form.", "Missing Request ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
            Return
        End If

        ' Step 2: Retrieve the request using the Business Layer
        Dim req = requestService.GetRequestById(_requestId)

        ' Step 3: If request does not exist in the store, notify the user
        If req Is Nothing Then
            MessageBox.Show("Request not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
            Return
        End If

        ' Step 4: Populate employee information
        lblEmployeeValue.Text = req.Employee.FirstName & " " & req.Employee.LastName
        lblDepartmentValue.Text = req.Employee.Department
        lblStartDateValue.Text = req.Employee.StartDate.ToShortDateString()

        ' Step 5: Populate requested systems list
        lstSystems.Items.Clear()

        If req.RequestedSystems IsNot Nothing AndAlso req.RequestedSystems.Count > 0 Then
            For Each sys In req.RequestedSystems
                lstSystems.Items.Add(sys)
            Next
        Else
            lstSystems.Items.Add("No systems requested")
        End If

        ' Step 6: Display message for reviewer
        lblMessage.Text = "Review this onboarding request and choose Approve or Reject."

    End Sub

    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        ' Confirm the action with the user.
        Dim dr = MessageBox.Show("Are you sure you want to approve this request?", "Confirm Approve", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dr <> DialogResult.Yes Then
            Return
        End If

        ' Call the business layer to perform the approve operation.
        Dim ok = requestService.ApproveRequest(_requestId)
        If ok Then
            MessageBox.Show("Request approved successfully.", "Approved", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Unable to approve request.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click
        ' Confirm the action with the user.
        Dim dr = MessageBox.Show("Are you sure you want to reject this request?", "Confirm Reject", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dr <> DialogResult.Yes Then
            Return
        End If

        ' Call the business layer to perform the reject operation.
        Dim ok = requestService.RejectRequest(_requestId)
        If ok Then
            MessageBox.Show("Request rejected successfully.", "Rejected", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Unable to reject request.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' Close the form without making changes.
        Me.Close()
    End Sub
End Class