Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Utilities.Collections

Public Class BD
    Dim conexion As New MySqlConnection("server=localhost; database=bong; user=root; password=''")

    'Guarda los datos en la BD
    Public Sub GuardarDatos(ChatU As String, ChatR As String, ChatID As Integer)

        Dim Sent As New MySqlCommand()
        Dim Received As New MySqlCommand()

        Try
            conexion.Open()

            Dim qsent As String = "INSERT INTO sent_messages(content, chat_id) VALUES (@sm, @sc)"
            Dim qreci As String = "INSERT INTO received_messages(content, chat_id) VALUES (@rm,@rc) "
            Sent.CommandText = qsent
            Sent.Connection = conexion
            Received.CommandText = qreci
            Received.Connection = conexion

            Sent.Parameters.AddWithValue("@sm", ChatU)
            Sent.Parameters.AddWithValue("@sc", ChatID)
            Received.Parameters.AddWithValue("@rm", ChatR)
            Received.Parameters.AddWithValue("@rc", ChatID)
            Sent.ExecuteNonQuery()

            Received.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error al agregar datos: " & ex.Message)
        Finally
            conexion.Close()
        End Try

    End Sub
    ' guardar chats
    Public Sub Guardarchat(cont As Integer)

        Dim chat As New MySqlCommand()
        Dim qChat As String = "INSERT INTO chats (chat_name) VALUES (@c)"
        chat.Connection = conexion
        chat.CommandText = qChat
        chat.Parameters.Add("@c", MySqlDbType.VarChar).Value = "Conversacion" & cont.ToString()
        conexion.Open()
        chat.ExecuteNonQuery()
        conexion.Close()
    End Sub

    'LISTA DE ID DE CHATS, aqui estan todos los ID
    Private Function ObtenerIDsChats() As List(Of Integer)
        Dim idsChats As New List(Of Integer)
        Dim comando As New MySqlCommand()

        Try
            conexion.Open()

            Dim query As String = "SELECT chat_id FROM chats"

            comando.CommandText = query
            comando.Connection = conexion

            Dim reader As MySqlDataReader = comando.ExecuteReader()

            While reader.Read()
                Dim chatID As Integer = Convert.ToInt32(reader("chat_id"))
                idsChats.Add(chatID)
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al obtener IDs de chats: " & ex.Message)
        Finally
            conexion.Close()
        End Try

        Return idsChats
    End Function

    Public Function GetChatNames() As List(Of String)
        Dim chatNames As New List(Of String)

        ' Cadena de conexión a la base de datos MySQL


        ' Crear la conexión
        Using conexion
            Try
                conexion.Open()

                ' Consulta SQL para obtener los datos de chat_name desde la tabla chats
                Dim query As String = "SELECT chat_name FROM chats"

                ' Crear el comando y asignar la conexión
                Using command As New MySqlCommand(query, conexion)

                    ' Crear un lector de datos
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        ' Leer los datos y agregarlos a la lista
                        While reader.Read()
                            chatNames.Add(reader("chat_name").ToString())
                        End While
                    End Using
                End Using
            Catch ex As Exception
                ' Manejar cualquier error en la conexión o consulta
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using

        ' Retornar la lista de chat_names
        Return chatNames
    End Function



    ' Obtiene el ultimo ID
    Public Function ObtenerUltimoID() As Integer
        Dim ultimoID As Integer = -1
        Dim Ult As New MySqlCommand()

        Try
            conexion.Open()
            Dim query As String = "SELECT MAX(chat_id) FROM chats"

            Ult.CommandText = query
            Ult.Connection = conexion

            Dim result As Object = Ult.ExecuteScalar()

            If result IsNot DBNull.Value Then
                ultimoID = Convert.ToInt32(result)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al obtener el último ID: " & ex.Message)
        End Try
        conexion.Close()
        Return ultimoID
    End Function




    Public Function GetChatID(ByVal chatName As String) As Integer
        Dim chatID As Integer = -1 ' Valor predeterminado en caso de que el chat_name no se encuentre

        ' Cadena de conexión a la base de datos MySQL

        ' Crear la conexión
        Using conexion
            Try
                conexion.Open()

                ' Consulta SQL para obtener el chat_id correspondiente al chat_name
                Dim query As String = "SELECT chat_id FROM chats WHERE chat_name = @chatName"

                ' Crear el comando y asignar la conexión
                Using command As New MySqlCommand(query, conexion)
                    ' Agregar el parámetro para evitar la inyección de SQL
                    command.Parameters.AddWithValue("@chatName", chatName)

                    ' Ejecutar la consulta y obtener el chat_id
                    Dim result As Object = command.ExecuteScalar()

                    ' Verificar si se encontró el chat_id y asignarlo a la variable chatID
                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        chatID = Convert.ToInt32(result)
                    End If
                End Using
            Catch ex As Exception
                ' Manejar cualquier error en la conexión o consulta
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using

        ' Retornar el chat_id encontrado (o -1 si no se encontró el chat_name)

        Return chatID
    End Function
    Public Function GetContentByChatIDUsuario(ByVal chatID As Integer) As List(Of String)
        Dim contentList As New List(Of String)

        ' Cadena de conexión a la base de datos MySQL


        ' Crear la conexión
        Using conexion
            Try
                conexion.Open()

                ' Consulta SQL para obtener el campo "content" del chat_id específico
                Dim query As String = "SELECT content FROM sent_messages WHERE chat_id = @chatID"

                ' Crear el comando y asignar la conexión
                Using command As New MySqlCommand(query, conexion)
                    ' Agregar el parámetro para evitar la inyección de SQL
                    command.Parameters.AddWithValue("@chatID", chatID)

                    ' Crear un lector de datos
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        ' Leer los datos y agregarlos a la lista
                        While reader.Read()
                            contentList.Add(reader("content").ToString())
                        End While
                    End Using
                End Using
            Catch ex As Exception
                ' Manejar cualquier error en la conexión o consulta
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using

        ' Retornar la lista de datos del campo "content" del chat_id específico
        Return contentList
    End Function
    Public Function GetContentByChatIDBong(ByVal chatID As Integer) As List(Of String)
        Dim contentList As New List(Of String)

        ' Cadena de conexión a la base de datos MySQL


        ' Crear la conexión
        Using conexion
            Try
                conexion.Open()

                ' Consulta SQL para obtener el campo "content" del chat_id específico
                Dim query As String = "SELECT content FROM received_messages WHERE chat_id = @chatID"

                ' Crear el comando y asignar la conexión
                Using command As New MySqlCommand(query, conexion)
                    ' Agregar el parámetro para evitar la inyección de SQL
                    command.Parameters.AddWithValue("@chatID", chatID)

                    ' Crear un lector de datos
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        ' Leer los datos y agregarlos a la lista
                        While reader.Read()
                            contentList.Add(reader("content").ToString())
                        End While
                    End Using
                End Using
            Catch ex As Exception
                ' Manejar cualquier error en la conexión o consulta
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using

        ' Retornar la lista de datos del campo "content" del chat_id específico
        Return contentList
    End Function
    Sub guardarcontador(Cont As integer)

        Using conexion
            Try
                conexion.Open()

                ' Consulta SQL para obtener el campo "content" del chat_id específico
                Dim query As String = "INSERT INTO contador (Contador) VALUES (@c) LIMIT 1"

                ' Crear el comando y asignar la conexión
                Using command As New MySqlCommand(query, conexion)
                    ' Agregar el parámetro para evitar la inyección de SQL
                    command.Parameters.AddWithValue("@c", Cont)
                End Using
            Catch ex As Exception
                ' Manejar cualquier error en la conexión o consulta
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using

    End Sub

End Class

