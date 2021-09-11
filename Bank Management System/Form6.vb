Imports System.Data.SqlClient
Public Class Form6
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Desktop\vap  project\Bank Management System\bin\Debug\BankingDatabe.mdf;Integrated Security=True;Connect Timeout=30")
    Dim sqlstr As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'sqlstr = " select tranNO, tranDate,acno,name,deposit,withdraw-deposit as  Balance from tranTab where acNo = " & TextBox1.Text & ""
        ' sqlstr = " select deposit from tranTab where acno = " & TextBox1.Text & ""
        ' con.Open()
        ' Dim cmd As SqlCommand = New SqlCommand(sqlstr, con)
        ' Dim dr1 As SqlDataReader = cmd.ExecuteReader
        ' dr1.Read()
        ' TextBox2.Text = dr1("deposit")
        'con.Close()
        'Dim d As Double = TextBox2.Text

        sqlstr = "select sum(deposit) - sum(withdraw) as balance from tranTab where acno = " & TextBox1.Text & ""
        If con.State = ConnectionState.Open Then con.Close()
        con.Open()
        Dim cmd1 As SqlCommand = New SqlCommand(sqlstr, con)
        Dim dr1 As SqlDataReader = cmd1.ExecuteReader
        If dr1.Read Then
            TextBox3.Text = IIf(IsDBNull(dr1(0)), 0, dr1(0))
        End If
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        TextBox2.Text = "not found "
        sqlstr = "select name from tranTab where acno = " & TextBox1.Text & ""
        con.Open()
        Dim cmd1 As SqlCommand = New SqlCommand(sqlstr, con)
        Dim dr1 As SqlDataReader = cmd1.ExecuteReader
        If dr1.Read Then
            TextBox2.Text = dr1(0)
        End If
        con.Close()
    End Sub
End Class