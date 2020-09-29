using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    [DesignerGenerated()]
    internal partial class FormMoBoard
    {
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        [DebuggerNonUserCode()]
        public FormMoBoard() : base()
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
        private TextBox _txtWindDir;

        public TextBox txtWindDir
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtWindDir;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtWindDir != null)
                {
                    _txtWindDir.TextChanged -= txtWindDir_TextChanged;
                    _txtWindDir.KeyPress -= txtWindDir_KeyPress;
                    _txtWindDir.Validating -= txtWindDir_Validating;
                    _txtWindDir.Enter -= txtWindDir_Enter;
                }

                _txtWindDir = value;
                if (_txtWindDir != null)
                {
                    _txtWindDir.TextChanged += txtWindDir_TextChanged;
                    _txtWindDir.KeyPress += txtWindDir_KeyPress;
                    _txtWindDir.Validating += txtWindDir_Validating;
                    _txtWindDir.Enter += txtWindDir_Enter;
                }
            }
        }

        private TextBox _txtWindSpeed;

        public TextBox txtWindSpeed
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtWindSpeed;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtWindSpeed != null)
                {
                    _txtWindSpeed.TextChanged -= txtWindSpeed_TextChanged;
                    _txtWindSpeed.KeyPress -= txtWindSpeed_KeyPress;
                    _txtWindSpeed.Validating -= txtWindSpeed_Validating;
                    _txtWindSpeed.Enter -= txtWindSpeed_Enter;
                }

                _txtWindSpeed = value;
                if (_txtWindSpeed != null)
                {
                    _txtWindSpeed.TextChanged += txtWindSpeed_TextChanged;
                    _txtWindSpeed.KeyPress += txtWindSpeed_KeyPress;
                    _txtWindSpeed.Validating += txtWindSpeed_Validating;
                    _txtWindSpeed.Enter += txtWindSpeed_Enter;
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

        private TextBox _txtV1Speed;

        public TextBox txtV1Speed
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtV1Speed;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtV1Speed != null)
                {
                    _txtV1Speed.TextChanged -= txtV1Speed_TextChanged;
                    _txtV1Speed.KeyPress -= txtV1Speed_KeyPress;
                    _txtV1Speed.Validating -= txtV1Speed_Validating;
                    _txtV1Speed.Enter -= txtV1Speed_Enter;
                }

                _txtV1Speed = value;
                if (_txtV1Speed != null)
                {
                    _txtV1Speed.TextChanged += txtV1Speed_TextChanged;
                    _txtV1Speed.KeyPress += txtV1Speed_KeyPress;
                    _txtV1Speed.Validating += txtV1Speed_Validating;
                    _txtV1Speed.Enter += txtV1Speed_Enter;
                }
            }
        }

        private TextBox _txtV1Course;

        public TextBox txtV1Course
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtV1Course;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtV1Course != null)
                {
                    _txtV1Course.TextChanged -= txtV1Course_TextChanged;
                    _txtV1Course.KeyPress -= txtV1Course_KeyPress;
                    _txtV1Course.Validating -= txtV1Course_Validating;
                    _txtV1Course.Enter -= txtV1Course_Enter;
                }

                _txtV1Course = value;
                if (_txtV1Course != null)
                {
                    _txtV1Course.TextChanged += txtV1Course_TextChanged;
                    _txtV1Course.KeyPress += txtV1Course_KeyPress;
                    _txtV1Course.Validating += txtV1Course_Validating;
                    _txtV1Course.Enter += txtV1Course_Enter;
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

        private RadioButton _optWindApp;

        public RadioButton optWindApp
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optWindApp;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optWindApp != null)
                {
                    _optWindApp.CheckedChanged -= optWindApp_CheckedChanged;
                }

                _optWindApp = value;
                if (_optWindApp != null)
                {
                    _optWindApp.CheckedChanged += optWindApp_CheckedChanged;
                }
            }
        }

        private RadioButton _optWind;

        public RadioButton optWind
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optWind;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optWind != null)
                {
                    _optWind.CheckedChanged -= optWind_CheckedChanged;
                }

                _optWind = value;
                if (_optWind != null)
                {
                    _optWind.CheckedChanged += optWind_CheckedChanged;
                }
            }
        }

        private RadioButton _optCPATypeB;

        public RadioButton optCPATypeB
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optCPATypeB;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optCPATypeB != null)
                {
                    _optCPATypeB.CheckedChanged -= optCPATypeB_CheckedChanged;
                }

                _optCPATypeB = value;
                if (_optCPATypeB != null)
                {
                    _optCPATypeB.CheckedChanged += optCPATypeB_CheckedChanged;
                }
            }
        }

        private RadioButton _optCPATypeA;

        public RadioButton optCPATypeA
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optCPATypeA;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optCPATypeA != null)
                {
                    _optCPATypeA.CheckedChanged -= optCPATypeA_CheckedChanged;
                }

                _optCPATypeA = value;
                if (_optCPATypeA != null)
                {
                    _optCPATypeA.CheckedChanged += optCPATypeA_CheckedChanged;
                }
            }
        }

        public GroupBox Frame1;
        private TextBox _txtBearing;

        public TextBox txtBearing
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtBearing;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtBearing != null)
                {
                    _txtBearing.TextChanged -= txtBearing_TextChanged;
                    _txtBearing.KeyPress -= txtBearing_KeyPress;
                    _txtBearing.Validating -= txtBearing_Validating;
                    _txtBearing.Enter -= txtBearing_Enter;
                }

                _txtBearing = value;
                if (_txtBearing != null)
                {
                    _txtBearing.TextChanged += txtBearing_TextChanged;
                    _txtBearing.KeyPress += txtBearing_KeyPress;
                    _txtBearing.Validating += txtBearing_Validating;
                    _txtBearing.Enter += txtBearing_Enter;
                }
            }
        }

        private TextBox _txtRange;

        public TextBox txtRange
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtRange;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtRange != null)
                {
                    _txtRange.TextChanged -= txtRange_TextChanged;
                    _txtRange.KeyPress -= txtRange_KeyPress;
                    _txtRange.Validating -= txtRange_Validating;
                    _txtRange.Enter -= txtRange_Enter;
                }

                _txtRange = value;
                if (_txtRange != null)
                {
                    _txtRange.TextChanged += txtRange_TextChanged;
                    _txtRange.KeyPress += txtRange_KeyPress;
                    _txtRange.Validating += txtRange_Validating;
                    _txtRange.Enter += txtRange_Enter;
                }
            }
        }

        private TextBox _txtCourse2;

        public TextBox txtCourse2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtCourse2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtCourse2 != null)
                {
                    _txtCourse2.TextChanged -= txtCourse2_TextChanged;
                    _txtCourse2.KeyPress -= txtCourse2_KeyPress;
                    _txtCourse2.Validating -= txtCourse2_Validating;
                    _txtCourse2.Enter -= txtCourse2_Enter;
                }

                _txtCourse2 = value;
                if (_txtCourse2 != null)
                {
                    _txtCourse2.TextChanged += txtCourse2_TextChanged;
                    _txtCourse2.KeyPress += txtCourse2_KeyPress;
                    _txtCourse2.Validating += txtCourse2_Validating;
                    _txtCourse2.Enter += txtCourse2_Enter;
                }
            }
        }

        private TextBox _txtSpeed2;

        public TextBox txtSpeed2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtSpeed2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtSpeed2 != null)
                {
                    _txtSpeed2.TextChanged -= txtSpeed2_TextChanged;
                    _txtSpeed2.KeyPress -= txtSpeed2_KeyPress;
                    _txtSpeed2.Validating -= txtSpeed2_Validating;
                    _txtSpeed2.Enter -= txtSpeed2_Enter;
                }

                _txtSpeed2 = value;
                if (_txtSpeed2 != null)
                {
                    _txtSpeed2.TextChanged += txtSpeed2_TextChanged;
                    _txtSpeed2.KeyPress += txtSpeed2_KeyPress;
                    _txtSpeed2.Validating += txtSpeed2_Validating;
                    _txtSpeed2.Enter += txtSpeed2_Enter;
                }
            }
        }

        private TextBox _txtCourse1;

        public TextBox txtCourse1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtCourse1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtCourse1 != null)
                {
                    _txtCourse1.TextChanged -= txtCourse1_TextChanged;
                    _txtCourse1.KeyPress -= txtCourse1_KeyPress;
                    _txtCourse1.Validating -= txtCourse1_Validating;
                    _txtCourse1.Enter -= txtCourse1_Enter;
                }

                _txtCourse1 = value;
                if (_txtCourse1 != null)
                {
                    _txtCourse1.TextChanged += txtCourse1_TextChanged;
                    _txtCourse1.KeyPress += txtCourse1_KeyPress;
                    _txtCourse1.Validating += txtCourse1_Validating;
                    _txtCourse1.Enter += txtCourse1_Enter;
                }
            }
        }

        private TextBox _txtSpeed1;

        public TextBox txtSpeed1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtSpeed1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtSpeed1 != null)
                {
                    _txtSpeed1.TextChanged -= txtSpeed1_TextChanged;
                    _txtSpeed1.KeyPress -= txtSpeed1_KeyPress;
                    _txtSpeed1.Validating -= txtSpeed1_Validating;
                    _txtSpeed1.Enter -= txtSpeed1_Enter;
                }

                _txtSpeed1 = value;
                if (_txtSpeed1 != null)
                {
                    _txtSpeed1.TextChanged += txtSpeed1_TextChanged;
                    _txtSpeed1.KeyPress += txtSpeed1_KeyPress;
                    _txtSpeed1.Validating += txtSpeed1_Validating;
                    _txtSpeed1.Enter += txtSpeed1_Enter;
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

        private TextBox _txtBearing2;

        public TextBox txtBearing2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtBearing2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtBearing2 != null)
                {
                    _txtBearing2.TextChanged -= txtBearing2_TextChanged;
                    _txtBearing2.KeyPress -= txtBearing2_KeyPress;
                    _txtBearing2.Validating -= txtBearing2_Validating;
                    _txtBearing2.Enter -= txtBearing2_Enter;
                }

                _txtBearing2 = value;
                if (_txtBearing2 != null)
                {
                    _txtBearing2.TextChanged += txtBearing2_TextChanged;
                    _txtBearing2.KeyPress += txtBearing2_KeyPress;
                    _txtBearing2.Validating += txtBearing2_Validating;
                    _txtBearing2.Enter += txtBearing2_Enter;
                }
            }
        }

        private TextBox _txtRange2;

        public TextBox txtRange2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtRange2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtRange2 != null)
                {
                    _txtRange2.TextChanged -= txtRange2_TextChanged;
                    _txtRange2.KeyPress -= txtRange2_KeyPress;
                    _txtRange2.Validating -= txtRange2_Validating;
                    _txtRange2.Enter -= txtRange2_Enter;
                }

                _txtRange2 = value;
                if (_txtRange2 != null)
                {
                    _txtRange2.TextChanged += txtRange2_TextChanged;
                    _txtRange2.KeyPress += txtRange2_KeyPress;
                    _txtRange2.Validating += txtRange2_Validating;
                    _txtRange2.Enter += txtRange2_Enter;
                }
            }
        }

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

        private TextBox _txtBearing1;

        public TextBox txtBearing1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtBearing1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtBearing1 != null)
                {
                    _txtBearing1.TextChanged -= txtBearing1_TextChanged;
                    _txtBearing1.KeyPress -= txtBearing1_KeyPress;
                    _txtBearing1.Validating -= txtBearing1_Validating;
                    _txtBearing1.Enter -= txtBearing1_Enter;
                }

                _txtBearing1 = value;
                if (_txtBearing1 != null)
                {
                    _txtBearing1.TextChanged += txtBearing1_TextChanged;
                    _txtBearing1.KeyPress += txtBearing1_KeyPress;
                    _txtBearing1.Validating += txtBearing1_Validating;
                    _txtBearing1.Enter += txtBearing1_Enter;
                }
            }
        }

        private TextBox _txtRange1;

        public TextBox txtRange1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtRange1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtRange1 != null)
                {
                    _txtRange1.TextChanged -= txtRange1_TextChanged;
                    _txtRange1.KeyPress -= txtRange1_KeyPress;
                    _txtRange1.Validating -= txtRange1_Validating;
                    _txtRange1.Enter -= txtRange1_Enter;
                }

                _txtRange1 = value;
                if (_txtRange1 != null)
                {
                    _txtRange1.TextChanged += txtRange1_TextChanged;
                    _txtRange1.KeyPress += txtRange1_KeyPress;
                    _txtRange1.Validating += txtRange1_Validating;
                    _txtRange1.Enter += txtRange1_Enter;
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

        public Label Label22;
        public Label Label23;
        public Label Label21;
        public Label Label20;
        public Label Label19;
        public Label Label18;
        public Label Label17;
        public Label Label16;
        // Public WithEvents Line1 As Microsoft.VisualBasic.PowerPacks.LineShape
        public Label Label15;
        public Label Label8;
        public Label Label7;
        public Label Label14;
        public Label Label13;
        public Label Label12;
        public Label Label11;
        public Label Label10;
        public Label Label9;
        public Label Label6;
        public Label Label5;
        public Label Label4;
        public Label Label2;
        public Label Label3;
        public Label Label1;
        // Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMoBoard));
            ToolTip1 = new ToolTip(components);
            _txtWindDir = new TextBox();
            _txtWindDir.TextChanged += new EventHandler(txtWindDir_TextChanged);
            _txtWindDir.KeyPress += new KeyPressEventHandler(txtWindDir_KeyPress);
            _txtWindDir.Validating += new System.ComponentModel.CancelEventHandler(txtWindDir_Validating);
            _txtWindDir.Enter += new EventHandler(txtWindDir_Enter);
            _txtWindSpeed = new TextBox();
            _txtWindSpeed.TextChanged += new EventHandler(txtWindSpeed_TextChanged);
            _txtWindSpeed.KeyPress += new KeyPressEventHandler(txtWindSpeed_KeyPress);
            _txtWindSpeed.Validating += new System.ComponentModel.CancelEventHandler(txtWindSpeed_Validating);
            _txtWindSpeed.Enter += new EventHandler(txtWindSpeed_Enter);
            _txtSpeed = new TextBox();
            _txtSpeed.TextChanged += new EventHandler(txtSpeed_TextChanged);
            _txtSpeed.KeyPress += new KeyPressEventHandler(txtSpeed_KeyPress);
            _txtSpeed.Validating += new System.ComponentModel.CancelEventHandler(txtSpeed_Validating);
            _txtSpeed.Enter += new EventHandler(txtSpeed_Enter);
            _txtCourse = new TextBox();
            _txtCourse.TextChanged += new EventHandler(txtCourse_TextChanged);
            _txtCourse.KeyPress += new KeyPressEventHandler(txtCourse_KeyPress);
            _txtCourse.Validating += new System.ComponentModel.CancelEventHandler(txtCourse_Validating);
            _txtCourse.Enter += new EventHandler(txtCourse_Enter);
            _txtV1Speed = new TextBox();
            _txtV1Speed.TextChanged += new EventHandler(txtV1Speed_TextChanged);
            _txtV1Speed.KeyPress += new KeyPressEventHandler(txtV1Speed_KeyPress);
            _txtV1Speed.Validating += new System.ComponentModel.CancelEventHandler(txtV1Speed_Validating);
            _txtV1Speed.Enter += new EventHandler(txtV1Speed_Enter);
            _txtV1Course = new TextBox();
            _txtV1Course.TextChanged += new EventHandler(txtV1Course_TextChanged);
            _txtV1Course.KeyPress += new KeyPressEventHandler(txtV1Course_KeyPress);
            _txtV1Course.Validating += new System.ComponentModel.CancelEventHandler(txtV1Course_Validating);
            _txtV1Course.Enter += new EventHandler(txtV1Course_Enter);
            _cmdPrint = new Button();
            _cmdPrint.Click += new EventHandler(cmdPrint_Click);
            _txtBearing = new TextBox();
            _txtBearing.TextChanged += new EventHandler(txtBearing_TextChanged);
            _txtBearing.KeyPress += new KeyPressEventHandler(txtBearing_KeyPress);
            _txtBearing.Validating += new System.ComponentModel.CancelEventHandler(txtBearing_Validating);
            _txtBearing.Enter += new EventHandler(txtBearing_Enter);
            _txtRange = new TextBox();
            _txtRange.TextChanged += new EventHandler(txtRange_TextChanged);
            _txtRange.KeyPress += new KeyPressEventHandler(txtRange_KeyPress);
            _txtRange.Validating += new System.ComponentModel.CancelEventHandler(txtRange_Validating);
            _txtRange.Enter += new EventHandler(txtRange_Enter);
            _txtCourse2 = new TextBox();
            _txtCourse2.TextChanged += new EventHandler(txtCourse2_TextChanged);
            _txtCourse2.KeyPress += new KeyPressEventHandler(txtCourse2_KeyPress);
            _txtCourse2.Validating += new System.ComponentModel.CancelEventHandler(txtCourse2_Validating);
            _txtCourse2.Enter += new EventHandler(txtCourse2_Enter);
            _txtSpeed2 = new TextBox();
            _txtSpeed2.TextChanged += new EventHandler(txtSpeed2_TextChanged);
            _txtSpeed2.KeyPress += new KeyPressEventHandler(txtSpeed2_KeyPress);
            _txtSpeed2.Validating += new System.ComponentModel.CancelEventHandler(txtSpeed2_Validating);
            _txtSpeed2.Enter += new EventHandler(txtSpeed2_Enter);
            _txtCourse1 = new TextBox();
            _txtCourse1.TextChanged += new EventHandler(txtCourse1_TextChanged);
            _txtCourse1.KeyPress += new KeyPressEventHandler(txtCourse1_KeyPress);
            _txtCourse1.Validating += new System.ComponentModel.CancelEventHandler(txtCourse1_Validating);
            _txtCourse1.Enter += new EventHandler(txtCourse1_Enter);
            _txtSpeed1 = new TextBox();
            _txtSpeed1.TextChanged += new EventHandler(txtSpeed1_TextChanged);
            _txtSpeed1.KeyPress += new KeyPressEventHandler(txtSpeed1_KeyPress);
            _txtSpeed1.Validating += new System.ComponentModel.CancelEventHandler(txtSpeed1_Validating);
            _txtSpeed1.Enter += new EventHandler(txtSpeed1_Enter);
            _txtBearing2 = new TextBox();
            _txtBearing2.TextChanged += new EventHandler(txtBearing2_TextChanged);
            _txtBearing2.KeyPress += new KeyPressEventHandler(txtBearing2_KeyPress);
            _txtBearing2.Validating += new System.ComponentModel.CancelEventHandler(txtBearing2_Validating);
            _txtBearing2.Enter += new EventHandler(txtBearing2_Enter);
            _txtRange2 = new TextBox();
            _txtRange2.TextChanged += new EventHandler(txtRange2_TextChanged);
            _txtRange2.KeyPress += new KeyPressEventHandler(txtRange2_KeyPress);
            _txtRange2.Validating += new System.ComponentModel.CancelEventHandler(txtRange2_Validating);
            _txtRange2.Enter += new EventHandler(txtRange2_Enter);
            _txtTime2 = new TextBox();
            _txtTime2.TextChanged += new EventHandler(txtTime2_TextChanged);
            _txtTime2.KeyPress += new KeyPressEventHandler(txtTime2_KeyPress);
            _txtTime2.Validating += new System.ComponentModel.CancelEventHandler(txtTime2_Validating);
            _txtTime2.Enter += new EventHandler(txtTime2_Enter);
            _txtBearing1 = new TextBox();
            _txtBearing1.TextChanged += new EventHandler(txtBearing1_TextChanged);
            _txtBearing1.KeyPress += new KeyPressEventHandler(txtBearing1_KeyPress);
            _txtBearing1.Validating += new System.ComponentModel.CancelEventHandler(txtBearing1_Validating);
            _txtBearing1.Enter += new EventHandler(txtBearing1_Enter);
            _txtRange1 = new TextBox();
            _txtRange1.TextChanged += new EventHandler(txtRange1_TextChanged);
            _txtRange1.KeyPress += new KeyPressEventHandler(txtRange1_KeyPress);
            _txtRange1.Validating += new System.ComponentModel.CancelEventHandler(txtRange1_Validating);
            _txtRange1.Enter += new EventHandler(txtRange1_Enter);
            _txtTime1 = new TextBox();
            _txtTime1.TextChanged += new EventHandler(txtTime1_TextChanged);
            _txtTime1.KeyPress += new KeyPressEventHandler(txtTime1_KeyPress);
            _txtTime1.Validating += new System.ComponentModel.CancelEventHandler(txtTime1_Validating);
            _txtTime1.Enter += new EventHandler(txtTime1_Enter);
            _cmdClear = new Button();
            _cmdClear.Click += new EventHandler(cmdClear_Click);
            Frame1 = new GroupBox();
            _optWindApp = new RadioButton();
            _optWindApp.CheckedChanged += new EventHandler(optWindApp_CheckedChanged);
            _optWind = new RadioButton();
            _optWind.CheckedChanged += new EventHandler(optWind_CheckedChanged);
            _optCPATypeB = new RadioButton();
            _optCPATypeB.CheckedChanged += new EventHandler(optCPATypeB_CheckedChanged);
            _optCPATypeA = new RadioButton();
            _optCPATypeA.CheckedChanged += new EventHandler(optCPATypeA_CheckedChanged);
            _cmdCalculate = new Button();
            _cmdCalculate.Click += new EventHandler(cmdCalculate_Click);
            Label22 = new Label();
            Label23 = new Label();
            Label21 = new Label();
            Label20 = new Label();
            Label19 = new Label();
            Label18 = new Label();
            Label17 = new Label();
            Label16 = new Label();
            Label15 = new Label();
            Label8 = new Label();
            Label7 = new Label();
            Label14 = new Label();
            Label13 = new Label();
            Label12 = new Label();
            Label11 = new Label();
            Label10 = new Label();
            Label9 = new Label();
            Label6 = new Label();
            Label5 = new Label();
            Label4 = new Label();
            Label2 = new Label();
            Label3 = new Label();
            Label1 = new Label();
            txtMoB = new TextBox();
            _ExitBtn = new Button();
            _ExitBtn.Click += new EventHandler(ExitBtn_Click);
            PictureBox1 = new PictureBox();
            Frame1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtWindDir
            // 
            _txtWindDir.AcceptsReturn = true;
            _txtWindDir.BackColor = SystemColors.Window;
            _txtWindDir.Cursor = Cursors.IBeam;
            _txtWindDir.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtWindDir.ForeColor = SystemColors.WindowText;
            _txtWindDir.Location = new Point(541, 141);
            _txtWindDir.MaxLength = 6;
            _txtWindDir.Name = "_txtWindDir";
            _txtWindDir.RightToLeft = RightToLeft.No;
            _txtWindDir.Size = new Size(41, 20);
            _txtWindDir.TabIndex = 45;
            ToolTip1.SetToolTip(_txtWindDir, "Range +/- 0 to 359.9");
            _txtWindDir.Visible = false;
            // 
            // txtWindSpeed
            // 
            _txtWindSpeed.AcceptsReturn = true;
            _txtWindSpeed.BackColor = SystemColors.Window;
            _txtWindSpeed.Cursor = Cursors.IBeam;
            _txtWindSpeed.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtWindSpeed.ForeColor = SystemColors.WindowText;
            _txtWindSpeed.Location = new Point(541, 117);
            _txtWindSpeed.MaxLength = 4;
            _txtWindSpeed.Name = "_txtWindSpeed";
            _txtWindSpeed.RightToLeft = RightToLeft.No;
            _txtWindSpeed.Size = new Size(33, 20);
            _txtWindSpeed.TabIndex = 44;
            ToolTip1.SetToolTip(_txtWindSpeed, "Range 0 to 99.9");
            _txtWindSpeed.Visible = false;
            // 
            // txtSpeed
            // 
            _txtSpeed.AcceptsReturn = true;
            _txtSpeed.BackColor = SystemColors.Window;
            _txtSpeed.Cursor = Cursors.IBeam;
            _txtSpeed.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtSpeed.ForeColor = SystemColors.WindowText;
            _txtSpeed.Location = new Point(541, 93);
            _txtSpeed.MaxLength = 4;
            _txtSpeed.Name = "_txtSpeed";
            _txtSpeed.RightToLeft = RightToLeft.No;
            _txtSpeed.Size = new Size(33, 20);
            _txtSpeed.TabIndex = 43;
            ToolTip1.SetToolTip(_txtSpeed, "Range 0 to 99.9");
            _txtSpeed.Visible = false;
            // 
            // txtCourse
            // 
            _txtCourse.AcceptsReturn = true;
            _txtCourse.BackColor = SystemColors.Window;
            _txtCourse.Cursor = Cursors.IBeam;
            _txtCourse.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtCourse.ForeColor = SystemColors.WindowText;
            _txtCourse.Location = new Point(541, 69);
            _txtCourse.MaxLength = 5;
            _txtCourse.Name = "_txtCourse";
            _txtCourse.RightToLeft = RightToLeft.No;
            _txtCourse.Size = new Size(41, 20);
            _txtCourse.TabIndex = 42;
            ToolTip1.SetToolTip(_txtCourse, "Range 0 to 359.9");
            _txtCourse.Visible = false;
            // 
            // txtV1Speed
            // 
            _txtV1Speed.AcceptsReturn = true;
            _txtV1Speed.BackColor = SystemColors.Window;
            _txtV1Speed.Cursor = Cursors.IBeam;
            _txtV1Speed.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtV1Speed.ForeColor = SystemColors.WindowText;
            _txtV1Speed.Location = new Point(509, 165);
            _txtV1Speed.MaxLength = 4;
            _txtV1Speed.Name = "_txtV1Speed";
            _txtV1Speed.RightToLeft = RightToLeft.No;
            _txtV1Speed.Size = new Size(33, 20);
            _txtV1Speed.TabIndex = 13;
            ToolTip1.SetToolTip(_txtV1Speed, "Range 0 to 99.9");
            // 
            // txtV1Course
            // 
            _txtV1Course.AcceptsReturn = true;
            _txtV1Course.BackColor = SystemColors.Window;
            _txtV1Course.Cursor = Cursors.IBeam;
            _txtV1Course.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtV1Course.ForeColor = SystemColors.WindowText;
            _txtV1Course.Location = new Point(509, 141);
            _txtV1Course.MaxLength = 5;
            _txtV1Course.Name = "_txtV1Course";
            _txtV1Course.RightToLeft = RightToLeft.No;
            _txtV1Course.Size = new Size(41, 20);
            _txtV1Course.TabIndex = 12;
            ToolTip1.SetToolTip(_txtV1Course, "Range 0 to 359.9");
            // 
            // cmdPrint
            // 
            _cmdPrint.BackColor = SystemColors.Control;
            _cmdPrint.Cursor = Cursors.Default;
            _cmdPrint.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdPrint.ForeColor = SystemColors.ControlText;
            _cmdPrint.Image = (Image)resources.GetObject("cmdPrint.Image");
            _cmdPrint.Location = new Point(677, 0);
            _cmdPrint.Name = "_cmdPrint";
            _cmdPrint.RightToLeft = RightToLeft.No;
            _cmdPrint.Size = new Size(21, 21);
            _cmdPrint.TabIndex = 33;
            _cmdPrint.TextAlign = ContentAlignment.BottomCenter;
            ToolTip1.SetToolTip(_cmdPrint, "Print window");
            _cmdPrint.UseVisualStyleBackColor = false;
            // 
            // txtBearing
            // 
            _txtBearing.AcceptsReturn = true;
            _txtBearing.BackColor = SystemColors.Window;
            _txtBearing.Cursor = Cursors.IBeam;
            _txtBearing.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtBearing.ForeColor = SystemColors.WindowText;
            _txtBearing.Location = new Point(509, 125);
            _txtBearing.MaxLength = 5;
            _txtBearing.Name = "_txtBearing";
            _txtBearing.RightToLeft = RightToLeft.No;
            _txtBearing.Size = new Size(41, 20);
            _txtBearing.TabIndex = 25;
            ToolTip1.SetToolTip(_txtBearing, "Range 0 to 359.9");
            _txtBearing.Visible = false;
            // 
            // txtRange
            // 
            _txtRange.AcceptsReturn = true;
            _txtRange.BackColor = SystemColors.Window;
            _txtRange.Cursor = Cursors.IBeam;
            _txtRange.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtRange.ForeColor = SystemColors.WindowText;
            _txtRange.Location = new Point(509, 149);
            _txtRange.MaxLength = 5;
            _txtRange.Name = "_txtRange";
            _txtRange.RightToLeft = RightToLeft.No;
            _txtRange.Size = new Size(41, 20);
            _txtRange.TabIndex = 26;
            ToolTip1.SetToolTip(_txtRange, "Range 0 to 99.99");
            _txtRange.Visible = false;
            // 
            // txtCourse2
            // 
            _txtCourse2.AcceptsReturn = true;
            _txtCourse2.BackColor = SystemColors.Window;
            _txtCourse2.Cursor = Cursors.IBeam;
            _txtCourse2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtCourse2.ForeColor = SystemColors.WindowText;
            _txtCourse2.Location = new Point(557, 69);
            _txtCourse2.MaxLength = 5;
            _txtCourse2.Name = "_txtCourse2";
            _txtCourse2.RightToLeft = RightToLeft.No;
            _txtCourse2.Size = new Size(41, 20);
            _txtCourse2.TabIndex = 23;
            ToolTip1.SetToolTip(_txtCourse2, "Range 0 to 359.9");
            _txtCourse2.Visible = false;
            // 
            // txtSpeed2
            // 
            _txtSpeed2.AcceptsReturn = true;
            _txtSpeed2.BackColor = SystemColors.Window;
            _txtSpeed2.Cursor = Cursors.IBeam;
            _txtSpeed2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtSpeed2.ForeColor = SystemColors.WindowText;
            _txtSpeed2.Location = new Point(557, 93);
            _txtSpeed2.MaxLength = 4;
            _txtSpeed2.Name = "_txtSpeed2";
            _txtSpeed2.RightToLeft = RightToLeft.No;
            _txtSpeed2.Size = new Size(33, 20);
            _txtSpeed2.TabIndex = 24;
            ToolTip1.SetToolTip(_txtSpeed2, "Range 0 to 99.9");
            _txtSpeed2.Visible = false;
            // 
            // txtCourse1
            // 
            _txtCourse1.AcceptsReturn = true;
            _txtCourse1.BackColor = SystemColors.Window;
            _txtCourse1.Cursor = Cursors.IBeam;
            _txtCourse1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtCourse1.ForeColor = SystemColors.WindowText;
            _txtCourse1.Location = new Point(437, 69);
            _txtCourse1.MaxLength = 5;
            _txtCourse1.Name = "_txtCourse1";
            _txtCourse1.RightToLeft = RightToLeft.No;
            _txtCourse1.Size = new Size(41, 20);
            _txtCourse1.TabIndex = 21;
            ToolTip1.SetToolTip(_txtCourse1, "Range 0 to 359.9");
            _txtCourse1.Visible = false;
            // 
            // txtSpeed1
            // 
            _txtSpeed1.AcceptsReturn = true;
            _txtSpeed1.BackColor = SystemColors.Window;
            _txtSpeed1.Cursor = Cursors.IBeam;
            _txtSpeed1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtSpeed1.ForeColor = SystemColors.WindowText;
            _txtSpeed1.Location = new Point(437, 93);
            _txtSpeed1.MaxLength = 4;
            _txtSpeed1.Name = "_txtSpeed1";
            _txtSpeed1.RightToLeft = RightToLeft.No;
            _txtSpeed1.Size = new Size(33, 20);
            _txtSpeed1.TabIndex = 22;
            ToolTip1.SetToolTip(_txtSpeed1, "Range 0 to 99.9");
            _txtSpeed1.Visible = false;
            // 
            // txtBearing2
            // 
            _txtBearing2.AcceptsReturn = true;
            _txtBearing2.BackColor = SystemColors.Window;
            _txtBearing2.Cursor = Cursors.IBeam;
            _txtBearing2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtBearing2.ForeColor = SystemColors.WindowText;
            _txtBearing2.Location = new Point(605, 93);
            _txtBearing2.MaxLength = 5;
            _txtBearing2.Name = "_txtBearing2";
            _txtBearing2.RightToLeft = RightToLeft.No;
            _txtBearing2.Size = new Size(41, 20);
            _txtBearing2.TabIndex = 10;
            ToolTip1.SetToolTip(_txtBearing2, "Range 0 to 359.9");
            // 
            // txtRange2
            // 
            _txtRange2.AcceptsReturn = true;
            _txtRange2.BackColor = SystemColors.Window;
            _txtRange2.Cursor = Cursors.IBeam;
            _txtRange2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtRange2.ForeColor = SystemColors.WindowText;
            _txtRange2.Location = new Point(605, 117);
            _txtRange2.MaxLength = 5;
            _txtRange2.Name = "_txtRange2";
            _txtRange2.RightToLeft = RightToLeft.No;
            _txtRange2.Size = new Size(41, 20);
            _txtRange2.TabIndex = 11;
            ToolTip1.SetToolTip(_txtRange2, "Range 0 to 99.99");
            // 
            // txtTime2
            // 
            _txtTime2.AcceptsReturn = true;
            _txtTime2.BackColor = SystemColors.Window;
            _txtTime2.Cursor = Cursors.IBeam;
            _txtTime2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtTime2.ForeColor = SystemColors.WindowText;
            _txtTime2.Location = new Point(605, 69);
            _txtTime2.MaxLength = 4;
            _txtTime2.Name = "_txtTime2";
            _txtTime2.RightToLeft = RightToLeft.No;
            _txtTime2.Size = new Size(33, 20);
            _txtTime2.TabIndex = 9;
            ToolTip1.SetToolTip(_txtTime2, "Range 0000 to 2359");
            // 
            // txtBearing1
            // 
            _txtBearing1.AcceptsReturn = true;
            _txtBearing1.BackColor = SystemColors.Window;
            _txtBearing1.Cursor = Cursors.IBeam;
            _txtBearing1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtBearing1.ForeColor = SystemColors.WindowText;
            _txtBearing1.Location = new Point(429, 93);
            _txtBearing1.MaxLength = 5;
            _txtBearing1.Name = "_txtBearing1";
            _txtBearing1.RightToLeft = RightToLeft.No;
            _txtBearing1.Size = new Size(41, 20);
            _txtBearing1.TabIndex = 4;
            ToolTip1.SetToolTip(_txtBearing1, "Range 0 to 359.9");
            // 
            // txtRange1
            // 
            _txtRange1.AcceptsReturn = true;
            _txtRange1.BackColor = SystemColors.Window;
            _txtRange1.Cursor = Cursors.IBeam;
            _txtRange1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtRange1.ForeColor = SystemColors.WindowText;
            _txtRange1.Location = new Point(429, 117);
            _txtRange1.MaxLength = 5;
            _txtRange1.Name = "_txtRange1";
            _txtRange1.RightToLeft = RightToLeft.No;
            _txtRange1.Size = new Size(41, 20);
            _txtRange1.TabIndex = 5;
            ToolTip1.SetToolTip(_txtRange1, "Range 0 to 99.99");
            // 
            // txtTime1
            // 
            _txtTime1.AcceptsReturn = true;
            _txtTime1.BackColor = SystemColors.Window;
            _txtTime1.Cursor = Cursors.IBeam;
            _txtTime1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtTime1.ForeColor = SystemColors.WindowText;
            _txtTime1.Location = new Point(429, 69);
            _txtTime1.MaxLength = 4;
            _txtTime1.Name = "_txtTime1";
            _txtTime1.RightToLeft = RightToLeft.No;
            _txtTime1.Size = new Size(33, 20);
            _txtTime1.TabIndex = 3;
            ToolTip1.SetToolTip(_txtTime1, "Range 0000 to 2359");
            // 
            // cmdClear
            // 
            _cmdClear.BackColor = SystemColors.Control;
            _cmdClear.Cursor = Cursors.Default;
            _cmdClear.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdClear.ForeColor = SystemColors.ControlText;
            _cmdClear.Location = new Point(613, 203);
            _cmdClear.Name = "_cmdClear";
            _cmdClear.RightToLeft = RightToLeft.No;
            _cmdClear.Size = new Size(81, 25);
            _cmdClear.TabIndex = 34;
            _cmdClear.Text = "Clea&r";
            _cmdClear.UseVisualStyleBackColor = false;
            // 
            // Frame1
            // 
            Frame1.BackColor = SystemColors.Window;
            Frame1.Controls.Add(_optWindApp);
            Frame1.Controls.Add(_optWind);
            Frame1.Controls.Add(_optCPATypeB);
            Frame1.Controls.Add(_optCPATypeA);
            Frame1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Frame1.ForeColor = SystemColors.ControlText;
            Frame1.Location = new Point(8, 32);
            Frame1.Name = "Frame1";
            Frame1.Padding = new Padding(0);
            Frame1.RightToLeft = RightToLeft.No;
            Frame1.Size = new Size(239, 265);
            Frame1.TabIndex = 27;
            Frame1.TabStop = false;
            Frame1.Text = "Type of calculation";
            // 
            // optWindApp
            // 
            _optWindApp.BackColor = SystemColors.Window;
            _optWindApp.Cursor = Cursors.Default;
            _optWindApp.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optWindApp.ForeColor = SystemColors.ControlText;
            _optWindApp.Location = new Point(3, 192);
            _optWindApp.Name = "_optWindApp";
            _optWindApp.RightToLeft = RightToLeft.No;
            _optWindApp.Size = new Size(201, 57);
            _optWindApp.TabIndex = 46;
            _optWindApp.TabStop = true;
            _optWindApp.Text = "Direction and speed of apparent wind (relative) if true wind direction and speed " + "are known";
            _optWindApp.UseVisualStyleBackColor = false;
            // 
            // optWind
            // 
            _optWind.BackColor = SystemColors.Window;
            _optWind.Cursor = Cursors.Default;
            _optWind.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optWind.ForeColor = SystemColors.ControlText;
            _optWind.Location = new Point(3, 141);
            _optWind.Name = "_optWind";
            _optWind.RightToLeft = RightToLeft.No;
            _optWind.Size = new Size(211, 55);
            _optWind.TabIndex = 37;
            _optWind.TabStop = true;
            _optWind.Text = "Direction and speed of true wind if apparent wind direction (relative) and speed " + "are known";
            _optWind.UseVisualStyleBackColor = false;
            // 
            // optCPATypeB
            // 
            _optCPATypeB.BackColor = SystemColors.Window;
            _optCPATypeB.Cursor = Cursors.Default;
            _optCPATypeB.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optCPATypeB.ForeColor = SystemColors.ControlText;
            _optCPATypeB.Location = new Point(1, 69);
            _optCPATypeB.Name = "_optCPATypeB";
            _optCPATypeB.RightToLeft = RightToLeft.No;
            _optCPATypeB.Size = new Size(215, 75);
            _optCPATypeB.TabIndex = 29;
            _optCPATypeB.TabStop = true;
            _optCPATypeB.Text = "Closest Point of Approach and related info if course and speed of Vessel 1 and Ve" + "ssel 2  and bearing and range from Vessel 1 to Vessel 2 at one time are known";
            _optCPATypeB.UseVisualStyleBackColor = false;
            // 
            // optCPATypeA
            // 
            _optCPATypeA.BackColor = SystemColors.Window;
            _optCPATypeA.Checked = true;
            _optCPATypeA.Cursor = Cursors.Default;
            _optCPATypeA.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optCPATypeA.ForeColor = SystemColors.ControlText;
            _optCPATypeA.Location = new Point(3, 16);
            _optCPATypeA.Name = "_optCPATypeA";
            _optCPATypeA.RightToLeft = RightToLeft.No;
            _optCPATypeA.Size = new Size(212, 59);
            _optCPATypeA.TabIndex = 28;
            _optCPATypeA.TabStop = true;
            _optCPATypeA.Text = "Closest Point of Approach and related info if range and bearing from Vessel 1  to" + " Vessel 2  at two times are known";
            _optCPATypeA.UseVisualStyleBackColor = false;
            // 
            // cmdCalculate
            // 
            _cmdCalculate.BackColor = Color.Blue;
            _cmdCalculate.Cursor = Cursors.Default;
            _cmdCalculate.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdCalculate.ForeColor = Color.White;
            _cmdCalculate.Location = new Point(437, 203);
            _cmdCalculate.Name = "_cmdCalculate";
            _cmdCalculate.RightToLeft = RightToLeft.No;
            _cmdCalculate.Size = new Size(97, 25);
            _cmdCalculate.TabIndex = 14;
            _cmdCalculate.Text = "&Calculate";
            _cmdCalculate.UseVisualStyleBackColor = false;
            // 
            // Label22
            // 
            Label22.BackColor = SystemColors.Window;
            Label22.Cursor = Cursors.Default;
            Label22.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label22.ForeColor = SystemColors.ControlText;
            Label22.Location = new Point(427, 117);
            Label22.Name = "Label22";
            Label22.RightToLeft = RightToLeft.No;
            Label22.Size = new Size(115, 17);
            Label22.TabIndex = 48;
            Label22.Text = "True wind speed (kn)";
            Label22.Visible = false;
            // 
            // Label23
            // 
            Label23.BackColor = SystemColors.Window;
            Label23.Cursor = Cursors.Default;
            Label23.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label23.ForeColor = SystemColors.ControlText;
            Label23.Location = new Point(440, 141);
            Label23.Name = "Label23";
            Label23.RightToLeft = RightToLeft.No;
            Label23.Size = new Size(89, 17);
            Label23.TabIndex = 47;
            Label23.Text = "True wind from (°)";
            Label23.Visible = false;
            // 
            // Label21
            // 
            Label21.BackColor = SystemColors.Window;
            Label21.Cursor = Cursors.Default;
            Label21.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label21.ForeColor = SystemColors.ControlText;
            Label21.Location = new Point(373, 141);
            Label21.Name = "Label21";
            Label21.RightToLeft = RightToLeft.No;
            Label21.Size = new Size(178, 17);
            Label21.TabIndex = 41;
            Label21.Text = "Apparent wind from  (° Relative)";
            Label21.Visible = false;
            // 
            // Label20
            // 
            Label20.BackColor = SystemColors.Window;
            Label20.Cursor = Cursors.Default;
            Label20.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label20.ForeColor = SystemColors.ControlText;
            Label20.Location = new Point(405, 117);
            Label20.Name = "Label20";
            Label20.RightToLeft = RightToLeft.No;
            Label20.Size = new Size(129, 17);
            Label20.TabIndex = 40;
            Label20.Text = "Apparent wind speed (kn)";
            Label20.Visible = false;
            // 
            // Label19
            // 
            Label19.BackColor = SystemColors.Window;
            Label19.Cursor = Cursors.Default;
            Label19.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label19.ForeColor = SystemColors.ControlText;
            Label19.Location = new Point(443, 93);
            Label19.Name = "Label19";
            Label19.RightToLeft = RightToLeft.No;
            Label19.Size = new Size(99, 17);
            Label19.TabIndex = 39;
            Label19.Text = "Vessel Speed (kn)";
            Label19.Visible = false;
            // 
            // Label18
            // 
            Label18.BackColor = SystemColors.Window;
            Label18.Cursor = Cursors.Default;
            Label18.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label18.ForeColor = SystemColors.ControlText;
            Label18.Location = new Point(421, 69);
            Label18.Name = "Label18";
            Label18.RightToLeft = RightToLeft.No;
            Label18.Size = new Size(120, 17);
            Label18.TabIndex = 38;
            Label18.Text = "Vessel Course (° True)";
            Label18.Visible = false;
            // 
            // Label17
            // 
            Label17.BackColor = SystemColors.Window;
            Label17.Cursor = Cursors.Default;
            Label17.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label17.ForeColor = SystemColors.ControlText;
            Label17.Location = new Point(405, 165);
            Label17.Name = "Label17";
            Label17.RightToLeft = RightToLeft.No;
            Label17.Size = new Size(97, 17);
            Label17.TabIndex = 36;
            Label17.Text = "Vessel 1 Speed (kn)";
            // 
            // Label16
            // 
            Label16.BackColor = SystemColors.Window;
            Label16.Cursor = Cursors.Default;
            Label16.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label16.ForeColor = SystemColors.ControlText;
            Label16.Location = new Point(405, 141);
            Label16.Name = "Label16";
            Label16.RightToLeft = RightToLeft.No;
            Label16.Size = new Size(105, 17);
            Label16.TabIndex = 35;
            Label16.Text = "Vessel 1 Course (°)";
            // 
            // Label15
            // 
            Label15.BackColor = SystemColors.Window;
            Label15.Cursor = Cursors.Default;
            Label15.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label15.ForeColor = SystemColors.ControlText;
            Label15.Location = new Point(517, 48);
            Label15.Name = "Label15";
            Label15.RightToLeft = RightToLeft.No;
            Label15.Size = new Size(49, 17);
            Label15.TabIndex = 32;
            Label15.Text = "Vessel 2";
            Label15.Visible = false;
            // 
            // Label8
            // 
            Label8.BackColor = SystemColors.Window;
            Label8.Cursor = Cursors.Default;
            Label8.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label8.ForeColor = SystemColors.ControlText;
            Label8.Location = new Point(397, 48);
            Label8.Name = "Label8";
            Label8.RightToLeft = RightToLeft.No;
            Label8.Size = new Size(49, 17);
            Label8.TabIndex = 31;
            Label8.Text = "Vessel 1";
            Label8.Visible = false;
            // 
            // Label7
            // 
            Label7.BackColor = SystemColors.Window;
            Label7.Cursor = Cursors.Default;
            Label7.Font = new Font("Arial", 14.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label7.ForeColor = SystemColors.ControlText;
            Label7.Location = new Point(79, 8);
            Label7.Name = "Label7";
            Label7.RightToLeft = RightToLeft.No;
            Label7.Size = new Size(515, 21);
            Label7.TabIndex = 30;
            Label7.Text = "Closest Point of Approach and True Wind Calculations";
            Label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label14
            // 
            Label14.BackColor = SystemColors.Window;
            Label14.Cursor = Cursors.Default;
            Label14.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label14.ForeColor = SystemColors.ControlText;
            Label14.Location = new Point(445, 125);
            Label14.Name = "Label14";
            Label14.RightToLeft = RightToLeft.No;
            Label14.Size = new Size(57, 17);
            Label14.TabIndex = 20;
            Label14.Text = "Bearing (°)";
            Label14.Visible = false;
            // 
            // Label13
            // 
            Label13.BackColor = SystemColors.Window;
            Label13.Cursor = Cursors.Default;
            Label13.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label13.ForeColor = SystemColors.ControlText;
            Label13.Location = new Point(445, 149);
            Label13.Name = "Label13";
            Label13.RightToLeft = RightToLeft.No;
            Label13.Size = new Size(65, 17);
            Label13.TabIndex = 19;
            Label13.Text = "Range (nm)";
            Label13.Visible = false;
            // 
            // Label12
            // 
            Label12.BackColor = SystemColors.Window;
            Label12.Cursor = Cursors.Default;
            Label12.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label12.ForeColor = SystemColors.ControlText;
            Label12.Location = new Point(493, 69);
            Label12.Name = "Label12";
            Label12.RightToLeft = RightToLeft.No;
            Label12.Size = new Size(65, 17);
            Label12.TabIndex = 18;
            Label12.Text = "Course2 (°)";
            Label12.Visible = false;
            // 
            // Label11
            // 
            Label11.BackColor = SystemColors.Window;
            Label11.Cursor = Cursors.Default;
            Label11.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label11.ForeColor = SystemColors.ControlText;
            Label11.Location = new Point(493, 93);
            Label11.Name = "Label11";
            Label11.RightToLeft = RightToLeft.No;
            Label11.Size = new Size(65, 17);
            Label11.TabIndex = 17;
            Label11.Text = "Speed2 (kn)";
            Label11.Visible = false;
            // 
            // Label10
            // 
            Label10.BackColor = SystemColors.Window;
            Label10.Cursor = Cursors.Default;
            Label10.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label10.ForeColor = SystemColors.ControlText;
            Label10.Location = new Point(373, 69);
            Label10.Name = "Label10";
            Label10.RightToLeft = RightToLeft.No;
            Label10.Size = new Size(57, 17);
            Label10.TabIndex = 16;
            Label10.Text = "Course1 (°)";
            Label10.Visible = false;
            // 
            // Label9
            // 
            Label9.BackColor = SystemColors.Window;
            Label9.Cursor = Cursors.Default;
            Label9.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label9.ForeColor = SystemColors.ControlText;
            Label9.Location = new Point(373, 93);
            Label9.Name = "Label9";
            Label9.RightToLeft = RightToLeft.No;
            Label9.Size = new Size(65, 17);
            Label9.TabIndex = 15;
            Label9.Text = "Speed1 (kn)";
            Label9.Visible = false;
            // 
            // Label6
            // 
            Label6.BackColor = SystemColors.Window;
            Label6.Cursor = Cursors.Default;
            Label6.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label6.ForeColor = SystemColors.ControlText;
            Label6.Location = new Point(493, 93);
            Label6.Name = "Label6";
            Label6.RightToLeft = RightToLeft.No;
            Label6.Size = new Size(105, 17);
            Label6.TabIndex = 8;
            Label6.Text = "Bearing at Time2 (°)";
            // 
            // Label5
            // 
            Label5.BackColor = SystemColors.Window;
            Label5.Cursor = Cursors.Default;
            Label5.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label5.ForeColor = SystemColors.ControlText;
            Label5.Location = new Point(493, 117);
            Label5.Name = "Label5";
            Label5.RightToLeft = RightToLeft.No;
            Label5.Size = new Size(113, 17);
            Label5.TabIndex = 7;
            Label5.Text = "Range at Time2 (nm)";
            // 
            // Label4
            // 
            Label4.BackColor = SystemColors.Window;
            Label4.Cursor = Cursors.Default;
            Label4.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.ForeColor = SystemColors.ControlText;
            Label4.Location = new Point(493, 69);
            Label4.Name = "Label4";
            Label4.RightToLeft = RightToLeft.No;
            Label4.Size = new Size(73, 17);
            Label4.TabIndex = 6;
            Label4.Text = "Time2 (hhmm)";
            // 
            // Label2
            // 
            Label2.BackColor = SystemColors.Window;
            Label2.Cursor = Cursors.Default;
            Label2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = SystemColors.ControlText;
            Label2.Location = new Point(317, 117);
            Label2.Name = "Label2";
            Label2.RightToLeft = RightToLeft.No;
            Label2.Size = new Size(113, 17);
            Label2.TabIndex = 2;
            Label2.Text = "Range at Time1 (nm)";
            // 
            // Label3
            // 
            Label3.BackColor = SystemColors.Window;
            Label3.Cursor = Cursors.Default;
            Label3.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.ForeColor = SystemColors.ControlText;
            Label3.Location = new Point(317, 93);
            Label3.Name = "Label3";
            Label3.RightToLeft = RightToLeft.No;
            Label3.Size = new Size(97, 17);
            Label3.TabIndex = 1;
            Label3.Text = "Bearing at Time1 (°)";
            // 
            // Label1
            // 
            Label1.BackColor = SystemColors.Window;
            Label1.Cursor = Cursors.Default;
            Label1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = SystemColors.ControlText;
            Label1.Location = new Point(317, 69);
            Label1.Name = "Label1";
            Label1.RightToLeft = RightToLeft.No;
            Label1.Size = new Size(73, 17);
            Label1.TabIndex = 0;
            Label1.Text = "Time1 (hhmm)";
            // 
            // txtMoB
            // 
            txtMoB.Location = new Point(253, 234);
            txtMoB.Multiline = true;
            txtMoB.Name = "txtMoB";
            txtMoB.ReadOnly = true;
            txtMoB.ScrollBars = ScrollBars.Vertical;
            txtMoB.Size = new Size(441, 60);
            txtMoB.TabIndex = 50;
            txtMoB.TextAlign = HorizontalAlignment.Center;
            // 
            // ExitBtn
            // 
            _ExitBtn.BackColor = Color.Red;
            _ExitBtn.Cursor = Cursors.Default;
            _ExitBtn.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _ExitBtn.ForeColor = SystemColors.ControlLightLight;
            _ExitBtn.Location = new Point(613, 300);
            _ExitBtn.Name = "_ExitBtn";
            _ExitBtn.RightToLeft = RightToLeft.No;
            _ExitBtn.Size = new Size(81, 25);
            _ExitBtn.TabIndex = 51;
            _ExitBtn.Text = "Exit";
            _ExitBtn.UseVisualStyleBackColor = false;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.ABC_white;
            PictureBox1.Location = new Point(213, 303);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(316, 50);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 102;
            PictureBox1.TabStop = false;
            // 
            // FormMoBoard
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(697, 361);
            Controls.Add(PictureBox1);
            Controls.Add(_ExitBtn);
            Controls.Add(txtMoB);
            Controls.Add(_txtWindDir);
            Controls.Add(_txtWindSpeed);
            Controls.Add(_txtSpeed);
            Controls.Add(_txtCourse);
            Controls.Add(_txtV1Speed);
            Controls.Add(_txtV1Course);
            Controls.Add(_cmdClear);
            Controls.Add(_cmdPrint);
            Controls.Add(Frame1);
            Controls.Add(_txtBearing);
            Controls.Add(_txtRange);
            Controls.Add(_txtCourse2);
            Controls.Add(_txtSpeed2);
            Controls.Add(_txtCourse1);
            Controls.Add(_txtSpeed1);
            Controls.Add(_cmdCalculate);
            Controls.Add(_txtBearing2);
            Controls.Add(_txtRange2);
            Controls.Add(_txtTime2);
            Controls.Add(_txtBearing1);
            Controls.Add(_txtRange1);
            Controls.Add(_txtTime1);
            Controls.Add(Label22);
            Controls.Add(Label23);
            Controls.Add(Label21);
            Controls.Add(Label20);
            Controls.Add(Label19);
            Controls.Add(Label18);
            Controls.Add(Label17);
            Controls.Add(Label16);
            Controls.Add(Label15);
            Controls.Add(Label8);
            Controls.Add(Label7);
            Controls.Add(Label14);
            Controls.Add(Label13);
            Controls.Add(Label12);
            Controls.Add(Label11);
            Controls.Add(Label10);
            Controls.Add(Label9);
            Controls.Add(Label6);
            Controls.Add(Label5);
            Controls.Add(Label4);
            Controls.Add(Label2);
            Controls.Add(Label3);
            Controls.Add(Label1);
            Cursor = Cursors.Default;
            Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(3, 29);
            MaximizeBox = false;
            Name = "FormMoBoard";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MoBoard";
            Frame1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        internal TextBox txtMoB;
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

        internal PictureBox PictureBox1;
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}