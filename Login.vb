Imports System.ComponentModel
Imports MySql.Data.MySqlClient


Public Class FormLogin
    Dim cmd As MySqlCommand
    Dim conexion As MySqlConnection = New MySqlConnection
    Dim comando As MySqlCommand = New MySqlCommand
    Dim adaptador As New MySqlDataAdapter
    Dim datos As DataSet
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Close()
        'TODO: esta línea de código carga datos en la tabla 'FarmaciasbernyDataSet.usuarios' Puede moverla o quitarla según sea necesario.
        'Me.UsuariosTableAdapter.Fill(Me.FarmaciasbernyDataSet.usuarios)


        comando.Connection = conexion
        Try
            conexion.ConnectionString = "Server = localhost; Database = farmaciasberny; Uid = root; Password = 1234"
            conexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conexion.Close()
        RtxtFe.Text = btnTime.Value
        Rtxtuser.Text = ""
        RtxtApellido.Text = ""
        RtxtPass.Text = ""
        RtxtPassConf.Text = ""
        RtxtCorr.Text = ""
        RtxtFe.Text = ""
        Ltxtpass.Text = ""
        LtxtUsu.Text = ""


        Dim query As String = "SELECT * FROM Usuarios"
        Dim adpt As New MySqlDataAdapter(query, conexion)
        Dim ds As New DataSet()
        adpt.Fill(ds)
        gridusuarios.DataSource = ds.Tables(0)
        gridusuarios.Refresh()


    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        conexion.Close()
        comando.Connection = conexion
        Try
            conexion.ConnectionString = "Server = localhost; Database = farmaciasberny; Uid = root; Password = 1234"
            conexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        ' -----------------verifica que no falten campos--------------------
        If Rtxtuser.Text = "" Or RtxtApellido.Text = "" Or RtxtPass.Text = "" Or RtxtPassConf.Text = "" Or RtxtCorr.Text = "" Or RtxtFe.Text = "" Then
            MsgBox("Faltan Campos Por Rellenar", vbInformation, "Registrar")
        Else
            ' -----------------verifica que el numero telefono sea numerico-------------------
            If IsNumeric(Me.RtxtTel.Text) Then
                ' -----------------verifica que el numero telefono sea mayor a 8-------------------
                If RtxtTel.TextLength = 8 Then
                    ' -----------------verifica que la contraseña sea mayor que 6-------------------
                    If RtxtPass.TextLength >= 6 Then
                        ' -----------------verifica que las contraseñas sean iguales-------------------
                        If RtxtPass.Text = RtxtPassConf.Text Then
                            ' -----------------verifica que el correo sea mayor de 6 digitos-------------------
                            'recupera todo los datos de correos con ese nombre a un grid

                            Dim consulta As String
                            Dim lista As Byte
                            consulta = "SELECT * FROM usuarios WHERE correo='" & RtxtCorr.Text & "'"
                            adaptador = New MySqlDataAdapter(consulta, conexion)
                            datos = New DataSet
                            adaptador.Fill(datos, "usuarios")
                            lista = datos.Tables("usuarios").Rows.Count

                            If lista <> 0 Then
                                MsgBox("el correo ya existe favor de ingresar otro")
                            Else
                                cmd = conexion.CreateCommand

                                cmd.CommandText = "INSERT INTO Usuarios(Nombre,Apellidos,Pass,ConfiPass,Telefono,Correo,Fecha)VALUES(@nom,@ape,@psw,@conpsw,@tel,@corr,@fe)"
                                cmd.Parameters.AddWithValue("@nom", Rtxtuser.Text)
                                cmd.Parameters.AddWithValue("@ape", RtxtApellido.Text)
                                cmd.Parameters.AddWithValue("@psw", RtxtPass.Text)
                                cmd.Parameters.AddWithValue("@conpsw", RtxtPassConf.Text)
                                cmd.Parameters.AddWithValue("@corr", RtxtCorr.Text)
                                cmd.Parameters.AddWithValue("@tel", RtxtTel.Text)
                                cmd.Parameters.AddWithValue("@fe", CDate(RtxtFe.Text))
                                cmd.ExecuteNonQuery()
                                MsgBox("Se Registro Correctamente Felicidades", , "Registrado")
                                module1.Correo = RtxtCorr.Text
                                menuPrincipal.Show()
                                Me.Hide()
                            End If
                        Else
                            MsgBox("Una De Las Contraseñas Esta Mal", vbInformation, "Registrar")
                        End If
                    Else
                        MsgBox("La Contraseña Es Menor De 6 Digitos", vbInformation, "Registrar")
                    End If
                Else
                    MsgBox("El Telefono Esta Mal", vbInformation, "Registrar")
                End If
            Else
                MsgBox("El Telefono Esta Mal", vbInformation, "Registrar")
            End If
        End If
        conexion.Close()
    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        conexion.Close()
        comando.Connection = conexion

        Dim consulta As String
        Dim lista As Byte
        consulta = "SELECT * FROM usuarios WHERE correo='" & LtxtUsu.Text & "'"
        adaptador = New MySqlDataAdapter(consulta, conexion)
        datos = New DataSet
        adaptador.Fill(datos, "usuarios")
        lista = datos.Tables("usuarios").Rows.Count

        If lista <> 0 Then
            TextBox1.Text = datos.Tables("usuarios").Rows(0).Item("Correo")
            TextBox2.Text = datos.Tables("usuarios").Rows(0).Item("Pass")
            If TextBox1.Text = LtxtUsu.Text And TextBox2.Text = Ltxtpass.Text Then
                MsgBox("Login Exitoso")
                module1.Correo = LtxtUsu.Text
                borrar()
                Me.Hide()
                menuPrincipal.Show()
            Else
                MsgBox("Favor de verificar correo o contraseña")
            End If
        Else
            MsgBox("Favor de verificar correo o contraseña")
        End If

    End Sub

    Private Sub btnTime_ValueChanged(sender As Object, e As EventArgs) Handles btnTime.ValueChanged
        RtxtFe.Text = btnTime.Value
    End Sub

    Private Sub borrar()
        Ltxtpass.Clear()
        LtxtUsu.Clear()
        TextBox1.Clear()
        TextBox2.Clear()
        RtxtApellido.Clear()
        RtxtCorr.Clear()
        RtxtFe.Clear()
        RtxtPass.Clear()
        RtxtPassConf.Clear()
        RtxtTel.Clear()
        Rtxtuser.Clear()
    End Sub
End Class