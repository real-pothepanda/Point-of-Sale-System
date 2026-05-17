Imports System.ComponentModel
Imports Point_of_Sale_System.Models
Imports Point_of_Sale_System.Repositories

Public Class SaleService
    Private ReadOnly _sales As New SaleRepository()
    Public Function SaveSale(cashierId As Integer, items As List(Of SaleItem)) As Integer
        If items Is Nothing OrElse items.Count = 0 Then
            Throw New ArgumentException("Cart is empty.")
        End If

        Dim sale As New Sale With {
            .CashierId = cashierId,
            .TotalAmount = items.Sum(Function(item) item.LineTotal),
            .Items = items
        }

        Return _sales.Save(sale)
    End Function
End Class
