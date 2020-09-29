using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    [DesignerGenerated()]
    internal partial class FormTides
    {
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        [DebuggerNonUserCode()]
        public FormTides() : base()
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
        private Button _cmdVertical;

        public Button cmdVertical
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdVertical;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdVertical != null)
                {
                    _cmdVertical.Click -= cmdVertical_Click;
                }

                _cmdVertical = value;
                if (_cmdVertical != null)
                {
                    _cmdVertical.Click += cmdVertical_Click;
                }
            }
        }

        private RadioButton _optAltRule;

        public RadioButton optAltRule
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optAltRule;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optAltRule != null)
                {
                    _optAltRule.CheckedChanged -= optAltRule_CheckedChanged;
                }

                _optAltRule = value;
                if (_optAltRule != null)
                {
                    _optAltRule.CheckedChanged += optAltRule_CheckedChanged;
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

        private RadioButton _optTable3;

        public RadioButton optTable3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optTable3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optTable3 != null)
                {
                    _optTable3.CheckedChanged -= optTable3_CheckedChanged;
                }

                _optTable3 = value;
                if (_optTable3 != null)
                {
                    _optTable3.CheckedChanged += optTable3_CheckedChanged;
                }
            }
        }

        public GroupBox Frame1;
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

        private TextBox _txtTab2HtLow;

        public TextBox txtTab2HtLow
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtTab2HtLow;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtTab2HtLow != null)
                {
                    _txtTab2HtLow.KeyPress -= txtTab2HtLow_KeyPress;
                    _txtTab2HtLow.Validating -= txtTab2HtLow_Validating;
                    _txtTab2HtLow.Enter -= txtTab2HtLow_Enter;
                }

                _txtTab2HtLow = value;
                if (_txtTab2HtLow != null)
                {
                    _txtTab2HtLow.KeyPress += txtTab2HtLow_KeyPress;
                    _txtTab2HtLow.Validating += txtTab2HtLow_Validating;
                    _txtTab2HtLow.Enter += txtTab2HtLow_Enter;
                }
            }
        }

        private TextBox _txtTab2LowMin;

        public TextBox txtTab2LowMin
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtTab2LowMin;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtTab2LowMin != null)
                {
                    _txtTab2LowMin.TextChanged -= txtTab2LowMin_TextChanged;
                    _txtTab2LowMin.KeyPress -= txtTab2LowMin_KeyPress;
                    _txtTab2LowMin.Validating -= txtTab2LowMin_Validating;
                    _txtTab2LowMin.Enter -= txtTab2LowMin_Enter;
                }

                _txtTab2LowMin = value;
                if (_txtTab2LowMin != null)
                {
                    _txtTab2LowMin.TextChanged += txtTab2LowMin_TextChanged;
                    _txtTab2LowMin.KeyPress += txtTab2LowMin_KeyPress;
                    _txtTab2LowMin.Validating += txtTab2LowMin_Validating;
                    _txtTab2LowMin.Enter += txtTab2LowMin_Enter;
                }
            }
        }

        private TextBox _txtTab2LowHour;

        public TextBox txtTab2LowHour
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtTab2LowHour;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtTab2LowHour != null)
                {
                    _txtTab2LowHour.TextChanged -= txtTab2LowHour_TextChanged;
                    _txtTab2LowHour.KeyPress -= txtTab2LowHour_KeyPress;
                    _txtTab2LowHour.Validating -= txtTab2LowHour_Validating;
                    _txtTab2LowHour.Enter -= txtTab2LowHour_Enter;
                }

                _txtTab2LowHour = value;
                if (_txtTab2LowHour != null)
                {
                    _txtTab2LowHour.TextChanged += txtTab2LowHour_TextChanged;
                    _txtTab2LowHour.KeyPress += txtTab2LowHour_KeyPress;
                    _txtTab2LowHour.Validating += txtTab2LowHour_Validating;
                    _txtTab2LowHour.Enter += txtTab2LowHour_Enter;
                }
            }
        }

        private TextBox _txtTab2HtHigh;

        public TextBox txtTab2HtHigh
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtTab2HtHigh;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtTab2HtHigh != null)
                {
                    _txtTab2HtHigh.KeyPress -= txtTab2HtHigh_KeyPress;
                    _txtTab2HtHigh.Validating -= txtTab2HtHigh_Validating;
                    _txtTab2HtHigh.Enter -= txtTab2HtHigh_Enter;
                }

                _txtTab2HtHigh = value;
                if (_txtTab2HtHigh != null)
                {
                    _txtTab2HtHigh.KeyPress += txtTab2HtHigh_KeyPress;
                    _txtTab2HtHigh.Validating += txtTab2HtHigh_Validating;
                    _txtTab2HtHigh.Enter += txtTab2HtHigh_Enter;
                }
            }
        }

        private TextBox _txtTab2HighMin;

        public TextBox txtTab2HighMin
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtTab2HighMin;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtTab2HighMin != null)
                {
                    _txtTab2HighMin.TextChanged -= txtTab2HighMin_TextChanged;
                    _txtTab2HighMin.KeyPress -= txtTab2HighMin_KeyPress;
                    _txtTab2HighMin.Validating -= txtTab2HighMin_Validating;
                    _txtTab2HighMin.Enter -= txtTab2HighMin_Enter;
                }

                _txtTab2HighMin = value;
                if (_txtTab2HighMin != null)
                {
                    _txtTab2HighMin.TextChanged += txtTab2HighMin_TextChanged;
                    _txtTab2HighMin.KeyPress += txtTab2HighMin_KeyPress;
                    _txtTab2HighMin.Validating += txtTab2HighMin_Validating;
                    _txtTab2HighMin.Enter += txtTab2HighMin_Enter;
                }
            }
        }

        private TextBox _txtTab2HighHour;

        public TextBox txtTab2HighHour
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtTab2HighHour;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtTab2HighHour != null)
                {
                    _txtTab2HighHour.TextChanged -= txtTab2HighHour_TextChanged;
                    _txtTab2HighHour.KeyPress -= txtTab2HighHour_KeyPress;
                    _txtTab2HighHour.Validating -= txtTab2HighHour_Validating;
                    _txtTab2HighHour.Enter -= txtTab2HighHour_Enter;
                }

                _txtTab2HighHour = value;
                if (_txtTab2HighHour != null)
                {
                    _txtTab2HighHour.TextChanged += txtTab2HighHour_TextChanged;
                    _txtTab2HighHour.KeyPress += txtTab2HighHour_KeyPress;
                    _txtTab2HighHour.Validating += txtTab2HighHour_Validating;
                    _txtTab2HighHour.Enter += txtTab2HighHour_Enter;
                }
            }
        }

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

        public TextBox txtTab2Diff;
        private TextBox _txtHtLow;

        public TextBox txtHtLow
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtHtLow;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtHtLow != null)
                {
                    _txtHtLow.KeyPress -= txtHtLow_KeyPress;
                    _txtHtLow.Validating -= txtHtLow_Validating;
                    _txtHtLow.Enter -= txtHtLow_Enter;
                }

                _txtHtLow = value;
                if (_txtHtLow != null)
                {
                    _txtHtLow.KeyPress += txtHtLow_KeyPress;
                    _txtHtLow.Validating += txtHtLow_Validating;
                    _txtHtLow.Enter += txtHtLow_Enter;
                }
            }
        }

        private TextBox _txtHtHigh;

        public TextBox txtHtHigh
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtHtHigh;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtHtHigh != null)
                {
                    _txtHtHigh.KeyPress -= txtHtHigh_KeyPress;
                    _txtHtHigh.Validating -= txtHtHigh_Validating;
                    _txtHtHigh.Enter -= txtHtHigh_Enter;
                }

                _txtHtHigh = value;
                if (_txtHtHigh != null)
                {
                    _txtHtHigh.KeyPress += txtHtHigh_KeyPress;
                    _txtHtHigh.Validating += txtHtHigh_Validating;
                    _txtHtHigh.Enter += txtHtHigh_Enter;
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
        // Public WithEvents Line10 As Microsoft.VisualBasic.PowerPacks.LineShape
        // Public WithEvents Line9 As Microsoft.VisualBasic.PowerPacks.LineShape
        // Public WithEvents Line8 As Microsoft.VisualBasic.PowerPacks.LineShape
        // Public WithEvents Line7 As Microsoft.VisualBasic.PowerPacks.LineShape
        // Public WithEvents Line6 As Microsoft.VisualBasic.PowerPacks.LineShape
        // Public WithEvents Line5 As Microsoft.VisualBasic.PowerPacks.LineShape
        // Public WithEvents Line4 As Microsoft.VisualBasic.PowerPacks.LineShape
        // Public WithEvents Line3 As Microsoft.VisualBasic.PowerPacks.LineShape
        // Public WithEvents Line2 As Microsoft.VisualBasic.PowerPacks.LineShape
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
        public Label Label5;
        public Label Label4;
        public Label Label3;
        public Label Label2;
        public Label Label1;
        public Label lblLocNumber;
        public Label lblLocation;
        // Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTides));
            ToolTip1 = new ToolTip(components);
            _cmdPrint = new Button();
            _cmdPrint.Click += new EventHandler(cmdPrint_Click);
            _txtTab2LowMin = new TextBox();
            _txtTab2LowMin.TextChanged += new EventHandler(txtTab2LowMin_TextChanged);
            _txtTab2LowMin.KeyPress += new KeyPressEventHandler(txtTab2LowMin_KeyPress);
            _txtTab2LowMin.Validating += new System.ComponentModel.CancelEventHandler(txtTab2LowMin_Validating);
            _txtTab2LowMin.Enter += new EventHandler(txtTab2LowMin_Enter);
            _txtTab2HighMin = new TextBox();
            _txtTab2HighMin.TextChanged += new EventHandler(txtTab2HighMin_TextChanged);
            _txtTab2HighMin.KeyPress += new KeyPressEventHandler(txtTab2HighMin_KeyPress);
            _txtTab2HighMin.Validating += new System.ComponentModel.CancelEventHandler(txtTab2HighMin_Validating);
            _txtTab2HighMin.Enter += new EventHandler(txtTab2HighMin_Enter);
            _cmdVertical = new Button();
            _cmdVertical.Click += new EventHandler(cmdVertical_Click);
            Frame1 = new GroupBox();
            _optAltRule = new RadioButton();
            _optAltRule.CheckedChanged += new EventHandler(optAltRule_CheckedChanged);
            _optRule = new RadioButton();
            _optRule.CheckedChanged += new EventHandler(optRule_CheckedChanged);
            _optCalc = new RadioButton();
            _optCalc.CheckedChanged += new EventHandler(optCalc_CheckedChanged);
            _optTable3 = new RadioButton();
            _optTable3.CheckedChanged += new EventHandler(optTable3_CheckedChanged);
            _cmdClear = new Button();
            _cmdClear.Click += new EventHandler(cmdClear_Click);
            _cmdTides = new Button();
            _cmdTides.Click += new EventHandler(cmdTides_Click);
            _txtTab2HtLow = new TextBox();
            _txtTab2HtLow.KeyPress += new KeyPressEventHandler(txtTab2HtLow_KeyPress);
            _txtTab2HtLow.Validating += new System.ComponentModel.CancelEventHandler(txtTab2HtLow_Validating);
            _txtTab2HtLow.Enter += new EventHandler(txtTab2HtLow_Enter);
            _txtTab2LowHour = new TextBox();
            _txtTab2LowHour.TextChanged += new EventHandler(txtTab2LowHour_TextChanged);
            _txtTab2LowHour.KeyPress += new KeyPressEventHandler(txtTab2LowHour_KeyPress);
            _txtTab2LowHour.Validating += new System.ComponentModel.CancelEventHandler(txtTab2LowHour_Validating);
            _txtTab2LowHour.Enter += new EventHandler(txtTab2LowHour_Enter);
            _txtTab2HtHigh = new TextBox();
            _txtTab2HtHigh.KeyPress += new KeyPressEventHandler(txtTab2HtHigh_KeyPress);
            _txtTab2HtHigh.Validating += new System.ComponentModel.CancelEventHandler(txtTab2HtHigh_Validating);
            _txtTab2HtHigh.Enter += new EventHandler(txtTab2HtHigh_Enter);
            _txtTab2HighHour = new TextBox();
            _txtTab2HighHour.TextChanged += new EventHandler(txtTab2HighHour_TextChanged);
            _txtTab2HighHour.KeyPress += new KeyPressEventHandler(txtTab2HighHour_KeyPress);
            _txtTab2HighHour.Validating += new System.ComponentModel.CancelEventHandler(txtTab2HighHour_Validating);
            _txtTab2HighHour.Enter += new EventHandler(txtTab2HighHour_Enter);
            _txtSubStaNo = new TextBox();
            _txtSubStaNo.KeyPress += new KeyPressEventHandler(txtSubStaNo_KeyPress);
            txtTab2Diff = new TextBox();
            _txtHtLow = new TextBox();
            _txtHtLow.KeyPress += new KeyPressEventHandler(txtHtLow_KeyPress);
            _txtHtLow.Validating += new System.ComponentModel.CancelEventHandler(txtHtLow_Validating);
            _txtHtLow.Enter += new EventHandler(txtHtLow_Enter);
            _txtHtHigh = new TextBox();
            _txtHtHigh.KeyPress += new KeyPressEventHandler(txtHtHigh_KeyPress);
            _txtHtHigh.Validating += new System.ComponentModel.CancelEventHandler(txtHtHigh_Validating);
            _txtHtHigh.Enter += new EventHandler(txtHtHigh_Enter);
            _txtRefSta = new TextBox();
            _txtRefSta.Enter += new EventHandler(txtRefSta_Enter);
            _txtLocNo = new TextBox();
            _txtLocNo.TextChanged += new EventHandler(txtLocNo_TextChanged);
            _txtLocNo.KeyPress += new KeyPressEventHandler(txtLocNo_KeyPress);
            _txtLocNo.Enter += new EventHandler(txtLocNo_Enter);
            _txtLocation = new TextBox();
            _txtLocation.TextChanged += new EventHandler(txtLocation_TextChanged);
            _txtLocation.Enter += new EventHandler(txtLocation_Enter);
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
            lblLocNumber = new Label();
            lblLocation = new Label();
            _ExitBtn = new Button();
            _ExitBtn.Click += new EventHandler(ExitBtn_Click);
            Tides1Txt = new TextBox();
            Tides2Txt = new TextBox();
            Tides3Txt = new TextBox();
            Tides4Txt = new RichTextBox();
            Tides5Txt = new TextBox();
            Tides7Txt = new TextBox();
            Tides6Txt = new RichTextBox();
            Tides8Txt = new TextBox();
            Tides9Txt = new TextBox();
            Tides10Txt = new RichTextBox();
            Tides11Txt = new TextBox();
            Tides12Txt = new TextBox();
            Tides13Txt = new TextBox();
            PictureBox1 = new PictureBox();
            _LinkNOAATideCurr = new LinkLabel();
            _LinkNOAATideCurr.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkNOAATideCurr_LinkClicked);
            DTTides = new DateTimePicker();
            lblDate = new Label();
            _DTTimeHigh = new DateTimePicker();
            _DTTimeHigh.ValueChanged += new EventHandler(DTTimeHigh_ValueChanged);
            DTTimeLow = new DateTimePicker();
            Frame1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmdPrint
            // 
            _cmdPrint.BackColor = SystemColors.Control;
            _cmdPrint.Cursor = Cursors.Default;
            _cmdPrint.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdPrint.ForeColor = SystemColors.ControlText;
            _cmdPrint.Image = (Image)resources.GetObject("cmdPrint.Image");
            _cmdPrint.Location = new Point(587, 0);
            _cmdPrint.Name = "_cmdPrint";
            _cmdPrint.RightToLeft = RightToLeft.No;
            _cmdPrint.Size = new Size(21, 21);
            _cmdPrint.TabIndex = 42;
            _cmdPrint.TextAlign = ContentAlignment.BottomCenter;
            ToolTip1.SetToolTip(_cmdPrint, "Print window");
            _cmdPrint.UseVisualStyleBackColor = false;
            // 
            // txtTab2LowMin
            // 
            _txtTab2LowMin.AcceptsReturn = true;
            _txtTab2LowMin.BackColor = SystemColors.Window;
            _txtTab2LowMin.Cursor = Cursors.IBeam;
            _txtTab2LowMin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtTab2LowMin.ForeColor = SystemColors.WindowText;
            _txtTab2LowMin.Location = new Point(520, 112);
            _txtTab2LowMin.MaxLength = 2;
            _txtTab2LowMin.Name = "_txtTab2LowMin";
            _txtTab2LowMin.RightToLeft = RightToLeft.No;
            _txtTab2LowMin.Size = new Size(25, 20);
            _txtTab2LowMin.TabIndex = 37;
            ToolTip1.SetToolTip(_txtTab2LowMin, "Range 0 to 59");
            // 
            // txtTab2HighMin
            // 
            _txtTab2HighMin.AcceptsReturn = true;
            _txtTab2HighMin.BackColor = SystemColors.Window;
            _txtTab2HighMin.Cursor = Cursors.IBeam;
            _txtTab2HighMin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtTab2HighMin.ForeColor = SystemColors.WindowText;
            _txtTab2HighMin.Location = new Point(392, 112);
            _txtTab2HighMin.MaxLength = 2;
            _txtTab2HighMin.Name = "_txtTab2HighMin";
            _txtTab2HighMin.RightToLeft = RightToLeft.No;
            _txtTab2HighMin.Size = new Size(25, 20);
            _txtTab2HighMin.TabIndex = 32;
            ToolTip1.SetToolTip(_txtTab2HighMin, "Range 0 to 59");
            // 
            // cmdVertical
            // 
            _cmdVertical.BackColor = SystemColors.Control;
            _cmdVertical.Cursor = Cursors.Default;
            _cmdVertical.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdVertical.ForeColor = SystemColors.ControlText;
            _cmdVertical.Location = new Point(1, 382);
            _cmdVertical.Name = "_cmdVertical";
            _cmdVertical.RightToLeft = RightToLeft.No;
            _cmdVertical.Size = new Size(185, 25);
            _cmdVertical.TabIndex = 49;
            _cmdVertical.Text = "&Vertical Clearances";
            _cmdVertical.UseVisualStyleBackColor = false;
            // 
            // Frame1
            // 
            Frame1.BackColor = SystemColors.Window;
            Frame1.Controls.Add(_optAltRule);
            Frame1.Controls.Add(_optRule);
            Frame1.Controls.Add(_optCalc);
            Frame1.Controls.Add(_optTable3);
            Frame1.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Frame1.ForeColor = SystemColors.ControlText;
            Frame1.Location = new Point(13, 23);
            Frame1.Name = "Frame1";
            Frame1.Padding = new Padding(0);
            Frame1.RightToLeft = RightToLeft.No;
            Frame1.Size = new Size(468, 34);
            Frame1.TabIndex = 44;
            Frame1.TabStop = false;
            Frame1.Text = "Use correction from";
            // 
            // optAltRule
            // 
            _optAltRule.BackColor = SystemColors.Window;
            _optAltRule.Cursor = Cursors.Default;
            _optAltRule.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optAltRule.ForeColor = SystemColors.ControlText;
            _optAltRule.Location = new Point(350, 12);
            _optAltRule.Name = "_optAltRule";
            _optAltRule.RightToLeft = RightToLeft.No;
            _optAltRule.Size = new Size(110, 17);
            _optAltRule.TabIndex = 48;
            _optAltRule.TabStop = true;
            _optAltRule.Text = "Alt. Rule of 12ths";
            _optAltRule.UseVisualStyleBackColor = false;
            // 
            // optRule
            // 
            _optRule.BackColor = SystemColors.Window;
            _optRule.Cursor = Cursors.Default;
            _optRule.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optRule.ForeColor = SystemColors.ControlText;
            _optRule.Location = new Point(256, 11);
            _optRule.Name = "_optRule";
            _optRule.RightToLeft = RightToLeft.No;
            _optRule.Size = new Size(90, 17);
            _optRule.TabIndex = 47;
            _optRule.TabStop = true;
            _optRule.Text = "Rule of 12ths";
            _optRule.UseVisualStyleBackColor = false;
            // 
            // optCalc
            // 
            _optCalc.BackColor = SystemColors.Window;
            _optCalc.Checked = true;
            _optCalc.Cursor = Cursors.Default;
            _optCalc.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optCalc.ForeColor = SystemColors.ControlText;
            _optCalc.Location = new Point(106, 11);
            _optCalc.Name = "_optCalc";
            _optCalc.RightToLeft = RightToLeft.No;
            _optCalc.Size = new Size(80, 17);
            _optCalc.TabIndex = 46;
            _optCalc.TabStop = true;
            _optCalc.Text = "Calculation";
            _optCalc.UseVisualStyleBackColor = false;
            // 
            // optTable3
            // 
            _optTable3.BackColor = SystemColors.Window;
            _optTable3.Cursor = Cursors.Default;
            _optTable3.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optTable3.ForeColor = SystemColors.ControlText;
            _optTable3.Location = new Point(192, 11);
            _optTable3.Name = "_optTable3";
            _optTable3.RightToLeft = RightToLeft.No;
            _optTable3.Size = new Size(60, 17);
            _optTable3.TabIndex = 45;
            _optTable3.TabStop = true;
            _optTable3.Text = "Table 3";
            _optTable3.UseVisualStyleBackColor = false;
            // 
            // cmdClear
            // 
            _cmdClear.BackColor = SystemColors.Control;
            _cmdClear.Cursor = Cursors.Default;
            _cmdClear.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdClear.ForeColor = SystemColors.ControlText;
            _cmdClear.Location = new Point(443, 382);
            _cmdClear.Name = "_cmdClear";
            _cmdClear.RightToLeft = RightToLeft.No;
            _cmdClear.Size = new Size(65, 25);
            _cmdClear.TabIndex = 43;
            _cmdClear.Text = "Clea&r";
            _cmdClear.UseVisualStyleBackColor = false;
            // 
            // cmdTides
            // 
            _cmdTides.BackColor = SystemColors.Control;
            _cmdTides.Cursor = Cursors.Default;
            _cmdTides.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdTides.ForeColor = SystemColors.ControlText;
            _cmdTides.Location = new Point(277, 382);
            _cmdTides.Name = "_cmdTides";
            _cmdTides.RightToLeft = RightToLeft.No;
            _cmdTides.Size = new Size(60, 25);
            _cmdTides.TabIndex = 41;
            _cmdTides.Text = "&Calculate";
            _cmdTides.UseVisualStyleBackColor = false;
            // 
            // txtTab2HtLow
            // 
            _txtTab2HtLow.AcceptsReturn = true;
            _txtTab2HtLow.BackColor = SystemColors.Window;
            _txtTab2HtLow.Cursor = Cursors.IBeam;
            _txtTab2HtLow.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtTab2HtLow.ForeColor = SystemColors.WindowText;
            _txtTab2HtLow.Location = new Point(560, 112);
            _txtTab2HtLow.MaxLength = 5;
            _txtTab2HtLow.Name = "_txtTab2HtLow";
            _txtTab2HtLow.RightToLeft = RightToLeft.No;
            _txtTab2HtLow.Size = new Size(41, 20);
            _txtTab2HtLow.TabIndex = 40;
            // 
            // txtTab2LowHour
            // 
            _txtTab2LowHour.AcceptsReturn = true;
            _txtTab2LowHour.BackColor = SystemColors.Window;
            _txtTab2LowHour.Cursor = Cursors.IBeam;
            _txtTab2LowHour.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtTab2LowHour.ForeColor = SystemColors.WindowText;
            _txtTab2LowHour.Location = new Point(488, 112);
            _txtTab2LowHour.MaxLength = 2;
            _txtTab2LowHour.Name = "_txtTab2LowHour";
            _txtTab2LowHour.RightToLeft = RightToLeft.No;
            _txtTab2LowHour.Size = new Size(25, 20);
            _txtTab2LowHour.TabIndex = 36;
            // 
            // txtTab2HtHigh
            // 
            _txtTab2HtHigh.AcceptsReturn = true;
            _txtTab2HtHigh.BackColor = SystemColors.Window;
            _txtTab2HtHigh.Cursor = Cursors.IBeam;
            _txtTab2HtHigh.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtTab2HtHigh.ForeColor = SystemColors.WindowText;
            _txtTab2HtHigh.Location = new Point(432, 112);
            _txtTab2HtHigh.MaxLength = 5;
            _txtTab2HtHigh.Name = "_txtTab2HtHigh";
            _txtTab2HtHigh.RightToLeft = RightToLeft.No;
            _txtTab2HtHigh.Size = new Size(41, 20);
            _txtTab2HtHigh.TabIndex = 35;
            // 
            // txtTab2HighHour
            // 
            _txtTab2HighHour.AcceptsReturn = true;
            _txtTab2HighHour.BackColor = SystemColors.Window;
            _txtTab2HighHour.Cursor = Cursors.IBeam;
            _txtTab2HighHour.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtTab2HighHour.ForeColor = SystemColors.WindowText;
            _txtTab2HighHour.Location = new Point(360, 112);
            _txtTab2HighHour.MaxLength = 2;
            _txtTab2HighHour.Name = "_txtTab2HighHour";
            _txtTab2HighHour.RightToLeft = RightToLeft.No;
            _txtTab2HighHour.Size = new Size(25, 20);
            _txtTab2HighHour.TabIndex = 31;
            // 
            // txtSubStaNo
            // 
            _txtSubStaNo.AcceptsReturn = true;
            _txtSubStaNo.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            _txtSubStaNo.Cursor = Cursors.IBeam;
            _txtSubStaNo.Enabled = false;
            _txtSubStaNo.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtSubStaNo.ForeColor = SystemColors.WindowText;
            _txtSubStaNo.Location = new Point(280, 112);
            _txtSubStaNo.MaxLength = 0;
            _txtSubStaNo.Name = "_txtSubStaNo";
            _txtSubStaNo.RightToLeft = RightToLeft.No;
            _txtSubStaNo.Size = new Size(49, 20);
            _txtSubStaNo.TabIndex = 29;
            // 
            // txtTab2Diff
            // 
            txtTab2Diff.AcceptsReturn = true;
            txtTab2Diff.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            txtTab2Diff.Cursor = Cursors.IBeam;
            txtTab2Diff.Enabled = false;
            txtTab2Diff.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtTab2Diff.ForeColor = SystemColors.WindowText;
            txtTab2Diff.Location = new Point(96, 112);
            txtTab2Diff.MaxLength = 0;
            txtTab2Diff.Name = "txtTab2Diff";
            txtTab2Diff.RightToLeft = RightToLeft.No;
            txtTab2Diff.Size = new Size(161, 20);
            txtTab2Diff.TabIndex = 27;
            // 
            // txtHtLow
            // 
            _txtHtLow.AcceptsReturn = true;
            _txtHtLow.BackColor = SystemColors.Window;
            _txtHtLow.Cursor = Cursors.IBeam;
            _txtHtLow.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtHtLow.ForeColor = SystemColors.WindowText;
            _txtHtLow.Location = new Point(560, 88);
            _txtHtLow.MaxLength = 5;
            _txtHtLow.Name = "_txtHtLow";
            _txtHtLow.RightToLeft = RightToLeft.No;
            _txtHtLow.Size = new Size(41, 20);
            _txtHtLow.TabIndex = 25;
            // 
            // txtHtHigh
            // 
            _txtHtHigh.AcceptsReturn = true;
            _txtHtHigh.BackColor = SystemColors.Window;
            _txtHtHigh.Cursor = Cursors.IBeam;
            _txtHtHigh.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtHtHigh.ForeColor = SystemColors.WindowText;
            _txtHtHigh.Location = new Point(432, 88);
            _txtHtHigh.MaxLength = 5;
            _txtHtHigh.Name = "_txtHtHigh";
            _txtHtHigh.RightToLeft = RightToLeft.No;
            _txtHtHigh.Size = new Size(41, 20);
            _txtHtHigh.TabIndex = 23;
            // 
            // txtRefSta
            // 
            _txtRefSta.AcceptsReturn = true;
            _txtRefSta.BackColor = SystemColors.Window;
            _txtRefSta.Cursor = Cursors.IBeam;
            _txtRefSta.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtRefSta.ForeColor = SystemColors.WindowText;
            _txtRefSta.Location = new Point(96, 88);
            _txtRefSta.MaxLength = 0;
            _txtRefSta.Name = "_txtRefSta";
            _txtRefSta.RightToLeft = RightToLeft.No;
            _txtRefSta.Size = new Size(249, 20);
            _txtRefSta.TabIndex = 21;
            // 
            // txtLocNo
            // 
            _txtLocNo.AcceptsReturn = true;
            _txtLocNo.BackColor = SystemColors.Window;
            _txtLocNo.Cursor = Cursors.IBeam;
            _txtLocNo.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtLocNo.ForeColor = SystemColors.WindowText;
            _txtLocNo.Location = new Point(376, 3);
            _txtLocNo.MaxLength = 7;
            _txtLocNo.Name = "_txtLocNo";
            _txtLocNo.RightToLeft = RightToLeft.No;
            _txtLocNo.Size = new Size(49, 20);
            _txtLocNo.TabIndex = 3;
            // 
            // txtLocation
            // 
            _txtLocation.AcceptsReturn = true;
            _txtLocation.BackColor = SystemColors.Window;
            _txtLocation.Cursor = Cursors.IBeam;
            _txtLocation.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtLocation.ForeColor = SystemColors.WindowText;
            _txtLocation.Location = new Point(72, 2);
            _txtLocation.MaxLength = 0;
            _txtLocation.Name = "_txtLocation";
            _txtLocation.RightToLeft = RightToLeft.No;
            _txtLocation.Size = new Size(273, 20);
            _txtLocation.TabIndex = 1;
            // 
            // Label15
            // 
            Label15.BackColor = SystemColors.Window;
            Label15.Cursor = Cursors.Default;
            Label15.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label15.ForeColor = SystemColors.ControlText;
            Label15.Location = new Point(543, 112);
            Label15.Name = "Label15";
            Label15.RightToLeft = RightToLeft.No;
            Label15.Size = new Size(12, 17);
            Label15.TabIndex = 39;
            Label15.Text = "m";
            // 
            // Label14
            // 
            Label14.BackColor = SystemColors.Window;
            Label14.Cursor = Cursors.Default;
            Label14.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label14.ForeColor = SystemColors.ControlText;
            Label14.Location = new Point(510, 112);
            Label14.Name = "Label14";
            Label14.RightToLeft = RightToLeft.No;
            Label14.Size = new Size(9, 17);
            Label14.TabIndex = 38;
            Label14.Text = "h";
            // 
            // Label13
            // 
            Label13.BackColor = SystemColors.Window;
            Label13.Cursor = Cursors.Default;
            Label13.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label13.ForeColor = SystemColors.ControlText;
            Label13.Location = new Point(415, 112);
            Label13.Name = "Label13";
            Label13.RightToLeft = RightToLeft.No;
            Label13.Size = new Size(12, 17);
            Label13.TabIndex = 34;
            Label13.Text = "m";
            // 
            // Label12
            // 
            Label12.BackColor = SystemColors.Window;
            Label12.Cursor = Cursors.Default;
            Label12.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label12.ForeColor = SystemColors.ControlText;
            Label12.Location = new Point(383, 112);
            Label12.Name = "Label12";
            Label12.RightToLeft = RightToLeft.No;
            Label12.Size = new Size(9, 17);
            Label12.TabIndex = 33;
            Label12.Text = "h";
            // 
            // Label11
            // 
            Label11.BackColor = SystemColors.Window;
            Label11.Cursor = Cursors.Default;
            Label11.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label11.ForeColor = SystemColors.ControlText;
            Label11.Location = new Point(336, 112);
            Label11.Name = "Label11";
            Label11.RightToLeft = RightToLeft.No;
            Label11.Size = new Size(9, 17);
            Label11.TabIndex = 30;
            Label11.Text = ")";
            // 
            // Label10
            // 
            Label10.BackColor = SystemColors.Window;
            Label10.Cursor = Cursors.Default;
            Label10.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label10.ForeColor = SystemColors.ControlText;
            Label10.Location = new Point(264, 112);
            Label10.Name = "Label10";
            Label10.RightToLeft = RightToLeft.No;
            Label10.Size = new Size(17, 17);
            Label10.TabIndex = 28;
            Label10.Text = "(#";
            // 
            // Label9
            // 
            Label9.BackColor = SystemColors.Window;
            Label9.Cursor = Cursors.Default;
            Label9.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label9.ForeColor = SystemColors.ControlText;
            Label9.Location = new Point(16, 112);
            Label9.Name = "Label9";
            Label9.RightToLeft = RightToLeft.No;
            Label9.Size = new Size(73, 17);
            Label9.TabIndex = 26;
            Label9.Text = "+ Table 2 Diff:";
            // 
            // Label8
            // 
            Label8.BackColor = SystemColors.Window;
            Label8.Cursor = Cursors.Default;
            Label8.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label8.ForeColor = SystemColors.ControlText;
            Label8.Location = new Point(16, 88);
            Label8.Name = "Label8";
            Label8.RightToLeft = RightToLeft.No;
            Label8.Size = new Size(65, 17);
            Label8.TabIndex = 20;
            Label8.Text = "Ref. Station:";
            // 
            // Label7
            // 
            Label7.BackColor = SystemColors.Window;
            Label7.Cursor = Cursors.Default;
            Label7.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label7.ForeColor = SystemColors.ControlText;
            Label7.Location = new Point(562, 72);
            Label7.Name = "Label7";
            Label7.RightToLeft = RightToLeft.No;
            Label7.Size = new Size(35, 17);
            Label7.TabIndex = 19;
            Label7.Text = "Ht (ft)";
            // 
            // Label6
            // 
            Label6.BackColor = SystemColors.Window;
            Label6.Cursor = Cursors.Default;
            Label6.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label6.ForeColor = SystemColors.ControlText;
            Label6.Location = new Point(435, 72);
            Label6.Name = "Label6";
            Label6.RightToLeft = RightToLeft.No;
            Label6.Size = new Size(35, 17);
            Label6.TabIndex = 18;
            Label6.Text = "Ht (ft)";
            // 
            // Label5
            // 
            Label5.BackColor = SystemColors.Window;
            Label5.Cursor = Cursors.Default;
            Label5.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label5.ForeColor = SystemColors.ControlText;
            Label5.Location = new Point(488, 72);
            Label5.Name = "Label5";
            Label5.RightToLeft = RightToLeft.No;
            Label5.Size = new Size(70, 17);
            Label5.TabIndex = 17;
            Label5.Text = "Time (hhmm)";
            // 
            // Label4
            // 
            Label4.BackColor = SystemColors.Window;
            Label4.Cursor = Cursors.Default;
            Label4.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.ForeColor = SystemColors.ControlText;
            Label4.Location = new Point(357, 72);
            Label4.Name = "Label4";
            Label4.RightToLeft = RightToLeft.No;
            Label4.Size = new Size(70, 17);
            Label4.TabIndex = 16;
            Label4.Text = "Time (hhmm)";
            // 
            // Label3
            // 
            Label3.BackColor = SystemColors.Window;
            Label3.Cursor = Cursors.Default;
            Label3.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.ForeColor = SystemColors.ControlText;
            Label3.Location = new Point(528, 56);
            Label3.Name = "Label3";
            Label3.RightToLeft = RightToLeft.No;
            Label3.Size = new Size(33, 17);
            Label3.TabIndex = 15;
            Label3.Text = "LOW";
            // 
            // Label2
            // 
            Label2.BackColor = SystemColors.Window;
            Label2.Cursor = Cursors.Default;
            Label2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = SystemColors.ControlText;
            Label2.Location = new Point(400, 56);
            Label2.Name = "Label2";
            Label2.RightToLeft = RightToLeft.No;
            Label2.Size = new Size(33, 17);
            Label2.TabIndex = 14;
            Label2.Text = "HIGH";
            // 
            // Label1
            // 
            Label1.BackColor = SystemColors.Window;
            Label1.Cursor = Cursors.Default;
            Label1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = SystemColors.ControlText;
            Label1.Location = new Point(426, 3);
            Label1.Name = "Label1";
            Label1.RightToLeft = RightToLeft.No;
            Label1.Size = new Size(145, 17);
            Label1.TabIndex = 4;
            Label1.Text = ")  Substation # from Table 2";
            Label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLocNumber
            // 
            lblLocNumber.BackColor = SystemColors.Window;
            lblLocNumber.Cursor = Cursors.Default;
            lblLocNumber.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLocNumber.ForeColor = SystemColors.ControlText;
            lblLocNumber.Location = new Point(360, 3);
            lblLocNumber.Name = "lblLocNumber";
            lblLocNumber.RightToLeft = RightToLeft.No;
            lblLocNumber.Size = new Size(17, 17);
            lblLocNumber.TabIndex = 2;
            lblLocNumber.Text = "(#";
            lblLocNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLocation
            // 
            lblLocation.BackColor = SystemColors.Window;
            lblLocation.Cursor = Cursors.Default;
            lblLocation.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLocation.ForeColor = SystemColors.ControlText;
            lblLocation.Location = new Point(8, 3);
            lblLocation.Name = "lblLocation";
            lblLocation.RightToLeft = RightToLeft.No;
            lblLocation.Size = new Size(60, 17);
            lblLocation.TabIndex = 0;
            lblLocation.Text = "LOCATION";
            // 
            // ExitBtn
            // 
            _ExitBtn.BackColor = Color.Red;
            _ExitBtn.ForeColor = SystemColors.ControlLightLight;
            _ExitBtn.Location = new Point(532, 384);
            _ExitBtn.Name = "_ExitBtn";
            _ExitBtn.Size = new Size(75, 23);
            _ExitBtn.TabIndex = 51;
            _ExitBtn.Text = "Exit";
            _ExitBtn.UseVisualStyleBackColor = false;
            // 
            // Tides1Txt
            // 
            Tides1Txt.BorderStyle = BorderStyle.None;
            Tides1Txt.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Tides1Txt.Location = new Point(1, 136);
            Tides1Txt.Name = "Tides1Txt";
            Tides1Txt.ReadOnly = true;
            Tides1Txt.Size = new Size(350, 13);
            Tides1Txt.TabIndex = 52;
            // 
            // Tides2Txt
            // 
            Tides2Txt.BorderStyle = BorderStyle.None;
            Tides2Txt.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Tides2Txt.Location = new Point(355, 136);
            Tides2Txt.Name = "Tides2Txt";
            Tides2Txt.ReadOnly = true;
            Tides2Txt.Size = new Size(124, 13);
            Tides2Txt.TabIndex = 53;
            Tides2Txt.TextAlign = HorizontalAlignment.Center;
            // 
            // Tides3Txt
            // 
            Tides3Txt.BorderStyle = BorderStyle.None;
            Tides3Txt.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Tides3Txt.Location = new Point(482, 136);
            Tides3Txt.Name = "Tides3Txt";
            Tides3Txt.ReadOnly = true;
            Tides3Txt.Size = new Size(124, 13);
            Tides3Txt.TabIndex = 54;
            Tides3Txt.TextAlign = HorizontalAlignment.Center;
            // 
            // Tides4Txt
            // 
            Tides4Txt.BorderStyle = BorderStyle.None;
            Tides4Txt.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Tides4Txt.Location = new Point(0, 154);
            Tides4Txt.Name = "Tides4Txt";
            Tides4Txt.ReadOnly = true;
            Tides4Txt.ScrollBars = RichTextBoxScrollBars.None;
            Tides4Txt.Size = new Size(478, 60);
            Tides4Txt.TabIndex = 55;
            Tides4Txt.Text = "";
            // 
            // Tides5Txt
            // 
            Tides5Txt.BorderStyle = BorderStyle.None;
            Tides5Txt.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Tides5Txt.Location = new Point(482, 154);
            Tides5Txt.Multiline = true;
            Tides5Txt.Name = "Tides5Txt";
            Tides5Txt.ReadOnly = true;
            Tides5Txt.Size = new Size(124, 60);
            Tides5Txt.TabIndex = 56;
            Tides5Txt.TextAlign = HorizontalAlignment.Center;
            // 
            // Tides7Txt
            // 
            Tides7Txt.BorderStyle = BorderStyle.None;
            Tides7Txt.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Tides7Txt.Location = new Point(483, 217);
            Tides7Txt.Multiline = true;
            Tides7Txt.Name = "Tides7Txt";
            Tides7Txt.ReadOnly = true;
            Tides7Txt.Size = new Size(124, 60);
            Tides7Txt.TabIndex = 57;
            Tides7Txt.TextAlign = HorizontalAlignment.Center;
            // 
            // Tides6Txt
            // 
            Tides6Txt.BorderStyle = BorderStyle.None;
            Tides6Txt.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Tides6Txt.Location = new Point(1, 218);
            Tides6Txt.Name = "Tides6Txt";
            Tides6Txt.ReadOnly = true;
            Tides6Txt.ScrollBars = RichTextBoxScrollBars.None;
            Tides6Txt.Size = new Size(478, 60);
            Tides6Txt.TabIndex = 58;
            Tides6Txt.Text = "";
            // 
            // Tides8Txt
            // 
            Tides8Txt.BorderStyle = BorderStyle.None;
            Tides8Txt.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Tides8Txt.Location = new Point(1, 282);
            Tides8Txt.Name = "Tides8Txt";
            Tides8Txt.ReadOnly = true;
            Tides8Txt.Size = new Size(478, 13);
            Tides8Txt.TabIndex = 59;
            Tides8Txt.TextAlign = HorizontalAlignment.Center;
            // 
            // Tides9Txt
            // 
            Tides9Txt.BorderStyle = BorderStyle.None;
            Tides9Txt.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Tides9Txt.Location = new Point(483, 282);
            Tides9Txt.Name = "Tides9Txt";
            Tides9Txt.ReadOnly = true;
            Tides9Txt.Size = new Size(124, 13);
            Tides9Txt.TabIndex = 60;
            Tides9Txt.TextAlign = HorizontalAlignment.Center;
            // 
            // Tides10Txt
            // 
            Tides10Txt.BorderStyle = BorderStyle.None;
            Tides10Txt.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Tides10Txt.Location = new Point(2, 300);
            Tides10Txt.Name = "Tides10Txt";
            Tides10Txt.ReadOnly = true;
            Tides10Txt.ScrollBars = RichTextBoxScrollBars.None;
            Tides10Txt.Size = new Size(478, 60);
            Tides10Txt.TabIndex = 61;
            Tides10Txt.Text = "";
            // 
            // Tides11Txt
            // 
            Tides11Txt.BorderStyle = BorderStyle.None;
            Tides11Txt.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Tides11Txt.Location = new Point(483, 300);
            Tides11Txt.Multiline = true;
            Tides11Txt.Name = "Tides11Txt";
            Tides11Txt.ReadOnly = true;
            Tides11Txt.Size = new Size(124, 60);
            Tides11Txt.TabIndex = 62;
            Tides11Txt.TextAlign = HorizontalAlignment.Center;
            // 
            // Tides12Txt
            // 
            Tides12Txt.BorderStyle = BorderStyle.None;
            Tides12Txt.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Tides12Txt.Location = new Point(2, 366);
            Tides12Txt.Name = "Tides12Txt";
            Tides12Txt.ReadOnly = true;
            Tides12Txt.Size = new Size(478, 13);
            Tides12Txt.TabIndex = 63;
            Tides12Txt.TextAlign = HorizontalAlignment.Center;
            // 
            // Tides13Txt
            // 
            Tides13Txt.BorderStyle = BorderStyle.None;
            Tides13Txt.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Tides13Txt.Location = new Point(482, 366);
            Tides13Txt.Name = "Tides13Txt";
            Tides13Txt.ReadOnly = true;
            Tides13Txt.Size = new Size(124, 13);
            Tides13Txt.TabIndex = 64;
            Tides13Txt.TextAlign = HorizontalAlignment.Center;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.ABC_white;
            PictureBox1.Location = new Point(155, 413);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(316, 50);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 102;
            PictureBox1.TabStop = false;
            // 
            // LinkNOAATideCurr
            // 
            _LinkNOAATideCurr.AutoSize = true;
            _LinkNOAATideCurr.Location = new Point(151, 468);
            _LinkNOAATideCurr.Name = "_LinkNOAATideCurr";
            _LinkNOAATideCurr.Size = new Size(321, 26);
            _LinkNOAATideCurr.TabIndex = 103;
            _LinkNOAATideCurr.TabStop = true;
            _LinkNOAATideCurr.Text = "For additional information and online tools about tide predictions, " + '\r' + '\n' + "Click here " + "to go to the NOAA Tides Predictions Web Page";
            _LinkNOAATideCurr.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DTTides
            // 
            DTTides.CustomFormat = "MM / dd / yyyy HH:mm";
            DTTides.DropDownAlign = LeftRightAlignment.Right;
            DTTides.Format = DateTimePickerFormat.Custom;
            DTTides.Location = new Point(193, 61);
            DTTides.Name = "DTTides";
            DTTides.Size = new Size(146, 21);
            DTTides.TabIndex = 126;
            // 
            // lblDate
            // 
            lblDate.BackColor = SystemColors.Window;
            lblDate.Cursor = Cursors.Default;
            lblDate.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblDate.ForeColor = SystemColors.ControlText;
            lblDate.Location = new Point(10, 60);
            lblDate.Name = "lblDate";
            lblDate.RightToLeft = RightToLeft.No;
            lblDate.Size = new Size(174, 20);
            lblDate.TabIndex = 125;
            lblDate.Text = "Desired Date and Time for Tides:";
            lblDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DTTimeHigh
            // 
            _DTTimeHigh.CustomFormat = "HH:mm";
            _DTTimeHigh.Format = DateTimePickerFormat.Custom;
            _DTTimeHigh.Location = new Point(360, 86);
            _DTTimeHigh.Name = "_DTTimeHigh";
            _DTTimeHigh.ShowUpDown = true;
            _DTTimeHigh.Size = new Size(60, 21);
            _DTTimeHigh.TabIndex = 127;
            // 
            // DTTimeLow
            // 
            DTTimeLow.CustomFormat = "HH:mm";
            DTTimeLow.Format = DateTimePickerFormat.Custom;
            DTTimeLow.Location = new Point(490, 87);
            DTTimeLow.Name = "DTTimeLow";
            DTTimeLow.ShowUpDown = true;
            DTTimeLow.Size = new Size(60, 21);
            DTTimeLow.TabIndex = 128;
            // 
            // FormTides
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(608, 508);
            Controls.Add(DTTimeLow);
            Controls.Add(_DTTimeHigh);
            Controls.Add(DTTides);
            Controls.Add(lblDate);
            Controls.Add(_LinkNOAATideCurr);
            Controls.Add(PictureBox1);
            Controls.Add(Tides13Txt);
            Controls.Add(Tides12Txt);
            Controls.Add(Tides11Txt);
            Controls.Add(Tides10Txt);
            Controls.Add(Tides9Txt);
            Controls.Add(Tides8Txt);
            Controls.Add(Tides6Txt);
            Controls.Add(Tides7Txt);
            Controls.Add(Tides5Txt);
            Controls.Add(Tides4Txt);
            Controls.Add(Tides3Txt);
            Controls.Add(Tides2Txt);
            Controls.Add(Tides1Txt);
            Controls.Add(_ExitBtn);
            Controls.Add(_cmdVertical);
            Controls.Add(Frame1);
            Controls.Add(_cmdClear);
            Controls.Add(_cmdPrint);
            Controls.Add(_cmdTides);
            Controls.Add(_txtTab2HtLow);
            Controls.Add(_txtTab2LowMin);
            Controls.Add(_txtTab2LowHour);
            Controls.Add(_txtTab2HtHigh);
            Controls.Add(_txtTab2HighMin);
            Controls.Add(_txtTab2HighHour);
            Controls.Add(_txtSubStaNo);
            Controls.Add(txtTab2Diff);
            Controls.Add(_txtHtLow);
            Controls.Add(_txtHtHigh);
            Controls.Add(_txtRefSta);
            Controls.Add(_txtLocNo);
            Controls.Add(_txtLocation);
            Controls.Add(Label15);
            Controls.Add(Label14);
            Controls.Add(Label13);
            Controls.Add(Label12);
            Controls.Add(Label11);
            Controls.Add(Label10);
            Controls.Add(Label9);
            Controls.Add(Label8);
            Controls.Add(Label7);
            Controls.Add(Label6);
            Controls.Add(Label5);
            Controls.Add(Label4);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(lblLocNumber);
            Controls.Add(lblLocation);
            Cursor = Cursors.Default;
            Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(3, 22);
            MaximizeBox = false;
            Name = "FormTides";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Height of Tide at Desired Time";
            Frame1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Load += new EventHandler(FormTides_Load);
            FormClosed += new FormClosedEventHandler(FormTides_FormClosed);
            ResumeLayout(false);
            PerformLayout();
        }

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

        internal TextBox Tides1Txt;
        internal TextBox Tides2Txt;
        internal TextBox Tides3Txt;
        internal RichTextBox Tides4Txt;
        internal TextBox Tides5Txt;
        internal TextBox Tides7Txt;
        internal RichTextBox Tides6Txt;
        internal TextBox Tides8Txt;
        internal TextBox Tides9Txt;
        internal RichTextBox Tides10Txt;
        internal TextBox Tides11Txt;
        internal TextBox Tides12Txt;
        internal TextBox Tides13Txt;
        internal PictureBox PictureBox1;
        private LinkLabel _LinkNOAATideCurr;

        internal LinkLabel LinkNOAATideCurr
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LinkNOAATideCurr;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LinkNOAATideCurr != null)
                {
                    _LinkNOAATideCurr.LinkClicked -= LinkNOAATideCurr_LinkClicked;
                }

                _LinkNOAATideCurr = value;
                if (_LinkNOAATideCurr != null)
                {
                    _LinkNOAATideCurr.LinkClicked += LinkNOAATideCurr_LinkClicked;
                }
            }
        }

        internal DateTimePicker DTTides;
        public Label lblDate;
        private DateTimePicker _DTTimeHigh;

        internal DateTimePicker DTTimeHigh
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _DTTimeHigh;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_DTTimeHigh != null)
                {
                    _DTTimeHigh.ValueChanged -= DTTimeHigh_ValueChanged;
                }

                _DTTimeHigh = value;
                if (_DTTimeHigh != null)
                {
                    _DTTimeHigh.ValueChanged += DTTimeHigh_ValueChanged;
                }
            }
        }

        internal DateTimePicker DTTimeLow;
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}