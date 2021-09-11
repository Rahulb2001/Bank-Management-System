Imports System.Data.SqlClient
Public Class Form9
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Desktop\vap  project\Bank Management System\bin\Debug\BankingDatabe.mdf;Integrated Security=True;Connect Timeout=30")
    Dim sqlstr As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sqlstr = "select tranNo,tranDate,acno,deposit from tranTab order by tranNo"
        If con.State = ConnectionState.Open Then con.Close()
        con.Open()
        Dim ds1 As New DataSet
        Dim adp As SqlDataAdapter = New SqlDataAdapter(sqlstr, con)
        adp.Fill(ds1)
        DataGridView1.DataSource = ds1.Tables(0)
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class