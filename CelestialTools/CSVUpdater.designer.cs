using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    [DesignerGenerated()]
    public partial class CSVUpdater : Form
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
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            var DataGridViewCellStyle4 = new DataGridViewCellStyle();
            var DataGridViewCellStyle5 = new DataGridViewCellStyle();
            _DataGridView1 = new DataGridView();
            _DataGridView1.CellContentClick += new DataGridViewCellEventHandler(DataGridView1_CellContentClick);
            _btnExit = new Button();
            _btnExit.Click += new EventHandler(btnExit_Click);
            _btnExitNoSave = new Button();
            _btnExitNoSave.Click += new EventHandler(btnExitNoSave_Click);
            CommonNameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            CommonNameDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            WebLocationDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            _btnOpenCSV = new Button();
            _btnOpenCSV.Click += new EventHandler(btnOpenCSV_Click);
            lblOpenFN = new Label();
            txtOpenFN = new TextBox();
            _btnSaveFile = new Button();
            _btnSaveFile.Click += new EventHandler(btnSaveFile_Click);
            _btnInfoForm = new Button();
            _btnInfoForm.Click += new EventHandler(btnInfoForm_Click);
            ((System.ComponentModel.ISupportInitialize)_DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // DataGridView1
            // 
            DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle1.BackColor = Color.LightGray;
            DataGridViewCellStyle1.Font = new Font("Arial Unicode MS", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            _DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            _DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            _DataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            _DataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = Color.Yellow;
            DataGridViewCellStyle2.Font = new Font("Arial Rounded MT Bold", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle2.ForeColor = SystemColors.InfoText;
            DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle2.SelectionForeColor = Color.Gold;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            _DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            _DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle3.BackColor = SystemColors.Window;
            DataGridViewCellStyle3.Font = new Font("Arial Unicode MS", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            DataGridViewCellStyle3.NullValue = " ";
            DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            _DataGridView1.DefaultCellStyle = DataGridViewCellStyle3;
            _DataGridView1.Location = new Point(11, 58);
            _DataGridView1.Name = "_DataGridView1";
            DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle4.BackColor = Color.Yellow;
            DataGridViewCellStyle4.Font = new Font("Arial Rounded MT Bold", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            _DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4;
            DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle5.BackColor = Color.Yellow;
            DataGridViewCellStyle5.Font = new Font("Arial Unicode MS", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle5.ForeColor = SystemColors.InfoText;
            DataGridViewCellStyle5.SelectionBackColor = Color.Blue;
            DataGridViewCellStyle5.SelectionForeColor = Color.White;
            _DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle5;
            _DataGridView1.RowTemplate.DefaultCellStyle.BackColor = Color.Yellow;
            _DataGridView1.RowTemplate.DefaultCellStyle.ForeColor = SystemColors.InfoText;
            _DataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Blue;
            _DataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            _DataGridView1.Size = new Size(1333, 780);
            _DataGridView1.TabIndex = 0;
            // 
            // btnExit
            // 
            _btnExit.BackColor = Color.Red;
            _btnExit.ForeColor = Color.White;
            _btnExit.Location = new Point(1224, 8);
            _btnExit.Name = "_btnExit";
            _btnExit.Size = new Size(118, 23);
            _btnExit.TabIndex = 1;
            _btnExit.Text = "Exit and Save Input";
            _btnExit.UseVisualStyleBackColor = false;
            // 
            // btnExitNoSave
            // 
            _btnExitNoSave.BackColor = Color.Red;
            _btnExitNoSave.ForeColor = Color.White;
            _btnExitNoSave.Location = new Point(1224, 33);
            _btnExitNoSave.Name = "_btnExitNoSave";
            _btnExitNoSave.Size = new Size(118, 23);
            _btnExitNoSave.TabIndex = 2;
            _btnExitNoSave.Text = "Exit with No Save";
            _btnExitNoSave.UseVisualStyleBackColor = false;
            // 
            // CommonNameDataGridViewTextBoxColumn1
            // 
            CommonNameDataGridViewTextBoxColumn1.DataPropertyName = "Common Name";
            CommonNameDataGridViewTextBoxColumn1.HeaderText = "Common Name";
            CommonNameDataGridViewTextBoxColumn1.Name = "CommonNameDataGridViewTextBoxColumn1";
            CommonNameDataGridViewTextBoxColumn1.Width = 140;
            // 
            // CommonNameDataGridViewTextBoxColumn2
            // 
            CommonNameDataGridViewTextBoxColumn2.DataPropertyName = "Common Name";
            CommonNameDataGridViewTextBoxColumn2.HeaderText = "Common Name";
            CommonNameDataGridViewTextBoxColumn2.Name = "CommonNameDataGridViewTextBoxColumn2";
            CommonNameDataGridViewTextBoxColumn2.Width = 140;
            // 
            // WebLocationDataGridViewTextBoxColumn1
            // 
            WebLocationDataGridViewTextBoxColumn1.DataPropertyName = "Web Location";
            WebLocationDataGridViewTextBoxColumn1.HeaderText = "Web Location";
            WebLocationDataGridViewTextBoxColumn1.Name = "WebLocationDataGridViewTextBoxColumn1";
            WebLocationDataGridViewTextBoxColumn1.Width = 130;
            // 
            // btnOpenCSV
            // 
            _btnOpenCSV.BackColor = Color.Yellow;
            _btnOpenCSV.ForeColor = Color.Black;
            _btnOpenCSV.Location = new Point(12, 7);
            _btnOpenCSV.Name = "_btnOpenCSV";
            _btnOpenCSV.Size = new Size(118, 23);
            _btnOpenCSV.TabIndex = 3;
            _btnOpenCSV.Text = "Open a CSV File";
            _btnOpenCSV.UseVisualStyleBackColor = false;
            // 
            // lblOpenFN
            // 
            lblOpenFN.AutoSize = true;
            lblOpenFN.Location = new Point(136, 13);
            lblOpenFN.Name = "lblOpenFN";
            lblOpenFN.Size = new Size(58, 13);
            lblOpenFN.TabIndex = 4;
            lblOpenFN.Text = "Open File: ";
            lblOpenFN.Visible = false;
            // 
            // txtOpenFN
            // 
            txtOpenFN.Location = new Point(194, 10);
            txtOpenFN.Name = "txtOpenFN";
            txtOpenFN.ReadOnly = true;
            txtOpenFN.Size = new Size(900, 20);
            txtOpenFN.TabIndex = 5;
            txtOpenFN.TextAlign = HorizontalAlignment.Center;
            txtOpenFN.Visible = false;
            // 
            // btnSaveFile
            // 
            _btnSaveFile.BackColor = Color.Blue;
            _btnSaveFile.ForeColor = Color.White;
            _btnSaveFile.Location = new Point(1102, 8);
            _btnSaveFile.Name = "_btnSaveFile";
            _btnSaveFile.Size = new Size(118, 23);
            _btnSaveFile.TabIndex = 6;
            _btnSaveFile.Text = "Save Current File";
            _btnSaveFile.UseVisualStyleBackColor = false;
            // 
            // btnInfoForm
            // 
            _btnInfoForm.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnInfoForm.ForeColor = Color.Black;
            _btnInfoForm.Location = new Point(1102, 32);
            _btnInfoForm.Name = "_btnInfoForm";
            _btnInfoForm.Size = new Size(118, 23);
            _btnInfoForm.TabIndex = 7;
            _btnInfoForm.Text = "Display Help Info";
            _btnInfoForm.UseVisualStyleBackColor = false;
            // 
            // CSVUpdater
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1353, 850);
            Controls.Add(_btnInfoForm);
            Controls.Add(_btnSaveFile);
            Controls.Add(txtOpenFN);
            Controls.Add(lblOpenFN);
            Controls.Add(_btnOpenCSV);
            Controls.Add(_btnExitNoSave);
            Controls.Add(_btnExit);
            Controls.Add(_DataGridView1);
            Name = "CSVUpdater";
            Text = "CSV File Updater";
            ((System.ComponentModel.ISupportInitialize)_DataGridView1).EndInit();
            Load += new EventHandler(FormSRF_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView _DataGridView1;

        internal DataGridView DataGridView1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _DataGridView1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_DataGridView1 != null)
                {
                    _DataGridView1.CellContentClick -= DataGridView1_CellContentClick;
                }

                _DataGridView1 = value;
                if (_DataGridView1 != null)
                {
                    _DataGridView1.CellContentClick += DataGridView1_CellContentClick;
                }
            }
        }

        private Button _btnExit;

        internal Button btnExit
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

        private Button _btnExitNoSave;

        internal Button btnExitNoSave
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnExitNoSave;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnExitNoSave != null)
                {
                    _btnExitNoSave.Click -= btnExitNoSave_Click;
                }

                _btnExitNoSave = value;
                if (_btnExitNoSave != null)
                {
                    _btnExitNoSave.Click += btnExitNoSave_Click;
                }
            }
        }

        internal DataGridViewTextBoxColumn CommonNameDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn CommonNameDataGridViewTextBoxColumn2;
        internal DataGridViewTextBoxColumn WebLocationDataGridViewTextBoxColumn1;
        private Button _btnOpenCSV;

        internal Button btnOpenCSV
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnOpenCSV;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnOpenCSV != null)
                {
                    _btnOpenCSV.Click -= btnOpenCSV_Click;
                }

                _btnOpenCSV = value;
                if (_btnOpenCSV != null)
                {
                    _btnOpenCSV.Click += btnOpenCSV_Click;
                }
            }
        }

        internal Label lblOpenFN;
        internal TextBox txtOpenFN;
        private Button _btnSaveFile;

        internal Button btnSaveFile
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSaveFile;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSaveFile != null)
                {
                    _btnSaveFile.Click -= btnSaveFile_Click;
                }

                _btnSaveFile = value;
                if (_btnSaveFile != null)
                {
                    _btnSaveFile.Click += btnSaveFile_Click;
                }
            }
        }

        private Button _btnInfoForm;

        internal Button btnInfoForm
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnInfoForm;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnInfoForm != null)
                {
                    _btnInfoForm.Click -= btnInfoForm_Click;
                }

                _btnInfoForm = value;
                if (_btnInfoForm != null)
                {
                    _btnInfoForm.Click += btnInfoForm_Click;
                }
            }
        }
    }
}