<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomPlot
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomPlot))
        Me.btnPrtSights = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.lblMidLat = New System.Windows.Forms.Label()
        Me.lblMidLong = New System.Windows.Forms.Label()
        Me.cboPlotSize = New System.Windows.Forms.ComboBox()
        Me.lblPlotZoom = New System.Windows.Forms.Label()
        Me.chkDisplayRose = New System.Windows.Forms.CheckBox()
        Me.txtLatActive = New System.Windows.Forms.TextBox()
        Me.txtLongActive = New System.Windows.Forms.TextBox()
        Me.txtUserInfo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PanelPlot = New System.Windows.Forms.Panel()
        Me.PicBoxPlot = New System.Windows.Forms.PictureBox()
        Me.txtDispLoc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.PanelPlot.SuspendLayout()
        CType(Me.PicBoxPlot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPrtSights
        '
        Me.btnPrtSights.BackColor = System.Drawing.Color.Yellow
        Me.btnPrtSights.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnPrtSights.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrtSights.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPrtSights.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrtSights.Location = New System.Drawing.Point(738, 4)
        Me.btnPrtSights.Name = "btnPrtSights"
        Me.btnPrtSights.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnPrtSights.Size = New System.Drawing.Size(105, 25)
        Me.btnPrtSights.TabIndex = 197
        Me.btnPrtSights.Text = "Display Sight Data "
        Me.btnPrtSights.UseVisualStyleBackColor = False
        '
        'ExitBtn
        '
        Me.ExitBtn.BackColor = System.Drawing.Color.Red
        Me.ExitBtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExitBtn.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ExitBtn.Location = New System.Drawing.Point(853, 4)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ExitBtn.Size = New System.Drawing.Size(78, 25)
        Me.ExitBtn.TabIndex = 194
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = False
        '
        'lblMidLat
        '
        Me.lblMidLat.AutoSize = True
        Me.lblMidLat.Location = New System.Drawing.Point(28, 36)
        Me.lblMidLat.Name = "lblMidLat"
        Me.lblMidLat.Size = New System.Drawing.Size(45, 13)
        Me.lblMidLat.TabIndex = 198
        Me.lblMidLat.Text = "Mid Lat:"
        Me.lblMidLat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMidLong
        '
        Me.lblMidLong.AutoSize = True
        Me.lblMidLong.Location = New System.Drawing.Point(198, 36)
        Me.lblMidLong.Name = "lblMidLong"
        Me.lblMidLong.Size = New System.Drawing.Size(54, 13)
        Me.lblMidLong.TabIndex = 200
        Me.lblMidLong.Text = "Mid Long:"
        Me.lblMidLong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboPlotSize
        '
        Me.cboPlotSize.Enabled = False
        Me.cboPlotSize.FormattingEnabled = True
        Me.cboPlotSize.Items.AddRange(New Object() {"Zoom Out to 100 nm / side", "Zoom Out to 80 nm / side", "Default to 60 nm / side", "Zoom in to 40 nm / side", "Zoom In to 20 nm / side"})
        Me.cboPlotSize.Location = New System.Drawing.Point(475, 31)
        Me.cboPlotSize.Name = "cboPlotSize"
        Me.cboPlotSize.Size = New System.Drawing.Size(150, 21)
        Me.cboPlotSize.TabIndex = 203
        '
        'lblPlotZoom
        '
        Me.lblPlotZoom.AutoSize = True
        Me.lblPlotZoom.Location = New System.Drawing.Point(420, 35)
        Me.lblPlotZoom.Name = "lblPlotZoom"
        Me.lblPlotZoom.Size = New System.Drawing.Size(51, 13)
        Me.lblPlotZoom.TabIndex = 202
        Me.lblPlotZoom.Text = "Plot Size:"
        '
        'chkDisplayRose
        '
        Me.chkDisplayRose.AutoSize = True
        Me.chkDisplayRose.Location = New System.Drawing.Point(475, 8)
        Me.chkDisplayRose.Name = "chkDisplayRose"
        Me.chkDisplayRose.Size = New System.Drawing.Size(127, 17)
        Me.chkDisplayRose.TabIndex = 206
        Me.chkDisplayRose.Text = "Show Compass Rose"
        Me.chkDisplayRose.UseVisualStyleBackColor = True
        '
        'txtLatActive
        '
        Me.txtLatActive.Location = New System.Drawing.Point(74, 32)
        Me.txtLatActive.Name = "txtLatActive"
        Me.txtLatActive.ReadOnly = True
        Me.txtLatActive.Size = New System.Drawing.Size(120, 20)
        Me.txtLatActive.TabIndex = 207
        '
        'txtLongActive
        '
        Me.txtLongActive.Location = New System.Drawing.Point(255, 32)
        Me.txtLongActive.Name = "txtLongActive"
        Me.txtLongActive.ReadOnly = True
        Me.txtLongActive.Size = New System.Drawing.Size(120, 20)
        Me.txtLongActive.TabIndex = 208
        '
        'txtUserInfo
        '
        Me.txtUserInfo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserInfo.HideSelection = False
        Me.txtUserInfo.Location = New System.Drawing.Point(74, 5)
        Me.txtUserInfo.Name = "txtUserInfo"
        Me.txtUserInfo.Size = New System.Drawing.Size(387, 20)
        Me.txtUserInfo.TabIndex = 211
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 14)
        Me.Label7.TabIndex = 210
        Me.Label7.Text = "User Info"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelPlot
        '
        Me.PanelPlot.AutoScroll = True
        Me.PanelPlot.AutoScrollMargin = New System.Drawing.Size(10, 10)
        Me.PanelPlot.AutoScrollMinSize = New System.Drawing.Size(10, 10)
        Me.PanelPlot.AutoSize = True
        Me.PanelPlot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelPlot.Controls.Add(Me.PicBoxPlot)
        Me.PanelPlot.Location = New System.Drawing.Point(11, 57)
        Me.PanelPlot.Name = "PanelPlot"
        Me.PanelPlot.Size = New System.Drawing.Size(935, 929)
        Me.PanelPlot.TabIndex = 204
        '
        'PicBoxPlot
        '
        Me.PicBoxPlot.InitialImage = Nothing
        Me.PicBoxPlot.Location = New System.Drawing.Point(12, 4)
        Me.PicBoxPlot.Name = "PicBoxPlot"
        Me.PicBoxPlot.Size = New System.Drawing.Size(900, 900)
        Me.PicBoxPlot.TabIndex = 0
        Me.PicBoxPlot.TabStop = False
        '
        'txtDispLoc
        '
        Me.txtDispLoc.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDispLoc.Location = New System.Drawing.Point(739, 32)
        Me.txtDispLoc.Name = "txtDispLoc"
        Me.txtDispLoc.ReadOnly = True
        Me.txtDispLoc.Size = New System.Drawing.Size(189, 20)
        Me.txtDispLoc.TabIndex = 212
        Me.txtDispLoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(642, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 213
        Me.Label1.Text = "Mouse Click L/Lo:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CelestialTools.My.Resources.Resources.ABC_white
        Me.PictureBox1.Location = New System.Drawing.Point(334, 995)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(312, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 209
        Me.PictureBox1.TabStop = False
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.Color.Yellow
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrint.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdPrint.Location = New System.Drawing.Point(646, 4)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrint.Size = New System.Drawing.Size(78, 25)
        Me.cmdPrint.TabIndex = 195
        Me.cmdPrint.Text = "Print Plot"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPrint.UseVisualStyleBackColor = False
        '
        'CustomPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMargin = New System.Drawing.Size(10, 10)
        Me.ClientSize = New System.Drawing.Size(967, 1061)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDispLoc)
        Me.Controls.Add(Me.txtUserInfo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtLongActive)
        Me.Controls.Add(Me.txtLatActive)
        Me.Controls.Add(Me.chkDisplayRose)
        Me.Controls.Add(Me.PanelPlot)
        Me.Controls.Add(Me.cboPlotSize)
        Me.Controls.Add(Me.lblPlotZoom)
        Me.Controls.Add(Me.lblMidLong)
        Me.Controls.Add(Me.lblMidLat)
        Me.Controls.Add(Me.btnPrtSights)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.ExitBtn)
        Me.Name = "CustomPlot"
        Me.Text = "Adjustable Scale Plot Form"
        Me.PanelPlot.ResumeLayout(False)
        CType(Me.PicBoxPlot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents btnPrtSights As Button
    Public WithEvents cmdPrint As Button
    Public WithEvents ExitBtn As Button
    Friend WithEvents lblMidLat As Label
    Friend WithEvents lblMidLong As Label
    Friend WithEvents cboPlotSize As ComboBox
    Friend WithEvents lblPlotZoom As Label
    Friend WithEvents chkDisplayRose As CheckBox
    Friend WithEvents txtLatActive As TextBox
    Friend WithEvents txtLongActive As TextBox
    Friend WithEvents txtUserInfo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PicBoxPlot As PictureBox
    Friend WithEvents PanelPlot As Panel
    Friend WithEvents txtDispLoc As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
