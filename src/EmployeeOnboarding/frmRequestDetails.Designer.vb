<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRequestDetails
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblEmployeeValue = New System.Windows.Forms.Label()
        Me.lblDepartmentValue = New System.Windows.Forms.Label()
        Me.lblStartDateValue = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lstSystems = New System.Windows.Forms.ListBox()
        Me.btnApprove = New System.Windows.Forms.Button()
        Me.btnReject = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(360, 34)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Onboarding Request Details"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(322, 9)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(50, 27)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Employee Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Department:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(58, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Start Date:"
        '
        'lblEmployeeValue
        '
        Me.lblEmployeeValue.BackColor = System.Drawing.Color.White
        Me.lblEmployeeValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmployeeValue.Location = New System.Drawing.Point(151, 56)
        Me.lblEmployeeValue.Name = "lblEmployeeValue"
        Me.lblEmployeeValue.Size = New System.Drawing.Size(175, 21)
        Me.lblEmployeeValue.TabIndex = 9
        Me.lblEmployeeValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDepartmentValue
        '
        Me.lblDepartmentValue.BackColor = System.Drawing.Color.White
        Me.lblDepartmentValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDepartmentValue.Location = New System.Drawing.Point(151, 90)
        Me.lblDepartmentValue.Name = "lblDepartmentValue"
        Me.lblDepartmentValue.Size = New System.Drawing.Size(175, 21)
        Me.lblDepartmentValue.TabIndex = 10
        Me.lblDepartmentValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStartDateValue
        '
        Me.lblStartDateValue.BackColor = System.Drawing.Color.White
        Me.lblStartDateValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStartDateValue.Location = New System.Drawing.Point(151, 124)
        Me.lblStartDateValue.Name = "lblStartDateValue"
        Me.lblStartDateValue.Size = New System.Drawing.Size(175, 21)
        Me.lblStartDateValue.TabIndex = 11
        Me.lblStartDateValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(58, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Requested Systems:"
        '
        'lstSystems
        '
        Me.lstSystems.FormattingEnabled = True
        Me.lstSystems.Location = New System.Drawing.Point(61, 182)
        Me.lstSystems.Name = "lstSystems"
        Me.lstSystems.Size = New System.Drawing.Size(265, 108)
        Me.lstSystems.TabIndex = 13
        '
        'btnApprove
        '
        Me.btnApprove.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnApprove.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApprove.ForeColor = System.Drawing.Color.White
        Me.btnApprove.Location = New System.Drawing.Point(60, 317)
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Size = New System.Drawing.Size(130, 23)
        Me.btnApprove.TabIndex = 14
        Me.btnApprove.Text = "Approve Request"
        Me.btnApprove.UseVisualStyleBackColor = False
        '
        'btnReject
        '
        Me.btnReject.BackColor = System.Drawing.Color.Goldenrod
        Me.btnReject.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReject.ForeColor = System.Drawing.Color.White
        Me.btnReject.Location = New System.Drawing.Point(196, 317)
        Me.btnReject.Name = "btnReject"
        Me.btnReject.Size = New System.Drawing.Size(130, 23)
        Me.btnReject.TabIndex = 15
        Me.btnReject.Text = "Reject Request"
        Me.btnReject.UseVisualStyleBackColor = False
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(61, 297)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(0, 13)
        Me.lblMessage.TabIndex = 16
        '
        'frmRequestDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(384, 361)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnReject)
        Me.Controls.Add(Me.btnApprove)
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
        Me.Name = "frmRequestDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Onboarding Request Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblEmployeeValue As Label
    Friend WithEvents lblDepartmentValue As Label
    Friend WithEvents lblStartDateValue As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lstSystems As ListBox
    Friend WithEvents btnApprove As Button
    Friend WithEvents btnReject As Button
    Friend WithEvents lblMessage As Label
End Class
