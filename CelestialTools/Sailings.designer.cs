using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    [DesignerGenerated()]
    internal partial class FormSailings
    {
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        [DebuggerNonUserCode()]
        public FormSailings() : base()
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
        private Button _cmdTraverse;

        public Button cmdTraverse
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdTraverse;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdTraverse != null)
                {
                    _cmdTraverse.Click -= cmdTraverse_Click;
                }

                _cmdTraverse = value;
                if (_cmdTraverse != null)
                {
                    _cmdTraverse.Click += cmdTraverse_Click;
                }
            }
        }

        private TextBox _txtL3Min;

        public TextBox txtL3Min
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtL3Min;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtL3Min != null)
                {
                    _txtL3Min.TextChanged -= txtL3Min_TextChanged;
                    _txtL3Min.KeyPress -= txtL3Min_KeyPress;
                    _txtL3Min.Validating -= txtL3Min_Validating;
                    _txtL3Min.Enter -= txtL3Min_Enter;
                }

                _txtL3Min = value;
                if (_txtL3Min != null)
                {
                    _txtL3Min.TextChanged += txtL3Min_TextChanged;
                    _txtL3Min.KeyPress += txtL3Min_KeyPress;
                    _txtL3Min.Validating += txtL3Min_Validating;
                    _txtL3Min.Enter += txtL3Min_Enter;
                }
            }
        }

        public ComboBox cboL3;
        private TextBox _txtL3Deg;

        public TextBox txtL3Deg
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtL3Deg;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtL3Deg != null)
                {
                    _txtL3Deg.TextChanged -= txtL3Deg_TextChanged;
                    _txtL3Deg.KeyPress -= txtL3Deg_KeyPress;
                    _txtL3Deg.Validating -= txtL3Deg_Validating;
                    _txtL3Deg.Enter -= txtL3Deg_Enter;
                }

                _txtL3Deg = value;
                if (_txtL3Deg != null)
                {
                    _txtL3Deg.TextChanged += txtL3Deg_TextChanged;
                    _txtL3Deg.KeyPress += txtL3Deg_KeyPress;
                    _txtL3Deg.Validating += txtL3Deg_Validating;
                    _txtL3Deg.Enter += txtL3Deg_Enter;
                }
            }
        }

        private RadioButton _optMethod2;

        public RadioButton optMethod2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optMethod2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optMethod2 != null)
                {
                    _optMethod2.CheckedChanged -= optMethod2_CheckedChanged;
                }

                _optMethod2 = value;
                if (_optMethod2 != null)
                {
                    _optMethod2.CheckedChanged += optMethod2_CheckedChanged;
                }
            }
        }

        private RadioButton _optMethod1;

        public RadioButton optMethod1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optMethod1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optMethod1 != null)
                {
                    _optMethod1.CheckedChanged -= optMethod1_CheckedChanged;
                }

                _optMethod1 = value;
                if (_optMethod1 != null)
                {
                    _optMethod1.CheckedChanged += optMethod1_CheckedChanged;
                }
            }
        }

        public Panel Frame3;
        private CheckBox _chkComposite;

        public CheckBox chkComposite
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _chkComposite;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_chkComposite != null)
                {
                    _chkComposite.CheckStateChanged -= chkComposite_CheckStateChanged;
                }

                _chkComposite = value;
                if (_chkComposite != null)
                {
                    _chkComposite.CheckStateChanged += chkComposite_CheckStateChanged;
                }
            }
        }

        public ComboBox cboMLmin;
        private CheckBox _chkDriftAngle;

        public CheckBox chkDriftAngle
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _chkDriftAngle;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_chkDriftAngle != null)
                {
                    _chkDriftAngle.CheckStateChanged -= chkDriftAngle_CheckStateChanged;
                }

                _chkDriftAngle = value;
                if (_chkDriftAngle != null)
                {
                    _chkDriftAngle.CheckStateChanged += chkDriftAngle_CheckStateChanged;
                }
            }
        }

        private TextBox _txtFix1LM;

        public TextBox txtFix1LM
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtFix1LM;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtFix1LM != null)
                {
                    _txtFix1LM.TextChanged -= txtFix1LM_TextChanged;
                    _txtFix1LM.KeyPress -= txtFix1LM_KeyPress;
                    _txtFix1LM.Validating -= txtFix1LM_Validating;
                    _txtFix1LM.Enter -= txtFix1LM_Enter;
                }

                _txtFix1LM = value;
                if (_txtFix1LM != null)
                {
                    _txtFix1LM.TextChanged += txtFix1LM_TextChanged;
                    _txtFix1LM.KeyPress += txtFix1LM_KeyPress;
                    _txtFix1LM.Validating += txtFix1LM_Validating;
                    _txtFix1LM.Enter += txtFix1LM_Enter;
                }
            }
        }

        public ComboBox cboFix1L;
        private TextBox _txtFix1LD;

        public TextBox txtFix1LD
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtFix1LD;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtFix1LD != null)
                {
                    _txtFix1LD.TextChanged -= txtFix1LD_TextChanged;
                    _txtFix1LD.KeyPress -= txtFix1LD_KeyPress;
                    _txtFix1LD.Validating -= txtFix1LD_Validating;
                    _txtFix1LD.Enter -= txtFix1LD_Enter;
                }

                _txtFix1LD = value;
                if (_txtFix1LD != null)
                {
                    _txtFix1LD.TextChanged += txtFix1LD_TextChanged;
                    _txtFix1LD.KeyPress += txtFix1LD_KeyPress;
                    _txtFix1LD.Validating += txtFix1LD_Validating;
                    _txtFix1LD.Enter += txtFix1LD_Enter;
                }
            }
        }

        private TextBox _txtFix1LoD;

        public TextBox txtFix1LoD
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtFix1LoD;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtFix1LoD != null)
                {
                    _txtFix1LoD.TextChanged -= txtFix1LoD_TextChanged;
                    _txtFix1LoD.KeyPress -= txtFix1LoD_KeyPress;
                    _txtFix1LoD.Validating -= txtFix1LoD_Validating;
                    _txtFix1LoD.Enter -= txtFix1LoD_Enter;
                }

                _txtFix1LoD = value;
                if (_txtFix1LoD != null)
                {
                    _txtFix1LoD.TextChanged += txtFix1LoD_TextChanged;
                    _txtFix1LoD.KeyPress += txtFix1LoD_KeyPress;
                    _txtFix1LoD.Validating += txtFix1LoD_Validating;
                    _txtFix1LoD.Enter += txtFix1LoD_Enter;
                }
            }
        }

        private TextBox _txtFix1LoM;

        public TextBox txtFix1LoM
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtFix1LoM;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtFix1LoM != null)
                {
                    _txtFix1LoM.TextChanged -= txtFix1LoM_TextChanged;
                    _txtFix1LoM.KeyPress -= txtFix1LoM_KeyPress;
                    _txtFix1LoM.Validating -= txtFix1LoM_Validating;
                    _txtFix1LoM.Enter -= txtFix1LoM_Enter;
                }

                _txtFix1LoM = value;
                if (_txtFix1LoM != null)
                {
                    _txtFix1LoM.TextChanged += txtFix1LoM_TextChanged;
                    _txtFix1LoM.KeyPress += txtFix1LoM_KeyPress;
                    _txtFix1LoM.Validating += txtFix1LoM_Validating;
                    _txtFix1LoM.Enter += txtFix1LoM_Enter;
                }
            }
        }

        public ComboBox cboFix1Lo;
        private RadioButton _optL2Lo2GC;

        public RadioButton optL2Lo2GC
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optL2Lo2GC;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optL2Lo2GC != null)
                {
                    _optL2Lo2GC.CheckedChanged -= optL2Lo2GC_CheckedChanged;
                }

                _optL2Lo2GC = value;
                if (_optL2Lo2GC != null)
                {
                    _optL2Lo2GC.CheckedChanged += optL2Lo2GC_CheckedChanged;
                }
            }
        }

        private RadioButton _optICD;

        public RadioButton optICD
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optICD;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optICD != null)
                {
                    _optICD.CheckedChanged -= optICD_CheckedChanged;
                }

                _optICD = value;
                if (_optICD != null)
                {
                    _optICD.CheckedChanged += optICD_CheckedChanged;
                }
            }
        }

        public GroupBox frameCalculateGC;
        private Button _cmdPoints;

        public Button cmdPoints
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdPoints;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdPoints != null)
                {
                    _cmdPoints.Click -= cmdPoints_Click;
                }

                _cmdPoints = value;
                if (_cmdPoints != null)
                {
                    _cmdPoints.Click += cmdPoints_Click;
                }
            }
        }

        private RadioButton _optMercatorS;

        public RadioButton optMercatorS
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optMercatorS;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optMercatorS != null)
                {
                    _optMercatorS.CheckedChanged -= optMercatorS_CheckedChanged;
                }

                _optMercatorS = value;
                if (_optMercatorS != null)
                {
                    _optMercatorS.CheckedChanged += optMercatorS_CheckedChanged;
                }
            }
        }

        private RadioButton _optAccurateRhumb;

        public RadioButton optAccurateRhumb
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optAccurateRhumb;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optAccurateRhumb != null)
                {
                    _optAccurateRhumb.CheckedChanged -= optAccurateRhumb_CheckedChanged;
                }

                _optAccurateRhumb = value;
                if (_optAccurateRhumb != null)
                {
                    _optAccurateRhumb.CheckedChanged += optAccurateRhumb_CheckedChanged;
                }
            }
        }

        private RadioButton _optGreatCircle;

        public RadioButton optGreatCircle
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optGreatCircle;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optGreatCircle != null)
                {
                    _optGreatCircle.CheckedChanged -= optGreatCircle_CheckedChanged;
                }

                _optGreatCircle = value;
                if (_optGreatCircle != null)
                {
                    _optGreatCircle.CheckedChanged += optGreatCircle_CheckedChanged;
                }
            }
        }

        private RadioButton _optMercatorE;

        public RadioButton optMercatorE
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optMercatorE;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optMercatorE != null)
                {
                    _optMercatorE.CheckedChanged -= optMercatorE_CheckedChanged;
                }

                _optMercatorE = value;
                if (_optMercatorE != null)
                {
                    _optMercatorE.CheckedChanged += optMercatorE_CheckedChanged;
                }
            }
        }

        private RadioButton _optMidLat;

        public RadioButton optMidLat
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optMidLat;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optMidLat != null)
                {
                    _optMidLat.CheckedChanged -= optMidLat_CheckedChanged;
                }

                _optMidLat = value;
                if (_optMidLat != null)
                {
                    _optMidLat.CheckedChanged += optMidLat_CheckedChanged;
                }
            }
        }

        public GroupBox Frame1;
        private TextBox _txtTime2;

        public TextBox txtTime2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtTime2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtTime2 != null)
                {
                    _txtTime2.TextChanged -= txtTime2_TextChanged;
                    _txtTime2.KeyPress -= txtTime2_KeyPress;
                    _txtTime2.Validating -= txtTime2_Validating;
                    _txtTime2.Enter -= txtTime2_Enter;
                }

                _txtTime2 = value;
                if (_txtTime2 != null)
                {
                    _txtTime2.TextChanged += txtTime2_TextChanged;
                    _txtTime2.KeyPress += txtTime2_KeyPress;
                    _txtTime2.Validating += txtTime2_Validating;
                    _txtTime2.Enter += txtTime2_Enter;
                }
            }
        }

        private TextBox _txtTime1;

        public TextBox txtTime1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtTime1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtTime1 != null)
                {
                    _txtTime1.TextChanged -= txtTime1_TextChanged;
                    _txtTime1.KeyPress -= txtTime1_KeyPress;
                    _txtTime1.Validating -= txtTime1_Validating;
                    _txtTime1.Enter -= txtTime1_Enter;
                }

                _txtTime1 = value;
                if (_txtTime1 != null)
                {
                    _txtTime1.TextChanged += txtTime1_TextChanged;
                    _txtTime1.KeyPress += txtTime1_KeyPress;
                    _txtTime1.Validating += txtTime1_Validating;
                    _txtTime1.Enter += txtTime1_Enter;
                }
            }
        }

        private TextBox _txtLog2;

        public TextBox txtLog2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtLog2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtLog2 != null)
                {
                    _txtLog2.TextChanged -= txtLog2_TextChanged;
                    _txtLog2.KeyPress -= txtLog2_KeyPress;
                    _txtLog2.Validating -= txtLog2_Validating;
                    _txtLog2.Enter -= txtLog2_Enter;
                }

                _txtLog2 = value;
                if (_txtLog2 != null)
                {
                    _txtLog2.TextChanged += txtLog2_TextChanged;
                    _txtLog2.KeyPress += txtLog2_KeyPress;
                    _txtLog2.Validating += txtLog2_Validating;
                    _txtLog2.Enter += txtLog2_Enter;
                }
            }
        }

        private TextBox _txtLog1;

        public TextBox txtLog1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtLog1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtLog1 != null)
                {
                    _txtLog1.TextChanged -= txtLog1_TextChanged;
                    _txtLog1.KeyPress -= txtLog1_KeyPress;
                    _txtLog1.Validating -= txtLog1_Validating;
                    _txtLog1.Enter -= txtLog1_Enter;
                }

                _txtLog1 = value;
                if (_txtLog1 != null)
                {
                    _txtLog1.TextChanged += txtLog1_TextChanged;
                    _txtLog1.KeyPress += txtLog1_KeyPress;
                    _txtLog1.Validating += txtLog1_Validating;
                    _txtLog1.Enter += txtLog1_Enter;
                }
            }
        }

        public ComboBox cboML;
        private TextBox _txtMLDeg;

        public TextBox txtMLDeg
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtMLDeg;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtMLDeg != null)
                {
                    _txtMLDeg.TextChanged -= txtMLDeg_TextChanged;
                    _txtMLDeg.KeyPress -= txtMLDeg_KeyPress;
                    _txtMLDeg.Validating -= txtMLDeg_Validating;
                    _txtMLDeg.Enter -= txtMLDeg_Enter;
                }

                _txtMLDeg = value;
                if (_txtMLDeg != null)
                {
                    _txtMLDeg.TextChanged += txtMLDeg_TextChanged;
                    _txtMLDeg.KeyPress += txtMLDeg_KeyPress;
                    _txtMLDeg.Validating += txtMLDeg_Validating;
                    _txtMLDeg.Enter += txtMLDeg_Enter;
                }
            }
        }

        public CheckBox chkML;
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

        private Button _cmdClearSwap;

        public Button cmdClearSwap
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdClearSwap;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdClearSwap != null)
                {
                    _cmdClearSwap.Click -= cmdClearSwap_Click;
                }

                _cmdClearSwap = value;
                if (_cmdClearSwap != null)
                {
                    _cmdClearSwap.Click += cmdClearSwap_Click;
                }
            }
        }

        private Button _cmdClearAll;

        public Button cmdClearAll
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdClearAll;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdClearAll != null)
                {
                    _cmdClearAll.Click -= cmdClearAll_Click;
                }

                _cmdClearAll = value;
                if (_cmdClearAll != null)
                {
                    _cmdClearAll.Click += cmdClearAll_Click;
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

        private TextBox _txtTimem;

        public TextBox txtTimem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtTimem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtTimem != null)
                {
                    _txtTimem.TextChanged -= txtTimem_TextChanged;
                    _txtTimem.KeyPress -= txtTimem_KeyPress;
                    _txtTimem.Validating -= txtTimem_Validating;
                    _txtTimem.Enter -= txtTimem_Enter;
                }

                _txtTimem = value;
                if (_txtTimem != null)
                {
                    _txtTimem.TextChanged += txtTimem_TextChanged;
                    _txtTimem.KeyPress += txtTimem_KeyPress;
                    _txtTimem.Validating += txtTimem_Validating;
                    _txtTimem.Enter += txtTimem_Enter;
                }
            }
        }

        private TextBox _txtTimeh;

        public TextBox txtTimeh
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtTimeh;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtTimeh != null)
                {
                    _txtTimeh.TextChanged -= txtTimeh_TextChanged;
                    _txtTimeh.KeyPress -= txtTimeh_KeyPress;
                    _txtTimeh.Validating -= txtTimeh_Validating;
                    _txtTimeh.Enter -= txtTimeh_Enter;
                }

                _txtTimeh = value;
                if (_txtTimeh != null)
                {
                    _txtTimeh.TextChanged += txtTimeh_TextChanged;
                    _txtTimeh.KeyPress += txtTimeh_KeyPress;
                    _txtTimeh.Validating += txtTimeh_Validating;
                    _txtTimeh.Enter += txtTimeh_Enter;
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

        private TextBox _txtDist;

        public TextBox txtDist
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtDist;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtDist != null)
                {
                    _txtDist.TextChanged -= txtDist_TextChanged;
                    _txtDist.KeyPress -= txtDist_KeyPress;
                    _txtDist.Validating -= txtDist_Validating;
                    _txtDist.Enter -= txtDist_Enter;
                }

                _txtDist = value;
                if (_txtDist != null)
                {
                    _txtDist.TextChanged += txtDist_TextChanged;
                    _txtDist.KeyPress += txtDist_KeyPress;
                    _txtDist.Validating += txtDist_Validating;
                    _txtDist.Enter += txtDist_Enter;
                }
            }
        }

        private TextBox _txtCourse;

        public TextBox txtCourse
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtCourse;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtCourse != null)
                {
                    _txtCourse.TextChanged -= txtCourse_TextChanged;
                    _txtCourse.KeyPress -= txtCourse_KeyPress;
                    _txtCourse.Validating -= txtCourse_Validating;
                    _txtCourse.Enter -= txtCourse_Enter;
                }

                _txtCourse = value;
                if (_txtCourse != null)
                {
                    _txtCourse.TextChanged += txtCourse_TextChanged;
                    _txtCourse.KeyPress += txtCourse_KeyPress;
                    _txtCourse.Validating += txtCourse_Validating;
                    _txtCourse.Enter += txtCourse_Enter;
                }
            }
        }

        private RadioButton _optSD;

        public RadioButton optSD
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optSD;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optSD != null)
                {
                    _optSD.CheckedChanged -= optSD_CheckedChanged;
                }

                _optSD = value;
                if (_optSD != null)
                {
                    _optSD.CheckedChanged += optSD_CheckedChanged;
                }
            }
        }

        private RadioButton _optCD;

        public RadioButton optCD
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optCD;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optCD != null)
                {
                    _optCD.CheckedChanged -= optCD_CheckedChanged;
                }

                _optCD = value;
                if (_optCD != null)
                {
                    _optCD.CheckedChanged += optCD_CheckedChanged;
                }
            }
        }

        private RadioButton _optL2Lo2;

        public RadioButton optL2Lo2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optL2Lo2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optL2Lo2 != null)
                {
                    _optL2Lo2.CheckedChanged -= optL2Lo2_CheckedChanged;
                }

                _optL2Lo2 = value;
                if (_optL2Lo2 != null)
                {
                    _optL2Lo2.CheckedChanged += optL2Lo2_CheckedChanged;
                }
            }
        }

        public GroupBox frameCalculate;
        public ComboBox cboLo1;
        private TextBox _txtLo1Min;

        public TextBox txtLo1Min
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtLo1Min;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtLo1Min != null)
                {
                    _txtLo1Min.TextChanged -= txtLo1Min_TextChanged;
                    _txtLo1Min.KeyPress -= txtLo1Min_KeyPress;
                    _txtLo1Min.Validating -= txtLo1Min_Validating;
                    _txtLo1Min.Enter -= txtLo1Min_Enter;
                }

                _txtLo1Min = value;
                if (_txtLo1Min != null)
                {
                    _txtLo1Min.TextChanged += txtLo1Min_TextChanged;
                    _txtLo1Min.KeyPress += txtLo1Min_KeyPress;
                    _txtLo1Min.Validating += txtLo1Min_Validating;
                    _txtLo1Min.Enter += txtLo1Min_Enter;
                }
            }
        }

        private TextBox _txtLo1Deg;

        public TextBox txtLo1Deg
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtLo1Deg;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtLo1Deg != null)
                {
                    _txtLo1Deg.TextChanged -= txtLo1Deg_TextChanged;
                    _txtLo1Deg.KeyPress -= txtLo1Deg_KeyPress;
                    _txtLo1Deg.Validating -= txtLo1Deg_Validating;
                    _txtLo1Deg.Enter -= txtLo1Deg_Enter;
                }

                _txtLo1Deg = value;
                if (_txtLo1Deg != null)
                {
                    _txtLo1Deg.TextChanged += txtLo1Deg_TextChanged;
                    _txtLo1Deg.KeyPress += txtLo1Deg_KeyPress;
                    _txtLo1Deg.Validating += txtLo1Deg_Validating;
                    _txtLo1Deg.Enter += txtLo1Deg_Enter;
                }
            }
        }

        private TextBox _txtL1Deg;

        public TextBox txtL1Deg
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtL1Deg;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtL1Deg != null)
                {
                    _txtL1Deg.TextChanged -= txtL1Deg_TextChanged;
                    _txtL1Deg.KeyPress -= txtL1Deg_KeyPress;
                    _txtL1Deg.Validating -= txtL1Deg_Validating;
                    _txtL1Deg.Enter -= txtL1Deg_Enter;
                }

                _txtL1Deg = value;
                if (_txtL1Deg != null)
                {
                    _txtL1Deg.TextChanged += txtL1Deg_TextChanged;
                    _txtL1Deg.KeyPress += txtL1Deg_KeyPress;
                    _txtL1Deg.Validating += txtL1Deg_Validating;
                    _txtL1Deg.Enter += txtL1Deg_Enter;
                }
            }
        }

        public ComboBox cboL1;
        private TextBox _txtL1Min;

        public TextBox txtL1Min
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtL1Min;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtL1Min != null)
                {
                    _txtL1Min.TextChanged -= txtL1Min_TextChanged;
                    _txtL1Min.KeyPress -= txtL1Min_KeyPress;
                    _txtL1Min.Validating -= txtL1Min_Validating;
                    _txtL1Min.Enter -= txtL1Min_Enter;
                }

                _txtL1Min = value;
                if (_txtL1Min != null)
                {
                    _txtL1Min.TextChanged += txtL1Min_TextChanged;
                    _txtL1Min.KeyPress += txtL1Min_KeyPress;
                    _txtL1Min.Validating += txtL1Min_Validating;
                    _txtL1Min.Enter += txtL1Min_Enter;
                }
            }
        }

        public ComboBox cboLo2;
        private TextBox _txtLo2Min;

        public TextBox txtLo2Min
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtLo2Min;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtLo2Min != null)
                {
                    _txtLo2Min.TextChanged -= txtLo2Min_TextChanged;
                    _txtLo2Min.KeyPress -= txtLo2Min_KeyPress;
                    _txtLo2Min.Validating -= txtLo2Min_Validating;
                    _txtLo2Min.Enter -= txtLo2Min_Enter;
                }

                _txtLo2Min = value;
                if (_txtLo2Min != null)
                {
                    _txtLo2Min.TextChanged += txtLo2Min_TextChanged;
                    _txtLo2Min.KeyPress += txtLo2Min_KeyPress;
                    _txtLo2Min.Validating += txtLo2Min_Validating;
                    _txtLo2Min.Enter += txtLo2Min_Enter;
                }
            }
        }

        private TextBox _txtLo2Deg;

        public TextBox txtLo2Deg
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtLo2Deg;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtLo2Deg != null)
                {
                    _txtLo2Deg.TextChanged -= txtLo2Deg_TextChanged;
                    _txtLo2Deg.KeyPress -= txtLo2Deg_KeyPress;
                    _txtLo2Deg.Validating -= txtLo2Deg_Validating;
                    _txtLo2Deg.Enter -= txtLo2Deg_Enter;
                }

                _txtLo2Deg = value;
                if (_txtLo2Deg != null)
                {
                    _txtLo2Deg.TextChanged += txtLo2Deg_TextChanged;
                    _txtLo2Deg.KeyPress += txtLo2Deg_KeyPress;
                    _txtLo2Deg.Validating += txtLo2Deg_Validating;
                    _txtLo2Deg.Enter += txtLo2Deg_Enter;
                }
            }
        }

        private TextBox _txtL2Deg;

        public TextBox txtL2Deg
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtL2Deg;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtL2Deg != null)
                {
                    _txtL2Deg.TextChanged -= txtL2Deg_TextChanged;
                    _txtL2Deg.KeyPress -= txtL2Deg_KeyPress;
                    _txtL2Deg.Validating -= txtL2Deg_Validating;
                    _txtL2Deg.Enter -= txtL2Deg_Enter;
                }

                _txtL2Deg = value;
                if (_txtL2Deg != null)
                {
                    _txtL2Deg.TextChanged += txtL2Deg_TextChanged;
                    _txtL2Deg.KeyPress += txtL2Deg_KeyPress;
                    _txtL2Deg.Validating += txtL2Deg_Validating;
                    _txtL2Deg.Enter += txtL2Deg_Enter;
                }
            }
        }

        public ComboBox cboL2;
        private TextBox _txtL2Min;

        public TextBox txtL2Min
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtL2Min;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtL2Min != null)
                {
                    _txtL2Min.TextChanged -= txtL2Min_TextChanged;
                    _txtL2Min.KeyPress -= txtL2Min_KeyPress;
                    _txtL2Min.Validating -= txtL2Min_Validating;
                    _txtL2Min.Enter -= txtL2Min_Enter;
                }

                _txtL2Min = value;
                if (_txtL2Min != null)
                {
                    _txtL2Min.TextChanged += txtL2Min_TextChanged;
                    _txtL2Min.KeyPress += txtL2Min_KeyPress;
                    _txtL2Min.Validating += txtL2Min_Validating;
                    _txtL2Min.Enter += txtL2Min_Enter;
                }
            }
        }

        public Label Label15;
        public Label Label16;
        public Label lblLimLat;
        public Label Label14;
        public Label Label13;
        public Label Label12;
        public Label Label11;
        public Label Label10;
        public Label Label9;
        public Label lblInitial;
        public Label lblor2;
        // Public WithEvents Line6 As Microsoft.VisualBasic.PowerPacks.LineShape
        // Public WithEvents Line5 As Microsoft.VisualBasic.PowerPacks.LineShape
        // Public WithEvents Line4 As Microsoft.VisualBasic.PowerPacks.LineShape
        // Public WithEvents Line3 As Microsoft.VisualBasic.PowerPacks.LineShape
        // Public WithEvents Line2 As Microsoft.VisualBasic.PowerPacks.LineShape
        public Label lblTime2;
        public Label lblTime1;
        // Public WithEvents Shape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
        public Label lblLog2nm;
        public Label lblLog1nm;
        public Label lblLog2;
        public Label lblLog1;
        public Label Label4;
        public Label Label1;
        public Label lblFixLo;
        public Label lblFixL;
        public Label lblDRLo;
        public Label lblDRL;
        // Public WithEvents Line1 As Microsoft.VisualBasic.PowerPacks.LineShape
        public Label lblm;
        public Label lblh;
        public Label lblTime;
        public Label lblkn;
        public Label lblSpeed;
        public Label lblor;
        public Label lblnm;
        public Label lblDistance;
        public Label lblCourseDeg;
        public Label lblCourse;
        public Label Label6;
        public Label Label5;
        public Label lblLo1;
        public Label Label3;
        public Label Label2;
        public Label lblL1;
        public Label lblLoMin;
        public Label lblLoDeg;
        public Label lblLo2;
        public Label lblLMin;
        public Label lblLDeg;
        public Label lblL2;
        // Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSailings));
            ToolTip1 = new ToolTip(components);
            _txtL3Min = new TextBox();
            _txtL3Min.TextChanged += new EventHandler(txtL3Min_TextChanged);
            _txtL3Min.KeyPress += new KeyPressEventHandler(txtL3Min_KeyPress);
            _txtL3Min.Validating += new System.ComponentModel.CancelEventHandler(txtL3Min_Validating);
            _txtL3Min.Enter += new EventHandler(txtL3Min_Enter);
            _txtL3Deg = new TextBox();
            _txtL3Deg.TextChanged += new EventHandler(txtL3Deg_TextChanged);
            _txtL3Deg.KeyPress += new KeyPressEventHandler(txtL3Deg_KeyPress);
            _txtL3Deg.Validating += new System.ComponentModel.CancelEventHandler(txtL3Deg_Validating);
            _txtL3Deg.Enter += new EventHandler(txtL3Deg_Enter);
            _txtFix1LM = new TextBox();
            _txtFix1LM.TextChanged += new EventHandler(txtFix1LM_TextChanged);
            _txtFix1LM.KeyPress += new KeyPressEventHandler(txtFix1LM_KeyPress);
            _txtFix1LM.Validating += new System.ComponentModel.CancelEventHandler(txtFix1LM_Validating);
            _txtFix1LM.Enter += new EventHandler(txtFix1LM_Enter);
            _txtFix1LD = new TextBox();
            _txtFix1LD.TextChanged += new EventHandler(txtFix1LD_TextChanged);
            _txtFix1LD.KeyPress += new KeyPressEventHandler(txtFix1LD_KeyPress);
            _txtFix1LD.Validating += new System.ComponentModel.CancelEventHandler(txtFix1LD_Validating);
            _txtFix1LD.Enter += new EventHandler(txtFix1LD_Enter);
            _txtFix1LoD = new TextBox();
            _txtFix1LoD.TextChanged += new EventHandler(txtFix1LoD_TextChanged);
            _txtFix1LoD.KeyPress += new KeyPressEventHandler(txtFix1LoD_KeyPress);
            _txtFix1LoD.Validating += new System.ComponentModel.CancelEventHandler(txtFix1LoD_Validating);
            _txtFix1LoD.Enter += new EventHandler(txtFix1LoD_Enter);
            _txtFix1LoM = new TextBox();
            _txtFix1LoM.TextChanged += new EventHandler(txtFix1LoM_TextChanged);
            _txtFix1LoM.KeyPress += new KeyPressEventHandler(txtFix1LoM_KeyPress);
            _txtFix1LoM.Validating += new System.ComponentModel.CancelEventHandler(txtFix1LoM_Validating);
            _txtFix1LoM.Enter += new EventHandler(txtFix1LoM_Enter);
            _txtTime2 = new TextBox();
            _txtTime2.TextChanged += new EventHandler(txtTime2_TextChanged);
            _txtTime2.KeyPress += new KeyPressEventHandler(txtTime2_KeyPress);
            _txtTime2.Validating += new System.ComponentModel.CancelEventHandler(txtTime2_Validating);
            _txtTime2.Enter += new EventHandler(txtTime2_Enter);
            _txtTime1 = new TextBox();
            _txtTime1.TextChanged += new EventHandler(txtTime1_TextChanged);
            _txtTime1.KeyPress += new KeyPressEventHandler(txtTime1_KeyPress);
            _txtTime1.Validating += new System.ComponentModel.CancelEventHandler(txtTime1_Validating);
            _txtTime1.Enter += new EventHandler(txtTime1_Enter);
            _txtLog2 = new TextBox();
            _txtLog2.TextChanged += new EventHandler(txtLog2_TextChanged);
            _txtLog2.KeyPress += new KeyPressEventHandler(txtLog2_KeyPress);
            _txtLog2.Validating += new System.ComponentModel.CancelEventHandler(txtLog2_Validating);
            _txtLog2.Enter += new EventHandler(txtLog2_Enter);
            _txtLog1 = new TextBox();
            _txtLog1.TextChanged += new EventHandler(txtLog1_TextChanged);
            _txtLog1.KeyPress += new KeyPressEventHandler(txtLog1_KeyPress);
            _txtLog1.Validating += new System.ComponentModel.CancelEventHandler(txtLog1_Validating);
            _txtLog1.Enter += new EventHandler(txtLog1_Enter);
            _txtMLDeg = new TextBox();
            _txtMLDeg.TextChanged += new EventHandler(txtMLDeg_TextChanged);
            _txtMLDeg.KeyPress += new KeyPressEventHandler(txtMLDeg_KeyPress);
            _txtMLDeg.Validating += new System.ComponentModel.CancelEventHandler(txtMLDeg_Validating);
            _txtMLDeg.Enter += new EventHandler(txtMLDeg_Enter);
            _txtTimem = new TextBox();
            _txtTimem.TextChanged += new EventHandler(txtTimem_TextChanged);
            _txtTimem.KeyPress += new KeyPressEventHandler(txtTimem_KeyPress);
            _txtTimem.Validating += new System.ComponentModel.CancelEventHandler(txtTimem_Validating);
            _txtTimem.Enter += new EventHandler(txtTimem_Enter);
            _txtTimeh = new TextBox();
            _txtTimeh.TextChanged += new EventHandler(txtTimeh_TextChanged);
            _txtTimeh.KeyPress += new KeyPressEventHandler(txtTimeh_KeyPress);
            _txtTimeh.Validating += new System.ComponentModel.CancelEventHandler(txtTimeh_Validating);
            _txtTimeh.Enter += new EventHandler(txtTimeh_Enter);
            _txtSpeed = new TextBox();
            _txtSpeed.TextChanged += new EventHandler(txtSpeed_TextChanged);
            _txtSpeed.KeyPress += new KeyPressEventHandler(txtSpeed_KeyPress);
            _txtSpeed.Validating += new System.ComponentModel.CancelEventHandler(txtSpeed_Validating);
            _txtSpeed.Enter += new EventHandler(txtSpeed_Enter);
            _txtDist = new TextBox();
            _txtDist.TextChanged += new EventHandler(txtDist_TextChanged);
            _txtDist.KeyPress += new KeyPressEventHandler(txtDist_KeyPress);
            _txtDist.Validating += new System.ComponentModel.CancelEventHandler(txtDist_Validating);
            _txtDist.Enter += new EventHandler(txtDist_Enter);
            _txtCourse = new TextBox();
            _txtCourse.TextChanged += new EventHandler(txtCourse_TextChanged);
            _txtCourse.KeyPress += new KeyPressEventHandler(txtCourse_KeyPress);
            _txtCourse.Validating += new System.ComponentModel.CancelEventHandler(txtCourse_Validating);
            _txtCourse.Enter += new EventHandler(txtCourse_Enter);
            _txtLo1Min = new TextBox();
            _txtLo1Min.TextChanged += new EventHandler(txtLo1Min_TextChanged);
            _txtLo1Min.KeyPress += new KeyPressEventHandler(txtLo1Min_KeyPress);
            _txtLo1Min.Validating += new System.ComponentModel.CancelEventHandler(txtLo1Min_Validating);
            _txtLo1Min.Enter += new EventHandler(txtLo1Min_Enter);
            _txtLo1Deg = new TextBox();
            _txtLo1Deg.TextChanged += new EventHandler(txtLo1Deg_TextChanged);
            _txtLo1Deg.KeyPress += new KeyPressEventHandler(txtLo1Deg_KeyPress);
            _txtLo1Deg.Validating += new System.ComponentModel.CancelEventHandler(txtLo1Deg_Validating);
            _txtLo1Deg.Enter += new EventHandler(txtLo1Deg_Enter);
            _txtL1Deg = new TextBox();
            _txtL1Deg.TextChanged += new EventHandler(txtL1Deg_TextChanged);
            _txtL1Deg.KeyPress += new KeyPressEventHandler(txtL1Deg_KeyPress);
            _txtL1Deg.Validating += new System.ComponentModel.CancelEventHandler(txtL1Deg_Validating);
            _txtL1Deg.Enter += new EventHandler(txtL1Deg_Enter);
            _txtL1Min = new TextBox();
            _txtL1Min.TextChanged += new EventHandler(txtL1Min_TextChanged);
            _txtL1Min.KeyPress += new KeyPressEventHandler(txtL1Min_KeyPress);
            _txtL1Min.Validating += new System.ComponentModel.CancelEventHandler(txtL1Min_Validating);
            _txtL1Min.Enter += new EventHandler(txtL1Min_Enter);
            _txtLo2Min = new TextBox();
            _txtLo2Min.TextChanged += new EventHandler(txtLo2Min_TextChanged);
            _txtLo2Min.KeyPress += new KeyPressEventHandler(txtLo2Min_KeyPress);
            _txtLo2Min.Validating += new System.ComponentModel.CancelEventHandler(txtLo2Min_Validating);
            _txtLo2Min.Enter += new EventHandler(txtLo2Min_Enter);
            _txtLo2Deg = new TextBox();
            _txtLo2Deg.TextChanged += new EventHandler(txtLo2Deg_TextChanged);
            _txtLo2Deg.KeyPress += new KeyPressEventHandler(txtLo2Deg_KeyPress);
            _txtLo2Deg.Validating += new System.ComponentModel.CancelEventHandler(txtLo2Deg_Validating);
            _txtLo2Deg.Enter += new EventHandler(txtLo2Deg_Enter);
            _txtL2Deg = new TextBox();
            _txtL2Deg.TextChanged += new EventHandler(txtL2Deg_TextChanged);
            _txtL2Deg.KeyPress += new KeyPressEventHandler(txtL2Deg_KeyPress);
            _txtL2Deg.Validating += new System.ComponentModel.CancelEventHandler(txtL2Deg_Validating);
            _txtL2Deg.Enter += new EventHandler(txtL2Deg_Enter);
            _txtL2Min = new TextBox();
            _txtL2Min.TextChanged += new EventHandler(txtL2Min_TextChanged);
            _txtL2Min.KeyPress += new KeyPressEventHandler(txtL2Min_KeyPress);
            _txtL2Min.Validating += new System.ComponentModel.CancelEventHandler(txtL2Min_Validating);
            _txtL2Min.Enter += new EventHandler(txtL2Min_Enter);
            _cmdPrint = new Button();
            _cmdPrint.Click += new EventHandler(cmdPrint_Click);
            _cmdTraverse = new Button();
            _cmdTraverse.Click += new EventHandler(cmdTraverse_Click);
            cboL3 = new ComboBox();
            Frame3 = new Panel();
            _optMethod2 = new RadioButton();
            _optMethod2.CheckedChanged += new EventHandler(optMethod2_CheckedChanged);
            _optMethod1 = new RadioButton();
            _optMethod1.CheckedChanged += new EventHandler(optMethod1_CheckedChanged);
            _chkComposite = new CheckBox();
            _chkComposite.CheckStateChanged += new EventHandler(chkComposite_CheckStateChanged);
            cboMLmin = new ComboBox();
            _chkDriftAngle = new CheckBox();
            _chkDriftAngle.CheckStateChanged += new EventHandler(chkDriftAngle_CheckStateChanged);
            cboFix1L = new ComboBox();
            cboFix1Lo = new ComboBox();
            frameCalculateGC = new GroupBox();
            _optL2Lo2GC = new RadioButton();
            _optL2Lo2GC.CheckedChanged += new EventHandler(optL2Lo2GC_CheckedChanged);
            _optICD = new RadioButton();
            _optICD.CheckedChanged += new EventHandler(optICD_CheckedChanged);
            _cmdPoints = new Button();
            _cmdPoints.Click += new EventHandler(cmdPoints_Click);
            Frame1 = new GroupBox();
            _optMercatorS = new RadioButton();
            _optMercatorS.CheckedChanged += new EventHandler(optMercatorS_CheckedChanged);
            _optAccurateRhumb = new RadioButton();
            _optAccurateRhumb.CheckedChanged += new EventHandler(optAccurateRhumb_CheckedChanged);
            _optGreatCircle = new RadioButton();
            _optGreatCircle.CheckedChanged += new EventHandler(optGreatCircle_CheckedChanged);
            _optMercatorE = new RadioButton();
            _optMercatorE.CheckedChanged += new EventHandler(optMercatorE_CheckedChanged);
            _optMidLat = new RadioButton();
            _optMidLat.CheckedChanged += new EventHandler(optMidLat_CheckedChanged);
            cboML = new ComboBox();
            chkML = new CheckBox();
            _cmdClearSwap = new Button();
            _cmdClearSwap.Click += new EventHandler(cmdClearSwap_Click);
            _cmdClearAll = new Button();
            _cmdClearAll.Click += new EventHandler(cmdClearAll_Click);
            _cmdCalculate = new Button();
            _cmdCalculate.Click += new EventHandler(cmdCalculate_Click);
            frameCalculate = new GroupBox();
            _optSD = new RadioButton();
            _optSD.CheckedChanged += new EventHandler(optSD_CheckedChanged);
            _optCD = new RadioButton();
            _optCD.CheckedChanged += new EventHandler(optCD_CheckedChanged);
            _optL2Lo2 = new RadioButton();
            _optL2Lo2.CheckedChanged += new EventHandler(optL2Lo2_CheckedChanged);
            cboLo1 = new ComboBox();
            cboL1 = new ComboBox();
            cboLo2 = new ComboBox();
            cboL2 = new ComboBox();
            Label15 = new Label();
            Label16 = new Label();
            lblLimLat = new Label();
            Label14 = new Label();
            Label13 = new Label();
            Label12 = new Label();
            Label11 = new Label();
            Label10 = new Label();
            Label9 = new Label();
            lblInitial = new Label();
            lblor2 = new Label();
            lblTime2 = new Label();
            lblTime1 = new Label();
            lblLog2nm = new Label();
            lblLog1nm = new Label();
            lblLog2 = new Label();
            lblLog1 = new Label();
            Label4 = new Label();
            Label1 = new Label();
            lblFixLo = new Label();
            lblFixL = new Label();
            lblDRLo = new Label();
            lblDRL = new Label();
            lblm = new Label();
            lblh = new Label();
            lblTime = new Label();
            lblkn = new Label();
            lblSpeed = new Label();
            lblor = new Label();
            lblnm = new Label();
            lblDistance = new Label();
            lblCourseDeg = new Label();
            lblCourse = new Label();
            Label6 = new Label();
            Label5 = new Label();
            lblLo1 = new Label();
            Label3 = new Label();
            Label2 = new Label();
            lblL1 = new Label();
            lblLoMin = new Label();
            lblLoDeg = new Label();
            lblLo2 = new Label();
            lblLMin = new Label();
            lblLDeg = new Label();
            lblL2 = new Label();
            txtSailings = new RichTextBox();
            _ExitBtn = new Button();
            _ExitBtn.Click += new EventHandler(ExitBtn_Click);
            _cmdRhumbPoints = new Button();
            _cmdRhumbPoints.Click += new EventHandler(cmdRhumbPoints_Click);
            txtUserInfo = new TextBox();
            Label17 = new Label();
            PictureBox1 = new PictureBox();
            Label7 = new Label();
            Frame3.SuspendLayout();
            frameCalculateGC.SuspendLayout();
            Frame1.SuspendLayout();
            frameCalculate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtL3Min
            // 
            _txtL3Min.AcceptsReturn = true;
            _txtL3Min.BackColor = SystemColors.Window;
            _txtL3Min.Cursor = Cursors.IBeam;
            _txtL3Min.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtL3Min.ForeColor = SystemColors.WindowText;
            _txtL3Min.Location = new Point(289, 220);
            _txtL3Min.MaxLength = 0;
            _txtL3Min.Name = "_txtL3Min";
            _txtL3Min.RightToLeft = RightToLeft.No;
            _txtL3Min.Size = new Size(33, 20);
            _txtL3Min.TabIndex = 100;
            ToolTip1.SetToolTip(_txtL3Min, "Range 0 to 59.9");
            // 
            // txtL3Deg
            // 
            _txtL3Deg.AcceptsReturn = true;
            _txtL3Deg.BackColor = SystemColors.Window;
            _txtL3Deg.Cursor = Cursors.IBeam;
            _txtL3Deg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtL3Deg.ForeColor = SystemColors.WindowText;
            _txtL3Deg.Location = new Point(254, 220);
            _txtL3Deg.MaxLength = 0;
            _txtL3Deg.Name = "_txtL3Deg";
            _txtL3Deg.RightToLeft = RightToLeft.No;
            _txtL3Deg.Size = new Size(25, 20);
            _txtL3Deg.TabIndex = 99;
            ToolTip1.SetToolTip(_txtL3Deg, "Range 1 to 89");
            // 
            // txtFix1LM
            // 
            _txtFix1LM.AcceptsReturn = true;
            _txtFix1LM.BackColor = SystemColors.Window;
            _txtFix1LM.Cursor = Cursors.IBeam;
            _txtFix1LM.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtFix1LM.ForeColor = SystemColors.WindowText;
            _txtFix1LM.Location = new Point(105, 245);
            _txtFix1LM.MaxLength = 4;
            _txtFix1LM.Name = "_txtFix1LM";
            _txtFix1LM.RightToLeft = RightToLeft.No;
            _txtFix1LM.Size = new Size(33, 20);
            _txtFix1LM.TabIndex = 89;
            ToolTip1.SetToolTip(_txtFix1LM, "Range 0 to 59.9");
            _txtFix1LM.Visible = false;
            // 
            // txtFix1LD
            // 
            _txtFix1LD.AcceptsReturn = true;
            _txtFix1LD.BackColor = SystemColors.Window;
            _txtFix1LD.Cursor = Cursors.IBeam;
            _txtFix1LD.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtFix1LD.ForeColor = SystemColors.WindowText;
            _txtFix1LD.Location = new Point(60, 245);
            _txtFix1LD.MaxLength = 2;
            _txtFix1LD.Name = "_txtFix1LD";
            _txtFix1LD.RightToLeft = RightToLeft.No;
            _txtFix1LD.Size = new Size(35, 20);
            _txtFix1LD.TabIndex = 88;
            ToolTip1.SetToolTip(_txtFix1LD, "Range 0 to 89");
            _txtFix1LD.Visible = false;
            // 
            // txtFix1LoD
            // 
            _txtFix1LoD.AcceptsReturn = true;
            _txtFix1LoD.BackColor = SystemColors.Window;
            _txtFix1LoD.Cursor = Cursors.IBeam;
            _txtFix1LoD.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtFix1LoD.ForeColor = SystemColors.WindowText;
            _txtFix1LoD.Location = new Point(60, 269);
            _txtFix1LoD.MaxLength = 3;
            _txtFix1LoD.Name = "_txtFix1LoD";
            _txtFix1LoD.RightToLeft = RightToLeft.No;
            _txtFix1LoD.Size = new Size(35, 20);
            _txtFix1LoD.TabIndex = 91;
            ToolTip1.SetToolTip(_txtFix1LoD, "Range 0 to 180");
            _txtFix1LoD.Visible = false;
            // 
            // txtFix1LoM
            // 
            _txtFix1LoM.AcceptsReturn = true;
            _txtFix1LoM.BackColor = SystemColors.Window;
            _txtFix1LoM.Cursor = Cursors.IBeam;
            _txtFix1LoM.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtFix1LoM.ForeColor = SystemColors.WindowText;
            _txtFix1LoM.Location = new Point(105, 269);
            _txtFix1LoM.MaxLength = 4;
            _txtFix1LoM.Name = "_txtFix1LoM";
            _txtFix1LoM.RightToLeft = RightToLeft.No;
            _txtFix1LoM.Size = new Size(33, 20);
            _txtFix1LoM.TabIndex = 92;
            ToolTip1.SetToolTip(_txtFix1LoM, "Range 0 to 59.9");
            _txtFix1LoM.Visible = false;
            // 
            // txtTime2
            // 
            _txtTime2.AcceptsReturn = true;
            _txtTime2.BackColor = SystemColors.Window;
            _txtTime2.Cursor = Cursors.IBeam;
            _txtTime2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtTime2.ForeColor = SystemColors.WindowText;
            _txtTime2.Location = new Point(496, 160);
            _txtTime2.MaxLength = 4;
            _txtTime2.Name = "_txtTime2";
            _txtTime2.RightToLeft = RightToLeft.No;
            _txtTime2.Size = new Size(33, 20);
            _txtTime2.TabIndex = 64;
            ToolTip1.SetToolTip(_txtTime2, "Range 0000 to 2359");
            // 
            // txtTime1
            // 
            _txtTime1.AcceptsReturn = true;
            _txtTime1.BackColor = SystemColors.Window;
            _txtTime1.Cursor = Cursors.IBeam;
            _txtTime1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtTime1.ForeColor = SystemColors.WindowText;
            _txtTime1.Location = new Point(496, 136);
            _txtTime1.MaxLength = 4;
            _txtTime1.Name = "_txtTime1";
            _txtTime1.RightToLeft = RightToLeft.No;
            _txtTime1.Size = new Size(33, 20);
            _txtTime1.TabIndex = 63;
            ToolTip1.SetToolTip(_txtTime1, "Range 0000 to 2359");
            // 
            // txtLog2
            // 
            _txtLog2.AcceptsReturn = true;
            _txtLog2.BackColor = SystemColors.Window;
            _txtLog2.Cursor = Cursors.IBeam;
            _txtLog2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtLog2.ForeColor = SystemColors.WindowText;
            _txtLog2.Location = new Point(240, 160);
            _txtLog2.MaxLength = 6;
            _txtLog2.Name = "_txtLog2";
            _txtLog2.RightToLeft = RightToLeft.No;
            _txtLog2.Size = new Size(41, 20);
            _txtLog2.TabIndex = 58;
            ToolTip1.SetToolTip(_txtLog2, "Range 0 to 9999.9");
            // 
            // txtLog1
            // 
            _txtLog1.AcceptsReturn = true;
            _txtLog1.BackColor = SystemColors.Window;
            _txtLog1.Cursor = Cursors.IBeam;
            _txtLog1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtLog1.ForeColor = SystemColors.WindowText;
            _txtLog1.Location = new Point(240, 136);
            _txtLog1.MaxLength = 6;
            _txtLog1.Name = "_txtLog1";
            _txtLog1.RightToLeft = RightToLeft.No;
            _txtLog1.Size = new Size(41, 20);
            _txtLog1.TabIndex = 57;
            ToolTip1.SetToolTip(_txtLog1, "Range 0 to 9999.9");
            // 
            // txtMLDeg
            // 
            _txtMLDeg.AcceptsReturn = true;
            _txtMLDeg.BackColor = SystemColors.Window;
            _txtMLDeg.Cursor = Cursors.IBeam;
            _txtMLDeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtMLDeg.ForeColor = SystemColors.WindowText;
            _txtMLDeg.Location = new Point(415, 243);
            _txtMLDeg.MaxLength = 2;
            _txtMLDeg.Name = "_txtMLDeg";
            _txtMLDeg.RightToLeft = RightToLeft.No;
            _txtMLDeg.Size = new Size(25, 20);
            _txtMLDeg.TabIndex = 52;
            ToolTip1.SetToolTip(_txtMLDeg, "Range 0 to 55");
            // 
            // txtTimem
            // 
            _txtTimem.AcceptsReturn = true;
            _txtTimem.BackColor = SystemColors.Window;
            _txtTimem.Cursor = Cursors.IBeam;
            _txtTimem.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtTimem.ForeColor = SystemColors.WindowText;
            _txtTimem.Location = new Point(496, 195);
            _txtTimem.MaxLength = 3;
            _txtTimem.Name = "_txtTimem";
            _txtTimem.RightToLeft = RightToLeft.No;
            _txtTimem.Size = new Size(33, 20);
            _txtTimem.TabIndex = 10;
            ToolTip1.SetToolTip(_txtTimem, "Range 0 to 999 or 59");
            // 
            // txtTimeh
            // 
            _txtTimeh.AcceptsReturn = true;
            _txtTimeh.BackColor = SystemColors.Window;
            _txtTimeh.Cursor = Cursors.IBeam;
            _txtTimeh.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtTimeh.ForeColor = SystemColors.WindowText;
            _txtTimeh.Location = new Point(454, 195);
            _txtTimeh.MaxLength = 2;
            _txtTimeh.Name = "_txtTimeh";
            _txtTimeh.RightToLeft = RightToLeft.No;
            _txtTimeh.Size = new Size(33, 20);
            _txtTimeh.TabIndex = 9;
            ToolTip1.SetToolTip(_txtTimeh, "Range 0 to 99");
            // 
            // txtSpeed
            // 
            _txtSpeed.AcceptsReturn = true;
            _txtSpeed.BackColor = SystemColors.Window;
            _txtSpeed.Cursor = Cursors.IBeam;
            _txtSpeed.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtSpeed.ForeColor = SystemColors.WindowText;
            _txtSpeed.Location = new Point(356, 195);
            _txtSpeed.MaxLength = 4;
            _txtSpeed.Name = "_txtSpeed";
            _txtSpeed.RightToLeft = RightToLeft.No;
            _txtSpeed.Size = new Size(33, 20);
            _txtSpeed.TabIndex = 8;
            ToolTip1.SetToolTip(_txtSpeed, "Range 0 to 99.9");
            // 
            // txtDist
            // 
            _txtDist.AcceptsReturn = true;
            _txtDist.BackColor = SystemColors.Window;
            _txtDist.Cursor = Cursors.IBeam;
            _txtDist.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtDist.ForeColor = SystemColors.WindowText;
            _txtDist.Location = new Point(232, 195);
            _txtDist.MaxLength = 7;
            _txtDist.Name = "_txtDist";
            _txtDist.RightToLeft = RightToLeft.No;
            _txtDist.Size = new Size(49, 20);
            _txtDist.TabIndex = 7;
            ToolTip1.SetToolTip(_txtDist, "Range 0 to 10800");
            // 
            // txtCourse
            // 
            _txtCourse.AcceptsReturn = true;
            _txtCourse.BackColor = SystemColors.Window;
            _txtCourse.Cursor = Cursors.IBeam;
            _txtCourse.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtCourse.ForeColor = SystemColors.WindowText;
            _txtCourse.Location = new Point(248, 104);
            _txtCourse.MaxLength = 5;
            _txtCourse.Name = "_txtCourse";
            _txtCourse.RightToLeft = RightToLeft.No;
            _txtCourse.Size = new Size(41, 20);
            _txtCourse.TabIndex = 6;
            ToolTip1.SetToolTip(_txtCourse, "Range 0 to 359.9");
            // 
            // txtLo1Min
            // 
            _txtLo1Min.AcceptsReturn = true;
            _txtLo1Min.BackColor = SystemColors.Window;
            _txtLo1Min.Cursor = Cursors.IBeam;
            _txtLo1Min.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtLo1Min.ForeColor = SystemColors.WindowText;
            _txtLo1Min.Location = new Point(94, 127);
            _txtLo1Min.MaxLength = 4;
            _txtLo1Min.Name = "_txtLo1Min";
            _txtLo1Min.RightToLeft = RightToLeft.No;
            _txtLo1Min.Size = new Size(33, 20);
            _txtLo1Min.TabIndex = 4;
            ToolTip1.SetToolTip(_txtLo1Min, "Range 0 to 59.9");
            // 
            // txtLo1Deg
            // 
            _txtLo1Deg.AcceptsReturn = true;
            _txtLo1Deg.BackColor = SystemColors.Window;
            _txtLo1Deg.Cursor = Cursors.IBeam;
            _txtLo1Deg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtLo1Deg.ForeColor = SystemColors.WindowText;
            _txtLo1Deg.Location = new Point(54, 127);
            _txtLo1Deg.MaxLength = 3;
            _txtLo1Deg.Name = "_txtLo1Deg";
            _txtLo1Deg.RightToLeft = RightToLeft.No;
            _txtLo1Deg.Size = new Size(33, 20);
            _txtLo1Deg.TabIndex = 3;
            ToolTip1.SetToolTip(_txtLo1Deg, "Range 0 to 180");
            // 
            // txtL1Deg
            // 
            _txtL1Deg.AcceptsReturn = true;
            _txtL1Deg.BackColor = SystemColors.Window;
            _txtL1Deg.Cursor = Cursors.IBeam;
            _txtL1Deg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtL1Deg.ForeColor = SystemColors.WindowText;
            _txtL1Deg.Location = new Point(54, 103);
            _txtL1Deg.MaxLength = 2;
            _txtL1Deg.Name = "_txtL1Deg";
            _txtL1Deg.RightToLeft = RightToLeft.No;
            _txtL1Deg.Size = new Size(33, 20);
            _txtL1Deg.TabIndex = 0;
            ToolTip1.SetToolTip(_txtL1Deg, "Range 0 to 84");
            // 
            // txtL1Min
            // 
            _txtL1Min.AcceptsReturn = true;
            _txtL1Min.BackColor = SystemColors.Window;
            _txtL1Min.Cursor = Cursors.IBeam;
            _txtL1Min.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtL1Min.ForeColor = SystemColors.WindowText;
            _txtL1Min.Location = new Point(94, 103);
            _txtL1Min.MaxLength = 4;
            _txtL1Min.Name = "_txtL1Min";
            _txtL1Min.RightToLeft = RightToLeft.No;
            _txtL1Min.Size = new Size(33, 20);
            _txtL1Min.TabIndex = 1;
            ToolTip1.SetToolTip(_txtL1Min, "Range 0 to 59.9");
            // 
            // txtLo2Min
            // 
            _txtLo2Min.AcceptsReturn = true;
            _txtLo2Min.BackColor = SystemColors.Window;
            _txtLo2Min.Cursor = Cursors.IBeam;
            _txtLo2Min.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtLo2Min.ForeColor = SystemColors.WindowText;
            _txtLo2Min.Location = new Point(94, 197);
            _txtLo2Min.MaxLength = 4;
            _txtLo2Min.Name = "_txtLo2Min";
            _txtLo2Min.RightToLeft = RightToLeft.No;
            _txtLo2Min.Size = new Size(33, 20);
            _txtLo2Min.TabIndex = 16;
            ToolTip1.SetToolTip(_txtLo2Min, "Range 0 to 59.9");
            _txtLo2Min.Visible = false;
            // 
            // txtLo2Deg
            // 
            _txtLo2Deg.AcceptsReturn = true;
            _txtLo2Deg.BackColor = SystemColors.Window;
            _txtLo2Deg.Cursor = Cursors.IBeam;
            _txtLo2Deg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtLo2Deg.ForeColor = SystemColors.WindowText;
            _txtLo2Deg.Location = new Point(54, 197);
            _txtLo2Deg.MaxLength = 3;
            _txtLo2Deg.Name = "_txtLo2Deg";
            _txtLo2Deg.RightToLeft = RightToLeft.No;
            _txtLo2Deg.Size = new Size(33, 20);
            _txtLo2Deg.TabIndex = 15;
            ToolTip1.SetToolTip(_txtLo2Deg, "Range 0 to 180");
            _txtLo2Deg.Visible = false;
            // 
            // txtL2Deg
            // 
            _txtL2Deg.AcceptsReturn = true;
            _txtL2Deg.BackColor = SystemColors.Window;
            _txtL2Deg.Cursor = Cursors.IBeam;
            _txtL2Deg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtL2Deg.ForeColor = SystemColors.WindowText;
            _txtL2Deg.Location = new Point(54, 173);
            _txtL2Deg.MaxLength = 2;
            _txtL2Deg.Name = "_txtL2Deg";
            _txtL2Deg.RightToLeft = RightToLeft.No;
            _txtL2Deg.Size = new Size(33, 20);
            _txtL2Deg.TabIndex = 11;
            ToolTip1.SetToolTip(_txtL2Deg, "Range 0 to 84");
            _txtL2Deg.Visible = false;
            // 
            // txtL2Min
            // 
            _txtL2Min.AcceptsReturn = true;
            _txtL2Min.BackColor = SystemColors.Window;
            _txtL2Min.Cursor = Cursors.IBeam;
            _txtL2Min.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtL2Min.ForeColor = SystemColors.WindowText;
            _txtL2Min.Location = new Point(94, 173);
            _txtL2Min.MaxLength = 4;
            _txtL2Min.Name = "_txtL2Min";
            _txtL2Min.RightToLeft = RightToLeft.No;
            _txtL2Min.Size = new Size(33, 20);
            _txtL2Min.TabIndex = 12;
            ToolTip1.SetToolTip(_txtL2Min, "Range 0 to 59.9");
            _txtL2Min.Visible = false;
            // 
            // cmdPrint
            // 
            _cmdPrint.BackColor = SystemColors.Control;
            _cmdPrint.Cursor = Cursors.Default;
            _cmdPrint.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdPrint.ForeColor = SystemColors.ControlText;
            _cmdPrint.Image = (Image)resources.GetObject("cmdPrint.Image");
            _cmdPrint.Location = new Point(517, 7);
            _cmdPrint.Name = "_cmdPrint";
            _cmdPrint.RightToLeft = RightToLeft.No;
            _cmdPrint.Size = new Size(21, 21);
            _cmdPrint.TabIndex = 45;
            _cmdPrint.TextAlign = ContentAlignment.BottomCenter;
            ToolTip1.SetToolTip(_cmdPrint, "Print window");
            _cmdPrint.UseVisualStyleBackColor = false;
            // 
            // cmdTraverse
            // 
            _cmdTraverse.BackColor = Color.Blue;
            _cmdTraverse.Cursor = Cursors.Default;
            _cmdTraverse.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdTraverse.ForeColor = Color.White;
            _cmdTraverse.Location = new Point(348, 267);
            _cmdTraverse.Name = "_cmdTraverse";
            _cmdTraverse.RightToLeft = RightToLeft.No;
            _cmdTraverse.Size = new Size(200, 25);
            _cmdTraverse.TabIndex = 104;
            _cmdTraverse.Text = "\"Simplified Traverse Table\" Calc";
            _cmdTraverse.UseVisualStyleBackColor = false;
            _cmdTraverse.Visible = false;
            // 
            // cboL3
            // 
            cboL3.BackColor = SystemColors.Window;
            cboL3.Cursor = Cursors.Default;
            cboL3.DropDownStyle = ComboBoxStyle.DropDownList;
            cboL3.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboL3.ForeColor = SystemColors.WindowText;
            cboL3.Items.AddRange(new object[] { "N", "S" });
            cboL3.Location = new Point(334, 218);
            cboL3.Name = "cboL3";
            cboL3.RightToLeft = RightToLeft.No;
            cboL3.Size = new Size(41, 22);
            cboL3.TabIndex = 101;
            cboL3.Visible = false;
            // 
            // Frame3
            // 
            Frame3.BackColor = SystemColors.Window;
            Frame3.Controls.Add(_optMethod2);
            Frame3.Controls.Add(_optMethod1);
            Frame3.Cursor = Cursors.Default;
            Frame3.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Frame3.ForeColor = SystemColors.ControlText;
            Frame3.Location = new Point(380, 218);
            Frame3.Name = "Frame3";
            Frame3.RightToLeft = RightToLeft.No;
            Frame3.Size = new Size(161, 22);
            Frame3.TabIndex = 95;
            // 
            // optMethod2
            // 
            _optMethod2.BackColor = SystemColors.Window;
            _optMethod2.Cursor = Cursors.Default;
            _optMethod2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optMethod2.ForeColor = SystemColors.ControlText;
            _optMethod2.Location = new Point(88, 3);
            _optMethod2.Name = "_optMethod2";
            _optMethod2.RightToLeft = RightToLeft.No;
            _optMethod2.Size = new Size(69, 17);
            _optMethod2.TabIndex = 97;
            _optMethod2.TabStop = true;
            _optMethod2.Text = "Method 2";
            _optMethod2.UseVisualStyleBackColor = false;
            // 
            // optMethod1
            // 
            _optMethod1.BackColor = SystemColors.Window;
            _optMethod1.Cursor = Cursors.Default;
            _optMethod1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optMethod1.ForeColor = SystemColors.ControlText;
            _optMethod1.Location = new Point(8, 3);
            _optMethod1.Name = "_optMethod1";
            _optMethod1.RightToLeft = RightToLeft.No;
            _optMethod1.Size = new Size(69, 17);
            _optMethod1.TabIndex = 96;
            _optMethod1.TabStop = true;
            _optMethod1.Text = "Method 1";
            _optMethod1.UseVisualStyleBackColor = false;
            // 
            // chkComposite
            // 
            _chkComposite.BackColor = SystemColors.Window;
            _chkComposite.Cursor = Cursors.Default;
            _chkComposite.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _chkComposite.ForeColor = SystemColors.ControlText;
            _chkComposite.Location = new Point(40, 224);
            _chkComposite.Name = "_chkComposite";
            _chkComposite.RightToLeft = RightToLeft.No;
            _chkComposite.Size = new Size(140, 17);
            _chkComposite.TabIndex = 94;
            _chkComposite.Text = "Use Composite Sailing ";
            _chkComposite.UseVisualStyleBackColor = false;
            // 
            // cboMLmin
            // 
            cboMLmin.BackColor = SystemColors.Window;
            cboMLmin.Cursor = Cursors.Default;
            cboMLmin.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMLmin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboMLmin.ForeColor = SystemColors.WindowText;
            cboMLmin.Items.AddRange(new object[] { "00", "10", "20", "30", "40", "50" });
            cboMLmin.Location = new Point(447, 242);
            cboMLmin.Name = "cboMLmin";
            cboMLmin.RightToLeft = RightToLeft.No;
            cboMLmin.Size = new Size(41, 22);
            cboMLmin.TabIndex = 53;
            // 
            // chkDriftAngle
            // 
            _chkDriftAngle.BackColor = SystemColors.Window;
            _chkDriftAngle.Cursor = Cursors.Default;
            _chkDriftAngle.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _chkDriftAngle.ForeColor = SystemColors.ControlText;
            _chkDriftAngle.Location = new Point(307, 104);
            _chkDriftAngle.Name = "_chkDriftAngle";
            _chkDriftAngle.RightToLeft = RightToLeft.No;
            _chkDriftAngle.Size = new Size(229, 22);
            _chkDriftAngle.TabIndex = 87;
            _chkDriftAngle.Text = "Prior fix available for drift, CMG, SMG calc";
            _chkDriftAngle.UseVisualStyleBackColor = false;
            _chkDriftAngle.Visible = false;
            // 
            // cboFix1L
            // 
            cboFix1L.BackColor = SystemColors.Window;
            cboFix1L.Cursor = Cursors.Default;
            cboFix1L.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFix1L.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboFix1L.ForeColor = SystemColors.WindowText;
            cboFix1L.Items.AddRange(new object[] { "N", "S" });
            cboFix1L.Location = new Point(145, 244);
            cboFix1L.Name = "cboFix1L";
            cboFix1L.RightToLeft = RightToLeft.No;
            cboFix1L.Size = new Size(41, 22);
            cboFix1L.TabIndex = 90;
            cboFix1L.Visible = false;
            // 
            // cboFix1Lo
            // 
            cboFix1Lo.BackColor = SystemColors.Window;
            cboFix1Lo.Cursor = Cursors.Default;
            cboFix1Lo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFix1Lo.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboFix1Lo.ForeColor = SystemColors.WindowText;
            cboFix1Lo.Items.AddRange(new object[] { "W", "E" });
            cboFix1Lo.Location = new Point(145, 268);
            cboFix1Lo.Name = "cboFix1Lo";
            cboFix1Lo.RightToLeft = RightToLeft.No;
            cboFix1Lo.Size = new Size(41, 22);
            cboFix1Lo.TabIndex = 93;
            cboFix1Lo.Visible = false;
            // 
            // frameCalculateGC
            // 
            frameCalculateGC.BackColor = SystemColors.Window;
            frameCalculateGC.Controls.Add(_optL2Lo2GC);
            frameCalculateGC.Controls.Add(_optICD);
            frameCalculateGC.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            frameCalculateGC.ForeColor = SystemColors.ControlText;
            frameCalculateGC.Location = new Point(23, 59);
            frameCalculateGC.Name = "frameCalculateGC";
            frameCalculateGC.Padding = new Padding(0);
            frameCalculateGC.RightToLeft = RightToLeft.No;
            frameCalculateGC.Size = new Size(489, 41);
            frameCalculateGC.TabIndex = 76;
            frameCalculateGC.TabStop = false;
            frameCalculateGC.Text = "Select What To Calculate ";
            // 
            // optL2Lo2GC
            // 
            _optL2Lo2GC.BackColor = SystemColors.Window;
            _optL2Lo2GC.Cursor = Cursors.Default;
            _optL2Lo2GC.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optL2Lo2GC.ForeColor = SystemColors.ControlText;
            _optL2Lo2GC.Location = new Point(280, 16);
            _optL2Lo2GC.Name = "_optL2Lo2GC";
            _optL2Lo2GC.RightToLeft = RightToLeft.No;
            _optL2Lo2GC.Size = new Size(130, 17);
            _optL2Lo2GC.TabIndex = 78;
            _optL2Lo2GC.TabStop = true;
            _optL2Lo2GC.Text = "Destination L and Lo";
            _optL2Lo2GC.UseVisualStyleBackColor = false;
            _optL2Lo2GC.Visible = false;
            // 
            // optICD
            // 
            _optICD.BackColor = SystemColors.Window;
            _optICD.Checked = true;
            _optICD.Cursor = Cursors.Default;
            _optICD.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optICD.ForeColor = SystemColors.ControlText;
            _optICD.Location = new Point(80, 16);
            _optICD.Name = "_optICD";
            _optICD.RightToLeft = RightToLeft.No;
            _optICD.Size = new Size(153, 17);
            _optICD.TabIndex = 77;
            _optICD.TabStop = true;
            _optICD.Text = "Initial Course and Distance";
            _optICD.UseVisualStyleBackColor = false;
            _optICD.Visible = false;
            // 
            // cmdPoints
            // 
            _cmdPoints.BackColor = Color.Yellow;
            _cmdPoints.Cursor = Cursors.Default;
            _cmdPoints.Enabled = false;
            _cmdPoints.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdPoints.ForeColor = SystemColors.ControlText;
            _cmdPoints.Location = new Point(8, 486);
            _cmdPoints.Name = "_cmdPoints";
            _cmdPoints.RightToLeft = RightToLeft.No;
            _cmdPoints.Size = new Size(159, 25);
            _cmdPoints.TabIndex = 75;
            _cmdPoints.Text = "&Points on Great Circle Route";
            _cmdPoints.UseVisualStyleBackColor = false;
            _cmdPoints.Visible = false;
            // 
            // Frame1
            // 
            Frame1.BackColor = SystemColors.Window;
            Frame1.Controls.Add(_optMercatorS);
            Frame1.Controls.Add(_optAccurateRhumb);
            Frame1.Controls.Add(_optGreatCircle);
            Frame1.Controls.Add(_optMercatorE);
            Frame1.Controls.Add(_optMidLat);
            Frame1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Frame1.ForeColor = SystemColors.ControlText;
            Frame1.Location = new Point(26, 7);
            Frame1.Name = "Frame1";
            Frame1.Padding = new Padding(0);
            Frame1.RightToLeft = RightToLeft.No;
            Frame1.Size = new Size(485, 50);
            Frame1.TabIndex = 68;
            Frame1.TabStop = false;
            Frame1.Text = "Select Sailing Route Type";
            // 
            // optMercatorS
            // 
            _optMercatorS.BackColor = SystemColors.Window;
            _optMercatorS.Cursor = Cursors.Default;
            _optMercatorS.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optMercatorS.ForeColor = SystemColors.ControlText;
            _optMercatorS.Location = new Point(322, 30);
            _optMercatorS.Name = "_optMercatorS";
            _optMercatorS.RightToLeft = RightToLeft.No;
            _optMercatorS.Size = new Size(160, 17);
            _optMercatorS.TabIndex = 71;
            _optMercatorS.TabStop = true;
            _optMercatorS.Text = "Mercator (Clarke spheroid)";
            _optMercatorS.UseVisualStyleBackColor = false;
            // 
            // optAccurateRhumb
            // 
            _optAccurateRhumb.BackColor = SystemColors.Window;
            _optAccurateRhumb.Cursor = Cursors.Default;
            _optAccurateRhumb.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optAccurateRhumb.ForeColor = SystemColors.ControlText;
            _optAccurateRhumb.Location = new Point(88, 16);
            _optAccurateRhumb.Name = "_optAccurateRhumb";
            _optAccurateRhumb.RightToLeft = RightToLeft.No;
            _optAccurateRhumb.Size = new Size(130, 25);
            _optAccurateRhumb.TabIndex = 72;
            _optAccurateRhumb.TabStop = true;
            _optAccurateRhumb.Text = "Accurate Rhumb Line";
            _optAccurateRhumb.UseVisualStyleBackColor = false;
            // 
            // optGreatCircle
            // 
            _optGreatCircle.BackColor = SystemColors.Window;
            _optGreatCircle.Cursor = Cursors.Default;
            _optGreatCircle.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optGreatCircle.ForeColor = SystemColors.ControlText;
            _optGreatCircle.Location = new Point(223, 18);
            _optGreatCircle.Name = "_optGreatCircle";
            _optGreatCircle.RightToLeft = RightToLeft.No;
            _optGreatCircle.Size = new Size(88, 21);
            _optGreatCircle.TabIndex = 73;
            _optGreatCircle.TabStop = true;
            _optGreatCircle.Text = "Great Circle";
            _optGreatCircle.UseVisualStyleBackColor = false;
            // 
            // optMercatorE
            // 
            _optMercatorE.BackColor = SystemColors.Window;
            _optMercatorE.Cursor = Cursors.Default;
            _optMercatorE.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optMercatorE.ForeColor = SystemColors.ControlText;
            _optMercatorE.Location = new Point(322, 9);
            _optMercatorE.Name = "_optMercatorE";
            _optMercatorE.RightToLeft = RightToLeft.No;
            _optMercatorE.Size = new Size(160, 17);
            _optMercatorE.TabIndex = 70;
            _optMercatorE.TabStop = true;
            _optMercatorE.Text = "Mercator (WGS72 ellipsoid)";
            _optMercatorE.UseVisualStyleBackColor = false;
            // 
            // optMidLat
            // 
            _optMidLat.BackColor = SystemColors.Window;
            _optMidLat.Checked = true;
            _optMidLat.Cursor = Cursors.Default;
            _optMidLat.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optMidLat.ForeColor = SystemColors.ControlText;
            _optMidLat.Location = new Point(4, 16);
            _optMidLat.Name = "_optMidLat";
            _optMidLat.RightToLeft = RightToLeft.No;
            _optMidLat.Size = new Size(84, 25);
            _optMidLat.TabIndex = 69;
            _optMidLat.TabStop = true;
            _optMidLat.Text = "Mid-Latitude";
            _optMidLat.UseVisualStyleBackColor = false;
            // 
            // cboML
            // 
            cboML.BackColor = SystemColors.Window;
            cboML.Cursor = Cursors.Default;
            cboML.DropDownStyle = ComboBoxStyle.DropDownList;
            cboML.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboML.ForeColor = SystemColors.WindowText;
            cboML.Items.AddRange(new object[] { "N", "S" });
            cboML.Location = new Point(495, 242);
            cboML.Name = "cboML";
            cboML.RightToLeft = RightToLeft.No;
            cboML.Size = new Size(41, 22);
            cboML.TabIndex = 55;
            // 
            // chkML
            // 
            chkML.BackColor = SystemColors.Window;
            chkML.Cursor = Cursors.Default;
            chkML.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            chkML.ForeColor = SystemColors.ControlText;
            chkML.Location = new Point(196, 243);
            chkML.Name = "chkML";
            chkML.RightToLeft = RightToLeft.No;
            chkML.Size = new Size(213, 22);
            chkML.TabIndex = 51;
            chkML.Text = "Use this mid-latitude for CLS SAPS plot";
            chkML.UseVisualStyleBackColor = false;
            // 
            // cmdClearSwap
            // 
            _cmdClearSwap.BackColor = Color.Yellow;
            _cmdClearSwap.Cursor = Cursors.Default;
            _cmdClearSwap.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdClearSwap.ForeColor = SystemColors.ControlText;
            _cmdClearSwap.Location = new Point(8, 546);
            _cmdClearSwap.Name = "_cmdClearSwap";
            _cmdClearSwap.RightToLeft = RightToLeft.No;
            _cmdClearSwap.Size = new Size(217, 25);
            _cmdClearSwap.TabIndex = 20;
            _cmdClearSwap.Text = "Clear But &Use L2, Lo2 For New L1, Lo1";
            _cmdClearSwap.UseVisualStyleBackColor = false;
            // 
            // cmdClearAll
            // 
            _cmdClearAll.BackColor = Color.Red;
            _cmdClearAll.Cursor = Cursors.Default;
            _cmdClearAll.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdClearAll.ForeColor = Color.White;
            _cmdClearAll.Location = new Point(8, 515);
            _cmdClearAll.Name = "_cmdClearAll";
            _cmdClearAll.RightToLeft = RightToLeft.No;
            _cmdClearAll.Size = new Size(217, 25);
            _cmdClearAll.TabIndex = 19;
            _cmdClearAll.Text = "Clear All Fields of Data Entered";
            _cmdClearAll.UseVisualStyleBackColor = false;
            // 
            // cmdCalculate
            // 
            _cmdCalculate.BackColor = Color.Blue;
            _cmdCalculate.Cursor = Cursors.Default;
            _cmdCalculate.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdCalculate.ForeColor = Color.White;
            _cmdCalculate.Location = new Point(192, 267);
            _cmdCalculate.Name = "_cmdCalculate";
            _cmdCalculate.RightToLeft = RightToLeft.No;
            _cmdCalculate.Size = new Size(150, 25);
            _cmdCalculate.TabIndex = 18;
            _cmdCalculate.Text = "&Calculate";
            _cmdCalculate.UseVisualStyleBackColor = false;
            // 
            // frameCalculate
            // 
            frameCalculate.BackColor = SystemColors.Window;
            frameCalculate.Controls.Add(_optSD);
            frameCalculate.Controls.Add(_optCD);
            frameCalculate.Controls.Add(_optL2Lo2);
            frameCalculate.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            frameCalculate.ForeColor = SystemColors.ControlText;
            frameCalculate.Location = new Point(24, 58);
            frameCalculate.Name = "frameCalculate";
            frameCalculate.Padding = new Padding(0);
            frameCalculate.RightToLeft = RightToLeft.No;
            frameCalculate.Size = new Size(489, 41);
            frameCalculate.TabIndex = 34;
            frameCalculate.TabStop = false;
            frameCalculate.Text = "Select What to Calculate";
            // 
            // optSD
            // 
            _optSD.BackColor = SystemColors.Window;
            _optSD.Cursor = Cursors.Default;
            _optSD.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optSD.ForeColor = SystemColors.ControlText;
            _optSD.Location = new Point(387, 16);
            _optSD.Name = "_optSD";
            _optSD.RightToLeft = RightToLeft.No;
            _optSD.Size = new Size(100, 17);
            _optSD.TabIndex = 46;
            _optSD.TabStop = true;
            _optSD.Text = "Set and Drift";
            _optSD.UseVisualStyleBackColor = false;
            // 
            // optCD
            // 
            _optCD.BackColor = SystemColors.Window;
            _optCD.Checked = true;
            _optCD.Cursor = Cursors.Default;
            _optCD.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optCD.ForeColor = SystemColors.ControlText;
            _optCD.Location = new Point(16, 16);
            _optCD.Name = "_optCD";
            _optCD.RightToLeft = RightToLeft.No;
            _optCD.Size = new Size(129, 17);
            _optCD.TabIndex = 22;
            _optCD.TabStop = true;
            _optCD.Text = "Course and Distance";
            _optCD.UseVisualStyleBackColor = false;
            // 
            // optL2Lo2
            // 
            _optL2Lo2.BackColor = SystemColors.Window;
            _optL2Lo2.Cursor = Cursors.Default;
            _optL2Lo2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optL2Lo2.ForeColor = SystemColors.ControlText;
            _optL2Lo2.Location = new Point(200, 16);
            _optL2Lo2.Name = "_optL2Lo2";
            _optL2Lo2.RightToLeft = RightToLeft.No;
            _optL2Lo2.Size = new Size(129, 17);
            _optL2Lo2.TabIndex = 21;
            _optL2Lo2.TabStop = true;
            _optL2Lo2.Text = "Destination L and Lo";
            _optL2Lo2.UseVisualStyleBackColor = false;
            // 
            // cboLo1
            // 
            cboLo1.BackColor = SystemColors.Window;
            cboLo1.Cursor = Cursors.Default;
            cboLo1.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLo1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboLo1.ForeColor = SystemColors.WindowText;
            cboLo1.Items.AddRange(new object[] { "W", "E" });
            cboLo1.Location = new Point(134, 127);
            cboLo1.Name = "cboLo1";
            cboLo1.RightToLeft = RightToLeft.No;
            cboLo1.Size = new Size(41, 22);
            cboLo1.TabIndex = 5;
            // 
            // cboL1
            // 
            cboL1.BackColor = SystemColors.Window;
            cboL1.Cursor = Cursors.Default;
            cboL1.DropDownStyle = ComboBoxStyle.DropDownList;
            cboL1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboL1.ForeColor = SystemColors.WindowText;
            cboL1.Items.AddRange(new object[] { "N", "S" });
            cboL1.Location = new Point(134, 103);
            cboL1.Name = "cboL1";
            cboL1.RightToLeft = RightToLeft.No;
            cboL1.Size = new Size(41, 22);
            cboL1.TabIndex = 2;
            // 
            // cboLo2
            // 
            cboLo2.BackColor = SystemColors.Window;
            cboLo2.Cursor = Cursors.Default;
            cboLo2.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLo2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboLo2.ForeColor = SystemColors.WindowText;
            cboLo2.Items.AddRange(new object[] { "W", "E" });
            cboLo2.Location = new Point(134, 197);
            cboLo2.Name = "cboLo2";
            cboLo2.RightToLeft = RightToLeft.No;
            cboLo2.Size = new Size(41, 22);
            cboLo2.TabIndex = 17;
            cboLo2.Visible = false;
            // 
            // cboL2
            // 
            cboL2.BackColor = SystemColors.Window;
            cboL2.Cursor = Cursors.Default;
            cboL2.DropDownStyle = ComboBoxStyle.DropDownList;
            cboL2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboL2.ForeColor = SystemColors.WindowText;
            cboL2.Items.AddRange(new object[] { "N", "S" });
            cboL2.Location = new Point(134, 173);
            cboL2.Name = "cboL2";
            cboL2.RightToLeft = RightToLeft.No;
            cboL2.Size = new Size(41, 22);
            cboL2.TabIndex = 14;
            cboL2.Visible = false;
            // 
            // Label15
            // 
            Label15.BackColor = SystemColors.Window;
            Label15.Cursor = Cursors.Default;
            Label15.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label15.ForeColor = SystemColors.ControlText;
            Label15.Location = new Point(487, 245);
            Label15.Name = "Label15";
            Label15.RightToLeft = RightToLeft.No;
            Label15.Size = new Size(9, 17);
            Label15.TabIndex = 103;
            Label15.Text = "'";
            // 
            // Label16
            // 
            Label16.BackColor = SystemColors.Window;
            Label16.Cursor = Cursors.Default;
            Label16.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label16.ForeColor = SystemColors.ControlText;
            Label16.Location = new Point(295, 160);
            Label16.Name = "Label16";
            Label16.RightToLeft = RightToLeft.No;
            Label16.Size = new Size(9, 17);
            Label16.TabIndex = 102;
            Label16.Text = "°";
            // 
            // lblLimLat
            // 
            lblLimLat.BackColor = SystemColors.Window;
            lblLimLat.Cursor = Cursors.Default;
            lblLimLat.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLimLat.ForeColor = SystemColors.ControlText;
            lblLimLat.Location = new Point(184, 226);
            lblLimLat.Name = "lblLimLat";
            lblLimLat.RightToLeft = RightToLeft.No;
            lblLimLat.Size = new Size(65, 17);
            lblLimLat.TabIndex = 98;
            lblLimLat.Text = "Latitude limit";
            // 
            // Label14
            // 
            Label14.BackColor = SystemColors.Window;
            Label14.Cursor = Cursors.Default;
            Label14.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label14.ForeColor = SystemColors.ControlText;
            Label14.Location = new Point(2, 246);
            Label14.Name = "Label14";
            Label14.RightToLeft = RightToLeft.No;
            Label14.Size = new Size(57, 17);
            Label14.TabIndex = 86;
            Label14.Text = "Prior fix L";
            Label14.Visible = false;
            // 
            // Label13
            // 
            Label13.BackColor = SystemColors.Window;
            Label13.Cursor = Cursors.Default;
            Label13.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label13.ForeColor = SystemColors.ControlText;
            Label13.Location = new Point(96, 243);
            Label13.Name = "Label13";
            Label13.RightToLeft = RightToLeft.No;
            Label13.Size = new Size(9, 17);
            Label13.TabIndex = 85;
            Label13.Text = "°";
            Label13.Visible = false;
            // 
            // Label12
            // 
            Label12.BackColor = SystemColors.Window;
            Label12.Cursor = Cursors.Default;
            Label12.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label12.ForeColor = SystemColors.ControlText;
            Label12.Location = new Point(137, 243);
            Label12.Name = "Label12";
            Label12.RightToLeft = RightToLeft.No;
            Label12.Size = new Size(9, 17);
            Label12.TabIndex = 84;
            Label12.Text = "'";
            Label12.Visible = false;
            // 
            // Label11
            // 
            Label11.BackColor = SystemColors.Window;
            Label11.Cursor = Cursors.Default;
            Label11.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label11.ForeColor = SystemColors.ControlText;
            Label11.Location = new Point(1, 270);
            Label11.Name = "Label11";
            Label11.RightToLeft = RightToLeft.No;
            Label11.Size = new Size(59, 17);
            Label11.TabIndex = 83;
            Label11.Text = "Prior fix Lo";
            Label11.Visible = false;
            // 
            // Label10
            // 
            Label10.BackColor = SystemColors.Window;
            Label10.Cursor = Cursors.Default;
            Label10.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label10.ForeColor = SystemColors.ControlText;
            Label10.Location = new Point(279, 222);
            Label10.Name = "Label10";
            Label10.RightToLeft = RightToLeft.No;
            Label10.Size = new Size(8, 17);
            Label10.TabIndex = 82;
            Label10.Text = "°";
            Label10.Visible = false;
            // 
            // Label9
            // 
            Label9.BackColor = SystemColors.Window;
            Label9.Cursor = Cursors.Default;
            Label9.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label9.ForeColor = SystemColors.ControlText;
            Label9.Location = new Point(137, 267);
            Label9.Name = "Label9";
            Label9.RightToLeft = RightToLeft.No;
            Label9.Size = new Size(9, 17);
            Label9.TabIndex = 81;
            Label9.Text = "'";
            Label9.Visible = false;
            // 
            // lblInitial
            // 
            lblInitial.BackColor = SystemColors.Window;
            lblInitial.Cursor = Cursors.Default;
            lblInitial.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblInitial.ForeColor = SystemColors.ControlText;
            lblInitial.Location = new Point(197, 116);
            lblInitial.Name = "lblInitial";
            lblInitial.RightToLeft = RightToLeft.No;
            lblInitial.Size = new Size(41, 17);
            lblInitial.TabIndex = 74;
            lblInitial.Text = "(Initial)";
            lblInitial.Visible = false;
            // 
            // lblor2
            // 
            lblor2.BackColor = SystemColors.Window;
            lblor2.Cursor = Cursors.Default;
            lblor2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblor2.ForeColor = SystemColors.ControlText;
            lblor2.Location = new Point(409, 174);
            lblor2.Name = "lblor2";
            lblor2.RightToLeft = RightToLeft.No;
            lblor2.Size = new Size(22, 17);
            lblor2.TabIndex = 67;
            lblor2.Text = "OR";
            lblor2.Visible = false;
            // 
            // lblTime2
            // 
            lblTime2.BackColor = SystemColors.Window;
            lblTime2.Cursor = Cursors.Default;
            lblTime2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblTime2.ForeColor = SystemColors.ControlText;
            lblTime2.Location = new Point(424, 160);
            lblTime2.Name = "lblTime2";
            lblTime2.RightToLeft = RightToLeft.No;
            lblTime2.Size = new Size(74, 17);
            lblTime2.TabIndex = 66;
            lblTime2.Text = "Time2 (hhmm)";
            // 
            // lblTime1
            // 
            lblTime1.BackColor = SystemColors.Window;
            lblTime1.Cursor = Cursors.Default;
            lblTime1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblTime1.ForeColor = SystemColors.ControlText;
            lblTime1.Location = new Point(424, 136);
            lblTime1.Name = "lblTime1";
            lblTime1.RightToLeft = RightToLeft.No;
            lblTime1.Size = new Size(74, 17);
            lblTime1.TabIndex = 65;
            lblTime1.Text = "Time1 (hhmm)";
            // 
            // lblLog2nm
            // 
            lblLog2nm.BackColor = SystemColors.Window;
            lblLog2nm.Cursor = Cursors.Default;
            lblLog2nm.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLog2nm.ForeColor = SystemColors.ControlText;
            lblLog2nm.Location = new Point(281, 160);
            lblLog2nm.Name = "lblLog2nm";
            lblLog2nm.RightToLeft = RightToLeft.No;
            lblLog2nm.Size = new Size(21, 17);
            lblLog2nm.TabIndex = 62;
            lblLog2nm.Text = "nm";
            // 
            // lblLog1nm
            // 
            lblLog1nm.BackColor = SystemColors.Window;
            lblLog1nm.Cursor = Cursors.Default;
            lblLog1nm.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLog1nm.ForeColor = SystemColors.ControlText;
            lblLog1nm.Location = new Point(281, 136);
            lblLog1nm.Name = "lblLog1nm";
            lblLog1nm.RightToLeft = RightToLeft.No;
            lblLog1nm.Size = new Size(21, 17);
            lblLog1nm.TabIndex = 61;
            lblLog1nm.Text = "nm";
            // 
            // lblLog2
            // 
            lblLog2.BackColor = SystemColors.Window;
            lblLog2.Cursor = Cursors.Default;
            lblLog2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLog2.ForeColor = SystemColors.ControlText;
            lblLog2.Location = new Point(208, 160);
            lblLog2.Name = "lblLog2";
            lblLog2.RightToLeft = RightToLeft.No;
            lblLog2.Size = new Size(31, 17);
            lblLog2.TabIndex = 60;
            lblLog2.Text = "Log2";
            // 
            // lblLog1
            // 
            lblLog1.BackColor = SystemColors.Window;
            lblLog1.Cursor = Cursors.Default;
            lblLog1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLog1.ForeColor = SystemColors.ControlText;
            lblLog1.Location = new Point(207, 136);
            lblLog1.Name = "lblLog1";
            lblLog1.RightToLeft = RightToLeft.No;
            lblLog1.Size = new Size(31, 17);
            lblLog1.TabIndex = 59;
            lblLog1.Text = "Log1";
            // 
            // Label4
            // 
            Label4.BackColor = SystemColors.Window;
            Label4.Cursor = Cursors.Default;
            Label4.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.ForeColor = SystemColors.ControlText;
            Label4.Location = new Point(439, 243);
            Label4.Name = "Label4";
            Label4.RightToLeft = RightToLeft.No;
            Label4.Size = new Size(9, 17);
            Label4.TabIndex = 56;
            Label4.Text = "°";
            // 
            // Label1
            // 
            Label1.BackColor = SystemColors.Window;
            Label1.Cursor = Cursors.Default;
            Label1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = SystemColors.ControlText;
            Label1.Location = new Point(323, 222);
            Label1.Name = "Label1";
            Label1.RightToLeft = RightToLeft.No;
            Label1.Size = new Size(9, 17);
            Label1.TabIndex = 54;
            Label1.Text = "'";
            // 
            // lblFixLo
            // 
            lblFixLo.BackColor = SystemColors.Window;
            lblFixLo.Cursor = Cursors.Default;
            lblFixLo.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblFixLo.ForeColor = SystemColors.ControlText;
            lblFixLo.Location = new Point(15, 198);
            lblFixLo.Name = "lblFixLo";
            lblFixLo.RightToLeft = RightToLeft.No;
            lblFixLo.Size = new Size(36, 17);
            lblFixLo.TabIndex = 50;
            lblFixLo.Text = "Fix Lo";
            lblFixLo.Visible = false;
            // 
            // lblFixL
            // 
            lblFixL.BackColor = SystemColors.Window;
            lblFixL.Cursor = Cursors.Default;
            lblFixL.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblFixL.ForeColor = SystemColors.ControlText;
            lblFixL.Location = new Point(20, 173);
            lblFixL.Name = "lblFixL";
            lblFixL.RightToLeft = RightToLeft.No;
            lblFixL.Size = new Size(33, 17);
            lblFixL.TabIndex = 49;
            lblFixL.Text = "Fix L";
            lblFixL.Visible = false;
            // 
            // lblDRLo
            // 
            lblDRLo.BackColor = SystemColors.Window;
            lblDRLo.Cursor = Cursors.Default;
            lblDRLo.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblDRLo.ForeColor = SystemColors.ControlText;
            lblDRLo.Location = new Point(20, 127);
            lblDRLo.Name = "lblDRLo";
            lblDRLo.RightToLeft = RightToLeft.No;
            lblDRLo.Size = new Size(36, 17);
            lblDRLo.TabIndex = 48;
            lblDRLo.Text = "DR Lo";
            lblDRLo.Visible = false;
            // 
            // lblDRL
            // 
            lblDRL.BackColor = SystemColors.Window;
            lblDRL.Cursor = Cursors.Default;
            lblDRL.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblDRL.ForeColor = SystemColors.ControlText;
            lblDRL.Location = new Point(20, 103);
            lblDRL.Name = "lblDRL";
            lblDRL.RightToLeft = RightToLeft.No;
            lblDRL.Size = new Size(33, 17);
            lblDRL.TabIndex = 47;
            lblDRL.Text = "DR L";
            lblDRL.Visible = false;
            // 
            // lblm
            // 
            lblm.BackColor = SystemColors.Window;
            lblm.Cursor = Cursors.Default;
            lblm.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblm.ForeColor = SystemColors.ControlText;
            lblm.Location = new Point(527, 195);
            lblm.Name = "lblm";
            lblm.RightToLeft = RightToLeft.No;
            lblm.Size = new Size(17, 17);
            lblm.TabIndex = 44;
            lblm.Text = "m";
            // 
            // lblh
            // 
            lblh.BackColor = SystemColors.Window;
            lblh.Cursor = Cursors.Default;
            lblh.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblh.ForeColor = SystemColors.ControlText;
            lblh.Location = new Point(485, 195);
            lblh.Name = "lblh";
            lblh.RightToLeft = RightToLeft.No;
            lblh.Size = new Size(17, 17);
            lblh.TabIndex = 43;
            lblh.Text = "h";
            // 
            // lblTime
            // 
            lblTime.BackColor = SystemColors.Window;
            lblTime.Cursor = Cursors.Default;
            lblTime.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblTime.ForeColor = SystemColors.ControlText;
            lblTime.Location = new Point(406, 195);
            lblTime.Name = "lblTime";
            lblTime.RightToLeft = RightToLeft.No;
            lblTime.Size = new Size(51, 17);
            lblTime.TabIndex = 42;
            lblTime.Text = "Run Time";
            // 
            // lblkn
            // 
            lblkn.BackColor = SystemColors.Window;
            lblkn.Cursor = Cursors.Default;
            lblkn.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblkn.ForeColor = SystemColors.ControlText;
            lblkn.Location = new Point(389, 195);
            lblkn.Name = "lblkn";
            lblkn.RightToLeft = RightToLeft.No;
            lblkn.Size = new Size(18, 17);
            lblkn.TabIndex = 41;
            lblkn.Text = "kn";
            // 
            // lblSpeed
            // 
            lblSpeed.BackColor = SystemColors.Window;
            lblSpeed.Cursor = Cursors.Default;
            lblSpeed.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblSpeed.ForeColor = SystemColors.ControlText;
            lblSpeed.Location = new Point(317, 195);
            lblSpeed.Name = "lblSpeed";
            lblSpeed.RightToLeft = RightToLeft.No;
            lblSpeed.Size = new Size(38, 17);
            lblSpeed.TabIndex = 40;
            lblSpeed.Text = "Speed";
            // 
            // lblor
            // 
            lblor.BackColor = SystemColors.Window;
            lblor.Cursor = Cursors.Default;
            lblor.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblor.ForeColor = SystemColors.ControlText;
            lblor.Location = new Point(296, 185);
            lblor.Name = "lblor";
            lblor.RightToLeft = RightToLeft.No;
            lblor.Size = new Size(22, 13);
            lblor.TabIndex = 39;
            lblor.Text = "OR";
            // 
            // lblnm
            // 
            lblnm.BackColor = SystemColors.Window;
            lblnm.Cursor = Cursors.Default;
            lblnm.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblnm.ForeColor = SystemColors.ControlText;
            lblnm.Location = new Point(281, 195);
            lblnm.Name = "lblnm";
            lblnm.RightToLeft = RightToLeft.No;
            lblnm.Size = new Size(21, 17);
            lblnm.TabIndex = 38;
            lblnm.Text = "nm";
            // 
            // lblDistance
            // 
            lblDistance.BackColor = SystemColors.Window;
            lblDistance.Cursor = Cursors.Default;
            lblDistance.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblDistance.ForeColor = SystemColors.ControlText;
            lblDistance.Location = new Point(185, 195);
            lblDistance.Name = "lblDistance";
            lblDistance.RightToLeft = RightToLeft.No;
            lblDistance.Size = new Size(49, 17);
            lblDistance.TabIndex = 37;
            lblDistance.Text = "Distance";
            // 
            // lblCourseDeg
            // 
            lblCourseDeg.BackColor = SystemColors.Window;
            lblCourseDeg.Cursor = Cursors.Default;
            lblCourseDeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblCourseDeg.ForeColor = SystemColors.ControlText;
            lblCourseDeg.Location = new Point(287, 104);
            lblCourseDeg.Name = "lblCourseDeg";
            lblCourseDeg.RightToLeft = RightToLeft.No;
            lblCourseDeg.Size = new Size(9, 17);
            lblCourseDeg.TabIndex = 36;
            lblCourseDeg.Text = "°";
            // 
            // lblCourse
            // 
            lblCourse.BackColor = SystemColors.Window;
            lblCourse.Cursor = Cursors.Default;
            lblCourse.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblCourse.ForeColor = SystemColors.ControlText;
            lblCourse.Location = new Point(180, 104);
            lblCourse.Name = "lblCourse";
            lblCourse.RightToLeft = RightToLeft.No;
            lblCourse.Size = new Size(67, 13);
            lblCourse.TabIndex = 35;
            lblCourse.Text = "True Course";
            // 
            // Label6
            // 
            Label6.BackColor = SystemColors.Window;
            Label6.Cursor = Cursors.Default;
            Label6.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label6.ForeColor = SystemColors.ControlText;
            Label6.Location = new Point(125, 127);
            Label6.Name = "Label6";
            Label6.RightToLeft = RightToLeft.No;
            Label6.Size = new Size(9, 17);
            Label6.TabIndex = 33;
            Label6.Text = "'";
            // 
            // Label5
            // 
            Label5.BackColor = SystemColors.Window;
            Label5.Cursor = Cursors.Default;
            Label5.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label5.ForeColor = SystemColors.ControlText;
            Label5.Location = new Point(85, 127);
            Label5.Name = "Label5";
            Label5.RightToLeft = RightToLeft.No;
            Label5.Size = new Size(9, 17);
            Label5.TabIndex = 32;
            Label5.Text = "°";
            // 
            // lblLo1
            // 
            lblLo1.BackColor = SystemColors.Window;
            lblLo1.Cursor = Cursors.Default;
            lblLo1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLo1.ForeColor = SystemColors.ControlText;
            lblLo1.Location = new Point(20, 127);
            lblLo1.Name = "lblLo1";
            lblLo1.RightToLeft = RightToLeft.No;
            lblLo1.Size = new Size(25, 17);
            lblLo1.TabIndex = 31;
            lblLo1.Text = "Lo1";
            // 
            // Label3
            // 
            Label3.BackColor = SystemColors.Window;
            Label3.Cursor = Cursors.Default;
            Label3.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.ForeColor = SystemColors.ControlText;
            Label3.Location = new Point(125, 103);
            Label3.Name = "Label3";
            Label3.RightToLeft = RightToLeft.No;
            Label3.Size = new Size(9, 17);
            Label3.TabIndex = 30;
            Label3.Text = "'";
            // 
            // Label2
            // 
            Label2.BackColor = SystemColors.Window;
            Label2.Cursor = Cursors.Default;
            Label2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = SystemColors.ControlText;
            Label2.Location = new Point(85, 103);
            Label2.Name = "Label2";
            Label2.RightToLeft = RightToLeft.No;
            Label2.Size = new Size(9, 17);
            Label2.TabIndex = 29;
            Label2.Text = "°";
            // 
            // lblL1
            // 
            lblL1.BackColor = SystemColors.Window;
            lblL1.Cursor = Cursors.Default;
            lblL1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblL1.ForeColor = SystemColors.ControlText;
            lblL1.Location = new Point(20, 103);
            lblL1.Name = "lblL1";
            lblL1.RightToLeft = RightToLeft.No;
            lblL1.Size = new Size(25, 17);
            lblL1.TabIndex = 28;
            lblL1.Text = "L1";
            // 
            // lblLoMin
            // 
            lblLoMin.BackColor = SystemColors.Window;
            lblLoMin.Cursor = Cursors.Default;
            lblLoMin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLoMin.ForeColor = SystemColors.ControlText;
            lblLoMin.Location = new Point(125, 197);
            lblLoMin.Name = "lblLoMin";
            lblLoMin.RightToLeft = RightToLeft.No;
            lblLoMin.Size = new Size(9, 17);
            lblLoMin.TabIndex = 27;
            lblLoMin.Text = "'";
            lblLoMin.Visible = false;
            // 
            // lblLoDeg
            // 
            lblLoDeg.BackColor = SystemColors.Window;
            lblLoDeg.Cursor = Cursors.Default;
            lblLoDeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLoDeg.ForeColor = SystemColors.ControlText;
            lblLoDeg.Location = new Point(85, 197);
            lblLoDeg.Name = "lblLoDeg";
            lblLoDeg.RightToLeft = RightToLeft.No;
            lblLoDeg.Size = new Size(9, 17);
            lblLoDeg.TabIndex = 26;
            lblLoDeg.Text = "°";
            lblLoDeg.Visible = false;
            // 
            // lblLo2
            // 
            lblLo2.BackColor = SystemColors.Window;
            lblLo2.Cursor = Cursors.Default;
            lblLo2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLo2.ForeColor = SystemColors.ControlText;
            lblLo2.Location = new Point(18, 197);
            lblLo2.Name = "lblLo2";
            lblLo2.RightToLeft = RightToLeft.No;
            lblLo2.Size = new Size(34, 15);
            lblLo2.TabIndex = 25;
            lblLo2.Text = "L2 Lo";
            lblLo2.Visible = false;
            // 
            // lblLMin
            // 
            lblLMin.BackColor = SystemColors.Window;
            lblLMin.Cursor = Cursors.Default;
            lblLMin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLMin.ForeColor = SystemColors.ControlText;
            lblLMin.Location = new Point(125, 173);
            lblLMin.Name = "lblLMin";
            lblLMin.RightToLeft = RightToLeft.No;
            lblLMin.Size = new Size(9, 17);
            lblLMin.TabIndex = 24;
            lblLMin.Text = "'";
            lblLMin.Visible = false;
            // 
            // lblLDeg
            // 
            lblLDeg.BackColor = SystemColors.Window;
            lblLDeg.Cursor = Cursors.Default;
            lblLDeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLDeg.ForeColor = SystemColors.ControlText;
            lblLDeg.Location = new Point(85, 173);
            lblLDeg.Name = "lblLDeg";
            lblLDeg.RightToLeft = RightToLeft.No;
            lblLDeg.Size = new Size(9, 17);
            lblLDeg.TabIndex = 23;
            lblLDeg.Text = "°";
            lblLDeg.Visible = false;
            // 
            // lblL2
            // 
            lblL2.BackColor = SystemColors.Window;
            lblL2.Cursor = Cursors.Default;
            lblL2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblL2.ForeColor = SystemColors.ControlText;
            lblL2.Location = new Point(20, 174);
            lblL2.Name = "lblL2";
            lblL2.RightToLeft = RightToLeft.No;
            lblL2.Size = new Size(19, 17);
            lblL2.TabIndex = 13;
            lblL2.Text = "L2";
            lblL2.Visible = false;
            // 
            // txtSailings
            // 
            txtSailings.BackColor = SystemColors.Window;
            txtSailings.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtSailings.Location = new Point(2, 299);
            txtSailings.Name = "txtSailings";
            txtSailings.ReadOnly = true;
            txtSailings.Size = new Size(546, 154);
            txtSailings.TabIndex = 106;
            txtSailings.Text = "";
            // 
            // ExitBtn
            // 
            _ExitBtn.BackColor = Color.Red;
            _ExitBtn.Cursor = Cursors.Default;
            _ExitBtn.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _ExitBtn.ForeColor = SystemColors.ControlLightLight;
            _ExitBtn.Location = new Point(473, 484);
            _ExitBtn.Name = "_ExitBtn";
            _ExitBtn.RightToLeft = RightToLeft.No;
            _ExitBtn.Size = new Size(73, 25);
            _ExitBtn.TabIndex = 107;
            _ExitBtn.Text = "Exit";
            _ExitBtn.UseVisualStyleBackColor = false;
            // 
            // cmdRhumbPoints
            // 
            _cmdRhumbPoints.BackColor = Color.Yellow;
            _cmdRhumbPoints.Enabled = false;
            _cmdRhumbPoints.Location = new Point(178, 486);
            _cmdRhumbPoints.Name = "_cmdRhumbPoints";
            _cmdRhumbPoints.Size = new Size(159, 25);
            _cmdRhumbPoints.TabIndex = 108;
            _cmdRhumbPoints.Text = "Points on &Rhumb Line";
            _cmdRhumbPoints.UseVisualStyleBackColor = false;
            // 
            // txtUserInfo
            // 
            txtUserInfo.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtUserInfo.HideSelection = false;
            txtUserInfo.Location = new Point(103, 458);
            txtUserInfo.Name = "txtUserInfo";
            txtUserInfo.Size = new Size(400, 22);
            txtUserInfo.TabIndex = 204;
            // 
            // Label17
            // 
            Label17.AutoSize = true;
            Label17.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label17.Location = new Point(42, 461);
            Label17.Name = "Label17";
            Label17.Size = new Size(57, 15);
            Label17.TabIndex = 203;
            Label17.Text = "User Info";
            Label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.ABC_white;
            PictureBox1.Location = new Point(253, 521);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(295, 50);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 109;
            PictureBox1.TabStop = false;
            // 
            // Label7
            // 
            Label7.BackColor = SystemColors.Window;
            Label7.Cursor = Cursors.Default;
            Label7.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label7.ForeColor = SystemColors.ControlText;
            Label7.Location = new Point(96, 270);
            Label7.Name = "Label7";
            Label7.RightToLeft = RightToLeft.No;
            Label7.Size = new Size(9, 17);
            Label7.TabIndex = 205;
            Label7.Text = "°";
            Label7.Visible = false;
            // 
            // FormSailings
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(553, 577);
            Controls.Add(Label7);
            Controls.Add(txtUserInfo);
            Controls.Add(Label17);
            Controls.Add(PictureBox1);
            Controls.Add(frameCalculateGC);
            Controls.Add(lblL2);
            Controls.Add(Label11);
            Controls.Add(_chkDriftAngle);
            Controls.Add(lblCourse);
            Controls.Add(Label14);
            Controls.Add(Label10);
            Controls.Add(lblLimLat);
            Controls.Add(_txtL3Deg);
            Controls.Add(Frame3);
            Controls.Add(_chkComposite);
            Controls.Add(lblLog2nm);
            Controls.Add(lblLog1nm);
            Controls.Add(lblnm);
            Controls.Add(lblor);
            Controls.Add(lblLog2);
            Controls.Add(lblLog1);
            Controls.Add(lblSpeed);
            Controls.Add(_cmdRhumbPoints);
            Controls.Add(_ExitBtn);
            Controls.Add(txtSailings);
            Controls.Add(_cmdTraverse);
            Controls.Add(_txtL3Min);
            Controls.Add(cboL3);
            Controls.Add(cboMLmin);
            Controls.Add(_txtFix1LM);
            Controls.Add(cboFix1L);
            Controls.Add(_txtFix1LD);
            Controls.Add(_txtFix1LoD);
            Controls.Add(_txtFix1LoM);
            Controls.Add(cboFix1Lo);
            Controls.Add(_cmdPoints);
            Controls.Add(Frame1);
            Controls.Add(_txtTime2);
            Controls.Add(_txtTime1);
            Controls.Add(_txtLog2);
            Controls.Add(cboML);
            Controls.Add(_txtMLDeg);
            Controls.Add(chkML);
            Controls.Add(_cmdPrint);
            Controls.Add(_cmdClearSwap);
            Controls.Add(_cmdClearAll);
            Controls.Add(_cmdCalculate);
            Controls.Add(_txtTimem);
            Controls.Add(_txtTimeh);
            Controls.Add(_txtSpeed);
            Controls.Add(_txtDist);
            Controls.Add(_txtCourse);
            Controls.Add(frameCalculate);
            Controls.Add(cboLo1);
            Controls.Add(_txtLo1Min);
            Controls.Add(_txtLo1Deg);
            Controls.Add(_txtL1Deg);
            Controls.Add(cboL1);
            Controls.Add(_txtL1Min);
            Controls.Add(cboLo2);
            Controls.Add(_txtLo2Min);
            Controls.Add(_txtLo2Deg);
            Controls.Add(_txtL2Deg);
            Controls.Add(cboL2);
            Controls.Add(_txtL2Min);
            Controls.Add(Label15);
            Controls.Add(Label16);
            Controls.Add(Label13);
            Controls.Add(Label12);
            Controls.Add(Label9);
            Controls.Add(lblInitial);
            Controls.Add(lblor2);
            Controls.Add(lblTime2);
            Controls.Add(lblTime1);
            Controls.Add(Label4);
            Controls.Add(Label1);
            Controls.Add(lblFixL);
            Controls.Add(lblDRLo);
            Controls.Add(lblDRL);
            Controls.Add(lblm);
            Controls.Add(lblh);
            Controls.Add(lblTime);
            Controls.Add(lblkn);
            Controls.Add(lblDistance);
            Controls.Add(lblCourseDeg);
            Controls.Add(Label6);
            Controls.Add(Label5);
            Controls.Add(lblLo1);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(lblL1);
            Controls.Add(lblLoMin);
            Controls.Add(lblLoDeg);
            Controls.Add(lblLMin);
            Controls.Add(lblLDeg);
            Controls.Add(_txtLog1);
            Controls.Add(lblLo2);
            Controls.Add(lblFixLo);
            Cursor = Cursors.Default;
            Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(99, 155);
            MaximizeBox = false;
            Name = "FormSailings";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "The Sailings";
            Frame3.ResumeLayout(false);
            frameCalculateGC.ResumeLayout(false);
            Frame1.ResumeLayout(false);
            frameCalculate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            FormClosed += new FormClosedEventHandler(FormSailings_FormClosed);
            Load += new EventHandler(FormSailings_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        internal RichTextBox txtSailings;
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

        private Button _cmdRhumbPoints;

        internal Button cmdRhumbPoints
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdRhumbPoints;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdRhumbPoints != null)
                {
                    _cmdRhumbPoints.Click -= cmdRhumbPoints_Click;
                }

                _cmdRhumbPoints = value;
                if (_cmdRhumbPoints != null)
                {
                    _cmdRhumbPoints.Click += cmdRhumbPoints_Click;
                }
            }
        }

        internal PictureBox PictureBox1;
        internal TextBox txtUserInfo;
        internal Label Label17;
        public Label Label7;
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}