Imports System
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class addUser
    Private uNameIfExist As Boolean
    Private ifEmpIDExist As Boolean
    Private userAlreadyExist As Boolean


    Private Sub addUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDatabaseConnection()

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        checkIfExists()

        If (ifEmpIDExist = False) Then
            MessageBox.Show("Employee does not exist.", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Error)
        Else
            If (uNameIfExist = True) Then
                MessageBox.Show("Username exist.", "", MessageBoxButtons.OK,
                                     MessageBoxIcon.Exclamation)
            Else

                If (userAlreadyExist = True) Then
                    MessageBox.Show("User with that ID already exist.", "", MessageBoxButtons.OK,
                                         MessageBoxIcon.Exclamation)
                Else
                    If txtPass.Text = txtConfirmPassword.Text Then
                        Dim strVal As String = txtPass.Text
                        Dim pwdEncrypted As String = CaesarCipher(strVal, intShift:=15)

                        addUser(pwdEncrypted)
                        MessageBox.Show("Succesfully Added User.", "", MessageBoxButtons.OK,
                                            MessageBoxIcon.Information)
                        Me.Hide()
                        Me.Dispose()
                    Else
                        MessageBox.Show("Password doesn't match..", "", MessageBoxButtons.OK,
                                           MessageBoxIcon.Information)
                    End If

                End If


            End If


        End If

        'If (uNameIfExist = True) Then
        '    MessageBox.Show("Username exist.", "", MessageBoxButtons.OK,
        '                         MessageBoxIcon.Exclamation)
        'End If
        'If (userAlreadyExist = True) Then
        '    MessageBox.Show("User with that ID already exist.", "", MessageBoxButtons.OK,
        '                         MessageBoxIcon.Exclamation)
        'End If

        'If (ifEmpIDExist = True And uNameIfExist = False And userAlreadyExist = False) Then

        '    If txtPass.Text = txtConfirmPassword.Text Then
        '        Dim strVal As String = txtPass.Text
        '        Dim pwdEncrypted As String = CaesarCipher(strVal, intShift:=15)

        '        addUser(pwdEncrypted)
        '        MessageBox.Show("Succesfully Added User.", "", MessageBoxButtons.OK,
        '                            MessageBoxIcon.Information)
        '        Me.Hide()
        '        Me.Dispose()
        '    Else
        '        MessageBox.Show("Password not match", "", MessageBoxButtons.OK,
        '                                 MessageBoxIcon.Exclamation)
        '        txtPass.Clear()
        '        txtConfirmPassword.Clear()
        '    End If
        'Else
        '    MessageBox.Show("Error", "", MessageBoxButtons.OK,
        '                        MessageBoxIcon.Information)
        'End If



        uNameIfExist = False
        ifEmpIDExist = False
        userAlreadyExist = False



    End Sub
    Private Sub checkIfExists()


        Try
            With command

                .Parameters.Clear()
                .CommandText = "prcCheckIfUserExists"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("uname", txtUname.Text)
                .Parameters.AddWithValue("eID", txtID.Text)

                Dim param1 As IDbDataParameter = command.CreateParameter()
                param1.ParameterName = "ifEmpIDExist"
                param1.Direction = System.Data.ParameterDirection.Output
                param1.DbType = System.Data.DbType.Boolean
                .Parameters.Add(param1)

                Dim param2 As IDbDataParameter = command.CreateParameter()
                param2.ParameterName = "ifUnameExist"
                param2.Direction = System.Data.ParameterDirection.Output
                param2.DbType = System.Data.DbType.Boolean
                command.Parameters.Add(param2)


                Dim param3 As IDbDataParameter = command.CreateParameter()
                param3.ParameterName = "ifUserExist"
                param3.Direction = System.Data.ParameterDirection.Output
                param3.DbType = System.Data.DbType.Boolean
                command.Parameters.Add(param3)


                command.ExecuteNonQuery()
                Console.WriteLine("param value")
                Console.WriteLine(param1.Value)
                Console.WriteLine(param2.Value)
                Console.WriteLine(param3.Value)


                ifEmpIDExist = param1.Value
                uNameIfExist = param2.Value
                userAlreadyExist = param3.Value
            End With
        Catch ex As Exception

        End Try


    End Sub
    Private Sub addUser(ByVal pwdEncrypted As String)

        Dim dateNow As String = Date.Now.ToString("yyyy-MM-dd hh:mm:ss")
        Dim type As String
        type = "user"
        Using cmd As MySqlCommand = New MySqlCommand("", conAttendanceSystem)

                cmd.Parameters.Clear()
                cmd.CommandText = "prcAddUser2"
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("eID", txtID.Text)
                cmd.Parameters.AddWithValue("uname", txtUname.Text)
                cmd.Parameters.AddWithValue("pass", pwdEncrypted)
                cmd.Parameters.AddWithValue("d", dateNow)
                cmd.Parameters.AddWithValue("utype", type)
                cmd.ExecuteNonQuery()

            'Dim param As IDbDataParameter = command.CreateParameter()
            'param.ParameterName = "ifExist"
            'param.Direction = System.Data.ParameterDirection.InputOutput
            'param.DbType = System.Data.DbType.Boolean
            '.Parameters.Add(param)
            '.ExecuteNonQuery()

        End Using

    End Sub
    Private Sub ifExistUname()

        dataAttendance = New DataTable()

        Using con As MySqlConnection = New MySqlConnection("server=localhost;user id=root;password=hello;database=db_attendance")
            Using cmd As MySqlCommand = New MySqlCommand("", con)

                cmd.Parameters.Clear()
                cmd.CommandText = "prcCheckUname"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("uname", txtUname.Text)

                Dim param As IDbDataParameter = command.CreateParameter()
                param.ParameterName = "exist"
                param.Direction = System.Data.ParameterDirection.InputOutput
                param.DbType = System.Data.DbType.Boolean
                cmd.Parameters.Add(param)
                Console.WriteLine(param.Value)

                If (param.Value = True) Then
                    uNameIfExist = True
                End If

            End Using
        End Using


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPassword.TextChanged

    End Sub
End Class