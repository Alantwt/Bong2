<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ong_txt = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Panel_inicio = New System.Windows.Forms.Panel()
        Me.Panel_crear = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_crear_nombre = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_crear_email = New System.Windows.Forms.TextBox()
        Me.txt_crear_pass = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_crear_pass2 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CheckBox_see_password = New System.Windows.Forms.CheckBox()
        Me.Panel_inicio.SuspendLayout()
        Me.Panel_crear.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ong_txt
        '
        Me.ong_txt.AutoSize = True
        Me.ong_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ong_txt.ForeColor = System.Drawing.SystemColors.Highlight
        Me.ong_txt.Location = New System.Drawing.Point(388, 249)
        Me.ong_txt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ong_txt.Name = "ong_txt"
        Me.ong_txt.Size = New System.Drawing.Size(0, 217)
        Me.ong_txt.TabIndex = 1
        '
        'txt_email
        '
        Me.txt_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.Location = New System.Drawing.Point(42, 656)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(968, 44)
        Me.txt_email.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 618)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(282, 37)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Correo Electronico"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 728)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 37)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Contrasena"
        '
        'txt_pass
        '
        Me.txt_pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pass.Location = New System.Drawing.Point(42, 768)
        Me.txt_pass.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.Size = New System.Drawing.Size(968, 44)
        Me.txt_pass.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(744, 878)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(266, 81)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Iniciar sesion"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(830, 66)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(178, 60)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Crear cuenta"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(54, 833)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(230, 29)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "Mostrar contrasena"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Panel_inicio
        '
        Me.Panel_inicio.Controls.Add(Me.ong_txt)
        Me.Panel_inicio.Controls.Add(Me.PictureBox1)
        Me.Panel_inicio.Controls.Add(Me.CheckBox1)
        Me.Panel_inicio.Controls.Add(Me.Button2)
        Me.Panel_inicio.Controls.Add(Me.txt_email)
        Me.Panel_inicio.Controls.Add(Me.Button1)
        Me.Panel_inicio.Controls.Add(Me.Label2)
        Me.Panel_inicio.Controls.Add(Me.Label3)
        Me.Panel_inicio.Controls.Add(Me.txt_pass)
        Me.Panel_inicio.Location = New System.Drawing.Point(12, 12)
        Me.Panel_inicio.Name = "Panel_inicio"
        Me.Panel_inicio.Size = New System.Drawing.Size(1053, 1007)
        Me.Panel_inicio.TabIndex = 9
        '
        'Panel_crear
        '
        Me.Panel_crear.Controls.Add(Me.CheckBox_see_password)
        Me.Panel_crear.Controls.Add(Me.Label10)
        Me.Panel_crear.Controls.Add(Me.Label9)
        Me.Panel_crear.Controls.Add(Me.Label8)
        Me.Panel_crear.Controls.Add(Me.txt_crear_nombre)
        Me.Panel_crear.Controls.Add(Me.Label6)
        Me.Panel_crear.Controls.Add(Me.Label7)
        Me.Panel_crear.Controls.Add(Me.txt_crear_email)
        Me.Panel_crear.Controls.Add(Me.txt_crear_pass)
        Me.Panel_crear.Controls.Add(Me.Button3)
        Me.Panel_crear.Controls.Add(Me.Label4)
        Me.Panel_crear.Controls.Add(Me.Label5)
        Me.Panel_crear.Controls.Add(Me.txt_crear_pass2)
        Me.Panel_crear.Location = New System.Drawing.Point(12, 12)
        Me.Panel_crear.Name = "Panel_crear"
        Me.Panel_crear.Size = New System.Drawing.Size(1131, 1041)
        Me.Panel_crear.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label10.Location = New System.Drawing.Point(44, 903)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(211, 31)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Ya tengo cuenta"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label9.Location = New System.Drawing.Point(227, 249)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(567, 37)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Una cuenta en Bong, seria maravilloso"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 55.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label8.Location = New System.Drawing.Point(26, 66)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(964, 166)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Crear Cuenta"
        '
        'txt_crear_nombre
        '
        Me.txt_crear_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_crear_nombre.Location = New System.Drawing.Point(39, 443)
        Me.txt_crear_nombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_crear_nombre.Name = "txt_crear_nombre"
        Me.txt_crear_nombre.Size = New System.Drawing.Size(968, 44)
        Me.txt_crear_nombre.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(43, 402)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 37)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Nombre"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(43, 512)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(282, 37)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Correo Electronico"
        '
        'txt_crear_email
        '
        Me.txt_crear_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_crear_email.Location = New System.Drawing.Point(39, 552)
        Me.txt_crear_email.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_crear_email.Name = "txt_crear_email"
        Me.txt_crear_email.Size = New System.Drawing.Size(968, 44)
        Me.txt_crear_email.TabIndex = 2
        '
        'txt_crear_pass
        '
        Me.txt_crear_pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_crear_pass.Location = New System.Drawing.Point(39, 656)
        Me.txt_crear_pass.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_crear_pass.Name = "txt_crear_pass"
        Me.txt_crear_pass.Size = New System.Drawing.Size(968, 44)
        Me.txt_crear_pass.TabIndex = 3
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button3.Location = New System.Drawing.Point(741, 878)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(266, 81)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Crear cuenta"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(43, 615)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(183, 37)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Contrasena"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(43, 725)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(310, 37)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Verificar Contrasena"
        '
        'txt_crear_pass2
        '
        Me.txt_crear_pass2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_crear_pass2.Location = New System.Drawing.Point(39, 765)
        Me.txt_crear_pass2.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_crear_pass2.Name = "txt_crear_pass2"
        Me.txt_crear_pass2.Size = New System.Drawing.Size(968, 44)
        Me.txt_crear_pass2.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Bong_2._0.My.Resources.Resources.bong_logo2
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.InitialImage = Global.Bong_2._0.My.Resources.Resources.bong_logo2
        Me.PictureBox1.Location = New System.Drawing.Point(42, 66)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(500, 483)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'CheckBox_see_password
        '
        Me.CheckBox_see_password.AutoSize = True
        Me.CheckBox_see_password.Location = New System.Drawing.Point(39, 820)
        Me.CheckBox_see_password.Name = "CheckBox_see_password"
        Me.CheckBox_see_password.Size = New System.Drawing.Size(190, 29)
        Me.CheckBox_see_password.TabIndex = 5
        Me.CheckBox_see_password.Text = "Ver contrasena"
        Me.CheckBox_see_password.UseVisualStyleBackColor = True
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(2367, 1342)
        Me.Controls.Add(Me.Panel_crear)
        Me.Controls.Add(Me.Panel_inicio)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Inicio"
        Me.Text = "Inicio"
        Me.Panel_inicio.ResumeLayout(False)
        Me.Panel_inicio.PerformLayout()
        Me.Panel_crear.ResumeLayout(False)
        Me.Panel_crear.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ong_txt As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_pass As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Panel_inicio As Panel
    Friend WithEvents Panel_crear As Panel
    Friend WithEvents txt_crear_nombre As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_crear_email As TextBox
    Friend WithEvents txt_crear_pass As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_crear_pass2 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CheckBox_see_password As CheckBox
End Class
