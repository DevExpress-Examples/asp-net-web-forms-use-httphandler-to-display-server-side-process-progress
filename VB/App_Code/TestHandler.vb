Option Infer On

Imports System
Imports System.Web
Imports System.Web.SessionState

Public Class TestHandler
    Implements IHttpHandler, IRequiresSessionState

    Private Function GetProgress(ByVal session As HttpSessionState) As String
        If session Is Nothing OrElse Not (TypeOf session("_Operation") Is Operation) Then
            Return "NaN"
        End If
        Dim progress = (TryCast(session("_Operation"), Operation)).Progress
        Return progress.ToString()
    End Function

    Public ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property

    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        Dim response = GetProgress(context.Session)
        context.Response.CacheControl = "No-cache"
        context.Response.Write(response)
    End Sub
End Class