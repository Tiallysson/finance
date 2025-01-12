<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Label1 = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        btnLogin = New Button()
        btnCancel = New Button()
        Label2 = New Label()
        Label3 = New Label()
        chkTerms = New CheckBox()
        Label4 = New Label()
        LinkLabel1 = New LinkLabel()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Variable Display Semib", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(244, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(114, 49)
        Label1.TabIndex = 0
        Label1.Text = "Login"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(191, 135)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(212, 23)
        txtUsername.TabIndex = 1
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(191, 179)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "•"c
        txtPassword.Size = New Size(212, 23)
        txtPassword.TabIndex = 2
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(305, 233)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(98, 23)
        btnLogin.TabIndex = 3
        btnLogin.Text = "Continuar"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(191, 233)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(98, 23)
        btnCancel.TabIndex = 4
        btnCancel.Text = "Cancelar"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Variable Small", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(192, 162)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 16)
        Label2.TabIndex = 6
        Label2.Text = "Senha"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(192, 118)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 16)
        Label3.TabIndex = 7
        Label3.Text = "Usuário"
        ' 
        ' chkTerms
        ' 
        chkTerms.AutoSize = True
        chkTerms.Location = New Point(192, 210)
        chkTerms.Name = "chkTerms"
        chkTerms.Size = New Size(184, 19)
        chkTerms.TabIndex = 8
        chkTerms.Text = "Aceito os termos de utilização"
        chkTerms.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(201, 259)
        Label4.Name = "Label4"
        Label4.Size = New Size(118, 15)
        Label4.TabIndex = 9
        Label4.Text = "Não tem uma conta?"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(320, 259)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(69, 15)
        LinkLabel1.TabIndex = 10
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Cadastre-se"
        ' 
        ' frmLogin
        ' 
        AcceptButton = btnLogin
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = btnCancel
        ClientSize = New Size(607, 363)
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
        FormBorderStyle = FormBorderStyle.None
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmLogin"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents chkTerms As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
