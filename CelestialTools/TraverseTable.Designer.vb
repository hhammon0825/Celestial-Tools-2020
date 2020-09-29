<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TraverseTable
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TraverseTable))
        Me.cboLo1 = New System.Windows.Forms.ComboBox()
        Me.txtLo1Min = New System.Windows.Forms.TextBox()
        Me.txtLo1Deg = New System.Windows.Forms.TextBox()
        Me.txtL1Deg = New System.Windows.Forms.TextBox()
        Me.cboL1 = New System.Windows.Forms.ComboBox()
        Me.txtL1Min = New System.Windows.Forms.TextBox()
        Me.lblDRLo = New System.Windows.Forms.Label()
        Me.lblDRL = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.lblnm = New System.Windows.Forms.Label()
        Me.txtDist = New System.Windows.Forms.TextBox()
        Me.lblDistance = New System.Windows.Forms.Label()
        Me.txtSailings = New System.Windows.Forms.RichTextBox()
        Me.cmdCalculate = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.btnPrintScreen = New System.Windows.Forms.Button()
        Me.lblCourseDeg = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTraverseTbl = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboLo1
        '
        Me.cboLo1.BackColor = System.Drawing.SystemColors.Window
        Me.cboLo1.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboLo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLo1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLo1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboLo1.Items.AddRange(New Object() {"W", "E"})
        Me.cboLo1.Location = New System.Drawing.Point(141, 46)
        Me.cboLo1.Name = "cboLo1"
        Me.cboLo1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboLo1.Size = New System.Drawing.Size(41, 22)
        Me.cboLo1.TabIndex = 54
        '
        'txtLo1Min
        '
        Me.txtLo1Min.AcceptsReturn = True
        Me.txtLo1Min.BackColor = System.Drawing.SystemColors.Window
        Me.txtLo1Min.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLo1Min.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLo1Min.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLo1Min.Location = New System.Drawing.Point(101, 46)
        Me.txtLo1Min.MaxLength = 4
        Me.txtLo1Min.Name = "txtLo1Min"
        Me.txtLo1Min.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLo1Min.Size = New System.Drawing.Size(33, 22)
        Me.txtLo1Min.TabIndex = 53
        Me.txtLo1Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLo1Deg
        '
        Me.txtLo1Deg.AcceptsReturn = True
        Me.txtLo1Deg.BackColor = System.Drawing.SystemColors.Window
        Me.txtLo1Deg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLo1Deg.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLo1Deg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLo1Deg.Location = New System.Drawing.Point(61, 46)
        Me.txtLo1Deg.MaxLength = 3
        Me.txtLo1Deg.Name = "txtLo1Deg"
        Me.txtLo1Deg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLo1Deg.Size = New System.Drawing.Size(33, 22)
        Me.txtLo1Deg.TabIndex = 52
        Me.txtLo1Deg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtL1Deg
        '
        Me.txtL1Deg.AcceptsReturn = True
        Me.txtL1Deg.BackColor = System.Drawing.SystemColors.Window
        Me.txtL1Deg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtL1Deg.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtL1Deg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtL1Deg.Location = New System.Drawing.Point(69, 22)
        Me.txtL1Deg.MaxLength = 2
        Me.txtL1Deg.Name = "txtL1Deg"
        Me.txtL1Deg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtL1Deg.Size = New System.Drawing.Size(25, 22)
        Me.txtL1Deg.TabIndex = 49
        Me.txtL1Deg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboL1
        '
        Me.cboL1.BackColor = System.Drawing.SystemColors.Window
        Me.cboL1.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboL1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboL1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboL1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboL1.Items.AddRange(New Object() {"N", "S"})
        Me.cboL1.Location = New System.Drawing.Point(141, 22)
        Me.cboL1.Name = "cboL1"
        Me.cboL1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboL1.Size = New System.Drawing.Size(41, 22)
        Me.cboL1.TabIndex = 51
        '
        'txtL1Min
        '
        Me.txtL1Min.AcceptsReturn = True
        Me.txtL1Min.BackColor = System.Drawing.SystemColors.Window
        Me.txtL1Min.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtL1Min.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtL1Min.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtL1Min.Location = New System.Drawing.Point(101, 22)
        Me.txtL1Min.MaxLength = 4
        Me.txtL1Min.Name = "txtL1Min"
        Me.txtL1Min.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtL1Min.Size = New System.Drawing.Size(33, 22)
        Me.txtL1Min.TabIndex = 50
        Me.txtL1Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDRLo
        '
        Me.lblDRLo.BackColor = System.Drawing.SystemColors.Window
        Me.lblDRLo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDRLo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDRLo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDRLo.Location = New System.Drawing.Point(4, 48)
        Me.lblDRLo.Name = "lblDRLo"
        Me.lblDRLo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDRLo.Size = New System.Drawing.Size(55, 17)
        Me.lblDRLo.TabIndex = 62
        Me.lblDRLo.Text = "Initial Lo"
        Me.lblDRLo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDRL
        '
        Me.lblDRL.BackColor = System.Drawing.SystemColors.Window
        Me.lblDRL.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDRL.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDRL.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDRL.Location = New System.Drawing.Point(4, 24)
        Me.lblDRL.Name = "lblDRL"
        Me.lblDRL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDRL.Size = New System.Drawing.Size(60, 17)
        Me.lblDRL.TabIndex = 61
        Me.lblDRL.Text = "Initial Lat"
        Me.lblDRL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Window
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(132, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(9, 17)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "'"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Window
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(92, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(9, 17)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "°"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Window
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(132, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(9, 17)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "'"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(92, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(9, 17)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "°"
        '
        'lblCourse
        '
        Me.lblCourse.BackColor = System.Drawing.SystemColors.Window
        Me.lblCourse.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCourse.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourse.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCourse.Location = New System.Drawing.Point(189, 24)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCourse.Size = New System.Drawing.Size(90, 18)
        Me.lblCourse.TabIndex = 76
        Me.lblCourse.Text = "Initial Course"
        Me.lblCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCourse
        '
        Me.txtCourse.AcceptsReturn = True
        Me.txtCourse.BackColor = System.Drawing.SystemColors.Window
        Me.txtCourse.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCourse.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourse.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCourse.Location = New System.Drawing.Point(293, 23)
        Me.txtCourse.MaxLength = 5
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCourse.Size = New System.Drawing.Size(50, 22)
        Me.txtCourse.TabIndex = 75
        Me.txtCourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblnm
        '
        Me.lblnm.BackColor = System.Drawing.SystemColors.Window
        Me.lblnm.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblnm.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblnm.Location = New System.Drawing.Point(344, 50)
        Me.lblnm.Name = "lblnm"
        Me.lblnm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblnm.Size = New System.Drawing.Size(30, 17)
        Me.lblnm.TabIndex = 80
        Me.lblnm.Text = "nm"
        Me.lblnm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDist
        '
        Me.txtDist.AcceptsReturn = True
        Me.txtDist.BackColor = System.Drawing.SystemColors.Window
        Me.txtDist.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDist.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDist.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDist.Location = New System.Drawing.Point(293, 48)
        Me.txtDist.MaxLength = 7
        Me.txtDist.Name = "txtDist"
        Me.txtDist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDist.Size = New System.Drawing.Size(50, 22)
        Me.txtDist.TabIndex = 78
        Me.txtDist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDistance
        '
        Me.lblDistance.BackColor = System.Drawing.SystemColors.Window
        Me.lblDistance.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDistance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDistance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDistance.Location = New System.Drawing.Point(190, 49)
        Me.lblDistance.Name = "lblDistance"
        Me.lblDistance.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDistance.Size = New System.Drawing.Size(100, 17)
        Me.lblDistance.TabIndex = 79
        Me.lblDistance.Text = "Distance Traveled"
        Me.lblDistance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSailings
        '
        Me.txtSailings.BackColor = System.Drawing.SystemColors.Window
        Me.txtSailings.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSailings.Location = New System.Drawing.Point(3, 71)
        Me.txtSailings.Name = "txtSailings"
        Me.txtSailings.ReadOnly = True
        Me.txtSailings.Size = New System.Drawing.Size(471, 416)
        Me.txtSailings.TabIndex = 108
        Me.txtSailings.Text = ""
        '
        'cmdCalculate
        '
        Me.cmdCalculate.BackColor = System.Drawing.Color.Yellow
        Me.cmdCalculate.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCalculate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCalculate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCalculate.Location = New System.Drawing.Point(401, 40)
        Me.cmdCalculate.Name = "cmdCalculate"
        Me.cmdCalculate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCalculate.Size = New System.Drawing.Size(73, 25)
        Me.cmdCalculate.TabIndex = 107
        Me.cmdCalculate.Text = "Calculate"
        Me.cmdCalculate.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CelestialTools.My.Resources.Resources.ABC_white
        Me.PictureBox1.Location = New System.Drawing.Point(95, 564)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(295, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 112
        Me.PictureBox1.TabStop = False
        '
        'ExitBtn
        '
        Me.ExitBtn.BackColor = System.Drawing.Color.Red
        Me.ExitBtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExitBtn.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ExitBtn.Location = New System.Drawing.Point(401, 564)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ExitBtn.Size = New System.Drawing.Size(73, 25)
        Me.ExitBtn.TabIndex = 111
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = False
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrint.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.Location = New System.Drawing.Point(581, -55)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrint.Size = New System.Drawing.Size(21, 21)
        Me.cmdPrint.TabIndex = 110
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdPrint.UseVisualStyleBackColor = False
        '
        'btnPrintScreen
        '
        Me.btnPrintScreen.BackColor = System.Drawing.SystemColors.Control
        Me.btnPrintScreen.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnPrintScreen.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintScreen.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPrintScreen.Image = CType(resources.GetObject("btnPrintScreen.Image"), System.Drawing.Image)
        Me.btnPrintScreen.Location = New System.Drawing.Point(453, 6)
        Me.btnPrintScreen.Name = "btnPrintScreen"
        Me.btnPrintScreen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnPrintScreen.Size = New System.Drawing.Size(21, 21)
        Me.btnPrintScreen.TabIndex = 113
        Me.btnPrintScreen.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPrintScreen.UseVisualStyleBackColor = False
        '
        'lblCourseDeg
        '
        Me.lblCourseDeg.BackColor = System.Drawing.SystemColors.Window
        Me.lblCourseDeg.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCourseDeg.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourseDeg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCourseDeg.Location = New System.Drawing.Point(345, 25)
        Me.lblCourseDeg.Name = "lblCourseDeg"
        Me.lblCourseDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCourseDeg.Size = New System.Drawing.Size(9, 17)
        Me.lblCourseDeg.TabIndex = 114
        Me.lblCourseDeg.Text = "°"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(357, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(35, 17)
        Me.Label1.TabIndex = 115
        Me.Label1.Text = "True"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTraverseTbl
        '
        Me.txtTraverseTbl.BackColor = System.Drawing.SystemColors.Window
        Me.txtTraverseTbl.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTraverseTbl.Location = New System.Drawing.Point(3, 493)
        Me.txtTraverseTbl.Name = "txtTraverseTbl"
        Me.txtTraverseTbl.ReadOnly = True
        Me.txtTraverseTbl.Size = New System.Drawing.Size(471, 65)
        Me.txtTraverseTbl.TabIndex = 116
        Me.txtTraverseTbl.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(137, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(203, 15)
        Me.Label4.TabIndex = 117
        Me.Label4.Text = "Simplified Traverse Table WorkSheet"
        '
        'TraverseTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 621)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTraverseTbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCourseDeg)
        Me.Controls.Add(Me.btnPrintScreen)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.txtSailings)
        Me.Controls.Add(Me.cmdCalculate)
        Me.Controls.Add(Me.lblnm)
        Me.Controls.Add(Me.txtDist)
        Me.Controls.Add(Me.lblDistance)
        Me.Controls.Add(Me.lblCourse)
        Me.Controls.Add(Me.txtCourse)
        Me.Controls.Add(Me.cboLo1)
        Me.Controls.Add(Me.txtLo1Min)
        Me.Controls.Add(Me.txtLo1Deg)
        Me.Controls.Add(Me.txtL1Deg)
        Me.Controls.Add(Me.cboL1)
        Me.Controls.Add(Me.txtL1Min)
        Me.Controls.Add(Me.lblDRLo)
        Me.Controls.Add(Me.lblDRL)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "TraverseTable"
        Me.Text = "TraverseTable"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents cboLo1 As ComboBox
    Public WithEvents txtLo1Min As TextBox
    Public WithEvents txtLo1Deg As TextBox
    Public WithEvents txtL1Deg As TextBox
    Public WithEvents cboL1 As ComboBox
    Public WithEvents txtL1Min As TextBox
    Public WithEvents lblDRLo As Label
    Public WithEvents lblDRL As Label
    Public WithEvents Label6 As Label
    Public WithEvents Label5 As Label
    Public WithEvents Label3 As Label
    Public WithEvents Label2 As Label
    Public WithEvents lblCourse As Label
    Public WithEvents txtCourse As TextBox
    Public WithEvents lblnm As Label
    Public WithEvents txtDist As TextBox
    Public WithEvents lblDistance As Label
    Friend WithEvents txtSailings As RichTextBox
    Public WithEvents cmdCalculate As Button
    Friend WithEvents PictureBox1 As PictureBox
    Public WithEvents ExitBtn As Button
    Public WithEvents cmdPrint As Button
    Public WithEvents btnPrintScreen As Button
    Public WithEvents lblCourseDeg As Label
    Public WithEvents Label1 As Label
    Friend WithEvents txtTraverseTbl As RichTextBox
    Friend WithEvents Label4 As Label
End Class
