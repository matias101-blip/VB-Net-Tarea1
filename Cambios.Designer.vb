Imports System.Windows.Forms
Imports System.Drawing
Partial Class Cambios
    Inherits Form

    ' Etiquetas para los campos antiguos (antes de los cambios)
    Private WithEvents AfterNameLb As Label
    Private WithEvents AfterLastName As Label
    Private WithEvents AfterAge As Label

    ' Etiquetas para los campos nuevos (después de los cambios)
    Private WithEvents NewNameLb As Label
    Private WithEvents NewLastName As Label
    Private WithEvents NewAge As Label

    ' Cuadros de texto para los nuevos valores
    Private WithEvents NewNameTextBox As TextBox
    Private WithEvents NewLastNameTextBox As TextBox
    Private WithEvents NewAgeTextBox As TextBox

    ' Botón Aplicar
    Private WithEvents ApplyButton As Button

    ' Este método configura los controles
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.AfterNameLb = New Label()
        Me.AfterLastName = New Label()
        Me.AfterAge = New Label()

        Me.NewNameLb = New Label()
        Me.NewLastName = New Label()
        Me.NewAge = New Label()

        Me.NewNameTextBox = New TextBox()
        Me.NewLastNameTextBox = New TextBox()
        Me.NewAgeTextBox = New TextBox()

        Me.ApplyButton = New Button()

        ' 
        ' AfterNameLb
        ' 
        Me.AfterNameLb.Text = "Nombre actual: Juan"
        Me.AfterNameLb.Location = New Point(50, 30)
        Me.AfterNameLb.AutoSize = True

        ' 
        ' AfterLastName
        ' 
        Me.AfterLastName.Text = "Apellido actual: Pérez"
        Me.AfterLastName.Location = New Point(50, 70)
        Me.AfterLastName.AutoSize = True

        ' 
        ' AfterAge
        ' 
        Me.AfterAge.Text = "Edad actual: 30"
        Me.AfterAge.Location = New Point(50, 110)
        Me.AfterAge.AutoSize = True

        ' 
        ' NewNameLb
        ' 
        Me.NewNameLb.Text = "Nuevo Nombre:"
        Me.NewNameLb.Location = New Point(50, 150)
        Me.NewNameLb.AutoSize = True

        ' 
        ' NewLastName
        ' 
        Me.NewLastName.Text = "Nuevo Apellido:"
        Me.NewLastName.Location = New Point(50, 190)
        Me.NewLastName.AutoSize = True

        ' 
        ' NewAge
        ' 
        Me.NewAge.Text = "Nueva Edad:"
        Me.NewAge.Location = New Point(50, 230)
        Me.NewAge.AutoSize = True

        ' 
        ' NewNameTextBox
        ' 
        Me.NewNameTextBox.Location = New Point(150, 150)
        Me.NewNameTextBox.Width = 200

        ' 
        ' NewLastNameTextBox
        ' 
        Me.NewLastNameTextBox.Location = New Point(150, 190)
        Me.NewLastNameTextBox.Width = 200

        ' 
        ' NewAgeTextBox
        ' 
        Me.NewAgeTextBox.Location = New Point(150, 230)
        Me.NewAgeTextBox.Width = 200

        ' 
        ' ApplyButton
        ' 
        Me.ApplyButton.Text = "Aplicar"
        Me.ApplyButton.Size = New Size(75, 30)
        Me.ApplyButton.Location = New Point((Me.ClientSize.Width - Me.ApplyButton.Width) / 2, Me.ClientSize.Height - Me.ApplyButton.Height - 30) ' Centrado en la parte inferior

        ' 
        ' Cambios
        ' 
        Me.ClientSize = New Size(400, 300)
        Me.Controls.Add(Me.AfterNameLb)
        Me.Controls.Add(Me.AfterLastName)
        Me.Controls.Add(Me.AfterAge)
        Me.Controls.Add(Me.NewNameLb)
        Me.Controls.Add(Me.NewLastName)
        Me.Controls.Add(Me.NewAge)
        Me.Controls.Add(Me.NewNameTextBox)
        Me.Controls.Add(Me.NewLastNameTextBox)
        Me.Controls.Add(Me.NewAgeTextBox)
        Me.Controls.Add(Me.ApplyButton)
        Me.Name = "Cambios"
        Me.Text = "Formulario de Cambios"
    End Sub
End Class
