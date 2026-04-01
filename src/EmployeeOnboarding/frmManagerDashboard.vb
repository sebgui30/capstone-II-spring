Imports System.Drawing
Imports System.Linq
Imports EmployeeOnboarding.Data
Imports EmployeeOnboarding.EmployeeOnboarding.Data

Partial Public Class frmManagerDashboard

    ' Load the manager dashboard when the form opens
    Private Sub frmManagerDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Seed temporary sample data for UI testing
        InMemoryRequestStore.SeedTestData()

        ' Load requests into the grid
        LoadManagerRequests()

    End Sub

    ' Load requests for manager visualization
    Private Sub LoadManagerRequests()

        dgvApprovals.DataSource = Nothing
        dgvApprovals.AutoGenerateColumns = True

        Dim requestList = InMemoryRequestStore.Requests _
            .Select(Function(r) New With {
                .RequestId = r.RequestId,
                .EmployeeName = r.Employee.FirstName & " " & r.Employee.LastName,
                .Department = r.Employee.Department,
                .StartDate = r.Employee.StartDate.ToShortDateString(),
                .Manager = r.ManagerName,
                .Status = r.Status
            }).ToList()

        dgvApprovals.DataSource = requestList

        ' Optional grid formatting
        dgvApprovals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvApprovals.ReadOnly = True
        dgvApprovals.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvApprovals.MultiSelect = False

        ' Apply color coding after binding
        ColorStatusRows()

    End Sub

    ' Apply status colors to make the workflow easier to visualize
    Private Sub ColorStatusRows()

        For Each row As DataGridViewRow In dgvApprovals.Rows

            If row.Cells("Status").Value IsNot Nothing Then

                Dim statusText As String = row.Cells("Status").Value.ToString().Trim().ToLower()

                Select Case statusText
                    Case "completed"
                        row.Cells("Status").Style.BackColor = Color.LightGreen
                        row.Cells("Status").Style.ForeColor = Color.Black

                    Case "in progress"
                        row.Cells("Status").Style.BackColor = Color.LightYellow
                        row.Cells("Status").Style.ForeColor = Color.Black

                    Case "rejected", "denied"
                        row.Cells("Status").Style.BackColor = Color.LightCoral
                        row.Cells("Status").Style.ForeColor = Color.Black

                    Case "pending"
                        row.Cells("Status").Style.BackColor = Color.LightSkyBlue
                        row.Cells("Status").Style.ForeColor = Color.Black
                End Select

            End If

        Next

    End Sub

    ' Open request details on double click
    Private Sub dgvApprovals_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvApprovals.CellDoubleClick

        If e.RowIndex < 0 Then Return

        Dim selectedRequestId As Integer = CInt(dgvApprovals.Rows(e.RowIndex).Cells("RequestId").Value)

        Dim detailsForm As New frmRequestDetails(selectedRequestId)
        detailsForm.ShowDialog()

        LoadManagerRequests()

    End Sub

    ' Logout and return to role selection
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        Dim roleForm As New frmRoleSelection()
        roleForm.Show()
        Me.Close()

    End Sub

End Class