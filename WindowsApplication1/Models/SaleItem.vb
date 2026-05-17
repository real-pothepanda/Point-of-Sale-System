Namespace Models
    Public Class SaleItem
        Public Property ProductID As Integer
        Public Property Barcode As String
        Public Property ProductName As String
        Public Property Quantity As Integer
        Public Property UnitPrice As Decimal
        Public ReadOnly Property LineTotal As Decimal
            Get
                Return Quantity * UnitPrice
            End Get
        End Property
    End Class
End Namespace

