Imports System.Data
Imports System.Data.SqlClient
Public Class Login
    Private Sub LogBut_Click(sender As Object, e As EventArgs) Handles LogBut.Click
        Call konekdatabase()
        Dim SQLCmd As New SqlCommand
        Dim DR As SqlDataReader
        SQLCmd = New SqlCommand("Select * From tbl_admin where  Username='" & UserBox.Text & "' and Password='" & PassBox.Text & "'", koneksiSQL)

        DR = SQLCmd.ExecuteReader

        If DR.Read Then

            UserBox.Focus()
            PassBox.Focus()
            MsgBox("Login Succesfull !")
            Main_Menu.Show()
            Me.Hide()

        Else
            MsgBox("Sorry Login Failed ! Wrong Username & Password !")

            UserBox.Clear()

            PassBox.Clear()

            UserBox.Focus()
        End If
    End Sub
    Private Sub QuitBut_Click(sender As Object, e As EventArgs) Handles QuitBut.Click
        MsgBox("Are you sure quit ?", vbQuestion + vbYesNo, "Confirmation")

        Close()
    End Sub

End Class