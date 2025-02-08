Public Class frmEditTransactions
    Private idTransaction As Long
    Private valueTransaction As String
    Private description As String
    Private transactionType As String
    Private transactionDate As String
    Private category As String
    Private status As String
    Private paymentMethod As String


    Dim dt As DataSet

    Public Sub New(idTransaction As Long, valueTransaction As String, description As String, transactionType As String, transactionDate As String, category As String, status As String, paymentMethod As String)
        InitializeComponent()

        Me.valueTransaction = valueTransaction
        Me.idTransaction = idTransaction
        Me.description = description
        Me.transactionType = transactionType
        Me.transactionDate = transactionDate
        Me.category = category
        Me.status = status
        Me.paymentMethod = paymentMethod
    End Sub

    Private Sub frmEditTransactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDescription.Text = description
        txtValor.Text = valueTransaction
        cboCategory.Text = category
        cboPayment.Text = paymentMethod
        cboTransactions.Text = transactionType
        cboStatus.Text = status
    End Sub

    Private Sub pctBtnSalvar_Click(sender As Object, e As EventArgs) Handles pctBtnSalvar.Click
        Try

            Dim response As DialogResult = MessageBox.Show("Tem certeza que deseja salvar as alterações?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If response = DialogResult.No Then
                Exit Sub
            End If
            Dim numericValue As String = txtValor.Text.Replace("R$ ", "").Replace(",", ".")

            dt = MyExtensions.FastExecute("UPDATE TRANSACOES
                                          SET VALOR = {0},
                                              DESCRICAO = '{1}',
                                              TIPO_TRANSACAO = '{2}',
                                              CATEGORIA = '{3}',
                                              STATUS = '{4}',
                                              METODO_PAGAMENTO = '{5}'
                                        WHERE ID = {6}", numericValue, txtDescription.Text, cboTransactions.Text, cboCategory.Text, cboStatus.SelectedText, cboPayment.Text, idTransaction)

            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Houve um erro ao salvar a transação: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


End Class