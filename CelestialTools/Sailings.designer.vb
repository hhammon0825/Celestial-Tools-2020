<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FormSailings
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
    Public WithEvents cmdTraverse As System.Windows.Forms.Button
    Public WithEvents txtL3Min As System.Windows.Forms.TextBox
    Public WithEvents cboL3 As System.Windows.Forms.ComboBox
    Public WithEvents txtL3Deg As System.Windows.Forms.TextBox
    Public WithEvents optMethod2 As System.Windows.Forms.RadioButton
    Public WithEvents optMethod1 As System.Windows.Forms.RadioButton
    Public WithEvents Frame3 As System.Windows.Forms.Panel
    Public WithEvents chkComposite As System.Windows.Forms.CheckBox
    Public WithEvents cboMLmin As System.Windows.Forms.ComboBox
    Public WithEvents chkDriftAngle As System.Windows.Forms.CheckBox
    Public WithEvents txtFix1LM As System.Windows.Forms.TextBox
    Public WithEvents cboFix1L As System.Windows.Forms.ComboBox
    Public WithEvents txtFix1LD As System.Windows.Forms.TextBox
    Public WithEvents txtFix1LoD As System.Windows.Forms.TextBox
    Public WithEvents txtFix1LoM As System.Windows.Forms.TextBox
    Public WithEvents cboFix1Lo As System.Windows.Forms.ComboBox
    Public WithEvents optL2Lo2GC As System.Windows.Forms.RadioButton
    Public WithEvents optICD As System.Windows.Forms.RadioButton
    Public WithEvents frameCalculateGC As System.Windows.Forms.GroupBox
    Public WithEvents cmdPoints As System.Windows.Forms.Button
    Public WithEvents optMercatorS As System.Windows.Forms.RadioButton
    Public WithEvents optAccurateRhumb As System.Windows.Forms.RadioButton
    Public WithEvents optGreatCircle As System.Windows.Forms.RadioButton
    Public WithEvents optMercatorE As System.Windows.Forms.RadioButton
    Public WithEvents optMidLat As System.Windows.Forms.RadioButton
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents txtTime2 As System.Windows.Forms.TextBox
    Public WithEvents txtTime1 As System.Windows.Forms.TextBox
    Public WithEvents txtLog2 As System.Windows.Forms.TextBox
    Public WithEvents txtLog1 As System.Windows.Forms.TextBox
    Public WithEvents cboML As System.Windows.Forms.ComboBox
    Public WithEvents txtMLDeg As System.Windows.Forms.TextBox
    Public WithEvents chkML As System.Windows.Forms.CheckBox
    Public WithEvents cmdPrint As System.Windows.Forms.Button
    Public WithEvents cmdClearSwap As System.Windows.Forms.Button
    Public WithEvents cmdClearAll As System.Windows.Forms.Button
    Public WithEvents cmdCalculate As System.Windows.Forms.Button
    Public WithEvents txtTimem As System.Windows.Forms.TextBox
    Public WithEvents txtTimeh As System.Windows.Forms.TextBox
    Public WithEvents txtSpeed As System.Windows.Forms.TextBox
    Public WithEvents txtDist As System.Windows.Forms.TextBox
    Public WithEvents txtCourse As System.Windows.Forms.TextBox
    Public WithEvents optSD As System.Windows.Forms.RadioButton
    Public WithEvents optCD As System.Windows.Forms.RadioButton
    Public WithEvents optL2Lo2 As System.Windows.Forms.RadioButton
    Public WithEvents frameCalculate As System.Windows.Forms.GroupBox
    Public WithEvents cboLo1 As System.Windows.Forms.ComboBox
    Public WithEvents txtLo1Min As System.Windows.Forms.TextBox
    Public WithEvents txtLo1Deg As System.Windows.Forms.TextBox
    Public WithEvents txtL1Deg As System.Windows.Forms.TextBox
    Public WithEvents cboL1 As System.Windows.Forms.ComboBox
    Public WithEvents txtL1Min As System.Windows.Forms.TextBox
    Public WithEvents cboLo2 As System.Windows.Forms.ComboBox
    Public WithEvents txtLo2Min As System.Windows.Forms.TextBox
    Public WithEvents txtLo2Deg As System.Windows.Forms.TextBox
    Public WithEvents txtL2Deg As System.Windows.Forms.TextBox
    Public WithEvents cboL2 As System.Windows.Forms.ComboBox
    Public WithEvents txtL2Min As System.Windows.Forms.TextBox
    Public WithEvents Label15 As System.Windows.Forms.Label
    Public WithEvents Label16 As System.Windows.Forms.Label
    Public WithEvents lblLimLat As System.Windows.Forms.Label
    Public WithEvents Label14 As System.Windows.Forms.Label
    Public WithEvents Label13 As System.Windows.Forms.Label
    Public WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents lblInitial As System.Windows.Forms.Label
    Public WithEvents lblor2 As System.Windows.Forms.Label
    'Public WithEvents Line6 As Microsoft.VisualBasic.PowerPacks.LineShape
    'Public WithEvents Line5 As Microsoft.VisualBasic.PowerPacks.LineShape
    'Public WithEvents Line4 As Microsoft.VisualBasic.PowerPacks.LineShape
    'Public WithEvents Line3 As Microsoft.VisualBasic.PowerPacks.LineShape
    'Public WithEvents Line2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Public WithEvents lblTime2 As System.Windows.Forms.Label
    Public WithEvents lblTime1 As System.Windows.Forms.Label
    'Public WithEvents Shape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Public WithEvents lblLog2nm As System.Windows.Forms.Label
    Public WithEvents lblLog1nm As System.Windows.Forms.Label
    Public WithEvents lblLog2 As System.Windows.Forms.Label
    Public WithEvents lblLog1 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents lblFixLo As System.Windows.Forms.Label
    Public WithEvents lblFixL As System.Windows.Forms.Label
    Public WithEvents lblDRLo As System.Windows.Forms.Label
    Public WithEvents lblDRL As System.Windows.Forms.Label
    'Public WithEvents Line1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Public WithEvents lblm As System.Windows.Forms.Label
    Public WithEvents lblh As System.Windows.Forms.Label
    Public WithEvents lblTime As System.Windows.Forms.Label
    Public WithEvents lblkn As System.Windows.Forms.Label
    Public WithEvents lblSpeed As System.Windows.Forms.Label
    Public WithEvents lblor As System.Windows.Forms.Label
    Public WithEvents lblnm As System.Windows.Forms.Label
    Public WithEvents lblDistance As System.Windows.Forms.Label
    Public WithEvents lblCourseDeg As System.Windows.Forms.Label
    Public WithEvents lblCourse As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents lblLo1 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents lblL1 As System.Windows.Forms.Label
    Public WithEvents lblLoMin As System.Windows.Forms.Label
    Public WithEvents lblLoDeg As System.Windows.Forms.Label
    Public WithEvents lblLo2 As System.Windows.Forms.Label
    Public WithEvents lblLMin As System.Windows.Forms.Label
    Public WithEvents lblLDeg As System.Windows.Forms.Label
    Public WithEvents lblL2 As System.Windows.Forms.Label
    'Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSailings))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtL3Min = New System.Windows.Forms.TextBox()
        Me.txtL3Deg = New System.Windows.Forms.TextBox()
        Me.txtFix1LM = New System.Windows.Forms.TextBox()
        Me.txtFix1LD = New System.Windows.Forms.TextBox()
        Me.txtFix1LoD = New System.Windows.Forms.TextBox()
        Me.txtFix1LoM = New System.Windows.Forms.TextBox()
        Me.txtTime2 = New System.Windows.Forms.TextBox()
        Me.txtTime1 = New System.Windows.Forms.TextBox()
        Me.txtLog2 = New System.Windows.Forms.TextBox()
        Me.txtLog1 = New System.Windows.Forms.TextBox()
        Me.txtMLDeg = New System.Windows.Forms.TextBox()
        Me.txtTimem = New System.Windows.Forms.TextBox()
        Me.txtTimeh = New System.Windows.Forms.TextBox()
        Me.txtSpeed = New System.Windows.Forms.TextBox()
        Me.txtDist = New System.Windows.Forms.TextBox()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.txtLo1Min = New System.Windows.Forms.TextBox()
        Me.txtLo1Deg = New System.Windows.Forms.TextBox()
        Me.txtL1Deg = New System.Windows.Forms.TextBox()
        Me.txtL1Min = New System.Windows.Forms.TextBox()
        Me.txtLo2Min = New System.Windows.Forms.TextBox()
        Me.txtLo2Deg = New System.Windows.Forms.TextBox()
        Me.txtL2Deg = New System.Windows.Forms.TextBox()
        Me.txtL2Min = New System.Windows.Forms.TextBox()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdTraverse = New System.Windows.Forms.Button()
        Me.cboL3 = New System.Windows.Forms.ComboBox()
        Me.Frame3 = New System.Windows.Forms.Panel()
        Me.optMethod2 = New System.Windows.Forms.RadioButton()
        Me.optMethod1 = New System.Windows.Forms.RadioButton()
        Me.chkComposite = New System.Windows.Forms.CheckBox()
        Me.cboMLmin = New System.Windows.Forms.ComboBox()
        Me.chkDriftAngle = New System.Windows.Forms.CheckBox()
        Me.cboFix1L = New System.Windows.Forms.ComboBox()
        Me.cboFix1Lo = New System.Windows.Forms.ComboBox()
        Me.frameCalculateGC = New System.Windows.Forms.GroupBox()
        Me.optL2Lo2GC = New System.Windows.Forms.RadioButton()
        Me.optICD = New System.Windows.Forms.RadioButton()
        Me.cmdPoints = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.optMercatorS = New System.Windows.Forms.RadioButton()
        Me.optAccurateRhumb = New System.Windows.Forms.RadioButton()
        Me.optGreatCircle = New System.Windows.Forms.RadioButton()
        Me.optMercatorE = New System.Windows.Forms.RadioButton()
        Me.optMidLat = New System.Windows.Forms.RadioButton()
        Me.cboML = New System.Windows.Forms.ComboBox()
        Me.chkML = New System.Windows.Forms.CheckBox()
        Me.cmdClearSwap = New System.Windows.Forms.Button()
        Me.cmdClearAll = New System.Windows.Forms.Button()
        Me.cmdCalculate = New System.Windows.Forms.Button()
        Me.frameCalculate = New System.Windows.Forms.GroupBox()
        Me.optSD = New System.Windows.Forms.RadioButton()
        Me.optCD = New System.Windows.Forms.RadioButton()
        Me.optL2Lo2 = New System.Windows.Forms.RadioButton()
        Me.cboLo1 = New System.Windows.Forms.ComboBox()
        Me.cboL1 = New System.Windows.Forms.ComboBox()
        Me.cboLo2 = New System.Windows.Forms.ComboBox()
        Me.cboL2 = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblLimLat = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblInitial = New System.Windows.Forms.Label()
        Me.lblor2 = New System.Windows.Forms.Label()
        Me.lblTime2 = New System.Windows.Forms.Label()
        Me.lblTime1 = New System.Windows.Forms.Label()
        Me.lblLog2nm = New System.Windows.Forms.Label()
        Me.lblLog1nm = New System.Windows.Forms.Label()
        Me.lblLog2 = New System.Windows.Forms.Label()
        Me.lblLog1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFixLo = New System.Windows.Forms.Label()
        Me.lblFixL = New System.Windows.Forms.Label()
        Me.lblDRLo = New System.Windows.Forms.Label()
        Me.lblDRL = New System.Windows.Forms.Label()
        Me.lblm = New System.Windows.Forms.Label()
        Me.lblh = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblkn = New System.Windows.Forms.Label()
        Me.lblSpeed = New System.Windows.Forms.Label()
        Me.lblor = New System.Windows.Forms.Label()
        Me.lblnm = New System.Windows.Forms.Label()
        Me.lblDistance = New System.Windows.Forms.Label()
        Me.lblCourseDeg = New System.Windows.Forms.Label()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblLo1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblL1 = New System.Windows.Forms.Label()
        Me.lblLoMin = New System.Windows.Forms.Label()
        Me.lblLoDeg = New System.Windows.Forms.Label()
        Me.lblLo2 = New System.Windows.Forms.Label()
        Me.lblLMin = New System.Windows.Forms.Label()
        Me.lblLDeg = New System.Windows.Forms.Label()
        Me.lblL2 = New System.Windows.Forms.Label()
        Me.txtSailings = New System.Windows.Forms.RichTextBox()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.cmdRhumbPoints = New System.Windows.Forms.Button()
        Me.txtUserInfo = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Frame3.SuspendLayout()
        Me.frameCalculateGC.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.frameCalculate.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtL3Min
        '
        Me.txtL3Min.AcceptsReturn = True
        Me.txtL3Min.BackColor = System.Drawing.SystemColors.Window
        Me.txtL3Min.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtL3Min.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtL3Min.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtL3Min.Location = New System.Drawing.Point(289, 220)
        Me.txtL3Min.MaxLength = 0
        Me.txtL3Min.Name = "txtL3Min"
        Me.txtL3Min.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtL3Min.Size = New System.Drawing.Size(33, 20)
        Me.txtL3Min.TabIndex = 100
        Me.ToolTip1.SetToolTip(Me.txtL3Min, "Range 0 to 59.9")
        '
        'txtL3Deg
        '
        Me.txtL3Deg.AcceptsReturn = True
        Me.txtL3Deg.BackColor = System.Drawing.SystemColors.Window
        Me.txtL3Deg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtL3Deg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtL3Deg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtL3Deg.Location = New System.Drawing.Point(254, 220)
        Me.txtL3Deg.MaxLength = 0
        Me.txtL3Deg.Name = "txtL3Deg"
        Me.txtL3Deg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtL3Deg.Size = New System.Drawing.Size(25, 20)
        Me.txtL3Deg.TabIndex = 99
        Me.ToolTip1.SetToolTip(Me.txtL3Deg, "Range 1 to 89")
        '
        'txtFix1LM
        '
        Me.txtFix1LM.AcceptsReturn = True
        Me.txtFix1LM.BackColor = System.Drawing.SystemColors.Window
        Me.txtFix1LM.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFix1LM.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFix1LM.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFix1LM.Location = New System.Drawing.Point(105, 245)
        Me.txtFix1LM.MaxLength = 4
        Me.txtFix1LM.Name = "txtFix1LM"
        Me.txtFix1LM.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFix1LM.Size = New System.Drawing.Size(33, 20)
        Me.txtFix1LM.TabIndex = 89
        Me.ToolTip1.SetToolTip(Me.txtFix1LM, "Range 0 to 59.9")
        Me.txtFix1LM.Visible = False
        '
        'txtFix1LD
        '
        Me.txtFix1LD.AcceptsReturn = True
        Me.txtFix1LD.BackColor = System.Drawing.SystemColors.Window
        Me.txtFix1LD.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFix1LD.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFix1LD.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFix1LD.Location = New System.Drawing.Point(60, 245)
        Me.txtFix1LD.MaxLength = 2
        Me.txtFix1LD.Name = "txtFix1LD"
        Me.txtFix1LD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFix1LD.Size = New System.Drawing.Size(35, 20)
        Me.txtFix1LD.TabIndex = 88
        Me.ToolTip1.SetToolTip(Me.txtFix1LD, "Range 0 to 89")
        Me.txtFix1LD.Visible = False
        '
        'txtFix1LoD
        '
        Me.txtFix1LoD.AcceptsReturn = True
        Me.txtFix1LoD.BackColor = System.Drawing.SystemColors.Window
        Me.txtFix1LoD.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFix1LoD.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFix1LoD.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFix1LoD.Location = New System.Drawing.Point(60, 269)
        Me.txtFix1LoD.MaxLength = 3
        Me.txtFix1LoD.Name = "txtFix1LoD"
        Me.txtFix1LoD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFix1LoD.Size = New System.Drawing.Size(35, 20)
        Me.txtFix1LoD.TabIndex = 91
        Me.ToolTip1.SetToolTip(Me.txtFix1LoD, "Range 0 to 180")
        Me.txtFix1LoD.Visible = False
        '
        'txtFix1LoM
        '
        Me.txtFix1LoM.AcceptsReturn = True
        Me.txtFix1LoM.BackColor = System.Drawing.SystemColors.Window
        Me.txtFix1LoM.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFix1LoM.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFix1LoM.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFix1LoM.Location = New System.Drawing.Point(105, 269)
        Me.txtFix1LoM.MaxLength = 4
        Me.txtFix1LoM.Name = "txtFix1LoM"
        Me.txtFix1LoM.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFix1LoM.Size = New System.Drawing.Size(33, 20)
        Me.txtFix1LoM.TabIndex = 92
        Me.ToolTip1.SetToolTip(Me.txtFix1LoM, "Range 0 to 59.9")
        Me.txtFix1LoM.Visible = False
        '
        'txtTime2
        '
        Me.txtTime2.AcceptsReturn = True
        Me.txtTime2.BackColor = System.Drawing.SystemColors.Window
        Me.txtTime2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTime2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTime2.Location = New System.Drawing.Point(496, 160)
        Me.txtTime2.MaxLength = 4
        Me.txtTime2.Name = "txtTime2"
        Me.txtTime2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTime2.Size = New System.Drawing.Size(33, 20)
        Me.txtTime2.TabIndex = 64
        Me.ToolTip1.SetToolTip(Me.txtTime2, "Range 0000 to 2359")
        '
        'txtTime1
        '
        Me.txtTime1.AcceptsReturn = True
        Me.txtTime1.BackColor = System.Drawing.SystemColors.Window
        Me.txtTime1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTime1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTime1.Location = New System.Drawing.Point(496, 136)
        Me.txtTime1.MaxLength = 4
        Me.txtTime1.Name = "txtTime1"
        Me.txtTime1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTime1.Size = New System.Drawing.Size(33, 20)
        Me.txtTime1.TabIndex = 63
        Me.ToolTip1.SetToolTip(Me.txtTime1, "Range 0000 to 2359")
        '
        'txtLog2
        '
        Me.txtLog2.AcceptsReturn = True
        Me.txtLog2.BackColor = System.Drawing.SystemColors.Window
        Me.txtLog2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLog2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLog2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLog2.Location = New System.Drawing.Point(240, 160)
        Me.txtLog2.MaxLength = 6
        Me.txtLog2.Name = "txtLog2"
        Me.txtLog2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLog2.Size = New System.Drawing.Size(41, 20)
        Me.txtLog2.TabIndex = 58
        Me.ToolTip1.SetToolTip(Me.txtLog2, "Range 0 to 9999.9")
        '
        'txtLog1
        '
        Me.txtLog1.AcceptsReturn = True
        Me.txtLog1.BackColor = System.Drawing.SystemColors.Window
        Me.txtLog1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLog1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLog1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLog1.Location = New System.Drawing.Point(240, 136)
        Me.txtLog1.MaxLength = 6
        Me.txtLog1.Name = "txtLog1"
        Me.txtLog1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLog1.Size = New System.Drawing.Size(41, 20)
        Me.txtLog1.TabIndex = 57
        Me.ToolTip1.SetToolTip(Me.txtLog1, "Range 0 to 9999.9")
        '
        'txtMLDeg
        '
        Me.txtMLDeg.AcceptsReturn = True
        Me.txtMLDeg.BackColor = System.Drawing.SystemColors.Window
        Me.txtMLDeg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMLDeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMLDeg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMLDeg.Location = New System.Drawing.Point(415, 243)
        Me.txtMLDeg.MaxLength = 2
        Me.txtMLDeg.Name = "txtMLDeg"
        Me.txtMLDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMLDeg.Size = New System.Drawing.Size(25, 20)
        Me.txtMLDeg.TabIndex = 52
        Me.ToolTip1.SetToolTip(Me.txtMLDeg, "Range 0 to 55")
        '
        'txtTimem
        '
        Me.txtTimem.AcceptsReturn = True
        Me.txtTimem.BackColor = System.Drawing.SystemColors.Window
        Me.txtTimem.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTimem.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimem.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTimem.Location = New System.Drawing.Point(496, 195)
        Me.txtTimem.MaxLength = 3
        Me.txtTimem.Name = "txtTimem"
        Me.txtTimem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTimem.Size = New System.Drawing.Size(33, 20)
        Me.txtTimem.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.txtTimem, "Range 0 to 999 or 59")
        '
        'txtTimeh
        '
        Me.txtTimeh.AcceptsReturn = True
        Me.txtTimeh.BackColor = System.Drawing.SystemColors.Window
        Me.txtTimeh.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTimeh.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimeh.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTimeh.Location = New System.Drawing.Point(454, 195)
        Me.txtTimeh.MaxLength = 2
        Me.txtTimeh.Name = "txtTimeh"
        Me.txtTimeh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTimeh.Size = New System.Drawing.Size(33, 20)
        Me.txtTimeh.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.txtTimeh, "Range 0 to 99")
        '
        'txtSpeed
        '
        Me.txtSpeed.AcceptsReturn = True
        Me.txtSpeed.BackColor = System.Drawing.SystemColors.Window
        Me.txtSpeed.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSpeed.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSpeed.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSpeed.Location = New System.Drawing.Point(356, 195)
        Me.txtSpeed.MaxLength = 4
        Me.txtSpeed.Name = "txtSpeed"
        Me.txtSpeed.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSpeed.Size = New System.Drawing.Size(33, 20)
        Me.txtSpeed.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.txtSpeed, "Range 0 to 99.9")
        '
        'txtDist
        '
        Me.txtDist.AcceptsReturn = True
        Me.txtDist.BackColor = System.Drawing.SystemColors.Window
        Me.txtDist.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDist.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDist.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDist.Location = New System.Drawing.Point(232, 195)
        Me.txtDist.MaxLength = 7
        Me.txtDist.Name = "txtDist"
        Me.txtDist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDist.Size = New System.Drawing.Size(49, 20)
        Me.txtDist.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.txtDist, "Range 0 to 10800")
        '
        'txtCourse
        '
        Me.txtCourse.AcceptsReturn = True
        Me.txtCourse.BackColor = System.Drawing.SystemColors.Window
        Me.txtCourse.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCourse.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourse.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCourse.Location = New System.Drawing.Point(248, 104)
        Me.txtCourse.MaxLength = 5
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCourse.Size = New System.Drawing.Size(41, 20)
        Me.txtCourse.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.txtCourse, "Range 0 to 359.9")
        '
        'txtLo1Min
        '
        Me.txtLo1Min.AcceptsReturn = True
        Me.txtLo1Min.BackColor = System.Drawing.SystemColors.Window
        Me.txtLo1Min.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLo1Min.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLo1Min.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLo1Min.Location = New System.Drawing.Point(94, 127)
        Me.txtLo1Min.MaxLength = 4
        Me.txtLo1Min.Name = "txtLo1Min"
        Me.txtLo1Min.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLo1Min.Size = New System.Drawing.Size(33, 20)
        Me.txtLo1Min.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.txtLo1Min, "Range 0 to 59.9")
        '
        'txtLo1Deg
        '
        Me.txtLo1Deg.AcceptsReturn = True
        Me.txtLo1Deg.BackColor = System.Drawing.SystemColors.Window
        Me.txtLo1Deg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLo1Deg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLo1Deg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLo1Deg.Location = New System.Drawing.Point(54, 127)
        Me.txtLo1Deg.MaxLength = 3
        Me.txtLo1Deg.Name = "txtLo1Deg"
        Me.txtLo1Deg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLo1Deg.Size = New System.Drawing.Size(33, 20)
        Me.txtLo1Deg.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txtLo1Deg, "Range 0 to 180")
        '
        'txtL1Deg
        '
        Me.txtL1Deg.AcceptsReturn = True
        Me.txtL1Deg.BackColor = System.Drawing.SystemColors.Window
        Me.txtL1Deg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtL1Deg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtL1Deg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtL1Deg.Location = New System.Drawing.Point(54, 103)
        Me.txtL1Deg.MaxLength = 2
        Me.txtL1Deg.Name = "txtL1Deg"
        Me.txtL1Deg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtL1Deg.Size = New System.Drawing.Size(33, 20)
        Me.txtL1Deg.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtL1Deg, "Range 0 to 84")
        '
        'txtL1Min
        '
        Me.txtL1Min.AcceptsReturn = True
        Me.txtL1Min.BackColor = System.Drawing.SystemColors.Window
        Me.txtL1Min.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtL1Min.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtL1Min.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtL1Min.Location = New System.Drawing.Point(94, 103)
        Me.txtL1Min.MaxLength = 4
        Me.txtL1Min.Name = "txtL1Min"
        Me.txtL1Min.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtL1Min.Size = New System.Drawing.Size(33, 20)
        Me.txtL1Min.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtL1Min, "Range 0 to 59.9")
        '
        'txtLo2Min
        '
        Me.txtLo2Min.AcceptsReturn = True
        Me.txtLo2Min.BackColor = System.Drawing.SystemColors.Window
        Me.txtLo2Min.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLo2Min.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLo2Min.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLo2Min.Location = New System.Drawing.Point(94, 197)
        Me.txtLo2Min.MaxLength = 4
        Me.txtLo2Min.Name = "txtLo2Min"
        Me.txtLo2Min.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLo2Min.Size = New System.Drawing.Size(33, 20)
        Me.txtLo2Min.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.txtLo2Min, "Range 0 to 59.9")
        Me.txtLo2Min.Visible = False
        '
        'txtLo2Deg
        '
        Me.txtLo2Deg.AcceptsReturn = True
        Me.txtLo2Deg.BackColor = System.Drawing.SystemColors.Window
        Me.txtLo2Deg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLo2Deg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLo2Deg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLo2Deg.Location = New System.Drawing.Point(54, 197)
        Me.txtLo2Deg.MaxLength = 3
        Me.txtLo2Deg.Name = "txtLo2Deg"
        Me.txtLo2Deg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLo2Deg.Size = New System.Drawing.Size(33, 20)
        Me.txtLo2Deg.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.txtLo2Deg, "Range 0 to 180")
        Me.txtLo2Deg.Visible = False
        '
        'txtL2Deg
        '
        Me.txtL2Deg.AcceptsReturn = True
        Me.txtL2Deg.BackColor = System.Drawing.SystemColors.Window
        Me.txtL2Deg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtL2Deg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtL2Deg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtL2Deg.Location = New System.Drawing.Point(54, 173)
        Me.txtL2Deg.MaxLength = 2
        Me.txtL2Deg.Name = "txtL2Deg"
        Me.txtL2Deg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtL2Deg.Size = New System.Drawing.Size(33, 20)
        Me.txtL2Deg.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.txtL2Deg, "Range 0 to 84")
        Me.txtL2Deg.Visible = False
        '
        'txtL2Min
        '
        Me.txtL2Min.AcceptsReturn = True
        Me.txtL2Min.BackColor = System.Drawing.SystemColors.Window
        Me.txtL2Min.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtL2Min.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtL2Min.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtL2Min.Location = New System.Drawing.Point(94, 173)
        Me.txtL2Min.MaxLength = 4
        Me.txtL2Min.Name = "txtL2Min"
        Me.txtL2Min.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtL2Min.Size = New System.Drawing.Size(33, 20)
        Me.txtL2Min.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.txtL2Min, "Range 0 to 59.9")
        Me.txtL2Min.Visible = False
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrint.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.Location = New System.Drawing.Point(517, 7)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrint.Size = New System.Drawing.Size(21, 21)
        Me.cmdPrint.TabIndex = 45
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdPrint, "Print window")
        Me.cmdPrint.UseVisualStyleBackColor = False
        '
        'cmdTraverse
        '
        Me.cmdTraverse.BackColor = System.Drawing.Color.Blue
        Me.cmdTraverse.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdTraverse.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTraverse.ForeColor = System.Drawing.Color.White
        Me.cmdTraverse.Location = New System.Drawing.Point(348, 267)
        Me.cmdTraverse.Name = "cmdTraverse"
        Me.cmdTraverse.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdTraverse.Size = New System.Drawing.Size(200, 25)
        Me.cmdTraverse.TabIndex = 104
        Me.cmdTraverse.Text = """Simplified Traverse Table"" Calc"
        Me.cmdTraverse.UseVisualStyleBackColor = False
        Me.cmdTraverse.Visible = False
        '
        'cboL3
        '
        Me.cboL3.BackColor = System.Drawing.SystemColors.Window
        Me.cboL3.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboL3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboL3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboL3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboL3.Items.AddRange(New Object() {"N", "S"})
        Me.cboL3.Location = New System.Drawing.Point(334, 218)
        Me.cboL3.Name = "cboL3"
        Me.cboL3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboL3.Size = New System.Drawing.Size(41, 22)
        Me.cboL3.TabIndex = 101
        Me.cboL3.Visible = False
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.SystemColors.Window
        Me.Frame3.Controls.Add(Me.optMethod2)
        Me.Frame3.Controls.Add(Me.optMethod1)
        Me.Frame3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Frame3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(380, 218)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(161, 22)
        Me.Frame3.TabIndex = 95
        '
        'optMethod2
        '
        Me.optMethod2.BackColor = System.Drawing.SystemColors.Window
        Me.optMethod2.Cursor = System.Windows.Forms.Cursors.Default
        Me.optMethod2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optMethod2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optMethod2.Location = New System.Drawing.Point(88, 3)
        Me.optMethod2.Name = "optMethod2"
        Me.optMethod2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optMethod2.Size = New System.Drawing.Size(69, 17)
        Me.optMethod2.TabIndex = 97
        Me.optMethod2.TabStop = True
        Me.optMethod2.Text = "Method 2"
        Me.optMethod2.UseVisualStyleBackColor = False
        '
        'optMethod1
        '
        Me.optMethod1.BackColor = System.Drawing.SystemColors.Window
        Me.optMethod1.Cursor = System.Windows.Forms.Cursors.Default
        Me.optMethod1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optMethod1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optMethod1.Location = New System.Drawing.Point(8, 3)
        Me.optMethod1.Name = "optMethod1"
        Me.optMethod1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optMethod1.Size = New System.Drawing.Size(69, 17)
        Me.optMethod1.TabIndex = 96
        Me.optMethod1.TabStop = True
        Me.optMethod1.Text = "Method 1"
        Me.optMethod1.UseVisualStyleBackColor = False
        '
        'chkComposite
        '
        Me.chkComposite.BackColor = System.Drawing.SystemColors.Window
        Me.chkComposite.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkComposite.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkComposite.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkComposite.Location = New System.Drawing.Point(40, 224)
        Me.chkComposite.Name = "chkComposite"
        Me.chkComposite.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkComposite.Size = New System.Drawing.Size(140, 17)
        Me.chkComposite.TabIndex = 94
        Me.chkComposite.Text = "Use Composite Sailing "
        Me.chkComposite.UseVisualStyleBackColor = False
        '
        'cboMLmin
        '
        Me.cboMLmin.BackColor = System.Drawing.SystemColors.Window
        Me.cboMLmin.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboMLmin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMLmin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMLmin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboMLmin.Items.AddRange(New Object() {"00", "10", "20", "30", "40", "50"})
        Me.cboMLmin.Location = New System.Drawing.Point(447, 242)
        Me.cboMLmin.Name = "cboMLmin"
        Me.cboMLmin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboMLmin.Size = New System.Drawing.Size(41, 22)
        Me.cboMLmin.TabIndex = 53
        '
        'chkDriftAngle
        '
        Me.chkDriftAngle.BackColor = System.Drawing.SystemColors.Window
        Me.chkDriftAngle.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkDriftAngle.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDriftAngle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkDriftAngle.Location = New System.Drawing.Point(307, 104)
        Me.chkDriftAngle.Name = "chkDriftAngle"
        Me.chkDriftAngle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkDriftAngle.Size = New System.Drawing.Size(229, 22)
        Me.chkDriftAngle.TabIndex = 87
        Me.chkDriftAngle.Text = "Prior fix available for drift, CMG, SMG calc"
        Me.chkDriftAngle.UseVisualStyleBackColor = False
        Me.chkDriftAngle.Visible = False
        '
        'cboFix1L
        '
        Me.cboFix1L.BackColor = System.Drawing.SystemColors.Window
        Me.cboFix1L.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboFix1L.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFix1L.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFix1L.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboFix1L.Items.AddRange(New Object() {"N", "S"})
        Me.cboFix1L.Location = New System.Drawing.Point(145, 244)
        Me.cboFix1L.Name = "cboFix1L"
        Me.cboFix1L.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboFix1L.Size = New System.Drawing.Size(41, 22)
        Me.cboFix1L.TabIndex = 90
        Me.cboFix1L.Visible = False
        '
        'cboFix1Lo
        '
        Me.cboFix1Lo.BackColor = System.Drawing.SystemColors.Window
        Me.cboFix1Lo.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboFix1Lo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFix1Lo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFix1Lo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboFix1Lo.Items.AddRange(New Object() {"W", "E"})
        Me.cboFix1Lo.Location = New System.Drawing.Point(145, 268)
        Me.cboFix1Lo.Name = "cboFix1Lo"
        Me.cboFix1Lo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboFix1Lo.Size = New System.Drawing.Size(41, 22)
        Me.cboFix1Lo.TabIndex = 93
        Me.cboFix1Lo.Visible = False
        '
        'frameCalculateGC
        '
        Me.frameCalculateGC.BackColor = System.Drawing.SystemColors.Window
        Me.frameCalculateGC.Controls.Add(Me.optL2Lo2GC)
        Me.frameCalculateGC.Controls.Add(Me.optICD)
        Me.frameCalculateGC.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frameCalculateGC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frameCalculateGC.Location = New System.Drawing.Point(23, 59)
        Me.frameCalculateGC.Name = "frameCalculateGC"
        Me.frameCalculateGC.Padding = New System.Windows.Forms.Padding(0)
        Me.frameCalculateGC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frameCalculateGC.Size = New System.Drawing.Size(489, 41)
        Me.frameCalculateGC.TabIndex = 76
        Me.frameCalculateGC.TabStop = False
        Me.frameCalculateGC.Text = "Select What To Calculate "
        '
        'optL2Lo2GC
        '
        Me.optL2Lo2GC.BackColor = System.Drawing.SystemColors.Window
        Me.optL2Lo2GC.Cursor = System.Windows.Forms.Cursors.Default
        Me.optL2Lo2GC.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optL2Lo2GC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optL2Lo2GC.Location = New System.Drawing.Point(280, 16)
        Me.optL2Lo2GC.Name = "optL2Lo2GC"
        Me.optL2Lo2GC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optL2Lo2GC.Size = New System.Drawing.Size(130, 17)
        Me.optL2Lo2GC.TabIndex = 78
        Me.optL2Lo2GC.TabStop = True
        Me.optL2Lo2GC.Text = "Destination L and Lo"
        Me.optL2Lo2GC.UseVisualStyleBackColor = False
        Me.optL2Lo2GC.Visible = False
        '
        'optICD
        '
        Me.optICD.BackColor = System.Drawing.SystemColors.Window
        Me.optICD.Checked = True
        Me.optICD.Cursor = System.Windows.Forms.Cursors.Default
        Me.optICD.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optICD.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optICD.Location = New System.Drawing.Point(80, 16)
        Me.optICD.Name = "optICD"
        Me.optICD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optICD.Size = New System.Drawing.Size(153, 17)
        Me.optICD.TabIndex = 77
        Me.optICD.TabStop = True
        Me.optICD.Text = "Initial Course and Distance"
        Me.optICD.UseVisualStyleBackColor = False
        Me.optICD.Visible = False
        '
        'cmdPoints
        '
        Me.cmdPoints.BackColor = System.Drawing.Color.Yellow
        Me.cmdPoints.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPoints.Enabled = False
        Me.cmdPoints.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPoints.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPoints.Location = New System.Drawing.Point(8, 486)
        Me.cmdPoints.Name = "cmdPoints"
        Me.cmdPoints.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPoints.Size = New System.Drawing.Size(159, 25)
        Me.cmdPoints.TabIndex = 75
        Me.cmdPoints.Text = "&Points on Great Circle Route"
        Me.cmdPoints.UseVisualStyleBackColor = False
        Me.cmdPoints.Visible = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Window
        Me.Frame1.Controls.Add(Me.optMercatorS)
        Me.Frame1.Controls.Add(Me.optAccurateRhumb)
        Me.Frame1.Controls.Add(Me.optGreatCircle)
        Me.Frame1.Controls.Add(Me.optMercatorE)
        Me.Frame1.Controls.Add(Me.optMidLat)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(26, 7)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(485, 50)
        Me.Frame1.TabIndex = 68
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Select Sailing Route Type"
        '
        'optMercatorS
        '
        Me.optMercatorS.BackColor = System.Drawing.SystemColors.Window
        Me.optMercatorS.Cursor = System.Windows.Forms.Cursors.Default
        Me.optMercatorS.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optMercatorS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optMercatorS.Location = New System.Drawing.Point(322, 30)
        Me.optMercatorS.Name = "optMercatorS"
        Me.optMercatorS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optMercatorS.Size = New System.Drawing.Size(160, 17)
        Me.optMercatorS.TabIndex = 71
        Me.optMercatorS.TabStop = True
        Me.optMercatorS.Text = "Mercator (Clarke spheroid)"
        Me.optMercatorS.UseVisualStyleBackColor = False
        '
        'optAccurateRhumb
        '
        Me.optAccurateRhumb.BackColor = System.Drawing.SystemColors.Window
        Me.optAccurateRhumb.Cursor = System.Windows.Forms.Cursors.Default
        Me.optAccurateRhumb.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optAccurateRhumb.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optAccurateRhumb.Location = New System.Drawing.Point(88, 16)
        Me.optAccurateRhumb.Name = "optAccurateRhumb"
        Me.optAccurateRhumb.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optAccurateRhumb.Size = New System.Drawing.Size(130, 25)
        Me.optAccurateRhumb.TabIndex = 72
        Me.optAccurateRhumb.TabStop = True
        Me.optAccurateRhumb.Text = "Accurate Rhumb Line"
        Me.optAccurateRhumb.UseVisualStyleBackColor = False
        '
        'optGreatCircle
        '
        Me.optGreatCircle.BackColor = System.Drawing.SystemColors.Window
        Me.optGreatCircle.Cursor = System.Windows.Forms.Cursors.Default
        Me.optGreatCircle.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optGreatCircle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optGreatCircle.Location = New System.Drawing.Point(223, 18)
        Me.optGreatCircle.Name = "optGreatCircle"
        Me.optGreatCircle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optGreatCircle.Size = New System.Drawing.Size(88, 21)
        Me.optGreatCircle.TabIndex = 73
        Me.optGreatCircle.TabStop = True
        Me.optGreatCircle.Text = "Great Circle"
        Me.optGreatCircle.UseVisualStyleBackColor = False
        '
        'optMercatorE
        '
        Me.optMercatorE.BackColor = System.Drawing.SystemColors.Window
        Me.optMercatorE.Cursor = System.Windows.Forms.Cursors.Default
        Me.optMercatorE.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optMercatorE.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optMercatorE.Location = New System.Drawing.Point(322, 9)
        Me.optMercatorE.Name = "optMercatorE"
        Me.optMercatorE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optMercatorE.Size = New System.Drawing.Size(160, 17)
        Me.optMercatorE.TabIndex = 70
        Me.optMercatorE.TabStop = True
        Me.optMercatorE.Text = "Mercator (WGS72 ellipsoid)"
        Me.optMercatorE.UseVisualStyleBackColor = False
        '
        'optMidLat
        '
        Me.optMidLat.BackColor = System.Drawing.SystemColors.Window
        Me.optMidLat.Checked = True
        Me.optMidLat.Cursor = System.Windows.Forms.Cursors.Default
        Me.optMidLat.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optMidLat.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optMidLat.Location = New System.Drawing.Point(4, 16)
        Me.optMidLat.Name = "optMidLat"
        Me.optMidLat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optMidLat.Size = New System.Drawing.Size(84, 25)
        Me.optMidLat.TabIndex = 69
        Me.optMidLat.TabStop = True
        Me.optMidLat.Text = "Mid-Latitude"
        Me.optMidLat.UseVisualStyleBackColor = False
        '
        'cboML
        '
        Me.cboML.BackColor = System.Drawing.SystemColors.Window
        Me.cboML.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboML.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboML.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboML.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboML.Items.AddRange(New Object() {"N", "S"})
        Me.cboML.Location = New System.Drawing.Point(495, 242)
        Me.cboML.Name = "cboML"
        Me.cboML.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboML.Size = New System.Drawing.Size(41, 22)
        Me.cboML.TabIndex = 55
        '
        'chkML
        '
        Me.chkML.BackColor = System.Drawing.SystemColors.Window
        Me.chkML.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkML.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkML.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkML.Location = New System.Drawing.Point(196, 243)
        Me.chkML.Name = "chkML"
        Me.chkML.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkML.Size = New System.Drawing.Size(213, 22)
        Me.chkML.TabIndex = 51
        Me.chkML.Text = "Use this mid-latitude for CLS SAPS plot"
        Me.chkML.UseVisualStyleBackColor = False
        '
        'cmdClearSwap
        '
        Me.cmdClearSwap.BackColor = System.Drawing.Color.Yellow
        Me.cmdClearSwap.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClearSwap.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClearSwap.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClearSwap.Location = New System.Drawing.Point(8, 546)
        Me.cmdClearSwap.Name = "cmdClearSwap"
        Me.cmdClearSwap.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClearSwap.Size = New System.Drawing.Size(217, 25)
        Me.cmdClearSwap.TabIndex = 20
        Me.cmdClearSwap.Text = "Clear But &Use L2, Lo2 For New L1, Lo1"
        Me.cmdClearSwap.UseVisualStyleBackColor = False
        '
        'cmdClearAll
        '
        Me.cmdClearAll.BackColor = System.Drawing.Color.Red
        Me.cmdClearAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClearAll.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClearAll.ForeColor = System.Drawing.Color.White
        Me.cmdClearAll.Location = New System.Drawing.Point(8, 515)
        Me.cmdClearAll.Name = "cmdClearAll"
        Me.cmdClearAll.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClearAll.Size = New System.Drawing.Size(217, 25)
        Me.cmdClearAll.TabIndex = 19
        Me.cmdClearAll.Text = "Clear All Fields of Data Entered"
        Me.cmdClearAll.UseVisualStyleBackColor = False
        '
        'cmdCalculate
        '
        Me.cmdCalculate.BackColor = System.Drawing.Color.Blue
        Me.cmdCalculate.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCalculate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCalculate.ForeColor = System.Drawing.Color.White
        Me.cmdCalculate.Location = New System.Drawing.Point(192, 267)
        Me.cmdCalculate.Name = "cmdCalculate"
        Me.cmdCalculate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCalculate.Size = New System.Drawing.Size(150, 25)
        Me.cmdCalculate.TabIndex = 18
        Me.cmdCalculate.Text = "&Calculate"
        Me.cmdCalculate.UseVisualStyleBackColor = False
        '
        'frameCalculate
        '
        Me.frameCalculate.BackColor = System.Drawing.SystemColors.Window
        Me.frameCalculate.Controls.Add(Me.optSD)
        Me.frameCalculate.Controls.Add(Me.optCD)
        Me.frameCalculate.Controls.Add(Me.optL2Lo2)
        Me.frameCalculate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frameCalculate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frameCalculate.Location = New System.Drawing.Point(24, 58)
        Me.frameCalculate.Name = "frameCalculate"
        Me.frameCalculate.Padding = New System.Windows.Forms.Padding(0)
        Me.frameCalculate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frameCalculate.Size = New System.Drawing.Size(489, 41)
        Me.frameCalculate.TabIndex = 34
        Me.frameCalculate.TabStop = False
        Me.frameCalculate.Text = "Select What to Calculate"
        '
        'optSD
        '
        Me.optSD.BackColor = System.Drawing.SystemColors.Window
        Me.optSD.Cursor = System.Windows.Forms.Cursors.Default
        Me.optSD.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optSD.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optSD.Location = New System.Drawing.Point(387, 16)
        Me.optSD.Name = "optSD"
        Me.optSD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optSD.Size = New System.Drawing.Size(100, 17)
        Me.optSD.TabIndex = 46
        Me.optSD.TabStop = True
        Me.optSD.Text = "Set and Drift"
        Me.optSD.UseVisualStyleBackColor = False
        '
        'optCD
        '
        Me.optCD.BackColor = System.Drawing.SystemColors.Window
        Me.optCD.Checked = True
        Me.optCD.Cursor = System.Windows.Forms.Cursors.Default
        Me.optCD.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optCD.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optCD.Location = New System.Drawing.Point(16, 16)
        Me.optCD.Name = "optCD"
        Me.optCD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optCD.Size = New System.Drawing.Size(129, 17)
        Me.optCD.TabIndex = 22
        Me.optCD.TabStop = True
        Me.optCD.Text = "Course and Distance"
        Me.optCD.UseVisualStyleBackColor = False
        '
        'optL2Lo2
        '
        Me.optL2Lo2.BackColor = System.Drawing.SystemColors.Window
        Me.optL2Lo2.Cursor = System.Windows.Forms.Cursors.Default
        Me.optL2Lo2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optL2Lo2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optL2Lo2.Location = New System.Drawing.Point(200, 16)
        Me.optL2Lo2.Name = "optL2Lo2"
        Me.optL2Lo2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optL2Lo2.Size = New System.Drawing.Size(129, 17)
        Me.optL2Lo2.TabIndex = 21
        Me.optL2Lo2.TabStop = True
        Me.optL2Lo2.Text = "Destination L and Lo"
        Me.optL2Lo2.UseVisualStyleBackColor = False
        '
        'cboLo1
        '
        Me.cboLo1.BackColor = System.Drawing.SystemColors.Window
        Me.cboLo1.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboLo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLo1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLo1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboLo1.Items.AddRange(New Object() {"W", "E"})
        Me.cboLo1.Location = New System.Drawing.Point(134, 127)
        Me.cboLo1.Name = "cboLo1"
        Me.cboLo1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboLo1.Size = New System.Drawing.Size(41, 22)
        Me.cboLo1.TabIndex = 5
        '
        'cboL1
        '
        Me.cboL1.BackColor = System.Drawing.SystemColors.Window
        Me.cboL1.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboL1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboL1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboL1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboL1.Items.AddRange(New Object() {"N", "S"})
        Me.cboL1.Location = New System.Drawing.Point(134, 103)
        Me.cboL1.Name = "cboL1"
        Me.cboL1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboL1.Size = New System.Drawing.Size(41, 22)
        Me.cboL1.TabIndex = 2
        '
        'cboLo2
        '
        Me.cboLo2.BackColor = System.Drawing.SystemColors.Window
        Me.cboLo2.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboLo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLo2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLo2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboLo2.Items.AddRange(New Object() {"W", "E"})
        Me.cboLo2.Location = New System.Drawing.Point(134, 197)
        Me.cboLo2.Name = "cboLo2"
        Me.cboLo2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboLo2.Size = New System.Drawing.Size(41, 22)
        Me.cboLo2.TabIndex = 17
        Me.cboLo2.Visible = False
        '
        'cboL2
        '
        Me.cboL2.BackColor = System.Drawing.SystemColors.Window
        Me.cboL2.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboL2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboL2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboL2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboL2.Items.AddRange(New Object() {"N", "S"})
        Me.cboL2.Location = New System.Drawing.Point(134, 173)
        Me.cboL2.Name = "cboL2"
        Me.cboL2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboL2.Size = New System.Drawing.Size(41, 22)
        Me.cboL2.TabIndex = 14
        Me.cboL2.Visible = False
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Window
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(487, 245)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(9, 17)
        Me.Label15.TabIndex = 103
        Me.Label15.Text = "'"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.Window
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(295, 160)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(9, 17)
        Me.Label16.TabIndex = 102
        Me.Label16.Text = "°"
        '
        'lblLimLat
        '
        Me.lblLimLat.BackColor = System.Drawing.SystemColors.Window
        Me.lblLimLat.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLimLat.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLimLat.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLimLat.Location = New System.Drawing.Point(184, 226)
        Me.lblLimLat.Name = "lblLimLat"
        Me.lblLimLat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLimLat.Size = New System.Drawing.Size(65, 17)
        Me.lblLimLat.TabIndex = 98
        Me.lblLimLat.Text = "Latitude limit"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Window
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(2, 246)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(57, 17)
        Me.Label14.TabIndex = 86
        Me.Label14.Text = "Prior fix L"
        Me.Label14.Visible = False
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Window
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(96, 243)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(9, 17)
        Me.Label13.TabIndex = 85
        Me.Label13.Text = "°"
        Me.Label13.Visible = False
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Window
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(137, 243)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(9, 17)
        Me.Label12.TabIndex = 84
        Me.Label12.Text = "'"
        Me.Label12.Visible = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Window
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(1, 270)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(59, 17)
        Me.Label11.TabIndex = 83
        Me.Label11.Text = "Prior fix Lo"
        Me.Label11.Visible = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Window
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(279, 222)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(8, 17)
        Me.Label10.TabIndex = 82
        Me.Label10.Text = "°"
        Me.Label10.Visible = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Window
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(137, 267)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(9, 17)
        Me.Label9.TabIndex = 81
        Me.Label9.Text = "'"
        Me.Label9.Visible = False
        '
        'lblInitial
        '
        Me.lblInitial.BackColor = System.Drawing.SystemColors.Window
        Me.lblInitial.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblInitial.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInitial.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblInitial.Location = New System.Drawing.Point(197, 116)
        Me.lblInitial.Name = "lblInitial"
        Me.lblInitial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInitial.Size = New System.Drawing.Size(41, 17)
        Me.lblInitial.TabIndex = 74
        Me.lblInitial.Text = "(Initial)"
        Me.lblInitial.Visible = False
        '
        'lblor2
        '
        Me.lblor2.BackColor = System.Drawing.SystemColors.Window
        Me.lblor2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblor2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblor2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblor2.Location = New System.Drawing.Point(409, 174)
        Me.lblor2.Name = "lblor2"
        Me.lblor2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblor2.Size = New System.Drawing.Size(22, 17)
        Me.lblor2.TabIndex = 67
        Me.lblor2.Text = "OR"
        Me.lblor2.Visible = False
        '
        'lblTime2
        '
        Me.lblTime2.BackColor = System.Drawing.SystemColors.Window
        Me.lblTime2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTime2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTime2.Location = New System.Drawing.Point(424, 160)
        Me.lblTime2.Name = "lblTime2"
        Me.lblTime2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTime2.Size = New System.Drawing.Size(74, 17)
        Me.lblTime2.TabIndex = 66
        Me.lblTime2.Text = "Time2 (hhmm)"
        '
        'lblTime1
        '
        Me.lblTime1.BackColor = System.Drawing.SystemColors.Window
        Me.lblTime1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTime1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTime1.Location = New System.Drawing.Point(424, 136)
        Me.lblTime1.Name = "lblTime1"
        Me.lblTime1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTime1.Size = New System.Drawing.Size(74, 17)
        Me.lblTime1.TabIndex = 65
        Me.lblTime1.Text = "Time1 (hhmm)"
        '
        'lblLog2nm
        '
        Me.lblLog2nm.BackColor = System.Drawing.SystemColors.Window
        Me.lblLog2nm.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLog2nm.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLog2nm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLog2nm.Location = New System.Drawing.Point(281, 160)
        Me.lblLog2nm.Name = "lblLog2nm"
        Me.lblLog2nm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLog2nm.Size = New System.Drawing.Size(21, 17)
        Me.lblLog2nm.TabIndex = 62
        Me.lblLog2nm.Text = "nm"
        '
        'lblLog1nm
        '
        Me.lblLog1nm.BackColor = System.Drawing.SystemColors.Window
        Me.lblLog1nm.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLog1nm.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLog1nm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLog1nm.Location = New System.Drawing.Point(281, 136)
        Me.lblLog1nm.Name = "lblLog1nm"
        Me.lblLog1nm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLog1nm.Size = New System.Drawing.Size(21, 17)
        Me.lblLog1nm.TabIndex = 61
        Me.lblLog1nm.Text = "nm"
        '
        'lblLog2
        '
        Me.lblLog2.BackColor = System.Drawing.SystemColors.Window
        Me.lblLog2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLog2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLog2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLog2.Location = New System.Drawing.Point(208, 160)
        Me.lblLog2.Name = "lblLog2"
        Me.lblLog2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLog2.Size = New System.Drawing.Size(31, 17)
        Me.lblLog2.TabIndex = 60
        Me.lblLog2.Text = "Log2"
        '
        'lblLog1
        '
        Me.lblLog1.BackColor = System.Drawing.SystemColors.Window
        Me.lblLog1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLog1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLog1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLog1.Location = New System.Drawing.Point(207, 136)
        Me.lblLog1.Name = "lblLog1"
        Me.lblLog1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLog1.Size = New System.Drawing.Size(31, 17)
        Me.lblLog1.TabIndex = 59
        Me.lblLog1.Text = "Log1"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Window
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(439, 243)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(9, 17)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "°"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(323, 222)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(9, 17)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "'"
        '
        'lblFixLo
        '
        Me.lblFixLo.BackColor = System.Drawing.SystemColors.Window
        Me.lblFixLo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFixLo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFixLo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFixLo.Location = New System.Drawing.Point(15, 198)
        Me.lblFixLo.Name = "lblFixLo"
        Me.lblFixLo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFixLo.Size = New System.Drawing.Size(36, 17)
        Me.lblFixLo.TabIndex = 50
        Me.lblFixLo.Text = "Fix Lo"
        Me.lblFixLo.Visible = False
        '
        'lblFixL
        '
        Me.lblFixL.BackColor = System.Drawing.SystemColors.Window
        Me.lblFixL.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFixL.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFixL.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFixL.Location = New System.Drawing.Point(20, 173)
        Me.lblFixL.Name = "lblFixL"
        Me.lblFixL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFixL.Size = New System.Drawing.Size(33, 17)
        Me.lblFixL.TabIndex = 49
        Me.lblFixL.Text = "Fix L"
        Me.lblFixL.Visible = False
        '
        'lblDRLo
        '
        Me.lblDRLo.BackColor = System.Drawing.SystemColors.Window
        Me.lblDRLo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDRLo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDRLo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDRLo.Location = New System.Drawing.Point(20, 127)
        Me.lblDRLo.Name = "lblDRLo"
        Me.lblDRLo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDRLo.Size = New System.Drawing.Size(36, 17)
        Me.lblDRLo.TabIndex = 48
        Me.lblDRLo.Text = "DR Lo"
        Me.lblDRLo.Visible = False
        '
        'lblDRL
        '
        Me.lblDRL.BackColor = System.Drawing.SystemColors.Window
        Me.lblDRL.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDRL.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDRL.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDRL.Location = New System.Drawing.Point(20, 103)
        Me.lblDRL.Name = "lblDRL"
        Me.lblDRL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDRL.Size = New System.Drawing.Size(33, 17)
        Me.lblDRL.TabIndex = 47
        Me.lblDRL.Text = "DR L"
        Me.lblDRL.Visible = False
        '
        'lblm
        '
        Me.lblm.BackColor = System.Drawing.SystemColors.Window
        Me.lblm.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblm.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblm.Location = New System.Drawing.Point(527, 195)
        Me.lblm.Name = "lblm"
        Me.lblm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblm.Size = New System.Drawing.Size(17, 17)
        Me.lblm.TabIndex = 44
        Me.lblm.Text = "m"
        '
        'lblh
        '
        Me.lblh.BackColor = System.Drawing.SystemColors.Window
        Me.lblh.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblh.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblh.Location = New System.Drawing.Point(485, 195)
        Me.lblh.Name = "lblh"
        Me.lblh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblh.Size = New System.Drawing.Size(17, 17)
        Me.lblh.TabIndex = 43
        Me.lblh.Text = "h"
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.SystemColors.Window
        Me.lblTime.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTime.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTime.Location = New System.Drawing.Point(406, 195)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTime.Size = New System.Drawing.Size(51, 17)
        Me.lblTime.TabIndex = 42
        Me.lblTime.Text = "Run Time"
        '
        'lblkn
        '
        Me.lblkn.BackColor = System.Drawing.SystemColors.Window
        Me.lblkn.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblkn.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblkn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblkn.Location = New System.Drawing.Point(389, 195)
        Me.lblkn.Name = "lblkn"
        Me.lblkn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblkn.Size = New System.Drawing.Size(18, 17)
        Me.lblkn.TabIndex = 41
        Me.lblkn.Text = "kn"
        '
        'lblSpeed
        '
        Me.lblSpeed.BackColor = System.Drawing.SystemColors.Window
        Me.lblSpeed.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSpeed.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpeed.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSpeed.Location = New System.Drawing.Point(317, 195)
        Me.lblSpeed.Name = "lblSpeed"
        Me.lblSpeed.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSpeed.Size = New System.Drawing.Size(38, 17)
        Me.lblSpeed.TabIndex = 40
        Me.lblSpeed.Text = "Speed"
        '
        'lblor
        '
        Me.lblor.BackColor = System.Drawing.SystemColors.Window
        Me.lblor.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblor.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblor.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblor.Location = New System.Drawing.Point(296, 185)
        Me.lblor.Name = "lblor"
        Me.lblor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblor.Size = New System.Drawing.Size(22, 13)
        Me.lblor.TabIndex = 39
        Me.lblor.Text = "OR"
        '
        'lblnm
        '
        Me.lblnm.BackColor = System.Drawing.SystemColors.Window
        Me.lblnm.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblnm.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblnm.Location = New System.Drawing.Point(281, 195)
        Me.lblnm.Name = "lblnm"
        Me.lblnm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblnm.Size = New System.Drawing.Size(21, 17)
        Me.lblnm.TabIndex = 38
        Me.lblnm.Text = "nm"
        '
        'lblDistance
        '
        Me.lblDistance.BackColor = System.Drawing.SystemColors.Window
        Me.lblDistance.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDistance.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDistance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDistance.Location = New System.Drawing.Point(185, 195)
        Me.lblDistance.Name = "lblDistance"
        Me.lblDistance.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDistance.Size = New System.Drawing.Size(49, 17)
        Me.lblDistance.TabIndex = 37
        Me.lblDistance.Text = "Distance"
        '
        'lblCourseDeg
        '
        Me.lblCourseDeg.BackColor = System.Drawing.SystemColors.Window
        Me.lblCourseDeg.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCourseDeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourseDeg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCourseDeg.Location = New System.Drawing.Point(287, 104)
        Me.lblCourseDeg.Name = "lblCourseDeg"
        Me.lblCourseDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCourseDeg.Size = New System.Drawing.Size(9, 17)
        Me.lblCourseDeg.TabIndex = 36
        Me.lblCourseDeg.Text = "°"
        '
        'lblCourse
        '
        Me.lblCourse.BackColor = System.Drawing.SystemColors.Window
        Me.lblCourse.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCourse.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourse.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCourse.Location = New System.Drawing.Point(180, 104)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCourse.Size = New System.Drawing.Size(67, 13)
        Me.lblCourse.TabIndex = 35
        Me.lblCourse.Text = "True Course"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Window
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(125, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(9, 17)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "'"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Window
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(85, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(9, 17)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "°"
        '
        'lblLo1
        '
        Me.lblLo1.BackColor = System.Drawing.SystemColors.Window
        Me.lblLo1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLo1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLo1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLo1.Location = New System.Drawing.Point(20, 127)
        Me.lblLo1.Name = "lblLo1"
        Me.lblLo1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLo1.Size = New System.Drawing.Size(25, 17)
        Me.lblLo1.TabIndex = 31
        Me.lblLo1.Text = "Lo1"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Window
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(125, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(9, 17)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "'"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(85, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(9, 17)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "°"
        '
        'lblL1
        '
        Me.lblL1.BackColor = System.Drawing.SystemColors.Window
        Me.lblL1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblL1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblL1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblL1.Location = New System.Drawing.Point(20, 103)
        Me.lblL1.Name = "lblL1"
        Me.lblL1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblL1.Size = New System.Drawing.Size(25, 17)
        Me.lblL1.TabIndex = 28
        Me.lblL1.Text = "L1"
        '
        'lblLoMin
        '
        Me.lblLoMin.BackColor = System.Drawing.SystemColors.Window
        Me.lblLoMin.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLoMin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoMin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLoMin.Location = New System.Drawing.Point(125, 197)
        Me.lblLoMin.Name = "lblLoMin"
        Me.lblLoMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLoMin.Size = New System.Drawing.Size(9, 17)
        Me.lblLoMin.TabIndex = 27
        Me.lblLoMin.Text = "'"
        Me.lblLoMin.Visible = False
        '
        'lblLoDeg
        '
        Me.lblLoDeg.BackColor = System.Drawing.SystemColors.Window
        Me.lblLoDeg.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLoDeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoDeg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLoDeg.Location = New System.Drawing.Point(85, 197)
        Me.lblLoDeg.Name = "lblLoDeg"
        Me.lblLoDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLoDeg.Size = New System.Drawing.Size(9, 17)
        Me.lblLoDeg.TabIndex = 26
        Me.lblLoDeg.Text = "°"
        Me.lblLoDeg.Visible = False
        '
        'lblLo2
        '
        Me.lblLo2.BackColor = System.Drawing.SystemColors.Window
        Me.lblLo2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLo2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLo2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLo2.Location = New System.Drawing.Point(18, 197)
        Me.lblLo2.Name = "lblLo2"
        Me.lblLo2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLo2.Size = New System.Drawing.Size(34, 15)
        Me.lblLo2.TabIndex = 25
        Me.lblLo2.Text = "L2 Lo"
        Me.lblLo2.Visible = False
        '
        'lblLMin
        '
        Me.lblLMin.BackColor = System.Drawing.SystemColors.Window
        Me.lblLMin.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLMin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLMin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLMin.Location = New System.Drawing.Point(125, 173)
        Me.lblLMin.Name = "lblLMin"
        Me.lblLMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLMin.Size = New System.Drawing.Size(9, 17)
        Me.lblLMin.TabIndex = 24
        Me.lblLMin.Text = "'"
        Me.lblLMin.Visible = False
        '
        'lblLDeg
        '
        Me.lblLDeg.BackColor = System.Drawing.SystemColors.Window
        Me.lblLDeg.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLDeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLDeg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLDeg.Location = New System.Drawing.Point(85, 173)
        Me.lblLDeg.Name = "lblLDeg"
        Me.lblLDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLDeg.Size = New System.Drawing.Size(9, 17)
        Me.lblLDeg.TabIndex = 23
        Me.lblLDeg.Text = "°"
        Me.lblLDeg.Visible = False
        '
        'lblL2
        '
        Me.lblL2.BackColor = System.Drawing.SystemColors.Window
        Me.lblL2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblL2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblL2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblL2.Location = New System.Drawing.Point(20, 174)
        Me.lblL2.Name = "lblL2"
        Me.lblL2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblL2.Size = New System.Drawing.Size(19, 17)
        Me.lblL2.TabIndex = 13
        Me.lblL2.Text = "L2"
        Me.lblL2.Visible = False
        '
        'txtSailings
        '
        Me.txtSailings.BackColor = System.Drawing.SystemColors.Window
        Me.txtSailings.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSailings.Location = New System.Drawing.Point(2, 299)
        Me.txtSailings.Name = "txtSailings"
        Me.txtSailings.ReadOnly = True
        Me.txtSailings.Size = New System.Drawing.Size(546, 154)
        Me.txtSailings.TabIndex = 106
        Me.txtSailings.Text = ""
        '
        'ExitBtn
        '
        Me.ExitBtn.BackColor = System.Drawing.Color.Red
        Me.ExitBtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExitBtn.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ExitBtn.Location = New System.Drawing.Point(473, 484)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ExitBtn.Size = New System.Drawing.Size(73, 25)
        Me.ExitBtn.TabIndex = 107
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = False
        '
        'cmdRhumbPoints
        '
        Me.cmdRhumbPoints.BackColor = System.Drawing.Color.Yellow
        Me.cmdRhumbPoints.Enabled = False
        Me.cmdRhumbPoints.Location = New System.Drawing.Point(178, 486)
        Me.cmdRhumbPoints.Name = "cmdRhumbPoints"
        Me.cmdRhumbPoints.Size = New System.Drawing.Size(159, 25)
        Me.cmdRhumbPoints.TabIndex = 108
        Me.cmdRhumbPoints.Text = "Points on &Rhumb Line"
        Me.cmdRhumbPoints.UseVisualStyleBackColor = False
        '
        'txtUserInfo
        '
        Me.txtUserInfo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserInfo.HideSelection = False
        Me.txtUserInfo.Location = New System.Drawing.Point(103, 458)
        Me.txtUserInfo.Name = "txtUserInfo"
        Me.txtUserInfo.Size = New System.Drawing.Size(400, 22)
        Me.txtUserInfo.TabIndex = 204
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(42, 461)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(57, 15)
        Me.Label17.TabIndex = 203
        Me.Label17.Text = "User Info"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CelestialTools.My.Resources.Resources.ABC_white
        Me.PictureBox1.Location = New System.Drawing.Point(253, 521)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(295, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 109
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Window
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(96, 270)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(9, 17)
        Me.Label7.TabIndex = 205
        Me.Label7.Text = "°"
        Me.Label7.Visible = False
        '
        'FormSailings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(553, 577)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtUserInfo)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.frameCalculateGC)
        Me.Controls.Add(Me.lblL2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.chkDriftAngle)
        Me.Controls.Add(Me.lblCourse)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblLimLat)
        Me.Controls.Add(Me.txtL3Deg)
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me.chkComposite)
        Me.Controls.Add(Me.lblLog2nm)
        Me.Controls.Add(Me.lblLog1nm)
        Me.Controls.Add(Me.lblnm)
        Me.Controls.Add(Me.lblor)
        Me.Controls.Add(Me.lblLog2)
        Me.Controls.Add(Me.lblLog1)
        Me.Controls.Add(Me.lblSpeed)
        Me.Controls.Add(Me.cmdRhumbPoints)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.txtSailings)
        Me.Controls.Add(Me.cmdTraverse)
        Me.Controls.Add(Me.txtL3Min)
        Me.Controls.Add(Me.cboL3)
        Me.Controls.Add(Me.cboMLmin)
        Me.Controls.Add(Me.txtFix1LM)
        Me.Controls.Add(Me.cboFix1L)
        Me.Controls.Add(Me.txtFix1LD)
        Me.Controls.Add(Me.txtFix1LoD)
        Me.Controls.Add(Me.txtFix1LoM)
        Me.Controls.Add(Me.cboFix1Lo)
        Me.Controls.Add(Me.cmdPoints)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.txtTime2)
        Me.Controls.Add(Me.txtTime1)
        Me.Controls.Add(Me.txtLog2)
        Me.Controls.Add(Me.cboML)
        Me.Controls.Add(Me.txtMLDeg)
        Me.Controls.Add(Me.chkML)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdClearSwap)
        Me.Controls.Add(Me.cmdClearAll)
        Me.Controls.Add(Me.cmdCalculate)
        Me.Controls.Add(Me.txtTimem)
        Me.Controls.Add(Me.txtTimeh)
        Me.Controls.Add(Me.txtSpeed)
        Me.Controls.Add(Me.txtDist)
        Me.Controls.Add(Me.txtCourse)
        Me.Controls.Add(Me.frameCalculate)
        Me.Controls.Add(Me.cboLo1)
        Me.Controls.Add(Me.txtLo1Min)
        Me.Controls.Add(Me.txtLo1Deg)
        Me.Controls.Add(Me.txtL1Deg)
        Me.Controls.Add(Me.cboL1)
        Me.Controls.Add(Me.txtL1Min)
        Me.Controls.Add(Me.cboLo2)
        Me.Controls.Add(Me.txtLo2Min)
        Me.Controls.Add(Me.txtLo2Deg)
        Me.Controls.Add(Me.txtL2Deg)
        Me.Controls.Add(Me.cboL2)
        Me.Controls.Add(Me.txtL2Min)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblInitial)
        Me.Controls.Add(Me.lblor2)
        Me.Controls.Add(Me.lblTime2)
        Me.Controls.Add(Me.lblTime1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblFixL)
        Me.Controls.Add(Me.lblDRLo)
        Me.Controls.Add(Me.lblDRL)
        Me.Controls.Add(Me.lblm)
        Me.Controls.Add(Me.lblh)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblkn)
        Me.Controls.Add(Me.lblDistance)
        Me.Controls.Add(Me.lblCourseDeg)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblLo1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblL1)
        Me.Controls.Add(Me.lblLoMin)
        Me.Controls.Add(Me.lblLoDeg)
        Me.Controls.Add(Me.lblLMin)
        Me.Controls.Add(Me.lblLDeg)
        Me.Controls.Add(Me.txtLog1)
        Me.Controls.Add(Me.lblLo2)
        Me.Controls.Add(Me.lblFixLo)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(99, 155)
        Me.MaximizeBox = False
        Me.Name = "FormSailings"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "The Sailings"
        Me.Frame3.ResumeLayout(False)
        Me.frameCalculateGC.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        Me.frameCalculate.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSailings As RichTextBox
    Public WithEvents ExitBtn As Button
    Friend WithEvents cmdRhumbPoints As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtUserInfo As TextBox
    Friend WithEvents Label17 As Label
    Public WithEvents Label7 As Label
#End Region
End Class