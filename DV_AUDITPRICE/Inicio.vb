Imports System.Runtime.InteropServices
Imports System
Imports System.IO
Imports System.Text
Imports System.InvalidCastException
Imports System.InvalidOperationException
Imports System.InvalidProgramException
Imports System.NotSupportedException
Imports System.Diagnostics
Imports System.Reflection
Imports System.Windows.Forms.ListBox
Imports System.Math 'para função round
Imports System.Resources
Imports System.Collections
Imports System.IO.Directory
Imports System.IO.File
Imports System.Windows.Forms
Public Class frmInicio

    <StructLayout(LayoutKind.Sequential)> _
Private Structure SYSTEMTIME
        <MarshalAs(UnmanagedType.U2)> Public Year As Short
        <MarshalAs(UnmanagedType.U2)> Public Month As Short
        <MarshalAs(UnmanagedType.U2)> Public DayOfWeek As Short
        <MarshalAs(UnmanagedType.U2)> Public Day As Short
        <MarshalAs(UnmanagedType.U2)> Public Hour As Short
        <MarshalAs(UnmanagedType.U2)> Public Minute As Short
        <MarshalAs(UnmanagedType.U2)> Public Second As Short
        <MarshalAs(UnmanagedType.U2)> Public Milliseconds As Short
    End Structure

    <DllImport("coredll.dll")> _
Private Shared Sub GetLocalTime(ByRef time As SYSTEMTIME)
    End Sub

    <DllImport("coredll.dll")> _
    Private Shared Function SetLocalTime(ByRef time As SYSTEMTIME) As Boolean
    End Function


    Private Sub frmInicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Preenche combo Hora
        Dim h, m, ha, ma As Integer
        Dim hora, min As String

        btnHabilitar.Enabled = True

        'preenche date picker
        Try
            dtCalendario.Value = System.DateTime.Now.ToString("dd/MM/yyyy")
        Catch ex As Exception
            dtCalendario.Value = System.DateTime.Now.ToString("yyyy/MM/dd")
        End Try

        For h = 1 To 24
            ha = System.DateTime.Now.ToString("HH")

            If h < 10 Then
                hora = "0" & h
            Else
                hora = h
            End If
            cmbHora.Items.Add(hora)

            If ha = h Then
                If h < 10 Then
                    hora = "0" & h
                Else
                    hora = h
                End If
                cmbHora.SelectedItem = hora
            End If
        Next

        'Preenche combo Minuto
        For m = 0 To 59
            ma = System.DateTime.Now.ToString("mm")
            If m < 10 Then
                min = "0" & m
            Else
                min = m
            End If
            cmbMinuto.Items.Add(min)

            If ma = m Then
                If m < 10 Then
                    min = "0" & m
                Else
                    min = m
                End If
                cmbMinuto.SelectedItem = min
            End If

        Next

    End Sub

    Private Sub btnInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInicio.Click
        Dim currentTime As SYSTEMTIME

        If btnHabilitar.Enabled = False Then

            GetLocalTime(currentTime)

            currentTime.Year = Format(dtCalendario.Value, "yyyy")
            currentTime.Month = Format(dtCalendario.Value, "MM")
            currentTime.Day = Format(dtCalendario.Value, "dd")
            currentTime.Hour = CInt(cmbHora.Text)
            currentTime.Minute = CInt(cmbMinuto.Text)

            SetLocalTime(currentTime)

        End If

        frmAuditorias.Show()

    End Sub

    Private Sub btnHabilitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHabilitar.Click

        btnHabilitar.Enabled = False
        dtCalendario.Enabled = True
        cmbHora.Enabled = True
        cmbMinuto.Enabled = True
        dtCalendario.Focus()

    End Sub

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

End Class