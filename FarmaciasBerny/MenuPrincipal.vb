Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.IO
Public Class menuPrincipal
    Dim cmd As MySqlCommand
    Dim conexion As MySqlConnection = New MySqlConnection
    Dim comando As MySqlCommand = New MySqlCommand
    Dim adaptador As New MySqlDataAdapter
    Dim datos As DataSet
    Dim cantidad As Integer

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        borrarcarrito()
        Me.Close()
        FormLogin.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Refresh()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Hide()
        FormBuscar.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Hide()
        FormCarrito.Show()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Refresh()
    End Sub

    Private Sub menuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion.ConnectionString = "Server = localhost; Database = farmaciasberny; Uid = root; Password = 1234"
            conexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        TextBox1.Text = module1.Correo
        comando.Connection = conexion

        Dim consulta As String
        Dim lista As Byte
        consulta = "SELECT * FROM usuarios WHERE correo='" & TextBox1.Text & "'"
        adaptador = New MySqlDataAdapter(consulta, conexion)
        datos = New DataSet
        adaptador.Fill(datos, "usuarios")
        lista = datos.Tables("usuarios").Rows.Count

        If lista <> 0 Then
            TextBox2.Text = datos.Tables("usuarios").Rows(0).Item("Nivel")
            If TextBox2.Text = "Usuario" Then
                PictureBox5.Visible = False
            ElseIf TextBox2.Text = "Administrador" Then
                PictureBox5.Visible = True
            End If
        End If
        cargargrid()
        cargarmedicamentos()

    End Sub

    Public Sub cargarmedicamentos()
        conexion.Close()
        Dim aux As Integer

        aux = GridMedicamentos.Rows.Count

        If aux >= 2 Then
            PictureBox3.Visible = True
            PictureBox4.Visible = True
            txtPro1.Visible = True
            btnagregar1.Visible = True
            imgPro1.Visible = True
            CostPro1.Visible = True
            InfPro1.Visible = True
            NamePro1.Visible = True
            id1.Text = GridMedicamentos.Rows(0).Cells(1).Value
            NamePro1.Text = GridMedicamentos.Rows(0).Cells(2).Value
            InfPro1.Text = GridMedicamentos.Rows(0).Cells(3).Value
            CostPro1.Text = GridMedicamentos.Rows(0).Cells(4).Value
            imgPro1.Image = Bytes_Imagen(GridMedicamentos.Rows(0).Cells(5).Value)
            CostPro1.Text = "$" + CostPro1.Text
            PictureBox3.SendToBack()
            PictureBox4.SendToBack()
            btnagregar1.BringToFront()
            If TextBox2.Text = "Administrador" Then
                PictureBox13.Visible = True
                PictureBox13.BringToFront()
            End If

        End If

        If aux >= 3 Then
            PictureBox7.Visible = True
            PictureBox8.Visible = True
            Label6.Visible = True
            btnagregar2.Visible = True
            ImgPro2.Visible = True
            CostPro2.Visible = True
            InfPro2.Visible = True
            NamePro2.Visible = True
            id2.Text = GridMedicamentos.Rows(1).Cells(1).Value
            NamePro2.Text = GridMedicamentos.Rows(1).Cells(2).Value
            InfPro2.Text = GridMedicamentos.Rows(1).Cells(3).Value
            CostPro2.Text = GridMedicamentos.Rows(1).Cells(4).Value
            ImgPro2.Image = Bytes_Imagen(GridMedicamentos.Rows(1).Cells(5).Value)
            CostPro2.Text = "$" + CostPro2.Text
            PictureBox7.SendToBack()
            PictureBox8.SendToBack()
            btnagregar2.BringToFront()
            If TextBox2.Text = "Administrador" Then
                PictureBox10.Visible = True
                PictureBox10.BringToFront()
            End If

        End If
        If aux >= 4 Then
            PictureBox15.Visible = True
            PictureBox16.Visible = True
            Label14.Visible = True
            btnagregar3.Visible = True
            ImgPro3.Visible = True
            CostPro3.Visible = True
            InfPro3.Visible = True
            NamePro3.Visible = True
            id3.Text = GridMedicamentos.Rows(2).Cells(1).Value
            NamePro3.Text = GridMedicamentos.Rows(2).Cells(2).Value
            InfPro3.Text = GridMedicamentos.Rows(2).Cells(3).Value
            CostPro3.Text = GridMedicamentos.Rows(2).Cells(4).Value
            ImgPro3.Image = Bytes_Imagen(GridMedicamentos.Rows(2).Cells(5).Value)
            CostPro3.Text = "$" + CostPro3.Text
            PictureBox15.SendToBack()
            PictureBox16.SendToBack()
            btnagregar3.BringToFront()
            If TextBox2.Text = "Administrador" Then
                PictureBox6.Visible = True
                PictureBox6.BringToFront()
            End If

        End If
        If aux >= 5 Then
            PictureBox11.Visible = True
            PictureBox12.Visible = True
            Label10.Visible = True
            btnAgregar4.Visible = True
            ImgPro4.Visible = True
            CostPro4.Visible = True
            InfPro4.Visible = True
            NamePro4.Visible = True
            id4.Text = GridMedicamentos.Rows(3).Cells(1).Value
            NamePro4.Text = GridMedicamentos.Rows(3).Cells(2).Value
            InfPro4.Text = GridMedicamentos.Rows(3).Cells(3).Value
            CostPro4.Text = GridMedicamentos.Rows(3).Cells(4).Value
            ImgPro4.Image = Bytes_Imagen(GridMedicamentos.Rows(3).Cells(5).Value)
            CostPro4.Text = "$" + CostPro4.Text
            PictureBox11.SendToBack()
            PictureBox12.SendToBack()
            btnAgregar4.BringToFront()
            If TextBox2.Text = "Administrador" Then
                PictureBox9.Visible = True
                PictureBox9.BringToFront()
            End If

        End If
        If aux >= 6 Then
            PictureBox24.Visible = True
            PictureBox23.Visible = True
            Label22.Visible = True
            btnPro5.Visible = True
            ImgPro5.Visible = True
            CostPro5.Visible = True
            InfPro5.Visible = True
            NamePro5.Visible = True
            id5.Text = GridMedicamentos.Rows(4).Cells(1).Value
            NamePro5.Text = GridMedicamentos.Rows(4).Cells(2).Value
            InfPro5.Text = GridMedicamentos.Rows(4).Cells(3).Value
            CostPro5.Text = GridMedicamentos.Rows(4).Cells(4).Value
            ImgPro5.Image = Bytes_Imagen(GridMedicamentos.Rows(4).Cells(5).Value)
            CostPro5.Text = "$" + CostPro5.Text
            PictureBox24.SendToBack()
            PictureBox23.SendToBack()
            btnPro5.BringToFront()
            If TextBox2.Text = "Administrador" Then
                PictureBox17.Visible = True
                PictureBox17.BringToFront()
            End If

        End If
        If aux >= 7 Then
            PictureBox20.Visible = True
            PictureBox19.Visible = True
            Label18.Visible = True
            btnPro6.Visible = True
            ImgPro6.Visible = True
            CostPro6.Visible = True
            InfPro6.Visible = True
            NamePro6.Visible = True
            id6.Text = GridMedicamentos.Rows(5).Cells(1).Value
            NamePro6.Text = GridMedicamentos.Rows(5).Cells(2).Value
            InfPro6.Text = GridMedicamentos.Rows(5).Cells(3).Value
            CostPro6.Text = GridMedicamentos.Rows(5).Cells(4).Value
            ImgPro6.Image = Bytes_Imagen(GridMedicamentos.Rows(5).Cells(5).Value)
            CostPro6.Text = "$" + CostPro6.Text
            PictureBox20.SendToBack()
            PictureBox19.SendToBack()
            btnPro6.BringToFront()
            If TextBox2.Text = "Administrador" Then
                PictureBox14.Visible = True
                PictureBox14.BringToFront()
            End If

        End If
        If aux >= 8 Then
            PictureBox32.Visible = True
            PictureBox31.Visible = True
            Label30.Visible = True
            btnPro7.Visible = True
            ImgPro7.Visible = True
            CostPro7.Visible = True
            InfPro7.Visible = True
            NamePro7.Visible = True
            id7.Text = GridMedicamentos.Rows(6).Cells(1).Value
            NamePro7.Text = GridMedicamentos.Rows(6).Cells(2).Value
            InfPro7.Text = GridMedicamentos.Rows(6).Cells(3).Value
            CostPro7.Text = GridMedicamentos.Rows(6).Cells(4).Value
            ImgPro7.Image = Bytes_Imagen(GridMedicamentos.Rows(6).Cells(5).Value)
            CostPro7.Text = "$" + CostPro7.Text
            PictureBox32.SendToBack()
            PictureBox31.SendToBack()
            btnPro7.BringToFront()
            If TextBox2.Text = "Administrador" Then
                PictureBox21.Visible = True
                PictureBox21.BringToFront()
            End If

        End If
        If aux >= 9 Then
            PictureBox28.Visible = True
            PictureBox27.Visible = True
            Label26.Visible = True
            btnPro8.Visible = True
            ImgPro8.Visible = True
            CostPro8.Visible = True
            InfPro8.Visible = True
            NamePro8.Visible = True
            id8.Text = GridMedicamentos.Rows(7).Cells(1).Value
            NamePro8.Text = GridMedicamentos.Rows(7).Cells(2).Value
            InfPro8.Text = GridMedicamentos.Rows(7).Cells(3).Value
            CostPro8.Text = GridMedicamentos.Rows(7).Cells(4).Value
            ImgPro8.Image = Bytes_Imagen(GridMedicamentos.Rows(7).Cells(5).Value)
            CostPro8.Text = "$" + CostPro8.Text
            PictureBox28.SendToBack()
            PictureBox27.SendToBack()
            btnPro8.BringToFront()
            If TextBox2.Text = "Administrador" Then
                PictureBox18.Visible = True
                PictureBox18.BringToFront()
            End If

        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        module1.editar = False
        Me.Close()
        AgregarMedicamento.Show()

    End Sub
    Public Sub cargargrid()
        conexion.Close()
        Try
            conexion.ConnectionString = "Server = localhost; Database = farmaciasberny; Uid = root; Password = 1234"
            conexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Dim query As String = "SELECT * FROM Medicamentos"
        Dim adpt As New MySqlDataAdapter(query, conexion)
        Dim ds As New DataSet()
        adpt.Fill(ds)
        GridMedicamentos.DataSource = ds.Tables(0)
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

    Private Sub menuPrincipal_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        cargargrid()
        cargarmedicamentos()
    End Sub

    Private Sub btnagregar1_Click(sender As Object, e As EventArgs) Handles btnagregar1.Click
        conexion.Close()
        comando.Connection = conexion
        Try
            conexion.ConnectionString = "Server = localhost; Database = farmaciasberny; Uid = root; Password = 1234"
            conexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim consulta As String
        Dim lista As Byte
        consulta = "SELECT * FROM carrito WHERE Id_Medicamento='" & id1.Text & "'"
        adaptador = New MySqlDataAdapter(consulta, conexion)
        datos = New DataSet
        adaptador.Fill(datos, "carrito")
        lista = datos.Tables("carrito").Rows.Count
        cantidad = 1
        Dim costos As Double
        If lista <> 0 Then
            cmd = conexion.CreateCommand
            cantidad = cantidad + datos.Tables("carrito").Rows(0).Item("Cantidad")
            cmd.CommandText = "UPDATE carrito SET Cantidad = " & cantidad & " WHERE Id_Medicamento= '" & id1.Text & "'"
            cmd.ExecuteNonQuery()
            MsgBox("se guardo en carrito")
        Else
            cmd = conexion.CreateCommand

            cmd.CommandText = "INSERT INTO carrito(Id_Medicamento,Nombre_Medicamento,Costo_Medicamento,Cantidad)VALUES(@id,@nom,@cost,@cant)"
            cmd.Parameters.AddWithValue("@id", id1.Text)
            cmd.Parameters.AddWithValue("@nom", NamePro1.Text)
            costos = CostPro1.Text.Replace("$", "")
            cmd.Parameters.AddWithValue("@cost", CDbl(costos))
            cmd.Parameters.AddWithValue("@cant", cantidad)
            cmd.ExecuteNonQuery()
            MsgBox("se guardo en carrito")
        End If
    End Sub

    Public Sub borrarcarrito()
        conexion.Close()
        comando.Connection = conexion
        Try
            conexion.ConnectionString = "Server = localhost; Database = farmaciasberny; Uid = root; Password = 1234"
            conexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cmd = conexion.CreateCommand
        cmd.CommandText = "DELETE FROM carrito"
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub btnagregar2_Click(sender As Object, e As EventArgs) Handles btnagregar2.Click
        conexion.Close()
        comando.Connection = conexion
        Try
            conexion.ConnectionString = "Server = localhost; Database = farmaciasberny; Uid = root; Password = 1234"
            conexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim consulta As String
        Dim lista As Byte
        consulta = "SELECT * FROM carrito WHERE Id_Medicamento='" & id2.Text & "'"
        adaptador = New MySqlDataAdapter(consulta, conexion)
        datos = New DataSet
        adaptador.Fill(datos, "carrito")
        lista = datos.Tables("carrito").Rows.Count
        cantidad = 1
        Dim costos As Double
        If lista <> 0 Then
            cmd = conexion.CreateCommand
            cantidad = cantidad + datos.Tables("carrito").Rows(0).Item("Cantidad")
            cmd.CommandText = "UPDATE carrito SET Cantidad = " & cantidad & " WHERE Id_Medicamento= '" & id2.Text & "'"
            cmd.ExecuteNonQuery()
            MsgBox("se guardo en carrito")
        Else
            cmd = conexion.CreateCommand

            cmd.CommandText = "INSERT INTO carrito(Id_Medicamento,Nombre_Medicamento,Costo_Medicamento,Cantidad)VALUES(@id,@nom,@cost,@cant)"
            cmd.Parameters.AddWithValue("@id", id2.Text)
            cmd.Parameters.AddWithValue("@nom", NamePro2.Text)
            costos = CostPro2.Text.Replace("$", "")
            cmd.Parameters.AddWithValue("@cost", CDbl(costos))
            cmd.Parameters.AddWithValue("@cant", cantidad)
            cmd.ExecuteNonQuery()
            MsgBox("se guardo en carrito")
        End If
    End Sub

    Private Sub btnagregar3_Click(sender As Object, e As EventArgs) Handles btnagregar3.Click
        conexion.Close()
        comando.Connection = conexion
        Try
            conexion.ConnectionString = "Server = localhost; Database = farmaciasberny; Uid = root; Password = 1234"
            conexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim consulta As String
        Dim lista As Byte
        consulta = "SELECT * FROM carrito WHERE Id_Medicamento='" & id3.Text & "'"
        adaptador = New MySqlDataAdapter(consulta, conexion)
        datos = New DataSet
        adaptador.Fill(datos, "carrito")
        lista = datos.Tables("carrito").Rows.Count
        cantidad = 1
        Dim costos As Double
        If lista <> 0 Then
            cmd = conexion.CreateCommand
            cantidad = cantidad + datos.Tables("carrito").Rows(0).Item("Cantidad")
            cmd.CommandText = "UPDATE carrito SET Cantidad = " & cantidad & " WHERE Id_Medicamento= '" & id3.Text & "'"
            cmd.ExecuteNonQuery()
            MsgBox("se guardo en carrito")
        Else
            cmd = conexion.CreateCommand

            cmd.CommandText = "INSERT INTO carrito(Id_Medicamento,Nombre_Medicamento,Costo_Medicamento,Cantidad)VALUES(@id,@nom,@cost,@cant)"
            cmd.Parameters.AddWithValue("@id", id3.Text)
            cmd.Parameters.AddWithValue("@nom", NamePro3.Text)
            costos = CostPro3.Text.Replace("$", "")
            cmd.Parameters.AddWithValue("@cost", CDbl(costos))
            cmd.Parameters.AddWithValue("@cant", cantidad)
            cmd.ExecuteNonQuery()
            MsgBox("se guardo en carrito")
        End If
    End Sub

    Private Sub btnAgregar4_Click(sender As Object, e As EventArgs) Handles btnAgregar4.Click
        conexion.Close()
        comando.Connection = conexion
        Try
            conexion.ConnectionString = "Server = localhost; Database = farmaciasberny; Uid = root; Password = 1234"
            conexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim consulta As String
        Dim lista As Byte
        consulta = "SELECT * FROM carrito WHERE Id_Medicamento='" & id4.Text & "'"
        adaptador = New MySqlDataAdapter(consulta, conexion)
        datos = New DataSet
        adaptador.Fill(datos, "carrito")
        lista = datos.Tables("carrito").Rows.Count
        cantidad = 1
        Dim costos As Double
        If lista <> 0 Then
            cmd = conexion.CreateCommand
            cantidad = cantidad + datos.Tables("carrito").Rows(0).Item("Cantidad")
            cmd.CommandText = "UPDATE carrito SET Cantidad = " & cantidad & " WHERE Id_Medicamento= '" & id4.Text & "'"
            cmd.ExecuteNonQuery()
            MsgBox("se guardo en carrito")
        Else
            cmd = conexion.CreateCommand

            cmd.CommandText = "INSERT INTO carrito(Id_Medicamento,Nombre_Medicamento,Costo_Medicamento,Cantidad)VALUES(@id,@nom,@cost,@cant)"
            cmd.Parameters.AddWithValue("@id", id4.Text)
            cmd.Parameters.AddWithValue("@nom", NamePro4.Text)
            costos = CostPro4.Text.Replace("$", "")
            cmd.Parameters.AddWithValue("@cost", CDbl(costos))
            cmd.Parameters.AddWithValue("@cant", cantidad)
            cmd.ExecuteNonQuery()
            MsgBox("se guardo en carrito")
        End If
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        module1.codigo = GridMedicamentos.Rows(0).Cells(1).Value
        module1.nombre_medi = GridMedicamentos.Rows(0).Cells(2).Value
        module1.descrip = GridMedicamentos.Rows(0).Cells(3).Value
        module1.costo = GridMedicamentos.Rows(0).Cells(4).Value
        module1.imagen = GridMedicamentos.Rows(0).Cells(5).Value
        module1.editar = True
        Me.Close()
        AgregarMedicamento.Show()
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        module1.codigo = GridMedicamentos.Rows(1).Cells(1).Value
        module1.nombre_medi = GridMedicamentos.Rows(1).Cells(2).Value
        module1.descrip = GridMedicamentos.Rows(1).Cells(3).Value
        module1.costo = GridMedicamentos.Rows(1).Cells(4).Value
        module1.imagen = GridMedicamentos.Rows(1).Cells(5).Value
        module1.editar = True
        Me.Close()
        AgregarMedicamento.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        module1.codigo = GridMedicamentos.Rows(2).Cells(1).Value
        module1.nombre_medi = GridMedicamentos.Rows(2).Cells(2).Value
        module1.descrip = GridMedicamentos.Rows(2).Cells(3).Value
        module1.costo = GridMedicamentos.Rows(2).Cells(4).Value
        module1.imagen = GridMedicamentos.Rows(2).Cells(5).Value
        module1.editar = True
        Me.Close()
        AgregarMedicamento.Show()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        module1.codigo = GridMedicamentos.Rows(3).Cells(1).Value
        module1.nombre_medi = GridMedicamentos.Rows(3).Cells(2).Value
        module1.descrip = GridMedicamentos.Rows(3).Cells(3).Value
        module1.costo = GridMedicamentos.Rows(3).Cells(4).Value
        module1.imagen = GridMedicamentos.Rows(3).Cells(5).Value
        module1.editar = True
        Me.Close()
        AgregarMedicamento.Show()
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        module1.codigo = GridMedicamentos.Rows(4).Cells(1).Value
        module1.nombre_medi = GridMedicamentos.Rows(4).Cells(2).Value
        module1.descrip = GridMedicamentos.Rows(4).Cells(3).Value
        module1.costo = GridMedicamentos.Rows(4).Cells(4).Value
        module1.imagen = GridMedicamentos.Rows(4).Cells(5).Value
        module1.editar = True
        Me.Close()
        AgregarMedicamento.Show()
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        module1.codigo = GridMedicamentos.Rows(5).Cells(1).Value
        module1.nombre_medi = GridMedicamentos.Rows(5).Cells(2).Value
        module1.descrip = GridMedicamentos.Rows(5).Cells(3).Value
        module1.costo = GridMedicamentos.Rows(5).Cells(4).Value
        module1.imagen = GridMedicamentos.Rows(5).Cells(5).Value
        module1.editar = True
        Me.Close()
        AgregarMedicamento.Show()
    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click
        module1.codigo = GridMedicamentos.Rows(6).Cells(1).Value
        module1.nombre_medi = GridMedicamentos.Rows(6).Cells(2).Value
        module1.descrip = GridMedicamentos.Rows(6).Cells(3).Value
        module1.costo = GridMedicamentos.Rows(6).Cells(4).Value
        module1.imagen = GridMedicamentos.Rows(6).Cells(5).Value
        module1.editar = True
        Me.Close()
        AgregarMedicamento.Show()
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        module1.codigo = GridMedicamentos.Rows(7).Cells(1).Value
        module1.nombre_medi = GridMedicamentos.Rows(7).Cells(2).Value
        module1.descrip = GridMedicamentos.Rows(7).Cells(3).Value
        module1.costo = GridMedicamentos.Rows(7).Cells(4).Value
        module1.imagen = GridMedicamentos.Rows(7).Cells(5).Value
        module1.editar = True
        Me.Close()
        AgregarMedicamento.Show()
    End Sub

    Private Sub btnPro5_Click(sender As Object, e As EventArgs) Handles btnPro5.Click
        conexion.Close()
        comando.Connection = conexion
        Try
            conexion.ConnectionString = "Server = localhost; Database = farmaciasberny; Uid = root; Password = 1234"
            conexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim consulta As String
        Dim lista As Byte
        consulta = "SELECT * FROM carrito WHERE Id_Medicamento='" & id5.Text & "'"
        adaptador = New MySqlDataAdapter(consulta, conexion)
        datos = New DataSet
        adaptador.Fill(datos, "carrito")
        lista = datos.Tables("carrito").Rows.Count
        cantidad = 1
        Dim costos As Double
        If lista <> 0 Then
            cmd = conexion.CreateCommand
            cantidad = cantidad + datos.Tables("carrito").Rows(0).Item("Cantidad")
            cmd.CommandText = "UPDATE carrito SET Cantidad = " & cantidad & " WHERE Id_Medicamento= '" & id5.Text & "'"
            cmd.ExecuteNonQuery()
            MsgBox("se guardo en carrito")
        Else
            cmd = conexion.CreateCommand

            cmd.CommandText = "INSERT INTO carrito(Id_Medicamento,Nombre_Medicamento,Costo_Medicamento,Cantidad)VALUES(@id,@nom,@cost,@cant)"
            cmd.Parameters.AddWithValue("@id", id5.Text)
            cmd.Parameters.AddWithValue("@nom", NamePro5.Text)
            costos = CostPro5.Text.Replace("$", "")
            cmd.Parameters.AddWithValue("@cost", CDbl(costos))
            cmd.Parameters.AddWithValue("@cant", cantidad)
            cmd.ExecuteNonQuery()
            MsgBox("se guardo en carrito")
        End If
    End Sub

    Private Sub btnPro6_Click(sender As Object, e As EventArgs) Handles btnPro6.Click
        conexion.Close()
        comando.Connection = conexion
        Try
            conexion.ConnectionString = "Server = localhost; Database = farmaciasberny; Uid = root; Password = 1234"
            conexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim consulta As String
        Dim lista As Byte
        consulta = "SELECT * FROM carrito WHERE Id_Medicamento='" & id6.Text & "'"
        adaptador = New MySqlDataAdapter(consulta, conexion)
        datos = New DataSet
        adaptador.Fill(datos, "carrito")
        lista = datos.Tables("carrito").Rows.Count
        cantidad = 1
        Dim costos As Double
        If lista <> 0 Then
            cmd = conexion.CreateCommand
            cantidad = cantidad + datos.Tables("carrito").Rows(0).Item("Cantidad")
            cmd.CommandText = "UPDATE carrito SET Cantidad = " & cantidad & " WHERE Id_Medicamento= '" & id6.Text & "'"
            cmd.ExecuteNonQuery()
            MsgBox("se guardo en carrito")
        Else
            cmd = conexion.CreateCommand

            cmd.CommandText = "INSERT INTO carrito(Id_Medicamento,Nombre_Medicamento,Costo_Medicamento,Cantidad)VALUES(@id,@nom,@cost,@cant)"
            cmd.Parameters.AddWithValue("@id", id6.Text)
            cmd.Parameters.AddWithValue("@nom", NamePro6.Text)
            costos = CostPro6.Text.Replace("$", "")
            cmd.Parameters.AddWithValue("@cost", CDbl(costos))
            cmd.Parameters.AddWithValue("@cant", cantidad)
            cmd.ExecuteNonQuery()
            MsgBox("se guardo en carrito")
        End If
    End Sub

    Private Sub btnPro7_Click(sender As Object, e As EventArgs) Handles btnPro7.Click
        conexion.Close()
        comando.Connection = conexion
        Try
            conexion.ConnectionString = "Server = localhost; Database = farmaciasberny; Uid = root; Password = 1234"
            conexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim consulta As String
        Dim lista As Byte
        consulta = "SELECT * FROM carrito WHERE Id_Medicamento='" & id7.Text & "'"
        adaptador = New MySqlDataAdapter(consulta, conexion)
        datos = New DataSet
        adaptador.Fill(datos, "carrito")
        lista = datos.Tables("carrito").Rows.Count
        cantidad = 1
        Dim costos As Double
        If lista <> 0 Then
            cmd = conexion.CreateCommand
            cantidad = cantidad + datos.Tables("carrito").Rows(0).Item("Cantidad")
            cmd.CommandText = "UPDATE carrito SET Cantidad = " & cantidad & " WHERE Id_Medicamento= '" & id7.Text & "'"
            cmd.ExecuteNonQuery()
            MsgBox("se guardo en carrito")
        Else
            cmd = conexion.CreateCommand

            cmd.CommandText = "INSERT INTO carrito(Id_Medicamento,Nombre_Medicamento,Costo_Medicamento,Cantidad)VALUES(@id,@nom,@cost,@cant)"
            cmd.Parameters.AddWithValue("@id", id7.Text)
            cmd.Parameters.AddWithValue("@nom", NamePro7.Text)
            costos = CostPro7.Text.Replace("$", "")
            cmd.Parameters.AddWithValue("@cost", CDbl(costos))
            cmd.Parameters.AddWithValue("@cant", cantidad)
            cmd.ExecuteNonQuery()
            MsgBox("se guardo en carrito")
        End If
    End Sub

    Private Sub btnPro8_Click(sender As Object, e As EventArgs) Handles btnPro8.Click
        conexion.Close()
        comando.Connection = conexion
        Try
            conexion.ConnectionString = "Server = localhost; Database = farmaciasberny; Uid = root; Password = 1234"
            conexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim consulta As String
        Dim lista As Byte
        consulta = "SELECT * FROM carrito WHERE Id_Medicamento='" & id8.Text & "'"
        adaptador = New MySqlDataAdapter(consulta, conexion)
        datos = New DataSet
        adaptador.Fill(datos, "carrito")
        lista = datos.Tables("carrito").Rows.Count
        cantidad = 1
        Dim costos As Double
        If lista <> 0 Then
            cmd = conexion.CreateCommand
            cantidad = cantidad + datos.Tables("carrito").Rows(0).Item("Cantidad")
            cmd.CommandText = "UPDATE carrito SET Cantidad = " & cantidad & " WHERE Id_Medicamento= '" & id8.Text & "'"
            cmd.ExecuteNonQuery()
            MsgBox("se guardo en carrito")
        Else
            cmd = conexion.CreateCommand

            cmd.CommandText = "INSERT INTO carrito(Id_Medicamento,Nombre_Medicamento,Costo_Medicamento,Cantidad)VALUES(@id,@nom,@cost,@cant)"
            cmd.Parameters.AddWithValue("@id", id8.Text)
            cmd.Parameters.AddWithValue("@nom", NamePro8.Text)
            costos = CostPro8.Text.Replace("$", "")
            cmd.Parameters.AddWithValue("@cost", CDbl(costos))
            cmd.Parameters.AddWithValue("@cant", cantidad)
            cmd.ExecuteNonQuery()
            MsgBox("se guardo en carrito")
        End If
    End Sub

End Class