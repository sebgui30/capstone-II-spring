Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports EmployeeOnboarding.Data
Imports EmployeeOnboarding.EmployeeOnboarding.Data
Imports Npgsql


Partial Public Class frmHRdashboard

    Private ReadOnly connString As String = "Host=localhost;Port=5432;Username=postgres;Password=0116646;Database=onboarding_portal"

    ' Load HR dashboard
    Private Sub frmHRdashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Create sample data so we can visualize the system

        LoadRequestsGrid()

    End Sub


    ' Load all onboarding requests into the grid
    Private Sub LoadRequestsGrid()

        dgvRequests.DataSource = Nothing
        dgvRequests.AutoGenerateColumns = True

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

        dgvRequests.DataSource = dt

        dgvRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRequests.ReadOnly = True
        dgvRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRequests.MultiSelect = False
        dgvRequests.AllowUserToAddRows = False
        dgvRequests.RowHeadersVisible = False
        dgvRequests.BackgroundColor = Color.White


        For Each col As DataGridViewColumn In dgvRequests.Columns
            col.SortMode = DataGridViewColumnSortMode.NotSortable
        Next




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

                    Case "pending", "pending approval", "pending_approval"
                        row.Cells("Status").Style.BackColor = Color.LightSkyBlue
                        row.Cells("Status").Style.ForeColor = Color.Black

                    Case Else
                        row.Cells("Status").Style.BackColor = Color.White
                        row.Cells("Status").Style.ForeColor = Color.Black

                End Select

            End If

        Next

    End Sub

    Private Sub dgvRequests_Sorted(sender As Object, e As EventArgs) Handles dgvRequests.Sorted
        ColorStatusRows()
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