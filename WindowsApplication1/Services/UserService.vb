Imports System.ComponentModel
Imports Point_of_Sale_System.Models
Imports Point_of_Sale_System.Services

Public Class UserService
    Private ReadOnly _users As New UserRepository()
    Private ReadOnly _hasher As New PasswordHasher()
    Private Sub ValidateUser(user As AppUser, plainPassword As String)
        If String.IsNullOrWhiteSpace(user.FullName) Then
            Throw New ArgumentException("Full name is required.")
        End If
        If String.IsNullOrWhiteSpace(user.Username) Then
            Throw New ArgumentException("Username is required.")
        End If
        If user.Id = 0 AndAlso String.IsNullOrWhiteSpace(plainPassword) Then
            Throw New ArgumentException("Password is required for new users.")
        End If
        If user.Role <> "admin" AndAlso user.Role <> "cashier" Then
            Throw New ArgumentException("Role must be admin or cashier.")
        End If
    End Sub
    Public Sub Save(user As AppUser, plainPassword As String)
        ValidateUser(user, plainPassword)
        Dim shouldUpdatePassword = Not String.IsNullOrWhiteSpace(plainPassword)
        If shouldUpdatePassword Then
            user.PasswordHash = _hasher.HashPassword(plainPassword)
        End If
        If user.Id = 0 Then
            _users.Add(user)
        Else
            _users.Update(user, shouldUpdatePassword)
        End If
    End Sub
    Public Function GetAll() As List(Of AppUser)
        Return _users.GetAll()
    End Function
    Public Sub Deactivate(id As Integer)
        _users.Deactivate(id)
    End Sub
End Class
