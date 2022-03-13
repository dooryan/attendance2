Imports MySql.Data.MySqlClient
Public Class viewUsers
    Private Sub viewUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDatabaseConnection()
        displayUsers()

    End Sub

    Private Sub deleteUser()
        Dim num As Integer

        Try
            num = MessageBox.Show("Delete user?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If num = DialogResult.Yes Then
                With command
                    .Parameters.Clear()
                    .CommandText = "prcDeleteUser"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("id", CInt(DataGridView1.CurrentRow.Cells(0).Value))
                    .ExecuteNonQuery()

                End With
            End If



        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub
    Private Sub displayUsers()
        ' Dim user As String = Label1.Text

        dataAttendance = New DataTable()
        sqlAttendanceAdapter = New MySqlDataAdapter
        command.Connection = conAttendanceSystem
        Try
            With command
                .Parameters.Clear()
                .CommandText = "prcDisplayAllUsers"
                .CommandType = CommandType.StoredProcedure
                sqlAttendanceAdapter.SelectCommand = command
                dataAttendance.Clear()
                sqlAttendanceAdapter.Fill(dataAttendance)


                If dataAttendance.Rows.Count > 0 Then
                    DataGridView1.RowCount = dataAttendance.Rows.Count

                    row = 0
                    While Not dataAttendance.Rows.Count - 1 < row
                        With DataGridView1
                            .Rows(row).Cells(0).Value = dataAttendance.Rows(row).Item("emp_id").ToString
                            .Rows(row).Cells(1).Value = dataAttendance.Rows(row).Item("username").ToString
                            .Rows(row).Cells(2).Value = dataAttendance.Rows(row).Item("f_name").ToString
                            .Rows(row).Cells(3).Value = dataAttendance.Rows(row).Item("l_name").ToString
                            .Rows(row).Cells(4).Value = dataAttendance.Rows(row).Item("date_created").ToString

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        deleteUser()
        displayUsers()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        adminDashboard.Show()
        Me.Close()
    End Sub
End Class