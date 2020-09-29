<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FormDistances
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
    Public WithEvents optVertSeaTop As System.Windows.Forms.RadioButton
    Public WithEvents optVertWaterSea As System.Windows.Forms.RadioButton
    Public WithEvents optVertWaterTop As System.Windows.Forms.RadioButton
    Public WithEvents optGeogRange As System.Windows.Forms.RadioButton
    Public WithEvents optDistHorizon As System.Windows.Forms.RadioButton
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents txtHsDeg As System.Windows.Forms.TextBox
    Public WithEvents txtHsMin As System.Windows.Forms.TextBox
    Public WithEvents txtHsSec As System.Windows.Forms.TextBox
    Public WithEvents txtIEmin As System.Windows.Forms.TextBox
    Public WithEvents cboIE As System.Windows.Forms.ComboBox
    Public WithEvents optHsDMm As System.Windows.Forms.RadioButton
    Public WithEvents optHsDMS As System.Windows.Forms.RadioButton
    Public WithEvents Framehs As System.Windows.Forms.Panel
    Public WithEvents txtIEdeg As System.Windows.Forms.TextBox
    Public WithEvents txtIESec As System.Windows.Forms.TextBox
    Public WithEvents cmdPrint As System.Windows.Forms.Button
    Public WithEvents cmdCalculate As System.Windows.Forms.Button
    Public WithEvents cboHO As System.Windows.Forms.ComboBox
    Public WithEvents txtHO As System.Windows.Forms.TextBox
    Public WithEvents cboHE As System.Windows.Forms.ComboBox
    Public WithEvents txtHE As System.Windows.Forms.TextBox
    Public WithEvents lblHsFormat As System.Windows.Forms.Label
    Public WithEvents lblHs As System.Windows.Forms.Label
    Public WithEvents lblHsDeg As System.Windows.Forms.Label
    Public WithEvents lblHsMin As System.Windows.Forms.Label
    Public WithEvents lblHsSec As System.Windows.Forms.Label
    Public WithEvents lblIE As System.Windows.Forms.Label
    Public WithEvents lblIEMin As System.Windows.Forms.Label
    Public WithEvents lblIEdeg As System.Windows.Forms.Label
    Public WithEvents lblIEsec As System.Windows.Forms.Label
    'Public WithEvents Line1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Public WithEvents lblHO As System.Windows.Forms.Label
    Public WithEvents lblHE As System.Windows.Forms.Label
    'Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDistances))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtHsDeg = New System.Windows.Forms.TextBox()
        Me.txtHsMin = New System.Windows.Forms.TextBox()
        Me.txtHsSec = New System.Windows.Forms.TextBox()
        Me.txtIEmin = New System.Windows.Forms.TextBox()
        Me.txtIEdeg = New System.Windows.Forms.TextBox()
        Me.txtIESec = New System.Windows.Forms.TextBox()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.txtHO = New System.Windows.Forms.TextBox()
        Me.txtHE = New System.Windows.Forms.TextBox()
        Me.lblHsFormat = New System.Windows.Forms.Label()
        Me.lblHs = New System.Windows.Forms.Label()
        Me.lblIE = New System.Windows.Forms.Label()
        Me.lblHE = New System.Windows.Forms.Label()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.optVertSeaTop = New System.Windows.Forms.RadioButton()
        Me.optVertWaterSea = New System.Windows.Forms.RadioButton()
        Me.optVertWaterTop = New System.Windows.Forms.RadioButton()
        Me.optGeogRange = New System.Windows.Forms.RadioButton()
        Me.optDistHorizon = New System.Windows.Forms.RadioButton()
        Me.cboIE = New System.Windows.Forms.ComboBox()
        Me.Framehs = New System.Windows.Forms.Panel()
        Me.optHsDMm = New System.Windows.Forms.RadioButton()
        Me.optHsDMS = New System.Windows.Forms.RadioButton()
        Me.cmdCalculate = New System.Windows.Forms.Button()
        Me.cboHO = New System.Windows.Forms.ComboBox()
        Me.cboHE = New System.Windows.Forms.ComboBox()
        Me.lblHsDeg = New System.Windows.Forms.Label()
        Me.lblHsMin = New System.Windows.Forms.Label()
        Me.lblHsSec = New System.Windows.Forms.Label()
        Me.lblIEMin = New System.Windows.Forms.Label()
        Me.lblIEdeg = New System.Windows.Forms.Label()
        Me.lblIEsec = New System.Windows.Forms.Label()
        Me.lblHO = New System.Windows.Forms.Label()
        Me.TextBoxFormDistances = New System.Windows.Forms.TextBox()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Frame1.SuspendLayout()
        Me.Framehs.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtHsDeg
        '
        Me.txtHsDeg.AcceptsReturn = True
        Me.txtHsDeg.BackColor = System.Drawing.SystemColors.Window
        Me.txtHsDeg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHsDeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHsDeg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHsDeg.Location = New System.Drawing.Point(405, 101)
        Me.txtHsDeg.MaxLength = 2
        Me.txtHsDeg.Name = "txtHsDeg"
        Me.txtHsDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHsDeg.Size = New System.Drawing.Size(25, 20)
        Me.txtHsDeg.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.txtHsDeg, "Range 0 to 89")
        Me.txtHsDeg.Visible = False
        '
        'txtHsMin
        '
        Me.txtHsMin.AcceptsReturn = True
        Me.txtHsMin.BackColor = System.Drawing.SystemColors.Window
        Me.txtHsMin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHsMin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHsMin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHsMin.Location = New System.Drawing.Point(437, 101)
        Me.txtHsMin.MaxLength = 4
        Me.txtHsMin.Name = "txtHsMin"
        Me.txtHsMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHsMin.Size = New System.Drawing.Size(33, 20)
        Me.txtHsMin.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.txtHsMin, "Range 0 to 59.9 (DM.m) or 59 (DMS)")
        Me.txtHsMin.Visible = False
        '
        'txtHsSec
        '
        Me.txtHsSec.AcceptsReturn = True
        Me.txtHsSec.BackColor = System.Drawing.SystemColors.Window
        Me.txtHsSec.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHsSec.Enabled = False
        Me.txtHsSec.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHsSec.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHsSec.Location = New System.Drawing.Point(477, 101)
        Me.txtHsSec.MaxLength = 2
        Me.txtHsSec.Name = "txtHsSec"
        Me.txtHsSec.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHsSec.Size = New System.Drawing.Size(33, 20)
        Me.txtHsSec.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.txtHsSec, "Range 0 to 59.")
        Me.txtHsSec.Visible = False
        '
        'txtIEmin
        '
        Me.txtIEmin.AcceptsReturn = True
        Me.txtIEmin.BackColor = System.Drawing.SystemColors.Window
        Me.txtIEmin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIEmin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIEmin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtIEmin.Location = New System.Drawing.Point(437, 123)
        Me.txtIEmin.MaxLength = 4
        Me.txtIEmin.Name = "txtIEmin"
        Me.txtIEmin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtIEmin.Size = New System.Drawing.Size(33, 20)
        Me.txtIEmin.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.txtIEmin, "Range 0 to 59.9 (DM.m) or 59 (DMS)")
        Me.txtIEmin.Visible = False
        '
        'txtIEdeg
        '
        Me.txtIEdeg.AcceptsReturn = True
        Me.txtIEdeg.BackColor = System.Drawing.SystemColors.Window
        Me.txtIEdeg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIEdeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIEdeg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtIEdeg.Location = New System.Drawing.Point(405, 123)
        Me.txtIEdeg.MaxLength = 1
        Me.txtIEdeg.Name = "txtIEdeg"
        Me.txtIEdeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtIEdeg.Size = New System.Drawing.Size(25, 20)
        Me.txtIEdeg.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.txtIEdeg, "Range 0 to 9")
        Me.txtIEdeg.Visible = False
        '
        'txtIESec
        '
        Me.txtIESec.AcceptsReturn = True
        Me.txtIESec.BackColor = System.Drawing.SystemColors.Window
        Me.txtIESec.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIESec.Enabled = False
        Me.txtIESec.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIESec.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtIESec.Location = New System.Drawing.Point(477, 123)
        Me.txtIESec.MaxLength = 2
        Me.txtIESec.Name = "txtIESec"
        Me.txtIESec.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtIESec.Size = New System.Drawing.Size(33, 20)
        Me.txtIESec.TabIndex = 14
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
        Me.cmdPrint.Location = New System.Drawing.Point(610, 0)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrint.Size = New System.Drawing.Size(21, 21)
        Me.cmdPrint.TabIndex = 19
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdPrint, "Print window")
        Me.cmdPrint.UseVisualStyleBackColor = False
        '
        'txtHO
        '
        Me.txtHO.AcceptsReturn = True
        Me.txtHO.BackColor = System.Drawing.SystemColors.Window
        Me.txtHO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHO.Location = New System.Drawing.Point(408, 47)
        Me.txtHO.MaxLength = 4
        Me.txtHO.Name = "txtHO"
        Me.txtHO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHO.Size = New System.Drawing.Size(33, 20)
        Me.txtHO.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.txtHO, "Max. 4 characters")
        Me.txtHO.Visible = False
        '
        'txtHE
        '
        Me.txtHE.AcceptsReturn = True
        Me.txtHE.BackColor = System.Drawing.SystemColors.Window
        Me.txtHE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHE.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHE.Location = New System.Drawing.Point(408, 22)
        Me.txtHE.MaxLength = 4
        Me.txtHE.Name = "txtHE"
        Me.txtHE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHE.Size = New System.Drawing.Size(33, 20)
        Me.txtHE.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.txtHE, "Max. 4 characters")
        '
        'lblHsFormat
        '
        Me.lblHsFormat.BackColor = System.Drawing.SystemColors.Window
        Me.lblHsFormat.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHsFormat.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHsFormat.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHsFormat.Location = New System.Drawing.Point(332, 79)
        Me.lblHsFormat.Name = "lblHsFormat"
        Me.lblHsFormat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblHsFormat.Size = New System.Drawing.Size(65, 13)
        Me.lblHsFormat.TabIndex = 31
        Me.lblHsFormat.Text = "hs/IE format"
        Me.lblHsFormat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.lblHsFormat, "Sextant Altitude/Index Error format")
        Me.lblHsFormat.Visible = False
        '
        'lblHs
        '
        Me.lblHs.BackColor = System.Drawing.SystemColors.Window
        Me.lblHs.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHs.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHs.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHs.Location = New System.Drawing.Point(253, 103)
        Me.lblHs.Name = "lblHs"
        Me.lblHs.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblHs.Size = New System.Drawing.Size(153, 17)
        Me.lblHs.TabIndex = 30
        Me.lblHs.Text = "Uncorrected Vertical Angle (hs)"
        Me.lblHs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.lblHs, "Sextant Altitude")
        Me.lblHs.Visible = False
        '
        'lblIE
        '
        Me.lblIE.BackColor = System.Drawing.SystemColors.Window
        Me.lblIE.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblIE.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIE.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblIE.Location = New System.Drawing.Point(325, 125)
        Me.lblIE.Name = "lblIE"
        Me.lblIE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblIE.Size = New System.Drawing.Size(81, 17)
        Me.lblIE.TabIndex = 26
        Me.lblIE.Text = "Index Error (IE)"
        Me.lblIE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.lblIE, "Index Error")
        Me.lblIE.Visible = False
        '
        'lblHE
        '
        Me.lblHE.BackColor = System.Drawing.SystemColors.Window
        Me.lblHE.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHE.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHE.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHE.Location = New System.Drawing.Point(332, 25)
        Me.lblHE.Name = "lblHE"
        Me.lblHE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblHE.Size = New System.Drawing.Size(75, 17)
        Me.lblHE.TabIndex = 16
        Me.lblHE.Text = "Height of Eye"
        Me.lblHE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.lblHE, "Height of Eye")
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Window
        Me.Frame1.Controls.Add(Me.optVertSeaTop)
        Me.Frame1.Controls.Add(Me.optVertWaterSea)
        Me.Frame1.Controls.Add(Me.optVertWaterTop)
        Me.Frame1.Controls.Add(Me.optGeogRange)
        Me.Frame1.Controls.Add(Me.optDistHorizon)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(17, 9)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(230, 241)
        Me.Frame1.TabIndex = 32
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Select function"
        '
        'optVertSeaTop
        '
        Me.optVertSeaTop.BackColor = System.Drawing.SystemColors.Window
        Me.optVertSeaTop.Cursor = System.Windows.Forms.Cursors.Default
        Me.optVertSeaTop.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optVertSeaTop.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optVertSeaTop.Location = New System.Drawing.Point(8, 168)
        Me.optVertSeaTop.Name = "optVertSeaTop"
        Me.optVertSeaTop.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optVertSeaTop.Size = New System.Drawing.Size(206, 57)
        Me.optVertSeaTop.TabIndex = 4
        Me.optVertSeaTop.TabStop = True
        Me.optVertSeaTop.Text = "Distance by Vertical Angle Measured Between Sea Horizon and Top of Object Beyond " &
    "Sea Horizon"
        Me.optVertSeaTop.UseVisualStyleBackColor = False
        '
        'optVertWaterSea
        '
        Me.optVertWaterSea.BackColor = System.Drawing.SystemColors.Window
        Me.optVertWaterSea.Cursor = System.Windows.Forms.Cursors.Default
        Me.optVertWaterSea.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optVertWaterSea.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optVertWaterSea.Location = New System.Drawing.Point(8, 115)
        Me.optVertWaterSea.Name = "optVertWaterSea"
        Me.optVertWaterSea.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optVertWaterSea.Size = New System.Drawing.Size(206, 50)
        Me.optVertWaterSea.TabIndex = 3
        Me.optVertWaterSea.TabStop = True
        Me.optVertWaterSea.Text = "Distance by Vertical Angle Measured Between Waterline at Object and Sea Horizon B" &
    "eyond Object"
        Me.optVertWaterSea.UseVisualStyleBackColor = False
        '
        'optVertWaterTop
        '
        Me.optVertWaterTop.BackColor = System.Drawing.SystemColors.Window
        Me.optVertWaterTop.Cursor = System.Windows.Forms.Cursors.Default
        Me.optVertWaterTop.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optVertWaterTop.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optVertWaterTop.Location = New System.Drawing.Point(8, 62)
        Me.optVertWaterTop.Name = "optVertWaterTop"
        Me.optVertWaterTop.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optVertWaterTop.Size = New System.Drawing.Size(206, 50)
        Me.optVertWaterTop.TabIndex = 2
        Me.optVertWaterTop.TabStop = True
        Me.optVertWaterTop.Text = "Distance by Vertical Angle Measured Between Waterline at Object and Top of Object" &
    ""
        Me.optVertWaterTop.UseVisualStyleBackColor = False
        '
        'optGeogRange
        '
        Me.optGeogRange.BackColor = System.Drawing.SystemColors.Window
        Me.optGeogRange.Cursor = System.Windows.Forms.Cursors.Default
        Me.optGeogRange.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optGeogRange.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optGeogRange.Location = New System.Drawing.Point(8, 39)
        Me.optGeogRange.Name = "optGeogRange"
        Me.optGeogRange.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optGeogRange.Size = New System.Drawing.Size(190, 17)
        Me.optGeogRange.TabIndex = 1
        Me.optGeogRange.TabStop = True
        Me.optGeogRange.Text = "Geographical Range of Visibility"
        Me.optGeogRange.UseVisualStyleBackColor = False
        '
        'optDistHorizon
        '
        Me.optDistHorizon.BackColor = System.Drawing.SystemColors.Window
        Me.optDistHorizon.Checked = True
        Me.optDistHorizon.Cursor = System.Windows.Forms.Cursors.Default
        Me.optDistHorizon.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optDistHorizon.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optDistHorizon.Location = New System.Drawing.Point(8, 16)
        Me.optDistHorizon.Name = "optDistHorizon"
        Me.optDistHorizon.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optDistHorizon.Size = New System.Drawing.Size(190, 17)
        Me.optDistHorizon.TabIndex = 0
        Me.optDistHorizon.TabStop = True
        Me.optDistHorizon.Text = "Distance of the Horizon"
        Me.optDistHorizon.UseVisualStyleBackColor = False
        '
        'cboIE
        '
        Me.cboIE.BackColor = System.Drawing.SystemColors.Window
        Me.cboIE.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboIE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboIE.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboIE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboIE.Items.AddRange(New Object() {"on the arc", "off the arc (val.)", "off the arc (rdg.)"})
        Me.cboIE.Location = New System.Drawing.Point(521, 123)
        Me.cboIE.Name = "cboIE"
        Me.cboIE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboIE.Size = New System.Drawing.Size(105, 22)
        Me.cboIE.TabIndex = 15
        Me.cboIE.Visible = False
        '
        'Framehs
        '
        Me.Framehs.BackColor = System.Drawing.SystemColors.Window
        Me.Framehs.Controls.Add(Me.optHsDMm)
        Me.Framehs.Controls.Add(Me.optHsDMS)
        Me.Framehs.Cursor = System.Windows.Forms.Cursors.Default
        Me.Framehs.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Framehs.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Framehs.Location = New System.Drawing.Point(406, 75)
        Me.Framehs.Name = "Framehs"
        Me.Framehs.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Framehs.Size = New System.Drawing.Size(121, 20)
        Me.Framehs.TabIndex = 20
        Me.Framehs.Text = "Frame2"
        '
        'optHsDMm
        '
        Me.optHsDMm.BackColor = System.Drawing.SystemColors.Window
        Me.optHsDMm.Checked = True
        Me.optHsDMm.Cursor = System.Windows.Forms.Cursors.Default
        Me.optHsDMm.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optHsDMm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optHsDMm.Location = New System.Drawing.Point(4, 2)
        Me.optHsDMm.Name = "optHsDMm"
        Me.optHsDMm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optHsDMm.Size = New System.Drawing.Size(49, 16)
        Me.optHsDMm.TabIndex = 22
        Me.optHsDMm.TabStop = True
        Me.optHsDMm.Text = "DM.m"
        Me.optHsDMm.UseVisualStyleBackColor = False
        Me.optHsDMm.Visible = False
        '
        'optHsDMS
        '
        Me.optHsDMS.BackColor = System.Drawing.SystemColors.Window
        Me.optHsDMS.Cursor = System.Windows.Forms.Cursors.Default
        Me.optHsDMS.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optHsDMS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optHsDMS.Location = New System.Drawing.Point(66, 2)
        Me.optHsDMS.Name = "optHsDMS"
        Me.optHsDMS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optHsDMS.Size = New System.Drawing.Size(49, 16)
        Me.optHsDMS.TabIndex = 21
        Me.optHsDMS.TabStop = True
        Me.optHsDMS.Text = "DMS"
        Me.optHsDMS.UseVisualStyleBackColor = False
        Me.optHsDMS.Visible = False
        '
        'cmdCalculate
        '
        Me.cmdCalculate.BackColor = System.Drawing.Color.Blue
        Me.cmdCalculate.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCalculate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCalculate.ForeColor = System.Drawing.Color.White
        Me.cmdCalculate.Location = New System.Drawing.Point(60, 256)
        Me.cmdCalculate.Name = "cmdCalculate"
        Me.cmdCalculate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCalculate.Size = New System.Drawing.Size(90, 25)
        Me.cmdCalculate.TabIndex = 18
        Me.cmdCalculate.Text = "&Calculate"
        Me.cmdCalculate.UseVisualStyleBackColor = False
        '
        'cboHO
        '
        Me.cboHO.BackColor = System.Drawing.SystemColors.Window
        Me.cboHO.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboHO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboHO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboHO.Items.AddRange(New Object() {"ft", "m "})
        Me.cboHO.Location = New System.Drawing.Point(456, 46)
        Me.cboHO.Name = "cboHO"
        Me.cboHO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboHO.Size = New System.Drawing.Size(41, 22)
        Me.cboHO.TabIndex = 8
        Me.cboHO.Visible = False
        '
        'cboHE
        '
        Me.cboHE.BackColor = System.Drawing.SystemColors.Window
        Me.cboHE.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboHE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHE.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboHE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboHE.Items.AddRange(New Object() {"ft", "in", "m ", "cm"})
        Me.cboHE.Location = New System.Drawing.Point(456, 22)
        Me.cboHE.Name = "cboHE"
        Me.cboHE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboHE.Size = New System.Drawing.Size(41, 22)
        Me.cboHE.TabIndex = 6
        '
        'lblHsDeg
        '
        Me.lblHsDeg.BackColor = System.Drawing.SystemColors.Window
        Me.lblHsDeg.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHsDeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHsDeg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHsDeg.Location = New System.Drawing.Point(430, 99)
        Me.lblHsDeg.Name = "lblHsDeg"
        Me.lblHsDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblHsDeg.Size = New System.Drawing.Size(9, 17)
        Me.lblHsDeg.TabIndex = 29
        Me.lblHsDeg.Text = "°"
        Me.lblHsDeg.Visible = False
        '
        'lblHsMin
        '
        Me.lblHsMin.BackColor = System.Drawing.SystemColors.Window
        Me.lblHsMin.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHsMin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHsMin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHsMin.Location = New System.Drawing.Point(470, 101)
        Me.lblHsMin.Name = "lblHsMin"
        Me.lblHsMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblHsMin.Size = New System.Drawing.Size(9, 17)
        Me.lblHsMin.TabIndex = 28
        Me.lblHsMin.Text = "'"
        Me.lblHsMin.Visible = False
        '
        'lblHsSec
        '
        Me.lblHsSec.BackColor = System.Drawing.SystemColors.Window
        Me.lblHsSec.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHsSec.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHsSec.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHsSec.Location = New System.Drawing.Point(510, 101)
        Me.lblHsSec.Name = "lblHsSec"
        Me.lblHsSec.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblHsSec.Size = New System.Drawing.Size(9, 17)
        Me.lblHsSec.TabIndex = 27
        Me.lblHsSec.Text = """"
        Me.lblHsSec.Visible = False
        '
        'lblIEMin
        '
        Me.lblIEMin.BackColor = System.Drawing.SystemColors.Window
        Me.lblIEMin.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblIEMin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIEMin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblIEMin.Location = New System.Drawing.Point(470, 123)
        Me.lblIEMin.Name = "lblIEMin"
        Me.lblIEMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblIEMin.Size = New System.Drawing.Size(9, 17)
        Me.lblIEMin.TabIndex = 25
        Me.lblIEMin.Text = "'"
        Me.lblIEMin.Visible = False
        '
        'lblIEdeg
        '
        Me.lblIEdeg.BackColor = System.Drawing.SystemColors.Window
        Me.lblIEdeg.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblIEdeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIEdeg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblIEdeg.Location = New System.Drawing.Point(430, 123)
        Me.lblIEdeg.Name = "lblIEdeg"
        Me.lblIEdeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblIEdeg.Size = New System.Drawing.Size(9, 17)
        Me.lblIEdeg.TabIndex = 24
        Me.lblIEdeg.Text = "°"
        Me.lblIEdeg.Visible = False
        '
        'lblIEsec
        '
        Me.lblIEsec.BackColor = System.Drawing.SystemColors.Window
        Me.lblIEsec.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblIEsec.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIEsec.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblIEsec.Location = New System.Drawing.Point(510, 123)
        Me.lblIEsec.Name = "lblIEsec"
        Me.lblIEsec.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblIEsec.Size = New System.Drawing.Size(9, 17)
        Me.lblIEsec.TabIndex = 23
        Me.lblIEsec.Text = """"
        Me.lblIEsec.Visible = False
        '
        'lblHO
        '
        Me.lblHO.BackColor = System.Drawing.SystemColors.Window
        Me.lblHO.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHO.Location = New System.Drawing.Point(320, 49)
        Me.lblHO.Name = "lblHO"
        Me.lblHO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblHO.Size = New System.Drawing.Size(86, 17)
        Me.lblHO.TabIndex = 17
        Me.lblHO.Text = "Height of Object"
        Me.lblHO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblHO.Visible = False
        '
        'TextBoxFormDistances
        '
        Me.TextBoxFormDistances.CausesValidation = False
        Me.TextBoxFormDistances.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxFormDistances.Location = New System.Drawing.Point(256, 151)
        Me.TextBoxFormDistances.Multiline = True
        Me.TextBoxFormDistances.Name = "TextBoxFormDistances"
        Me.TextBoxFormDistances.ReadOnly = True
        Me.TextBoxFormDistances.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxFormDistances.Size = New System.Drawing.Size(370, 98)
        Me.TextBoxFormDistances.TabIndex = 34
        Me.TextBoxFormDistances.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ExitBtn
        '
        Me.ExitBtn.BackColor = System.Drawing.Color.Red
        Me.ExitBtn.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ExitBtn.Location = New System.Drawing.Point(535, 256)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(90, 25)
        Me.ExitBtn.TabIndex = 35
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CelestialTools.My.Resources.Resources.ABC_white
        Me.PictureBox1.Location = New System.Drawing.Point(181, 256)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(316, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 102
        Me.PictureBox1.TabStop = False
        '
        'FormDistances
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(631, 315)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.TextBoxFormDistances)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.txtHsDeg)
        Me.Controls.Add(Me.txtHsMin)
        Me.Controls.Add(Me.txtHsSec)
        Me.Controls.Add(Me.txtIEmin)
        Me.Controls.Add(Me.cboIE)
        Me.Controls.Add(Me.Framehs)
        Me.Controls.Add(Me.txtIEdeg)
        Me.Controls.Add(Me.txtIESec)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdCalculate)
        Me.Controls.Add(Me.cboHO)
        Me.Controls.Add(Me.txtHO)
        Me.Controls.Add(Me.cboHE)
        Me.Controls.Add(Me.txtHE)
        Me.Controls.Add(Me.lblHsFormat)
        Me.Controls.Add(Me.lblHs)
        Me.Controls.Add(Me.lblHsDeg)
        Me.Controls.Add(Me.lblHsMin)
        Me.Controls.Add(Me.lblHsSec)
        Me.Controls.Add(Me.lblIE)
        Me.Controls.Add(Me.lblIEMin)
        Me.Controls.Add(Me.lblIEdeg)
        Me.Controls.Add(Me.lblIEsec)
        Me.Controls.Add(Me.lblHO)
        Me.Controls.Add(Me.lblHE)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(3, 435)
        Me.MaximizeBox = False
        Me.Name = "FormDistances"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Distances"
        Me.Frame1.ResumeLayout(False)
        Me.Framehs.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxFormDistances As System.Windows.Forms.TextBox
    Friend WithEvents ExitBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
#End Region
End Class