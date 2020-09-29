using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    [DesignerGenerated()]
    internal partial class Form60DST
    {
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        [DebuggerNonUserCode()]
        public Form60DST() : base()
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
        private TextBox _txtd;

        public TextBox txtd
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtd;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtd != null)
                {
                    _txtd.TextChanged -= txtd_TextChanged;
                    _txtd.KeyPress -= txtd_KeyPress;
                    _txtd.Enter -= txtd_Enter;
                }

                _txtd = value;
                if (_txtd != null)
                {
                    _txtd.TextChanged += txtd_TextChanged;
                    _txtd.KeyPress += txtd_KeyPress;
                    _txtd.Enter += txtd_Enter;
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

        private Button _cmdDistance;

        public Button cmdDistance
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdDistance;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdDistance != null)
                {
                    _cmdDistance.Click -= cmdDistance_Click;
                }

                _cmdDistance = value;
                if (_cmdDistance != null)
                {
                    _cmdDistance.Click += cmdDistance_Click;
                }
            }
        }

        private Button _cmdTime;

        public Button cmdTime
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdTime;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdTime != null)
                {
                    _cmdTime.Click -= cmdTime_Click;
                }

                _cmdTime = value;
                if (_cmdTime != null)
                {
                    _cmdTime.Click += cmdTime_Click;
                }
            }
        }

        private Button _cmdSpeed;

        public Button cmdSpeed
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdSpeed;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdSpeed != null)
                {
                    _cmdSpeed.Click -= cmdSpeed_Click;
                }

                _cmdSpeed = value;
                if (_cmdSpeed != null)
                {
                    _cmdSpeed.Click += cmdSpeed_Click;
                }
            }
        }

        private TextBox _txtm;

        public TextBox txtm
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtm;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtm != null)
                {
                    _txtm.TextChanged -= txtm_TextChanged;
                    _txtm.KeyPress -= txtm_KeyPress;
                    _txtm.Validating -= txtm_Validating;
                    _txtm.Enter -= txtm_Enter;
                }

                _txtm = value;
                if (_txtm != null)
                {
                    _txtm.TextChanged += txtm_TextChanged;
                    _txtm.KeyPress += txtm_KeyPress;
                    _txtm.Validating += txtm_Validating;
                    _txtm.Enter += txtm_Enter;
                }
            }
        }

        private TextBox _txth;

        public TextBox txth
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txth;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txth != null)
                {
                    _txth.TextChanged -= txth_TextChanged;
                    _txth.KeyPress -= txth_KeyPress;
                    _txth.Enter -= txth_Enter;
                }

                _txth = value;
                if (_txth != null)
                {
                    _txth.TextChanged += txth_TextChanged;
                    _txth.KeyPress += txth_KeyPress;
                    _txth.Enter += txth_Enter;
                }
            }
        }

        private Button _cmdClear;

        public Button cmdClear
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdClear;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdClear != null)
                {
                    _cmdClear.Click -= cmdClear_Click;
                }

                _cmdClear = value;
                if (_cmdClear != null)
                {
                    _cmdClear.Click += cmdClear_Click;
                }
            }
        }

        private TextBox _txtTime;

        public TextBox txtTime
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtTime;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtTime != null)
                {
                    _txtTime.TextChanged -= txtTime_TextChanged;
                    _txtTime.KeyPress -= txtTime_KeyPress;
                    _txtTime.Validating -= txtTime_Validating;
                    _txtTime.Enter -= txtTime_Enter;
                }

                _txtTime = value;
                if (_txtTime != null)
                {
                    _txtTime.TextChanged += txtTime_TextChanged;
                    _txtTime.KeyPress += txtTime_KeyPress;
                    _txtTime.Validating += txtTime_Validating;
                    _txtTime.Enter += txtTime_Enter;
                }
            }
        }

        private TextBox _txtSpeed;

        public TextBox txtSpeed
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtSpeed;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtSpeed != null)
                {
                    _txtSpeed.TextChanged -= txtSpeed_TextChanged;
                    _txtSpeed.KeyPress -= txtSpeed_KeyPress;
                    _txtSpeed.Validating -= txtSpeed_Validating;
                    _txtSpeed.Enter -= txtSpeed_Enter;
                }

                _txtSpeed = value;
                if (_txtSpeed != null)
                {
                    _txtSpeed.TextChanged += txtSpeed_TextChanged;
                    _txtSpeed.KeyPress += txtSpeed_KeyPress;
                    _txtSpeed.Validating += txtSpeed_Validating;
                    _txtSpeed.Enter += txtSpeed_Enter;
                }
            }
        }

        private TextBox _txtDistance;

        public TextBox txtDistance
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtDistance;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtDistance != null)
                {
                    _txtDistance.TextChanged -= txtDistance_TextChanged;
                    _txtDistance.KeyPress -= txtDistance_KeyPress;
                    _txtDistance.Enter -= txtDistance_Enter;
                }

                _txtDistance = value;
                if (_txtDistance != null)
                {
                    _txtDistance.TextChanged += txtDistance_TextChanged;
                    _txtDistance.KeyPress += txtDistance_KeyPress;
                    _txtDistance.Enter += txtDistance_Enter;
                }
            }
        }

        public Label Label1;
        public Label Label2;
        public Label lblm;
        public Label lblh;
        public Label lblmin;
        public Label lblkn;
        public Label lblnm;
        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Form60DST));
            ToolTip1 = new ToolTip(components);
            _txtd = new TextBox();
            _txtd.TextChanged += new EventHandler(txtd_TextChanged);
            _txtd.KeyPress += new KeyPressEventHandler(txtd_KeyPress);
            _txtd.Enter += new EventHandler(txtd_Enter);
            _cmdPrint = new Button();
            _cmdPrint.Click += new EventHandler(cmdPrint_Click);
            _txtm = new TextBox();
            _txtm.TextChanged += new EventHandler(txtm_TextChanged);
            _txtm.KeyPress += new KeyPressEventHandler(txtm_KeyPress);
            _txtm.Validating += new System.ComponentModel.CancelEventHandler(txtm_Validating);
            _txtm.Enter += new EventHandler(txtm_Enter);
            _txth = new TextBox();
            _txth.TextChanged += new EventHandler(txth_TextChanged);
            _txth.KeyPress += new KeyPressEventHandler(txth_KeyPress);
            _txth.Enter += new EventHandler(txth_Enter);
            _txtTime = new TextBox();
            _txtTime.TextChanged += new EventHandler(txtTime_TextChanged);
            _txtTime.KeyPress += new KeyPressEventHandler(txtTime_KeyPress);
            _txtTime.Validating += new System.ComponentModel.CancelEventHandler(txtTime_Validating);
            _txtTime.Enter += new EventHandler(txtTime_Enter);
            _txtSpeed = new TextBox();
            _txtSpeed.TextChanged += new EventHandler(txtSpeed_TextChanged);
            _txtSpeed.KeyPress += new KeyPressEventHandler(txtSpeed_KeyPress);
            _txtSpeed.Validating += new System.ComponentModel.CancelEventHandler(txtSpeed_Validating);
            _txtSpeed.Enter += new EventHandler(txtSpeed_Enter);
            _txtDistance = new TextBox();
            _txtDistance.TextChanged += new EventHandler(txtDistance_TextChanged);
            _txtDistance.KeyPress += new KeyPressEventHandler(txtDistance_KeyPress);
            _txtDistance.Enter += new EventHandler(txtDistance_Enter);
            _cmdDistance = new Button();
            _cmdDistance.Click += new EventHandler(cmdDistance_Click);
            _cmdTime = new Button();
            _cmdTime.Click += new EventHandler(cmdTime_Click);
            _cmdSpeed = new Button();
            _cmdSpeed.Click += new EventHandler(cmdSpeed_Click);
            _cmdClear = new Button();
            _cmdClear.Click += new EventHandler(cmdClear_Click);
            Label1 = new Label();
            Label2 = new Label();
            lblm = new Label();
            lblh = new Label();
            lblmin = new Label();
            lblkn = new Label();
            lblnm = new Label();
            _ExitBtn = new Button();
            _ExitBtn.Click += new EventHandler(ExitBtn_Click);
            PictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtd
            // 
            _txtd.AcceptsReturn = true;
            _txtd.BackColor = SystemColors.Window;
            _txtd.Cursor = Cursors.IBeam;
            _txtd.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtd.ForeColor = SystemColors.WindowText;
            _txtd.Location = new Point(216, 91);
            _txtd.MaxLength = 2;
            _txtd.Name = "_txtd";
            _txtd.RightToLeft = RightToLeft.No;
            _txtd.Size = new Size(50, 20);
            _txtd.TabIndex = 16;
            _txtd.TextAlign = HorizontalAlignment.Center;
            ToolTip1.SetToolTip(_txtd, "Maximum 99");
            // 
            // cmdPrint
            // 
            _cmdPrint.BackColor = SystemColors.Control;
            _cmdPrint.Cursor = Cursors.Default;
            _cmdPrint.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdPrint.ForeColor = SystemColors.ControlText;
            _cmdPrint.Image = (Image)resources.GetObject("cmdPrint.Image");
            _cmdPrint.Location = new Point(308, 3);
            _cmdPrint.Name = "_cmdPrint";
            _cmdPrint.RightToLeft = RightToLeft.No;
            _cmdPrint.Size = new Size(21, 21);
            _cmdPrint.TabIndex = 15;
            _cmdPrint.TextAlign = ContentAlignment.BottomCenter;
            ToolTip1.SetToolTip(_cmdPrint, "Print window");
            _cmdPrint.UseVisualStyleBackColor = false;
            // 
            // txtm
            // 
            _txtm.AcceptsReturn = true;
            _txtm.BackColor = SystemColors.Window;
            _txtm.Cursor = Cursors.IBeam;
            _txtm.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtm.ForeColor = SystemColors.WindowText;
            _txtm.Location = new Point(216, 134);
            _txtm.MaxLength = 2;
            _txtm.Name = "_txtm";
            _txtm.RightToLeft = RightToLeft.No;
            _txtm.Size = new Size(50, 20);
            _txtm.TabIndex = 9;
            _txtm.TextAlign = HorizontalAlignment.Center;
            ToolTip1.SetToolTip(_txtm, "Maximum 59");
            // 
            // txth
            // 
            _txth.AcceptsReturn = true;
            _txth.BackColor = SystemColors.Window;
            _txth.Cursor = Cursors.IBeam;
            _txth.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txth.ForeColor = SystemColors.WindowText;
            _txth.Location = new Point(216, 112);
            _txth.MaxLength = 3;
            _txth.Name = "_txth";
            _txth.RightToLeft = RightToLeft.No;
            _txth.Size = new Size(50, 20);
            _txth.TabIndex = 7;
            _txth.TextAlign = HorizontalAlignment.Center;
            ToolTip1.SetToolTip(_txth, "Maximum 999");
            // 
            // txtTime
            // 
            _txtTime.AcceptsReturn = true;
            _txtTime.BackColor = SystemColors.Window;
            _txtTime.Cursor = Cursors.IBeam;
            _txtTime.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtTime.ForeColor = SystemColors.WindowText;
            _txtTime.Location = new Point(81, 112);
            _txtTime.MaxLength = 5;
            _txtTime.Name = "_txtTime";
            _txtTime.RightToLeft = RightToLeft.No;
            _txtTime.Size = new Size(50, 20);
            _txtTime.TabIndex = 1;
            _txtTime.TextAlign = HorizontalAlignment.Center;
            ToolTip1.SetToolTip(_txtTime, "Maximum 59999");
            // 
            // txtSpeed
            // 
            _txtSpeed.AcceptsReturn = true;
            _txtSpeed.BackColor = SystemColors.Window;
            _txtSpeed.Cursor = Cursors.IBeam;
            _txtSpeed.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtSpeed.ForeColor = SystemColors.WindowText;
            _txtSpeed.Location = new Point(81, 68);
            _txtSpeed.MaxLength = 4;
            _txtSpeed.Name = "_txtSpeed";
            _txtSpeed.RightToLeft = RightToLeft.No;
            _txtSpeed.Size = new Size(50, 20);
            _txtSpeed.TabIndex = 0;
            _txtSpeed.TextAlign = HorizontalAlignment.Center;
            ToolTip1.SetToolTip(_txtSpeed, "Maximum 99.9");
            // 
            // txtDistance
            // 
            _txtDistance.AcceptsReturn = true;
            _txtDistance.BackColor = Color.White;
            _txtDistance.Cursor = Cursors.IBeam;
            _txtDistance.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtDistance.ForeColor = SystemColors.WindowText;
            _txtDistance.Location = new Point(80, 157);
            _txtDistance.MaxLength = 6;
            _txtDistance.Name = "_txtDistance";
            _txtDistance.RightToLeft = RightToLeft.No;
            _txtDistance.Size = new Size(50, 20);
            _txtDistance.TabIndex = 2;
            _txtDistance.TextAlign = HorizontalAlignment.Center;
            ToolTip1.SetToolTip(_txtDistance, "Maximum 9999.9");
            // 
            // cmdDistance
            // 
            _cmdDistance.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(192)));
            _cmdDistance.Cursor = Cursors.Default;
            _cmdDistance.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdDistance.ForeColor = SystemColors.ControlText;
            _cmdDistance.Location = new Point(16, 154);
            _cmdDistance.Name = "_cmdDistance";
            _cmdDistance.RightToLeft = RightToLeft.No;
            _cmdDistance.Size = new Size(57, 25);
            _cmdDistance.TabIndex = 13;
            _cmdDistance.Text = "Distance";
            _cmdDistance.UseVisualStyleBackColor = false;
            // 
            // cmdTime
            // 
            _cmdTime.BackColor = SystemColors.Highlight;
            _cmdTime.Cursor = Cursors.Default;
            _cmdTime.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdTime.ForeColor = SystemColors.ControlText;
            _cmdTime.Location = new Point(16, 109);
            _cmdTime.Name = "_cmdTime";
            _cmdTime.RightToLeft = RightToLeft.No;
            _cmdTime.Size = new Size(57, 25);
            _cmdTime.TabIndex = 12;
            _cmdTime.Text = "Time";
            _cmdTime.UseVisualStyleBackColor = false;
            // 
            // cmdSpeed
            // 
            _cmdSpeed.BackColor = SystemColors.ActiveCaption;
            _cmdSpeed.Cursor = Cursors.Default;
            _cmdSpeed.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdSpeed.ForeColor = SystemColors.ControlText;
            _cmdSpeed.Location = new Point(17, 66);
            _cmdSpeed.Name = "_cmdSpeed";
            _cmdSpeed.RightToLeft = RightToLeft.No;
            _cmdSpeed.Size = new Size(57, 25);
            _cmdSpeed.TabIndex = 11;
            _cmdSpeed.Text = "Speed";
            _cmdSpeed.UseVisualStyleBackColor = false;
            // 
            // cmdClear
            // 
            _cmdClear.BackColor = Color.Yellow;
            _cmdClear.Cursor = Cursors.Default;
            _cmdClear.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdClear.ForeColor = SystemColors.ControlText;
            _cmdClear.Location = new Point(6, 192);
            _cmdClear.Name = "_cmdClear";
            _cmdClear.RightToLeft = RightToLeft.No;
            _cmdClear.Size = new Size(80, 25);
            _cmdClear.TabIndex = 6;
            _cmdClear.Text = "&Clear All Data";
            _cmdClear.UseVisualStyleBackColor = false;
            // 
            // Label1
            // 
            Label1.BackColor = SystemColors.Window;
            Label1.Cursor = Cursors.Default;
            Label1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = SystemColors.ControlText;
            Label1.Location = new Point(269, 93);
            Label1.Name = "Label1";
            Label1.RightToLeft = RightToLeft.No;
            Label1.Size = new Size(33, 17);
            Label1.TabIndex = 17;
            Label1.Text = "days";
            Label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label2
            // 
            Label2.BackColor = SystemColors.Window;
            Label2.Cursor = Cursors.Default;
            Label2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = SystemColors.ControlText;
            Label2.Location = new Point(6, 2);
            Label2.Name = "Label2";
            Label2.RightToLeft = RightToLeft.No;
            Label2.Size = new Size(298, 63);
            Label2.TabIndex = 14;
            Label2.Text = resources.GetString("Label2.Text");
            Label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblm
            // 
            lblm.BackColor = SystemColors.Window;
            lblm.Cursor = Cursors.Default;
            lblm.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblm.ForeColor = SystemColors.ControlText;
            lblm.Location = new Point(269, 135);
            lblm.Name = "lblm";
            lblm.RightToLeft = RightToLeft.No;
            lblm.Size = new Size(50, 17);
            lblm.TabIndex = 10;
            lblm.Text = "minutes";
            lblm.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblh
            // 
            lblh.BackColor = SystemColors.Window;
            lblh.Cursor = Cursors.Default;
            lblh.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblh.ForeColor = SystemColors.ControlText;
            lblh.Location = new Point(269, 113);
            lblh.Name = "lblh";
            lblh.RightToLeft = RightToLeft.No;
            lblh.Size = new Size(35, 17);
            lblh.TabIndex = 8;
            lblh.Text = "hours";
            lblh.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblmin
            // 
            lblmin.BackColor = SystemColors.Window;
            lblmin.Cursor = Cursors.Default;
            lblmin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblmin.ForeColor = SystemColors.ControlText;
            lblmin.Location = new Point(135, 113);
            lblmin.Name = "lblmin";
            lblmin.RightToLeft = RightToLeft.No;
            lblmin.Size = new Size(75, 20);
            lblmin.TabIndex = 5;
            lblmin.Text = "minutes    OR";
            lblmin.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblkn
            // 
            lblkn.BackColor = SystemColors.Window;
            lblkn.Cursor = Cursors.Default;
            lblkn.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblkn.ForeColor = SystemColors.ControlText;
            lblkn.Location = new Point(135, 68);
            lblkn.Name = "lblkn";
            lblkn.RightToLeft = RightToLeft.No;
            lblkn.Size = new Size(41, 20);
            lblkn.TabIndex = 4;
            lblkn.Text = "knots";
            lblkn.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblnm
            // 
            lblnm.BackColor = SystemColors.Window;
            lblnm.Cursor = Cursors.Default;
            lblnm.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblnm.ForeColor = SystemColors.ControlText;
            lblnm.Location = new Point(133, 160);
            lblnm.Name = "lblnm";
            lblnm.RightToLeft = RightToLeft.No;
            lblnm.Size = new Size(75, 17);
            lblnm.TabIndex = 3;
            lblnm.Text = "nautical miles";
            lblnm.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ExitBtn
            // 
            _ExitBtn.BackColor = Color.Red;
            _ExitBtn.Cursor = Cursors.Default;
            _ExitBtn.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _ExitBtn.ForeColor = SystemColors.ControlLightLight;
            _ExitBtn.Location = new Point(242, 192);
            _ExitBtn.Name = "_ExitBtn";
            _ExitBtn.RightToLeft = RightToLeft.No;
            _ExitBtn.Size = new Size(80, 25);
            _ExitBtn.TabIndex = 18;
            _ExitBtn.Text = "Exit";
            _ExitBtn.UseVisualStyleBackColor = false;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.ABC_white;
            PictureBox1.Location = new Point(6, 223);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(316, 50);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 102;
            PictureBox1.TabStop = false;
            // 
            // Form60DST
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(334, 279);
            Controls.Add(PictureBox1);
            Controls.Add(_ExitBtn);
            Controls.Add(_txtd);
            Controls.Add(_cmdPrint);
            Controls.Add(_cmdDistance);
            Controls.Add(_cmdTime);
            Controls.Add(_cmdSpeed);
            Controls.Add(_txtm);
            Controls.Add(_txth);
            Controls.Add(_cmdClear);
            Controls.Add(_txtTime);
            Controls.Add(_txtSpeed);
            Controls.Add(_txtDistance);
            Controls.Add(Label1);
            Controls.Add(Label2);
            Controls.Add(lblm);
            Controls.Add(lblh);
            Controls.Add(lblmin);
            Controls.Add(lblkn);
            Controls.Add(lblnm);
            Cursor = Cursors.Default;
            Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(359, 275);
            MaximizeBox = false;
            Name = "Form60DST";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "60D = ST";
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            FormClosed += new FormClosedEventHandler(Form60DST_FormClosed);
            ResumeLayout(false);
            PerformLayout();
        }

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

        internal PictureBox PictureBox1;
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}