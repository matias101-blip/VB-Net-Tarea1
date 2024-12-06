Imports System.Windows.Forms
Imports System.Drawing

Public Partial Class Cambios
    Inherits Form

    Public Sub New()
        InitializeComponent()
    End Sub

    ' Evento cuando se hace clic en el botón "Aplicar"
    Private Sub ApplyButton_Click(sender As Object, e As EventArgs)
        ' Verificar si los campos nuevos están vacíos
        If String.IsNullOrEmpty(NewNameTextBox.Text) OrElse String.IsNullOrEmpty(NewLastNameTextBox.Text) OrElse String.IsNullOrEmpty(NewAgeTextBox.Text) Then
            MessageBox.Show("Por favor, complete todos los campos.")
            Return
        End If

        ' Aquí podrías agregar la lógica para aplicar los cambios, por ejemplo, actualizar un archivo XML o base de datos
        MessageBox.Show("Los cambios se han aplicado correctamente.")
        Me.Close() ' Cierra el formulario después de aplicar los cambios
    End Sub
End Class
