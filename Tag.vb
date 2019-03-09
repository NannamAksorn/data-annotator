Imports System.IO
Public Class Tag
    Private Const INSERT = 0
    Private Const DELETE = 1
    Private _objFS As FileStream = Nothing
    Private _tagList As New ArrayList
    Private _buttonList As New ArrayList
    Private _form As Form
    Private _strFilePath As String

    Private _undostack As Stack = New Stack()
    Private _redostack As Stack = New Stack()

    Public Sub New(ByVal form As Form, ByVal strFilePath As String)
        _form = form
        _strFilePath = strFilePath
        Close()
        Dim key As Integer
        Dim Index As Integer
        For Each line As String In System.IO.File.ReadAllLines(_strFilePath)
            Index = Integer.Parse(line.Split(",").ElementAt(0))
            key = Integer.Parse(line.Split(",").ElementAt(1))
            add({Index, key})
        Next
    End Sub

    Public Sub Close()
        If Not IsNothing(_objFS) Then
            _objFS.Close()
            _objFS = Nothing
        End If
        If Not IsNothing(_tagList) Then
            For index As Integer = 0 To _tagList.Count - 1
                deleteAt(0)
            Next
        End If
    End Sub

    Public Sub add(ByVal data As Array)
        If _tagList.Count <> 0 Then
            For index As Integer = _tagList.Count - 1 To 0 Step -1
                If data(0) > _tagList(index)(0) Then
                    If index + 1 < _tagList.Count Then
                        If _tagList(index + 1)(0) = data(0) Then
                            deleteAt(index + 1)
                        End If
                    End If

                    _tagList.Insert(index + 1, data)
                    addButton(index + 1, data)
                    _undostack.Push({INSERT, index + 1, data})

                    Return
                End If
            Next
            If _tagList(0)(0) = data(0) Then
                deleteAt(0)
            End If
        End If
        _tagList.Insert(0, data)
        addButton(0, data)
        _undostack.Push({INSERT, 0, data})
    End Sub

    Private Sub addButton(ByVal index As Integer, ByVal data As Array)
        Dim btn As Button = New Button
        btn.Anchor = AnchorStyles.Top
        btn.Top = 70
        btn.Left = Form1._getWavePointX(data(0))
        btn.Size = New Size(20, 20)
        btn.Text = data(1)

        If data(1) >= 9 Then
            btn.Text = "T"
            btn.Top -= 10
        End If
        _form.Controls.Add(btn)

        btn.BringToFront()

        AddHandler btn.Click, AddressOf delHandler
        _buttonList.Insert(index, btn)

    End Sub

    Public Sub update()
        For index As Integer = 0 To _tagList.Count - 1
            _buttonList(index).Left = Form1._getWavePointX(_tagList(index)(0))
        Next
    End Sub

    Private Sub deleteAt(Index As Integer)
        Dim i = _tagList(Index)(0)
        _form.Controls.Remove(_buttonList(Index))
        _buttonList(Index).Dispose()
        _buttonList.RemoveAt(Index)
        _tagList.RemoveAt(Index)

        Form1.NumericUpDown1.Value = i
        _form.Refresh()
    End Sub

    Private Sub delHandler(sender As Object, e As EventArgs)
        Dim Index = _buttonList.IndexOf(sender)
        _undostack.Push({DELETE, Index, _tagList(Index)})
        deleteAt(Index)

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

    Public Function nextTag(currentTag As Integer)
        For Each tag In _tagList
            If currentTag < tag(0) Then
                Return tag(0)
            End If
        Next
        Return 0
    End Function

    Public Function prevTag(currentTag As Integer)
        For i As Integer = _tagList.Count - 1 To 0 Step -1
            If currentTag > _tagList(i)(0) Then
                Return _tagList(i)(0)
            End If
        Next i
        Return 0
    End Function

    Public Function delPrev(currentTag As Integer)
        For i As Integer = _tagList.Count - 1 To 0 Step -1
            If currentTag >= _tagList(i)(0) Then
                Dim ret = _tagList(i)(0)
                _undostack.Push({DELETE, i, _tagList(i)})
                deleteAt(i)
                Return ret
            End If
        Next i
        Return 0
    End Function

    Public Function undo()
        Try
            Dim command As Array = _undostack.Pop()
            _redostack.Push(command)
            Select Case command(0)
                Case INSERT
                    deleteAt(command(1))
                Case DELETE
                    _tagList.Insert(command(1), command(2))
                    addButton(command(1), command(2))
            End Select
            Return command(2)(0)

        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function redo()
        Try
            Dim command As Array = _redostack.Pop()
            _undostack.Push(command)
            Select Case command(0)
                Case INSERT
                    _tagList.Insert(command(1), command(2))
                    addButton(command(1), command(2))
                Case DELETE
                    deleteAt(command(1))
            End Select
            Return command(2)(0)
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Sub save(fileName As String)
        Dim w As New IO.StreamWriter(_strFilePath)
        Dim i As Integer
        For i = 0 To _tagList.Count - 1
            w.WriteLine(CType(_tagList(i)(0), String) + "," + CType(_tagList(i)(1), String))
        Next
        w.Close()
    End Sub
End Class
