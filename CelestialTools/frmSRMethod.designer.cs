using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    [DesignerGenerated()]
    internal partial class FormAltSR
    {
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        [DebuggerNonUserCode()]
        public FormAltSR() : base()
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
        private CheckBox _chkInterpolateB;

        public CheckBox chkInterpolateB
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _chkInterpolateB;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_chkInterpolateB != null)
                {
                    _chkInterpolateB.CheckStateChanged -= chkInterpolateB_CheckStateChanged;
                }

                _chkInterpolateB = value;
                if (_chkInterpolateB != null)
                {
                    _chkInterpolateB.CheckStateChanged += chkInterpolateB_CheckStateChanged;
                }
            }
        }

        private Button _cmdWeems;

        public Button cmdWeems
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdWeems;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdWeems != null)
                {
                    _cmdWeems.Click -= cmdWeems_Click;
                }

                _cmdWeems = value;
                if (_cmdWeems != null)
                {
                    _cmdWeems.Click += cmdWeems_Click;
                }
            }
        }

        private RadioButton _optFarley;

        public RadioButton optFarley
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optFarley;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optFarley != null)
                {
                    _optFarley.CheckedChanged -= optFarley_CheckedChanged;
                }

                _optFarley = value;
                if (_optFarley != null)
                {
                    _optFarley.CheckedChanged += optFarley_CheckedChanged;
                }
            }
        }

        private RadioButton _optPepperday;

        public RadioButton optPepperday
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optPepperday;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optPepperday != null)
                {
                    _optPepperday.CheckedChanged -= optPepperday_CheckedChanged;
                }

                _optPepperday = value;
                if (_optPepperday != null)
                {
                    _optPepperday.CheckedChanged += optPepperday_CheckedChanged;
                }
            }
        }

        public GroupBox frameS;
        private Button _cmdSTable;

        public Button cmdSTable
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdSTable;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdSTable != null)
                {
                    _cmdSTable.Click -= cmdSTable_Click;
                }

                _cmdSTable = value;
                if (_cmdSTable != null)
                {
                    _cmdSTable.Click += cmdSTable_Click;
                }
            }
        }

        private CheckBox _chkSadler;

        public CheckBox chkSadler
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _chkSadler;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_chkSadler != null)
                {
                    _chkSadler.CheckStateChanged -= chkSadler_CheckStateChanged;
                }

                _chkSadler = value;
                if (_chkSadler != null)
                {
                    _chkSadler.CheckStateChanged += chkSadler_CheckStateChanged;
                }
            }
        }

        private RadioButton _optdtL;

        public RadioButton optdtL
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optdtL;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optdtL != null)
                {
                    _optdtL.CheckedChanged -= optdtL_CheckedChanged;
                }

                _optdtL = value;
                if (_optdtL != null)
                {
                    _optdtL.CheckedChanged += optdtL_CheckedChanged;
                }
            }
        }

        private RadioButton _optdt;

        public RadioButton optdt
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optdt;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optdt != null)
                {
                    _optdt.CheckedChanged -= optdt_CheckedChanged;
                }

                _optdt = value;
                if (_optdt != null)
                {
                    _optdt.CheckedChanged += optdt_CheckedChanged;
                }
            }
        }

        private RadioButton _optd;

        public RadioButton optd
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optd;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optd != null)
                {
                    _optd.CheckedChanged -= optd_CheckedChanged;
                }

                _optd = value;
                if (_optd != null)
                {
                    _optd.CheckedChanged += optd_CheckedChanged;
                }
            }
        }

        public Label Label15;
        public Label Label14;
        public Label Label13;
        public Label Label12;
        public Label Label11;
        public Label Label10;
        public Label Label8;
        public Label Label7;
        public Label Label9;
        public GroupBox frame214;
        private CheckBox _chkDSD;

        public CheckBox chkDSD
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _chkDSD;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_chkDSD != null)
                {
                    _chkDSD.CheckStateChanged -= chkDSD_CheckStateChanged;
                }

                _chkDSD = value;
                if (_chkDSD != null)
                {
                    _chkDSD.CheckStateChanged += chkDSD_CheckStateChanged;
                }
            }
        }

        private RadioButton _optCompact;

        public RadioButton optCompact
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optCompact;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optCompact != null)
                {
                    _optCompact.CheckedChanged -= optCompact_CheckedChanged;
                }

                _optCompact = value;
                if (_optCompact != null)
                {
                    _optCompact.CheckedChanged += optCompact_CheckedChanged;
                }
            }
        }

        private RadioButton _optOriginal;

        public RadioButton optOriginal
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optOriginal;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optOriginal != null)
                {
                    _optOriginal.CheckedChanged -= optOriginal_CheckedChanged;
                }

                _optOriginal = value;
                if (_optOriginal != null)
                {
                    _optOriginal.CheckedChanged += optOriginal_CheckedChanged;
                }
            }
        }

        public GroupBox frame211;
        private Button _cmd208;

        public Button cmd208
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmd208;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmd208 != null)
                {
                    _cmd208.Click -= cmd208_Click;
                }

                _cmd208 = value;
                if (_cmd208 != null)
                {
                    _cmd208.Click += cmd208_Click;
                }
            }
        }

        private Button _cmd211;

        public Button cmd211
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmd211;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmd211 != null)
                {
                    _cmd211.Click -= cmd211_Click;
                }

                _cmd211 = value;
                if (_cmd211 != null)
                {
                    _cmd211.Click += cmd211_Click;
                }
            }
        }

        private Button _cmd214;

        public Button cmd214
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmd214;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmd214 != null)
                {
                    _cmd214.Click -= cmd214_Click;
                }

                _cmd214 = value;
                if (_cmd214 != null)
                {
                    _cmd214.Click += cmd214_Click;
                }
            }
        }

        private Button _cmd229;

        public Button cmd229
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmd229;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmd229 != null)
                {
                    _cmd229.Click -= cmd229_Click;
                }

                _cmd229 = value;
                if (_cmd229 != null)
                {
                    _cmd229.Click += cmd229_Click;
                }
            }
        }

        private Button _cmd249;

        public Button cmd249
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmd249;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmd249 != null)
                {
                    _cmd249.Click -= cmd249_Click;
                }

                _cmd249 = value;
                if (_cmd249 != null)
                {
                    _cmd249.Click += cmd249_Click;
                }
            }
        }

        private Button _cmdClearSome;

        public Button cmdClearSome
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdClearSome;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdClearSome != null)
                {
                    _cmdClearSome.Click -= cmdClearSome_Click;
                }

                _cmdClearSome = value;
                if (_cmdClearSome != null)
                {
                    _cmdClearSome.Click += cmdClearSome_Click;
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

        private Button _cmdFix;

        public Button cmdFix
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdFix;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdFix != null)
                {
                    _cmdFix.Click -= cmdFix_Click;
                }

                _cmdFix = value;
                if (_cmdFix != null)
                {
                    _cmdFix.Click += cmdFix_Click;
                }
            }
        }

        private Button _cmdSave;

        public Button cmdSave
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdSave;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdSave != null)
                {
                    _cmdSave.Click -= cmdSave_Click;
                }

                _cmdSave = value;
                if (_cmdSave != null)
                {
                    _cmdSave.Click += cmdSave_Click;
                }
            }
        }

        private RadioButton _optNATable;

        public RadioButton optNATable
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optNATable;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optNATable != null)
                {
                    _optNATable.CheckedChanged -= optNATable_CheckedChanged;
                }

                _optNATable = value;
                if (_optNATable != null)
                {
                    _optNATable.CheckedChanged += optNATable_CheckedChanged;
                }
            }
        }

        private RadioButton _optUSPSTable;

        public RadioButton optUSPSTable
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optUSPSTable;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optUSPSTable != null)
                {
                    _optUSPSTable.CheckedChanged -= optUSPSTable_CheckedChanged;
                }

                _optUSPSTable = value;
                if (_optUSPSTable != null)
                {
                    _optUSPSTable.CheckedChanged += optUSPSTable_CheckedChanged;
                }
            }
        }

        public GroupBox frameNASRUsing;
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

        private Button _cmdNASR;

        public Button cmdNASR
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdNASR;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdNASR != null)
                {
                    _cmdNASR.Click -= cmdNASR_Click;
                }

                _cmdNASR = value;
                if (_cmdNASR != null)
                {
                    _cmdNASR.Click += cmdNASR_Click;
                }
            }
        }

        private Button _cmdLawOfCosines;

        public Button cmdLawOfCosines
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdLawOfCosines;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdLawOfCosines != null)
                {
                    _cmdLawOfCosines.Click -= cmdLawOfCosines_Click;
                }

                _cmdLawOfCosines = value;
                if (_cmdLawOfCosines != null)
                {
                    _cmdLawOfCosines.Click += cmdLawOfCosines_Click;
                }
            }
        }

        private ComboBox _cboDec;

        public ComboBox cboDec
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboDec;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboDec != null)
                {
                    _cboDec.SelectedIndexChanged -= CboDec_SelectedIndexChanged;
                }

                _cboDec = value;
                if (_cboDec != null)
                {
                    _cboDec.SelectedIndexChanged += CboDec_SelectedIndexChanged;
                }
            }
        }

        private TextBox _txtHoMin;

        public TextBox txtHoMin
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtHoMin;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtHoMin != null)
                {
                    _txtHoMin.TextChanged -= txtHoMin_TextChanged;
                    _txtHoMin.KeyPress -= txtHoMin_KeyPress;
                    _txtHoMin.Validating -= txtHoMin_Validating;
                    _txtHoMin.Enter -= txtHoMin_Enter;
                }

                _txtHoMin = value;
                if (_txtHoMin != null)
                {
                    _txtHoMin.TextChanged += txtHoMin_TextChanged;
                    _txtHoMin.KeyPress += txtHoMin_KeyPress;
                    _txtHoMin.Validating += txtHoMin_Validating;
                    _txtHoMin.Enter += txtHoMin_Enter;
                }
            }
        }

        private TextBox _txtDecMin;

        public TextBox txtDecMin
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtDecMin;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtDecMin != null)
                {
                    _txtDecMin.TextChanged -= txtDecMin_TextChanged;
                    _txtDecMin.KeyPress -= txtDecMin_KeyPress;
                    _txtDecMin.Validating -= txtDecMin_Validating;
                    _txtDecMin.Enter -= txtDecMin_Enter;
                }

                _txtDecMin = value;
                if (_txtDecMin != null)
                {
                    _txtDecMin.TextChanged += txtDecMin_TextChanged;
                    _txtDecMin.KeyPress += txtDecMin_KeyPress;
                    _txtDecMin.Validating += txtDecMin_Validating;
                    _txtDecMin.Enter += txtDecMin_Enter;
                }
            }
        }

        private TextBox _txtGHAMin;

        public TextBox txtGHAMin
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtGHAMin;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtGHAMin != null)
                {
                    _txtGHAMin.TextChanged -= txtGHAMin_TextChanged;
                    _txtGHAMin.KeyPress -= txtGHAMin_KeyPress;
                    _txtGHAMin.Validating -= txtGHAMin_Validating;
                    _txtGHAMin.Enter -= txtGHAMin_Enter;
                }

                _txtGHAMin = value;
                if (_txtGHAMin != null)
                {
                    _txtGHAMin.TextChanged += txtGHAMin_TextChanged;
                    _txtGHAMin.KeyPress += txtGHAMin_KeyPress;
                    _txtGHAMin.Validating += txtGHAMin_Validating;
                    _txtGHAMin.Enter += txtGHAMin_Enter;
                }
            }
        }

        private TextBox _txtHoDeg;

        public TextBox txtHoDeg
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtHoDeg;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtHoDeg != null)
                {
                    _txtHoDeg.TextChanged -= txtHoDeg_TextChanged;
                    _txtHoDeg.KeyPress -= txtHoDeg_KeyPress;
                    _txtHoDeg.Validating -= txtHoDeg_Validating;
                    _txtHoDeg.Enter -= txtHoDeg_Enter;
                }

                _txtHoDeg = value;
                if (_txtHoDeg != null)
                {
                    _txtHoDeg.TextChanged += txtHoDeg_TextChanged;
                    _txtHoDeg.KeyPress += txtHoDeg_KeyPress;
                    _txtHoDeg.Validating += txtHoDeg_Validating;
                    _txtHoDeg.Enter += txtHoDeg_Enter;
                }
            }
        }

        private TextBox _txtDecDeg;

        public TextBox txtDecDeg
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtDecDeg;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtDecDeg != null)
                {
                    _txtDecDeg.TextChanged -= txtDecDeg_TextChanged;
                    _txtDecDeg.KeyPress -= txtDecDeg_KeyPress;
                    _txtDecDeg.Validating -= txtDecDeg_Validating;
                    _txtDecDeg.Enter -= txtDecDeg_Enter;
                }

                _txtDecDeg = value;
                if (_txtDecDeg != null)
                {
                    _txtDecDeg.TextChanged += txtDecDeg_TextChanged;
                    _txtDecDeg.KeyPress += txtDecDeg_KeyPress;
                    _txtDecDeg.Validating += txtDecDeg_Validating;
                    _txtDecDeg.Enter += txtDecDeg_Enter;
                }
            }
        }

        private TextBox _txtGHADeg;

        public TextBox txtGHADeg
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtGHADeg;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtGHADeg != null)
                {
                    _txtGHADeg.TextChanged -= txtGHADeg_TextChanged;
                    _txtGHADeg.KeyPress -= txtGHADeg_KeyPress;
                    _txtGHADeg.Validating -= txtGHADeg_Validating;
                    _txtGHADeg.Enter -= txtGHADeg_Enter;
                }

                _txtGHADeg = value;
                if (_txtGHADeg != null)
                {
                    _txtGHADeg.TextChanged += txtGHADeg_TextChanged;
                    _txtGHADeg.KeyPress += txtGHADeg_KeyPress;
                    _txtGHADeg.Validating += txtGHADeg_Validating;
                    _txtGHADeg.Enter += txtGHADeg_Enter;
                }
            }
        }

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

        public ComboBox cboL;
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

        public Label Label6;
        // Public WithEvents Line5 As Microsoft.VisualBasic.PowerPacks.LineShape
        public Label Label5;
        public Label Label4;
        // Public WithEvents Line2 As Microsoft.VisualBasic.PowerPacks.LineShape
        // Public WithEvents Line1 As Microsoft.VisualBasic.PowerPacks.LineShape
        // Public WithEvents Line3 As Microsoft.VisualBasic.PowerPacks.LineShape
        public Label lblHoMin;
        public Label lblDecMin;
        public Label lblGHAMin;
        public Label lblHoDeg;
        public Label lblDecDeg;
        public Label lblGHADeg;
        public Label Label3;
        public Label Label2;
        public Label Label1;
        public Label lblDRL;
        public Label lblLDeg;
        public Label lblLMin;
        public Label lblDRLo;
        public Label lblLoDeg;
        public Label lblLoMin;
        // Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
        public GroupBox framePrecision;
        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAltSR));
            ToolTip1 = new ToolTip(components);
            _cmdPrint = new Button();
            _cmdPrint.Click += new EventHandler(cmdPrint_Click);
            _txtHoMin = new TextBox();
            _txtHoMin.TextChanged += new EventHandler(txtHoMin_TextChanged);
            _txtHoMin.KeyPress += new KeyPressEventHandler(txtHoMin_KeyPress);
            _txtHoMin.Validating += new System.ComponentModel.CancelEventHandler(txtHoMin_Validating);
            _txtHoMin.Enter += new EventHandler(txtHoMin_Enter);
            _txtDecMin = new TextBox();
            _txtDecMin.TextChanged += new EventHandler(txtDecMin_TextChanged);
            _txtDecMin.KeyPress += new KeyPressEventHandler(txtDecMin_KeyPress);
            _txtDecMin.Validating += new System.ComponentModel.CancelEventHandler(txtDecMin_Validating);
            _txtDecMin.Enter += new EventHandler(txtDecMin_Enter);
            _txtGHAMin = new TextBox();
            _txtGHAMin.TextChanged += new EventHandler(txtGHAMin_TextChanged);
            _txtGHAMin.KeyPress += new KeyPressEventHandler(txtGHAMin_KeyPress);
            _txtGHAMin.Validating += new System.ComponentModel.CancelEventHandler(txtGHAMin_Validating);
            _txtGHAMin.Enter += new EventHandler(txtGHAMin_Enter);
            _txtHoDeg = new TextBox();
            _txtHoDeg.TextChanged += new EventHandler(txtHoDeg_TextChanged);
            _txtHoDeg.KeyPress += new KeyPressEventHandler(txtHoDeg_KeyPress);
            _txtHoDeg.Validating += new System.ComponentModel.CancelEventHandler(txtHoDeg_Validating);
            _txtHoDeg.Enter += new EventHandler(txtHoDeg_Enter);
            _txtDecDeg = new TextBox();
            _txtDecDeg.TextChanged += new EventHandler(txtDecDeg_TextChanged);
            _txtDecDeg.KeyPress += new KeyPressEventHandler(txtDecDeg_KeyPress);
            _txtDecDeg.Validating += new System.ComponentModel.CancelEventHandler(txtDecDeg_Validating);
            _txtDecDeg.Enter += new EventHandler(txtDecDeg_Enter);
            _txtGHADeg = new TextBox();
            _txtGHADeg.TextChanged += new EventHandler(txtGHADeg_TextChanged);
            _txtGHADeg.KeyPress += new KeyPressEventHandler(txtGHADeg_KeyPress);
            _txtGHADeg.Validating += new System.ComponentModel.CancelEventHandler(txtGHADeg_Validating);
            _txtGHADeg.Enter += new EventHandler(txtGHADeg_Enter);
            _txtLMin = new TextBox();
            _txtLMin.TextChanged += new EventHandler(txtLMin_TextChanged);
            _txtLMin.KeyPress += new KeyPressEventHandler(txtLMin_KeyPress);
            _txtLMin.Validating += new System.ComponentModel.CancelEventHandler(txtLMin_Validating);
            _txtLMin.Enter += new EventHandler(txtLMin_Enter);
            _txtLoDeg = new TextBox();
            _txtLoDeg.TextChanged += new EventHandler(txtLoDeg_TextChanged);
            _txtLoDeg.KeyPress += new KeyPressEventHandler(txtLoDeg_KeyPress);
            _txtLoDeg.Validating += new System.ComponentModel.CancelEventHandler(txtLoDeg_Validating);
            _txtLoDeg.Enter += new EventHandler(txtLoDeg_Enter);
            _txtLoMin = new TextBox();
            _txtLoMin.TextChanged += new EventHandler(txtLoMin_TextChanged);
            _txtLoMin.KeyPress += new KeyPressEventHandler(txtLoMin_KeyPress);
            _txtLoMin.Validating += new System.ComponentModel.CancelEventHandler(txtLoMin_Validating);
            _txtLoMin.Enter += new EventHandler(txtLoMin_Enter);
            _txtLDeg = new TextBox();
            _txtLDeg.TextChanged += new EventHandler(txtLDeg_TextChanged);
            _txtLDeg.KeyPress += new KeyPressEventHandler(txtLDeg_KeyPress);
            _txtLDeg.Validating += new System.ComponentModel.CancelEventHandler(txtLDeg_Validating);
            _txtLDeg.Enter += new EventHandler(txtLDeg_Enter);
            _chkInterpolateB = new CheckBox();
            _chkInterpolateB.CheckStateChanged += new EventHandler(chkInterpolateB_CheckStateChanged);
            _cmdWeems = new Button();
            _cmdWeems.Click += new EventHandler(cmdWeems_Click);
            frameS = new GroupBox();
            _optFarley = new RadioButton();
            _optFarley.CheckedChanged += new EventHandler(optFarley_CheckedChanged);
            _optPepperday = new RadioButton();
            _optPepperday.CheckedChanged += new EventHandler(optPepperday_CheckedChanged);
            _cmdSTable = new Button();
            _cmdSTable.Click += new EventHandler(cmdSTable_Click);
            _chkSadler = new CheckBox();
            _chkSadler.CheckStateChanged += new EventHandler(chkSadler_CheckStateChanged);
            frame214 = new GroupBox();
            _optdtL = new RadioButton();
            _optdtL.CheckedChanged += new EventHandler(optdtL_CheckedChanged);
            _optdt = new RadioButton();
            _optdt.CheckedChanged += new EventHandler(optdt_CheckedChanged);
            _optd = new RadioButton();
            _optd.CheckedChanged += new EventHandler(optd_CheckedChanged);
            Label15 = new Label();
            Label14 = new Label();
            Label13 = new Label();
            Label12 = new Label();
            Label11 = new Label();
            Label10 = new Label();
            Label8 = new Label();
            Label7 = new Label();
            Label9 = new Label();
            _chkDSD = new CheckBox();
            _chkDSD.CheckStateChanged += new EventHandler(chkDSD_CheckStateChanged);
            frame211 = new GroupBox();
            _optCompact = new RadioButton();
            _optCompact.CheckedChanged += new EventHandler(optCompact_CheckedChanged);
            _optOriginal = new RadioButton();
            _optOriginal.CheckedChanged += new EventHandler(optOriginal_CheckedChanged);
            _cmd208 = new Button();
            _cmd208.Click += new EventHandler(cmd208_Click);
            _cmd211 = new Button();
            _cmd211.Click += new EventHandler(cmd211_Click);
            _cmd214 = new Button();
            _cmd214.Click += new EventHandler(cmd214_Click);
            _cmd229 = new Button();
            _cmd229.Click += new EventHandler(cmd229_Click);
            _cmd249 = new Button();
            _cmd249.Click += new EventHandler(cmd249_Click);
            _cmdClearSome = new Button();
            _cmdClearSome.Click += new EventHandler(cmdClearSome_Click);
            _cmdClear = new Button();
            _cmdClear.Click += new EventHandler(cmdClear_Click);
            _cmdFix = new Button();
            _cmdFix.Click += new EventHandler(cmdFix_Click);
            _cmdSave = new Button();
            _cmdSave.Click += new EventHandler(cmdSave_Click);
            frameNASRUsing = new GroupBox();
            _optNATable = new RadioButton();
            _optNATable.CheckedChanged += new EventHandler(optNATable_CheckedChanged);
            _optUSPSTable = new RadioButton();
            _optUSPSTable.CheckedChanged += new EventHandler(optUSPSTable_CheckedChanged);
            _cmdNASR = new Button();
            _cmdNASR.Click += new EventHandler(cmdNASR_Click);
            _cmdLawOfCosines = new Button();
            _cmdLawOfCosines.Click += new EventHandler(cmdLawOfCosines_Click);
            _cboDec = new ComboBox();
            _cboDec.SelectedIndexChanged += new EventHandler(CboDec_SelectedIndexChanged);
            cboL = new ComboBox();
            cboLo = new ComboBox();
            Label6 = new Label();
            Label5 = new Label();
            Label4 = new Label();
            lblHoMin = new Label();
            lblDecMin = new Label();
            lblGHAMin = new Label();
            lblHoDeg = new Label();
            lblDecDeg = new Label();
            lblGHADeg = new Label();
            Label3 = new Label();
            Label2 = new Label();
            Label1 = new Label();
            lblDRL = new Label();
            lblLDeg = new Label();
            lblLMin = new Label();
            lblDRLo = new Label();
            lblLoDeg = new Label();
            lblLoMin = new Label();
            SRLgTxtBx = new RichTextBox();
            _ExitBtn = new Button();
            _ExitBtn.Click += new EventHandler(ExitBtn_Click);
            SRHdrTxtBx = new RichTextBox();
            SRLeftTxtBx = new RichTextBox();
            SRRightTxtBx = new RichTextBox();
            NASRAsmTxtBx = new RichTextBox();
            NASRAFTxtBx = new RichTextBox();
            DCorrTxtBx = new RichTextBox();
            optFull = new RadioButton();
            GroupBoxPrecision = new GroupBox();
            optRound = new RadioButton();
            WeemsPVTxtBx = new TextBox();
            PictureBox1 = new PictureBox();
            DTSight = new DateTimePicker();
            lblDate = new Label();
            _btnUseCLS = new Button();
            _btnUseCLS.Click += new EventHandler(btnUseCLS_Click);
            _btnCustomPlot = new Button();
            _btnCustomPlot.Click += new EventHandler(btnCustomPlot_Click);
            _cmdMerDiag = new Button();
            _cmdMerDiag.Click += new EventHandler(cmdMerDiag_Click_1);
            txtUserInfo = new TextBox();
            Label16 = new Label();
            cboLLoBy = new ComboBox();
            Label17 = new Label();
            grpSLInfo = new GroupBox();
            lblBodyNm = new Label();
            lblLimb = new Label();
            cbLimb = new ComboBox();
            cboBody = new ComboBox();
            _btnNASRFix = new Button();
            _btnNASRFix.Click += new EventHandler(btnNASRFix_Click);
            frameS.SuspendLayout();
            frame214.SuspendLayout();
            frame211.SuspendLayout();
            frameNASRUsing.SuspendLayout();
            GroupBoxPrecision.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            grpSLInfo.SuspendLayout();
            SuspendLayout();
            // 
            // cmdPrint
            // 
            _cmdPrint.BackColor = SystemColors.Control;
            _cmdPrint.Cursor = Cursors.Default;
            _cmdPrint.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdPrint.ForeColor = SystemColors.ControlText;
            _cmdPrint.Image = (Image)resources.GetObject("cmdPrint.Image");
            _cmdPrint.Location = new Point(646, 2);
            _cmdPrint.Name = "_cmdPrint";
            _cmdPrint.RightToLeft = RightToLeft.No;
            _cmdPrint.Size = new Size(21, 21);
            _cmdPrint.TabIndex = 72;
            _cmdPrint.TextAlign = ContentAlignment.BottomCenter;
            ToolTip1.SetToolTip(_cmdPrint, "Print window");
            _cmdPrint.UseVisualStyleBackColor = false;
            // 
            // txtHoMin
            // 
            _txtHoMin.AcceptsReturn = true;
            _txtHoMin.BackColor = SystemColors.Window;
            _txtHoMin.Cursor = Cursors.IBeam;
            _txtHoMin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtHoMin.ForeColor = SystemColors.WindowText;
            _txtHoMin.Location = new Point(80, 58);
            _txtHoMin.MaxLength = 5;
            _txtHoMin.Name = "_txtHoMin";
            _txtHoMin.RightToLeft = RightToLeft.No;
            _txtHoMin.Size = new Size(33, 20);
            _txtHoMin.TabIndex = 6;
            ToolTip1.SetToolTip(_txtHoMin, "Range -59.9 to 59.9");
            // 
            // txtDecMin
            // 
            _txtDecMin.AcceptsReturn = true;
            _txtDecMin.BackColor = SystemColors.Window;
            _txtDecMin.Cursor = Cursors.IBeam;
            _txtDecMin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtDecMin.ForeColor = SystemColors.WindowText;
            _txtDecMin.Location = new Point(80, 34);
            _txtDecMin.MaxLength = 4;
            _txtDecMin.Name = "_txtDecMin";
            _txtDecMin.RightToLeft = RightToLeft.No;
            _txtDecMin.Size = new Size(33, 20);
            _txtDecMin.TabIndex = 3;
            ToolTip1.SetToolTip(_txtDecMin, "Range 0 to 59.9");
            // 
            // txtGHAMin
            // 
            _txtGHAMin.AcceptsReturn = true;
            _txtGHAMin.BackColor = SystemColors.Window;
            _txtGHAMin.Cursor = Cursors.IBeam;
            _txtGHAMin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtGHAMin.ForeColor = SystemColors.WindowText;
            _txtGHAMin.Location = new Point(80, 10);
            _txtGHAMin.MaxLength = 4;
            _txtGHAMin.Name = "_txtGHAMin";
            _txtGHAMin.RightToLeft = RightToLeft.No;
            _txtGHAMin.Size = new Size(33, 20);
            _txtGHAMin.TabIndex = 1;
            ToolTip1.SetToolTip(_txtGHAMin, "Range 0 to 59.9");
            // 
            // txtHoDeg
            // 
            _txtHoDeg.AcceptsReturn = true;
            _txtHoDeg.BackColor = SystemColors.Window;
            _txtHoDeg.Cursor = Cursors.IBeam;
            _txtHoDeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtHoDeg.ForeColor = SystemColors.WindowText;
            _txtHoDeg.Location = new Point(40, 58);
            _txtHoDeg.MaxLength = 2;
            _txtHoDeg.Name = "_txtHoDeg";
            _txtHoDeg.RightToLeft = RightToLeft.No;
            _txtHoDeg.Size = new Size(33, 20);
            _txtHoDeg.TabIndex = 5;
            ToolTip1.SetToolTip(_txtHoDeg, "Range 0 to 88 for LoC, 0 to 75 for NASR, 0 to 85 for 229, 0 to 90 for others");
            // 
            // txtDecDeg
            // 
            _txtDecDeg.AcceptsReturn = true;
            _txtDecDeg.BackColor = SystemColors.Window;
            _txtDecDeg.Cursor = Cursors.IBeam;
            _txtDecDeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtDecDeg.ForeColor = SystemColors.WindowText;
            _txtDecDeg.Location = new Point(40, 34);
            _txtDecDeg.MaxLength = 2;
            _txtDecDeg.Name = "_txtDecDeg";
            _txtDecDeg.RightToLeft = RightToLeft.No;
            _txtDecDeg.Size = new Size(33, 20);
            _txtDecDeg.TabIndex = 2;
            ToolTip1.SetToolTip(_txtDecDeg, "Range 0 to 90");
            // 
            // txtGHADeg
            // 
            _txtGHADeg.AcceptsReturn = true;
            _txtGHADeg.BackColor = SystemColors.Window;
            _txtGHADeg.Cursor = Cursors.IBeam;
            _txtGHADeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtGHADeg.ForeColor = SystemColors.WindowText;
            _txtGHADeg.Location = new Point(40, 10);
            _txtGHADeg.MaxLength = 3;
            _txtGHADeg.Name = "_txtGHADeg";
            _txtGHADeg.RightToLeft = RightToLeft.No;
            _txtGHADeg.Size = new Size(33, 20);
            _txtGHADeg.TabIndex = 0;
            ToolTip1.SetToolTip(_txtGHADeg, "Range 0 to 719");
            // 
            // txtLMin
            // 
            _txtLMin.AcceptsReturn = true;
            _txtLMin.BackColor = SystemColors.Window;
            _txtLMin.Cursor = Cursors.IBeam;
            _txtLMin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtLMin.ForeColor = SystemColors.WindowText;
            _txtLMin.Location = new Point(296, 8);
            _txtLMin.MaxLength = 4;
            _txtLMin.Name = "_txtLMin";
            _txtLMin.RightToLeft = RightToLeft.No;
            _txtLMin.Size = new Size(33, 20);
            _txtLMin.TabIndex = 8;
            ToolTip1.SetToolTip(_txtLMin, "Range 0 to 59.9");
            // 
            // txtLoDeg
            // 
            _txtLoDeg.AcceptsReturn = true;
            _txtLoDeg.BackColor = SystemColors.Window;
            _txtLoDeg.Cursor = Cursors.IBeam;
            _txtLoDeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtLoDeg.ForeColor = SystemColors.WindowText;
            _txtLoDeg.Location = new Point(256, 32);
            _txtLoDeg.MaxLength = 3;
            _txtLoDeg.Name = "_txtLoDeg";
            _txtLoDeg.RightToLeft = RightToLeft.No;
            _txtLoDeg.Size = new Size(33, 20);
            _txtLoDeg.TabIndex = 10;
            ToolTip1.SetToolTip(_txtLoDeg, "Range 0 to 180");
            // 
            // txtLoMin
            // 
            _txtLoMin.AcceptsReturn = true;
            _txtLoMin.BackColor = SystemColors.Window;
            _txtLoMin.Cursor = Cursors.IBeam;
            _txtLoMin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtLoMin.ForeColor = SystemColors.WindowText;
            _txtLoMin.Location = new Point(296, 32);
            _txtLoMin.MaxLength = 4;
            _txtLoMin.Name = "_txtLoMin";
            _txtLoMin.RightToLeft = RightToLeft.No;
            _txtLoMin.Size = new Size(33, 20);
            _txtLoMin.TabIndex = 11;
            ToolTip1.SetToolTip(_txtLoMin, "Range 0 to 59.9");
            // 
            // txtLDeg
            // 
            _txtLDeg.AcceptsReturn = true;
            _txtLDeg.BackColor = SystemColors.Window;
            _txtLDeg.Cursor = Cursors.IBeam;
            _txtLDeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtLDeg.ForeColor = SystemColors.WindowText;
            _txtLDeg.Location = new Point(256, 8);
            _txtLDeg.MaxLength = 2;
            _txtLDeg.Name = "_txtLDeg";
            _txtLDeg.RightToLeft = RightToLeft.No;
            _txtLDeg.Size = new Size(33, 20);
            _txtLDeg.TabIndex = 7;
            ToolTip1.SetToolTip(_txtLDeg, "Range 0 to 90");
            // 
            // chkInterpolateB
            // 
            _chkInterpolateB.BackColor = SystemColors.Window;
            _chkInterpolateB.Cursor = Cursors.Default;
            _chkInterpolateB.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _chkInterpolateB.ForeColor = SystemColors.ControlText;
            _chkInterpolateB.Location = new Point(7, 155);
            _chkInterpolateB.Name = "_chkInterpolateB";
            _chkInterpolateB.RightToLeft = RightToLeft.No;
            _chkInterpolateB.Size = new Size(190, 22);
            _chkInterpolateB.TabIndex = 66;
            _chkInterpolateB.Text = "Interpolate Table B (for Hc calc.)";
            _chkInterpolateB.UseVisualStyleBackColor = false;
            _chkInterpolateB.Visible = false;
            // 
            // cmdWeems
            // 
            _cmdWeems.BackColor = SystemColors.Control;
            _cmdWeems.Cursor = Cursors.Default;
            _cmdWeems.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdWeems.ForeColor = SystemColors.ControlText;
            _cmdWeems.Location = new Point(536, 120);
            _cmdWeems.Name = "_cmdWeems";
            _cmdWeems.RightToLeft = RightToLeft.No;
            _cmdWeems.Size = new Size(65, 22);
            _cmdWeems.TabIndex = 42;
            _cmdWeems.Text = "&Weems LPB";
            _cmdWeems.UseVisualStyleBackColor = false;
            // 
            // frameS
            // 
            frameS.BackColor = SystemColors.Window;
            frameS.Controls.Add(_optFarley);
            frameS.Controls.Add(_optPepperday);
            frameS.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            frameS.ForeColor = SystemColors.ControlText;
            frameS.Location = new Point(526, 145);
            frameS.Name = "frameS";
            frameS.Padding = new Padding(0);
            frameS.RightToLeft = RightToLeft.No;
            frameS.Size = new Size(140, 32);
            frameS.TabIndex = 63;
            frameS.TabStop = false;
            frameS.Text = "Version";
            frameS.Visible = false;
            // 
            // optFarley
            // 
            _optFarley.BackColor = SystemColors.Window;
            _optFarley.Cursor = Cursors.Default;
            _optFarley.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optFarley.ForeColor = SystemColors.ControlText;
            _optFarley.Location = new Point(83, 10);
            _optFarley.Name = "_optFarley";
            _optFarley.RightToLeft = RightToLeft.No;
            _optFarley.Size = new Size(57, 21);
            _optFarley.TabIndex = 65;
            _optFarley.TabStop = true;
            _optFarley.Text = "Farley";
            _optFarley.UseVisualStyleBackColor = false;
            // 
            // optPepperday
            // 
            _optPepperday.BackColor = SystemColors.Window;
            _optPepperday.Checked = true;
            _optPepperday.Cursor = Cursors.Default;
            _optPepperday.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optPepperday.ForeColor = SystemColors.ControlText;
            _optPepperday.Location = new Point(8, 11);
            _optPepperday.Name = "_optPepperday";
            _optPepperday.RightToLeft = RightToLeft.No;
            _optPepperday.Size = new Size(81, 18);
            _optPepperday.TabIndex = 64;
            _optPepperday.TabStop = true;
            _optPepperday.Text = "Pepperday";
            _optPepperday.UseVisualStyleBackColor = false;
            // 
            // cmdSTable
            // 
            _cmdSTable.BackColor = SystemColors.Control;
            _cmdSTable.Cursor = Cursors.Default;
            _cmdSTable.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdSTable.ForeColor = SystemColors.ControlText;
            _cmdSTable.Location = new Point(608, 120);
            _cmdSTable.Name = "_cmdSTable";
            _cmdSTable.RightToLeft = RightToLeft.No;
            _cmdSTable.Size = new Size(57, 22);
            _cmdSTable.TabIndex = 43;
            _cmdSTable.Text = "&S-Table";
            _cmdSTable.UseVisualStyleBackColor = false;
            // 
            // chkSadler
            // 
            _chkSadler.BackColor = SystemColors.Window;
            _chkSadler.Cursor = Cursors.Default;
            _chkSadler.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _chkSadler.ForeColor = SystemColors.ControlText;
            _chkSadler.Location = new Point(133, 501);
            _chkSadler.Name = "_chkSadler";
            _chkSadler.RightToLeft = RightToLeft.No;
            _chkSadler.Size = new Size(132, 17);
            _chkSadler.TabIndex = 62;
            _chkSadler.Text = "Use Sadler Technique";
            _chkSadler.UseVisualStyleBackColor = false;
            _chkSadler.Visible = false;
            // 
            // frame214
            // 
            frame214.BackColor = SystemColors.Window;
            frame214.Controls.Add(_optdtL);
            frame214.Controls.Add(_optdt);
            frame214.Controls.Add(_optd);
            frame214.Controls.Add(Label15);
            frame214.Controls.Add(Label14);
            frame214.Controls.Add(Label13);
            frame214.Controls.Add(Label12);
            frame214.Controls.Add(Label11);
            frame214.Controls.Add(Label10);
            frame214.Controls.Add(Label8);
            frame214.Controls.Add(Label7);
            frame214.Controls.Add(Label9);
            frame214.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            frame214.ForeColor = SystemColors.ControlText;
            frame214.Location = new Point(320, 145);
            frame214.Name = "frame214";
            frame214.Padding = new Padding(0);
            frame214.RightToLeft = RightToLeft.No;
            frame214.Size = new Size(201, 34);
            frame214.TabIndex = 49;
            frame214.TabStop = false;
            frame214.Text = "Solution using";
            frame214.Visible = false;
            // 
            // optdtL
            // 
            _optdtL.BackColor = SystemColors.Window;
            _optdtL.Cursor = Cursors.Default;
            _optdtL.Font = new Font("Symbol", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(2));
            _optdtL.ForeColor = SystemColors.ControlText;
            _optdtL.Location = new Point(120, 14);
            _optdtL.Name = "_optdtL";
            _optdtL.RightToLeft = RightToLeft.No;
            _optdtL.Size = new Size(25, 14);
            _optdtL.TabIndex = 53;
            _optdtL.TabStop = true;
            _optdtL.Text = "D";
            _optdtL.UseVisualStyleBackColor = false;
            // 
            // optdt
            // 
            _optdt.BackColor = SystemColors.Window;
            _optdt.Cursor = Cursors.Default;
            _optdt.Font = new Font("Symbol", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(2));
            _optdt.ForeColor = SystemColors.ControlText;
            _optdt.Location = new Point(56, 14);
            _optdt.Name = "_optdt";
            _optdt.RightToLeft = RightToLeft.No;
            _optdt.Size = new Size(25, 14);
            _optdt.TabIndex = 51;
            _optdt.TabStop = true;
            _optdt.Text = "D";
            _optdt.UseVisualStyleBackColor = false;
            // 
            // optd
            // 
            _optd.BackColor = SystemColors.Window;
            _optd.Checked = true;
            _optd.Cursor = Cursors.Default;
            _optd.Font = new Font("Symbol", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(2));
            _optd.ForeColor = SystemColors.ControlText;
            _optd.Location = new Point(8, 14);
            _optd.Name = "_optd";
            _optd.RightToLeft = RightToLeft.No;
            _optd.Size = new Size(25, 14);
            _optd.TabIndex = 50;
            _optd.TabStop = true;
            _optd.Text = "D";
            _optd.UseVisualStyleBackColor = false;
            // 
            // Label15
            // 
            Label15.BackColor = SystemColors.Window;
            Label15.Cursor = Cursors.Default;
            Label15.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label15.ForeColor = SystemColors.ControlText;
            Label15.Location = new Point(186, 14);
            Label15.Name = "Label15";
            Label15.RightToLeft = RightToLeft.No;
            Label15.Size = new Size(8, 17);
            Label15.TabIndex = 61;
            Label15.Text = "L";
            // 
            // Label14
            // 
            Label14.BackColor = SystemColors.Window;
            Label14.Cursor = Cursors.Default;
            Label14.Font = new Font("Symbol", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(2));
            Label14.ForeColor = SystemColors.ControlText;
            Label14.Location = new Point(176, 14);
            Label14.Name = "Label14";
            Label14.RightToLeft = RightToLeft.No;
            Label14.Size = new Size(8, 17);
            Label14.TabIndex = 60;
            Label14.Text = "D";
            // 
            // Label13
            // 
            Label13.BackColor = SystemColors.Window;
            Label13.Cursor = Cursors.Default;
            Label13.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label13.ForeColor = SystemColors.ControlText;
            Label13.Location = new Point(168, 14);
            Label13.Name = "Label13";
            Label13.RightToLeft = RightToLeft.No;
            Label13.Size = new Size(8, 17);
            Label13.TabIndex = 59;
            Label13.Text = "t,";
            // 
            // Label12
            // 
            Label12.BackColor = SystemColors.Window;
            Label12.Cursor = Cursors.Default;
            Label12.Font = new Font("Symbol", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(2));
            Label12.ForeColor = SystemColors.ControlText;
            Label12.Location = new Point(157, 14);
            Label12.Name = "Label12";
            Label12.RightToLeft = RightToLeft.No;
            Label12.Size = new Size(8, 17);
            Label12.TabIndex = 58;
            Label12.Text = "D";
            // 
            // Label11
            // 
            Label11.BackColor = SystemColors.Window;
            Label11.Cursor = Cursors.Default;
            Label11.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label11.ForeColor = SystemColors.ControlText;
            Label11.Location = new Point(147, 14);
            Label11.Name = "Label11";
            Label11.RightToLeft = RightToLeft.No;
            Label11.Size = new Size(8, 17);
            Label11.TabIndex = 57;
            Label11.Text = "d,";
            // 
            // Label10
            // 
            Label10.BackColor = SystemColors.Window;
            Label10.Cursor = Cursors.Default;
            Label10.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label10.ForeColor = SystemColors.ControlText;
            Label10.Location = new Point(104, 14);
            Label10.Name = "Label10";
            Label10.RightToLeft = RightToLeft.No;
            Label10.Size = new Size(5, 17);
            Label10.TabIndex = 56;
            Label10.Text = "t";
            // 
            // Label8
            // 
            Label8.BackColor = SystemColors.Window;
            Label8.Cursor = Cursors.Default;
            Label8.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label8.ForeColor = SystemColors.ControlText;
            Label8.Location = new Point(84, 14);
            Label8.Name = "Label8";
            Label8.RightToLeft = RightToLeft.No;
            Label8.Size = new Size(8, 14);
            Label8.TabIndex = 55;
            Label8.Text = "d,";
            // 
            // Label7
            // 
            Label7.BackColor = SystemColors.Window;
            Label7.Cursor = Cursors.Default;
            Label7.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label7.ForeColor = SystemColors.ControlText;
            Label7.Location = new Point(35, 14);
            Label7.Name = "Label7";
            Label7.RightToLeft = RightToLeft.No;
            Label7.Size = new Size(5, 14);
            Label7.TabIndex = 54;
            Label7.Text = "d";
            // 
            // Label9
            // 
            Label9.BackColor = SystemColors.Window;
            Label9.Cursor = Cursors.Default;
            Label9.Font = new Font("Symbol", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(2));
            Label9.ForeColor = SystemColors.ControlText;
            Label9.Location = new Point(94, 14);
            Label9.Name = "Label9";
            Label9.RightToLeft = RightToLeft.No;
            Label9.Size = new Size(8, 17);
            Label9.TabIndex = 52;
            Label9.Text = "D";
            Label9.Visible = false;
            // 
            // chkDSD
            // 
            _chkDSD.BackColor = SystemColors.Window;
            _chkDSD.Cursor = Cursors.Default;
            _chkDSD.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _chkDSD.ForeColor = SystemColors.ControlText;
            _chkDSD.Location = new Point(204, 157);
            _chkDSD.Name = "_chkDSD";
            _chkDSD.RightToLeft = RightToLeft.No;
            _chkDSD.Size = new Size(117, 19);
            _chkDSD.TabIndex = 47;
            _chkDSD.Text = "Always use DSD";
            _chkDSD.UseVisualStyleBackColor = false;
            _chkDSD.Visible = false;
            // 
            // frame211
            // 
            frame211.BackColor = SystemColors.Window;
            frame211.Controls.Add(_optCompact);
            frame211.Controls.Add(_optOriginal);
            frame211.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            frame211.ForeColor = SystemColors.ControlText;
            frame211.Location = new Point(528, 145);
            frame211.Name = "frame211";
            frame211.Padding = new Padding(0);
            frame211.RightToLeft = RightToLeft.No;
            frame211.Size = new Size(137, 34);
            frame211.TabIndex = 44;
            frame211.TabStop = false;
            frame211.Text = "Version";
            frame211.Visible = false;
            // 
            // optCompact
            // 
            _optCompact.BackColor = SystemColors.Window;
            _optCompact.Checked = true;
            _optCompact.Cursor = Cursors.Default;
            _optCompact.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optCompact.ForeColor = SystemColors.ControlText;
            _optCompact.Location = new Point(4, 14);
            _optCompact.Name = "_optCompact";
            _optCompact.RightToLeft = RightToLeft.No;
            _optCompact.Size = new Size(67, 17);
            _optCompact.TabIndex = 46;
            _optCompact.TabStop = true;
            _optCompact.Text = "Compact";
            _optCompact.UseVisualStyleBackColor = false;
            // 
            // optOriginal
            // 
            _optOriginal.BackColor = SystemColors.Window;
            _optOriginal.Cursor = Cursors.Default;
            _optOriginal.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optOriginal.ForeColor = SystemColors.ControlText;
            _optOriginal.Location = new Point(72, 14);
            _optOriginal.Name = "_optOriginal";
            _optOriginal.RightToLeft = RightToLeft.No;
            _optOriginal.Size = new Size(61, 17);
            _optOriginal.TabIndex = 45;
            _optOriginal.TabStop = true;
            _optOriginal.Text = "Original";
            _optOriginal.UseVisualStyleBackColor = false;
            // 
            // cmd208
            // 
            _cmd208.BackColor = SystemColors.Control;
            _cmd208.Cursor = Cursors.Default;
            _cmd208.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmd208.ForeColor = SystemColors.ControlText;
            _cmd208.Location = new Point(608, 88);
            _cmd208.Name = "_cmd208";
            _cmd208.RightToLeft = RightToLeft.No;
            _cmd208.Size = new Size(57, 25);
            _cmd208.TabIndex = 41;
            _cmd208.Text = "H.O. 20&8";
            _cmd208.UseVisualStyleBackColor = false;
            // 
            // cmd211
            // 
            _cmd211.BackColor = SystemColors.Control;
            _cmd211.Cursor = Cursors.Default;
            _cmd211.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmd211.ForeColor = SystemColors.ControlText;
            _cmd211.Location = new Point(608, 56);
            _cmd211.Name = "_cmd211";
            _cmd211.RightToLeft = RightToLeft.No;
            _cmd211.Size = new Size(57, 25);
            _cmd211.TabIndex = 40;
            _cmd211.Text = "H.O. 21&1";
            _cmd211.UseVisualStyleBackColor = false;
            // 
            // cmd214
            // 
            _cmd214.BackColor = SystemColors.Control;
            _cmd214.Cursor = Cursors.Default;
            _cmd214.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmd214.ForeColor = SystemColors.ControlText;
            _cmd214.Location = new Point(536, 88);
            _cmd214.Name = "_cmd214";
            _cmd214.RightToLeft = RightToLeft.No;
            _cmd214.Size = new Size(65, 25);
            _cmd214.TabIndex = 39;
            _cmd214.Text = "H.O. 21&4";
            _cmd214.UseVisualStyleBackColor = false;
            // 
            // cmd229
            // 
            _cmd229.BackColor = SystemColors.Control;
            _cmd229.Cursor = Cursors.Default;
            _cmd229.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmd229.ForeColor = SystemColors.ControlText;
            _cmd229.Location = new Point(536, 56);
            _cmd229.Name = "_cmd229";
            _cmd229.RightToLeft = RightToLeft.No;
            _cmd229.Size = new Size(65, 25);
            _cmd229.TabIndex = 38;
            _cmd229.Text = "Pub. 22&9";
            _cmd229.UseVisualStyleBackColor = false;
            // 
            // cmd249
            // 
            _cmd249.BackColor = SystemColors.Control;
            _cmd249.Cursor = Cursors.Default;
            _cmd249.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmd249.ForeColor = SystemColors.ControlText;
            _cmd249.Location = new Point(536, 24);
            _cmd249.Name = "_cmd249";
            _cmd249.RightToLeft = RightToLeft.No;
            _cmd249.Size = new Size(128, 25);
            _cmd249.TabIndex = 37;
            _cmd249.Text = "Pub. &249 Vol. 2 && 3";
            _cmd249.UseVisualStyleBackColor = false;
            // 
            // cmdClearSome
            // 
            _cmdClearSome.BackColor = SystemColors.Control;
            _cmdClearSome.Cursor = Cursors.Default;
            _cmdClearSome.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdClearSome.ForeColor = SystemColors.ControlText;
            _cmdClearSome.Location = new Point(90, 467);
            _cmdClearSome.Name = "_cmdClearSome";
            _cmdClearSome.RightToLeft = RightToLeft.No;
            _cmdClearSome.Size = new Size(97, 25);
            _cmdClearSome.TabIndex = 70;
            _cmdClearSome.Text = "&Clear except DR";
            _cmdClearSome.UseVisualStyleBackColor = false;
            // 
            // cmdClear
            // 
            _cmdClear.BackColor = SystemColors.Control;
            _cmdClear.Cursor = Cursors.Default;
            _cmdClear.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdClear.ForeColor = SystemColors.ControlText;
            _cmdClear.Location = new Point(3, 468);
            _cmdClear.Name = "_cmdClear";
            _cmdClear.RightToLeft = RightToLeft.No;
            _cmdClear.Size = new Size(81, 25);
            _cmdClear.TabIndex = 71;
            _cmdClear.Text = "Clear &All";
            _cmdClear.UseVisualStyleBackColor = false;
            // 
            // cmdFix
            // 
            _cmdFix.BackColor = SystemColors.Control;
            _cmdFix.Cursor = Cursors.Default;
            _cmdFix.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdFix.ForeColor = SystemColors.ControlText;
            _cmdFix.Location = new Point(2, 497);
            _cmdFix.Name = "_cmdFix";
            _cmdFix.RightToLeft = RightToLeft.No;
            _cmdFix.Size = new Size(111, 25);
            _cmdFix.TabIndex = 68;
            _cmdFix.Text = "&Establish Fix";
            _cmdFix.UseVisualStyleBackColor = false;
            _cmdFix.Visible = false;
            // 
            // cmdSave
            // 
            _cmdSave.BackColor = SystemColors.Control;
            _cmdSave.Cursor = Cursors.Default;
            _cmdSave.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdSave.ForeColor = SystemColors.ControlText;
            _cmdSave.Location = new Point(3, 525);
            _cmdSave.Name = "_cmdSave";
            _cmdSave.RightToLeft = RightToLeft.No;
            _cmdSave.Size = new Size(110, 25);
            _cmdSave.TabIndex = 67;
            _cmdSave.Text = "Save for LOC Fix";
            _cmdSave.UseVisualStyleBackColor = false;
            _cmdSave.Visible = false;
            // 
            // frameNASRUsing
            // 
            frameNASRUsing.BackColor = SystemColors.Window;
            frameNASRUsing.Controls.Add(_optNATable);
            frameNASRUsing.Controls.Add(_optUSPSTable);
            frameNASRUsing.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            frameNASRUsing.ForeColor = SystemColors.ControlText;
            frameNASRUsing.Location = new Point(8, 398);
            frameNASRUsing.Name = "frameNASRUsing";
            frameNASRUsing.Padding = new Padding(0);
            frameNASRUsing.RightToLeft = RightToLeft.No;
            frameNASRUsing.Size = new Size(171, 57);
            frameNASRUsing.TabIndex = 31;
            frameNASRUsing.TabStop = false;
            frameNASRUsing.Text = "Use Auxiliary Table from";
            frameNASRUsing.Visible = false;
            // 
            // optNATable
            // 
            _optNATable.BackColor = SystemColors.Window;
            _optNATable.Checked = true;
            _optNATable.Cursor = Cursors.Default;
            _optNATable.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optNATable.ForeColor = SystemColors.ControlText;
            _optNATable.Location = new Point(8, 16);
            _optNATable.Name = "_optNATable";
            _optNATable.RightToLeft = RightToLeft.No;
            _optNATable.Size = new Size(164, 17);
            _optNATable.TabIndex = 33;
            _optNATable.TabStop = true;
            _optNATable.Text = "Pre-1999/post-2004 Almanac ";
            _optNATable.UseVisualStyleBackColor = false;
            // 
            // optUSPSTable
            // 
            _optUSPSTable.BackColor = SystemColors.Window;
            _optUSPSTable.Cursor = Cursors.Default;
            _optUSPSTable.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optUSPSTable.ForeColor = SystemColors.ControlText;
            _optUSPSTable.Location = new Point(8, 32);
            _optUSPSTable.Name = "_optUSPSTable";
            _optUSPSTable.RightToLeft = RightToLeft.No;
            _optUSPSTable.Size = new Size(120, 17);
            _optUSPSTable.TabIndex = 32;
            _optUSPSTable.TabStop = true;
            _optUSPSTable.Text = "1999-2004 Almanac";
            _optUSPSTable.UseVisualStyleBackColor = false;
            // 
            // cmdNASR
            // 
            _cmdNASR.BackColor = SystemColors.Control;
            _cmdNASR.Cursor = Cursors.Default;
            _cmdNASR.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdNASR.ForeColor = SystemColors.ControlText;
            _cmdNASR.Location = new Point(424, 52);
            _cmdNASR.Name = "_cmdNASR";
            _cmdNASR.RightToLeft = RightToLeft.No;
            _cmdNASR.Size = new Size(97, 25);
            _cmdNASR.TabIndex = 30;
            _cmdNASR.Text = "&NASR";
            _cmdNASR.UseVisualStyleBackColor = false;
            // 
            // cmdLawOfCosines
            // 
            _cmdLawOfCosines.BackColor = SystemColors.Control;
            _cmdLawOfCosines.Cursor = Cursors.Default;
            _cmdLawOfCosines.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdLawOfCosines.ForeColor = SystemColors.ControlText;
            _cmdLawOfCosines.Location = new Point(424, 24);
            _cmdLawOfCosines.Name = "_cmdLawOfCosines";
            _cmdLawOfCosines.RightToLeft = RightToLeft.No;
            _cmdLawOfCosines.Size = new Size(97, 25);
            _cmdLawOfCosines.TabIndex = 29;
            _cmdLawOfCosines.Text = "&Law of Cosines";
            _cmdLawOfCosines.UseVisualStyleBackColor = false;
            // 
            // cboDec
            // 
            _cboDec.BackColor = SystemColors.Window;
            _cboDec.Cursor = Cursors.Default;
            _cboDec.DropDownStyle = ComboBoxStyle.DropDownList;
            _cboDec.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboDec.ForeColor = SystemColors.WindowText;
            _cboDec.Items.AddRange(new object[] { "N", "S" });
            _cboDec.Location = new Point(120, 34);
            _cboDec.Name = "_cboDec";
            _cboDec.RightToLeft = RightToLeft.No;
            _cboDec.Size = new Size(41, 22);
            _cboDec.TabIndex = 4;
            // 
            // cboL
            // 
            cboL.BackColor = SystemColors.Window;
            cboL.Cursor = Cursors.Default;
            cboL.DropDownStyle = ComboBoxStyle.DropDownList;
            cboL.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboL.ForeColor = SystemColors.WindowText;
            cboL.Items.AddRange(new object[] { "N", "S" });
            cboL.Location = new Point(336, 8);
            cboL.Name = "cboL";
            cboL.RightToLeft = RightToLeft.No;
            cboL.Size = new Size(41, 22);
            cboL.TabIndex = 9;
            // 
            // cboLo
            // 
            cboLo.BackColor = SystemColors.Window;
            cboLo.Cursor = Cursors.Default;
            cboLo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLo.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboLo.ForeColor = SystemColors.WindowText;
            cboLo.Items.AddRange(new object[] { "W", "E" });
            cboLo.Location = new Point(336, 31);
            cboLo.Name = "cboLo";
            cboLo.RightToLeft = RightToLeft.No;
            cboLo.Size = new Size(41, 22);
            cboLo.TabIndex = 12;
            // 
            // Label6
            // 
            Label6.BackColor = SystemColors.Window;
            Label6.Cursor = Cursors.Default;
            Label6.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label6.ForeColor = SystemColors.ControlText;
            Label6.Location = new Point(427, 6);
            Label6.Name = "Label6";
            Label6.RightToLeft = RightToLeft.No;
            Label6.Size = new Size(213, 17);
            Label6.TabIndex = 48;
            Label6.Text = "Select Sight Reduction Method";
            Label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label5
            // 
            Label5.BackColor = SystemColors.Window;
            Label5.BorderStyle = BorderStyle.FixedSingle;
            Label5.Cursor = Cursors.Default;
            Label5.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label5.ForeColor = SystemColors.ControlText;
            Label5.Location = new Point(8, 81);
            Label5.Name = "Label5";
            Label5.RightToLeft = RightToLeft.No;
            Label5.Size = new Size(281, 34);
            Label5.TabIndex = 36;
            Label5.Text = "To use LHA instead of GHA, enter LHA  in place of GHA and set DR Lo to zero or le" + "ave blank.";
            Label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label4
            // 
            Label4.BackColor = SystemColors.Window;
            Label4.BorderStyle = BorderStyle.FixedSingle;
            Label4.Cursor = Cursors.Default;
            Label4.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.ForeColor = SystemColors.ControlText;
            Label4.Location = new Point(290, 81);
            Label4.Name = "Label4";
            Label4.RightToLeft = RightToLeft.No;
            Label4.Size = new Size(231, 34);
            Label4.TabIndex = 35;
            Label4.Text = "Time is only required for establishing a fix from a moving vessel using Law of Co" + "sines.";
            // 
            // lblHoMin
            // 
            lblHoMin.BackColor = SystemColors.Window;
            lblHoMin.Cursor = Cursors.Default;
            lblHoMin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblHoMin.ForeColor = SystemColors.ControlText;
            lblHoMin.Location = new Point(113, 58);
            lblHoMin.Name = "lblHoMin";
            lblHoMin.RightToLeft = RightToLeft.No;
            lblHoMin.Size = new Size(9, 17);
            lblHoMin.TabIndex = 28;
            lblHoMin.Text = "'";
            // 
            // lblDecMin
            // 
            lblDecMin.BackColor = SystemColors.Window;
            lblDecMin.Cursor = Cursors.Default;
            lblDecMin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblDecMin.ForeColor = SystemColors.ControlText;
            lblDecMin.Location = new Point(113, 34);
            lblDecMin.Name = "lblDecMin";
            lblDecMin.RightToLeft = RightToLeft.No;
            lblDecMin.Size = new Size(9, 17);
            lblDecMin.TabIndex = 27;
            lblDecMin.Text = "'";
            // 
            // lblGHAMin
            // 
            lblGHAMin.BackColor = SystemColors.Window;
            lblGHAMin.Cursor = Cursors.Default;
            lblGHAMin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblGHAMin.ForeColor = SystemColors.ControlText;
            lblGHAMin.Location = new Point(113, 10);
            lblGHAMin.Name = "lblGHAMin";
            lblGHAMin.RightToLeft = RightToLeft.No;
            lblGHAMin.Size = new Size(9, 17);
            lblGHAMin.TabIndex = 26;
            lblGHAMin.Text = "'";
            // 
            // lblHoDeg
            // 
            lblHoDeg.BackColor = SystemColors.Window;
            lblHoDeg.Cursor = Cursors.Default;
            lblHoDeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblHoDeg.ForeColor = SystemColors.ControlText;
            lblHoDeg.Location = new Point(73, 58);
            lblHoDeg.Name = "lblHoDeg";
            lblHoDeg.RightToLeft = RightToLeft.No;
            lblHoDeg.Size = new Size(9, 17);
            lblHoDeg.TabIndex = 25;
            lblHoDeg.Text = "°";
            // 
            // lblDecDeg
            // 
            lblDecDeg.BackColor = SystemColors.Window;
            lblDecDeg.Cursor = Cursors.Default;
            lblDecDeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblDecDeg.ForeColor = SystemColors.ControlText;
            lblDecDeg.Location = new Point(73, 34);
            lblDecDeg.Name = "lblDecDeg";
            lblDecDeg.RightToLeft = RightToLeft.No;
            lblDecDeg.Size = new Size(9, 17);
            lblDecDeg.TabIndex = 24;
            lblDecDeg.Text = "°";
            // 
            // lblGHADeg
            // 
            lblGHADeg.BackColor = SystemColors.Window;
            lblGHADeg.Cursor = Cursors.Default;
            lblGHADeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblGHADeg.ForeColor = SystemColors.ControlText;
            lblGHADeg.Location = new Point(73, 10);
            lblGHADeg.Name = "lblGHADeg";
            lblGHADeg.RightToLeft = RightToLeft.No;
            lblGHADeg.Size = new Size(9, 17);
            lblGHADeg.TabIndex = 23;
            lblGHADeg.Text = "°";
            // 
            // Label3
            // 
            Label3.BackColor = SystemColors.Window;
            Label3.Cursor = Cursors.Default;
            Label3.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.ForeColor = SystemColors.ControlText;
            Label3.Location = new Point(8, 59);
            Label3.Name = "Label3";
            Label3.RightToLeft = RightToLeft.No;
            Label3.Size = new Size(25, 17);
            Label3.TabIndex = 22;
            Label3.Text = "Ho";
            // 
            // Label2
            // 
            Label2.BackColor = SystemColors.Window;
            Label2.Cursor = Cursors.Default;
            Label2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = SystemColors.ControlText;
            Label2.Location = new Point(7, 36);
            Label2.Name = "Label2";
            Label2.RightToLeft = RightToLeft.No;
            Label2.Size = new Size(33, 17);
            Label2.TabIndex = 21;
            Label2.Text = "Dec";
            // 
            // Label1
            // 
            Label1.BackColor = SystemColors.Window;
            Label1.Cursor = Cursors.Default;
            Label1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = SystemColors.ControlText;
            Label1.Location = new Point(7, 12);
            Label1.Name = "Label1";
            Label1.RightToLeft = RightToLeft.No;
            Label1.Size = new Size(33, 17);
            Label1.TabIndex = 20;
            Label1.Text = "GHA";
            // 
            // lblDRL
            // 
            lblDRL.BackColor = SystemColors.Window;
            lblDRL.Cursor = Cursors.Default;
            lblDRL.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblDRL.ForeColor = SystemColors.ControlText;
            lblDRL.Location = new Point(216, 8);
            lblDRL.Name = "lblDRL";
            lblDRL.RightToLeft = RightToLeft.No;
            lblDRL.Size = new Size(32, 17);
            lblDRL.TabIndex = 19;
            lblDRL.Text = "DR L";
            // 
            // lblLDeg
            // 
            lblLDeg.BackColor = SystemColors.Window;
            lblLDeg.Cursor = Cursors.Default;
            lblLDeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLDeg.ForeColor = SystemColors.ControlText;
            lblLDeg.Location = new Point(289, 8);
            lblLDeg.Name = "lblLDeg";
            lblLDeg.RightToLeft = RightToLeft.No;
            lblLDeg.Size = new Size(9, 17);
            lblLDeg.TabIndex = 18;
            lblLDeg.Text = "°";
            // 
            // lblLMin
            // 
            lblLMin.BackColor = SystemColors.Window;
            lblLMin.Cursor = Cursors.Default;
            lblLMin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLMin.ForeColor = SystemColors.ControlText;
            lblLMin.Location = new Point(329, 8);
            lblLMin.Name = "lblLMin";
            lblLMin.RightToLeft = RightToLeft.No;
            lblLMin.Size = new Size(9, 17);
            lblLMin.TabIndex = 17;
            lblLMin.Text = "'";
            // 
            // lblDRLo
            // 
            lblDRLo.BackColor = SystemColors.Window;
            lblDRLo.Cursor = Cursors.Default;
            lblDRLo.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblDRLo.ForeColor = SystemColors.ControlText;
            lblDRLo.Location = new Point(216, 32);
            lblDRLo.Name = "lblDRLo";
            lblDRLo.RightToLeft = RightToLeft.No;
            lblDRLo.Size = new Size(36, 17);
            lblDRLo.TabIndex = 16;
            lblDRLo.Text = "DR Lo";
            // 
            // lblLoDeg
            // 
            lblLoDeg.BackColor = SystemColors.Window;
            lblLoDeg.Cursor = Cursors.Default;
            lblLoDeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLoDeg.ForeColor = SystemColors.ControlText;
            lblLoDeg.Location = new Point(289, 32);
            lblLoDeg.Name = "lblLoDeg";
            lblLoDeg.RightToLeft = RightToLeft.No;
            lblLoDeg.Size = new Size(9, 17);
            lblLoDeg.TabIndex = 15;
            lblLoDeg.Text = "°";
            // 
            // lblLoMin
            // 
            lblLoMin.BackColor = SystemColors.Window;
            lblLoMin.Cursor = Cursors.Default;
            lblLoMin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLoMin.ForeColor = SystemColors.ControlText;
            lblLoMin.Location = new Point(329, 32);
            lblLoMin.Name = "lblLoMin";
            lblLoMin.RightToLeft = RightToLeft.No;
            lblLoMin.Size = new Size(9, 17);
            lblLoMin.TabIndex = 14;
            lblLoMin.Text = "'";
            // 
            // SRLgTxtBx
            // 
            SRLgTxtBx.Font = new Font("Courier New", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            SRLgTxtBx.Location = new Point(2, 207);
            SRLgTxtBx.Name = "SRLgTxtBx";
            SRLgTxtBx.ReadOnly = true;
            SRLgTxtBx.Size = new Size(669, 258);
            SRLgTxtBx.TabIndex = 74;
            SRLgTxtBx.Text = "";
            // 
            // ExitBtn
            // 
            _ExitBtn.BackColor = Color.Red;
            _ExitBtn.Cursor = Cursors.Default;
            _ExitBtn.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _ExitBtn.ForeColor = SystemColors.ControlLightLight;
            _ExitBtn.Location = new Point(591, 468);
            _ExitBtn.Name = "_ExitBtn";
            _ExitBtn.RightToLeft = RightToLeft.No;
            _ExitBtn.Size = new Size(70, 25);
            _ExitBtn.TabIndex = 75;
            _ExitBtn.Text = "Exit";
            _ExitBtn.UseVisualStyleBackColor = false;
            // 
            // SRHdrTxtBx
            // 
            SRHdrTxtBx.Font = new Font("Courier New", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            SRHdrTxtBx.Location = new Point(1, 180);
            SRHdrTxtBx.Name = "SRHdrTxtBx";
            SRHdrTxtBx.ReadOnly = true;
            SRHdrTxtBx.Size = new Size(671, 24);
            SRHdrTxtBx.TabIndex = 76;
            SRHdrTxtBx.Text = "";
            // 
            // SRLeftTxtBx
            // 
            SRLeftTxtBx.Font = new Font("Courier New", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            SRLeftTxtBx.Location = new Point(1, 207);
            SRLeftTxtBx.Name = "SRLeftTxtBx";
            SRLeftTxtBx.ReadOnly = true;
            SRLeftTxtBx.Size = new Size(184, 255);
            SRLeftTxtBx.TabIndex = 77;
            SRLeftTxtBx.Text = "";
            // 
            // SRRightTxtBx
            // 
            SRRightTxtBx.Font = new Font("Courier New", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            SRRightTxtBx.Location = new Point(183, 207);
            SRRightTxtBx.Name = "SRRightTxtBx";
            SRRightTxtBx.ReadOnly = true;
            SRRightTxtBx.Size = new Size(489, 255);
            SRRightTxtBx.TabIndex = 78;
            SRRightTxtBx.Text = "";
            // 
            // NASRAsmTxtBx
            // 
            NASRAsmTxtBx.Font = new Font("Courier New", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            NASRAsmTxtBx.Location = new Point(315, 214);
            NASRAsmTxtBx.Name = "NASRAsmTxtBx";
            NASRAsmTxtBx.ReadOnly = true;
            NASRAsmTxtBx.Size = new Size(230, 22);
            NASRAsmTxtBx.TabIndex = 79;
            NASRAsmTxtBx.Text = "";
            NASRAsmTxtBx.Visible = false;
            // 
            // NASRAFTxtBx
            // 
            NASRAFTxtBx.Font = new Font("Courier New", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            NASRAFTxtBx.Location = new Point(332, 279);
            NASRAFTxtBx.Name = "NASRAFTxtBx";
            NASRAFTxtBx.ReadOnly = true;
            NASRAFTxtBx.Size = new Size(193, 22);
            NASRAFTxtBx.TabIndex = 80;
            NASRAFTxtBx.Text = "";
            NASRAFTxtBx.Visible = false;
            // 
            // DCorrTxtBx
            // 
            DCorrTxtBx.Font = new Font("Courier New", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DCorrTxtBx.Location = new Point(191, 302);
            DCorrTxtBx.Name = "DCorrTxtBx";
            DCorrTxtBx.ReadOnly = true;
            DCorrTxtBx.Size = new Size(259, 37);
            DCorrTxtBx.TabIndex = 81;
            DCorrTxtBx.Text = "";
            DCorrTxtBx.Visible = false;
            // 
            // optFull
            // 
            optFull.AutoSize = true;
            optFull.Checked = true;
            optFull.Location = new Point(6, 20);
            optFull.Name = "optFull";
            optFull.Size = new Size(41, 17);
            optFull.TabIndex = 82;
            optFull.TabStop = true;
            optFull.Text = "Full";
            optFull.UseVisualStyleBackColor = true;
            // 
            // GroupBoxPrecision
            // 
            GroupBoxPrecision.Controls.Add(optRound);
            GroupBoxPrecision.Controls.Add(optFull);
            GroupBoxPrecision.Location = new Point(16, 231);
            GroupBoxPrecision.Name = "GroupBoxPrecision";
            GroupBoxPrecision.Size = new Size(232, 38);
            GroupBoxPrecision.TabIndex = 83;
            GroupBoxPrecision.TabStop = false;
            GroupBoxPrecision.Text = "Precision to use for subsequent calculations";
            GroupBoxPrecision.Visible = false;
            // 
            // optRound
            // 
            optRound.AutoSize = true;
            optRound.Location = new Point(54, 20);
            optRound.Name = "optRound";
            optRound.Size = new Size(173, 17);
            optRound.TabIndex = 83;
            optRound.TabStop = true;
            optRound.Text = "Rounded to five decimal places";
            optRound.UseVisualStyleBackColor = true;
            // 
            // WeemsPVTxtBx
            // 
            WeemsPVTxtBx.Location = new Point(191, 409);
            WeemsPVTxtBx.Multiline = true;
            WeemsPVTxtBx.Name = "WeemsPVTxtBx";
            WeemsPVTxtBx.Size = new Size(267, 50);
            WeemsPVTxtBx.TabIndex = 84;
            WeemsPVTxtBx.Visible = false;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.ABC_white;
            PictureBox1.Location = new Point(132, 525);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(413, 50);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 102;
            PictureBox1.TabStop = false;
            // 
            // DTSight
            // 
            DTSight.CustomFormat = "MM / dd / yyyy HH:mm:ss ";
            DTSight.DropDownAlign = LeftRightAlignment.Right;
            DTSight.Format = DateTimePickerFormat.Custom;
            DTSight.Location = new Point(254, 58);
            DTSight.Name = "DTSight";
            DTSight.ShowUpDown = true;
            DTSight.Size = new Size(146, 21);
            DTSight.TabIndex = 126;
            // 
            // lblDate
            // 
            lblDate.BackColor = SystemColors.Window;
            lblDate.Cursor = Cursors.Default;
            lblDate.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblDate.ForeColor = SystemColors.ControlText;
            lblDate.Location = new Point(167, 58);
            lblDate.Name = "lblDate";
            lblDate.RightToLeft = RightToLeft.No;
            lblDate.Size = new Size(85, 22);
            lblDate.TabIndex = 125;
            lblDate.Text = "Sight Date/Time";
            lblDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnUseCLS
            // 
            _btnUseCLS.BackColor = Color.Yellow;
            _btnUseCLS.Font = new Font("Arial Narrow", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnUseCLS.ForeColor = SystemColors.WindowText;
            _btnUseCLS.Location = new Point(564, 502);
            _btnUseCLS.Name = "_btnUseCLS";
            _btnUseCLS.Size = new Size(100, 23);
            _btnUseCLS.TabIndex = 174;
            _btnUseCLS.Text = "CLS Form Plot";
            _btnUseCLS.UseVisualStyleBackColor = false;
            _btnUseCLS.Visible = false;
            // 
            // btnCustomPlot
            // 
            _btnCustomPlot.BackColor = Color.Yellow;
            _btnCustomPlot.Font = new Font("Arial Narrow", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnCustomPlot.ForeColor = SystemColors.WindowText;
            _btnCustomPlot.Location = new Point(564, 528);
            _btnCustomPlot.Name = "_btnCustomPlot";
            _btnCustomPlot.Size = new Size(100, 23);
            _btnCustomPlot.TabIndex = 175;
            _btnCustomPlot.Text = "Custom Plot Form";
            _btnCustomPlot.UseVisualStyleBackColor = false;
            _btnCustomPlot.Visible = false;
            // 
            // cmdMerDiag
            // 
            _cmdMerDiag.BackColor = Color.Yellow;
            _cmdMerDiag.Font = new Font("Arial Narrow", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdMerDiag.ForeColor = SystemColors.WindowText;
            _cmdMerDiag.Location = new Point(564, 553);
            _cmdMerDiag.Name = "_cmdMerDiag";
            _cmdMerDiag.Size = new Size(100, 23);
            _cmdMerDiag.TabIndex = 177;
            _cmdMerDiag.Text = "Meridian Diagram";
            _cmdMerDiag.UseVisualStyleBackColor = false;
            _cmdMerDiag.Visible = false;
            // 
            // txtUserInfo
            // 
            txtUserInfo.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtUserInfo.HideSelection = false;
            txtUserInfo.Location = new Point(250, 469);
            txtUserInfo.Name = "txtUserInfo";
            txtUserInfo.Size = new Size(335, 22);
            txtUserInfo.TabIndex = 202;
            // 
            // Label16
            // 
            Label16.AutoSize = true;
            Label16.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label16.Location = new Point(190, 472);
            Label16.Name = "Label16";
            Label16.Size = new Size(57, 15);
            Label16.TabIndex = 201;
            Label16.Text = "User Info";
            Label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cboLLoBy
            // 
            cboLLoBy.BackColor = SystemColors.Window;
            cboLLoBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLLoBy.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboLLoBy.FormattingEnabled = true;
            cboLLoBy.Items.AddRange(new object[] { "DR", "GPS", "KP" });
            cboLLoBy.Location = new Point(436, 9);
            cboLLoBy.Name = "cboLLoBy";
            cboLLoBy.Size = new Size(70, 22);
            cboLLoBy.TabIndex = 204;
            // 
            // Label17
            // 
            Label17.AutoSize = true;
            Label17.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label17.Location = new Point(389, 13);
            Label17.Name = "Label17";
            Label17.Size = new Size(46, 14);
            Label17.TabIndex = 203;
            Label17.Text = "L/Lo by:";
            Label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpSLInfo
            // 
            grpSLInfo.BackColor = SystemColors.Info;
            grpSLInfo.Controls.Add(lblBodyNm);
            grpSLInfo.Controls.Add(lblLimb);
            grpSLInfo.Controls.Add(cbLimb);
            grpSLInfo.Controls.Add(cboBody);
            grpSLInfo.Controls.Add(Label17);
            grpSLInfo.Controls.Add(cboLLoBy);
            grpSLInfo.Location = new Point(7, 118);
            grpSLInfo.Name = "grpSLInfo";
            grpSLInfo.Size = new Size(515, 35);
            grpSLInfo.TabIndex = 205;
            grpSLInfo.TabStop = false;
            grpSLInfo.Text = "SightLog Info";
            grpSLInfo.Visible = false;
            // 
            // lblBodyNm
            // 
            lblBodyNm.BackColor = SystemColors.Control;
            lblBodyNm.Cursor = Cursors.Default;
            lblBodyNm.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblBodyNm.ForeColor = SystemColors.ControlText;
            lblBodyNm.Location = new Point(49, 14);
            lblBodyNm.Name = "lblBodyNm";
            lblBodyNm.RightToLeft = RightToLeft.No;
            lblBodyNm.Size = new Size(45, 17);
            lblBodyNm.TabIndex = 208;
            lblBodyNm.Text = "Body";
            lblBodyNm.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLimb
            // 
            lblLimb.BackColor = SystemColors.Control;
            lblLimb.Cursor = Cursors.Default;
            lblLimb.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLimb.ForeColor = SystemColors.ControlText;
            lblLimb.Location = new Point(248, 12);
            lblLimb.Name = "lblLimb";
            lblLimb.RightToLeft = RightToLeft.No;
            lblLimb.Size = new Size(38, 17);
            lblLimb.TabIndex = 207;
            lblLimb.Text = "Limb";
            lblLimb.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbLimb
            // 
            cbLimb.BackColor = SystemColors.Window;
            cbLimb.Cursor = Cursors.Default;
            cbLimb.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLimb.Enabled = false;
            cbLimb.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cbLimb.ForeColor = SystemColors.WindowText;
            cbLimb.Items.AddRange(new object[] { "Lower", "Upper", "Center" });
            cbLimb.Location = new Point(288, 9);
            cbLimb.Name = "cbLimb";
            cbLimb.RightToLeft = RightToLeft.No;
            cbLimb.Size = new Size(100, 22);
            cbLimb.TabIndex = 206;
            // 
            // cboBody
            // 
            cboBody.BackColor = SystemColors.Window;
            cboBody.Cursor = Cursors.Default;
            cboBody.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBody.Enabled = false;
            cboBody.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboBody.ForeColor = SystemColors.WindowText;
            cboBody.Items.AddRange(new object[] { "Sun", "Moon", "Venus", "Mars", "Jupiter", "Saturn", "Acamar", "Achernar", "Acrux", "Adhara", "Aldebaran", "Alioth", "Alkaid", "Al Na'ir", "Alnilam", "Alphard", "Alphecca", "Alpheratz", "Altair", "Ankaa", "Antares", "Arcturus", "Atria", "Avior", "Bellatrix", "Betelgeuse", "Canopus", "Capella", "Deneb", "Denebola", "Diphda", "Dubhe", "Elnath", "Eltanin", "Enif", "Fomalhaut", "Gacrux", "Gienah", "Hadar", "Hamal", "Kaus Australis", "Kochab", "Markab", "Menkar", "Menkent", "Miaplacidus", "Mirfak", "Nunki", "Peacock", "Polaris", "Pollux", "Procyon", "Rasalhague", "Regulus", "Rigel", "Rigil Kentaurus", "Sabik", "Schedar", "Shaula", "Sirius", "Spica", "Suhail", "Vega", "Zubenelgenubi" + '\t' });
            cboBody.Location = new Point(95, 9);
            cboBody.Name = "cboBody";
            cboBody.RightToLeft = RightToLeft.No;
            cboBody.Size = new Size(150, 22);
            cboBody.TabIndex = 205;
            // 
            // btnNASRFix
            // 
            _btnNASRFix.BackColor = SystemColors.Control;
            _btnNASRFix.Cursor = Cursors.Default;
            _btnNASRFix.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnNASRFix.ForeColor = SystemColors.ControlText;
            _btnNASRFix.Location = new Point(3, 553);
            _btnNASRFix.Name = "_btnNASRFix";
            _btnNASRFix.RightToLeft = RightToLeft.No;
            _btnNASRFix.Size = new Size(110, 25);
            _btnNASRFix.TabIndex = 206;
            _btnNASRFix.Text = "Save for NASR Fix";
            _btnNASRFix.UseVisualStyleBackColor = false;
            _btnNASRFix.Visible = false;
            // 
            // FormAltSR
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Window;
            ClientSize = new Size(672, 585);
            Controls.Add(_btnNASRFix);
            Controls.Add(grpSLInfo);
            Controls.Add(txtUserInfo);
            Controls.Add(Label16);
            Controls.Add(_cmdMerDiag);
            Controls.Add(_btnCustomPlot);
            Controls.Add(_btnUseCLS);
            Controls.Add(DTSight);
            Controls.Add(lblDate);
            Controls.Add(PictureBox1);
            Controls.Add(WeemsPVTxtBx);
            Controls.Add(GroupBoxPrecision);
            Controls.Add(DCorrTxtBx);
            Controls.Add(NASRAFTxtBx);
            Controls.Add(NASRAsmTxtBx);
            Controls.Add(SRRightTxtBx);
            Controls.Add(SRHdrTxtBx);
            Controls.Add(_ExitBtn);
            Controls.Add(_chkInterpolateB);
            Controls.Add(_cmdWeems);
            Controls.Add(frameS);
            Controls.Add(_cmdSTable);
            Controls.Add(_chkSadler);
            Controls.Add(frame214);
            Controls.Add(_chkDSD);
            Controls.Add(frame211);
            Controls.Add(_cmd208);
            Controls.Add(_cmd211);
            Controls.Add(_cmd214);
            Controls.Add(_cmd229);
            Controls.Add(_cmd249);
            Controls.Add(_cmdClearSome);
            Controls.Add(_cmdClear);
            Controls.Add(_cmdFix);
            Controls.Add(_cmdSave);
            Controls.Add(frameNASRUsing);
            Controls.Add(_cmdPrint);
            Controls.Add(_cmdNASR);
            Controls.Add(_cmdLawOfCosines);
            Controls.Add(_cboDec);
            Controls.Add(_txtHoMin);
            Controls.Add(_txtDecMin);
            Controls.Add(_txtGHAMin);
            Controls.Add(_txtHoDeg);
            Controls.Add(_txtDecDeg);
            Controls.Add(_txtGHADeg);
            Controls.Add(_txtLMin);
            Controls.Add(cboL);
            Controls.Add(_txtLoDeg);
            Controls.Add(_txtLoMin);
            Controls.Add(cboLo);
            Controls.Add(_txtLDeg);
            Controls.Add(Label6);
            Controls.Add(Label5);
            Controls.Add(Label4);
            Controls.Add(lblHoMin);
            Controls.Add(lblDecMin);
            Controls.Add(lblGHAMin);
            Controls.Add(lblHoDeg);
            Controls.Add(lblDecDeg);
            Controls.Add(lblGHADeg);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(lblDRL);
            Controls.Add(lblLDeg);
            Controls.Add(lblLMin);
            Controls.Add(lblDRLo);
            Controls.Add(lblLoDeg);
            Controls.Add(lblLoMin);
            Controls.Add(SRLgTxtBx);
            Controls.Add(SRLeftTxtBx);
            Cursor = Cursors.Default;
            Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(61, 187);
            MaximizeBox = false;
            Name = "FormAltSR";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sight Reduction Methods";
            frameS.ResumeLayout(false);
            frame214.ResumeLayout(false);
            frame211.ResumeLayout(false);
            frameNASRUsing.ResumeLayout(false);
            GroupBoxPrecision.ResumeLayout(false);
            GroupBoxPrecision.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            grpSLInfo.ResumeLayout(false);
            grpSLInfo.PerformLayout();
            Load += new EventHandler(FormAltSR_Load);
            FormClosed += new FormClosedEventHandler(FormAltSR_FormClosed);
            ResumeLayout(false);
            PerformLayout();
        }

        internal RichTextBox SRLgTxtBx;
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

        internal RichTextBox SRHdrTxtBx;
        internal RichTextBox SRLeftTxtBx;
        internal RichTextBox SRRightTxtBx;
        internal RichTextBox NASRAsmTxtBx;
        internal RichTextBox NASRAFTxtBx;
        internal RichTextBox DCorrTxtBx;
        internal RadioButton optFull;
        internal GroupBox GroupBoxPrecision;
        internal RadioButton optRound;
        internal TextBox WeemsPVTxtBx;
        internal PictureBox PictureBox1;
        internal DateTimePicker DTSight;
        public Label lblDate;
        private Button _btnUseCLS;

        internal Button btnUseCLS
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnUseCLS;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnUseCLS != null)
                {
                    _btnUseCLS.Click -= btnUseCLS_Click;
                }

                _btnUseCLS = value;
                if (_btnUseCLS != null)
                {
                    _btnUseCLS.Click += btnUseCLS_Click;
                }
            }
        }

        private Button _btnCustomPlot;

        internal Button btnCustomPlot
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnCustomPlot;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnCustomPlot != null)
                {
                    _btnCustomPlot.Click -= btnCustomPlot_Click;
                }

                _btnCustomPlot = value;
                if (_btnCustomPlot != null)
                {
                    _btnCustomPlot.Click += btnCustomPlot_Click;
                }
            }
        }

        private Button _cmdMerDiag;

        internal Button cmdMerDiag
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdMerDiag;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdMerDiag != null)
                {
                    _cmdMerDiag.Click -= cmdMerDiag_Click_1;
                }

                _cmdMerDiag = value;
                if (_cmdMerDiag != null)
                {
                    _cmdMerDiag.Click += cmdMerDiag_Click_1;
                }
            }
        }

        internal TextBox txtUserInfo;
        internal Label Label16;
        internal ComboBox cboLLoBy;
        internal Label Label17;
        internal GroupBox grpSLInfo;
        public Label lblBodyNm;
        public Label lblLimb;
        public ComboBox cbLimb;
        public ComboBox cboBody;
        private Button _btnNASRFix;

        public Button btnNASRFix
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnNASRFix;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnNASRFix != null)
                {
                    _btnNASRFix.Click -= btnNASRFix_Click;
                }

                _btnNASRFix = value;
                if (_btnNASRFix != null)
                {
                    _btnNASRFix.Click += btnNASRFix_Click;
                }
            }
        }
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}