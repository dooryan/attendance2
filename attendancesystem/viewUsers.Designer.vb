<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class viewUsers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateCreated = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.uname, Me.fname, Me.lname, Me.dateCreated})
        Me.DataGridView1.Location = New System.Drawing.Point(16, 25)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(546, 388)
        Me.DataGridView1.TabIndex = 0
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        '
        'uname
        '
        Me.uname.HeaderText = "Username"
        Me.uname.Name = "uname"
        '
        'fname
        '
        Me.fname.HeaderText = "First name"
        Me.fname.Name = "fname"
        '
        'lname
        '
        Me.lname.HeaderText = "Last name"
        Me.lname.Name = "lname"
        '
        'dateCreated
        '
        Me.dateCreated.HeaderText = "Date Created"
        Me.dateCreated.Name = "dateCreated"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(11, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(584, 428)
        Me.Panel1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.DarkRed
        Me.Button1.Location = New System.Drawing.Point(503, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 20)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Delete"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'viewUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.attendancesystem.My.Resources.Resources.beautiful_color_ui_gradients_backgrounds_frost
        Me.ClientSize = New System.Drawing.Size(607, 470)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "viewUsers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "All Users"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents uname As DataGridViewTextBoxColumn
    Friend WithEvents fname As DataGridViewTextBoxColumn
    Friend WithEvents lname As DataGridViewTextBoxColumn
    Friend WithEvents dateCreated As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
End Class
