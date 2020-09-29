<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HelpV2
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
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cboHelpList = New System.Windows.Forms.ComboBox()
        Me.txtHelpInfo = New System.Windows.Forms.RichTextBox()
        Me.lblSelScreen = New System.Windows.Forms.Label()
        Me.btnPrintThisInfo = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ExitBtn
        '
        Me.ExitBtn.BackColor = System.Drawing.Color.Red
        Me.ExitBtn.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitBtn.ForeColor = System.Drawing.Color.White
        Me.ExitBtn.Location = New System.Drawing.Point(587, 661)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(75, 23)
        Me.ExitBtn.TabIndex = 38
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(190, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 26)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Celestial Tools Help Info "
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CelestialTools.My.Resources.Resources.ABC_white
        Me.PictureBox1.Location = New System.Drawing.Point(190, 653)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(316, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 123
        Me.PictureBox1.TabStop = False
        '
        'cboHelpList
        '
        Me.cboHelpList.BackColor = System.Drawing.SystemColors.Window
        Me.cboHelpList.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboHelpList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHelpList.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboHelpList.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboHelpList.Location = New System.Drawing.Point(210, 42)
        Me.cboHelpList.Name = "cboHelpList"
        Me.cboHelpList.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboHelpList.Size = New System.Drawing.Size(225, 22)
        Me.cboHelpList.TabIndex = 124
        '
        'txtHelpInfo
        '
        Me.txtHelpInfo.Location = New System.Drawing.Point(13, 70)
        Me.txtHelpInfo.Margin = New System.Windows.Forms.Padding(10)
        Me.txtHelpInfo.Name = "txtHelpInfo"
        Me.txtHelpInfo.ReadOnly = True
        Me.txtHelpInfo.Size = New System.Drawing.Size(649, 573)
        Me.txtHelpInfo.TabIndex = 125
        Me.txtHelpInfo.TabStop = False
        Me.txtHelpInfo.Text = ""
        '
        'lblSelScreen
        '
        Me.lblSelScreen.AutoSize = True
        Me.lblSelScreen.Location = New System.Drawing.Point(33, 47)
        Me.lblSelScreen.Name = "lblSelScreen"
        Me.lblSelScreen.Size = New System.Drawing.Size(169, 13)
        Me.lblSelScreen.TabIndex = 126
        Me.lblSelScreen.Text = "Select Screen Name For Help Info"
        '
        'btnPrintThisInfo
        '
        Me.btnPrintThisInfo.BackColor = System.Drawing.Color.Yellow
        Me.btnPrintThisInfo.Location = New System.Drawing.Point(512, 42)
        Me.btnPrintThisInfo.Name = "btnPrintThisInfo"
        Me.btnPrintThisInfo.Size = New System.Drawing.Size(150, 23)
        Me.btnPrintThisInfo.TabIndex = 127
        Me.btnPrintThisInfo.Text = "Print This Help Info"
        Me.btnPrintThisInfo.UseVisualStyleBackColor = False
        '
        'HelpV2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 715)
        Me.Controls.Add(Me.btnPrintThisInfo)
        Me.Controls.Add(Me.lblSelScreen)
        Me.Controls.Add(Me.txtHelpInfo)
        Me.Controls.Add(Me.cboHelpList)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ExitBtn)
        Me.Name = "HelpV2"
        Me.Text = "Celestial Tools Help"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ExitBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Public WithEvents cboHelpList As ComboBox
    Friend WithEvents txtHelpInfo As RichTextBox
    Friend WithEvents lblSelScreen As Label
    Friend WithEvents btnPrintThisInfo As Button
End Class
