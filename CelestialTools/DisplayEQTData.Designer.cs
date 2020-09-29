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
    public partial class DisplayEQTData : Form
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
            DataGridView1 = new DataGridView();
            LatitudeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            LongitudeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            LANDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            LANTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            EQTFactorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            SunDeclinationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            SunCalcHoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            DataSet1 = new DataSet();
            Export = new DataTable();
            Latitude = new DataColumn();
            Longitude = new DataColumn();
            LANDate = new DataColumn();
            LANTime = new DataColumn();
            EQTFactor = new DataColumn();
            SunDeclination = new DataColumn();
            SunCalcHo = new DataColumn();
            _btnExit = new Button();
            _btnExit.Click += new EventHandler(btnExit_Click);
            lblFileLoc = new Label();
            pbAnalema = new PictureBox();
            Label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataSet1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Export).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAnalema).BeginInit();
            SuspendLayout();
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
            DataGridView1.DataMember = "Export";
            DataGridView1.DataSource = DataSet1;
            DataGridView1.Location = new Point(4, 43);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.ReadOnly = true;
            DataGridView1.RowTemplate.ReadOnly = true;
            DataGridView1.Size = new Size(784, 817);
            DataGridView1.TabIndex = 0;
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
            // DataSet1
            // 
            DataSet1.DataSetName = "NewDataSet";
            DataSet1.Tables.AddRange(new DataTable[] { Export });
            // 
            // Export
            // 
            Export.Columns.AddRange(new DataColumn[] { Latitude, Longitude, LANDate, LANTime, EQTFactor, SunDeclination, SunCalcHo });
            Export.TableName = "Export";
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
            // btnExit
            // 
            _btnExit.BackColor = Color.Red;
            _btnExit.Cursor = Cursors.Default;
            _btnExit.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnExit.ForeColor = SystemColors.ControlLightLight;
            _btnExit.Location = new Point(1533, 8);
            _btnExit.Name = "_btnExit";
            _btnExit.RightToLeft = RightToLeft.No;
            _btnExit.Size = new Size(75, 25);
            _btnExit.TabIndex = 98;
            _btnExit.Text = "Exit";
            _btnExit.UseVisualStyleBackColor = false;
            // 
            // lblFileLoc
            // 
            lblFileLoc.AutoSize = true;
            lblFileLoc.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblFileLoc.Location = new Point(9, 6);
            lblFileLoc.Name = "lblFileLoc";
            lblFileLoc.Size = new Size(565, 32);
            lblFileLoc.TabIndex = 99;
            lblFileLoc.Text = "The data displayed in the table belowcan be found in the file \"./Graphics/EQTData" + ".csv\" " + '\r' + '\n' + " This file is rewritten and renewed each time the NoonSight form to comp" + "ute LAN for a Lat/Long.";
            // 
            // pbAnalema
            // 
            pbAnalema.BackColor = Color.PowderBlue;
            pbAnalema.BorderStyle = BorderStyle.Fixed3D;
            pbAnalema.Location = new Point(794, 43);
            pbAnalema.Name = "pbAnalema";
            pbAnalema.Size = new Size(820, 820);
            pbAnalema.TabIndex = 100;
            pbAnalema.TabStop = false;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.Location = new Point(797, 8);
            Label1.Name = "Label1";
            Label1.Size = new Size(483, 32);
            Label1.TabIndex = 101;
            Label1.Text = "Analema graph is displayed using the file \"./Graphics/AnalemaBitMapSave.jpg\" " + '\r' + '\n' + "Th" + "is file is rewritten and renewed each time this DisplayEqtData form is used";
            // 
            // DisplayEQTData
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1620, 872);
            Controls.Add(Label1);
            Controls.Add(pbAnalema);
            Controls.Add(lblFileLoc);
            Controls.Add(_btnExit);
            Controls.Add(DataGridView1);
            Name = "DisplayEQTData";
            Text = "Display NoonSight Equation of Time Data";
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataSet1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Export).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAnalema).EndInit();
            Load += new EventHandler(DisplayEQTData_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        internal DataGridView DataGridView1;
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

        internal Label lblFileLoc;
        internal DataSet DataSet1;
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
        internal PictureBox pbAnalema;
        internal Label Label1;
    }
}