<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FormTwoBearings
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
    Public WithEvents cmdPrint As System.Windows.Forms.Button
    'Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTwoBearings))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.txtDist = New System.Windows.Forms.TextBox()
        Me.txtSpeed = New System.Windows.Forms.TextBox()
        Me.txtTimeh = New System.Windows.Forms.TextBox()
        Me.txtTimem = New System.Windows.Forms.TextBox()
        Me.txtLog1 = New System.Windows.Forms.TextBox()
        Me.txtLog2 = New System.Windows.Forms.TextBox()
        Me.txtTime1 = New System.Windows.Forms.TextBox()
        Me.txtTime2 = New System.Windows.Forms.TextBox()
        Me.txtBearing2 = New System.Windows.Forms.TextBox()
        Me.txtBearing1 = New System.Windows.Forms.TextBox()
        Me.txtB1 = New System.Windows.Forms.TextBox()
        Me.txtB2 = New System.Windows.Forms.TextBox()
        Me.txtB3 = New System.Windows.Forms.TextBox()
        Me.txtL2Min = New System.Windows.Forms.TextBox()
        Me.txtLo2Deg = New System.Windows.Forms.TextBox()
        Me.txtLo2Min = New System.Windows.Forms.TextBox()
        Me.txtL2Deg = New System.Windows.Forms.TextBox()
        Me.txtL1Min = New System.Windows.Forms.TextBox()
        Me.txtLo1Deg = New System.Windows.Forms.TextBox()
        Me.txtLo1Min = New System.Windows.Forms.TextBox()
        Me.txtL1Deg = New System.Windows.Forms.TextBox()
        Me.txtBg2 = New System.Windows.Forms.TextBox()
        Me.txtBg1 = New System.Windows.Forms.TextBox()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Distance = New System.Windows.Forms.TabPage()
        Me.lblT2Fmt = New System.Windows.Forms.Label()
        Me.lblT1Fmt = New System.Windows.Forms.Label()
        Me.DistanceTxtBx = New System.Windows.Forms.RichTextBox()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.optComp = New System.Windows.Forms.RadioButton()
        Me.optMag = New System.Windows.Forms.RadioButton()
        Me.optTrue = New System.Windows.Forms.RadioButton()
        Me.optRel = New System.Windows.Forms.RadioButton()
        Me.cmdClearD = New System.Windows.Forms.Button()
        Me.cmdCalculateD = New System.Windows.Forms.Button()
        Me.lblB2 = New System.Windows.Forms.Label()
        Me.lblB1 = New System.Windows.Forms.Label()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.lblVesselCourse = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblDistance = New System.Windows.Forms.Label()
        Me.lblnm = New System.Windows.Forms.Label()
        Me.lblor = New System.Windows.Forms.Label()
        Me.lblSpeed = New System.Windows.Forms.Label()
        Me.lblkn = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblh = New System.Windows.Forms.Label()
        Me.lblm = New System.Windows.Forms.Label()
        Me.lblLog1 = New System.Windows.Forms.Label()
        Me.lblLog2 = New System.Windows.Forms.Label()
        Me.lblLog1nm = New System.Windows.Forms.Label()
        Me.lblLog2nm = New System.Windows.Forms.Label()
        Me.lblTime1 = New System.Windows.Forms.Label()
        Me.lblTime2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CMG = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtResultCourse = New System.Windows.Forms.TextBox()
        Me.cmdClearC = New System.Windows.Forms.Button()
        Me.cmdCalculateC = New System.Windows.Forms.Button()
        Me.txtI1 = New System.Windows.Forms.TextBox()
        Me.txtI2 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Fix = New System.Windows.Forms.TabPage()
        Me.chkReciprocal = New System.Windows.Forms.CheckBox()
        Me.txtFixLo = New System.Windows.Forms.TextBox()
        Me.txtFixL = New System.Windows.Forms.TextBox()
        Me.cmdClearF2 = New System.Windows.Forms.Button()
        Me.cmdCalculateF2 = New System.Windows.Forms.Button()
        Me.cboL2 = New System.Windows.Forms.ComboBox()
        Me.cboLo2 = New System.Windows.Forms.ComboBox()
        Me.cboL1 = New System.Windows.Forms.ComboBox()
        Me.cboLo1 = New System.Windows.Forms.ComboBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblDRL = New System.Windows.Forms.Label()
        Me.lblLDeg = New System.Windows.Forms.Label()
        Me.lblLMin = New System.Windows.Forms.Label()
        Me.lblDRLo = New System.Windows.Forms.Label()
        Me.lblLoDeg = New System.Windows.Forms.Label()
        Me.lblLoMin = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.Distance.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.CMG.SuspendLayout()
        Me.Fix.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrint.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.Location = New System.Drawing.Point(541, 3)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrint.Size = New System.Drawing.Size(21, 21)
        Me.cmdPrint.TabIndex = 30
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdPrint, "Print window")
        Me.cmdPrint.UseVisualStyleBackColor = False
        '
        'txtCourse
        '
        Me.txtCourse.AcceptsReturn = True
        Me.txtCourse.BackColor = System.Drawing.SystemColors.Window
        Me.txtCourse.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCourse.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourse.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCourse.Location = New System.Drawing.Point(285, 99)
        Me.txtCourse.MaxLength = 3
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCourse.Size = New System.Drawing.Size(33, 20)
        Me.txtCourse.TabIndex = 132
        Me.ToolTip1.SetToolTip(Me.txtCourse, "Range 0 to 359")
        Me.txtCourse.Visible = False
        '
        'txtDist
        '
        Me.txtDist.AcceptsReturn = True
        Me.txtDist.BackColor = System.Drawing.SystemColors.Window
        Me.txtDist.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDist.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDist.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDist.Location = New System.Drawing.Point(141, 249)
        Me.txtDist.MaxLength = 4
        Me.txtDist.Name = "txtDist"
        Me.txtDist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDist.Size = New System.Drawing.Size(41, 20)
        Me.txtDist.TabIndex = 113
        Me.ToolTip1.SetToolTip(Me.txtDist, "Range 0 to 99.9")
        '
        'txtSpeed
        '
        Me.txtSpeed.AcceptsReturn = True
        Me.txtSpeed.BackColor = System.Drawing.SystemColors.Window
        Me.txtSpeed.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSpeed.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSpeed.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSpeed.Location = New System.Drawing.Point(277, 249)
        Me.txtSpeed.MaxLength = 4
        Me.txtSpeed.Name = "txtSpeed"
        Me.txtSpeed.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSpeed.Size = New System.Drawing.Size(33, 20)
        Me.txtSpeed.TabIndex = 112
        Me.ToolTip1.SetToolTip(Me.txtSpeed, "Range 0 to 99.9")
        '
        'txtTimeh
        '
        Me.txtTimeh.AcceptsReturn = True
        Me.txtTimeh.BackColor = System.Drawing.SystemColors.Window
        Me.txtTimeh.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTimeh.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimeh.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTimeh.Location = New System.Drawing.Point(366, 249)
        Me.txtTimeh.MaxLength = 2
        Me.txtTimeh.Name = "txtTimeh"
        Me.txtTimeh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTimeh.Size = New System.Drawing.Size(33, 20)
        Me.txtTimeh.TabIndex = 111
        Me.ToolTip1.SetToolTip(Me.txtTimeh, "Range 0 to 99")
        '
        'txtTimem
        '
        Me.txtTimem.AcceptsReturn = True
        Me.txtTimem.BackColor = System.Drawing.SystemColors.Window
        Me.txtTimem.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTimem.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimem.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTimem.Location = New System.Drawing.Point(415, 249)
        Me.txtTimem.MaxLength = 2
        Me.txtTimem.Name = "txtTimem"
        Me.txtTimem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTimem.Size = New System.Drawing.Size(33, 20)
        Me.txtTimem.TabIndex = 110
        Me.ToolTip1.SetToolTip(Me.txtTimem, "Range 0 to 99 or 59")
        '
        'txtLog1
        '
        Me.txtLog1.AcceptsReturn = True
        Me.txtLog1.BackColor = System.Drawing.SystemColors.Window
        Me.txtLog1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLog1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLog1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLog1.Location = New System.Drawing.Point(141, 201)
        Me.txtLog1.MaxLength = 6
        Me.txtLog1.Name = "txtLog1"
        Me.txtLog1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLog1.Size = New System.Drawing.Size(41, 20)
        Me.txtLog1.TabIndex = 109
        Me.ToolTip1.SetToolTip(Me.txtLog1, "Range 0 to 9999.9")
        '
        'txtLog2
        '
        Me.txtLog2.AcceptsReturn = True
        Me.txtLog2.BackColor = System.Drawing.SystemColors.Window
        Me.txtLog2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLog2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLog2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLog2.Location = New System.Drawing.Point(141, 225)
        Me.txtLog2.MaxLength = 6
        Me.txtLog2.Name = "txtLog2"
        Me.txtLog2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLog2.Size = New System.Drawing.Size(41, 20)
        Me.txtLog2.TabIndex = 108
        Me.ToolTip1.SetToolTip(Me.txtLog2, "Range 0 to 9999.9")
        '
        'txtTime1
        '
        Me.txtTime1.AcceptsReturn = True
        Me.txtTime1.BackColor = System.Drawing.SystemColors.Window
        Me.txtTime1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTime1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTime1.Location = New System.Drawing.Point(415, 201)
        Me.txtTime1.MaxLength = 4
        Me.txtTime1.Name = "txtTime1"
        Me.txtTime1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTime1.Size = New System.Drawing.Size(33, 20)
        Me.txtTime1.TabIndex = 107
        Me.ToolTip1.SetToolTip(Me.txtTime1, "Range 0000 to 2359")
        '
        'txtTime2
        '
        Me.txtTime2.AcceptsReturn = True
        Me.txtTime2.BackColor = System.Drawing.SystemColors.Window
        Me.txtTime2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTime2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTime2.Location = New System.Drawing.Point(415, 225)
        Me.txtTime2.MaxLength = 4
        Me.txtTime2.Name = "txtTime2"
        Me.txtTime2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTime2.Size = New System.Drawing.Size(33, 20)
        Me.txtTime2.TabIndex = 106
        Me.ToolTip1.SetToolTip(Me.txtTime2, "Range 0000 to 2359")
        '
        'txtBearing2
        '
        Me.txtBearing2.AcceptsReturn = True
        Me.txtBearing2.BackColor = System.Drawing.SystemColors.Window
        Me.txtBearing2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBearing2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBearing2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBearing2.Location = New System.Drawing.Point(285, 147)
        Me.txtBearing2.MaxLength = 3
        Me.txtBearing2.Name = "txtBearing2"
        Me.txtBearing2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBearing2.Size = New System.Drawing.Size(33, 20)
        Me.txtBearing2.TabIndex = 104
        Me.ToolTip1.SetToolTip(Me.txtBearing2, "Range 1 to 90 if relative; 0 to 359 otherwise")
        '
        'txtBearing1
        '
        Me.txtBearing1.AcceptsReturn = True
        Me.txtBearing1.BackColor = System.Drawing.SystemColors.Window
        Me.txtBearing1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBearing1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBearing1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBearing1.Location = New System.Drawing.Point(285, 123)
        Me.txtBearing1.MaxLength = 3
        Me.txtBearing1.Name = "txtBearing1"
        Me.txtBearing1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBearing1.Size = New System.Drawing.Size(33, 20)
        Me.txtBearing1.TabIndex = 103
        Me.ToolTip1.SetToolTip(Me.txtBearing1, "Range 1 to 90 if relative; 0 to 359 otherwise")
        '
        'txtB1
        '
        Me.txtB1.AcceptsReturn = True
        Me.txtB1.BackColor = System.Drawing.SystemColors.Window
        Me.txtB1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtB1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtB1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtB1.Location = New System.Drawing.Point(96, 101)
        Me.txtB1.MaxLength = 3
        Me.txtB1.Name = "txtB1"
        Me.txtB1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtB1.Size = New System.Drawing.Size(33, 20)
        Me.txtB1.TabIndex = 60
        Me.ToolTip1.SetToolTip(Me.txtB1, "Range 0 to 359")
        '
        'txtB2
        '
        Me.txtB2.AcceptsReturn = True
        Me.txtB2.BackColor = System.Drawing.SystemColors.Window
        Me.txtB2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtB2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtB2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtB2.Location = New System.Drawing.Point(240, 101)
        Me.txtB2.MaxLength = 3
        Me.txtB2.Name = "txtB2"
        Me.txtB2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtB2.Size = New System.Drawing.Size(33, 20)
        Me.txtB2.TabIndex = 64
        Me.ToolTip1.SetToolTip(Me.txtB2, "Range 0 to 359")
        '
        'txtB3
        '
        Me.txtB3.AcceptsReturn = True
        Me.txtB3.BackColor = System.Drawing.SystemColors.Window
        Me.txtB3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtB3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtB3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtB3.Location = New System.Drawing.Point(384, 101)
        Me.txtB3.MaxLength = 3
        Me.txtB3.Name = "txtB3"
        Me.txtB3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtB3.Size = New System.Drawing.Size(33, 20)
        Me.txtB3.TabIndex = 68
        Me.ToolTip1.SetToolTip(Me.txtB3, "Range 0 to 359")
        '
        'txtL2Min
        '
        Me.txtL2Min.AcceptsReturn = True
        Me.txtL2Min.BackColor = System.Drawing.SystemColors.Window
        Me.txtL2Min.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtL2Min.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtL2Min.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtL2Min.Location = New System.Drawing.Point(341, 87)
        Me.txtL2Min.MaxLength = 4
        Me.txtL2Min.Name = "txtL2Min"
        Me.txtL2Min.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtL2Min.Size = New System.Drawing.Size(33, 20)
        Me.txtL2Min.TabIndex = 108
        Me.ToolTip1.SetToolTip(Me.txtL2Min, "Range 0 to 59.9")
        '
        'txtLo2Deg
        '
        Me.txtLo2Deg.AcceptsReturn = True
        Me.txtLo2Deg.BackColor = System.Drawing.SystemColors.Window
        Me.txtLo2Deg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLo2Deg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLo2Deg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLo2Deg.Location = New System.Drawing.Point(301, 111)
        Me.txtLo2Deg.MaxLength = 3
        Me.txtLo2Deg.Name = "txtLo2Deg"
        Me.txtLo2Deg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLo2Deg.Size = New System.Drawing.Size(33, 20)
        Me.txtLo2Deg.TabIndex = 110
        Me.ToolTip1.SetToolTip(Me.txtLo2Deg, "Range 0 to 180")
        '
        'txtLo2Min
        '
        Me.txtLo2Min.AcceptsReturn = True
        Me.txtLo2Min.BackColor = System.Drawing.SystemColors.Window
        Me.txtLo2Min.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLo2Min.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLo2Min.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLo2Min.Location = New System.Drawing.Point(341, 111)
        Me.txtLo2Min.MaxLength = 4
        Me.txtLo2Min.Name = "txtLo2Min"
        Me.txtLo2Min.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLo2Min.Size = New System.Drawing.Size(33, 20)
        Me.txtLo2Min.TabIndex = 111
        Me.ToolTip1.SetToolTip(Me.txtLo2Min, "Range 0 to 59.9")
        '
        'txtL2Deg
        '
        Me.txtL2Deg.AcceptsReturn = True
        Me.txtL2Deg.BackColor = System.Drawing.SystemColors.Window
        Me.txtL2Deg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtL2Deg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtL2Deg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtL2Deg.Location = New System.Drawing.Point(301, 87)
        Me.txtL2Deg.MaxLength = 2
        Me.txtL2Deg.Name = "txtL2Deg"
        Me.txtL2Deg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtL2Deg.Size = New System.Drawing.Size(33, 20)
        Me.txtL2Deg.TabIndex = 107
        Me.ToolTip1.SetToolTip(Me.txtL2Deg, "Range 0 to 90")
        '
        'txtL1Min
        '
        Me.txtL1Min.AcceptsReturn = True
        Me.txtL1Min.BackColor = System.Drawing.SystemColors.Window
        Me.txtL1Min.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtL1Min.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtL1Min.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtL1Min.Location = New System.Drawing.Point(157, 87)
        Me.txtL1Min.MaxLength = 4
        Me.txtL1Min.Name = "txtL1Min"
        Me.txtL1Min.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtL1Min.Size = New System.Drawing.Size(33, 20)
        Me.txtL1Min.TabIndex = 101
        Me.ToolTip1.SetToolTip(Me.txtL1Min, "Range 0 to 59.9")
        '
        'txtLo1Deg
        '
        Me.txtLo1Deg.AcceptsReturn = True
        Me.txtLo1Deg.BackColor = System.Drawing.SystemColors.Window
        Me.txtLo1Deg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLo1Deg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLo1Deg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLo1Deg.Location = New System.Drawing.Point(117, 111)
        Me.txtLo1Deg.MaxLength = 3
        Me.txtLo1Deg.Name = "txtLo1Deg"
        Me.txtLo1Deg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLo1Deg.Size = New System.Drawing.Size(33, 20)
        Me.txtLo1Deg.TabIndex = 103
        Me.ToolTip1.SetToolTip(Me.txtLo1Deg, "Range 0 to 180")
        '
        'txtLo1Min
        '
        Me.txtLo1Min.AcceptsReturn = True
        Me.txtLo1Min.BackColor = System.Drawing.SystemColors.Window
        Me.txtLo1Min.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLo1Min.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLo1Min.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLo1Min.Location = New System.Drawing.Point(157, 111)
        Me.txtLo1Min.MaxLength = 4
        Me.txtLo1Min.Name = "txtLo1Min"
        Me.txtLo1Min.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLo1Min.Size = New System.Drawing.Size(33, 20)
        Me.txtLo1Min.TabIndex = 104
        Me.ToolTip1.SetToolTip(Me.txtLo1Min, "Range 0 to 59.9")
        '
        'txtL1Deg
        '
        Me.txtL1Deg.AcceptsReturn = True
        Me.txtL1Deg.BackColor = System.Drawing.SystemColors.Window
        Me.txtL1Deg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtL1Deg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtL1Deg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtL1Deg.Location = New System.Drawing.Point(117, 87)
        Me.txtL1Deg.MaxLength = 2
        Me.txtL1Deg.Name = "txtL1Deg"
        Me.txtL1Deg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtL1Deg.Size = New System.Drawing.Size(33, 20)
        Me.txtL1Deg.TabIndex = 100
        Me.ToolTip1.SetToolTip(Me.txtL1Deg, "Range 0 to 90")
        '
        'txtBg2
        '
        Me.txtBg2.AcceptsReturn = True
        Me.txtBg2.BackColor = System.Drawing.SystemColors.Window
        Me.txtBg2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBg2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBg2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBg2.Location = New System.Drawing.Point(341, 63)
        Me.txtBg2.MaxLength = 5
        Me.txtBg2.Name = "txtBg2"
        Me.txtBg2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBg2.Size = New System.Drawing.Size(41, 20)
        Me.txtBg2.TabIndex = 106
        Me.ToolTip1.SetToolTip(Me.txtBg2, "Range 0 to 359.9")
        '
        'txtBg1
        '
        Me.txtBg1.AcceptsReturn = True
        Me.txtBg1.BackColor = System.Drawing.SystemColors.Window
        Me.txtBg1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBg1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBg1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBg1.Location = New System.Drawing.Point(157, 63)
        Me.txtBg1.MaxLength = 5
        Me.txtBg1.Name = "txtBg1"
        Me.txtBg1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBg1.Size = New System.Drawing.Size(41, 20)
        Me.txtBg1.TabIndex = 99
        Me.ToolTip1.SetToolTip(Me.txtBg1, "Range 0 to 359.9")
        '
        'ExitBtn
        '
        Me.ExitBtn.BackColor = System.Drawing.Color.Red
        Me.ExitBtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExitBtn.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ExitBtn.Location = New System.Drawing.Point(487, 432)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ExitBtn.Size = New System.Drawing.Size(73, 25)
        Me.ExitBtn.TabIndex = 100
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CelestialTools.My.Resources.Resources.ABC_white
        Me.PictureBox1.Location = New System.Drawing.Point(112, 432)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(316, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 103
        Me.PictureBox1.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Distance)
        Me.TabControl1.Controls.Add(Me.CMG)
        Me.TabControl1.Controls.Add(Me.Fix)
        Me.TabControl1.Location = New System.Drawing.Point(12, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(552, 423)
        Me.TabControl1.TabIndex = 104
        '
        'Distance
        '
        Me.Distance.Controls.Add(Me.lblT2Fmt)
        Me.Distance.Controls.Add(Me.lblT1Fmt)
        Me.Distance.Controls.Add(Me.DistanceTxtBx)
        Me.Distance.Controls.Add(Me.txtCourse)
        Me.Distance.Controls.Add(Me.Frame1)
        Me.Distance.Controls.Add(Me.cmdClearD)
        Me.Distance.Controls.Add(Me.txtDist)
        Me.Distance.Controls.Add(Me.txtSpeed)
        Me.Distance.Controls.Add(Me.txtTimeh)
        Me.Distance.Controls.Add(Me.txtTimem)
        Me.Distance.Controls.Add(Me.txtLog1)
        Me.Distance.Controls.Add(Me.txtLog2)
        Me.Distance.Controls.Add(Me.txtTime1)
        Me.Distance.Controls.Add(Me.txtTime2)
        Me.Distance.Controls.Add(Me.cmdCalculateD)
        Me.Distance.Controls.Add(Me.txtBearing2)
        Me.Distance.Controls.Add(Me.txtBearing1)
        Me.Distance.Controls.Add(Me.lblB2)
        Me.Distance.Controls.Add(Me.lblB1)
        Me.Distance.Controls.Add(Me.lblCourse)
        Me.Distance.Controls.Add(Me.lblVesselCourse)
        Me.Distance.Controls.Add(Me.Label4)
        Me.Distance.Controls.Add(Me.lblDistance)
        Me.Distance.Controls.Add(Me.lblnm)
        Me.Distance.Controls.Add(Me.lblor)
        Me.Distance.Controls.Add(Me.lblSpeed)
        Me.Distance.Controls.Add(Me.lblkn)
        Me.Distance.Controls.Add(Me.lblTime)
        Me.Distance.Controls.Add(Me.lblh)
        Me.Distance.Controls.Add(Me.lblm)
        Me.Distance.Controls.Add(Me.lblLog1)
        Me.Distance.Controls.Add(Me.lblLog2)
        Me.Distance.Controls.Add(Me.lblLog1nm)
        Me.Distance.Controls.Add(Me.lblLog2nm)
        Me.Distance.Controls.Add(Me.lblTime1)
        Me.Distance.Controls.Add(Me.lblTime2)
        Me.Distance.Controls.Add(Me.Label3)
        Me.Distance.Controls.Add(Me.Label2)
        Me.Distance.Controls.Add(Me.Label1)
        Me.Distance.Location = New System.Drawing.Point(4, 22)
        Me.Distance.Name = "Distance"
        Me.Distance.Padding = New System.Windows.Forms.Padding(3)
        Me.Distance.Size = New System.Drawing.Size(544, 397)
        Me.Distance.TabIndex = 0
        Me.Distance.Text = "Distance by 2 Bearings"
        Me.Distance.UseVisualStyleBackColor = True
        '
        'lblT2Fmt
        '
        Me.lblT2Fmt.AutoSize = True
        Me.lblT2Fmt.Location = New System.Drawing.Point(452, 229)
        Me.lblT2Fmt.Name = "lblT2Fmt"
        Me.lblT2Fmt.Size = New System.Drawing.Size(43, 13)
        Me.lblT2Fmt.TabIndex = 138
        Me.lblT2Fmt.Text = "(hhmm)"
        '
        'lblT1Fmt
        '
        Me.lblT1Fmt.AutoSize = True
        Me.lblT1Fmt.Location = New System.Drawing.Point(452, 205)
        Me.lblT1Fmt.Name = "lblT1Fmt"
        Me.lblT1Fmt.Size = New System.Drawing.Size(43, 13)
        Me.lblT1Fmt.TabIndex = 137
        Me.lblT1Fmt.Text = "(hhmm)"
        '
        'DistanceTxtBx
        '
        Me.DistanceTxtBx.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DistanceTxtBx.Location = New System.Drawing.Point(70, 311)
        Me.DistanceTxtBx.Name = "DistanceTxtBx"
        Me.DistanceTxtBx.ReadOnly = True
        Me.DistanceTxtBx.Size = New System.Drawing.Size(418, 78)
        Me.DistanceTxtBx.TabIndex = 136
        Me.DistanceTxtBx.Text = ""
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Window
        Me.Frame1.Controls.Add(Me.optComp)
        Me.Frame1.Controls.Add(Me.optMag)
        Me.Frame1.Controls.Add(Me.optTrue)
        Me.Frame1.Controls.Add(Me.optRel)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(94, 53)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(365, 41)
        Me.Frame1.TabIndex = 130
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Bearings are"
        '
        'optComp
        '
        Me.optComp.BackColor = System.Drawing.SystemColors.Window
        Me.optComp.Cursor = System.Windows.Forms.Cursors.Default
        Me.optComp.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optComp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optComp.Location = New System.Drawing.Point(280, 16)
        Me.optComp.Name = "optComp"
        Me.optComp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optComp.Size = New System.Drawing.Size(70, 17)
        Me.optComp.TabIndex = 35
        Me.optComp.TabStop = True
        Me.optComp.Text = "Compass"
        Me.optComp.UseVisualStyleBackColor = False
        '
        'optMag
        '
        Me.optMag.BackColor = System.Drawing.SystemColors.Window
        Me.optMag.Cursor = System.Windows.Forms.Cursors.Default
        Me.optMag.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optMag.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optMag.Location = New System.Drawing.Point(192, 16)
        Me.optMag.Name = "optMag"
        Me.optMag.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optMag.Size = New System.Drawing.Size(69, 17)
        Me.optMag.TabIndex = 34
        Me.optMag.TabStop = True
        Me.optMag.Text = "Magnetic"
        Me.optMag.UseVisualStyleBackColor = False
        '
        'optTrue
        '
        Me.optTrue.BackColor = System.Drawing.SystemColors.Window
        Me.optTrue.Cursor = System.Windows.Forms.Cursors.Default
        Me.optTrue.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optTrue.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optTrue.Location = New System.Drawing.Point(120, 16)
        Me.optTrue.Name = "optTrue"
        Me.optTrue.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optTrue.Size = New System.Drawing.Size(49, 17)
        Me.optTrue.TabIndex = 33
        Me.optTrue.TabStop = True
        Me.optTrue.Text = "True"
        Me.optTrue.UseVisualStyleBackColor = False
        '
        'optRel
        '
        Me.optRel.BackColor = System.Drawing.SystemColors.Window
        Me.optRel.Checked = True
        Me.optRel.Cursor = System.Windows.Forms.Cursors.Default
        Me.optRel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optRel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optRel.Location = New System.Drawing.Point(8, 16)
        Me.optRel.Name = "optRel"
        Me.optRel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optRel.Size = New System.Drawing.Size(97, 17)
        Me.optRel.TabIndex = 32
        Me.optRel.TabStop = True
        Me.optRel.Text = "Relative (bow)"
        Me.optRel.UseVisualStyleBackColor = False
        '
        'cmdClearD
        '
        Me.cmdClearD.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClearD.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClearD.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClearD.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClearD.Location = New System.Drawing.Point(415, 278)
        Me.cmdClearD.Name = "cmdClearD"
        Me.cmdClearD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClearD.Size = New System.Drawing.Size(73, 25)
        Me.cmdClearD.TabIndex = 129
        Me.cmdClearD.Text = "Clea&r"
        Me.cmdClearD.UseVisualStyleBackColor = False
        '
        'cmdCalculateD
        '
        Me.cmdCalculateD.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCalculateD.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCalculateD.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCalculateD.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCalculateD.Location = New System.Drawing.Point(214, 278)
        Me.cmdCalculateD.Name = "cmdCalculateD"
        Me.cmdCalculateD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCalculateD.Size = New System.Drawing.Size(121, 25)
        Me.cmdCalculateD.TabIndex = 105
        Me.cmdCalculateD.Text = "Calculate &Distance"
        Me.cmdCalculateD.UseVisualStyleBackColor = False
        '
        'lblB2
        '
        Me.lblB2.BackColor = System.Drawing.SystemColors.Window
        Me.lblB2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblB2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblB2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblB2.Location = New System.Drawing.Point(318, 149)
        Me.lblB2.Name = "lblB2"
        Me.lblB2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblB2.Size = New System.Drawing.Size(120, 17)
        Me.lblB2.TabIndex = 135
        Me.lblB2.Text = "° Relative (off the bow)"
        Me.lblB2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblB1
        '
        Me.lblB1.BackColor = System.Drawing.SystemColors.Window
        Me.lblB1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblB1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblB1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblB1.Location = New System.Drawing.Point(318, 125)
        Me.lblB1.Name = "lblB1"
        Me.lblB1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblB1.Size = New System.Drawing.Size(120, 17)
        Me.lblB1.TabIndex = 134
        Me.lblB1.Text = "° Relative (off the bow)"
        Me.lblB1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCourse
        '
        Me.lblCourse.BackColor = System.Drawing.SystemColors.Window
        Me.lblCourse.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCourse.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourse.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCourse.Location = New System.Drawing.Point(318, 101)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCourse.Size = New System.Drawing.Size(120, 17)
        Me.lblCourse.TabIndex = 133
        Me.lblCourse.Text = "° True"
        Me.lblCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCourse.Visible = False
        '
        'lblVesselCourse
        '
        Me.lblVesselCourse.BackColor = System.Drawing.SystemColors.Window
        Me.lblVesselCourse.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblVesselCourse.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVesselCourse.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblVesselCourse.Location = New System.Drawing.Point(205, 100)
        Me.lblVesselCourse.Name = "lblVesselCourse"
        Me.lblVesselCourse.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblVesselCourse.Size = New System.Drawing.Size(78, 17)
        Me.lblVesselCourse.TabIndex = 131
        Me.lblVesselCourse.Text = "Vessel Course"
        Me.lblVesselCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblVesselCourse.Visible = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(94, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(365, 20)
        Me.Label4.TabIndex = 128
        Me.Label4.Text = "Input distance or speed and time traveled between bearings"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDistance
        '
        Me.lblDistance.BackColor = System.Drawing.SystemColors.Window
        Me.lblDistance.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDistance.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDistance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDistance.Location = New System.Drawing.Point(88, 249)
        Me.lblDistance.Name = "lblDistance"
        Me.lblDistance.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDistance.Size = New System.Drawing.Size(50, 17)
        Me.lblDistance.TabIndex = 127
        Me.lblDistance.Text = "Distance"
        Me.lblDistance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblnm
        '
        Me.lblnm.BackColor = System.Drawing.SystemColors.Window
        Me.lblnm.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblnm.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblnm.Location = New System.Drawing.Point(183, 249)
        Me.lblnm.Name = "lblnm"
        Me.lblnm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblnm.Size = New System.Drawing.Size(25, 17)
        Me.lblnm.TabIndex = 126
        Me.lblnm.Text = "nm"
        Me.lblnm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblor
        '
        Me.lblor.BackColor = System.Drawing.SystemColors.Window
        Me.lblor.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblor.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblor.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblor.Location = New System.Drawing.Point(214, 225)
        Me.lblor.Name = "lblor"
        Me.lblor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblor.Size = New System.Drawing.Size(25, 17)
        Me.lblor.TabIndex = 125
        Me.lblor.Text = "OR"
        '
        'lblSpeed
        '
        Me.lblSpeed.BackColor = System.Drawing.SystemColors.Window
        Me.lblSpeed.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSpeed.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpeed.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSpeed.Location = New System.Drawing.Point(238, 250)
        Me.lblSpeed.Name = "lblSpeed"
        Me.lblSpeed.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSpeed.Size = New System.Drawing.Size(38, 17)
        Me.lblSpeed.TabIndex = 124
        Me.lblSpeed.Text = "Speed"
        Me.lblSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblkn
        '
        Me.lblkn.BackColor = System.Drawing.SystemColors.Window
        Me.lblkn.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblkn.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblkn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblkn.Location = New System.Drawing.Point(310, 249)
        Me.lblkn.Name = "lblkn"
        Me.lblkn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblkn.Size = New System.Drawing.Size(25, 17)
        Me.lblkn.TabIndex = 123
        Me.lblkn.Text = "kn"
        Me.lblkn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.SystemColors.Window
        Me.lblTime.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTime.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTime.Location = New System.Drawing.Point(334, 249)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTime.Size = New System.Drawing.Size(30, 20)
        Me.lblTime.TabIndex = 122
        Me.lblTime.Text = "Run Time"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblh
        '
        Me.lblh.BackColor = System.Drawing.SystemColors.Window
        Me.lblh.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblh.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblh.Location = New System.Drawing.Point(399, 249)
        Me.lblh.Name = "lblh"
        Me.lblh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblh.Size = New System.Drawing.Size(17, 17)
        Me.lblh.TabIndex = 121
        Me.lblh.Text = "hr"
        Me.lblh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblm
        '
        Me.lblm.BackColor = System.Drawing.SystemColors.Window
        Me.lblm.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblm.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblm.Location = New System.Drawing.Point(448, 249)
        Me.lblm.Name = "lblm"
        Me.lblm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblm.Size = New System.Drawing.Size(25, 17)
        Me.lblm.TabIndex = 120
        Me.lblm.Text = "min"
        Me.lblm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLog1
        '
        Me.lblLog1.BackColor = System.Drawing.SystemColors.Window
        Me.lblLog1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLog1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLog1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLog1.Location = New System.Drawing.Point(78, 202)
        Me.lblLog1.Name = "lblLog1"
        Me.lblLog1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLog1.Size = New System.Drawing.Size(65, 17)
        Me.lblLog1.TabIndex = 119
        Me.lblLog1.Text = "Log Entry 1"
        Me.lblLog1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLog2
        '
        Me.lblLog2.BackColor = System.Drawing.SystemColors.Window
        Me.lblLog2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLog2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLog2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLog2.Location = New System.Drawing.Point(77, 226)
        Me.lblLog2.Name = "lblLog2"
        Me.lblLog2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLog2.Size = New System.Drawing.Size(65, 17)
        Me.lblLog2.TabIndex = 118
        Me.lblLog2.Text = "Log Entry 2"
        Me.lblLog2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLog1nm
        '
        Me.lblLog1nm.BackColor = System.Drawing.SystemColors.Window
        Me.lblLog1nm.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLog1nm.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLog1nm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLog1nm.Location = New System.Drawing.Point(183, 201)
        Me.lblLog1nm.Name = "lblLog1nm"
        Me.lblLog1nm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLog1nm.Size = New System.Drawing.Size(25, 17)
        Me.lblLog1nm.TabIndex = 117
        Me.lblLog1nm.Text = "nm"
        Me.lblLog1nm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLog2nm
        '
        Me.lblLog2nm.BackColor = System.Drawing.SystemColors.Window
        Me.lblLog2nm.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLog2nm.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLog2nm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLog2nm.Location = New System.Drawing.Point(183, 225)
        Me.lblLog2nm.Name = "lblLog2nm"
        Me.lblLog2nm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLog2nm.Size = New System.Drawing.Size(25, 17)
        Me.lblLog2nm.TabIndex = 116
        Me.lblLog2nm.Text = "nm"
        Me.lblLog2nm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTime1
        '
        Me.lblTime1.BackColor = System.Drawing.SystemColors.Window
        Me.lblTime1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTime1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTime1.Location = New System.Drawing.Point(348, 203)
        Me.lblTime1.Name = "lblTime1"
        Me.lblTime1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTime1.Size = New System.Drawing.Size(70, 17)
        Me.lblTime1.TabIndex = 115
        Me.lblTime1.Text = "First Time"
        Me.lblTime1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTime2
        '
        Me.lblTime2.BackColor = System.Drawing.SystemColors.Window
        Me.lblTime2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTime2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTime2.Location = New System.Drawing.Point(347, 226)
        Me.lblTime2.Name = "lblTime2"
        Me.lblTime2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTime2.Size = New System.Drawing.Size(70, 17)
        Me.lblTime2.TabIndex = 114
        Me.lblTime2.Text = "Second Time"
        Me.lblTime2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Window
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(157, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(129, 20)
        Me.Label3.TabIndex = 102
        Me.Label3.Text = "Second bearing to object"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(173, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(113, 17)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "First bearing to object"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(94, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(365, 49)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "Calculates the distance of a fixed object by two bearings " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and the distance and " &
    "time to object when object is abeam. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Assumes a constant course and speed, movi" &
    "ng towards object."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CMG
        '
        Me.CMG.Controls.Add(Me.TextBox1)
        Me.CMG.Controls.Add(Me.txtResultCourse)
        Me.CMG.Controls.Add(Me.cmdClearC)
        Me.CMG.Controls.Add(Me.cmdCalculateC)
        Me.CMG.Controls.Add(Me.txtB1)
        Me.CMG.Controls.Add(Me.txtI1)
        Me.CMG.Controls.Add(Me.txtB2)
        Me.CMG.Controls.Add(Me.txtI2)
        Me.CMG.Controls.Add(Me.txtB3)
        Me.CMG.Controls.Add(Me.Label14)
        Me.CMG.Controls.Add(Me.Label13)
        Me.CMG.Controls.Add(Me.Label12)
        Me.CMG.Controls.Add(Me.Label11)
        Me.CMG.Controls.Add(Me.Label10)
        Me.CMG.Controls.Add(Me.Label6)
        Me.CMG.Controls.Add(Me.Label7)
        Me.CMG.Controls.Add(Me.Label8)
        Me.CMG.Controls.Add(Me.Label9)
        Me.CMG.Controls.Add(Me.Label5)
        Me.CMG.Location = New System.Drawing.Point(4, 22)
        Me.CMG.Name = "CMG"
        Me.CMG.Padding = New System.Windows.Forms.Padding(3)
        Me.CMG.Size = New System.Drawing.Size(544, 397)
        Me.CMG.TabIndex = 1
        Me.CMG.Text = "Course by 2 or 3 Bearings"
        Me.CMG.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 229)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(532, 106)
        Me.TextBox1.TabIndex = 77
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtResultCourse
        '
        Me.txtResultCourse.AcceptsReturn = True
        Me.txtResultCourse.BackColor = System.Drawing.SystemColors.Window
        Me.txtResultCourse.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtResultCourse.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResultCourse.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtResultCourse.Location = New System.Drawing.Point(264, 162)
        Me.txtResultCourse.MaxLength = 0
        Me.txtResultCourse.Name = "txtResultCourse"
        Me.txtResultCourse.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtResultCourse.Size = New System.Drawing.Size(30, 20)
        Me.txtResultCourse.TabIndex = 76
        '
        'cmdClearC
        '
        Me.cmdClearC.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClearC.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClearC.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClearC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClearC.Location = New System.Drawing.Point(216, 191)
        Me.cmdClearC.Name = "cmdClearC"
        Me.cmdClearC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClearC.Size = New System.Drawing.Size(89, 25)
        Me.cmdClearC.TabIndex = 74
        Me.cmdClearC.Text = "Cl&ear"
        Me.cmdClearC.UseVisualStyleBackColor = False
        '
        'cmdCalculateC
        '
        Me.cmdCalculateC.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCalculateC.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCalculateC.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCalculateC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCalculateC.Location = New System.Drawing.Point(216, 125)
        Me.cmdCalculateC.Name = "cmdCalculateC"
        Me.cmdCalculateC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCalculateC.Size = New System.Drawing.Size(89, 25)
        Me.cmdCalculateC.TabIndex = 69
        Me.cmdCalculateC.Text = "Calculate &CMG"
        Me.cmdCalculateC.UseVisualStyleBackColor = False
        '
        'txtI1
        '
        Me.txtI1.AcceptsReturn = True
        Me.txtI1.BackColor = System.Drawing.SystemColors.Window
        Me.txtI1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtI1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtI1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtI1.Location = New System.Drawing.Point(169, 101)
        Me.txtI1.MaxLength = 5
        Me.txtI1.Name = "txtI1"
        Me.txtI1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtI1.Size = New System.Drawing.Size(41, 20)
        Me.txtI1.TabIndex = 62
        '
        'txtI2
        '
        Me.txtI2.AcceptsReturn = True
        Me.txtI2.BackColor = System.Drawing.SystemColors.Window
        Me.txtI2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtI2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtI2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtI2.Location = New System.Drawing.Point(311, 101)
        Me.txtI2.MaxLength = 5
        Me.txtI2.Name = "txtI2"
        Me.txtI2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtI2.Size = New System.Drawing.Size(41, 20)
        Me.txtI2.TabIndex = 66
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Window
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(218, 158)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(35, 29)
        Me.Label14.TabIndex = 75
        Me.Label14.Text = "CMG"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Window
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(85, 85)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(63, 17)
        Me.Label13.TabIndex = 73
        Me.Label13.Text = "1st Bearing"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Window
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(160, 84)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(63, 15)
        Me.Label12.TabIndex = 72
        Me.Label12.Text = "1st Interval" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Window
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(232, 85)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(65, 17)
        Me.Label11.TabIndex = 71
        Me.Label11.Text = "2nd Bearing"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Window
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(301, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(65, 15)
        Me.Label10.TabIndex = 70
        Me.Label10.Text = "2nd Interval"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Window
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(376, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(63, 17)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "3rd Bearing"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Window
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(129, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(9, 17)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "°"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Window
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(273, 101)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(9, 17)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "°"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Window
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(417, 101)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(9, 17)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "°"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Window
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(80, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(369, 41)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = resources.GetString("Label5.Text")
        '
        'Fix
        '
        Me.Fix.Controls.Add(Me.chkReciprocal)
        Me.Fix.Controls.Add(Me.txtFixLo)
        Me.Fix.Controls.Add(Me.txtFixL)
        Me.Fix.Controls.Add(Me.cmdClearF2)
        Me.Fix.Controls.Add(Me.cmdCalculateF2)
        Me.Fix.Controls.Add(Me.txtL2Min)
        Me.Fix.Controls.Add(Me.cboL2)
        Me.Fix.Controls.Add(Me.txtLo2Deg)
        Me.Fix.Controls.Add(Me.txtLo2Min)
        Me.Fix.Controls.Add(Me.cboLo2)
        Me.Fix.Controls.Add(Me.txtL2Deg)
        Me.Fix.Controls.Add(Me.txtL1Min)
        Me.Fix.Controls.Add(Me.cboL1)
        Me.Fix.Controls.Add(Me.txtLo1Deg)
        Me.Fix.Controls.Add(Me.txtLo1Min)
        Me.Fix.Controls.Add(Me.cboLo1)
        Me.Fix.Controls.Add(Me.txtL1Deg)
        Me.Fix.Controls.Add(Me.txtBg2)
        Me.Fix.Controls.Add(Me.txtBg1)
        Me.Fix.Controls.Add(Me.Label28)
        Me.Fix.Controls.Add(Me.Label27)
        Me.Fix.Controls.Add(Me.Label26)
        Me.Fix.Controls.Add(Me.Label25)
        Me.Fix.Controls.Add(Me.Label24)
        Me.Fix.Controls.Add(Me.Label23)
        Me.Fix.Controls.Add(Me.Label22)
        Me.Fix.Controls.Add(Me.Label21)
        Me.Fix.Controls.Add(Me.Label20)
        Me.Fix.Controls.Add(Me.Label19)
        Me.Fix.Controls.Add(Me.Label18)
        Me.Fix.Controls.Add(Me.Label17)
        Me.Fix.Controls.Add(Me.lblDRL)
        Me.Fix.Controls.Add(Me.lblLDeg)
        Me.Fix.Controls.Add(Me.lblLMin)
        Me.Fix.Controls.Add(Me.lblDRLo)
        Me.Fix.Controls.Add(Me.lblLoDeg)
        Me.Fix.Controls.Add(Me.lblLoMin)
        Me.Fix.Controls.Add(Me.Label16)
        Me.Fix.Controls.Add(Me.Label15)
        Me.Fix.Location = New System.Drawing.Point(4, 22)
        Me.Fix.Name = "Fix"
        Me.Fix.Size = New System.Drawing.Size(544, 397)
        Me.Fix.TabIndex = 2
        Me.Fix.Text = "Fix from 2 Bearings"
        Me.Fix.UseVisualStyleBackColor = True
        '
        'chkReciprocal
        '
        Me.chkReciprocal.BackColor = System.Drawing.SystemColors.Window
        Me.chkReciprocal.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkReciprocal.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkReciprocal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkReciprocal.Location = New System.Drawing.Point(197, 43)
        Me.chkReciprocal.Name = "chkReciprocal"
        Me.chkReciprocal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkReciprocal.Size = New System.Drawing.Size(137, 17)
        Me.chkReciprocal.TabIndex = 135
        Me.chkReciprocal.Text = "Use reciprocal bearings"
        Me.chkReciprocal.UseVisualStyleBackColor = False
        '
        'txtFixLo
        '
        Me.txtFixLo.AcceptsReturn = True
        Me.txtFixLo.BackColor = System.Drawing.SystemColors.Window
        Me.txtFixLo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFixLo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFixLo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFixLo.Location = New System.Drawing.Point(253, 199)
        Me.txtFixLo.MaxLength = 0
        Me.txtFixLo.Name = "txtFixLo"
        Me.txtFixLo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFixLo.Size = New System.Drawing.Size(65, 20)
        Me.txtFixLo.TabIndex = 134
        '
        'txtFixL
        '
        Me.txtFixL.AcceptsReturn = True
        Me.txtFixL.BackColor = System.Drawing.SystemColors.Window
        Me.txtFixL.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFixL.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFixL.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFixL.Location = New System.Drawing.Point(253, 178)
        Me.txtFixL.MaxLength = 0
        Me.txtFixL.Name = "txtFixL"
        Me.txtFixL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFixL.Size = New System.Drawing.Size(65, 20)
        Me.txtFixL.TabIndex = 133
        '
        'cmdClearF2
        '
        Me.cmdClearF2.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClearF2.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClearF2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClearF2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClearF2.Location = New System.Drawing.Point(221, 223)
        Me.cmdClearF2.Name = "cmdClearF2"
        Me.cmdClearF2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClearF2.Size = New System.Drawing.Size(73, 25)
        Me.cmdClearF2.TabIndex = 130
        Me.cmdClearF2.Text = "Cle&ar"
        Me.cmdClearF2.UseVisualStyleBackColor = False
        '
        'cmdCalculateF2
        '
        Me.cmdCalculateF2.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCalculateF2.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCalculateF2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCalculateF2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCalculateF2.Location = New System.Drawing.Point(157, 143)
        Me.cmdCalculateF2.Name = "cmdCalculateF2"
        Me.cmdCalculateF2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCalculateF2.Size = New System.Drawing.Size(201, 25)
        Me.cmdCalculateF2.TabIndex = 113
        Me.cmdCalculateF2.Text = "Calculate &Fix from Cross Bearings"
        Me.cmdCalculateF2.UseVisualStyleBackColor = False
        '
        'cboL2
        '
        Me.cboL2.BackColor = System.Drawing.SystemColors.Window
        Me.cboL2.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboL2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboL2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboL2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboL2.Items.AddRange(New Object() {"N", "S"})
        Me.cboL2.Location = New System.Drawing.Point(381, 87)
        Me.cboL2.Name = "cboL2"
        Me.cboL2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboL2.Size = New System.Drawing.Size(41, 22)
        Me.cboL2.TabIndex = 109
        '
        'cboLo2
        '
        Me.cboLo2.BackColor = System.Drawing.SystemColors.Window
        Me.cboLo2.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboLo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLo2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLo2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboLo2.Items.AddRange(New Object() {"W", "E"})
        Me.cboLo2.Location = New System.Drawing.Point(381, 111)
        Me.cboLo2.Name = "cboLo2"
        Me.cboLo2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboLo2.Size = New System.Drawing.Size(41, 22)
        Me.cboLo2.TabIndex = 112
        '
        'cboL1
        '
        Me.cboL1.BackColor = System.Drawing.SystemColors.Window
        Me.cboL1.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboL1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboL1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboL1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboL1.Items.AddRange(New Object() {"N", "S"})
        Me.cboL1.Location = New System.Drawing.Point(197, 87)
        Me.cboL1.Name = "cboL1"
        Me.cboL1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboL1.Size = New System.Drawing.Size(41, 22)
        Me.cboL1.TabIndex = 102
        '
        'cboLo1
        '
        Me.cboLo1.BackColor = System.Drawing.SystemColors.Window
        Me.cboLo1.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboLo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLo1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLo1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboLo1.Items.AddRange(New Object() {"W", "E"})
        Me.cboLo1.Location = New System.Drawing.Point(197, 111)
        Me.cboLo1.Name = "cboLo1"
        Me.cboLo1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboLo1.Size = New System.Drawing.Size(41, 22)
        Me.cboLo1.TabIndex = 105
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.SystemColors.Window
        Me.Label28.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label28.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.Location = New System.Drawing.Point(341, 183)
        Me.Label28.Name = "Label28"
        Me.Label28.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label28.Size = New System.Drawing.Size(105, 41)
        Me.Label28.TabIndex = 136
        Me.Label28.Text = "Bearing angular separation outside recommended range."
        Me.Label28.Visible = False
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.SystemColors.Window
        Me.Label27.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label27.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label27.Location = New System.Drawing.Point(205, 200)
        Me.Label27.Name = "Label27"
        Me.Label27.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label27.Size = New System.Drawing.Size(40, 17)
        Me.Label27.TabIndex = 132
        Me.Label27.Text = "Fix Lo"
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.SystemColors.Window
        Me.Label26.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label26.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label26.Location = New System.Drawing.Point(205, 181)
        Me.Label26.Name = "Label26"
        Me.Label26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label26.Size = New System.Drawing.Size(35, 17)
        Me.Label26.TabIndex = 131
        Me.Label26.Text = "Fix L"
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.SystemColors.Window
        Me.Label25.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label25.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label25.Location = New System.Drawing.Point(293, 63)
        Me.Label25.Name = "Label25"
        Me.Label25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label25.Size = New System.Drawing.Size(49, 17)
        Me.Label25.TabIndex = 129
        Me.Label25.Text = "Bearing 2"
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.SystemColors.Window
        Me.Label24.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label24.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label24.Location = New System.Drawing.Point(277, 90)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label24.Size = New System.Drawing.Size(20, 13)
        Me.Label24.TabIndex = 128
        Me.Label24.Text = "L2"
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.SystemColors.Window
        Me.Label23.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label23.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(334, 87)
        Me.Label23.Name = "Label23"
        Me.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label23.Size = New System.Drawing.Size(9, 17)
        Me.Label23.TabIndex = 127
        Me.Label23.Text = "°"
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.SystemColors.Window
        Me.Label22.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label22.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(374, 87)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label22.Size = New System.Drawing.Size(9, 17)
        Me.Label22.TabIndex = 126
        Me.Label22.Text = "'"
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.SystemColors.Window
        Me.Label21.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label21.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(277, 114)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label21.Size = New System.Drawing.Size(25, 13)
        Me.Label21.TabIndex = 125
        Me.Label21.Text = "Lo2"
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.Window
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label20.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(334, 111)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label20.Size = New System.Drawing.Size(9, 17)
        Me.Label20.TabIndex = 124
        Me.Label20.Text = "°"
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.Window
        Me.Label19.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label19.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(374, 111)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label19.Size = New System.Drawing.Size(9, 17)
        Me.Label19.TabIndex = 123
        Me.Label19.Text = "'"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.Window
        Me.Label18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label18.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(382, 63)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(16, 17)
        Me.Label18.TabIndex = 122
        Me.Label18.Text = "°T"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.SystemColors.Window
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label17.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(198, 63)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(16, 17)
        Me.Label17.TabIndex = 121
        Me.Label17.Text = "°T"
        '
        'lblDRL
        '
        Me.lblDRL.BackColor = System.Drawing.SystemColors.Window
        Me.lblDRL.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDRL.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDRL.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDRL.Location = New System.Drawing.Point(93, 90)
        Me.lblDRL.Name = "lblDRL"
        Me.lblDRL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDRL.Size = New System.Drawing.Size(20, 13)
        Me.lblDRL.TabIndex = 120
        Me.lblDRL.Text = "L1"
        '
        'lblLDeg
        '
        Me.lblLDeg.BackColor = System.Drawing.SystemColors.Window
        Me.lblLDeg.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLDeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLDeg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLDeg.Location = New System.Drawing.Point(150, 87)
        Me.lblLDeg.Name = "lblLDeg"
        Me.lblLDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLDeg.Size = New System.Drawing.Size(9, 17)
        Me.lblLDeg.TabIndex = 119
        Me.lblLDeg.Text = "°"
        '
        'lblLMin
        '
        Me.lblLMin.BackColor = System.Drawing.SystemColors.Window
        Me.lblLMin.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLMin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLMin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLMin.Location = New System.Drawing.Point(190, 87)
        Me.lblLMin.Name = "lblLMin"
        Me.lblLMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLMin.Size = New System.Drawing.Size(9, 17)
        Me.lblLMin.TabIndex = 118
        Me.lblLMin.Text = "'"
        '
        'lblDRLo
        '
        Me.lblDRLo.BackColor = System.Drawing.SystemColors.Window
        Me.lblDRLo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDRLo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDRLo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDRLo.Location = New System.Drawing.Point(93, 114)
        Me.lblDRLo.Name = "lblDRLo"
        Me.lblDRLo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDRLo.Size = New System.Drawing.Size(25, 13)
        Me.lblDRLo.TabIndex = 117
        Me.lblDRLo.Text = "Lo1"
        '
        'lblLoDeg
        '
        Me.lblLoDeg.BackColor = System.Drawing.SystemColors.Window
        Me.lblLoDeg.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLoDeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoDeg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLoDeg.Location = New System.Drawing.Point(150, 111)
        Me.lblLoDeg.Name = "lblLoDeg"
        Me.lblLoDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLoDeg.Size = New System.Drawing.Size(9, 17)
        Me.lblLoDeg.TabIndex = 116
        Me.lblLoDeg.Text = "°"
        '
        'lblLoMin
        '
        Me.lblLoMin.BackColor = System.Drawing.SystemColors.Window
        Me.lblLoMin.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLoMin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoMin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLoMin.Location = New System.Drawing.Point(190, 111)
        Me.lblLoMin.Name = "lblLoMin"
        Me.lblLoMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLoMin.Size = New System.Drawing.Size(9, 17)
        Me.lblLoMin.TabIndex = 115
        Me.lblLoMin.Text = "'"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.Window
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(109, 63)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(49, 17)
        Me.Label16.TabIndex = 114
        Me.Label16.Text = "Bearing 1"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Window
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(117, 29)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(289, 17)
        Me.Label15.TabIndex = 98
        Me.Label15.Text = "Calculates a fix from two cross bearings on charted objects."
        '
        'FormTwoBearings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(570, 486)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ExitBtn)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(3, 29)
        Me.MaximizeBox = False
        Me.Name = "FormTwoBearings"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Distance by Two Bearings/Fix by Cross Bearings/CMG by Three Bearings"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.Distance.ResumeLayout(False)
        Me.Distance.PerformLayout()
        Me.Frame1.ResumeLayout(False)
        Me.CMG.ResumeLayout(False)
        Me.CMG.PerformLayout()
        Me.Fix.ResumeLayout(False)
        Me.Fix.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents ExitBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Distance As TabPage
    Friend WithEvents DistanceTxtBx As RichTextBox
    Public WithEvents txtCourse As TextBox
    Public WithEvents Frame1 As GroupBox
    Public WithEvents optComp As RadioButton
    Public WithEvents optMag As RadioButton
    Public WithEvents optTrue As RadioButton
    Public WithEvents optRel As RadioButton
    Public WithEvents cmdClearD As Button
    Public WithEvents txtDist As TextBox
    Public WithEvents txtSpeed As TextBox
    Public WithEvents txtTimeh As TextBox
    Public WithEvents txtTimem As TextBox
    Public WithEvents txtLog1 As TextBox
    Public WithEvents txtLog2 As TextBox
    Public WithEvents txtTime1 As TextBox
    Public WithEvents txtTime2 As TextBox
    Public WithEvents cmdCalculateD As Button
    Public WithEvents txtBearing2 As TextBox
    Public WithEvents txtBearing1 As TextBox
    Public WithEvents lblB2 As Label
    Public WithEvents lblB1 As Label
    Public WithEvents lblCourse As Label
    Public WithEvents lblVesselCourse As Label
    Public WithEvents Label4 As Label
    Public WithEvents lblDistance As Label
    Public WithEvents lblnm As Label
    Public WithEvents lblor As Label
    Public WithEvents lblSpeed As Label
    Public WithEvents lblkn As Label
    Public WithEvents lblTime As Label
    Public WithEvents lblh As Label
    Public WithEvents lblm As Label
    Public WithEvents lblLog1 As Label
    Public WithEvents lblLog2 As Label
    Public WithEvents lblLog1nm As Label
    Public WithEvents lblLog2nm As Label
    Public WithEvents lblTime1 As Label
    Public WithEvents lblTime2 As Label
    Public WithEvents Label3 As Label
    Public WithEvents Label2 As Label
    Public WithEvents Label1 As Label
    Friend WithEvents CMG As TabPage
    Public WithEvents txtResultCourse As TextBox
    Public WithEvents cmdClearC As Button
    Public WithEvents cmdCalculateC As Button
    Public WithEvents txtB1 As TextBox
    Public WithEvents txtI1 As TextBox
    Public WithEvents txtB2 As TextBox
    Public WithEvents txtI2 As TextBox
    Public WithEvents txtB3 As TextBox
    Public WithEvents Label14 As Label
    Public WithEvents Label13 As Label
    Public WithEvents Label12 As Label
    Public WithEvents Label11 As Label
    Public WithEvents Label10 As Label
    Public WithEvents Label6 As Label
    Public WithEvents Label7 As Label
    Public WithEvents Label8 As Label
    Public WithEvents Label9 As Label
    Public WithEvents Label5 As Label
    Friend WithEvents Fix As TabPage
    Public WithEvents chkReciprocal As CheckBox
    Public WithEvents txtFixLo As TextBox
    Public WithEvents txtFixL As TextBox
    Public WithEvents cmdClearF2 As Button
    Public WithEvents cmdCalculateF2 As Button
    Public WithEvents txtL2Min As TextBox
    Public WithEvents cboL2 As ComboBox
    Public WithEvents txtLo2Deg As TextBox
    Public WithEvents txtLo2Min As TextBox
    Public WithEvents cboLo2 As ComboBox
    Public WithEvents txtL2Deg As TextBox
    Public WithEvents txtL1Min As TextBox
    Public WithEvents cboL1 As ComboBox
    Public WithEvents txtLo1Deg As TextBox
    Public WithEvents txtLo1Min As TextBox
    Public WithEvents cboLo1 As ComboBox
    Public WithEvents txtL1Deg As TextBox
    Public WithEvents txtBg2 As TextBox
    Public WithEvents txtBg1 As TextBox
    Public WithEvents Label28 As Label
    Public WithEvents Label27 As Label
    Public WithEvents Label26 As Label
    Public WithEvents Label25 As Label
    Public WithEvents Label24 As Label
    Public WithEvents Label23 As Label
    Public WithEvents Label22 As Label
    Public WithEvents Label21 As Label
    Public WithEvents Label20 As Label
    Public WithEvents Label19 As Label
    Public WithEvents Label18 As Label
    Public WithEvents Label17 As Label
    Public WithEvents lblDRL As Label
    Public WithEvents lblLDeg As Label
    Public WithEvents lblLMin As Label
    Public WithEvents lblDRLo As Label
    Public WithEvents lblLoDeg As Label
    Public WithEvents lblLoMin As Label
    Public WithEvents Label16 As Label
    Public WithEvents Label15 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblT2Fmt As Label
    Friend WithEvents lblT1Fmt As Label
#End Region
End Class