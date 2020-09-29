using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    [DesignerGenerated()]
    internal partial class FormNoonSight
    {
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        [DebuggerNonUserCode()]
        public FormNoonSight() : base()
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

        private RadioButton _OptStdTPYes;

        public RadioButton OptStdTPYes
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _OptStdTPYes;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_OptStdTPYes != null)
                {
                    _OptStdTPYes.CheckedChanged -= optStdTPYes_CheckedChanged;
                }

                _OptStdTPYes = value;
                if (_OptStdTPYes != null)
                {
                    _OptStdTPYes.CheckedChanged += optStdTPYes_CheckedChanged;
                }
            }
        }

        public TextBox txtTime;
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
                    _chkDST.CheckStateChanged -= chkDST_CheckStateChanged;
                    _chkDST.CheckedChanged -= chkDST_CheckedChanged;
                }

                _chkDST = value;
                if (_chkDST != null)
                {
                    _chkDST.CheckStateChanged += chkDST_CheckStateChanged;
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

        private RadioButton _optDRL;

        public RadioButton optDRL
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optDRL;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optDRL != null)
                {
                    _optDRL.CheckedChanged -= optDRL_CheckedChanged;
                }

                _optDRL = value;
                if (_optDRL != null)
                {
                    _optDRL.CheckedChanged += optDRL_CheckedChanged;
                }
            }
        }

        private TextBox _txtDRLMin;

        public TextBox txtDRLMin
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtDRLMin;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtDRLMin != null)
                {
                    _txtDRLMin.TextChanged -= txtDRLMin_TextChanged;
                    _txtDRLMin.KeyPress -= txtDRLMin_KeyPress;
                    _txtDRLMin.Validating -= txtDRLMin_Validating;
                    _txtDRLMin.Enter -= txtDRLMin_Enter;
                }

                _txtDRLMin = value;
                if (_txtDRLMin != null)
                {
                    _txtDRLMin.TextChanged += txtDRLMin_TextChanged;
                    _txtDRLMin.KeyPress += txtDRLMin_KeyPress;
                    _txtDRLMin.Validating += txtDRLMin_Validating;
                    _txtDRLMin.Enter += txtDRLMin_Enter;
                }
            }
        }

        private ComboBox _cboDRL;

        public ComboBox cboDRL
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboDRL;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboDRL != null)
                {
                    _cboDRL.SelectedIndexChanged -= cboDRL_SelectedIndexChanged;
                }

                _cboDRL = value;
                if (_cboDRL != null)
                {
                    _cboDRL.SelectedIndexChanged += cboDRL_SelectedIndexChanged;
                }
            }
        }

        private TextBox _txtDRLDeg;

        public TextBox txtDRLDeg
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtDRLDeg;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtDRLDeg != null)
                {
                    _txtDRLDeg.TextChanged -= txtDRLDeg_TextChanged;
                    _txtDRLDeg.KeyPress -= txtDRLDeg_KeyPress;
                    _txtDRLDeg.Validating -= txtDRLDeg_Validating;
                    _txtDRLDeg.Enter -= txtDRLDeg_Enter;
                }

                _txtDRLDeg = value;
                if (_txtDRLDeg != null)
                {
                    _txtDRLDeg.TextChanged += txtDRLDeg_TextChanged;
                    _txtDRLDeg.KeyPress += txtDRLDeg_KeyPress;
                    _txtDRLDeg.Validating += txtDRLDeg_Validating;
                    _txtDRLDeg.Enter += txtDRLDeg_Enter;
                }
            }
        }

        private RadioButton _optAzS;

        public RadioButton optAzS
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optAzS;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optAzS != null)
                {
                    _optAzS.CheckedChanged -= optAzS_CheckedChanged;
                }

                _optAzS = value;
                if (_optAzS != null)
                {
                    _optAzS.CheckedChanged += optAzS_CheckedChanged;
                }
            }
        }

        private RadioButton _optAzN;

        public RadioButton optAzN
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optAzN;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optAzN != null)
                {
                    _optAzN.CheckedChanged -= optAzN_CheckedChanged;
                }

                _optAzN = value;
                if (_optAzN != null)
                {
                    _optAzN.CheckedChanged += optAzN_CheckedChanged;
                }
            }
        }

        public Label lblLDeg;
        public Label lblLMin;
        public GroupBox Frame2;
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

        private RadioButton _optUpper;

        public RadioButton optUpper
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

        public RadioButton optLower
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

        public GroupBox Frame1;
        private Button _cmdNoonSight;

        public Button cmdNoonSight
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdNoonSight;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdNoonSight != null)
                {
                    _cmdNoonSight.Click -= cmdNoonSight_Click;
                }

                _cmdNoonSight = value;
                if (_cmdNoonSight != null)
                {
                    _cmdNoonSight.Click += cmdNoonSight_Click;
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

        public ComboBox cboHE;
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
                    _txtTemperature.KeyPress -= txtTemperature_KeyPress;
                    _txtTemperature.Validating -= txtTemperature_Validating;
                    _txtTemperature.Enter -= txtTemperature_Enter;
                }

                _txtTemperature = value;
                if (_txtTemperature != null)
                {
                    _txtTemperature.TextChanged += txtTemperature_TextChanged;
                    _txtTemperature.KeyPress += txtTemperature_KeyPress;
                    _txtTemperature.Validating += txtTemperature_Validating;
                    _txtTemperature.Enter += txtTemperature_Enter;
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
                    _txtPressure.Validating -= txtPressure_Validating;
                    _txtPressure.Enter -= txtPressure_Enter;
                }

                _txtPressure = value;
                if (_txtPressure != null)
                {
                    _txtPressure.TextChanged += txtPressure_TextChanged;
                    _txtPressure.KeyPress += txtPressure_KeyPress;
                    _txtPressure.Validating += txtPressure_Validating;
                    _txtPressure.Enter += txtPressure_Enter;
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

        public Panel FrameHorizon;
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

        public ComboBox cboDsUnit;
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

        private Button _cmdLAN;

        public Button cmdLAN
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdLAN;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdLAN != null)
                {
                    _cmdLAN.Click -= cmdLAN_Click;
                }

                _cmdLAN = value;
                if (_cmdLAN != null)
                {
                    _cmdLAN.Click += cmdLAN_Click;
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
                    _txtZDh.Enter -= txtZDh_Enter;
                    _txtZDh.Validating -= txtZDh_Validating;
                }

                _txtZDh = value;
                if (_txtZDh != null)
                {
                    _txtZDh.TextChanged += txtZDh_TextChanged;
                    _txtZDh.KeyPress += txtZDh_KeyPress;
                    _txtZDh.Enter += txtZDh_Enter;
                    _txtZDh.Validating += txtZDh_Validating;
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
        private ComboBox _cboZDm;

        public ComboBox cboZDm
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboZDm;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboZDm != null)
                {
                    _cboZDm.SelectedIndexChanged -= cboZDm_SelectedIndexChanged;
                }

                _cboZDm = value;
                if (_cboZDm != null)
                {
                    _cboZDm.SelectedIndexChanged += cboZDm_SelectedIndexChanged;
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
                    _txtLoDeg.Enter -= txtLoDeg_Enter;
                    _txtLoDeg.Validating -= txtLoDeg_Validating;
                }

                _txtLoDeg = value;
                if (_txtLoDeg != null)
                {
                    _txtLoDeg.TextChanged += txtLoDeg_TextChanged;
                    _txtLoDeg.Enter += txtLoDeg_Enter;
                    _txtLoDeg.Validating += txtLoDeg_Validating;
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
                    _txtLoMin.Enter -= txtLoMin_Enter;
                    _txtLoMin.Validating -= txtLoMin_Validating;
                }

                _txtLoMin = value;
                if (_txtLoMin != null)
                {
                    _txtLoMin.TextChanged += txtLoMin_TextChanged;
                    _txtLoMin.KeyPress += txtLoMin_KeyPress;
                    _txtLoMin.Enter += txtLoMin_Enter;
                    _txtLoMin.Validating += txtLoMin_Validating;
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
        // Public WithEvents Line5 As Microsoft.VisualBasic.PowerPacks.LineShape
        public Label lblHoCorrs;
        // Public WithEvents Line8 As Microsoft.VisualBasic.PowerPacks.LineShape
        public Label Label3;
        public Label lblZDDST;
        public Label lblS;
        public Label lblZ;
        public Label lblN;
        // Public WithEvents Line4 As Microsoft.VisualBasic.PowerPacks.LineShape
        // Public WithEvents Line3 As Microsoft.VisualBasic.PowerPacks.LineShape
        // Public WithEvents Line2 As Microsoft.VisualBasic.PowerPacks.LineShape
        // Public WithEvents Line1 As Microsoft.VisualBasic.PowerPacks.LineShape
        public Label lblHsFormat;
        public Label lblHs;
        public Label lblHsDeg;
        public Label lblHsMin;
        public Label lblHsSec;
        public Label lblHE;
        public Label lblIE;
        public Label lblIEMin;
        public Label lblStdT_P;
        public Label lblTemperature;
        public Label lblTempDeg;
        public Label lblPressure;
        public Label lblHorizon;
        public Label lblDsDist;
        public Label lblIEdeg;
        public Label Label1;
        public Label lblZDAutoManual;
        public Label lblZD;
        public Label lblZDh;
        public Label lblZDm;
        public Label lblDRLo;
        public Label lblLoDeg;
        public Label lblLoMin;
        public Label lblDate;
        // Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNoonSight));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this._optHoSRForm = new System.Windows.Forms.RadioButton();
            this.txtTime = new System.Windows.Forms.TextBox();
            this._chkDST = new System.Windows.Forms.CheckBox();
            this._txtDRLMin = new System.Windows.Forms.TextBox();
            this._txtDRLDeg = new System.Windows.Forms.TextBox();
            this._txtHsDeg = new System.Windows.Forms.TextBox();
            this._txtHsMin = new System.Windows.Forms.TextBox();
            this._txtHsSec = new System.Windows.Forms.TextBox();
            this._txtHE = new System.Windows.Forms.TextBox();
            this._txtIEmin = new System.Windows.Forms.TextBox();
            this._txtTemperature = new System.Windows.Forms.TextBox();
            this._txtPressure = new System.Windows.Forms.TextBox();
            this._txtDsDist = new System.Windows.Forms.TextBox();
            this._txtIEdeg = new System.Windows.Forms.TextBox();
            this._txtZDh = new System.Windows.Forms.TextBox();
            this._optZDAuto = new System.Windows.Forms.RadioButton();
            this._optZDManual = new System.Windows.Forms.RadioButton();
            this._txtLoDeg = new System.Windows.Forms.TextBox();
            this._txtLoMin = new System.Windows.Forms.TextBox();
            this.lblHsFormat = new System.Windows.Forms.Label();
            this.lblHs = new System.Windows.Forms.Label();
            this.lblHE = new System.Windows.Forms.Label();
            this.lblIE = new System.Windows.Forms.Label();
            this.lblDsDist = new System.Windows.Forms.Label();
            this.lblZDAutoManual = new System.Windows.Forms.Label();
            this.lblZD = new System.Windows.Forms.Label();
            this._optHoParameters = new System.Windows.Forms.RadioButton();
            this.DTNoonSight = new System.Windows.Forms.DateTimePicker();
            this.txtCalcHo = new System.Windows.Forms.TextBox();
            this._txtIESec = new System.Windows.Forms.TextBox();
            this._cmdPrint = new System.Windows.Forms.Button();
            this._optStdTPNo = new System.Windows.Forms.RadioButton();
            this._OptStdTPYes = new System.Windows.Forms.RadioButton();
            this.Frame2 = new System.Windows.Forms.GroupBox();
            this._optDRL = new System.Windows.Forms.RadioButton();
            this._optAzS = new System.Windows.Forms.RadioButton();
            this._optAzN = new System.Windows.Forms.RadioButton();
            this._cboDRL = new System.Windows.Forms.ComboBox();
            this.lblLDeg = new System.Windows.Forms.Label();
            this.lblLMin = new System.Windows.Forms.Label();
            this.Frame1 = new System.Windows.Forms.GroupBox();
            this._optCenter = new System.Windows.Forms.RadioButton();
            this._optUpper = new System.Windows.Forms.RadioButton();
            this._optLower = new System.Windows.Forms.RadioButton();
            this._cmdNoonSight = new System.Windows.Forms.Button();
            this.cboHE = new System.Windows.Forms.ComboBox();
            this.cboIE = new System.Windows.Forms.ComboBox();
            this._cboTemperature = new System.Windows.Forms.ComboBox();
            this._cboPressure = new System.Windows.Forms.ComboBox();
            this.Framehs = new System.Windows.Forms.Panel();
            this._optHsDMm = new System.Windows.Forms.RadioButton();
            this._optHsDMS = new System.Windows.Forms.RadioButton();
            this.FrameHorizon = new System.Windows.Forms.Panel();
            this._optHorizonBubble = new System.Windows.Forms.RadioButton();
            this._optHorizonNatural = new System.Windows.Forms.RadioButton();
            this._optHorizonArtificial = new System.Windows.Forms.RadioButton();
            this._optHorizonDipShort = new System.Windows.Forms.RadioButton();
            this.cboDsUnit = new System.Windows.Forms.ComboBox();
            this._cmdLAN = new System.Windows.Forms.Button();
            this.FrameZD = new System.Windows.Forms.Panel();
            this._optZDUT = new System.Windows.Forms.RadioButton();
            this._cboZDm = new System.Windows.Forms.ComboBox();
            this._cboLo = new System.Windows.Forms.ComboBox();
            this.lblHoCorrs = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.lblZDDST = new System.Windows.Forms.Label();
            this.lblS = new System.Windows.Forms.Label();
            this.lblZ = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.lblHsDeg = new System.Windows.Forms.Label();
            this.lblHsMin = new System.Windows.Forms.Label();
            this.lblHsSec = new System.Windows.Forms.Label();
            this.lblIEMin = new System.Windows.Forms.Label();
            this.lblStdT_P = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblTempDeg = new System.Windows.Forms.Label();
            this.lblPressure = new System.Windows.Forms.Label();
            this.lblHorizon = new System.Windows.Forms.Label();
            this.lblIEdeg = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.lblZDh = new System.Windows.Forms.Label();
            this.lblZDm = new System.Windows.Forms.Label();
            this.lblDRLo = new System.Windows.Forms.Label();
            this.lblLoDeg = new System.Windows.Forms.Label();
            this.lblLoMin = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.AltitudeTxtBx = new System.Windows.Forms.TextBox();
            this.LatitudeTxtBx = new System.Windows.Forms.TextBox();
            this.LANTimeTxtBx = new System.Windows.Forms.TextBox();
            this.LongitudeCalcTxtBx = new System.Windows.Forms.TextBox();
            this._ExitNoonSight = new System.Windows.Forms.Button();
            this._ClearScrBtn = new System.Windows.Forms.Button();
            this._OldFormBtn = new System.Windows.Forms.RadioButton();
            this._NewFormBtn = new System.Windows.Forms.RadioButton();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.lblIEsec = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this._MeridianPicBx = new System.Windows.Forms.PictureBox();
            this._btnDisplayEQTData = new System.Windows.Forms.Button();
            this.DGLAN = new System.Windows.Forms.DataGridView();
            this.DGAlt = new System.Windows.Forms.DataGridView();
            this.AlmanacTxtBx = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.DGAlm = new System.Windows.Forms.DataGridView();
            this.DGLat = new System.Windows.Forms.DataGridView();
            this.txtUserInfo = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtZTLANWarn = new System.Windows.Forms.TextBox();
            this.Frame2.SuspendLayout();
            this.Frame1.SuspendLayout();
            this.Framehs.SuspendLayout();
            this.FrameHorizon.SuspendLayout();
            this.FrameZD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._MeridianPicBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGLAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGAlt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGAlm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGLat)).BeginInit();
            this.SuspendLayout();
            // 
            // _optHoSRForm
            // 
            this._optHoSRForm.BackColor = System.Drawing.SystemColors.Window;
            this._optHoSRForm.Checked = true;
            this._optHoSRForm.Cursor = System.Windows.Forms.Cursors.Default;
            this._optHoSRForm.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optHoSRForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this._optHoSRForm.Location = new System.Drawing.Point(553, 181);
            this._optHoSRForm.Name = "_optHoSRForm";
            this._optHoSRForm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optHoSRForm.Size = new System.Drawing.Size(66, 15);
            this._optHoSRForm.TabIndex = 88;
            this._optHoSRForm.TabStop = true;
            this._optHoSRForm.Text = "SR Form";
            this.ToolTip1.SetToolTip(this._optHoSRForm, "Main, Add\'l, etc.");
            this._optHoSRForm.UseVisualStyleBackColor = false;
            this._optHoSRForm.CheckedChanged += new System.EventHandler(this.optHoSRForm_CheckedChanged);
            // 
            // txtTime
            // 
            this.txtTime.AcceptsReturn = true;
            this.txtTime.BackColor = System.Drawing.SystemColors.Window;
            this.txtTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTime.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTime.Location = new System.Drawing.Point(164, 579);
            this.txtTime.MaxLength = 6;
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTime.Size = new System.Drawing.Size(77, 20);
            this.txtTime.TabIndex = 81;
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToolTip1.SetToolTip(this.txtTime, "Range 111328 to 124427 (121328 to 134427 if DST) for Auto ZD");
            // 
            // _chkDST
            // 
            this._chkDST.BackColor = System.Drawing.SystemColors.Window;
            this._chkDST.Cursor = System.Windows.Forms.Cursors.Default;
            this._chkDST.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._chkDST.ForeColor = System.Drawing.SystemColors.ControlText;
            this._chkDST.Location = new System.Drawing.Point(156, 172);
            this._chkDST.Name = "_chkDST";
            this._chkDST.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._chkDST.Size = new System.Drawing.Size(17, 14);
            this._chkDST.TabIndex = 79;
            this._chkDST.Text = "Check1";
            this.ToolTip1.SetToolTip(this._chkDST, "Check if Dayslight Saving is in effect");
            this._chkDST.UseVisualStyleBackColor = false;
            this._chkDST.CheckedChanged += new System.EventHandler(this.chkDST_CheckedChanged);
            this._chkDST.CheckStateChanged += new System.EventHandler(this.chkDST_CheckStateChanged);
            // 
            // _txtDRLMin
            // 
            this._txtDRLMin.AcceptsReturn = true;
            this._txtDRLMin.BackColor = System.Drawing.SystemColors.Window;
            this._txtDRLMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtDRLMin.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtDRLMin.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtDRLMin.Location = new System.Drawing.Point(136, 60);
            this._txtDRLMin.MaxLength = 4;
            this._txtDRLMin.Name = "_txtDRLMin";
            this._txtDRLMin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtDRLMin.Size = new System.Drawing.Size(33, 20);
            this._txtDRLMin.TabIndex = 4;
            this.ToolTip1.SetToolTip(this._txtDRLMin, "Range 0 to 59.9");
            this._txtDRLMin.TextChanged += new System.EventHandler(this.txtDRLMin_TextChanged);
            this._txtDRLMin.Enter += new System.EventHandler(this.txtDRLMin_Enter);
            this._txtDRLMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDRLMin_KeyPress);
            this._txtDRLMin.Validating += new System.ComponentModel.CancelEventHandler(this.txtDRLMin_Validating);
            // 
            // _txtDRLDeg
            // 
            this._txtDRLDeg.AcceptsReturn = true;
            this._txtDRLDeg.BackColor = System.Drawing.SystemColors.Window;
            this._txtDRLDeg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtDRLDeg.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtDRLDeg.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtDRLDeg.Location = new System.Drawing.Point(89, 60);
            this._txtDRLDeg.MaxLength = 2;
            this._txtDRLDeg.Name = "_txtDRLDeg";
            this._txtDRLDeg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtDRLDeg.Size = new System.Drawing.Size(33, 20);
            this._txtDRLDeg.TabIndex = 2;
            this.ToolTip1.SetToolTip(this._txtDRLDeg, "Range 0 to 90");
            this._txtDRLDeg.TextChanged += new System.EventHandler(this.txtDRLDeg_TextChanged);
            this._txtDRLDeg.Enter += new System.EventHandler(this.txtDRLDeg_Enter);
            this._txtDRLDeg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDRLDeg_KeyPress);
            this._txtDRLDeg.Validating += new System.ComponentModel.CancelEventHandler(this.txtDRLDeg_Validating);
            // 
            // _txtHsDeg
            // 
            this._txtHsDeg.AcceptsReturn = true;
            this._txtHsDeg.BackColor = System.Drawing.SystemColors.Window;
            this._txtHsDeg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtHsDeg.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtHsDeg.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtHsDeg.Location = new System.Drawing.Point(262, 122);
            this._txtHsDeg.MaxLength = 3;
            this._txtHsDeg.Name = "_txtHsDeg";
            this._txtHsDeg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtHsDeg.Size = new System.Drawing.Size(28, 20);
            this._txtHsDeg.TabIndex = 32;
            this.ToolTip1.SetToolTip(this._txtHsDeg, "Range 0 to 145");
            this._txtHsDeg.TextChanged += new System.EventHandler(this.txtHsDeg_TextChanged);
            this._txtHsDeg.Enter += new System.EventHandler(this.txtHsDeg_Enter);
            this._txtHsDeg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHsDeg_KeyPress);
            this._txtHsDeg.Validating += new System.ComponentModel.CancelEventHandler(this.txtHsDeg_Validating);
            // 
            // _txtHsMin
            // 
            this._txtHsMin.AcceptsReturn = true;
            this._txtHsMin.BackColor = System.Drawing.SystemColors.Window;
            this._txtHsMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtHsMin.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtHsMin.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtHsMin.Location = new System.Drawing.Point(297, 122);
            this._txtHsMin.MaxLength = 4;
            this._txtHsMin.Name = "_txtHsMin";
            this._txtHsMin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtHsMin.Size = new System.Drawing.Size(33, 20);
            this._txtHsMin.TabIndex = 33;
            this.ToolTip1.SetToolTip(this._txtHsMin, "Range 0 to 59.9 (DM.m) or 59 (DMS)");
            this._txtHsMin.TextChanged += new System.EventHandler(this.txtHsMin_TextChanged);
            this._txtHsMin.Enter += new System.EventHandler(this.txtHsMin_Enter);
            this._txtHsMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHsMin_KeyPress);
            this._txtHsMin.Validating += new System.ComponentModel.CancelEventHandler(this.txtHsMin_Validating);
            // 
            // _txtHsSec
            // 
            this._txtHsSec.AcceptsReturn = true;
            this._txtHsSec.BackColor = System.Drawing.SystemColors.Window;
            this._txtHsSec.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtHsSec.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtHsSec.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtHsSec.Location = new System.Drawing.Point(337, 122);
            this._txtHsSec.MaxLength = 2;
            this._txtHsSec.Name = "_txtHsSec";
            this._txtHsSec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtHsSec.Size = new System.Drawing.Size(33, 20);
            this._txtHsSec.TabIndex = 34;
            this.ToolTip1.SetToolTip(this._txtHsSec, "Range 0 to 59");
            this._txtHsSec.Visible = false;
            this._txtHsSec.TextChanged += new System.EventHandler(this.txtHsSec_TextChanged);
            this._txtHsSec.Enter += new System.EventHandler(this.txtHsSec_Enter);
            this._txtHsSec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHsSec_KeyPress);
            this._txtHsSec.Validating += new System.ComponentModel.CancelEventHandler(this.txtHsSec_Validating);
            // 
            // _txtHE
            // 
            this._txtHE.AcceptsReturn = true;
            this._txtHE.BackColor = System.Drawing.SystemColors.Window;
            this._txtHE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtHE.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtHE.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtHE.Location = new System.Drawing.Point(332, 219);
            this._txtHE.MaxLength = 4;
            this._txtHE.Name = "_txtHE";
            this._txtHE.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtHE.Size = new System.Drawing.Size(33, 20);
            this._txtHE.TabIndex = 42;
            this.ToolTip1.SetToolTip(this._txtHE, "Max. 4 characters");
            this._txtHE.Enter += new System.EventHandler(this.txtHE_Enter);
            this._txtHE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHE_KeyPress);
            // 
            // _txtIEmin
            // 
            this._txtIEmin.AcceptsReturn = true;
            this._txtIEmin.BackColor = System.Drawing.SystemColors.Window;
            this._txtIEmin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtIEmin.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtIEmin.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtIEmin.Location = new System.Drawing.Point(297, 145);
            this._txtIEmin.MaxLength = 4;
            this._txtIEmin.Name = "_txtIEmin";
            this._txtIEmin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtIEmin.Size = new System.Drawing.Size(33, 20);
            this._txtIEmin.TabIndex = 36;
            this.ToolTip1.SetToolTip(this._txtIEmin, "Range 0 to 59.9 (DM.m) or 59 (DMS)");
            this._txtIEmin.TextChanged += new System.EventHandler(this.txtIEmin_TextChanged);
            this._txtIEmin.Enter += new System.EventHandler(this.txtIEmin_Enter);
            this._txtIEmin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIEmin_KeyPress);
            this._txtIEmin.Validating += new System.ComponentModel.CancelEventHandler(this.txtIEmin_Validating);
            // 
            // _txtTemperature
            // 
            this._txtTemperature.AcceptsReturn = true;
            this._txtTemperature.BackColor = System.Drawing.SystemColors.Window;
            this._txtTemperature.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtTemperature.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtTemperature.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtTemperature.Location = new System.Drawing.Point(595, 105);
            this._txtTemperature.MaxLength = 4;
            this._txtTemperature.Name = "_txtTemperature";
            this._txtTemperature.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtTemperature.Size = new System.Drawing.Size(33, 20);
            this._txtTemperature.TabIndex = 46;
            this._txtTemperature.Text = "50";
            this.ToolTip1.SetToolTip(this._txtTemperature, "Range -40 to 130 (F) or -40 to 55 (C)");
            this._txtTemperature.Visible = false;
            this._txtTemperature.TextChanged += new System.EventHandler(this.txtTemperature_TextChanged);
            this._txtTemperature.Enter += new System.EventHandler(this.txtTemperature_Enter);
            this._txtTemperature.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTemperature_KeyPress);
            this._txtTemperature.Validating += new System.ComponentModel.CancelEventHandler(this.txtTemperature_Validating);
            // 
            // _txtPressure
            // 
            this._txtPressure.AcceptsReturn = true;
            this._txtPressure.BackColor = System.Drawing.SystemColors.Window;
            this._txtPressure.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtPressure.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtPressure.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtPressure.Location = new System.Drawing.Point(594, 132);
            this._txtPressure.MaxLength = 5;
            this._txtPressure.Name = "_txtPressure";
            this._txtPressure.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtPressure.Size = new System.Drawing.Size(41, 20);
            this._txtPressure.TabIndex = 48;
            this._txtPressure.Text = "29.83";
            this.ToolTip1.SetToolTip(this._txtPressure, "Range 28 to 32 (in Hg) or 950 to 1100 (mb)");
            this._txtPressure.Visible = false;
            this._txtPressure.TextChanged += new System.EventHandler(this.txtPressure_TextChanged);
            this._txtPressure.Enter += new System.EventHandler(this.txtPressure_Enter);
            this._txtPressure.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPressure_KeyPress);
            this._txtPressure.Validating += new System.ComponentModel.CancelEventHandler(this.txtPressure_Validating);
            // 
            // _txtDsDist
            // 
            this._txtDsDist.AcceptsReturn = true;
            this._txtDsDist.BackColor = System.Drawing.SystemColors.Window;
            this._txtDsDist.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtDsDist.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtDsDist.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtDsDist.Location = new System.Drawing.Point(332, 243);
            this._txtDsDist.MaxLength = 5;
            this._txtDsDist.Name = "_txtDsDist";
            this._txtDsDist.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtDsDist.Size = new System.Drawing.Size(41, 20);
            this._txtDsDist.TabIndex = 44;
            this.ToolTip1.SetToolTip(this._txtDsDist, "Limited to five characters");
            this._txtDsDist.Visible = false;
            this._txtDsDist.Enter += new System.EventHandler(this.txtDsDist_Enter);
            this._txtDsDist.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDsDist_KeyPress);
            // 
            // _txtIEdeg
            // 
            this._txtIEdeg.AcceptsReturn = true;
            this._txtIEdeg.BackColor = System.Drawing.SystemColors.Window;
            this._txtIEdeg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtIEdeg.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtIEdeg.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtIEdeg.Location = new System.Drawing.Point(262, 145);
            this._txtIEdeg.MaxLength = 1;
            this._txtIEdeg.Name = "_txtIEdeg";
            this._txtIEdeg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtIEdeg.Size = new System.Drawing.Size(28, 20);
            this._txtIEdeg.TabIndex = 35;
            this.ToolTip1.SetToolTip(this._txtIEdeg, "Range 0 to 9; to right of index mark");
            this._txtIEdeg.TextChanged += new System.EventHandler(this.txtIEdeg_TextChanged);
            this._txtIEdeg.Enter += new System.EventHandler(this.txtIEDeg_Enter);
            this._txtIEdeg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIEdeg_KeyPress);
            this._txtIEdeg.Validating += new System.ComponentModel.CancelEventHandler(this.txtIEdeg_Validating);
            // 
            // _txtZDh
            // 
            this._txtZDh.AcceptsReturn = true;
            this._txtZDh.BackColor = System.Drawing.SystemColors.Window;
            this._txtZDh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtZDh.Enabled = false;
            this._txtZDh.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtZDh.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtZDh.Location = new System.Drawing.Point(37, 168);
            this._txtZDh.MaxLength = 3;
            this._txtZDh.Name = "_txtZDh";
            this._txtZDh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtZDh.Size = new System.Drawing.Size(25, 20);
            this._txtZDh.TabIndex = 17;
            this.ToolTip1.SetToolTip(this._txtZDh, "Range -14 to +12.  Lo E is -.");
            this._txtZDh.TextChanged += new System.EventHandler(this.txtZDh_TextChanged);
            this._txtZDh.Enter += new System.EventHandler(this.txtZDh_Enter);
            this._txtZDh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZDh_KeyPress);
            this._txtZDh.Validating += new System.ComponentModel.CancelEventHandler(this.txtZDh_Validating);
            // 
            // _optZDAuto
            // 
            this._optZDAuto.BackColor = System.Drawing.SystemColors.Window;
            this._optZDAuto.Checked = true;
            this._optZDAuto.Cursor = System.Windows.Forms.Cursors.Default;
            this._optZDAuto.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optZDAuto.ForeColor = System.Drawing.SystemColors.ControlText;
            this._optZDAuto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this._optZDAuto.Location = new System.Drawing.Point(3, 1);
            this._optZDAuto.Name = "_optZDAuto";
            this._optZDAuto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optZDAuto.Size = new System.Drawing.Size(49, 19);
            this._optZDAuto.TabIndex = 15;
            this._optZDAuto.TabStop = true;
            this._optZDAuto.Text = "Auto";
            this.ToolTip1.SetToolTip(this._optZDAuto, "ZD based on longitude alone");
            this._optZDAuto.UseVisualStyleBackColor = false;
            this._optZDAuto.CheckedChanged += new System.EventHandler(this.optZDAuto_CheckedChanged);
            // 
            // _optZDManual
            // 
            this._optZDManual.BackColor = System.Drawing.SystemColors.Window;
            this._optZDManual.Cursor = System.Windows.Forms.Cursors.Default;
            this._optZDManual.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optZDManual.ForeColor = System.Drawing.SystemColors.ControlText;
            this._optZDManual.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this._optZDManual.Location = new System.Drawing.Point(56, 1);
            this._optZDManual.Name = "_optZDManual";
            this._optZDManual.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optZDManual.Size = new System.Drawing.Size(65, 19);
            this._optZDManual.TabIndex = 16;
            this._optZDManual.TabStop = true;
            this._optZDManual.Text = "Manual";
            this.ToolTip1.SetToolTip(this._optZDManual, "ZD can be set for civil standard time zone");
            this._optZDManual.UseVisualStyleBackColor = false;
            this._optZDManual.CheckedChanged += new System.EventHandler(this.optZDManual_CheckedChanged);
            // 
            // _txtLoDeg
            // 
            this._txtLoDeg.AcceptsReturn = true;
            this._txtLoDeg.BackColor = System.Drawing.SystemColors.Window;
            this._txtLoDeg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtLoDeg.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtLoDeg.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtLoDeg.Location = new System.Drawing.Point(90, 93);
            this._txtLoDeg.MaxLength = 3;
            this._txtLoDeg.Name = "_txtLoDeg";
            this._txtLoDeg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtLoDeg.Size = new System.Drawing.Size(33, 20);
            this._txtLoDeg.TabIndex = 8;
            this.ToolTip1.SetToolTip(this._txtLoDeg, "Range 0 to 180");
            this._txtLoDeg.TextChanged += new System.EventHandler(this.txtLoDeg_TextChanged);
            this._txtLoDeg.Enter += new System.EventHandler(this.txtLoDeg_Enter);
            this._txtLoDeg.Validating += new System.ComponentModel.CancelEventHandler(this.txtLoDeg_Validating);
            // 
            // _txtLoMin
            // 
            this._txtLoMin.AcceptsReturn = true;
            this._txtLoMin.BackColor = System.Drawing.SystemColors.Window;
            this._txtLoMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtLoMin.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtLoMin.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtLoMin.Location = new System.Drawing.Point(135, 93);
            this._txtLoMin.MaxLength = 4;
            this._txtLoMin.Name = "_txtLoMin";
            this._txtLoMin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtLoMin.Size = new System.Drawing.Size(33, 20);
            this._txtLoMin.TabIndex = 10;
            this.ToolTip1.SetToolTip(this._txtLoMin, "Range 0 to 59.9");
            this._txtLoMin.TextChanged += new System.EventHandler(this.txtLoMin_TextChanged);
            this._txtLoMin.Enter += new System.EventHandler(this.txtLoMin_Enter);
            this._txtLoMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLoMin_KeyPress);
            this._txtLoMin.Validating += new System.ComponentModel.CancelEventHandler(this.txtLoMin_Validating);
            // 
            // lblHsFormat
            // 
            this.lblHsFormat.BackColor = System.Drawing.SystemColors.Window;
            this.lblHsFormat.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblHsFormat.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHsFormat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHsFormat.Location = new System.Drawing.Point(485, 51);
            this.lblHsFormat.Name = "lblHsFormat";
            this.lblHsFormat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHsFormat.Size = new System.Drawing.Size(73, 13);
            this.lblHsFormat.TabIndex = 71;
            this.lblHsFormat.Text = "hs/IE format";
            this.ToolTip1.SetToolTip(this.lblHsFormat, "Sextant Altitude/Index Error format");
            // 
            // lblHs
            // 
            this.lblHs.BackColor = System.Drawing.SystemColors.Window;
            this.lblHs.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblHs.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHs.Location = new System.Drawing.Point(233, 125);
            this.lblHs.Name = "lblHs";
            this.lblHs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHs.Size = new System.Drawing.Size(19, 13);
            this.lblHs.TabIndex = 70;
            this.lblHs.Text = "hs";
            this.ToolTip1.SetToolTip(this.lblHs, "Sextant Altitude");
            // 
            // lblHE
            // 
            this.lblHE.BackColor = System.Drawing.SystemColors.Window;
            this.lblHE.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblHE.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHE.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHE.Location = new System.Drawing.Point(233, 223);
            this.lblHE.Name = "lblHE";
            this.lblHE.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblHE.Size = new System.Drawing.Size(82, 16);
            this.lblHE.TabIndex = 66;
            this.lblHE.Text = "Height of Eye";
            this.lblHE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ToolTip1.SetToolTip(this.lblHE, "Height of Eye");
            // 
            // lblIE
            // 
            this.lblIE.BackColor = System.Drawing.SystemColors.Window;
            this.lblIE.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblIE.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIE.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblIE.Location = new System.Drawing.Point(233, 148);
            this.lblIE.Name = "lblIE";
            this.lblIE.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblIE.Size = new System.Drawing.Size(17, 17);
            this.lblIE.TabIndex = 65;
            this.lblIE.Text = "IE";
            this.ToolTip1.SetToolTip(this.lblIE, "Index Error");
            // 
            // lblDsDist
            // 
            this.lblDsDist.BackColor = System.Drawing.SystemColors.Window;
            this.lblDsDist.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDsDist.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDsDist.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDsDist.Location = new System.Drawing.Point(233, 244);
            this.lblDsDist.Name = "lblDsDist";
            this.lblDsDist.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDsDist.Size = new System.Drawing.Size(97, 18);
            this.lblDsDist.TabIndex = 58;
            this.lblDsDist.Text = "Dip Short distance";
            this.lblDsDist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ToolTip1.SetToolTip(this.lblDsDist, "Distance to dip short horizon");
            this.lblDsDist.Visible = false;
            // 
            // lblZDAutoManual
            // 
            this.lblZDAutoManual.BackColor = System.Drawing.SystemColors.Window;
            this.lblZDAutoManual.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblZDAutoManual.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZDAutoManual.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblZDAutoManual.Location = new System.Drawing.Point(13, 143);
            this.lblZDAutoManual.Name = "lblZDAutoManual";
            this.lblZDAutoManual.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblZDAutoManual.Size = new System.Drawing.Size(22, 13);
            this.lblZDAutoManual.TabIndex = 14;
            this.lblZDAutoManual.Text = "ZD";
            this.ToolTip1.SetToolTip(this.lblZDAutoManual, "Zone Description ");
            // 
            // lblZD
            // 
            this.lblZD.BackColor = System.Drawing.SystemColors.Window;
            this.lblZD.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblZD.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblZD.Location = new System.Drawing.Point(13, 172);
            this.lblZD.Name = "lblZD";
            this.lblZD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblZD.Size = new System.Drawing.Size(22, 13);
            this.lblZD.TabIndex = 54;
            this.lblZD.Text = "ZD";
            this.ToolTip1.SetToolTip(this.lblZD, "Zone Description");
            // 
            // _optHoParameters
            // 
            this._optHoParameters.BackColor = System.Drawing.SystemColors.Window;
            this._optHoParameters.Cursor = System.Windows.Forms.Cursors.Default;
            this._optHoParameters.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optHoParameters.ForeColor = System.Drawing.SystemColors.ControlText;
            this._optHoParameters.Location = new System.Drawing.Point(628, 181);
            this._optHoParameters.Name = "_optHoParameters";
            this._optHoParameters.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optHoParameters.Size = new System.Drawing.Size(80, 15);
            this._optHoParameters.TabIndex = 87;
            this._optHoParameters.Text = "Parameters";
            this.ToolTip1.SetToolTip(this._optHoParameters, "Refraction, parallax, etc.");
            this._optHoParameters.UseVisualStyleBackColor = false;
            this._optHoParameters.CheckedChanged += new System.EventHandler(this.optHoParameters_CheckedChanged);
            // 
            // DTNoonSight
            // 
            this.DTNoonSight.CustomFormat = "MM/dd/yyyy HH:mm:ss ";
            this.DTNoonSight.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DTNoonSight.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTNoonSight.Location = new System.Drawing.Point(77, 26);
            this.DTNoonSight.Name = "DTNoonSight";
            this.DTNoonSight.ShowUpDown = true;
            this.DTNoonSight.Size = new System.Drawing.Size(148, 21);
            this.DTNoonSight.TabIndex = 1;
            this.ToolTip1.SetToolTip(this.DTNoonSight, resources.GetString("DTNoonSight.ToolTip"));
            this.DTNoonSight.ValueChanged += new System.EventHandler(this.DTNoonSight_ValueChanged);
            // 
            // txtCalcHo
            // 
            this.txtCalcHo.AcceptsReturn = true;
            this.txtCalcHo.BackColor = System.Drawing.SystemColors.Window;
            this.txtCalcHo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCalcHo.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalcHo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCalcHo.Location = new System.Drawing.Point(164, 610);
            this.txtCalcHo.MaxLength = 6;
            this.txtCalcHo.Name = "txtCalcHo";
            this.txtCalcHo.ReadOnly = true;
            this.txtCalcHo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCalcHo.Size = new System.Drawing.Size(77, 20);
            this.txtCalcHo.TabIndex = 117;
            this.txtCalcHo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToolTip1.SetToolTip(this.txtCalcHo, "Range 111328 to 124427 (121328 to 134427 if DST) for Auto ZD");
            // 
            // _txtIESec
            // 
            this._txtIESec.AcceptsReturn = true;
            this._txtIESec.BackColor = System.Drawing.SystemColors.Window;
            this._txtIESec.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtIESec.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtIESec.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtIESec.Location = new System.Drawing.Point(338, 145);
            this._txtIESec.MaxLength = 0;
            this._txtIESec.Name = "_txtIESec";
            this._txtIESec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtIESec.Size = new System.Drawing.Size(33, 20);
            this._txtIESec.TabIndex = 37;
            this.ToolTip1.SetToolTip(this._txtIESec, "Range 0 to 59");
            this._txtIESec.Visible = false;
            this._txtIESec.TextChanged += new System.EventHandler(this.txtIESec_TextChanged);
            this._txtIESec.Enter += new System.EventHandler(this.txtIESec_Enter);
            this._txtIESec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIESec_KeyPress);
            this._txtIESec.Validating += new System.ComponentModel.CancelEventHandler(this.txtIESec_Validating);
            // 
            // _cmdPrint
            // 
            this._cmdPrint.BackColor = System.Drawing.SystemColors.Control;
            this._cmdPrint.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdPrint.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdPrint.Image = ((System.Drawing.Image)(resources.GetObject("_cmdPrint.Image")));
            this._cmdPrint.Location = new System.Drawing.Point(694, 0);
            this._cmdPrint.Name = "_cmdPrint";
            this._cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdPrint.Size = new System.Drawing.Size(21, 21);
            this._cmdPrint.TabIndex = 74;
            this._cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ToolTip1.SetToolTip(this._cmdPrint, "Print window");
            this._cmdPrint.UseVisualStyleBackColor = false;
            this._cmdPrint.Click += new System.EventHandler(this.cmdPrint_Click);
            // 
            // _optStdTPNo
            // 
            this._optStdTPNo.BackColor = System.Drawing.SystemColors.Window;
            this._optStdTPNo.Cursor = System.Windows.Forms.Cursors.Default;
            this._optStdTPNo.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optStdTPNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this._optStdTPNo.Location = new System.Drawing.Point(658, 80);
            this._optStdTPNo.Name = "_optStdTPNo";
            this._optStdTPNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optStdTPNo.Size = new System.Drawing.Size(45, 15);
            this._optStdTPNo.TabIndex = 85;
            this._optStdTPNo.TabStop = true;
            this._optStdTPNo.Text = "No";
            this._optStdTPNo.UseVisualStyleBackColor = false;
            this._optStdTPNo.CheckedChanged += new System.EventHandler(this.optStdTPNo_CheckedChanged);
            // 
            // _OptStdTPYes
            // 
            this._OptStdTPYes.BackColor = System.Drawing.SystemColors.Window;
            this._OptStdTPYes.Checked = true;
            this._OptStdTPYes.Cursor = System.Windows.Forms.Cursors.Default;
            this._OptStdTPYes.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._OptStdTPYes.ForeColor = System.Drawing.SystemColors.ControlText;
            this._OptStdTPYes.Location = new System.Drawing.Point(603, 80);
            this._OptStdTPYes.Name = "_OptStdTPYes";
            this._OptStdTPYes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._OptStdTPYes.Size = new System.Drawing.Size(45, 15);
            this._OptStdTPYes.TabIndex = 84;
            this._OptStdTPYes.TabStop = true;
            this._OptStdTPYes.Text = "Yes";
            this._OptStdTPYes.UseVisualStyleBackColor = false;
            this._OptStdTPYes.CheckedChanged += new System.EventHandler(this.optStdTPYes_CheckedChanged);
            // 
            // Frame2
            // 
            this.Frame2.BackColor = System.Drawing.SystemColors.Window;
            this.Frame2.Controls.Add(this._optDRL);
            this.Frame2.Controls.Add(this._optAzS);
            this.Frame2.Controls.Add(this._optAzN);
            this.Frame2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame2.Location = new System.Drawing.Point(236, 52);
            this.Frame2.Name = "Frame2";
            this.Frame2.Padding = new System.Windows.Forms.Padding(0);
            this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame2.Size = new System.Drawing.Size(209, 68);
            this.Frame2.TabIndex = 73;
            this.Frame2.TabStop = false;
            this.Frame2.Text = "At LAN (select one)";
            // 
            // _optDRL
            // 
            this._optDRL.BackColor = System.Drawing.SystemColors.Window;
            this._optDRL.Checked = true;
            this._optDRL.Cursor = System.Windows.Forms.Cursors.Default;
            this._optDRL.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optDRL.ForeColor = System.Drawing.SystemColors.ControlText;
            this._optDRL.Location = new System.Drawing.Point(8, 46);
            this._optDRL.Name = "_optDRL";
            this._optDRL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optDRL.Size = new System.Drawing.Size(120, 20);
            this._optDRL.TabIndex = 22;
            this._optDRL.TabStop = true;
            this._optDRL.Text = "Use DR Latitude";
            this._optDRL.UseVisualStyleBackColor = false;
            this._optDRL.CheckedChanged += new System.EventHandler(this.optDRL_CheckedChanged);
            // 
            // _optAzS
            // 
            this._optAzS.BackColor = System.Drawing.SystemColors.Window;
            this._optAzS.Cursor = System.Windows.Forms.Cursors.Default;
            this._optAzS.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optAzS.ForeColor = System.Drawing.SystemColors.ControlText;
            this._optAzS.Location = new System.Drawing.Point(8, 30);
            this._optAzS.Name = "_optAzS";
            this._optAzS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optAzS.Size = new System.Drawing.Size(146, 15);
            this._optAzS.TabIndex = 21;
            this._optAzS.TabStop = true;
            this._optAzS.Text = "sun was to south";
            this._optAzS.UseVisualStyleBackColor = false;
            this._optAzS.CheckedChanged += new System.EventHandler(this.optAzS_CheckedChanged);
            // 
            // _optAzN
            // 
            this._optAzN.BackColor = System.Drawing.SystemColors.Window;
            this._optAzN.Cursor = System.Windows.Forms.Cursors.Default;
            this._optAzN.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optAzN.ForeColor = System.Drawing.SystemColors.ControlText;
            this._optAzN.Location = new System.Drawing.Point(8, 12);
            this._optAzN.Name = "_optAzN";
            this._optAzN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optAzN.Size = new System.Drawing.Size(145, 15);
            this._optAzN.TabIndex = 20;
            this._optAzN.TabStop = true;
            this._optAzN.Text = "sun was to north";
            this._optAzN.UseVisualStyleBackColor = false;
            this._optAzN.CheckedChanged += new System.EventHandler(this.optAzN_CheckedChanged);
            // 
            // _cboDRL
            // 
            this._cboDRL.BackColor = System.Drawing.SystemColors.Window;
            this._cboDRL.Cursor = System.Windows.Forms.Cursors.Default;
            this._cboDRL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cboDRL.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cboDRL.ForeColor = System.Drawing.SystemColors.WindowText;
            this._cboDRL.Items.AddRange(new object[] {
            "N",
            "S"});
            this._cboDRL.Location = new System.Drawing.Point(182, 60);
            this._cboDRL.Name = "_cboDRL";
            this._cboDRL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cboDRL.Size = new System.Drawing.Size(41, 22);
            this._cboDRL.TabIndex = 6;
            this._cboDRL.SelectedIndexChanged += new System.EventHandler(this.cboDRL_SelectedIndexChanged);
            // 
            // lblLDeg
            // 
            this.lblLDeg.BackColor = System.Drawing.SystemColors.Window;
            this.lblLDeg.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLDeg.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLDeg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLDeg.Location = new System.Drawing.Point(123, 60);
            this.lblLDeg.Name = "lblLDeg";
            this.lblLDeg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLDeg.Size = new System.Drawing.Size(9, 17);
            this.lblLDeg.TabIndex = 24;
            this.lblLDeg.Text = "°";
            // 
            // lblLMin
            // 
            this.lblLMin.BackColor = System.Drawing.SystemColors.Window;
            this.lblLMin.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLMin.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLMin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLMin.Location = new System.Drawing.Point(169, 59);
            this.lblLMin.Name = "lblLMin";
            this.lblLMin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLMin.Size = new System.Drawing.Size(9, 17);
            this.lblLMin.TabIndex = 26;
            this.lblLMin.Text = "\'";
            // 
            // Frame1
            // 
            this.Frame1.BackColor = System.Drawing.SystemColors.Window;
            this.Frame1.Controls.Add(this._optCenter);
            this.Frame1.Controls.Add(this._optUpper);
            this.Frame1.Controls.Add(this._optLower);
            this.Frame1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame1.Location = new System.Drawing.Point(236, 20);
            this.Frame1.Name = "Frame1";
            this.Frame1.Padding = new System.Windows.Forms.Padding(0);
            this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame1.Size = new System.Drawing.Size(240, 30);
            this.Frame1.TabIndex = 72;
            this.Frame1.TabStop = false;
            this.Frame1.Text = "Sun Limb";
            // 
            // _optCenter
            // 
            this._optCenter.BackColor = System.Drawing.SystemColors.Window;
            this._optCenter.Cursor = System.Windows.Forms.Cursors.Default;
            this._optCenter.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optCenter.ForeColor = System.Drawing.SystemColors.ControlText;
            this._optCenter.Location = new System.Drawing.Point(175, 8);
            this._optCenter.Name = "_optCenter";
            this._optCenter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optCenter.Size = new System.Drawing.Size(59, 19);
            this._optCenter.TabIndex = 90;
            this._optCenter.TabStop = true;
            this._optCenter.Text = "Center";
            this._optCenter.UseVisualStyleBackColor = false;
            this._optCenter.CheckedChanged += new System.EventHandler(this.optCenter_CheckedChanged);
            // 
            // _optUpper
            // 
            this._optUpper.BackColor = System.Drawing.SystemColors.Window;
            this._optUpper.Cursor = System.Windows.Forms.Cursors.Default;
            this._optUpper.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optUpper.ForeColor = System.Drawing.SystemColors.ControlText;
            this._optUpper.Location = new System.Drawing.Point(112, 8);
            this._optUpper.Name = "_optUpper";
            this._optUpper.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optUpper.Size = new System.Drawing.Size(57, 17);
            this._optUpper.TabIndex = 29;
            this._optUpper.TabStop = true;
            this._optUpper.Text = "Upper";
            this._optUpper.UseVisualStyleBackColor = false;
            this._optUpper.CheckedChanged += new System.EventHandler(this.optUpper_CheckedChanged);
            // 
            // _optLower
            // 
            this._optLower.BackColor = System.Drawing.SystemColors.Window;
            this._optLower.Checked = true;
            this._optLower.Cursor = System.Windows.Forms.Cursors.Default;
            this._optLower.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optLower.ForeColor = System.Drawing.SystemColors.ControlText;
            this._optLower.Location = new System.Drawing.Point(55, 8);
            this._optLower.Name = "_optLower";
            this._optLower.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optLower.Size = new System.Drawing.Size(58, 17);
            this._optLower.TabIndex = 28;
            this._optLower.TabStop = true;
            this._optLower.Text = "Lower";
            this._optLower.UseVisualStyleBackColor = false;
            this._optLower.CheckedChanged += new System.EventHandler(this.optLower_CheckedChanged);
            // 
            // _cmdNoonSight
            // 
            this._cmdNoonSight.BackColor = System.Drawing.SystemColors.Control;
            this._cmdNoonSight.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdNoonSight.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmdNoonSight.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdNoonSight.Location = new System.Drawing.Point(260, 270);
            this._cmdNoonSight.Name = "_cmdNoonSight";
            this._cmdNoonSight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdNoonSight.Size = new System.Drawing.Size(210, 25);
            this._cmdNoonSight.TabIndex = 50;
            this._cmdNoonSight.Text = "Evaluate Noon Sight";
            this._cmdNoonSight.UseVisualStyleBackColor = false;
            this._cmdNoonSight.Visible = false;
            this._cmdNoonSight.Click += new System.EventHandler(this.cmdNoonSight_Click);
            // 
            // cboHE
            // 
            this.cboHE.BackColor = System.Drawing.SystemColors.Window;
            this.cboHE.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboHE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHE.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHE.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboHE.Items.AddRange(new object[] {
            "ft",
            "in",
            "m ",
            "cm"});
            this.cboHE.Location = new System.Drawing.Point(378, 219);
            this.cboHE.Name = "cboHE";
            this.cboHE.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboHE.Size = new System.Drawing.Size(41, 22);
            this.cboHE.TabIndex = 43;
            // 
            // cboIE
            // 
            this.cboIE.BackColor = System.Drawing.SystemColors.Window;
            this.cboIE.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboIE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIE.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboIE.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboIE.Items.AddRange(new object[] {
            "on the arc",
            "off the arc (val.)",
            "off the arc (rdg.)"});
            this.cboIE.Location = new System.Drawing.Point(379, 143);
            this.cboIE.Name = "cboIE";
            this.cboIE.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboIE.Size = new System.Drawing.Size(105, 22);
            this.cboIE.TabIndex = 38;
            // 
            // _cboTemperature
            // 
            this._cboTemperature.BackColor = System.Drawing.SystemColors.Window;
            this._cboTemperature.Cursor = System.Windows.Forms.Cursors.Default;
            this._cboTemperature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cboTemperature.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cboTemperature.ForeColor = System.Drawing.SystemColors.WindowText;
            this._cboTemperature.Items.AddRange(new object[] {
            "F ",
            "C "});
            this._cboTemperature.Location = new System.Drawing.Point(648, 105);
            this._cboTemperature.Name = "_cboTemperature";
            this._cboTemperature.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cboTemperature.Size = new System.Drawing.Size(33, 22);
            this._cboTemperature.TabIndex = 47;
            this._cboTemperature.Visible = false;
            this._cboTemperature.SelectedIndexChanged += new System.EventHandler(this.cboTemperature_SelectedIndexChanged);
            // 
            // _cboPressure
            // 
            this._cboPressure.BackColor = System.Drawing.SystemColors.Window;
            this._cboPressure.Cursor = System.Windows.Forms.Cursors.Default;
            this._cboPressure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cboPressure.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cboPressure.ForeColor = System.Drawing.SystemColors.WindowText;
            this._cboPressure.Items.AddRange(new object[] {
            "in Hg",
            "mbar"});
            this._cboPressure.Location = new System.Drawing.Point(647, 132);
            this._cboPressure.Name = "_cboPressure";
            this._cboPressure.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cboPressure.Size = new System.Drawing.Size(57, 22);
            this._cboPressure.TabIndex = 49;
            this._cboPressure.Visible = false;
            this._cboPressure.SelectedIndexChanged += new System.EventHandler(this.cboPressure_SelectedIndexChanged);
            // 
            // Framehs
            // 
            this.Framehs.BackColor = System.Drawing.SystemColors.Window;
            this.Framehs.Controls.Add(this._optHsDMm);
            this.Framehs.Controls.Add(this._optHsDMS);
            this.Framehs.Cursor = System.Windows.Forms.Cursors.Default;
            this.Framehs.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Framehs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Framehs.Location = new System.Drawing.Point(549, 49);
            this.Framehs.Name = "Framehs";
            this.Framehs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Framehs.Size = new System.Drawing.Size(145, 22);
            this.Framehs.TabIndex = 56;
            this.Framehs.Text = "Frame2";
            // 
            // _optHsDMm
            // 
            this._optHsDMm.BackColor = System.Drawing.SystemColors.Window;
            this._optHsDMm.Checked = true;
            this._optHsDMm.Cursor = System.Windows.Forms.Cursors.Default;
            this._optHsDMm.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optHsDMm.ForeColor = System.Drawing.SystemColors.ControlText;
            this._optHsDMm.Location = new System.Drawing.Point(8, 4);
            this._optHsDMm.Name = "_optHsDMm";
            this._optHsDMm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optHsDMm.Size = new System.Drawing.Size(58, 15);
            this._optHsDMm.TabIndex = 30;
            this._optHsDMm.TabStop = true;
            this._optHsDMm.Text = "DM.m";
            this._optHsDMm.UseVisualStyleBackColor = false;
            this._optHsDMm.CheckedChanged += new System.EventHandler(this.optHsDMm_CheckedChanged);
            // 
            // _optHsDMS
            // 
            this._optHsDMS.BackColor = System.Drawing.SystemColors.Window;
            this._optHsDMS.Cursor = System.Windows.Forms.Cursors.Default;
            this._optHsDMS.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optHsDMS.ForeColor = System.Drawing.SystemColors.ControlText;
            this._optHsDMS.Location = new System.Drawing.Point(72, 4);
            this._optHsDMS.Name = "_optHsDMS";
            this._optHsDMS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optHsDMS.Size = new System.Drawing.Size(58, 15);
            this._optHsDMS.TabIndex = 31;
            this._optHsDMS.TabStop = true;
            this._optHsDMS.Text = "DMS";
            this._optHsDMS.UseVisualStyleBackColor = false;
            this._optHsDMS.CheckedChanged += new System.EventHandler(this.optHsDMS_CheckedChanged);
            // 
            // FrameHorizon
            // 
            this.FrameHorizon.BackColor = System.Drawing.SystemColors.Window;
            this.FrameHorizon.Controls.Add(this._optHorizonBubble);
            this.FrameHorizon.Controls.Add(this._optHorizonNatural);
            this.FrameHorizon.Controls.Add(this._optHorizonArtificial);
            this.FrameHorizon.Controls.Add(this._optHorizonDipShort);
            this.FrameHorizon.Cursor = System.Windows.Forms.Cursors.Default;
            this.FrameHorizon.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrameHorizon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FrameHorizon.Location = new System.Drawing.Point(332, 168);
            this.FrameHorizon.Name = "FrameHorizon";
            this.FrameHorizon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FrameHorizon.Size = new System.Drawing.Size(133, 47);
            this.FrameHorizon.TabIndex = 55;
            this.FrameHorizon.Text = "Frame4";
            // 
            // _optHorizonBubble
            // 
            this._optHorizonBubble.BackColor = System.Drawing.SystemColors.Window;
            this._optHorizonBubble.Cursor = System.Windows.Forms.Cursors.Default;
            this._optHorizonBubble.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optHorizonBubble.ForeColor = System.Drawing.SystemColors.ControlText;
            this._optHorizonBubble.Location = new System.Drawing.Point(73, 25);
            this._optHorizonBubble.Name = "_optHorizonBubble";
            this._optHorizonBubble.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optHorizonBubble.Size = new System.Drawing.Size(54, 18);
            this._optHorizonBubble.TabIndex = 103;
            this._optHorizonBubble.TabStop = true;
            this._optHorizonBubble.Text = "Bubble";
            this._optHorizonBubble.UseVisualStyleBackColor = false;
            this._optHorizonBubble.CheckedChanged += new System.EventHandler(this.optHorizonBubble_CheckedChanged);
            // 
            // _optHorizonNatural
            // 
            this._optHorizonNatural.BackColor = System.Drawing.SystemColors.Window;
            this._optHorizonNatural.Checked = true;
            this._optHorizonNatural.Cursor = System.Windows.Forms.Cursors.Default;
            this._optHorizonNatural.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optHorizonNatural.ForeColor = System.Drawing.SystemColors.ControlText;
            this._optHorizonNatural.Location = new System.Drawing.Point(11, 2);
            this._optHorizonNatural.Name = "_optHorizonNatural";
            this._optHorizonNatural.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optHorizonNatural.Size = new System.Drawing.Size(55, 18);
            this._optHorizonNatural.TabIndex = 39;
            this._optHorizonNatural.TabStop = true;
            this._optHorizonNatural.Text = "Natural";
            this._optHorizonNatural.UseVisualStyleBackColor = false;
            this._optHorizonNatural.CheckedChanged += new System.EventHandler(this.optHorizonNatural_CheckedChanged);
            // 
            // _optHorizonArtificial
            // 
            this._optHorizonArtificial.BackColor = System.Drawing.SystemColors.Window;
            this._optHorizonArtificial.Cursor = System.Windows.Forms.Cursors.Default;
            this._optHorizonArtificial.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optHorizonArtificial.ForeColor = System.Drawing.SystemColors.ControlText;
            this._optHorizonArtificial.Location = new System.Drawing.Point(66, 2);
            this._optHorizonArtificial.Name = "_optHorizonArtificial";
            this._optHorizonArtificial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optHorizonArtificial.Size = new System.Drawing.Size(63, 18);
            this._optHorizonArtificial.TabIndex = 40;
            this._optHorizonArtificial.TabStop = true;
            this._optHorizonArtificial.Text = "Artificial";
            this._optHorizonArtificial.UseVisualStyleBackColor = false;
            this._optHorizonArtificial.CheckedChanged += new System.EventHandler(this.optHorizonArtificial_CheckedChanged);
            // 
            // _optHorizonDipShort
            // 
            this._optHorizonDipShort.BackColor = System.Drawing.SystemColors.Window;
            this._optHorizonDipShort.Cursor = System.Windows.Forms.Cursors.Default;
            this._optHorizonDipShort.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optHorizonDipShort.ForeColor = System.Drawing.SystemColors.ControlText;
            this._optHorizonDipShort.Location = new System.Drawing.Point(11, 25);
            this._optHorizonDipShort.Name = "_optHorizonDipShort";
            this._optHorizonDipShort.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optHorizonDipShort.Size = new System.Drawing.Size(63, 18);
            this._optHorizonDipShort.TabIndex = 41;
            this._optHorizonDipShort.TabStop = true;
            this._optHorizonDipShort.Text = "Dip Short";
            this._optHorizonDipShort.UseVisualStyleBackColor = false;
            this._optHorizonDipShort.CheckedChanged += new System.EventHandler(this.optHorizonDipShort_CheckedChanged);
            // 
            // cboDsUnit
            // 
            this.cboDsUnit.BackColor = System.Drawing.SystemColors.Window;
            this.cboDsUnit.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboDsUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDsUnit.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDsUnit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboDsUnit.Items.AddRange(new object[] {
            "feet",
            "yards",
            "meters",
            "statute miles",
            "nautical miles"});
            this.cboDsUnit.Location = new System.Drawing.Point(378, 242);
            this.cboDsUnit.Name = "cboDsUnit";
            this.cboDsUnit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboDsUnit.Size = new System.Drawing.Size(89, 22);
            this.cboDsUnit.TabIndex = 45;
            this.cboDsUnit.Visible = false;
            // 
            // _cmdLAN
            // 
            this._cmdLAN.BackColor = System.Drawing.SystemColors.Control;
            this._cmdLAN.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdLAN.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmdLAN.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdLAN.Location = new System.Drawing.Point(18, 271);
            this._cmdLAN.Name = "_cmdLAN";
            this._cmdLAN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdLAN.Size = new System.Drawing.Size(225, 25);
            this._cmdLAN.TabIndex = 19;
            this._cmdLAN.Text = "Calculate Zone Time of LAN";
            this._cmdLAN.UseVisualStyleBackColor = false;
            this._cmdLAN.Click += new System.EventHandler(this.cmdLAN_Click);
            // 
            // FrameZD
            // 
            this.FrameZD.BackColor = System.Drawing.SystemColors.Window;
            this.FrameZD.Controls.Add(this._optZDUT);
            this.FrameZD.Controls.Add(this._optZDAuto);
            this.FrameZD.Controls.Add(this._optZDManual);
            this.FrameZD.Cursor = System.Windows.Forms.Cursors.Default;
            this.FrameZD.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrameZD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FrameZD.Location = new System.Drawing.Point(37, 138);
            this.FrameZD.Name = "FrameZD";
            this.FrameZD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FrameZD.Size = new System.Drawing.Size(190, 24);
            this.FrameZD.TabIndex = 51;
            this.FrameZD.Text = "Frame1";
            // 
            // _optZDUT
            // 
            this._optZDUT.BackColor = System.Drawing.SystemColors.Window;
            this._optZDUT.Cursor = System.Windows.Forms.Cursors.Default;
            this._optZDUT.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._optZDUT.ForeColor = System.Drawing.SystemColors.ControlText;
            this._optZDUT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this._optZDUT.Location = new System.Drawing.Point(114, 2);
            this._optZDUT.Name = "_optZDUT";
            this._optZDUT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optZDUT.Size = new System.Drawing.Size(73, 17);
            this._optZDUT.TabIndex = 91;
            this._optZDUT.TabStop = true;
            this._optZDUT.Text = "UT (GMT)";
            this._optZDUT.UseVisualStyleBackColor = false;
            this._optZDUT.CheckedChanged += new System.EventHandler(this.optZDUT_CheckedChanged);
            // 
            // _cboZDm
            // 
            this._cboZDm.BackColor = System.Drawing.SystemColors.Window;
            this._cboZDm.Cursor = System.Windows.Forms.Cursors.Default;
            this._cboZDm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cboZDm.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cboZDm.ForeColor = System.Drawing.SystemColors.WindowText;
            this._cboZDm.Items.AddRange(new object[] {
            "00",
            "30",
            "45"});
            this._cboZDm.Location = new System.Drawing.Point(84, 168);
            this._cboZDm.Name = "_cboZDm";
            this._cboZDm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cboZDm.Size = new System.Drawing.Size(41, 22);
            this._cboZDm.TabIndex = 18;
            this._cboZDm.Visible = false;
            this._cboZDm.SelectedIndexChanged += new System.EventHandler(this.cboZDm_SelectedIndexChanged);
            // 
            // _cboLo
            // 
            this._cboLo.BackColor = System.Drawing.SystemColors.Window;
            this._cboLo.Cursor = System.Windows.Forms.Cursors.Default;
            this._cboLo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cboLo.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cboLo.ForeColor = System.Drawing.SystemColors.WindowText;
            this._cboLo.Items.AddRange(new object[] {
            "W",
            "E"});
            this._cboLo.Location = new System.Drawing.Point(182, 93);
            this._cboLo.Name = "_cboLo";
            this._cboLo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cboLo.Size = new System.Drawing.Size(41, 22);
            this._cboLo.TabIndex = 12;
            this._cboLo.SelectedIndexChanged += new System.EventHandler(this.cboLo_SelectedIndexChanged);
            // 
            // lblHoCorrs
            // 
            this.lblHoCorrs.BackColor = System.Drawing.SystemColors.Window;
            this.lblHoCorrs.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblHoCorrs.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoCorrs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHoCorrs.Location = new System.Drawing.Point(489, 164);
            this.lblHoCorrs.Name = "lblHoCorrs";
            this.lblHoCorrs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHoCorrs.Size = new System.Drawing.Size(128, 13);
            this.lblHoCorrs.TabIndex = 89;
            this.lblHoCorrs.Text = "Show Ho corrections as:";
            this.lblHoCorrs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.SystemColors.Window;
            this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label3.Location = new System.Drawing.Point(18, 567);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(142, 42);
            this.Label3.TabIndex = 82;
            this.Label3.Text = "Calculated ZT of LAN  \r\nIncl Eqn of Time Factor";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblZDDST
            // 
            this.lblZDDST.BackColor = System.Drawing.SystemColors.Window;
            this.lblZDDST.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblZDDST.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZDDST.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblZDDST.Location = new System.Drawing.Point(173, 172);
            this.lblZDDST.Name = "lblZDDST";
            this.lblZDDST.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblZDDST.Size = new System.Drawing.Size(33, 13);
            this.lblZDDST.TabIndex = 80;
            this.lblZDDST.Text = "DST";
            // 
            // lblS
            // 
            this.lblS.BackColor = System.Drawing.Color.Transparent;
            this.lblS.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblS.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblS.Location = new System.Drawing.Point(699, 650);
            this.lblS.Name = "lblS";
            this.lblS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblS.Size = new System.Drawing.Size(9, 17);
            this.lblS.TabIndex = 77;
            this.lblS.Text = "S";
            this.lblS.Visible = false;
            // 
            // lblZ
            // 
            this.lblZ.BackColor = System.Drawing.Color.Transparent;
            this.lblZ.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblZ.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZ.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblZ.Location = new System.Drawing.Point(591, 533);
            this.lblZ.Name = "lblZ";
            this.lblZ.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblZ.Size = new System.Drawing.Size(9, 16);
            this.lblZ.TabIndex = 76;
            this.lblZ.Text = "Z";
            this.lblZ.Visible = false;
            // 
            // lblN
            // 
            this.lblN.BackColor = System.Drawing.Color.Transparent;
            this.lblN.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblN.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblN.Location = new System.Drawing.Point(484, 650);
            this.lblN.Name = "lblN";
            this.lblN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblN.Size = new System.Drawing.Size(9, 17);
            this.lblN.TabIndex = 75;
            this.lblN.Text = "N";
            this.lblN.Visible = false;
            // 
            // lblHsDeg
            // 
            this.lblHsDeg.BackColor = System.Drawing.SystemColors.Window;
            this.lblHsDeg.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblHsDeg.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHsDeg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHsDeg.Location = new System.Drawing.Point(288, 122);
            this.lblHsDeg.Name = "lblHsDeg";
            this.lblHsDeg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHsDeg.Size = new System.Drawing.Size(9, 17);
            this.lblHsDeg.TabIndex = 69;
            this.lblHsDeg.Text = "°";
            // 
            // lblHsMin
            // 
            this.lblHsMin.BackColor = System.Drawing.SystemColors.Window;
            this.lblHsMin.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblHsMin.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHsMin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHsMin.Location = new System.Drawing.Point(330, 122);
            this.lblHsMin.Name = "lblHsMin";
            this.lblHsMin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHsMin.Size = new System.Drawing.Size(9, 17);
            this.lblHsMin.TabIndex = 68;
            this.lblHsMin.Text = "\'";
            // 
            // lblHsSec
            // 
            this.lblHsSec.BackColor = System.Drawing.SystemColors.Window;
            this.lblHsSec.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblHsSec.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHsSec.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHsSec.Location = new System.Drawing.Point(370, 122);
            this.lblHsSec.Name = "lblHsSec";
            this.lblHsSec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHsSec.Size = new System.Drawing.Size(9, 17);
            this.lblHsSec.TabIndex = 67;
            this.lblHsSec.Text = "\"";
            this.lblHsSec.Visible = false;
            // 
            // lblIEMin
            // 
            this.lblIEMin.BackColor = System.Drawing.SystemColors.Window;
            this.lblIEMin.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblIEMin.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIEMin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblIEMin.Location = new System.Drawing.Point(330, 145);
            this.lblIEMin.Name = "lblIEMin";
            this.lblIEMin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblIEMin.Size = new System.Drawing.Size(9, 17);
            this.lblIEMin.TabIndex = 64;
            this.lblIEMin.Text = "\'";
            // 
            // lblStdT_P
            // 
            this.lblStdT_P.BackColor = System.Drawing.SystemColors.Window;
            this.lblStdT_P.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblStdT_P.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStdT_P.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStdT_P.Location = new System.Drawing.Point(489, 81);
            this.lblStdT_P.Name = "lblStdT_P";
            this.lblStdT_P.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStdT_P.Size = new System.Drawing.Size(110, 13);
            this.lblStdT_P.TabIndex = 63;
            this.lblStdT_P.Text = "Std. temp. and press.";
            // 
            // lblTemperature
            // 
            this.lblTemperature.BackColor = System.Drawing.SystemColors.Window;
            this.lblTemperature.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTemperature.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperature.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTemperature.Location = new System.Drawing.Point(489, 106);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTemperature.Size = new System.Drawing.Size(86, 19);
            this.lblTemperature.TabIndex = 62;
            this.lblTemperature.Text = "Temperature:";
            this.lblTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTemperature.Visible = false;
            // 
            // lblTempDeg
            // 
            this.lblTempDeg.BackColor = System.Drawing.SystemColors.Window;
            this.lblTempDeg.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTempDeg.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempDeg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTempDeg.Location = new System.Drawing.Point(628, 105);
            this.lblTempDeg.Name = "lblTempDeg";
            this.lblTempDeg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTempDeg.Size = new System.Drawing.Size(9, 17);
            this.lblTempDeg.TabIndex = 61;
            this.lblTempDeg.Text = "°";
            this.lblTempDeg.Visible = false;
            // 
            // lblPressure
            // 
            this.lblPressure.BackColor = System.Drawing.SystemColors.Window;
            this.lblPressure.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPressure.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPressure.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPressure.Location = new System.Drawing.Point(490, 130);
            this.lblPressure.Name = "lblPressure";
            this.lblPressure.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPressure.Size = new System.Drawing.Size(67, 22);
            this.lblPressure.TabIndex = 60;
            this.lblPressure.Text = "Pressure";
            this.lblPressure.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPressure.Visible = false;
            // 
            // lblHorizon
            // 
            this.lblHorizon.BackColor = System.Drawing.SystemColors.Window;
            this.lblHorizon.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblHorizon.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorizon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHorizon.Location = new System.Drawing.Point(231, 174);
            this.lblHorizon.Name = "lblHorizon";
            this.lblHorizon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHorizon.Size = new System.Drawing.Size(81, 17);
            this.lblHorizon.TabIndex = 59;
            this.lblHorizon.Text = "Horizon Type";
            // 
            // lblIEdeg
            // 
            this.lblIEdeg.BackColor = System.Drawing.SystemColors.Window;
            this.lblIEdeg.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblIEdeg.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIEdeg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblIEdeg.Location = new System.Drawing.Point(288, 145);
            this.lblIEdeg.Name = "lblIEdeg";
            this.lblIEdeg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblIEdeg.Size = new System.Drawing.Size(9, 17);
            this.lblIEdeg.TabIndex = 57;
            this.lblIEdeg.Text = "°";
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.Window;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(35, 123);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(129, 13);
            this.Label1.TabIndex = 13;
            this.Label1.Text = "Select ZD of timepiece:";
            // 
            // lblZDh
            // 
            this.lblZDh.BackColor = System.Drawing.SystemColors.Window;
            this.lblZDh.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblZDh.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZDh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblZDh.Location = new System.Drawing.Point(62, 172);
            this.lblZDh.Name = "lblZDh";
            this.lblZDh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblZDh.Size = new System.Drawing.Size(20, 15);
            this.lblZDh.TabIndex = 53;
            this.lblZDh.Text = "Hr";
            this.lblZDh.Visible = false;
            // 
            // lblZDm
            // 
            this.lblZDm.BackColor = System.Drawing.SystemColors.Window;
            this.lblZDm.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblZDm.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZDm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblZDm.Location = new System.Drawing.Point(125, 172);
            this.lblZDm.Name = "lblZDm";
            this.lblZDm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblZDm.Size = new System.Drawing.Size(25, 15);
            this.lblZDm.TabIndex = 52;
            this.lblZDm.Text = "Min";
            this.lblZDm.Visible = false;
            // 
            // lblDRLo
            // 
            this.lblDRLo.BackColor = System.Drawing.SystemColors.Window;
            this.lblDRLo.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDRLo.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDRLo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDRLo.Location = new System.Drawing.Point(13, 96);
            this.lblDRLo.Name = "lblDRLo";
            this.lblDRLo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDRLo.Size = new System.Drawing.Size(80, 17);
            this.lblDRLo.TabIndex = 7;
            this.lblDRLo.Text = "DR Longitude";
            this.lblDRLo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLoDeg
            // 
            this.lblLoDeg.BackColor = System.Drawing.SystemColors.Window;
            this.lblLoDeg.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLoDeg.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoDeg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLoDeg.Location = new System.Drawing.Point(45, 93);
            this.lblLoDeg.Name = "lblLoDeg";
            this.lblLoDeg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLoDeg.Size = new System.Drawing.Size(9, 17);
            this.lblLoDeg.TabIndex = 9;
            this.lblLoDeg.Text = "°";
            // 
            // lblLoMin
            // 
            this.lblLoMin.BackColor = System.Drawing.SystemColors.Window;
            this.lblLoMin.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLoMin.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoMin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLoMin.Location = new System.Drawing.Point(169, 93);
            this.lblLoMin.Name = "lblLoMin";
            this.lblLoMin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLoMin.Size = new System.Drawing.Size(9, 17);
            this.lblLoMin.TabIndex = 11;
            this.lblLoMin.Text = "\'";
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.SystemColors.Window;
            this.lblDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDate.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDate.Location = new System.Drawing.Point(12, 25);
            this.lblDate.Name = "lblDate";
            this.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDate.Size = new System.Drawing.Size(71, 29);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Sight Date \r\n&& Time";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AltitudeTxtBx
            // 
            this.AltitudeTxtBx.BackColor = System.Drawing.SystemColors.Window;
            this.AltitudeTxtBx.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AltitudeTxtBx.Location = new System.Drawing.Point(260, 298);
            this.AltitudeTxtBx.Name = "AltitudeTxtBx";
            this.AltitudeTxtBx.ReadOnly = true;
            this.AltitudeTxtBx.Size = new System.Drawing.Size(210, 20);
            this.AltitudeTxtBx.TabIndex = 91;
            this.AltitudeTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LatitudeTxtBx
            // 
            this.LatitudeTxtBx.BackColor = System.Drawing.SystemColors.Window;
            this.LatitudeTxtBx.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LatitudeTxtBx.Location = new System.Drawing.Point(484, 299);
            this.LatitudeTxtBx.Name = "LatitudeTxtBx";
            this.LatitudeTxtBx.ReadOnly = true;
            this.LatitudeTxtBx.Size = new System.Drawing.Size(230, 20);
            this.LatitudeTxtBx.TabIndex = 93;
            this.LatitudeTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LANTimeTxtBx
            // 
            this.LANTimeTxtBx.BackColor = System.Drawing.SystemColors.Window;
            this.LANTimeTxtBx.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LANTimeTxtBx.Location = new System.Drawing.Point(18, 299);
            this.LANTimeTxtBx.Name = "LANTimeTxtBx";
            this.LANTimeTxtBx.ReadOnly = true;
            this.LANTimeTxtBx.Size = new System.Drawing.Size(225, 20);
            this.LANTimeTxtBx.TabIndex = 95;
            this.LANTimeTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LongitudeCalcTxtBx
            // 
            this.LongitudeCalcTxtBx.BackColor = System.Drawing.SystemColors.Window;
            this.LongitudeCalcTxtBx.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LongitudeCalcTxtBx.Location = new System.Drawing.Point(259, 665);
            this.LongitudeCalcTxtBx.Name = "LongitudeCalcTxtBx";
            this.LongitudeCalcTxtBx.ReadOnly = true;
            this.LongitudeCalcTxtBx.Size = new System.Drawing.Size(455, 20);
            this.LongitudeCalcTxtBx.TabIndex = 96;
            this.LongitudeCalcTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _ExitNoonSight
            // 
            this._ExitNoonSight.BackColor = System.Drawing.Color.Red;
            this._ExitNoonSight.Cursor = System.Windows.Forms.Cursors.Default;
            this._ExitNoonSight.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ExitNoonSight.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this._ExitNoonSight.Location = new System.Drawing.Point(638, 271);
            this._ExitNoonSight.Name = "_ExitNoonSight";
            this._ExitNoonSight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._ExitNoonSight.Size = new System.Drawing.Size(75, 25);
            this._ExitNoonSight.TabIndex = 97;
            this._ExitNoonSight.Text = "Exit";
            this._ExitNoonSight.UseVisualStyleBackColor = false;
            this._ExitNoonSight.Click += new System.EventHandler(this.ExitNoonSight_Click);
            // 
            // _ClearScrBtn
            // 
            this._ClearScrBtn.BackColor = System.Drawing.SystemColors.Control;
            this._ClearScrBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this._ClearScrBtn.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ClearScrBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this._ClearScrBtn.Location = new System.Drawing.Point(484, 270);
            this._ClearScrBtn.Name = "_ClearScrBtn";
            this._ClearScrBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._ClearScrBtn.Size = new System.Drawing.Size(81, 25);
            this._ClearScrBtn.TabIndex = 102;
            this._ClearScrBtn.Text = "Clear All";
            this._ClearScrBtn.UseVisualStyleBackColor = false;
            this._ClearScrBtn.Click += new System.EventHandler(this.ClearScrBtn_Click);
            // 
            // _OldFormBtn
            // 
            this._OldFormBtn.AutoSize = true;
            this._OldFormBtn.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._OldFormBtn.Location = new System.Drawing.Point(628, 204);
            this._OldFormBtn.Name = "_OldFormBtn";
            this._OldFormBtn.Size = new System.Drawing.Size(68, 18);
            this._OldFormBtn.TabIndex = 104;
            this._OldFormBtn.Text = "Old Form";
            this._OldFormBtn.UseVisualStyleBackColor = true;
            this._OldFormBtn.Visible = false;
            this._OldFormBtn.CheckedChanged += new System.EventHandler(this.OldFormBtn_CheckedChanged);
            // 
            // _NewFormBtn
            // 
            this._NewFormBtn.AutoSize = true;
            this._NewFormBtn.Checked = true;
            this._NewFormBtn.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._NewFormBtn.Location = new System.Drawing.Point(553, 202);
            this._NewFormBtn.Name = "_NewFormBtn";
            this._NewFormBtn.Size = new System.Drawing.Size(75, 18);
            this._NewFormBtn.TabIndex = 103;
            this._NewFormBtn.TabStop = true;
            this._NewFormBtn.Text = "New Form\r\n";
            this._NewFormBtn.UseVisualStyleBackColor = true;
            this._NewFormBtn.Visible = false;
            this._NewFormBtn.CheckedChanged += new System.EventHandler(this.NewFormBtn_CheckedChanged);
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.SystemColors.Window;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(124, 93);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(9, 17);
            this.Label2.TabIndex = 110;
            this.Label2.Text = "°";
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.SystemColors.Window;
            this.Label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label4.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label4.Location = new System.Drawing.Point(9, 62);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label4.Size = new System.Drawing.Size(80, 17);
            this.Label4.TabIndex = 111;
            this.Label4.Text = "DR Latitude";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.SystemColors.Window;
            this.Label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label5.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label5.Location = new System.Drawing.Point(21, 610);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label5.Size = new System.Drawing.Size(139, 19);
            this.Label5.TabIndex = 116;
            this.Label5.Text = "Est Ho of Center at LAN";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIEsec
            // 
            this.lblIEsec.BackColor = System.Drawing.SystemColors.Window;
            this.lblIEsec.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblIEsec.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIEsec.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblIEsec.Location = new System.Drawing.Point(370, 145);
            this.lblIEsec.Name = "lblIEsec";
            this.lblIEsec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblIEsec.Size = new System.Drawing.Size(9, 17);
            this.lblIEsec.TabIndex = 78;
            this.lblIEsec.Text = "\"";
            this.lblIEsec.Visible = false;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::CelestialTools.My.Resources.Resources.ABC_white;
            this.PictureBox1.Location = new System.Drawing.Point(232, 689);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(316, 50);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 108;
            this.PictureBox1.TabStop = false;
            // 
            // _MeridianPicBx
            // 
            this._MeridianPicBx.Location = new System.Drawing.Point(484, 546);
            this._MeridianPicBx.Name = "_MeridianPicBx";
            this._MeridianPicBx.Size = new System.Drawing.Size(230, 115);
            this._MeridianPicBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this._MeridianPicBx.TabIndex = 94;
            this._MeridianPicBx.TabStop = false;
            this._MeridianPicBx.Paint += new System.Windows.Forms.PaintEventHandler(this.MeridianPicBx_Paint);
            // 
            // _btnDisplayEQTData
            // 
            this._btnDisplayEQTData.Location = new System.Drawing.Point(30, 636);
            this._btnDisplayEQTData.Name = "_btnDisplayEQTData";
            this._btnDisplayEQTData.Size = new System.Drawing.Size(216, 23);
            this._btnDisplayEQTData.TabIndex = 118;
            this._btnDisplayEQTData.TabStop = false;
            this._btnDisplayEQTData.Text = "Display EQT Data for Year";
            this._btnDisplayEQTData.UseVisualStyleBackColor = true;
            this._btnDisplayEQTData.Visible = false;
            this._btnDisplayEQTData.Click += new System.EventHandler(this.btnDisplayEQTData_Click);
            // 
            // DGLAN
            // 
            this.DGLAN.AllowUserToAddRows = false;
            this.DGLAN.AllowUserToDeleteRows = false;
            this.DGLAN.AllowUserToResizeColumns = false;
            this.DGLAN.AllowUserToResizeRows = false;
            this.DGLAN.BackgroundColor = System.Drawing.Color.White;
            this.DGLAN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGLAN.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGLAN.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGLAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGLAN.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGLAN.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGLAN.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGLAN.Location = new System.Drawing.Point(18, 322);
            this.DGLAN.MultiSelect = false;
            this.DGLAN.Name = "DGLAN";
            this.DGLAN.ReadOnly = true;
            this.DGLAN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DGLAN.RowHeadersVisible = false;
            this.DGLAN.RowTemplate.ReadOnly = true;
            this.DGLAN.Size = new System.Drawing.Size(225, 223);
            this.DGLAN.TabIndex = 119;
            // 
            // DGAlt
            // 
            this.DGAlt.AllowUserToAddRows = false;
            this.DGAlt.AllowUserToDeleteRows = false;
            this.DGAlt.AllowUserToResizeColumns = false;
            this.DGAlt.AllowUserToResizeRows = false;
            this.DGAlt.BackgroundColor = System.Drawing.Color.White;
            this.DGAlt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGAlt.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGAlt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGAlt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGAlt.Cursor = System.Windows.Forms.Cursors.Default;
            this.DGAlt.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGAlt.Location = new System.Drawing.Point(260, 320);
            this.DGAlt.MultiSelect = false;
            this.DGAlt.Name = "DGAlt";
            this.DGAlt.ReadOnly = true;
            this.DGAlt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DGAlt.RowHeadersVisible = false;
            this.DGAlt.RowTemplate.ReadOnly = true;
            this.DGAlt.Size = new System.Drawing.Size(210, 225);
            this.DGAlt.TabIndex = 120;
            // 
            // AlmanacTxtBx
            // 
            this.AlmanacTxtBx.BackColor = System.Drawing.SystemColors.Window;
            this.AlmanacTxtBx.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlmanacTxtBx.Location = new System.Drawing.Point(260, 547);
            this.AlmanacTxtBx.Name = "AlmanacTxtBx";
            this.AlmanacTxtBx.ReadOnly = true;
            this.AlmanacTxtBx.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.AlmanacTxtBx.Size = new System.Drawing.Size(210, 20);
            this.AlmanacTxtBx.TabIndex = 92;
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.GroupBox1.Location = new System.Drawing.Point(488, 34);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(225, 188);
            this.GroupBox1.TabIndex = 112;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Noon Sight Eval Settings";
            // 
            // DGAlm
            // 
            this.DGAlm.AllowUserToAddRows = false;
            this.DGAlm.AllowUserToDeleteRows = false;
            this.DGAlm.AllowUserToResizeColumns = false;
            this.DGAlm.AllowUserToResizeRows = false;
            this.DGAlm.BackgroundColor = System.Drawing.Color.White;
            this.DGAlm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGAlm.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGAlm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGAlm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGAlm.Cursor = System.Windows.Forms.Cursors.Default;
            this.DGAlm.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGAlm.Location = new System.Drawing.Point(260, 568);
            this.DGAlm.MultiSelect = false;
            this.DGAlm.Name = "DGAlm";
            this.DGAlm.ReadOnly = true;
            this.DGAlm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DGAlm.RowHeadersVisible = false;
            this.DGAlm.RowTemplate.ReadOnly = true;
            this.DGAlm.Size = new System.Drawing.Size(210, 90);
            this.DGAlm.TabIndex = 121;
            // 
            // DGLat
            // 
            this.DGLat.AllowUserToAddRows = false;
            this.DGLat.AllowUserToDeleteRows = false;
            this.DGLat.AllowUserToResizeColumns = false;
            this.DGLat.AllowUserToResizeRows = false;
            this.DGLat.BackgroundColor = System.Drawing.Color.White;
            this.DGLat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGLat.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGLat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGLat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGLat.Cursor = System.Windows.Forms.Cursors.Default;
            this.DGLat.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGLat.Location = new System.Drawing.Point(484, 321);
            this.DGLat.MultiSelect = false;
            this.DGLat.Name = "DGLat";
            this.DGLat.ReadOnly = true;
            this.DGLat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DGLat.RowHeadersVisible = false;
            this.DGLat.RowTemplate.ReadOnly = true;
            this.DGLat.Size = new System.Drawing.Size(230, 215);
            this.DGLat.TabIndex = 122;
            // 
            // txtUserInfo
            // 
            this.txtUserInfo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserInfo.HideSelection = false;
            this.txtUserInfo.Location = new System.Drawing.Point(77, 1);
            this.txtUserInfo.Name = "txtUserInfo";
            this.txtUserInfo.Size = new System.Drawing.Size(400, 20);
            this.txtUserInfo.TabIndex = 198;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(20, 4);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(51, 14);
            this.Label7.TabIndex = 197;
            this.Label7.Text = "User Info";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtZTLANWarn
            // 
            this.txtZTLANWarn.BackColor = System.Drawing.Color.Yellow;
            this.txtZTLANWarn.Location = new System.Drawing.Point(487, 223);
            this.txtZTLANWarn.Multiline = true;
            this.txtZTLANWarn.Name = "txtZTLANWarn";
            this.txtZTLANWarn.ReadOnly = true;
            this.txtZTLANWarn.Size = new System.Drawing.Size(226, 45);
            this.txtZTLANWarn.TabIndex = 199;
            this.txtZTLANWarn.Text = "WARNING: The ZT of this Sun Sight is > 1 hour from LAN. Use the SRF form for Sun " +
    "Sight Reductions.";
            this.txtZTLANWarn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtZTLANWarn.Visible = false;
            // 
            // FormNoonSight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(722, 741);
            this.Controls.Add(this.txtZTLANWarn);
            this.Controls.Add(this.txtUserInfo);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.DGLat);
            this.Controls.Add(this.DGAlm);
            this.Controls.Add(this._cmdPrint);
            this.Controls.Add(this.DGAlt);
            this.Controls.Add(this.DGLAN);
            this.Controls.Add(this._btnDisplayEQTData);
            this.Controls.Add(this.txtCalcHo);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this._txtDRLMin);
            this.Controls.Add(this._NewFormBtn);
            this.Controls.Add(this._cboDRL);
            this.Controls.Add(this._txtDRLDeg);
            this.Controls.Add(this._OldFormBtn);
            this.Controls.Add(this._optHoParameters);
            this.Controls.Add(this._optHoSRForm);
            this.Controls.Add(this.lblLDeg);
            this.Controls.Add(this._optStdTPNo);
            this.Controls.Add(this.lblLMin);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this._OptStdTPYes);
            this.Controls.Add(this.DTNoonSight);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this._ClearScrBtn);
            this.Controls.Add(this._ExitNoonSight);
            this.Controls.Add(this.LongitudeCalcTxtBx);
            this.Controls.Add(this.LANTimeTxtBx);
            this.Controls.Add(this.LatitudeTxtBx);
            this.Controls.Add(this.AlmanacTxtBx);
            this.Controls.Add(this.AltitudeTxtBx);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this._chkDST);
            this.Controls.Add(this._txtIESec);
            this.Controls.Add(this.Frame2);
            this.Controls.Add(this.Frame1);
            this.Controls.Add(this._cmdNoonSight);
            this.Controls.Add(this._txtHsDeg);
            this.Controls.Add(this._txtHsMin);
            this.Controls.Add(this._txtHsSec);
            this.Controls.Add(this._txtHE);
            this.Controls.Add(this.cboHE);
            this.Controls.Add(this._txtIEmin);
            this.Controls.Add(this.cboIE);
            this.Controls.Add(this._txtTemperature);
            this.Controls.Add(this._cboTemperature);
            this.Controls.Add(this._txtPressure);
            this.Controls.Add(this._cboPressure);
            this.Controls.Add(this.Framehs);
            this.Controls.Add(this.FrameHorizon);
            this.Controls.Add(this._txtDsDist);
            this.Controls.Add(this.cboDsUnit);
            this.Controls.Add(this._txtIEdeg);
            this.Controls.Add(this._cmdLAN);
            this.Controls.Add(this._txtZDh);
            this.Controls.Add(this.FrameZD);
            this.Controls.Add(this._cboZDm);
            this.Controls.Add(this._txtLoDeg);
            this.Controls.Add(this._txtLoMin);
            this.Controls.Add(this._cboLo);
            this.Controls.Add(this.lblHoCorrs);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.lblZDDST);
            this.Controls.Add(this.lblIEsec);
            this.Controls.Add(this.lblS);
            this.Controls.Add(this.lblZ);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.lblHsFormat);
            this.Controls.Add(this.lblHs);
            this.Controls.Add(this.lblHsDeg);
            this.Controls.Add(this.lblHsMin);
            this.Controls.Add(this.lblHsSec);
            this.Controls.Add(this.lblHE);
            this.Controls.Add(this.lblIE);
            this.Controls.Add(this.lblIEMin);
            this.Controls.Add(this.lblStdT_P);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.lblTempDeg);
            this.Controls.Add(this.lblPressure);
            this.Controls.Add(this.lblHorizon);
            this.Controls.Add(this.lblDsDist);
            this.Controls.Add(this.lblIEdeg);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.lblZDAutoManual);
            this.Controls.Add(this.lblZD);
            this.Controls.Add(this.lblZDh);
            this.Controls.Add(this.lblZDm);
            this.Controls.Add(this.lblDRLo);
            this.Controls.Add(this.lblLoDeg);
            this.Controls.Add(this.lblLoMin);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this._MeridianPicBx);
            this.Controls.Add(this.GroupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(194, 29);
            this.MaximizeBox = false;
            this.Name = "FormNoonSight";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Noon Sight";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormNoonSight_FormClosed);
            this.Load += new System.EventHandler(this.FormNoonSight_Load);
            this.Frame2.ResumeLayout(false);
            this.Frame1.ResumeLayout(false);
            this.Framehs.ResumeLayout(false);
            this.FrameHorizon.ResumeLayout(false);
            this.FrameZD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._MeridianPicBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGLAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGAlt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGAlm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGLat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal TextBox AltitudeTxtBx;
        internal TextBox LatitudeTxtBx;
        private PictureBox _MeridianPicBx;

        internal PictureBox MeridianPicBx
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _MeridianPicBx;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_MeridianPicBx != null)
                {
                    _MeridianPicBx.Paint -= MeridianPicBx_Paint;
                }

                _MeridianPicBx = value;
                if (_MeridianPicBx != null)
                {
                    _MeridianPicBx.Paint += MeridianPicBx_Paint;
                }
            }
        }

        internal TextBox LANTimeTxtBx;
        internal TextBox LongitudeCalcTxtBx;
        private Button _ExitNoonSight;

        public Button ExitNoonSight
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ExitNoonSight;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ExitNoonSight != null)
                {
                    _ExitNoonSight.Click -= ExitNoonSight_Click;
                }

                _ExitNoonSight = value;
                if (_ExitNoonSight != null)
                {
                    _ExitNoonSight.Click += ExitNoonSight_Click;
                }
            }
        }

        private Button _ClearScrBtn;

        public Button ClearScrBtn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ClearScrBtn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ClearScrBtn != null)
                {
                    _ClearScrBtn.Click -= ClearScrBtn_Click;
                }

                _ClearScrBtn = value;
                if (_ClearScrBtn != null)
                {
                    _ClearScrBtn.Click += ClearScrBtn_Click;
                }
            }
        }

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

        private RadioButton _OldFormBtn;

        internal RadioButton OldFormBtn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _OldFormBtn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_OldFormBtn != null)
                {
                    _OldFormBtn.CheckedChanged -= OldFormBtn_CheckedChanged;
                }

                _OldFormBtn = value;
                if (_OldFormBtn != null)
                {
                    _OldFormBtn.CheckedChanged += OldFormBtn_CheckedChanged;
                }
            }
        }

        private RadioButton _NewFormBtn;

        internal RadioButton NewFormBtn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _NewFormBtn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_NewFormBtn != null)
                {
                    _NewFormBtn.CheckedChanged -= NewFormBtn_CheckedChanged;
                }

                _NewFormBtn = value;
                if (_NewFormBtn != null)
                {
                    _NewFormBtn.CheckedChanged += NewFormBtn_CheckedChanged;
                }
            }
        }

        internal PictureBox PictureBox1;
        internal DateTimePicker DTNoonSight;
        public Label Label2;
        public Label Label4;
        public Label Label5;
        public TextBox txtCalcHo;
        public Label lblIEsec;
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

        private Button _btnDisplayEQTData;

        internal Button btnDisplayEQTData
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnDisplayEQTData;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnDisplayEQTData != null)
                {
                    _btnDisplayEQTData.Click -= btnDisplayEQTData_Click;
                }

                _btnDisplayEQTData = value;
                if (_btnDisplayEQTData != null)
                {
                    _btnDisplayEQTData.Click += btnDisplayEQTData_Click;
                }
            }
        }

        internal DataGridView DGLAN;
        internal DataGridView DGAlt;
        internal TextBox AlmanacTxtBx;
        internal GroupBox GroupBox1;
        internal DataGridView DGAlm;
        internal DataGridView DGLat;
        internal TextBox txtUserInfo;
        internal Label Label7;
        internal TextBox txtZTLANWarn;
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}