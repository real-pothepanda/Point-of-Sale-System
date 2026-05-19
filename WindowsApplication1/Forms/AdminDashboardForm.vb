Imports Point_of_Sale_System.Services

Partial Public Class AdminDashboardForm

    Public Sub New()
        InitializeComponent()
        Dim nameText = If(Session.CurrentUser Is Nothing, "Admin", Session.CurrentUser.FullName)
        SubtitleLabel.Text = "Logged in as " & nameText
    End Sub

    Private Sub ProductsButton_Click(sender As Object, e As EventArgs) Handles ProductsButton.Click
        Using form As New ProductManagementForm()
            form.ShowDialog(Me)
        End Using
    End Sub

    Private Sub UsersButton_Click(sender As Object, e As EventArgs) Handles UsersButton.Click
        Using form As New UserManagementForm()
            form.ShowDialog(Me)
        End Using
    End Sub

    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        Session.CurrentUser = Nothing
        Dim loginScreen = Application.OpenForms.OfType(Of LoginForm)().FirstOrDefault()

        If loginScreen IsNot Nothing Then
            loginScreen.PasswordTextBox.Clear()
            loginScreen.Show()
        End If
        Me.Close()
    End Sub
End Class
