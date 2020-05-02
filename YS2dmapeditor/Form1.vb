Public Class Form1

    Public COL_NUM As Integer = 80 'xに何個
    Public ROW_NUM As Integer = 60 'yに何個
    Public BLO_SIZE As Integer = 32 'マップの１チップのサイズ

    Dim BmpMap As Bitmap 'マップのビットマップ
    Dim ChipMap As Bitmap 'チップのビットマップ

    Public RangeSelFlg As Boolean = False '囲い状態かどうか

    Dim DSelX = 0, DSelY = 0, USelX = 0, USelY As Integer = 0　'枠を選択するときに使う

    Public MapData(1024, 1024) As Integer 'マップデータ　　1024×1024

    Dim DownFlg As Boolean = False  'マウスが押されているかどうか

    '背景
    Public backbmpfilename As String = "background\anime_001.bmp" '背景のファイルの名前
    Public backbmp As Bitmap

    Public MapChipSetFile As String 'マップチップの設定ファイルの名前
    Public TestPlayfile As String 'テストプレイの実行ファイルの名前
    Public Mapdatafile As String 'マップデータファイルの名前
    Public countnum As Integer


    Public GridFlg As Boolean = True 'グリッド線を表示させるかどうか
    Dim RangeVal As Rectangle     '選択された枠の値

    '------------------ 


    Public CHIP_SIZE As Integer = 24
    Dim chipgyou As Integer = 10
    Public selchip As Integer
    Public chip = New List(Of chipinf)
    Public selectchipnum As Integer = 0
    Dim selectchipmax As Integer = 1

    'チップの情報のクラス
    Public Class chipinf
        Public x_size As Integer
        Public y_size As Integer
        Public ChipRectList = New List(Of Rectangle)()
        Public typelist = New List(Of Integer)()
        Public rectlist = New List(Of Rectangle)()
        Public ht As Hashtable = New Hashtable
        Public chipcnt As Integer = 0
        Public bmp = New List(Of Bitmap)()

        'Public bmpht As HashSet(Of Bitmap)()

    End Class



    '関数 全体マップを書く
    Public Function DrawMm()

        Mapbox.Size = New Size(COL_NUM * BLO_SIZE, ROW_NUM * BLO_SIZE)

        '描画先とするImageオブジェクトを作成する
        Dim GraMap As Graphics

        If BmpMap Is Nothing Then

            BmpMap = New Bitmap(Mapbox.Width, Mapbox.Height)
        Else
            Dim oldimage = BmpMap
            BmpMap = New Bitmap(Mapbox.Width, Mapbox.Height)
            oldimage.Dispose()
        End If

        GraMap = Graphics.FromImage(BmpMap)

        '背景描画
        GraMap.DrawImage(backbmp, 0, 0, Mapbox.Width, Mapbox.Height)

        ' グリッドの描画
        DrawGrid(GraMap, Mapbox, BLO_SIZE)

        Dim cnt As Integer = 0

        countnum = Integer.Parse(TextBox13.Text)
        For i As Integer = 0 To COL_NUM - 1
            For j As Integer = 0 To ROW_NUM - 1

                If MapData(i, j) = countnum Then
                    cnt += 1
                End If

                If MapData(i, j) <> 0 Then
                    DrawMap(i, j, MapData(i, j))
                End If

            Next
        Next

        Label16.Text = cnt

        If RangeSelFlg = True Then
            Dim p As New Pen(Color.Black, 3)
            GraMap.DrawRectangle(p, RangeVal.Left * BLO_SIZE, RangeVal.Top * BLO_SIZE, (RangeVal.Width + 1) * BLO_SIZE, (RangeVal.Height + 1) * BLO_SIZE)
            p.Dispose()

        End If

        GraMap.Dispose() '解放

        Mapbox.Image = BmpMap

        Return 0

    End Function

    '関数　一個、指定したチップをマップに書く
    Public Function DrawMap(x As Integer, y As Integer, type As Integer)

        Dim GraMap As Graphics

        GraMap = Graphics.FromImage(BmpMap)
        '
        Dim desRect As New Rectangle(x * BLO_SIZE, y * BLO_SIZE, BLO_SIZE, BLO_SIZE)

        GraMap.DrawImage(ChipBox.Image, desRect, chip(selectchipnum).ChipRectList(chip(selectchipnum).ht(type)), GraphicsUnit.Pixel)

        Mapbox.Image = BmpMap

        GraMap.Dispose()

        Return 0


    End Function

    '関数　一個、指定したチップをマップに書く チップの元のサイズのまま描画する。
    Public Function DrawMap2(x As Integer, y As Integer, type As Integer)

        Dim GraMap As Graphics

        GraMap = Graphics.FromImage(BmpMap)

        Dim sizex As Integer = chip(selectchipnum).rectlist(chip(selectchipnum).Width)
        Dim sizey As Integer = chip(selectchipnum).rectlist(chip(selectchipnum).Height)
        '
        Dim desRect As New Rectangle(x * sizex, y * sizey, sizex, sizey)

        GraMap.DrawImage(chip(selectchipnum).bmp(selchip), desRect, chip(selectchipnum).ChipRectList(chip(selectchipnum).ht(type)), GraphicsUnit.Pixel)

        Mapbox.Image = BmpMap

        GraMap.Dispose()

        Return 0


    End Function

    '関数　グリッド線を引く
    Public Function DrawGrid(g As Graphics, p As PictureBox, size As Integer)
        If GridFlg = True Then


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

    '関数　init　初期化 
    Private Sub initsetting()
        Dim filename As String = "setting\InitConfiguration.txt"
        If System.IO.File.Exists(filename) Then


            '文字コード(ここでは、Shift JIS))
            Dim enc As System.Text.Encoding = System.Text.Encoding.GetEncoding("shift_jis")
            Dim text1 As String() = System.IO.File.ReadAllLines(filename, enc)

            Dim cnt As Integer = 0

            Dim li = New List(Of String)()
            Dim liva = New List(Of String)()

            For i As Integer = 0 To text1.Length - 1
                For j As Integer = 0 To text1(i).Length() - 1
                    If text1(i)(j) = "=" Then
                        li.Add(text1(i).Substring(0, j))
                        liva.Add(text1(i).Substring(j + 1, text1(i).Length() - (j + 1)))

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
                        backbmp = New Bitmap("background\" & backbmpfilename)
                    Case "MapChipSetFile"
                        MapChipSetFile = liva(i)
                    Case "TestPlayfile"
                        TestPlayfile = liva(i)
                    Case "Mapdatafile"
                        Mapdatafile = liva(i)
                    Case "Count"
                        countnum = liva(i)
                        TextBox13.Text = countnum
                End Select

            Next

        Else

        End If
        Button4.Text = "ON"
        Button10.Text = "OFF"
        TextBox3.Text = BLO_SIZE

        TextBox1.Text = COL_NUM
        TextBox2.Text = ROW_NUM
        TextBox5.Text = Mapdatafile

        'テキストボックスに０入れる
        TextBox12.Text = 0
        TextBox11.Text = 0
        TextBox10.Text = 0
        TextBox9.Text = 0
        TextBox4.Text = 0
        TextBox6.Text = 0
        TextBox7.Text = 0
        TextBox8.Text = 0
    End Sub

    '関数　DrawChip　
    Function DrawChip()

        Dim GraChip As Graphics

        ChipBox.Size = New Size(CHIP_SIZE * chipgyou, CHIP_SIZE * ((chip(selectchipnum).chipcnt \ chipgyou) + 1))


        If ChipMap Is Nothing Then
            ChipMap = New Bitmap(ChipBox.Width, ChipBox.Height)
        Else
            Dim oldimage = ChipMap
            ChipMap = New Bitmap(ChipBox.Width, ChipBox.Height)
            oldimage.Dispose()

        End If

        GraChip = Graphics.FromImage(ChipMap)

        For i As Integer = 0 To chip(selectchipnum).rectlist.count - 1
            GraChip.DrawImage(chip(selectchipnum).bmp(i), chip(selectchipnum).ChipRectList(i), chip(selectchipnum).rectlist(i), GraphicsUnit.Pixel)
        Next
        ' グリッドの描画
        DrawGrid(GraChip, ChipBox, CHIP_SIZE)

        ChipBox.Image = ChipMap

        GraChip.Dispose()

        Return 0

    End Function

    '関数 ReadChip
    Public Function readchip()

        Dim filename As String = MapChipSetFile
        If System.IO.File.Exists(filename) Then

            '文字コード(ここでは、Shift JIS)
            Dim enc As System.Text.Encoding = System.Text.Encoding.GetEncoding("shift_jis")
            Dim filetext As String() = System.IO.File.ReadAllLines(filename, enc)


            Dim cnt As Integer = 0

            Dim clist = New List(Of String)()
            Dim cntlist = New List(Of Integer)()

            For i As Integer = 0 To filetext.Length - 1
                Dim stcnt As Integer = 0
                'If filetext(i) = "1*1" Then
                '    Form1.TextBox3.Text &= "1*1" & vbCrLf
                'ElseIf filetext(i) = "1*2" Then
                '    Form1.TextBox3.Text &= "1*2" & vbCrLf
                'End If



                For j As Integer = 0 To filetext(i).Length() - 1
                    If filetext(i)(j) = "{" Then
                        chip.add(New chipinf)
                    End If
                    If filetext(i)(j) = "/" Then
                        cnt += 1
                        clist.Add(filetext(i).Substring(stcnt, j - stcnt))
                        stcnt = j + 1

                    ElseIf j = filetext(i).Length() - 1 Then
                        cnt += 1
                        clist.Add(filetext(i).Substring(stcnt, j - stcnt + 1))
                        cntlist.Add(cnt)
                        cnt = 0

                    End If
                Next
            Next


            Dim clistc = New List(Of String)()
            Dim listva = New List(Of String)()

            For i As Integer = 0 To clist.Count - 1
                For j As Integer = 0 To clist(i).Count - 1
                    If clist(i)(j) = "=" Then
                        clistc.Add(clist(i).Substring(0, j))
                        listva.Add(clist(i).Substring(j + 1, clist(i).Length() - (j + 1)))
                    End If
                Next
            Next


            For i As Integer = 0 To clistc.Count - 1
                Select Case clistc(i)
                    Case "chip"
                        'If Integer.Parse(listva(i)) > 0 Then
                        '    chip(selectchipnum).chipcnt = chip(selectchipnum).rectlist.count - 1

                        '    selectchipnum += 1


                        'End If

                    Case "type"
                        'chip(selectchipnum).typelist.add(Integer.Parse(listva(i), System.Globalization.NumberStyles.HexNumber))
                        chip(selectchipnum).typelist.add(Integer.Parse(listva(i)))
                    Case "rect"

                        Dim cntva As Integer = 0
                        Dim va() As Integer = {0, 0, 0, 0}
                        Dim stcnt As Integer = 0
                        Dim stval As String

                        For k As Integer = 0 To listva(i).Count - 1

                            If listva(i)(k) = "," Then
                                stval = listva(i).Substring(stcnt, k - stcnt)

                                va(cntva) = Integer.Parse(stval)

                                stcnt = k + 1
                                cntva += 1
                            ElseIf k = listva(i).Count - 1 Then
                                stval = listva(i).Substring(stcnt, k - stcnt + 1)

                                va(cntva) = Integer.Parse(stval)
                                chip(selectchipnum).rectlist.Add(New Rectangle(va(0), va(1), va(2), va(3)))


                            End If
                        Next

                    Case "file"

                        chip(selectchipnum).bmp.add(New Bitmap("mapchip\" & listva(i)))


                        'chip(selectchipnum).bmpht.add(New Bitmap("mapchip\" & listva(i)))
                        'bmpstring.add(listva(i))

                        'Case "ratio"
                        '    chip(selectchipnum).chipsizeratio.add(listva(i))


                End Select

            Next

        Else

        End If
        For k As Integer = 0 To chip.count - 1

            For i As Integer = 0 To chip(k).typelist.count - 1

                chip(k).ht.Add(chip(k).typelist(i), i)
            Next
            For i As Integer = 1 To chip(k).bmp.count - 1
                chip(k).bmp(i).MakeTransparent(Color.White)

            Next

        Next

        'For i As Integer = 0 To bmpstring.count - 1
        '    chip(selectchipnum).bmp.add(New Bitmap("mapchip\" & bmpstring(i)))

        'Next

        'For i As Integer = 0 To chip(selectchipnum).typelist.count - 1
        '    Form1.TextBox3.Text &= chip(selectchipnum).typelist(i) & "  " & chip(selectchipnum).ht(chip(selectchipnum).typelist(i)) & vbCrLf

        'Next
        'Form1.TextBox3.Text &= vbCrLf

        'For i As Integer = 0 To clistc.Count - 1
        '    Form1.TextBox3.Text &= clistc(i) & "  " & listva(i) & vbCrLf
        'Next
        'Form1.TextBox3.Text &= vbCrLf

        For k As Integer = 0 To chip.count - 1
            Dim chi As Integer = 0
            Dim chj As Integer = 0
            For i As Integer = 0 To chip(k).rectlist.count - 1
                If chj >= chipgyou Then
                    chi += 1
                    chj = 0
                End If
                Dim a As New Rectangle(chj * CHIP_SIZE, chi * CHIP_SIZE, CHIP_SIZE, CHIP_SIZE)
                chip(k).ChipRectList.Add(a)
                chj += 1
            Next
        Next

        chip(selectchipnum).chipcnt = chip(selectchipnum).rectlist.count - 1




        selectchipmax = chip.count - 1


        selectchipnum = 0
        Return 0
    End Function



    'フォームのイベントーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーー

    'フォームの最初のロード
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'サイズの設定　全画面モード
        Me.WindowState = FormWindowState.Maximized
        'Me.TopMost = True
        Me.Top = 0
        Me.Left = 0
        Me.Height = My.Computer.Screen.Bounds.Height
        Me.Width = My.Computer.Screen.Bounds.Width


        'tabpanel1の初期化ーー
        'map関係の初期化
        initsetting()
        DrawMm()

        'chip関係の初期化
        readchip()
        DrawChip()



    End Sub

    'フォームのサイズが変更されたとき
    Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        'サイズを調整する。
        TabControl1.Size = New Size(Me.Size.Width - 30, Me.Size.Height - 60)
        'MapPanel.Size = New Size(TabControl1.Size.Width - 300, TabControl1.Size.Height - 40)
    End Sub

    'フォームが閉じたとき　解放
    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        backbmp.Dispose()
        BmpMap.Dispose()
        Mapbox.Dispose()

        For i As Integer = 0 To chip.count - 1
            For j As Integer = 0 To chip(i).bmp.count - 1
                chip(i).bmp(j).Dispose()
            Next

        Next
    End Sub



    'mapbox関係ーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーー

    'mapboxの上でマウスを動かしたとき
    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles Mapbox.MouseMove
        Dim x As Integer = e.X \ BLO_SIZE
        Dim y As Integer = e.Y \ BLO_SIZE

        Label9.Text = x & "," & y

        If DownFlg = True Then

            If RangeSelFlg = True Then

            ElseIf RangeSelFlg = False Then

                If e.X < 0 Or e.Y < 0 Or e.X >= Mapbox.Width Or e.Y >= Mapbox.Height Then
                Else
                    If e.Button = MouseButtons.Left Then
                        MapData(x, y) = chip(selectchipnum).typelist(selchip)
                        DrawMap(x, y, chip(selectchipnum).typelist(selchip))
                    End If
                    If e.Button = MouseButtons.Right Then
                        MapData(x, y) = 0
                        DrawMap(x, y, 0)

                    End If
                End If
            End If
        End If

    End Sub

    'mapboxの上でマウスが押されたとき
    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles Mapbox.MouseDown
        Dim x As Integer = e.X \ BLO_SIZE
        Dim y As Integer = e.Y \ BLO_SIZE

        If RangeSelFlg = True Then
            DSelX = x
            DSelY = y

        ElseIf RangeSelFlg = False Then

            If e.X < 0 Or e.Y < 0 Or e.X >= Mapbox.Width Or e.Y >= Mapbox.Height Then
            Else

                If e.Button = MouseButtons.Left Then
                    MapData(x, y) = chip(selectchipnum).typelist(selchip)
                    DrawMap(x, y, chip(selectchipnum).typelist(selchip))
                End If

                If e.Button = MouseButtons.Right Then
                    MapData(x, y) = 0

                End If

            End If
        End If

        DownFlg = True

    End Sub

    'mapboxの上で押されたマウスが離れたとき
    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles Mapbox.MouseUp

        Dim x As Integer = e.X \ BLO_SIZE
        Dim y As Integer = e.Y \ BLO_SIZE

        If RangeSelFlg = True Then
            USelX = x
            USelY = y


            If USelX < 0 Or USelX > COL_NUM - 1 Or USelY < 0 Or USelY > ROW_NUM - 1 Then
            Else
                If DSelX <= USelX And DSelY <= USelY Then
                    RangeVal = New Rectangle(DSelX, DSelY, (USelX - DSelX), (USelY - DSelY))


                ElseIf DSelX >= USelX And DSelY >= USelY Then
                    RangeVal = New Rectangle(USelX, USelY, (DSelX - USelX), (DSelY - USelY))


                ElseIf DSelX >= USelX And DSelY <= USelY Then
                    RangeVal = New Rectangle(USelX, DSelY, (DSelX - USelX), (USelY - DSelY))

                ElseIf DSelX <= USelX And DSelY >= USelY Then
                    RangeVal = New Rectangle(DSelX, USelY, (USelX - DSelX), (DSelY - USelY))

                End If

            End If

            TextBox12.Text = RangeVal.Left
            TextBox11.Text = RangeVal.Top
            TextBox10.Text = RangeVal.Width + RangeVal.Left
            TextBox9.Text = RangeVal.Height + RangeVal.Top

        Else

        End If
        DownFlg = False


        DrawMm()

    End Sub



    'chipbox関係ーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーー

    'chipboxの上でマウスが押された時
    Private Sub ChipBox_MouseDown(sender As Object, e As MouseEventArgs) Handles ChipBox.MouseDown

        Dim Chipx As Integer
        Dim Chipy As Integer

        Dim selbmp As Bitmap
        Dim grasel As Graphics
        Chipx = e.X \ CHIP_SIZE
        Chipy = e.Y \ CHIP_SIZE

        If Chipy = 0 Then
            selchip = Chipx
        ElseIf Chipy >= 1 Then
            selchip = Chipx + (chipgyou * Chipy)
        Else selchip = 0

        End If
        If selchip > chip(selectchipnum).rectlist.count - 1 Then
            selchip = 0
        End If
        Label8.Text = chip(selectchipnum).typelist(selchip)

        TextBox4.Text = chip(selectchipnum).typelist(selchip)
        TextBox7.Text = chip(selectchipnum).typelist(selchip)
        TextBox8.Text = chip(selectchipnum).typelist(selchip)


        'DrawChip(Chipx, Chipy)


        SelectChipBox.Size = New Size(32, 32)
        selbmp = New Bitmap(SelectChipBox.Width, SelectChipBox.Height)
        grasel = Graphics.FromImage(selbmp)
        Dim desRect As New Rectangle(0, 0, 32, 32)
        grasel.DrawImage(chip(selectchipnum).bmp(selchip), desRect, chip(selectchipnum).rectlist(selchip), GraphicsUnit.Pixel)
        SelectChipBox.Image = selbmp



    End Sub

    'setting チップの設定ファイルを開く
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim psi As New System.Diagnostics.ProcessStartInfo()
        psi.FileName = MapChipSetFile
        Dim p As System.Diagnostics.Process = System.Diagnostics.Process.Start(psi)
    End Sub



    'TextPanel関係ーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーー

    'グリッド線を付けるかのボタン
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If GridFlg = True Then
            Button4.Text = "OFF"

            GridFlg = False
        ElseIf GridFlg = False Then
            Button4.Text = "ON"
            GridFlg = True

        End If
        'チップとマップを再描画
        DrawChip()
        DrawMm()

    End Sub

    'マップデータ　saveボタン　
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'OpenFileDialogクラスのインスタンスを作成
        Dim sfd As New SaveFileDialog()

        'はじめのファイル名を指定する
        'はじめに「ファイル名」で表示される文字列を指定する
        sfd.FileName = TextBox5.Text
        'はじめに表示されるフォルダを指定する
        '指定しない（空の文字列）の時は、現在のディレクトリが表示される
        sfd.InitialDirectory = System.IO.Directory.GetCurrentDirectory() & "\data"
        '[ファイルの種類]に表示される選択肢を指定する
        '指定しないとすべてのファイルが表示される
        sfd.Filter = "Textファイル(*.txt)|*.txt"
        '[ファイルの種類]ではじめに選択されるものを指定する
        '2番目の「すべてのファイル」が選択されているようにする
        sfd.FilterIndex = 2
        'タイトルを設定する
        sfd.Title = "ファイルを選択してください"
        'ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
        sfd.RestoreDirectory = True
        '存在しないファイルの名前が指定されたとき警告を表示する
        'デフォルトでTrueなので指定する必要はない
        sfd.OverwritePrompt = True
        '存在しないパスが指定されたとき警告を表示する
        'デフォルトでTrueなので指定する必要はない
        sfd.CheckPathExists = True

        'ダイアログを表示する
        If sfd.ShowDialog() = DialogResult.OK Then
            'OKボタンがクリックされたとき、選択されたファイル名を表示する

            Dim mapdatast As String

            mapdatast = COL_NUM & "," & ROW_NUM & "," & vbCrLf

            For i As Integer = 0 To ROW_NUM - 1
                For j As Integer = 0 To COL_NUM - 1
                    mapdatast = mapdatast & MapData(j, i) & ","
                Next
                mapdatast = mapdatast & vbCrLf
            Next

            'Shift JISで書き込む
            '書き込むファイルが既に存在している場合は、上書きする
            Dim sw As New System.IO.StreamWriter(sfd.FileName,
                False,
                System.Text.Encoding.GetEncoding("shift_jis"))
            'TextBox1.Textの内容を書き込む
            sw.Write(mapdatast)
            '閉じる
            sw.Close()

            Dim s As String
            s = sfd.FileName
            Dim stcnt As Integer = 0

            For i As Integer = 0 To s.Length - 1

                If s(i) = "\" Then

                    stcnt = i + 1

                ElseIf i = s.Length() - 1 Then

                    TextBox5.Text = s.Substring(stcnt, i - stcnt + 1)


                End If

            Next


        End If


    End Sub

    'マップデータ　readボタン
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        'OpenFileDialogクラスのインスタンスを作成
        Dim ofd As New OpenFileDialog()

        'はじめのファイル名を指定する
        'はじめに「ファイル名」で表示される文字列を指定する
        ofd.FileName = TextBox5.Text
        'はじめに表示されるフォルダを指定する
        '指定しない（空の文字列）の時は、現在のディレクトリが表示される
        ofd.InitialDirectory = System.IO.Directory.GetCurrentDirectory() & "\data"
        '[ファイルの種類]に表示される選択肢を指定する
        '指定しないとすべてのファイルが表示される
        ofd.Filter = "Textファイル(*.txt)|*.txt"
        '[ファイルの種類]ではじめに選択されるものを指定する
        '2番目の「すべてのファイル」が選択されているようにする
        ofd.FilterIndex = 2
        'タイトルを設定する
        ofd.Title = "開くファイルを選択してください"
        'ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
        ofd.RestoreDirectory = True
        '存在しないファイルの名前が指定されたとき警告を表示する
        'デフォルトでTrueなので指定する必要はない
        ofd.CheckFileExists = True
        '存在しないパスが指定されたとき警告を表示する
        'デフォルトでTrueなので指定する必要はない
        ofd.CheckPathExists = True

        'ダイアログを表示する
        If ofd.ShowDialog() = DialogResult.OK Then
            'OKボタンがクリックされたとき、選択されたファイル名を表示する
            'Console.WriteLine(ofd.FileName)]
            If System.IO.File.Exists(ofd.FileName) Then

                '"C:\test\1.txt"をShift-JISコードとして開く
                Dim sr As New System.IO.StreamReader(ofd.FileName,
                 System.Text.Encoding.GetEncoding("shift_jis"))
                '内容をすべて読み込む
                'ReadMapStr = sr.ReadToEnd()
                '閉じる
                sr.Close()



                'ファイル名と文字エンコードを指定してパーサを実体化
                Dim txtParser As Microsoft.VisualBasic.FileIO.TextFieldParser =
                    New Microsoft.VisualBasic.FileIO.TextFieldParser(
                                 ofd.FileName,
                                System.Text.Encoding.GetEncoding("shift_jis"))

                '内容は区切り文字形式
                txtParser.TextFieldType =
                    Microsoft.VisualBasic.FileIO.FieldType.Delimited

                'デリミタはカンマ
                txtParser.SetDelimiters(",")
                Dim j As Integer = 0
                While Not txtParser.EndOfData

                    '一行を読み込んで配列に結果を受け取る
                    Dim splittedResult As String() = txtParser.ReadFields()


                    If j = 0 Then
                        COL_NUM = Integer.Parse(splittedResult(0))
                        ROW_NUM = Integer.Parse(splittedResult(1))
                        TextBox1.Text = COL_NUM
                        TextBox2.Text = ROW_NUM

                    End If

                    For i As Integer = 0 To splittedResult.Length - 2 '最後の文字の中に入っているのは改行コード

                        If j <> 0 Then

                            MapData(i, j - 1) = Integer.Parse(splittedResult(i))
                        End If
                    Next


                    j += 1

                End While

                DrawMm()

                For k As Integer = 0 To COL_NUM - 1
                    For l As Integer = 0 To ROW_NUM - 1
                        If MapData(k, l) <> 0 Then
                            DrawMap(k, l, MapData(k, l))
                        End If

                    Next
                Next

            Else

            End If

            'テキストボックスに選択したファイルをｃ：～～の部分を切り取ってる
            Dim s As String
            s = ofd.FileName
            Dim stcnt As Integer = 0

            For i As Integer = 0 To s.Length - 1

                If s(i) = "\" Then

                    stcnt = i + 1

                ElseIf i = s.Length() - 1 Then

                    TextBox5.Text = s.Substring(stcnt, i - stcnt + 1)

                End If

            Next

        End If

    End Sub

    'マップデータ　clearボタン
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        For i As Integer = 0 To COL_NUM - 1
            For j As Integer = 0 To ROW_NUM - 1
                If MapData(i, j) <> 0 Then
                    MapData(i, j) = 0
                    DrawMap(i, j, MapData(i, j))
                End If
            Next
        Next

        Dim data As String = ""
        data = COL_NUM & "," & ROW_NUM & "," & vbCrLf
        For i As Integer = 0 To ROW_NUM - 1
            For j As Integer = 0 To COL_NUM - 1
                data = data & MapData(j, i) & ","
            Next
            data = data & vbCrLf
        Next

        DrawMm()
    End Sub

    'バックグラウンドの読み込みボタン
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        'OpenFileDialogクラスのインスタンスを作成
        Dim ofd As New OpenFileDialog()

        'はじめのファイル名を指定する
        'はじめに「ファイル名」で表示される文字列を指定する
        ofd.FileName = backbmpfilename
        'はじめに表示されるフォルダを指定する
        '指定しない（空の文字列）の時は、現在のディレクトリが表示される
        ofd.InitialDirectory = System.IO.Directory.GetCurrentDirectory() & "\background"
        '[ファイルの種類]に表示される選択肢を指定する
        '指定しないとすべてのファイルが表示される
        ofd.Filter = "Imageファイル(*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png"
        '[ファイルの種類]ではじめに選択されるものを指定する
        '2番目の「すべてのファイル」が選択されているようにする
        ofd.FilterIndex = 2
        'タイトルを設定する
        ofd.Title = "開くファイルを選択してください"
        'ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
        ofd.RestoreDirectory = True
        '存在しないファイルの名前が指定されたとき警告を表示する
        'デフォルトでTrueなので指定する必要はない
        ofd.CheckFileExists = True
        '存在しないパスが指定されたとき警告を表示する
        'デフォルトでTrueなので指定する必要はない
        ofd.CheckPathExists = True

        'ダイアログを表示する
        If ofd.ShowDialog() = DialogResult.OK Then
            'OKボタンがクリックされたとき、選択されたファイル名を表示する


            If System.IO.File.Exists(ofd.FileName) Then
                Dim oldimage As Bitmap = backbmp

                backbmp = New Bitmap(ofd.FileName)

                oldimage.Dispose()

                DrawMm()

            End If

        End If

    End Sub

    '背景セーブボタン
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        'OpenFileDialogクラスのインスタンスを作成
        Dim sfdi As New SaveFileDialog()

        'はじめのファイル名を指定する
        'はじめに「ファイル名」で表示される文字列を指定する
        sfdi.FileName = "gameimage.png"
        'はじめに表示されるフォルダを指定する
        '指定しない（空の文字列）の時は、現在のディレクトリが表示される
        sfdi.InitialDirectory = System.IO.Directory.GetCurrentDirectory() & "\background"
        '[ファイルの種類]に表示される選択肢を指定する
        '指定しないとすべてのファイルが表示される
        sfdi.Filter = "Imageファイル(*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png"
        '[ファイルの種類]ではじめに選択されるものを指定する
        '2番目の「すべてのファイル」が選択されているようにする
        sfdi.FilterIndex = 2
        'タイトルを設定する
        sfdi.Title = "ファイルを選択してください"
        'ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
        sfdi.RestoreDirectory = True
        '存在しないファイルの名前が指定されたとき警告を表示する
        'デフォルトでTrueなので指定する必要はない
        sfdi.OverwritePrompt = True
        '存在しないパスが指定されたとき警告を表示する
        'デフォルトでTrueなので指定する必要はない
        sfdi.CheckPathExists = True

        'ダイアログを表示する
        If sfdi.ShowDialog() = DialogResult.OK Then

            Mapbox.Image.Save(sfdi.FileName)
        End If
    End Sub

    '囲いの選択ボタン
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If RangeSelFlg = True Then
            Button10.Text = "OFF"

            RangeSelFlg = False
        ElseIf RangeSelFlg = False Then
            Button10.Text = "ON"
            RangeSelFlg = True

        End If
        DrawMm()


    End Sub

    'マップチップ数のボタン　　～１０２４
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TextBox1.Text <= 1023 And TextBox2.Text <= 1023 Then

            COL_NUM = TextBox1.Text
            ROW_NUM = TextBox2.Text
            'フォーム①のピクチャボックス再設定
            DrawMm()

            For i As Integer = 0 To COL_NUM - 1
                For j As Integer = 0 To ROW_NUM - 1
                    If MapData(i, j) <> 0 Then

                        DrawMap(i, j, MapData(i, j))
                    End If
                Next
            Next


        End If
    End Sub

    'マップチップサイズのボタン１～１００
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

        If TextBox3.Text > 0 And TextBox3.Text < 100 Then

            BLO_SIZE = Integer.Parse(TextBox3.Text)

            DrawMm()

        End If

    End Sub

    'テストプレイボタン
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim psi As New System.Diagnostics.ProcessStartInfo()
        psi.FileName = TestPlayfile
        Dim p As System.Diagnostics.Process = System.Diagnostics.Process.Start(psi)
    End Sub




    'opepanel関係------------------------------------------------------------------------

    '塗りつぶしボタン
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim val As Integer
        val = Integer.Parse(TextBox4.Text)
        For i As Integer = Integer.Parse(TextBox12.Text) To Integer.Parse(TextBox10.Text)
            For j As Integer = Integer.Parse(TextBox11.Text) To Integer.Parse(TextBox9.Text)

                MapData(i, j) = val
            Next
        Next
        DrawMm()
    End Sub

    '置換ボタン
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim fval As Integer = Integer.Parse(TextBox6.Text)
        Dim val As Integer = Integer.Parse(TextBox7.Text)
        For i As Integer = Integer.Parse(TextBox12.Text) To Integer.Parse(TextBox10.Text)
            For j As Integer = Integer.Parse(TextBox11.Text) To Integer.Parse(TextBox9.Text)
                If MapData(i, j) = fval Then
                    MapData(i, j) = val

                End If
            Next
        Next
        DrawMm()
    End Sub

    '枠ボタン
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        For i As Integer = Integer.Parse(TextBox12.Text) To Integer.Parse(TextBox10.Text)
            For j As Integer = Integer.Parse(TextBox11.Text) To Integer.Parse(TextBox9.Text)
                If i = Integer.Parse(TextBox12.Text) Or i = Integer.Parse(TextBox10.Text) Or j = Integer.Parse(TextBox11.Text) Or j = Integer.Parse(TextBox9.Text) Then
                    MapData(i, j) = Integer.Parse(TextBox8.Text)

                End If
            Next
        Next
        DrawMm()
    End Sub


    'TabPanel2----------------------------------------------------------------------------

End Class
