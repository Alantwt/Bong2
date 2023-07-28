Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Inicio
    Public BaseD2 As New BD_2()
    Public usuarioID As Integer = -1
    Public nombreBD As String = ""
    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_pass.UseSystemPasswordChar = True
        txt_crear_pass.UseSystemPasswordChar = True
        txt_crear_pass2.UseSystemPasswordChar = True
        Me.Size = New Size(550, 580)
        Panel_inicio.Show()
        Panel_crear.Hide()

        Dim texto As String = "ong"
        Dim letras As Char() = texto.ToCharArray()

        Dim timer1 As New Timer()
        timer1.Interval = 300
        timer1.Enabled = True

        Dim i As Integer = 0
        AddHandler timer1.Tick, Sub()
                                    If i < letras.Length Then
                                        ong_txt.Text += letras(i)
                                        i += 1
                                    Else
                                        timer1.Enabled = False
                                    End If
                                End Sub

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            'IF TRUE, IT SHOWS THE TEXT
            txt_pass.UseSystemPasswordChar = False
        Else
            'IF FALSE, IT WILL HIDE THE TEXT AND IT WILL TURN INTO BULLETS.
            txt_pass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel_inicio.Hide()
        Panel_crear.Show()


    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Panel_inicio.Show()
        Panel_crear.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim name = txt_crear_nombre.Text
        Dim Pass = txt_crear_pass.Text
        Dim Pass2 = txt_crear_pass2.Text
        Dim correo = txt_crear_email.Text

        If name = "" Or Pass = "" Or Pass2 = "" Or correo = "" Then
            MsgBox("Por favor, rellene todos los campos", MsgBoxStyle.Critical)
        Else
            If Pass = Pass2 Then
                Dim ok = BaseD2.crear_usuario(name, Pass, correo)

                If ok = True Then
                    MsgBox("Usuario creado correctamente")
                    txt_crear_nombre.Text = ""
                    txt_crear_pass.Text = ""
                    txt_crear_pass2.Text = ""
                    txt_crear_email.Text = ""
                Else
                    MsgBox("Error al crear el usuario", MsgBoxStyle.Critical)
                End If
            Else
                MsgBox("Las contraseñas no coinciden", MsgBoxStyle.Critical)
            End If
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim correo = txt_email.Text
        'Dim pass = txt_pass.Text
        Dim correo = "asd@asd.com"
        Dim pass = "123"

        If correo = "" Or pass = "" Then
            MsgBox("Por favor, rellene todos los campos", MsgBoxStyle.Critical)
        Else
            Dim ok = BaseD2.login(correo, pass)
            If ok = True Then
                Me.Hide()
                Dim form As New Form1()
                form.Show()

                txt_email.Text = ""
                txt_pass.Text = ""
            Else
                MsgBox("Usuario o contrasena incorrecto!!", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub CheckBox_see_password_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_see_password.CheckedChanged
        If CheckBox_see_password.CheckState = CheckState.Checked Then
            'IF TRUE, IT SHOWS THE TEXT
            txt_crear_pass.UseSystemPasswordChar = False
            txt_crear_pass2.UseSystemPasswordChar = False
        Else
            'IF FALSE, IT WILL HIDE THE TEXT AND IT WILL TURN INTO BULLETS.
            txt_crear_pass.UseSystemPasswordChar = True
            txt_crear_pass2.UseSystemPasswordChar = True
        End If
    End Sub
End Class