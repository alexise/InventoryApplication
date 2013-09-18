Public Class CategoryMaster
    Dim count As Integer
    Dim conn As New SqlClient.SqlConnection
    
    Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click
        If Trim(categoryNameTextBox.Text) <> "" Then
            Dim cat As String
            CategoryDataGrid.Visible = True
            cat = categoryNameTextBox.Text

            CategoryDataGrid.Rows.Add(cat)
            Dim r As Integer
            r = CategoryDataGrid.Rows.Count
            CategoryDataGrid.Rows(r - 2).Cells("Category").Style.ForeColor = Color.Red

        Else
            MsgBox("Please enter first the category to be added.")
        End If
    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        If count < CategoryDataGrid.Rows.Count - 1 Then
            Dim k As Integer
            conn.Open()
            For k = count To CategoryDataGrid.Rows.Count - 2
                Dim com As SqlClient.SqlCommand = New SqlClient.SqlCommand
                com.Connection = conn

                com.CommandText = "Insert into category_master (category_type) Values(@catType ) "
                com.Parameters.Add("@catType", SqlDbType.VarChar).Value = CategoryDataGrid.Rows(k).Cells(0).Value
                ' com.Connection = conn
                com.ExecuteNonQuery()


            Next
            MsgBox("Category Type is successfully created", MsgBoxStyle.Information)
            conn.Close()
            CategoryDataGrid.Rows.Clear()
            CategoryMaster_Load(sender, e)
        End If
    End Sub

    Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        End
    End Sub

    Private Sub CategoryMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InventoryDBDataSet1.category_master' table. You can move, or remove it, as needed.
        'Me.Category_masterTableAdapter.Fill(Me.InventoryDBDataSet1.category_master)
        Dim query As String

        query = "Select category_type from category_master"
        Call openDB()
        conn.ConnectionString = ("Data Source=CPU096\SQLEXPRESS;Initial Catalog=InventoryDB;Integrated Security=True")
        Call execute(query)
        count = ds.Tables(0).Rows.Count
        Dim x As Integer
        If count = 0 Then
            CategoryDataGrid.Visible = False
        Else
            For x = 0 To count - 1
                CategoryDataGrid.AutoResizeColumns()
                CategoryDataGrid.Rows.Add(ds.Tables(0).Rows(x).Item(0))
            Next
        End If
        closeDB()
    End Sub
End Class