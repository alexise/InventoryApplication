Public Class DepartmentMaster
    Dim count As Integer
    Dim conn As New SqlClient.SqlConnection
    Private Sub DepartmentMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InventoryDBDataSet3.department_master' table. You can move, or remove it, as needed.
        Me.Department_masterTableAdapter.Fill(Me.InventoryDBDataSet3.department_master)
        Dim query As String

        query = "Select department from department_master"
        Call openDB()
        conn.ConnectionString = ("Data Source=CPU096\SQLEXPRESS;Initial Catalog=InventoryDB;Integrated Security=True")
        Call execute(query)
        count = ds.Tables(0).Rows.Count
        Dim x As Integer
        If count = 0 Then
            DepartmentDataGridView.Visible = False
        Else
            For x = 0 To count - 1
                DepartmentDataGridView.AutoResizeColumns()
                DepartmentDataGridView.Rows.Add(ds.Tables(0).Rows(x).Item(0))
            Next
        End If
        closeDB()
    End Sub

    Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click
        If Trim(DepartmentTexbox.Text) <> "" Then
            Dim dep As String
            DepartmentDataGridView.Visible = True
            dep = DepartmentTexbox.Text
            DepartmentDataGridView.Rows.Add(dep)
            Dim r As Integer
            r = DepartmentDataGridView.Rows.Count
            DepartmentDataGridView.Rows(r - 2).Cells("Department").Style.ForeColor = Color.Red

        Else
            MsgBox("Please enter first the department to be added.")
        End If
    End Sub

    Private Sub SaveDepButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveDepButton.Click
        If count < DepartmentDataGridView.Rows.Count - 1 Then
            Dim k As Integer
            conn.Open()
            For k = count To DepartmentDataGridView.Rows.Count - 2
                Dim com As SqlClient.SqlCommand = New SqlClient.SqlCommand
                com.Connection = conn

                com.CommandText = "Insert into department_master (department) Values(@dept ) "
                com.Parameters.Add("@dept", SqlDbType.VarChar).Value = DepartmentDataGridView.Rows(k).Cells(0).Value
                ' com.Connection = conn
                com.ExecuteNonQuery()


            Next
            MsgBox("Department is successfully created", MsgBoxStyle.Information)
            conn.Close()
            DepartmentDataGridView.Rows.Clear()
            DepartmentMaster_Load(sender, e)
        End If
    End Sub

    Private Sub CancelDeptButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelDeptButton.Click
        End
    End Sub
End Class