using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    [DesignerGenerated()]
    internal partial class FormTwoBearings
    {
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        [DebuggerNonUserCode()]
        public FormTwoBearings() : base()
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
        // Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTwoBearings));
            ToolTip1 = new ToolTip(components);
            _cmdPrint = new Button();
            _cmdPrint.Click += new EventHandler(cmdPrint_Click);
            _txtCourse = new TextBox();
            _txtCourse.TextChanged += new EventHandler(txtCourse_TextChanged);
            _txtCourse.KeyPress += new KeyPressEventHandler(txtCourse_KeyPress);
            _txtCourse.Validating += new System.ComponentModel.CancelEventHandler(txtCourse_Validating);
            _txtCourse.Enter += new EventHandler(txtCourse_Enter);
            _txtDist = new TextBox();
            _txtDist.TextChanged += new EventHandler(txtDist_TextChanged);
            _txtDist.Enter += new EventHandler(txtDist_TextChanged);
            _txtDist.TextChanged += new EventHandler(txtDist_TextChanged);
            _txtDist.Enter += new EventHandler(txtDist_TextChanged);
            _txtDist.KeyPress += new KeyPressEventHandler(txtDist_KeyPress);
            _txtDist.Validating += new System.ComponentModel.CancelEventHandler(txtDist_Validating);
            _txtSpeed = new TextBox();
            _txtSpeed.TextChanged += new EventHandler(txtSpeed_TextChanged);
            _txtSpeed.KeyPress += new KeyPressEventHandler(txtSpeed_KeyPress);
            _txtSpeed.Validating += new System.ComponentModel.CancelEventHandler(txtSpeed_Validating);
            _txtSpeed.Enter += new EventHandler(txtSpeed_Enter);
            _txtTimeh = new TextBox();
            _txtTimeh.TextChanged += new EventHandler(txtTimeh_TextChanged);
            _txtTimeh.KeyPress += new KeyPressEventHandler(txtTimeh_KeyPress);
            _txtTimeh.Validating += new System.ComponentModel.CancelEventHandler(txtTimeh_Validating);
            _txtTimeh.Enter += new EventHandler(txtTimeh_Enter);
            _txtTimem = new TextBox();
            _txtTimem.TextChanged += new EventHandler(txtTimem_TextChanged);
            _txtTimem.KeyPress += new KeyPressEventHandler(txtTimem_KeyPress);
            _txtTimem.Validating += new System.ComponentModel.CancelEventHandler(txtTimem_Validating);
            _txtTimem.Enter += new EventHandler(txtTimem_Enter);
            _txtLog1 = new TextBox();
            _txtLog1.TextChanged += new EventHandler(txtLog1_TextChanged);
            _txtLog1.KeyPress += new KeyPressEventHandler(txtLog1_KeyPress);
            _txtLog1.Validating += new System.ComponentModel.CancelEventHandler(txtLog1_Validating);
            _txtLog1.Enter += new EventHandler(txtLog1_Enter);
            _txtLog2 = new TextBox();
            _txtLog2.TextChanged += new EventHandler(txtLog2_TextChanged);
            _txtLog2.KeyPress += new KeyPressEventHandler(txtLog2_KeyPress);
            _txtLog2.Validating += new System.ComponentModel.CancelEventHandler(txtLog2_Validating);
            _txtLog2.Enter += new EventHandler(txtLog2_Enter);
            _txtTime1 = new TextBox();
            _txtTime1.TextChanged += new EventHandler(txtTime1_TextChanged);
            _txtTime1.KeyPress += new KeyPressEventHandler(txtTime1_KeyPress);
            _txtTime1.Validating += new System.ComponentModel.CancelEventHandler(txtTime1_Validating);
            _txtTime1.Enter += new EventHandler(txtTime1_Enter);
            _txtTime2 = new TextBox();
            _txtTime2.TextChanged += new EventHandler(txtTime2_TextChanged);
            _txtTime2.KeyPress += new KeyPressEventHandler(txtTime2_KeyPress);
            _txtTime2.Validating += new System.ComponentModel.CancelEventHandler(txtTime2_Validating);
            _txtTime2.Enter += new EventHandler(txtTime2_Enter);
            _txtBearing2 = new TextBox();
            _txtBearing2.TextChanged += new EventHandler(txtBearing2_TextChanged);
            _txtBearing2.KeyPress += new KeyPressEventHandler(txtBearing2_KeyPress);
            _txtBearing2.Validating += new System.ComponentModel.CancelEventHandler(txtBearing2_Validating);
            _txtBearing2.Enter += new EventHandler(txtBearing2_Enter);
            _txtBearing1 = new TextBox();
            _txtBearing1.TextChanged += new EventHandler(txtBearing1_TextChanged);
            _txtBearing1.KeyPress += new KeyPressEventHandler(txtBearing1_KeyPress);
            _txtBearing1.Validating += new System.ComponentModel.CancelEventHandler(txtBearing1_Validating);
            _txtBearing1.Enter += new EventHandler(txtBearing1_Enter);
            _txtB1 = new TextBox();
            _txtB1.KeyPress += new KeyPressEventHandler(txtB1_KeyPress);
            _txtB1.Validating += new System.ComponentModel.CancelEventHandler(txtB1_Validating);
            _txtB1.Enter += new EventHandler(txtB1_Enter);
            _txtB1.TextChanged += new EventHandler(txtB2_TextChanged);
            _txtB2 = new TextBox();
            _txtB2.Enter += new EventHandler(txtB1_Enter);
            _txtB2.TextChanged += new EventHandler(txtB2_TextChanged);
            _txtB2.KeyPress += new KeyPressEventHandler(txtB2_KeyPress);
            _txtB2.Validating += new System.ComponentModel.CancelEventHandler(txtB2_Validating);
            _txtB3 = new TextBox();
            _txtB3.TextChanged += new EventHandler(txtB3_TextChanged);
            _txtB3.KeyPress += new KeyPressEventHandler(txtB3_KeyPress);
            _txtB3.Validating += new System.ComponentModel.CancelEventHandler(txtB3_Validating);
            _txtB3.Enter += new EventHandler(txtB3_Enter);
            _txtL2Min = new TextBox();
            _txtL2Min.TextChanged += new EventHandler(txtL2Min_TextChanged);
            _txtL2Min.KeyPress += new KeyPressEventHandler(txtL2Min_KeyPress);
            _txtL2Min.Validating += new System.ComponentModel.CancelEventHandler(txtL2Min_Validating);
            _txtL2Min.Enter += new EventHandler(txtL2Min_Enter);
            _txtLo2Deg = new TextBox();
            _txtLo2Deg.TextChanged += new EventHandler(txtLo2Deg_TextChanged);
            _txtLo2Deg.KeyPress += new KeyPressEventHandler(txtLo2Deg_KeyPress);
            _txtLo2Deg.Validating += new System.ComponentModel.CancelEventHandler(txtLo2Deg_Validating);
            _txtLo2Deg.Enter += new EventHandler(txtLo2Deg_Enter);
            _txtLo2Min = new TextBox();
            _txtLo2Min.TextChanged += new EventHandler(txtLo2Min_TextChanged);
            _txtLo2Min.KeyPress += new KeyPressEventHandler(txtLo2Min_KeyPress);
            _txtLo2Min.Validating += new System.ComponentModel.CancelEventHandler(txtLo2Min_Validating);
            _txtLo2Min.Enter += new EventHandler(txtLo2Min_Enter);
            _txtL2Deg = new TextBox();
            _txtL2Deg.TextChanged += new EventHandler(txtL2Deg_TextChanged);
            _txtL2Deg.KeyPress += new KeyPressEventHandler(txtL2Deg_KeyPress);
            _txtL2Deg.Validating += new System.ComponentModel.CancelEventHandler(txtL2Deg_Validating);
            _txtL2Deg.Enter += new EventHandler(txtL2Deg_Enter);
            _txtL1Min = new TextBox();
            _txtL1Min.TextChanged += new EventHandler(txtL1Min_TextChanged);
            _txtL1Min.KeyPress += new KeyPressEventHandler(txtL1Min_KeyPress);
            _txtL1Min.Validating += new System.ComponentModel.CancelEventHandler(txtL1Min_Validating);
            _txtL1Min.Enter += new EventHandler(txtL1Min_Enter);
            _txtLo1Deg = new TextBox();
            _txtLo1Deg.TextChanged += new EventHandler(txtLo1Deg_TextChanged);
            _txtLo1Deg.KeyPress += new KeyPressEventHandler(txtLo1Deg_KeyPress);
            _txtLo1Deg.Validating += new System.ComponentModel.CancelEventHandler(txtLo1Deg_Validating);
            _txtLo1Deg.Enter += new EventHandler(txtLo1Deg_Enter);
            _txtLo1Min = new TextBox();
            _txtLo1Min.TextChanged += new EventHandler(txtLo1Min_TextChanged);
            _txtLo1Min.KeyPress += new KeyPressEventHandler(txtLo1Min_KeyPress);
            _txtLo1Min.Validating += new System.ComponentModel.CancelEventHandler(txtLo1Min_Validating);
            _txtLo1Min.Enter += new EventHandler(txtLo1Min_Enter);
            _txtL1Deg = new TextBox();
            _txtL1Deg.KeyPress += new KeyPressEventHandler(txtL1Deg_KeyPress);
            _txtL1Deg.Validating += new System.ComponentModel.CancelEventHandler(txtL1Deg_Validating);
            _txtL1Deg.Enter += new EventHandler(txtL1Deg_Enter);
            _txtL1Deg.TextChanged += new EventHandler(txtLo1Deg_TextChanged);
            _txtBg2 = new TextBox();
            _txtBg2.TextChanged += new EventHandler(txtBg2_TextChanged);
            _txtBg2.KeyPress += new KeyPressEventHandler(txtBg2_KeyPress);
            _txtBg2.Validating += new System.ComponentModel.CancelEventHandler(txtBg2_Validating);
            _txtBg2.Enter += new EventHandler(txtBg2_Enter);
            _txtBg1 = new TextBox();
            _txtBg1.KeyPress += new KeyPressEventHandler(txtBg1_KeyPress);
            _txtBg1.Validating += new System.ComponentModel.CancelEventHandler(txtBg1_Validating);
            _txtBg1.Enter += new EventHandler(txtBg1_Enter);
            _txtBg1.TextChanged += new EventHandler(txtBg2_TextChanged);
            _ExitBtn = new Button();
            _ExitBtn.Click += new EventHandler(ExitBtn_Click);
            PictureBox1 = new PictureBox();
            TabControl1 = new TabControl();
            Distance = new TabPage();
            lblT2Fmt = new Label();
            lblT1Fmt = new Label();
            DistanceTxtBx = new RichTextBox();
            Frame1 = new GroupBox();
            _optComp = new RadioButton();
            _optComp.CheckedChanged += new EventHandler(optComp_CheckedChanged);
            _optMag = new RadioButton();
            _optMag.CheckedChanged += new EventHandler(optMag_CheckedChanged);
            _optTrue = new RadioButton();
            _optTrue.CheckedChanged += new EventHandler(optTrue_CheckedChanged);
            _optRel = new RadioButton();
            _optRel.CheckedChanged += new EventHandler(optRel_CheckedChanged);
            _cmdClearD = new Button();
            _cmdClearD.Click += new EventHandler(cmdClearD_Click);
            _cmdCalculateD = new Button();
            _cmdCalculateD.Click += new EventHandler(cmdCalculateD_Click);
            lblB2 = new Label();
            lblB1 = new Label();
            lblCourse = new Label();
            lblVesselCourse = new Label();
            Label4 = new Label();
            lblDistance = new Label();
            lblnm = new Label();
            lblor = new Label();
            lblSpeed = new Label();
            lblkn = new Label();
            lblTime = new Label();
            lblh = new Label();
            lblm = new Label();
            lblLog1 = new Label();
            lblLog2 = new Label();
            lblLog1nm = new Label();
            lblLog2nm = new Label();
            lblTime1 = new Label();
            lblTime2 = new Label();
            Label3 = new Label();
            Label2 = new Label();
            Label1 = new Label();
            CMG = new TabPage();
            TextBox1 = new TextBox();
            txtResultCourse = new TextBox();
            _cmdClearC = new Button();
            _cmdClearC.Click += new EventHandler(cmdClearC_Click);
            _cmdCalculateC = new Button();
            _cmdCalculateC.Click += new EventHandler(cmdCalculateC_Click);
            _txtI1 = new TextBox();
            _txtI1.TextChanged += new EventHandler(txtI1_TextChanged);
            _txtI1.KeyPress += new KeyPressEventHandler(txtI1_KeyPress);
            _txtI1.Validating += new System.ComponentModel.CancelEventHandler(txtI1_Validating);
            _txtI1.Enter += new EventHandler(txtI1_Enter);
            _txtI2 = new TextBox();
            _txtI2.TextChanged += new EventHandler(txtI2_TextChanged);
            _txtI2.KeyPress += new KeyPressEventHandler(txtI2_KeyPress);
            _txtI2.Validating += new System.ComponentModel.CancelEventHandler(txtI2_Validating);
            _txtI2.Enter += new EventHandler(txtI2_Enter);
            Label14 = new Label();
            Label13 = new Label();
            Label12 = new Label();
            Label11 = new Label();
            Label10 = new Label();
            Label6 = new Label();
            Label7 = new Label();
            Label8 = new Label();
            Label9 = new Label();
            Label5 = new Label();
            Fix = new TabPage();
            chkReciprocal = new CheckBox();
            txtFixLo = new TextBox();
            txtFixL = new TextBox();
            _cmdClearF2 = new Button();
            _cmdClearF2.Click += new EventHandler(cmdClearF2_Click);
            _cmdCalculateF2 = new Button();
            _cmdCalculateF2.Click += new EventHandler(cmdCalculateF2_Click);
            cboL2 = new ComboBox();
            cboLo2 = new ComboBox();
            cboL1 = new ComboBox();
            cboLo1 = new ComboBox();
            Label28 = new Label();
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
            lblDRL = new Label();
            lblLDeg = new Label();
            lblLMin = new Label();
            lblDRLo = new Label();
            lblLoDeg = new Label();
            lblLoMin = new Label();
            Label16 = new Label();
            Label15 = new Label();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            TabControl1.SuspendLayout();
            Distance.SuspendLayout();
            Frame1.SuspendLayout();
            CMG.SuspendLayout();
            Fix.SuspendLayout();
            SuspendLayout();
            // 
            // cmdPrint
            // 
            _cmdPrint.BackColor = SystemColors.Control;
            _cmdPrint.Cursor = Cursors.Default;
            _cmdPrint.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdPrint.ForeColor = SystemColors.ControlText;
            _cmdPrint.Image = (Image)resources.GetObject("cmdPrint.Image");
            _cmdPrint.Location = new Point(541, 3);
            _cmdPrint.Name = "_cmdPrint";
            _cmdPrint.RightToLeft = RightToLeft.No;
            _cmdPrint.Size = new Size(21, 21);
            _cmdPrint.TabIndex = 30;
            _cmdPrint.TextAlign = ContentAlignment.BottomCenter;
            ToolTip1.SetToolTip(_cmdPrint, "Print window");
            _cmdPrint.UseVisualStyleBackColor = false;
            // 
            // txtCourse
            // 
            _txtCourse.AcceptsReturn = true;
            _txtCourse.BackColor = SystemColors.Window;
            _txtCourse.Cursor = Cursors.IBeam;
            _txtCourse.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtCourse.ForeColor = SystemColors.WindowText;
            _txtCourse.Location = new Point(285, 99);
            _txtCourse.MaxLength = 3;
            _txtCourse.Name = "_txtCourse";
            _txtCourse.RightToLeft = RightToLeft.No;
            _txtCourse.Size = new Size(33, 20);
            _txtCourse.TabIndex = 132;
            ToolTip1.SetToolTip(_txtCourse, "Range 0 to 359");
            _txtCourse.Visible = false;
            // 
            // txtDist
            // 
            _txtDist.AcceptsReturn = true;
            _txtDist.BackColor = SystemColors.Window;
            _txtDist.Cursor = Cursors.IBeam;
            _txtDist.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtDist.ForeColor = SystemColors.WindowText;
            _txtDist.Location = new Point(141, 249);
            _txtDist.MaxLength = 4;
            _txtDist.Name = "_txtDist";
            _txtDist.RightToLeft = RightToLeft.No;
            _txtDist.Size = new Size(41, 20);
            _txtDist.TabIndex = 113;
            ToolTip1.SetToolTip(_txtDist, "Range 0 to 99.9");
            // 
            // txtSpeed
            // 
            _txtSpeed.AcceptsReturn = true;
            _txtSpeed.BackColor = SystemColors.Window;
            _txtSpeed.Cursor = Cursors.IBeam;
            _txtSpeed.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtSpeed.ForeColor = SystemColors.WindowText;
            _txtSpeed.Location = new Point(277, 249);
            _txtSpeed.MaxLength = 4;
            _txtSpeed.Name = "_txtSpeed";
            _txtSpeed.RightToLeft = RightToLeft.No;
            _txtSpeed.Size = new Size(33, 20);
            _txtSpeed.TabIndex = 112;
            ToolTip1.SetToolTip(_txtSpeed, "Range 0 to 99.9");
            // 
            // txtTimeh
            // 
            _txtTimeh.AcceptsReturn = true;
            _txtTimeh.BackColor = SystemColors.Window;
            _txtTimeh.Cursor = Cursors.IBeam;
            _txtTimeh.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtTimeh.ForeColor = SystemColors.WindowText;
            _txtTimeh.Location = new Point(366, 249);
            _txtTimeh.MaxLength = 2;
            _txtTimeh.Name = "_txtTimeh";
            _txtTimeh.RightToLeft = RightToLeft.No;
            _txtTimeh.Size = new Size(33, 20);
            _txtTimeh.TabIndex = 111;
            ToolTip1.SetToolTip(_txtTimeh, "Range 0 to 99");
            // 
            // txtTimem
            // 
            _txtTimem.AcceptsReturn = true;
            _txtTimem.BackColor = SystemColors.Window;
            _txtTimem.Cursor = Cursors.IBeam;
            _txtTimem.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtTimem.ForeColor = SystemColors.WindowText;
            _txtTimem.Location = new Point(415, 249);
            _txtTimem.MaxLength = 2;
            _txtTimem.Name = "_txtTimem";
            _txtTimem.RightToLeft = RightToLeft.No;
            _txtTimem.Size = new Size(33, 20);
            _txtTimem.TabIndex = 110;
            ToolTip1.SetToolTip(_txtTimem, "Range 0 to 99 or 59");
            // 
            // txtLog1
            // 
            _txtLog1.AcceptsReturn = true;
            _txtLog1.BackColor = SystemColors.Window;
            _txtLog1.Cursor = Cursors.IBeam;
            _txtLog1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtLog1.ForeColor = SystemColors.WindowText;
            _txtLog1.Location = new Point(141, 201);
            _txtLog1.MaxLength = 6;
            _txtLog1.Name = "_txtLog1";
            _txtLog1.RightToLeft = RightToLeft.No;
            _txtLog1.Size = new Size(41, 20);
            _txtLog1.TabIndex = 109;
            ToolTip1.SetToolTip(_txtLog1, "Range 0 to 9999.9");
            // 
            // txtLog2
            // 
            _txtLog2.AcceptsReturn = true;
            _txtLog2.BackColor = SystemColors.Window;
            _txtLog2.Cursor = Cursors.IBeam;
            _txtLog2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtLog2.ForeColor = SystemColors.WindowText;
            _txtLog2.Location = new Point(141, 225);
            _txtLog2.MaxLength = 6;
            _txtLog2.Name = "_txtLog2";
            _txtLog2.RightToLeft = RightToLeft.No;
            _txtLog2.Size = new Size(41, 20);
            _txtLog2.TabIndex = 108;
            ToolTip1.SetToolTip(_txtLog2, "Range 0 to 9999.9");
            // 
            // txtTime1
            // 
            _txtTime1.AcceptsReturn = true;
            _txtTime1.BackColor = SystemColors.Window;
            _txtTime1.Cursor = Cursors.IBeam;
            _txtTime1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtTime1.ForeColor = SystemColors.WindowText;
            _txtTime1.Location = new Point(415, 201);
            _txtTime1.MaxLength = 4;
            _txtTime1.Name = "_txtTime1";
            _txtTime1.RightToLeft = RightToLeft.No;
            _txtTime1.Size = new Size(33, 20);
            _txtTime1.TabIndex = 107;
            ToolTip1.SetToolTip(_txtTime1, "Range 0000 to 2359");
            // 
            // txtTime2
            // 
            _txtTime2.AcceptsReturn = true;
            _txtTime2.BackColor = SystemColors.Window;
            _txtTime2.Cursor = Cursors.IBeam;
            _txtTime2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtTime2.ForeColor = SystemColors.WindowText;
            _txtTime2.Location = new Point(415, 225);
            _txtTime2.MaxLength = 4;
            _txtTime2.Name = "_txtTime2";
            _txtTime2.RightToLeft = RightToLeft.No;
            _txtTime2.Size = new Size(33, 20);
            _txtTime2.TabIndex = 106;
            ToolTip1.SetToolTip(_txtTime2, "Range 0000 to 2359");
            // 
            // txtBearing2
            // 
            _txtBearing2.AcceptsReturn = true;
            _txtBearing2.BackColor = SystemColors.Window;
            _txtBearing2.Cursor = Cursors.IBeam;
            _txtBearing2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtBearing2.ForeColor = SystemColors.WindowText;
            _txtBearing2.Location = new Point(285, 147);
            _txtBearing2.MaxLength = 3;
            _txtBearing2.Name = "_txtBearing2";
            _txtBearing2.RightToLeft = RightToLeft.No;
            _txtBearing2.Size = new Size(33, 20);
            _txtBearing2.TabIndex = 104;
            ToolTip1.SetToolTip(_txtBearing2, "Range 1 to 90 if relative; 0 to 359 otherwise");
            // 
            // txtBearing1
            // 
            _txtBearing1.AcceptsReturn = true;
            _txtBearing1.BackColor = SystemColors.Window;
            _txtBearing1.Cursor = Cursors.IBeam;
            _txtBearing1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtBearing1.ForeColor = SystemColors.WindowText;
            _txtBearing1.Location = new Point(285, 123);
            _txtBearing1.MaxLength = 3;
            _txtBearing1.Name = "_txtBearing1";
            _txtBearing1.RightToLeft = RightToLeft.No;
            _txtBearing1.Size = new Size(33, 20);
            _txtBearing1.TabIndex = 103;
            ToolTip1.SetToolTip(_txtBearing1, "Range 1 to 90 if relative; 0 to 359 otherwise");
            // 
            // txtB1
            // 
            _txtB1.AcceptsReturn = true;
            _txtB1.BackColor = SystemColors.Window;
            _txtB1.Cursor = Cursors.IBeam;
            _txtB1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtB1.ForeColor = SystemColors.WindowText;
            _txtB1.Location = new Point(96, 101);
            _txtB1.MaxLength = 3;
            _txtB1.Name = "_txtB1";
            _txtB1.RightToLeft = RightToLeft.No;
            _txtB1.Size = new Size(33, 20);
            _txtB1.TabIndex = 60;
            ToolTip1.SetToolTip(_txtB1, "Range 0 to 359");
            // 
            // txtB2
            // 
            _txtB2.AcceptsReturn = true;
            _txtB2.BackColor = SystemColors.Window;
            _txtB2.Cursor = Cursors.IBeam;
            _txtB2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtB2.ForeColor = SystemColors.WindowText;
            _txtB2.Location = new Point(240, 101);
            _txtB2.MaxLength = 3;
            _txtB2.Name = "_txtB2";
            _txtB2.RightToLeft = RightToLeft.No;
            _txtB2.Size = new Size(33, 20);
            _txtB2.TabIndex = 64;
            ToolTip1.SetToolTip(_txtB2, "Range 0 to 359");
            // 
            // txtB3
            // 
            _txtB3.AcceptsReturn = true;
            _txtB3.BackColor = SystemColors.Window;
            _txtB3.Cursor = Cursors.IBeam;
            _txtB3.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtB3.ForeColor = SystemColors.WindowText;
            _txtB3.Location = new Point(384, 101);
            _txtB3.MaxLength = 3;
            _txtB3.Name = "_txtB3";
            _txtB3.RightToLeft = RightToLeft.No;
            _txtB3.Size = new Size(33, 20);
            _txtB3.TabIndex = 68;
            ToolTip1.SetToolTip(_txtB3, "Range 0 to 359");
            // 
            // txtL2Min
            // 
            _txtL2Min.AcceptsReturn = true;
            _txtL2Min.BackColor = SystemColors.Window;
            _txtL2Min.Cursor = Cursors.IBeam;
            _txtL2Min.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtL2Min.ForeColor = SystemColors.WindowText;
            _txtL2Min.Location = new Point(341, 87);
            _txtL2Min.MaxLength = 4;
            _txtL2Min.Name = "_txtL2Min";
            _txtL2Min.RightToLeft = RightToLeft.No;
            _txtL2Min.Size = new Size(33, 20);
            _txtL2Min.TabIndex = 108;
            ToolTip1.SetToolTip(_txtL2Min, "Range 0 to 59.9");
            // 
            // txtLo2Deg
            // 
            _txtLo2Deg.AcceptsReturn = true;
            _txtLo2Deg.BackColor = SystemColors.Window;
            _txtLo2Deg.Cursor = Cursors.IBeam;
            _txtLo2Deg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtLo2Deg.ForeColor = SystemColors.WindowText;
            _txtLo2Deg.Location = new Point(301, 111);
            _txtLo2Deg.MaxLength = 3;
            _txtLo2Deg.Name = "_txtLo2Deg";
            _txtLo2Deg.RightToLeft = RightToLeft.No;
            _txtLo2Deg.Size = new Size(33, 20);
            _txtLo2Deg.TabIndex = 110;
            ToolTip1.SetToolTip(_txtLo2Deg, "Range 0 to 180");
            // 
            // txtLo2Min
            // 
            _txtLo2Min.AcceptsReturn = true;
            _txtLo2Min.BackColor = SystemColors.Window;
            _txtLo2Min.Cursor = Cursors.IBeam;
            _txtLo2Min.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtLo2Min.ForeColor = SystemColors.WindowText;
            _txtLo2Min.Location = new Point(341, 111);
            _txtLo2Min.MaxLength = 4;
            _txtLo2Min.Name = "_txtLo2Min";
            _txtLo2Min.RightToLeft = RightToLeft.No;
            _txtLo2Min.Size = new Size(33, 20);
            _txtLo2Min.TabIndex = 111;
            ToolTip1.SetToolTip(_txtLo2Min, "Range 0 to 59.9");
            // 
            // txtL2Deg
            // 
            _txtL2Deg.AcceptsReturn = true;
            _txtL2Deg.BackColor = SystemColors.Window;
            _txtL2Deg.Cursor = Cursors.IBeam;
            _txtL2Deg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtL2Deg.ForeColor = SystemColors.WindowText;
            _txtL2Deg.Location = new Point(301, 87);
            _txtL2Deg.MaxLength = 2;
            _txtL2Deg.Name = "_txtL2Deg";
            _txtL2Deg.RightToLeft = RightToLeft.No;
            _txtL2Deg.Size = new Size(33, 20);
            _txtL2Deg.TabIndex = 107;
            ToolTip1.SetToolTip(_txtL2Deg, "Range 0 to 90");
            // 
            // txtL1Min
            // 
            _txtL1Min.AcceptsReturn = true;
            _txtL1Min.BackColor = SystemColors.Window;
            _txtL1Min.Cursor = Cursors.IBeam;
            _txtL1Min.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtL1Min.ForeColor = SystemColors.WindowText;
            _txtL1Min.Location = new Point(157, 87);
            _txtL1Min.MaxLength = 4;
            _txtL1Min.Name = "_txtL1Min";
            _txtL1Min.RightToLeft = RightToLeft.No;
            _txtL1Min.Size = new Size(33, 20);
            _txtL1Min.TabIndex = 101;
            ToolTip1.SetToolTip(_txtL1Min, "Range 0 to 59.9");
            // 
            // txtLo1Deg
            // 
            _txtLo1Deg.AcceptsReturn = true;
            _txtLo1Deg.BackColor = SystemColors.Window;
            _txtLo1Deg.Cursor = Cursors.IBeam;
            _txtLo1Deg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtLo1Deg.ForeColor = SystemColors.WindowText;
            _txtLo1Deg.Location = new Point(117, 111);
            _txtLo1Deg.MaxLength = 3;
            _txtLo1Deg.Name = "_txtLo1Deg";
            _txtLo1Deg.RightToLeft = RightToLeft.No;
            _txtLo1Deg.Size = new Size(33, 20);
            _txtLo1Deg.TabIndex = 103;
            ToolTip1.SetToolTip(_txtLo1Deg, "Range 0 to 180");
            // 
            // txtLo1Min
            // 
            _txtLo1Min.AcceptsReturn = true;
            _txtLo1Min.BackColor = SystemColors.Window;
            _txtLo1Min.Cursor = Cursors.IBeam;
            _txtLo1Min.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtLo1Min.ForeColor = SystemColors.WindowText;
            _txtLo1Min.Location = new Point(157, 111);
            _txtLo1Min.MaxLength = 4;
            _txtLo1Min.Name = "_txtLo1Min";
            _txtLo1Min.RightToLeft = RightToLeft.No;
            _txtLo1Min.Size = new Size(33, 20);
            _txtLo1Min.TabIndex = 104;
            ToolTip1.SetToolTip(_txtLo1Min, "Range 0 to 59.9");
            // 
            // txtL1Deg
            // 
            _txtL1Deg.AcceptsReturn = true;
            _txtL1Deg.BackColor = SystemColors.Window;
            _txtL1Deg.Cursor = Cursors.IBeam;
            _txtL1Deg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtL1Deg.ForeColor = SystemColors.WindowText;
            _txtL1Deg.Location = new Point(117, 87);
            _txtL1Deg.MaxLength = 2;
            _txtL1Deg.Name = "_txtL1Deg";
            _txtL1Deg.RightToLeft = RightToLeft.No;
            _txtL1Deg.Size = new Size(33, 20);
            _txtL1Deg.TabIndex = 100;
            ToolTip1.SetToolTip(_txtL1Deg, "Range 0 to 90");
            // 
            // txtBg2
            // 
            _txtBg2.AcceptsReturn = true;
            _txtBg2.BackColor = SystemColors.Window;
            _txtBg2.Cursor = Cursors.IBeam;
            _txtBg2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtBg2.ForeColor = SystemColors.WindowText;
            _txtBg2.Location = new Point(341, 63);
            _txtBg2.MaxLength = 5;
            _txtBg2.Name = "_txtBg2";
            _txtBg2.RightToLeft = RightToLeft.No;
            _txtBg2.Size = new Size(41, 20);
            _txtBg2.TabIndex = 106;
            ToolTip1.SetToolTip(_txtBg2, "Range 0 to 359.9");
            // 
            // txtBg1
            // 
            _txtBg1.AcceptsReturn = true;
            _txtBg1.BackColor = SystemColors.Window;
            _txtBg1.Cursor = Cursors.IBeam;
            _txtBg1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtBg1.ForeColor = SystemColors.WindowText;
            _txtBg1.Location = new Point(157, 63);
            _txtBg1.MaxLength = 5;
            _txtBg1.Name = "_txtBg1";
            _txtBg1.RightToLeft = RightToLeft.No;
            _txtBg1.Size = new Size(41, 20);
            _txtBg1.TabIndex = 99;
            ToolTip1.SetToolTip(_txtBg1, "Range 0 to 359.9");
            // 
            // ExitBtn
            // 
            _ExitBtn.BackColor = Color.Red;
            _ExitBtn.Cursor = Cursors.Default;
            _ExitBtn.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _ExitBtn.ForeColor = SystemColors.ControlLightLight;
            _ExitBtn.Location = new Point(487, 432);
            _ExitBtn.Name = "_ExitBtn";
            _ExitBtn.RightToLeft = RightToLeft.No;
            _ExitBtn.Size = new Size(73, 25);
            _ExitBtn.TabIndex = 100;
            _ExitBtn.Text = "Exit";
            _ExitBtn.UseVisualStyleBackColor = false;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.ABC_white;
            PictureBox1.Location = new Point(112, 432);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(316, 50);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 103;
            PictureBox1.TabStop = false;
            // 
            // TabControl1
            // 
            TabControl1.Controls.Add(Distance);
            TabControl1.Controls.Add(CMG);
            TabControl1.Controls.Add(Fix);
            TabControl1.Location = new Point(12, 3);
            TabControl1.Name = "TabControl1";
            TabControl1.SelectedIndex = 0;
            TabControl1.Size = new Size(552, 423);
            TabControl1.TabIndex = 104;
            // 
            // Distance
            // 
            Distance.Controls.Add(lblT2Fmt);
            Distance.Controls.Add(lblT1Fmt);
            Distance.Controls.Add(DistanceTxtBx);
            Distance.Controls.Add(_txtCourse);
            Distance.Controls.Add(Frame1);
            Distance.Controls.Add(_cmdClearD);
            Distance.Controls.Add(_txtDist);
            Distance.Controls.Add(_txtSpeed);
            Distance.Controls.Add(_txtTimeh);
            Distance.Controls.Add(_txtTimem);
            Distance.Controls.Add(_txtLog1);
            Distance.Controls.Add(_txtLog2);
            Distance.Controls.Add(_txtTime1);
            Distance.Controls.Add(_txtTime2);
            Distance.Controls.Add(_cmdCalculateD);
            Distance.Controls.Add(_txtBearing2);
            Distance.Controls.Add(_txtBearing1);
            Distance.Controls.Add(lblB2);
            Distance.Controls.Add(lblB1);
            Distance.Controls.Add(lblCourse);
            Distance.Controls.Add(lblVesselCourse);
            Distance.Controls.Add(Label4);
            Distance.Controls.Add(lblDistance);
            Distance.Controls.Add(lblnm);
            Distance.Controls.Add(lblor);
            Distance.Controls.Add(lblSpeed);
            Distance.Controls.Add(lblkn);
            Distance.Controls.Add(lblTime);
            Distance.Controls.Add(lblh);
            Distance.Controls.Add(lblm);
            Distance.Controls.Add(lblLog1);
            Distance.Controls.Add(lblLog2);
            Distance.Controls.Add(lblLog1nm);
            Distance.Controls.Add(lblLog2nm);
            Distance.Controls.Add(lblTime1);
            Distance.Controls.Add(lblTime2);
            Distance.Controls.Add(Label3);
            Distance.Controls.Add(Label2);
            Distance.Controls.Add(Label1);
            Distance.Location = new Point(4, 22);
            Distance.Name = "Distance";
            Distance.Padding = new Padding(3);
            Distance.Size = new Size(544, 397);
            Distance.TabIndex = 0;
            Distance.Text = "Distance by 2 Bearings";
            Distance.UseVisualStyleBackColor = true;
            // 
            // lblT2Fmt
            // 
            lblT2Fmt.AutoSize = true;
            lblT2Fmt.Location = new Point(452, 229);
            lblT2Fmt.Name = "lblT2Fmt";
            lblT2Fmt.Size = new Size(43, 13);
            lblT2Fmt.TabIndex = 138;
            lblT2Fmt.Text = "(hhmm)";
            // 
            // lblT1Fmt
            // 
            lblT1Fmt.AutoSize = true;
            lblT1Fmt.Location = new Point(452, 205);
            lblT1Fmt.Name = "lblT1Fmt";
            lblT1Fmt.Size = new Size(43, 13);
            lblT1Fmt.TabIndex = 137;
            lblT1Fmt.Text = "(hhmm)";
            // 
            // DistanceTxtBx
            // 
            DistanceTxtBx.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DistanceTxtBx.Location = new Point(70, 311);
            DistanceTxtBx.Name = "DistanceTxtBx";
            DistanceTxtBx.ReadOnly = true;
            DistanceTxtBx.Size = new Size(418, 78);
            DistanceTxtBx.TabIndex = 136;
            DistanceTxtBx.Text = "";
            // 
            // Frame1
            // 
            Frame1.BackColor = SystemColors.Window;
            Frame1.Controls.Add(_optComp);
            Frame1.Controls.Add(_optMag);
            Frame1.Controls.Add(_optTrue);
            Frame1.Controls.Add(_optRel);
            Frame1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Frame1.ForeColor = SystemColors.ControlText;
            Frame1.Location = new Point(94, 53);
            Frame1.Name = "Frame1";
            Frame1.Padding = new Padding(0);
            Frame1.RightToLeft = RightToLeft.No;
            Frame1.Size = new Size(365, 41);
            Frame1.TabIndex = 130;
            Frame1.TabStop = false;
            Frame1.Text = "Bearings are";
            // 
            // optComp
            // 
            _optComp.BackColor = SystemColors.Window;
            _optComp.Cursor = Cursors.Default;
            _optComp.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optComp.ForeColor = SystemColors.ControlText;
            _optComp.Location = new Point(280, 16);
            _optComp.Name = "_optComp";
            _optComp.RightToLeft = RightToLeft.No;
            _optComp.Size = new Size(70, 17);
            _optComp.TabIndex = 35;
            _optComp.TabStop = true;
            _optComp.Text = "Compass";
            _optComp.UseVisualStyleBackColor = false;
            // 
            // optMag
            // 
            _optMag.BackColor = SystemColors.Window;
            _optMag.Cursor = Cursors.Default;
            _optMag.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optMag.ForeColor = SystemColors.ControlText;
            _optMag.Location = new Point(192, 16);
            _optMag.Name = "_optMag";
            _optMag.RightToLeft = RightToLeft.No;
            _optMag.Size = new Size(69, 17);
            _optMag.TabIndex = 34;
            _optMag.TabStop = true;
            _optMag.Text = "Magnetic";
            _optMag.UseVisualStyleBackColor = false;
            // 
            // optTrue
            // 
            _optTrue.BackColor = SystemColors.Window;
            _optTrue.Cursor = Cursors.Default;
            _optTrue.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optTrue.ForeColor = SystemColors.ControlText;
            _optTrue.Location = new Point(120, 16);
            _optTrue.Name = "_optTrue";
            _optTrue.RightToLeft = RightToLeft.No;
            _optTrue.Size = new Size(49, 17);
            _optTrue.TabIndex = 33;
            _optTrue.TabStop = true;
            _optTrue.Text = "True";
            _optTrue.UseVisualStyleBackColor = false;
            // 
            // optRel
            // 
            _optRel.BackColor = SystemColors.Window;
            _optRel.Checked = true;
            _optRel.Cursor = Cursors.Default;
            _optRel.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optRel.ForeColor = SystemColors.ControlText;
            _optRel.Location = new Point(8, 16);
            _optRel.Name = "_optRel";
            _optRel.RightToLeft = RightToLeft.No;
            _optRel.Size = new Size(97, 17);
            _optRel.TabIndex = 32;
            _optRel.TabStop = true;
            _optRel.Text = "Relative (bow)";
            _optRel.UseVisualStyleBackColor = false;
            // 
            // cmdClearD
            // 
            _cmdClearD.BackColor = SystemColors.Control;
            _cmdClearD.Cursor = Cursors.Default;
            _cmdClearD.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdClearD.ForeColor = SystemColors.ControlText;
            _cmdClearD.Location = new Point(415, 278);
            _cmdClearD.Name = "_cmdClearD";
            _cmdClearD.RightToLeft = RightToLeft.No;
            _cmdClearD.Size = new Size(73, 25);
            _cmdClearD.TabIndex = 129;
            _cmdClearD.Text = "Clea&r";
            _cmdClearD.UseVisualStyleBackColor = false;
            // 
            // cmdCalculateD
            // 
            _cmdCalculateD.BackColor = SystemColors.Control;
            _cmdCalculateD.Cursor = Cursors.Default;
            _cmdCalculateD.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdCalculateD.ForeColor = SystemColors.ControlText;
            _cmdCalculateD.Location = new Point(214, 278);
            _cmdCalculateD.Name = "_cmdCalculateD";
            _cmdCalculateD.RightToLeft = RightToLeft.No;
            _cmdCalculateD.Size = new Size(121, 25);
            _cmdCalculateD.TabIndex = 105;
            _cmdCalculateD.Text = "Calculate &Distance";
            _cmdCalculateD.UseVisualStyleBackColor = false;
            // 
            // lblB2
            // 
            lblB2.BackColor = SystemColors.Window;
            lblB2.Cursor = Cursors.Default;
            lblB2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblB2.ForeColor = SystemColors.ControlText;
            lblB2.Location = new Point(318, 149);
            lblB2.Name = "lblB2";
            lblB2.RightToLeft = RightToLeft.No;
            lblB2.Size = new Size(120, 17);
            lblB2.TabIndex = 135;
            lblB2.Text = "° Relative (off the bow)";
            lblB2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblB1
            // 
            lblB1.BackColor = SystemColors.Window;
            lblB1.Cursor = Cursors.Default;
            lblB1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblB1.ForeColor = SystemColors.ControlText;
            lblB1.Location = new Point(318, 125);
            lblB1.Name = "lblB1";
            lblB1.RightToLeft = RightToLeft.No;
            lblB1.Size = new Size(120, 17);
            lblB1.TabIndex = 134;
            lblB1.Text = "° Relative (off the bow)";
            lblB1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCourse
            // 
            lblCourse.BackColor = SystemColors.Window;
            lblCourse.Cursor = Cursors.Default;
            lblCourse.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblCourse.ForeColor = SystemColors.ControlText;
            lblCourse.Location = new Point(318, 101);
            lblCourse.Name = "lblCourse";
            lblCourse.RightToLeft = RightToLeft.No;
            lblCourse.Size = new Size(120, 17);
            lblCourse.TabIndex = 133;
            lblCourse.Text = "° True";
            lblCourse.TextAlign = ContentAlignment.MiddleLeft;
            lblCourse.Visible = false;
            // 
            // lblVesselCourse
            // 
            lblVesselCourse.BackColor = SystemColors.Window;
            lblVesselCourse.Cursor = Cursors.Default;
            lblVesselCourse.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblVesselCourse.ForeColor = SystemColors.ControlText;
            lblVesselCourse.Location = new Point(205, 100);
            lblVesselCourse.Name = "lblVesselCourse";
            lblVesselCourse.RightToLeft = RightToLeft.No;
            lblVesselCourse.Size = new Size(78, 17);
            lblVesselCourse.TabIndex = 131;
            lblVesselCourse.Text = "Vessel Course";
            lblVesselCourse.TextAlign = ContentAlignment.MiddleLeft;
            lblVesselCourse.Visible = false;
            // 
            // Label4
            // 
            Label4.BackColor = SystemColors.ScrollBar;
            Label4.BorderStyle = BorderStyle.Fixed3D;
            Label4.Cursor = Cursors.Default;
            Label4.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.ForeColor = SystemColors.ControlText;
            Label4.Location = new Point(94, 172);
            Label4.Name = "Label4";
            Label4.RightToLeft = RightToLeft.No;
            Label4.Size = new Size(365, 20);
            Label4.TabIndex = 128;
            Label4.Text = "Input distance or speed and time traveled between bearings";
            Label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDistance
            // 
            lblDistance.BackColor = SystemColors.Window;
            lblDistance.Cursor = Cursors.Default;
            lblDistance.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblDistance.ForeColor = SystemColors.ControlText;
            lblDistance.Location = new Point(88, 249);
            lblDistance.Name = "lblDistance";
            lblDistance.RightToLeft = RightToLeft.No;
            lblDistance.Size = new Size(50, 17);
            lblDistance.TabIndex = 127;
            lblDistance.Text = "Distance";
            lblDistance.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblnm
            // 
            lblnm.BackColor = SystemColors.Window;
            lblnm.Cursor = Cursors.Default;
            lblnm.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblnm.ForeColor = SystemColors.ControlText;
            lblnm.Location = new Point(183, 249);
            lblnm.Name = "lblnm";
            lblnm.RightToLeft = RightToLeft.No;
            lblnm.Size = new Size(25, 17);
            lblnm.TabIndex = 126;
            lblnm.Text = "nm";
            lblnm.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblor
            // 
            lblor.BackColor = SystemColors.Window;
            lblor.Cursor = Cursors.Default;
            lblor.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblor.ForeColor = SystemColors.ControlText;
            lblor.Location = new Point(214, 225);
            lblor.Name = "lblor";
            lblor.RightToLeft = RightToLeft.No;
            lblor.Size = new Size(25, 17);
            lblor.TabIndex = 125;
            lblor.Text = "OR";
            // 
            // lblSpeed
            // 
            lblSpeed.BackColor = SystemColors.Window;
            lblSpeed.Cursor = Cursors.Default;
            lblSpeed.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblSpeed.ForeColor = SystemColors.ControlText;
            lblSpeed.Location = new Point(238, 250);
            lblSpeed.Name = "lblSpeed";
            lblSpeed.RightToLeft = RightToLeft.No;
            lblSpeed.Size = new Size(38, 17);
            lblSpeed.TabIndex = 124;
            lblSpeed.Text = "Speed";
            lblSpeed.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblkn
            // 
            lblkn.BackColor = SystemColors.Window;
            lblkn.Cursor = Cursors.Default;
            lblkn.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblkn.ForeColor = SystemColors.ControlText;
            lblkn.Location = new Point(310, 249);
            lblkn.Name = "lblkn";
            lblkn.RightToLeft = RightToLeft.No;
            lblkn.Size = new Size(25, 17);
            lblkn.TabIndex = 123;
            lblkn.Text = "kn";
            lblkn.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTime
            // 
            lblTime.BackColor = SystemColors.Window;
            lblTime.Cursor = Cursors.Default;
            lblTime.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblTime.ForeColor = SystemColors.ControlText;
            lblTime.Location = new Point(334, 249);
            lblTime.Name = "lblTime";
            lblTime.RightToLeft = RightToLeft.No;
            lblTime.Size = new Size(30, 20);
            lblTime.TabIndex = 122;
            lblTime.Text = "Run Time";
            lblTime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblh
            // 
            lblh.BackColor = SystemColors.Window;
            lblh.Cursor = Cursors.Default;
            lblh.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblh.ForeColor = SystemColors.ControlText;
            lblh.Location = new Point(399, 249);
            lblh.Name = "lblh";
            lblh.RightToLeft = RightToLeft.No;
            lblh.Size = new Size(17, 17);
            lblh.TabIndex = 121;
            lblh.Text = "hr";
            lblh.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblm
            // 
            lblm.BackColor = SystemColors.Window;
            lblm.Cursor = Cursors.Default;
            lblm.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblm.ForeColor = SystemColors.ControlText;
            lblm.Location = new Point(448, 249);
            lblm.Name = "lblm";
            lblm.RightToLeft = RightToLeft.No;
            lblm.Size = new Size(25, 17);
            lblm.TabIndex = 120;
            lblm.Text = "min";
            lblm.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblLog1
            // 
            lblLog1.BackColor = SystemColors.Window;
            lblLog1.Cursor = Cursors.Default;
            lblLog1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLog1.ForeColor = SystemColors.ControlText;
            lblLog1.Location = new Point(78, 202);
            lblLog1.Name = "lblLog1";
            lblLog1.RightToLeft = RightToLeft.No;
            lblLog1.Size = new Size(65, 17);
            lblLog1.TabIndex = 119;
            lblLog1.Text = "Log Entry 1";
            lblLog1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblLog2
            // 
            lblLog2.BackColor = SystemColors.Window;
            lblLog2.Cursor = Cursors.Default;
            lblLog2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLog2.ForeColor = SystemColors.ControlText;
            lblLog2.Location = new Point(77, 226);
            lblLog2.Name = "lblLog2";
            lblLog2.RightToLeft = RightToLeft.No;
            lblLog2.Size = new Size(65, 17);
            lblLog2.TabIndex = 118;
            lblLog2.Text = "Log Entry 2";
            lblLog2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblLog1nm
            // 
            lblLog1nm.BackColor = SystemColors.Window;
            lblLog1nm.Cursor = Cursors.Default;
            lblLog1nm.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLog1nm.ForeColor = SystemColors.ControlText;
            lblLog1nm.Location = new Point(183, 201);
            lblLog1nm.Name = "lblLog1nm";
            lblLog1nm.RightToLeft = RightToLeft.No;
            lblLog1nm.Size = new Size(25, 17);
            lblLog1nm.TabIndex = 117;
            lblLog1nm.Text = "nm";
            lblLog1nm.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblLog2nm
            // 
            lblLog2nm.BackColor = SystemColors.Window;
            lblLog2nm.Cursor = Cursors.Default;
            lblLog2nm.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLog2nm.ForeColor = SystemColors.ControlText;
            lblLog2nm.Location = new Point(183, 225);
            lblLog2nm.Name = "lblLog2nm";
            lblLog2nm.RightToLeft = RightToLeft.No;
            lblLog2nm.Size = new Size(25, 17);
            lblLog2nm.TabIndex = 116;
            lblLog2nm.Text = "nm";
            lblLog2nm.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTime1
            // 
            lblTime1.BackColor = SystemColors.Window;
            lblTime1.Cursor = Cursors.Default;
            lblTime1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblTime1.ForeColor = SystemColors.ControlText;
            lblTime1.Location = new Point(348, 203);
            lblTime1.Name = "lblTime1";
            lblTime1.RightToLeft = RightToLeft.No;
            lblTime1.Size = new Size(70, 17);
            lblTime1.TabIndex = 115;
            lblTime1.Text = "First Time";
            lblTime1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTime2
            // 
            lblTime2.BackColor = SystemColors.Window;
            lblTime2.Cursor = Cursors.Default;
            lblTime2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblTime2.ForeColor = SystemColors.ControlText;
            lblTime2.Location = new Point(347, 226);
            lblTime2.Name = "lblTime2";
            lblTime2.RightToLeft = RightToLeft.No;
            lblTime2.Size = new Size(70, 17);
            lblTime2.TabIndex = 114;
            lblTime2.Text = "Second Time";
            lblTime2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label3
            // 
            Label3.BackColor = SystemColors.Window;
            Label3.Cursor = Cursors.Default;
            Label3.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.ForeColor = SystemColors.ControlText;
            Label3.Location = new Point(157, 147);
            Label3.Name = "Label3";
            Label3.RightToLeft = RightToLeft.No;
            Label3.Size = new Size(129, 20);
            Label3.TabIndex = 102;
            Label3.Text = "Second bearing to object";
            Label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label2
            // 
            Label2.BackColor = SystemColors.Window;
            Label2.Cursor = Cursors.Default;
            Label2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = SystemColors.ControlText;
            Label2.Location = new Point(173, 125);
            Label2.Name = "Label2";
            Label2.RightToLeft = RightToLeft.No;
            Label2.Size = new Size(113, 17);
            Label2.TabIndex = 101;
            Label2.Text = "First bearing to object";
            Label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label1
            // 
            Label1.BackColor = SystemColors.ScrollBar;
            Label1.BorderStyle = BorderStyle.Fixed3D;
            Label1.Cursor = Cursors.Default;
            Label1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = SystemColors.ControlText;
            Label1.Location = new Point(94, 4);
            Label1.Name = "Label1";
            Label1.RightToLeft = RightToLeft.No;
            Label1.Size = new Size(365, 49);
            Label1.TabIndex = 100;
            Label1.Text = "Calculates the distance of a fixed object by two bearings " + '\r' + '\n' + "and the distance and " + "time to object when object is abeam. " + '\r' + '\n' + "Assumes a constant course and speed, movi" + "ng towards object.";
            Label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // CMG
            // 
            CMG.Controls.Add(TextBox1);
            CMG.Controls.Add(txtResultCourse);
            CMG.Controls.Add(_cmdClearC);
            CMG.Controls.Add(_cmdCalculateC);
            CMG.Controls.Add(_txtB1);
            CMG.Controls.Add(_txtI1);
            CMG.Controls.Add(_txtB2);
            CMG.Controls.Add(_txtI2);
            CMG.Controls.Add(_txtB3);
            CMG.Controls.Add(Label14);
            CMG.Controls.Add(Label13);
            CMG.Controls.Add(Label12);
            CMG.Controls.Add(Label11);
            CMG.Controls.Add(Label10);
            CMG.Controls.Add(Label6);
            CMG.Controls.Add(Label7);
            CMG.Controls.Add(Label8);
            CMG.Controls.Add(Label9);
            CMG.Controls.Add(Label5);
            CMG.Location = new Point(4, 22);
            CMG.Name = "CMG";
            CMG.Padding = new Padding(3);
            CMG.Size = new Size(544, 397);
            CMG.TabIndex = 1;
            CMG.Text = "Course by 2 or 3 Bearings";
            CMG.UseVisualStyleBackColor = true;
            // 
            // TextBox1
            // 
            TextBox1.Location = new Point(6, 229);
            TextBox1.Multiline = true;
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(532, 106);
            TextBox1.TabIndex = 77;
            TextBox1.Text = resources.GetString("TextBox1.Text");
            TextBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtResultCourse
            // 
            txtResultCourse.AcceptsReturn = true;
            txtResultCourse.BackColor = SystemColors.Window;
            txtResultCourse.Cursor = Cursors.IBeam;
            txtResultCourse.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtResultCourse.ForeColor = SystemColors.WindowText;
            txtResultCourse.Location = new Point(264, 162);
            txtResultCourse.MaxLength = 0;
            txtResultCourse.Name = "txtResultCourse";
            txtResultCourse.RightToLeft = RightToLeft.No;
            txtResultCourse.Size = new Size(30, 20);
            txtResultCourse.TabIndex = 76;
            // 
            // cmdClearC
            // 
            _cmdClearC.BackColor = SystemColors.Control;
            _cmdClearC.Cursor = Cursors.Default;
            _cmdClearC.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdClearC.ForeColor = SystemColors.ControlText;
            _cmdClearC.Location = new Point(216, 191);
            _cmdClearC.Name = "_cmdClearC";
            _cmdClearC.RightToLeft = RightToLeft.No;
            _cmdClearC.Size = new Size(89, 25);
            _cmdClearC.TabIndex = 74;
            _cmdClearC.Text = "Cl&ear";
            _cmdClearC.UseVisualStyleBackColor = false;
            // 
            // cmdCalculateC
            // 
            _cmdCalculateC.BackColor = SystemColors.Control;
            _cmdCalculateC.Cursor = Cursors.Default;
            _cmdCalculateC.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdCalculateC.ForeColor = SystemColors.ControlText;
            _cmdCalculateC.Location = new Point(216, 125);
            _cmdCalculateC.Name = "_cmdCalculateC";
            _cmdCalculateC.RightToLeft = RightToLeft.No;
            _cmdCalculateC.Size = new Size(89, 25);
            _cmdCalculateC.TabIndex = 69;
            _cmdCalculateC.Text = "Calculate &CMG";
            _cmdCalculateC.UseVisualStyleBackColor = false;
            // 
            // txtI1
            // 
            _txtI1.AcceptsReturn = true;
            _txtI1.BackColor = SystemColors.Window;
            _txtI1.Cursor = Cursors.IBeam;
            _txtI1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtI1.ForeColor = SystemColors.WindowText;
            _txtI1.Location = new Point(169, 101);
            _txtI1.MaxLength = 5;
            _txtI1.Name = "_txtI1";
            _txtI1.RightToLeft = RightToLeft.No;
            _txtI1.Size = new Size(41, 20);
            _txtI1.TabIndex = 62;
            // 
            // txtI2
            // 
            _txtI2.AcceptsReturn = true;
            _txtI2.BackColor = SystemColors.Window;
            _txtI2.Cursor = Cursors.IBeam;
            _txtI2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtI2.ForeColor = SystemColors.WindowText;
            _txtI2.Location = new Point(311, 101);
            _txtI2.MaxLength = 5;
            _txtI2.Name = "_txtI2";
            _txtI2.RightToLeft = RightToLeft.No;
            _txtI2.Size = new Size(41, 20);
            _txtI2.TabIndex = 66;
            // 
            // Label14
            // 
            Label14.BackColor = SystemColors.Window;
            Label14.Cursor = Cursors.Default;
            Label14.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label14.ForeColor = SystemColors.ControlText;
            Label14.Location = new Point(218, 158);
            Label14.Name = "Label14";
            Label14.RightToLeft = RightToLeft.No;
            Label14.Size = new Size(35, 29);
            Label14.TabIndex = 75;
            Label14.Text = "CMG";
            Label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label13
            // 
            Label13.BackColor = SystemColors.Window;
            Label13.Cursor = Cursors.Default;
            Label13.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label13.ForeColor = SystemColors.ControlText;
            Label13.Location = new Point(85, 85);
            Label13.Name = "Label13";
            Label13.RightToLeft = RightToLeft.No;
            Label13.Size = new Size(63, 17);
            Label13.TabIndex = 73;
            Label13.Text = "1st Bearing";
            // 
            // Label12
            // 
            Label12.BackColor = SystemColors.Window;
            Label12.Cursor = Cursors.Default;
            Label12.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label12.ForeColor = SystemColors.ControlText;
            Label12.Location = new Point(160, 84);
            Label12.Name = "Label12";
            Label12.RightToLeft = RightToLeft.No;
            Label12.Size = new Size(63, 15);
            Label12.TabIndex = 72;
            Label12.Text = "1st Interval" + '\r' + '\n';
            Label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label11
            // 
            Label11.BackColor = SystemColors.Window;
            Label11.Cursor = Cursors.Default;
            Label11.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label11.ForeColor = SystemColors.ControlText;
            Label11.Location = new Point(232, 85);
            Label11.Name = "Label11";
            Label11.RightToLeft = RightToLeft.No;
            Label11.Size = new Size(65, 17);
            Label11.TabIndex = 71;
            Label11.Text = "2nd Bearing";
            // 
            // Label10
            // 
            Label10.BackColor = SystemColors.Window;
            Label10.Cursor = Cursors.Default;
            Label10.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label10.ForeColor = SystemColors.ControlText;
            Label10.Location = new Point(301, 83);
            Label10.Name = "Label10";
            Label10.RightToLeft = RightToLeft.No;
            Label10.Size = new Size(65, 15);
            Label10.TabIndex = 70;
            Label10.Text = "2nd Interval";
            Label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label6
            // 
            Label6.BackColor = SystemColors.Window;
            Label6.Cursor = Cursors.Default;
            Label6.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label6.ForeColor = SystemColors.ControlText;
            Label6.Location = new Point(376, 85);
            Label6.Name = "Label6";
            Label6.RightToLeft = RightToLeft.No;
            Label6.Size = new Size(63, 17);
            Label6.TabIndex = 67;
            Label6.Text = "3rd Bearing";
            // 
            // Label7
            // 
            Label7.BackColor = SystemColors.Window;
            Label7.Cursor = Cursors.Default;
            Label7.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label7.ForeColor = SystemColors.ControlText;
            Label7.Location = new Point(129, 101);
            Label7.Name = "Label7";
            Label7.RightToLeft = RightToLeft.No;
            Label7.Size = new Size(9, 17);
            Label7.TabIndex = 65;
            Label7.Text = "°";
            // 
            // Label8
            // 
            Label8.BackColor = SystemColors.Window;
            Label8.Cursor = Cursors.Default;
            Label8.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label8.ForeColor = SystemColors.ControlText;
            Label8.Location = new Point(273, 101);
            Label8.Name = "Label8";
            Label8.RightToLeft = RightToLeft.No;
            Label8.Size = new Size(9, 17);
            Label8.TabIndex = 63;
            Label8.Text = "°";
            // 
            // Label9
            // 
            Label9.BackColor = SystemColors.Window;
            Label9.Cursor = Cursors.Default;
            Label9.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label9.ForeColor = SystemColors.ControlText;
            Label9.Location = new Point(417, 101);
            Label9.Name = "Label9";
            Label9.RightToLeft = RightToLeft.No;
            Label9.Size = new Size(9, 17);
            Label9.TabIndex = 61;
            Label9.Text = "°";
            // 
            // Label5
            // 
            Label5.BackColor = SystemColors.Window;
            Label5.Cursor = Cursors.Default;
            Label5.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label5.ForeColor = SystemColors.ControlText;
            Label5.Location = new Point(80, 41);
            Label5.Name = "Label5";
            Label5.RightToLeft = RightToLeft.No;
            Label5.Size = new Size(369, 41);
            Label5.TabIndex = 59;
            Label5.Text = resources.GetString("Label5.Text");
            // 
            // Fix
            // 
            Fix.Controls.Add(chkReciprocal);
            Fix.Controls.Add(txtFixLo);
            Fix.Controls.Add(txtFixL);
            Fix.Controls.Add(_cmdClearF2);
            Fix.Controls.Add(_cmdCalculateF2);
            Fix.Controls.Add(_txtL2Min);
            Fix.Controls.Add(cboL2);
            Fix.Controls.Add(_txtLo2Deg);
            Fix.Controls.Add(_txtLo2Min);
            Fix.Controls.Add(cboLo2);
            Fix.Controls.Add(_txtL2Deg);
            Fix.Controls.Add(_txtL1Min);
            Fix.Controls.Add(cboL1);
            Fix.Controls.Add(_txtLo1Deg);
            Fix.Controls.Add(_txtLo1Min);
            Fix.Controls.Add(cboLo1);
            Fix.Controls.Add(_txtL1Deg);
            Fix.Controls.Add(_txtBg2);
            Fix.Controls.Add(_txtBg1);
            Fix.Controls.Add(Label28);
            Fix.Controls.Add(Label27);
            Fix.Controls.Add(Label26);
            Fix.Controls.Add(Label25);
            Fix.Controls.Add(Label24);
            Fix.Controls.Add(Label23);
            Fix.Controls.Add(Label22);
            Fix.Controls.Add(Label21);
            Fix.Controls.Add(Label20);
            Fix.Controls.Add(Label19);
            Fix.Controls.Add(Label18);
            Fix.Controls.Add(Label17);
            Fix.Controls.Add(lblDRL);
            Fix.Controls.Add(lblLDeg);
            Fix.Controls.Add(lblLMin);
            Fix.Controls.Add(lblDRLo);
            Fix.Controls.Add(lblLoDeg);
            Fix.Controls.Add(lblLoMin);
            Fix.Controls.Add(Label16);
            Fix.Controls.Add(Label15);
            Fix.Location = new Point(4, 22);
            Fix.Name = "Fix";
            Fix.Size = new Size(544, 397);
            Fix.TabIndex = 2;
            Fix.Text = "Fix from 2 Bearings";
            Fix.UseVisualStyleBackColor = true;
            // 
            // chkReciprocal
            // 
            chkReciprocal.BackColor = SystemColors.Window;
            chkReciprocal.Cursor = Cursors.Default;
            chkReciprocal.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            chkReciprocal.ForeColor = SystemColors.ControlText;
            chkReciprocal.Location = new Point(197, 43);
            chkReciprocal.Name = "chkReciprocal";
            chkReciprocal.RightToLeft = RightToLeft.No;
            chkReciprocal.Size = new Size(137, 17);
            chkReciprocal.TabIndex = 135;
            chkReciprocal.Text = "Use reciprocal bearings";
            chkReciprocal.UseVisualStyleBackColor = false;
            // 
            // txtFixLo
            // 
            txtFixLo.AcceptsReturn = true;
            txtFixLo.BackColor = SystemColors.Window;
            txtFixLo.Cursor = Cursors.IBeam;
            txtFixLo.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtFixLo.ForeColor = SystemColors.WindowText;
            txtFixLo.Location = new Point(253, 199);
            txtFixLo.MaxLength = 0;
            txtFixLo.Name = "txtFixLo";
            txtFixLo.RightToLeft = RightToLeft.No;
            txtFixLo.Size = new Size(65, 20);
            txtFixLo.TabIndex = 134;
            // 
            // txtFixL
            // 
            txtFixL.AcceptsReturn = true;
            txtFixL.BackColor = SystemColors.Window;
            txtFixL.Cursor = Cursors.IBeam;
            txtFixL.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtFixL.ForeColor = SystemColors.WindowText;
            txtFixL.Location = new Point(253, 178);
            txtFixL.MaxLength = 0;
            txtFixL.Name = "txtFixL";
            txtFixL.RightToLeft = RightToLeft.No;
            txtFixL.Size = new Size(65, 20);
            txtFixL.TabIndex = 133;
            // 
            // cmdClearF2
            // 
            _cmdClearF2.BackColor = SystemColors.Control;
            _cmdClearF2.Cursor = Cursors.Default;
            _cmdClearF2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdClearF2.ForeColor = SystemColors.ControlText;
            _cmdClearF2.Location = new Point(221, 223);
            _cmdClearF2.Name = "_cmdClearF2";
            _cmdClearF2.RightToLeft = RightToLeft.No;
            _cmdClearF2.Size = new Size(73, 25);
            _cmdClearF2.TabIndex = 130;
            _cmdClearF2.Text = "Cle&ar";
            _cmdClearF2.UseVisualStyleBackColor = false;
            // 
            // cmdCalculateF2
            // 
            _cmdCalculateF2.BackColor = SystemColors.Control;
            _cmdCalculateF2.Cursor = Cursors.Default;
            _cmdCalculateF2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdCalculateF2.ForeColor = SystemColors.ControlText;
            _cmdCalculateF2.Location = new Point(157, 143);
            _cmdCalculateF2.Name = "_cmdCalculateF2";
            _cmdCalculateF2.RightToLeft = RightToLeft.No;
            _cmdCalculateF2.Size = new Size(201, 25);
            _cmdCalculateF2.TabIndex = 113;
            _cmdCalculateF2.Text = "Calculate &Fix from Cross Bearings";
            _cmdCalculateF2.UseVisualStyleBackColor = false;
            // 
            // cboL2
            // 
            cboL2.BackColor = SystemColors.Window;
            cboL2.Cursor = Cursors.Default;
            cboL2.DropDownStyle = ComboBoxStyle.DropDownList;
            cboL2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboL2.ForeColor = SystemColors.WindowText;
            cboL2.Items.AddRange(new object[] { "N", "S" });
            cboL2.Location = new Point(381, 87);
            cboL2.Name = "cboL2";
            cboL2.RightToLeft = RightToLeft.No;
            cboL2.Size = new Size(41, 22);
            cboL2.TabIndex = 109;
            // 
            // cboLo2
            // 
            cboLo2.BackColor = SystemColors.Window;
            cboLo2.Cursor = Cursors.Default;
            cboLo2.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLo2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboLo2.ForeColor = SystemColors.WindowText;
            cboLo2.Items.AddRange(new object[] { "W", "E" });
            cboLo2.Location = new Point(381, 111);
            cboLo2.Name = "cboLo2";
            cboLo2.RightToLeft = RightToLeft.No;
            cboLo2.Size = new Size(41, 22);
            cboLo2.TabIndex = 112;
            // 
            // cboL1
            // 
            cboL1.BackColor = SystemColors.Window;
            cboL1.Cursor = Cursors.Default;
            cboL1.DropDownStyle = ComboBoxStyle.DropDownList;
            cboL1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboL1.ForeColor = SystemColors.WindowText;
            cboL1.Items.AddRange(new object[] { "N", "S" });
            cboL1.Location = new Point(197, 87);
            cboL1.Name = "cboL1";
            cboL1.RightToLeft = RightToLeft.No;
            cboL1.Size = new Size(41, 22);
            cboL1.TabIndex = 102;
            // 
            // cboLo1
            // 
            cboLo1.BackColor = SystemColors.Window;
            cboLo1.Cursor = Cursors.Default;
            cboLo1.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLo1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboLo1.ForeColor = SystemColors.WindowText;
            cboLo1.Items.AddRange(new object[] { "W", "E" });
            cboLo1.Location = new Point(197, 111);
            cboLo1.Name = "cboLo1";
            cboLo1.RightToLeft = RightToLeft.No;
            cboLo1.Size = new Size(41, 22);
            cboLo1.TabIndex = 105;
            // 
            // Label28
            // 
            Label28.BackColor = SystemColors.Window;
            Label28.Cursor = Cursors.Default;
            Label28.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label28.ForeColor = SystemColors.ControlText;
            Label28.Location = new Point(341, 183);
            Label28.Name = "Label28";
            Label28.RightToLeft = RightToLeft.No;
            Label28.Size = new Size(105, 41);
            Label28.TabIndex = 136;
            Label28.Text = "Bearing angular separation outside recommended range.";
            Label28.Visible = false;
            // 
            // Label27
            // 
            Label27.BackColor = SystemColors.Window;
            Label27.Cursor = Cursors.Default;
            Label27.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label27.ForeColor = SystemColors.ControlText;
            Label27.Location = new Point(205, 200);
            Label27.Name = "Label27";
            Label27.RightToLeft = RightToLeft.No;
            Label27.Size = new Size(40, 17);
            Label27.TabIndex = 132;
            Label27.Text = "Fix Lo";
            // 
            // Label26
            // 
            Label26.BackColor = SystemColors.Window;
            Label26.Cursor = Cursors.Default;
            Label26.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label26.ForeColor = SystemColors.ControlText;
            Label26.Location = new Point(205, 181);
            Label26.Name = "Label26";
            Label26.RightToLeft = RightToLeft.No;
            Label26.Size = new Size(35, 17);
            Label26.TabIndex = 131;
            Label26.Text = "Fix L";
            // 
            // Label25
            // 
            Label25.BackColor = SystemColors.Window;
            Label25.Cursor = Cursors.Default;
            Label25.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label25.ForeColor = SystemColors.ControlText;
            Label25.Location = new Point(293, 63);
            Label25.Name = "Label25";
            Label25.RightToLeft = RightToLeft.No;
            Label25.Size = new Size(49, 17);
            Label25.TabIndex = 129;
            Label25.Text = "Bearing 2";
            // 
            // Label24
            // 
            Label24.BackColor = SystemColors.Window;
            Label24.Cursor = Cursors.Default;
            Label24.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label24.ForeColor = SystemColors.ControlText;
            Label24.Location = new Point(277, 90);
            Label24.Name = "Label24";
            Label24.RightToLeft = RightToLeft.No;
            Label24.Size = new Size(20, 13);
            Label24.TabIndex = 128;
            Label24.Text = "L2";
            // 
            // Label23
            // 
            Label23.BackColor = SystemColors.Window;
            Label23.Cursor = Cursors.Default;
            Label23.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label23.ForeColor = SystemColors.ControlText;
            Label23.Location = new Point(334, 87);
            Label23.Name = "Label23";
            Label23.RightToLeft = RightToLeft.No;
            Label23.Size = new Size(9, 17);
            Label23.TabIndex = 127;
            Label23.Text = "°";
            // 
            // Label22
            // 
            Label22.BackColor = SystemColors.Window;
            Label22.Cursor = Cursors.Default;
            Label22.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label22.ForeColor = SystemColors.ControlText;
            Label22.Location = new Point(374, 87);
            Label22.Name = "Label22";
            Label22.RightToLeft = RightToLeft.No;
            Label22.Size = new Size(9, 17);
            Label22.TabIndex = 126;
            Label22.Text = "'";
            // 
            // Label21
            // 
            Label21.BackColor = SystemColors.Window;
            Label21.Cursor = Cursors.Default;
            Label21.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label21.ForeColor = SystemColors.ControlText;
            Label21.Location = new Point(277, 114);
            Label21.Name = "Label21";
            Label21.RightToLeft = RightToLeft.No;
            Label21.Size = new Size(25, 13);
            Label21.TabIndex = 125;
            Label21.Text = "Lo2";
            // 
            // Label20
            // 
            Label20.BackColor = SystemColors.Window;
            Label20.Cursor = Cursors.Default;
            Label20.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label20.ForeColor = SystemColors.ControlText;
            Label20.Location = new Point(334, 111);
            Label20.Name = "Label20";
            Label20.RightToLeft = RightToLeft.No;
            Label20.Size = new Size(9, 17);
            Label20.TabIndex = 124;
            Label20.Text = "°";
            // 
            // Label19
            // 
            Label19.BackColor = SystemColors.Window;
            Label19.Cursor = Cursors.Default;
            Label19.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label19.ForeColor = SystemColors.ControlText;
            Label19.Location = new Point(374, 111);
            Label19.Name = "Label19";
            Label19.RightToLeft = RightToLeft.No;
            Label19.Size = new Size(9, 17);
            Label19.TabIndex = 123;
            Label19.Text = "'";
            // 
            // Label18
            // 
            Label18.BackColor = SystemColors.Window;
            Label18.Cursor = Cursors.Default;
            Label18.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label18.ForeColor = SystemColors.ControlText;
            Label18.Location = new Point(382, 63);
            Label18.Name = "Label18";
            Label18.RightToLeft = RightToLeft.No;
            Label18.Size = new Size(16, 17);
            Label18.TabIndex = 122;
            Label18.Text = "°T";
            // 
            // Label17
            // 
            Label17.BackColor = SystemColors.Window;
            Label17.Cursor = Cursors.Default;
            Label17.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label17.ForeColor = SystemColors.ControlText;
            Label17.Location = new Point(198, 63);
            Label17.Name = "Label17";
            Label17.RightToLeft = RightToLeft.No;
            Label17.Size = new Size(16, 17);
            Label17.TabIndex = 121;
            Label17.Text = "°T";
            // 
            // lblDRL
            // 
            lblDRL.BackColor = SystemColors.Window;
            lblDRL.Cursor = Cursors.Default;
            lblDRL.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblDRL.ForeColor = SystemColors.ControlText;
            lblDRL.Location = new Point(93, 90);
            lblDRL.Name = "lblDRL";
            lblDRL.RightToLeft = RightToLeft.No;
            lblDRL.Size = new Size(20, 13);
            lblDRL.TabIndex = 120;
            lblDRL.Text = "L1";
            // 
            // lblLDeg
            // 
            lblLDeg.BackColor = SystemColors.Window;
            lblLDeg.Cursor = Cursors.Default;
            lblLDeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLDeg.ForeColor = SystemColors.ControlText;
            lblLDeg.Location = new Point(150, 87);
            lblLDeg.Name = "lblLDeg";
            lblLDeg.RightToLeft = RightToLeft.No;
            lblLDeg.Size = new Size(9, 17);
            lblLDeg.TabIndex = 119;
            lblLDeg.Text = "°";
            // 
            // lblLMin
            // 
            lblLMin.BackColor = SystemColors.Window;
            lblLMin.Cursor = Cursors.Default;
            lblLMin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLMin.ForeColor = SystemColors.ControlText;
            lblLMin.Location = new Point(190, 87);
            lblLMin.Name = "lblLMin";
            lblLMin.RightToLeft = RightToLeft.No;
            lblLMin.Size = new Size(9, 17);
            lblLMin.TabIndex = 118;
            lblLMin.Text = "'";
            // 
            // lblDRLo
            // 
            lblDRLo.BackColor = SystemColors.Window;
            lblDRLo.Cursor = Cursors.Default;
            lblDRLo.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblDRLo.ForeColor = SystemColors.ControlText;
            lblDRLo.Location = new Point(93, 114);
            lblDRLo.Name = "lblDRLo";
            lblDRLo.RightToLeft = RightToLeft.No;
            lblDRLo.Size = new Size(25, 13);
            lblDRLo.TabIndex = 117;
            lblDRLo.Text = "Lo1";
            // 
            // lblLoDeg
            // 
            lblLoDeg.BackColor = SystemColors.Window;
            lblLoDeg.Cursor = Cursors.Default;
            lblLoDeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLoDeg.ForeColor = SystemColors.ControlText;
            lblLoDeg.Location = new Point(150, 111);
            lblLoDeg.Name = "lblLoDeg";
            lblLoDeg.RightToLeft = RightToLeft.No;
            lblLoDeg.Size = new Size(9, 17);
            lblLoDeg.TabIndex = 116;
            lblLoDeg.Text = "°";
            // 
            // lblLoMin
            // 
            lblLoMin.BackColor = SystemColors.Window;
            lblLoMin.Cursor = Cursors.Default;
            lblLoMin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLoMin.ForeColor = SystemColors.ControlText;
            lblLoMin.Location = new Point(190, 111);
            lblLoMin.Name = "lblLoMin";
            lblLoMin.RightToLeft = RightToLeft.No;
            lblLoMin.Size = new Size(9, 17);
            lblLoMin.TabIndex = 115;
            lblLoMin.Text = "'";
            // 
            // Label16
            // 
            Label16.BackColor = SystemColors.Window;
            Label16.Cursor = Cursors.Default;
            Label16.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label16.ForeColor = SystemColors.ControlText;
            Label16.Location = new Point(109, 63);
            Label16.Name = "Label16";
            Label16.RightToLeft = RightToLeft.No;
            Label16.Size = new Size(49, 17);
            Label16.TabIndex = 114;
            Label16.Text = "Bearing 1";
            // 
            // Label15
            // 
            Label15.BackColor = SystemColors.Window;
            Label15.Cursor = Cursors.Default;
            Label15.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label15.ForeColor = SystemColors.ControlText;
            Label15.Location = new Point(117, 29);
            Label15.Name = "Label15";
            Label15.RightToLeft = RightToLeft.No;
            Label15.Size = new Size(289, 17);
            Label15.TabIndex = 98;
            Label15.Text = "Calculates a fix from two cross bearings on charted objects.";
            // 
            // FormTwoBearings
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(570, 486);
            Controls.Add(_cmdPrint);
            Controls.Add(TabControl1);
            Controls.Add(PictureBox1);
            Controls.Add(_ExitBtn);
            Cursor = Cursors.Default;
            Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(3, 29);
            MaximizeBox = false;
            Name = "FormTwoBearings";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Distance by Two Bearings/Fix by Cross Bearings/CMG by Three Bearings";
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            TabControl1.ResumeLayout(false);
            Distance.ResumeLayout(false);
            Distance.PerformLayout();
            Frame1.ResumeLayout(false);
            CMG.ResumeLayout(false);
            CMG.PerformLayout();
            Fix.ResumeLayout(false);
            Fix.PerformLayout();
            Load += new EventHandler(FormTwoBearings_Load);
            FormClosed += new FormClosedEventHandler(FormTwoBearings_FormClosed);
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

        internal PictureBox PictureBox1;
        internal TabControl TabControl1;
        internal TabPage Distance;
        internal RichTextBox DistanceTxtBx;
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

        public GroupBox Frame1;
        private RadioButton _optComp;

        public RadioButton optComp
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optComp;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optComp != null)
                {
                    _optComp.CheckedChanged -= optComp_CheckedChanged;
                }

                _optComp = value;
                if (_optComp != null)
                {
                    _optComp.CheckedChanged += optComp_CheckedChanged;
                }
            }
        }

        private RadioButton _optMag;

        public RadioButton optMag
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optMag;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optMag != null)
                {
                    _optMag.CheckedChanged -= optMag_CheckedChanged;
                }

                _optMag = value;
                if (_optMag != null)
                {
                    _optMag.CheckedChanged += optMag_CheckedChanged;
                }
            }
        }

        private RadioButton _optTrue;

        public RadioButton optTrue
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optTrue;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optTrue != null)
                {
                    _optTrue.CheckedChanged -= optTrue_CheckedChanged;
                }

                _optTrue = value;
                if (_optTrue != null)
                {
                    _optTrue.CheckedChanged += optTrue_CheckedChanged;
                }
            }
        }

        private RadioButton _optRel;

        public RadioButton optRel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optRel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optRel != null)
                {
                    _optRel.CheckedChanged -= optRel_CheckedChanged;
                }

                _optRel = value;
                if (_optRel != null)
                {
                    _optRel.CheckedChanged += optRel_CheckedChanged;
                }
            }
        }

        private Button _cmdClearD;

        public Button cmdClearD
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdClearD;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdClearD != null)
                {
                    _cmdClearD.Click -= cmdClearD_Click;
                }

                _cmdClearD = value;
                if (_cmdClearD != null)
                {
                    _cmdClearD.Click += cmdClearD_Click;
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
                    _txtDist.Enter -= txtDist_TextChanged;
                    _txtDist.KeyPress -= txtDist_KeyPress;
                    _txtDist.Validating -= txtDist_Validating;
                }

                _txtDist = value;
                if (_txtDist != null)
                {
                    _txtDist.TextChanged += txtDist_TextChanged;
                    _txtDist.Enter += txtDist_TextChanged;
                    _txtDist.KeyPress += txtDist_KeyPress;
                    _txtDist.Validating += txtDist_Validating;
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

        private Button _cmdCalculateD;

        public Button cmdCalculateD
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdCalculateD;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdCalculateD != null)
                {
                    _cmdCalculateD.Click -= cmdCalculateD_Click;
                }

                _cmdCalculateD = value;
                if (_cmdCalculateD != null)
                {
                    _cmdCalculateD.Click += cmdCalculateD_Click;
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

        public Label lblB2;
        public Label lblB1;
        public Label lblCourse;
        public Label lblVesselCourse;
        public Label Label4;
        public Label lblDistance;
        public Label lblnm;
        public Label lblor;
        public Label lblSpeed;
        public Label lblkn;
        public Label lblTime;
        public Label lblh;
        public Label lblm;
        public Label lblLog1;
        public Label lblLog2;
        public Label lblLog1nm;
        public Label lblLog2nm;
        public Label lblTime1;
        public Label lblTime2;
        public Label Label3;
        public Label Label2;
        public Label Label1;
        internal TabPage CMG;
        public TextBox txtResultCourse;
        private Button _cmdClearC;

        public Button cmdClearC
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdClearC;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdClearC != null)
                {
                    _cmdClearC.Click -= cmdClearC_Click;
                }

                _cmdClearC = value;
                if (_cmdClearC != null)
                {
                    _cmdClearC.Click += cmdClearC_Click;
                }
            }
        }

        private Button _cmdCalculateC;

        public Button cmdCalculateC
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdCalculateC;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdCalculateC != null)
                {
                    _cmdCalculateC.Click -= cmdCalculateC_Click;
                }

                _cmdCalculateC = value;
                if (_cmdCalculateC != null)
                {
                    _cmdCalculateC.Click += cmdCalculateC_Click;
                }
            }
        }

        private TextBox _txtB1;

        public TextBox txtB1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtB1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtB1 != null)
                {
                    _txtB1.KeyPress -= txtB1_KeyPress;
                    _txtB1.Validating -= txtB1_Validating;
                    _txtB1.Enter -= txtB1_Enter;
                    _txtB1.TextChanged -= txtB2_TextChanged;
                }

                _txtB1 = value;
                if (_txtB1 != null)
                {
                    _txtB1.KeyPress += txtB1_KeyPress;
                    _txtB1.Validating += txtB1_Validating;
                    _txtB1.Enter += txtB1_Enter;
                    _txtB1.TextChanged += txtB2_TextChanged;
                }
            }
        }

        private TextBox _txtI1;

        public TextBox txtI1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtI1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtI1 != null)
                {
                    _txtI1.TextChanged -= txtI1_TextChanged;
                    _txtI1.KeyPress -= txtI1_KeyPress;
                    _txtI1.Validating -= txtI1_Validating;
                    _txtI1.Enter -= txtI1_Enter;
                }

                _txtI1 = value;
                if (_txtI1 != null)
                {
                    _txtI1.TextChanged += txtI1_TextChanged;
                    _txtI1.KeyPress += txtI1_KeyPress;
                    _txtI1.Validating += txtI1_Validating;
                    _txtI1.Enter += txtI1_Enter;
                }
            }
        }

        private TextBox _txtB2;

        public TextBox txtB2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtB2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtB2 != null)
                {
                    _txtB2.Enter -= txtB1_Enter;
                    _txtB2.TextChanged -= txtB2_TextChanged;
                    _txtB2.KeyPress -= txtB2_KeyPress;
                    _txtB2.Validating -= txtB2_Validating;
                }

                _txtB2 = value;
                if (_txtB2 != null)
                {
                    _txtB2.Enter += txtB1_Enter;
                    _txtB2.TextChanged += txtB2_TextChanged;
                    _txtB2.KeyPress += txtB2_KeyPress;
                    _txtB2.Validating += txtB2_Validating;
                }
            }
        }

        private TextBox _txtI2;

        public TextBox txtI2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtI2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtI2 != null)
                {
                    _txtI2.TextChanged -= txtI2_TextChanged;
                    _txtI2.KeyPress -= txtI2_KeyPress;
                    _txtI2.Validating -= txtI2_Validating;
                    _txtI2.Enter -= txtI2_Enter;
                }

                _txtI2 = value;
                if (_txtI2 != null)
                {
                    _txtI2.TextChanged += txtI2_TextChanged;
                    _txtI2.KeyPress += txtI2_KeyPress;
                    _txtI2.Validating += txtI2_Validating;
                    _txtI2.Enter += txtI2_Enter;
                }
            }
        }

        private TextBox _txtB3;

        public TextBox txtB3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtB3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtB3 != null)
                {
                    _txtB3.TextChanged -= txtB3_TextChanged;
                    _txtB3.KeyPress -= txtB3_KeyPress;
                    _txtB3.Validating -= txtB3_Validating;
                    _txtB3.Enter -= txtB3_Enter;
                }

                _txtB3 = value;
                if (_txtB3 != null)
                {
                    _txtB3.TextChanged += txtB3_TextChanged;
                    _txtB3.KeyPress += txtB3_KeyPress;
                    _txtB3.Validating += txtB3_Validating;
                    _txtB3.Enter += txtB3_Enter;
                }
            }
        }

        public Label Label14;
        public Label Label13;
        public Label Label12;
        public Label Label11;
        public Label Label10;
        public Label Label6;
        public Label Label7;
        public Label Label8;
        public Label Label9;
        public Label Label5;
        internal TabPage Fix;
        public CheckBox chkReciprocal;
        public TextBox txtFixLo;
        public TextBox txtFixL;
        private Button _cmdClearF2;

        public Button cmdClearF2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdClearF2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdClearF2 != null)
                {
                    _cmdClearF2.Click -= cmdClearF2_Click;
                }

                _cmdClearF2 = value;
                if (_cmdClearF2 != null)
                {
                    _cmdClearF2.Click += cmdClearF2_Click;
                }
            }
        }

        private Button _cmdCalculateF2;

        public Button cmdCalculateF2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdCalculateF2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdCalculateF2 != null)
                {
                    _cmdCalculateF2.Click -= cmdCalculateF2_Click;
                }

                _cmdCalculateF2 = value;
                if (_cmdCalculateF2 != null)
                {
                    _cmdCalculateF2.Click += cmdCalculateF2_Click;
                }
            }
        }

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

        public ComboBox cboL2;
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

        public ComboBox cboLo2;
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

        public ComboBox cboL1;
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

        public ComboBox cboLo1;
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
                    _txtL1Deg.KeyPress -= txtL1Deg_KeyPress;
                    _txtL1Deg.Validating -= txtL1Deg_Validating;
                    _txtL1Deg.Enter -= txtL1Deg_Enter;
                    _txtL1Deg.TextChanged -= txtLo1Deg_TextChanged;
                }

                _txtL1Deg = value;
                if (_txtL1Deg != null)
                {
                    _txtL1Deg.KeyPress += txtL1Deg_KeyPress;
                    _txtL1Deg.Validating += txtL1Deg_Validating;
                    _txtL1Deg.Enter += txtL1Deg_Enter;
                    _txtL1Deg.TextChanged += txtLo1Deg_TextChanged;
                }
            }
        }

        private TextBox _txtBg2;

        public TextBox txtBg2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtBg2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtBg2 != null)
                {
                    _txtBg2.TextChanged -= txtBg2_TextChanged;
                    _txtBg2.KeyPress -= txtBg2_KeyPress;
                    _txtBg2.Validating -= txtBg2_Validating;
                    _txtBg2.Enter -= txtBg2_Enter;
                }

                _txtBg2 = value;
                if (_txtBg2 != null)
                {
                    _txtBg2.TextChanged += txtBg2_TextChanged;
                    _txtBg2.KeyPress += txtBg2_KeyPress;
                    _txtBg2.Validating += txtBg2_Validating;
                    _txtBg2.Enter += txtBg2_Enter;
                }
            }
        }

        private TextBox _txtBg1;

        public TextBox txtBg1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtBg1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtBg1 != null)
                {
                    _txtBg1.KeyPress -= txtBg1_KeyPress;
                    _txtBg1.Validating -= txtBg1_Validating;
                    _txtBg1.Enter -= txtBg1_Enter;
                    _txtBg1.TextChanged -= txtBg2_TextChanged;
                }

                _txtBg1 = value;
                if (_txtBg1 != null)
                {
                    _txtBg1.KeyPress += txtBg1_KeyPress;
                    _txtBg1.Validating += txtBg1_Validating;
                    _txtBg1.Enter += txtBg1_Enter;
                    _txtBg1.TextChanged += txtBg2_TextChanged;
                }
            }
        }

        public Label Label28;
        public Label Label27;
        public Label Label26;
        public Label Label25;
        public Label Label24;
        public Label Label23;
        public Label Label22;
        public Label Label21;
        public Label Label20;
        public Label Label19;
        public Label Label18;
        public Label Label17;
        public Label lblDRL;
        public Label lblLDeg;
        public Label lblLMin;
        public Label lblDRLo;
        public Label lblLoDeg;
        public Label lblLoMin;
        public Label Label16;
        public Label Label15;
        internal TextBox TextBox1;
        internal Label lblT2Fmt;
        internal Label lblT1Fmt;
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}