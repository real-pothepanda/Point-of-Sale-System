Imports System.ComponentModel
Imports Point_of_Sale_System.Models
Imports Point_of_Sale_System.Services

Public Class PosForm
    Private ReadOnly _cart As New BindingList(Of SaleItem)()
    Private ReadOnly _scanService As New BarcodeScanService()
    Private ReadOnly _productService As New ProductService()
    Private ReadOnly _saleService As New SaleService()

    Public Sub New()
        InitializeComponent()
        Dim cashierName = If(Session.CurrentUser Is Nothing, "Cashier", Session.CurrentUser.FullName)
        UserLabel.Text = "Logged in as " & cashierName
        CartGrid.DataSource = _cart
    End Sub

    Private Sub ScanTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles ScanTextBox.KeyDown
        If e.KeyCode <> Keys.Enter Then
            Return
        End If

        e.SuppressKeyPress = True
        Try
            Dim scan = _scanService.Parse(ScanTextBox.Text)
            Dim product = _productService.FindByBarcode(scan.Barcode)

            If product Is Nothing Then
                ShowStatus("Barcode not found: " & scan.Barcode)
                Return
            End If

            If product.IsActive = False Then
                MessageBox.Show("This product has been deactivated and cannot be sold!", "Scan Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ScanTextBox.Clear()
                ScanTextBox.Focus()
                Return
            End If

            AddToCart(product, scan.Quantity)
            ShowStatus("Added " & scan.Quantity.ToString() & " x " & product.Name, Color.DarkGreen)
        Catch ex As Exception
            ShowStatus(ex.Message)
        Finally
            ScanTextBox.Clear()
            ScanTextBox.Focus()
        End Try
    End Sub

    Private Sub AddToCart(product As Product, quantity As Integer)
        Dim existing = _cart.FirstOrDefault(Function(item) item.ProductID = product.Id)
        If existing Is Nothing Then
            _cart.Add(New SaleItem With {
                .ProductID = product.Id,
                .Barcode = product.Barcode,
                .ProductName = product.Name,
                .Quantity = quantity,
                .UnitPrice = product.Price
            })
        Else
            existing.Quantity += quantity
            _cart.ResetBindings()
        End If

        RefreshTotal()
    End Sub

    Private Sub RefreshTotal()
        TotalLabel.Text = "Total: " & _cart.Sum(Function(item) item.LineTotal).ToString("N2")
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Try
            If Session.CurrentUser Is Nothing Then
                MessageBox.Show("No cashier session found.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim saleId = _saleService.SaveSale(Session.CurrentUser.Id, _cart.ToList())
            MessageBox.Show("Sale saved. Sale No: " & saleId.ToString(), "POS", MessageBoxButtons.OK, MessageBoxIcon.Information)

            _cart.Clear()
            RefreshTotal()
            ScanTextBox.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub ShowStatus(message As String, Optional textColor As System.Drawing.Color = Nothing)
        StatusLabel.Text = message
        If textColor <> Nothing Then
            StatusLabel.ForeColor = textColor
        Else
            StatusLabel.ForeColor = System.Drawing.Color.Red
        End If
    End Sub

    Private Sub RemoveButon_Click(sender As Object, e As EventArgs) Handles RemoveButon.Click
        If CartGrid.CurrentRow Is Nothing OrElse CartGrid.CurrentRow.DataBoundItem Is Nothing Then
            MessageBox.Show("Please select an item from the cart to remove.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedItem = DirectCast(CartGrid.CurrentRow.DataBoundItem, SaleItem)

        _cart.Remove(selectedItem)

        RefreshTotal()
        ShowStatus("Item removed from cart.", Color.DarkRed)
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        If _cart.Count = 0 Then Return

        If MessageBox.Show("Are you sure you want to clear the entire cart?", "POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            _cart.Clear()

            RefreshTotal()
            ShowStatus("Cart cleared.", Color.Gray)
            ScanTextBox.Focus()
        End If
    End Sub

    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        Session.CurrentUser = Nothing
        Me.Close()
    End Sub
End Class