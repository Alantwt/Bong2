Imports System.IO
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports Newtonsoft.Json.Linq


Public Class GenerarTexto
    'https://replicate.com/yrvelez/flamingo/api
    Dim flamingoModel As String = "0e85a6c091cccdabac7bfcb0a9db0ecd7db6909493fb3b32fc76bac9151c2a34"
    'https://replicate.com/daanelson/minigpt-4/examples
    Dim miniGPT4Model As String = "b96a2f33cc8e4b0aa23eacfce731b9c41a7d9466d9ed4e167375587b54db9423"
    'https://replicate.com/joehoover/falcon-40b-instruct
    Dim falconModel As String = "7eb0f4b1ff770ab4f68c3a309dd4984469749b7323a3d47fd2d5e09d58836d3c"
    Dim llamaModel As String = "6b4da803a2382c08868c5af10a523892f38e2de1aafb2ee55b020d9efef2fdb8"

    'url de las peticiones
    Dim apiUrl As String = "https://api.replicate.com/v1/predictions"

    'apitoken
    Dim apiToken As String = "r8_cFTYuMZQYiRi5Qi6ximOyJOQG9hq91t0y7w3I"

    'respuesta de la api
    Dim apiOutput As String = ""


    Public Async Function prueba() As Task(Of String)
        'Await Task.Delay(10 * 1000)
        Dim xd = Await Task.Run(
            Function()
                For i As Integer = 0 To 1000000000
                    ' Código a ejecutar en cada iteración del bucle
                Next
                Return "hola"
            End Function
        )
        Return xd
    End Function

    Public Async Function text2text(prompt As String) As Task(Of String)
        Return Await Task.Run(
            Async Function()
                If prompt.Length > 0 Then

                    Using client As New HttpClient()
                        Dim request As New HttpRequestMessage(HttpMethod.Post, apiUrl)

                        'agregar los headers
                        request.Headers.Add("Authorization", "Token " & apiToken)
                        request.Headers.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

                        ' Agregar el body
                        'Dim requestBody As String = "{""version"": ""{falconModel}"", ""input"": {""prompt"": ""{prompt}""}}"
                        Dim requestBody As String = String.Format("{{""version"": ""{0}"", ""input"": {{""prompt"": ""{1}""}}}}", llamaModel, prompt)
                        Dim content As New StringContent(requestBody)
                        content.Headers.ContentType = New MediaTypeHeaderValue("application/json")
                        request.Content = content

                        Dim response As HttpResponseMessage = client.SendAsync(request).Result

                        Debug.Print("Respuesta code de la api" & response.StatusCode)
                        If response.IsSuccessStatusCode Then
                            Dim jsonObject As JObject = JObject.Parse(response.Content.ReadAsStringAsync().Result)
                            Debug.Print("object: " & jsonObject.ToString)
                            Dim id As String = jsonObject("id").ToString()
                            Debug.Print("id: " & id)

                            While True
                                Await Task.Delay(5 * 1000)
                                If text2textCheckAnswer(id).Equals("succeeded") Then
                                    Debug.Print("Esto retorna: " & apiOutput)
                                    Return apiOutput
                                End If
                            End While
                        Else
                            Throw New BongException("api error, code: " & response.StatusCode & " " & response.Content.ToString)
                        End If
                    End Using
                Else
                    Throw New BongException("Prompt vacio, prompt: " & prompt)
                End If
                Return ""
            End Function
        )
    End Function

    Public Function text2textCheckAnswer(id As String) As String
        Using client As New HttpClient()
            Dim url As String = apiUrl + "/" + id
            Dim request As New HttpRequestMessage(HttpMethod.Get, url)
            request.Headers.Add("Authorization", "Token " & apiToken)

            request.Headers.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

            Dim response As HttpResponseMessage = client.SendAsync(request).Result

            If response.IsSuccessStatusCode Then
                Dim jsonObject As JObject = JObject.Parse(response.Content.ReadAsStringAsync().Result)
                Debug.Print("object: " & jsonObject.ToString)
                Try
                    'apiOutput = jsonObject("output")
                    Dim words = jsonObject("output")

                    For Each word In words
                        apiOutput = apiOutput & " " & word.ToString().Trim()
                    Next
                    Debug.Print("output: " & apiOutput)

                Catch ex As Exception
                    apiOutput = ""
                End Try
                Debug.Print("status code: " & jsonObject("status").ToString())
                Return jsonObject("status").ToString()
            Else
                Dim jsonObject As JObject = JObject.Parse(response.Content.ReadAsStringAsync().Result)
                Debug.Print("object: " & jsonObject.ToString)
                Try
                    apiOutput = jsonObject("output")
                Catch ex As Exception
                    apiOutput = ""
                End Try
                Debug.Print("status code: " & jsonObject("status").ToString())
                Return jsonObject("status").ToString()
            End If
        End Using
    End Function

    Public Async Function image2text(pathImage As String) As Task(Of String)
        Return Await Task.Run(
            Async Function()
                If pathImage.Length > 0 Then
                    Using client As New HttpClient()
                        Dim request As New HttpRequestMessage(HttpMethod.Post, apiUrl)
                        request.Headers.Add("Authorization", "Token " & apiToken)
                        request.Headers.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

                        'leer la imagen
                        Dim imageBytes As Byte() = File.ReadAllBytes(pathImage)
                        Dim base64Image As String = Convert.ToBase64String(imageBytes)

                        Dim requestBody As String = String.Format("{{""version"": ""{0}"", ""input"": {{""image"": ""{1}""}}}}", miniGPT4Model, base64Image)
                        Dim content As New StringContent(requestBody)
                        content.Headers.ContentType = New MediaTypeHeaderValue("application/json")
                        request.Content = content

                        Dim response As HttpResponseMessage = Await client.SendAsync(request)

                        If response.IsSuccessStatusCode Then
                            Dim jsonObject As JObject = JObject.Parse(response.Content.ReadAsStringAsync().Result)
                            Dim id As String = jsonObject("id").ToString()

                            While True
                                Await Task.Delay(5 * 1000)
                                If image2textCheckAnswer(id).Equals("succeeded") Then
                                    Return apiOutput
                                End If
                            End While
                        Else
                            Throw New BongException("api error, code: " & response.StatusCode & " " & response.Content.ToString)
                        End If
                    End Using
                Else
                    Return ""
                End If
                Return ""
            End Function
        )
    End Function

    Public Function image2textCheckAnswer(id As String) As String
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
