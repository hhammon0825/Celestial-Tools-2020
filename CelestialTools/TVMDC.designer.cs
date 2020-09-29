using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    [DesignerGenerated()]
    internal partial class FormTVMDC
    {
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        [DebuggerNonUserCode()]
        public FormTVMDC() : base()
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

        public TextBox txtEW;
        public TextBox txtCorrVar;
        private TextBox _txtYI;

        public TextBox txtYI
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtYI;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtYI != null)
                {
                    _txtYI.TextChanged -= txtYI_TextChanged;
                    _txtYI.KeyPress -= txtYI_KeyPress;
                    _txtYI.Enter -= txtYI_Enter;
                }

                _txtYI = value;
                if (_txtYI != null)
                {
                    _txtYI.TextChanged += txtYI_TextChanged;
                    _txtYI.KeyPress += txtYI_KeyPress;
                    _txtYI.Enter += txtYI_Enter;
                }
            }
        }

        private ComboBox _cboCV;

        public ComboBox cboCV
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboCV;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboCV != null)
                {
                    _cboCV.SelectedIndexChanged -= cboCV_SelectedIndexChanged;
                }

                _cboCV = value;
                if (_cboCV != null)
                {
                    _cboCV.SelectedIndexChanged += cboCV_SelectedIndexChanged;
                }
            }
        }

        private ComboBox _cboD;

        public ComboBox cboD
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboD;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboD != null)
                {
                    _cboD.SelectedIndexChanged -= cboD_SelectedIndexChanged;
                }

                _cboD = value;
                if (_cboD != null)
                {
                    _cboD.SelectedIndexChanged += cboD_SelectedIndexChanged;
                }
            }
        }

        private ComboBox _cboV;

        public ComboBox cboV
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboV;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboV != null)
                {
                    _cboV.SelectedIndexChanged -= cboV_SelectedIndexChanged;
                }

                _cboV = value;
                if (_cboV != null)
                {
                    _cboV.SelectedIndexChanged += cboV_SelectedIndexChanged;
                }
            }
        }

        private ComboBox _cboIncDec;

        public ComboBox cboIncDec
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboIncDec;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboIncDec != null)
                {
                    _cboIncDec.SelectedIndexChanged -= cboIncDec_SelectedIndexChanged;
                }

                _cboIncDec = value;
                if (_cboIncDec != null)
                {
                    _cboIncDec.SelectedIndexChanged += cboIncDec_SelectedIndexChanged;
                }
            }
        }

        private TextBox _txtChange;

        public TextBox txtChange
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtChange;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtChange != null)
                {
                    _txtChange.TextChanged -= txtChange_TextChanged;
                    _txtChange.KeyPress -= txtChange_KeyPress;
                    _txtChange.Validating -= txtChange_Validating;
                    _txtChange.Enter -= txtChange_Enter;
                }

                _txtChange = value;
                if (_txtChange != null)
                {
                    _txtChange.TextChanged += txtChange_TextChanged;
                    _txtChange.KeyPress += txtChange_KeyPress;
                    _txtChange.Validating += txtChange_Validating;
                    _txtChange.Enter += txtChange_Enter;
                }
            }
        }

        private TextBox _txtCY;

        public TextBox txtCY
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtCY;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtCY != null)
                {
                    _txtCY.TextChanged -= txtCY_TextChanged;
                    _txtCY.KeyPress -= txtCY_KeyPress;
                    _txtCY.Enter -= txtCY_Enter;
                }

                _txtCY = value;
                if (_txtCY != null)
                {
                    _txtCY.TextChanged += txtCY_TextChanged;
                    _txtCY.KeyPress += txtCY_KeyPress;
                    _txtCY.Enter += txtCY_Enter;
                }
            }
        }

        private TextBox _txtCVMin;

        public TextBox txtCVMin
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtCVMin;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtCVMin != null)
                {
                    _txtCVMin.TextChanged -= txtCVMin_TextChanged;
                    _txtCVMin.KeyPress -= txtCVMin_KeyPress;
                    _txtCVMin.Validating -= txtCVMin_Validating;
                    _txtCVMin.Enter -= txtCVMin_Enter;
                }

                _txtCVMin = value;
                if (_txtCVMin != null)
                {
                    _txtCVMin.TextChanged += txtCVMin_TextChanged;
                    _txtCVMin.KeyPress += txtCVMin_KeyPress;
                    _txtCVMin.Validating += txtCVMin_Validating;
                    _txtCVMin.Enter += txtCVMin_Enter;
                }
            }
        }

        private TextBox _txtCVDeg;

        public TextBox txtCVDeg
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtCVDeg;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtCVDeg != null)
                {
                    _txtCVDeg.TextChanged -= txtCVDeg_TextChanged;
                    _txtCVDeg.KeyPress -= txtCVDeg_KeyPress;
                    _txtCVDeg.Enter -= txtCVDeg_Enter;
                }

                _txtCVDeg = value;
                if (_txtCVDeg != null)
                {
                    _txtCVDeg.TextChanged += txtCVDeg_TextChanged;
                    _txtCVDeg.KeyPress += txtCVDeg_KeyPress;
                    _txtCVDeg.Enter += txtCVDeg_Enter;
                }
            }
        }

        private TextBox _txtCompass;

        public TextBox txtCompass
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtCompass;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtCompass != null)
                {
                    _txtCompass.KeyPress -= txtCompass_KeyPress;
                    _txtCompass.KeyDown -= txtCompass_KeyDown;
                    _txtCompass.TextChanged -= txtCompass_TextChanged;
                    _txtCompass.Validating -= txtCompass_Validating;
                    _txtCompass.Enter -= txtCompass_Enter;
                    _txtCompass.Leave -= txtCompass_Leave;
                }

                _txtCompass = value;
                if (_txtCompass != null)
                {
                    _txtCompass.KeyPress += txtCompass_KeyPress;
                    _txtCompass.KeyDown += txtCompass_KeyDown;
                    _txtCompass.TextChanged += txtCompass_TextChanged;
                    _txtCompass.Validating += txtCompass_Validating;
                    _txtCompass.Enter += txtCompass_Enter;
                    _txtCompass.Leave += txtCompass_Leave;
                }
            }
        }

        private TextBox _txtDeviation;

        public TextBox txtDeviation
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtDeviation;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtDeviation != null)
                {
                    _txtDeviation.KeyPress -= txtDeviation_KeyPress;
                    _txtDeviation.KeyDown -= txtDeviation_KeyDown;
                    _txtDeviation.Enter -= txtDeviation_Enter;
                    _txtDeviation.Leave -= txtDeviation_Leave;
                    _txtDeviation.TextChanged -= txtDeviation_TextChanged;
                }

                _txtDeviation = value;
                if (_txtDeviation != null)
                {
                    _txtDeviation.KeyPress += txtDeviation_KeyPress;
                    _txtDeviation.KeyDown += txtDeviation_KeyDown;
                    _txtDeviation.Enter += txtDeviation_Enter;
                    _txtDeviation.Leave += txtDeviation_Leave;
                    _txtDeviation.TextChanged += txtDeviation_TextChanged;
                }
            }
        }

        private TextBox _txtMagnetic;

        public TextBox txtMagnetic
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtMagnetic;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtMagnetic != null)
                {
                    _txtMagnetic.KeyPress -= txtMagnetic_KeyPress;
                    _txtMagnetic.KeyDown -= txtMagnetic_KeyDown;
                    _txtMagnetic.TextChanged -= txtMagnetic_TextChanged;
                    _txtMagnetic.Leave -= txtMagnetic_Leave;
                    _txtMagnetic.Validating -= txtMagnetic_Validating;
                    _txtMagnetic.Enter -= txtMagnetic_Enter;
                }

                _txtMagnetic = value;
                if (_txtMagnetic != null)
                {
                    _txtMagnetic.KeyPress += txtMagnetic_KeyPress;
                    _txtMagnetic.KeyDown += txtMagnetic_KeyDown;
                    _txtMagnetic.TextChanged += txtMagnetic_TextChanged;
                    _txtMagnetic.Leave += txtMagnetic_Leave;
                    _txtMagnetic.Validating += txtMagnetic_Validating;
                    _txtMagnetic.Enter += txtMagnetic_Enter;
                }
            }
        }

        private TextBox _txtVariation;

        public TextBox txtVariation
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtVariation;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtVariation != null)
                {
                    _txtVariation.KeyPress -= txtVariation_KeyPress;
                    _txtVariation.KeyDown -= txtVariation_KeyDown;
                    _txtVariation.Enter -= txtVariation_Enter;
                    _txtVariation.Leave -= txtVariation_Leave;
                    _txtVariation.TextChanged -= txtVariation_TextChanged;
                }

                _txtVariation = value;
                if (_txtVariation != null)
                {
                    _txtVariation.KeyPress += txtVariation_KeyPress;
                    _txtVariation.KeyDown += txtVariation_KeyDown;
                    _txtVariation.Enter += txtVariation_Enter;
                    _txtVariation.Leave += txtVariation_Leave;
                    _txtVariation.TextChanged += txtVariation_TextChanged;
                }
            }
        }

        private TextBox _txtTrue;

        public TextBox txtTrue
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtTrue;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtTrue != null)
                {
                    _txtTrue.KeyPress -= txtTrue_KeyPress;
                    _txtTrue.KeyDown -= txtTrue_KeyDown;
                    _txtTrue.TextChanged -= txtTrue_TextChanged;
                    _txtTrue.Validating -= txtTrue_Validating;
                    _txtTrue.Enter -= txtTrue_Enter;
                    _txtTrue.Leave -= txtTrue_Leave;
                }

                _txtTrue = value;
                if (_txtTrue != null)
                {
                    _txtTrue.KeyPress += txtTrue_KeyPress;
                    _txtTrue.KeyDown += txtTrue_KeyDown;
                    _txtTrue.TextChanged += txtTrue_TextChanged;
                    _txtTrue.Validating += txtTrue_Validating;
                    _txtTrue.Enter += txtTrue_Enter;
                    _txtTrue.Leave += txtTrue_Leave;
                }
            }
        }

        public Label Label15;
        public Label Label14;
        public Label Label13;
        public Label Label12;
        public Label Label11;
        public Label Label10;
        public Label Label9;
        public Label Label8;
        public Label Label7;
        public Label Label6;
        // Public WithEvents Line1 As Microsoft.VisualBasic.PowerPacks.LineShape
        public Label Label5;
        public Label Label4;
        public Label Label3;
        public Label Label2;
        public Label Label1;
        public Label lblCompass;
        public Label lblDeviation;
        public Label lblMagnetic;
        public Label lblVariation;
        public Label lblTrue;
        // Public WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
        // Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTVMDC));
            ToolTip1 = new ToolTip(components);
            _cmdPrint = new Button();
            _cmdPrint.Click += new EventHandler(cmdPrint_Click);
            _txtYI = new TextBox();
            _txtYI.TextChanged += new EventHandler(txtYI_TextChanged);
            _txtYI.KeyPress += new KeyPressEventHandler(txtYI_KeyPress);
            _txtYI.Enter += new EventHandler(txtYI_Enter);
            _txtChange = new TextBox();
            _txtChange.TextChanged += new EventHandler(txtChange_TextChanged);
            _txtChange.KeyPress += new KeyPressEventHandler(txtChange_KeyPress);
            _txtChange.Validating += new System.ComponentModel.CancelEventHandler(txtChange_Validating);
            _txtChange.Enter += new EventHandler(txtChange_Enter);
            _txtCY = new TextBox();
            _txtCY.TextChanged += new EventHandler(txtCY_TextChanged);
            _txtCY.KeyPress += new KeyPressEventHandler(txtCY_KeyPress);
            _txtCY.Enter += new EventHandler(txtCY_Enter);
            _txtCVMin = new TextBox();
            _txtCVMin.TextChanged += new EventHandler(txtCVMin_TextChanged);
            _txtCVMin.KeyPress += new KeyPressEventHandler(txtCVMin_KeyPress);
            _txtCVMin.Validating += new System.ComponentModel.CancelEventHandler(txtCVMin_Validating);
            _txtCVMin.Enter += new EventHandler(txtCVMin_Enter);
            _txtCVDeg = new TextBox();
            _txtCVDeg.TextChanged += new EventHandler(txtCVDeg_TextChanged);
            _txtCVDeg.KeyPress += new KeyPressEventHandler(txtCVDeg_KeyPress);
            _txtCVDeg.Enter += new EventHandler(txtCVDeg_Enter);
            _txtCompass = new TextBox();
            _txtCompass.KeyPress += new KeyPressEventHandler(txtCompass_KeyPress);
            _txtCompass.KeyDown += new KeyEventHandler(txtCompass_KeyDown);
            _txtCompass.TextChanged += new EventHandler(txtCompass_TextChanged);
            _txtCompass.Validating += new System.ComponentModel.CancelEventHandler(txtCompass_Validating);
            _txtCompass.Enter += new EventHandler(txtCompass_Enter);
            _txtCompass.Leave += new EventHandler(txtCompass_Leave);
            _txtDeviation = new TextBox();
            _txtDeviation.KeyPress += new KeyPressEventHandler(txtDeviation_KeyPress);
            _txtDeviation.KeyDown += new KeyEventHandler(txtDeviation_KeyDown);
            _txtDeviation.Enter += new EventHandler(txtDeviation_Enter);
            _txtDeviation.Leave += new EventHandler(txtDeviation_Leave);
            _txtDeviation.TextChanged += new EventHandler(txtDeviation_TextChanged);
            _txtMagnetic = new TextBox();
            _txtMagnetic.KeyPress += new KeyPressEventHandler(txtMagnetic_KeyPress);
            _txtMagnetic.KeyDown += new KeyEventHandler(txtMagnetic_KeyDown);
            _txtMagnetic.TextChanged += new EventHandler(txtMagnetic_TextChanged);
            _txtMagnetic.Leave += new EventHandler(txtMagnetic_Leave);
            _txtMagnetic.Validating += new System.ComponentModel.CancelEventHandler(txtMagnetic_Validating);
            _txtMagnetic.Enter += new EventHandler(txtMagnetic_Enter);
            _txtVariation = new TextBox();
            _txtVariation.KeyPress += new KeyPressEventHandler(txtVariation_KeyPress);
            _txtVariation.KeyDown += new KeyEventHandler(txtVariation_KeyDown);
            _txtVariation.Enter += new EventHandler(txtVariation_Enter);
            _txtVariation.Leave += new EventHandler(txtVariation_Leave);
            _txtVariation.TextChanged += new EventHandler(txtVariation_TextChanged);
            _txtTrue = new TextBox();
            _txtTrue.KeyPress += new KeyPressEventHandler(txtTrue_KeyPress);
            _txtTrue.KeyDown += new KeyEventHandler(txtTrue_KeyDown);
            _txtTrue.TextChanged += new EventHandler(txtTrue_TextChanged);
            _txtTrue.Validating += new System.ComponentModel.CancelEventHandler(txtTrue_Validating);
            _txtTrue.Enter += new EventHandler(txtTrue_Enter);
            _txtTrue.Leave += new EventHandler(txtTrue_Leave);
            _btnCalcTVMDC = new Button();
            _btnCalcTVMDC.Click += new EventHandler(btnCalcTVMDC_Click);
            _cmdClear = new Button();
            _cmdClear.Click += new EventHandler(cmdClear_Click);
            txtEW = new TextBox();
            txtCorrVar = new TextBox();
            _cboCV = new ComboBox();
            _cboCV.SelectedIndexChanged += new EventHandler(cboCV_SelectedIndexChanged);
            _cboD = new ComboBox();
            _cboD.SelectedIndexChanged += new EventHandler(cboD_SelectedIndexChanged);
            _cboV = new ComboBox();
            _cboV.SelectedIndexChanged += new EventHandler(cboV_SelectedIndexChanged);
            _cboIncDec = new ComboBox();
            _cboIncDec.SelectedIndexChanged += new EventHandler(cboIncDec_SelectedIndexChanged);
            Label15 = new Label();
            Label14 = new Label();
            Label13 = new Label();
            Label12 = new Label();
            Label11 = new Label();
            Label10 = new Label();
            Label9 = new Label();
            Label8 = new Label();
            Label7 = new Label();
            Label6 = new Label();
            Label5 = new Label();
            Label4 = new Label();
            Label3 = new Label();
            Label2 = new Label();
            Label1 = new Label();
            lblCompass = new Label();
            lblDeviation = new Label();
            lblMagnetic = new Label();
            lblVariation = new Label();
            lblTrue = new Label();
            _ExitBtn = new Button();
            _ExitBtn.Click += new EventHandler(ExitBtn_Click);
            _chkDev = new CheckBox();
            _chkDev.CheckedChanged += new EventHandler(chkDev_CheckedChanged);
            PictureBox1 = new PictureBox();
            Label16 = new Label();
            DirectionLbl = new Label();
            _optDown = new RadioButton();
            _optDown.CheckedChanged += new EventHandler(optDown_CheckedChanged);
            _optUp = new RadioButton();
            _optUp.CheckedChanged += new EventHandler(optUp_CheckedChanged);
            Frame1 = new GroupBox();
            _CalcControl = new TabControl();
            _CalcControl.SelectedIndexChanged += new EventHandler(CalcControl_SelectedIndexChanged);
            CalcTVMDC = new TabPage();
            _chkChartVar = new CheckBox();
            _chkChartVar.CheckedChanged += new EventHandler(chkChartVar_CheckedChanged);
            CalcChartVar = new TabPage();
            _btnCalcChartVar = new Button();
            _btnCalcChartVar.Click += new EventHandler(btnCalcChartVar_Click);
            _btnClearChartVar = new Button();
            _btnClearChartVar.Click += new EventHandler(btnClearChartVar_Click);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            Frame1.SuspendLayout();
            _CalcControl.SuspendLayout();
            CalcTVMDC.SuspendLayout();
            CalcChartVar.SuspendLayout();
            SuspendLayout();
            // 
            // cmdPrint
            // 
            _cmdPrint.BackColor = SystemColors.Control;
            _cmdPrint.Cursor = Cursors.Default;
            _cmdPrint.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdPrint.ForeColor = SystemColors.ControlText;
            _cmdPrint.Image = (Image)resources.GetObject("cmdPrint.Image");
            _cmdPrint.Location = new Point(491, 3);
            _cmdPrint.Name = "_cmdPrint";
            _cmdPrint.RightToLeft = RightToLeft.No;
            _cmdPrint.Size = new Size(21, 21);
            _cmdPrint.TabIndex = 41;
            _cmdPrint.TextAlign = ContentAlignment.BottomCenter;
            ToolTip1.SetToolTip(_cmdPrint, "Print window");
            _cmdPrint.UseVisualStyleBackColor = false;
            // 
            // txtYI
            // 
            _txtYI.AcceptsReturn = true;
            _txtYI.BackColor = SystemColors.Window;
            _txtYI.Cursor = Cursors.IBeam;
            _txtYI.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtYI.ForeColor = SystemColors.WindowText;
            _txtYI.Location = new Point(170, 132);
            _txtYI.MaxLength = 4;
            _txtYI.Name = "_txtYI";
            _txtYI.RightToLeft = RightToLeft.No;
            _txtYI.Size = new Size(33, 20);
            _txtYI.TabIndex = 31;
            ToolTip1.SetToolTip(_txtYI, "Limited to 4 digits");
            // 
            // txtChange
            // 
            _txtChange.AcceptsReturn = true;
            _txtChange.BackColor = SystemColors.Window;
            _txtChange.Cursor = Cursors.IBeam;
            _txtChange.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtChange.ForeColor = SystemColors.WindowText;
            _txtChange.Location = new Point(214, 108);
            _txtChange.MaxLength = 0;
            _txtChange.Name = "_txtChange";
            _txtChange.RightToLeft = RightToLeft.No;
            _txtChange.Size = new Size(25, 20);
            _txtChange.TabIndex = 24;
            ToolTip1.SetToolTip(_txtChange, "Range 0 to 59");
            // 
            // txtCY
            // 
            _txtCY.AcceptsReturn = true;
            _txtCY.BackColor = SystemColors.Window;
            _txtCY.Cursor = Cursors.IBeam;
            _txtCY.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtCY.ForeColor = SystemColors.WindowText;
            _txtCY.Location = new Point(170, 57);
            _txtCY.MaxLength = 4;
            _txtCY.Name = "_txtCY";
            _txtCY.RightToLeft = RightToLeft.No;
            _txtCY.Size = new Size(33, 20);
            _txtCY.TabIndex = 22;
            ToolTip1.SetToolTip(_txtCY, "Limited to 4 digits");
            // 
            // txtCVMin
            // 
            _txtCVMin.AcceptsReturn = true;
            _txtCVMin.BackColor = SystemColors.Window;
            _txtCVMin.Cursor = Cursors.IBeam;
            _txtCVMin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtCVMin.ForeColor = SystemColors.WindowText;
            _txtCVMin.Location = new Point(214, 84);
            _txtCVMin.MaxLength = 2;
            _txtCVMin.Name = "_txtCVMin";
            _txtCVMin.RightToLeft = RightToLeft.No;
            _txtCVMin.Size = new Size(25, 20);
            _txtCVMin.TabIndex = 19;
            ToolTip1.SetToolTip(_txtCVMin, "Range 0 to 59");
            // 
            // txtCVDeg
            // 
            _txtCVDeg.AcceptsReturn = true;
            _txtCVDeg.BackColor = SystemColors.Window;
            _txtCVDeg.Cursor = Cursors.IBeam;
            _txtCVDeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtCVDeg.ForeColor = SystemColors.WindowText;
            _txtCVDeg.Location = new Point(170, 83);
            _txtCVDeg.MaxLength = 2;
            _txtCVDeg.Name = "_txtCVDeg";
            _txtCVDeg.RightToLeft = RightToLeft.No;
            _txtCVDeg.Size = new Size(33, 20);
            _txtCVDeg.TabIndex = 17;
            ToolTip1.SetToolTip(_txtCVDeg, "Range 0 to 99");
            // 
            // txtCompass
            // 
            _txtCompass.AcceptsReturn = true;
            _txtCompass.BackColor = SystemColors.Window;
            _txtCompass.Cursor = Cursors.IBeam;
            _txtCompass.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtCompass.ForeColor = SystemColors.WindowText;
            _txtCompass.Location = new Point(191, 183);
            _txtCompass.MaxLength = 3;
            _txtCompass.Name = "_txtCompass";
            _txtCompass.RightToLeft = RightToLeft.No;
            _txtCompass.Size = new Size(33, 20);
            _txtCompass.TabIndex = 9;
            ToolTip1.SetToolTip(_txtCompass, "Range 0 to 359");
            // 
            // txtDeviation
            // 
            _txtDeviation.AcceptsReturn = true;
            _txtDeviation.BackColor = SystemColors.Window;
            _txtDeviation.Cursor = Cursors.IBeam;
            _txtDeviation.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtDeviation.ForeColor = SystemColors.WindowText;
            _txtDeviation.Location = new Point(191, 159);
            _txtDeviation.MaxLength = 1;
            _txtDeviation.Name = "_txtDeviation";
            _txtDeviation.RightToLeft = RightToLeft.No;
            _txtDeviation.Size = new Size(33, 20);
            _txtDeviation.TabIndex = 8;
            ToolTip1.SetToolTip(_txtDeviation, "Range 0 to 9");
            // 
            // txtMagnetic
            // 
            _txtMagnetic.AcceptsReturn = true;
            _txtMagnetic.BackColor = SystemColors.Window;
            _txtMagnetic.Cursor = Cursors.IBeam;
            _txtMagnetic.Enabled = false;
            _txtMagnetic.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtMagnetic.ForeColor = SystemColors.WindowText;
            _txtMagnetic.Location = new Point(191, 135);
            _txtMagnetic.MaxLength = 3;
            _txtMagnetic.Name = "_txtMagnetic";
            _txtMagnetic.RightToLeft = RightToLeft.No;
            _txtMagnetic.Size = new Size(33, 20);
            _txtMagnetic.TabIndex = 7;
            ToolTip1.SetToolTip(_txtMagnetic, "Range 0 to 359");
            // 
            // txtVariation
            // 
            _txtVariation.AcceptsReturn = true;
            _txtVariation.BackColor = SystemColors.Window;
            _txtVariation.Cursor = Cursors.IBeam;
            _txtVariation.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtVariation.ForeColor = SystemColors.WindowText;
            _txtVariation.Location = new Point(191, 111);
            _txtVariation.MaxLength = 2;
            _txtVariation.Name = "_txtVariation";
            _txtVariation.RightToLeft = RightToLeft.No;
            _txtVariation.Size = new Size(33, 20);
            _txtVariation.TabIndex = 6;
            ToolTip1.SetToolTip(_txtVariation, "Range 0 to 99");
            // 
            // txtTrue
            // 
            _txtTrue.AcceptsReturn = true;
            _txtTrue.BackColor = SystemColors.Window;
            _txtTrue.Cursor = Cursors.IBeam;
            _txtTrue.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtTrue.ForeColor = SystemColors.WindowText;
            _txtTrue.Location = new Point(191, 87);
            _txtTrue.MaxLength = 3;
            _txtTrue.Name = "_txtTrue";
            _txtTrue.RightToLeft = RightToLeft.No;
            _txtTrue.Size = new Size(33, 20);
            _txtTrue.TabIndex = 5;
            ToolTip1.SetToolTip(_txtTrue, "Range 0 to 359");
            // 
            // btnCalcTVMDC
            // 
            _btnCalcTVMDC.BackColor = Color.Blue;
            _btnCalcTVMDC.Cursor = Cursors.Default;
            _btnCalcTVMDC.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnCalcTVMDC.ForeColor = Color.White;
            _btnCalcTVMDC.Location = new Point(138, 220);
            _btnCalcTVMDC.Name = "_btnCalcTVMDC";
            _btnCalcTVMDC.RightToLeft = RightToLeft.No;
            _btnCalcTVMDC.Size = new Size(140, 25);
            _btnCalcTVMDC.TabIndex = 104;
            _btnCalcTVMDC.Text = "Calculate TVMDC";
            ToolTip1.SetToolTip(_btnCalcTVMDC, "You can click this button anytime" + '\r' + '\n' + "to see the results of your data entered");
            _btnCalcTVMDC.UseVisualStyleBackColor = false;
            // 
            // cmdClear
            // 
            _cmdClear.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(192)));
            _cmdClear.Cursor = Cursors.Default;
            _cmdClear.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdClear.ForeColor = SystemColors.ControlText;
            _cmdClear.Location = new Point(138, 265);
            _cmdClear.Name = "_cmdClear";
            _cmdClear.RightToLeft = RightToLeft.No;
            _cmdClear.Size = new Size(140, 25);
            _cmdClear.TabIndex = 40;
            _cmdClear.Text = "Clear TVMDC Input Fields";
            _cmdClear.UseVisualStyleBackColor = false;
            // 
            // txtEW
            // 
            txtEW.AcceptsReturn = true;
            txtEW.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            txtEW.Cursor = Cursors.IBeam;
            txtEW.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtEW.ForeColor = SystemColors.WindowText;
            txtEW.Location = new Point(328, 162);
            txtEW.MaxLength = 0;
            txtEW.Name = "txtEW";
            txtEW.ReadOnly = true;
            txtEW.RightToLeft = RightToLeft.No;
            txtEW.Size = new Size(17, 20);
            txtEW.TabIndex = 35;
            // 
            // txtCorrVar
            // 
            txtCorrVar.AcceptsReturn = true;
            txtCorrVar.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            txtCorrVar.Cursor = Cursors.IBeam;
            txtCorrVar.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtCorrVar.ForeColor = SystemColors.WindowText;
            txtCorrVar.Location = new Point(279, 162);
            txtCorrVar.MaxLength = 0;
            txtCorrVar.Name = "txtCorrVar";
            txtCorrVar.ReadOnly = true;
            txtCorrVar.RightToLeft = RightToLeft.No;
            txtCorrVar.Size = new Size(33, 20);
            txtCorrVar.TabIndex = 33;
            // 
            // cboCV
            // 
            _cboCV.BackColor = SystemColors.Window;
            _cboCV.Cursor = Cursors.Default;
            _cboCV.DropDownStyle = ComboBoxStyle.DropDownList;
            _cboCV.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboCV.ForeColor = SystemColors.WindowText;
            _cboCV.Items.AddRange(new object[] { "W", "E" });
            _cboCV.Location = new Point(249, 84);
            _cboCV.Name = "_cboCV";
            _cboCV.RightToLeft = RightToLeft.No;
            _cboCV.Size = new Size(41, 22);
            _cboCV.TabIndex = 29;
            // 
            // cboD
            // 
            _cboD.BackColor = SystemColors.Window;
            _cboD.Cursor = Cursors.Default;
            _cboD.DropDownStyle = ComboBoxStyle.DropDownList;
            _cboD.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboD.ForeColor = SystemColors.WindowText;
            _cboD.Items.AddRange(new object[] { "W", "E" });
            _cboD.Location = new Point(234, 159);
            _cboD.Name = "_cboD";
            _cboD.RightToLeft = RightToLeft.No;
            _cboD.Size = new Size(41, 22);
            _cboD.TabIndex = 28;
            // 
            // cboV
            // 
            _cboV.BackColor = SystemColors.Window;
            _cboV.Cursor = Cursors.Default;
            _cboV.DropDownStyle = ComboBoxStyle.DropDownList;
            _cboV.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboV.ForeColor = SystemColors.WindowText;
            _cboV.Items.AddRange(new object[] { "W", "E" });
            _cboV.Location = new Point(234, 111);
            _cboV.Name = "_cboV";
            _cboV.RightToLeft = RightToLeft.No;
            _cboV.Size = new Size(41, 22);
            _cboV.TabIndex = 27;
            // 
            // cboIncDec
            // 
            _cboIncDec.BackColor = SystemColors.Window;
            _cboIncDec.Cursor = Cursors.Default;
            _cboIncDec.DropDownStyle = ComboBoxStyle.DropDownList;
            _cboIncDec.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboIncDec.ForeColor = SystemColors.WindowText;
            _cboIncDec.Items.AddRange(new object[] { "Increasing", "Decreasing" });
            _cboIncDec.Location = new Point(249, 108);
            _cboIncDec.Name = "_cboIncDec";
            _cboIncDec.RightToLeft = RightToLeft.No;
            _cboIncDec.Size = new Size(81, 22);
            _cboIncDec.TabIndex = 26;
            // 
            // Label15
            // 
            Label15.BackColor = SystemColors.Window;
            Label15.Cursor = Cursors.Default;
            Label15.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label15.ForeColor = SystemColors.ControlText;
            Label15.Location = new Point(313, 160);
            Label15.Name = "Label15";
            Label15.RightToLeft = RightToLeft.No;
            Label15.Size = new Size(9, 17);
            Label15.TabIndex = 34;
            Label15.Text = "°";
            // 
            // Label14
            // 
            Label14.BackColor = SystemColors.Window;
            Label14.Cursor = Cursors.Default;
            Label14.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label14.ForeColor = SystemColors.ControlText;
            Label14.Location = new Point(85, 158);
            Label14.Name = "Label14";
            Label14.RightToLeft = RightToLeft.No;
            Label14.Size = new Size(190, 28);
            Label14.TabIndex = 32;
            Label14.Text = "Variation Corrected to Year of Interest" + '\r' + '\n' + "(rounded to whole degrees)";
            Label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label13
            // 
            Label13.BackColor = SystemColors.Window;
            Label13.Cursor = Cursors.Default;
            Label13.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label13.ForeColor = SystemColors.ControlText;
            Label13.Location = new Point(82, 132);
            Label13.Name = "Label13";
            Label13.RightToLeft = RightToLeft.No;
            Label13.Size = new Size(90, 19);
            Label13.TabIndex = 30;
            Label13.Text = "Year of Interest";
            Label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label12
            // 
            Label12.BackColor = SystemColors.Window;
            Label12.Cursor = Cursors.Default;
            Label12.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label12.ForeColor = SystemColors.ControlText;
            Label12.Location = new Point(239, 108);
            Label12.Name = "Label12";
            Label12.RightToLeft = RightToLeft.No;
            Label12.Size = new Size(9, 17);
            Label12.TabIndex = 25;
            Label12.Text = "'";
            // 
            // Label11
            // 
            Label11.BackColor = SystemColors.Window;
            Label11.Cursor = Cursors.Default;
            Label11.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label11.ForeColor = SystemColors.ControlText;
            Label11.Location = new Point(82, 108);
            Label11.Name = "Label11";
            Label11.RightToLeft = RightToLeft.No;
            Label11.Size = new Size(81, 17);
            Label11.TabIndex = 23;
            Label11.Text = "Annual Change";
            Label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label10
            // 
            Label10.BackColor = SystemColors.Window;
            Label10.Cursor = Cursors.Default;
            Label10.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label10.ForeColor = SystemColors.ControlText;
            Label10.Location = new Point(85, 59);
            Label10.Name = "Label10";
            Label10.RightToLeft = RightToLeft.No;
            Label10.Size = new Size(80, 18);
            Label10.TabIndex = 21;
            Label10.Text = "Chart Year";
            Label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label9
            // 
            Label9.BackColor = SystemColors.Window;
            Label9.Cursor = Cursors.Default;
            Label9.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label9.ForeColor = SystemColors.ControlText;
            Label9.Location = new Point(239, 84);
            Label9.Name = "Label9";
            Label9.RightToLeft = RightToLeft.No;
            Label9.Size = new Size(9, 17);
            Label9.TabIndex = 20;
            Label9.Text = "'";
            // 
            // Label8
            // 
            Label8.BackColor = SystemColors.Window;
            Label8.Cursor = Cursors.Default;
            Label8.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label8.ForeColor = SystemColors.ControlText;
            Label8.Location = new Point(204, 84);
            Label8.Name = "Label8";
            Label8.RightToLeft = RightToLeft.No;
            Label8.Size = new Size(9, 17);
            Label8.TabIndex = 18;
            Label8.Text = "°";
            // 
            // Label7
            // 
            Label7.BackColor = SystemColors.Window;
            Label7.Cursor = Cursors.Default;
            Label7.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label7.ForeColor = SystemColors.ControlText;
            Label7.Location = new Point(82, 85);
            Label7.Name = "Label7";
            Label7.RightToLeft = RightToLeft.No;
            Label7.Size = new Size(80, 17);
            Label7.TabIndex = 16;
            Label7.Text = "Chart Variation";
            Label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label6
            // 
            Label6.BackColor = SystemColors.Window;
            Label6.Cursor = Cursors.Default;
            Label6.Font = new Font("Tahoma", 8.25f, FontStyle.Underline, GraphicsUnit.Point, Conversions.ToByte(0));
            Label6.ForeColor = SystemColors.ControlText;
            Label6.Location = new Point(114, 27);
            Label6.Name = "Label6";
            Label6.RightToLeft = RightToLeft.No;
            Label6.Size = new Size(200, 17);
            Label6.TabIndex = 15;
            Label6.Text = "Calculate Corrected Chart Variation";
            Label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label5
            // 
            Label5.BackColor = SystemColors.Window;
            Label5.Cursor = Cursors.Default;
            Label5.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label5.ForeColor = SystemColors.ControlText;
            Label5.Location = new Point(224, 183);
            Label5.Name = "Label5";
            Label5.RightToLeft = RightToLeft.No;
            Label5.Size = new Size(9, 17);
            Label5.TabIndex = 14;
            Label5.Text = "°";
            // 
            // Label4
            // 
            Label4.BackColor = SystemColors.Window;
            Label4.Cursor = Cursors.Default;
            Label4.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.ForeColor = SystemColors.ControlText;
            Label4.Location = new Point(224, 159);
            Label4.Name = "Label4";
            Label4.RightToLeft = RightToLeft.No;
            Label4.Size = new Size(9, 17);
            Label4.TabIndex = 13;
            Label4.Text = "°";
            // 
            // Label3
            // 
            Label3.BackColor = SystemColors.Window;
            Label3.Cursor = Cursors.Default;
            Label3.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.ForeColor = SystemColors.ControlText;
            Label3.Location = new Point(224, 135);
            Label3.Name = "Label3";
            Label3.RightToLeft = RightToLeft.No;
            Label3.Size = new Size(9, 17);
            Label3.TabIndex = 12;
            Label3.Text = "°";
            // 
            // Label2
            // 
            Label2.BackColor = SystemColors.Window;
            Label2.Cursor = Cursors.Default;
            Label2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = SystemColors.ControlText;
            Label2.Location = new Point(224, 111);
            Label2.Name = "Label2";
            Label2.RightToLeft = RightToLeft.No;
            Label2.Size = new Size(9, 17);
            Label2.TabIndex = 11;
            Label2.Text = "°";
            // 
            // Label1
            // 
            Label1.BackColor = SystemColors.Window;
            Label1.Cursor = Cursors.Default;
            Label1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = SystemColors.ControlText;
            Label1.Location = new Point(224, 87);
            Label1.Name = "Label1";
            Label1.RightToLeft = RightToLeft.No;
            Label1.Size = new Size(9, 17);
            Label1.TabIndex = 10;
            Label1.Text = "°";
            // 
            // lblCompass
            // 
            lblCompass.BackColor = SystemColors.Window;
            lblCompass.Cursor = Cursors.Default;
            lblCompass.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblCompass.ForeColor = SystemColors.ControlText;
            lblCompass.Location = new Point(135, 185);
            lblCompass.Name = "lblCompass";
            lblCompass.RightToLeft = RightToLeft.No;
            lblCompass.Size = new Size(53, 17);
            lblCompass.TabIndex = 4;
            lblCompass.Text = "Compass";
            lblCompass.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDeviation
            // 
            lblDeviation.BackColor = SystemColors.Window;
            lblDeviation.Cursor = Cursors.Default;
            lblDeviation.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblDeviation.ForeColor = SystemColors.ControlText;
            lblDeviation.Location = new Point(129, 159);
            lblDeviation.Name = "lblDeviation";
            lblDeviation.RightToLeft = RightToLeft.No;
            lblDeviation.Size = new Size(66, 20);
            lblDeviation.TabIndex = 3;
            lblDeviation.Text = "Deviation";
            lblDeviation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMagnetic
            // 
            lblMagnetic.BackColor = SystemColors.Window;
            lblMagnetic.Cursor = Cursors.Default;
            lblMagnetic.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblMagnetic.ForeColor = SystemColors.ControlText;
            lblMagnetic.Location = new Point(130, 135);
            lblMagnetic.Name = "lblMagnetic";
            lblMagnetic.RightToLeft = RightToLeft.No;
            lblMagnetic.Size = new Size(58, 20);
            lblMagnetic.TabIndex = 2;
            lblMagnetic.Text = "Magnetic";
            lblMagnetic.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblVariation
            // 
            lblVariation.BackColor = SystemColors.Window;
            lblVariation.Cursor = Cursors.Default;
            lblVariation.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblVariation.ForeColor = SystemColors.ControlText;
            lblVariation.Location = new Point(136, 113);
            lblVariation.Name = "lblVariation";
            lblVariation.RightToLeft = RightToLeft.No;
            lblVariation.Size = new Size(49, 17);
            lblVariation.TabIndex = 1;
            lblVariation.Text = "Variation";
            lblVariation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTrue
            // 
            lblTrue.BackColor = SystemColors.Window;
            lblTrue.Cursor = Cursors.Default;
            lblTrue.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblTrue.ForeColor = SystemColors.ControlText;
            lblTrue.Location = new Point(136, 87);
            lblTrue.Name = "lblTrue";
            lblTrue.RightToLeft = RightToLeft.No;
            lblTrue.Size = new Size(31, 20);
            lblTrue.TabIndex = 0;
            lblTrue.Text = "True";
            lblTrue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ExitBtn
            // 
            _ExitBtn.BackColor = Color.Red;
            _ExitBtn.Cursor = Cursors.Default;
            _ExitBtn.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _ExitBtn.ForeColor = SystemColors.ControlLightLight;
            _ExitBtn.Location = new Point(441, 380);
            _ExitBtn.Name = "_ExitBtn";
            _ExitBtn.RightToLeft = RightToLeft.No;
            _ExitBtn.Size = new Size(65, 25);
            _ExitBtn.TabIndex = 43;
            _ExitBtn.Text = "Exit";
            _ExitBtn.UseVisualStyleBackColor = false;
            // 
            // chkDev
            // 
            _chkDev.BackColor = SystemColors.Window;
            _chkDev.Cursor = Cursors.Default;
            _chkDev.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _chkDev.ForeColor = SystemColors.ControlText;
            _chkDev.Location = new Point(285, 158);
            _chkDev.Name = "_chkDev";
            _chkDev.RightToLeft = RightToLeft.No;
            _chkDev.Size = new Size(160, 25);
            _chkDev.TabIndex = 45;
            _chkDev.Text = "Use Saved Deviation Table";
            _chkDev.UseVisualStyleBackColor = false;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.ABC_white;
            PictureBox1.Location = new Point(110, 355);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(316, 50);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 102;
            PictureBox1.TabStop = false;
            // 
            // Label16
            // 
            Label16.BackColor = SystemColors.Window;
            Label16.Cursor = Cursors.Default;
            Label16.Font = new Font("Tahoma", 8.25f, FontStyle.Underline, GraphicsUnit.Point, Conversions.ToByte(0));
            Label16.ForeColor = SystemColors.ControlText;
            Label16.Location = new Point(123, 6);
            Label16.Name = "Label16";
            Label16.RightToLeft = RightToLeft.No;
            Label16.Size = new Size(200, 22);
            Label16.TabIndex = 103;
            Label16.Text = "Calculate TVMDC";
            Label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DirectionLbl
            // 
            DirectionLbl.BackColor = SystemColors.Window;
            DirectionLbl.Cursor = Cursors.Default;
            DirectionLbl.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DirectionLbl.ForeColor = SystemColors.ControlText;
            DirectionLbl.Location = new Point(6, 8);
            DirectionLbl.Name = "DirectionLbl";
            DirectionLbl.RightToLeft = RightToLeft.No;
            DirectionLbl.Size = new Size(60, 20);
            DirectionLbl.TabIndex = 44;
            DirectionLbl.Text = "Direction";
            DirectionLbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // optDown
            // 
            _optDown.BackColor = SystemColors.Window;
            _optDown.Checked = true;
            _optDown.Cursor = Cursors.Default;
            _optDown.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optDown.ForeColor = SystemColors.ControlText;
            _optDown.Location = new Point(70, 5);
            _optDown.Name = "_optDown";
            _optDown.RightToLeft = RightToLeft.No;
            _optDown.Size = new Size(136, 19);
            _optDown.TabIndex = 38;
            _optDown.TabStop = true;
            _optDown.Text = "DOWN / Calc Compass";
            _optDown.UseVisualStyleBackColor = false;
            // 
            // optUp
            // 
            _optUp.BackColor = SystemColors.Window;
            _optUp.Cursor = Cursors.Default;
            _optUp.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optUp.ForeColor = SystemColors.ControlText;
            _optUp.Location = new Point(70, 25);
            _optUp.Name = "_optUp";
            _optUp.RightToLeft = RightToLeft.No;
            _optUp.Size = new Size(122, 20);
            _optUp.TabIndex = 39;
            _optUp.TabStop = true;
            _optUp.Text = "UP / Calc True";
            _optUp.UseVisualStyleBackColor = false;
            // 
            // Frame1
            // 
            Frame1.BackColor = SystemColors.Window;
            Frame1.Controls.Add(_optUp);
            Frame1.Controls.Add(_optDown);
            Frame1.Controls.Add(DirectionLbl);
            Frame1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Frame1.ForeColor = SystemColors.ControlText;
            Frame1.Location = new Point(114, 26);
            Frame1.Name = "Frame1";
            Frame1.Padding = new Padding(0);
            Frame1.RightToLeft = RightToLeft.No;
            Frame1.Size = new Size(212, 55);
            Frame1.TabIndex = 37;
            Frame1.TabStop = false;
            Frame1.Text = " ";
            // 
            // CalcControl
            // 
            _CalcControl.Controls.Add(CalcTVMDC);
            _CalcControl.Controls.Add(CalcChartVar);
            _CalcControl.Location = new Point(32, 12);
            _CalcControl.Name = "_CalcControl";
            _CalcControl.SelectedIndex = 0;
            _CalcControl.Size = new Size(456, 337);
            _CalcControl.TabIndex = 104;
            // 
            // CalcTVMDC
            // 
            CalcTVMDC.Controls.Add(_chkChartVar);
            CalcTVMDC.Controls.Add(_btnCalcTVMDC);
            CalcTVMDC.Controls.Add(_txtDeviation);
            CalcTVMDC.Controls.Add(Label16);
            CalcTVMDC.Controls.Add(Frame1);
            CalcTVMDC.Controls.Add(lblTrue);
            CalcTVMDC.Controls.Add(_chkDev);
            CalcTVMDC.Controls.Add(lblVariation);
            CalcTVMDC.Controls.Add(lblMagnetic);
            CalcTVMDC.Controls.Add(lblDeviation);
            CalcTVMDC.Controls.Add(_cmdClear);
            CalcTVMDC.Controls.Add(lblCompass);
            CalcTVMDC.Controls.Add(Label1);
            CalcTVMDC.Controls.Add(Label2);
            CalcTVMDC.Controls.Add(Label3);
            CalcTVMDC.Controls.Add(Label4);
            CalcTVMDC.Controls.Add(_cboD);
            CalcTVMDC.Controls.Add(Label5);
            CalcTVMDC.Controls.Add(_cboV);
            CalcTVMDC.Controls.Add(_txtTrue);
            CalcTVMDC.Controls.Add(_txtVariation);
            CalcTVMDC.Controls.Add(_txtMagnetic);
            CalcTVMDC.Controls.Add(_txtCompass);
            CalcTVMDC.Location = new Point(4, 22);
            CalcTVMDC.Name = "CalcTVMDC";
            CalcTVMDC.Padding = new Padding(3);
            CalcTVMDC.Size = new Size(448, 311);
            CalcTVMDC.TabIndex = 0;
            CalcTVMDC.Text = "Calculate TVMDC";
            CalcTVMDC.UseVisualStyleBackColor = true;
            // 
            // chkChartVar
            // 
            _chkChartVar.BackColor = SystemColors.Window;
            _chkChartVar.Cursor = Cursors.Default;
            _chkChartVar.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _chkChartVar.ForeColor = SystemColors.ControlText;
            _chkChartVar.Location = new Point(285, 110);
            _chkChartVar.Name = "_chkChartVar";
            _chkChartVar.RightToLeft = RightToLeft.No;
            _chkChartVar.Size = new Size(151, 25);
            _chkChartVar.TabIndex = 105;
            _chkChartVar.Text = "Use Calc'd Chart Variation";
            _chkChartVar.UseVisualStyleBackColor = false;
            // 
            // CalcChartVar
            // 
            CalcChartVar.Controls.Add(_btnCalcChartVar);
            CalcChartVar.Controls.Add(_btnClearChartVar);
            CalcChartVar.Controls.Add(Label6);
            CalcChartVar.Controls.Add(Label7);
            CalcChartVar.Controls.Add(Label8);
            CalcChartVar.Controls.Add(Label9);
            CalcChartVar.Controls.Add(txtEW);
            CalcChartVar.Controls.Add(Label10);
            CalcChartVar.Controls.Add(txtCorrVar);
            CalcChartVar.Controls.Add(Label11);
            CalcChartVar.Controls.Add(_txtYI);
            CalcChartVar.Controls.Add(Label12);
            CalcChartVar.Controls.Add(_cboCV);
            CalcChartVar.Controls.Add(Label13);
            CalcChartVar.Controls.Add(_cboIncDec);
            CalcChartVar.Controls.Add(Label14);
            CalcChartVar.Controls.Add(_txtChange);
            CalcChartVar.Controls.Add(Label15);
            CalcChartVar.Controls.Add(_txtCY);
            CalcChartVar.Controls.Add(_txtCVDeg);
            CalcChartVar.Controls.Add(_txtCVMin);
            CalcChartVar.Location = new Point(4, 22);
            CalcChartVar.Name = "CalcChartVar";
            CalcChartVar.Padding = new Padding(3);
            CalcChartVar.Size = new Size(448, 311);
            CalcChartVar.TabIndex = 1;
            CalcChartVar.Text = "Calculate Chart Variation";
            CalcChartVar.UseVisualStyleBackColor = true;
            // 
            // btnCalcChartVar
            // 
            _btnCalcChartVar.BackColor = Color.Blue;
            _btnCalcChartVar.Cursor = Cursors.Default;
            _btnCalcChartVar.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnCalcChartVar.ForeColor = Color.White;
            _btnCalcChartVar.Location = new Point(150, 212);
            _btnCalcChartVar.Name = "_btnCalcChartVar";
            _btnCalcChartVar.RightToLeft = RightToLeft.No;
            _btnCalcChartVar.Size = new Size(140, 25);
            _btnCalcChartVar.TabIndex = 106;
            _btnCalcChartVar.Text = "Calculate Chart Variation";
            _btnCalcChartVar.UseVisualStyleBackColor = false;
            // 
            // btnClearChartVar
            // 
            _btnClearChartVar.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(192)));
            _btnClearChartVar.Cursor = Cursors.Default;
            _btnClearChartVar.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnClearChartVar.ForeColor = SystemColors.ControlText;
            _btnClearChartVar.Location = new Point(150, 257);
            _btnClearChartVar.Name = "_btnClearChartVar";
            _btnClearChartVar.RightToLeft = RightToLeft.No;
            _btnClearChartVar.Size = new Size(140, 25);
            _btnClearChartVar.TabIndex = 105;
            _btnClearChartVar.Text = "Clear Chart Var Fields";
            _btnClearChartVar.UseVisualStyleBackColor = false;
            // 
            // FormTVMDC
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(524, 426);
            Controls.Add(_CalcControl);
            Controls.Add(PictureBox1);
            Controls.Add(_ExitBtn);
            Controls.Add(_cmdPrint);
            Cursor = Cursors.Default;
            Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(3, 29);
            MaximizeBox = false;
            Name = "FormTVMDC";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TVMDC";
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Frame1.ResumeLayout(false);
            _CalcControl.ResumeLayout(false);
            CalcTVMDC.ResumeLayout(false);
            CalcTVMDC.PerformLayout();
            CalcChartVar.ResumeLayout(false);
            CalcChartVar.PerformLayout();
            Load += new EventHandler(FormTVMDC_Load);
            FormClosed += new FormClosedEventHandler(FormTVMDC_FormClosed);
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

        private CheckBox _chkDev;

        public CheckBox chkDev
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _chkDev;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_chkDev != null)
                {
                    _chkDev.CheckedChanged -= chkDev_CheckedChanged;
                }

                _chkDev = value;
                if (_chkDev != null)
                {
                    _chkDev.CheckedChanged += chkDev_CheckedChanged;
                }
            }
        }

        internal PictureBox PictureBox1;
        public Label Label16;
        public Label DirectionLbl;
        private RadioButton _optDown;

        public RadioButton optDown
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optDown;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optDown != null)
                {
                    _optDown.CheckedChanged -= optDown_CheckedChanged;
                }

                _optDown = value;
                if (_optDown != null)
                {
                    _optDown.CheckedChanged += optDown_CheckedChanged;
                }
            }
        }

        private RadioButton _optUp;

        public RadioButton optUp
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optUp;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optUp != null)
                {
                    _optUp.CheckedChanged -= optUp_CheckedChanged;
                }

                _optUp = value;
                if (_optUp != null)
                {
                    _optUp.CheckedChanged += optUp_CheckedChanged;
                }
            }
        }

        public GroupBox Frame1;
        private TabControl _CalcControl;

        internal TabControl CalcControl
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CalcControl;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CalcControl != null)
                {
                    _CalcControl.SelectedIndexChanged -= CalcControl_SelectedIndexChanged;
                }

                _CalcControl = value;
                if (_CalcControl != null)
                {
                    _CalcControl.SelectedIndexChanged += CalcControl_SelectedIndexChanged;
                }
            }
        }

        internal TabPage CalcTVMDC;
        internal TabPage CalcChartVar;
        private Button _btnCalcTVMDC;

        public Button btnCalcTVMDC
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnCalcTVMDC;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnCalcTVMDC != null)
                {
                    _btnCalcTVMDC.Click -= btnCalcTVMDC_Click;
                }

                _btnCalcTVMDC = value;
                if (_btnCalcTVMDC != null)
                {
                    _btnCalcTVMDC.Click += btnCalcTVMDC_Click;
                }
            }
        }

        private Button _btnCalcChartVar;

        public Button btnCalcChartVar
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnCalcChartVar;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnCalcChartVar != null)
                {
                    _btnCalcChartVar.Click -= btnCalcChartVar_Click;
                }

                _btnCalcChartVar = value;
                if (_btnCalcChartVar != null)
                {
                    _btnCalcChartVar.Click += btnCalcChartVar_Click;
                }
            }
        }

        private Button _btnClearChartVar;

        public Button btnClearChartVar
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnClearChartVar;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnClearChartVar != null)
                {
                    _btnClearChartVar.Click -= btnClearChartVar_Click;
                }

                _btnClearChartVar = value;
                if (_btnClearChartVar != null)
                {
                    _btnClearChartVar.Click += btnClearChartVar_Click;
                }
            }
        }

        private CheckBox _chkChartVar;

        public CheckBox chkChartVar
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _chkChartVar;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_chkChartVar != null)
                {
                    _chkChartVar.CheckedChanged -= chkChartVar_CheckedChanged;
                }

                _chkChartVar = value;
                if (_chkChartVar != null)
                {
                    _chkChartVar.CheckedChanged += chkChartVar_CheckedChanged;
                }
            }
        }
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}