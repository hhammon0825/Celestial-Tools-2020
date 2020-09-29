using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    [DesignerGenerated()]
    internal partial class FormCurrents
    {
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        [DebuggerNonUserCode()]
        public FormCurrents() : base()
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
        private TextBox _txtSetEbb;

        public TextBox txtSetEbb
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtSetEbb;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtSetEbb != null)
                {
                    _txtSetEbb.TextChanged -= txtSetEbb_TextChanged;
                    _txtSetEbb.Validating -= txtSetEbb_Validating;
                    _txtSetEbb.Enter -= txtSetEbb_Enter;
                }

                _txtSetEbb = value;
                if (_txtSetEbb != null)
                {
                    _txtSetEbb.TextChanged += txtSetEbb_TextChanged;
                    _txtSetEbb.Validating += txtSetEbb_Validating;
                    _txtSetEbb.Enter += txtSetEbb_Enter;
                }
            }
        }

        private TextBox _txtSetFlood;

        public TextBox txtSetFlood
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtSetFlood;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtSetFlood != null)
                {
                    _txtSetFlood.TextChanged -= txtSetFlood_TextChanged;
                    _txtSetFlood.Validating -= txtSetFlood_Validating;
                    _txtSetFlood.Enter -= txtSetFlood_Enter;
                }

                _txtSetFlood = value;
                if (_txtSetFlood != null)
                {
                    _txtSetFlood.TextChanged += txtSetFlood_TextChanged;
                    _txtSetFlood.Validating += txtSetFlood_Validating;
                    _txtSetFlood.Enter += txtSetFlood_Enter;
                }
            }
        }

        private CheckBox _chkE;

        public CheckBox chkE
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _chkE;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_chkE != null)
                {
                    _chkE.CheckStateChanged -= chkE_CheckStateChanged;
                }

                _chkE = value;
                if (_chkE != null)
                {
                    _chkE.CheckStateChanged += chkE_CheckStateChanged;
                }
            }
        }

        private CheckBox _chkSBE;

        public CheckBox chkSBE
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _chkSBE;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_chkSBE != null)
                {
                    _chkSBE.CheckStateChanged -= chkSBE_CheckStateChanged;
                }

                _chkSBE = value;
                if (_chkSBE != null)
                {
                    _chkSBE.CheckStateChanged += chkSBE_CheckStateChanged;
                }
            }
        }

        private CheckBox _chkF;

        public CheckBox chkF
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _chkF;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_chkF != null)
                {
                    _chkF.CheckStateChanged -= chkF_CheckStateChanged;
                }

                _chkF = value;
                if (_chkF != null)
                {
                    _chkF.CheckStateChanged += chkF_CheckStateChanged;
                }
            }
        }

        private CheckBox _chkSBF;

        public CheckBox chkSBF
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _chkSBF;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_chkSBF != null)
                {
                    _chkSBF.CheckStateChanged -= chkSBF_CheckStateChanged;
                }

                _chkSBF = value;
                if (_chkSBF != null)
                {
                    _chkSBF.CheckStateChanged += chkSBF_CheckStateChanged;
                }
            }
        }

        private TextBox _txtTab2SlackFHour;

        public TextBox txtTab2SlackFHour
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtTab2SlackFHour;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtTab2SlackFHour != null)
                {
                    _txtTab2SlackFHour.KeyPress -= txtTab2SlackFHour_KeyPress;
                    _txtTab2SlackFHour.Validating -= txtTab2SlackFHour_Validating;
                    _txtTab2SlackFHour.Enter -= txtTab2SlackFHour_Enter;
                }

                _txtTab2SlackFHour = value;
                if (_txtTab2SlackFHour != null)
                {
                    _txtTab2SlackFHour.KeyPress += txtTab2SlackFHour_KeyPress;
                    _txtTab2SlackFHour.Validating += txtTab2SlackFHour_Validating;
                    _txtTab2SlackFHour.Enter += txtTab2SlackFHour_Enter;
                }
            }
        }

        private TextBox _txtTab2SlackFMin;

        public TextBox txtTab2SlackFMin
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtTab2SlackFMin;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtTab2SlackFMin != null)
                {
                    _txtTab2SlackFMin.TextChanged -= txtTab2SlackFMin_TextChanged;
                    _txtTab2SlackFMin.KeyPress -= txtTab2SlackFMin_KeyPress;
                    _txtTab2SlackFMin.Validating -= txtTab2SlackFMin_Validating;
                    _txtTab2SlackFMin.Enter -= txtTab2SlackFMin_Enter;
                }

                _txtTab2SlackFMin = value;
                if (_txtTab2SlackFMin != null)
                {
                    _txtTab2SlackFMin.TextChanged += txtTab2SlackFMin_TextChanged;
                    _txtTab2SlackFMin.KeyPress += txtTab2SlackFMin_KeyPress;
                    _txtTab2SlackFMin.Validating += txtTab2SlackFMin_Validating;
                    _txtTab2SlackFMin.Enter += txtTab2SlackFMin_Enter;
                }
            }
        }

        private TextBox _txtTab2SlackEHour;

        public TextBox txtTab2SlackEHour
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtTab2SlackEHour;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtTab2SlackEHour != null)
                {
                    _txtTab2SlackEHour.KeyPress -= txtTab2SlackEHour_KeyPress;
                    _txtTab2SlackEHour.Validating -= txtTab2SlackEHour_Validating;
                    _txtTab2SlackEHour.Enter -= txtTab2SlackEHour_Enter;
                }

                _txtTab2SlackEHour = value;
                if (_txtTab2SlackEHour != null)
                {
                    _txtTab2SlackEHour.KeyPress += txtTab2SlackEHour_KeyPress;
                    _txtTab2SlackEHour.Validating += txtTab2SlackEHour_Validating;
                    _txtTab2SlackEHour.Enter += txtTab2SlackEHour_Enter;
                }
            }
        }

        private TextBox _txtTab2SlackEMin;

        public TextBox txtTab2SlackEMin
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtTab2SlackEMin;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtTab2SlackEMin != null)
                {
                    _txtTab2SlackEMin.TextChanged -= txtTab2SlackEMin_TextChanged;
                    _txtTab2SlackEMin.KeyPress -= txtTab2SlackEMin_KeyPress;
                    _txtTab2SlackEMin.Validating -= txtTab2SlackEMin_Validating;
                    _txtTab2SlackEMin.Enter -= txtTab2SlackEMin_Enter;
                }

                _txtTab2SlackEMin = value;
                if (_txtTab2SlackEMin != null)
                {
                    _txtTab2SlackEMin.TextChanged += txtTab2SlackEMin_TextChanged;
                    _txtTab2SlackEMin.KeyPress += txtTab2SlackEMin_KeyPress;
                    _txtTab2SlackEMin.Validating += txtTab2SlackEMin_Validating;
                    _txtTab2SlackEMin.Enter += txtTab2SlackEMin_Enter;
                }
            }
        }

        private TextBox _txtLocation;

        public TextBox txtLocation
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtLocation;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtLocation != null)
                {
                    _txtLocation.TextChanged -= txtLocation_TextChanged;
                    _txtLocation.Enter -= txtLocation_Enter;
                }

                _txtLocation = value;
                if (_txtLocation != null)
                {
                    _txtLocation.TextChanged += txtLocation_TextChanged;
                    _txtLocation.Enter += txtLocation_Enter;
                }
            }
        }

        private TextBox _txtLocNo;

        public TextBox txtLocNo
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtLocNo;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtLocNo != null)
                {
                    _txtLocNo.TextChanged -= txtLocNo_TextChanged;
                    _txtLocNo.KeyPress -= txtLocNo_KeyPress;
                    _txtLocNo.Enter -= txtLocNo_Enter;
                }

                _txtLocNo = value;
                if (_txtLocNo != null)
                {
                    _txtLocNo.TextChanged += txtLocNo_TextChanged;
                    _txtLocNo.KeyPress += txtLocNo_KeyPress;
                    _txtLocNo.Enter += txtLocNo_Enter;
                }
            }
        }

        private TextBox _txtRefSta;

        public TextBox txtRefSta
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtRefSta;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtRefSta != null)
                {
                    _txtRefSta.Enter -= txtRefSta_Enter;
                }

                _txtRefSta = value;
                if (_txtRefSta != null)
                {
                    _txtRefSta.Enter += txtRefSta_Enter;
                }
            }
        }

        private TextBox _txtVelFlood;

        public TextBox txtVelFlood
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtVelFlood;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtVelFlood != null)
                {
                    _txtVelFlood.KeyPress -= txtVelFlood_KeyPress;
                    _txtVelFlood.Enter -= txtVelFlood_Enter;
                }

                _txtVelFlood = value;
                if (_txtVelFlood != null)
                {
                    _txtVelFlood.KeyPress += txtVelFlood_KeyPress;
                    _txtVelFlood.Enter += txtVelFlood_Enter;
                }
            }
        }

        private TextBox _txtVelEbb;

        public TextBox txtVelEbb
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtVelEbb;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtVelEbb != null)
                {
                    _txtVelEbb.KeyPress -= txtVelEbb_KeyPress;
                    _txtVelEbb.Enter -= txtVelEbb_Enter;
                }

                _txtVelEbb = value;
                if (_txtVelEbb != null)
                {
                    _txtVelEbb.KeyPress += txtVelEbb_KeyPress;
                    _txtVelEbb.Enter += txtVelEbb_Enter;
                }
            }
        }

        public TextBox txtTab2Diff;
        private TextBox _txtSubStaNo;

        public TextBox txtSubStaNo
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtSubStaNo;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtSubStaNo != null)
                {
                    _txtSubStaNo.KeyPress -= txtSubStaNo_KeyPress;
                }

                _txtSubStaNo = value;
                if (_txtSubStaNo != null)
                {
                    _txtSubStaNo.KeyPress += txtSubStaNo_KeyPress;
                }
            }
        }

        private TextBox _txtTab2FloodHour;

        public TextBox txtTab2FloodHour
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtTab2FloodHour;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtTab2FloodHour != null)
                {
                    _txtTab2FloodHour.TextChanged -= txtTab2FloodHour_TextChanged;
                    _txtTab2FloodHour.KeyPress -= txtTab2FloodHour_KeyPress;
                    _txtTab2FloodHour.Validating -= txtTab2FloodHour_Validating;
                    _txtTab2FloodHour.Enter -= txtTab2FloodHour_Enter;
                }

                _txtTab2FloodHour = value;
                if (_txtTab2FloodHour != null)
                {
                    _txtTab2FloodHour.TextChanged += txtTab2FloodHour_TextChanged;
                    _txtTab2FloodHour.KeyPress += txtTab2FloodHour_KeyPress;
                    _txtTab2FloodHour.Validating += txtTab2FloodHour_Validating;
                    _txtTab2FloodHour.Enter += txtTab2FloodHour_Enter;
                }
            }
        }

        private TextBox _txtTab2FloodMin;

        public TextBox txtTab2FloodMin
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtTab2FloodMin;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtTab2FloodMin != null)
                {
                    _txtTab2FloodMin.TextChanged -= txtTab2FloodMin_TextChanged;
                    _txtTab2FloodMin.KeyPress -= txtTab2FloodMin_KeyPress;
                    _txtTab2FloodMin.Validating -= txtTab2FloodMin_Validating;
                    _txtTab2FloodMin.Enter -= txtTab2FloodMin_Enter;
                }

                _txtTab2FloodMin = value;
                if (_txtTab2FloodMin != null)
                {
                    _txtTab2FloodMin.TextChanged += txtTab2FloodMin_TextChanged;
                    _txtTab2FloodMin.KeyPress += txtTab2FloodMin_KeyPress;
                    _txtTab2FloodMin.Validating += txtTab2FloodMin_Validating;
                    _txtTab2FloodMin.Enter += txtTab2FloodMin_Enter;
                }
            }
        }

        private TextBox _txtTab2FloodMult;

        public TextBox txtTab2FloodMult
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtTab2FloodMult;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtTab2FloodMult != null)
                {
                    _txtTab2FloodMult.KeyPress -= txtTab2FloodMult_KeyPress;
                    _txtTab2FloodMult.Enter -= txtTab2FloodMult_Enter;
                }

                _txtTab2FloodMult = value;
                if (_txtTab2FloodMult != null)
                {
                    _txtTab2FloodMult.KeyPress += txtTab2FloodMult_KeyPress;
                    _txtTab2FloodMult.Enter += txtTab2FloodMult_Enter;
                }
            }
        }

        private TextBox _txtTab2EbbHour;

        public TextBox txtTab2EbbHour
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtTab2EbbHour;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtTab2EbbHour != null)
                {
                    _txtTab2EbbHour.TextChanged -= txtTab2EbbHour_TextChanged;
                    _txtTab2EbbHour.KeyPress -= txtTab2EbbHour_KeyPress;
                    _txtTab2EbbHour.Validating -= txtTab2EbbHour_Validating;
                    _txtTab2EbbHour.Enter -= txtTab2EbbHour_Enter;
                }

                _txtTab2EbbHour = value;
                if (_txtTab2EbbHour != null)
                {
                    _txtTab2EbbHour.TextChanged += txtTab2EbbHour_TextChanged;
                    _txtTab2EbbHour.KeyPress += txtTab2EbbHour_KeyPress;
                    _txtTab2EbbHour.Validating += txtTab2EbbHour_Validating;
                    _txtTab2EbbHour.Enter += txtTab2EbbHour_Enter;
                }
            }
        }

        private TextBox _txtTab2EbbMin;

        public TextBox txtTab2EbbMin
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtTab2EbbMin;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtTab2EbbMin != null)
                {
                    _txtTab2EbbMin.TextChanged -= txtTab2EbbMin_TextChanged;
                    _txtTab2EbbMin.KeyPress -= txtTab2EbbMin_KeyPress;
                    _txtTab2EbbMin.Validating -= txtTab2EbbMin_Validating;
                    _txtTab2EbbMin.Enter -= txtTab2EbbMin_Enter;
                }

                _txtTab2EbbMin = value;
                if (_txtTab2EbbMin != null)
                {
                    _txtTab2EbbMin.TextChanged += txtTab2EbbMin_TextChanged;
                    _txtTab2EbbMin.KeyPress += txtTab2EbbMin_KeyPress;
                    _txtTab2EbbMin.Validating += txtTab2EbbMin_Validating;
                    _txtTab2EbbMin.Enter += txtTab2EbbMin_Enter;
                }
            }
        }

        private TextBox _txtTab2EbbMult;

        public TextBox txtTab2EbbMult
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtTab2EbbMult;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtTab2EbbMult != null)
                {
                    _txtTab2EbbMult.KeyPress -= txtTab2EbbMult_KeyPress;
                    _txtTab2EbbMult.Validating -= txtTab2EbbMult_Validating;
                    _txtTab2EbbMult.Enter -= txtTab2EbbMult_Enter;
                }

                _txtTab2EbbMult = value;
                if (_txtTab2EbbMult != null)
                {
                    _txtTab2EbbMult.KeyPress += txtTab2EbbMult_KeyPress;
                    _txtTab2EbbMult.Validating += txtTab2EbbMult_Validating;
                    _txtTab2EbbMult.Enter += txtTab2EbbMult_Enter;
                }
            }
        }

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

        private RadioButton _optRule;

        public RadioButton optRule
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optRule;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optRule != null)
                {
                    _optRule.CheckedChanged -= optRule_CheckedChanged;
                }

                _optRule = value;
                if (_optRule != null)
                {
                    _optRule.CheckedChanged += optRule_CheckedChanged;
                }
            }
        }

        private RadioButton _optB;

        public RadioButton optB
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optB;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optB != null)
                {
                    _optB.CheckedChanged -= optB_CheckedChanged;
                }

                _optB = value;
                if (_optB != null)
                {
                    _optB.CheckedChanged += optB_CheckedChanged;
                }
            }
        }

        private RadioButton _optA;

        public RadioButton optA
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optA;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optA != null)
                {
                    _optA.CheckedChanged -= optA_CheckedChanged;
                }

                _optA = value;
                if (_optA != null)
                {
                    _optA.CheckedChanged += optA_CheckedChanged;
                }
            }
        }

        private RadioButton _optCalc;

        public RadioButton optCalc
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optCalc;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optCalc != null)
                {
                    _optCalc.CheckedChanged -= optCalc_CheckedChanged;
                }

                _optCalc = value;
                if (_optCalc != null)
                {
                    _optCalc.CheckedChanged += optCalc_CheckedChanged;
                }
            }
        }
        // Public WithEvents Line13 As Microsoft.VisualBasic.PowerPacks.LineShape
        public GroupBox Frame1;
        public Label Label27;
        public Label Label26;
        // Public WithEvents Line12 As Microsoft.VisualBasic.PowerPacks.LineShape
        public Label Label25;
        public Label Label24;
        public Label Label23;
        public Label Label22;
        public Label Label21;
        // Public WithEvents Line11 As Microsoft.VisualBasic.PowerPacks.LineShape
        // Public WithEvents Line10 As Microsoft.VisualBasic.PowerPacks.LineShape
        public Label Label20;
        public Label Label19;
        public Label Label18;
        public Label Label17;
        public Label Label16;
        public Label lblLocation;
        public Label lblLocNumber;
        public Label Label1;
        // Public WithEvents Line1 As Microsoft.VisualBasic.PowerPacks.LineShape
        public Label Label2;
        public Label Label3;
        public Label Label4;
        public Label Label5;
        public Label Label6;
        public Label Label7;
        public Label Label8;
        public Label Label9;
        public Label Label10;
        public Label Label11;
        public Label Label12;
        public Label Label13;
        public Label Label14;
        public Label Label15;
        // Public WithEvents Line2 As Microsoft.VisualBasic.PowerPacks.LineShape
        // Public WithEvents Line3 As Microsoft.VisualBasic.PowerPacks.LineShape
        // Public WithEvents Line4 As Microsoft.VisualBasic.PowerPacks.LineShape
        // Public WithEvents Line5 As Microsoft.VisualBasic.PowerPacks.LineShape
        // Public WithEvents Line6 As Microsoft.VisualBasic.PowerPacks.LineShape
        // Public WithEvents Line7 As Microsoft.VisualBasic.PowerPacks.LineShape
        // Public WithEvents Line8 As Microsoft.VisualBasic.PowerPacks.LineShape
        // Public WithEvents Line9 As Microsoft.VisualBasic.PowerPacks.LineShape
        // Public WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
        // Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCurrents));
            ToolTip1 = new ToolTip(components);
            _txtTab2SlackFMin = new TextBox();
            _txtTab2SlackFMin.TextChanged += new EventHandler(txtTab2SlackFMin_TextChanged);
            _txtTab2SlackFMin.KeyPress += new KeyPressEventHandler(txtTab2SlackFMin_KeyPress);
            _txtTab2SlackFMin.Validating += new System.ComponentModel.CancelEventHandler(txtTab2SlackFMin_Validating);
            _txtTab2SlackFMin.Enter += new EventHandler(txtTab2SlackFMin_Enter);
            _txtTab2SlackEMin = new TextBox();
            _txtTab2SlackEMin.TextChanged += new EventHandler(txtTab2SlackEMin_TextChanged);
            _txtTab2SlackEMin.KeyPress += new KeyPressEventHandler(txtTab2SlackEMin_KeyPress);
            _txtTab2SlackEMin.Validating += new System.ComponentModel.CancelEventHandler(txtTab2SlackEMin_Validating);
            _txtTab2SlackEMin.Enter += new EventHandler(txtTab2SlackEMin_Enter);
            _txtTab2FloodMin = new TextBox();
            _txtTab2FloodMin.TextChanged += new EventHandler(txtTab2FloodMin_TextChanged);
            _txtTab2FloodMin.KeyPress += new KeyPressEventHandler(txtTab2FloodMin_KeyPress);
            _txtTab2FloodMin.Validating += new System.ComponentModel.CancelEventHandler(txtTab2FloodMin_Validating);
            _txtTab2FloodMin.Enter += new EventHandler(txtTab2FloodMin_Enter);
            _txtTab2EbbMin = new TextBox();
            _txtTab2EbbMin.TextChanged += new EventHandler(txtTab2EbbMin_TextChanged);
            _txtTab2EbbMin.KeyPress += new KeyPressEventHandler(txtTab2EbbMin_KeyPress);
            _txtTab2EbbMin.Validating += new System.ComponentModel.CancelEventHandler(txtTab2EbbMin_Validating);
            _txtTab2EbbMin.Enter += new EventHandler(txtTab2EbbMin_Enter);
            _cmdPrint = new Button();
            _cmdPrint.Click += new EventHandler(cmdPrint_Click);
            _txtSetEbb = new TextBox();
            _txtSetEbb.TextChanged += new EventHandler(txtSetEbb_TextChanged);
            _txtSetEbb.Validating += new System.ComponentModel.CancelEventHandler(txtSetEbb_Validating);
            _txtSetEbb.Enter += new EventHandler(txtSetEbb_Enter);
            _txtSetFlood = new TextBox();
            _txtSetFlood.TextChanged += new EventHandler(txtSetFlood_TextChanged);
            _txtSetFlood.Validating += new System.ComponentModel.CancelEventHandler(txtSetFlood_Validating);
            _txtSetFlood.Enter += new EventHandler(txtSetFlood_Enter);
            _chkE = new CheckBox();
            _chkE.CheckStateChanged += new EventHandler(chkE_CheckStateChanged);
            _chkSBE = new CheckBox();
            _chkSBE.CheckStateChanged += new EventHandler(chkSBE_CheckStateChanged);
            _chkF = new CheckBox();
            _chkF.CheckStateChanged += new EventHandler(chkF_CheckStateChanged);
            _chkSBF = new CheckBox();
            _chkSBF.CheckStateChanged += new EventHandler(chkSBF_CheckStateChanged);
            _txtTab2SlackFHour = new TextBox();
            _txtTab2SlackFHour.KeyPress += new KeyPressEventHandler(txtTab2SlackFHour_KeyPress);
            _txtTab2SlackFHour.Validating += new System.ComponentModel.CancelEventHandler(txtTab2SlackFHour_Validating);
            _txtTab2SlackFHour.Enter += new EventHandler(txtTab2SlackFHour_Enter);
            _txtTab2SlackEHour = new TextBox();
            _txtTab2SlackEHour.KeyPress += new KeyPressEventHandler(txtTab2SlackEHour_KeyPress);
            _txtTab2SlackEHour.Validating += new System.ComponentModel.CancelEventHandler(txtTab2SlackEHour_Validating);
            _txtTab2SlackEHour.Enter += new EventHandler(txtTab2SlackEHour_Enter);
            _txtLocation = new TextBox();
            _txtLocation.TextChanged += new EventHandler(txtLocation_TextChanged);
            _txtLocation.Enter += new EventHandler(txtLocation_Enter);
            _txtLocNo = new TextBox();
            _txtLocNo.TextChanged += new EventHandler(txtLocNo_TextChanged);
            _txtLocNo.KeyPress += new KeyPressEventHandler(txtLocNo_KeyPress);
            _txtLocNo.Enter += new EventHandler(txtLocNo_Enter);
            _txtRefSta = new TextBox();
            _txtRefSta.Enter += new EventHandler(txtRefSta_Enter);
            _txtVelFlood = new TextBox();
            _txtVelFlood.KeyPress += new KeyPressEventHandler(txtVelFlood_KeyPress);
            _txtVelFlood.Enter += new EventHandler(txtVelFlood_Enter);
            _txtVelEbb = new TextBox();
            _txtVelEbb.KeyPress += new KeyPressEventHandler(txtVelEbb_KeyPress);
            _txtVelEbb.Enter += new EventHandler(txtVelEbb_Enter);
            txtTab2Diff = new TextBox();
            _txtSubStaNo = new TextBox();
            _txtSubStaNo.KeyPress += new KeyPressEventHandler(txtSubStaNo_KeyPress);
            _txtTab2FloodHour = new TextBox();
            _txtTab2FloodHour.TextChanged += new EventHandler(txtTab2FloodHour_TextChanged);
            _txtTab2FloodHour.KeyPress += new KeyPressEventHandler(txtTab2FloodHour_KeyPress);
            _txtTab2FloodHour.Validating += new System.ComponentModel.CancelEventHandler(txtTab2FloodHour_Validating);
            _txtTab2FloodHour.Enter += new EventHandler(txtTab2FloodHour_Enter);
            _txtTab2FloodMult = new TextBox();
            _txtTab2FloodMult.KeyPress += new KeyPressEventHandler(txtTab2FloodMult_KeyPress);
            _txtTab2FloodMult.Enter += new EventHandler(txtTab2FloodMult_Enter);
            _txtTab2EbbHour = new TextBox();
            _txtTab2EbbHour.TextChanged += new EventHandler(txtTab2EbbHour_TextChanged);
            _txtTab2EbbHour.KeyPress += new KeyPressEventHandler(txtTab2EbbHour_KeyPress);
            _txtTab2EbbHour.Validating += new System.ComponentModel.CancelEventHandler(txtTab2EbbHour_Validating);
            _txtTab2EbbHour.Enter += new EventHandler(txtTab2EbbHour_Enter);
            _txtTab2EbbMult = new TextBox();
            _txtTab2EbbMult.KeyPress += new KeyPressEventHandler(txtTab2EbbMult_KeyPress);
            _txtTab2EbbMult.Validating += new System.ComponentModel.CancelEventHandler(txtTab2EbbMult_Validating);
            _txtTab2EbbMult.Enter += new EventHandler(txtTab2EbbMult_Enter);
            _cmdCurrents = new Button();
            _cmdCurrents.Click += new EventHandler(cmdCurrents_Click);
            _cmdClear = new Button();
            _cmdClear.Click += new EventHandler(cmdClear_Click);
            Frame1 = new GroupBox();
            _optRule = new RadioButton();
            _optRule.CheckedChanged += new EventHandler(optRule_CheckedChanged);
            _optB = new RadioButton();
            _optB.CheckedChanged += new EventHandler(optB_CheckedChanged);
            _optA = new RadioButton();
            _optA.CheckedChanged += new EventHandler(optA_CheckedChanged);
            _optCalc = new RadioButton();
            _optCalc.CheckedChanged += new EventHandler(optCalc_CheckedChanged);
            Label27 = new Label();
            Label26 = new Label();
            Label25 = new Label();
            Label24 = new Label();
            Label23 = new Label();
            Label22 = new Label();
            Label21 = new Label();
            Label20 = new Label();
            Label19 = new Label();
            Label18 = new Label();
            Label17 = new Label();
            Label16 = new Label();
            lblLocation = new Label();
            lblLocNumber = new Label();
            Label1 = new Label();
            Label2 = new Label();
            Label3 = new Label();
            Label4 = new Label();
            Label5 = new Label();
            Label6 = new Label();
            Label7 = new Label();
            Label8 = new Label();
            Label9 = new Label();
            Label10 = new Label();
            Label11 = new Label();
            Label12 = new Label();
            Label13 = new Label();
            Label14 = new Label();
            Label15 = new Label();
            _ExitBtn = new Button();
            _ExitBtn.Click += new EventHandler(ExitBtn_Click);
            Curr1Txtbx = new TextBox();
            Curr2TxtBx = new TextBox();
            Curr3TxtBx = new TextBox();
            Curr4TxtBx = new TextBox();
            Curr5TxtBx = new TextBox();
            Curr6TxtBx = new TextBox();
            Curr7TxtBx = new TextBox();
            Curr11TxtBx = new TextBox();
            Curr15TxtBx = new TextBox();
            Curr8TxtBx = new RichTextBox();
            Curr13TxtBx = new RichTextBox();
            Curr18TxtBx = new RichTextBox();
            Curr10TxtBx = new TextBox();
            Curr12TxtBx = new TextBox();
            Curr17TxtBx = new TextBox();
            Curr14TxtBx = new TextBox();
            Curr20TxtBx = new TextBox();
            Curr16TxtBx = new TextBox();
            Curr19TxtBx = new TextBox();
            PictureBox1 = new PictureBox();
            _LinkNOAACurrentTides = new LinkLabel();
            _LinkNOAACurrentTides.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkNOAACurrentTides_LinkClicked);
            DTTides = new DateTimePicker();
            lblDate = new Label();
            DTTimeSlackBeforeFlood = new DateTimePicker();
            DTTimeFlood = new DateTimePicker();
            DTTimeSlackBeforeEbb = new DateTimePicker();
            DTTimeEbb = new DateTimePicker();
            Frame1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtTab2SlackFMin
            // 
            _txtTab2SlackFMin.AcceptsReturn = true;
            _txtTab2SlackFMin.BackColor = SystemColors.Window;
            _txtTab2SlackFMin.Cursor = Cursors.IBeam;
            _txtTab2SlackFMin.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtTab2SlackFMin.ForeColor = SystemColors.WindowText;
            _txtTab2SlackFMin.Location = new Point(384, 127);
            _txtTab2SlackFMin.MaxLength = 2;
            _txtTab2SlackFMin.Name = "_txtTab2SlackFMin";
            _txtTab2SlackFMin.RightToLeft = RightToLeft.No;
            _txtTab2SlackFMin.Size = new Size(25, 21);
            _txtTab2SlackFMin.TabIndex = 53;
            ToolTip1.SetToolTip(_txtTab2SlackFMin, "Range 0 to 59");
            // 
            // txtTab2SlackEMin
            // 
            _txtTab2SlackEMin.AcceptsReturn = true;
            _txtTab2SlackEMin.BackColor = SystemColors.Window;
            _txtTab2SlackEMin.Cursor = Cursors.IBeam;
            _txtTab2SlackEMin.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtTab2SlackEMin.ForeColor = SystemColors.WindowText;
            _txtTab2SlackEMin.Location = new Point(600, 127);
            _txtTab2SlackEMin.MaxLength = 2;
            _txtTab2SlackEMin.Name = "_txtTab2SlackEMin";
            _txtTab2SlackEMin.RightToLeft = RightToLeft.No;
            _txtTab2SlackEMin.Size = new Size(25, 21);
            _txtTab2SlackEMin.TabIndex = 58;
            ToolTip1.SetToolTip(_txtTab2SlackEMin, "Range 0 to 59");
            // 
            // txtTab2FloodMin
            // 
            _txtTab2FloodMin.AcceptsReturn = true;
            _txtTab2FloodMin.BackColor = SystemColors.Window;
            _txtTab2FloodMin.Cursor = Cursors.IBeam;
            _txtTab2FloodMin.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtTab2FloodMin.ForeColor = SystemColors.WindowText;
            _txtTab2FloodMin.Location = new Point(464, 127);
            _txtTab2FloodMin.MaxLength = 2;
            _txtTab2FloodMin.Name = "_txtTab2FloodMin";
            _txtTab2FloodMin.RightToLeft = RightToLeft.No;
            _txtTab2FloodMin.Size = new Size(25, 21);
            _txtTab2FloodMin.TabIndex = 55;
            ToolTip1.SetToolTip(_txtTab2FloodMin, "Range 0 to 59");
            // 
            // txtTab2EbbMin
            // 
            _txtTab2EbbMin.AcceptsReturn = true;
            _txtTab2EbbMin.BackColor = SystemColors.Window;
            _txtTab2EbbMin.Cursor = Cursors.IBeam;
            _txtTab2EbbMin.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtTab2EbbMin.ForeColor = SystemColors.WindowText;
            _txtTab2EbbMin.Location = new Point(680, 127);
            _txtTab2EbbMin.MaxLength = 2;
            _txtTab2EbbMin.Name = "_txtTab2EbbMin";
            _txtTab2EbbMin.RightToLeft = RightToLeft.No;
            _txtTab2EbbMin.Size = new Size(25, 21);
            _txtTab2EbbMin.TabIndex = 60;
            ToolTip1.SetToolTip(_txtTab2EbbMin, "Range 0 to 59");
            // 
            // cmdPrint
            // 
            _cmdPrint.BackColor = SystemColors.Control;
            _cmdPrint.Cursor = Cursors.Default;
            _cmdPrint.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdPrint.ForeColor = SystemColors.ControlText;
            _cmdPrint.Image = (Image)resources.GetObject("cmdPrint.Image");
            _cmdPrint.Location = new Point(771, 3);
            _cmdPrint.Name = "_cmdPrint";
            _cmdPrint.RightToLeft = RightToLeft.No;
            _cmdPrint.Size = new Size(21, 21);
            _cmdPrint.TabIndex = 4;
            _cmdPrint.TextAlign = ContentAlignment.BottomCenter;
            ToolTip1.SetToolTip(_cmdPrint, "Print window");
            _cmdPrint.UseVisualStyleBackColor = false;
            // 
            // txtSetEbb
            // 
            _txtSetEbb.AcceptsReturn = true;
            _txtSetEbb.BackColor = SystemColors.Window;
            _txtSetEbb.Cursor = Cursors.IBeam;
            _txtSetEbb.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtSetEbb.ForeColor = SystemColors.WindowText;
            _txtSetEbb.Location = new Point(712, 67);
            _txtSetEbb.MaxLength = 3;
            _txtSetEbb.Name = "_txtSetEbb";
            _txtSetEbb.RightToLeft = RightToLeft.No;
            _txtSetEbb.Size = new Size(25, 21);
            _txtSetEbb.TabIndex = 49;
            // 
            // txtSetFlood
            // 
            _txtSetFlood.AcceptsReturn = true;
            _txtSetFlood.BackColor = SystemColors.Window;
            _txtSetFlood.Cursor = Cursors.IBeam;
            _txtSetFlood.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtSetFlood.ForeColor = SystemColors.WindowText;
            _txtSetFlood.Location = new Point(496, 67);
            _txtSetFlood.MaxLength = 3;
            _txtSetFlood.Name = "_txtSetFlood";
            _txtSetFlood.RightToLeft = RightToLeft.No;
            _txtSetFlood.Size = new Size(25, 21);
            _txtSetFlood.TabIndex = 45;
            // 
            // chkE
            // 
            _chkE.BackColor = SystemColors.Window;
            _chkE.Cursor = Cursors.Default;
            _chkE.Enabled = false;
            _chkE.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _chkE.ForeColor = SystemColors.ControlText;
            _chkE.Location = new Point(695, 154);
            _chkE.Name = "_chkE";
            _chkE.RightToLeft = RightToLeft.No;
            _chkE.Size = new Size(14, 13);
            _chkE.TabIndex = 69;
            _chkE.Text = "Check1";
            _chkE.UseVisualStyleBackColor = false;
            _chkE.Visible = false;
            // 
            // chkSBE
            // 
            _chkSBE.BackColor = SystemColors.Window;
            _chkSBE.Cursor = Cursors.Default;
            _chkSBE.Enabled = false;
            _chkSBE.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _chkSBE.ForeColor = SystemColors.ControlText;
            _chkSBE.Location = new Point(617, 154);
            _chkSBE.Name = "_chkSBE";
            _chkSBE.RightToLeft = RightToLeft.No;
            _chkSBE.Size = new Size(14, 13);
            _chkSBE.TabIndex = 68;
            _chkSBE.Text = "Check1";
            _chkSBE.UseVisualStyleBackColor = false;
            _chkSBE.Visible = false;
            // 
            // chkF
            // 
            _chkF.BackColor = SystemColors.Window;
            _chkF.Cursor = Cursors.Default;
            _chkF.Enabled = false;
            _chkF.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _chkF.ForeColor = SystemColors.ControlText;
            _chkF.Location = new Point(479, 154);
            _chkF.Name = "_chkF";
            _chkF.RightToLeft = RightToLeft.No;
            _chkF.Size = new Size(14, 13);
            _chkF.TabIndex = 67;
            _chkF.Text = "Check1";
            _chkF.UseVisualStyleBackColor = false;
            _chkF.Visible = false;
            // 
            // chkSBF
            // 
            _chkSBF.BackColor = SystemColors.Window;
            _chkSBF.Cursor = Cursors.Default;
            _chkSBF.Enabled = false;
            _chkSBF.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _chkSBF.ForeColor = SystemColors.ControlText;
            _chkSBF.Location = new Point(409, 154);
            _chkSBF.Name = "_chkSBF";
            _chkSBF.RightToLeft = RightToLeft.No;
            _chkSBF.Size = new Size(14, 13);
            _chkSBF.TabIndex = 66;
            _chkSBF.Text = "Check1";
            _chkSBF.UseVisualStyleBackColor = false;
            _chkSBF.Visible = false;
            // 
            // txtTab2SlackFHour
            // 
            _txtTab2SlackFHour.AcceptsReturn = true;
            _txtTab2SlackFHour.BackColor = SystemColors.Window;
            _txtTab2SlackFHour.Cursor = Cursors.IBeam;
            _txtTab2SlackFHour.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtTab2SlackFHour.ForeColor = SystemColors.WindowText;
            _txtTab2SlackFHour.Location = new Point(352, 127);
            _txtTab2SlackFHour.MaxLength = 2;
            _txtTab2SlackFHour.Name = "_txtTab2SlackFHour";
            _txtTab2SlackFHour.RightToLeft = RightToLeft.No;
            _txtTab2SlackFHour.Size = new Size(25, 21);
            _txtTab2SlackFHour.TabIndex = 52;
            // 
            // txtTab2SlackEHour
            // 
            _txtTab2SlackEHour.AcceptsReturn = true;
            _txtTab2SlackEHour.BackColor = SystemColors.Window;
            _txtTab2SlackEHour.Cursor = Cursors.IBeam;
            _txtTab2SlackEHour.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtTab2SlackEHour.ForeColor = SystemColors.WindowText;
            _txtTab2SlackEHour.Location = new Point(568, 127);
            _txtTab2SlackEHour.MaxLength = 2;
            _txtTab2SlackEHour.Name = "_txtTab2SlackEHour";
            _txtTab2SlackEHour.RightToLeft = RightToLeft.No;
            _txtTab2SlackEHour.Size = new Size(25, 21);
            _txtTab2SlackEHour.TabIndex = 57;
            // 
            // txtLocation
            // 
            _txtLocation.AcceptsReturn = true;
            _txtLocation.BackColor = SystemColors.Window;
            _txtLocation.Cursor = Cursors.IBeam;
            _txtLocation.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtLocation.ForeColor = SystemColors.WindowText;
            _txtLocation.Location = new Point(83, 2);
            _txtLocation.MaxLength = 0;
            _txtLocation.Name = "_txtLocation";
            _txtLocation.RightToLeft = RightToLeft.No;
            _txtLocation.Size = new Size(272, 21);
            _txtLocation.TabIndex = 14;
            // 
            // txtLocNo
            // 
            _txtLocNo.AcceptsReturn = true;
            _txtLocNo.BackColor = SystemColors.Window;
            _txtLocNo.Cursor = Cursors.IBeam;
            _txtLocNo.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtLocNo.ForeColor = SystemColors.WindowText;
            _txtLocNo.Location = new Point(387, 2);
            _txtLocNo.MaxLength = 7;
            _txtLocNo.Name = "_txtLocNo";
            _txtLocNo.RightToLeft = RightToLeft.No;
            _txtLocNo.Size = new Size(49, 21);
            _txtLocNo.TabIndex = 13;
            // 
            // txtRefSta
            // 
            _txtRefSta.AcceptsReturn = true;
            _txtRefSta.BackColor = SystemColors.Window;
            _txtRefSta.Cursor = Cursors.IBeam;
            _txtRefSta.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtRefSta.ForeColor = SystemColors.WindowText;
            _txtRefSta.Location = new Point(96, 104);
            _txtRefSta.MaxLength = 0;
            _txtRefSta.Name = "_txtRefSta";
            _txtRefSta.RightToLeft = RightToLeft.No;
            _txtRefSta.Size = new Size(234, 21);
            _txtRefSta.TabIndex = 8;
            // 
            // txtVelFlood
            // 
            _txtVelFlood.AcceptsReturn = true;
            _txtVelFlood.BackColor = SystemColors.Window;
            _txtVelFlood.Cursor = Cursors.IBeam;
            _txtVelFlood.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtVelFlood.ForeColor = SystemColors.WindowText;
            _txtVelFlood.Location = new Point(504, 104);
            _txtVelFlood.MaxLength = 5;
            _txtVelFlood.Name = "_txtVelFlood";
            _txtVelFlood.RightToLeft = RightToLeft.No;
            _txtVelFlood.Size = new Size(42, 21);
            _txtVelFlood.TabIndex = 47;
            // 
            // txtVelEbb
            // 
            _txtVelEbb.AcceptsReturn = true;
            _txtVelEbb.BackColor = SystemColors.Window;
            _txtVelEbb.Cursor = Cursors.IBeam;
            _txtVelEbb.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtVelEbb.ForeColor = SystemColors.WindowText;
            _txtVelEbb.Location = new Point(720, 104);
            _txtVelEbb.MaxLength = 5;
            _txtVelEbb.Name = "_txtVelEbb";
            _txtVelEbb.RightToLeft = RightToLeft.No;
            _txtVelEbb.Size = new Size(42, 21);
            _txtVelEbb.TabIndex = 51;
            // 
            // txtTab2Diff
            // 
            txtTab2Diff.AcceptsReturn = true;
            txtTab2Diff.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            txtTab2Diff.Cursor = Cursors.IBeam;
            txtTab2Diff.Enabled = false;
            txtTab2Diff.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtTab2Diff.ForeColor = SystemColors.WindowText;
            txtTab2Diff.Location = new Point(96, 127);
            txtTab2Diff.MaxLength = 0;
            txtTab2Diff.Name = "txtTab2Diff";
            txtTab2Diff.RightToLeft = RightToLeft.No;
            txtTab2Diff.Size = new Size(152, 21);
            txtTab2Diff.TabIndex = 7;
            // 
            // txtSubStaNo
            // 
            _txtSubStaNo.AcceptsReturn = true;
            _txtSubStaNo.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            _txtSubStaNo.Cursor = Cursors.IBeam;
            _txtSubStaNo.Enabled = false;
            _txtSubStaNo.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtSubStaNo.ForeColor = SystemColors.WindowText;
            _txtSubStaNo.Location = new Point(272, 127);
            _txtSubStaNo.MaxLength = 0;
            _txtSubStaNo.Name = "_txtSubStaNo";
            _txtSubStaNo.RightToLeft = RightToLeft.No;
            _txtSubStaNo.Size = new Size(49, 21);
            _txtSubStaNo.TabIndex = 6;
            // 
            // txtTab2FloodHour
            // 
            _txtTab2FloodHour.AcceptsReturn = true;
            _txtTab2FloodHour.BackColor = SystemColors.Window;
            _txtTab2FloodHour.Cursor = Cursors.IBeam;
            _txtTab2FloodHour.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtTab2FloodHour.ForeColor = SystemColors.WindowText;
            _txtTab2FloodHour.Location = new Point(432, 127);
            _txtTab2FloodHour.MaxLength = 2;
            _txtTab2FloodHour.Name = "_txtTab2FloodHour";
            _txtTab2FloodHour.RightToLeft = RightToLeft.No;
            _txtTab2FloodHour.Size = new Size(25, 21);
            _txtTab2FloodHour.TabIndex = 54;
            // 
            // txtTab2FloodMult
            // 
            _txtTab2FloodMult.AcceptsReturn = true;
            _txtTab2FloodMult.BackColor = SystemColors.Window;
            _txtTab2FloodMult.Cursor = Cursors.IBeam;
            _txtTab2FloodMult.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtTab2FloodMult.ForeColor = SystemColors.WindowText;
            _txtTab2FloodMult.Location = new Point(513, 127);
            _txtTab2FloodMult.MaxLength = 5;
            _txtTab2FloodMult.Name = "_txtTab2FloodMult";
            _txtTab2FloodMult.RightToLeft = RightToLeft.No;
            _txtTab2FloodMult.Size = new Size(32, 21);
            _txtTab2FloodMult.TabIndex = 56;
            // 
            // txtTab2EbbHour
            // 
            _txtTab2EbbHour.AcceptsReturn = true;
            _txtTab2EbbHour.BackColor = SystemColors.Window;
            _txtTab2EbbHour.Cursor = Cursors.IBeam;
            _txtTab2EbbHour.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtTab2EbbHour.ForeColor = SystemColors.WindowText;
            _txtTab2EbbHour.Location = new Point(648, 127);
            _txtTab2EbbHour.MaxLength = 2;
            _txtTab2EbbHour.Name = "_txtTab2EbbHour";
            _txtTab2EbbHour.RightToLeft = RightToLeft.No;
            _txtTab2EbbHour.Size = new Size(25, 21);
            _txtTab2EbbHour.TabIndex = 59;
            // 
            // txtTab2EbbMult
            // 
            _txtTab2EbbMult.AcceptsReturn = true;
            _txtTab2EbbMult.BackColor = SystemColors.Window;
            _txtTab2EbbMult.Cursor = Cursors.IBeam;
            _txtTab2EbbMult.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtTab2EbbMult.ForeColor = SystemColors.WindowText;
            _txtTab2EbbMult.Location = new Point(729, 127);
            _txtTab2EbbMult.MaxLength = 5;
            _txtTab2EbbMult.Name = "_txtTab2EbbMult";
            _txtTab2EbbMult.RightToLeft = RightToLeft.No;
            _txtTab2EbbMult.Size = new Size(32, 21);
            _txtTab2EbbMult.TabIndex = 61;
            // 
            // cmdCurrents
            // 
            _cmdCurrents.BackColor = SystemColors.Control;
            _cmdCurrents.Cursor = Cursors.Default;
            _cmdCurrents.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdCurrents.ForeColor = SystemColors.ControlText;
            _cmdCurrents.Location = new Point(567, 405);
            _cmdCurrents.Name = "_cmdCurrents";
            _cmdCurrents.RightToLeft = RightToLeft.No;
            _cmdCurrents.Size = new Size(67, 25);
            _cmdCurrents.TabIndex = 5;
            _cmdCurrents.Text = "&Calculate";
            _cmdCurrents.UseVisualStyleBackColor = false;
            // 
            // cmdClear
            // 
            _cmdClear.BackColor = SystemColors.Control;
            _cmdClear.Cursor = Cursors.Default;
            _cmdClear.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdClear.ForeColor = SystemColors.ControlText;
            _cmdClear.Location = new Point(649, 405);
            _cmdClear.Name = "_cmdClear";
            _cmdClear.RightToLeft = RightToLeft.No;
            _cmdClear.Size = new Size(64, 25);
            _cmdClear.TabIndex = 3;
            _cmdClear.Text = "Clea&r";
            _cmdClear.UseVisualStyleBackColor = false;
            // 
            // Frame1
            // 
            Frame1.BackColor = SystemColors.Window;
            Frame1.Controls.Add(_optRule);
            Frame1.Controls.Add(_optB);
            Frame1.Controls.Add(_optA);
            Frame1.Controls.Add(_optCalc);
            Frame1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Frame1.ForeColor = SystemColors.ControlText;
            Frame1.Location = new Point(19, 54);
            Frame1.Name = "Frame1";
            Frame1.Padding = new Padding(0);
            Frame1.RightToLeft = RightToLeft.No;
            Frame1.Size = new Size(319, 34);
            Frame1.TabIndex = 0;
            Frame1.TabStop = false;
            Frame1.Text = "Use Velocity Factor from";
            // 
            // optRule
            // 
            _optRule.BackColor = SystemColors.Window;
            _optRule.Cursor = Cursors.Default;
            _optRule.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optRule.ForeColor = SystemColors.ControlText;
            _optRule.Location = new Point(167, 12);
            _optRule.Name = "_optRule";
            _optRule.RightToLeft = RightToLeft.No;
            _optRule.Size = new Size(84, 17);
            _optRule.TabIndex = 72;
            _optRule.TabStop = true;
            _optRule.Text = "50-90  Rule";
            _optRule.UseVisualStyleBackColor = false;
            // 
            // optB
            // 
            _optB.BackColor = SystemColors.Window;
            _optB.Cursor = Cursors.Default;
            _optB.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optB.ForeColor = SystemColors.ControlText;
            _optB.Location = new Point(252, 12);
            _optB.Name = "_optB";
            _optB.RightToLeft = RightToLeft.No;
            _optB.Size = new Size(62, 17);
            _optB.TabIndex = 65;
            _optB.TabStop = true;
            _optB.Text = "Table 3B";
            _optB.UseVisualStyleBackColor = false;
            // 
            // optA
            // 
            _optA.BackColor = SystemColors.Window;
            _optA.Cursor = Cursors.Default;
            _optA.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optA.ForeColor = SystemColors.ControlText;
            _optA.Location = new Point(96, 12);
            _optA.Name = "_optA";
            _optA.RightToLeft = RightToLeft.No;
            _optA.Size = new Size(70, 17);
            _optA.TabIndex = 2;
            _optA.TabStop = true;
            _optA.Text = "Table 3A";
            _optA.UseVisualStyleBackColor = false;
            // 
            // optCalc
            // 
            _optCalc.BackColor = SystemColors.Window;
            _optCalc.Checked = true;
            _optCalc.Cursor = Cursors.Default;
            _optCalc.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optCalc.ForeColor = SystemColors.ControlText;
            _optCalc.Location = new Point(14, 12);
            _optCalc.Name = "_optCalc";
            _optCalc.RightToLeft = RightToLeft.No;
            _optCalc.Size = new Size(84, 17);
            _optCalc.TabIndex = 1;
            _optCalc.TabStop = true;
            _optCalc.Text = "Calculation";
            _optCalc.UseVisualStyleBackColor = false;
            // 
            // Label27
            // 
            Label27.BackColor = SystemColors.Window;
            Label27.Cursor = Cursors.Default;
            Label27.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label27.ForeColor = SystemColors.ControlText;
            Label27.Location = new Point(672, 67);
            Label27.Name = "Label27";
            Label27.RightToLeft = RightToLeft.No;
            Label27.Size = new Size(40, 17);
            Label27.TabIndex = 71;
            Label27.Text = "Set (°)";
            // 
            // Label26
            // 
            Label26.BackColor = SystemColors.Window;
            Label26.Cursor = Cursors.Default;
            Label26.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label26.ForeColor = SystemColors.ControlText;
            Label26.Location = new Point(456, 67);
            Label26.Name = "Label26";
            Label26.RightToLeft = RightToLeft.No;
            Label26.Size = new Size(40, 17);
            Label26.TabIndex = 70;
            Label26.Text = "Set (°)";
            // 
            // Label25
            // 
            Label25.BackColor = SystemColors.Window;
            Label25.Cursor = Cursors.Default;
            Label25.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label25.ForeColor = SystemColors.ControlText;
            Label25.Location = new Point(565, 89);
            Label25.Name = "Label25";
            Label25.RightToLeft = RightToLeft.No;
            Label25.Size = new Size(68, 17);
            Label25.TabIndex = 64;
            Label25.Text = "Time (hhmm)";
            // 
            // Label24
            // 
            Label24.BackColor = SystemColors.Window;
            Label24.Cursor = Cursors.Default;
            Label24.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label24.ForeColor = SystemColors.ControlText;
            Label24.Location = new Point(351, 88);
            Label24.Name = "Label24";
            Label24.RightToLeft = RightToLeft.No;
            Label24.Size = new Size(68, 17);
            Label24.TabIndex = 63;
            Label24.Text = "Time (hhmm)";
            // 
            // Label23
            // 
            Label23.BackColor = SystemColors.Window;
            Label23.Cursor = Cursors.Default;
            Label23.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label23.ForeColor = SystemColors.ControlText;
            Label23.Location = new Point(504, 127);
            Label23.Name = "Label23";
            Label23.RightToLeft = RightToLeft.No;
            Label23.Size = new Size(9, 17);
            Label23.TabIndex = 62;
            Label23.Text = "x";
            // 
            // Label22
            // 
            Label22.BackColor = SystemColors.Window;
            Label22.Cursor = Cursors.Default;
            Label22.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label22.ForeColor = SystemColors.ControlText;
            Label22.Location = new Point(560, 50);
            Label22.Name = "Label22";
            Label22.RightToLeft = RightToLeft.No;
            Label22.Size = new Size(110, 17);
            Label22.TabIndex = 43;
            Label22.Text = "SLACK Before Ebb";
            // 
            // Label21
            // 
            Label21.BackColor = SystemColors.Window;
            Label21.Cursor = Cursors.Default;
            Label21.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label21.ForeColor = SystemColors.ControlText;
            Label21.Location = new Point(344, 50);
            Label21.Name = "Label21";
            Label21.RightToLeft = RightToLeft.No;
            Label21.Size = new Size(110, 17);
            Label21.TabIndex = 42;
            Label21.Text = "SLACK Before Flood";
            // 
            // Label20
            // 
            Label20.BackColor = SystemColors.Window;
            Label20.Cursor = Cursors.Default;
            Label20.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label20.ForeColor = SystemColors.ControlText;
            Label20.Location = new Point(376, 127);
            Label20.Name = "Label20";
            Label20.RightToLeft = RightToLeft.No;
            Label20.Size = new Size(9, 17);
            Label20.TabIndex = 41;
            Label20.Text = "h";
            // 
            // Label19
            // 
            Label19.BackColor = SystemColors.Window;
            Label19.Cursor = Cursors.Default;
            Label19.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label19.ForeColor = SystemColors.ControlText;
            Label19.Location = new Point(410, 127);
            Label19.Name = "Label19";
            Label19.RightToLeft = RightToLeft.No;
            Label19.Size = new Size(12, 17);
            Label19.TabIndex = 40;
            Label19.Text = "m";
            // 
            // Label18
            // 
            Label18.BackColor = SystemColors.Window;
            Label18.Cursor = Cursors.Default;
            Label18.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label18.ForeColor = SystemColors.ControlText;
            Label18.Location = new Point(592, 127);
            Label18.Name = "Label18";
            Label18.RightToLeft = RightToLeft.No;
            Label18.Size = new Size(9, 17);
            Label18.TabIndex = 39;
            Label18.Text = "h";
            // 
            // Label17
            // 
            Label17.BackColor = SystemColors.Window;
            Label17.Cursor = Cursors.Default;
            Label17.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label17.ForeColor = SystemColors.ControlText;
            Label17.Location = new Point(626, 127);
            Label17.Name = "Label17";
            Label17.RightToLeft = RightToLeft.No;
            Label17.Size = new Size(12, 17);
            Label17.TabIndex = 38;
            Label17.Text = "m";
            // 
            // Label16
            // 
            Label16.BackColor = SystemColors.Window;
            Label16.Cursor = Cursors.Default;
            Label16.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label16.ForeColor = SystemColors.ControlText;
            Label16.Location = new Point(720, 127);
            Label16.Name = "Label16";
            Label16.RightToLeft = RightToLeft.No;
            Label16.Size = new Size(9, 17);
            Label16.TabIndex = 37;
            Label16.Text = "x";
            // 
            // lblLocation
            // 
            lblLocation.BackColor = SystemColors.Window;
            lblLocation.Cursor = Cursors.Default;
            lblLocation.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLocation.ForeColor = SystemColors.ControlText;
            lblLocation.Location = new Point(19, 4);
            lblLocation.Name = "lblLocation";
            lblLocation.RightToLeft = RightToLeft.No;
            lblLocation.Size = new Size(62, 17);
            lblLocation.TabIndex = 36;
            lblLocation.Text = "LOCATION";
            lblLocation.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblLocNumber
            // 
            lblLocNumber.BackColor = SystemColors.Window;
            lblLocNumber.Cursor = Cursors.Default;
            lblLocNumber.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLocNumber.ForeColor = SystemColors.ControlText;
            lblLocNumber.Location = new Point(371, 3);
            lblLocNumber.Name = "lblLocNumber";
            lblLocNumber.RightToLeft = RightToLeft.No;
            lblLocNumber.Size = new Size(16, 17);
            lblLocNumber.TabIndex = 35;
            lblLocNumber.Text = "(#";
            lblLocNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label1
            // 
            Label1.BackColor = SystemColors.Window;
            Label1.Cursor = Cursors.Default;
            Label1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = SystemColors.ControlText;
            Label1.Location = new Point(437, 2);
            Label1.Name = "Label1";
            Label1.RightToLeft = RightToLeft.No;
            Label1.Size = new Size(146, 17);
            Label1.TabIndex = 34;
            Label1.Text = ")  Substation # from Table 2";
            Label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label2
            // 
            Label2.BackColor = SystemColors.Window;
            Label2.Cursor = Cursors.Default;
            Label2.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = SystemColors.ControlText;
            Label2.Location = new Point(456, 50);
            Label2.Name = "Label2";
            Label2.RightToLeft = RightToLeft.No;
            Label2.Size = new Size(80, 17);
            Label2.TabIndex = 28;
            Label2.Text = "MAX. FLOOD";
            // 
            // Label3
            // 
            Label3.BackColor = SystemColors.Window;
            Label3.Cursor = Cursors.Default;
            Label3.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.ForeColor = SystemColors.ControlText;
            Label3.Location = new Point(680, 50);
            Label3.Name = "Label3";
            Label3.RightToLeft = RightToLeft.No;
            Label3.Size = new Size(57, 17);
            Label3.TabIndex = 27;
            Label3.Text = "MAX. EBB";
            // 
            // Label4
            // 
            Label4.BackColor = SystemColors.Window;
            Label4.Cursor = Cursors.Default;
            Label4.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.ForeColor = SystemColors.ControlText;
            Label4.Location = new Point(432, 88);
            Label4.Name = "Label4";
            Label4.RightToLeft = RightToLeft.No;
            Label4.Size = new Size(68, 17);
            Label4.TabIndex = 26;
            Label4.Text = "Time (hhmm)";
            // 
            // Label5
            // 
            Label5.BackColor = SystemColors.Window;
            Label5.Cursor = Cursors.Default;
            Label5.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label5.ForeColor = SystemColors.ControlText;
            Label5.Location = new Point(643, 88);
            Label5.Name = "Label5";
            Label5.RightToLeft = RightToLeft.No;
            Label5.Size = new Size(68, 17);
            Label5.TabIndex = 25;
            Label5.Text = "Time (hhmm)";
            // 
            // Label6
            // 
            Label6.BackColor = SystemColors.Window;
            Label6.Cursor = Cursors.Default;
            Label6.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label6.ForeColor = SystemColors.ControlText;
            Label6.Location = new Point(507, 88);
            Label6.Name = "Label6";
            Label6.RightToLeft = RightToLeft.No;
            Label6.Size = new Size(45, 17);
            Label6.TabIndex = 24;
            Label6.Text = "Vel (kn)";
            // 
            // Label7
            // 
            Label7.BackColor = SystemColors.Window;
            Label7.Cursor = Cursors.Default;
            Label7.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label7.ForeColor = SystemColors.ControlText;
            Label7.Location = new Point(723, 88);
            Label7.Name = "Label7";
            Label7.RightToLeft = RightToLeft.No;
            Label7.Size = new Size(50, 17);
            Label7.TabIndex = 23;
            Label7.Text = "Vel (kn)";
            // 
            // Label8
            // 
            Label8.BackColor = SystemColors.Window;
            Label8.Cursor = Cursors.Default;
            Label8.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label8.ForeColor = SystemColors.ControlText;
            Label8.Location = new Point(16, 106);
            Label8.Name = "Label8";
            Label8.RightToLeft = RightToLeft.No;
            Label8.Size = new Size(70, 17);
            Label8.TabIndex = 22;
            Label8.Text = "Ref. Station:";
            // 
            // Label9
            // 
            Label9.BackColor = SystemColors.Window;
            Label9.Cursor = Cursors.Default;
            Label9.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label9.ForeColor = SystemColors.ControlText;
            Label9.Location = new Point(16, 129);
            Label9.Name = "Label9";
            Label9.RightToLeft = RightToLeft.No;
            Label9.Size = new Size(78, 17);
            Label9.TabIndex = 21;
            Label9.Text = "+ Table 2 Diff:";
            // 
            // Label10
            // 
            Label10.BackColor = SystemColors.Window;
            Label10.Cursor = Cursors.Default;
            Label10.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label10.ForeColor = SystemColors.ControlText;
            Label10.Location = new Point(256, 127);
            Label10.Name = "Label10";
            Label10.RightToLeft = RightToLeft.No;
            Label10.Size = new Size(16, 17);
            Label10.TabIndex = 20;
            Label10.Text = "(#";
            // 
            // Label11
            // 
            Label11.BackColor = SystemColors.Window;
            Label11.Cursor = Cursors.Default;
            Label11.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label11.ForeColor = SystemColors.ControlText;
            Label11.Location = new Point(321, 127);
            Label11.Name = "Label11";
            Label11.RightToLeft = RightToLeft.No;
            Label11.Size = new Size(9, 17);
            Label11.TabIndex = 19;
            Label11.Text = ")";
            // 
            // Label12
            // 
            Label12.BackColor = SystemColors.Window;
            Label12.Cursor = Cursors.Default;
            Label12.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label12.ForeColor = SystemColors.ControlText;
            Label12.Location = new Point(455, 127);
            Label12.Name = "Label12";
            Label12.RightToLeft = RightToLeft.No;
            Label12.Size = new Size(9, 17);
            Label12.TabIndex = 18;
            Label12.Text = "h";
            // 
            // Label13
            // 
            Label13.BackColor = SystemColors.Window;
            Label13.Cursor = Cursors.Default;
            Label13.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label13.ForeColor = SystemColors.ControlText;
            Label13.Location = new Point(489, 127);
            Label13.Name = "Label13";
            Label13.RightToLeft = RightToLeft.No;
            Label13.Size = new Size(12, 17);
            Label13.TabIndex = 17;
            Label13.Text = "m";
            // 
            // Label14
            // 
            Label14.BackColor = SystemColors.Window;
            Label14.Cursor = Cursors.Default;
            Label14.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label14.ForeColor = SystemColors.ControlText;
            Label14.Location = new Point(672, 127);
            Label14.Name = "Label14";
            Label14.RightToLeft = RightToLeft.No;
            Label14.Size = new Size(9, 17);
            Label14.TabIndex = 16;
            Label14.Text = "h";
            // 
            // Label15
            // 
            Label15.BackColor = SystemColors.Window;
            Label15.Cursor = Cursors.Default;
            Label15.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label15.ForeColor = SystemColors.ControlText;
            Label15.Location = new Point(705, 127);
            Label15.Name = "Label15";
            Label15.RightToLeft = RightToLeft.No;
            Label15.Size = new Size(12, 17);
            Label15.TabIndex = 15;
            Label15.Text = "m";
            // 
            // ExitBtn
            // 
            _ExitBtn.BackColor = Color.Red;
            _ExitBtn.Cursor = Cursors.Default;
            _ExitBtn.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _ExitBtn.ForeColor = SystemColors.ControlLightLight;
            _ExitBtn.Location = new Point(721, 405);
            _ExitBtn.Name = "_ExitBtn";
            _ExitBtn.RightToLeft = RightToLeft.No;
            _ExitBtn.Size = new Size(64, 25);
            _ExitBtn.TabIndex = 73;
            _ExitBtn.Text = "Exit";
            _ExitBtn.UseVisualStyleBackColor = false;
            // 
            // Curr1Txtbx
            // 
            Curr1Txtbx.BorderStyle = BorderStyle.None;
            Curr1Txtbx.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Pixel, Conversions.ToByte(0));
            Curr1Txtbx.Location = new Point(-2, 155);
            Curr1Txtbx.Name = "Curr1Txtbx";
            Curr1Txtbx.ReadOnly = true;
            Curr1Txtbx.Size = new Size(338, 10);
            Curr1Txtbx.TabIndex = 74;
            // 
            // Curr2TxtBx
            // 
            Curr2TxtBx.BorderStyle = BorderStyle.None;
            Curr2TxtBx.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Pixel, Conversions.ToByte(0));
            Curr2TxtBx.Location = new Point(352, 155);
            Curr2TxtBx.Name = "Curr2TxtBx";
            Curr2TxtBx.ReadOnly = true;
            Curr2TxtBx.Size = new Size(55, 10);
            Curr2TxtBx.TabIndex = 75;
            Curr2TxtBx.TextAlign = HorizontalAlignment.Right;
            // 
            // Curr3TxtBx
            // 
            Curr3TxtBx.BorderStyle = BorderStyle.None;
            Curr3TxtBx.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Pixel, Conversions.ToByte(0));
            Curr3TxtBx.Location = new Point(433, 155);
            Curr3TxtBx.Name = "Curr3TxtBx";
            Curr3TxtBx.ReadOnly = true;
            Curr3TxtBx.Size = new Size(44, 10);
            Curr3TxtBx.TabIndex = 76;
            Curr3TxtBx.TextAlign = HorizontalAlignment.Right;
            // 
            // Curr4TxtBx
            // 
            Curr4TxtBx.BorderStyle = BorderStyle.None;
            Curr4TxtBx.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Pixel, Conversions.ToByte(0));
            Curr4TxtBx.Location = new Point(503, 155);
            Curr4TxtBx.Name = "Curr4TxtBx";
            Curr4TxtBx.ReadOnly = true;
            Curr4TxtBx.Size = new Size(44, 10);
            Curr4TxtBx.TabIndex = 77;
            Curr4TxtBx.TextAlign = HorizontalAlignment.Right;
            // 
            // Curr5TxtBx
            // 
            Curr5TxtBx.BorderStyle = BorderStyle.None;
            Curr5TxtBx.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Pixel, Conversions.ToByte(0));
            Curr5TxtBx.Location = new Point(570, 155);
            Curr5TxtBx.Name = "Curr5TxtBx";
            Curr5TxtBx.ReadOnly = true;
            Curr5TxtBx.Size = new Size(44, 10);
            Curr5TxtBx.TabIndex = 78;
            Curr5TxtBx.TextAlign = HorizontalAlignment.Right;
            // 
            // Curr6TxtBx
            // 
            Curr6TxtBx.BorderStyle = BorderStyle.None;
            Curr6TxtBx.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Pixel, Conversions.ToByte(0));
            Curr6TxtBx.Location = new Point(649, 155);
            Curr6TxtBx.Name = "Curr6TxtBx";
            Curr6TxtBx.ReadOnly = true;
            Curr6TxtBx.Size = new Size(44, 10);
            Curr6TxtBx.TabIndex = 79;
            Curr6TxtBx.TextAlign = HorizontalAlignment.Right;
            // 
            // Curr7TxtBx
            // 
            Curr7TxtBx.BorderStyle = BorderStyle.None;
            Curr7TxtBx.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Pixel, Conversions.ToByte(0));
            Curr7TxtBx.Location = new Point(719, 155);
            Curr7TxtBx.Name = "Curr7TxtBx";
            Curr7TxtBx.ReadOnly = true;
            Curr7TxtBx.Size = new Size(44, 10);
            Curr7TxtBx.TabIndex = 80;
            Curr7TxtBx.TextAlign = HorizontalAlignment.Right;
            // 
            // Curr11TxtBx
            // 
            Curr11TxtBx.BorderStyle = BorderStyle.None;
            Curr11TxtBx.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Pixel, Conversions.ToByte(0));
            Curr11TxtBx.Location = new Point(1, 239);
            Curr11TxtBx.Name = "Curr11TxtBx";
            Curr11TxtBx.ReadOnly = true;
            Curr11TxtBx.Size = new Size(553, 10);
            Curr11TxtBx.TabIndex = 81;
            Curr11TxtBx.TextAlign = HorizontalAlignment.Center;
            // 
            // Curr15TxtBx
            // 
            Curr15TxtBx.BorderStyle = BorderStyle.None;
            Curr15TxtBx.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Pixel, Conversions.ToByte(0));
            Curr15TxtBx.Location = new Point(1, 319);
            Curr15TxtBx.Name = "Curr15TxtBx";
            Curr15TxtBx.ReadOnly = true;
            Curr15TxtBx.Size = new Size(553, 10);
            Curr15TxtBx.TabIndex = 82;
            // 
            // Curr8TxtBx
            // 
            Curr8TxtBx.BorderStyle = BorderStyle.None;
            Curr8TxtBx.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Pixel, Conversions.ToByte(0));
            Curr8TxtBx.Location = new Point(0, 174);
            Curr8TxtBx.Name = "Curr8TxtBx";
            Curr8TxtBx.ReadOnly = true;
            Curr8TxtBx.ScrollBars = RichTextBoxScrollBars.None;
            Curr8TxtBx.Size = new Size(553, 60);
            Curr8TxtBx.TabIndex = 83;
            Curr8TxtBx.Text = "";
            // 
            // Curr13TxtBx
            // 
            Curr13TxtBx.BorderStyle = BorderStyle.None;
            Curr13TxtBx.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Pixel, Conversions.ToByte(0));
            Curr13TxtBx.Location = new Point(1, 253);
            Curr13TxtBx.Name = "Curr13TxtBx";
            Curr13TxtBx.ReadOnly = true;
            Curr13TxtBx.ScrollBars = RichTextBoxScrollBars.None;
            Curr13TxtBx.Size = new Size(553, 60);
            Curr13TxtBx.TabIndex = 84;
            Curr13TxtBx.Text = "";
            // 
            // Curr18TxtBx
            // 
            Curr18TxtBx.BorderStyle = BorderStyle.None;
            Curr18TxtBx.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Pixel, Conversions.ToByte(0));
            Curr18TxtBx.Location = new Point(1, 333);
            Curr18TxtBx.Name = "Curr18TxtBx";
            Curr18TxtBx.ReadOnly = true;
            Curr18TxtBx.ScrollBars = RichTextBoxScrollBars.None;
            Curr18TxtBx.Size = new Size(553, 60);
            Curr18TxtBx.TabIndex = 85;
            Curr18TxtBx.Text = "";
            // 
            // Curr10TxtBx
            // 
            Curr10TxtBx.BorderStyle = BorderStyle.None;
            Curr10TxtBx.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Pixel, Conversions.ToByte(0));
            Curr10TxtBx.Location = new Point(650, 175);
            Curr10TxtBx.Multiline = true;
            Curr10TxtBx.Name = "Curr10TxtBx";
            Curr10TxtBx.ReadOnly = true;
            Curr10TxtBx.Size = new Size(150, 60);
            Curr10TxtBx.TabIndex = 86;
            // 
            // Curr12TxtBx
            // 
            Curr12TxtBx.BorderStyle = BorderStyle.None;
            Curr12TxtBx.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Pixel, Conversions.ToByte(0));
            Curr12TxtBx.Location = new Point(651, 241);
            Curr12TxtBx.Name = "Curr12TxtBx";
            Curr12TxtBx.ReadOnly = true;
            Curr12TxtBx.Size = new Size(150, 10);
            Curr12TxtBx.TabIndex = 87;
            // 
            // Curr17TxtBx
            // 
            Curr17TxtBx.BorderStyle = BorderStyle.None;
            Curr17TxtBx.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Pixel, Conversions.ToByte(0));
            Curr17TxtBx.Location = new Point(651, 320);
            Curr17TxtBx.Name = "Curr17TxtBx";
            Curr17TxtBx.ReadOnly = true;
            Curr17TxtBx.Size = new Size(150, 10);
            Curr17TxtBx.TabIndex = 88;
            // 
            // Curr14TxtBx
            // 
            Curr14TxtBx.BorderStyle = BorderStyle.None;
            Curr14TxtBx.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Pixel, Conversions.ToByte(0));
            Curr14TxtBx.Location = new Point(651, 253);
            Curr14TxtBx.Multiline = true;
            Curr14TxtBx.Name = "Curr14TxtBx";
            Curr14TxtBx.ReadOnly = true;
            Curr14TxtBx.Size = new Size(150, 60);
            Curr14TxtBx.TabIndex = 89;
            // 
            // Curr20TxtBx
            // 
            Curr20TxtBx.BorderStyle = BorderStyle.None;
            Curr20TxtBx.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Pixel, Conversions.ToByte(0));
            Curr20TxtBx.Location = new Point(651, 333);
            Curr20TxtBx.Multiline = true;
            Curr20TxtBx.Name = "Curr20TxtBx";
            Curr20TxtBx.ReadOnly = true;
            Curr20TxtBx.Size = new Size(150, 60);
            Curr20TxtBx.TabIndex = 90;
            // 
            // Curr16TxtBx
            // 
            Curr16TxtBx.BorderStyle = BorderStyle.None;
            Curr16TxtBx.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Pixel, Conversions.ToByte(0));
            Curr16TxtBx.Location = new Point(558, 320);
            Curr16TxtBx.Name = "Curr16TxtBx";
            Curr16TxtBx.ReadOnly = true;
            Curr16TxtBx.Size = new Size(90, 10);
            Curr16TxtBx.TabIndex = 91;
            Curr16TxtBx.TextAlign = HorizontalAlignment.Center;
            // 
            // Curr19TxtBx
            // 
            Curr19TxtBx.BorderStyle = BorderStyle.None;
            Curr19TxtBx.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Pixel, Conversions.ToByte(0));
            Curr19TxtBx.Location = new Point(557, 333);
            Curr19TxtBx.Multiline = true;
            Curr19TxtBx.Name = "Curr19TxtBx";
            Curr19TxtBx.ReadOnly = true;
            Curr19TxtBx.Size = new Size(90, 60);
            Curr19TxtBx.TabIndex = 92;
            Curr19TxtBx.TextAlign = HorizontalAlignment.Center;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.ABC_white;
            PictureBox1.Location = new Point(236, 405);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(316, 50);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 102;
            PictureBox1.TabStop = false;
            // 
            // LinkNOAACurrentTides
            // 
            _LinkNOAACurrentTides.AutoSize = true;
            _LinkNOAACurrentTides.Location = new Point(231, 460);
            _LinkNOAACurrentTides.Name = "_LinkNOAACurrentTides";
            _LinkNOAACurrentTides.Size = new Size(335, 28);
            _LinkNOAACurrentTides.TabIndex = 104;
            _LinkNOAACurrentTides.TabStop = true;
            _LinkNOAACurrentTides.Text = "For additional information and online tools about current predictions, " + '\r' + '\n' + "Click he" + "re to go to the NOAA Currents Predictions Web Page";
            _LinkNOAACurrentTides.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DTTides
            // 
            DTTides.CustomFormat = "MM / dd / yyyy HH:mm";
            DTTides.DropDownAlign = LeftRightAlignment.Right;
            DTTides.Format = DateTimePickerFormat.Custom;
            DTTides.Location = new Point(208, 25);
            DTTides.Name = "DTTides";
            DTTides.Size = new Size(146, 20);
            DTTides.TabIndex = 128;
            // 
            // lblDate
            // 
            lblDate.BackColor = SystemColors.Window;
            lblDate.Cursor = Cursors.Default;
            lblDate.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblDate.ForeColor = SystemColors.ControlText;
            lblDate.Location = new Point(12, 24);
            lblDate.Name = "lblDate";
            lblDate.RightToLeft = RightToLeft.No;
            lblDate.Size = new Size(190, 20);
            lblDate.TabIndex = 127;
            lblDate.Text = "Desired Date and Time for Currents:";
            lblDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DTTimeSlackBeforeFlood
            // 
            DTTimeSlackBeforeFlood.CustomFormat = "HH:mm";
            DTTimeSlackBeforeFlood.Format = DateTimePickerFormat.Custom;
            DTTimeSlackBeforeFlood.Location = new Point(353, 104);
            DTTimeSlackBeforeFlood.Name = "DTTimeSlackBeforeFlood";
            DTTimeSlackBeforeFlood.ShowUpDown = true;
            DTTimeSlackBeforeFlood.Size = new Size(60, 20);
            DTTimeSlackBeforeFlood.TabIndex = 129;
            // 
            // DTTimeFlood
            // 
            DTTimeFlood.CustomFormat = "HH:mm";
            DTTimeFlood.Format = DateTimePickerFormat.Custom;
            DTTimeFlood.Location = new Point(433, 103);
            DTTimeFlood.Name = "DTTimeFlood";
            DTTimeFlood.ShowUpDown = true;
            DTTimeFlood.Size = new Size(60, 20);
            DTTimeFlood.TabIndex = 130;
            // 
            // DTTimeSlackBeforeEbb
            // 
            DTTimeSlackBeforeEbb.CustomFormat = "HH:mm";
            DTTimeSlackBeforeEbb.Format = DateTimePickerFormat.Custom;
            DTTimeSlackBeforeEbb.Location = new Point(568, 105);
            DTTimeSlackBeforeEbb.Name = "DTTimeSlackBeforeEbb";
            DTTimeSlackBeforeEbb.ShowUpDown = true;
            DTTimeSlackBeforeEbb.Size = new Size(60, 20);
            DTTimeSlackBeforeEbb.TabIndex = 131;
            // 
            // DTTimeEbb
            // 
            DTTimeEbb.CustomFormat = "HH:mm";
            DTTimeEbb.Format = DateTimePickerFormat.Custom;
            DTTimeEbb.Location = new Point(647, 104);
            DTTimeEbb.Name = "DTTimeEbb";
            DTTimeEbb.ShowUpDown = true;
            DTTimeEbb.Size = new Size(60, 20);
            DTTimeEbb.TabIndex = 132;
            // 
            // FormCurrents
            // 
            AutoScaleDimensions = new SizeF(6.0f, 14.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(802, 519);
            Controls.Add(DTTimeEbb);
            Controls.Add(DTTimeSlackBeforeEbb);
            Controls.Add(DTTimeFlood);
            Controls.Add(DTTimeSlackBeforeFlood);
            Controls.Add(DTTides);
            Controls.Add(lblDate);
            Controls.Add(_LinkNOAACurrentTides);
            Controls.Add(PictureBox1);
            Controls.Add(Curr19TxtBx);
            Controls.Add(Curr16TxtBx);
            Controls.Add(Curr20TxtBx);
            Controls.Add(Curr14TxtBx);
            Controls.Add(Curr17TxtBx);
            Controls.Add(Curr12TxtBx);
            Controls.Add(Curr10TxtBx);
            Controls.Add(Curr18TxtBx);
            Controls.Add(Curr13TxtBx);
            Controls.Add(Curr8TxtBx);
            Controls.Add(Curr15TxtBx);
            Controls.Add(Curr11TxtBx);
            Controls.Add(Curr7TxtBx);
            Controls.Add(_ExitBtn);
            Controls.Add(_txtSetEbb);
            Controls.Add(_txtSetFlood);
            Controls.Add(_chkE);
            Controls.Add(_chkSBE);
            Controls.Add(_chkF);
            Controls.Add(_chkSBF);
            Controls.Add(_txtTab2SlackFHour);
            Controls.Add(_txtTab2SlackFMin);
            Controls.Add(_txtTab2SlackEHour);
            Controls.Add(_txtTab2SlackEMin);
            Controls.Add(_txtLocation);
            Controls.Add(_txtLocNo);
            Controls.Add(_txtRefSta);
            Controls.Add(_txtVelFlood);
            Controls.Add(_txtVelEbb);
            Controls.Add(txtTab2Diff);
            Controls.Add(_txtSubStaNo);
            Controls.Add(_txtTab2FloodHour);
            Controls.Add(_txtTab2FloodMin);
            Controls.Add(_txtTab2FloodMult);
            Controls.Add(_txtTab2EbbHour);
            Controls.Add(_txtTab2EbbMin);
            Controls.Add(_txtTab2EbbMult);
            Controls.Add(_cmdCurrents);
            Controls.Add(_cmdPrint);
            Controls.Add(_cmdClear);
            Controls.Add(Frame1);
            Controls.Add(Label27);
            Controls.Add(Label26);
            Controls.Add(Label25);
            Controls.Add(Label24);
            Controls.Add(Label23);
            Controls.Add(Label22);
            Controls.Add(Label21);
            Controls.Add(Label20);
            Controls.Add(Label19);
            Controls.Add(Label18);
            Controls.Add(Label17);
            Controls.Add(Label16);
            Controls.Add(lblLocation);
            Controls.Add(lblLocNumber);
            Controls.Add(Label1);
            Controls.Add(Label2);
            Controls.Add(Label3);
            Controls.Add(Label4);
            Controls.Add(Label5);
            Controls.Add(Label6);
            Controls.Add(Label7);
            Controls.Add(Label8);
            Controls.Add(Label9);
            Controls.Add(Label10);
            Controls.Add(Label11);
            Controls.Add(Label12);
            Controls.Add(Label13);
            Controls.Add(Label14);
            Controls.Add(Label15);
            Controls.Add(Curr1Txtbx);
            Controls.Add(Curr2TxtBx);
            Controls.Add(Curr3TxtBx);
            Controls.Add(Curr4TxtBx);
            Controls.Add(Curr5TxtBx);
            Controls.Add(Curr6TxtBx);
            Cursor = Cursors.Default;
            Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(3, 22);
            MaximizeBox = false;
            Name = "FormCurrents";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Set & Drift of Tidal Current at Desired Time";
            Frame1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Load += new EventHandler(FormCurrents_Load);
            FormClosed += new FormClosedEventHandler(FormCurrents_FormClosed);
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

        internal TextBox Curr1Txtbx;
        internal TextBox Curr2TxtBx;
        internal TextBox Curr3TxtBx;
        internal TextBox Curr4TxtBx;
        internal TextBox Curr5TxtBx;
        internal TextBox Curr6TxtBx;
        internal TextBox Curr7TxtBx;
        internal TextBox Curr11TxtBx;
        internal TextBox Curr15TxtBx;
        internal RichTextBox Curr8TxtBx;
        internal RichTextBox Curr13TxtBx;
        internal RichTextBox Curr18TxtBx;
        internal TextBox Curr10TxtBx;
        internal TextBox Curr12TxtBx;
        internal TextBox Curr17TxtBx;
        internal TextBox Curr14TxtBx;
        internal TextBox Curr20TxtBx;
        internal TextBox Curr16TxtBx;
        internal TextBox Curr19TxtBx;
        internal PictureBox PictureBox1;
        private LinkLabel _LinkNOAACurrentTides;

        internal LinkLabel LinkNOAACurrentTides
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LinkNOAACurrentTides;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LinkNOAACurrentTides != null)
                {
                    _LinkNOAACurrentTides.LinkClicked -= LinkNOAACurrentTides_LinkClicked;
                }

                _LinkNOAACurrentTides = value;
                if (_LinkNOAACurrentTides != null)
                {
                    _LinkNOAACurrentTides.LinkClicked += LinkNOAACurrentTides_LinkClicked;
                }
            }
        }

        internal DateTimePicker DTTides;
        public Label lblDate;
        internal DateTimePicker DTTimeSlackBeforeFlood;
        internal DateTimePicker DTTimeFlood;
        internal DateTimePicker DTTimeSlackBeforeEbb;
        internal DateTimePicker DTTimeEbb;
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}