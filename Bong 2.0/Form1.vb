Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar

Public Class Form1

    Dim BaseD2 As New BD_2()
    Dim cantidadChats As Integer = 0
    Dim lastHeightChats As Integer = 20
    Dim modo = "texto"
    Dim textGenerate As New GenerarTexto()
    Dim imageGenerate As New GenerarImagen()


    Dim chatID2 = "none"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadingBox.Visible = False

        Dim texto As String = "Bienvenido a Bong"
        Dim letras As Char() = texto.ToCharArray()

        Dim timer1 As New Timer()
        timer1.Interval = 100
        timer1.Enabled = True

        Dim i As Integer = 0
        AddHandler timer1.Tick, Sub()
                                    If i < letras.Length Then
                                        LabelBievenida.Text += letras(i)
                                        i += 1
                                    Else
                                        timer1.Enabled = False
                                    End If
                                End Sub




        Dim chat_group As List(Of String) = BaseD2.consultar_historialChats()

        For Each chat_group2 As String In chat_group
            ListBox_history.Items.Add(chat_group2)
        Next


    End Sub

    Private  Function send_btn_ClickAsync(sender As Object, e As EventArgs) As Task Handles send_btn.Click
        EnviarChat()
    End Function

    Public Async Sub EnviarChat()
        LogoBienvenida.Visible = False
        Dim textoTemp = TextBoxChat.Text
        loadingBox.Visible = True

        If modo = "texto" Then

            chatCard("rigth", Inicio.nombreBD, textoTemp)
            TextBoxChat.Text = ""
            TextBoxChat.Enabled = False

            If chatID2.Equals("none") Then
                chatID2 = Guid.NewGuid().ToString("N")
                ListBox_history.Items.Add(chatID2)
                BaseD2.guardar_chat("user", "text", textoTemp, chatID2)

            Else
                BaseD2.guardar_chat("user", "text", textoTemp, chatID2)

            End If

            'Dim textResponse = Await textGenerate.text2text(textoTemp)

            Dim textResponse = Await textGenerate.text2text(textoTemp)
            chatCard("left", "Bong", textResponse)
            TextBoxChat.Enabled = True

            BaseD2.guardar_chat("bong", "text", textResponse, chatID2)
        Else
            chatCard("rigth", Inicio.nombreBD, textoTemp)
            TextBoxChat.Text = ""
            TextBoxChat.Enabled = False

            If chatID2.Equals("none") Then
                chatID2 = Guid.NewGuid().ToString("N")
                ListBox_history.Items.Add(chatID2)
                BaseD2.guardar_chat("user", "text", textoTemp, chatID2)
            Else
                BaseD2.guardar_chat("user", "text", textoTemp, chatID2)
            End If

            Dim imagePathResponse = Await imageGenerate.text2img(textoTemp)
            Dim path_completa = imagePathResponse
            chatImageCard("left", "Bong", path_completa)
            TextBoxChat.Enabled = True

            BaseD2.guardar_chat("bong", "image", path_completa, chatID2)
        End If
        ListBox_history.SelectedItem = chatID2
        loadingBox.Visible = False
    End Sub

    Private Sub chatCard(position As String, chatName As String, chatMessage As String)
        Panel1.VerticalScroll.Value = Panel1.VerticalScroll.Maximum
        Dim groupBox1 As New GroupBox()

        groupBox1.Text = chatName

        Dim groupBoxHeight As Integer = 100

        If Len(chatMessage) >= 36 Then
            If Len(chatMessage) >= 1000 Then
                groupBoxHeight += (Len(chatMessage) / 36) * 12

            ElseIf Len(chatMessage) >= 700 Then
                groupBoxHeight += (Len(chatMessage) / 36) * 15
            Else
                groupBoxHeight += (Len(chatMessage) / 36) * 10
            End If

        End If

        groupBox1.Width = 400
        groupBox1.Height = groupBoxHeight



        If position = "left" Then
            groupBox1.Location = New Point(10, lastHeightChats)
        Else
            groupBox1.Location = New Point(300, lastHeightChats)
        End If

        Dim label1 As New Label()
        label1.Text = chatMessage
        label1.Font = New Font(label1.Font.FontFamily, 11)
        label1.AutoSize = True
        label1.Location = New Point(10, 50)
        label1.MaximumSize = New Size(380, 0)
        groupBox1.Controls.Add(label1)


        Panel1.Controls.Add(groupBox1)

        lastHeightChats += groupBoxHeight + 10

        cantidadChats += 1

        Panel1.VerticalScroll.Value = Panel1.VerticalScroll.Maximum

    End Sub

    Private Sub chatImageCard(position As String, chatName As String, imagePath As String)
        Panel1.VerticalScroll.Value = Panel1.VerticalScroll.Maximum

        Dim groupBox1 As New GroupBox()

        groupBox1.Text = chatName

        Dim groupBoxHeight As Integer = 400


        groupBox1.Width = 400
        groupBox1.Height = groupBoxHeight

        If position = "left" Then
            groupBox1.Location = New Point(10, lastHeightChats)
        Else
            groupBox1.Location = New Point(300, lastHeightChats)
        End If

        Dim pictureBox1 As New PictureBox()
        pictureBox1.Image = Image.FromFile(imagePath) ' Ruta de la imagen que quieres mostrar
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        pictureBox1.Size = New Size(300, 300) ' Tamaño de la imagen en el GroupBox
        pictureBox1.Location = New Point(50, 50) ' Posición de la imagen en el GroupBox
        groupBox1.Controls.Add(pictureBox1)


        Panel1.Controls.Add(groupBox1)

        lastHeightChats += groupBoxHeight + 10

        cantidadChats += 1

        Panel1.VerticalScroll.Value = Panel1.VerticalScroll.Maximum

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox_history.ClearSelected()
        If chatID2.Equals("none") Then
            cantidadChats = 0
            lastHeightChats = 20
            RadioBtn_texto.Checked = True
            loadingBox.Visible = False
            Return
        End If

        ClearPanelExceptLogoBienvenida()
        cantidadChats = 0
        lastHeightChats = 20
        RadioBtn_texto.Checked = True

        ClearPanelExceptLogoBienvenida()
        LabelBievenida.Text = ""
        LogoBienvenida.Visible = True
        loadingBox.Visible = False

        Dim texto As String = "Bienvenido a Bong"
        Dim letras As Char() = texto.ToCharArray()

        Dim timer1 As New Timer()
        timer1.Interval = 100
        timer1.Enabled = True

        Dim i As Integer = 0
        AddHandler timer1.Tick, Sub()
                                    If i < letras.Length Then
                                        LabelBievenida.Text += letras(i)
                                        i += 1
                                    Else
                                        timer1.Enabled = False
                                    End If
                                End Sub
        ClearPanelExceptLogoBienvenida()

        chatID2 = "none"
    End Sub

    Private Sub ClearPanelExceptLogoBienvenida()

        Dim logoBienvenidaGroupBox As GroupBox = Nothing


        For Each ctrl As Control In Panel1.Controls
            If TypeOf ctrl Is GroupBox AndAlso ctrl.Name = "LogoBienvenida" Then
                logoBienvenidaGroupBox = DirectCast(ctrl, GroupBox)
            Else
                Panel1.Controls.Remove(ctrl)
            End If
        Next

        If logoBienvenidaGroupBox IsNot Nothing Then
            Panel1.Controls.Add(logoBienvenidaGroupBox)
        End If
    End Sub

    Private Sub RadioBtn_texto_CheckedChanged(sender As Object, e As EventArgs) Handles RadioBtn_texto.CheckedChanged
        If RadioBtn_texto.Checked Then
            modo = "texto"
            Me.BackColor = SystemColors.Control
            Panel1.BackColor = SystemColors.Control
            ListBox_history.BackColor = SystemColors.Control

            Btn_plus.Enabled = True
        End If
    End Sub

    Private Sub RadioBtn_creativo_CheckedChanged(sender As Object, e As EventArgs) Handles RadioBtn_creativo.CheckedChanged
        If RadioBtn_creativo.Checked Then
            modo = "creativo"
            Me.BackColor = Color.FromArgb(245, 218, 223)
            Panel1.BackColor = Color.FromArgb(245, 218, 223)
            ListBox_history.BackColor = Color.FromArgb(245, 218, 223)

            Btn_plus.Enabled = False
        End If
    End Sub

    Private Async Sub Btn_plus_Click(sender As Object, e As EventArgs) Handles Btn_plus.Click
        Try
            Dim opf As New OpenFileDialog
            opf.Filter = "Image Files(*.jpg; *.jpeg; *png)|*.jpg;*.jpeg;*.png"

            If opf.ShowDialog = DialogResult.OK Then
                LogoBienvenida.Visible = False
                Dim imagePath = opf.FileName
                Dim fileExtension As String = Path.GetExtension(imagePath).ToLower()

                If fileExtension = ".jpg" Or fileExtension = ".jpeg" Or fileExtension = ".png" Then
                    loadingBox.Visible = True
                    chatImageCard("rigth", Inicio.nombreBD, imagePath)
                    BaseD2.guardar_chat("user", "image", imagePath, chatID2)
                    Dim textoTemp As String = Await textGenerate.image2text(imagePath)
                    chatCard("left", "Bong", textoTemp)
                Else
                    MsgBox("El archivo seleccionado no es una imagen", MsgBoxStyle.Critical)
                End If


            End If
        Catch ex As Exception
            Debug.Print("Error")
            MsgBox("El archivo seleccionado no es una imagen", MsgBoxStyle.Critical)
        Finally
            loadingBox.Visible = False
        End Try
    End Sub

    Private Sub ListBox_history_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox_history.SelectedIndexChanged
        ClearPanelExceptLogoBienvenida()
        cantidadChats = 0
        lastHeightChats = 20
        RadioBtn_texto.Checked = True
        ClearPanelExceptLogoBienvenida()
        LabelBievenida.Text = ""
        LogoBienvenida.Visible = False

        ClearPanelExceptLogoBienvenida()
        ClearPanelExceptLogoBienvenida()

        Try
            If ListBox_history.SelectedItem = Nothing Then
                Return
            End If

            chatID2 = ListBox_history.SelectedItem.ToString()

            Dim listaDatos As List(Of ChatData) = BaseD2.GetContentByChatIDUsuario(chatID2)

            For Each datos As ChatData In listaDatos


                If datos.Who.Equals("bong") Then
                    If datos.Type.Equals("text") Then
                        chatCard("left", "Bong", datos.Message)
                    Else
                        chatImageCard("left", "Bong", datos.Message)
                    End If
                Else
                    If datos.Type.Equals("text") Then
                        chatCard("right", Inicio.nombreBD, datos.Message)
                    Else
                        chatImageCard("right", Inicio.nombreBD, datos.Message)
                    End If
                End If

            Next
        Catch ex As Exception
            MsgBox("Error ocurrido desconocido", MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Inicio.Show()
    End Sub


    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message,
                                           ByVal keyData As System.Windows.Forms.Keys) _
                                           As Boolean

        If msg.WParam.ToInt32() = CInt(Keys.Enter) Then
            If Len(TextBoxChat.Text) > 0 Then
                EnviarChat()
            Else
                MsgBox("No puedes enviar un mensaje vacio", MsgBoxStyle.Critical)
            End If
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub TextBoxChat_TextChanged_1(sender As Object, e As EventArgs) Handles TextBoxChat.TextChanged
        If Len(TextBoxChat.Text) > 0 Then
            send_btn.Enabled = True
        Else
            send_btn.Enabled = False
        End If
    End Sub

    Private Sub btn_delete_message_Click(sender As Object, e As EventArgs) Handles btn_delete_message.Click
        If chatID2.Equals("none") Then
            MsgBox("Debe de seleccionar un grupo de mensajes en el historial de chats, para eliminar.", MsgBoxStyle.Critical)
        Else
            Dim respuesta = BaseD2.EliminarPorGroupID(chatID2)
            MsgBox("Se a eliminado correactamente.", MsgBoxStyle.Information)
            If respuesta > 0 Then
                ClearPanelExceptLogoBienvenida()
                cantidadChats = 0
                lastHeightChats = 20
                RadioBtn_texto.Checked = True
                ClearPanelExceptLogoBienvenida()

                LabelBievenida.Text = ""
                LogoBienvenida.Visible = True
                loadingBox.Visible = False

                Dim texto As String = "Bienvenido a Bong"
                Dim letras As Char() = texto.ToCharArray()

                Dim timer1 As New Timer()
                timer1.Interval = 100
                timer1.Enabled = True

                Dim i As Integer = 0
                AddHandler timer1.Tick, Sub()
                                            If i < letras.Length Then
                                                LabelBievenida.Text += letras(i)
                                                i += 1
                                            Else
                                                timer1.Enabled = False
                                            End If
                                        End Sub
                ClearPanelExceptLogoBienvenida()

                ListBox_history.Items.Clear()
                chatID2 = "none"

                Dim chat_group As List(Of String) = BaseD2.consultar_historialChats()

                For Each chat_group2 As String In chat_group
                    ListBox_history.Items.Add(chat_group2)
                Next
            End If
        End If
    End Sub
End Class
