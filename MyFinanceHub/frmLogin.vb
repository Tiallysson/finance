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
            ' Se o usuário for encontrado e a senha estiver correta, verifica se os termos foram aceitos
            If chkTerms.Checked = False Then
                MessageBox.Show("Você precisa aceitar os termos de utilização para prosseguir.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            Dim firstName As String = dt.Tables(0).Rows(0)("FIRST_NAME").ToString()
            Dim userId As Integer = dt.Tables(0).Rows(0)("ID").ToString()

            frmPrincipal.name = firstName
            frmPrincipal.userId = userId
            ' Exibe o formulário principal após a validação bem-sucedida
            frmPrincipal.Show()
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
        frmCadastro.Show()
    End Sub
End Class