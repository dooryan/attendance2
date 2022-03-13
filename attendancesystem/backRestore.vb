Imports MySql.Data.MySqlClient

Imports System.IO
Imports System

Public Class backRestore
    Private Sub btnBackuo_Click(sender As Object, e As EventArgs) Handles btnBackuo.Click
        Using cmd As MySqlCommand = New MySqlCommand("", conAttendanceSystem)

            Dim sfd As New SaveFileDialog()
            'With {
            '.Filter = "Backup File | *.back",
            '.FileName = ""
            '}

            Try

                sfd.InitialDirectory = "C:\Users\" & My.User.Name & "\Desktop"
                sfd.Title = "Save to a file"
                sfd.FileName = "attendanceandpayroll.sql"
                sfd.Filter = "(*.sql)|*.sql"

                If sfd.ShowDialog = DialogResult.OK Then

                    Dim mb As MySqlBackup = New MySqlBackup(cmd)
                    mb.ExportToFile(sfd.FileName)

                    MessageBox.Show("Backup complete.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally

            End Try

        End Using
    End Sub

    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        Using cmd As MySqlCommand = New MySqlCommand("", conAttendanceSystem)
            Dim ofd As New OpenFileDialog()
            Try
                ofd.InitialDirectory = System.Environment.CurrentDirectory
                ofd.Title = "Save to a file"
                ofd.Filter = "(*.sql)|*.sql"

                If ofd.ShowDialog = DialogResult.OK Then

                    Dim mb As MySqlBackup = New MySqlBackup(cmd)
                    mb.ImportFromFile(ofd.FileName)

                    MessageBox.Show("Database Restored!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally

            End Try

        End Using
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub backRestore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.FlatStyle = FlatStyle.Flat
        Button1.FlatAppearance.BorderSize = 0
    End Sub
End Class