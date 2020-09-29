<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmPointsOnGCR
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
	Public WithEvents txtLoPointDeg As System.Windows.Forms.TextBox
	Public WithEvents txtLoPointMin As System.Windows.Forms.TextBox
	Public WithEvents cboLoPoint As System.Windows.Forms.ComboBox
	Public WithEvents cmdWaypoint As System.Windows.Forms.Button
	Public WithEvents cmdPrint As System.Windows.Forms.Button
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents lblWaypointLo As System.Windows.Forms.Label
    Public WithEvents lblLoDeg As System.Windows.Forms.Label
    Public WithEvents lblLoMin As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPointsOnGCR))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtLoPointDeg = New System.Windows.Forms.TextBox()
        Me.txtLoPointMin = New System.Windows.Forms.TextBox()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cboLoPoint = New System.Windows.Forms.ComboBox()
        Me.cmdWaypoint = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblWaypointLo = New System.Windows.Forms.Label()
        Me.lblLoDeg = New System.Windows.Forms.Label()
        Me.lblLoMin = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.DGGCR = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGGCR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtLoPointDeg
        '
        Me.txtLoPointDeg.AcceptsReturn = True
        Me.txtLoPointDeg.BackColor = System.Drawing.SystemColors.Window
        Me.txtLoPointDeg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLoPointDeg.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoPointDeg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLoPointDeg.Location = New System.Drawing.Point(442, 106)
        Me.txtLoPointDeg.MaxLength = 3
        Me.txtLoPointDeg.Name = "txtLoPointDeg"
        Me.txtLoPointDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLoPointDeg.Size = New System.Drawing.Size(33, 21)
        Me.txtLoPointDeg.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.txtLoPointDeg, "Range 0 to 180")
        '
        'txtLoPointMin
        '
        Me.txtLoPointMin.AcceptsReturn = True
        Me.txtLoPointMin.BackColor = System.Drawing.SystemColors.Window
        Me.txtLoPointMin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLoPointMin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoPointMin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLoPointMin.Location = New System.Drawing.Point(482, 106)
        Me.txtLoPointMin.MaxLength = 4
        Me.txtLoPointMin.Name = "txtLoPointMin"
        Me.txtLoPointMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLoPointMin.Size = New System.Drawing.Size(33, 21)
        Me.txtLoPointMin.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.txtLoPointMin, "Range 0 to 59.9")
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrint.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.Location = New System.Drawing.Point(552, 0)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrint.Size = New System.Drawing.Size(21, 21)
        Me.cmdPrint.TabIndex = 2
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdPrint, "Print window")
        Me.cmdPrint.UseVisualStyleBackColor = False
        '
        'cboLoPoint
        '
        Me.cboLoPoint.BackColor = System.Drawing.SystemColors.Window
        Me.cboLoPoint.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboLoPoint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLoPoint.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLoPoint.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboLoPoint.Items.AddRange(New Object() {"W", "E"})
        Me.cboLoPoint.Location = New System.Drawing.Point(522, 106)
        Me.cboLoPoint.Name = "cboLoPoint"
        Me.cboLoPoint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboLoPoint.Size = New System.Drawing.Size(41, 21)
        Me.cboLoPoint.TabIndex = 4
        '
        'cmdWaypoint
        '
        Me.cmdWaypoint.BackColor = System.Drawing.SystemColors.Control
        Me.cmdWaypoint.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdWaypoint.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdWaypoint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdWaypoint.Location = New System.Drawing.Point(442, 133)
        Me.cmdWaypoint.Name = "cmdWaypoint"
        Me.cmdWaypoint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdWaypoint.Size = New System.Drawing.Size(89, 33)
        Me.cmdWaypoint.TabIndex = 3
        Me.cmdWaypoint.Text = "&Point Latitude"
        Me.cmdWaypoint.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Window
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(434, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(104, 32)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "(not necessarily " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "on route)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Window
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(439, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(96, 40)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Individual Point " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "on Great Circle"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWaypointLo
        '
        Me.lblWaypointLo.BackColor = System.Drawing.SystemColors.Window
        Me.lblWaypointLo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblWaypointLo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWaypointLo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblWaypointLo.Location = New System.Drawing.Point(422, 105)
        Me.lblWaypointLo.Name = "lblWaypointLo"
        Me.lblWaypointLo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblWaypointLo.Size = New System.Drawing.Size(20, 23)
        Me.lblWaypointLo.TabIndex = 9
        Me.lblWaypointLo.Text = "Lo"
        Me.lblWaypointLo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLoDeg
        '
        Me.lblLoDeg.BackColor = System.Drawing.SystemColors.Window
        Me.lblLoDeg.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLoDeg.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoDeg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLoDeg.Location = New System.Drawing.Point(472, 106)
        Me.lblLoDeg.Name = "lblLoDeg"
        Me.lblLoDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLoDeg.Size = New System.Drawing.Size(9, 17)
        Me.lblLoDeg.TabIndex = 8
        Me.lblLoDeg.Text = "°"
        '
        'lblLoMin
        '
        Me.lblLoMin.BackColor = System.Drawing.SystemColors.Window
        Me.lblLoMin.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLoMin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoMin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLoMin.Location = New System.Drawing.Point(515, 106)
        Me.lblLoMin.Name = "lblLoMin"
        Me.lblLoMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLoMin.Size = New System.Drawing.Size(9, 17)
        Me.lblLoMin.TabIndex = 7
        Me.lblLoMin.Text = "'"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CelestialTools.My.Resources.Resources.ABC_white
        Me.PictureBox1.Location = New System.Drawing.Point(21, 674)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(390, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 102
        Me.PictureBox1.TabStop = False
        '
        'ExitBtn
        '
        Me.ExitBtn.BackColor = System.Drawing.Color.Red
        Me.ExitBtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExitBtn.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ExitBtn.Location = New System.Drawing.Point(491, 674)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ExitBtn.Size = New System.Drawing.Size(72, 27)
        Me.ExitBtn.TabIndex = 108
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = False
        '
        'DGGCR
        '
        Me.DGGCR.AllowUserToAddRows = False
        Me.DGGCR.AllowUserToDeleteRows = False
        Me.DGGCR.AllowUserToResizeColumns = False
        Me.DGGCR.AllowUserToResizeRows = False
        Me.DGGCR.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.DGGCR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGGCR.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGGCR.Location = New System.Drawing.Point(21, 34)
        Me.DGGCR.Name = "DGGCR"
        Me.DGGCR.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGGCR.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGGCR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DGGCR.Size = New System.Drawing.Size(390, 634)
        Me.DGGCR.TabIndex = 109
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(71, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 22)
        Me.Label1.TabIndex = 110
        Me.Label1.Text = "Points on a Great Circle Route"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(421, 469)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 196)
        Me.Label2.TabIndex = 111
        Me.Label2.Text = resources.GetString("Label2.Text")
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmPointsOnGCR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(576, 720)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGGCR)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtLoPointDeg)
        Me.Controls.Add(Me.txtLoPointMin)
        Me.Controls.Add(Me.cboLoPoint)
        Me.Controls.Add(Me.cmdWaypoint)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblWaypointLo)
        Me.Controls.Add(Me.lblLoDeg)
        Me.Controls.Add(Me.lblLoMin)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(3, 29)
        Me.MaximizeBox = False
        Me.Name = "frmPointsOnGCR"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Points on Great Circle Route"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGGCR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Public WithEvents ExitBtn As Button
    Friend WithEvents DGGCR As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
#End Region
End Class