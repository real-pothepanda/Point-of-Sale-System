Imports System.Collections.Generic

Namespace Models

    Public Class Sale
        Public Property Id As Integer
        Public Property CashierId As Integer
        Public Property TotalAmount As Decimal
        Public Property Items As New List(Of SaleItem)
    End Class
End Namespace

