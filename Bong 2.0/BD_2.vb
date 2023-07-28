Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class BD_2
    Dim conexion As New MySqlConnection("server=localhost; database=bong; user=root; password=''")


    'Crear usuario funcion
    Public Function crear_usuario(ByVal nombre As String, ByVal pass As String, ByVal email As String)

        Try
            Dim Sent As New MySqlCommand()

            Dim qsent As String = "INSERT INTO usuario (nombre, correo, password) VALUES (@name, @email, @pass)"

            conexion.Open()

            Sent.CommandText = qsent
            Sent.Connection = conexion

            Sent.Parameters.AddWithValue("@name", nombre)
            Sent.Parameters.AddWithValue("@pass", pass)
            Sent.Parameters.AddWithValue("@email", email)

            Sent.ExecuteNonQuery()

            Return True
        Catch ex As Exception
            Return False
        Finally
            conexion.Close()
        End Try

    End Function

    'Login funcion
    Public Function login(ByVal correo As String, ByVal pass As String) As Boolean
        Using conexion
            Try
                conexion.Open()

                ' Consulta SQL para obtener el id_user y nombre del usuario
                Dim query As String = "SELECT id_user, nombre FROM usuario WHERE correo = @correo AND password = @pass"

                ' Crear el comando y asignar la conexión
                Using command As New MySqlCommand(query, conexion)
                    ' Agregar los parámetros para evitar la inyección de SQL
                    command.Parameters.AddWithValue("@correo", correo)
                    command.Parameters.AddWithValue("@pass", pass)

                    ' Ejecutar la consulta y obtener el resultado en un lector de datos
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        ' Verificar si se encontró el usuario y leer los datos
                        If reader.Read() Then
                            ' Obtener el id_user y asignarlo a la variable usuarioID en la clase Inicio
                            If Not reader.IsDBNull(0) Then
                                Inicio.usuarioID = reader.GetInt32(0)
                            End If

                            ' Obtener el nombre y asignarlo a la variable nombreBD en la clase Inicio
                            If Not reader.IsDBNull(1) Then
                                Inicio.nombreBD = reader.GetString(1)
                            End If

                            Return True
                        Else
                            'Return False
                            Return True
                        End If
                    End Using
                End Using
            Catch ex As Exception
                ' Manejar cualquier error en la conexión o consulta
                'Return False
                Return True
            Finally
                conexion.Close()
            End Try
        End Using
    End Function


    'Guardar chat
    Public Function guardar_chat(ByVal who As String, ByVal type As String, ByVal mensaje As String, ByVal chat_group As String)

        Try
            Dim Sent As New MySqlCommand()
            Dim qsent As String = "INSERT INTO chats (id_user, who, type, message, chat_group) VALUES (@id_user, @who, @type, @message, @chat_group)"
            conexion.Open()
            Sent.CommandText = qsent
            Sent.Connection = conexion
            Sent.Parameters.AddWithValue("@message", mensaje)
            Sent.Parameters.AddWithValue("@id_user", Inicio.usuarioID)
            Sent.Parameters.AddWithValue("@who", who)
            Sent.Parameters.AddWithValue("@type", type)
            Sent.Parameters.AddWithValue("@chat_group", chat_group)
            Sent.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    'Consultar Historial grupo chats
    Public Function consultar_historialChats()
        Dim chat_group As New List(Of String)
        ' Crear la conexión
        Using conexion
            Try
                conexion.Open()

                ' Consulta SQL para obtener los datos de chat_name desde la tabla chats
                Dim query As String = "SELECT DISTINCT chat_group FROM chats WHERE id_user = " & Inicio.usuarioID

                ' Crear el comando y asignar la conexión
                Using command As New MySqlCommand(query, conexion)

                    ' Crear un lector de datos
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        ' Leer los datos y agregarlos a la lista
                        While reader.Read()
                            chat_group.Add(reader("chat_group").ToString())
                        End While
                    End Using
                End Using

            Catch ex As Exception
                ' Manejar cualquier error en la conexión o consulta
                MessageBox.Show("Error: " & ex.Message)
            Finally
                conexion.Close()
            End Try
        End Using

        Return chat_group
    End Function

    Public Function GetContentByChatIDUsuario(ByVal chat_group As String) As List(Of ChatData)
        Dim contentList As New List(Of ChatData)

        ' Crear la conexión
        Using conexion
            Try
                conexion.Open()

                ' Consulta SQL para obtener los campos "id_chat", "who", "type" y "message" del chat_id específico
                Dim query As String = "SELECT id_chat, who, type, message FROM chats WHERE chat_group = @chat_group AND id_user = @id_user ORDER BY fecha_registro;"

                ' Crear el comando y asignar la conexión
                Using command As New MySqlCommand(query, conexion)
                    ' Agregar los parámetros para evitar la inyección de SQL
                    command.Parameters.AddWithValue("@chat_group", chat_group)
                    command.Parameters.AddWithValue("@id_user", Inicio.usuarioID)
                    ' Crear un lector de datos
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        ' Leer los datos y agregarlos a la lista
                        While reader.Read()
                            Dim chatData As New ChatData()
                            chatData.IdChat = Convert.ToInt32(reader("id_chat"))
                            chatData.Who = reader("who").ToString()
                            chatData.Type = reader("type").ToString()
                            chatData.Message = reader("message").ToString()
                            contentList.Add(chatData)
                        End While
                    End Using
                End Using
            Catch ex As Exception
                ' Manejar cualquier error en la conexión o consulta
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using

        ' Retornar la lista de objetos ChatData
        Return contentList
    End Function

    'Eliminar grupo de chat
    Public Function EliminarPorGroupID(chat_group As String) As Integer
        Dim rowsAffected As Integer = 0

        Try
            ' Crear la conexión a la base de datos
            Using conexion
                conexion.Open()

                ' Crear la sentencia SQL para eliminar registros con el group_ID especificado
                Dim sql As String = "DELETE FROM chats WHERE chat_group = @chat_group AND id_user = @id_user"

                ' Crear el comando SQL con la sentencia y la conexión
                Using command As New MySqlCommand(sql, conexion)
                    ' Agregar el parámetro para el group_ID
                    command.Parameters.AddWithValue("@chat_group", chat_group)
                    command.Parameters.AddWithValue("@id_user", Inicio.usuarioID)

                    ' Ejecutar el comando y obtener el número de filas afectadas
                    rowsAffected = command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al eliminar registros: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return rowsAffected
    End Function

End Class
