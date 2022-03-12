Imports MySql.Data.MySqlClient

Public Class WageDetails

    Private Sub WageDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDatabaseConnection()
        displayWageDetails()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged


    End Sub
    Private Sub displayWageDetails()

        Dim displayDA = New DataTable()
        Dim sqlAttendanceAdapter = New MySqlDataAdapter

        Using cmd As MySqlCommand = New MySqlCommand("", conAttendanceSystem)
            With cmd
                .Parameters.Clear()
                .CommandText = "prcDisplayPayDetails"
                .CommandType = CommandType.StoredProcedure
                sqlAttendanceAdapter.SelectCommand = cmd
                displayDA.Clear()
                sqlAttendanceAdapter.Fill(displayDA)

                row = 0
                If displayDA.Rows.Count > 0 Then
                    DataGridView1.RowCount = displayDA.Rows.Count

                    'Dim name As String = displayDA.Rows(row).Item("l_name").ToString & " ," & displayDA.Rows(row).Item("f_name").ToString

                    While Not displayDA.Rows.Count - 1 < row
                        With DataGridView1
                            .Rows(row).Cells(0).Value = displayDA.Rows(row).Item("id").ToString
                            .Rows(row).Cells(1).Value = displayDA.Rows(row).Item("l_name").ToString & " ," & displayDA.Rows(row).Item("f_name").ToString
                            .Rows(row).Cells(2).Value = displayDA.Rows(row).Item("name").ToString
                            .Rows(row).Cells(3).Value = displayDA.Rows(row).Item("rate_hour").ToString
                            .Rows(row).Cells(4).Value = displayDA.Rows(row).Item("philhealth").ToString
                            .Rows(row).Cells(5).Value = displayDA.Rows(row).Item("sss").ToString
                            .Rows(row).Cells(6).Value = displayDA.Rows(row).Item("pagibig").ToString

                        End With
                        row = row + 1
                    End While
                Else




                End If
                sqlAttendanceAdapter.Dispose()
                dataAttendance.Dispose()

            End With

        End Using
        Me.Refresh()
    End Sub

    Private Sub EmployeeInfo()
        Dim DA = New DataTable()
        Dim sqlAdapter = New MySqlDataAdapter
        'Dim v = ComboBox1.SelectedItem
        'Dim LogQuery As String = "SELECT USERNAME, PASSWORD, USER_TYPE FROM tbl_user WHERE USERNAME=@USERNAME AND PASSWORD=@PASSWORD "
        Using con As MySqlConnection = New MySqlConnection("server=localhost;user id=root;password=hello;database=db_attendance")
            Using cmd As MySqlCommand = New MySqlCommand("", con)

                cmd.CommandText = "prcDisplayPayDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("i", txtID.Text)
                sqlAdapter.SelectCommand = cmd
                DA.Clear()
                sqlAdapter.Fill(DA)

                If DA.Rows.Count > 0 Then
                    'txtHourlyRate.Text = DataGridView1.CurrentRow.Cells(3).Value
                    ''txtGrossWage.Text = 48 * Val(txtHourlyRate.Text) * 2
                    'txtName.Text = DataGridView1.CurrentRow.Cells(1).Value
                    'txtDept.Text = DataGridView1.CurrentRow.Cells(2).Value
                    ''txtJobStat.Text = DA(0)(7)
                    'txtphilhealth.Text = CDec(DataGridView1.CurrentRow.Cells(4).Value)
                    'txtsss.Text = CDec(DataGridView1.CurrentRow.Cells(5).Value)
                    'txtpagibig.Text = CDec(DataGridView1.CurrentRow.Cells(6).Value)
                    ''txtDept.Text = DA(0)(11)
                    'btnSave.Enabled = False
                    'btnUpdate.Enabled = True
                    ''txtBasic.Text = DA(0)(11)
                Else
                    Dim m = MessageBox.Show("No record found. Add record?", "", MessageBoxButtons.OKCancel)
                    If m = vbOK Then
                        'TextBox clear all
                        txtName.Clear()
                        txtDept.Clear()
                        txtDept.Clear()
                        'txtJobStat.Clear()
                        txtphilhealth.Clear()
                        txtsss.Clear()
                        txtphilhealth.Clear()
                        txtpagibig.Clear()
                        txtHourlyRate.Clear()
                        'txtGrossWage.Clear()

                        btnUpdate.Enabled = False
                        btnSave.Enabled = True
                    End If

                End If

            End Using
            con.Dispose()
        End Using

        'Multiply your monthly premium by 12 And 
        'you have total annual contributions Of Php 10, 92.06.

    End Sub
    Private Sub displayIndividualRecord()
        txtID.Text = DataGridView1.CurrentRow.Cells(0).Value
        txtHourlyRate.Text = DataGridView1.CurrentRow.Cells(3).Value
        'txtGrossWage.Text = 48 * Val(txtHourlyRate.Text) * 2
        txtName.Text = DataGridView1.CurrentRow.Cells(1).Value
        txtDept.Text = DataGridView1.CurrentRow.Cells(2).Value
        'txtJobStat.Text = DA(0)(7)
        txtphilhealth.Text = CDec(DataGridView1.CurrentRow.Cells(4).Value)
        txtsss.Text = CDec(DataGridView1.CurrentRow.Cells(5).Value)
        txtpagibig.Text = CDec(DataGridView1.CurrentRow.Cells(6).Value)
        'txtDept.Text = DA(0)(11)
        btnSave.Enabled = False
        btnUpdate.Enabled = True
        'txtBasic.Text = DA(0)(11)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'EmployeeInfo()

    End Sub

    Private Sub InsertPayDetails(ByVal flag)

        Dim rate_day = txtHourlyRate.Text * 8
        Dim rate_month = ((Val(txtHourlyRate.Text) * 48) * 52) / 12

        Try
            With command

                If (flag = "insert") Then
                    .CommandText = "prcInsertPayDetails"

                    .Parameters.Clear()
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("id", txtID.Text)
                    .Parameters.AddWithValue("hr", txtHourlyRate.Text)
                    .Parameters.AddWithValue("rd", rate_day)
                    .Parameters.AddWithValue("rm", rate_month)
                    .Parameters.AddWithValue("ph", txtphilhealth.Text)
                    .Parameters.AddWithValue("sss", txtsss.Text)
                    .Parameters.AddWithValue("pibig", txtpagibig.Text)
                    .ExecuteNonQuery()

                    MessageBox.Show("Successfully added.", "Information", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information)


                ElseIf (flag = "update") Then


                    .Parameters.Clear()
                    .CommandText = "prcUpdatePayDetails"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("id", txtID.Text)
                    .Parameters.AddWithValue("hr", txtHourlyRate.Text)
                    .Parameters.AddWithValue("rd", rate_day)
                    .Parameters.AddWithValue("rm", rate_month)
                    .Parameters.AddWithValue("ph", txtphilhealth.Text)
                    .Parameters.AddWithValue("sss", txtsss.Text)
                    .Parameters.AddWithValue("pibig", txtpagibig.Text)
                    '.Parameters.AddWithValue("jobstat", txtJobStat.Text)
                    .ExecuteNonQuery()

                    MessageBox.Show("Successfully updated.", "Information", MessageBoxButtons.OK,
                                            MessageBoxIcon.Information)


                    'End Using
                    'End Using

                End If

            End With

            'End Using
            'End Using
        Catch ex As Exception

        End Try


    End Sub

    Private Sub txtDailyRate_TextChanged(sender As Object, e As EventArgs) Handles txtHourlyRate.TextChanged
        If ((Val(txtHourlyRate.Text) * 48) * 52) / 12 <= 10000 Then
            txtphilhealth.Text = 350
        Else
            txtphilhealth.Text = (Val(((Val(txtHourlyRate.Text) * 48) * 52) / 12) * 0.035)
        End If


        txtsss.Text = (((Val(txtHourlyRate.Text) * 48) * 52) / 12) * 0.0363
        txtpagibig.Text = (((Val(txtHourlyRate.Text) * 48) * 52) / 12) * 0.02
        'txtGrossWage.Text = 48 * Val(txtHourlyRate.Text) * 2

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        InsertPayDetails("insert")
        displayWageDetails()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        InsertPayDetails("update")
        displayWageDetails()





    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        displayIndividualRecord()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        addNew()
    End Sub

    Private Sub addNew()
        txtID.Clear()
        txtHourlyRate.Clear()

        txtName.Clear()
        txtDept.Clear()

        txtphilhealth.Clear()
        txtsss.Clear()
        txtpagibig.Clear()

        btnSave.Enabled = True
        btnUpdate.Enabled = False

    End Sub
    Private Sub delete()
        Using cmd As MySqlCommand = New MySqlCommand("", conAttendanceSystem)
            Dim m = MessageBox.Show("Are you sure you want to delete this data?.", "Delete Data", MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Information)
            If m = DialogResult.Yes Then

                Try
                    With cmd
                        .CommandText = "prcDeletePayDetails"
                        .Parameters.Clear()
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.AddWithValue("id", DataGridView1.CurrentRow.Cells(0).Value)

                        .ExecuteNonQuery()


                    End With

                Catch ex As Exception

                End Try

                MessageBox.Show("Data Deleted.", "Information", MessageBoxButtons.OK,
                                       MessageBoxIcon.Information)
            ElseIf m = DialogResult.No Then


            End If

        End Using
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        delete()
        displayWageDetails()
    End Sub
End Class