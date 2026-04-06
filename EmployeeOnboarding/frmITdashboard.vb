Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports Npgsql
Imports EmployeeOnboarding.Data
Imports EmployeeOnboarding.EmployeeOnboarding.Data

Partial Public Class frmITdashboard

    Private ReadOnly connString As String = "Host=localhost;Port=5432;Username=postgres;Password=0116646;Database=onboarding_portal”


    ' Load IT dashboard when the form opens
    Private Sub frmITdashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ' Load requests into the grid
        LoadITRequests()

    End Sub

    ' Load requests relevant to IT
    Private Sub LoadITRequests()

        dgvTasks.DataSource = Nothing
        dgvTasks.AutoGenerateColumns = True

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
            WHERE s.status_code IN ('APPROVED', 'IN_PROGRESS', 'ON_HOLD', 'COMPLETED')
            ORDER BY r.request_id;
        "

            Using cmd As New NpgsqlCommand(query, conn)
                Using da As New NpgsqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using

        dgvTasks.DataSource = dt

        dgvTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvTasks.ReadOnly = True
        dgvTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvTasks.MultiSelect = False
        dgvTasks.AllowUserToAddRows = False
        dgvTasks.RowHeadersVisible = False
        dgvTasks.BackgroundColor = Color.White

        For Each col As DataGridViewColumn In dgvTasks.Columns
            col.SortMode = DataGridViewColumnSortMode.NotSortable
        Next




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

                    Case "in progress", "in_progress", "inprogress"
                        row.Cells("Status").Style.BackColor = Color.LightYellow
                        row.Cells("Status").Style.ForeColor = Color.Black

                    Case "rejected", "denied"
                        row.Cells("Status").Style.BackColor = Color.LightCoral
                        row.Cells("Status").Style.ForeColor = Color.Black

                    Case "pending", "pending approval", "pending_approval"
                        row.Cells("Status").Style.BackColor = Color.LightSkyBlue
                        row.Cells("Status").Style.ForeColor = Color.Black

                    Case "on hold", "on_hold"
                        row.Cells("Status").Style.BackColor = Color.Khaki
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