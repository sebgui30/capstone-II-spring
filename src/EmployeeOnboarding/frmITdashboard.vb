Imports System.Drawing
Imports System.Linq
Imports EmployeeOnboarding.Data
Imports EmployeeOnboarding.EmployeeOnboarding.Data

Partial Public Class frmITdashboard

    ' Load IT dashboard when the form opens
    Private Sub frmITdashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Seed sample data for testing if needed
        InMemoryRequestStore.SeedTestData()

        ' Load requests into the grid
        LoadITRequests()

    End Sub

    ' Load requests relevant to IT
    Private Sub LoadITRequests()

        dgvTasks.DataSource = Nothing
        dgvTasks.AutoGenerateColumns = True

        ' For now, IT sees all requests except rejected ones if desired.
        ' You can change this filter later depending on your workflow.
        Dim requestList = InMemoryRequestStore.Requests _
            .Select(Function(r) New With {
                .RequestId = r.RequestId,
                .EmployeeName = r.Employee.FirstName & " " & r.Employee.LastName,
                .Department = r.Employee.Department,
                .StartDate = r.Employee.StartDate.ToShortDateString(),
                .Manager = r.ManagerName,
                .Status = r.Status
            }).ToList()

        dgvTasks.DataSource = requestList

        dgvTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvTasks.ReadOnly = True
        dgvTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvTasks.MultiSelect = False

        ColorStatusRows()

    End Sub

    ' Color-code the Status column
    Private Sub ColorStatusRows()

        For Each row As DataGridViewRow In dgvTasks.Rows

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

    ' Open request details when double-clicking a row
    Private Sub dgvTasks_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTasks.CellDoubleClick

        If e.RowIndex < 0 Then
            Return
        End If

        Dim selectedRequestId As Integer = CInt(dgvTasks.Rows(e.RowIndex).Cells("RequestId").Value)

        Dim detailsForm As New frmRequestDetails(selectedRequestId)
        detailsForm.ShowDialog()

        LoadITRequests()

    End Sub

    ' Logout and return to role selection
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        Dim roleForm As New frmRoleSelection()
        roleForm.Show()
        Me.Close()

    End Sub

End Class