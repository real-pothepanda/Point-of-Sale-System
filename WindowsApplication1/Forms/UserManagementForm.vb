Imports System.ComponentModel
Imports Point_of_Sale_System.Models
Imports Point_of_Sale_System.Services

Public Class UserManagementForm
    Private ReadOnly _service As New UserService()
    Private _selectedId As Integer = 0
    Private Sub UsersGrid_SelectionChanged(sender As Object, e As EventArgs) Handles UsersGrid.SelectionChanged
        If UsersGrid.SelectedRows.Count = 0 OrElse UsersGrid.CurrentRow Is Nothing OrElse
UsersGrid.CurrentRow.DataBoundItem Is Nothing Then
            Return
        End If

        Dim user = DirectCast(UsersGrid.CurrentRow.DataBoundItem, AppUser)
        _selectedId = user.Id
        FullNameTextBox.Text = user.FullName
        UsernameTextBox.Text = user.Username
        PasswordTextBox.Clear()
        RoleComboBox.SelectedItem = user.Role
        ActiveCheckBox.Checked = user.IsActive
    End Sub
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Try
            Dim role = If(RoleComboBox.SelectedItem Is Nothing, "cashier", RoleComboBox.SelectedItem.ToString())
            Dim user As New AppUser With {
                .Id = _selectedId,
                .FullName = FullNameTextBox.Text.Trim(),
                .Username = UsernameTextBox.Text.Trim(),
                .Role = role,
                .IsActive = ActiveCheckBox.Checked
            }

            _service.Save(user, PasswordTextBox.Text)
            LoadUsers()
            MessageBox.Show("User saved.", "Users", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Users", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Private Sub ClearForm()
        _selectedId = 0
        FullNameTextBox.Clear()
        UsernameTextBox.Clear()
        PasswordTextBox.Clear()
        RoleComboBox.SelectedIndex = -1
        ActiveCheckBox.Checked = True
    End Sub
    Private Sub LoadUsers()
        UsersGrid.DataSource = Nothing
        UsersGrid.DataSource = _service.GetAll()
        UsersGrid.ClearSelection()
        ClearForm()
    End Sub

    Private Sub UserManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUsers()
    End Sub

    Private Sub NewButton_Click(sender As Object, e As EventArgs) Handles NewButton.Click
        ClearForm()
        UsersGrid.ClearSelection()
        FullNameTextBox.Focus()
    End Sub

    Private Sub DeactivateButton_Click(sender As Object, e As EventArgs) Handles DeactivateButton.Click
        If _selectedId = 0 Then
            MessageBox.Show("Please select a user to delete.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If MessageBox.Show("Are you sure you want to PERMANENTLY delete this user?", "Confirm Nuclear Strike", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                _service.Deactivate(_selectedId)
                LoadUsers()
                ClearForm()

                MessageBox.Show("User completely vaporized from the timeline.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error deleting user: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class