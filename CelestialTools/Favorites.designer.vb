<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form7
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
	Public WithEvents cboDsUnit As System.Windows.Forms.ComboBox
	Public WithEvents txtDsDist As System.Windows.Forms.TextBox
	Public WithEvents optHorizonNatural As System.Windows.Forms.RadioButton
	Public WithEvents optHorizonArtificial As System.Windows.Forms.RadioButton
	Public WithEvents optHorizonDipShort As System.Windows.Forms.RadioButton
	Public WithEvents cmdUse As System.Windows.Forms.Button
	Public WithEvents cmdSave As System.Windows.Forms.Button
	Public WithEvents cmdRemoveLocation As System.Windows.Forms.Button
	Public WithEvents txtMaxAz As System.Windows.Forms.TextBox
	Public WithEvents txtMinAz As System.Windows.Forms.TextBox
	Public WithEvents txtLMin As System.Windows.Forms.TextBox
	Public WithEvents cboL As System.Windows.Forms.ComboBox
	Public WithEvents txtLoDeg As System.Windows.Forms.TextBox
	Public WithEvents txtLoMin As System.Windows.Forms.TextBox
	Public WithEvents cboLo As System.Windows.Forms.ComboBox
	Public WithEvents txtLDeg As System.Windows.Forms.TextBox
	Public WithEvents txtNewName As System.Windows.Forms.TextBox
	Public WithEvents cmdAddLocation As System.Windows.Forms.Button
	Public WithEvents lstFavorites As System.Windows.Forms.ListBox
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents lblDsDist As System.Windows.Forms.Label
	Public WithEvents lblHorizon As System.Windows.Forms.Label
    'Public WithEvents Line1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Public WithEvents lblSelect As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents lblNewLocation As System.Windows.Forms.Label
	Public WithEvents lblMaxAzdeg As System.Windows.Forms.Label
	Public WithEvents lblMinAzDeg As System.Windows.Forms.Label
	Public WithEvents lblNewMaxAz As System.Windows.Forms.Label
	Public WithEvents lblNewMinAz As System.Windows.Forms.Label
	Public WithEvents lblNewLong As System.Windows.Forms.Label
	Public WithEvents lblNewLat As System.Windows.Forms.Label
	Public WithEvents lblLDeg As System.Windows.Forms.Label
	Public WithEvents lblLMin As System.Windows.Forms.Label
	Public WithEvents lblLoDeg As System.Windows.Forms.Label
	Public WithEvents lblLoMin As System.Windows.Forms.Label
	Public WithEvents lblNewName As System.Windows.Forms.Label
	Public WithEvents lblMaxAz As System.Windows.Forms.Label
	Public WithEvents lblMinAz As System.Windows.Forms.Label
	Public WithEvents lblLongitude As System.Windows.Forms.Label
	Public WithEvents lblLatitude As System.Windows.Forms.Label
	Public WithEvents lblName As System.Windows.Forms.Label
    'Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtDsDist = New System.Windows.Forms.TextBox()
        Me.txtMaxAz = New System.Windows.Forms.TextBox()
        Me.txtMinAz = New System.Windows.Forms.TextBox()
        Me.txtLMin = New System.Windows.Forms.TextBox()
        Me.txtLoDeg = New System.Windows.Forms.TextBox()
        Me.txtLoMin = New System.Windows.Forms.TextBox()
        Me.txtLDeg = New System.Windows.Forms.TextBox()
        Me.txtNewName = New System.Windows.Forms.TextBox()
        Me.lblDsDist = New System.Windows.Forms.Label()
        'Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        'Me.Line1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.cboDsUnit = New System.Windows.Forms.ComboBox()
        Me.optHorizonNatural = New System.Windows.Forms.RadioButton()
        Me.optHorizonArtificial = New System.Windows.Forms.RadioButton()
        Me.optHorizonDipShort = New System.Windows.Forms.RadioButton()
        Me.cmdUse = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdRemoveLocation = New System.Windows.Forms.Button()
        Me.cboL = New System.Windows.Forms.ComboBox()
        Me.cboLo = New System.Windows.Forms.ComboBox()
        Me.cmdAddLocation = New System.Windows.Forms.Button()
        Me.lstFavorites = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblHorizon = New System.Windows.Forms.Label()
        Me.lblSelect = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNewLocation = New System.Windows.Forms.Label()
        Me.lblMaxAzdeg = New System.Windows.Forms.Label()
        Me.lblMinAzDeg = New System.Windows.Forms.Label()
        Me.lblNewMaxAz = New System.Windows.Forms.Label()
        Me.lblNewMinAz = New System.Windows.Forms.Label()
        Me.lblNewLong = New System.Windows.Forms.Label()
        Me.lblNewLat = New System.Windows.Forms.Label()
        Me.lblLDeg = New System.Windows.Forms.Label()
        Me.lblLMin = New System.Windows.Forms.Label()
        Me.lblLoDeg = New System.Windows.Forms.Label()
        Me.lblLoMin = New System.Windows.Forms.Label()
        Me.lblNewName = New System.Windows.Forms.Label()
        Me.lblMaxAz = New System.Windows.Forms.Label()
        Me.lblMinAz = New System.Windows.Forms.Label()
        Me.lblLongitude = New System.Windows.Forms.Label()
        Me.lblLatitude = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.btnOpenLocList = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtDsDist
        '
        Me.txtDsDist.AcceptsReturn = True
        Me.txtDsDist.BackColor = System.Drawing.SystemColors.Window
        Me.txtDsDist.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDsDist.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDsDist.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDsDist.Location = New System.Drawing.Point(224, 321)
        Me.txtDsDist.MaxLength = 5
        Me.txtDsDist.Name = "txtDsDist"
        Me.txtDsDist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDsDist.Size = New System.Drawing.Size(41, 20)
        Me.txtDsDist.TabIndex = 38
        Me.ToolTip1.SetToolTip(Me.txtDsDist, "Limited to four characters")
        Me.txtDsDist.Visible = False
        '
        'txtMaxAz
        '
        Me.txtMaxAz.AcceptsReturn = True
        Me.txtMaxAz.BackColor = System.Drawing.SystemColors.Window
        Me.txtMaxAz.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMaxAz.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaxAz.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMaxAz.Location = New System.Drawing.Point(296, 272)
        Me.txtMaxAz.MaxLength = 3
        Me.txtMaxAz.Name = "txtMaxAz"
        Me.txtMaxAz.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMaxAz.Size = New System.Drawing.Size(33, 20)
        Me.txtMaxAz.TabIndex = 24
        Me.txtMaxAz.Text = "360"
        Me.ToolTip1.SetToolTip(Me.txtMaxAz, "Range 0 to 360")
        '
        'txtMinAz
        '
        Me.txtMinAz.AcceptsReturn = True
        Me.txtMinAz.BackColor = System.Drawing.SystemColors.Window
        Me.txtMinAz.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMinAz.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinAz.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMinAz.Location = New System.Drawing.Point(232, 272)
        Me.txtMinAz.MaxLength = 3
        Me.txtMinAz.Name = "txtMinAz"
        Me.txtMinAz.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMinAz.Size = New System.Drawing.Size(33, 20)
        Me.txtMinAz.TabIndex = 21
        Me.txtMinAz.Text = "0"
        Me.ToolTip1.SetToolTip(Me.txtMinAz, "Range 0 to 360")
        '
        'txtLMin
        '
        Me.txtLMin.AcceptsReturn = True
        Me.txtLMin.BackColor = System.Drawing.SystemColors.Window
        Me.txtLMin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLMin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLMin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLMin.Location = New System.Drawing.Point(256, 224)
        Me.txtLMin.MaxLength = 4
        Me.txtLMin.Name = "txtLMin"
        Me.txtLMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLMin.Size = New System.Drawing.Size(33, 20)
        Me.txtLMin.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.txtLMin, "Range 0 to 59.9")
        '
        'txtLoDeg
        '
        Me.txtLoDeg.AcceptsReturn = True
        Me.txtLoDeg.BackColor = System.Drawing.SystemColors.Window
        Me.txtLoDeg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLoDeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoDeg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLoDeg.Location = New System.Drawing.Point(216, 248)
        Me.txtLoDeg.MaxLength = 3
        Me.txtLoDeg.Name = "txtLoDeg"
        Me.txtLoDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLoDeg.Size = New System.Drawing.Size(33, 20)
        Me.txtLoDeg.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.txtLoDeg, "Range 0 to 180")
        '
        'txtLoMin
        '
        Me.txtLoMin.AcceptsReturn = True
        Me.txtLoMin.BackColor = System.Drawing.SystemColors.Window
        Me.txtLoMin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLoMin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoMin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLoMin.Location = New System.Drawing.Point(256, 248)
        Me.txtLoMin.MaxLength = 4
        Me.txtLoMin.Name = "txtLoMin"
        Me.txtLoMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLoMin.Size = New System.Drawing.Size(33, 20)
        Me.txtLoMin.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.txtLoMin, "Range 0 to 59.9")
        '
        'txtLDeg
        '
        Me.txtLDeg.AcceptsReturn = True
        Me.txtLDeg.BackColor = System.Drawing.SystemColors.Window
        Me.txtLDeg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLDeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLDeg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLDeg.Location = New System.Drawing.Point(224, 224)
        Me.txtLDeg.MaxLength = 2
        Me.txtLDeg.Name = "txtLDeg"
        Me.txtLDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLDeg.Size = New System.Drawing.Size(25, 20)
        Me.txtLDeg.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.txtLDeg, "Range 0 to 90")
        '
        'txtNewName
        '
        Me.txtNewName.AcceptsReturn = True
        Me.txtNewName.BackColor = System.Drawing.SystemColors.Window
        Me.txtNewName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNewName.Location = New System.Drawing.Point(200, 200)
        Me.txtNewName.MaxLength = 35
        Me.txtNewName.Name = "txtNewName"
        Me.txtNewName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNewName.Size = New System.Drawing.Size(393, 20)
        Me.txtNewName.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.txtNewName, "Max. 35 characters")
        '
        'lblDsDist
        '
        Me.lblDsDist.BackColor = System.Drawing.SystemColors.Control
        Me.lblDsDist.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDsDist.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDsDist.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDsDist.Location = New System.Drawing.Point(160, 321)
        Me.lblDsDist.Name = "lblDsDist"
        Me.lblDsDist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDsDist.Size = New System.Drawing.Size(57, 17)
        Me.lblDsDist.TabIndex = 37
        Me.lblDsDist.Text = "Ds distance"
        Me.ToolTip1.SetToolTip(Me.lblDsDist, "Distance to dip short horizon")
        Me.lblDsDist.Visible = False
        '
        'ShapeContainer1
        '
        'Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        'Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        'Me.ShapeContainer1.Name = "ShapeContainer1"
        'Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.Line1})
        'Me.ShapeContainer1.Size = New System.Drawing.Size(776, 382)
        'Me.ShapeContainer1.TabIndex = 42
        'Me.ShapeContainer1.TabStop = False
        '
        'Line1
        '
        'Me.Line1.BorderColor = System.Drawing.SystemColors.WindowText
        'Me.Line1.BorderWidth = 2
        'Me.Line1.Name = "Line1"
        'Me.Line1.X1 = 0
        'Me.Line1.X2 = 776
        'Me.Line1.Y1 = 176
        'Me.Line1.Y2 = 176
        '
        'cboDsUnit
        '
        Me.cboDsUnit.BackColor = System.Drawing.SystemColors.Window
        Me.cboDsUnit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboDsUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDsUnit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDsUnit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboDsUnit.Items.AddRange(New Object() {"feet", "yards", "meters", "statute miles", "nautical miles"})
        Me.cboDsUnit.Location = New System.Drawing.Point(272, 321)
        Me.cboDsUnit.Name = "cboDsUnit"
        Me.cboDsUnit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboDsUnit.Size = New System.Drawing.Size(89, 22)
        Me.cboDsUnit.TabIndex = 39
        Me.cboDsUnit.Visible = False
        '
        'optHorizonNatural
        '
        Me.optHorizonNatural.BackColor = System.Drawing.SystemColors.Control
        Me.optHorizonNatural.Checked = True
        Me.optHorizonNatural.Cursor = System.Windows.Forms.Cursors.Default
        Me.optHorizonNatural.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optHorizonNatural.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optHorizonNatural.Location = New System.Drawing.Point(216, 296)
        Me.optHorizonNatural.Name = "optHorizonNatural"
        Me.optHorizonNatural.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optHorizonNatural.Size = New System.Drawing.Size(65, 18)
        Me.optHorizonNatural.TabIndex = 35
        Me.optHorizonNatural.TabStop = True
        Me.optHorizonNatural.Text = "Natural"
        Me.optHorizonNatural.UseVisualStyleBackColor = False
        '
        'optHorizonArtificial
        '
        Me.optHorizonArtificial.BackColor = System.Drawing.SystemColors.Control
        Me.optHorizonArtificial.Cursor = System.Windows.Forms.Cursors.Default
        Me.optHorizonArtificial.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optHorizonArtificial.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optHorizonArtificial.Location = New System.Drawing.Point(284, 296)
        Me.optHorizonArtificial.Name = "optHorizonArtificial"
        Me.optHorizonArtificial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optHorizonArtificial.Size = New System.Drawing.Size(68, 18)
        Me.optHorizonArtificial.TabIndex = 34
        Me.optHorizonArtificial.TabStop = True
        Me.optHorizonArtificial.Text = "Artificial"
        Me.optHorizonArtificial.UseVisualStyleBackColor = False
        '
        'optHorizonDipShort
        '
        Me.optHorizonDipShort.BackColor = System.Drawing.SystemColors.Control
        Me.optHorizonDipShort.Cursor = System.Windows.Forms.Cursors.Default
        Me.optHorizonDipShort.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optHorizonDipShort.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optHorizonDipShort.Location = New System.Drawing.Point(354, 296)
        Me.optHorizonDipShort.Name = "optHorizonDipShort"
        Me.optHorizonDipShort.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optHorizonDipShort.Size = New System.Drawing.Size(65, 18)
        Me.optHorizonDipShort.TabIndex = 33
        Me.optHorizonDipShort.TabStop = True
        Me.optHorizonDipShort.Text = "Dip Short"
        Me.optHorizonDipShort.UseVisualStyleBackColor = False
        '
        'cmdUse
        '
        Me.cmdUse.BackColor = System.Drawing.SystemColors.Control
        Me.cmdUse.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdUse.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUse.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdUse.Location = New System.Drawing.Point(664, 144)
        Me.cmdUse.Name = "cmdUse"
        Me.cmdUse.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdUse.Size = New System.Drawing.Size(105, 25)
        Me.cmdUse.TabIndex = 32
        Me.cmdUse.Text = "&Use Location"
        Me.cmdUse.UseVisualStyleBackColor = False
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSave.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSave.Location = New System.Drawing.Point(123, 144)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSave.Size = New System.Drawing.Size(105, 25)
        Me.cmdSave.TabIndex = 28
        Me.cmdSave.Text = "&Save Location List"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'cmdRemoveLocation
        '
        Me.cmdRemoveLocation.BackColor = System.Drawing.SystemColors.Control
        Me.cmdRemoveLocation.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRemoveLocation.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRemoveLocation.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdRemoveLocation.Location = New System.Drawing.Point(553, 144)
        Me.cmdRemoveLocation.Name = "cmdRemoveLocation"
        Me.cmdRemoveLocation.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdRemoveLocation.Size = New System.Drawing.Size(105, 25)
        Me.cmdRemoveLocation.TabIndex = 27
        Me.cmdRemoveLocation.Text = "&Remove Location"
        Me.cmdRemoveLocation.UseVisualStyleBackColor = False
        '
        'cboL
        '
        Me.cboL.BackColor = System.Drawing.SystemColors.Window
        Me.cboL.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboL.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboL.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboL.Items.AddRange(New Object() {"N", "S"})
        Me.cboL.Location = New System.Drawing.Point(296, 224)
        Me.cboL.Name = "cboL"
        Me.cboL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboL.Size = New System.Drawing.Size(41, 22)
        Me.cboL.TabIndex = 13
        '
        'cboLo
        '
        Me.cboLo.BackColor = System.Drawing.SystemColors.Window
        Me.cboLo.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboLo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboLo.Items.AddRange(New Object() {"W", "E"})
        Me.cboLo.Location = New System.Drawing.Point(296, 248)
        Me.cboLo.Name = "cboLo"
        Me.cboLo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboLo.Size = New System.Drawing.Size(41, 22)
        Me.cboLo.TabIndex = 19
        '
        'cmdAddLocation
        '
        Me.cmdAddLocation.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAddLocation.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAddLocation.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddLocation.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAddLocation.Location = New System.Drawing.Point(328, 350)
        Me.cmdAddLocation.Name = "cmdAddLocation"
        Me.cmdAddLocation.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAddLocation.Size = New System.Drawing.Size(121, 25)
        Me.cmdAddLocation.TabIndex = 26
        Me.cmdAddLocation.Text = "&Add New Location"
        Me.cmdAddLocation.UseVisualStyleBackColor = False
        '
        'lstFavorites
        '
        Me.lstFavorites.BackColor = System.Drawing.SystemColors.Window
        Me.lstFavorites.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstFavorites.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstFavorites.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstFavorites.ItemHeight = 14
        Me.lstFavorites.Location = New System.Drawing.Point(8, 32)
        Me.lstFavorites.Name = "lstFavorites"
        Me.lstFavorites.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstFavorites.ScrollAlwaysVisible = True
        Me.lstFavorites.Size = New System.Drawing.Size(761, 102)
        Me.lstFavorites.Sorted = True
        Me.lstFavorites.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(616, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(55, 17)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Ds dist."
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(576, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(24, 17)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Hor"
        '
        'lblHorizon
        '
        Me.lblHorizon.BackColor = System.Drawing.SystemColors.Control
        Me.lblHorizon.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHorizon.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHorizon.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHorizon.Location = New System.Drawing.Point(160, 296)
        Me.lblHorizon.Name = "lblHorizon"
        Me.lblHorizon.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblHorizon.Size = New System.Drawing.Size(49, 17)
        Me.lblHorizon.TabIndex = 36
        Me.lblHorizon.Text = "Horizon"
        '
        'lblSelect
        '
        Me.lblSelect.BackColor = System.Drawing.SystemColors.Control
        Me.lblSelect.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSelect.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelect.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSelect.Location = New System.Drawing.Point(8, 0)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSelect.Size = New System.Drawing.Size(81, 17)
        Me.lblSelect.TabIndex = 31
        Me.lblSelect.Text = "Select location:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(16, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(105, 1)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Label2"
        '
        'lblNewLocation
        '
        Me.lblNewLocation.BackColor = System.Drawing.SystemColors.Control
        Me.lblNewLocation.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNewLocation.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewLocation.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNewLocation.Location = New System.Drawing.Point(200, 184)
        Me.lblNewLocation.Name = "lblNewLocation"
        Me.lblNewLocation.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNewLocation.Size = New System.Drawing.Size(80, 17)
        Me.lblNewLocation.TabIndex = 29
        Me.lblNewLocation.Text = "New Location:"
        '
        'lblMaxAzdeg
        '
        Me.lblMaxAzdeg.BackColor = System.Drawing.SystemColors.Control
        Me.lblMaxAzdeg.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMaxAzdeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxAzdeg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMaxAzdeg.Location = New System.Drawing.Point(329, 272)
        Me.lblMaxAzdeg.Name = "lblMaxAzdeg"
        Me.lblMaxAzdeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMaxAzdeg.Size = New System.Drawing.Size(9, 17)
        Me.lblMaxAzdeg.TabIndex = 25
        Me.lblMaxAzdeg.Text = "°"
        '
        'lblMinAzDeg
        '
        Me.lblMinAzDeg.BackColor = System.Drawing.SystemColors.Control
        Me.lblMinAzDeg.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMinAzDeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinAzDeg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMinAzDeg.Location = New System.Drawing.Point(265, 272)
        Me.lblMinAzDeg.Name = "lblMinAzDeg"
        Me.lblMinAzDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMinAzDeg.Size = New System.Drawing.Size(9, 17)
        Me.lblMinAzDeg.TabIndex = 22
        Me.lblMinAzDeg.Text = "°"
        '
        'lblNewMaxAz
        '
        Me.lblNewMaxAz.BackColor = System.Drawing.SystemColors.Control
        Me.lblNewMaxAz.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNewMaxAz.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewMaxAz.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNewMaxAz.Location = New System.Drawing.Point(275, 272)
        Me.lblNewMaxAz.Name = "lblNewMaxAz"
        Me.lblNewMaxAz.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNewMaxAz.Size = New System.Drawing.Size(18, 17)
        Me.lblNewMaxAz.TabIndex = 23
        Me.lblNewMaxAz.Text = "to"
        Me.lblNewMaxAz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNewMinAz
        '
        Me.lblNewMinAz.BackColor = System.Drawing.SystemColors.Control
        Me.lblNewMinAz.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNewMinAz.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewMinAz.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNewMinAz.Location = New System.Drawing.Point(160, 272)
        Me.lblNewMinAz.Name = "lblNewMinAz"
        Me.lblNewMinAz.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNewMinAz.Size = New System.Drawing.Size(68, 17)
        Me.lblNewMinAz.TabIndex = 20
        Me.lblNewMinAz.Text = "Azimuth from"
        '
        'lblNewLong
        '
        Me.lblNewLong.BackColor = System.Drawing.SystemColors.Control
        Me.lblNewLong.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNewLong.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewLong.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNewLong.Location = New System.Drawing.Point(160, 248)
        Me.lblNewLong.Name = "lblNewLong"
        Me.lblNewLong.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNewLong.Size = New System.Drawing.Size(55, 17)
        Me.lblNewLong.TabIndex = 14
        Me.lblNewLong.Text = "Longitude"
        '
        'lblNewLat
        '
        Me.lblNewLat.BackColor = System.Drawing.SystemColors.Control
        Me.lblNewLat.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNewLat.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewLat.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNewLat.Location = New System.Drawing.Point(160, 224)
        Me.lblNewLat.Name = "lblNewLat"
        Me.lblNewLat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNewLat.Size = New System.Drawing.Size(57, 17)
        Me.lblNewLat.TabIndex = 8
        Me.lblNewLat.Text = "Latitude"
        '
        'lblLDeg
        '
        Me.lblLDeg.BackColor = System.Drawing.SystemColors.Control
        Me.lblLDeg.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLDeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLDeg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLDeg.Location = New System.Drawing.Point(249, 224)
        Me.lblLDeg.Name = "lblLDeg"
        Me.lblLDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLDeg.Size = New System.Drawing.Size(9, 17)
        Me.lblLDeg.TabIndex = 10
        Me.lblLDeg.Text = "°"
        '
        'lblLMin
        '
        Me.lblLMin.BackColor = System.Drawing.SystemColors.Control
        Me.lblLMin.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLMin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLMin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLMin.Location = New System.Drawing.Point(289, 224)
        Me.lblLMin.Name = "lblLMin"
        Me.lblLMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLMin.Size = New System.Drawing.Size(9, 17)
        Me.lblLMin.TabIndex = 12
        Me.lblLMin.Text = "'"
        '
        'lblLoDeg
        '
        Me.lblLoDeg.BackColor = System.Drawing.SystemColors.Control
        Me.lblLoDeg.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLoDeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoDeg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLoDeg.Location = New System.Drawing.Point(249, 248)
        Me.lblLoDeg.Name = "lblLoDeg"
        Me.lblLoDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLoDeg.Size = New System.Drawing.Size(9, 17)
        Me.lblLoDeg.TabIndex = 16
        Me.lblLoDeg.Text = "°"
        '
        'lblLoMin
        '
        Me.lblLoMin.BackColor = System.Drawing.SystemColors.Control
        Me.lblLoMin.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLoMin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoMin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLoMin.Location = New System.Drawing.Point(289, 248)
        Me.lblLoMin.Name = "lblLoMin"
        Me.lblLoMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLoMin.Size = New System.Drawing.Size(9, 17)
        Me.lblLoMin.TabIndex = 18
        Me.lblLoMin.Text = "'"
        '
        'lblNewName
        '
        Me.lblNewName.BackColor = System.Drawing.SystemColors.Control
        Me.lblNewName.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNewName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNewName.Location = New System.Drawing.Point(160, 200)
        Me.lblNewName.Name = "lblNewName"
        Me.lblNewName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNewName.Size = New System.Drawing.Size(36, 17)
        Me.lblNewName.TabIndex = 6
        Me.lblNewName.Text = "Name"
        '
        'lblMaxAz
        '
        Me.lblMaxAz.BackColor = System.Drawing.SystemColors.Control
        Me.lblMaxAz.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMaxAz.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxAz.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMaxAz.Location = New System.Drawing.Point(520, 16)
        Me.lblMaxAz.Name = "lblMaxAz"
        Me.lblMaxAz.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMaxAz.Size = New System.Drawing.Size(38, 17)
        Me.lblMaxAz.TabIndex = 5
        Me.lblMaxAz.Text = "To Zn"
        '
        'lblMinAz
        '
        Me.lblMinAz.BackColor = System.Drawing.SystemColors.Control
        Me.lblMinAz.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMinAz.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinAz.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMinAz.Location = New System.Drawing.Point(448, 16)
        Me.lblMinAz.Name = "lblMinAz"
        Me.lblMinAz.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMinAz.Size = New System.Drawing.Size(55, 17)
        Me.lblMinAz.TabIndex = 4
        Me.lblMinAz.Text = "From Zn"
        '
        'lblLongitude
        '
        Me.lblLongitude.BackColor = System.Drawing.SystemColors.Control
        Me.lblLongitude.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLongitude.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLongitude.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLongitude.Location = New System.Drawing.Point(360, 16)
        Me.lblLongitude.Name = "lblLongitude"
        Me.lblLongitude.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLongitude.Size = New System.Drawing.Size(55, 17)
        Me.lblLongitude.TabIndex = 3
        Me.lblLongitude.Text = "Longitude"
        '
        'lblLatitude
        '
        Me.lblLatitude.BackColor = System.Drawing.SystemColors.Control
        Me.lblLatitude.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLatitude.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLatitude.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLatitude.Location = New System.Drawing.Point(280, 16)
        Me.lblLatitude.Name = "lblLatitude"
        Me.lblLatitude.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLatitude.Size = New System.Drawing.Size(50, 17)
        Me.lblLatitude.TabIndex = 2
        Me.lblLatitude.Text = "Latitude"
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.SystemColors.Control
        Me.lblName.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblName.Location = New System.Drawing.Point(16, 16)
        Me.lblName.Name = "lblName"
        Me.lblName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblName.Size = New System.Drawing.Size(38, 17)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name"
        '
        'ExitBtn
        '
        Me.ExitBtn.Location = New System.Drawing.Point(694, 351)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(75, 23)
        Me.ExitBtn.TabIndex = 43
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'btnOpenLocList
        '
        Me.btnOpenLocList.BackColor = System.Drawing.SystemColors.Control
        Me.btnOpenLocList.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnOpenLocList.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenLocList.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnOpenLocList.Location = New System.Drawing.Point(8, 144)
        Me.btnOpenLocList.Name = "btnOpenLocList"
        Me.btnOpenLocList.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnOpenLocList.Size = New System.Drawing.Size(105, 25)
        Me.btnOpenLocList.TabIndex = 44
        Me.btnOpenLocList.Text = "Open Location List"
        Me.btnOpenLocList.UseVisualStyleBackColor = False
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(776, 382)
        Me.Controls.Add(Me.btnOpenLocList)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.cboDsUnit)
        Me.Controls.Add(Me.txtDsDist)
        Me.Controls.Add(Me.optHorizonNatural)
        Me.Controls.Add(Me.optHorizonArtificial)
        Me.Controls.Add(Me.optHorizonDipShort)
        Me.Controls.Add(Me.cmdUse)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdRemoveLocation)
        Me.Controls.Add(Me.txtMaxAz)
        Me.Controls.Add(Me.txtMinAz)
        Me.Controls.Add(Me.txtLMin)
        Me.Controls.Add(Me.cboL)
        Me.Controls.Add(Me.txtLoDeg)
        Me.Controls.Add(Me.txtLoMin)
        Me.Controls.Add(Me.cboLo)
        Me.Controls.Add(Me.txtLDeg)
        Me.Controls.Add(Me.txtNewName)
        Me.Controls.Add(Me.cmdAddLocation)
        Me.Controls.Add(Me.lstFavorites)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDsDist)
        Me.Controls.Add(Me.lblHorizon)
        Me.Controls.Add(Me.lblSelect)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblNewLocation)
        Me.Controls.Add(Me.lblMaxAzdeg)
        Me.Controls.Add(Me.lblMinAzDeg)
        Me.Controls.Add(Me.lblNewMaxAz)
        Me.Controls.Add(Me.lblNewMinAz)
        Me.Controls.Add(Me.lblNewLong)
        Me.Controls.Add(Me.lblNewLat)
        Me.Controls.Add(Me.lblLDeg)
        Me.Controls.Add(Me.lblLMin)
        Me.Controls.Add(Me.lblLoDeg)
        Me.Controls.Add(Me.lblLoMin)
        Me.Controls.Add(Me.lblNewName)
        Me.Controls.Add(Me.lblMaxAz)
        Me.Controls.Add(Me.lblMinAz)
        Me.Controls.Add(Me.lblLongitude)
        Me.Controls.Add(Me.lblLatitude)
        Me.Controls.Add(Me.lblName)
        'Me.Controls.Add(Me.ShapeContainer1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form7"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Favorite Places"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExitBtn As Button
    Public WithEvents btnOpenLocList As Button
#End Region
End Class