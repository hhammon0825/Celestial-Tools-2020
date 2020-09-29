using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    [DesignerGenerated()]
    internal partial class FormSightPlan
    {
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        [DebuggerNonUserCode()]
        public FormSightPlan() : base()
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
        private RadioButton _optCenter;

        public RadioButton optCenter
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optCenter;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optCenter != null)
                {
                    _optCenter.CheckedChanged -= optCenter_CheckedChanged;
                }

                _optCenter = value;
                if (_optCenter != null)
                {
                    _optCenter.CheckedChanged += optCenter_CheckedChanged;
                }
            }
        }

        private RadioButton _optLimb;

        public RadioButton optLimb
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optLimb;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optLimb != null)
                {
                    _optLimb.CheckedChanged -= optLimb_CheckedChanged;
                }

                _optLimb = value;
                if (_optLimb != null)
                {
                    _optLimb.CheckedChanged += optLimb_CheckedChanged;
                }
            }
        }

        public GroupBox FrameZn;
        public TextBox txtWarning;
        private TextBox _txtMinimumAltitude;

        public TextBox txtMinimumAltitude
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtMinimumAltitude;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtMinimumAltitude != null)
                {
                    _txtMinimumAltitude.TextChanged -= txtMinimumAltitude_TextChanged;
                    _txtMinimumAltitude.KeyPress -= txtMinimumAltitude_KeyPress;
                    _txtMinimumAltitude.Validating -= txtMinimumAltitude_Validating;
                    _txtMinimumAltitude.Enter -= txtMinimumAltitude_Enter;
                }

                _txtMinimumAltitude = value;
                if (_txtMinimumAltitude != null)
                {
                    _txtMinimumAltitude.TextChanged += txtMinimumAltitude_TextChanged;
                    _txtMinimumAltitude.KeyPress += txtMinimumAltitude_KeyPress;
                    _txtMinimumAltitude.Validating += txtMinimumAltitude_Validating;
                    _txtMinimumAltitude.Enter += txtMinimumAltitude_Enter;
                }
            }
        }

        private CheckBox _chkDST;

        public CheckBox chkDST
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _chkDST;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_chkDST != null)
                {
                    _chkDST.CheckedChanged -= chkDST_CheckedChanged;
                }

                _chkDST = value;
                if (_chkDST != null)
                {
                    _chkDST.CheckedChanged += chkDST_CheckedChanged;
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

        private TextBox _txtHighAz;

        public TextBox txtHighAz
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtHighAz;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtHighAz != null)
                {
                    _txtHighAz.TextChanged -= txtHighAz_TextChanged;
                    _txtHighAz.KeyPress -= txtHighAz_KeyPress;
                    _txtHighAz.Validating -= txtHighAz_Validating;
                    _txtHighAz.Enter -= txtHighAz_Enter;
                }

                _txtHighAz = value;
                if (_txtHighAz != null)
                {
                    _txtHighAz.TextChanged += txtHighAz_TextChanged;
                    _txtHighAz.KeyPress += txtHighAz_KeyPress;
                    _txtHighAz.Validating += txtHighAz_Validating;
                    _txtHighAz.Enter += txtHighAz_Enter;
                }
            }
        }

        private TextBox _txtLowAz;

        public TextBox txtLowAz
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtLowAz;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtLowAz != null)
                {
                    _txtLowAz.TextChanged -= txtLowAz_TextChanged;
                    _txtLowAz.KeyPress -= txtLowAz_KeyPress;
                    _txtLowAz.Validating -= txtLowAz_Validating;
                    _txtLowAz.Enter -= txtLowAz_Enter;
                    _txtLowAz.Leave -= txtLowAz_Leave;
                }

                _txtLowAz = value;
                if (_txtLowAz != null)
                {
                    _txtLowAz.TextChanged += txtLowAz_TextChanged;
                    _txtLowAz.KeyPress += txtLowAz_KeyPress;
                    _txtLowAz.Validating += txtLowAz_Validating;
                    _txtLowAz.Enter += txtLowAz_Enter;
                    _txtLowAz.Leave += txtLowAz_Leave;
                }
            }
        }

        public Label Label3;
        public Label Label2;
        public Label lblAzDeg;
        public Label lblAz1;
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

        private TextBox _txtZDh;

        public TextBox txtZDh
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtZDh;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtZDh != null)
                {
                    _txtZDh.TextChanged -= txtZDh_TextChanged;
                    _txtZDh.KeyPress -= txtZDh_KeyPress;
                    _txtZDh.Validating -= txtZDh_Validating;
                    _txtZDh.Enter -= txtZDh_Enter;
                }

                _txtZDh = value;
                if (_txtZDh != null)
                {
                    _txtZDh.TextChanged += txtZDh_TextChanged;
                    _txtZDh.KeyPress += txtZDh_KeyPress;
                    _txtZDh.Validating += txtZDh_Validating;
                    _txtZDh.Enter += txtZDh_Enter;
                }
            }
        }

        private RadioButton _optZDUT;

        public RadioButton optZDUT
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optZDUT;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optZDUT != null)
                {
                    _optZDUT.CheckedChanged -= optZDUT_CheckedChanged;
                }

                _optZDUT = value;
                if (_optZDUT != null)
                {
                    _optZDUT.CheckedChanged += optZDUT_CheckedChanged;
                }
            }
        }

        private RadioButton _optZDAuto;

        public RadioButton optZDAuto
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optZDAuto;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optZDAuto != null)
                {
                    _optZDAuto.CheckedChanged -= optZDAuto_CheckedChanged;
                }

                _optZDAuto = value;
                if (_optZDAuto != null)
                {
                    _optZDAuto.CheckedChanged += optZDAuto_CheckedChanged;
                }
            }
        }

        private RadioButton _optZDManual;

        public RadioButton optZDManual
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optZDManual;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optZDManual != null)
                {
                    _optZDManual.CheckedChanged -= optZDManual_CheckedChanged;
                }

                _optZDManual = value;
                if (_optZDManual != null)
                {
                    _optZDManual.CheckedChanged += optZDManual_CheckedChanged;
                }
            }
        }

        public Panel FrameZD;
        public ComboBox cboZDm;
        private Button _cmdTwilights;

        public Button cmdTwilights
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdTwilights;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdTwilights != null)
                {
                    _cmdTwilights.Click -= cmdTwilights_Click;
                }

                _cmdTwilights = value;
                if (_cmdTwilights != null)
                {
                    _cmdTwilights.Click += cmdTwilights_Click;
                }
            }
        }

        private ComboBox _cboLo;

        public ComboBox cboLo
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboLo;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboLo != null)
                {
                    _cboLo.SelectedIndexChanged -= cboLo_SelectedIndexChanged;
                }

                _cboLo = value;
                if (_cboLo != null)
                {
                    _cboLo.SelectedIndexChanged += cboLo_SelectedIndexChanged;
                }
            }
        }

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

        public ComboBox cboL;
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

        public Label lblAltDeg;
        public Label lblMinimumAltitude;
        public Label lblZDDST;
        // Public WithEvents Line4 As Microsoft.VisualBasic.PowerPacks.LineShape
        // Public WithEvents Line3 As Microsoft.VisualBasic.PowerPacks.LineShape
        // Public WithEvents Line2 As Microsoft.VisualBasic.PowerPacks.LineShape
        // Public WithEvents Line1 As Microsoft.VisualBasic.PowerPacks.LineShape
        public Label lblEnterTime;
        public Label WEZDAutoManual;
        public Label lblWEZD;
        public Label lblZDh;
        public Label lblZDm;
        public Label Label10;
        public Label Label9;
        public Label Label8;
        public Label lblDRLo;
        public Label Label6;
        public Label lblDRL;
        public Label lblDate;
        // Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSightPlan));
            var DataGridViewCellStyle7 = new DataGridViewCellStyle();
            var DataGridViewCellStyle8 = new DataGridViewCellStyle();
            var DataGridViewCellStyle9 = new DataGridViewCellStyle();
            var DataGridViewCellStyle10 = new DataGridViewCellStyle();
            var DataGridViewCellStyle11 = new DataGridViewCellStyle();
            var DataGridViewCellStyle12 = new DataGridViewCellStyle();
            _txtMinimumAltitude = new TextBox();
            _txtMinimumAltitude.TextChanged += new EventHandler(txtMinimumAltitude_TextChanged);
            _txtMinimumAltitude.KeyPress += new KeyPressEventHandler(txtMinimumAltitude_KeyPress);
            _txtMinimumAltitude.Validating += new System.ComponentModel.CancelEventHandler(txtMinimumAltitude_Validating);
            _txtMinimumAltitude.Enter += new EventHandler(txtMinimumAltitude_Enter);
            _chkDST = new CheckBox();
            _chkDST.CheckedChanged += new EventHandler(chkDST_CheckedChanged);
            _cmdPrint = new Button();
            _cmdPrint.Click += new EventHandler(cmdPrint_Click);
            _txtHighAz = new TextBox();
            _txtHighAz.TextChanged += new EventHandler(txtHighAz_TextChanged);
            _txtHighAz.KeyPress += new KeyPressEventHandler(txtHighAz_KeyPress);
            _txtHighAz.Validating += new System.ComponentModel.CancelEventHandler(txtHighAz_Validating);
            _txtHighAz.Enter += new EventHandler(txtHighAz_Enter);
            _txtLowAz = new TextBox();
            _txtLowAz.TextChanged += new EventHandler(txtLowAz_TextChanged);
            _txtLowAz.KeyPress += new KeyPressEventHandler(txtLowAz_KeyPress);
            _txtLowAz.Validating += new System.ComponentModel.CancelEventHandler(txtLowAz_Validating);
            _txtLowAz.Enter += new EventHandler(txtLowAz_Enter);
            _txtLowAz.Leave += new EventHandler(txtLowAz_Leave);
            lblAz1 = new Label();
            _txtTime = new TextBox();
            _txtTime.TextChanged += new EventHandler(txtTime_TextChanged);
            _txtTime.KeyPress += new KeyPressEventHandler(txtTime_KeyPress);
            _txtTime.Validating += new System.ComponentModel.CancelEventHandler(txtTime_Validating);
            _txtTime.Enter += new EventHandler(txtTime_Enter);
            _txtZDh = new TextBox();
            _txtZDh.TextChanged += new EventHandler(txtZDh_TextChanged);
            _txtZDh.KeyPress += new KeyPressEventHandler(txtZDh_KeyPress);
            _txtZDh.Validating += new System.ComponentModel.CancelEventHandler(txtZDh_Validating);
            _txtZDh.Enter += new EventHandler(txtZDh_Enter);
            _optZDAuto = new RadioButton();
            _optZDAuto.CheckedChanged += new EventHandler(optZDAuto_CheckedChanged);
            _optZDManual = new RadioButton();
            _optZDManual.CheckedChanged += new EventHandler(optZDManual_CheckedChanged);
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
            WEZDAutoManual = new Label();
            lblWEZD = new Label();
            _optThreeBeach = new RadioButton();
            _optThreeBeach.CheckedChanged += new EventHandler(optThreeBeach_CheckedChanged);
            _optThreeBoat = new RadioButton();
            _optThreeBoat.CheckedChanged += new EventHandler(optThreeBoat_CheckedChanged);
            FrameZn = new GroupBox();
            _optCenter = new RadioButton();
            _optCenter.CheckedChanged += new EventHandler(optCenter_CheckedChanged);
            _optLimb = new RadioButton();
            _optLimb.CheckedChanged += new EventHandler(optLimb_CheckedChanged);
            txtWarning = new TextBox();
            Label3 = new Label();
            Label2 = new Label();
            lblAzDeg = new Label();
            FrameZD = new Panel();
            _optZDUT = new RadioButton();
            _optZDUT.CheckedChanged += new EventHandler(optZDUT_CheckedChanged);
            cboZDm = new ComboBox();
            _cmdTwilights = new Button();
            _cmdTwilights.Click += new EventHandler(cmdTwilights_Click);
            _cboLo = new ComboBox();
            _cboLo.SelectedIndexChanged += new EventHandler(cboLo_SelectedIndexChanged);
            cboL = new ComboBox();
            lblAltDeg = new Label();
            lblMinimumAltitude = new Label();
            lblZDDST = new Label();
            lblEnterTime = new Label();
            lblZDh = new Label();
            lblZDm = new Label();
            Label10 = new Label();
            Label9 = new Label();
            Label8 = new Label();
            lblDRLo = new Label();
            Label6 = new Label();
            lblDRL = new Label();
            lblDate = new Label();
            MoonTxtBx = new RichTextBox();
            SunTxtBx = new RichTextBox();
            _ExitBtn = new Button();
            _ExitBtn.Click += new EventHandler(ExitBtn_Click);
            _Plan1TabCntl = new TabControl();
            _Plan1TabCntl.SelectedIndexChanged += new EventHandler(Plan1TabCntl_SelectedIndexChanged);
            ListVisiblePg = new TabPage();
            Shape1 = new TextBox();
            txtBx2 = new RichTextBox();
            TextBox4 = new TextBox();
            _DGMag3 = new DataGridView();
            _DGMag3.SelectionChanged += new EventHandler(DGMag3_SelectionChanged);
            TextBox3 = new TextBox();
            _DGMag2 = new DataGridView();
            _DGMag2.SelectionChanged += new EventHandler(DGMag2_SelectionChanged);
            TextBox2 = new TextBox();
            _DGMag1 = new DataGridView();
            _DGMag1.SelectionChanged += new EventHandler(DGMag1_SelectionChanged);
            ViewVisiblePg = new TabPage();
            TextBox1 = new TextBox();
            lblSLeft = new Label();
            lblSRight = new Label();
            _chkHelper = new CheckBox();
            _chkHelper.CheckStateChanged += new EventHandler(chkHelper_CheckStateChanged);
            _chkLimit = new CheckBox();
            _chkLimit.CheckStateChanged += new EventHandler(chkLimit_CheckStateChanged);
            _chkFirst = new CheckBox();
            _chkFirst.CheckStateChanged += new EventHandler(chkFirst_CheckStateChanged);
            _chkSecond = new CheckBox();
            _chkSecond.CheckStateChanged += new EventHandler(chkSecond_CheckStateChanged);
            _chkThird = new CheckBox();
            _chkThird.CheckStateChanged += new EventHandler(chkThird_CheckStateChanged);
            _chkNames = new CheckBox();
            _chkNames.CheckStateChanged += new EventHandler(chkNames_CheckStateChanged);
            lblBody = new Label();
            lblBodyName = new Label();
            lblAlt = new Label();
            lblAz = new Label();
            lblAzimuth = new Label();
            lblAltitude = new Label();
            Label7 = new Label();
            Label5 = new Label();
            lblW = new Label();
            lblE = new Label();
            lblS = new Label();
            lblN = new Label();
            _SkyPicBx = new PictureBox();
            _SkyPicBx.MouseDown += new MouseEventHandler(SkyPicBx_MouseDown);
            _SkyPicBx.MouseUp += new MouseEventHandler(SkyPicBx_MouseUp);
            _SkyPicBx.MouseMove += new MouseEventHandler(SkyPicBx_MouseMove);
            _SkyPicBx.MouseEnter += new EventHandler(SkyPicBx_MouseEnter);
            _SkyPicBx.MouseLeave += new EventHandler(SkyPicBx_MouseLeave);
            _SkyPicBx.Paint += new PaintEventHandler(SkyPicBx_Paint);
            FrameBest = new GroupBox();
            RotateIncr = new ComboBox();
            _ResetRotateBtn = new Button();
            _ResetRotateBtn.Click += new EventHandler(ResetRotateBtn_Click);
            _cmdCW = new Button();
            _cmdCW.MouseDown += new MouseEventHandler(cmdCW_MouseDown);
            _cmdCW.MouseUp += new MouseEventHandler(cmdCW_MouseUp);
            _cmdCCW = new Button();
            _cmdCCW.MouseDown += new MouseEventHandler(cmdCCW_MouseDown);
            _cmdCCW.MouseUp += new MouseEventHandler(cmdCCW_MouseUp);
            _optTwo = new RadioButton();
            _optTwo.CheckedChanged += new EventHandler(optTwo_CheckedChanged);
            _optOff = new RadioButton();
            _optOff.CheckedChanged += new EventHandler(optOff_CheckedChanged);
            FrameDirection = new GroupBox();
            _optW = new RadioButton();
            _optW.CheckedChanged += new EventHandler(optW_CheckedChanged);
            _optE = new RadioButton();
            _optE.CheckedChanged += new EventHandler(optE_CheckedChanged);
            _optS = new RadioButton();
            _optS.CheckedChanged += new EventHandler(optS_CheckedChanged);
            _optN = new RadioButton();
            _optN.CheckedChanged += new EventHandler(optN_CheckedChanged);
            FrameView = new GroupBox();
            _optHorizon = new RadioButton();
            _optHorizon.CheckedChanged += new EventHandler(optHorizon_CheckedChanged);
            _optStarFinder = new RadioButton();
            _optStarFinder.CheckedChanged += new EventHandler(optStarFinder_CheckedChanged);
            _optOverhead = new RadioButton();
            _optOverhead.CheckedChanged += new EventHandler(optOverhead_CheckedChanged);
            StarFinder1Pg = new TabPage();
            ReportTxtBx = new TextBox();
            SunRiseSunSet = new TabPage();
            _SunRiseSet = new PictureBox();
            _SunRiseSet.Paint += new PaintEventHandler(SunRiseSet_Paint);
            MoonTxtBxRight = new RichTextBox();
            ToolTip1 = new ToolTip(components);
            _DTPlan = new DateTimePicker();
            _DTPlan.ValueChanged += new EventHandler(DTPlan_ValueChanged);
            PictureBox1 = new PictureBox();
            txtUserInfo = new TextBox();
            Label1 = new Label();
            _chkNoonSightLAN = new CheckBox();
            _chkNoonSightLAN.CheckedChanged += new EventHandler(chkNoonSightLAN_CheckedChanged);
            txtLAN = new TextBox();
            _cboLineWidth = new ComboBox();
            _cboLineWidth.SelectedIndexChanged += new EventHandler(cboLineWidth_SelectedIndexChanged);
            lblLineWidth = new Label();
            txtIncreaseDT = new RichTextBox();
            _btnAdd1Hour = new Button();
            _btnAdd1Hour.Click += new EventHandler(btnAdd1Hour_Click);
            _btnAdd1Day = new Button();
            _btnAdd1Day.Click += new EventHandler(btnAdd1Day_Click);
            _btnAdd1Week = new Button();
            _btnAdd1Week.Click += new EventHandler(btnAdd1Week_Click);
            _btnAdd1Month = new Button();
            _btnAdd1Month.Click += new EventHandler(btnAdd1Month_Click);
            _btnAdd30Min = new Button();
            _btnAdd30Min.Click += new EventHandler(btnAdd30Min_Click);
            _btnAdd1Year = new Button();
            _btnAdd1Year.Click += new EventHandler(btnAdd1Year_Click);
            _btnSub1Year = new Button();
            _btnSub1Year.Click += new EventHandler(btnSub1Year_Click);
            _btnSub30Min = new Button();
            _btnSub30Min.Click += new EventHandler(btnSub30Min_Click);
            _btnSub1Month = new Button();
            _btnSub1Month.Click += new EventHandler(btnSub1Month_Click);
            _btnSub1Week = new Button();
            _btnSub1Week.Click += new EventHandler(btnSub1Week_Click);
            _btnSub1Day = new Button();
            _btnSub1Day.Click += new EventHandler(btnSub1Day_Click);
            _btnSub1Hour = new Button();
            _btnSub1Hour.Click += new EventHandler(btnSub1Hour_Click);
            txtDecreaseDT = new RichTextBox();
            _btnResetDTtoNow = new Button();
            _btnResetDTtoNow.Click += new EventHandler(btnResetDTtoNow_Click);
            FrameZn.SuspendLayout();
            FrameZD.SuspendLayout();
            _Plan1TabCntl.SuspendLayout();
            ListVisiblePg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_DGMag3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_DGMag2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_DGMag1).BeginInit();
            ViewVisiblePg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_SkyPicBx).BeginInit();
            FrameBest.SuspendLayout();
            FrameDirection.SuspendLayout();
            FrameView.SuspendLayout();
            StarFinder1Pg.SuspendLayout();
            SunRiseSunSet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_SunRiseSet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtMinimumAltitude
            // 
            _txtMinimumAltitude.AcceptsReturn = true;
            _txtMinimumAltitude.BackColor = SystemColors.Window;
            _txtMinimumAltitude.Cursor = Cursors.IBeam;
            _txtMinimumAltitude.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtMinimumAltitude.ForeColor = SystemColors.WindowText;
            _txtMinimumAltitude.Location = new Point(725, 61);
            _txtMinimumAltitude.MaxLength = 2;
            _txtMinimumAltitude.Name = "_txtMinimumAltitude";
            _txtMinimumAltitude.RightToLeft = RightToLeft.No;
            _txtMinimumAltitude.Size = new Size(25, 20);
            _txtMinimumAltitude.TabIndex = 27;
            _txtMinimumAltitude.Text = "15";
            // 
            // chkDST
            // 
            _chkDST.BackColor = SystemColors.Window;
            _chkDST.Cursor = Cursors.Default;
            _chkDST.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _chkDST.ForeColor = SystemColors.ControlText;
            _chkDST.Location = new Point(413, 62);
            _chkDST.Name = "_chkDST";
            _chkDST.RightToLeft = RightToLeft.No;
            _chkDST.Size = new Size(17, 17);
            _chkDST.TabIndex = 69;
            _chkDST.Text = "Check1";
            _chkDST.UseVisualStyleBackColor = false;
            // 
            // cmdPrint
            // 
            _cmdPrint.BackColor = SystemColors.Control;
            _cmdPrint.Cursor = Cursors.Default;
            _cmdPrint.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdPrint.ForeColor = SystemColors.ControlText;
            _cmdPrint.Image = (Image)resources.GetObject("cmdPrint.Image");
            _cmdPrint.Location = new Point(809, 4);
            _cmdPrint.Name = "_cmdPrint";
            _cmdPrint.RightToLeft = RightToLeft.No;
            _cmdPrint.Size = new Size(21, 21);
            _cmdPrint.TabIndex = 34;
            _cmdPrint.TextAlign = ContentAlignment.BottomCenter;
            _cmdPrint.UseVisualStyleBackColor = false;
            // 
            // txtHighAz
            // 
            _txtHighAz.AcceptsReturn = true;
            _txtHighAz.BackColor = SystemColors.Window;
            _txtHighAz.Cursor = Cursors.IBeam;
            _txtHighAz.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtHighAz.ForeColor = SystemColors.WindowText;
            _txtHighAz.Location = new Point(771, 39);
            _txtHighAz.MaxLength = 3;
            _txtHighAz.Name = "_txtHighAz";
            _txtHighAz.RightToLeft = RightToLeft.No;
            _txtHighAz.Size = new Size(25, 20);
            _txtHighAz.TabIndex = 39;
            _txtHighAz.Text = "360";
            // 
            // txtLowAz
            // 
            _txtLowAz.AcceptsReturn = true;
            _txtLowAz.BackColor = SystemColors.Window;
            _txtLowAz.Cursor = Cursors.IBeam;
            _txtLowAz.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtLowAz.ForeColor = SystemColors.WindowText;
            _txtLowAz.Location = new Point(725, 39);
            _txtLowAz.MaxLength = 3;
            _txtLowAz.Name = "_txtLowAz";
            _txtLowAz.RightToLeft = RightToLeft.No;
            _txtLowAz.Size = new Size(25, 20);
            _txtLowAz.TabIndex = 35;
            _txtLowAz.Text = "0";
            // 
            // lblAz1
            // 
            lblAz1.BackColor = SystemColors.Window;
            lblAz1.Cursor = Cursors.Default;
            lblAz1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblAz1.ForeColor = SystemColors.ControlText;
            lblAz1.Location = new Point(523, 43);
            lblAz1.Name = "lblAz1";
            lblAz1.RightToLeft = RightToLeft.No;
            lblAz1.Size = new Size(201, 17);
            lblAz1.TabIndex = 36;
            lblAz1.Text = "List/view visible bodies with azimuths from";
            // 
            // txtTime
            // 
            _txtTime.AcceptsReturn = true;
            _txtTime.BackColor = SystemColors.Window;
            _txtTime.Cursor = Cursors.IBeam;
            _txtTime.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtTime.ForeColor = SystemColors.WindowText;
            _txtTime.Location = new Point(387, 84);
            _txtTime.MaxLength = 4;
            _txtTime.Name = "_txtTime";
            _txtTime.ReadOnly = true;
            _txtTime.RightToLeft = RightToLeft.No;
            _txtTime.Size = new Size(40, 20);
            _txtTime.TabIndex = 26;
            _txtTime.Visible = false;
            // 
            // txtZDh
            // 
            _txtZDh.AcceptsReturn = true;
            _txtZDh.BackColor = SystemColors.Window;
            _txtZDh.Cursor = Cursors.IBeam;
            _txtZDh.Enabled = false;
            _txtZDh.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtZDh.ForeColor = SystemColors.WindowText;
            _txtZDh.Location = new Point(308, 61);
            _txtZDh.MaxLength = 3;
            _txtZDh.Name = "_txtZDh";
            _txtZDh.RightToLeft = RightToLeft.No;
            _txtZDh.Size = new Size(25, 20);
            _txtZDh.TabIndex = 22;
            // 
            // optZDAuto
            // 
            _optZDAuto.BackColor = SystemColors.Window;
            _optZDAuto.Checked = true;
            _optZDAuto.Cursor = Cursors.Default;
            _optZDAuto.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optZDAuto.ForeColor = SystemColors.ControlText;
            _optZDAuto.Location = new Point(5, 5);
            _optZDAuto.Name = "_optZDAuto";
            _optZDAuto.RightToLeft = RightToLeft.No;
            _optZDAuto.Size = new Size(49, 20);
            _optZDAuto.TabIndex = 19;
            _optZDAuto.TabStop = true;
            _optZDAuto.Text = "Auto";
            _optZDAuto.UseVisualStyleBackColor = false;
            // 
            // optZDManual
            // 
            _optZDManual.BackColor = SystemColors.Window;
            _optZDManual.Cursor = Cursors.Default;
            _optZDManual.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optZDManual.ForeColor = SystemColors.ControlText;
            _optZDManual.Location = new Point(55, 5);
            _optZDManual.Name = "_optZDManual";
            _optZDManual.RightToLeft = RightToLeft.No;
            _optZDManual.Size = new Size(67, 18);
            _optZDManual.TabIndex = 20;
            _optZDManual.TabStop = true;
            _optZDManual.Text = "Manual";
            _optZDManual.UseVisualStyleBackColor = false;
            // 
            // txtLoMin
            // 
            _txtLoMin.AcceptsReturn = true;
            _txtLoMin.BackColor = SystemColors.Window;
            _txtLoMin.Cursor = Cursors.IBeam;
            _txtLoMin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtLoMin.ForeColor = SystemColors.WindowText;
            _txtLoMin.Location = new Point(147, 78);
            _txtLoMin.MaxLength = 4;
            _txtLoMin.Name = "_txtLoMin";
            _txtLoMin.RightToLeft = RightToLeft.No;
            _txtLoMin.Size = new Size(33, 20);
            _txtLoMin.TabIndex = 15;
            // 
            // txtLoDeg
            // 
            _txtLoDeg.AcceptsReturn = true;
            _txtLoDeg.BackColor = SystemColors.Window;
            _txtLoDeg.Cursor = Cursors.IBeam;
            _txtLoDeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtLoDeg.ForeColor = SystemColors.WindowText;
            _txtLoDeg.Location = new Point(107, 78);
            _txtLoDeg.MaxLength = 3;
            _txtLoDeg.Name = "_txtLoDeg";
            _txtLoDeg.RightToLeft = RightToLeft.No;
            _txtLoDeg.Size = new Size(33, 20);
            _txtLoDeg.TabIndex = 13;
            // 
            // txtLMin
            // 
            _txtLMin.AcceptsReturn = true;
            _txtLMin.BackColor = SystemColors.Window;
            _txtLMin.Cursor = Cursors.IBeam;
            _txtLMin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtLMin.ForeColor = SystemColors.WindowText;
            _txtLMin.Location = new Point(147, 56);
            _txtLMin.MaxLength = 4;
            _txtLMin.Name = "_txtLMin";
            _txtLMin.RightToLeft = RightToLeft.No;
            _txtLMin.Size = new Size(33, 20);
            _txtLMin.TabIndex = 10;
            // 
            // txtLDeg
            // 
            _txtLDeg.AcceptsReturn = true;
            _txtLDeg.BackColor = SystemColors.Window;
            _txtLDeg.Cursor = Cursors.IBeam;
            _txtLDeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtLDeg.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(91)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            _txtLDeg.Location = new Point(107, 56);
            _txtLDeg.MaxLength = 2;
            _txtLDeg.Name = "_txtLDeg";
            _txtLDeg.RightToLeft = RightToLeft.No;
            _txtLDeg.Size = new Size(33, 20);
            _txtLDeg.TabIndex = 8;
            // 
            // WEZDAutoManual
            // 
            WEZDAutoManual.BackColor = SystemColors.Window;
            WEZDAutoManual.Cursor = Cursors.Default;
            WEZDAutoManual.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            WEZDAutoManual.ForeColor = SystemColors.ControlText;
            WEZDAutoManual.Location = new Point(253, 35);
            WEZDAutoManual.Name = "WEZDAutoManual";
            WEZDAutoManual.RightToLeft = RightToLeft.No;
            WEZDAutoManual.Size = new Size(42, 18);
            WEZDAutoManual.TabIndex = 18;
            WEZDAutoManual.Text = "ZD Opt";
            // 
            // lblWEZD
            // 
            lblWEZD.BackColor = SystemColors.Window;
            lblWEZD.Cursor = Cursors.Default;
            lblWEZD.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblWEZD.ForeColor = SystemColors.ControlText;
            lblWEZD.Location = new Point(254, 61);
            lblWEZD.Name = "lblWEZD";
            lblWEZD.RightToLeft = RightToLeft.No;
            lblWEZD.Size = new Size(42, 17);
            lblWEZD.TabIndex = 21;
            lblWEZD.Text = "ZD ";
            // 
            // optThreeBeach
            // 
            _optThreeBeach.BackColor = SystemColors.Window;
            _optThreeBeach.Cursor = Cursors.Default;
            _optThreeBeach.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optThreeBeach.ForeColor = SystemColors.ControlText;
            _optThreeBeach.Location = new Point(8, 64);
            _optThreeBeach.Name = "_optThreeBeach";
            _optThreeBeach.RightToLeft = RightToLeft.No;
            _optThreeBeach.Size = new Size(134, 17);
            _optThreeBeach.TabIndex = 79;
            _optThreeBeach.TabStop = true;
            _optThreeBeach.Text = "Three-body fix (beach)";
            _optThreeBeach.UseVisualStyleBackColor = false;
            // 
            // optThreeBoat
            // 
            _optThreeBoat.BackColor = SystemColors.Window;
            _optThreeBoat.Cursor = Cursors.Default;
            _optThreeBoat.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optThreeBoat.ForeColor = SystemColors.ControlText;
            _optThreeBoat.Location = new Point(8, 48);
            _optThreeBoat.Name = "_optThreeBoat";
            _optThreeBoat.RightToLeft = RightToLeft.No;
            _optThreeBoat.Size = new Size(128, 17);
            _optThreeBoat.TabIndex = 76;
            _optThreeBoat.TabStop = true;
            _optThreeBoat.Text = "Three-body fix (boat)";
            _optThreeBoat.UseVisualStyleBackColor = false;
            // 
            // FrameZn
            // 
            FrameZn.BackColor = SystemColors.Window;
            FrameZn.Controls.Add(_optCenter);
            FrameZn.Controls.Add(_optLimb);
            FrameZn.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FrameZn.ForeColor = SystemColors.ControlText;
            FrameZn.Location = new Point(521, 2);
            FrameZn.Name = "FrameZn";
            FrameZn.Padding = new Padding(0);
            FrameZn.RightToLeft = RightToLeft.No;
            FrameZn.Size = new Size(190, 35);
            FrameZn.TabIndex = 84;
            FrameZn.TabStop = false;
            FrameZn.Text = "Show Zn  when visible on horizon";
            // 
            // optCenter
            // 
            _optCenter.BackColor = SystemColors.Window;
            _optCenter.Cursor = Cursors.Default;
            _optCenter.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optCenter.ForeColor = SystemColors.ControlText;
            _optCenter.Location = new Point(116, 16);
            _optCenter.Name = "_optCenter";
            _optCenter.RightToLeft = RightToLeft.No;
            _optCenter.Size = new Size(57, 17);
            _optCenter.TabIndex = 86;
            _optCenter.TabStop = true;
            _optCenter.Text = "Center";
            _optCenter.UseVisualStyleBackColor = false;
            // 
            // optLimb
            // 
            _optLimb.BackColor = SystemColors.Window;
            _optLimb.Checked = true;
            _optLimb.Cursor = Cursors.Default;
            _optLimb.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optLimb.ForeColor = SystemColors.ControlText;
            _optLimb.Location = new Point(8, 16);
            _optLimb.Name = "_optLimb";
            _optLimb.RightToLeft = RightToLeft.No;
            _optLimb.Size = new Size(81, 17);
            _optLimb.TabIndex = 85;
            _optLimb.TabStop = true;
            _optLimb.Text = "Upper Limb";
            _optLimb.UseVisualStyleBackColor = false;
            // 
            // txtWarning
            // 
            txtWarning.AcceptsReturn = true;
            txtWarning.BackColor = Color.Blue;
            txtWarning.BorderStyle = BorderStyle.None;
            txtWarning.Cursor = Cursors.IBeam;
            txtWarning.Font = new Font("Tahoma", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtWarning.ForeColor = Color.Black;
            txtWarning.Location = new Point(433, 84);
            txtWarning.MaxLength = 0;
            txtWarning.Multiline = true;
            txtWarning.Name = "txtWarning";
            txtWarning.ReadOnly = true;
            txtWarning.RightToLeft = RightToLeft.No;
            txtWarning.Size = new Size(70, 20);
            txtWarning.TabIndex = 81;
            txtWarning.TextAlign = HorizontalAlignment.Center;
            txtWarning.Visible = false;
            // 
            // Label3
            // 
            Label3.BackColor = SystemColors.Window;
            Label3.Cursor = Cursors.Default;
            Label3.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.ForeColor = SystemColors.ControlText;
            Label3.Location = new Point(776, 40);
            Label3.Name = "Label3";
            Label3.RightToLeft = RightToLeft.No;
            Label3.Size = new Size(9, 17);
            Label3.TabIndex = 40;
            Label3.Text = "°";
            // 
            // Label2
            // 
            Label2.BackColor = SystemColors.Window;
            Label2.Cursor = Cursors.Default;
            Label2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = SystemColors.ControlText;
            Label2.Location = new Point(752, 41);
            Label2.Name = "Label2";
            Label2.RightToLeft = RightToLeft.No;
            Label2.Size = new Size(17, 15);
            Label2.TabIndex = 38;
            Label2.Text = "to";
            // 
            // lblAzDeg
            // 
            lblAzDeg.BackColor = SystemColors.Window;
            lblAzDeg.Cursor = Cursors.Default;
            lblAzDeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblAzDeg.ForeColor = SystemColors.ControlText;
            lblAzDeg.Location = new Point(702, 43);
            lblAzDeg.Name = "lblAzDeg";
            lblAzDeg.RightToLeft = RightToLeft.No;
            lblAzDeg.Size = new Size(9, 17);
            lblAzDeg.TabIndex = 37;
            lblAzDeg.Text = "°";
            // 
            // FrameZD
            // 
            FrameZD.BackColor = SystemColors.Window;
            FrameZD.Controls.Add(_optZDUT);
            FrameZD.Controls.Add(_optZDAuto);
            FrameZD.Controls.Add(_optZDManual);
            FrameZD.Cursor = Cursors.Default;
            FrameZD.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FrameZD.ForeColor = SystemColors.ControlText;
            FrameZD.Location = new Point(308, 30);
            FrameZD.Name = "FrameZD";
            FrameZD.RightToLeft = RightToLeft.No;
            FrameZD.Size = new Size(196, 28);
            FrameZD.TabIndex = 30;
            FrameZD.Text = "Frame1";
            // 
            // optZDUT
            // 
            _optZDUT.BackColor = SystemColors.Window;
            _optZDUT.Cursor = Cursors.Default;
            _optZDUT.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optZDUT.ForeColor = SystemColors.ControlText;
            _optZDUT.Location = new Point(117, 6);
            _optZDUT.Name = "_optZDUT";
            _optZDUT.RightToLeft = RightToLeft.No;
            _optZDUT.Size = new Size(75, 17);
            _optZDUT.TabIndex = 87;
            _optZDUT.TabStop = true;
            _optZDUT.Text = "UT (GMT)";
            _optZDUT.UseVisualStyleBackColor = false;
            // 
            // cboZDm
            // 
            cboZDm.BackColor = SystemColors.Window;
            cboZDm.Cursor = Cursors.Default;
            cboZDm.DropDownStyle = ComboBoxStyle.DropDownList;
            cboZDm.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboZDm.ForeColor = SystemColors.WindowText;
            cboZDm.Items.AddRange(new object[] { "00", "30", "45" });
            cboZDm.Location = new Point(348, 60);
            cboZDm.Name = "cboZDm";
            cboZDm.RightToLeft = RightToLeft.No;
            cboZDm.Size = new Size(41, 22);
            cboZDm.TabIndex = 23;
            cboZDm.Visible = false;
            // 
            // cmdTwilights
            // 
            _cmdTwilights.BackColor = Color.Yellow;
            _cmdTwilights.Cursor = Cursors.Default;
            _cmdTwilights.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdTwilights.ForeColor = SystemColors.ControlText;
            _cmdTwilights.Location = new Point(752, 142);
            _cmdTwilights.Name = "_cmdTwilights";
            _cmdTwilights.RightToLeft = RightToLeft.No;
            _cmdTwilights.Size = new Size(90, 36);
            _cmdTwilights.TabIndex = 24;
            _cmdTwilights.Text = " Display Sight Planning Data";
            _cmdTwilights.UseVisualStyleBackColor = false;
            // 
            // cboLo
            // 
            _cboLo.BackColor = SystemColors.Window;
            _cboLo.Cursor = Cursors.Default;
            _cboLo.DropDownStyle = ComboBoxStyle.DropDownList;
            _cboLo.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboLo.ForeColor = SystemColors.WindowText;
            _cboLo.Items.AddRange(new object[] { "W", "E" });
            _cboLo.Location = new Point(187, 78);
            _cboLo.Name = "_cboLo";
            _cboLo.RightToLeft = RightToLeft.No;
            _cboLo.Size = new Size(41, 22);
            _cboLo.TabIndex = 16;
            // 
            // cboL
            // 
            cboL.BackColor = SystemColors.Window;
            cboL.Cursor = Cursors.Default;
            cboL.DropDownStyle = ComboBoxStyle.DropDownList;
            cboL.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboL.ForeColor = SystemColors.WindowText;
            cboL.Items.AddRange(new object[] { "N", "S" });
            cboL.Location = new Point(187, 55);
            cboL.Name = "cboL";
            cboL.RightToLeft = RightToLeft.No;
            cboL.Size = new Size(41, 22);
            cboL.TabIndex = 11;
            // 
            // lblAltDeg
            // 
            lblAltDeg.BackColor = SystemColors.Window;
            lblAltDeg.Cursor = Cursors.Default;
            lblAltDeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblAltDeg.ForeColor = SystemColors.ControlText;
            lblAltDeg.Location = new Point(750, 61);
            lblAltDeg.Name = "lblAltDeg";
            lblAltDeg.RightToLeft = RightToLeft.No;
            lblAltDeg.Size = new Size(13, 17);
            lblAltDeg.TabIndex = 72;
            lblAltDeg.Text = "°";
            // 
            // lblMinimumAltitude
            // 
            lblMinimumAltitude.BackColor = SystemColors.Window;
            lblMinimumAltitude.Cursor = Cursors.Default;
            lblMinimumAltitude.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblMinimumAltitude.ForeColor = SystemColors.ControlText;
            lblMinimumAltitude.Location = new Point(524, 65);
            lblMinimumAltitude.Name = "lblMinimumAltitude";
            lblMinimumAltitude.RightToLeft = RightToLeft.No;
            lblMinimumAltitude.Size = new Size(199, 17);
            lblMinimumAltitude.TabIndex = 71;
            lblMinimumAltitude.Text = "Enter minimum altitude for Sun-Moon Fix";
            // 
            // lblZDDST
            // 
            lblZDDST.BackColor = SystemColors.Window;
            lblZDDST.Cursor = Cursors.Default;
            lblZDDST.Font = new Font("Times New Roman", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblZDDST.ForeColor = SystemColors.ControlText;
            lblZDDST.Location = new Point(430, 62);
            lblZDDST.Name = "lblZDDST";
            lblZDDST.RightToLeft = RightToLeft.No;
            lblZDDST.Size = new Size(30, 17);
            lblZDDST.TabIndex = 70;
            lblZDDST.Text = "DST";
            // 
            // lblEnterTime
            // 
            lblEnterTime.BackColor = SystemColors.Window;
            lblEnterTime.Cursor = Cursors.Default;
            lblEnterTime.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblEnterTime.ForeColor = SystemColors.ControlText;
            lblEnterTime.Location = new Point(253, 85);
            lblEnterTime.Name = "lblEnterTime";
            lblEnterTime.RightToLeft = RightToLeft.No;
            lblEnterTime.Size = new Size(110, 17);
            lblEnterTime.TabIndex = 25;
            lblEnterTime.Text = "ZT for body visibility:";
            lblEnterTime.TextAlign = ContentAlignment.MiddleCenter;
            lblEnterTime.Visible = false;
            // 
            // lblZDh
            // 
            lblZDh.BackColor = SystemColors.Window;
            lblZDh.Cursor = Cursors.Default;
            lblZDh.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblZDh.ForeColor = SystemColors.ControlText;
            lblZDh.Location = new Point(333, 61);
            lblZDh.Name = "lblZDh";
            lblZDh.RightToLeft = RightToLeft.No;
            lblZDh.Size = new Size(9, 17);
            lblZDh.TabIndex = 32;
            lblZDh.Text = "h";
            lblZDh.Visible = false;
            // 
            // lblZDm
            // 
            lblZDm.BackColor = SystemColors.Window;
            lblZDm.Cursor = Cursors.Default;
            lblZDm.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblZDm.ForeColor = SystemColors.ControlText;
            lblZDm.Location = new Point(389, 60);
            lblZDm.Name = "lblZDm";
            lblZDm.RightToLeft = RightToLeft.No;
            lblZDm.Size = new Size(12, 17);
            lblZDm.TabIndex = 31;
            lblZDm.Text = "m";
            lblZDm.Visible = false;
            // 
            // Label10
            // 
            Label10.BackColor = SystemColors.Window;
            Label10.Cursor = Cursors.Default;
            Label10.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label10.ForeColor = SystemColors.ControlText;
            Label10.Location = new Point(121, 81);
            Label10.Name = "Label10";
            Label10.RightToLeft = RightToLeft.No;
            Label10.Size = new Size(9, 20);
            Label10.TabIndex = 29;
            Label10.Text = "'";
            // 
            // Label9
            // 
            Label9.BackColor = SystemColors.Window;
            Label9.Cursor = Cursors.Default;
            Label9.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label9.ForeColor = SystemColors.ControlText;
            Label9.Location = new Point(121, 59);
            Label9.Name = "Label9";
            Label9.RightToLeft = RightToLeft.No;
            Label9.Size = new Size(9, 25);
            Label9.TabIndex = 28;
            Label9.Text = "'";
            // 
            // Label8
            // 
            Label8.BackColor = SystemColors.Window;
            Label8.Cursor = Cursors.Default;
            Label8.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label8.ForeColor = SystemColors.ControlText;
            Label8.Location = new Point(139, 81);
            Label8.Name = "Label8";
            Label8.RightToLeft = RightToLeft.No;
            Label8.Size = new Size(9, 17);
            Label8.TabIndex = 14;
            Label8.Text = "°";
            // 
            // lblDRLo
            // 
            lblDRLo.BackColor = SystemColors.Window;
            lblDRLo.Cursor = Cursors.Default;
            lblDRLo.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblDRLo.ForeColor = SystemColors.ControlText;
            lblDRLo.Location = new Point(45, 78);
            lblDRLo.Name = "lblDRLo";
            lblDRLo.RightToLeft = RightToLeft.No;
            lblDRLo.Size = new Size(50, 17);
            lblDRLo.TabIndex = 12;
            lblDRLo.Text = "DR Long";
            lblDRLo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label6
            // 
            Label6.BackColor = SystemColors.Window;
            Label6.Cursor = Cursors.Default;
            Label6.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label6.ForeColor = SystemColors.ControlText;
            Label6.Location = new Point(138, 59);
            Label6.Name = "Label6";
            Label6.RightToLeft = RightToLeft.No;
            Label6.Size = new Size(9, 17);
            Label6.TabIndex = 9;
            Label6.Text = "°";
            // 
            // lblDRL
            // 
            lblDRL.BackColor = SystemColors.Window;
            lblDRL.Cursor = Cursors.Default;
            lblDRL.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblDRL.ForeColor = SystemColors.ControlText;
            lblDRL.Location = new Point(45, 56);
            lblDRL.Name = "lblDRL";
            lblDRL.RightToLeft = RightToLeft.No;
            lblDRL.Size = new Size(40, 17);
            lblDRL.TabIndex = 7;
            lblDRL.Text = "DR Lat";
            lblDRL.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDate
            // 
            lblDate.BackColor = SystemColors.Window;
            lblDate.Cursor = Cursors.Default;
            lblDate.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblDate.ForeColor = SystemColors.ControlText;
            lblDate.Location = new Point(44, 35);
            lblDate.Name = "lblDate";
            lblDate.RightToLeft = RightToLeft.No;
            lblDate.Size = new Size(60, 17);
            lblDate.TabIndex = 0;
            lblDate.Text = "Date / Time";
            lblDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MoonTxtBx
            // 
            MoonTxtBx.BackColor = SystemColors.Window;
            MoonTxtBx.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            MoonTxtBx.Location = new Point(40, 196);
            MoonTxtBx.Name = "MoonTxtBx";
            MoonTxtBx.ReadOnly = true;
            MoonTxtBx.ScrollBars = RichTextBoxScrollBars.None;
            MoonTxtBx.Size = new Size(519, 17);
            MoonTxtBx.TabIndex = 90;
            MoonTxtBx.Text = "";
            // 
            // SunTxtBx
            // 
            SunTxtBx.BackColor = SystemColors.Window;
            SunTxtBx.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            SunTxtBx.Location = new Point(40, 105);
            SunTxtBx.Name = "SunTxtBx";
            SunTxtBx.ReadOnly = true;
            SunTxtBx.Size = new Size(696, 90);
            SunTxtBx.TabIndex = 91;
            SunTxtBx.Text = "";
            // 
            // ExitBtn
            // 
            _ExitBtn.BackColor = Color.Red;
            _ExitBtn.Cursor = Cursors.Default;
            _ExitBtn.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _ExitBtn.ForeColor = SystemColors.ControlLightLight;
            _ExitBtn.Location = new Point(753, 184);
            _ExitBtn.Name = "_ExitBtn";
            _ExitBtn.RightToLeft = RightToLeft.No;
            _ExitBtn.Size = new Size(90, 26);
            _ExitBtn.TabIndex = 98;
            _ExitBtn.Text = "Exit";
            _ExitBtn.UseVisualStyleBackColor = false;
            // 
            // Plan1TabCntl
            // 
            _Plan1TabCntl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            _Plan1TabCntl.Appearance = TabAppearance.Buttons;
            _Plan1TabCntl.Controls.Add(ListVisiblePg);
            _Plan1TabCntl.Controls.Add(ViewVisiblePg);
            _Plan1TabCntl.Controls.Add(StarFinder1Pg);
            _Plan1TabCntl.Controls.Add(SunRiseSunSet);
            _Plan1TabCntl.ItemSize = new Size(158, 21);
            _Plan1TabCntl.Location = new Point(1, 219);
            _Plan1TabCntl.Multiline = true;
            _Plan1TabCntl.Name = "_Plan1TabCntl";
            _Plan1TabCntl.RightToLeft = RightToLeft.Yes;
            _Plan1TabCntl.SelectedIndex = 0;
            _Plan1TabCntl.Size = new Size(844, 556);
            _Plan1TabCntl.TabIndex = 99;
            _Plan1TabCntl.TabStop = false;
            _Plan1TabCntl.Visible = false;
            // 
            // ListVisiblePg
            // 
            ListVisiblePg.AutoScroll = true;
            ListVisiblePg.BackColor = SystemColors.Window;
            ListVisiblePg.Controls.Add(Shape1);
            ListVisiblePg.Controls.Add(txtBx2);
            ListVisiblePg.Controls.Add(TextBox4);
            ListVisiblePg.Controls.Add(_DGMag3);
            ListVisiblePg.Controls.Add(TextBox3);
            ListVisiblePg.Controls.Add(_DGMag2);
            ListVisiblePg.Controls.Add(TextBox2);
            ListVisiblePg.Controls.Add(_DGMag1);
            ListVisiblePg.Location = new Point(4, 25);
            ListVisiblePg.Name = "ListVisiblePg";
            ListVisiblePg.Size = new Size(836, 527);
            ListVisiblePg.TabIndex = 2;
            ListVisiblePg.Text = "List Visible Bodies/ Sun & Moon Fix";
            // 
            // Shape1
            // 
            Shape1.Location = new Point(551, 419);
            Shape1.Multiline = true;
            Shape1.Name = "Shape1";
            Shape1.ReadOnly = true;
            Shape1.Size = new Size(247, 64);
            Shape1.TabIndex = 108;
            Shape1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBx2
            // 
            txtBx2.BackColor = SystemColors.Window;
            txtBx2.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            txtBx2.Location = new Point(49, 489);
            txtBx2.Name = "txtBx2";
            txtBx2.ReadOnly = true;
            txtBx2.RightToLeft = RightToLeft.No;
            txtBx2.ScrollBars = RichTextBoxScrollBars.Vertical;
            txtBx2.Size = new Size(742, 35);
            txtBx2.TabIndex = 107;
            txtBx2.Text = "Rows where h>=15 and <=75 appear in Light Gray (Stars) or Yellow (Sun) or LightGr" + "een (Moon and Planets)." + '\n' + "Rows where h<   15 and  > 75 appear Yellow (Sun) or Whit" + "e (Stars, Moon and Planets)." + '\n' + '\n';
            txtBx2.WordWrap = false;
            // 
            // TextBox4
            // 
            TextBox4.Font = new Font("Times New Roman", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            TextBox4.Location = new Point(548, 4);
            TextBox4.Name = "TextBox4";
            TextBox4.ReadOnly = true;
            TextBox4.Size = new Size(250, 20);
            TextBox4.TabIndex = 106;
            TextBox4.Text = "3rd Magnitude Stars";
            TextBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // DGMag3
            // 
            _DGMag3.AllowUserToAddRows = false;
            _DGMag3.AllowUserToDeleteRows = false;
            _DGMag3.AllowUserToResizeColumns = false;
            _DGMag3.AllowUserToResizeRows = false;
            DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            _DGMag3.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7;
            _DGMag3.BorderStyle = BorderStyle.Fixed3D;
            _DGMag3.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle8.BackColor = Color.Cyan;
            DataGridViewCellStyle8.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            _DGMag3.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8;
            _DGMag3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _DGMag3.Cursor = Cursors.Default;
            _DGMag3.EditMode = DataGridViewEditMode.EditProgrammatically;
            _DGMag3.Enabled = false;
            _DGMag3.Location = new Point(548, 27);
            _DGMag3.MultiSelect = false;
            _DGMag3.Name = "_DGMag3";
            _DGMag3.ReadOnly = true;
            _DGMag3.RightToLeft = RightToLeft.No;
            _DGMag3.RowHeadersVisible = false;
            _DGMag3.RowTemplate.ReadOnly = true;
            _DGMag3.Size = new Size(250, 386);
            _DGMag3.TabIndex = 105;
            // 
            // TextBox3
            // 
            TextBox3.Font = new Font("Times New Roman", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            TextBox3.Location = new Point(295, 4);
            TextBox3.Name = "TextBox3";
            TextBox3.ReadOnly = true;
            TextBox3.Size = new Size(250, 20);
            TextBox3.TabIndex = 104;
            TextBox3.Text = "2nd Magnitude Stars";
            TextBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // DGMag2
            // 
            _DGMag2.AllowUserToAddRows = false;
            _DGMag2.AllowUserToDeleteRows = false;
            _DGMag2.AllowUserToResizeColumns = false;
            _DGMag2.AllowUserToResizeRows = false;
            DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            _DGMag2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9;
            _DGMag2.BorderStyle = BorderStyle.Fixed3D;
            _DGMag2.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle10.BackColor = Color.Cyan;
            DataGridViewCellStyle10.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            _DGMag2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10;
            _DGMag2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _DGMag2.Cursor = Cursors.Default;
            _DGMag2.EditMode = DataGridViewEditMode.EditProgrammatically;
            _DGMag2.Location = new Point(295, 27);
            _DGMag2.MultiSelect = false;
            _DGMag2.Name = "_DGMag2";
            _DGMag2.ReadOnly = true;
            _DGMag2.RightToLeft = RightToLeft.No;
            _DGMag2.RowHeadersVisible = false;
            _DGMag2.RowTemplate.ReadOnly = true;
            _DGMag2.Size = new Size(250, 460);
            _DGMag2.TabIndex = 103;
            // 
            // TextBox2
            // 
            TextBox2.Font = new Font("Times New Roman", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            TextBox2.Location = new Point(41, 4);
            TextBox2.Name = "TextBox2";
            TextBox2.ReadOnly = true;
            TextBox2.Size = new Size(250, 20);
            TextBox2.TabIndex = 102;
            TextBox2.Text = "1st Mag Stars & Solar System Objects";
            TextBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // DGMag1
            // 
            _DGMag1.AllowUserToAddRows = false;
            _DGMag1.AllowUserToDeleteRows = false;
            _DGMag1.AllowUserToResizeColumns = false;
            _DGMag1.AllowUserToResizeRows = false;
            DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            _DGMag1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11;
            _DGMag1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            DataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle12.BackColor = Color.Cyan;
            DataGridViewCellStyle12.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            _DGMag1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12;
            _DGMag1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _DGMag1.Cursor = Cursors.Default;
            _DGMag1.EditMode = DataGridViewEditMode.EditProgrammatically;
            _DGMag1.Location = new Point(42, 27);
            _DGMag1.MultiSelect = false;
            _DGMag1.Name = "_DGMag1";
            _DGMag1.ReadOnly = true;
            _DGMag1.RightToLeft = RightToLeft.No;
            _DGMag1.RowHeadersVisible = false;
            _DGMag1.RowTemplate.ReadOnly = true;
            _DGMag1.Size = new Size(250, 460);
            _DGMag1.TabIndex = 100;
            // 
            // ViewVisiblePg
            // 
            ViewVisiblePg.AutoScroll = true;
            ViewVisiblePg.BackColor = SystemColors.Window;
            ViewVisiblePg.Controls.Add(TextBox1);
            ViewVisiblePg.Controls.Add(lblSLeft);
            ViewVisiblePg.Controls.Add(lblSRight);
            ViewVisiblePg.Controls.Add(_chkHelper);
            ViewVisiblePg.Controls.Add(_chkLimit);
            ViewVisiblePg.Controls.Add(_chkFirst);
            ViewVisiblePg.Controls.Add(_chkSecond);
            ViewVisiblePg.Controls.Add(_chkThird);
            ViewVisiblePg.Controls.Add(_chkNames);
            ViewVisiblePg.Controls.Add(lblBody);
            ViewVisiblePg.Controls.Add(lblBodyName);
            ViewVisiblePg.Controls.Add(lblAlt);
            ViewVisiblePg.Controls.Add(lblAz);
            ViewVisiblePg.Controls.Add(lblAzimuth);
            ViewVisiblePg.Controls.Add(lblAltitude);
            ViewVisiblePg.Controls.Add(Label7);
            ViewVisiblePg.Controls.Add(Label5);
            ViewVisiblePg.Controls.Add(lblW);
            ViewVisiblePg.Controls.Add(lblE);
            ViewVisiblePg.Controls.Add(lblS);
            ViewVisiblePg.Controls.Add(lblN);
            ViewVisiblePg.Controls.Add(_SkyPicBx);
            ViewVisiblePg.Controls.Add(FrameBest);
            ViewVisiblePg.Controls.Add(FrameDirection);
            ViewVisiblePg.Controls.Add(FrameView);
            ViewVisiblePg.Location = new Point(4, 25);
            ViewVisiblePg.Name = "ViewVisiblePg";
            ViewVisiblePg.Padding = new Padding(3);
            ViewVisiblePg.Size = new Size(836, 527);
            ViewVisiblePg.TabIndex = 1;
            ViewVisiblePg.Text = "View Visible Bodies";
            // 
            // TextBox1
            // 
            TextBox1.Location = new Point(667, 18);
            TextBox1.Multiline = true;
            TextBox1.Name = "TextBox1";
            TextBox1.ReadOnly = true;
            TextBox1.Size = new Size(119, 49);
            TextBox1.TabIndex = 114;
            TextBox1.Text = "Move Mouse Over" + '\r' + '\n' + "Body to Display its" + '\r' + '\n' + "Name, Az, Altitude";
            TextBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // lblSLeft
            // 
            lblSLeft.BackColor = Color.Transparent;
            lblSLeft.Cursor = Cursors.Default;
            lblSLeft.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblSLeft.ForeColor = SystemColors.ControlText;
            lblSLeft.Location = new Point(171, 510);
            lblSLeft.Name = "lblSLeft";
            lblSLeft.RightToLeft = RightToLeft.No;
            lblSLeft.Size = new Size(9, 12);
            lblSLeft.TabIndex = 113;
            lblSLeft.Text = "S";
            lblSLeft.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblSRight
            // 
            lblSRight.BackColor = Color.Transparent;
            lblSRight.Cursor = Cursors.Default;
            lblSRight.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblSRight.ForeColor = SystemColors.ControlText;
            lblSRight.Location = new Point(655, 510);
            lblSRight.Name = "lblSRight";
            lblSRight.RightToLeft = RightToLeft.No;
            lblSRight.Size = new Size(9, 12);
            lblSRight.TabIndex = 112;
            lblSRight.Text = "S";
            lblSRight.TextAlign = ContentAlignment.TopCenter;
            // 
            // chkHelper
            // 
            _chkHelper.BackColor = SystemColors.Window;
            _chkHelper.Cursor = Cursors.Default;
            _chkHelper.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _chkHelper.ForeColor = SystemColors.ControlText;
            _chkHelper.Location = new Point(8, 327);
            _chkHelper.Name = "_chkHelper";
            _chkHelper.RightToLeft = RightToLeft.No;
            _chkHelper.Size = new Size(105, 17);
            _chkHelper.TabIndex = 108;
            _chkHelper.Text = "Show Helpers";
            _chkHelper.UseVisualStyleBackColor = false;
            // 
            // chkLimit
            // 
            _chkLimit.BackColor = SystemColors.Window;
            _chkLimit.Cursor = Cursors.Default;
            _chkLimit.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _chkLimit.ForeColor = SystemColors.ControlText;
            _chkLimit.Location = new Point(8, 307);
            _chkLimit.Name = "_chkLimit";
            _chkLimit.RightToLeft = RightToLeft.No;
            _chkLimit.Size = new Size(121, 17);
            _chkLimit.TabIndex = 105;
            _chkLimit.Text = "Limit azimuth range";
            _chkLimit.UseVisualStyleBackColor = false;
            // 
            // chkFirst
            // 
            _chkFirst.BackColor = SystemColors.Window;
            _chkFirst.Checked = true;
            _chkFirst.CheckState = CheckState.Checked;
            _chkFirst.Cursor = Cursors.Default;
            _chkFirst.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _chkFirst.ForeColor = SystemColors.ControlText;
            _chkFirst.Location = new Point(9, 210);
            _chkFirst.Name = "_chkFirst";
            _chkFirst.RightToLeft = RightToLeft.No;
            _chkFirst.Size = new Size(149, 35);
            _chkFirst.TabIndex = 104;
            _chkFirst.Text = "1st Mag. Stars, Sun,Moon, Planets-Blue" + '\r' + '\n';
            _chkFirst.UseVisualStyleBackColor = false;
            // 
            // chkSecond
            // 
            _chkSecond.BackColor = SystemColors.Window;
            _chkSecond.Checked = true;
            _chkSecond.CheckState = CheckState.Checked;
            _chkSecond.Cursor = Cursors.Default;
            _chkSecond.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _chkSecond.ForeColor = SystemColors.ControlText;
            _chkSecond.Location = new Point(8, 245);
            _chkSecond.Name = "_chkSecond";
            _chkSecond.RightToLeft = RightToLeft.No;
            _chkSecond.Size = new Size(150, 21);
            _chkSecond.TabIndex = 103;
            _chkSecond.Text = "2nd Mag. Stars-DarkGray";
            _chkSecond.UseVisualStyleBackColor = false;
            // 
            // chkThird
            // 
            _chkThird.BackColor = SystemColors.Window;
            _chkThird.Checked = true;
            _chkThird.CheckState = CheckState.Checked;
            _chkThird.Cursor = Cursors.Default;
            _chkThird.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _chkThird.ForeColor = SystemColors.ControlText;
            _chkThird.Location = new Point(8, 264);
            _chkThird.Name = "_chkThird";
            _chkThird.RightToLeft = RightToLeft.No;
            _chkThird.Size = new Size(154, 25);
            _chkThird.TabIndex = 102;
            _chkThird.Text = "3rd Mag. Stars-LightGray";
            _chkThird.UseVisualStyleBackColor = false;
            // 
            // chkNames
            // 
            _chkNames.BackColor = SystemColors.Window;
            _chkNames.Checked = true;
            _chkNames.CheckState = CheckState.Checked;
            _chkNames.Cursor = Cursors.Default;
            _chkNames.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _chkNames.ForeColor = SystemColors.ControlText;
            _chkNames.Location = new Point(8, 287);
            _chkNames.Name = "_chkNames";
            _chkNames.RightToLeft = RightToLeft.No;
            _chkNames.Size = new Size(139, 18);
            _chkNames.TabIndex = 101;
            _chkNames.Text = "Show Names";
            _chkNames.UseVisualStyleBackColor = false;
            // 
            // lblBody
            // 
            lblBody.BackColor = SystemColors.Window;
            lblBody.Cursor = Cursors.Default;
            lblBody.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblBody.ForeColor = SystemColors.ControlText;
            lblBody.Location = new Point(664, 76);
            lblBody.Name = "lblBody";
            lblBody.RightToLeft = RightToLeft.No;
            lblBody.Size = new Size(35, 17);
            lblBody.TabIndex = 110;
            lblBody.Text = "Name";
            lblBody.TextAlign = ContentAlignment.MiddleCenter;
            lblBody.Visible = false;
            // 
            // lblBodyName
            // 
            lblBodyName.BackColor = SystemColors.Window;
            lblBodyName.BorderStyle = BorderStyle.Fixed3D;
            lblBodyName.Cursor = Cursors.Default;
            lblBodyName.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblBodyName.ForeColor = SystemColors.ControlText;
            lblBodyName.Location = new Point(699, 75);
            lblBodyName.Name = "lblBodyName";
            lblBodyName.RightToLeft = RightToLeft.No;
            lblBodyName.Size = new Size(90, 22);
            lblBodyName.TabIndex = 109;
            lblBodyName.TextAlign = ContentAlignment.TopCenter;
            lblBodyName.Visible = false;
            // 
            // lblAlt
            // 
            lblAlt.BackColor = SystemColors.Window;
            lblAlt.BorderStyle = BorderStyle.Fixed3D;
            lblAlt.Cursor = Cursors.Default;
            lblAlt.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblAlt.ForeColor = SystemColors.ControlText;
            lblAlt.Location = new Point(738, 123);
            lblAlt.Name = "lblAlt";
            lblAlt.RightToLeft = RightToLeft.No;
            lblAlt.Size = new Size(42, 17);
            lblAlt.TabIndex = 107;
            lblAlt.TextAlign = ContentAlignment.TopRight;
            lblAlt.Visible = false;
            // 
            // lblAz
            // 
            lblAz.BackColor = SystemColors.Window;
            lblAz.BorderStyle = BorderStyle.Fixed3D;
            lblAz.Cursor = Cursors.Default;
            lblAz.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblAz.ForeColor = SystemColors.ControlText;
            lblAz.Location = new Point(738, 99);
            lblAz.Name = "lblAz";
            lblAz.RightToLeft = RightToLeft.No;
            lblAz.Size = new Size(42, 17);
            lblAz.TabIndex = 106;
            lblAz.TextAlign = ContentAlignment.TopRight;
            lblAz.Visible = false;
            // 
            // lblAzimuth
            // 
            lblAzimuth.BackColor = SystemColors.Window;
            lblAzimuth.Cursor = Cursors.Default;
            lblAzimuth.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblAzimuth.ForeColor = SystemColors.ControlText;
            lblAzimuth.Location = new Point(690, 100);
            lblAzimuth.Name = "lblAzimuth";
            lblAzimuth.RightToLeft = RightToLeft.No;
            lblAzimuth.Size = new Size(48, 17);
            lblAzimuth.TabIndex = 100;
            lblAzimuth.Text = "Azimuth";
            lblAzimuth.TextAlign = ContentAlignment.MiddleCenter;
            lblAzimuth.Visible = false;
            // 
            // lblAltitude
            // 
            lblAltitude.BackColor = SystemColors.Window;
            lblAltitude.Cursor = Cursors.Default;
            lblAltitude.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblAltitude.ForeColor = SystemColors.ControlText;
            lblAltitude.Location = new Point(691, 124);
            lblAltitude.Name = "lblAltitude";
            lblAltitude.RightToLeft = RightToLeft.No;
            lblAltitude.Size = new Size(48, 17);
            lblAltitude.TabIndex = 99;
            lblAltitude.Text = "Altitude";
            lblAltitude.TextAlign = ContentAlignment.MiddleCenter;
            lblAltitude.Visible = false;
            // 
            // Label7
            // 
            Label7.BackColor = SystemColors.Window;
            Label7.Cursor = Cursors.Default;
            Label7.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label7.ForeColor = SystemColors.ControlText;
            Label7.Location = new Point(777, 99);
            Label7.Name = "Label7";
            Label7.RightToLeft = RightToLeft.No;
            Label7.Size = new Size(9, 17);
            Label7.TabIndex = 98;
            Label7.Text = "°";
            // 
            // Label5
            // 
            Label5.BackColor = SystemColors.Window;
            Label5.Cursor = Cursors.Default;
            Label5.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label5.ForeColor = SystemColors.ControlText;
            Label5.Location = new Point(777, 123);
            Label5.Name = "Label5";
            Label5.RightToLeft = RightToLeft.No;
            Label5.Size = new Size(9, 25);
            Label5.TabIndex = 97;
            Label5.Text = "°";
            Label5.Visible = false;
            // 
            // lblW
            // 
            lblW.BackColor = Color.Transparent;
            lblW.Cursor = Cursors.Default;
            lblW.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblW.ForeColor = SystemColors.ControlText;
            lblW.Location = new Point(670, 250);
            lblW.Name = "lblW";
            lblW.RightToLeft = RightToLeft.No;
            lblW.Size = new Size(12, 17);
            lblW.TabIndex = 96;
            lblW.Text = "W";
            lblW.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblE
            // 
            lblE.BackColor = Color.Transparent;
            lblE.Cursor = Cursors.Default;
            lblE.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblE.ForeColor = SystemColors.ControlText;
            lblE.Location = new Point(160, 249);
            lblE.Name = "lblE";
            lblE.RightToLeft = RightToLeft.No;
            lblE.Size = new Size(9, 17);
            lblE.TabIndex = 95;
            lblE.Text = "E";
            lblE.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblS
            // 
            lblS.BackColor = Color.Transparent;
            lblS.Cursor = Cursors.Default;
            lblS.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblS.ForeColor = SystemColors.ControlText;
            lblS.Location = new Point(416, 510);
            lblS.Name = "lblS";
            lblS.RightToLeft = RightToLeft.No;
            lblS.Size = new Size(9, 12);
            lblS.TabIndex = 94;
            lblS.Text = "S";
            lblS.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblN
            // 
            lblN.BackColor = Color.Transparent;
            lblN.Cursor = Cursors.Default;
            lblN.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblN.ForeColor = SystemColors.ControlText;
            lblN.Location = new Point(415, 0);
            lblN.Name = "lblN";
            lblN.RightToLeft = RightToLeft.No;
            lblN.Size = new Size(9, 17);
            lblN.TabIndex = 93;
            lblN.Text = "N";
            lblN.TextAlign = ContentAlignment.TopCenter;
            // 
            // SkyPicBx
            // 
            _SkyPicBx.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            _SkyPicBx.Cursor = Cursors.Default;
            _SkyPicBx.ErrorImage = null;
            _SkyPicBx.InitialImage = null;
            _SkyPicBx.Location = new Point(174, 18);
            _SkyPicBx.Name = "_SkyPicBx";
            _SkyPicBx.Size = new Size(490, 490);
            _SkyPicBx.TabIndex = 111;
            _SkyPicBx.TabStop = false;
            // 
            // FrameBest
            // 
            FrameBest.BackColor = SystemColors.Window;
            FrameBest.Controls.Add(RotateIncr);
            FrameBest.Controls.Add(_ResetRotateBtn);
            FrameBest.Controls.Add(_cmdCW);
            FrameBest.Controls.Add(_optThreeBeach);
            FrameBest.Controls.Add(_cmdCCW);
            FrameBest.Controls.Add(_optThreeBoat);
            FrameBest.Controls.Add(_optTwo);
            FrameBest.Controls.Add(_optOff);
            FrameBest.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FrameBest.ForeColor = SystemColors.ControlText;
            FrameBest.Location = new Point(3, 378);
            FrameBest.Name = "FrameBest";
            FrameBest.Padding = new Padding(0);
            FrameBest.RightToLeft = RightToLeft.No;
            FrameBest.Size = new Size(162, 145);
            FrameBest.TabIndex = 76;
            FrameBest.TabStop = false;
            FrameBest.Text = "Best Bodies Aid";
            // 
            // RotateIncr
            // 
            RotateIncr.BackColor = SystemColors.Control;
            RotateIncr.Enabled = false;
            RotateIncr.FormattingEnabled = true;
            RotateIncr.Items.AddRange(new object[] { "1", "5", "15", "30", "45", "90" });
            RotateIncr.Location = new Point(79, 118);
            RotateIncr.Name = "RotateIncr";
            RotateIncr.Size = new Size(76, 22);
            RotateIncr.TabIndex = 81;
            RotateIncr.Text = "Rotate Deg";
            // 
            // ResetRotateBtn
            // 
            _ResetRotateBtn.BackColor = SystemColors.Control;
            _ResetRotateBtn.Cursor = Cursors.Default;
            _ResetRotateBtn.Enabled = false;
            _ResetRotateBtn.Font = new Font("Arial Narrow", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _ResetRotateBtn.ForeColor = SystemColors.ControlText;
            _ResetRotateBtn.Location = new Point(4, 114);
            _ResetRotateBtn.Name = "_ResetRotateBtn";
            _ResetRotateBtn.RightToLeft = RightToLeft.No;
            _ResetRotateBtn.Size = new Size(72, 29);
            _ResetRotateBtn.TabIndex = 80;
            _ResetRotateBtn.Text = "Reset Rotate";
            _ResetRotateBtn.UseVisualStyleBackColor = false;
            // 
            // cmdCW
            // 
            _cmdCW.BackColor = SystemColors.Control;
            _cmdCW.Cursor = Cursors.Default;
            _cmdCW.Enabled = false;
            _cmdCW.Font = new Font("Arial Narrow", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdCW.ForeColor = SystemColors.ControlText;
            _cmdCW.Location = new Point(80, 83);
            _cmdCW.Name = "_cmdCW";
            _cmdCW.RightToLeft = RightToLeft.No;
            _cmdCW.Size = new Size(72, 29);
            _cmdCW.TabIndex = 78;
            _cmdCW.Text = "  Rotate CW";
            _cmdCW.UseVisualStyleBackColor = false;
            // 
            // cmdCCW
            // 
            _cmdCCW.BackColor = SystemColors.Control;
            _cmdCCW.Cursor = Cursors.Default;
            _cmdCCW.Enabled = false;
            _cmdCCW.Font = new Font("Arial Narrow", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdCCW.ForeColor = SystemColors.ControlText;
            _cmdCCW.Location = new Point(4, 83);
            _cmdCCW.Name = "_cmdCCW";
            _cmdCCW.RightToLeft = RightToLeft.No;
            _cmdCCW.Size = new Size(72, 29);
            _cmdCCW.TabIndex = 77;
            _cmdCCW.Text = "Rotate CCW";
            _cmdCCW.UseVisualStyleBackColor = false;
            // 
            // optTwo
            // 
            _optTwo.BackColor = SystemColors.Window;
            _optTwo.Cursor = Cursors.Default;
            _optTwo.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optTwo.ForeColor = SystemColors.ControlText;
            _optTwo.Location = new Point(8, 32);
            _optTwo.Name = "_optTwo";
            _optTwo.RightToLeft = RightToLeft.No;
            _optTwo.Size = new Size(89, 17);
            _optTwo.TabIndex = 75;
            _optTwo.TabStop = true;
            _optTwo.Text = "Two-body fix";
            _optTwo.UseVisualStyleBackColor = false;
            // 
            // optOff
            // 
            _optOff.BackColor = SystemColors.Window;
            _optOff.Checked = true;
            _optOff.Cursor = Cursors.Default;
            _optOff.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optOff.ForeColor = SystemColors.ControlText;
            _optOff.Location = new Point(8, 16);
            _optOff.Name = "_optOff";
            _optOff.RightToLeft = RightToLeft.No;
            _optOff.Size = new Size(49, 17);
            _optOff.TabIndex = 74;
            _optOff.TabStop = true;
            _optOff.Text = "Off";
            _optOff.UseVisualStyleBackColor = false;
            // 
            // FrameDirection
            // 
            FrameDirection.BackColor = SystemColors.Window;
            FrameDirection.Controls.Add(_optW);
            FrameDirection.Controls.Add(_optE);
            FrameDirection.Controls.Add(_optS);
            FrameDirection.Controls.Add(_optN);
            FrameDirection.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FrameDirection.ForeColor = SystemColors.ControlText;
            FrameDirection.Location = new Point(8, 84);
            FrameDirection.Name = "FrameDirection";
            FrameDirection.Padding = new Padding(0);
            FrameDirection.RightToLeft = RightToLeft.No;
            FrameDirection.Size = new Size(97, 89);
            FrameDirection.TabIndex = 75;
            FrameDirection.TabStop = false;
            FrameDirection.Text = "View toward";
            // 
            // optW
            // 
            _optW.BackColor = SystemColors.Window;
            _optW.Cursor = Cursors.Default;
            _optW.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optW.ForeColor = SystemColors.ControlText;
            _optW.Location = new Point(8, 64);
            _optW.Name = "_optW";
            _optW.RightToLeft = RightToLeft.No;
            _optW.Size = new Size(65, 17);
            _optW.TabIndex = 65;
            _optW.TabStop = true;
            _optW.Text = "West";
            _optW.UseVisualStyleBackColor = false;
            // 
            // optE
            // 
            _optE.BackColor = SystemColors.Window;
            _optE.Cursor = Cursors.Default;
            _optE.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optE.ForeColor = SystemColors.ControlText;
            _optE.Location = new Point(8, 48);
            _optE.Name = "_optE";
            _optE.RightToLeft = RightToLeft.No;
            _optE.Size = new Size(73, 17);
            _optE.TabIndex = 64;
            _optE.TabStop = true;
            _optE.Text = "East";
            _optE.UseVisualStyleBackColor = false;
            // 
            // optS
            // 
            _optS.BackColor = SystemColors.Window;
            _optS.Checked = true;
            _optS.Cursor = Cursors.Default;
            _optS.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optS.ForeColor = SystemColors.ControlText;
            _optS.Location = new Point(8, 32);
            _optS.Name = "_optS";
            _optS.RightToLeft = RightToLeft.No;
            _optS.Size = new Size(73, 17);
            _optS.TabIndex = 63;
            _optS.TabStop = true;
            _optS.Text = "South";
            _optS.UseVisualStyleBackColor = false;
            // 
            // optN
            // 
            _optN.BackColor = SystemColors.Window;
            _optN.Cursor = Cursors.Default;
            _optN.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optN.ForeColor = SystemColors.ControlText;
            _optN.Location = new Point(8, 16);
            _optN.Name = "_optN";
            _optN.RightToLeft = RightToLeft.No;
            _optN.Size = new Size(73, 17);
            _optN.TabIndex = 62;
            _optN.TabStop = true;
            _optN.Text = "North";
            _optN.UseVisualStyleBackColor = false;
            // 
            // FrameView
            // 
            FrameView.BackColor = SystemColors.Window;
            FrameView.Controls.Add(_optHorizon);
            FrameView.Controls.Add(_optStarFinder);
            FrameView.Controls.Add(_optOverhead);
            FrameView.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FrameView.ForeColor = SystemColors.ControlText;
            FrameView.Location = new Point(8, 7);
            FrameView.Name = "FrameView";
            FrameView.Padding = new Padding(0);
            FrameView.RightToLeft = RightToLeft.No;
            FrameView.Size = new Size(97, 73);
            FrameView.TabIndex = 74;
            FrameView.TabStop = false;
            FrameView.Text = "View";
            // 
            // optHorizon
            // 
            _optHorizon.BackColor = SystemColors.Window;
            _optHorizon.Cursor = Cursors.Default;
            _optHorizon.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optHorizon.ForeColor = SystemColors.ControlText;
            _optHorizon.Location = new Point(8, 49);
            _optHorizon.Name = "_optHorizon";
            _optHorizon.RightToLeft = RightToLeft.No;
            _optHorizon.Size = new Size(81, 17);
            _optHorizon.TabIndex = 60;
            _optHorizon.TabStop = true;
            _optHorizon.Text = "Horizon";
            _optHorizon.UseVisualStyleBackColor = false;
            // 
            // optStarFinder
            // 
            _optStarFinder.BackColor = SystemColors.Window;
            _optStarFinder.Cursor = Cursors.Default;
            _optStarFinder.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optStarFinder.ForeColor = SystemColors.ControlText;
            _optStarFinder.Location = new Point(8, 32);
            _optStarFinder.Name = "_optStarFinder";
            _optStarFinder.RightToLeft = RightToLeft.No;
            _optStarFinder.Size = new Size(86, 17);
            _optStarFinder.TabIndex = 58;
            _optStarFinder.TabStop = true;
            _optStarFinder.Text = "\"Star Finder\"";
            _optStarFinder.UseVisualStyleBackColor = false;
            // 
            // optOverhead
            // 
            _optOverhead.BackColor = SystemColors.Window;
            _optOverhead.Checked = true;
            _optOverhead.Cursor = Cursors.Default;
            _optOverhead.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optOverhead.ForeColor = SystemColors.ControlText;
            _optOverhead.Location = new Point(8, 15);
            _optOverhead.Name = "_optOverhead";
            _optOverhead.RightToLeft = RightToLeft.No;
            _optOverhead.Size = new Size(73, 17);
            _optOverhead.TabIndex = 57;
            _optOverhead.TabStop = true;
            _optOverhead.Text = "Overhead";
            _optOverhead.UseVisualStyleBackColor = false;
            // 
            // StarFinder1Pg
            // 
            StarFinder1Pg.BackColor = SystemColors.Window;
            StarFinder1Pg.Controls.Add(ReportTxtBx);
            StarFinder1Pg.Location = new Point(4, 25);
            StarFinder1Pg.Name = "StarFinder1Pg";
            StarFinder1Pg.Padding = new Padding(3);
            StarFinder1Pg.Size = new Size(836, 527);
            StarFinder1Pg.TabIndex = 0;
            StarFinder1Pg.Text = "Star Finder Data";
            // 
            // ReportTxtBx
            // 
            ReportTxtBx.BackColor = SystemColors.Window;
            ReportTxtBx.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            ReportTxtBx.Location = new Point(51, 6);
            ReportTxtBx.Multiline = true;
            ReportTxtBx.Name = "ReportTxtBx";
            ReportTxtBx.ReadOnly = true;
            ReportTxtBx.RightToLeft = RightToLeft.No;
            ReportTxtBx.ScrollBars = ScrollBars.Vertical;
            ReportTxtBx.Size = new Size(683, 475);
            ReportTxtBx.TabIndex = 95;
            // 
            // SunRiseSunSet
            // 
            SunRiseSunSet.Controls.Add(_SunRiseSet);
            SunRiseSunSet.Location = new Point(4, 25);
            SunRiseSunSet.Name = "SunRiseSunSet";
            SunRiseSunSet.Size = new Size(836, 527);
            SunRiseSunSet.TabIndex = 3;
            SunRiseSunSet.Text = "Rising / Setting Times";
            SunRiseSunSet.UseVisualStyleBackColor = true;
            // 
            // SunRiseSet
            // 
            _SunRiseSet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            _SunRiseSet.BackColor = Color.MediumTurquoise;
            _SunRiseSet.Cursor = Cursors.Default;
            _SunRiseSet.ErrorImage = null;
            _SunRiseSet.InitialImage = null;
            _SunRiseSet.Location = new Point(18, 4);
            _SunRiseSet.Name = "_SunRiseSet";
            _SunRiseSet.Size = new Size(800, 520);
            _SunRiseSet.TabIndex = 112;
            _SunRiseSet.TabStop = false;
            // 
            // MoonTxtBxRight
            // 
            MoonTxtBxRight.BackColor = SystemColors.Window;
            MoonTxtBxRight.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            MoonTxtBxRight.Location = new Point(560, 196);
            MoonTxtBxRight.Multiline = false;
            MoonTxtBxRight.Name = "MoonTxtBxRight";
            MoonTxtBxRight.ReadOnly = true;
            MoonTxtBxRight.ScrollBars = RichTextBoxScrollBars.None;
            MoonTxtBxRight.Size = new Size(176, 17);
            MoonTxtBxRight.TabIndex = 100;
            MoonTxtBxRight.Text = "";
            // 
            // DTPlan
            // 
            _DTPlan.CustomFormat = "MM / dd / yyyy HH:mm";
            _DTPlan.DropDownAlign = LeftRightAlignment.Right;
            _DTPlan.Format = DateTimePickerFormat.Custom;
            _DTPlan.Location = new Point(107, 32);
            _DTPlan.Name = "_DTPlan";
            _DTPlan.ShowUpDown = true;
            _DTPlan.Size = new Size(130, 21);
            _DTPlan.TabIndex = 102;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.ABC_white;
            PictureBox1.Location = new Point(255, 799);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(328, 45);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 101;
            PictureBox1.TabStop = false;
            // 
            // txtUserInfo
            // 
            txtUserInfo.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtUserInfo.HideSelection = false;
            txtUserInfo.Location = new Point(106, 5);
            txtUserInfo.Name = "txtUserInfo";
            txtUserInfo.Size = new Size(400, 22);
            txtUserInfo.TabIndex = 198;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.Location = new Point(45, 8);
            Label1.Name = "Label1";
            Label1.Size = new Size(57, 15);
            Label1.TabIndex = 197;
            Label1.Text = "User Info";
            Label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chkNoonSightLAN
            // 
            _chkNoonSightLAN.AutoSize = true;
            _chkNoonSightLAN.Location = new Point(527, 85);
            _chkNoonSightLAN.Name = "_chkNoonSightLAN";
            _chkNoonSightLAN.Size = new Size(240, 17);
            _chkNoonSightLAN.TabIndex = 199;
            _chkNoonSightLAN.Text = "Display Local Apparent Noon from NoonSight";
            _chkNoonSightLAN.UseVisualStyleBackColor = true;
            // 
            // txtLAN
            // 
            txtLAN.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtLAN.Location = new Point(770, 83);
            txtLAN.MaxLength = 8;
            txtLAN.Name = "txtLAN";
            txtLAN.ReadOnly = true;
            txtLAN.Size = new Size(60, 20);
            txtLAN.TabIndex = 200;
            txtLAN.Visible = false;
            // 
            // cboLineWidth
            // 
            _cboLineWidth.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboLineWidth.FormattingEnabled = true;
            _cboLineWidth.Items.AddRange(new object[] { "Thin", "Reg", "Wide", "XWide" });
            _cboLineWidth.Location = new Point(780, 110);
            _cboLineWidth.Name = "_cboLineWidth";
            _cboLineWidth.Size = new Size(60, 22);
            _cboLineWidth.TabIndex = 201;
            _cboLineWidth.Visible = false;
            // 
            // lblLineWidth
            // 
            lblLineWidth.AutoSize = true;
            lblLineWidth.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLineWidth.Location = new Point(738, 108);
            lblLineWidth.Name = "lblLineWidth";
            lblLineWidth.Size = new Size(37, 28);
            lblLineWidth.TabIndex = 202;
            lblLineWidth.Text = "Line " + '\r' + '\n' + "Width:";
            lblLineWidth.Visible = false;
            // 
            // txtIncreaseDT
            // 
            txtIncreaseDT.BackColor = Color.Yellow;
            txtIncreaseDT.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtIncreaseDT.Location = new Point(5, 775);
            txtIncreaseDT.Multiline = false;
            txtIncreaseDT.Name = "txtIncreaseDT";
            txtIncreaseDT.ReadOnly = true;
            txtIncreaseDT.ScrollBars = RichTextBoxScrollBars.None;
            txtIncreaseDT.Size = new Size(234, 21);
            txtIncreaseDT.TabIndex = 203;
            txtIncreaseDT.Text = "                      Increase Date/Time";
            // 
            // btnAdd1Hour
            // 
            _btnAdd1Hour.BackColor = Color.Silver;
            _btnAdd1Hour.Font = new Font("Arial Narrow", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnAdd1Hour.Location = new Point(85, 799);
            _btnAdd1Hour.Name = "_btnAdd1Hour";
            _btnAdd1Hour.Size = new Size(75, 23);
            _btnAdd1Hour.TabIndex = 205;
            _btnAdd1Hour.Text = "Add 1 Hour";
            _btnAdd1Hour.UseVisualStyleBackColor = false;
            // 
            // btnAdd1Day
            // 
            _btnAdd1Day.BackColor = Color.Silver;
            _btnAdd1Day.Font = new Font("Arial Narrow", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnAdd1Day.Location = new Point(164, 799);
            _btnAdd1Day.Name = "_btnAdd1Day";
            _btnAdd1Day.Size = new Size(75, 23);
            _btnAdd1Day.TabIndex = 206;
            _btnAdd1Day.Text = "Add 1 Day";
            _btnAdd1Day.UseVisualStyleBackColor = false;
            // 
            // btnAdd1Week
            // 
            _btnAdd1Week.BackColor = Color.Silver;
            _btnAdd1Week.Font = new Font("Arial Narrow", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnAdd1Week.Location = new Point(4, 822);
            _btnAdd1Week.Name = "_btnAdd1Week";
            _btnAdd1Week.Size = new Size(75, 23);
            _btnAdd1Week.TabIndex = 207;
            _btnAdd1Week.Text = "Add 1 Week";
            _btnAdd1Week.UseVisualStyleBackColor = false;
            // 
            // btnAdd1Month
            // 
            _btnAdd1Month.BackColor = Color.Silver;
            _btnAdd1Month.Font = new Font("Arial Narrow", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnAdd1Month.Location = new Point(85, 822);
            _btnAdd1Month.Name = "_btnAdd1Month";
            _btnAdd1Month.Size = new Size(75, 23);
            _btnAdd1Month.TabIndex = 208;
            _btnAdd1Month.Text = "Add 1 Month";
            _btnAdd1Month.UseVisualStyleBackColor = false;
            // 
            // btnAdd30Min
            // 
            _btnAdd30Min.BackColor = Color.Silver;
            _btnAdd30Min.Font = new Font("Arial Narrow", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnAdd30Min.Location = new Point(4, 799);
            _btnAdd30Min.Name = "_btnAdd30Min";
            _btnAdd30Min.Size = new Size(75, 23);
            _btnAdd30Min.TabIndex = 209;
            _btnAdd30Min.Text = "Add 30 Min";
            _btnAdd30Min.UseVisualStyleBackColor = false;
            // 
            // btnAdd1Year
            // 
            _btnAdd1Year.BackColor = Color.Silver;
            _btnAdd1Year.Font = new Font("Arial Narrow", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnAdd1Year.Location = new Point(164, 823);
            _btnAdd1Year.Name = "_btnAdd1Year";
            _btnAdd1Year.Size = new Size(75, 23);
            _btnAdd1Year.TabIndex = 210;
            _btnAdd1Year.Text = "Add 1 Year";
            _btnAdd1Year.UseVisualStyleBackColor = false;
            // 
            // btnSub1Year
            // 
            _btnSub1Year.BackColor = Color.Silver;
            _btnSub1Year.Font = new Font("Arial Narrow", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnSub1Year.Location = new Point(765, 823);
            _btnSub1Year.Name = "_btnSub1Year";
            _btnSub1Year.Size = new Size(75, 23);
            _btnSub1Year.TabIndex = 217;
            _btnSub1Year.Text = "Subt 1 Year";
            _btnSub1Year.UseVisualStyleBackColor = false;
            // 
            // btnSub30Min
            // 
            _btnSub30Min.BackColor = Color.Silver;
            _btnSub30Min.Font = new Font("Arial Narrow", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnSub30Min.Location = new Point(605, 799);
            _btnSub30Min.Name = "_btnSub30Min";
            _btnSub30Min.Size = new Size(75, 23);
            _btnSub30Min.TabIndex = 216;
            _btnSub30Min.Text = "Subt 30 Min";
            _btnSub30Min.UseVisualStyleBackColor = false;
            // 
            // btnSub1Month
            // 
            _btnSub1Month.BackColor = Color.Silver;
            _btnSub1Month.Font = new Font("Arial Narrow", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnSub1Month.Location = new Point(686, 822);
            _btnSub1Month.Name = "_btnSub1Month";
            _btnSub1Month.Size = new Size(75, 23);
            _btnSub1Month.TabIndex = 215;
            _btnSub1Month.Text = "Subt 1 Month";
            _btnSub1Month.UseVisualStyleBackColor = false;
            // 
            // btnSub1Week
            // 
            _btnSub1Week.BackColor = Color.Silver;
            _btnSub1Week.Font = new Font("Arial Narrow", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnSub1Week.Location = new Point(605, 822);
            _btnSub1Week.Name = "_btnSub1Week";
            _btnSub1Week.Size = new Size(75, 23);
            _btnSub1Week.TabIndex = 214;
            _btnSub1Week.Text = "Subt 1 Week";
            _btnSub1Week.UseVisualStyleBackColor = false;
            // 
            // btnSub1Day
            // 
            _btnSub1Day.BackColor = Color.Silver;
            _btnSub1Day.Font = new Font("Arial Narrow", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnSub1Day.Location = new Point(765, 799);
            _btnSub1Day.Name = "_btnSub1Day";
            _btnSub1Day.Size = new Size(75, 23);
            _btnSub1Day.TabIndex = 213;
            _btnSub1Day.Text = "Subt 1 Day";
            _btnSub1Day.UseVisualStyleBackColor = false;
            // 
            // btnSub1Hour
            // 
            _btnSub1Hour.BackColor = Color.Silver;
            _btnSub1Hour.Font = new Font("Arial Narrow", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnSub1Hour.Location = new Point(686, 799);
            _btnSub1Hour.Name = "_btnSub1Hour";
            _btnSub1Hour.Size = new Size(75, 23);
            _btnSub1Hour.TabIndex = 212;
            _btnSub1Hour.Text = "Subt 1 Hour";
            _btnSub1Hour.UseVisualStyleBackColor = false;
            // 
            // txtDecreaseDT
            // 
            txtDecreaseDT.BackColor = Color.Blue;
            txtDecreaseDT.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtDecreaseDT.ForeColor = Color.White;
            txtDecreaseDT.Location = new Point(606, 775);
            txtDecreaseDT.Multiline = false;
            txtDecreaseDT.Name = "txtDecreaseDT";
            txtDecreaseDT.ReadOnly = true;
            txtDecreaseDT.ScrollBars = RichTextBoxScrollBars.None;
            txtDecreaseDT.Size = new Size(234, 21);
            txtDecreaseDT.TabIndex = 211;
            txtDecreaseDT.Text = "                      Decrease Date/Time";
            // 
            // btnResetDTtoNow
            // 
            _btnResetDTtoNow.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(192)));
            _btnResetDTtoNow.Location = new Point(329, 774);
            _btnResetDTtoNow.Name = "_btnResetDTtoNow";
            _btnResetDTtoNow.Size = new Size(175, 23);
            _btnResetDTtoNow.TabIndex = 218;
            _btnResetDTtoNow.Text = "Reset Date / Time to Now";
            _btnResetDTtoNow.UseVisualStyleBackColor = false;
            // 
            // FormSightPlan
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Window;
            ClientSize = new Size(852, 852);
            Controls.Add(_btnResetDTtoNow);
            Controls.Add(_btnSub1Year);
            Controls.Add(_btnSub30Min);
            Controls.Add(_btnSub1Month);
            Controls.Add(_btnSub1Week);
            Controls.Add(_btnSub1Day);
            Controls.Add(_btnSub1Hour);
            Controls.Add(txtDecreaseDT);
            Controls.Add(_btnAdd1Year);
            Controls.Add(_btnAdd30Min);
            Controls.Add(_btnAdd1Month);
            Controls.Add(_btnAdd1Week);
            Controls.Add(_btnAdd1Day);
            Controls.Add(_btnAdd1Hour);
            Controls.Add(txtIncreaseDT);
            Controls.Add(lblLineWidth);
            Controls.Add(_cboLineWidth);
            Controls.Add(txtLAN);
            Controls.Add(_chkNoonSightLAN);
            Controls.Add(txtUserInfo);
            Controls.Add(Label1);
            Controls.Add(MoonTxtBxRight);
            Controls.Add(_DTPlan);
            Controls.Add(PictureBox1);
            Controls.Add(_txtHighAz);
            Controls.Add(lblAz1);
            Controls.Add(_txtLowAz);
            Controls.Add(lblAzDeg);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(_Plan1TabCntl);
            Controls.Add(txtWarning);
            Controls.Add(_ExitBtn);
            Controls.Add(SunTxtBx);
            Controls.Add(MoonTxtBx);
            Controls.Add(FrameZn);
            Controls.Add(_txtMinimumAltitude);
            Controls.Add(_chkDST);
            Controls.Add(_cmdPrint);
            Controls.Add(_txtTime);
            Controls.Add(_txtZDh);
            Controls.Add(FrameZD);
            Controls.Add(cboZDm);
            Controls.Add(_cmdTwilights);
            Controls.Add(_cboLo);
            Controls.Add(_txtLoMin);
            Controls.Add(_txtLoDeg);
            Controls.Add(cboL);
            Controls.Add(_txtLMin);
            Controls.Add(_txtLDeg);
            Controls.Add(lblAltDeg);
            Controls.Add(lblMinimumAltitude);
            Controls.Add(lblZDDST);
            Controls.Add(lblEnterTime);
            Controls.Add(lblZDh);
            Controls.Add(lblZDm);
            Controls.Add(Label10);
            Controls.Add(Label9);
            Controls.Add(Label8);
            Controls.Add(lblDRLo);
            Controls.Add(Label6);
            Controls.Add(lblDRL);
            Controls.Add(lblDate);
            Controls.Add(WEZDAutoManual);
            Controls.Add(lblWEZD);
            Cursor = Cursors.Default;
            Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            ForeColor = SystemColors.WindowText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(99, 29);
            MaximizeBox = false;
            Name = "FormSightPlan";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.Manual;
            Text = "Sight Planner";
            FrameZn.ResumeLayout(false);
            FrameZD.ResumeLayout(false);
            _Plan1TabCntl.ResumeLayout(false);
            ListVisiblePg.ResumeLayout(false);
            ListVisiblePg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_DGMag3).EndInit();
            ((System.ComponentModel.ISupportInitialize)_DGMag2).EndInit();
            ((System.ComponentModel.ISupportInitialize)_DGMag1).EndInit();
            ViewVisiblePg.ResumeLayout(false);
            ViewVisiblePg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_SkyPicBx).EndInit();
            FrameBest.ResumeLayout(false);
            FrameDirection.ResumeLayout(false);
            FrameView.ResumeLayout(false);
            StarFinder1Pg.ResumeLayout(false);
            StarFinder1Pg.PerformLayout();
            SunRiseSunSet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_SunRiseSet).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Load += new EventHandler(FormSightPlan_Load);
            FormClosed += new FormClosedEventHandler(FormSightPlan_FormClosed);
            ResumeLayout(false);
            PerformLayout();
        }

        internal RichTextBox MoonTxtBx;
        internal RichTextBox SunTxtBx;
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

        private TabControl _Plan1TabCntl;

        internal TabControl Plan1TabCntl
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Plan1TabCntl;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Plan1TabCntl != null)
                {
                    _Plan1TabCntl.SelectedIndexChanged -= Plan1TabCntl_SelectedIndexChanged;
                }

                _Plan1TabCntl = value;
                if (_Plan1TabCntl != null)
                {
                    _Plan1TabCntl.SelectedIndexChanged += Plan1TabCntl_SelectedIndexChanged;
                }
            }
        }

        internal TabPage ListVisiblePg;
        internal TabPage ViewVisiblePg;
        private CheckBox _chkHelper;

        public CheckBox chkHelper
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _chkHelper;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_chkHelper != null)
                {
                    _chkHelper.CheckStateChanged -= chkHelper_CheckStateChanged;
                }

                _chkHelper = value;
                if (_chkHelper != null)
                {
                    _chkHelper.CheckStateChanged += chkHelper_CheckStateChanged;
                }
            }
        }

        private CheckBox _chkLimit;

        public CheckBox chkLimit
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _chkLimit;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_chkLimit != null)
                {
                    _chkLimit.CheckStateChanged -= chkLimit_CheckStateChanged;
                }

                _chkLimit = value;
                if (_chkLimit != null)
                {
                    _chkLimit.CheckStateChanged += chkLimit_CheckStateChanged;
                }
            }
        }

        private CheckBox _chkFirst;

        public CheckBox chkFirst
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _chkFirst;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_chkFirst != null)
                {
                    _chkFirst.CheckStateChanged -= chkFirst_CheckStateChanged;
                }

                _chkFirst = value;
                if (_chkFirst != null)
                {
                    _chkFirst.CheckStateChanged += chkFirst_CheckStateChanged;
                }
            }
        }

        private CheckBox _chkSecond;

        public CheckBox chkSecond
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _chkSecond;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_chkSecond != null)
                {
                    _chkSecond.CheckStateChanged -= chkSecond_CheckStateChanged;
                }

                _chkSecond = value;
                if (_chkSecond != null)
                {
                    _chkSecond.CheckStateChanged += chkSecond_CheckStateChanged;
                }
            }
        }

        private CheckBox _chkThird;

        public CheckBox chkThird
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _chkThird;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_chkThird != null)
                {
                    _chkThird.CheckStateChanged -= chkThird_CheckStateChanged;
                }

                _chkThird = value;
                if (_chkThird != null)
                {
                    _chkThird.CheckStateChanged += chkThird_CheckStateChanged;
                }
            }
        }

        private CheckBox _chkNames;

        public CheckBox chkNames
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _chkNames;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_chkNames != null)
                {
                    _chkNames.CheckStateChanged -= chkNames_CheckStateChanged;
                }

                _chkNames = value;
                if (_chkNames != null)
                {
                    _chkNames.CheckStateChanged += chkNames_CheckStateChanged;
                }
            }
        }

        public Label lblBody;
        public Label lblBodyName;
        public Label lblAlt;
        public Label lblAz;
        public Label lblAzimuth;
        public Label lblAltitude;
        public Label Label7;
        public Label Label5;
        public Label lblW;
        public Label lblE;
        public Label lblS;
        public Label lblN;
        private PictureBox _SkyPicBx;

        internal PictureBox SkyPicBx
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SkyPicBx;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SkyPicBx != null)
                {
                    _SkyPicBx.MouseDown -= SkyPicBx_MouseDown;
                    _SkyPicBx.MouseUp -= SkyPicBx_MouseUp;
                    _SkyPicBx.MouseMove -= SkyPicBx_MouseMove;
                    _SkyPicBx.MouseEnter -= SkyPicBx_MouseEnter;
                    _SkyPicBx.MouseLeave -= SkyPicBx_MouseLeave;
                    _SkyPicBx.Paint -= SkyPicBx_Paint;
                }

                _SkyPicBx = value;
                if (_SkyPicBx != null)
                {
                    _SkyPicBx.MouseDown += SkyPicBx_MouseDown;
                    _SkyPicBx.MouseUp += SkyPicBx_MouseUp;
                    _SkyPicBx.MouseMove += SkyPicBx_MouseMove;
                    _SkyPicBx.MouseEnter += SkyPicBx_MouseEnter;
                    _SkyPicBx.MouseLeave += SkyPicBx_MouseLeave;
                    _SkyPicBx.Paint += SkyPicBx_Paint;
                }
            }
        }

        public GroupBox FrameBest;
        private RadioButton _optThreeBeach;

        public RadioButton optThreeBeach
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optThreeBeach;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optThreeBeach != null)
                {
                    _optThreeBeach.CheckedChanged -= optThreeBeach_CheckedChanged;
                }

                _optThreeBeach = value;
                if (_optThreeBeach != null)
                {
                    _optThreeBeach.CheckedChanged += optThreeBeach_CheckedChanged;
                }
            }
        }

        private Button _cmdCW;

        public Button cmdCW
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdCW;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdCW != null)
                {
                    _cmdCW.MouseDown -= cmdCW_MouseDown;
                    _cmdCW.MouseUp -= cmdCW_MouseUp;
                }

                _cmdCW = value;
                if (_cmdCW != null)
                {
                    _cmdCW.MouseDown += cmdCW_MouseDown;
                    _cmdCW.MouseUp += cmdCW_MouseUp;
                }
            }
        }

        private Button _cmdCCW;

        public Button cmdCCW
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdCCW;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdCCW != null)
                {
                    _cmdCCW.MouseDown -= cmdCCW_MouseDown;
                    _cmdCCW.MouseUp -= cmdCCW_MouseUp;
                }

                _cmdCCW = value;
                if (_cmdCCW != null)
                {
                    _cmdCCW.MouseDown += cmdCCW_MouseDown;
                    _cmdCCW.MouseUp += cmdCCW_MouseUp;
                }
            }
        }

        private RadioButton _optThreeBoat;

        public RadioButton optThreeBoat
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optThreeBoat;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optThreeBoat != null)
                {
                    _optThreeBoat.CheckedChanged -= optThreeBoat_CheckedChanged;
                }

                _optThreeBoat = value;
                if (_optThreeBoat != null)
                {
                    _optThreeBoat.CheckedChanged += optThreeBoat_CheckedChanged;
                }
            }
        }

        private RadioButton _optTwo;

        public RadioButton optTwo
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optTwo;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optTwo != null)
                {
                    _optTwo.CheckedChanged -= optTwo_CheckedChanged;
                }

                _optTwo = value;
                if (_optTwo != null)
                {
                    _optTwo.CheckedChanged += optTwo_CheckedChanged;
                }
            }
        }

        private RadioButton _optOff;

        public RadioButton optOff
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optOff;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optOff != null)
                {
                    _optOff.CheckedChanged -= optOff_CheckedChanged;
                }

                _optOff = value;
                if (_optOff != null)
                {
                    _optOff.CheckedChanged += optOff_CheckedChanged;
                }
            }
        }

        public GroupBox FrameDirection;
        private RadioButton _optW;

        public RadioButton optW
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optW;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optW != null)
                {
                    _optW.CheckedChanged -= optW_CheckedChanged;
                }

                _optW = value;
                if (_optW != null)
                {
                    _optW.CheckedChanged += optW_CheckedChanged;
                }
            }
        }

        private RadioButton _optE;

        public RadioButton optE
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optE;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optE != null)
                {
                    _optE.CheckedChanged -= optE_CheckedChanged;
                }

                _optE = value;
                if (_optE != null)
                {
                    _optE.CheckedChanged += optE_CheckedChanged;
                }
            }
        }

        private RadioButton _optS;

        public RadioButton optS
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optS;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optS != null)
                {
                    _optS.CheckedChanged -= optS_CheckedChanged;
                }

                _optS = value;
                if (_optS != null)
                {
                    _optS.CheckedChanged += optS_CheckedChanged;
                }
            }
        }

        private RadioButton _optN;

        public RadioButton optN
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optN;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optN != null)
                {
                    _optN.CheckedChanged -= optN_CheckedChanged;
                }

                _optN = value;
                if (_optN != null)
                {
                    _optN.CheckedChanged += optN_CheckedChanged;
                }
            }
        }

        public GroupBox FrameView;
        private RadioButton _optHorizon;

        public RadioButton optHorizon
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optHorizon;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optHorizon != null)
                {
                    _optHorizon.CheckedChanged -= optHorizon_CheckedChanged;
                }

                _optHorizon = value;
                if (_optHorizon != null)
                {
                    _optHorizon.CheckedChanged += optHorizon_CheckedChanged;
                }
            }
        }

        private RadioButton _optStarFinder;

        public RadioButton optStarFinder
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optStarFinder;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optStarFinder != null)
                {
                    _optStarFinder.CheckedChanged -= optStarFinder_CheckedChanged;
                }

                _optStarFinder = value;
                if (_optStarFinder != null)
                {
                    _optStarFinder.CheckedChanged += optStarFinder_CheckedChanged;
                }
            }
        }

        private RadioButton _optOverhead;

        public RadioButton optOverhead
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optOverhead;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optOverhead != null)
                {
                    _optOverhead.CheckedChanged -= optOverhead_CheckedChanged;
                }

                _optOverhead = value;
                if (_optOverhead != null)
                {
                    _optOverhead.CheckedChanged += optOverhead_CheckedChanged;
                }
            }
        }

        internal TabPage StarFinder1Pg;
        internal TextBox ReportTxtBx;
        internal RichTextBox MoonTxtBxRight;
        public Label lblSLeft;
        public Label lblSRight;
        private Button _ResetRotateBtn;

        public Button ResetRotateBtn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ResetRotateBtn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ResetRotateBtn != null)
                {
                    _ResetRotateBtn.Click -= ResetRotateBtn_Click;
                }

                _ResetRotateBtn = value;
                if (_ResetRotateBtn != null)
                {
                    _ResetRotateBtn.Click += ResetRotateBtn_Click;
                }
            }
        }

        internal ComboBox RotateIncr;
        internal ToolTip ToolTip1;
        internal PictureBox PictureBox1;
        private DateTimePicker _DTPlan;

        internal DateTimePicker DTPlan
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _DTPlan;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_DTPlan != null)
                {
                    _DTPlan.ValueChanged -= DTPlan_ValueChanged;
                }

                _DTPlan = value;
                if (_DTPlan != null)
                {
                    _DTPlan.ValueChanged += DTPlan_ValueChanged;
                }
            }
        }

        internal TextBox TextBox1;
        private DataGridView _DGMag1;

        internal DataGridView DGMag1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _DGMag1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_DGMag1 != null)
                {
                    _DGMag1.SelectionChanged -= DGMag1_SelectionChanged;
                }

                _DGMag1 = value;
                if (_DGMag1 != null)
                {
                    _DGMag1.SelectionChanged += DGMag1_SelectionChanged;
                }
            }
        }

        internal TextBox TextBox3;
        private DataGridView _DGMag2;

        internal DataGridView DGMag2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _DGMag2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_DGMag2 != null)
                {
                    _DGMag2.SelectionChanged -= DGMag2_SelectionChanged;
                }

                _DGMag2 = value;
                if (_DGMag2 != null)
                {
                    _DGMag2.SelectionChanged += DGMag2_SelectionChanged;
                }
            }
        }

        internal TextBox TextBox2;
        internal TextBox TextBox4;
        private DataGridView _DGMag3;

        internal DataGridView DGMag3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _DGMag3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_DGMag3 != null)
                {
                    _DGMag3.SelectionChanged -= DGMag3_SelectionChanged;
                }

                _DGMag3 = value;
                if (_DGMag3 != null)
                {
                    _DGMag3.SelectionChanged += DGMag3_SelectionChanged;
                }
            }
        }

        internal RichTextBox txtBx2;
        internal TextBox Shape1;
        internal TextBox txtUserInfo;
        internal Label Label1;
        internal TabPage SunRiseSunSet;
        private PictureBox _SunRiseSet;

        internal PictureBox SunRiseSet
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SunRiseSet;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SunRiseSet != null)
                {
                    _SunRiseSet.Paint -= SunRiseSet_Paint;
                }

                _SunRiseSet = value;
                if (_SunRiseSet != null)
                {
                    _SunRiseSet.Paint += SunRiseSet_Paint;
                }
            }
        }

        private CheckBox _chkNoonSightLAN;

        internal CheckBox chkNoonSightLAN
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _chkNoonSightLAN;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_chkNoonSightLAN != null)
                {
                    _chkNoonSightLAN.CheckedChanged -= chkNoonSightLAN_CheckedChanged;
                }

                _chkNoonSightLAN = value;
                if (_chkNoonSightLAN != null)
                {
                    _chkNoonSightLAN.CheckedChanged += chkNoonSightLAN_CheckedChanged;
                }
            }
        }

        internal TextBox txtLAN;
        private ComboBox _cboLineWidth;

        internal ComboBox cboLineWidth
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboLineWidth;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboLineWidth != null)
                {
                    _cboLineWidth.SelectedIndexChanged -= cboLineWidth_SelectedIndexChanged;
                }

                _cboLineWidth = value;
                if (_cboLineWidth != null)
                {
                    _cboLineWidth.SelectedIndexChanged += cboLineWidth_SelectedIndexChanged;
                }
            }
        }

        internal Label lblLineWidth;
        internal RichTextBox txtIncreaseDT;
        private Button _btnAdd1Hour;

        internal Button btnAdd1Hour
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnAdd1Hour;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnAdd1Hour != null)
                {
                    _btnAdd1Hour.Click -= btnAdd1Hour_Click;
                }

                _btnAdd1Hour = value;
                if (_btnAdd1Hour != null)
                {
                    _btnAdd1Hour.Click += btnAdd1Hour_Click;
                }
            }
        }

        private Button _btnAdd1Day;

        internal Button btnAdd1Day
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnAdd1Day;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnAdd1Day != null)
                {
                    _btnAdd1Day.Click -= btnAdd1Day_Click;
                }

                _btnAdd1Day = value;
                if (_btnAdd1Day != null)
                {
                    _btnAdd1Day.Click += btnAdd1Day_Click;
                }
            }
        }

        private Button _btnAdd1Week;

        internal Button btnAdd1Week
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnAdd1Week;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnAdd1Week != null)
                {
                    _btnAdd1Week.Click -= btnAdd1Week_Click;
                }

                _btnAdd1Week = value;
                if (_btnAdd1Week != null)
                {
                    _btnAdd1Week.Click += btnAdd1Week_Click;
                }
            }
        }

        private Button _btnAdd1Month;

        internal Button btnAdd1Month
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnAdd1Month;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnAdd1Month != null)
                {
                    _btnAdd1Month.Click -= btnAdd1Month_Click;
                }

                _btnAdd1Month = value;
                if (_btnAdd1Month != null)
                {
                    _btnAdd1Month.Click += btnAdd1Month_Click;
                }
            }
        }

        private Button _btnAdd30Min;

        internal Button btnAdd30Min
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnAdd30Min;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnAdd30Min != null)
                {
                    _btnAdd30Min.Click -= btnAdd30Min_Click;
                }

                _btnAdd30Min = value;
                if (_btnAdd30Min != null)
                {
                    _btnAdd30Min.Click += btnAdd30Min_Click;
                }
            }
        }

        private Button _btnAdd1Year;

        internal Button btnAdd1Year
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnAdd1Year;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnAdd1Year != null)
                {
                    _btnAdd1Year.Click -= btnAdd1Year_Click;
                }

                _btnAdd1Year = value;
                if (_btnAdd1Year != null)
                {
                    _btnAdd1Year.Click += btnAdd1Year_Click;
                }
            }
        }

        private Button _btnSub1Year;

        internal Button btnSub1Year
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSub1Year;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSub1Year != null)
                {
                    _btnSub1Year.Click -= btnSub1Year_Click;
                }

                _btnSub1Year = value;
                if (_btnSub1Year != null)
                {
                    _btnSub1Year.Click += btnSub1Year_Click;
                }
            }
        }

        private Button _btnSub30Min;

        internal Button btnSub30Min
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSub30Min;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSub30Min != null)
                {
                    _btnSub30Min.Click -= btnSub30Min_Click;
                }

                _btnSub30Min = value;
                if (_btnSub30Min != null)
                {
                    _btnSub30Min.Click += btnSub30Min_Click;
                }
            }
        }

        private Button _btnSub1Month;

        internal Button btnSub1Month
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSub1Month;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSub1Month != null)
                {
                    _btnSub1Month.Click -= btnSub1Month_Click;
                }

                _btnSub1Month = value;
                if (_btnSub1Month != null)
                {
                    _btnSub1Month.Click += btnSub1Month_Click;
                }
            }
        }

        private Button _btnSub1Week;

        internal Button btnSub1Week
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSub1Week;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSub1Week != null)
                {
                    _btnSub1Week.Click -= btnSub1Week_Click;
                }

                _btnSub1Week = value;
                if (_btnSub1Week != null)
                {
                    _btnSub1Week.Click += btnSub1Week_Click;
                }
            }
        }

        private Button _btnSub1Day;

        internal Button btnSub1Day
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSub1Day;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSub1Day != null)
                {
                    _btnSub1Day.Click -= btnSub1Day_Click;
                }

                _btnSub1Day = value;
                if (_btnSub1Day != null)
                {
                    _btnSub1Day.Click += btnSub1Day_Click;
                }
            }
        }

        private Button _btnSub1Hour;

        internal Button btnSub1Hour
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSub1Hour;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSub1Hour != null)
                {
                    _btnSub1Hour.Click -= btnSub1Hour_Click;
                }

                _btnSub1Hour = value;
                if (_btnSub1Hour != null)
                {
                    _btnSub1Hour.Click += btnSub1Hour_Click;
                }
            }
        }

        internal RichTextBox txtDecreaseDT;
        private Button _btnResetDTtoNow;

        internal Button btnResetDTtoNow
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnResetDTtoNow;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnResetDTtoNow != null)
                {
                    _btnResetDTtoNow.Click -= btnResetDTtoNow_Click;
                }

                _btnResetDTtoNow = value;
                if (_btnResetDTtoNow != null)
                {
                    _btnResetDTtoNow.Click += btnResetDTtoNow_Click;
                }
            }
        }
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}