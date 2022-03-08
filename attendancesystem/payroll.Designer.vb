<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class payroll
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtHoliday = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtOTPay = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtttlpay = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtMonthly = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtBasicRate = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtHourlyRate = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtTtlDeductions = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtpagibig = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSSS = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPhil = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtHolidayHous = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtOvertime = New System.Windows.Forms.TextBox()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.txtTotalPay = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.DateTimePicker4 = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.id1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ttime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.days = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(9, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1025, 630)
        Me.TabControl1.TabIndex = 38
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label23)
        Me.TabPage1.Controls.Add(Me.Panel4)
        Me.TabPage1.Controls.Add(Me.txtName)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1017, 604)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Payroll"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(24, 16)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(159, 26)
        Me.Label23.TabIndex = 36
        Me.Label23.Text = "Payroll Overview"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel4.Controls.Add(Me.Label19)
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.Panel3)
        Me.Panel4.Controls.Add(Me.Panel2)
        Me.Panel4.Controls.Add(Me.Panel1)
        Me.Panel4.Controls.Add(Me.txtTotalPay)
        Me.Panel4.Location = New System.Drawing.Point(1, 54)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1016, 545)
        Me.Panel4.TabIndex = 35
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(542, 404)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(81, 23)
        Me.Label19.TabIndex = 38
        Me.Label19.Text = "Net Pay"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Controls.Add(Me.Label9)
        Me.Panel6.Controls.Add(Me.txtHoliday)
        Me.Panel6.Controls.Add(Me.Label18)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.txtOTPay)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Controls.Add(Me.txtttlpay)
        Me.Panel6.Location = New System.Drawing.Point(0, 146)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1015, 95)
        Me.Panel6.TabIndex = 37
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label9.Location = New System.Drawing.Point(457, 15)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 15)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Holiday pay"
        '
        'txtHoliday
        '
        Me.txtHoliday.BackColor = System.Drawing.SystemColors.Window
        Me.txtHoliday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoliday.ForeColor = System.Drawing.Color.Black
        Me.txtHoliday.Location = New System.Drawing.Point(420, 43)
        Me.txtHoliday.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHoliday.Name = "txtHoliday"
        Me.txtHoliday.Size = New System.Drawing.Size(139, 26)
        Me.txtHoliday.TabIndex = 44
        Me.txtHoliday.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label18.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label18.Location = New System.Drawing.Point(96, 15)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(111, 15)
        Me.Label18.TabIndex = 43
        Me.Label18.Text = "Total Overtime pay"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Black", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 80)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 15)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Less Deductions"
        '
        'txtOTPay
        '
        Me.txtOTPay.BackColor = System.Drawing.SystemColors.Window
        Me.txtOTPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOTPay.ForeColor = System.Drawing.Color.Black
        Me.txtOTPay.Location = New System.Drawing.Point(83, 43)
        Me.txtOTPay.Margin = New System.Windows.Forms.Padding(2)
        Me.txtOTPay.Name = "txtOTPay"
        Me.txtOTPay.Size = New System.Drawing.Size(144, 26)
        Me.txtOTPay.TabIndex = 42
        Me.txtOTPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label4.Location = New System.Drawing.Point(735, 15)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 15)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "TOTAL SALARY"
        '
        'txtttlpay
        '
        Me.txtttlpay.BackColor = System.Drawing.SystemColors.Window
        Me.txtttlpay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtttlpay.ForeColor = System.Drawing.Color.Black
        Me.txtttlpay.Location = New System.Drawing.Point(713, 43)
        Me.txtttlpay.Margin = New System.Windows.Forms.Padding(2)
        Me.txtttlpay.Name = "txtttlpay"
        Me.txtttlpay.Size = New System.Drawing.Size(136, 26)
        Me.txtttlpay.TabIndex = 40
        Me.txtttlpay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.txtMonthly)
        Me.Panel5.Controls.Add(Me.Label16)
        Me.Panel5.Controls.Add(Me.txtBasicRate)
        Me.Panel5.Controls.Add(Me.Label15)
        Me.Panel5.Controls.Add(Me.txtHourlyRate)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(Me.Label14)
        Me.Panel5.Location = New System.Drawing.Point(-3, 309)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1018, 73)
        Me.Panel5.TabIndex = 36
        '
        'txtMonthly
        '
        Me.txtMonthly.BackColor = System.Drawing.SystemColors.Window
        Me.txtMonthly.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtMonthly.Location = New System.Drawing.Point(716, 37)
        Me.txtMonthly.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMonthly.Name = "txtMonthly"
        Me.txtMonthly.Size = New System.Drawing.Size(139, 26)
        Me.txtMonthly.TabIndex = 31
        Me.txtMonthly.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label16.Location = New System.Drawing.Point(733, 16)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(104, 15)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "Monthly Basic Pay"
        '
        'txtBasicRate
        '
        Me.txtBasicRate.BackColor = System.Drawing.SystemColors.Window
        Me.txtBasicRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtBasicRate.Location = New System.Drawing.Point(418, 37)
        Me.txtBasicRate.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBasicRate.Name = "txtBasicRate"
        Me.txtBasicRate.Size = New System.Drawing.Size(139, 26)
        Me.txtBasicRate.TabIndex = 29
        Me.txtBasicRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label15.Location = New System.Drawing.Point(455, 16)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 15)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Basic Rate"
        '
        'txtHourlyRate
        '
        Me.txtHourlyRate.BackColor = System.Drawing.SystemColors.Window
        Me.txtHourlyRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtHourlyRate.Location = New System.Drawing.Point(85, 37)
        Me.txtHourlyRate.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHourlyRate.Name = "txtHourlyRate"
        Me.txtHourlyRate.Size = New System.Drawing.Size(140, 26)
        Me.txtHourlyRate.TabIndex = 27
        Me.txtHourlyRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(101, 16)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 15)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Hourly Rate"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(26, 7)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 14)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "INCOME"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.txtTtlDeductions)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.txtpagibig)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.txtSSS)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.txtPhil)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Location = New System.Drawing.Point(-1, 239)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1017, 71)
        Me.Panel3.TabIndex = 34
        '
        'txtTtlDeductions
        '
        Me.txtTtlDeductions.BackColor = System.Drawing.Color.Tan
        Me.txtTtlDeductions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTtlDeductions.Location = New System.Drawing.Point(105, 190)
        Me.txtTtlDeductions.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTtlDeductions.Name = "txtTtlDeductions"
        Me.txtTtlDeductions.Size = New System.Drawing.Size(132, 26)
        Me.txtTtlDeductions.TabIndex = 25
        Me.txtTtlDeductions.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 173)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 15)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "TOTAL DEDUCTIONS"
        '
        'txtpagibig
        '
        Me.txtpagibig.BackColor = System.Drawing.SystemColors.Window
        Me.txtpagibig.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpagibig.Location = New System.Drawing.Point(421, 37)
        Me.txtpagibig.Margin = New System.Windows.Forms.Padding(2)
        Me.txtpagibig.Name = "txtpagibig"
        Me.txtpagibig.Size = New System.Drawing.Size(139, 26)
        Me.txtpagibig.TabIndex = 22
        Me.txtpagibig.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(466, 12)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 15)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Pag-ibig"
        '
        'txtSSS
        '
        Me.txtSSS.BackColor = System.Drawing.SystemColors.Window
        Me.txtSSS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSSS.Location = New System.Drawing.Point(714, 33)
        Me.txtSSS.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSSS.Name = "txtSSS"
        Me.txtSSS.Size = New System.Drawing.Size(136, 26)
        Me.txtSSS.TabIndex = 20
        Me.txtSSS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(776, 12)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(25, 15)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "SSS"
        '
        'txtPhil
        '
        Me.txtPhil.BackColor = System.Drawing.SystemColors.Window
        Me.txtPhil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhil.Location = New System.Drawing.Point(85, 34)
        Me.txtPhil.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPhil.Name = "txtPhil"
        Me.txtPhil.Size = New System.Drawing.Size(143, 26)
        Me.txtPhil.TabIndex = 18
        Me.txtPhil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(121, 12)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 15)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Philhealth"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.txtHolidayHous)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.txtOvertime)
        Me.Panel2.Controls.Add(Me.txtHours)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(0, 63)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1014, 87)
        Me.Panel2.TabIndex = 33
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label13.Location = New System.Drawing.Point(723, 11)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(111, 15)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "Total Holiday Hours"
        '
        'txtHolidayHous
        '
        Me.txtHolidayHous.BackColor = System.Drawing.Color.White
        Me.txtHolidayHous.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHolidayHous.ForeColor = System.Drawing.Color.Black
        Me.txtHolidayHous.Location = New System.Drawing.Point(713, 40)
        Me.txtHolidayHous.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHolidayHous.Name = "txtHolidayHous"
        Me.txtHolidayHous.Size = New System.Drawing.Size(136, 26)
        Me.txtHolidayHous.TabIndex = 38
        Me.txtHolidayHous.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label17.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label17.Location = New System.Drawing.Point(449, 11)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(85, 15)
        Me.Label17.TabIndex = 37
        Me.Label17.Text = "Total OT hours"
        '
        'txtOvertime
        '
        Me.txtOvertime.BackColor = System.Drawing.SystemColors.Window
        Me.txtOvertime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOvertime.ForeColor = System.Drawing.Color.Black
        Me.txtOvertime.Location = New System.Drawing.Point(420, 40)
        Me.txtOvertime.Margin = New System.Windows.Forms.Padding(2)
        Me.txtOvertime.Name = "txtOvertime"
        Me.txtOvertime.Size = New System.Drawing.Size(139, 26)
        Me.txtOvertime.TabIndex = 36
        Me.txtOvertime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtHours
        '
        Me.txtHours.BackColor = System.Drawing.Color.White
        Me.txtHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHours.ForeColor = System.Drawing.Color.Black
        Me.txtHours.Location = New System.Drawing.Point(83, 40)
        Me.txtHours.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(144, 26)
        Me.txtHours.TabIndex = 13
        Me.txtHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(103, 11)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Total hours worked"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 76)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.btnFilter)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnPay)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1017, 64)
        Me.Panel1.TabIndex = 26
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(183, 12)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(83, 30)
        Me.ComboBox1.TabIndex = 29
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(499, 12)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(148, 28)
        Me.DateTimePicker2.TabIndex = 28
        Me.DateTimePicker2.Value = New Date(2022, 3, 8, 0, 0, 0, 0)
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(328, 12)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(148, 28)
        Me.DateTimePicker1.TabIndex = 27
        Me.DateTimePicker1.Value = New Date(2022, 3, 8, 0, 0, 0, 0)
        '
        'btnFilter
        '
        Me.btnFilter.BackColor = System.Drawing.Color.White
        Me.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFilter.Location = New System.Drawing.Point(660, 12)
        Me.btnFilter.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(44, 30)
        Me.btnFilter.TabIndex = 26
        Me.btnFilter.Text = "GO"
        Me.btnFilter.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee ID"
        '
        'btnPay
        '
        Me.btnPay.BackColor = System.Drawing.Color.IndianRed
        Me.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPay.Font = New System.Drawing.Font("Arial Black", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPay.ForeColor = System.Drawing.Color.White
        Me.btnPay.Location = New System.Drawing.Point(844, 17)
        Me.btnPay.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(146, 30)
        Me.btnPay.TabIndex = 23
        Me.btnPay.Text = "Generate Payroll"
        Me.btnPay.UseVisualStyleBackColor = False
        '
        'txtTotalPay
        '
        Me.txtTotalPay.BackColor = System.Drawing.Color.White
        Me.txtTotalPay.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotalPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPay.Location = New System.Drawing.Point(665, 392)
        Me.txtTotalPay.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTotalPay.Name = "txtTotalPay"
        Me.txtTotalPay.Size = New System.Drawing.Size(184, 39)
        Me.txtTotalPay.TabIndex = 27
        Me.txtTotalPay.Text = "0"
        Me.txtTotalPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtName.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(727, 17)
        Me.txtName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(273, 25)
        Me.txtName.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(723, 21)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 20)
        Me.Label2.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Panel7)
        Me.TabPage2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1017, 604)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Reports"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel7.Controls.Add(Me.Label20)
        Me.Panel7.Controls.Add(Me.Label21)
        Me.Panel7.Controls.Add(Me.Label22)
        Me.Panel7.Controls.Add(Me.Button2)
        Me.Panel7.Controls.Add(Me.DateTimePicker3)
        Me.Panel7.Controls.Add(Me.Button1)
        Me.Panel7.Controls.Add(Me.txtID)
        Me.Panel7.Controls.Add(Me.DateTimePicker4)
        Me.Panel7.Controls.Add(Me.DataGridView2)
        Me.Panel7.Location = New System.Drawing.Point(5, 5)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1006, 594)
        Me.Panel7.TabIndex = 19
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(346, 45)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(19, 15)
        Me.Label20.TabIndex = 8
        Me.Label20.Text = "To"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(346, 22)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(36, 15)
        Me.Label21.TabIndex = 7
        Me.Label21.Text = "From"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(45, 31)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(51, 15)
        Me.Label22.TabIndex = 6
        Me.Label22.Text = "Enter ID"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(842, 22)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(127, 46)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Generate Report"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Location = New System.Drawing.Point(381, 41)
        Me.DateTimePicker3.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(143, 23)
        Me.DateTimePicker3.TabIndex = 4
        Me.DateTimePicker3.Value = New Date(2021, 3, 22, 9, 50, 59, 0)
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(535, 18)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 45)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "GO"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(100, 29)
        Me.txtID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(191, 28)
        Me.txtID.TabIndex = 2
        '
        'DateTimePicker4
        '
        Me.DateTimePicker4.Location = New System.Drawing.Point(381, 18)
        Me.DateTimePicker4.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker4.Name = "DateTimePicker4"
        Me.DateTimePicker4.Size = New System.Drawing.Size(143, 23)
        Me.DateTimePicker4.TabIndex = 1
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id1, Me.DataGridViewTextBoxColumn1, Me.lname, Me.tdate, Me.ttime, Me.stat, Me.days})
        Me.DataGridView2.Location = New System.Drawing.Point(11, 124)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(980, 457)
        Me.DataGridView2.TabIndex = 0
        '
        'id1
        '
        Me.id1.HeaderText = "EMPLOYEE ID"
        Me.id1.Name = "id1"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'lname
        '
        Me.lname.HeaderText = "DATE"
        Me.lname.Name = "lname"
        '
        'tdate
        '
        Me.tdate.HeaderText = "GROSS PAY"
        Me.tdate.Name = "tdate"
        '
        'ttime
        '
        Me.ttime.HeaderText = "DEDUCTION"
        Me.ttime.Name = "ttime"
        '
        'stat
        '
        Me.stat.HeaderText = "NET PAY"
        Me.stat.Name = "stat"
        '
        'days
        '
        Me.days.HeaderText = "Total Working Hours"
        Me.days.Name = "days"
        '
        'payroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.attendancesystem.My.Resources.Resources.beautiful_color_ui_gradients_backgrounds_frost
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1038, 644)
        Me.Controls.Add(Me.TabControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "payroll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "  "
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents txtHoliday As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtOTPay As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtttlpay As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label19 As Label
    Friend WithEvents txtMonthly As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtBasicRate As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtHourlyRate As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTotalPay As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtTtlDeductions As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtpagibig As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtSSS As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtPhil As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents txtHolidayHous As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtOvertime As TextBox
    Friend WithEvents txtHours As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnFilter As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnPay As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents DateTimePicker4 As DateTimePicker
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents id1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents lname As DataGridViewTextBoxColumn
    Friend WithEvents tdate As DataGridViewTextBoxColumn
    Friend WithEvents ttime As DataGridViewTextBoxColumn
    Friend WithEvents stat As DataGridViewTextBoxColumn
    Friend WithEvents days As DataGridViewTextBoxColumn
    Friend WithEvents Label23 As Label
End Class
