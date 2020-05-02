<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.MapPanel = New System.Windows.Forms.Panel()
        Me.Mapbox = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ChipPanel = New System.Windows.Forms.Panel()
        Me.ChipBox = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SelectChipBox = New System.Windows.Forms.PictureBox()
        Me.TypeText = New System.Windows.Forms.Label()
        Me.TextPanel = New System.Windows.Forms.Panel()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.MapPanel.SuspendLayout()
        CType(Me.Mapbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ChipPanel.SuspendLayout()
        CType(Me.ChipBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.SelectChipBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TextPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(13, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1559, 837)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.TextPanel)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.ChipPanel)
        Me.TabPage1.Controls.Add(Me.MapPanel)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1551, 811)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'MapPanel
        '
        Me.MapPanel.BackColor = System.Drawing.Color.Snow
        Me.MapPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MapPanel.Controls.Add(Me.Mapbox)
        Me.MapPanel.Location = New System.Drawing.Point(282, 6)
        Me.MapPanel.Name = "MapPanel"
        Me.MapPanel.Size = New System.Drawing.Size(987, 799)
        Me.MapPanel.TabIndex = 0
        '
        'Mapbox
        '
        Me.Mapbox.Location = New System.Drawing.Point(4, 4)
        Me.Mapbox.Name = "Mapbox"
        Me.Mapbox.Size = New System.Drawing.Size(100, 50)
        Me.Mapbox.TabIndex = 0
        Me.Mapbox.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(376, 390)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ChipPanel
        '
        Me.ChipPanel.AutoScroll = True
        Me.ChipPanel.BackColor = System.Drawing.Color.Snow
        Me.ChipPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ChipPanel.Controls.Add(Me.ChipBox)
        Me.ChipPanel.Location = New System.Drawing.Point(6, 6)
        Me.ChipPanel.Name = "ChipPanel"
        Me.ChipPanel.Size = New System.Drawing.Size(270, 313)
        Me.ChipPanel.TabIndex = 21
        '
        'ChipBox
        '
        Me.ChipBox.Location = New System.Drawing.Point(4, 5)
        Me.ChipBox.Name = "ChipBox"
        Me.ChipBox.Size = New System.Drawing.Size(100, 50)
        Me.ChipBox.TabIndex = 0
        Me.ChipBox.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Snow
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.SelectChipBox)
        Me.Panel1.Controls.Add(Me.TypeText)
        Me.Panel1.Location = New System.Drawing.Point(6, 325)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(270, 60)
        Me.Panel1.TabIndex = 22
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(191, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(58, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Setting"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label8.Location = New System.Drawing.Point(83, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 22)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "0"
        '
        'SelectChipBox
        '
        Me.SelectChipBox.BackColor = System.Drawing.Color.Transparent
        Me.SelectChipBox.Location = New System.Drawing.Point(132, 9)
        Me.SelectChipBox.Name = "SelectChipBox"
        Me.SelectChipBox.Size = New System.Drawing.Size(32, 30)
        Me.SelectChipBox.TabIndex = 11
        Me.SelectChipBox.TabStop = False
        '
        'TypeText
        '
        Me.TypeText.AutoSize = True
        Me.TypeText.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TypeText.Location = New System.Drawing.Point(3, 9)
        Me.TypeText.Name = "TypeText"
        Me.TypeText.Size = New System.Drawing.Size(55, 22)
        Me.TypeText.TabIndex = 1
        Me.TypeText.Text = "Type"
        '
        'TextPanel
        '
        Me.TextPanel.AutoScroll = True
        Me.TextPanel.BackColor = System.Drawing.Color.Snow
        Me.TextPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.TextPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextPanel.Controls.Add(Me.Button9)
        Me.TextPanel.Controls.Add(Me.Button4)
        Me.TextPanel.Controls.Add(Me.PictureBox1)
        Me.TextPanel.Controls.Add(Me.Label7)
        Me.TextPanel.Controls.Add(Me.Button8)
        Me.TextPanel.Controls.Add(Me.Button7)
        Me.TextPanel.Controls.Add(Me.Button3)
        Me.TextPanel.Controls.Add(Me.TextBox5)
        Me.TextPanel.Controls.Add(Me.Label6)
        Me.TextPanel.Controls.Add(Me.Button5)
        Me.TextPanel.Controls.Add(Me.Button6)
        Me.TextPanel.Controls.Add(Me.TextBox2)
        Me.TextPanel.Controls.Add(Me.TextBox1)
        Me.TextPanel.Controls.Add(Me.Label3)
        Me.TextPanel.Controls.Add(Me.Button10)
        Me.TextPanel.Controls.Add(Me.Label2)
        Me.TextPanel.Controls.Add(Me.Label4)
        Me.TextPanel.Controls.Add(Me.Button11)
        Me.TextPanel.Controls.Add(Me.TextBox3)
        Me.TextPanel.Controls.Add(Me.Label9)
        Me.TextPanel.Controls.Add(Me.Label5)
        Me.TextPanel.Location = New System.Drawing.Point(6, 391)
        Me.TextPanel.Name = "TextPanel"
        Me.TextPanel.Size = New System.Drawing.Size(268, 414)
        Me.TextPanel.TabIndex = 23
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(128, 169)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 23)
        Me.Button9.TabIndex = 42
        Me.Button9.Text = "save"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Location = New System.Drawing.Point(13, 214)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(40, 25)
        Me.Button4.TabIndex = 41
        Me.Button4.Text = "ON"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(83, 171)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 22)
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 16)
        Me.Label7.TabIndex = 38
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(202, 141)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(44, 21)
        Me.Button8.TabIndex = 37
        Me.Button8.Text = "clear"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(140, 141)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(44, 21)
        Me.Button7.TabIndex = 36
        Me.Button7.Text = "read"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(83, 140)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(44, 22)
        Me.Button3.TabIndex = 35
        Me.Button3.Text = "save"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(83, 112)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(163, 19)
        Me.TextBox5.TabIndex = 34
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 22)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "MapD"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(202, 325)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(44, 23)
        Me.Button5.TabIndex = 32
        Me.Button5.Text = "TEST"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(202, 46)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(44, 19)
        Me.Button6.TabIndex = 31
        Me.Button6.Text = "B"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(140, 46)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(51, 19)
        Me.TextBox2.TabIndex = 30
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(83, 46)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(51, 19)
        Me.TextBox1.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 22)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "cW,H"
        '
        'Button10
        '
        Me.Button10.BackgroundImage = CType(resources.GetObject("Button10.BackgroundImage"), System.Drawing.Image)
        Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button10.Location = New System.Drawing.Point(13, 245)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(40, 25)
        Me.Button10.TabIndex = 27
        Me.Button10.Text = "OFF"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 22)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "BImg"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 22)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Size"
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(202, 80)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(44, 19)
        Me.Button11.TabIndex = 16
        Me.Button11.Text = "B"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(83, 80)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(108, 19)
        Me.TextBox3.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label9.Location = New System.Drawing.Point(191, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 22)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "0 , 0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 22)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "W,H"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Snow
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TextBox8)
        Me.Panel2.Controls.Add(Me.Button12)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Button13)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.TextBox7)
        Me.Panel2.Controls.Add(Me.TextBox6)
        Me.Panel2.Controls.Add(Me.Button14)
        Me.Panel2.Controls.Add(Me.TextBox4)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.TextBox9)
        Me.Panel2.Controls.Add(Me.TextBox10)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.TextBox11)
        Me.Panel2.Controls.Add(Me.TextBox12)
        Me.Panel2.Location = New System.Drawing.Point(1275, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(270, 799)
        Me.Panel2.TabIndex = 24
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(123, 133)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(44, 19)
        Me.TextBox8.TabIndex = 33
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(173, 131)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(75, 23)
        Me.Button12.TabIndex = 32
        Me.Button12.Text = "B"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 136)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(17, 12)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "枠"
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(173, 93)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(75, 23)
        Me.Button13.TabIndex = 30
        Me.Button13.Text = "B"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(97, 102)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(17, 12)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "→"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 98)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(29, 12)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "置換"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(123, 95)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(44, 19)
        Me.TextBox7.TabIndex = 27
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(47, 95)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(44, 19)
        Me.TextBox6.TabIndex = 26
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(173, 55)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(75, 23)
        Me.Button14.TabIndex = 25
        Me.Button14.Text = "B"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(123, 57)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(44, 19)
        Me.TextBox4.TabIndex = 24
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 60)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 12)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "塗りつぶし"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(138, 18)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(10, 12)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "~"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(204, 11)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(44, 19)
        Me.TextBox9.TabIndex = 21
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(154, 11)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(44, 19)
        Me.TextBox10.TabIndex = 20
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 14)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(29, 12)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "範囲"
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(88, 11)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(44, 19)
        Me.TextBox11.TabIndex = 18
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(38, 11)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(44, 19)
        Me.TextBox12.TabIndex = 17
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1584, 861)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Main"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.MapPanel.ResumeLayout(False)
        CType(Me.Mapbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ChipPanel.ResumeLayout(False)
        CType(Me.ChipBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.SelectChipBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TextPanel.ResumeLayout(False)
        Me.TextPanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents MapPanel As Panel
    Friend WithEvents Mapbox As PictureBox
    Friend WithEvents ChipPanel As Panel
    Friend WithEvents ChipBox As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents SelectChipBox As PictureBox
    Friend WithEvents TypeText As Label
    Friend WithEvents TextPanel As Panel
    Friend WithEvents Button9 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button10 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button11 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Button12 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Button13 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Button14 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox12 As TextBox
End Class
