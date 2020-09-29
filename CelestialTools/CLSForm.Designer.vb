<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CLSForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CLSForm))
        Me.PicBoxCLS = New System.Windows.Forms.PictureBox()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.btnPrtSights = New System.Windows.Forms.Button()
        Me.txtUserInfo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtLongActive = New System.Windows.Forms.TextBox()
        Me.txtLatActive = New System.Windows.Forms.TextBox()
        Me.lblMidLong = New System.Windows.Forms.Label()
        Me.lblMidLat = New System.Windows.Forms.Label()
        Me.lblPlotZoom = New System.Windows.Forms.Label()
        Me.txtDispLoc = New System.Windows.Forms.TextBox()
        CType(Me.PicBoxCLS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicBoxCLS
        '
        Me.PicBoxCLS.BackgroundImage = CType(resources.GetObject("PicBoxCLS.BackgroundImage"), System.Drawing.Image)
        Me.PicBoxCLS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PicBoxCLS.InitialImage = Nothing
        Me.PicBoxCLS.Location = New System.Drawing.Point(8, 67)
        Me.PicBoxCLS.Name = "PicBoxCLS"
        Me.PicBoxCLS.Size = New System.Drawing.Size(820, 960)
        Me.PicBoxCLS.TabIndex = 0
        Me.PicBoxCLS.TabStop = False
        '
        'ExitBtn
        '
        Me.ExitBtn.BackColor = System.Drawing.Color.Red
        Me.ExitBtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExitBtn.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ExitBtn.Location = New System.Drawing.Point(722, 26)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ExitBtn.Size = New System.Drawing.Size(106, 25)
        Me.ExitBtn.TabIndex = 102
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = False
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.Color.Yellow
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrint.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdPrint.Location = New System.Drawing.Point(497, 26)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrint.Size = New System.Drawing.Size(107, 25)
        Me.cmdPrint.TabIndex = 104
        Me.cmdPrint.Text = "Print Plot"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPrint.UseVisualStyleBackColor = False
        '
        'btnPrtSights
        '
        Me.btnPrtSights.BackColor = System.Drawing.Color.Yellow
        Me.btnPrtSights.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnPrtSights.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrtSights.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPrtSights.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrtSights.Location = New System.Drawing.Point(610, 26)
        Me.btnPrtSights.Name = "btnPrtSights"
        Me.btnPrtSights.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnPrtSights.Size = New System.Drawing.Size(106, 25)
        Me.btnPrtSights.TabIndex = 193
        Me.btnPrtSights.Text = "Display Sight Data"
        Me.btnPrtSights.UseVisualStyleBackColor = False
        '
        'txtUserInfo
        '
        Me.txtUserInfo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserInfo.HideSelection = False
        Me.txtUserInfo.Location = New System.Drawing.Point(69, 3)
        Me.txtUserInfo.Name = "txtUserInfo"
        Me.txtUserInfo.Size = New System.Drawing.Size(387, 20)
        Me.txtUserInfo.TabIndex = 202
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 14)
        Me.Label7.TabIndex = 201
        Me.Label7.Text = "User Info"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtLongActive
        '
        Me.txtLongActive.Location = New System.Drawing.Point(283, 30)
        Me.txtLongActive.Name = "txtLongActive"
        Me.txtLongActive.ReadOnly = True
        Me.txtLongActive.Size = New System.Drawing.Size(150, 20)
        Me.txtLongActive.TabIndex = 212
        '
        'txtLatActive
        '
        Me.txtLatActive.Location = New System.Drawing.Point(69, 30)
        Me.txtLatActive.Name = "txtLatActive"
        Me.txtLatActive.ReadOnly = True
        Me.txtLatActive.Size = New System.Drawing.Size(150, 20)
        Me.txtLatActive.TabIndex = 211
        '
        'lblMidLong
        '
        Me.lblMidLong.AutoSize = True
        Me.lblMidLong.Location = New System.Drawing.Point(225, 34)
        Me.lblMidLong.Name = "lblMidLong"
        Me.lblMidLong.Size = New System.Drawing.Size(54, 13)
        Me.lblMidLong.TabIndex = 210
        Me.lblMidLong.Text = "Mid Long:"
        Me.lblMidLong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMidLat
        '
        Me.lblMidLat.AutoSize = True
        Me.lblMidLat.Location = New System.Drawing.Point(18, 34)
        Me.lblMidLat.Name = "lblMidLat"
        Me.lblMidLat.Size = New System.Drawing.Size(45, 13)
        Me.lblMidLat.TabIndex = 209
        Me.lblMidLat.Text = "Mid Lat:"
        Me.lblMidLat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPlotZoom
        '
        Me.lblPlotZoom.AutoSize = True
        Me.lblPlotZoom.Location = New System.Drawing.Point(462, 8)
        Me.lblPlotZoom.Name = "lblPlotZoom"
        Me.lblPlotZoom.Size = New System.Drawing.Size(94, 13)
        Me.lblPlotZoom.TabIndex = 216
        Me.lblPlotZoom.Text = "Mouse Click L/Lo:"
        '
        'txtDispLoc
        '
        Me.txtDispLoc.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDispLoc.Location = New System.Drawing.Point(560, 4)
        Me.txtDispLoc.Name = "txtDispLoc"
        Me.txtDispLoc.ReadOnly = True
        Me.txtDispLoc.Size = New System.Drawing.Size(198, 20)
        Me.txtDispLoc.TabIndex = 215
        Me.txtDispLoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CLSForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMargin = New System.Drawing.Size(20, 20)
        Me.AutoScrollMinSize = New System.Drawing.Size(856, 1095)
        Me.ClientSize = New System.Drawing.Size(856, 1009)
        Me.Controls.Add(Me.lblPlotZoom)
        Me.Controls.Add(Me.txtDispLoc)
        Me.Controls.Add(Me.txtLongActive)
        Me.Controls.Add(Me.txtLatActive)
        Me.Controls.Add(Me.lblMidLong)
        Me.Controls.Add(Me.lblMidLat)
        Me.Controls.Add(Me.txtUserInfo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnPrtSights)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.PicBoxCLS)
        Me.Name = "CLSForm"
        Me.Text = "Constant Latitude Scale Plot Form"
        CType(Me.PicBoxCLS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PicBoxCLS As PictureBox
    Public WithEvents ExitBtn As Button
    Public WithEvents cmdPrint As Button
    Friend WithEvents txtSquadron As TextBox
    Friend WithEvents lblSquadron As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents txtSightNum As TextBox
    Friend WithEvents lblSightNum As Label
    Public WithEvents btnPrtPlot As Button
    Public WithEvents btnPrtSights As Button
    Friend WithEvents txtUserInfo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtLongActive As TextBox
    Friend WithEvents txtLatActive As TextBox
    Friend WithEvents lblMidLong As Label
    Friend WithEvents lblMidLat As Label
    Friend WithEvents lblPlotZoom As Label
    Friend WithEvents txtDispLoc As TextBox
End Class
