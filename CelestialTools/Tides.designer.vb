<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FormTides
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
    Public WithEvents cmdVertical As System.Windows.Forms.Button
    Public WithEvents optAltRule As System.Windows.Forms.RadioButton
    Public WithEvents optRule As System.Windows.Forms.RadioButton
    Public WithEvents optCalc As System.Windows.Forms.RadioButton
    Public WithEvents optTable3 As System.Windows.Forms.RadioButton
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents cmdClear As System.Windows.Forms.Button
    Public WithEvents cmdPrint As System.Windows.Forms.Button
    Public WithEvents cmdTides As System.Windows.Forms.Button
    Public WithEvents txtTab2HtLow As System.Windows.Forms.TextBox
    Public WithEvents txtTab2LowMin As System.Windows.Forms.TextBox
    Public WithEvents txtTab2LowHour As System.Windows.Forms.TextBox
    Public WithEvents txtTab2HtHigh As System.Windows.Forms.TextBox
    Public WithEvents txtTab2HighMin As System.Windows.Forms.TextBox
    Public WithEvents txtTab2HighHour As System.Windows.Forms.TextBox
    Public WithEvents txtSubStaNo As System.Windows.Forms.TextBox
    Public WithEvents txtTab2Diff As System.Windows.Forms.TextBox
    Public WithEvents txtHtLow As System.Windows.Forms.TextBox
    Public WithEvents txtHtHigh As System.Windows.Forms.TextBox
    Public WithEvents txtRefSta As System.Windows.Forms.TextBox
    Public WithEvents txtLocNo As System.Windows.Forms.TextBox
    Public WithEvents txtLocation As System.Windows.Forms.TextBox
    'Public WithEvents Line10 As Microsoft.VisualBasic.PowerPacks.LineShape
    'Public WithEvents Line9 As Microsoft.VisualBasic.PowerPacks.LineShape
    'Public WithEvents Line8 As Microsoft.VisualBasic.PowerPacks.LineShape
    'Public WithEvents Line7 As Microsoft.VisualBasic.PowerPacks.LineShape
    'Public WithEvents Line6 As Microsoft.VisualBasic.PowerPacks.LineShape
    'Public WithEvents Line5 As Microsoft.VisualBasic.PowerPacks.LineShape
    'Public WithEvents Line4 As Microsoft.VisualBasic.PowerPacks.LineShape
    'Public WithEvents Line3 As Microsoft.VisualBasic.PowerPacks.LineShape
    'Public WithEvents Line2 As Microsoft.VisualBasic.PowerPacks.LineShape
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
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents lblLocNumber As System.Windows.Forms.Label
    Public WithEvents lblLocation As System.Windows.Forms.Label
    'Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTides))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.txtTab2LowMin = New System.Windows.Forms.TextBox()
        Me.txtTab2HighMin = New System.Windows.Forms.TextBox()
        Me.cmdVertical = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.optAltRule = New System.Windows.Forms.RadioButton()
        Me.optRule = New System.Windows.Forms.RadioButton()
        Me.optCalc = New System.Windows.Forms.RadioButton()
        Me.optTable3 = New System.Windows.Forms.RadioButton()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdTides = New System.Windows.Forms.Button()
        Me.txtTab2HtLow = New System.Windows.Forms.TextBox()
        Me.txtTab2LowHour = New System.Windows.Forms.TextBox()
        Me.txtTab2HtHigh = New System.Windows.Forms.TextBox()
        Me.txtTab2HighHour = New System.Windows.Forms.TextBox()
        Me.txtSubStaNo = New System.Windows.Forms.TextBox()
        Me.txtTab2Diff = New System.Windows.Forms.TextBox()
        Me.txtHtLow = New System.Windows.Forms.TextBox()
        Me.txtHtHigh = New System.Windows.Forms.TextBox()
        Me.txtRefSta = New System.Windows.Forms.TextBox()
        Me.txtLocNo = New System.Windows.Forms.TextBox()
        Me.txtLocation = New System.Windows.Forms.TextBox()
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
        Me.lblLocNumber = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.Tides1Txt = New System.Windows.Forms.TextBox()
        Me.Tides2Txt = New System.Windows.Forms.TextBox()
        Me.Tides3Txt = New System.Windows.Forms.TextBox()
        Me.Tides4Txt = New System.Windows.Forms.RichTextBox()
        Me.Tides5Txt = New System.Windows.Forms.TextBox()
        Me.Tides7Txt = New System.Windows.Forms.TextBox()
        Me.Tides6Txt = New System.Windows.Forms.RichTextBox()
        Me.Tides8Txt = New System.Windows.Forms.TextBox()
        Me.Tides9Txt = New System.Windows.Forms.TextBox()
        Me.Tides10Txt = New System.Windows.Forms.RichTextBox()
        Me.Tides11Txt = New System.Windows.Forms.TextBox()
        Me.Tides12Txt = New System.Windows.Forms.TextBox()
        Me.Tides13Txt = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LinkNOAATideCurr = New System.Windows.Forms.LinkLabel()
        Me.DTTides = New System.Windows.Forms.DateTimePicker()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.DTTimeHigh = New System.Windows.Forms.DateTimePicker()
        Me.DTTimeLow = New System.Windows.Forms.DateTimePicker()
        Me.Frame1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrint.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.Location = New System.Drawing.Point(587, 0)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrint.Size = New System.Drawing.Size(21, 21)
        Me.cmdPrint.TabIndex = 42
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdPrint, "Print window")
        Me.cmdPrint.UseVisualStyleBackColor = False
        '
        'txtTab2LowMin
        '
        Me.txtTab2LowMin.AcceptsReturn = True
        Me.txtTab2LowMin.BackColor = System.Drawing.SystemColors.Window
        Me.txtTab2LowMin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTab2LowMin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTab2LowMin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTab2LowMin.Location = New System.Drawing.Point(520, 112)
        Me.txtTab2LowMin.MaxLength = 2
        Me.txtTab2LowMin.Name = "txtTab2LowMin"
        Me.txtTab2LowMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTab2LowMin.Size = New System.Drawing.Size(25, 20)
        Me.txtTab2LowMin.TabIndex = 37
        Me.ToolTip1.SetToolTip(Me.txtTab2LowMin, "Range 0 to 59")
        '
        'txtTab2HighMin
        '
        Me.txtTab2HighMin.AcceptsReturn = True
        Me.txtTab2HighMin.BackColor = System.Drawing.SystemColors.Window
        Me.txtTab2HighMin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTab2HighMin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTab2HighMin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTab2HighMin.Location = New System.Drawing.Point(392, 112)
        Me.txtTab2HighMin.MaxLength = 2
        Me.txtTab2HighMin.Name = "txtTab2HighMin"
        Me.txtTab2HighMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTab2HighMin.Size = New System.Drawing.Size(25, 20)
        Me.txtTab2HighMin.TabIndex = 32
        Me.ToolTip1.SetToolTip(Me.txtTab2HighMin, "Range 0 to 59")
        '
        'cmdVertical
        '
        Me.cmdVertical.BackColor = System.Drawing.SystemColors.Control
        Me.cmdVertical.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdVertical.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVertical.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdVertical.Location = New System.Drawing.Point(1, 382)
        Me.cmdVertical.Name = "cmdVertical"
        Me.cmdVertical.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdVertical.Size = New System.Drawing.Size(185, 25)
        Me.cmdVertical.TabIndex = 49
        Me.cmdVertical.Text = "&Vertical Clearances"
        Me.cmdVertical.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Window
        Me.Frame1.Controls.Add(Me.optAltRule)
        Me.Frame1.Controls.Add(Me.optRule)
        Me.Frame1.Controls.Add(Me.optCalc)
        Me.Frame1.Controls.Add(Me.optTable3)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(13, 23)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(468, 34)
        Me.Frame1.TabIndex = 44
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Use correction from"
        '
        'optAltRule
        '
        Me.optAltRule.BackColor = System.Drawing.SystemColors.Window
        Me.optAltRule.Cursor = System.Windows.Forms.Cursors.Default
        Me.optAltRule.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optAltRule.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optAltRule.Location = New System.Drawing.Point(350, 12)
        Me.optAltRule.Name = "optAltRule"
        Me.optAltRule.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optAltRule.Size = New System.Drawing.Size(110, 17)
        Me.optAltRule.TabIndex = 48
        Me.optAltRule.TabStop = True
        Me.optAltRule.Text = "Alt. Rule of 12ths"
        Me.optAltRule.UseVisualStyleBackColor = False
        '
        'optRule
        '
        Me.optRule.BackColor = System.Drawing.SystemColors.Window
        Me.optRule.Cursor = System.Windows.Forms.Cursors.Default
        Me.optRule.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optRule.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optRule.Location = New System.Drawing.Point(256, 11)
        Me.optRule.Name = "optRule"
        Me.optRule.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optRule.Size = New System.Drawing.Size(90, 17)
        Me.optRule.TabIndex = 47
        Me.optRule.TabStop = True
        Me.optRule.Text = "Rule of 12ths"
        Me.optRule.UseVisualStyleBackColor = False
        '
        'optCalc
        '
        Me.optCalc.BackColor = System.Drawing.SystemColors.Window
        Me.optCalc.Checked = True
        Me.optCalc.Cursor = System.Windows.Forms.Cursors.Default
        Me.optCalc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optCalc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optCalc.Location = New System.Drawing.Point(106, 11)
        Me.optCalc.Name = "optCalc"
        Me.optCalc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optCalc.Size = New System.Drawing.Size(80, 17)
        Me.optCalc.TabIndex = 46
        Me.optCalc.TabStop = True
        Me.optCalc.Text = "Calculation"
        Me.optCalc.UseVisualStyleBackColor = False
        '
        'optTable3
        '
        Me.optTable3.BackColor = System.Drawing.SystemColors.Window
        Me.optTable3.Cursor = System.Windows.Forms.Cursors.Default
        Me.optTable3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optTable3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optTable3.Location = New System.Drawing.Point(192, 11)
        Me.optTable3.Name = "optTable3"
        Me.optTable3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optTable3.Size = New System.Drawing.Size(60, 17)
        Me.optTable3.TabIndex = 45
        Me.optTable3.TabStop = True
        Me.optTable3.Text = "Table 3"
        Me.optTable3.UseVisualStyleBackColor = False
        '
        'cmdClear
        '
        Me.cmdClear.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClear.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClear.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClear.Location = New System.Drawing.Point(443, 382)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClear.Size = New System.Drawing.Size(65, 25)
        Me.cmdClear.TabIndex = 43
        Me.cmdClear.Text = "Clea&r"
        Me.cmdClear.UseVisualStyleBackColor = False
        '
        'cmdTides
        '
        Me.cmdTides.BackColor = System.Drawing.SystemColors.Control
        Me.cmdTides.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdTides.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTides.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdTides.Location = New System.Drawing.Point(277, 382)
        Me.cmdTides.Name = "cmdTides"
        Me.cmdTides.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdTides.Size = New System.Drawing.Size(60, 25)
        Me.cmdTides.TabIndex = 41
        Me.cmdTides.Text = "&Calculate"
        Me.cmdTides.UseVisualStyleBackColor = False
        '
        'txtTab2HtLow
        '
        Me.txtTab2HtLow.AcceptsReturn = True
        Me.txtTab2HtLow.BackColor = System.Drawing.SystemColors.Window
        Me.txtTab2HtLow.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTab2HtLow.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTab2HtLow.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTab2HtLow.Location = New System.Drawing.Point(560, 112)
        Me.txtTab2HtLow.MaxLength = 5
        Me.txtTab2HtLow.Name = "txtTab2HtLow"
        Me.txtTab2HtLow.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTab2HtLow.Size = New System.Drawing.Size(41, 20)
        Me.txtTab2HtLow.TabIndex = 40
        '
        'txtTab2LowHour
        '
        Me.txtTab2LowHour.AcceptsReturn = True
        Me.txtTab2LowHour.BackColor = System.Drawing.SystemColors.Window
        Me.txtTab2LowHour.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTab2LowHour.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTab2LowHour.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTab2LowHour.Location = New System.Drawing.Point(488, 112)
        Me.txtTab2LowHour.MaxLength = 2
        Me.txtTab2LowHour.Name = "txtTab2LowHour"
        Me.txtTab2LowHour.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTab2LowHour.Size = New System.Drawing.Size(25, 20)
        Me.txtTab2LowHour.TabIndex = 36
        '
        'txtTab2HtHigh
        '
        Me.txtTab2HtHigh.AcceptsReturn = True
        Me.txtTab2HtHigh.BackColor = System.Drawing.SystemColors.Window
        Me.txtTab2HtHigh.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTab2HtHigh.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTab2HtHigh.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTab2HtHigh.Location = New System.Drawing.Point(432, 112)
        Me.txtTab2HtHigh.MaxLength = 5
        Me.txtTab2HtHigh.Name = "txtTab2HtHigh"
        Me.txtTab2HtHigh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTab2HtHigh.Size = New System.Drawing.Size(41, 20)
        Me.txtTab2HtHigh.TabIndex = 35
        '
        'txtTab2HighHour
        '
        Me.txtTab2HighHour.AcceptsReturn = True
        Me.txtTab2HighHour.BackColor = System.Drawing.SystemColors.Window
        Me.txtTab2HighHour.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTab2HighHour.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTab2HighHour.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTab2HighHour.Location = New System.Drawing.Point(360, 112)
        Me.txtTab2HighHour.MaxLength = 2
        Me.txtTab2HighHour.Name = "txtTab2HighHour"
        Me.txtTab2HighHour.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTab2HighHour.Size = New System.Drawing.Size(25, 20)
        Me.txtTab2HighHour.TabIndex = 31
        '
        'txtSubStaNo
        '
        Me.txtSubStaNo.AcceptsReturn = True
        Me.txtSubStaNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtSubStaNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSubStaNo.Enabled = False
        Me.txtSubStaNo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubStaNo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSubStaNo.Location = New System.Drawing.Point(280, 112)
        Me.txtSubStaNo.MaxLength = 0
        Me.txtSubStaNo.Name = "txtSubStaNo"
        Me.txtSubStaNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSubStaNo.Size = New System.Drawing.Size(49, 20)
        Me.txtSubStaNo.TabIndex = 29
        '
        'txtTab2Diff
        '
        Me.txtTab2Diff.AcceptsReturn = True
        Me.txtTab2Diff.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtTab2Diff.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTab2Diff.Enabled = False
        Me.txtTab2Diff.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTab2Diff.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTab2Diff.Location = New System.Drawing.Point(96, 112)
        Me.txtTab2Diff.MaxLength = 0
        Me.txtTab2Diff.Name = "txtTab2Diff"
        Me.txtTab2Diff.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTab2Diff.Size = New System.Drawing.Size(161, 20)
        Me.txtTab2Diff.TabIndex = 27
        '
        'txtHtLow
        '
        Me.txtHtLow.AcceptsReturn = True
        Me.txtHtLow.BackColor = System.Drawing.SystemColors.Window
        Me.txtHtLow.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHtLow.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHtLow.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHtLow.Location = New System.Drawing.Point(560, 88)
        Me.txtHtLow.MaxLength = 5
        Me.txtHtLow.Name = "txtHtLow"
        Me.txtHtLow.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHtLow.Size = New System.Drawing.Size(41, 20)
        Me.txtHtLow.TabIndex = 25
        '
        'txtHtHigh
        '
        Me.txtHtHigh.AcceptsReturn = True
        Me.txtHtHigh.BackColor = System.Drawing.SystemColors.Window
        Me.txtHtHigh.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHtHigh.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHtHigh.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHtHigh.Location = New System.Drawing.Point(432, 88)
        Me.txtHtHigh.MaxLength = 5
        Me.txtHtHigh.Name = "txtHtHigh"
        Me.txtHtHigh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHtHigh.Size = New System.Drawing.Size(41, 20)
        Me.txtHtHigh.TabIndex = 23
        '
        'txtRefSta
        '
        Me.txtRefSta.AcceptsReturn = True
        Me.txtRefSta.BackColor = System.Drawing.SystemColors.Window
        Me.txtRefSta.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRefSta.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefSta.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtRefSta.Location = New System.Drawing.Point(96, 88)
        Me.txtRefSta.MaxLength = 0
        Me.txtRefSta.Name = "txtRefSta"
        Me.txtRefSta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtRefSta.Size = New System.Drawing.Size(249, 20)
        Me.txtRefSta.TabIndex = 21
        '
        'txtLocNo
        '
        Me.txtLocNo.AcceptsReturn = True
        Me.txtLocNo.BackColor = System.Drawing.SystemColors.Window
        Me.txtLocNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLocNo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocNo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLocNo.Location = New System.Drawing.Point(376, 3)
        Me.txtLocNo.MaxLength = 7
        Me.txtLocNo.Name = "txtLocNo"
        Me.txtLocNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLocNo.Size = New System.Drawing.Size(49, 20)
        Me.txtLocNo.TabIndex = 3
        '
        'txtLocation
        '
        Me.txtLocation.AcceptsReturn = True
        Me.txtLocation.BackColor = System.Drawing.SystemColors.Window
        Me.txtLocation.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLocation.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocation.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLocation.Location = New System.Drawing.Point(72, 2)
        Me.txtLocation.MaxLength = 0
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLocation.Size = New System.Drawing.Size(273, 20)
        Me.txtLocation.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Window
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(543, 112)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(12, 17)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "m"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Window
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(510, 112)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(9, 17)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "h"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Window
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(415, 112)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(12, 17)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "m"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Window
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(383, 112)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(9, 17)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "h"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Window
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(336, 112)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(9, 17)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = ")"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Window
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(264, 112)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(17, 17)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "(#"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Window
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(16, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(73, 17)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "+ Table 2 Diff:"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Window
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(16, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(65, 17)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Ref. Station:"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Window
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(562, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(35, 17)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Ht (ft)"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Window
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(435, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(35, 17)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Ht (ft)"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Window
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(488, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(70, 17)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Time (hhmm)"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Window
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(357, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(70, 17)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Time (hhmm)"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Window
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(528, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(33, 17)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "LOW"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(400, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(33, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "HIGH"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(426, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(145, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = ")  Substation # from Table 2"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLocNumber
        '
        Me.lblLocNumber.BackColor = System.Drawing.SystemColors.Window
        Me.lblLocNumber.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLocNumber.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocNumber.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLocNumber.Location = New System.Drawing.Point(360, 3)
        Me.lblLocNumber.Name = "lblLocNumber"
        Me.lblLocNumber.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLocNumber.Size = New System.Drawing.Size(17, 17)
        Me.lblLocNumber.TabIndex = 2
        Me.lblLocNumber.Text = "(#"
        Me.lblLocNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLocation
        '
        Me.lblLocation.BackColor = System.Drawing.SystemColors.Window
        Me.lblLocation.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLocation.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocation.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLocation.Location = New System.Drawing.Point(8, 3)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLocation.Size = New System.Drawing.Size(60, 17)
        Me.lblLocation.TabIndex = 0
        Me.lblLocation.Text = "LOCATION"
        '
        'ExitBtn
        '
        Me.ExitBtn.BackColor = System.Drawing.Color.Red
        Me.ExitBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ExitBtn.Location = New System.Drawing.Point(532, 384)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(75, 23)
        Me.ExitBtn.TabIndex = 51
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = False
        '
        'Tides1Txt
        '
        Me.Tides1Txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tides1Txt.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tides1Txt.Location = New System.Drawing.Point(1, 136)
        Me.Tides1Txt.Name = "Tides1Txt"
        Me.Tides1Txt.ReadOnly = True
        Me.Tides1Txt.Size = New System.Drawing.Size(350, 13)
        Me.Tides1Txt.TabIndex = 52
        '
        'Tides2Txt
        '
        Me.Tides2Txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tides2Txt.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tides2Txt.Location = New System.Drawing.Point(355, 136)
        Me.Tides2Txt.Name = "Tides2Txt"
        Me.Tides2Txt.ReadOnly = True
        Me.Tides2Txt.Size = New System.Drawing.Size(124, 13)
        Me.Tides2Txt.TabIndex = 53
        Me.Tides2Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tides3Txt
        '
        Me.Tides3Txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tides3Txt.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tides3Txt.Location = New System.Drawing.Point(482, 136)
        Me.Tides3Txt.Name = "Tides3Txt"
        Me.Tides3Txt.ReadOnly = True
        Me.Tides3Txt.Size = New System.Drawing.Size(124, 13)
        Me.Tides3Txt.TabIndex = 54
        Me.Tides3Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tides4Txt
        '
        Me.Tides4Txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tides4Txt.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tides4Txt.Location = New System.Drawing.Point(0, 154)
        Me.Tides4Txt.Name = "Tides4Txt"
        Me.Tides4Txt.ReadOnly = True
        Me.Tides4Txt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.Tides4Txt.Size = New System.Drawing.Size(478, 60)
        Me.Tides4Txt.TabIndex = 55
        Me.Tides4Txt.Text = ""
        '
        'Tides5Txt
        '
        Me.Tides5Txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tides5Txt.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tides5Txt.Location = New System.Drawing.Point(482, 154)
        Me.Tides5Txt.Multiline = True
        Me.Tides5Txt.Name = "Tides5Txt"
        Me.Tides5Txt.ReadOnly = True
        Me.Tides5Txt.Size = New System.Drawing.Size(124, 60)
        Me.Tides5Txt.TabIndex = 56
        Me.Tides5Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tides7Txt
        '
        Me.Tides7Txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tides7Txt.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tides7Txt.Location = New System.Drawing.Point(483, 217)
        Me.Tides7Txt.Multiline = True
        Me.Tides7Txt.Name = "Tides7Txt"
        Me.Tides7Txt.ReadOnly = True
        Me.Tides7Txt.Size = New System.Drawing.Size(124, 60)
        Me.Tides7Txt.TabIndex = 57
        Me.Tides7Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tides6Txt
        '
        Me.Tides6Txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tides6Txt.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tides6Txt.Location = New System.Drawing.Point(1, 218)
        Me.Tides6Txt.Name = "Tides6Txt"
        Me.Tides6Txt.ReadOnly = True
        Me.Tides6Txt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.Tides6Txt.Size = New System.Drawing.Size(478, 60)
        Me.Tides6Txt.TabIndex = 58
        Me.Tides6Txt.Text = ""
        '
        'Tides8Txt
        '
        Me.Tides8Txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tides8Txt.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tides8Txt.Location = New System.Drawing.Point(1, 282)
        Me.Tides8Txt.Name = "Tides8Txt"
        Me.Tides8Txt.ReadOnly = True
        Me.Tides8Txt.Size = New System.Drawing.Size(478, 13)
        Me.Tides8Txt.TabIndex = 59
        Me.Tides8Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tides9Txt
        '
        Me.Tides9Txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tides9Txt.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tides9Txt.Location = New System.Drawing.Point(483, 282)
        Me.Tides9Txt.Name = "Tides9Txt"
        Me.Tides9Txt.ReadOnly = True
        Me.Tides9Txt.Size = New System.Drawing.Size(124, 13)
        Me.Tides9Txt.TabIndex = 60
        Me.Tides9Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tides10Txt
        '
        Me.Tides10Txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tides10Txt.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tides10Txt.Location = New System.Drawing.Point(2, 300)
        Me.Tides10Txt.Name = "Tides10Txt"
        Me.Tides10Txt.ReadOnly = True
        Me.Tides10Txt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.Tides10Txt.Size = New System.Drawing.Size(478, 60)
        Me.Tides10Txt.TabIndex = 61
        Me.Tides10Txt.Text = ""
        '
        'Tides11Txt
        '
        Me.Tides11Txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tides11Txt.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tides11Txt.Location = New System.Drawing.Point(483, 300)
        Me.Tides11Txt.Multiline = True
        Me.Tides11Txt.Name = "Tides11Txt"
        Me.Tides11Txt.ReadOnly = True
        Me.Tides11Txt.Size = New System.Drawing.Size(124, 60)
        Me.Tides11Txt.TabIndex = 62
        Me.Tides11Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tides12Txt
        '
        Me.Tides12Txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tides12Txt.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tides12Txt.Location = New System.Drawing.Point(2, 366)
        Me.Tides12Txt.Name = "Tides12Txt"
        Me.Tides12Txt.ReadOnly = True
        Me.Tides12Txt.Size = New System.Drawing.Size(478, 13)
        Me.Tides12Txt.TabIndex = 63
        Me.Tides12Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tides13Txt
        '
        Me.Tides13Txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tides13Txt.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tides13Txt.Location = New System.Drawing.Point(482, 366)
        Me.Tides13Txt.Name = "Tides13Txt"
        Me.Tides13Txt.ReadOnly = True
        Me.Tides13Txt.Size = New System.Drawing.Size(124, 13)
        Me.Tides13Txt.TabIndex = 64
        Me.Tides13Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CelestialTools.My.Resources.Resources.ABC_white
        Me.PictureBox1.Location = New System.Drawing.Point(155, 413)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(316, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 102
        Me.PictureBox1.TabStop = False
        '
        'LinkNOAATideCurr
        '
        Me.LinkNOAATideCurr.AutoSize = True
        Me.LinkNOAATideCurr.Location = New System.Drawing.Point(151, 468)
        Me.LinkNOAATideCurr.Name = "LinkNOAATideCurr"
        Me.LinkNOAATideCurr.Size = New System.Drawing.Size(321, 26)
        Me.LinkNOAATideCurr.TabIndex = 103
        Me.LinkNOAATideCurr.TabStop = True
        Me.LinkNOAATideCurr.Text = "For additional information and online tools about tide predictions, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click here " &
    "to go to the NOAA Tides Predictions Web Page"
        Me.LinkNOAATideCurr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DTTides
        '
        Me.DTTides.CustomFormat = "MM / dd / yyyy HH:mm"
        Me.DTTides.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DTTides.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTTides.Location = New System.Drawing.Point(193, 61)
        Me.DTTides.Name = "DTTides"
        Me.DTTides.Size = New System.Drawing.Size(146, 21)
        Me.DTTides.TabIndex = 126
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.SystemColors.Window
        Me.lblDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDate.Location = New System.Drawing.Point(10, 60)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDate.Size = New System.Drawing.Size(174, 20)
        Me.lblDate.TabIndex = 125
        Me.lblDate.Text = "Desired Date and Time for Tides:"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DTTimeHigh
        '
        Me.DTTimeHigh.CustomFormat = "HH:mm"
        Me.DTTimeHigh.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTTimeHigh.Location = New System.Drawing.Point(360, 86)
        Me.DTTimeHigh.Name = "DTTimeHigh"
        Me.DTTimeHigh.ShowUpDown = True
        Me.DTTimeHigh.Size = New System.Drawing.Size(60, 21)
        Me.DTTimeHigh.TabIndex = 127
        '
        'DTTimeLow
        '
        Me.DTTimeLow.CustomFormat = "HH:mm"
        Me.DTTimeLow.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTTimeLow.Location = New System.Drawing.Point(490, 87)
        Me.DTTimeLow.Name = "DTTimeLow"
        Me.DTTimeLow.ShowUpDown = True
        Me.DTTimeLow.Size = New System.Drawing.Size(60, 21)
        Me.DTTimeLow.TabIndex = 128
        '
        'FormTides
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(608, 508)
        Me.Controls.Add(Me.DTTimeLow)
        Me.Controls.Add(Me.DTTimeHigh)
        Me.Controls.Add(Me.DTTides)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.LinkNOAATideCurr)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Tides13Txt)
        Me.Controls.Add(Me.Tides12Txt)
        Me.Controls.Add(Me.Tides11Txt)
        Me.Controls.Add(Me.Tides10Txt)
        Me.Controls.Add(Me.Tides9Txt)
        Me.Controls.Add(Me.Tides8Txt)
        Me.Controls.Add(Me.Tides6Txt)
        Me.Controls.Add(Me.Tides7Txt)
        Me.Controls.Add(Me.Tides5Txt)
        Me.Controls.Add(Me.Tides4Txt)
        Me.Controls.Add(Me.Tides3Txt)
        Me.Controls.Add(Me.Tides2Txt)
        Me.Controls.Add(Me.Tides1Txt)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.cmdVertical)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdTides)
        Me.Controls.Add(Me.txtTab2HtLow)
        Me.Controls.Add(Me.txtTab2LowMin)
        Me.Controls.Add(Me.txtTab2LowHour)
        Me.Controls.Add(Me.txtTab2HtHigh)
        Me.Controls.Add(Me.txtTab2HighMin)
        Me.Controls.Add(Me.txtTab2HighHour)
        Me.Controls.Add(Me.txtSubStaNo)
        Me.Controls.Add(Me.txtTab2Diff)
        Me.Controls.Add(Me.txtHtLow)
        Me.Controls.Add(Me.txtHtHigh)
        Me.Controls.Add(Me.txtRefSta)
        Me.Controls.Add(Me.txtLocNo)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblLocNumber)
        Me.Controls.Add(Me.lblLocation)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.Name = "FormTides"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Height of Tide at Desired Time"
        Me.Frame1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExitBtn As Button
    Friend WithEvents Tides1Txt As TextBox
    Friend WithEvents Tides2Txt As TextBox
    Friend WithEvents Tides3Txt As TextBox
    Friend WithEvents Tides4Txt As RichTextBox
    Friend WithEvents Tides5Txt As TextBox
    Friend WithEvents Tides7Txt As TextBox
    Friend WithEvents Tides6Txt As RichTextBox
    Friend WithEvents Tides8Txt As TextBox
    Friend WithEvents Tides9Txt As TextBox
    Friend WithEvents Tides10Txt As RichTextBox
    Friend WithEvents Tides11Txt As TextBox
    Friend WithEvents Tides12Txt As TextBox
    Friend WithEvents Tides13Txt As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LinkNOAATideCurr As LinkLabel
    Friend WithEvents DTTides As DateTimePicker
    Public WithEvents lblDate As Label
    Friend WithEvents DTTimeHigh As DateTimePicker
    Friend WithEvents DTTimeLow As DateTimePicker
#End Region
End Class