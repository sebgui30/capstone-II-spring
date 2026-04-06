Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports Npgsql
Imports EmployeeOnboarding.Data
Imports EmployeeOnboarding.EmployeeOnboarding.Data

Partial Public Class frmManagerDashboard

    Private ReadOnly connString As String = "Host=localhost;Port=5432;Username=postgres;Password=0116646;Database=onboarding_portal”


    ' Load the manager dashboard when the form opens
    Private Sub frmManagerDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Load requests into the grid
        LoadManagerRequests()

    End Sub

    ' Load requests for manager visualization
    Private Sub LoadManagerRequests()


        dgvApprovals.DataSource = Nothing
        dgvApprovals.AutoGenerateColumns = True

        Dim dt As New DataTable()

        Using conn As New NpgsqlConnection(connString)
            conn.Open()

            Dim query As String = "
            SELECT
                r.request_id AS ""RequestId"",
                e.first_name || ' ' || e.last_name AS ""EmployeeName"",
                e.department AS ""Department"",
                e.start_date AS ""StartDate"",
                COALESCE(u.full_name, 'Assigned Manager') AS ""Manager"",
                s.status_code AS ""Status""
            FROM onboarding.onboarding_requests r
            INNER JOIN onboarding.employees e
                ON r.employee_id = e.employee_id
            LEFT JOIN onboarding.users u
                ON r.manager_user_id = u.user_id
            INNER JOIN onboarding.onboarding_request_statuses s
                ON r.status_id = s.status_id
            ORDER BY r.request_id;
        "

            Using cmd As New NpgsqlCommand(query, conn)
                Using da As New NpgsqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using

        dgvApprovals.DataSource = dt

        dgvApprovals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvApprovals.ReadOnly = True
        dgvApprovals.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvApprovals.MultiSelect = False
        dgvApprovals.AllowUserToAddRows = False
        dgvApprovals.RowHeadersVisible = False
        dgvApprovals.BackgroundColor = Color.White


        For Each col As DataGridViewColumn In dgvApprovals.Columns
            col.SortMode = DataGridViewColumnSortMode.NotSortable
        Next





        ColorStatusRows()






    End Sub

    ' Apply status colors to make the workflow easier to visualize
    Private Sub ColorStatusRows()


        For Each row As DataGridViewRow In dgvApprovals.Rows

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

                    Case "pending", "pending_approval", "pending approval"
                        row.Cells("Status").Style.BackColor = Color.LightSkyBlue
                        row.Cells("Status").Style.ForeColor = Color.Black

                    Case Else
                        row.Cells("Status").Style.BackColor = Color.White
                        row.Cells("Status").Style.ForeColor = Color.Black
                End Select

            End If

        Next


    End Sub

    Private Sub dgvApprovals_Sorted(sender As Object, e As EventArgs) Handles dgvApprovals.Sorted
        ColorStatusRows()
    End Sub



    ' Open request details on double click
    Private Sub dgvApprovals_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvApprovals.CellDoubleClick

        If e.RowIndex < 0 Then
            Return
        End If

        If dgvApprovals.Rows(e.RowIndex).IsNewRow Then
            Return
        End If

        If dgvApprovals.Rows(e.RowIndex).Cells("RequestId").Value Is Nothing OrElse IsDBNull(dgvApprovals.Rows(e.RowIndex).Cells("RequestId").Value) Then
            Return
        End If

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