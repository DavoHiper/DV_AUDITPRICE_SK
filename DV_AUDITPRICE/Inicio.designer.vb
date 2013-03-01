<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmInicio
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
        Me.lblSeparador = New System.Windows.Forms.Label
        Me.cmbMinuto = New System.Windows.Forms.ComboBox
        Me.cmbHora = New System.Windows.Forms.ComboBox
        Me.lblHorario = New System.Windows.Forms.Label
        Me.lblData = New System.Windows.Forms.Label
        Me.dtCalendario = New System.Windows.Forms.DateTimePicker
        Me.btnHabilitar = New System.Windows.Forms.Button
        Me.btnInicio = New System.Windows.Forms.Button
        Me.btnFechar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblSeparador
        '
        Me.lblSeparador.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular)
        Me.lblSeparador.Location = New System.Drawing.Point(82, 123)
        Me.lblSeparador.Name = "lblSeparador"
        Me.lblSeparador.Size = New System.Drawing.Size(10, 20)
        Me.lblSeparador.Text = ":"
        '
        'cmbMinuto
        '
        Me.cmbMinuto.Enabled = False
        Me.cmbMinuto.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.cmbMinuto.Location = New System.Drawing.Point(98, 120)
        Me.cmbMinuto.Name = "cmbMinuto"
        Me.cmbMinuto.Size = New System.Drawing.Size(57, 32)
        Me.cmbMinuto.TabIndex = 3
        '
        'cmbHora
        '
        Me.cmbHora.Enabled = False
        Me.cmbHora.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.cmbHora.Location = New System.Drawing.Point(19, 120)
        Me.cmbHora.Name = "cmbHora"
        Me.cmbHora.Size = New System.Drawing.Size(57, 32)
        Me.cmbHora.TabIndex = 2
        '
        'lblHorario
        '
        Me.lblHorario.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular)
        Me.lblHorario.Location = New System.Drawing.Point(19, 96)
        Me.lblHorario.Name = "lblHorario"
        Me.lblHorario.Size = New System.Drawing.Size(202, 20)
        Me.lblHorario.Text = "Hora:"
        '
        'lblData
        '
        Me.lblData.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular)
        Me.lblData.Location = New System.Drawing.Point(19, 40)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(191, 20)
        Me.lblData.Text = "Data:"
        '
        'dtCalendario
        '
        Me.dtCalendario.CalendarFont = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.dtCalendario.CustomFormat = "dd / MM / yyyy"
        Me.dtCalendario.Enabled = False
        Me.dtCalendario.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular)
        Me.dtCalendario.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtCalendario.Location = New System.Drawing.Point(19, 63)
        Me.dtCalendario.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.dtCalendario.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtCalendario.Name = "dtCalendario"
        Me.dtCalendario.Size = New System.Drawing.Size(202, 30)
        Me.dtCalendario.TabIndex = 1
        Me.dtCalendario.Value = New Date(2011, 11, 8, 16, 45, 2, 0)
        '
        'btnHabilitar
        '
        Me.btnHabilitar.Location = New System.Drawing.Point(162, 128)
        Me.btnHabilitar.Name = "btnHabilitar"
        Me.btnHabilitar.Size = New System.Drawing.Size(59, 23)
        Me.btnHabilitar.TabIndex = 11
        Me.btnHabilitar.Text = "Alterar"
        '
        'btnInicio
        '
        Me.btnInicio.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.btnInicio.Location = New System.Drawing.Point(19, 198)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(202, 41)
        Me.btnInicio.TabIndex = 5
        Me.btnInicio.Text = "Iniciar Auditoria"
        '
        'btnFechar
        '
        Me.btnFechar.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular)
        Me.btnFechar.Location = New System.Drawing.Point(19, 242)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(202, 26)
        Me.btnFechar.TabIndex = 6
        Me.btnFechar.Text = "Fechar"
        '
        'frmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(640, 480)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnHabilitar)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnInicio)
        Me.Controls.Add(Me.lblSeparador)
        Me.Controls.Add(Me.cmbMinuto)
        Me.Controls.Add(Me.cmbHora)
        Me.Controls.Add(Me.lblHorario)
        Me.Controls.Add(Me.lblData)
        Me.Controls.Add(Me.dtCalendario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInicio"
        Me.Text = "Inicio"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblSeparador As System.Windows.Forms.Label
    Friend WithEvents cmbMinuto As System.Windows.Forms.ComboBox
    Friend WithEvents cmbHora As System.Windows.Forms.ComboBox
    Friend WithEvents lblHorario As System.Windows.Forms.Label
    Friend WithEvents lblData As System.Windows.Forms.Label
    Friend WithEvents dtCalendario As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnHabilitar As System.Windows.Forms.Button
    Friend WithEvents btnInicio As System.Windows.Forms.Button
    Friend WithEvents btnFechar As System.Windows.Forms.Button
End Class
