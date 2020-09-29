<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeckLogHelp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeckLogHelp))
        Me.btnInfoExit = New System.Windows.Forms.Button()
        Me.TabDeckLogInfo = New System.Windows.Forms.TabControl()
        Me.GeneralInfo = New System.Windows.Forms.TabPage()
        Me.txtGenInfo = New System.Windows.Forms.RichTextBox()
        Me.FileActions = New System.Windows.Forms.TabPage()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.LogDataEntry = New System.Windows.Forms.TabPage()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.EntryFields = New System.Windows.Forms.TabPage()
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox()
        Me.DataGridActions = New System.Windows.Forms.TabPage()
        Me.RichTextBox4 = New System.Windows.Forms.RichTextBox()
        Me.TabDeckLogInfo.SuspendLayout()
        Me.GeneralInfo.SuspendLayout()
        Me.FileActions.SuspendLayout()
        Me.LogDataEntry.SuspendLayout()
        Me.EntryFields.SuspendLayout()
        Me.DataGridActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnInfoExit
        '
        Me.btnInfoExit.BackColor = System.Drawing.Color.Red
        Me.btnInfoExit.ForeColor = System.Drawing.Color.White
        Me.btnInfoExit.Location = New System.Drawing.Point(548, 4)
        Me.btnInfoExit.Name = "btnInfoExit"
        Me.btnInfoExit.Size = New System.Drawing.Size(118, 23)
        Me.btnInfoExit.TabIndex = 9
        Me.btnInfoExit.Text = "Exit"
        Me.btnInfoExit.UseVisualStyleBackColor = False
        '
        'TabDeckLogInfo
        '
        Me.TabDeckLogInfo.Controls.Add(Me.GeneralInfo)
        Me.TabDeckLogInfo.Controls.Add(Me.FileActions)
        Me.TabDeckLogInfo.Controls.Add(Me.LogDataEntry)
        Me.TabDeckLogInfo.Controls.Add(Me.EntryFields)
        Me.TabDeckLogInfo.Controls.Add(Me.DataGridActions)
        Me.TabDeckLogInfo.Location = New System.Drawing.Point(12, 33)
        Me.TabDeckLogInfo.Name = "TabDeckLogInfo"
        Me.TabDeckLogInfo.SelectedIndex = 0
        Me.TabDeckLogInfo.Size = New System.Drawing.Size(659, 640)
        Me.TabDeckLogInfo.TabIndex = 10
        '
        'GeneralInfo
        '
        Me.GeneralInfo.Controls.Add(Me.txtGenInfo)
        Me.GeneralInfo.Location = New System.Drawing.Point(4, 22)
        Me.GeneralInfo.Name = "GeneralInfo"
        Me.GeneralInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.GeneralInfo.Size = New System.Drawing.Size(651, 614)
        Me.GeneralInfo.TabIndex = 0
        Me.GeneralInfo.Text = "General Info"
        Me.GeneralInfo.UseVisualStyleBackColor = True
        '
        'txtGenInfo
        '
        Me.txtGenInfo.Location = New System.Drawing.Point(7, 4)
        Me.txtGenInfo.Name = "txtGenInfo"
        Me.txtGenInfo.Size = New System.Drawing.Size(638, 604)
        Me.txtGenInfo.TabIndex = 0
        Me.txtGenInfo.Text = resources.GetString("txtGenInfo.Text")
        '
        'FileActions
        '
        Me.FileActions.Controls.Add(Me.RichTextBox1)
        Me.FileActions.Location = New System.Drawing.Point(4, 22)
        Me.FileActions.Name = "FileActions"
        Me.FileActions.Padding = New System.Windows.Forms.Padding(3)
        Me.FileActions.Size = New System.Drawing.Size(651, 614)
        Me.FileActions.TabIndex = 1
        Me.FileActions.Text = "Form and File Buttons"
        Me.FileActions.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(6, 5)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(638, 582)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'LogDataEntry
        '
        Me.LogDataEntry.Controls.Add(Me.RichTextBox2)
        Me.LogDataEntry.Location = New System.Drawing.Point(4, 22)
        Me.LogDataEntry.Name = "LogDataEntry"
        Me.LogDataEntry.Size = New System.Drawing.Size(651, 614)
        Me.LogDataEntry.TabIndex = 2
        Me.LogDataEntry.Text = "Log Data Entry Buttons"
        Me.LogDataEntry.UseVisualStyleBackColor = True
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Location = New System.Drawing.Point(6, 4)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(638, 607)
        Me.RichTextBox2.TabIndex = 2
        Me.RichTextBox2.Text = resources.GetString("RichTextBox2.Text")
        '
        'EntryFields
        '
        Me.EntryFields.Controls.Add(Me.RichTextBox3)
        Me.EntryFields.Location = New System.Drawing.Point(4, 22)
        Me.EntryFields.Name = "EntryFields"
        Me.EntryFields.Size = New System.Drawing.Size(651, 614)
        Me.EntryFields.TabIndex = 3
        Me.EntryFields.Text = "Log Data Entry Fields"
        Me.EntryFields.UseVisualStyleBackColor = True
        '
        'RichTextBox3
        '
        Me.RichTextBox3.Location = New System.Drawing.Point(5, 4)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.Size = New System.Drawing.Size(638, 607)
        Me.RichTextBox3.TabIndex = 2
        Me.RichTextBox3.Text = resources.GetString("RichTextBox3.Text")
        '
        'DataGridActions
        '
        Me.DataGridActions.Controls.Add(Me.RichTextBox4)
        Me.DataGridActions.Location = New System.Drawing.Point(4, 22)
        Me.DataGridActions.Name = "DataGridActions"
        Me.DataGridActions.Size = New System.Drawing.Size(651, 614)
        Me.DataGridActions.TabIndex = 4
        Me.DataGridActions.Text = "Data Grid Actions"
        Me.DataGridActions.UseVisualStyleBackColor = True
        '
        'RichTextBox4
        '
        Me.RichTextBox4.Location = New System.Drawing.Point(6, 3)
        Me.RichTextBox4.Name = "RichTextBox4"
        Me.RichTextBox4.Size = New System.Drawing.Size(638, 608)
        Me.RichTextBox4.TabIndex = 2
        Me.RichTextBox4.Text = resources.GetString("RichTextBox4.Text")
        '
        'DeckLogHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 685)
        Me.Controls.Add(Me.TabDeckLogInfo)
        Me.Controls.Add(Me.btnInfoExit)
        Me.Name = "DeckLogHelp"
        Me.Text = "Deck Log Info "
        Me.TabDeckLogInfo.ResumeLayout(False)
        Me.GeneralInfo.ResumeLayout(False)
        Me.FileActions.ResumeLayout(False)
        Me.LogDataEntry.ResumeLayout(False)
        Me.EntryFields.ResumeLayout(False)
        Me.DataGridActions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnInfoExit As Button
    Friend WithEvents TabDeckLogInfo As TabControl
    Friend WithEvents GeneralInfo As TabPage
    Friend WithEvents txtGenInfo As RichTextBox
    Friend WithEvents FileActions As TabPage
    Friend WithEvents LogDataEntry As TabPage
    Friend WithEvents EntryFields As TabPage
    Friend WithEvents DataGridActions As TabPage
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents RichTextBox3 As RichTextBox
    Friend WithEvents RichTextBox4 As RichTextBox
End Class
