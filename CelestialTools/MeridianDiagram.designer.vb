<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FormMeridianDiagram
#Region "Windows Form Designer generated code "
    <System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
        MyBase.New()
        'This is required by the Windows Form Designer.
        InitializeComponent()
        'Form_Initialize_renamed()
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
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMeridianDiagram))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.MeridianPicBx = New System.Windows.Forms.PictureBox()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkTwiLites = New System.Windows.Forms.CheckBox()
        Me.chkDispZnLHA = New System.Windows.Forms.CheckBox()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        CType(Me.MeridianPicBx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrint.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.Location = New System.Drawing.Point(682, 7)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrint.Size = New System.Drawing.Size(21, 21)
        Me.cmdPrint.TabIndex = 4
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdPrint, "Print window")
        Me.cmdPrint.UseVisualStyleBackColor = False
        '
        'MeridianPicBx
        '
        Me.MeridianPicBx.BackColor = System.Drawing.Color.LightGray
        Me.MeridianPicBx.Location = New System.Drawing.Point(3, 35)
        Me.MeridianPicBx.Name = "MeridianPicBx"
        Me.MeridianPicBx.Size = New System.Drawing.Size(700, 700)
        Me.MeridianPicBx.TabIndex = 13
        Me.MeridianPicBx.TabStop = False
        '
        'ExitBtn
        '
        Me.ExitBtn.BackColor = System.Drawing.Color.Red
        Me.ExitBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ExitBtn.Location = New System.Drawing.Point(646, 745)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(57, 27)
        Me.ExitBtn.TabIndex = 14
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CelestialTools.My.Resources.Resources.ABC_white
        Me.PictureBox1.Location = New System.Drawing.Point(220, 745)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(316, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 102
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(167, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(340, 18)
        Me.Label1.TabIndex = 103
        Me.Label1.Text = "Projection on the Plane of the Celestial Meridian"
        '
        'chkTwiLites
        '
        Me.chkTwiLites.AutoSize = True
        Me.chkTwiLites.Location = New System.Drawing.Point(32, 41)
        Me.chkTwiLites.Name = "chkTwiLites"
        Me.chkTwiLites.Size = New System.Drawing.Size(104, 17)
        Me.chkTwiLites.TabIndex = 104
        Me.chkTwiLites.Text = "Display Twilights"
        Me.chkTwiLites.UseVisualStyleBackColor = True
        '
        'chkDispZnLHA
        '
        Me.chkDispZnLHA.AutoSize = True
        Me.chkDispZnLHA.Checked = True
        Me.chkDispZnLHA.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDispZnLHA.Location = New System.Drawing.Point(32, 20)
        Me.chkDispZnLHA.Name = "chkDispZnLHA"
        Me.chkDispZnLHA.Size = New System.Drawing.Size(118, 17)
        Me.chkDispZnLHA.TabIndex = 105
        Me.chkDispZnLHA.Text = "Display Zn and LHA"
        Me.chkDispZnLHA.UseVisualStyleBackColor = True
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.chkDispZnLHA)
        Me.grpOptions.Controls.Add(Me.chkTwiLites)
        Me.grpOptions.Location = New System.Drawing.Point(3, 737)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(156, 67)
        Me.grpOptions.TabIndex = 106
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Display Options"
        '
        'FormMeridianDiagram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(716, 812)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.MeridianPicBx)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(3, 29)
        Me.MaximizeBox = False
        Me.Name = "FormMeridianDiagram"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Projection on the Plane of the Celestial Meridian"
        CType(Me.MeridianPicBx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MeridianPicBx As PictureBox
    Friend WithEvents ExitBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chkTwiLites As CheckBox
    Friend WithEvents chkDispZnLHA As CheckBox
    Friend WithEvents grpOptions As GroupBox
#End Region
End Class