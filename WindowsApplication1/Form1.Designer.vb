<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ship = New System.Windows.Forms.PictureBox()
        Me.en1 = New System.Windows.Forms.PictureBox()
        Me.en2 = New System.Windows.Forms.PictureBox()
        Me.en3 = New System.Windows.Forms.PictureBox()
        Me.en4 = New System.Windows.Forms.PictureBox()
        Me.en5 = New System.Windows.Forms.PictureBox()
        Me.blt5 = New System.Windows.Forms.PictureBox()
        Me.tshipblt = New System.Windows.Forms.Timer(Me.components)
        Me.blt4 = New System.Windows.Forms.PictureBox()
        Me.blt3 = New System.Windows.Forms.PictureBox()
        Me.blt2 = New System.Windows.Forms.PictureBox()
        Me.blt1 = New System.Windows.Forms.PictureBox()
        Me.ten1blt = New System.Windows.Forms.Timer(Me.components)
        Me.ten2blt = New System.Windows.Forms.Timer(Me.components)
        Me.ten3blt = New System.Windows.Forms.Timer(Me.components)
        Me.ten4blt = New System.Windows.Forms.Timer(Me.components)
        Me.ten5blt = New System.Windows.Forms.Timer(Me.components)
        Me.en1bt = New System.Windows.Forms.PictureBox()
        Me.en2bt = New System.Windows.Forms.PictureBox()
        Me.en3bt = New System.Windows.Forms.PictureBox()
        Me.en4bt = New System.Windows.Forms.PictureBox()
        Me.en5bt = New System.Windows.Forms.PictureBox()
        Me.fxship = New System.Windows.Forms.Timer(Me.components)
        Me.ensycmv1 = New System.Windows.Forms.Timer(Me.components)
        Me.ensycmv2 = New System.Windows.Forms.Timer(Me.components)
        Me.hp = New System.Windows.Forms.PictureBox()
        Me.boss = New System.Windows.Forms.PictureBox()
        Me.bossAI = New System.Windows.Forms.Timer(Me.components)
        Me.bossblt = New System.Windows.Forms.PictureBox()
        Me.tbossbt = New System.Windows.Forms.Timer(Me.components)
        Me.bosshp = New System.Windows.Forms.ProgressBar()
        CType(Me.ship, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.en1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.en2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.en3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.en4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.en5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blt5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blt4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blt3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blt2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blt1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.en1bt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.en2bt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.en3bt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.en4bt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.en5bt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.boss, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bossblt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ship
        '
        Me.ship.BackColor = System.Drawing.Color.Transparent
        Me.ship.Image = Global.WindowsApplication1.My.Resources.Resources.ship1
        Me.ship.Location = New System.Drawing.Point(468, 471)
        Me.ship.Name = "ship"
        Me.ship.Size = New System.Drawing.Size(75, 70)
        Me.ship.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ship.TabIndex = 0
        Me.ship.TabStop = False
        '
        'en1
        '
        Me.en1.BackColor = System.Drawing.Color.Transparent
        Me.en1.Image = Global.WindowsApplication1.My.Resources.Resources.en5_1
        Me.en1.Location = New System.Drawing.Point(295, 56)
        Me.en1.Name = "en1"
        Me.en1.Size = New System.Drawing.Size(66, 60)
        Me.en1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.en1.TabIndex = 1
        Me.en1.TabStop = False
        '
        'en2
        '
        Me.en2.BackColor = System.Drawing.Color.Transparent
        Me.en2.Image = Global.WindowsApplication1.My.Resources.Resources.en5_1
        Me.en2.Location = New System.Drawing.Point(437, 122)
        Me.en2.Name = "en2"
        Me.en2.Size = New System.Drawing.Size(68, 60)
        Me.en2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.en2.TabIndex = 2
        Me.en2.TabStop = False
        '
        'en3
        '
        Me.en3.BackColor = System.Drawing.Color.Transparent
        Me.en3.Image = Global.WindowsApplication1.My.Resources.Resources.en5_1
        Me.en3.Location = New System.Drawing.Point(580, 56)
        Me.en3.Name = "en3"
        Me.en3.Size = New System.Drawing.Size(68, 60)
        Me.en3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.en3.TabIndex = 3
        Me.en3.TabStop = False
        '
        'en4
        '
        Me.en4.BackColor = System.Drawing.Color.Transparent
        Me.en4.Image = Global.WindowsApplication1.My.Resources.Resources.en5_1
        Me.en4.Location = New System.Drawing.Point(730, 109)
        Me.en4.Name = "en4"
        Me.en4.Size = New System.Drawing.Size(67, 60)
        Me.en4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.en4.TabIndex = 4
        Me.en4.TabStop = False
        '
        'en5
        '
        Me.en5.BackColor = System.Drawing.Color.Transparent
        Me.en5.Image = Global.WindowsApplication1.My.Resources.Resources.en5_1
        Me.en5.Location = New System.Drawing.Point(863, 56)
        Me.en5.Name = "en5"
        Me.en5.Size = New System.Drawing.Size(68, 60)
        Me.en5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.en5.TabIndex = 5
        Me.en5.TabStop = False
        '
        'blt5
        '
        Me.blt5.BackColor = System.Drawing.Color.Transparent
        Me.blt5.Image = CType(resources.GetObject("blt5.Image"), System.Drawing.Image)
        Me.blt5.Location = New System.Drawing.Point(315, 490)
        Me.blt5.Name = "blt5"
        Me.blt5.Size = New System.Drawing.Size(10, 30)
        Me.blt5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.blt5.TabIndex = 6
        Me.blt5.TabStop = False
        Me.blt5.Visible = False
        '
        'tshipblt
        '
        '
        'blt4
        '
        Me.blt4.BackColor = System.Drawing.Color.Transparent
        Me.blt4.Image = CType(resources.GetObject("blt4.Image"), System.Drawing.Image)
        Me.blt4.Location = New System.Drawing.Point(331, 490)
        Me.blt4.Name = "blt4"
        Me.blt4.Size = New System.Drawing.Size(11, 30)
        Me.blt4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.blt4.TabIndex = 7
        Me.blt4.TabStop = False
        Me.blt4.Visible = False
        '
        'blt3
        '
        Me.blt3.BackColor = System.Drawing.Color.Transparent
        Me.blt3.Image = CType(resources.GetObject("blt3.Image"), System.Drawing.Image)
        Me.blt3.Location = New System.Drawing.Point(348, 490)
        Me.blt3.Name = "blt3"
        Me.blt3.Size = New System.Drawing.Size(11, 30)
        Me.blt3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.blt3.TabIndex = 8
        Me.blt3.TabStop = False
        Me.blt3.Visible = False
        '
        'blt2
        '
        Me.blt2.BackColor = System.Drawing.Color.Transparent
        Me.blt2.Image = CType(resources.GetObject("blt2.Image"), System.Drawing.Image)
        Me.blt2.Location = New System.Drawing.Point(365, 490)
        Me.blt2.Name = "blt2"
        Me.blt2.Size = New System.Drawing.Size(11, 30)
        Me.blt2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.blt2.TabIndex = 9
        Me.blt2.TabStop = False
        Me.blt2.Visible = False
        '
        'blt1
        '
        Me.blt1.BackColor = System.Drawing.Color.Transparent
        Me.blt1.Image = CType(resources.GetObject("blt1.Image"), System.Drawing.Image)
        Me.blt1.Location = New System.Drawing.Point(382, 490)
        Me.blt1.Name = "blt1"
        Me.blt1.Size = New System.Drawing.Size(11, 30)
        Me.blt1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.blt1.TabIndex = 10
        Me.blt1.TabStop = False
        Me.blt1.Visible = False
        '
        'ten1blt
        '
        Me.ten1blt.Enabled = True
        Me.ten1blt.Interval = 80
        '
        'ten2blt
        '
        Me.ten2blt.Enabled = True
        Me.ten2blt.Interval = 20
        '
        'ten3blt
        '
        Me.ten3blt.Enabled = True
        Me.ten3blt.Interval = 50
        '
        'ten4blt
        '
        Me.ten4blt.Enabled = True
        Me.ten4blt.Interval = 10
        '
        'ten5blt
        '
        Me.ten5blt.Enabled = True
        Me.ten5blt.Interval = 150
        '
        'en1bt
        '
        Me.en1bt.BackColor = System.Drawing.Color.Transparent
        Me.en1bt.Image = Global.WindowsApplication1.My.Resources.Resources.greenblt
        Me.en1bt.Location = New System.Drawing.Point(312, 109)
        Me.en1bt.Name = "en1bt"
        Me.en1bt.Size = New System.Drawing.Size(30, 72)
        Me.en1bt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.en1bt.TabIndex = 12
        Me.en1bt.TabStop = False
        '
        'en2bt
        '
        Me.en2bt.BackColor = System.Drawing.Color.Transparent
        Me.en2bt.Image = Global.WindowsApplication1.My.Resources.Resources.greenblt
        Me.en2bt.Location = New System.Drawing.Point(457, 169)
        Me.en2bt.Name = "en2bt"
        Me.en2bt.Size = New System.Drawing.Size(30, 73)
        Me.en2bt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.en2bt.TabIndex = 13
        Me.en2bt.TabStop = False
        '
        'en3bt
        '
        Me.en3bt.BackColor = System.Drawing.Color.Transparent
        Me.en3bt.Image = Global.WindowsApplication1.My.Resources.Resources.greenblt
        Me.en3bt.Location = New System.Drawing.Point(598, 107)
        Me.en3bt.Name = "en3bt"
        Me.en3bt.Size = New System.Drawing.Size(30, 72)
        Me.en3bt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.en3bt.TabIndex = 14
        Me.en3bt.TabStop = False
        '
        'en4bt
        '
        Me.en4bt.BackColor = System.Drawing.Color.Transparent
        Me.en4bt.Image = Global.WindowsApplication1.My.Resources.Resources.greenblt
        Me.en4bt.Location = New System.Drawing.Point(752, 160)
        Me.en4bt.Name = "en4bt"
        Me.en4bt.Size = New System.Drawing.Size(30, 72)
        Me.en4bt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.en4bt.TabIndex = 15
        Me.en4bt.TabStop = False
        '
        'en5bt
        '
        Me.en5bt.BackColor = System.Drawing.Color.Transparent
        Me.en5bt.Image = Global.WindowsApplication1.My.Resources.Resources.greenblt
        Me.en5bt.Location = New System.Drawing.Point(883, 99)
        Me.en5bt.Name = "en5bt"
        Me.en5bt.Size = New System.Drawing.Size(30, 70)
        Me.en5bt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.en5bt.TabIndex = 16
        Me.en5bt.TabStop = False
        '
        'fxship
        '
        '
        'ensycmv1
        '
        Me.ensycmv1.Enabled = True
        Me.ensycmv1.Interval = 500
        '
        'ensycmv2
        '
        Me.ensycmv2.Interval = 500
        '
        'hp
        '
        Me.hp.BackColor = System.Drawing.Color.Transparent
        Me.hp.Image = Global.WindowsApplication1.My.Resources.Resources.life1
        Me.hp.Location = New System.Drawing.Point(868, 522)
        Me.hp.Name = "hp"
        Me.hp.Size = New System.Drawing.Size(116, 33)
        Me.hp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.hp.TabIndex = 17
        Me.hp.TabStop = False
        '
        'boss
        '
        Me.boss.BackColor = System.Drawing.Color.Transparent
        Me.boss.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.boss.Image = Global.WindowsApplication1.My.Resources.Resources.alien1_1
        Me.boss.Location = New System.Drawing.Point(908, 537)
        Me.boss.Name = "boss"
        Me.boss.Size = New System.Drawing.Size(222, 220)
        Me.boss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.boss.TabIndex = 18
        Me.boss.TabStop = False
        Me.boss.Visible = False
        '
        'bossAI
        '
        Me.bossAI.Interval = 10
        '
        'bossblt
        '
        Me.bossblt.BackColor = System.Drawing.Color.Transparent
        Me.bossblt.Image = Global.WindowsApplication1.My.Resources.Resources.greenblt
        Me.bossblt.Location = New System.Drawing.Point(-48, -187)
        Me.bossblt.Name = "bossblt"
        Me.bossblt.Size = New System.Drawing.Size(128, 231)
        Me.bossblt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bossblt.TabIndex = 19
        Me.bossblt.TabStop = False
        Me.bossblt.Visible = False
        '
        'tbossbt
        '
        '
        'bosshp
        '
        Me.bosshp.Location = New System.Drawing.Point(12, 12)
        Me.bosshp.Name = "bosshp"
        Me.bosshp.Size = New System.Drawing.Size(100, 23)
        Me.bosshp.TabIndex = 20
        Me.bosshp.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(986, 558)
        Me.Controls.Add(Me.hp)
        Me.Controls.Add(Me.bosshp)
        Me.Controls.Add(Me.boss)
        Me.Controls.Add(Me.en5)
        Me.Controls.Add(Me.en2)
        Me.Controls.Add(Me.en5bt)
        Me.Controls.Add(Me.blt1)
        Me.Controls.Add(Me.blt2)
        Me.Controls.Add(Me.blt3)
        Me.Controls.Add(Me.blt4)
        Me.Controls.Add(Me.blt5)
        Me.Controls.Add(Me.en4)
        Me.Controls.Add(Me.en3)
        Me.Controls.Add(Me.en1)
        Me.Controls.Add(Me.ship)
        Me.Controls.Add(Me.en3bt)
        Me.Controls.Add(Me.en1bt)
        Me.Controls.Add(Me.en2bt)
        Me.Controls.Add(Me.en4bt)
        Me.Controls.Add(Me.bossblt)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.ship, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.en1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.en2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.en3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.en4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.en5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blt5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blt4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blt3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blt2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blt1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.en1bt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.en2bt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.en3bt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.en4bt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.en5bt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.boss, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bossblt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ship As System.Windows.Forms.PictureBox
    Friend WithEvents en1 As System.Windows.Forms.PictureBox
    Friend WithEvents en2 As System.Windows.Forms.PictureBox
    Friend WithEvents en3 As System.Windows.Forms.PictureBox
    Friend WithEvents en4 As System.Windows.Forms.PictureBox
    Friend WithEvents en5 As System.Windows.Forms.PictureBox
    Friend WithEvents blt5 As System.Windows.Forms.PictureBox
    Friend WithEvents tshipblt As System.Windows.Forms.Timer
    Friend WithEvents blt4 As System.Windows.Forms.PictureBox
    Friend WithEvents blt3 As System.Windows.Forms.PictureBox
    Friend WithEvents blt2 As System.Windows.Forms.PictureBox
    Friend WithEvents blt1 As System.Windows.Forms.PictureBox
    Friend WithEvents ten1blt As System.Windows.Forms.Timer
    Friend WithEvents ten2blt As System.Windows.Forms.Timer
    Friend WithEvents ten3blt As System.Windows.Forms.Timer
    Friend WithEvents ten4blt As System.Windows.Forms.Timer
    Friend WithEvents ten5blt As System.Windows.Forms.Timer
    Friend WithEvents en1bt As System.Windows.Forms.PictureBox
    Friend WithEvents en2bt As System.Windows.Forms.PictureBox
    Friend WithEvents en3bt As System.Windows.Forms.PictureBox
    Friend WithEvents en4bt As System.Windows.Forms.PictureBox
    Friend WithEvents en5bt As System.Windows.Forms.PictureBox
    Friend WithEvents fxship As System.Windows.Forms.Timer
    Friend WithEvents ensycmv1 As System.Windows.Forms.Timer
    Friend WithEvents ensycmv2 As System.Windows.Forms.Timer
    Friend WithEvents hp As System.Windows.Forms.PictureBox
    Friend WithEvents boss As System.Windows.Forms.PictureBox
    Friend WithEvents bossAI As System.Windows.Forms.Timer
    Friend WithEvents bossblt As System.Windows.Forms.PictureBox
    Friend WithEvents tbossbt As System.Windows.Forms.Timer
    Friend WithEvents bosshp As System.Windows.Forms.ProgressBar

End Class
