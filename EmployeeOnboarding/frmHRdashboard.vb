Imports System.Drawing
Imports System.Linq
Imports EmployeeOnboarding.Data
Imports EmployeeOnboarding.EmployeeOnboarding.Data

Partial Public Class frmHRdashboard

    ' Load HR dashboard
    Private Sub frmHRdashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Create sample data so we can visualize the system
        InMemoryRequestStore.SeedTestData()

        LoadRequestsGrid()

    End Sub


    ' Load all onboarding requests into the grid
    Private Sub LoadRequestsGrid()

        dgvRequests.DataSource = Nothing
        dgvRequests.AutoGenerateColumns = True

        Dim displayList = InMemoryRequestStore.Requests _
            .Select(Function(r) New With {
                .RequestId = r.RequestId,
                .EmployeeName = r.Employee.FirstName & " " & r.Employee.LastName,
                .Department = r.Employee.Department,
                .StartDate = r.Employee.StartDate.ToShortDateString(),
                .Manager = r.ManagerName,
                .Status = r.Status
            }).ToList()

        dgvRequests.DataSource = displayList

        dgvRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRequests.ReadOnly = True
        dgvRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRequests.MultiSelect = False

        ColorStatusRows()

    End Sub


    Private Sub ColorStatusRows()

        For Each row As DataGridViewRow In dgvRequests.Rows

            If row.Cells("Status").Value IsNot Nothing Then

                Dim statusText As String = row.Cells("Status").Value.ToString().Trim().ToLower()

                Select Case statusText

                    Case "completed", "approved"
                        row.Cells("Status").Style.BackColor = Color.LightGreen
                        row.Cells("Status").Style.ForeColor = Color.Black

                    Case "in progress", "inprogress"
                        row.Cells("Status").Style.BackColor = Color.LightYellow
                        row.Cells("Status").Style.ForeColor = Color.Black

                    Case "rejected", "denied"
                        row.Cells("Status").Style.BackColor = Color.LightCoral
                        row.Cells("Status").Style.ForeColor = Color.Black

                    Case "pending", "pending approval"
                        row.Cells("Status").Style.BackColor = Color.LightSkyBlue
                        row.Cells("Status").Style.ForeColor = Color.Black

                    Case Else
                        row.Cells("Status").Style.BackColor = Color.White
                        row.Cells("Status").Style.ForeColor = Color.Black

                End Select

            End If

        Next

    End Sub


    Private Sub btnCreateRequest_Click(sender As Object, e As EventArgs) Handles btnCreateRequest.Click

        ' Open the onboarding request form
        Dim requestForm As New frmOnboardingRequest()
        requestForm.ShowDialog()

        ' Refresh the grid after the form closes
        LoadRequestsGrid()

    End Sub


    ' Open the request details screen
    Private Sub btnViewDetails_Click(sender As Object, e As EventArgs) Handles btnViewDetails.Click

        If dgvRequests.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a request first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedRequestId As Integer = CInt(dgvRequests.CurrentRow.Cells("RequestId").Value)

        Dim detailsForm As New frmRequestDetails(selectedRequestId)
        detailsForm.ShowDialog()

        LoadRequestsGrid()

    End Sub


    ' Logout back to role selection
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        Dim roleForm As New frmRoleSelection()
        roleForm.Show()
        Me.Close()

    End Sub

End Class