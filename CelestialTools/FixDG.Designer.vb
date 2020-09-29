<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FixDG
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FixDG))
        Me.DGFix = New System.Windows.Forms.DataGridView()
        Me.DGSelect = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DGSightNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGBodyName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGZoneTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGIntercept = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGAzimuth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGLat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGLong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFixZT = New System.Windows.Forms.Label()
        Me.txtFixZT = New System.Windows.Forms.TextBox()
        Me.txtFixLat = New System.Windows.Forms.TextBox()
        Me.lbFixLat = New System.Windows.Forms.Label()
        Me.txtFixLong = New System.Windows.Forms.TextBox()
        Me.lblFixLong = New System.Windows.Forms.Label()
        Me.txtFixIntercept = New System.Windows.Forms.TextBox()
        Me.lblFixIntercept = New System.Windows.Forms.Label()
        Me.txtFixBearing = New System.Windows.Forms.TextBox()
        Me.lblFixAZ = New System.Windows.Forms.Label()
        Me.GrpBxFix = New System.Windows.Forms.GroupBox()
        Me.btnUseCLS = New System.Windows.Forms.Button()
        Me.btnCustomPlot = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtUserInfo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.DGFix, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBxFix.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGFix
        '
        Me.DGFix.AllowUserToAddRows = False
        Me.DGFix.AllowUserToDeleteRows = False
        Me.DGFix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGFix.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGSelect, Me.DGSightNum, Me.DGBodyName, Me.DGZoneTime, Me.DGIntercept, Me.DGAzimuth, Me.DGLat, Me.DGLong})
        Me.DGFix.Location = New System.Drawing.Point(8, 120)
        Me.DGFix.Name = "DGFix"
        Me.DGFix.ReadOnly = True
        Me.DGFix.Size = New System.Drawing.Size(635, 317)
        Me.DGFix.TabIndex = 0
        '
        'DGSelect
        '
        Me.DGSelect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DGSelect.HeaderText = "Select"
        Me.DGSelect.Name = "DGSelect"
        Me.DGSelect.ReadOnly = True
        Me.DGSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.DGSelect.Width = 62
        '
        'DGSightNum
        '
        Me.DGSightNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DGSightNum.HeaderText = "Sight #"
        Me.DGSightNum.Name = "DGSightNum"
        Me.DGSightNum.ReadOnly = True
        Me.DGSightNum.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGSightNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.DGSightNum.Width = 66
        '
        'DGBodyName
        '
        Me.DGBodyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DGBodyName.HeaderText = "Body Name"
        Me.DGBodyName.Name = "DGBodyName"
        Me.DGBodyName.ReadOnly = True
        Me.DGBodyName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGBodyName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.DGBodyName.Width = 87
        '
        'DGZoneTime
        '
        Me.DGZoneTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DGZoneTime.HeaderText = "Zone Time"
        Me.DGZoneTime.Name = "DGZoneTime"
        Me.DGZoneTime.ReadOnly = True
        Me.DGZoneTime.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGZoneTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.DGZoneTime.Width = 83
        '
        'DGIntercept
        '
        Me.DGIntercept.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DGIntercept.HeaderText = "Intercept (nm)"
        Me.DGIntercept.Name = "DGIntercept"
        Me.DGIntercept.ReadOnly = True
        Me.DGIntercept.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGIntercept.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.DGIntercept.Width = 97
        '
        'DGAzimuth
        '
        Me.DGAzimuth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DGAzimuth.HeaderText = "Zn"
        Me.DGAzimuth.Name = "DGAzimuth"
        Me.DGAzimuth.ReadOnly = True
        Me.DGAzimuth.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGAzimuth.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.DGAzimuth.Width = 45
        '
        'DGLat
        '
        Me.DGLat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DGLat.HeaderText = "Latitude"
        Me.DGLat.Name = "DGLat"
        Me.DGLat.ReadOnly = True
        Me.DGLat.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGLat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.DGLat.Width = 70
        '
        'DGLong
        '
        Me.DGLong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DGLong.HeaderText = "Longitude"
        Me.DGLong.Name = "DGLong"
        Me.DGLong.ReadOnly = True
        Me.DGLong.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGLong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.DGLong.Width = 79
        '
        'ExitBtn
        '
        Me.ExitBtn.BackColor = System.Drawing.Color.Red
        Me.ExitBtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExitBtn.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ExitBtn.Location = New System.Drawing.Point(581, 443)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ExitBtn.Size = New System.Drawing.Size(62, 25)
        Me.ExitBtn.TabIndex = 25
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.SystemColors.Control
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnPrint.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.Location = New System.Drawing.Point(608, 12)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnPrint.Size = New System.Drawing.Size(30, 26)
        Me.btnPrint.TabIndex = 26
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(219, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 16)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Calculated Fix for Sights Selected" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblFixZT
        '
        Me.lblFixZT.AutoSize = True
        Me.lblFixZT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFixZT.Location = New System.Drawing.Point(52, 21)
        Me.lblFixZT.Name = "lblFixZT"
        Me.lblFixZT.Size = New System.Drawing.Size(94, 16)
        Me.lblFixZT.TabIndex = 31
        Me.lblFixZT.Text = "Zone Time ="
        Me.lblFixZT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtFixZT
        '
        Me.txtFixZT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFixZT.Location = New System.Drawing.Point(146, 18)
        Me.txtFixZT.Name = "txtFixZT"
        Me.txtFixZT.ReadOnly = True
        Me.txtFixZT.Size = New System.Drawing.Size(100, 22)
        Me.txtFixZT.TabIndex = 32
        Me.txtFixZT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFixLat
        '
        Me.txtFixLat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFixLat.Location = New System.Drawing.Point(293, 18)
        Me.txtFixLat.Name = "txtFixLat"
        Me.txtFixLat.ReadOnly = True
        Me.txtFixLat.Size = New System.Drawing.Size(100, 22)
        Me.txtFixLat.TabIndex = 34
        Me.txtFixLat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbFixLat
        '
        Me.lbFixLat.AutoSize = True
        Me.lbFixLat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFixLat.Location = New System.Drawing.Point(252, 21)
        Me.lbFixLat.Name = "lbFixLat"
        Me.lbFixLat.Size = New System.Drawing.Size(41, 16)
        Me.lbFixLat.TabIndex = 33
        Me.lbFixLat.Text = "Lat ="
        Me.lbFixLat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtFixLong
        '
        Me.txtFixLong.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFixLong.Location = New System.Drawing.Point(464, 19)
        Me.txtFixLong.Name = "txtFixLong"
        Me.txtFixLong.ReadOnly = True
        Me.txtFixLong.Size = New System.Drawing.Size(100, 22)
        Me.txtFixLong.TabIndex = 36
        Me.txtFixLong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFixLong
        '
        Me.lblFixLong.AutoSize = True
        Me.lblFixLong.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFixLong.Location = New System.Drawing.Point(405, 21)
        Me.lblFixLong.Name = "lblFixLong"
        Me.lblFixLong.Size = New System.Drawing.Size(54, 16)
        Me.lblFixLong.TabIndex = 35
        Me.lblFixLong.Text = "Long ="
        Me.lblFixLong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtFixIntercept
        '
        Me.txtFixIntercept.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFixIntercept.Location = New System.Drawing.Point(293, 42)
        Me.txtFixIntercept.Name = "txtFixIntercept"
        Me.txtFixIntercept.ReadOnly = True
        Me.txtFixIntercept.Size = New System.Drawing.Size(51, 22)
        Me.txtFixIntercept.TabIndex = 38
        Me.txtFixIntercept.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFixIntercept
        '
        Me.lblFixIntercept.AutoSize = True
        Me.lblFixIntercept.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFixIntercept.Location = New System.Drawing.Point(172, 45)
        Me.lblFixIntercept.Name = "lblFixIntercept"
        Me.lblFixIntercept.Size = New System.Drawing.Size(115, 16)
        Me.lblFixIntercept.TabIndex = 37
        Me.lblFixIntercept.Text = "Distance (nm) ="
        Me.lblFixIntercept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtFixBearing
        '
        Me.txtFixBearing.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFixBearing.Location = New System.Drawing.Point(507, 42)
        Me.txtFixBearing.Name = "txtFixBearing"
        Me.txtFixBearing.ReadOnly = True
        Me.txtFixBearing.Size = New System.Drawing.Size(55, 22)
        Me.txtFixBearing.TabIndex = 40
        Me.txtFixBearing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFixAZ
        '
        Me.lblFixAZ.AutoSize = True
        Me.lblFixAZ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFixAZ.Location = New System.Drawing.Point(354, 45)
        Me.lblFixAZ.Name = "lblFixAZ"
        Me.lblFixAZ.Size = New System.Drawing.Size(150, 16)
        Me.lblFixAZ.TabIndex = 39
        Me.lblFixAZ.Text = "and Bearing (True) ="
        Me.lblFixAZ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GrpBxFix
        '
        Me.GrpBxFix.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GrpBxFix.Controls.Add(Me.txtFixLat)
        Me.GrpBxFix.Controls.Add(Me.txtFixBearing)
        Me.GrpBxFix.Controls.Add(Me.lblFixZT)
        Me.GrpBxFix.Controls.Add(Me.lblFixAZ)
        Me.GrpBxFix.Controls.Add(Me.txtFixZT)
        Me.GrpBxFix.Controls.Add(Me.txtFixIntercept)
        Me.GrpBxFix.Controls.Add(Me.lbFixLat)
        Me.GrpBxFix.Controls.Add(Me.lblFixIntercept)
        Me.GrpBxFix.Controls.Add(Me.lblFixLong)
        Me.GrpBxFix.Controls.Add(Me.txtFixLong)
        Me.GrpBxFix.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpBxFix.Location = New System.Drawing.Point(13, 44)
        Me.GrpBxFix.Name = "GrpBxFix"
        Me.GrpBxFix.Size = New System.Drawing.Size(630, 70)
        Me.GrpBxFix.TabIndex = 41
        Me.GrpBxFix.TabStop = False
        Me.GrpBxFix.Text = "Fix calculated at:"
        '
        'btnUseCLS
        '
        Me.btnUseCLS.BackColor = System.Drawing.Color.Yellow
        Me.btnUseCLS.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUseCLS.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnUseCLS.Location = New System.Drawing.Point(8, 445)
        Me.btnUseCLS.Name = "btnUseCLS"
        Me.btnUseCLS.Size = New System.Drawing.Size(110, 23)
        Me.btnUseCLS.TabIndex = 174
        Me.btnUseCLS.Text = "CLS Form Plot"
        Me.btnUseCLS.UseVisualStyleBackColor = False
        Me.btnUseCLS.Visible = False
        '
        'btnCustomPlot
        '
        Me.btnCustomPlot.BackColor = System.Drawing.Color.Yellow
        Me.btnCustomPlot.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomPlot.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnCustomPlot.Location = New System.Drawing.Point(8, 474)
        Me.btnCustomPlot.Name = "btnCustomPlot"
        Me.btnCustomPlot.Size = New System.Drawing.Size(110, 23)
        Me.btnCustomPlot.TabIndex = 175
        Me.btnCustomPlot.Text = "Custom Plot Form"
        Me.btnCustomPlot.UseVisualStyleBackColor = False
        Me.btnCustomPlot.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CelestialTools.My.Resources.Resources.ABC_white
        Me.PictureBox1.Location = New System.Drawing.Point(177, 515)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(338, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 176
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(125, 443)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(450, 66)
        Me.TextBox1.TabIndex = 177
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUserInfo
        '
        Me.txtUserInfo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserInfo.HideSelection = False
        Me.txtUserInfo.Location = New System.Drawing.Point(148, 21)
        Me.txtUserInfo.Name = "txtUserInfo"
        Me.txtUserInfo.Size = New System.Drawing.Size(400, 20)
        Me.txtUserInfo.TabIndex = 202
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(93, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 14)
        Me.Label7.TabIndex = 201
        Me.Label7.Text = "User Info"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FixDG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 570)
        Me.Controls.Add(Me.txtUserInfo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCustomPlot)
        Me.Controls.Add(Me.btnUseCLS)
        Me.Controls.Add(Me.GrpBxFix)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.DGFix)
        Me.Name = "FixDG"
        Me.Text = "Fix Calculation for Selected Sights"
        CType(Me.DGFix, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBxFix.ResumeLayout(False)
        Me.GrpBxFix.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGFix As DataGridView
    Public WithEvents ExitBtn As Button
    Public WithEvents btnPrint As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblFixZT As Label
    Friend WithEvents txtFixZT As TextBox
    Friend WithEvents txtFixLat As TextBox
    Friend WithEvents lbFixLat As Label
    Friend WithEvents txtFixLong As TextBox
    Friend WithEvents lblFixLong As Label
    Friend WithEvents txtFixIntercept As TextBox
    Friend WithEvents lblFixIntercept As Label
    Friend WithEvents txtFixBearing As TextBox
    Friend WithEvents lblFixAZ As Label
    Friend WithEvents GrpBxFix As GroupBox
    Friend WithEvents btnUseCLS As Button
    Friend WithEvents btnCustomPlot As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DGSelect As DataGridViewCheckBoxColumn
    Friend WithEvents DGSightNum As DataGridViewTextBoxColumn
    Friend WithEvents DGBodyName As DataGridViewTextBoxColumn
    Friend WithEvents DGZoneTime As DataGridViewTextBoxColumn
    Friend WithEvents DGIntercept As DataGridViewTextBoxColumn
    Friend WithEvents DGAzimuth As DataGridViewTextBoxColumn
    Friend WithEvents DGLat As DataGridViewTextBoxColumn
    Friend WithEvents DGLong As DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtUserInfo As TextBox
    Friend WithEvents Label7 As Label
End Class
