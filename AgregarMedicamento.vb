Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.IO
Public Class AgregarMedicamento
    Dim cmd As MySqlCommand
    Dim conexion As MySqlConnection = New MySqlConnection
    Dim comando As MySqlCommand = New MySqlCommand
    Dim adaptador As New MySqlDataAdapter
    Dim datos As DataSet
    Dim aux As Integer
    Dim filename As String
    Private Sub AgregarMedicamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If module1.editar = False Then
            PictureBox6.Visible = False
        Else
            PictureBox6.Visible = True
            recuperardatos()
        End If
        conexion.Close()
        Label1.Parent = PictureBox1
        Label1.BackColor = Color.Transparent
        comando.Connection = conexion
        Try
            conexion.ConnectionString = "Server = localhost; Database = farmaciasberny; Uid = root; Password = dfr4902"
            conexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim query As String = "SELECT * FROM Medicamentos"
        Dim adpt As New MySqlDataAdapter(query, conexion)
        Dim ds As New DataSet()
        adpt.Fill(ds)
        GridMedicamentos.DataSource = ds.Tables(0)
        aux = GridMedicamentos.Rows.Count

        txtcodigo.Focus()

    End Sub

    Public Sub recuperardatos()
        conexion.Close()
        comando.Connection = conexion
        Try
            conexion.ConnectionString = "Server = localhost; Database = farmaciasberny; Uid = root; Password = dfr4902"
            conexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        txtcodigo.Text = module1.codigo
        txtcost.Text = module1.costo
        txtdes.Text = module1.descrip
        txtnom.Text = module1.nombre_medi
        PictureBox2.Image = Bytes_Imagen(module1.imagen)
        Dim consulta As String
        Dim lista As Byte
        consulta = "SELECT * FROM Medicamentos WHERE Codigo='" & txtcodigo.Text & "'"
        adaptador = New MySqlDataAdapter(consulta, conexion)
        datos = New DataSet
        adaptador.Fill(datos, "Medicamentos")
        lista = datos.Tables("Medicamentos").Rows.Count

        If lista <> 0 Then
            auxcodigo.Text = datos.Tables("Medicamentos").Rows(0).Item("id")
        End If

    End Sub

    Private Function Bytes_Imagen(ByVal Imagen As Byte()) As Image
        Try
            'si hay imagen
            If Not Imagen Is Nothing Then
                'caturar array con memorystream hacia Bin
                Dim Bin As New MemoryStream(Imagen)
                'con el método FroStream de Image obtenemos imagen
                Dim Resultado As Image = Image.FromStream(Bin)
                'y la retornamos
                Return Resultado
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

        Dim openfiler As New OpenFileDialog
        'Definiendo propiedades al openfiledialog
        With openfiler
            'directorio inicial
            .InitialDirectory = "C:\"
            'indice del archivo de lectura por defecto
            .FilterIndex = 1
            'restaurar el directorio al cerrar el dialogo
            .RestoreDirectory = True
        End With
        '
        'Evalua si el usuario hace click en el boton abrir
        If openfiler.ShowDialog = Windows.Forms.DialogResult.OK Then
            'Obteniendo la ruta completa del archivo xml
            filename = openfiler.FileName
            PictureBox2.Image = Image.FromFile(filename)

        End If
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If module1.editar = False Then
            conexion.Close()
            comando.Connection = conexion
            Dim imag As Byte()

            Try
                conexion.ConnectionString = "Server = localhost; Database = farmaciasberny; Uid = root; Password = dfr4902"
                conexion.Open()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try



            Try
                If txtnom.Text = "" Or txtdes.Text = "" Or txtcost.Text = "" Then
                    MsgBox("Favor De Rellenar Todos Los Campos")
                Else
                    If IsNumeric(txtcost.Text) Then
                        If filename = "" Then
                            MsgBox("Favor seleccionar una imagen")
                        Else

                            imag = Imagen_Bytes(PictureBox2.Image)

                            If aux >= 9 Then
                                MsgBox("Ya No Se Cuenta Con Espacio Para Agregar Mas Productos, Favor De Contactar Al Programador")
                            Else
                                txtcost.Text = txtcost.Text.Replace("$", "")

                                Dim consulta As String
                                Dim lista As Byte
                                consulta = "SELECT * FROM Medicamentos WHERE Codigo='" & txtcodigo.Text & "'"
                                adaptador = New MySqlDataAdapter(consulta, conexion)
                                datos = New DataSet
                                adaptador.Fill(datos, "Medicamentos")
                                lista = datos.Tables("Medicamentos").Rows.Count

                                If lista <> 0 Then
                                    MsgBox("El Codigo Ya fue Registrado")
                                    txtcodigo.SelectAll()
                                Else
                                    cmd = conexion.CreateCommand

                                    cmd.CommandText = "INSERT INTO medicamentos(Codigo,Nombre,Descripcion,Costo,Imagen)VALUES(@cod,@nom,@des,@cost,@img)"
                                    cmd.Parameters.AddWithValue("@cod", txtcodigo.Text)
                                    cmd.Parameters.AddWithValue("@nom", txtnom.Text)
                                    cmd.Parameters.AddWithValue("@des", txtdes.Text)
                                    cmd.Parameters.AddWithValue("@cost", CDbl(txtcost.Text))
                                    cmd.Parameters.AddWithValue("@img", imag)
                                    cmd.ExecuteNonQuery()
                                    MsgBox("Se Agrego Correctamente")
                                    txtcost.Text = "$" + txtcost.Text
                                    Me.Close()
                                    menuPrincipal.Show()
                                End If

                            End If
                        End If

                    Else
                        MsgBox("Favor de Verificar El Costo")
                    End If

                End If
            Catch ex As Exception
                MsgBox("Ocurrio Un Error")
            End Try

        Else
            Dim consulta As String
            Dim lista As Byte
            consulta = "SELECT * FROM Medicamentos WHERE id='" & auxcodigo.Text & "'"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "Medicamentos")
            lista = datos.Tables("Medicamentos").Rows.Count
            If lista <> 0 Then
                cmd = conexion.CreateCommand
                cmd.CommandText = "UPDATE Medicamentos SET Codigo = ?cod, Nombre = ?nom, Descripcion = ?des, Costo = ?cost, Imagen = ?img  WHERE Id = '" & auxcodigo.Text & "'"
                cmd.Parameters.AddWithValue("?cod", txtcodigo.Text)
                txtcost.Text = txtcost.Text.Replace("$", "")
                cmd.Parameters.AddWithValue("?cost", txtcost.Text)
                cmd.Parameters.AddWithValue("?des", txtdes.Text)
                cmd.Parameters.AddWithValue("?nom", txtnom.Text)
                cmd.Parameters.AddWithValue("?img", Imagen_Bytes(PictureBox2.Image))
                cmd.ExecuteNonQuery()
                txtcost.Text = "$" & txtcost.Text
                MsgBox("Se Actualizo El Producto")
            End If
        End If



    End Sub


    Private Sub txtcost_Leave(sender As Object, e As EventArgs) Handles txtcost.Leave
        txtcost.Text = "$" + txtcost.Text
    End Sub

    Private Sub txtcost_Enter(sender As Object, e As EventArgs) Handles txtcost.Enter
        txtcost.Text = txtcost.Text.Replace("$", "")
        txtcost.SelectAll()
    End Sub
    Private Function Imagen_Bytes(ByVal Imagen As Image) As Byte()
        'si hay imagen
        If Not Imagen Is Nothing Then
            'variable de datos binarios en stream(flujo)
            Dim Bin As New MemoryStream
            'convertir a bytes
            Imagen.Save(Bin, Imaging.ImageFormat.Jpeg)
            'retorna binario
            Return Bin.GetBuffer
        Else
            Return Nothing
        End If
    End Function


    Private Sub AgregarMedicamento_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        menuPrincipal.Show()
        menuPrincipal.Refresh()
        'menuPrincipal.Close()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        If MsgBox("seguro que quieres eliminar este producto?", vbYesNo, "Borrar Producto") = MsgBoxResult.Yes Then
            cmd = conexion.CreateCommand
            cmd.CommandText = "DELETE FROM Medicamentos WHERE id = '" & auxcodigo.Text & "'"
            cmd.ExecuteNonQuery()
            MsgBox("Producto Borrado")
            menuPrincipal.Show()
            Me.Close()
        Else

        End If

    End Sub
End Class