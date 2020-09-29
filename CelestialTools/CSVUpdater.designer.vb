<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CSVUpdater
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnExitNoSave = New System.Windows.Forms.Button()
        Me.CommonNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommonNameDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WebLocationDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnOpenCSV = New System.Windows.Forms.Button()
        Me.lblOpenFN = New System.Windows.Forms.Label()
        Me.txtOpenFN = New System.Windows.Forms.TextBox()
        Me.btnSaveFile = New System.Windows.Forms.Button()
        Me.btnInfoForm = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InfoText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gold
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.NullValue = " "
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Location = New System.Drawing.Point(11, 58)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.InfoText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Yellow
        Me.DataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.InfoText
        Me.DataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Blue
        Me.DataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView1.Size = New System.Drawing.Size(1333, 780)
        Me.DataGridView1.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(1224, 8)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(118, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit and Save Input"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnExitNoSave
        '
        Me.btnExitNoSave.BackColor = System.Drawing.Color.Red
        Me.btnExitNoSave.ForeColor = System.Drawing.Color.White
        Me.btnExitNoSave.Location = New System.Drawing.Point(1224, 33)
        Me.btnExitNoSave.Name = "btnExitNoSave"
        Me.btnExitNoSave.Size = New System.Drawing.Size(118, 23)
        Me.btnExitNoSave.TabIndex = 2
        Me.btnExitNoSave.Text = "Exit with No Save"
        Me.btnExitNoSave.UseVisualStyleBackColor = False
        '
        'CommonNameDataGridViewTextBoxColumn1
        '
        Me.CommonNameDataGridViewTextBoxColumn1.DataPropertyName = "Common Name"
        Me.CommonNameDataGridViewTextBoxColumn1.HeaderText = "Common Name"
        Me.CommonNameDataGridViewTextBoxColumn1.Name = "CommonNameDataGridViewTextBoxColumn1"
        Me.CommonNameDataGridViewTextBoxColumn1.Width = 140
        '
        'CommonNameDataGridViewTextBoxColumn2
        '
        Me.CommonNameDataGridViewTextBoxColumn2.DataPropertyName = "Common Name"
        Me.CommonNameDataGridViewTextBoxColumn2.HeaderText = "Common Name"
        Me.CommonNameDataGridViewTextBoxColumn2.Name = "CommonNameDataGridViewTextBoxColumn2"
        Me.CommonNameDataGridViewTextBoxColumn2.Width = 140
        '
        'WebLocationDataGridViewTextBoxColumn1
        '
        Me.WebLocationDataGridViewTextBoxColumn1.DataPropertyName = "Web Location"
        Me.WebLocationDataGridViewTextBoxColumn1.HeaderText = "Web Location"
        Me.WebLocationDataGridViewTextBoxColumn1.Name = "WebLocationDataGridViewTextBoxColumn1"
        Me.WebLocationDataGridViewTextBoxColumn1.Width = 130
        '
        'btnOpenCSV
        '
        Me.btnOpenCSV.BackColor = System.Drawing.Color.Yellow
        Me.btnOpenCSV.ForeColor = System.Drawing.Color.Black
        Me.btnOpenCSV.Location = New System.Drawing.Point(12, 7)
        Me.btnOpenCSV.Name = "btnOpenCSV"
        Me.btnOpenCSV.Size = New System.Drawing.Size(118, 23)
        Me.btnOpenCSV.TabIndex = 3
        Me.btnOpenCSV.Text = "Open a CSV File"
        Me.btnOpenCSV.UseVisualStyleBackColor = False
        '
        'lblOpenFN
        '
        Me.lblOpenFN.AutoSize = True
        Me.lblOpenFN.Location = New System.Drawing.Point(136, 13)
        Me.lblOpenFN.Name = "lblOpenFN"
        Me.lblOpenFN.Size = New System.Drawing.Size(58, 13)
        Me.lblOpenFN.TabIndex = 4
        Me.lblOpenFN.Text = "Open File: "
        Me.lblOpenFN.Visible = False
        '
        'txtOpenFN
        '
        Me.txtOpenFN.Location = New System.Drawing.Point(194, 10)
        Me.txtOpenFN.Name = "txtOpenFN"
        Me.txtOpenFN.ReadOnly = True
        Me.txtOpenFN.Size = New System.Drawing.Size(900, 20)
        Me.txtOpenFN.TabIndex = 5
        Me.txtOpenFN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtOpenFN.Visible = False
        '
        'btnSaveFile
        '
        Me.btnSaveFile.BackColor = System.Drawing.Color.Blue
        Me.btnSaveFile.ForeColor = System.Drawing.Color.White
        Me.btnSaveFile.Location = New System.Drawing.Point(1102, 8)
        Me.btnSaveFile.Name = "btnSaveFile"
        Me.btnSaveFile.Size = New System.Drawing.Size(118, 23)
        Me.btnSaveFile.TabIndex = 6
        Me.btnSaveFile.Text = "Save Current File"
        Me.btnSaveFile.UseVisualStyleBackColor = False
        '
        'btnInfoForm
        '
        Me.btnInfoForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnInfoForm.ForeColor = System.Drawing.Color.Black
        Me.btnInfoForm.Location = New System.Drawing.Point(1102, 32)
        Me.btnInfoForm.Name = "btnInfoForm"
        Me.btnInfoForm.Size = New System.Drawing.Size(118, 23)
        Me.btnInfoForm.TabIndex = 7
        Me.btnInfoForm.Text = "Display Help Info"
        Me.btnInfoForm.UseVisualStyleBackColor = False
        '
        'CSVUpdater
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1353, 850)
        Me.Controls.Add(Me.btnInfoForm)
        Me.Controls.Add(Me.btnSaveFile)
        Me.Controls.Add(Me.txtOpenFN)
        Me.Controls.Add(Me.lblOpenFN)
        Me.Controls.Add(Me.btnOpenCSV)
        Me.Controls.Add(Me.btnExitNoSave)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "CSVUpdater"
        Me.Text = "CSV File Updater"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnExit As Button
    Friend WithEvents btnExitNoSave As Button
    Friend WithEvents CommonNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CommonNameDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents WebLocationDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents btnOpenCSV As Button
    Friend WithEvents lblOpenFN As Label
    Friend WithEvents txtOpenFN As TextBox
    Friend WithEvents btnSaveFile As Button
    Friend WithEvents btnInfoForm As Button
End Class
