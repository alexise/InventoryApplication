Public Class LoginForm
    Private sqlDB As SqlClient.SqlConnection


    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click

        Dim command As New SqlClient.SqlCommand
        Dim adaptor As New SqlClient.SqlDataAdapter
        Dim query As String

        query = "SELECT * FROM [user_master] WHERE username='" & txtUsername.Text & "' AND password='" & txtPass.Text & "';"
        Call openDB()
        Call execute(query)
        Dim count = ds.Tables(0).Rows.Count

        If count > 0 Then
            Me.Hide()
            Dim type = ds.Tables(0).Rows(0).Item(3)
            If type.ToString().Equals("a") Then
                EntryForm.Show()
            Else
                MenuForm.Show()
            End If
        Else
            MsgBox("Invalid Account", MsgBoxStyle.Critical, "Login Failed")
            txtUsername.Clear()
            txtPass.Clear()
        End If
        Call closeDB()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Hide()

    End Sub

    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub txtPass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPass.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Call btnLogin_Click(sender, e)
        End If
    End Sub

    Private Sub txtUsername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsername.TextChanged

    End Sub
End Class
