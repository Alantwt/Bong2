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
    Dim apiToken As String = "r8_8SE2RGSHTJ3nnrFWJ0i4tAGLQVoMR663Gjtdo"

    'respuesta de la api
    Dim apiOutput As String = ""

    'carpeta de salida de las imagenes
    Dim dirFileOut = "images\"

    Public Async Function prueba(prompt As String) As Task(Of String)
        'Await Task.Delay(3 * 1000)

        Return "images\out-0.png"
    End Function

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
                               Await Task.Delay(5 * 1000)
                               If text2imageCheckAswer(id).Equals("succeeded") Then
                                   Try
                                       Using ImageClient As New WebClient()
                                           ImageClient.DownloadFile(apiOutput, dirFileOut + id)
                                       End Using
                                       Dim filepath As String = dirFileOut + id
                                       Return filepath
                                   Catch ex As Exception
                                       Throw New BongException("Error:imagen no generada")
                                   End Try
                                   Return apiOutput
                               End If
                           End While
                       ElseIf response.StatusCode = 402 Then
                           Return "Error: paga"
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
            Dim request As New HttpRequestMessage(HttpMethod.Get, url)
            request.Headers.Add("Authorization", "Token " & apiToken)

            request.Headers.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

            Dim response As HttpResponseMessage = client.SendAsync(request).Result

            Dim jsonObject As JObject = JObject.Parse(response.Content.ReadAsStringAsync().Result)
            apiOutput = jsonObject("output").ToString()
            Return jsonObject("status").ToString()
        End Using
    End Function
End Class
