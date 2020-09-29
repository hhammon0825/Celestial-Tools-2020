using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    [DesignerGenerated()]
    internal partial class MainMenu
    {
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        [DebuggerNonUserCode()]
        public MainMenu() : base()
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
        private Button _cmdCurrents;

        public Button cmdCurrents
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdCurrents;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdCurrents != null)
                {
                    _cmdCurrents.Click -= cmdCurrents_Click;
                }

                _cmdCurrents = value;
                if (_cmdCurrents != null)
                {
                    _cmdCurrents.Click += cmdCurrents_Click;
                }
            }
        }

        private Button _cmdTides;

        public Button cmdTides
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdTides;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdTides != null)
                {
                    _cmdTides.Click -= cmdTides_Click;
                }

                _cmdTides = value;
                if (_cmdTides != null)
                {
                    _cmdTides.Click += cmdTides_Click;
                }
            }
        }

        private Button _cmdTwoBearings;

        public Button cmdTwoBearings
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdTwoBearings;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdTwoBearings != null)
                {
                    _cmdTwoBearings.Click -= cmdTwoBearings_Click;
                }

                _cmdTwoBearings = value;
                if (_cmdTwoBearings != null)
                {
                    _cmdTwoBearings.Click += cmdTwoBearings_Click;
                }
            }
        }

        private Button _cmdCPA;

        public Button cmdCPA
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdCPA;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdCPA != null)
                {
                    _cmdCPA.Click -= cmdCPA_Click;
                }

                _cmdCPA = value;
                if (_cmdCPA != null)
                {
                    _cmdCPA.Click += cmdCPA_Click;
                }
            }
        }

        private Button _cmdYellow;

        public Button cmdYellow
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdYellow;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdYellow != null)
                {
                    _cmdYellow.Click -= cmdYellow_Click;
                }

                _cmdYellow = value;
                if (_cmdYellow != null)
                {
                    _cmdYellow.Click += cmdYellow_Click;
                }
            }
        }

        private Button _cmdLengthDeg;

        public Button cmdLengthDeg
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdLengthDeg;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdLengthDeg != null)
                {
                    _cmdLengthDeg.Click -= cmdLengthDeg_Click;
                }

                _cmdLengthDeg = value;
                if (_cmdLengthDeg != null)
                {
                    _cmdLengthDeg.Click += cmdLengthDeg_Click;
                }
            }
        }

        private Button _cmdTVMDC;

        public Button cmdTVMDC
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdTVMDC;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdTVMDC != null)
                {
                    _cmdTVMDC.Click -= cmdTVMDC_Click;
                }

                _cmdTVMDC = value;
                if (_cmdTVMDC != null)
                {
                    _cmdTVMDC.Click += cmdTVMDC_Click;
                }
            }
        }

        private Button _cmd60DST;

        public Button cmd60DST
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmd60DST;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmd60DST != null)
                {
                    _cmd60DST.Click -= cmd60DST_Click;
                }

                _cmd60DST = value;
                if (_cmd60DST != null)
                {
                    _cmd60DST.Click += cmd60DST_Click;
                }
            }
        }

        private Button _cmdInterpolate;

        public Button cmdInterpolate
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdInterpolate;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdInterpolate != null)
                {
                    _cmdInterpolate.Click -= cmdInterpolate_Click;
                }

                _cmdInterpolate = value;
                if (_cmdInterpolate != null)
                {
                    _cmdInterpolate.Click += cmdInterpolate_Click;
                }
            }
        }

        private Button _cmdDistances;

        public Button cmdDistances
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdDistances;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdDistances != null)
                {
                    _cmdDistances.Click -= cmdDistances_Click;
                }

                _cmdDistances = value;
                if (_cmdDistances != null)
                {
                    _cmdDistances.Click += cmdDistances_Click;
                }
            }
        }

        private Button _cmdCTSSOA;

        public Button cmdCTSSOA
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdCTSSOA;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdCTSSOA != null)
                {
                    _cmdCTSSOA.Click -= cmdCTSSOA_Click;
                }

                _cmdCTSSOA = value;
                if (_cmdCTSSOA != null)
                {
                    _cmdCTSSOA.Click += cmdCTSSOA_Click;
                }
            }
        }

        private Button _cmdSailings;

        public Button cmdSailings
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdSailings;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdSailings != null)
                {
                    _cmdSailings.Click -= cmdSailings_Click;
                }

                _cmdSailings = value;
                if (_cmdSailings != null)
                {
                    _cmdSailings.Click += cmdSailings_Click;
                }
            }
        }

        private Button _cmdArcTime;

        public Button cmdArcTime
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdArcTime;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdArcTime != null)
                {
                    _cmdArcTime.Click -= cmdArcTime_Click;
                }

                _cmdArcTime = value;
                if (_cmdArcTime != null)
                {
                    _cmdArcTime.Click += cmdArcTime_Click;
                }
            }
        }

        private Button _SRMethod;

        public Button SRMethod
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SRMethod;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SRMethod != null)
                {
                    _SRMethod.Click -= SRMethod_Click;
                }

                _SRMethod = value;
                if (_SRMethod != null)
                {
                    _SRMethod.Click += SRMethod_Click;
                }
            }
        }

        private Button _cmdNoon;

        public Button cmdNoon
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdNoon;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdNoon != null)
                {
                    _cmdNoon.Click -= cmdNoon_Click;
                }

                _cmdNoon = value;
                if (_cmdNoon != null)
                {
                    _cmdNoon.Click += cmdNoon_Click;
                }
            }
        }

        private Button _cmdReduction;

        public Button cmdReduction
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdReduction;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdReduction != null)
                {
                    _cmdReduction.Click -= cmdReduction_Click;
                }

                _cmdReduction = value;
                if (_cmdReduction != null)
                {
                    _cmdReduction.Click += cmdReduction_Click;
                }
            }
        }

        private Button _cmdPlanning;

        public Button cmdPlanning
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdPlanning;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdPlanning != null)
                {
                    _cmdPlanning.Click -= cmdPlanning_Click;
                }

                _cmdPlanning = value;
                if (_cmdPlanning != null)
                {
                    _cmdPlanning.Click += cmdPlanning_Click;
                }
            }
        }

        public Label Label1;
        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            ToolTip1 = new ToolTip(components);
            _cmdPlanning = new Button();
            _cmdPlanning.Click += new EventHandler(cmdPlanning_Click);
            _cmdCurrents = new Button();
            _cmdCurrents.Click += new EventHandler(cmdCurrents_Click);
            _cmdTides = new Button();
            _cmdTides.Click += new EventHandler(cmdTides_Click);
            _cmdTwoBearings = new Button();
            _cmdTwoBearings.Click += new EventHandler(cmdTwoBearings_Click);
            _cmdCPA = new Button();
            _cmdCPA.Click += new EventHandler(cmdCPA_Click);
            _cmdYellow = new Button();
            _cmdYellow.Click += new EventHandler(cmdYellow_Click);
            _cmdLengthDeg = new Button();
            _cmdLengthDeg.Click += new EventHandler(cmdLengthDeg_Click);
            _cmdTVMDC = new Button();
            _cmdTVMDC.Click += new EventHandler(cmdTVMDC_Click);
            _cmd60DST = new Button();
            _cmd60DST.Click += new EventHandler(cmd60DST_Click);
            _cmdInterpolate = new Button();
            _cmdInterpolate.Click += new EventHandler(cmdInterpolate_Click);
            _cmdDistances = new Button();
            _cmdDistances.Click += new EventHandler(cmdDistances_Click);
            _cmdCTSSOA = new Button();
            _cmdCTSSOA.Click += new EventHandler(cmdCTSSOA_Click);
            _cmdSailings = new Button();
            _cmdSailings.Click += new EventHandler(cmdSailings_Click);
            _cmdArcTime = new Button();
            _cmdArcTime.Click += new EventHandler(cmdArcTime_Click);
            _SRMethod = new Button();
            _SRMethod.Click += new EventHandler(SRMethod_Click);
            _cmdNoon = new Button();
            _cmdNoon.Click += new EventHandler(cmdNoon_Click);
            _cmdReduction = new Button();
            _cmdReduction.Click += new EventHandler(cmdReduction_Click);
            _btnSightLog = new Button();
            _btnSightLog.Click += new EventHandler(btnSightLog_Click);
            _btnFavLocs = new Button();
            _btnFavLocs.Click += new EventHandler(btnFavLocs_Click);
            _btnDeckLog = new Button();
            _btnDeckLog.Click += new EventHandler(btnDeckLog_Click);
            _btnCVSFile = new Button();
            _btnCVSFile.Click += new EventHandler(btnCVSFile_Click);
            _btnDevForm = new Button();
            _btnDevForm.Click += new EventHandler(btnDevForm_Click);
            Label1 = new Label();
            _ExitBtn = new Button();
            _ExitBtn.Click += new EventHandler(ExitBtn_Click);
            _HelpV2Btn = new Button();
            _HelpV2Btn.Click += new EventHandler(HelpV2Btn_Click);
            PictureBox1 = new PictureBox();
            _cmdAbout = new Button();
            _cmdAbout.Click += new EventHandler(cmdAbout_Click);
            GroupBox1 = new GroupBox();
            GroupBox2 = new GroupBox();
            _btnTraverseTable = new Button();
            _btnTraverseTable.Click += new EventHandler(btnTraverseTable_Click);
            _btnZoneTime = new Button();
            _btnZoneTime.Click += new EventHandler(btnZoneTime_Click);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            GroupBox1.SuspendLayout();
            GroupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // cmdPlanning
            // 
            _cmdPlanning.BackColor = SystemColors.Control;
            _cmdPlanning.Cursor = Cursors.Default;
            _cmdPlanning.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdPlanning.ForeColor = SystemColors.ControlText;
            _cmdPlanning.Image = (Image)resources.GetObject("cmdPlanning.Image");
            _cmdPlanning.ImageAlign = ContentAlignment.TopCenter;
            _cmdPlanning.Location = new Point(7, 23);
            _cmdPlanning.Name = "_cmdPlanning";
            _cmdPlanning.RightToLeft = RightToLeft.No;
            _cmdPlanning.Size = new Size(91, 60);
            _cmdPlanning.TabIndex = 0;
            _cmdPlanning.Text = "Sight Planner";
            _cmdPlanning.TextAlign = ContentAlignment.BottomCenter;
            ToolTip1.SetToolTip(_cmdPlanning, "Plan which celestial bodies are visible and where");
            _cmdPlanning.UseVisualStyleBackColor = false;
            // 
            // cmdCurrents
            // 
            _cmdCurrents.BackColor = SystemColors.Control;
            _cmdCurrents.Cursor = Cursors.Default;
            _cmdCurrents.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdCurrents.ForeColor = SystemColors.ControlText;
            _cmdCurrents.Image = (Image)resources.GetObject("cmdCurrents.Image");
            _cmdCurrents.ImageAlign = ContentAlignment.TopCenter;
            _cmdCurrents.Location = new Point(202, 82);
            _cmdCurrents.Name = "_cmdCurrents";
            _cmdCurrents.RightToLeft = RightToLeft.No;
            _cmdCurrents.Size = new Size(92, 60);
            _cmdCurrents.TabIndex = 23;
            _cmdCurrents.Text = "Currents";
            _cmdCurrents.TextAlign = ContentAlignment.BottomCenter;
            ToolTip1.SetToolTip(_cmdCurrents, "Calculate tidal currents or use NOAA web sight");
            _cmdCurrents.UseVisualStyleBackColor = false;
            // 
            // cmdTides
            // 
            _cmdTides.BackColor = SystemColors.Control;
            _cmdTides.Cursor = Cursors.Default;
            _cmdTides.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdTides.ForeColor = SystemColors.ControlText;
            _cmdTides.Image = (Image)resources.GetObject("cmdTides.Image");
            _cmdTides.ImageAlign = ContentAlignment.TopCenter;
            _cmdTides.Location = new Point(105, 82);
            _cmdTides.Name = "_cmdTides";
            _cmdTides.RightToLeft = RightToLeft.No;
            _cmdTides.Size = new Size(92, 60);
            _cmdTides.TabIndex = 22;
            _cmdTides.Text = "Tides";
            _cmdTides.TextAlign = ContentAlignment.BottomCenter;
            ToolTip1.SetToolTip(_cmdTides, "Calculate tidal data or use NOAA web sight");
            _cmdTides.UseVisualStyleBackColor = false;
            // 
            // cmdTwoBearings
            // 
            _cmdTwoBearings.BackColor = SystemColors.Control;
            _cmdTwoBearings.Cursor = Cursors.Default;
            _cmdTwoBearings.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdTwoBearings.ForeColor = SystemColors.ControlText;
            _cmdTwoBearings.Image = (Image)resources.GetObject("cmdTwoBearings.Image");
            _cmdTwoBearings.ImageAlign = ContentAlignment.TopLeft;
            _cmdTwoBearings.Location = new Point(300, 82);
            _cmdTwoBearings.Name = "_cmdTwoBearings";
            _cmdTwoBearings.RightToLeft = RightToLeft.No;
            _cmdTwoBearings.Size = new Size(92, 60);
            _cmdTwoBearings.TabIndex = 15;
            _cmdTwoBearings.Text = "Distance, Course, Fix" + '\r' + '\n' + "from Bearings";
            _cmdTwoBearings.TextAlign = ContentAlignment.BottomRight;
            ToolTip1.SetToolTip(_cmdTwoBearings, "Calculate distance, course, or fix given 2 or 3 bearings");
            _cmdTwoBearings.UseVisualStyleBackColor = false;
            // 
            // cmdCPA
            // 
            _cmdCPA.BackColor = SystemColors.Control;
            _cmdCPA.Cursor = Cursors.Default;
            _cmdCPA.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdCPA.ForeColor = SystemColors.ControlText;
            _cmdCPA.Image = (Image)resources.GetObject("cmdCPA.Image");
            _cmdCPA.ImageAlign = ContentAlignment.TopLeft;
            _cmdCPA.Location = new Point(399, 18);
            _cmdCPA.Name = "_cmdCPA";
            _cmdCPA.RightToLeft = RightToLeft.No;
            _cmdCPA.Size = new Size(92, 60);
            _cmdCPA.TabIndex = 7;
            _cmdCPA.Text = "Closest " + '\r' + '\n' + "Approach " + '\r' + '\n' + "&& True Wind";
            _cmdCPA.TextAlign = ContentAlignment.BottomRight;
            ToolTip1.SetToolTip(_cmdCPA, "Calculate closest point of approach or true wind");
            _cmdCPA.UseVisualStyleBackColor = false;
            // 
            // cmdYellow
            // 
            _cmdYellow.BackColor = SystemColors.Control;
            _cmdYellow.Cursor = Cursors.Default;
            _cmdYellow.Font = new Font("Arial Narrow", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdYellow.ForeColor = SystemColors.ControlText;
            _cmdYellow.Image = (Image)resources.GetObject("cmdYellow.Image");
            _cmdYellow.ImageAlign = ContentAlignment.TopCenter;
            _cmdYellow.Location = new Point(591, 24);
            _cmdYellow.Name = "_cmdYellow";
            _cmdYellow.RightToLeft = RightToLeft.No;
            _cmdYellow.Size = new Size(92, 60);
            _cmdYellow.TabIndex = 4;
            _cmdYellow.Text = "Yellow Pages (I&&C)";
            _cmdYellow.TextAlign = ContentAlignment.BottomCenter;
            ToolTip1.SetToolTip(_cmdYellow, "Calculate nautical almanac 'Yellow Page' I&C corrections");
            _cmdYellow.UseVisualStyleBackColor = false;
            // 
            // cmdLengthDeg
            // 
            _cmdLengthDeg.BackColor = SystemColors.Control;
            _cmdLengthDeg.Cursor = Cursors.Default;
            _cmdLengthDeg.Font = new Font("Arial Narrow", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdLengthDeg.ForeColor = SystemColors.ControlText;
            _cmdLengthDeg.Image = (Image)resources.GetObject("cmdLengthDeg.Image");
            _cmdLengthDeg.ImageAlign = ContentAlignment.TopCenter;
            _cmdLengthDeg.Location = new Point(7, 82);
            _cmdLengthDeg.Name = "_cmdLengthDeg";
            _cmdLengthDeg.RightToLeft = RightToLeft.No;
            _cmdLengthDeg.Size = new Size(92, 60);
            _cmdLengthDeg.TabIndex = 11;
            _cmdLengthDeg.Text = "Length of Degree For Lat/Long";
            _cmdLengthDeg.TextAlign = ContentAlignment.BottomCenter;
            ToolTip1.SetToolTip(_cmdLengthDeg, "Over calculate information about 1 degree of latitude / longitude");
            _cmdLengthDeg.UseVisualStyleBackColor = false;
            // 
            // cmdTVMDC
            // 
            _cmdTVMDC.BackColor = SystemColors.Control;
            _cmdTVMDC.Cursor = Cursors.Default;
            _cmdTVMDC.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdTVMDC.ForeColor = SystemColors.ControlText;
            _cmdTVMDC.Image = (Image)resources.GetObject("cmdTVMDC.Image");
            _cmdTVMDC.ImageAlign = ContentAlignment.TopCenter;
            _cmdTVMDC.Location = new Point(7, 20);
            _cmdTVMDC.Name = "_cmdTVMDC";
            _cmdTVMDC.RightToLeft = RightToLeft.No;
            _cmdTVMDC.Size = new Size(92, 60);
            _cmdTVMDC.TabIndex = 13;
            _cmdTVMDC.Text = "TVMDC";
            _cmdTVMDC.TextAlign = ContentAlignment.BottomCenter;
            ToolTip1.SetToolTip(_cmdTVMDC, "Calculate true, magnetic, or compass courses given deviation and variation (TVMDC" + ")");
            _cmdTVMDC.UseVisualStyleBackColor = false;
            // 
            // cmd60DST
            // 
            _cmd60DST.BackColor = SystemColors.Control;
            _cmd60DST.Cursor = Cursors.Default;
            _cmd60DST.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmd60DST.ForeColor = SystemColors.ControlText;
            _cmd60DST.Image = (Image)resources.GetObject("cmd60DST.Image");
            _cmd60DST.ImageAlign = ContentAlignment.TopLeft;
            _cmd60DST.Location = new Point(105, 20);
            _cmd60DST.Name = "_cmd60DST";
            _cmd60DST.RightToLeft = RightToLeft.No;
            _cmd60DST.Size = new Size(92, 60);
            _cmd60DST.TabIndex = 12;
            _cmd60DST.Text = "Calculate Distance, Speed, Time";
            _cmd60DST.TextAlign = ContentAlignment.BottomRight;
            ToolTip1.SetToolTip(_cmd60DST, "Calculate navigation distances, speed, or time");
            _cmd60DST.UseVisualStyleBackColor = false;
            // 
            // cmdInterpolate
            // 
            _cmdInterpolate.BackColor = SystemColors.Control;
            _cmdInterpolate.Cursor = Cursors.Default;
            _cmdInterpolate.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdInterpolate.ForeColor = SystemColors.ControlText;
            _cmdInterpolate.Image = (Image)resources.GetObject("cmdInterpolate.Image");
            _cmdInterpolate.ImageAlign = ContentAlignment.TopCenter;
            _cmdInterpolate.Location = new Point(398, 82);
            _cmdInterpolate.Name = "_cmdInterpolate";
            _cmdInterpolate.RightToLeft = RightToLeft.No;
            _cmdInterpolate.Size = new Size(92, 60);
            _cmdInterpolate.TabIndex = 16;
            _cmdInterpolate.Text = "Navigation Math";
            _cmdInterpolate.TextAlign = ContentAlignment.BottomCenter;
            ToolTip1.SetToolTip(_cmdInterpolate, "Nav Math Tools to convert Angles or Time to Decimal, Add/Subtract Angle or Time, " + "Arrival Date&&Time, ZT from Long");
            _cmdInterpolate.UseVisualStyleBackColor = false;
            // 
            // cmdDistances
            // 
            _cmdDistances.BackColor = SystemColors.Control;
            _cmdDistances.Cursor = Cursors.Default;
            _cmdDistances.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdDistances.ForeColor = SystemColors.ControlText;
            _cmdDistances.Image = (Image)resources.GetObject("cmdDistances.Image");
            _cmdDistances.ImageAlign = ContentAlignment.TopLeft;
            _cmdDistances.Location = new Point(203, 20);
            _cmdDistances.Name = "_cmdDistances";
            _cmdDistances.RightToLeft = RightToLeft.No;
            _cmdDistances.Size = new Size(92, 60);
            _cmdDistances.TabIndex = 14;
            _cmdDistances.Text = "Distance " + '\r' + '\n' + "From " + '\r' + '\n' + "Objects";
            _cmdDistances.TextAlign = ContentAlignment.BottomRight;
            ToolTip1.SetToolTip(_cmdDistances, "Calculate distances from objects in common situation");
            _cmdDistances.UseVisualStyleBackColor = false;
            // 
            // cmdCTSSOA
            // 
            _cmdCTSSOA.BackColor = SystemColors.Control;
            _cmdCTSSOA.Cursor = Cursors.Default;
            _cmdCTSSOA.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdCTSSOA.ForeColor = SystemColors.ControlText;
            _cmdCTSSOA.Image = (Image)resources.GetObject("cmdCTSSOA.Image");
            _cmdCTSSOA.ImageAlign = ContentAlignment.TopLeft;
            _cmdCTSSOA.Location = new Point(492, 18);
            _cmdCTSSOA.Name = "_cmdCTSSOA";
            _cmdCTSSOA.RightToLeft = RightToLeft.No;
            _cmdCTSSOA.Size = new Size(92, 60);
            _cmdCTSSOA.TabIndex = 5;
            _cmdCTSSOA.Text = "Calculate " + '\r' + '\n' + "CTS && SOA" + '\r' + '\n' + "or CMG && SMG";
            _cmdCTSSOA.TextAlign = ContentAlignment.BottomRight;
            ToolTip1.SetToolTip(_cmdCTSSOA, "Calculate CTS and SOA or CMG and SMG");
            _cmdCTSSOA.UseVisualStyleBackColor = false;
            // 
            // cmdSailings
            // 
            _cmdSailings.BackColor = SystemColors.Control;
            _cmdSailings.Cursor = Cursors.Default;
            _cmdSailings.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdSailings.ForeColor = SystemColors.ControlText;
            _cmdSailings.Image = (Image)resources.GetObject("cmdSailings.Image");
            _cmdSailings.ImageAlign = ContentAlignment.TopCenter;
            _cmdSailings.Location = new Point(301, 20);
            _cmdSailings.Name = "_cmdSailings";
            _cmdSailings.RightToLeft = RightToLeft.No;
            _cmdSailings.Size = new Size(92, 60);
            _cmdSailings.TabIndex = 9;
            _cmdSailings.Text = "The Sailings";
            _cmdSailings.TextAlign = ContentAlignment.BottomCenter;
            ToolTip1.SetToolTip(_cmdSailings, "Calculate sailing waypoints and distances");
            _cmdSailings.UseVisualStyleBackColor = false;
            // 
            // cmdArcTime
            // 
            _cmdArcTime.BackColor = SystemColors.Control;
            _cmdArcTime.Cursor = Cursors.Default;
            _cmdArcTime.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdArcTime.ForeColor = SystemColors.ControlText;
            _cmdArcTime.Image = (Image)resources.GetObject("cmdArcTime.Image");
            _cmdArcTime.ImageAlign = ContentAlignment.TopLeft;
            _cmdArcTime.Location = new Point(492, 82);
            _cmdArcTime.Name = "_cmdArcTime";
            _cmdArcTime.RightToLeft = RightToLeft.No;
            _cmdArcTime.Size = new Size(92, 60);
            _cmdArcTime.TabIndex = 8;
            _cmdArcTime.Text = "Convert" + '\r' + '\n' + "Between" + '\r' + '\n' + "Arcs && Times";
            _cmdArcTime.TextAlign = ContentAlignment.BottomRight;
            ToolTip1.SetToolTip(_cmdArcTime, "Convert Arcs to Time and Time to Arcs");
            _cmdArcTime.UseVisualStyleBackColor = false;
            // 
            // SRMethod
            // 
            _SRMethod.BackColor = SystemColors.Control;
            _SRMethod.Cursor = Cursors.Default;
            _SRMethod.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _SRMethod.ForeColor = SystemColors.ControlText;
            _SRMethod.Image = (Image)resources.GetObject("SRMethod.Image");
            _SRMethod.ImageAlign = ContentAlignment.TopCenter;
            _SRMethod.Location = new Point(300, 24);
            _SRMethod.Name = "_SRMethod";
            _SRMethod.RightToLeft = RightToLeft.No;
            _SRMethod.Size = new Size(92, 60);
            _SRMethod.TabIndex = 3;
            _SRMethod.Text = "Alt SR Methods";
            _SRMethod.TextAlign = ContentAlignment.BottomCenter;
            ToolTip1.SetToolTip(_SRMethod, "Perform alternate method, tabular sight reductions");
            _SRMethod.UseVisualStyleBackColor = false;
            // 
            // cmdNoon
            // 
            _cmdNoon.BackColor = SystemColors.Control;
            _cmdNoon.Cursor = Cursors.Default;
            _cmdNoon.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdNoon.ForeColor = SystemColors.ControlText;
            _cmdNoon.Image = (Image)resources.GetObject("cmdNoon.Image");
            _cmdNoon.ImageAlign = ContentAlignment.TopCenter;
            _cmdNoon.Location = new Point(104, 23);
            _cmdNoon.Name = "_cmdNoon";
            _cmdNoon.RightToLeft = RightToLeft.No;
            _cmdNoon.Size = new Size(92, 60);
            _cmdNoon.TabIndex = 2;
            _cmdNoon.Text = "Noon Sight";
            _cmdNoon.TextAlign = ContentAlignment.BottomCenter;
            ToolTip1.SetToolTip(_cmdNoon, "Plan a sun noon sight or evaluate noon sight sight ");
            _cmdNoon.UseVisualStyleBackColor = false;
            // 
            // cmdReduction
            // 
            _cmdReduction.BackColor = SystemColors.Control;
            _cmdReduction.Cursor = Cursors.Default;
            _cmdReduction.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdReduction.ForeColor = SystemColors.ControlText;
            _cmdReduction.Image = (Image)resources.GetObject("cmdReduction.Image");
            _cmdReduction.ImageAlign = ContentAlignment.TopCenter;
            _cmdReduction.Location = new Point(201, 23);
            _cmdReduction.Name = "_cmdReduction";
            _cmdReduction.RightToLeft = RightToLeft.No;
            _cmdReduction.Size = new Size(92, 60);
            _cmdReduction.TabIndex = 1;
            _cmdReduction.Text = "Sight Reduction";
            _cmdReduction.TextAlign = ContentAlignment.BottomCenter;
            ToolTip1.SetToolTip(_cmdReduction, "Perform a Law of Cosines sight reduction for most celestial bodies");
            _cmdReduction.UseVisualStyleBackColor = false;
            // 
            // btnSightLog
            // 
            _btnSightLog.BackColor = SystemColors.Control;
            _btnSightLog.Cursor = Cursors.Default;
            _btnSightLog.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnSightLog.ForeColor = SystemColors.ControlText;
            _btnSightLog.Image = (Image)resources.GetObject("btnSightLog.Image");
            _btnSightLog.ImageAlign = ContentAlignment.TopCenter;
            _btnSightLog.Location = new Point(398, 24);
            _btnSightLog.Name = "_btnSightLog";
            _btnSightLog.RightToLeft = RightToLeft.No;
            _btnSightLog.Size = new Size(92, 60);
            _btnSightLog.TabIndex = 26;
            _btnSightLog.Text = "Sight Log";
            _btnSightLog.TextAlign = ContentAlignment.BottomCenter;
            ToolTip1.SetToolTip(_btnSightLog, "Store sight data taken, recall, edit, perform sight reduction and plots");
            _btnSightLog.UseVisualStyleBackColor = false;
            // 
            // btnFavLocs
            // 
            _btnFavLocs.BackColor = SystemColors.Control;
            _btnFavLocs.Cursor = Cursors.Default;
            _btnFavLocs.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnFavLocs.ForeColor = SystemColors.ControlText;
            _btnFavLocs.Image = (Image)resources.GetObject("btnFavLocs.Image");
            _btnFavLocs.ImageAlign = ContentAlignment.TopRight;
            _btnFavLocs.Location = new Point(493, 24);
            _btnFavLocs.Name = "_btnFavLocs";
            _btnFavLocs.RightToLeft = RightToLeft.No;
            _btnFavLocs.Size = new Size(92, 60);
            _btnFavLocs.TabIndex = 27;
            _btnFavLocs.Text = "Shared Locations";
            _btnFavLocs.TextAlign = ContentAlignment.BottomLeft;
            ToolTip1.SetToolTip(_btnFavLocs, "Input, store, and share common navigation locations with other forms");
            _btnFavLocs.UseVisualStyleBackColor = false;
            // 
            // btnDeckLog
            // 
            _btnDeckLog.BackColor = SystemColors.Control;
            _btnDeckLog.Cursor = Cursors.Default;
            _btnDeckLog.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnDeckLog.ForeColor = SystemColors.ControlText;
            _btnDeckLog.Image = (Image)resources.GetObject("btnDeckLog.Image");
            _btnDeckLog.ImageAlign = ContentAlignment.TopCenter;
            _btnDeckLog.Location = new Point(6, 148);
            _btnDeckLog.Name = "_btnDeckLog";
            _btnDeckLog.RightToLeft = RightToLeft.No;
            _btnDeckLog.Size = new Size(92, 60);
            _btnDeckLog.TabIndex = 28;
            _btnDeckLog.Text = "Deck Log";
            _btnDeckLog.TextAlign = ContentAlignment.BottomCenter;
            ToolTip1.SetToolTip(_btnDeckLog, "Input and store deck log and route entries");
            _btnDeckLog.UseVisualStyleBackColor = false;
            // 
            // btnCVSFile
            // 
            _btnCVSFile.BackColor = SystemColors.Control;
            _btnCVSFile.Cursor = Cursors.Default;
            _btnCVSFile.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnCVSFile.ForeColor = SystemColors.ControlText;
            _btnCVSFile.Image = (Image)resources.GetObject("btnCVSFile.Image");
            _btnCVSFile.ImageAlign = ContentAlignment.TopLeft;
            _btnCVSFile.Location = new Point(105, 148);
            _btnCVSFile.Name = "_btnCVSFile";
            _btnCVSFile.RightToLeft = RightToLeft.No;
            _btnCVSFile.Size = new Size(92, 60);
            _btnCVSFile.TabIndex = 29;
            _btnCVSFile.Text = "DeckLog" + '\r' + '\n' + "CSV File " + '\r' + '\n' + "Utility";
            _btnCVSFile.TextAlign = ContentAlignment.BottomRight;
            ToolTip1.SetToolTip(_btnCVSFile, "Utility to allow view and updating of CSV report files ");
            _btnCVSFile.UseVisualStyleBackColor = false;
            // 
            // btnDevForm
            // 
            _btnDevForm.BackColor = SystemColors.Control;
            _btnDevForm.Cursor = Cursors.Default;
            _btnDevForm.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnDevForm.ForeColor = SystemColors.ControlText;
            _btnDevForm.Image = (Image)resources.GetObject("btnDevForm.Image");
            _btnDevForm.ImageAlign = ContentAlignment.TopLeft;
            _btnDevForm.Location = new Point(590, 82);
            _btnDevForm.Name = "_btnDevForm";
            _btnDevForm.RightToLeft = RightToLeft.No;
            _btnDevForm.Size = new Size(92, 60);
            _btnDevForm.TabIndex = 30;
            _btnDevForm.Text = "Deviation " + '\r' + '\n' + "Data Form";
            _btnDevForm.TextAlign = ContentAlignment.BottomRight;
            ToolTip1.SetToolTip(_btnDevForm, "Input and Interpolate Deviation data for Compass Magnetic Headings ");
            _btnDevForm.UseVisualStyleBackColor = false;
            // 
            // Label1
            // 
            Label1.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(173)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(214)));
            Label1.Cursor = Cursors.Default;
            Label1.Font = new Font("Tahoma", 24.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.Red;
            Label1.Location = new Point(25, 83);
            Label1.Name = "Label1";
            Label1.RightToLeft = RightToLeft.No;
            Label1.Size = new Size(699, 46);
            Label1.TabIndex = 20;
            Label1.Text = "Celestial Tools:  Navigation Class Tools";
            Label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ExitBtn
            // 
            _ExitBtn.BackColor = Color.Red;
            _ExitBtn.Cursor = Cursors.Default;
            _ExitBtn.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _ExitBtn.ForeColor = SystemColors.ControlLightLight;
            _ExitBtn.Image = (Image)resources.GetObject("ExitBtn.Image");
            _ExitBtn.ImageAlign = ContentAlignment.TopCenter;
            _ExitBtn.Location = new Point(632, 516);
            _ExitBtn.Name = "_ExitBtn";
            _ExitBtn.RightToLeft = RightToLeft.No;
            _ExitBtn.Size = new Size(92, 60);
            _ExitBtn.TabIndex = 24;
            _ExitBtn.Text = "Exit";
            _ExitBtn.TextAlign = ContentAlignment.BottomCenter;
            _ExitBtn.UseVisualStyleBackColor = false;
            // 
            // HelpV2Btn
            // 
            _HelpV2Btn.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)));
            _HelpV2Btn.Cursor = Cursors.Default;
            _HelpV2Btn.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _HelpV2Btn.ForeColor = SystemColors.ControlText;
            _HelpV2Btn.Image = (Image)resources.GetObject("HelpV2Btn.Image");
            _HelpV2Btn.ImageAlign = ContentAlignment.TopCenter;
            _HelpV2Btn.Location = new Point(24, 518);
            _HelpV2Btn.Name = "_HelpV2Btn";
            _HelpV2Btn.RightToLeft = RightToLeft.No;
            _HelpV2Btn.Size = new Size(92, 60);
            _HelpV2Btn.TabIndex = 25;
            _HelpV2Btn.Text = "Help";
            _HelpV2Btn.TextAlign = ContentAlignment.BottomCenter;
            _HelpV2Btn.UseVisualStyleBackColor = false;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.ABC_white;
            PictureBox1.InitialImage = (Image)resources.GetObject("PictureBox1.InitialImage");
            PictureBox1.Location = new Point(99, 12);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(555, 68);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 28;
            PictureBox1.TabStop = false;
            // 
            // cmdAbout
            // 
            _cmdAbout.BackColor = Color.Blue;
            _cmdAbout.Cursor = Cursors.Default;
            _cmdAbout.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdAbout.ForeColor = SystemColors.ControlLightLight;
            _cmdAbout.Image = (Image)resources.GetObject("cmdAbout.Image");
            _cmdAbout.ImageAlign = ContentAlignment.TopCenter;
            _cmdAbout.Location = new Point(324, 516);
            _cmdAbout.Name = "_cmdAbout";
            _cmdAbout.RightToLeft = RightToLeft.No;
            _cmdAbout.Size = new Size(92, 60);
            _cmdAbout.TabIndex = 19;
            _cmdAbout.Text = "About";
            _cmdAbout.TextAlign = ContentAlignment.BottomCenter;
            _cmdAbout.UseVisualStyleBackColor = false;
            // 
            // GroupBox1
            // 
            GroupBox1.BackColor = Color.DarkGray;
            GroupBox1.Controls.Add(_SRMethod);
            GroupBox1.Controls.Add(_cmdPlanning);
            GroupBox1.Controls.Add(_btnFavLocs);
            GroupBox1.Controls.Add(_cmdReduction);
            GroupBox1.Controls.Add(_btnSightLog);
            GroupBox1.Controls.Add(_cmdNoon);
            GroupBox1.Controls.Add(_cmdYellow);
            GroupBox1.Cursor = Cursors.Default;
            GroupBox1.Location = new Point(24, 133);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(700, 111);
            GroupBox1.TabIndex = 29;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Celestial Navigation Tools:  Plan, Reduce, Plot Sights";
            // 
            // GroupBox2
            // 
            GroupBox2.BackColor = Color.DarkGray;
            GroupBox2.Controls.Add(_btnTraverseTable);
            GroupBox2.Controls.Add(_btnZoneTime);
            GroupBox2.Controls.Add(_btnDevForm);
            GroupBox2.Controls.Add(_btnCVSFile);
            GroupBox2.Controls.Add(_btnDeckLog);
            GroupBox2.Controls.Add(_cmd60DST);
            GroupBox2.Controls.Add(_cmdArcTime);
            GroupBox2.Controls.Add(_cmdSailings);
            GroupBox2.Controls.Add(_cmdCTSSOA);
            GroupBox2.Controls.Add(_cmdDistances);
            GroupBox2.Controls.Add(_cmdCurrents);
            GroupBox2.Controls.Add(_cmdInterpolate);
            GroupBox2.Controls.Add(_cmdTides);
            GroupBox2.Controls.Add(_cmdTVMDC);
            GroupBox2.Controls.Add(_cmdTwoBearings);
            GroupBox2.Controls.Add(_cmdLengthDeg);
            GroupBox2.Controls.Add(_cmdCPA);
            GroupBox2.Location = new Point(24, 254);
            GroupBox2.Name = "GroupBox2";
            GroupBox2.Size = new Size(700, 221);
            GroupBox2.TabIndex = 30;
            GroupBox2.TabStop = false;
            GroupBox2.Text = "Marine Navigation Tools";
            // 
            // btnTraverseTable
            // 
            _btnTraverseTable.BackColor = SystemColors.Control;
            _btnTraverseTable.Cursor = Cursors.Default;
            _btnTraverseTable.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnTraverseTable.ForeColor = SystemColors.ControlText;
            _btnTraverseTable.Image = (Image)resources.GetObject("btnTraverseTable.Image");
            _btnTraverseTable.ImageAlign = ContentAlignment.TopLeft;
            _btnTraverseTable.Location = new Point(590, 18);
            _btnTraverseTable.Name = "_btnTraverseTable";
            _btnTraverseTable.RightToLeft = RightToLeft.No;
            _btnTraverseTable.Size = new Size(92, 60);
            _btnTraverseTable.TabIndex = 32;
            _btnTraverseTable.Text = "Dest L/Lo" + '\r' + '\n' + "Using " + '\r' + '\n' + "Traverse Table";
            _btnTraverseTable.TextAlign = ContentAlignment.BottomRight;
            _btnTraverseTable.UseVisualStyleBackColor = false;
            // 
            // btnZoneTime
            // 
            _btnZoneTime.BackColor = SystemColors.Control;
            _btnZoneTime.Cursor = Cursors.Default;
            _btnZoneTime.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnZoneTime.ForeColor = SystemColors.ControlText;
            _btnZoneTime.Image = (Image)resources.GetObject("btnZoneTime.Image");
            _btnZoneTime.ImageAlign = ContentAlignment.TopCenter;
            _btnZoneTime.Location = new Point(590, 148);
            _btnZoneTime.Name = "_btnZoneTime";
            _btnZoneTime.RightToLeft = RightToLeft.No;
            _btnZoneTime.Size = new Size(92, 60);
            _btnZoneTime.TabIndex = 31;
            _btnZoneTime.Text = "Zone Time Calc";
            _btnZoneTime.TextAlign = ContentAlignment.BottomCenter;
            _btnZoneTime.UseVisualStyleBackColor = false;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(173)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(214)));
            ClientSize = new Size(736, 598);
            Controls.Add(GroupBox2);
            Controls.Add(GroupBox1);
            Controls.Add(PictureBox1);
            Controls.Add(_HelpV2Btn);
            Controls.Add(_ExitBtn);
            Controls.Add(_cmdAbout);
            Controls.Add(Label1);
            Cursor = Cursors.Default;
            Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(15)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Location = new Point(37, 165);
            MaximizeBox = false;
            Name = "MainMenu";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Celestial Tools";
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            GroupBox1.ResumeLayout(false);
            GroupBox2.ResumeLayout(false);
            Load += new EventHandler(MainMenu_Load);
            FormClosed += new FormClosedEventHandler(MainMenu_FormClosed);
            ResumeLayout(false);
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

        private Button _HelpV2Btn;

        public Button HelpV2Btn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _HelpV2Btn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_HelpV2Btn != null)
                {
                    _HelpV2Btn.Click -= HelpV2Btn_Click;
                }

                _HelpV2Btn = value;
                if (_HelpV2Btn != null)
                {
                    _HelpV2Btn.Click += HelpV2Btn_Click;
                }
            }
        }

        private Button _btnSightLog;

        public Button btnSightLog
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSightLog;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSightLog != null)
                {
                    _btnSightLog.Click -= btnSightLog_Click;
                }

                _btnSightLog = value;
                if (_btnSightLog != null)
                {
                    _btnSightLog.Click += btnSightLog_Click;
                }
            }
        }

        private Button _btnFavLocs;

        public Button btnFavLocs
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnFavLocs;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnFavLocs != null)
                {
                    _btnFavLocs.Click -= btnFavLocs_Click;
                }

                _btnFavLocs = value;
                if (_btnFavLocs != null)
                {
                    _btnFavLocs.Click += btnFavLocs_Click;
                }
            }
        }

        internal PictureBox PictureBox1;
        private Button _cmdAbout;

        public Button cmdAbout
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdAbout;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdAbout != null)
                {
                    _cmdAbout.Click -= cmdAbout_Click;
                }

                _cmdAbout = value;
                if (_cmdAbout != null)
                {
                    _cmdAbout.Click += cmdAbout_Click;
                }
            }
        }

        internal GroupBox GroupBox1;
        internal GroupBox GroupBox2;
        private Button _btnDeckLog;

        public Button btnDeckLog
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnDeckLog;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnDeckLog != null)
                {
                    _btnDeckLog.Click -= btnDeckLog_Click;
                }

                _btnDeckLog = value;
                if (_btnDeckLog != null)
                {
                    _btnDeckLog.Click += btnDeckLog_Click;
                }
            }
        }

        private Button _btnCVSFile;

        public Button btnCVSFile
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnCVSFile;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnCVSFile != null)
                {
                    _btnCVSFile.Click -= btnCVSFile_Click;
                }

                _btnCVSFile = value;
                if (_btnCVSFile != null)
                {
                    _btnCVSFile.Click += btnCVSFile_Click;
                }
            }
        }

        private Button _btnDevForm;

        public Button btnDevForm
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnDevForm;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnDevForm != null)
                {
                    _btnDevForm.Click -= btnDevForm_Click;
                }

                _btnDevForm = value;
                if (_btnDevForm != null)
                {
                    _btnDevForm.Click += btnDevForm_Click;
                }
            }
        }

        private Button _btnZoneTime;

        public Button btnZoneTime
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnZoneTime;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnZoneTime != null)
                {
                    _btnZoneTime.Click -= btnZoneTime_Click;
                }

                _btnZoneTime = value;
                if (_btnZoneTime != null)
                {
                    _btnZoneTime.Click += btnZoneTime_Click;
                }
            }
        }

        private Button _btnTraverseTable;

        public Button btnTraverseTable
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnTraverseTable;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnTraverseTable != null)
                {
                    _btnTraverseTable.Click -= btnTraverseTable_Click;
                }

                _btnTraverseTable = value;
                if (_btnTraverseTable != null)
                {
                    _btnTraverseTable.Click += btnTraverseTable_Click;
                }
            }
        }
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}