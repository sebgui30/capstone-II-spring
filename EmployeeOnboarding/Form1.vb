Public Class frmEmployeeOnboarding
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim empName As String = txtName.Text.Trim()
        Dim dept As String = ""
        Dim role As String = ""
        Dim startDate As String = dtpStartDate.Value.ToShortDateString()
        Dim status As String = "Pending"

        If cboDepartment.SelectedIndex >= 0 Then
            dept = cboDepartment.SelectedItem.ToString()
        End If

        If radIntern.Checked Then
            role = "Intern"
        ElseIf radFullTime.Checked Then
            role = "Full-Time"
        End If

        If empName = "" Or dept = "" Or role = "" Then
            MessageBox.Show("Please complete Name, Department, and Role.", "Missing Info")
            Exit Sub
        End If

        Dim line As String = empName & " | " & dept & " | " & role & " | " & startDate & " | " & status
        lstEmployees.Items.Add(line)

        txtName.Clear()
        cboDepartment.SelectedIndex = -1
        radIntern.Checked = False
        radFullTime.Checked = False
        dtpStartDate.Value = DateTime.Now
        txtName.Focus()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Clear()
        cboDepartment.SelectedIndex = -1
        radIntern.Checked = False
        radFullTime.Checked = False
        dtpStartDate.Value = DateTime.Now
        lstEmployees.Items.Clear()
        txtName.Focus()
    End Sub

    Private Sub frmEmployeeOnboarding_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboDepartment.Items.Clear()

        cboDepartment.Items.Add("HR")
        cboDepartment.Items.Add("IT")
        cboDepartment.Items.Add("Sales")
        cboDepartment.Items.Add("Finance")
        cboDepartment.Items.Add("Operations")
    End Sub
End Class
