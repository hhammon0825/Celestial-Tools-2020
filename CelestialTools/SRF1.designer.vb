<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FormSRF
#Region "Windows Form Designer generated code "
    <System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
        MyBase.New()
        'This is required by the Windows Form Designer.
        InitializeComponent()
        'Form_Initialize_Renamed()
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
    Public ToolTipFormSRF As System.Windows.Forms.ToolTip
    Public WithEvents cboStars As System.Windows.Forms.ComboBox
    Public WithEvents cboLo As System.Windows.Forms.ComboBox
    Public WithEvents cboL As System.Windows.Forms.ComboBox
    Public WithEvents cboSun As System.Windows.Forms.ComboBox
    Public WithEvents chkDST As System.Windows.Forms.CheckBox
    Public WithEvents txtIESec As System.Windows.Forms.TextBox
    Public WithEvents optHoParameters As System.Windows.Forms.RadioButton
    Public WithEvents optHoSRForm As System.Windows.Forms.RadioButton
    Public WithEvents txtSightNo As System.Windows.Forms.TextBox
    Public WithEvents cmdPrint As System.Windows.Forms.Button
    Public WithEvents cmdFix As System.Windows.Forms.Button
    Public WithEvents cmdSave As System.Windows.Forms.Button
    Public WithEvents txtIEdeg As System.Windows.Forms.TextBox
    Public WithEvents cboZDm As System.Windows.Forms.ComboBox
    Public WithEvents txtLDeg As System.Windows.Forms.TextBox
    Public WithEvents cboPolaris As System.Windows.Forms.ComboBox
    Public WithEvents cboDsUnit As System.Windows.Forms.ComboBox
    Public WithEvents txtDsDist As System.Windows.Forms.TextBox
    Public WithEvents optHsDMS As System.Windows.Forms.RadioButton
    Public WithEvents optHsDMm As System.Windows.Forms.RadioButton
    Public WithEvents Framehs As System.Windows.Forms.Panel
    Public WithEvents optZDUT As System.Windows.Forms.RadioButton
    Public WithEvents optZDManual As System.Windows.Forms.RadioButton
    Public WithEvents optZDAuto As System.Windows.Forms.RadioButton
    Public WithEvents FrameZD As System.Windows.Forms.Panel
    Public WithEvents cmdReduce As System.Windows.Forms.Button
    Public WithEvents cboPressure As System.Windows.Forms.ComboBox
    Public WithEvents txtPressure As System.Windows.Forms.TextBox
    Public WithEvents cboTemperature As System.Windows.Forms.ComboBox
    Public WithEvents txtTemperature As System.Windows.Forms.TextBox
    Public WithEvents cboIE As System.Windows.Forms.ComboBox
    Public WithEvents txtIEmin As System.Windows.Forms.TextBox
    Public WithEvents cboHE As System.Windows.Forms.ComboBox
    Public WithEvents txtHE As System.Windows.Forms.TextBox
    Public WithEvents txtHsSec As System.Windows.Forms.TextBox
    Public WithEvents txtHsMin As System.Windows.Forms.TextBox
    Public WithEvents txtHsDeg As System.Windows.Forms.TextBox
    Public WithEvents txtLoMin As System.Windows.Forms.TextBox
    Public WithEvents txtLoDeg As System.Windows.Forms.TextBox
    Public WithEvents txtLMin As System.Windows.Forms.TextBox
    Public WithEvents cboBody As System.Windows.Forms.ComboBox
    Public WithEvents txtZDh As System.Windows.Forms.TextBox
    Public WithEvents cboWE As System.Windows.Forms.ComboBox
    Public WithEvents txtWESec As System.Windows.Forms.TextBox
    Public WithEvents txtWEMin As System.Windows.Forms.TextBox
    Public WithEvents optStdTPNo As System.Windows.Forms.RadioButton
    Public WithEvents optStdTPYes As System.Windows.Forms.RadioButton
    Public WithEvents FrameTP As System.Windows.Forms.Panel
    Public WithEvents FrameHo As System.Windows.Forms.Panel
    Public WithEvents lblZDDST As System.Windows.Forms.Label
    Public WithEvents lblIEsec As System.Windows.Forms.Label
    Public WithEvents lblHoCorrs As System.Windows.Forms.Label
    Public WithEvents lblSightNo As System.Windows.Forms.Label

    Public WithEvents lblIEdeg As System.Windows.Forms.Label
    Public WithEvents lblZDm As System.Windows.Forms.Label
    Public WithEvents lblZDh As System.Windows.Forms.Label
    Public WithEvents lblDsDist As System.Windows.Forms.Label
    Public WithEvents lblHorizon As System.Windows.Forms.Label
    Public WithEvents lblPressure As System.Windows.Forms.Label
    Public WithEvents lblTempDeg As System.Windows.Forms.Label
    Public WithEvents lblTemperature As System.Windows.Forms.Label
    Public WithEvents lblStdT_P As System.Windows.Forms.Label
    Public WithEvents lblIEMin As System.Windows.Forms.Label
    Public WithEvents lblIE As System.Windows.Forms.Label
    Public WithEvents lblHE As System.Windows.Forms.Label
    Public WithEvents lblHsSec As System.Windows.Forms.Label
    Public WithEvents lblHsMin As System.Windows.Forms.Label
    Public WithEvents lblHsDeg As System.Windows.Forms.Label
    Public WithEvents lblHs As System.Windows.Forms.Label
    Public WithEvents lblHsFormat As System.Windows.Forms.Label
    Public WithEvents lblLoMin As System.Windows.Forms.Label
    Public WithEvents lblLoDeg As System.Windows.Forms.Label
    Public WithEvents lblDRLo As System.Windows.Forms.Label
    Public WithEvents lblLMin As System.Windows.Forms.Label
    Public WithEvents lblLDeg As System.Windows.Forms.Label
    Public WithEvents lblDRL As System.Windows.Forms.Label
    Public WithEvents lblBody As System.Windows.Forms.Label
    Public WithEvents lblZD As System.Windows.Forms.Label
    Public WithEvents lblZDAutoManual As System.Windows.Forms.Label
    Public WithEvents lblWEsec As System.Windows.Forms.Label
    Public WithEvents lblWEmin As System.Windows.Forms.Label
    Public WithEvents lblWE As System.Windows.Forms.Label
    'Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSRF))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolTipFormSRF = New System.Windows.Forms.ToolTip(Me.components)
        Me.chkDST = New System.Windows.Forms.CheckBox()
        Me.txtIESec = New System.Windows.Forms.TextBox()
        Me.optHoParameters = New System.Windows.Forms.RadioButton()
        Me.optHoSRForm = New System.Windows.Forms.RadioButton()
        Me.txtSightNo = New System.Windows.Forms.TextBox()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.txtIEdeg = New System.Windows.Forms.TextBox()
        Me.txtLDeg = New System.Windows.Forms.TextBox()
        Me.txtDsDist = New System.Windows.Forms.TextBox()
        Me.optZDManual = New System.Windows.Forms.RadioButton()
        Me.optZDAuto = New System.Windows.Forms.RadioButton()
        Me.txtPressure = New System.Windows.Forms.TextBox()
        Me.txtTemperature = New System.Windows.Forms.TextBox()
        Me.txtIEmin = New System.Windows.Forms.TextBox()
        Me.txtHE = New System.Windows.Forms.TextBox()
        Me.txtHsSec = New System.Windows.Forms.TextBox()
        Me.txtHsMin = New System.Windows.Forms.TextBox()
        Me.txtHsDeg = New System.Windows.Forms.TextBox()
        Me.txtLoMin = New System.Windows.Forms.TextBox()
        Me.txtLoDeg = New System.Windows.Forms.TextBox()
        Me.txtLMin = New System.Windows.Forms.TextBox()
        Me.txtZDh = New System.Windows.Forms.TextBox()
        Me.txtWESec = New System.Windows.Forms.TextBox()
        Me.txtWEMin = New System.Windows.Forms.TextBox()
        Me.lblDsDist = New System.Windows.Forms.Label()
        Me.lblIE = New System.Windows.Forms.Label()
        Me.lblHE = New System.Windows.Forms.Label()
        Me.lblHs = New System.Windows.Forms.Label()
        Me.lblHsFormat = New System.Windows.Forms.Label()
        Me.lblZD = New System.Windows.Forms.Label()
        Me.lblZDAutoManual = New System.Windows.Forms.Label()
        Me.lblWE = New System.Windows.Forms.Label()
        Me.cboStars = New System.Windows.Forms.ComboBox()
        Me.cboLo = New System.Windows.Forms.ComboBox()
        Me.cboL = New System.Windows.Forms.ComboBox()
        Me.cboSun = New System.Windows.Forms.ComboBox()
        Me.cmdFix = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cboZDm = New System.Windows.Forms.ComboBox()
        Me.cboPolaris = New System.Windows.Forms.ComboBox()
        Me.cboDsUnit = New System.Windows.Forms.ComboBox()
        Me.Framehs = New System.Windows.Forms.Panel()
        Me.optHsDMS = New System.Windows.Forms.RadioButton()
        Me.optHsDMm = New System.Windows.Forms.RadioButton()
        Me.FrameZD = New System.Windows.Forms.Panel()
        Me.optZDUT = New System.Windows.Forms.RadioButton()
        Me.cmdReduce = New System.Windows.Forms.Button()
        Me.cboPressure = New System.Windows.Forms.ComboBox()
        Me.cboTemperature = New System.Windows.Forms.ComboBox()
        Me.cboIE = New System.Windows.Forms.ComboBox()
        Me.cboHE = New System.Windows.Forms.ComboBox()
        Me.cboBody = New System.Windows.Forms.ComboBox()
        Me.cboWE = New System.Windows.Forms.ComboBox()
        Me.FrameTP = New System.Windows.Forms.Panel()
        Me.optStdTPNo = New System.Windows.Forms.RadioButton()
        Me.optStdTPYes = New System.Windows.Forms.RadioButton()
        Me.FrameHo = New System.Windows.Forms.Panel()
        Me.lblZDDST = New System.Windows.Forms.Label()
        Me.lblIEsec = New System.Windows.Forms.Label()
        Me.lblHoCorrs = New System.Windows.Forms.Label()
        Me.lblSightNo = New System.Windows.Forms.Label()
        Me.lblIEdeg = New System.Windows.Forms.Label()
        Me.lblZDm = New System.Windows.Forms.Label()
        Me.lblZDh = New System.Windows.Forms.Label()
        Me.lblHorizon = New System.Windows.Forms.Label()
        Me.lblPressure = New System.Windows.Forms.Label()
        Me.lblTempDeg = New System.Windows.Forms.Label()
        Me.lblTemperature = New System.Windows.Forms.Label()
        Me.lblStdT_P = New System.Windows.Forms.Label()
        Me.lblIEMin = New System.Windows.Forms.Label()
        Me.lblHsSec = New System.Windows.Forms.Label()
        Me.lblHsMin = New System.Windows.Forms.Label()
        Me.lblHsDeg = New System.Windows.Forms.Label()
        Me.lblLoMin = New System.Windows.Forms.Label()
        Me.lblLoDeg = New System.Windows.Forms.Label()
        Me.lblDRLo = New System.Windows.Forms.Label()
        Me.lblLMin = New System.Windows.Forms.Label()
        Me.lblLDeg = New System.Windows.Forms.Label()
        Me.lblDRL = New System.Windows.Forms.Label()
        Me.lblBody = New System.Windows.Forms.Label()
        Me.lblWEsec = New System.Windows.Forms.Label()
        Me.lblWEmin = New System.Windows.Forms.Label()
        Me.TimeTxtBx = New System.Windows.Forms.RichTextBox()
        Me.LHATxtBx = New System.Windows.Forms.RichTextBox()
        Me.AltitudeTxtBx = New System.Windows.Forms.RichTextBox()
        Me.IntAzTxtBx = New System.Windows.Forms.RichTextBox()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.EqTPicBx = New System.Windows.Forms.PictureBox()
        Me.FrameHorizon = New System.Windows.Forms.Panel()
        Me.optHorizonBubble = New System.Windows.Forms.RadioButton()
        Me.optHorizonDipShort = New System.Windows.Forms.RadioButton()
        Me.optHorizonArtificial = New System.Windows.Forms.RadioButton()
        Me.optHorizonNatural = New System.Windows.Forms.RadioButton()
        Me.frmLimb = New System.Windows.Forms.Panel()
        Me.optCenter = New System.Windows.Forms.RadioButton()
        Me.optUpper = New System.Windows.Forms.RadioButton()
        Me.optLower = New System.Windows.Forms.RadioButton()
        Me.LimbTxt = New System.Windows.Forms.TextBox()
        Me.cboPlanets = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DTSight = New System.Windows.Forms.DateTimePicker()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.btnCLSPlot = New System.Windows.Forms.Button()
        Me.btnCustomPlot = New System.Windows.Forms.Button()
        Me.cmdMerDiag = New System.Windows.Forms.Button()
        Me.DGSight = New System.Windows.Forms.DataGridView()
        Me.SightTxtBx = New System.Windows.Forms.TextBox()
        Me.DecTxtBx = New System.Windows.Forms.TextBox()
        Me.DGDec = New System.Windows.Forms.DataGridView()
        Me.DGTime = New System.Windows.Forms.DataGridView()
        Me.DGLHA = New System.Windows.Forms.DataGridView()
        Me.DGAlt = New System.Windows.Forms.DataGridView()
        Me.txtUserInfo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnExpandTimeDiag = New System.Windows.Forms.Button()
        Me.ClearAllBtn = New System.Windows.Forms.Button()
        Me.cboLLoBy = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Framehs.SuspendLayout()
        Me.FrameZD.SuspendLayout()
        Me.FrameTP.SuspendLayout()
        Me.FrameHo.SuspendLayout()
        CType(Me.EqTPicBx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FrameHorizon.SuspendLayout()
        Me.frmLimb.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGSight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGDec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGLHA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGAlt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkDST
        '
        Me.chkDST.BackColor = System.Drawing.SystemColors.Window
        Me.chkDST.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkDST.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDST.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkDST.Location = New System.Drawing.Point(169, 161)
        Me.chkDST.Name = "chkDST"
        Me.chkDST.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkDST.Size = New System.Drawing.Size(17, 17)
        Me.chkDST.TabIndex = 88
        Me.chkDST.Text = "Check1"
        Me.ToolTipFormSRF.SetToolTip(Me.chkDST, "Check if Dayslight Saving is in effect")
        Me.chkDST.UseVisualStyleBackColor = False
        '
        'txtIESec
        '
        Me.txtIESec.AcceptsReturn = True
        Me.txtIESec.BackColor = System.Drawing.SystemColors.Window
        Me.txtIESec.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIESec.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIESec.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtIESec.Location = New System.Drawing.Point(561, 43)
        Me.txtIESec.MaxLength = 2
        Me.txtIESec.Name = "txtIESec"
        Me.txtIESec.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtIESec.Size = New System.Drawing.Size(33, 20)
        Me.txtIESec.TabIndex = 54
        Me.ToolTipFormSRF.SetToolTip(Me.txtIESec, "Range 0 to 59")
        Me.txtIESec.Visible = False
        '
        'optHoParameters
        '
        Me.optHoParameters.BackColor = System.Drawing.SystemColors.Window
        Me.optHoParameters.Cursor = System.Windows.Forms.Cursors.Default
        Me.optHoParameters.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optHoParameters.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optHoParameters.Location = New System.Drawing.Point(70, 1)
        Me.optHoParameters.Name = "optHoParameters"
        Me.optHoParameters.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optHoParameters.Size = New System.Drawing.Size(73, 18)
        Me.optHoParameters.TabIndex = 86
        Me.optHoParameters.TabStop = True
        Me.optHoParameters.Text = "Parameters"
        Me.ToolTipFormSRF.SetToolTip(Me.optHoParameters, "Refraction, parallax, etc.")
        Me.optHoParameters.UseVisualStyleBackColor = False
        '
        'optHoSRForm
        '
        Me.optHoSRForm.BackColor = System.Drawing.SystemColors.Window
        Me.optHoSRForm.Checked = True
        Me.optHoSRForm.Cursor = System.Windows.Forms.Cursors.Default
        Me.optHoSRForm.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optHoSRForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optHoSRForm.Location = New System.Drawing.Point(6, 1)
        Me.optHoSRForm.Name = "optHoSRForm"
        Me.optHoSRForm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optHoSRForm.Size = New System.Drawing.Size(67, 18)
        Me.optHoSRForm.TabIndex = 85
        Me.optHoSRForm.TabStop = True
        Me.optHoSRForm.Text = "SR Form"
        Me.ToolTipFormSRF.SetToolTip(Me.optHoSRForm, "Main, Add'l, etc.")
        Me.optHoSRForm.UseVisualStyleBackColor = False
        '
        'txtSightNo
        '
        Me.txtSightNo.AcceptsReturn = True
        Me.txtSightNo.BackColor = System.Drawing.SystemColors.Window
        Me.txtSightNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSightNo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSightNo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSightNo.Location = New System.Drawing.Point(103, 29)
        Me.txtSightNo.MaxLength = 2
        Me.txtSightNo.Name = "txtSightNo"
        Me.txtSightNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSightNo.Size = New System.Drawing.Size(25, 20)
        Me.txtSightNo.TabIndex = 24
        Me.ToolTipFormSRF.SetToolTip(Me.txtSightNo, "Range 0 to 99")
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrint.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.Location = New System.Drawing.Point(692, 0)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrint.Size = New System.Drawing.Size(21, 21)
        Me.cmdPrint.TabIndex = 81
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTipFormSRF.SetToolTip(Me.cmdPrint, "Print window")
        Me.cmdPrint.UseVisualStyleBackColor = False
        '
        'txtIEdeg
        '
        Me.txtIEdeg.AcceptsReturn = True
        Me.txtIEdeg.BackColor = System.Drawing.SystemColors.Window
        Me.txtIEdeg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIEdeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIEdeg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtIEdeg.Location = New System.Drawing.Point(497, 43)
        Me.txtIEdeg.MaxLength = 1
        Me.txtIEdeg.Name = "txtIEdeg"
        Me.txtIEdeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtIEdeg.Size = New System.Drawing.Size(17, 20)
        Me.txtIEdeg.TabIndex = 51
        Me.ToolTipFormSRF.SetToolTip(Me.txtIEdeg, "Range 0 to 9; to right of index mark")
        '
        'txtLDeg
        '
        Me.txtLDeg.AcceptsReturn = True
        Me.txtLDeg.BackColor = System.Drawing.SystemColors.Window
        Me.txtLDeg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLDeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLDeg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLDeg.Location = New System.Drawing.Point(321, 112)
        Me.txtLDeg.MaxLength = 2
        Me.txtLDeg.Name = "txtLDeg"
        Me.txtLDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLDeg.Size = New System.Drawing.Size(25, 20)
        Me.txtLDeg.TabIndex = 29
        Me.ToolTipFormSRF.SetToolTip(Me.txtLDeg, "Range 0 to 90")
        '
        'txtDsDist
        '
        Me.txtDsDist.AcceptsReturn = True
        Me.txtDsDist.BackColor = System.Drawing.SystemColors.Window
        Me.txtDsDist.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDsDist.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDsDist.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDsDist.Location = New System.Drawing.Point(521, 110)
        Me.txtDsDist.MaxLength = 5
        Me.txtDsDist.Name = "txtDsDist"
        Me.txtDsDist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDsDist.Size = New System.Drawing.Size(41, 20)
        Me.txtDsDist.TabIndex = 65
        Me.ToolTipFormSRF.SetToolTip(Me.txtDsDist, "Limited to five characters")
        Me.txtDsDist.Visible = False
        '
        'optZDManual
        '
        Me.optZDManual.BackColor = System.Drawing.SystemColors.Window
        Me.optZDManual.Cursor = System.Windows.Forms.Cursors.Default
        Me.optZDManual.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optZDManual.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optZDManual.Location = New System.Drawing.Point(54, 3)
        Me.optZDManual.Name = "optZDManual"
        Me.optZDManual.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optZDManual.Size = New System.Drawing.Size(60, 18)
        Me.optZDManual.TabIndex = 17
        Me.optZDManual.TabStop = True
        Me.optZDManual.Text = "Manual"
        Me.ToolTipFormSRF.SetToolTip(Me.optZDManual, "ZD can be set for civil standard time zone")
        Me.optZDManual.UseVisualStyleBackColor = False
        '
        'optZDAuto
        '
        Me.optZDAuto.BackColor = System.Drawing.SystemColors.Window
        Me.optZDAuto.Checked = True
        Me.optZDAuto.Cursor = System.Windows.Forms.Cursors.Default
        Me.optZDAuto.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optZDAuto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optZDAuto.Location = New System.Drawing.Point(5, 3)
        Me.optZDAuto.Name = "optZDAuto"
        Me.optZDAuto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optZDAuto.Size = New System.Drawing.Size(49, 18)
        Me.optZDAuto.TabIndex = 16
        Me.optZDAuto.TabStop = True
        Me.optZDAuto.Text = "Auto"
        Me.ToolTipFormSRF.SetToolTip(Me.optZDAuto, "ZD based on longitude alone")
        Me.optZDAuto.UseVisualStyleBackColor = False
        '
        'txtPressure
        '
        Me.txtPressure.AcceptsReturn = True
        Me.txtPressure.BackColor = System.Drawing.SystemColors.Window
        Me.txtPressure.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPressure.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPressure.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPressure.Location = New System.Drawing.Point(595, 155)
        Me.txtPressure.MaxLength = 5
        Me.txtPressure.Name = "txtPressure"
        Me.txtPressure.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPressure.Size = New System.Drawing.Size(41, 20)
        Me.txtPressure.TabIndex = 73
        Me.txtPressure.Text = "29.83"
        Me.ToolTipFormSRF.SetToolTip(Me.txtPressure, "Range 28 to 32 (in Hg) or 950 to 1100 (mb)")
        Me.txtPressure.Visible = False
        '
        'txtTemperature
        '
        Me.txtTemperature.AcceptsReturn = True
        Me.txtTemperature.BackColor = System.Drawing.SystemColors.Window
        Me.txtTemperature.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTemperature.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTemperature.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTemperature.Location = New System.Drawing.Point(481, 155)
        Me.txtTemperature.MaxLength = 4
        Me.txtTemperature.Name = "txtTemperature"
        Me.txtTemperature.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTemperature.Size = New System.Drawing.Size(33, 20)
        Me.txtTemperature.TabIndex = 69
        Me.txtTemperature.Text = "50"
        Me.ToolTipFormSRF.SetToolTip(Me.txtTemperature, "Range -40 to 130 (F) or -40 to 55 (C)")
        Me.txtTemperature.Visible = False
        '
        'txtIEmin
        '
        Me.txtIEmin.AcceptsReturn = True
        Me.txtIEmin.BackColor = System.Drawing.SystemColors.Window
        Me.txtIEmin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIEmin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIEmin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtIEmin.Location = New System.Drawing.Point(521, 43)
        Me.txtIEmin.MaxLength = 4
        Me.txtIEmin.Name = "txtIEmin"
        Me.txtIEmin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtIEmin.Size = New System.Drawing.Size(33, 20)
        Me.txtIEmin.TabIndex = 53
        Me.ToolTipFormSRF.SetToolTip(Me.txtIEmin, "Range 0 to 59.9 (DM.m) or 59 (DMS)")
        '
        'txtHE
        '
        Me.txtHE.AcceptsReturn = True
        Me.txtHE.BackColor = System.Drawing.SystemColors.Window
        Me.txtHE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHE.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHE.Location = New System.Drawing.Point(479, 85)
        Me.txtHE.MaxLength = 4
        Me.txtHE.Name = "txtHE"
        Me.txtHE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHE.Size = New System.Drawing.Size(33, 20)
        Me.txtHE.TabIndex = 62
        Me.ToolTipFormSRF.SetToolTip(Me.txtHE, "Max. 4 characters")
        '
        'txtHsSec
        '
        Me.txtHsSec.AcceptsReturn = True
        Me.txtHsSec.BackColor = System.Drawing.SystemColors.Window
        Me.txtHsSec.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHsSec.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHsSec.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHsSec.Location = New System.Drawing.Point(561, 21)
        Me.txtHsSec.MaxLength = 2
        Me.txtHsSec.Name = "txtHsSec"
        Me.txtHsSec.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHsSec.Size = New System.Drawing.Size(33, 20)
        Me.txtHsSec.TabIndex = 48
        Me.ToolTipFormSRF.SetToolTip(Me.txtHsSec, "Range 0 to 59")
        Me.txtHsSec.Visible = False
        '
        'txtHsMin
        '
        Me.txtHsMin.AcceptsReturn = True
        Me.txtHsMin.BackColor = System.Drawing.SystemColors.Window
        Me.txtHsMin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHsMin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHsMin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHsMin.Location = New System.Drawing.Point(521, 21)
        Me.txtHsMin.MaxLength = 4
        Me.txtHsMin.Name = "txtHsMin"
        Me.txtHsMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHsMin.Size = New System.Drawing.Size(33, 20)
        Me.txtHsMin.TabIndex = 46
        Me.ToolTipFormSRF.SetToolTip(Me.txtHsMin, "Range 0 to 59.9 (DM.m) or 59 (DMS)")
        '
        'txtHsDeg
        '
        Me.txtHsDeg.AcceptsReturn = True
        Me.txtHsDeg.BackColor = System.Drawing.SystemColors.Window
        Me.txtHsDeg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHsDeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHsDeg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHsDeg.Location = New System.Drawing.Point(481, 21)
        Me.txtHsDeg.MaxLength = 3
        Me.txtHsDeg.Name = "txtHsDeg"
        Me.txtHsDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHsDeg.Size = New System.Drawing.Size(33, 20)
        Me.txtHsDeg.TabIndex = 44
        Me.ToolTipFormSRF.SetToolTip(Me.txtHsDeg, "Range 0 to 145")
        '
        'txtLoMin
        '
        Me.txtLoMin.AcceptsReturn = True
        Me.txtLoMin.BackColor = System.Drawing.SystemColors.Window
        Me.txtLoMin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLoMin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoMin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLoMin.Location = New System.Drawing.Point(353, 135)
        Me.txtLoMin.MaxLength = 4
        Me.txtLoMin.Name = "txtLoMin"
        Me.txtLoMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLoMin.Size = New System.Drawing.Size(33, 20)
        Me.txtLoMin.TabIndex = 36
        Me.ToolTipFormSRF.SetToolTip(Me.txtLoMin, "Range 0 to 59.9")
        '
        'txtLoDeg
        '
        Me.txtLoDeg.AcceptsReturn = True
        Me.txtLoDeg.BackColor = System.Drawing.SystemColors.Window
        Me.txtLoDeg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLoDeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoDeg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLoDeg.Location = New System.Drawing.Point(313, 135)
        Me.txtLoDeg.MaxLength = 3
        Me.txtLoDeg.Name = "txtLoDeg"
        Me.txtLoDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLoDeg.Size = New System.Drawing.Size(33, 20)
        Me.txtLoDeg.TabIndex = 35
        Me.ToolTipFormSRF.SetToolTip(Me.txtLoDeg, "Range 0 to 180")
        '
        'txtLMin
        '
        Me.txtLMin.AcceptsReturn = True
        Me.txtLMin.BackColor = System.Drawing.SystemColors.Window
        Me.txtLMin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLMin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLMin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLMin.Location = New System.Drawing.Point(353, 112)
        Me.txtLMin.MaxLength = 4
        Me.txtLMin.Name = "txtLMin"
        Me.txtLMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLMin.Size = New System.Drawing.Size(33, 20)
        Me.txtLMin.TabIndex = 30
        Me.ToolTipFormSRF.SetToolTip(Me.txtLMin, "Range 0 to 59.9")
        '
        'txtZDh
        '
        Me.txtZDh.AcceptsReturn = True
        Me.txtZDh.BackColor = System.Drawing.SystemColors.Window
        Me.txtZDh.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtZDh.Enabled = False
        Me.txtZDh.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZDh.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtZDh.Location = New System.Drawing.Point(65, 160)
        Me.txtZDh.MaxLength = 3
        Me.txtZDh.Name = "txtZDh"
        Me.txtZDh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtZDh.Size = New System.Drawing.Size(25, 20)
        Me.txtZDh.TabIndex = 19
        Me.ToolTipFormSRF.SetToolTip(Me.txtZDh, "Range -14 to +12.  Lo E is -.")
        '
        'txtWESec
        '
        Me.txtWESec.AcceptsReturn = True
        Me.txtWESec.BackColor = System.Drawing.SystemColors.Window
        Me.txtWESec.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWESec.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWESec.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtWESec.Location = New System.Drawing.Point(121, 95)
        Me.txtWESec.MaxLength = 2
        Me.txtWESec.Name = "txtWESec"
        Me.txtWESec.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtWESec.Size = New System.Drawing.Size(25, 20)
        Me.txtWESec.TabIndex = 12
        Me.ToolTipFormSRF.SetToolTip(Me.txtWESec, "Range 0 to 59")
        '
        'txtWEMin
        '
        Me.txtWEMin.AcceptsReturn = True
        Me.txtWEMin.BackColor = System.Drawing.SystemColors.Window
        Me.txtWEMin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWEMin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWEMin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtWEMin.Location = New System.Drawing.Point(73, 95)
        Me.txtWEMin.MaxLength = 1
        Me.txtWEMin.Name = "txtWEMin"
        Me.txtWEMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtWEMin.Size = New System.Drawing.Size(17, 20)
        Me.txtWEMin.TabIndex = 10
        Me.ToolTipFormSRF.SetToolTip(Me.txtWEMin, "Range 0 to 9")
        '
        'lblDsDist
        '
        Me.lblDsDist.BackColor = System.Drawing.SystemColors.Window
        Me.lblDsDist.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDsDist.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDsDist.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDsDist.Location = New System.Drawing.Point(449, 112)
        Me.lblDsDist.Name = "lblDsDist"
        Me.lblDsDist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDsDist.Size = New System.Drawing.Size(65, 17)
        Me.lblDsDist.TabIndex = 64
        Me.lblDsDist.Text = "Ds distance"
        Me.ToolTipFormSRF.SetToolTip(Me.lblDsDist, "Distance to dip short horizon")
        Me.lblDsDist.Visible = False
        '
        'lblIE
        '
        Me.lblIE.BackColor = System.Drawing.SystemColors.Window
        Me.lblIE.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblIE.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIE.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblIE.Location = New System.Drawing.Point(450, 45)
        Me.lblIE.Name = "lblIE"
        Me.lblIE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblIE.Size = New System.Drawing.Size(17, 17)
        Me.lblIE.TabIndex = 50
        Me.lblIE.Text = "IE"
        Me.ToolTipFormSRF.SetToolTip(Me.lblIE, "Index Error")
        '
        'lblHE
        '
        Me.lblHE.BackColor = System.Drawing.SystemColors.Window
        Me.lblHE.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHE.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHE.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHE.Location = New System.Drawing.Point(449, 89)
        Me.lblHE.Name = "lblHE"
        Me.lblHE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblHE.Size = New System.Drawing.Size(22, 17)
        Me.lblHE.TabIndex = 61
        Me.lblHE.Text = "HE"
        Me.ToolTipFormSRF.SetToolTip(Me.lblHE, "Height of Eye")
        '
        'lblHs
        '
        Me.lblHs.BackColor = System.Drawing.SystemColors.Window
        Me.lblHs.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHs.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHs.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHs.Location = New System.Drawing.Point(449, 22)
        Me.lblHs.Name = "lblHs"
        Me.lblHs.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblHs.Size = New System.Drawing.Size(22, 17)
        Me.lblHs.TabIndex = 43
        Me.lblHs.Text = "hs"
        Me.ToolTipFormSRF.SetToolTip(Me.lblHs, "Sextant Altitude")
        '
        'lblHsFormat
        '
        Me.lblHsFormat.BackColor = System.Drawing.SystemColors.Window
        Me.lblHsFormat.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHsFormat.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHsFormat.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHsFormat.Location = New System.Drawing.Point(489, 3)
        Me.lblHsFormat.Name = "lblHsFormat"
        Me.lblHsFormat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblHsFormat.Size = New System.Drawing.Size(65, 13)
        Me.lblHsFormat.TabIndex = 40
        Me.lblHsFormat.Text = "hs/IE format"
        Me.ToolTipFormSRF.SetToolTip(Me.lblHsFormat, "Sextant Altitude/Index Error format")
        '
        'lblZD
        '
        Me.lblZD.BackColor = System.Drawing.SystemColors.Window
        Me.lblZD.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblZD.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZD.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblZD.Location = New System.Drawing.Point(41, 162)
        Me.lblZD.Name = "lblZD"
        Me.lblZD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblZD.Size = New System.Drawing.Size(22, 17)
        Me.lblZD.TabIndex = 18
        Me.lblZD.Text = "ZD"
        Me.ToolTipFormSRF.SetToolTip(Me.lblZD, "Zone Description")
        '
        'lblZDAutoManual
        '
        Me.lblZDAutoManual.BackColor = System.Drawing.SystemColors.Window
        Me.lblZDAutoManual.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblZDAutoManual.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZDAutoManual.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblZDAutoManual.Location = New System.Drawing.Point(41, 131)
        Me.lblZDAutoManual.Name = "lblZDAutoManual"
        Me.lblZDAutoManual.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblZDAutoManual.Size = New System.Drawing.Size(22, 17)
        Me.lblZDAutoManual.TabIndex = 15
        Me.lblZDAutoManual.Text = "ZD"
        Me.ToolTipFormSRF.SetToolTip(Me.lblZDAutoManual, "Zone Description ")
        '
        'lblWE
        '
        Me.lblWE.BackColor = System.Drawing.SystemColors.Window
        Me.lblWE.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblWE.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWE.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblWE.Location = New System.Drawing.Point(41, 98)
        Me.lblWE.Name = "lblWE"
        Me.lblWE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblWE.Size = New System.Drawing.Size(25, 17)
        Me.lblWE.TabIndex = 9
        Me.lblWE.Text = "WE"
        Me.ToolTipFormSRF.SetToolTip(Me.lblWE, "Watch Error")
        '
        'cboStars
        '
        Me.cboStars.BackColor = System.Drawing.SystemColors.Window
        Me.cboStars.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboStars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStars.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStars.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboStars.Items.AddRange(New Object() {"NA vals. of SHA/Dec", "Accurate vals. of SHA/Dec"})
        Me.cboStars.Location = New System.Drawing.Point(276, 84)
        Me.cboStars.Name = "cboStars"
        Me.cboStars.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboStars.Size = New System.Drawing.Size(161, 22)
        Me.cboStars.TabIndex = 97
        '
        'cboLo
        '
        Me.cboLo.BackColor = System.Drawing.SystemColors.Window
        Me.cboLo.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboLo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboLo.Items.AddRange(New Object() {"W", "E"})
        Me.cboLo.Location = New System.Drawing.Point(393, 135)
        Me.cboLo.Name = "cboLo"
        Me.cboLo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboLo.Size = New System.Drawing.Size(41, 22)
        Me.cboLo.TabIndex = 37
        '
        'cboL
        '
        Me.cboL.BackColor = System.Drawing.SystemColors.Window
        Me.cboL.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboL.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboL.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboL.Items.AddRange(New Object() {"N", "S"})
        Me.cboL.Location = New System.Drawing.Point(393, 112)
        Me.cboL.Name = "cboL"
        Me.cboL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboL.Size = New System.Drawing.Size(41, 22)
        Me.cboL.TabIndex = 31
        '
        'cboSun
        '
        Me.cboSun.BackColor = System.Drawing.SystemColors.Window
        Me.cboSun.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboSun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSun.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSun.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboSun.Items.AddRange(New Object() {"NA val. of hourly GHA/d", "Accurate val. of hourly GHA/d"})
        Me.cboSun.Location = New System.Drawing.Point(276, 84)
        Me.cboSun.Name = "cboSun"
        Me.cboSun.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboSun.Size = New System.Drawing.Size(161, 22)
        Me.cboSun.TabIndex = 96
        '
        'cmdFix
        '
        Me.cmdFix.BackColor = System.Drawing.SystemColors.Control
        Me.cmdFix.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFix.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFix.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdFix.Location = New System.Drawing.Point(285, 837)
        Me.cmdFix.Name = "cmdFix"
        Me.cmdFix.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdFix.Size = New System.Drawing.Size(140, 23)
        Me.cmdFix.TabIndex = 80
        Me.cmdFix.Text = "&Establish Fix"
        Me.cmdFix.UseVisualStyleBackColor = False
        Me.cmdFix.Visible = False
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSave.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSave.Location = New System.Drawing.Point(285, 808)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSave.Size = New System.Drawing.Size(140, 23)
        Me.cmdSave.TabIndex = 79
        Me.cmdSave.Text = "&Save Sight Data for Fix"
        Me.cmdSave.UseVisualStyleBackColor = False
        Me.cmdSave.Visible = False
        '
        'cboZDm
        '
        Me.cboZDm.BackColor = System.Drawing.SystemColors.Window
        Me.cboZDm.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboZDm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboZDm.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboZDm.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboZDm.Items.AddRange(New Object() {"00", "30", "45"})
        Me.cboZDm.Location = New System.Drawing.Point(105, 159)
        Me.cboZDm.Name = "cboZDm"
        Me.cboZDm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboZDm.Size = New System.Drawing.Size(41, 22)
        Me.cboZDm.TabIndex = 21
        Me.cboZDm.Visible = False
        '
        'cboPolaris
        '
        Me.cboPolaris.BackColor = System.Drawing.SystemColors.Window
        Me.cboPolaris.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboPolaris.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPolaris.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPolaris.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboPolaris.Items.AddRange(New Object() {"Latitude by altitude of Polaris", "Full reduction of Polaris sight"})
        Me.cboPolaris.Location = New System.Drawing.Point(276, 84)
        Me.cboPolaris.Name = "cboPolaris"
        Me.cboPolaris.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboPolaris.Size = New System.Drawing.Size(161, 22)
        Me.cboPolaris.TabIndex = 27
        Me.cboPolaris.Visible = False
        '
        'cboDsUnit
        '
        Me.cboDsUnit.BackColor = System.Drawing.SystemColors.Window
        Me.cboDsUnit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboDsUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDsUnit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDsUnit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboDsUnit.Items.AddRange(New Object() {"feet", "yards", "meters", "statute miles", "nautical miles"})
        Me.cboDsUnit.Location = New System.Drawing.Point(565, 108)
        Me.cboDsUnit.Name = "cboDsUnit"
        Me.cboDsUnit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboDsUnit.Size = New System.Drawing.Size(95, 22)
        Me.cboDsUnit.TabIndex = 66
        Me.cboDsUnit.Visible = False
        '
        'Framehs
        '
        Me.Framehs.BackColor = System.Drawing.SystemColors.Window
        Me.Framehs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Framehs.Controls.Add(Me.optHsDMS)
        Me.Framehs.Controls.Add(Me.optHsDMm)
        Me.Framehs.Cursor = System.Windows.Forms.Cursors.Default
        Me.Framehs.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Framehs.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Framehs.Location = New System.Drawing.Point(559, 1)
        Me.Framehs.Name = "Framehs"
        Me.Framehs.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Framehs.Size = New System.Drawing.Size(128, 18)
        Me.Framehs.TabIndex = 77
        Me.Framehs.Text = "Frame2"
        '
        'optHsDMS
        '
        Me.optHsDMS.BackColor = System.Drawing.SystemColors.Window
        Me.optHsDMS.Cursor = System.Windows.Forms.Cursors.Default
        Me.optHsDMS.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optHsDMS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optHsDMS.Location = New System.Drawing.Point(69, 0)
        Me.optHsDMS.Name = "optHsDMS"
        Me.optHsDMS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optHsDMS.Size = New System.Drawing.Size(49, 18)
        Me.optHsDMS.TabIndex = 42
        Me.optHsDMS.TabStop = True
        Me.optHsDMS.Text = "DMS"
        Me.optHsDMS.UseVisualStyleBackColor = False
        '
        'optHsDMm
        '
        Me.optHsDMm.BackColor = System.Drawing.SystemColors.Window
        Me.optHsDMm.Checked = True
        Me.optHsDMm.Cursor = System.Windows.Forms.Cursors.Default
        Me.optHsDMm.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optHsDMm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optHsDMm.Location = New System.Drawing.Point(6, 0)
        Me.optHsDMm.Name = "optHsDMm"
        Me.optHsDMm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optHsDMm.Size = New System.Drawing.Size(57, 18)
        Me.optHsDMm.TabIndex = 41
        Me.optHsDMm.TabStop = True
        Me.optHsDMm.Text = "DM.m"
        Me.optHsDMm.UseVisualStyleBackColor = False
        '
        'FrameZD
        '
        Me.FrameZD.BackColor = System.Drawing.SystemColors.Window
        Me.FrameZD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FrameZD.Controls.Add(Me.optZDUT)
        Me.FrameZD.Controls.Add(Me.optZDManual)
        Me.FrameZD.Controls.Add(Me.optZDAuto)
        Me.FrameZD.Cursor = System.Windows.Forms.Cursors.Default
        Me.FrameZD.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FrameZD.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FrameZD.Location = New System.Drawing.Point(65, 126)
        Me.FrameZD.Name = "FrameZD"
        Me.FrameZD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FrameZD.Size = New System.Drawing.Size(192, 25)
        Me.FrameZD.TabIndex = 76
        '
        'optZDUT
        '
        Me.optZDUT.BackColor = System.Drawing.SystemColors.Window
        Me.optZDUT.Cursor = System.Windows.Forms.Cursors.Default
        Me.optZDUT.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optZDUT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optZDUT.Location = New System.Drawing.Point(114, 3)
        Me.optZDUT.Name = "optZDUT"
        Me.optZDUT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optZDUT.Size = New System.Drawing.Size(75, 17)
        Me.optZDUT.TabIndex = 100
        Me.optZDUT.TabStop = True
        Me.optZDUT.Text = "UT (GMT)"
        Me.optZDUT.UseVisualStyleBackColor = False
        '
        'cmdReduce
        '
        Me.cmdReduce.BackColor = System.Drawing.Color.Blue
        Me.cmdReduce.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdReduce.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReduce.ForeColor = System.Drawing.Color.White
        Me.cmdReduce.Location = New System.Drawing.Point(275, 175)
        Me.cmdReduce.Name = "cmdReduce"
        Me.cmdReduce.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdReduce.Size = New System.Drawing.Size(161, 25)
        Me.cmdReduce.TabIndex = 75
        Me.cmdReduce.Text = "&Reduce Sight"
        Me.cmdReduce.UseVisualStyleBackColor = False
        '
        'cboPressure
        '
        Me.cboPressure.BackColor = System.Drawing.SystemColors.Window
        Me.cboPressure.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboPressure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPressure.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPressure.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboPressure.Items.AddRange(New Object() {"in Hg", "mbar"})
        Me.cboPressure.Location = New System.Drawing.Point(641, 155)
        Me.cboPressure.Name = "cboPressure"
        Me.cboPressure.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboPressure.Size = New System.Drawing.Size(57, 22)
        Me.cboPressure.TabIndex = 74
        Me.cboPressure.Visible = False
        '
        'cboTemperature
        '
        Me.cboTemperature.BackColor = System.Drawing.SystemColors.Window
        Me.cboTemperature.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboTemperature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTemperature.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTemperature.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboTemperature.Items.AddRange(New Object() {"F ", "C "})
        Me.cboTemperature.Location = New System.Drawing.Point(521, 155)
        Me.cboTemperature.Name = "cboTemperature"
        Me.cboTemperature.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboTemperature.Size = New System.Drawing.Size(33, 22)
        Me.cboTemperature.TabIndex = 71
        Me.cboTemperature.Visible = False
        '
        'cboIE
        '
        Me.cboIE.BackColor = System.Drawing.SystemColors.Window
        Me.cboIE.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboIE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboIE.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboIE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboIE.Items.AddRange(New Object() {"on the arc", "off the arc (val.)", "off the arc (rdg.)"})
        Me.cboIE.Location = New System.Drawing.Point(604, 41)
        Me.cboIE.Name = "cboIE"
        Me.cboIE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboIE.Size = New System.Drawing.Size(105, 22)
        Me.cboIE.TabIndex = 56
        '
        'cboHE
        '
        Me.cboHE.BackColor = System.Drawing.SystemColors.Window
        Me.cboHE.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboHE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHE.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboHE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboHE.Items.AddRange(New Object() {"ft", "in", "m ", "cm"})
        Me.cboHE.Location = New System.Drawing.Point(521, 85)
        Me.cboHE.Name = "cboHE"
        Me.cboHE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboHE.Size = New System.Drawing.Size(41, 22)
        Me.cboHE.TabIndex = 63
        '
        'cboBody
        '
        Me.cboBody.BackColor = System.Drawing.SystemColors.Window
        Me.cboBody.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboBody.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBody.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBody.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboBody.Items.AddRange(New Object() {"Sun", "Moon", "Venus", "Mars", "Jupiter", "Saturn", "Acamar", "Achernar", "Acrux", "Adhara", "Aldebaran", "Alioth", "Alkaid", "Al Na'ir", "Alnilam", "Alphard", "Alphecca", "Alpheratz", "Altair", "Ankaa", "Antares", "Arcturus", "Atria", "Avior", "Bellatrix", "Betelgeuse", "Canopus", "Capella", "Deneb", "Denebola", "Diphda", "Dubhe", "Elnath", "Eltanin", "Enif", "Fomalhaut", "Gacrux", "Gienah", "Hadar", "Hamal", "Kaus Australis", "Kochab", "Markab", "Menkar", "Menkent", "Miaplacidus", "Mirfak", "Nunki", "Peacock", "Polaris", "Pollux", "Procyon", "Rasalhague", "Regulus", "Rigel", "Rigil Kentaurus", "Sabik", "Schedar", "Shaula", "Sirius", "Spica", "Suhail", "Vega", "Zubenelgenubi" & Global.Microsoft.VisualBasic.ChrW(9)})
        Me.cboBody.Location = New System.Drawing.Point(337, 27)
        Me.cboBody.Name = "cboBody"
        Me.cboBody.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboBody.Size = New System.Drawing.Size(97, 22)
        Me.cboBody.TabIndex = 26
        '
        'cboWE
        '
        Me.cboWE.BackColor = System.Drawing.SystemColors.Window
        Me.cboWE.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboWE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboWE.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboWE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboWE.Items.AddRange(New Object() {"fast", "slow"})
        Me.cboWE.Location = New System.Drawing.Point(177, 95)
        Me.cboWE.Name = "cboWE"
        Me.cboWE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboWE.Size = New System.Drawing.Size(49, 22)
        Me.cboWE.TabIndex = 14
        '
        'FrameTP
        '
        Me.FrameTP.BackColor = System.Drawing.SystemColors.Window
        Me.FrameTP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FrameTP.Controls.Add(Me.optStdTPNo)
        Me.FrameTP.Controls.Add(Me.optStdTPYes)
        Me.FrameTP.Cursor = System.Windows.Forms.Cursors.Default
        Me.FrameTP.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FrameTP.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FrameTP.Location = New System.Drawing.Point(566, 133)
        Me.FrameTP.Name = "FrameTP"
        Me.FrameTP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FrameTP.Size = New System.Drawing.Size(104, 20)
        Me.FrameTP.TabIndex = 91
        '
        'optStdTPNo
        '
        Me.optStdTPNo.BackColor = System.Drawing.SystemColors.Window
        Me.optStdTPNo.Cursor = System.Windows.Forms.Cursors.Default
        Me.optStdTPNo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optStdTPNo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optStdTPNo.Location = New System.Drawing.Point(56, 1)
        Me.optStdTPNo.Name = "optStdTPNo"
        Me.optStdTPNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optStdTPNo.Size = New System.Drawing.Size(41, 18)
        Me.optStdTPNo.TabIndex = 94
        Me.optStdTPNo.TabStop = True
        Me.optStdTPNo.Text = "No"
        Me.optStdTPNo.UseVisualStyleBackColor = False
        '
        'optStdTPYes
        '
        Me.optStdTPYes.BackColor = System.Drawing.SystemColors.Window
        Me.optStdTPYes.Checked = True
        Me.optStdTPYes.Cursor = System.Windows.Forms.Cursors.Default
        Me.optStdTPYes.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optStdTPYes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optStdTPYes.Location = New System.Drawing.Point(8, 1)
        Me.optStdTPYes.Name = "optStdTPYes"
        Me.optStdTPYes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optStdTPYes.Size = New System.Drawing.Size(46, 18)
        Me.optStdTPYes.TabIndex = 93
        Me.optStdTPYes.TabStop = True
        Me.optStdTPYes.Text = "Yes"
        Me.optStdTPYes.UseVisualStyleBackColor = False
        '
        'FrameHo
        '
        Me.FrameHo.BackColor = System.Drawing.SystemColors.Window
        Me.FrameHo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FrameHo.Controls.Add(Me.optHoParameters)
        Me.FrameHo.Controls.Add(Me.optHoSRForm)
        Me.FrameHo.Cursor = System.Windows.Forms.Cursors.Default
        Me.FrameHo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FrameHo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FrameHo.Location = New System.Drawing.Point(563, 180)
        Me.FrameHo.Name = "FrameHo"
        Me.FrameHo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FrameHo.Size = New System.Drawing.Size(144, 22)
        Me.FrameHo.TabIndex = 92
        '
        'lblZDDST
        '
        Me.lblZDDST.BackColor = System.Drawing.SystemColors.Window
        Me.lblZDDST.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblZDDST.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZDDST.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblZDDST.Location = New System.Drawing.Point(186, 162)
        Me.lblZDDST.Name = "lblZDDST"
        Me.lblZDDST.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblZDDST.Size = New System.Drawing.Size(33, 13)
        Me.lblZDDST.TabIndex = 89
        Me.lblZDDST.Text = "DST"
        '
        'lblIEsec
        '
        Me.lblIEsec.BackColor = System.Drawing.SystemColors.Window
        Me.lblIEsec.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblIEsec.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIEsec.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblIEsec.Location = New System.Drawing.Point(594, 40)
        Me.lblIEsec.Name = "lblIEsec"
        Me.lblIEsec.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblIEsec.Size = New System.Drawing.Size(9, 17)
        Me.lblIEsec.TabIndex = 87
        Me.lblIEsec.Text = """"
        Me.lblIEsec.Visible = False
        '
        'lblHoCorrs
        '
        Me.lblHoCorrs.BackColor = System.Drawing.SystemColors.Window
        Me.lblHoCorrs.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHoCorrs.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoCorrs.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHoCorrs.Location = New System.Drawing.Point(450, 184)
        Me.lblHoCorrs.Name = "lblHoCorrs"
        Me.lblHoCorrs.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblHoCorrs.Size = New System.Drawing.Size(113, 13)
        Me.lblHoCorrs.TabIndex = 84
        Me.lblHoCorrs.Text = "Show Ho corrections as"
        '
        'lblSightNo
        '
        Me.lblSightNo.BackColor = System.Drawing.SystemColors.Window
        Me.lblSightNo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSightNo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSightNo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSightNo.Location = New System.Drawing.Point(44, 30)
        Me.lblSightNo.Name = "lblSightNo"
        Me.lblSightNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSightNo.Size = New System.Drawing.Size(55, 17)
        Me.lblSightNo.TabIndex = 23
        Me.lblSightNo.Text = "Sight No."
        '
        'lblIEdeg
        '
        Me.lblIEdeg.BackColor = System.Drawing.SystemColors.Window
        Me.lblIEdeg.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblIEdeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIEdeg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblIEdeg.Location = New System.Drawing.Point(512, 40)
        Me.lblIEdeg.Name = "lblIEdeg"
        Me.lblIEdeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblIEdeg.Size = New System.Drawing.Size(9, 17)
        Me.lblIEdeg.TabIndex = 52
        Me.lblIEdeg.Text = "°"
        '
        'lblZDm
        '
        Me.lblZDm.BackColor = System.Drawing.SystemColors.Window
        Me.lblZDm.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblZDm.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZDm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblZDm.Location = New System.Drawing.Point(146, 160)
        Me.lblZDm.Name = "lblZDm"
        Me.lblZDm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblZDm.Size = New System.Drawing.Size(15, 17)
        Me.lblZDm.TabIndex = 22
        Me.lblZDm.Text = "m"
        Me.lblZDm.Visible = False
        '
        'lblZDh
        '
        Me.lblZDh.BackColor = System.Drawing.SystemColors.Window
        Me.lblZDh.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblZDh.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZDh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblZDh.Location = New System.Drawing.Point(90, 161)
        Me.lblZDh.Name = "lblZDh"
        Me.lblZDh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblZDh.Size = New System.Drawing.Size(12, 17)
        Me.lblZDh.TabIndex = 20
        Me.lblZDh.Text = "h"
        Me.lblZDh.Visible = False
        '
        'lblHorizon
        '
        Me.lblHorizon.BackColor = System.Drawing.SystemColors.Window
        Me.lblHorizon.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHorizon.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHorizon.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHorizon.Location = New System.Drawing.Point(449, 65)
        Me.lblHorizon.Name = "lblHorizon"
        Me.lblHorizon.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblHorizon.Size = New System.Drawing.Size(49, 17)
        Me.lblHorizon.TabIndex = 57
        Me.lblHorizon.Text = "Hor."
        '
        'lblPressure
        '
        Me.lblPressure.BackColor = System.Drawing.SystemColors.Window
        Me.lblPressure.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPressure.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPressure.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPressure.Location = New System.Drawing.Point(557, 157)
        Me.lblPressure.Name = "lblPressure"
        Me.lblPressure.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPressure.Size = New System.Drawing.Size(38, 17)
        Me.lblPressure.TabIndex = 72
        Me.lblPressure.Text = "Press."
        Me.lblPressure.Visible = False
        '
        'lblTempDeg
        '
        Me.lblTempDeg.BackColor = System.Drawing.SystemColors.Window
        Me.lblTempDeg.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTempDeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTempDeg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTempDeg.Location = New System.Drawing.Point(512, 155)
        Me.lblTempDeg.Name = "lblTempDeg"
        Me.lblTempDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTempDeg.Size = New System.Drawing.Size(9, 17)
        Me.lblTempDeg.TabIndex = 70
        Me.lblTempDeg.Text = "°"
        Me.lblTempDeg.Visible = False
        '
        'lblTemperature
        '
        Me.lblTemperature.BackColor = System.Drawing.SystemColors.Window
        Me.lblTemperature.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTemperature.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTemperature.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTemperature.Location = New System.Drawing.Point(449, 158)
        Me.lblTemperature.Name = "lblTemperature"
        Me.lblTemperature.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTemperature.Size = New System.Drawing.Size(33, 17)
        Me.lblTemperature.TabIndex = 68
        Me.lblTemperature.Text = "Temp."
        Me.lblTemperature.Visible = False
        '
        'lblStdT_P
        '
        Me.lblStdT_P.BackColor = System.Drawing.SystemColors.Window
        Me.lblStdT_P.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblStdT_P.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStdT_P.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblStdT_P.Location = New System.Drawing.Point(449, 134)
        Me.lblStdT_P.Name = "lblStdT_P"
        Me.lblStdT_P.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblStdT_P.Size = New System.Drawing.Size(115, 17)
        Me.lblStdT_P.TabIndex = 67
        Me.lblStdT_P.Text = "Std. temp. and press."
        '
        'lblIEMin
        '
        Me.lblIEMin.BackColor = System.Drawing.SystemColors.Window
        Me.lblIEMin.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblIEMin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIEMin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblIEMin.Location = New System.Drawing.Point(554, 40)
        Me.lblIEMin.Name = "lblIEMin"
        Me.lblIEMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblIEMin.Size = New System.Drawing.Size(9, 17)
        Me.lblIEMin.TabIndex = 55
        Me.lblIEMin.Text = "'"
        '
        'lblHsSec
        '
        Me.lblHsSec.BackColor = System.Drawing.SystemColors.Window
        Me.lblHsSec.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHsSec.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHsSec.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHsSec.Location = New System.Drawing.Point(594, 21)
        Me.lblHsSec.Name = "lblHsSec"
        Me.lblHsSec.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblHsSec.Size = New System.Drawing.Size(9, 17)
        Me.lblHsSec.TabIndex = 49
        Me.lblHsSec.Text = """"
        Me.lblHsSec.Visible = False
        '
        'lblHsMin
        '
        Me.lblHsMin.BackColor = System.Drawing.SystemColors.Window
        Me.lblHsMin.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHsMin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHsMin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHsMin.Location = New System.Drawing.Point(554, 21)
        Me.lblHsMin.Name = "lblHsMin"
        Me.lblHsMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblHsMin.Size = New System.Drawing.Size(9, 17)
        Me.lblHsMin.TabIndex = 47
        Me.lblHsMin.Text = "'"
        '
        'lblHsDeg
        '
        Me.lblHsDeg.BackColor = System.Drawing.SystemColors.Window
        Me.lblHsDeg.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHsDeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHsDeg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHsDeg.Location = New System.Drawing.Point(512, 20)
        Me.lblHsDeg.Name = "lblHsDeg"
        Me.lblHsDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblHsDeg.Size = New System.Drawing.Size(9, 17)
        Me.lblHsDeg.TabIndex = 45
        Me.lblHsDeg.Text = "°"
        '
        'lblLoMin
        '
        Me.lblLoMin.BackColor = System.Drawing.SystemColors.Window
        Me.lblLoMin.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLoMin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoMin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLoMin.Location = New System.Drawing.Point(386, 135)
        Me.lblLoMin.Name = "lblLoMin"
        Me.lblLoMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLoMin.Size = New System.Drawing.Size(9, 17)
        Me.lblLoMin.TabIndex = 39
        Me.lblLoMin.Text = "'"
        '
        'lblLoDeg
        '
        Me.lblLoDeg.BackColor = System.Drawing.SystemColors.Window
        Me.lblLoDeg.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLoDeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoDeg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLoDeg.Location = New System.Drawing.Point(344, 135)
        Me.lblLoDeg.Name = "lblLoDeg"
        Me.lblLoDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLoDeg.Size = New System.Drawing.Size(9, 17)
        Me.lblLoDeg.TabIndex = 38
        Me.lblLoDeg.Text = "°"
        '
        'lblDRLo
        '
        Me.lblDRLo.BackColor = System.Drawing.SystemColors.Window
        Me.lblDRLo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDRLo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDRLo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDRLo.Location = New System.Drawing.Point(273, 138)
        Me.lblDRLo.Name = "lblDRLo"
        Me.lblDRLo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDRLo.Size = New System.Drawing.Size(38, 13)
        Me.lblDRLo.TabIndex = 34
        Me.lblDRLo.Text = "DR Lo"
        '
        'lblLMin
        '
        Me.lblLMin.BackColor = System.Drawing.SystemColors.Window
        Me.lblLMin.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLMin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLMin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLMin.Location = New System.Drawing.Point(386, 111)
        Me.lblLMin.Name = "lblLMin"
        Me.lblLMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLMin.Size = New System.Drawing.Size(9, 17)
        Me.lblLMin.TabIndex = 33
        Me.lblLMin.Text = "'"
        '
        'lblLDeg
        '
        Me.lblLDeg.BackColor = System.Drawing.SystemColors.Window
        Me.lblLDeg.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLDeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLDeg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLDeg.Location = New System.Drawing.Point(344, 112)
        Me.lblLDeg.Name = "lblLDeg"
        Me.lblLDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLDeg.Size = New System.Drawing.Size(9, 17)
        Me.lblLDeg.TabIndex = 32
        Me.lblLDeg.Text = "°"
        '
        'lblDRL
        '
        Me.lblDRL.BackColor = System.Drawing.SystemColors.Window
        Me.lblDRL.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDRL.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDRL.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDRL.Location = New System.Drawing.Point(273, 115)
        Me.lblDRL.Name = "lblDRL"
        Me.lblDRL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDRL.Size = New System.Drawing.Size(30, 13)
        Me.lblDRL.TabIndex = 28
        Me.lblDRL.Text = "DR L"
        '
        'lblBody
        '
        Me.lblBody.BackColor = System.Drawing.SystemColors.Window
        Me.lblBody.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblBody.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBody.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblBody.Location = New System.Drawing.Point(273, 30)
        Me.lblBody.Name = "lblBody"
        Me.lblBody.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBody.Size = New System.Drawing.Size(35, 17)
        Me.lblBody.TabIndex = 25
        Me.lblBody.Text = "Body"
        '
        'lblWEsec
        '
        Me.lblWEsec.BackColor = System.Drawing.SystemColors.Window
        Me.lblWEsec.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblWEsec.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWEsec.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblWEsec.Location = New System.Drawing.Point(146, 98)
        Me.lblWEsec.Name = "lblWEsec"
        Me.lblWEsec.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblWEsec.Size = New System.Drawing.Size(26, 17)
        Me.lblWEsec.TabIndex = 13
        Me.lblWEsec.Text = "sec"
        '
        'lblWEmin
        '
        Me.lblWEmin.BackColor = System.Drawing.SystemColors.Window
        Me.lblWEmin.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblWEmin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWEmin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblWEmin.Location = New System.Drawing.Point(90, 98)
        Me.lblWEmin.Name = "lblWEmin"
        Me.lblWEmin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblWEmin.Size = New System.Drawing.Size(23, 17)
        Me.lblWEmin.TabIndex = 11
        Me.lblWEmin.Text = "min"
        '
        'TimeTxtBx
        '
        Me.TimeTxtBx.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TimeTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TimeTxtBx.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeTxtBx.Location = New System.Drawing.Point(33, 205)
        Me.TimeTxtBx.Multiline = False
        Me.TimeTxtBx.Name = "TimeTxtBx"
        Me.TimeTxtBx.ReadOnly = True
        Me.TimeTxtBx.Size = New System.Drawing.Size(228, 19)
        Me.TimeTxtBx.TabIndex = 101
        Me.TimeTxtBx.Text = ""
        '
        'LHATxtBx
        '
        Me.LHATxtBx.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.LHATxtBx.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LHATxtBx.Location = New System.Drawing.Point(33, 397)
        Me.LHATxtBx.Multiline = False
        Me.LHATxtBx.Name = "LHATxtBx"
        Me.LHATxtBx.ReadOnly = True
        Me.LHATxtBx.Size = New System.Drawing.Size(228, 19)
        Me.LHATxtBx.TabIndex = 102
        Me.LHATxtBx.Text = ""
        '
        'AltitudeTxtBx
        '
        Me.AltitudeTxtBx.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.AltitudeTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AltitudeTxtBx.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AltitudeTxtBx.ForeColor = System.Drawing.SystemColors.WindowText
        Me.AltitudeTxtBx.Location = New System.Drawing.Point(449, 205)
        Me.AltitudeTxtBx.Multiline = False
        Me.AltitudeTxtBx.Name = "AltitudeTxtBx"
        Me.AltitudeTxtBx.ReadOnly = True
        Me.AltitudeTxtBx.Size = New System.Drawing.Size(260, 19)
        Me.AltitudeTxtBx.TabIndex = 105
        Me.AltitudeTxtBx.Text = ""
        '
        'IntAzTxtBx
        '
        Me.IntAzTxtBx.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.IntAzTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IntAzTxtBx.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IntAzTxtBx.Location = New System.Drawing.Point(33, 625)
        Me.IntAzTxtBx.Name = "IntAzTxtBx"
        Me.IntAzTxtBx.ReadOnly = True
        Me.IntAzTxtBx.Size = New System.Drawing.Size(676, 175)
        Me.IntAzTxtBx.TabIndex = 106
        Me.IntAzTxtBx.Text = ""
        '
        'ExitBtn
        '
        Me.ExitBtn.BackColor = System.Drawing.Color.Red
        Me.ExitBtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExitBtn.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ExitBtn.Location = New System.Drawing.Point(626, 845)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ExitBtn.Size = New System.Drawing.Size(80, 25)
        Me.ExitBtn.TabIndex = 107
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = False
        '
        'EqTPicBx
        '
        Me.EqTPicBx.Enabled = False
        Me.EqTPicBx.ErrorImage = Nothing
        Me.EqTPicBx.InitialImage = Nothing
        Me.EqTPicBx.Location = New System.Drawing.Point(268, 322)
        Me.EqTPicBx.Name = "EqTPicBx"
        Me.EqTPicBx.Size = New System.Drawing.Size(175, 181)
        Me.EqTPicBx.TabIndex = 108
        Me.EqTPicBx.TabStop = False
        Me.EqTPicBx.Visible = False
        '
        'FrameHorizon
        '
        Me.FrameHorizon.BackColor = System.Drawing.SystemColors.Window
        Me.FrameHorizon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FrameHorizon.Controls.Add(Me.optHorizonBubble)
        Me.FrameHorizon.Controls.Add(Me.optHorizonDipShort)
        Me.FrameHorizon.Controls.Add(Me.optHorizonArtificial)
        Me.FrameHorizon.Controls.Add(Me.optHorizonNatural)
        Me.FrameHorizon.Cursor = System.Windows.Forms.Cursors.Default
        Me.FrameHorizon.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FrameHorizon.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FrameHorizon.Location = New System.Drawing.Point(479, 64)
        Me.FrameHorizon.Name = "FrameHorizon"
        Me.FrameHorizon.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FrameHorizon.Size = New System.Drawing.Size(230, 20)
        Me.FrameHorizon.TabIndex = 117
        Me.FrameHorizon.Text = "Frame4"
        '
        'optHorizonBubble
        '
        Me.optHorizonBubble.BackColor = System.Drawing.SystemColors.Window
        Me.optHorizonBubble.Cursor = System.Windows.Forms.Cursors.Default
        Me.optHorizonBubble.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optHorizonBubble.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optHorizonBubble.Location = New System.Drawing.Point(175, 0)
        Me.optHorizonBubble.Name = "optHorizonBubble"
        Me.optHorizonBubble.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optHorizonBubble.Size = New System.Drawing.Size(57, 18)
        Me.optHorizonBubble.TabIndex = 104
        Me.optHorizonBubble.TabStop = True
        Me.optHorizonBubble.Text = "Bubble"
        Me.optHorizonBubble.UseVisualStyleBackColor = False
        '
        'optHorizonDipShort
        '
        Me.optHorizonDipShort.BackColor = System.Drawing.SystemColors.Window
        Me.optHorizonDipShort.Cursor = System.Windows.Forms.Cursors.Default
        Me.optHorizonDipShort.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optHorizonDipShort.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optHorizonDipShort.Location = New System.Drawing.Point(113, 0)
        Me.optHorizonDipShort.Name = "optHorizonDipShort"
        Me.optHorizonDipShort.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optHorizonDipShort.Size = New System.Drawing.Size(66, 18)
        Me.optHorizonDipShort.TabIndex = 60
        Me.optHorizonDipShort.TabStop = True
        Me.optHorizonDipShort.Text = "Dip Short"
        Me.optHorizonDipShort.UseVisualStyleBackColor = False
        '
        'optHorizonArtificial
        '
        Me.optHorizonArtificial.BackColor = System.Drawing.SystemColors.Window
        Me.optHorizonArtificial.Cursor = System.Windows.Forms.Cursors.Default
        Me.optHorizonArtificial.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optHorizonArtificial.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optHorizonArtificial.Location = New System.Drawing.Point(59, 0)
        Me.optHorizonArtificial.Name = "optHorizonArtificial"
        Me.optHorizonArtificial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optHorizonArtificial.Size = New System.Drawing.Size(58, 18)
        Me.optHorizonArtificial.TabIndex = 59
        Me.optHorizonArtificial.TabStop = True
        Me.optHorizonArtificial.Text = "Artificial"
        Me.optHorizonArtificial.UseVisualStyleBackColor = False
        '
        'optHorizonNatural
        '
        Me.optHorizonNatural.BackColor = System.Drawing.SystemColors.Window
        Me.optHorizonNatural.Checked = True
        Me.optHorizonNatural.Cursor = System.Windows.Forms.Cursors.Default
        Me.optHorizonNatural.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optHorizonNatural.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optHorizonNatural.Location = New System.Drawing.Point(2, 0)
        Me.optHorizonNatural.Name = "optHorizonNatural"
        Me.optHorizonNatural.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optHorizonNatural.Size = New System.Drawing.Size(57, 18)
        Me.optHorizonNatural.TabIndex = 58
        Me.optHorizonNatural.TabStop = True
        Me.optHorizonNatural.Text = "Natural"
        Me.optHorizonNatural.UseVisualStyleBackColor = False
        '
        'frmLimb
        '
        Me.frmLimb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.frmLimb.Controls.Add(Me.optCenter)
        Me.frmLimb.Controls.Add(Me.optUpper)
        Me.frmLimb.Controls.Add(Me.optLower)
        Me.frmLimb.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmLimb.Location = New System.Drawing.Point(276, 58)
        Me.frmLimb.Name = "frmLimb"
        Me.frmLimb.Size = New System.Drawing.Size(164, 20)
        Me.frmLimb.TabIndex = 119
        '
        'optCenter
        '
        Me.optCenter.AutoSize = True
        Me.optCenter.Location = New System.Drawing.Point(110, 1)
        Me.optCenter.Name = "optCenter"
        Me.optCenter.Size = New System.Drawing.Size(57, 18)
        Me.optCenter.TabIndex = 2
        Me.optCenter.TabStop = True
        Me.optCenter.Text = "Center"
        Me.optCenter.UseVisualStyleBackColor = True
        '
        'optUpper
        '
        Me.optUpper.AutoSize = True
        Me.optUpper.Location = New System.Drawing.Point(60, 1)
        Me.optUpper.Name = "optUpper"
        Me.optUpper.Size = New System.Drawing.Size(54, 18)
        Me.optUpper.TabIndex = 1
        Me.optUpper.TabStop = True
        Me.optUpper.Text = "Upper"
        Me.optUpper.UseVisualStyleBackColor = True
        '
        'optLower
        '
        Me.optLower.AutoSize = True
        Me.optLower.Checked = True
        Me.optLower.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optLower.Location = New System.Drawing.Point(2, 1)
        Me.optLower.Name = "optLower"
        Me.optLower.Size = New System.Drawing.Size(57, 18)
        Me.optLower.TabIndex = 0
        Me.optLower.TabStop = True
        Me.optLower.Text = "Lower"
        Me.optLower.UseVisualStyleBackColor = True
        '
        'LimbTxt
        '
        Me.LimbTxt.BackColor = System.Drawing.SystemColors.Window
        Me.LimbTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LimbTxt.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LimbTxt.Location = New System.Drawing.Point(280, 48)
        Me.LimbTxt.Name = "LimbTxt"
        Me.LimbTxt.ReadOnly = True
        Me.LimbTxt.Size = New System.Drawing.Size(23, 13)
        Me.LimbTxt.TabIndex = 120
        Me.LimbTxt.Text = "Limb"
        '
        'cboPlanets
        '
        Me.cboPlanets.BackColor = System.Drawing.SystemColors.Window
        Me.cboPlanets.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboPlanets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPlanets.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPlanets.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboPlanets.Items.AddRange(New Object() {"NA vals. of v/d", "Accurate vals. of v/d"})
        Me.cboPlanets.Location = New System.Drawing.Point(276, 84)
        Me.cboPlanets.Name = "cboPlanets"
        Me.cboPlanets.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboPlanets.Size = New System.Drawing.Size(161, 22)
        Me.cboPlanets.TabIndex = 121
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CelestialTools.My.Resources.Resources.ABC_white
        Me.PictureBox1.Location = New System.Drawing.Point(428, 809)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(279, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 122
        Me.PictureBox1.TabStop = False
        '
        'DTSight
        '
        Me.DTSight.CustomFormat = "MM / dd / yyyy HH:mm:ss "
        Me.DTSight.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DTSight.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTSight.Location = New System.Drawing.Point(112, 60)
        Me.DTSight.Name = "DTSight"
        Me.DTSight.ShowUpDown = True
        Me.DTSight.Size = New System.Drawing.Size(146, 21)
        Me.DTSight.TabIndex = 124
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.SystemColors.Window
        Me.lblDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDate.Location = New System.Drawing.Point(40, 54)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDate.Size = New System.Drawing.Size(65, 34)
        Me.lblDate.TabIndex = 123
        Me.lblDate.Text = "Sight Date" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Watch Time"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCLSPlot
        '
        Me.btnCLSPlot.BackColor = System.Drawing.Color.Yellow
        Me.btnCLSPlot.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCLSPlot.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCLSPlot.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCLSPlot.Location = New System.Drawing.Point(158, 808)
        Me.btnCLSPlot.Name = "btnCLSPlot"
        Me.btnCLSPlot.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCLSPlot.Size = New System.Drawing.Size(120, 23)
        Me.btnCLSPlot.TabIndex = 125
        Me.btnCLSPlot.Text = "CLS Form Plot"
        Me.btnCLSPlot.UseVisualStyleBackColor = False
        Me.btnCLSPlot.Visible = False
        '
        'btnCustomPlot
        '
        Me.btnCustomPlot.BackColor = System.Drawing.Color.Yellow
        Me.btnCustomPlot.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomPlot.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnCustomPlot.Location = New System.Drawing.Point(158, 837)
        Me.btnCustomPlot.Name = "btnCustomPlot"
        Me.btnCustomPlot.Size = New System.Drawing.Size(120, 23)
        Me.btnCustomPlot.TabIndex = 175
        Me.btnCustomPlot.Text = "Custom Plot Form"
        Me.btnCustomPlot.UseVisualStyleBackColor = False
        Me.btnCustomPlot.Visible = False
        '
        'cmdMerDiag
        '
        Me.cmdMerDiag.BackColor = System.Drawing.Color.Yellow
        Me.cmdMerDiag.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMerDiag.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmdMerDiag.Location = New System.Drawing.Point(33, 837)
        Me.cmdMerDiag.Name = "cmdMerDiag"
        Me.cmdMerDiag.Size = New System.Drawing.Size(120, 23)
        Me.cmdMerDiag.TabIndex = 176
        Me.cmdMerDiag.Text = "Meridian Diagram"
        Me.cmdMerDiag.UseVisualStyleBackColor = False
        Me.cmdMerDiag.Visible = False
        '
        'DGSight
        '
        Me.DGSight.AllowUserToAddRows = False
        Me.DGSight.AllowUserToDeleteRows = False
        Me.DGSight.AllowUserToResizeColumns = False
        Me.DGSight.AllowUserToResizeRows = False
        Me.DGSight.BackgroundColor = System.Drawing.Color.White
        Me.DGSight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGSight.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGSight.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGSight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGSight.Cursor = System.Windows.Forms.Cursors.Default
        Me.DGSight.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGSight.Location = New System.Drawing.Point(268, 226)
        Me.DGSight.MultiSelect = False
        Me.DGSight.Name = "DGSight"
        Me.DGSight.ReadOnly = True
        Me.DGSight.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DGSight.RowHeadersVisible = False
        Me.DGSight.RowTemplate.ReadOnly = True
        Me.DGSight.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DGSight.Size = New System.Drawing.Size(175, 90)
        Me.DGSight.TabIndex = 177
        '
        'SightTxtBx
        '
        Me.SightTxtBx.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.SightTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SightTxtBx.Font = New System.Drawing.Font("Arial Narrow", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SightTxtBx.ForeColor = System.Drawing.SystemColors.WindowText
        Me.SightTxtBx.Location = New System.Drawing.Point(268, 205)
        Me.SightTxtBx.Name = "SightTxtBx"
        Me.SightTxtBx.Size = New System.Drawing.Size(175, 18)
        Me.SightTxtBx.TabIndex = 178
        '
        'DecTxtBx
        '
        Me.DecTxtBx.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.DecTxtBx.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecTxtBx.Location = New System.Drawing.Point(267, 509)
        Me.DecTxtBx.Name = "DecTxtBx"
        Me.DecTxtBx.Size = New System.Drawing.Size(175, 18)
        Me.DecTxtBx.TabIndex = 179
        '
        'DGDec
        '
        Me.DGDec.AllowUserToAddRows = False
        Me.DGDec.AllowUserToDeleteRows = False
        Me.DGDec.AllowUserToResizeColumns = False
        Me.DGDec.AllowUserToResizeRows = False
        Me.DGDec.BackgroundColor = System.Drawing.Color.White
        Me.DGDec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGDec.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGDec.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGDec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGDec.Cursor = System.Windows.Forms.Cursors.Default
        Me.DGDec.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGDec.Location = New System.Drawing.Point(267, 530)
        Me.DGDec.MultiSelect = False
        Me.DGDec.Name = "DGDec"
        Me.DGDec.ReadOnly = True
        Me.DGDec.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DGDec.RowHeadersVisible = False
        Me.DGDec.RowTemplate.ReadOnly = True
        Me.DGDec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DGDec.Size = New System.Drawing.Size(175, 90)
        Me.DGDec.TabIndex = 180
        '
        'DGTime
        '
        Me.DGTime.AllowUserToAddRows = False
        Me.DGTime.AllowUserToDeleteRows = False
        Me.DGTime.AllowUserToResizeColumns = False
        Me.DGTime.AllowUserToResizeRows = False
        Me.DGTime.BackgroundColor = System.Drawing.Color.White
        Me.DGTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGTime.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGTime.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGTime.Cursor = System.Windows.Forms.Cursors.Default
        Me.DGTime.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGTime.Location = New System.Drawing.Point(33, 226)
        Me.DGTime.MultiSelect = False
        Me.DGTime.Name = "DGTime"
        Me.DGTime.ReadOnly = True
        Me.DGTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DGTime.RowHeadersVisible = False
        Me.DGTime.RowTemplate.ReadOnly = True
        Me.DGTime.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DGTime.Size = New System.Drawing.Size(228, 160)
        Me.DGTime.TabIndex = 181
        '
        'DGLHA
        '
        Me.DGLHA.AllowUserToAddRows = False
        Me.DGLHA.AllowUserToDeleteRows = False
        Me.DGLHA.AllowUserToResizeColumns = False
        Me.DGLHA.AllowUserToResizeRows = False
        Me.DGLHA.BackgroundColor = System.Drawing.Color.White
        Me.DGLHA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGLHA.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGLHA.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGLHA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGLHA.Cursor = System.Windows.Forms.Cursors.Default
        Me.DGLHA.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGLHA.Location = New System.Drawing.Point(34, 419)
        Me.DGLHA.MultiSelect = False
        Me.DGLHA.Name = "DGLHA"
        Me.DGLHA.ReadOnly = True
        Me.DGLHA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DGLHA.RowHeadersVisible = False
        Me.DGLHA.RowTemplate.ReadOnly = True
        Me.DGLHA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DGLHA.Size = New System.Drawing.Size(228, 200)
        Me.DGLHA.TabIndex = 182
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
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGAlt.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DGAlt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGAlt.Cursor = System.Windows.Forms.Cursors.Default
        Me.DGAlt.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGAlt.Location = New System.Drawing.Point(449, 226)
        Me.DGAlt.MultiSelect = False
        Me.DGAlt.Name = "DGAlt"
        Me.DGAlt.ReadOnly = True
        Me.DGAlt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DGAlt.RowHeadersVisible = False
        Me.DGAlt.RowTemplate.ReadOnly = True
        Me.DGAlt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DGAlt.Size = New System.Drawing.Size(260, 394)
        Me.DGAlt.TabIndex = 183
        '
        'txtUserInfo
        '
        Me.txtUserInfo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserInfo.HideSelection = False
        Me.txtUserInfo.Location = New System.Drawing.Point(88, 1)
        Me.txtUserInfo.Name = "txtUserInfo"
        Me.txtUserInfo.Size = New System.Drawing.Size(375, 20)
        Me.txtUserInfo.TabIndex = 200
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(33, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 14)
        Me.Label7.TabIndex = 199
        Me.Label7.Text = "User Info"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExpandTimeDiag
        '
        Me.btnExpandTimeDiag.BackColor = System.Drawing.Color.Yellow
        Me.btnExpandTimeDiag.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpandTimeDiag.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnExpandTimeDiag.Location = New System.Drawing.Point(33, 808)
        Me.btnExpandTimeDiag.Name = "btnExpandTimeDiag"
        Me.btnExpandTimeDiag.Size = New System.Drawing.Size(120, 23)
        Me.btnExpandTimeDiag.TabIndex = 201
        Me.btnExpandTimeDiag.Text = "Expand Time Diagram"
        Me.btnExpandTimeDiag.UseVisualStyleBackColor = False
        Me.btnExpandTimeDiag.Visible = False
        '
        'ClearAllBtn
        '
        Me.ClearAllBtn.BackColor = System.Drawing.SystemColors.Control
        Me.ClearAllBtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.ClearAllBtn.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearAllBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ClearAllBtn.Location = New System.Drawing.Point(428, 845)
        Me.ClearAllBtn.Name = "ClearAllBtn"
        Me.ClearAllBtn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ClearAllBtn.Size = New System.Drawing.Size(174, 25)
        Me.ClearAllBtn.TabIndex = 109
        Me.ClearAllBtn.Text = "Clear Sight Report / Retain Input"
        Me.ClearAllBtn.UseVisualStyleBackColor = False
        '
        'cboLLoBy
        '
        Me.cboLLoBy.BackColor = System.Drawing.SystemColors.Window
        Me.cboLLoBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLLoBy.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLLoBy.FormattingEnabled = True
        Me.cboLLoBy.Items.AddRange(New Object() {"DR", "GPS", "KP"})
        Me.cboLLoBy.Location = New System.Drawing.Point(189, 28)
        Me.cboLLoBy.Name = "cboLLoBy"
        Me.cboLLoBy.Size = New System.Drawing.Size(70, 23)
        Me.cboLLoBy.TabIndex = 203
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(134, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 15)
        Me.Label9.TabIndex = 202
        Me.Label9.Text = "L/Lo by:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormSRF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(727, 873)
        Me.Controls.Add(Me.cboLLoBy)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnExpandTimeDiag)
        Me.Controls.Add(Me.txtUserInfo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DGAlt)
        Me.Controls.Add(Me.DGLHA)
        Me.Controls.Add(Me.DGTime)
        Me.Controls.Add(Me.DGDec)
        Me.Controls.Add(Me.DecTxtBx)
        Me.Controls.Add(Me.SightTxtBx)
        Me.Controls.Add(Me.DGSight)
        Me.Controls.Add(Me.cmdMerDiag)
        Me.Controls.Add(Me.btnCustomPlot)
        Me.Controls.Add(Me.btnCLSPlot)
        Me.Controls.Add(Me.DTSight)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LimbTxt)
        Me.Controls.Add(Me.frmLimb)
        Me.Controls.Add(Me.FrameHorizon)
        Me.Controls.Add(Me.AltitudeTxtBx)
        Me.Controls.Add(Me.LHATxtBx)
        Me.Controls.Add(Me.TimeTxtBx)
        Me.Controls.Add(Me.ClearAllBtn)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.IntAzTxtBx)
        Me.Controls.Add(Me.cboStars)
        Me.Controls.Add(Me.cboLo)
        Me.Controls.Add(Me.cboL)
        Me.Controls.Add(Me.cboSun)
        Me.Controls.Add(Me.chkDST)
        Me.Controls.Add(Me.txtIESec)
        Me.Controls.Add(Me.txtSightNo)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdFix)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.txtIEdeg)
        Me.Controls.Add(Me.cboZDm)
        Me.Controls.Add(Me.txtLDeg)
        Me.Controls.Add(Me.cboPolaris)
        Me.Controls.Add(Me.cboDsUnit)
        Me.Controls.Add(Me.txtDsDist)
        Me.Controls.Add(Me.Framehs)
        Me.Controls.Add(Me.FrameZD)
        Me.Controls.Add(Me.cmdReduce)
        Me.Controls.Add(Me.cboPressure)
        Me.Controls.Add(Me.txtPressure)
        Me.Controls.Add(Me.cboTemperature)
        Me.Controls.Add(Me.txtTemperature)
        Me.Controls.Add(Me.cboIE)
        Me.Controls.Add(Me.txtIEmin)
        Me.Controls.Add(Me.cboHE)
        Me.Controls.Add(Me.txtHE)
        Me.Controls.Add(Me.txtHsSec)
        Me.Controls.Add(Me.txtHsMin)
        Me.Controls.Add(Me.txtHsDeg)
        Me.Controls.Add(Me.txtLoMin)
        Me.Controls.Add(Me.txtLoDeg)
        Me.Controls.Add(Me.txtLMin)
        Me.Controls.Add(Me.cboBody)
        Me.Controls.Add(Me.txtZDh)
        Me.Controls.Add(Me.cboWE)
        Me.Controls.Add(Me.txtWESec)
        Me.Controls.Add(Me.txtWEMin)
        Me.Controls.Add(Me.FrameTP)
        Me.Controls.Add(Me.FrameHo)
        Me.Controls.Add(Me.lblZDDST)
        Me.Controls.Add(Me.lblIEsec)
        Me.Controls.Add(Me.lblHoCorrs)
        Me.Controls.Add(Me.lblSightNo)
        Me.Controls.Add(Me.lblIEdeg)
        Me.Controls.Add(Me.lblZDm)
        Me.Controls.Add(Me.lblZDh)
        Me.Controls.Add(Me.lblDsDist)
        Me.Controls.Add(Me.lblHorizon)
        Me.Controls.Add(Me.lblPressure)
        Me.Controls.Add(Me.lblTempDeg)
        Me.Controls.Add(Me.lblTemperature)
        Me.Controls.Add(Me.lblStdT_P)
        Me.Controls.Add(Me.lblIEMin)
        Me.Controls.Add(Me.lblIE)
        Me.Controls.Add(Me.lblHE)
        Me.Controls.Add(Me.lblHsSec)
        Me.Controls.Add(Me.lblHsMin)
        Me.Controls.Add(Me.lblHsDeg)
        Me.Controls.Add(Me.lblHs)
        Me.Controls.Add(Me.lblHsFormat)
        Me.Controls.Add(Me.lblLoMin)
        Me.Controls.Add(Me.lblLoDeg)
        Me.Controls.Add(Me.lblDRLo)
        Me.Controls.Add(Me.lblLMin)
        Me.Controls.Add(Me.lblLDeg)
        Me.Controls.Add(Me.lblDRL)
        Me.Controls.Add(Me.lblBody)
        Me.Controls.Add(Me.lblZD)
        Me.Controls.Add(Me.lblZDAutoManual)
        Me.Controls.Add(Me.lblWEsec)
        Me.Controls.Add(Me.lblWEmin)
        Me.Controls.Add(Me.lblWE)
        Me.Controls.Add(Me.EqTPicBx)
        Me.Controls.Add(Me.cboPlanets)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(56, 29)
        Me.Name = "FormSRF"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Sight Reduction"
        Me.Framehs.ResumeLayout(False)
        Me.FrameZD.ResumeLayout(False)
        Me.FrameTP.ResumeLayout(False)
        Me.FrameHo.ResumeLayout(False)
        CType(Me.EqTPicBx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FrameHorizon.ResumeLayout(False)
        Me.frmLimb.ResumeLayout(False)
        Me.frmLimb.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGSight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGDec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGLHA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGAlt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TimeTxtBx As RichTextBox
    Friend WithEvents LHATxtBx As RichTextBox
    Friend WithEvents AltitudeTxtBx As RichTextBox
    Friend WithEvents IntAzTxtBx As RichTextBox
    Public WithEvents ExitBtn As Button
    Friend WithEvents EqTPicBx As PictureBox
    Public WithEvents FrameHorizon As Panel
    Public WithEvents optHorizonBubble As RadioButton
    Public WithEvents optHorizonDipShort As RadioButton
    Public WithEvents optHorizonArtificial As RadioButton
    Public WithEvents optHorizonNatural As RadioButton
    Friend WithEvents frmLimb As Panel
    Friend WithEvents optCenter As RadioButton
    Friend WithEvents optUpper As RadioButton
    Friend WithEvents optLower As RadioButton
    Friend WithEvents LimbTxt As TextBox
    Public WithEvents cboPlanets As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DTSight As DateTimePicker
    Public WithEvents lblDate As Label
    Public WithEvents btnCLSPlot As Button
    Friend WithEvents btnCustomPlot As Button
    Friend WithEvents cmdMerDiag As Button
    Friend WithEvents DGSight As DataGridView
    Friend WithEvents SightTxtBx As TextBox
    Friend WithEvents DecTxtBx As TextBox
    Friend WithEvents DGDec As DataGridView
    Friend WithEvents DGTime As DataGridView
    Friend WithEvents DGLHA As DataGridView
    Friend WithEvents DGAlt As DataGridView
    Friend WithEvents txtUserInfo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnExpandTimeDiag As Button
    Public WithEvents ClearAllBtn As Button
    Friend WithEvents cboLLoBy As ComboBox
    Friend WithEvents Label9 As Label
#End Region
End Class