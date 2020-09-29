<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class MainMenu
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
    Public WithEvents cmdCurrents As System.Windows.Forms.Button
    Public WithEvents cmdTides As System.Windows.Forms.Button
    Public WithEvents cmdTwoBearings As System.Windows.Forms.Button
    Public WithEvents cmdCPA As System.Windows.Forms.Button
    Public WithEvents cmdYellow As System.Windows.Forms.Button
    Public WithEvents cmdLengthDeg As System.Windows.Forms.Button
    Public WithEvents cmdTVMDC As System.Windows.Forms.Button
    Public WithEvents cmd60DST As System.Windows.Forms.Button
    Public WithEvents cmdInterpolate As System.Windows.Forms.Button
    Public WithEvents cmdDistances As System.Windows.Forms.Button
    Public WithEvents cmdCTSSOA As System.Windows.Forms.Button
    Public WithEvents cmdSailings As System.Windows.Forms.Button
    Public WithEvents cmdArcTime As System.Windows.Forms.Button
    Public WithEvents SRMethod As System.Windows.Forms.Button
    Public WithEvents cmdNoon As System.Windows.Forms.Button
    Public WithEvents cmdReduction As System.Windows.Forms.Button
    Public WithEvents cmdPlanning As System.Windows.Forms.Button
    Public WithEvents Label1 As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdPlanning = New System.Windows.Forms.Button()
        Me.cmdCurrents = New System.Windows.Forms.Button()
        Me.cmdTides = New System.Windows.Forms.Button()
        Me.cmdTwoBearings = New System.Windows.Forms.Button()
        Me.cmdCPA = New System.Windows.Forms.Button()
        Me.cmdYellow = New System.Windows.Forms.Button()
        Me.cmdLengthDeg = New System.Windows.Forms.Button()
        Me.cmdTVMDC = New System.Windows.Forms.Button()
        Me.cmd60DST = New System.Windows.Forms.Button()
        Me.cmdInterpolate = New System.Windows.Forms.Button()
        Me.cmdDistances = New System.Windows.Forms.Button()
        Me.cmdCTSSOA = New System.Windows.Forms.Button()
        Me.cmdSailings = New System.Windows.Forms.Button()
        Me.cmdArcTime = New System.Windows.Forms.Button()
        Me.SRMethod = New System.Windows.Forms.Button()
        Me.cmdNoon = New System.Windows.Forms.Button()
        Me.cmdReduction = New System.Windows.Forms.Button()
        Me.btnSightLog = New System.Windows.Forms.Button()
        Me.btnFavLocs = New System.Windows.Forms.Button()
        Me.btnDeckLog = New System.Windows.Forms.Button()
        Me.btnCVSFile = New System.Windows.Forms.Button()
        Me.btnDevForm = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.HelpV2Btn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmdAbout = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnTraverseTable = New System.Windows.Forms.Button()
        Me.btnZoneTime = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdPlanning
        '
        Me.cmdPlanning.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPlanning.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPlanning.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPlanning.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPlanning.Image = CType(resources.GetObject("cmdPlanning.Image"), System.Drawing.Image)
        Me.cmdPlanning.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPlanning.Location = New System.Drawing.Point(7, 23)
        Me.cmdPlanning.Name = "cmdPlanning"
        Me.cmdPlanning.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPlanning.Size = New System.Drawing.Size(91, 60)
        Me.cmdPlanning.TabIndex = 0
        Me.cmdPlanning.Text = "Sight Planner"
        Me.cmdPlanning.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdPlanning, "Plan which celestial bodies are visible and where")
        Me.cmdPlanning.UseVisualStyleBackColor = False
        '
        'cmdCurrents
        '
        Me.cmdCurrents.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCurrents.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCurrents.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCurrents.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCurrents.Image = CType(resources.GetObject("cmdCurrents.Image"), System.Drawing.Image)
        Me.cmdCurrents.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdCurrents.Location = New System.Drawing.Point(202, 82)
        Me.cmdCurrents.Name = "cmdCurrents"
        Me.cmdCurrents.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCurrents.Size = New System.Drawing.Size(92, 60)
        Me.cmdCurrents.TabIndex = 23
        Me.cmdCurrents.Text = "Currents"
        Me.cmdCurrents.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdCurrents, "Calculate tidal currents or use NOAA web sight")
        Me.cmdCurrents.UseVisualStyleBackColor = False
        '
        'cmdTides
        '
        Me.cmdTides.BackColor = System.Drawing.SystemColors.Control
        Me.cmdTides.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdTides.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTides.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdTides.Image = CType(resources.GetObject("cmdTides.Image"), System.Drawing.Image)
        Me.cmdTides.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdTides.Location = New System.Drawing.Point(105, 82)
        Me.cmdTides.Name = "cmdTides"
        Me.cmdTides.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdTides.Size = New System.Drawing.Size(92, 60)
        Me.cmdTides.TabIndex = 22
        Me.cmdTides.Text = "Tides"
        Me.cmdTides.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdTides, "Calculate tidal data or use NOAA web sight")
        Me.cmdTides.UseVisualStyleBackColor = False
        '
        'cmdTwoBearings
        '
        Me.cmdTwoBearings.BackColor = System.Drawing.SystemColors.Control
        Me.cmdTwoBearings.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdTwoBearings.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTwoBearings.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdTwoBearings.Image = CType(resources.GetObject("cmdTwoBearings.Image"), System.Drawing.Image)
        Me.cmdTwoBearings.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cmdTwoBearings.Location = New System.Drawing.Point(300, 82)
        Me.cmdTwoBearings.Name = "cmdTwoBearings"
        Me.cmdTwoBearings.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdTwoBearings.Size = New System.Drawing.Size(92, 60)
        Me.cmdTwoBearings.TabIndex = 15
        Me.cmdTwoBearings.Text = "Distance, Course, Fix" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "from Bearings"
        Me.cmdTwoBearings.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.ToolTip1.SetToolTip(Me.cmdTwoBearings, "Calculate distance, course, or fix given 2 or 3 bearings")
        Me.cmdTwoBearings.UseVisualStyleBackColor = False
        '
        'cmdCPA
        '
        Me.cmdCPA.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCPA.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCPA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCPA.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCPA.Image = CType(resources.GetObject("cmdCPA.Image"), System.Drawing.Image)
        Me.cmdCPA.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cmdCPA.Location = New System.Drawing.Point(399, 18)
        Me.cmdCPA.Name = "cmdCPA"
        Me.cmdCPA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCPA.Size = New System.Drawing.Size(92, 60)
        Me.cmdCPA.TabIndex = 7
        Me.cmdCPA.Text = "Closest " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Approach " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "&& True Wind"
        Me.cmdCPA.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.ToolTip1.SetToolTip(Me.cmdCPA, "Calculate closest point of approach or true wind")
        Me.cmdCPA.UseVisualStyleBackColor = False
        '
        'cmdYellow
        '
        Me.cmdYellow.BackColor = System.Drawing.SystemColors.Control
        Me.cmdYellow.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdYellow.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdYellow.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdYellow.Image = CType(resources.GetObject("cmdYellow.Image"), System.Drawing.Image)
        Me.cmdYellow.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdYellow.Location = New System.Drawing.Point(591, 24)
        Me.cmdYellow.Name = "cmdYellow"
        Me.cmdYellow.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdYellow.Size = New System.Drawing.Size(92, 60)
        Me.cmdYellow.TabIndex = 4
        Me.cmdYellow.Text = "Yellow Pages (I&&C)"
        Me.cmdYellow.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdYellow, "Calculate nautical almanac 'Yellow Page' I&C corrections")
        Me.cmdYellow.UseVisualStyleBackColor = False
        '
        'cmdLengthDeg
        '
        Me.cmdLengthDeg.BackColor = System.Drawing.SystemColors.Control
        Me.cmdLengthDeg.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLengthDeg.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLengthDeg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdLengthDeg.Image = CType(resources.GetObject("cmdLengthDeg.Image"), System.Drawing.Image)
        Me.cmdLengthDeg.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdLengthDeg.Location = New System.Drawing.Point(7, 82)
        Me.cmdLengthDeg.Name = "cmdLengthDeg"
        Me.cmdLengthDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdLengthDeg.Size = New System.Drawing.Size(92, 60)
        Me.cmdLengthDeg.TabIndex = 11
        Me.cmdLengthDeg.Text = "Length of Degree For Lat/Long"
        Me.cmdLengthDeg.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdLengthDeg, "Over calculate information about 1 degree of latitude / longitude")
        Me.cmdLengthDeg.UseVisualStyleBackColor = False
        '
        'cmdTVMDC
        '
        Me.cmdTVMDC.BackColor = System.Drawing.SystemColors.Control
        Me.cmdTVMDC.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdTVMDC.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTVMDC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdTVMDC.Image = CType(resources.GetObject("cmdTVMDC.Image"), System.Drawing.Image)
        Me.cmdTVMDC.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdTVMDC.Location = New System.Drawing.Point(7, 20)
        Me.cmdTVMDC.Name = "cmdTVMDC"
        Me.cmdTVMDC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdTVMDC.Size = New System.Drawing.Size(92, 60)
        Me.cmdTVMDC.TabIndex = 13
        Me.cmdTVMDC.Text = "TVMDC"
        Me.cmdTVMDC.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdTVMDC, "Calculate true, magnetic, or compass courses given deviation and variation (TVMDC" &
        ")")
        Me.cmdTVMDC.UseVisualStyleBackColor = False
        '
        'cmd60DST
        '
        Me.cmd60DST.BackColor = System.Drawing.SystemColors.Control
        Me.cmd60DST.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmd60DST.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd60DST.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmd60DST.Image = CType(resources.GetObject("cmd60DST.Image"), System.Drawing.Image)
        Me.cmd60DST.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cmd60DST.Location = New System.Drawing.Point(105, 20)
        Me.cmd60DST.Name = "cmd60DST"
        Me.cmd60DST.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmd60DST.Size = New System.Drawing.Size(92, 60)
        Me.cmd60DST.TabIndex = 12
        Me.cmd60DST.Text = "Calculate Distance, Speed, Time"
        Me.cmd60DST.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.ToolTip1.SetToolTip(Me.cmd60DST, "Calculate navigation distances, speed, or time")
        Me.cmd60DST.UseVisualStyleBackColor = False
        '
        'cmdInterpolate
        '
        Me.cmdInterpolate.BackColor = System.Drawing.SystemColors.Control
        Me.cmdInterpolate.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdInterpolate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdInterpolate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdInterpolate.Image = CType(resources.GetObject("cmdInterpolate.Image"), System.Drawing.Image)
        Me.cmdInterpolate.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdInterpolate.Location = New System.Drawing.Point(398, 82)
        Me.cmdInterpolate.Name = "cmdInterpolate"
        Me.cmdInterpolate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdInterpolate.Size = New System.Drawing.Size(92, 60)
        Me.cmdInterpolate.TabIndex = 16
        Me.cmdInterpolate.Text = "Navigation Math"
        Me.cmdInterpolate.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdInterpolate, "Nav Math Tools to convert Angles or Time to Decimal, Add/Subtract Angle or Time, " &
        "Arrival Date&&Time, ZT from Long")
        Me.cmdInterpolate.UseVisualStyleBackColor = False
        '
        'cmdDistances
        '
        Me.cmdDistances.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDistances.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDistances.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDistances.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDistances.Image = CType(resources.GetObject("cmdDistances.Image"), System.Drawing.Image)
        Me.cmdDistances.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cmdDistances.Location = New System.Drawing.Point(203, 20)
        Me.cmdDistances.Name = "cmdDistances"
        Me.cmdDistances.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDistances.Size = New System.Drawing.Size(92, 60)
        Me.cmdDistances.TabIndex = 14
        Me.cmdDistances.Text = "Distance " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "From " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Objects"
        Me.cmdDistances.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.ToolTip1.SetToolTip(Me.cmdDistances, "Calculate distances from objects in common situation")
        Me.cmdDistances.UseVisualStyleBackColor = False
        '
        'cmdCTSSOA
        '
        Me.cmdCTSSOA.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCTSSOA.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCTSSOA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCTSSOA.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCTSSOA.Image = CType(resources.GetObject("cmdCTSSOA.Image"), System.Drawing.Image)
        Me.cmdCTSSOA.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cmdCTSSOA.Location = New System.Drawing.Point(492, 18)
        Me.cmdCTSSOA.Name = "cmdCTSSOA"
        Me.cmdCTSSOA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCTSSOA.Size = New System.Drawing.Size(92, 60)
        Me.cmdCTSSOA.TabIndex = 5
        Me.cmdCTSSOA.Text = "Calculate " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CTS && SOA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "or CMG && SMG"
        Me.cmdCTSSOA.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.ToolTip1.SetToolTip(Me.cmdCTSSOA, "Calculate CTS and SOA or CMG and SMG")
        Me.cmdCTSSOA.UseVisualStyleBackColor = False
        '
        'cmdSailings
        '
        Me.cmdSailings.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSailings.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSailings.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSailings.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSailings.Image = CType(resources.GetObject("cmdSailings.Image"), System.Drawing.Image)
        Me.cmdSailings.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdSailings.Location = New System.Drawing.Point(301, 20)
        Me.cmdSailings.Name = "cmdSailings"
        Me.cmdSailings.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSailings.Size = New System.Drawing.Size(92, 60)
        Me.cmdSailings.TabIndex = 9
        Me.cmdSailings.Text = "The Sailings"
        Me.cmdSailings.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdSailings, "Calculate sailing waypoints and distances")
        Me.cmdSailings.UseVisualStyleBackColor = False
        '
        'cmdArcTime
        '
        Me.cmdArcTime.BackColor = System.Drawing.SystemColors.Control
        Me.cmdArcTime.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdArcTime.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdArcTime.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdArcTime.Image = CType(resources.GetObject("cmdArcTime.Image"), System.Drawing.Image)
        Me.cmdArcTime.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cmdArcTime.Location = New System.Drawing.Point(492, 82)
        Me.cmdArcTime.Name = "cmdArcTime"
        Me.cmdArcTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdArcTime.Size = New System.Drawing.Size(92, 60)
        Me.cmdArcTime.TabIndex = 8
        Me.cmdArcTime.Text = "Convert" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Between" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Arcs && Times"
        Me.cmdArcTime.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.ToolTip1.SetToolTip(Me.cmdArcTime, "Convert Arcs to Time and Time to Arcs")
        Me.cmdArcTime.UseVisualStyleBackColor = False
        '
        'SRMethod
        '
        Me.SRMethod.BackColor = System.Drawing.SystemColors.Control
        Me.SRMethod.Cursor = System.Windows.Forms.Cursors.Default
        Me.SRMethod.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SRMethod.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SRMethod.Image = CType(resources.GetObject("SRMethod.Image"), System.Drawing.Image)
        Me.SRMethod.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SRMethod.Location = New System.Drawing.Point(300, 24)
        Me.SRMethod.Name = "SRMethod"
        Me.SRMethod.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SRMethod.Size = New System.Drawing.Size(92, 60)
        Me.SRMethod.TabIndex = 3
        Me.SRMethod.Text = "Alt SR Methods"
        Me.SRMethod.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.SRMethod, "Perform alternate method, tabular sight reductions")
        Me.SRMethod.UseVisualStyleBackColor = False
        '
        'cmdNoon
        '
        Me.cmdNoon.BackColor = System.Drawing.SystemColors.Control
        Me.cmdNoon.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdNoon.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNoon.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdNoon.Image = CType(resources.GetObject("cmdNoon.Image"), System.Drawing.Image)
        Me.cmdNoon.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdNoon.Location = New System.Drawing.Point(104, 23)
        Me.cmdNoon.Name = "cmdNoon"
        Me.cmdNoon.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdNoon.Size = New System.Drawing.Size(92, 60)
        Me.cmdNoon.TabIndex = 2
        Me.cmdNoon.Text = "Noon Sight"
        Me.cmdNoon.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdNoon, "Plan a sun noon sight or evaluate noon sight sight ")
        Me.cmdNoon.UseVisualStyleBackColor = False
        '
        'cmdReduction
        '
        Me.cmdReduction.BackColor = System.Drawing.SystemColors.Control
        Me.cmdReduction.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdReduction.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReduction.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdReduction.Image = CType(resources.GetObject("cmdReduction.Image"), System.Drawing.Image)
        Me.cmdReduction.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdReduction.Location = New System.Drawing.Point(201, 23)
        Me.cmdReduction.Name = "cmdReduction"
        Me.cmdReduction.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdReduction.Size = New System.Drawing.Size(92, 60)
        Me.cmdReduction.TabIndex = 1
        Me.cmdReduction.Text = "Sight Reduction"
        Me.cmdReduction.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdReduction, "Perform a Law of Cosines sight reduction for most celestial bodies")
        Me.cmdReduction.UseVisualStyleBackColor = False
        '
        'btnSightLog
        '
        Me.btnSightLog.BackColor = System.Drawing.SystemColors.Control
        Me.btnSightLog.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSightLog.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSightLog.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSightLog.Image = CType(resources.GetObject("btnSightLog.Image"), System.Drawing.Image)
        Me.btnSightLog.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSightLog.Location = New System.Drawing.Point(398, 24)
        Me.btnSightLog.Name = "btnSightLog"
        Me.btnSightLog.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSightLog.Size = New System.Drawing.Size(92, 60)
        Me.btnSightLog.TabIndex = 26
        Me.btnSightLog.Text = "Sight Log"
        Me.btnSightLog.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnSightLog, "Store sight data taken, recall, edit, perform sight reduction and plots")
        Me.btnSightLog.UseVisualStyleBackColor = False
        '
        'btnFavLocs
        '
        Me.btnFavLocs.BackColor = System.Drawing.SystemColors.Control
        Me.btnFavLocs.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnFavLocs.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFavLocs.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnFavLocs.Image = CType(resources.GetObject("btnFavLocs.Image"), System.Drawing.Image)
        Me.btnFavLocs.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnFavLocs.Location = New System.Drawing.Point(493, 24)
        Me.btnFavLocs.Name = "btnFavLocs"
        Me.btnFavLocs.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnFavLocs.Size = New System.Drawing.Size(92, 60)
        Me.btnFavLocs.TabIndex = 27
        Me.btnFavLocs.Text = "Shared Locations"
        Me.btnFavLocs.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.ToolTip1.SetToolTip(Me.btnFavLocs, "Input, store, and share common navigation locations with other forms")
        Me.btnFavLocs.UseVisualStyleBackColor = False
        '
        'btnDeckLog
        '
        Me.btnDeckLog.BackColor = System.Drawing.SystemColors.Control
        Me.btnDeckLog.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDeckLog.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeckLog.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDeckLog.Image = CType(resources.GetObject("btnDeckLog.Image"), System.Drawing.Image)
        Me.btnDeckLog.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDeckLog.Location = New System.Drawing.Point(6, 148)
        Me.btnDeckLog.Name = "btnDeckLog"
        Me.btnDeckLog.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnDeckLog.Size = New System.Drawing.Size(92, 60)
        Me.btnDeckLog.TabIndex = 28
        Me.btnDeckLog.Text = "Deck Log"
        Me.btnDeckLog.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnDeckLog, "Input and store deck log and route entries")
        Me.btnDeckLog.UseVisualStyleBackColor = False
        '
        'btnCVSFile
        '
        Me.btnCVSFile.BackColor = System.Drawing.SystemColors.Control
        Me.btnCVSFile.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCVSFile.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCVSFile.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCVSFile.Image = CType(resources.GetObject("btnCVSFile.Image"), System.Drawing.Image)
        Me.btnCVSFile.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnCVSFile.Location = New System.Drawing.Point(105, 148)
        Me.btnCVSFile.Name = "btnCVSFile"
        Me.btnCVSFile.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCVSFile.Size = New System.Drawing.Size(92, 60)
        Me.btnCVSFile.TabIndex = 29
        Me.btnCVSFile.Text = "DeckLog" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CSV File " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Utility"
        Me.btnCVSFile.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.ToolTip1.SetToolTip(Me.btnCVSFile, "Utility to allow view and updating of CSV report files ")
        Me.btnCVSFile.UseVisualStyleBackColor = False
        '
        'btnDevForm
        '
        Me.btnDevForm.BackColor = System.Drawing.SystemColors.Control
        Me.btnDevForm.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDevForm.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDevForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDevForm.Image = CType(resources.GetObject("btnDevForm.Image"), System.Drawing.Image)
        Me.btnDevForm.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnDevForm.Location = New System.Drawing.Point(590, 82)
        Me.btnDevForm.Name = "btnDevForm"
        Me.btnDevForm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnDevForm.Size = New System.Drawing.Size(92, 60)
        Me.btnDevForm.TabIndex = 30
        Me.btnDevForm.Text = "Deviation " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Data Form"
        Me.btnDevForm.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.ToolTip1.SetToolTip(Me.btnDevForm, "Input and Interpolate Deviation data for Compass Magnetic Headings ")
        Me.btnDevForm.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(25, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(699, 46)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Celestial Tools:  Navigation Class Tools"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ExitBtn
        '
        Me.ExitBtn.BackColor = System.Drawing.Color.Red
        Me.ExitBtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExitBtn.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ExitBtn.Image = CType(resources.GetObject("ExitBtn.Image"), System.Drawing.Image)
        Me.ExitBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ExitBtn.Location = New System.Drawing.Point(632, 516)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ExitBtn.Size = New System.Drawing.Size(92, 60)
        Me.ExitBtn.TabIndex = 24
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ExitBtn.UseVisualStyleBackColor = False
        '
        'HelpV2Btn
        '
        Me.HelpV2Btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HelpV2Btn.Cursor = System.Windows.Forms.Cursors.Default
        Me.HelpV2Btn.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpV2Btn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.HelpV2Btn.Image = CType(resources.GetObject("HelpV2Btn.Image"), System.Drawing.Image)
        Me.HelpV2Btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.HelpV2Btn.Location = New System.Drawing.Point(24, 518)
        Me.HelpV2Btn.Name = "HelpV2Btn"
        Me.HelpV2Btn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HelpV2Btn.Size = New System.Drawing.Size(92, 60)
        Me.HelpV2Btn.TabIndex = 25
        Me.HelpV2Btn.Text = "Help"
        Me.HelpV2Btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.HelpV2Btn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CelestialTools.My.Resources.Resources.ABC_white
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(99, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(555, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'cmdAbout
        '
        Me.cmdAbout.BackColor = System.Drawing.Color.Blue
        Me.cmdAbout.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAbout.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAbout.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdAbout.Image = CType(resources.GetObject("cmdAbout.Image"), System.Drawing.Image)
        Me.cmdAbout.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdAbout.Location = New System.Drawing.Point(324, 516)
        Me.cmdAbout.Name = "cmdAbout"
        Me.cmdAbout.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAbout.Size = New System.Drawing.Size(92, 60)
        Me.cmdAbout.TabIndex = 19
        Me.cmdAbout.Text = "About"
        Me.cmdAbout.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdAbout.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkGray
        Me.GroupBox1.Controls.Add(Me.SRMethod)
        Me.GroupBox1.Controls.Add(Me.cmdPlanning)
        Me.GroupBox1.Controls.Add(Me.btnFavLocs)
        Me.GroupBox1.Controls.Add(Me.cmdReduction)
        Me.GroupBox1.Controls.Add(Me.btnSightLog)
        Me.GroupBox1.Controls.Add(Me.cmdNoon)
        Me.GroupBox1.Controls.Add(Me.cmdYellow)
        Me.GroupBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GroupBox1.Location = New System.Drawing.Point(24, 133)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(700, 111)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Celestial Navigation Tools:  Plan, Reduce, Plot Sights"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.DarkGray
        Me.GroupBox2.Controls.Add(Me.btnTraverseTable)
        Me.GroupBox2.Controls.Add(Me.btnZoneTime)
        Me.GroupBox2.Controls.Add(Me.btnDevForm)
        Me.GroupBox2.Controls.Add(Me.btnCVSFile)
        Me.GroupBox2.Controls.Add(Me.btnDeckLog)
        Me.GroupBox2.Controls.Add(Me.cmd60DST)
        Me.GroupBox2.Controls.Add(Me.cmdArcTime)
        Me.GroupBox2.Controls.Add(Me.cmdSailings)
        Me.GroupBox2.Controls.Add(Me.cmdCTSSOA)
        Me.GroupBox2.Controls.Add(Me.cmdDistances)
        Me.GroupBox2.Controls.Add(Me.cmdCurrents)
        Me.GroupBox2.Controls.Add(Me.cmdInterpolate)
        Me.GroupBox2.Controls.Add(Me.cmdTides)
        Me.GroupBox2.Controls.Add(Me.cmdTVMDC)
        Me.GroupBox2.Controls.Add(Me.cmdTwoBearings)
        Me.GroupBox2.Controls.Add(Me.cmdLengthDeg)
        Me.GroupBox2.Controls.Add(Me.cmdCPA)
        Me.GroupBox2.Location = New System.Drawing.Point(24, 254)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(700, 221)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Marine Navigation Tools"
        '
        'btnTraverseTable
        '
        Me.btnTraverseTable.BackColor = System.Drawing.SystemColors.Control
        Me.btnTraverseTable.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnTraverseTable.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTraverseTable.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnTraverseTable.Image = CType(resources.GetObject("btnTraverseTable.Image"), System.Drawing.Image)
        Me.btnTraverseTable.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnTraverseTable.Location = New System.Drawing.Point(590, 18)
        Me.btnTraverseTable.Name = "btnTraverseTable"
        Me.btnTraverseTable.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnTraverseTable.Size = New System.Drawing.Size(92, 60)
        Me.btnTraverseTable.TabIndex = 32
        Me.btnTraverseTable.Text = "Dest L/Lo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Using " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Traverse Table"
        Me.btnTraverseTable.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnTraverseTable.UseVisualStyleBackColor = False
        '
        'btnZoneTime
        '
        Me.btnZoneTime.BackColor = System.Drawing.SystemColors.Control
        Me.btnZoneTime.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnZoneTime.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZoneTime.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnZoneTime.Image = CType(resources.GetObject("btnZoneTime.Image"), System.Drawing.Image)
        Me.btnZoneTime.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnZoneTime.Location = New System.Drawing.Point(590, 148)
        Me.btnZoneTime.Name = "btnZoneTime"
        Me.btnZoneTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnZoneTime.Size = New System.Drawing.Size(92, 60)
        Me.btnZoneTime.TabIndex = 31
        Me.btnZoneTime.Text = "Zone Time Calc"
        Me.btnZoneTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnZoneTime.UseVisualStyleBackColor = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(736, 598)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.HelpV2Btn)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.cmdAbout)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(37, 165)
        Me.MaximizeBox = False
        Me.Name = "MainMenu"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Celestial Tools"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents ExitBtn As Button
    Public WithEvents HelpV2Btn As Button
    Public WithEvents btnSightLog As Button
    Public WithEvents btnFavLocs As Button
    Friend WithEvents PictureBox1 As PictureBox
    Public WithEvents cmdAbout As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Public WithEvents btnDeckLog As Button
    Public WithEvents btnCVSFile As Button
    Public WithEvents btnDevForm As Button
    Public WithEvents btnZoneTime As Button
    Public WithEvents btnTraverseTable As Button
#End Region
End Class