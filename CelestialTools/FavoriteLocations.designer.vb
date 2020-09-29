<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FavoriteLocations
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtSightNum = New System.Windows.Forms.TextBox()
        Me.lblSightNum = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtHE = New System.Windows.Forms.TextBox()
        Me.lblHE = New System.Windows.Forms.Label()
        Me.cboLo = New System.Windows.Forms.ComboBox()
        Me.cboL = New System.Windows.Forms.ComboBox()
        Me.txtLDeg = New System.Windows.Forms.TextBox()
        Me.txtLoMin = New System.Windows.Forms.TextBox()
        Me.txtLoDeg = New System.Windows.Forms.TextBox()
        Me.txtLMin = New System.Windows.Forms.TextBox()
        Me.lblLoMin = New System.Windows.Forms.Label()
        Me.lblLoDeg = New System.Windows.Forms.Label()
        Me.lblDRLo = New System.Windows.Forms.Label()
        Me.lblLMin = New System.Windows.Forms.Label()
        Me.lblLDeg = New System.Windows.Forms.Label()
        Me.lblDRL = New System.Windows.Forms.Label()
        Me.lblHorType = New System.Windows.Forms.Label()
        Me.cbHorizon = New System.Windows.Forms.ComboBox()
        Me.cbHorDistType = New System.Windows.Forms.ComboBox()
        Me.lblDistance = New System.Windows.Forms.Label()
        Me.txtHorDist = New System.Windows.Forms.TextBox()
        Me.chkbxDST = New System.Windows.Forms.CheckBox()
        Me.btnOpenLog = New System.Windows.Forms.Button()
        Me.btnSaveLog = New System.Windows.Forms.Button()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnUpdateExisting = New System.Windows.Forms.Button()
        Me.btnDeleteSight = New System.Windows.Forms.Button()
        Me.btnNewLog = New System.Windows.Forms.Button()
        Me.SEDataGrid = New System.Windows.Forms.DataGridView()
        Me.SightNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PsnName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DRLat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DRLong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SDST = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FromAZ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToAZ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HorType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HorDist = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HorDistType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HSIEFormat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblUSPSSightLog = New System.Windows.Forms.Label()
        Me.lblZD = New System.Windows.Forms.Label()
        Me.cboZD = New System.Windows.Forms.ComboBox()
        Me.btnClearFields = New System.Windows.Forms.Button()
        Me.grpSightButtons = New System.Windows.Forms.GroupBox()
        Me.btnShowSharedLoc = New System.Windows.Forms.Button()
        Me.btnClearShared = New System.Windows.Forms.Button()
        Me.btnUseLocation = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grpFileButtons = New System.Windows.Forms.GroupBox()
        Me.btnSLReport = New System.Windows.Forms.Button()
        Me.btnPrintDG = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.cboHEUnit = New System.Windows.Forms.ComboBox()
        Me.lblHSIEFmt = New System.Windows.Forms.Label()
        Me.cboHSIEFmt = New System.Windows.Forms.ComboBox()
        Me.cboApprxBrg = New System.Windows.Forms.ComboBox()
        Me.lblApprxBrg = New System.Windows.Forms.Label()
        Me.txtFromAZ = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblFromAZ = New System.Windows.Forms.Label()
        Me.txtToAZ = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblToAZ = New System.Windows.Forms.Label()
        Me.chkbxSharedLoc = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.SEDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSightButtons.SuspendLayout()
        Me.grpFileButtons.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(130, 40)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(87, 15)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Location Name"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.HideSelection = False
        Me.txtName.Location = New System.Drawing.Point(227, 38)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(391, 22)
        Me.txtName.TabIndex = 1
        '
        'txtSightNum
        '
        Me.txtSightNum.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSightNum.Location = New System.Drawing.Point(66, 36)
        Me.txtSightNum.Name = "txtSightNum"
        Me.txtSightNum.ReadOnly = True
        Me.txtSightNum.Size = New System.Drawing.Size(60, 22)
        Me.txtSightNum.TabIndex = 5
        Me.txtSightNum.TabStop = False
        '
        'lblSightNum
        '
        Me.lblSightNum.AutoSize = True
        Me.lblSightNum.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSightNum.Location = New System.Drawing.Point(6, 39)
        Me.lblSightNum.Name = "lblSightNum"
        Me.lblSightNum.Size = New System.Drawing.Size(49, 15)
        Me.lblSightNum.TabIndex = 4
        Me.lblSightNum.Text = "Loc No."
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExit.Location = New System.Drawing.Point(915, 96)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'txtHE
        '
        Me.txtHE.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHE.HideSelection = False
        Me.txtHE.Location = New System.Drawing.Point(64, 100)
        Me.txtHE.MaxLength = 4
        Me.txtHE.Name = "txtHE"
        Me.txtHE.Size = New System.Drawing.Size(60, 22)
        Me.txtHE.TabIndex = 90
        '
        'lblHE
        '
        Me.lblHE.AutoSize = True
        Me.lblHE.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHE.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHE.Location = New System.Drawing.Point(37, 103)
        Me.lblHE.Name = "lblHE"
        Me.lblHE.Size = New System.Drawing.Size(23, 15)
        Me.lblHE.TabIndex = 18
        Me.lblHE.Text = "HE"
        '
        'cboLo
        '
        Me.cboLo.BackColor = System.Drawing.SystemColors.Window
        Me.cboLo.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboLo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboLo.Items.AddRange(New Object() {"W", "E"})
        Me.cboLo.Location = New System.Drawing.Point(943, 37)
        Me.cboLo.Name = "cboLo"
        Me.cboLo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboLo.Size = New System.Drawing.Size(41, 23)
        Me.cboLo.TabIndex = 60
        '
        'cboL
        '
        Me.cboL.BackColor = System.Drawing.SystemColors.Window
        Me.cboL.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboL.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboL.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboL.Items.AddRange(New Object() {"N", "S"})
        Me.cboL.Location = New System.Drawing.Point(744, 37)
        Me.cboL.Name = "cboL"
        Me.cboL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboL.Size = New System.Drawing.Size(41, 23)
        Me.cboL.TabIndex = 45
        '
        'txtLDeg
        '
        Me.txtLDeg.AcceptsReturn = True
        Me.txtLDeg.BackColor = System.Drawing.SystemColors.Window
        Me.txtLDeg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLDeg.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLDeg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLDeg.HideSelection = False
        Me.txtLDeg.Location = New System.Drawing.Point(672, 37)
        Me.txtLDeg.MaxLength = 2
        Me.txtLDeg.Name = "txtLDeg"
        Me.txtLDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLDeg.Size = New System.Drawing.Size(25, 22)
        Me.txtLDeg.TabIndex = 35
        '
        'txtLoMin
        '
        Me.txtLoMin.AcceptsReturn = True
        Me.txtLoMin.BackColor = System.Drawing.SystemColors.Window
        Me.txtLoMin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLoMin.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoMin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLoMin.HideSelection = False
        Me.txtLoMin.Location = New System.Drawing.Point(899, 38)
        Me.txtLoMin.MaxLength = 4
        Me.txtLoMin.Name = "txtLoMin"
        Me.txtLoMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLoMin.Size = New System.Drawing.Size(33, 22)
        Me.txtLoMin.TabIndex = 55
        '
        'txtLoDeg
        '
        Me.txtLoDeg.AcceptsReturn = True
        Me.txtLoDeg.BackColor = System.Drawing.SystemColors.Window
        Me.txtLoDeg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLoDeg.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoDeg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLoDeg.HideSelection = False
        Me.txtLoDeg.Location = New System.Drawing.Point(857, 38)
        Me.txtLoDeg.MaxLength = 3
        Me.txtLoDeg.Name = "txtLoDeg"
        Me.txtLoDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLoDeg.Size = New System.Drawing.Size(33, 22)
        Me.txtLoDeg.TabIndex = 50
        '
        'txtLMin
        '
        Me.txtLMin.AcceptsReturn = True
        Me.txtLMin.BackColor = System.Drawing.SystemColors.Window
        Me.txtLMin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLMin.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLMin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLMin.HideSelection = False
        Me.txtLMin.Location = New System.Drawing.Point(704, 37)
        Me.txtLMin.MaxLength = 4
        Me.txtLMin.Name = "txtLMin"
        Me.txtLMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLMin.Size = New System.Drawing.Size(33, 22)
        Me.txtLMin.TabIndex = 40
        '
        'lblLoMin
        '
        Me.lblLoMin.BackColor = System.Drawing.SystemColors.Window
        Me.lblLoMin.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLoMin.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoMin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLoMin.Location = New System.Drawing.Point(932, 39)
        Me.lblLoMin.Name = "lblLoMin"
        Me.lblLoMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLoMin.Size = New System.Drawing.Size(9, 17)
        Me.lblLoMin.TabIndex = 134
        Me.lblLoMin.Text = "'"
        '
        'lblLoDeg
        '
        Me.lblLoDeg.BackColor = System.Drawing.SystemColors.Window
        Me.lblLoDeg.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLoDeg.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoDeg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLoDeg.Location = New System.Drawing.Point(890, 39)
        Me.lblLoDeg.Name = "lblLoDeg"
        Me.lblLoDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLoDeg.Size = New System.Drawing.Size(9, 17)
        Me.lblLoDeg.TabIndex = 133
        Me.lblLoDeg.Text = "°"
        '
        'lblDRLo
        '
        Me.lblDRLo.BackColor = System.Drawing.SystemColors.Control
        Me.lblDRLo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDRLo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDRLo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDRLo.Location = New System.Drawing.Point(791, 41)
        Me.lblDRLo.Name = "lblDRLo"
        Me.lblDRLo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDRLo.Size = New System.Drawing.Size(60, 16)
        Me.lblDRLo.TabIndex = 129
        Me.lblDRLo.Text = "DR Long"
        '
        'lblLMin
        '
        Me.lblLMin.BackColor = System.Drawing.SystemColors.Window
        Me.lblLMin.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLMin.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLMin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLMin.Location = New System.Drawing.Point(737, 36)
        Me.lblLMin.Name = "lblLMin"
        Me.lblLMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLMin.Size = New System.Drawing.Size(9, 17)
        Me.lblLMin.TabIndex = 128
        Me.lblLMin.Text = "'"
        '
        'lblLDeg
        '
        Me.lblLDeg.BackColor = System.Drawing.SystemColors.Window
        Me.lblLDeg.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLDeg.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLDeg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLDeg.Location = New System.Drawing.Point(696, 37)
        Me.lblLDeg.Name = "lblLDeg"
        Me.lblLDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLDeg.Size = New System.Drawing.Size(9, 17)
        Me.lblLDeg.TabIndex = 127
        Me.lblLDeg.Text = "°"
        '
        'lblDRL
        '
        Me.lblDRL.BackColor = System.Drawing.SystemColors.Control
        Me.lblDRL.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDRL.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDRL.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDRL.Location = New System.Drawing.Point(619, 41)
        Me.lblDRL.Name = "lblDRL"
        Me.lblDRL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDRL.Size = New System.Drawing.Size(50, 16)
        Me.lblDRL.TabIndex = 123
        Me.lblDRL.Text = "DR Lat"
        '
        'lblHorType
        '
        Me.lblHorType.AutoSize = True
        Me.lblHorType.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHorType.Location = New System.Drawing.Point(482, 70)
        Me.lblHorType.Name = "lblHorType"
        Me.lblHorType.Size = New System.Drawing.Size(49, 15)
        Me.lblHorType.TabIndex = 137
        Me.lblHorType.Text = "Horizon"
        '
        'cbHorizon
        '
        Me.cbHorizon.BackColor = System.Drawing.SystemColors.Window
        Me.cbHorizon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbHorizon.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbHorizon.FormattingEnabled = True
        Me.cbHorizon.Items.AddRange(New Object() {"Natural", "Dip Short", "Artificial", "Bubble"})
        Me.cbHorizon.Location = New System.Drawing.Point(537, 66)
        Me.cbHorizon.Name = "cbHorizon"
        Me.cbHorizon.Size = New System.Drawing.Size(80, 23)
        Me.cbHorizon.TabIndex = 95
        '
        'cbHorDistType
        '
        Me.cbHorDistType.BackColor = System.Drawing.SystemColors.Window
        Me.cbHorDistType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbHorDistType.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbHorDistType.FormattingEnabled = True
        Me.cbHorDistType.Items.AddRange(New Object() {"Feet", "Yards", "Meters", "Statute Mile", "Nautical Mile"})
        Me.cbHorDistType.Location = New System.Drawing.Point(792, 67)
        Me.cbHorDistType.Name = "cbHorDistType"
        Me.cbHorDistType.Size = New System.Drawing.Size(90, 23)
        Me.cbHorDistType.TabIndex = 105
        Me.cbHorDistType.Visible = False
        '
        'lblDistance
        '
        Me.lblDistance.AutoSize = True
        Me.lblDistance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDistance.Location = New System.Drawing.Point(627, 71)
        Me.lblDistance.Name = "lblDistance"
        Me.lblDistance.Size = New System.Drawing.Size(72, 15)
        Me.lblDistance.TabIndex = 139
        Me.lblDistance.Text = "Ds Distance"
        Me.lblDistance.Visible = False
        '
        'txtHorDist
        '
        Me.txtHorDist.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHorDist.HideSelection = False
        Me.txtHorDist.Location = New System.Drawing.Point(709, 68)
        Me.txtHorDist.MaxLength = 8
        Me.txtHorDist.Name = "txtHorDist"
        Me.txtHorDist.Size = New System.Drawing.Size(75, 22)
        Me.txtHorDist.TabIndex = 100
        Me.txtHorDist.Visible = False
        '
        'chkbxDST
        '
        Me.chkbxDST.AutoSize = True
        Me.chkbxDST.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbxDST.Location = New System.Drawing.Point(168, 68)
        Me.chkbxDST.Name = "chkbxDST"
        Me.chkbxDST.Size = New System.Drawing.Size(50, 19)
        Me.chkbxDST.TabIndex = 25
        Me.chkbxDST.Text = "DST"
        Me.chkbxDST.UseVisualStyleBackColor = True
        '
        'btnOpenLog
        '
        Me.btnOpenLog.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnOpenLog.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenLog.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnOpenLog.Location = New System.Drawing.Point(115, 13)
        Me.btnOpenLog.Name = "btnOpenLog"
        Me.btnOpenLog.Size = New System.Drawing.Size(160, 23)
        Me.btnOpenLog.TabIndex = 145
        Me.btnOpenLog.Text = "Open Existing File"
        Me.btnOpenLog.UseVisualStyleBackColor = False
        '
        'btnSaveLog
        '
        Me.btnSaveLog.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnSaveLog.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveLog.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnSaveLog.Location = New System.Drawing.Point(281, 13)
        Me.btnSaveLog.Name = "btnSaveLog"
        Me.btnSaveLog.Size = New System.Drawing.Size(160, 23)
        Me.btnSaveLog.TabIndex = 146
        Me.btnSaveLog.Text = "Save This File"
        Me.btnSaveLog.UseVisualStyleBackColor = False
        '
        'btnAddNew
        '
        Me.btnAddNew.BackColor = System.Drawing.Color.Yellow
        Me.btnAddNew.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNew.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAddNew.Location = New System.Drawing.Point(32, 12)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(120, 23)
        Me.btnAddNew.TabIndex = 148
        Me.btnAddNew.Text = "Add Location"
        Me.btnAddNew.UseVisualStyleBackColor = False
        '
        'btnUpdateExisting
        '
        Me.btnUpdateExisting.BackColor = System.Drawing.Color.Yellow
        Me.btnUpdateExisting.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateExisting.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnUpdateExisting.Location = New System.Drawing.Point(156, 12)
        Me.btnUpdateExisting.Name = "btnUpdateExisting"
        Me.btnUpdateExisting.Size = New System.Drawing.Size(120, 23)
        Me.btnUpdateExisting.TabIndex = 149
        Me.btnUpdateExisting.Text = "Update Location"
        Me.btnUpdateExisting.UseVisualStyleBackColor = False
        '
        'btnDeleteSight
        '
        Me.btnDeleteSight.BackColor = System.Drawing.Color.Red
        Me.btnDeleteSight.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteSight.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnDeleteSight.Location = New System.Drawing.Point(410, 12)
        Me.btnDeleteSight.Name = "btnDeleteSight"
        Me.btnDeleteSight.Size = New System.Drawing.Size(120, 23)
        Me.btnDeleteSight.TabIndex = 150
        Me.btnDeleteSight.Text = "Delete Location"
        Me.btnDeleteSight.UseVisualStyleBackColor = False
        '
        'btnNewLog
        '
        Me.btnNewLog.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnNewLog.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewLog.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnNewLog.Location = New System.Drawing.Point(448, 13)
        Me.btnNewLog.Name = "btnNewLog"
        Me.btnNewLog.Size = New System.Drawing.Size(160, 23)
        Me.btnNewLog.TabIndex = 151
        Me.btnNewLog.Text = "Start A New File"
        Me.btnNewLog.UseVisualStyleBackColor = False
        '
        'SEDataGrid
        '
        Me.SEDataGrid.AllowUserToAddRows = False
        Me.SEDataGrid.AllowUserToDeleteRows = False
        Me.SEDataGrid.AllowUserToResizeColumns = False
        Me.SEDataGrid.AllowUserToResizeRows = False
        Me.SEDataGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SEDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.SEDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SEDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.SEDataGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SEDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.SEDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SEDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SightNum, Me.PsnName, Me.DRLat, Me.DRLong, Me.ZD, Me.SDST, Me.FromAZ, Me.ToAZ, Me.HorType, Me.HorDist, Me.HE, Me.HorDistType, Me.HSIEFormat})
        Me.SEDataGrid.Location = New System.Drawing.Point(6, 220)
        Me.SEDataGrid.Name = "SEDataGrid"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SEDataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.SEDataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow
        Me.SEDataGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Blue
        Me.SEDataGrid.Size = New System.Drawing.Size(984, 367)
        Me.SEDataGrid.TabIndex = 161
        '
        'SightNum
        '
        Me.SightNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SightNum.Frozen = True
        Me.SightNum.HeaderText = "No"
        Me.SightNum.MaxInputLength = 5
        Me.SightNum.MinimumWidth = 3
        Me.SightNum.Name = "SightNum"
        Me.SightNum.ReadOnly = True
        Me.SightNum.Width = 48
        '
        'PsnName
        '
        Me.PsnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PsnName.HeaderText = "Name"
        Me.PsnName.Name = "PsnName"
        Me.PsnName.ReadOnly = True
        Me.PsnName.Width = 62
        '
        'DRLat
        '
        Me.DRLat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DRLat.HeaderText = "DR Lat"
        Me.DRLat.Name = "DRLat"
        Me.DRLat.ReadOnly = True
        Me.DRLat.Width = 69
        '
        'DRLong
        '
        Me.DRLong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DRLong.HeaderText = "DR Long"
        Me.DRLong.Name = "DRLong"
        Me.DRLong.ReadOnly = True
        Me.DRLong.Width = 80
        '
        'ZD
        '
        Me.ZD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ZD.HeaderText = "ZD"
        Me.ZD.Name = "ZD"
        Me.ZD.Width = 49
        '
        'SDST
        '
        Me.SDST.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.SDST.HeaderText = "DST"
        Me.SDST.MinimumWidth = 3
        Me.SDST.Name = "SDST"
        Me.SDST.ReadOnly = True
        Me.SDST.Width = 56
        '
        'FromAZ
        '
        Me.FromAZ.HeaderText = "From AZ"
        Me.FromAZ.Name = "FromAZ"
        Me.FromAZ.Width = 79
        '
        'ToAZ
        '
        Me.ToAZ.HeaderText = "To AZ"
        Me.ToAZ.Name = "ToAZ"
        Me.ToAZ.Width = 66
        '
        'HorType
        '
        Me.HorType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.HorType.HeaderText = "Horizon"
        Me.HorType.Name = "HorType"
        Me.HorType.ReadOnly = True
        Me.HorType.ToolTipText = "Natural / Dip Short / Artificial / Bubble"
        Me.HorType.Width = 74
        '
        'HorDist
        '
        Me.HorDist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.HorDist.HeaderText = "Ds Distance"
        Me.HorDist.Name = "HorDist"
        Me.HorDist.ReadOnly = True
        Me.HorDist.Width = 97
        '
        'HE
        '
        Me.HE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.HE.HeaderText = "HE"
        Me.HE.Name = "HE"
        Me.HE.ReadOnly = True
        Me.HE.Width = 48
        '
        'HorDistType
        '
        Me.HorDistType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.HorDistType.HeaderText = "Apprx Brg"
        Me.HorDistType.Name = "HorDistType"
        Me.HorDistType.ReadOnly = True
        Me.HorDistType.Width = 87
        '
        'HSIEFormat
        '
        Me.HSIEFormat.HeaderText = "hs/IE Fmt"
        Me.HSIEFormat.Name = "HSIEFormat"
        Me.HSIEFormat.Width = 83
        '
        'lblUSPSSightLog
        '
        Me.lblUSPSSightLog.AutoSize = True
        Me.lblUSPSSightLog.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUSPSSightLog.Location = New System.Drawing.Point(348, 9)
        Me.lblUSPSSightLog.Name = "lblUSPSSightLog"
        Me.lblUSPSSightLog.Size = New System.Drawing.Size(304, 22)
        Me.lblUSPSSightLog.TabIndex = 162
        Me.lblUSPSSightLog.Text = "Favorite Locations and Defaults"
        '
        'lblZD
        '
        Me.lblZD.AutoSize = True
        Me.lblZD.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZD.Location = New System.Drawing.Point(37, 68)
        Me.lblZD.Name = "lblZD"
        Me.lblZD.Size = New System.Drawing.Size(24, 15)
        Me.lblZD.TabIndex = 163
        Me.lblZD.Text = "ZD"
        '
        'cboZD
        '
        Me.cboZD.BackColor = System.Drawing.SystemColors.Window
        Me.cboZD.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboZD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboZD.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboZD.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboZD.Location = New System.Drawing.Point(64, 64)
        Me.cboZD.Name = "cboZD"
        Me.cboZD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboZD.Size = New System.Drawing.Size(95, 23)
        Me.cboZD.TabIndex = 32
        '
        'btnClearFields
        '
        Me.btnClearFields.BackColor = System.Drawing.Color.Yellow
        Me.btnClearFields.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearFields.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnClearFields.Location = New System.Drawing.Point(280, 12)
        Me.btnClearFields.Name = "btnClearFields"
        Me.btnClearFields.Size = New System.Drawing.Size(120, 23)
        Me.btnClearFields.TabIndex = 164
        Me.btnClearFields.Text = "Clear Fields"
        Me.btnClearFields.UseVisualStyleBackColor = False
        '
        'grpSightButtons
        '
        Me.grpSightButtons.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.grpSightButtons.Controls.Add(Me.btnShowSharedLoc)
        Me.grpSightButtons.Controls.Add(Me.btnClearShared)
        Me.grpSightButtons.Controls.Add(Me.btnUseLocation)
        Me.grpSightButtons.Controls.Add(Me.Label4)
        Me.grpSightButtons.Controls.Add(Me.btnClearFields)
        Me.grpSightButtons.Controls.Add(Me.btnAddNew)
        Me.grpSightButtons.Controls.Add(Me.btnUpdateExisting)
        Me.grpSightButtons.Controls.Add(Me.btnDeleteSight)
        Me.grpSightButtons.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSightButtons.Location = New System.Drawing.Point(6, 170)
        Me.grpSightButtons.Name = "grpSightButtons"
        Me.grpSightButtons.Size = New System.Drawing.Size(984, 44)
        Me.grpSightButtons.TabIndex = 166
        Me.grpSightButtons.TabStop = False
        Me.grpSightButtons.Text = "Location Actions"
        '
        'btnShowSharedLoc
        '
        Me.btnShowSharedLoc.BackColor = System.Drawing.Color.Blue
        Me.btnShowSharedLoc.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowSharedLoc.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnShowSharedLoc.Location = New System.Drawing.Point(826, 12)
        Me.btnShowSharedLoc.Name = "btnShowSharedLoc"
        Me.btnShowSharedLoc.Size = New System.Drawing.Size(140, 23)
        Me.btnShowSharedLoc.TabIndex = 172
        Me.btnShowSharedLoc.Text = "Show Shared Loc"
        Me.btnShowSharedLoc.UseVisualStyleBackColor = False
        '
        'btnClearShared
        '
        Me.btnClearShared.BackColor = System.Drawing.Color.Blue
        Me.btnClearShared.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearShared.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnClearShared.Location = New System.Drawing.Point(683, 12)
        Me.btnClearShared.Name = "btnClearShared"
        Me.btnClearShared.Size = New System.Drawing.Size(140, 23)
        Me.btnClearShared.TabIndex = 171
        Me.btnClearShared.Text = "Clear Shared Loc"
        Me.btnClearShared.UseVisualStyleBackColor = False
        '
        'btnUseLocation
        '
        Me.btnUseLocation.BackColor = System.Drawing.Color.Blue
        Me.btnUseLocation.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUseLocation.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnUseLocation.Location = New System.Drawing.Point(539, 12)
        Me.btnUseLocation.Name = "btnUseLocation"
        Me.btnUseLocation.Size = New System.Drawing.Size(140, 23)
        Me.btnUseLocation.TabIndex = 170
        Me.btnUseLocation.Text = "Share Location"
        Me.btnUseLocation.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Window
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(305, -53)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(9, 17)
        Me.Label4.TabIndex = 169
        Me.Label4.Text = "'"
        '
        'grpFileButtons
        '
        Me.grpFileButtons.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.grpFileButtons.Controls.Add(Me.btnSLReport)
        Me.grpFileButtons.Controls.Add(Me.btnPrintDG)
        Me.grpFileButtons.Controls.Add(Me.btnOpenLog)
        Me.grpFileButtons.Controls.Add(Me.btnSaveLog)
        Me.grpFileButtons.Controls.Add(Me.btnNewLog)
        Me.grpFileButtons.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFileButtons.Location = New System.Drawing.Point(6, 126)
        Me.grpFileButtons.Name = "grpFileButtons"
        Me.grpFileButtons.Size = New System.Drawing.Size(984, 40)
        Me.grpFileButtons.TabIndex = 167
        Me.grpFileButtons.TabStop = False
        Me.grpFileButtons.Text = "Sight File Actions"
        '
        'btnSLReport
        '
        Me.btnSLReport.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnSLReport.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSLReport.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnSLReport.Location = New System.Drawing.Point(780, 13)
        Me.btnSLReport.Name = "btnSLReport"
        Me.btnSLReport.Size = New System.Drawing.Size(160, 23)
        Me.btnSLReport.TabIndex = 153
        Me.btnSLReport.Text = "Save Location Report"
        Me.btnSLReport.UseVisualStyleBackColor = False
        Me.btnSLReport.Visible = False
        '
        'btnPrintDG
        '
        Me.btnPrintDG.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnPrintDG.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintDG.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnPrintDG.Location = New System.Drawing.Point(615, 13)
        Me.btnPrintDG.Name = "btnPrintDG"
        Me.btnPrintDG.Size = New System.Drawing.Size(160, 23)
        Me.btnPrintDG.TabIndex = 152
        Me.btnPrintDG.Text = "Print Location Data"
        Me.btnPrintDG.UseVisualStyleBackColor = False
        Me.btnPrintDG.Visible = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        Me.PrintDocument1.DocumentName = "Sight Log "
        '
        'cboHEUnit
        '
        Me.cboHEUnit.BackColor = System.Drawing.SystemColors.Window
        Me.cboHEUnit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboHEUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHEUnit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboHEUnit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboHEUnit.Items.AddRange(New Object() {"ft", "in", "m", "cm"})
        Me.cboHEUnit.Location = New System.Drawing.Point(129, 99)
        Me.cboHEUnit.Name = "cboHEUnit"
        Me.cboHEUnit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboHEUnit.Size = New System.Drawing.Size(41, 23)
        Me.cboHEUnit.TabIndex = 172
        '
        'lblHSIEFmt
        '
        Me.lblHSIEFmt.AutoSize = True
        Me.lblHSIEFmt.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHSIEFmt.Location = New System.Drawing.Point(331, 103)
        Me.lblHSIEFmt.Name = "lblHSIEFmt"
        Me.lblHSIEFmt.Size = New System.Drawing.Size(75, 15)
        Me.lblHSIEFmt.TabIndex = 179
        Me.lblHSIEFmt.Text = "hs/IE Format"
        '
        'cboHSIEFmt
        '
        Me.cboHSIEFmt.BackColor = System.Drawing.SystemColors.Window
        Me.cboHSIEFmt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHSIEFmt.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboHSIEFmt.FormattingEnabled = True
        Me.cboHSIEFmt.Items.AddRange(New Object() {"DM", "DMS"})
        Me.cboHSIEFmt.Location = New System.Drawing.Point(420, 100)
        Me.cboHSIEFmt.Name = "cboHSIEFmt"
        Me.cboHSIEFmt.Size = New System.Drawing.Size(70, 23)
        Me.cboHSIEFmt.TabIndex = 180
        '
        'cboApprxBrg
        '
        Me.cboApprxBrg.BackColor = System.Drawing.SystemColors.Window
        Me.cboApprxBrg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboApprxBrg.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboApprxBrg.FormattingEnabled = True
        Me.cboApprxBrg.Items.AddRange(New Object() {"N", "NE", "E", "SE", "S", "SW", "W", "NW", "None"})
        Me.cboApprxBrg.Location = New System.Drawing.Point(254, 100)
        Me.cboApprxBrg.Name = "cboApprxBrg"
        Me.cboApprxBrg.Size = New System.Drawing.Size(70, 23)
        Me.cboApprxBrg.TabIndex = 182
        '
        'lblApprxBrg
        '
        Me.lblApprxBrg.AutoSize = True
        Me.lblApprxBrg.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApprxBrg.Location = New System.Drawing.Point(178, 103)
        Me.lblApprxBrg.Name = "lblApprxBrg"
        Me.lblApprxBrg.Size = New System.Drawing.Size(62, 15)
        Me.lblApprxBrg.TabIndex = 181
        Me.lblApprxBrg.Text = "Apprx Brg"
        '
        'txtFromAZ
        '
        Me.txtFromAZ.AcceptsReturn = True
        Me.txtFromAZ.BackColor = System.Drawing.SystemColors.Window
        Me.txtFromAZ.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFromAZ.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFromAZ.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFromAZ.HideSelection = False
        Me.txtFromAZ.Location = New System.Drawing.Point(310, 65)
        Me.txtFromAZ.MaxLength = 3
        Me.txtFromAZ.Name = "txtFromAZ"
        Me.txtFromAZ.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFromAZ.Size = New System.Drawing.Size(30, 22)
        Me.txtFromAZ.TabIndex = 186
        Me.txtFromAZ.Text = "0"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(342, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(9, 17)
        Me.Label2.TabIndex = 188
        Me.Label2.Text = "°"
        '
        'LblFromAZ
        '
        Me.LblFromAZ.BackColor = System.Drawing.SystemColors.Control
        Me.LblFromAZ.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblFromAZ.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFromAZ.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblFromAZ.Location = New System.Drawing.Point(221, 69)
        Me.LblFromAZ.Name = "LblFromAZ"
        Me.LblFromAZ.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblFromAZ.Size = New System.Drawing.Size(95, 16)
        Me.LblFromAZ.TabIndex = 187
        Me.LblFromAZ.Text = "From Azimuth"
        '
        'txtToAZ
        '
        Me.txtToAZ.BackColor = System.Drawing.SystemColors.Window
        Me.txtToAZ.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtToAZ.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtToAZ.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtToAZ.HideSelection = False
        Me.txtToAZ.Location = New System.Drawing.Point(427, 65)
        Me.txtToAZ.MaxLength = 3
        Me.txtToAZ.Name = "txtToAZ"
        Me.txtToAZ.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtToAZ.Size = New System.Drawing.Size(30, 22)
        Me.txtToAZ.TabIndex = 189
        Me.txtToAZ.Text = "360"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Window
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(459, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(9, 17)
        Me.Label3.TabIndex = 191
        Me.Label3.Text = "°"
        '
        'lblToAZ
        '
        Me.lblToAZ.BackColor = System.Drawing.SystemColors.Control
        Me.lblToAZ.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblToAZ.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToAZ.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblToAZ.Location = New System.Drawing.Point(351, 69)
        Me.lblToAZ.Name = "lblToAZ"
        Me.lblToAZ.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblToAZ.Size = New System.Drawing.Size(75, 16)
        Me.lblToAZ.TabIndex = 190
        Me.lblToAZ.Text = "To Azimuth"
        '
        'chkbxSharedLoc
        '
        Me.chkbxSharedLoc.AutoSize = True
        Me.chkbxSharedLoc.Enabled = False
        Me.chkbxSharedLoc.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbxSharedLoc.Location = New System.Drawing.Point(505, 101)
        Me.chkbxSharedLoc.Name = "chkbxSharedLoc"
        Me.chkbxSharedLoc.Size = New System.Drawing.Size(113, 19)
        Me.chkbxSharedLoc.TabIndex = 192
        Me.chkbxSharedLoc.Text = "Location Shared"
        Me.chkbxSharedLoc.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CelestialTools.My.Resources.Resources.ABC_white
        Me.PictureBox1.Location = New System.Drawing.Point(9, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(222, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 193
        Me.PictureBox1.TabStop = False
        '
        'FavoriteLocations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1002, 590)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.chkbxSharedLoc)
        Me.Controls.Add(Me.txtToAZ)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblToAZ)
        Me.Controls.Add(Me.txtFromAZ)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblFromAZ)
        Me.Controls.Add(Me.cboHSIEFmt)
        Me.Controls.Add(Me.lblHSIEFmt)
        Me.Controls.Add(Me.cboApprxBrg)
        Me.Controls.Add(Me.lblApprxBrg)
        Me.Controls.Add(Me.cboHEUnit)
        Me.Controls.Add(Me.grpFileButtons)
        Me.Controls.Add(Me.grpSightButtons)
        Me.Controls.Add(Me.cboZD)
        Me.Controls.Add(Me.lblZD)
        Me.Controls.Add(Me.lblUSPSSightLog)
        Me.Controls.Add(Me.SEDataGrid)
        Me.Controls.Add(Me.chkbxDST)
        Me.Controls.Add(Me.txtHorDist)
        Me.Controls.Add(Me.cbHorDistType)
        Me.Controls.Add(Me.lblDistance)
        Me.Controls.Add(Me.cbHorizon)
        Me.Controls.Add(Me.lblHorType)
        Me.Controls.Add(Me.cboLo)
        Me.Controls.Add(Me.cboL)
        Me.Controls.Add(Me.txtLDeg)
        Me.Controls.Add(Me.txtLoMin)
        Me.Controls.Add(Me.txtLoDeg)
        Me.Controls.Add(Me.txtLMin)
        Me.Controls.Add(Me.lblLoMin)
        Me.Controls.Add(Me.lblLoDeg)
        Me.Controls.Add(Me.lblDRLo)
        Me.Controls.Add(Me.lblLMin)
        Me.Controls.Add(Me.lblLDeg)
        Me.Controls.Add(Me.lblDRL)
        Me.Controls.Add(Me.txtHE)
        Me.Controls.Add(Me.lblHE)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtSightNum)
        Me.Controls.Add(Me.lblSightNum)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Name = "FavoriteLocations"
        Me.Text = "USPS Sight Log"
        CType(Me.SEDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSightButtons.ResumeLayout(False)
        Me.grpFileButtons.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtSightNum As TextBox
    Friend WithEvents lblSightNum As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents txtHE As TextBox
    Friend WithEvents lblHE As Label
    Public WithEvents cboLo As ComboBox
    Public WithEvents cboL As ComboBox
    Public WithEvents txtLDeg As TextBox
    Public WithEvents txtLoMin As TextBox
    Public WithEvents txtLoDeg As TextBox
    Public WithEvents txtLMin As TextBox
    Public WithEvents lblLoMin As Label
    Public WithEvents lblLoDeg As Label
    Public WithEvents lblDRLo As Label
    Public WithEvents lblLMin As Label
    Public WithEvents lblLDeg As Label
    Public WithEvents lblDRL As Label
    Friend WithEvents lblHorType As Label
    Friend WithEvents cbHorizon As ComboBox
    Friend WithEvents cbHorDistType As ComboBox
    Friend WithEvents lblDistance As Label
    Friend WithEvents txtHorDist As TextBox
    Friend WithEvents chkbxDST As CheckBox
    Friend WithEvents btnOpenLog As Button
    Friend WithEvents btnSaveLog As Button
    Friend WithEvents btnAddNew As Button
    Friend WithEvents btnUpdateExisting As Button
    Friend WithEvents btnDeleteSight As Button
    Friend WithEvents btnNewLog As Button
    Friend WithEvents SEDataGrid As DataGridView
    Friend WithEvents lblUSPSSightLog As Label
    Friend WithEvents lblZD As Label
    Public WithEvents cboZD As ComboBox
    Friend WithEvents btnClearFields As Button
    Friend WithEvents grpSightButtons As GroupBox
    Friend WithEvents grpFileButtons As GroupBox
    Friend WithEvents btnPrintDG As Button
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As PrintDocument
    Public WithEvents Label4 As Label
    Public WithEvents cboHEUnit As ComboBox
    Friend WithEvents btnSLReport As Button
    Friend WithEvents lblHSIEFmt As Label
    Friend WithEvents cboHSIEFmt As ComboBox
    Friend WithEvents cboApprxBrg As ComboBox
    Friend WithEvents lblApprxBrg As Label
    Public WithEvents txtFromAZ As TextBox
    Public WithEvents Label2 As Label
    Public WithEvents LblFromAZ As Label
    Public WithEvents txtToAZ As TextBox
    Public WithEvents Label3 As Label
    Public WithEvents lblToAZ As Label
    Friend WithEvents SightNum As DataGridViewTextBoxColumn
    Friend WithEvents PsnName As DataGridViewTextBoxColumn
    Friend WithEvents DRLat As DataGridViewTextBoxColumn
    Friend WithEvents DRLong As DataGridViewTextBoxColumn
    Friend WithEvents ZD As DataGridViewTextBoxColumn
    Friend WithEvents SDST As DataGridViewTextBoxColumn
    Friend WithEvents FromAZ As DataGridViewTextBoxColumn
    Friend WithEvents ToAZ As DataGridViewTextBoxColumn
    Friend WithEvents HorType As DataGridViewTextBoxColumn
    Friend WithEvents HorDist As DataGridViewTextBoxColumn
    Friend WithEvents HE As DataGridViewTextBoxColumn
    Friend WithEvents HorDistType As DataGridViewTextBoxColumn
    Friend WithEvents HSIEFormat As DataGridViewTextBoxColumn
    Friend WithEvents btnUseLocation As Button
    Friend WithEvents btnClearShared As Button
    Friend WithEvents chkbxSharedLoc As CheckBox
    Friend WithEvents btnShowSharedLoc As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
