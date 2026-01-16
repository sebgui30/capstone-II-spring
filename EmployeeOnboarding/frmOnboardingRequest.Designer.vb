<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployeeOnboarding
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.cboDepartment = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkEmail = New System.Windows.Forms.CheckBox()
        Me.chkVPN = New System.Windows.Forms.CheckBox()
        Me.chkPayroll = New System.Windows.Forms.CheckBox()
        Me.chkGitAccess = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(85, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Department:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(92, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Start Date:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(85, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Required Systems:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(159, 56)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(163, 20)
        Me.txtName.TabIndex = 0
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStartDate.Location = New System.Drawing.Point(159, 84)
        Me.dtpStartDate.MaxDate = New Date(3100, 12, 31, 0, 0, 0, 0)
        Me.dtpStartDate.MinDate = New Date(2026, 1, 1, 0, 0, 0, 0)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(163, 20)
        Me.dtpStartDate.TabIndex = 4
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(317, 8)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(55, 27)
        Me.btnBack.TabIndex = 6
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(128, 312)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(129, 25)
        Me.btnSubmit.TabIndex = 5
        Me.btnSubmit.Text = "Submit Request"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'cboDepartment
        '
        Me.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDepartment.FormattingEnabled = True
        Me.cboDepartment.Location = New System.Drawing.Point(159, 118)
        Me.cboDepartment.Name = "cboDepartment"
        Me.cboDepartment.Size = New System.Drawing.Size(163, 21)
        Me.cboDepartment.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label6.Location = New System.Drawing.Point(74, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(237, 27)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Employee Onboarding Portal"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkEmail
        '
        Me.chkEmail.AutoSize = True
        Me.chkEmail.Location = New System.Drawing.Point(88, 202)
        Me.chkEmail.Name = "chkEmail"
        Me.chkEmail.Size = New System.Drawing.Size(51, 17)
        Me.chkEmail.TabIndex = 18
        Me.chkEmail.Text = "Email"
        Me.chkEmail.UseVisualStyleBackColor = True
        '
        'chkVPN
        '
        Me.chkVPN.AutoSize = True
        Me.chkVPN.Location = New System.Drawing.Point(88, 226)
        Me.chkVPN.Name = "chkVPN"
        Me.chkVPN.Size = New System.Drawing.Size(48, 17)
        Me.chkVPN.TabIndex = 19
        Me.chkVPN.Text = "VPN"
        Me.chkVPN.UseVisualStyleBackColor = True
        '
        'chkPayroll
        '
        Me.chkPayroll.AutoSize = True
        Me.chkPayroll.Location = New System.Drawing.Point(88, 250)
        Me.chkPayroll.Name = "chkPayroll"
        Me.chkPayroll.Size = New System.Drawing.Size(57, 17)
        Me.chkPayroll.TabIndex = 20
        Me.chkPayroll.Text = "Payroll"
        Me.chkPayroll.UseVisualStyleBackColor = True
        '
        'chkGitAccess
        '
        Me.chkGitAccess.AutoSize = True
        Me.chkGitAccess.Location = New System.Drawing.Point(88, 274)
        Me.chkGitAccess.Name = "chkGitAccess"
        Me.chkGitAccess.Size = New System.Drawing.Size(111, 17)
        Me.chkGitAccess.TabIndex = 21
        Me.chkGitAccess.Text = "Git/ Repo Access"
        Me.chkGitAccess.UseVisualStyleBackColor = True
        '
        'frmEmployeeOnboarding
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(384, 361)
        Me.Controls.Add(Me.chkGitAccess)
        Me.Controls.Add(Me.chkPayroll)
        Me.Controls.Add(Me.chkVPN)
        Me.Controls.Add(Me.chkEmail)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboDepartment)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.dtpStartDate)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmEmployeeOnboarding"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create Onboarding Request"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents btnBack As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents cboDepartment As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents chkEmail As CheckBox
    Friend WithEvents chkVPN As CheckBox
    Friend WithEvents chkPayroll As CheckBox
    Friend WithEvents chkGitAccess As CheckBox
End Class
