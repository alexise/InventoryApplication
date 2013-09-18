Module DBFunctions
    Friend connection As New SqlClient.SqlConnection
    Dim command As New SqlClient.SqlCommand


    Public Function openDB()
        connection.ConnectionString = ("Data Source=CPU096\SQLEXPRESS;Initial Catalog=InventoryDB;Integrated Security=True")
    End Function
    Public Function execute(ByVal sql As String)
        command.CommandText = sql
        connection.Open()
    End Function
    Public Function ds() As DataSet
        Dim adaptor As New SqlClient.SqlDataAdapter
        Dim dataset As New DataSet
        command.Connection = connection
        adaptor.SelectCommand = command
        adaptor.Fill(dataset, "0")
        Dim count = dataset.Tables(0).Rows.Count
        ds = dataset
    End Function
    Public Function closeDB()
        connection.Close()
    End Function
End Module
