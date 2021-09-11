Imports System.Data.SqlClient
Public Class Form8
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Desktop\vap  project\Bank Management System\bin\Debug\BankingDatabe.mdf;Integrated Security=True;Connect Timeout=30")
    Dim sqlstr As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sqlstr = "update tranTab set withdraw = '" & TextBox4.Text & "' where acno = '" & TextBox2.Text & "'"
        'sqlstr = "insert into tranTab values('" & TextBox1.Text & "','" & Date.Today.ToString & "','" & TextBox2.Text & "','" & TextBox3.Text & "','0','" & TextBox4.Text & "','" & TextBox5.Text & "')"
        con.Open()
        Dim cmd1 As SqlCommand = New SqlCommand(sqlstr, con)
        cmd1.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("withdrawn  Sucessfully ")
        TextBox2.Text = " "
        TextBox3.Text = " "
        TextBox4.Text = " "
        TextBox5.Text = " "

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class