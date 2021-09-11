Imports System.Windows.Forms

Public Class MDIParent1

    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AcTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcTypeToolStripMenuItem.Click

        Form3.WindowState = 2
        Form3.MdiParent = Me
        Form3.Show()
    End Sub

    Private Sub AccountDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccountDetailsToolStripMenuItem.Click
        Form4.WindowState = 2
        Form4.MdiParent = Me
        Form4.Show()
    End Sub

    Private Sub DepositToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepositToolStripMenuItem.Click
        Form5.WindowState = 2
        Form5.MdiParent = Me
        Form5.Show()
    End Sub

    Private Sub CheckBalanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckBalanceToolStripMenuItem.Click
        Form6.WindowState = 2
        Form6.MdiParent = Me
        Form6.Show()
    End Sub

    Private Sub AccountListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccountListToolStripMenuItem.Click
        Form7.WindowState = 2
        Form7.MdiParent = Me
        Form7.Show()
    End Sub

    Private Sub WithdrawToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WithdrawToolStripMenuItem.Click
        Form8.WindowState = 2
        Form8.MdiParent = Me
        Form8.Show()
    End Sub

    Private Sub DepositListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepositListToolStripMenuItem.Click
        Form9.WindowState = 2
        Form9.MdiParent = Me
        Form9.Show()
    End Sub

    Private Sub WithdrawListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WithdrawListToolStripMenuItem.Click
        Form10.WindowState = 2
        Form10.MdiParent = Me
        Form10.Show()
    End Sub

    Private Sub TransactionListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransactionListToolStripMenuItem.Click
        Form11.WindowState = 2
        Form11.MdiParent = Me
        Form11.Show()
    End Sub
End Class
