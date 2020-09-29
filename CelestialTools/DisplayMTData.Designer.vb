<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DisplayMTData
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
        Me.lblFileLoc = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataSet2 = New System.Data.DataSet()
        Me.Export = New System.Data.DataTable()
        Me.Latitude = New System.Data.DataColumn()
        Me.Longitude = New System.Data.DataColumn()
        Me.LANDate = New System.Data.DataColumn()
        Me.LANTime = New System.Data.DataColumn()
        Me.EQTFactor = New System.Data.DataColumn()
        Me.SunDeclination = New System.Data.DataColumn()
        Me.SunCalcHo = New System.Data.DataColumn()
        Me.LatitudeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LongitudeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LANDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LANTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EQTFactorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SunDeclinationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SunCalcHoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Export, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFileLoc
        '
        Me.lblFileLoc.AutoSize = True
        Me.lblFileLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFileLoc.Location = New System.Drawing.Point(13, -202)
        Me.lblFileLoc.Name = "lblFileLoc"
        Me.lblFileLoc.Size = New System.Drawing.Size(565, 32)
        Me.lblFileLoc.TabIndex = 101
        Me.lblFileLoc.Text = "The data displayed in the table belowcan be found in the file ""./Graphics/EQTData" &
    ".csv"" " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " This file is rewritten and renewed each time the NoonSight form to comp" &
    "ute LAN for a Lat/Long."
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LatitudeDataGridViewTextBoxColumn, Me.LongitudeDataGridViewTextBoxColumn, Me.LANDateDataGridViewTextBoxColumn, Me.LANTimeDataGridViewTextBoxColumn, Me.EQTFactorDataGridViewTextBoxColumn, Me.SunDeclinationDataGridViewTextBoxColumn, Me.SunCalcHoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataMember = "Export2"
        Me.DataGridView1.DataSource = Me.DataSet2
        Me.DataGridView1.Location = New System.Drawing.Point(47, 44)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(784, 694)
        Me.DataGridView1.TabIndex = 102
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "NewDataSet"
        Me.DataSet2.Tables.AddRange(New System.Data.DataTable() {Me.Export})
        '
        'Export
        '
        Me.Export.Columns.AddRange(New System.Data.DataColumn() {Me.Latitude, Me.Longitude, Me.LANDate, Me.LANTime, Me.EQTFactor, Me.SunDeclination, Me.SunCalcHo})
        Me.Export.TableName = "Export2"
        '
        'Latitude
        '
        Me.Latitude.ColumnName = "Latitude"
        '
        'Longitude
        '
        Me.Longitude.ColumnName = "Longitude"
        '
        'LANDate
        '
        Me.LANDate.ColumnName = "LANDate"
        '
        'LANTime
        '
        Me.LANTime.ColumnName = "LANTime"
        '
        'EQTFactor
        '
        Me.EQTFactor.ColumnName = "EQTFactor"
        '
        'SunDeclination
        '
        Me.SunDeclination.ColumnName = "SunDeclination"
        '
        'SunCalcHo
        '
        Me.SunCalcHo.ColumnName = "SunCalcHo"
        '
        'LatitudeDataGridViewTextBoxColumn
        '
        Me.LatitudeDataGridViewTextBoxColumn.DataPropertyName = "Latitude"
        Me.LatitudeDataGridViewTextBoxColumn.HeaderText = "Latitude"
        Me.LatitudeDataGridViewTextBoxColumn.Name = "LatitudeDataGridViewTextBoxColumn"
        Me.LatitudeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LongitudeDataGridViewTextBoxColumn
        '
        Me.LongitudeDataGridViewTextBoxColumn.DataPropertyName = "Longitude"
        Me.LongitudeDataGridViewTextBoxColumn.HeaderText = "Longitude"
        Me.LongitudeDataGridViewTextBoxColumn.Name = "LongitudeDataGridViewTextBoxColumn"
        Me.LongitudeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LANDateDataGridViewTextBoxColumn
        '
        Me.LANDateDataGridViewTextBoxColumn.DataPropertyName = "LANDate"
        Me.LANDateDataGridViewTextBoxColumn.HeaderText = "LANDate"
        Me.LANDateDataGridViewTextBoxColumn.Name = "LANDateDataGridViewTextBoxColumn"
        Me.LANDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LANTimeDataGridViewTextBoxColumn
        '
        Me.LANTimeDataGridViewTextBoxColumn.DataPropertyName = "LANTime"
        Me.LANTimeDataGridViewTextBoxColumn.HeaderText = "LANTime"
        Me.LANTimeDataGridViewTextBoxColumn.Name = "LANTimeDataGridViewTextBoxColumn"
        Me.LANTimeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EQTFactorDataGridViewTextBoxColumn
        '
        Me.EQTFactorDataGridViewTextBoxColumn.DataPropertyName = "EQTFactor"
        Me.EQTFactorDataGridViewTextBoxColumn.HeaderText = "EQTFactor"
        Me.EQTFactorDataGridViewTextBoxColumn.Name = "EQTFactorDataGridViewTextBoxColumn"
        Me.EQTFactorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SunDeclinationDataGridViewTextBoxColumn
        '
        Me.SunDeclinationDataGridViewTextBoxColumn.DataPropertyName = "SunDeclination"
        Me.SunDeclinationDataGridViewTextBoxColumn.HeaderText = "SunDeclination"
        Me.SunDeclinationDataGridViewTextBoxColumn.Name = "SunDeclinationDataGridViewTextBoxColumn"
        Me.SunDeclinationDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SunCalcHoDataGridViewTextBoxColumn
        '
        Me.SunCalcHoDataGridViewTextBoxColumn.DataPropertyName = "SunCalcHo"
        Me.SunCalcHoDataGridViewTextBoxColumn.HeaderText = "SunCalcHo"
        Me.SunCalcHoDataGridViewTextBoxColumn.Name = "SunCalcHoDataGridViewTextBoxColumn"
        Me.SunCalcHoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(592, 32)
        Me.Label1.TabIndex = 103
        Me.Label1.Text = "The data displayed in the table below can be found in the file ""./Graphics/Meridi" &
    "anTransitData.csv"" " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " This file is rewritten and renewed each time the NoonSight" &
    " form to compute LAN for a Lat/Long."
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnExit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExit.Location = New System.Drawing.Point(756, 9)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnExit.Size = New System.Drawing.Size(75, 25)
        Me.btnExit.TabIndex = 104
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'DisplayMTData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 763)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblFileLoc)
        Me.Name = "DisplayMTData"
        Me.Text = "DisplayMTData"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Export, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFileLoc As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataSet2 As DataSet
    Friend WithEvents Export As DataTable
    Friend WithEvents Latitude As DataColumn
    Friend WithEvents Longitude As DataColumn
    Friend WithEvents LANDate As DataColumn
    Friend WithEvents LANTime As DataColumn
    Friend WithEvents EQTFactor As DataColumn
    Friend WithEvents SunDeclination As DataColumn
    Friend WithEvents SunCalcHo As DataColumn
    Friend WithEvents LatitudeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LongitudeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LANDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LANTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EQTFactorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SunDeclinationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SunCalcHoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Public WithEvents btnExit As Button
End Class
