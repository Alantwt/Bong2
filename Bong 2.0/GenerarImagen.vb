Imports System.IO
Imports System.Net
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports Newtonsoft.Json.Linq
Public Class GenerarImagen
    'https://replicate.com/ai-forever/kandinsky-2.2/api
    Dim kandinskyModel As String = "ea1addaab376f4dc227f5368bbd8eff901820fd1cc14ed8cad63b29249e9d463"

    'url de las peticiones
    Dim apiUrl As String = "https://api.replicate.com/v1/predictions"

    'apitoken
    Dim apiToken As String = "r8_0UoiP9TQZkdy5zYeqxmGh4gDXMSi1o21s5pAd"

    'respuesta de la api
    Dim apiOutput As String = ""

    'carpeta de salida de las imagenes
    Dim dirFileOut = "images\"
    Dim fullDirFileOut As String = Path.Combine(Application.StartupPath, dirFileOut)

    Public Async Function prueba() As Task(Of String)
        Await Task.Delay(3 * 1000)

        Return "images\out-0.png"
    End Function

    Public Function pruebaGuardar() As String
        Dim out = "https://replicate.delivery/pbxt/HduOcoBewPwFEiBSPCqZrPyAwhEUErhFNu9vRuPT4GP0qGqIA/out-0.png"

        If Not Directory.Exists(fullDirFileOut) Then
            Directory.CreateDirectory(fullDirFileOut)
        End If
        Debug.Print("full: " & fullDirFileOut)
        Using ImageClient As New WebClient()
            ImageClient.DownloadFile(out, fullDirFileOut & "prueba" & ".jpg")
        End Using

        Return fullDirFileOut
    End Function

    Public Sub AgregarLineaAlArchivo(rutaArchivo As String, texto As String)
        ' Verificar si el archivo existe, si no, crearlo
        If Not File.Exists(fullDirFileOut & "img2text.txt") Then
            File.Create(fullDirFileOut & "img2text.txt").Dispose()
        End If

        ' Abrir el archivo en modo Append para añadir nuevas líneas al final
        Using sw As StreamWriter = File.AppendText(fullDirFileOut & "img2text.txt")
            sw.WriteLine(rutaArchivo & "," & texto)
        End Using
    End Sub

    Public Async Function text2img(prompt As String) As Task(Of String)
        'Retorna el path de la imagen guardada localmente o lanza un error identificado

        Return Await Task.Run(
           Async Function()
               If prompt.Length > 0 Then
                   Debug.Print("aqui toy")
                   Using client As New HttpClient()
                       Dim request As New HttpRequestMessage(HttpMethod.Post, apiUrl)

                       'agregar los headers
                       request.Headers.Add("Authorization", "Token " & apiToken)
                       request.Headers.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

                       ' Agregar el body
                       'Dim requestBody As String = "{""version"": ""{falconModel}"", ""input"": {""prompt"": ""{prompt}""}}"
                       Dim requestBody As String = String.Format("{{""version"": ""{0}"", ""input"": {{""prompt"": ""{1}""}}}}", kandinskyModel, prompt)
                       Dim content As New StringContent(requestBody)
                       content.Headers.ContentType = New MediaTypeHeaderValue("application/json")
                       request.Content = content

                       Dim response As HttpResponseMessage = client.SendAsync(request).Result

                       Debug.Print("status code: " & response.StatusCode)
                       Debug.Print(response.StatusCode & response.StatusCode.ToString().Equals("402"))
                       If response.IsSuccessStatusCode Then
                           Dim jsonObject As JObject = JObject.Parse(response.Content.ReadAsStringAsync().Result)
                           Dim id As String = jsonObject("id").ToString()

                           While True
                               Debug.Print("Inicia la peticion")
                               Await Task.Delay(5 * 1000)
                               Dim status = text2ImageCheckAnswer(id)
                               Debug.Print("status: " & status)
                               Debug.Print("out: " & apiOutput)

                               If status.Equals("succeeded") Then
                                   Debug.Print("api output: " & apiOutput)
                                   Try
                                       If Not Directory.Exists(fullDirFileOut) Then
                                           Directory.CreateDirectory(fullDirFileOut)
                                       End If
                                       Using ImageClient As New WebClient()
                                           ImageClient.DownloadFile(apiOutput, fullDirFileOut & id & ".jpg")
                                           AgregarLineaAlArchivo(fullDirFileOut & id & ".jpg", apiOutput)
                                       End Using
                                       Debug.Print("se hizo la imagen")
                                       Dim filepath As String = dirFileOut + id
                                       Return fullDirFileOut & id & ".jpg"
                                   Catch ex As Exception
                                       Debug.Print("Hubo algun error desconocido")
                                       Debug.Print("error: " & ex.ToString())
                                       'Throw New BongException("Error:imagen no generada")
                                   End Try
                               Else
                                   Debug.Print("status no es igual")
                               End If
                           End While
                       ElseIf response.StatusCode = 402 Then
                           Return "Error: sin creditos en el apiToken"
                       Else
                           Throw New BongException("Error:api error code, code: " & response.StatusCode & " " & response.Content.ToString)
                       End If
                   End Using
               End If
               Return ""
           End Function
        )
    End Function

    Public Function text2imageCheckAswer(id As String)
        Using client As New HttpClient()
            Dim url As String = apiUrl + "/" + id
            Debug.Print("url: " & url)
            Dim request As New HttpRequestMessage(HttpMethod.Get, url)
            request.Headers.Add("Authorization", "Token " & apiToken)

            request.Headers.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

            Dim response As HttpResponseMessage = client.SendAsync(request).Result

            Dim jsonObject As JObject = JObject.Parse(response.Content.ReadAsStringAsync().Result)
            Debug.Print("object: " & jsonObject.ToString)
            apiOutput = jsonObject("output")
            Debug.Print("Api output: " & apiOutput & jsonObject("status").ToString())
            Return jsonObject("status").ToString()
        End Using
    End Function

    Public Function text2ImageCheckAnswer(id As String) As String
        Using client As New HttpClient()
            Dim url As String = apiUrl + "/" + id
            Dim request As New HttpRequestMessage(HttpMethod.Get, url)

            request.Headers.Add("Authorization", "Token " & apiToken)
            request.Headers.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

            Dim response As HttpResponseMessage = client.SendAsync(request).Result

            Dim jsonObject As JObject = JObject.Parse(response.Content.ReadAsStringAsync().Result)
            Debug.Print("object: " & jsonObject.ToString)
            If jsonObject("status").ToString().Equals("succeeded") Then
                apiOutput = jsonObject("output")(0)
            Else
                apiOutput = ""
            End If
            Debug.Print("Api output: " & apiOutput & jsonObject("status").ToString())
            Return jsonObject("status").ToString()
        End Using
    End Function
End Class
