<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHRdashboard
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
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnCreateRequest = New System.Windows.Forms.Button()
        Me.dgvRequests = New System.Windows.Forms.DataGridView()
        CType(Me.dgvRequests, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "HR Dashboard"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(472, 14)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(86, 48)
        Me.btnLogout.TabIndex = 3
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnCreateRequest
        '
        Me.btnCreateRequest.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateRequest.ForeColor = System.Drawing.Color.Goldenrod
        Me.btnCreateRequest.Location = New System.Drawing.Point(93, 106)
        Me.btnCreateRequest.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCreateRequest.Name = "btnCreateRequest"
        Me.btnCreateRequest.Size = New System.Drawing.Size(392, 35)
        Me.btnCreateRequest.TabIndex = 4
        Me.btnCreateRequest.Text = "+ Create Onboarding Request"
        Me.btnCreateRequest.UseVisualStyleBackColor = True
        '
        'dgvRequests
        '
        Me.dgvRequests.AllowUserToAddRows = False
        Me.dgvRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRequests.Location = New System.Drawing.Point(42, 178)
        Me.dgvRequests.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvRequests.Name = "dgvRequests"
        Me.dgvRequests.ReadOnly = True
        Me.dgvRequests.RowHeadersWidth = 62
        Me.dgvRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRequests.Size = New System.Drawing.Size(494, 275)
        Me.dgvRequests.TabIndex = 5
        '
        'frmHRdashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(576, 555)
        Me.Controls.Add(Me.dgvRequests)
        Me.Controls.Add(Me.btnCreateRequest)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.Label2)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmHRdashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "HR Dashboard"
        CType(Me.dgvRequests, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnCreateRequest As Button
    Friend WithEvents dgvRequests As DataGridView
End Class
