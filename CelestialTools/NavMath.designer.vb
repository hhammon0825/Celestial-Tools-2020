<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FormNavMath
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
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormNavMath))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtLoMin = New System.Windows.Forms.TextBox()
        Me.txtLoDeg = New System.Windows.Forms.TextBox()
        Me.lblZD1 = New System.Windows.Forms.Label()
        Me.lblZD2 = New System.Windows.Forms.Label()
        Me.txtTime1 = New System.Windows.Forms.TextBox()
        Me.chkDST1 = New System.Windows.Forms.CheckBox()
        Me.txtZDh1 = New System.Windows.Forms.TextBox()
        Me.chkDST2 = New System.Windows.Forms.CheckBox()
        Me.txtZDh2 = New System.Windows.Forms.TextBox()
        Me.txtMin2 = New System.Windows.Forms.TextBox()
        Me.txtDeg2 = New System.Windows.Forms.TextBox()
        Me.txtMin1 = New System.Windows.Forms.TextBox()
        Me.txtDeg1 = New System.Windows.Forms.TextBox()
        Me.txtDeg3 = New System.Windows.Forms.TextBox()
        Me.txtMin3 = New System.Windows.Forms.TextBox()
        Me.txtHsSec = New System.Windows.Forms.TextBox()
        Me.txtHsMin = New System.Windows.Forms.TextBox()
        Me.txtHsDeg = New System.Windows.Forms.TextBox()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.TimeZoneCalc = New System.Windows.Forms.TabPage()
        Me.btnZDCalc = New System.Windows.Forms.Button()
        Me.cboLo = New System.Windows.Forms.ComboBox()
        Me.txtZD = New System.Windows.Forms.TextBox()
        Me.cmdClearTZ = New System.Windows.Forms.Button()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.lblLoDeg = New System.Windows.Forms.Label()
        Me.lblLoMin = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TimeofDateCalc = New System.Windows.Forms.TabPage()
        Me.txtIntD = New System.Windows.Forms.TextBox()
        Me.txtIntM = New System.Windows.Forms.TextBox()
        Me.txtIntH = New System.Windows.Forms.TextBox()
        Me.txtDays = New System.Windows.Forms.TextBox()
        Me.txtTimeResult = New System.Windows.Forms.TextBox()
        Me.Frame2 = New System.Windows.Forms.Panel()
        Me.optSubtractToD = New System.Windows.Forms.RadioButton()
        Me.optAddToD = New System.Windows.Forms.RadioButton()
        Me.cboZDm2 = New System.Windows.Forms.ComboBox()
        Me.cboZDm1 = New System.Windows.Forms.ComboBox()
        Me.cmdCalculateToD = New System.Windows.Forms.Button()
        Me.cmdClearToD = New System.Windows.Forms.Button()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lblZDh2 = New System.Windows.Forms.Label()
        Me.lblZDm2 = New System.Windows.Forms.Label()
        Me.lblZDDST2 = New System.Windows.Forms.Label()
        Me.lblZDh1 = New System.Windows.Forms.Label()
        Me.lblZDm1 = New System.Windows.Forms.Label()
        Me.lblZDDST1 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TimeAddSubtract = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnMoveResult = New System.Windows.Forms.Button()
        Me.DTRSeconds = New System.Windows.Forms.NumericUpDown()
        Me.DTRMinutes = New System.Windows.Forms.NumericUpDown()
        Me.DTRHours = New System.Windows.Forms.NumericUpDown()
        Me.DTRDays = New System.Windows.Forms.NumericUpDown()
        Me.DT2Seconds = New System.Windows.Forms.NumericUpDown()
        Me.DT2Minutes = New System.Windows.Forms.NumericUpDown()
        Me.DT2Hours = New System.Windows.Forms.NumericUpDown()
        Me.DT2Days = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DT1Seconds = New System.Windows.Forms.NumericUpDown()
        Me.DT1Minutes = New System.Windows.Forms.NumericUpDown()
        Me.DT1Hours = New System.Windows.Forms.NumericUpDown()
        Me.DT1Days = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdClearTimes = New System.Windows.Forms.Button()
        Me.cmdCalculateTimes = New System.Windows.Forms.Button()
        Me.Frame3 = New System.Windows.Forms.Panel()
        Me.optAddTimes = New System.Windows.Forms.RadioButton()
        Me.optSubtractTimes = New System.Windows.Forms.RadioButton()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.AngleAddSubtract = New System.Windows.Forms.TabPage()
        Me.btnAddSubtract = New System.Windows.Forms.Button()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.Frame4 = New System.Windows.Forms.Panel()
        Me.optSubtract2 = New System.Windows.Forms.RadioButton()
        Me.optAdd2 = New System.Windows.Forms.RadioButton()
        Me.cmdClearAddSubtract = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.Panel()
        Me.optAdd1 = New System.Windows.Forms.RadioButton()
        Me.optSubtract1 = New System.Windows.Forms.RadioButton()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ConvertAngleorTime = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optHsDMm = New System.Windows.Forms.RadioButton()
        Me.optHsDMS = New System.Windows.Forms.RadioButton()
        Me.dtTime = New System.Windows.Forms.DateTimePicker()
        Me.txtConvertedTime = New System.Windows.Forms.TextBox()
        Me.txtAngle = New System.Windows.Forms.TextBox()
        Me.cmdClearConverter = New System.Windows.Forms.Button()
        Me.cmdConvert = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblHs = New System.Windows.Forms.Label()
        Me.lblHsDeg = New System.Windows.Forms.Label()
        Me.lblHsMin = New System.Windows.Forms.Label()
        Me.lblHsSec = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TimeZoneCalc.SuspendLayout()
        Me.TimeofDateCalc.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me.TimeAddSubtract.SuspendLayout()
        CType(Me.DTRSeconds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTRMinutes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTRHours, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTRDays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT2Seconds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT2Minutes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT2Hours, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT2Days, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT1Seconds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT1Minutes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT1Hours, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT1Days, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame3.SuspendLayout()
        Me.AngleAddSubtract.SuspendLayout()
        Me.Frame4.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.ConvertAngleorTime.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtLoMin
        '
        Me.txtLoMin.AcceptsReturn = True
        Me.txtLoMin.BackColor = System.Drawing.SystemColors.Window
        Me.txtLoMin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLoMin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoMin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLoMin.Location = New System.Drawing.Point(340, 38)
        Me.txtLoMin.MaxLength = 4
        Me.txtLoMin.Name = "txtLoMin"
        Me.txtLoMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLoMin.Size = New System.Drawing.Size(33, 20)
        Me.txtLoMin.TabIndex = 119
        Me.ToolTip1.SetToolTip(Me.txtLoMin, "Range 0 to 59.9")
        '
        'txtLoDeg
        '
        Me.txtLoDeg.AcceptsReturn = True
        Me.txtLoDeg.BackColor = System.Drawing.SystemColors.Window
        Me.txtLoDeg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLoDeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoDeg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLoDeg.Location = New System.Drawing.Point(300, 38)
        Me.txtLoDeg.MaxLength = 3
        Me.txtLoDeg.Name = "txtLoDeg"
        Me.txtLoDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLoDeg.Size = New System.Drawing.Size(33, 20)
        Me.txtLoDeg.TabIndex = 118
        Me.ToolTip1.SetToolTip(Me.txtLoDeg, "Range 0 to 180")
        '
        'lblZD1
        '
        Me.lblZD1.BackColor = System.Drawing.SystemColors.Window
        Me.lblZD1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblZD1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZD1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblZD1.Location = New System.Drawing.Point(172, 88)
        Me.lblZD1.Name = "lblZD1"
        Me.lblZD1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblZD1.Size = New System.Drawing.Size(87, 17)
        Me.lblZD1.TabIndex = 151
        Me.lblZD1.Text = "ZD at Location A"
        Me.ToolTip1.SetToolTip(Me.lblZD1, "Zone Description")
        '
        'lblZD2
        '
        Me.lblZD2.BackColor = System.Drawing.SystemColors.Window
        Me.lblZD2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblZD2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZD2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblZD2.Location = New System.Drawing.Point(172, 152)
        Me.lblZD2.Name = "lblZD2"
        Me.lblZD2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblZD2.Size = New System.Drawing.Size(81, 17)
        Me.lblZD2.TabIndex = 155
        Me.lblZD2.Text = "ZD at Location B"
        Me.ToolTip1.SetToolTip(Me.lblZD2, "Zone Description")
        '
        'txtTime1
        '
        Me.txtTime1.AcceptsReturn = True
        Me.txtTime1.BackColor = System.Drawing.SystemColors.Window
        Me.txtTime1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTime1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTime1.Location = New System.Drawing.Point(318, 59)
        Me.txtTime1.MaxLength = 4
        Me.txtTime1.Name = "txtTime1"
        Me.txtTime1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTime1.Size = New System.Drawing.Size(52, 20)
        Me.txtTime1.TabIndex = 132
        Me.ToolTip1.SetToolTip(Me.txtTime1, "Range 0000 to 2359")
        '
        'chkDST1
        '
        Me.chkDST1.BackColor = System.Drawing.SystemColors.Window
        Me.chkDST1.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkDST1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDST1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkDST1.Location = New System.Drawing.Point(364, 87)
        Me.chkDST1.Name = "chkDST1"
        Me.chkDST1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkDST1.Size = New System.Drawing.Size(17, 17)
        Me.chkDST1.TabIndex = 135
        Me.chkDST1.Text = "Check1"
        Me.ToolTip1.SetToolTip(Me.chkDST1, "Check if Dayslight Saving is in effect")
        Me.chkDST1.UseVisualStyleBackColor = False
        '
        'txtZDh1
        '
        Me.txtZDh1.AcceptsReturn = True
        Me.txtZDh1.BackColor = System.Drawing.SystemColors.Window
        Me.txtZDh1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtZDh1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZDh1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtZDh1.Location = New System.Drawing.Point(260, 85)
        Me.txtZDh1.MaxLength = 3
        Me.txtZDh1.Name = "txtZDh1"
        Me.txtZDh1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtZDh1.Size = New System.Drawing.Size(25, 20)
        Me.txtZDh1.TabIndex = 133
        Me.ToolTip1.SetToolTip(Me.txtZDh1, "Range -13 to +12.  Lo E is -.")
        '
        'chkDST2
        '
        Me.chkDST2.BackColor = System.Drawing.SystemColors.Window
        Me.chkDST2.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkDST2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDST2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkDST2.Location = New System.Drawing.Point(364, 151)
        Me.chkDST2.Name = "chkDST2"
        Me.chkDST2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkDST2.Size = New System.Drawing.Size(17, 17)
        Me.chkDST2.TabIndex = 142
        Me.chkDST2.Text = "Check1"
        Me.ToolTip1.SetToolTip(Me.chkDST2, "Check if Dayslight Saving is in effect")
        Me.chkDST2.UseVisualStyleBackColor = False
        '
        'txtZDh2
        '
        Me.txtZDh2.AcceptsReturn = True
        Me.txtZDh2.BackColor = System.Drawing.SystemColors.Window
        Me.txtZDh2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtZDh2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZDh2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtZDh2.Location = New System.Drawing.Point(260, 149)
        Me.txtZDh2.MaxLength = 3
        Me.txtZDh2.Name = "txtZDh2"
        Me.txtZDh2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtZDh2.Size = New System.Drawing.Size(25, 20)
        Me.txtZDh2.TabIndex = 140
        Me.ToolTip1.SetToolTip(Me.txtZDh2, "Range -13 to +12.  Lo E is -.")
        '
        'txtMin2
        '
        Me.txtMin2.AcceptsReturn = True
        Me.txtMin2.BackColor = System.Drawing.SystemColors.Window
        Me.txtMin2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMin2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMin2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMin2.Location = New System.Drawing.Point(232, 50)
        Me.txtMin2.MaxLength = 4
        Me.txtMin2.Name = "txtMin2"
        Me.txtMin2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMin2.Size = New System.Drawing.Size(33, 20)
        Me.txtMin2.TabIndex = 140
        Me.ToolTip1.SetToolTip(Me.txtMin2, "Range 0 to 59.9")
        '
        'txtDeg2
        '
        Me.txtDeg2.AcceptsReturn = True
        Me.txtDeg2.BackColor = System.Drawing.SystemColors.Window
        Me.txtDeg2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDeg2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeg2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDeg2.Location = New System.Drawing.Point(189, 50)
        Me.txtDeg2.MaxLength = 3
        Me.txtDeg2.Name = "txtDeg2"
        Me.txtDeg2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDeg2.Size = New System.Drawing.Size(33, 20)
        Me.txtDeg2.TabIndex = 139
        Me.ToolTip1.SetToolTip(Me.txtDeg2, "Range 0 to 999")
        '
        'txtMin1
        '
        Me.txtMin1.AcceptsReturn = True
        Me.txtMin1.BackColor = System.Drawing.SystemColors.Window
        Me.txtMin1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMin1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMin1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMin1.Location = New System.Drawing.Point(92, 50)
        Me.txtMin1.MaxLength = 4
        Me.txtMin1.Name = "txtMin1"
        Me.txtMin1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMin1.Size = New System.Drawing.Size(33, 20)
        Me.txtMin1.TabIndex = 138
        Me.ToolTip1.SetToolTip(Me.txtMin1, "Range 0 to 59.9")
        '
        'txtDeg1
        '
        Me.txtDeg1.AcceptsReturn = True
        Me.txtDeg1.BackColor = System.Drawing.SystemColors.Window
        Me.txtDeg1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDeg1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeg1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDeg1.Location = New System.Drawing.Point(50, 50)
        Me.txtDeg1.MaxLength = 3
        Me.txtDeg1.Name = "txtDeg1"
        Me.txtDeg1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDeg1.Size = New System.Drawing.Size(33, 20)
        Me.txtDeg1.TabIndex = 137
        Me.ToolTip1.SetToolTip(Me.txtDeg1, "Range 0 to 999")
        '
        'txtDeg3
        '
        Me.txtDeg3.AcceptsReturn = True
        Me.txtDeg3.BackColor = System.Drawing.SystemColors.Window
        Me.txtDeg3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDeg3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeg3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDeg3.Location = New System.Drawing.Point(330, 50)
        Me.txtDeg3.MaxLength = 3
        Me.txtDeg3.Name = "txtDeg3"
        Me.txtDeg3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDeg3.Size = New System.Drawing.Size(33, 20)
        Me.txtDeg3.TabIndex = 141
        Me.ToolTip1.SetToolTip(Me.txtDeg3, "Range 0 to 999")
        '
        'txtMin3
        '
        Me.txtMin3.AcceptsReturn = True
        Me.txtMin3.BackColor = System.Drawing.SystemColors.Window
        Me.txtMin3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMin3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMin3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMin3.Location = New System.Drawing.Point(373, 50)
        Me.txtMin3.MaxLength = 4
        Me.txtMin3.Name = "txtMin3"
        Me.txtMin3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMin3.Size = New System.Drawing.Size(33, 20)
        Me.txtMin3.TabIndex = 142
        Me.ToolTip1.SetToolTip(Me.txtMin3, "Range 0 to 59.9")
        '
        'txtHsSec
        '
        Me.txtHsSec.AcceptsReturn = True
        Me.txtHsSec.BackColor = System.Drawing.SystemColors.Window
        Me.txtHsSec.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHsSec.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHsSec.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHsSec.Location = New System.Drawing.Point(306, 71)
        Me.txtHsSec.MaxLength = 2
        Me.txtHsSec.Name = "txtHsSec"
        Me.txtHsSec.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHsSec.Size = New System.Drawing.Size(33, 20)
        Me.txtHsSec.TabIndex = 86
        Me.ToolTip1.SetToolTip(Me.txtHsSec, "Range 0 to 59")
        Me.txtHsSec.Visible = False
        '
        'txtHsMin
        '
        Me.txtHsMin.AcceptsReturn = True
        Me.txtHsMin.BackColor = System.Drawing.SystemColors.Window
        Me.txtHsMin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHsMin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHsMin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHsMin.Location = New System.Drawing.Point(266, 71)
        Me.txtHsMin.MaxLength = 4
        Me.txtHsMin.Name = "txtHsMin"
        Me.txtHsMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHsMin.Size = New System.Drawing.Size(33, 20)
        Me.txtHsMin.TabIndex = 85
        Me.ToolTip1.SetToolTip(Me.txtHsMin, "Range 0 to 59.9 (DM.m) or 59 (DMS)")
        '
        'txtHsDeg
        '
        Me.txtHsDeg.AcceptsReturn = True
        Me.txtHsDeg.BackColor = System.Drawing.SystemColors.Window
        Me.txtHsDeg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHsDeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHsDeg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHsDeg.Location = New System.Drawing.Point(226, 71)
        Me.txtHsDeg.MaxLength = 3
        Me.txtHsDeg.Name = "txtHsDeg"
        Me.txtHsDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHsDeg.Size = New System.Drawing.Size(33, 20)
        Me.txtHsDeg.TabIndex = 84
        Me.ToolTip1.SetToolTip(Me.txtHsDeg, "Range 0 to 999")
        '
        'ExitBtn
        '
        Me.ExitBtn.BackColor = System.Drawing.Color.Red
        Me.ExitBtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExitBtn.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ExitBtn.Location = New System.Drawing.Point(534, 421)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ExitBtn.Size = New System.Drawing.Size(73, 25)
        Me.ExitBtn.TabIndex = 137
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = False
        '
        'TimeZoneCalc
        '
        Me.TimeZoneCalc.Controls.Add(Me.btnZDCalc)
        Me.TimeZoneCalc.Controls.Add(Me.cboLo)
        Me.TimeZoneCalc.Controls.Add(Me.txtZD)
        Me.TimeZoneCalc.Controls.Add(Me.txtLoDeg)
        Me.TimeZoneCalc.Controls.Add(Me.txtLoMin)
        Me.TimeZoneCalc.Controls.Add(Me.cmdClearTZ)
        Me.TimeZoneCalc.Controls.Add(Me.Label35)
        Me.TimeZoneCalc.Controls.Add(Me.lblLoDeg)
        Me.TimeZoneCalc.Controls.Add(Me.lblLoMin)
        Me.TimeZoneCalc.Controls.Add(Me.Label34)
        Me.TimeZoneCalc.Controls.Add(Me.Label24)
        Me.TimeZoneCalc.Location = New System.Drawing.Point(4, 22)
        Me.TimeZoneCalc.Name = "TimeZoneCalc"
        Me.TimeZoneCalc.Size = New System.Drawing.Size(599, 367)
        Me.TimeZoneCalc.TabIndex = 5
        Me.TimeZoneCalc.Text = "Time Zone Calc"
        Me.TimeZoneCalc.UseVisualStyleBackColor = True
        '
        'btnZDCalc
        '
        Me.btnZDCalc.BackColor = System.Drawing.SystemColors.Control
        Me.btnZDCalc.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnZDCalc.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZDCalc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnZDCalc.Location = New System.Drawing.Point(214, 107)
        Me.btnZDCalc.Name = "btnZDCalc"
        Me.btnZDCalc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnZDCalc.Size = New System.Drawing.Size(82, 25)
        Me.btnZDCalc.TabIndex = 126
        Me.btnZDCalc.Text = "Calculate ZD"
        Me.btnZDCalc.UseVisualStyleBackColor = False
        '
        'cboLo
        '
        Me.cboLo.BackColor = System.Drawing.SystemColors.Window
        Me.cboLo.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboLo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboLo.Items.AddRange(New Object() {"W", "E"})
        Me.cboLo.Location = New System.Drawing.Point(380, 38)
        Me.cboLo.Name = "cboLo"
        Me.cboLo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboLo.Size = New System.Drawing.Size(41, 22)
        Me.cboLo.TabIndex = 120
        '
        'txtZD
        '
        Me.txtZD.AcceptsReturn = True
        Me.txtZD.BackColor = System.Drawing.SystemColors.Window
        Me.txtZD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtZD.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtZD.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZD.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtZD.Location = New System.Drawing.Point(300, 70)
        Me.txtZD.MaxLength = 0
        Me.txtZD.Name = "txtZD"
        Me.txtZD.ReadOnly = True
        Me.txtZD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtZD.Size = New System.Drawing.Size(49, 20)
        Me.txtZD.TabIndex = 125
        Me.txtZD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdClearTZ
        '
        Me.cmdClearTZ.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClearTZ.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClearTZ.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClearTZ.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClearTZ.Location = New System.Drawing.Point(329, 107)
        Me.cmdClearTZ.Name = "cmdClearTZ"
        Me.cmdClearTZ.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClearTZ.Size = New System.Drawing.Size(65, 25)
        Me.cmdClearTZ.TabIndex = 124
        Me.cmdClearTZ.Text = "Clear"
        Me.cmdClearTZ.UseVisualStyleBackColor = False
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.SystemColors.Window
        Me.Label35.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label35.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label35.Location = New System.Drawing.Point(202, 70)
        Me.Label35.Name = "Label35"
        Me.Label35.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label35.Size = New System.Drawing.Size(105, 17)
        Me.Label35.TabIndex = 123
        Me.Label35.Text = "Zone Description (ZD)"
        '
        'lblLoDeg
        '
        Me.lblLoDeg.BackColor = System.Drawing.SystemColors.Window
        Me.lblLoDeg.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLoDeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoDeg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLoDeg.Location = New System.Drawing.Point(333, 38)
        Me.lblLoDeg.Name = "lblLoDeg"
        Me.lblLoDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLoDeg.Size = New System.Drawing.Size(9, 17)
        Me.lblLoDeg.TabIndex = 122
        Me.lblLoDeg.Text = "°"
        '
        'lblLoMin
        '
        Me.lblLoMin.BackColor = System.Drawing.SystemColors.Window
        Me.lblLoMin.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLoMin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoMin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLoMin.Location = New System.Drawing.Point(373, 38)
        Me.lblLoMin.Name = "lblLoMin"
        Me.lblLoMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLoMin.Size = New System.Drawing.Size(9, 17)
        Me.lblLoMin.TabIndex = 121
        Me.lblLoMin.Text = "'"
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.SystemColors.Window
        Me.Label34.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label34.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label34.Location = New System.Drawing.Point(202, 38)
        Me.Label34.Name = "Label34"
        Me.Label34.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label34.Size = New System.Drawing.Size(54, 17)
        Me.Label34.TabIndex = 117
        Me.Label34.Text = "Longitude"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.SystemColors.Window
        Me.Label24.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label24.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label24.Location = New System.Drawing.Point(231, 9)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label24.Size = New System.Drawing.Size(153, 21)
        Me.Label24.TabIndex = 116
        Me.Label24.Text = "Time Zone Calculator"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimeofDateCalc
        '
        Me.TimeofDateCalc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TimeofDateCalc.Controls.Add(Me.Label11)
        Me.TimeofDateCalc.Controls.Add(Me.txtIntD)
        Me.TimeofDateCalc.Controls.Add(Me.txtIntM)
        Me.TimeofDateCalc.Controls.Add(Me.txtIntH)
        Me.TimeofDateCalc.Controls.Add(Me.txtZDh2)
        Me.TimeofDateCalc.Controls.Add(Me.txtZDh1)
        Me.TimeofDateCalc.Controls.Add(Me.txtDays)
        Me.TimeofDateCalc.Controls.Add(Me.txtTimeResult)
        Me.TimeofDateCalc.Controls.Add(Me.txtTime1)
        Me.TimeofDateCalc.Controls.Add(Me.Frame2)
        Me.TimeofDateCalc.Controls.Add(Me.cboZDm2)
        Me.TimeofDateCalc.Controls.Add(Me.chkDST2)
        Me.TimeofDateCalc.Controls.Add(Me.cboZDm1)
        Me.TimeofDateCalc.Controls.Add(Me.chkDST1)
        Me.TimeofDateCalc.Controls.Add(Me.cmdCalculateToD)
        Me.TimeofDateCalc.Controls.Add(Me.cmdClearToD)
        Me.TimeofDateCalc.Controls.Add(Me.Label38)
        Me.TimeofDateCalc.Controls.Add(Me.Label36)
        Me.TimeofDateCalc.Controls.Add(Me.Label37)
        Me.TimeofDateCalc.Controls.Add(Me.Label26)
        Me.TimeofDateCalc.Controls.Add(Me.Label23)
        Me.TimeofDateCalc.Controls.Add(Me.lblZD2)
        Me.TimeofDateCalc.Controls.Add(Me.lblZDh2)
        Me.TimeofDateCalc.Controls.Add(Me.lblZDm2)
        Me.TimeofDateCalc.Controls.Add(Me.lblZDDST2)
        Me.TimeofDateCalc.Controls.Add(Me.lblZD1)
        Me.TimeofDateCalc.Controls.Add(Me.lblZDh1)
        Me.TimeofDateCalc.Controls.Add(Me.lblZDm1)
        Me.TimeofDateCalc.Controls.Add(Me.lblZDDST1)
        Me.TimeofDateCalc.Controls.Add(Me.Label25)
        Me.TimeofDateCalc.Controls.Add(Me.TextBox1)
        Me.TimeofDateCalc.Location = New System.Drawing.Point(4, 22)
        Me.TimeofDateCalc.Name = "TimeofDateCalc"
        Me.TimeofDateCalc.Size = New System.Drawing.Size(599, 367)
        Me.TimeofDateCalc.TabIndex = 4
        Me.TimeofDateCalc.Text = "Time of Day Calc"
        Me.TimeofDateCalc.UseVisualStyleBackColor = True
        '
        'txtIntD
        '
        Me.txtIntD.AcceptsReturn = True
        Me.txtIntD.BackColor = System.Drawing.SystemColors.Window
        Me.txtIntD.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIntD.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIntD.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtIntD.Location = New System.Drawing.Point(259, 117)
        Me.txtIntD.MaxLength = 0
        Me.txtIntD.Name = "txtIntD"
        Me.txtIntD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtIntD.Size = New System.Drawing.Size(25, 20)
        Me.txtIntD.TabIndex = 137
        '
        'txtIntM
        '
        Me.txtIntM.AcceptsReturn = True
        Me.txtIntM.BackColor = System.Drawing.SystemColors.Window
        Me.txtIntM.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIntM.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIntM.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtIntM.Location = New System.Drawing.Point(356, 117)
        Me.txtIntM.MaxLength = 0
        Me.txtIntM.Name = "txtIntM"
        Me.txtIntM.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtIntM.Size = New System.Drawing.Size(41, 20)
        Me.txtIntM.TabIndex = 139
        '
        'txtIntH
        '
        Me.txtIntH.AcceptsReturn = True
        Me.txtIntH.BackColor = System.Drawing.SystemColors.Window
        Me.txtIntH.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIntH.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIntH.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtIntH.Location = New System.Drawing.Point(300, 117)
        Me.txtIntH.MaxLength = 0
        Me.txtIntH.Name = "txtIntH"
        Me.txtIntH.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtIntH.Size = New System.Drawing.Size(41, 20)
        Me.txtIntH.TabIndex = 138
        '
        'txtDays
        '
        Me.txtDays.AcceptsReturn = True
        Me.txtDays.BackColor = System.Drawing.SystemColors.Window
        Me.txtDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDays.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDays.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDays.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDays.Location = New System.Drawing.Point(344, 181)
        Me.txtDays.MaxLength = 0
        Me.txtDays.Name = "txtDays"
        Me.txtDays.ReadOnly = True
        Me.txtDays.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDays.Size = New System.Drawing.Size(64, 20)
        Me.txtDays.TabIndex = 146
        Me.txtDays.Visible = False
        '
        'txtTimeResult
        '
        Me.txtTimeResult.AcceptsReturn = True
        Me.txtTimeResult.BackColor = System.Drawing.SystemColors.Window
        Me.txtTimeResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTimeResult.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTimeResult.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimeResult.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTimeResult.Location = New System.Drawing.Point(260, 181)
        Me.txtTimeResult.MaxLength = 0
        Me.txtTimeResult.Name = "txtTimeResult"
        Me.txtTimeResult.ReadOnly = True
        Me.txtTimeResult.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTimeResult.Size = New System.Drawing.Size(81, 20)
        Me.txtTimeResult.TabIndex = 145
        Me.txtTimeResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Window
        Me.Frame2.Controls.Add(Me.optSubtractToD)
        Me.Frame2.Controls.Add(Me.optAddToD)
        Me.Frame2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(211, 106)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(42, 40)
        Me.Frame2.TabIndex = 136
        '
        'optSubtractToD
        '
        Me.optSubtractToD.BackColor = System.Drawing.SystemColors.Window
        Me.optSubtractToD.Cursor = System.Windows.Forms.Cursors.Default
        Me.optSubtractToD.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optSubtractToD.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optSubtractToD.Location = New System.Drawing.Point(8, 20)
        Me.optSubtractToD.Name = "optSubtractToD"
        Me.optSubtractToD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optSubtractToD.Size = New System.Drawing.Size(33, 17)
        Me.optSubtractToD.TabIndex = 125
        Me.optSubtractToD.TabStop = True
        Me.optSubtractToD.Text = "-"
        Me.optSubtractToD.UseVisualStyleBackColor = False
        '
        'optAddToD
        '
        Me.optAddToD.BackColor = System.Drawing.SystemColors.Window
        Me.optAddToD.Checked = True
        Me.optAddToD.Cursor = System.Windows.Forms.Cursors.Default
        Me.optAddToD.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optAddToD.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optAddToD.Location = New System.Drawing.Point(8, 4)
        Me.optAddToD.Name = "optAddToD"
        Me.optAddToD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optAddToD.Size = New System.Drawing.Size(33, 17)
        Me.optAddToD.TabIndex = 124
        Me.optAddToD.TabStop = True
        Me.optAddToD.Text = "+"
        Me.optAddToD.UseVisualStyleBackColor = False
        '
        'cboZDm2
        '
        Me.cboZDm2.BackColor = System.Drawing.SystemColors.Window
        Me.cboZDm2.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboZDm2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboZDm2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboZDm2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboZDm2.Items.AddRange(New Object() {"00", "30", "45"})
        Me.cboZDm2.Location = New System.Drawing.Point(300, 149)
        Me.cboZDm2.Name = "cboZDm2"
        Me.cboZDm2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboZDm2.Size = New System.Drawing.Size(41, 22)
        Me.cboZDm2.TabIndex = 141
        '
        'cboZDm1
        '
        Me.cboZDm1.BackColor = System.Drawing.SystemColors.Window
        Me.cboZDm1.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboZDm1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboZDm1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboZDm1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboZDm1.Items.AddRange(New Object() {"00", "30", "45"})
        Me.cboZDm1.Location = New System.Drawing.Point(300, 85)
        Me.cboZDm1.Name = "cboZDm1"
        Me.cboZDm1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboZDm1.Size = New System.Drawing.Size(41, 22)
        Me.cboZDm1.TabIndex = 134
        '
        'cmdCalculateToD
        '
        Me.cmdCalculateToD.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCalculateToD.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCalculateToD.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCalculateToD.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCalculateToD.Location = New System.Drawing.Point(196, 233)
        Me.cmdCalculateToD.Name = "cmdCalculateToD"
        Me.cmdCalculateToD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCalculateToD.Size = New System.Drawing.Size(65, 25)
        Me.cmdCalculateToD.TabIndex = 143
        Me.cmdCalculateToD.Text = "C&alculate"
        Me.cmdCalculateToD.UseVisualStyleBackColor = False
        '
        'cmdClearToD
        '
        Me.cmdClearToD.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClearToD.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClearToD.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClearToD.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClearToD.Location = New System.Drawing.Point(300, 233)
        Me.cmdClearToD.Name = "cmdClearToD"
        Me.cmdClearToD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClearToD.Size = New System.Drawing.Size(65, 25)
        Me.cmdClearToD.TabIndex = 144
        Me.cmdClearToD.Text = "Cl&ear"
        Me.cmdClearToD.UseVisualStyleBackColor = False
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.SystemColors.Window
        Me.Label38.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label38.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label38.Location = New System.Drawing.Point(170, 117)
        Me.Label38.Name = "Label38"
        Me.Label38.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label38.Size = New System.Drawing.Size(45, 17)
        Me.Label38.TabIndex = 160
        Me.Label38.Text = "Interval"
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.SystemColors.Window
        Me.Label36.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label36.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label36.Location = New System.Drawing.Point(172, 181)
        Me.Label36.Name = "Label36"
        Me.Label36.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label36.Size = New System.Drawing.Size(89, 17)
        Me.Label36.TabIndex = 159
        Me.Label36.Text = "ZT at Location B"
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.SystemColors.Window
        Me.Label37.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label37.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label37.Location = New System.Drawing.Point(285, 117)
        Me.Label37.Name = "Label37"
        Me.Label37.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label37.Size = New System.Drawing.Size(9, 17)
        Me.Label37.TabIndex = 158
        Me.Label37.Text = "d"
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.SystemColors.Window
        Me.Label26.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label26.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label26.Location = New System.Drawing.Point(341, 117)
        Me.Label26.Name = "Label26"
        Me.Label26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label26.Size = New System.Drawing.Size(11, 17)
        Me.Label26.TabIndex = 157
        Me.Label26.Text = "h"
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.SystemColors.Window
        Me.Label23.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label23.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(397, 117)
        Me.Label23.Name = "Label23"
        Me.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label23.Size = New System.Drawing.Size(11, 17)
        Me.Label23.TabIndex = 156
        Me.Label23.Text = "m"
        '
        'lblZDh2
        '
        Me.lblZDh2.BackColor = System.Drawing.SystemColors.Window
        Me.lblZDh2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblZDh2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZDh2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblZDh2.Location = New System.Drawing.Point(285, 152)
        Me.lblZDh2.Name = "lblZDh2"
        Me.lblZDh2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblZDh2.Size = New System.Drawing.Size(9, 17)
        Me.lblZDh2.TabIndex = 154
        Me.lblZDh2.Text = "h"
        '
        'lblZDm2
        '
        Me.lblZDm2.BackColor = System.Drawing.SystemColors.Window
        Me.lblZDm2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblZDm2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZDm2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblZDm2.Location = New System.Drawing.Point(341, 152)
        Me.lblZDm2.Name = "lblZDm2"
        Me.lblZDm2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblZDm2.Size = New System.Drawing.Size(11, 17)
        Me.lblZDm2.TabIndex = 153
        Me.lblZDm2.Text = "m"
        '
        'lblZDDST2
        '
        Me.lblZDDST2.BackColor = System.Drawing.SystemColors.Window
        Me.lblZDDST2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblZDDST2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZDDST2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblZDDST2.Location = New System.Drawing.Point(381, 152)
        Me.lblZDDST2.Name = "lblZDDST2"
        Me.lblZDDST2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblZDDST2.Size = New System.Drawing.Size(33, 13)
        Me.lblZDDST2.TabIndex = 152
        Me.lblZDDST2.Text = "DST"
        '
        'lblZDh1
        '
        Me.lblZDh1.BackColor = System.Drawing.SystemColors.Window
        Me.lblZDh1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblZDh1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZDh1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblZDh1.Location = New System.Drawing.Point(285, 88)
        Me.lblZDh1.Name = "lblZDh1"
        Me.lblZDh1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblZDh1.Size = New System.Drawing.Size(9, 17)
        Me.lblZDh1.TabIndex = 150
        Me.lblZDh1.Text = "h"
        '
        'lblZDm1
        '
        Me.lblZDm1.BackColor = System.Drawing.SystemColors.Window
        Me.lblZDm1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblZDm1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZDm1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblZDm1.Location = New System.Drawing.Point(341, 88)
        Me.lblZDm1.Name = "lblZDm1"
        Me.lblZDm1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblZDm1.Size = New System.Drawing.Size(11, 17)
        Me.lblZDm1.TabIndex = 149
        Me.lblZDm1.Text = "m"
        '
        'lblZDDST1
        '
        Me.lblZDDST1.BackColor = System.Drawing.SystemColors.Window
        Me.lblZDDST1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblZDDST1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZDDST1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblZDDST1.Location = New System.Drawing.Point(381, 88)
        Me.lblZDDST1.Name = "lblZDDST1"
        Me.lblZDDST1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblZDDST1.Size = New System.Drawing.Size(33, 13)
        Me.lblZDDST1.TabIndex = 148
        Me.lblZDDST1.Text = "DST"
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.SystemColors.Window
        Me.Label25.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label25.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label25.Location = New System.Drawing.Point(172, 61)
        Me.Label25.Name = "Label25"
        Me.Label25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label25.Size = New System.Drawing.Size(140, 17)
        Me.Label25.TabIndex = 147
        Me.Label25.Text = "ZT at Location A (hhmmss)"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox1.Location = New System.Drawing.Point(165, 40)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(252, 187)
        Me.TextBox1.TabIndex = 170
        '
        'TimeAddSubtract
        '
        Me.TimeAddSubtract.Controls.Add(Me.Label10)
        Me.TimeAddSubtract.Controls.Add(Me.Label9)
        Me.TimeAddSubtract.Controls.Add(Me.btnMoveResult)
        Me.TimeAddSubtract.Controls.Add(Me.DTRSeconds)
        Me.TimeAddSubtract.Controls.Add(Me.DTRMinutes)
        Me.TimeAddSubtract.Controls.Add(Me.DTRHours)
        Me.TimeAddSubtract.Controls.Add(Me.DTRDays)
        Me.TimeAddSubtract.Controls.Add(Me.DT2Seconds)
        Me.TimeAddSubtract.Controls.Add(Me.DT2Minutes)
        Me.TimeAddSubtract.Controls.Add(Me.DT2Hours)
        Me.TimeAddSubtract.Controls.Add(Me.DT2Days)
        Me.TimeAddSubtract.Controls.Add(Me.Label8)
        Me.TimeAddSubtract.Controls.Add(Me.DT1Seconds)
        Me.TimeAddSubtract.Controls.Add(Me.DT1Minutes)
        Me.TimeAddSubtract.Controls.Add(Me.DT1Hours)
        Me.TimeAddSubtract.Controls.Add(Me.DT1Days)
        Me.TimeAddSubtract.Controls.Add(Me.Label7)
        Me.TimeAddSubtract.Controls.Add(Me.Label6)
        Me.TimeAddSubtract.Controls.Add(Me.Label5)
        Me.TimeAddSubtract.Controls.Add(Me.Label1)
        Me.TimeAddSubtract.Controls.Add(Me.cmdClearTimes)
        Me.TimeAddSubtract.Controls.Add(Me.cmdCalculateTimes)
        Me.TimeAddSubtract.Controls.Add(Me.Frame3)
        Me.TimeAddSubtract.Controls.Add(Me.Label27)
        Me.TimeAddSubtract.Location = New System.Drawing.Point(4, 22)
        Me.TimeAddSubtract.Name = "TimeAddSubtract"
        Me.TimeAddSubtract.Size = New System.Drawing.Size(599, 367)
        Me.TimeAddSubtract.TabIndex = 3
        Me.TimeAddSubtract.Text = "Time Add or Subtract"
        Me.TimeAddSubtract.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(35, 126)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(147, 13)
        Me.Label10.TabIndex = 185
        Me.Label10.Text = "Time Period 2: Dy/Hr/Min/Sec"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(35, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(147, 13)
        Me.Label9.TabIndex = 184
        Me.Label9.Text = "Time Period 1: Dy/Hr/Min/Sec"
        '
        'btnMoveResult
        '
        Me.btnMoveResult.BackColor = System.Drawing.SystemColors.Control
        Me.btnMoveResult.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnMoveResult.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoveResult.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnMoveResult.Location = New System.Drawing.Point(279, 200)
        Me.btnMoveResult.Name = "btnMoveResult"
        Me.btnMoveResult.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnMoveResult.Size = New System.Drawing.Size(121, 25)
        Me.btnMoveResult.TabIndex = 183
        Me.btnMoveResult.Text = "Move Result to Start"
        Me.btnMoveResult.UseVisualStyleBackColor = False
        '
        'DTRSeconds
        '
        Me.DTRSeconds.Location = New System.Drawing.Point(365, 160)
        Me.DTRSeconds.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.DTRSeconds.Name = "DTRSeconds"
        Me.DTRSeconds.Size = New System.Drawing.Size(35, 21)
        Me.DTRSeconds.TabIndex = 182
        '
        'DTRMinutes
        '
        Me.DTRMinutes.Location = New System.Drawing.Point(302, 160)
        Me.DTRMinutes.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.DTRMinutes.Name = "DTRMinutes"
        Me.DTRMinutes.Size = New System.Drawing.Size(35, 21)
        Me.DTRMinutes.TabIndex = 181
        '
        'DTRHours
        '
        Me.DTRHours.Location = New System.Drawing.Point(246, 160)
        Me.DTRHours.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.DTRHours.Name = "DTRHours"
        Me.DTRHours.Size = New System.Drawing.Size(35, 21)
        Me.DTRHours.TabIndex = 180
        '
        'DTRDays
        '
        Me.DTRDays.Location = New System.Drawing.Point(186, 160)
        Me.DTRDays.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.DTRDays.Name = "DTRDays"
        Me.DTRDays.Size = New System.Drawing.Size(35, 21)
        Me.DTRDays.TabIndex = 179
        '
        'DT2Seconds
        '
        Me.DT2Seconds.Location = New System.Drawing.Point(365, 122)
        Me.DT2Seconds.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.DT2Seconds.Name = "DT2Seconds"
        Me.DT2Seconds.Size = New System.Drawing.Size(35, 21)
        Me.DT2Seconds.TabIndex = 178
        '
        'DT2Minutes
        '
        Me.DT2Minutes.Location = New System.Drawing.Point(302, 122)
        Me.DT2Minutes.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.DT2Minutes.Name = "DT2Minutes"
        Me.DT2Minutes.Size = New System.Drawing.Size(35, 21)
        Me.DT2Minutes.TabIndex = 177
        '
        'DT2Hours
        '
        Me.DT2Hours.Location = New System.Drawing.Point(246, 122)
        Me.DT2Hours.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.DT2Hours.Name = "DT2Hours"
        Me.DT2Hours.Size = New System.Drawing.Size(35, 21)
        Me.DT2Hours.TabIndex = 176
        '
        'DT2Days
        '
        Me.DT2Days.Location = New System.Drawing.Point(186, 122)
        Me.DT2Days.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.DT2Days.Name = "DT2Days"
        Me.DT2Days.Size = New System.Drawing.Size(35, 21)
        Me.DT2Days.TabIndex = 175
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(359, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 174
        Me.Label8.Text = "Seconds"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DT1Seconds
        '
        Me.DT1Seconds.Location = New System.Drawing.Point(365, 84)
        Me.DT1Seconds.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.DT1Seconds.Name = "DT1Seconds"
        Me.DT1Seconds.Size = New System.Drawing.Size(35, 21)
        Me.DT1Seconds.TabIndex = 173
        '
        'DT1Minutes
        '
        Me.DT1Minutes.Location = New System.Drawing.Point(302, 84)
        Me.DT1Minutes.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.DT1Minutes.Name = "DT1Minutes"
        Me.DT1Minutes.Size = New System.Drawing.Size(35, 21)
        Me.DT1Minutes.TabIndex = 172
        '
        'DT1Hours
        '
        Me.DT1Hours.Location = New System.Drawing.Point(246, 84)
        Me.DT1Hours.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.DT1Hours.Name = "DT1Hours"
        Me.DT1Hours.Size = New System.Drawing.Size(35, 21)
        Me.DT1Hours.TabIndex = 171
        '
        'DT1Days
        '
        Me.DT1Days.Location = New System.Drawing.Point(186, 84)
        Me.DT1Days.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.DT1Days.Name = "DT1Days"
        Me.DT1Days.Size = New System.Drawing.Size(35, 21)
        Me.DT1Days.TabIndex = 170
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(299, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 169
        Me.Label7.Text = "Minutes"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(245, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 165
        Me.Label6.Text = "Hours"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(187, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 164
        Me.Label5.Text = "Days " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(165, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 13)
        Me.Label1.TabIndex = 159
        Me.Label1.Text = "="
        '
        'cmdClearTimes
        '
        Me.cmdClearTimes.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClearTimes.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClearTimes.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClearTimes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClearTimes.Location = New System.Drawing.Point(186, 200)
        Me.cmdClearTimes.Name = "cmdClearTimes"
        Me.cmdClearTimes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClearTimes.Size = New System.Drawing.Size(65, 25)
        Me.cmdClearTimes.TabIndex = 151
        Me.cmdClearTimes.Text = "Cle&ar"
        Me.cmdClearTimes.UseVisualStyleBackColor = False
        '
        'cmdCalculateTimes
        '
        Me.cmdCalculateTimes.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCalculateTimes.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCalculateTimes.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCalculateTimes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCalculateTimes.Location = New System.Drawing.Point(27, 157)
        Me.cmdCalculateTimes.Name = "cmdCalculateTimes"
        Me.cmdCalculateTimes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCalculateTimes.Size = New System.Drawing.Size(65, 25)
        Me.cmdCalculateTimes.TabIndex = 150
        Me.cmdCalculateTimes.Text = "Calc&ulate"
        Me.cmdCalculateTimes.UseVisualStyleBackColor = False
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.SystemColors.Window
        Me.Frame3.Controls.Add(Me.optAddTimes)
        Me.Frame3.Controls.Add(Me.optSubtractTimes)
        Me.Frame3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Frame3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(116, 150)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(45, 40)
        Me.Frame3.TabIndex = 142
        '
        'optAddTimes
        '
        Me.optAddTimes.BackColor = System.Drawing.SystemColors.Window
        Me.optAddTimes.Checked = True
        Me.optAddTimes.Cursor = System.Windows.Forms.Cursors.Default
        Me.optAddTimes.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optAddTimes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optAddTimes.Location = New System.Drawing.Point(8, 4)
        Me.optAddTimes.Name = "optAddTimes"
        Me.optAddTimes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optAddTimes.Size = New System.Drawing.Size(33, 17)
        Me.optAddTimes.TabIndex = 92
        Me.optAddTimes.TabStop = True
        Me.optAddTimes.Text = "+"
        Me.optAddTimes.UseVisualStyleBackColor = False
        '
        'optSubtractTimes
        '
        Me.optSubtractTimes.BackColor = System.Drawing.SystemColors.Window
        Me.optSubtractTimes.Cursor = System.Windows.Forms.Cursors.Default
        Me.optSubtractTimes.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optSubtractTimes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optSubtractTimes.Location = New System.Drawing.Point(8, 20)
        Me.optSubtractTimes.Name = "optSubtractTimes"
        Me.optSubtractTimes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optSubtractTimes.Size = New System.Drawing.Size(33, 17)
        Me.optSubtractTimes.TabIndex = 93
        Me.optSubtractTimes.TabStop = True
        Me.optSubtractTimes.Text = "-"
        Me.optSubtractTimes.UseVisualStyleBackColor = False
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.SystemColors.Window
        Me.Label27.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label27.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label27.Location = New System.Drawing.Point(178, 14)
        Me.Label27.Name = "Label27"
        Me.Label27.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label27.Size = New System.Drawing.Size(247, 21)
        Me.Label27.TabIndex = 134
        Me.Label27.Text = "Time Addition/Subtraction/Conversion"
        '
        'AngleAddSubtract
        '
        Me.AngleAddSubtract.Controls.Add(Me.btnAddSubtract)
        Me.AngleAddSubtract.Controls.Add(Me.txtMin3)
        Me.AngleAddSubtract.Controls.Add(Me.txtDeg3)
        Me.AngleAddSubtract.Controls.Add(Me.txtResult)
        Me.AngleAddSubtract.Controls.Add(Me.txtDeg1)
        Me.AngleAddSubtract.Controls.Add(Me.txtMin1)
        Me.AngleAddSubtract.Controls.Add(Me.txtDeg2)
        Me.AngleAddSubtract.Controls.Add(Me.txtMin2)
        Me.AngleAddSubtract.Controls.Add(Me.Frame4)
        Me.AngleAddSubtract.Controls.Add(Me.cmdClearAddSubtract)
        Me.AngleAddSubtract.Controls.Add(Me.Frame1)
        Me.AngleAddSubtract.Controls.Add(Me.Label42)
        Me.AngleAddSubtract.Controls.Add(Me.Label41)
        Me.AngleAddSubtract.Controls.Add(Me.Label20)
        Me.AngleAddSubtract.Controls.Add(Me.Label19)
        Me.AngleAddSubtract.Controls.Add(Me.Label18)
        Me.AngleAddSubtract.Controls.Add(Me.Label17)
        Me.AngleAddSubtract.Controls.Add(Me.Label16)
        Me.AngleAddSubtract.Controls.Add(Me.Label15)
        Me.AngleAddSubtract.Controls.Add(Me.Label4)
        Me.AngleAddSubtract.Location = New System.Drawing.Point(4, 22)
        Me.AngleAddSubtract.Name = "AngleAddSubtract"
        Me.AngleAddSubtract.Size = New System.Drawing.Size(599, 367)
        Me.AngleAddSubtract.TabIndex = 2
        Me.AngleAddSubtract.Text = "Angle Add or Subtract"
        Me.AngleAddSubtract.UseVisualStyleBackColor = True
        '
        'btnAddSubtract
        '
        Me.btnAddSubtract.BackColor = System.Drawing.SystemColors.Control
        Me.btnAddSubtract.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnAddSubtract.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSubtract.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAddSubtract.Location = New System.Drawing.Point(196, 94)
        Me.btnAddSubtract.Name = "btnAddSubtract"
        Me.btnAddSubtract.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAddSubtract.Size = New System.Drawing.Size(70, 25)
        Me.btnAddSubtract.TabIndex = 155
        Me.btnAddSubtract.Text = "Calculate"
        Me.btnAddSubtract.UseVisualStyleBackColor = False
        '
        'txtResult
        '
        Me.txtResult.AcceptsReturn = True
        Me.txtResult.BackColor = System.Drawing.SystemColors.Window
        Me.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtResult.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtResult.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResult.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtResult.Location = New System.Drawing.Point(435, 50)
        Me.txtResult.MaxLength = 0
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtResult.Size = New System.Drawing.Size(108, 20)
        Me.txtResult.TabIndex = 151
        Me.txtResult.TabStop = False
        Me.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Frame4
        '
        Me.Frame4.BackColor = System.Drawing.SystemColors.Window
        Me.Frame4.Controls.Add(Me.optSubtract2)
        Me.Frame4.Controls.Add(Me.optAdd2)
        Me.Frame4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Frame4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame4.Location = New System.Drawing.Point(278, 42)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame4.Size = New System.Drawing.Size(45, 40)
        Me.Frame4.TabIndex = 152
        '
        'optSubtract2
        '
        Me.optSubtract2.BackColor = System.Drawing.SystemColors.Window
        Me.optSubtract2.Cursor = System.Windows.Forms.Cursors.Default
        Me.optSubtract2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optSubtract2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optSubtract2.Location = New System.Drawing.Point(8, 20)
        Me.optSubtract2.Name = "optSubtract2"
        Me.optSubtract2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optSubtract2.Size = New System.Drawing.Size(33, 17)
        Me.optSubtract2.TabIndex = 53
        Me.optSubtract2.TabStop = True
        Me.optSubtract2.Text = "-"
        Me.optSubtract2.UseVisualStyleBackColor = False
        '
        'optAdd2
        '
        Me.optAdd2.BackColor = System.Drawing.SystemColors.Window
        Me.optAdd2.Checked = True
        Me.optAdd2.Cursor = System.Windows.Forms.Cursors.Default
        Me.optAdd2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optAdd2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optAdd2.Location = New System.Drawing.Point(8, 4)
        Me.optAdd2.Name = "optAdd2"
        Me.optAdd2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optAdd2.Size = New System.Drawing.Size(33, 17)
        Me.optAdd2.TabIndex = 52
        Me.optAdd2.TabStop = True
        Me.optAdd2.Text = "+"
        Me.optAdd2.UseVisualStyleBackColor = False
        '
        'cmdClearAddSubtract
        '
        Me.cmdClearAddSubtract.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClearAddSubtract.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClearAddSubtract.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClearAddSubtract.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClearAddSubtract.Location = New System.Drawing.Point(330, 94)
        Me.cmdClearAddSubtract.Name = "cmdClearAddSubtract"
        Me.cmdClearAddSubtract.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClearAddSubtract.Size = New System.Drawing.Size(73, 25)
        Me.cmdClearAddSubtract.TabIndex = 143
        Me.cmdClearAddSubtract.Text = "C&lear"
        Me.cmdClearAddSubtract.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Window
        Me.Frame1.Controls.Add(Me.optAdd1)
        Me.Frame1.Controls.Add(Me.optSubtract1)
        Me.Frame1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(139, 41)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(45, 40)
        Me.Frame1.TabIndex = 136
        '
        'optAdd1
        '
        Me.optAdd1.BackColor = System.Drawing.SystemColors.Window
        Me.optAdd1.Checked = True
        Me.optAdd1.Cursor = System.Windows.Forms.Cursors.Default
        Me.optAdd1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optAdd1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optAdd1.Location = New System.Drawing.Point(8, 4)
        Me.optAdd1.Name = "optAdd1"
        Me.optAdd1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optAdd1.Size = New System.Drawing.Size(33, 17)
        Me.optAdd1.TabIndex = 48
        Me.optAdd1.TabStop = True
        Me.optAdd1.Text = "+"
        Me.optAdd1.UseVisualStyleBackColor = False
        '
        'optSubtract1
        '
        Me.optSubtract1.BackColor = System.Drawing.SystemColors.Window
        Me.optSubtract1.Cursor = System.Windows.Forms.Cursors.Default
        Me.optSubtract1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optSubtract1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optSubtract1.Location = New System.Drawing.Point(8, 20)
        Me.optSubtract1.Name = "optSubtract1"
        Me.optSubtract1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optSubtract1.Size = New System.Drawing.Size(33, 17)
        Me.optSubtract1.TabIndex = 49
        Me.optSubtract1.TabStop = True
        Me.optSubtract1.Text = "-"
        Me.optSubtract1.UseVisualStyleBackColor = False
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.SystemColors.Window
        Me.Label42.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label42.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label42.Location = New System.Drawing.Point(407, 50)
        Me.Label42.Name = "Label42"
        Me.Label42.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label42.Size = New System.Drawing.Size(9, 17)
        Me.Label42.TabIndex = 154
        Me.Label42.Text = "'"
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.SystemColors.Window
        Me.Label41.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label41.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label41.Location = New System.Drawing.Point(364, 50)
        Me.Label41.Name = "Label41"
        Me.Label41.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label41.Size = New System.Drawing.Size(9, 17)
        Me.Label41.TabIndex = 153
        Me.Label41.Text = "°"
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.Window
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label20.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(164, 136)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label20.Size = New System.Drawing.Size(270, 17)
        Me.Label20.TabIndex = 150
        Me.Label20.Text = " Calculated result will be between 0º and 359º59.9'"
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.Window
        Me.Label19.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label19.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(83, 50)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label19.Size = New System.Drawing.Size(9, 17)
        Me.Label19.TabIndex = 149
        Me.Label19.Text = "°"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.Window
        Me.Label18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label18.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(125, 50)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(9, 17)
        Me.Label18.TabIndex = 148
        Me.Label18.Text = "'"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.SystemColors.Window
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label17.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(223, 50)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(9, 17)
        Me.Label17.TabIndex = 147
        Me.Label17.Text = "°"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.Window
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(266, 50)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(9, 17)
        Me.Label16.TabIndex = 146
        Me.Label16.Text = "'"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Window
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(185, 5)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(230, 24)
        Me.Label15.TabIndex = 145
        Me.Label15.Text = "Addition and Subtraction of Angles"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Window
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(418, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(9, 17)
        Me.Label4.TabIndex = 144
        Me.Label4.Text = "="
        '
        'ConvertAngleorTime
        '
        Me.ConvertAngleorTime.Controls.Add(Me.GroupBox1)
        Me.ConvertAngleorTime.Controls.Add(Me.dtTime)
        Me.ConvertAngleorTime.Controls.Add(Me.txtConvertedTime)
        Me.ConvertAngleorTime.Controls.Add(Me.txtAngle)
        Me.ConvertAngleorTime.Controls.Add(Me.txtHsDeg)
        Me.ConvertAngleorTime.Controls.Add(Me.txtHsMin)
        Me.ConvertAngleorTime.Controls.Add(Me.txtHsSec)
        Me.ConvertAngleorTime.Controls.Add(Me.cmdClearConverter)
        Me.ConvertAngleorTime.Controls.Add(Me.cmdConvert)
        Me.ConvertAngleorTime.Controls.Add(Me.Label3)
        Me.ConvertAngleorTime.Controls.Add(Me.Label2)
        Me.ConvertAngleorTime.Controls.Add(Me.lblHs)
        Me.ConvertAngleorTime.Controls.Add(Me.lblHsDeg)
        Me.ConvertAngleorTime.Controls.Add(Me.lblHsMin)
        Me.ConvertAngleorTime.Controls.Add(Me.lblHsSec)
        Me.ConvertAngleorTime.Location = New System.Drawing.Point(4, 22)
        Me.ConvertAngleorTime.Name = "ConvertAngleorTime"
        Me.ConvertAngleorTime.Padding = New System.Windows.Forms.Padding(3)
        Me.ConvertAngleorTime.Size = New System.Drawing.Size(599, 367)
        Me.ConvertAngleorTime.TabIndex = 1
        Me.ConvertAngleorTime.Text = "Angle or Time to Decimal"
        Me.ConvertAngleorTime.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optHsDMm)
        Me.GroupBox1.Controls.Add(Me.optHsDMS)
        Me.GroupBox1.Location = New System.Drawing.Point(219, 187)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(144, 51)
        Me.GroupBox1.TabIndex = 101
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Angle Format"
        '
        'optHsDMm
        '
        Me.optHsDMm.BackColor = System.Drawing.SystemColors.Window
        Me.optHsDMm.Checked = True
        Me.optHsDMm.Cursor = System.Windows.Forms.Cursors.Default
        Me.optHsDMm.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optHsDMm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optHsDMm.Location = New System.Drawing.Point(22, 20)
        Me.optHsDMm.Name = "optHsDMm"
        Me.optHsDMm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optHsDMm.Size = New System.Drawing.Size(57, 25)
        Me.optHsDMm.TabIndex = 13
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
        Me.optHsDMS.Location = New System.Drawing.Point(87, 23)
        Me.optHsDMS.Name = "optHsDMS"
        Me.optHsDMS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optHsDMS.Size = New System.Drawing.Size(49, 17)
        Me.optHsDMS.TabIndex = 14
        Me.optHsDMS.TabStop = True
        Me.optHsDMS.Text = "DMS"
        Me.optHsDMS.UseVisualStyleBackColor = False
        '
        'dtTime
        '
        Me.dtTime.CustomFormat = "HH:mm:ss"
        Me.dtTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTime.Location = New System.Drawing.Point(226, 100)
        Me.dtTime.Name = "dtTime"
        Me.dtTime.ShowUpDown = True
        Me.dtTime.Size = New System.Drawing.Size(77, 21)
        Me.dtTime.TabIndex = 100
        '
        'txtConvertedTime
        '
        Me.txtConvertedTime.AcceptsReturn = True
        Me.txtConvertedTime.BackColor = System.Drawing.SystemColors.Window
        Me.txtConvertedTime.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConvertedTime.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConvertedTime.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConvertedTime.Location = New System.Drawing.Point(353, 102)
        Me.txtConvertedTime.MaxLength = 0
        Me.txtConvertedTime.Name = "txtConvertedTime"
        Me.txtConvertedTime.ReadOnly = True
        Me.txtConvertedTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConvertedTime.Size = New System.Drawing.Size(185, 20)
        Me.txtConvertedTime.TabIndex = 99
        '
        'txtAngle
        '
        Me.txtAngle.AcceptsReturn = True
        Me.txtAngle.BackColor = System.Drawing.SystemColors.Window
        Me.txtAngle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAngle.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAngle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAngle.Location = New System.Drawing.Point(353, 72)
        Me.txtAngle.MaxLength = 0
        Me.txtAngle.Name = "txtAngle"
        Me.txtAngle.ReadOnly = True
        Me.txtAngle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAngle.Size = New System.Drawing.Size(185, 20)
        Me.txtAngle.TabIndex = 98
        '
        'cmdClearConverter
        '
        Me.cmdClearConverter.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClearConverter.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClearConverter.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClearConverter.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClearConverter.Location = New System.Drawing.Point(306, 142)
        Me.cmdClearConverter.Name = "cmdClearConverter"
        Me.cmdClearConverter.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClearConverter.Size = New System.Drawing.Size(73, 25)
        Me.cmdClearConverter.TabIndex = 89
        Me.cmdClearConverter.Text = "Clea&r"
        Me.cmdClearConverter.UseVisualStyleBackColor = False
        '
        'cmdConvert
        '
        Me.cmdConvert.BackColor = System.Drawing.SystemColors.Control
        Me.cmdConvert.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdConvert.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConvert.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdConvert.Location = New System.Drawing.Point(202, 142)
        Me.cmdConvert.Name = "cmdConvert"
        Me.cmdConvert.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdConvert.Size = New System.Drawing.Size(73, 25)
        Me.cmdConvert.TabIndex = 88
        Me.cmdConvert.Text = "Con&vert"
        Me.cmdConvert.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Window
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(80, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(140, 25)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "Time to convert (hh:mm:ss)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(182, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(238, 20)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "Angle or Time to Decimal Conversion"
        '
        'lblHs
        '
        Me.lblHs.BackColor = System.Drawing.SystemColors.Window
        Me.lblHs.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHs.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHs.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHs.Location = New System.Drawing.Point(85, 72)
        Me.lblHs.Name = "lblHs"
        Me.lblHs.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblHs.Size = New System.Drawing.Size(97, 17)
        Me.lblHs.TabIndex = 94
        Me.lblHs.Text = "Angle  to convert"
        '
        'lblHsDeg
        '
        Me.lblHsDeg.BackColor = System.Drawing.SystemColors.Window
        Me.lblHsDeg.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHsDeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHsDeg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHsDeg.Location = New System.Drawing.Point(259, 71)
        Me.lblHsDeg.Name = "lblHsDeg"
        Me.lblHsDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblHsDeg.Size = New System.Drawing.Size(9, 17)
        Me.lblHsDeg.TabIndex = 93
        Me.lblHsDeg.Text = "°"
        '
        'lblHsMin
        '
        Me.lblHsMin.BackColor = System.Drawing.SystemColors.Window
        Me.lblHsMin.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHsMin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHsMin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHsMin.Location = New System.Drawing.Point(299, 71)
        Me.lblHsMin.Name = "lblHsMin"
        Me.lblHsMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblHsMin.Size = New System.Drawing.Size(9, 17)
        Me.lblHsMin.TabIndex = 92
        Me.lblHsMin.Text = "'"
        '
        'lblHsSec
        '
        Me.lblHsSec.BackColor = System.Drawing.SystemColors.Window
        Me.lblHsSec.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHsSec.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHsSec.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHsSec.Location = New System.Drawing.Point(339, 71)
        Me.lblHsSec.Name = "lblHsSec"
        Me.lblHsSec.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblHsSec.Size = New System.Drawing.Size(9, 17)
        Me.lblHsSec.TabIndex = 91
        Me.lblHsSec.Text = """"
        Me.lblHsSec.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.AngleAddSubtract)
        Me.TabControl1.Controls.Add(Me.TimeAddSubtract)
        Me.TabControl1.Controls.Add(Me.TimeofDateCalc)
        Me.TabControl1.Controls.Add(Me.TimeZoneCalc)
        Me.TabControl1.Controls.Add(Me.ConvertAngleorTime)
        Me.TabControl1.Location = New System.Drawing.Point(4, 22)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(607, 393)
        Me.TabControl1.TabIndex = 138
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CelestialTools.My.Resources.Resources.ABC_white
        Me.PictureBox1.Location = New System.Drawing.Point(159, 417)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(316, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 139
        Me.PictureBox1.TabStop = False
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrint.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.Location = New System.Drawing.Point(587, 3)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrint.Size = New System.Drawing.Size(21, 21)
        Me.cmdPrint.TabIndex = 95
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdPrint.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(96, 282)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(402, 13)
        Me.Label11.TabIndex = 171
        Me.Label11.Text = "The ZTInfo form offers an improved version of this functionality off the Main Men" &
    "u"
        '
        'FormNavMath
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(615, 483)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ExitBtn)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(3, 29)
        Me.MaximizeBox = False
        Me.Name = "FormNavMath"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Navigation Math"
        Me.TimeZoneCalc.ResumeLayout(False)
        Me.TimeZoneCalc.PerformLayout()
        Me.TimeofDateCalc.ResumeLayout(False)
        Me.TimeofDateCalc.PerformLayout()
        Me.Frame2.ResumeLayout(False)
        Me.TimeAddSubtract.ResumeLayout(False)
        Me.TimeAddSubtract.PerformLayout()
        CType(Me.DTRSeconds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTRMinutes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTRHours, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTRDays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT2Seconds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT2Minutes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT2Hours, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT2Days, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT1Seconds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT1Minutes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT1Hours, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT1Days, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame3.ResumeLayout(False)
        Me.AngleAddSubtract.ResumeLayout(False)
        Me.AngleAddSubtract.PerformLayout()
        Me.Frame4.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        Me.ConvertAngleorTime.ResumeLayout(False)
        Me.ConvertAngleorTime.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents ExitBtn As Button
    Friend WithEvents TimeZoneCalc As TabPage
    Public WithEvents cboLo As ComboBox
    Public WithEvents txtZD As TextBox
    Public WithEvents txtLoDeg As TextBox
    Public WithEvents txtLoMin As TextBox
    Public WithEvents cmdClearTZ As Button
    Public WithEvents Label35 As Label
    Public WithEvents lblLoDeg As Label
    Public WithEvents lblLoMin As Label
    Public WithEvents Label34 As Label
    Public WithEvents Label24 As Label
    Friend WithEvents TimeofDateCalc As TabPage
    Public WithEvents txtIntD As TextBox
    Public WithEvents txtIntM As TextBox
    Public WithEvents txtIntH As TextBox
    Public WithEvents txtZDh2 As TextBox
    Public WithEvents txtZDh1 As TextBox
    Public WithEvents txtDays As TextBox
    Public WithEvents txtTimeResult As TextBox
    Public WithEvents txtTime1 As TextBox
    Public WithEvents Frame2 As Panel
    Public WithEvents optSubtractToD As RadioButton
    Public WithEvents optAddToD As RadioButton
    Public WithEvents cboZDm2 As ComboBox
    Public WithEvents chkDST2 As CheckBox
    Public WithEvents cboZDm1 As ComboBox
    Public WithEvents chkDST1 As CheckBox
    Public WithEvents cmdCalculateToD As Button
    Public WithEvents cmdClearToD As Button
    Public WithEvents Label38 As Label
    Public WithEvents Label36 As Label
    Public WithEvents Label37 As Label
    Public WithEvents Label26 As Label
    Public WithEvents Label23 As Label
    Public WithEvents lblZD2 As Label
    Public WithEvents lblZDh2 As Label
    Public WithEvents lblZDm2 As Label
    Public WithEvents lblZDDST2 As Label
    Public WithEvents lblZD1 As Label
    Public WithEvents lblZDh1 As Label
    Public WithEvents lblZDm1 As Label
    Public WithEvents lblZDDST1 As Label
    Public WithEvents Label25 As Label
    Friend WithEvents TimeAddSubtract As TabPage
    Public WithEvents cmdClearTimes As Button
    Public WithEvents cmdCalculateTimes As Button
    Public WithEvents Frame3 As Panel
    Public WithEvents optAddTimes As RadioButton
    Public WithEvents optSubtractTimes As RadioButton
    Public WithEvents Label27 As Label
    Friend WithEvents AngleAddSubtract As TabPage
    Public WithEvents txtMin3 As TextBox
    Public WithEvents txtDeg3 As TextBox
    Public WithEvents txtResult As TextBox
    Public WithEvents txtDeg1 As TextBox
    Public WithEvents txtMin1 As TextBox
    Public WithEvents txtDeg2 As TextBox
    Public WithEvents txtMin2 As TextBox
    Public WithEvents Frame4 As Panel
    Public WithEvents optSubtract2 As RadioButton
    Public WithEvents optAdd2 As RadioButton
    Public WithEvents cmdClearAddSubtract As Button
    Public WithEvents Frame1 As Panel
    Public WithEvents optAdd1 As RadioButton
    Public WithEvents optSubtract1 As RadioButton
    Public WithEvents Label42 As Label
    Public WithEvents Label41 As Label
    Public WithEvents Label20 As Label
    Public WithEvents Label19 As Label
    Public WithEvents Label18 As Label
    Public WithEvents Label17 As Label
    Public WithEvents Label16 As Label
    Public WithEvents Label15 As Label
    Public WithEvents Label4 As Label
    Friend WithEvents ConvertAngleorTime As TabPage
    Public WithEvents optHsDMm As RadioButton
    Public WithEvents txtConvertedTime As TextBox
    Public WithEvents txtAngle As TextBox
    Public WithEvents txtHsDeg As TextBox
    Public WithEvents txtHsMin As TextBox
    Public WithEvents txtHsSec As TextBox
    Public WithEvents optHsDMS As RadioButton
    Public WithEvents cmdClearConverter As Button
    Public WithEvents cmdConvert As Button
    Public WithEvents Label3 As Label
    Public WithEvents Label2 As Label
    Public WithEvents lblHs As Label
    Public WithEvents lblHsDeg As Label
    Public WithEvents lblHsMin As Label
    Public WithEvents lblHsSec As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Public WithEvents cmdPrint As Button
    Friend WithEvents dtTime As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Public WithEvents btnAddSubtract As Button
    Public WithEvents btnZDCalc As Button
    Friend WithEvents Label1 As Label
    Public WithEvents btnMoveResult As Button
    Friend WithEvents DTRSeconds As NumericUpDown
    Friend WithEvents DTRMinutes As NumericUpDown
    Friend WithEvents DTRHours As NumericUpDown
    Friend WithEvents DTRDays As NumericUpDown
    Friend WithEvents DT2Seconds As NumericUpDown
    Friend WithEvents DT2Minutes As NumericUpDown
    Friend WithEvents DT2Hours As NumericUpDown
    Friend WithEvents DT2Days As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents DT1Seconds As NumericUpDown
    Friend WithEvents DT1Minutes As NumericUpDown
    Friend WithEvents DT1Hours As NumericUpDown
    Friend WithEvents DT1Days As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
#End Region
End Class