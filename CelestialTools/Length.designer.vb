<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FormLength
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
    Public WithEvents txtLMin As System.Windows.Forms.TextBox
    Public WithEvents txtLDeg As System.Windows.Forms.TextBox
    'Public WithEvents Line1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents lblDRL As System.Windows.Forms.Label
    Public WithEvents lblLDeg As System.Windows.Forms.Label
    Public WithEvents lblLMin As System.Windows.Forms.Label
    'Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLength))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.txtLMin = New System.Windows.Forms.TextBox()
        Me.txtLDeg = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDRL = New System.Windows.Forms.Label()
        Me.lblLDeg = New System.Windows.Forms.Label()
        Me.lblLMin = New System.Windows.Forms.Label()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.CalcBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrint.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.Location = New System.Drawing.Point(1159, 7)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrint.Size = New System.Drawing.Size(25, 25)
        Me.cmdPrint.TabIndex = 6
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdPrint, "Print window")
        Me.cmdPrint.UseVisualStyleBackColor = False
        '
        'txtLMin
        '
        Me.txtLMin.AcceptsReturn = True
        Me.txtLMin.BackColor = System.Drawing.SystemColors.Window
        Me.txtLMin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLMin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLMin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLMin.Location = New System.Drawing.Point(85, 53)
        Me.txtLMin.MaxLength = 4
        Me.txtLMin.Name = "txtLMin"
        Me.txtLMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLMin.Size = New System.Drawing.Size(33, 20)
        Me.txtLMin.TabIndex = 1
        Me.txtLMin.Text = "0"
        Me.txtLMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtLMin, "Range 0 to 59.9")
        '
        'txtLDeg
        '
        Me.txtLDeg.AcceptsReturn = True
        Me.txtLDeg.BackColor = System.Drawing.SystemColors.Window
        Me.txtLDeg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLDeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLDeg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLDeg.Location = New System.Drawing.Point(53, 53)
        Me.txtLDeg.MaxLength = 2
        Me.txtLDeg.Name = "txtLDeg"
        Me.txtLDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLDeg.Size = New System.Drawing.Size(25, 20)
        Me.txtLDeg.TabIndex = 0
        Me.txtLDeg.Text = "0"
        Me.txtLDeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtLDeg, "Range 0 to 90")
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(123, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(38, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "N or S"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDRL
        '
        Me.lblDRL.BackColor = System.Drawing.SystemColors.Window
        Me.lblDRL.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDRL.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDRL.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDRL.Location = New System.Drawing.Point(3, 54)
        Me.lblDRL.Name = "lblDRL"
        Me.lblDRL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDRL.Size = New System.Drawing.Size(51, 20)
        Me.lblDRL.TabIndex = 4
        Me.lblDRL.Text = "Latitude"
        Me.lblDRL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLDeg
        '
        Me.lblLDeg.BackColor = System.Drawing.SystemColors.Window
        Me.lblLDeg.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLDeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLDeg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLDeg.Location = New System.Drawing.Point(78, 53)
        Me.lblLDeg.Name = "lblLDeg"
        Me.lblLDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLDeg.Size = New System.Drawing.Size(9, 17)
        Me.lblLDeg.TabIndex = 3
        Me.lblLDeg.Text = "°"
        '
        'lblLMin
        '
        Me.lblLMin.BackColor = System.Drawing.SystemColors.Window
        Me.lblLMin.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLMin.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLMin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLMin.Location = New System.Drawing.Point(118, 53)
        Me.lblLMin.Name = "lblLMin"
        Me.lblLMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLMin.Size = New System.Drawing.Size(9, 17)
        Me.lblLMin.TabIndex = 2
        Me.lblLMin.Text = "'"
        '
        'txtLength
        '
        Me.txtLength.Location = New System.Drawing.Point(2, 89)
        Me.txtLength.Multiline = True
        Me.txtLength.Name = "txtLength"
        Me.txtLength.ReadOnly = True
        Me.txtLength.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLength.Size = New System.Drawing.Size(328, 386)
        Me.txtLength.TabIndex = 8
        '
        'CalcBtn
        '
        Me.CalcBtn.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.CalcBtn.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalcBtn.ForeColor = System.Drawing.SystemColors.Window
        Me.CalcBtn.Location = New System.Drawing.Point(167, 49)
        Me.CalcBtn.Name = "CalcBtn"
        Me.CalcBtn.Size = New System.Drawing.Size(161, 27)
        Me.CalcBtn.TabIndex = 9
        Me.CalcBtn.Text = "Calculate Latitude Detail"
        Me.CalcBtn.UseVisualStyleBackColor = False
        '
        'ExitBtn
        '
        Me.ExitBtn.BackColor = System.Drawing.Color.Red
        Me.ExitBtn.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitBtn.ForeColor = System.Drawing.SystemColors.Window
        Me.ExitBtn.Location = New System.Drawing.Point(1117, 493)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(67, 27)
        Me.ExitBtn.TabIndex = 10
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CelestialTools.My.Resources.Resources.ABC_white
        Me.PictureBox1.Location = New System.Drawing.Point(434, 481)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(316, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 102
        Me.PictureBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Location = New System.Drawing.Point(346, 44)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.Size = New System.Drawing.Size(838, 431)
        Me.DataGridView1.TabIndex = 103
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1150, 23)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "How the Length of Latitude and Longitude Changes with Latitude: Use General Data " &
    "Table Below or Input Individual Latitude for Details"
        '
        'FormLength
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1211, 543)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.CalcBtn)
        Me.Controls.Add(Me.txtLength)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.txtLMin)
        Me.Controls.Add(Me.txtLDeg)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDRL)
        Me.Controls.Add(Me.lblLDeg)
        Me.Controls.Add(Me.lblLMin)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(3, 29)
        Me.MaximizeBox = False
        Me.Name = "FormLength"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Length of a degree"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtLength As TextBox
    Friend WithEvents CalcBtn As Button
    Friend WithEvents ExitBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
#End Region
End Class