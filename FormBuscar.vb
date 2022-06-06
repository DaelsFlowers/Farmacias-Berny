Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.IO
Public Class FormBuscar
    Dim cmd As MySqlCommand
    Dim conexion As MySqlConnection = New MySqlConnection
    Dim comando As MySqlCommand = New MySqlCommand
    Dim adaptador As New MySqlDataAdapter
    Dim datos As DataSet
    Dim consulta As String
    Dim lista As Byte
    Dim cantidad As Integer
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
        menuPrincipal.Show()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Refresh()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Close()
        FormLogin.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
        FormLogin.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Close()
        FormCarrito.Show()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        conexion.Close()
        comando.Connection = conexion
        Try
            conexion.ConnectionString = "Server = localhost; Database = farmaciasberny; Uid = root; Password = dfr4902"
            conexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Dim consulta As String
        Dim lista As Byte
        consulta = "SELECT * FROM Medicamentos WHERE Nombre='" & txtBuscar.Text & "'"
        adaptador = New MySqlDataAdapter(consulta, conexion)
        datos = New DataSet
        adaptador.Fill(datos, "Medicamentos")
        lista = datos.Tables("Medicamentos").Rows.Count

        If lista <> 0 Then
            mostrar()
            NamePro1.Text = datos.Tables("Medicamentos").Rows(0).Item("Nombre")
            InfPro1.Text = datos.Tables("medicamentos").Rows(0).Item("Descripcion")
            CostPro1.Text = datos.Tables("medicamentos").Rows(0).Item("Costo")
            CostPro1.Text = "$" & CostPro1.Text
            imgPro1.Image = Bytes_Imagen(datos.Tables("medicamentos").Rows(0).Item("Imagen"))
            Label6.Text = datos.Tables("medicamentos").Rows(0).Item("Codigo")

        Else
            ocultar()
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

    Private Sub FormBuscar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Close()
        comando.Connection = conexion
        Try
            conexion.ConnectionString = "Server = localhost; Database = farmaciasberny; Uid = root; Password = dfr4902"
            conexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        cargargrid()
    End Sub


    Public Sub cargargrid()
        Dim query As String = "SELECT * FROM carrito"
        Dim adpt As New MySqlDataAdapter(query, conexion)
        Dim ds As New DataSet()
        adpt.Fill(ds)
        gridcarrito.DataSource = ds.Tables(0)
    End Sub

    Private Sub btnagregar1_Click(sender As Object, e As EventArgs) Handles btnagregar1.Click
        conexion.Close()
        comando.Connection = conexion
        Try
            conexion.ConnectionString = "Server = localhost; Database = farmaciasberny; Uid = root; Password = dfr4902"
            conexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Dim consulta As String
        Dim lista As Byte
        consulta = "SELECT * FROM carrito WHERE Nombre_Medicamento='" & NamePro1.Text & "'"
        adaptador = New MySqlDataAdapter(consulta, conexion)
        datos = New DataSet
        adaptador.Fill(datos, "carrito")
        lista = datos.Tables("carrito").Rows.Count
        cantidad = 1
        Dim costos As Double
        If lista <> 0 Then
            cmd = conexion.CreateCommand
            cantidad = cantidad + datos.Tables("carrito").Rows(0).Item("Cantidad")
            cmd.CommandText = "UPDATE carrito SET Cantidad = " & cantidad & " WHERE Nombre_Medicamento= '" & NamePro1.Text & "'"
            cmd.ExecuteNonQuery()
            MsgBox("se guardo en carrito")
        Else
            cmd = conexion.CreateCommand

            cmd.CommandText = "INSERT INTO carrito(Id_Medicamento,Nombre_Medicamento,Costo_Medicamento,Cantidad)VALUES(@id,@nom,@cost,@cant)"
            cmd.Parameters.AddWithValue("@id", Label6.Text)
            cmd.Parameters.AddWithValue("@nom", NamePro1.Text)
            costos = CostPro1.Text.Replace("$", "")
            cmd.Parameters.AddWithValue("@cost", CDbl(costos))
            cmd.Parameters.AddWithValue("@cant", cantidad)
            cmd.ExecuteNonQuery()
            MsgBox("se guardo en carrito")
        End If
    End Sub

    Public Sub mostrar()
        PictureBox4.Visible = True
        PictureBox3.Visible = True
        imgPro1.Visible = True
        CostPro1.Visible = True
        InfPro1.Visible = True
        NamePro1.Visible = True
        txtPro1.Visible = True
        btnagregar1.Visible = True

        PictureBox3.SendToBack()
        PictureBox4.SendToBack()

    End Sub
    Public Sub ocultar()
        PictureBox4.Visible = False
        PictureBox3.Visible = False
        imgPro1.Visible = False
        CostPro1.Visible = False
        InfPro1.Visible = False
        NamePro1.Visible = False
        txtPro1.Visible = False
        btnagregar1.Visible = False

        PictureBox3.SendToBack()
        PictureBox4.SendToBack()

    End Sub
End Class


