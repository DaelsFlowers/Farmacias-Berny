<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarMedicamento
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarMedicamento))
        Me.lblAR = New System.Windows.Forms.Label()
        Me.txtnom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtdes = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcost = New System.Windows.Forms.TextBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.GridMedicamentos = New System.Windows.Forms.DataGridView()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.rimg2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.auxcodigo = New System.Windows.Forms.TextBox()
        CType(Me.GridMedicamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rimg2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAR
        '
        resources.ApplyResources(Me.lblAR, "lblAR")
        Me.lblAR.BackColor = System.Drawing.SystemColors.Control
        Me.lblAR.Name = "lblAR"
        Me.lblAR.Tag = "Registrar"
        '
        'txtnom
        '
        Me.txtnom.BackColor = System.Drawing.SystemColors.Control
        Me.txtnom.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.txtnom, "txtnom")
        Me.txtnom.Name = "txtnom"
        Me.txtnom.Tag = "Registrar"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label1.Name = "Label1"
        Me.Label1.Tag = "Registrar"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Name = "Label2"
        Me.Label2.Tag = "Registrar"
        '
        'txtdes
        '
        Me.txtdes.BackColor = System.Drawing.Color.White
        Me.txtdes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.txtdes, "txtdes")
        Me.txtdes.Name = "txtdes"
        Me.txtdes.Tag = "Registrar"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Name = "Label3"
        Me.Label3.Tag = "Registrar"
        '
        'txtcost
        '
        Me.txtcost.BackColor = System.Drawing.SystemColors.Control
        Me.txtcost.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.txtcost, "txtcost")
        Me.txtcost.Name = "txtcost"
        Me.txtcost.Tag = "Registrar"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.btnRegistrar, "btnRegistrar")
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.TabStop = False
        Me.btnRegistrar.Tag = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Name = "Label4"
        Me.Label4.Tag = "Registrar"
        '
        'txtcodigo
        '
        Me.txtcodigo.BackColor = System.Drawing.SystemColors.Control
        Me.txtcodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.txtcodigo, "txtcodigo")
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Tag = "Registrar"
        '
        'GridMedicamentos
        '
        Me.GridMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        resources.ApplyResources(Me.GridMedicamentos, "GridMedicamentos")
        Me.GridMedicamentos.Name = "GridMedicamentos"
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.PictureBox6, "PictureBox6")
        Me.PictureBox6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox6.Image = Global.FarmaciasBerny.My.Resources.Resources.btneliminar
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.FarmaciasBerny.My.Resources.Resources.line
        resources.ApplyResources(Me.PictureBox5, "PictureBox5")
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Tag = "Registrar"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.PictureBox4, "PictureBox4")
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = Global.FarmaciasBerny.My.Resources.Resources.btnAgregar
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.FarmaciasBerny.My.Resources.Resources.line
        resources.ApplyResources(Me.PictureBox3, "PictureBox3")
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Tag = "Registrar"
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.PictureBox2, "PictureBox2")
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.TabStop = False
        '
        'rimg2
        '
        Me.rimg2.Image = Global.FarmaciasBerny.My.Resources.Resources.line
        resources.ApplyResources(Me.rimg2, "rimg2")
        Me.rimg2.Name = "rimg2"
        Me.rimg2.TabStop = False
        Me.rimg2.Tag = "Registrar"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FarmaciasBerny.My.Resources.Resources.bannergreen
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'auxcodigo
        '
        Me.auxcodigo.BackColor = System.Drawing.SystemColors.Control
        Me.auxcodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.auxcodigo, "auxcodigo")
        Me.auxcodigo.Name = "auxcodigo"
        Me.auxcodigo.Tag = "Registrar"
        '
        'AgregarMedicamento
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        resources.ApplyResources(Me, "$this")
        Me.Controls.Add(Me.auxcodigo)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.GridMedicamentos)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtcodigo)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtcost)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtdes)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rimg2)
        Me.Controls.Add(Me.lblAR)
        Me.Controls.Add(Me.txtnom)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.Name = "AgregarMedicamento"
        CType(Me.GridMedicamentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rimg2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents rimg2 As PictureBox
    Friend WithEvents lblAR As Label
    Friend WithEvents txtnom As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtdes As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtcost As TextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents GridMedicamentos As DataGridView
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents auxcodigo As TextBox
End Class
