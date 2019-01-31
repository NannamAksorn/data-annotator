Imports System.IO

Public Class Tag
    Private _objFS As FileStream = Nothing
    Private _tagList As New ArrayList
    Private _buttonList As New ArrayList
    Private _form As Form

    Public Sub New(ByVal form As Form, ByVal strFilePath As String)
        _form = form
        Close()
    End Sub

    Public Sub Close()
        If Not IsNothing(_objFS) Then
            _objFS.Close()
            _objFS = Nothing
        End If
    End Sub

    Public Sub add(ByVal data As Array)
        If _tagList.Count <> 0 Then
            For index As Integer = _tagList.Count - 1 To 0 Step -1
                If data(0) > _tagList(index)(0) Then
                    _tagList.Insert(index + 1, data)
                    addButton(index, data)
                    Return
                End If
            Next
        End If
        _tagList.Insert(0, data)
        addButton(-1, data)
    End Sub

    Private Sub addButton(ByVal index As Integer, ByVal data As Array)
        Dim btn As Button = New Button
        btn.Anchor = AnchorStyles.Top
        btn.Top = 70
        btn.Left = Form1._getWavePointX(data(0))
        btn.Size = New Size(20, 20)
        If (data(1) \ 10 < 1) Then
            btn.Text = data(1)
        Else
            btn.Text = "T"
        End If
        _form.Controls.Add(btn)
        AddHandler btn.Click, AddressOf delHandler
        _buttonList.Insert(index + 1, btn)

    End Sub

    Public Sub update()
        For index As Integer = 0 To _tagList.Count - 1
            _buttonList(index).Left = Form1._getWavePointX(_tagList(index)(0))
        Next
    End Sub

    Private Sub delHandler(sender As Object, e As EventArgs)
        Dim Index = _buttonList.IndexOf(sender)
        Dim i = _tagList(Index)(0)
        _buttonList.RemoveAt(Index)
        _tagList.RemoveAt(Index)
        _form.Controls.Remove(sender)
        sender.Dispose()

        Form1.NumericUpDown1.Value = i
        _form.Refresh()
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
