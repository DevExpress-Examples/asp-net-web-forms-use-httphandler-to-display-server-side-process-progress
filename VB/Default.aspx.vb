Imports System
Partial Public Class _Default
    Inherits System.Web.UI.Page

    Private ReadOnly Property Operation() As Operation
        Get
            If Session("_Operation") Is Nothing Then
                Session("_Operation") = New Operation()
            End If
            Return TryCast(Session("_Operation"), Operation)
        End Get
    End Property

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Protected Sub cbak_Callback(ByVal source As Object, ByVal e As DevExpress.Web.ASPxCallback.CallbackEventArgs)
        Operation.AsyncStart(5000)
    End Sub
End Class