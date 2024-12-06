Imports System.Windows.Forms
Imports System.Drawing

Public Class Register
    Inherits Form

    ' Definimos los Labels y los TextBoxes
    Private NameLb As Label
    Private LastNameLb As Label
    Private AgeLb As Label
    Private NameTextBox As TextBox
    Private LastNameTextBox As TextBox
    Private AgeTextBox As TextBox
    Private DoneButton As Button

    Public Sub New()
        ' Configuración del formulario
        Text = "Formulario de Registro"
        Width = 400
        Height = 300

        ' Crear el Label para el nombre
        NameLb = New Label()
        NameLb.Text = "Nombre:"
        NameLb.Location = New Point(50, 50)
        NameLb.AutoSize = True
        Controls.Add(NameLb)

        ' Crear el TextBox para el nombre
        NameTextBox = New TextBox()
        NameTextBox.Location = New Point(150, 50)
        NameTextBox.Width = 200
        Controls.Add(NameTextBox)

        ' Crear el Label para el apellido
        LastNameLb = New Label()
        LastNameLb.Text = "Apellido:"
        LastNameLb.Location = New Point(50, 100)
        LastNameLb.AutoSize = True
        Controls.Add(LastNameLb)

        ' Crear el TextBox para el apellido
        LastNameTextBox = New TextBox()
        LastNameTextBox.Location = New Point(150, 100)
        LastNameTextBox.Width = 200
        Controls.Add(LastNameTextBox)

        ' Crear el Label para la edad
        AgeLb = New Label()
        AgeLb.Text = "Edad:"
        AgeLb.Location = New Point(50, 150)
        AgeLb.AutoSize = True
        Controls.Add(AgeLb)

        ' Crear el TextBox para la edad
        AgeTextBox = New TextBox()
        AgeTextBox.Location = New Point(150, 150)
        AgeTextBox.Width = 200
        Controls.Add(AgeTextBox)

        ' Crear el botón "Hecho"
        DoneButton = New Button()
        DoneButton.Text = "Hecho"
        DoneButton.Size = New Size(75, 30)
        DoneButton.Location = New Point((Me.ClientSize.Width - DoneButton.Width) / 2, Me.ClientSize.Height - DoneButton.Height - 30) ' Centrado en la parte inferior
        AddHandler DoneButton.Click, AddressOf Me.DoneButton_Click
        Controls.Add(DoneButton)
    End Sub

    ' Evento que cierra el formulario cuando se hace clic en "Hecho"
    Private Sub DoneButton_Click(sender As Object, e As EventArgs)
        ' Aquí podrías agregar alguna validación o lógica con los datos ingresados
        MessageBox.Show("Registro completado.")
        Me.Close()
    End Sub

End Class