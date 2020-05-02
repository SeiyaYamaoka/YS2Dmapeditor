Public Class Form1

    Public COL_NUM As Integer = 80
    Public ROW_NUM As Integer = 60
    Public BLO_SIZE As Integer = 32

    Public RangeSel As Boolean = False
    Dim DSelX = 0, DSelY = 0, USelX = 0, USelY As Integer = 0

    Public MapData(1024, 1024) As Integer
    Dim DownFlg As Boolean = False
    Public GraMap As Graphics
    Public backbmpfilename As String = "background\anime_001.bmp"
    Public backbmp As Bitmap
    Public BmpMap As Bitmap

    Public ReadMapStr As String

    Public RectList As New ArrayList
    'Dim ChipRectList As New ArrayList

    'Dim Chipx = 0, Chipy As Integer = 0

    Public MapChipSetFile As String
    Public TestPlayfile As String
    Public Mapdatafile As String


    Public gridflg As Boolean = True
    Dim sq As Rectangle


    '------------------
    Dim Chipx As Integer
    Dim Chipy As Integer
    Public ChipRectList = New List(Of Rectangle)()

    Public typelist = New List(Of Integer)()
    Public CHIP_SIZE As Integer = 32
    Public GraChip As Graphics
    Dim bmp = New List(Of Bitmap)()
    Dim chipgyou As Integer = 8
    'Public rectlist = New List(Of Rectangle)()
    Public chipcnt As Integer = 0

    Public ht As Hashtable = New Hashtable

    'Dim httype = New List(Of Hashtable)

    Public selchip As Integer

    '関数ーーーー
    Public Function DrawMm()

        Mapbox.Size = New Size(COL_NUM * BLO_SIZE, ROW_NUM * BLO_SIZE)

        '描画先とするImageオブジェクトを作成する
        BmpMap = New Bitmap(Mapbox.Width, Mapbox.Height)
        GraMap = Graphics.FromImage(BmpMap)

        GraMap.DrawImage(backbmp, 0, 0, Mapbox.Width, Mapbox.Height)

        ' グリッドの描画
        DrawGrid(GraMap, Mapbox, BLO_SIZE)


        'GraMap.DrawRectangle(p, DSelX, DSelY, BLO_SIZE, BLO_SIZE)

        For i As Integer = 0 To COL_NUM - 1
            For j As Integer = 0 To ROW_NUM - 1
                If MapData(i, j) <> 0 Then
                    DrawMap(i, j, MapData(i, j))
                End If

            Next
        Next

        If RangeSel = True Then
            Dim p As New Pen(Color.Black, 3)
            GraMap.DrawRectangle(p, sq.Left * BLO_SIZE, sq.Top * BLO_SIZE, (sq.Width + 1) * BLO_SIZE, (sq.Height + 1) * BLO_SIZE)

        End If

        Mapbox.Image = BmpMap

        Return 0

    End Function
    Public Function DrawMap(x As Integer, y As Integer, type As Integer)

        'If ht(type) > chipcnt Then
        '    type = 0
        'End If

        ''If type <> 0 Then


        'GraMap = Graphics.FromImage(BmpMap)


        ''
        'Dim rebmp As New Bitmap(ChipBox.Image, ChipBox.Size.Width, ChipBox.Size.Height)

        'Dim desRect As New Rectangle(x * BLO_SIZE, y * BLO_SIZE, BLO_SIZE, BLO_SIZE)

        'GraMap.DrawImage(rebmp, desRect, ChipRectList(ht(type)), GraphicsUnit.Pixel)

        'Mapbox.Image = BmpMap
        ''GraMap.Dispose()

        ''End If
        'Return 0

    End Function
    Public Function DrawGrid(g As Graphics, p As PictureBox, size As Integer)
        If gridflg = True Then


            ' グリッドの描画
            For I As Integer = 0 To p.Width Step size
                g.DrawLine(Pens.LightGray, I, 0, I, p.Height)
            Next
            For I As Integer = 0 To p.Height Step size
                g.DrawLine(Pens.LightGray, 0, I, p.Width, I)
            Next
        End If

        Return 0

    End Function
    Private Sub initsetting()
        Dim filename As String = "setting\InitConfiguration.txt"
        If System.IO.File.Exists(filename) Then

            'Dim sr As New StreamReader(filename, System.Text.Encoding.GetEncoding("Shift_JIS"))
            'Dim text As String = sr.ReadToEnd()

            'sr.Close()

            '文字コード(ここでは、Shift JIS)
            Dim enc As System.Text.Encoding = System.Text.Encoding.GetEncoding("shift_jis")
            Dim text1 As String() = System.IO.File.ReadAllLines(filename, enc)

            'For i As Integer = 0 To text1.Length() - 1
            '    TextBox3.Text &= text1(i) & vbCrLf
            'Next

            Dim cnt As Integer = 0

            Dim li = New List(Of String)()
            Dim liva = New List(Of String)()

            For i As Integer = 0 To text1.Length - 1
                For j As Integer = 0 To text1(i).Length() - 1
                    If text1(i)(j) = "=" Then
                        li.Add(text1(i).Substring(0, j))
                        liva.Add(text1(i).Substring(j + 1, text1(i).Length() - (j + 1)))
                        'TextBox3.Text &= j & "   " & text1(i).Length() & vbCrLf

                        cnt += 1
                        Exit For
                    End If
                Next
            Next


            For i As Integer = 0 To cnt - 1

                Select Case li(i)
                    Case "COL_NUM"
                        COL_NUM = Integer.Parse(liva(i))
                    Case "ROW_NUM"
                        ROW_NUM = Integer.Parse(liva(i))
                    Case "BLO_SIZE"
                        BLO_SIZE = Integer.Parse(liva(i))
                    Case "backbmpfilename"
                        backbmpfilename = liva(i)
                    Case "MapChipSetFile"
                        MapChipSetFile = liva(i)
                    Case "TestPlayfile"
                        TestPlayfile = liva(i)
                    Case "Mapdatafile"
                        Mapdatafile = liva(i)
                End Select

            Next

            'Label3.Text = "処理終了"
        Else
            'Label2.Text = "file not found"

        End If
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'サイズの設定　全画面モード
        Me.WindowState = FormWindowState.Maximized
        Me.TopMost = True
        Me.Top = 0
        Me.Left = 0
        Me.Height = My.Computer.Screen.Bounds.Height
        Me.Width = My.Computer.Screen.Bounds.Width



    End Sub

    Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        '画面サイズが変更されたとき　サイズを調整する。
        TabControl1.Size = New Size(Me.Size.Width - 30, Me.Size.Height - 60)
        'MapPanel.Size = New Size(TabControl1.Size.Width - 300, TabControl1.Size.Height - 40)
    End Sub


    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles Mapbox.MouseMove
        Dim x As Integer = e.X \ BLO_SIZE
        Dim y As Integer = e.Y \ BLO_SIZE

        'グラフィックを消してきれいにしてから追加する

        'Label9.Text = x & "," & y

        If DownFlg = True Then

            If RangeSel = True Then


            ElseIf RangeSel = False Then

                If e.X < 0 Or e.Y < 0 Or e.X >= Mapbox.Width Or e.Y >= Mapbox.Height Then
                Else

                    If e.Button = MouseButtons.Left Then
                        MapData(x, y) = typelist(selchip)
                        DrawMap(x, y, typelist(selchip))
                    End If

                    If e.Button = MouseButtons.Right Then
                        MapData(x, y) = 0
                        DrawMap(x, y, 0)

                    End If


                End If
            End If
        End If

    End Sub
End Class
