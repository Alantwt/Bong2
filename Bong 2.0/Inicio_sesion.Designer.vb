<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio_sesion
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
        PictureBox1 = New PictureBox()
        ong_label = New Label()
        Label1 = New Label()
        TextBox_correo = New TextBox()
        Label2 = New Label()
        TextBox_pass = New TextBox()
        Button1 = New Button()
        CheckBox1 = New CheckBox()
        Btn_crear = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.bong_logo2
        PictureBox1.Location = New Point(151, 45)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(448, 444)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' ong_label
        ' 
        ong_label.AutoSize = True
        ong_label.BackColor = Color.Transparent
        ong_label.Font = New Font("Segoe UI Black", 72F, FontStyle.Bold, GraphicsUnit.Point)
        ong_label.ForeColor = SystemColors.MenuHighlight
        ong_label.ImageAlign = ContentAlignment.MiddleLeft
        ong_label.Location = New Point(472, 157)
        ong_label.Name = "ong_label"
        ong_label.Size = New Size(0, 254)
        ong_label.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(159, 539)
        Label1.Name = "Label1"
        Label1.Size = New Size(298, 45)
        Label1.TabIndex = 2
        Label1.Text = "Correo electronico"
        ' 
        ' TextBox_correo
        ' 
        TextBox_correo.BorderStyle = BorderStyle.FixedSingle
        TextBox_correo.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_correo.Location = New Point(164, 598)
        TextBox_correo.Name = "TextBox_correo"
        TextBox_correo.Size = New Size(898, 50)
        TextBox_correo.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(164, 680)
        Label2.Name = "Label2"
        Label2.Size = New Size(188, 45)
        Label2.TabIndex = 4
        Label2.Text = "Contrasena"
        ' 
        ' TextBox_pass
        ' 
        TextBox_pass.BorderStyle = BorderStyle.FixedSingle
        TextBox_pass.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_pass.Location = New Point(159, 728)
        TextBox_pass.Name = "TextBox_pass"
        TextBox_pass.Size = New Size(898, 50)
        TextBox_pass.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.MenuHighlight
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(835, 840)
        Button1.Name = "Button1"
        Button1.Size = New Size(222, 59)
        Button1.TabIndex = 6
        Button1.Text = "Iniciar Sesion"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(159, 796)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(203, 36)
        CheckBox1.TabIndex = 7
        CheckBox1.Text = "Ver contrasena"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Btn_crear
        ' 
        Btn_crear.BackColor = SystemColors.GradientActiveCaption
        Btn_crear.FlatStyle = FlatStyle.Flat
        Btn_crear.ForeColor = SystemColors.ButtonHighlight
        Btn_crear.Location = New Point(992, 12)
        Btn_crear.Name = "Btn_crear"
        Btn_crear.Size = New Size(196, 46)
        Btn_crear.TabIndex = 8
        Btn_crear.Text = "Crear cuenta"
        Btn_crear.UseVisualStyleBackColor = False
        ' 
        ' Inicio_sesion
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientInactiveCaption
        ClientSize = New Size(1214, 993)
        Controls.Add(Btn_crear)
        Controls.Add(CheckBox1)
        Controls.Add(Button1)
        Controls.Add(TextBox_pass)
        Controls.Add(Label2)
        Controls.Add(TextBox_correo)
        Controls.Add(Label1)
        Controls.Add(ong_label)
        Controls.Add(PictureBox1)
        Name = "Inicio_sesion"
        Text = "Inicio sesion"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ong_label As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_correo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_pass As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Btn_crear As Button
End Class
