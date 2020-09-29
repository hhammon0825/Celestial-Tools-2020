<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FormCTSSOA
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
    Public WithEvents optCMGSMG As System.Windows.Forms.RadioButton
    Public WithEvents optCTSSOA As System.Windows.Forms.RadioButton
    Public WithEvents Label15 As System.Windows.Forms.Label
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents cmdClear As System.Windows.Forms.Button
    Public WithEvents cboWind As System.Windows.Forms.ComboBox
    Public WithEvents txtDriftAngle As System.Windows.Forms.TextBox
    Public WithEvents cmdPrint As System.Windows.Forms.Button
    Public WithEvents cmdCalculate As System.Windows.Forms.Button
    Public WithEvents txtDrift As System.Windows.Forms.TextBox
    Public WithEvents txtSet As System.Windows.Forms.TextBox
    Public WithEvents txtCS As System.Windows.Forms.TextBox
    Public WithEvents txtDC As System.Windows.Forms.TextBox
    Public WithEvents Label14 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label13 As System.Windows.Forms.Label
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    'Public WithEvents Line4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Public WithEvents Label8 As System.Windows.Forms.Label
    'Public WithEvents Line3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Public WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents lblST As System.Windows.Forms.Label
    Public WithEvents lblDCT As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    'Public WithEvents Line2 As Microsoft.VisualBasic.PowerPacks.LineShape
    'Public WithEvents Line1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    'Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCTSSOA))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cboWind = New System.Windows.Forms.ComboBox()
        Me.txtDriftAngle = New System.Windows.Forms.TextBox()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.txtDrift = New System.Windows.Forms.TextBox()
        Me.txtSet = New System.Windows.Forms.TextBox()
        Me.txtCS = New System.Windows.Forms.TextBox()
        Me.txtDC = New System.Windows.Forms.TextBox()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.optCMGSMG = New System.Windows.Forms.RadioButton()
        Me.optCTSSOA = New System.Windows.Forms.RadioButton()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdCalculate = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblST = New System.Windows.Forms.Label()
        Me.lblDCT = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtWindCurrent = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Frame1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboWind
        '
        Me.cboWind.BackColor = System.Drawing.SystemColors.Window
        Me.cboWind.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboWind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboWind.Enabled = False
        Me.cboWind.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboWind.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboWind.Items.AddRange(New Object() {"Port", "Starboard", "N", "NE", "E", "SE", "S", "SW", "W", "NW"})
        Me.cboWind.Location = New System.Drawing.Point(408, 112)
        Me.cboWind.Name = "cboWind"
        Me.cboWind.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboWind.Size = New System.Drawing.Size(73, 22)
        Me.cboWind.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.cboWind, "If wind is nearly on the bow or stern, use Port or Starboard.")
        '
        'txtDriftAngle
        '
        Me.txtDriftAngle.AcceptsReturn = True
        Me.txtDriftAngle.BackColor = System.Drawing.SystemColors.Window
        Me.txtDriftAngle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDriftAngle.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDriftAngle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDriftAngle.Location = New System.Drawing.Point(408, 88)
        Me.txtDriftAngle.MaxLength = 3
        Me.txtDriftAngle.Name = "txtDriftAngle"
        Me.txtDriftAngle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDriftAngle.Size = New System.Drawing.Size(25, 20)
        Me.txtDriftAngle.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.txtDriftAngle, "Range 0 to 90")
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrint.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.Location = New System.Drawing.Point(474, 2)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrint.Size = New System.Drawing.Size(21, 21)
        Me.cmdPrint.TabIndex = 10
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdPrint, "Print window")
        Me.cmdPrint.UseVisualStyleBackColor = False
        '
        'txtDrift
        '
        Me.txtDrift.AcceptsReturn = True
        Me.txtDrift.BackColor = System.Drawing.SystemColors.Window
        Me.txtDrift.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDrift.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDrift.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDrift.Location = New System.Drawing.Point(248, 112)
        Me.txtDrift.MaxLength = 4
        Me.txtDrift.Name = "txtDrift"
        Me.txtDrift.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDrift.Size = New System.Drawing.Size(41, 20)
        Me.txtDrift.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.txtDrift, "Range 0 to 99.9")
        '
        'txtSet
        '
        Me.txtSet.AcceptsReturn = True
        Me.txtSet.BackColor = System.Drawing.SystemColors.Window
        Me.txtSet.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSet.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSet.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSet.Location = New System.Drawing.Point(248, 88)
        Me.txtSet.MaxLength = 4
        Me.txtSet.Name = "txtSet"
        Me.txtSet.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSet.Size = New System.Drawing.Size(41, 20)
        Me.txtSet.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.txtSet, "Range 0 to 359")
        '
        'txtCS
        '
        Me.txtCS.AcceptsReturn = True
        Me.txtCS.BackColor = System.Drawing.SystemColors.Window
        Me.txtCS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCS.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCS.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCS.Location = New System.Drawing.Point(104, 112)
        Me.txtCS.MaxLength = 4
        Me.txtCS.Name = "txtCS"
        Me.txtCS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCS.Size = New System.Drawing.Size(33, 20)
        Me.txtCS.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txtCS, "Range 0.1 to 99.9")
        '
        'txtDC
        '
        Me.txtDC.AcceptsReturn = True
        Me.txtDC.BackColor = System.Drawing.SystemColors.Window
        Me.txtDC.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDC.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDC.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDC.Location = New System.Drawing.Point(104, 88)
        Me.txtDC.MaxLength = 3
        Me.txtDC.Name = "txtDC"
        Me.txtDC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDC.Size = New System.Drawing.Size(33, 20)
        Me.txtDC.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.txtDC, "Range 0 to 359")
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Window
        Me.Frame1.Controls.Add(Me.optCMGSMG)
        Me.Frame1.Controls.Add(Me.optCTSSOA)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(4, 0)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(371, 61)
        Me.Frame1.TabIndex = 25
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Determine"
        '
        'optCMGSMG
        '
        Me.optCMGSMG.BackColor = System.Drawing.SystemColors.Window
        Me.optCMGSMG.Cursor = System.Windows.Forms.Cursors.Default
        Me.optCMGSMG.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optCMGSMG.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optCMGSMG.Location = New System.Drawing.Point(65, 32)
        Me.optCMGSMG.Name = "optCMGSMG"
        Me.optCMGSMG.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optCMGSMG.Size = New System.Drawing.Size(303, 25)
        Me.optCMGSMG.TabIndex = 1
        Me.optCMGSMG.TabStop = True
        Me.optCMGSMG.Text = "Course Made Good (CMG) and Speed Made Good (SMG)"
        Me.optCMGSMG.UseVisualStyleBackColor = False
        '
        'optCTSSOA
        '
        Me.optCTSSOA.BackColor = System.Drawing.SystemColors.Window
        Me.optCTSSOA.Checked = True
        Me.optCTSSOA.Cursor = System.Windows.Forms.Cursors.Default
        Me.optCTSSOA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optCTSSOA.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optCTSSOA.Location = New System.Drawing.Point(65, 8)
        Me.optCTSSOA.Name = "optCTSSOA"
        Me.optCTSSOA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optCTSSOA.Size = New System.Drawing.Size(303, 25)
        Me.optCTSSOA.TabIndex = 0
        Me.optCTSSOA.TabStop = True
        Me.optCTSSOA.Text = "Course to Steer (CTS) and Speed of Advance (SOA)"
        Me.optCTSSOA.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Window
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(379, 7)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(93, 53)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Adjusting " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for current " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and/or leeway"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdClear
        '
        Me.cmdClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdClear.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClear.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClear.Location = New System.Drawing.Point(5, 152)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClear.Size = New System.Drawing.Size(90, 25)
        Me.cmdClear.TabIndex = 9
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = False
        '
        'cmdCalculate
        '
        Me.cmdCalculate.BackColor = System.Drawing.Color.Blue
        Me.cmdCalculate.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCalculate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCalculate.ForeColor = System.Drawing.Color.White
        Me.cmdCalculate.Location = New System.Drawing.Point(405, 152)
        Me.cmdCalculate.Name = "cmdCalculate"
        Me.cmdCalculate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCalculate.Size = New System.Drawing.Size(90, 25)
        Me.cmdCalculate.TabIndex = 8
        Me.cmdCalculate.Text = "Calculate"
        Me.cmdCalculate.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Window
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(56, 64)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(80, 16)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Actual Values"
        Me.Label14.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(16, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(48, 20)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Heading"
        Me.Label1.Visible = False
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Window
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(344, 112)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(57, 17)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Wind from"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Window
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(344, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(57, 17)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Drift Angle"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Window
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(440, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(25, 17)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "°"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Window
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(392, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(50, 16)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Leeway"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Window
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(296, 112)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(33, 17)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "knots"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Window
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(144, 112)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(33, 17)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "knots"
        '
        'lblST
        '
        Me.lblST.BackColor = System.Drawing.SystemColors.Window
        Me.lblST.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblST.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblST.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblST.Location = New System.Drawing.Point(296, 88)
        Me.lblST.Name = "lblST"
        Me.lblST.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblST.Size = New System.Drawing.Size(25, 17)
        Me.lblST.TabIndex = 18
        Me.lblST.Text = "°"
        '
        'lblDCT
        '
        Me.lblDCT.BackColor = System.Drawing.SystemColors.Window
        Me.lblDCT.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDCT.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDCT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDCT.Location = New System.Drawing.Point(144, 88)
        Me.lblDCT.Name = "lblDCT"
        Me.lblDCT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDCT.Size = New System.Drawing.Size(25, 17)
        Me.lblDCT.TabIndex = 17
        Me.lblDCT.Text = "°"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Window
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(203, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(41, 17)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Avg. Drift"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Window
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(204, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(41, 17)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Set"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Window
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(16, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(73, 17)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Cruising Speed"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Window
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(16, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(81, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Intended Course"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Window
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(240, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(47, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Current"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(56, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(85, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Intended Values"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnExit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExit.Location = New System.Drawing.Point(405, 302)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnExit.Size = New System.Drawing.Size(90, 25)
        Me.btnExit.TabIndex = 29
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'txtWindCurrent
        '
        Me.txtWindCurrent.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWindCurrent.Location = New System.Drawing.Point(3, 183)
        Me.txtWindCurrent.Multiline = True
        Me.txtWindCurrent.Name = "txtWindCurrent"
        Me.txtWindCurrent.ReadOnly = True
        Me.txtWindCurrent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtWindCurrent.Size = New System.Drawing.Size(491, 111)
        Me.txtWindCurrent.TabIndex = 30
        Me.txtWindCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CelestialTools.My.Resources.Resources.ABC_white
        Me.PictureBox1.Location = New System.Drawing.Point(85, 302)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(316, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 102
        Me.PictureBox1.TabStop = False
        '
        'FormCTSSOA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(498, 357)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtWindCurrent)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cboWind)
        Me.Controls.Add(Me.txtDriftAngle)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdCalculate)
        Me.Controls.Add(Me.txtDrift)
        Me.Controls.Add(Me.txtSet)
        Me.Controls.Add(Me.txtCS)
        Me.Controls.Add(Me.txtDC)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblST)
        Me.Controls.Add(Me.lblDCT)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label15)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(454, 333)
        Me.MaximizeBox = False
        Me.Name = "FormCTSSOA"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Wind & Current"
        Me.Frame1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents btnExit As Button
    Friend WithEvents txtWindCurrent As TextBox
    Friend WithEvents PictureBox1 As PictureBox
#End Region
End Class