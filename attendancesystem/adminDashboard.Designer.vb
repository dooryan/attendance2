﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminDashboard
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminDashboard))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddPayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PayRecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WagesDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTotalEmp1 = New System.Windows.Forms.Label()
        Me.ffff = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblontime = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblpresent = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblLate = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.ViewUsersToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel10.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Cambria", 23.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label15.Location = New System.Drawing.Point(-55, -50)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(756, 36)
        Me.Label15.TabIndex = 36
        Me.Label15.Text = "Laak Banana Employees Multi-Purpose Cooperative "
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Gray
        Me.Panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel10.Controls.Add(Me.Panel9)
        Me.Panel10.Location = New System.Drawing.Point(20, 24)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(756, 412)
        Me.Panel10.TabIndex = 38
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.White
        Me.Panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel9.Controls.Add(Me.Button3)
        Me.Panel9.Controls.Add(Me.MenuStrip1)
        Me.Panel9.Controls.Add(Me.Panel8)
        Me.Panel9.Controls.Add(Me.Panel13)
        Me.Panel9.Location = New System.Drawing.Point(8, 9)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(741, 396)
        Me.Panel9.TabIndex = 33
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(52, 346)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(79, 32)
        Me.Button3.TabIndex = 33
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Snow
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserToolStripMenuItem, Me.ToolStripMenuItem1, Me.LogOutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 1)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(280, 28)
        Me.MenuStrip1.TabIndex = 32
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewUsersToolStripMenuItem1})
        Me.UserToolStripMenuItem.Enabled = False
        Me.UserToolStripMenuItem.Font = New System.Drawing.Font("Trebuchet MS", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(135, 24)
        Me.UserToolStripMenuItem.Text = "Manage Accounts"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddPayToolStripMenuItem, Me.PayRecordsToolStripMenuItem, Me.WagesDetailsToolStripMenuItem})
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Trebuchet MS", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(63, 24)
        Me.ToolStripMenuItem1.Text = "Payroll"
        '
        'AddPayToolStripMenuItem
        '
        Me.AddPayToolStripMenuItem.Name = "AddPayToolStripMenuItem"
        Me.AddPayToolStripMenuItem.Size = New System.Drawing.Size(169, 24)
        Me.AddPayToolStripMenuItem.Text = "Add Pay"
        '
        'PayRecordsToolStripMenuItem
        '
        Me.PayRecordsToolStripMenuItem.Name = "PayRecordsToolStripMenuItem"
        Me.PayRecordsToolStripMenuItem.Size = New System.Drawing.Size(169, 24)
        Me.PayRecordsToolStripMenuItem.Text = "Pay Records"
        '
        'WagesDetailsToolStripMenuItem
        '
        Me.WagesDetailsToolStripMenuItem.Name = "WagesDetailsToolStripMenuItem"
        Me.WagesDetailsToolStripMenuItem.Size = New System.Drawing.Size(169, 24)
        Me.WagesDetailsToolStripMenuItem.Text = "Wages Details"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Font = New System.Drawing.Font("Trebuchet MS", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOutToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(74, 24)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.SlateGray
        Me.Panel8.Controls.Add(Me.Label2)
        Me.Panel8.Controls.Add(Me.Panel2)
        Me.Panel8.Controls.Add(Me.ffff)
        Me.Panel8.Controls.Add(Me.Panel7)
        Me.Panel8.Controls.Add(Me.Panel11)
        Me.Panel8.Controls.Add(Me.Panel12)
        Me.Panel8.Location = New System.Drawing.Point(177, 29)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(538, 349)
        Me.Panel8.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(186, 27)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(333, 49)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Welcome, Admin!"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.lblTotalEmp1)
        Me.Panel2.Location = New System.Drawing.Point(290, 199)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(214, 98)
        Me.Panel2.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(84, 64)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "TOTAL Employees"
        '
        'lblTotalEmp1
        '
        Me.lblTotalEmp1.AutoSize = True
        Me.lblTotalEmp1.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalEmp1.CausesValidation = False
        Me.lblTotalEmp1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalEmp1.ForeColor = System.Drawing.Color.White
        Me.lblTotalEmp1.Location = New System.Drawing.Point(169, 11)
        Me.lblTotalEmp1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotalEmp1.Name = "lblTotalEmp1"
        Me.lblTotalEmp1.Size = New System.Drawing.Size(41, 44)
        Me.lblTotalEmp1.TabIndex = 4
        Me.lblTotalEmp1.Text = "0"
        '
        'ffff
        '
        Me.ffff.AutoSize = True
        Me.ffff.BackColor = System.Drawing.Color.Transparent
        Me.ffff.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ffff.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.ffff.Location = New System.Drawing.Point(302, 1)
        Me.ffff.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ffff.Name = "ffff"
        Me.ffff.Size = New System.Drawing.Size(50, 24)
        Me.ffff.TabIndex = 21
        Me.ffff.Text = "date"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.Label11)
        Me.Panel7.Controls.Add(Me.lblontime)
        Me.Panel7.Location = New System.Drawing.Point(188, 87)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(156, 93)
        Me.Panel7.TabIndex = 18
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(20, 68)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 20)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "ON TIME"
        '
        'lblontime
        '
        Me.lblontime.AutoSize = True
        Me.lblontime.BackColor = System.Drawing.Color.Transparent
        Me.lblontime.CausesValidation = False
        Me.lblontime.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblontime.ForeColor = System.Drawing.Color.White
        Me.lblontime.Location = New System.Drawing.Point(2, 11)
        Me.lblontime.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblontime.Name = "lblontime"
        Me.lblontime.Size = New System.Drawing.Size(41, 44)
        Me.lblontime.TabIndex = 4
        Me.lblontime.Text = "0"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Panel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel11.Controls.Add(Me.Label12)
        Me.Panel11.Controls.Add(Me.lblpresent)
        Me.Panel11.Location = New System.Drawing.Point(14, 87)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(154, 93)
        Me.Panel11.TabIndex = 16
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(17, 68)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(102, 20)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "ALL PRESENT"
        '
        'lblpresent
        '
        Me.lblpresent.AutoSize = True
        Me.lblpresent.BackColor = System.Drawing.Color.Transparent
        Me.lblpresent.CausesValidation = False
        Me.lblpresent.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpresent.ForeColor = System.Drawing.Color.White
        Me.lblpresent.Location = New System.Drawing.Point(2, 11)
        Me.lblpresent.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblpresent.Name = "lblpresent"
        Me.lblpresent.Size = New System.Drawing.Size(41, 44)
        Me.lblpresent.TabIndex = 4
        Me.lblpresent.Text = "0"
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel12.Controls.Add(Me.Label14)
        Me.Panel12.Controls.Add(Me.lblLate)
        Me.Panel12.Location = New System.Drawing.Point(355, 87)
        Me.Panel12.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(149, 93)
        Me.Panel12.TabIndex = 17
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Trebuchet MS", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(20, 68)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 20)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "LATE"
        '
        'lblLate
        '
        Me.lblLate.AutoSize = True
        Me.lblLate.BackColor = System.Drawing.Color.Transparent
        Me.lblLate.CausesValidation = False
        Me.lblLate.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLate.ForeColor = System.Drawing.Color.White
        Me.lblLate.Location = New System.Drawing.Point(2, 11)
        Me.lblLate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLate.Name = "lblLate"
        Me.lblLate.Size = New System.Drawing.Size(41, 44)
        Me.lblLate.TabIndex = 4
        Me.lblLate.Text = "0"
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel13.Controls.Add(Me.Button2)
        Me.Panel13.Controls.Add(Me.Button1)
        Me.Panel13.Controls.Add(Me.Button9)
        Me.Panel13.Location = New System.Drawing.Point(8, 81)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(161, 245)
        Me.Panel13.TabIndex = 23
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Gray
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Trebuchet MS", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Wheat
        Me.Button2.Location = New System.Drawing.Point(7, 162)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(148, 70)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "Daily Records"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Wheat
        Me.Button1.Location = New System.Drawing.Point(7, 86)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 70)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Employees"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Gray
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button9.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.Wheat
        Me.Button9.Location = New System.Drawing.Point(7, 11)
        Me.Button9.Margin = New System.Windows.Forms.Padding(2)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(148, 70)
        Me.Button9.TabIndex = 26
        Me.Button9.Text = "Dashboard"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'ViewUsersToolStripMenuItem1
        '
        Me.ViewUsersToolStripMenuItem1.Name = "ViewUsersToolStripMenuItem1"
        Me.ViewUsersToolStripMenuItem1.Size = New System.Drawing.Size(152, 24)
        Me.ViewUsersToolStripMenuItem1.Text = "View Users"
        '
        'adminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(796, 462)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Label15)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "adminDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Attendance System"
        Me.Panel10.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AddPayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PayRecordsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTotalEmp1 As Label
    Friend WithEvents ffff As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents lblontime As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents lblpresent As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents lblLate As Label
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Button9 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents WagesDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button3 As Button
    Friend WithEvents ViewUsersToolStripMenuItem1 As ToolStripMenuItem
End Class
