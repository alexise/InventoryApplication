Public Class EntryForm
    Dim x As Integer
    Dim conn As New SqlClient.SqlConnection


    Private Sub EntryForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InventoryDBDataSet2.category_master' table. You can move, or remove it, as needed.
        Me.Category_masterTableAdapter1.Fill(Me.InventoryDBDataSet2.category_master)
        'TODO: This line of code loads data into the 'InventoryDBDataSet.category_master' table. You can move, or remove it, as needed.
        Me.Category_masterTableAdapter.Fill(Me.InventoryDBDataSet.category_master)
        x = 1
        lblDate.Text = Date.Now()
        conn.ConnectionString = ("Data Source=CPU096\SQLEXPRESS;Initial Catalog=InventoryDB;Integrated Security=True")
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click
        ItemFlexGrid.set_TextMatrix(x, 2, ItemNameTextBox.Text)
        ItemFlexGrid.set_TextMatrix(x, 3, UnitPriceTextBox.Text)
        ItemFlexGrid.set_TextMatrix(x, 4, QuantityTextBox.Text)
        ItemFlexGrid.set_TextMatrix(x, 5, CategoryComboBox.Text)
        ItemFlexGrid.set_TextMatrix(x, 6, EstimatedUsefulTextBox.Text)
        ItemFlexGrid.set_TextMatrix(x, 7, SalvageValueTextBox.Text)
        ItemFlexGrid.set_TextMatrix(x, 8, DepreciationTextBox.Text)
        ItemFlexGrid.Rows = ItemFlexGrid.Rows + 1
        x = x + 1
    End Sub

    Private Sub UnitPrice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles UnitPriceTextBox.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If Trim(UnitPriceTextBox.Text) = "" Then
                MessageBox.Show("Enter the unit price", "Empty")
            Else
                QuantityTextBox.Focus()
            End If
        End If
    End Sub

    Private Sub UnitPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnitPriceTextBox.TextChanged
        If Trim(UnitPriceTextBox.Text) <> "" Then
            If IsNumeric(UnitPriceTextBox.Text) Then
                'QuantityTextBox.Focus()
            Else
                MessageBox.Show("Enter numeric value only", "Invalid Entry")
            End If
        End If
    End Sub

    Private Sub ItemNameTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ItemNameTextBox.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If Trim(ItemNameTextBox.Text) = "" Then
                MessageBox.Show("Enter the item name", "Empty")
            Else
                DateAcquired.Focus()
            End If
        End If
    End Sub

    Private Sub EstimatedUsefulTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles EstimatedUsefulTextBox.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If Trim(EstimatedUsefulTextBox.Text) = "" Then
                MessageBox.Show("Enter the estimated useful life", "Empty")
            Else
                EstimatedPeriodComboBox.Focus()
            End If
        End If
    End Sub


    Private Sub EstimatedUsefulTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EstimatedUsefulTextBox.TextChanged
        If Trim(EstimatedUsefulTextBox.Text) <> "" Then
            If IsNumeric(EstimatedUsefulTextBox.Text) Then
                'QuantityTextBox.Focus()
            Else
                MessageBox.Show("Enter numeric value only", "Invalid Entry")
            End If
        End If
    End Sub

    Private Sub SalvageValueTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles SalvageValueTextBox.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If Trim(SalvageValueTextBox.Text) = "" Then
                MessageBox.Show("Enter the salvage value of this item", "Empty")
            Else
                Dim salvageValue As Double
                Dim actualCost As Double
                Dim estimatedLife As Double
                Dim depreciation As Double
                salvageValue = Double.Parse(SalvageValueTextBox.Text)
                actualCost = Double.Parse(UnitPriceTextBox.Text)
                estimatedLife = Double.Parse(EstimatedUsefulTextBox.Text)
                depreciation = (actualCost - salvageValue) / estimatedLife
                DepreciationTextBox.Text = Format(depreciation, 2)
                AddButton.Focus()
            End If
        End If
    End Sub

    Private Sub SalvageValueTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalvageValueTextBox.TextChanged
        If Trim(SalvageValueTextBox.Text) <> "" Then
            If IsNumeric(SalvageValueTextBox.Text) Then
                'QuantityTextBox.Focus()
            Else
                MessageBox.Show("Enter numeric value only", "Invalid Entry")
            End If
        End If
    End Sub

    Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton.Click
        ItemNameTextBox.Clear()
        UnitPriceTextBox.Clear()
        EstimatedUsefulTextBox.Clear()
        SalvageValueTextBox.Clear()
        DepreciationTextBox.Clear()
        QuantityTextBox.Clear()
        ItemFlexGrid.Rows = ItemFlexGrid.Rows - 2
        x = x - 2
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Dim com As SqlClient.SqlCommand = New SqlClient.SqlCommand
        com.Connection = conn

        com.CommandText = "Insert into reference (invoice_no, notes, date_acquired) Values(@invoiceNo, @notes, @dateAcq ) "
        com.Parameters.Add("@invoiceNo", SqlDbType.VarChar).Value = Trim(InvoiceNoTextBox.Text)
        com.Parameters.Add("@notes", SqlDbType.VarChar).Value = NotesTextBox.Text
        com.Parameters.Add("@dateAcq", SqlDbType.Date).Value = CDate(DateAcquired.Text)
        com.Connection = conn
        conn.Open()
        com.ExecuteNonQuery()



        For k = 1 To x - 1
            Dim com1 As SqlClient.SqlCommand = New SqlClient.SqlCommand
            com1.Connection = conn
            com1.CommandText = "Insert into item_master (item_desc, date_added, category_id,unit_price,quantity,amount,depreciation,est_life, salvage_value, invoice_no) Values(@descr,@date, @cat, @price,@qty, @amount, @dep, @est, @salv, @invoice ) "
            com1.Parameters.Add("@descr", SqlDbType.VarChar).Value = ItemNameTextBox.Text
            com1.Parameters.Add("@date", SqlDbType.Date).Value = Date.Now
            com1.Parameters.Add("@cat", SqlDbType.Int).Value = CategoryComboBox.SelectedValue
            com1.Parameters.Add("@price", SqlDbType.Float).Value = Double.Parse(UnitPriceTextBox.Text)
            com1.Parameters.Add("@qty", SqlDbType.Int).Value = Integer.Parse(QuantityTextBox.Text)
            com1.Parameters.Add("@amount", SqlDbType.Float).Value = Double.Parse(UnitPriceTextBox.Text) * Double.Parse(QuantityTextBox.Text)
            com1.Parameters.Add("@dep", SqlDbType.Float).Value = Double.Parse(DepreciationTextBox.Text)
            com1.Parameters.Add("@est", SqlDbType.Float).Value = Double.Parse(EstimatedUsefulTextBox.Text)
            com1.Parameters.Add("@salv", SqlDbType.Float).Value = Double.Parse(SalvageValueTextBox.Text)
            com1.Parameters.Add("@invoice", SqlDbType.VarChar).Value = Trim(InvoiceNoTextBox.Text)
            com1.Connection = conn
            com1.ExecuteNonQuery()
        Next
        conn.Close()
        MessageBox.Show("Successfully saved!", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Private Sub ItemNameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemNameTextBox.TextChanged

    End Sub

<<<<<<< HEAD
    Private Sub InvoiceNoTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles InvoiceNoTextBox.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If Trim(InvoiceNoTextBox.Text) = "" Then
                MessageBox.Show("Enter the Invoice No", "Empty")
            Else
                Dim com As SqlClient.SqlCommand = New SqlClient.SqlCommand
                openDB()
                Dim str As String
                str = "Select invoice_no from reference where invoice_no='" & Trim(InvoiceNoTextBox.Text) & " ' "
                execute(str)
                Dim count = 0
                count = ds.Tables(0).Rows.Count
                If count > 0 Then
                    MsgBox("This Invoice No " & InvoiceNoTextBox.Text & " already exists. Enter a unique one")
                Else
                    DateAcquired.Focus()
                End If
                closeDB()
            End If
        End If
    End Sub

    Private Sub InvoiceNoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InvoiceNoTextBox.TextChanged
        
=======
    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

>>>>>>> afce4a28bdef16d3519e3514494fded99e887549
    End Sub
End Class