<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SightLog
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtSquadron = New System.Windows.Forms.TextBox()
        Me.lblSquadron = New System.Windows.Forms.Label()
        Me.txtSightNum = New System.Windows.Forms.TextBox()
        Me.lblSightNum = New System.Windows.Forms.Label()
        Me.SightDateTime = New System.Windows.Forms.DateTimePicker()
        Me.lblSightDate = New System.Windows.Forms.Label()
        Me.lblWE = New System.Windows.Forms.Label()
        Me.txtWE = New System.Windows.Forms.TextBox()
        Me.cbWEType = New System.Windows.Forms.ComboBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.cbIEType = New System.Windows.Forms.ComboBox()
        Me.txtIE = New System.Windows.Forms.TextBox()
        Me.txtHE = New System.Windows.Forms.TextBox()
        Me.lblHE = New System.Windows.Forms.Label()
        Me.cboLo = New System.Windows.Forms.ComboBox()
        Me.cboL = New System.Windows.Forms.ComboBox()
        Me.txtLDeg = New System.Windows.Forms.TextBox()
        Me.txtLoMin = New System.Windows.Forms.TextBox()
        Me.txtLoDeg = New System.Windows.Forms.TextBox()
        Me.txtLMin = New System.Windows.Forms.TextBox()
        Me.cboBody = New System.Windows.Forms.ComboBox()
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
        Me.txtRemarks = New System.Windows.Forms.RichTextBox()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnUpdateExisting = New System.Windows.Forms.Button()
        Me.btnDeleteSight = New System.Windows.Forms.Button()
        Me.btnNewLog = New System.Windows.Forms.Button()
        Me.btnSightReduce = New System.Windows.Forms.Button()
        Me.cbLimb = New System.Windows.Forms.ComboBox()
        Me.lblLimb = New System.Windows.Forms.Label()
        Me.txtHSDeg = New System.Windows.Forms.TextBox()
        Me.txtHSMin = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lvlHS = New System.Windows.Forms.Label()
        Me.txtIntZn = New System.Windows.Forms.TextBox()
        Me.SEDataGrid = New System.Windows.Forms.DataGridView()
        Me.SightNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SDateTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BodyName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BodyLimb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SDST = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SWE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SWEType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HorType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HorDist = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HorDistType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ICType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DRLat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DRLong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LLoBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Intercept = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Aziumuth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PsnName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Squadron = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WTDiff = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HSDiff = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HSWTRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SRGHA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SRDec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SRHo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserInfo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblUSPSSightLog = New System.Windows.Forms.Label()
        Me.lblZD = New System.Windows.Forms.Label()
        Me.cboZD = New System.Windows.Forms.ComboBox()
        Me.btnClearFields = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grpSightButtons = New System.Windows.Forms.GroupBox()
        Me.btnPlanSight = New System.Windows.Forms.Button()
        Me.btnCustomPlot = New System.Windows.Forms.Button()
        Me.btnUseCLS = New System.Windows.Forms.Button()
        Me.btnNoonSight = New System.Windows.Forms.Button()
        Me.btnAltSR = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSLReport = New System.Windows.Forms.Button()
        Me.btnPrintDG = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.lblBodyNm = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtIEDeg = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblIE = New System.Windows.Forms.Label()
        Me.cboHEUnit = New System.Windows.Forms.ComboBox()
        Me.lblSRFEP = New System.Windows.Forms.Label()
        Me.txtSRFEP = New System.Windows.Forms.TextBox()
        Me.txtHsSec = New System.Windows.Forms.TextBox()
        Me.lblHsSec = New System.Windows.Forms.Label()
        Me.txtIESec = New System.Windows.Forms.TextBox()
        Me.lblIEsec = New System.Windows.Forms.Label()
        Me.lblHSIEFmt = New System.Windows.Forms.Label()
        Me.cboHSIEFmt = New System.Windows.Forms.ComboBox()
        Me.cboApprxBrg = New System.Windows.Forms.ComboBox()
        Me.lblApprxBrg = New System.Windows.Forms.Label()
        Me.CheckBoxShowAvg = New System.Windows.Forms.CheckBox()
        Me.CheckBoxAutoReduce = New System.Windows.Forms.CheckBox()
        Me.SLOptions = New System.Windows.Forms.GroupBox()
        Me.chkDispGHADecHo = New System.Windows.Forms.CheckBox()
        Me.chkClearFields = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblSRGHA = New System.Windows.Forms.Label()
        Me.txtSRGHA = New System.Windows.Forms.TextBox()
        Me.lblSRDec = New System.Windows.Forms.Label()
        Me.txtSRDec = New System.Windows.Forms.TextBox()
        Me.lblSRHo = New System.Windows.Forms.Label()
        Me.txtSRHo = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtUserInfo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.grpFileButtons = New System.Windows.Forms.GroupBox()
        Me.btnSaveLogAsTxt = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.cboLLoBy = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.SEDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSightButtons.SuspendLayout()
        Me.SLOptions.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpFileButtons.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(139, 89)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(37, 15)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.HideSelection = False
        Me.txtName.Location = New System.Drawing.Point(187, 86)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(250, 22)
        Me.txtName.TabIndex = 1
        '
        'txtSquadron
        '
        Me.txtSquadron.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSquadron.HideSelection = False
        Me.txtSquadron.Location = New System.Drawing.Point(513, 87)
        Me.txtSquadron.Name = "txtSquadron"
        Me.txtSquadron.Size = New System.Drawing.Size(250, 22)
        Me.txtSquadron.TabIndex = 5
        '
        'lblSquadron
        '
        Me.lblSquadron.AutoSize = True
        Me.lblSquadron.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSquadron.Location = New System.Drawing.Point(445, 90)
        Me.lblSquadron.Name = "lblSquadron"
        Me.lblSquadron.Size = New System.Drawing.Size(59, 15)
        Me.lblSquadron.TabIndex = 2
        Me.lblSquadron.Text = "Squadron"
        Me.lblSquadron.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSightNum
        '
        Me.txtSightNum.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSightNum.Location = New System.Drawing.Point(71, 86)
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
        Me.lblSightNum.Location = New System.Drawing.Point(6, 89)
        Me.lblSightNum.Name = "lblSightNum"
        Me.lblSightNum.Size = New System.Drawing.Size(57, 15)
        Me.lblSightNum.TabIndex = 4
        Me.lblSightNum.Text = "Sight No."
        Me.lblSightNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SightDateTime
        '
        Me.SightDateTime.CustomFormat = "MM/dd/yyyy HH:mm:ss "
        Me.SightDateTime.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SightDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.SightDateTime.Location = New System.Drawing.Point(100, 115)
        Me.SightDateTime.Name = "SightDateTime"
        Me.SightDateTime.ShowUpDown = True
        Me.SightDateTime.Size = New System.Drawing.Size(155, 22)
        Me.SightDateTime.TabIndex = 10
        Me.SightDateTime.Value = New Date(2017, 6, 7, 0, 0, 0, 0)
        '
        'lblSightDate
        '
        Me.lblSightDate.AutoSize = True
        Me.lblSightDate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSightDate.Location = New System.Drawing.Point(6, 118)
        Me.lblSightDate.Name = "lblSightDate"
        Me.lblSightDate.Size = New System.Drawing.Size(93, 15)
        Me.lblSightDate.TabIndex = 7
        Me.lblSightDate.Text = "Sight Date/Time"
        Me.lblSightDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWE
        '
        Me.lblWE.AutoSize = True
        Me.lblWE.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWE.Location = New System.Drawing.Point(262, 119)
        Me.lblWE.Name = "lblWE"
        Me.lblWE.Size = New System.Drawing.Size(68, 15)
        Me.lblWE.TabIndex = 11
        Me.lblWE.Text = "WE (mmss)"
        Me.lblWE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtWE
        '
        Me.txtWE.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWE.HideSelection = False
        Me.txtWE.Location = New System.Drawing.Point(334, 116)
        Me.txtWE.MaxLength = 4
        Me.txtWE.Name = "txtWE"
        Me.txtWE.Size = New System.Drawing.Size(59, 22)
        Me.txtWE.TabIndex = 15
        '
        'cbWEType
        '
        Me.cbWEType.BackColor = System.Drawing.SystemColors.Window
        Me.cbWEType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbWEType.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbWEType.FormattingEnabled = True
        Me.cbWEType.Items.AddRange(New Object() {"Fast", "Slow"})
        Me.cbWEType.Location = New System.Drawing.Point(395, 115)
        Me.cbWEType.Name = "cbWEType"
        Me.cbWEType.Size = New System.Drawing.Size(100, 23)
        Me.cbWEType.TabIndex = 20
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExit.Location = New System.Drawing.Point(1253, 87)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'cbIEType
        '
        Me.cbIEType.BackColor = System.Drawing.SystemColors.Window
        Me.cbIEType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbIEType.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbIEType.FormattingEnabled = True
        Me.cbIEType.Items.AddRange(New Object() {"On Arc (-)", "Off Arc (+)"})
        Me.cbIEType.Location = New System.Drawing.Point(741, 148)
        Me.cbIEType.Name = "cbIEType"
        Me.cbIEType.Size = New System.Drawing.Size(90, 23)
        Me.cbIEType.TabIndex = 80
        '
        'txtIE
        '
        Me.txtIE.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIE.HideSelection = False
        Me.txtIE.Location = New System.Drawing.Point(652, 148)
        Me.txtIE.MaxLength = 4
        Me.txtIE.Name = "txtIE"
        Me.txtIE.Size = New System.Drawing.Size(35, 22)
        Me.txtIE.TabIndex = 75
        '
        'txtHE
        '
        Me.txtHE.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHE.HideSelection = False
        Me.txtHE.Location = New System.Drawing.Point(860, 147)
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
        Me.lblHE.Location = New System.Drawing.Point(833, 151)
        Me.lblHE.Name = "lblHE"
        Me.lblHE.Size = New System.Drawing.Size(23, 15)
        Me.lblHE.TabIndex = 18
        Me.lblHE.Text = "HE"
        Me.lblHE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboLo
        '
        Me.cboLo.BackColor = System.Drawing.SystemColors.Window
        Me.cboLo.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboLo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboLo.Items.AddRange(New Object() {"W", "E"})
        Me.cboLo.Location = New System.Drawing.Point(331, 147)
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
        Me.cboL.Location = New System.Drawing.Point(132, 147)
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
        Me.txtLDeg.Location = New System.Drawing.Point(60, 147)
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
        Me.txtLoMin.Location = New System.Drawing.Point(287, 148)
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
        Me.txtLoDeg.Location = New System.Drawing.Point(245, 148)
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
        Me.txtLMin.Location = New System.Drawing.Point(92, 147)
        Me.txtLMin.MaxLength = 4
        Me.txtLMin.Name = "txtLMin"
        Me.txtLMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLMin.Size = New System.Drawing.Size(33, 22)
        Me.txtLMin.TabIndex = 40
        '
        'cboBody
        '
        Me.cboBody.BackColor = System.Drawing.SystemColors.Window
        Me.cboBody.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboBody.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBody.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBody.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboBody.Items.AddRange(New Object() {"Sun", "Moon", "Venus", "Mars", "Jupiter", "Saturn", "Acamar", "Achernar", "Acrux", "Adhara", "Aldebaran", "Alioth", "Alkaid", "Al Na'ir", "Alnilam", "Alphard", "Alphecca", "Alpheratz", "Altair", "Ankaa", "Antares", "Arcturus", "Atria", "Avior", "Bellatrix", "Betelgeuse", "Canopus", "Capella", "Deneb", "Denebola", "Diphda", "Dubhe", "Elnath", "Eltanin", "Enif", "Fomalhaut", "Gacrux", "Gienah", "Hadar", "Hamal", "Kaus Australis", "Kochab", "Markab", "Menkar", "Menkent", "Miaplacidus", "Mirfak", "Nunki", "Peacock", "Polaris", "Pollux", "Procyon", "Rasalhague", "Regulus", "Rigel", "Rigil Kentaurus", "Sabik", "Schedar", "Shaula", "Sirius", "Spica", "Suhail", "Vega", "Zubenelgenubi" & Global.Microsoft.VisualBasic.ChrW(9)})
        Me.cboBody.Location = New System.Drawing.Point(719, 115)
        Me.cboBody.Name = "cboBody"
        Me.cboBody.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboBody.Size = New System.Drawing.Size(175, 23)
        Me.cboBody.TabIndex = 25
        '
        'lblLoMin
        '
        Me.lblLoMin.BackColor = System.Drawing.SystemColors.Window
        Me.lblLoMin.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLoMin.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoMin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLoMin.Location = New System.Drawing.Point(320, 149)
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
        Me.lblLoDeg.Location = New System.Drawing.Point(279, 149)
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
        Me.lblDRLo.Location = New System.Drawing.Point(179, 151)
        Me.lblDRLo.Name = "lblDRLo"
        Me.lblDRLo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDRLo.Size = New System.Drawing.Size(60, 16)
        Me.lblDRLo.TabIndex = 129
        Me.lblDRLo.Text = "DR Long"
        Me.lblDRLo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLMin
        '
        Me.lblLMin.BackColor = System.Drawing.SystemColors.Window
        Me.lblLMin.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLMin.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLMin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLMin.Location = New System.Drawing.Point(125, 146)
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
        Me.lblLDeg.Location = New System.Drawing.Point(85, 147)
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
        Me.lblDRL.Location = New System.Drawing.Point(7, 151)
        Me.lblDRL.Name = "lblDRL"
        Me.lblDRL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDRL.Size = New System.Drawing.Size(50, 16)
        Me.lblDRL.TabIndex = 123
        Me.lblDRL.Text = "DR Lat"
        Me.lblDRL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHorType
        '
        Me.lblHorType.AutoSize = True
        Me.lblHorType.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHorType.Location = New System.Drawing.Point(965, 151)
        Me.lblHorType.Name = "lblHorType"
        Me.lblHorType.Size = New System.Drawing.Size(49, 15)
        Me.lblHorType.TabIndex = 137
        Me.lblHorType.Text = "Horizon"
        Me.lblHorType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbHorizon
        '
        Me.cbHorizon.BackColor = System.Drawing.SystemColors.Window
        Me.cbHorizon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbHorizon.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbHorizon.FormattingEnabled = True
        Me.cbHorizon.Items.AddRange(New Object() {"Natural", "Dip Short", "Artificial", "Bubble"})
        Me.cbHorizon.Location = New System.Drawing.Point(1018, 147)
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
        Me.cbHorDistType.Location = New System.Drawing.Point(1234, 147)
        Me.cbHorDistType.Name = "cbHorDistType"
        Me.cbHorDistType.Size = New System.Drawing.Size(90, 23)
        Me.cbHorDistType.TabIndex = 105
        Me.cbHorDistType.Visible = False
        '
        'lblDistance
        '
        Me.lblDistance.AutoSize = True
        Me.lblDistance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDistance.Location = New System.Drawing.Point(1100, 152)
        Me.lblDistance.Name = "lblDistance"
        Me.lblDistance.Size = New System.Drawing.Size(51, 15)
        Me.lblDistance.TabIndex = 139
        Me.lblDistance.Text = "Dip Dist"
        Me.lblDistance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblDistance.Visible = False
        '
        'txtHorDist
        '
        Me.txtHorDist.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHorDist.HideSelection = False
        Me.txtHorDist.Location = New System.Drawing.Point(1155, 148)
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
        Me.chkbxDST.Location = New System.Drawing.Point(625, 118)
        Me.chkbxDST.Name = "chkbxDST"
        Me.chkbxDST.Size = New System.Drawing.Size(50, 19)
        Me.chkbxDST.TabIndex = 25
        Me.chkbxDST.Text = "DST"
        Me.chkbxDST.UseVisualStyleBackColor = True
        '
        'btnOpenLog
        '
        Me.btnOpenLog.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnOpenLog.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenLog.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnOpenLog.Location = New System.Drawing.Point(136, 12)
        Me.btnOpenLog.Name = "btnOpenLog"
        Me.btnOpenLog.Size = New System.Drawing.Size(120, 23)
        Me.btnOpenLog.TabIndex = 145
        Me.btnOpenLog.Text = "Open Existing Log"
        Me.btnOpenLog.UseVisualStyleBackColor = False
        '
        'btnSaveLog
        '
        Me.btnSaveLog.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnSaveLog.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveLog.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnSaveLog.Location = New System.Drawing.Point(11, 37)
        Me.btnSaveLog.Name = "btnSaveLog"
        Me.btnSaveLog.Size = New System.Drawing.Size(120, 23)
        Me.btnSaveLog.TabIndex = 146
        Me.btnSaveLog.Text = "Save This Log"
        Me.btnSaveLog.UseVisualStyleBackColor = False
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.Location = New System.Drawing.Point(698, 180)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(630, 69)
        Me.txtRemarks.TabIndex = 147
        Me.txtRemarks.Text = "Remarks"
        '
        'btnAddNew
        '
        Me.btnAddNew.BackColor = System.Drawing.Color.Yellow
        Me.btnAddNew.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNew.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAddNew.Location = New System.Drawing.Point(11, 12)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(110, 23)
        Me.btnAddNew.TabIndex = 148
        Me.btnAddNew.Text = "Add Sight"
        Me.btnAddNew.UseVisualStyleBackColor = False
        '
        'btnUpdateExisting
        '
        Me.btnUpdateExisting.BackColor = System.Drawing.Color.Yellow
        Me.btnUpdateExisting.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateExisting.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnUpdateExisting.Location = New System.Drawing.Point(127, 12)
        Me.btnUpdateExisting.Name = "btnUpdateExisting"
        Me.btnUpdateExisting.Size = New System.Drawing.Size(110, 23)
        Me.btnUpdateExisting.TabIndex = 149
        Me.btnUpdateExisting.Text = "Update Sight"
        Me.btnUpdateExisting.UseVisualStyleBackColor = False
        '
        'btnDeleteSight
        '
        Me.btnDeleteSight.BackColor = System.Drawing.Color.Red
        Me.btnDeleteSight.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteSight.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnDeleteSight.Location = New System.Drawing.Point(240, 12)
        Me.btnDeleteSight.Name = "btnDeleteSight"
        Me.btnDeleteSight.Size = New System.Drawing.Size(110, 23)
        Me.btnDeleteSight.TabIndex = 150
        Me.btnDeleteSight.Text = "Delete Sight"
        Me.btnDeleteSight.UseVisualStyleBackColor = False
        '
        'btnNewLog
        '
        Me.btnNewLog.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnNewLog.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewLog.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnNewLog.Location = New System.Drawing.Point(11, 12)
        Me.btnNewLog.Name = "btnNewLog"
        Me.btnNewLog.Size = New System.Drawing.Size(120, 23)
        Me.btnNewLog.TabIndex = 151
        Me.btnNewLog.Text = "Start A New Log"
        Me.btnNewLog.UseVisualStyleBackColor = False
        '
        'btnSightReduce
        '
        Me.btnSightReduce.BackColor = System.Drawing.Color.Blue
        Me.btnSightReduce.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSightReduce.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnSightReduce.Location = New System.Drawing.Point(11, 40)
        Me.btnSightReduce.Name = "btnSightReduce"
        Me.btnSightReduce.Size = New System.Drawing.Size(110, 23)
        Me.btnSightReduce.TabIndex = 152
        Me.btnSightReduce.Text = "Sight Reduction"
        Me.btnSightReduce.UseVisualStyleBackColor = False
        '
        'cbLimb
        '
        Me.cbLimb.BackColor = System.Drawing.SystemColors.Window
        Me.cbLimb.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbLimb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLimb.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLimb.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbLimb.Items.AddRange(New Object() {"Lower", "Upper", "Center"})
        Me.cbLimb.Location = New System.Drawing.Point(937, 115)
        Me.cbLimb.Name = "cbLimb"
        Me.cbLimb.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbLimb.Size = New System.Drawing.Size(100, 23)
        Me.cbLimb.TabIndex = 30
        '
        'lblLimb
        '
        Me.lblLimb.BackColor = System.Drawing.SystemColors.Control
        Me.lblLimb.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLimb.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLimb.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLimb.Location = New System.Drawing.Point(897, 118)
        Me.lblLimb.Name = "lblLimb"
        Me.lblLimb.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLimb.Size = New System.Drawing.Size(38, 17)
        Me.lblLimb.TabIndex = 154
        Me.lblLimb.Text = "Limb"
        Me.lblLimb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtHSDeg
        '
        Me.txtHSDeg.AcceptsReturn = True
        Me.txtHSDeg.BackColor = System.Drawing.SystemColors.Window
        Me.txtHSDeg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHSDeg.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHSDeg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHSDeg.HideSelection = False
        Me.txtHSDeg.Location = New System.Drawing.Point(457, 148)
        Me.txtHSDeg.MaxLength = 2
        Me.txtHSDeg.Name = "txtHSDeg"
        Me.txtHSDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHSDeg.Size = New System.Drawing.Size(30, 22)
        Me.txtHSDeg.TabIndex = 65
        '
        'txtHSMin
        '
        Me.txtHSMin.AcceptsReturn = True
        Me.txtHSMin.BackColor = System.Drawing.SystemColors.Window
        Me.txtHSMin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHSMin.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHSMin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHSMin.HideSelection = False
        Me.txtHSMin.Location = New System.Drawing.Point(497, 148)
        Me.txtHSMin.MaxLength = 4
        Me.txtHSMin.Name = "txtHSMin"
        Me.txtHSMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHSMin.Size = New System.Drawing.Size(33, 22)
        Me.txtHSMin.TabIndex = 70
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(532, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(9, 17)
        Me.Label1.TabIndex = 159
        Me.Label1.Text = "'"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(487, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(9, 17)
        Me.Label2.TabIndex = 158
        Me.Label2.Text = "°"
        '
        'lvlHS
        '
        Me.lvlHS.BackColor = System.Drawing.SystemColors.Control
        Me.lvlHS.Cursor = System.Windows.Forms.Cursors.Default
        Me.lvlHS.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvlHS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lvlHS.Location = New System.Drawing.Point(429, 150)
        Me.lvlHS.Name = "lvlHS"
        Me.lvlHS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lvlHS.Size = New System.Drawing.Size(25, 19)
        Me.lvlHS.TabIndex = 155
        Me.lvlHS.Text = "Hs"
        Me.lvlHS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtIntZn
        '
        Me.txtIntZn.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIntZn.Location = New System.Drawing.Point(83, 19)
        Me.txtIntZn.Name = "txtIntZn"
        Me.txtIntZn.ReadOnly = True
        Me.txtIntZn.Size = New System.Drawing.Size(259, 22)
        Me.txtIntZn.TabIndex = 160
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
        Me.SEDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.SEDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SEDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.SEDataGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SEDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.SEDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SEDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SightNum, Me.SDateTime, Me.BodyName, Me.BodyLimb, Me.SDST, Me.SWE, Me.SWEType, Me.ZD, Me.HS, Me.HorType, Me.HorDist, Me.HorDistType, Me.HE, Me.IC, Me.ICType, Me.DRLat, Me.DRLong, Me.LLoBy, Me.Intercept, Me.Aziumuth, Me.EP, Me.PsnName, Me.Squadron, Me.WTDiff, Me.HSDiff, Me.HSWTRate, Me.Remarks, Me.SRGHA, Me.SRDec, Me.SRHo, Me.UserInfo})
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SEDataGrid.DefaultCellStyle = DataGridViewCellStyle14
        Me.SEDataGrid.Location = New System.Drawing.Point(9, 331)
        Me.SEDataGrid.Name = "SEDataGrid"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SEDataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.SEDataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow
        Me.SEDataGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Blue
        Me.SEDataGrid.Size = New System.Drawing.Size(1320, 432)
        Me.SEDataGrid.TabIndex = 161
        '
        'SightNum
        '
        Me.SightNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SightNum.HeaderText = "No"
        Me.SightNum.MaxInputLength = 5
        Me.SightNum.MinimumWidth = 3
        Me.SightNum.Name = "SightNum"
        Me.SightNum.ReadOnly = True
        Me.SightNum.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SightNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.SightNum.Width = 29
        '
        'SDateTime
        '
        Me.SDateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle12.Format = "MM/dd/yyyy HH:mm:ss"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.SDateTime.DefaultCellStyle = DataGridViewCellStyle12
        Me.SDateTime.HeaderText = "Date/Time"
        Me.SDateTime.MaxInputLength = 22
        Me.SDateTime.Name = "SDateTime"
        Me.SDateTime.ReadOnly = True
        Me.SDateTime.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SDateTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.SDateTime.Width = 68
        '
        'BodyName
        '
        Me.BodyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.BodyName.HeaderText = "Body"
        Me.BodyName.Name = "BodyName"
        Me.BodyName.ReadOnly = True
        Me.BodyName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BodyName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.BodyName.Width = 42
        '
        'BodyLimb
        '
        Me.BodyLimb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.BodyLimb.HeaderText = "Limb"
        Me.BodyLimb.Name = "BodyLimb"
        Me.BodyLimb.ReadOnly = True
        Me.BodyLimb.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BodyLimb.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.BodyLimb.Width = 39
        '
        'SDST
        '
        Me.SDST.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.SDST.HeaderText = "DST"
        Me.SDST.MinimumWidth = 3
        Me.SDST.Name = "SDST"
        Me.SDST.ReadOnly = True
        Me.SDST.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SDST.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.SDST.Width = 37
        '
        'SWE
        '
        Me.SWE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SWE.HeaderText = "WE"
        Me.SWE.Name = "SWE"
        Me.SWE.ReadOnly = True
        Me.SWE.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SWE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.SWE.Width = 33
        '
        'SWEType
        '
        Me.SWEType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SWEType.HeaderText = "F/S"
        Me.SWEType.Name = "SWEType"
        Me.SWEType.ReadOnly = True
        Me.SWEType.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SWEType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.SWEType.Width = 31
        '
        'ZD
        '
        Me.ZD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ZD.HeaderText = "ZD"
        Me.ZD.Name = "ZD"
        Me.ZD.ReadOnly = True
        Me.ZD.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ZD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ZD.Width = 30
        '
        'HS
        '
        Me.HS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.HS.HeaderText = "HS"
        Me.HS.Name = "HS"
        Me.HS.ReadOnly = True
        Me.HS.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.HS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.HS.Width = 29
        '
        'HorType
        '
        Me.HorType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.HorType.HeaderText = "Horizon"
        Me.HorType.Name = "HorType"
        Me.HorType.ReadOnly = True
        Me.HorType.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.HorType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.HorType.ToolTipText = "Natural / Dip Short / Artificial / Bubble"
        Me.HorType.Width = 55
        '
        'HorDist
        '
        Me.HorDist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.HorDist.HeaderText = "Dip Dist"
        Me.HorDist.Name = "HorDist"
        Me.HorDist.ReadOnly = True
        Me.HorDist.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.HorDist.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.HorDist.Width = 57
        '
        'HorDistType
        '
        Me.HorDistType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.HorDistType.HeaderText = "Apprx Brg"
        Me.HorDistType.Name = "HorDistType"
        Me.HorDistType.ReadOnly = True
        Me.HorDistType.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.HorDistType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.HorDistType.Width = 68
        '
        'HE
        '
        Me.HE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.HE.HeaderText = "HE"
        Me.HE.Name = "HE"
        Me.HE.ReadOnly = True
        Me.HE.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.HE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.HE.Width = 29
        '
        'IC
        '
        Me.IC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IC.HeaderText = "IE"
        Me.IC.Name = "IC"
        Me.IC.ReadOnly = True
        Me.IC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.IC.Width = 24
        '
        'ICType
        '
        Me.ICType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ICType.HeaderText = "Arc"
        Me.ICType.MinimumWidth = 4
        Me.ICType.Name = "ICType"
        Me.ICType.ReadOnly = True
        Me.ICType.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ICType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ICType.Width = 33
        '
        'DRLat
        '
        Me.DRLat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DRLat.HeaderText = "Lat"
        Me.DRLat.Name = "DRLat"
        Me.DRLat.ReadOnly = True
        Me.DRLat.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DRLat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DRLat.Width = 30
        '
        'DRLong
        '
        Me.DRLong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DRLong.HeaderText = "Long"
        Me.DRLong.Name = "DRLong"
        Me.DRLong.ReadOnly = True
        Me.DRLong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DRLong.Width = 41
        '
        'LLoBy
        '
        Me.LLoBy.HeaderText = "LLoBy"
        Me.LLoBy.Name = "LLoBy"
        Me.LLoBy.ReadOnly = True
        Me.LLoBy.Width = 68
        '
        'Intercept
        '
        Me.Intercept.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Intercept.HeaderText = "a (nm)"
        Me.Intercept.Name = "Intercept"
        Me.Intercept.ReadOnly = True
        Me.Intercept.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Intercept.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Intercept.Width = 46
        '
        'Aziumuth
        '
        Me.Aziumuth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Aziumuth.HeaderText = "Zn"
        Me.Aziumuth.Name = "Aziumuth"
        Me.Aziumuth.ReadOnly = True
        Me.Aziumuth.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Aziumuth.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Aziumuth.Width = 28
        '
        'EP
        '
        Me.EP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.EP.HeaderText = "SR Est Position"
        Me.EP.Name = "EP"
        Me.EP.ReadOnly = True
        Me.EP.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.EP.Width = 95
        '
        'PsnName
        '
        Me.PsnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PsnName.HeaderText = "Name"
        Me.PsnName.Name = "PsnName"
        Me.PsnName.ReadOnly = True
        Me.PsnName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PsnName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.PsnName.Width = 43
        '
        'Squadron
        '
        Me.Squadron.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Squadron.HeaderText = "Squadron"
        Me.Squadron.Name = "Squadron"
        Me.Squadron.ReadOnly = True
        Me.Squadron.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Squadron.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Squadron.Width = 65
        '
        'WTDiff
        '
        Me.WTDiff.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.WTDiff.HeaderText = "WT diff (sec)"
        Me.WTDiff.Name = "WTDiff"
        Me.WTDiff.ReadOnly = True
        Me.WTDiff.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.WTDiff.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.WTDiff.Visible = False
        '
        'HSDiff
        '
        Me.HSDiff.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.HSDiff.HeaderText = "hs diff (')"
        Me.HSDiff.Name = "HSDiff"
        Me.HSDiff.ReadOnly = True
        Me.HSDiff.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.HSDiff.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.HSDiff.Visible = False
        '
        'HSWTRate
        '
        Me.HSWTRate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.HSWTRate.HeaderText = "hs/WT ('/sec)"
        Me.HSWTRate.Name = "HSWTRate"
        Me.HSWTRate.ReadOnly = True
        Me.HSWTRate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.HSWTRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.HSWTRate.Visible = False
        '
        'Remarks
        '
        Me.Remarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        Me.Remarks.DefaultCellStyle = DataGridViewCellStyle13
        Me.Remarks.HeaderText = "Remarks"
        Me.Remarks.Name = "Remarks"
        Me.Remarks.ReadOnly = True
        Me.Remarks.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Remarks.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Remarks.Width = 58
        '
        'SRGHA
        '
        Me.SRGHA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SRGHA.HeaderText = "SR GHA"
        Me.SRGHA.Name = "SRGHA"
        Me.SRGHA.ReadOnly = True
        Me.SRGHA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.SRGHA.Visible = False
        '
        'SRDec
        '
        Me.SRDec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SRDec.HeaderText = "SR Dec"
        Me.SRDec.Name = "SRDec"
        Me.SRDec.ReadOnly = True
        Me.SRDec.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.SRDec.Visible = False
        '
        'SRHo
        '
        Me.SRHo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SRHo.HeaderText = "SR Ho"
        Me.SRHo.Name = "SRHo"
        Me.SRHo.ReadOnly = True
        Me.SRHo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.SRHo.Visible = False
        '
        'UserInfo
        '
        Me.UserInfo.HeaderText = "User Info"
        Me.UserInfo.Name = "UserInfo"
        Me.UserInfo.ReadOnly = True
        Me.UserInfo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.UserInfo.Width = 63
        '
        'lblUSPSSightLog
        '
        Me.lblUSPSSightLog.AutoSize = True
        Me.lblUSPSSightLog.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUSPSSightLog.Location = New System.Drawing.Point(511, 15)
        Me.lblUSPSSightLog.Name = "lblUSPSSightLog"
        Me.lblUSPSSightLog.Size = New System.Drawing.Size(286, 22)
        Me.lblUSPSSightLog.TabIndex = 162
        Me.lblUSPSSightLog.Text = "Celestial Navigation Sight Log"
        '
        'lblZD
        '
        Me.lblZD.AutoSize = True
        Me.lblZD.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZD.Location = New System.Drawing.Point(499, 119)
        Me.lblZD.Name = "lblZD"
        Me.lblZD.Size = New System.Drawing.Size(24, 15)
        Me.lblZD.TabIndex = 163
        Me.lblZD.Text = "ZD"
        Me.lblZD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboZD
        '
        Me.cboZD.BackColor = System.Drawing.SystemColors.Window
        Me.cboZD.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboZD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboZD.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboZD.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboZD.Location = New System.Drawing.Point(526, 115)
        Me.cboZD.Name = "cboZD"
        Me.cboZD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboZD.Size = New System.Drawing.Size(95, 23)
        Me.cboZD.TabIndex = 32
        '
        'btnClearFields
        '
        Me.btnClearFields.BackColor = System.Drawing.Color.Yellow
        Me.btnClearFields.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearFields.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnClearFields.Location = New System.Drawing.Point(356, 12)
        Me.btnClearFields.Name = "btnClearFields"
        Me.btnClearFields.Size = New System.Drawing.Size(110, 23)
        Me.btnClearFields.TabIndex = 164
        Me.btnClearFields.Text = "Clear Fields"
        Me.btnClearFields.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(4, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(77, 16)
        Me.Label3.TabIndex = 165
        Me.Label3.Text = "SR Int && Az"
        '
        'grpSightButtons
        '
        Me.grpSightButtons.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.grpSightButtons.Controls.Add(Me.btnPlanSight)
        Me.grpSightButtons.Controls.Add(Me.btnCustomPlot)
        Me.grpSightButtons.Controls.Add(Me.btnUseCLS)
        Me.grpSightButtons.Controls.Add(Me.btnNoonSight)
        Me.grpSightButtons.Controls.Add(Me.btnAltSR)
        Me.grpSightButtons.Controls.Add(Me.Label4)
        Me.grpSightButtons.Controls.Add(Me.btnClearFields)
        Me.grpSightButtons.Controls.Add(Me.btnAddNew)
        Me.grpSightButtons.Controls.Add(Me.btnUpdateExisting)
        Me.grpSightButtons.Controls.Add(Me.btnDeleteSight)
        Me.grpSightButtons.Controls.Add(Me.btnSightReduce)
        Me.grpSightButtons.Location = New System.Drawing.Point(698, 255)
        Me.grpSightButtons.Name = "grpSightButtons"
        Me.grpSightButtons.Size = New System.Drawing.Size(630, 70)
        Me.grpSightButtons.TabIndex = 166
        Me.grpSightButtons.TabStop = False
        Me.grpSightButtons.Text = "Sight Actions"
        '
        'btnPlanSight
        '
        Me.btnPlanSight.BackColor = System.Drawing.Color.Gold
        Me.btnPlanSight.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlanSight.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPlanSight.Location = New System.Drawing.Point(356, 40)
        Me.btnPlanSight.Name = "btnPlanSight"
        Me.btnPlanSight.Size = New System.Drawing.Size(110, 23)
        Me.btnPlanSight.TabIndex = 175
        Me.btnPlanSight.Text = "Plan Sight"
        Me.btnPlanSight.UseVisualStyleBackColor = False
        Me.btnPlanSight.Visible = False
        '
        'btnCustomPlot
        '
        Me.btnCustomPlot.BackColor = System.Drawing.Color.Yellow
        Me.btnCustomPlot.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomPlot.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnCustomPlot.Location = New System.Drawing.Point(472, 41)
        Me.btnCustomPlot.Name = "btnCustomPlot"
        Me.btnCustomPlot.Size = New System.Drawing.Size(110, 23)
        Me.btnCustomPlot.TabIndex = 174
        Me.btnCustomPlot.Text = "Custom Plot Form"
        Me.btnCustomPlot.UseVisualStyleBackColor = False
        Me.btnCustomPlot.Visible = False
        '
        'btnUseCLS
        '
        Me.btnUseCLS.BackColor = System.Drawing.Color.Yellow
        Me.btnUseCLS.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUseCLS.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnUseCLS.Location = New System.Drawing.Point(472, 12)
        Me.btnUseCLS.Name = "btnUseCLS"
        Me.btnUseCLS.Size = New System.Drawing.Size(110, 23)
        Me.btnUseCLS.TabIndex = 173
        Me.btnUseCLS.Text = "CLS Form Plot"
        Me.btnUseCLS.UseVisualStyleBackColor = False
        Me.btnUseCLS.Visible = False
        '
        'btnNoonSight
        '
        Me.btnNoonSight.BackColor = System.Drawing.Color.Gold
        Me.btnNoonSight.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNoonSight.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnNoonSight.Location = New System.Drawing.Point(240, 40)
        Me.btnNoonSight.Name = "btnNoonSight"
        Me.btnNoonSight.Size = New System.Drawing.Size(110, 23)
        Me.btnNoonSight.TabIndex = 171
        Me.btnNoonSight.Text = "Noon Sight Form"
        Me.btnNoonSight.UseVisualStyleBackColor = False
        Me.btnNoonSight.Visible = False
        '
        'btnAltSR
        '
        Me.btnAltSR.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnAltSR.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAltSR.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnAltSR.Location = New System.Drawing.Point(127, 40)
        Me.btnAltSR.Name = "btnAltSR"
        Me.btnAltSR.Size = New System.Drawing.Size(110, 23)
        Me.btnAltSR.TabIndex = 170
        Me.btnAltSR.Text = "Alt SR Method"
        Me.btnAltSR.UseVisualStyleBackColor = False
        Me.btnAltSR.Visible = False
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
        'btnSLReport
        '
        Me.btnSLReport.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnSLReport.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSLReport.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnSLReport.Location = New System.Drawing.Point(260, 12)
        Me.btnSLReport.Name = "btnSLReport"
        Me.btnSLReport.Size = New System.Drawing.Size(185, 23)
        Me.btnSLReport.TabIndex = 153
        Me.btnSLReport.Text = "Save Log As Formatted CSV File"
        Me.btnSLReport.UseVisualStyleBackColor = False
        Me.btnSLReport.Visible = False
        '
        'btnPrintDG
        '
        Me.btnPrintDG.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnPrintDG.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintDG.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnPrintDG.Location = New System.Drawing.Point(134, 37)
        Me.btnPrintDG.Name = "btnPrintDG"
        Me.btnPrintDG.Size = New System.Drawing.Size(120, 23)
        Me.btnPrintDG.TabIndex = 152
        Me.btnPrintDG.Text = "Print Data Grid Data"
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
        'lblBodyNm
        '
        Me.lblBodyNm.BackColor = System.Drawing.SystemColors.Control
        Me.lblBodyNm.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblBodyNm.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBodyNm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblBodyNm.Location = New System.Drawing.Point(673, 118)
        Me.lblBodyNm.Name = "lblBodyNm"
        Me.lblBodyNm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBodyNm.Size = New System.Drawing.Size(45, 17)
        Me.lblBodyNm.TabIndex = 168
        Me.lblBodyNm.Text = "Body"
        Me.lblBodyNm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Window
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(689, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(9, 17)
        Me.Label5.TabIndex = 169
        Me.Label5.Text = "'"
        '
        'txtIEDeg
        '
        Me.txtIEDeg.AcceptsReturn = True
        Me.txtIEDeg.BackColor = System.Drawing.SystemColors.Window
        Me.txtIEDeg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIEDeg.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIEDeg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtIEDeg.HideSelection = False
        Me.txtIEDeg.Location = New System.Drawing.Point(610, 148)
        Me.txtIEDeg.MaxLength = 2
        Me.txtIEDeg.Name = "txtIEDeg"
        Me.txtIEDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtIEDeg.Size = New System.Drawing.Size(30, 22)
        Me.txtIEDeg.TabIndex = 72
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Window
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(642, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(9, 17)
        Me.Label6.TabIndex = 171
        Me.Label6.Text = "°"
        '
        'lblIE
        '
        Me.lblIE.AutoSize = True
        Me.lblIE.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIE.Location = New System.Drawing.Point(589, 151)
        Me.lblIE.Name = "lblIE"
        Me.lblIE.Size = New System.Drawing.Size(18, 15)
        Me.lblIE.TabIndex = 15
        Me.lblIE.Text = "IE"
        Me.lblIE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboHEUnit
        '
        Me.cboHEUnit.BackColor = System.Drawing.SystemColors.Window
        Me.cboHEUnit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboHEUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHEUnit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboHEUnit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboHEUnit.Items.AddRange(New Object() {"ft", "in", "m", "cm"})
        Me.cboHEUnit.Location = New System.Drawing.Point(924, 147)
        Me.cboHEUnit.Name = "cboHEUnit"
        Me.cboHEUnit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboHEUnit.Size = New System.Drawing.Size(41, 23)
        Me.cboHEUnit.TabIndex = 172
        '
        'lblSRFEP
        '
        Me.lblSRFEP.BackColor = System.Drawing.Color.AntiqueWhite
        Me.lblSRFEP.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSRFEP.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSRFEP.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSRFEP.Location = New System.Drawing.Point(3, 47)
        Me.lblSRFEP.Name = "lblSRFEP"
        Me.lblSRFEP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSRFEP.Size = New System.Drawing.Size(60, 16)
        Me.lblSRFEP.TabIndex = 174
        Me.lblSRFEP.Text = "SR EP"
        '
        'txtSRFEP
        '
        Me.txtSRFEP.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSRFEP.Location = New System.Drawing.Point(83, 44)
        Me.txtSRFEP.Name = "txtSRFEP"
        Me.txtSRFEP.ReadOnly = True
        Me.txtSRFEP.Size = New System.Drawing.Size(259, 22)
        Me.txtSRFEP.TabIndex = 173
        '
        'txtHsSec
        '
        Me.txtHsSec.AcceptsReturn = True
        Me.txtHsSec.BackColor = System.Drawing.SystemColors.Window
        Me.txtHsSec.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHsSec.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHsSec.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHsSec.Location = New System.Drawing.Point(543, 148)
        Me.txtHsSec.MaxLength = 2
        Me.txtHsSec.Name = "txtHsSec"
        Me.txtHsSec.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHsSec.Size = New System.Drawing.Size(33, 22)
        Me.txtHsSec.TabIndex = 71
        Me.txtHsSec.Visible = False
        '
        'lblHsSec
        '
        Me.lblHsSec.BackColor = System.Drawing.SystemColors.Window
        Me.lblHsSec.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHsSec.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHsSec.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHsSec.Location = New System.Drawing.Point(578, 150)
        Me.lblHsSec.Name = "lblHsSec"
        Me.lblHsSec.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblHsSec.Size = New System.Drawing.Size(9, 17)
        Me.lblHsSec.TabIndex = 176
        Me.lblHsSec.Text = """"
        Me.lblHsSec.Visible = False
        '
        'txtIESec
        '
        Me.txtIESec.AcceptsReturn = True
        Me.txtIESec.BackColor = System.Drawing.SystemColors.Window
        Me.txtIESec.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIESec.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIESec.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtIESec.Location = New System.Drawing.Point(697, 148)
        Me.txtIESec.MaxLength = 2
        Me.txtIESec.Name = "txtIESec"
        Me.txtIESec.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtIESec.Size = New System.Drawing.Size(33, 22)
        Me.txtIESec.TabIndex = 76
        Me.txtIESec.Visible = False
        '
        'lblIEsec
        '
        Me.lblIEsec.BackColor = System.Drawing.SystemColors.Window
        Me.lblIEsec.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblIEsec.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIEsec.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblIEsec.Location = New System.Drawing.Point(729, 149)
        Me.lblIEsec.Name = "lblIEsec"
        Me.lblIEsec.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblIEsec.Size = New System.Drawing.Size(9, 17)
        Me.lblIEsec.TabIndex = 178
        Me.lblIEsec.Text = """"
        Me.lblIEsec.Visible = False
        '
        'lblHSIEFmt
        '
        Me.lblHSIEFmt.AutoSize = True
        Me.lblHSIEFmt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHSIEFmt.Location = New System.Drawing.Point(468, 22)
        Me.lblHSIEFmt.Name = "lblHSIEFmt"
        Me.lblHSIEFmt.Size = New System.Drawing.Size(120, 14)
        Me.lblHSIEFmt.TabIndex = 179
        Me.lblHSIEFmt.Text = "Default SR hs/IE Format"
        '
        'cboHSIEFmt
        '
        Me.cboHSIEFmt.BackColor = System.Drawing.SystemColors.Window
        Me.cboHSIEFmt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHSIEFmt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboHSIEFmt.FormattingEnabled = True
        Me.cboHSIEFmt.Items.AddRange(New Object() {"DM", "DMS"})
        Me.cboHSIEFmt.Location = New System.Drawing.Point(596, 18)
        Me.cboHSIEFmt.Name = "cboHSIEFmt"
        Me.cboHSIEFmt.Size = New System.Drawing.Size(70, 22)
        Me.cboHSIEFmt.TabIndex = 180
        '
        'cboApprxBrg
        '
        Me.cboApprxBrg.BackColor = System.Drawing.SystemColors.Window
        Me.cboApprxBrg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboApprxBrg.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboApprxBrg.FormattingEnabled = True
        Me.cboApprxBrg.Items.AddRange(New Object() {"N", "NE", "E", "SE", "S", "SW", "W", "NW", "None"})
        Me.cboApprxBrg.Location = New System.Drawing.Point(1242, 116)
        Me.cboApprxBrg.Name = "cboApprxBrg"
        Me.cboApprxBrg.Size = New System.Drawing.Size(70, 23)
        Me.cboApprxBrg.TabIndex = 182
        '
        'lblApprxBrg
        '
        Me.lblApprxBrg.AutoSize = True
        Me.lblApprxBrg.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApprxBrg.Location = New System.Drawing.Point(1175, 120)
        Me.lblApprxBrg.Name = "lblApprxBrg"
        Me.lblApprxBrg.Size = New System.Drawing.Size(62, 15)
        Me.lblApprxBrg.TabIndex = 181
        Me.lblApprxBrg.Text = "Apprx Brg"
        Me.lblApprxBrg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckBoxShowAvg
        '
        Me.CheckBoxShowAvg.AutoSize = True
        Me.CheckBoxShowAvg.Location = New System.Drawing.Point(10, 43)
        Me.CheckBoxShowAvg.Name = "CheckBoxShowAvg"
        Me.CheckBoxShowAvg.Size = New System.Drawing.Size(220, 17)
        Me.CheckBoxShowAvg.TabIndex = 183
        Me.CheckBoxShowAvg.Text = "Show Sight WT and hs Diff's for all sights"
        Me.CheckBoxShowAvg.UseVisualStyleBackColor = True
        '
        'CheckBoxAutoReduce
        '
        Me.CheckBoxAutoReduce.AutoSize = True
        Me.CheckBoxAutoReduce.Location = New System.Drawing.Point(10, 21)
        Me.CheckBoxAutoReduce.Name = "CheckBoxAutoReduce"
        Me.CheckBoxAutoReduce.Size = New System.Drawing.Size(211, 17)
        Me.CheckBoxAutoReduce.TabIndex = 184
        Me.CheckBoxAutoReduce.Text = "Auto Reduce New and Updated Sights"
        Me.CheckBoxAutoReduce.UseVisualStyleBackColor = True
        '
        'SLOptions
        '
        Me.SLOptions.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.SLOptions.Controls.Add(Me.chkDispGHADecHo)
        Me.SLOptions.Controls.Add(Me.chkClearFields)
        Me.SLOptions.Controls.Add(Me.Label8)
        Me.SLOptions.Controls.Add(Me.CheckBoxShowAvg)
        Me.SLOptions.Controls.Add(Me.CheckBoxAutoReduce)
        Me.SLOptions.Controls.Add(Me.cboHSIEFmt)
        Me.SLOptions.Controls.Add(Me.lblHSIEFmt)
        Me.SLOptions.Location = New System.Drawing.Point(9, 255)
        Me.SLOptions.Name = "SLOptions"
        Me.SLOptions.Size = New System.Drawing.Size(683, 70)
        Me.SLOptions.TabIndex = 186
        Me.SLOptions.TabStop = False
        Me.SLOptions.Text = "SightLog Options"
        '
        'chkDispGHADecHo
        '
        Me.chkDispGHADecHo.AutoSize = True
        Me.chkDispGHADecHo.Location = New System.Drawing.Point(236, 43)
        Me.chkDispGHADecHo.Name = "chkDispGHADecHo"
        Me.chkDispGHADecHo.Size = New System.Drawing.Size(241, 17)
        Me.chkDispGHADecHo.TabIndex = 186
        Me.chkDispGHADecHo.Text = "Display Sight Reduction GHA/DEC/Ho Fields"
        Me.chkDispGHADecHo.UseVisualStyleBackColor = True
        '
        'chkClearFields
        '
        Me.chkClearFields.AutoSize = True
        Me.chkClearFields.Location = New System.Drawing.Point(235, 22)
        Me.chkClearFields.Name = "chkClearFields"
        Me.chkClearFields.Size = New System.Drawing.Size(226, 17)
        Me.chkClearFields.TabIndex = 185
        Me.chkClearFields.Text = "Clear Fields after New and Updated Sights"
        Me.chkClearFields.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Window
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(305, -53)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(9, 17)
        Me.Label8.TabIndex = 169
        Me.Label8.Text = "'"
        '
        'lblSRGHA
        '
        Me.lblSRGHA.BackColor = System.Drawing.Color.AntiqueWhite
        Me.lblSRGHA.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSRGHA.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSRGHA.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSRGHA.Location = New System.Drawing.Point(348, 22)
        Me.lblSRGHA.Name = "lblSRGHA"
        Me.lblSRGHA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSRGHA.Size = New System.Drawing.Size(60, 19)
        Me.lblSRGHA.TabIndex = 189
        Me.lblSRGHA.Text = "SR GHA"
        '
        'txtSRGHA
        '
        Me.txtSRGHA.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSRGHA.Location = New System.Drawing.Point(409, 20)
        Me.txtSRGHA.Name = "txtSRGHA"
        Me.txtSRGHA.ReadOnly = True
        Me.txtSRGHA.Size = New System.Drawing.Size(90, 22)
        Me.txtSRGHA.TabIndex = 188
        Me.txtSRGHA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblSRDec
        '
        Me.lblSRDec.BackColor = System.Drawing.Color.AntiqueWhite
        Me.lblSRDec.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSRDec.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSRDec.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSRDec.Location = New System.Drawing.Point(502, 22)
        Me.lblSRDec.Name = "lblSRDec"
        Me.lblSRDec.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSRDec.Size = New System.Drawing.Size(55, 19)
        Me.lblSRDec.TabIndex = 191
        Me.lblSRDec.Text = "SR Dec"
        '
        'txtSRDec
        '
        Me.txtSRDec.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSRDec.Location = New System.Drawing.Point(559, 21)
        Me.txtSRDec.Name = "txtSRDec"
        Me.txtSRDec.ReadOnly = True
        Me.txtSRDec.Size = New System.Drawing.Size(90, 22)
        Me.txtSRDec.TabIndex = 190
        Me.txtSRDec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblSRHo
        '
        Me.lblSRHo.BackColor = System.Drawing.Color.AntiqueWhite
        Me.lblSRHo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSRHo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSRHo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSRHo.Location = New System.Drawing.Point(348, 47)
        Me.lblSRHo.Name = "lblSRHo"
        Me.lblSRHo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSRHo.Size = New System.Drawing.Size(60, 19)
        Me.lblSRHo.TabIndex = 193
        Me.lblSRHo.Text = "SR Ho"
        '
        'txtSRHo
        '
        Me.txtSRHo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSRHo.Location = New System.Drawing.Point(409, 45)
        Me.txtSRHo.Name = "txtSRHo"
        Me.txtSRHo.ReadOnly = True
        Me.txtSRHo.Size = New System.Drawing.Size(90, 22)
        Me.txtSRHo.TabIndex = 192
        Me.txtSRHo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.AntiqueWhite
        Me.GroupBox1.Controls.Add(Me.txtIntZn)
        Me.GroupBox1.Controls.Add(Me.lblSRHo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtSRHo)
        Me.GroupBox1.Controls.Add(Me.txtSRFEP)
        Me.GroupBox1.Controls.Add(Me.lblSRDec)
        Me.GroupBox1.Controls.Add(Me.lblSRFEP)
        Me.GroupBox1.Controls.Add(Me.txtSRDec)
        Me.GroupBox1.Controls.Add(Me.lblSRGHA)
        Me.GroupBox1.Controls.Add(Me.txtSRGHA)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(10, 175)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(682, 76)
        Me.GroupBox1.TabIndex = 194
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sight Reduction Form Results"
        '
        'txtUserInfo
        '
        Me.txtUserInfo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserInfo.HideSelection = False
        Me.txtUserInfo.Location = New System.Drawing.Point(835, 87)
        Me.txtUserInfo.Name = "txtUserInfo"
        Me.txtUserInfo.Size = New System.Drawing.Size(375, 22)
        Me.txtUserInfo.TabIndex = 196
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(771, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 15)
        Me.Label7.TabIndex = 195
        Me.Label7.Text = "User Info"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpFileButtons
        '
        Me.grpFileButtons.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.grpFileButtons.Controls.Add(Me.btnSaveLogAsTxt)
        Me.grpFileButtons.Controls.Add(Me.btnSLReport)
        Me.grpFileButtons.Controls.Add(Me.btnPrintDG)
        Me.grpFileButtons.Controls.Add(Me.btnOpenLog)
        Me.grpFileButtons.Controls.Add(Me.btnSaveLog)
        Me.grpFileButtons.Controls.Add(Me.btnNewLog)
        Me.grpFileButtons.Location = New System.Drawing.Point(874, 12)
        Me.grpFileButtons.Name = "grpFileButtons"
        Me.grpFileButtons.Size = New System.Drawing.Size(454, 68)
        Me.grpFileButtons.TabIndex = 167
        Me.grpFileButtons.TabStop = False
        Me.grpFileButtons.Text = "Sight File Actions"
        '
        'btnSaveLogAsTxt
        '
        Me.btnSaveLogAsTxt.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnSaveLogAsTxt.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveLogAsTxt.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnSaveLogAsTxt.Location = New System.Drawing.Point(260, 37)
        Me.btnSaveLogAsTxt.Name = "btnSaveLogAsTxt"
        Me.btnSaveLogAsTxt.Size = New System.Drawing.Size(185, 23)
        Me.btnSaveLogAsTxt.TabIndex = 154
        Me.btnSaveLogAsTxt.Text = "Save Log As Formatted Txt File"
        Me.btnSaveLogAsTxt.UseVisualStyleBackColor = False
        Me.btnSaveLogAsTxt.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.CelestialTools.My.Resources.Resources.ABC_white
        Me.PictureBox2.Location = New System.Drawing.Point(10, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(447, 68)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 197
        Me.PictureBox2.TabStop = False
        '
        'cboLLoBy
        '
        Me.cboLLoBy.BackColor = System.Drawing.SystemColors.Window
        Me.cboLLoBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLLoBy.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLLoBy.FormattingEnabled = True
        Me.cboLLoBy.Items.AddRange(New Object() {"DR", "GPS", "KP"})
        Me.cboLLoBy.Location = New System.Drawing.Point(1100, 116)
        Me.cboLLoBy.Name = "cboLLoBy"
        Me.cboLLoBy.Size = New System.Drawing.Size(70, 23)
        Me.cboLLoBy.TabIndex = 199
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(1043, 120)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 15)
        Me.Label9.TabIndex = 198
        Me.Label9.Text = "L/Lo by:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SightLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1336, 771)
        Me.Controls.Add(Me.cboLLoBy)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtUserInfo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SLOptions)
        Me.Controls.Add(Me.cboApprxBrg)
        Me.Controls.Add(Me.txtIESec)
        Me.Controls.Add(Me.lblIEsec)
        Me.Controls.Add(Me.txtHsSec)
        Me.Controls.Add(Me.lblHsSec)
        Me.Controls.Add(Me.lblApprxBrg)
        Me.Controls.Add(Me.grpFileButtons)
        Me.Controls.Add(Me.cboHEUnit)
        Me.Controls.Add(Me.txtIEDeg)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblBodyNm)
        Me.Controls.Add(Me.grpSightButtons)
        Me.Controls.Add(Me.cboZD)
        Me.Controls.Add(Me.lblZD)
        Me.Controls.Add(Me.lblUSPSSightLog)
        Me.Controls.Add(Me.SEDataGrid)
        Me.Controls.Add(Me.txtHSDeg)
        Me.Controls.Add(Me.txtHSMin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lvlHS)
        Me.Controls.Add(Me.lblLimb)
        Me.Controls.Add(Me.cbLimb)
        Me.Controls.Add(Me.txtRemarks)
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
        Me.Controls.Add(Me.cboBody)
        Me.Controls.Add(Me.lblLoMin)
        Me.Controls.Add(Me.lblLoDeg)
        Me.Controls.Add(Me.lblDRLo)
        Me.Controls.Add(Me.lblLMin)
        Me.Controls.Add(Me.lblLDeg)
        Me.Controls.Add(Me.lblDRL)
        Me.Controls.Add(Me.txtHE)
        Me.Controls.Add(Me.lblHE)
        Me.Controls.Add(Me.cbIEType)
        Me.Controls.Add(Me.txtIE)
        Me.Controls.Add(Me.lblIE)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.cbWEType)
        Me.Controls.Add(Me.txtWE)
        Me.Controls.Add(Me.lblWE)
        Me.Controls.Add(Me.lblSightDate)
        Me.Controls.Add(Me.SightDateTime)
        Me.Controls.Add(Me.txtSightNum)
        Me.Controls.Add(Me.lblSightNum)
        Me.Controls.Add(Me.txtSquadron)
        Me.Controls.Add(Me.lblSquadron)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "SightLog"
        Me.Text = "USPS Sight Log"
        CType(Me.SEDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSightButtons.ResumeLayout(False)
        Me.SLOptions.ResumeLayout(False)
        Me.SLOptions.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpFileButtons.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtSquadron As TextBox
    Friend WithEvents lblSquadron As Label
    Friend WithEvents txtSightNum As TextBox
    Friend WithEvents lblSightNum As Label
    Friend WithEvents SightDateTime As DateTimePicker
    Friend WithEvents lblSightDate As Label
    Friend WithEvents lblWE As Label
    Friend WithEvents txtWE As TextBox
    Friend WithEvents cbWEType As ComboBox
    Friend WithEvents btnExit As Button
    Friend WithEvents cbIEType As ComboBox
    Friend WithEvents txtIE As TextBox
    Friend WithEvents txtHE As TextBox
    Friend WithEvents lblHE As Label
    Public WithEvents cboLo As ComboBox
    Public WithEvents cboL As ComboBox
    Public WithEvents txtLDeg As TextBox
    Public WithEvents txtLoMin As TextBox
    Public WithEvents txtLoDeg As TextBox
    Public WithEvents txtLMin As TextBox
    Public WithEvents cboBody As ComboBox
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
    Friend WithEvents txtRemarks As RichTextBox
    Friend WithEvents btnAddNew As Button
    Friend WithEvents btnUpdateExisting As Button
    Friend WithEvents btnDeleteSight As Button
    Friend WithEvents btnNewLog As Button
    Friend WithEvents btnSightReduce As Button
    Public WithEvents cbLimb As ComboBox
    Public WithEvents lblLimb As Label
    Public WithEvents txtHSDeg As TextBox
    Public WithEvents txtHSMin As TextBox
    Public WithEvents Label1 As Label
    Public WithEvents Label2 As Label
    Public WithEvents lvlHS As Label
    Friend WithEvents txtIntZn As TextBox
    Friend WithEvents SEDataGrid As DataGridView
    Friend WithEvents lblUSPSSightLog As Label
    Friend WithEvents lblZD As Label
    Public WithEvents cboZD As ComboBox
    Friend WithEvents btnClearFields As Button
    Public WithEvents Label3 As Label
    Friend WithEvents grpSightButtons As GroupBox
    Friend WithEvents btnPrintDG As Button
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As PrintDocument
    Public WithEvents lblBodyNm As Label
    Public WithEvents Label4 As Label
    Public WithEvents Label5 As Label
    Public WithEvents txtIEDeg As TextBox
    Public WithEvents Label6 As Label
    Friend WithEvents lblIE As Label
    Public WithEvents cboHEUnit As ComboBox
    Public WithEvents lblSRFEP As Label
    Friend WithEvents txtSRFEP As TextBox
    Friend WithEvents btnSLReport As Button
    Public WithEvents txtHsSec As TextBox
    Public WithEvents lblHsSec As Label
    Public WithEvents txtIESec As TextBox
    Public WithEvents lblIEsec As Label
    Friend WithEvents lblHSIEFmt As Label
    Friend WithEvents cboHSIEFmt As ComboBox
    Friend WithEvents cboApprxBrg As ComboBox
    Friend WithEvents lblApprxBrg As Label
    Friend WithEvents CheckBoxShowAvg As CheckBox
    Friend WithEvents CheckBoxAutoReduce As CheckBox
    Friend WithEvents SLOptions As GroupBox
    Public WithEvents Label8 As Label
    Friend WithEvents chkClearFields As CheckBox
    Friend WithEvents btnAltSR As Button
    Friend WithEvents chkDispGHADecHo As CheckBox
    Public WithEvents lblSRGHA As Label
    Friend WithEvents txtSRGHA As TextBox
    Public WithEvents lblSRDec As Label
    Friend WithEvents txtSRDec As TextBox
    Public WithEvents lblSRHo As Label
    Friend WithEvents txtSRHo As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnNoonSight As Button
    Friend WithEvents btnUseCLS As Button
    Friend WithEvents btnCustomPlot As Button
    Friend WithEvents txtUserInfo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents grpFileButtons As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnPlanSight As Button
    Friend WithEvents cboLLoBy As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents SightNum As DataGridViewTextBoxColumn
    Friend WithEvents SDateTime As DataGridViewTextBoxColumn
    Friend WithEvents BodyName As DataGridViewTextBoxColumn
    Friend WithEvents BodyLimb As DataGridViewTextBoxColumn
    Friend WithEvents SDST As DataGridViewTextBoxColumn
    Friend WithEvents SWE As DataGridViewTextBoxColumn
    Friend WithEvents SWEType As DataGridViewTextBoxColumn
    Friend WithEvents ZD As DataGridViewTextBoxColumn
    Friend WithEvents HS As DataGridViewTextBoxColumn
    Friend WithEvents HorType As DataGridViewTextBoxColumn
    Friend WithEvents HorDist As DataGridViewTextBoxColumn
    Friend WithEvents HorDistType As DataGridViewTextBoxColumn
    Friend WithEvents HE As DataGridViewTextBoxColumn
    Friend WithEvents IC As DataGridViewTextBoxColumn
    Friend WithEvents ICType As DataGridViewTextBoxColumn
    Friend WithEvents DRLat As DataGridViewTextBoxColumn
    Friend WithEvents DRLong As DataGridViewTextBoxColumn
    Friend WithEvents LLoBy As DataGridViewTextBoxColumn
    Friend WithEvents Intercept As DataGridViewTextBoxColumn
    Friend WithEvents Aziumuth As DataGridViewTextBoxColumn
    Friend WithEvents EP As DataGridViewTextBoxColumn
    Friend WithEvents PsnName As DataGridViewTextBoxColumn
    Friend WithEvents Squadron As DataGridViewTextBoxColumn
    Friend WithEvents WTDiff As DataGridViewTextBoxColumn
    Friend WithEvents HSDiff As DataGridViewTextBoxColumn
    Friend WithEvents HSWTRate As DataGridViewTextBoxColumn
    Friend WithEvents Remarks As DataGridViewTextBoxColumn
    Friend WithEvents SRGHA As DataGridViewTextBoxColumn
    Friend WithEvents SRDec As DataGridViewTextBoxColumn
    Friend WithEvents SRHo As DataGridViewTextBoxColumn
    Friend WithEvents UserInfo As DataGridViewTextBoxColumn
    Friend WithEvents btnSaveLogAsTxt As Button
End Class
