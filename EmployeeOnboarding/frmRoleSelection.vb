Imports Business
Imports EmployeeOnboarding.Business
Public Class frmRoleSelection
    ''' <summary>
    ''' Presentation layer: handles UI events only and delegates decisions to Business layer.
    ''' </summary>

    Private Sub frmRoleSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Usability: default to HR so keyboard users can press Enter immediately.
        ' This is a presentation detail; the service still validates selection.
        radHR.Checked = True
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        ' 1) Use business service to validate that a role is selected.
        Dim service As New RoleSelectionService()
        If Not service.ValidateRoleSelected(radHR.Checked, radManager.Checked, radIT.Checked) Then
            ' Presentation responsibility: show message to the user.
            MessageBox.Show("Please select a role before entering the dashboard.", "Role Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' 2) Ask business layer for the selected role string.
        Dim role As String = service.GetSelectedRole(radHR.Checked, radManager.Checked, radIT.Checked)

        ' 3) Persist role using business layer (which writes to Data.SessionStore).
        service.SetCurrentRole(role)

        ' 4) Open the corresponding dashboard form (presentation action).
        Select Case role
            Case "HR"
                Dim frm As New frmHRdashboard()
                frm.Show()
            Case "Manager"
                Dim frm As New frmManagerDashboard()
                frm.Show()
            Case "IT"
                Dim frm As New frmITdashboard()
                frm.Show()
            Case Else
                ' This should not happen because we validated, but guard anyway.
                MessageBox.Show("Unrecognized role selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
        End Select

        ' 5) Hide the role selection form after opening the dashboard.
        Me.Hide()
    End Sub
End Class