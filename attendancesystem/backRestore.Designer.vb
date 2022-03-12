<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class backRestore
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
        Me.btnBackuo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRestore = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'btnBackuo
        '
        Me.btnBackuo.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnBackuo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBackuo.Font = New System.Drawing.Font("Segoe MDL2 Assets", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackuo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBackuo.Location = New System.Drawing.Point(79, 166)
        Me.btnBackuo.Name = "btnBackuo"
        Me.btnBackuo.Size = New System.Drawing.Size(149, 56)
        Me.btnBackuo.TabIndex = 1
        Me.btnBackuo.Text = "Back Up"
        Me.btnBackuo.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(151, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Back-up or restore your Database."
        '
        'btnRestore
        '
        Me.btnRestore.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestore.Font = New System.Drawing.Font("Segoe MDL2 Assets", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestore.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnRestore.Location = New System.Drawing.Point(360, 166)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(149, 56)
        Me.btnRestore.TabIndex = 4
        Me.btnRestore.Text = "Restore"
        Me.btnRestore.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(178, 119)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(236, 27)
        Me.ProgressBar1.TabIndex = 5
        '
        'backRestore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 334)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnRestore)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBackuo)
        Me.Name = "backRestore"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "backRestore"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBackuo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRestore As Button
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
