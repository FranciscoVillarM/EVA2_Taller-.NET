<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        LblRut = New Label()
        LblNombres = New Label()
        LblApellidos = New Label()
        LblSexo = New Label()
        RadioBtnMasculino = New RadioButton()
        RadioBtnFemenino = New RadioButton()
        RadioBtnIndefinido = New RadioButton()
        ComboBoxComunas = New ComboBox()
        LblComuna = New Label()
        LblCiudad = New Label()
        Label1 = New Label()
        TxtRut = New TextBox()
        TxtNombres = New TextBox()
        TxtApellidos = New TextBox()
        TxtCiudad = New TextBox()
        TxtObservacion = New TextBox()
        BtnBuscar = New Button()
        BtnGuardar = New Button()
        BtnVerDatosBD = New Button()
        LblEjemploRut = New Label()
        BtnEliminar = New Button()
        BtnActualizar = New Button()
        SuspendLayout()
        ' 
        ' LblRut
        ' 
        LblRut.AutoSize = True
        LblRut.Location = New Point(22, 46)
        LblRut.Name = "LblRut"
        LblRut.Size = New Size(39, 20)
        LblRut.TabIndex = 0
        LblRut.Text = "RUT:"
        ' 
        ' LblNombres
        ' 
        LblNombres.AutoSize = True
        LblNombres.Location = New Point(22, 91)
        LblNombres.Name = "LblNombres"
        LblNombres.Size = New Size(73, 20)
        LblNombres.TabIndex = 1
        LblNombres.Text = "Nombres:"
        ' 
        ' LblApellidos
        ' 
        LblApellidos.AutoSize = True
        LblApellidos.Location = New Point(22, 133)
        LblApellidos.Name = "LblApellidos"
        LblApellidos.Size = New Size(75, 20)
        LblApellidos.TabIndex = 2
        LblApellidos.Text = "Apellidos:"
        ' 
        ' LblSexo
        ' 
        LblSexo.AutoSize = True
        LblSexo.Location = New Point(22, 181)
        LblSexo.Name = "LblSexo"
        LblSexo.Size = New Size(426, 20)
        LblSexo.TabIndex = 3
        LblSexo.Text = "Sexo: ---------------------------------------------------------------"
        ' 
        ' RadioBtnMasculino
        ' 
        RadioBtnMasculino.AutoSize = True
        RadioBtnMasculino.Location = New Point(30, 220)
        RadioBtnMasculino.Name = "RadioBtnMasculino"
        RadioBtnMasculino.Size = New Size(94, 24)
        RadioBtnMasculino.TabIndex = 4
        RadioBtnMasculino.TabStop = True
        RadioBtnMasculino.Text = "Masculino"
        RadioBtnMasculino.UseVisualStyleBackColor = True
        ' 
        ' RadioBtnFemenino
        ' 
        RadioBtnFemenino.AutoSize = True
        RadioBtnFemenino.Location = New Point(182, 220)
        RadioBtnFemenino.Name = "RadioBtnFemenino"
        RadioBtnFemenino.Size = New Size(92, 24)
        RadioBtnFemenino.TabIndex = 5
        RadioBtnFemenino.TabStop = True
        RadioBtnFemenino.Text = "Femenino"
        RadioBtnFemenino.UseVisualStyleBackColor = True
        ' 
        ' RadioBtnIndefinido
        ' 
        RadioBtnIndefinido.AutoSize = True
        RadioBtnIndefinido.Location = New Point(352, 220)
        RadioBtnIndefinido.Name = "RadioBtnIndefinido"
        RadioBtnIndefinido.Size = New Size(95, 24)
        RadioBtnIndefinido.TabIndex = 6
        RadioBtnIndefinido.TabStop = True
        RadioBtnIndefinido.Text = "Indefinido"
        RadioBtnIndefinido.UseVisualStyleBackColor = True
        ' 
        ' ComboBoxComunas
        ' 
        ComboBoxComunas.FormattingEnabled = True
        ComboBoxComunas.Location = New Point(122, 284)
        ComboBoxComunas.Name = "ComboBoxComunas"
        ComboBoxComunas.Size = New Size(325, 27)
        ComboBoxComunas.TabIndex = 7
        ComboBoxComunas.Text = "(Seleccione una comuna)"
        ' 
        ' LblComuna
        ' 
        LblComuna.AutoSize = True
        LblComuna.Location = New Point(22, 287)
        LblComuna.Name = "LblComuna"
        LblComuna.Size = New Size(67, 20)
        LblComuna.TabIndex = 8
        LblComuna.Text = "Comuna:"
        ' 
        ' LblCiudad
        ' 
        LblCiudad.AutoSize = True
        LblCiudad.Location = New Point(22, 363)
        LblCiudad.Name = "LblCiudad"
        LblCiudad.Size = New Size(59, 20)
        LblCiudad.TabIndex = 9
        LblCiudad.Text = "Ciudad:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(22, 434)
        Label1.Name = "Label1"
        Label1.Size = New Size(94, 20)
        Label1.TabIndex = 10
        Label1.Text = "Observacion:"
        ' 
        ' TxtRut
        ' 
        TxtRut.Location = New Point(67, 40)
        TxtRut.Name = "TxtRut"
        TxtRut.Size = New Size(232, 26)
        TxtRut.TabIndex = 11
        ' 
        ' TxtNombres
        ' 
        TxtNombres.Location = New Point(122, 85)
        TxtNombres.Name = "TxtNombres"
        TxtNombres.Size = New Size(325, 26)
        TxtNombres.TabIndex = 12
        ' 
        ' TxtApellidos
        ' 
        TxtApellidos.Location = New Point(122, 127)
        TxtApellidos.Name = "TxtApellidos"
        TxtApellidos.Size = New Size(325, 26)
        TxtApellidos.TabIndex = 13
        ' 
        ' TxtCiudad
        ' 
        TxtCiudad.Location = New Point(122, 357)
        TxtCiudad.Name = "TxtCiudad"
        TxtCiudad.Size = New Size(325, 26)
        TxtCiudad.TabIndex = 14
        ' 
        ' TxtObservacion
        ' 
        TxtObservacion.Location = New Point(122, 431)
        TxtObservacion.Name = "TxtObservacion"
        TxtObservacion.Size = New Size(325, 26)
        TxtObservacion.TabIndex = 15
        ' 
        ' BtnBuscar
        ' 
        BtnBuscar.BackColor = SystemColors.ScrollBar
        BtnBuscar.Location = New Point(319, 32)
        BtnBuscar.Name = "BtnBuscar"
        BtnBuscar.Size = New Size(128, 41)
        BtnBuscar.TabIndex = 16
        BtnBuscar.Text = "Buscar"
        BtnBuscar.UseVisualStyleBackColor = False
        ' 
        ' BtnGuardar
        ' 
        BtnGuardar.BackColor = SystemColors.ScrollBar
        BtnGuardar.Location = New Point(22, 476)
        BtnGuardar.Name = "BtnGuardar"
        BtnGuardar.Size = New Size(154, 48)
        BtnGuardar.TabIndex = 17
        BtnGuardar.Text = "Guardar MySql"
        BtnGuardar.UseVisualStyleBackColor = False
        ' 
        ' BtnVerDatosBD
        ' 
        BtnVerDatosBD.BackColor = SystemColors.ScrollBar
        BtnVerDatosBD.Location = New Point(293, 541)
        BtnVerDatosBD.Name = "BtnVerDatosBD"
        BtnVerDatosBD.Size = New Size(154, 48)
        BtnVerDatosBD.TabIndex = 20
        BtnVerDatosBD.Text = "Ver datos BD"
        BtnVerDatosBD.UseVisualStyleBackColor = False
        ' 
        ' LblEjemploRut
        ' 
        LblEjemploRut.AutoSize = True
        LblEjemploRut.Location = New Point(67, 9)
        LblEjemploRut.Name = "LblEjemploRut"
        LblEjemploRut.Size = New Size(149, 20)
        LblEjemploRut.TabIndex = 21
        LblEjemploRut.Text = "Ejemplo: 16912321-2"
        ' 
        ' BtnEliminar
        ' 
        BtnEliminar.BackColor = SystemColors.ScrollBar
        BtnEliminar.Location = New Point(22, 541)
        BtnEliminar.Name = "BtnEliminar"
        BtnEliminar.Size = New Size(154, 48)
        BtnEliminar.TabIndex = 22
        BtnEliminar.Text = "Eliminar"
        BtnEliminar.UseVisualStyleBackColor = False
        ' 
        ' BtnActualizar
        ' 
        BtnActualizar.BackColor = SystemColors.ScrollBar
        BtnActualizar.Location = New Point(293, 476)
        BtnActualizar.Name = "BtnActualizar"
        BtnActualizar.Size = New Size(154, 48)
        BtnActualizar.TabIndex = 23
        BtnActualizar.Text = "Actualizar"
        BtnActualizar.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(490, 617)
        Controls.Add(BtnActualizar)
        Controls.Add(BtnEliminar)
        Controls.Add(LblEjemploRut)
        Controls.Add(BtnVerDatosBD)
        Controls.Add(BtnGuardar)
        Controls.Add(BtnBuscar)
        Controls.Add(TxtObservacion)
        Controls.Add(TxtCiudad)
        Controls.Add(TxtApellidos)
        Controls.Add(TxtNombres)
        Controls.Add(TxtRut)
        Controls.Add(Label1)
        Controls.Add(LblCiudad)
        Controls.Add(LblComuna)
        Controls.Add(ComboBoxComunas)
        Controls.Add(RadioBtnIndefinido)
        Controls.Add(RadioBtnFemenino)
        Controls.Add(RadioBtnMasculino)
        Controls.Add(LblSexo)
        Controls.Add(LblApellidos)
        Controls.Add(LblNombres)
        Controls.Add(LblRut)
        Name = "Form1"
        Text = "EVA2_FranciscoVillar"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LblRut As Label
    Friend WithEvents LblNombres As Label
    Friend WithEvents LblApellidos As Label
    Friend WithEvents LblSexo As Label
    Friend WithEvents RadioBtnMasculino As RadioButton
    Friend WithEvents RadioBtnFemenino As RadioButton
    Friend WithEvents RadioBtnIndefinido As RadioButton
    Friend WithEvents ComboBoxComunas As ComboBox
    Friend WithEvents LblComuna As Label
    Friend WithEvents LblCiudad As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtRut As TextBox
    Friend WithEvents TxtNombres As TextBox
    Friend WithEvents TxtApellidos As TextBox
    Friend WithEvents TxtCiudad As TextBox
    Friend WithEvents TxtObservacion As TextBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnVerDatosBD As Button
    Friend WithEvents LblEjemploRut As Label
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnActualizar As Button

End Class
