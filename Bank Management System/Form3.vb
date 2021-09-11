Imports System.Data.SqlClient
Public Class Form3
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Desktop\vap  project\Bank Management System\bin\Debug\BankingDatabe.mdf;Integrated Security=True;Connect Timeout=30")
    Dim sqlstr As String

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = " "
        TextBox2.Text = " "
        TextBox1.Select()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sqlstr = "select * from actypeTab where actypename='" & TextBox1.Text & "'"
        con.Open()
        Dim cmd As SqlCommand = New SqlCommand(sqlstr, con)
        Dim dr1 As SqlDataReader = cmd.ExecuteReader
        If dr1.Read Then
            MessageBox.Show("This Account Type is Already Present ")
            Exit Sub
        End If
        con.Close()
        sqlstr = "insert into actypeTab values('" & TextBox1.Text & "','" & TextBox2.Text & "')"
        con.Open()
        Dim cmd1 As SqlCommand = New SqlCommand(sqlstr, con)
        cmd1.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Account Saved Sucessfully ")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class