using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    [DesignerGenerated()]
    internal partial class frmPointsOnGCR
    {
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        [DebuggerNonUserCode()]
        public frmPointsOnGCR() : base()
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
        private TextBox _txtLoPointDeg;

        public TextBox txtLoPointDeg
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtLoPointDeg;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtLoPointDeg != null)
                {
                    _txtLoPointDeg.TextChanged -= txtLoPointDeg_TextChanged;
                    _txtLoPointDeg.KeyPress -= txtLoPointDeg_KeyPress;
                    _txtLoPointDeg.Validating -= txtLoPointDeg_Validating;
                    _txtLoPointDeg.Enter -= txtLoPointDeg_Enter;
                }

                _txtLoPointDeg = value;
                if (_txtLoPointDeg != null)
                {
                    _txtLoPointDeg.TextChanged += txtLoPointDeg_TextChanged;
                    _txtLoPointDeg.KeyPress += txtLoPointDeg_KeyPress;
                    _txtLoPointDeg.Validating += txtLoPointDeg_Validating;
                    _txtLoPointDeg.Enter += txtLoPointDeg_Enter;
                }
            }
        }

        private TextBox _txtLoPointMin;

        public TextBox txtLoPointMin
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtLoPointMin;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtLoPointMin != null)
                {
                    _txtLoPointMin.TextChanged -= txtLoPointMin_TextChanged;
                    _txtLoPointMin.KeyPress -= txtLoPointMin_KeyPress;
                    _txtLoPointMin.Validating -= txtLoPointMin_Validating;
                    _txtLoPointMin.Enter -= txtLoPointMin_Enter;
                }

                _txtLoPointMin = value;
                if (_txtLoPointMin != null)
                {
                    _txtLoPointMin.TextChanged += txtLoPointMin_TextChanged;
                    _txtLoPointMin.KeyPress += txtLoPointMin_KeyPress;
                    _txtLoPointMin.Validating += txtLoPointMin_Validating;
                    _txtLoPointMin.Enter += txtLoPointMin_Enter;
                }
            }
        }

        public ComboBox cboLoPoint;
        private Button _cmdWaypoint;

        public Button cmdWaypoint
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdWaypoint;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdWaypoint != null)
                {
                    _cmdWaypoint.Click -= cmdWaypoint_Click;
                }

                _cmdWaypoint = value;
                if (_cmdWaypoint != null)
                {
                    _cmdWaypoint.Click += cmdWaypoint_Click;
                }
            }
        }

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

        public Label Label4;
        public Label Label3;
        public Label lblWaypointLo;
        public Label lblLoDeg;
        public Label lblLoMin;
        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPointsOnGCR));
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            ToolTip1 = new ToolTip(components);
            _txtLoPointDeg = new TextBox();
            _txtLoPointDeg.TextChanged += new EventHandler(txtLoPointDeg_TextChanged);
            _txtLoPointDeg.KeyPress += new KeyPressEventHandler(txtLoPointDeg_KeyPress);
            _txtLoPointDeg.Validating += new System.ComponentModel.CancelEventHandler(txtLoPointDeg_Validating);
            _txtLoPointDeg.Enter += new EventHandler(txtLoPointDeg_Enter);
            _txtLoPointMin = new TextBox();
            _txtLoPointMin.TextChanged += new EventHandler(txtLoPointMin_TextChanged);
            _txtLoPointMin.KeyPress += new KeyPressEventHandler(txtLoPointMin_KeyPress);
            _txtLoPointMin.Validating += new System.ComponentModel.CancelEventHandler(txtLoPointMin_Validating);
            _txtLoPointMin.Enter += new EventHandler(txtLoPointMin_Enter);
            _cmdPrint = new Button();
            _cmdPrint.Click += new EventHandler(cmdPrint_Click);
            cboLoPoint = new ComboBox();
            _cmdWaypoint = new Button();
            _cmdWaypoint.Click += new EventHandler(cmdWaypoint_Click);
            Label4 = new Label();
            Label3 = new Label();
            lblWaypointLo = new Label();
            lblLoDeg = new Label();
            lblLoMin = new Label();
            PictureBox1 = new PictureBox();
            _ExitBtn = new Button();
            _ExitBtn.Click += new EventHandler(ExitBtn_Click);
            DGGCR = new DataGridView();
            Label1 = new Label();
            Label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGGCR).BeginInit();
            SuspendLayout();
            // 
            // txtLoPointDeg
            // 
            _txtLoPointDeg.AcceptsReturn = true;
            _txtLoPointDeg.BackColor = SystemColors.Window;
            _txtLoPointDeg.Cursor = Cursors.IBeam;
            _txtLoPointDeg.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtLoPointDeg.ForeColor = SystemColors.WindowText;
            _txtLoPointDeg.Location = new Point(442, 106);
            _txtLoPointDeg.MaxLength = 3;
            _txtLoPointDeg.Name = "_txtLoPointDeg";
            _txtLoPointDeg.RightToLeft = RightToLeft.No;
            _txtLoPointDeg.Size = new Size(33, 21);
            _txtLoPointDeg.TabIndex = 6;
            ToolTip1.SetToolTip(_txtLoPointDeg, "Range 0 to 180");
            // 
            // txtLoPointMin
            // 
            _txtLoPointMin.AcceptsReturn = true;
            _txtLoPointMin.BackColor = SystemColors.Window;
            _txtLoPointMin.Cursor = Cursors.IBeam;
            _txtLoPointMin.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtLoPointMin.ForeColor = SystemColors.WindowText;
            _txtLoPointMin.Location = new Point(482, 106);
            _txtLoPointMin.MaxLength = 4;
            _txtLoPointMin.Name = "_txtLoPointMin";
            _txtLoPointMin.RightToLeft = RightToLeft.No;
            _txtLoPointMin.Size = new Size(33, 21);
            _txtLoPointMin.TabIndex = 5;
            ToolTip1.SetToolTip(_txtLoPointMin, "Range 0 to 59.9");
            // 
            // cmdPrint
            // 
            _cmdPrint.BackColor = SystemColors.Control;
            _cmdPrint.Cursor = Cursors.Default;
            _cmdPrint.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdPrint.ForeColor = SystemColors.ControlText;
            _cmdPrint.Image = (Image)resources.GetObject("cmdPrint.Image");
            _cmdPrint.Location = new Point(552, 0);
            _cmdPrint.Name = "_cmdPrint";
            _cmdPrint.RightToLeft = RightToLeft.No;
            _cmdPrint.Size = new Size(21, 21);
            _cmdPrint.TabIndex = 2;
            _cmdPrint.TextAlign = ContentAlignment.BottomCenter;
            ToolTip1.SetToolTip(_cmdPrint, "Print window");
            _cmdPrint.UseVisualStyleBackColor = false;
            // 
            // cboLoPoint
            // 
            cboLoPoint.BackColor = SystemColors.Window;
            cboLoPoint.Cursor = Cursors.Default;
            cboLoPoint.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoPoint.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboLoPoint.ForeColor = SystemColors.WindowText;
            cboLoPoint.Items.AddRange(new object[] { "W", "E" });
            cboLoPoint.Location = new Point(522, 106);
            cboLoPoint.Name = "cboLoPoint";
            cboLoPoint.RightToLeft = RightToLeft.No;
            cboLoPoint.Size = new Size(41, 21);
            cboLoPoint.TabIndex = 4;
            // 
            // cmdWaypoint
            // 
            _cmdWaypoint.BackColor = SystemColors.Control;
            _cmdWaypoint.Cursor = Cursors.Default;
            _cmdWaypoint.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdWaypoint.ForeColor = SystemColors.ControlText;
            _cmdWaypoint.Location = new Point(442, 133);
            _cmdWaypoint.Name = "_cmdWaypoint";
            _cmdWaypoint.RightToLeft = RightToLeft.No;
            _cmdWaypoint.Size = new Size(89, 33);
            _cmdWaypoint.TabIndex = 3;
            _cmdWaypoint.Text = "&Point Latitude";
            _cmdWaypoint.UseVisualStyleBackColor = false;
            // 
            // Label4
            // 
            Label4.BackColor = SystemColors.Window;
            Label4.Cursor = Cursors.Default;
            Label4.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.ForeColor = SystemColors.ControlText;
            Label4.Location = new Point(434, 68);
            Label4.Name = "Label4";
            Label4.RightToLeft = RightToLeft.No;
            Label4.Size = new Size(104, 32);
            Label4.TabIndex = 11;
            Label4.Text = "(not necessarily " + '\r' + '\n' + "on route)";
            Label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label3
            // 
            Label3.BackColor = SystemColors.Window;
            Label3.Cursor = Cursors.Default;
            Label3.Font = new Font("Tahoma", 8.25f, FontStyle.Underline, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.ForeColor = SystemColors.ControlText;
            Label3.Location = new Point(439, 32);
            Label3.Name = "Label3";
            Label3.RightToLeft = RightToLeft.No;
            Label3.Size = new Size(96, 40);
            Label3.TabIndex = 10;
            Label3.Text = "Individual Point " + '\r' + '\n' + "on Great Circle";
            Label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWaypointLo
            // 
            lblWaypointLo.BackColor = SystemColors.Window;
            lblWaypointLo.Cursor = Cursors.Default;
            lblWaypointLo.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblWaypointLo.ForeColor = SystemColors.ControlText;
            lblWaypointLo.Location = new Point(422, 105);
            lblWaypointLo.Name = "lblWaypointLo";
            lblWaypointLo.RightToLeft = RightToLeft.No;
            lblWaypointLo.Size = new Size(20, 23);
            lblWaypointLo.TabIndex = 9;
            lblWaypointLo.Text = "Lo";
            lblWaypointLo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLoDeg
            // 
            lblLoDeg.BackColor = SystemColors.Window;
            lblLoDeg.Cursor = Cursors.Default;
            lblLoDeg.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLoDeg.ForeColor = SystemColors.ControlText;
            lblLoDeg.Location = new Point(472, 106);
            lblLoDeg.Name = "lblLoDeg";
            lblLoDeg.RightToLeft = RightToLeft.No;
            lblLoDeg.Size = new Size(9, 17);
            lblLoDeg.TabIndex = 8;
            lblLoDeg.Text = "°";
            // 
            // lblLoMin
            // 
            lblLoMin.BackColor = SystemColors.Window;
            lblLoMin.Cursor = Cursors.Default;
            lblLoMin.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLoMin.ForeColor = SystemColors.ControlText;
            lblLoMin.Location = new Point(515, 106);
            lblLoMin.Name = "lblLoMin";
            lblLoMin.RightToLeft = RightToLeft.No;
            lblLoMin.Size = new Size(9, 17);
            lblLoMin.TabIndex = 7;
            lblLoMin.Text = "'";
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.ABC_white;
            PictureBox1.Location = new Point(21, 674);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(390, 41);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 102;
            PictureBox1.TabStop = false;
            // 
            // ExitBtn
            // 
            _ExitBtn.BackColor = Color.Red;
            _ExitBtn.Cursor = Cursors.Default;
            _ExitBtn.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _ExitBtn.ForeColor = SystemColors.ControlLightLight;
            _ExitBtn.Location = new Point(491, 674);
            _ExitBtn.Name = "_ExitBtn";
            _ExitBtn.RightToLeft = RightToLeft.No;
            _ExitBtn.Size = new Size(72, 27);
            _ExitBtn.TabIndex = 108;
            _ExitBtn.Text = "Exit";
            _ExitBtn.UseVisualStyleBackColor = false;
            // 
            // DGGCR
            // 
            DGGCR.AllowUserToAddRows = false;
            DGGCR.AllowUserToDeleteRows = false;
            DGGCR.AllowUserToResizeColumns = false;
            DGGCR.AllowUserToResizeRows = false;
            DGGCR.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            DGGCR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGGCR.EditMode = DataGridViewEditMode.EditProgrammatically;
            DGGCR.Location = new Point(21, 34);
            DGGCR.Name = "DGGCR";
            DGGCR.ReadOnly = true;
            DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle1.BackColor = Color.Yellow;
            DataGridViewCellStyle1.Font = new Font("Courier New", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGGCR.RowHeadersDefaultCellStyle = DataGridViewCellStyle1;
            DGGCR.SelectionMode = DataGridViewSelectionMode.CellSelect;
            DGGCR.Size = new Size(390, 634);
            DGGCR.TabIndex = 109;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Arial", 14.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.Location = new Point(71, 9);
            Label1.Name = "Label1";
            Label1.Size = new Size(288, 22);
            Label1.TabIndex = 110;
            Label1.Text = "Points on a Great Circle Route";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.Location = new Point(421, 469);
            Label2.Name = "Label2";
            Label2.Size = new Size(158, 196);
            Label2.TabIndex = 111;
            Label2.Text = resources.GetString("Label2.Text");
            Label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmPointsOnGCR
            // 
            AutoScaleDimensions = new SizeF(7.0f, 14.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(576, 720);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(DGGCR);
            Controls.Add(_ExitBtn);
            Controls.Add(PictureBox1);
            Controls.Add(_txtLoPointDeg);
            Controls.Add(_txtLoPointMin);
            Controls.Add(cboLoPoint);
            Controls.Add(_cmdWaypoint);
            Controls.Add(_cmdPrint);
            Controls.Add(Label4);
            Controls.Add(Label3);
            Controls.Add(lblWaypointLo);
            Controls.Add(lblLoDeg);
            Controls.Add(lblLoMin);
            Cursor = Cursors.Default;
            Font = new Font("Courier New", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(3, 29);
            MaximizeBox = false;
            Name = "frmPointsOnGCR";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.Manual;
            Text = "Points on Great Circle Route";
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGGCR).EndInit();
            Load += new EventHandler(frmPointsOnGCR_Load);
            FormClosed += new FormClosedEventHandler(frmPointsOnGCR_FormClosed);
            ResumeLayout(false);
            PerformLayout();
        }

        internal PictureBox PictureBox1;
        private Button _ExitBtn;

        public Button ExitBtn
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

        internal DataGridView DGGCR;
        internal Label Label1;
        internal Label Label2;
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}