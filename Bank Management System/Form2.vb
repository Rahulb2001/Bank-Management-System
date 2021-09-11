Imports System.Data.SqlClient
Public Class Form2
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Desktop\vap  project\Bank Management System\bin\Debug\BankingDatabe.mdf;Integrated Security=True;Connect Timeout=30")
    Dim sqlstr As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        sqlstr = "select * from Login where phoneno='" & TextBox1.Text & "' And password='" & TextBox2.Text & "'"
        con.Open()
            Dim cmd As SqlCommand = New SqlCommand(sqlstr, con)
            Dim dr1 As SqlDataReader = cmd.ExecuteReader
            If dr1.Read Then
                Me.Hide()
                MDIParent1.Show()
            Else
                MessageBox.Show("Entered Username or password is incorrect")
            End If
            con.Close()



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        con.Open()
        sqlstr = "insert into login values('" & TextBox3.Text & "','" & TextBox4.Text & "','" & ComboBox1.SelectedItem.ToString & "','" & TextBox6.Text & "','" & TextBox7.Text & "')"
        Dim cmd As SqlCommand = New SqlCommand(sqlstr, con)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Admin Added SucessFully")
        con.Close()
        TextBox3.Text = " "
        TextBox4.Text = " "
        TextBox6.Text = " "
        TextBox7.Text = " "
    End Sub
End Class