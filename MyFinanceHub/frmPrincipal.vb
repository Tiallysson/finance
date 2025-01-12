Imports System.Data.Common
Imports MySql.Data.MySqlClient

Public Class frmPrincipal
    Dim dt As DataSet
    Public Property name As String
    Public Property userId As Integer

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblName.Text = "Olá, " & name

        dt = MyExtensions.FastExecute("SELECT T.VALOR,
                                              T.DESCRICAO,
                                              CASE 
                                                  WHEN T.TIPO_TRANSACAO = 1 THEN 'Recebimento'
                                                  WHEN T.TIPO_TRANSACAO = 2 THEN 'Pagamento'
                                                  ELSE 'Outro'
                                              END AS TIPO_TRANSACAO_DESC,
                                              T.DATA_TRANSACAO,
                                              T.CATEGORIA,
                                              T.STATUS,
                                              T.METODO_PAGAMENTO
                                         FROM TRANSACOES T 
                                        WHERE T.USUARIO_ID = {0}", userId)

        dgvTransactions.DataSource = dt.Tables(0)
    End Sub
End Class