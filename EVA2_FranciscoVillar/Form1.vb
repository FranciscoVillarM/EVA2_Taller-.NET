Imports MySql.Data.MySqlClient


Public Class Form1
    'Conexión MySQL
    Dim connectionString As String = "Server=localhost;Database=registropersonas;User ID='root';Password='';"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Llenar el ComboBox con comunas desde la base de datos
        CargarComunAs()
    End Sub

    Private Sub CargarComunAs()
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim sql As String = "SELECT NombreComuna FROM comuna"

                Using cmd As New MySqlCommand(sql, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        ComboBoxComunas.Items.Clear() ' Limpia items existentes
                        While reader.Read()
                            ComboBoxComunas.Items.Add(reader("NombreComuna").ToString())
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al cargar las comunas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim rut = TxtRut.Text
        Dim nombre = TxtNombres.Text
        Dim apellido = TxtApellidos.Text
        Dim sexo As String


        If RadioBtnMasculino.Checked Then
            sexo = "Masculino"
        ElseIf RadioBtnFemenino.Checked Then
            sexo = "Femenino"
        ElseIf RadioBtnIndefinido.Checked Then
            sexo = "Indefinido"
        Else
            MessageBox.Show("Por favor, seleccione el sexo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Obtener otros campos
        Dim comuna = ComboBoxComunas.SelectedItem?.ToString
        Dim ciudad = TxtCiudad.Text
        Dim observacion = TxtObservacion.Text

        ' Validar campos obligatorios
        If String.IsNullOrWhiteSpace(rut) Or String.IsNullOrWhiteSpace(nombre) Or String.IsNullOrWhiteSpace(apellido) Or String.IsNullOrWhiteSpace(comuna) Then
            MessageBox.Show("Por favor, complete todos los campos obligatorios (RUT, Nombre, Apellido y Comuna).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Guardar los datos en la base de datos
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()

                Dim sql = "INSERT INTO personas (RUT, Nombre, Apellido, Sexo, Comuna, Ciudad, Observacion) " &
                                "VALUES (@rut, @nombre, @apellido, @sexo, @comuna, @ciudad, @observacion)"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@rut", rut)
                    cmd.Parameters.AddWithValue("@nombre", nombre)
                    cmd.Parameters.AddWithValue("@apellido", apellido)
                    cmd.Parameters.AddWithValue("@sexo", sexo)
                    cmd.Parameters.AddWithValue("@comuna", comuna)
                    cmd.Parameters.AddWithValue("@ciudad", ciudad)
                    cmd.Parameters.AddWithValue("@observacion", observacion)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Datos guardados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Limpia el formulario después de guardar
                    LimpiarFormulario()
                End Using

            Catch ex As Exception
                MessageBox.Show("Error al guardar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Método para limpiar el formulario
    Private Sub LimpiarFormulario()
        TxtRut.Clear()
        TxtNombres.Clear()
        TxtApellidos.Clear()
        TxtCiudad.Clear()
        TxtObservacion.Clear()
        RadioBtnMasculino.Checked = False
        RadioBtnFemenino.Checked = False
        RadioBtnIndefinido.Checked = False
        ComboBoxComunas.SelectedIndex = -1
        TxtRut.Focus() ' Coloca el cursor en el campo "RUT"
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim rut As String = TxtRut.Text

        ' Validar que el campo RUT no esté vacío
        If String.IsNullOrWhiteSpace(rut) Then
            MessageBox.Show("Por favor, ingrese el RUT.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Buscar el registro en la base de datos por RUT
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()

                Dim sql As String = "SELECT * FROM personas WHERE RUT = @rut"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@rut", rut)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Si se encuentra el registro, rellenar los campos
                            TxtNombres.Text = reader("Nombre").ToString()
                            TxtApellidos.Text = reader("Apellido").ToString()
                            Dim sexo As String = reader("Sexo").ToString()

                            ' Seleccionar el radio button según el valor del sexo
                            Select Case sexo
                                Case "Masculino"
                                    RadioBtnMasculino.Checked = True
                                Case "Femenino"
                                    RadioBtnFemenino.Checked = True
                                Case "Indefinido"
                                    RadioBtnIndefinido.Checked = True
                            End Select

                            ComboBoxComunas.SelectedItem = reader("Comuna").ToString()
                            TxtCiudad.Text = reader("Ciudad").ToString()
                            TxtObservacion.Text = reader("Observacion").ToString()

                            MessageBox.Show("Registro encontrado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("No se encontró el registro con el RUT ingresado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                            ' Limpiar el formulario si no se encuentra el registro
                            LimpiarFormulario()

                            ' Habilita todos los campos exepto el de búsqueda
                            TxtNombres.Enabled = True
                            TxtApellidos.Enabled = True
                            RadioBtnMasculino.Enabled = True
                            RadioBtnFemenino.Enabled = True
                            RadioBtnIndefinido.Enabled = True
                            ComboBoxComunas.Enabled = True
                            TxtCiudad.Enabled = True
                            TxtObservacion.Enabled = True

                            ' Habilita botón Guardar
                            BtnGuardar.Enabled = True

                            ' Deshabilita el botón de búsquedaa
                            BtnBuscar.Enabled = True
                        End If
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("Error al buscar el registro: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        ' Validar que se hayan cargado los datos del usuario
        If String.IsNullOrWhiteSpace(TxtRut.Text) Then
            MessageBox.Show("Por favor, busque un usuario antes de actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Obtener los nuevos datos del formulario
        Dim nombre = TxtNombres.Text
        Dim apellido = TxtApellidos.Text
        ' ... (obtener otros campos)

        ' Actualizar los datos en la base de datos
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()

                Dim sql = "UPDATE personas SET Nombre = @nombre, Apellido = @apellido, " &
                          "Sexo = @sexo, Comuna = @comuna, Ciudad = @ciudad, Observacion = @observacion " &
                          "WHERE RUT = @rut"

                Using cmd As New MySqlCommand(sql, conn)
                    ' ... (asignar parámetros)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Datos actualizados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al actualizar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End Using
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        ' Validar que se hayan cargado los datos del usuario
        If String.IsNullOrWhiteSpace(TxtRut.Text) Then
            MessageBox.Show("Por favor, busque un usuario antes de eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show("¿Está seguro que desea eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Using conn As New MySqlConnection(connectionString)
                Try
                    conn.Open()

                    Dim sql = "DELETE FROM personas WHERE RUT = @rut"
                    Using cmd As New MySqlCommand(sql, conn)
                        cmd.Parameters.AddWithValue("@rut", TxtRut.Text)
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Registro eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LimpiarFormulario()
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error al eliminar el registro: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            End Using
        End If
    End Sub

    Private Sub BtnVerDatosBD_Click(sender As Object, e As EventArgs) Handles BtnVerDatosBD.Click
        Dim todosLosUsuarios As String = ""

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()

                Dim sql = "SELECT RUT, Nombre, Apellido FROM personas"
                Using cmd As New MySqlCommand(sql, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            todosLosUsuarios &= $"RUT: {reader("RUT")}, Nombre: {reader("Nombre")}, Apellido: {reader("Apellido")} {Environment.NewLine}"
                        End While
                    End Using
                End Using

                If todosLosUsuarios = "" Then
                    MessageBox.Show("No hay usuarios registrados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show(todosLosUsuarios, "Todos los Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show("Error al obtener los datos de los usuarios: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
End Class