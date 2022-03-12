Public Class BackupRestore
    Private Sub btnBackuo_Click(sender As Object, e As EventArgs) Handles btnBackuo.Click

        Dim sfd As New SaveFileDialog() With {
            .Filter = "Backup File | *.back",
            .FileName = ""
            }

        If sfd.ShowDialog = DialogResult.OK Then
            Dim sql As String = $"backup database management to disk"

        End If

    End Sub
End Class