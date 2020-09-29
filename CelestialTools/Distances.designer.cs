using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    [DesignerGenerated()]
    internal partial class FormDistances
    {
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        [DebuggerNonUserCode()]
        public FormDistances() : base()
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
        private RadioButton _optVertSeaTop;

        public RadioButton optVertSeaTop
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optVertSeaTop;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optVertSeaTop != null)
                {
                    _optVertSeaTop.CheckedChanged -= optVertSeaTop_CheckedChanged;
                }

                _optVertSeaTop = value;
                if (_optVertSeaTop != null)
                {
                    _optVertSeaTop.CheckedChanged += optVertSeaTop_CheckedChanged;
                }
            }
        }

        private RadioButton _optVertWaterSea;

        public RadioButton optVertWaterSea
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optVertWaterSea;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optVertWaterSea != null)
                {
                    _optVertWaterSea.CheckedChanged -= optVertWaterSea_CheckedChanged;
                }

                _optVertWaterSea = value;
                if (_optVertWaterSea != null)
                {
                    _optVertWaterSea.CheckedChanged += optVertWaterSea_CheckedChanged;
                }
            }
        }

        private RadioButton _optVertWaterTop;

        public RadioButton optVertWaterTop
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optVertWaterTop;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optVertWaterTop != null)
                {
                    _optVertWaterTop.CheckedChanged -= optVertWaterTop_CheckedChanged;
                }

                _optVertWaterTop = value;
                if (_optVertWaterTop != null)
                {
                    _optVertWaterTop.CheckedChanged += optVertWaterTop_CheckedChanged;
                }
            }
        }

        private RadioButton _optGeogRange;

        public RadioButton optGeogRange
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optGeogRange;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optGeogRange != null)
                {
                    _optGeogRange.CheckedChanged -= optGeogRange_CheckedChanged;
                }

                _optGeogRange = value;
                if (_optGeogRange != null)
                {
                    _optGeogRange.CheckedChanged += optGeogRange_CheckedChanged;
                }
            }
        }

        private RadioButton _optDistHorizon;

        public RadioButton optDistHorizon
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optDistHorizon;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optDistHorizon != null)
                {
                    _optDistHorizon.CheckedChanged -= optDistHorizon_CheckedChanged;
                }

                _optDistHorizon = value;
                if (_optDistHorizon != null)
                {
                    _optDistHorizon.CheckedChanged += optDistHorizon_CheckedChanged;
                }
            }
        }

        public GroupBox Frame1;
        private TextBox _txtHsDeg;

        public TextBox txtHsDeg
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtHsDeg;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtHsDeg != null)
                {
                    _txtHsDeg.TextChanged -= txtHsDeg_TextChanged;
                    _txtHsDeg.KeyPress -= txtHsDeg_KeyPress;
                    _txtHsDeg.Validating -= txtHsDeg_Validating;
                    _txtHsDeg.Enter -= txtHsDeg_Enter;
                }

                _txtHsDeg = value;
                if (_txtHsDeg != null)
                {
                    _txtHsDeg.TextChanged += txtHsDeg_TextChanged;
                    _txtHsDeg.KeyPress += txtHsDeg_KeyPress;
                    _txtHsDeg.Validating += txtHsDeg_Validating;
                    _txtHsDeg.Enter += txtHsDeg_Enter;
                }
            }
        }

        private TextBox _txtHsMin;

        public TextBox txtHsMin
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtHsMin;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtHsMin != null)
                {
                    _txtHsMin.TextChanged -= txtHsMin_TextChanged;
                    _txtHsMin.KeyPress -= txtHsMin_KeyPress;
                    _txtHsMin.Validating -= txtHsMin_Validating;
                    _txtHsMin.Enter -= txtHsMin_Enter;
                }

                _txtHsMin = value;
                if (_txtHsMin != null)
                {
                    _txtHsMin.TextChanged += txtHsMin_TextChanged;
                    _txtHsMin.KeyPress += txtHsMin_KeyPress;
                    _txtHsMin.Validating += txtHsMin_Validating;
                    _txtHsMin.Enter += txtHsMin_Enter;
                }
            }
        }

        private TextBox _txtHsSec;

        public TextBox txtHsSec
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtHsSec;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtHsSec != null)
                {
                    _txtHsSec.TextChanged -= txtHsSec_TextChanged;
                    _txtHsSec.KeyPress -= txtHsSec_KeyPress;
                    _txtHsSec.Validating -= txtHsSec_Validating;
                    _txtHsSec.Enter -= txtHsSec_Enter;
                }

                _txtHsSec = value;
                if (_txtHsSec != null)
                {
                    _txtHsSec.TextChanged += txtHsSec_TextChanged;
                    _txtHsSec.KeyPress += txtHsSec_KeyPress;
                    _txtHsSec.Validating += txtHsSec_Validating;
                    _txtHsSec.Enter += txtHsSec_Enter;
                }
            }
        }

        private TextBox _txtIEmin;

        public TextBox txtIEmin
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtIEmin;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtIEmin != null)
                {
                    _txtIEmin.TextChanged -= txtIEmin_TextChanged;
                    _txtIEmin.KeyPress -= txtIEmin_KeyPress;
                    _txtIEmin.Validating -= txtIEmin_Validating;
                    _txtIEmin.Enter -= txtIEmin_Enter;
                }

                _txtIEmin = value;
                if (_txtIEmin != null)
                {
                    _txtIEmin.TextChanged += txtIEmin_TextChanged;
                    _txtIEmin.KeyPress += txtIEmin_KeyPress;
                    _txtIEmin.Validating += txtIEmin_Validating;
                    _txtIEmin.Enter += txtIEmin_Enter;
                }
            }
        }

        public ComboBox cboIE;
        private RadioButton _optHsDMm;

        public RadioButton optHsDMm
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optHsDMm;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optHsDMm != null)
                {
                    _optHsDMm.CheckedChanged -= optHsDMm_CheckedChanged;
                }

                _optHsDMm = value;
                if (_optHsDMm != null)
                {
                    _optHsDMm.CheckedChanged += optHsDMm_CheckedChanged;
                }
            }
        }

        private RadioButton _optHsDMS;

        public RadioButton optHsDMS
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optHsDMS;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optHsDMS != null)
                {
                    _optHsDMS.CheckedChanged -= optHsDMS_CheckedChanged;
                }

                _optHsDMS = value;
                if (_optHsDMS != null)
                {
                    _optHsDMS.CheckedChanged += optHsDMS_CheckedChanged;
                }
            }
        }

        public Panel Framehs;
        private TextBox _txtIEdeg;

        public TextBox txtIEdeg
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtIEdeg;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtIEdeg != null)
                {
                    _txtIEdeg.TextChanged -= txtIEdeg_TextChanged;
                    _txtIEdeg.KeyPress -= txtIEdeg_KeyPress;
                    _txtIEdeg.Validating -= txtIEdeg_Validating;
                    _txtIEdeg.Enter -= txtIEDeg_Enter;
                }

                _txtIEdeg = value;
                if (_txtIEdeg != null)
                {
                    _txtIEdeg.TextChanged += txtIEdeg_TextChanged;
                    _txtIEdeg.KeyPress += txtIEdeg_KeyPress;
                    _txtIEdeg.Validating += txtIEdeg_Validating;
                    _txtIEdeg.Enter += txtIEDeg_Enter;
                }
            }
        }

        private TextBox _txtIESec;

        public TextBox txtIESec
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtIESec;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtIESec != null)
                {
                    _txtIESec.TextChanged -= txtIESec_TextChanged;
                    _txtIESec.KeyPress -= txtIESec_KeyPress;
                    _txtIESec.Validating -= txtIESec_Validating;
                    _txtIESec.Enter -= txtIESec_Enter;
                }

                _txtIESec = value;
                if (_txtIESec != null)
                {
                    _txtIESec.TextChanged += txtIESec_TextChanged;
                    _txtIESec.KeyPress += txtIESec_KeyPress;
                    _txtIESec.Validating += txtIESec_Validating;
                    _txtIESec.Enter += txtIESec_Enter;
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

        public ComboBox cboHO;
        private TextBox _txtHO;

        public TextBox txtHO
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtHO;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtHO != null)
                {
                    _txtHO.KeyPress -= txtHO_KeyPress;
                    _txtHO.Enter -= txtHO_Enter;
                }

                _txtHO = value;
                if (_txtHO != null)
                {
                    _txtHO.KeyPress += txtHO_KeyPress;
                    _txtHO.Enter += txtHO_Enter;
                }
            }
        }

        public ComboBox cboHE;
        private TextBox _txtHE;

        public TextBox txtHE
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtHE;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtHE != null)
                {
                    _txtHE.KeyPress -= txtHE_KeyPress;
                    _txtHE.Enter -= txtHE_Enter;
                }

                _txtHE = value;
                if (_txtHE != null)
                {
                    _txtHE.KeyPress += txtHE_KeyPress;
                    _txtHE.Enter += txtHE_Enter;
                }
            }
        }

        public Label lblHsFormat;
        public Label lblHs;
        public Label lblHsDeg;
        public Label lblHsMin;
        public Label lblHsSec;
        public Label lblIE;
        public Label lblIEMin;
        public Label lblIEdeg;
        public Label lblIEsec;
        // Public WithEvents Line1 As Microsoft.VisualBasic.PowerPacks.LineShape
        public Label lblHO;
        public Label lblHE;
        // Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDistances));
            ToolTip1 = new ToolTip(components);
            _txtHsDeg = new TextBox();
            _txtHsDeg.TextChanged += new EventHandler(txtHsDeg_TextChanged);
            _txtHsDeg.KeyPress += new KeyPressEventHandler(txtHsDeg_KeyPress);
            _txtHsDeg.Validating += new System.ComponentModel.CancelEventHandler(txtHsDeg_Validating);
            _txtHsDeg.Enter += new EventHandler(txtHsDeg_Enter);
            _txtHsMin = new TextBox();
            _txtHsMin.TextChanged += new EventHandler(txtHsMin_TextChanged);
            _txtHsMin.KeyPress += new KeyPressEventHandler(txtHsMin_KeyPress);
            _txtHsMin.Validating += new System.ComponentModel.CancelEventHandler(txtHsMin_Validating);
            _txtHsMin.Enter += new EventHandler(txtHsMin_Enter);
            _txtHsSec = new TextBox();
            _txtHsSec.TextChanged += new EventHandler(txtHsSec_TextChanged);
            _txtHsSec.KeyPress += new KeyPressEventHandler(txtHsSec_KeyPress);
            _txtHsSec.Validating += new System.ComponentModel.CancelEventHandler(txtHsSec_Validating);
            _txtHsSec.Enter += new EventHandler(txtHsSec_Enter);
            _txtIEmin = new TextBox();
            _txtIEmin.TextChanged += new EventHandler(txtIEmin_TextChanged);
            _txtIEmin.KeyPress += new KeyPressEventHandler(txtIEmin_KeyPress);
            _txtIEmin.Validating += new System.ComponentModel.CancelEventHandler(txtIEmin_Validating);
            _txtIEmin.Enter += new EventHandler(txtIEmin_Enter);
            _txtIEdeg = new TextBox();
            _txtIEdeg.TextChanged += new EventHandler(txtIEdeg_TextChanged);
            _txtIEdeg.KeyPress += new KeyPressEventHandler(txtIEdeg_KeyPress);
            _txtIEdeg.Validating += new System.ComponentModel.CancelEventHandler(txtIEdeg_Validating);
            _txtIEdeg.Enter += new EventHandler(txtIEDeg_Enter);
            _txtIESec = new TextBox();
            _txtIESec.TextChanged += new EventHandler(txtIESec_TextChanged);
            _txtIESec.KeyPress += new KeyPressEventHandler(txtIESec_KeyPress);
            _txtIESec.Validating += new System.ComponentModel.CancelEventHandler(txtIESec_Validating);
            _txtIESec.Enter += new EventHandler(txtIESec_Enter);
            _cmdPrint = new Button();
            _cmdPrint.Click += new EventHandler(cmdPrint_Click);
            _txtHO = new TextBox();
            _txtHO.KeyPress += new KeyPressEventHandler(txtHO_KeyPress);
            _txtHO.Enter += new EventHandler(txtHO_Enter);
            _txtHE = new TextBox();
            _txtHE.KeyPress += new KeyPressEventHandler(txtHE_KeyPress);
            _txtHE.Enter += new EventHandler(txtHE_Enter);
            lblHsFormat = new Label();
            lblHs = new Label();
            lblIE = new Label();
            lblHE = new Label();
            Frame1 = new GroupBox();
            _optVertSeaTop = new RadioButton();
            _optVertSeaTop.CheckedChanged += new EventHandler(optVertSeaTop_CheckedChanged);
            _optVertWaterSea = new RadioButton();
            _optVertWaterSea.CheckedChanged += new EventHandler(optVertWaterSea_CheckedChanged);
            _optVertWaterTop = new RadioButton();
            _optVertWaterTop.CheckedChanged += new EventHandler(optVertWaterTop_CheckedChanged);
            _optGeogRange = new RadioButton();
            _optGeogRange.CheckedChanged += new EventHandler(optGeogRange_CheckedChanged);
            _optDistHorizon = new RadioButton();
            _optDistHorizon.CheckedChanged += new EventHandler(optDistHorizon_CheckedChanged);
            cboIE = new ComboBox();
            Framehs = new Panel();
            _optHsDMm = new RadioButton();
            _optHsDMm.CheckedChanged += new EventHandler(optHsDMm_CheckedChanged);
            _optHsDMS = new RadioButton();
            _optHsDMS.CheckedChanged += new EventHandler(optHsDMS_CheckedChanged);
            _cmdCalculate = new Button();
            _cmdCalculate.Click += new EventHandler(cmdCalculate_Click);
            cboHO = new ComboBox();
            cboHE = new ComboBox();
            lblHsDeg = new Label();
            lblHsMin = new Label();
            lblHsSec = new Label();
            lblIEMin = new Label();
            lblIEdeg = new Label();
            lblIEsec = new Label();
            lblHO = new Label();
            TextBoxFormDistances = new TextBox();
            _ExitBtn = new Button();
            _ExitBtn.Click += new EventHandler(ExitBtn_Click);
            PictureBox1 = new PictureBox();
            Frame1.SuspendLayout();
            Framehs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtHsDeg
            // 
            _txtHsDeg.AcceptsReturn = true;
            _txtHsDeg.BackColor = SystemColors.Window;
            _txtHsDeg.Cursor = Cursors.IBeam;
            _txtHsDeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtHsDeg.ForeColor = SystemColors.WindowText;
            _txtHsDeg.Location = new Point(405, 101);
            _txtHsDeg.MaxLength = 2;
            _txtHsDeg.Name = "_txtHsDeg";
            _txtHsDeg.RightToLeft = RightToLeft.No;
            _txtHsDeg.Size = new Size(25, 20);
            _txtHsDeg.TabIndex = 9;
            ToolTip1.SetToolTip(_txtHsDeg, "Range 0 to 89");
            _txtHsDeg.Visible = false;
            // 
            // txtHsMin
            // 
            _txtHsMin.AcceptsReturn = true;
            _txtHsMin.BackColor = SystemColors.Window;
            _txtHsMin.Cursor = Cursors.IBeam;
            _txtHsMin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtHsMin.ForeColor = SystemColors.WindowText;
            _txtHsMin.Location = new Point(437, 101);
            _txtHsMin.MaxLength = 4;
            _txtHsMin.Name = "_txtHsMin";
            _txtHsMin.RightToLeft = RightToLeft.No;
            _txtHsMin.Size = new Size(33, 20);
            _txtHsMin.TabIndex = 10;
            ToolTip1.SetToolTip(_txtHsMin, "Range 0 to 59.9 (DM.m) or 59 (DMS)");
            _txtHsMin.Visible = false;
            // 
            // txtHsSec
            // 
            _txtHsSec.AcceptsReturn = true;
            _txtHsSec.BackColor = SystemColors.Window;
            _txtHsSec.Cursor = Cursors.IBeam;
            _txtHsSec.Enabled = false;
            _txtHsSec.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtHsSec.ForeColor = SystemColors.WindowText;
            _txtHsSec.Location = new Point(477, 101);
            _txtHsSec.MaxLength = 2;
            _txtHsSec.Name = "_txtHsSec";
            _txtHsSec.RightToLeft = RightToLeft.No;
            _txtHsSec.Size = new Size(33, 20);
            _txtHsSec.TabIndex = 11;
            ToolTip1.SetToolTip(_txtHsSec, "Range 0 to 59.");
            _txtHsSec.Visible = false;
            // 
            // txtIEmin
            // 
            _txtIEmin.AcceptsReturn = true;
            _txtIEmin.BackColor = SystemColors.Window;
            _txtIEmin.Cursor = Cursors.IBeam;
            _txtIEmin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtIEmin.ForeColor = SystemColors.WindowText;
            _txtIEmin.Location = new Point(437, 123);
            _txtIEmin.MaxLength = 4;
            _txtIEmin.Name = "_txtIEmin";
            _txtIEmin.RightToLeft = RightToLeft.No;
            _txtIEmin.Size = new Size(33, 20);
            _txtIEmin.TabIndex = 13;
            ToolTip1.SetToolTip(_txtIEmin, "Range 0 to 59.9 (DM.m) or 59 (DMS)");
            _txtIEmin.Visible = false;
            // 
            // txtIEdeg
            // 
            _txtIEdeg.AcceptsReturn = true;
            _txtIEdeg.BackColor = SystemColors.Window;
            _txtIEdeg.Cursor = Cursors.IBeam;
            _txtIEdeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtIEdeg.ForeColor = SystemColors.WindowText;
            _txtIEdeg.Location = new Point(405, 123);
            _txtIEdeg.MaxLength = 1;
            _txtIEdeg.Name = "_txtIEdeg";
            _txtIEdeg.RightToLeft = RightToLeft.No;
            _txtIEdeg.Size = new Size(25, 20);
            _txtIEdeg.TabIndex = 12;
            ToolTip1.SetToolTip(_txtIEdeg, "Range 0 to 9");
            _txtIEdeg.Visible = false;
            // 
            // txtIESec
            // 
            _txtIESec.AcceptsReturn = true;
            _txtIESec.BackColor = SystemColors.Window;
            _txtIESec.Cursor = Cursors.IBeam;
            _txtIESec.Enabled = false;
            _txtIESec.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtIESec.ForeColor = SystemColors.WindowText;
            _txtIESec.Location = new Point(477, 123);
            _txtIESec.MaxLength = 2;
            _txtIESec.Name = "_txtIESec";
            _txtIESec.RightToLeft = RightToLeft.No;
            _txtIESec.Size = new Size(33, 20);
            _txtIESec.TabIndex = 14;
            ToolTip1.SetToolTip(_txtIESec, "Range 0 to 59");
            _txtIESec.Visible = false;
            // 
            // cmdPrint
            // 
            _cmdPrint.BackColor = SystemColors.Control;
            _cmdPrint.Cursor = Cursors.Default;
            _cmdPrint.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdPrint.ForeColor = SystemColors.ControlText;
            _cmdPrint.Image = (Image)resources.GetObject("cmdPrint.Image");
            _cmdPrint.Location = new Point(610, 0);
            _cmdPrint.Name = "_cmdPrint";
            _cmdPrint.RightToLeft = RightToLeft.No;
            _cmdPrint.Size = new Size(21, 21);
            _cmdPrint.TabIndex = 19;
            _cmdPrint.TextAlign = ContentAlignment.BottomCenter;
            ToolTip1.SetToolTip(_cmdPrint, "Print window");
            _cmdPrint.UseVisualStyleBackColor = false;
            // 
            // txtHO
            // 
            _txtHO.AcceptsReturn = true;
            _txtHO.BackColor = SystemColors.Window;
            _txtHO.Cursor = Cursors.IBeam;
            _txtHO.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtHO.ForeColor = SystemColors.WindowText;
            _txtHO.Location = new Point(408, 47);
            _txtHO.MaxLength = 4;
            _txtHO.Name = "_txtHO";
            _txtHO.RightToLeft = RightToLeft.No;
            _txtHO.Size = new Size(33, 20);
            _txtHO.TabIndex = 7;
            ToolTip1.SetToolTip(_txtHO, "Max. 4 characters");
            _txtHO.Visible = false;
            // 
            // txtHE
            // 
            _txtHE.AcceptsReturn = true;
            _txtHE.BackColor = SystemColors.Window;
            _txtHE.Cursor = Cursors.IBeam;
            _txtHE.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtHE.ForeColor = SystemColors.WindowText;
            _txtHE.Location = new Point(408, 22);
            _txtHE.MaxLength = 4;
            _txtHE.Name = "_txtHE";
            _txtHE.RightToLeft = RightToLeft.No;
            _txtHE.Size = new Size(33, 20);
            _txtHE.TabIndex = 5;
            ToolTip1.SetToolTip(_txtHE, "Max. 4 characters");
            // 
            // lblHsFormat
            // 
            lblHsFormat.BackColor = SystemColors.Window;
            lblHsFormat.Cursor = Cursors.Default;
            lblHsFormat.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblHsFormat.ForeColor = SystemColors.ControlText;
            lblHsFormat.Location = new Point(332, 79);
            lblHsFormat.Name = "lblHsFormat";
            lblHsFormat.RightToLeft = RightToLeft.No;
            lblHsFormat.Size = new Size(65, 13);
            lblHsFormat.TabIndex = 31;
            lblHsFormat.Text = "hs/IE format";
            lblHsFormat.TextAlign = ContentAlignment.MiddleLeft;
            ToolTip1.SetToolTip(lblHsFormat, "Sextant Altitude/Index Error format");
            lblHsFormat.Visible = false;
            // 
            // lblHs
            // 
            lblHs.BackColor = SystemColors.Window;
            lblHs.Cursor = Cursors.Default;
            lblHs.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblHs.ForeColor = SystemColors.ControlText;
            lblHs.Location = new Point(253, 103);
            lblHs.Name = "lblHs";
            lblHs.RightToLeft = RightToLeft.No;
            lblHs.Size = new Size(153, 17);
            lblHs.TabIndex = 30;
            lblHs.Text = "Uncorrected Vertical Angle (hs)";
            lblHs.TextAlign = ContentAlignment.MiddleLeft;
            ToolTip1.SetToolTip(lblHs, "Sextant Altitude");
            lblHs.Visible = false;
            // 
            // lblIE
            // 
            lblIE.BackColor = SystemColors.Window;
            lblIE.Cursor = Cursors.Default;
            lblIE.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblIE.ForeColor = SystemColors.ControlText;
            lblIE.Location = new Point(325, 125);
            lblIE.Name = "lblIE";
            lblIE.RightToLeft = RightToLeft.No;
            lblIE.Size = new Size(81, 17);
            lblIE.TabIndex = 26;
            lblIE.Text = "Index Error (IE)";
            lblIE.TextAlign = ContentAlignment.MiddleLeft;
            ToolTip1.SetToolTip(lblIE, "Index Error");
            lblIE.Visible = false;
            // 
            // lblHE
            // 
            lblHE.BackColor = SystemColors.Window;
            lblHE.Cursor = Cursors.Default;
            lblHE.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblHE.ForeColor = SystemColors.ControlText;
            lblHE.Location = new Point(332, 25);
            lblHE.Name = "lblHE";
            lblHE.RightToLeft = RightToLeft.No;
            lblHE.Size = new Size(75, 17);
            lblHE.TabIndex = 16;
            lblHE.Text = "Height of Eye";
            lblHE.TextAlign = ContentAlignment.MiddleLeft;
            ToolTip1.SetToolTip(lblHE, "Height of Eye");
            // 
            // Frame1
            // 
            Frame1.BackColor = SystemColors.Window;
            Frame1.Controls.Add(_optVertSeaTop);
            Frame1.Controls.Add(_optVertWaterSea);
            Frame1.Controls.Add(_optVertWaterTop);
            Frame1.Controls.Add(_optGeogRange);
            Frame1.Controls.Add(_optDistHorizon);
            Frame1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Frame1.ForeColor = SystemColors.ControlText;
            Frame1.Location = new Point(17, 9);
            Frame1.Name = "Frame1";
            Frame1.Padding = new Padding(0);
            Frame1.RightToLeft = RightToLeft.No;
            Frame1.Size = new Size(230, 241);
            Frame1.TabIndex = 32;
            Frame1.TabStop = false;
            Frame1.Text = "Select function";
            // 
            // optVertSeaTop
            // 
            _optVertSeaTop.BackColor = SystemColors.Window;
            _optVertSeaTop.Cursor = Cursors.Default;
            _optVertSeaTop.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optVertSeaTop.ForeColor = SystemColors.ControlText;
            _optVertSeaTop.Location = new Point(8, 168);
            _optVertSeaTop.Name = "_optVertSeaTop";
            _optVertSeaTop.RightToLeft = RightToLeft.No;
            _optVertSeaTop.Size = new Size(206, 57);
            _optVertSeaTop.TabIndex = 4;
            _optVertSeaTop.TabStop = true;
            _optVertSeaTop.Text = "Distance by Vertical Angle Measured Between Sea Horizon and Top of Object Beyond " + "Sea Horizon";
            _optVertSeaTop.UseVisualStyleBackColor = false;
            // 
            // optVertWaterSea
            // 
            _optVertWaterSea.BackColor = SystemColors.Window;
            _optVertWaterSea.Cursor = Cursors.Default;
            _optVertWaterSea.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optVertWaterSea.ForeColor = SystemColors.ControlText;
            _optVertWaterSea.Location = new Point(8, 115);
            _optVertWaterSea.Name = "_optVertWaterSea";
            _optVertWaterSea.RightToLeft = RightToLeft.No;
            _optVertWaterSea.Size = new Size(206, 50);
            _optVertWaterSea.TabIndex = 3;
            _optVertWaterSea.TabStop = true;
            _optVertWaterSea.Text = "Distance by Vertical Angle Measured Between Waterline at Object and Sea Horizon B" + "eyond Object";
            _optVertWaterSea.UseVisualStyleBackColor = false;
            // 
            // optVertWaterTop
            // 
            _optVertWaterTop.BackColor = SystemColors.Window;
            _optVertWaterTop.Cursor = Cursors.Default;
            _optVertWaterTop.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optVertWaterTop.ForeColor = SystemColors.ControlText;
            _optVertWaterTop.Location = new Point(8, 62);
            _optVertWaterTop.Name = "_optVertWaterTop";
            _optVertWaterTop.RightToLeft = RightToLeft.No;
            _optVertWaterTop.Size = new Size(206, 50);
            _optVertWaterTop.TabIndex = 2;
            _optVertWaterTop.TabStop = true;
            _optVertWaterTop.Text = "Distance by Vertical Angle Measured Between Waterline at Object and Top of Object" + "";
            _optVertWaterTop.UseVisualStyleBackColor = false;
            // 
            // optGeogRange
            // 
            _optGeogRange.BackColor = SystemColors.Window;
            _optGeogRange.Cursor = Cursors.Default;
            _optGeogRange.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optGeogRange.ForeColor = SystemColors.ControlText;
            _optGeogRange.Location = new Point(8, 39);
            _optGeogRange.Name = "_optGeogRange";
            _optGeogRange.RightToLeft = RightToLeft.No;
            _optGeogRange.Size = new Size(190, 17);
            _optGeogRange.TabIndex = 1;
            _optGeogRange.TabStop = true;
            _optGeogRange.Text = "Geographical Range of Visibility";
            _optGeogRange.UseVisualStyleBackColor = false;
            // 
            // optDistHorizon
            // 
            _optDistHorizon.BackColor = SystemColors.Window;
            _optDistHorizon.Checked = true;
            _optDistHorizon.Cursor = Cursors.Default;
            _optDistHorizon.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optDistHorizon.ForeColor = SystemColors.ControlText;
            _optDistHorizon.Location = new Point(8, 16);
            _optDistHorizon.Name = "_optDistHorizon";
            _optDistHorizon.RightToLeft = RightToLeft.No;
            _optDistHorizon.Size = new Size(190, 17);
            _optDistHorizon.TabIndex = 0;
            _optDistHorizon.TabStop = true;
            _optDistHorizon.Text = "Distance of the Horizon";
            _optDistHorizon.UseVisualStyleBackColor = false;
            // 
            // cboIE
            // 
            cboIE.BackColor = SystemColors.Window;
            cboIE.Cursor = Cursors.Default;
            cboIE.DropDownStyle = ComboBoxStyle.DropDownList;
            cboIE.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboIE.ForeColor = SystemColors.WindowText;
            cboIE.Items.AddRange(new object[] { "on the arc", "off the arc (val.)", "off the arc (rdg.)" });
            cboIE.Location = new Point(521, 123);
            cboIE.Name = "cboIE";
            cboIE.RightToLeft = RightToLeft.No;
            cboIE.Size = new Size(105, 22);
            cboIE.TabIndex = 15;
            cboIE.Visible = false;
            // 
            // Framehs
            // 
            Framehs.BackColor = SystemColors.Window;
            Framehs.Controls.Add(_optHsDMm);
            Framehs.Controls.Add(_optHsDMS);
            Framehs.Cursor = Cursors.Default;
            Framehs.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Framehs.ForeColor = SystemColors.ControlText;
            Framehs.Location = new Point(406, 75);
            Framehs.Name = "Framehs";
            Framehs.RightToLeft = RightToLeft.No;
            Framehs.Size = new Size(121, 20);
            Framehs.TabIndex = 20;
            Framehs.Text = "Frame2";
            // 
            // optHsDMm
            // 
            _optHsDMm.BackColor = SystemColors.Window;
            _optHsDMm.Checked = true;
            _optHsDMm.Cursor = Cursors.Default;
            _optHsDMm.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optHsDMm.ForeColor = SystemColors.ControlText;
            _optHsDMm.Location = new Point(4, 2);
            _optHsDMm.Name = "_optHsDMm";
            _optHsDMm.RightToLeft = RightToLeft.No;
            _optHsDMm.Size = new Size(49, 16);
            _optHsDMm.TabIndex = 22;
            _optHsDMm.TabStop = true;
            _optHsDMm.Text = "DM.m";
            _optHsDMm.UseVisualStyleBackColor = false;
            _optHsDMm.Visible = false;
            // 
            // optHsDMS
            // 
            _optHsDMS.BackColor = SystemColors.Window;
            _optHsDMS.Cursor = Cursors.Default;
            _optHsDMS.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optHsDMS.ForeColor = SystemColors.ControlText;
            _optHsDMS.Location = new Point(66, 2);
            _optHsDMS.Name = "_optHsDMS";
            _optHsDMS.RightToLeft = RightToLeft.No;
            _optHsDMS.Size = new Size(49, 16);
            _optHsDMS.TabIndex = 21;
            _optHsDMS.TabStop = true;
            _optHsDMS.Text = "DMS";
            _optHsDMS.UseVisualStyleBackColor = false;
            _optHsDMS.Visible = false;
            // 
            // cmdCalculate
            // 
            _cmdCalculate.BackColor = Color.Blue;
            _cmdCalculate.Cursor = Cursors.Default;
            _cmdCalculate.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdCalculate.ForeColor = Color.White;
            _cmdCalculate.Location = new Point(60, 256);
            _cmdCalculate.Name = "_cmdCalculate";
            _cmdCalculate.RightToLeft = RightToLeft.No;
            _cmdCalculate.Size = new Size(90, 25);
            _cmdCalculate.TabIndex = 18;
            _cmdCalculate.Text = "&Calculate";
            _cmdCalculate.UseVisualStyleBackColor = false;
            // 
            // cboHO
            // 
            cboHO.BackColor = SystemColors.Window;
            cboHO.Cursor = Cursors.Default;
            cboHO.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHO.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboHO.ForeColor = SystemColors.WindowText;
            cboHO.Items.AddRange(new object[] { "ft", "m " });
            cboHO.Location = new Point(456, 46);
            cboHO.Name = "cboHO";
            cboHO.RightToLeft = RightToLeft.No;
            cboHO.Size = new Size(41, 22);
            cboHO.TabIndex = 8;
            cboHO.Visible = false;
            // 
            // cboHE
            // 
            cboHE.BackColor = SystemColors.Window;
            cboHE.Cursor = Cursors.Default;
            cboHE.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHE.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboHE.ForeColor = SystemColors.WindowText;
            cboHE.Items.AddRange(new object[] { "ft", "in", "m ", "cm" });
            cboHE.Location = new Point(456, 22);
            cboHE.Name = "cboHE";
            cboHE.RightToLeft = RightToLeft.No;
            cboHE.Size = new Size(41, 22);
            cboHE.TabIndex = 6;
            // 
            // lblHsDeg
            // 
            lblHsDeg.BackColor = SystemColors.Window;
            lblHsDeg.Cursor = Cursors.Default;
            lblHsDeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblHsDeg.ForeColor = SystemColors.ControlText;
            lblHsDeg.Location = new Point(430, 99);
            lblHsDeg.Name = "lblHsDeg";
            lblHsDeg.RightToLeft = RightToLeft.No;
            lblHsDeg.Size = new Size(9, 17);
            lblHsDeg.TabIndex = 29;
            lblHsDeg.Text = "°";
            lblHsDeg.Visible = false;
            // 
            // lblHsMin
            // 
            lblHsMin.BackColor = SystemColors.Window;
            lblHsMin.Cursor = Cursors.Default;
            lblHsMin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblHsMin.ForeColor = SystemColors.ControlText;
            lblHsMin.Location = new Point(470, 101);
            lblHsMin.Name = "lblHsMin";
            lblHsMin.RightToLeft = RightToLeft.No;
            lblHsMin.Size = new Size(9, 17);
            lblHsMin.TabIndex = 28;
            lblHsMin.Text = "'";
            lblHsMin.Visible = false;
            // 
            // lblHsSec
            // 
            lblHsSec.BackColor = SystemColors.Window;
            lblHsSec.Cursor = Cursors.Default;
            lblHsSec.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblHsSec.ForeColor = SystemColors.ControlText;
            lblHsSec.Location = new Point(510, 101);
            lblHsSec.Name = "lblHsSec";
            lblHsSec.RightToLeft = RightToLeft.No;
            lblHsSec.Size = new Size(9, 17);
            lblHsSec.TabIndex = 27;
            lblHsSec.Text = "\"";
            lblHsSec.Visible = false;
            // 
            // lblIEMin
            // 
            lblIEMin.BackColor = SystemColors.Window;
            lblIEMin.Cursor = Cursors.Default;
            lblIEMin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblIEMin.ForeColor = SystemColors.ControlText;
            lblIEMin.Location = new Point(470, 123);
            lblIEMin.Name = "lblIEMin";
            lblIEMin.RightToLeft = RightToLeft.No;
            lblIEMin.Size = new Size(9, 17);
            lblIEMin.TabIndex = 25;
            lblIEMin.Text = "'";
            lblIEMin.Visible = false;
            // 
            // lblIEdeg
            // 
            lblIEdeg.BackColor = SystemColors.Window;
            lblIEdeg.Cursor = Cursors.Default;
            lblIEdeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblIEdeg.ForeColor = SystemColors.ControlText;
            lblIEdeg.Location = new Point(430, 123);
            lblIEdeg.Name = "lblIEdeg";
            lblIEdeg.RightToLeft = RightToLeft.No;
            lblIEdeg.Size = new Size(9, 17);
            lblIEdeg.TabIndex = 24;
            lblIEdeg.Text = "°";
            lblIEdeg.Visible = false;
            // 
            // lblIEsec
            // 
            lblIEsec.BackColor = SystemColors.Window;
            lblIEsec.Cursor = Cursors.Default;
            lblIEsec.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblIEsec.ForeColor = SystemColors.ControlText;
            lblIEsec.Location = new Point(510, 123);
            lblIEsec.Name = "lblIEsec";
            lblIEsec.RightToLeft = RightToLeft.No;
            lblIEsec.Size = new Size(9, 17);
            lblIEsec.TabIndex = 23;
            lblIEsec.Text = "\"";
            lblIEsec.Visible = false;
            // 
            // lblHO
            // 
            lblHO.BackColor = SystemColors.Window;
            lblHO.Cursor = Cursors.Default;
            lblHO.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblHO.ForeColor = SystemColors.ControlText;
            lblHO.Location = new Point(320, 49);
            lblHO.Name = "lblHO";
            lblHO.RightToLeft = RightToLeft.No;
            lblHO.Size = new Size(86, 17);
            lblHO.TabIndex = 17;
            lblHO.Text = "Height of Object";
            lblHO.TextAlign = ContentAlignment.MiddleLeft;
            lblHO.Visible = false;
            // 
            // TextBoxFormDistances
            // 
            TextBoxFormDistances.CausesValidation = false;
            TextBoxFormDistances.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TextBoxFormDistances.Location = new Point(256, 151);
            TextBoxFormDistances.Multiline = true;
            TextBoxFormDistances.Name = "TextBoxFormDistances";
            TextBoxFormDistances.ReadOnly = true;
            TextBoxFormDistances.ScrollBars = ScrollBars.Both;
            TextBoxFormDistances.Size = new Size(370, 98);
            TextBoxFormDistances.TabIndex = 34;
            TextBoxFormDistances.TextAlign = HorizontalAlignment.Center;
            // 
            // ExitBtn
            // 
            _ExitBtn.BackColor = Color.Red;
            _ExitBtn.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _ExitBtn.ForeColor = SystemColors.ControlLightLight;
            _ExitBtn.Location = new Point(535, 256);
            _ExitBtn.Name = "_ExitBtn";
            _ExitBtn.Size = new Size(90, 25);
            _ExitBtn.TabIndex = 35;
            _ExitBtn.Text = "Exit";
            _ExitBtn.UseVisualStyleBackColor = false;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.ABC_white;
            PictureBox1.Location = new Point(181, 256);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(316, 50);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 102;
            PictureBox1.TabStop = false;
            // 
            // FormDistances
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(631, 315);
            Controls.Add(PictureBox1);
            Controls.Add(_ExitBtn);
            Controls.Add(TextBoxFormDistances);
            Controls.Add(Frame1);
            Controls.Add(_txtHsDeg);
            Controls.Add(_txtHsMin);
            Controls.Add(_txtHsSec);
            Controls.Add(_txtIEmin);
            Controls.Add(cboIE);
            Controls.Add(Framehs);
            Controls.Add(_txtIEdeg);
            Controls.Add(_txtIESec);
            Controls.Add(_cmdPrint);
            Controls.Add(_cmdCalculate);
            Controls.Add(cboHO);
            Controls.Add(_txtHO);
            Controls.Add(cboHE);
            Controls.Add(_txtHE);
            Controls.Add(lblHsFormat);
            Controls.Add(lblHs);
            Controls.Add(lblHsDeg);
            Controls.Add(lblHsMin);
            Controls.Add(lblHsSec);
            Controls.Add(lblIE);
            Controls.Add(lblIEMin);
            Controls.Add(lblIEdeg);
            Controls.Add(lblIEsec);
            Controls.Add(lblHO);
            Controls.Add(lblHE);
            Cursor = Cursors.Default;
            Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(3, 435);
            MaximizeBox = false;
            Name = "FormDistances";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Distances";
            Frame1.ResumeLayout(false);
            Framehs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Load += new EventHandler(FormDistances_Load);
            FormClosed += new FormClosedEventHandler(FormDistances_FormClosed);
            ResumeLayout(false);
            PerformLayout();
        }

        internal TextBox TextBoxFormDistances;
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
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}