<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHome))
        lblName = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        lblTotalValue = New Label()
        lblFiveDays = New Label()
        lblLastExit = New Label()
        lblLastEntry = New Label()
        txtCoin = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        dgvTransactions = New DataGridView()
        ptbMenu = New PictureBox()
        pnlMenu = New Panel()
        PictureBox2 = New PictureBox()
        pcbButtonExit = New PictureBox()
        Editar = New DataGridViewImageColumn()
        clmValue = New DataGridViewTextBoxColumn()
        Id = New DataGridViewTextBoxColumn()
        clmDescription = New DataGridViewTextBoxColumn()
        clmTransaction = New DataGridViewTextBoxColumn()
        clmData = New DataGridViewTextBoxColumn()
        clmCategory = New DataGridViewTextBoxColumn()
        clmStatus = New DataGridViewTextBoxColumn()
        clmPayment = New DataGridViewTextBoxColumn()
        CType(dgvTransactions, ComponentModel.ISupportInitialize).BeginInit()
        CType(ptbMenu, ComponentModel.ISupportInitialize).BeginInit()
        pnlMenu.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(pcbButtonExit, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Segoe UI Variable Display Semib", 20F, FontStyle.Bold)
        lblName.Location = New Point(48, 23)
        lblName.Name = "lblName"
        lblName.Size = New Size(100, 36)
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
        Label2.Location = New Point(214, 97)
        Label2.Name = "Label2"
        Label2.Size = New Size(141, 16)
        Label2.TabIndex = 3
        Label2.Text = "Gasto nos últimos 5 dias:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold)
        Label3.Location = New Point(463, 97)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 16)
        Label3.TabIndex = 4
        Label3.Text = "Última venda:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold)
        Label4.Location = New Point(663, 97)
        Label4.Name = "Label4"
        Label4.Size = New Size(91, 16)
        Label4.TabIndex = 5
        Label4.Text = "Última compra:"
        ' 
        ' lblTotalValue
        ' 
        lblTotalValue.AutoSize = True
        lblTotalValue.Font = New Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalValue.Location = New Point(84, 127)
        lblTotalValue.Name = "lblTotalValue"
        lblTotalValue.Size = New Size(16, 21)
        lblTotalValue.TabIndex = 6
        lblTotalValue.Text = "-"
        ' 
        ' lblFiveDays
        ' 
        lblFiveDays.AutoSize = True
        lblFiveDays.Font = New Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFiveDays.Location = New Point(250, 127)
        lblFiveDays.Name = "lblFiveDays"
        lblFiveDays.Size = New Size(16, 21)
        lblFiveDays.TabIndex = 7
        lblFiveDays.Text = "-"
        ' 
        ' lblLastExit
        ' 
        lblLastExit.AutoSize = True
        lblLastExit.Font = New Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblLastExit.Location = New Point(499, 127)
        lblLastExit.Name = "lblLastExit"
        lblLastExit.Size = New Size(16, 21)
        lblLastExit.TabIndex = 8
        lblLastExit.Text = "-"
        ' 
        ' lblLastEntry
        ' 
        lblLastEntry.AutoSize = True
        lblLastEntry.Font = New Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblLastEntry.Location = New Point(699, 127)
        lblLastEntry.Name = "lblLastEntry"
        lblLastEntry.Size = New Size(16, 21)
        lblLastEntry.TabIndex = 9
        lblLastEntry.Text = "-"
        ' 
        ' txtCoin
        ' 
        txtCoin.AutoSize = True
        txtCoin.Font = New Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtCoin.Location = New Point(48, 127)
        txtCoin.Name = "txtCoin"
        txtCoin.Size = New Size(30, 21)
        txtCoin.TabIndex = 10
        txtCoin.Text = "R$"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(214, 127)
        Label5.Name = "Label5"
        Label5.Size = New Size(30, 21)
        Label5.TabIndex = 11
        Label5.Text = "R$"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(463, 127)
        Label6.Name = "Label6"
        Label6.Size = New Size(30, 21)
        Label6.TabIndex = 12
        Label6.Text = "R$"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(663, 127)
        Label7.Name = "Label7"
        Label7.Size = New Size(30, 21)
        Label7.TabIndex = 13
        Label7.Text = "R$"
        ' 
        ' dgvTransactions
        ' 
        dgvTransactions.AllowUserToAddRows = False
        dgvTransactions.AllowUserToDeleteRows = False
        dgvTransactions.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = Color.White
        dgvTransactions.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvTransactions.BackgroundColor = Color.White
        dgvTransactions.BorderStyle = BorderStyle.None
        dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTransactions.Columns.AddRange(New DataGridViewColumn() {Editar, clmValue, Id, clmDescription, clmTransaction, clmData, clmCategory, clmStatus, clmPayment})
        dgvTransactions.EditMode = DataGridViewEditMode.EditOnF2
        dgvTransactions.Location = New Point(48, 203)
        dgvTransactions.Name = "dgvTransactions"
        dgvTransactions.ReadOnly = True
        dgvTransactions.Size = New Size(748, 296)
        dgvTransactions.TabIndex = 14
        ' 
        ' ptbMenu
        ' 
        ptbMenu.Cursor = Cursors.Hand
        ptbMenu.Image = My.Resources.Resources.menu_hamburguer
        ptbMenu.Location = New Point(776, 29)
        ptbMenu.Name = "ptbMenu"
        ptbMenu.Size = New Size(24, 27)
        ptbMenu.SizeMode = PictureBoxSizeMode.Zoom
        ptbMenu.TabIndex = 15
        ptbMenu.TabStop = False
        ' 
        ' pnlMenu
        ' 
        pnlMenu.BackColor = SystemColors.ButtonHighlight
        pnlMenu.Controls.Add(PictureBox2)
        pnlMenu.Controls.Add(pcbButtonExit)
        pnlMenu.Location = New Point(634, 22)
        pnlMenu.Name = "pnlMenu"
        pnlMenu.Size = New Size(120, 37)
        pnlMenu.TabIndex = 16
        pnlMenu.Visible = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Cursor = Cursors.Hand
        PictureBox2.Image = My.Resources.Resources.adicionar__1_1
        PictureBox2.Location = New Point(51, 7)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(27, 27)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' pcbButtonExit
        ' 
        pcbButtonExit.Cursor = Cursors.Hand
        pcbButtonExit.Image = My.Resources.Resources.cartao_de_endereco
        pcbButtonExit.Location = New Point(94, 7)
        pcbButtonExit.Name = "pcbButtonExit"
        pcbButtonExit.Size = New Size(23, 27)
        pcbButtonExit.SizeMode = PictureBoxSizeMode.Zoom
        pcbButtonExit.TabIndex = 0
        pcbButtonExit.TabStop = False
        ' 
        ' Editar
        ' 
        Editar.HeaderText = ""
        Editar.Image = My.Resources.Resources.lapis__1_
        Editar.ImageLayout = DataGridViewImageCellLayout.Zoom
        Editar.Name = "Editar"
        Editar.ReadOnly = True
        Editar.Width = 20
        ' 
        ' clmValue
        ' 
        clmValue.DataPropertyName = "VALOR"
        clmValue.HeaderText = "Valor:"
        clmValue.Name = "clmValue"
        clmValue.ReadOnly = True
        ' 
        ' Id
        ' 
        Id.DataPropertyName = "ID"
        Id.HeaderText = "Id"
        Id.Name = "Id"
        Id.ReadOnly = True
        Id.Visible = False
        ' 
        ' clmDescription
        ' 
        clmDescription.DataPropertyName = "DESCRICAO"
        clmDescription.HeaderText = "Descrição:"
        clmDescription.Name = "clmDescription"
        clmDescription.ReadOnly = True
        ' 
        ' clmTransaction
        ' 
        clmTransaction.DataPropertyName = "TIPO_TRANSACAO_DESC"
        clmTransaction.HeaderText = "Tipo da Transação:"
        clmTransaction.Name = "clmTransaction"
        clmTransaction.ReadOnly = True
        ' 
        ' clmData
        ' 
        clmData.DataPropertyName = "DATA_TRANSACAO"
        clmData.HeaderText = "Data:"
        clmData.Name = "clmData"
        clmData.ReadOnly = True
        ' 
        ' clmCategory
        ' 
        clmCategory.DataPropertyName = "CATEGORIA"
        clmCategory.HeaderText = "Categoria:"
        clmCategory.Name = "clmCategory"
        clmCategory.ReadOnly = True
        ' 
        ' clmStatus
        ' 
        clmStatus.DataPropertyName = "STATUS"
        clmStatus.HeaderText = "Status:"
        clmStatus.Name = "clmStatus"
        clmStatus.ReadOnly = True
        ' 
        ' clmPayment
        ' 
        clmPayment.DataPropertyName = "METODO_PAGAMENTO"
        clmPayment.HeaderText = "Método de pagamento:"
        clmPayment.Name = "clmPayment"
        clmPayment.ReadOnly = True
        ' 
        ' frmHome
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(838, 511)
        Controls.Add(pnlMenu)
        Controls.Add(ptbMenu)
        Controls.Add(dgvTransactions)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(txtCoin)
        Controls.Add(lblLastEntry)
        Controls.Add(lblLastExit)
        Controls.Add(lblFiveDays)
        Controls.Add(lblTotalValue)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblName)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmHome"
        Text = "frmPrincipal"
        CType(dgvTransactions, ComponentModel.ISupportInitialize).EndInit()
        CType(ptbMenu, ComponentModel.ISupportInitialize).EndInit()
        pnlMenu.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(pcbButtonExit, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTotalValue As Label
    Friend WithEvents lblFiveDays As Label
    Friend WithEvents lblLastExit As Label
    Friend WithEvents lblLastEntry As Label
    Friend WithEvents txtCoin As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvTransactions As DataGridView
    Friend WithEvents ptbMenu As PictureBox
    Friend WithEvents pnlMenu As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents pcbButtonExit As PictureBox
    Friend WithEvents Editar As DataGridViewImageColumn
    Friend WithEvents clmValue As DataGridViewTextBoxColumn
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents clmDescription As DataGridViewTextBoxColumn
    Friend WithEvents clmTransaction As DataGridViewTextBoxColumn
    Friend WithEvents clmData As DataGridViewTextBoxColumn
    Friend WithEvents clmCategory As DataGridViewTextBoxColumn
    Friend WithEvents clmStatus As DataGridViewTextBoxColumn
    Friend WithEvents clmPayment As DataGridViewTextBoxColumn
End Class
