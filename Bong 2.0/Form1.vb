Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar

Public Class Form1
    Dim BaseD As New BD()
    Dim cantidadChats As Integer = 0
    Dim lastHeightChats As Integer = 20
    Dim modo = "texto"
    Dim textGenerate As New GenerarTexto()
    Dim imageGenerate As New GenerarImagen()
    Dim conversacionID As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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




        Dim chatNames As List(Of String) = BaseD.GetChatNames()

        For Each chatName As String In chatNames
            ListBox_history.Items.Add(chatName)
        Next


    End Sub

    Private Async Function send_btn_ClickAsync(sender As Object, e As EventArgs) As Task Handles send_btn.Click
        LogoBienvenida.Visible = False
        Dim textoTemp = TextBoxChat.Text
        If conversacionID = 0 And BaseD.ObtenerUltimoID() > 0 Then

            BaseD.Guardarchat(BaseD.ObtenerUltimoID())
            conversacionID = BaseD.ObtenerUltimoID()
            ListBox_history.Items.Add("Conversacion" & conversacionID - 1)
            ListBox_history.SelectedIndex = ListBox_history.Items.Count - 1
            MsgBox("entro 1- " & conversacionID.ToString() & " - " & BaseD.ObtenerUltimoID().ToString())
        ElseIf conversacionID > 0 Then
            ListBox_history.Items.Add("Conversacion" & conversacionID)
            MsgBox("entro 2 - " & conversacionID.ToString() & " - " & BaseD.ObtenerUltimoID().ToString())
        Else
            BaseD.Guardarchat(1)
            conversacionID = BaseD.ObtenerUltimoID()
            ListBox_history.Items.Add("Conversacion" & conversacionID)
            MsgBox("entro 3 - " & conversacionID.ToString() & " - " & BaseD.ObtenerUltimoID().ToString())
        End If

        If modo = "texto" Then

            chatCard("rigth", "Alan", textoTemp)
            TextBoxChat.Text = ""
            TextBoxChat.Enabled = False
            'Dim textResponse = Await textGenerate.text2text(textoTemp)
            Dim textResponse = "hola testo respondido"
            chatCard("left", "Bong", textResponse)
            TextBoxChat.Enabled = True

            BaseD.GuardarDatos(textoTemp, textResponse, conversacionID)
        Else
            chatCard("rigth", "Alan", textoTemp)
            TextBoxChat.Text = ""
            TextBoxChat.Enabled = False
            Dim imagePathResponse = Await imageGenerate.prueba(textoTemp)
            chatImageCard("left", "Bong", "C:\Users\anton\Documents\herramientas\Bong\" & imagePathResponse)
            TextBoxChat.Enabled = True
        End If
    End Function

    Private Sub chatCard(position As String, chatName As String, chatMessage As String)
        Panel1.VerticalScroll.Value = Panel1.VerticalScroll.Maximum
        Dim groupBox1 As New GroupBox()

        groupBox1.Text = chatName & "-" & Len(chatMessage)

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

        Dim groupBoxHeight As Integer = 600


        groupBox1.Width = 700
        groupBox1.Height = groupBoxHeight

        If position = "left" Then
            groupBox1.Location = New Point(10, lastHeightChats)
        Else
            groupBox1.Location = New Point(600, lastHeightChats)
        End If

        Dim pictureBox1 As New PictureBox()
        pictureBox1.Image = Image.FromFile(imagePath) ' Ruta de la imagen que quieres mostrar
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        pictureBox1.Size = New Size(500, 500) ' Tamaño de la imagen en el GroupBox
        pictureBox1.Location = New Point(50, 50) ' Posición de la imagen en el GroupBox
        groupBox1.Controls.Add(pictureBox1)


        Panel1.Controls.Add(groupBox1)

        lastHeightChats += groupBoxHeight + 10

        cantidadChats += 1

        Panel1.VerticalScroll.Value = Panel1.VerticalScroll.Maximum

    End Sub

    Private Sub TextBoxChat_TextChanged(sender As Object, e As EventArgs) Handles TextBoxChat.TextChanged
        If Len(TextBoxChat.Text) > 0 Then
            send_btn.Enabled = True
        Else
            send_btn.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ClearPanelExceptLogoBienvenida()
        cantidadChats = 0
        lastHeightChats = 20
        RadioBtn_texto.Checked = True

        ClearPanelExceptLogoBienvenida()
        LabelBievenida.Text = ""
        LogoBienvenida.Visible = True

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

        conversacionID = 0
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
            ListBox_favorito.BackColor = SystemColors.Control
            Btn_plus.Enabled = True
        End If
    End Sub

    Private Sub RadioBtn_creativo_CheckedChanged(sender As Object, e As EventArgs) Handles RadioBtn_creativo.CheckedChanged
        If RadioBtn_creativo.Checked Then
            modo = "creativo"
            Me.BackColor = Color.FromArgb(245, 218, 223)
            Panel1.BackColor = Color.FromArgb(245, 218, 223)
            ListBox_history.BackColor = Color.FromArgb(245, 218, 223)
            ListBox_favorito.BackColor = Color.FromArgb(245, 218, 223)
            Btn_plus.Enabled = False
        End If
    End Sub

    Private Sub Btn_plus_Click(sender As Object, e As EventArgs) Handles Btn_plus.Click
        Try
            Dim opf As New OpenFileDialog
            opf.Filter = "Image Files(*.jpg; *.jpeg; *png)|*.jpg;*.jpeg;*.png"

            If opf.ShowDialog = DialogResult.OK Then
                LogoBienvenida.Visible = False
                Dim imagePath = opf.FileName
                Dim fileExtension As String = Path.GetExtension(imagePath).ToLower()

                If fileExtension = ".jpg" Or fileExtension = ".jpeg" Or fileExtension = ".png" Then
                    chatImageCard("rigth", "Alan", imagePath)
                Else
                    MsgBox("El archivo seleccionado no es una imagen", MsgBoxStyle.Critical)
                End If


            End If
        Catch ex As Exception
            Debug.Print("Error")
            MsgBox("El archivo seleccionado no es una imagen", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub ListBox_history_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox_history.SelectedIndexChanged
        ClearPanelExceptLogoBienvenida()
        cantidadChats = 0
        lastHeightChats = 20
        RadioBtn_texto.Checked = True

        LabelBievenida.Text = ""
        LogoBienvenida.Visible = False

        ClearPanelExceptLogoBienvenida()

        'MsgBox("You have selected " + ListBox_history.SelectedItem.ToString())
        'MsgBox("Chat ID -->" & BaseD.GetChatID(ListBox_history.SelectedItem.ToString()))
        conversacionID = BaseD.GetChatID(ListBox_history.SelectedItem.ToString())
        'MsgBox(ListBox_history.SelectedItem.ToString(), conversacionID)

        Dim ConverU As List(Of String) = BaseD.GetContentByChatIDUsuario(BaseD.GetChatID(ListBox_history.SelectedItem.ToString()))
        Dim ConverB As List(Of String) = BaseD.GetContentByChatIDBong(BaseD.GetChatID(ListBox_history.SelectedItem.ToString()))
        Dim Indice As Integer = 0
        For Each ChatConver As String In ConverU
            '    ListBox_favorito.Items.Add(ChatConver)
            chatCard("right", "Alan", ChatConver)
            chatCard("left", "Bong", ConverB(Indice))
            Indice = Indice + 1
        Next
    End Sub
End Class
