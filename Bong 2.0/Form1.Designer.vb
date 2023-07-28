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
        Me.loadingBox = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.loading_box = New System.Windows.Forms.PictureBox()
        Me.LogoBienvenida = New System.Windows.Forms.GroupBox()
        Me.LabelBievenida = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxChat = New System.Windows.Forms.TextBox()
        Me.send_btn = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioBtn_creativo = New System.Windows.Forms.RadioButton()
        Me.RadioBtn_texto = New System.Windows.Forms.RadioButton()
        Me.ListBox_history = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_plus = New System.Windows.Forms.Button()
        Me.btn_delete_message = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.loadingBox.SuspendLayout()
        CType(Me.loading_box, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LogoBienvenida.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.loadingBox)
        Me.Panel1.Controls.Add(Me.LogoBienvenida)
        Me.Panel1.Location = New System.Drawing.Point(26, 48)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1490, 1229)
        Me.Panel1.TabIndex = 0
        '
        'loadingBox
        '
        Me.loadingBox.Controls.Add(Me.Label3)
        Me.loadingBox.Controls.Add(Me.loading_box)
        Me.loadingBox.Location = New System.Drawing.Point(474, 472)
        Me.loadingBox.Name = "loadingBox"
        Me.loadingBox.Size = New System.Drawing.Size(405, 308)
        Me.loadingBox.TabIndex = 2
        Me.loadingBox.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label3.Location = New System.Drawing.Point(29, 227)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(351, 55)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Dejame pensar"
        '
        'loading_box
        '
        Me.loading_box.Image = Global.Bong_2._0.My.Resources.Resources.loading
        Me.loading_box.Location = New System.Drawing.Point(125, 61)
        Me.loading_box.Name = "loading_box"
        Me.loading_box.Size = New System.Drawing.Size(161, 152)
        Me.loading_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.loading_box.TabIndex = 1
        Me.loading_box.TabStop = False
        '
        'LogoBienvenida
        '
        Me.LogoBienvenida.Controls.Add(Me.LabelBievenida)
        Me.LogoBienvenida.Controls.Add(Me.Label4)
        Me.LogoBienvenida.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.LogoBienvenida.Location = New System.Drawing.Point(390, 493)
        Me.LogoBienvenida.Margin = New System.Windows.Forms.Padding(4)
        Me.LogoBienvenida.Name = "LogoBienvenida"
        Me.LogoBienvenida.Padding = New System.Windows.Forms.Padding(4)
        Me.LogoBienvenida.Size = New System.Drawing.Size(566, 212)
        Me.LogoBienvenida.TabIndex = 0
        Me.LogoBienvenida.TabStop = False
        '
        'LabelBievenida
        '
        Me.LabelBievenida.AutoSize = True
        Me.LabelBievenida.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBievenida.Location = New System.Drawing.Point(36, 54)
        Me.LabelBievenida.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelBievenida.Name = "LabelBievenida"
        Me.LabelBievenida.Size = New System.Drawing.Size(0, 64)
        Me.LabelBievenida.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 158)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(502, 31)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Preguntame lo que quiera, y te respondo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Chats"
        '
        'TextBoxChat
        '
        Me.TextBoxChat.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxChat.Location = New System.Drawing.Point(92, 1283)
        Me.TextBoxChat.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxChat.Name = "TextBoxChat"
        Me.TextBoxChat.Size = New System.Drawing.Size(1290, 49)
        Me.TextBoxChat.TabIndex = 1
        '
        'send_btn
        '
        Me.send_btn.Enabled = False
        Me.send_btn.Location = New System.Drawing.Point(1388, 1283)
        Me.send_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.send_btn.Name = "send_btn"
        Me.send_btn.Size = New System.Drawing.Size(128, 48)
        Me.send_btn.TabIndex = 2
        Me.send_btn.Text = "Enviar"
        Me.send_btn.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1540, 40)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(168, 52)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Nuevo Chat"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1728, 40)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(174, 52)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Cerrar Sesion"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioBtn_creativo)
        Me.GroupBox1.Controls.Add(Me.RadioBtn_texto)
        Me.GroupBox1.Location = New System.Drawing.Point(1540, 114)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(362, 156)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Modo"
        '
        'RadioBtn_creativo
        '
        Me.RadioBtn_creativo.AutoSize = True
        Me.RadioBtn_creativo.Location = New System.Drawing.Point(12, 96)
        Me.RadioBtn_creativo.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioBtn_creativo.Name = "RadioBtn_creativo"
        Me.RadioBtn_creativo.Size = New System.Drawing.Size(183, 29)
        Me.RadioBtn_creativo.TabIndex = 7
        Me.RadioBtn_creativo.TabStop = True
        Me.RadioBtn_creativo.Text = "Modo Creativo"
        Me.RadioBtn_creativo.UseVisualStyleBackColor = True
        '
        'RadioBtn_texto
        '
        Me.RadioBtn_texto.AutoSize = True
        Me.RadioBtn_texto.Checked = True
        Me.RadioBtn_texto.Location = New System.Drawing.Point(12, 46)
        Me.RadioBtn_texto.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioBtn_texto.Name = "RadioBtn_texto"
        Me.RadioBtn_texto.Size = New System.Drawing.Size(157, 29)
        Me.RadioBtn_texto.TabIndex = 6
        Me.RadioBtn_texto.TabStop = True
        Me.RadioBtn_texto.Text = "Modo Texto"
        Me.RadioBtn_texto.UseVisualStyleBackColor = True
        '
        'ListBox_history
        '
        Me.ListBox_history.FormattingEnabled = True
        Me.ListBox_history.ItemHeight = 25
        Me.ListBox_history.Location = New System.Drawing.Point(1540, 393)
        Me.ListBox_history.Margin = New System.Windows.Forms.Padding(4)
        Me.ListBox_history.Name = "ListBox_history"
        Me.ListBox_history.Size = New System.Drawing.Size(362, 929)
        Me.ListBox_history.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1547, 364)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Historial del chats"
        '
        'Btn_plus
        '
        Me.Btn_plus.Image = Global.Bong_2._0.My.Resources.Resources.plus_icon
        Me.Btn_plus.Location = New System.Drawing.Point(26, 1283)
        Me.Btn_plus.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_plus.Name = "Btn_plus"
        Me.Btn_plus.Size = New System.Drawing.Size(60, 52)
        Me.Btn_plus.TabIndex = 3
        Me.Btn_plus.UseVisualStyleBackColor = True
        '
        'btn_delete_message
        '
        Me.btn_delete_message.Location = New System.Drawing.Point(1540, 300)
        Me.btn_delete_message.Name = "btn_delete_message"
        Me.btn_delete_message.Size = New System.Drawing.Size(362, 43)
        Me.btn_delete_message.TabIndex = 10
        Me.btn_delete_message.Text = "Eliminar Grupo de mensaje"
        Me.btn_delete_message.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1922, 1346)
        Me.Controls.Add(Me.btn_delete_message)
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
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Chat"
        Me.Panel1.ResumeLayout(False)
        Me.loadingBox.ResumeLayout(False)
        Me.loadingBox.PerformLayout()
        CType(Me.loading_box, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents LabelBievenida As Label
    Friend WithEvents loading_box As PictureBox
    Friend WithEvents loadingBox As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_delete_message As Button
End Class
