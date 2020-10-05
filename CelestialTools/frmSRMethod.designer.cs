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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAltSR));
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this._cmdPrint = new System.Windows.Forms.Button();
            this._txtHoMin = new System.Windows.Forms.TextBox();
            this._txtDecMin = new System.Windows.Forms.TextBox();
            this._txtGHAMin = new System.Windows.Forms.TextBox();
            this._txtHoDeg = new System.Windows.Forms.TextBox();
            this._txtDecDeg = new System.Windows.Forms.TextBox();
            this._txtGHADeg = new System.Windows.Forms.TextBox();
            this._txtLMin = new System.Windows.Forms.TextBox();
            this._txtLoDeg = new System.Windows.Forms.TextBox();
            this._txtLoMin = new System.Windows.Forms.TextBox();
            this._txtLDeg = new System.Windows.Forms.TextBox();
            this._chkInterpolateB = new System.Windows.Forms.CheckBox();
            this._cmdWeems = new System.Windows.Forms.Button();
            this.frameS = new System.Windows.Forms.GroupBox();
            this._optFarley = new System.Windows.Forms.RadioButton();
            this._optPepperday = new System.Windows.Forms.RadioButton();
            this._cmdSTable = new System.Windows.Forms.Button();
            this._chkSadler = new System.Windows.Forms.CheckBox();
            this.frame214 = new System.Windows.Forms.GroupBox();
            this._optdtL = new System.Windows.Forms.RadioButton();
            this._optdt = new System.Windows.Forms.RadioButton();
            this._optd = new System.Windows.Forms.RadioButton();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this._chkDSD = new System.Windows.Forms.CheckBox();
            this.frame211 = new System.Windows.Forms.GroupBox();
            this._optCompact = new System.Windows.Forms.RadioButton();
            this._optOriginal = new System.Windows.Forms.RadioButton();
            this._cmd208 = new System.Windows.Forms.Button();
            this._cmd211 = new System.Windows.Forms.Button();
            this._cmd214 = new System.Windows.Forms.Button();
            this._cmd229 = new System.Windows.Forms.Button();
            this._cmd249 = new System.Windows.Forms.Button();
            this._cmdClearSome = new System.Windows.Forms.Button();
            this._cmdClear = new System.Windows.Forms.Button();
            this._cmdFix = new System.Windows.Forms.Button();
            this._cmdSave = new System.Windows.Forms.Button();
            this.frameNASRUsing = new System.Windows.Forms.GroupBox();
            this._optNATable = new System.Windows.Forms.RadioButton();
            this._optUSPSTable = new System.Windows.Forms.RadioButton();
            this._cmdNASR = new System.Windows.Forms.Button();
            this._cmdLawOfCosines = new System.Windows.Forms.Button();
            this._cboDec = new System.Windows.Forms.ComboBox();
            this.cboL = new System.Windows.Forms.ComboBox();
            this.cboLo = new System.Windows.Forms.ComboBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.lblHoMin = new System.Windows.Forms.Label();
            this.lblDecMin = new System.Windows.Forms.Label();
            this.lblGHAMin = new System.Windows.Forms.Label();
            this.lblHoDeg = new System.Windows.Forms.Label();
            this.lblDecDeg = new System.Windows.Forms.Label();
            this.lblGHADeg = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.lblDRL = new System.Windows.Forms.Label();
            this.lblLDeg = new System.Windows.Forms.Label();
            this.lblLMin = new System.Windows.Forms.Label();
            this.lblDRLo = new System.Windows.Forms.Label();
            this.lblLoDeg = new System.Windows.Forms.Label();
            this.lblLoMin = new System.Windows.Forms.Label();
            this.SRLgTxtBx = new System.Windows.Forms.RichTextBox();
            this._ExitBtn = new System.Windows.Forms.Button();
            this.SRHdrTxtBx = new System.Windows.Forms.RichTextBox();
            this.SRLeftTxtBx = new System.Windows.Forms.RichTextBox();
            this.SRRightTxtBx = new System.Windows.Forms.RichTextBox();
            this.NASRAsmTxtBx = new System.Windows.Forms.RichTextBox();
            this.NASRAFTxtBx = new System.Windows.Forms.RichTextBox();
            this.DCorrTxtBx = new System.Windows.Forms.RichTextBox();
            this.optFull = new System.Windows.Forms.RadioButton();
            this.GroupBoxPrecision = new System.Windows.Forms.GroupBox();
            this.optRound = new System.Windows.Forms.RadioButton();
            this.WeemsPVTxtBx = new System.Windows.Forms.TextBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.DTSight = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this._btnUseCLS = new System.Windows.Forms.Button();
            this._btnCustomPlot = new System.Windows.Forms.Button();
            this._cmdMerDiag = new System.Windows.Forms.Button();
            this.txtUserInfo = new System.Windows.Forms.TextBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.cboLLoBy = new System.Windows.Forms.ComboBox();
            this.Label17 = new System.Windows.Forms.Label();
            this.grpSLInfo = new System.Windows.Forms.GroupBox();
            this.lblBodyNm = new System.Windows.Forms.Label();
            this.lblLimb = new System.Windows.Forms.Label();
            this.cbLimb = new System.Windows.Forms.ComboBox();
            this.cboBody = new System.Windows.Forms.ComboBox();
            this._btnNASRFix = new System.Windows.Forms.Button();
            this.frameS.SuspendLayout();
            this.frame214.SuspendLayout();
            this.frame211.SuspendLayout();
            this.frameNASRUsing.SuspendLayout();
            this.GroupBoxPrecision.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.grpSLInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // _cmdPrint
            // 
            this._cmdPrint.BackColor = System.Drawing.SystemColors.Control;
            this._cmdPrint.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdPrint.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdPrint.Image = ((System.Drawing.Image)(resources.GetObject("_cmdPrint.Image")));
            this._cmdPrint.Location = new System.Drawing.Point(646, 2);
            this._cmdPrint.Name = "_cmdPrint";
            this._cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdPrint.Size = new System.Drawing.Size(21, 21);
            this._cmdPrint.TabIndex = 72;
            this._cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ToolTip1.SetToolTip(this._cmdPrint, "Print window");
            this._cmdPrint.UseVisualStyleBackColor = false;
            this._cmdPrint.Click += new System.EventHandler(this.cmdPrint_Click);
            // 
            // _txtHoMin
            // 
            this._txtHoMin.AcceptsReturn = true;
            this._txtHoMin.BackColor = System.Drawing.SystemColors.Window;
            this._txtHoMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtHoMin.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtHoMin.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtHoMin.Location = new System.Drawing.Point(80, 58);
            this._txtHoMin.MaxLength = 5;
            this._txtHoMin.Name = "_txtHoMin";
            this._txtHoMin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtHoMin.Size = new System.Drawing.Size(33, 20);
            this._txtHoMin.TabIndex = 6;
            this._txtHoMin.Text = "0";
            this.ToolTip1.SetToolTip(this._txtHoMin, "Range -59.9 to 59.9");
            this._txtHoMin.TextChanged += new System.EventHandler(this.txtHoMin_TextChanged);
            this._txtHoMin.Enter += new System.EventHandler(this.txtHoMin_Enter);
            this._txtHoMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoMin_KeyPress);
            this._txtHoMin.Validating += new System.ComponentModel.CancelEventHandler(this.txtHoMin_Validating);
            // 
            // _txtDecMin
            // 
            this._txtDecMin.AcceptsReturn = true;
            this._txtDecMin.BackColor = System.Drawing.SystemColors.Window;
            this._txtDecMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtDecMin.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtDecMin.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtDecMin.Location = new System.Drawing.Point(80, 34);
            this._txtDecMin.MaxLength = 4;
            this._txtDecMin.Name = "_txtDecMin";
            this._txtDecMin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtDecMin.Size = new System.Drawing.Size(33, 20);
            this._txtDecMin.TabIndex = 3;
            this._txtDecMin.Text = "0";
            this.ToolTip1.SetToolTip(this._txtDecMin, "Range 0 to 59.9");
            this._txtDecMin.TextChanged += new System.EventHandler(this.txtDecMin_TextChanged);
            this._txtDecMin.Enter += new System.EventHandler(this.txtDecMin_Enter);
            this._txtDecMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDecMin_KeyPress);
            this._txtDecMin.Validating += new System.ComponentModel.CancelEventHandler(this.txtDecMin_Validating);
            // 
            // _txtGHAMin
            // 
            this._txtGHAMin.AcceptsReturn = true;
            this._txtGHAMin.BackColor = System.Drawing.SystemColors.Window;
            this._txtGHAMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtGHAMin.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtGHAMin.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtGHAMin.Location = new System.Drawing.Point(80, 10);
            this._txtGHAMin.MaxLength = 4;
            this._txtGHAMin.Name = "_txtGHAMin";
            this._txtGHAMin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtGHAMin.Size = new System.Drawing.Size(33, 20);
            this._txtGHAMin.TabIndex = 1;
            this._txtGHAMin.Text = "0";
            this.ToolTip1.SetToolTip(this._txtGHAMin, "Range 0 to 59.9");
            this._txtGHAMin.TextChanged += new System.EventHandler(this.txtGHAMin_TextChanged);
            this._txtGHAMin.Enter += new System.EventHandler(this.txtGHAMin_Enter);
            this._txtGHAMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGHAMin_KeyPress);
            this._txtGHAMin.Validating += new System.ComponentModel.CancelEventHandler(this.txtGHAMin_Validating);
            // 
            // _txtHoDeg
            // 
            this._txtHoDeg.AcceptsReturn = true;
            this._txtHoDeg.BackColor = System.Drawing.SystemColors.Window;
            this._txtHoDeg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtHoDeg.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtHoDeg.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtHoDeg.Location = new System.Drawing.Point(40, 58);
            this._txtHoDeg.MaxLength = 2;
            this._txtHoDeg.Name = "_txtHoDeg";
            this._txtHoDeg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtHoDeg.Size = new System.Drawing.Size(33, 20);
            this._txtHoDeg.TabIndex = 5;
            this._txtHoDeg.Text = "0";
            this.ToolTip1.SetToolTip(this._txtHoDeg, "Range 0 to 88 for LoC, 0 to 75 for NASR, 0 to 85 for 229, 0 to 90 for others");
            this._txtHoDeg.TextChanged += new System.EventHandler(this.txtHoDeg_TextChanged);
            this._txtHoDeg.Enter += new System.EventHandler(this.txtHoDeg_Enter);
            this._txtHoDeg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoDeg_KeyPress);
            this._txtHoDeg.Validating += new System.ComponentModel.CancelEventHandler(this.txtHoDeg_Validating);
            // 
            // _txtDecDeg
            // 
            this._txtDecDeg.AcceptsReturn = true;
            this._txtDecDeg.BackColor = System.Drawing.SystemColors.Window;
            this._txtDecDeg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtDecDeg.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtDecDeg.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtDecDeg.Location = new System.Drawing.Point(40, 34);
            this._txtDecDeg.MaxLength = 2;
            this._txtDecDeg.Name = "_txtDecDeg";
            this._txtDecDeg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtDecDeg.Size = new System.Drawing.Size(33, 20);
            this._txtDecDeg.TabIndex = 2;
            this._txtDecDeg.Text = "0";
            this.ToolTip1.SetToolTip(this._txtDecDeg, "Range 0 to 90");
            this._txtDecDeg.TextChanged += new System.EventHandler(this.txtDecDeg_TextChanged);
            this._txtDecDeg.Enter += new System.EventHandler(this.txtDecDeg_Enter);
            this._txtDecDeg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDecDeg_KeyPress);
            this._txtDecDeg.Validating += new System.ComponentModel.CancelEventHandler(this.txtDecDeg_Validating);
            // 
            // _txtGHADeg
            // 
            this._txtGHADeg.AcceptsReturn = true;
            this._txtGHADeg.BackColor = System.Drawing.SystemColors.Window;
            this._txtGHADeg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtGHADeg.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtGHADeg.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtGHADeg.Location = new System.Drawing.Point(40, 10);
            this._txtGHADeg.MaxLength = 3;
            this._txtGHADeg.Name = "_txtGHADeg";
            this._txtGHADeg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtGHADeg.Size = new System.Drawing.Size(33, 20);
            this._txtGHADeg.TabIndex = 0;
            this._txtGHADeg.Text = "0";
            this.ToolTip1.SetToolTip(this._txtGHADeg, "Range 0 to 719");
            this._txtGHADeg.TextChanged += new System.EventHandler(this.txtGHADeg_TextChanged);
            this._txtGHADeg.Enter += new System.EventHandler(this.txtGHADeg_Enter);
            this._txtGHADeg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGHADeg_KeyPress);
            this._txtGHADeg.Validating += new System.ComponentModel.CancelEventHandler(this.txtGHADeg_Validating);
            // 
            // _txtLMin
            // 
            this._txtLMin.AcceptsReturn = true;
            this._txtLMin.BackColor = System.Drawing.SystemColors.Window;
            this._txtLMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtLMin.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtLMin.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtLMin.Location = new System.Drawing.Point(296, 8);
            this._txtLMin.MaxLength = 4;
            this._txtLMin.Name = "_txtLMin";
            this._txtLMin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtLMin.Size = new System.Drawing.Size(33, 20);
            this._txtLMin.TabIndex = 8;
            this._txtLMin.Text = "0";
            this.ToolTip1.SetToolTip(this._txtLMin, "Range 0 to 59.9");
            this._txtLMin.TextChanged += new System.EventHandler(this.txtLMin_TextChanged);
            this._txtLMin.Enter += new System.EventHandler(this.txtLMin_Enter);
            this._txtLMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLMin_KeyPress);
            this._txtLMin.Validating += new System.ComponentModel.CancelEventHandler(this.txtLMin_Validating);
            // 
            // _txtLoDeg
            // 
            this._txtLoDeg.AcceptsReturn = true;
            this._txtLoDeg.BackColor = System.Drawing.SystemColors.Window;
            this._txtLoDeg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtLoDeg.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtLoDeg.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtLoDeg.Location = new System.Drawing.Point(256, 32);
            this._txtLoDeg.MaxLength = 3;
            this._txtLoDeg.Name = "_txtLoDeg";
            this._txtLoDeg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtLoDeg.Size = new System.Drawing.Size(33, 20);
            this._txtLoDeg.TabIndex = 10;
            this._txtLoDeg.Text = "0";
            this.ToolTip1.SetToolTip(this._txtLoDeg, "Range 0 to 180");
            this._txtLoDeg.TextChanged += new System.EventHandler(this.txtLoDeg_TextChanged);
            this._txtLoDeg.Enter += new System.EventHandler(this.txtLoDeg_Enter);
            this._txtLoDeg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLoDeg_KeyPress);
            this._txtLoDeg.Validating += new System.ComponentModel.CancelEventHandler(this.txtLoDeg_Validating);
            // 
            // _txtLoMin
            // 
            this._txtLoMin.AcceptsReturn = true;
            this._txtLoMin.BackColor = System.Drawing.SystemColors.Window;
            this._txtLoMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtLoMin.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtLoMin.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtLoMin.Location = new System.Drawing.Point(296, 32);
            this._txtLoMin.MaxLength = 4;
            this._txtLoMin.Name = "_txtLoMin";
            this._txtLoMin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtLoMin.Size = new System.Drawing.Size(33, 20);
            this._txtLoMin.TabIndex = 11;
            this._txtLoMin.Text = "0";
            this.ToolTip1.SetToolTip(this._txtLoMin, "Range 0 to 59.9");
            this._txtLoMin.TextChanged += new System.EventHandler(this.txtLoMin_TextChanged);
            this._txtLoMin.Enter += new System.EventHandler(this.txtLoMin_Enter);
            this._txtLoMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLoMin_KeyPress);
            this._txtLoMin.Validating += new System.ComponentModel.CancelEventHandler(this.txtLoMin_Validating);
            // 
            // _txtLDeg
            // 
            this._txtLDeg.AcceptsReturn = true;
            this._txtLDeg.BackColor = System.Drawing.SystemColors.Window;
            this._txtLDeg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtLDeg.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtLDeg.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtLDeg.Location = new System.Drawing.Point(256, 8);
            this._txtLDeg.MaxLength = 2;
            this._txtLDeg.Name = "_txtLDeg";
            this._txtLDeg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtLDeg.Size = new System.Drawing.Size(33, 20);
            this._txtLDeg.TabIndex = 7;
            this._txtLDeg.Text = "0";
            this.ToolTip1.SetToolTip(this._txtLDeg, "Range 0 to 90");
            this._txtLDeg.TextChanged += new System.EventHandler(this.txtLDeg_TextChanged);
            this._txtLDeg.Enter += new System.EventHandler(this.txtLDeg_Enter);
            this._txtLDeg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLDeg_KeyPress);
            this._txtLDeg.Validating += new System.ComponentModel.CancelEventHandler(this.txtLDeg_Validating);
            // 
            // _chkInterpolateB
            // 
            this._chkInterpolateB.BackColor = System.Drawing.SystemColors.Window;
            this._chkInterpolateB.Cursor = System.Windows.Forms.Cursors.Default;
            this._chkInterpolateB.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._chkInterpolateB.ForeColor = System.Drawing.SystemColors.ControlText;
            this._chkInterpolateB.Location = new System.Drawing.Point(7, 155);
            this._chkInterpolateB.Name = "_chkInterpolateB";
            this._chkInterpolateB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._chkInterpolateB.Size = new System.Drawing.Size(190, 22);
            this._chkInterpolateB.TabIndex = 66;
            this._chkInterpolateB.Text = "Interpolate Table B (for Hc calc.)";
            this._chkInterpolateB.UseVisualStyleBackColor = false;
            this._chkInterpolateB.Visible = false;
            this._chkInterpolateB.CheckStateChanged += new System.EventHandler(this.chkInterpolateB_CheckStateChanged);
            // 
            // _cmdWeems
            // 
            this._cmdWeems.BackColor = System.Drawing.SystemColors.Control;
            this._cmdWeems.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdWeems.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmdWeems.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdWeems.Location = new System.Drawing.Point(536, 120);
            this._cmdWeems.Name = "_cmdWeems";
            this._cmdWeems.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdWeems.Size = new System.Drawing.Size(65, 22);
            this._cmdWeems.TabIndex = 42;
            this._cmdWeems.Text = "&Weems LPB";
            this._cmdWeems.UseVisualStyleBackColor = false;
            this._cmdWeems.Click += new System.EventHandler(this.cmdWeems_Click);
            // 
            // frameS
            // 
            this.frameS.BackColor = System.Drawing.SystemColors.Window;
            this.frameS.Controls.Add(this._optFarley);
            this.frameS.Controls.Add(this._optPepperday);
            this.frameS.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frameS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.frameS.Location = new System.Drawing.Point(526, 145);
            this.frameS.Name = "frameS";
            this.frameS.Padding = new System.Windows.Forms.Padding(0);
            this.frameS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.frameS.Size = new System.Drawing.Size(140, 32);
            this.frameS.TabIndex = 63;
            this.frameS.TabStop = false;
            this.frameS.Text = "Version";
            this.frameS.Visible = false;
            // 
            // _optFarley
            // 
            this._optFarley.BackColor = System.Drawing.SystemColors.Window;
            this._optFarley.Cursor = System.Windows.Forms.Cursors.Default;
            this._optFarley.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optFarley.ForeColor = System.Drawing.SystemColors.ControlText;
            this._optFarley.Location = new System.Drawing.Point(83, 10);
            this._optFarley.Name = "_optFarley";
            this._optFarley.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optFarley.Size = new System.Drawing.Size(57, 21);
            this._optFarley.TabIndex = 65;
            this._optFarley.TabStop = true;
            this._optFarley.Text = "Farley";
            this._optFarley.UseVisualStyleBackColor = false;
            this._optFarley.CheckedChanged += new System.EventHandler(this.optFarley_CheckedChanged);
            // 
            // _optPepperday
            // 
            this._optPepperday.BackColor = System.Drawing.SystemColors.Window;
            this._optPepperday.Checked = true;
            this._optPepperday.Cursor = System.Windows.Forms.Cursors.Default;
            this._optPepperday.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optPepperday.ForeColor = System.Drawing.SystemColors.ControlText;
            this._optPepperday.Location = new System.Drawing.Point(8, 11);
            this._optPepperday.Name = "_optPepperday";
            this._optPepperday.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optPepperday.Size = new System.Drawing.Size(81, 18);
            this._optPepperday.TabIndex = 64;
            this._optPepperday.TabStop = true;
            this._optPepperday.Text = "Pepperday";
            this._optPepperday.UseVisualStyleBackColor = false;
            this._optPepperday.CheckedChanged += new System.EventHandler(this.optPepperday_CheckedChanged);
            // 
            // _cmdSTable
            // 
            this._cmdSTable.BackColor = System.Drawing.SystemColors.Control;
            this._cmdSTable.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdSTable.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmdSTable.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdSTable.Location = new System.Drawing.Point(608, 120);
            this._cmdSTable.Name = "_cmdSTable";
            this._cmdSTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdSTable.Size = new System.Drawing.Size(57, 22);
            this._cmdSTable.TabIndex = 43;
            this._cmdSTable.Text = "&S-Table";
            this._cmdSTable.UseVisualStyleBackColor = false;
            this._cmdSTable.Click += new System.EventHandler(this.cmdSTable_Click);
            // 
            // _chkSadler
            // 
            this._chkSadler.BackColor = System.Drawing.SystemColors.Window;
            this._chkSadler.Cursor = System.Windows.Forms.Cursors.Default;
            this._chkSadler.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._chkSadler.ForeColor = System.Drawing.SystemColors.ControlText;
            this._chkSadler.Location = new System.Drawing.Point(133, 501);
            this._chkSadler.Name = "_chkSadler";
            this._chkSadler.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._chkSadler.Size = new System.Drawing.Size(132, 17);
            this._chkSadler.TabIndex = 62;
            this._chkSadler.Text = "Use Sadler Technique";
            this._chkSadler.UseVisualStyleBackColor = false;
            this._chkSadler.Visible = false;
            this._chkSadler.CheckStateChanged += new System.EventHandler(this.chkSadler_CheckStateChanged);
            // 
            // frame214
            // 
            this.frame214.BackColor = System.Drawing.SystemColors.Window;
            this.frame214.Controls.Add(this._optdtL);
            this.frame214.Controls.Add(this._optdt);
            this.frame214.Controls.Add(this._optd);
            this.frame214.Controls.Add(this.Label15);
            this.frame214.Controls.Add(this.Label14);
            this.frame214.Controls.Add(this.Label13);
            this.frame214.Controls.Add(this.Label12);
            this.frame214.Controls.Add(this.Label11);
            this.frame214.Controls.Add(this.Label10);
            this.frame214.Controls.Add(this.Label8);
            this.frame214.Controls.Add(this.Label7);
            this.frame214.Controls.Add(this.Label9);
            this.frame214.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frame214.ForeColor = System.Drawing.SystemColors.ControlText;
            this.frame214.Location = new System.Drawing.Point(320, 145);
            this.frame214.Name = "frame214";
            this.frame214.Padding = new System.Windows.Forms.Padding(0);
            this.frame214.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.frame214.Size = new System.Drawing.Size(201, 34);
            this.frame214.TabIndex = 49;
            this.frame214.TabStop = false;
            this.frame214.Text = "Solution using";
            this.frame214.Visible = false;
            // 
            // _optdtL
            // 
            this._optdtL.BackColor = System.Drawing.SystemColors.Window;
            this._optdtL.Cursor = System.Windows.Forms.Cursors.Default;
            this._optdtL.Font = new System.Drawing.Font("Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this._optdtL.ForeColor = System.Drawing.SystemColors.ControlText;
            this._optdtL.Location = new System.Drawing.Point(120, 14);
            this._optdtL.Name = "_optdtL";
            this._optdtL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optdtL.Size = new System.Drawing.Size(25, 14);
            this._optdtL.TabIndex = 53;
            this._optdtL.TabStop = true;
            this._optdtL.Text = "D";
            this._optdtL.UseVisualStyleBackColor = false;
            this._optdtL.CheckedChanged += new System.EventHandler(this.optdtL_CheckedChanged);
            // 
            // _optdt
            // 
            this._optdt.BackColor = System.Drawing.SystemColors.Window;
            this._optdt.Cursor = System.Windows.Forms.Cursors.Default;
            this._optdt.Font = new System.Drawing.Font("Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this._optdt.ForeColor = System.Drawing.SystemColors.ControlText;
            this._optdt.Location = new System.Drawing.Point(56, 14);
            this._optdt.Name = "_optdt";
            this._optdt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optdt.Size = new System.Drawing.Size(25, 14);
            this._optdt.TabIndex = 51;
            this._optdt.TabStop = true;
            this._optdt.Text = "D";
            this._optdt.UseVisualStyleBackColor = false;
            this._optdt.CheckedChanged += new System.EventHandler(this.optdt_CheckedChanged);
            // 
            // _optd
            // 
            this._optd.BackColor = System.Drawing.SystemColors.Window;
            this._optd.Checked = true;
            this._optd.Cursor = System.Windows.Forms.Cursors.Default;
            this._optd.Font = new System.Drawing.Font("Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this._optd.ForeColor = System.Drawing.SystemColors.ControlText;
            this._optd.Location = new System.Drawing.Point(8, 14);
            this._optd.Name = "_optd";
            this._optd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optd.Size = new System.Drawing.Size(25, 14);
            this._optd.TabIndex = 50;
            this._optd.TabStop = true;
            this._optd.Text = "D";
            this._optd.UseVisualStyleBackColor = false;
            this._optd.CheckedChanged += new System.EventHandler(this.optd_CheckedChanged);
            // 
            // Label15
            // 
            this.Label15.BackColor = System.Drawing.SystemColors.Window;
            this.Label15.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label15.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label15.Location = new System.Drawing.Point(186, 14);
            this.Label15.Name = "Label15";
            this.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label15.Size = new System.Drawing.Size(8, 17);
            this.Label15.TabIndex = 61;
            this.Label15.Text = "L";
            // 
            // Label14
            // 
            this.Label14.BackColor = System.Drawing.SystemColors.Window;
            this.Label14.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label14.Font = new System.Drawing.Font("Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label14.Location = new System.Drawing.Point(176, 14);
            this.Label14.Name = "Label14";
            this.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label14.Size = new System.Drawing.Size(8, 17);
            this.Label14.TabIndex = 60;
            this.Label14.Text = "D";
            // 
            // Label13
            // 
            this.Label13.BackColor = System.Drawing.SystemColors.Window;
            this.Label13.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label13.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label13.Location = new System.Drawing.Point(168, 14);
            this.Label13.Name = "Label13";
            this.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label13.Size = new System.Drawing.Size(8, 17);
            this.Label13.TabIndex = 59;
            this.Label13.Text = "t,";
            // 
            // Label12
            // 
            this.Label12.BackColor = System.Drawing.SystemColors.Window;
            this.Label12.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label12.Font = new System.Drawing.Font("Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label12.Location = new System.Drawing.Point(157, 14);
            this.Label12.Name = "Label12";
            this.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label12.Size = new System.Drawing.Size(8, 17);
            this.Label12.TabIndex = 58;
            this.Label12.Text = "D";
            // 
            // Label11
            // 
            this.Label11.BackColor = System.Drawing.SystemColors.Window;
            this.Label11.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label11.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label11.Location = new System.Drawing.Point(147, 14);
            this.Label11.Name = "Label11";
            this.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label11.Size = new System.Drawing.Size(8, 17);
            this.Label11.TabIndex = 57;
            this.Label11.Text = "d,";
            // 
            // Label10
            // 
            this.Label10.BackColor = System.Drawing.SystemColors.Window;
            this.Label10.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label10.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label10.Location = new System.Drawing.Point(104, 14);
            this.Label10.Name = "Label10";
            this.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label10.Size = new System.Drawing.Size(5, 17);
            this.Label10.TabIndex = 56;
            this.Label10.Text = "t";
            // 
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.SystemColors.Window;
            this.Label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label8.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label8.Location = new System.Drawing.Point(84, 14);
            this.Label8.Name = "Label8";
            this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label8.Size = new System.Drawing.Size(8, 14);
            this.Label8.TabIndex = 55;
            this.Label8.Text = "d,";
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.SystemColors.Window;
            this.Label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label7.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label7.Location = new System.Drawing.Point(35, 14);
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label7.Size = new System.Drawing.Size(5, 14);
            this.Label7.TabIndex = 54;
            this.Label7.Text = "d";
            // 
            // Label9
            // 
            this.Label9.BackColor = System.Drawing.SystemColors.Window;
            this.Label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label9.Font = new System.Drawing.Font("Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label9.Location = new System.Drawing.Point(94, 14);
            this.Label9.Name = "Label9";
            this.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label9.Size = new System.Drawing.Size(8, 17);
            this.Label9.TabIndex = 52;
            this.Label9.Text = "D";
            this.Label9.Visible = false;
            // 
            // _chkDSD
            // 
            this._chkDSD.BackColor = System.Drawing.SystemColors.Window;
            this._chkDSD.Cursor = System.Windows.Forms.Cursors.Default;
            this._chkDSD.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._chkDSD.ForeColor = System.Drawing.SystemColors.ControlText;
            this._chkDSD.Location = new System.Drawing.Point(204, 157);
            this._chkDSD.Name = "_chkDSD";
            this._chkDSD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._chkDSD.Size = new System.Drawing.Size(117, 19);
            this._chkDSD.TabIndex = 47;
            this._chkDSD.Text = "Always use DSD";
            this._chkDSD.UseVisualStyleBackColor = false;
            this._chkDSD.Visible = false;
            this._chkDSD.CheckStateChanged += new System.EventHandler(this.chkDSD_CheckStateChanged);
            // 
            // frame211
            // 
            this.frame211.BackColor = System.Drawing.SystemColors.Window;
            this.frame211.Controls.Add(this._optCompact);
            this.frame211.Controls.Add(this._optOriginal);
            this.frame211.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frame211.ForeColor = System.Drawing.SystemColors.ControlText;
            this.frame211.Location = new System.Drawing.Point(528, 145);
            this.frame211.Name = "frame211";
            this.frame211.Padding = new System.Windows.Forms.Padding(0);
            this.frame211.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.frame211.Size = new System.Drawing.Size(137, 34);
            this.frame211.TabIndex = 44;
            this.frame211.TabStop = false;
            this.frame211.Text = "Version";
            this.frame211.Visible = false;
            // 
            // _optCompact
            // 
            this._optCompact.BackColor = System.Drawing.SystemColors.Window;
            this._optCompact.Checked = true;
            this._optCompact.Cursor = System.Windows.Forms.Cursors.Default;
            this._optCompact.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optCompact.ForeColor = System.Drawing.SystemColors.ControlText;
            this._optCompact.Location = new System.Drawing.Point(4, 14);
            this._optCompact.Name = "_optCompact";
            this._optCompact.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optCompact.Size = new System.Drawing.Size(67, 17);
            this._optCompact.TabIndex = 46;
            this._optCompact.TabStop = true;
            this._optCompact.Text = "Compact";
            this._optCompact.UseVisualStyleBackColor = false;
            this._optCompact.CheckedChanged += new System.EventHandler(this.optCompact_CheckedChanged);
            // 
            // _optOriginal
            // 
            this._optOriginal.BackColor = System.Drawing.SystemColors.Window;
            this._optOriginal.Cursor = System.Windows.Forms.Cursors.Default;
            this._optOriginal.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optOriginal.ForeColor = System.Drawing.SystemColors.ControlText;
            this._optOriginal.Location = new System.Drawing.Point(72, 14);
            this._optOriginal.Name = "_optOriginal";
            this._optOriginal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optOriginal.Size = new System.Drawing.Size(61, 17);
            this._optOriginal.TabIndex = 45;
            this._optOriginal.TabStop = true;
            this._optOriginal.Text = "Original";
            this._optOriginal.UseVisualStyleBackColor = false;
            this._optOriginal.CheckedChanged += new System.EventHandler(this.optOriginal_CheckedChanged);
            // 
            // _cmd208
            // 
            this._cmd208.BackColor = System.Drawing.SystemColors.Control;
            this._cmd208.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmd208.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmd208.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmd208.Location = new System.Drawing.Point(608, 88);
            this._cmd208.Name = "_cmd208";
            this._cmd208.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmd208.Size = new System.Drawing.Size(57, 25);
            this._cmd208.TabIndex = 41;
            this._cmd208.Text = "H.O. 20&8";
            this._cmd208.UseVisualStyleBackColor = false;
            this._cmd208.Click += new System.EventHandler(this.cmd208_Click);
            // 
            // _cmd211
            // 
            this._cmd211.BackColor = System.Drawing.SystemColors.Control;
            this._cmd211.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmd211.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmd211.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmd211.Location = new System.Drawing.Point(608, 56);
            this._cmd211.Name = "_cmd211";
            this._cmd211.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmd211.Size = new System.Drawing.Size(57, 25);
            this._cmd211.TabIndex = 40;
            this._cmd211.Text = "H.O. 21&1";
            this._cmd211.UseVisualStyleBackColor = false;
            this._cmd211.Click += new System.EventHandler(this.cmd211_Click);
            // 
            // _cmd214
            // 
            this._cmd214.BackColor = System.Drawing.SystemColors.Control;
            this._cmd214.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmd214.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmd214.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmd214.Location = new System.Drawing.Point(536, 88);
            this._cmd214.Name = "_cmd214";
            this._cmd214.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmd214.Size = new System.Drawing.Size(65, 25);
            this._cmd214.TabIndex = 39;
            this._cmd214.Text = "H.O. 21&4";
            this._cmd214.UseVisualStyleBackColor = false;
            this._cmd214.Click += new System.EventHandler(this.cmd214_Click);
            // 
            // _cmd229
            // 
            this._cmd229.BackColor = System.Drawing.SystemColors.Control;
            this._cmd229.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmd229.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmd229.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmd229.Location = new System.Drawing.Point(536, 56);
            this._cmd229.Name = "_cmd229";
            this._cmd229.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmd229.Size = new System.Drawing.Size(65, 25);
            this._cmd229.TabIndex = 38;
            this._cmd229.Text = "Pub. 22&9";
            this._cmd229.UseVisualStyleBackColor = false;
            this._cmd229.Click += new System.EventHandler(this.cmd229_Click);
            // 
            // _cmd249
            // 
            this._cmd249.BackColor = System.Drawing.SystemColors.Control;
            this._cmd249.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmd249.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmd249.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmd249.Location = new System.Drawing.Point(536, 24);
            this._cmd249.Name = "_cmd249";
            this._cmd249.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmd249.Size = new System.Drawing.Size(128, 25);
            this._cmd249.TabIndex = 37;
            this._cmd249.Text = "Pub. &249 Vol. 2 && 3";
            this._cmd249.UseVisualStyleBackColor = false;
            this._cmd249.Click += new System.EventHandler(this.cmd249_Click);
            // 
            // _cmdClearSome
            // 
            this._cmdClearSome.BackColor = System.Drawing.SystemColors.Control;
            this._cmdClearSome.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdClearSome.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmdClearSome.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdClearSome.Location = new System.Drawing.Point(90, 467);
            this._cmdClearSome.Name = "_cmdClearSome";
            this._cmdClearSome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdClearSome.Size = new System.Drawing.Size(97, 25);
            this._cmdClearSome.TabIndex = 70;
            this._cmdClearSome.Text = "&Clear except DR";
            this._cmdClearSome.UseVisualStyleBackColor = false;
            this._cmdClearSome.Click += new System.EventHandler(this.cmdClearSome_Click);
            // 
            // _cmdClear
            // 
            this._cmdClear.BackColor = System.Drawing.SystemColors.Control;
            this._cmdClear.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdClear.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmdClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdClear.Location = new System.Drawing.Point(3, 468);
            this._cmdClear.Name = "_cmdClear";
            this._cmdClear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdClear.Size = new System.Drawing.Size(81, 25);
            this._cmdClear.TabIndex = 71;
            this._cmdClear.Text = "Clear &All";
            this._cmdClear.UseVisualStyleBackColor = false;
            this._cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // _cmdFix
            // 
            this._cmdFix.BackColor = System.Drawing.SystemColors.Control;
            this._cmdFix.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdFix.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmdFix.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdFix.Location = new System.Drawing.Point(2, 497);
            this._cmdFix.Name = "_cmdFix";
            this._cmdFix.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdFix.Size = new System.Drawing.Size(111, 25);
            this._cmdFix.TabIndex = 68;
            this._cmdFix.Text = "&Establish Fix";
            this._cmdFix.UseVisualStyleBackColor = false;
            this._cmdFix.Visible = false;
            this._cmdFix.Click += new System.EventHandler(this.cmdFix_Click);
            // 
            // _cmdSave
            // 
            this._cmdSave.BackColor = System.Drawing.SystemColors.Control;
            this._cmdSave.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdSave.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmdSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdSave.Location = new System.Drawing.Point(3, 525);
            this._cmdSave.Name = "_cmdSave";
            this._cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdSave.Size = new System.Drawing.Size(110, 25);
            this._cmdSave.TabIndex = 67;
            this._cmdSave.Text = "Save for LOC Fix";
            this._cmdSave.UseVisualStyleBackColor = false;
            this._cmdSave.Visible = false;
            this._cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // frameNASRUsing
            // 
            this.frameNASRUsing.BackColor = System.Drawing.SystemColors.Window;
            this.frameNASRUsing.Controls.Add(this._optNATable);
            this.frameNASRUsing.Controls.Add(this._optUSPSTable);
            this.frameNASRUsing.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frameNASRUsing.ForeColor = System.Drawing.SystemColors.ControlText;
            this.frameNASRUsing.Location = new System.Drawing.Point(8, 398);
            this.frameNASRUsing.Name = "frameNASRUsing";
            this.frameNASRUsing.Padding = new System.Windows.Forms.Padding(0);
            this.frameNASRUsing.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.frameNASRUsing.Size = new System.Drawing.Size(171, 57);
            this.frameNASRUsing.TabIndex = 31;
            this.frameNASRUsing.TabStop = false;
            this.frameNASRUsing.Text = "Use Auxiliary Table from";
            this.frameNASRUsing.Visible = false;
            // 
            // _optNATable
            // 
            this._optNATable.BackColor = System.Drawing.SystemColors.Window;
            this._optNATable.Checked = true;
            this._optNATable.Cursor = System.Windows.Forms.Cursors.Default;
            this._optNATable.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optNATable.ForeColor = System.Drawing.SystemColors.ControlText;
            this._optNATable.Location = new System.Drawing.Point(8, 16);
            this._optNATable.Name = "_optNATable";
            this._optNATable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optNATable.Size = new System.Drawing.Size(164, 17);
            this._optNATable.TabIndex = 33;
            this._optNATable.TabStop = true;
            this._optNATable.Text = "Pre-1999/post-2004 Almanac ";
            this._optNATable.UseVisualStyleBackColor = false;
            this._optNATable.CheckedChanged += new System.EventHandler(this.optNATable_CheckedChanged);
            // 
            // _optUSPSTable
            // 
            this._optUSPSTable.BackColor = System.Drawing.SystemColors.Window;
            this._optUSPSTable.Cursor = System.Windows.Forms.Cursors.Default;
            this._optUSPSTable.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optUSPSTable.ForeColor = System.Drawing.SystemColors.ControlText;
            this._optUSPSTable.Location = new System.Drawing.Point(8, 32);
            this._optUSPSTable.Name = "_optUSPSTable";
            this._optUSPSTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optUSPSTable.Size = new System.Drawing.Size(120, 17);
            this._optUSPSTable.TabIndex = 32;
            this._optUSPSTable.TabStop = true;
            this._optUSPSTable.Text = "1999-2004 Almanac";
            this._optUSPSTable.UseVisualStyleBackColor = false;
            this._optUSPSTable.CheckedChanged += new System.EventHandler(this.optUSPSTable_CheckedChanged);
            // 
            // _cmdNASR
            // 
            this._cmdNASR.BackColor = System.Drawing.SystemColors.Control;
            this._cmdNASR.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdNASR.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmdNASR.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdNASR.Location = new System.Drawing.Point(424, 52);
            this._cmdNASR.Name = "_cmdNASR";
            this._cmdNASR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdNASR.Size = new System.Drawing.Size(97, 25);
            this._cmdNASR.TabIndex = 30;
            this._cmdNASR.Text = "&NASR";
            this._cmdNASR.UseVisualStyleBackColor = false;
            this._cmdNASR.Click += new System.EventHandler(this.cmdNASR_Click);
            // 
            // _cmdLawOfCosines
            // 
            this._cmdLawOfCosines.BackColor = System.Drawing.SystemColors.Control;
            this._cmdLawOfCosines.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdLawOfCosines.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmdLawOfCosines.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdLawOfCosines.Location = new System.Drawing.Point(424, 24);
            this._cmdLawOfCosines.Name = "_cmdLawOfCosines";
            this._cmdLawOfCosines.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdLawOfCosines.Size = new System.Drawing.Size(97, 25);
            this._cmdLawOfCosines.TabIndex = 29;
            this._cmdLawOfCosines.Text = "&Law of Cosines";
            this._cmdLawOfCosines.UseVisualStyleBackColor = false;
            this._cmdLawOfCosines.Click += new System.EventHandler(this.cmdLawOfCosines_Click);
            // 
            // _cboDec
            // 
            this._cboDec.BackColor = System.Drawing.SystemColors.Window;
            this._cboDec.Cursor = System.Windows.Forms.Cursors.Default;
            this._cboDec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cboDec.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cboDec.ForeColor = System.Drawing.SystemColors.WindowText;
            this._cboDec.Items.AddRange(new object[] {
            "N",
            "S"});
            this._cboDec.Location = new System.Drawing.Point(120, 34);
            this._cboDec.Name = "_cboDec";
            this._cboDec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cboDec.Size = new System.Drawing.Size(41, 22);
            this._cboDec.TabIndex = 4;
            this._cboDec.SelectedIndexChanged += new System.EventHandler(this.CboDec_SelectedIndexChanged);
            // 
            // cboL
            // 
            this.cboL.BackColor = System.Drawing.SystemColors.Window;
            this.cboL.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboL.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboL.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboL.Items.AddRange(new object[] {
            "N",
            "S"});
            this.cboL.Location = new System.Drawing.Point(336, 8);
            this.cboL.Name = "cboL";
            this.cboL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboL.Size = new System.Drawing.Size(41, 22);
            this.cboL.TabIndex = 9;
            // 
            // cboLo
            // 
            this.cboLo.BackColor = System.Drawing.SystemColors.Window;
            this.cboLo.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboLo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLo.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboLo.Items.AddRange(new object[] {
            "W",
            "E"});
            this.cboLo.Location = new System.Drawing.Point(336, 31);
            this.cboLo.Name = "cboLo";
            this.cboLo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboLo.Size = new System.Drawing.Size(41, 22);
            this.cboLo.TabIndex = 12;
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.SystemColors.Window;
            this.Label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label6.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label6.Location = new System.Drawing.Point(427, 6);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label6.Size = new System.Drawing.Size(213, 17);
            this.Label6.TabIndex = 48;
            this.Label6.Text = "Select Sight Reduction Method";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.SystemColors.Window;
            this.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label5.Location = new System.Drawing.Point(8, 81);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label5.Size = new System.Drawing.Size(281, 34);
            this.Label5.TabIndex = 36;
            this.Label5.Text = "To use LHA instead of GHA, enter LHA  in place of GHA and set DR Lo to zero or le" +
    "ave blank.";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.SystemColors.Window;
            this.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label4.Location = new System.Drawing.Point(290, 81);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label4.Size = new System.Drawing.Size(231, 34);
            this.Label4.TabIndex = 35;
            this.Label4.Text = "Time is only required for establishing a fix from a moving vessel using Law of Co" +
    "sines.";
            // 
            // lblHoMin
            // 
            this.lblHoMin.BackColor = System.Drawing.SystemColors.Window;
            this.lblHoMin.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblHoMin.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoMin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHoMin.Location = new System.Drawing.Point(113, 58);
            this.lblHoMin.Name = "lblHoMin";
            this.lblHoMin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHoMin.Size = new System.Drawing.Size(9, 17);
            this.lblHoMin.TabIndex = 28;
            this.lblHoMin.Text = "\'";
            // 
            // lblDecMin
            // 
            this.lblDecMin.BackColor = System.Drawing.SystemColors.Window;
            this.lblDecMin.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDecMin.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecMin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDecMin.Location = new System.Drawing.Point(113, 34);
            this.lblDecMin.Name = "lblDecMin";
            this.lblDecMin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDecMin.Size = new System.Drawing.Size(9, 17);
            this.lblDecMin.TabIndex = 27;
            this.lblDecMin.Text = "\'";
            // 
            // lblGHAMin
            // 
            this.lblGHAMin.BackColor = System.Drawing.SystemColors.Window;
            this.lblGHAMin.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblGHAMin.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGHAMin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGHAMin.Location = new System.Drawing.Point(113, 10);
            this.lblGHAMin.Name = "lblGHAMin";
            this.lblGHAMin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblGHAMin.Size = new System.Drawing.Size(9, 17);
            this.lblGHAMin.TabIndex = 26;
            this.lblGHAMin.Text = "\'";
            // 
            // lblHoDeg
            // 
            this.lblHoDeg.BackColor = System.Drawing.SystemColors.Window;
            this.lblHoDeg.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblHoDeg.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoDeg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHoDeg.Location = new System.Drawing.Point(73, 58);
            this.lblHoDeg.Name = "lblHoDeg";
            this.lblHoDeg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHoDeg.Size = new System.Drawing.Size(9, 17);
            this.lblHoDeg.TabIndex = 25;
            this.lblHoDeg.Text = "°";
            // 
            // lblDecDeg
            // 
            this.lblDecDeg.BackColor = System.Drawing.SystemColors.Window;
            this.lblDecDeg.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDecDeg.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecDeg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDecDeg.Location = new System.Drawing.Point(73, 34);
            this.lblDecDeg.Name = "lblDecDeg";
            this.lblDecDeg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDecDeg.Size = new System.Drawing.Size(9, 17);
            this.lblDecDeg.TabIndex = 24;
            this.lblDecDeg.Text = "°";
            // 
            // lblGHADeg
            // 
            this.lblGHADeg.BackColor = System.Drawing.SystemColors.Window;
            this.lblGHADeg.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblGHADeg.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGHADeg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGHADeg.Location = new System.Drawing.Point(73, 10);
            this.lblGHADeg.Name = "lblGHADeg";
            this.lblGHADeg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblGHADeg.Size = new System.Drawing.Size(9, 17);
            this.lblGHADeg.TabIndex = 23;
            this.lblGHADeg.Text = "°";
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.SystemColors.Window;
            this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label3.Location = new System.Drawing.Point(8, 59);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(25, 17);
            this.Label3.TabIndex = 22;
            this.Label3.Text = "Ho";
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.SystemColors.Window;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(7, 36);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(33, 17);
            this.Label2.TabIndex = 21;
            this.Label2.Text = "Dec";
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.Window;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(7, 12);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(33, 17);
            this.Label1.TabIndex = 20;
            this.Label1.Text = "GHA";
            // 
            // lblDRL
            // 
            this.lblDRL.BackColor = System.Drawing.SystemColors.Window;
            this.lblDRL.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDRL.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDRL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDRL.Location = new System.Drawing.Point(216, 8);
            this.lblDRL.Name = "lblDRL";
            this.lblDRL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDRL.Size = new System.Drawing.Size(32, 17);
            this.lblDRL.TabIndex = 19;
            this.lblDRL.Text = "DR L";
            // 
            // lblLDeg
            // 
            this.lblLDeg.BackColor = System.Drawing.SystemColors.Window;
            this.lblLDeg.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLDeg.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLDeg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLDeg.Location = new System.Drawing.Point(289, 8);
            this.lblLDeg.Name = "lblLDeg";
            this.lblLDeg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLDeg.Size = new System.Drawing.Size(9, 17);
            this.lblLDeg.TabIndex = 18;
            this.lblLDeg.Text = "°";
            // 
            // lblLMin
            // 
            this.lblLMin.BackColor = System.Drawing.SystemColors.Window;
            this.lblLMin.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLMin.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLMin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLMin.Location = new System.Drawing.Point(329, 8);
            this.lblLMin.Name = "lblLMin";
            this.lblLMin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLMin.Size = new System.Drawing.Size(9, 17);
            this.lblLMin.TabIndex = 17;
            this.lblLMin.Text = "\'";
            // 
            // lblDRLo
            // 
            this.lblDRLo.BackColor = System.Drawing.SystemColors.Window;
            this.lblDRLo.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDRLo.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDRLo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDRLo.Location = new System.Drawing.Point(216, 32);
            this.lblDRLo.Name = "lblDRLo";
            this.lblDRLo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDRLo.Size = new System.Drawing.Size(36, 17);
            this.lblDRLo.TabIndex = 16;
            this.lblDRLo.Text = "DR Lo";
            // 
            // lblLoDeg
            // 
            this.lblLoDeg.BackColor = System.Drawing.SystemColors.Window;
            this.lblLoDeg.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLoDeg.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoDeg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLoDeg.Location = new System.Drawing.Point(289, 32);
            this.lblLoDeg.Name = "lblLoDeg";
            this.lblLoDeg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLoDeg.Size = new System.Drawing.Size(9, 17);
            this.lblLoDeg.TabIndex = 15;
            this.lblLoDeg.Text = "°";
            // 
            // lblLoMin
            // 
            this.lblLoMin.BackColor = System.Drawing.SystemColors.Window;
            this.lblLoMin.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLoMin.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoMin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLoMin.Location = new System.Drawing.Point(329, 32);
            this.lblLoMin.Name = "lblLoMin";
            this.lblLoMin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLoMin.Size = new System.Drawing.Size(9, 17);
            this.lblLoMin.TabIndex = 14;
            this.lblLoMin.Text = "\'";
            // 
            // SRLgTxtBx
            // 
            this.SRLgTxtBx.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SRLgTxtBx.Location = new System.Drawing.Point(2, 207);
            this.SRLgTxtBx.Name = "SRLgTxtBx";
            this.SRLgTxtBx.ReadOnly = true;
            this.SRLgTxtBx.Size = new System.Drawing.Size(669, 258);
            this.SRLgTxtBx.TabIndex = 74;
            this.SRLgTxtBx.Text = "";
            // 
            // _ExitBtn
            // 
            this._ExitBtn.BackColor = System.Drawing.Color.Red;
            this._ExitBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this._ExitBtn.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ExitBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this._ExitBtn.Location = new System.Drawing.Point(591, 468);
            this._ExitBtn.Name = "_ExitBtn";
            this._ExitBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._ExitBtn.Size = new System.Drawing.Size(70, 25);
            this._ExitBtn.TabIndex = 75;
            this._ExitBtn.Text = "Exit";
            this._ExitBtn.UseVisualStyleBackColor = false;
            this._ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // SRHdrTxtBx
            // 
            this.SRHdrTxtBx.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SRHdrTxtBx.Location = new System.Drawing.Point(1, 180);
            this.SRHdrTxtBx.Name = "SRHdrTxtBx";
            this.SRHdrTxtBx.ReadOnly = true;
            this.SRHdrTxtBx.Size = new System.Drawing.Size(671, 24);
            this.SRHdrTxtBx.TabIndex = 76;
            this.SRHdrTxtBx.Text = "";
            // 
            // SRLeftTxtBx
            // 
            this.SRLeftTxtBx.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SRLeftTxtBx.Location = new System.Drawing.Point(1, 207);
            this.SRLeftTxtBx.Name = "SRLeftTxtBx";
            this.SRLeftTxtBx.ReadOnly = true;
            this.SRLeftTxtBx.Size = new System.Drawing.Size(184, 255);
            this.SRLeftTxtBx.TabIndex = 77;
            this.SRLeftTxtBx.Text = "";
            // 
            // SRRightTxtBx
            // 
            this.SRRightTxtBx.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SRRightTxtBx.Location = new System.Drawing.Point(183, 207);
            this.SRRightTxtBx.Name = "SRRightTxtBx";
            this.SRRightTxtBx.ReadOnly = true;
            this.SRRightTxtBx.Size = new System.Drawing.Size(489, 255);
            this.SRRightTxtBx.TabIndex = 78;
            this.SRRightTxtBx.Text = "";
            // 
            // NASRAsmTxtBx
            // 
            this.NASRAsmTxtBx.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NASRAsmTxtBx.Location = new System.Drawing.Point(315, 214);
            this.NASRAsmTxtBx.Name = "NASRAsmTxtBx";
            this.NASRAsmTxtBx.ReadOnly = true;
            this.NASRAsmTxtBx.Size = new System.Drawing.Size(230, 22);
            this.NASRAsmTxtBx.TabIndex = 79;
            this.NASRAsmTxtBx.Text = "";
            this.NASRAsmTxtBx.Visible = false;
            // 
            // NASRAFTxtBx
            // 
            this.NASRAFTxtBx.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NASRAFTxtBx.Location = new System.Drawing.Point(332, 279);
            this.NASRAFTxtBx.Name = "NASRAFTxtBx";
            this.NASRAFTxtBx.ReadOnly = true;
            this.NASRAFTxtBx.Size = new System.Drawing.Size(193, 22);
            this.NASRAFTxtBx.TabIndex = 80;
            this.NASRAFTxtBx.Text = "";
            this.NASRAFTxtBx.Visible = false;
            // 
            // DCorrTxtBx
            // 
            this.DCorrTxtBx.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DCorrTxtBx.Location = new System.Drawing.Point(191, 302);
            this.DCorrTxtBx.Name = "DCorrTxtBx";
            this.DCorrTxtBx.ReadOnly = true;
            this.DCorrTxtBx.Size = new System.Drawing.Size(259, 37);
            this.DCorrTxtBx.TabIndex = 81;
            this.DCorrTxtBx.Text = "";
            this.DCorrTxtBx.Visible = false;
            // 
            // optFull
            // 
            this.optFull.AutoSize = true;
            this.optFull.Checked = true;
            this.optFull.Location = new System.Drawing.Point(6, 20);
            this.optFull.Name = "optFull";
            this.optFull.Size = new System.Drawing.Size(41, 17);
            this.optFull.TabIndex = 82;
            this.optFull.TabStop = true;
            this.optFull.Text = "Full";
            this.optFull.UseVisualStyleBackColor = true;
            // 
            // GroupBoxPrecision
            // 
            this.GroupBoxPrecision.Controls.Add(this.optRound);
            this.GroupBoxPrecision.Controls.Add(this.optFull);
            this.GroupBoxPrecision.Location = new System.Drawing.Point(16, 231);
            this.GroupBoxPrecision.Name = "GroupBoxPrecision";
            this.GroupBoxPrecision.Size = new System.Drawing.Size(232, 38);
            this.GroupBoxPrecision.TabIndex = 83;
            this.GroupBoxPrecision.TabStop = false;
            this.GroupBoxPrecision.Text = "Precision to use for subsequent calculations";
            this.GroupBoxPrecision.Visible = false;
            // 
            // optRound
            // 
            this.optRound.AutoSize = true;
            this.optRound.Location = new System.Drawing.Point(54, 20);
            this.optRound.Name = "optRound";
            this.optRound.Size = new System.Drawing.Size(173, 17);
            this.optRound.TabIndex = 83;
            this.optRound.TabStop = true;
            this.optRound.Text = "Rounded to five decimal places";
            this.optRound.UseVisualStyleBackColor = true;
            // 
            // WeemsPVTxtBx
            // 
            this.WeemsPVTxtBx.Location = new System.Drawing.Point(191, 409);
            this.WeemsPVTxtBx.Multiline = true;
            this.WeemsPVTxtBx.Name = "WeemsPVTxtBx";
            this.WeemsPVTxtBx.Size = new System.Drawing.Size(267, 50);
            this.WeemsPVTxtBx.TabIndex = 84;
            this.WeemsPVTxtBx.Visible = false;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::CelestialTools.My.Resources.Resources.ABC_white;
            this.PictureBox1.Location = new System.Drawing.Point(132, 525);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(413, 50);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 102;
            this.PictureBox1.TabStop = false;
            // 
            // DTSight
            // 
            this.DTSight.CustomFormat = "MM / dd / yyyy HH:mm:ss ";
            this.DTSight.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DTSight.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTSight.Location = new System.Drawing.Point(254, 58);
            this.DTSight.Name = "DTSight";
            this.DTSight.ShowUpDown = true;
            this.DTSight.Size = new System.Drawing.Size(146, 21);
            this.DTSight.TabIndex = 126;
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.SystemColors.Window;
            this.lblDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDate.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDate.Location = new System.Drawing.Point(167, 58);
            this.lblDate.Name = "lblDate";
            this.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDate.Size = new System.Drawing.Size(85, 22);
            this.lblDate.TabIndex = 125;
            this.lblDate.Text = "Sight Date/Time";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _btnUseCLS
            // 
            this._btnUseCLS.BackColor = System.Drawing.Color.Yellow;
            this._btnUseCLS.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnUseCLS.ForeColor = System.Drawing.SystemColors.WindowText;
            this._btnUseCLS.Location = new System.Drawing.Point(564, 502);
            this._btnUseCLS.Name = "_btnUseCLS";
            this._btnUseCLS.Size = new System.Drawing.Size(100, 23);
            this._btnUseCLS.TabIndex = 174;
            this._btnUseCLS.Text = "CLS Form Plot";
            this._btnUseCLS.UseVisualStyleBackColor = false;
            this._btnUseCLS.Visible = false;
            this._btnUseCLS.Click += new System.EventHandler(this.btnUseCLS_Click);
            // 
            // _btnCustomPlot
            // 
            this._btnCustomPlot.BackColor = System.Drawing.Color.Yellow;
            this._btnCustomPlot.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnCustomPlot.ForeColor = System.Drawing.SystemColors.WindowText;
            this._btnCustomPlot.Location = new System.Drawing.Point(564, 528);
            this._btnCustomPlot.Name = "_btnCustomPlot";
            this._btnCustomPlot.Size = new System.Drawing.Size(100, 23);
            this._btnCustomPlot.TabIndex = 175;
            this._btnCustomPlot.Text = "Custom Plot Form";
            this._btnCustomPlot.UseVisualStyleBackColor = false;
            this._btnCustomPlot.Visible = false;
            this._btnCustomPlot.Click += new System.EventHandler(this.btnCustomPlot_Click);
            // 
            // _cmdMerDiag
            // 
            this._cmdMerDiag.BackColor = System.Drawing.Color.Yellow;
            this._cmdMerDiag.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmdMerDiag.ForeColor = System.Drawing.SystemColors.WindowText;
            this._cmdMerDiag.Location = new System.Drawing.Point(564, 553);
            this._cmdMerDiag.Name = "_cmdMerDiag";
            this._cmdMerDiag.Size = new System.Drawing.Size(100, 23);
            this._cmdMerDiag.TabIndex = 177;
            this._cmdMerDiag.Text = "Meridian Diagram";
            this._cmdMerDiag.UseVisualStyleBackColor = false;
            this._cmdMerDiag.Visible = false;
            this._cmdMerDiag.Click += new System.EventHandler(this.cmdMerDiag_Click_1);
            // 
            // txtUserInfo
            // 
            this.txtUserInfo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserInfo.HideSelection = false;
            this.txtUserInfo.Location = new System.Drawing.Point(250, 469);
            this.txtUserInfo.Name = "txtUserInfo";
            this.txtUserInfo.Size = new System.Drawing.Size(335, 22);
            this.txtUserInfo.TabIndex = 202;
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.Location = new System.Drawing.Point(190, 472);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(57, 15);
            this.Label16.TabIndex = 201;
            this.Label16.Text = "User Info";
            this.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboLLoBy
            // 
            this.cboLLoBy.BackColor = System.Drawing.SystemColors.Window;
            this.cboLLoBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLLoBy.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLLoBy.FormattingEnabled = true;
            this.cboLLoBy.Items.AddRange(new object[] {
            "DR",
            "GPS",
            "KP"});
            this.cboLLoBy.Location = new System.Drawing.Point(436, 9);
            this.cboLLoBy.Name = "cboLLoBy";
            this.cboLLoBy.Size = new System.Drawing.Size(70, 22);
            this.cboLLoBy.TabIndex = 204;
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label17.Location = new System.Drawing.Point(389, 13);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(46, 14);
            this.Label17.TabIndex = 203;
            this.Label17.Text = "L/Lo by:";
            this.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpSLInfo
            // 
            this.grpSLInfo.BackColor = System.Drawing.SystemColors.Info;
            this.grpSLInfo.Controls.Add(this.lblBodyNm);
            this.grpSLInfo.Controls.Add(this.lblLimb);
            this.grpSLInfo.Controls.Add(this.cbLimb);
            this.grpSLInfo.Controls.Add(this.cboBody);
            this.grpSLInfo.Controls.Add(this.Label17);
            this.grpSLInfo.Controls.Add(this.cboLLoBy);
            this.grpSLInfo.Location = new System.Drawing.Point(7, 118);
            this.grpSLInfo.Name = "grpSLInfo";
            this.grpSLInfo.Size = new System.Drawing.Size(515, 35);
            this.grpSLInfo.TabIndex = 205;
            this.grpSLInfo.TabStop = false;
            this.grpSLInfo.Text = "SightLog Info";
            this.grpSLInfo.Visible = false;
            // 
            // lblBodyNm
            // 
            this.lblBodyNm.BackColor = System.Drawing.SystemColors.Control;
            this.lblBodyNm.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblBodyNm.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBodyNm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBodyNm.Location = new System.Drawing.Point(49, 14);
            this.lblBodyNm.Name = "lblBodyNm";
            this.lblBodyNm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBodyNm.Size = new System.Drawing.Size(45, 17);
            this.lblBodyNm.TabIndex = 208;
            this.lblBodyNm.Text = "Body";
            this.lblBodyNm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLimb
            // 
            this.lblLimb.BackColor = System.Drawing.SystemColors.Control;
            this.lblLimb.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLimb.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimb.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLimb.Location = new System.Drawing.Point(248, 12);
            this.lblLimb.Name = "lblLimb";
            this.lblLimb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLimb.Size = new System.Drawing.Size(38, 17);
            this.lblLimb.TabIndex = 207;
            this.lblLimb.Text = "Limb";
            this.lblLimb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbLimb
            // 
            this.cbLimb.BackColor = System.Drawing.SystemColors.Window;
            this.cbLimb.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbLimb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLimb.Enabled = false;
            this.cbLimb.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLimb.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbLimb.Items.AddRange(new object[] {
            "Lower",
            "Upper",
            "Center"});
            this.cbLimb.Location = new System.Drawing.Point(288, 9);
            this.cbLimb.Name = "cbLimb";
            this.cbLimb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbLimb.Size = new System.Drawing.Size(100, 22);
            this.cbLimb.TabIndex = 206;
            // 
            // cboBody
            // 
            this.cboBody.BackColor = System.Drawing.SystemColors.Window;
            this.cboBody.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboBody.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBody.Enabled = false;
            this.cboBody.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBody.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboBody.Items.AddRange(new object[] {
            "Sun",
            "Moon",
            "Venus",
            "Mars",
            "Jupiter",
            "Saturn",
            "Acamar",
            "Achernar",
            "Acrux",
            "Adhara",
            "Aldebaran",
            "Alioth",
            "Alkaid",
            "Al Na\'ir",
            "Alnilam",
            "Alphard",
            "Alphecca",
            "Alpheratz",
            "Altair",
            "Ankaa",
            "Antares",
            "Arcturus",
            "Atria",
            "Avior",
            "Bellatrix",
            "Betelgeuse",
            "Canopus",
            "Capella",
            "Deneb",
            "Denebola",
            "Diphda",
            "Dubhe",
            "Elnath",
            "Eltanin",
            "Enif",
            "Fomalhaut",
            "Gacrux",
            "Gienah",
            "Hadar",
            "Hamal",
            "Kaus Australis",
            "Kochab",
            "Markab",
            "Menkar",
            "Menkent",
            "Miaplacidus",
            "Mirfak",
            "Nunki",
            "Peacock",
            "Polaris",
            "Pollux",
            "Procyon",
            "Rasalhague",
            "Regulus",
            "Rigel",
            "Rigil Kentaurus",
            "Sabik",
            "Schedar",
            "Shaula",
            "Sirius",
            "Spica",
            "Suhail",
            "Vega",
            "Zubenelgenubi\t"});
            this.cboBody.Location = new System.Drawing.Point(95, 9);
            this.cboBody.Name = "cboBody";
            this.cboBody.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboBody.Size = new System.Drawing.Size(150, 22);
            this.cboBody.TabIndex = 205;
            // 
            // _btnNASRFix
            // 
            this._btnNASRFix.BackColor = System.Drawing.SystemColors.Control;
            this._btnNASRFix.Cursor = System.Windows.Forms.Cursors.Default;
            this._btnNASRFix.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnNASRFix.ForeColor = System.Drawing.SystemColors.ControlText;
            this._btnNASRFix.Location = new System.Drawing.Point(3, 553);
            this._btnNASRFix.Name = "_btnNASRFix";
            this._btnNASRFix.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._btnNASRFix.Size = new System.Drawing.Size(110, 25);
            this._btnNASRFix.TabIndex = 206;
            this._btnNASRFix.Text = "Save for NASR Fix";
            this._btnNASRFix.UseVisualStyleBackColor = false;
            this._btnNASRFix.Visible = false;
            this._btnNASRFix.Click += new System.EventHandler(this.btnNASRFix_Click);
            // 
            // FormAltSR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(672, 585);
            this.Controls.Add(this._btnNASRFix);
            this.Controls.Add(this.grpSLInfo);
            this.Controls.Add(this.txtUserInfo);
            this.Controls.Add(this.Label16);
            this.Controls.Add(this._cmdMerDiag);
            this.Controls.Add(this._btnCustomPlot);
            this.Controls.Add(this._btnUseCLS);
            this.Controls.Add(this.DTSight);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.WeemsPVTxtBx);
            this.Controls.Add(this.GroupBoxPrecision);
            this.Controls.Add(this.DCorrTxtBx);
            this.Controls.Add(this.NASRAFTxtBx);
            this.Controls.Add(this.NASRAsmTxtBx);
            this.Controls.Add(this.SRRightTxtBx);
            this.Controls.Add(this.SRHdrTxtBx);
            this.Controls.Add(this._ExitBtn);
            this.Controls.Add(this._chkInterpolateB);
            this.Controls.Add(this._cmdWeems);
            this.Controls.Add(this.frameS);
            this.Controls.Add(this._cmdSTable);
            this.Controls.Add(this._chkSadler);
            this.Controls.Add(this.frame214);
            this.Controls.Add(this._chkDSD);
            this.Controls.Add(this.frame211);
            this.Controls.Add(this._cmd208);
            this.Controls.Add(this._cmd211);
            this.Controls.Add(this._cmd214);
            this.Controls.Add(this._cmd229);
            this.Controls.Add(this._cmd249);
            this.Controls.Add(this._cmdClearSome);
            this.Controls.Add(this._cmdClear);
            this.Controls.Add(this._cmdFix);
            this.Controls.Add(this._cmdSave);
            this.Controls.Add(this.frameNASRUsing);
            this.Controls.Add(this._cmdPrint);
            this.Controls.Add(this._cmdNASR);
            this.Controls.Add(this._cmdLawOfCosines);
            this.Controls.Add(this._cboDec);
            this.Controls.Add(this._txtHoMin);
            this.Controls.Add(this._txtDecMin);
            this.Controls.Add(this._txtGHAMin);
            this.Controls.Add(this._txtHoDeg);
            this.Controls.Add(this._txtDecDeg);
            this.Controls.Add(this._txtGHADeg);
            this.Controls.Add(this._txtLMin);
            this.Controls.Add(this.cboL);
            this.Controls.Add(this._txtLoDeg);
            this.Controls.Add(this._txtLoMin);
            this.Controls.Add(this.cboLo);
            this.Controls.Add(this._txtLDeg);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.lblHoMin);
            this.Controls.Add(this.lblDecMin);
            this.Controls.Add(this.lblGHAMin);
            this.Controls.Add(this.lblHoDeg);
            this.Controls.Add(this.lblDecDeg);
            this.Controls.Add(this.lblGHADeg);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.lblDRL);
            this.Controls.Add(this.lblLDeg);
            this.Controls.Add(this.lblLMin);
            this.Controls.Add(this.lblDRLo);
            this.Controls.Add(this.lblLoDeg);
            this.Controls.Add(this.lblLoMin);
            this.Controls.Add(this.SRLgTxtBx);
            this.Controls.Add(this.SRLeftTxtBx);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(61, 187);
            this.MaximizeBox = false;
            this.Name = "FormAltSR";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sight Reduction Methods";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAltSR_FormClosed);
            this.Load += new System.EventHandler(this.FormAltSR_Load);
            this.frameS.ResumeLayout(false);
            this.frame214.ResumeLayout(false);
            this.frame211.ResumeLayout(false);
            this.frameNASRUsing.ResumeLayout(false);
            this.GroupBoxPrecision.ResumeLayout(false);
            this.GroupBoxPrecision.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.grpSLInfo.ResumeLayout(false);
            this.grpSLInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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