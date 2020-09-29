using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    [DesignerGenerated()]
    public partial class DisplayMTData : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            lblFileLoc = new Label();
            DataGridView1 = new DataGridView();
            DataSet2 = new DataSet();
            Export = new DataTable();
            Latitude = new DataColumn();
            Longitude = new DataColumn();
            LANDate = new DataColumn();
            LANTime = new DataColumn();
            EQTFactor = new DataColumn();
            SunDeclination = new DataColumn();
            SunCalcHo = new DataColumn();
            LatitudeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            LongitudeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            LANDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            LANTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            EQTFactorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            SunDeclinationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            SunCalcHoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Label1 = new Label();
            _btnExit = new Button();
            _btnExit.Click += new EventHandler(btnExit_Click);
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataSet2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Export).BeginInit();
            SuspendLayout();
            // 
            // lblFileLoc
            // 
            lblFileLoc.AutoSize = true;
            lblFileLoc.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblFileLoc.Location = new Point(13, -202);
            lblFileLoc.Name = "lblFileLoc";
            lblFileLoc.Size = new Size(565, 32);
            lblFileLoc.TabIndex = 101;
            lblFileLoc.Text = "The data displayed in the table belowcan be found in the file \"./Graphics/EQTData" + ".csv\" " + '\r' + '\n' + " This file is rewritten and renewed each time the NoonSight form to comp" + "ute LAN for a Lat/Long.";
            // 
            // DataGridView1
            // 
            DataGridView1.AllowUserToAddRows = false;
            DataGridView1.AllowUserToDeleteRows = false;
            DataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            DataGridView1.AutoGenerateColumns = false;
            DataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Columns.AddRange(new DataGridViewColumn[] { LatitudeDataGridViewTextBoxColumn, LongitudeDataGridViewTextBoxColumn, LANDateDataGridViewTextBoxColumn, LANTimeDataGridViewTextBoxColumn, EQTFactorDataGridViewTextBoxColumn, SunDeclinationDataGridViewTextBoxColumn, SunCalcHoDataGridViewTextBoxColumn });
            DataGridView1.DataMember = "Export2";
            DataGridView1.DataSource = DataSet2;
            DataGridView1.Location = new Point(47, 44);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.ReadOnly = true;
            DataGridView1.RowTemplate.ReadOnly = true;
            DataGridView1.Size = new Size(784, 694);
            DataGridView1.TabIndex = 102;
            // 
            // DataSet2
            // 
            DataSet2.DataSetName = "NewDataSet";
            DataSet2.Tables.AddRange(new DataTable[] { Export });
            // 
            // Export
            // 
            Export.Columns.AddRange(new DataColumn[] { Latitude, Longitude, LANDate, LANTime, EQTFactor, SunDeclination, SunCalcHo });
            Export.TableName = "Export2";
            // 
            // Latitude
            // 
            Latitude.ColumnName = "Latitude";
            // 
            // Longitude
            // 
            Longitude.ColumnName = "Longitude";
            // 
            // LANDate
            // 
            LANDate.ColumnName = "LANDate";
            // 
            // LANTime
            // 
            LANTime.ColumnName = "LANTime";
            // 
            // EQTFactor
            // 
            EQTFactor.ColumnName = "EQTFactor";
            // 
            // SunDeclination
            // 
            SunDeclination.ColumnName = "SunDeclination";
            // 
            // SunCalcHo
            // 
            SunCalcHo.ColumnName = "SunCalcHo";
            // 
            // LatitudeDataGridViewTextBoxColumn
            // 
            LatitudeDataGridViewTextBoxColumn.DataPropertyName = "Latitude";
            LatitudeDataGridViewTextBoxColumn.HeaderText = "Latitude";
            LatitudeDataGridViewTextBoxColumn.Name = "LatitudeDataGridViewTextBoxColumn";
            LatitudeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // LongitudeDataGridViewTextBoxColumn
            // 
            LongitudeDataGridViewTextBoxColumn.DataPropertyName = "Longitude";
            LongitudeDataGridViewTextBoxColumn.HeaderText = "Longitude";
            LongitudeDataGridViewTextBoxColumn.Name = "LongitudeDataGridViewTextBoxColumn";
            LongitudeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // LANDateDataGridViewTextBoxColumn
            // 
            LANDateDataGridViewTextBoxColumn.DataPropertyName = "LANDate";
            LANDateDataGridViewTextBoxColumn.HeaderText = "LANDate";
            LANDateDataGridViewTextBoxColumn.Name = "LANDateDataGridViewTextBoxColumn";
            LANDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // LANTimeDataGridViewTextBoxColumn
            // 
            LANTimeDataGridViewTextBoxColumn.DataPropertyName = "LANTime";
            LANTimeDataGridViewTextBoxColumn.HeaderText = "LANTime";
            LANTimeDataGridViewTextBoxColumn.Name = "LANTimeDataGridViewTextBoxColumn";
            LANTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // EQTFactorDataGridViewTextBoxColumn
            // 
            EQTFactorDataGridViewTextBoxColumn.DataPropertyName = "EQTFactor";
            EQTFactorDataGridViewTextBoxColumn.HeaderText = "EQTFactor";
            EQTFactorDataGridViewTextBoxColumn.Name = "EQTFactorDataGridViewTextBoxColumn";
            EQTFactorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SunDeclinationDataGridViewTextBoxColumn
            // 
            SunDeclinationDataGridViewTextBoxColumn.DataPropertyName = "SunDeclination";
            SunDeclinationDataGridViewTextBoxColumn.HeaderText = "SunDeclination";
            SunDeclinationDataGridViewTextBoxColumn.Name = "SunDeclinationDataGridViewTextBoxColumn";
            SunDeclinationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SunCalcHoDataGridViewTextBoxColumn
            // 
            SunCalcHoDataGridViewTextBoxColumn.DataPropertyName = "SunCalcHo";
            SunCalcHoDataGridViewTextBoxColumn.HeaderText = "SunCalcHo";
            SunCalcHoDataGridViewTextBoxColumn.Name = "SunCalcHoDataGridViewTextBoxColumn";
            SunCalcHoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.Location = new Point(44, 9);
            Label1.Name = "Label1";
            Label1.Size = new Size(592, 32);
            Label1.TabIndex = 103;
            Label1.Text = "The data displayed in the table below can be found in the file \"./Graphics/Meridi" + "anTransitData.csv\" " + '\r' + '\n' + " This file is rewritten and renewed each time the NoonSight" + " form to compute LAN for a Lat/Long.";
            // 
            // btnExit
            // 
            _btnExit.BackColor = Color.Red;
            _btnExit.Cursor = Cursors.Default;
            _btnExit.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnExit.ForeColor = SystemColors.ControlLightLight;
            _btnExit.Location = new Point(756, 9);
            _btnExit.Name = "_btnExit";
            _btnExit.RightToLeft = RightToLeft.No;
            _btnExit.Size = new Size(75, 25);
            _btnExit.TabIndex = 104;
            _btnExit.Text = "Exit";
            _btnExit.UseVisualStyleBackColor = false;
            // 
            // DisplayMTData
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 763);
            Controls.Add(_btnExit);
            Controls.Add(Label1);
            Controls.Add(DataGridView1);
            Controls.Add(lblFileLoc);
            Name = "DisplayMTData";
            Text = "DisplayMTData";
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataSet2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Export).EndInit();
            Load += new EventHandler(DisplayMTData_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        internal Label lblFileLoc;
        internal DataGridView DataGridView1;
        internal DataSet DataSet2;
        internal DataTable Export;
        internal DataColumn Latitude;
        internal DataColumn Longitude;
        internal DataColumn LANDate;
        internal DataColumn LANTime;
        internal DataColumn EQTFactor;
        internal DataColumn SunDeclination;
        internal DataColumn SunCalcHo;
        internal DataGridViewTextBoxColumn LatitudeDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn LongitudeDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn LANDateDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn LANTimeDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn EQTFactorDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn SunDeclinationDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn SunCalcHoDataGridViewTextBoxColumn;
        internal Label Label1;
        private Button _btnExit;

        public Button btnExit
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnExit;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnExit != null)
                {
                    _btnExit.Click -= btnExit_Click;
                }

                _btnExit = value;
                if (_btnExit != null)
                {
                    _btnExit.Click += btnExit_Click;
                }
            }
        }
    }
}