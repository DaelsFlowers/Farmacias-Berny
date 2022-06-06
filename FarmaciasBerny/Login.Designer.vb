<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.lblR = New System.Windows.Forms.Label()
        Me.btnTime = New System.Windows.Forms.DateTimePicker()
        Me.rimg3 = New System.Windows.Forms.PictureBox()
        Me.rimg6 = New System.Windows.Forms.PictureBox()
        Me.rimg4 = New System.Windows.Forms.PictureBox()
        Me.rimg2 = New System.Windows.Forms.PictureBox()
        Me.rimg7 = New System.Windows.Forms.PictureBox()
        Me.rimg1 = New System.Windows.Forms.PictureBox()
        Me.lblCR = New System.Windows.Forms.Label()
        Me.RtxtPass = New System.Windows.Forms.TextBox()
        Me.lblTR = New System.Windows.Forms.Label()
        Me.RtxtCorr = New System.Windows.Forms.TextBox()
        Me.lblCCR = New System.Windows.Forms.Label()
        Me.RtxtPassConf = New System.Windows.Forms.TextBox()
        Me.lblAR = New System.Windows.Forms.Label()
        Me.RtxtApellido = New System.Windows.Forms.TextBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.RtxtFe = New System.Windows.Forms.TextBox()
        Me.lblNR = New System.Windows.Forms.Label()
        Me.Rtxtuser = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LtxtUsu = New System.Windows.Forms.TextBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Ltxtpass = New System.Windows.Forms.TextBox()
        Me.btnEntrar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RtxtTel = New System.Windows.Forms.TextBox()
        Me.gridusuarios = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        CType(Me.rimg3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rimg6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rimg4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rimg2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rimg7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rimg1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridusuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblR
        '
        resources.ApplyResources(Me.lblR, "lblR")
        Me.lblR.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblR.Name = "lblR"
        Me.lblR.Tag = "Registrar"
        '
        'btnTime
        '
        Me.btnTime.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        resources.ApplyResources(Me.btnTime, "btnTime")
        Me.btnTime.MaxDate = New Date(2005, 1, 1, 0, 0, 0, 0)
        Me.btnTime.Name = "btnTime"
        Me.btnTime.Tag = "Registrar"
        Me.btnTime.Value = New Date(2005, 1, 1, 0, 0, 0, 0)
        '
        'rimg3
        '
        Me.rimg3.Image = Global.FarmaciasBerny.My.Resources.Resources.line
        resources.ApplyResources(Me.rimg3, "rimg3")
        Me.rimg3.Name = "rimg3"
        Me.rimg3.TabStop = False
        Me.rimg3.Tag = "Registrar"
        '
        'rimg6
        '
        Me.rimg6.Image = Global.FarmaciasBerny.My.Resources.Resources.line
        resources.ApplyResources(Me.rimg6, "rimg6")
        Me.rimg6.Name = "rimg6"
        Me.rimg6.TabStop = False
        Me.rimg6.Tag = "Registrar"
        '
        'rimg4
        '
        Me.rimg4.Image = Global.FarmaciasBerny.My.Resources.Resources.line
        resources.ApplyResources(Me.rimg4, "rimg4")
        Me.rimg4.Name = "rimg4"
        Me.rimg4.TabStop = False
        Me.rimg4.Tag = "Registrar"
        '
        'rimg2
        '
        Me.rimg2.Image = Global.FarmaciasBerny.My.Resources.Resources.line
        resources.ApplyResources(Me.rimg2, "rimg2")
        Me.rimg2.Name = "rimg2"
        Me.rimg2.TabStop = False
        Me.rimg2.Tag = "Registrar"
        '
        'rimg7
        '
        Me.rimg7.Image = Global.FarmaciasBerny.My.Resources.Resources.line
        resources.ApplyResources(Me.rimg7, "rimg7")
        Me.rimg7.Name = "rimg7"
        Me.rimg7.TabStop = False
        Me.rimg7.Tag = "Registrar"
        '
        'rimg1
        '
        Me.rimg1.Image = Global.FarmaciasBerny.My.Resources.Resources.line
        resources.ApplyResources(Me.rimg1, "rimg1")
        Me.rimg1.Name = "rimg1"
        Me.rimg1.TabStop = False
        Me.rimg1.Tag = "Registrar"
        '
        'lblCR
        '
        resources.ApplyResources(Me.lblCR, "lblCR")
        Me.lblCR.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblCR.Name = "lblCR"
        Me.lblCR.Tag = "Registrar"
        '
        'RtxtPass
        '
        Me.RtxtPass.BackColor = System.Drawing.SystemColors.HighlightText
        Me.RtxtPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.RtxtPass, "RtxtPass")
        Me.RtxtPass.Name = "RtxtPass"
        Me.RtxtPass.Tag = "Registrar"
        '
        'lblTR
        '
        resources.ApplyResources(Me.lblTR, "lblTR")
        Me.lblTR.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblTR.Name = "lblTR"
        Me.lblTR.Tag = "Registrar"
        '
        'RtxtCorr
        '
        Me.RtxtCorr.BackColor = System.Drawing.SystemColors.HighlightText
        Me.RtxtCorr.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.RtxtCorr, "RtxtCorr")
        Me.RtxtCorr.Name = "RtxtCorr"
        Me.RtxtCorr.Tag = "Registrar"
        '
        'lblCCR
        '
        resources.ApplyResources(Me.lblCCR, "lblCCR")
        Me.lblCCR.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblCCR.Name = "lblCCR"
        Me.lblCCR.Tag = "Registrar"
        '
        'RtxtPassConf
        '
        Me.RtxtPassConf.BackColor = System.Drawing.SystemColors.HighlightText
        Me.RtxtPassConf.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.RtxtPassConf, "RtxtPassConf")
        Me.RtxtPassConf.Name = "RtxtPassConf"
        Me.RtxtPassConf.Tag = "Registrar"
        '
        'lblAR
        '
        resources.ApplyResources(Me.lblAR, "lblAR")
        Me.lblAR.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblAR.Name = "lblAR"
        Me.lblAR.Tag = "Registrar"
        '
        'RtxtApellido
        '
        Me.RtxtApellido.BackColor = System.Drawing.SystemColors.HighlightText
        Me.RtxtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.RtxtApellido, "RtxtApellido")
        Me.RtxtApellido.Name = "RtxtApellido"
        Me.RtxtApellido.Tag = "Registrar"
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
        'RtxtFe
        '
        Me.RtxtFe.BackColor = System.Drawing.SystemColors.HighlightText
        Me.RtxtFe.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.RtxtFe, "RtxtFe")
        Me.RtxtFe.Name = "RtxtFe"
        Me.RtxtFe.Tag = "Registrar"
        '
        'lblNR
        '
        resources.ApplyResources(Me.lblNR, "lblNR")
        Me.lblNR.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblNR.Name = "lblNR"
        Me.lblNR.Tag = "Registrar"
        '
        'Rtxtuser
        '
        Me.Rtxtuser.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Rtxtuser.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.Rtxtuser, "Rtxtuser")
        Me.Rtxtuser.Name = "Rtxtuser"
        Me.Rtxtuser.Tag = "Registrar"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.FarmaciasBerny.My.Resources.Resources.bannerlogin
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.FarmaciasBerny.My.Resources.Resources.bannerasdf
        resources.ApplyResources(Me.PictureBox3, "PictureBox3")
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.TabStop = False
        '
        'PictureBox5
        '
        resources.ApplyResources(Me.PictureBox5, "PictureBox5")
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Tag = "Registrar"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Name = "Label1"
        Me.Label1.Tag = "Registrar"
        '
        'LtxtUsu
        '
        Me.LtxtUsu.BackColor = System.Drawing.Color.White
        Me.LtxtUsu.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.LtxtUsu, "LtxtUsu")
        Me.LtxtUsu.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LtxtUsu.Name = "LtxtUsu"
        Me.LtxtUsu.Tag = "Registrar"
        '
        'PictureBox6
        '
        resources.ApplyResources(Me.PictureBox6, "PictureBox6")
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.TabStop = False
        Me.PictureBox6.Tag = "Registrar"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Name = "Label2"
        Me.Label2.Tag = "Registrar"
        '
        'Ltxtpass
        '
        Me.Ltxtpass.BackColor = System.Drawing.Color.White
        Me.Ltxtpass.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.Ltxtpass, "Ltxtpass")
        Me.Ltxtpass.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Ltxtpass.Name = "Ltxtpass"
        Me.Ltxtpass.Tag = "Registrar"
        '
        'btnEntrar
        '
        Me.btnEntrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEntrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed
        Me.btnEntrar.FlatAppearance.BorderSize = 10
        resources.ApplyResources(Me.btnEntrar, "btnEntrar")
        Me.btnEntrar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Tag = "Registrar"
        Me.btnEntrar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Name = "Label3"
        Me.Label3.Tag = "Registrar"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label4.Name = "Label4"
        Me.Label4.Tag = "Registrar"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.FarmaciasBerny.My.Resources.Resources.line
        resources.ApplyResources(Me.PictureBox2, "PictureBox2")
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Tag = "Registrar"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label5.Name = "Label5"
        Me.Label5.Tag = "Registrar"
        '
        'RtxtTel
        '
        Me.RtxtTel.BackColor = System.Drawing.SystemColors.HighlightText
        Me.RtxtTel.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.RtxtTel, "RtxtTel")
        Me.RtxtTel.Name = "RtxtTel"
        Me.RtxtTel.Tag = "Registrar"
        '
        'gridusuarios
        '
        Me.gridusuarios.AllowUserToAddRows = False
        Me.gridusuarios.AllowUserToDeleteRows = False
        Me.gridusuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        resources.ApplyResources(Me.gridusuarios, "gridusuarios")
        Me.gridusuarios.Name = "gridusuarios"
        Me.gridusuarios.ReadOnly = True
        '
        'TextBox1
        '
        resources.ApplyResources(Me.TextBox1, "TextBox1")
        Me.TextBox1.Name = "TextBox1"
        '
        'TextBox2
        '
        resources.ApplyResources(Me.TextBox2, "TextBox2")
        Me.TextBox2.Name = "TextBox2"
        '
        'FormLogin
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.FarmaciasBerny.My.Resources.Resources.background2
        resources.ApplyResources(Me, "$this")
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.gridusuarios)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RtxtTel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnEntrar)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Ltxtpass)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LtxtUsu)
        Me.Controls.Add(Me.lblR)
        Me.Controls.Add(Me.btnTime)
        Me.Controls.Add(Me.rimg3)
        Me.Controls.Add(Me.rimg6)
        Me.Controls.Add(Me.rimg4)
        Me.Controls.Add(Me.rimg2)
        Me.Controls.Add(Me.rimg7)
        Me.Controls.Add(Me.rimg1)
        Me.Controls.Add(Me.lblCR)
        Me.Controls.Add(Me.RtxtPass)
        Me.Controls.Add(Me.lblTR)
        Me.Controls.Add(Me.RtxtCorr)
        Me.Controls.Add(Me.lblCCR)
        Me.Controls.Add(Me.RtxtPassConf)
        Me.Controls.Add(Me.lblAR)
        Me.Controls.Add(Me.RtxtApellido)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.RtxtFe)
        Me.Controls.Add(Me.lblNR)
        Me.Controls.Add(Me.Rtxtuser)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.DoubleBuffered = True
        Me.Name = "FormLogin"
        CType(Me.rimg3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rimg6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rimg4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rimg2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rimg7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rimg1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridusuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DirectoryEntry1 As DirectoryServices.DirectoryEntry
    Friend WithEvents lblR As Label
    Friend WithEvents btnTime As DateTimePicker
    Friend WithEvents rimg3 As PictureBox
    Friend WithEvents rimg6 As PictureBox
    Friend WithEvents rimg4 As PictureBox
    Friend WithEvents rimg2 As PictureBox
    Friend WithEvents rimg7 As PictureBox
    Friend WithEvents rimg1 As PictureBox
    Friend WithEvents lblCR As Label
    Friend WithEvents RtxtPass As TextBox
    Friend WithEvents lblTR As Label
    Friend WithEvents RtxtCorr As TextBox
    Friend WithEvents lblCCR As Label
    Friend WithEvents RtxtPassConf As TextBox
    Friend WithEvents lblAR As Label
    Friend WithEvents RtxtApellido As TextBox
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents RtxtFe As TextBox
    Friend WithEvents lblNR As Label
    Friend WithEvents Rtxtuser As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LtxtUsu As TextBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Ltxtpass As TextBox
    Friend WithEvents btnEntrar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents UsuariosBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents UsuariosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents RtxtTel As TextBox
    Friend WithEvents gridusuarios As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
