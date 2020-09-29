<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FormNoonSight
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
    Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents optHoSRForm As System.Windows.Forms.RadioButton
    Public WithEvents optStdTPNo As System.Windows.Forms.RadioButton
    Public WithEvents OptStdTPYes As System.Windows.Forms.RadioButton
    Public WithEvents txtTime As System.Windows.Forms.TextBox
    Public WithEvents chkDST As System.Windows.Forms.CheckBox
    Public WithEvents cmdPrint As System.Windows.Forms.Button
    Public WithEvents optDRL As System.Windows.Forms.RadioButton
    Public WithEvents txtDRLMin As System.Windows.Forms.TextBox
    Public WithEvents cboDRL As System.Windows.Forms.ComboBox
    Public WithEvents txtDRLDeg As System.Windows.Forms.TextBox
    Public WithEvents optAzS As System.Windows.Forms.RadioButton
    Public WithEvents optAzN As System.Windows.Forms.RadioButton
    Public WithEvents lblLDeg As System.Windows.Forms.Label
    Public WithEvents lblLMin As System.Windows.Forms.Label
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents optCenter As System.Windows.Forms.RadioButton
    Public WithEvents optUpper As System.Windows.Forms.RadioButton
    Public WithEvents optLower As System.Windows.Forms.RadioButton
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents cmdNoonSight As System.Windows.Forms.Button
    Public WithEvents txtHsDeg As System.Windows.Forms.TextBox
    Public WithEvents txtHsMin As System.Windows.Forms.TextBox
    Public WithEvents txtHsSec As System.Windows.Forms.TextBox
    Public WithEvents txtHE As System.Windows.Forms.TextBox
    Public WithEvents cboHE As System.Windows.Forms.ComboBox
    Public WithEvents txtIEmin As System.Windows.Forms.TextBox
    Public WithEvents cboIE As System.Windows.Forms.ComboBox
    Public WithEvents txtTemperature As System.Windows.Forms.TextBox
    Public WithEvents cboTemperature As System.Windows.Forms.ComboBox
    Public WithEvents txtPressure As System.Windows.Forms.TextBox
    Public WithEvents cboPressure As System.Windows.Forms.ComboBox
    Public WithEvents optHsDMm As System.Windows.Forms.RadioButton
    Public WithEvents optHsDMS As System.Windows.Forms.RadioButton
    Public WithEvents Framehs As System.Windows.Forms.Panel
    Public WithEvents optHorizonNatural As System.Windows.Forms.RadioButton
    Public WithEvents optHorizonArtificial As System.Windows.Forms.RadioButton
    Public WithEvents optHorizonDipShort As System.Windows.Forms.RadioButton
    Public WithEvents FrameHorizon As System.Windows.Forms.Panel
    Public WithEvents txtDsDist As System.Windows.Forms.TextBox
    Public WithEvents cboDsUnit As System.Windows.Forms.ComboBox
    Public WithEvents txtIEdeg As System.Windows.Forms.TextBox
    Public WithEvents cmdLAN As System.Windows.Forms.Button
    Public WithEvents txtZDh As System.Windows.Forms.TextBox
    Public WithEvents optZDUT As System.Windows.Forms.RadioButton
    Public WithEvents optZDAuto As System.Windows.Forms.RadioButton
    Public WithEvents optZDManual As System.Windows.Forms.RadioButton
    Public WithEvents FrameZD As System.Windows.Forms.Panel
    Public WithEvents cboZDm As System.Windows.Forms.ComboBox
    Public WithEvents txtLoDeg As System.Windows.Forms.TextBox
    Public WithEvents txtLoMin As System.Windows.Forms.TextBox
    Public WithEvents cboLo As System.Windows.Forms.ComboBox
    'Public WithEvents Line5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Public WithEvents lblHoCorrs As System.Windows.Forms.Label
    'Public WithEvents Line8 As Microsoft.VisualBasic.PowerPacks.LineShape
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents lblZDDST As System.Windows.Forms.Label
    Public WithEvents lblS As System.Windows.Forms.Label
    Public WithEvents lblZ As System.Windows.Forms.Label
    Public WithEvents lblN As System.Windows.Forms.Label
    'Public WithEvents Line4 As Microsoft.VisualBasic.PowerPacks.LineShape
    'Public WithEvents Line3 As Microsoft.VisualBasic.PowerPacks.LineShape
    'Public WithEvents Line2 As Microsoft.VisualBasic.PowerPacks.LineShape
    'Public WithEvents Line1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Public WithEvents lblHsFormat As System.Windows.Forms.Label
    Public WithEvents lblHs As System.Windows.Forms.Label
    Public WithEvents lblHsDeg As System.Windows.Forms.Label
    Public WithEvents lblHsMin As System.Windows.Forms.Label
    Public WithEvents lblHsSec As System.Windows.Forms.Label
    Public WithEvents lblHE As System.Windows.Forms.Label
    Public WithEvents lblIE As System.Windows.Forms.Label
    Public WithEvents lblIEMin As System.Windows.Forms.Label
    Public WithEvents lblStdT_P As System.Windows.Forms.Label
    Public WithEvents lblTemperature As System.Windows.Forms.Label
    Public WithEvents lblTempDeg As System.Windows.Forms.Label
    Public WithEvents lblPressure As System.Windows.Forms.Label
    Public WithEvents lblHorizon As System.Windows.Forms.Label
    Public WithEvents lblDsDist As System.Windows.Forms.Label
    Public WithEvents lblIEdeg As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents lblZDAutoManual As System.Windows.Forms.Label
    Public WithEvents lblZD As System.Windows.Forms.Label
    Public WithEvents lblZDh As System.Windows.Forms.Label
    Public WithEvents lblZDm As System.Windows.Forms.Label
    Public WithEvents lblDRLo As System.Windows.Forms.Label
    Public WithEvents lblLoDeg As System.Windows.Forms.Label
    Public WithEvents lblLoMin As System.Windows.Forms.Label
    Public WithEvents lblDate As System.Windows.Forms.Label
    'Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormNoonSight))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.optHoSRForm = New System.Windows.Forms.RadioButton()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.chkDST = New System.Windows.Forms.CheckBox()
        Me.txtDRLMin = New System.Windows.Forms.TextBox()
        Me.txtDRLDeg = New System.Windows.Forms.TextBox()
        Me.txtHsDeg = New System.Windows.Forms.TextBox()
        Me.txtHsMin = New System.Windows.Forms.TextBox()
        Me.txtHsSec = New System.Windows.Forms.TextBox()
        Me.txtHE = New System.Windows.Forms.TextBox()
        Me.txtIEmin = New System.Windows.Forms.TextBox()
        Me.txtTemperature = New System.Windows.Forms.TextBox()
        Me.txtPressure = New System.Windows.Forms.TextBox()
        Me.txtDsDist = New System.Windows.Forms.TextBox()
        Me.txtIEdeg = New System.Windows.Forms.TextBox()
        Me.txtZDh = New System.Windows.Forms.TextBox()
        Me.optZDAuto = New System.Windows.Forms.RadioButton()
        Me.optZDManual = New System.Windows.Forms.RadioButton()
        Me.txtLoDeg = New System.Windows.Forms.TextBox()
        Me.txtLoMin = New System.Windows.Forms.TextBox()
        Me.lblHsFormat = New System.Windows.Forms.Label()
        Me.lblHs = New System.Windows.Forms.Label()
        Me.lblHE = New System.Windows.Forms.Label()
        Me.lblIE = New System.Windows.Forms.Label()
        Me.lblDsDist = New System.Windows.Forms.Label()
        Me.lblZDAutoManual = New System.Windows.Forms.Label()
        Me.lblZD = New System.Windows.Forms.Label()
        Me.optHoParameters = New System.Windows.Forms.RadioButton()
        Me.DTNoonSight = New System.Windows.Forms.DateTimePicker()
        Me.txtCalcHo = New System.Windows.Forms.TextBox()
        Me.txtIESec = New System.Windows.Forms.TextBox()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.optStdTPNo = New System.Windows.Forms.RadioButton()
        Me.OptStdTPYes = New System.Windows.Forms.RadioButton()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.optDRL = New System.Windows.Forms.RadioButton()
        Me.optAzS = New System.Windows.Forms.RadioButton()
        Me.optAzN = New System.Windows.Forms.RadioButton()
        Me.cboDRL = New System.Windows.Forms.ComboBox()
        Me.lblLDeg = New System.Windows.Forms.Label()
        Me.lblLMin = New System.Windows.Forms.Label()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.optCenter = New System.Windows.Forms.RadioButton()
        Me.optUpper = New System.Windows.Forms.RadioButton()
        Me.optLower = New System.Windows.Forms.RadioButton()
        Me.cmdNoonSight = New System.Windows.Forms.Button()
        Me.cboHE = New System.Windows.Forms.ComboBox()
        Me.cboIE = New System.Windows.Forms.ComboBox()
        Me.cboTemperature = New System.Windows.Forms.ComboBox()
        Me.cboPressure = New System.Windows.Forms.ComboBox()
        Me.Framehs = New System.Windows.Forms.Panel()
        Me.optHsDMm = New System.Windows.Forms.RadioButton()
        Me.optHsDMS = New System.Windows.Forms.RadioButton()
        Me.FrameHorizon = New System.Windows.Forms.Panel()
        Me.optHorizonBubble = New System.Windows.Forms.RadioButton()
        Me.optHorizonNatural = New System.Windows.Forms.RadioButton()
        Me.optHorizonArtificial = New System.Windows.Forms.RadioButton()
        Me.optHorizonDipShort = New System.Windows.Forms.RadioButton()
        Me.cboDsUnit = New System.Windows.Forms.ComboBox()
        Me.cmdLAN = New System.Windows.Forms.Button()
        Me.FrameZD = New System.Windows.Forms.Panel()
        Me.optZDUT = New System.Windows.Forms.RadioButton()
        Me.cboZDm = New System.Windows.Forms.ComboBox()
        Me.cboLo = New System.Windows.Forms.ComboBox()
        Me.lblHoCorrs = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblZDDST = New System.Windows.Forms.Label()
        Me.lblS = New System.Windows.Forms.Label()
        Me.lblZ = New System.Windows.Forms.Label()
        Me.lblN = New System.Windows.Forms.Label()
        Me.lblHsDeg = New System.Windows.Forms.Label()
        Me.lblHsMin = New System.Windows.Forms.Label()
        Me.lblHsSec = New System.Windows.Forms.Label()
        Me.lblIEMin = New System.Windows.Forms.Label()
        Me.lblStdT_P = New System.Windows.Forms.Label()
        Me.lblTemperature = New System.Windows.Forms.Label()
        Me.lblTempDeg = New System.Windows.Forms.Label()
        Me.lblPressure = New System.Windows.Forms.Label()
        Me.lblHorizon = New System.Windows.Forms.Label()
        Me.lblIEdeg = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblZDh = New System.Windows.Forms.Label()
        Me.lblZDm = New System.Windows.Forms.Label()
        Me.lblDRLo = New System.Windows.Forms.Label()
        Me.lblLoDeg = New System.Windows.Forms.Label()
        Me.lblLoMin = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.AltitudeTxtBx = New System.Windows.Forms.TextBox()
        Me.LatitudeTxtBx = New System.Windows.Forms.TextBox()
        Me.LANTimeTxtBx = New System.Windows.Forms.TextBox()
        Me.LongitudeCalcTxtBx = New System.Windows.Forms.TextBox()
        Me.ExitNoonSight = New System.Windows.Forms.Button()
        Me.ClearScrBtn = New System.Windows.Forms.Button()
        Me.OldFormBtn = New System.Windows.Forms.RadioButton()
        Me.NewFormBtn = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblIEsec = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MeridianPicBx = New System.Windows.Forms.PictureBox()
        Me.btnDisplayEQTData = New System.Windows.Forms.Button()
        Me.DGLAN = New System.Windows.Forms.DataGridView()
        Me.DGAlt = New System.Windows.Forms.DataGridView()
        Me.AlmanacTxtBx = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGAlm = New System.Windows.Forms.DataGridView()
        Me.DGLat = New System.Windows.Forms.DataGridView()
        Me.txtUserInfo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtZTLANWarn = New System.Windows.Forms.TextBox()
        Me.Frame2.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.Framehs.SuspendLayout()
        Me.FrameHorizon.SuspendLayout()
        Me.FrameZD.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MeridianPicBx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGLAN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGAlt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGAlm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGLat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'optHoSRForm
        '
        Me.optHoSRForm.BackColor = System.Drawing.SystemColors.Window
        Me.optHoSRForm.Checked = True
        Me.optHoSRForm.Cursor = System.Windows.Forms.Cursors.Default
        Me.optHoSRForm.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optHoSRForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optHoSRForm.Location = New System.Drawing.Point(553, 181)
        Me.optHoSRForm.Name = "optHoSRForm"
        Me.optHoSRForm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optHoSRForm.Size = New System.Drawing.Size(66, 15)
        Me.optHoSRForm.TabIndex = 88
        Me.optHoSRForm.TabStop = True
        Me.optHoSRForm.Text = "SR Form"
        Me.ToolTip1.SetToolTip(Me.optHoSRForm, "Main, Add'l, etc.")
        Me.optHoSRForm.UseVisualStyleBackColor = False
        '
        'txtTime
        '
        Me.txtTime.AcceptsReturn = True
        Me.txtTime.BackColor = System.Drawing.SystemColors.Window
        Me.txtTime.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTime.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTime.Location = New System.Drawing.Point(164, 579)
        Me.txtTime.MaxLength = 6
        Me.txtTime.Name = "txtTime"
        Me.txtTime.ReadOnly = True
        Me.txtTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTime.Size = New System.Drawing.Size(77, 20)
        Me.txtTime.TabIndex = 81
        Me.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtTime, "Range 111328 to 124427 (121328 to 134427 if DST) for Auto ZD")
        '
        'chkDST
        '
        Me.chkDST.BackColor = System.Drawing.SystemColors.Window
        Me.chkDST.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkDST.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDST.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkDST.Location = New System.Drawing.Point(156, 172)
        Me.chkDST.Name = "chkDST"
        Me.chkDST.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkDST.Size = New System.Drawing.Size(17, 14)
        Me.chkDST.TabIndex = 79
        Me.chkDST.Text = "Check1"
        Me.ToolTip1.SetToolTip(Me.chkDST, "Check if Dayslight Saving is in effect")
        Me.chkDST.UseVisualStyleBackColor = False
        '
        'txtDRLMin
        '
        Me.txtDRLMin.AcceptsReturn = True
        Me.txtDRLMin.BackColor = System.Drawing.SystemColors.Window
        Me.txtDRLMin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDRLMin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDRLMin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDRLMin.Location = New System.Drawing.Point(136, 60)
        Me.txtDRLMin.MaxLength = 4
        Me.txtDRLMin.Name = "txtDRLMin"
        Me.txtDRLMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDRLMin.Size = New System.Drawing.Size(33, 20)
        Me.txtDRLMin.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.txtDRLMin, "Range 0 to 59.9")
        '
        'txtDRLDeg
        '
        Me.txtDRLDeg.AcceptsReturn = True
        Me.txtDRLDeg.BackColor = System.Drawing.SystemColors.Window
        Me.txtDRLDeg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDRLDeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDRLDeg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDRLDeg.Location = New System.Drawing.Point(89, 60)
        Me.txtDRLDeg.MaxLength = 2
        Me.txtDRLDeg.Name = "txtDRLDeg"
        Me.txtDRLDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDRLDeg.Size = New System.Drawing.Size(33, 20)
        Me.txtDRLDeg.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.txtDRLDeg, "Range 0 to 90")
        '
        'txtHsDeg
        '
        Me.txtHsDeg.AcceptsReturn = True
        Me.txtHsDeg.BackColor = System.Drawing.SystemColors.Window
        Me.txtHsDeg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHsDeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHsDeg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHsDeg.Location = New System.Drawing.Point(262, 122)
        Me.txtHsDeg.MaxLength = 3
        Me.txtHsDeg.Name = "txtHsDeg"
        Me.txtHsDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHsDeg.Size = New System.Drawing.Size(28, 20)
        Me.txtHsDeg.TabIndex = 32
        Me.ToolTip1.SetToolTip(Me.txtHsDeg, "Range 0 to 145")
        '
        'txtHsMin
        '
        Me.txtHsMin.AcceptsReturn = True
        Me.txtHsMin.BackColor = System.Drawing.SystemColors.Window
        Me.txtHsMin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHsMin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHsMin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHsMin.Location = New System.Drawing.Point(297, 122)
        Me.txtHsMin.MaxLength = 4
        Me.txtHsMin.Name = "txtHsMin"
        Me.txtHsMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHsMin.Size = New System.Drawing.Size(33, 20)
        Me.txtHsMin.TabIndex = 33
        Me.ToolTip1.SetToolTip(Me.txtHsMin, "Range 0 to 59.9 (DM.m) or 59 (DMS)")
        '
        'txtHsSec
        '
        Me.txtHsSec.AcceptsReturn = True
        Me.txtHsSec.BackColor = System.Drawing.SystemColors.Window
        Me.txtHsSec.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHsSec.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHsSec.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHsSec.Location = New System.Drawing.Point(337, 122)
        Me.txtHsSec.MaxLength = 2
        Me.txtHsSec.Name = "txtHsSec"
        Me.txtHsSec.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHsSec.Size = New System.Drawing.Size(33, 20)
        Me.txtHsSec.TabIndex = 34
        Me.ToolTip1.SetToolTip(Me.txtHsSec, "Range 0 to 59")
        Me.txtHsSec.Visible = False
        '
        'txtHE
        '
        Me.txtHE.AcceptsReturn = True
        Me.txtHE.BackColor = System.Drawing.SystemColors.Window
        Me.txtHE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHE.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHE.Location = New System.Drawing.Point(332, 219)
        Me.txtHE.MaxLength = 4
        Me.txtHE.Name = "txtHE"
        Me.txtHE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHE.Size = New System.Drawing.Size(33, 20)
        Me.txtHE.TabIndex = 42
        Me.ToolTip1.SetToolTip(Me.txtHE, "Max. 4 characters")
        '
        'txtIEmin
        '
        Me.txtIEmin.AcceptsReturn = True
        Me.txtIEmin.BackColor = System.Drawing.SystemColors.Window
        Me.txtIEmin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIEmin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIEmin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtIEmin.Location = New System.Drawing.Point(297, 145)
        Me.txtIEmin.MaxLength = 4
        Me.txtIEmin.Name = "txtIEmin"
        Me.txtIEmin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtIEmin.Size = New System.Drawing.Size(33, 20)
        Me.txtIEmin.TabIndex = 36
        Me.ToolTip1.SetToolTip(Me.txtIEmin, "Range 0 to 59.9 (DM.m) or 59 (DMS)")
        '
        'txtTemperature
        '
        Me.txtTemperature.AcceptsReturn = True
        Me.txtTemperature.BackColor = System.Drawing.SystemColors.Window
        Me.txtTemperature.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTemperature.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTemperature.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTemperature.Location = New System.Drawing.Point(595, 105)
        Me.txtTemperature.MaxLength = 4
        Me.txtTemperature.Name = "txtTemperature"
        Me.txtTemperature.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTemperature.Size = New System.Drawing.Size(33, 20)
        Me.txtTemperature.TabIndex = 46
        Me.txtTemperature.Text = "50"
        Me.ToolTip1.SetToolTip(Me.txtTemperature, "Range -40 to 130 (F) or -40 to 55 (C)")
        Me.txtTemperature.Visible = False
        '
        'txtPressure
        '
        Me.txtPressure.AcceptsReturn = True
        Me.txtPressure.BackColor = System.Drawing.SystemColors.Window
        Me.txtPressure.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPressure.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPressure.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPressure.Location = New System.Drawing.Point(594, 132)
        Me.txtPressure.MaxLength = 5
        Me.txtPressure.Name = "txtPressure"
        Me.txtPressure.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPressure.Size = New System.Drawing.Size(41, 20)
        Me.txtPressure.TabIndex = 48
        Me.txtPressure.Text = "29.83"
        Me.ToolTip1.SetToolTip(Me.txtPressure, "Range 28 to 32 (in Hg) or 950 to 1100 (mb)")
        Me.txtPressure.Visible = False
        '
        'txtDsDist
        '
        Me.txtDsDist.AcceptsReturn = True
        Me.txtDsDist.BackColor = System.Drawing.SystemColors.Window
        Me.txtDsDist.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDsDist.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDsDist.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDsDist.Location = New System.Drawing.Point(332, 243)
        Me.txtDsDist.MaxLength = 5
        Me.txtDsDist.Name = "txtDsDist"
        Me.txtDsDist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDsDist.Size = New System.Drawing.Size(41, 20)
        Me.txtDsDist.TabIndex = 44
        Me.ToolTip1.SetToolTip(Me.txtDsDist, "Limited to five characters")
        Me.txtDsDist.Visible = False
        '
        'txtIEdeg
        '
        Me.txtIEdeg.AcceptsReturn = True
        Me.txtIEdeg.BackColor = System.Drawing.SystemColors.Window
        Me.txtIEdeg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIEdeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIEdeg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtIEdeg.Location = New System.Drawing.Point(262, 145)
        Me.txtIEdeg.MaxLength = 1
        Me.txtIEdeg.Name = "txtIEdeg"
        Me.txtIEdeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtIEdeg.Size = New System.Drawing.Size(28, 20)
        Me.txtIEdeg.TabIndex = 35
        Me.ToolTip1.SetToolTip(Me.txtIEdeg, "Range 0 to 9; to right of index mark")
        '
        'txtZDh
        '
        Me.txtZDh.AcceptsReturn = True
        Me.txtZDh.BackColor = System.Drawing.SystemColors.Window
        Me.txtZDh.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtZDh.Enabled = False
        Me.txtZDh.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZDh.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtZDh.Location = New System.Drawing.Point(37, 168)
        Me.txtZDh.MaxLength = 3
        Me.txtZDh.Name = "txtZDh"
        Me.txtZDh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtZDh.Size = New System.Drawing.Size(25, 20)
        Me.txtZDh.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.txtZDh, "Range -14 to +12.  Lo E is -.")
        '
        'optZDAuto
        '
        Me.optZDAuto.BackColor = System.Drawing.SystemColors.Window
        Me.optZDAuto.Checked = True
        Me.optZDAuto.Cursor = System.Windows.Forms.Cursors.Default
        Me.optZDAuto.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optZDAuto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optZDAuto.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.optZDAuto.Location = New System.Drawing.Point(3, 1)
        Me.optZDAuto.Name = "optZDAuto"
        Me.optZDAuto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optZDAuto.Size = New System.Drawing.Size(49, 19)
        Me.optZDAuto.TabIndex = 15
        Me.optZDAuto.TabStop = True
        Me.optZDAuto.Text = "Auto"
        Me.ToolTip1.SetToolTip(Me.optZDAuto, "ZD based on longitude alone")
        Me.optZDAuto.UseVisualStyleBackColor = False
        '
        'optZDManual
        '
        Me.optZDManual.BackColor = System.Drawing.SystemColors.Window
        Me.optZDManual.Cursor = System.Windows.Forms.Cursors.Default
        Me.optZDManual.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optZDManual.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optZDManual.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.optZDManual.Location = New System.Drawing.Point(56, 1)
        Me.optZDManual.Name = "optZDManual"
        Me.optZDManual.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optZDManual.Size = New System.Drawing.Size(65, 19)
        Me.optZDManual.TabIndex = 16
        Me.optZDManual.TabStop = True
        Me.optZDManual.Text = "Manual"
        Me.ToolTip1.SetToolTip(Me.optZDManual, "ZD can be set for civil standard time zone")
        Me.optZDManual.UseVisualStyleBackColor = False
        '
        'txtLoDeg
        '
        Me.txtLoDeg.AcceptsReturn = True
        Me.txtLoDeg.BackColor = System.Drawing.SystemColors.Window
        Me.txtLoDeg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLoDeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoDeg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLoDeg.Location = New System.Drawing.Point(90, 93)
        Me.txtLoDeg.MaxLength = 3
        Me.txtLoDeg.Name = "txtLoDeg"
        Me.txtLoDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLoDeg.Size = New System.Drawing.Size(33, 20)
        Me.txtLoDeg.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.txtLoDeg, "Range 0 to 180")
        '
        'txtLoMin
        '
        Me.txtLoMin.AcceptsReturn = True
        Me.txtLoMin.BackColor = System.Drawing.SystemColors.Window
        Me.txtLoMin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLoMin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoMin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLoMin.Location = New System.Drawing.Point(135, 93)
        Me.txtLoMin.MaxLength = 4
        Me.txtLoMin.Name = "txtLoMin"
        Me.txtLoMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLoMin.Size = New System.Drawing.Size(33, 20)
        Me.txtLoMin.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.txtLoMin, "Range 0 to 59.9")
        '
        'lblHsFormat
        '
        Me.lblHsFormat.BackColor = System.Drawing.SystemColors.Window
        Me.lblHsFormat.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHsFormat.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHsFormat.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHsFormat.Location = New System.Drawing.Point(485, 51)
        Me.lblHsFormat.Name = "lblHsFormat"
        Me.lblHsFormat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblHsFormat.Size = New System.Drawing.Size(73, 13)
        Me.lblHsFormat.TabIndex = 71
        Me.lblHsFormat.Text = "hs/IE format"
        Me.ToolTip1.SetToolTip(Me.lblHsFormat, "Sextant Altitude/Index Error format")
        '
        'lblHs
        '
        Me.lblHs.BackColor = System.Drawing.SystemColors.Window
        Me.lblHs.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHs.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHs.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHs.Location = New System.Drawing.Point(233, 125)
        Me.lblHs.Name = "lblHs"
        Me.lblHs.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblHs.Size = New System.Drawing.Size(19, 13)
        Me.lblHs.TabIndex = 70
        Me.lblHs.Text = "hs"
        Me.ToolTip1.SetToolTip(Me.lblHs, "Sextant Altitude")
        '
        'lblHE
        '
        Me.lblHE.BackColor = System.Drawing.SystemColors.Window
        Me.lblHE.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHE.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHE.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHE.Location = New System.Drawing.Point(233, 223)
        Me.lblHE.Name = "lblHE"
        Me.lblHE.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblHE.Size = New System.Drawing.Size(82, 16)
        Me.lblHE.TabIndex = 66
        Me.lblHE.Text = "Height of Eye"
        Me.lblHE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.lblHE, "Height of Eye")
        '
        'lblIE
        '
        Me.lblIE.BackColor = System.Drawing.SystemColors.Window
        Me.lblIE.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblIE.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIE.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblIE.Location = New System.Drawing.Point(233, 148)
        Me.lblIE.Name = "lblIE"
        Me.lblIE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblIE.Size = New System.Drawing.Size(17, 17)
        Me.lblIE.TabIndex = 65
        Me.lblIE.Text = "IE"
        Me.ToolTip1.SetToolTip(Me.lblIE, "Index Error")
        '
        'lblDsDist
        '
        Me.lblDsDist.BackColor = System.Drawing.SystemColors.Window
        Me.lblDsDist.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDsDist.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDsDist.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDsDist.Location = New System.Drawing.Point(233, 244)
        Me.lblDsDist.Name = "lblDsDist"
        Me.lblDsDist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDsDist.Size = New System.Drawing.Size(97, 18)
        Me.lblDsDist.TabIndex = 58
        Me.lblDsDist.Text = "Dip Short distance"
        Me.lblDsDist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblDsDist, "Distance to dip short horizon")
        Me.lblDsDist.Visible = False
        '
        'lblZDAutoManual
        '
        Me.lblZDAutoManual.BackColor = System.Drawing.SystemColors.Window
        Me.lblZDAutoManual.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblZDAutoManual.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZDAutoManual.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblZDAutoManual.Location = New System.Drawing.Point(13, 143)
        Me.lblZDAutoManual.Name = "lblZDAutoManual"
        Me.lblZDAutoManual.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblZDAutoManual.Size = New System.Drawing.Size(22, 13)
        Me.lblZDAutoManual.TabIndex = 14
        Me.lblZDAutoManual.Text = "ZD"
        Me.ToolTip1.SetToolTip(Me.lblZDAutoManual, "Zone Description ")
        '
        'lblZD
        '
        Me.lblZD.BackColor = System.Drawing.SystemColors.Window
        Me.lblZD.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblZD.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZD.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblZD.Location = New System.Drawing.Point(13, 172)
        Me.lblZD.Name = "lblZD"
        Me.lblZD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblZD.Size = New System.Drawing.Size(22, 13)
        Me.lblZD.TabIndex = 54
        Me.lblZD.Text = "ZD"
        Me.ToolTip1.SetToolTip(Me.lblZD, "Zone Description")
        '
        'optHoParameters
        '
        Me.optHoParameters.BackColor = System.Drawing.SystemColors.Window
        Me.optHoParameters.Cursor = System.Windows.Forms.Cursors.Default
        Me.optHoParameters.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optHoParameters.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optHoParameters.Location = New System.Drawing.Point(628, 181)
        Me.optHoParameters.Name = "optHoParameters"
        Me.optHoParameters.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optHoParameters.Size = New System.Drawing.Size(80, 15)
        Me.optHoParameters.TabIndex = 87
        Me.optHoParameters.Text = "Parameters"
        Me.ToolTip1.SetToolTip(Me.optHoParameters, "Refraction, parallax, etc.")
        Me.optHoParameters.UseVisualStyleBackColor = False
        '
        'DTNoonSight
        '
        Me.DTNoonSight.CustomFormat = "MM/dd/yyyy HH:mm:ss "
        Me.DTNoonSight.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DTNoonSight.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTNoonSight.Location = New System.Drawing.Point(77, 26)
        Me.DTNoonSight.Name = "DTNoonSight"
        Me.DTNoonSight.ShowUpDown = True
        Me.DTNoonSight.Size = New System.Drawing.Size(148, 21)
        Me.DTNoonSight.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.DTNoonSight, resources.GetString("DTNoonSight.ToolTip"))
        '
        'txtCalcHo
        '
        Me.txtCalcHo.AcceptsReturn = True
        Me.txtCalcHo.BackColor = System.Drawing.SystemColors.Window
        Me.txtCalcHo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCalcHo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCalcHo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCalcHo.Location = New System.Drawing.Point(164, 610)
        Me.txtCalcHo.MaxLength = 6
        Me.txtCalcHo.Name = "txtCalcHo"
        Me.txtCalcHo.ReadOnly = True
        Me.txtCalcHo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCalcHo.Size = New System.Drawing.Size(77, 20)
        Me.txtCalcHo.TabIndex = 117
        Me.txtCalcHo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtCalcHo, "Range 111328 to 124427 (121328 to 134427 if DST) for Auto ZD")
        '
        'txtIESec
        '
        Me.txtIESec.AcceptsReturn = True
        Me.txtIESec.BackColor = System.Drawing.SystemColors.Window
        Me.txtIESec.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIESec.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIESec.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtIESec.Location = New System.Drawing.Point(338, 145)
        Me.txtIESec.MaxLength = 0
        Me.txtIESec.Name = "txtIESec"
        Me.txtIESec.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtIESec.Size = New System.Drawing.Size(33, 20)
        Me.txtIESec.TabIndex = 37
        Me.ToolTip1.SetToolTip(Me.txtIESec, "Range 0 to 59")
        Me.txtIESec.Visible = False
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrint.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.Location = New System.Drawing.Point(694, 0)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrint.Size = New System.Drawing.Size(21, 21)
        Me.cmdPrint.TabIndex = 74
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdPrint, "Print window")
        Me.cmdPrint.UseVisualStyleBackColor = False
        '
        'optStdTPNo
        '
        Me.optStdTPNo.BackColor = System.Drawing.SystemColors.Window
        Me.optStdTPNo.Cursor = System.Windows.Forms.Cursors.Default
        Me.optStdTPNo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optStdTPNo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optStdTPNo.Location = New System.Drawing.Point(658, 80)
        Me.optStdTPNo.Name = "optStdTPNo"
        Me.optStdTPNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optStdTPNo.Size = New System.Drawing.Size(45, 15)
        Me.optStdTPNo.TabIndex = 85
        Me.optStdTPNo.TabStop = True
        Me.optStdTPNo.Text = "No"
        Me.optStdTPNo.UseVisualStyleBackColor = False
        '
        'OptStdTPYes
        '
        Me.OptStdTPYes.BackColor = System.Drawing.SystemColors.Window
        Me.OptStdTPYes.Checked = True
        Me.OptStdTPYes.Cursor = System.Windows.Forms.Cursors.Default
        Me.OptStdTPYes.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptStdTPYes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OptStdTPYes.Location = New System.Drawing.Point(603, 80)
        Me.OptStdTPYes.Name = "OptStdTPYes"
        Me.OptStdTPYes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OptStdTPYes.Size = New System.Drawing.Size(45, 15)
        Me.OptStdTPYes.TabIndex = 84
        Me.OptStdTPYes.TabStop = True
        Me.OptStdTPYes.Text = "Yes"
        Me.OptStdTPYes.UseVisualStyleBackColor = False
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Window
        Me.Frame2.Controls.Add(Me.optDRL)
        Me.Frame2.Controls.Add(Me.optAzS)
        Me.Frame2.Controls.Add(Me.optAzN)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(236, 52)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(209, 68)
        Me.Frame2.TabIndex = 73
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "At LAN (select one)"
        '
        'optDRL
        '
        Me.optDRL.BackColor = System.Drawing.SystemColors.Window
        Me.optDRL.Checked = True
        Me.optDRL.Cursor = System.Windows.Forms.Cursors.Default
        Me.optDRL.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optDRL.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optDRL.Location = New System.Drawing.Point(8, 46)
        Me.optDRL.Name = "optDRL"
        Me.optDRL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optDRL.Size = New System.Drawing.Size(120, 20)
        Me.optDRL.TabIndex = 22
        Me.optDRL.TabStop = True
        Me.optDRL.Text = "Use DR Latitude"
        Me.optDRL.UseVisualStyleBackColor = False
        '
        'optAzS
        '
        Me.optAzS.BackColor = System.Drawing.SystemColors.Window
        Me.optAzS.Cursor = System.Windows.Forms.Cursors.Default
        Me.optAzS.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optAzS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optAzS.Location = New System.Drawing.Point(8, 30)
        Me.optAzS.Name = "optAzS"
        Me.optAzS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optAzS.Size = New System.Drawing.Size(146, 15)
        Me.optAzS.TabIndex = 21
        Me.optAzS.TabStop = True
        Me.optAzS.Text = "sun was to south"
        Me.optAzS.UseVisualStyleBackColor = False
        '
        'optAzN
        '
        Me.optAzN.BackColor = System.Drawing.SystemColors.Window
        Me.optAzN.Cursor = System.Windows.Forms.Cursors.Default
        Me.optAzN.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optAzN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optAzN.Location = New System.Drawing.Point(8, 12)
        Me.optAzN.Name = "optAzN"
        Me.optAzN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optAzN.Size = New System.Drawing.Size(145, 15)
        Me.optAzN.TabIndex = 20
        Me.optAzN.TabStop = True
        Me.optAzN.Text = "sun was to north"
        Me.optAzN.UseVisualStyleBackColor = False
        '
        'cboDRL
        '
        Me.cboDRL.BackColor = System.Drawing.SystemColors.Window
        Me.cboDRL.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboDRL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDRL.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDRL.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboDRL.Items.AddRange(New Object() {"N", "S"})
        Me.cboDRL.Location = New System.Drawing.Point(182, 60)
        Me.cboDRL.Name = "cboDRL"
        Me.cboDRL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboDRL.Size = New System.Drawing.Size(41, 22)
        Me.cboDRL.TabIndex = 6
        '
        'lblLDeg
        '
        Me.lblLDeg.BackColor = System.Drawing.SystemColors.Window
        Me.lblLDeg.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLDeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLDeg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLDeg.Location = New System.Drawing.Point(123, 60)
        Me.lblLDeg.Name = "lblLDeg"
        Me.lblLDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLDeg.Size = New System.Drawing.Size(9, 17)
        Me.lblLDeg.TabIndex = 24
        Me.lblLDeg.Text = "°"
        '
        'lblLMin
        '
        Me.lblLMin.BackColor = System.Drawing.SystemColors.Window
        Me.lblLMin.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLMin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLMin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLMin.Location = New System.Drawing.Point(169, 59)
        Me.lblLMin.Name = "lblLMin"
        Me.lblLMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLMin.Size = New System.Drawing.Size(9, 17)
        Me.lblLMin.TabIndex = 26
        Me.lblLMin.Text = "'"
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Window
        Me.Frame1.Controls.Add(Me.optCenter)
        Me.Frame1.Controls.Add(Me.optUpper)
        Me.Frame1.Controls.Add(Me.optLower)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(236, 20)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(240, 30)
        Me.Frame1.TabIndex = 72
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Sun Limb"
        '
        'optCenter
        '
        Me.optCenter.BackColor = System.Drawing.SystemColors.Window
        Me.optCenter.Cursor = System.Windows.Forms.Cursors.Default
        Me.optCenter.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optCenter.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optCenter.Location = New System.Drawing.Point(175, 8)
        Me.optCenter.Name = "optCenter"
        Me.optCenter.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optCenter.Size = New System.Drawing.Size(59, 19)
        Me.optCenter.TabIndex = 90
        Me.optCenter.TabStop = True
        Me.optCenter.Text = "Center"
        Me.optCenter.UseVisualStyleBackColor = False
        '
        'optUpper
        '
        Me.optUpper.BackColor = System.Drawing.SystemColors.Window
        Me.optUpper.Cursor = System.Windows.Forms.Cursors.Default
        Me.optUpper.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optUpper.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optUpper.Location = New System.Drawing.Point(112, 8)
        Me.optUpper.Name = "optUpper"
        Me.optUpper.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optUpper.Size = New System.Drawing.Size(57, 17)
        Me.optUpper.TabIndex = 29
        Me.optUpper.TabStop = True
        Me.optUpper.Text = "Upper"
        Me.optUpper.UseVisualStyleBackColor = False
        '
        'optLower
        '
        Me.optLower.BackColor = System.Drawing.SystemColors.Window
        Me.optLower.Checked = True
        Me.optLower.Cursor = System.Windows.Forms.Cursors.Default
        Me.optLower.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optLower.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optLower.Location = New System.Drawing.Point(55, 8)
        Me.optLower.Name = "optLower"
        Me.optLower.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optLower.Size = New System.Drawing.Size(58, 17)
        Me.optLower.TabIndex = 28
        Me.optLower.TabStop = True
        Me.optLower.Text = "Lower"
        Me.optLower.UseVisualStyleBackColor = False
        '
        'cmdNoonSight
        '
        Me.cmdNoonSight.BackColor = System.Drawing.SystemColors.Control
        Me.cmdNoonSight.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdNoonSight.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNoonSight.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdNoonSight.Location = New System.Drawing.Point(260, 270)
        Me.cmdNoonSight.Name = "cmdNoonSight"
        Me.cmdNoonSight.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdNoonSight.Size = New System.Drawing.Size(210, 25)
        Me.cmdNoonSight.TabIndex = 50
        Me.cmdNoonSight.Text = "Evaluate Noon Sight"
        Me.cmdNoonSight.UseVisualStyleBackColor = False
        Me.cmdNoonSight.Visible = False
        '
        'cboHE
        '
        Me.cboHE.BackColor = System.Drawing.SystemColors.Window
        Me.cboHE.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboHE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHE.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboHE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboHE.Items.AddRange(New Object() {"ft", "in", "m ", "cm"})
        Me.cboHE.Location = New System.Drawing.Point(378, 219)
        Me.cboHE.Name = "cboHE"
        Me.cboHE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboHE.Size = New System.Drawing.Size(41, 22)
        Me.cboHE.TabIndex = 43
        '
        'cboIE
        '
        Me.cboIE.BackColor = System.Drawing.SystemColors.Window
        Me.cboIE.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboIE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboIE.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboIE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboIE.Items.AddRange(New Object() {"on the arc", "off the arc (val.)", "off the arc (rdg.)"})
        Me.cboIE.Location = New System.Drawing.Point(379, 143)
        Me.cboIE.Name = "cboIE"
        Me.cboIE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboIE.Size = New System.Drawing.Size(105, 22)
        Me.cboIE.TabIndex = 38
        '
        'cboTemperature
        '
        Me.cboTemperature.BackColor = System.Drawing.SystemColors.Window
        Me.cboTemperature.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboTemperature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTemperature.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTemperature.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboTemperature.Items.AddRange(New Object() {"F ", "C "})
        Me.cboTemperature.Location = New System.Drawing.Point(648, 105)
        Me.cboTemperature.Name = "cboTemperature"
        Me.cboTemperature.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboTemperature.Size = New System.Drawing.Size(33, 22)
        Me.cboTemperature.TabIndex = 47
        Me.cboTemperature.Visible = False
        '
        'cboPressure
        '
        Me.cboPressure.BackColor = System.Drawing.SystemColors.Window
        Me.cboPressure.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboPressure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPressure.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPressure.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboPressure.Items.AddRange(New Object() {"in Hg", "mbar"})
        Me.cboPressure.Location = New System.Drawing.Point(647, 132)
        Me.cboPressure.Name = "cboPressure"
        Me.cboPressure.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboPressure.Size = New System.Drawing.Size(57, 22)
        Me.cboPressure.TabIndex = 49
        Me.cboPressure.Visible = False
        '
        'Framehs
        '
        Me.Framehs.BackColor = System.Drawing.SystemColors.Window
        Me.Framehs.Controls.Add(Me.optHsDMm)
        Me.Framehs.Controls.Add(Me.optHsDMS)
        Me.Framehs.Cursor = System.Windows.Forms.Cursors.Default
        Me.Framehs.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Framehs.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Framehs.Location = New System.Drawing.Point(549, 49)
        Me.Framehs.Name = "Framehs"
        Me.Framehs.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Framehs.Size = New System.Drawing.Size(145, 22)
        Me.Framehs.TabIndex = 56
        Me.Framehs.Text = "Frame2"
        '
        'optHsDMm
        '
        Me.optHsDMm.BackColor = System.Drawing.SystemColors.Window
        Me.optHsDMm.Checked = True
        Me.optHsDMm.Cursor = System.Windows.Forms.Cursors.Default
        Me.optHsDMm.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optHsDMm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optHsDMm.Location = New System.Drawing.Point(8, 4)
        Me.optHsDMm.Name = "optHsDMm"
        Me.optHsDMm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optHsDMm.Size = New System.Drawing.Size(58, 15)
        Me.optHsDMm.TabIndex = 30
        Me.optHsDMm.TabStop = True
        Me.optHsDMm.Text = "DM.m"
        Me.optHsDMm.UseVisualStyleBackColor = False
        '
        'optHsDMS
        '
        Me.optHsDMS.BackColor = System.Drawing.SystemColors.Window
        Me.optHsDMS.Cursor = System.Windows.Forms.Cursors.Default
        Me.optHsDMS.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optHsDMS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optHsDMS.Location = New System.Drawing.Point(72, 4)
        Me.optHsDMS.Name = "optHsDMS"
        Me.optHsDMS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optHsDMS.Size = New System.Drawing.Size(58, 15)
        Me.optHsDMS.TabIndex = 31
        Me.optHsDMS.TabStop = True
        Me.optHsDMS.Text = "DMS"
        Me.optHsDMS.UseVisualStyleBackColor = False
        '
        'FrameHorizon
        '
        Me.FrameHorizon.BackColor = System.Drawing.SystemColors.Window
        Me.FrameHorizon.Controls.Add(Me.optHorizonBubble)
        Me.FrameHorizon.Controls.Add(Me.optHorizonNatural)
        Me.FrameHorizon.Controls.Add(Me.optHorizonArtificial)
        Me.FrameHorizon.Controls.Add(Me.optHorizonDipShort)
        Me.FrameHorizon.Cursor = System.Windows.Forms.Cursors.Default
        Me.FrameHorizon.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FrameHorizon.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FrameHorizon.Location = New System.Drawing.Point(332, 168)
        Me.FrameHorizon.Name = "FrameHorizon"
        Me.FrameHorizon.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FrameHorizon.Size = New System.Drawing.Size(133, 47)
        Me.FrameHorizon.TabIndex = 55
        Me.FrameHorizon.Text = "Frame4"
        '
        'optHorizonBubble
        '
        Me.optHorizonBubble.BackColor = System.Drawing.SystemColors.Window
        Me.optHorizonBubble.Cursor = System.Windows.Forms.Cursors.Default
        Me.optHorizonBubble.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optHorizonBubble.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optHorizonBubble.Location = New System.Drawing.Point(73, 25)
        Me.optHorizonBubble.Name = "optHorizonBubble"
        Me.optHorizonBubble.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optHorizonBubble.Size = New System.Drawing.Size(54, 18)
        Me.optHorizonBubble.TabIndex = 103
        Me.optHorizonBubble.TabStop = True
        Me.optHorizonBubble.Text = "Bubble"
        Me.optHorizonBubble.UseVisualStyleBackColor = False
        '
        'optHorizonNatural
        '
        Me.optHorizonNatural.BackColor = System.Drawing.SystemColors.Window
        Me.optHorizonNatural.Checked = True
        Me.optHorizonNatural.Cursor = System.Windows.Forms.Cursors.Default
        Me.optHorizonNatural.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optHorizonNatural.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optHorizonNatural.Location = New System.Drawing.Point(11, 2)
        Me.optHorizonNatural.Name = "optHorizonNatural"
        Me.optHorizonNatural.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optHorizonNatural.Size = New System.Drawing.Size(55, 18)
        Me.optHorizonNatural.TabIndex = 39
        Me.optHorizonNatural.TabStop = True
        Me.optHorizonNatural.Text = "Natural"
        Me.optHorizonNatural.UseVisualStyleBackColor = False
        '
        'optHorizonArtificial
        '
        Me.optHorizonArtificial.BackColor = System.Drawing.SystemColors.Window
        Me.optHorizonArtificial.Cursor = System.Windows.Forms.Cursors.Default
        Me.optHorizonArtificial.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optHorizonArtificial.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optHorizonArtificial.Location = New System.Drawing.Point(66, 2)
        Me.optHorizonArtificial.Name = "optHorizonArtificial"
        Me.optHorizonArtificial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optHorizonArtificial.Size = New System.Drawing.Size(63, 18)
        Me.optHorizonArtificial.TabIndex = 40
        Me.optHorizonArtificial.TabStop = True
        Me.optHorizonArtificial.Text = "Artificial"
        Me.optHorizonArtificial.UseVisualStyleBackColor = False
        '
        'optHorizonDipShort
        '
        Me.optHorizonDipShort.BackColor = System.Drawing.SystemColors.Window
        Me.optHorizonDipShort.Cursor = System.Windows.Forms.Cursors.Default
        Me.optHorizonDipShort.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optHorizonDipShort.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optHorizonDipShort.Location = New System.Drawing.Point(11, 25)
        Me.optHorizonDipShort.Name = "optHorizonDipShort"
        Me.optHorizonDipShort.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optHorizonDipShort.Size = New System.Drawing.Size(63, 18)
        Me.optHorizonDipShort.TabIndex = 41
        Me.optHorizonDipShort.TabStop = True
        Me.optHorizonDipShort.Text = "Dip Short"
        Me.optHorizonDipShort.UseVisualStyleBackColor = False
        '
        'cboDsUnit
        '
        Me.cboDsUnit.BackColor = System.Drawing.SystemColors.Window
        Me.cboDsUnit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboDsUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDsUnit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDsUnit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboDsUnit.Items.AddRange(New Object() {"feet", "yards", "meters", "statute miles", "nautical miles"})
        Me.cboDsUnit.Location = New System.Drawing.Point(378, 242)
        Me.cboDsUnit.Name = "cboDsUnit"
        Me.cboDsUnit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboDsUnit.Size = New System.Drawing.Size(89, 22)
        Me.cboDsUnit.TabIndex = 45
        Me.cboDsUnit.Visible = False
        '
        'cmdLAN
        '
        Me.cmdLAN.BackColor = System.Drawing.SystemColors.Control
        Me.cmdLAN.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLAN.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLAN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdLAN.Location = New System.Drawing.Point(18, 271)
        Me.cmdLAN.Name = "cmdLAN"
        Me.cmdLAN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdLAN.Size = New System.Drawing.Size(225, 25)
        Me.cmdLAN.TabIndex = 19
        Me.cmdLAN.Text = "Calculate Zone Time of LAN"
        Me.cmdLAN.UseVisualStyleBackColor = False
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
        Me.FrameZD.Location = New System.Drawing.Point(37, 138)
        Me.FrameZD.Name = "FrameZD"
        Me.FrameZD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FrameZD.Size = New System.Drawing.Size(190, 24)
        Me.FrameZD.TabIndex = 51
        Me.FrameZD.Text = "Frame1"
        '
        'optZDUT
        '
        Me.optZDUT.BackColor = System.Drawing.SystemColors.Window
        Me.optZDUT.Cursor = System.Windows.Forms.Cursors.Default
        Me.optZDUT.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optZDUT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optZDUT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.optZDUT.Location = New System.Drawing.Point(114, 2)
        Me.optZDUT.Name = "optZDUT"
        Me.optZDUT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optZDUT.Size = New System.Drawing.Size(73, 17)
        Me.optZDUT.TabIndex = 91
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
        Me.cboZDm.Location = New System.Drawing.Point(84, 168)
        Me.cboZDm.Name = "cboZDm"
        Me.cboZDm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboZDm.Size = New System.Drawing.Size(41, 22)
        Me.cboZDm.TabIndex = 18
        Me.cboZDm.Visible = False
        '
        'cboLo
        '
        Me.cboLo.BackColor = System.Drawing.SystemColors.Window
        Me.cboLo.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboLo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboLo.Items.AddRange(New Object() {"W", "E"})
        Me.cboLo.Location = New System.Drawing.Point(182, 93)
        Me.cboLo.Name = "cboLo"
        Me.cboLo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboLo.Size = New System.Drawing.Size(41, 22)
        Me.cboLo.TabIndex = 12
        '
        'lblHoCorrs
        '
        Me.lblHoCorrs.BackColor = System.Drawing.SystemColors.Window
        Me.lblHoCorrs.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHoCorrs.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoCorrs.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHoCorrs.Location = New System.Drawing.Point(489, 164)
        Me.lblHoCorrs.Name = "lblHoCorrs"
        Me.lblHoCorrs.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblHoCorrs.Size = New System.Drawing.Size(128, 13)
        Me.lblHoCorrs.TabIndex = 89
        Me.lblHoCorrs.Text = "Show Ho corrections as:"
        Me.lblHoCorrs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Window
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(18, 567)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(142, 42)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Calculated ZT of LAN  " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Incl Eqn of Time Factor"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblZDDST
        '
        Me.lblZDDST.BackColor = System.Drawing.SystemColors.Window
        Me.lblZDDST.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblZDDST.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZDDST.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblZDDST.Location = New System.Drawing.Point(173, 172)
        Me.lblZDDST.Name = "lblZDDST"
        Me.lblZDDST.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblZDDST.Size = New System.Drawing.Size(33, 13)
        Me.lblZDDST.TabIndex = 80
        Me.lblZDDST.Text = "DST"
        '
        'lblS
        '
        Me.lblS.BackColor = System.Drawing.Color.Transparent
        Me.lblS.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblS.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblS.Location = New System.Drawing.Point(699, 650)
        Me.lblS.Name = "lblS"
        Me.lblS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblS.Size = New System.Drawing.Size(9, 17)
        Me.lblS.TabIndex = 77
        Me.lblS.Text = "S"
        Me.lblS.Visible = False
        '
        'lblZ
        '
        Me.lblZ.BackColor = System.Drawing.Color.Transparent
        Me.lblZ.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblZ.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZ.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblZ.Location = New System.Drawing.Point(591, 533)
        Me.lblZ.Name = "lblZ"
        Me.lblZ.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblZ.Size = New System.Drawing.Size(9, 16)
        Me.lblZ.TabIndex = 76
        Me.lblZ.Text = "Z"
        Me.lblZ.Visible = False
        '
        'lblN
        '
        Me.lblN.BackColor = System.Drawing.Color.Transparent
        Me.lblN.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblN.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblN.Location = New System.Drawing.Point(484, 650)
        Me.lblN.Name = "lblN"
        Me.lblN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblN.Size = New System.Drawing.Size(9, 17)
        Me.lblN.TabIndex = 75
        Me.lblN.Text = "N"
        Me.lblN.Visible = False
        '
        'lblHsDeg
        '
        Me.lblHsDeg.BackColor = System.Drawing.SystemColors.Window
        Me.lblHsDeg.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHsDeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHsDeg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHsDeg.Location = New System.Drawing.Point(288, 122)
        Me.lblHsDeg.Name = "lblHsDeg"
        Me.lblHsDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblHsDeg.Size = New System.Drawing.Size(9, 17)
        Me.lblHsDeg.TabIndex = 69
        Me.lblHsDeg.Text = "°"
        '
        'lblHsMin
        '
        Me.lblHsMin.BackColor = System.Drawing.SystemColors.Window
        Me.lblHsMin.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHsMin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHsMin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHsMin.Location = New System.Drawing.Point(330, 122)
        Me.lblHsMin.Name = "lblHsMin"
        Me.lblHsMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblHsMin.Size = New System.Drawing.Size(9, 17)
        Me.lblHsMin.TabIndex = 68
        Me.lblHsMin.Text = "'"
        '
        'lblHsSec
        '
        Me.lblHsSec.BackColor = System.Drawing.SystemColors.Window
        Me.lblHsSec.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHsSec.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHsSec.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHsSec.Location = New System.Drawing.Point(370, 122)
        Me.lblHsSec.Name = "lblHsSec"
        Me.lblHsSec.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblHsSec.Size = New System.Drawing.Size(9, 17)
        Me.lblHsSec.TabIndex = 67
        Me.lblHsSec.Text = """"
        Me.lblHsSec.Visible = False
        '
        'lblIEMin
        '
        Me.lblIEMin.BackColor = System.Drawing.SystemColors.Window
        Me.lblIEMin.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblIEMin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIEMin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblIEMin.Location = New System.Drawing.Point(330, 145)
        Me.lblIEMin.Name = "lblIEMin"
        Me.lblIEMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblIEMin.Size = New System.Drawing.Size(9, 17)
        Me.lblIEMin.TabIndex = 64
        Me.lblIEMin.Text = "'"
        '
        'lblStdT_P
        '
        Me.lblStdT_P.BackColor = System.Drawing.SystemColors.Window
        Me.lblStdT_P.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblStdT_P.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStdT_P.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblStdT_P.Location = New System.Drawing.Point(489, 81)
        Me.lblStdT_P.Name = "lblStdT_P"
        Me.lblStdT_P.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblStdT_P.Size = New System.Drawing.Size(110, 13)
        Me.lblStdT_P.TabIndex = 63
        Me.lblStdT_P.Text = "Std. temp. and press."
        '
        'lblTemperature
        '
        Me.lblTemperature.BackColor = System.Drawing.SystemColors.Window
        Me.lblTemperature.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTemperature.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTemperature.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTemperature.Location = New System.Drawing.Point(489, 106)
        Me.lblTemperature.Name = "lblTemperature"
        Me.lblTemperature.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTemperature.Size = New System.Drawing.Size(86, 19)
        Me.lblTemperature.TabIndex = 62
        Me.lblTemperature.Text = "Temperature:"
        Me.lblTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTemperature.Visible = False
        '
        'lblTempDeg
        '
        Me.lblTempDeg.BackColor = System.Drawing.SystemColors.Window
        Me.lblTempDeg.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTempDeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTempDeg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTempDeg.Location = New System.Drawing.Point(628, 105)
        Me.lblTempDeg.Name = "lblTempDeg"
        Me.lblTempDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTempDeg.Size = New System.Drawing.Size(9, 17)
        Me.lblTempDeg.TabIndex = 61
        Me.lblTempDeg.Text = "°"
        Me.lblTempDeg.Visible = False
        '
        'lblPressure
        '
        Me.lblPressure.BackColor = System.Drawing.SystemColors.Window
        Me.lblPressure.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPressure.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPressure.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPressure.Location = New System.Drawing.Point(490, 130)
        Me.lblPressure.Name = "lblPressure"
        Me.lblPressure.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPressure.Size = New System.Drawing.Size(67, 22)
        Me.lblPressure.TabIndex = 60
        Me.lblPressure.Text = "Pressure"
        Me.lblPressure.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblPressure.Visible = False
        '
        'lblHorizon
        '
        Me.lblHorizon.BackColor = System.Drawing.SystemColors.Window
        Me.lblHorizon.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHorizon.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHorizon.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHorizon.Location = New System.Drawing.Point(231, 174)
        Me.lblHorizon.Name = "lblHorizon"
        Me.lblHorizon.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblHorizon.Size = New System.Drawing.Size(81, 17)
        Me.lblHorizon.TabIndex = 59
        Me.lblHorizon.Text = "Horizon Type"
        '
        'lblIEdeg
        '
        Me.lblIEdeg.BackColor = System.Drawing.SystemColors.Window
        Me.lblIEdeg.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblIEdeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIEdeg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblIEdeg.Location = New System.Drawing.Point(288, 145)
        Me.lblIEdeg.Name = "lblIEdeg"
        Me.lblIEdeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblIEdeg.Size = New System.Drawing.Size(9, 17)
        Me.lblIEdeg.TabIndex = 57
        Me.lblIEdeg.Text = "°"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(35, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(129, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Select ZD of timepiece:"
        '
        'lblZDh
        '
        Me.lblZDh.BackColor = System.Drawing.SystemColors.Window
        Me.lblZDh.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblZDh.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZDh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblZDh.Location = New System.Drawing.Point(62, 172)
        Me.lblZDh.Name = "lblZDh"
        Me.lblZDh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblZDh.Size = New System.Drawing.Size(20, 15)
        Me.lblZDh.TabIndex = 53
        Me.lblZDh.Text = "Hr"
        Me.lblZDh.Visible = False
        '
        'lblZDm
        '
        Me.lblZDm.BackColor = System.Drawing.SystemColors.Window
        Me.lblZDm.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblZDm.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZDm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblZDm.Location = New System.Drawing.Point(125, 172)
        Me.lblZDm.Name = "lblZDm"
        Me.lblZDm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblZDm.Size = New System.Drawing.Size(25, 15)
        Me.lblZDm.TabIndex = 52
        Me.lblZDm.Text = "Min"
        Me.lblZDm.Visible = False
        '
        'lblDRLo
        '
        Me.lblDRLo.BackColor = System.Drawing.SystemColors.Window
        Me.lblDRLo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDRLo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDRLo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDRLo.Location = New System.Drawing.Point(13, 96)
        Me.lblDRLo.Name = "lblDRLo"
        Me.lblDRLo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDRLo.Size = New System.Drawing.Size(80, 17)
        Me.lblDRLo.TabIndex = 7
        Me.lblDRLo.Text = "DR Longitude"
        Me.lblDRLo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLoDeg
        '
        Me.lblLoDeg.BackColor = System.Drawing.SystemColors.Window
        Me.lblLoDeg.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLoDeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoDeg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLoDeg.Location = New System.Drawing.Point(45, 93)
        Me.lblLoDeg.Name = "lblLoDeg"
        Me.lblLoDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLoDeg.Size = New System.Drawing.Size(9, 17)
        Me.lblLoDeg.TabIndex = 9
        Me.lblLoDeg.Text = "°"
        '
        'lblLoMin
        '
        Me.lblLoMin.BackColor = System.Drawing.SystemColors.Window
        Me.lblLoMin.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLoMin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoMin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLoMin.Location = New System.Drawing.Point(169, 93)
        Me.lblLoMin.Name = "lblLoMin"
        Me.lblLoMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLoMin.Size = New System.Drawing.Size(9, 17)
        Me.lblLoMin.TabIndex = 11
        Me.lblLoMin.Text = "'"
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.SystemColors.Window
        Me.lblDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDate.Location = New System.Drawing.Point(12, 25)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDate.Size = New System.Drawing.Size(71, 29)
        Me.lblDate.TabIndex = 0
        Me.lblDate.Text = "Sight Date " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "&& Time"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AltitudeTxtBx
        '
        Me.AltitudeTxtBx.BackColor = System.Drawing.SystemColors.Window
        Me.AltitudeTxtBx.Font = New System.Drawing.Font("Courier New", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AltitudeTxtBx.Location = New System.Drawing.Point(260, 298)
        Me.AltitudeTxtBx.Name = "AltitudeTxtBx"
        Me.AltitudeTxtBx.ReadOnly = True
        Me.AltitudeTxtBx.Size = New System.Drawing.Size(210, 20)
        Me.AltitudeTxtBx.TabIndex = 91
        Me.AltitudeTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LatitudeTxtBx
        '
        Me.LatitudeTxtBx.BackColor = System.Drawing.SystemColors.Window
        Me.LatitudeTxtBx.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LatitudeTxtBx.Location = New System.Drawing.Point(484, 299)
        Me.LatitudeTxtBx.Name = "LatitudeTxtBx"
        Me.LatitudeTxtBx.ReadOnly = True
        Me.LatitudeTxtBx.Size = New System.Drawing.Size(230, 20)
        Me.LatitudeTxtBx.TabIndex = 93
        Me.LatitudeTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LANTimeTxtBx
        '
        Me.LANTimeTxtBx.BackColor = System.Drawing.SystemColors.Window
        Me.LANTimeTxtBx.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LANTimeTxtBx.Location = New System.Drawing.Point(18, 299)
        Me.LANTimeTxtBx.Name = "LANTimeTxtBx"
        Me.LANTimeTxtBx.ReadOnly = True
        Me.LANTimeTxtBx.Size = New System.Drawing.Size(225, 20)
        Me.LANTimeTxtBx.TabIndex = 95
        Me.LANTimeTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LongitudeCalcTxtBx
        '
        Me.LongitudeCalcTxtBx.BackColor = System.Drawing.SystemColors.Window
        Me.LongitudeCalcTxtBx.Font = New System.Drawing.Font("Courier New", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LongitudeCalcTxtBx.Location = New System.Drawing.Point(259, 665)
        Me.LongitudeCalcTxtBx.Name = "LongitudeCalcTxtBx"
        Me.LongitudeCalcTxtBx.ReadOnly = True
        Me.LongitudeCalcTxtBx.Size = New System.Drawing.Size(455, 20)
        Me.LongitudeCalcTxtBx.TabIndex = 96
        Me.LongitudeCalcTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ExitNoonSight
        '
        Me.ExitNoonSight.BackColor = System.Drawing.Color.Red
        Me.ExitNoonSight.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExitNoonSight.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitNoonSight.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ExitNoonSight.Location = New System.Drawing.Point(638, 271)
        Me.ExitNoonSight.Name = "ExitNoonSight"
        Me.ExitNoonSight.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ExitNoonSight.Size = New System.Drawing.Size(75, 25)
        Me.ExitNoonSight.TabIndex = 97
        Me.ExitNoonSight.Text = "Exit"
        Me.ExitNoonSight.UseVisualStyleBackColor = False
        '
        'ClearScrBtn
        '
        Me.ClearScrBtn.BackColor = System.Drawing.SystemColors.Control
        Me.ClearScrBtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.ClearScrBtn.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearScrBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ClearScrBtn.Location = New System.Drawing.Point(484, 270)
        Me.ClearScrBtn.Name = "ClearScrBtn"
        Me.ClearScrBtn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ClearScrBtn.Size = New System.Drawing.Size(81, 25)
        Me.ClearScrBtn.TabIndex = 102
        Me.ClearScrBtn.Text = "Clear All"
        Me.ClearScrBtn.UseVisualStyleBackColor = False
        '
        'OldFormBtn
        '
        Me.OldFormBtn.AutoSize = True
        Me.OldFormBtn.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OldFormBtn.Location = New System.Drawing.Point(628, 204)
        Me.OldFormBtn.Name = "OldFormBtn"
        Me.OldFormBtn.Size = New System.Drawing.Size(68, 18)
        Me.OldFormBtn.TabIndex = 104
        Me.OldFormBtn.Text = "Old Form"
        Me.OldFormBtn.UseVisualStyleBackColor = True
        Me.OldFormBtn.Visible = False
        '
        'NewFormBtn
        '
        Me.NewFormBtn.AutoSize = True
        Me.NewFormBtn.Checked = True
        Me.NewFormBtn.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewFormBtn.Location = New System.Drawing.Point(553, 202)
        Me.NewFormBtn.Name = "NewFormBtn"
        Me.NewFormBtn.Size = New System.Drawing.Size(75, 18)
        Me.NewFormBtn.TabIndex = 103
        Me.NewFormBtn.TabStop = True
        Me.NewFormBtn.Text = "New Form" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.NewFormBtn.UseVisualStyleBackColor = True
        Me.NewFormBtn.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(124, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(9, 17)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "°"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Window
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(9, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(80, 17)
        Me.Label4.TabIndex = 111
        Me.Label4.Text = "DR Latitude"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Window
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(21, 610)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(139, 19)
        Me.Label5.TabIndex = 116
        Me.Label5.Text = "Est Ho of Center at LAN"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblIEsec
        '
        Me.lblIEsec.BackColor = System.Drawing.SystemColors.Window
        Me.lblIEsec.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblIEsec.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIEsec.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblIEsec.Location = New System.Drawing.Point(370, 145)
        Me.lblIEsec.Name = "lblIEsec"
        Me.lblIEsec.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblIEsec.Size = New System.Drawing.Size(9, 17)
        Me.lblIEsec.TabIndex = 78
        Me.lblIEsec.Text = """"
        Me.lblIEsec.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CelestialTools.My.Resources.Resources.ABC_white
        Me.PictureBox1.Location = New System.Drawing.Point(232, 689)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(316, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 108
        Me.PictureBox1.TabStop = False
        '
        'MeridianPicBx
        '
        Me.MeridianPicBx.Location = New System.Drawing.Point(484, 546)
        Me.MeridianPicBx.Name = "MeridianPicBx"
        Me.MeridianPicBx.Size = New System.Drawing.Size(230, 115)
        Me.MeridianPicBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.MeridianPicBx.TabIndex = 94
        Me.MeridianPicBx.TabStop = False
        '
        'btnDisplayEQTData
        '
        Me.btnDisplayEQTData.Location = New System.Drawing.Point(30, 636)
        Me.btnDisplayEQTData.Name = "btnDisplayEQTData"
        Me.btnDisplayEQTData.Size = New System.Drawing.Size(216, 23)
        Me.btnDisplayEQTData.TabIndex = 118
        Me.btnDisplayEQTData.TabStop = False
        Me.btnDisplayEQTData.Text = "Display EQT Data for Year"
        Me.btnDisplayEQTData.UseVisualStyleBackColor = True
        Me.btnDisplayEQTData.Visible = False
        '
        'DGLAN
        '
        Me.DGLAN.AllowUserToAddRows = False
        Me.DGLAN.AllowUserToDeleteRows = False
        Me.DGLAN.AllowUserToResizeColumns = False
        Me.DGLAN.AllowUserToResizeRows = False
        Me.DGLAN.BackgroundColor = System.Drawing.Color.White
        Me.DGLAN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGLAN.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGLAN.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGLAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGLAN.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGLAN.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGLAN.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGLAN.Location = New System.Drawing.Point(18, 322)
        Me.DGLAN.MultiSelect = False
        Me.DGLAN.Name = "DGLAN"
        Me.DGLAN.ReadOnly = True
        Me.DGLAN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DGLAN.RowHeadersVisible = False
        Me.DGLAN.RowTemplate.ReadOnly = True
        Me.DGLAN.Size = New System.Drawing.Size(225, 223)
        Me.DGLAN.TabIndex = 119
        '
        'DGAlt
        '
        Me.DGAlt.AllowUserToAddRows = False
        Me.DGAlt.AllowUserToDeleteRows = False
        Me.DGAlt.AllowUserToResizeColumns = False
        Me.DGAlt.AllowUserToResizeRows = False
        Me.DGAlt.BackgroundColor = System.Drawing.Color.White
        Me.DGAlt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGAlt.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGAlt.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGAlt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGAlt.Cursor = System.Windows.Forms.Cursors.Default
        Me.DGAlt.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGAlt.Location = New System.Drawing.Point(260, 320)
        Me.DGAlt.MultiSelect = False
        Me.DGAlt.Name = "DGAlt"
        Me.DGAlt.ReadOnly = True
        Me.DGAlt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DGAlt.RowHeadersVisible = False
        Me.DGAlt.RowTemplate.ReadOnly = True
        Me.DGAlt.Size = New System.Drawing.Size(210, 225)
        Me.DGAlt.TabIndex = 120
        '
        'AlmanacTxtBx
        '
        Me.AlmanacTxtBx.BackColor = System.Drawing.SystemColors.Window
        Me.AlmanacTxtBx.Font = New System.Drawing.Font("Courier New", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlmanacTxtBx.Location = New System.Drawing.Point(260, 547)
        Me.AlmanacTxtBx.Name = "AlmanacTxtBx"
        Me.AlmanacTxtBx.ReadOnly = True
        Me.AlmanacTxtBx.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.AlmanacTxtBx.Size = New System.Drawing.Size(210, 20)
        Me.AlmanacTxtBx.TabIndex = 92
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Window
        Me.GroupBox1.Location = New System.Drawing.Point(488, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(225, 188)
        Me.GroupBox1.TabIndex = 112
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Noon Sight Eval Settings"
        '
        'DGAlm
        '
        Me.DGAlm.AllowUserToAddRows = False
        Me.DGAlm.AllowUserToDeleteRows = False
        Me.DGAlm.AllowUserToResizeColumns = False
        Me.DGAlm.AllowUserToResizeRows = False
        Me.DGAlm.BackgroundColor = System.Drawing.Color.White
        Me.DGAlm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGAlm.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGAlm.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGAlm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGAlm.Cursor = System.Windows.Forms.Cursors.Default
        Me.DGAlm.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGAlm.Location = New System.Drawing.Point(260, 568)
        Me.DGAlm.MultiSelect = False
        Me.DGAlm.Name = "DGAlm"
        Me.DGAlm.ReadOnly = True
        Me.DGAlm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DGAlm.RowHeadersVisible = False
        Me.DGAlm.RowTemplate.ReadOnly = True
        Me.DGAlm.Size = New System.Drawing.Size(210, 90)
        Me.DGAlm.TabIndex = 121
        '
        'DGLat
        '
        Me.DGLat.AllowUserToAddRows = False
        Me.DGLat.AllowUserToDeleteRows = False
        Me.DGLat.AllowUserToResizeColumns = False
        Me.DGLat.AllowUserToResizeRows = False
        Me.DGLat.BackgroundColor = System.Drawing.Color.White
        Me.DGLat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGLat.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGLat.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DGLat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGLat.Cursor = System.Windows.Forms.Cursors.Default
        Me.DGLat.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGLat.Location = New System.Drawing.Point(484, 321)
        Me.DGLat.MultiSelect = False
        Me.DGLat.Name = "DGLat"
        Me.DGLat.ReadOnly = True
        Me.DGLat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DGLat.RowHeadersVisible = False
        Me.DGLat.RowTemplate.ReadOnly = True
        Me.DGLat.Size = New System.Drawing.Size(230, 215)
        Me.DGLat.TabIndex = 122
        '
        'txtUserInfo
        '
        Me.txtUserInfo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserInfo.HideSelection = False
        Me.txtUserInfo.Location = New System.Drawing.Point(77, 1)
        Me.txtUserInfo.Name = "txtUserInfo"
        Me.txtUserInfo.Size = New System.Drawing.Size(400, 20)
        Me.txtUserInfo.TabIndex = 198
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 14)
        Me.Label7.TabIndex = 197
        Me.Label7.Text = "User Info"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtZTLANWarn
        '
        Me.txtZTLANWarn.BackColor = System.Drawing.Color.Yellow
        Me.txtZTLANWarn.Location = New System.Drawing.Point(487, 223)
        Me.txtZTLANWarn.Multiline = True
        Me.txtZTLANWarn.Name = "txtZTLANWarn"
        Me.txtZTLANWarn.ReadOnly = True
        Me.txtZTLANWarn.Size = New System.Drawing.Size(226, 45)
        Me.txtZTLANWarn.TabIndex = 199
        Me.txtZTLANWarn.Text = "WARNING: The ZT of this Sun Sight is > 1 hour from LAN. Use the SRF form for Sun " &
    "Sight Reductions."
        Me.txtZTLANWarn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtZTLANWarn.Visible = False
        '
        'FormNoonSight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(722, 741)
        Me.Controls.Add(Me.txtZTLANWarn)
        Me.Controls.Add(Me.txtUserInfo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DGLat)
        Me.Controls.Add(Me.DGAlm)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.DGAlt)
        Me.Controls.Add(Me.DGLAN)
        Me.Controls.Add(Me.btnDisplayEQTData)
        Me.Controls.Add(Me.txtCalcHo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDRLMin)
        Me.Controls.Add(Me.NewFormBtn)
        Me.Controls.Add(Me.cboDRL)
        Me.Controls.Add(Me.txtDRLDeg)
        Me.Controls.Add(Me.OldFormBtn)
        Me.Controls.Add(Me.optHoParameters)
        Me.Controls.Add(Me.optHoSRForm)
        Me.Controls.Add(Me.lblLDeg)
        Me.Controls.Add(Me.optStdTPNo)
        Me.Controls.Add(Me.lblLMin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.OptStdTPYes)
        Me.Controls.Add(Me.DTNoonSight)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ClearScrBtn)
        Me.Controls.Add(Me.ExitNoonSight)
        Me.Controls.Add(Me.LongitudeCalcTxtBx)
        Me.Controls.Add(Me.LANTimeTxtBx)
        Me.Controls.Add(Me.LatitudeTxtBx)
        Me.Controls.Add(Me.AlmanacTxtBx)
        Me.Controls.Add(Me.AltitudeTxtBx)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.chkDST)
        Me.Controls.Add(Me.txtIESec)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.cmdNoonSight)
        Me.Controls.Add(Me.txtHsDeg)
        Me.Controls.Add(Me.txtHsMin)
        Me.Controls.Add(Me.txtHsSec)
        Me.Controls.Add(Me.txtHE)
        Me.Controls.Add(Me.cboHE)
        Me.Controls.Add(Me.txtIEmin)
        Me.Controls.Add(Me.cboIE)
        Me.Controls.Add(Me.txtTemperature)
        Me.Controls.Add(Me.cboTemperature)
        Me.Controls.Add(Me.txtPressure)
        Me.Controls.Add(Me.cboPressure)
        Me.Controls.Add(Me.Framehs)
        Me.Controls.Add(Me.FrameHorizon)
        Me.Controls.Add(Me.txtDsDist)
        Me.Controls.Add(Me.cboDsUnit)
        Me.Controls.Add(Me.txtIEdeg)
        Me.Controls.Add(Me.cmdLAN)
        Me.Controls.Add(Me.txtZDh)
        Me.Controls.Add(Me.FrameZD)
        Me.Controls.Add(Me.cboZDm)
        Me.Controls.Add(Me.txtLoDeg)
        Me.Controls.Add(Me.txtLoMin)
        Me.Controls.Add(Me.cboLo)
        Me.Controls.Add(Me.lblHoCorrs)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblZDDST)
        Me.Controls.Add(Me.lblIEsec)
        Me.Controls.Add(Me.lblS)
        Me.Controls.Add(Me.lblZ)
        Me.Controls.Add(Me.lblN)
        Me.Controls.Add(Me.lblHsFormat)
        Me.Controls.Add(Me.lblHs)
        Me.Controls.Add(Me.lblHsDeg)
        Me.Controls.Add(Me.lblHsMin)
        Me.Controls.Add(Me.lblHsSec)
        Me.Controls.Add(Me.lblHE)
        Me.Controls.Add(Me.lblIE)
        Me.Controls.Add(Me.lblIEMin)
        Me.Controls.Add(Me.lblStdT_P)
        Me.Controls.Add(Me.lblTemperature)
        Me.Controls.Add(Me.lblTempDeg)
        Me.Controls.Add(Me.lblPressure)
        Me.Controls.Add(Me.lblHorizon)
        Me.Controls.Add(Me.lblDsDist)
        Me.Controls.Add(Me.lblIEdeg)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblZDAutoManual)
        Me.Controls.Add(Me.lblZD)
        Me.Controls.Add(Me.lblZDh)
        Me.Controls.Add(Me.lblZDm)
        Me.Controls.Add(Me.lblDRLo)
        Me.Controls.Add(Me.lblLoDeg)
        Me.Controls.Add(Me.lblLoMin)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.MeridianPicBx)
        Me.Controls.Add(Me.GroupBox1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(194, 29)
        Me.MaximizeBox = False
        Me.Name = "FormNoonSight"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Noon Sight"
        Me.Frame2.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        Me.Framehs.ResumeLayout(False)
        Me.FrameHorizon.ResumeLayout(False)
        Me.FrameZD.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MeridianPicBx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGLAN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGAlt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGAlm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGLat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AltitudeTxtBx As TextBox
    Friend WithEvents LatitudeTxtBx As TextBox
    Friend WithEvents MeridianPicBx As PictureBox
    Friend WithEvents LANTimeTxtBx As TextBox
    Friend WithEvents LongitudeCalcTxtBx As TextBox
    Public WithEvents ExitNoonSight As Button
    Public WithEvents ClearScrBtn As Button
    Public WithEvents optHorizonBubble As RadioButton
    Public WithEvents optHoParameters As RadioButton
    Friend WithEvents OldFormBtn As RadioButton
    Friend WithEvents NewFormBtn As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DTNoonSight As DateTimePicker
    Public WithEvents Label2 As Label
    Public WithEvents Label4 As Label
    Public WithEvents Label5 As Label
    Public WithEvents txtCalcHo As TextBox
    Public WithEvents lblIEsec As Label
    Public WithEvents txtIESec As TextBox
    Friend WithEvents btnDisplayEQTData As Button
    Friend WithEvents DGLAN As DataGridView
    Friend WithEvents DGAlt As DataGridView
    Friend WithEvents AlmanacTxtBx As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DGAlm As DataGridView
    Friend WithEvents DGLat As DataGridView
    Friend WithEvents txtUserInfo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtZTLANWarn As TextBox
#End Region
End Class