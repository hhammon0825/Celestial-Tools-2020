<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FormTVMDC
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
    Public WithEvents cmdPrint As System.Windows.Forms.Button
    Public WithEvents cmdClear As System.Windows.Forms.Button
    Public WithEvents txtEW As System.Windows.Forms.TextBox
    Public WithEvents txtCorrVar As System.Windows.Forms.TextBox
    Public WithEvents txtYI As System.Windows.Forms.TextBox
    Public WithEvents cboCV As System.Windows.Forms.ComboBox
    Public WithEvents cboD As System.Windows.Forms.ComboBox
    Public WithEvents cboV As System.Windows.Forms.ComboBox
    Public WithEvents cboIncDec As System.Windows.Forms.ComboBox
    Public WithEvents txtChange As System.Windows.Forms.TextBox
    Public WithEvents txtCY As System.Windows.Forms.TextBox
    Public WithEvents txtCVMin As System.Windows.Forms.TextBox
    Public WithEvents txtCVDeg As System.Windows.Forms.TextBox
    Public WithEvents txtCompass As System.Windows.Forms.TextBox
    Public WithEvents txtDeviation As System.Windows.Forms.TextBox
    Public WithEvents txtMagnetic As System.Windows.Forms.TextBox
    Public WithEvents txtVariation As System.Windows.Forms.TextBox
    Public WithEvents txtTrue As System.Windows.Forms.TextBox
    Public WithEvents Label15 As System.Windows.Forms.Label
    Public WithEvents Label14 As System.Windows.Forms.Label
    Public WithEvents Label13 As System.Windows.Forms.Label
    Public WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    'Public WithEvents Line1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents lblCompass As System.Windows.Forms.Label
    Public WithEvents lblDeviation As System.Windows.Forms.Label
    Public WithEvents lblMagnetic As System.Windows.Forms.Label
    Public WithEvents lblVariation As System.Windows.Forms.Label
    Public WithEvents lblTrue As System.Windows.Forms.Label
    'Public WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    'Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTVMDC))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.txtYI = New System.Windows.Forms.TextBox()
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.txtCY = New System.Windows.Forms.TextBox()
        Me.txtCVMin = New System.Windows.Forms.TextBox()
        Me.txtCVDeg = New System.Windows.Forms.TextBox()
        Me.txtCompass = New System.Windows.Forms.TextBox()
        Me.txtDeviation = New System.Windows.Forms.TextBox()
        Me.txtMagnetic = New System.Windows.Forms.TextBox()
        Me.txtVariation = New System.Windows.Forms.TextBox()
        Me.txtTrue = New System.Windows.Forms.TextBox()
        Me.btnCalcTVMDC = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.txtEW = New System.Windows.Forms.TextBox()
        Me.txtCorrVar = New System.Windows.Forms.TextBox()
        Me.cboCV = New System.Windows.Forms.ComboBox()
        Me.cboD = New System.Windows.Forms.ComboBox()
        Me.cboV = New System.Windows.Forms.ComboBox()
        Me.cboIncDec = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCompass = New System.Windows.Forms.Label()
        Me.lblDeviation = New System.Windows.Forms.Label()
        Me.lblMagnetic = New System.Windows.Forms.Label()
        Me.lblVariation = New System.Windows.Forms.Label()
        Me.lblTrue = New System.Windows.Forms.Label()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.chkDev = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DirectionLbl = New System.Windows.Forms.Label()
        Me.optDown = New System.Windows.Forms.RadioButton()
        Me.optUp = New System.Windows.Forms.RadioButton()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.CalcControl = New System.Windows.Forms.TabControl()
        Me.CalcTVMDC = New System.Windows.Forms.TabPage()
        Me.chkChartVar = New System.Windows.Forms.CheckBox()
        Me.CalcChartVar = New System.Windows.Forms.TabPage()
        Me.btnCalcChartVar = New System.Windows.Forms.Button()
        Me.btnClearChartVar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame1.SuspendLayout()
        Me.CalcControl.SuspendLayout()
        Me.CalcTVMDC.SuspendLayout()
        Me.CalcChartVar.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrint.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.Location = New System.Drawing.Point(491, 3)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrint.Size = New System.Drawing.Size(21, 21)
        Me.cmdPrint.TabIndex = 41
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdPrint, "Print window")
        Me.cmdPrint.UseVisualStyleBackColor = False
        '
        'txtYI
        '
        Me.txtYI.AcceptsReturn = True
        Me.txtYI.BackColor = System.Drawing.SystemColors.Window
        Me.txtYI.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtYI.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYI.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtYI.Location = New System.Drawing.Point(170, 132)
        Me.txtYI.MaxLength = 4
        Me.txtYI.Name = "txtYI"
        Me.txtYI.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtYI.Size = New System.Drawing.Size(33, 20)
        Me.txtYI.TabIndex = 31
        Me.ToolTip1.SetToolTip(Me.txtYI, "Limited to 4 digits")
        '
        'txtChange
        '
        Me.txtChange.AcceptsReturn = True
        Me.txtChange.BackColor = System.Drawing.SystemColors.Window
        Me.txtChange.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtChange.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChange.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtChange.Location = New System.Drawing.Point(214, 108)
        Me.txtChange.MaxLength = 0
        Me.txtChange.Name = "txtChange"
        Me.txtChange.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtChange.Size = New System.Drawing.Size(25, 20)
        Me.txtChange.TabIndex = 24
        Me.ToolTip1.SetToolTip(Me.txtChange, "Range 0 to 59")
        '
        'txtCY
        '
        Me.txtCY.AcceptsReturn = True
        Me.txtCY.BackColor = System.Drawing.SystemColors.Window
        Me.txtCY.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCY.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCY.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCY.Location = New System.Drawing.Point(170, 57)
        Me.txtCY.MaxLength = 4
        Me.txtCY.Name = "txtCY"
        Me.txtCY.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCY.Size = New System.Drawing.Size(33, 20)
        Me.txtCY.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.txtCY, "Limited to 4 digits")
        '
        'txtCVMin
        '
        Me.txtCVMin.AcceptsReturn = True
        Me.txtCVMin.BackColor = System.Drawing.SystemColors.Window
        Me.txtCVMin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCVMin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCVMin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCVMin.Location = New System.Drawing.Point(214, 84)
        Me.txtCVMin.MaxLength = 2
        Me.txtCVMin.Name = "txtCVMin"
        Me.txtCVMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCVMin.Size = New System.Drawing.Size(25, 20)
        Me.txtCVMin.TabIndex = 19
        Me.ToolTip1.SetToolTip(Me.txtCVMin, "Range 0 to 59")
        '
        'txtCVDeg
        '
        Me.txtCVDeg.AcceptsReturn = True
        Me.txtCVDeg.BackColor = System.Drawing.SystemColors.Window
        Me.txtCVDeg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCVDeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCVDeg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCVDeg.Location = New System.Drawing.Point(170, 83)
        Me.txtCVDeg.MaxLength = 2
        Me.txtCVDeg.Name = "txtCVDeg"
        Me.txtCVDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCVDeg.Size = New System.Drawing.Size(33, 20)
        Me.txtCVDeg.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.txtCVDeg, "Range 0 to 99")
        '
        'txtCompass
        '
        Me.txtCompass.AcceptsReturn = True
        Me.txtCompass.BackColor = System.Drawing.SystemColors.Window
        Me.txtCompass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCompass.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompass.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCompass.Location = New System.Drawing.Point(191, 183)
        Me.txtCompass.MaxLength = 3
        Me.txtCompass.Name = "txtCompass"
        Me.txtCompass.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCompass.Size = New System.Drawing.Size(33, 20)
        Me.txtCompass.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.txtCompass, "Range 0 to 359")
        '
        'txtDeviation
        '
        Me.txtDeviation.AcceptsReturn = True
        Me.txtDeviation.BackColor = System.Drawing.SystemColors.Window
        Me.txtDeviation.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDeviation.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeviation.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDeviation.Location = New System.Drawing.Point(191, 159)
        Me.txtDeviation.MaxLength = 1
        Me.txtDeviation.Name = "txtDeviation"
        Me.txtDeviation.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDeviation.Size = New System.Drawing.Size(33, 20)
        Me.txtDeviation.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.txtDeviation, "Range 0 to 9")
        '
        'txtMagnetic
        '
        Me.txtMagnetic.AcceptsReturn = True
        Me.txtMagnetic.BackColor = System.Drawing.SystemColors.Window
        Me.txtMagnetic.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMagnetic.Enabled = False
        Me.txtMagnetic.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMagnetic.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMagnetic.Location = New System.Drawing.Point(191, 135)
        Me.txtMagnetic.MaxLength = 3
        Me.txtMagnetic.Name = "txtMagnetic"
        Me.txtMagnetic.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMagnetic.Size = New System.Drawing.Size(33, 20)
        Me.txtMagnetic.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.txtMagnetic, "Range 0 to 359")
        '
        'txtVariation
        '
        Me.txtVariation.AcceptsReturn = True
        Me.txtVariation.BackColor = System.Drawing.SystemColors.Window
        Me.txtVariation.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVariation.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVariation.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtVariation.Location = New System.Drawing.Point(191, 111)
        Me.txtVariation.MaxLength = 2
        Me.txtVariation.Name = "txtVariation"
        Me.txtVariation.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtVariation.Size = New System.Drawing.Size(33, 20)
        Me.txtVariation.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.txtVariation, "Range 0 to 99")
        '
        'txtTrue
        '
        Me.txtTrue.AcceptsReturn = True
        Me.txtTrue.BackColor = System.Drawing.SystemColors.Window
        Me.txtTrue.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTrue.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTrue.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTrue.Location = New System.Drawing.Point(191, 87)
        Me.txtTrue.MaxLength = 3
        Me.txtTrue.Name = "txtTrue"
        Me.txtTrue.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTrue.Size = New System.Drawing.Size(33, 20)
        Me.txtTrue.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.txtTrue, "Range 0 to 359")
        '
        'btnCalcTVMDC
        '
        Me.btnCalcTVMDC.BackColor = System.Drawing.Color.Blue
        Me.btnCalcTVMDC.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCalcTVMDC.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcTVMDC.ForeColor = System.Drawing.Color.White
        Me.btnCalcTVMDC.Location = New System.Drawing.Point(138, 220)
        Me.btnCalcTVMDC.Name = "btnCalcTVMDC"
        Me.btnCalcTVMDC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCalcTVMDC.Size = New System.Drawing.Size(140, 25)
        Me.btnCalcTVMDC.TabIndex = 104
        Me.btnCalcTVMDC.Text = "Calculate TVMDC"
        Me.ToolTip1.SetToolTip(Me.btnCalcTVMDC, "You can click this button anytime" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to see the results of your data entered")
        Me.btnCalcTVMDC.UseVisualStyleBackColor = False
        '
        'cmdClear
        '
        Me.cmdClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdClear.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClear.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClear.Location = New System.Drawing.Point(138, 265)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClear.Size = New System.Drawing.Size(140, 25)
        Me.cmdClear.TabIndex = 40
        Me.cmdClear.Text = "Clear TVMDC Input Fields"
        Me.cmdClear.UseVisualStyleBackColor = False
        '
        'txtEW
        '
        Me.txtEW.AcceptsReturn = True
        Me.txtEW.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtEW.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEW.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEW.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtEW.Location = New System.Drawing.Point(328, 162)
        Me.txtEW.MaxLength = 0
        Me.txtEW.Name = "txtEW"
        Me.txtEW.ReadOnly = True
        Me.txtEW.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtEW.Size = New System.Drawing.Size(17, 20)
        Me.txtEW.TabIndex = 35
        '
        'txtCorrVar
        '
        Me.txtCorrVar.AcceptsReturn = True
        Me.txtCorrVar.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtCorrVar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCorrVar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorrVar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCorrVar.Location = New System.Drawing.Point(279, 162)
        Me.txtCorrVar.MaxLength = 0
        Me.txtCorrVar.Name = "txtCorrVar"
        Me.txtCorrVar.ReadOnly = True
        Me.txtCorrVar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCorrVar.Size = New System.Drawing.Size(33, 20)
        Me.txtCorrVar.TabIndex = 33
        '
        'cboCV
        '
        Me.cboCV.BackColor = System.Drawing.SystemColors.Window
        Me.cboCV.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboCV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCV.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCV.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboCV.Items.AddRange(New Object() {"W", "E"})
        Me.cboCV.Location = New System.Drawing.Point(249, 84)
        Me.cboCV.Name = "cboCV"
        Me.cboCV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboCV.Size = New System.Drawing.Size(41, 22)
        Me.cboCV.TabIndex = 29
        '
        'cboD
        '
        Me.cboD.BackColor = System.Drawing.SystemColors.Window
        Me.cboD.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboD.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboD.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboD.Items.AddRange(New Object() {"W", "E"})
        Me.cboD.Location = New System.Drawing.Point(234, 159)
        Me.cboD.Name = "cboD"
        Me.cboD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboD.Size = New System.Drawing.Size(41, 22)
        Me.cboD.TabIndex = 28
        '
        'cboV
        '
        Me.cboV.BackColor = System.Drawing.SystemColors.Window
        Me.cboV.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboV.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboV.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboV.Items.AddRange(New Object() {"W", "E"})
        Me.cboV.Location = New System.Drawing.Point(234, 111)
        Me.cboV.Name = "cboV"
        Me.cboV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboV.Size = New System.Drawing.Size(41, 22)
        Me.cboV.TabIndex = 27
        '
        'cboIncDec
        '
        Me.cboIncDec.BackColor = System.Drawing.SystemColors.Window
        Me.cboIncDec.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboIncDec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboIncDec.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboIncDec.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboIncDec.Items.AddRange(New Object() {"Increasing", "Decreasing"})
        Me.cboIncDec.Location = New System.Drawing.Point(249, 108)
        Me.cboIncDec.Name = "cboIncDec"
        Me.cboIncDec.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboIncDec.Size = New System.Drawing.Size(81, 22)
        Me.cboIncDec.TabIndex = 26
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Window
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(313, 160)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(9, 17)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = "°"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Window
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(85, 158)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(190, 28)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Variation Corrected to Year of Interest" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(rounded to whole degrees)"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Window
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(82, 132)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(90, 19)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Year of Interest"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Window
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(239, 108)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(9, 17)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "'"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Window
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(82, 108)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(81, 17)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Annual Change"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Window
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(85, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(80, 18)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Chart Year"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Window
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(239, 84)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(9, 17)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "'"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Window
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(204, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(9, 17)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "°"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Window
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(82, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(80, 17)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Chart Variation"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Window
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(114, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(200, 17)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Calculate Corrected Chart Variation"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Window
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(224, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(9, 17)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "°"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Window
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(224, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(9, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "°"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Window
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(224, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(9, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "°"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(224, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(9, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "°"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(224, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(9, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "°"
        '
        'lblCompass
        '
        Me.lblCompass.BackColor = System.Drawing.SystemColors.Window
        Me.lblCompass.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCompass.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompass.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCompass.Location = New System.Drawing.Point(135, 185)
        Me.lblCompass.Name = "lblCompass"
        Me.lblCompass.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCompass.Size = New System.Drawing.Size(53, 17)
        Me.lblCompass.TabIndex = 4
        Me.lblCompass.Text = "Compass"
        Me.lblCompass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDeviation
        '
        Me.lblDeviation.BackColor = System.Drawing.SystemColors.Window
        Me.lblDeviation.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDeviation.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeviation.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDeviation.Location = New System.Drawing.Point(129, 159)
        Me.lblDeviation.Name = "lblDeviation"
        Me.lblDeviation.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDeviation.Size = New System.Drawing.Size(66, 20)
        Me.lblDeviation.TabIndex = 3
        Me.lblDeviation.Text = "Deviation"
        Me.lblDeviation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMagnetic
        '
        Me.lblMagnetic.BackColor = System.Drawing.SystemColors.Window
        Me.lblMagnetic.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMagnetic.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMagnetic.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMagnetic.Location = New System.Drawing.Point(130, 135)
        Me.lblMagnetic.Name = "lblMagnetic"
        Me.lblMagnetic.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMagnetic.Size = New System.Drawing.Size(58, 20)
        Me.lblMagnetic.TabIndex = 2
        Me.lblMagnetic.Text = "Magnetic"
        Me.lblMagnetic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVariation
        '
        Me.lblVariation.BackColor = System.Drawing.SystemColors.Window
        Me.lblVariation.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblVariation.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVariation.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblVariation.Location = New System.Drawing.Point(136, 113)
        Me.lblVariation.Name = "lblVariation"
        Me.lblVariation.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblVariation.Size = New System.Drawing.Size(49, 17)
        Me.lblVariation.TabIndex = 1
        Me.lblVariation.Text = "Variation"
        Me.lblVariation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTrue
        '
        Me.lblTrue.BackColor = System.Drawing.SystemColors.Window
        Me.lblTrue.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTrue.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrue.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTrue.Location = New System.Drawing.Point(136, 87)
        Me.lblTrue.Name = "lblTrue"
        Me.lblTrue.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTrue.Size = New System.Drawing.Size(31, 20)
        Me.lblTrue.TabIndex = 0
        Me.lblTrue.Text = "True"
        Me.lblTrue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ExitBtn
        '
        Me.ExitBtn.BackColor = System.Drawing.Color.Red
        Me.ExitBtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExitBtn.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ExitBtn.Location = New System.Drawing.Point(441, 380)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ExitBtn.Size = New System.Drawing.Size(65, 25)
        Me.ExitBtn.TabIndex = 43
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = False
        '
        'chkDev
        '
        Me.chkDev.BackColor = System.Drawing.SystemColors.Window
        Me.chkDev.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkDev.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDev.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkDev.Location = New System.Drawing.Point(285, 158)
        Me.chkDev.Name = "chkDev"
        Me.chkDev.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkDev.Size = New System.Drawing.Size(160, 25)
        Me.chkDev.TabIndex = 45
        Me.chkDev.Text = "Use Saved Deviation Table"
        Me.chkDev.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CelestialTools.My.Resources.Resources.ABC_white
        Me.PictureBox1.Location = New System.Drawing.Point(110, 355)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(316, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 102
        Me.PictureBox1.TabStop = False
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.Window
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(123, 6)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(200, 22)
        Me.Label16.TabIndex = 103
        Me.Label16.Text = "Calculate TVMDC"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DirectionLbl
        '
        Me.DirectionLbl.BackColor = System.Drawing.SystemColors.Window
        Me.DirectionLbl.Cursor = System.Windows.Forms.Cursors.Default
        Me.DirectionLbl.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DirectionLbl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DirectionLbl.Location = New System.Drawing.Point(6, 8)
        Me.DirectionLbl.Name = "DirectionLbl"
        Me.DirectionLbl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DirectionLbl.Size = New System.Drawing.Size(60, 20)
        Me.DirectionLbl.TabIndex = 44
        Me.DirectionLbl.Text = "Direction"
        Me.DirectionLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'optDown
        '
        Me.optDown.BackColor = System.Drawing.SystemColors.Window
        Me.optDown.Checked = True
        Me.optDown.Cursor = System.Windows.Forms.Cursors.Default
        Me.optDown.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optDown.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optDown.Location = New System.Drawing.Point(70, 5)
        Me.optDown.Name = "optDown"
        Me.optDown.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optDown.Size = New System.Drawing.Size(136, 19)
        Me.optDown.TabIndex = 38
        Me.optDown.TabStop = True
        Me.optDown.Text = "DOWN / Calc Compass"
        Me.optDown.UseVisualStyleBackColor = False
        '
        'optUp
        '
        Me.optUp.BackColor = System.Drawing.SystemColors.Window
        Me.optUp.Cursor = System.Windows.Forms.Cursors.Default
        Me.optUp.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optUp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optUp.Location = New System.Drawing.Point(70, 25)
        Me.optUp.Name = "optUp"
        Me.optUp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optUp.Size = New System.Drawing.Size(122, 20)
        Me.optUp.TabIndex = 39
        Me.optUp.TabStop = True
        Me.optUp.Text = "UP / Calc True"
        Me.optUp.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Window
        Me.Frame1.Controls.Add(Me.optUp)
        Me.Frame1.Controls.Add(Me.optDown)
        Me.Frame1.Controls.Add(Me.DirectionLbl)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(114, 26)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(212, 55)
        Me.Frame1.TabIndex = 37
        Me.Frame1.TabStop = False
        Me.Frame1.Text = " "
        '
        'CalcControl
        '
        Me.CalcControl.Controls.Add(Me.CalcTVMDC)
        Me.CalcControl.Controls.Add(Me.CalcChartVar)
        Me.CalcControl.Location = New System.Drawing.Point(32, 12)
        Me.CalcControl.Name = "CalcControl"
        Me.CalcControl.SelectedIndex = 0
        Me.CalcControl.Size = New System.Drawing.Size(456, 337)
        Me.CalcControl.TabIndex = 104
        '
        'CalcTVMDC
        '
        Me.CalcTVMDC.Controls.Add(Me.chkChartVar)
        Me.CalcTVMDC.Controls.Add(Me.btnCalcTVMDC)
        Me.CalcTVMDC.Controls.Add(Me.txtDeviation)
        Me.CalcTVMDC.Controls.Add(Me.Label16)
        Me.CalcTVMDC.Controls.Add(Me.Frame1)
        Me.CalcTVMDC.Controls.Add(Me.lblTrue)
        Me.CalcTVMDC.Controls.Add(Me.chkDev)
        Me.CalcTVMDC.Controls.Add(Me.lblVariation)
        Me.CalcTVMDC.Controls.Add(Me.lblMagnetic)
        Me.CalcTVMDC.Controls.Add(Me.lblDeviation)
        Me.CalcTVMDC.Controls.Add(Me.cmdClear)
        Me.CalcTVMDC.Controls.Add(Me.lblCompass)
        Me.CalcTVMDC.Controls.Add(Me.Label1)
        Me.CalcTVMDC.Controls.Add(Me.Label2)
        Me.CalcTVMDC.Controls.Add(Me.Label3)
        Me.CalcTVMDC.Controls.Add(Me.Label4)
        Me.CalcTVMDC.Controls.Add(Me.cboD)
        Me.CalcTVMDC.Controls.Add(Me.Label5)
        Me.CalcTVMDC.Controls.Add(Me.cboV)
        Me.CalcTVMDC.Controls.Add(Me.txtTrue)
        Me.CalcTVMDC.Controls.Add(Me.txtVariation)
        Me.CalcTVMDC.Controls.Add(Me.txtMagnetic)
        Me.CalcTVMDC.Controls.Add(Me.txtCompass)
        Me.CalcTVMDC.Location = New System.Drawing.Point(4, 22)
        Me.CalcTVMDC.Name = "CalcTVMDC"
        Me.CalcTVMDC.Padding = New System.Windows.Forms.Padding(3)
        Me.CalcTVMDC.Size = New System.Drawing.Size(448, 311)
        Me.CalcTVMDC.TabIndex = 0
        Me.CalcTVMDC.Text = "Calculate TVMDC"
        Me.CalcTVMDC.UseVisualStyleBackColor = True
        '
        'chkChartVar
        '
        Me.chkChartVar.BackColor = System.Drawing.SystemColors.Window
        Me.chkChartVar.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkChartVar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkChartVar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkChartVar.Location = New System.Drawing.Point(285, 110)
        Me.chkChartVar.Name = "chkChartVar"
        Me.chkChartVar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkChartVar.Size = New System.Drawing.Size(151, 25)
        Me.chkChartVar.TabIndex = 105
        Me.chkChartVar.Text = "Use Calc'd Chart Variation"
        Me.chkChartVar.UseVisualStyleBackColor = False
        '
        'CalcChartVar
        '
        Me.CalcChartVar.Controls.Add(Me.btnCalcChartVar)
        Me.CalcChartVar.Controls.Add(Me.btnClearChartVar)
        Me.CalcChartVar.Controls.Add(Me.Label6)
        Me.CalcChartVar.Controls.Add(Me.Label7)
        Me.CalcChartVar.Controls.Add(Me.Label8)
        Me.CalcChartVar.Controls.Add(Me.Label9)
        Me.CalcChartVar.Controls.Add(Me.txtEW)
        Me.CalcChartVar.Controls.Add(Me.Label10)
        Me.CalcChartVar.Controls.Add(Me.txtCorrVar)
        Me.CalcChartVar.Controls.Add(Me.Label11)
        Me.CalcChartVar.Controls.Add(Me.txtYI)
        Me.CalcChartVar.Controls.Add(Me.Label12)
        Me.CalcChartVar.Controls.Add(Me.cboCV)
        Me.CalcChartVar.Controls.Add(Me.Label13)
        Me.CalcChartVar.Controls.Add(Me.cboIncDec)
        Me.CalcChartVar.Controls.Add(Me.Label14)
        Me.CalcChartVar.Controls.Add(Me.txtChange)
        Me.CalcChartVar.Controls.Add(Me.Label15)
        Me.CalcChartVar.Controls.Add(Me.txtCY)
        Me.CalcChartVar.Controls.Add(Me.txtCVDeg)
        Me.CalcChartVar.Controls.Add(Me.txtCVMin)
        Me.CalcChartVar.Location = New System.Drawing.Point(4, 22)
        Me.CalcChartVar.Name = "CalcChartVar"
        Me.CalcChartVar.Padding = New System.Windows.Forms.Padding(3)
        Me.CalcChartVar.Size = New System.Drawing.Size(448, 311)
        Me.CalcChartVar.TabIndex = 1
        Me.CalcChartVar.Text = "Calculate Chart Variation"
        Me.CalcChartVar.UseVisualStyleBackColor = True
        '
        'btnCalcChartVar
        '
        Me.btnCalcChartVar.BackColor = System.Drawing.Color.Blue
        Me.btnCalcChartVar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCalcChartVar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcChartVar.ForeColor = System.Drawing.Color.White
        Me.btnCalcChartVar.Location = New System.Drawing.Point(150, 212)
        Me.btnCalcChartVar.Name = "btnCalcChartVar"
        Me.btnCalcChartVar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCalcChartVar.Size = New System.Drawing.Size(140, 25)
        Me.btnCalcChartVar.TabIndex = 106
        Me.btnCalcChartVar.Text = "Calculate Chart Variation"
        Me.btnCalcChartVar.UseVisualStyleBackColor = False
        '
        'btnClearChartVar
        '
        Me.btnClearChartVar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnClearChartVar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnClearChartVar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearChartVar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClearChartVar.Location = New System.Drawing.Point(150, 257)
        Me.btnClearChartVar.Name = "btnClearChartVar"
        Me.btnClearChartVar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnClearChartVar.Size = New System.Drawing.Size(140, 25)
        Me.btnClearChartVar.TabIndex = 105
        Me.btnClearChartVar.Text = "Clear Chart Var Fields"
        Me.btnClearChartVar.UseVisualStyleBackColor = False
        '
        'FormTVMDC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(524, 426)
        Me.Controls.Add(Me.CalcControl)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.cmdPrint)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(3, 29)
        Me.MaximizeBox = False
        Me.Name = "FormTVMDC"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TVMDC"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        Me.CalcControl.ResumeLayout(False)
        Me.CalcTVMDC.ResumeLayout(False)
        Me.CalcTVMDC.PerformLayout()
        Me.CalcChartVar.ResumeLayout(False)
        Me.CalcChartVar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents ExitBtn As Button
    Public WithEvents chkDev As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Public WithEvents Label16 As Label
    Public WithEvents DirectionLbl As Label
    Public WithEvents optDown As RadioButton
    Public WithEvents optUp As RadioButton
    Public WithEvents Frame1 As GroupBox
    Friend WithEvents CalcControl As TabControl
    Friend WithEvents CalcTVMDC As TabPage
    Friend WithEvents CalcChartVar As TabPage
    Public WithEvents btnCalcTVMDC As Button
    Public WithEvents btnCalcChartVar As Button
    Public WithEvents btnClearChartVar As Button
    Public WithEvents chkChartVar As CheckBox
#End Region
End Class