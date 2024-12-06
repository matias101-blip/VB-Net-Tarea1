Imports System.Windows.Forms
Imports System.Drawing

Public Class Main
    Inherits Form

    Private Msj As Label
    Private menuStrip As MenuStrip
    
    Private Formularios As ToolStripMenuItem
    Private OpRegistro As ToolStripMenuItem
    Private OpCambios As ToolStripMenuItem
    Private OpDespidos As ToolStripMenuItem

    Private Formularios2 As ToolStripMenuItem
    Private OpMuestra As ToolStripMenuItem
    Private OpBuscar As ToolStripMenuItem
    Private OpEliminar As ToolStripMenuItem

    Public Sub New()
        Text = "Video Club"
        Width = 500
        Height = 400

        Msj = New Label()

        menuStrip = New MenuStrip()

        Formularios = New ToolStripMenuItem("Usuarios")
        Formularios2 = New ToolStripMenuItem("Ver")

        OpRegistro = New ToolStripMenuItem("Registro")
        AddHandler OpRegistro.Click,AddressOf Registrar
        OpCambios = New ToolStripMenuItem("Cambios")
        AddHandler OpCambios.Click, AddressOf Cambiar
        OpDespidos = New ToolStripMenuItem("Despidos")
        AddHandler OpDespidos.Click, AddressOf Despedir

        OpMuestra = New ToolStripMenuItem("Mostrar")
        OpBuscar = New ToolStripMenuItem("Buscar")
        OpEliminar = New ToolStripMenuItem("Eliminar")

        Formularios.DropDownItems.Add(OpRegistro)
        Formularios.DropDownItems.Add(OpCambios)
        Formularios.DropDownItems.Add(OpDespidos)

        Formularios2.DropDownItems.Add(OpMuestra)
        Formularios2.DropDownItems.Add(OpBuscar)
        Formularios2.DropDownItems.Add(OpEliminar)

        Msj.Text = "Sistema de Usuarios"
        Msj.AutoSize = True
        Msj.TextAlign = Drawing.ContentAlignment.MiddleCenter
        Msj.Left = (Me.ClientSize.Width - Msj.Width) / 2.5
        Msj.Top = (Me.ClientSize.Height - Msj.Height) / 2.5

        Msj.Font = New Font("arial",15,FontStyle.Bold)

        menuStrip.Items.Add(Formularios)
        menuStrip.Items.Add(Formularios2)

        ' Agregar el MenuStrip al formulario
        MainMenuStrip = menuStrip
        Controls.Add(menuStrip)
        Controls.Add(Msj)
    End Sub

    Private Sub Registrar(sender As Object, e as EventArgs)
        Dim Register As New Register()
        Register.Show()
    End Sub

    Private Sub Cambiar(sender As Object, e as EventArgs)
        Dim Cambios As New Cambios()
        Cambios.Show()
    End Sub

    Private Sub Despedir(sender As Object, e as EventArgs)
        Dim Despidos As New DespidosForm()
        Despidos.Show()
    End Sub
End Class

Module Program
    Sub Main()
        Application.Run(New Main())
    End Sub
End Module
