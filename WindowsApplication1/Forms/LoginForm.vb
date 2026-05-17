Imports Point_of_Sale_System.Services

Partial Public Class LoginForm

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
        Try
            Dim user = _auth.Login(UsernameTextBox.Text, PasswordTextBox.Text)
            If user Is Nothing Then
                MessageLabel.Text = "Invalid username or password."
                Return
            End If

            Session.CurrentUser = user
            MessageLabel.Text = String.Empty
            Hide()

            If user.Role = "admin" Then
                Using form As New AdminDashboardForm()
                    form.ShowDialog(Me)
                End Using
            Else
                Using form As New PosForm()
                    form.ShowDialog(Me)
                End Using
            End If

            Session.CurrentUser = Nothing
            PasswordTextBox.Clear()
            Show()
            UsernameTextBox.Focus()
        Catch ex As Exception
            MessageLabel.Text = ex.Message
        End Try
    End Sub
End Class