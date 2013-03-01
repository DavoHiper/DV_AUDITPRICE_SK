<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Coleta
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
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.txtLastFocus = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblOferta = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtQtdEtq = New System.Windows.Forms.TextBox
        Me.lblQtdEtq = New System.Windows.Forms.Label
        Me.cmdSair = New System.Windows.Forms.Button
        Me.cmdConfirma = New System.Windows.Forms.Button
        Me.chkPrc = New System.Windows.Forms.CheckBox
        Me.lblMsg = New System.Windows.Forms.Label
        Me.btnSim = New System.Windows.Forms.Button
        Me.btnNao = New System.Windows.Forms.Button
        Me.frmMsg = New System.Windows.Forms.Panel
        Me.chkEtq = New System.Windows.Forms.CheckBox
        Me.lblPreco = New System.Windows.Forms.Label
        Me.lblProduto = New System.Windows.Forms.Label
        Me.txtPreco = New System.Windows.Forms.TextBox
        Me.frmMsg.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Regular)
        Me.txtCodigo.Location = New System.Drawing.Point(19, 24)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(174, 31)
        Me.txtCodigo.TabIndex = 1
        '
        'txtLastFocus
        '
        Me.txtLastFocus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLastFocus.ForeColor = System.Drawing.SystemColors.Control
        Me.txtLastFocus.Location = New System.Drawing.Point(165, 28)
        Me.txtLastFocus.Name = "txtLastFocus"
        Me.txtLastFocus.Size = New System.Drawing.Size(12, 23)
        Me.txtLastFocus.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(9, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.Text = "Descrição:"
        '
        'lblOferta
        '
        Me.lblOferta.BackColor = System.Drawing.Color.Tomato
        Me.lblOferta.Enabled = False
        Me.lblOferta.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular)
        Me.lblOferta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblOferta.Location = New System.Drawing.Point(117, 136)
        Me.lblOferta.Name = "lblOferta"
        Me.lblOferta.Size = New System.Drawing.Size(90, 32)
        Me.lblOferta.Text = "ITEM EM OFERTA"
        Me.lblOferta.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblOferta.Visible = False
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(9, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 20)
        Me.Label5.Text = "Preço:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(26, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 20)
        Me.Label1.Text = "Scaneie o Código de Barra"
        '
        'txtQtdEtq
        '
        Me.txtQtdEtq.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.txtQtdEtq.Location = New System.Drawing.Point(107, 229)
        Me.txtQtdEtq.Name = "txtQtdEtq"
        Me.txtQtdEtq.Size = New System.Drawing.Size(34, 32)
        Me.txtQtdEtq.TabIndex = 6
        Me.txtQtdEtq.Visible = False
        '
        'lblQtdEtq
        '
        Me.lblQtdEtq.ForeColor = System.Drawing.Color.Black
        Me.lblQtdEtq.Location = New System.Drawing.Point(11, 241)
        Me.lblQtdEtq.Name = "lblQtdEtq"
        Me.lblQtdEtq.Size = New System.Drawing.Size(108, 20)
        Me.lblQtdEtq.Text = "Qtd. Etiqueta(s):"
        Me.lblQtdEtq.Visible = False
        '
        'cmdSair
        '
        Me.cmdSair.Location = New System.Drawing.Point(11, 267)
        Me.cmdSair.Name = "cmdSair"
        Me.cmdSair.Size = New System.Drawing.Size(49, 25)
        Me.cmdSair.TabIndex = 50
        Me.cmdSair.Text = "Sair"
        '
        'cmdConfirma
        '
        Me.cmdConfirma.Enabled = False
        Me.cmdConfirma.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.cmdConfirma.Location = New System.Drawing.Point(145, 229)
        Me.cmdConfirma.Name = "cmdConfirma"
        Me.cmdConfirma.Size = New System.Drawing.Size(62, 32)
        Me.cmdConfirma.TabIndex = 7
        Me.cmdConfirma.Text = "OK"
        '
        'chkPrc
        '
        Me.chkPrc.Enabled = False
        Me.chkPrc.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.chkPrc.Location = New System.Drawing.Point(10, 171)
        Me.chkPrc.Name = "chkPrc"
        Me.chkPrc.Size = New System.Drawing.Size(89, 37)
        Me.chkPrc.TabIndex = 4
        Me.chkPrc.Text = "Preço"
        '
        'lblMsg
        '
        Me.lblMsg.Font = New System.Drawing.Font("Tahoma", 13.0!, System.Drawing.FontStyle.Regular)
        Me.lblMsg.Location = New System.Drawing.Point(3, 3)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(213, 50)
        Me.lblMsg.Text = "Item não cadastrado, deseja auditar?"
        '
        'btnSim
        '
        Me.btnSim.BackColor = System.Drawing.SystemColors.Info
        Me.btnSim.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
        Me.btnSim.Location = New System.Drawing.Point(3, 55)
        Me.btnSim.Name = "btnSim"
        Me.btnSim.Size = New System.Drawing.Size(85, 32)
        Me.btnSim.TabIndex = 8
        Me.btnSim.Text = "Sim"
        '
        'btnNao
        '
        Me.btnNao.BackColor = System.Drawing.SystemColors.Info
        Me.btnNao.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
        Me.btnNao.Location = New System.Drawing.Point(106, 55)
        Me.btnNao.Name = "btnNao"
        Me.btnNao.Size = New System.Drawing.Size(88, 32)
        Me.btnNao.TabIndex = 9
        Me.btnNao.Text = "Não"
        '
        'frmMsg
        '
        Me.frmMsg.BackColor = System.Drawing.SystemColors.Info
        Me.frmMsg.Controls.Add(Me.lblMsg)
        Me.frmMsg.Controls.Add(Me.btnNao)
        Me.frmMsg.Controls.Add(Me.btnSim)
        Me.frmMsg.Location = New System.Drawing.Point(11, 134)
        Me.frmMsg.Name = "frmMsg"
        Me.frmMsg.Size = New System.Drawing.Size(197, 90)
        Me.frmMsg.Visible = False
        '
        'chkEtq
        '
        Me.chkEtq.Enabled = False
        Me.chkEtq.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.chkEtq.Location = New System.Drawing.Point(105, 171)
        Me.chkEtq.Name = "chkEtq"
        Me.chkEtq.Size = New System.Drawing.Size(110, 37)
        Me.chkEtq.TabIndex = 5
        Me.chkEtq.Text = "Etiqueta"
        '
        'lblPreco
        '
        Me.lblPreco.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.lblPreco.Location = New System.Drawing.Point(12, 134)
        Me.lblPreco.Name = "lblPreco"
        Me.lblPreco.Size = New System.Drawing.Size(99, 32)
        '
        'lblProduto
        '
        Me.lblProduto.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblProduto.Location = New System.Drawing.Point(8, 79)
        Me.lblProduto.Name = "lblProduto"
        Me.lblProduto.Size = New System.Drawing.Size(200, 34)
        '
        'txtPreco
        '
        Me.txtPreco.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.txtPreco.Location = New System.Drawing.Point(14, 229)
        Me.txtPreco.Name = "txtPreco"
        Me.txtPreco.Size = New System.Drawing.Size(127, 32)
        Me.txtPreco.TabIndex = 56
        Me.txtPreco.Visible = False
        '
        'Coleta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(640, 480)
        Me.ControlBox = False
        Me.Controls.Add(Me.frmMsg)
        Me.Controls.Add(Me.txtPreco)
        Me.Controls.Add(Me.lblPreco)
        Me.Controls.Add(Me.lblProduto)
        Me.Controls.Add(Me.chkEtq)
        Me.Controls.Add(Me.chkPrc)
        Me.Controls.Add(Me.cmdConfirma)
        Me.Controls.Add(Me.cmdSair)
        Me.Controls.Add(Me.txtQtdEtq)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblOferta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.txtLastFocus)
        Me.Controls.Add(Me.lblQtdEtq)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Coleta"
        Me.Text = "Coleta de Itens"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.frmMsg.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtLastFocus As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblOferta As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtQtdEtq As System.Windows.Forms.TextBox
    Friend WithEvents lblQtdEtq As System.Windows.Forms.Label
    Friend WithEvents cmdSair As System.Windows.Forms.Button
    Friend WithEvents cmdConfirma As System.Windows.Forms.Button
    Friend WithEvents chkPrc As System.Windows.Forms.CheckBox
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents btnSim As System.Windows.Forms.Button
    Friend WithEvents btnNao As System.Windows.Forms.Button
    Friend WithEvents frmMsg As System.Windows.Forms.Panel
    Friend WithEvents chkEtq As System.Windows.Forms.CheckBox
    Friend WithEvents lblPreco As System.Windows.Forms.Label
    Friend WithEvents lblProduto As System.Windows.Forms.Label
    Friend WithEvents txtPreco As System.Windows.Forms.TextBox

End Class
