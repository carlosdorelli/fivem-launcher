<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Launcher
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Launcher))
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.Michael = New System.Windows.Forms.PictureBox()
        Me.EntrarNaCidade = New System.Windows.Forms.Button()
        Me.LimparCache = New System.Windows.Forms.Button()
        Me.Copyright = New System.Windows.Forms.Label()
        Me.Discord = New System.Windows.Forms.PictureBox()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Michael, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Discord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Logo
        '
        Me.Logo.BackColor = System.Drawing.Color.Transparent
        Me.Logo.BackgroundImage = CType(resources.GetObject("Logo.BackgroundImage"), System.Drawing.Image)
        Me.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Logo.Location = New System.Drawing.Point(500, 142)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(320, 162)
        Me.Logo.TabIndex = 0
        Me.Logo.TabStop = False
        '
        'Michael
        '
        Me.Michael.BackColor = System.Drawing.Color.Transparent
        Me.Michael.BackgroundImage = CType(resources.GetObject("Michael.BackgroundImage"), System.Drawing.Image)
        Me.Michael.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Michael.Location = New System.Drawing.Point(21, -65)
        Me.Michael.Name = "Michael"
        Me.Michael.Size = New System.Drawing.Size(614, 680)
        Me.Michael.TabIndex = 1
        Me.Michael.TabStop = False
        '
        'EntrarNaCidade
        '
        Me.EntrarNaCidade.BackColor = System.Drawing.Color.LimeGreen
        Me.EntrarNaCidade.FlatAppearance.BorderSize = 0
        Me.EntrarNaCidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EntrarNaCidade.Font = New System.Drawing.Font("Aharoni", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.EntrarNaCidade.ForeColor = System.Drawing.Color.White
        Me.EntrarNaCidade.Location = New System.Drawing.Point(517, 352)
        Me.EntrarNaCidade.Name = "EntrarNaCidade"
        Me.EntrarNaCidade.Size = New System.Drawing.Size(287, 68)
        Me.EntrarNaCidade.TabIndex = 2
        Me.EntrarNaCidade.Text = "ENTRAR NA CIDADE"
        Me.EntrarNaCidade.UseVisualStyleBackColor = False
        '
        'LimparCache
        '
        Me.LimparCache.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.LimparCache.FlatAppearance.BorderSize = 0
        Me.LimparCache.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LimparCache.Font = New System.Drawing.Font("Aharoni", 15.75!, System.Drawing.FontStyle.Bold)
        Me.LimparCache.ForeColor = System.Drawing.Color.White
        Me.LimparCache.Location = New System.Drawing.Point(517, 426)
        Me.LimparCache.Name = "LimparCache"
        Me.LimparCache.Size = New System.Drawing.Size(287, 41)
        Me.LimparCache.TabIndex = 3
        Me.LimparCache.Text = "Limpar cache"
        Me.LimparCache.UseVisualStyleBackColor = False
        '
        'Copyright
        '
        Me.Copyright.AutoSize = True
        Me.Copyright.BackColor = System.Drawing.Color.Transparent
        Me.Copyright.ForeColor = System.Drawing.Color.White
        Me.Copyright.Location = New System.Drawing.Point(653, 586)
        Me.Copyright.Name = "Copyright"
        Me.Copyright.Size = New System.Drawing.Size(248, 13)
        Me.Copyright.TabIndex = 4
        Me.Copyright.Text = "Todos os direitos reservados 2020 - SuaCidade RP"
        '
        'Discord
        '
        Me.Discord.BackColor = System.Drawing.Color.Transparent
        Me.Discord.BackgroundImage = CType(resources.GetObject("Discord.BackgroundImage"), System.Drawing.Image)
        Me.Discord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Discord.Location = New System.Drawing.Point(898, 526)
        Me.Discord.Name = "Discord"
        Me.Discord.Size = New System.Drawing.Size(74, 73)
        Me.Discord.TabIndex = 5
        Me.Discord.TabStop = False
        '
        'Launcher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(984, 611)
        Me.Controls.Add(Me.Discord)
        Me.Controls.Add(Me.Copyright)
        Me.Controls.Add(Me.LimparCache)
        Me.Controls.Add(Me.EntrarNaCidade)
        Me.Controls.Add(Me.Logo)
        Me.Controls.Add(Me.Michael)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Launcher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FiveM Server Launcher | Created by Carlos ""Eldremor"" Dorelli"
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Michael, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Discord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Logo As PictureBox
    Friend WithEvents Michael As PictureBox
    Friend WithEvents EntrarNaCidade As Button
    Friend WithEvents LimparCache As Button
    Friend WithEvents Copyright As Label
    Friend WithEvents Discord As PictureBox
End Class
