Imports MySql.Data.MySqlClient
'Imports EXCEL = Microsoft.Office.Interop.Excel
Imports CrystalDecisions.CrystalReports.Engine

Public Class EmpTimesheet

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)


    End Sub

    Private Sub prcDisplayTimesheet()

        dataAttendance = New DataTable()

        sqlAttendanceAdapter = New MySqlDataAdapter
        command.Connection = conAttendanceSystem
        Try
            With command
                .Parameters.Clear()
                .CommandText = "prcDisplayTotalHours"
                .CommandType = CommandType.StoredProcedure
                sqlAttendanceAdapter.SelectCommand = command
                dataAttendance.Clear()
                sqlAttendanceAdapter.Fill(dataAttendance)



                If dataAttendance.Rows.Count > 0 Then
                    DataGridView1.RowCount = dataAttendance.Rows.Count

                    row = 0
                    While Not dataAttendance.Rows.Count - 1 < row
                        With DataGridView1
                            .Rows(row).Cells(0).Value = dataAttendance.Rows(row).Item("id").ToString
                            .Rows(row).Cells(1).Value = dataAttendance.Rows(row).Item("f_name").ToString
                            .Rows(row).Cells(2).Value = dataAttendance.Rows(row).Item("l_name").ToString

                            .Rows(row).Cells(3).Value = dataAttendance.Rows(row).Item("date").ToString
                            .Rows(row).Cells(4).Value = dataAttendance.Rows(row).Item("time_in").ToString
                            .Rows(row).Cells(5).Value = dataAttendance.Rows(row).Item("time_out").ToString
                            .Rows(row).Cells(6).Value = dataAttendance.Rows(row).Item("total_hours").ToString


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

    Private Sub EmpTimesheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        checkDatabaseConnection()
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy/MM/dd"
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = "yyyy/MM/dd"
        If rbDate.Checked Then
            ComboBox1.Enabled = False
            rbID.Checked = False
            rbAll.Checked = False
        ElseIf rbID.Checked Then
            ComboBox1.Enabled = True
        ElseIf rbAll.Checked Then
            prcDisplayTimesheet()

        End If
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("None")
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
            End With


            sqlAttendanceAdapter.Fill(dataAttendance)
            ComboBox1.DataSource = dataAttendance
            ComboBox1.DisplayMember = "id"
            ComboBox1.ValueMember = "id"



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        prcDisplayTimesheet()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Dispose()

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs)


    End Sub
    Private Sub calculateHours()
        Dim total As Integer
        Dim dayTotal As Integer

        For index As Integer = 0 To DataGridView1.RowCount - 1
            ' dayTotal = DataGridView1.Rows(index).Cells[4].Value 
        Next

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs)

        'dim date1 as string = datetimepicker1.value.tostring("yyyy/mm/dd")
        'dim date2 as string = datetimepicker2.value.tostring("yyyy/mm/dd")

        'dataattendance = new datatable()
        'sqlattendanceadapter = new mysqldataadapter
        'command.connection = conattendancesystem
        'dim ds as new dataset

        'dim i, j as integer

        'dim xlapp as excel.application
        'dim xlworkbook as excel.workbook
        'dim xlworksheet as excel.worksheet
        'dim misvalue as object = system.reflection.missing.value

        'xlapp = new excel.application
        'xlworkbook = xlapp.workbooks.add(misvalue)
        'xlworksheet = xlworkbook.sheets("sheet1")

        'with command
        '    .parameters.clear()
        '    .commandtext = "prcfiltertimesheet"
        '    .commandtype = commandtype.storedprocedure
        '    .parameters.addwithvalue("date1", date1)
        '    .parameters.addwithvalue("date2", date2)
        '    .parameters.addwithvalue("id", combobox1.text)

        '    sqlattendanceadapter.selectcommand = command
        '    sqlattendanceadapter.fill(ds)

        '    for i = 0 to ds.tables(0).rows.count - 1
        '        for j = 0 to ds.tables(0).columns.count - 1
        '            xlworksheet.cells(i + 1, j + 1) =
        '            ds.tables(0).rows(i).item(j)
        '        next
        '    next

        'end with



        'try
        '    dim fbd as new folderbrowserdialog

        '    if fbd.showdialog() = vbok then

        '        xlworksheet.saveas(fbd.selectedpath & "\" & combobox1.selectedvalue & "attendancerecord.xlsx")
        '        xlworkbook.close()
        '        xlapp.quit()

        '        releaseobject(xlapp)
        '        releaseobject(xlworkbook)
        '        releaseobject(xlworksheet)

        '        messagebox.show("succcessfully exported to excel file!", "export", messageboxbuttons.ok, messageboxicon.information)
        '    end if
        'catch ex as exception
        '    messagebox.show(ex.message)
        'end try
    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If rbDate.Checked = True Then
            filterSummaryHoursByDate()
        ElseIf rbID.Checked = True Then
            filterSummaryHoursByID()
        ElseIf rbAll.Checked = True Then
            prcDisplayTimesheet()
        End If

    End Sub
    Private Sub filterSummaryHoursByID()
        Dim date1 As String = DateTimePicker1.Value.ToString("yyyy/MM/dd")

        Dim date2 As String = DateTimePicker2.Value.ToString("yyyy/MM/dd")

        Dim DA = New DataTable()
        Dim sqlAdapter = New MySqlDataAdapter
        Using con As MySqlConnection = New MySqlConnection("server=localhost;user id=root;password=hello;database=db_attendance")
            Using cmd As MySqlCommand = New MySqlCommand("", con)

                cmd.CommandText = "prcFilterTimesheetbyID"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("date1", date1)
                cmd.Parameters.AddWithValue("date2", date2)
                cmd.Parameters.AddWithValue("id", ComboBox1.Text)
                sqlAdapter.SelectCommand = cmd
                DA.Clear()
                sqlAdapter.Fill(DA)

                If DA.Rows.Count > 0 Then
                    DataGridView1.RowCount = DA.Rows.Count

                    row = 0
                    While Not DA.Rows.Count - 1 < row
                        With DataGridView1
                            .Rows(row).Cells(0).Value = DA.Rows(row).Item("id").ToString
                            .Rows(row).Cells(1).Value = DA.Rows(row).Item("f_name").ToString
                            .Rows(row).Cells(2).Value = DA.Rows(row).Item("l_name").ToString

                            .Rows(row).Cells(3).Value = DA.Rows(row).Item("date").ToString
                            .Rows(row).Cells(4).Value = DA.Rows(row).Item("time_in").ToString
                            .Rows(row).Cells(5).Value = DA.Rows(row).Item("time_out").ToString
                            .Rows(row).Cells(6).Value = DA.Rows(row).Item("total_hours").ToString

                        End With
                        row = row + 1
                    End While
                Else

                End If
                DA.Dispose()
                sqlAdapter.Dispose()

            End Using
        End Using
    End Sub
    Private Sub filterSummaryHoursByDate()
        Dim date1 As String = DateTimePicker1.Value.ToString("yyyy/MM/dd")

        Dim date2 As String = DateTimePicker2.Value.ToString("yyyy/MM/dd")

        Dim DA = New DataTable()
        Dim sqlAdapter = New MySqlDataAdapter
        Using con As MySqlConnection = New MySqlConnection("server=localhost;user id=root;password=hello;database=db_attendance")
            Using cmd As MySqlCommand = New MySqlCommand("", con)

                cmd.CommandText = "prcFilterTimesheetByDate"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("date1", date1)
                cmd.Parameters.AddWithValue("date2", date2)
                sqlAdapter.SelectCommand = cmd
                DA.Clear()
                sqlAdapter.Fill(DA)

                If DA.Rows.Count > 0 Then
                    DataGridView1.RowCount = DA.Rows.Count

                    row = 0
                    While Not DA.Rows.Count - 1 < row
                        With DataGridView1
                            .Rows(row).Cells(0).Value = DA.Rows(row).Item("id").ToString
                            .Rows(row).Cells(1).Value = DA.Rows(row).Item("f_name").ToString
                            .Rows(row).Cells(2).Value = DA.Rows(row).Item("l_name").ToString

                            .Rows(row).Cells(3).Value = DA.Rows(row).Item("date").ToString
                            .Rows(row).Cells(4).Value = DA.Rows(row).Item("time_in").ToString
                            .Rows(row).Cells(5).Value = DA.Rows(row).Item("time_out").ToString
                            .Rows(row).Cells(6).Value = DA.Rows(row).Item("total_hours").ToString

                        End With
                        row = row + 1
                    End While
                Else

                End If
                DA.Dispose()
                sqlAdapter.Dispose()

            End Using
        End Using
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim date1 As String = DateTimePicker1.Value.ToString("yyyy/MM/dd")

        Dim date2 As String = DateTimePicker2.Value.ToString("yyyy/MM/dd")


        Dim dt As New DataTable
        With dt
            .Columns.Add("ID")
            .Columns.Add("Firstname")
            .Columns.Add("Lastname")
            .Columns.Add("Date")
            .Columns.Add("Timein")
            .Columns.Add("Timeout")
            .Columns.Add("Totalhours")
        End With

        For Each dgr As DataGridViewRow In Me.DataGridView1.Rows
            dt.Rows.Add(dgr.Cells(0).Value, dgr.Cells(1).Value, dgr.Cells(2).Value, dgr.Cells(3).Value, dgr.Cells(4).Value, dgr.Cells(5).Value, dgr.Cells(6).Value)
        Next
        Dim report1 As ReportDocument
        report1 = New CrystalReport1
        report1.SetDataSource(dt)
        Report.CrystalReportViewer1.ReportSource = report1

        Dim TxtDate1, TxtDate2 As TextObject


        If CheckBox1.Checked = True Then
            TxtDate1 = report1.ReportDefinition.ReportObjects("Text6")
            TxtDate1.Text = date1
        Else

            TxtDate1 = report1.ReportDefinition.ReportObjects("Text4")
            TxtDate1.Text = date1
            TxtDate2 = report1.ReportDefinition.ReportObjects("Text6")
            TxtDate2.Text = date2

        End If

        Report.ShowDialog()
        Report.Dispose()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        'If CheckBox1.Checked = True Then

        '    Label1.Visible = False
        '    ComboBox1.Visible = False
        '    DateTimePicker2.Visible = False


        'Else

        '    Label1.Visible = True
        '    ComboBox1.Visible = True
        '    DateTimePicker2.Visible = True


        'End If
    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub rbAll_CheckedChanged(sender As Object, e As EventArgs) Handles rbAll.CheckedChanged
        prcDisplayTimesheet()
    End Sub

    Private Sub rbDate_CheckedChanged(sender As Object, e As EventArgs) Handles rbDate.CheckedChanged
        rbID.Enabled = True
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
        adminDashboard.Show()
    End Sub
End Class