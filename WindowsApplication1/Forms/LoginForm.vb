Imports Point_of_Sale_System.Services

Partial Public Class LoginForm
    Private ReadOnly _userService As New UserService()
    Private ReadOnly _auth As New AuthService()

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub PasswordTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles PasswordTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            LoginButton_Click(sender, EventArgs.Empty)
        End If
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim typedPassword As String = PasswordTextBox.Text
        Dim hasher As New PasswordHasher()
        Dim scrambledInput As String = hasher.HashPassword(typedPassword)
        Dim user = _userService.Authenticate(UsernameTextBox.Text, scrambledInput)

        If user IsNot Nothing Then
            If user.IsActive = False Then
                MessageBox.Show("You're fired quietly; please contact HR for details.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                PasswordTextBox.Clear()
                UsernameTextBox.Focus()
                Return
            End If
            Session.CurrentUser = user
            If user.Role.ToLower() = "admin" Then
                Dim adminForm As New AdminDashboardForm()
                adminForm.Show()

            ElseIf user.Role.ToLower() = "cashier" Then
                Dim posForm As New PosForm()
                posForm.Show()
            Else
                MessageBox.Show("Unknown system role detected. Please contact IT.", "Security Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class