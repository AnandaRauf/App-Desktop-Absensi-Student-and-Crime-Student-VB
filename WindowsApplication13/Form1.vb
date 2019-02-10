Imports System.Data
Imports System.Data.SqlClient
Public Class Register
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub RegBut_Click(sender As Object, e As EventArgs) Handles RegBut.Click
        Dim cmd As New SqlCommand
        Dim con As New SqlConnection
        Try

            con.ConnectionString = ("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Penting\Db SQL Server Project App Desktop\db_ControlStudent.mdf;Integrated Security=True;Connect Timeout=30")
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "Insert into tbl_admin([Username], [Password]) VALUES('" & UserBox.Text & "','" & PassBox.Text & "')"
            cmd.ExecuteNonQuery()
            MessageBox.Show("Register Succesfull")
            Login.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally
            con.Close()
        End Try


    End Sub

    Public Sub ExecuteQuery(query As String)

        Dim command As New SqlCommand(query, koneksiSQL)

        koneksiSQL.Open()

        command.ExecuteNonQuery()

        koneksiSQL.Close()

    End Sub
    Private Sub QuitBut_Click(sender As Object, e As EventArgs) Handles QuitBut.Click
        MsgBox("Are you sure quit ?", vbQuestion + vbYesNo, "Confirmation")

        Close()
    End Sub
End Class
