<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ZTInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ZTInfo))
        Me.Label44 = New System.Windows.Forms.Label()
        Me.cboLocAZD = New System.Windows.Forms.ComboBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.DTLocA = New System.Windows.Forms.DateTimePicker()
        Me.cboLoA = New System.Windows.Forms.ComboBox()
        Me.txtLoMinA = New System.Windows.Forms.TextBox()
        Me.txtLoDegA = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblDRLo = New System.Windows.Forms.Label()
        Me.txtTZInfoA = New System.Windows.Forms.Label()
        Me.txtLocAZTInfo = New System.Windows.Forms.TextBox()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DTLocAUTC = New System.Windows.Forms.DateTimePicker()
        Me.btnClearFields = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtInfo = New System.Windows.Forms.TextBox()
        Me.txtSLDST = New System.Windows.Forms.TextBox()
        Me.btnReloadZT = New System.Windows.Forms.Button()
        Me.DGTZ = New System.Windows.Forms.DataGridView()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.grpDestInfo = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DTResult = New System.Windows.Forms.DateTimePicker()
        Me.cboAddSub = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DT1Minutes = New System.Windows.Forms.NumericUpDown()
        Me.DT1Hours = New System.Windows.Forms.NumericUpDown()
        Me.DT1Days = New System.Windows.Forms.NumericUpDown()
        Me.txtLocBZTInfo = New System.Windows.Forms.TextBox()
        Me.cboLoB = New System.Windows.Forms.ComboBox()
        Me.txtLoMinB = New System.Windows.Forms.TextBox()
        Me.txtLoDegB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboLocBZD = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DGTZ, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDestInfo.SuspendLayout()
        CType(Me.DT1Minutes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT1Hours, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT1Days, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label44
        '
        Me.Label44.BackColor = System.Drawing.SystemColors.Window
        Me.Label44.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label44.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label44.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label44.Location = New System.Drawing.Point(40, 130)
        Me.Label44.Name = "Label44"
        Me.Label44.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label44.Size = New System.Drawing.Size(80, 17)
        Me.Label44.TabIndex = 204
        Me.Label44.Text = "Time Zone "
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboLocAZD
        '
        Me.cboLocAZD.FormattingEnabled = True
        Me.cboLocAZD.Location = New System.Drawing.Point(133, 128)
        Me.cboLocAZD.Name = "cboLocAZD"
        Me.cboLocAZD.Size = New System.Drawing.Size(280, 21)
        Me.cboLocAZD.TabIndex = 203
        '
        'Label43
        '
        Me.Label43.BackColor = System.Drawing.SystemColors.Window
        Me.Label43.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label43.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label43.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label43.Location = New System.Drawing.Point(40, 104)
        Me.Label43.Name = "Label43"
        Me.Label43.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label43.Size = New System.Drawing.Size(80, 17)
        Me.Label43.TabIndex = 201
        Me.Label43.Text = "Date Time:"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DTLocA
        '
        Me.DTLocA.CustomFormat = "ddd MM/dd/yyyy HH:mm"
        Me.DTLocA.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTLocA.Location = New System.Drawing.Point(133, 102)
        Me.DTLocA.Name = "DTLocA"
        Me.DTLocA.Size = New System.Drawing.Size(200, 20)
        Me.DTLocA.TabIndex = 200
        '
        'cboLoA
        '
        Me.cboLoA.BackColor = System.Drawing.SystemColors.Window
        Me.cboLoA.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboLoA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLoA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLoA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboLoA.Items.AddRange(New Object() {"W", "E"})
        Me.cboLoA.Location = New System.Drawing.Point(220, 75)
        Me.cboLoA.Name = "cboLoA"
        Me.cboLoA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboLoA.Size = New System.Drawing.Size(41, 22)
        Me.cboLoA.TabIndex = 214
        '
        'txtLoMinA
        '
        Me.txtLoMinA.AcceptsReturn = True
        Me.txtLoMinA.BackColor = System.Drawing.SystemColors.Window
        Me.txtLoMinA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLoMinA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoMinA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLoMinA.Location = New System.Drawing.Point(177, 76)
        Me.txtLoMinA.MaxLength = 4
        Me.txtLoMinA.Name = "txtLoMinA"
        Me.txtLoMinA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLoMinA.Size = New System.Drawing.Size(33, 20)
        Me.txtLoMinA.TabIndex = 213
        '
        'txtLoDegA
        '
        Me.txtLoDegA.AcceptsReturn = True
        Me.txtLoDegA.BackColor = System.Drawing.SystemColors.Window
        Me.txtLoDegA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLoDegA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoDegA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLoDegA.Location = New System.Drawing.Point(135, 76)
        Me.txtLoDegA.MaxLength = 3
        Me.txtLoDegA.Name = "txtLoDegA"
        Me.txtLoDegA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLoDegA.Size = New System.Drawing.Size(33, 20)
        Me.txtLoDegA.TabIndex = 211
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Window
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(167, 79)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(9, 17)
        Me.Label8.TabIndex = 212
        Me.Label8.Text = "°"
        '
        'lblDRLo
        '
        Me.lblDRLo.BackColor = System.Drawing.SystemColors.Window
        Me.lblDRLo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDRLo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDRLo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDRLo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDRLo.Location = New System.Drawing.Point(40, 76)
        Me.lblDRLo.Name = "lblDRLo"
        Me.lblDRLo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDRLo.Size = New System.Drawing.Size(80, 20)
        Me.lblDRLo.TabIndex = 210
        Me.lblDRLo.Text = "Longitude:"
        Me.lblDRLo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTZInfoA
        '
        Me.txtTZInfoA.BackColor = System.Drawing.SystemColors.Window
        Me.txtTZInfoA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtTZInfoA.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtTZInfoA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTZInfoA.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtTZInfoA.Location = New System.Drawing.Point(40, 159)
        Me.txtTZInfoA.Name = "txtTZInfoA"
        Me.txtTZInfoA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTZInfoA.Size = New System.Drawing.Size(80, 17)
        Me.txtTZInfoA.TabIndex = 229
        Me.txtTZInfoA.Text = "TimeZone Info:"
        Me.txtTZInfoA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtLocAZTInfo
        '
        Me.txtLocAZTInfo.Location = New System.Drawing.Point(133, 157)
        Me.txtLocAZTInfo.Multiline = True
        Me.txtLocAZTInfo.Name = "txtLocAZTInfo"
        Me.txtLocAZTInfo.Size = New System.Drawing.Size(280, 60)
        Me.txtLocAZTInfo.TabIndex = 230
        '
        'ExitBtn
        '
        Me.ExitBtn.BackColor = System.Drawing.Color.Red
        Me.ExitBtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExitBtn.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ExitBtn.Location = New System.Drawing.Point(966, 6)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ExitBtn.Size = New System.Drawing.Size(111, 30)
        Me.ExitBtn.TabIndex = 239
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label4.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(389, 24)
        Me.Label4.TabIndex = 241
        Me.Label4.Text = "Time Zone Planner and Calculation Tools"
        '
        'btnCalc
        '
        Me.btnCalc.BackColor = System.Drawing.Color.Yellow
        Me.btnCalc.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCalc.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCalc.Location = New System.Drawing.Point(37, 284)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCalc.Size = New System.Drawing.Size(112, 30)
        Me.btnCalc.TabIndex = 242
        Me.btnCalc.Text = "Calc Dest Date/Time"
        Me.btnCalc.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Window
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(210, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(10, 17)
        Me.Label6.TabIndex = 245
        Me.Label6.Text = "'"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Window
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(40, 224)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(80, 17)
        Me.Label12.TabIndex = 250
        Me.Label12.Text = "UTC"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DTLocAUTC
        '
        Me.DTLocAUTC.CustomFormat = "ddd MM/dd/yyyy HH:mm"
        Me.DTLocAUTC.Enabled = False
        Me.DTLocAUTC.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTLocAUTC.Location = New System.Drawing.Point(133, 222)
        Me.DTLocAUTC.Name = "DTLocAUTC"
        Me.DTLocAUTC.Size = New System.Drawing.Size(200, 20)
        Me.DTLocAUTC.TabIndex = 249
        '
        'btnClearFields
        '
        Me.btnClearFields.BackColor = System.Drawing.Color.Yellow
        Me.btnClearFields.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnClearFields.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearFields.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnClearFields.Location = New System.Drawing.Point(165, 284)
        Me.btnClearFields.Name = "btnClearFields"
        Me.btnClearFields.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnClearFields.Size = New System.Drawing.Size(112, 30)
        Me.btnClearFields.TabIndex = 251
        Me.btnClearFields.Text = "Initialize All Fields"
        Me.btnClearFields.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Silver
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(2, 50)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(439, 24)
        Me.Label13.TabIndex = 252
        Me.Label13.Text = "Origin Longitude, Date/Time, Time Zone, and UTC:"
        '
        'txtInfo
        '
        Me.txtInfo.Location = New System.Drawing.Point(69, 574)
        Me.txtInfo.Multiline = True
        Me.txtInfo.Name = "txtInfo"
        Me.txtInfo.Size = New System.Drawing.Size(346, 195)
        Me.txtInfo.TabIndex = 260
        Me.txtInfo.Text = resources.GetString("txtInfo.Text")
        '
        'txtSLDST
        '
        Me.txtSLDST.BackColor = System.Drawing.Color.Red
        Me.txtSLDST.ForeColor = System.Drawing.Color.White
        Me.txtSLDST.Location = New System.Drawing.Point(94, 574)
        Me.txtSLDST.Multiline = True
        Me.txtSLDST.Name = "txtSLDST"
        Me.txtSLDST.Size = New System.Drawing.Size(290, 111)
        Me.txtSLDST.TabIndex = 261
        Me.txtSLDST.Text = resources.GetString("txtSLDST.Text")
        Me.txtSLDST.Visible = False
        '
        'btnReloadZT
        '
        Me.btnReloadZT.BackColor = System.Drawing.Color.Yellow
        Me.btnReloadZT.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnReloadZT.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReloadZT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnReloadZT.Location = New System.Drawing.Point(1095, 6)
        Me.btnReloadZT.Name = "btnReloadZT"
        Me.btnReloadZT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnReloadZT.Size = New System.Drawing.Size(112, 30)
        Me.btnReloadZT.TabIndex = 240
        Me.btnReloadZT.Text = "Reload Time Zones"
        Me.btnReloadZT.UseVisualStyleBackColor = False
        '
        'DGTZ
        '
        Me.DGTZ.AllowUserToAddRows = False
        Me.DGTZ.AllowUserToDeleteRows = False
        Me.DGTZ.AllowUserToResizeColumns = False
        Me.DGTZ.AllowUserToResizeRows = False
        Me.DGTZ.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGTZ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGTZ.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DGTZ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGTZ.Location = New System.Drawing.Point(445, 48)
        Me.DGTZ.MultiSelect = False
        Me.DGTZ.Name = "DGTZ"
        Me.DGTZ.ReadOnly = True
        Me.DGTZ.Size = New System.Drawing.Size(762, 721)
        Me.DGTZ.TabIndex = 238
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label18.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(447, 9)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(204, 24)
        Me.Label18.TabIndex = 259
        Me.Label18.Text = "Table of Time Zones:"
        '
        'grpDestInfo
        '
        Me.grpDestInfo.Controls.Add(Me.Label2)
        Me.grpDestInfo.Controls.Add(Me.Label3)
        Me.grpDestInfo.Controls.Add(Me.Label16)
        Me.grpDestInfo.Controls.Add(Me.Label17)
        Me.grpDestInfo.Controls.Add(Me.btnClearFields)
        Me.grpDestInfo.Controls.Add(Me.Label15)
        Me.grpDestInfo.Controls.Add(Me.Label14)
        Me.grpDestInfo.Controls.Add(Me.Label11)
        Me.grpDestInfo.Controls.Add(Me.Label10)
        Me.grpDestInfo.Controls.Add(Me.btnCalc)
        Me.grpDestInfo.Controls.Add(Me.Label7)
        Me.grpDestInfo.Controls.Add(Me.DTResult)
        Me.grpDestInfo.Controls.Add(Me.cboAddSub)
        Me.grpDestInfo.Controls.Add(Me.Label9)
        Me.grpDestInfo.Controls.Add(Me.DT1Minutes)
        Me.grpDestInfo.Controls.Add(Me.DT1Hours)
        Me.grpDestInfo.Controls.Add(Me.DT1Days)
        Me.grpDestInfo.Controls.Add(Me.txtLocBZTInfo)
        Me.grpDestInfo.Controls.Add(Me.cboLoB)
        Me.grpDestInfo.Controls.Add(Me.txtLoMinB)
        Me.grpDestInfo.Controls.Add(Me.txtLoDegB)
        Me.grpDestInfo.Controls.Add(Me.Label1)
        Me.grpDestInfo.Controls.Add(Me.cboLocBZD)
        Me.grpDestInfo.Controls.Add(Me.Label5)
        Me.grpDestInfo.Location = New System.Drawing.Point(3, 248)
        Me.grpDestInfo.Name = "grpDestInfo"
        Me.grpDestInfo.Size = New System.Drawing.Size(439, 320)
        Me.grpDestInfo.TabIndex = 262
        Me.grpDestInfo.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(38, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(80, 17)
        Me.Label2.TabIndex = 280
        Me.Label2.Text = "TimeZone Info:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Window
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(38, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(80, 20)
        Me.Label3.TabIndex = 279
        Me.Label3.Text = "Longitude:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.Window
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(38, 147)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(80, 17)
        Me.Label16.TabIndex = 278
        Me.Label16.Text = "Time Zone "
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.SystemColors.Window
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label17.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(38, 252)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(85, 19)
        Me.Label17.TabIndex = 277
        Me.Label17.Text = "Dest Date Time:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Silver
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(1, 15)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(437, 24)
        Me.Label15.TabIndex = 276
        Me.Label15.Text = "Interval of Days/Hrs/Mins to Add/Subtract to Origin "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Silver
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 86)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(429, 24)
        Me.Label14.TabIndex = 275
        Me.Label14.Text = "Destination Longitude, Time Zone, and Date/Time"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Window
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(306, 50)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(25, 17)
        Me.Label11.TabIndex = 274
        Me.Label11.Text = "Min"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Window
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(239, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(25, 17)
        Me.Label10.TabIndex = 273
        Me.Label10.Text = "Hrs"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Window
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(168, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(32, 17)
        Me.Label7.TabIndex = 272
        Me.Label7.Text = "Days"
        '
        'DTResult
        '
        Me.DTResult.CustomFormat = "ddd MM/dd/yyyy HH:mm"
        Me.DTResult.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTResult.Location = New System.Drawing.Point(129, 251)
        Me.DTResult.Name = "DTResult"
        Me.DTResult.Size = New System.Drawing.Size(200, 20)
        Me.DTResult.TabIndex = 270
        '
        'cboAddSub
        '
        Me.cboAddSub.FormattingEnabled = True
        Me.cboAddSub.Items.AddRange(New Object() {"+", "-"})
        Me.cboAddSub.Location = New System.Drawing.Point(337, 48)
        Me.cboAddSub.Name = "cboAddSub"
        Me.cboAddSub.Size = New System.Drawing.Size(68, 21)
        Me.cboAddSub.TabIndex = 269
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Window
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Location = New System.Drawing.Point(38, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 15)
        Me.Label9.TabIndex = 268
        Me.Label9.Text = "Interval "
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DT1Minutes
        '
        Me.DT1Minutes.Location = New System.Drawing.Point(268, 48)
        Me.DT1Minutes.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.DT1Minutes.Name = "DT1Minutes"
        Me.DT1Minutes.Size = New System.Drawing.Size(35, 20)
        Me.DT1Minutes.TabIndex = 267
        '
        'DT1Hours
        '
        Me.DT1Hours.Location = New System.Drawing.Point(200, 48)
        Me.DT1Hours.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.DT1Hours.Name = "DT1Hours"
        Me.DT1Hours.Size = New System.Drawing.Size(35, 20)
        Me.DT1Hours.TabIndex = 266
        '
        'DT1Days
        '
        Me.DT1Days.Location = New System.Drawing.Point(130, 49)
        Me.DT1Days.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.DT1Days.Name = "DT1Days"
        Me.DT1Days.Size = New System.Drawing.Size(35, 20)
        Me.DT1Days.TabIndex = 265
        '
        'txtLocBZTInfo
        '
        Me.txtLocBZTInfo.Location = New System.Drawing.Point(130, 175)
        Me.txtLocBZTInfo.Multiline = True
        Me.txtLocBZTInfo.Name = "txtLocBZTInfo"
        Me.txtLocBZTInfo.Size = New System.Drawing.Size(280, 60)
        Me.txtLocBZTInfo.TabIndex = 264
        '
        'cboLoB
        '
        Me.cboLoB.BackColor = System.Drawing.SystemColors.Window
        Me.cboLoB.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboLoB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLoB.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLoB.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboLoB.Items.AddRange(New Object() {"W", "E"})
        Me.cboLoB.Location = New System.Drawing.Point(213, 115)
        Me.cboLoB.Name = "cboLoB"
        Me.cboLoB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboLoB.Size = New System.Drawing.Size(41, 22)
        Me.cboLoB.TabIndex = 263
        '
        'txtLoMinB
        '
        Me.txtLoMinB.AcceptsReturn = True
        Me.txtLoMinB.BackColor = System.Drawing.SystemColors.Window
        Me.txtLoMinB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLoMinB.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoMinB.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLoMinB.Location = New System.Drawing.Point(170, 116)
        Me.txtLoMinB.MaxLength = 4
        Me.txtLoMinB.Name = "txtLoMinB"
        Me.txtLoMinB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLoMinB.Size = New System.Drawing.Size(33, 20)
        Me.txtLoMinB.TabIndex = 262
        '
        'txtLoDegB
        '
        Me.txtLoDegB.AcceptsReturn = True
        Me.txtLoDegB.BackColor = System.Drawing.SystemColors.Window
        Me.txtLoDegB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLoDegB.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoDegB.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLoDegB.Location = New System.Drawing.Point(130, 116)
        Me.txtLoDegB.MaxLength = 3
        Me.txtLoDegB.Name = "txtLoDegB"
        Me.txtLoDegB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLoDegB.Size = New System.Drawing.Size(33, 20)
        Me.txtLoDegB.TabIndex = 260
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(162, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(9, 17)
        Me.Label1.TabIndex = 261
        Me.Label1.Text = "°"
        '
        'cboLocBZD
        '
        Me.cboLocBZD.FormattingEnabled = True
        Me.cboLocBZD.Location = New System.Drawing.Point(129, 143)
        Me.cboLocBZD.Name = "cboLocBZD"
        Me.cboLocBZD.Size = New System.Drawing.Size(282, 21)
        Me.cboLocBZD.TabIndex = 259
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Window
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(203, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(9, 17)
        Me.Label5.TabIndex = 271
        Me.Label5.Text = "'"
        '
        'ZTInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1222, 781)
        Me.Controls.Add(Me.txtSLDST)
        Me.Controls.Add(Me.txtInfo)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.DTLocAUTC)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnReloadZT)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.DGTZ)
        Me.Controls.Add(Me.txtLocAZTInfo)
        Me.Controls.Add(Me.txtTZInfoA)
        Me.Controls.Add(Me.cboLoA)
        Me.Controls.Add(Me.txtLoMinA)
        Me.Controls.Add(Me.txtLoDegA)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblDRLo)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.cboLocAZD)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.DTLocA)
        Me.Controls.Add(Me.grpDestInfo)
        Me.Name = "ZTInfo"
        Me.Text = "Time Zone Planner "
        CType(Me.DGTZ, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDestInfo.ResumeLayout(False)
        Me.grpDestInfo.PerformLayout()
        CType(Me.DT1Minutes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT1Hours, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT1Days, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents Label44 As Label
    Friend WithEvents cboLocAZD As ComboBox
    Public WithEvents Label43 As Label
    Friend WithEvents DTLocA As DateTimePicker
    Public WithEvents cboLoA As ComboBox
    Public WithEvents txtLoMinA As TextBox
    Public WithEvents txtLoDegA As TextBox
    Public WithEvents Label8 As Label
    Public WithEvents lblDRLo As Label
    Public WithEvents txtTZInfoA As Label
    Friend WithEvents txtLocAZTInfo As TextBox
    Public WithEvents ExitBtn As Button
    Friend WithEvents Label4 As Label
    Public WithEvents btnCalc As Button
    Public WithEvents Label6 As Label
    Public WithEvents Label12 As Label
    Friend WithEvents DTLocAUTC As DateTimePicker
    Public WithEvents btnClearFields As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents txtInfo As TextBox
    Friend WithEvents txtSLDST As TextBox
    Public WithEvents btnReloadZT As Button
    Friend WithEvents DGTZ As DataGridView
    Friend WithEvents Label18 As Label
    Friend WithEvents grpDestInfo As GroupBox
    Public WithEvents Label2 As Label
    Public WithEvents Label3 As Label
    Public WithEvents Label16 As Label
    Public WithEvents Label17 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Public WithEvents Label11 As Label
    Public WithEvents Label10 As Label
    Public WithEvents Label7 As Label
    Friend WithEvents DTResult As DateTimePicker
    Friend WithEvents cboAddSub As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents DT1Minutes As NumericUpDown
    Friend WithEvents DT1Hours As NumericUpDown
    Friend WithEvents DT1Days As NumericUpDown
    Friend WithEvents txtLocBZTInfo As TextBox
    Public WithEvents cboLoB As ComboBox
    Public WithEvents txtLoMinB As TextBox
    Public WithEvents txtLoDegB As TextBox
    Public WithEvents Label1 As Label
    Friend WithEvents cboLocBZD As ComboBox
    Public WithEvents Label5 As Label
End Class
