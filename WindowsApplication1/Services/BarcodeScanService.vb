
Namespace Services
    Public Class BarcodeScanService
        Public Function Parse(input As String) As ScanRequest
            Dim text = If(input, String.Empty).Trim()
            If text.Length = 0 Then
                Throw New ArgumentException("Please scan or type a barcode.")
            End If

            If text.Contains("*") Then
                Dim parts = text.Split("*"c)
                If parts.Length <> 2 OrElse parts(0).Trim().Length = 0 OrElse parts(1).Trim().Length = 0 Then
                    Throw New ArgumentException("Use QTY*BARCODE, for example 3*480000000001.")
                End If

                Dim quantity As Integer
                If Not Integer.TryParse(parts(0).Trim(), quantity) OrElse quantity <= 0 Then
                    Throw New ArgumentException("Quantity must be a positive whole number.")
                End If

                Return New ScanRequest With {.Quantity = quantity, .Barcode = parts(1).Trim()}
            End If

            Return New ScanRequest With {.Quantity = 1, .Barcode = text}
        End Function
    End Class
End Namespace
