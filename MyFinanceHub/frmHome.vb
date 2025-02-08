Imports System.Data.Common
Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient

Public Class frmHome
    Dim dt As DataSet
    Public Property name As String
    Public Property userId As Integer

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblName.Text = "Olá, " & name
        clsCont()
        Try
            dt = MyExtensions.FastExecute("SELECT T.VALOR,
                                              T.DESCRICAO,
                                              T.TIPO_TRANSACAO AS TIPO_TRANSACAO_DESC,
                                              T.DATA_TRANSACAO,
                                              T.CATEGORIA,
                                              T.STATUS,
                                              T.METODO_PAGAMENTO,
                                              T.ID
                                         FROM TRANSACOES T 
                                        WHERE T.USUARIO_ID = {0}", userId)

            dgvTransactions.DataSource = dt.Tables(0)
        Catch
            MessageBox.Show("Ocorreu um erro ao obter os dados!", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub clsCont()

        Try
            dt = MyExtensions.FastExecute("SELECT 
                                                 (SELECT IFNULL(SUM(T.VALOR), 0)
                                                  FROM TRANSACOES T 
                                                  WHERE T.USUARIO_ID = {0}) AS VALOR_FINAL,
                                                 
                                                 (SELECT IFNULL(SUM(T.VALOR), 0)
                                                  FROM TRANSACOES T
                                                  WHERE T.USUARIO_ID = {0}
                                                  AND T.DATA_TRANSACAO >= DATE_SUB(CURDATE(), INTERVAL 5 DAY)) AS VALOR_DIAS,
                                                 
                                                 (SELECT IFNULL(T.VALOR, 0)
                                                  FROM TRANSACOES T
                                                  WHERE T.USUARIO_ID = {0}
                                                  AND T.TIPO_TRANSACAO = 'COMPRA'
                                                  AND T.DATA_TRANSACAO = (SELECT MAX(T2.DATA_TRANSACAO) 
                                                                          FROM TRANSACOES T2 
                                                                          WHERE T2.USUARIO_ID = {0}
                                                                          AND T2.TIPO_TRANSACAO = 'COMPRA') LIMIT 1) AS ULTIMA_ENTRADA,
                                                 
                                                 (SELECT IFNULL(T.VALOR, 0)
                                                  FROM TRANSACOES T
                                                  WHERE T.USUARIO_ID = {0}
                                                  AND T.TIPO_TRANSACAO = 'VENDA'
                                                  AND T.DATA_TRANSACAO = (SELECT MAX(T2.DATA_TRANSACAO) 
                                                                          FROM TRANSACOES T2 
                                                                          WHERE T2.USUARIO_ID = {0}
                                                                          AND T2.TIPO_TRANSACAO = 'VENDA') LIMIT 1) AS ULTIMA_SAIDA", userId)

            Dim totalValue As Decimal = dt.Tables(0).Rows(0)("VALOR_FINAL").ToString()
            lblTotalValue.Text = totalValue

            Dim valueDays As Decimal = dt.Tables(0).Rows(0)("VALOR_DIAS").ToString()
            lblFiveDays.Text = valueDays

            Dim lastReceipt As Decimal = dt.Tables(0).Rows(0)("ULTIMA_ENTRADA").ToString()
            lblLastEntry.Text = lastReceipt

            Dim lastPayment As Decimal = dt.Tables(0).Rows(0)("ULTIMA_SAIDA").ToString()
            lblLastExit.Text = lastPayment
        Catch
            MessageBox.Show("Ocorreu um erro ao obter os valores!", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private panelVisivel As Boolean = False
    Private Sub ptbMenu_Click(sender As Object, e As EventArgs) Handles ptbMenu.Click
        panelVisivel = Not panelVisivel
        pnlMenu.Visible = panelVisivel
    End Sub

    Private Sub pcbButtonExit_Click(sender As Object, e As EventArgs) Handles pcbButtonExit.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        frmTransactions.Show()
    End Sub

    Private Sub dgvTransactions_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransactions.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            If dgvTransactions.Columns(e.ColumnIndex).Name = "Editar" Then
                Dim row As DataGridViewRow = dgvTransactions.Rows(e.RowIndex)

                Dim idTransaction As Long = Convert.ToInt64(row.Cells("ID").Value)
                Dim valueTransaction As String = row.Cells("clmValue").Value.ToString()
                Dim description As String = row.Cells("clmDescription").Value.ToString()
                Dim transactionType As String = row.Cells("clmTransaction").Value.ToString()
                Dim transactionDate As String = row.Cells("clmData").Value.ToString()
                Dim category As String = row.Cells("clmCategory").Value.ToString()
                Dim status As String = row.Cells("clmStatus").Value.ToString()
                Dim paymentMethod As String = row.Cells("clmPayment").Value.ToString()

                Dim frmEdit As New frmEditTransactions(idTransaction, valueTransaction, description, transactionType, transactionDate, category, status, paymentMethod)

                frmEdit.ShowDialog()
            Else
                MessageBox.Show("Não foi possível carregar a transação.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        End If



    End Sub


End Class