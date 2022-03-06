Imports System
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class addUser
    Private uNameIfExist As Boolean


    Private Sub addUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDatabaseConnection()


    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim dateNow As String = Date.Now.ToString("yyyy-MM-dd hh:mm:ss")
        Dim type As String
        type = "user"

        'ifExistUname()
        If txtPass.Text = txtConfirmPassword.Text Then
            Dim strVal As String = txtPass.Text
            Dim pwdEncrypted As String = CaesarCipher(strVal, intShift:=15)


            Try
                With command
                    .Parameters.Clear()
                    .CommandText = "prcAddUser"
                    .CommandType = CommandType.StoredProcedure

                    .Parameters.AddWithValue("eID", txtID.Text)
                    .Parameters.AddWithValue("uname", txtUname.Text)
                    .Parameters.AddWithValue("pass", pwdEncrypted)
                    .Parameters.AddWithValue("d", dateNow)
                    .Parameters.AddWithValue("utype", type)


                    Dim param As IDbDataParameter = command.CreateParameter()
                    param.ParameterName = "ifExist"
                    param.Direction = System.Data.ParameterDirection.InputOutput
                    param.DbType = System.Data.DbType.Boolean
                    .Parameters.Add(param)

                    .ExecuteNonQuery()
                    Console.WriteLine(param.Value)


                    If (param.Value = False) Then
                        MessageBox.Show("Employee does not exist.", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Error)

                    Else
                        If (uNameIfExist = True) Then
                            MessageBox.Show("Username exist.", "", MessageBoxButtons.OK,
                                 MessageBoxIcon.Exclamation)
                        Else
                            MessageBox.Show("Succesfully Added User.", "", MessageBoxButtons.OK,
                                 MessageBoxIcon.Information)
                        End If

                    End If
                    Me.Hide()
                    Me.Dispose()

                End With

            Catch ex As Exception
                MessageBox.Show("" & ex.Message)

            End Try

        Else
            MessageBox.Show("Password not match", "", MessageBoxButtons.OK,
                                 MessageBoxIcon.Exclamation)
            txtPass.Clear()
            txtConfirmPassword.Clear()
        End If






    End Sub
    Private Sub ifExistUname()
        Try
            With command
                .Parameters.Clear()
                .CommandText = "prcCheckUname"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("uname", txtUname.Text)

                Dim param As IDbDataParameter = command.CreateParameter()
                param.ParameterName = "exist"
                param.Direction = System.Data.ParameterDirection.InputOutput
                param.DbType = System.Data.DbType.Boolean
                .Parameters.Add(param)



                .ExecuteNonQuery()
                Console.WriteLine(param.Value)

                If (param.Value = True) Then
                    uNameIfExist = True

                End If
                Me.Hide()
                Me.Dispose()

            End With

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)

        End Try

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPassword.TextChanged

    End Sub
End Class