Imports System.Windows.Forms
Imports System.Drawing
Imports System.Collections.Generic ' Agregar esta línea

Public Class DespidosForm
    Inherits Form

    ' Lista de nombres para los empleados
    Private empleados As String() = {"Juan Pérez", "Ana Gómez", "Carlos Díaz", "Laura Martínez", "Pedro Sánchez"}
    
    ' Lista para los CheckBox generados dinámicamente
    Private checkboxes As New List(Of CheckBox)
    
    ' Botón de despedir
    Private despedirButton As Button

    Public Sub New()
        ' Configuración del formulario
        Text = "Formulario de Despidos"
        Width = 400
        Height = 300
        
        ' Generar los CheckBoxes
        For i As Integer = 0 To empleados.Length - 1
            Dim checkBox As New CheckBox()
            checkBox.Text = empleados(i)
            checkBox.Location = New Point(50, 50 + (i * 30)) ' Posición dinámica
            checkBox.AutoSize = True
            Controls.Add(checkBox)
            checkboxes.Add(checkBox)
        Next

        ' Crear el botón "Despedir"
        despedirButton = New Button()
        despedirButton.Text = "Despedir"
        despedirButton.Size = New Size(75, 30)
        despedirButton.Location = New Point((Me.ClientSize.Width - despedirButton.Width) / 2, Me.ClientSize.Height - despedirButton.Height - 30) ' Centrado en la parte inferior
        AddHandler despedirButton.Click, AddressOf Me.DespedirButton_Click
        Controls.Add(despedirButton)
    End Sub

    ' Evento que se ejecuta al hacer clic en el botón "Despedir"
    Private Sub DespedirButton_Click(sender As Object, e As EventArgs)
        Dim despedidos As New List(Of String)

        ' Verificar cuáles CheckBoxes están seleccionados
        For Each checkBox As CheckBox In checkboxes
            If checkBox.Checked Then
                despedidos.Add(checkBox.Text)
            End If
        Next

        ' Mostrar los empleados despedidos
        If despedidos.Count > 0 Then
            MessageBox.Show("Los siguientes empleados han sido despedidos: " & String.Join(", ", despedidos))
            Me.Close()
        Else
            MessageBox.Show("No se ha seleccionado ningún empleado para despedir.")
        End If
    End Sub
End Class
