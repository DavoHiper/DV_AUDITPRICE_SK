<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmAuditorias
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.lstArquivos = New System.Windows.Forms.ListBox
        Me.lblArquivo = New System.Windows.Forms.Label
        Me.lblDepto = New System.Windows.Forms.Label
        Me.lblSecao = New System.Windows.Forms.Label
        Me.lblGrupo = New System.Windows.Forms.Label
        Me.lblSubgrupo = New System.Windows.Forms.Label
        Me.txtArquivo = New System.Windows.Forms.TextBox
        Me.txtDpto = New System.Windows.Forms.TextBox
        Me.txtGrupo = New System.Windows.Forms.TextBox
        Me.txtSubgrupo = New System.Windows.Forms.TextBox
        Me.cmdOk = New System.Windows.Forms.Button
        Me.cmdSair = New System.Windows.Forms.Button
        Me.txtSecao = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.Location = New System.Drawing.Point(9, 4)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(151, 20)
        Me.lblTitulo.Text = "Selecione um arquivo:"
        '
        'lstArquivos
        '
        Me.lstArquivos.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular)
        Me.lstArquivos.Location = New System.Drawing.Point(9, 23)
        Me.lstArquivos.Name = "lstArquivos"
        Me.lstArquivos.Size = New System.Drawing.Size(215, 71)
        Me.lstArquivos.TabIndex = 1
        '
        'lblArquivo
        '
        Me.lblArquivo.Location = New System.Drawing.Point(10, 104)
        Me.lblArquivo.Name = "lblArquivo"
        Me.lblArquivo.Size = New System.Drawing.Size(100, 20)
        Me.lblArquivo.Text = "Arquivo:"
        '
        'lblDepto
        '
        Me.lblDepto.Location = New System.Drawing.Point(10, 130)
        Me.lblDepto.Name = "lblDepto"
        Me.lblDepto.Size = New System.Drawing.Size(100, 20)
        Me.lblDepto.Text = "Depto:"
        '
        'lblSecao
        '
        Me.lblSecao.Location = New System.Drawing.Point(10, 156)
        Me.lblSecao.Name = "lblSecao"
        Me.lblSecao.Size = New System.Drawing.Size(100, 20)
        Me.lblSecao.Text = "Seção:"
        '
        'lblGrupo
        '
        Me.lblGrupo.Location = New System.Drawing.Point(10, 182)
        Me.lblGrupo.Name = "lblGrupo"
        Me.lblGrupo.Size = New System.Drawing.Size(100, 20)
        Me.lblGrupo.Text = "Grupo:"
        '
        'lblSubgrupo
        '
        Me.lblSubgrupo.Location = New System.Drawing.Point(10, 208)
        Me.lblSubgrupo.Name = "lblSubgrupo"
        Me.lblSubgrupo.Size = New System.Drawing.Size(100, 20)
        Me.lblSubgrupo.Text = "SubGrupo:"
        '
        'txtArquivo
        '
        Me.txtArquivo.BackColor = System.Drawing.SystemColors.Control
        Me.txtArquivo.Enabled = False
        Me.txtArquivo.Location = New System.Drawing.Point(76, 101)
        Me.txtArquivo.Name = "txtArquivo"
        Me.txtArquivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtArquivo.Size = New System.Drawing.Size(148, 23)
        Me.txtArquivo.TabIndex = 15
        '
        'txtDpto
        '
        Me.txtDpto.BackColor = System.Drawing.SystemColors.Control
        Me.txtDpto.Enabled = False
        Me.txtDpto.Location = New System.Drawing.Point(76, 127)
        Me.txtDpto.Name = "txtDpto"
        Me.txtDpto.Size = New System.Drawing.Size(148, 23)
        Me.txtDpto.TabIndex = 18
        '
        'txtGrupo
        '
        Me.txtGrupo.BackColor = System.Drawing.SystemColors.Control
        Me.txtGrupo.Enabled = False
        Me.txtGrupo.Location = New System.Drawing.Point(76, 179)
        Me.txtGrupo.Name = "txtGrupo"
        Me.txtGrupo.Size = New System.Drawing.Size(148, 23)
        Me.txtGrupo.TabIndex = 20
        '
        'txtSubgrupo
        '
        Me.txtSubgrupo.BackColor = System.Drawing.SystemColors.Control
        Me.txtSubgrupo.Enabled = False
        Me.txtSubgrupo.Location = New System.Drawing.Point(76, 205)
        Me.txtSubgrupo.Name = "txtSubgrupo"
        Me.txtSubgrupo.Size = New System.Drawing.Size(148, 23)
        Me.txtSubgrupo.TabIndex = 21
        '
        'cmdOk
        '
        Me.cmdOk.Enabled = False
        Me.cmdOk.Location = New System.Drawing.Point(76, 234)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(148, 33)
        Me.cmdOk.TabIndex = 22
        Me.cmdOk.Text = "Selecionar Arquivo"
        '
        'cmdSair
        '
        Me.cmdSair.Location = New System.Drawing.Point(4, 234)
        Me.cmdSair.Name = "cmdSair"
        Me.cmdSair.Size = New System.Drawing.Size(66, 33)
        Me.cmdSair.TabIndex = 23
        Me.cmdSair.Text = "Sair"
        '
        'txtSecao
        '
        Me.txtSecao.BackColor = System.Drawing.SystemColors.Control
        Me.txtSecao.Enabled = False
        Me.txtSecao.Location = New System.Drawing.Point(76, 153)
        Me.txtSecao.Name = "txtSecao"
        Me.txtSecao.Size = New System.Drawing.Size(148, 23)
        Me.txtSecao.TabIndex = 19
        '
        'frmAuditorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(638, 455)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdSair)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.txtSubgrupo)
        Me.Controls.Add(Me.txtGrupo)
        Me.Controls.Add(Me.txtSecao)
        Me.Controls.Add(Me.txtDpto)
        Me.Controls.Add(Me.txtArquivo)
        Me.Controls.Add(Me.lblSubgrupo)
        Me.Controls.Add(Me.lblGrupo)
        Me.Controls.Add(Me.lblSecao)
        Me.Controls.Add(Me.lblDepto)
        Me.Controls.Add(Me.lblArquivo)
        Me.Controls.Add(Me.lstArquivos)
        Me.Controls.Add(Me.lblTitulo)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAuditorias"
        Me.Text = "Auditoria de Preços"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lstArquivos As System.Windows.Forms.ListBox
    Friend WithEvents lblArquivo As System.Windows.Forms.Label
    Friend WithEvents lblDepto As System.Windows.Forms.Label
    Friend WithEvents lblSecao As System.Windows.Forms.Label
    Friend WithEvents lblGrupo As System.Windows.Forms.Label
    Friend WithEvents lblSubgrupo As System.Windows.Forms.Label
    Friend WithEvents txtArquivo As System.Windows.Forms.TextBox
    Friend WithEvents txtDpto As System.Windows.Forms.TextBox
    Friend WithEvents txtGrupo As System.Windows.Forms.TextBox
    Friend WithEvents txtSubgrupo As System.Windows.Forms.TextBox
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdSair As System.Windows.Forms.Button
    Friend WithEvents txtSecao As System.Windows.Forms.TextBox
End Class
