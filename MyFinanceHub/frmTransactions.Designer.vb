<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransactions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransactions))
        txtDescription = New TextBox()
        cboTransactions = New ComboBox()
        cboCategory = New ComboBox()
        cboPayment = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        lblAdd = New Label()
        txtValor = New TextBox()
        pctBtnSalvar = New PictureBox()
        chkStatus = New CheckBox()
        CType(pctBtnSalvar, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtDescription
        ' 
        txtDescription.Location = New Point(217, 115)
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(340, 23)
        txtDescription.TabIndex = 1
        ' 
        ' cboTransactions
        ' 
        cboTransactions.FormattingEnabled = True
        cboTransactions.Location = New Point(44, 180)
        cboTransactions.Name = "cboTransactions"
        cboTransactions.Size = New Size(167, 23)
        cboTransactions.TabIndex = 2
        ' 
        ' cboCategory
        ' 
        cboCategory.FormattingEnabled = True
        cboCategory.Location = New Point(217, 180)
        cboCategory.Name = "cboCategory"
        cboCategory.Size = New Size(167, 23)
        cboCategory.TabIndex = 3
        ' 
        ' cboPayment
        ' 
        cboPayment.FormattingEnabled = True
        cboPayment.Location = New Point(390, 180)
        cboPayment.Name = "cboPayment"
        cboPayment.Size = New Size(167, 23)
        cboPayment.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Variable Display", 9F)
        Label1.Location = New Point(44, 94)
        Label1.Name = "Label1"
        Label1.Size = New Size(33, 16)
        Label1.TabIndex = 5
        Label1.Text = "Valor"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Variable Display", 9F)
        Label2.Location = New Point(217, 94)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 16)
        Label2.TabIndex = 6
        Label2.Text = "Descrição"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Variable Display", 9F)
        Label3.Location = New Point(44, 162)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 16)
        Label3.TabIndex = 7
        Label3.Text = "Tipo de transação"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Variable Display", 9F)
        Label4.Location = New Point(217, 162)
        Label4.Name = "Label4"
        Label4.Size = New Size(58, 16)
        Label4.TabIndex = 8
        Label4.Text = "Categoria"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Variable Display", 9F)
        Label5.Location = New Point(390, 162)
        Label5.Name = "Label5"
        Label5.Size = New Size(128, 16)
        Label5.TabIndex = 9
        Label5.Text = "Método de pagamento"
        ' 
        ' lblAdd
        ' 
        lblAdd.AutoSize = True
        lblAdd.Font = New Font("Segoe UI Variable Display Semib", 20F, FontStyle.Bold)
        lblAdd.Location = New Point(44, 27)
        lblAdd.Name = "lblAdd"
        lblAdd.Size = New Size(281, 36)
        lblAdd.TabIndex = 10
        lblAdd.Text = "Adicionar lançamento"
        ' 
        ' txtValor
        ' 
        txtValor.Location = New Point(44, 115)
        txtValor.Name = "txtValor"
        txtValor.Size = New Size(167, 23)
        txtValor.TabIndex = 11
        ' 
        ' pctBtnSalvar
        ' 
        pctBtnSalvar.Cursor = Cursors.Hand
        pctBtnSalvar.Image = My.Resources.Resources.adicionar__1_
        pctBtnSalvar.Location = New Point(521, 230)
        pctBtnSalvar.Name = "pctBtnSalvar"
        pctBtnSalvar.Size = New Size(36, 34)
        pctBtnSalvar.SizeMode = PictureBoxSizeMode.Zoom
        pctBtnSalvar.TabIndex = 12
        pctBtnSalvar.TabStop = False
        ' 
        ' chkStatus
        ' 
        chkStatus.AutoSize = True
        chkStatus.Cursor = Cursors.Hand
        chkStatus.Location = New Point(424, 238)
        chkStatus.Name = "chkStatus"
        chkStatus.Size = New Size(53, 19)
        chkStatus.TabIndex = 13
        chkStatus.Text = "Pago"
        chkStatus.UseVisualStyleBackColor = True
        ' 
        ' frmTransactions
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(612, 325)
        Controls.Add(chkStatus)
        Controls.Add(pctBtnSalvar)
        Controls.Add(txtValor)
        Controls.Add(lblAdd)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(cboPayment)
        Controls.Add(cboCategory)
        Controls.Add(cboTransactions)
        Controls.Add(txtDescription)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmTransactions"
        Text = "frmValores"
        CType(pctBtnSalvar, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents cboTransactions As ComboBox
    Friend WithEvents cboCategory As ComboBox
    Friend WithEvents cboPayment As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblAdd As Label
    Friend WithEvents txtValor As TextBox
    Friend WithEvents pctBtnSalvar As PictureBox
    Friend WithEvents chkStatus As CheckBox
End Class
