<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FormSightPlan
#Region "Windows Form Designer generated code "
    <System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
        MyBase.New()
        'This is required by the Windows Form Designer.
        InitializeComponent()
        Form_Initialize_Renamed()
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
    Public WithEvents optCenter As System.Windows.Forms.RadioButton
    Public WithEvents optLimb As System.Windows.Forms.RadioButton
    Public WithEvents FrameZn As System.Windows.Forms.GroupBox
    Public WithEvents txtWarning As System.Windows.Forms.TextBox
    Public WithEvents txtMinimumAltitude As System.Windows.Forms.TextBox
    Public WithEvents chkDST As System.Windows.Forms.CheckBox
    Public WithEvents cmdPrint As System.Windows.Forms.Button
    Public WithEvents txtHighAz As System.Windows.Forms.TextBox
    Public WithEvents txtLowAz As System.Windows.Forms.TextBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents lblAzDeg As System.Windows.Forms.Label
    Public WithEvents lblAz1 As System.Windows.Forms.Label
    Public WithEvents txtTime As System.Windows.Forms.TextBox
    Public WithEvents txtZDh As System.Windows.Forms.TextBox
    Public WithEvents optZDUT As System.Windows.Forms.RadioButton
    Public WithEvents optZDAuto As System.Windows.Forms.RadioButton
    Public WithEvents optZDManual As System.Windows.Forms.RadioButton
    Public WithEvents FrameZD As System.Windows.Forms.Panel
    Public WithEvents cboZDm As System.Windows.Forms.ComboBox
    Public WithEvents cmdTwilights As System.Windows.Forms.Button
    Public WithEvents cboLo As System.Windows.Forms.ComboBox
    Public WithEvents txtLoMin As System.Windows.Forms.TextBox
    Public WithEvents txtLoDeg As System.Windows.Forms.TextBox
    Public WithEvents cboL As System.Windows.Forms.ComboBox
    Public WithEvents txtLMin As System.Windows.Forms.TextBox
    Public WithEvents txtLDeg As System.Windows.Forms.TextBox
    Public WithEvents lblAltDeg As System.Windows.Forms.Label
    Public WithEvents lblMinimumAltitude As System.Windows.Forms.Label
    Public WithEvents lblZDDST As System.Windows.Forms.Label
    'Public WithEvents Line4 As Microsoft.VisualBasic.PowerPacks.LineShape
    'Public WithEvents Line3 As Microsoft.VisualBasic.PowerPacks.LineShape
    'Public WithEvents Line2 As Microsoft.VisualBasic.PowerPacks.LineShape
    'Public WithEvents Line1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Public WithEvents lblEnterTime As System.Windows.Forms.Label
    Public WithEvents WEZDAutoManual As System.Windows.Forms.Label
    Public WithEvents lblWEZD As System.Windows.Forms.Label
    Public WithEvents lblZDh As System.Windows.Forms.Label
    Public WithEvents lblZDm As System.Windows.Forms.Label
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents lblDRLo As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents lblDRL As System.Windows.Forms.Label
    Public WithEvents lblDate As System.Windows.Forms.Label
    'Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSightPlan))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtMinimumAltitude = New System.Windows.Forms.TextBox()
        Me.chkDST = New System.Windows.Forms.CheckBox()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.txtHighAz = New System.Windows.Forms.TextBox()
        Me.txtLowAz = New System.Windows.Forms.TextBox()
        Me.lblAz1 = New System.Windows.Forms.Label()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.txtZDh = New System.Windows.Forms.TextBox()
        Me.optZDAuto = New System.Windows.Forms.RadioButton()
        Me.optZDManual = New System.Windows.Forms.RadioButton()
        Me.txtLoMin = New System.Windows.Forms.TextBox()
        Me.txtLoDeg = New System.Windows.Forms.TextBox()
        Me.txtLMin = New System.Windows.Forms.TextBox()
        Me.txtLDeg = New System.Windows.Forms.TextBox()
        Me.WEZDAutoManual = New System.Windows.Forms.Label()
        Me.lblWEZD = New System.Windows.Forms.Label()
        Me.optThreeBeach = New System.Windows.Forms.RadioButton()
        Me.optThreeBoat = New System.Windows.Forms.RadioButton()
        Me.FrameZn = New System.Windows.Forms.GroupBox()
        Me.optCenter = New System.Windows.Forms.RadioButton()
        Me.optLimb = New System.Windows.Forms.RadioButton()
        Me.txtWarning = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblAzDeg = New System.Windows.Forms.Label()
        Me.FrameZD = New System.Windows.Forms.Panel()
        Me.optZDUT = New System.Windows.Forms.RadioButton()
        Me.cboZDm = New System.Windows.Forms.ComboBox()
        Me.cmdTwilights = New System.Windows.Forms.Button()
        Me.cboLo = New System.Windows.Forms.ComboBox()
        Me.cboL = New System.Windows.Forms.ComboBox()
        Me.lblAltDeg = New System.Windows.Forms.Label()
        Me.lblMinimumAltitude = New System.Windows.Forms.Label()
        Me.lblZDDST = New System.Windows.Forms.Label()
        Me.lblEnterTime = New System.Windows.Forms.Label()
        Me.lblZDh = New System.Windows.Forms.Label()
        Me.lblZDm = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblDRLo = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblDRL = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.MoonTxtBx = New System.Windows.Forms.RichTextBox()
        Me.SunTxtBx = New System.Windows.Forms.RichTextBox()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.Plan1TabCntl = New System.Windows.Forms.TabControl()
        Me.ListVisiblePg = New System.Windows.Forms.TabPage()
        Me.Shape1 = New System.Windows.Forms.TextBox()
        Me.txtBx2 = New System.Windows.Forms.RichTextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.DGMag3 = New System.Windows.Forms.DataGridView()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.DGMag2 = New System.Windows.Forms.DataGridView()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DGMag1 = New System.Windows.Forms.DataGridView()
        Me.ViewVisiblePg = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblSLeft = New System.Windows.Forms.Label()
        Me.lblSRight = New System.Windows.Forms.Label()
        Me.chkHelper = New System.Windows.Forms.CheckBox()
        Me.chkLimit = New System.Windows.Forms.CheckBox()
        Me.chkFirst = New System.Windows.Forms.CheckBox()
        Me.chkSecond = New System.Windows.Forms.CheckBox()
        Me.chkThird = New System.Windows.Forms.CheckBox()
        Me.chkNames = New System.Windows.Forms.CheckBox()
        Me.lblBody = New System.Windows.Forms.Label()
        Me.lblBodyName = New System.Windows.Forms.Label()
        Me.lblAlt = New System.Windows.Forms.Label()
        Me.lblAz = New System.Windows.Forms.Label()
        Me.lblAzimuth = New System.Windows.Forms.Label()
        Me.lblAltitude = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblW = New System.Windows.Forms.Label()
        Me.lblE = New System.Windows.Forms.Label()
        Me.lblS = New System.Windows.Forms.Label()
        Me.lblN = New System.Windows.Forms.Label()
        Me.SkyPicBx = New System.Windows.Forms.PictureBox()
        Me.FrameBest = New System.Windows.Forms.GroupBox()
        Me.RotateIncr = New System.Windows.Forms.ComboBox()
        Me.ResetRotateBtn = New System.Windows.Forms.Button()
        Me.cmdCW = New System.Windows.Forms.Button()
        Me.cmdCCW = New System.Windows.Forms.Button()
        Me.optTwo = New System.Windows.Forms.RadioButton()
        Me.optOff = New System.Windows.Forms.RadioButton()
        Me.FrameDirection = New System.Windows.Forms.GroupBox()
        Me.optW = New System.Windows.Forms.RadioButton()
        Me.optE = New System.Windows.Forms.RadioButton()
        Me.optS = New System.Windows.Forms.RadioButton()
        Me.optN = New System.Windows.Forms.RadioButton()
        Me.FrameView = New System.Windows.Forms.GroupBox()
        Me.optHorizon = New System.Windows.Forms.RadioButton()
        Me.optStarFinder = New System.Windows.Forms.RadioButton()
        Me.optOverhead = New System.Windows.Forms.RadioButton()
        Me.StarFinder1Pg = New System.Windows.Forms.TabPage()
        Me.ReportTxtBx = New System.Windows.Forms.TextBox()
        Me.SunRiseSunSet = New System.Windows.Forms.TabPage()
        Me.SunRiseSet = New System.Windows.Forms.PictureBox()
        Me.MoonTxtBxRight = New System.Windows.Forms.RichTextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DTPlan = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtUserInfo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkNoonSightLAN = New System.Windows.Forms.CheckBox()
        Me.txtLAN = New System.Windows.Forms.TextBox()
        Me.cboLineWidth = New System.Windows.Forms.ComboBox()
        Me.lblLineWidth = New System.Windows.Forms.Label()
        Me.txtIncreaseDT = New System.Windows.Forms.RichTextBox()
        Me.btnAdd1Hour = New System.Windows.Forms.Button()
        Me.btnAdd1Day = New System.Windows.Forms.Button()
        Me.btnAdd1Week = New System.Windows.Forms.Button()
        Me.btnAdd1Month = New System.Windows.Forms.Button()
        Me.btnAdd30Min = New System.Windows.Forms.Button()
        Me.btnAdd1Year = New System.Windows.Forms.Button()
        Me.btnSub1Year = New System.Windows.Forms.Button()
        Me.btnSub30Min = New System.Windows.Forms.Button()
        Me.btnSub1Month = New System.Windows.Forms.Button()
        Me.btnSub1Week = New System.Windows.Forms.Button()
        Me.btnSub1Day = New System.Windows.Forms.Button()
        Me.btnSub1Hour = New System.Windows.Forms.Button()
        Me.txtDecreaseDT = New System.Windows.Forms.RichTextBox()
        Me.btnResetDTtoNow = New System.Windows.Forms.Button()
        Me.FrameZn.SuspendLayout()
        Me.FrameZD.SuspendLayout()
        Me.Plan1TabCntl.SuspendLayout()
        Me.ListVisiblePg.SuspendLayout()
        CType(Me.DGMag3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGMag2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGMag1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ViewVisiblePg.SuspendLayout()
        CType(Me.SkyPicBx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FrameBest.SuspendLayout()
        Me.FrameDirection.SuspendLayout()
        Me.FrameView.SuspendLayout()
        Me.StarFinder1Pg.SuspendLayout()
        Me.SunRiseSunSet.SuspendLayout()
        CType(Me.SunRiseSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMinimumAltitude
        '
        Me.txtMinimumAltitude.AcceptsReturn = True
        Me.txtMinimumAltitude.BackColor = System.Drawing.SystemColors.Window
        Me.txtMinimumAltitude.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMinimumAltitude.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinimumAltitude.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMinimumAltitude.Location = New System.Drawing.Point(725, 61)
        Me.txtMinimumAltitude.MaxLength = 2
        Me.txtMinimumAltitude.Name = "txtMinimumAltitude"
        Me.txtMinimumAltitude.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMinimumAltitude.Size = New System.Drawing.Size(25, 20)
        Me.txtMinimumAltitude.TabIndex = 27
        Me.txtMinimumAltitude.Text = "15"
        '
        'chkDST
        '
        Me.chkDST.BackColor = System.Drawing.SystemColors.Window
        Me.chkDST.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkDST.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDST.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkDST.Location = New System.Drawing.Point(413, 62)
        Me.chkDST.Name = "chkDST"
        Me.chkDST.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkDST.Size = New System.Drawing.Size(17, 17)
        Me.chkDST.TabIndex = 69
        Me.chkDST.Text = "Check1"
        Me.chkDST.UseVisualStyleBackColor = False
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrint.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.Location = New System.Drawing.Point(809, 4)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrint.Size = New System.Drawing.Size(21, 21)
        Me.cmdPrint.TabIndex = 34
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdPrint.UseVisualStyleBackColor = False
        '
        'txtHighAz
        '
        Me.txtHighAz.AcceptsReturn = True
        Me.txtHighAz.BackColor = System.Drawing.SystemColors.Window
        Me.txtHighAz.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHighAz.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHighAz.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHighAz.Location = New System.Drawing.Point(771, 39)
        Me.txtHighAz.MaxLength = 3
        Me.txtHighAz.Name = "txtHighAz"
        Me.txtHighAz.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHighAz.Size = New System.Drawing.Size(25, 20)
        Me.txtHighAz.TabIndex = 39
        Me.txtHighAz.Text = "360"
        '
        'txtLowAz
        '
        Me.txtLowAz.AcceptsReturn = True
        Me.txtLowAz.BackColor = System.Drawing.SystemColors.Window
        Me.txtLowAz.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLowAz.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLowAz.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLowAz.Location = New System.Drawing.Point(725, 39)
        Me.txtLowAz.MaxLength = 3
        Me.txtLowAz.Name = "txtLowAz"
        Me.txtLowAz.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLowAz.Size = New System.Drawing.Size(25, 20)
        Me.txtLowAz.TabIndex = 35
        Me.txtLowAz.Text = "0"
        '
        'lblAz1
        '
        Me.lblAz1.BackColor = System.Drawing.SystemColors.Window
        Me.lblAz1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAz1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAz1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAz1.Location = New System.Drawing.Point(523, 43)
        Me.lblAz1.Name = "lblAz1"
        Me.lblAz1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAz1.Size = New System.Drawing.Size(201, 17)
        Me.lblAz1.TabIndex = 36
        Me.lblAz1.Text = "List/view visible bodies with azimuths from"
        '
        'txtTime
        '
        Me.txtTime.AcceptsReturn = True
        Me.txtTime.BackColor = System.Drawing.SystemColors.Window
        Me.txtTime.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTime.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTime.Location = New System.Drawing.Point(387, 84)
        Me.txtTime.MaxLength = 4
        Me.txtTime.Name = "txtTime"
        Me.txtTime.ReadOnly = True
        Me.txtTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTime.Size = New System.Drawing.Size(40, 20)
        Me.txtTime.TabIndex = 26
        Me.txtTime.Visible = False
        '
        'txtZDh
        '
        Me.txtZDh.AcceptsReturn = True
        Me.txtZDh.BackColor = System.Drawing.SystemColors.Window
        Me.txtZDh.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtZDh.Enabled = False
        Me.txtZDh.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZDh.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtZDh.Location = New System.Drawing.Point(308, 61)
        Me.txtZDh.MaxLength = 3
        Me.txtZDh.Name = "txtZDh"
        Me.txtZDh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtZDh.Size = New System.Drawing.Size(25, 20)
        Me.txtZDh.TabIndex = 22
        '
        'optZDAuto
        '
        Me.optZDAuto.BackColor = System.Drawing.SystemColors.Window
        Me.optZDAuto.Checked = True
        Me.optZDAuto.Cursor = System.Windows.Forms.Cursors.Default
        Me.optZDAuto.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optZDAuto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optZDAuto.Location = New System.Drawing.Point(5, 5)
        Me.optZDAuto.Name = "optZDAuto"
        Me.optZDAuto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optZDAuto.Size = New System.Drawing.Size(49, 20)
        Me.optZDAuto.TabIndex = 19
        Me.optZDAuto.TabStop = True
        Me.optZDAuto.Text = "Auto"
        Me.optZDAuto.UseVisualStyleBackColor = False
        '
        'optZDManual
        '
        Me.optZDManual.BackColor = System.Drawing.SystemColors.Window
        Me.optZDManual.Cursor = System.Windows.Forms.Cursors.Default
        Me.optZDManual.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optZDManual.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optZDManual.Location = New System.Drawing.Point(55, 5)
        Me.optZDManual.Name = "optZDManual"
        Me.optZDManual.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optZDManual.Size = New System.Drawing.Size(67, 18)
        Me.optZDManual.TabIndex = 20
        Me.optZDManual.TabStop = True
        Me.optZDManual.Text = "Manual"
        Me.optZDManual.UseVisualStyleBackColor = False
        '
        'txtLoMin
        '
        Me.txtLoMin.AcceptsReturn = True
        Me.txtLoMin.BackColor = System.Drawing.SystemColors.Window
        Me.txtLoMin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLoMin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoMin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLoMin.Location = New System.Drawing.Point(147, 78)
        Me.txtLoMin.MaxLength = 4
        Me.txtLoMin.Name = "txtLoMin"
        Me.txtLoMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLoMin.Size = New System.Drawing.Size(33, 20)
        Me.txtLoMin.TabIndex = 15
        '
        'txtLoDeg
        '
        Me.txtLoDeg.AcceptsReturn = True
        Me.txtLoDeg.BackColor = System.Drawing.SystemColors.Window
        Me.txtLoDeg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLoDeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoDeg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLoDeg.Location = New System.Drawing.Point(107, 78)
        Me.txtLoDeg.MaxLength = 3
        Me.txtLoDeg.Name = "txtLoDeg"
        Me.txtLoDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLoDeg.Size = New System.Drawing.Size(33, 20)
        Me.txtLoDeg.TabIndex = 13
        '
        'txtLMin
        '
        Me.txtLMin.AcceptsReturn = True
        Me.txtLMin.BackColor = System.Drawing.SystemColors.Window
        Me.txtLMin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLMin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLMin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLMin.Location = New System.Drawing.Point(147, 56)
        Me.txtLMin.MaxLength = 4
        Me.txtLMin.Name = "txtLMin"
        Me.txtLMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLMin.Size = New System.Drawing.Size(33, 20)
        Me.txtLMin.TabIndex = 10
        '
        'txtLDeg
        '
        Me.txtLDeg.AcceptsReturn = True
        Me.txtLDeg.BackColor = System.Drawing.SystemColors.Window
        Me.txtLDeg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLDeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLDeg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtLDeg.Location = New System.Drawing.Point(107, 56)
        Me.txtLDeg.MaxLength = 2
        Me.txtLDeg.Name = "txtLDeg"
        Me.txtLDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLDeg.Size = New System.Drawing.Size(33, 20)
        Me.txtLDeg.TabIndex = 8
        '
        'WEZDAutoManual
        '
        Me.WEZDAutoManual.BackColor = System.Drawing.SystemColors.Window
        Me.WEZDAutoManual.Cursor = System.Windows.Forms.Cursors.Default
        Me.WEZDAutoManual.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WEZDAutoManual.ForeColor = System.Drawing.SystemColors.ControlText
        Me.WEZDAutoManual.Location = New System.Drawing.Point(253, 35)
        Me.WEZDAutoManual.Name = "WEZDAutoManual"
        Me.WEZDAutoManual.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WEZDAutoManual.Size = New System.Drawing.Size(42, 18)
        Me.WEZDAutoManual.TabIndex = 18
        Me.WEZDAutoManual.Text = "ZD Opt"
        '
        'lblWEZD
        '
        Me.lblWEZD.BackColor = System.Drawing.SystemColors.Window
        Me.lblWEZD.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblWEZD.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWEZD.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblWEZD.Location = New System.Drawing.Point(254, 61)
        Me.lblWEZD.Name = "lblWEZD"
        Me.lblWEZD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblWEZD.Size = New System.Drawing.Size(42, 17)
        Me.lblWEZD.TabIndex = 21
        Me.lblWEZD.Text = "ZD "
        '
        'optThreeBeach
        '
        Me.optThreeBeach.BackColor = System.Drawing.SystemColors.Window
        Me.optThreeBeach.Cursor = System.Windows.Forms.Cursors.Default
        Me.optThreeBeach.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optThreeBeach.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optThreeBeach.Location = New System.Drawing.Point(8, 64)
        Me.optThreeBeach.Name = "optThreeBeach"
        Me.optThreeBeach.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optThreeBeach.Size = New System.Drawing.Size(134, 17)
        Me.optThreeBeach.TabIndex = 79
        Me.optThreeBeach.TabStop = True
        Me.optThreeBeach.Text = "Three-body fix (beach)"
        Me.optThreeBeach.UseVisualStyleBackColor = False
        '
        'optThreeBoat
        '
        Me.optThreeBoat.BackColor = System.Drawing.SystemColors.Window
        Me.optThreeBoat.Cursor = System.Windows.Forms.Cursors.Default
        Me.optThreeBoat.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optThreeBoat.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optThreeBoat.Location = New System.Drawing.Point(8, 48)
        Me.optThreeBoat.Name = "optThreeBoat"
        Me.optThreeBoat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optThreeBoat.Size = New System.Drawing.Size(128, 17)
        Me.optThreeBoat.TabIndex = 76
        Me.optThreeBoat.TabStop = True
        Me.optThreeBoat.Text = "Three-body fix (boat)"
        Me.optThreeBoat.UseVisualStyleBackColor = False
        '
        'FrameZn
        '
        Me.FrameZn.BackColor = System.Drawing.SystemColors.Window
        Me.FrameZn.Controls.Add(Me.optCenter)
        Me.FrameZn.Controls.Add(Me.optLimb)
        Me.FrameZn.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FrameZn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FrameZn.Location = New System.Drawing.Point(521, 2)
        Me.FrameZn.Name = "FrameZn"
        Me.FrameZn.Padding = New System.Windows.Forms.Padding(0)
        Me.FrameZn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FrameZn.Size = New System.Drawing.Size(190, 35)
        Me.FrameZn.TabIndex = 84
        Me.FrameZn.TabStop = False
        Me.FrameZn.Text = "Show Zn  when visible on horizon"
        '
        'optCenter
        '
        Me.optCenter.BackColor = System.Drawing.SystemColors.Window
        Me.optCenter.Cursor = System.Windows.Forms.Cursors.Default
        Me.optCenter.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optCenter.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optCenter.Location = New System.Drawing.Point(116, 16)
        Me.optCenter.Name = "optCenter"
        Me.optCenter.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optCenter.Size = New System.Drawing.Size(57, 17)
        Me.optCenter.TabIndex = 86
        Me.optCenter.TabStop = True
        Me.optCenter.Text = "Center"
        Me.optCenter.UseVisualStyleBackColor = False
        '
        'optLimb
        '
        Me.optLimb.BackColor = System.Drawing.SystemColors.Window
        Me.optLimb.Checked = True
        Me.optLimb.Cursor = System.Windows.Forms.Cursors.Default
        Me.optLimb.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optLimb.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optLimb.Location = New System.Drawing.Point(8, 16)
        Me.optLimb.Name = "optLimb"
        Me.optLimb.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optLimb.Size = New System.Drawing.Size(81, 17)
        Me.optLimb.TabIndex = 85
        Me.optLimb.TabStop = True
        Me.optLimb.Text = "Upper Limb"
        Me.optLimb.UseVisualStyleBackColor = False
        '
        'txtWarning
        '
        Me.txtWarning.AcceptsReturn = True
        Me.txtWarning.BackColor = System.Drawing.Color.Blue
        Me.txtWarning.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtWarning.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWarning.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWarning.ForeColor = System.Drawing.Color.Black
        Me.txtWarning.Location = New System.Drawing.Point(433, 84)
        Me.txtWarning.MaxLength = 0
        Me.txtWarning.Multiline = True
        Me.txtWarning.Name = "txtWarning"
        Me.txtWarning.ReadOnly = True
        Me.txtWarning.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtWarning.Size = New System.Drawing.Size(70, 20)
        Me.txtWarning.TabIndex = 81
        Me.txtWarning.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtWarning.Visible = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Window
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(776, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(9, 17)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "°"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(752, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(17, 15)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "to"
        '
        'lblAzDeg
        '
        Me.lblAzDeg.BackColor = System.Drawing.SystemColors.Window
        Me.lblAzDeg.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAzDeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAzDeg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAzDeg.Location = New System.Drawing.Point(702, 43)
        Me.lblAzDeg.Name = "lblAzDeg"
        Me.lblAzDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAzDeg.Size = New System.Drawing.Size(9, 17)
        Me.lblAzDeg.TabIndex = 37
        Me.lblAzDeg.Text = "°"
        '
        'FrameZD
        '
        Me.FrameZD.BackColor = System.Drawing.SystemColors.Window
        Me.FrameZD.Controls.Add(Me.optZDUT)
        Me.FrameZD.Controls.Add(Me.optZDAuto)
        Me.FrameZD.Controls.Add(Me.optZDManual)
        Me.FrameZD.Cursor = System.Windows.Forms.Cursors.Default
        Me.FrameZD.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FrameZD.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FrameZD.Location = New System.Drawing.Point(308, 30)
        Me.FrameZD.Name = "FrameZD"
        Me.FrameZD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FrameZD.Size = New System.Drawing.Size(196, 28)
        Me.FrameZD.TabIndex = 30
        Me.FrameZD.Text = "Frame1"
        '
        'optZDUT
        '
        Me.optZDUT.BackColor = System.Drawing.SystemColors.Window
        Me.optZDUT.Cursor = System.Windows.Forms.Cursors.Default
        Me.optZDUT.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optZDUT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optZDUT.Location = New System.Drawing.Point(117, 6)
        Me.optZDUT.Name = "optZDUT"
        Me.optZDUT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optZDUT.Size = New System.Drawing.Size(75, 17)
        Me.optZDUT.TabIndex = 87
        Me.optZDUT.TabStop = True
        Me.optZDUT.Text = "UT (GMT)"
        Me.optZDUT.UseVisualStyleBackColor = False
        '
        'cboZDm
        '
        Me.cboZDm.BackColor = System.Drawing.SystemColors.Window
        Me.cboZDm.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboZDm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboZDm.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboZDm.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboZDm.Items.AddRange(New Object() {"00", "30", "45"})
        Me.cboZDm.Location = New System.Drawing.Point(348, 60)
        Me.cboZDm.Name = "cboZDm"
        Me.cboZDm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboZDm.Size = New System.Drawing.Size(41, 22)
        Me.cboZDm.TabIndex = 23
        Me.cboZDm.Visible = False
        '
        'cmdTwilights
        '
        Me.cmdTwilights.BackColor = System.Drawing.Color.Yellow
        Me.cmdTwilights.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdTwilights.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTwilights.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdTwilights.Location = New System.Drawing.Point(752, 142)
        Me.cmdTwilights.Name = "cmdTwilights"
        Me.cmdTwilights.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdTwilights.Size = New System.Drawing.Size(90, 36)
        Me.cmdTwilights.TabIndex = 24
        Me.cmdTwilights.Text = " Display Sight Planning Data"
        Me.cmdTwilights.UseVisualStyleBackColor = False
        '
        'cboLo
        '
        Me.cboLo.BackColor = System.Drawing.SystemColors.Window
        Me.cboLo.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboLo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboLo.Items.AddRange(New Object() {"W", "E"})
        Me.cboLo.Location = New System.Drawing.Point(187, 78)
        Me.cboLo.Name = "cboLo"
        Me.cboLo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboLo.Size = New System.Drawing.Size(41, 22)
        Me.cboLo.TabIndex = 16
        '
        'cboL
        '
        Me.cboL.BackColor = System.Drawing.SystemColors.Window
        Me.cboL.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboL.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboL.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboL.Items.AddRange(New Object() {"N", "S"})
        Me.cboL.Location = New System.Drawing.Point(187, 55)
        Me.cboL.Name = "cboL"
        Me.cboL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboL.Size = New System.Drawing.Size(41, 22)
        Me.cboL.TabIndex = 11
        '
        'lblAltDeg
        '
        Me.lblAltDeg.BackColor = System.Drawing.SystemColors.Window
        Me.lblAltDeg.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAltDeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAltDeg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAltDeg.Location = New System.Drawing.Point(750, 61)
        Me.lblAltDeg.Name = "lblAltDeg"
        Me.lblAltDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAltDeg.Size = New System.Drawing.Size(13, 17)
        Me.lblAltDeg.TabIndex = 72
        Me.lblAltDeg.Text = "°"
        '
        'lblMinimumAltitude
        '
        Me.lblMinimumAltitude.BackColor = System.Drawing.SystemColors.Window
        Me.lblMinimumAltitude.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMinimumAltitude.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinimumAltitude.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMinimumAltitude.Location = New System.Drawing.Point(524, 65)
        Me.lblMinimumAltitude.Name = "lblMinimumAltitude"
        Me.lblMinimumAltitude.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMinimumAltitude.Size = New System.Drawing.Size(199, 17)
        Me.lblMinimumAltitude.TabIndex = 71
        Me.lblMinimumAltitude.Text = "Enter minimum altitude for Sun-Moon Fix"
        '
        'lblZDDST
        '
        Me.lblZDDST.BackColor = System.Drawing.SystemColors.Window
        Me.lblZDDST.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblZDDST.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZDDST.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblZDDST.Location = New System.Drawing.Point(430, 62)
        Me.lblZDDST.Name = "lblZDDST"
        Me.lblZDDST.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblZDDST.Size = New System.Drawing.Size(30, 17)
        Me.lblZDDST.TabIndex = 70
        Me.lblZDDST.Text = "DST"
        '
        'lblEnterTime
        '
        Me.lblEnterTime.BackColor = System.Drawing.SystemColors.Window
        Me.lblEnterTime.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblEnterTime.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterTime.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblEnterTime.Location = New System.Drawing.Point(253, 85)
        Me.lblEnterTime.Name = "lblEnterTime"
        Me.lblEnterTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblEnterTime.Size = New System.Drawing.Size(110, 17)
        Me.lblEnterTime.TabIndex = 25
        Me.lblEnterTime.Text = "ZT for body visibility:"
        Me.lblEnterTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEnterTime.Visible = False
        '
        'lblZDh
        '
        Me.lblZDh.BackColor = System.Drawing.SystemColors.Window
        Me.lblZDh.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblZDh.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZDh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblZDh.Location = New System.Drawing.Point(333, 61)
        Me.lblZDh.Name = "lblZDh"
        Me.lblZDh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblZDh.Size = New System.Drawing.Size(9, 17)
        Me.lblZDh.TabIndex = 32
        Me.lblZDh.Text = "h"
        Me.lblZDh.Visible = False
        '
        'lblZDm
        '
        Me.lblZDm.BackColor = System.Drawing.SystemColors.Window
        Me.lblZDm.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblZDm.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZDm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblZDm.Location = New System.Drawing.Point(389, 60)
        Me.lblZDm.Name = "lblZDm"
        Me.lblZDm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblZDm.Size = New System.Drawing.Size(12, 17)
        Me.lblZDm.TabIndex = 31
        Me.lblZDm.Text = "m"
        Me.lblZDm.Visible = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Window
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(121, 81)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(9, 20)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "'"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Window
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(121, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(9, 25)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "'"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Window
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(139, 81)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(9, 17)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "°"
        '
        'lblDRLo
        '
        Me.lblDRLo.BackColor = System.Drawing.SystemColors.Window
        Me.lblDRLo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDRLo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDRLo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDRLo.Location = New System.Drawing.Point(45, 78)
        Me.lblDRLo.Name = "lblDRLo"
        Me.lblDRLo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDRLo.Size = New System.Drawing.Size(50, 17)
        Me.lblDRLo.TabIndex = 12
        Me.lblDRLo.Text = "DR Long"
        Me.lblDRLo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Window
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(138, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(9, 17)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "°"
        '
        'lblDRL
        '
        Me.lblDRL.BackColor = System.Drawing.SystemColors.Window
        Me.lblDRL.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDRL.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDRL.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDRL.Location = New System.Drawing.Point(45, 56)
        Me.lblDRL.Name = "lblDRL"
        Me.lblDRL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDRL.Size = New System.Drawing.Size(40, 17)
        Me.lblDRL.TabIndex = 7
        Me.lblDRL.Text = "DR Lat"
        Me.lblDRL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.SystemColors.Window
        Me.lblDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDate.Location = New System.Drawing.Point(44, 35)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDate.Size = New System.Drawing.Size(60, 17)
        Me.lblDate.TabIndex = 0
        Me.lblDate.Text = "Date / Time"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MoonTxtBx
        '
        Me.MoonTxtBx.BackColor = System.Drawing.SystemColors.Window
        Me.MoonTxtBx.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MoonTxtBx.Location = New System.Drawing.Point(40, 196)
        Me.MoonTxtBx.Name = "MoonTxtBx"
        Me.MoonTxtBx.ReadOnly = True
        Me.MoonTxtBx.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.MoonTxtBx.Size = New System.Drawing.Size(519, 17)
        Me.MoonTxtBx.TabIndex = 90
        Me.MoonTxtBx.Text = ""
        '
        'SunTxtBx
        '
        Me.SunTxtBx.BackColor = System.Drawing.SystemColors.Window
        Me.SunTxtBx.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SunTxtBx.Location = New System.Drawing.Point(40, 105)
        Me.SunTxtBx.Name = "SunTxtBx"
        Me.SunTxtBx.ReadOnly = True
        Me.SunTxtBx.Size = New System.Drawing.Size(696, 90)
        Me.SunTxtBx.TabIndex = 91
        Me.SunTxtBx.Text = ""
        '
        'ExitBtn
        '
        Me.ExitBtn.BackColor = System.Drawing.Color.Red
        Me.ExitBtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExitBtn.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ExitBtn.Location = New System.Drawing.Point(753, 184)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ExitBtn.Size = New System.Drawing.Size(90, 26)
        Me.ExitBtn.TabIndex = 98
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = False
        '
        'Plan1TabCntl
        '
        Me.Plan1TabCntl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Plan1TabCntl.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.Plan1TabCntl.Controls.Add(Me.ListVisiblePg)
        Me.Plan1TabCntl.Controls.Add(Me.ViewVisiblePg)
        Me.Plan1TabCntl.Controls.Add(Me.StarFinder1Pg)
        Me.Plan1TabCntl.Controls.Add(Me.SunRiseSunSet)
        Me.Plan1TabCntl.ItemSize = New System.Drawing.Size(158, 21)
        Me.Plan1TabCntl.Location = New System.Drawing.Point(1, 219)
        Me.Plan1TabCntl.Multiline = True
        Me.Plan1TabCntl.Name = "Plan1TabCntl"
        Me.Plan1TabCntl.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Plan1TabCntl.SelectedIndex = 0
        Me.Plan1TabCntl.Size = New System.Drawing.Size(844, 556)
        Me.Plan1TabCntl.TabIndex = 99
        Me.Plan1TabCntl.TabStop = False
        Me.Plan1TabCntl.Visible = False
        '
        'ListVisiblePg
        '
        Me.ListVisiblePg.AutoScroll = True
        Me.ListVisiblePg.BackColor = System.Drawing.SystemColors.Window
        Me.ListVisiblePg.Controls.Add(Me.Shape1)
        Me.ListVisiblePg.Controls.Add(Me.txtBx2)
        Me.ListVisiblePg.Controls.Add(Me.TextBox4)
        Me.ListVisiblePg.Controls.Add(Me.DGMag3)
        Me.ListVisiblePg.Controls.Add(Me.TextBox3)
        Me.ListVisiblePg.Controls.Add(Me.DGMag2)
        Me.ListVisiblePg.Controls.Add(Me.TextBox2)
        Me.ListVisiblePg.Controls.Add(Me.DGMag1)
        Me.ListVisiblePg.Location = New System.Drawing.Point(4, 25)
        Me.ListVisiblePg.Name = "ListVisiblePg"
        Me.ListVisiblePg.Size = New System.Drawing.Size(836, 527)
        Me.ListVisiblePg.TabIndex = 2
        Me.ListVisiblePg.Text = "List Visible Bodies/ Sun & Moon Fix"
        '
        'Shape1
        '
        Me.Shape1.Location = New System.Drawing.Point(551, 419)
        Me.Shape1.Multiline = True
        Me.Shape1.Name = "Shape1"
        Me.Shape1.ReadOnly = True
        Me.Shape1.Size = New System.Drawing.Size(247, 64)
        Me.Shape1.TabIndex = 108
        Me.Shape1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBx2
        '
        Me.txtBx2.BackColor = System.Drawing.SystemColors.Window
        Me.txtBx2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBx2.Location = New System.Drawing.Point(49, 489)
        Me.txtBx2.Name = "txtBx2"
        Me.txtBx2.ReadOnly = True
        Me.txtBx2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBx2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtBx2.Size = New System.Drawing.Size(742, 35)
        Me.txtBx2.TabIndex = 107
        Me.txtBx2.Text = "Rows where h>=15 and <=75 appear in Light Gray (Stars) or Yellow (Sun) or LightGr" &
    "een (Moon and Planets)." & Global.Microsoft.VisualBasic.ChrW(10) & "Rows where h<   15 and  > 75 appear Yellow (Sun) or Whit" &
    "e (Stars, Moon and Planets)." & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.txtBx2.WordWrap = False
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(548, 4)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(250, 20)
        Me.TextBox4.TabIndex = 106
        Me.TextBox4.Text = "3rd Magnitude Stars"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DGMag3
        '
        Me.DGMag3.AllowUserToAddRows = False
        Me.DGMag3.AllowUserToDeleteRows = False
        Me.DGMag3.AllowUserToResizeColumns = False
        Me.DGMag3.AllowUserToResizeRows = False
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DGMag3.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DGMag3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGMag3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Cyan
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGMag3.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DGMag3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGMag3.Cursor = System.Windows.Forms.Cursors.Default
        Me.DGMag3.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGMag3.Enabled = False
        Me.DGMag3.Location = New System.Drawing.Point(548, 27)
        Me.DGMag3.MultiSelect = False
        Me.DGMag3.Name = "DGMag3"
        Me.DGMag3.ReadOnly = True
        Me.DGMag3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DGMag3.RowHeadersVisible = False
        Me.DGMag3.RowTemplate.ReadOnly = True
        Me.DGMag3.Size = New System.Drawing.Size(250, 386)
        Me.DGMag3.TabIndex = 105
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(295, 4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(250, 20)
        Me.TextBox3.TabIndex = 104
        Me.TextBox3.Text = "2nd Magnitude Stars"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DGMag2
        '
        Me.DGMag2.AllowUserToAddRows = False
        Me.DGMag2.AllowUserToDeleteRows = False
        Me.DGMag2.AllowUserToResizeColumns = False
        Me.DGMag2.AllowUserToResizeRows = False
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DGMag2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DGMag2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGMag2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.Cyan
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGMag2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DGMag2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGMag2.Cursor = System.Windows.Forms.Cursors.Default
        Me.DGMag2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGMag2.Location = New System.Drawing.Point(295, 27)
        Me.DGMag2.MultiSelect = False
        Me.DGMag2.Name = "DGMag2"
        Me.DGMag2.ReadOnly = True
        Me.DGMag2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DGMag2.RowHeadersVisible = False
        Me.DGMag2.RowTemplate.ReadOnly = True
        Me.DGMag2.Size = New System.Drawing.Size(250, 460)
        Me.DGMag2.TabIndex = 103
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(41, 4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(250, 20)
        Me.TextBox2.TabIndex = 102
        Me.TextBox2.Text = "1st Mag Stars & Solar System Objects"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DGMag1
        '
        Me.DGMag1.AllowUserToAddRows = False
        Me.DGMag1.AllowUserToDeleteRows = False
        Me.DGMag1.AllowUserToResizeColumns = False
        Me.DGMag1.AllowUserToResizeRows = False
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DGMag1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.DGMag1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.Cyan
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGMag1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.DGMag1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGMag1.Cursor = System.Windows.Forms.Cursors.Default
        Me.DGMag1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGMag1.Location = New System.Drawing.Point(42, 27)
        Me.DGMag1.MultiSelect = False
        Me.DGMag1.Name = "DGMag1"
        Me.DGMag1.ReadOnly = True
        Me.DGMag1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DGMag1.RowHeadersVisible = False
        Me.DGMag1.RowTemplate.ReadOnly = True
        Me.DGMag1.Size = New System.Drawing.Size(250, 460)
        Me.DGMag1.TabIndex = 100
        '
        'ViewVisiblePg
        '
        Me.ViewVisiblePg.AutoScroll = True
        Me.ViewVisiblePg.BackColor = System.Drawing.SystemColors.Window
        Me.ViewVisiblePg.Controls.Add(Me.TextBox1)
        Me.ViewVisiblePg.Controls.Add(Me.lblSLeft)
        Me.ViewVisiblePg.Controls.Add(Me.lblSRight)
        Me.ViewVisiblePg.Controls.Add(Me.chkHelper)
        Me.ViewVisiblePg.Controls.Add(Me.chkLimit)
        Me.ViewVisiblePg.Controls.Add(Me.chkFirst)
        Me.ViewVisiblePg.Controls.Add(Me.chkSecond)
        Me.ViewVisiblePg.Controls.Add(Me.chkThird)
        Me.ViewVisiblePg.Controls.Add(Me.chkNames)
        Me.ViewVisiblePg.Controls.Add(Me.lblBody)
        Me.ViewVisiblePg.Controls.Add(Me.lblBodyName)
        Me.ViewVisiblePg.Controls.Add(Me.lblAlt)
        Me.ViewVisiblePg.Controls.Add(Me.lblAz)
        Me.ViewVisiblePg.Controls.Add(Me.lblAzimuth)
        Me.ViewVisiblePg.Controls.Add(Me.lblAltitude)
        Me.ViewVisiblePg.Controls.Add(Me.Label7)
        Me.ViewVisiblePg.Controls.Add(Me.Label5)
        Me.ViewVisiblePg.Controls.Add(Me.lblW)
        Me.ViewVisiblePg.Controls.Add(Me.lblE)
        Me.ViewVisiblePg.Controls.Add(Me.lblS)
        Me.ViewVisiblePg.Controls.Add(Me.lblN)
        Me.ViewVisiblePg.Controls.Add(Me.SkyPicBx)
        Me.ViewVisiblePg.Controls.Add(Me.FrameBest)
        Me.ViewVisiblePg.Controls.Add(Me.FrameDirection)
        Me.ViewVisiblePg.Controls.Add(Me.FrameView)
        Me.ViewVisiblePg.Location = New System.Drawing.Point(4, 25)
        Me.ViewVisiblePg.Name = "ViewVisiblePg"
        Me.ViewVisiblePg.Padding = New System.Windows.Forms.Padding(3)
        Me.ViewVisiblePg.Size = New System.Drawing.Size(836, 527)
        Me.ViewVisiblePg.TabIndex = 1
        Me.ViewVisiblePg.Text = "View Visible Bodies"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(667, 18)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(119, 49)
        Me.TextBox1.TabIndex = 114
        Me.TextBox1.Text = "Move Mouse Over" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Body to Display its" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Name, Az, Altitude"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblSLeft
        '
        Me.lblSLeft.BackColor = System.Drawing.Color.Transparent
        Me.lblSLeft.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSLeft.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSLeft.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSLeft.Location = New System.Drawing.Point(171, 510)
        Me.lblSLeft.Name = "lblSLeft"
        Me.lblSLeft.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSLeft.Size = New System.Drawing.Size(9, 12)
        Me.lblSLeft.TabIndex = 113
        Me.lblSLeft.Text = "S"
        Me.lblSLeft.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblSRight
        '
        Me.lblSRight.BackColor = System.Drawing.Color.Transparent
        Me.lblSRight.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSRight.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSRight.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSRight.Location = New System.Drawing.Point(655, 510)
        Me.lblSRight.Name = "lblSRight"
        Me.lblSRight.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSRight.Size = New System.Drawing.Size(9, 12)
        Me.lblSRight.TabIndex = 112
        Me.lblSRight.Text = "S"
        Me.lblSRight.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'chkHelper
        '
        Me.chkHelper.BackColor = System.Drawing.SystemColors.Window
        Me.chkHelper.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkHelper.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkHelper.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkHelper.Location = New System.Drawing.Point(8, 327)
        Me.chkHelper.Name = "chkHelper"
        Me.chkHelper.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkHelper.Size = New System.Drawing.Size(105, 17)
        Me.chkHelper.TabIndex = 108
        Me.chkHelper.Text = "Show Helpers"
        Me.chkHelper.UseVisualStyleBackColor = False
        '
        'chkLimit
        '
        Me.chkLimit.BackColor = System.Drawing.SystemColors.Window
        Me.chkLimit.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkLimit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLimit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkLimit.Location = New System.Drawing.Point(8, 307)
        Me.chkLimit.Name = "chkLimit"
        Me.chkLimit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkLimit.Size = New System.Drawing.Size(121, 17)
        Me.chkLimit.TabIndex = 105
        Me.chkLimit.Text = "Limit azimuth range"
        Me.chkLimit.UseVisualStyleBackColor = False
        '
        'chkFirst
        '
        Me.chkFirst.BackColor = System.Drawing.SystemColors.Window
        Me.chkFirst.Checked = True
        Me.chkFirst.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFirst.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkFirst.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFirst.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkFirst.Location = New System.Drawing.Point(9, 210)
        Me.chkFirst.Name = "chkFirst"
        Me.chkFirst.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkFirst.Size = New System.Drawing.Size(149, 35)
        Me.chkFirst.TabIndex = 104
        Me.chkFirst.Text = "1st Mag. Stars, Sun,Moon, Planets-Blue" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.chkFirst.UseVisualStyleBackColor = False
        '
        'chkSecond
        '
        Me.chkSecond.BackColor = System.Drawing.SystemColors.Window
        Me.chkSecond.Checked = True
        Me.chkSecond.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSecond.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkSecond.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSecond.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSecond.Location = New System.Drawing.Point(8, 245)
        Me.chkSecond.Name = "chkSecond"
        Me.chkSecond.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkSecond.Size = New System.Drawing.Size(150, 21)
        Me.chkSecond.TabIndex = 103
        Me.chkSecond.Text = "2nd Mag. Stars-DarkGray"
        Me.chkSecond.UseVisualStyleBackColor = False
        '
        'chkThird
        '
        Me.chkThird.BackColor = System.Drawing.SystemColors.Window
        Me.chkThird.Checked = True
        Me.chkThird.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkThird.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkThird.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkThird.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkThird.Location = New System.Drawing.Point(8, 264)
        Me.chkThird.Name = "chkThird"
        Me.chkThird.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkThird.Size = New System.Drawing.Size(154, 25)
        Me.chkThird.TabIndex = 102
        Me.chkThird.Text = "3rd Mag. Stars-LightGray"
        Me.chkThird.UseVisualStyleBackColor = False
        '
        'chkNames
        '
        Me.chkNames.BackColor = System.Drawing.SystemColors.Window
        Me.chkNames.Checked = True
        Me.chkNames.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNames.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkNames.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNames.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkNames.Location = New System.Drawing.Point(8, 287)
        Me.chkNames.Name = "chkNames"
        Me.chkNames.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkNames.Size = New System.Drawing.Size(139, 18)
        Me.chkNames.TabIndex = 101
        Me.chkNames.Text = "Show Names"
        Me.chkNames.UseVisualStyleBackColor = False
        '
        'lblBody
        '
        Me.lblBody.BackColor = System.Drawing.SystemColors.Window
        Me.lblBody.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblBody.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBody.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblBody.Location = New System.Drawing.Point(664, 76)
        Me.lblBody.Name = "lblBody"
        Me.lblBody.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBody.Size = New System.Drawing.Size(35, 17)
        Me.lblBody.TabIndex = 110
        Me.lblBody.Text = "Name"
        Me.lblBody.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblBody.Visible = False
        '
        'lblBodyName
        '
        Me.lblBodyName.BackColor = System.Drawing.SystemColors.Window
        Me.lblBodyName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBodyName.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblBodyName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBodyName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblBodyName.Location = New System.Drawing.Point(699, 75)
        Me.lblBodyName.Name = "lblBodyName"
        Me.lblBodyName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBodyName.Size = New System.Drawing.Size(90, 22)
        Me.lblBodyName.TabIndex = 109
        Me.lblBodyName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblBodyName.Visible = False
        '
        'lblAlt
        '
        Me.lblAlt.BackColor = System.Drawing.SystemColors.Window
        Me.lblAlt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAlt.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAlt.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAlt.Location = New System.Drawing.Point(738, 123)
        Me.lblAlt.Name = "lblAlt"
        Me.lblAlt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAlt.Size = New System.Drawing.Size(42, 17)
        Me.lblAlt.TabIndex = 107
        Me.lblAlt.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblAlt.Visible = False
        '
        'lblAz
        '
        Me.lblAz.BackColor = System.Drawing.SystemColors.Window
        Me.lblAz.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAz.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAz.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAz.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAz.Location = New System.Drawing.Point(738, 99)
        Me.lblAz.Name = "lblAz"
        Me.lblAz.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAz.Size = New System.Drawing.Size(42, 17)
        Me.lblAz.TabIndex = 106
        Me.lblAz.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblAz.Visible = False
        '
        'lblAzimuth
        '
        Me.lblAzimuth.BackColor = System.Drawing.SystemColors.Window
        Me.lblAzimuth.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAzimuth.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAzimuth.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAzimuth.Location = New System.Drawing.Point(690, 100)
        Me.lblAzimuth.Name = "lblAzimuth"
        Me.lblAzimuth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAzimuth.Size = New System.Drawing.Size(48, 17)
        Me.lblAzimuth.TabIndex = 100
        Me.lblAzimuth.Text = "Azimuth"
        Me.lblAzimuth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblAzimuth.Visible = False
        '
        'lblAltitude
        '
        Me.lblAltitude.BackColor = System.Drawing.SystemColors.Window
        Me.lblAltitude.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAltitude.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAltitude.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAltitude.Location = New System.Drawing.Point(691, 124)
        Me.lblAltitude.Name = "lblAltitude"
        Me.lblAltitude.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAltitude.Size = New System.Drawing.Size(48, 17)
        Me.lblAltitude.TabIndex = 99
        Me.lblAltitude.Text = "Altitude"
        Me.lblAltitude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblAltitude.Visible = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Window
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(777, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(9, 17)
        Me.Label7.TabIndex = 98
        Me.Label7.Text = "°"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Window
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(777, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(9, 25)
        Me.Label5.TabIndex = 97
        Me.Label5.Text = "°"
        Me.Label5.Visible = False
        '
        'lblW
        '
        Me.lblW.BackColor = System.Drawing.Color.Transparent
        Me.lblW.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblW.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblW.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblW.Location = New System.Drawing.Point(670, 250)
        Me.lblW.Name = "lblW"
        Me.lblW.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblW.Size = New System.Drawing.Size(12, 17)
        Me.lblW.TabIndex = 96
        Me.lblW.Text = "W"
        Me.lblW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblE
        '
        Me.lblE.BackColor = System.Drawing.Color.Transparent
        Me.lblE.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblE.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblE.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblE.Location = New System.Drawing.Point(160, 249)
        Me.lblE.Name = "lblE"
        Me.lblE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblE.Size = New System.Drawing.Size(9, 17)
        Me.lblE.TabIndex = 95
        Me.lblE.Text = "E"
        Me.lblE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblS
        '
        Me.lblS.BackColor = System.Drawing.Color.Transparent
        Me.lblS.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblS.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblS.Location = New System.Drawing.Point(416, 510)
        Me.lblS.Name = "lblS"
        Me.lblS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblS.Size = New System.Drawing.Size(9, 12)
        Me.lblS.TabIndex = 94
        Me.lblS.Text = "S"
        Me.lblS.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblN
        '
        Me.lblN.BackColor = System.Drawing.Color.Transparent
        Me.lblN.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblN.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblN.Location = New System.Drawing.Point(415, 0)
        Me.lblN.Name = "lblN"
        Me.lblN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblN.Size = New System.Drawing.Size(9, 17)
        Me.lblN.TabIndex = 93
        Me.lblN.Text = "N"
        Me.lblN.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'SkyPicBx
        '
        Me.SkyPicBx.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SkyPicBx.Cursor = System.Windows.Forms.Cursors.Default
        Me.SkyPicBx.ErrorImage = Nothing
        Me.SkyPicBx.InitialImage = Nothing
        Me.SkyPicBx.Location = New System.Drawing.Point(174, 18)
        Me.SkyPicBx.Name = "SkyPicBx"
        Me.SkyPicBx.Size = New System.Drawing.Size(490, 490)
        Me.SkyPicBx.TabIndex = 111
        Me.SkyPicBx.TabStop = False
        '
        'FrameBest
        '
        Me.FrameBest.BackColor = System.Drawing.SystemColors.Window
        Me.FrameBest.Controls.Add(Me.RotateIncr)
        Me.FrameBest.Controls.Add(Me.ResetRotateBtn)
        Me.FrameBest.Controls.Add(Me.cmdCW)
        Me.FrameBest.Controls.Add(Me.optThreeBeach)
        Me.FrameBest.Controls.Add(Me.cmdCCW)
        Me.FrameBest.Controls.Add(Me.optThreeBoat)
        Me.FrameBest.Controls.Add(Me.optTwo)
        Me.FrameBest.Controls.Add(Me.optOff)
        Me.FrameBest.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FrameBest.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FrameBest.Location = New System.Drawing.Point(3, 378)
        Me.FrameBest.Name = "FrameBest"
        Me.FrameBest.Padding = New System.Windows.Forms.Padding(0)
        Me.FrameBest.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FrameBest.Size = New System.Drawing.Size(162, 145)
        Me.FrameBest.TabIndex = 76
        Me.FrameBest.TabStop = False
        Me.FrameBest.Text = "Best Bodies Aid"
        '
        'RotateIncr
        '
        Me.RotateIncr.BackColor = System.Drawing.SystemColors.Control
        Me.RotateIncr.Enabled = False
        Me.RotateIncr.FormattingEnabled = True
        Me.RotateIncr.Items.AddRange(New Object() {"1", "5", "15", "30", "45", "90"})
        Me.RotateIncr.Location = New System.Drawing.Point(79, 118)
        Me.RotateIncr.Name = "RotateIncr"
        Me.RotateIncr.Size = New System.Drawing.Size(76, 22)
        Me.RotateIncr.TabIndex = 81
        Me.RotateIncr.Text = "Rotate Deg"
        '
        'ResetRotateBtn
        '
        Me.ResetRotateBtn.BackColor = System.Drawing.SystemColors.Control
        Me.ResetRotateBtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.ResetRotateBtn.Enabled = False
        Me.ResetRotateBtn.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetRotateBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ResetRotateBtn.Location = New System.Drawing.Point(4, 114)
        Me.ResetRotateBtn.Name = "ResetRotateBtn"
        Me.ResetRotateBtn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ResetRotateBtn.Size = New System.Drawing.Size(72, 29)
        Me.ResetRotateBtn.TabIndex = 80
        Me.ResetRotateBtn.Text = "Reset Rotate"
        Me.ResetRotateBtn.UseVisualStyleBackColor = False
        '
        'cmdCW
        '
        Me.cmdCW.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCW.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCW.Enabled = False
        Me.cmdCW.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCW.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCW.Location = New System.Drawing.Point(80, 83)
        Me.cmdCW.Name = "cmdCW"
        Me.cmdCW.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCW.Size = New System.Drawing.Size(72, 29)
        Me.cmdCW.TabIndex = 78
        Me.cmdCW.Text = "  Rotate CW"
        Me.cmdCW.UseVisualStyleBackColor = False
        '
        'cmdCCW
        '
        Me.cmdCCW.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCCW.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCCW.Enabled = False
        Me.cmdCCW.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCCW.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCCW.Location = New System.Drawing.Point(4, 83)
        Me.cmdCCW.Name = "cmdCCW"
        Me.cmdCCW.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCCW.Size = New System.Drawing.Size(72, 29)
        Me.cmdCCW.TabIndex = 77
        Me.cmdCCW.Text = "Rotate CCW"
        Me.cmdCCW.UseVisualStyleBackColor = False
        '
        'optTwo
        '
        Me.optTwo.BackColor = System.Drawing.SystemColors.Window
        Me.optTwo.Cursor = System.Windows.Forms.Cursors.Default
        Me.optTwo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optTwo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optTwo.Location = New System.Drawing.Point(8, 32)
        Me.optTwo.Name = "optTwo"
        Me.optTwo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optTwo.Size = New System.Drawing.Size(89, 17)
        Me.optTwo.TabIndex = 75
        Me.optTwo.TabStop = True
        Me.optTwo.Text = "Two-body fix"
        Me.optTwo.UseVisualStyleBackColor = False
        '
        'optOff
        '
        Me.optOff.BackColor = System.Drawing.SystemColors.Window
        Me.optOff.Checked = True
        Me.optOff.Cursor = System.Windows.Forms.Cursors.Default
        Me.optOff.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optOff.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optOff.Location = New System.Drawing.Point(8, 16)
        Me.optOff.Name = "optOff"
        Me.optOff.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optOff.Size = New System.Drawing.Size(49, 17)
        Me.optOff.TabIndex = 74
        Me.optOff.TabStop = True
        Me.optOff.Text = "Off"
        Me.optOff.UseVisualStyleBackColor = False
        '
        'FrameDirection
        '
        Me.FrameDirection.BackColor = System.Drawing.SystemColors.Window
        Me.FrameDirection.Controls.Add(Me.optW)
        Me.FrameDirection.Controls.Add(Me.optE)
        Me.FrameDirection.Controls.Add(Me.optS)
        Me.FrameDirection.Controls.Add(Me.optN)
        Me.FrameDirection.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FrameDirection.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FrameDirection.Location = New System.Drawing.Point(8, 84)
        Me.FrameDirection.Name = "FrameDirection"
        Me.FrameDirection.Padding = New System.Windows.Forms.Padding(0)
        Me.FrameDirection.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FrameDirection.Size = New System.Drawing.Size(97, 89)
        Me.FrameDirection.TabIndex = 75
        Me.FrameDirection.TabStop = False
        Me.FrameDirection.Text = "View toward"
        '
        'optW
        '
        Me.optW.BackColor = System.Drawing.SystemColors.Window
        Me.optW.Cursor = System.Windows.Forms.Cursors.Default
        Me.optW.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optW.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optW.Location = New System.Drawing.Point(8, 64)
        Me.optW.Name = "optW"
        Me.optW.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optW.Size = New System.Drawing.Size(65, 17)
        Me.optW.TabIndex = 65
        Me.optW.TabStop = True
        Me.optW.Text = "West"
        Me.optW.UseVisualStyleBackColor = False
        '
        'optE
        '
        Me.optE.BackColor = System.Drawing.SystemColors.Window
        Me.optE.Cursor = System.Windows.Forms.Cursors.Default
        Me.optE.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optE.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optE.Location = New System.Drawing.Point(8, 48)
        Me.optE.Name = "optE"
        Me.optE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optE.Size = New System.Drawing.Size(73, 17)
        Me.optE.TabIndex = 64
        Me.optE.TabStop = True
        Me.optE.Text = "East"
        Me.optE.UseVisualStyleBackColor = False
        '
        'optS
        '
        Me.optS.BackColor = System.Drawing.SystemColors.Window
        Me.optS.Checked = True
        Me.optS.Cursor = System.Windows.Forms.Cursors.Default
        Me.optS.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optS.Location = New System.Drawing.Point(8, 32)
        Me.optS.Name = "optS"
        Me.optS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optS.Size = New System.Drawing.Size(73, 17)
        Me.optS.TabIndex = 63
        Me.optS.TabStop = True
        Me.optS.Text = "South"
        Me.optS.UseVisualStyleBackColor = False
        '
        'optN
        '
        Me.optN.BackColor = System.Drawing.SystemColors.Window
        Me.optN.Cursor = System.Windows.Forms.Cursors.Default
        Me.optN.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optN.Location = New System.Drawing.Point(8, 16)
        Me.optN.Name = "optN"
        Me.optN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optN.Size = New System.Drawing.Size(73, 17)
        Me.optN.TabIndex = 62
        Me.optN.TabStop = True
        Me.optN.Text = "North"
        Me.optN.UseVisualStyleBackColor = False
        '
        'FrameView
        '
        Me.FrameView.BackColor = System.Drawing.SystemColors.Window
        Me.FrameView.Controls.Add(Me.optHorizon)
        Me.FrameView.Controls.Add(Me.optStarFinder)
        Me.FrameView.Controls.Add(Me.optOverhead)
        Me.FrameView.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FrameView.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FrameView.Location = New System.Drawing.Point(8, 7)
        Me.FrameView.Name = "FrameView"
        Me.FrameView.Padding = New System.Windows.Forms.Padding(0)
        Me.FrameView.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FrameView.Size = New System.Drawing.Size(97, 73)
        Me.FrameView.TabIndex = 74
        Me.FrameView.TabStop = False
        Me.FrameView.Text = "View"
        '
        'optHorizon
        '
        Me.optHorizon.BackColor = System.Drawing.SystemColors.Window
        Me.optHorizon.Cursor = System.Windows.Forms.Cursors.Default
        Me.optHorizon.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optHorizon.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optHorizon.Location = New System.Drawing.Point(8, 49)
        Me.optHorizon.Name = "optHorizon"
        Me.optHorizon.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optHorizon.Size = New System.Drawing.Size(81, 17)
        Me.optHorizon.TabIndex = 60
        Me.optHorizon.TabStop = True
        Me.optHorizon.Text = "Horizon"
        Me.optHorizon.UseVisualStyleBackColor = False
        '
        'optStarFinder
        '
        Me.optStarFinder.BackColor = System.Drawing.SystemColors.Window
        Me.optStarFinder.Cursor = System.Windows.Forms.Cursors.Default
        Me.optStarFinder.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optStarFinder.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optStarFinder.Location = New System.Drawing.Point(8, 32)
        Me.optStarFinder.Name = "optStarFinder"
        Me.optStarFinder.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optStarFinder.Size = New System.Drawing.Size(86, 17)
        Me.optStarFinder.TabIndex = 58
        Me.optStarFinder.TabStop = True
        Me.optStarFinder.Text = """Star Finder"""
        Me.optStarFinder.UseVisualStyleBackColor = False
        '
        'optOverhead
        '
        Me.optOverhead.BackColor = System.Drawing.SystemColors.Window
        Me.optOverhead.Checked = True
        Me.optOverhead.Cursor = System.Windows.Forms.Cursors.Default
        Me.optOverhead.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optOverhead.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optOverhead.Location = New System.Drawing.Point(8, 15)
        Me.optOverhead.Name = "optOverhead"
        Me.optOverhead.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optOverhead.Size = New System.Drawing.Size(73, 17)
        Me.optOverhead.TabIndex = 57
        Me.optOverhead.TabStop = True
        Me.optOverhead.Text = "Overhead"
        Me.optOverhead.UseVisualStyleBackColor = False
        '
        'StarFinder1Pg
        '
        Me.StarFinder1Pg.BackColor = System.Drawing.SystemColors.Window
        Me.StarFinder1Pg.Controls.Add(Me.ReportTxtBx)
        Me.StarFinder1Pg.Location = New System.Drawing.Point(4, 25)
        Me.StarFinder1Pg.Name = "StarFinder1Pg"
        Me.StarFinder1Pg.Padding = New System.Windows.Forms.Padding(3)
        Me.StarFinder1Pg.Size = New System.Drawing.Size(836, 527)
        Me.StarFinder1Pg.TabIndex = 0
        Me.StarFinder1Pg.Text = "Star Finder Data"
        '
        'ReportTxtBx
        '
        Me.ReportTxtBx.BackColor = System.Drawing.SystemColors.Window
        Me.ReportTxtBx.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportTxtBx.Location = New System.Drawing.Point(51, 6)
        Me.ReportTxtBx.Multiline = True
        Me.ReportTxtBx.Name = "ReportTxtBx"
        Me.ReportTxtBx.ReadOnly = True
        Me.ReportTxtBx.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ReportTxtBx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ReportTxtBx.Size = New System.Drawing.Size(683, 475)
        Me.ReportTxtBx.TabIndex = 95
        '
        'SunRiseSunSet
        '
        Me.SunRiseSunSet.Controls.Add(Me.SunRiseSet)
        Me.SunRiseSunSet.Location = New System.Drawing.Point(4, 25)
        Me.SunRiseSunSet.Name = "SunRiseSunSet"
        Me.SunRiseSunSet.Size = New System.Drawing.Size(836, 527)
        Me.SunRiseSunSet.TabIndex = 3
        Me.SunRiseSunSet.Text = "Rising / Setting Times"
        Me.SunRiseSunSet.UseVisualStyleBackColor = True
        '
        'SunRiseSet
        '
        Me.SunRiseSet.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SunRiseSet.BackColor = System.Drawing.Color.MediumTurquoise
        Me.SunRiseSet.Cursor = System.Windows.Forms.Cursors.Default
        Me.SunRiseSet.ErrorImage = Nothing
        Me.SunRiseSet.InitialImage = Nothing
        Me.SunRiseSet.Location = New System.Drawing.Point(18, 4)
        Me.SunRiseSet.Name = "SunRiseSet"
        Me.SunRiseSet.Size = New System.Drawing.Size(800, 520)
        Me.SunRiseSet.TabIndex = 112
        Me.SunRiseSet.TabStop = False
        '
        'MoonTxtBxRight
        '
        Me.MoonTxtBxRight.BackColor = System.Drawing.SystemColors.Window
        Me.MoonTxtBxRight.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MoonTxtBxRight.Location = New System.Drawing.Point(560, 196)
        Me.MoonTxtBxRight.Multiline = False
        Me.MoonTxtBxRight.Name = "MoonTxtBxRight"
        Me.MoonTxtBxRight.ReadOnly = True
        Me.MoonTxtBxRight.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.MoonTxtBxRight.Size = New System.Drawing.Size(176, 17)
        Me.MoonTxtBxRight.TabIndex = 100
        Me.MoonTxtBxRight.Text = ""
        '
        'DTPlan
        '
        Me.DTPlan.CustomFormat = "MM / dd / yyyy HH:mm"
        Me.DTPlan.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DTPlan.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPlan.Location = New System.Drawing.Point(107, 32)
        Me.DTPlan.Name = "DTPlan"
        Me.DTPlan.ShowUpDown = True
        Me.DTPlan.Size = New System.Drawing.Size(130, 21)
        Me.DTPlan.TabIndex = 102
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CelestialTools.My.Resources.Resources.ABC_white
        Me.PictureBox1.Location = New System.Drawing.Point(255, 799)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(328, 45)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 101
        Me.PictureBox1.TabStop = False
        '
        'txtUserInfo
        '
        Me.txtUserInfo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserInfo.HideSelection = False
        Me.txtUserInfo.Location = New System.Drawing.Point(106, 5)
        Me.txtUserInfo.Name = "txtUserInfo"
        Me.txtUserInfo.Size = New System.Drawing.Size(400, 22)
        Me.txtUserInfo.TabIndex = 198
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 15)
        Me.Label1.TabIndex = 197
        Me.Label1.Text = "User Info"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkNoonSightLAN
        '
        Me.chkNoonSightLAN.AutoSize = True
        Me.chkNoonSightLAN.Location = New System.Drawing.Point(527, 85)
        Me.chkNoonSightLAN.Name = "chkNoonSightLAN"
        Me.chkNoonSightLAN.Size = New System.Drawing.Size(240, 17)
        Me.chkNoonSightLAN.TabIndex = 199
        Me.chkNoonSightLAN.Text = "Display Local Apparent Noon from NoonSight"
        Me.chkNoonSightLAN.UseVisualStyleBackColor = True
        '
        'txtLAN
        '
        Me.txtLAN.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLAN.Location = New System.Drawing.Point(770, 83)
        Me.txtLAN.MaxLength = 8
        Me.txtLAN.Name = "txtLAN"
        Me.txtLAN.ReadOnly = True
        Me.txtLAN.Size = New System.Drawing.Size(60, 20)
        Me.txtLAN.TabIndex = 200
        Me.txtLAN.Visible = False
        '
        'cboLineWidth
        '
        Me.cboLineWidth.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLineWidth.FormattingEnabled = True
        Me.cboLineWidth.Items.AddRange(New Object() {"Thin", "Reg", "Wide", "XWide"})
        Me.cboLineWidth.Location = New System.Drawing.Point(780, 110)
        Me.cboLineWidth.Name = "cboLineWidth"
        Me.cboLineWidth.Size = New System.Drawing.Size(60, 22)
        Me.cboLineWidth.TabIndex = 201
        Me.cboLineWidth.Visible = False
        '
        'lblLineWidth
        '
        Me.lblLineWidth.AutoSize = True
        Me.lblLineWidth.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLineWidth.Location = New System.Drawing.Point(738, 108)
        Me.lblLineWidth.Name = "lblLineWidth"
        Me.lblLineWidth.Size = New System.Drawing.Size(37, 28)
        Me.lblLineWidth.TabIndex = 202
        Me.lblLineWidth.Text = "Line " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Width:"
        Me.lblLineWidth.Visible = False
        '
        'txtIncreaseDT
        '
        Me.txtIncreaseDT.BackColor = System.Drawing.Color.Yellow
        Me.txtIncreaseDT.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIncreaseDT.Location = New System.Drawing.Point(5, 775)
        Me.txtIncreaseDT.Multiline = False
        Me.txtIncreaseDT.Name = "txtIncreaseDT"
        Me.txtIncreaseDT.ReadOnly = True
        Me.txtIncreaseDT.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtIncreaseDT.Size = New System.Drawing.Size(234, 21)
        Me.txtIncreaseDT.TabIndex = 203
        Me.txtIncreaseDT.Text = "                      Increase Date/Time"
        '
        'btnAdd1Hour
        '
        Me.btnAdd1Hour.BackColor = System.Drawing.Color.Silver
        Me.btnAdd1Hour.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd1Hour.Location = New System.Drawing.Point(85, 799)
        Me.btnAdd1Hour.Name = "btnAdd1Hour"
        Me.btnAdd1Hour.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd1Hour.TabIndex = 205
        Me.btnAdd1Hour.Text = "Add 1 Hour"
        Me.btnAdd1Hour.UseVisualStyleBackColor = False
        '
        'btnAdd1Day
        '
        Me.btnAdd1Day.BackColor = System.Drawing.Color.Silver
        Me.btnAdd1Day.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd1Day.Location = New System.Drawing.Point(164, 799)
        Me.btnAdd1Day.Name = "btnAdd1Day"
        Me.btnAdd1Day.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd1Day.TabIndex = 206
        Me.btnAdd1Day.Text = "Add 1 Day"
        Me.btnAdd1Day.UseVisualStyleBackColor = False
        '
        'btnAdd1Week
        '
        Me.btnAdd1Week.BackColor = System.Drawing.Color.Silver
        Me.btnAdd1Week.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd1Week.Location = New System.Drawing.Point(4, 822)
        Me.btnAdd1Week.Name = "btnAdd1Week"
        Me.btnAdd1Week.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd1Week.TabIndex = 207
        Me.btnAdd1Week.Text = "Add 1 Week"
        Me.btnAdd1Week.UseVisualStyleBackColor = False
        '
        'btnAdd1Month
        '
        Me.btnAdd1Month.BackColor = System.Drawing.Color.Silver
        Me.btnAdd1Month.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd1Month.Location = New System.Drawing.Point(85, 822)
        Me.btnAdd1Month.Name = "btnAdd1Month"
        Me.btnAdd1Month.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd1Month.TabIndex = 208
        Me.btnAdd1Month.Text = "Add 1 Month"
        Me.btnAdd1Month.UseVisualStyleBackColor = False
        '
        'btnAdd30Min
        '
        Me.btnAdd30Min.BackColor = System.Drawing.Color.Silver
        Me.btnAdd30Min.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd30Min.Location = New System.Drawing.Point(4, 799)
        Me.btnAdd30Min.Name = "btnAdd30Min"
        Me.btnAdd30Min.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd30Min.TabIndex = 209
        Me.btnAdd30Min.Text = "Add 30 Min"
        Me.btnAdd30Min.UseVisualStyleBackColor = False
        '
        'btnAdd1Year
        '
        Me.btnAdd1Year.BackColor = System.Drawing.Color.Silver
        Me.btnAdd1Year.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd1Year.Location = New System.Drawing.Point(164, 823)
        Me.btnAdd1Year.Name = "btnAdd1Year"
        Me.btnAdd1Year.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd1Year.TabIndex = 210
        Me.btnAdd1Year.Text = "Add 1 Year"
        Me.btnAdd1Year.UseVisualStyleBackColor = False
        '
        'btnSub1Year
        '
        Me.btnSub1Year.BackColor = System.Drawing.Color.Silver
        Me.btnSub1Year.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSub1Year.Location = New System.Drawing.Point(765, 823)
        Me.btnSub1Year.Name = "btnSub1Year"
        Me.btnSub1Year.Size = New System.Drawing.Size(75, 23)
        Me.btnSub1Year.TabIndex = 217
        Me.btnSub1Year.Text = "Subt 1 Year"
        Me.btnSub1Year.UseVisualStyleBackColor = False
        '
        'btnSub30Min
        '
        Me.btnSub30Min.BackColor = System.Drawing.Color.Silver
        Me.btnSub30Min.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSub30Min.Location = New System.Drawing.Point(605, 799)
        Me.btnSub30Min.Name = "btnSub30Min"
        Me.btnSub30Min.Size = New System.Drawing.Size(75, 23)
        Me.btnSub30Min.TabIndex = 216
        Me.btnSub30Min.Text = "Subt 30 Min"
        Me.btnSub30Min.UseVisualStyleBackColor = False
        '
        'btnSub1Month
        '
        Me.btnSub1Month.BackColor = System.Drawing.Color.Silver
        Me.btnSub1Month.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSub1Month.Location = New System.Drawing.Point(686, 822)
        Me.btnSub1Month.Name = "btnSub1Month"
        Me.btnSub1Month.Size = New System.Drawing.Size(75, 23)
        Me.btnSub1Month.TabIndex = 215
        Me.btnSub1Month.Text = "Subt 1 Month"
        Me.btnSub1Month.UseVisualStyleBackColor = False
        '
        'btnSub1Week
        '
        Me.btnSub1Week.BackColor = System.Drawing.Color.Silver
        Me.btnSub1Week.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSub1Week.Location = New System.Drawing.Point(605, 822)
        Me.btnSub1Week.Name = "btnSub1Week"
        Me.btnSub1Week.Size = New System.Drawing.Size(75, 23)
        Me.btnSub1Week.TabIndex = 214
        Me.btnSub1Week.Text = "Subt 1 Week"
        Me.btnSub1Week.UseVisualStyleBackColor = False
        '
        'btnSub1Day
        '
        Me.btnSub1Day.BackColor = System.Drawing.Color.Silver
        Me.btnSub1Day.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSub1Day.Location = New System.Drawing.Point(765, 799)
        Me.btnSub1Day.Name = "btnSub1Day"
        Me.btnSub1Day.Size = New System.Drawing.Size(75, 23)
        Me.btnSub1Day.TabIndex = 213
        Me.btnSub1Day.Text = "Subt 1 Day"
        Me.btnSub1Day.UseVisualStyleBackColor = False
        '
        'btnSub1Hour
        '
        Me.btnSub1Hour.BackColor = System.Drawing.Color.Silver
        Me.btnSub1Hour.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSub1Hour.Location = New System.Drawing.Point(686, 799)
        Me.btnSub1Hour.Name = "btnSub1Hour"
        Me.btnSub1Hour.Size = New System.Drawing.Size(75, 23)
        Me.btnSub1Hour.TabIndex = 212
        Me.btnSub1Hour.Text = "Subt 1 Hour"
        Me.btnSub1Hour.UseVisualStyleBackColor = False
        '
        'txtDecreaseDT
        '
        Me.txtDecreaseDT.BackColor = System.Drawing.Color.Blue
        Me.txtDecreaseDT.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDecreaseDT.ForeColor = System.Drawing.Color.White
        Me.txtDecreaseDT.Location = New System.Drawing.Point(606, 775)
        Me.txtDecreaseDT.Multiline = False
        Me.txtDecreaseDT.Name = "txtDecreaseDT"
        Me.txtDecreaseDT.ReadOnly = True
        Me.txtDecreaseDT.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtDecreaseDT.Size = New System.Drawing.Size(234, 21)
        Me.txtDecreaseDT.TabIndex = 211
        Me.txtDecreaseDT.Text = "                      Decrease Date/Time"
        '
        'btnResetDTtoNow
        '
        Me.btnResetDTtoNow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnResetDTtoNow.Location = New System.Drawing.Point(329, 774)
        Me.btnResetDTtoNow.Name = "btnResetDTtoNow"
        Me.btnResetDTtoNow.Size = New System.Drawing.Size(175, 23)
        Me.btnResetDTtoNow.TabIndex = 218
        Me.btnResetDTtoNow.Text = "Reset Date / Time to Now"
        Me.btnResetDTtoNow.UseVisualStyleBackColor = False
        '
        'FormSightPlan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(852, 852)
        Me.Controls.Add(Me.btnResetDTtoNow)
        Me.Controls.Add(Me.btnSub1Year)
        Me.Controls.Add(Me.btnSub30Min)
        Me.Controls.Add(Me.btnSub1Month)
        Me.Controls.Add(Me.btnSub1Week)
        Me.Controls.Add(Me.btnSub1Day)
        Me.Controls.Add(Me.btnSub1Hour)
        Me.Controls.Add(Me.txtDecreaseDT)
        Me.Controls.Add(Me.btnAdd1Year)
        Me.Controls.Add(Me.btnAdd30Min)
        Me.Controls.Add(Me.btnAdd1Month)
        Me.Controls.Add(Me.btnAdd1Week)
        Me.Controls.Add(Me.btnAdd1Day)
        Me.Controls.Add(Me.btnAdd1Hour)
        Me.Controls.Add(Me.txtIncreaseDT)
        Me.Controls.Add(Me.lblLineWidth)
        Me.Controls.Add(Me.cboLineWidth)
        Me.Controls.Add(Me.txtLAN)
        Me.Controls.Add(Me.chkNoonSightLAN)
        Me.Controls.Add(Me.txtUserInfo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MoonTxtBxRight)
        Me.Controls.Add(Me.DTPlan)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtHighAz)
        Me.Controls.Add(Me.lblAz1)
        Me.Controls.Add(Me.txtLowAz)
        Me.Controls.Add(Me.lblAzDeg)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Plan1TabCntl)
        Me.Controls.Add(Me.txtWarning)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.SunTxtBx)
        Me.Controls.Add(Me.MoonTxtBx)
        Me.Controls.Add(Me.FrameZn)
        Me.Controls.Add(Me.txtMinimumAltitude)
        Me.Controls.Add(Me.chkDST)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.txtZDh)
        Me.Controls.Add(Me.FrameZD)
        Me.Controls.Add(Me.cboZDm)
        Me.Controls.Add(Me.cmdTwilights)
        Me.Controls.Add(Me.cboLo)
        Me.Controls.Add(Me.txtLoMin)
        Me.Controls.Add(Me.txtLoDeg)
        Me.Controls.Add(Me.cboL)
        Me.Controls.Add(Me.txtLMin)
        Me.Controls.Add(Me.txtLDeg)
        Me.Controls.Add(Me.lblAltDeg)
        Me.Controls.Add(Me.lblMinimumAltitude)
        Me.Controls.Add(Me.lblZDDST)
        Me.Controls.Add(Me.lblEnterTime)
        Me.Controls.Add(Me.lblZDh)
        Me.Controls.Add(Me.lblZDm)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblDRLo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblDRL)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.WEZDAutoManual)
        Me.Controls.Add(Me.lblWEZD)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(99, 29)
        Me.MaximizeBox = False
        Me.Name = "FormSightPlan"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Sight Planner"
        Me.FrameZn.ResumeLayout(False)
        Me.FrameZD.ResumeLayout(False)
        Me.Plan1TabCntl.ResumeLayout(False)
        Me.ListVisiblePg.ResumeLayout(False)
        Me.ListVisiblePg.PerformLayout()
        CType(Me.DGMag3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGMag2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGMag1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ViewVisiblePg.ResumeLayout(False)
        Me.ViewVisiblePg.PerformLayout()
        CType(Me.SkyPicBx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FrameBest.ResumeLayout(False)
        Me.FrameDirection.ResumeLayout(False)
        Me.FrameView.ResumeLayout(False)
        Me.StarFinder1Pg.ResumeLayout(False)
        Me.StarFinder1Pg.PerformLayout()
        Me.SunRiseSunSet.ResumeLayout(False)
        CType(Me.SunRiseSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MoonTxtBx As RichTextBox
    Friend WithEvents SunTxtBx As RichTextBox
    Public WithEvents ExitBtn As Button
    Friend WithEvents Plan1TabCntl As TabControl
    Friend WithEvents ListVisiblePg As TabPage
    Friend WithEvents ViewVisiblePg As TabPage
    Public WithEvents chkHelper As CheckBox
    Public WithEvents chkLimit As CheckBox
    Public WithEvents chkFirst As CheckBox
    Public WithEvents chkSecond As CheckBox
    Public WithEvents chkThird As CheckBox
    Public WithEvents chkNames As CheckBox
    Public WithEvents lblBody As Label
    Public WithEvents lblBodyName As Label
    Public WithEvents lblAlt As Label
    Public WithEvents lblAz As Label
    Public WithEvents lblAzimuth As Label
    Public WithEvents lblAltitude As Label
    Public WithEvents Label7 As Label
    Public WithEvents Label5 As Label
    Public WithEvents lblW As Label
    Public WithEvents lblE As Label
    Public WithEvents lblS As Label
    Public WithEvents lblN As Label
    Friend WithEvents SkyPicBx As PictureBox
    Public WithEvents FrameBest As GroupBox
    Public WithEvents optThreeBeach As RadioButton
    Public WithEvents cmdCW As Button
    Public WithEvents cmdCCW As Button
    Public WithEvents optThreeBoat As RadioButton
    Public WithEvents optTwo As RadioButton
    Public WithEvents optOff As RadioButton
    Public WithEvents FrameDirection As GroupBox
    Public WithEvents optW As RadioButton
    Public WithEvents optE As RadioButton
    Public WithEvents optS As RadioButton
    Public WithEvents optN As RadioButton
    Public WithEvents FrameView As GroupBox
    Public WithEvents optHorizon As RadioButton
    Public WithEvents optStarFinder As RadioButton
    Public WithEvents optOverhead As RadioButton
    Friend WithEvents StarFinder1Pg As TabPage
    Friend WithEvents ReportTxtBx As TextBox
    Friend WithEvents MoonTxtBxRight As RichTextBox
    Public WithEvents lblSLeft As Label
    Public WithEvents lblSRight As Label
    Public WithEvents ResetRotateBtn As Button
    Friend WithEvents RotateIncr As ComboBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DTPlan As DateTimePicker
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DGMag1 As DataGridView
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents DGMag2 As DataGridView
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents DGMag3 As DataGridView
    Friend WithEvents txtBx2 As RichTextBox
    Friend WithEvents Shape1 As TextBox
    Friend WithEvents txtUserInfo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SunRiseSunSet As TabPage
    Friend WithEvents SunRiseSet As PictureBox
    Friend WithEvents chkNoonSightLAN As CheckBox
    Friend WithEvents txtLAN As TextBox
    Friend WithEvents cboLineWidth As ComboBox
    Friend WithEvents lblLineWidth As Label
    Friend WithEvents txtIncreaseDT As RichTextBox
    Friend WithEvents btnAdd1Hour As Button
    Friend WithEvents btnAdd1Day As Button
    Friend WithEvents btnAdd1Week As Button
    Friend WithEvents btnAdd1Month As Button
    Friend WithEvents btnAdd30Min As Button
    Friend WithEvents btnAdd1Year As Button
    Friend WithEvents btnSub1Year As Button
    Friend WithEvents btnSub30Min As Button
    Friend WithEvents btnSub1Month As Button
    Friend WithEvents btnSub1Week As Button
    Friend WithEvents btnSub1Day As Button
    Friend WithEvents btnSub1Hour As Button
    Friend WithEvents txtDecreaseDT As RichTextBox
    Friend WithEvents btnResetDTtoNow As Button
#End Region
End Class