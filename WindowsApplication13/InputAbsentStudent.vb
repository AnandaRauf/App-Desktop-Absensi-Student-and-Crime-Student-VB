Imports System.Data
Imports System.Data.SqlClient
Public Class InputAbsentStudent
    Private Sub InputAbsentStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_ControlStudentDataSet.tbl_absent' table. You can move, or remove it, as needed.
        Me.Tbl_absentTableAdapter.Fill(Me.Db_ControlStudentDataSet.tbl_absent)

    End Sub

    Private Sub SaveBut_Click(sender As Object, e As EventArgs) Handles SaveBut.Click
        If NamStu.Text = "" Or Classroom.Text = "" Or TotalSick.Text = "" Or TotalPermit.Text = "" Or TotalNoDesc.Text = "" Or TotalPresent.Text = "" Then
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
            cmd.CommandText = "Insert into tbl_absent([Name_Student], [Classroom],[Total_Sick], [Total_Permit], [Total_Nodescription], [Total_Present]) VALUES('" & NamStu.Text & "','" & Classroom.Text & "','" & TotalSick.Text & "','" & TotalPermit.Text & "','" & TotalNoDesc.Text & "','" & TotalPresent.Text & "')"
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
            Dim da = New SqlDataAdapter("Select * From tbl_absent", koneksiSQL)
            Dim ds = New DataSet
            da.Fill(ds, "tbl_absent")
            TotalAbsentView.DataSource = ds.Tables("tbl_absent")

        Catch ex As Exception
        End Try
    End Sub
    Private Sub DelBut_Click(sender As Object, e As EventArgs) Handles DelBut.Click
        Call konekdatabase()
        Dim SQLCmd As New SqlCommand
        Dim DR As SqlDataReader
        SQLCmd = New SqlCommand("Delete * From tbl_absent where  Name_Student='" & NamStu.Text & "'  Classroom='" & Classroom.Text & "' Total_Sick='" & TotalSick.Text & "' Total_Permit='" & TotalPermit.Text & "' Total_Nodescription='" & TotalNoDesc.Text & "' Total_Present='" & TotalPresent.Text & "'", koneksiSQL)

        DR = SQLCmd.ExecuteReader

        If DR.Read Then

            NamStu.Focus()
            Classroom.Focus()
            TotalSick.Focus()
            TotalPermit.Focus()
            TotalNoDesc.Focus()
            TotalPresent.Focus()
            MsgBox("Deleted Succesfull !")
            Main_Menu.Show()
            Me.Hide()

        Else
            MsgBox("Sorry Deleted Has Been Failed ! Wrong Table & Column !")

            NamStu.Clear()
            Classroom.Clear()
            TotalSick.Clear()
            TotalPermit.Focus()
            TotalNoDesc.Clear()
            TotalPresent.Focus()
        End If
    End Sub
    Private Sub QuitBut_Click(sender As Object, e As EventArgs) Handles QuitBut.Click
        MsgBox("Are you sure quit ?", vbQuestion + vbYesNo, "Confirmation")

        Close()
    End Sub
End Class