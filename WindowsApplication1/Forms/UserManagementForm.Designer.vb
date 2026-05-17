<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserManagementForm
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
        Me.UserDetailsGroupBox = New System.Windows.Forms.GroupBox()
        Me.NoteLabel = New System.Windows.Forms.Label()
        Me.RoleComboBox = New System.Windows.Forms.ComboBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FullNameLabel = New System.Windows.Forms.Label()
        Me.DeactivateButton = New System.Windows.Forms.Button()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.NewButton = New System.Windows.Forms.Button()
        Me.RoleLabel = New System.Windows.Forms.Label()
        Me.ActiveCheckBox = New System.Windows.Forms.CheckBox()
        Me.FullNameTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.UsersGrid = New System.Windows.Forms.DataGridView()
        Me.UserDetailsGroupBox.SuspendLayout()
        CType(Me.UsersGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserDetailsGroupBox
        '
        Me.UserDetailsGroupBox.Controls.Add(Me.NoteLabel)
        Me.UserDetailsGroupBox.Controls.Add(Me.RoleComboBox)
        Me.UserDetailsGroupBox.Controls.Add(Me.PasswordTextBox)
        Me.UserDetailsGroupBox.Controls.Add(Me.Label2)
        Me.UserDetailsGroupBox.Controls.Add(Me.FullNameLabel)
        Me.UserDetailsGroupBox.Controls.Add(Me.DeactivateButton)
        Me.UserDetailsGroupBox.Controls.Add(Me.UsernameLabel)
        Me.UserDetailsGroupBox.Controls.Add(Me.SaveButton)
        Me.UserDetailsGroupBox.Controls.Add(Me.PasswordLabel)
        Me.UserDetailsGroupBox.Controls.Add(Me.NewButton)
        Me.UserDetailsGroupBox.Controls.Add(Me.RoleLabel)
        Me.UserDetailsGroupBox.Controls.Add(Me.ActiveCheckBox)
        Me.UserDetailsGroupBox.Controls.Add(Me.FullNameTextBox)
        Me.UserDetailsGroupBox.Controls.Add(Me.UsernameTextBox)
        Me.UserDetailsGroupBox.Location = New System.Drawing.Point(561, 14)
        Me.UserDetailsGroupBox.Name = "UserDetailsGroupBox"
        Me.UserDetailsGroupBox.Size = New System.Drawing.Size(325, 365)
        Me.UserDetailsGroupBox.TabIndex = 19
        Me.UserDetailsGroupBox.TabStop = False
        '
        'NoteLabel
        '
        Me.NoteLabel.AutoSize = True
        Me.NoteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoteLabel.Location = New System.Drawing.Point(14, 310)
        Me.NoteLabel.Name = "NoteLabel"
        Me.NoteLabel.Size = New System.Drawing.Size(219, 26)
        Me.NoteLabel.TabIndex = 19
        Me.NoteLabel.Text = "Leave password blank when editing to keep " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "it unchanged." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'RoleComboBox
        '
        Me.RoleComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoleComboBox.FormattingEnabled = True
        Me.RoleComboBox.Items.AddRange(New Object() {"admin", "cashier"})
        Me.RoleComboBox.Location = New System.Drawing.Point(90, 166)
        Me.RoleComboBox.Name = "RoleComboBox"
        Me.RoleComboBox.Size = New System.Drawing.Size(229, 21)
        Me.RoleComboBox.TabIndex = 18
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.Location = New System.Drawing.Point(90, 126)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(229, 20)
        Me.PasswordTextBox.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "User Details"
        '
        'FullNameLabel
        '
        Me.FullNameLabel.AutoSize = True
        Me.FullNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FullNameLabel.Location = New System.Drawing.Point(7, 49)
        Me.FullNameLabel.Name = "FullNameLabel"
        Me.FullNameLabel.Size = New System.Drawing.Size(57, 13)
        Me.FullNameLabel.TabIndex = 5
        Me.FullNameLabel.Text = "Full Name:"
        '
        'DeactivateButton
        '
        Me.DeactivateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeactivateButton.Location = New System.Drawing.Point(217, 240)
        Me.DeactivateButton.Name = "DeactivateButton"
        Me.DeactivateButton.Size = New System.Drawing.Size(88, 23)
        Me.DeactivateButton.TabIndex = 16
        Me.DeactivateButton.Text = "Delete"
        Me.DeactivateButton.UseVisualStyleBackColor = True
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.Location = New System.Drawing.Point(14, 89)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(58, 13)
        Me.UsernameLabel.TabIndex = 6
        Me.UsernameLabel.Text = "Username:"
        '
        'SaveButton
        '
        Me.SaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(123, 240)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(88, 23)
        Me.SaveButton.TabIndex = 15
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.Location = New System.Drawing.Point(14, 129)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(56, 13)
        Me.PasswordLabel.TabIndex = 7
        Me.PasswordLabel.Text = "Password:"
        '
        'NewButton
        '
        Me.NewButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton.Location = New System.Drawing.Point(27, 240)
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Size = New System.Drawing.Size(88, 23)
        Me.NewButton.TabIndex = 14
        Me.NewButton.Text = "New"
        Me.NewButton.UseVisualStyleBackColor = True
        '
        'RoleLabel
        '
        Me.RoleLabel.AutoSize = True
        Me.RoleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoleLabel.Location = New System.Drawing.Point(42, 169)
        Me.RoleLabel.Name = "RoleLabel"
        Me.RoleLabel.Size = New System.Drawing.Size(32, 13)
        Me.RoleLabel.TabIndex = 8
        Me.RoleLabel.Text = "Role:"
        '
        'ActiveCheckBox
        '
        Me.ActiveCheckBox.AutoSize = True
        Me.ActiveCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActiveCheckBox.Location = New System.Drawing.Point(249, 208)
        Me.ActiveCheckBox.Name = "ActiveCheckBox"
        Me.ActiveCheckBox.Size = New System.Drawing.Size(56, 17)
        Me.ActiveCheckBox.TabIndex = 13
        Me.ActiveCheckBox.Text = "Active"
        Me.ActiveCheckBox.UseVisualStyleBackColor = True
        '
        'FullNameTextBox
        '
        Me.FullNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FullNameTextBox.Location = New System.Drawing.Point(90, 46)
        Me.FullNameTextBox.Name = "FullNameTextBox"
        Me.FullNameTextBox.Size = New System.Drawing.Size(229, 20)
        Me.FullNameTextBox.TabIndex = 9
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTextBox.Location = New System.Drawing.Point(90, 86)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(229, 20)
        Me.UsernameTextBox.TabIndex = 10
        '
        'UsersGrid
        '
        Me.UsersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsersGrid.Location = New System.Drawing.Point(12, 14)
        Me.UsersGrid.Name = "UsersGrid"
        Me.UsersGrid.Size = New System.Drawing.Size(543, 422)
        Me.UsersGrid.TabIndex = 20
        '
        'UserManagementForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 448)
        Me.Controls.Add(Me.UsersGrid)
        Me.Controls.Add(Me.UserDetailsGroupBox)
        Me.Name = "UserManagementForm"
        Me.Text = "User Management Form"
        Me.UserDetailsGroupBox.ResumeLayout(False)
        Me.UserDetailsGroupBox.PerformLayout()
        CType(Me.UsersGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UserDetailsGroupBox As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents FullNameLabel As Label
    Friend WithEvents DeactivateButton As Button
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents SaveButton As Button
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents NewButton As Button
    Friend WithEvents RoleLabel As Label
    Friend WithEvents ActiveCheckBox As CheckBox
    Friend WithEvents FullNameTextBox As TextBox
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents RoleComboBox As ComboBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents UsersGrid As DataGridView
    Friend WithEvents NoteLabel As Label
End Class
