Imports System.Data.SqlClient

Public Class Form5
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Desktop\vap  project\Bank Management System\bin\Debug\BankingDatabe.mdf;Integrated Security=True;Connect Timeout=30")
    Dim sqlstr As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Text = " "
        TextBox3.Text = " "
        TextBox4.Text = " "
        TextBox1.Text = " "
        sqlstr = "select Max(tranNO) + 1 from tranTab"
        con.Open()
        Dim cmd As SqlCommand = New SqlCommand(sqlstr, con)
        Dim dr1 As SqlDataReader = cmd.ExecuteReader
        If dr1.Read Then
            TextBox1.Text = IIf(IsDBNull(dr1(0)), 1001, dr1(0))
        End If
        con.Close()
        TextBox2.Select()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sqlstr = "insert into tranTab values('" & TextBox1.Text & "','" & Date.Today.ToString & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','0','" & TextBox5.Text & "')"
        con.Open()
        Dim cmd1 As SqlCommand = New SqlCommand(sqlstr, con)
        cmd1.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Account Saved Sucessfully ")


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    'Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles TextBox2.Leave
    'If TextBox1.Text = " " Then Exit Sub
    '   sqlstr = "select acName from accountTab where acNo" & TextBox2.Text & ""
    '  con.Open()
    'Dim cmd As SqlCommand = New SqlCommand(sqlstr, con)
    'Dim dr1 As SqlDataReader = cmd.ExecuteReader
    'If dr1.Read Then
    '       TextBox3.Text = dr1(0)
    'End If
    '   con.Close()
    '  TextBox2.Select()
    'End Sub
End Class