Imports System.Diagnostics.Eventing

Public Class frmTransactions

    Dim dt As DataSet

    Private Sub frmTransactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dt = MyExtensions.FastExecute("SELECT * FROM SETTINGS S")

            Dim filteredCategory = dt.Tables(0).Select("CATEGORY_TYPE <> '' AND CATEGORY_TYPE IS NOT NULL")
            Dim filteredTransactions = dt.Tables(0).Select("TRANSACTION_TYPE <> '' AND TRANSACTION_TYPE IS NOT NULL")
            Dim filteredPayment = dt.Tables(0).Select("PAYMENT_TYPE <> '' AND PAYMENT_TYPE IS NOT NULL")

            cboCategory.DataSource = filteredCategory.CopyToDataTable()
            cboCategory.DisplayMember = "CATEGORY_TYPE"
            cboCategory.ValueMember = "CATEGORY_TYPE"

            cboTransactions.DataSource = filteredTransactions.CopyToDataTable()
            cboTransactions.DisplayMember = "TRANSACTION_TYPE"
            cboTransactions.ValueMember = "TRANSACTION_TYPE"

            cboPayment.DataSource = filteredPayment.CopyToDataTable()
            cboPayment.DisplayMember = "PAYMENT_TYPE"
            cboPayment.ValueMember = "PAYMENT_TYPE"
        Catch
            MessageBox.Show("Houve um erro ao obter dados.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtValor.TextChanged
        Dim valorNumerico As String = System.Text.RegularExpressions.Regex.Replace(txtValor.Text, "[^0-9]", "")

        ' Se for um número válido, formata para moeda
        If valorNumerico <> "" Then
            Dim valor As Decimal = Convert.ToDecimal(valorNumerico) / 100
            txtValor.Text = String.Format("R$ {0:N2}", valor)
            txtValor.SelectionStart = txtValor.Text.Length
        End If
    End Sub

    Private Sub txtValor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValor.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True ' Bloqueia a entrada de caracteres não numéricos
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pctBtnSalvar.Click

        Try
            Dim response As DialogResult = MessageBox.Show("Tem certeza que deseja salvar as alterações?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If response = DialogResult.No Then
                Exit Sub
            End If

            Dim valorNumerico As String = txtValor.Text.Replace("R$ ", "").Replace(",", ".")

            Dim checkStatus As String
            If chkStatus.Checked Then
                checkStatus = "Concluída"
            Else
                checkStatus = "Pendente"
            End If

            MessageBox.Show(checkStatus)

            dt = MyExtensions.FastExecute("INSERT INTO TRANSACOES (VALOR, DESCRICAO, TIPO_TRANSACAO, CATEGORIA, STATUS, METODO_PAGAMENTO, USUARIO_ID)
                                        VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');
                                        ", valorNumerico,
                                           txtDescription.Text,
                                           cboTransactions.Text,
                                           cboCategory.Text,
                                           checkStatus,
                                           cboPayment.Text,
                                           frmHome.userId)

            txtValor.Clear()
            txtDescription.Clear()
        Catch ex As Exception
            MessageBox.Show("Houve um erro ao salvar a transação: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class