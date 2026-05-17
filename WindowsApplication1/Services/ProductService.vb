Imports System.ComponentModel
Imports Point_of_Sale_System.Models
Imports Point_of_Sale_System.Repositories

Public Class ProductService
    Private ReadOnly _products As New ProductRepository()
    Private Sub ValidateProduct(product As Product)
        If String.IsNullOrWhiteSpace(product.Barcode) Then
            Throw New ArgumentException("Barcode is required.")
        End If
        If String.IsNullOrWhiteSpace(product.Name) Then
            Throw New ArgumentException("Product name is required.")
        End If
        If product.Price < 0D Then
            Throw New ArgumentException("Price cannot be negative.")
        End If
        If product.StockQuantity < 0 Then
            Throw New ArgumentException("Stock cannot be negative.")
        End If
    End Sub
    Public Sub Save(product As Product)
        ValidateProduct(product)

        If product.Id = 0 Then
            _products.Add(product)
        Else
            _products.Update(product)
        End If
    End Sub
    Public Function FindByBarcode(barcode As String) As Product
        Dim results = _products.Search(barcode)
        For Each p In results
            If p.Barcode = barcode Then
                Return p
            End If
        Next
        Return Nothing
    End Function
    Public Function Search(term As String) As List(Of Product)
        Return _products.Search(term)
    End Function

    Public Sub Deactivate(productId As Integer)
        _products.Deactivate(productId)
    End Sub
    Public Function GetAll() As List(Of Product)
        Return _products.GetAll()
    End Function
End Class
