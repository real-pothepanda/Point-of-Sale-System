Imports MySql.Data.MySqlClient
Imports System.Data
Imports Point_of_Sale_System.Models
Imports Point_of_Sale_System.Data

Namespace Repositories

    Public Class ProductRepository
        Private ReadOnly _factory As New DbConnectionFactory()
        Public Function Search(term As String) As List(Of Product)
            Dim products As New List(Of Product)()

            Using connection = _factory.CreateConnection()
                connection.Open()
                Using command As New MySqlCommand("SELECT id, barcode, name, price, stock_quantity, is_active FROM products WHERE (barcode LIKE @term OR name LIKE @term) ORDER BY name", connection)
                    command.Parameters.AddWithValue("@term", "%" & term & "%")
                    Using reader = command.ExecuteReader()
                        While reader.Read()
                            products.Add(MapProduct(reader))
                        End While
                    End Using
                End Using
            End Using

            Return products
        End Function

        Public Sub Add(product As Product)
            Using connection = _factory.CreateConnection()
                connection.Open()
                Using command As New MySqlCommand("INSERT INTO products (barcode, name, price, stock_quantity, is_active) VALUES (@barcode, @name, @price, @stock, @active)", connection)
                    FillProductParameters(command, product)
                    command.ExecuteNonQuery()
                End Using
            End Using
        End Sub
        Public Sub Update(product As Product)
            Using connection = _factory.CreateConnection()
                connection.Open()
                Using command As New MySqlCommand("UPDATE products SET barcode = @barcode, name = @name, price = @price, stock_quantity = @stock, is_active = @active WHERE id = @id", connection)
                    command.Parameters.AddWithValue("@id", product.Id)
                    FillProductParameters(command, product)
                    command.ExecuteNonQuery()
                End Using
            End Using
        End Sub
        Public Sub Deactivate(productId As Integer)
            Using connection = _factory.CreateConnection()
                connection.Open()
                Using command As New MySqlCommand("DELETE FROM products WHERE id = @id", connection)
                    command.Parameters.AddWithValue("@id", productId)
                    command.ExecuteNonQuery()
                End Using
            End Using
        End Sub
        Private Function MapProduct(reader As MySqlDataReader) As Product
            Return New Product With {
                .Id = Convert.ToInt32(reader("id")),
                .Barcode = reader("barcode").ToString(),
                .Name = reader("name").ToString(),
                .Price = Convert.ToDecimal(reader("price")),
                .StockQuantity = Convert.ToInt32(reader("stock_quantity")),
                .IsActive = Convert.ToBoolean(reader("is_active"))
            }
        End Function

        Private Sub FillProductParameters(command As MySqlCommand, product As Product)
            command.Parameters.AddWithValue("@barcode", product.Barcode)
            command.Parameters.AddWithValue("@name", product.Name)
            command.Parameters.AddWithValue("@price", product.Price)
            command.Parameters.AddWithValue("@stock", product.StockQuantity)
            command.Parameters.AddWithValue("@active", product.IsActive)
        End Sub
        Public Function GetAll() As List(Of Product)
            Dim products As New List(Of Product)()
            Using connection = _factory.CreateConnection()
                connection.Open()
                Using command As New MySqlCommand("SELECT * FROM products", connection)
                    Using reader = command.ExecuteReader()
                        While reader.Read()
                            products.Add(MapProduct(reader))
                        End While
                    End Using
                End Using
            End Using
            Return products
        End Function
    End Class
End Namespace
