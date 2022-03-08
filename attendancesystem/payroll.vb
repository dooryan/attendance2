Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data

Public Class payroll
    Dim totalHolidayHours = 0
    Public finalHoursTotal = 0
    Dim recordsExist = True


    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub payroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDatabaseConnection()
        ComboBox1.Items.Clear()

        prcDisplayTimesheet()

        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy/MM/dd"
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = "yyyy/MM/dd"


        Try
            dataAttendance = New DataTable()

            sqlAttendanceAdapter = New MySqlDataAdapter
            command.Connection = conAttendanceSystem
            With command
                .Parameters.Clear()
                .CommandText = "prcDisplayEmployeeID"
                .CommandType = CommandType.StoredProcedure
                sqlAttendanceAdapter.SelectCommand = command
                dataAttendance.Clear()
                sqlAttendanceAdapter.Fill(dataAttendance)

                sqlAttendanceAdapter.Fill(dataAttendance)
                ComboBox1.DataSource = dataAttendance
                ComboBox1.DisplayMember = "id"
                ComboBox1.ValueMember = "id"
            End With




            'sqlAttendanceAdapter.Dispose()
            'dataAttendance.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try


    End Sub
    Private Sub prcAutoSearch(ByVal searchType As String, ByVal strValue As String)
        sqlAttendanceAdapter = New MySqlDataAdapter
        dataAttendance = New DataTable
        Try
            With command
                .Parameters.Clear()
                .CommandText = "prcSearchPayHistoryAuto"
                .Parameters.AddWithValue("@p_searchtype", searchType)

                .CommandType = CommandType.StoredProcedure
                sqlAttendanceAdapter.SelectCommand = command
                dataAttendance.Clear()
                sqlAttendanceAdapter.Fill(dataAttendance)

                If dataAttendance.Rows.Count > 0 Then
                    DataGridView2.RowCount = dataAttendance.Rows.Count
                    row = 0
                    While Not dataAttendance.Rows.Count - 1 < row
                        With DataGridView2

                            .Rows(row).Cells(0).Value = dataAttendance.Rows(row).Item("emp_id").ToString
                            .Rows(row).Cells(1).Value = dataAttendance.Rows(row).Item("date").ToString

                            .Rows(row).Cells(2).Value = dataAttendance.Rows(row).Item("gross_pay").ToString
                            .Rows(row).Cells(3).Value = dataAttendance.Rows(row).Item("total_deduction").ToString
                            .Rows(row).Cells(4).Value = dataAttendance.Rows(row).Item("total_pay").ToString
                            .Rows(row).Cells(5).Value = dataAttendance.Rows(row).Item("total_hours").ToString

                        End With

                        row = row + 1
                    End While
                Else

                    DataGridView2.Rows.Clear()


                End If
                sqlAttendanceAdapter.Dispose()
                dataAttendance.Dispose()

            End With
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

    End Sub
    Private Sub prcDisplayTimesheet()

        dataAttendance = New DataTable()

        sqlAttendanceAdapter = New MySqlDataAdapter
        command.Connection = conAttendanceSystem
        Try
            With command
                .Parameters.Clear()
                .CommandText = "prcDisplayAllPayHistory"
                .CommandType = CommandType.StoredProcedure
                sqlAttendanceAdapter.SelectCommand = command
                dataAttendance.Clear()
                sqlAttendanceAdapter.Fill(dataAttendance)


                If dataAttendance.Rows.Count > 0 Then
                    DataGridView2.RowCount = dataAttendance.Rows.Count
                    Dim name As String = dataAttendance.Rows(row).Item("l_name").ToString & "," & dataAttendance.Rows(row).Item("f_name").ToString
                    row = 0
                    While Not dataAttendance.Rows.Count - 1 < row
                        With DataGridView2
                            ' .Rows(row).Cells(0).Value = dataAttendance.Rows(row).Item("id").ToString
                            .Rows(row).Cells(0).Value = dataAttendance.Rows(row).Item("emp_id").ToString
                            .Rows(row).Cells(1).Value = name
                            .Rows(row).Cells(2).Value = dataAttendance.Rows(row).Item("date").ToString

                            .Rows(row).Cells(3).Value = dataAttendance.Rows(row).Item("gross_pay").ToString
                            .Rows(row).Cells(4).Value = dataAttendance.Rows(row).Item("total_deduction").ToString
                            .Rows(row).Cells(5).Value = dataAttendance.Rows(row).Item("total_pay").ToString
                            '.Rows(row).Cells(6).Value = dataAttendance.Rows(row).Item("total_hours").ToString
                            .Rows(row).Cells(6).Value = dataAttendance.Rows(row).Item("day_period").ToString



                        End With
                        row = row + 1
                    End While
                Else




                End If
                sqlAttendanceAdapter.Dispose()
                dataAttendance.Dispose()
            End With
        Catch ex As Exception

        End Try
        Me.Refresh()
    End Sub
    Private Sub prcDisplayByAutoSearch(ByVal strValue As String)
        sqlAttendanceAdapter = New MySqlDataAdapter
        dataAttendance = New DataTable
        Try
            With command
                .Parameters.Clear()
                .CommandText = "prcSearchPayHistoryAuto"
                '.Parameters.AddWithValue("@p_searchtype", searchType)
                .Parameters.AddWithValue("p_value", strValue)
                .CommandType = CommandType.StoredProcedure
                sqlAttendanceAdapter.SelectCommand = command
                dataAttendance.Clear()
                sqlAttendanceAdapter.Fill(dataAttendance)

                If dataAttendance.Rows.Count > 0 Then
                    DataGridView2.RowCount = dataAttendance.Rows.Count
                    row = 0
                    While Not dataAttendance.Rows.Count - 1 < row
                        With DataGridView2

                            .Rows(row).Cells(0).Value = dataAttendance.Rows(row).Item("emp_id").ToString
                            .Rows(row).Cells(1).Value = dataAttendance.Rows(row).Item("date").ToString

                            .Rows(row).Cells(2).Value = dataAttendance.Rows(row).Item("gross_pay").ToString
                            .Rows(row).Cells(3).Value = dataAttendance.Rows(row).Item("total_deduction").ToString
                            .Rows(row).Cells(4).Value = dataAttendance.Rows(row).Item("total_pay").ToString
                            .Rows(row).Cells(5).Value = dataAttendance.Rows(row).Item("total_hours").ToString

                        End With

                        row = row + 1
                    End While
                Else

                    DataGridView2.Rows.Clear()


                End If
                sqlAttendanceAdapter.Dispose()
                dataAttendance.Dispose()

            End With
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

    End Sub
    Private Sub AddPay()
        Dim mes = MessageBox.Show("Confirm PAY?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If mes = vbYes Then
            Dim petsa = Date.Now.ToString("yyyy/MM/dd")
            Dim gross As Decimal = Val(txtttlpay.Text)
            Dim deduct As Decimal = Val(txtTtlDeductions.Text)
            Dim totalpay As Decimal = Val(txtTotalPay.Text)
            Dim hourstotal As Integer = txtHours.Text
            Dim id = ComboBox1.Text

            prcDisplayTimesheet()

            Try

                With command
                    .Parameters.Clear()
                    .CommandText = "prcInsertPay"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("i", id)
                    .Parameters.AddWithValue("date", petsa)
                    .Parameters.AddWithValue("gpay", gross)
                    .Parameters.AddWithValue("ttldeduction", deduct)
                    .Parameters.AddWithValue("ttlpay", totalpay)
                    .Parameters.AddWithValue("hours", hourstotal)
                    .Parameters.AddWithValue("days", finalHoursTotal)
                    .ExecuteNonQuery()




                End With

            Catch ex As Exception
                MessageBox.Show("" & ex.Message)

            End Try
        Else



        End If







    End Sub
    Private Sub DisplayPayDetails()
        Dim DA = New DataTable()
        Dim sqlAdapter = New MySqlDataAdapter
        Dim v = ComboBox1.SelectedItem
        'Dim LogQuery As String = "SELECT USERNAME, PASSWORD, USER_TYPE FROM tbl_user WHERE USERNAME=@USERNAME AND PASSWORD=@PASSWORD "
        Using con As MySqlConnection = New MySqlConnection("server=localhost;user id=root;password=hello;database=db_attendance")
            Using cmd As MySqlCommand = New MySqlCommand("", con)

                cmd.CommandText = "prcDisplayPayDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("i", ComboBox1.Text)
                sqlAdapter.SelectCommand = cmd
                DA.Clear()
                sqlAdapter.Fill(DA)



                'txtGrosspay.Text = Val(txtHours.Text) * CDec(DA(0)(1))
                txtHourlyRate.Text = DA.Rows(0).Item(1).ToString()
                txtPhil.Text = (CDec(DA.Rows(0).Item(4).ToString()) / 2) / 2
                txtSSS.Text = CDec(DA.Rows(0).Item(5).ToString()) / 2
                txtpagibig.Text = CDec(DA.Rows(0).Item(6).ToString()) / 2
                txtTtlDeductions.Text = Val(txtPhil.Text) + Val(txtSSS.Text) + Val(txtpagibig.Text)

                txtMonthly.Text = Val(((Val(txtHourlyRate.Text) * 48) * 52) / 12)
                txtBasicRate.Text = Val(txtMonthly.Text) / 2
                txtOTPay.Text = (Val(txtOvertime.Text) * Val(txtHourlyRate.Text)) * 1.25
                txtHoliday.Text = (totalHolidayHours * Val(txtHourlyRate.Text)) * 2
                txtttlpay.Text = (((Val(txtHours.Text)) * CDec(DA.Rows(0).Item(1).ToString()))) + Val(txtOTPay.Text) + Val(txtHoliday.Text)
                txtTotalPay.Text = Val(txtttlpay.Text) - Val(txtTtlDeductions.Text)
                txtHolidayHous.Text = totalHolidayHours


            End Using
        End Using

    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click

        DisplayPayDetails()
        getDaysCount()
        DisplayPayHistory()

        Dim DA = New DataTable()
        Dim sqlAdapter = New MySqlDataAdapter
        Dim v = ComboBox1.SelectedItem
        'Dim LogQuery As String = "SELECT USERNAME, PASSWORD, USER_TYPE FROM tbl_user WHERE USERNAME=@USERNAME AND PASSWORD=@PASSWORD "
        Using con As MySqlConnection = New MySqlConnection("server=localhost;user id=root;password=hello;database=db_attendance")
            Using cmd As MySqlCommand = New MySqlCommand("", con)

                cmd.CommandText = "prcSelectEmpName"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("aydi", ComboBox1.Text)
                sqlAdapter.SelectCommand = cmd
                DA.Clear()
                sqlAdapter.Fill(DA)

                txtName.Text = DA.Rows(0).Item(0).ToString() & ", " & DA.Rows(0).Item(1).ToString()

            End Using
        End Using

    End Sub
    Private Sub getDaysCount()

        Dim date1 As String = DateTimePicker1.Value.ToString("yyyy/MM/dd")
        Dim date2 As String = DateTimePicker2.Value.ToString("yyyy/MM/dd")

        'Dim count As Integer
        'txtdays.Text = count

        Dim DA = New DataTable()
        Dim sqlAdapter = New MySqlDataAdapter
        Dim dt = New DataSet



        'Dim cmd = New MySqlCommand

        ' Dim LogQuery As String = "SELECT USERNAME, PASSWORD, USER_TYPE FROM tbl_user WHERE USERNAME=@USERNAME AND PASSWORD=@PASSWORD "
        Using con As MySqlConnection = New MySqlConnection("server=localhost;user id=root;password=hello;database=db_attendance")
            Using cmd As MySqlCommand = New MySqlCommand("", con)

                cmd.CommandText = "prcFilterSummaryHours"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("date1", date1)
                cmd.Parameters.AddWithValue("date2", date2)
                cmd.Parameters.AddWithValue("i", ComboBox1.Text)

                sqlAdapter.SelectCommand = cmd
                DA.Clear()
                sqlAdapter.Fill(DA)

                row = 0
                Dim counter = 0
                Dim c = 0
                Dim x As Integer = 0
                Dim totalHours As Integer = 0
                Dim countOT As Integer = 0
                Dim countHoliday As Integer = 0

                Dim holidaydates() As String = {"2021/01/01", "2021/02/12", "2021/04/01",
                                                "2021/04/02", "2021/04/09", "2021/05/01",
                                                "2021/01/01", "2021/01/01", "2021/05/13",
                                                "2021/06/12", "2021/07/19", "2021/08/30",
                                                "2021/11/30", "2021/12/08", "2021/12/25",
                                                "2021/12/30"}


                If DA.Rows.Count > 0 Then

                    For Each row As DataRow In DA.Rows
                        x = CInt(DA.Rows(counter).Item(6).ToString())
                        totalHours = totalHours + x - 1

                        If (CInt(DA.Rows(counter).Item(6).ToString()) > 9) Then
                            countOT = (countOT + (DA.Rows(counter).Item(6).ToString()) - 1) - 8
                            totalHours = totalHours - countOT
                        End If

                        counter = counter + 1

                    Next
                    Dim count = 0
                    Dim r = 0
                    'count if the dates in attendance fall in holiday
                    For Each row As DataRow In DA.Rows
                        For Each dates As String In holidaydates
                            If DA.Rows(r).Item(3).ToString = holidaydates(count) Then
                                x = CInt(DA.Rows(row).Item(3).ToString)
                                countHoliday = countHoliday + x - 1
                                totalHours = totalHours - countHoliday
                                count += 1
                            End If

                        Next
                        count = 0
                        r += 1
                    Next
                    finalHoursTotal = totalHours
                    totalHolidayHours = countHoliday

                    'If (DA.Rows(c).Item(3).ToString() = holidaydates(0) Or DA.Rows(c).Item(3) = holidaydates(1) Or DA.Rows(c).Item(3) = holidaydates(2) Or
                    '             DA.Rows(c).Item(3) = holidaydates(3) Or DA.Rows(c).Item(3) = holidaydates(4) Or DA.Rows(c).Item(3) = holidaydates(5) Or
                    '              DA.Rows(c).Item(3) = holidaydates(6) Or DA.Rows(c).Item(3) = holidaydates(7) Or DA.Rows(c).Item(3) = holidaydates(8) Or
                    '              DA(c)(3) = holidaydates(9) Or DA(c)(3) = holidaydates(10) Or DA(c)(3) = holidaydates(11) Or
                    '              DA(c)(3) = holidaydates(12) Or DA(c)(3) = holidaydates(13) Or DA(c)(3) = holidaydates(14) Or
                    '              DA(c)(3) = holidaydates(15)) Then
                    '        x = CInt(DA(c)(6))
                    '        countHoliday = countHoliday + x - 1
                    '        totalHours = totalHours - countHoliday

                    '    End If
                    '    c = c + 1



                    'x = x + Convert.ToInt32(DA(i)(6))

                    If DA IsNot Nothing AndAlso DA.Rows.Count > 0 Then
                        'some code
                        'txtHours.Text = DA.Rows.Count.ToString

                        txtHours.Text = totalHours
                        txtOvertime.Text = countOT
                        txtHoliday.Text = countHoliday
                    Else
                        'some code
                        txtHours.Text = "0"
                        txtOvertime.Text = "0"
                    End If



                Else
                    recordsExist = False
                    MessageBox.Show("No records found.", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

                End If

            End Using
        End Using

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'Dim gross = Val(txtperHour.Text) * Val(txtHours.Text)
        'Dim deduct = Val(txtCAd.Text) + Val(txtpagibig.Text) + Val(txtPhil.Text) + Val(txtSSS.Text)
        ' Dim totalpay = gross - deduct
        'Dim daysperiod = txtHours

        'Dim hourly = Val(txtPerDay.Text) / 8
        'txtperHour.Text = hourly
        'txtMonth.Text = Val(txtPerDay.Text) * 20

        'btnTotalPay.Text = totalpay

    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        AddPay()
        DisplayPayHistory()
        Dim mes = MessageBox.Show("Generate Payslip?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If (mes = vbYes) Then
            Dim dt As New DataTable
            With dt
                .Columns.Add("ID")
                .Columns.Add("Name")
                .Columns.Add("Overtime")
                .Columns.Add("Holiday")
                .Columns.Add("TotalSalary")
                .Columns.Add("Philhealth")
                .Columns.Add("Pagibig")
                .Columns.Add("SSS")
                .Columns.Add("TotalDeductions")
                .Columns.Add("NetPay")
                .Columns.Add("BasicPay")
            End With

            With dt
                Dim R As DataRow = dt.NewRow
                R("ID") = ComboBox1.Text
                R("Name") = txtName.Text
                R("Overtime") = txtOTPay.Text
                R("Holiday") = txtHoliday.Text
                R("TotalSalary") = txtttlpay.Text
                R("Philhealth") = txtPhil.Text
                R("SSS") = txtSSS.Text
                R("Pagibig") = txtpagibig.Text
                R("TotalDeductions") = txtTtlDeductions.Text
                R("NetPay") = txtTotalPay.Text
                R("BasicPay") = Val(txtHours.Text) * Val(txtHourlyRate.Text)

                dt.Rows.Add(R)
                '.Rows.Add(dgr.Cells(0).Value
                'dgr.Cells(1).Value, dgr.Cells(2).Value, dgr.Cells(3).Value, dgr.Cells(4).Value, dgr.Cells(5).Value, dgr.Cells(6).Value)

            End With

            Dim report1 As ReportDocument
            report1 = New Payslip
            report1.SetDataSource(dt)
            Report.CrystalReportViewer1.ReportSource = report1

            '


            Report.ShowDialog()
            Report.Dispose()
        End If

    End Sub
    Private Sub DisplayPayHistory()
        'Dim DA = New DataTable()
        'Dim sqlAdapter = New MySqlDataAdapter
        'Dim dt = New DataSet

        'Using con As MySqlConnection = New MySqlConnection("server=localhost;user id=root;password=hello;database=db_attendance")
        '    Using cmd As MySqlCommand = New MySqlCommand("", con)

        '        cmd.CommandText = "prcDisplayPayHistorybyEmp"
        '        cmd.CommandType = CommandType.StoredProcedure
        '        cmd.Parameters.Clear()
        '        cmd.Parameters.AddWithValue("id", ComboBox1.Text)

        '        sqlAdapter.SelectCommand = cmd
        '        DA.Clear()
        '        sqlAdapter.Fill(DA)

        '        If DA.Rows.Count > 0 Then
        '            DataGridView1.RowCount = DA.Rows.Count
        '            Dim name = DA.Rows(0).Item(0).ToString() & "," & DA(0)(1)
        '            row = 0
        '            While Not DA.Rows.Count - 1 < row
        '                With DataGridView1
        '                    .Rows(row).Cells(0).Value = name
        '                    .Rows(row).Cells(1).Value = DA.Rows(row).Item("date").ToString
        '                    .Rows(row).Cells(2).Value = DA.Rows(row).Item("total_hours").ToString
        '                    .Rows(row).Cells(3).Value = DA.Rows(row).Item("gross_pay").ToString
        '                    .Rows(row).Cells(4).Value = DA.Rows(row).Item("total_deduction").ToString
        '                    .Rows(row).Cells(5).Value = DA.Rows(row).Item("total_pay").ToString


        '                End With
        '                row = row + 1
        '            End While
        '        Else
        '            'MessageBox.Show("No record found...")



        '        End If



        '    End Using
        'End Using
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub txtBasicRate_TextChanged(sender As Object, e As EventArgs) Handles txtBasicRate.TextChanged

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        checkDatabaseConnection()



        Dim date1 As String = DateTimePicker1.Value.ToString("yyyy/MM/dd")
        Dim date2 As String = DateTimePicker2.Value.ToString("yyyy/MM/dd")

        dataAttendance = New DataTable()

        sqlAttendanceAdapter = New MySqlDataAdapter
        command.Connection = conAttendanceSystem
        Try
            With command
                .Parameters.Clear()
                If txtID.Text = "" Then
                    .CommandText = "reportDisplayPayHistorybyDate"
                    .Parameters.AddWithValue("d1", date1)
                    .Parameters.AddWithValue("d2", date2)

                Else
                    .CommandText = "reportDisplayPayHistorybyDateAndID"
                    .Parameters.AddWithValue("id", txtID.Text)
                    .Parameters.AddWithValue("d1", date1)
                    .Parameters.AddWithValue("d2", date2)
                End If

                .CommandType = CommandType.StoredProcedure
                sqlAttendanceAdapter.SelectCommand = command
                dataAttendance.Clear()
                sqlAttendanceAdapter.Fill(dataAttendance)


                If dataAttendance.Rows.Count > 0 Then
                    DataGridView2.RowCount = dataAttendance.Rows.Count
                    Dim name = dataAttendance(0)(5) & "," & dataAttendance(0)(6)
                    row = 0
                    While Not dataAttendance.Rows.Count - 1 < row
                        With DataGridView2
                            ' .Rows(row).Cells(0).Value = dataAttendance.Rows(row).Item("id").ToString
                            .Rows(row).Cells(0).Value = dataAttendance.Rows(row).Item("id").ToString
                            .Rows(row).Cells(1).Value = dataAttendance(row)(5) & ", " & dataAttendance(row)(6)
                            .Rows(row).Cells(2).Value = dataAttendance.Rows(row).Item("date").ToString

                            .Rows(row).Cells(3).Value = dataAttendance.Rows(row).Item("gross_pay").ToString
                            .Rows(row).Cells(4).Value = dataAttendance.Rows(row).Item("total_deduction").ToString
                            .Rows(row).Cells(5).Value = dataAttendance.Rows(row).Item("total_pay").ToString
                            .Rows(row).Cells(6).Value = dataAttendance.Rows(row).Item("total_hours").ToString



                        End With
                        row = row + 1
                    End While
                Else
                    MessageBox.Show("No data to show.")



                End If
                sqlAttendanceAdapter.Dispose()
                dataAttendance.Dispose()
            End With
        Catch ex As Exception

        End Try
        Me.Refresh()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim date1 As String = Date.Now.ToString("yyyy/MM/dd")
        Dim dt As New DataTable
        With dt
            .Columns.Add("EmployeeID")
            .Columns.Add("Name")
            .Columns.Add("Date")
            .Columns.Add("GrossPay")
            .Columns.Add("Deduction")
            .Columns.Add("TotalPay")
            .Columns.Add("WorkingDays")
        End With

        For Each dgr As DataGridViewRow In Me.DataGridView2.Rows
            dt.Rows.Add(dgr.Cells(0).Value, dgr.Cells(1).Value, dgr.Cells(2).Value, dgr.Cells(3).Value, dgr.Cells(4).Value, dgr.Cells(5).Value, dgr.Cells(6).Value)
        Next
        Dim report1 As ReportDocument
        report1 = New CrystalPayrollReport
        report1.SetDataSource(dt)
        Report.CrystalReportViewer1.ReportSource = report1

        Dim TxtDate1 As TextObject
        TxtDate1 = report1.ReportDefinition.ReportObjects("txtDate")
        TxtDate1.Text = date1

        Report.ShowDialog()
        Report.Dispose()
    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class