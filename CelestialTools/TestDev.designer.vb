<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestDev
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
        Me.UpDwnCompass = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCompassDev = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCompassDev = New System.Windows.Forms.Button()
        Me.btnMagDev = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMagDev = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UpDwnMag = New System.Windows.Forms.NumericUpDown()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.UpDwnCompass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UpDwnMag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UpDwnCompass
        '
        Me.UpDwnCompass.Location = New System.Drawing.Point(146, 40)
        Me.UpDwnCompass.Maximum = New Decimal(New Integer() {359, 0, 0, 0})
        Me.UpDwnCompass.Name = "UpDwnCompass"
        Me.UpDwnCompass.Size = New System.Drawing.Size(64, 20)
        Me.UpDwnCompass.TabIndex = 0
        Me.UpDwnCompass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Compass Heading:"
        '
        'txtCompassDev
        '
        Me.txtCompassDev.BackColor = System.Drawing.Color.White
        Me.txtCompassDev.Location = New System.Drawing.Point(194, 76)
        Me.txtCompassDev.Name = "txtCompassDev"
        Me.txtCompassDev.ReadOnly = True
        Me.txtCompassDev.Size = New System.Drawing.Size(282, 20)
        Me.txtCompassDev.TabIndex = 2
        Me.txtCompassDev.TabStop = False
        Me.txtCompassDev.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Compass Based Interpolation:"
        '
        'btnCompassDev
        '
        Me.btnCompassDev.BackColor = System.Drawing.Color.Blue
        Me.btnCompassDev.ForeColor = System.Drawing.Color.White
        Me.btnCompassDev.Location = New System.Drawing.Point(238, 38)
        Me.btnCompassDev.Name = "btnCompassDev"
        Me.btnCompassDev.Size = New System.Drawing.Size(180, 23)
        Me.btnCompassDev.TabIndex = 4
        Me.btnCompassDev.Text = "Get Compass Based Interpolation"
        Me.btnCompassDev.UseVisualStyleBackColor = False
        '
        'btnMagDev
        '
        Me.btnMagDev.BackColor = System.Drawing.Color.Yellow
        Me.btnMagDev.Location = New System.Drawing.Point(238, 110)
        Me.btnMagDev.Name = "btnMagDev"
        Me.btnMagDev.Size = New System.Drawing.Size(180, 23)
        Me.btnMagDev.TabIndex = 9
        Me.btnMagDev.Text = "Get Magnetic Based Interpolation"
        Me.btnMagDev.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Magnetic Based Interpolation:"
        '
        'txtMagDev
        '
        Me.txtMagDev.BackColor = System.Drawing.Color.White
        Me.txtMagDev.Location = New System.Drawing.Point(194, 150)
        Me.txtMagDev.Name = "txtMagDev"
        Me.txtMagDev.ReadOnly = True
        Me.txtMagDev.Size = New System.Drawing.Size(282, 20)
        Me.txtMagDev.TabIndex = 7
        Me.txtMagDev.TabStop = False
        Me.txtMagDev.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Magnetic Heading:"
        '
        'UpDwnMag
        '
        Me.UpDwnMag.Location = New System.Drawing.Point(146, 112)
        Me.UpDwnMag.Maximum = New Decimal(New Integer() {359, 0, 0, 0})
        Me.UpDwnMag.Name = "UpDwnMag"
        Me.UpDwnMag.Size = New System.Drawing.Size(64, 20)
        Me.UpDwnMag.TabIndex = 5
        Me.UpDwnMag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(194, 201)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(117, 23)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit Interpolation Test"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(42, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(442, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Test Interpolation of Deviation Data for Compass or Magnetic Heading"
        '
        'TestDev
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 239)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnMagDev)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMagDev)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.UpDwnMag)
        Me.Controls.Add(Me.btnCompassDev)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCompassDev)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UpDwnCompass)
        Me.Name = "TestDev"
        Me.Text = "TestDev"
        CType(Me.UpDwnCompass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UpDwnMag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UpDwnCompass As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCompassDev As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCompassDev As Button
    Friend WithEvents btnMagDev As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMagDev As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents UpDwnMag As NumericUpDown
    Friend WithEvents btnExit As Button
    Friend WithEvents Label5 As Label
End Class
