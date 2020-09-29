using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    [DesignerGenerated()]
    public partial class DevForm : Form
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
            var DataGridViewCellStyle7 = new DataGridViewCellStyle();
            var DataGridViewCellStyle8 = new DataGridViewCellStyle();
            var DataGridViewCellStyle9 = new DataGridViewCellStyle();
            _btnExit = new Button();
            _btnExit.Click += new EventHandler(btnExit_Click);
            CommonNameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            CommonNameDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            WebLocationDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            _btnSaveInput = new Button();
            _btnSaveInput.Click += new EventHandler(btnSaveInput_Click);
            lblDevForm = new Label();
            _btnReset = new Button();
            _btnReset.Click += new EventHandler(btnReset_Click);
            _DGDev = new DataGridView();
            _DGDev.CellValueChanged += new DataGridViewCellEventHandler(DGDev_CellValueChanged);
            _btnTestInterp = new Button();
            _btnTestInterp.Click += new EventHandler(btnTestInterp_Click);
            _btnOpenDev = new Button();
            _btnOpenDev.Click += new EventHandler(btnOpenDev_Click);
            txtOpenFile = new TextBox();
            ((System.ComponentModel.ISupportInitialize)_DGDev).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            _btnExit.BackColor = Color.Red;
            _btnExit.ForeColor = Color.White;
            _btnExit.Location = new Point(227, 389);
            _btnExit.Name = "_btnExit";
            _btnExit.Size = new Size(115, 23);
            _btnExit.TabIndex = 1;
            _btnExit.Text = "Exit and Save Input";
            _btnExit.UseVisualStyleBackColor = false;
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
            // btnSaveInput
            // 
            _btnSaveInput.BackColor = Color.Blue;
            _btnSaveInput.ForeColor = Color.White;
            _btnSaveInput.Location = new Point(5, 389);
            _btnSaveInput.Name = "_btnSaveInput";
            _btnSaveInput.Size = new Size(105, 23);
            _btnSaveInput.TabIndex = 3;
            _btnSaveInput.Text = "Save Info Input";
            _btnSaveInput.UseVisualStyleBackColor = false;
            // 
            // lblDevForm
            // 
            lblDevForm.AutoSize = true;
            lblDevForm.BackColor = Color.Blue;
            lblDevForm.BorderStyle = BorderStyle.Fixed3D;
            lblDevForm.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblDevForm.ForeColor = Color.White;
            lblDevForm.Location = new Point(11, 15);
            lblDevForm.Name = "lblDevForm";
            lblDevForm.Size = new Size(338, 50);
            lblDevForm.TabIndex = 4;
            lblDevForm.Text = "Deviation Table Data: " + '\r' + '\n' + "Input a Magnetic Heading for each Compass Heading" + '\r' + '\n' + "and th" + "e associated Deviation is automatically calculated ";
            lblDevForm.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnReset
            // 
            _btnReset.BackColor = Color.Blue;
            _btnReset.ForeColor = Color.White;
            _btnReset.Location = new Point(5, 416);
            _btnReset.Name = "_btnReset";
            _btnReset.Size = new Size(105, 23);
            _btnReset.TabIndex = 5;
            _btnReset.Text = "Reset to Defaults";
            _btnReset.UseVisualStyleBackColor = false;
            // 
            // DGDev
            // 
            _DGDev.AllowUserToAddRows = false;
            _DGDev.AllowUserToDeleteRows = false;
            _DGDev.AllowUserToResizeColumns = false;
            _DGDev.AllowUserToResizeRows = false;
            DataGridViewCellStyle7.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _DGDev.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7;
            _DGDev.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle8.BackColor = SystemColors.Control;
            DataGridViewCellStyle8.Font = new Font("Arial Narrow", 9.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            _DGDev.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8;
            _DGDev.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle9.BackColor = SystemColors.Window;
            DataGridViewCellStyle9.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            DataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            _DGDev.DefaultCellStyle = DataGridViewCellStyle9;
            _DGDev.EditMode = DataGridViewEditMode.EditOnEnter;
            _DGDev.Location = new Point(25, 70);
            _DGDev.MultiSelect = false;
            _DGDev.Name = "_DGDev";
            _DGDev.RowHeadersVisible = false;
            _DGDev.SelectionMode = DataGridViewSelectionMode.CellSelect;
            _DGDev.Size = new Size(299, 233);
            _DGDev.TabIndex = 6;
            // 
            // btnTestInterp
            // 
            _btnTestInterp.BackColor = Color.Blue;
            _btnTestInterp.ForeColor = Color.White;
            _btnTestInterp.Location = new Point(116, 416);
            _btnTestInterp.Name = "_btnTestInterp";
            _btnTestInterp.Size = new Size(105, 23);
            _btnTestInterp.TabIndex = 7;
            _btnTestInterp.Text = "Test Interpolation";
            _btnTestInterp.UseVisualStyleBackColor = false;
            // 
            // btnOpenDev
            // 
            _btnOpenDev.BackColor = Color.Yellow;
            _btnOpenDev.ForeColor = Color.Black;
            _btnOpenDev.Location = new Point(116, 389);
            _btnOpenDev.Name = "_btnOpenDev";
            _btnOpenDev.Size = new Size(105, 23);
            _btnOpenDev.TabIndex = 9;
            _btnOpenDev.Text = "Open Dev File";
            _btnOpenDev.UseVisualStyleBackColor = false;
            // 
            // txtOpenFile
            // 
            txtOpenFile.BackColor = Color.Yellow;
            txtOpenFile.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtOpenFile.Location = new Point(6, 310);
            txtOpenFile.Multiline = true;
            txtOpenFile.Name = "txtOpenFile";
            txtOpenFile.Size = new Size(337, 73);
            txtOpenFile.TabIndex = 10;
            // 
            // DevForm
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 453);
            Controls.Add(txtOpenFile);
            Controls.Add(_btnOpenDev);
            Controls.Add(_btnTestInterp);
            Controls.Add(_DGDev);
            Controls.Add(_btnReset);
            Controls.Add(lblDevForm);
            Controls.Add(_btnSaveInput);
            Controls.Add(_btnExit);
            Name = "DevForm";
            Text = "Deviation Table Data";
            ((System.ComponentModel.ISupportInitialize)_DGDev).EndInit();
            Load += new EventHandler(FormSRF_Load);
            ResumeLayout(false);
            PerformLayout();
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

        internal DataGridViewTextBoxColumn CommonNameDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn CommonNameDataGridViewTextBoxColumn2;
        internal DataGridViewTextBoxColumn WebLocationDataGridViewTextBoxColumn1;
        private Button _btnSaveInput;

        internal Button btnSaveInput
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSaveInput;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSaveInput != null)
                {
                    _btnSaveInput.Click -= btnSaveInput_Click;
                }

                _btnSaveInput = value;
                if (_btnSaveInput != null)
                {
                    _btnSaveInput.Click += btnSaveInput_Click;
                }
            }
        }

        internal Label lblDevForm;
        private Button _btnReset;

        internal Button btnReset
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnReset;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnReset != null)
                {
                    _btnReset.Click -= btnReset_Click;
                }

                _btnReset = value;
                if (_btnReset != null)
                {
                    _btnReset.Click += btnReset_Click;
                }
            }
        }

        private DataGridView _DGDev;

        internal DataGridView DGDev
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _DGDev;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_DGDev != null)
                {
                    _DGDev.CellValueChanged -= DGDev_CellValueChanged;
                }

                _DGDev = value;
                if (_DGDev != null)
                {
                    _DGDev.CellValueChanged += DGDev_CellValueChanged;
                }
            }
        }

        private Button _btnTestInterp;

        internal Button btnTestInterp
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnTestInterp;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnTestInterp != null)
                {
                    _btnTestInterp.Click -= btnTestInterp_Click;
                }

                _btnTestInterp = value;
                if (_btnTestInterp != null)
                {
                    _btnTestInterp.Click += btnTestInterp_Click;
                }
            }
        }

        private Button _btnOpenDev;

        internal Button btnOpenDev
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnOpenDev;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnOpenDev != null)
                {
                    _btnOpenDev.Click -= btnOpenDev_Click;
                }

                _btnOpenDev = value;
                if (_btnOpenDev != null)
                {
                    _btnOpenDev.Click += btnOpenDev_Click;
                }
            }
        }

        internal TextBox txtOpenFile;
    }
}