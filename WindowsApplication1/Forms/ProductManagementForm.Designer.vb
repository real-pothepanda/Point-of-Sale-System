<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductManagementForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SearchLabel = New System.Windows.Forms.Label()
        Me.SearchTextbox = New System.Windows.Forms.TextBox()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BarcodeLabel = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.PriceLabel = New System.Windows.Forms.Label()
        Me.StockLabel = New System.Windows.Forms.Label()
        Me.BarcodeTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.PriceInput = New System.Windows.Forms.NumericUpDown()
        Me.StockInput = New System.Windows.Forms.NumericUpDown()
        Me.ActiveCheckBox = New System.Windows.Forms.CheckBox()
        Me.NewButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.ProductsGrid = New System.Windows.Forms.DataGridView()
        Me.ProductDetailsGroupBox = New System.Windows.Forms.GroupBox()
        CType(Me.PriceInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductDetailsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'SearchLabel
        '
        Me.SearchLabel.AutoSize = True
        Me.SearchLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchLabel.Location = New System.Drawing.Point(12, 9)
        Me.SearchLabel.Name = "SearchLabel"
        Me.SearchLabel.Size = New System.Drawing.Size(44, 13)
        Me.SearchLabel.TabIndex = 0
        Me.SearchLabel.Text = "Search:"
        '
        'SearchTextbox
        '
        Me.SearchTextbox.Location = New System.Drawing.Point(74, 6)
        Me.SearchTextbox.Name = "SearchTextbox"
        Me.SearchTextbox.Size = New System.Drawing.Size(419, 20)
        Me.SearchTextbox.TabIndex = 1
        '
        'SearchButton
        '
        Me.SearchButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchButton.Location = New System.Drawing.Point(499, 4)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(75, 22)
        Me.SearchButton.TabIndex = 2
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'RefreshButton
        '
        Me.RefreshButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefreshButton.Location = New System.Drawing.Point(580, 4)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(75, 22)
        Me.RefreshButton.TabIndex = 3
        Me.RefreshButton.Text = "Refresh"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Product Details"
        '
        'BarcodeLabel
        '
        Me.BarcodeLabel.AutoSize = True
        Me.BarcodeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarcodeLabel.Location = New System.Drawing.Point(11, 49)
        Me.BarcodeLabel.Name = "BarcodeLabel"
        Me.BarcodeLabel.Size = New System.Drawing.Size(50, 13)
        Me.BarcodeLabel.TabIndex = 5
        Me.BarcodeLabel.Text = "Barcode:"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel.Location = New System.Drawing.Point(21, 89)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(38, 13)
        Me.NameLabel.TabIndex = 6
        Me.NameLabel.Text = "Name:"
        '
        'PriceLabel
        '
        Me.PriceLabel.AutoSize = True
        Me.PriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceLabel.Location = New System.Drawing.Point(25, 129)
        Me.PriceLabel.Name = "PriceLabel"
        Me.PriceLabel.Size = New System.Drawing.Size(34, 13)
        Me.PriceLabel.TabIndex = 7
        Me.PriceLabel.Text = "Price:"
        '
        'StockLabel
        '
        Me.StockLabel.AutoSize = True
        Me.StockLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StockLabel.Location = New System.Drawing.Point(25, 169)
        Me.StockLabel.Name = "StockLabel"
        Me.StockLabel.Size = New System.Drawing.Size(38, 13)
        Me.StockLabel.TabIndex = 8
        Me.StockLabel.Text = "Stock:"
        '
        'BarcodeTextBox
        '
        Me.BarcodeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarcodeTextBox.Location = New System.Drawing.Point(80, 46)
        Me.BarcodeTextBox.Name = "BarcodeTextBox"
        Me.BarcodeTextBox.Size = New System.Drawing.Size(225, 20)
        Me.BarcodeTextBox.TabIndex = 9
        '
        'NameTextBox
        '
        Me.NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTextBox.Location = New System.Drawing.Point(80, 86)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(225, 20)
        Me.NameTextBox.TabIndex = 10
        '
        'PriceInput
        '
        Me.PriceInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceInput.Location = New System.Drawing.Point(80, 127)
        Me.PriceInput.Name = "PriceInput"
        Me.PriceInput.Size = New System.Drawing.Size(225, 20)
        Me.PriceInput.TabIndex = 11
        '
        'StockInput
        '
        Me.StockInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StockInput.Location = New System.Drawing.Point(80, 167)
        Me.StockInput.Name = "StockInput"
        Me.StockInput.Size = New System.Drawing.Size(225, 20)
        Me.StockInput.TabIndex = 12
        '
        'ActiveCheckBox
        '
        Me.ActiveCheckBox.AutoSize = True
        Me.ActiveCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActiveCheckBox.Location = New System.Drawing.Point(237, 208)
        Me.ActiveCheckBox.Name = "ActiveCheckBox"
        Me.ActiveCheckBox.Size = New System.Drawing.Size(56, 17)
        Me.ActiveCheckBox.TabIndex = 13
        Me.ActiveCheckBox.Text = "Active"
        Me.ActiveCheckBox.UseVisualStyleBackColor = True
        '
        'NewButton
        '
        Me.NewButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton.Location = New System.Drawing.Point(27, 242)
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Size = New System.Drawing.Size(88, 23)
        Me.NewButton.TabIndex = 14
        Me.NewButton.Text = "New"
        Me.NewButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(123, 242)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(88, 23)
        Me.SaveButton.TabIndex = 15
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.Location = New System.Drawing.Point(217, 242)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(88, 23)
        Me.DeleteButton.TabIndex = 16
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'ProductsGrid
        '
        Me.ProductsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductsGrid.Location = New System.Drawing.Point(12, 33)
        Me.ProductsGrid.Name = "ProductsGrid"
        Me.ProductsGrid.Size = New System.Drawing.Size(627, 446)
        Me.ProductsGrid.TabIndex = 17
        '
        'ProductDetailsGroupBox
        '
        Me.ProductDetailsGroupBox.Controls.Add(Me.Label2)
        Me.ProductDetailsGroupBox.Controls.Add(Me.BarcodeLabel)
        Me.ProductDetailsGroupBox.Controls.Add(Me.DeleteButton)
        Me.ProductDetailsGroupBox.Controls.Add(Me.NameLabel)
        Me.ProductDetailsGroupBox.Controls.Add(Me.SaveButton)
        Me.ProductDetailsGroupBox.Controls.Add(Me.PriceLabel)
        Me.ProductDetailsGroupBox.Controls.Add(Me.NewButton)
        Me.ProductDetailsGroupBox.Controls.Add(Me.StockLabel)
        Me.ProductDetailsGroupBox.Controls.Add(Me.ActiveCheckBox)
        Me.ProductDetailsGroupBox.Controls.Add(Me.BarcodeTextBox)
        Me.ProductDetailsGroupBox.Controls.Add(Me.StockInput)
        Me.ProductDetailsGroupBox.Controls.Add(Me.NameTextBox)
        Me.ProductDetailsGroupBox.Controls.Add(Me.PriceInput)
        Me.ProductDetailsGroupBox.Location = New System.Drawing.Point(645, 32)
        Me.ProductDetailsGroupBox.Name = "ProductDetailsGroupBox"
        Me.ProductDetailsGroupBox.Size = New System.Drawing.Size(325, 365)
        Me.ProductDetailsGroupBox.TabIndex = 18
        Me.ProductDetailsGroupBox.TabStop = False
        '
        'ProductManagementForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 483)
        Me.Controls.Add(Me.ProductDetailsGroupBox)
        Me.Controls.Add(Me.ProductsGrid)
        Me.Controls.Add(Me.RefreshButton)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.SearchTextbox)
        Me.Controls.Add(Me.SearchLabel)
        Me.Name = "ProductManagementForm"
        Me.Text = "Product Management Form"
        CType(Me.PriceInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductDetailsGroupBox.ResumeLayout(False)
        Me.ProductDetailsGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SearchLabel As Label
    Friend WithEvents SearchTextbox As TextBox
    Friend WithEvents SearchButton As Button
    Friend WithEvents RefreshButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents BarcodeLabel As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents PriceLabel As Label
    Friend WithEvents StockLabel As Label
    Friend WithEvents BarcodeTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents PriceInput As NumericUpDown
    Friend WithEvents StockInput As NumericUpDown
    Friend WithEvents ActiveCheckBox As CheckBox
    Friend WithEvents NewButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents ProductsGrid As DataGridView
    Friend WithEvents ProductDetailsGroupBox As GroupBox
End Class
