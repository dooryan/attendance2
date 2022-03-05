Imports System
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class addUser
    Private Sub addUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDatabaseConnection()

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dateNow As String = Date.Now.ToString("yyyy-MM-dd hh:mm:ss")
        Dim type As String
        type = "user"

        Dim strVal As String = txtPass.Text
        Dim pwdEncrypted As String =
         CaesarCipher(strVal, intShift:=15)

        'Dim pwdDecrypted As String =
        'CaesarDecipher(pwdEncrypted, intShift:=15)

        'Debug.WriteLine(String.Format("Entered string: {0}",
        ' strVal))
        'Debug.WriteLine(String.Format("Encrypted  string: {0}",
        ' pwdEncrypted))
        'Debug.WriteLine(String.Format("Decrypted string: {0}",
        ' pwdDecrypted))

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
                Console.WriteLine(param.ToString)

                If (param.Value = False) Then
                    MessageBox.Show("Employee does not exist.", "", MessageBoxButtons.OK,
                MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Successfully added User", "", MessageBoxButtons.OK,
                              MessageBoxIcon.Information)
                End If


            End With
            Me.Dispose()
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)

        End Try






        Me.Hide()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged

    End Sub


End Class