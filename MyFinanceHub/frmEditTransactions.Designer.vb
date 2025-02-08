<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditTransactions
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
        pctBtnSalvar = New PictureBox()
        txtValor = New TextBox()
        lblAdd = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        cboPayment = New ComboBox()
        cboCategory = New ComboBox()
        cboTransactions = New ComboBox()
        txtDescription = New TextBox()
        cboStatus = New ComboBox()
        CType(pctBtnSalvar, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pctBtnSalvar
        ' 
        pctBtnSalvar.Cursor = Cursors.Hand
        pctBtnSalvar.Image = My.Resources.Resources.adicionar__1_
        pctBtnSalvar.Location = New Point(549, 266)
        pctBtnSalvar.Name = "pctBtnSalvar"
        pctBtnSalvar.Size = New Size(36, 34)
        pctBtnSalvar.SizeMode = PictureBoxSizeMode.Zoom
        pctBtnSalvar.TabIndex = 25
        pctBtnSalvar.TabStop = False
        ' 
        ' txtValor
        ' 
        txtValor.Location = New Point(72, 151)
        txtValor.Name = "txtValor"
        txtValor.Size = New Size(167, 23)
        txtValor.TabIndex = 24
        ' 
        ' lblAdd
        ' 
        lblAdd.AutoSize = True
        lblAdd.Font = New Font("Segoe UI Variable Display Semib", 20F, FontStyle.Bold)
        lblAdd.Location = New Point(72, 63)
        lblAdd.Name = "lblAdd"
        lblAdd.Size = New Size(86, 36)
        lblAdd.TabIndex = 23
        lblAdd.Text = "Editar"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Variable Display", 9F)
        Label5.Location = New Point(418, 198)
        Label5.Name = "Label5"
        Label5.Size = New Size(128, 16)
        Label5.TabIndex = 22
        Label5.Text = "Método de pagamento"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Variable Display", 9F)
        Label4.Location = New Point(245, 198)
        Label4.Name = "Label4"
        Label4.Size = New Size(58, 16)
        Label4.TabIndex = 21
        Label4.Text = "Categoria"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Variable Display", 9F)
        Label3.Location = New Point(72, 198)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 16)
        Label3.TabIndex = 20
        Label3.Text = "Tipo de transação"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Variable Display", 9F)
        Label2.Location = New Point(245, 130)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 16)
        Label2.TabIndex = 19
        Label2.Text = "Descrição"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Variable Display", 9F)
        Label1.Location = New Point(72, 130)
        Label1.Name = "Label1"
        Label1.Size = New Size(33, 16)
        Label1.TabIndex = 18
        Label1.Text = "Valor"
        ' 
        ' cboPayment
        ' 
        cboPayment.FormattingEnabled = True
        cboPayment.Location = New Point(418, 216)
        cboPayment.Name = "cboPayment"
        cboPayment.Size = New Size(167, 23)
        cboPayment.TabIndex = 17
        ' 
        ' cboCategory
        ' 
        cboCategory.FormattingEnabled = True
        cboCategory.Location = New Point(245, 216)
        cboCategory.Name = "cboCategory"
        cboCategory.Size = New Size(167, 23)
        cboCategory.TabIndex = 16
        ' 
        ' cboTransactions
        ' 
        cboTransactions.FormattingEnabled = True
        cboTransactions.Location = New Point(72, 216)
        cboTransactions.Name = "cboTransactions"
        cboTransactions.Size = New Size(167, 23)
        cboTransactions.TabIndex = 15
        ' 
        ' txtDescription
        ' 
        txtDescription.Location = New Point(245, 151)
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(340, 23)
        txtDescription.TabIndex = 14
        ' 
        ' cboStatus
        ' 
        cboStatus.FormattingEnabled = True
        cboStatus.Items.AddRange(New Object() {"Concluída", "Cancelada", "Pendente"})
        cboStatus.Location = New Point(396, 272)
        cboStatus.Name = "cboStatus"
        cboStatus.Size = New Size(121, 23)
        cboStatus.TabIndex = 26
        ' 
        ' frmEditTransactions
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(663, 435)
        Controls.Add(cboStatus)
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
        Name = "frmEditTransactions"
        Text = "frmEditTransactions"
        CType(pctBtnSalvar, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents pctBtnSalvar As PictureBox
    Friend WithEvents txtValor As TextBox
    Friend WithEvents lblAdd As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboPayment As ComboBox
    Friend WithEvents cboCategory As ComboBox
    Friend WithEvents cboTransactions As ComboBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents cboStatus As ComboBox
End Class
