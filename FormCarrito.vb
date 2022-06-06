Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.IO
Imports System.Drawing.Printing

Public Class FormCarrito
    Dim cmd As MySqlCommand
    Dim conexion As MySqlConnection = New MySqlConnection
    Dim comando As MySqlCommand = New MySqlCommand
    Dim adaptador As New MySqlDataAdapter
    Dim datos As DataSet
    Dim consulta As String
    Dim lista As Byte
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
        menuPrincipal.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
        FormBuscar.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        menuPrincipal.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Refresh()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        module1.Nombre = ""
        module1.Apellidos = ""
        module1.Telefono = ""
        module1.Correo = ""
        borrarcarrito()
        Me.Close()
        FormLogin.Show()
    End Sub

    Public Sub borrarcarrito()
        conexion.Close()
        Try
            conexion.ConnectionString = "Server = localhost; Database = farmaciasberny; Uid = root; Password = dfr4902"
            conexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        comando.Connection = conexion
        cmd = conexion.CreateCommand
        cmd.CommandText = "DELETE FROM carrito"
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub FormCarrito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        menuPrincipal.Close()
        Try
            conexion.ConnectionString = "Server = localhost; Database = farmaciasberny; Uid = root; Password = dfr4902"
            conexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        comando.Connection = conexion

        cargargrid()
        cargarproducto1()
        cargarusuario()
    End Sub

    Public Sub cargarusuario()
        TextBox1.Text = module1.Correo
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
        consulta = "SELECT * FROM usuarios WHERE Correo ='" & TextBox1.Text & "'"
        adaptador = New MySqlDataAdapter(consulta, conexion)
        datos = New DataSet
        adaptador.Fill(datos, "usuarios")
        lista = datos.Tables("usuarios").Rows.Count

        If lista <> 0 Then
            module1.Nombre = datos.Tables("usuarios").Rows(0).Item("Nombre")
            module1.Apellidos = datos.Tables("usuarios").Rows(0).Item("Apellidos")
            module1.Telefono = datos.Tables("usuarios").Rows(0).Item("Telefono")
            module1.Correo = datos.Tables("usuarios").Rows(0).Item("Correo")
        End If


    End Sub

    Public Sub cargargrid()
        Dim query As String = "SELECT * FROM carrito"
        Dim adpt As New MySqlDataAdapter(query, conexion)
        Dim ds As New DataSet()
        adpt.Fill(ds)
        gridcarrito.DataSource = ds.Tables(0)

    End Sub

    Public Sub cargarproducto1()
        Dim aux As Integer

        aux = gridcarrito.Rows.Count

        If aux >= 2 Then
            ' se hace visible el recuadro
            PictureBox3.Visible = True
            PictureBox4.Visible = True
            NamePro1.Visible = True
            txtPro1.Visible = True
            CostPro1.Visible = True
            imgPro1.Visible = True
            cantpor1.Visible = True
            cant1.Visible = True
            elm1.Visible = True

            'se le dan los valores del grid
            NamePro1.Text = gridcarrito.Rows(0).Cells(2).Value
            CostPro1.Text = gridcarrito.Rows(0).Cells(3).Value
            cant1.Text = gridcarrito.Rows(0).Cells(4).Value

            'se acomoda la z
            PictureBox3.SendToBack()
            PictureBox4.SendToBack()

            'busca producto en la base medicina
            comando.Connection = conexion
            consulta = "SELECT * FROM medicamentos WHERE Nombre ='" & NamePro1.Text & "'"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "medicamentos")
            lista = datos.Tables("medicamentos").Rows.Count

            If lista <> 0 Then
                imgPro1.Image = Bytes_Imagen(datos.Tables("medicamentos").Rows(0).Item("Imagen"))
            End If
        End If

        If aux >= 3 Then
            ' se hace visible el recuadro
            PictureBox7.Visible = True
            PictureBox6.Visible = True
            Label10.Visible = True
            Label8.Visible = True
            Label7.Visible = True
            PictureBox5.Visible = True
            Label6.Visible = True
            Label5.Visible = True
            elm2.Visible = True
            'se le dan los valores del grid
            Label10.Text = gridcarrito.Rows(1).Cells(2).Value
            Label7.Text = gridcarrito.Rows(1).Cells(3).Value
            Label5.Text = gridcarrito.Rows(1).Cells(4).Value

            'se acomoda la z
            PictureBox7.SendToBack()
            PictureBox6.SendToBack()

            comando.Connection = conexion
            consulta = "SELECT * FROM medicamentos WHERE Nombre ='" & Label10.Text & "'"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "medicamentos")
            lista = datos.Tables("medicamentos").Rows.Count

            If lista <> 0 Then
                PictureBox5.Image = Bytes_Imagen(datos.Tables("medicamentos").Rows(0).Item("Imagen"))
            End If
        End If
        If aux >= 4 Then
            ' se hace visible el recuadro
            PictureBox13.Visible = True
            PictureBox12.Visible = True
            Label20.Visible = True
            Label18.Visible = True
            Label16.Visible = True
            PictureBox11.Visible = True
            Label17.Visible = True
            Label41.Visible = True
            elm3.Visible = True
            'se le dan los valores del grid
            Label20.Text = gridcarrito.Rows(2).Cells(2).Value
            Label17.Text = gridcarrito.Rows(2).Cells(3).Value
            Label41.Text = gridcarrito.Rows(2).Cells(4).Value

            'se acomoda la z
            PictureBox13.SendToBack()
            PictureBox12.SendToBack()
            comando.Connection = conexion
            consulta = "SELECT * FROM medicamentos WHERE Nombre ='" & Label20.Text & "'"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "medicamentos")
            lista = datos.Tables("medicamentos").Rows.Count

            If lista <> 0 Then
                PictureBox11.Image = Bytes_Imagen(datos.Tables("medicamentos").Rows(0).Item("Imagen"))
            End If
        End If
        If aux >= 5 Then
            ' se hace visible el recuadro
            PictureBox10.Visible = True
            PictureBox9.Visible = True
            Label15.Visible = True
            Label12.Visible = True
            Label42.Visible = True
            PictureBox8.Visible = True
            Label13.Visible = True
            Label11.Visible = True
            elm4.Visible = True
            'se le dan los valores del grid
            Label15.Text = gridcarrito.Rows(3).Cells(2).Value
            Label12.Text = gridcarrito.Rows(3).Cells(3).Value
            Label42.Text = gridcarrito.Rows(3).Cells(4).Value

            'se acomoda la z
            PictureBox10.SendToBack()
            PictureBox9.SendToBack()
            comando.Connection = conexion
            consulta = "SELECT * FROM medicamentos WHERE Nombre ='" & Label15.Text & "'"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "medicamentos")
            lista = datos.Tables("medicamentos").Rows.Count

            If lista <> 0 Then
                PictureBox8.Image = Bytes_Imagen(datos.Tables("medicamentos").Rows(0).Item("Imagen"))
            End If
        End If
        If aux >= 6 Then
            ' se hace visible el recuadro
            PictureBox25.Visible = True
            PictureBox24.Visible = True
            Label40.Visible = True
            Label37.Visible = True
            Label46.Visible = True
            PictureBox23.Visible = True
            Label38.Visible = True
            Label36.Visible = True
            elm5.Visible = True
            'se le dan los valores del grid
            Label40.Text = gridcarrito.Rows(4).Cells(2).Value
            Label37.Text = gridcarrito.Rows(4).Cells(3).Value
            Label46.Text = gridcarrito.Rows(4).Cells(4).Value

            'se acomoda la z
            PictureBox25.SendToBack()
            PictureBox24.SendToBack()
            comando.Connection = conexion
            consulta = "SELECT * FROM medicamentos WHERE Nombre ='" & Label40.Text & "'"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "medicamentos")
            lista = datos.Tables("medicamentos").Rows.Count

            If lista <> 0 Then
                PictureBox23.Image = Bytes_Imagen(datos.Tables("medicamentos").Rows(0).Item("Imagen"))
            End If
        End If
        If aux >= 7 Then
            ' se hace visible el recuadro
            PictureBox22.Visible = True
            PictureBox21.Visible = True
            Label35.Visible = True
            Label32.Visible = True
            Label45.Visible = True
            PictureBox20.Visible = True
            Label33.Visible = True
            Label31.Visible = True
            elm6.Visible = True
            'se le dan los valores del grid
            Label35.Text = gridcarrito.Rows(5).Cells(2).Value
            Label32.Text = gridcarrito.Rows(5).Cells(3).Value
            Label45.Text = gridcarrito.Rows(5).Cells(4).Value

            'se acomoda la z
            PictureBox22.SendToBack()
            PictureBox21.SendToBack()
            comando.Connection = conexion
            consulta = "SELECT * FROM medicamentos WHERE Nombre ='" & Label35.Text & "'"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "medicamentos")
            lista = datos.Tables("medicamentos").Rows.Count

            If lista <> 0 Then
                PictureBox20.Image = Bytes_Imagen(datos.Tables("medicamentos").Rows(0).Item("Imagen"))
            End If
        End If
        If aux >= 8 Then
            ' se hace visible el recuadro
            PictureBox19.Visible = True
            PictureBox18.Visible = True
            Label30.Visible = True
            Label27.Visible = True
            Label44.Visible = True
            PictureBox17.Visible = True
            Label28.Visible = True
            Label26.Visible = True
            elm7.Visible = True
            'se le dan los valores del grid
            Label30.Text = gridcarrito.Rows(6).Cells(2).Value
            Label27.Text = gridcarrito.Rows(6).Cells(3).Value
            Label44.Text = gridcarrito.Rows(6).Cells(4).Value

            'se acomoda la z
            PictureBox19.SendToBack()
            PictureBox18.SendToBack()
            comando.Connection = conexion
            consulta = "SELECT * FROM medicamentos WHERE Nombre ='" & Label30.Text & "'"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "medicamentos")
            lista = datos.Tables("medicamentos").Rows.Count

            If lista <> 0 Then
                PictureBox17.Image = Bytes_Imagen(datos.Tables("medicamentos").Rows(0).Item("Imagen"))
            End If
        End If
        If aux >= 9 Then
            ' se hace visible el recuadro
            PictureBox16.Visible = True
            PictureBox15.Visible = True
            Label25.Visible = True
            Label22.Visible = True
            Label43.Visible = True
            PictureBox14.Visible = True
            Label23.Visible = True
            Label21.Visible = True
            elm8.Visible = True
            'se le dan los valores del grid
            Label25.Text = gridcarrito.Rows(7).Cells(2).Value
            Label22.Text = gridcarrito.Rows(7).Cells(3).Value
            Label43.Text = gridcarrito.Rows(7).Cells(4).Value

            'se acomoda la z
            PictureBox16.SendToBack()
            PictureBox15.SendToBack()
            comando.Connection = conexion
            consulta = "SELECT * FROM medicamentos WHERE Nombre ='" & Label25.Text & "'"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "medicamentos")
            lista = datos.Tables("medicamentos").Rows.Count

            If lista <> 0 Then
                PictureBox14.Image = Bytes_Imagen(datos.Tables("medicamentos").Rows(0).Item("Imagen"))
            End If
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If PrintDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ' ejemplo simple para imprimir en .NET
            ' Usamos una clase del tipo PrintDocument
            Dim printDoc As New PrintDocument
            ' asignamos el método de evento para cada página a imprimir
            AddHandler printDoc.PrintPage, AddressOf print_PrintPage

            ' indicamos que queremos imprimir

            Try
                PrintDialog1.PrinterSettings = printDoc.PrinterSettings
                PrintDialog1.PrinterSettings.PrinterName = "Microsoft Print to PDF"

                PrintPreviewDialog1.Document = printDoc
                'PrintPreviewDialog1.ShowDialog()
                printDoc.Print()

            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub print_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
        ' Este evento se producirá cada vez que se imprima una nueva página

        ' La fuente a usar arial a tamano 9
        Dim prFont As New Font("Arial", 9)
        Dim prFontP As New Font("Arial", 11, FontStyle.Bold)
        Dim prFontT As New Font("Arial", 30, FontStyle.Bold)
        ' la posición superior y left
        Dim xPos As Integer = 5
        Dim yPos As Integer = 0


        Dim txt1 As String = "FARMACIAS BERNY"
        Dim txt2 As String = "DATOS DE LA FARMACIA"
        Dim txt3 As String = "FAVOR DE RECOGER SUS PRODUCTOS EN LA SUCURSAL INDICADA DEPENDIENDO"
        Dim txt4 As String = "DE LAS HORAS EN EL QUE ESTA DISPONIBLE"
        Dim txt5 As String = "SUCURSAL"
        Dim txt6 As String = "v. Manuel L. Barragán 201, Villa Universidad, 66420 San Nicolás de los Garza, N.L."
        Dim txt7 As String = "PAGO"
        Dim txt8 As String = "EFECTIVO"
        Dim txt9 As String = "HORARIO"
        Dim txt10 As String = "10:00AM – 18:45PM"
        Dim txt11 As String = "DATOS DEL USUARIO"
        Dim txt12 As String = "NOMBRE"
        Dim txt1a As String = module1.Nombre & " " & module1.Apellidos
        Dim txt13 As String = "TELEFONO"
        Dim txt2a As String = module1.Telefono
        Dim txt14 As String = "CORREO"
        Dim txt3a As String = module1.Correo
        Dim txt15 As String = "FECHA"
        Dim txt4a As String = Date.Now.ToShortDateString
        Dim txt16 As String = "LISTA DE PRODUCTOS"
        Dim txt17 As String = "CODIGO"
        Dim txt18 As String = "NOMBRE"
        Dim txt19 As String = "COSTO"
        Dim txt20 As String = "CANTIDAD"
        Dim txt21 As String = "TOTAL"
        Dim totalr As Double
        Dim pro1a As String = ""
        Dim pro2a As String = ""
        Dim pro3a As String = ""
        Dim pro4a As String = ""
        Dim totala As Double
        Dim total1a As String = ""
        Dim pro1b As String = ""
        Dim pro2b As String = ""
        Dim pro3b As String = ""
        Dim pro4b As String = ""
        Dim totalb As Double
        Dim total1b As String = ""
        Dim pro1c As String = ""
        Dim pro2c As String = ""
        Dim pro3c As String = ""
        Dim pro4c As String = ""
        Dim totalc As Double
        Dim total1c As String = ""
        Dim pro1d As String = ""
        Dim pro2d As String = ""
        Dim pro3d As String = ""
        Dim pro4d As String = ""
        Dim totald As Double
        Dim total1d As String = ""
        Dim pro1e As String = ""
        Dim pro2e As String = ""
        Dim pro3e As String = ""
        Dim pro4e As String = ""
        Dim totale As Double
        Dim total1e As String = ""
        Dim pro1f As String = ""
        Dim pro2f As String = ""
        Dim pro3f As String = ""
        Dim pro4f As String = ""
        Dim totalf As Double
        Dim total1f As String = ""
        Dim pro1g As String = ""
        Dim pro2g As String = ""
        Dim pro3g As String = ""
        Dim pro4g As String = ""
        Dim totalg As Double
        Dim total1g As String = ""
        Dim pro1h As String = ""
        Dim pro2h As String = ""
        Dim pro3h As String = ""
        Dim pro4h As String = ""
        Dim totalh As Double
        Dim total1h As String = ""


        totalr = 0
        Dim aux As Integer

        aux = gridcarrito.Rows.Count

        If aux >= 2 Then
            pro1a = gridcarrito.Rows(0).Cells(1).Value
            pro2a = gridcarrito.Rows(0).Cells(2).Value
            pro3a = gridcarrito.Rows(0).Cells(3).Value
            pro3a = "$" & pro3a
            pro4a = gridcarrito.Rows(0).Cells(4).Value
            totala = CDbl(pro3a.Replace("$", "")) * CInt(pro4a)
            totalr = CDbl(totalr) + CDbl(totala)
            total1a = "$" & CStr(totala)
        End If
        If aux >= 3 Then
            pro1b = gridcarrito.Rows(1).Cells(1).Value
            pro2b = gridcarrito.Rows(1).Cells(2).Value
            pro3b = gridcarrito.Rows(1).Cells(3).Value
            pro3b = "$" & pro3b
            pro4b = gridcarrito.Rows(1).Cells(4).Value
            totalb = CDbl(pro3b.Replace("$", "")) * CInt(pro4b)
            totalr = CDbl(totalr) + CDbl(totalb)
            total1b = "$" & CStr(totalb)
        End If
        If aux >= 4 Then
            pro1c = gridcarrito.Rows(2).Cells(1).Value
            pro2c = gridcarrito.Rows(2).Cells(2).Value
            pro3c = gridcarrito.Rows(2).Cells(3).Value
            pro3c = "$" & pro3c
            pro4c = gridcarrito.Rows(2).Cells(4).Value
            totalc = CDbl(pro3c.Replace("$", "")) * CInt(pro4c)
            totalr = CDbl(totalr) + CDbl(totalc)
            total1c = "$" & CStr(totalc)
        End If
        If aux >= 5 Then
            pro1d = gridcarrito.Rows(3).Cells(1).Value
            pro2d = gridcarrito.Rows(3).Cells(2).Value
            pro3d = gridcarrito.Rows(3).Cells(3).Value
            pro3d = "$" & pro3d
            pro4d = gridcarrito.Rows(3).Cells(4).Value
            totald = CDbl(pro3d.Replace("$", "")) * CInt(pro4d)
            totalr = CDbl(totalr) + CDbl(totald)
            total1d = "$" & CStr(totald)
        End If
        If aux >= 6 Then
            pro1e = gridcarrito.Rows(4).Cells(1).Value
            pro2e = gridcarrito.Rows(4).Cells(2).Value
            pro3e = gridcarrito.Rows(4).Cells(3).Value
            pro3e = "$" & pro3e
            pro4e = gridcarrito.Rows(4).Cells(4).Value
            totale = CDbl(pro3e.Replace("$", "")) * CInt(pro4e)
            totalr = CDbl(totalr) + CDbl(totale)
            total1e = "$" & CStr(totale)
        End If
        If aux >= 7 Then
            pro1f = gridcarrito.Rows(5).Cells(1).Value
            pro2f = gridcarrito.Rows(5).Cells(2).Value
            pro3f = gridcarrito.Rows(5).Cells(3).Value
            pro3f = "$" & pro3f
            pro4f = gridcarrito.Rows(5).Cells(4).Value

            totalf = CDbl(pro3f.Replace("$", "")) * CInt(pro4f)
            totalr = CDbl(totalr) + CDbl(totalf)
            total1f = "$" & CStr(totalf)
        End If
        If aux >= 8 Then
            pro1g = gridcarrito.Rows(6).Cells(1).Value
            pro2g = gridcarrito.Rows(6).Cells(2).Value
            pro3g = gridcarrito.Rows(6).Cells(3).Value
            pro3g = "$" & pro3g
            pro4g = gridcarrito.Rows(6).Cells(4).Value

            totalg = CDbl(pro3g.Replace("$", "")) * CInt(pro4g)
            totalr = CDbl(totalr) + CDbl(totalg)
            total1g = "$" & CStr(totalg)

        End If
        If aux >= 9 Then
            pro1h = gridcarrito.Rows(7).Cells(1).Value
            pro2h = gridcarrito.Rows(7).Cells(2).Value
            pro3h = gridcarrito.Rows(7).Cells(3).Value
            pro3h = "$" & pro3h
            pro4h = gridcarrito.Rows(7).Cells(4).Value


            totalh = CDbl(pro3h.Replace("$", "")) * CInt(pro4h)
            totalr = CDbl(totalr) + CDbl(totalh)
            total1h = "$" & CStr(totalh)

        End If
        Dim totalx As String = "TOTAL: "
        'totalr imprimir        


        ''-------------------banner--------------------------------------------------------------
        e.Graphics.DrawImage(logo.Image, xPos + 5, yPos + 10, 100, 100)
        e.Graphics.DrawImage(logo.Image, xPos + 735, yPos + 10, 100, 100)
        e.Graphics.DrawString(txt1, prFontT, Brushes.Black, xPos + 200, yPos + 30)
        yPos = yPos + 75
        ''----------------------------------------------------------------------------------------

        ''-------------------farmacias banner--------------------------------------------------------
        e.Graphics.DrawImage(liner.Image, 10, yPos + 47, 825, 25)
        e.Graphics.DrawString(txt2, prFontP, Brushes.Black, xPos + 15, yPos + 50)
        yPos = yPos + 75
        ''----------------------------------------------------------------------------------------


        ''-------------------datos farmacias--------------------------------------------------------
        e.Graphics.DrawString(txt3, prFontP, Brushes.Black, xPos + 100, yPos + 5)
        e.Graphics.DrawString(txt4, prFontP, Brushes.Black, xPos + 250, yPos + 25)
        e.Graphics.DrawString(txt5, prFontP, Brushes.Black, xPos + 15, yPos + 45)
        e.Graphics.DrawString(txt6, prFontP, Brushes.Black, xPos + 25, yPos + 65)

        e.Graphics.DrawString(txt7, prFontP, Brushes.Black, xPos + 15, yPos + 95)
        e.Graphics.DrawString(txt8, prFontP, Brushes.Black, xPos + 50, yPos + 115)
        e.Graphics.DrawString(txt9, prFontP, Brushes.Black, xPos + 515, yPos + 95)
        e.Graphics.DrawString(txt10, prFontP, Brushes.Black, xPos + 550, yPos + 115)
        yPos = yPos + 90
        ''----------------------------------------------------------------------------------------

        ''-------------------usuario banner--------------------------------------------------------
        e.Graphics.DrawImage(liner.Image, 10, yPos + 47, 825, 25)
        e.Graphics.DrawString(txt11, prFontP, Brushes.Black, xPos + 15, yPos + 50)
        yPos = yPos + 60
        ''----------------------------------------------------------------------------------------



        ''-------------------datos usuario-----------------------------------------------------------
        e.Graphics.DrawString(txt12, prFontP, Brushes.Black, xPos + 15, yPos + 20)
        e.Graphics.DrawString(txt1a, prFontP, Brushes.Black, xPos + 50, yPos + 40)

        e.Graphics.DrawString(txt13, prFontP, Brushes.Black, xPos + 515, yPos + 20)
        e.Graphics.DrawString(txt2a, prFontP, Brushes.Black, xPos + 550, yPos + 40)

        e.Graphics.DrawString(txt14, prFontP, Brushes.Black, xPos + 15, yPos + 70)
        e.Graphics.DrawString(txt3a, prFontP, Brushes.Black, xPos + 50, yPos + 90)

        e.Graphics.DrawString(txt15, prFontP, Brushes.Black, xPos + 515, yPos + 70)
        e.Graphics.DrawString(txt4a, prFontP, Brushes.Black, xPos + 550, yPos + 90)
        yPos = yPos + 70
        ''-------------------------------------------------------------------------------------------

        ''-------------------productos banner--------------------------------------------------------
        e.Graphics.DrawImage(liner.Image, 10, yPos + 47, 825, 25)
        e.Graphics.DrawString(txt16, prFontP, Brushes.Black, xPos + 15, yPos + 50)
        yPos = yPos + 65
        ''----------------------------------------------------------------------------------------

        ''-------------------productos columna superior--------------------------------------------------------
        e.Graphics.DrawString(txt17, prFontP, Brushes.Black, xPos + 15, yPos + 20)
        e.Graphics.DrawString(txt18, prFontP, Brushes.Black, xPos + 165, yPos + 20)
        e.Graphics.DrawString(txt19, prFontP, Brushes.Black, xPos + 365, yPos + 20)
        e.Graphics.DrawString(txt20, prFontP, Brushes.Black, xPos + 565, yPos + 20)
        e.Graphics.DrawString(txt21, prFontP, Brushes.Black, xPos + 715, yPos + 20)
        ''----------------------------------------------------------------------------------------

        ''-------------------productos--------------------------------------------------------
        If aux >= 2 Then
            yPos = yPos + 30
            e.Graphics.DrawString(pro1a, prFontP, Brushes.Black, xPos + 15, yPos + 20)
            e.Graphics.DrawString(pro2a, prFontP, Brushes.Black, xPos + 165, yPos + 20)
            e.Graphics.DrawString(pro3a, prFontP, Brushes.Black, xPos + 365, yPos + 20)
            e.Graphics.DrawString(pro4a, prFontP, Brushes.Black, xPos + 565, yPos + 20)
            e.Graphics.DrawString(total1a, prFontP, Brushes.Black, xPos + 715, yPos + 20)
        End If
        If aux >= 3 Then
            yPos = yPos + 30
            e.Graphics.DrawString(pro1b, prFontP, Brushes.Black, xPos + 15, yPos + 20)
            e.Graphics.DrawString(pro2b, prFontP, Brushes.Black, xPos + 165, yPos + 20)
            e.Graphics.DrawString(pro3b, prFontP, Brushes.Black, xPos + 365, yPos + 20)
            e.Graphics.DrawString(pro4b, prFontP, Brushes.Black, xPos + 565, yPos + 20)
            e.Graphics.DrawString(total1b, prFontP, Brushes.Black, xPos + 715, yPos + 20)
        End If
        If aux >= 4 Then
            yPos = yPos + 30
            e.Graphics.DrawString(pro1c, prFontP, Brushes.Black, xPos + 15, yPos + 20)
            e.Graphics.DrawString(pro2c, prFontP, Brushes.Black, xPos + 165, yPos + 20)
            e.Graphics.DrawString(pro3c, prFontP, Brushes.Black, xPos + 365, yPos + 20)
            e.Graphics.DrawString(pro4c, prFontP, Brushes.Black, xPos + 565, yPos + 20)
            e.Graphics.DrawString(total1c, prFontP, Brushes.Black, xPos + 715, yPos + 20)
        End If
        If aux >= 5 Then
            yPos = yPos + 30
            e.Graphics.DrawString(pro1d, prFontP, Brushes.Black, xPos + 15, yPos + 20)
            e.Graphics.DrawString(pro2d, prFontP, Brushes.Black, xPos + 165, yPos + 20)
            e.Graphics.DrawString(pro3d, prFontP, Brushes.Black, xPos + 365, yPos + 20)
            e.Graphics.DrawString(pro4d, prFontP, Brushes.Black, xPos + 565, yPos + 20)
            e.Graphics.DrawString(total1d, prFontP, Brushes.Black, xPos + 715, yPos + 20)
        End If
        If aux >= 6 Then
            yPos = yPos + 30
            e.Graphics.DrawString(pro1e, prFontP, Brushes.Black, xPos + 15, yPos + 20)
            e.Graphics.DrawString(pro2e, prFontP, Brushes.Black, xPos + 165, yPos + 20)
            e.Graphics.DrawString(pro3e, prFontP, Brushes.Black, xPos + 365, yPos + 20)
            e.Graphics.DrawString(pro4e, prFontP, Brushes.Black, xPos + 565, yPos + 20)
            e.Graphics.DrawString(total1e, prFontP, Brushes.Black, xPos + 715, yPos + 20)
        End If
        If aux >= 7 Then
            yPos = yPos + 30
            e.Graphics.DrawString(pro1f, prFontP, Brushes.Black, xPos + 15, yPos + 20)
            e.Graphics.DrawString(pro2f, prFontP, Brushes.Black, xPos + 165, yPos + 20)
            e.Graphics.DrawString(pro3f, prFontP, Brushes.Black, xPos + 365, yPos + 20)
            e.Graphics.DrawString(pro4f, prFontP, Brushes.Black, xPos + 565, yPos + 20)
            e.Graphics.DrawString(total1f, prFontP, Brushes.Black, xPos + 715, yPos + 20)
        End If
        If aux >= 8 Then
            yPos = yPos + 30
            e.Graphics.DrawString(pro1g, prFontP, Brushes.Black, xPos + 15, yPos + 20)
            e.Graphics.DrawString(pro2g, prFontP, Brushes.Black, xPos + 165, yPos + 20)
            e.Graphics.DrawString(pro3g, prFontP, Brushes.Black, xPos + 365, yPos + 20)
            e.Graphics.DrawString(pro4g, prFontP, Brushes.Black, xPos + 565, yPos + 20)
            e.Graphics.DrawString(total1g, prFontP, Brushes.Black, xPos + 715, yPos + 20)
        End If
        If aux >= 9 Then
            yPos = yPos + 30
            e.Graphics.DrawString(pro1h, prFontP, Brushes.Black, xPos + 15, yPos + 20)
            e.Graphics.DrawString(pro2h, prFontP, Brushes.Black, xPos + 165, yPos + 20)
            e.Graphics.DrawString(pro3h, prFontP, Brushes.Black, xPos + 365, yPos + 20)
            e.Graphics.DrawString(pro4h, prFontP, Brushes.Black, xPos + 565, yPos + 20)
            e.Graphics.DrawString(total1h, prFontP, Brushes.Black, xPos + 715, yPos + 20)
        End If

        yPos = yPos + 30
        e.Graphics.DrawString(totalx, prFontP, Brushes.Black, xPos + 565, yPos + 20)
        Dim totalprint As String
        totalprint = "$" + CStr(totalr)
        e.Graphics.DrawString(totalprint, prFontP, Brushes.Black, xPos + 715, yPos + 20)

        ' indicamos que ya no hay nada más que imprimir
        ' (el valor predeterminado de esta propiedad es False)

        e.HasMorePages = False
    End Sub

    Private Sub elm1_Click(sender As Object, e As EventArgs) Handles elm1.Click
        cmd = conexion.CreateCommand
        cmd.CommandText = "DELETE FROM carrito WHERE Nombre_Medicamento = '" & NamePro1.Text & "'"
        cmd.ExecuteNonQuery()
        MsgBox("Producto eliminado")
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        NamePro1.Visible = False
        txtPro1.Visible = False
        CostPro1.Visible = False
        imgPro1.Visible = False
        cantpor1.Visible = False
        cant1.Visible = False
        elm1.Visible = False
        cargarproducto1()
        Me.Close()
        Form1.Show()

    End Sub

    Private Sub elm2_Click(sender As Object, e As EventArgs) Handles elm2.Click
        cmd = conexion.CreateCommand
        cmd.CommandText = "DELETE FROM carrito WHERE Nombre_Medicamento = '" & Label10.Text & "'"
        cmd.ExecuteNonQuery()
        MsgBox("Producto eliminado")
        PictureBox7.Visible = False
        PictureBox6.Visible = False
        Label10.Visible = False
        Label8.Visible = False
        Label7.Visible = False
        PictureBox5.Visible = False
        Label6.Visible = False
        Label5.Visible = False
        elm2.Visible = False
        cargarproducto1()
        Me.Close()
        Form1.Show()

    End Sub

    Private Sub elm3_Click(sender As Object, e As EventArgs) Handles elm3.Click
        cmd = conexion.CreateCommand
        cmd.CommandText = "DELETE FROM carrito WHERE Nombre_Medicamento = '" & Label20.Text & "'"
        cmd.ExecuteNonQuery()
        MsgBox("Producto eliminado")
        PictureBox13.Visible = False
        PictureBox12.Visible = False
        Label20.Visible = False
        Label18.Visible = False
        Label16.Visible = False
        PictureBox11.Visible = False
        Label17.Visible = False
        Label41.Visible = False
        elm3.Visible = False
        cargarproducto1()
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub elm4_Click(sender As Object, e As EventArgs) Handles elm4.Click
        cmd = conexion.CreateCommand
        cmd.CommandText = "DELETE FROM carrito WHERE Nombre_Medicamento = '" & Label15.Text & "'"
        cmd.ExecuteNonQuery()
        MsgBox("Producto eliminado")
        PictureBox10.Visible = True
        PictureBox9.Visible = True
        Label15.Visible = True
        Label12.Visible = True
        Label42.Visible = True
        PictureBox8.Visible = True
        Label13.Visible = True
        Label11.Visible = True
        elm4.Visible = True
        cargarproducto1()
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub elm5_Click(sender As Object, e As EventArgs) Handles elm5.Click
        cmd = conexion.CreateCommand
        cmd.CommandText = "DELETE FROM carrito WHERE Nombre_Medicamento = '" & Label40.Text & "'"
        cmd.ExecuteNonQuery()
        MsgBox("Producto eliminado")
        PictureBox25.Visible = False
        PictureBox24.Visible = False
        Label40.Visible = False
        Label37.Visible = False
        Label46.Visible = False
        PictureBox23.Visible = False
        Label38.Visible = False
        Label36.Visible = False
        elm5.Visible = False
        cargarproducto1()
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub elm6_Click(sender As Object, e As EventArgs) Handles elm6.Click
        cmd = conexion.CreateCommand
        cmd.CommandText = "DELETE FROM carrito WHERE Nombre_Medicamento = '" & Label35.Text & "'"
        cmd.ExecuteNonQuery()
        MsgBox("Producto eliminado")
        PictureBox22.Visible = False
        PictureBox21.Visible = False
        Label35.Visible = False
        Label32.Visible = False
        Label45.Visible = False
        PictureBox20.Visible = False
        Label33.Visible = False
        Label31.Visible = False
        elm6.Visible = False
        cargarproducto1()
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub elm7_Click(sender As Object, e As EventArgs) Handles elm7.Click
        cmd = conexion.CreateCommand
        cmd.CommandText = "DELETE FROM carrito WHERE Nombre_Medicamento = '" & Label30.Text & "'"
        cmd.ExecuteNonQuery()
        MsgBox("Producto eliminado")
        PictureBox19.Visible = False
        PictureBox18.Visible = False
        Label30.Visible = False
        Label27.Visible = False
        Label44.Visible = False
        PictureBox17.Visible = False
        Label28.Visible = False
        Label26.Visible = False
        elm7.Visible = False
        cargarproducto1()
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub elm8_Click(sender As Object, e As EventArgs) Handles elm8.Click
        cmd = conexion.CreateCommand
        cmd.CommandText = "DELETE FROM carrito WHERE Nombre_Medicamento = '" & Label25.Text & "'"
        cmd.ExecuteNonQuery()
        MsgBox("Producto eliminado")
        PictureBox16.Visible = False
        PictureBox15.Visible = False
        Label25.Visible = False
        Label22.Visible = False
        Label43.Visible = False
        PictureBox14.Visible = False
        Label23.Visible = False
        Label21.Visible = False
        elm8.Visible = False
        cargarproducto1()
        Me.Close()
        Form1.Show()
    End Sub
End Class