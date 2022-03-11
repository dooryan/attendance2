Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient


Public Class login

    Private Sub btn_login_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub username_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged

    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDatabaseConnection()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub login(ByVal uname As String, ByVal pwd As String)
        checkDatabaseConnection()

        'Dim USERNAME As String = txtusername.Text
        'Dim PASSWORD As String = txtpassword.Text

        If txtusername.Text = "" Or txtpassword.Text = "" Then
            MessageBox.Show("PLEASE ENTER YOUR CRENDENTIALS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else

            Dim LogQuery As String = "SELECT USERNAME, PASSWORD, USER_TYPE FROM tbl_user WHERE USERNAME=@USERNAME AND PASSWORD=@PASSWORD"
            Using con As MySqlConnection = New MySqlConnection("server=localhost;user id=root;password=hello;database=db_attendance")
                Using cmd As MySqlCommand = New MySqlCommand(LogQuery, con)

                    cmd.Parameters.AddWithValue("@USERNAME", uname)
                    cmd.Parameters.AddWithValue("@PASSWORD", pwd)

                    Dim da As New MySqlDataAdapter(cmd)
                    Dim myTable As New DataTable

                    con.Open()
                    da.Fill(myTable)
                    If myTable.Rows.Count > 0 Then
                        Dim message As String = "You have successfully login. Please click ok to proceed."
                        Dim caption As String = "Success"
                        Dim result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information)

                        If myTable.Rows(0)("USER_TYPE") = "admin" Then
                            Dim adminDashboard As New adminDashboard
                            adminDashboard.adminDashboard = txtusername.Text
                            adminDashboard.Show()

                        ElseIf myTable.Rows(0)("USER_TYPE") = "user" Then
                            Dim UserDashboard As New attendance
                            attendance.userDashboard = txtusername.Text
                            attendance.Show()
                        Else
                            MessageBox.Show("Error Occured", " ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)


                        End If
                        txtusername.Clear()
                        txtpassword.Clear()
                    Else
                        MessageBox.Show("Username or password does not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    con.Close()
                End Using
            End Using
        End If

    End Sub

    Private Sub userLogin(ByVal pwd As String, ByVal userType As String)
        If txtusername.Text = "" Or txtpassword.Text = "" Then
            MessageBox.Show("PLEASE ENTER YOUR CRENDENTIALS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else

            If (pwd = txtpassword.Text) Then


                Dim message As String = "You have successfully login. Please click ok to proceed."
                Dim caption As String = "Success"
                Dim result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information)


                If userType = "admin" Then
                    Dim adminDashboard As New adminDashboard
                    adminDashboard.adminDashboard = txtusername.Text
                    adminDashboard.Show()


                ElseIf userType = "user" Then
                    Dim UserDashboard As New attendance
                    attendance.userDashboard = txtusername.Text
                    attendance.Show()

                Else
                    MessageBox.Show("Error Occured", " ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

                End If

            Else
                MessageBox.Show("Username or password does not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

        End If

    End Sub
    Private Sub decrypt()
        If txtusername.Text = "" Or txtpassword.Text = "" Then
            MessageBox.Show("PLEASE ENTER YOUR CRENDENTIALS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else
            Try
                With command
                    .Parameters.Clear()
                    .CommandText = "prcDecrypt"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("uname", txtusername.Text)

                    Dim paramPwd As IDbDataParameter = command.CreateParameter()
                    paramPwd.ParameterName = "pwd"
                    paramPwd.Direction = System.Data.ParameterDirection.Output
                    .Parameters.Add(paramPwd)
                    Dim paramUtype As IDbDataParameter = command.CreateParameter()
                    paramUtype.ParameterName = "uType"
                    paramUtype.Direction = System.Data.ParameterDirection.Output
                    .Parameters.Add(paramUtype)
                    Dim paramIfUNameExist As IDbDataParameter = command.CreateParameter()
                    paramIfUNameExist.ParameterName = "IfUNameExist"
                    paramIfUNameExist.Direction = System.Data.ParameterDirection.Output
                    paramIfUNameExist.DbType = System.Data.DbType.Boolean
                    .Parameters.Add(paramIfUNameExist)
                    .ExecuteNonQuery()

                    Dim IfUNameExist As Boolean = paramIfUNameExist.Value

                    If (IfUNameExist = True) Then
                        Dim userType As String = paramUtype.Value
                        Dim pwdDecrypted As String = CaesarDecipher(paramPwd.Value, intShift:=15)
                        userLogin(pwdDecrypted, userType)
                    Else
                        MessageBox.Show("Username does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                    Console.WriteLine(paramPwd.Value & paramUtype.Value)

                End With
                'Me.Dispose()
            Catch ex As Exception
                MessageBox.Show("" & ex.Message)

            End Try
        End If
    End Sub
    Private Sub btn_login_Click_1(sender As Object, e As EventArgs) Handles btn_login.Click
        decrypt()
        txtpassword.Clear()
        txtusername.Clear()


    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        addUser.Show()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class