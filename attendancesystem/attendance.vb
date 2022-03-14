Imports System.DateTime
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient



Public Class attendance
    Dim dateNow As String = Date.Now.ToString("yyyy/MM/dd")
    Dim timeNow As String = Date.Now.ToString("HH:mm:ss")

    Shared Property userDashboard As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnIn.Click

        Dim user As String = Label1.Text
        'Dim dateNow As String = Date.Now.ToString("yyyy/MM/dd")
        'Dim timeNow As String = Date.Now.ToString("HH:mm:ss")
        Dim statt As String = "IN"
        Dim Flag = 0

        dataAttendance = New DataTable()
        sqlAttendanceAdapter = New MySqlDataAdapter
        command.Connection = conAttendanceSystem
        Dim com = New MySqlCommand()
        com.Connection = conAttendanceSystem

        Try
            With command
                .Parameters.Clear()
                .CommandText = "prcValidateTimeEntry"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("uname", user)
                .Parameters.AddWithValue("stat", statt)
                .Parameters.AddWithValue("d", dateNow)

                .ExecuteNonQuery()
                sqlAttendanceAdapter.SelectCommand = command
                dataAttendance.Clear()
                sqlAttendanceAdapter.Fill(dataAttendance)

                If dataAttendance.Rows.Count >= 1 Then
                    MessageBox.Show("YOU HAVE ALREADY TIME-IN FOR TODAY", "", MessageBoxButtons.OK, MessageBoxIcon.Hand)

                ElseIf dataAttendance.Rows.Count <= 0 Then
                    With com
                        .Parameters.Clear()
                        .CommandText = "prcEntryTimesheet"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.AddWithValue("uname", user)
                        .Parameters.AddWithValue("stat", statt)
                        .Parameters.AddWithValue("currTime", timeNow)
                        .Parameters.AddWithValue("currDate", Date.Now.ToString("yyy/MM/dd"))
                        .Parameters.AddWithValue("flag", Flag)
                        .ExecuteNonQuery()

                        MessageBox.Show("Time-in successful", "", MessageBoxButtons.OK,
                                                        MessageBoxIcon.Information)



                    End With
                End If
            End With

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)

        End Try
        dateCompare()
        displayTimesheet()




    End Sub

    Private Sub attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Refresh()

        Timer1.Enabled = True
        displayName()
        Label1.Text = userDashboard
        displayTimesheet()



    End Sub
    Private Sub displayName()


        Using command As MySqlCommand = New MySqlCommand("", conAttendanceSystem)
            command.Parameters.Clear()
            command.CommandText = "prcDisplayEmpName"
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("uname", userDashboard)

            Dim l_name As IDbDataParameter = command.CreateParameter()
            l_name.ParameterName = "l_name"
            l_name.Direction = System.Data.ParameterDirection.Output
            command.Parameters.Add(l_name)
            Dim f_name As IDbDataParameter = command.CreateParameter()
            f_name.ParameterName = "f_name"
            f_name.Direction = System.Data.ParameterDirection.Output
            command.Parameters.Add(f_name)

            command.ExecuteNonQuery()
            lblName.Text = l_name.Value & ", " & f_name.Value
        End Using


        'command.Connection = conAttendanceSystem
        'Dim com = New MySqlCommand()
        'com.Connection = conAttendanceSystem
        'Try
        '    With command
        '        .Parameters.Clear()
        '        .CommandText = "prcDisplayEmpName"
        '        .CommandType = CommandType.StoredProcedure
        '        .Parameters.AddWithValue("uname", userDashboard)

        '        Dim l_name As IDbDataParameter = command.CreateParameter()
        '        l_name.ParameterName = "l_name"
        '        l_name.Direction = System.Data.ParameterDirection.Output
        '        .Parameters.Add(l_name)
        '        Dim f_name As IDbDataParameter = command.CreateParameter()
        '        f_name.ParameterName = "f_name"
        '        f_name.Direction = System.Data.ParameterDirection.Output
        '        .Parameters.Add(f_name)


        '        lblName.Text = l_name.Value & ", " & f_name.Value
        '    End With
        '    Me.Dispose()
        'Catch ex As Exception
        '    MessageBox.Show("" & ex.Message)

        'End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lbl_date.Click
        lbl_date.Text = DateTime.Now.ToLongDateString()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim oForm As New login
        oForm.Show()
        Me.Dispose()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_date.Text = Date.Now.ToString("dd MMM yyy")
        lbl_time.Text = Date.Now.ToString("hh:mm:ss")

    End Sub

    Private Sub btnOut_Click(sender As Object, e As EventArgs) Handles btnOut.Click

        Dim user As String = Label1.Text

        Dim statt As String = "OUT"

        dataAttendance = New DataTable()
        sqlAttendanceAdapter = New MySqlDataAdapter
        command.Connection = conAttendanceSystem
        Dim com = New MySqlCommand()
        com.Connection = conAttendanceSystem
        Dim Flag = 1
        Try
            With command
                .Parameters.Clear()
                .CommandText = "prcValidateTimeEntry"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("uname", user)
                .Parameters.AddWithValue("stat", statt)
                .Parameters.AddWithValue("d", dateNow)

                .ExecuteNonQuery()
                sqlAttendanceAdapter.SelectCommand = command
                dataAttendance.Clear()
                sqlAttendanceAdapter.Fill(dataAttendance)

                If dataAttendance.Rows.Count >= 1 Then
                    MessageBox.Show("YOU HAVE ALREADY TIME-OUT FOR TODAY", "", MessageBoxButtons.OK, MessageBoxIcon.Hand)

                ElseIf dataAttendance.Rows.Count <= 0 Then
                    With com
                        .Parameters.Clear()
                        .CommandText = "prcEntryTimesheet"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.AddWithValue("uname", user)
                        .Parameters.AddWithValue("stat", statt)
                        .Parameters.AddWithValue("currTime", timeNow)
                        .Parameters.AddWithValue("currDate", dateNow)
                        .Parameters.AddWithValue("flag", Flag)

                        .ExecuteNonQuery()
                        btnIn.Show()
                        MessageBox.Show("Time-out successful", "", MessageBoxButtons.OK,
                                                        MessageBoxIcon.Information)

                    End With
                End If
            End With

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)

        End Try
        displayTimesheet()
    End Sub

    Private Sub dgrid_emp_time_history_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgrid_emp_time_history.CellContentClick

    End Sub

    Private Sub displayTimesheet()
        Dim user As String = Label1.Text
        dgrid_emp_time_history.Columns(0).DefaultCellStyle.Format = "yyyy/MM/dd"
        dataAttendance = New DataTable()
        sqlAttendanceAdapter = New MySqlDataAdapter
        command.Connection = conAttendanceSystem
        Try
            With command
                .Parameters.Clear()
                .CommandText = "prcDisplayEmpTimesheet"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("uname", user)
                sqlAttendanceAdapter.SelectCommand = command
                dataAttendance.Clear()
                sqlAttendanceAdapter.Fill(dataAttendance)


                If dataAttendance.Rows.Count > 0 Then
                    dgrid_emp_time_history.RowCount = dataAttendance.Rows.Count

                    row = 0
                    While Not dataAttendance.Rows.Count - 1 < row

                        With dgrid_emp_time_history
                            .Rows(row).Cells(0).Value = dataAttendance.Rows(row).Item("tdate").ToString

                            .Rows(row).Cells(1).Value = dataAttendance.Rows(row).Item("ttime").ToString

                            .Rows(row).Cells(2).Value = dataAttendance.Rows(row).Item("status").ToString
                        End With
                        row = row + 1
                    End While


                Else
                    MessageBox.Show("No record found...")

                End If
                sqlAttendanceAdapter.Dispose()
                dataAttendance.Dispose()
            End With
        Catch ex As Exception

        End Try

    End Sub

    Private Sub dateCompare()
        'Compare date to let btnIn and btnOut hide and show alternately
        Dim dateFromDGridSplit As String
        Dim row1 = 0

        If dgrid_emp_time_history.Rows.Count < 0 Then
            While dgrid_emp_time_history.Rows.Count > row1
                dateFromDGridSplit = dgrid_emp_time_history.Rows(row1).Cells(0).Value
                dateFromDGridSplit.Substring(0, 10)
                If ((dgrid_emp_time_history.Rows(row1).Cells(2).Value = "IN") And (dateFromDGridSplit.Substring(0, 10) = Date.Now.ToString("dd/MM/yyyy"))) Then
                    btnIn.Hide()

                Else
                    Console.WriteLine("no value ")
                    Console.WriteLine(dgrid_emp_time_history.Rows(row1).Cells(0).Value)
                    Console.WriteLine(dateFromDGridSplit.Substring(0, 10))
                    Console.WriteLine(Date.Now.ToString("dd/MM/yyyy"))
                End If
                row1 = row1 + 1
            End While
        Else
            btnIn.Hide()
        End If


    End Sub
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        'Me.Dispose()
        'login.Show()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        addLogs("user")
        login.Show()
        Me.Close()

    End Sub
    Private Sub addLogs(ByVal type As String)
        checkDatabaseConnection()
        Dim d As String = dateNow & " " & timeNow

        If (conAttendanceSystem.State = ConnectionState.Open) Then

            Console.WriteLine(d)
            'Using cmd As New MySqlCommand
            'cmd.Connection = conAttendanceSystem

            With command

                .Parameters.Clear()
                .CommandText = "prcInsertLogs"
                .CommandType = CommandType.StoredProcedure

                .Parameters.AddWithValue("uname", Label1.Text)
                .Parameters.AddWithValue("tdate", d)
                .Parameters.AddWithValue("utype", type)
                .Parameters.AddWithValue("uAction", "logout")
                .ExecuteNonQuery()

            End With

            'End Using
        End If

    End Sub
End Class