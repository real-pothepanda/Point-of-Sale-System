<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.MessageLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(71, 39)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(193, 25)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "Point of Sale System"
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.Location = New System.Drawing.Point(43, 106)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(58, 13)
        Me.UsernameLabel.TabIndex = 1
        Me.UsernameLabel.Text = "Username:"
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.Location = New System.Drawing.Point(43, 154)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(56, 13)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "Password:"
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTextBox.Location = New System.Drawing.Point(130, 103)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(174, 20)
        Me.UsernameTextBox.TabIndex = 3
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.Location = New System.Drawing.Point(130, 151)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(174, 20)
        Me.PasswordTextBox.TabIndex = 4
        '
        'LoginButton
        '
        Me.LoginButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginButton.Location = New System.Drawing.Point(229, 189)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(75, 28)
        Me.LoginButton.TabIndex = 5
        Me.LoginButton.Text = "Login"
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'MessageLabel
        '
        Me.MessageLabel.AutoSize = True
        Me.MessageLabel.Location = New System.Drawing.Point(43, 228)
        Me.MessageLabel.Name = "MessageLabel"
        Me.MessageLabel.Size = New System.Drawing.Size(37, 13)
        Me.MessageLabel.TabIndex = 6
        Me.MessageLabel.Text = "          "
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 261)
        Me.Controls.Add(Me.MessageLabel)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.TitleLabel)
        Me.Name = "LoginForm"
        Me.Text = "LoginForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TitleLabel As Label
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents LoginButton As Button
    Friend WithEvents MessageLabel As Label
End Class
