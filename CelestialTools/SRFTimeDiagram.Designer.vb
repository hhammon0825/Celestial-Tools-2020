<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SRFTimeDiagram
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SRFTimeDiagram))
        Me.EqtPicBx = New System.Windows.Forms.PictureBox()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.chkDispEqt = New System.Windows.Forms.CheckBox()
        CType(Me.EqtPicBx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EqtPicBx
        '
        Me.EqtPicBx.BackColor = System.Drawing.Color.LightGray
        Me.EqtPicBx.Location = New System.Drawing.Point(13, 7)
        Me.EqtPicBx.Name = "EqtPicBx"
        Me.EqtPicBx.Size = New System.Drawing.Size(700, 700)
        Me.EqtPicBx.TabIndex = 0
        Me.EqtPicBx.TabStop = False
        '
        'ExitBtn
        '
        Me.ExitBtn.BackColor = System.Drawing.Color.Red
        Me.ExitBtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExitBtn.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ExitBtn.Location = New System.Drawing.Point(650, 711)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ExitBtn.Size = New System.Drawing.Size(63, 25)
        Me.ExitBtn.TabIndex = 108
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CelestialTools.My.Resources.Resources.ABC_white
        Me.PictureBox1.Location = New System.Drawing.Point(229, 711)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(316, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 123
        Me.PictureBox1.TabStop = False
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrint.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.Location = New System.Drawing.Point(690, 740)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrint.Size = New System.Drawing.Size(21, 21)
        Me.cmdPrint.TabIndex = 124
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdPrint.UseVisualStyleBackColor = False
        '
        'chkDispEqt
        '
        Me.chkDispEqt.AutoSize = True
        Me.chkDispEqt.Location = New System.Drawing.Point(22, 727)
        Me.chkDispEqt.Name = "chkDispEqt"
        Me.chkDispEqt.Size = New System.Drawing.Size(201, 17)
        Me.chkDispEqt.TabIndex = 125
        Me.chkDispEqt.Text = "Display Apparent Sun and Eqt Factor"
        Me.chkDispEqt.UseVisualStyleBackColor = True
        '
        'SRFTimeDiagram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 766)
        Me.Controls.Add(Me.chkDispEqt)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.EqtPicBx)
        Me.Name = "SRFTimeDiagram"
        Me.Text = "SRFTimeDiagram"
        CType(Me.EqtPicBx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EqtPicBx As PictureBox
    Public WithEvents ExitBtn As Button
    Friend WithEvents chkDisplayEqt As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Public WithEvents cmdPrint As Button
    Friend WithEvents chkDispEqt As CheckBox
End Class
