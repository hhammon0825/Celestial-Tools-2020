<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form6
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
	Public WithEvents txtHelpCurrents As System.Windows.Forms.TextBox
	Public WithEvents cmdHelpCurrents As System.Windows.Forms.Button
	Public WithEvents txtHelpTides As System.Windows.Forms.TextBox
	Public WithEvents cmdHelpTides As System.Windows.Forms.Button
	Public WithEvents txtHelpTwoBearings As System.Windows.Forms.TextBox
	Public WithEvents cmdHelpTwoBearings As System.Windows.Forms.Button
	Public WithEvents txtHelpMoBoard As System.Windows.Forms.TextBox
	Public WithEvents cmdHelpMoBoard As System.Windows.Forms.Button
	Public WithEvents txtHelpYellow As System.Windows.Forms.TextBox
	Public WithEvents cmdHelpYellow As System.Windows.Forms.Button
	Public WithEvents txtHelpLength As System.Windows.Forms.TextBox
	Public WithEvents cmdHelpLength As System.Windows.Forms.Button
	Public WithEvents txtHelpTVMDC As System.Windows.Forms.TextBox
	Public WithEvents txtHelp60DST As System.Windows.Forms.TextBox
	Public WithEvents cmdHelpTVMDC As System.Windows.Forms.Button
	Public WithEvents cmdHelp60DST As System.Windows.Forms.Button
	Public WithEvents txtHelpInterpolate As System.Windows.Forms.TextBox
	Public WithEvents cmdHelpInterpolate As System.Windows.Forms.Button
	Public WithEvents txtHelpDistances As System.Windows.Forms.TextBox
	Public WithEvents cmdHelpDistances As System.Windows.Forms.Button
	Public WithEvents txtHelpCTS_SOA As System.Windows.Forms.TextBox
	Public WithEvents cmdHelpCTS_SOA As System.Windows.Forms.Button
	Public WithEvents txtHelpSailings As System.Windows.Forms.TextBox
	Public WithEvents cmdHelpSailings As System.Windows.Forms.Button
	Public WithEvents txtHelpArcTime As System.Windows.Forms.TextBox
	Public WithEvents cmdHelpArcTime As System.Windows.Forms.Button
	Public WithEvents txtHelpAveraging As System.Windows.Forms.TextBox
	Public WithEvents cmdHelpAveraging As System.Windows.Forms.Button
	Public WithEvents txtHelpLoCNASR As System.Windows.Forms.TextBox
	Public WithEvents cmdHelpLoCNASR As System.Windows.Forms.Button
	Public WithEvents cmdHelpFavorites As System.Windows.Forms.Button
	Public WithEvents cmdHelpNoon As System.Windows.Forms.Button
	Public WithEvents cmdHelpSRF As System.Windows.Forms.Button
	Public WithEvents cmdHelpPlan As System.Windows.Forms.Button
	Public WithEvents cmdHelpGeneral As System.Windows.Forms.Button
	Public WithEvents cmdPrint As System.Windows.Forms.Button
	Public WithEvents txtHelpSRF As System.Windows.Forms.TextBox
	Public WithEvents txtHelpFavorites As System.Windows.Forms.TextBox
	Public WithEvents txtHelpGeneral As System.Windows.Forms.TextBox
	Public WithEvents txtHelpPlan As System.Windows.Forms.TextBox
	Public WithEvents txtHelpNoon As System.Windows.Forms.TextBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.txtHelpCurrents = New System.Windows.Forms.TextBox()
        Me.cmdHelpCurrents = New System.Windows.Forms.Button()
        Me.txtHelpTides = New System.Windows.Forms.TextBox()
        Me.cmdHelpTides = New System.Windows.Forms.Button()
        Me.txtHelpTwoBearings = New System.Windows.Forms.TextBox()
        Me.cmdHelpTwoBearings = New System.Windows.Forms.Button()
        Me.txtHelpMoBoard = New System.Windows.Forms.TextBox()
        Me.cmdHelpMoBoard = New System.Windows.Forms.Button()
        Me.txtHelpYellow = New System.Windows.Forms.TextBox()
        Me.cmdHelpYellow = New System.Windows.Forms.Button()
        Me.txtHelpLength = New System.Windows.Forms.TextBox()
        Me.cmdHelpLength = New System.Windows.Forms.Button()
        Me.txtHelpTVMDC = New System.Windows.Forms.TextBox()
        Me.txtHelp60DST = New System.Windows.Forms.TextBox()
        Me.cmdHelpTVMDC = New System.Windows.Forms.Button()
        Me.cmdHelp60DST = New System.Windows.Forms.Button()
        Me.txtHelpInterpolate = New System.Windows.Forms.TextBox()
        Me.cmdHelpInterpolate = New System.Windows.Forms.Button()
        Me.txtHelpDistances = New System.Windows.Forms.TextBox()
        Me.cmdHelpDistances = New System.Windows.Forms.Button()
        Me.txtHelpCTS_SOA = New System.Windows.Forms.TextBox()
        Me.cmdHelpCTS_SOA = New System.Windows.Forms.Button()
        Me.txtHelpSailings = New System.Windows.Forms.TextBox()
        Me.cmdHelpSailings = New System.Windows.Forms.Button()
        Me.txtHelpArcTime = New System.Windows.Forms.TextBox()
        Me.cmdHelpArcTime = New System.Windows.Forms.Button()
        Me.txtHelpAveraging = New System.Windows.Forms.TextBox()
        Me.cmdHelpAveraging = New System.Windows.Forms.Button()
        Me.txtHelpLoCNASR = New System.Windows.Forms.TextBox()
        Me.cmdHelpLoCNASR = New System.Windows.Forms.Button()
        Me.cmdHelpFavorites = New System.Windows.Forms.Button()
        Me.cmdHelpNoon = New System.Windows.Forms.Button()
        Me.cmdHelpSRF = New System.Windows.Forms.Button()
        Me.cmdHelpPlan = New System.Windows.Forms.Button()
        Me.cmdHelpGeneral = New System.Windows.Forms.Button()
        Me.txtHelpSRF = New System.Windows.Forms.TextBox()
        Me.txtHelpFavorites = New System.Windows.Forms.TextBox()
        Me.txtHelpGeneral = New System.Windows.Forms.TextBox()
        Me.txtHelpPlan = New System.Windows.Forms.TextBox()
        Me.txtHelpNoon = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrint.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.Location = New System.Drawing.Point(741, 0)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrint.Size = New System.Drawing.Size(21, 21)
        Me.cmdPrint.TabIndex = 36
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdPrint, "Print window")
        Me.cmdPrint.UseVisualStyleBackColor = False
        '
        'txtHelpCurrents
        '
        Me.txtHelpCurrents.AcceptsReturn = True
        Me.txtHelpCurrents.BackColor = System.Drawing.SystemColors.Window
        Me.txtHelpCurrents.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHelpCurrents.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHelpCurrents.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHelpCurrents.Location = New System.Drawing.Point(0, 72)
        Me.txtHelpCurrents.MaxLength = 0
        Me.txtHelpCurrents.Multiline = True
        Me.txtHelpCurrents.Name = "txtHelpCurrents"
        Me.txtHelpCurrents.ReadOnly = True
        Me.txtHelpCurrents.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHelpCurrents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtHelpCurrents.Size = New System.Drawing.Size(761, 505)
        Me.txtHelpCurrents.TabIndex = 40
        Me.txtHelpCurrents.Text = resources.GetString("txtHelpCurrents.Text")
        '
        'cmdHelpCurrents
        '
        Me.cmdHelpCurrents.BackColor = System.Drawing.SystemColors.Control
        Me.cmdHelpCurrents.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdHelpCurrents.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHelpCurrents.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdHelpCurrents.Location = New System.Drawing.Point(668, 48)
        Me.cmdHelpCurrents.Name = "cmdHelpCurrents"
        Me.cmdHelpCurrents.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdHelpCurrents.Size = New System.Drawing.Size(95, 25)
        Me.cmdHelpCurrents.TabIndex = 39
        Me.cmdHelpCurrents.Text = "Curr&ents"
        Me.cmdHelpCurrents.UseVisualStyleBackColor = False
        '
        'txtHelpTides
        '
        Me.txtHelpTides.AcceptsReturn = True
        Me.txtHelpTides.BackColor = System.Drawing.SystemColors.Window
        Me.txtHelpTides.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHelpTides.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHelpTides.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHelpTides.Location = New System.Drawing.Point(0, 72)
        Me.txtHelpTides.MaxLength = 0
        Me.txtHelpTides.Multiline = True
        Me.txtHelpTides.Name = "txtHelpTides"
        Me.txtHelpTides.ReadOnly = True
        Me.txtHelpTides.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHelpTides.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtHelpTides.Size = New System.Drawing.Size(761, 505)
        Me.txtHelpTides.TabIndex = 38
        Me.txtHelpTides.Text = resources.GetString("txtHelpTides.Text")
        '
        'cmdHelpTides
        '
        Me.cmdHelpTides.BackColor = System.Drawing.SystemColors.Control
        Me.cmdHelpTides.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdHelpTides.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHelpTides.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdHelpTides.Location = New System.Drawing.Point(573, 48)
        Me.cmdHelpTides.Name = "cmdHelpTides"
        Me.cmdHelpTides.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdHelpTides.Size = New System.Drawing.Size(95, 25)
        Me.cmdHelpTides.TabIndex = 37
        Me.cmdHelpTides.Text = "&Tides"
        Me.cmdHelpTides.UseVisualStyleBackColor = False
        '
        'txtHelpTwoBearings
        '
        Me.txtHelpTwoBearings.AcceptsReturn = True
        Me.txtHelpTwoBearings.BackColor = System.Drawing.SystemColors.Window
        Me.txtHelpTwoBearings.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHelpTwoBearings.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHelpTwoBearings.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHelpTwoBearings.Location = New System.Drawing.Point(0, 72)
        Me.txtHelpTwoBearings.MaxLength = 0
        Me.txtHelpTwoBearings.Multiline = True
        Me.txtHelpTwoBearings.Name = "txtHelpTwoBearings"
        Me.txtHelpTwoBearings.ReadOnly = True
        Me.txtHelpTwoBearings.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHelpTwoBearings.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtHelpTwoBearings.Size = New System.Drawing.Size(760, 505)
        Me.txtHelpTwoBearings.TabIndex = 1
        Me.txtHelpTwoBearings.TabStop = False
        Me.txtHelpTwoBearings.Text = resources.GetString("txtHelpTwoBearings.Text")
        '
        'cmdHelpTwoBearings
        '
        Me.cmdHelpTwoBearings.BackColor = System.Drawing.SystemColors.Control
        Me.cmdHelpTwoBearings.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdHelpTwoBearings.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHelpTwoBearings.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdHelpTwoBearings.Location = New System.Drawing.Point(284, 48)
        Me.cmdHelpTwoBearings.Name = "cmdHelpTwoBearings"
        Me.cmdHelpTwoBearings.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdHelpTwoBearings.Size = New System.Drawing.Size(98, 25)
        Me.cmdHelpTwoBearings.TabIndex = 33
        Me.cmdHelpTwoBearings.Text = "&2/3  Bearings"
        Me.cmdHelpTwoBearings.UseVisualStyleBackColor = False
        '
        'txtHelpMoBoard
        '
        Me.txtHelpMoBoard.AcceptsReturn = True
        Me.txtHelpMoBoard.BackColor = System.Drawing.SystemColors.Window
        Me.txtHelpMoBoard.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHelpMoBoard.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHelpMoBoard.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHelpMoBoard.Location = New System.Drawing.Point(0, 72)
        Me.txtHelpMoBoard.MaxLength = 0
        Me.txtHelpMoBoard.Multiline = True
        Me.txtHelpMoBoard.Name = "txtHelpMoBoard"
        Me.txtHelpMoBoard.ReadOnly = True
        Me.txtHelpMoBoard.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHelpMoBoard.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtHelpMoBoard.Size = New System.Drawing.Size(760, 505)
        Me.txtHelpMoBoard.TabIndex = 7
        Me.txtHelpMoBoard.TabStop = False
        Me.txtHelpMoBoard.Text = resources.GetString("txtHelpMoBoard.Text")
        '
        'cmdHelpMoBoard
        '
        Me.cmdHelpMoBoard.BackColor = System.Drawing.SystemColors.Control
        Me.cmdHelpMoBoard.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdHelpMoBoard.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHelpMoBoard.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdHelpMoBoard.Location = New System.Drawing.Point(189, 48)
        Me.cmdHelpMoBoard.Name = "cmdHelpMoBoard"
        Me.cmdHelpMoBoard.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdHelpMoBoard.Size = New System.Drawing.Size(95, 25)
        Me.cmdHelpMoBoard.TabIndex = 32
        Me.cmdHelpMoBoard.Text = "Mo&Board"
        Me.cmdHelpMoBoard.UseVisualStyleBackColor = False
        '
        'txtHelpYellow
        '
        Me.txtHelpYellow.AcceptsReturn = True
        Me.txtHelpYellow.BackColor = System.Drawing.SystemColors.Window
        Me.txtHelpYellow.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHelpYellow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHelpYellow.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHelpYellow.Location = New System.Drawing.Point(0, 72)
        Me.txtHelpYellow.MaxLength = 0
        Me.txtHelpYellow.Multiline = True
        Me.txtHelpYellow.Name = "txtHelpYellow"
        Me.txtHelpYellow.ReadOnly = True
        Me.txtHelpYellow.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHelpYellow.Size = New System.Drawing.Size(760, 505)
        Me.txtHelpYellow.TabIndex = 0
        Me.txtHelpYellow.TabStop = False
        Me.txtHelpYellow.Text = resources.GetString("txtHelpYellow.Text")
        '
        'cmdHelpYellow
        '
        Me.cmdHelpYellow.BackColor = System.Drawing.SystemColors.Control
        Me.cmdHelpYellow.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdHelpYellow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHelpYellow.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdHelpYellow.Location = New System.Drawing.Point(0, 24)
        Me.cmdHelpYellow.Name = "cmdHelpYellow"
        Me.cmdHelpYellow.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdHelpYellow.Size = New System.Drawing.Size(145, 24)
        Me.cmdHelpYellow.TabIndex = 24
        Me.cmdHelpYellow.Text = "&Yellow Pages (I&&C)"
        Me.cmdHelpYellow.UseVisualStyleBackColor = False
        '
        'txtHelpLength
        '
        Me.txtHelpLength.AcceptsReturn = True
        Me.txtHelpLength.BackColor = System.Drawing.SystemColors.Window
        Me.txtHelpLength.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHelpLength.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHelpLength.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHelpLength.Location = New System.Drawing.Point(0, 72)
        Me.txtHelpLength.MaxLength = 0
        Me.txtHelpLength.Multiline = True
        Me.txtHelpLength.Name = "txtHelpLength"
        Me.txtHelpLength.ReadOnly = True
        Me.txtHelpLength.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHelpLength.Size = New System.Drawing.Size(760, 505)
        Me.txtHelpLength.TabIndex = 9
        Me.txtHelpLength.TabStop = False
        Me.txtHelpLength.Text = resources.GetString("txtHelpLength.Text")
        '
        'cmdHelpLength
        '
        Me.cmdHelpLength.BackColor = System.Drawing.SystemColors.Control
        Me.cmdHelpLength.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdHelpLength.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHelpLength.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdHelpLength.Location = New System.Drawing.Point(399, 24)
        Me.cmdHelpLength.Name = "cmdHelpLength"
        Me.cmdHelpLength.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdHelpLength.Size = New System.Drawing.Size(139, 25)
        Me.cmdHelpLength.TabIndex = 27
        Me.cmdHelpLength.Text = "&Length of Degree"
        Me.cmdHelpLength.UseVisualStyleBackColor = False
        '
        'txtHelpTVMDC
        '
        Me.txtHelpTVMDC.AcceptsReturn = True
        Me.txtHelpTVMDC.BackColor = System.Drawing.SystemColors.Window
        Me.txtHelpTVMDC.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHelpTVMDC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHelpTVMDC.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHelpTVMDC.Location = New System.Drawing.Point(0, 72)
        Me.txtHelpTVMDC.MaxLength = 0
        Me.txtHelpTVMDC.Multiline = True
        Me.txtHelpTVMDC.Name = "txtHelpTVMDC"
        Me.txtHelpTVMDC.ReadOnly = True
        Me.txtHelpTVMDC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHelpTVMDC.Size = New System.Drawing.Size(760, 505)
        Me.txtHelpTVMDC.TabIndex = 2
        Me.txtHelpTVMDC.TabStop = False
        Me.txtHelpTVMDC.Text = resources.GetString("txtHelpTVMDC.Text")
        '
        'txtHelp60DST
        '
        Me.txtHelp60DST.AcceptsReturn = True
        Me.txtHelp60DST.BackColor = System.Drawing.SystemColors.Window
        Me.txtHelp60DST.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHelp60DST.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHelp60DST.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHelp60DST.Location = New System.Drawing.Point(0, 72)
        Me.txtHelp60DST.MaxLength = 0
        Me.txtHelp60DST.Multiline = True
        Me.txtHelp60DST.Name = "txtHelp60DST"
        Me.txtHelp60DST.ReadOnly = True
        Me.txtHelp60DST.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHelp60DST.Size = New System.Drawing.Size(760, 505)
        Me.txtHelp60DST.TabIndex = 17
        Me.txtHelp60DST.TabStop = False
        Me.txtHelp60DST.Text = resources.GetString("txtHelp60DST.Text")
        '
        'cmdHelpTVMDC
        '
        Me.cmdHelpTVMDC.BackColor = System.Drawing.SystemColors.Control
        Me.cmdHelpTVMDC.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdHelpTVMDC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHelpTVMDC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdHelpTVMDC.Location = New System.Drawing.Point(95, 48)
        Me.cmdHelpTVMDC.Name = "cmdHelpTVMDC"
        Me.cmdHelpTVMDC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdHelpTVMDC.Size = New System.Drawing.Size(95, 25)
        Me.cmdHelpTVMDC.TabIndex = 31
        Me.cmdHelpTVMDC.Text = "TV&MDC"
        Me.cmdHelpTVMDC.UseVisualStyleBackColor = False
        '
        'cmdHelp60DST
        '
        Me.cmdHelp60DST.BackColor = System.Drawing.SystemColors.Control
        Me.cmdHelp60DST.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdHelp60DST.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHelp60DST.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdHelp60DST.Location = New System.Drawing.Point(0, 48)
        Me.cmdHelp60DST.Name = "cmdHelp60DST"
        Me.cmdHelp60DST.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdHelp60DST.Size = New System.Drawing.Size(95, 25)
        Me.cmdHelp60DST.TabIndex = 30
        Me.cmdHelp60DST.Text = "&60D=ST"
        Me.cmdHelp60DST.UseVisualStyleBackColor = False
        '
        'txtHelpInterpolate
        '
        Me.txtHelpInterpolate.AcceptsReturn = True
        Me.txtHelpInterpolate.BackColor = System.Drawing.SystemColors.Window
        Me.txtHelpInterpolate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHelpInterpolate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHelpInterpolate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHelpInterpolate.Location = New System.Drawing.Point(0, 72)
        Me.txtHelpInterpolate.MaxLength = 0
        Me.txtHelpInterpolate.Multiline = True
        Me.txtHelpInterpolate.Name = "txtHelpInterpolate"
        Me.txtHelpInterpolate.ReadOnly = True
        Me.txtHelpInterpolate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHelpInterpolate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtHelpInterpolate.Size = New System.Drawing.Size(760, 505)
        Me.txtHelpInterpolate.TabIndex = 10
        Me.txtHelpInterpolate.TabStop = False
        Me.txtHelpInterpolate.Text = resources.GetString("txtHelpInterpolate.Text")
        '
        'cmdHelpInterpolate
        '
        Me.cmdHelpInterpolate.BackColor = System.Drawing.SystemColors.Control
        Me.cmdHelpInterpolate.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdHelpInterpolate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHelpInterpolate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdHelpInterpolate.Location = New System.Drawing.Point(277, 24)
        Me.cmdHelpInterpolate.Name = "cmdHelpInterpolate"
        Me.cmdHelpInterpolate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdHelpInterpolate.Size = New System.Drawing.Size(123, 25)
        Me.cmdHelpInterpolate.TabIndex = 26
        Me.cmdHelpInterpolate.Text = "Nav&ig. Math"
        Me.cmdHelpInterpolate.UseVisualStyleBackColor = False
        '
        'txtHelpDistances
        '
        Me.txtHelpDistances.AcceptsReturn = True
        Me.txtHelpDistances.BackColor = System.Drawing.SystemColors.Window
        Me.txtHelpDistances.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHelpDistances.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHelpDistances.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHelpDistances.Location = New System.Drawing.Point(0, 72)
        Me.txtHelpDistances.MaxLength = 0
        Me.txtHelpDistances.Multiline = True
        Me.txtHelpDistances.Name = "txtHelpDistances"
        Me.txtHelpDistances.ReadOnly = True
        Me.txtHelpDistances.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHelpDistances.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtHelpDistances.Size = New System.Drawing.Size(760, 505)
        Me.txtHelpDistances.TabIndex = 13
        Me.txtHelpDistances.TabStop = False
        Me.txtHelpDistances.Text = resources.GetString("txtHelpDistances.Text")
        '
        'cmdHelpDistances
        '
        Me.cmdHelpDistances.BackColor = System.Drawing.SystemColors.Control
        Me.cmdHelpDistances.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdHelpDistances.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHelpDistances.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdHelpDistances.Location = New System.Drawing.Point(479, 48)
        Me.cmdHelpDistances.Name = "cmdHelpDistances"
        Me.cmdHelpDistances.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdHelpDistances.Size = New System.Drawing.Size(95, 25)
        Me.cmdHelpDistances.TabIndex = 35
        Me.cmdHelpDistances.Text = "&Distances"
        Me.cmdHelpDistances.UseVisualStyleBackColor = False
        '
        'txtHelpCTS_SOA
        '
        Me.txtHelpCTS_SOA.AcceptsReturn = True
        Me.txtHelpCTS_SOA.BackColor = System.Drawing.SystemColors.Window
        Me.txtHelpCTS_SOA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHelpCTS_SOA.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHelpCTS_SOA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHelpCTS_SOA.Location = New System.Drawing.Point(0, 72)
        Me.txtHelpCTS_SOA.MaxLength = 0
        Me.txtHelpCTS_SOA.Multiline = True
        Me.txtHelpCTS_SOA.Name = "txtHelpCTS_SOA"
        Me.txtHelpCTS_SOA.ReadOnly = True
        Me.txtHelpCTS_SOA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHelpCTS_SOA.Size = New System.Drawing.Size(760, 505)
        Me.txtHelpCTS_SOA.TabIndex = 14
        Me.txtHelpCTS_SOA.TabStop = False
        Me.txtHelpCTS_SOA.Text = resources.GetString("txtHelpCTS_SOA.Text")
        '
        'cmdHelpCTS_SOA
        '
        Me.cmdHelpCTS_SOA.BackColor = System.Drawing.SystemColors.Control
        Me.cmdHelpCTS_SOA.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdHelpCTS_SOA.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHelpCTS_SOA.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdHelpCTS_SOA.Location = New System.Drawing.Point(381, 48)
        Me.cmdHelpCTS_SOA.Name = "cmdHelpCTS_SOA"
        Me.cmdHelpCTS_SOA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdHelpCTS_SOA.Size = New System.Drawing.Size(98, 25)
        Me.cmdHelpCTS_SOA.TabIndex = 34
        Me.cmdHelpCTS_SOA.Text = "Wind && &Current"
        Me.cmdHelpCTS_SOA.UseVisualStyleBackColor = False
        '
        'txtHelpSailings
        '
        Me.txtHelpSailings.AcceptsReturn = True
        Me.txtHelpSailings.BackColor = System.Drawing.SystemColors.Window
        Me.txtHelpSailings.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHelpSailings.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHelpSailings.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHelpSailings.Location = New System.Drawing.Point(0, 72)
        Me.txtHelpSailings.MaxLength = 0
        Me.txtHelpSailings.Multiline = True
        Me.txtHelpSailings.Name = "txtHelpSailings"
        Me.txtHelpSailings.ReadOnly = True
        Me.txtHelpSailings.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHelpSailings.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtHelpSailings.Size = New System.Drawing.Size(760, 505)
        Me.txtHelpSailings.TabIndex = 4
        Me.txtHelpSailings.TabStop = False
        Me.txtHelpSailings.Text = resources.GetString("txtHelpSailings.Text")
        '
        'cmdHelpSailings
        '
        Me.cmdHelpSailings.BackColor = System.Drawing.SystemColors.Control
        Me.cmdHelpSailings.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdHelpSailings.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHelpSailings.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdHelpSailings.Location = New System.Drawing.Point(665, 24)
        Me.cmdHelpSailings.Name = "cmdHelpSailings"
        Me.cmdHelpSailings.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdHelpSailings.Size = New System.Drawing.Size(98, 25)
        Me.cmdHelpSailings.TabIndex = 29
        Me.cmdHelpSailings.Text = "The Sailin&gs"
        Me.cmdHelpSailings.UseVisualStyleBackColor = False
        '
        'txtHelpArcTime
        '
        Me.txtHelpArcTime.AcceptsReturn = True
        Me.txtHelpArcTime.BackColor = System.Drawing.SystemColors.Window
        Me.txtHelpArcTime.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHelpArcTime.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHelpArcTime.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHelpArcTime.Location = New System.Drawing.Point(0, 72)
        Me.txtHelpArcTime.MaxLength = 0
        Me.txtHelpArcTime.Multiline = True
        Me.txtHelpArcTime.Name = "txtHelpArcTime"
        Me.txtHelpArcTime.ReadOnly = True
        Me.txtHelpArcTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHelpArcTime.Size = New System.Drawing.Size(760, 505)
        Me.txtHelpArcTime.TabIndex = 16
        Me.txtHelpArcTime.TabStop = False
        Me.txtHelpArcTime.Text = resources.GetString("txtHelpArcTime.Text")
        '
        'cmdHelpArcTime
        '
        Me.cmdHelpArcTime.BackColor = System.Drawing.SystemColors.Control
        Me.cmdHelpArcTime.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdHelpArcTime.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHelpArcTime.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdHelpArcTime.Location = New System.Drawing.Point(145, 24)
        Me.cmdHelpArcTime.Name = "cmdHelpArcTime"
        Me.cmdHelpArcTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdHelpArcTime.Size = New System.Drawing.Size(132, 25)
        Me.cmdHelpArcTime.TabIndex = 25
        Me.cmdHelpArcTime.Text = "&Arcs and Times"
        Me.cmdHelpArcTime.UseVisualStyleBackColor = False
        '
        'txtHelpAveraging
        '
        Me.txtHelpAveraging.AcceptsReturn = True
        Me.txtHelpAveraging.BackColor = System.Drawing.SystemColors.Window
        Me.txtHelpAveraging.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHelpAveraging.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHelpAveraging.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHelpAveraging.Location = New System.Drawing.Point(0, 72)
        Me.txtHelpAveraging.MaxLength = 0
        Me.txtHelpAveraging.Multiline = True
        Me.txtHelpAveraging.Name = "txtHelpAveraging"
        Me.txtHelpAveraging.ReadOnly = True
        Me.txtHelpAveraging.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHelpAveraging.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtHelpAveraging.Size = New System.Drawing.Size(760, 505)
        Me.txtHelpAveraging.TabIndex = 15
        Me.txtHelpAveraging.TabStop = False
        Me.txtHelpAveraging.Text = resources.GetString("txtHelpAveraging.Text")
        '
        'cmdHelpAveraging
        '
        Me.cmdHelpAveraging.BackColor = System.Drawing.SystemColors.Control
        Me.cmdHelpAveraging.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdHelpAveraging.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHelpAveraging.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdHelpAveraging.Location = New System.Drawing.Point(538, 24)
        Me.cmdHelpAveraging.Name = "cmdHelpAveraging"
        Me.cmdHelpAveraging.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdHelpAveraging.Size = New System.Drawing.Size(128, 25)
        Me.cmdHelpAveraging.TabIndex = 28
        Me.cmdHelpAveraging.Text = "Sight A&veraging"
        Me.cmdHelpAveraging.UseVisualStyleBackColor = False
        '
        'txtHelpLoCNASR
        '
        Me.txtHelpLoCNASR.AcceptsReturn = True
        Me.txtHelpLoCNASR.BackColor = System.Drawing.SystemColors.Window
        Me.txtHelpLoCNASR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHelpLoCNASR.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHelpLoCNASR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHelpLoCNASR.Location = New System.Drawing.Point(0, 72)
        Me.txtHelpLoCNASR.MaxLength = 0
        Me.txtHelpLoCNASR.Multiline = True
        Me.txtHelpLoCNASR.Name = "txtHelpLoCNASR"
        Me.txtHelpLoCNASR.ReadOnly = True
        Me.txtHelpLoCNASR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHelpLoCNASR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtHelpLoCNASR.Size = New System.Drawing.Size(760, 505)
        Me.txtHelpLoCNASR.TabIndex = 8
        Me.txtHelpLoCNASR.TabStop = False
        Me.txtHelpLoCNASR.Text = resources.GetString("txtHelpLoCNASR.Text")
        '
        'cmdHelpLoCNASR
        '
        Me.cmdHelpLoCNASR.BackColor = System.Drawing.SystemColors.Control
        Me.cmdHelpLoCNASR.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdHelpLoCNASR.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHelpLoCNASR.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdHelpLoCNASR.Location = New System.Drawing.Point(503, 0)
        Me.cmdHelpLoCNASR.Name = "cmdHelpLoCNASR"
        Me.cmdHelpLoCNASR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdHelpLoCNASR.Size = New System.Drawing.Size(121, 25)
        Me.cmdHelpLoCNASR.TabIndex = 22
        Me.cmdHelpLoCNASR.Text = "SR Meth&ods && Fix"
        Me.cmdHelpLoCNASR.UseVisualStyleBackColor = False
        '
        'cmdHelpFavorites
        '
        Me.cmdHelpFavorites.BackColor = System.Drawing.SystemColors.Control
        Me.cmdHelpFavorites.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdHelpFavorites.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHelpFavorites.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdHelpFavorites.Location = New System.Drawing.Point(624, 0)
        Me.cmdHelpFavorites.Name = "cmdHelpFavorites"
        Me.cmdHelpFavorites.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdHelpFavorites.Size = New System.Drawing.Size(117, 25)
        Me.cmdHelpFavorites.TabIndex = 23
        Me.cmdHelpFavorites.Text = "&Favorite Places"
        Me.cmdHelpFavorites.UseVisualStyleBackColor = False
        '
        'cmdHelpNoon
        '
        Me.cmdHelpNoon.BackColor = System.Drawing.SystemColors.Control
        Me.cmdHelpNoon.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdHelpNoon.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHelpNoon.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdHelpNoon.Location = New System.Drawing.Point(390, 0)
        Me.cmdHelpNoon.Name = "cmdHelpNoon"
        Me.cmdHelpNoon.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdHelpNoon.Size = New System.Drawing.Size(114, 25)
        Me.cmdHelpNoon.TabIndex = 21
        Me.cmdHelpNoon.Text = "&Noon Sight"
        Me.cmdHelpNoon.UseVisualStyleBackColor = False
        '
        'cmdHelpSRF
        '
        Me.cmdHelpSRF.BackColor = System.Drawing.SystemColors.Control
        Me.cmdHelpSRF.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdHelpSRF.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHelpSRF.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdHelpSRF.Location = New System.Drawing.Point(234, 0)
        Me.cmdHelpSRF.Name = "cmdHelpSRF"
        Me.cmdHelpSRF.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdHelpSRF.Size = New System.Drawing.Size(156, 25)
        Me.cmdHelpSRF.TabIndex = 20
        Me.cmdHelpSRF.Text = "Sight &Reduction && Fix"
        Me.cmdHelpSRF.UseVisualStyleBackColor = False
        '
        'cmdHelpPlan
        '
        Me.cmdHelpPlan.BackColor = System.Drawing.SystemColors.Control
        Me.cmdHelpPlan.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdHelpPlan.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHelpPlan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdHelpPlan.Location = New System.Drawing.Point(117, 0)
        Me.cmdHelpPlan.Name = "cmdHelpPlan"
        Me.cmdHelpPlan.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdHelpPlan.Size = New System.Drawing.Size(117, 25)
        Me.cmdHelpPlan.TabIndex = 19
        Me.cmdHelpPlan.Text = "Sight &Planner"
        Me.cmdHelpPlan.UseVisualStyleBackColor = False
        '
        'cmdHelpGeneral
        '
        Me.cmdHelpGeneral.BackColor = System.Drawing.SystemColors.Control
        Me.cmdHelpGeneral.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdHelpGeneral.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHelpGeneral.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdHelpGeneral.Location = New System.Drawing.Point(0, 0)
        Me.cmdHelpGeneral.Name = "cmdHelpGeneral"
        Me.cmdHelpGeneral.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdHelpGeneral.Size = New System.Drawing.Size(117, 25)
        Me.cmdHelpGeneral.TabIndex = 18
        Me.cmdHelpGeneral.Text = "&General"
        Me.cmdHelpGeneral.UseVisualStyleBackColor = False
        '
        'txtHelpSRF
        '
        Me.txtHelpSRF.AcceptsReturn = True
        Me.txtHelpSRF.BackColor = System.Drawing.SystemColors.Window
        Me.txtHelpSRF.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHelpSRF.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHelpSRF.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHelpSRF.Location = New System.Drawing.Point(0, 72)
        Me.txtHelpSRF.MaxLength = 0
        Me.txtHelpSRF.Multiline = True
        Me.txtHelpSRF.Name = "txtHelpSRF"
        Me.txtHelpSRF.ReadOnly = True
        Me.txtHelpSRF.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHelpSRF.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtHelpSRF.Size = New System.Drawing.Size(760, 505)
        Me.txtHelpSRF.TabIndex = 3
        Me.txtHelpSRF.TabStop = False
        Me.txtHelpSRF.Text = resources.GetString("txtHelpSRF.Text")
        '
        'txtHelpFavorites
        '
        Me.txtHelpFavorites.AcceptsReturn = True
        Me.txtHelpFavorites.BackColor = System.Drawing.SystemColors.Window
        Me.txtHelpFavorites.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHelpFavorites.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHelpFavorites.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHelpFavorites.Location = New System.Drawing.Point(0, 72)
        Me.txtHelpFavorites.MaxLength = 0
        Me.txtHelpFavorites.Multiline = True
        Me.txtHelpFavorites.Name = "txtHelpFavorites"
        Me.txtHelpFavorites.ReadOnly = True
        Me.txtHelpFavorites.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHelpFavorites.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtHelpFavorites.Size = New System.Drawing.Size(760, 505)
        Me.txtHelpFavorites.TabIndex = 12
        Me.txtHelpFavorites.TabStop = False
        Me.txtHelpFavorites.Text = resources.GetString("txtHelpFavorites.Text")
        '
        'txtHelpGeneral
        '
        Me.txtHelpGeneral.AcceptsReturn = True
        Me.txtHelpGeneral.BackColor = System.Drawing.SystemColors.Window
        Me.txtHelpGeneral.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHelpGeneral.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHelpGeneral.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHelpGeneral.Location = New System.Drawing.Point(0, 72)
        Me.txtHelpGeneral.MaxLength = 0
        Me.txtHelpGeneral.Multiline = True
        Me.txtHelpGeneral.Name = "txtHelpGeneral"
        Me.txtHelpGeneral.ReadOnly = True
        Me.txtHelpGeneral.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHelpGeneral.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtHelpGeneral.Size = New System.Drawing.Size(760, 505)
        Me.txtHelpGeneral.TabIndex = 11
        Me.txtHelpGeneral.TabStop = False
        Me.txtHelpGeneral.Text = resources.GetString("txtHelpGeneral.Text")
        '
        'txtHelpPlan
        '
        Me.txtHelpPlan.AcceptsReturn = True
        Me.txtHelpPlan.BackColor = System.Drawing.SystemColors.Window
        Me.txtHelpPlan.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHelpPlan.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHelpPlan.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHelpPlan.Location = New System.Drawing.Point(0, 72)
        Me.txtHelpPlan.MaxLength = 0
        Me.txtHelpPlan.Multiline = True
        Me.txtHelpPlan.Name = "txtHelpPlan"
        Me.txtHelpPlan.ReadOnly = True
        Me.txtHelpPlan.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHelpPlan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtHelpPlan.Size = New System.Drawing.Size(760, 505)
        Me.txtHelpPlan.TabIndex = 5
        Me.txtHelpPlan.TabStop = False
        Me.txtHelpPlan.Text = resources.GetString("txtHelpPlan.Text")
        '
        'txtHelpNoon
        '
        Me.txtHelpNoon.AcceptsReturn = True
        Me.txtHelpNoon.BackColor = System.Drawing.SystemColors.Window
        Me.txtHelpNoon.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHelpNoon.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHelpNoon.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHelpNoon.Location = New System.Drawing.Point(0, 72)
        Me.txtHelpNoon.MaxLength = 0
        Me.txtHelpNoon.Multiline = True
        Me.txtHelpNoon.Name = "txtHelpNoon"
        Me.txtHelpNoon.ReadOnly = True
        Me.txtHelpNoon.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHelpNoon.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtHelpNoon.Size = New System.Drawing.Size(760, 505)
        Me.txtHelpNoon.TabIndex = 6
        Me.txtHelpNoon.TabStop = False
        Me.txtHelpNoon.Text = resources.GetString("txtHelpNoon.Text")
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(761, 575)
        Me.Controls.Add(Me.txtHelpCurrents)
        Me.Controls.Add(Me.cmdHelpCurrents)
        Me.Controls.Add(Me.txtHelpTides)
        Me.Controls.Add(Me.cmdHelpTides)
        Me.Controls.Add(Me.txtHelpTwoBearings)
        Me.Controls.Add(Me.cmdHelpTwoBearings)
        Me.Controls.Add(Me.txtHelpMoBoard)
        Me.Controls.Add(Me.cmdHelpMoBoard)
        Me.Controls.Add(Me.txtHelpYellow)
        Me.Controls.Add(Me.cmdHelpYellow)
        Me.Controls.Add(Me.txtHelpLength)
        Me.Controls.Add(Me.cmdHelpLength)
        Me.Controls.Add(Me.txtHelpTVMDC)
        Me.Controls.Add(Me.txtHelp60DST)
        Me.Controls.Add(Me.cmdHelpTVMDC)
        Me.Controls.Add(Me.cmdHelp60DST)
        Me.Controls.Add(Me.txtHelpInterpolate)
        Me.Controls.Add(Me.cmdHelpInterpolate)
        Me.Controls.Add(Me.txtHelpDistances)
        Me.Controls.Add(Me.cmdHelpDistances)
        Me.Controls.Add(Me.txtHelpCTS_SOA)
        Me.Controls.Add(Me.cmdHelpCTS_SOA)
        Me.Controls.Add(Me.txtHelpSailings)
        Me.Controls.Add(Me.cmdHelpSailings)
        Me.Controls.Add(Me.txtHelpArcTime)
        Me.Controls.Add(Me.cmdHelpArcTime)
        Me.Controls.Add(Me.txtHelpAveraging)
        Me.Controls.Add(Me.cmdHelpAveraging)
        Me.Controls.Add(Me.txtHelpLoCNASR)
        Me.Controls.Add(Me.cmdHelpLoCNASR)
        Me.Controls.Add(Me.cmdHelpFavorites)
        Me.Controls.Add(Me.cmdHelpNoon)
        Me.Controls.Add(Me.cmdHelpSRF)
        Me.Controls.Add(Me.cmdHelpPlan)
        Me.Controls.Add(Me.cmdHelpGeneral)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.txtHelpSRF)
        Me.Controls.Add(Me.txtHelpFavorites)
        Me.Controls.Add(Me.txtHelpGeneral)
        Me.Controls.Add(Me.txtHelpPlan)
        Me.Controls.Add(Me.txtHelpNoon)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(35, 42)
        Me.MaximizeBox = False
        Me.Name = "Form6"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Celestial Tools Help"
        Me.ResumeLayout(False)

    End Sub
#End Region
End Class