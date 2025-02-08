<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsers))
        LinkLabel1 = New LinkLabel()
        Label4 = New Label()
        chkTerms = New CheckBox()
        Label3 = New Label()
        Label2 = New Label()
        btnCancel = New Button()
        btnLogin = New Button()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        Label1 = New Label()
        Label6 = New Label()
        TextBox2 = New TextBox()
        Label7 = New Label()
        TextBox3 = New TextBox()
        Label5 = New Label()
        TextBox1 = New TextBox()
        Label8 = New Label()
        TextBox4 = New TextBox()
        SuspendLayout()
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(394, 398)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(64, 15)
        LinkLabel1.TabIndex = 20
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Fazer login"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(282, 398)
        Label4.Name = "Label4"
        Label4.Size = New Size(106, 15)
        Label4.TabIndex = 19
        Label4.Text = "Já tem uma conta?"
        ' 
        ' chkTerms
        ' 
        chkTerms.AutoSize = True
        chkTerms.Location = New Point(282, 347)
        chkTerms.Name = "chkTerms"
        chkTerms.Size = New Size(184, 19)
        chkTerms.TabIndex = 18
        chkTerms.Text = "Aceito os termos de utilização"
        chkTerms.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(279, 171)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 16)
        Label3.TabIndex = 17
        Label3.Text = "Usuário"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Variable Small", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(279, 257)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 16)
        Label2.TabIndex = 16
        Label2.Text = "Senha"
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(278, 372)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(98, 23)
        btnCancel.TabIndex = 15
        btnCancel.Text = "Cancelar"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(392, 372)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(98, 23)
        btnLogin.TabIndex = 14
        btnLogin.Text = "Salvar"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(278, 274)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(212, 23)
        txtPassword.TabIndex = 13
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(278, 188)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(212, 23)
        txtUsername.TabIndex = 12
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Variable Display Semib", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(203, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(363, 49)
        Label1.TabIndex = 11
        Label1.Text = "Cadastro de Usuário"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(278, 126)
        Label6.Name = "Label6"
        Label6.Size = New Size(68, 16)
        Label6.TabIndex = 24
        Label6.Text = "Sobrenome"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(278, 145)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(212, 23)
        TextBox2.TabIndex = 23
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(280, 83)
        Label7.Name = "Label7"
        Label7.Size = New Size(39, 16)
        Label7.TabIndex = 26
        Label7.Text = "Nome"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(279, 100)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(212, 23)
        TextBox3.TabIndex = 25
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(279, 214)
        Label5.Name = "Label5"
        Label5.Size = New Size(35, 16)
        Label5.TabIndex = 28
        Label5.Text = "Email"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(278, 231)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(212, 23)
        TextBox1.TabIndex = 27
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Variable Small", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(279, 300)
        Label8.Name = "Label8"
        Label8.Size = New Size(61, 16)
        Label8.TabIndex = 30
        Label8.Text = "Confirmar"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(278, 317)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(212, 23)
        TextBox4.TabIndex = 29
        ' 
        ' frmUsers
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label8)
        Controls.Add(TextBox4)
        Controls.Add(Label5)
        Controls.Add(TextBox1)
        Controls.Add(Label7)
        Controls.Add(TextBox3)
        Controls.Add(Label6)
        Controls.Add(TextBox2)
        Controls.Add(LinkLabel1)
        Controls.Add(Label4)
        Controls.Add(chkTerms)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btnCancel)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmUsers"
        Text = "frmCadastro"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents chkTerms As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox4 As TextBox
End Class
