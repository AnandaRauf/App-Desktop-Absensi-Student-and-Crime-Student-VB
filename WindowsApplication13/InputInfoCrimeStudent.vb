Imports System.Data
Imports System.Data.SqlClient
Public Class InputInfoCrimeStudent
    Private Sub InputInfoCrimeStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_ControlStudentDataSet6.tbl_criminal' table. You can move, or remove it, as needed.
        Me.Tbl_criminalTableAdapter6.Fill(Me.Db_ControlStudentDataSet6.tbl_criminal)



    End Sub

    Private Sub SaveBut_Click(sender As Object, e As EventArgs) Handles SaveBut.Click
        If NamStu.Text = "" Or Classroom.Text = "" Or CrimeInfo.Text = "" Or TotalCrime.Text = "" Then
            MsgBox("Your Data Empty !", MsgBoxStyle.Critical, "Data Empty")
            NamStu.Focus()
        Else
            MessageBox.Show("Save Data Succesfull")
        End If
        Dim cons As New SqlConnection
        Dim cmd As New SqlCommand
        Try
            cons.ConnectionString = ("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Penting\Db SQL Server Project App Desktop\db_ControlStudent.mdf;Integrated Security=True;Connect Timeout=30")
            cons.Open()
            cmd.Connection = cons
            cmd.CommandText = "Insert into tbl_criminal([Name_Student], [Classroom],[Criminal_Info], [Total_Criminal]) VALUES('" & NamStu.Text & "','" & Classroom.Text & "','" & CrimeInfo.Text & "','" & TotalCrime.Text & "')"
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally
            cons.Close()
        End Try
    End Sub
    Sub ShowTotalAbsent()
        Try
            Call konekdatabase()
            Dim da = New SqlDataAdapter("Select * From tbl_criminal", koneksiSQL)
            Dim ds = New DataSet
            da.Fill(ds, "tbl_criminal")
            TotalInfoCrimeView.DataSource = ds.Tables("tbl_criminal")

        Catch ex As Exception
        End Try
    End Sub
    Private Sub DelBut_Click(sender As Object, e As EventArgs) Handles DelBut.Click
        Call konekdatabase()
        Dim SQLCmd As New SqlCommand
        Dim DR As SqlDataReader
        SQLCmd = New SqlCommand("Delete * From tbl_criminal where  Name_Student='" & NamStu.Text & "'  Classroom='" & Classroom.Text & "' Criminal_Info='" & CrimeInfo.Text & "' Total_Criminal='" & TotalCrime.Text & "'", koneksiSQL)

        DR = SQLCmd.ExecuteReader

        If DR.Read Then
            NamStu.Focus()
            Classroom.Focus()
            CrimeInfo.Focus()
            TotalCrime.Focus()
            MsgBox("Deleted Succesfull !")
            Main_Menu.Show()
            Me.Hide()

        Else
            MsgBox("Sorry Deleted Has Been Failed ! Wrong Table & Column !")

            NamStu.Clear()
            Classroom.Clear()
            CrimeInfo.Clear()
            TotalCrime.Clear()


        End If
    End Sub
    Private Sub QuitBut_Click(sender As Object, e As EventArgs) Handles QuitBut.Click
        MsgBox("Are you sure quit ?", vbQuestion + vbYesNo, "Confirmation")

        Close()
    End Sub
End Class