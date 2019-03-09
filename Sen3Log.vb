Imports System.IO
Imports System.Text.RegularExpressions
Public Class Sen3Log

    Private _objFS As FileStream = Nothing
    Private _nSAMPLE As Integer = 0
    Private arrP0() As Byte
    Private arrP1() As Byte
    Private arrW0() As Byte
    Private arrW1() As Byte
    Private sdate As Date
    Public diff As Integer = 0

    Public Shared ReadOnly Property IsLogFile(ByVal strFilePath As String) As Boolean
        Get
            Dim fs As FileStream = Nothing
            Dim isJudge As Boolean = False
            Try
                fs = New FileStream(strFilePath, FileMode.Open)

                'センサーデータファイルをチェックする
                Dim packet(44) As Byte
                Dim len As Integer

                len = fs.Read(packet, 0, packet.Length)
                isJudge = Not (len < packet.Length Or packet(0) <> &HAA Or packet(1) <> 40)
            Catch ex As Exception
                isJudge = False

            Finally
                fs.Close()
                fs = Nothing
            End Try
            Return isJudge
        End Get
    End Property
    Private Function parseDate(strFilePath As String) As Date
        strFilePath = strFilePath.Replace("-", "_")
        Dim match As Match = Regex.Match(strFilePath, "_(\d{4})(\d{2})(\d{2})_?(\d{2})_?(\d{2})_?(\d{2})")
        If match.Success Then
            Dim year = match.Groups.Item(1).Value
            year = Integer.Parse(year)
            If year > 2500 Then
                year = year - 543
            End If
            Dim month = match.Groups.Item(2).Value
            month = Integer.Parse(month)
            Dim day = match.Groups.Item(3).Value
            day = Integer.Parse(day)
            Dim hour = match.Groups.Item(4).Value
            hour = Integer.Parse(hour)
            Dim min = match.Groups.Item(5).Value
            min = Integer.Parse(min)
            Dim sec = match.Groups.Item(6).Value
            sec = Integer.Parse(sec)
            Dim pdate As Date = New Date(year, month, day, hour, min, sec)
            Form1.lblTest.Text = pdate.ToString
            Return pdate
        End If
        Return Nothing
    End Function


    Public Sub New(ByVal strFilePath As String)
        Close()

        Try
            _objFS = New FileStream(strFilePath, FileMode.Open)
            sdate = parseDate(strFilePath)
            If Form1.videoFiles.Count <= 0 Then
                If Form1.OpenFileDialog2.ShowDialog() = DialogResult.OK Then
                    Form1.getVideoFiles(Path.GetDirectoryName(Form1.OpenFileDialog2.FileName))
                End If
            End If
            If Form1.csvFiles.Count <= 0 Then
                If Form1.OpenFileDialog3.ShowDialog() = DialogResult.OK Then
                    Form1.getCSVFiles(Path.GetDirectoryName(Form1.OpenFileDialog3.FileName))
                End If
            End If
            setVideo()
            'センサーデータファイルをチェックする
            Dim packet(44) As Byte
            Dim nPacket As Integer = (_objFS.Length / packet.Length)

            If nPacket < 1 Then
                Throw New Exception("センサーログファイルではない Filesize=" + _objFS.Length)
            End If

            _nSAMPLE = nPacket * 8
            arrP0 = New Byte(_nSAMPLE - 1) {}
            arrP1 = New Byte(_nSAMPLE - 1) {}
            arrW0 = New Byte(_nSAMPLE - 1) {}
            arrW1 = New Byte(_nSAMPLE - 1) {}

            For i As Integer = 0 To nPacket - 1
                _objFS.Read(packet, 0, packet.Length)
                If packet(0) <> &HAA Or packet(1) <> 40 Then
                    Throw New Exception("センサーログファイルではない")
                End If
                Array.Copy(packet, 10, arrP0, i * 8, 8)
                Array.Copy(packet, 18, arrW0, i * 8, 8)
                Array.Copy(packet, 26, arrP1, i * 8, 8)
                Array.Copy(packet, 34, arrW1, i * 8, 8)
            Next

        Catch ex As Exception
            Close()
            Throw ex
        End Try
    End Sub

    Private Sub setVideo()
        Dim vdate As Date
        Dim video_current As String = ""
        Dim videoFiles = Form1.videoFiles
        For i As Integer = 0 To videoFiles.Count - 1
            Dim video_name = videoFiles.Item(i)
            vdate = parseDate(video_name)
            video_current = video_name
            diff = sdate.Subtract(vdate).TotalSeconds
            If diff < -3600 Then
                If i <> 0 Then
                    video_name = videoFiles.Item(i - 1)
                    vdate = parseDate(video_name)
                    video_current = video_name
                    diff = sdate.Subtract(vdate).TotalSeconds
                End If
                Exit For
            End If
        Next
        Form1.lblTest.Text = diff

        If video_current <> "" Then
            Form1.AxWindowsMediaPlayer1.URL = video_current
        End If
    End Sub


    Public Sub Close()
        If Not IsNothing(_objFS) Then
            _objFS.Close()
            _objFS = Nothing
        End If
    End Sub

    Public ReadOnly Property SampleCount() As Integer
        Get
            Return _nSAMPLE
        End Get
    End Property

    Public ReadOnly Property P0() As Byte()
        Get
            Return arrP0
        End Get
    End Property

    Public ReadOnly Property P1() As Byte()
        Get
            Return arrP1
        End Get
    End Property

    Public ReadOnly Property W0() As Byte()
        Get
            Return arrW0
        End Get
    End Property

    Public ReadOnly Property W1() As Byte()
        Get
            Return arrW1
        End Get
    End Property

    Private arrP0crr() As Byte
    Private arrP1crr() As Byte
    Private arrW0crr() As Byte
    Private arrW1crr() As Byte

    Public ReadOnly Property P0crr() As Byte()
        Get
            Return arrP0crr
        End Get
    End Property

    Public ReadOnly Property P1crr() As Byte()
        Get
            Return arrP1crr
        End Get
    End Property

    Public ReadOnly Property W0crr() As Byte()
        Get
            Return arrW0crr
        End Get
    End Property

    Public ReadOnly Property W1crr() As Byte()
        Get
            Return arrW1crr
        End Get
    End Property

    Public Sub LoadSamples(ByVal staBlock As Integer, ByVal countBlock As Integer)
        Dim packet(44) As Byte
        'Dim nPacket As Integer = (_objFS.Length / packet.Length)

        arrP0crr = New Byte(countBlock * 8 - 1) {}
        arrP1crr = New Byte(countBlock * 8 - 1) {}
        arrW0crr = New Byte(countBlock * 8 - 1) {}
        arrW1crr = New Byte(countBlock * 8 - 1) {}

        _objFS.Seek(packet.Length * staBlock, SeekOrigin.Begin)
        For i As Integer = 0 To countBlock - 1
            _objFS.Read(packet, 0, packet.Length)
            If packet(0) <> &HAA Or packet(1) <> 40 Then
                Trace.WriteLine("LoadSamples 読み込みデータ不良")
                Exit Sub
            End If
            Array.Copy(packet, 10, arrP0crr, i * 8, 8)
            Array.Copy(packet, 18, arrW0crr, i * 8, 8)
            Array.Copy(packet, 26, arrP1crr, i * 8, 8)
            Array.Copy(packet, 34, arrW1crr, i * 8, 8)
        Next

    End Sub
    '####
End Class
