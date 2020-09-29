<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FormArcTime
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
    Public WithEvents txtLoMin As System.Windows.Forms.TextBox
    Public WithEvents cboLo As System.Windows.Forms.ComboBox
    Public WithEvents txtLoDeg As System.Windows.Forms.TextBox
    Public WithEvents optZTtoLMT As System.Windows.Forms.RadioButton
    Public WithEvents optLMTtoZT As System.Windows.Forms.RadioButton
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents cmdPrint As System.Windows.Forms.Button
    Public WithEvents cmdConvert As System.Windows.Forms.Button
    Public WithEvents txtDeg As System.Windows.Forms.TextBox
    Public WithEvents txtMin As System.Windows.Forms.TextBox
    Public WithEvents optTimeToArc As System.Windows.Forms.RadioButton
    Public WithEvents optArcToTime As System.Windows.Forms.RadioButton
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents lblZT As System.Windows.Forms.Label
    Public WithEvents lblLMT As System.Windows.Forms.Label
    Public WithEvents lblLoMin As System.Windows.Forms.Label
    Public WithEvents lblLoDeg As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents lblArc As System.Windows.Forms.Label
    Public WithEvents lblDeg As System.Windows.Forms.Label
    Public WithEvents lblMin As System.Windows.Forms.Label
    Public WithEvents lblTime As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormArcTime))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtLoMin = New System.Windows.Forms.TextBox()
        Me.txtLoDeg = New System.Windows.Forms.TextBox()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.txtDeg = New System.Windows.Forms.TextBox()
        Me.txtMin = New System.Windows.Forms.TextBox()
        Me.lblArc = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.cboLo = New System.Windows.Forms.ComboBox()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.optZTtoLMT = New System.Windows.Forms.RadioButton()
        Me.optLMTtoZT = New System.Windows.Forms.RadioButton()
        Me.cmdConvert = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.optTimeToArc = New System.Windows.Forms.RadioButton()
        Me.optArcToTime = New System.Windows.Forms.RadioButton()
        Me.lblZT = New System.Windows.Forms.Label()
        Me.lblLMT = New System.Windows.Forms.Label()
        Me.lblLoMin = New System.Windows.Forms.Label()
        Me.lblLoDeg = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDeg = New System.Windows.Forms.Label()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.txtArcTime = New System.Windows.Forms.TextBox()
        Me.txtLMTZT = New System.Windows.Forms.TextBox()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.ArcTime = New System.Windows.Forms.TabPage()
        Me.DTTime = New System.Windows.Forms.DateTimePicker()
        Me.LMTZT = New System.Windows.Forms.TabPage()
        Me.DTLMT = New System.Windows.Forms.DateTimePicker()
        Me.Frame2.SuspendLayout()
        Me.Frame1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.ArcTime.SuspendLayout()
        Me.LMTZT.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtLoMin
        '
        Me.txtLoMin.AcceptsReturn = True
        Me.txtLoMin.BackColor = System.Drawing.SystemColors.Window
        Me.txtLoMin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLoMin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoMin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLoMin.Location = New System.Drawing.Point(216, 71)
        Me.txtLoMin.MaxLength = 4
        Me.txtLoMin.Name = "txtLoMin"
        Me.txtLoMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLoMin.Size = New System.Drawing.Size(33, 20)
        Me.txtLoMin.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.txtLoMin, "Range 0 to 59.9")
        '
        'txtLoDeg
        '
        Me.txtLoDeg.AcceptsReturn = True
        Me.txtLoDeg.BackColor = System.Drawing.SystemColors.Window
        Me.txtLoDeg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLoDeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoDeg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLoDeg.Location = New System.Drawing.Point(173, 71)
        Me.txtLoDeg.MaxLength = 3
        Me.txtLoDeg.Name = "txtLoDeg"
        Me.txtLoDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLoDeg.Size = New System.Drawing.Size(33, 20)
        Me.txtLoDeg.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.txtLoDeg, "Range 0 to 180")
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrint.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.Location = New System.Drawing.Point(440, 0)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrint.Size = New System.Drawing.Size(21, 21)
        Me.cmdPrint.TabIndex = 23
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdPrint, "Print window")
        Me.cmdPrint.UseVisualStyleBackColor = False
        '
        'txtDeg
        '
        Me.txtDeg.AcceptsReturn = True
        Me.txtDeg.BackColor = System.Drawing.SystemColors.Window
        Me.txtDeg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDeg.Location = New System.Drawing.Point(198, 66)
        Me.txtDeg.MaxLength = 3
        Me.txtDeg.Name = "txtDeg"
        Me.txtDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDeg.Size = New System.Drawing.Size(33, 20)
        Me.txtDeg.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txtDeg, "Range 0 to 359")
        '
        'txtMin
        '
        Me.txtMin.AcceptsReturn = True
        Me.txtMin.BackColor = System.Drawing.SystemColors.Window
        Me.txtMin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMin.Location = New System.Drawing.Point(244, 66)
        Me.txtMin.MaxLength = 4
        Me.txtMin.Name = "txtMin"
        Me.txtMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMin.Size = New System.Drawing.Size(33, 20)
        Me.txtMin.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.txtMin, "Range 0 to 59.9")
        '
        'lblArc
        '
        Me.lblArc.BackColor = System.Drawing.SystemColors.Window
        Me.lblArc.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblArc.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblArc.Location = New System.Drawing.Point(155, 66)
        Me.lblArc.Name = "lblArc"
        Me.lblArc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblArc.Size = New System.Drawing.Size(26, 22)
        Me.lblArc.TabIndex = 9
        Me.lblArc.Text = "Arc"
        Me.lblArc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblArc, "Sextant Altitude")
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.SystemColors.Window
        Me.lblTime.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTime.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTime.Location = New System.Drawing.Point(108, 92)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTime.Size = New System.Drawing.Size(89, 20)
        Me.lblTime.TabIndex = 6
        Me.lblTime.Text = "Time (hh:mm:ss)"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblTime, "Watch Time")
        Me.lblTime.Visible = False
        '
        'cboLo
        '
        Me.cboLo.BackColor = System.Drawing.SystemColors.Window
        Me.cboLo.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboLo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboLo.Items.AddRange(New Object() {"W", "E"})
        Me.cboLo.Location = New System.Drawing.Point(258, 70)
        Me.cboLo.Name = "cboLo"
        Me.cboLo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboLo.Size = New System.Drawing.Size(41, 22)
        Me.cboLo.TabIndex = 17
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Window
        Me.Frame2.Controls.Add(Me.optZTtoLMT)
        Me.Frame2.Controls.Add(Me.optLMTtoZT)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(128, 23)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(185, 41)
        Me.Frame2.TabIndex = 10
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Convert"
        '
        'optZTtoLMT
        '
        Me.optZTtoLMT.BackColor = System.Drawing.SystemColors.Window
        Me.optZTtoLMT.Cursor = System.Windows.Forms.Cursors.Default
        Me.optZTtoLMT.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optZTtoLMT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optZTtoLMT.Location = New System.Drawing.Point(96, 16)
        Me.optZTtoLMT.Name = "optZTtoLMT"
        Me.optZTtoLMT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optZTtoLMT.Size = New System.Drawing.Size(73, 17)
        Me.optZTtoLMT.TabIndex = 12
        Me.optZTtoLMT.TabStop = True
        Me.optZTtoLMT.Text = "ZT to LMT"
        Me.optZTtoLMT.UseVisualStyleBackColor = False
        '
        'optLMTtoZT
        '
        Me.optLMTtoZT.BackColor = System.Drawing.SystemColors.Window
        Me.optLMTtoZT.Checked = True
        Me.optLMTtoZT.Cursor = System.Windows.Forms.Cursors.Default
        Me.optLMTtoZT.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optLMTtoZT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optLMTtoZT.Location = New System.Drawing.Point(8, 16)
        Me.optLMTtoZT.Name = "optLMTtoZT"
        Me.optLMTtoZT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optLMTtoZT.Size = New System.Drawing.Size(73, 17)
        Me.optLMTtoZT.TabIndex = 11
        Me.optLMTtoZT.TabStop = True
        Me.optLMTtoZT.Text = "LMT to ZT"
        Me.optLMTtoZT.UseVisualStyleBackColor = False
        '
        'cmdConvert
        '
        Me.cmdConvert.BackColor = System.Drawing.SystemColors.Control
        Me.cmdConvert.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdConvert.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConvert.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdConvert.Location = New System.Drawing.Point(186, 241)
        Me.cmdConvert.Name = "cmdConvert"
        Me.cmdConvert.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdConvert.Size = New System.Drawing.Size(92, 25)
        Me.cmdConvert.TabIndex = 22
        Me.cmdConvert.Text = "&Convert"
        Me.cmdConvert.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Window
        Me.Frame1.Controls.Add(Me.optTimeToArc)
        Me.Frame1.Controls.Add(Me.optArcToTime)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(113, 18)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(185, 41)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Convert"
        '
        'optTimeToArc
        '
        Me.optTimeToArc.BackColor = System.Drawing.SystemColors.Window
        Me.optTimeToArc.Cursor = System.Windows.Forms.Cursors.Default
        Me.optTimeToArc.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optTimeToArc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optTimeToArc.Location = New System.Drawing.Point(96, 16)
        Me.optTimeToArc.Name = "optTimeToArc"
        Me.optTimeToArc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optTimeToArc.Size = New System.Drawing.Size(81, 17)
        Me.optTimeToArc.TabIndex = 2
        Me.optTimeToArc.TabStop = True
        Me.optTimeToArc.Text = "Time to Arc"
        Me.optTimeToArc.UseVisualStyleBackColor = False
        '
        'optArcToTime
        '
        Me.optArcToTime.BackColor = System.Drawing.SystemColors.Window
        Me.optArcToTime.Checked = True
        Me.optArcToTime.Cursor = System.Windows.Forms.Cursors.Default
        Me.optArcToTime.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optArcToTime.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optArcToTime.Location = New System.Drawing.Point(8, 16)
        Me.optArcToTime.Name = "optArcToTime"
        Me.optArcToTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optArcToTime.Size = New System.Drawing.Size(81, 17)
        Me.optArcToTime.TabIndex = 1
        Me.optArcToTime.TabStop = True
        Me.optArcToTime.Text = "Arc to Time"
        Me.optArcToTime.UseVisualStyleBackColor = False
        '
        'lblZT
        '
        Me.lblZT.BackColor = System.Drawing.SystemColors.Window
        Me.lblZT.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblZT.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblZT.Location = New System.Drawing.Point(147, 98)
        Me.lblZT.Name = "lblZT"
        Me.lblZT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblZT.Size = New System.Drawing.Size(90, 17)
        Me.lblZT.TabIndex = 21
        Me.lblZT.Text = "ZT (hh:mm:ss)"
        Me.lblZT.Visible = False
        '
        'lblLMT
        '
        Me.lblLMT.BackColor = System.Drawing.SystemColors.Window
        Me.lblLMT.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLMT.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLMT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLMT.Location = New System.Drawing.Point(147, 98)
        Me.lblLMT.Name = "lblLMT"
        Me.lblLMT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLMT.Size = New System.Drawing.Size(90, 17)
        Me.lblLMT.TabIndex = 20
        Me.lblLMT.Text = "LMT (hh:mm:ss)"
        Me.lblLMT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLoMin
        '
        Me.lblLoMin.BackColor = System.Drawing.SystemColors.Window
        Me.lblLoMin.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLoMin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoMin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLoMin.Location = New System.Drawing.Point(249, 71)
        Me.lblLoMin.Name = "lblLoMin"
        Me.lblLoMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLoMin.Size = New System.Drawing.Size(9, 17)
        Me.lblLoMin.TabIndex = 18
        Me.lblLoMin.Text = "'"
        '
        'lblLoDeg
        '
        Me.lblLoDeg.BackColor = System.Drawing.SystemColors.Window
        Me.lblLoDeg.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLoDeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoDeg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLoDeg.Location = New System.Drawing.Point(207, 71)
        Me.lblLoDeg.Name = "lblLoDeg"
        Me.lblLoDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLoDeg.Size = New System.Drawing.Size(9, 17)
        Me.lblLoDeg.TabIndex = 16
        Me.lblLoDeg.Text = "°"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(144, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(26, 22)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Lo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDeg
        '
        Me.lblDeg.BackColor = System.Drawing.SystemColors.Window
        Me.lblDeg.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDeg.Location = New System.Drawing.Point(231, 66)
        Me.lblDeg.Name = "lblDeg"
        Me.lblDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDeg.Size = New System.Drawing.Size(9, 17)
        Me.lblDeg.TabIndex = 8
        Me.lblDeg.Text = "°"
        '
        'lblMin
        '
        Me.lblMin.BackColor = System.Drawing.SystemColors.Window
        Me.lblMin.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMin.Location = New System.Drawing.Point(279, 68)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMin.Size = New System.Drawing.Size(9, 17)
        Me.lblMin.TabIndex = 7
        Me.lblMin.Text = "'"
        '
        'txtArcTime
        '
        Me.txtArcTime.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArcTime.Location = New System.Drawing.Point(103, 116)
        Me.txtArcTime.Multiline = True
        Me.txtArcTime.Name = "txtArcTime"
        Me.txtArcTime.ReadOnly = True
        Me.txtArcTime.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtArcTime.Size = New System.Drawing.Size(226, 45)
        Me.txtArcTime.TabIndex = 25
        Me.txtArcTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLMTZT
        '
        Me.txtLMTZT.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLMTZT.Location = New System.Drawing.Point(109, 122)
        Me.txtLMTZT.Multiline = True
        Me.txtLMTZT.Name = "txtLMTZT"
        Me.txtLMTZT.ReadOnly = True
        Me.txtLMTZT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLMTZT.Size = New System.Drawing.Size(226, 45)
        Me.txtLMTZT.TabIndex = 26
        Me.txtLMTZT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ExitBtn
        '
        Me.ExitBtn.BackColor = System.Drawing.Color.Red
        Me.ExitBtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExitBtn.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ExitBtn.Location = New System.Drawing.Point(394, 241)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ExitBtn.Size = New System.Drawing.Size(60, 25)
        Me.ExitBtn.TabIndex = 27
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = False
        '
        'ClearBtn
        '
        Me.ClearBtn.BackColor = System.Drawing.SystemColors.Control
        Me.ClearBtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.ClearBtn.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ClearBtn.Location = New System.Drawing.Point(4, 241)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ClearBtn.Size = New System.Drawing.Size(92, 25)
        Me.ClearBtn.TabIndex = 28
        Me.ClearBtn.Text = "Clear"
        Me.ClearBtn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CelestialTools.My.Resources.Resources.ABC_white
        Me.PictureBox1.Location = New System.Drawing.Point(76, 271)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(316, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 102
        Me.PictureBox1.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.ArcTime)
        Me.TabControl1.Controls.Add(Me.LMTZT)
        Me.TabControl1.Location = New System.Drawing.Point(0, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(463, 231)
        Me.TabControl1.TabIndex = 103
        '
        'ArcTime
        '
        Me.ArcTime.Controls.Add(Me.DTTime)
        Me.ArcTime.Controls.Add(Me.txtArcTime)
        Me.ArcTime.Controls.Add(Me.lblDeg)
        Me.ArcTime.Controls.Add(Me.lblArc)
        Me.ArcTime.Controls.Add(Me.Frame1)
        Me.ArcTime.Controls.Add(Me.txtMin)
        Me.ArcTime.Controls.Add(Me.txtDeg)
        Me.ArcTime.Controls.Add(Me.lblMin)
        Me.ArcTime.Controls.Add(Me.lblTime)
        Me.ArcTime.Location = New System.Drawing.Point(4, 22)
        Me.ArcTime.Name = "ArcTime"
        Me.ArcTime.Padding = New System.Windows.Forms.Padding(3)
        Me.ArcTime.Size = New System.Drawing.Size(455, 205)
        Me.ArcTime.TabIndex = 0
        Me.ArcTime.Text = "Arc-Time"
        Me.ArcTime.UseVisualStyleBackColor = True
        '
        'DTTime
        '
        Me.DTTime.CustomFormat = "HH:mm:ss"
        Me.DTTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTTime.Location = New System.Drawing.Point(198, 91)
        Me.DTTime.Name = "DTTime"
        Me.DTTime.ShowUpDown = True
        Me.DTTime.Size = New System.Drawing.Size(79, 21)
        Me.DTTime.TabIndex = 26
        Me.DTTime.Visible = False
        '
        'LMTZT
        '
        Me.LMTZT.Controls.Add(Me.DTLMT)
        Me.LMTZT.Controls.Add(Me.txtLMTZT)
        Me.LMTZT.Controls.Add(Me.Label1)
        Me.LMTZT.Controls.Add(Me.lblLoDeg)
        Me.LMTZT.Controls.Add(Me.lblLoMin)
        Me.LMTZT.Controls.Add(Me.lblLMT)
        Me.LMTZT.Controls.Add(Me.lblZT)
        Me.LMTZT.Controls.Add(Me.txtLoMin)
        Me.LMTZT.Controls.Add(Me.Frame2)
        Me.LMTZT.Controls.Add(Me.cboLo)
        Me.LMTZT.Controls.Add(Me.txtLoDeg)
        Me.LMTZT.Location = New System.Drawing.Point(4, 22)
        Me.LMTZT.Name = "LMTZT"
        Me.LMTZT.Padding = New System.Windows.Forms.Padding(3)
        Me.LMTZT.Size = New System.Drawing.Size(455, 205)
        Me.LMTZT.TabIndex = 1
        Me.LMTZT.Text = "LMT-ZT"
        Me.LMTZT.UseVisualStyleBackColor = True
        '
        'DTLMT
        '
        Me.DTLMT.CustomFormat = "HH:mm:ss"
        Me.DTLMT.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTLMT.Location = New System.Drawing.Point(241, 96)
        Me.DTLMT.Name = "DTLMT"
        Me.DTLMT.ShowUpDown = True
        Me.DTLMT.Size = New System.Drawing.Size(72, 21)
        Me.DTLMT.TabIndex = 27
        '
        'FormArcTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(466, 323)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ClearBtn)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdConvert)
        Me.Controls.Add(Me.TabControl1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(285, 99)
        Me.MaximizeBox = False
        Me.Name = "FormArcTime"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Arc-Time, LMT-ZT Conversion"
        Me.Frame2.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ArcTime.ResumeLayout(False)
        Me.ArcTime.PerformLayout()
        Me.LMTZT.ResumeLayout(False)
        Me.LMTZT.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtArcTime As TextBox
    Friend WithEvents txtLMTZT As TextBox
    Public WithEvents ExitBtn As Button
    Public WithEvents ClearBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents ArcTime As TabPage
    Friend WithEvents LMTZT As TabPage
    Friend WithEvents DTTime As DateTimePicker
    Friend WithEvents DTLMT As DateTimePicker
#End Region
End Class