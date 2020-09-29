<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FormVertical
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
    Public WithEvents txtBH As System.Windows.Forms.TextBox
    Public WithEvents cmdPrint As System.Windows.Forms.Button
    Public WithEvents cmdClear As System.Windows.Forms.Button
    Public WithEvents txtDraft As System.Windows.Forms.TextBox
    Public WithEvents txtCD As System.Windows.Forms.TextBox
    Public WithEvents txtHeight As System.Windows.Forms.TextBox
    Public WithEvents txtCH As System.Windows.Forms.TextBox
    Public WithEvents txtMTR As System.Windows.Forms.TextBox
    Public WithEvents txtMTL As System.Windows.Forms.TextBox
    Public WithEvents cmdCalcVert As System.Windows.Forms.Button
    Public WithEvents Label1 As System.Windows.Forms.Label
    'Public WithEvents Line3 As Microsoft.VisualBasic.PowerPacks.LineShape
    'Public WithEvents Line2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Public WithEvents Label14 As System.Windows.Forms.Label
    'Public WithEvents Line1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Public WithEvents Label13 As System.Windows.Forms.Label
    Public WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    'Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormVertical))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtBH = New System.Windows.Forms.TextBox()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.txtDraft = New System.Windows.Forms.TextBox()
        Me.txtCD = New System.Windows.Forms.TextBox()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.txtCH = New System.Windows.Forms.TextBox()
        Me.txtMTR = New System.Windows.Forms.TextBox()
        Me.txtMTL = New System.Windows.Forms.TextBox()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdCalcVert = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.VerticalTxtBx = New System.Windows.Forms.RichTextBox()
        Me.DepthTxtBx = New System.Windows.Forms.RichTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ExitBtn = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBH
        '
        Me.txtBH.AcceptsReturn = True
        Me.txtBH.BackColor = System.Drawing.SystemColors.Window
        Me.txtBH.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBH.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBH.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBH.Location = New System.Drawing.Point(320, 136)
        Me.txtBH.MaxLength = 5
        Me.txtBH.Name = "txtBH"
        Me.txtBH.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBH.Size = New System.Drawing.Size(41, 21)
        Me.txtBH.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.txtBH, "Max. 999.9")
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrint.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.Location = New System.Drawing.Point(460, 0)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrint.Size = New System.Drawing.Size(21, 21)
        Me.cmdPrint.TabIndex = 17
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdPrint, "Print window")
        Me.cmdPrint.UseVisualStyleBackColor = False
        '
        'txtDraft
        '
        Me.txtDraft.AcceptsReturn = True
        Me.txtDraft.BackColor = System.Drawing.SystemColors.Window
        Me.txtDraft.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDraft.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDraft.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDraft.Location = New System.Drawing.Point(328, 304)
        Me.txtDraft.MaxLength = 4
        Me.txtDraft.Name = "txtDraft"
        Me.txtDraft.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDraft.Size = New System.Drawing.Size(33, 21)
        Me.txtDraft.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.txtDraft, "Range 0 to 99.9")
        '
        'txtCD
        '
        Me.txtCD.AcceptsReturn = True
        Me.txtCD.BackColor = System.Drawing.SystemColors.Window
        Me.txtCD.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCD.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCD.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCD.Location = New System.Drawing.Point(328, 280)
        Me.txtCD.MaxLength = 4
        Me.txtCD.Name = "txtCD"
        Me.txtCD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCD.Size = New System.Drawing.Size(33, 21)
        Me.txtCD.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.txtCD, "Range 0 to 99.9")
        '
        'txtHeight
        '
        Me.txtHeight.AcceptsReturn = True
        Me.txtHeight.BackColor = System.Drawing.SystemColors.Window
        Me.txtHeight.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHeight.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHeight.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHeight.Location = New System.Drawing.Point(328, 8)
        Me.txtHeight.MaxLength = 5
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHeight.Size = New System.Drawing.Size(33, 21)
        Me.txtHeight.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtHeight, "Range -99.9 to 99.9")
        '
        'txtCH
        '
        Me.txtCH.AcceptsReturn = True
        Me.txtCH.BackColor = System.Drawing.SystemColors.Window
        Me.txtCH.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCH.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCH.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCH.Location = New System.Drawing.Point(320, 64)
        Me.txtCH.MaxLength = 5
        Me.txtCH.Name = "txtCH"
        Me.txtCH.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCH.Size = New System.Drawing.Size(41, 21)
        Me.txtCH.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtCH, "Range 0 to 999.9")
        '
        'txtMTR
        '
        Me.txtMTR.AcceptsReturn = True
        Me.txtMTR.BackColor = System.Drawing.SystemColors.Window
        Me.txtMTR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMTR.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMTR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMTR.Location = New System.Drawing.Point(328, 88)
        Me.txtMTR.MaxLength = 4
        Me.txtMTR.Name = "txtMTR"
        Me.txtMTR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMTR.Size = New System.Drawing.Size(33, 21)
        Me.txtMTR.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.txtMTR, "Range 0 to 99.9")
        '
        'txtMTL
        '
        Me.txtMTL.AcceptsReturn = True
        Me.txtMTL.BackColor = System.Drawing.SystemColors.Window
        Me.txtMTL.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMTL.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMTL.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMTL.Location = New System.Drawing.Point(328, 112)
        Me.txtMTL.MaxLength = 4
        Me.txtMTL.Name = "txtMTL"
        Me.txtMTL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMTL.Size = New System.Drawing.Size(33, 21)
        Me.txtMTL.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txtMTL, "Range 0 to 99.9")
        '
        'cmdClear
        '
        Me.cmdClear.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClear.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClear.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClear.Location = New System.Drawing.Point(328, 376)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClear.Size = New System.Drawing.Size(89, 25)
        Me.cmdClear.TabIndex = 8
        Me.cmdClear.Text = "&Clear"
        Me.cmdClear.UseVisualStyleBackColor = False
        '
        'cmdCalcVert
        '
        Me.cmdCalcVert.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCalcVert.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCalcVert.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCalcVert.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCalcVert.Location = New System.Drawing.Point(64, 376)
        Me.cmdCalcVert.Name = "cmdCalcVert"
        Me.cmdCalcVert.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCalcVert.Size = New System.Drawing.Size(177, 25)
        Me.cmdCalcVert.TabIndex = 7
        Me.cmdCalcVert.Text = "Calculate &Vertical Clearances"
        Me.cmdCalcVert.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(120, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(89, 17)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Boat (mast) height"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Window
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(96, 8)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(137, 17)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Height of tide at desired time"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Window
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(120, 88)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(161, 17)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Mean Tidal Range (from Table 2)"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Window
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(120, 112)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(153, 17)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Mean Tide Level (from Table 2)"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Window
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(120, 64)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(193, 17)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Charted Height of object (above MHW)"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Window
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(120, 304)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(57, 17)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Boat's Draft"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Window
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(120, 280)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(73, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Charted Depth"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Window
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(200, 256)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(89, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Depth Under Keel"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Window
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(200, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(89, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Vertical Clearance"
        '
        'VerticalTxtBx
        '
        Me.VerticalTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.VerticalTxtBx.Location = New System.Drawing.Point(2, 159)
        Me.VerticalTxtBx.Name = "VerticalTxtBx"
        Me.VerticalTxtBx.ReadOnly = True
        Me.VerticalTxtBx.Size = New System.Drawing.Size(476, 85)
        Me.VerticalTxtBx.TabIndex = 20
        Me.VerticalTxtBx.Text = ""
        '
        'DepthTxtBx
        '
        Me.DepthTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DepthTxtBx.Location = New System.Drawing.Point(2, 327)
        Me.DepthTxtBx.Name = "DepthTxtBx"
        Me.DepthTxtBx.ReadOnly = True
        Me.DepthTxtBx.Size = New System.Drawing.Size(476, 35)
        Me.DepthTxtBx.TabIndex = 21
        Me.DepthTxtBx.Text = ""
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CelestialTools.My.Resources.Resources.ABC_white
        Me.PictureBox1.Location = New System.Drawing.Point(67, 405)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(316, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 103
        Me.PictureBox1.TabStop = False
        '
        'ExitBtn
        '
        Me.ExitBtn.BackColor = System.Drawing.Color.Red
        Me.ExitBtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExitBtn.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ExitBtn.Location = New System.Drawing.Point(406, 407)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ExitBtn.Size = New System.Drawing.Size(63, 25)
        Me.ExitBtn.TabIndex = 108
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = False
        '
        'FormVertical
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(481, 458)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DepthTxtBx)
        Me.Controls.Add(Me.VerticalTxtBx)
        Me.Controls.Add(Me.txtBH)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.txtDraft)
        Me.Controls.Add(Me.txtCD)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.txtCH)
        Me.Controls.Add(Me.txtMTR)
        Me.Controls.Add(Me.txtMTL)
        Me.Controls.Add(Me.cmdCalcVert)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.Name = "FormVertical"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Vertical Clearances"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents VerticalTxtBx As RichTextBox
    Friend WithEvents DepthTxtBx As RichTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Public WithEvents ExitBtn As Button
#End Region
End Class