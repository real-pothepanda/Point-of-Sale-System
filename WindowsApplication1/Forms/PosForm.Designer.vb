<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PosForm
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
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.UserLabel = New System.Windows.Forms.Label()
        Me.ScanLabel = New System.Windows.Forms.Label()
        Me.HintLabel = New System.Windows.Forms.Label()
        Me.ScanTextBox = New System.Windows.Forms.TextBox()
        Me.CartGrid = New System.Windows.Forms.DataGridView()
        Me.RemoveButon = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.LogoutButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.StatusLabel = New System.Windows.Forms.Label()
        CType(Me.CartGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(11, 14)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(89, 17)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "Cashier POS"
        '
        'UserLabel
        '
        Me.UserLabel.AutoSize = True
        Me.UserLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserLabel.Location = New System.Drawing.Point(11, 43)
        Me.UserLabel.Name = "UserLabel"
        Me.UserLabel.Size = New System.Drawing.Size(106, 13)
        Me.UserLabel.TabIndex = 1
        Me.UserLabel.Text = "Logged in as Cashier"
        '
        'ScanLabel
        '
        Me.ScanLabel.AutoSize = True
        Me.ScanLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScanLabel.Location = New System.Drawing.Point(11, 84)
        Me.ScanLabel.Name = "ScanLabel"
        Me.ScanLabel.Size = New System.Drawing.Size(104, 13)
        Me.ScanLabel.TabIndex = 2
        Me.ScanLabel.Text = "Scan/Type Barcode"
        '
        'HintLabel
        '
        Me.HintLabel.AutoSize = True
        Me.HintLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HintLabel.Location = New System.Drawing.Point(438, 84)
        Me.HintLabel.Name = "HintLabel"
        Me.HintLabel.Size = New System.Drawing.Size(135, 13)
        Me.HintLabel.TabIndex = 3
        Me.HintLabel.Text = "Example: 3*480000000001"
        '
        'ScanTextBox
        '
        Me.ScanTextBox.Location = New System.Drawing.Point(14, 108)
        Me.ScanTextBox.Name = "ScanTextBox"
        Me.ScanTextBox.Size = New System.Drawing.Size(629, 20)
        Me.ScanTextBox.TabIndex = 4
        '
        'CartGrid
        '
        Me.CartGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CartGrid.Location = New System.Drawing.Point(14, 145)
        Me.CartGrid.Name = "CartGrid"
        Me.CartGrid.Size = New System.Drawing.Size(645, 278)
        Me.CartGrid.TabIndex = 5
        '
        'RemoveButon
        '
        Me.RemoveButon.Location = New System.Drawing.Point(14, 429)
        Me.RemoveButon.Name = "RemoveButon"
        Me.RemoveButon.Size = New System.Drawing.Size(106, 30)
        Me.RemoveButon.TabIndex = 6
        Me.RemoveButon.Text = "Remove Item"
        Me.RemoveButon.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(126, 429)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(106, 30)
        Me.ClearButton.TabIndex = 7
        Me.ClearButton.Text = "Clear Cart"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'LogoutButton
        '
        Me.LogoutButton.Location = New System.Drawing.Point(553, 429)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Size = New System.Drawing.Size(106, 30)
        Me.LogoutButton.TabIndex = 8
        Me.LogoutButton.Text = "Logout"
        Me.LogoutButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(441, 429)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(106, 30)
        Me.SaveButton.TabIndex = 9
        Me.SaveButton.Text = "Save Sale"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalLabel.Location = New System.Drawing.Point(339, 436)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(76, 17)
        Me.TotalLabel.TabIndex = 11
        Me.TotalLabel.Text = "Total: 0.00"
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.Location = New System.Drawing.Point(14, 466)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(40, 13)
        Me.StatusLabel.TabIndex = 12
        Me.StatusLabel.Text = "           "
        '
        'PosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 490)
        Me.Controls.Add(Me.StatusLabel)
        Me.Controls.Add(Me.TotalLabel)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.LogoutButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.RemoveButon)
        Me.Controls.Add(Me.CartGrid)
        Me.Controls.Add(Me.ScanTextBox)
        Me.Controls.Add(Me.HintLabel)
        Me.Controls.Add(Me.ScanLabel)
        Me.Controls.Add(Me.UserLabel)
        Me.Controls.Add(Me.TitleLabel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "PosForm"
        Me.Text = "Pos Form"
        CType(Me.CartGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TitleLabel As Label
    Friend WithEvents UserLabel As Label
    Friend WithEvents ScanLabel As Label
    Friend WithEvents HintLabel As Label
    Friend WithEvents ScanTextBox As TextBox
    Friend WithEvents CartGrid As DataGridView
    Friend WithEvents RemoveButon As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents LogoutButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents TotalLabel As Label
    Friend WithEvents StatusLabel As Label
End Class
