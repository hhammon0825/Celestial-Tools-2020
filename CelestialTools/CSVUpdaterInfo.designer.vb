<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CSVUpdaterInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CSVUpdaterInfo))
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.btnInfoExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(21, 9)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(753, 274)
        Me.lblInfo.TabIndex = 8
        Me.lblInfo.Text = resources.GetString("lblInfo.Text")
        '
        'btnInfoExit
        '
        Me.btnInfoExit.BackColor = System.Drawing.Color.Red
        Me.btnInfoExit.ForeColor = System.Drawing.Color.White
        Me.btnInfoExit.Location = New System.Drawing.Point(656, 302)
        Me.btnInfoExit.Name = "btnInfoExit"
        Me.btnInfoExit.Size = New System.Drawing.Size(118, 23)
        Me.btnInfoExit.TabIndex = 9
        Me.btnInfoExit.Text = "Exit"
        Me.btnInfoExit.UseVisualStyleBackColor = False
        '
        'CSVUpdaterInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 347)
        Me.Controls.Add(Me.btnInfoExit)
        Me.Controls.Add(Me.lblInfo)
        Me.Name = "CSVUpdaterInfo"
        Me.Text = "CSVUpdaterInfo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInfo As Label
    Friend WithEvents btnInfoExit As Button
End Class
