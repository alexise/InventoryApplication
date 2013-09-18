Public Class UserMaster
    Dim conn As New SqlClient.SqlConnection

    Private Sub UserMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InventoryDBDataSet4.department_master' table. You can move, or remove it, as needed.
        Me.Department_masterTableAdapter.Fill(Me.InventoryDBDataSet4.department_master)
        conn.ConnectionString = ("Data Source=CPU096\SQLEXPRESS;Initial Catalog=InventoryDB;Integrated Security=True")
    End Sub

    Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click
        Dim wrapper As New Simple3Des(PasswordTextBox.Text)
        Dim cipherText As String = wrapper.EncryptData(PasswordTextBox.Text)

        Dim com As SqlClient.SqlCommand = New SqlClient.SqlCommand
        com.Connection = conn

        com.CommandText = "Insert into user_master (username,password,ulevel,is_active,department_id,firstname,lastname) Values(@username,@password,@ulevel,@is_active,@department_id,@firstname,@lastname) "
        com.Parameters.Add("@username", SqlDbType.VarChar).Value = Trim(UsernameTextBox.Text)
        com.Parameters.Add("@password", SqlDbType.VarChar).Value = Trim(cipherText)
        com.Parameters.Add("@ulevel", SqlDbType.VarChar).Value = Trim(UserLevelComboBox.SelectedIndex)
        com.Parameters.Add("@is_active", SqlDbType.VarChar).Value = "1"
        com.Parameters.Add("@department_id", SqlDbType.Int).Value = Trim(DepartmentCombobox.SelectedValue)
        com.Parameters.Add("@firstname", SqlDbType.VarChar).Value = Trim(FirstNameTextBox.Text)
        com.Parameters.Add("@lastname", SqlDbType.VarChar).Value = Trim(LastNameTextBox.Text)
        com.Connection = conn
        conn.Open()
        com.ExecuteNonQuery()

        conn.Close()
        MessageBox.Show("Successfully saved!", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class