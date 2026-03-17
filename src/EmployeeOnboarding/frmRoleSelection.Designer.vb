<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRoleSelection
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpRole = New System.Windows.Forms.GroupBox()
        Me.radIT = New System.Windows.Forms.RadioButton()
        Me.radManager = New System.Windows.Forms.RadioButton()
        Me.radHR = New System.Windows.Forms.RadioButton()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.grpRole.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(18, 14)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(540, 52)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Employee Onboarding and IT Access Portal"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpRole
        '
        Me.grpRole.Controls.Add(Me.radIT)
        Me.grpRole.Controls.Add(Me.radManager)
        Me.grpRole.Controls.Add(Me.radHR)
        Me.grpRole.Location = New System.Drawing.Point(111, 94)
        Me.grpRole.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpRole.Name = "grpRole"
        Me.grpRole.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpRole.Size = New System.Drawing.Size(356, 246)
        Me.grpRole.TabIndex = 2
        Me.grpRole.TabStop = False
        Me.grpRole.Text = "Select your role"
        '
        'radIT
        '
        Me.radIT.AutoSize = True
        Me.radIT.Location = New System.Drawing.Point(44, 165)
        Me.radIT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.radIT.Name = "radIT"
        Me.radIT.Size = New System.Drawing.Size(48, 24)
        Me.radIT.TabIndex = 2
        Me.radIT.TabStop = True
        Me.radIT.Text = "IT"
        Me.radIT.UseVisualStyleBackColor = True
        '
        'radManager
        '
        Me.radManager.AutoSize = True
        Me.radManager.Location = New System.Drawing.Point(44, 109)
        Me.radManager.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.radManager.Name = "radManager"
        Me.radManager.Size = New System.Drawing.Size(97, 24)
        Me.radManager.TabIndex = 1
        Me.radManager.TabStop = True
        Me.radManager.Text = "Manager"
        Me.radManager.UseVisualStyleBackColor = True
        '
        'radHR
        '
        Me.radHR.AutoSize = True
        Me.radHR.Location = New System.Drawing.Point(44, 54)
        Me.radHR.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.radHR.Name = "radHR"
        Me.radHR.Size = New System.Drawing.Size(58, 24)
        Me.radHR.TabIndex = 0
        Me.radHR.TabStop = True
        Me.radHR.Text = "HR"
        Me.radHR.UseVisualStyleBackColor = True
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnEnter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.ForeColor = System.Drawing.Color.White
        Me.btnEnter.Location = New System.Drawing.Point(111, 368)
        Me.btnEnter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(356, 45)
        Me.btnEnter.TabIndex = 3
        Me.btnEnter.Text = "Enter Dashboard"
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'frmRoleSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(576, 555)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.grpRole)
        Me.Controls.Add(Me.Label2)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmRoleSelection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Onboarding and IT Access Portal"
        Me.grpRole.ResumeLayout(False)
        Me.grpRole.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents grpRole As GroupBox
    Friend WithEvents radIT As RadioButton
    Friend WithEvents radManager As RadioButton
    Friend WithEvents radHR As RadioButton
    Friend WithEvents btnEnter As Button
End Class
