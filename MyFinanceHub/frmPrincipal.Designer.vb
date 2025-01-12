<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        lblName = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtTotalValue = New Label()
        txtFiveDays = New Label()
        txtLastExit = New Label()
        txtLastEntry = New Label()
        txtCoin = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        dgvTransactions = New DataGridView()
        clmValue = New DataGridViewTextBoxColumn()
        clmDescription = New DataGridViewTextBoxColumn()
        clmTransaction = New DataGridViewTextBoxColumn()
        clmData = New DataGridViewTextBoxColumn()
        clmCategory = New DataGridViewTextBoxColumn()
        clmStatus = New DataGridViewTextBoxColumn()
        clmPayment = New DataGridViewTextBoxColumn()
        CType(dgvTransactions, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblName.Location = New Point(42, 9)
        lblName.Name = "lblName"
        lblName.Size = New Size(60, 21)
        lblName.TabIndex = 1
        lblName.Text = "{name}"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold)
        Label1.Location = New Point(48, 97)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 16)
        Label1.TabIndex = 2
        Label1.Text = "Valor atual:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold)
        Label2.Location = New Point(201, 97)
        Label2.Name = "Label2"
        Label2.Size = New Size(141, 16)
        Label2.TabIndex = 3
        Label2.Text = "Gasto nos últimos 5 dias:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold)
        Label3.Location = New Point(444, 97)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 16)
        Label3.TabIndex = 4
        Label3.Text = "Última saída:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold)
        Label4.Location = New Point(611, 97)
        Label4.Name = "Label4"
        Label4.Size = New Size(91, 16)
        Label4.TabIndex = 5
        Label4.Text = "Última entrada:"
        ' 
        ' txtTotalValue
        ' 
        txtTotalValue.AutoSize = True
        txtTotalValue.Font = New Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtTotalValue.Location = New Point(78, 127)
        txtTotalValue.Name = "txtTotalValue"
        txtTotalValue.Size = New Size(16, 21)
        txtTotalValue.TabIndex = 6
        txtTotalValue.Text = "-"
        ' 
        ' txtFiveDays
        ' 
        txtFiveDays.AutoSize = True
        txtFiveDays.Font = New Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtFiveDays.Location = New Point(230, 127)
        txtFiveDays.Name = "txtFiveDays"
        txtFiveDays.Size = New Size(16, 21)
        txtFiveDays.TabIndex = 7
        txtFiveDays.Text = "-"
        ' 
        ' txtLastExit
        ' 
        txtLastExit.AutoSize = True
        txtLastExit.Font = New Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtLastExit.Location = New Point(480, 127)
        txtLastExit.Name = "txtLastExit"
        txtLastExit.Size = New Size(16, 21)
        txtLastExit.TabIndex = 8
        txtLastExit.Text = "-"
        ' 
        ' txtLastEntry
        ' 
        txtLastEntry.AutoSize = True
        txtLastEntry.Font = New Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtLastEntry.Location = New Point(647, 127)
        txtLastEntry.Name = "txtLastEntry"
        txtLastEntry.Size = New Size(16, 21)
        txtLastEntry.TabIndex = 9
        txtLastEntry.Text = "-"
        ' 
        ' txtCoin
        ' 
        txtCoin.AutoSize = True
        txtCoin.Font = New Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtCoin.Location = New Point(42, 127)
        txtCoin.Name = "txtCoin"
        txtCoin.Size = New Size(30, 21)
        txtCoin.TabIndex = 10
        txtCoin.Text = "R$"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(194, 127)
        Label5.Name = "Label5"
        Label5.Size = New Size(30, 21)
        Label5.TabIndex = 11
        Label5.Text = "R$"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(444, 127)
        Label6.Name = "Label6"
        Label6.Size = New Size(30, 21)
        Label6.TabIndex = 12
        Label6.Text = "R$"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(611, 127)
        Label7.Name = "Label7"
        Label7.Size = New Size(30, 21)
        Label7.TabIndex = 13
        Label7.Text = "R$"
        ' 
        ' dgvTransactions
        ' 
        DataGridViewCellStyle1.BackColor = Color.White
        dgvTransactions.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvTransactions.BackgroundColor = Color.White
        dgvTransactions.BorderStyle = BorderStyle.None
        dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTransactions.Columns.AddRange(New DataGridViewColumn() {clmValue, clmDescription, clmTransaction, clmData, clmCategory, clmStatus, clmPayment})
        dgvTransactions.Location = New Point(48, 203)
        dgvTransactions.Name = "dgvTransactions"
        dgvTransactions.Size = New Size(654, 182)
        dgvTransactions.TabIndex = 14
        ' 
        ' clmValue
        ' 
        clmValue.DataPropertyName = "VALOR"
        clmValue.HeaderText = "Valor:"
        clmValue.Name = "clmValue"
        ' 
        ' clmDescription
        ' 
        clmDescription.DataPropertyName = "DESCRICAO"
        clmDescription.HeaderText = "Descrição:"
        clmDescription.Name = "clmDescription"
        ' 
        ' clmTransaction
        ' 
        clmTransaction.DataPropertyName = "TIPO_TRANSACAO_DESC"
        clmTransaction.HeaderText = "Tipo da Transação:"
        clmTransaction.Name = "clmTransaction"
        ' 
        ' clmData
        ' 
        clmData.DataPropertyName = "DATA_TRANSACAO"
        clmData.HeaderText = "Data:"
        clmData.Name = "clmData"
        ' 
        ' clmCategory
        ' 
        clmCategory.DataPropertyName = "CATEGORIA"
        clmCategory.HeaderText = "Categoria:"
        clmCategory.Name = "clmCategory"
        ' 
        ' clmStatus
        ' 
        clmStatus.DataPropertyName = "STATUS"
        clmStatus.HeaderText = "Status:"
        clmStatus.Name = "clmStatus"
        ' 
        ' clmPayment
        ' 
        clmPayment.DataPropertyName = "METODO_PAGAMENTO"
        clmPayment.HeaderText = "Método de pagamento:"
        clmPayment.Name = "clmPayment"
        ' 
        ' frmPrincipal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(752, 450)
        Controls.Add(dgvTransactions)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(txtCoin)
        Controls.Add(txtLastEntry)
        Controls.Add(txtLastExit)
        Controls.Add(txtFiveDays)
        Controls.Add(txtTotalValue)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblName)
        Name = "frmPrincipal"
        Text = "frmPrincipal"
        CType(dgvTransactions, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTotalValue As Label
    Friend WithEvents txtFiveDays As Label
    Friend WithEvents txtLastExit As Label
    Friend WithEvents txtLastEntry As Label
    Friend WithEvents txtCoin As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvTransactions As DataGridView
    Friend WithEvents clmValue As DataGridViewTextBoxColumn
    Friend WithEvents clmDescription As DataGridViewTextBoxColumn
    Friend WithEvents clmTransaction As DataGridViewTextBoxColumn
    Friend WithEvents clmData As DataGridViewTextBoxColumn
    Friend WithEvents clmCategory As DataGridViewTextBoxColumn
    Friend WithEvents clmStatus As DataGridViewTextBoxColumn
    Friend WithEvents clmPayment As DataGridViewTextBoxColumn
End Class
