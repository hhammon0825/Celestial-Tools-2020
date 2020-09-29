<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FormIandC
#Region "Windows Form Designer generated code "
    <System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
        MyBase.New()
        'This is required by the Windows Form Designer.
        InitializeComponent()
    End Sub
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents txtMin As System.Windows.Forms.TextBox
    Public WithEvents txtDeg As System.Windows.Forms.TextBox
    Public WithEvents optBack As System.Windows.Forms.RadioButton
    Public WithEvents optFwd As System.Windows.Forms.RadioButton
    Public WithEvents frameFwdBack As System.Windows.Forms.GroupBox
    Public WithEvents cmdPrint As System.Windows.Forms.Button
    Public WithEvents optMoon As System.Windows.Forms.RadioButton
    Public WithEvents optAries As System.Windows.Forms.RadioButton
    Public WithEvents optSunPlanets As System.Windows.Forms.RadioButton
    Public WithEvents frameSelect As System.Windows.Forms.GroupBox
    Public WithEvents txtv As System.Windows.Forms.TextBox
    Public WithEvents txtUTs As System.Windows.Forms.TextBox
    Public WithEvents txtUTm As System.Windows.Forms.TextBox
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    'Public WithEvents Line1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    'Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormIandC))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtMin = New System.Windows.Forms.TextBox()
        Me.txtDeg = New System.Windows.Forms.TextBox()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.txtv = New System.Windows.Forms.TextBox()
        Me.txtUTs = New System.Windows.Forms.TextBox()
        Me.txtUTm = New System.Windows.Forms.TextBox()
        Me.txtd = New System.Windows.Forms.TextBox()
        Me.txtdcorr = New System.Windows.Forms.TextBox()
        Me.txtvcorr = New System.Windows.Forms.TextBox()
        Me.frameFwdBack = New System.Windows.Forms.GroupBox()
        Me.optBack = New System.Windows.Forms.RadioButton()
        Me.optFwd = New System.Windows.Forms.RadioButton()
        Me.frameSelect = New System.Windows.Forms.GroupBox()
        Me.optMoon = New System.Windows.Forms.RadioButton()
        Me.optAries = New System.Windows.Forms.RadioButton()
        Me.optSunPlanets = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnClearFields = New System.Windows.Forms.Button()
        Me.txtdcorrx = New System.Windows.Forms.TextBox()
        Me.txtvcorrx = New System.Windows.Forms.TextBox()
        Me.frameFwdBack.SuspendLayout()
        Me.frameSelect.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMin
        '
        Me.txtMin.AcceptsReturn = True
        Me.txtMin.BackColor = System.Drawing.SystemColors.Window
        Me.txtMin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMin.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMin.Location = New System.Drawing.Point(153, 155)
        Me.txtMin.MaxLength = 4
        Me.txtMin.Name = "txtMin"
        Me.txtMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMin.Size = New System.Drawing.Size(33, 20)
        Me.txtMin.TabIndex = 18
        Me.txtMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtMin, "Range 0 to 59.9")
        '
        'txtDeg
        '
        Me.txtDeg.AcceptsReturn = True
        Me.txtDeg.BackColor = System.Drawing.SystemColors.Window
        Me.txtDeg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDeg.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDeg.Location = New System.Drawing.Point(103, 155)
        Me.txtDeg.MaxLength = 2
        Me.txtDeg.Name = "txtDeg"
        Me.txtDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDeg.Size = New System.Drawing.Size(33, 20)
        Me.txtDeg.TabIndex = 17
        Me.txtDeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtDeg, "Range 0 to 15 for Sun/Planets, Aries; 0 to 14 for Moon")
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrint.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.Location = New System.Drawing.Point(348, 5)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrint.Size = New System.Drawing.Size(21, 21)
        Me.cmdPrint.TabIndex = 13
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdPrint, "Print window")
        Me.cmdPrint.UseVisualStyleBackColor = False
        '
        'txtv
        '
        Me.txtv.AcceptsReturn = True
        Me.txtv.BackColor = System.Drawing.SystemColors.Window
        Me.txtv.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtv.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtv.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtv.Location = New System.Drawing.Point(303, 98)
        Me.txtv.MaxLength = 4
        Me.txtv.Name = "txtv"
        Me.txtv.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtv.Size = New System.Drawing.Size(33, 20)
        Me.txtv.TabIndex = 8
        Me.txtv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtv, "Range 0 to 18.0")
        '
        'txtUTs
        '
        Me.txtUTs.AcceptsReturn = True
        Me.txtUTs.BackColor = System.Drawing.SystemColors.Window
        Me.txtUTs.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUTs.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUTs.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtUTs.Location = New System.Drawing.Point(153, 96)
        Me.txtUTs.MaxLength = 2
        Me.txtUTs.Name = "txtUTs"
        Me.txtUTs.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtUTs.Size = New System.Drawing.Size(33, 20)
        Me.txtUTs.TabIndex = 7
        Me.txtUTs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtUTs, "Range 0 to 60")
        '
        'txtUTm
        '
        Me.txtUTm.AcceptsReturn = True
        Me.txtUTm.BackColor = System.Drawing.SystemColors.Window
        Me.txtUTm.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUTm.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUTm.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtUTm.Location = New System.Drawing.Point(101, 96)
        Me.txtUTm.MaxLength = 2
        Me.txtUTm.Name = "txtUTm"
        Me.txtUTm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtUTm.Size = New System.Drawing.Size(33, 20)
        Me.txtUTm.TabIndex = 6
        Me.txtUTm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtUTm, "Range 0 to 59")
        '
        'txtd
        '
        Me.txtd.AcceptsReturn = True
        Me.txtd.BackColor = System.Drawing.SystemColors.Window
        Me.txtd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtd.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtd.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtd.Location = New System.Drawing.Point(303, 124)
        Me.txtd.MaxLength = 4
        Me.txtd.Name = "txtd"
        Me.txtd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtd.Size = New System.Drawing.Size(33, 20)
        Me.txtd.TabIndex = 9
        Me.txtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtd, "Range 0 to 18.0")
        '
        'txtdcorr
        '
        Me.txtdcorr.AcceptsReturn = True
        Me.txtdcorr.BackColor = System.Drawing.SystemColors.Window
        Me.txtdcorr.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdcorr.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdcorr.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtdcorr.Location = New System.Drawing.Point(264, 180)
        Me.txtdcorr.MaxLength = 4
        Me.txtdcorr.Name = "txtdcorr"
        Me.txtdcorr.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtdcorr.Size = New System.Drawing.Size(33, 20)
        Me.txtdcorr.TabIndex = 21
        Me.txtdcorr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtdcorr, "Range 0 to 18.0")
        '
        'txtvcorr
        '
        Me.txtvcorr.AcceptsReturn = True
        Me.txtvcorr.BackColor = System.Drawing.SystemColors.Window
        Me.txtvcorr.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtvcorr.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvcorr.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtvcorr.Location = New System.Drawing.Point(264, 154)
        Me.txtvcorr.MaxLength = 4
        Me.txtvcorr.Name = "txtvcorr"
        Me.txtvcorr.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtvcorr.Size = New System.Drawing.Size(33, 20)
        Me.txtvcorr.TabIndex = 20
        Me.txtvcorr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtvcorr, "Range 0 to 18.0")
        '
        'frameFwdBack
        '
        Me.frameFwdBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.frameFwdBack.Controls.Add(Me.optBack)
        Me.frameFwdBack.Controls.Add(Me.optFwd)
        Me.frameFwdBack.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frameFwdBack.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frameFwdBack.Location = New System.Drawing.Point(30, 5)
        Me.frameFwdBack.Name = "frameFwdBack"
        Me.frameFwdBack.Padding = New System.Windows.Forms.Padding(0)
        Me.frameFwdBack.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frameFwdBack.Size = New System.Drawing.Size(306, 40)
        Me.frameFwdBack.TabIndex = 14
        Me.frameFwdBack.TabStop = False
        Me.frameFwdBack.Text = "Select Table Direction"
        '
        'optBack
        '
        Me.optBack.BackColor = System.Drawing.SystemColors.Window
        Me.optBack.Cursor = System.Windows.Forms.Cursors.Default
        Me.optBack.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optBack.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optBack.Location = New System.Drawing.Point(177, 16)
        Me.optBack.Name = "optBack"
        Me.optBack.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optBack.Size = New System.Drawing.Size(119, 18)
        Me.optBack.TabIndex = 16
        Me.optBack.TabStop = True
        Me.optBack.Text = "GHA Incr to UT Incr"
        Me.optBack.UseVisualStyleBackColor = False
        '
        'optFwd
        '
        Me.optFwd.BackColor = System.Drawing.SystemColors.Window
        Me.optFwd.Checked = True
        Me.optFwd.Cursor = System.Windows.Forms.Cursors.Default
        Me.optFwd.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optFwd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optFwd.Location = New System.Drawing.Point(46, 16)
        Me.optFwd.Name = "optFwd"
        Me.optFwd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optFwd.Size = New System.Drawing.Size(125, 18)
        Me.optFwd.TabIndex = 15
        Me.optFwd.TabStop = True
        Me.optFwd.Text = "UT  Incr to GHA Incr"
        Me.optFwd.UseVisualStyleBackColor = False
        '
        'frameSelect
        '
        Me.frameSelect.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.frameSelect.Controls.Add(Me.optMoon)
        Me.frameSelect.Controls.Add(Me.optAries)
        Me.frameSelect.Controls.Add(Me.optSunPlanets)
        Me.frameSelect.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frameSelect.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frameSelect.Location = New System.Drawing.Point(30, 52)
        Me.frameSelect.Name = "frameSelect"
        Me.frameSelect.Padding = New System.Windows.Forms.Padding(0)
        Me.frameSelect.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frameSelect.Size = New System.Drawing.Size(306, 40)
        Me.frameSelect.TabIndex = 9
        Me.frameSelect.TabStop = False
        Me.frameSelect.Text = "Select object"
        '
        'optMoon
        '
        Me.optMoon.BackColor = System.Drawing.SystemColors.Window
        Me.optMoon.Cursor = System.Windows.Forms.Cursors.Default
        Me.optMoon.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optMoon.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optMoon.Location = New System.Drawing.Point(229, 15)
        Me.optMoon.Name = "optMoon"
        Me.optMoon.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optMoon.Size = New System.Drawing.Size(65, 17)
        Me.optMoon.TabIndex = 12
        Me.optMoon.Text = "Moon"
        Me.optMoon.UseVisualStyleBackColor = False
        '
        'optAries
        '
        Me.optAries.BackColor = System.Drawing.SystemColors.Window
        Me.optAries.Cursor = System.Windows.Forms.Cursors.Default
        Me.optAries.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optAries.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optAries.Location = New System.Drawing.Point(149, 15)
        Me.optAries.Name = "optAries"
        Me.optAries.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optAries.Size = New System.Drawing.Size(65, 17)
        Me.optAries.TabIndex = 11
        Me.optAries.Text = "Aries"
        Me.optAries.UseVisualStyleBackColor = False
        '
        'optSunPlanets
        '
        Me.optSunPlanets.BackColor = System.Drawing.SystemColors.Window
        Me.optSunPlanets.Checked = True
        Me.optSunPlanets.Cursor = System.Windows.Forms.Cursors.Default
        Me.optSunPlanets.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optSunPlanets.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optSunPlanets.Location = New System.Drawing.Point(47, 15)
        Me.optSunPlanets.Name = "optSunPlanets"
        Me.optSunPlanets.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optSunPlanets.Size = New System.Drawing.Size(81, 17)
        Me.optSunPlanets.TabIndex = 10
        Me.optSunPlanets.TabStop = True
        Me.optSunPlanets.Text = "Sun/Planets"
        Me.optSunPlanets.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Window
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(187, 157)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(12, 17)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "'"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Window
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Symbol", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(137, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(9, 17)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "°"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Window
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(337, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(9, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "'"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Window
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(205, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(95, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "v from daily page"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Window
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(187, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(9, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "s"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(134, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(12, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "m"
        '
        'ExitBtn
        '
        Me.ExitBtn.BackColor = System.Drawing.Color.Crimson
        Me.ExitBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ExitBtn.Location = New System.Drawing.Point(284, 277)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(62, 23)
        Me.ExitBtn.TabIndex = 24
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(24, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(75, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "UT Increment"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Window
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(23, 152)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(82, 25)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "GHA Increment"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnCalculate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCalculate.Location = New System.Drawing.Point(153, 277)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 25
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CelestialTools.My.Resources.Resources.ABC_white
        Me.PictureBox1.Location = New System.Drawing.Point(26, 306)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(320, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 102
        Me.PictureBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Window
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(337, 124)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(9, 17)
        Me.Label10.TabIndex = 105
        Me.Label10.Text = "'"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Window
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(205, 124)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(95, 19)
        Me.Label12.TabIndex = 103
        Me.Label12.Text = "d from daily page"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Window
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(298, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(9, 17)
        Me.Label5.TabIndex = 111
        Me.Label5.Text = "'"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Window
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(211, 180)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(46, 19)
        Me.Label11.TabIndex = 110
        Me.Label11.Text = "d corr"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Window
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(298, 154)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(9, 17)
        Me.Label13.TabIndex = 108
        Me.Label13.Text = "'"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Window
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(211, 154)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(49, 19)
        Me.Label14.TabIndex = 107
        Me.Label14.Text = "v corr"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnClearFields
        '
        Me.btnClearFields.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnClearFields.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnClearFields.Location = New System.Drawing.Point(26, 277)
        Me.btnClearFields.Name = "btnClearFields"
        Me.btnClearFields.Size = New System.Drawing.Size(83, 23)
        Me.btnClearFields.TabIndex = 113
        Me.btnClearFields.Text = "Clear Fields"
        Me.btnClearFields.UseVisualStyleBackColor = False
        '
        'txtdcorrx
        '
        Me.txtdcorrx.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdcorrx.Location = New System.Drawing.Point(77, 235)
        Me.txtdcorrx.Name = "txtdcorrx"
        Me.txtdcorrx.ReadOnly = True
        Me.txtdcorrx.Size = New System.Drawing.Size(259, 20)
        Me.txtdcorrx.TabIndex = 115
        Me.txtdcorrx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtdcorrx.Visible = False
        '
        'txtvcorrx
        '
        Me.txtvcorrx.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvcorrx.Location = New System.Drawing.Point(77, 209)
        Me.txtvcorrx.Name = "txtvcorrx"
        Me.txtvcorrx.ReadOnly = True
        Me.txtvcorrx.Size = New System.Drawing.Size(259, 20)
        Me.txtvcorrx.TabIndex = 114
        Me.txtvcorrx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtvcorrx.Visible = False
        '
        'FormIandC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(381, 364)
        Me.Controls.Add(Me.txtdcorrx)
        Me.Controls.Add(Me.txtvcorrx)
        Me.Controls.Add(Me.btnClearFields)
        Me.Controls.Add(Me.txtdcorr)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtvcorr)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtd)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.txtMin)
        Me.Controls.Add(Me.txtDeg)
        Me.Controls.Add(Me.frameFwdBack)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.frameSelect)
        Me.Controls.Add(Me.txtv)
        Me.Controls.Add(Me.txtUTs)
        Me.Controls.Add(Me.txtUTm)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(3, 29)
        Me.MaximizeBox = False
        Me.Name = "FormIandC"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Increments and Corrections"
        Me.frameFwdBack.ResumeLayout(False)
        Me.frameSelect.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ExitBtn As Button
    Public WithEvents Label1 As Label
    Public WithEvents Label9 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents PictureBox1 As PictureBox
    Public WithEvents txtd As TextBox
    Public WithEvents Label10 As Label
    Public WithEvents Label12 As Label
    Public WithEvents txtdcorr As TextBox
    Public WithEvents Label5 As Label
    Public WithEvents Label11 As Label
    Public WithEvents txtvcorr As TextBox
    Public WithEvents Label13 As Label
    Public WithEvents Label14 As Label
    Friend WithEvents btnClearFields As Button
    Friend WithEvents txtdcorrx As TextBox
    Friend WithEvents txtvcorrx As TextBox
#End Region
End Class