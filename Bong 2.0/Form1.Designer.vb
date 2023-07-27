<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LogoBienvenida = New System.Windows.Forms.GroupBox()
        Me.LabelBievenida = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_plus = New System.Windows.Forms.Button()
        Me.TextBoxChat = New System.Windows.Forms.TextBox()
        Me.send_btn = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioBtn_creativo = New System.Windows.Forms.RadioButton()
        Me.RadioBtn_texto = New System.Windows.Forms.RadioButton()
        Me.ListBox_history = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListBox_favorito = New System.Windows.Forms.ListBox()
        Me.Panel1.SuspendLayout()
        Me.LogoBienvenida.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.LogoBienvenida)
        Me.Panel1.Location = New System.Drawing.Point(26, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1490, 1228)
        Me.Panel1.TabIndex = 0
        '
        'LogoBienvenida
        '
        Me.LogoBienvenida.Controls.Add(Me.LabelBievenida)
        Me.LogoBienvenida.Controls.Add(Me.Label4)
        Me.LogoBienvenida.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.LogoBienvenida.Location = New System.Drawing.Point(288, 504)
        Me.LogoBienvenida.Name = "LogoBienvenida"
        Me.LogoBienvenida.Size = New System.Drawing.Size(566, 212)
        Me.LogoBienvenida.TabIndex = 0
        Me.LogoBienvenida.TabStop = False
        '
        'LabelBievenida
        '
        Me.LabelBievenida.AutoSize = True
        Me.LabelBievenida.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBievenida.Location = New System.Drawing.Point(35, 53)
        Me.LabelBievenida.Name = "LabelBievenida"
        Me.LabelBievenida.Size = New System.Drawing.Size(0, 64)
        Me.LabelBievenida.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(502, 31)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Preguntame lo que quiera, y te respondo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Chats"
        '
        'Btn_plus
        '
        Me.Btn_plus.Image = Global.Bong_2._0.My.Resources.Resources.plus_icon
        Me.Btn_plus.Location = New System.Drawing.Point(26, 1282)
        Me.Btn_plus.Name = "Btn_plus"
        Me.Btn_plus.Size = New System.Drawing.Size(61, 52)
        Me.Btn_plus.TabIndex = 2
        Me.Btn_plus.UseVisualStyleBackColor = True
        '
        'TextBoxChat
        '
        Me.TextBoxChat.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxChat.Location = New System.Drawing.Point(93, 1282)
        Me.TextBoxChat.Name = "TextBoxChat"
        Me.TextBoxChat.Size = New System.Drawing.Size(1290, 49)
        Me.TextBoxChat.TabIndex = 3
        '
        'send_btn
        '
        Me.send_btn.Enabled = False
        Me.send_btn.Location = New System.Drawing.Point(1389, 1282)
        Me.send_btn.Name = "send_btn"
        Me.send_btn.Size = New System.Drawing.Size(127, 48)
        Me.send_btn.TabIndex = 4
        Me.send_btn.Text = "Enviar"
        Me.send_btn.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1541, 40)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(168, 51)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Nuevo Chat"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1729, 40)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(174, 51)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Cerrar Sesion"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioBtn_creativo)
        Me.GroupBox1.Controls.Add(Me.RadioBtn_texto)
        Me.GroupBox1.Location = New System.Drawing.Point(1541, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(362, 155)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Modo"
        '
        'RadioBtn_creativo
        '
        Me.RadioBtn_creativo.AutoSize = True
        Me.RadioBtn_creativo.Location = New System.Drawing.Point(11, 97)
        Me.RadioBtn_creativo.Name = "RadioBtn_creativo"
        Me.RadioBtn_creativo.Size = New System.Drawing.Size(183, 29)
        Me.RadioBtn_creativo.TabIndex = 1
        Me.RadioBtn_creativo.TabStop = True
        Me.RadioBtn_creativo.Text = "Modo Creativo"
        Me.RadioBtn_creativo.UseVisualStyleBackColor = True
        '
        'RadioBtn_texto
        '
        Me.RadioBtn_texto.AutoSize = True
        Me.RadioBtn_texto.Checked = True
        Me.RadioBtn_texto.Location = New System.Drawing.Point(11, 47)
        Me.RadioBtn_texto.Name = "RadioBtn_texto"
        Me.RadioBtn_texto.Size = New System.Drawing.Size(157, 29)
        Me.RadioBtn_texto.TabIndex = 0
        Me.RadioBtn_texto.TabStop = True
        Me.RadioBtn_texto.Text = "Modo Texto"
        Me.RadioBtn_texto.UseVisualStyleBackColor = True
        '
        'ListBox_history
        '
        Me.ListBox_history.FormattingEnabled = True
        Me.ListBox_history.ItemHeight = 25
        Me.ListBox_history.Location = New System.Drawing.Point(1541, 309)
        Me.ListBox_history.Name = "ListBox_history"
        Me.ListBox_history.Size = New System.Drawing.Size(362, 529)
        Me.ListBox_history.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1552, 276)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Historial del chats"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1552, 860)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 25)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Favoritos"
        '
        'ListBox_favorito
        '
        Me.ListBox_favorito.FormattingEnabled = True
        Me.ListBox_favorito.ItemHeight = 25
        Me.ListBox_favorito.Location = New System.Drawing.Point(1541, 889)
        Me.ListBox_favorito.Name = "ListBox_favorito"
        Me.ListBox_favorito.Size = New System.Drawing.Size(362, 429)
        Me.ListBox_favorito.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1929, 1346)
        Me.Controls.Add(Me.ListBox_favorito)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBox_history)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.send_btn)
        Me.Controls.Add(Me.TextBoxChat)
        Me.Controls.Add(Me.Btn_plus)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Chat"
        Me.Panel1.ResumeLayout(False)
        Me.LogoBienvenida.ResumeLayout(False)
        Me.LogoBienvenida.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LogoBienvenida As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_plus As Button
    Friend WithEvents TextBoxChat As TextBox
    Friend WithEvents send_btn As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioBtn_creativo As RadioButton
    Friend WithEvents RadioBtn_texto As RadioButton
    Friend WithEvents ListBox_history As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ListBox_favorito As ListBox
    Friend WithEvents LabelBievenida As Label
End Class
