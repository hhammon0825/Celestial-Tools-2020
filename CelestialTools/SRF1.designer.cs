using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    [DesignerGenerated()]
    internal partial class FormSRF
    {
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        [DebuggerNonUserCode()]
        public FormSRF() : base()
        {
            // This is required by the Windows Form Designer.
            InitializeComponent();
            // Form_Initialize_Renamed()
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
        public ToolTip ToolTipFormSRF;
        public ComboBox cboStars;
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

        public ComboBox cboL;
        public ComboBox cboSun;
        public CheckBox chkDST;
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

        private RadioButton _optHoParameters;

        public RadioButton optHoParameters
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optHoParameters;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optHoParameters != null)
                {
                    _optHoParameters.CheckedChanged -= optHoParameters_CheckedChanged;
                }

                _optHoParameters = value;
                if (_optHoParameters != null)
                {
                    _optHoParameters.CheckedChanged += optHoParameters_CheckedChanged;
                }
            }
        }

        private RadioButton _optHoSRForm;

        public RadioButton optHoSRForm
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optHoSRForm;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optHoSRForm != null)
                {
                    _optHoSRForm.CheckedChanged -= optHoSRForm_CheckedChanged;
                }

                _optHoSRForm = value;
                if (_optHoSRForm != null)
                {
                    _optHoSRForm.CheckedChanged += optHoSRForm_CheckedChanged;
                }
            }
        }

        private TextBox _txtSightNo;

        public TextBox txtSightNo
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtSightNo;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtSightNo != null)
                {
                    _txtSightNo.KeyPress -= txtSightNo_KeyPress;
                    _txtSightNo.Enter -= txtSightNo_Enter;
                }

                _txtSightNo = value;
                if (_txtSightNo != null)
                {
                    _txtSightNo.KeyPress += txtSightNo_KeyPress;
                    _txtSightNo.Enter += txtSightNo_Enter;
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

        public ComboBox cboZDm;
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

        private ComboBox _cboPolaris;

        public ComboBox cboPolaris
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboPolaris;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboPolaris != null)
                {
                    _cboPolaris.SelectedIndexChanged -= cboPolaris_SelectedIndexChanged;
                }

                _cboPolaris = value;
                if (_cboPolaris != null)
                {
                    _cboPolaris.SelectedIndexChanged += cboPolaris_SelectedIndexChanged;
                }
            }
        }

        public ComboBox cboDsUnit;
        private TextBox _txtDsDist;

        public TextBox txtDsDist
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtDsDist;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtDsDist != null)
                {
                    _txtDsDist.KeyPress -= txtDsDist_KeyPress;
                    _txtDsDist.Enter -= txtDsDist_Enter;
                }

                _txtDsDist = value;
                if (_txtDsDist != null)
                {
                    _txtDsDist.KeyPress += txtDsDist_KeyPress;
                    _txtDsDist.Enter += txtDsDist_Enter;
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

        public Panel Framehs;
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

        public Panel FrameZD;
        private Button _cmdReduce;

        public Button cmdReduce
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdReduce;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdReduce != null)
                {
                    _cmdReduce.Click -= cmdReduce_Click;
                }

                _cmdReduce = value;
                if (_cmdReduce != null)
                {
                    _cmdReduce.Click += cmdReduce_Click;
                }
            }
        }

        private ComboBox _cboPressure;

        public ComboBox cboPressure
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboPressure;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboPressure != null)
                {
                    _cboPressure.SelectedIndexChanged -= cboPressure_SelectedIndexChanged;
                }

                _cboPressure = value;
                if (_cboPressure != null)
                {
                    _cboPressure.SelectedIndexChanged += cboPressure_SelectedIndexChanged;
                }
            }
        }

        private TextBox _txtPressure;

        public TextBox txtPressure
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtPressure;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtPressure != null)
                {
                    _txtPressure.TextChanged -= txtPressure_TextChanged;
                    _txtPressure.KeyPress -= txtPressure_KeyPress;
                    _txtPressure.Enter -= txtPressure_Enter;
                }

                _txtPressure = value;
                if (_txtPressure != null)
                {
                    _txtPressure.TextChanged += txtPressure_TextChanged;
                    _txtPressure.KeyPress += txtPressure_KeyPress;
                    _txtPressure.Enter += txtPressure_Enter;
                }
            }
        }

        private ComboBox _cboTemperature;

        public ComboBox cboTemperature
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboTemperature;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboTemperature != null)
                {
                    _cboTemperature.SelectedIndexChanged -= cboTemperature_SelectedIndexChanged;
                }

                _cboTemperature = value;
                if (_cboTemperature != null)
                {
                    _cboTemperature.SelectedIndexChanged += cboTemperature_SelectedIndexChanged;
                }
            }
        }

        private TextBox _txtTemperature;

        public TextBox txtTemperature
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtTemperature;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtTemperature != null)
                {
                    _txtTemperature.TextChanged -= txtTemperature_TextChanged;
                    _txtTemperature.Enter -= txtTemperature_Enter;
                }

                _txtTemperature = value;
                if (_txtTemperature != null)
                {
                    _txtTemperature.TextChanged += txtTemperature_TextChanged;
                    _txtTemperature.Enter += txtTemperature_Enter;
                }
            }
        }

        public ComboBox cboIE;
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
                    _txtIEmin.Enter -= txtIEmin_Enter;
                    _txtIEmin.KeyPress -= txtIEmin_KeyPress;
                    _txtIEmin.Validating -= txtIEmin_Validating;
                }

                _txtIEmin = value;
                if (_txtIEmin != null)
                {
                    _txtIEmin.TextChanged += txtIEmin_TextChanged;
                    _txtIEmin.Enter += txtIEmin_Enter;
                    _txtIEmin.KeyPress += txtIEmin_KeyPress;
                    _txtIEmin.Validating += txtIEmin_Validating;
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

        private ComboBox _cboBody;

        public ComboBox cboBody
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboBody;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboBody != null)
                {
                    _cboBody.SelectedIndexChanged -= cboBody_SelectedIndexChanged;
                }

                _cboBody = value;
                if (_cboBody != null)
                {
                    _cboBody.SelectedIndexChanged += cboBody_SelectedIndexChanged;
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

        public ComboBox cboWE;
        private TextBox _txtWESec;

        public TextBox txtWESec
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtWESec;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtWESec != null)
                {
                    _txtWESec.TextChanged -= txtWESec_TextChanged;
                    _txtWESec.KeyPress -= txtWESec_KeyPress;
                    _txtWESec.Validating -= txtWESec_Validating;
                    _txtWESec.Enter -= txtWESec_Enter;
                }

                _txtWESec = value;
                if (_txtWESec != null)
                {
                    _txtWESec.TextChanged += txtWESec_TextChanged;
                    _txtWESec.KeyPress += txtWESec_KeyPress;
                    _txtWESec.Validating += txtWESec_Validating;
                    _txtWESec.Enter += txtWESec_Enter;
                }
            }
        }

        private TextBox _txtWEMin;

        public TextBox txtWEMin
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtWEMin;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtWEMin != null)
                {
                    _txtWEMin.TextChanged -= txtWEMin_TextChanged;
                    _txtWEMin.KeyPress -= txtWEMin_KeyPress;
                    _txtWEMin.Enter -= txtWEMin_Enter;
                }

                _txtWEMin = value;
                if (_txtWEMin != null)
                {
                    _txtWEMin.TextChanged += txtWEMin_TextChanged;
                    _txtWEMin.KeyPress += txtWEMin_KeyPress;
                    _txtWEMin.Enter += txtWEMin_Enter;
                }
            }
        }

        private RadioButton _optStdTPNo;

        public RadioButton optStdTPNo
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optStdTPNo;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optStdTPNo != null)
                {
                    _optStdTPNo.CheckedChanged -= optStdTPNo_CheckedChanged;
                }

                _optStdTPNo = value;
                if (_optStdTPNo != null)
                {
                    _optStdTPNo.CheckedChanged += optStdTPNo_CheckedChanged;
                }
            }
        }

        private RadioButton _optStdTPYes;

        public RadioButton optStdTPYes
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optStdTPYes;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optStdTPYes != null)
                {
                    _optStdTPYes.CheckedChanged -= optStdTPYes_CheckedChanged;
                }

                _optStdTPYes = value;
                if (_optStdTPYes != null)
                {
                    _optStdTPYes.CheckedChanged += optStdTPYes_CheckedChanged;
                }
            }
        }

        public Panel FrameTP;
        public Panel FrameHo;
        public Label lblZDDST;
        public Label lblIEsec;
        public Label lblHoCorrs;
        public Label lblSightNo;
        public Label lblIEdeg;
        public Label lblZDm;
        public Label lblZDh;
        public Label lblDsDist;
        public Label lblHorizon;
        public Label lblPressure;
        public Label lblTempDeg;
        public Label lblTemperature;
        public Label lblStdT_P;
        public Label lblIEMin;
        public Label lblIE;
        public Label lblHE;
        public Label lblHsSec;
        public Label lblHsMin;
        public Label lblHsDeg;
        public Label lblHs;
        public Label lblHsFormat;
        public Label lblLoMin;
        public Label lblLoDeg;
        public Label lblDRLo;
        public Label lblLMin;
        public Label lblLDeg;
        public Label lblDRL;
        public Label lblBody;
        public Label lblZD;
        public Label lblZDAutoManual;
        public Label lblWEsec;
        public Label lblWEmin;
        public Label lblWE;
        // Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSRF));
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            var DataGridViewCellStyle4 = new DataGridViewCellStyle();
            var DataGridViewCellStyle5 = new DataGridViewCellStyle();
            ToolTipFormSRF = new ToolTip(components);
            chkDST = new CheckBox();
            _txtIESec = new TextBox();
            _txtIESec.TextChanged += new EventHandler(txtIESec_TextChanged);
            _txtIESec.KeyPress += new KeyPressEventHandler(txtIESec_KeyPress);
            _txtIESec.Validating += new System.ComponentModel.CancelEventHandler(txtIESec_Validating);
            _txtIESec.Enter += new EventHandler(txtIESec_Enter);
            _optHoParameters = new RadioButton();
            _optHoParameters.CheckedChanged += new EventHandler(optHoParameters_CheckedChanged);
            _optHoSRForm = new RadioButton();
            _optHoSRForm.CheckedChanged += new EventHandler(optHoSRForm_CheckedChanged);
            _txtSightNo = new TextBox();
            _txtSightNo.KeyPress += new KeyPressEventHandler(txtSightNo_KeyPress);
            _txtSightNo.Enter += new EventHandler(txtSightNo_Enter);
            _cmdPrint = new Button();
            _cmdPrint.Click += new EventHandler(cmdPrint_Click);
            _txtIEdeg = new TextBox();
            _txtIEdeg.TextChanged += new EventHandler(txtIEdeg_TextChanged);
            _txtIEdeg.KeyPress += new KeyPressEventHandler(txtIEdeg_KeyPress);
            _txtIEdeg.Validating += new System.ComponentModel.CancelEventHandler(txtIEdeg_Validating);
            _txtIEdeg.Enter += new EventHandler(txtIEDeg_Enter);
            _txtLDeg = new TextBox();
            _txtLDeg.TextChanged += new EventHandler(txtLDeg_TextChanged);
            _txtLDeg.KeyPress += new KeyPressEventHandler(txtLDeg_KeyPress);
            _txtLDeg.Validating += new System.ComponentModel.CancelEventHandler(txtLDeg_Validating);
            _txtLDeg.Enter += new EventHandler(txtLDeg_Enter);
            _txtDsDist = new TextBox();
            _txtDsDist.KeyPress += new KeyPressEventHandler(txtDsDist_KeyPress);
            _txtDsDist.Enter += new EventHandler(txtDsDist_Enter);
            _optZDManual = new RadioButton();
            _optZDManual.CheckedChanged += new EventHandler(optZDManual_CheckedChanged);
            _optZDAuto = new RadioButton();
            _optZDAuto.CheckedChanged += new EventHandler(optZDAuto_CheckedChanged);
            _txtPressure = new TextBox();
            _txtPressure.TextChanged += new EventHandler(txtPressure_TextChanged);
            _txtPressure.KeyPress += new KeyPressEventHandler(txtPressure_KeyPress);
            _txtPressure.Enter += new EventHandler(txtPressure_Enter);
            _txtTemperature = new TextBox();
            _txtTemperature.TextChanged += new EventHandler(txtTemperature_TextChanged);
            _txtTemperature.Enter += new EventHandler(txtTemperature_Enter);
            _txtIEmin = new TextBox();
            _txtIEmin.TextChanged += new EventHandler(txtIEmin_TextChanged);
            _txtIEmin.Enter += new EventHandler(txtIEmin_Enter);
            _txtIEmin.KeyPress += new KeyPressEventHandler(txtIEmin_KeyPress);
            _txtIEmin.Validating += new System.ComponentModel.CancelEventHandler(txtIEmin_Validating);
            _txtHE = new TextBox();
            _txtHE.KeyPress += new KeyPressEventHandler(txtHE_KeyPress);
            _txtHE.Enter += new EventHandler(txtHE_Enter);
            _txtHsSec = new TextBox();
            _txtHsSec.TextChanged += new EventHandler(txtHsSec_TextChanged);
            _txtHsSec.KeyPress += new KeyPressEventHandler(txtHsSec_KeyPress);
            _txtHsSec.Validating += new System.ComponentModel.CancelEventHandler(txtHsSec_Validating);
            _txtHsSec.Enter += new EventHandler(txtHsSec_Enter);
            _txtHsMin = new TextBox();
            _txtHsMin.TextChanged += new EventHandler(txtHsMin_TextChanged);
            _txtHsMin.KeyPress += new KeyPressEventHandler(txtHsMin_KeyPress);
            _txtHsMin.Validating += new System.ComponentModel.CancelEventHandler(txtHsMin_Validating);
            _txtHsMin.Enter += new EventHandler(txtHsMin_Enter);
            _txtHsDeg = new TextBox();
            _txtHsDeg.TextChanged += new EventHandler(txtHsDeg_TextChanged);
            _txtHsDeg.KeyPress += new KeyPressEventHandler(txtHsDeg_KeyPress);
            _txtHsDeg.Validating += new System.ComponentModel.CancelEventHandler(txtHsDeg_Validating);
            _txtHsDeg.Enter += new EventHandler(txtHsDeg_Enter);
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
            _txtZDh = new TextBox();
            _txtZDh.TextChanged += new EventHandler(txtZDh_TextChanged);
            _txtZDh.KeyPress += new KeyPressEventHandler(txtZDh_KeyPress);
            _txtZDh.Validating += new System.ComponentModel.CancelEventHandler(txtZDh_Validating);
            _txtZDh.Enter += new EventHandler(txtZDh_Enter);
            _txtWESec = new TextBox();
            _txtWESec.TextChanged += new EventHandler(txtWESec_TextChanged);
            _txtWESec.KeyPress += new KeyPressEventHandler(txtWESec_KeyPress);
            _txtWESec.Validating += new System.ComponentModel.CancelEventHandler(txtWESec_Validating);
            _txtWESec.Enter += new EventHandler(txtWESec_Enter);
            _txtWEMin = new TextBox();
            _txtWEMin.TextChanged += new EventHandler(txtWEMin_TextChanged);
            _txtWEMin.KeyPress += new KeyPressEventHandler(txtWEMin_KeyPress);
            _txtWEMin.Enter += new EventHandler(txtWEMin_Enter);
            lblDsDist = new Label();
            lblIE = new Label();
            lblHE = new Label();
            lblHs = new Label();
            lblHsFormat = new Label();
            lblZD = new Label();
            lblZDAutoManual = new Label();
            lblWE = new Label();
            cboStars = new ComboBox();
            _cboLo = new ComboBox();
            _cboLo.SelectedIndexChanged += new EventHandler(cboLo_SelectedIndexChanged);
            cboL = new ComboBox();
            cboSun = new ComboBox();
            _cmdFix = new Button();
            _cmdFix.Click += new EventHandler(cmdFix_Click);
            _cmdSave = new Button();
            _cmdSave.Click += new EventHandler(cmdSave_Click);
            cboZDm = new ComboBox();
            _cboPolaris = new ComboBox();
            _cboPolaris.SelectedIndexChanged += new EventHandler(cboPolaris_SelectedIndexChanged);
            cboDsUnit = new ComboBox();
            Framehs = new Panel();
            _optHsDMS = new RadioButton();
            _optHsDMS.CheckedChanged += new EventHandler(optHsDMS_CheckedChanged);
            _optHsDMm = new RadioButton();
            _optHsDMm.CheckedChanged += new EventHandler(optHsDMm_CheckedChanged);
            FrameZD = new Panel();
            _optZDUT = new RadioButton();
            _optZDUT.CheckedChanged += new EventHandler(optZDUT_CheckedChanged);
            _cmdReduce = new Button();
            _cmdReduce.Click += new EventHandler(cmdReduce_Click);
            _cboPressure = new ComboBox();
            _cboPressure.SelectedIndexChanged += new EventHandler(cboPressure_SelectedIndexChanged);
            _cboTemperature = new ComboBox();
            _cboTemperature.SelectedIndexChanged += new EventHandler(cboTemperature_SelectedIndexChanged);
            cboIE = new ComboBox();
            cboHE = new ComboBox();
            _cboBody = new ComboBox();
            _cboBody.SelectedIndexChanged += new EventHandler(cboBody_SelectedIndexChanged);
            cboWE = new ComboBox();
            FrameTP = new Panel();
            _optStdTPNo = new RadioButton();
            _optStdTPNo.CheckedChanged += new EventHandler(optStdTPNo_CheckedChanged);
            _optStdTPYes = new RadioButton();
            _optStdTPYes.CheckedChanged += new EventHandler(optStdTPYes_CheckedChanged);
            FrameHo = new Panel();
            lblZDDST = new Label();
            lblIEsec = new Label();
            lblHoCorrs = new Label();
            lblSightNo = new Label();
            lblIEdeg = new Label();
            lblZDm = new Label();
            lblZDh = new Label();
            lblHorizon = new Label();
            lblPressure = new Label();
            lblTempDeg = new Label();
            lblTemperature = new Label();
            lblStdT_P = new Label();
            lblIEMin = new Label();
            lblHsSec = new Label();
            lblHsMin = new Label();
            lblHsDeg = new Label();
            lblLoMin = new Label();
            lblLoDeg = new Label();
            lblDRLo = new Label();
            lblLMin = new Label();
            lblLDeg = new Label();
            lblDRL = new Label();
            lblBody = new Label();
            lblWEsec = new Label();
            lblWEmin = new Label();
            TimeTxtBx = new RichTextBox();
            LHATxtBx = new RichTextBox();
            AltitudeTxtBx = new RichTextBox();
            IntAzTxtBx = new RichTextBox();
            _ExitBtn = new Button();
            _ExitBtn.Click += new EventHandler(ExitBtn_Click);
            _EqTPicBx = new PictureBox();
            _EqTPicBx.Click += new EventHandler(EqTPicBx_Click);
            _EqTPicBx.Paint += new PaintEventHandler(EqTPicBx_Paint);
            FrameHorizon = new Panel();
            _optHorizonBubble = new RadioButton();
            _optHorizonBubble.CheckedChanged += new EventHandler(optHorizonBubble_CheckedChanged);
            _optHorizonDipShort = new RadioButton();
            _optHorizonDipShort.CheckedChanged += new EventHandler(optHorizonDipShort_CheckedChanged);
            _optHorizonArtificial = new RadioButton();
            _optHorizonArtificial.CheckedChanged += new EventHandler(optHorizonArtificial_CheckedChanged);
            _optHorizonNatural = new RadioButton();
            _optHorizonNatural.CheckedChanged += new EventHandler(optHorizonNatural_CheckedChanged);
            frmLimb = new Panel();
            _optCenter = new RadioButton();
            _optCenter.CheckedChanged += new EventHandler(optCenter_CheckedChanged);
            _optUpper = new RadioButton();
            _optUpper.CheckedChanged += new EventHandler(optUpper_CheckedChanged);
            _optLower = new RadioButton();
            _optLower.CheckedChanged += new EventHandler(optLower_CheckedChanged);
            LimbTxt = new TextBox();
            cboPlanets = new ComboBox();
            PictureBox1 = new PictureBox();
            DTSight = new DateTimePicker();
            lblDate = new Label();
            _btnCLSPlot = new Button();
            _btnCLSPlot.Click += new EventHandler(btnCLSPlot_Click);
            _btnCustomPlot = new Button();
            _btnCustomPlot.Click += new EventHandler(btnCustomPlot_Click);
            _cmdMerDiag = new Button();
            _cmdMerDiag.Click += new EventHandler(cmdMerDiag_Click);
            _DGSight = new DataGridView();
            _DGSight.SelectionChanged += new EventHandler(DGSight_SelectionChanged);
            SightTxtBx = new TextBox();
            DecTxtBx = new TextBox();
            _DGDec = new DataGridView();
            _DGDec.SelectionChanged += new EventHandler(DGDec_SelectionChanged);
            _DGTime = new DataGridView();
            _DGTime.SelectionChanged += new EventHandler(DGTime_SelectionChanged);
            _DGLHA = new DataGridView();
            _DGLHA.SelectionChanged += new EventHandler(DGLHA_SelectionChanged);
            _DGAlt = new DataGridView();
            _DGAlt.SelectionChanged += new EventHandler(DGAlt_SelectionChanged);
            txtUserInfo = new TextBox();
            Label7 = new Label();
            _btnExpandTimeDiag = new Button();
            _btnExpandTimeDiag.Click += new EventHandler(btnExpandTimeDiag_Click);
            _ClearAllBtn = new Button();
            _ClearAllBtn.Click += new EventHandler(ClearAllBtn_Click);
            cboLLoBy = new ComboBox();
            Label9 = new Label();
            Framehs.SuspendLayout();
            FrameZD.SuspendLayout();
            FrameTP.SuspendLayout();
            FrameHo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_EqTPicBx).BeginInit();
            FrameHorizon.SuspendLayout();
            frmLimb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_DGSight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_DGDec).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_DGTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_DGLHA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_DGAlt).BeginInit();
            SuspendLayout();
            // 
            // chkDST
            // 
            chkDST.BackColor = SystemColors.Window;
            chkDST.Cursor = Cursors.Default;
            chkDST.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            chkDST.ForeColor = SystemColors.ControlText;
            chkDST.Location = new Point(169, 161);
            chkDST.Name = "chkDST";
            chkDST.RightToLeft = RightToLeft.No;
            chkDST.Size = new Size(17, 17);
            chkDST.TabIndex = 88;
            chkDST.Text = "Check1";
            ToolTipFormSRF.SetToolTip(chkDST, "Check if Dayslight Saving is in effect");
            chkDST.UseVisualStyleBackColor = false;
            // 
            // txtIESec
            // 
            _txtIESec.AcceptsReturn = true;
            _txtIESec.BackColor = SystemColors.Window;
            _txtIESec.Cursor = Cursors.IBeam;
            _txtIESec.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtIESec.ForeColor = SystemColors.WindowText;
            _txtIESec.Location = new Point(561, 43);
            _txtIESec.MaxLength = 2;
            _txtIESec.Name = "_txtIESec";
            _txtIESec.RightToLeft = RightToLeft.No;
            _txtIESec.Size = new Size(33, 20);
            _txtIESec.TabIndex = 54;
            ToolTipFormSRF.SetToolTip(_txtIESec, "Range 0 to 59");
            _txtIESec.Visible = false;
            // 
            // optHoParameters
            // 
            _optHoParameters.BackColor = SystemColors.Window;
            _optHoParameters.Cursor = Cursors.Default;
            _optHoParameters.Font = new Font("Arial Narrow", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optHoParameters.ForeColor = SystemColors.ControlText;
            _optHoParameters.Location = new Point(70, 1);
            _optHoParameters.Name = "_optHoParameters";
            _optHoParameters.RightToLeft = RightToLeft.No;
            _optHoParameters.Size = new Size(73, 18);
            _optHoParameters.TabIndex = 86;
            _optHoParameters.TabStop = true;
            _optHoParameters.Text = "Parameters";
            ToolTipFormSRF.SetToolTip(_optHoParameters, "Refraction, parallax, etc.");
            _optHoParameters.UseVisualStyleBackColor = false;
            // 
            // optHoSRForm
            // 
            _optHoSRForm.BackColor = SystemColors.Window;
            _optHoSRForm.Checked = true;
            _optHoSRForm.Cursor = Cursors.Default;
            _optHoSRForm.Font = new Font("Arial Narrow", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optHoSRForm.ForeColor = SystemColors.ControlText;
            _optHoSRForm.Location = new Point(6, 1);
            _optHoSRForm.Name = "_optHoSRForm";
            _optHoSRForm.RightToLeft = RightToLeft.No;
            _optHoSRForm.Size = new Size(67, 18);
            _optHoSRForm.TabIndex = 85;
            _optHoSRForm.TabStop = true;
            _optHoSRForm.Text = "SR Form";
            ToolTipFormSRF.SetToolTip(_optHoSRForm, "Main, Add'l, etc.");
            _optHoSRForm.UseVisualStyleBackColor = false;
            // 
            // txtSightNo
            // 
            _txtSightNo.AcceptsReturn = true;
            _txtSightNo.BackColor = SystemColors.Window;
            _txtSightNo.Cursor = Cursors.IBeam;
            _txtSightNo.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtSightNo.ForeColor = SystemColors.WindowText;
            _txtSightNo.Location = new Point(103, 29);
            _txtSightNo.MaxLength = 2;
            _txtSightNo.Name = "_txtSightNo";
            _txtSightNo.RightToLeft = RightToLeft.No;
            _txtSightNo.Size = new Size(25, 20);
            _txtSightNo.TabIndex = 24;
            ToolTipFormSRF.SetToolTip(_txtSightNo, "Range 0 to 99");
            // 
            // cmdPrint
            // 
            _cmdPrint.BackColor = SystemColors.Control;
            _cmdPrint.Cursor = Cursors.Default;
            _cmdPrint.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdPrint.ForeColor = SystemColors.ControlText;
            _cmdPrint.Image = (Image)resources.GetObject("cmdPrint.Image");
            _cmdPrint.Location = new Point(692, 0);
            _cmdPrint.Name = "_cmdPrint";
            _cmdPrint.RightToLeft = RightToLeft.No;
            _cmdPrint.Size = new Size(21, 21);
            _cmdPrint.TabIndex = 81;
            _cmdPrint.TextAlign = ContentAlignment.BottomCenter;
            ToolTipFormSRF.SetToolTip(_cmdPrint, "Print window");
            _cmdPrint.UseVisualStyleBackColor = false;
            // 
            // txtIEdeg
            // 
            _txtIEdeg.AcceptsReturn = true;
            _txtIEdeg.BackColor = SystemColors.Window;
            _txtIEdeg.Cursor = Cursors.IBeam;
            _txtIEdeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtIEdeg.ForeColor = SystemColors.WindowText;
            _txtIEdeg.Location = new Point(497, 43);
            _txtIEdeg.MaxLength = 1;
            _txtIEdeg.Name = "_txtIEdeg";
            _txtIEdeg.RightToLeft = RightToLeft.No;
            _txtIEdeg.Size = new Size(17, 20);
            _txtIEdeg.TabIndex = 51;
            ToolTipFormSRF.SetToolTip(_txtIEdeg, "Range 0 to 9; to right of index mark");
            // 
            // txtLDeg
            // 
            _txtLDeg.AcceptsReturn = true;
            _txtLDeg.BackColor = SystemColors.Window;
            _txtLDeg.Cursor = Cursors.IBeam;
            _txtLDeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtLDeg.ForeColor = SystemColors.WindowText;
            _txtLDeg.Location = new Point(321, 112);
            _txtLDeg.MaxLength = 2;
            _txtLDeg.Name = "_txtLDeg";
            _txtLDeg.RightToLeft = RightToLeft.No;
            _txtLDeg.Size = new Size(25, 20);
            _txtLDeg.TabIndex = 29;
            ToolTipFormSRF.SetToolTip(_txtLDeg, "Range 0 to 90");
            // 
            // txtDsDist
            // 
            _txtDsDist.AcceptsReturn = true;
            _txtDsDist.BackColor = SystemColors.Window;
            _txtDsDist.Cursor = Cursors.IBeam;
            _txtDsDist.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtDsDist.ForeColor = SystemColors.WindowText;
            _txtDsDist.Location = new Point(521, 110);
            _txtDsDist.MaxLength = 5;
            _txtDsDist.Name = "_txtDsDist";
            _txtDsDist.RightToLeft = RightToLeft.No;
            _txtDsDist.Size = new Size(41, 20);
            _txtDsDist.TabIndex = 65;
            ToolTipFormSRF.SetToolTip(_txtDsDist, "Limited to five characters");
            _txtDsDist.Visible = false;
            // 
            // optZDManual
            // 
            _optZDManual.BackColor = SystemColors.Window;
            _optZDManual.Cursor = Cursors.Default;
            _optZDManual.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optZDManual.ForeColor = SystemColors.ControlText;
            _optZDManual.Location = new Point(54, 3);
            _optZDManual.Name = "_optZDManual";
            _optZDManual.RightToLeft = RightToLeft.No;
            _optZDManual.Size = new Size(60, 18);
            _optZDManual.TabIndex = 17;
            _optZDManual.TabStop = true;
            _optZDManual.Text = "Manual";
            ToolTipFormSRF.SetToolTip(_optZDManual, "ZD can be set for civil standard time zone");
            _optZDManual.UseVisualStyleBackColor = false;
            // 
            // optZDAuto
            // 
            _optZDAuto.BackColor = SystemColors.Window;
            _optZDAuto.Checked = true;
            _optZDAuto.Cursor = Cursors.Default;
            _optZDAuto.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optZDAuto.ForeColor = SystemColors.ControlText;
            _optZDAuto.Location = new Point(5, 3);
            _optZDAuto.Name = "_optZDAuto";
            _optZDAuto.RightToLeft = RightToLeft.No;
            _optZDAuto.Size = new Size(49, 18);
            _optZDAuto.TabIndex = 16;
            _optZDAuto.TabStop = true;
            _optZDAuto.Text = "Auto";
            ToolTipFormSRF.SetToolTip(_optZDAuto, "ZD based on longitude alone");
            _optZDAuto.UseVisualStyleBackColor = false;
            // 
            // txtPressure
            // 
            _txtPressure.AcceptsReturn = true;
            _txtPressure.BackColor = SystemColors.Window;
            _txtPressure.Cursor = Cursors.IBeam;
            _txtPressure.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtPressure.ForeColor = SystemColors.WindowText;
            _txtPressure.Location = new Point(595, 155);
            _txtPressure.MaxLength = 5;
            _txtPressure.Name = "_txtPressure";
            _txtPressure.RightToLeft = RightToLeft.No;
            _txtPressure.Size = new Size(41, 20);
            _txtPressure.TabIndex = 73;
            _txtPressure.Text = "29.83";
            ToolTipFormSRF.SetToolTip(_txtPressure, "Range 28 to 32 (in Hg) or 950 to 1100 (mb)");
            _txtPressure.Visible = false;
            // 
            // txtTemperature
            // 
            _txtTemperature.AcceptsReturn = true;
            _txtTemperature.BackColor = SystemColors.Window;
            _txtTemperature.Cursor = Cursors.IBeam;
            _txtTemperature.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtTemperature.ForeColor = SystemColors.WindowText;
            _txtTemperature.Location = new Point(481, 155);
            _txtTemperature.MaxLength = 4;
            _txtTemperature.Name = "_txtTemperature";
            _txtTemperature.RightToLeft = RightToLeft.No;
            _txtTemperature.Size = new Size(33, 20);
            _txtTemperature.TabIndex = 69;
            _txtTemperature.Text = "50";
            ToolTipFormSRF.SetToolTip(_txtTemperature, "Range -40 to 130 (F) or -40 to 55 (C)");
            _txtTemperature.Visible = false;
            // 
            // txtIEmin
            // 
            _txtIEmin.AcceptsReturn = true;
            _txtIEmin.BackColor = SystemColors.Window;
            _txtIEmin.Cursor = Cursors.IBeam;
            _txtIEmin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtIEmin.ForeColor = SystemColors.WindowText;
            _txtIEmin.Location = new Point(521, 43);
            _txtIEmin.MaxLength = 4;
            _txtIEmin.Name = "_txtIEmin";
            _txtIEmin.RightToLeft = RightToLeft.No;
            _txtIEmin.Size = new Size(33, 20);
            _txtIEmin.TabIndex = 53;
            ToolTipFormSRF.SetToolTip(_txtIEmin, "Range 0 to 59.9 (DM.m) or 59 (DMS)");
            // 
            // txtHE
            // 
            _txtHE.AcceptsReturn = true;
            _txtHE.BackColor = SystemColors.Window;
            _txtHE.Cursor = Cursors.IBeam;
            _txtHE.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtHE.ForeColor = SystemColors.WindowText;
            _txtHE.Location = new Point(479, 85);
            _txtHE.MaxLength = 4;
            _txtHE.Name = "_txtHE";
            _txtHE.RightToLeft = RightToLeft.No;
            _txtHE.Size = new Size(33, 20);
            _txtHE.TabIndex = 62;
            ToolTipFormSRF.SetToolTip(_txtHE, "Max. 4 characters");
            // 
            // txtHsSec
            // 
            _txtHsSec.AcceptsReturn = true;
            _txtHsSec.BackColor = SystemColors.Window;
            _txtHsSec.Cursor = Cursors.IBeam;
            _txtHsSec.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtHsSec.ForeColor = SystemColors.WindowText;
            _txtHsSec.Location = new Point(561, 21);
            _txtHsSec.MaxLength = 2;
            _txtHsSec.Name = "_txtHsSec";
            _txtHsSec.RightToLeft = RightToLeft.No;
            _txtHsSec.Size = new Size(33, 20);
            _txtHsSec.TabIndex = 48;
            ToolTipFormSRF.SetToolTip(_txtHsSec, "Range 0 to 59");
            _txtHsSec.Visible = false;
            // 
            // txtHsMin
            // 
            _txtHsMin.AcceptsReturn = true;
            _txtHsMin.BackColor = SystemColors.Window;
            _txtHsMin.Cursor = Cursors.IBeam;
            _txtHsMin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtHsMin.ForeColor = SystemColors.WindowText;
            _txtHsMin.Location = new Point(521, 21);
            _txtHsMin.MaxLength = 4;
            _txtHsMin.Name = "_txtHsMin";
            _txtHsMin.RightToLeft = RightToLeft.No;
            _txtHsMin.Size = new Size(33, 20);
            _txtHsMin.TabIndex = 46;
            ToolTipFormSRF.SetToolTip(_txtHsMin, "Range 0 to 59.9 (DM.m) or 59 (DMS)");
            // 
            // txtHsDeg
            // 
            _txtHsDeg.AcceptsReturn = true;
            _txtHsDeg.BackColor = SystemColors.Window;
            _txtHsDeg.Cursor = Cursors.IBeam;
            _txtHsDeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtHsDeg.ForeColor = SystemColors.WindowText;
            _txtHsDeg.Location = new Point(481, 21);
            _txtHsDeg.MaxLength = 3;
            _txtHsDeg.Name = "_txtHsDeg";
            _txtHsDeg.RightToLeft = RightToLeft.No;
            _txtHsDeg.Size = new Size(33, 20);
            _txtHsDeg.TabIndex = 44;
            ToolTipFormSRF.SetToolTip(_txtHsDeg, "Range 0 to 145");
            // 
            // txtLoMin
            // 
            _txtLoMin.AcceptsReturn = true;
            _txtLoMin.BackColor = SystemColors.Window;
            _txtLoMin.Cursor = Cursors.IBeam;
            _txtLoMin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtLoMin.ForeColor = SystemColors.WindowText;
            _txtLoMin.Location = new Point(353, 135);
            _txtLoMin.MaxLength = 4;
            _txtLoMin.Name = "_txtLoMin";
            _txtLoMin.RightToLeft = RightToLeft.No;
            _txtLoMin.Size = new Size(33, 20);
            _txtLoMin.TabIndex = 36;
            ToolTipFormSRF.SetToolTip(_txtLoMin, "Range 0 to 59.9");
            // 
            // txtLoDeg
            // 
            _txtLoDeg.AcceptsReturn = true;
            _txtLoDeg.BackColor = SystemColors.Window;
            _txtLoDeg.Cursor = Cursors.IBeam;
            _txtLoDeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtLoDeg.ForeColor = SystemColors.WindowText;
            _txtLoDeg.Location = new Point(313, 135);
            _txtLoDeg.MaxLength = 3;
            _txtLoDeg.Name = "_txtLoDeg";
            _txtLoDeg.RightToLeft = RightToLeft.No;
            _txtLoDeg.Size = new Size(33, 20);
            _txtLoDeg.TabIndex = 35;
            ToolTipFormSRF.SetToolTip(_txtLoDeg, "Range 0 to 180");
            // 
            // txtLMin
            // 
            _txtLMin.AcceptsReturn = true;
            _txtLMin.BackColor = SystemColors.Window;
            _txtLMin.Cursor = Cursors.IBeam;
            _txtLMin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtLMin.ForeColor = SystemColors.WindowText;
            _txtLMin.Location = new Point(353, 112);
            _txtLMin.MaxLength = 4;
            _txtLMin.Name = "_txtLMin";
            _txtLMin.RightToLeft = RightToLeft.No;
            _txtLMin.Size = new Size(33, 20);
            _txtLMin.TabIndex = 30;
            ToolTipFormSRF.SetToolTip(_txtLMin, "Range 0 to 59.9");
            // 
            // txtZDh
            // 
            _txtZDh.AcceptsReturn = true;
            _txtZDh.BackColor = SystemColors.Window;
            _txtZDh.Cursor = Cursors.IBeam;
            _txtZDh.Enabled = false;
            _txtZDh.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtZDh.ForeColor = SystemColors.WindowText;
            _txtZDh.Location = new Point(65, 160);
            _txtZDh.MaxLength = 3;
            _txtZDh.Name = "_txtZDh";
            _txtZDh.RightToLeft = RightToLeft.No;
            _txtZDh.Size = new Size(25, 20);
            _txtZDh.TabIndex = 19;
            ToolTipFormSRF.SetToolTip(_txtZDh, "Range -14 to +12.  Lo E is -.");
            // 
            // txtWESec
            // 
            _txtWESec.AcceptsReturn = true;
            _txtWESec.BackColor = SystemColors.Window;
            _txtWESec.Cursor = Cursors.IBeam;
            _txtWESec.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtWESec.ForeColor = SystemColors.WindowText;
            _txtWESec.Location = new Point(121, 95);
            _txtWESec.MaxLength = 2;
            _txtWESec.Name = "_txtWESec";
            _txtWESec.RightToLeft = RightToLeft.No;
            _txtWESec.Size = new Size(25, 20);
            _txtWESec.TabIndex = 12;
            ToolTipFormSRF.SetToolTip(_txtWESec, "Range 0 to 59");
            // 
            // txtWEMin
            // 
            _txtWEMin.AcceptsReturn = true;
            _txtWEMin.BackColor = SystemColors.Window;
            _txtWEMin.Cursor = Cursors.IBeam;
            _txtWEMin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtWEMin.ForeColor = SystemColors.WindowText;
            _txtWEMin.Location = new Point(73, 95);
            _txtWEMin.MaxLength = 1;
            _txtWEMin.Name = "_txtWEMin";
            _txtWEMin.RightToLeft = RightToLeft.No;
            _txtWEMin.Size = new Size(17, 20);
            _txtWEMin.TabIndex = 10;
            ToolTipFormSRF.SetToolTip(_txtWEMin, "Range 0 to 9");
            // 
            // lblDsDist
            // 
            lblDsDist.BackColor = SystemColors.Window;
            lblDsDist.Cursor = Cursors.Default;
            lblDsDist.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblDsDist.ForeColor = SystemColors.ControlText;
            lblDsDist.Location = new Point(449, 112);
            lblDsDist.Name = "lblDsDist";
            lblDsDist.RightToLeft = RightToLeft.No;
            lblDsDist.Size = new Size(65, 17);
            lblDsDist.TabIndex = 64;
            lblDsDist.Text = "Ds distance";
            ToolTipFormSRF.SetToolTip(lblDsDist, "Distance to dip short horizon");
            lblDsDist.Visible = false;
            // 
            // lblIE
            // 
            lblIE.BackColor = SystemColors.Window;
            lblIE.Cursor = Cursors.Default;
            lblIE.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblIE.ForeColor = SystemColors.ControlText;
            lblIE.Location = new Point(450, 45);
            lblIE.Name = "lblIE";
            lblIE.RightToLeft = RightToLeft.No;
            lblIE.Size = new Size(17, 17);
            lblIE.TabIndex = 50;
            lblIE.Text = "IE";
            ToolTipFormSRF.SetToolTip(lblIE, "Index Error");
            // 
            // lblHE
            // 
            lblHE.BackColor = SystemColors.Window;
            lblHE.Cursor = Cursors.Default;
            lblHE.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblHE.ForeColor = SystemColors.ControlText;
            lblHE.Location = new Point(449, 89);
            lblHE.Name = "lblHE";
            lblHE.RightToLeft = RightToLeft.No;
            lblHE.Size = new Size(22, 17);
            lblHE.TabIndex = 61;
            lblHE.Text = "HE";
            ToolTipFormSRF.SetToolTip(lblHE, "Height of Eye");
            // 
            // lblHs
            // 
            lblHs.BackColor = SystemColors.Window;
            lblHs.Cursor = Cursors.Default;
            lblHs.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblHs.ForeColor = SystemColors.ControlText;
            lblHs.Location = new Point(449, 22);
            lblHs.Name = "lblHs";
            lblHs.RightToLeft = RightToLeft.No;
            lblHs.Size = new Size(22, 17);
            lblHs.TabIndex = 43;
            lblHs.Text = "hs";
            ToolTipFormSRF.SetToolTip(lblHs, "Sextant Altitude");
            // 
            // lblHsFormat
            // 
            lblHsFormat.BackColor = SystemColors.Window;
            lblHsFormat.Cursor = Cursors.Default;
            lblHsFormat.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblHsFormat.ForeColor = SystemColors.ControlText;
            lblHsFormat.Location = new Point(489, 3);
            lblHsFormat.Name = "lblHsFormat";
            lblHsFormat.RightToLeft = RightToLeft.No;
            lblHsFormat.Size = new Size(65, 13);
            lblHsFormat.TabIndex = 40;
            lblHsFormat.Text = "hs/IE format";
            ToolTipFormSRF.SetToolTip(lblHsFormat, "Sextant Altitude/Index Error format");
            // 
            // lblZD
            // 
            lblZD.BackColor = SystemColors.Window;
            lblZD.Cursor = Cursors.Default;
            lblZD.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblZD.ForeColor = SystemColors.ControlText;
            lblZD.Location = new Point(41, 162);
            lblZD.Name = "lblZD";
            lblZD.RightToLeft = RightToLeft.No;
            lblZD.Size = new Size(22, 17);
            lblZD.TabIndex = 18;
            lblZD.Text = "ZD";
            ToolTipFormSRF.SetToolTip(lblZD, "Zone Description");
            // 
            // lblZDAutoManual
            // 
            lblZDAutoManual.BackColor = SystemColors.Window;
            lblZDAutoManual.Cursor = Cursors.Default;
            lblZDAutoManual.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblZDAutoManual.ForeColor = SystemColors.ControlText;
            lblZDAutoManual.Location = new Point(41, 131);
            lblZDAutoManual.Name = "lblZDAutoManual";
            lblZDAutoManual.RightToLeft = RightToLeft.No;
            lblZDAutoManual.Size = new Size(22, 17);
            lblZDAutoManual.TabIndex = 15;
            lblZDAutoManual.Text = "ZD";
            ToolTipFormSRF.SetToolTip(lblZDAutoManual, "Zone Description ");
            // 
            // lblWE
            // 
            lblWE.BackColor = SystemColors.Window;
            lblWE.Cursor = Cursors.Default;
            lblWE.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblWE.ForeColor = SystemColors.ControlText;
            lblWE.Location = new Point(41, 98);
            lblWE.Name = "lblWE";
            lblWE.RightToLeft = RightToLeft.No;
            lblWE.Size = new Size(25, 17);
            lblWE.TabIndex = 9;
            lblWE.Text = "WE";
            ToolTipFormSRF.SetToolTip(lblWE, "Watch Error");
            // 
            // cboStars
            // 
            cboStars.BackColor = SystemColors.Window;
            cboStars.Cursor = Cursors.Default;
            cboStars.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStars.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboStars.ForeColor = SystemColors.WindowText;
            cboStars.Items.AddRange(new object[] { "NA vals. of SHA/Dec", "Accurate vals. of SHA/Dec" });
            cboStars.Location = new Point(276, 84);
            cboStars.Name = "cboStars";
            cboStars.RightToLeft = RightToLeft.No;
            cboStars.Size = new Size(161, 22);
            cboStars.TabIndex = 97;
            // 
            // cboLo
            // 
            _cboLo.BackColor = SystemColors.Window;
            _cboLo.Cursor = Cursors.Default;
            _cboLo.DropDownStyle = ComboBoxStyle.DropDownList;
            _cboLo.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboLo.ForeColor = SystemColors.WindowText;
            _cboLo.Items.AddRange(new object[] { "W", "E" });
            _cboLo.Location = new Point(393, 135);
            _cboLo.Name = "_cboLo";
            _cboLo.RightToLeft = RightToLeft.No;
            _cboLo.Size = new Size(41, 22);
            _cboLo.TabIndex = 37;
            // 
            // cboL
            // 
            cboL.BackColor = SystemColors.Window;
            cboL.Cursor = Cursors.Default;
            cboL.DropDownStyle = ComboBoxStyle.DropDownList;
            cboL.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboL.ForeColor = SystemColors.WindowText;
            cboL.Items.AddRange(new object[] { "N", "S" });
            cboL.Location = new Point(393, 112);
            cboL.Name = "cboL";
            cboL.RightToLeft = RightToLeft.No;
            cboL.Size = new Size(41, 22);
            cboL.TabIndex = 31;
            // 
            // cboSun
            // 
            cboSun.BackColor = SystemColors.Window;
            cboSun.Cursor = Cursors.Default;
            cboSun.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSun.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboSun.ForeColor = SystemColors.WindowText;
            cboSun.Items.AddRange(new object[] { "NA val. of hourly GHA/d", "Accurate val. of hourly GHA/d" });
            cboSun.Location = new Point(276, 84);
            cboSun.Name = "cboSun";
            cboSun.RightToLeft = RightToLeft.No;
            cboSun.Size = new Size(161, 22);
            cboSun.TabIndex = 96;
            // 
            // cmdFix
            // 
            _cmdFix.BackColor = SystemColors.Control;
            _cmdFix.Cursor = Cursors.Default;
            _cmdFix.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdFix.ForeColor = SystemColors.ControlText;
            _cmdFix.Location = new Point(285, 837);
            _cmdFix.Name = "_cmdFix";
            _cmdFix.RightToLeft = RightToLeft.No;
            _cmdFix.Size = new Size(140, 23);
            _cmdFix.TabIndex = 80;
            _cmdFix.Text = "&Establish Fix";
            _cmdFix.UseVisualStyleBackColor = false;
            _cmdFix.Visible = false;
            // 
            // cmdSave
            // 
            _cmdSave.BackColor = SystemColors.Control;
            _cmdSave.Cursor = Cursors.Default;
            _cmdSave.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdSave.ForeColor = SystemColors.ControlText;
            _cmdSave.Location = new Point(285, 808);
            _cmdSave.Name = "_cmdSave";
            _cmdSave.RightToLeft = RightToLeft.No;
            _cmdSave.Size = new Size(140, 23);
            _cmdSave.TabIndex = 79;
            _cmdSave.Text = "&Save Sight Data for Fix";
            _cmdSave.UseVisualStyleBackColor = false;
            _cmdSave.Visible = false;
            // 
            // cboZDm
            // 
            cboZDm.BackColor = SystemColors.Window;
            cboZDm.Cursor = Cursors.Default;
            cboZDm.DropDownStyle = ComboBoxStyle.DropDownList;
            cboZDm.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboZDm.ForeColor = SystemColors.WindowText;
            cboZDm.Items.AddRange(new object[] { "00", "30", "45" });
            cboZDm.Location = new Point(105, 159);
            cboZDm.Name = "cboZDm";
            cboZDm.RightToLeft = RightToLeft.No;
            cboZDm.Size = new Size(41, 22);
            cboZDm.TabIndex = 21;
            cboZDm.Visible = false;
            // 
            // cboPolaris
            // 
            _cboPolaris.BackColor = SystemColors.Window;
            _cboPolaris.Cursor = Cursors.Default;
            _cboPolaris.DropDownStyle = ComboBoxStyle.DropDownList;
            _cboPolaris.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboPolaris.ForeColor = SystemColors.WindowText;
            _cboPolaris.Items.AddRange(new object[] { "Latitude by altitude of Polaris", "Full reduction of Polaris sight" });
            _cboPolaris.Location = new Point(276, 84);
            _cboPolaris.Name = "_cboPolaris";
            _cboPolaris.RightToLeft = RightToLeft.No;
            _cboPolaris.Size = new Size(161, 22);
            _cboPolaris.TabIndex = 27;
            _cboPolaris.Visible = false;
            // 
            // cboDsUnit
            // 
            cboDsUnit.BackColor = SystemColors.Window;
            cboDsUnit.Cursor = Cursors.Default;
            cboDsUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDsUnit.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboDsUnit.ForeColor = SystemColors.WindowText;
            cboDsUnit.Items.AddRange(new object[] { "feet", "yards", "meters", "statute miles", "nautical miles" });
            cboDsUnit.Location = new Point(565, 108);
            cboDsUnit.Name = "cboDsUnit";
            cboDsUnit.RightToLeft = RightToLeft.No;
            cboDsUnit.Size = new Size(95, 22);
            cboDsUnit.TabIndex = 66;
            cboDsUnit.Visible = false;
            // 
            // Framehs
            // 
            Framehs.BackColor = SystemColors.Window;
            Framehs.BorderStyle = BorderStyle.FixedSingle;
            Framehs.Controls.Add(_optHsDMS);
            Framehs.Controls.Add(_optHsDMm);
            Framehs.Cursor = Cursors.Default;
            Framehs.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Framehs.ForeColor = SystemColors.ControlText;
            Framehs.Location = new Point(559, 1);
            Framehs.Name = "Framehs";
            Framehs.RightToLeft = RightToLeft.No;
            Framehs.Size = new Size(128, 18);
            Framehs.TabIndex = 77;
            Framehs.Text = "Frame2";
            // 
            // optHsDMS
            // 
            _optHsDMS.BackColor = SystemColors.Window;
            _optHsDMS.Cursor = Cursors.Default;
            _optHsDMS.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optHsDMS.ForeColor = SystemColors.ControlText;
            _optHsDMS.Location = new Point(69, 0);
            _optHsDMS.Name = "_optHsDMS";
            _optHsDMS.RightToLeft = RightToLeft.No;
            _optHsDMS.Size = new Size(49, 18);
            _optHsDMS.TabIndex = 42;
            _optHsDMS.TabStop = true;
            _optHsDMS.Text = "DMS";
            _optHsDMS.UseVisualStyleBackColor = false;
            // 
            // optHsDMm
            // 
            _optHsDMm.BackColor = SystemColors.Window;
            _optHsDMm.Checked = true;
            _optHsDMm.Cursor = Cursors.Default;
            _optHsDMm.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optHsDMm.ForeColor = SystemColors.ControlText;
            _optHsDMm.Location = new Point(6, 0);
            _optHsDMm.Name = "_optHsDMm";
            _optHsDMm.RightToLeft = RightToLeft.No;
            _optHsDMm.Size = new Size(57, 18);
            _optHsDMm.TabIndex = 41;
            _optHsDMm.TabStop = true;
            _optHsDMm.Text = "DM.m";
            _optHsDMm.UseVisualStyleBackColor = false;
            // 
            // FrameZD
            // 
            FrameZD.BackColor = SystemColors.Window;
            FrameZD.BorderStyle = BorderStyle.FixedSingle;
            FrameZD.Controls.Add(_optZDUT);
            FrameZD.Controls.Add(_optZDManual);
            FrameZD.Controls.Add(_optZDAuto);
            FrameZD.Cursor = Cursors.Default;
            FrameZD.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FrameZD.ForeColor = SystemColors.ControlText;
            FrameZD.Location = new Point(65, 126);
            FrameZD.Name = "FrameZD";
            FrameZD.RightToLeft = RightToLeft.No;
            FrameZD.Size = new Size(192, 25);
            FrameZD.TabIndex = 76;
            // 
            // optZDUT
            // 
            _optZDUT.BackColor = SystemColors.Window;
            _optZDUT.Cursor = Cursors.Default;
            _optZDUT.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optZDUT.ForeColor = SystemColors.ControlText;
            _optZDUT.Location = new Point(114, 3);
            _optZDUT.Name = "_optZDUT";
            _optZDUT.RightToLeft = RightToLeft.No;
            _optZDUT.Size = new Size(75, 17);
            _optZDUT.TabIndex = 100;
            _optZDUT.TabStop = true;
            _optZDUT.Text = "UT (GMT)";
            _optZDUT.UseVisualStyleBackColor = false;
            // 
            // cmdReduce
            // 
            _cmdReduce.BackColor = Color.Blue;
            _cmdReduce.Cursor = Cursors.Default;
            _cmdReduce.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdReduce.ForeColor = Color.White;
            _cmdReduce.Location = new Point(275, 175);
            _cmdReduce.Name = "_cmdReduce";
            _cmdReduce.RightToLeft = RightToLeft.No;
            _cmdReduce.Size = new Size(161, 25);
            _cmdReduce.TabIndex = 75;
            _cmdReduce.Text = "&Reduce Sight";
            _cmdReduce.UseVisualStyleBackColor = false;
            // 
            // cboPressure
            // 
            _cboPressure.BackColor = SystemColors.Window;
            _cboPressure.Cursor = Cursors.Default;
            _cboPressure.DropDownStyle = ComboBoxStyle.DropDownList;
            _cboPressure.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboPressure.ForeColor = SystemColors.WindowText;
            _cboPressure.Items.AddRange(new object[] { "in Hg", "mbar" });
            _cboPressure.Location = new Point(641, 155);
            _cboPressure.Name = "_cboPressure";
            _cboPressure.RightToLeft = RightToLeft.No;
            _cboPressure.Size = new Size(57, 22);
            _cboPressure.TabIndex = 74;
            _cboPressure.Visible = false;
            // 
            // cboTemperature
            // 
            _cboTemperature.BackColor = SystemColors.Window;
            _cboTemperature.Cursor = Cursors.Default;
            _cboTemperature.DropDownStyle = ComboBoxStyle.DropDownList;
            _cboTemperature.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboTemperature.ForeColor = SystemColors.WindowText;
            _cboTemperature.Items.AddRange(new object[] { "F ", "C " });
            _cboTemperature.Location = new Point(521, 155);
            _cboTemperature.Name = "_cboTemperature";
            _cboTemperature.RightToLeft = RightToLeft.No;
            _cboTemperature.Size = new Size(33, 22);
            _cboTemperature.TabIndex = 71;
            _cboTemperature.Visible = false;
            // 
            // cboIE
            // 
            cboIE.BackColor = SystemColors.Window;
            cboIE.Cursor = Cursors.Default;
            cboIE.DropDownStyle = ComboBoxStyle.DropDownList;
            cboIE.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboIE.ForeColor = SystemColors.WindowText;
            cboIE.Items.AddRange(new object[] { "on the arc", "off the arc (val.)", "off the arc (rdg.)" });
            cboIE.Location = new Point(604, 41);
            cboIE.Name = "cboIE";
            cboIE.RightToLeft = RightToLeft.No;
            cboIE.Size = new Size(105, 22);
            cboIE.TabIndex = 56;
            // 
            // cboHE
            // 
            cboHE.BackColor = SystemColors.Window;
            cboHE.Cursor = Cursors.Default;
            cboHE.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHE.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboHE.ForeColor = SystemColors.WindowText;
            cboHE.Items.AddRange(new object[] { "ft", "in", "m ", "cm" });
            cboHE.Location = new Point(521, 85);
            cboHE.Name = "cboHE";
            cboHE.RightToLeft = RightToLeft.No;
            cboHE.Size = new Size(41, 22);
            cboHE.TabIndex = 63;
            // 
            // cboBody
            // 
            _cboBody.BackColor = SystemColors.Window;
            _cboBody.Cursor = Cursors.Default;
            _cboBody.DropDownStyle = ComboBoxStyle.DropDownList;
            _cboBody.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboBody.ForeColor = SystemColors.WindowText;
            _cboBody.Items.AddRange(new object[] { "Sun", "Moon", "Venus", "Mars", "Jupiter", "Saturn", "Acamar", "Achernar", "Acrux", "Adhara", "Aldebaran", "Alioth", "Alkaid", "Al Na'ir", "Alnilam", "Alphard", "Alphecca", "Alpheratz", "Altair", "Ankaa", "Antares", "Arcturus", "Atria", "Avior", "Bellatrix", "Betelgeuse", "Canopus", "Capella", "Deneb", "Denebola", "Diphda", "Dubhe", "Elnath", "Eltanin", "Enif", "Fomalhaut", "Gacrux", "Gienah", "Hadar", "Hamal", "Kaus Australis", "Kochab", "Markab", "Menkar", "Menkent", "Miaplacidus", "Mirfak", "Nunki", "Peacock", "Polaris", "Pollux", "Procyon", "Rasalhague", "Regulus", "Rigel", "Rigil Kentaurus", "Sabik", "Schedar", "Shaula", "Sirius", "Spica", "Suhail", "Vega", "Zubenelgenubi" + '\t' });
            _cboBody.Location = new Point(337, 27);
            _cboBody.Name = "_cboBody";
            _cboBody.RightToLeft = RightToLeft.No;
            _cboBody.Size = new Size(97, 22);
            _cboBody.TabIndex = 26;
            // 
            // cboWE
            // 
            cboWE.BackColor = SystemColors.Window;
            cboWE.Cursor = Cursors.Default;
            cboWE.DropDownStyle = ComboBoxStyle.DropDownList;
            cboWE.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboWE.ForeColor = SystemColors.WindowText;
            cboWE.Items.AddRange(new object[] { "fast", "slow" });
            cboWE.Location = new Point(177, 95);
            cboWE.Name = "cboWE";
            cboWE.RightToLeft = RightToLeft.No;
            cboWE.Size = new Size(49, 22);
            cboWE.TabIndex = 14;
            // 
            // FrameTP
            // 
            FrameTP.BackColor = SystemColors.Window;
            FrameTP.BorderStyle = BorderStyle.FixedSingle;
            FrameTP.Controls.Add(_optStdTPNo);
            FrameTP.Controls.Add(_optStdTPYes);
            FrameTP.Cursor = Cursors.Default;
            FrameTP.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FrameTP.ForeColor = SystemColors.ControlText;
            FrameTP.Location = new Point(566, 133);
            FrameTP.Name = "FrameTP";
            FrameTP.RightToLeft = RightToLeft.No;
            FrameTP.Size = new Size(104, 20);
            FrameTP.TabIndex = 91;
            // 
            // optStdTPNo
            // 
            _optStdTPNo.BackColor = SystemColors.Window;
            _optStdTPNo.Cursor = Cursors.Default;
            _optStdTPNo.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optStdTPNo.ForeColor = SystemColors.ControlText;
            _optStdTPNo.Location = new Point(56, 1);
            _optStdTPNo.Name = "_optStdTPNo";
            _optStdTPNo.RightToLeft = RightToLeft.No;
            _optStdTPNo.Size = new Size(41, 18);
            _optStdTPNo.TabIndex = 94;
            _optStdTPNo.TabStop = true;
            _optStdTPNo.Text = "No";
            _optStdTPNo.UseVisualStyleBackColor = false;
            // 
            // optStdTPYes
            // 
            _optStdTPYes.BackColor = SystemColors.Window;
            _optStdTPYes.Checked = true;
            _optStdTPYes.Cursor = Cursors.Default;
            _optStdTPYes.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optStdTPYes.ForeColor = SystemColors.ControlText;
            _optStdTPYes.Location = new Point(8, 1);
            _optStdTPYes.Name = "_optStdTPYes";
            _optStdTPYes.RightToLeft = RightToLeft.No;
            _optStdTPYes.Size = new Size(46, 18);
            _optStdTPYes.TabIndex = 93;
            _optStdTPYes.TabStop = true;
            _optStdTPYes.Text = "Yes";
            _optStdTPYes.UseVisualStyleBackColor = false;
            // 
            // FrameHo
            // 
            FrameHo.BackColor = SystemColors.Window;
            FrameHo.BorderStyle = BorderStyle.FixedSingle;
            FrameHo.Controls.Add(_optHoParameters);
            FrameHo.Controls.Add(_optHoSRForm);
            FrameHo.Cursor = Cursors.Default;
            FrameHo.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FrameHo.ForeColor = SystemColors.ControlText;
            FrameHo.Location = new Point(563, 180);
            FrameHo.Name = "FrameHo";
            FrameHo.RightToLeft = RightToLeft.No;
            FrameHo.Size = new Size(144, 22);
            FrameHo.TabIndex = 92;
            // 
            // lblZDDST
            // 
            lblZDDST.BackColor = SystemColors.Window;
            lblZDDST.Cursor = Cursors.Default;
            lblZDDST.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblZDDST.ForeColor = SystemColors.ControlText;
            lblZDDST.Location = new Point(186, 162);
            lblZDDST.Name = "lblZDDST";
            lblZDDST.RightToLeft = RightToLeft.No;
            lblZDDST.Size = new Size(33, 13);
            lblZDDST.TabIndex = 89;
            lblZDDST.Text = "DST";
            // 
            // lblIEsec
            // 
            lblIEsec.BackColor = SystemColors.Window;
            lblIEsec.Cursor = Cursors.Default;
            lblIEsec.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblIEsec.ForeColor = SystemColors.ControlText;
            lblIEsec.Location = new Point(594, 40);
            lblIEsec.Name = "lblIEsec";
            lblIEsec.RightToLeft = RightToLeft.No;
            lblIEsec.Size = new Size(9, 17);
            lblIEsec.TabIndex = 87;
            lblIEsec.Text = "\"";
            lblIEsec.Visible = false;
            // 
            // lblHoCorrs
            // 
            lblHoCorrs.BackColor = SystemColors.Window;
            lblHoCorrs.Cursor = Cursors.Default;
            lblHoCorrs.Font = new Font("Arial Narrow", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblHoCorrs.ForeColor = SystemColors.ControlText;
            lblHoCorrs.Location = new Point(450, 184);
            lblHoCorrs.Name = "lblHoCorrs";
            lblHoCorrs.RightToLeft = RightToLeft.No;
            lblHoCorrs.Size = new Size(113, 13);
            lblHoCorrs.TabIndex = 84;
            lblHoCorrs.Text = "Show Ho corrections as";
            // 
            // lblSightNo
            // 
            lblSightNo.BackColor = SystemColors.Window;
            lblSightNo.Cursor = Cursors.Default;
            lblSightNo.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblSightNo.ForeColor = SystemColors.ControlText;
            lblSightNo.Location = new Point(44, 30);
            lblSightNo.Name = "lblSightNo";
            lblSightNo.RightToLeft = RightToLeft.No;
            lblSightNo.Size = new Size(55, 17);
            lblSightNo.TabIndex = 23;
            lblSightNo.Text = "Sight No.";
            // 
            // lblIEdeg
            // 
            lblIEdeg.BackColor = SystemColors.Window;
            lblIEdeg.Cursor = Cursors.Default;
            lblIEdeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblIEdeg.ForeColor = SystemColors.ControlText;
            lblIEdeg.Location = new Point(512, 40);
            lblIEdeg.Name = "lblIEdeg";
            lblIEdeg.RightToLeft = RightToLeft.No;
            lblIEdeg.Size = new Size(9, 17);
            lblIEdeg.TabIndex = 52;
            lblIEdeg.Text = "°";
            // 
            // lblZDm
            // 
            lblZDm.BackColor = SystemColors.Window;
            lblZDm.Cursor = Cursors.Default;
            lblZDm.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblZDm.ForeColor = SystemColors.ControlText;
            lblZDm.Location = new Point(146, 160);
            lblZDm.Name = "lblZDm";
            lblZDm.RightToLeft = RightToLeft.No;
            lblZDm.Size = new Size(15, 17);
            lblZDm.TabIndex = 22;
            lblZDm.Text = "m";
            lblZDm.Visible = false;
            // 
            // lblZDh
            // 
            lblZDh.BackColor = SystemColors.Window;
            lblZDh.Cursor = Cursors.Default;
            lblZDh.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblZDh.ForeColor = SystemColors.ControlText;
            lblZDh.Location = new Point(90, 161);
            lblZDh.Name = "lblZDh";
            lblZDh.RightToLeft = RightToLeft.No;
            lblZDh.Size = new Size(12, 17);
            lblZDh.TabIndex = 20;
            lblZDh.Text = "h";
            lblZDh.Visible = false;
            // 
            // lblHorizon
            // 
            lblHorizon.BackColor = SystemColors.Window;
            lblHorizon.Cursor = Cursors.Default;
            lblHorizon.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblHorizon.ForeColor = SystemColors.ControlText;
            lblHorizon.Location = new Point(449, 65);
            lblHorizon.Name = "lblHorizon";
            lblHorizon.RightToLeft = RightToLeft.No;
            lblHorizon.Size = new Size(49, 17);
            lblHorizon.TabIndex = 57;
            lblHorizon.Text = "Hor.";
            // 
            // lblPressure
            // 
            lblPressure.BackColor = SystemColors.Window;
            lblPressure.Cursor = Cursors.Default;
            lblPressure.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblPressure.ForeColor = SystemColors.ControlText;
            lblPressure.Location = new Point(557, 157);
            lblPressure.Name = "lblPressure";
            lblPressure.RightToLeft = RightToLeft.No;
            lblPressure.Size = new Size(38, 17);
            lblPressure.TabIndex = 72;
            lblPressure.Text = "Press.";
            lblPressure.Visible = false;
            // 
            // lblTempDeg
            // 
            lblTempDeg.BackColor = SystemColors.Window;
            lblTempDeg.Cursor = Cursors.Default;
            lblTempDeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblTempDeg.ForeColor = SystemColors.ControlText;
            lblTempDeg.Location = new Point(512, 155);
            lblTempDeg.Name = "lblTempDeg";
            lblTempDeg.RightToLeft = RightToLeft.No;
            lblTempDeg.Size = new Size(9, 17);
            lblTempDeg.TabIndex = 70;
            lblTempDeg.Text = "°";
            lblTempDeg.Visible = false;
            // 
            // lblTemperature
            // 
            lblTemperature.BackColor = SystemColors.Window;
            lblTemperature.Cursor = Cursors.Default;
            lblTemperature.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblTemperature.ForeColor = SystemColors.ControlText;
            lblTemperature.Location = new Point(449, 158);
            lblTemperature.Name = "lblTemperature";
            lblTemperature.RightToLeft = RightToLeft.No;
            lblTemperature.Size = new Size(33, 17);
            lblTemperature.TabIndex = 68;
            lblTemperature.Text = "Temp.";
            lblTemperature.Visible = false;
            // 
            // lblStdT_P
            // 
            lblStdT_P.BackColor = SystemColors.Window;
            lblStdT_P.Cursor = Cursors.Default;
            lblStdT_P.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblStdT_P.ForeColor = SystemColors.ControlText;
            lblStdT_P.Location = new Point(449, 134);
            lblStdT_P.Name = "lblStdT_P";
            lblStdT_P.RightToLeft = RightToLeft.No;
            lblStdT_P.Size = new Size(115, 17);
            lblStdT_P.TabIndex = 67;
            lblStdT_P.Text = "Std. temp. and press.";
            // 
            // lblIEMin
            // 
            lblIEMin.BackColor = SystemColors.Window;
            lblIEMin.Cursor = Cursors.Default;
            lblIEMin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblIEMin.ForeColor = SystemColors.ControlText;
            lblIEMin.Location = new Point(554, 40);
            lblIEMin.Name = "lblIEMin";
            lblIEMin.RightToLeft = RightToLeft.No;
            lblIEMin.Size = new Size(9, 17);
            lblIEMin.TabIndex = 55;
            lblIEMin.Text = "'";
            // 
            // lblHsSec
            // 
            lblHsSec.BackColor = SystemColors.Window;
            lblHsSec.Cursor = Cursors.Default;
            lblHsSec.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblHsSec.ForeColor = SystemColors.ControlText;
            lblHsSec.Location = new Point(594, 21);
            lblHsSec.Name = "lblHsSec";
            lblHsSec.RightToLeft = RightToLeft.No;
            lblHsSec.Size = new Size(9, 17);
            lblHsSec.TabIndex = 49;
            lblHsSec.Text = "\"";
            lblHsSec.Visible = false;
            // 
            // lblHsMin
            // 
            lblHsMin.BackColor = SystemColors.Window;
            lblHsMin.Cursor = Cursors.Default;
            lblHsMin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblHsMin.ForeColor = SystemColors.ControlText;
            lblHsMin.Location = new Point(554, 21);
            lblHsMin.Name = "lblHsMin";
            lblHsMin.RightToLeft = RightToLeft.No;
            lblHsMin.Size = new Size(9, 17);
            lblHsMin.TabIndex = 47;
            lblHsMin.Text = "'";
            // 
            // lblHsDeg
            // 
            lblHsDeg.BackColor = SystemColors.Window;
            lblHsDeg.Cursor = Cursors.Default;
            lblHsDeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblHsDeg.ForeColor = SystemColors.ControlText;
            lblHsDeg.Location = new Point(512, 20);
            lblHsDeg.Name = "lblHsDeg";
            lblHsDeg.RightToLeft = RightToLeft.No;
            lblHsDeg.Size = new Size(9, 17);
            lblHsDeg.TabIndex = 45;
            lblHsDeg.Text = "°";
            // 
            // lblLoMin
            // 
            lblLoMin.BackColor = SystemColors.Window;
            lblLoMin.Cursor = Cursors.Default;
            lblLoMin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLoMin.ForeColor = SystemColors.ControlText;
            lblLoMin.Location = new Point(386, 135);
            lblLoMin.Name = "lblLoMin";
            lblLoMin.RightToLeft = RightToLeft.No;
            lblLoMin.Size = new Size(9, 17);
            lblLoMin.TabIndex = 39;
            lblLoMin.Text = "'";
            // 
            // lblLoDeg
            // 
            lblLoDeg.BackColor = SystemColors.Window;
            lblLoDeg.Cursor = Cursors.Default;
            lblLoDeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLoDeg.ForeColor = SystemColors.ControlText;
            lblLoDeg.Location = new Point(344, 135);
            lblLoDeg.Name = "lblLoDeg";
            lblLoDeg.RightToLeft = RightToLeft.No;
            lblLoDeg.Size = new Size(9, 17);
            lblLoDeg.TabIndex = 38;
            lblLoDeg.Text = "°";
            // 
            // lblDRLo
            // 
            lblDRLo.BackColor = SystemColors.Window;
            lblDRLo.Cursor = Cursors.Default;
            lblDRLo.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblDRLo.ForeColor = SystemColors.ControlText;
            lblDRLo.Location = new Point(273, 138);
            lblDRLo.Name = "lblDRLo";
            lblDRLo.RightToLeft = RightToLeft.No;
            lblDRLo.Size = new Size(38, 13);
            lblDRLo.TabIndex = 34;
            lblDRLo.Text = "DR Lo";
            // 
            // lblLMin
            // 
            lblLMin.BackColor = SystemColors.Window;
            lblLMin.Cursor = Cursors.Default;
            lblLMin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLMin.ForeColor = SystemColors.ControlText;
            lblLMin.Location = new Point(386, 111);
            lblLMin.Name = "lblLMin";
            lblLMin.RightToLeft = RightToLeft.No;
            lblLMin.Size = new Size(9, 17);
            lblLMin.TabIndex = 33;
            lblLMin.Text = "'";
            // 
            // lblLDeg
            // 
            lblLDeg.BackColor = SystemColors.Window;
            lblLDeg.Cursor = Cursors.Default;
            lblLDeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLDeg.ForeColor = SystemColors.ControlText;
            lblLDeg.Location = new Point(344, 112);
            lblLDeg.Name = "lblLDeg";
            lblLDeg.RightToLeft = RightToLeft.No;
            lblLDeg.Size = new Size(9, 17);
            lblLDeg.TabIndex = 32;
            lblLDeg.Text = "°";
            // 
            // lblDRL
            // 
            lblDRL.BackColor = SystemColors.Window;
            lblDRL.Cursor = Cursors.Default;
            lblDRL.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblDRL.ForeColor = SystemColors.ControlText;
            lblDRL.Location = new Point(273, 115);
            lblDRL.Name = "lblDRL";
            lblDRL.RightToLeft = RightToLeft.No;
            lblDRL.Size = new Size(30, 13);
            lblDRL.TabIndex = 28;
            lblDRL.Text = "DR L";
            // 
            // lblBody
            // 
            lblBody.BackColor = SystemColors.Window;
            lblBody.Cursor = Cursors.Default;
            lblBody.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblBody.ForeColor = SystemColors.ControlText;
            lblBody.Location = new Point(273, 30);
            lblBody.Name = "lblBody";
            lblBody.RightToLeft = RightToLeft.No;
            lblBody.Size = new Size(35, 17);
            lblBody.TabIndex = 25;
            lblBody.Text = "Body";
            // 
            // lblWEsec
            // 
            lblWEsec.BackColor = SystemColors.Window;
            lblWEsec.Cursor = Cursors.Default;
            lblWEsec.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblWEsec.ForeColor = SystemColors.ControlText;
            lblWEsec.Location = new Point(146, 98);
            lblWEsec.Name = "lblWEsec";
            lblWEsec.RightToLeft = RightToLeft.No;
            lblWEsec.Size = new Size(26, 17);
            lblWEsec.TabIndex = 13;
            lblWEsec.Text = "sec";
            // 
            // lblWEmin
            // 
            lblWEmin.BackColor = SystemColors.Window;
            lblWEmin.Cursor = Cursors.Default;
            lblWEmin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblWEmin.ForeColor = SystemColors.ControlText;
            lblWEmin.Location = new Point(90, 98);
            lblWEmin.Name = "lblWEmin";
            lblWEmin.RightToLeft = RightToLeft.No;
            lblWEmin.Size = new Size(23, 17);
            lblWEmin.TabIndex = 11;
            lblWEmin.Text = "min";
            // 
            // TimeTxtBx
            // 
            TimeTxtBx.BackColor = SystemColors.ButtonFace;
            TimeTxtBx.BorderStyle = BorderStyle.FixedSingle;
            TimeTxtBx.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TimeTxtBx.Location = new Point(33, 205);
            TimeTxtBx.Multiline = false;
            TimeTxtBx.Name = "TimeTxtBx";
            TimeTxtBx.ReadOnly = true;
            TimeTxtBx.Size = new Size(228, 19);
            TimeTxtBx.TabIndex = 101;
            TimeTxtBx.Text = "";
            // 
            // LHATxtBx
            // 
            LHATxtBx.BackColor = SystemColors.ButtonFace;
            LHATxtBx.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            LHATxtBx.Location = new Point(33, 397);
            LHATxtBx.Multiline = false;
            LHATxtBx.Name = "LHATxtBx";
            LHATxtBx.ReadOnly = true;
            LHATxtBx.Size = new Size(228, 19);
            LHATxtBx.TabIndex = 102;
            LHATxtBx.Text = "";
            // 
            // AltitudeTxtBx
            // 
            AltitudeTxtBx.BackColor = SystemColors.ButtonFace;
            AltitudeTxtBx.BorderStyle = BorderStyle.FixedSingle;
            AltitudeTxtBx.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            AltitudeTxtBx.ForeColor = SystemColors.WindowText;
            AltitudeTxtBx.Location = new Point(449, 205);
            AltitudeTxtBx.Multiline = false;
            AltitudeTxtBx.Name = "AltitudeTxtBx";
            AltitudeTxtBx.ReadOnly = true;
            AltitudeTxtBx.Size = new Size(260, 19);
            AltitudeTxtBx.TabIndex = 105;
            AltitudeTxtBx.Text = "";
            // 
            // IntAzTxtBx
            // 
            IntAzTxtBx.BackColor = SystemColors.ButtonFace;
            IntAzTxtBx.BorderStyle = BorderStyle.FixedSingle;
            IntAzTxtBx.Font = new Font("Courier New", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            IntAzTxtBx.Location = new Point(33, 625);
            IntAzTxtBx.Name = "IntAzTxtBx";
            IntAzTxtBx.ReadOnly = true;
            IntAzTxtBx.Size = new Size(676, 175);
            IntAzTxtBx.TabIndex = 106;
            IntAzTxtBx.Text = "";
            // 
            // ExitBtn
            // 
            _ExitBtn.BackColor = Color.Red;
            _ExitBtn.Cursor = Cursors.Default;
            _ExitBtn.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _ExitBtn.ForeColor = SystemColors.ControlLightLight;
            _ExitBtn.Location = new Point(626, 845);
            _ExitBtn.Name = "_ExitBtn";
            _ExitBtn.RightToLeft = RightToLeft.No;
            _ExitBtn.Size = new Size(80, 25);
            _ExitBtn.TabIndex = 107;
            _ExitBtn.Text = "Exit";
            _ExitBtn.UseVisualStyleBackColor = false;
            // 
            // EqTPicBx
            // 
            _EqTPicBx.Enabled = false;
            _EqTPicBx.ErrorImage = null;
            _EqTPicBx.InitialImage = null;
            _EqTPicBx.Location = new Point(268, 322);
            _EqTPicBx.Name = "_EqTPicBx";
            _EqTPicBx.Size = new Size(175, 181);
            _EqTPicBx.TabIndex = 108;
            _EqTPicBx.TabStop = false;
            _EqTPicBx.Visible = false;
            // 
            // FrameHorizon
            // 
            FrameHorizon.BackColor = SystemColors.Window;
            FrameHorizon.BorderStyle = BorderStyle.FixedSingle;
            FrameHorizon.Controls.Add(_optHorizonBubble);
            FrameHorizon.Controls.Add(_optHorizonDipShort);
            FrameHorizon.Controls.Add(_optHorizonArtificial);
            FrameHorizon.Controls.Add(_optHorizonNatural);
            FrameHorizon.Cursor = Cursors.Default;
            FrameHorizon.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FrameHorizon.ForeColor = SystemColors.ControlText;
            FrameHorizon.Location = new Point(479, 64);
            FrameHorizon.Name = "FrameHorizon";
            FrameHorizon.RightToLeft = RightToLeft.No;
            FrameHorizon.Size = new Size(230, 20);
            FrameHorizon.TabIndex = 117;
            FrameHorizon.Text = "Frame4";
            // 
            // optHorizonBubble
            // 
            _optHorizonBubble.BackColor = SystemColors.Window;
            _optHorizonBubble.Cursor = Cursors.Default;
            _optHorizonBubble.Font = new Font("Arial Narrow", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optHorizonBubble.ForeColor = SystemColors.ControlText;
            _optHorizonBubble.Location = new Point(175, 0);
            _optHorizonBubble.Name = "_optHorizonBubble";
            _optHorizonBubble.RightToLeft = RightToLeft.No;
            _optHorizonBubble.Size = new Size(57, 18);
            _optHorizonBubble.TabIndex = 104;
            _optHorizonBubble.TabStop = true;
            _optHorizonBubble.Text = "Bubble";
            _optHorizonBubble.UseVisualStyleBackColor = false;
            // 
            // optHorizonDipShort
            // 
            _optHorizonDipShort.BackColor = SystemColors.Window;
            _optHorizonDipShort.Cursor = Cursors.Default;
            _optHorizonDipShort.Font = new Font("Arial Narrow", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optHorizonDipShort.ForeColor = SystemColors.ControlText;
            _optHorizonDipShort.Location = new Point(113, 0);
            _optHorizonDipShort.Name = "_optHorizonDipShort";
            _optHorizonDipShort.RightToLeft = RightToLeft.No;
            _optHorizonDipShort.Size = new Size(66, 18);
            _optHorizonDipShort.TabIndex = 60;
            _optHorizonDipShort.TabStop = true;
            _optHorizonDipShort.Text = "Dip Short";
            _optHorizonDipShort.UseVisualStyleBackColor = false;
            // 
            // optHorizonArtificial
            // 
            _optHorizonArtificial.BackColor = SystemColors.Window;
            _optHorizonArtificial.Cursor = Cursors.Default;
            _optHorizonArtificial.Font = new Font("Arial Narrow", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optHorizonArtificial.ForeColor = SystemColors.ControlText;
            _optHorizonArtificial.Location = new Point(59, 0);
            _optHorizonArtificial.Name = "_optHorizonArtificial";
            _optHorizonArtificial.RightToLeft = RightToLeft.No;
            _optHorizonArtificial.Size = new Size(58, 18);
            _optHorizonArtificial.TabIndex = 59;
            _optHorizonArtificial.TabStop = true;
            _optHorizonArtificial.Text = "Artificial";
            _optHorizonArtificial.UseVisualStyleBackColor = false;
            // 
            // optHorizonNatural
            // 
            _optHorizonNatural.BackColor = SystemColors.Window;
            _optHorizonNatural.Checked = true;
            _optHorizonNatural.Cursor = Cursors.Default;
            _optHorizonNatural.Font = new Font("Arial Narrow", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optHorizonNatural.ForeColor = SystemColors.ControlText;
            _optHorizonNatural.Location = new Point(2, 0);
            _optHorizonNatural.Name = "_optHorizonNatural";
            _optHorizonNatural.RightToLeft = RightToLeft.No;
            _optHorizonNatural.Size = new Size(57, 18);
            _optHorizonNatural.TabIndex = 58;
            _optHorizonNatural.TabStop = true;
            _optHorizonNatural.Text = "Natural";
            _optHorizonNatural.UseVisualStyleBackColor = false;
            // 
            // frmLimb
            // 
            frmLimb.BorderStyle = BorderStyle.FixedSingle;
            frmLimb.Controls.Add(_optCenter);
            frmLimb.Controls.Add(_optUpper);
            frmLimb.Controls.Add(_optLower);
            frmLimb.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            frmLimb.Location = new Point(276, 58);
            frmLimb.Name = "frmLimb";
            frmLimb.Size = new Size(164, 20);
            frmLimb.TabIndex = 119;
            // 
            // optCenter
            // 
            _optCenter.AutoSize = true;
            _optCenter.Location = new Point(110, 1);
            _optCenter.Name = "_optCenter";
            _optCenter.Size = new Size(57, 18);
            _optCenter.TabIndex = 2;
            _optCenter.TabStop = true;
            _optCenter.Text = "Center";
            _optCenter.UseVisualStyleBackColor = true;
            // 
            // optUpper
            // 
            _optUpper.AutoSize = true;
            _optUpper.Location = new Point(60, 1);
            _optUpper.Name = "_optUpper";
            _optUpper.Size = new Size(54, 18);
            _optUpper.TabIndex = 1;
            _optUpper.TabStop = true;
            _optUpper.Text = "Upper";
            _optUpper.UseVisualStyleBackColor = true;
            // 
            // optLower
            // 
            _optLower.AutoSize = true;
            _optLower.Checked = true;
            _optLower.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optLower.Location = new Point(2, 1);
            _optLower.Name = "_optLower";
            _optLower.Size = new Size(57, 18);
            _optLower.TabIndex = 0;
            _optLower.TabStop = true;
            _optLower.Text = "Lower";
            _optLower.UseVisualStyleBackColor = true;
            // 
            // LimbTxt
            // 
            LimbTxt.BackColor = SystemColors.Window;
            LimbTxt.BorderStyle = BorderStyle.None;
            LimbTxt.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            LimbTxt.Location = new Point(280, 48);
            LimbTxt.Name = "LimbTxt";
            LimbTxt.ReadOnly = true;
            LimbTxt.Size = new Size(23, 13);
            LimbTxt.TabIndex = 120;
            LimbTxt.Text = "Limb";
            // 
            // cboPlanets
            // 
            cboPlanets.BackColor = SystemColors.Window;
            cboPlanets.Cursor = Cursors.Default;
            cboPlanets.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPlanets.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboPlanets.ForeColor = SystemColors.WindowText;
            cboPlanets.Items.AddRange(new object[] { "NA vals. of v/d", "Accurate vals. of v/d" });
            cboPlanets.Location = new Point(276, 84);
            cboPlanets.Name = "cboPlanets";
            cboPlanets.RightToLeft = RightToLeft.No;
            cboPlanets.Size = new Size(161, 22);
            cboPlanets.TabIndex = 121;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.ABC_white;
            PictureBox1.Location = new Point(428, 809);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(279, 33);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 122;
            PictureBox1.TabStop = false;
            // 
            // DTSight
            // 
            DTSight.CustomFormat = "MM / dd / yyyy HH:mm:ss ";
            DTSight.DropDownAlign = LeftRightAlignment.Right;
            DTSight.Format = DateTimePickerFormat.Custom;
            DTSight.Location = new Point(112, 60);
            DTSight.Name = "DTSight";
            DTSight.ShowUpDown = true;
            DTSight.Size = new Size(146, 21);
            DTSight.TabIndex = 124;
            // 
            // lblDate
            // 
            lblDate.BackColor = SystemColors.Window;
            lblDate.Cursor = Cursors.Default;
            lblDate.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblDate.ForeColor = SystemColors.ControlText;
            lblDate.Location = new Point(40, 54);
            lblDate.Name = "lblDate";
            lblDate.RightToLeft = RightToLeft.No;
            lblDate.Size = new Size(65, 34);
            lblDate.TabIndex = 123;
            lblDate.Text = "Sight Date" + '\r' + '\n' + "Watch Time";
            lblDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnCLSPlot
            // 
            _btnCLSPlot.BackColor = Color.Yellow;
            _btnCLSPlot.Cursor = Cursors.Default;
            _btnCLSPlot.Font = new Font("Arial Narrow", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnCLSPlot.ForeColor = SystemColors.ControlText;
            _btnCLSPlot.Location = new Point(158, 808);
            _btnCLSPlot.Name = "_btnCLSPlot";
            _btnCLSPlot.RightToLeft = RightToLeft.No;
            _btnCLSPlot.Size = new Size(120, 23);
            _btnCLSPlot.TabIndex = 125;
            _btnCLSPlot.Text = "CLS Form Plot";
            _btnCLSPlot.UseVisualStyleBackColor = false;
            _btnCLSPlot.Visible = false;
            // 
            // btnCustomPlot
            // 
            _btnCustomPlot.BackColor = Color.Yellow;
            _btnCustomPlot.Font = new Font("Arial Narrow", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnCustomPlot.ForeColor = SystemColors.WindowText;
            _btnCustomPlot.Location = new Point(158, 837);
            _btnCustomPlot.Name = "_btnCustomPlot";
            _btnCustomPlot.Size = new Size(120, 23);
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
            _cmdMerDiag.Location = new Point(33, 837);
            _cmdMerDiag.Name = "_cmdMerDiag";
            _cmdMerDiag.Size = new Size(120, 23);
            _cmdMerDiag.TabIndex = 176;
            _cmdMerDiag.Text = "Meridian Diagram";
            _cmdMerDiag.UseVisualStyleBackColor = false;
            _cmdMerDiag.Visible = false;
            // 
            // DGSight
            // 
            _DGSight.AllowUserToAddRows = false;
            _DGSight.AllowUserToDeleteRows = false;
            _DGSight.AllowUserToResizeColumns = false;
            _DGSight.AllowUserToResizeRows = false;
            _DGSight.BackgroundColor = Color.White;
            _DGSight.BorderStyle = BorderStyle.Fixed3D;
            _DGSight.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle1.BackColor = SystemColors.Control;
            DataGridViewCellStyle1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            _DGSight.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1;
            _DGSight.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _DGSight.Cursor = Cursors.Default;
            _DGSight.EditMode = DataGridViewEditMode.EditProgrammatically;
            _DGSight.Location = new Point(268, 226);
            _DGSight.MultiSelect = false;
            _DGSight.Name = "_DGSight";
            _DGSight.ReadOnly = true;
            _DGSight.RightToLeft = RightToLeft.No;
            _DGSight.RowHeadersVisible = false;
            _DGSight.RowTemplate.ReadOnly = true;
            _DGSight.SelectionMode = DataGridViewSelectionMode.CellSelect;
            _DGSight.Size = new Size(175, 90);
            _DGSight.TabIndex = 177;
            // 
            // SightTxtBx
            // 
            SightTxtBx.BackColor = SystemColors.ButtonFace;
            SightTxtBx.BorderStyle = BorderStyle.FixedSingle;
            SightTxtBx.Font = new Font("Arial Narrow", 6.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            SightTxtBx.ForeColor = SystemColors.WindowText;
            SightTxtBx.Location = new Point(268, 205);
            SightTxtBx.Name = "SightTxtBx";
            SightTxtBx.Size = new Size(175, 18);
            SightTxtBx.TabIndex = 178;
            // 
            // DecTxtBx
            // 
            DecTxtBx.BackColor = SystemColors.ButtonFace;
            DecTxtBx.Font = new Font("Arial", 6.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DecTxtBx.Location = new Point(267, 509);
            DecTxtBx.Name = "DecTxtBx";
            DecTxtBx.Size = new Size(175, 18);
            DecTxtBx.TabIndex = 179;
            // 
            // DGDec
            // 
            _DGDec.AllowUserToAddRows = false;
            _DGDec.AllowUserToDeleteRows = false;
            _DGDec.AllowUserToResizeColumns = false;
            _DGDec.AllowUserToResizeRows = false;
            _DGDec.BackgroundColor = Color.White;
            _DGDec.BorderStyle = BorderStyle.Fixed3D;
            _DGDec.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle2.BackColor = SystemColors.Control;
            DataGridViewCellStyle2.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            _DGDec.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            _DGDec.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _DGDec.Cursor = Cursors.Default;
            _DGDec.EditMode = DataGridViewEditMode.EditProgrammatically;
            _DGDec.Location = new Point(267, 530);
            _DGDec.MultiSelect = false;
            _DGDec.Name = "_DGDec";
            _DGDec.ReadOnly = true;
            _DGDec.RightToLeft = RightToLeft.No;
            _DGDec.RowHeadersVisible = false;
            _DGDec.RowTemplate.ReadOnly = true;
            _DGDec.SelectionMode = DataGridViewSelectionMode.CellSelect;
            _DGDec.Size = new Size(175, 90);
            _DGDec.TabIndex = 180;
            // 
            // DGTime
            // 
            _DGTime.AllowUserToAddRows = false;
            _DGTime.AllowUserToDeleteRows = false;
            _DGTime.AllowUserToResizeColumns = false;
            _DGTime.AllowUserToResizeRows = false;
            _DGTime.BackgroundColor = Color.White;
            _DGTime.BorderStyle = BorderStyle.Fixed3D;
            _DGTime.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle3.BackColor = SystemColors.Control;
            DataGridViewCellStyle3.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            _DGTime.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3;
            _DGTime.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _DGTime.Cursor = Cursors.Default;
            _DGTime.EditMode = DataGridViewEditMode.EditProgrammatically;
            _DGTime.Location = new Point(33, 226);
            _DGTime.MultiSelect = false;
            _DGTime.Name = "_DGTime";
            _DGTime.ReadOnly = true;
            _DGTime.RightToLeft = RightToLeft.No;
            _DGTime.RowHeadersVisible = false;
            _DGTime.RowTemplate.ReadOnly = true;
            _DGTime.SelectionMode = DataGridViewSelectionMode.CellSelect;
            _DGTime.Size = new Size(228, 160);
            _DGTime.TabIndex = 181;
            // 
            // DGLHA
            // 
            _DGLHA.AllowUserToAddRows = false;
            _DGLHA.AllowUserToDeleteRows = false;
            _DGLHA.AllowUserToResizeColumns = false;
            _DGLHA.AllowUserToResizeRows = false;
            _DGLHA.BackgroundColor = Color.White;
            _DGLHA.BorderStyle = BorderStyle.Fixed3D;
            _DGLHA.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle4.BackColor = SystemColors.Control;
            DataGridViewCellStyle4.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            _DGLHA.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4;
            _DGLHA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _DGLHA.Cursor = Cursors.Default;
            _DGLHA.EditMode = DataGridViewEditMode.EditProgrammatically;
            _DGLHA.Location = new Point(34, 419);
            _DGLHA.MultiSelect = false;
            _DGLHA.Name = "_DGLHA";
            _DGLHA.ReadOnly = true;
            _DGLHA.RightToLeft = RightToLeft.No;
            _DGLHA.RowHeadersVisible = false;
            _DGLHA.RowTemplate.ReadOnly = true;
            _DGLHA.SelectionMode = DataGridViewSelectionMode.CellSelect;
            _DGLHA.Size = new Size(228, 200);
            _DGLHA.TabIndex = 182;
            // 
            // DGAlt
            // 
            _DGAlt.AllowUserToAddRows = false;
            _DGAlt.AllowUserToDeleteRows = false;
            _DGAlt.AllowUserToResizeColumns = false;
            _DGAlt.AllowUserToResizeRows = false;
            _DGAlt.BackgroundColor = Color.White;
            _DGAlt.BorderStyle = BorderStyle.Fixed3D;
            _DGAlt.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle5.BackColor = SystemColors.Control;
            DataGridViewCellStyle5.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            _DGAlt.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5;
            _DGAlt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _DGAlt.Cursor = Cursors.Default;
            _DGAlt.EditMode = DataGridViewEditMode.EditProgrammatically;
            _DGAlt.Location = new Point(449, 226);
            _DGAlt.MultiSelect = false;
            _DGAlt.Name = "_DGAlt";
            _DGAlt.ReadOnly = true;
            _DGAlt.RightToLeft = RightToLeft.No;
            _DGAlt.RowHeadersVisible = false;
            _DGAlt.RowTemplate.ReadOnly = true;
            _DGAlt.SelectionMode = DataGridViewSelectionMode.CellSelect;
            _DGAlt.Size = new Size(260, 394);
            _DGAlt.TabIndex = 183;
            // 
            // txtUserInfo
            // 
            txtUserInfo.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtUserInfo.HideSelection = false;
            txtUserInfo.Location = new Point(88, 1);
            txtUserInfo.Name = "txtUserInfo";
            txtUserInfo.Size = new Size(375, 20);
            txtUserInfo.TabIndex = 200;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label7.Location = new Point(33, 4);
            Label7.Name = "Label7";
            Label7.Size = new Size(51, 14);
            Label7.TabIndex = 199;
            Label7.Text = "User Info";
            Label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnExpandTimeDiag
            // 
            _btnExpandTimeDiag.BackColor = Color.Yellow;
            _btnExpandTimeDiag.Font = new Font("Arial Narrow", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnExpandTimeDiag.ForeColor = SystemColors.WindowText;
            _btnExpandTimeDiag.Location = new Point(33, 808);
            _btnExpandTimeDiag.Name = "_btnExpandTimeDiag";
            _btnExpandTimeDiag.Size = new Size(120, 23);
            _btnExpandTimeDiag.TabIndex = 201;
            _btnExpandTimeDiag.Text = "Expand Time Diagram";
            _btnExpandTimeDiag.UseVisualStyleBackColor = false;
            _btnExpandTimeDiag.Visible = false;
            // 
            // ClearAllBtn
            // 
            _ClearAllBtn.BackColor = SystemColors.Control;
            _ClearAllBtn.Cursor = Cursors.Default;
            _ClearAllBtn.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _ClearAllBtn.ForeColor = SystemColors.ControlText;
            _ClearAllBtn.Location = new Point(428, 845);
            _ClearAllBtn.Name = "_ClearAllBtn";
            _ClearAllBtn.RightToLeft = RightToLeft.No;
            _ClearAllBtn.Size = new Size(174, 25);
            _ClearAllBtn.TabIndex = 109;
            _ClearAllBtn.Text = "Clear Sight Report / Retain Input";
            _ClearAllBtn.UseVisualStyleBackColor = false;
            // 
            // cboLLoBy
            // 
            cboLLoBy.BackColor = SystemColors.Window;
            cboLLoBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLLoBy.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboLLoBy.FormattingEnabled = true;
            cboLLoBy.Items.AddRange(new object[] { "DR", "GPS", "KP" });
            cboLLoBy.Location = new Point(189, 28);
            cboLLoBy.Name = "cboLLoBy";
            cboLLoBy.Size = new Size(70, 23);
            cboLLoBy.TabIndex = 203;
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label9.Location = new Point(134, 32);
            Label9.Name = "Label9";
            Label9.Size = new Size(52, 15);
            Label9.TabIndex = 202;
            Label9.Text = "L/Lo by:";
            Label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormSRF
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Window;
            ClientSize = new Size(727, 873);
            Controls.Add(cboLLoBy);
            Controls.Add(Label9);
            Controls.Add(_btnExpandTimeDiag);
            Controls.Add(txtUserInfo);
            Controls.Add(Label7);
            Controls.Add(_DGAlt);
            Controls.Add(_DGLHA);
            Controls.Add(_DGTime);
            Controls.Add(_DGDec);
            Controls.Add(DecTxtBx);
            Controls.Add(SightTxtBx);
            Controls.Add(_DGSight);
            Controls.Add(_cmdMerDiag);
            Controls.Add(_btnCustomPlot);
            Controls.Add(_btnCLSPlot);
            Controls.Add(DTSight);
            Controls.Add(lblDate);
            Controls.Add(PictureBox1);
            Controls.Add(LimbTxt);
            Controls.Add(frmLimb);
            Controls.Add(FrameHorizon);
            Controls.Add(AltitudeTxtBx);
            Controls.Add(LHATxtBx);
            Controls.Add(TimeTxtBx);
            Controls.Add(_ClearAllBtn);
            Controls.Add(_ExitBtn);
            Controls.Add(IntAzTxtBx);
            Controls.Add(cboStars);
            Controls.Add(_cboLo);
            Controls.Add(cboL);
            Controls.Add(cboSun);
            Controls.Add(chkDST);
            Controls.Add(_txtIESec);
            Controls.Add(_txtSightNo);
            Controls.Add(_cmdPrint);
            Controls.Add(_cmdFix);
            Controls.Add(_cmdSave);
            Controls.Add(_txtIEdeg);
            Controls.Add(cboZDm);
            Controls.Add(_txtLDeg);
            Controls.Add(_cboPolaris);
            Controls.Add(cboDsUnit);
            Controls.Add(_txtDsDist);
            Controls.Add(Framehs);
            Controls.Add(FrameZD);
            Controls.Add(_cmdReduce);
            Controls.Add(_cboPressure);
            Controls.Add(_txtPressure);
            Controls.Add(_cboTemperature);
            Controls.Add(_txtTemperature);
            Controls.Add(cboIE);
            Controls.Add(_txtIEmin);
            Controls.Add(cboHE);
            Controls.Add(_txtHE);
            Controls.Add(_txtHsSec);
            Controls.Add(_txtHsMin);
            Controls.Add(_txtHsDeg);
            Controls.Add(_txtLoMin);
            Controls.Add(_txtLoDeg);
            Controls.Add(_txtLMin);
            Controls.Add(_cboBody);
            Controls.Add(_txtZDh);
            Controls.Add(cboWE);
            Controls.Add(_txtWESec);
            Controls.Add(_txtWEMin);
            Controls.Add(FrameTP);
            Controls.Add(FrameHo);
            Controls.Add(lblZDDST);
            Controls.Add(lblIEsec);
            Controls.Add(lblHoCorrs);
            Controls.Add(lblSightNo);
            Controls.Add(lblIEdeg);
            Controls.Add(lblZDm);
            Controls.Add(lblZDh);
            Controls.Add(lblDsDist);
            Controls.Add(lblHorizon);
            Controls.Add(lblPressure);
            Controls.Add(lblTempDeg);
            Controls.Add(lblTemperature);
            Controls.Add(lblStdT_P);
            Controls.Add(lblIEMin);
            Controls.Add(lblIE);
            Controls.Add(lblHE);
            Controls.Add(lblHsSec);
            Controls.Add(lblHsMin);
            Controls.Add(lblHsDeg);
            Controls.Add(lblHs);
            Controls.Add(lblHsFormat);
            Controls.Add(lblLoMin);
            Controls.Add(lblLoDeg);
            Controls.Add(lblDRLo);
            Controls.Add(lblLMin);
            Controls.Add(lblLDeg);
            Controls.Add(lblDRL);
            Controls.Add(lblBody);
            Controls.Add(lblZD);
            Controls.Add(lblZDAutoManual);
            Controls.Add(lblWEsec);
            Controls.Add(lblWEmin);
            Controls.Add(lblWE);
            Controls.Add(_EqTPicBx);
            Controls.Add(cboPlanets);
            Cursor = Cursors.Default;
            Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(56, 29);
            Name = "FormSRF";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.Manual;
            Text = "Sight Reduction";
            Framehs.ResumeLayout(false);
            FrameZD.ResumeLayout(false);
            FrameTP.ResumeLayout(false);
            FrameHo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_EqTPicBx).EndInit();
            FrameHorizon.ResumeLayout(false);
            frmLimb.ResumeLayout(false);
            frmLimb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)_DGSight).EndInit();
            ((System.ComponentModel.ISupportInitialize)_DGDec).EndInit();
            ((System.ComponentModel.ISupportInitialize)_DGTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)_DGLHA).EndInit();
            ((System.ComponentModel.ISupportInitialize)_DGAlt).EndInit();
            Load += new EventHandler(FormSRF_Load);
            FormClosed += new FormClosedEventHandler(FormSRF_FormClosed);
            ResumeLayout(false);
            PerformLayout();
        }

        internal RichTextBox TimeTxtBx;
        internal RichTextBox LHATxtBx;
        internal RichTextBox AltitudeTxtBx;
        internal RichTextBox IntAzTxtBx;
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

        private PictureBox _EqTPicBx;

        internal PictureBox EqTPicBx
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _EqTPicBx;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_EqTPicBx != null)
                {
                    _EqTPicBx.Click -= EqTPicBx_Click;
                    _EqTPicBx.Paint -= EqTPicBx_Paint;
                }

                _EqTPicBx = value;
                if (_EqTPicBx != null)
                {
                    _EqTPicBx.Click += EqTPicBx_Click;
                    _EqTPicBx.Paint += EqTPicBx_Paint;
                }
            }
        }

        public Panel FrameHorizon;
        private RadioButton _optHorizonBubble;

        public RadioButton optHorizonBubble
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optHorizonBubble;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optHorizonBubble != null)
                {
                    _optHorizonBubble.CheckedChanged -= optHorizonBubble_CheckedChanged;
                }

                _optHorizonBubble = value;
                if (_optHorizonBubble != null)
                {
                    _optHorizonBubble.CheckedChanged += optHorizonBubble_CheckedChanged;
                }
            }
        }

        private RadioButton _optHorizonDipShort;

        public RadioButton optHorizonDipShort
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optHorizonDipShort;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optHorizonDipShort != null)
                {
                    _optHorizonDipShort.CheckedChanged -= optHorizonDipShort_CheckedChanged;
                }

                _optHorizonDipShort = value;
                if (_optHorizonDipShort != null)
                {
                    _optHorizonDipShort.CheckedChanged += optHorizonDipShort_CheckedChanged;
                }
            }
        }

        private RadioButton _optHorizonArtificial;

        public RadioButton optHorizonArtificial
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optHorizonArtificial;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optHorizonArtificial != null)
                {
                    _optHorizonArtificial.CheckedChanged -= optHorizonArtificial_CheckedChanged;
                }

                _optHorizonArtificial = value;
                if (_optHorizonArtificial != null)
                {
                    _optHorizonArtificial.CheckedChanged += optHorizonArtificial_CheckedChanged;
                }
            }
        }

        private RadioButton _optHorizonNatural;

        public RadioButton optHorizonNatural
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optHorizonNatural;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optHorizonNatural != null)
                {
                    _optHorizonNatural.CheckedChanged -= optHorizonNatural_CheckedChanged;
                }

                _optHorizonNatural = value;
                if (_optHorizonNatural != null)
                {
                    _optHorizonNatural.CheckedChanged += optHorizonNatural_CheckedChanged;
                }
            }
        }

        internal Panel frmLimb;
        private RadioButton _optCenter;

        internal RadioButton optCenter
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

        private RadioButton _optUpper;

        internal RadioButton optUpper
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optUpper;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optUpper != null)
                {
                    _optUpper.CheckedChanged -= optUpper_CheckedChanged;
                }

                _optUpper = value;
                if (_optUpper != null)
                {
                    _optUpper.CheckedChanged += optUpper_CheckedChanged;
                }
            }
        }

        private RadioButton _optLower;

        internal RadioButton optLower
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optLower;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optLower != null)
                {
                    _optLower.CheckedChanged -= optLower_CheckedChanged;
                }

                _optLower = value;
                if (_optLower != null)
                {
                    _optLower.CheckedChanged += optLower_CheckedChanged;
                }
            }
        }

        internal TextBox LimbTxt;
        public ComboBox cboPlanets;
        internal PictureBox PictureBox1;
        internal DateTimePicker DTSight;
        public Label lblDate;
        private Button _btnCLSPlot;

        public Button btnCLSPlot
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnCLSPlot;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnCLSPlot != null)
                {
                    _btnCLSPlot.Click -= btnCLSPlot_Click;
                }

                _btnCLSPlot = value;
                if (_btnCLSPlot != null)
                {
                    _btnCLSPlot.Click += btnCLSPlot_Click;
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
                    _cmdMerDiag.Click -= cmdMerDiag_Click;
                }

                _cmdMerDiag = value;
                if (_cmdMerDiag != null)
                {
                    _cmdMerDiag.Click += cmdMerDiag_Click;
                }
            }
        }

        private DataGridView _DGSight;

        internal DataGridView DGSight
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _DGSight;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_DGSight != null)
                {
                    _DGSight.SelectionChanged -= DGSight_SelectionChanged;
                }

                _DGSight = value;
                if (_DGSight != null)
                {
                    _DGSight.SelectionChanged += DGSight_SelectionChanged;
                }
            }
        }

        internal TextBox SightTxtBx;
        internal TextBox DecTxtBx;
        private DataGridView _DGDec;

        internal DataGridView DGDec
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _DGDec;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_DGDec != null)
                {
                    _DGDec.SelectionChanged -= DGDec_SelectionChanged;
                }

                _DGDec = value;
                if (_DGDec != null)
                {
                    _DGDec.SelectionChanged += DGDec_SelectionChanged;
                }
            }
        }

        private DataGridView _DGTime;

        internal DataGridView DGTime
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _DGTime;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_DGTime != null)
                {
                    _DGTime.SelectionChanged -= DGTime_SelectionChanged;
                }

                _DGTime = value;
                if (_DGTime != null)
                {
                    _DGTime.SelectionChanged += DGTime_SelectionChanged;
                }
            }
        }

        private DataGridView _DGLHA;

        internal DataGridView DGLHA
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _DGLHA;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_DGLHA != null)
                {
                    _DGLHA.SelectionChanged -= DGLHA_SelectionChanged;
                }

                _DGLHA = value;
                if (_DGLHA != null)
                {
                    _DGLHA.SelectionChanged += DGLHA_SelectionChanged;
                }
            }
        }

        private DataGridView _DGAlt;

        internal DataGridView DGAlt
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _DGAlt;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_DGAlt != null)
                {
                    _DGAlt.SelectionChanged -= DGAlt_SelectionChanged;
                }

                _DGAlt = value;
                if (_DGAlt != null)
                {
                    _DGAlt.SelectionChanged += DGAlt_SelectionChanged;
                }
            }
        }

        internal TextBox txtUserInfo;
        internal Label Label7;
        private Button _btnExpandTimeDiag;

        internal Button btnExpandTimeDiag
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnExpandTimeDiag;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnExpandTimeDiag != null)
                {
                    _btnExpandTimeDiag.Click -= btnExpandTimeDiag_Click;
                }

                _btnExpandTimeDiag = value;
                if (_btnExpandTimeDiag != null)
                {
                    _btnExpandTimeDiag.Click += btnExpandTimeDiag_Click;
                }
            }
        }

        private Button _ClearAllBtn;

        public Button ClearAllBtn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ClearAllBtn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ClearAllBtn != null)
                {
                    _ClearAllBtn.Click -= ClearAllBtn_Click;
                }

                _ClearAllBtn = value;
                if (_ClearAllBtn != null)
                {
                    _ClearAllBtn.Click += ClearAllBtn_Click;
                }
            }
        }

        internal ComboBox cboLLoBy;
        internal Label Label9;
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}