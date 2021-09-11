Imports System.Data.SqlClient
Public Class Form4
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Desktop\vap  project\Bank Management System\bin\Debug\BankingDatabe.mdf;Integrated Security=True;Connect Timeout=30")
    Dim sqlstr As String
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ac As New Random
        Dim rn As Double = ac.Next(100000, 1000000)
        TextBox1.Text = rn
        sqlstr = "select actypename from  actypeTab order by actypename"
        con.Open()
        Dim cmd As SqlCommand = New SqlCommand(sqlstr, con)
        Dim dr1 As SqlDataReader = cmd.ExecuteReader
        While dr1.Read
            ComboBox1.Items.Add(dr1(0))
        End While
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sqlstr = "insert into accountTab values('" & TextBox1.Text & "','" & ComboBox1.SelectedItem & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "')"
        con.Open()
        Dim cmd1 As SqlCommand = New SqlCommand(sqlstr, con)
        cmd1.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Account Saved Sucessfully ")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Text = " "
        TextBox3.Text = " "
        TextBox4.Text = " "
        TextBox5.Text = " "
        sqlstr = "select Max(acNO) + 1 from accountTab"
        con.Open()
        Dim cmd As SqlCommand = New SqlCommand(sqlstr, con)
        Dim dr1 As SqlDataReader = cmd.ExecuteReader
        If dr1.Read Then
            TextBox1.Text = IIf(IsDBNull(dr1(0)), 1001, dr1(0))
        End If
        con.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class