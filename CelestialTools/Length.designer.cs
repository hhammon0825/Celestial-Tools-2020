using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    [DesignerGenerated()]
    internal partial class FormLength
    {
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        [DebuggerNonUserCode()]
        public FormLength() : base()
        {
            // This is required by the Windows Form Designer.
            InitializeComponent();
        }
        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool Disposing)
        {
            if (Disposing)
            {
                if (components is object)
                {
                    components.Dispose();
                }
            }

            base.Dispose(Disposing);
        }
        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;
        public ToolTip ToolTip1;
        private Button _cmdPrint;

        public Button cmdPrint
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdPrint;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdPrint != null)
                {
                    _cmdPrint.Click -= cmdPrint_Click;
                }

                _cmdPrint = value;
                if (_cmdPrint != null)
                {
                    _cmdPrint.Click += cmdPrint_Click;
                }
            }
        }

        private TextBox _txtLMin;

        public TextBox txtLMin
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtLMin;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtLMin != null)
                {
                    _txtLMin.TextChanged -= txtLMin_TextChanged;
                    _txtLMin.KeyPress -= txtLMin_KeyPress;
                    _txtLMin.Validating -= txtLMin_Validating;
                    _txtLMin.Enter -= txtLMin_Enter;
                }

                _txtLMin = value;
                if (_txtLMin != null)
                {
                    _txtLMin.TextChanged += txtLMin_TextChanged;
                    _txtLMin.KeyPress += txtLMin_KeyPress;
                    _txtLMin.Validating += txtLMin_Validating;
                    _txtLMin.Enter += txtLMin_Enter;
                }
            }
        }

        private TextBox _txtLDeg;

        public TextBox txtLDeg
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtLDeg;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtLDeg != null)
                {
                    _txtLDeg.TextChanged -= txtLDeg_TextChanged;
                    _txtLDeg.KeyPress -= txtLDeg_KeyPress;
                    _txtLDeg.Validating -= txtLDeg_Validating;
                    _txtLDeg.Enter -= txtLDeg_Enter;
                }

                _txtLDeg = value;
                if (_txtLDeg != null)
                {
                    _txtLDeg.TextChanged += txtLDeg_TextChanged;
                    _txtLDeg.KeyPress += txtLDeg_KeyPress;
                    _txtLDeg.Validating += txtLDeg_Validating;
                    _txtLDeg.Enter += txtLDeg_Enter;
                }
            }
        }
        // Public WithEvents Line1 As Microsoft.VisualBasic.PowerPacks.LineShape
        public Label Label1;
        public Label lblDRL;
        public Label lblLDeg;
        public Label lblLMin;
        // Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLength));
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            ToolTip1 = new ToolTip(components);
            _cmdPrint = new Button();
            _cmdPrint.Click += new EventHandler(cmdPrint_Click);
            _txtLMin = new TextBox();
            _txtLMin.TextChanged += new EventHandler(txtLMin_TextChanged);
            _txtLMin.KeyPress += new KeyPressEventHandler(txtLMin_KeyPress);
            _txtLMin.Validating += new System.ComponentModel.CancelEventHandler(txtLMin_Validating);
            _txtLMin.Enter += new EventHandler(txtLMin_Enter);
            _txtLDeg = new TextBox();
            _txtLDeg.TextChanged += new EventHandler(txtLDeg_TextChanged);
            _txtLDeg.KeyPress += new KeyPressEventHandler(txtLDeg_KeyPress);
            _txtLDeg.Validating += new System.ComponentModel.CancelEventHandler(txtLDeg_Validating);
            _txtLDeg.Enter += new EventHandler(txtLDeg_Enter);
            Label1 = new Label();
            lblDRL = new Label();
            lblLDeg = new Label();
            lblLMin = new Label();
            txtLength = new TextBox();
            _CalcBtn = new Button();
            _CalcBtn.Click += new EventHandler(CalcBtn_Click);
            _ExitBtn = new Button();
            _ExitBtn.Click += new EventHandler(ExitBtn_Click);
            PictureBox1 = new PictureBox();
            DataGridView1 = new DataGridView();
            Label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cmdPrint
            // 
            _cmdPrint.BackColor = SystemColors.Control;
            _cmdPrint.Cursor = Cursors.Default;
            _cmdPrint.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdPrint.ForeColor = SystemColors.ControlText;
            _cmdPrint.Image = (Image)resources.GetObject("cmdPrint.Image");
            _cmdPrint.Location = new Point(1159, 7);
            _cmdPrint.Name = "_cmdPrint";
            _cmdPrint.RightToLeft = RightToLeft.No;
            _cmdPrint.Size = new Size(25, 25);
            _cmdPrint.TabIndex = 6;
            _cmdPrint.TextAlign = ContentAlignment.BottomCenter;
            ToolTip1.SetToolTip(_cmdPrint, "Print window");
            _cmdPrint.UseVisualStyleBackColor = false;
            // 
            // txtLMin
            // 
            _txtLMin.AcceptsReturn = true;
            _txtLMin.BackColor = SystemColors.Window;
            _txtLMin.Cursor = Cursors.IBeam;
            _txtLMin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtLMin.ForeColor = SystemColors.WindowText;
            _txtLMin.Location = new Point(85, 53);
            _txtLMin.MaxLength = 4;
            _txtLMin.Name = "_txtLMin";
            _txtLMin.RightToLeft = RightToLeft.No;
            _txtLMin.Size = new Size(33, 20);
            _txtLMin.TabIndex = 1;
            _txtLMin.Text = "0";
            _txtLMin.TextAlign = HorizontalAlignment.Center;
            ToolTip1.SetToolTip(_txtLMin, "Range 0 to 59.9");
            // 
            // txtLDeg
            // 
            _txtLDeg.AcceptsReturn = true;
            _txtLDeg.BackColor = SystemColors.Window;
            _txtLDeg.Cursor = Cursors.IBeam;
            _txtLDeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtLDeg.ForeColor = SystemColors.WindowText;
            _txtLDeg.Location = new Point(53, 53);
            _txtLDeg.MaxLength = 2;
            _txtLDeg.Name = "_txtLDeg";
            _txtLDeg.RightToLeft = RightToLeft.No;
            _txtLDeg.Size = new Size(25, 20);
            _txtLDeg.TabIndex = 0;
            _txtLDeg.Text = "0";
            _txtLDeg.TextAlign = HorizontalAlignment.Center;
            ToolTip1.SetToolTip(_txtLDeg, "Range 0 to 90");
            // 
            // Label1
            // 
            Label1.BackColor = SystemColors.Window;
            Label1.Cursor = Cursors.Default;
            Label1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = SystemColors.ControlText;
            Label1.Location = new Point(123, 53);
            Label1.Name = "Label1";
            Label1.RightToLeft = RightToLeft.No;
            Label1.Size = new Size(38, 20);
            Label1.TabIndex = 5;
            Label1.Text = "N or S";
            Label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDRL
            // 
            lblDRL.BackColor = SystemColors.Window;
            lblDRL.Cursor = Cursors.Default;
            lblDRL.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblDRL.ForeColor = SystemColors.ControlText;
            lblDRL.Location = new Point(3, 54);
            lblDRL.Name = "lblDRL";
            lblDRL.RightToLeft = RightToLeft.No;
            lblDRL.Size = new Size(51, 20);
            lblDRL.TabIndex = 4;
            lblDRL.Text = "Latitude";
            lblDRL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLDeg
            // 
            lblLDeg.BackColor = SystemColors.Window;
            lblLDeg.Cursor = Cursors.Default;
            lblLDeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLDeg.ForeColor = SystemColors.ControlText;
            lblLDeg.Location = new Point(78, 53);
            lblLDeg.Name = "lblLDeg";
            lblLDeg.RightToLeft = RightToLeft.No;
            lblLDeg.Size = new Size(9, 17);
            lblLDeg.TabIndex = 3;
            lblLDeg.Text = "°";
            // 
            // lblLMin
            // 
            lblLMin.BackColor = SystemColors.Window;
            lblLMin.Cursor = Cursors.Default;
            lblLMin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLMin.ForeColor = SystemColors.ControlText;
            lblLMin.Location = new Point(118, 53);
            lblLMin.Name = "lblLMin";
            lblLMin.RightToLeft = RightToLeft.No;
            lblLMin.Size = new Size(9, 17);
            lblLMin.TabIndex = 2;
            lblLMin.Text = "'";
            // 
            // txtLength
            // 
            txtLength.Location = new Point(2, 89);
            txtLength.Multiline = true;
            txtLength.Name = "txtLength";
            txtLength.ReadOnly = true;
            txtLength.ScrollBars = ScrollBars.Vertical;
            txtLength.Size = new Size(328, 386);
            txtLength.TabIndex = 8;
            // 
            // CalcBtn
            // 
            _CalcBtn.BackColor = SystemColors.MenuHighlight;
            _CalcBtn.Font = new Font("Arial Narrow", 8.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _CalcBtn.ForeColor = SystemColors.Window;
            _CalcBtn.Location = new Point(167, 49);
            _CalcBtn.Name = "_CalcBtn";
            _CalcBtn.Size = new Size(161, 27);
            _CalcBtn.TabIndex = 9;
            _CalcBtn.Text = "Calculate Latitude Detail";
            _CalcBtn.UseVisualStyleBackColor = false;
            // 
            // ExitBtn
            // 
            _ExitBtn.BackColor = Color.Red;
            _ExitBtn.Font = new Font("Arial Narrow", 8.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _ExitBtn.ForeColor = SystemColors.Window;
            _ExitBtn.Location = new Point(1117, 493);
            _ExitBtn.Name = "_ExitBtn";
            _ExitBtn.Size = new Size(67, 27);
            _ExitBtn.TabIndex = 10;
            _ExitBtn.Text = "Exit";
            _ExitBtn.UseVisualStyleBackColor = false;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.ABC_white;
            PictureBox1.Location = new Point(434, 481);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(316, 50);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 102;
            PictureBox1.TabStop = false;
            // 
            // DataGridView1
            // 
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle1.BackColor = SystemColors.Window;
            DataGridViewCellStyle1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            DataGridViewCellStyle1.Format = "N0";
            DataGridViewCellStyle1.NullValue = null;
            DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            DataGridView1.DefaultCellStyle = DataGridViewCellStyle1;
            DataGridView1.Location = new Point(346, 44);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.ReadOnly = true;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle2.BackColor = SystemColors.Control;
            DataGridViewCellStyle2.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle2;
            DataGridView1.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridView1.Size = new Size(838, 431);
            DataGridView1.TabIndex = 103;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Times New Roman", 15.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.Location = new Point(10, 7);
            Label2.Name = "Label2";
            Label2.Size = new Size(1150, 23);
            Label2.TabIndex = 104;
            Label2.Text = "How the Length of Latitude and Longitude Changes with Latitude: Use General Data " + "Table Below or Input Individual Latitude for Details";
            // 
            // FormLength
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1211, 543);
            Controls.Add(Label2);
            Controls.Add(DataGridView1);
            Controls.Add(PictureBox1);
            Controls.Add(_ExitBtn);
            Controls.Add(_CalcBtn);
            Controls.Add(txtLength);
            Controls.Add(_cmdPrint);
            Controls.Add(_txtLMin);
            Controls.Add(_txtLDeg);
            Controls.Add(Label1);
            Controls.Add(lblDRL);
            Controls.Add(lblLDeg);
            Controls.Add(lblLMin);
            Cursor = Cursors.Default;
            Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(3, 29);
            MaximizeBox = false;
            Name = "FormLength";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Length of a degree";
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            Load += new EventHandler(FormLength_Load);
            FormClosed += new FormClosedEventHandler(FormLength_FormClosed);
            ResumeLayout(false);
            PerformLayout();
        }

        internal TextBox txtLength;
        private Button _CalcBtn;

        internal Button CalcBtn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CalcBtn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CalcBtn != null)
                {
                    _CalcBtn.Click -= CalcBtn_Click;
                }

                _CalcBtn = value;
                if (_CalcBtn != null)
                {
                    _CalcBtn.Click += CalcBtn_Click;
                }
            }
        }

        private Button _ExitBtn;

        internal Button ExitBtn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ExitBtn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ExitBtn != null)
                {
                    _ExitBtn.Click -= ExitBtn_Click;
                }

                _ExitBtn = value;
                if (_ExitBtn != null)
                {
                    _ExitBtn.Click += ExitBtn_Click;
                }
            }
        }

        internal PictureBox PictureBox1;
        internal DataGridView DataGridView1;
        internal Label Label2;
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}