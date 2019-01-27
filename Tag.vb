Imports System.IO

Public Class Tag
    Private _objFS As FileStream = Nothing
    Private _tagList As New ArrayList

    Public Sub New(ByVal strFilePath As String)
        Close()
    End Sub

    Public Sub Close()
        If Not IsNothing(_objFS) Then
            _objFS.Close()
            _objFS = Nothing
        End If
    End Sub

    Public Sub add(ByVal data As Array)
        _tagList.Add(data)
    End Sub


    Public ReadOnly Property size As Integer
        Get
            Return _tagList.Count
        End Get
    End Property

    Public ReadOnly Property list As ArrayList
        Get
            Return _tagList
        End Get
    End Property


End Class
