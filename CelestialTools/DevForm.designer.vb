<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DevForm
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.CommonNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommonNameDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WebLocationDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSaveInput = New System.Windows.Forms.Button()
        Me.lblDevForm = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.DGDev = New System.Windows.Forms.DataGridView()
        Me.btnTestInterp = New System.Windows.Forms.Button()
        Me.btnOpenDev = New System.Windows.Forms.Button()
        Me.txtOpenFile = New System.Windows.Forms.TextBox()
        CType(Me.DGDev, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(227, 389)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(115, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit and Save Input"
        Me.btnExit.UseVisualStyleBackColor = False
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
        'btnSaveInput
        '
        Me.btnSaveInput.BackColor = System.Drawing.Color.Blue
        Me.btnSaveInput.ForeColor = System.Drawing.Color.White
        Me.btnSaveInput.Location = New System.Drawing.Point(5, 389)
        Me.btnSaveInput.Name = "btnSaveInput"
        Me.btnSaveInput.Size = New System.Drawing.Size(105, 23)
        Me.btnSaveInput.TabIndex = 3
        Me.btnSaveInput.Text = "Save Info Input"
        Me.btnSaveInput.UseVisualStyleBackColor = False
        '
        'lblDevForm
        '
        Me.lblDevForm.AutoSize = True
        Me.lblDevForm.BackColor = System.Drawing.Color.Blue
        Me.lblDevForm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDevForm.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDevForm.ForeColor = System.Drawing.Color.White
        Me.lblDevForm.Location = New System.Drawing.Point(11, 15)
        Me.lblDevForm.Name = "lblDevForm"
        Me.lblDevForm.Size = New System.Drawing.Size(338, 50)
        Me.lblDevForm.TabIndex = 4
        Me.lblDevForm.Text = "Deviation Table Data: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Input a Magnetic Heading for each Compass Heading" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and th" &
    "e associated Deviation is automatically calculated "
        Me.lblDevForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.Blue
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(5, 416)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(105, 23)
        Me.btnReset.TabIndex = 5
        Me.btnReset.Text = "Reset to Defaults"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'DGDev
        '
        Me.DGDev.AllowUserToAddRows = False
        Me.DGDev.AllowUserToDeleteRows = False
        Me.DGDev.AllowUserToResizeColumns = False
        Me.DGDev.AllowUserToResizeRows = False
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGDev.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DGDev.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGDev.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DGDev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGDev.DefaultCellStyle = DataGridViewCellStyle9
        Me.DGDev.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DGDev.Location = New System.Drawing.Point(25, 70)
        Me.DGDev.MultiSelect = False
        Me.DGDev.Name = "DGDev"
        Me.DGDev.RowHeadersVisible = False
        Me.DGDev.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DGDev.Size = New System.Drawing.Size(299, 233)
        Me.DGDev.TabIndex = 6
        '
        'btnTestInterp
        '
        Me.btnTestInterp.BackColor = System.Drawing.Color.Blue
        Me.btnTestInterp.ForeColor = System.Drawing.Color.White
        Me.btnTestInterp.Location = New System.Drawing.Point(116, 416)
        Me.btnTestInterp.Name = "btnTestInterp"
        Me.btnTestInterp.Size = New System.Drawing.Size(105, 23)
        Me.btnTestInterp.TabIndex = 7
        Me.btnTestInterp.Text = "Test Interpolation"
        Me.btnTestInterp.UseVisualStyleBackColor = False
        '
        'btnOpenDev
        '
        Me.btnOpenDev.BackColor = System.Drawing.Color.Yellow
        Me.btnOpenDev.ForeColor = System.Drawing.Color.Black
        Me.btnOpenDev.Location = New System.Drawing.Point(116, 389)
        Me.btnOpenDev.Name = "btnOpenDev"
        Me.btnOpenDev.Size = New System.Drawing.Size(105, 23)
        Me.btnOpenDev.TabIndex = 9
        Me.btnOpenDev.Text = "Open Dev File"
        Me.btnOpenDev.UseVisualStyleBackColor = False
        '
        'txtOpenFile
        '
        Me.txtOpenFile.BackColor = System.Drawing.Color.Yellow
        Me.txtOpenFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOpenFile.Location = New System.Drawing.Point(6, 310)
        Me.txtOpenFile.Multiline = True
        Me.txtOpenFile.Name = "txtOpenFile"
        Me.txtOpenFile.Size = New System.Drawing.Size(337, 73)
        Me.txtOpenFile.TabIndex = 10
        '
        'DevForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 453)
        Me.Controls.Add(Me.txtOpenFile)
        Me.Controls.Add(Me.btnOpenDev)
        Me.Controls.Add(Me.btnTestInterp)
        Me.Controls.Add(Me.DGDev)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lblDevForm)
        Me.Controls.Add(Me.btnSaveInput)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "DevForm"
        Me.Text = "Deviation Table Data"
        CType(Me.DGDev, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As Button
    Friend WithEvents CommonNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CommonNameDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents WebLocationDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents btnSaveInput As Button
    Friend WithEvents lblDevForm As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents DGDev As DataGridView
    Friend WithEvents btnTestInterp As Button
    Friend WithEvents btnOpenDev As Button
    Friend WithEvents txtOpenFile As TextBox
End Class
