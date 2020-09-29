using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    [DesignerGenerated()]
    internal partial class FormCTSSOA
    {
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        [DebuggerNonUserCode()]
        public FormCTSSOA() : base()
        {
            // This is required by the Windows Form Designer.
            InitializeComponent();
            Form_Initialize_Renamed();
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
        private RadioButton _optCMGSMG;

        public RadioButton optCMGSMG
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optCMGSMG;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optCMGSMG != null)
                {
                    _optCMGSMG.CheckedChanged -= optCMGSMG_CheckedChanged;
                }

                _optCMGSMG = value;
                if (_optCMGSMG != null)
                {
                    _optCMGSMG.CheckedChanged += optCMGSMG_CheckedChanged;
                }
            }
        }

        private RadioButton _optCTSSOA;

        public RadioButton optCTSSOA
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optCTSSOA;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optCTSSOA != null)
                {
                    _optCTSSOA.CheckedChanged -= optCTSSOA_CheckedChanged;
                }

                _optCTSSOA = value;
                if (_optCTSSOA != null)
                {
                    _optCTSSOA.CheckedChanged += optCTSSOA_CheckedChanged;
                }
            }
        }

        public Label Label15;
        public GroupBox Frame1;
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

        public ComboBox cboWind;
        private TextBox _txtDriftAngle;

        public TextBox txtDriftAngle
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtDriftAngle;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtDriftAngle != null)
                {
                    _txtDriftAngle.TextChanged -= txtDriftAngle_TextChanged;
                    _txtDriftAngle.KeyPress -= txtDriftAngle_KeyPress;
                    _txtDriftAngle.Validating -= txtDriftAngle_Validating;
                    _txtDriftAngle.Enter -= txtDriftAngle_Enter;
                }

                _txtDriftAngle = value;
                if (_txtDriftAngle != null)
                {
                    _txtDriftAngle.TextChanged += txtDriftAngle_TextChanged;
                    _txtDriftAngle.KeyPress += txtDriftAngle_KeyPress;
                    _txtDriftAngle.Validating += txtDriftAngle_Validating;
                    _txtDriftAngle.Enter += txtDriftAngle_Enter;
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

        private Button _cmdCalculate;

        public Button cmdCalculate
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdCalculate;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdCalculate != null)
                {
                    _cmdCalculate.Click -= cmdCalculate_Click;
                }

                _cmdCalculate = value;
                if (_cmdCalculate != null)
                {
                    _cmdCalculate.Click += cmdCalculate_Click;
                }
            }
        }

        private TextBox _txtDrift;

        public TextBox txtDrift
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtDrift;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtDrift != null)
                {
                    _txtDrift.TextChanged -= txtDrift_TextChanged;
                    _txtDrift.KeyPress -= txtDrift_KeyPress;
                    _txtDrift.Validating -= txtDrift_Validating;
                    _txtDrift.Enter -= txtDrift_Enter;
                }

                _txtDrift = value;
                if (_txtDrift != null)
                {
                    _txtDrift.TextChanged += txtDrift_TextChanged;
                    _txtDrift.KeyPress += txtDrift_KeyPress;
                    _txtDrift.Validating += txtDrift_Validating;
                    _txtDrift.Enter += txtDrift_Enter;
                }
            }
        }

        private TextBox _txtSet;

        public TextBox txtSet
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtSet;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtSet != null)
                {
                    _txtSet.TextChanged -= txtSet_TextChanged;
                    _txtSet.KeyPress -= txtSet_KeyPress;
                    _txtSet.Validating -= txtSet_Validating;
                    _txtSet.Enter -= txtSet_Enter;
                }

                _txtSet = value;
                if (_txtSet != null)
                {
                    _txtSet.TextChanged += txtSet_TextChanged;
                    _txtSet.KeyPress += txtSet_KeyPress;
                    _txtSet.Validating += txtSet_Validating;
                    _txtSet.Enter += txtSet_Enter;
                }
            }
        }

        private TextBox _txtCS;

        public TextBox txtCS
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtCS;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtCS != null)
                {
                    _txtCS.TextChanged -= txtCS_TextChanged;
                    _txtCS.KeyPress -= txtCS_KeyPress;
                    _txtCS.Validating -= txtCS_Validating;
                    _txtCS.Enter -= txtCS_Enter;
                }

                _txtCS = value;
                if (_txtCS != null)
                {
                    _txtCS.TextChanged += txtCS_TextChanged;
                    _txtCS.KeyPress += txtCS_KeyPress;
                    _txtCS.Validating += txtCS_Validating;
                    _txtCS.Enter += txtCS_Enter;
                }
            }
        }

        private TextBox _txtDC;

        public TextBox txtDC
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtDC;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtDC != null)
                {
                    _txtDC.TextChanged -= txtDC_TextChanged;
                    _txtDC.KeyPress -= txtDC_KeyPress;
                    _txtDC.Validating -= txtDC_Validating;
                    _txtDC.Enter -= txtDC_Enter;
                }

                _txtDC = value;
                if (_txtDC != null)
                {
                    _txtDC.TextChanged += txtDC_TextChanged;
                    _txtDC.KeyPress += txtDC_KeyPress;
                    _txtDC.Validating += txtDC_Validating;
                    _txtDC.Enter += txtDC_Enter;
                }
            }
        }

        public Label Label14;
        public Label Label1;
        public Label Label13;
        public Label Label10;
        public Label Label9;
        // Public WithEvents Line4 As Microsoft.VisualBasic.PowerPacks.LineShape
        public Label Label8;
        // Public WithEvents Line3 As Microsoft.VisualBasic.PowerPacks.LineShape
        public Label Label12;
        public Label Label11;
        public Label lblST;
        public Label lblDCT;
        public Label Label7;
        public Label Label6;
        public Label Label5;
        public Label Label4;
        // Public WithEvents Line2 As Microsoft.VisualBasic.PowerPacks.LineShape
        // Public WithEvents Line1 As Microsoft.VisualBasic.PowerPacks.LineShape
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCTSSOA));
            ToolTip1 = new ToolTip(components);
            cboWind = new ComboBox();
            _txtDriftAngle = new TextBox();
            _txtDriftAngle.TextChanged += new EventHandler(txtDriftAngle_TextChanged);
            _txtDriftAngle.KeyPress += new KeyPressEventHandler(txtDriftAngle_KeyPress);
            _txtDriftAngle.Validating += new System.ComponentModel.CancelEventHandler(txtDriftAngle_Validating);
            _txtDriftAngle.Enter += new EventHandler(txtDriftAngle_Enter);
            _cmdPrint = new Button();
            _cmdPrint.Click += new EventHandler(cmdPrint_Click);
            _txtDrift = new TextBox();
            _txtDrift.TextChanged += new EventHandler(txtDrift_TextChanged);
            _txtDrift.KeyPress += new KeyPressEventHandler(txtDrift_KeyPress);
            _txtDrift.Validating += new System.ComponentModel.CancelEventHandler(txtDrift_Validating);
            _txtDrift.Enter += new EventHandler(txtDrift_Enter);
            _txtSet = new TextBox();
            _txtSet.TextChanged += new EventHandler(txtSet_TextChanged);
            _txtSet.KeyPress += new KeyPressEventHandler(txtSet_KeyPress);
            _txtSet.Validating += new System.ComponentModel.CancelEventHandler(txtSet_Validating);
            _txtSet.Enter += new EventHandler(txtSet_Enter);
            _txtCS = new TextBox();
            _txtCS.TextChanged += new EventHandler(txtCS_TextChanged);
            _txtCS.KeyPress += new KeyPressEventHandler(txtCS_KeyPress);
            _txtCS.Validating += new System.ComponentModel.CancelEventHandler(txtCS_Validating);
            _txtCS.Enter += new EventHandler(txtCS_Enter);
            _txtDC = new TextBox();
            _txtDC.TextChanged += new EventHandler(txtDC_TextChanged);
            _txtDC.KeyPress += new KeyPressEventHandler(txtDC_KeyPress);
            _txtDC.Validating += new System.ComponentModel.CancelEventHandler(txtDC_Validating);
            _txtDC.Enter += new EventHandler(txtDC_Enter);
            Frame1 = new GroupBox();
            _optCMGSMG = new RadioButton();
            _optCMGSMG.CheckedChanged += new EventHandler(optCMGSMG_CheckedChanged);
            _optCTSSOA = new RadioButton();
            _optCTSSOA.CheckedChanged += new EventHandler(optCTSSOA_CheckedChanged);
            Label15 = new Label();
            _cmdClear = new Button();
            _cmdClear.Click += new EventHandler(cmdClear_Click);
            _cmdCalculate = new Button();
            _cmdCalculate.Click += new EventHandler(cmdCalculate_Click);
            Label14 = new Label();
            Label1 = new Label();
            Label13 = new Label();
            Label10 = new Label();
            Label9 = new Label();
            Label8 = new Label();
            Label12 = new Label();
            Label11 = new Label();
            lblST = new Label();
            lblDCT = new Label();
            Label7 = new Label();
            Label6 = new Label();
            Label5 = new Label();
            Label4 = new Label();
            Label3 = new Label();
            Label2 = new Label();
            _btnExit = new Button();
            _btnExit.Click += new EventHandler(btnExit_Click);
            txtWindCurrent = new TextBox();
            PictureBox1 = new PictureBox();
            Frame1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cboWind
            // 
            cboWind.BackColor = SystemColors.Window;
            cboWind.Cursor = Cursors.Default;
            cboWind.DropDownStyle = ComboBoxStyle.DropDownList;
            cboWind.Enabled = false;
            cboWind.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboWind.ForeColor = SystemColors.WindowText;
            cboWind.Items.AddRange(new object[] { "Port", "Starboard", "N", "NE", "E", "SE", "S", "SW", "W", "NW" });
            cboWind.Location = new Point(408, 112);
            cboWind.Name = "cboWind";
            cboWind.RightToLeft = RightToLeft.No;
            cboWind.Size = new Size(73, 22);
            cboWind.TabIndex = 7;
            ToolTip1.SetToolTip(cboWind, "If wind is nearly on the bow or stern, use Port or Starboard.");
            // 
            // txtDriftAngle
            // 
            _txtDriftAngle.AcceptsReturn = true;
            _txtDriftAngle.BackColor = SystemColors.Window;
            _txtDriftAngle.Cursor = Cursors.IBeam;
            _txtDriftAngle.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtDriftAngle.ForeColor = SystemColors.WindowText;
            _txtDriftAngle.Location = new Point(408, 88);
            _txtDriftAngle.MaxLength = 3;
            _txtDriftAngle.Name = "_txtDriftAngle";
            _txtDriftAngle.RightToLeft = RightToLeft.No;
            _txtDriftAngle.Size = new Size(25, 20);
            _txtDriftAngle.TabIndex = 6;
            ToolTip1.SetToolTip(_txtDriftAngle, "Range 0 to 90");
            // 
            // cmdPrint
            // 
            _cmdPrint.BackColor = SystemColors.Control;
            _cmdPrint.Cursor = Cursors.Default;
            _cmdPrint.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdPrint.ForeColor = SystemColors.ControlText;
            _cmdPrint.Image = (Image)resources.GetObject("cmdPrint.Image");
            _cmdPrint.Location = new Point(474, 2);
            _cmdPrint.Name = "_cmdPrint";
            _cmdPrint.RightToLeft = RightToLeft.No;
            _cmdPrint.Size = new Size(21, 21);
            _cmdPrint.TabIndex = 10;
            _cmdPrint.TextAlign = ContentAlignment.BottomCenter;
            ToolTip1.SetToolTip(_cmdPrint, "Print window");
            _cmdPrint.UseVisualStyleBackColor = false;
            // 
            // txtDrift
            // 
            _txtDrift.AcceptsReturn = true;
            _txtDrift.BackColor = SystemColors.Window;
            _txtDrift.Cursor = Cursors.IBeam;
            _txtDrift.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtDrift.ForeColor = SystemColors.WindowText;
            _txtDrift.Location = new Point(248, 112);
            _txtDrift.MaxLength = 4;
            _txtDrift.Name = "_txtDrift";
            _txtDrift.RightToLeft = RightToLeft.No;
            _txtDrift.Size = new Size(41, 20);
            _txtDrift.TabIndex = 5;
            ToolTip1.SetToolTip(_txtDrift, "Range 0 to 99.9");
            // 
            // txtSet
            // 
            _txtSet.AcceptsReturn = true;
            _txtSet.BackColor = SystemColors.Window;
            _txtSet.Cursor = Cursors.IBeam;
            _txtSet.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtSet.ForeColor = SystemColors.WindowText;
            _txtSet.Location = new Point(248, 88);
            _txtSet.MaxLength = 4;
            _txtSet.Name = "_txtSet";
            _txtSet.RightToLeft = RightToLeft.No;
            _txtSet.Size = new Size(41, 20);
            _txtSet.TabIndex = 4;
            ToolTip1.SetToolTip(_txtSet, "Range 0 to 359");
            // 
            // txtCS
            // 
            _txtCS.AcceptsReturn = true;
            _txtCS.BackColor = SystemColors.Window;
            _txtCS.Cursor = Cursors.IBeam;
            _txtCS.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtCS.ForeColor = SystemColors.WindowText;
            _txtCS.Location = new Point(104, 112);
            _txtCS.MaxLength = 4;
            _txtCS.Name = "_txtCS";
            _txtCS.RightToLeft = RightToLeft.No;
            _txtCS.Size = new Size(33, 20);
            _txtCS.TabIndex = 3;
            ToolTip1.SetToolTip(_txtCS, "Range 0.1 to 99.9");
            // 
            // txtDC
            // 
            _txtDC.AcceptsReturn = true;
            _txtDC.BackColor = SystemColors.Window;
            _txtDC.Cursor = Cursors.IBeam;
            _txtDC.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtDC.ForeColor = SystemColors.WindowText;
            _txtDC.Location = new Point(104, 88);
            _txtDC.MaxLength = 3;
            _txtDC.Name = "_txtDC";
            _txtDC.RightToLeft = RightToLeft.No;
            _txtDC.Size = new Size(33, 20);
            _txtDC.TabIndex = 2;
            ToolTip1.SetToolTip(_txtDC, "Range 0 to 359");
            // 
            // Frame1
            // 
            Frame1.BackColor = SystemColors.Window;
            Frame1.Controls.Add(_optCMGSMG);
            Frame1.Controls.Add(_optCTSSOA);
            Frame1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Frame1.ForeColor = SystemColors.ControlText;
            Frame1.Location = new Point(4, 0);
            Frame1.Name = "Frame1";
            Frame1.Padding = new Padding(0);
            Frame1.RightToLeft = RightToLeft.No;
            Frame1.Size = new Size(371, 61);
            Frame1.TabIndex = 25;
            Frame1.TabStop = false;
            Frame1.Text = "Determine";
            // 
            // optCMGSMG
            // 
            _optCMGSMG.BackColor = SystemColors.Window;
            _optCMGSMG.Cursor = Cursors.Default;
            _optCMGSMG.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optCMGSMG.ForeColor = SystemColors.ControlText;
            _optCMGSMG.Location = new Point(65, 32);
            _optCMGSMG.Name = "_optCMGSMG";
            _optCMGSMG.RightToLeft = RightToLeft.No;
            _optCMGSMG.Size = new Size(303, 25);
            _optCMGSMG.TabIndex = 1;
            _optCMGSMG.TabStop = true;
            _optCMGSMG.Text = "Course Made Good (CMG) and Speed Made Good (SMG)";
            _optCMGSMG.UseVisualStyleBackColor = false;
            // 
            // optCTSSOA
            // 
            _optCTSSOA.BackColor = SystemColors.Window;
            _optCTSSOA.Checked = true;
            _optCTSSOA.Cursor = Cursors.Default;
            _optCTSSOA.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optCTSSOA.ForeColor = SystemColors.ControlText;
            _optCTSSOA.Location = new Point(65, 8);
            _optCTSSOA.Name = "_optCTSSOA";
            _optCTSSOA.RightToLeft = RightToLeft.No;
            _optCTSSOA.Size = new Size(303, 25);
            _optCTSSOA.TabIndex = 0;
            _optCTSSOA.TabStop = true;
            _optCTSSOA.Text = "Course to Steer (CTS) and Speed of Advance (SOA)";
            _optCTSSOA.UseVisualStyleBackColor = false;
            // 
            // Label15
            // 
            Label15.BackColor = SystemColors.Window;
            Label15.Cursor = Cursors.Default;
            Label15.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label15.ForeColor = SystemColors.ControlText;
            Label15.Location = new Point(379, 7);
            Label15.Name = "Label15";
            Label15.RightToLeft = RightToLeft.No;
            Label15.Size = new Size(93, 53);
            Label15.TabIndex = 28;
            Label15.Text = "Adjusting " + '\r' + '\n' + "for current " + '\r' + '\n' + "and/or leeway";
            Label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmdClear
            // 
            _cmdClear.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)));
            _cmdClear.Cursor = Cursors.Default;
            _cmdClear.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdClear.ForeColor = SystemColors.ControlText;
            _cmdClear.Location = new Point(5, 152);
            _cmdClear.Name = "_cmdClear";
            _cmdClear.RightToLeft = RightToLeft.No;
            _cmdClear.Size = new Size(90, 25);
            _cmdClear.TabIndex = 9;
            _cmdClear.Text = "Clear";
            _cmdClear.UseVisualStyleBackColor = false;
            // 
            // cmdCalculate
            // 
            _cmdCalculate.BackColor = Color.Blue;
            _cmdCalculate.Cursor = Cursors.Default;
            _cmdCalculate.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdCalculate.ForeColor = Color.White;
            _cmdCalculate.Location = new Point(405, 152);
            _cmdCalculate.Name = "_cmdCalculate";
            _cmdCalculate.RightToLeft = RightToLeft.No;
            _cmdCalculate.Size = new Size(90, 25);
            _cmdCalculate.TabIndex = 8;
            _cmdCalculate.Text = "Calculate";
            _cmdCalculate.UseVisualStyleBackColor = false;
            // 
            // Label14
            // 
            Label14.BackColor = SystemColors.Window;
            Label14.Cursor = Cursors.Default;
            Label14.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label14.ForeColor = SystemColors.ControlText;
            Label14.Location = new Point(56, 64);
            Label14.Name = "Label14";
            Label14.RightToLeft = RightToLeft.No;
            Label14.Size = new Size(80, 16);
            Label14.TabIndex = 27;
            Label14.Text = "Actual Values";
            Label14.Visible = false;
            // 
            // Label1
            // 
            Label1.BackColor = SystemColors.Window;
            Label1.Cursor = Cursors.Default;
            Label1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = SystemColors.ControlText;
            Label1.Location = new Point(16, 88);
            Label1.Name = "Label1";
            Label1.RightToLeft = RightToLeft.No;
            Label1.Size = new Size(48, 20);
            Label1.TabIndex = 26;
            Label1.Text = "Heading";
            Label1.Visible = false;
            // 
            // Label13
            // 
            Label13.BackColor = SystemColors.Window;
            Label13.Cursor = Cursors.Default;
            Label13.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label13.ForeColor = SystemColors.ControlText;
            Label13.Location = new Point(344, 112);
            Label13.Name = "Label13";
            Label13.RightToLeft = RightToLeft.No;
            Label13.Size = new Size(57, 17);
            Label13.TabIndex = 24;
            Label13.Text = "Wind from";
            // 
            // Label10
            // 
            Label10.BackColor = SystemColors.Window;
            Label10.Cursor = Cursors.Default;
            Label10.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label10.ForeColor = SystemColors.ControlText;
            Label10.Location = new Point(344, 88);
            Label10.Name = "Label10";
            Label10.RightToLeft = RightToLeft.No;
            Label10.Size = new Size(57, 17);
            Label10.TabIndex = 23;
            Label10.Text = "Drift Angle";
            // 
            // Label9
            // 
            Label9.BackColor = SystemColors.Window;
            Label9.Cursor = Cursors.Default;
            Label9.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label9.ForeColor = SystemColors.ControlText;
            Label9.Location = new Point(440, 88);
            Label9.Name = "Label9";
            Label9.RightToLeft = RightToLeft.No;
            Label9.Size = new Size(25, 17);
            Label9.TabIndex = 22;
            Label9.Text = "°";
            // 
            // Label8
            // 
            Label8.BackColor = SystemColors.Window;
            Label8.Cursor = Cursors.Default;
            Label8.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label8.ForeColor = SystemColors.ControlText;
            Label8.Location = new Point(392, 64);
            Label8.Name = "Label8";
            Label8.RightToLeft = RightToLeft.No;
            Label8.Size = new Size(50, 16);
            Label8.TabIndex = 21;
            Label8.Text = "Leeway";
            // 
            // Label12
            // 
            Label12.BackColor = SystemColors.Window;
            Label12.Cursor = Cursors.Default;
            Label12.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label12.ForeColor = SystemColors.ControlText;
            Label12.Location = new Point(296, 112);
            Label12.Name = "Label12";
            Label12.RightToLeft = RightToLeft.No;
            Label12.Size = new Size(33, 17);
            Label12.TabIndex = 20;
            Label12.Text = "knots";
            // 
            // Label11
            // 
            Label11.BackColor = SystemColors.Window;
            Label11.Cursor = Cursors.Default;
            Label11.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label11.ForeColor = SystemColors.ControlText;
            Label11.Location = new Point(144, 112);
            Label11.Name = "Label11";
            Label11.RightToLeft = RightToLeft.No;
            Label11.Size = new Size(33, 17);
            Label11.TabIndex = 19;
            Label11.Text = "knots";
            // 
            // lblST
            // 
            lblST.BackColor = SystemColors.Window;
            lblST.Cursor = Cursors.Default;
            lblST.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblST.ForeColor = SystemColors.ControlText;
            lblST.Location = new Point(296, 88);
            lblST.Name = "lblST";
            lblST.RightToLeft = RightToLeft.No;
            lblST.Size = new Size(25, 17);
            lblST.TabIndex = 18;
            lblST.Text = "°";
            // 
            // lblDCT
            // 
            lblDCT.BackColor = SystemColors.Window;
            lblDCT.Cursor = Cursors.Default;
            lblDCT.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblDCT.ForeColor = SystemColors.ControlText;
            lblDCT.Location = new Point(144, 88);
            lblDCT.Name = "lblDCT";
            lblDCT.RightToLeft = RightToLeft.No;
            lblDCT.Size = new Size(25, 17);
            lblDCT.TabIndex = 17;
            lblDCT.Text = "°";
            // 
            // Label7
            // 
            Label7.BackColor = SystemColors.Window;
            Label7.Cursor = Cursors.Default;
            Label7.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label7.ForeColor = SystemColors.ControlText;
            Label7.Location = new Point(203, 112);
            Label7.Name = "Label7";
            Label7.RightToLeft = RightToLeft.No;
            Label7.Size = new Size(41, 17);
            Label7.TabIndex = 16;
            Label7.Text = "Avg. Drift";
            // 
            // Label6
            // 
            Label6.BackColor = SystemColors.Window;
            Label6.Cursor = Cursors.Default;
            Label6.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label6.ForeColor = SystemColors.ControlText;
            Label6.Location = new Point(204, 89);
            Label6.Name = "Label6";
            Label6.RightToLeft = RightToLeft.No;
            Label6.Size = new Size(41, 17);
            Label6.TabIndex = 15;
            Label6.Text = "Set";
            // 
            // Label5
            // 
            Label5.BackColor = SystemColors.Window;
            Label5.Cursor = Cursors.Default;
            Label5.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label5.ForeColor = SystemColors.ControlText;
            Label5.Location = new Point(16, 112);
            Label5.Name = "Label5";
            Label5.RightToLeft = RightToLeft.No;
            Label5.Size = new Size(73, 17);
            Label5.TabIndex = 14;
            Label5.Text = "Cruising Speed";
            // 
            // Label4
            // 
            Label4.BackColor = SystemColors.Window;
            Label4.Cursor = Cursors.Default;
            Label4.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.ForeColor = SystemColors.ControlText;
            Label4.Location = new Point(16, 88);
            Label4.Name = "Label4";
            Label4.RightToLeft = RightToLeft.No;
            Label4.Size = new Size(81, 17);
            Label4.TabIndex = 13;
            Label4.Text = "Intended Course";
            // 
            // Label3
            // 
            Label3.BackColor = SystemColors.Window;
            Label3.Cursor = Cursors.Default;
            Label3.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.ForeColor = SystemColors.ControlText;
            Label3.Location = new Point(240, 64);
            Label3.Name = "Label3";
            Label3.RightToLeft = RightToLeft.No;
            Label3.Size = new Size(47, 16);
            Label3.TabIndex = 12;
            Label3.Text = "Current";
            // 
            // Label2
            // 
            Label2.BackColor = SystemColors.Window;
            Label2.Cursor = Cursors.Default;
            Label2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = SystemColors.ControlText;
            Label2.Location = new Point(56, 64);
            Label2.Name = "Label2";
            Label2.RightToLeft = RightToLeft.No;
            Label2.Size = new Size(85, 16);
            Label2.TabIndex = 11;
            Label2.Text = "Intended Values";
            // 
            // btnExit
            // 
            _btnExit.BackColor = Color.Red;
            _btnExit.Cursor = Cursors.Default;
            _btnExit.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnExit.ForeColor = SystemColors.ControlLightLight;
            _btnExit.Location = new Point(405, 302);
            _btnExit.Name = "_btnExit";
            _btnExit.RightToLeft = RightToLeft.No;
            _btnExit.Size = new Size(90, 25);
            _btnExit.TabIndex = 29;
            _btnExit.Text = "Exit";
            _btnExit.UseVisualStyleBackColor = false;
            // 
            // txtWindCurrent
            // 
            txtWindCurrent.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtWindCurrent.Location = new Point(3, 183);
            txtWindCurrent.Multiline = true;
            txtWindCurrent.Name = "txtWindCurrent";
            txtWindCurrent.ReadOnly = true;
            txtWindCurrent.ScrollBars = ScrollBars.Vertical;
            txtWindCurrent.Size = new Size(491, 111);
            txtWindCurrent.TabIndex = 30;
            txtWindCurrent.TextAlign = HorizontalAlignment.Center;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.ABC_white;
            PictureBox1.Location = new Point(85, 302);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(316, 50);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 102;
            PictureBox1.TabStop = false;
            // 
            // FormCTSSOA
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(498, 357);
            Controls.Add(PictureBox1);
            Controls.Add(txtWindCurrent);
            Controls.Add(_btnExit);
            Controls.Add(Frame1);
            Controls.Add(_cmdClear);
            Controls.Add(cboWind);
            Controls.Add(_txtDriftAngle);
            Controls.Add(_cmdPrint);
            Controls.Add(_cmdCalculate);
            Controls.Add(_txtDrift);
            Controls.Add(_txtSet);
            Controls.Add(_txtCS);
            Controls.Add(_txtDC);
            Controls.Add(Label14);
            Controls.Add(Label1);
            Controls.Add(Label13);
            Controls.Add(Label10);
            Controls.Add(Label9);
            Controls.Add(Label8);
            Controls.Add(Label12);
            Controls.Add(Label11);
            Controls.Add(lblST);
            Controls.Add(lblDCT);
            Controls.Add(Label7);
            Controls.Add(Label6);
            Controls.Add(Label5);
            Controls.Add(Label4);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(Label15);
            Cursor = Cursors.Default;
            Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(454, 333);
            MaximizeBox = false;
            Name = "FormCTSSOA";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Wind & Current";
            Frame1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            FormClosed += new FormClosedEventHandler(FormCTSSOA_FormClosed);
            ResumeLayout(false);
            PerformLayout();
        }

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

        internal TextBox txtWindCurrent;
        internal PictureBox PictureBox1;
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}