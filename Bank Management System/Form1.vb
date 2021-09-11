Public Class Form1
    Dim ivar As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ivar = ivar + 1
        If ivar > 5 Then
            Timer1.Enabled = False
            Form2.Show()
        End If
    End Sub
End Class
