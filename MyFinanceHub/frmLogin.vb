Public Class frmLogin
    Dim dt As DataSet
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        SU_VALIDATIONS()
        Dim user = txtUsername.Text
        Dim password = txtPassword.Text
        dt = MyExtensions.FastExecute("SELECT U.FIRST_NAME,
                                              U.ID
                                         FROM USUARIOS U 
                                        WHERE U.USER = '{0}' 
                                          AND U.PASSWORD = '{1}'", user, password)

        If dt.Tables(0).Rows.Count > 0 Then

            Dim firstName As String = dt.Tables(0).Rows(0)("FIRST_NAME").ToString()
            Dim userId As Integer = dt.Tables(0).Rows(0)("ID").ToString()

            frmHome.name = firstName
            frmHome.userId = userId
            ' Exibe o formulário principal após a validação bem-sucedida
            frmHome.Show()
            Me.Hide()
        Else
            ' Caso o usuário ou senha estejam incorretos
            MessageBox.Show("Usuário ou senha estão incorretos.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub
    Private Sub SU_VALIDATIONS()

        'Valida se os campos são nulos
        If String.IsNullOrEmpty(txtUsername.Text) And String.IsNullOrEmpty(txtPassword.Text) Then
            MessageBox.Show("Você precisa preencher todos os campos.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frmUsers.Show()
    End Sub
End Class