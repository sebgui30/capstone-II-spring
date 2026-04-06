<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmITProvision
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
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnProvisionComplete = New System.Windows.Forms.Button()
        Me.lstSystems = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblStartDateValue = New System.Windows.Forms.Label()
        Me.lblDepartmentValue = New System.Windows.Forms.Label()
        Me.lblEmployeeValue = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(61, 303)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(0, 13)
        Me.lblMessage.TabIndex = 29
        '
        'btnProvisionComplete
        '
        Me.btnProvisionComplete.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnProvisionComplete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProvisionComplete.ForeColor = System.Drawing.Color.White
        Me.btnProvisionComplete.Location = New System.Drawing.Point(127, 331)
        Me.btnProvisionComplete.Name = "btnProvisionComplete"
        Me.btnProvisionComplete.Size = New System.Drawing.Size(130, 23)
        Me.btnProvisionComplete.TabIndex = 27
        Me.btnProvisionComplete.Text = "Provision Complete"
        Me.btnProvisionComplete.UseVisualStyleBackColor = False
        '
        'lstSystems
        '
        Me.lstSystems.FormattingEnabled = True
        Me.lstSystems.Location = New System.Drawing.Point(61, 176)
        Me.lstSystems.Name = "lstSystems"
        Me.lstSystems.Size = New System.Drawing.Size(265, 108)
        Me.lstSystems.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(58, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Requested Systems:"
        '
        'lblStartDateValue
        '
        Me.lblStartDateValue.BackColor = System.Drawing.Color.White
        Me.lblStartDateValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStartDateValue.Location = New System.Drawing.Point(151, 124)
        Me.lblStartDateValue.Name = "lblStartDateValue"
        Me.lblStartDateValue.Size = New System.Drawing.Size(175, 21)
        Me.lblStartDateValue.TabIndex = 24
        Me.lblStartDateValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDepartmentValue
        '
        Me.lblDepartmentValue.BackColor = System.Drawing.Color.White
        Me.lblDepartmentValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDepartmentValue.Location = New System.Drawing.Point(151, 90)
        Me.lblDepartmentValue.Name = "lblDepartmentValue"
        Me.lblDepartmentValue.Size = New System.Drawing.Size(175, 21)
        Me.lblDepartmentValue.TabIndex = 23
        Me.lblDepartmentValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployeeValue
        '
        Me.lblEmployeeValue.BackColor = System.Drawing.Color.White
        Me.lblEmployeeValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmployeeValue.Location = New System.Drawing.Point(151, 56)
        Me.lblEmployeeValue.Name = "lblEmployeeValue"
        Me.lblEmployeeValue.Size = New System.Drawing.Size(175, 21)
        Me.lblEmployeeValue.TabIndex = 22
        Me.lblEmployeeValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(58, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Start Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Department:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Employee Name:"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(322, 15)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(50, 27)
        Me.btnClose.TabIndex = 18
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(12, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(360, 34)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "IT Provision Details"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(61, 296)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(272, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Review the requested systems and mark provisioning as "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(113, 310)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(159, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "complete when setup is finished."
        '
        'frmITProvision
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 361)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnProvisionComplete)
        Me.Controls.Add(Me.lstSystems)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblStartDateValue)
        Me.Controls.Add(Me.lblDepartmentValue)
        Me.Controls.Add(Me.lblEmployeeValue)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmITProvision"
        Me.Text = "frmITProvision"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMessage As Label
    Friend WithEvents btnProvisionComplete As Button
    Friend WithEvents lstSystems As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblStartDateValue As Label
    Friend WithEvents lblDepartmentValue As Label
    Friend WithEvents lblEmployeeValue As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
