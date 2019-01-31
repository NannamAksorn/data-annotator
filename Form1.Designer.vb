<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TxtLOGFILE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnLOGFILE = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.PBoxVIEW = New System.Windows.Forms.PictureBox()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.PBoxWAVE = New System.Windows.Forms.PictureBox()
        Me.Lblサンプル位置 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.LblP0 = New System.Windows.Forms.Label()
        Me.LblP1 = New System.Windows.Forms.Label()
        Me.LblW0 = New System.Windows.Forms.Label()
        Me.LblW1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PBoxVIEW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBoxWAVE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtLOGFILE
        '
        Me.TxtLOGFILE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtLOGFILE.Location = New System.Drawing.Point(71, 9)
        Me.TxtLOGFILE.Name = "TxtLOGFILE"
        Me.TxtLOGFILE.ReadOnly = True
        Me.TxtLOGFILE.Size = New System.Drawing.Size(804, 20)
        Me.TxtLOGFILE.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ログファイル :"
        '
        'BtnLOGFILE
        '
        Me.BtnLOGFILE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLOGFILE.Location = New System.Drawing.Point(876, 6)
        Me.BtnLOGFILE.Name = "BtnLOGFILE"
        Me.BtnLOGFILE.Size = New System.Drawing.Size(33, 25)
        Me.BtnLOGFILE.TabIndex = 14
        Me.BtnLOGFILE.Text = "..."
        Me.BtnLOGFILE.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "ログファイル|*.sendat|すべてのファイル|*.*"""
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.SplitContainer1)
        Me.Panel1.Controls.Add(Me.HScrollBar1)
        Me.Panel1.Controls.Add(Me.PBoxWAVE)
        Me.Panel1.Location = New System.Drawing.Point(4, 89)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(905, 499)
        Me.Panel1.TabIndex = 15
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(5, 83)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(2)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.PBoxVIEW)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.SplitContainer1.Size = New System.Drawing.Size(894, 395)
        Me.SplitContainer1.SplitterDistance = 510
        Me.SplitContainer1.SplitterWidth = 3
        Me.SplitContainer1.TabIndex = 22
        '
        'PBoxVIEW
        '
        Me.PBoxVIEW.BackColor = System.Drawing.Color.Black
        Me.PBoxVIEW.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PBoxVIEW.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PBoxVIEW.Location = New System.Drawing.Point(0, 0)
        Me.PBoxVIEW.Margin = New System.Windows.Forms.Padding(0)
        Me.PBoxVIEW.Name = "PBoxVIEW"
        Me.PBoxVIEW.Size = New System.Drawing.Size(510, 395)
        Me.PBoxVIEW.TabIndex = 19
        Me.PBoxVIEW.TabStop = False
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(103, 451)
        Me.AxWindowsMediaPlayer1.Margin = New System.Windows.Forms.Padding(2)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(332, 23)
        Me.AxWindowsMediaPlayer1.TabIndex = 21
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HScrollBar1.LargeChange = 1
        Me.HScrollBar1.Location = New System.Drawing.Point(0, 480)
        Me.HScrollBar1.Maximum = 0
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(905, 17)
        Me.HScrollBar1.TabIndex = 20
        '
        'PBoxWAVE
        '
        Me.PBoxWAVE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PBoxWAVE.BackColor = System.Drawing.Color.DimGray
        Me.PBoxWAVE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PBoxWAVE.Location = New System.Drawing.Point(0, 0)
        Me.PBoxWAVE.Margin = New System.Windows.Forms.Padding(0)
        Me.PBoxWAVE.Name = "PBoxWAVE"
        Me.PBoxWAVE.Size = New System.Drawing.Size(905, 81)
        Me.PBoxWAVE.TabIndex = 18
        Me.PBoxWAVE.TabStop = False
        Me.PBoxWAVE.Visible = False
        '
        'Lblサンプル位置
        '
        Me.Lblサンプル位置.AutoSize = True
        Me.Lblサンプル位置.Location = New System.Drawing.Point(156, 38)
        Me.Lblサンプル位置.Name = "Lblサンプル位置"
        Me.Lblサンプル位置.Size = New System.Drawing.Size(151, 13)
        Me.Lblサンプル位置.TabIndex = 18
        Me.Lblサンプル位置.Text = "9(99:99:99) 999,999(99:99:99)"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(71, 36)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(79, 20)
        Me.NumericUpDown1.TabIndex = 19
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LblP0
        '
        Me.LblP0.AutoSize = True
        Me.LblP0.Location = New System.Drawing.Point(383, 38)
        Me.LblP0.Name = "LblP0"
        Me.LblP0.Size = New System.Drawing.Size(49, 13)
        Me.LblP0.TabIndex = 20
        Me.LblP0.Text = "P0 : xxxx"
        '
        'LblP1
        '
        Me.LblP1.AutoSize = True
        Me.LblP1.Location = New System.Drawing.Point(452, 38)
        Me.LblP1.Name = "LblP1"
        Me.LblP1.Size = New System.Drawing.Size(49, 13)
        Me.LblP1.TabIndex = 21
        Me.LblP1.Text = "P1 : xxxx"
        '
        'LblW0
        '
        Me.LblW0.AutoSize = True
        Me.LblW0.Location = New System.Drawing.Point(524, 38)
        Me.LblW0.Name = "LblW0"
        Me.LblW0.Size = New System.Drawing.Size(53, 13)
        Me.LblW0.TabIndex = 22
        Me.LblW0.Text = "W0 : xxxx"
        '
        'LblW1
        '
        Me.LblW1.AutoSize = True
        Me.LblW1.Location = New System.Drawing.Point(597, 38)
        Me.LblW1.Name = "LblW1"
        Me.LblW1.Size = New System.Drawing.Size(53, 13)
        Me.LblW1.TabIndex = 23
        Me.LblW1.Text = "W1 : xxxx"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 598)
        Me.Controls.Add(Me.LblW1)
        Me.Controls.Add(Me.LblW0)
        Me.Controls.Add(Me.LblP1)
        Me.Controls.Add(Me.LblP0)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Lblサンプル位置)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnLOGFILE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtLOGFILE)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(639, 319)
        Me.Name = "Form1"
        Me.Text = "センサーログビューア"
        Me.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PBoxVIEW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBoxWAVE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtLOGFILE As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnLOGFILE As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PBoxWAVE As System.Windows.Forms.PictureBox
    Friend WithEvents PBoxVIEW As System.Windows.Forms.PictureBox
    Friend WithEvents HScrollBar1 As System.Windows.Forms.HScrollBar
    Friend WithEvents Lblサンプル位置 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblP0 As System.Windows.Forms.Label
    Friend WithEvents LblP1 As System.Windows.Forms.Label
    Friend WithEvents LblW0 As System.Windows.Forms.Label
    Friend WithEvents LblW1 As System.Windows.Forms.Label
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents SplitContainer1 As SplitContainer
End Class
