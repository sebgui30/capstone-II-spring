Imports System.Linq
Imports EmployeeOnboarding.Data
Imports EmployeeOnboarding.EmployeeOnboarding.Data
Imports EmployeeOnboarding.Models

Partial Public Class frmOnboardingRequest

    ' Load basic form setup
    Private Sub frmOnboardingRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Fill the department combo box
        LoadDepartments()

        ' Set default start date
        dtpStartDate.Value = Date.Today

    End Sub

    ' Load department options into the combo box
    Private Sub LoadDepartments()

        cboDepartment.Items.Clear()

        cboDepartment.Items.Add("IT")
        cboDepartment.Items.Add("HR")
        cboDepartment.Items.Add("Finance")
        cboDepartment.Items.Add("Marketing")
        cboDepartment.Items.Add("Operations")

        cboDepartment.SelectedIndex = 0

    End Sub

    ' Submit the onboarding request
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        ' Validate employee name
        If String.IsNullOrWhiteSpace(txtName.Text) Then
            MessageBox.Show("Please enter the employee name.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtName.Focus()
            Return
        End If

        ' Validate department
        If cboDepartment.SelectedIndex = -1 Then
            MessageBox.Show("Please select a department.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cboDepartment.Focus()
            Return
        End If

        ' Build requested systems list
        Dim selectedSystems As New List(Of String)

        If chkEmail.Checked Then
            selectedSystems.Add("Email")
        End If

        If chkVPN.Checked Then
            selectedSystems.Add("VPN")
        End If

        If chkPayroll.Checked Then
            selectedSystems.Add("Payroll")
        End If

        If chkGitAccess.Checked Then
            selectedSystems.Add("Git / Repo Access")
        End If

        ' Require at least one requested system
        If selectedSystems.Count = 0 Then
            MessageBox.Show("Please select at least one required system.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Split full name into first and last name
        Dim fullName As String = txtName.Text.Trim()
        Dim nameParts() As String = fullName.Split(" "c)

        Dim firstName As String = nameParts(0)
        Dim lastName As String = ""

        If nameParts.Length > 1 Then
            lastName = String.Join(" ", nameParts.Skip(1))
        End If

        ' Create employee object
        Dim newEmployee As New Employee With {
            .EmployeeId = InMemoryRequestStore.NextRequestId,
            .FirstName = firstName,
            .LastName = lastName,
            .Email = (firstName & "." & lastName).ToLower().Replace(" ", "") & "@company.com",
            .Department = cboDepartment.SelectedItem.ToString(),
            .JobTitle = "New Hire",
            .StartDate = dtpStartDate.Value.Date
        }

        ' Create onboarding request object
        Dim newRequest As New OnboardingRequest With {
            .RequestId = InMemoryRequestStore.NextRequestId,
            .Employee = newEmployee,
            .Status = "In Progress",
            .ManagerName = "Assigned Manager",
            .TemplateName = cboDepartment.SelectedItem.ToString() & " Access",
            .Notes = "Created from HR onboarding form",
            .RequestedSystems = selectedSystems,
            .CreatedAt = DateTime.Now,
            .UpdatedAt = DateTime.Now
        }

        ' Save request into the in-memory store
        InMemoryRequestStore.Requests.Add(newRequest)
        InMemoryRequestStore.NextRequestId += 1

        ' Show confirmation message
        MessageBox.Show("Onboarding request submitted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Close the form and return to HR Dashboard
        Me.Close()

    End Sub

    ' Close the form without saving
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

End Class