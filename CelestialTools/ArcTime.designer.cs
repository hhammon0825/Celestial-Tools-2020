using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    [DesignerGenerated()]
    internal partial class FormArcTime
    {
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        [DebuggerNonUserCode()]
        public FormArcTime() : base()
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
        private TextBox _txtLoMin;

        public TextBox txtLoMin
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtLoMin;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtLoMin != null)
                {
                    _txtLoMin.TextChanged -= txtLoMin_TextChanged;
                    _txtLoMin.KeyPress -= txtLoMin_KeyPress;
                    _txtLoMin.Validating -= txtLoMin_Validating;
                    _txtLoMin.Enter -= txtLoMin_Enter;
                }

                _txtLoMin = value;
                if (_txtLoMin != null)
                {
                    _txtLoMin.TextChanged += txtLoMin_TextChanged;
                    _txtLoMin.KeyPress += txtLoMin_KeyPress;
                    _txtLoMin.Validating += txtLoMin_Validating;
                    _txtLoMin.Enter += txtLoMin_Enter;
                }
            }
        }

        public ComboBox cboLo;
        private TextBox _txtLoDeg;

        public TextBox txtLoDeg
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtLoDeg;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtLoDeg != null)
                {
                    _txtLoDeg.TextChanged -= txtLoDeg_TextChanged;
                    _txtLoDeg.KeyPress -= txtLoDeg_KeyPress;
                    _txtLoDeg.Validating -= txtLoDeg_Validating;
                    _txtLoDeg.Enter -= txtLoDeg_Enter;
                }

                _txtLoDeg = value;
                if (_txtLoDeg != null)
                {
                    _txtLoDeg.TextChanged += txtLoDeg_TextChanged;
                    _txtLoDeg.KeyPress += txtLoDeg_KeyPress;
                    _txtLoDeg.Validating += txtLoDeg_Validating;
                    _txtLoDeg.Enter += txtLoDeg_Enter;
                }
            }
        }

        private RadioButton _optZTtoLMT;

        public RadioButton optZTtoLMT
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optZTtoLMT;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optZTtoLMT != null)
                {
                    _optZTtoLMT.CheckedChanged -= optZTtoLMT_CheckedChanged;
                }

                _optZTtoLMT = value;
                if (_optZTtoLMT != null)
                {
                    _optZTtoLMT.CheckedChanged += optZTtoLMT_CheckedChanged;
                }
            }
        }

        private RadioButton _optLMTtoZT;

        public RadioButton optLMTtoZT
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optLMTtoZT;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optLMTtoZT != null)
                {
                    _optLMTtoZT.CheckedChanged -= optLMTtoZT_CheckedChanged;
                }

                _optLMTtoZT = value;
                if (_optLMTtoZT != null)
                {
                    _optLMTtoZT.CheckedChanged += optLMTtoZT_CheckedChanged;
                }
            }
        }

        public GroupBox Frame2;
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

        private Button _cmdConvert;

        public Button cmdConvert
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdConvert;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdConvert != null)
                {
                    _cmdConvert.Click -= cmdConvert_Click;
                }

                _cmdConvert = value;
                if (_cmdConvert != null)
                {
                    _cmdConvert.Click += cmdConvert_Click;
                }
            }
        }

        private TextBox _txtDeg;

        public TextBox txtDeg
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtDeg;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtDeg != null)
                {
                    _txtDeg.TextChanged -= txtDeg_TextChanged;
                    _txtDeg.KeyPress -= txtDeg_KeyPress;
                    _txtDeg.Validating -= txtDeg_Validating;
                    _txtDeg.Enter -= txtDeg_Enter;
                }

                _txtDeg = value;
                if (_txtDeg != null)
                {
                    _txtDeg.TextChanged += txtDeg_TextChanged;
                    _txtDeg.KeyPress += txtDeg_KeyPress;
                    _txtDeg.Validating += txtDeg_Validating;
                    _txtDeg.Enter += txtDeg_Enter;
                }
            }
        }

        private TextBox _txtMin;

        public TextBox txtMin
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtMin;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtMin != null)
                {
                    _txtMin.TextChanged -= txtMin_TextChanged;
                    _txtMin.KeyPress -= txtMin_KeyPress;
                    _txtMin.Validating -= txtMin_Validating;
                    _txtMin.Enter -= txtMin_Enter;
                }

                _txtMin = value;
                if (_txtMin != null)
                {
                    _txtMin.TextChanged += txtMin_TextChanged;
                    _txtMin.KeyPress += txtMin_KeyPress;
                    _txtMin.Validating += txtMin_Validating;
                    _txtMin.Enter += txtMin_Enter;
                }
            }
        }

        private RadioButton _optTimeToArc;

        public RadioButton optTimeToArc
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optTimeToArc;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optTimeToArc != null)
                {
                    _optTimeToArc.CheckedChanged -= optTimeToArc_CheckedChanged;
                }

                _optTimeToArc = value;
                if (_optTimeToArc != null)
                {
                    _optTimeToArc.CheckedChanged += optTimeToArc_CheckedChanged;
                }
            }
        }

        private RadioButton _optArcToTime;

        public RadioButton optArcToTime
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optArcToTime;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optArcToTime != null)
                {
                    _optArcToTime.CheckedChanged -= optArcToTime_CheckedChanged;
                }

                _optArcToTime = value;
                if (_optArcToTime != null)
                {
                    _optArcToTime.CheckedChanged += optArcToTime_CheckedChanged;
                }
            }
        }

        public GroupBox Frame1;
        public Label lblZT;
        public Label lblLMT;
        public Label lblLoMin;
        public Label lblLoDeg;
        public Label Label1;
        public Label lblArc;
        public Label lblDeg;
        public Label lblMin;
        public Label lblTime;
        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FormArcTime));
            ToolTip1 = new ToolTip(components);
            _txtLoMin = new TextBox();
            _txtLoMin.TextChanged += new EventHandler(txtLoMin_TextChanged);
            _txtLoMin.KeyPress += new KeyPressEventHandler(txtLoMin_KeyPress);
            _txtLoMin.Validating += new System.ComponentModel.CancelEventHandler(txtLoMin_Validating);
            _txtLoMin.Enter += new EventHandler(txtLoMin_Enter);
            _txtLoDeg = new TextBox();
            _txtLoDeg.TextChanged += new EventHandler(txtLoDeg_TextChanged);
            _txtLoDeg.KeyPress += new KeyPressEventHandler(txtLoDeg_KeyPress);
            _txtLoDeg.Validating += new System.ComponentModel.CancelEventHandler(txtLoDeg_Validating);
            _txtLoDeg.Enter += new EventHandler(txtLoDeg_Enter);
            _cmdPrint = new Button();
            _cmdPrint.Click += new EventHandler(cmdPrint_Click);
            _txtDeg = new TextBox();
            _txtDeg.TextChanged += new EventHandler(txtDeg_TextChanged);
            _txtDeg.KeyPress += new KeyPressEventHandler(txtDeg_KeyPress);
            _txtDeg.Validating += new System.ComponentModel.CancelEventHandler(txtDeg_Validating);
            _txtDeg.Enter += new EventHandler(txtDeg_Enter);
            _txtMin = new TextBox();
            _txtMin.TextChanged += new EventHandler(txtMin_TextChanged);
            _txtMin.KeyPress += new KeyPressEventHandler(txtMin_KeyPress);
            _txtMin.Validating += new System.ComponentModel.CancelEventHandler(txtMin_Validating);
            _txtMin.Enter += new EventHandler(txtMin_Enter);
            lblArc = new Label();
            lblTime = new Label();
            cboLo = new ComboBox();
            Frame2 = new GroupBox();
            _optZTtoLMT = new RadioButton();
            _optZTtoLMT.CheckedChanged += new EventHandler(optZTtoLMT_CheckedChanged);
            _optLMTtoZT = new RadioButton();
            _optLMTtoZT.CheckedChanged += new EventHandler(optLMTtoZT_CheckedChanged);
            _cmdConvert = new Button();
            _cmdConvert.Click += new EventHandler(cmdConvert_Click);
            Frame1 = new GroupBox();
            _optTimeToArc = new RadioButton();
            _optTimeToArc.CheckedChanged += new EventHandler(optTimeToArc_CheckedChanged);
            _optArcToTime = new RadioButton();
            _optArcToTime.CheckedChanged += new EventHandler(optArcToTime_CheckedChanged);
            lblZT = new Label();
            lblLMT = new Label();
            lblLoMin = new Label();
            lblLoDeg = new Label();
            Label1 = new Label();
            lblDeg = new Label();
            lblMin = new Label();
            txtArcTime = new TextBox();
            txtLMTZT = new TextBox();
            _ExitBtn = new Button();
            _ExitBtn.Click += new EventHandler(ExitBtn_Click);
            _ClearBtn = new Button();
            _ClearBtn.Click += new EventHandler(ClearBtn_Click);
            PictureBox1 = new PictureBox();
            TabControl1 = new TabControl();
            ArcTime = new TabPage();
            DTTime = new DateTimePicker();
            LMTZT = new TabPage();
            DTLMT = new DateTimePicker();
            Frame2.SuspendLayout();
            Frame1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            TabControl1.SuspendLayout();
            ArcTime.SuspendLayout();
            LMTZT.SuspendLayout();
            SuspendLayout();
            // 
            // txtLoMin
            // 
            _txtLoMin.AcceptsReturn = true;
            _txtLoMin.BackColor = SystemColors.Window;
            _txtLoMin.Cursor = Cursors.IBeam;
            _txtLoMin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtLoMin.ForeColor = SystemColors.WindowText;
            _txtLoMin.Location = new Point(216, 71);
            _txtLoMin.MaxLength = 4;
            _txtLoMin.Name = "_txtLoMin";
            _txtLoMin.RightToLeft = RightToLeft.No;
            _txtLoMin.Size = new Size(33, 20);
            _txtLoMin.TabIndex = 15;
            ToolTip1.SetToolTip(_txtLoMin, "Range 0 to 59.9");
            // 
            // txtLoDeg
            // 
            _txtLoDeg.AcceptsReturn = true;
            _txtLoDeg.BackColor = SystemColors.Window;
            _txtLoDeg.Cursor = Cursors.IBeam;
            _txtLoDeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtLoDeg.ForeColor = SystemColors.WindowText;
            _txtLoDeg.Location = new Point(173, 71);
            _txtLoDeg.MaxLength = 3;
            _txtLoDeg.Name = "_txtLoDeg";
            _txtLoDeg.RightToLeft = RightToLeft.No;
            _txtLoDeg.Size = new Size(33, 20);
            _txtLoDeg.TabIndex = 14;
            ToolTip1.SetToolTip(_txtLoDeg, "Range 0 to 180");
            // 
            // cmdPrint
            // 
            _cmdPrint.BackColor = SystemColors.Control;
            _cmdPrint.Cursor = Cursors.Default;
            _cmdPrint.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdPrint.ForeColor = SystemColors.ControlText;
            _cmdPrint.Image = (Image)resources.GetObject("cmdPrint.Image");
            _cmdPrint.Location = new Point(440, 0);
            _cmdPrint.Name = "_cmdPrint";
            _cmdPrint.RightToLeft = RightToLeft.No;
            _cmdPrint.Size = new Size(21, 21);
            _cmdPrint.TabIndex = 23;
            _cmdPrint.TextAlign = ContentAlignment.BottomCenter;
            ToolTip1.SetToolTip(_cmdPrint, "Print window");
            _cmdPrint.UseVisualStyleBackColor = false;
            // 
            // txtDeg
            // 
            _txtDeg.AcceptsReturn = true;
            _txtDeg.BackColor = SystemColors.Window;
            _txtDeg.Cursor = Cursors.IBeam;
            _txtDeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtDeg.ForeColor = SystemColors.WindowText;
            _txtDeg.Location = new Point(198, 66);
            _txtDeg.MaxLength = 3;
            _txtDeg.Name = "_txtDeg";
            _txtDeg.RightToLeft = RightToLeft.No;
            _txtDeg.Size = new Size(33, 20);
            _txtDeg.TabIndex = 3;
            ToolTip1.SetToolTip(_txtDeg, "Range 0 to 359");
            // 
            // txtMin
            // 
            _txtMin.AcceptsReturn = true;
            _txtMin.BackColor = SystemColors.Window;
            _txtMin.Cursor = Cursors.IBeam;
            _txtMin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtMin.ForeColor = SystemColors.WindowText;
            _txtMin.Location = new Point(244, 66);
            _txtMin.MaxLength = 4;
            _txtMin.Name = "_txtMin";
            _txtMin.RightToLeft = RightToLeft.No;
            _txtMin.Size = new Size(33, 20);
            _txtMin.TabIndex = 4;
            ToolTip1.SetToolTip(_txtMin, "Range 0 to 59.9");
            // 
            // lblArc
            // 
            lblArc.BackColor = SystemColors.Window;
            lblArc.Cursor = Cursors.Default;
            lblArc.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblArc.ForeColor = SystemColors.ControlText;
            lblArc.Location = new Point(155, 66);
            lblArc.Name = "lblArc";
            lblArc.RightToLeft = RightToLeft.No;
            lblArc.Size = new Size(26, 22);
            lblArc.TabIndex = 9;
            lblArc.Text = "Arc";
            lblArc.TextAlign = ContentAlignment.MiddleCenter;
            ToolTip1.SetToolTip(lblArc, "Sextant Altitude");
            // 
            // lblTime
            // 
            lblTime.BackColor = SystemColors.Window;
            lblTime.Cursor = Cursors.Default;
            lblTime.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblTime.ForeColor = SystemColors.ControlText;
            lblTime.Location = new Point(108, 92);
            lblTime.Name = "lblTime";
            lblTime.RightToLeft = RightToLeft.No;
            lblTime.Size = new Size(89, 20);
            lblTime.TabIndex = 6;
            lblTime.Text = "Time (hh:mm:ss)";
            lblTime.TextAlign = ContentAlignment.MiddleCenter;
            ToolTip1.SetToolTip(lblTime, "Watch Time");
            lblTime.Visible = false;
            // 
            // cboLo
            // 
            cboLo.BackColor = SystemColors.Window;
            cboLo.Cursor = Cursors.Default;
            cboLo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLo.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboLo.ForeColor = SystemColors.WindowText;
            cboLo.Items.AddRange(new object[] { "W", "E" });
            cboLo.Location = new Point(258, 70);
            cboLo.Name = "cboLo";
            cboLo.RightToLeft = RightToLeft.No;
            cboLo.Size = new Size(41, 22);
            cboLo.TabIndex = 17;
            // 
            // Frame2
            // 
            Frame2.BackColor = SystemColors.Window;
            Frame2.Controls.Add(_optZTtoLMT);
            Frame2.Controls.Add(_optLMTtoZT);
            Frame2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Frame2.ForeColor = SystemColors.ControlText;
            Frame2.Location = new Point(128, 23);
            Frame2.Name = "Frame2";
            Frame2.Padding = new Padding(0);
            Frame2.RightToLeft = RightToLeft.No;
            Frame2.Size = new Size(185, 41);
            Frame2.TabIndex = 10;
            Frame2.TabStop = false;
            Frame2.Text = "Convert";
            // 
            // optZTtoLMT
            // 
            _optZTtoLMT.BackColor = SystemColors.Window;
            _optZTtoLMT.Cursor = Cursors.Default;
            _optZTtoLMT.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optZTtoLMT.ForeColor = SystemColors.ControlText;
            _optZTtoLMT.Location = new Point(96, 16);
            _optZTtoLMT.Name = "_optZTtoLMT";
            _optZTtoLMT.RightToLeft = RightToLeft.No;
            _optZTtoLMT.Size = new Size(73, 17);
            _optZTtoLMT.TabIndex = 12;
            _optZTtoLMT.TabStop = true;
            _optZTtoLMT.Text = "ZT to LMT";
            _optZTtoLMT.UseVisualStyleBackColor = false;
            // 
            // optLMTtoZT
            // 
            _optLMTtoZT.BackColor = SystemColors.Window;
            _optLMTtoZT.Checked = true;
            _optLMTtoZT.Cursor = Cursors.Default;
            _optLMTtoZT.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optLMTtoZT.ForeColor = SystemColors.ControlText;
            _optLMTtoZT.Location = new Point(8, 16);
            _optLMTtoZT.Name = "_optLMTtoZT";
            _optLMTtoZT.RightToLeft = RightToLeft.No;
            _optLMTtoZT.Size = new Size(73, 17);
            _optLMTtoZT.TabIndex = 11;
            _optLMTtoZT.TabStop = true;
            _optLMTtoZT.Text = "LMT to ZT";
            _optLMTtoZT.UseVisualStyleBackColor = false;
            // 
            // cmdConvert
            // 
            _cmdConvert.BackColor = SystemColors.Control;
            _cmdConvert.Cursor = Cursors.Default;
            _cmdConvert.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdConvert.ForeColor = SystemColors.ControlText;
            _cmdConvert.Location = new Point(186, 241);
            _cmdConvert.Name = "_cmdConvert";
            _cmdConvert.RightToLeft = RightToLeft.No;
            _cmdConvert.Size = new Size(92, 25);
            _cmdConvert.TabIndex = 22;
            _cmdConvert.Text = "&Convert";
            _cmdConvert.UseVisualStyleBackColor = false;
            // 
            // Frame1
            // 
            Frame1.BackColor = SystemColors.Window;
            Frame1.Controls.Add(_optTimeToArc);
            Frame1.Controls.Add(_optArcToTime);
            Frame1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Frame1.ForeColor = SystemColors.ControlText;
            Frame1.Location = new Point(113, 18);
            Frame1.Name = "Frame1";
            Frame1.Padding = new Padding(0);
            Frame1.RightToLeft = RightToLeft.No;
            Frame1.Size = new Size(185, 41);
            Frame1.TabIndex = 0;
            Frame1.TabStop = false;
            Frame1.Text = "Convert";
            // 
            // optTimeToArc
            // 
            _optTimeToArc.BackColor = SystemColors.Window;
            _optTimeToArc.Cursor = Cursors.Default;
            _optTimeToArc.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optTimeToArc.ForeColor = SystemColors.ControlText;
            _optTimeToArc.Location = new Point(96, 16);
            _optTimeToArc.Name = "_optTimeToArc";
            _optTimeToArc.RightToLeft = RightToLeft.No;
            _optTimeToArc.Size = new Size(81, 17);
            _optTimeToArc.TabIndex = 2;
            _optTimeToArc.TabStop = true;
            _optTimeToArc.Text = "Time to Arc";
            _optTimeToArc.UseVisualStyleBackColor = false;
            // 
            // optArcToTime
            // 
            _optArcToTime.BackColor = SystemColors.Window;
            _optArcToTime.Checked = true;
            _optArcToTime.Cursor = Cursors.Default;
            _optArcToTime.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optArcToTime.ForeColor = SystemColors.ControlText;
            _optArcToTime.Location = new Point(8, 16);
            _optArcToTime.Name = "_optArcToTime";
            _optArcToTime.RightToLeft = RightToLeft.No;
            _optArcToTime.Size = new Size(81, 17);
            _optArcToTime.TabIndex = 1;
            _optArcToTime.TabStop = true;
            _optArcToTime.Text = "Arc to Time";
            _optArcToTime.UseVisualStyleBackColor = false;
            // 
            // lblZT
            // 
            lblZT.BackColor = SystemColors.Window;
            lblZT.Cursor = Cursors.Default;
            lblZT.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblZT.ForeColor = SystemColors.ControlText;
            lblZT.Location = new Point(147, 98);
            lblZT.Name = "lblZT";
            lblZT.RightToLeft = RightToLeft.No;
            lblZT.Size = new Size(90, 17);
            lblZT.TabIndex = 21;
            lblZT.Text = "ZT (hh:mm:ss)";
            lblZT.Visible = false;
            // 
            // lblLMT
            // 
            lblLMT.BackColor = SystemColors.Window;
            lblLMT.Cursor = Cursors.Default;
            lblLMT.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLMT.ForeColor = SystemColors.ControlText;
            lblLMT.Location = new Point(147, 98);
            lblLMT.Name = "lblLMT";
            lblLMT.RightToLeft = RightToLeft.No;
            lblLMT.Size = new Size(90, 17);
            lblLMT.TabIndex = 20;
            lblLMT.Text = "LMT (hh:mm:ss)";
            lblLMT.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLoMin
            // 
            lblLoMin.BackColor = SystemColors.Window;
            lblLoMin.Cursor = Cursors.Default;
            lblLoMin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLoMin.ForeColor = SystemColors.ControlText;
            lblLoMin.Location = new Point(249, 71);
            lblLoMin.Name = "lblLoMin";
            lblLoMin.RightToLeft = RightToLeft.No;
            lblLoMin.Size = new Size(9, 17);
            lblLoMin.TabIndex = 18;
            lblLoMin.Text = "'";
            // 
            // lblLoDeg
            // 
            lblLoDeg.BackColor = SystemColors.Window;
            lblLoDeg.Cursor = Cursors.Default;
            lblLoDeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLoDeg.ForeColor = SystemColors.ControlText;
            lblLoDeg.Location = new Point(207, 71);
            lblLoDeg.Name = "lblLoDeg";
            lblLoDeg.RightToLeft = RightToLeft.No;
            lblLoDeg.Size = new Size(9, 17);
            lblLoDeg.TabIndex = 16;
            lblLoDeg.Text = "°";
            // 
            // Label1
            // 
            Label1.BackColor = SystemColors.Window;
            Label1.Cursor = Cursors.Default;
            Label1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = SystemColors.ControlText;
            Label1.Location = new Point(144, 71);
            Label1.Name = "Label1";
            Label1.RightToLeft = RightToLeft.No;
            Label1.Size = new Size(26, 22);
            Label1.TabIndex = 13;
            Label1.Text = "Lo";
            Label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDeg
            // 
            lblDeg.BackColor = SystemColors.Window;
            lblDeg.Cursor = Cursors.Default;
            lblDeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblDeg.ForeColor = SystemColors.ControlText;
            lblDeg.Location = new Point(231, 66);
            lblDeg.Name = "lblDeg";
            lblDeg.RightToLeft = RightToLeft.No;
            lblDeg.Size = new Size(9, 17);
            lblDeg.TabIndex = 8;
            lblDeg.Text = "°";
            // 
            // lblMin
            // 
            lblMin.BackColor = SystemColors.Window;
            lblMin.Cursor = Cursors.Default;
            lblMin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblMin.ForeColor = SystemColors.ControlText;
            lblMin.Location = new Point(279, 68);
            lblMin.Name = "lblMin";
            lblMin.RightToLeft = RightToLeft.No;
            lblMin.Size = new Size(9, 17);
            lblMin.TabIndex = 7;
            lblMin.Text = "'";
            // 
            // txtArcTime
            // 
            txtArcTime.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtArcTime.Location = new Point(103, 116);
            txtArcTime.Multiline = true;
            txtArcTime.Name = "txtArcTime";
            txtArcTime.ReadOnly = true;
            txtArcTime.ScrollBars = ScrollBars.Vertical;
            txtArcTime.Size = new Size(226, 45);
            txtArcTime.TabIndex = 25;
            txtArcTime.TextAlign = HorizontalAlignment.Center;
            // 
            // txtLMTZT
            // 
            txtLMTZT.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtLMTZT.Location = new Point(109, 122);
            txtLMTZT.Multiline = true;
            txtLMTZT.Name = "txtLMTZT";
            txtLMTZT.ReadOnly = true;
            txtLMTZT.ScrollBars = ScrollBars.Vertical;
            txtLMTZT.Size = new Size(226, 45);
            txtLMTZT.TabIndex = 26;
            txtLMTZT.TextAlign = HorizontalAlignment.Center;
            // 
            // ExitBtn
            // 
            _ExitBtn.BackColor = Color.Red;
            _ExitBtn.Cursor = Cursors.Default;
            _ExitBtn.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _ExitBtn.ForeColor = SystemColors.ControlLightLight;
            _ExitBtn.Location = new Point(394, 241);
            _ExitBtn.Name = "_ExitBtn";
            _ExitBtn.RightToLeft = RightToLeft.No;
            _ExitBtn.Size = new Size(60, 25);
            _ExitBtn.TabIndex = 27;
            _ExitBtn.Text = "Exit";
            _ExitBtn.UseVisualStyleBackColor = false;
            // 
            // ClearBtn
            // 
            _ClearBtn.BackColor = SystemColors.Control;
            _ClearBtn.Cursor = Cursors.Default;
            _ClearBtn.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _ClearBtn.ForeColor = SystemColors.ControlText;
            _ClearBtn.Location = new Point(4, 241);
            _ClearBtn.Name = "_ClearBtn";
            _ClearBtn.RightToLeft = RightToLeft.No;
            _ClearBtn.Size = new Size(92, 25);
            _ClearBtn.TabIndex = 28;
            _ClearBtn.Text = "Clear";
            _ClearBtn.UseVisualStyleBackColor = false;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.ABC_white;
            PictureBox1.Location = new Point(76, 271);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(316, 50);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 102;
            PictureBox1.TabStop = false;
            // 
            // TabControl1
            // 
            TabControl1.Controls.Add(ArcTime);
            TabControl1.Controls.Add(LMTZT);
            TabControl1.Location = new Point(0, 5);
            TabControl1.Name = "TabControl1";
            TabControl1.SelectedIndex = 0;
            TabControl1.Size = new Size(463, 231);
            TabControl1.TabIndex = 103;
            // 
            // ArcTime
            // 
            ArcTime.Controls.Add(DTTime);
            ArcTime.Controls.Add(txtArcTime);
            ArcTime.Controls.Add(lblDeg);
            ArcTime.Controls.Add(lblArc);
            ArcTime.Controls.Add(Frame1);
            ArcTime.Controls.Add(_txtMin);
            ArcTime.Controls.Add(_txtDeg);
            ArcTime.Controls.Add(lblMin);
            ArcTime.Controls.Add(lblTime);
            ArcTime.Location = new Point(4, 22);
            ArcTime.Name = "ArcTime";
            ArcTime.Padding = new Padding(3);
            ArcTime.Size = new Size(455, 205);
            ArcTime.TabIndex = 0;
            ArcTime.Text = "Arc-Time";
            ArcTime.UseVisualStyleBackColor = true;
            // 
            // DTTime
            // 
            DTTime.CustomFormat = "HH:mm:ss";
            DTTime.Format = DateTimePickerFormat.Custom;
            DTTime.Location = new Point(198, 91);
            DTTime.Name = "DTTime";
            DTTime.ShowUpDown = true;
            DTTime.Size = new Size(79, 21);
            DTTime.TabIndex = 26;
            DTTime.Visible = false;
            // 
            // LMTZT
            // 
            LMTZT.Controls.Add(DTLMT);
            LMTZT.Controls.Add(txtLMTZT);
            LMTZT.Controls.Add(Label1);
            LMTZT.Controls.Add(lblLoDeg);
            LMTZT.Controls.Add(lblLoMin);
            LMTZT.Controls.Add(lblLMT);
            LMTZT.Controls.Add(lblZT);
            LMTZT.Controls.Add(_txtLoMin);
            LMTZT.Controls.Add(Frame2);
            LMTZT.Controls.Add(cboLo);
            LMTZT.Controls.Add(_txtLoDeg);
            LMTZT.Location = new Point(4, 22);
            LMTZT.Name = "LMTZT";
            LMTZT.Padding = new Padding(3);
            LMTZT.Size = new Size(455, 205);
            LMTZT.TabIndex = 1;
            LMTZT.Text = "LMT-ZT";
            LMTZT.UseVisualStyleBackColor = true;
            // 
            // DTLMT
            // 
            DTLMT.CustomFormat = "HH:mm:ss";
            DTLMT.Format = DateTimePickerFormat.Custom;
            DTLMT.Location = new Point(241, 96);
            DTLMT.Name = "DTLMT";
            DTLMT.ShowUpDown = true;
            DTLMT.Size = new Size(72, 21);
            DTLMT.TabIndex = 27;
            // 
            // FormArcTime
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(466, 323);
            Controls.Add(PictureBox1);
            Controls.Add(_ClearBtn);
            Controls.Add(_ExitBtn);
            Controls.Add(_cmdPrint);
            Controls.Add(_cmdConvert);
            Controls.Add(TabControl1);
            Cursor = Cursors.Default;
            Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(285, 99);
            MaximizeBox = false;
            Name = "FormArcTime";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Arc-Time, LMT-ZT Conversion";
            Frame2.ResumeLayout(false);
            Frame1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            TabControl1.ResumeLayout(false);
            ArcTime.ResumeLayout(false);
            ArcTime.PerformLayout();
            LMTZT.ResumeLayout(false);
            LMTZT.PerformLayout();
            Load += new EventHandler(FormArcTime_Load);
            FormClosed += new FormClosedEventHandler(FormArcTime_FormClosed);
            ResumeLayout(false);
        }

        internal TextBox txtArcTime;
        internal TextBox txtLMTZT;
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

        private Button _ClearBtn;

        public Button ClearBtn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ClearBtn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ClearBtn != null)
                {
                    _ClearBtn.Click -= ClearBtn_Click;
                }

                _ClearBtn = value;
                if (_ClearBtn != null)
                {
                    _ClearBtn.Click += ClearBtn_Click;
                }
            }
        }

        internal PictureBox PictureBox1;
        internal TabControl TabControl1;
        internal TabPage ArcTime;
        internal TabPage LMTZT;
        internal DateTimePicker DTTime;
        internal DateTimePicker DTLMT;
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}