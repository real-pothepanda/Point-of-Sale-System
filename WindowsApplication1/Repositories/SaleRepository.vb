Imports MySql.Data.MySqlClient
Imports Point_of_Sale_System.Models
Imports Point_of_Sale_System.Data

Namespace Repositories
    Public Class SaleRepository
        Private ReadOnly _factory As New DbConnectionFactory()

        Public Function Save(sale As Sale) As Integer
            Using connection = _factory.CreateConnection()
                connection.Open()

                Using transaction = connection.BeginTransaction()
                    Try
                        Using command As New MySqlCommand("INSERT INTO sales (cashier_id, total_amount) VALUES (@cashierId, @total); SELECT LAST_INSERT_ID();", connection, transaction)
                            command.Parameters.AddWithValue("@cashierId", sale.CashierId)
                            command.Parameters.AddWithValue("@total", sale.TotalAmount)
                            sale.Id = Convert.ToInt32(command.ExecuteScalar())
                        End Using
                        For Each item In sale.Items
                            Using itemCommand As New MySqlCommand("INSERT INTO sale_items (sale_id, product_id, quantity, unit_price, line_total) VALUES (@saleId, @productId, @quantity, @unitPrice, @lineTotal)", connection, transaction)
                                itemCommand.Parameters.AddWithValue("@saleId", sale.Id)
                                itemCommand.Parameters.AddWithValue("@productId", item.ProductID)
                                itemCommand.Parameters.AddWithValue("@quantity", item.Quantity)
                                itemCommand.Parameters.AddWithValue("@unitPrice", item.UnitPrice)
                                itemCommand.Parameters.AddWithValue("@lineTotal", item.LineTotal)
                                itemCommand.ExecuteNonQuery()
                            End Using
                            Using stockCommand As New MySqlCommand("UPDATE products SET stock_quantity = stock_quantity - @qty WHERE id = @productId", connection, transaction)
                                stockCommand.Parameters.AddWithValue("@qty", item.Quantity)
                                stockCommand.Parameters.AddWithValue("@productId", item.ProductID)
                                stockCommand.ExecuteNonQuery()
                            End Using
                        Next
                        transaction.Commit()
                        Return sale.Id

                    Catch
                        transaction.Rollback()
                        Throw
                    End Try
                End Using
            End Using
        End Function
    End Class
End Namespace