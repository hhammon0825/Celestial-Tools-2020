using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    [DesignerGenerated()]
    internal partial class FormIandC
    {
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        [DebuggerNonUserCode()]
        public FormIandC() : base()
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

        private RadioButton _optBack;

        public RadioButton optBack
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optBack;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optBack != null)
                {
                    _optBack.CheckedChanged -= optBack_CheckedChanged;
                }

                _optBack = value;
                if (_optBack != null)
                {
                    _optBack.CheckedChanged += optBack_CheckedChanged;
                }
            }
        }

        private RadioButton _optFwd;

        public RadioButton optFwd
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optFwd;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optFwd != null)
                {
                    _optFwd.CheckedChanged -= optFwd_CheckedChanged;
                }

                _optFwd = value;
                if (_optFwd != null)
                {
                    _optFwd.CheckedChanged += optFwd_CheckedChanged;
                }
            }
        }

        public GroupBox frameFwdBack;
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

        private RadioButton _optMoon;

        public RadioButton optMoon
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optMoon;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optMoon != null)
                {
                    _optMoon.CheckedChanged -= optMoon_CheckedChanged;
                }

                _optMoon = value;
                if (_optMoon != null)
                {
                    _optMoon.CheckedChanged += optMoon_CheckedChanged;
                }
            }
        }

        private RadioButton _optAries;

        public RadioButton optAries
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optAries;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optAries != null)
                {
                    _optAries.CheckedChanged -= optAries_CheckedChanged;
                }

                _optAries = value;
                if (_optAries != null)
                {
                    _optAries.CheckedChanged += optAries_CheckedChanged;
                }
            }
        }

        private RadioButton _optSunPlanets;

        public RadioButton optSunPlanets
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optSunPlanets;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optSunPlanets != null)
                {
                    _optSunPlanets.CheckedChanged -= optSunPlanets_CheckedChanged;
                }

                _optSunPlanets = value;
                if (_optSunPlanets != null)
                {
                    _optSunPlanets.CheckedChanged += optSunPlanets_CheckedChanged;
                }
            }
        }

        public GroupBox frameSelect;
        private TextBox _txtv;

        public TextBox txtv
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtv;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtv != null)
                {
                    _txtv.TextChanged -= txtvd_TextChanged;
                    _txtv.KeyPress -= txtvd_KeyPress;
                    _txtv.Validating -= txtvd_Validating;
                    _txtv.Enter -= txtvd_Enter;
                }

                _txtv = value;
                if (_txtv != null)
                {
                    _txtv.TextChanged += txtvd_TextChanged;
                    _txtv.KeyPress += txtvd_KeyPress;
                    _txtv.Validating += txtvd_Validating;
                    _txtv.Enter += txtvd_Enter;
                }
            }
        }

        private TextBox _txtUTs;

        public TextBox txtUTs
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtUTs;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtUTs != null)
                {
                    _txtUTs.TextChanged -= txtUTs_TextChanged;
                    _txtUTs.KeyPress -= txtUTs_KeyPress;
                    _txtUTs.Validating -= txtUTs_Validating;
                    _txtUTs.Enter -= txtUTs_Enter;
                }

                _txtUTs = value;
                if (_txtUTs != null)
                {
                    _txtUTs.TextChanged += txtUTs_TextChanged;
                    _txtUTs.KeyPress += txtUTs_KeyPress;
                    _txtUTs.Validating += txtUTs_Validating;
                    _txtUTs.Enter += txtUTs_Enter;
                }
            }
        }

        private TextBox _txtUTm;

        public TextBox txtUTm
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtUTm;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtUTm != null)
                {
                    _txtUTm.TextChanged -= txtUTm_TextChanged;
                    _txtUTm.KeyPress -= txtUTm_KeyPress;
                    _txtUTm.Validating -= txtUTm_Validating;
                    _txtUTm.Enter -= txtUTm_Enter;
                }

                _txtUTm = value;
                if (_txtUTm != null)
                {
                    _txtUTm.TextChanged += txtUTm_TextChanged;
                    _txtUTm.KeyPress += txtUTm_KeyPress;
                    _txtUTm.Validating += txtUTm_Validating;
                    _txtUTm.Enter += txtUTm_Enter;
                }
            }
        }

        public Label Label8;
        public Label Label7;
        // Public WithEvents Line1 As Microsoft.VisualBasic.PowerPacks.LineShape
        public Label Label6;
        public Label Label4;
        public Label Label3;
        public Label Label2;
        // Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIandC));
            ToolTip1 = new ToolTip(components);
            _txtMin = new TextBox();
            _txtMin.TextChanged += new EventHandler(txtMin_TextChanged);
            _txtMin.KeyPress += new KeyPressEventHandler(txtMin_KeyPress);
            _txtMin.Validating += new System.ComponentModel.CancelEventHandler(txtMin_Validating);
            _txtMin.Enter += new EventHandler(txtMin_Enter);
            _txtDeg = new TextBox();
            _txtDeg.TextChanged += new EventHandler(txtDeg_TextChanged);
            _txtDeg.KeyPress += new KeyPressEventHandler(txtDeg_KeyPress);
            _txtDeg.Validating += new System.ComponentModel.CancelEventHandler(txtDeg_Validating);
            _txtDeg.Enter += new EventHandler(txtDeg_Enter);
            _cmdPrint = new Button();
            _cmdPrint.Click += new EventHandler(cmdPrint_Click);
            _txtv = new TextBox();
            _txtv.TextChanged += new EventHandler(txtvd_TextChanged);
            _txtv.KeyPress += new KeyPressEventHandler(txtvd_KeyPress);
            _txtv.Validating += new System.ComponentModel.CancelEventHandler(txtvd_Validating);
            _txtv.Enter += new EventHandler(txtvd_Enter);
            _txtUTs = new TextBox();
            _txtUTs.TextChanged += new EventHandler(txtUTs_TextChanged);
            _txtUTs.KeyPress += new KeyPressEventHandler(txtUTs_KeyPress);
            _txtUTs.Validating += new System.ComponentModel.CancelEventHandler(txtUTs_Validating);
            _txtUTs.Enter += new EventHandler(txtUTs_Enter);
            _txtUTm = new TextBox();
            _txtUTm.TextChanged += new EventHandler(txtUTm_TextChanged);
            _txtUTm.KeyPress += new KeyPressEventHandler(txtUTm_KeyPress);
            _txtUTm.Validating += new System.ComponentModel.CancelEventHandler(txtUTm_Validating);
            _txtUTm.Enter += new EventHandler(txtUTm_Enter);
            _txtd = new TextBox();
            _txtd.Enter += new EventHandler(txtd_Enter);
            _txtd.KeyPress += new KeyPressEventHandler(txtd_KeyPress);
            _txtd.TextChanged += new EventHandler(txtd_TextChanged);
            _txtd.Validating += new System.ComponentModel.CancelEventHandler(txtd_Validating);
            txtdcorr = new TextBox();
            txtvcorr = new TextBox();
            frameFwdBack = new GroupBox();
            _optBack = new RadioButton();
            _optBack.CheckedChanged += new EventHandler(optBack_CheckedChanged);
            _optFwd = new RadioButton();
            _optFwd.CheckedChanged += new EventHandler(optFwd_CheckedChanged);
            frameSelect = new GroupBox();
            _optMoon = new RadioButton();
            _optMoon.CheckedChanged += new EventHandler(optMoon_CheckedChanged);
            _optAries = new RadioButton();
            _optAries.CheckedChanged += new EventHandler(optAries_CheckedChanged);
            _optSunPlanets = new RadioButton();
            _optSunPlanets.CheckedChanged += new EventHandler(optSunPlanets_CheckedChanged);
            Label8 = new Label();
            Label7 = new Label();
            Label6 = new Label();
            Label4 = new Label();
            Label3 = new Label();
            Label2 = new Label();
            _ExitBtn = new Button();
            _ExitBtn.Click += new EventHandler(ExitBtn_Click);
            Label1 = new Label();
            Label9 = new Label();
            _btnCalculate = new Button();
            _btnCalculate.Click += new EventHandler(btnCalculate_Click);
            PictureBox1 = new PictureBox();
            Label10 = new Label();
            Label12 = new Label();
            Label5 = new Label();
            Label11 = new Label();
            Label13 = new Label();
            Label14 = new Label();
            _btnClearFields = new Button();
            _btnClearFields.Click += new EventHandler(btnClearFields_Click);
            txtdcorrx = new TextBox();
            txtvcorrx = new TextBox();
            frameFwdBack.SuspendLayout();
            frameSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtMin
            // 
            _txtMin.AcceptsReturn = true;
            _txtMin.BackColor = SystemColors.Window;
            _txtMin.Cursor = Cursors.IBeam;
            _txtMin.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtMin.ForeColor = SystemColors.WindowText;
            _txtMin.Location = new Point(153, 155);
            _txtMin.MaxLength = 4;
            _txtMin.Name = "_txtMin";
            _txtMin.RightToLeft = RightToLeft.No;
            _txtMin.Size = new Size(33, 20);
            _txtMin.TabIndex = 18;
            _txtMin.TextAlign = HorizontalAlignment.Center;
            ToolTip1.SetToolTip(_txtMin, "Range 0 to 59.9");
            // 
            // txtDeg
            // 
            _txtDeg.AcceptsReturn = true;
            _txtDeg.BackColor = SystemColors.Window;
            _txtDeg.Cursor = Cursors.IBeam;
            _txtDeg.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtDeg.ForeColor = SystemColors.WindowText;
            _txtDeg.Location = new Point(103, 155);
            _txtDeg.MaxLength = 2;
            _txtDeg.Name = "_txtDeg";
            _txtDeg.RightToLeft = RightToLeft.No;
            _txtDeg.Size = new Size(33, 20);
            _txtDeg.TabIndex = 17;
            _txtDeg.TextAlign = HorizontalAlignment.Center;
            ToolTip1.SetToolTip(_txtDeg, "Range 0 to 15 for Sun/Planets, Aries; 0 to 14 for Moon");
            // 
            // cmdPrint
            // 
            _cmdPrint.BackColor = SystemColors.Control;
            _cmdPrint.Cursor = Cursors.Default;
            _cmdPrint.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdPrint.ForeColor = SystemColors.ControlText;
            _cmdPrint.Image = (Image)resources.GetObject("cmdPrint.Image");
            _cmdPrint.Location = new Point(348, 5);
            _cmdPrint.Name = "_cmdPrint";
            _cmdPrint.RightToLeft = RightToLeft.No;
            _cmdPrint.Size = new Size(21, 21);
            _cmdPrint.TabIndex = 13;
            _cmdPrint.TextAlign = ContentAlignment.BottomCenter;
            ToolTip1.SetToolTip(_cmdPrint, "Print window");
            _cmdPrint.UseVisualStyleBackColor = false;
            // 
            // txtv
            // 
            _txtv.AcceptsReturn = true;
            _txtv.BackColor = SystemColors.Window;
            _txtv.Cursor = Cursors.IBeam;
            _txtv.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtv.ForeColor = SystemColors.WindowText;
            _txtv.Location = new Point(303, 98);
            _txtv.MaxLength = 4;
            _txtv.Name = "_txtv";
            _txtv.RightToLeft = RightToLeft.No;
            _txtv.Size = new Size(33, 20);
            _txtv.TabIndex = 8;
            _txtv.TextAlign = HorizontalAlignment.Center;
            ToolTip1.SetToolTip(_txtv, "Range 0 to 18.0");
            // 
            // txtUTs
            // 
            _txtUTs.AcceptsReturn = true;
            _txtUTs.BackColor = SystemColors.Window;
            _txtUTs.Cursor = Cursors.IBeam;
            _txtUTs.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtUTs.ForeColor = SystemColors.WindowText;
            _txtUTs.Location = new Point(153, 96);
            _txtUTs.MaxLength = 2;
            _txtUTs.Name = "_txtUTs";
            _txtUTs.RightToLeft = RightToLeft.No;
            _txtUTs.Size = new Size(33, 20);
            _txtUTs.TabIndex = 7;
            _txtUTs.TextAlign = HorizontalAlignment.Center;
            ToolTip1.SetToolTip(_txtUTs, "Range 0 to 60");
            // 
            // txtUTm
            // 
            _txtUTm.AcceptsReturn = true;
            _txtUTm.BackColor = SystemColors.Window;
            _txtUTm.Cursor = Cursors.IBeam;
            _txtUTm.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtUTm.ForeColor = SystemColors.WindowText;
            _txtUTm.Location = new Point(101, 96);
            _txtUTm.MaxLength = 2;
            _txtUTm.Name = "_txtUTm";
            _txtUTm.RightToLeft = RightToLeft.No;
            _txtUTm.Size = new Size(33, 20);
            _txtUTm.TabIndex = 6;
            _txtUTm.TextAlign = HorizontalAlignment.Center;
            ToolTip1.SetToolTip(_txtUTm, "Range 0 to 59");
            // 
            // txtd
            // 
            _txtd.AcceptsReturn = true;
            _txtd.BackColor = SystemColors.Window;
            _txtd.Cursor = Cursors.IBeam;
            _txtd.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtd.ForeColor = SystemColors.WindowText;
            _txtd.Location = new Point(303, 124);
            _txtd.MaxLength = 4;
            _txtd.Name = "_txtd";
            _txtd.RightToLeft = RightToLeft.No;
            _txtd.Size = new Size(33, 20);
            _txtd.TabIndex = 9;
            _txtd.TextAlign = HorizontalAlignment.Center;
            ToolTip1.SetToolTip(_txtd, "Range 0 to 18.0");
            // 
            // txtdcorr
            // 
            txtdcorr.AcceptsReturn = true;
            txtdcorr.BackColor = SystemColors.Window;
            txtdcorr.Cursor = Cursors.IBeam;
            txtdcorr.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            txtdcorr.ForeColor = SystemColors.WindowText;
            txtdcorr.Location = new Point(264, 180);
            txtdcorr.MaxLength = 4;
            txtdcorr.Name = "txtdcorr";
            txtdcorr.RightToLeft = RightToLeft.No;
            txtdcorr.Size = new Size(33, 20);
            txtdcorr.TabIndex = 21;
            txtdcorr.TextAlign = HorizontalAlignment.Center;
            ToolTip1.SetToolTip(txtdcorr, "Range 0 to 18.0");
            // 
            // txtvcorr
            // 
            txtvcorr.AcceptsReturn = true;
            txtvcorr.BackColor = SystemColors.Window;
            txtvcorr.Cursor = Cursors.IBeam;
            txtvcorr.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            txtvcorr.ForeColor = SystemColors.WindowText;
            txtvcorr.Location = new Point(264, 154);
            txtvcorr.MaxLength = 4;
            txtvcorr.Name = "txtvcorr";
            txtvcorr.RightToLeft = RightToLeft.No;
            txtvcorr.Size = new Size(33, 20);
            txtvcorr.TabIndex = 20;
            txtvcorr.TextAlign = HorizontalAlignment.Center;
            ToolTip1.SetToolTip(txtvcorr, "Range 0 to 18.0");
            // 
            // frameFwdBack
            // 
            frameFwdBack.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            frameFwdBack.Controls.Add(_optBack);
            frameFwdBack.Controls.Add(_optFwd);
            frameFwdBack.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            frameFwdBack.ForeColor = SystemColors.ControlText;
            frameFwdBack.Location = new Point(30, 5);
            frameFwdBack.Name = "frameFwdBack";
            frameFwdBack.Padding = new Padding(0);
            frameFwdBack.RightToLeft = RightToLeft.No;
            frameFwdBack.Size = new Size(306, 40);
            frameFwdBack.TabIndex = 14;
            frameFwdBack.TabStop = false;
            frameFwdBack.Text = "Select Table Direction";
            // 
            // optBack
            // 
            _optBack.BackColor = SystemColors.Window;
            _optBack.Cursor = Cursors.Default;
            _optBack.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optBack.ForeColor = SystemColors.ControlText;
            _optBack.Location = new Point(177, 16);
            _optBack.Name = "_optBack";
            _optBack.RightToLeft = RightToLeft.No;
            _optBack.Size = new Size(119, 18);
            _optBack.TabIndex = 16;
            _optBack.TabStop = true;
            _optBack.Text = "GHA Incr to UT Incr";
            _optBack.UseVisualStyleBackColor = false;
            // 
            // optFwd
            // 
            _optFwd.BackColor = SystemColors.Window;
            _optFwd.Checked = true;
            _optFwd.Cursor = Cursors.Default;
            _optFwd.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optFwd.ForeColor = SystemColors.ControlText;
            _optFwd.Location = new Point(46, 16);
            _optFwd.Name = "_optFwd";
            _optFwd.RightToLeft = RightToLeft.No;
            _optFwd.Size = new Size(125, 18);
            _optFwd.TabIndex = 15;
            _optFwd.TabStop = true;
            _optFwd.Text = "UT  Incr to GHA Incr";
            _optFwd.UseVisualStyleBackColor = false;
            // 
            // frameSelect
            // 
            frameSelect.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            frameSelect.Controls.Add(_optMoon);
            frameSelect.Controls.Add(_optAries);
            frameSelect.Controls.Add(_optSunPlanets);
            frameSelect.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            frameSelect.ForeColor = SystemColors.ControlText;
            frameSelect.Location = new Point(30, 52);
            frameSelect.Name = "frameSelect";
            frameSelect.Padding = new Padding(0);
            frameSelect.RightToLeft = RightToLeft.No;
            frameSelect.Size = new Size(306, 40);
            frameSelect.TabIndex = 9;
            frameSelect.TabStop = false;
            frameSelect.Text = "Select object";
            // 
            // optMoon
            // 
            _optMoon.BackColor = SystemColors.Window;
            _optMoon.Cursor = Cursors.Default;
            _optMoon.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optMoon.ForeColor = SystemColors.ControlText;
            _optMoon.Location = new Point(229, 15);
            _optMoon.Name = "_optMoon";
            _optMoon.RightToLeft = RightToLeft.No;
            _optMoon.Size = new Size(65, 17);
            _optMoon.TabIndex = 12;
            _optMoon.Text = "Moon";
            _optMoon.UseVisualStyleBackColor = false;
            // 
            // optAries
            // 
            _optAries.BackColor = SystemColors.Window;
            _optAries.Cursor = Cursors.Default;
            _optAries.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optAries.ForeColor = SystemColors.ControlText;
            _optAries.Location = new Point(149, 15);
            _optAries.Name = "_optAries";
            _optAries.RightToLeft = RightToLeft.No;
            _optAries.Size = new Size(65, 17);
            _optAries.TabIndex = 11;
            _optAries.Text = "Aries";
            _optAries.UseVisualStyleBackColor = false;
            // 
            // optSunPlanets
            // 
            _optSunPlanets.BackColor = SystemColors.Window;
            _optSunPlanets.Checked = true;
            _optSunPlanets.Cursor = Cursors.Default;
            _optSunPlanets.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optSunPlanets.ForeColor = SystemColors.ControlText;
            _optSunPlanets.Location = new Point(47, 15);
            _optSunPlanets.Name = "_optSunPlanets";
            _optSunPlanets.RightToLeft = RightToLeft.No;
            _optSunPlanets.Size = new Size(81, 17);
            _optSunPlanets.TabIndex = 10;
            _optSunPlanets.TabStop = true;
            _optSunPlanets.Text = "Sun/Planets";
            _optSunPlanets.UseVisualStyleBackColor = false;
            // 
            // Label8
            // 
            Label8.BackColor = SystemColors.Window;
            Label8.Cursor = Cursors.Default;
            Label8.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label8.ForeColor = SystemColors.ControlText;
            Label8.Location = new Point(187, 157);
            Label8.Name = "Label8";
            Label8.RightToLeft = RightToLeft.No;
            Label8.Size = new Size(12, 17);
            Label8.TabIndex = 20;
            Label8.Text = "'";
            // 
            // Label7
            // 
            Label7.BackColor = SystemColors.Window;
            Label7.Cursor = Cursors.Default;
            Label7.Font = new Font("Symbol", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(2));
            Label7.ForeColor = SystemColors.ControlText;
            Label7.Location = new Point(137, 156);
            Label7.Name = "Label7";
            Label7.RightToLeft = RightToLeft.No;
            Label7.Size = new Size(9, 17);
            Label7.TabIndex = 19;
            Label7.Text = "°";
            // 
            // Label6
            // 
            Label6.BackColor = SystemColors.Window;
            Label6.Cursor = Cursors.Default;
            Label6.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label6.ForeColor = SystemColors.ControlText;
            Label6.Location = new Point(337, 98);
            Label6.Name = "Label6";
            Label6.RightToLeft = RightToLeft.No;
            Label6.Size = new Size(9, 17);
            Label6.TabIndex = 5;
            Label6.Text = "'";
            // 
            // Label4
            // 
            Label4.BackColor = SystemColors.Window;
            Label4.Cursor = Cursors.Default;
            Label4.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.ForeColor = SystemColors.ControlText;
            Label4.Location = new Point(205, 97);
            Label4.Name = "Label4";
            Label4.RightToLeft = RightToLeft.No;
            Label4.Size = new Size(95, 19);
            Label4.TabIndex = 3;
            Label4.Text = "v from daily page";
            Label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label3
            // 
            Label3.BackColor = SystemColors.Window;
            Label3.Cursor = Cursors.Default;
            Label3.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.ForeColor = SystemColors.ControlText;
            Label3.Location = new Point(187, 98);
            Label3.Name = "Label3";
            Label3.RightToLeft = RightToLeft.No;
            Label3.Size = new Size(9, 17);
            Label3.TabIndex = 2;
            Label3.Text = "s";
            // 
            // Label2
            // 
            Label2.BackColor = SystemColors.Window;
            Label2.Cursor = Cursors.Default;
            Label2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = SystemColors.ControlText;
            Label2.Location = new Point(134, 98);
            Label2.Name = "Label2";
            Label2.RightToLeft = RightToLeft.No;
            Label2.Size = new Size(12, 17);
            Label2.TabIndex = 1;
            Label2.Text = "m";
            // 
            // ExitBtn
            // 
            _ExitBtn.BackColor = Color.Crimson;
            _ExitBtn.ForeColor = SystemColors.ControlLightLight;
            _ExitBtn.Location = new Point(284, 277);
            _ExitBtn.Name = "_ExitBtn";
            _ExitBtn.Size = new Size(62, 23);
            _ExitBtn.TabIndex = 24;
            _ExitBtn.Text = "Exit";
            _ExitBtn.UseVisualStyleBackColor = false;
            // 
            // Label1
            // 
            Label1.BackColor = SystemColors.Window;
            Label1.Cursor = Cursors.Default;
            Label1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = SystemColors.ControlText;
            Label1.Location = new Point(24, 97);
            Label1.Name = "Label1";
            Label1.RightToLeft = RightToLeft.No;
            Label1.Size = new Size(75, 19);
            Label1.TabIndex = 0;
            Label1.Text = "UT Increment";
            Label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label9
            // 
            Label9.BackColor = SystemColors.Window;
            Label9.Cursor = Cursors.Default;
            Label9.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label9.ForeColor = SystemColors.ControlText;
            Label9.Location = new Point(23, 152);
            Label9.Name = "Label9";
            Label9.RightToLeft = RightToLeft.No;
            Label9.Size = new Size(82, 25);
            Label9.TabIndex = 21;
            Label9.Text = "GHA Increment";
            Label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCalculate
            // 
            _btnCalculate.BackColor = SystemColors.MenuHighlight;
            _btnCalculate.ForeColor = SystemColors.ControlLightLight;
            _btnCalculate.Location = new Point(153, 277);
            _btnCalculate.Name = "_btnCalculate";
            _btnCalculate.Size = new Size(75, 23);
            _btnCalculate.TabIndex = 25;
            _btnCalculate.Text = "Calculate";
            _btnCalculate.UseVisualStyleBackColor = false;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.ABC_white;
            PictureBox1.Location = new Point(26, 306);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(320, 50);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 102;
            PictureBox1.TabStop = false;
            // 
            // Label10
            // 
            Label10.BackColor = SystemColors.Window;
            Label10.Cursor = Cursors.Default;
            Label10.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label10.ForeColor = SystemColors.ControlText;
            Label10.Location = new Point(337, 124);
            Label10.Name = "Label10";
            Label10.RightToLeft = RightToLeft.No;
            Label10.Size = new Size(9, 17);
            Label10.TabIndex = 105;
            Label10.Text = "'";
            // 
            // Label12
            // 
            Label12.BackColor = SystemColors.Window;
            Label12.Cursor = Cursors.Default;
            Label12.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label12.ForeColor = SystemColors.ControlText;
            Label12.Location = new Point(205, 124);
            Label12.Name = "Label12";
            Label12.RightToLeft = RightToLeft.No;
            Label12.Size = new Size(95, 19);
            Label12.TabIndex = 103;
            Label12.Text = "d from daily page";
            Label12.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label5
            // 
            Label5.BackColor = SystemColors.Window;
            Label5.Cursor = Cursors.Default;
            Label5.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label5.ForeColor = SystemColors.ControlText;
            Label5.Location = new Point(298, 180);
            Label5.Name = "Label5";
            Label5.RightToLeft = RightToLeft.No;
            Label5.Size = new Size(9, 17);
            Label5.TabIndex = 111;
            Label5.Text = "'";
            // 
            // Label11
            // 
            Label11.BackColor = SystemColors.Window;
            Label11.Cursor = Cursors.Default;
            Label11.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label11.ForeColor = SystemColors.ControlText;
            Label11.Location = new Point(211, 180);
            Label11.Name = "Label11";
            Label11.RightToLeft = RightToLeft.No;
            Label11.Size = new Size(46, 19);
            Label11.TabIndex = 110;
            Label11.Text = "d corr";
            Label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label13
            // 
            Label13.BackColor = SystemColors.Window;
            Label13.Cursor = Cursors.Default;
            Label13.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label13.ForeColor = SystemColors.ControlText;
            Label13.Location = new Point(298, 154);
            Label13.Name = "Label13";
            Label13.RightToLeft = RightToLeft.No;
            Label13.Size = new Size(9, 17);
            Label13.TabIndex = 108;
            Label13.Text = "'";
            // 
            // Label14
            // 
            Label14.BackColor = SystemColors.Window;
            Label14.Cursor = Cursors.Default;
            Label14.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label14.ForeColor = SystemColors.ControlText;
            Label14.Location = new Point(211, 154);
            Label14.Name = "Label14";
            Label14.RightToLeft = RightToLeft.No;
            Label14.Size = new Size(49, 19);
            Label14.TabIndex = 107;
            Label14.Text = "v corr";
            Label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnClearFields
            // 
            _btnClearFields.BackColor = SystemColors.MenuHighlight;
            _btnClearFields.ForeColor = SystemColors.ControlLightLight;
            _btnClearFields.Location = new Point(26, 277);
            _btnClearFields.Name = "_btnClearFields";
            _btnClearFields.Size = new Size(83, 23);
            _btnClearFields.TabIndex = 113;
            _btnClearFields.Text = "Clear Fields";
            _btnClearFields.UseVisualStyleBackColor = false;
            // 
            // txtdcorrx
            // 
            txtdcorrx.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtdcorrx.Location = new Point(77, 235);
            txtdcorrx.Name = "txtdcorrx";
            txtdcorrx.ReadOnly = true;
            txtdcorrx.Size = new Size(259, 20);
            txtdcorrx.TabIndex = 115;
            txtdcorrx.TextAlign = HorizontalAlignment.Center;
            txtdcorrx.Visible = false;
            // 
            // txtvcorrx
            // 
            txtvcorrx.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtvcorrx.Location = new Point(77, 209);
            txtvcorrx.Name = "txtvcorrx";
            txtvcorrx.ReadOnly = true;
            txtvcorrx.Size = new Size(259, 20);
            txtvcorrx.TabIndex = 114;
            txtvcorrx.TextAlign = HorizontalAlignment.Center;
            txtvcorrx.Visible = false;
            // 
            // FormIandC
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(381, 364);
            Controls.Add(txtdcorrx);
            Controls.Add(txtvcorrx);
            Controls.Add(_btnClearFields);
            Controls.Add(txtdcorr);
            Controls.Add(Label5);
            Controls.Add(Label11);
            Controls.Add(txtvcorr);
            Controls.Add(Label13);
            Controls.Add(Label14);
            Controls.Add(_txtd);
            Controls.Add(Label10);
            Controls.Add(Label12);
            Controls.Add(PictureBox1);
            Controls.Add(_btnCalculate);
            Controls.Add(_ExitBtn);
            Controls.Add(_txtMin);
            Controls.Add(_txtDeg);
            Controls.Add(frameFwdBack);
            Controls.Add(_cmdPrint);
            Controls.Add(frameSelect);
            Controls.Add(_txtv);
            Controls.Add(_txtUTs);
            Controls.Add(_txtUTm);
            Controls.Add(Label9);
            Controls.Add(Label8);
            Controls.Add(Label7);
            Controls.Add(Label6);
            Controls.Add(Label4);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Cursor = Cursors.Default;
            Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(3, 29);
            MaximizeBox = false;
            Name = "FormIandC";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Increments and Corrections";
            frameFwdBack.ResumeLayout(false);
            frameSelect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Activated += new EventHandler(FormIandC_Activated);
            FormClosed += new FormClosedEventHandler(FormIandC_FormClosed);
            ResumeLayout(false);
            PerformLayout();
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

        public Label Label1;
        public Label Label9;
        private Button _btnCalculate;

        internal Button btnCalculate
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnCalculate;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnCalculate != null)
                {
                    _btnCalculate.Click -= btnCalculate_Click;
                }

                _btnCalculate = value;
                if (_btnCalculate != null)
                {
                    _btnCalculate.Click += btnCalculate_Click;
                }
            }
        }

        internal PictureBox PictureBox1;
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
                    _txtd.Enter -= txtd_Enter;
                    _txtd.KeyPress -= txtd_KeyPress;
                    _txtd.TextChanged -= txtd_TextChanged;
                    _txtd.Validating -= txtd_Validating;
                }

                _txtd = value;
                if (_txtd != null)
                {
                    _txtd.Enter += txtd_Enter;
                    _txtd.KeyPress += txtd_KeyPress;
                    _txtd.TextChanged += txtd_TextChanged;
                    _txtd.Validating += txtd_Validating;
                }
            }
        }

        public Label Label10;
        public Label Label12;
        public TextBox txtdcorr;
        public Label Label5;
        public Label Label11;
        public TextBox txtvcorr;
        public Label Label13;
        public Label Label14;
        private Button _btnClearFields;

        internal Button btnClearFields
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnClearFields;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnClearFields != null)
                {
                    _btnClearFields.Click -= btnClearFields_Click;
                }

                _btnClearFields = value;
                if (_btnClearFields != null)
                {
                    _btnClearFields.Click += btnClearFields_Click;
                }
            }
        }

        internal TextBox txtdcorrx;
        internal TextBox txtvcorrx;
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}