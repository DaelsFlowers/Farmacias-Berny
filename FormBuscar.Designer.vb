<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBuscar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBuscar))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.CostPro1 = New System.Windows.Forms.Label()
        Me.txtPro1 = New System.Windows.Forms.Label()
        Me.InfPro1 = New System.Windows.Forms.Label()
        Me.NamePro1 = New System.Windows.Forms.Label()
        Me.imgPro1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnagregar1 = New System.Windows.Forms.PictureBox()
        Me.gridcarrito = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPro1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnagregar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridcarrito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("Montserrat", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(1184, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 40)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "SALIR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(878, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 40)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "CARRITO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(316, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 40)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "BUSCAR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(63, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 40)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "INICIO"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.FarmaciasBerny.My.Resources.Resources.iconobig
        Me.PictureBox2.Location = New System.Drawing.Point(624, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(124, 118)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FarmaciasBerny.My.Resources.Resources.bannergreen
        Me.PictureBox1.Location = New System.Drawing.Point(-2, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1374, 71)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'txtBuscar
        '
        Me.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuscar.Location = New System.Drawing.Point(361, 199)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(639, 20)
        Me.txtBuscar.TabIndex = 12
        '
        'CostPro1
        '
        Me.CostPro1.AutoSize = True
        Me.CostPro1.BackColor = System.Drawing.Color.White
        Me.CostPro1.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CostPro1.Location = New System.Drawing.Point(669, 384)
        Me.CostPro1.Name = "CostPro1"
        Me.CostPro1.Size = New System.Drawing.Size(63, 18)
        Me.CostPro1.TabIndex = 31
        Me.CostPro1.Text = "CostPro1"
        Me.CostPro1.Visible = False
        '
        'txtPro1
        '
        Me.txtPro1.AutoSize = True
        Me.txtPro1.BackColor = System.Drawing.Color.White
        Me.txtPro1.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPro1.Location = New System.Drawing.Point(580, 372)
        Me.txtPro1.Name = "txtPro1"
        Me.txtPro1.Size = New System.Drawing.Size(77, 36)
        Me.txtPro1.TabIndex = 30
        Me.txtPro1.Text = "Precio Por " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Unidad"
        Me.txtPro1.Visible = False
        '
        'InfPro1
        '
        Me.InfPro1.AutoSize = True
        Me.InfPro1.BackColor = System.Drawing.Color.White
        Me.InfPro1.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfPro1.Location = New System.Drawing.Point(579, 329)
        Me.InfPro1.MaximumSize = New System.Drawing.Size(335, 36)
        Me.InfPro1.Name = "InfPro1"
        Me.InfPro1.Size = New System.Drawing.Size(47, 18)
        Me.InfPro1.TabIndex = 29
        Me.InfPro1.Text = "InfPro"
        Me.InfPro1.Visible = False
        '
        'NamePro1
        '
        Me.NamePro1.AutoSize = True
        Me.NamePro1.BackColor = System.Drawing.Color.White
        Me.NamePro1.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NamePro1.Location = New System.Drawing.Point(579, 301)
        Me.NamePro1.Name = "NamePro1"
        Me.NamePro1.Size = New System.Drawing.Size(100, 22)
        Me.NamePro1.TabIndex = 28
        Me.NamePro1.Text = "NamePro1"
        Me.NamePro1.Visible = False
        '
        'imgPro1
        '
        Me.imgPro1.Location = New System.Drawing.Point(380, 297)
        Me.imgPro1.Name = "imgPro1"
        Me.imgPro1.Size = New System.Drawing.Size(191, 116)
        Me.imgPro1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgPro1.TabIndex = 27
        Me.imgPro1.TabStop = False
        Me.imgPro1.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.FarmaciasBerny.My.Resources.Resources.marco
        Me.PictureBox4.Location = New System.Drawing.Point(379, 296)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(193, 118)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 34
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.FarmaciasBerny.My.Resources.Resources.txtboxcarr2
        Me.PictureBox3.Location = New System.Drawing.Point(571, 296)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(421, 118)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 33
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'btnagregar1
        '
        Me.btnagregar1.BackColor = System.Drawing.Color.Transparent
        Me.btnagregar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnagregar1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnagregar1.Image = Global.FarmaciasBerny.My.Resources.Resources.btnAgregar
        Me.btnagregar1.Location = New System.Drawing.Point(925, 339)
        Me.btnagregar1.Name = "btnagregar1"
        Me.btnagregar1.Size = New System.Drawing.Size(45, 40)
        Me.btnagregar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnagregar1.TabIndex = 35
        Me.btnagregar1.TabStop = False
        Me.btnagregar1.Visible = False
        '
        'gridcarrito
        '
        Me.gridcarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridcarrito.Location = New System.Drawing.Point(84, 174)
        Me.gridcarrito.Name = "gridcarrito"
        Me.gridcarrito.Size = New System.Drawing.Size(220, 149)
        Me.gridcarrito.TabIndex = 36
        Me.gridcarrito.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(376, 262)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 22)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Label6"
        Me.Label6.Visible = False
        '
        'FormBuscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 711)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.gridcarrito)
        Me.Controls.Add(Me.btnagregar1)
        Me.Controls.Add(Me.CostPro1)
        Me.Controls.Add(Me.txtPro1)
        Me.Controls.Add(Me.InfPro1)
        Me.Controls.Add(Me.NamePro1)
        Me.Controls.Add(Me.imgPro1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormBuscar"
        Me.Text = "Farmacias Berny"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPro1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnagregar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridcarrito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents CostPro1 As Label
    Friend WithEvents txtPro1 As Label
    Friend WithEvents InfPro1 As Label
    Friend WithEvents NamePro1 As Label
    Friend WithEvents imgPro1 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnagregar1 As PictureBox
    Friend WithEvents gridcarrito As DataGridView
    Friend WithEvents Label6 As Label
End Class
