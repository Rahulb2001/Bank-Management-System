<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MDIParent1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AcTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepositToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WithdrawToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckBalanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepositListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WithdrawListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcTypeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcTypeToolStripMenuItem, Me.AccountDetailsToolStripMenuItem, Me.DepositToolStripMenuItem, Me.WithdrawToolStripMenuItem, Me.CheckBalanceToolStripMenuItem, Me.ReportsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(971, 40)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AcTypeToolStripMenuItem
        '
        Me.AcTypeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.AcTypeToolStripMenuItem1})
        Me.AcTypeToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AcTypeToolStripMenuItem.Name = "AcTypeToolStripMenuItem"
        Me.AcTypeToolStripMenuItem.Size = New System.Drawing.Size(113, 36)
        Me.AcTypeToolStripMenuItem.Text = "Ac type "
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(180, 36)
        '
        'AccountDetailsToolStripMenuItem
        '
        Me.AccountDetailsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AccountDetailsToolStripMenuItem.Name = "AccountDetailsToolStripMenuItem"
        Me.AccountDetailsToolStripMenuItem.Size = New System.Drawing.Size(192, 36)
        Me.AccountDetailsToolStripMenuItem.Text = "Account Details"
        '
        'DepositToolStripMenuItem
        '
        Me.DepositToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DepositToolStripMenuItem.Name = "DepositToolStripMenuItem"
        Me.DepositToolStripMenuItem.Size = New System.Drawing.Size(108, 36)
        Me.DepositToolStripMenuItem.Text = "Deposit"
        '
        'WithdrawToolStripMenuItem
        '
        Me.WithdrawToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.WithdrawToolStripMenuItem.Name = "WithdrawToolStripMenuItem"
        Me.WithdrawToolStripMenuItem.Size = New System.Drawing.Size(122, 36)
        Me.WithdrawToolStripMenuItem.Text = "withdraw"
        '
        'CheckBalanceToolStripMenuItem
        '
        Me.CheckBalanceToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CheckBalanceToolStripMenuItem.Name = "CheckBalanceToolStripMenuItem"
        Me.CheckBalanceToolStripMenuItem.Size = New System.Drawing.Size(169, 36)
        Me.CheckBalanceToolStripMenuItem.Text = "checkBalance"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccountListToolStripMenuItem, Me.DepositListToolStripMenuItem, Me.WithdrawListToolStripMenuItem, Me.TransactionListToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(101, 36)
        Me.ReportsToolStripMenuItem.Text = "reports"
        '
        'AccountListToolStripMenuItem
        '
        Me.AccountListToolStripMenuItem.Name = "AccountListToolStripMenuItem"
        Me.AccountListToolStripMenuItem.Size = New System.Drawing.Size(250, 36)
        Me.AccountListToolStripMenuItem.Text = "Account List"
        '
        'DepositListToolStripMenuItem
        '
        Me.DepositListToolStripMenuItem.Name = "DepositListToolStripMenuItem"
        Me.DepositListToolStripMenuItem.Size = New System.Drawing.Size(250, 36)
        Me.DepositListToolStripMenuItem.Text = "Deposit List"
        '
        'WithdrawListToolStripMenuItem
        '
        Me.WithdrawListToolStripMenuItem.Name = "WithdrawListToolStripMenuItem"
        Me.WithdrawListToolStripMenuItem.Size = New System.Drawing.Size(250, 36)
        Me.WithdrawListToolStripMenuItem.Text = "Withdraw List"
        '
        'TransactionListToolStripMenuItem
        '
        Me.TransactionListToolStripMenuItem.Name = "TransactionListToolStripMenuItem"
        Me.TransactionListToolStripMenuItem.Size = New System.Drawing.Size(250, 36)
        Me.TransactionListToolStripMenuItem.Text = "Transaction List"
        '
        'AcTypeToolStripMenuItem1
        '
        Me.AcTypeToolStripMenuItem1.Name = "AcTypeToolStripMenuItem1"
        Me.AcTypeToolStripMenuItem1.Size = New System.Drawing.Size(180, 36)
        Me.AcTypeToolStripMenuItem1.Text = "Ac type "
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(971, 523)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "MDIParent1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin MDI"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AcTypeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccountDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DepositToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WithdrawToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckBalanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccountListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DepositListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WithdrawListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransactionListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AcTypeToolStripMenuItem1 As ToolStripMenuItem
End Class
