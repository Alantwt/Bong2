Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Inicio_sesion
    Private Sub Inicio_sesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox_pass.UseSystemPasswordChar = True

        Dim texto As String = "ONG"
        Dim letras As Char() = texto.ToCharArray()

        Dim timer1 As New Timer()
        timer1.Interval = 300
        timer1.Enabled = True

        Dim i As Integer = 0
        AddHandler timer1.Tick, Sub()
                                    If i < letras.Length Then
                                        ong_label.Text += letras(i)
                                        i += 1
                                    Else
                                        timer1.Enabled = False
                                    End If
                                End Sub
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            'IF TRUE, IT SHOWS THE TEXT
            TextBox_pass.UseSystemPasswordChar = False
        Else
            'IF FALSE, IT WILL HIDE THE TEXT AND IT WILL TURN INTO BULLETS.
            TextBox_pass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Btn_crear_Click(sender As Object, e As EventArgs) Handles Btn_crear.Click
        Me.Hide()
        crearCuenta.Show()
    End Sub
End Class