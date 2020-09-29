using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    [DesignerGenerated()]
    internal partial class FormNavMath
    {
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        [DebuggerNonUserCode()]
        public FormNavMath() : base()
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
        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNavMath));
            ToolTip1 = new ToolTip(components);
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
            lblZD1 = new Label();
            lblZD2 = new Label();
            _txtTime1 = new TextBox();
            _txtTime1.TextChanged += new EventHandler(txtTime1_TextChanged);
            _txtTime1.KeyPress += new KeyPressEventHandler(txtTime1_KeyPress);
            _txtTime1.Validating += new System.ComponentModel.CancelEventHandler(txtTime1_Validating);
            _txtTime1.Enter += new EventHandler(txtTime1_Enter);
            _chkDST1 = new CheckBox();
            _chkDST1.CheckedChanged += new EventHandler(chkDST1_CheckStateChanged);
            _txtZDh1 = new TextBox();
            _txtZDh1.TextChanged += new EventHandler(txtZDh1_TextChanged);
            _txtZDh1.KeyPress += new KeyPressEventHandler(txtZDh1_KeyPress);
            _txtZDh1.Validating += new System.ComponentModel.CancelEventHandler(txtZDh1_Validating);
            _txtZDh1.Enter += new EventHandler(txtZDh1_Enter);
            _chkDST2 = new CheckBox();
            _chkDST2.CheckStateChanged += new EventHandler(chkDST2_CheckStateChanged);
            _txtZDh2 = new TextBox();
            _txtZDh2.TextChanged += new EventHandler(txtZDh2_TextChanged);
            _txtZDh2.KeyPress += new KeyPressEventHandler(txtZDh2_KeyPress);
            _txtZDh2.Enter += new EventHandler(txtZDh2_Enter);
            _txtMin2 = new TextBox();
            _txtMin2.TextChanged += new EventHandler(txtMin2_TextChanged);
            _txtMin2.KeyPress += new KeyPressEventHandler(txtMin2_KeyPress);
            _txtMin2.Validating += new System.ComponentModel.CancelEventHandler(txtMin2_Validating);
            _txtMin2.Enter += new EventHandler(txtMin2_Enter);
            _txtDeg2 = new TextBox();
            _txtDeg2.TextChanged += new EventHandler(txtDeg2_TextChanged);
            _txtDeg2.KeyPress += new KeyPressEventHandler(txtDeg2_KeyPress);
            _txtDeg2.Validating += new System.ComponentModel.CancelEventHandler(txtDeg2_Validating);
            _txtDeg2.Enter += new EventHandler(txtDeg2_Enter);
            _txtMin1 = new TextBox();
            _txtMin1.TextChanged += new EventHandler(txtMin1_TextChanged);
            _txtMin1.KeyPress += new KeyPressEventHandler(txtMin1_KeyPress);
            _txtMin1.Validating += new System.ComponentModel.CancelEventHandler(txtMin1_Validating);
            _txtMin1.Enter += new EventHandler(txtMin1_Enter);
            _txtDeg1 = new TextBox();
            _txtDeg1.TextChanged += new EventHandler(txtDeg1_TextChanged);
            _txtDeg1.KeyPress += new KeyPressEventHandler(txtDeg1_KeyPress);
            _txtDeg1.Validating += new System.ComponentModel.CancelEventHandler(txtDeg1_Validating);
            _txtDeg1.Enter += new EventHandler(txtDeg1_Enter);
            _txtDeg3 = new TextBox();
            _txtDeg3.TextChanged += new EventHandler(txtDeg3_TextChanged);
            _txtDeg3.KeyPress += new KeyPressEventHandler(txtDeg3_KeyPress);
            _txtDeg3.Validating += new System.ComponentModel.CancelEventHandler(txtDeg3_Validating);
            _txtDeg3.Enter += new EventHandler(txtDeg3_Enter);
            _txtMin3 = new TextBox();
            _txtMin3.TextChanged += new EventHandler(txtMin3_TextChanged);
            _txtMin3.KeyPress += new KeyPressEventHandler(txtMin3_KeyPress);
            _txtMin3.Validating += new System.ComponentModel.CancelEventHandler(txtMin3_Validating);
            _txtMin3.Enter += new EventHandler(txtTime1_Enter);
            _txtHsSec = new TextBox();
            _txtHsSec.TextChanged += new EventHandler(txtHsSec_TextChanged);
            _txtHsSec.KeyPress += new KeyPressEventHandler(txtHsSec_KeyPress);
            _txtHsSec.Validating += new System.ComponentModel.CancelEventHandler(txtHsSec_Validating);
            _txtHsSec.Enter += new EventHandler(txtHsSec_Enter);
            _txtHsMin = new TextBox();
            _txtHsMin.TextChanged += new EventHandler(txtHsDeg_TextChanged);
            _txtHsMin.KeyPress += new KeyPressEventHandler(txtHsMin_KeyPress);
            _txtHsMin.Validating += new System.ComponentModel.CancelEventHandler(txtHsMin_Validating);
            _txtHsMin.Enter += new EventHandler(txtHsMin_Enter);
            _txtHsDeg = new TextBox();
            _txtHsDeg.TextChanged += new EventHandler(txtHsDeg_TextChanged);
            _txtHsDeg.KeyPress += new KeyPressEventHandler(txtHsDeg_KeyPress);
            _txtHsDeg.Validating += new System.ComponentModel.CancelEventHandler(txtHsDeg_Validating);
            _txtHsDeg.Enter += new EventHandler(txtHsDeg_Enter);
            _ExitBtn = new Button();
            _ExitBtn.Click += new EventHandler(ExitBtn_Click);
            TimeZoneCalc = new TabPage();
            _btnZDCalc = new Button();
            _btnZDCalc.Click += new EventHandler(btnZDCalc_Click);
            _cboLo = new ComboBox();
            _cboLo.SelectedIndexChanged += new EventHandler(cboLo_SelectedIndexChanged);
            txtZD = new TextBox();
            _cmdClearTZ = new Button();
            _cmdClearTZ.Click += new EventHandler(cmdClearTZ_Click);
            Label35 = new Label();
            lblLoDeg = new Label();
            lblLoMin = new Label();
            Label34 = new Label();
            Label24 = new Label();
            TimeofDateCalc = new TabPage();
            _txtIntD = new TextBox();
            _txtIntD.TextChanged += new EventHandler(txtIntD_TextChanged);
            _txtIntD.KeyPress += new KeyPressEventHandler(txtIntD_KeyPress);
            _txtIntD.Enter += new EventHandler(txtIntD_Enter);
            _txtIntM = new TextBox();
            _txtIntM.TextChanged += new EventHandler(txtIntM_TextChanged);
            _txtIntM.KeyPress += new KeyPressEventHandler(txtIntM_KeyPress);
            _txtIntM.Enter += new EventHandler(txtIntM_Enter);
            _txtIntH = new TextBox();
            _txtIntH.TextChanged += new EventHandler(txtIntH_TextChanged);
            _txtIntH.KeyPress += new KeyPressEventHandler(txtIntH_KeyPress);
            _txtIntH.Enter += new EventHandler(txtIntH_Enter);
            txtDays = new TextBox();
            txtTimeResult = new TextBox();
            Frame2 = new Panel();
            _optSubtractToD = new RadioButton();
            _optSubtractToD.CheckedChanged += new EventHandler(optSubtractToD_CheckedChanged);
            _optAddToD = new RadioButton();
            _optAddToD.CheckedChanged += new EventHandler(optAddToD_CheckedChanged);
            _cboZDm2 = new ComboBox();
            _cboZDm2.SelectedIndexChanged += new EventHandler(cboZDm2_SelectedIndexChanged);
            _cboZDm1 = new ComboBox();
            _cboZDm1.SelectedIndexChanged += new EventHandler(cboZDm1_SelectedIndexChanged);
            _cmdCalculateToD = new Button();
            _cmdCalculateToD.Click += new EventHandler(cmdCalculateToD_Click);
            _cmdClearToD = new Button();
            _cmdClearToD.Click += new EventHandler(cmdClearToD_Click);
            Label38 = new Label();
            Label36 = new Label();
            Label37 = new Label();
            Label26 = new Label();
            Label23 = new Label();
            lblZDh2 = new Label();
            lblZDm2 = new Label();
            lblZDDST2 = new Label();
            lblZDh1 = new Label();
            lblZDm1 = new Label();
            lblZDDST1 = new Label();
            Label25 = new Label();
            TextBox1 = new TextBox();
            TimeAddSubtract = new TabPage();
            Label10 = new Label();
            Label9 = new Label();
            _btnMoveResult = new Button();
            _btnMoveResult.Click += new EventHandler(btnMoveResult_Click);
            DTRSeconds = new NumericUpDown();
            DTRMinutes = new NumericUpDown();
            DTRHours = new NumericUpDown();
            DTRDays = new NumericUpDown();
            DT2Seconds = new NumericUpDown();
            DT2Minutes = new NumericUpDown();
            DT2Hours = new NumericUpDown();
            DT2Days = new NumericUpDown();
            Label8 = new Label();
            DT1Seconds = new NumericUpDown();
            DT1Minutes = new NumericUpDown();
            DT1Hours = new NumericUpDown();
            DT1Days = new NumericUpDown();
            Label7 = new Label();
            Label6 = new Label();
            Label5 = new Label();
            Label1 = new Label();
            _cmdClearTimes = new Button();
            _cmdClearTimes.Click += new EventHandler(cmdClearTimes_Click);
            _cmdCalculateTimes = new Button();
            _cmdCalculateTimes.Click += new EventHandler(cmdCalculateTimes_Click);
            Frame3 = new Panel();
            _optAddTimes = new RadioButton();
            _optAddTimes.CheckedChanged += new EventHandler(optAddTimes_CheckedChanged);
            _optSubtractTimes = new RadioButton();
            _optSubtractTimes.CheckedChanged += new EventHandler(optSubtractTimes_CheckedChanged);
            Label27 = new Label();
            AngleAddSubtract = new TabPage();
            _btnAddSubtract = new Button();
            _btnAddSubtract.Click += new EventHandler(btnAddSubtract_Click);
            txtResult = new TextBox();
            Frame4 = new Panel();
            _optSubtract2 = new RadioButton();
            _optSubtract2.CheckedChanged += new EventHandler(optSubtract2_CheckedChanged);
            _optAdd2 = new RadioButton();
            _optAdd2.CheckedChanged += new EventHandler(optAdd2_CheckedChanged);
            _cmdClearAddSubtract = new Button();
            _cmdClearAddSubtract.Click += new EventHandler(cmdClearAddSubtract_Click);
            Frame1 = new Panel();
            _optAdd1 = new RadioButton();
            _optAdd1.CheckedChanged += new EventHandler(optAdd1_CheckedChanged);
            _optSubtract1 = new RadioButton();
            _optSubtract1.CheckedChanged += new EventHandler(optSubtract1_CheckedChanged);
            Label42 = new Label();
            Label41 = new Label();
            Label20 = new Label();
            Label19 = new Label();
            Label18 = new Label();
            Label17 = new Label();
            Label16 = new Label();
            Label15 = new Label();
            Label4 = new Label();
            ConvertAngleorTime = new TabPage();
            GroupBox1 = new GroupBox();
            _optHsDMm = new RadioButton();
            _optHsDMm.CheckedChanged += new EventHandler(optHsDMm_CheckedChanged);
            _optHsDMS = new RadioButton();
            _optHsDMS.CheckedChanged += new EventHandler(optHsDMS_CheckedChanged);
            dtTime = new DateTimePicker();
            txtConvertedTime = new TextBox();
            txtAngle = new TextBox();
            _cmdClearConverter = new Button();
            _cmdClearConverter.Click += new EventHandler(cmdClearConverter_Click);
            _cmdConvert = new Button();
            _cmdConvert.Click += new EventHandler(cmdConvert_Click);
            Label3 = new Label();
            Label2 = new Label();
            lblHs = new Label();
            lblHsDeg = new Label();
            lblHsMin = new Label();
            lblHsSec = new Label();
            _TabControl1 = new TabControl();
            _TabControl1.SelectedIndexChanged += new EventHandler(TabControl1_SelectedIndexChanged);
            PictureBox1 = new PictureBox();
            _cmdPrint = new Button();
            _cmdPrint.Click += new EventHandler(cmdPrint_Click);
            Label11 = new Label();
            TimeZoneCalc.SuspendLayout();
            TimeofDateCalc.SuspendLayout();
            Frame2.SuspendLayout();
            TimeAddSubtract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DTRSeconds).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DTRMinutes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DTRHours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DTRDays).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DT2Seconds).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DT2Minutes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DT2Hours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DT2Days).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DT1Seconds).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DT1Minutes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DT1Hours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DT1Days).BeginInit();
            Frame3.SuspendLayout();
            AngleAddSubtract.SuspendLayout();
            Frame4.SuspendLayout();
            Frame1.SuspendLayout();
            ConvertAngleorTime.SuspendLayout();
            GroupBox1.SuspendLayout();
            _TabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtLoMin
            // 
            _txtLoMin.AcceptsReturn = true;
            _txtLoMin.BackColor = SystemColors.Window;
            _txtLoMin.Cursor = Cursors.IBeam;
            _txtLoMin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtLoMin.ForeColor = SystemColors.WindowText;
            _txtLoMin.Location = new Point(340, 38);
            _txtLoMin.MaxLength = 4;
            _txtLoMin.Name = "_txtLoMin";
            _txtLoMin.RightToLeft = RightToLeft.No;
            _txtLoMin.Size = new Size(33, 20);
            _txtLoMin.TabIndex = 119;
            ToolTip1.SetToolTip(_txtLoMin, "Range 0 to 59.9");
            // 
            // txtLoDeg
            // 
            _txtLoDeg.AcceptsReturn = true;
            _txtLoDeg.BackColor = SystemColors.Window;
            _txtLoDeg.Cursor = Cursors.IBeam;
            _txtLoDeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtLoDeg.ForeColor = SystemColors.WindowText;
            _txtLoDeg.Location = new Point(300, 38);
            _txtLoDeg.MaxLength = 3;
            _txtLoDeg.Name = "_txtLoDeg";
            _txtLoDeg.RightToLeft = RightToLeft.No;
            _txtLoDeg.Size = new Size(33, 20);
            _txtLoDeg.TabIndex = 118;
            ToolTip1.SetToolTip(_txtLoDeg, "Range 0 to 180");
            // 
            // lblZD1
            // 
            lblZD1.BackColor = SystemColors.Window;
            lblZD1.Cursor = Cursors.Default;
            lblZD1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblZD1.ForeColor = SystemColors.ControlText;
            lblZD1.Location = new Point(172, 88);
            lblZD1.Name = "lblZD1";
            lblZD1.RightToLeft = RightToLeft.No;
            lblZD1.Size = new Size(87, 17);
            lblZD1.TabIndex = 151;
            lblZD1.Text = "ZD at Location A";
            ToolTip1.SetToolTip(lblZD1, "Zone Description");
            // 
            // lblZD2
            // 
            lblZD2.BackColor = SystemColors.Window;
            lblZD2.Cursor = Cursors.Default;
            lblZD2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblZD2.ForeColor = SystemColors.ControlText;
            lblZD2.Location = new Point(172, 152);
            lblZD2.Name = "lblZD2";
            lblZD2.RightToLeft = RightToLeft.No;
            lblZD2.Size = new Size(81, 17);
            lblZD2.TabIndex = 155;
            lblZD2.Text = "ZD at Location B";
            ToolTip1.SetToolTip(lblZD2, "Zone Description");
            // 
            // txtTime1
            // 
            _txtTime1.AcceptsReturn = true;
            _txtTime1.BackColor = SystemColors.Window;
            _txtTime1.Cursor = Cursors.IBeam;
            _txtTime1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtTime1.ForeColor = SystemColors.WindowText;
            _txtTime1.Location = new Point(318, 59);
            _txtTime1.MaxLength = 4;
            _txtTime1.Name = "_txtTime1";
            _txtTime1.RightToLeft = RightToLeft.No;
            _txtTime1.Size = new Size(52, 20);
            _txtTime1.TabIndex = 132;
            ToolTip1.SetToolTip(_txtTime1, "Range 0000 to 2359");
            // 
            // chkDST1
            // 
            _chkDST1.BackColor = SystemColors.Window;
            _chkDST1.Cursor = Cursors.Default;
            _chkDST1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _chkDST1.ForeColor = SystemColors.ControlText;
            _chkDST1.Location = new Point(364, 87);
            _chkDST1.Name = "_chkDST1";
            _chkDST1.RightToLeft = RightToLeft.No;
            _chkDST1.Size = new Size(17, 17);
            _chkDST1.TabIndex = 135;
            _chkDST1.Text = "Check1";
            ToolTip1.SetToolTip(_chkDST1, "Check if Dayslight Saving is in effect");
            _chkDST1.UseVisualStyleBackColor = false;
            // 
            // txtZDh1
            // 
            _txtZDh1.AcceptsReturn = true;
            _txtZDh1.BackColor = SystemColors.Window;
            _txtZDh1.Cursor = Cursors.IBeam;
            _txtZDh1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtZDh1.ForeColor = SystemColors.WindowText;
            _txtZDh1.Location = new Point(260, 85);
            _txtZDh1.MaxLength = 3;
            _txtZDh1.Name = "_txtZDh1";
            _txtZDh1.RightToLeft = RightToLeft.No;
            _txtZDh1.Size = new Size(25, 20);
            _txtZDh1.TabIndex = 133;
            ToolTip1.SetToolTip(_txtZDh1, "Range -13 to +12.  Lo E is -.");
            // 
            // chkDST2
            // 
            _chkDST2.BackColor = SystemColors.Window;
            _chkDST2.Cursor = Cursors.Default;
            _chkDST2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _chkDST2.ForeColor = SystemColors.ControlText;
            _chkDST2.Location = new Point(364, 151);
            _chkDST2.Name = "_chkDST2";
            _chkDST2.RightToLeft = RightToLeft.No;
            _chkDST2.Size = new Size(17, 17);
            _chkDST2.TabIndex = 142;
            _chkDST2.Text = "Check1";
            ToolTip1.SetToolTip(_chkDST2, "Check if Dayslight Saving is in effect");
            _chkDST2.UseVisualStyleBackColor = false;
            // 
            // txtZDh2
            // 
            _txtZDh2.AcceptsReturn = true;
            _txtZDh2.BackColor = SystemColors.Window;
            _txtZDh2.Cursor = Cursors.IBeam;
            _txtZDh2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtZDh2.ForeColor = SystemColors.WindowText;
            _txtZDh2.Location = new Point(260, 149);
            _txtZDh2.MaxLength = 3;
            _txtZDh2.Name = "_txtZDh2";
            _txtZDh2.RightToLeft = RightToLeft.No;
            _txtZDh2.Size = new Size(25, 20);
            _txtZDh2.TabIndex = 140;
            ToolTip1.SetToolTip(_txtZDh2, "Range -13 to +12.  Lo E is -.");
            // 
            // txtMin2
            // 
            _txtMin2.AcceptsReturn = true;
            _txtMin2.BackColor = SystemColors.Window;
            _txtMin2.Cursor = Cursors.IBeam;
            _txtMin2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtMin2.ForeColor = SystemColors.WindowText;
            _txtMin2.Location = new Point(232, 50);
            _txtMin2.MaxLength = 4;
            _txtMin2.Name = "_txtMin2";
            _txtMin2.RightToLeft = RightToLeft.No;
            _txtMin2.Size = new Size(33, 20);
            _txtMin2.TabIndex = 140;
            ToolTip1.SetToolTip(_txtMin2, "Range 0 to 59.9");
            // 
            // txtDeg2
            // 
            _txtDeg2.AcceptsReturn = true;
            _txtDeg2.BackColor = SystemColors.Window;
            _txtDeg2.Cursor = Cursors.IBeam;
            _txtDeg2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtDeg2.ForeColor = SystemColors.WindowText;
            _txtDeg2.Location = new Point(189, 50);
            _txtDeg2.MaxLength = 3;
            _txtDeg2.Name = "_txtDeg2";
            _txtDeg2.RightToLeft = RightToLeft.No;
            _txtDeg2.Size = new Size(33, 20);
            _txtDeg2.TabIndex = 139;
            ToolTip1.SetToolTip(_txtDeg2, "Range 0 to 999");
            // 
            // txtMin1
            // 
            _txtMin1.AcceptsReturn = true;
            _txtMin1.BackColor = SystemColors.Window;
            _txtMin1.Cursor = Cursors.IBeam;
            _txtMin1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtMin1.ForeColor = SystemColors.WindowText;
            _txtMin1.Location = new Point(92, 50);
            _txtMin1.MaxLength = 4;
            _txtMin1.Name = "_txtMin1";
            _txtMin1.RightToLeft = RightToLeft.No;
            _txtMin1.Size = new Size(33, 20);
            _txtMin1.TabIndex = 138;
            ToolTip1.SetToolTip(_txtMin1, "Range 0 to 59.9");
            // 
            // txtDeg1
            // 
            _txtDeg1.AcceptsReturn = true;
            _txtDeg1.BackColor = SystemColors.Window;
            _txtDeg1.Cursor = Cursors.IBeam;
            _txtDeg1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtDeg1.ForeColor = SystemColors.WindowText;
            _txtDeg1.Location = new Point(50, 50);
            _txtDeg1.MaxLength = 3;
            _txtDeg1.Name = "_txtDeg1";
            _txtDeg1.RightToLeft = RightToLeft.No;
            _txtDeg1.Size = new Size(33, 20);
            _txtDeg1.TabIndex = 137;
            ToolTip1.SetToolTip(_txtDeg1, "Range 0 to 999");
            // 
            // txtDeg3
            // 
            _txtDeg3.AcceptsReturn = true;
            _txtDeg3.BackColor = SystemColors.Window;
            _txtDeg3.Cursor = Cursors.IBeam;
            _txtDeg3.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtDeg3.ForeColor = SystemColors.WindowText;
            _txtDeg3.Location = new Point(330, 50);
            _txtDeg3.MaxLength = 3;
            _txtDeg3.Name = "_txtDeg3";
            _txtDeg3.RightToLeft = RightToLeft.No;
            _txtDeg3.Size = new Size(33, 20);
            _txtDeg3.TabIndex = 141;
            ToolTip1.SetToolTip(_txtDeg3, "Range 0 to 999");
            // 
            // txtMin3
            // 
            _txtMin3.AcceptsReturn = true;
            _txtMin3.BackColor = SystemColors.Window;
            _txtMin3.Cursor = Cursors.IBeam;
            _txtMin3.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtMin3.ForeColor = SystemColors.WindowText;
            _txtMin3.Location = new Point(373, 50);
            _txtMin3.MaxLength = 4;
            _txtMin3.Name = "_txtMin3";
            _txtMin3.RightToLeft = RightToLeft.No;
            _txtMin3.Size = new Size(33, 20);
            _txtMin3.TabIndex = 142;
            ToolTip1.SetToolTip(_txtMin3, "Range 0 to 59.9");
            // 
            // txtHsSec
            // 
            _txtHsSec.AcceptsReturn = true;
            _txtHsSec.BackColor = SystemColors.Window;
            _txtHsSec.Cursor = Cursors.IBeam;
            _txtHsSec.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtHsSec.ForeColor = SystemColors.WindowText;
            _txtHsSec.Location = new Point(306, 71);
            _txtHsSec.MaxLength = 2;
            _txtHsSec.Name = "_txtHsSec";
            _txtHsSec.RightToLeft = RightToLeft.No;
            _txtHsSec.Size = new Size(33, 20);
            _txtHsSec.TabIndex = 86;
            ToolTip1.SetToolTip(_txtHsSec, "Range 0 to 59");
            _txtHsSec.Visible = false;
            // 
            // txtHsMin
            // 
            _txtHsMin.AcceptsReturn = true;
            _txtHsMin.BackColor = SystemColors.Window;
            _txtHsMin.Cursor = Cursors.IBeam;
            _txtHsMin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtHsMin.ForeColor = SystemColors.WindowText;
            _txtHsMin.Location = new Point(266, 71);
            _txtHsMin.MaxLength = 4;
            _txtHsMin.Name = "_txtHsMin";
            _txtHsMin.RightToLeft = RightToLeft.No;
            _txtHsMin.Size = new Size(33, 20);
            _txtHsMin.TabIndex = 85;
            ToolTip1.SetToolTip(_txtHsMin, "Range 0 to 59.9 (DM.m) or 59 (DMS)");
            // 
            // txtHsDeg
            // 
            _txtHsDeg.AcceptsReturn = true;
            _txtHsDeg.BackColor = SystemColors.Window;
            _txtHsDeg.Cursor = Cursors.IBeam;
            _txtHsDeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtHsDeg.ForeColor = SystemColors.WindowText;
            _txtHsDeg.Location = new Point(226, 71);
            _txtHsDeg.MaxLength = 3;
            _txtHsDeg.Name = "_txtHsDeg";
            _txtHsDeg.RightToLeft = RightToLeft.No;
            _txtHsDeg.Size = new Size(33, 20);
            _txtHsDeg.TabIndex = 84;
            ToolTip1.SetToolTip(_txtHsDeg, "Range 0 to 999");
            // 
            // ExitBtn
            // 
            _ExitBtn.BackColor = Color.Red;
            _ExitBtn.Cursor = Cursors.Default;
            _ExitBtn.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _ExitBtn.ForeColor = SystemColors.ControlLightLight;
            _ExitBtn.Location = new Point(534, 421);
            _ExitBtn.Name = "_ExitBtn";
            _ExitBtn.RightToLeft = RightToLeft.No;
            _ExitBtn.Size = new Size(73, 25);
            _ExitBtn.TabIndex = 137;
            _ExitBtn.Text = "Exit";
            _ExitBtn.UseVisualStyleBackColor = false;
            // 
            // TimeZoneCalc
            // 
            TimeZoneCalc.Controls.Add(_btnZDCalc);
            TimeZoneCalc.Controls.Add(_cboLo);
            TimeZoneCalc.Controls.Add(txtZD);
            TimeZoneCalc.Controls.Add(_txtLoDeg);
            TimeZoneCalc.Controls.Add(_txtLoMin);
            TimeZoneCalc.Controls.Add(_cmdClearTZ);
            TimeZoneCalc.Controls.Add(Label35);
            TimeZoneCalc.Controls.Add(lblLoDeg);
            TimeZoneCalc.Controls.Add(lblLoMin);
            TimeZoneCalc.Controls.Add(Label34);
            TimeZoneCalc.Controls.Add(Label24);
            TimeZoneCalc.Location = new Point(4, 22);
            TimeZoneCalc.Name = "TimeZoneCalc";
            TimeZoneCalc.Size = new Size(599, 367);
            TimeZoneCalc.TabIndex = 5;
            TimeZoneCalc.Text = "Time Zone Calc";
            TimeZoneCalc.UseVisualStyleBackColor = true;
            // 
            // btnZDCalc
            // 
            _btnZDCalc.BackColor = SystemColors.Control;
            _btnZDCalc.Cursor = Cursors.Default;
            _btnZDCalc.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnZDCalc.ForeColor = SystemColors.ControlText;
            _btnZDCalc.Location = new Point(214, 107);
            _btnZDCalc.Name = "_btnZDCalc";
            _btnZDCalc.RightToLeft = RightToLeft.No;
            _btnZDCalc.Size = new Size(82, 25);
            _btnZDCalc.TabIndex = 126;
            _btnZDCalc.Text = "Calculate ZD";
            _btnZDCalc.UseVisualStyleBackColor = false;
            // 
            // cboLo
            // 
            _cboLo.BackColor = SystemColors.Window;
            _cboLo.Cursor = Cursors.Default;
            _cboLo.DropDownStyle = ComboBoxStyle.DropDownList;
            _cboLo.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboLo.ForeColor = SystemColors.WindowText;
            _cboLo.Items.AddRange(new object[] { "W", "E" });
            _cboLo.Location = new Point(380, 38);
            _cboLo.Name = "_cboLo";
            _cboLo.RightToLeft = RightToLeft.No;
            _cboLo.Size = new Size(41, 22);
            _cboLo.TabIndex = 120;
            // 
            // txtZD
            // 
            txtZD.AcceptsReturn = true;
            txtZD.BackColor = SystemColors.Window;
            txtZD.BorderStyle = BorderStyle.FixedSingle;
            txtZD.Cursor = Cursors.IBeam;
            txtZD.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtZD.ForeColor = SystemColors.WindowText;
            txtZD.Location = new Point(300, 70);
            txtZD.MaxLength = 0;
            txtZD.Name = "txtZD";
            txtZD.ReadOnly = true;
            txtZD.RightToLeft = RightToLeft.No;
            txtZD.Size = new Size(49, 20);
            txtZD.TabIndex = 125;
            txtZD.TextAlign = HorizontalAlignment.Center;
            // 
            // cmdClearTZ
            // 
            _cmdClearTZ.BackColor = SystemColors.Control;
            _cmdClearTZ.Cursor = Cursors.Default;
            _cmdClearTZ.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdClearTZ.ForeColor = SystemColors.ControlText;
            _cmdClearTZ.Location = new Point(329, 107);
            _cmdClearTZ.Name = "_cmdClearTZ";
            _cmdClearTZ.RightToLeft = RightToLeft.No;
            _cmdClearTZ.Size = new Size(65, 25);
            _cmdClearTZ.TabIndex = 124;
            _cmdClearTZ.Text = "Clear";
            _cmdClearTZ.UseVisualStyleBackColor = false;
            // 
            // Label35
            // 
            Label35.BackColor = SystemColors.Window;
            Label35.Cursor = Cursors.Default;
            Label35.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label35.ForeColor = SystemColors.ControlText;
            Label35.Location = new Point(202, 70);
            Label35.Name = "Label35";
            Label35.RightToLeft = RightToLeft.No;
            Label35.Size = new Size(105, 17);
            Label35.TabIndex = 123;
            Label35.Text = "Zone Description (ZD)";
            // 
            // lblLoDeg
            // 
            lblLoDeg.BackColor = SystemColors.Window;
            lblLoDeg.Cursor = Cursors.Default;
            lblLoDeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLoDeg.ForeColor = SystemColors.ControlText;
            lblLoDeg.Location = new Point(333, 38);
            lblLoDeg.Name = "lblLoDeg";
            lblLoDeg.RightToLeft = RightToLeft.No;
            lblLoDeg.Size = new Size(9, 17);
            lblLoDeg.TabIndex = 122;
            lblLoDeg.Text = "°";
            // 
            // lblLoMin
            // 
            lblLoMin.BackColor = SystemColors.Window;
            lblLoMin.Cursor = Cursors.Default;
            lblLoMin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLoMin.ForeColor = SystemColors.ControlText;
            lblLoMin.Location = new Point(373, 38);
            lblLoMin.Name = "lblLoMin";
            lblLoMin.RightToLeft = RightToLeft.No;
            lblLoMin.Size = new Size(9, 17);
            lblLoMin.TabIndex = 121;
            lblLoMin.Text = "'";
            // 
            // Label34
            // 
            Label34.BackColor = SystemColors.Window;
            Label34.Cursor = Cursors.Default;
            Label34.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label34.ForeColor = SystemColors.ControlText;
            Label34.Location = new Point(202, 38);
            Label34.Name = "Label34";
            Label34.RightToLeft = RightToLeft.No;
            Label34.Size = new Size(54, 17);
            Label34.TabIndex = 117;
            Label34.Text = "Longitude";
            Label34.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label24
            // 
            Label24.BackColor = SystemColors.Window;
            Label24.Cursor = Cursors.Default;
            Label24.Font = new Font("Times New Roman", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label24.ForeColor = SystemColors.ControlText;
            Label24.Location = new Point(231, 9);
            Label24.Name = "Label24";
            Label24.RightToLeft = RightToLeft.No;
            Label24.Size = new Size(153, 21);
            Label24.TabIndex = 116;
            Label24.Text = "Time Zone Calculator";
            Label24.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TimeofDateCalc
            // 
            TimeofDateCalc.BorderStyle = BorderStyle.FixedSingle;
            TimeofDateCalc.Controls.Add(Label11);
            TimeofDateCalc.Controls.Add(_txtIntD);
            TimeofDateCalc.Controls.Add(_txtIntM);
            TimeofDateCalc.Controls.Add(_txtIntH);
            TimeofDateCalc.Controls.Add(_txtZDh2);
            TimeofDateCalc.Controls.Add(_txtZDh1);
            TimeofDateCalc.Controls.Add(txtDays);
            TimeofDateCalc.Controls.Add(txtTimeResult);
            TimeofDateCalc.Controls.Add(_txtTime1);
            TimeofDateCalc.Controls.Add(Frame2);
            TimeofDateCalc.Controls.Add(_cboZDm2);
            TimeofDateCalc.Controls.Add(_chkDST2);
            TimeofDateCalc.Controls.Add(_cboZDm1);
            TimeofDateCalc.Controls.Add(_chkDST1);
            TimeofDateCalc.Controls.Add(_cmdCalculateToD);
            TimeofDateCalc.Controls.Add(_cmdClearToD);
            TimeofDateCalc.Controls.Add(Label38);
            TimeofDateCalc.Controls.Add(Label36);
            TimeofDateCalc.Controls.Add(Label37);
            TimeofDateCalc.Controls.Add(Label26);
            TimeofDateCalc.Controls.Add(Label23);
            TimeofDateCalc.Controls.Add(lblZD2);
            TimeofDateCalc.Controls.Add(lblZDh2);
            TimeofDateCalc.Controls.Add(lblZDm2);
            TimeofDateCalc.Controls.Add(lblZDDST2);
            TimeofDateCalc.Controls.Add(lblZD1);
            TimeofDateCalc.Controls.Add(lblZDh1);
            TimeofDateCalc.Controls.Add(lblZDm1);
            TimeofDateCalc.Controls.Add(lblZDDST1);
            TimeofDateCalc.Controls.Add(Label25);
            TimeofDateCalc.Controls.Add(TextBox1);
            TimeofDateCalc.Location = new Point(4, 22);
            TimeofDateCalc.Name = "TimeofDateCalc";
            TimeofDateCalc.Size = new Size(599, 367);
            TimeofDateCalc.TabIndex = 4;
            TimeofDateCalc.Text = "Time of Day Calc";
            TimeofDateCalc.UseVisualStyleBackColor = true;
            // 
            // txtIntD
            // 
            _txtIntD.AcceptsReturn = true;
            _txtIntD.BackColor = SystemColors.Window;
            _txtIntD.Cursor = Cursors.IBeam;
            _txtIntD.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtIntD.ForeColor = SystemColors.WindowText;
            _txtIntD.Location = new Point(259, 117);
            _txtIntD.MaxLength = 0;
            _txtIntD.Name = "_txtIntD";
            _txtIntD.RightToLeft = RightToLeft.No;
            _txtIntD.Size = new Size(25, 20);
            _txtIntD.TabIndex = 137;
            // 
            // txtIntM
            // 
            _txtIntM.AcceptsReturn = true;
            _txtIntM.BackColor = SystemColors.Window;
            _txtIntM.Cursor = Cursors.IBeam;
            _txtIntM.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtIntM.ForeColor = SystemColors.WindowText;
            _txtIntM.Location = new Point(356, 117);
            _txtIntM.MaxLength = 0;
            _txtIntM.Name = "_txtIntM";
            _txtIntM.RightToLeft = RightToLeft.No;
            _txtIntM.Size = new Size(41, 20);
            _txtIntM.TabIndex = 139;
            // 
            // txtIntH
            // 
            _txtIntH.AcceptsReturn = true;
            _txtIntH.BackColor = SystemColors.Window;
            _txtIntH.Cursor = Cursors.IBeam;
            _txtIntH.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtIntH.ForeColor = SystemColors.WindowText;
            _txtIntH.Location = new Point(300, 117);
            _txtIntH.MaxLength = 0;
            _txtIntH.Name = "_txtIntH";
            _txtIntH.RightToLeft = RightToLeft.No;
            _txtIntH.Size = new Size(41, 20);
            _txtIntH.TabIndex = 138;
            // 
            // txtDays
            // 
            txtDays.AcceptsReturn = true;
            txtDays.BackColor = SystemColors.Window;
            txtDays.BorderStyle = BorderStyle.FixedSingle;
            txtDays.Cursor = Cursors.IBeam;
            txtDays.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtDays.ForeColor = SystemColors.WindowText;
            txtDays.Location = new Point(344, 181);
            txtDays.MaxLength = 0;
            txtDays.Name = "txtDays";
            txtDays.ReadOnly = true;
            txtDays.RightToLeft = RightToLeft.No;
            txtDays.Size = new Size(64, 20);
            txtDays.TabIndex = 146;
            txtDays.Visible = false;
            // 
            // txtTimeResult
            // 
            txtTimeResult.AcceptsReturn = true;
            txtTimeResult.BackColor = SystemColors.Window;
            txtTimeResult.BorderStyle = BorderStyle.FixedSingle;
            txtTimeResult.Cursor = Cursors.IBeam;
            txtTimeResult.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtTimeResult.ForeColor = SystemColors.WindowText;
            txtTimeResult.Location = new Point(260, 181);
            txtTimeResult.MaxLength = 0;
            txtTimeResult.Name = "txtTimeResult";
            txtTimeResult.ReadOnly = true;
            txtTimeResult.RightToLeft = RightToLeft.No;
            txtTimeResult.Size = new Size(81, 20);
            txtTimeResult.TabIndex = 145;
            txtTimeResult.TextAlign = HorizontalAlignment.Center;
            // 
            // Frame2
            // 
            Frame2.BackColor = SystemColors.Window;
            Frame2.Controls.Add(_optSubtractToD);
            Frame2.Controls.Add(_optAddToD);
            Frame2.Cursor = Cursors.Default;
            Frame2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Frame2.ForeColor = SystemColors.ControlText;
            Frame2.Location = new Point(211, 106);
            Frame2.Name = "Frame2";
            Frame2.RightToLeft = RightToLeft.No;
            Frame2.Size = new Size(42, 40);
            Frame2.TabIndex = 136;
            // 
            // optSubtractToD
            // 
            _optSubtractToD.BackColor = SystemColors.Window;
            _optSubtractToD.Cursor = Cursors.Default;
            _optSubtractToD.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _optSubtractToD.ForeColor = SystemColors.ControlText;
            _optSubtractToD.Location = new Point(8, 20);
            _optSubtractToD.Name = "_optSubtractToD";
            _optSubtractToD.RightToLeft = RightToLeft.No;
            _optSubtractToD.Size = new Size(33, 17);
            _optSubtractToD.TabIndex = 125;
            _optSubtractToD.TabStop = true;
            _optSubtractToD.Text = "-";
            _optSubtractToD.UseVisualStyleBackColor = false;
            // 
            // optAddToD
            // 
            _optAddToD.BackColor = SystemColors.Window;
            _optAddToD.Checked = true;
            _optAddToD.Cursor = Cursors.Default;
            _optAddToD.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optAddToD.ForeColor = SystemColors.ControlText;
            _optAddToD.Location = new Point(8, 4);
            _optAddToD.Name = "_optAddToD";
            _optAddToD.RightToLeft = RightToLeft.No;
            _optAddToD.Size = new Size(33, 17);
            _optAddToD.TabIndex = 124;
            _optAddToD.TabStop = true;
            _optAddToD.Text = "+";
            _optAddToD.UseVisualStyleBackColor = false;
            // 
            // cboZDm2
            // 
            _cboZDm2.BackColor = SystemColors.Window;
            _cboZDm2.Cursor = Cursors.Default;
            _cboZDm2.DropDownStyle = ComboBoxStyle.DropDownList;
            _cboZDm2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboZDm2.ForeColor = SystemColors.WindowText;
            _cboZDm2.Items.AddRange(new object[] { "00", "30", "45" });
            _cboZDm2.Location = new Point(300, 149);
            _cboZDm2.Name = "_cboZDm2";
            _cboZDm2.RightToLeft = RightToLeft.No;
            _cboZDm2.Size = new Size(41, 22);
            _cboZDm2.TabIndex = 141;
            // 
            // cboZDm1
            // 
            _cboZDm1.BackColor = SystemColors.Window;
            _cboZDm1.Cursor = Cursors.Default;
            _cboZDm1.DropDownStyle = ComboBoxStyle.DropDownList;
            _cboZDm1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboZDm1.ForeColor = SystemColors.WindowText;
            _cboZDm1.Items.AddRange(new object[] { "00", "30", "45" });
            _cboZDm1.Location = new Point(300, 85);
            _cboZDm1.Name = "_cboZDm1";
            _cboZDm1.RightToLeft = RightToLeft.No;
            _cboZDm1.Size = new Size(41, 22);
            _cboZDm1.TabIndex = 134;
            // 
            // cmdCalculateToD
            // 
            _cmdCalculateToD.BackColor = SystemColors.Control;
            _cmdCalculateToD.Cursor = Cursors.Default;
            _cmdCalculateToD.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdCalculateToD.ForeColor = SystemColors.ControlText;
            _cmdCalculateToD.Location = new Point(196, 233);
            _cmdCalculateToD.Name = "_cmdCalculateToD";
            _cmdCalculateToD.RightToLeft = RightToLeft.No;
            _cmdCalculateToD.Size = new Size(65, 25);
            _cmdCalculateToD.TabIndex = 143;
            _cmdCalculateToD.Text = "C&alculate";
            _cmdCalculateToD.UseVisualStyleBackColor = false;
            // 
            // cmdClearToD
            // 
            _cmdClearToD.BackColor = SystemColors.Control;
            _cmdClearToD.Cursor = Cursors.Default;
            _cmdClearToD.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdClearToD.ForeColor = SystemColors.ControlText;
            _cmdClearToD.Location = new Point(300, 233);
            _cmdClearToD.Name = "_cmdClearToD";
            _cmdClearToD.RightToLeft = RightToLeft.No;
            _cmdClearToD.Size = new Size(65, 25);
            _cmdClearToD.TabIndex = 144;
            _cmdClearToD.Text = "Cl&ear";
            _cmdClearToD.UseVisualStyleBackColor = false;
            // 
            // Label38
            // 
            Label38.BackColor = SystemColors.Window;
            Label38.Cursor = Cursors.Default;
            Label38.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label38.ForeColor = SystemColors.ControlText;
            Label38.Location = new Point(170, 117);
            Label38.Name = "Label38";
            Label38.RightToLeft = RightToLeft.No;
            Label38.Size = new Size(45, 17);
            Label38.TabIndex = 160;
            Label38.Text = "Interval";
            // 
            // Label36
            // 
            Label36.BackColor = SystemColors.Window;
            Label36.Cursor = Cursors.Default;
            Label36.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label36.ForeColor = SystemColors.ControlText;
            Label36.Location = new Point(172, 181);
            Label36.Name = "Label36";
            Label36.RightToLeft = RightToLeft.No;
            Label36.Size = new Size(89, 17);
            Label36.TabIndex = 159;
            Label36.Text = "ZT at Location B";
            // 
            // Label37
            // 
            Label37.BackColor = SystemColors.Window;
            Label37.Cursor = Cursors.Default;
            Label37.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label37.ForeColor = SystemColors.ControlText;
            Label37.Location = new Point(285, 117);
            Label37.Name = "Label37";
            Label37.RightToLeft = RightToLeft.No;
            Label37.Size = new Size(9, 17);
            Label37.TabIndex = 158;
            Label37.Text = "d";
            // 
            // Label26
            // 
            Label26.BackColor = SystemColors.Window;
            Label26.Cursor = Cursors.Default;
            Label26.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label26.ForeColor = SystemColors.ControlText;
            Label26.Location = new Point(341, 117);
            Label26.Name = "Label26";
            Label26.RightToLeft = RightToLeft.No;
            Label26.Size = new Size(11, 17);
            Label26.TabIndex = 157;
            Label26.Text = "h";
            // 
            // Label23
            // 
            Label23.BackColor = SystemColors.Window;
            Label23.Cursor = Cursors.Default;
            Label23.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label23.ForeColor = SystemColors.ControlText;
            Label23.Location = new Point(397, 117);
            Label23.Name = "Label23";
            Label23.RightToLeft = RightToLeft.No;
            Label23.Size = new Size(11, 17);
            Label23.TabIndex = 156;
            Label23.Text = "m";
            // 
            // lblZDh2
            // 
            lblZDh2.BackColor = SystemColors.Window;
            lblZDh2.Cursor = Cursors.Default;
            lblZDh2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblZDh2.ForeColor = SystemColors.ControlText;
            lblZDh2.Location = new Point(285, 152);
            lblZDh2.Name = "lblZDh2";
            lblZDh2.RightToLeft = RightToLeft.No;
            lblZDh2.Size = new Size(9, 17);
            lblZDh2.TabIndex = 154;
            lblZDh2.Text = "h";
            // 
            // lblZDm2
            // 
            lblZDm2.BackColor = SystemColors.Window;
            lblZDm2.Cursor = Cursors.Default;
            lblZDm2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblZDm2.ForeColor = SystemColors.ControlText;
            lblZDm2.Location = new Point(341, 152);
            lblZDm2.Name = "lblZDm2";
            lblZDm2.RightToLeft = RightToLeft.No;
            lblZDm2.Size = new Size(11, 17);
            lblZDm2.TabIndex = 153;
            lblZDm2.Text = "m";
            // 
            // lblZDDST2
            // 
            lblZDDST2.BackColor = SystemColors.Window;
            lblZDDST2.Cursor = Cursors.Default;
            lblZDDST2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblZDDST2.ForeColor = SystemColors.ControlText;
            lblZDDST2.Location = new Point(381, 152);
            lblZDDST2.Name = "lblZDDST2";
            lblZDDST2.RightToLeft = RightToLeft.No;
            lblZDDST2.Size = new Size(33, 13);
            lblZDDST2.TabIndex = 152;
            lblZDDST2.Text = "DST";
            // 
            // lblZDh1
            // 
            lblZDh1.BackColor = SystemColors.Window;
            lblZDh1.Cursor = Cursors.Default;
            lblZDh1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblZDh1.ForeColor = SystemColors.ControlText;
            lblZDh1.Location = new Point(285, 88);
            lblZDh1.Name = "lblZDh1";
            lblZDh1.RightToLeft = RightToLeft.No;
            lblZDh1.Size = new Size(9, 17);
            lblZDh1.TabIndex = 150;
            lblZDh1.Text = "h";
            // 
            // lblZDm1
            // 
            lblZDm1.BackColor = SystemColors.Window;
            lblZDm1.Cursor = Cursors.Default;
            lblZDm1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblZDm1.ForeColor = SystemColors.ControlText;
            lblZDm1.Location = new Point(341, 88);
            lblZDm1.Name = "lblZDm1";
            lblZDm1.RightToLeft = RightToLeft.No;
            lblZDm1.Size = new Size(11, 17);
            lblZDm1.TabIndex = 149;
            lblZDm1.Text = "m";
            // 
            // lblZDDST1
            // 
            lblZDDST1.BackColor = SystemColors.Window;
            lblZDDST1.Cursor = Cursors.Default;
            lblZDDST1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblZDDST1.ForeColor = SystemColors.ControlText;
            lblZDDST1.Location = new Point(381, 88);
            lblZDDST1.Name = "lblZDDST1";
            lblZDDST1.RightToLeft = RightToLeft.No;
            lblZDDST1.Size = new Size(33, 13);
            lblZDDST1.TabIndex = 148;
            lblZDDST1.Text = "DST";
            // 
            // Label25
            // 
            Label25.BackColor = SystemColors.Window;
            Label25.Cursor = Cursors.Default;
            Label25.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label25.ForeColor = SystemColors.ControlText;
            Label25.Location = new Point(172, 61);
            Label25.Name = "Label25";
            Label25.RightToLeft = RightToLeft.No;
            Label25.Size = new Size(140, 17);
            Label25.TabIndex = 147;
            Label25.Text = "ZT at Location A (hhmmss)";
            // 
            // TextBox1
            // 
            TextBox1.BackColor = SystemColors.Info;
            TextBox1.Location = new Point(165, 40);
            TextBox1.Multiline = true;
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(252, 187);
            TextBox1.TabIndex = 170;
            // 
            // TimeAddSubtract
            // 
            TimeAddSubtract.Controls.Add(Label10);
            TimeAddSubtract.Controls.Add(Label9);
            TimeAddSubtract.Controls.Add(_btnMoveResult);
            TimeAddSubtract.Controls.Add(DTRSeconds);
            TimeAddSubtract.Controls.Add(DTRMinutes);
            TimeAddSubtract.Controls.Add(DTRHours);
            TimeAddSubtract.Controls.Add(DTRDays);
            TimeAddSubtract.Controls.Add(DT2Seconds);
            TimeAddSubtract.Controls.Add(DT2Minutes);
            TimeAddSubtract.Controls.Add(DT2Hours);
            TimeAddSubtract.Controls.Add(DT2Days);
            TimeAddSubtract.Controls.Add(Label8);
            TimeAddSubtract.Controls.Add(DT1Seconds);
            TimeAddSubtract.Controls.Add(DT1Minutes);
            TimeAddSubtract.Controls.Add(DT1Hours);
            TimeAddSubtract.Controls.Add(DT1Days);
            TimeAddSubtract.Controls.Add(Label7);
            TimeAddSubtract.Controls.Add(Label6);
            TimeAddSubtract.Controls.Add(Label5);
            TimeAddSubtract.Controls.Add(Label1);
            TimeAddSubtract.Controls.Add(_cmdClearTimes);
            TimeAddSubtract.Controls.Add(_cmdCalculateTimes);
            TimeAddSubtract.Controls.Add(Frame3);
            TimeAddSubtract.Controls.Add(Label27);
            TimeAddSubtract.Location = new Point(4, 22);
            TimeAddSubtract.Name = "TimeAddSubtract";
            TimeAddSubtract.Size = new Size(599, 367);
            TimeAddSubtract.TabIndex = 3;
            TimeAddSubtract.Text = "Time Add or Subtract";
            TimeAddSubtract.UseVisualStyleBackColor = true;
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.Location = new Point(35, 126);
            Label10.Name = "Label10";
            Label10.Size = new Size(147, 13);
            Label10.TabIndex = 185;
            Label10.Text = "Time Period 2: Dy/Hr/Min/Sec";
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Location = new Point(35, 88);
            Label9.Name = "Label9";
            Label9.Size = new Size(147, 13);
            Label9.TabIndex = 184;
            Label9.Text = "Time Period 1: Dy/Hr/Min/Sec";
            // 
            // btnMoveResult
            // 
            _btnMoveResult.BackColor = SystemColors.Control;
            _btnMoveResult.Cursor = Cursors.Default;
            _btnMoveResult.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnMoveResult.ForeColor = SystemColors.ControlText;
            _btnMoveResult.Location = new Point(279, 200);
            _btnMoveResult.Name = "_btnMoveResult";
            _btnMoveResult.RightToLeft = RightToLeft.No;
            _btnMoveResult.Size = new Size(121, 25);
            _btnMoveResult.TabIndex = 183;
            _btnMoveResult.Text = "Move Result to Start";
            _btnMoveResult.UseVisualStyleBackColor = false;
            // 
            // DTRSeconds
            // 
            DTRSeconds.Location = new Point(365, 160);
            DTRSeconds.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            DTRSeconds.Name = "DTRSeconds";
            DTRSeconds.Size = new Size(35, 21);
            DTRSeconds.TabIndex = 182;
            // 
            // DTRMinutes
            // 
            DTRMinutes.Location = new Point(302, 160);
            DTRMinutes.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            DTRMinutes.Name = "DTRMinutes";
            DTRMinutes.Size = new Size(35, 21);
            DTRMinutes.TabIndex = 181;
            // 
            // DTRHours
            // 
            DTRHours.Location = new Point(246, 160);
            DTRHours.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            DTRHours.Name = "DTRHours";
            DTRHours.Size = new Size(35, 21);
            DTRHours.TabIndex = 180;
            // 
            // DTRDays
            // 
            DTRDays.Location = new Point(186, 160);
            DTRDays.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            DTRDays.Name = "DTRDays";
            DTRDays.Size = new Size(35, 21);
            DTRDays.TabIndex = 179;
            // 
            // DT2Seconds
            // 
            DT2Seconds.Location = new Point(365, 122);
            DT2Seconds.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            DT2Seconds.Name = "DT2Seconds";
            DT2Seconds.Size = new Size(35, 21);
            DT2Seconds.TabIndex = 178;
            // 
            // DT2Minutes
            // 
            DT2Minutes.Location = new Point(302, 122);
            DT2Minutes.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            DT2Minutes.Name = "DT2Minutes";
            DT2Minutes.Size = new Size(35, 21);
            DT2Minutes.TabIndex = 177;
            // 
            // DT2Hours
            // 
            DT2Hours.Location = new Point(246, 122);
            DT2Hours.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            DT2Hours.Name = "DT2Hours";
            DT2Hours.Size = new Size(35, 21);
            DT2Hours.TabIndex = 176;
            // 
            // DT2Days
            // 
            DT2Days.Location = new Point(186, 122);
            DT2Days.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            DT2Days.Name = "DT2Days";
            DT2Days.Size = new Size(35, 21);
            DT2Days.TabIndex = 175;
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Location = new Point(359, 58);
            Label8.Name = "Label8";
            Label8.Size = new Size(47, 13);
            Label8.TabIndex = 174;
            Label8.Text = "Seconds";
            Label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DT1Seconds
            // 
            DT1Seconds.Location = new Point(365, 84);
            DT1Seconds.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            DT1Seconds.Name = "DT1Seconds";
            DT1Seconds.Size = new Size(35, 21);
            DT1Seconds.TabIndex = 173;
            // 
            // DT1Minutes
            // 
            DT1Minutes.Location = new Point(302, 84);
            DT1Minutes.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            DT1Minutes.Name = "DT1Minutes";
            DT1Minutes.Size = new Size(35, 21);
            DT1Minutes.TabIndex = 172;
            // 
            // DT1Hours
            // 
            DT1Hours.Location = new Point(246, 84);
            DT1Hours.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            DT1Hours.Name = "DT1Hours";
            DT1Hours.Size = new Size(35, 21);
            DT1Hours.TabIndex = 171;
            // 
            // DT1Days
            // 
            DT1Days.Location = new Point(186, 84);
            DT1Days.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            DT1Days.Name = "DT1Days";
            DT1Days.Size = new Size(35, 21);
            DT1Days.TabIndex = 170;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Location = new Point(299, 57);
            Label7.Name = "Label7";
            Label7.Size = new Size(44, 13);
            Label7.TabIndex = 169;
            Label7.Text = "Minutes";
            Label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Location = new Point(245, 56);
            Label6.Name = "Label6";
            Label6.Size = new Size(35, 13);
            Label6.TabIndex = 165;
            Label6.Text = "Hours";
            Label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Location = new Point(187, 57);
            Label5.Name = "Label5";
            Label5.Size = new Size(34, 13);
            Label5.TabIndex = 164;
            Label5.Text = "Days " + '\r' + '\n';
            Label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(165, 162);
            Label1.Name = "Label1";
            Label1.Size = new Size(15, 13);
            Label1.TabIndex = 159;
            Label1.Text = "=";
            // 
            // cmdClearTimes
            // 
            _cmdClearTimes.BackColor = SystemColors.Control;
            _cmdClearTimes.Cursor = Cursors.Default;
            _cmdClearTimes.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdClearTimes.ForeColor = SystemColors.ControlText;
            _cmdClearTimes.Location = new Point(186, 200);
            _cmdClearTimes.Name = "_cmdClearTimes";
            _cmdClearTimes.RightToLeft = RightToLeft.No;
            _cmdClearTimes.Size = new Size(65, 25);
            _cmdClearTimes.TabIndex = 151;
            _cmdClearTimes.Text = "Cle&ar";
            _cmdClearTimes.UseVisualStyleBackColor = false;
            // 
            // cmdCalculateTimes
            // 
            _cmdCalculateTimes.BackColor = SystemColors.Control;
            _cmdCalculateTimes.Cursor = Cursors.Default;
            _cmdCalculateTimes.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdCalculateTimes.ForeColor = SystemColors.ControlText;
            _cmdCalculateTimes.Location = new Point(27, 157);
            _cmdCalculateTimes.Name = "_cmdCalculateTimes";
            _cmdCalculateTimes.RightToLeft = RightToLeft.No;
            _cmdCalculateTimes.Size = new Size(65, 25);
            _cmdCalculateTimes.TabIndex = 150;
            _cmdCalculateTimes.Text = "Calc&ulate";
            _cmdCalculateTimes.UseVisualStyleBackColor = false;
            // 
            // Frame3
            // 
            Frame3.BackColor = SystemColors.Window;
            Frame3.Controls.Add(_optAddTimes);
            Frame3.Controls.Add(_optSubtractTimes);
            Frame3.Cursor = Cursors.Default;
            Frame3.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Frame3.ForeColor = SystemColors.ControlText;
            Frame3.Location = new Point(116, 150);
            Frame3.Name = "Frame3";
            Frame3.RightToLeft = RightToLeft.No;
            Frame3.Size = new Size(45, 40);
            Frame3.TabIndex = 142;
            // 
            // optAddTimes
            // 
            _optAddTimes.BackColor = SystemColors.Window;
            _optAddTimes.Checked = true;
            _optAddTimes.Cursor = Cursors.Default;
            _optAddTimes.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optAddTimes.ForeColor = SystemColors.ControlText;
            _optAddTimes.Location = new Point(8, 4);
            _optAddTimes.Name = "_optAddTimes";
            _optAddTimes.RightToLeft = RightToLeft.No;
            _optAddTimes.Size = new Size(33, 17);
            _optAddTimes.TabIndex = 92;
            _optAddTimes.TabStop = true;
            _optAddTimes.Text = "+";
            _optAddTimes.UseVisualStyleBackColor = false;
            // 
            // optSubtractTimes
            // 
            _optSubtractTimes.BackColor = SystemColors.Window;
            _optSubtractTimes.Cursor = Cursors.Default;
            _optSubtractTimes.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _optSubtractTimes.ForeColor = SystemColors.ControlText;
            _optSubtractTimes.Location = new Point(8, 20);
            _optSubtractTimes.Name = "_optSubtractTimes";
            _optSubtractTimes.RightToLeft = RightToLeft.No;
            _optSubtractTimes.Size = new Size(33, 17);
            _optSubtractTimes.TabIndex = 93;
            _optSubtractTimes.TabStop = true;
            _optSubtractTimes.Text = "-";
            _optSubtractTimes.UseVisualStyleBackColor = false;
            // 
            // Label27
            // 
            Label27.BackColor = SystemColors.Window;
            Label27.Cursor = Cursors.Default;
            Label27.Font = new Font("Times New Roman", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label27.ForeColor = SystemColors.ControlText;
            Label27.Location = new Point(178, 14);
            Label27.Name = "Label27";
            Label27.RightToLeft = RightToLeft.No;
            Label27.Size = new Size(247, 21);
            Label27.TabIndex = 134;
            Label27.Text = "Time Addition/Subtraction/Conversion";
            // 
            // AngleAddSubtract
            // 
            AngleAddSubtract.Controls.Add(_btnAddSubtract);
            AngleAddSubtract.Controls.Add(_txtMin3);
            AngleAddSubtract.Controls.Add(_txtDeg3);
            AngleAddSubtract.Controls.Add(txtResult);
            AngleAddSubtract.Controls.Add(_txtDeg1);
            AngleAddSubtract.Controls.Add(_txtMin1);
            AngleAddSubtract.Controls.Add(_txtDeg2);
            AngleAddSubtract.Controls.Add(_txtMin2);
            AngleAddSubtract.Controls.Add(Frame4);
            AngleAddSubtract.Controls.Add(_cmdClearAddSubtract);
            AngleAddSubtract.Controls.Add(Frame1);
            AngleAddSubtract.Controls.Add(Label42);
            AngleAddSubtract.Controls.Add(Label41);
            AngleAddSubtract.Controls.Add(Label20);
            AngleAddSubtract.Controls.Add(Label19);
            AngleAddSubtract.Controls.Add(Label18);
            AngleAddSubtract.Controls.Add(Label17);
            AngleAddSubtract.Controls.Add(Label16);
            AngleAddSubtract.Controls.Add(Label15);
            AngleAddSubtract.Controls.Add(Label4);
            AngleAddSubtract.Location = new Point(4, 22);
            AngleAddSubtract.Name = "AngleAddSubtract";
            AngleAddSubtract.Size = new Size(599, 367);
            AngleAddSubtract.TabIndex = 2;
            AngleAddSubtract.Text = "Angle Add or Subtract";
            AngleAddSubtract.UseVisualStyleBackColor = true;
            // 
            // btnAddSubtract
            // 
            _btnAddSubtract.BackColor = SystemColors.Control;
            _btnAddSubtract.Cursor = Cursors.Default;
            _btnAddSubtract.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnAddSubtract.ForeColor = SystemColors.ControlText;
            _btnAddSubtract.Location = new Point(196, 94);
            _btnAddSubtract.Name = "_btnAddSubtract";
            _btnAddSubtract.RightToLeft = RightToLeft.No;
            _btnAddSubtract.Size = new Size(70, 25);
            _btnAddSubtract.TabIndex = 155;
            _btnAddSubtract.Text = "Calculate";
            _btnAddSubtract.UseVisualStyleBackColor = false;
            // 
            // txtResult
            // 
            txtResult.AcceptsReturn = true;
            txtResult.BackColor = SystemColors.Window;
            txtResult.BorderStyle = BorderStyle.FixedSingle;
            txtResult.Cursor = Cursors.IBeam;
            txtResult.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtResult.ForeColor = SystemColors.WindowText;
            txtResult.Location = new Point(435, 50);
            txtResult.MaxLength = 0;
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.RightToLeft = RightToLeft.No;
            txtResult.Size = new Size(108, 20);
            txtResult.TabIndex = 151;
            txtResult.TabStop = false;
            txtResult.TextAlign = HorizontalAlignment.Center;
            // 
            // Frame4
            // 
            Frame4.BackColor = SystemColors.Window;
            Frame4.Controls.Add(_optSubtract2);
            Frame4.Controls.Add(_optAdd2);
            Frame4.Cursor = Cursors.Default;
            Frame4.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Frame4.ForeColor = SystemColors.ControlText;
            Frame4.Location = new Point(278, 42);
            Frame4.Name = "Frame4";
            Frame4.RightToLeft = RightToLeft.No;
            Frame4.Size = new Size(45, 40);
            Frame4.TabIndex = 152;
            // 
            // optSubtract2
            // 
            _optSubtract2.BackColor = SystemColors.Window;
            _optSubtract2.Cursor = Cursors.Default;
            _optSubtract2.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _optSubtract2.ForeColor = SystemColors.ControlText;
            _optSubtract2.Location = new Point(8, 20);
            _optSubtract2.Name = "_optSubtract2";
            _optSubtract2.RightToLeft = RightToLeft.No;
            _optSubtract2.Size = new Size(33, 17);
            _optSubtract2.TabIndex = 53;
            _optSubtract2.TabStop = true;
            _optSubtract2.Text = "-";
            _optSubtract2.UseVisualStyleBackColor = false;
            // 
            // optAdd2
            // 
            _optAdd2.BackColor = SystemColors.Window;
            _optAdd2.Checked = true;
            _optAdd2.Cursor = Cursors.Default;
            _optAdd2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optAdd2.ForeColor = SystemColors.ControlText;
            _optAdd2.Location = new Point(8, 4);
            _optAdd2.Name = "_optAdd2";
            _optAdd2.RightToLeft = RightToLeft.No;
            _optAdd2.Size = new Size(33, 17);
            _optAdd2.TabIndex = 52;
            _optAdd2.TabStop = true;
            _optAdd2.Text = "+";
            _optAdd2.UseVisualStyleBackColor = false;
            // 
            // cmdClearAddSubtract
            // 
            _cmdClearAddSubtract.BackColor = SystemColors.Control;
            _cmdClearAddSubtract.Cursor = Cursors.Default;
            _cmdClearAddSubtract.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdClearAddSubtract.ForeColor = SystemColors.ControlText;
            _cmdClearAddSubtract.Location = new Point(330, 94);
            _cmdClearAddSubtract.Name = "_cmdClearAddSubtract";
            _cmdClearAddSubtract.RightToLeft = RightToLeft.No;
            _cmdClearAddSubtract.Size = new Size(73, 25);
            _cmdClearAddSubtract.TabIndex = 143;
            _cmdClearAddSubtract.Text = "C&lear";
            _cmdClearAddSubtract.UseVisualStyleBackColor = false;
            // 
            // Frame1
            // 
            Frame1.BackColor = SystemColors.Window;
            Frame1.Controls.Add(_optAdd1);
            Frame1.Controls.Add(_optSubtract1);
            Frame1.Cursor = Cursors.Default;
            Frame1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Frame1.ForeColor = SystemColors.ControlText;
            Frame1.Location = new Point(139, 41);
            Frame1.Name = "Frame1";
            Frame1.RightToLeft = RightToLeft.No;
            Frame1.Size = new Size(45, 40);
            Frame1.TabIndex = 136;
            // 
            // optAdd1
            // 
            _optAdd1.BackColor = SystemColors.Window;
            _optAdd1.Checked = true;
            _optAdd1.Cursor = Cursors.Default;
            _optAdd1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optAdd1.ForeColor = SystemColors.ControlText;
            _optAdd1.Location = new Point(8, 4);
            _optAdd1.Name = "_optAdd1";
            _optAdd1.RightToLeft = RightToLeft.No;
            _optAdd1.Size = new Size(33, 17);
            _optAdd1.TabIndex = 48;
            _optAdd1.TabStop = true;
            _optAdd1.Text = "+";
            _optAdd1.UseVisualStyleBackColor = false;
            // 
            // optSubtract1
            // 
            _optSubtract1.BackColor = SystemColors.Window;
            _optSubtract1.Cursor = Cursors.Default;
            _optSubtract1.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _optSubtract1.ForeColor = SystemColors.ControlText;
            _optSubtract1.Location = new Point(8, 20);
            _optSubtract1.Name = "_optSubtract1";
            _optSubtract1.RightToLeft = RightToLeft.No;
            _optSubtract1.Size = new Size(33, 17);
            _optSubtract1.TabIndex = 49;
            _optSubtract1.TabStop = true;
            _optSubtract1.Text = "-";
            _optSubtract1.UseVisualStyleBackColor = false;
            // 
            // Label42
            // 
            Label42.BackColor = SystemColors.Window;
            Label42.Cursor = Cursors.Default;
            Label42.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label42.ForeColor = SystemColors.ControlText;
            Label42.Location = new Point(407, 50);
            Label42.Name = "Label42";
            Label42.RightToLeft = RightToLeft.No;
            Label42.Size = new Size(9, 17);
            Label42.TabIndex = 154;
            Label42.Text = "'";
            // 
            // Label41
            // 
            Label41.BackColor = SystemColors.Window;
            Label41.Cursor = Cursors.Default;
            Label41.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label41.ForeColor = SystemColors.ControlText;
            Label41.Location = new Point(364, 50);
            Label41.Name = "Label41";
            Label41.RightToLeft = RightToLeft.No;
            Label41.Size = new Size(9, 17);
            Label41.TabIndex = 153;
            Label41.Text = "°";
            // 
            // Label20
            // 
            Label20.BackColor = SystemColors.Window;
            Label20.Cursor = Cursors.Default;
            Label20.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label20.ForeColor = SystemColors.ControlText;
            Label20.Location = new Point(164, 136);
            Label20.Name = "Label20";
            Label20.RightToLeft = RightToLeft.No;
            Label20.Size = new Size(270, 17);
            Label20.TabIndex = 150;
            Label20.Text = " Calculated result will be between 0º and 359º59.9'";
            // 
            // Label19
            // 
            Label19.BackColor = SystemColors.Window;
            Label19.Cursor = Cursors.Default;
            Label19.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label19.ForeColor = SystemColors.ControlText;
            Label19.Location = new Point(83, 50);
            Label19.Name = "Label19";
            Label19.RightToLeft = RightToLeft.No;
            Label19.Size = new Size(9, 17);
            Label19.TabIndex = 149;
            Label19.Text = "°";
            // 
            // Label18
            // 
            Label18.BackColor = SystemColors.Window;
            Label18.Cursor = Cursors.Default;
            Label18.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label18.ForeColor = SystemColors.ControlText;
            Label18.Location = new Point(125, 50);
            Label18.Name = "Label18";
            Label18.RightToLeft = RightToLeft.No;
            Label18.Size = new Size(9, 17);
            Label18.TabIndex = 148;
            Label18.Text = "'";
            // 
            // Label17
            // 
            Label17.BackColor = SystemColors.Window;
            Label17.Cursor = Cursors.Default;
            Label17.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label17.ForeColor = SystemColors.ControlText;
            Label17.Location = new Point(223, 50);
            Label17.Name = "Label17";
            Label17.RightToLeft = RightToLeft.No;
            Label17.Size = new Size(9, 17);
            Label17.TabIndex = 147;
            Label17.Text = "°";
            // 
            // Label16
            // 
            Label16.BackColor = SystemColors.Window;
            Label16.Cursor = Cursors.Default;
            Label16.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label16.ForeColor = SystemColors.ControlText;
            Label16.Location = new Point(266, 50);
            Label16.Name = "Label16";
            Label16.RightToLeft = RightToLeft.No;
            Label16.Size = new Size(9, 17);
            Label16.TabIndex = 146;
            Label16.Text = "'";
            // 
            // Label15
            // 
            Label15.BackColor = SystemColors.Window;
            Label15.Cursor = Cursors.Default;
            Label15.Font = new Font("Times New Roman", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label15.ForeColor = SystemColors.ControlText;
            Label15.Location = new Point(185, 5);
            Label15.Name = "Label15";
            Label15.RightToLeft = RightToLeft.No;
            Label15.Size = new Size(230, 24);
            Label15.TabIndex = 145;
            Label15.Text = "Addition and Subtraction of Angles";
            Label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label4
            // 
            Label4.BackColor = SystemColors.Window;
            Label4.Cursor = Cursors.Default;
            Label4.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.ForeColor = SystemColors.ControlText;
            Label4.Location = new Point(418, 50);
            Label4.Name = "Label4";
            Label4.RightToLeft = RightToLeft.No;
            Label4.Size = new Size(9, 17);
            Label4.TabIndex = 144;
            Label4.Text = "=";
            // 
            // ConvertAngleorTime
            // 
            ConvertAngleorTime.Controls.Add(GroupBox1);
            ConvertAngleorTime.Controls.Add(dtTime);
            ConvertAngleorTime.Controls.Add(txtConvertedTime);
            ConvertAngleorTime.Controls.Add(txtAngle);
            ConvertAngleorTime.Controls.Add(_txtHsDeg);
            ConvertAngleorTime.Controls.Add(_txtHsMin);
            ConvertAngleorTime.Controls.Add(_txtHsSec);
            ConvertAngleorTime.Controls.Add(_cmdClearConverter);
            ConvertAngleorTime.Controls.Add(_cmdConvert);
            ConvertAngleorTime.Controls.Add(Label3);
            ConvertAngleorTime.Controls.Add(Label2);
            ConvertAngleorTime.Controls.Add(lblHs);
            ConvertAngleorTime.Controls.Add(lblHsDeg);
            ConvertAngleorTime.Controls.Add(lblHsMin);
            ConvertAngleorTime.Controls.Add(lblHsSec);
            ConvertAngleorTime.Location = new Point(4, 22);
            ConvertAngleorTime.Name = "ConvertAngleorTime";
            ConvertAngleorTime.Padding = new Padding(3);
            ConvertAngleorTime.Size = new Size(599, 367);
            ConvertAngleorTime.TabIndex = 1;
            ConvertAngleorTime.Text = "Angle or Time to Decimal";
            ConvertAngleorTime.UseVisualStyleBackColor = true;
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(_optHsDMm);
            GroupBox1.Controls.Add(_optHsDMS);
            GroupBox1.Location = new Point(219, 187);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(144, 51);
            GroupBox1.TabIndex = 101;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Angle Format";
            // 
            // optHsDMm
            // 
            _optHsDMm.BackColor = SystemColors.Window;
            _optHsDMm.Checked = true;
            _optHsDMm.Cursor = Cursors.Default;
            _optHsDMm.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optHsDMm.ForeColor = SystemColors.ControlText;
            _optHsDMm.Location = new Point(22, 20);
            _optHsDMm.Name = "_optHsDMm";
            _optHsDMm.RightToLeft = RightToLeft.No;
            _optHsDMm.Size = new Size(57, 25);
            _optHsDMm.TabIndex = 13;
            _optHsDMm.TabStop = true;
            _optHsDMm.Text = "DM.m";
            _optHsDMm.UseVisualStyleBackColor = false;
            // 
            // optHsDMS
            // 
            _optHsDMS.BackColor = SystemColors.Window;
            _optHsDMS.Cursor = Cursors.Default;
            _optHsDMS.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _optHsDMS.ForeColor = SystemColors.ControlText;
            _optHsDMS.Location = new Point(87, 23);
            _optHsDMS.Name = "_optHsDMS";
            _optHsDMS.RightToLeft = RightToLeft.No;
            _optHsDMS.Size = new Size(49, 17);
            _optHsDMS.TabIndex = 14;
            _optHsDMS.TabStop = true;
            _optHsDMS.Text = "DMS";
            _optHsDMS.UseVisualStyleBackColor = false;
            // 
            // dtTime
            // 
            dtTime.CustomFormat = "HH:mm:ss";
            dtTime.Format = DateTimePickerFormat.Custom;
            dtTime.Location = new Point(226, 100);
            dtTime.Name = "dtTime";
            dtTime.ShowUpDown = true;
            dtTime.Size = new Size(77, 21);
            dtTime.TabIndex = 100;
            // 
            // txtConvertedTime
            // 
            txtConvertedTime.AcceptsReturn = true;
            txtConvertedTime.BackColor = SystemColors.Window;
            txtConvertedTime.Cursor = Cursors.IBeam;
            txtConvertedTime.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtConvertedTime.ForeColor = SystemColors.WindowText;
            txtConvertedTime.Location = new Point(353, 102);
            txtConvertedTime.MaxLength = 0;
            txtConvertedTime.Name = "txtConvertedTime";
            txtConvertedTime.ReadOnly = true;
            txtConvertedTime.RightToLeft = RightToLeft.No;
            txtConvertedTime.Size = new Size(185, 20);
            txtConvertedTime.TabIndex = 99;
            // 
            // txtAngle
            // 
            txtAngle.AcceptsReturn = true;
            txtAngle.BackColor = SystemColors.Window;
            txtAngle.Cursor = Cursors.IBeam;
            txtAngle.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtAngle.ForeColor = SystemColors.WindowText;
            txtAngle.Location = new Point(353, 72);
            txtAngle.MaxLength = 0;
            txtAngle.Name = "txtAngle";
            txtAngle.ReadOnly = true;
            txtAngle.RightToLeft = RightToLeft.No;
            txtAngle.Size = new Size(185, 20);
            txtAngle.TabIndex = 98;
            // 
            // cmdClearConverter
            // 
            _cmdClearConverter.BackColor = SystemColors.Control;
            _cmdClearConverter.Cursor = Cursors.Default;
            _cmdClearConverter.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdClearConverter.ForeColor = SystemColors.ControlText;
            _cmdClearConverter.Location = new Point(306, 142);
            _cmdClearConverter.Name = "_cmdClearConverter";
            _cmdClearConverter.RightToLeft = RightToLeft.No;
            _cmdClearConverter.Size = new Size(73, 25);
            _cmdClearConverter.TabIndex = 89;
            _cmdClearConverter.Text = "Clea&r";
            _cmdClearConverter.UseVisualStyleBackColor = false;
            // 
            // cmdConvert
            // 
            _cmdConvert.BackColor = SystemColors.Control;
            _cmdConvert.Cursor = Cursors.Default;
            _cmdConvert.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdConvert.ForeColor = SystemColors.ControlText;
            _cmdConvert.Location = new Point(202, 142);
            _cmdConvert.Name = "_cmdConvert";
            _cmdConvert.RightToLeft = RightToLeft.No;
            _cmdConvert.Size = new Size(73, 25);
            _cmdConvert.TabIndex = 88;
            _cmdConvert.Text = "Con&vert";
            _cmdConvert.UseVisualStyleBackColor = false;
            // 
            // Label3
            // 
            Label3.BackColor = SystemColors.Window;
            Label3.Cursor = Cursors.Default;
            Label3.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.ForeColor = SystemColors.ControlText;
            Label3.Location = new Point(80, 97);
            Label3.Name = "Label3";
            Label3.RightToLeft = RightToLeft.No;
            Label3.Size = new Size(140, 25);
            Label3.TabIndex = 97;
            Label3.Text = "Time to convert (hh:mm:ss)";
            Label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label2
            // 
            Label2.BackColor = SystemColors.Window;
            Label2.Cursor = Cursors.Default;
            Label2.Font = new Font("Times New Roman", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = SystemColors.ControlText;
            Label2.Location = new Point(182, 20);
            Label2.Name = "Label2";
            Label2.RightToLeft = RightToLeft.No;
            Label2.Size = new Size(238, 20);
            Label2.TabIndex = 96;
            Label2.Text = "Angle or Time to Decimal Conversion";
            // 
            // lblHs
            // 
            lblHs.BackColor = SystemColors.Window;
            lblHs.Cursor = Cursors.Default;
            lblHs.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblHs.ForeColor = SystemColors.ControlText;
            lblHs.Location = new Point(85, 72);
            lblHs.Name = "lblHs";
            lblHs.RightToLeft = RightToLeft.No;
            lblHs.Size = new Size(97, 17);
            lblHs.TabIndex = 94;
            lblHs.Text = "Angle  to convert";
            // 
            // lblHsDeg
            // 
            lblHsDeg.BackColor = SystemColors.Window;
            lblHsDeg.Cursor = Cursors.Default;
            lblHsDeg.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblHsDeg.ForeColor = SystemColors.ControlText;
            lblHsDeg.Location = new Point(259, 71);
            lblHsDeg.Name = "lblHsDeg";
            lblHsDeg.RightToLeft = RightToLeft.No;
            lblHsDeg.Size = new Size(9, 17);
            lblHsDeg.TabIndex = 93;
            lblHsDeg.Text = "°";
            // 
            // lblHsMin
            // 
            lblHsMin.BackColor = SystemColors.Window;
            lblHsMin.Cursor = Cursors.Default;
            lblHsMin.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblHsMin.ForeColor = SystemColors.ControlText;
            lblHsMin.Location = new Point(299, 71);
            lblHsMin.Name = "lblHsMin";
            lblHsMin.RightToLeft = RightToLeft.No;
            lblHsMin.Size = new Size(9, 17);
            lblHsMin.TabIndex = 92;
            lblHsMin.Text = "'";
            // 
            // lblHsSec
            // 
            lblHsSec.BackColor = SystemColors.Window;
            lblHsSec.Cursor = Cursors.Default;
            lblHsSec.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblHsSec.ForeColor = SystemColors.ControlText;
            lblHsSec.Location = new Point(339, 71);
            lblHsSec.Name = "lblHsSec";
            lblHsSec.RightToLeft = RightToLeft.No;
            lblHsSec.Size = new Size(9, 17);
            lblHsSec.TabIndex = 91;
            lblHsSec.Text = "\"";
            lblHsSec.Visible = false;
            // 
            // TabControl1
            // 
            _TabControl1.Controls.Add(AngleAddSubtract);
            _TabControl1.Controls.Add(TimeAddSubtract);
            _TabControl1.Controls.Add(TimeofDateCalc);
            _TabControl1.Controls.Add(TimeZoneCalc);
            _TabControl1.Controls.Add(ConvertAngleorTime);
            _TabControl1.Location = new Point(4, 22);
            _TabControl1.Name = "_TabControl1";
            _TabControl1.SelectedIndex = 0;
            _TabControl1.Size = new Size(607, 393);
            _TabControl1.TabIndex = 138;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.ABC_white;
            PictureBox1.Location = new Point(159, 417);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(316, 50);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 139;
            PictureBox1.TabStop = false;
            // 
            // cmdPrint
            // 
            _cmdPrint.BackColor = SystemColors.Control;
            _cmdPrint.Cursor = Cursors.Default;
            _cmdPrint.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cmdPrint.ForeColor = SystemColors.ControlText;
            _cmdPrint.Image = (Image)resources.GetObject("cmdPrint.Image");
            _cmdPrint.Location = new Point(587, 3);
            _cmdPrint.Name = "_cmdPrint";
            _cmdPrint.RightToLeft = RightToLeft.No;
            _cmdPrint.Size = new Size(21, 21);
            _cmdPrint.TabIndex = 95;
            _cmdPrint.TextAlign = ContentAlignment.BottomCenter;
            _cmdPrint.UseVisualStyleBackColor = false;
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.Location = new Point(96, 282);
            Label11.Name = "Label11";
            Label11.Size = new Size(402, 13);
            Label11.TabIndex = 171;
            Label11.Text = "The ZTInfo form offers an improved version of this functionality off the Main Men" + "u";
            // 
            // FormNavMath
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(615, 483);
            Controls.Add(_cmdPrint);
            Controls.Add(PictureBox1);
            Controls.Add(_TabControl1);
            Controls.Add(_ExitBtn);
            Cursor = Cursors.Default;
            Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(3, 29);
            MaximizeBox = false;
            Name = "FormNavMath";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Navigation Math";
            TimeZoneCalc.ResumeLayout(false);
            TimeZoneCalc.PerformLayout();
            TimeofDateCalc.ResumeLayout(false);
            TimeofDateCalc.PerformLayout();
            Frame2.ResumeLayout(false);
            TimeAddSubtract.ResumeLayout(false);
            TimeAddSubtract.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DTRSeconds).EndInit();
            ((System.ComponentModel.ISupportInitialize)DTRMinutes).EndInit();
            ((System.ComponentModel.ISupportInitialize)DTRHours).EndInit();
            ((System.ComponentModel.ISupportInitialize)DTRDays).EndInit();
            ((System.ComponentModel.ISupportInitialize)DT2Seconds).EndInit();
            ((System.ComponentModel.ISupportInitialize)DT2Minutes).EndInit();
            ((System.ComponentModel.ISupportInitialize)DT2Hours).EndInit();
            ((System.ComponentModel.ISupportInitialize)DT2Days).EndInit();
            ((System.ComponentModel.ISupportInitialize)DT1Seconds).EndInit();
            ((System.ComponentModel.ISupportInitialize)DT1Minutes).EndInit();
            ((System.ComponentModel.ISupportInitialize)DT1Hours).EndInit();
            ((System.ComponentModel.ISupportInitialize)DT1Days).EndInit();
            Frame3.ResumeLayout(false);
            AngleAddSubtract.ResumeLayout(false);
            AngleAddSubtract.PerformLayout();
            Frame4.ResumeLayout(false);
            Frame1.ResumeLayout(false);
            ConvertAngleorTime.ResumeLayout(false);
            ConvertAngleorTime.PerformLayout();
            GroupBox1.ResumeLayout(false);
            _TabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Load += new EventHandler(FormNavMath_Load);
            FormClosed += new FormClosedEventHandler(FormNavMath_FormClosed);
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

        internal TabPage TimeZoneCalc;
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

        public TextBox txtZD;
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

        private Button _cmdClearTZ;

        public Button cmdClearTZ
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdClearTZ;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdClearTZ != null)
                {
                    _cmdClearTZ.Click -= cmdClearTZ_Click;
                }

                _cmdClearTZ = value;
                if (_cmdClearTZ != null)
                {
                    _cmdClearTZ.Click += cmdClearTZ_Click;
                }
            }
        }

        public Label Label35;
        public Label lblLoDeg;
        public Label lblLoMin;
        public Label Label34;
        public Label Label24;
        internal TabPage TimeofDateCalc;
        private TextBox _txtIntD;

        public TextBox txtIntD
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtIntD;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtIntD != null)
                {
                    _txtIntD.TextChanged -= txtIntD_TextChanged;
                    _txtIntD.KeyPress -= txtIntD_KeyPress;
                    _txtIntD.Enter -= txtIntD_Enter;
                }

                _txtIntD = value;
                if (_txtIntD != null)
                {
                    _txtIntD.TextChanged += txtIntD_TextChanged;
                    _txtIntD.KeyPress += txtIntD_KeyPress;
                    _txtIntD.Enter += txtIntD_Enter;
                }
            }
        }

        private TextBox _txtIntM;

        public TextBox txtIntM
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtIntM;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtIntM != null)
                {
                    _txtIntM.TextChanged -= txtIntM_TextChanged;
                    _txtIntM.KeyPress -= txtIntM_KeyPress;
                    _txtIntM.Enter -= txtIntM_Enter;
                }

                _txtIntM = value;
                if (_txtIntM != null)
                {
                    _txtIntM.TextChanged += txtIntM_TextChanged;
                    _txtIntM.KeyPress += txtIntM_KeyPress;
                    _txtIntM.Enter += txtIntM_Enter;
                }
            }
        }

        private TextBox _txtIntH;

        public TextBox txtIntH
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtIntH;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtIntH != null)
                {
                    _txtIntH.TextChanged -= txtIntH_TextChanged;
                    _txtIntH.KeyPress -= txtIntH_KeyPress;
                    _txtIntH.Enter -= txtIntH_Enter;
                }

                _txtIntH = value;
                if (_txtIntH != null)
                {
                    _txtIntH.TextChanged += txtIntH_TextChanged;
                    _txtIntH.KeyPress += txtIntH_KeyPress;
                    _txtIntH.Enter += txtIntH_Enter;
                }
            }
        }

        private TextBox _txtZDh2;

        public TextBox txtZDh2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtZDh2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtZDh2 != null)
                {
                    _txtZDh2.TextChanged -= txtZDh2_TextChanged;
                    _txtZDh2.KeyPress -= txtZDh2_KeyPress;
                    _txtZDh2.Enter -= txtZDh2_Enter;
                }

                _txtZDh2 = value;
                if (_txtZDh2 != null)
                {
                    _txtZDh2.TextChanged += txtZDh2_TextChanged;
                    _txtZDh2.KeyPress += txtZDh2_KeyPress;
                    _txtZDh2.Enter += txtZDh2_Enter;
                }
            }
        }

        private TextBox _txtZDh1;

        public TextBox txtZDh1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtZDh1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtZDh1 != null)
                {
                    _txtZDh1.TextChanged -= txtZDh1_TextChanged;
                    _txtZDh1.KeyPress -= txtZDh1_KeyPress;
                    _txtZDh1.Validating -= txtZDh1_Validating;
                    _txtZDh1.Enter -= txtZDh1_Enter;
                }

                _txtZDh1 = value;
                if (_txtZDh1 != null)
                {
                    _txtZDh1.TextChanged += txtZDh1_TextChanged;
                    _txtZDh1.KeyPress += txtZDh1_KeyPress;
                    _txtZDh1.Validating += txtZDh1_Validating;
                    _txtZDh1.Enter += txtZDh1_Enter;
                }
            }
        }

        public TextBox txtDays;
        public TextBox txtTimeResult;
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

        public Panel Frame2;
        private RadioButton _optSubtractToD;

        public RadioButton optSubtractToD
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optSubtractToD;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optSubtractToD != null)
                {
                    _optSubtractToD.CheckedChanged -= optSubtractToD_CheckedChanged;
                }

                _optSubtractToD = value;
                if (_optSubtractToD != null)
                {
                    _optSubtractToD.CheckedChanged += optSubtractToD_CheckedChanged;
                }
            }
        }

        private RadioButton _optAddToD;

        public RadioButton optAddToD
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optAddToD;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optAddToD != null)
                {
                    _optAddToD.CheckedChanged -= optAddToD_CheckedChanged;
                }

                _optAddToD = value;
                if (_optAddToD != null)
                {
                    _optAddToD.CheckedChanged += optAddToD_CheckedChanged;
                }
            }
        }

        private ComboBox _cboZDm2;

        public ComboBox cboZDm2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboZDm2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboZDm2 != null)
                {
                    _cboZDm2.SelectedIndexChanged -= cboZDm2_SelectedIndexChanged;
                }

                _cboZDm2 = value;
                if (_cboZDm2 != null)
                {
                    _cboZDm2.SelectedIndexChanged += cboZDm2_SelectedIndexChanged;
                }
            }
        }

        private CheckBox _chkDST2;

        public CheckBox chkDST2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _chkDST2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_chkDST2 != null)
                {
                    _chkDST2.CheckStateChanged -= chkDST2_CheckStateChanged;
                }

                _chkDST2 = value;
                if (_chkDST2 != null)
                {
                    _chkDST2.CheckStateChanged += chkDST2_CheckStateChanged;
                }
            }
        }

        private ComboBox _cboZDm1;

        public ComboBox cboZDm1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboZDm1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboZDm1 != null)
                {
                    _cboZDm1.SelectedIndexChanged -= cboZDm1_SelectedIndexChanged;
                }

                _cboZDm1 = value;
                if (_cboZDm1 != null)
                {
                    _cboZDm1.SelectedIndexChanged += cboZDm1_SelectedIndexChanged;
                }
            }
        }

        private CheckBox _chkDST1;

        public CheckBox chkDST1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _chkDST1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_chkDST1 != null)
                {
                    _chkDST1.CheckedChanged -= chkDST1_CheckStateChanged;
                }

                _chkDST1 = value;
                if (_chkDST1 != null)
                {
                    _chkDST1.CheckedChanged += chkDST1_CheckStateChanged;
                }
            }
        }

        private Button _cmdCalculateToD;

        public Button cmdCalculateToD
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdCalculateToD;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdCalculateToD != null)
                {
                    _cmdCalculateToD.Click -= cmdCalculateToD_Click;
                }

                _cmdCalculateToD = value;
                if (_cmdCalculateToD != null)
                {
                    _cmdCalculateToD.Click += cmdCalculateToD_Click;
                }
            }
        }

        private Button _cmdClearToD;

        public Button cmdClearToD
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdClearToD;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdClearToD != null)
                {
                    _cmdClearToD.Click -= cmdClearToD_Click;
                }

                _cmdClearToD = value;
                if (_cmdClearToD != null)
                {
                    _cmdClearToD.Click += cmdClearToD_Click;
                }
            }
        }

        public Label Label38;
        public Label Label36;
        public Label Label37;
        public Label Label26;
        public Label Label23;
        public Label lblZD2;
        public Label lblZDh2;
        public Label lblZDm2;
        public Label lblZDDST2;
        public Label lblZD1;
        public Label lblZDh1;
        public Label lblZDm1;
        public Label lblZDDST1;
        public Label Label25;
        internal TabPage TimeAddSubtract;
        private Button _cmdClearTimes;

        public Button cmdClearTimes
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdClearTimes;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdClearTimes != null)
                {
                    _cmdClearTimes.Click -= cmdClearTimes_Click;
                }

                _cmdClearTimes = value;
                if (_cmdClearTimes != null)
                {
                    _cmdClearTimes.Click += cmdClearTimes_Click;
                }
            }
        }

        private Button _cmdCalculateTimes;

        public Button cmdCalculateTimes
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdCalculateTimes;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdCalculateTimes != null)
                {
                    _cmdCalculateTimes.Click -= cmdCalculateTimes_Click;
                }

                _cmdCalculateTimes = value;
                if (_cmdCalculateTimes != null)
                {
                    _cmdCalculateTimes.Click += cmdCalculateTimes_Click;
                }
            }
        }

        public Panel Frame3;
        private RadioButton _optAddTimes;

        public RadioButton optAddTimes
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optAddTimes;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optAddTimes != null)
                {
                    _optAddTimes.CheckedChanged -= optAddTimes_CheckedChanged;
                }

                _optAddTimes = value;
                if (_optAddTimes != null)
                {
                    _optAddTimes.CheckedChanged += optAddTimes_CheckedChanged;
                }
            }
        }

        private RadioButton _optSubtractTimes;

        public RadioButton optSubtractTimes
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optSubtractTimes;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optSubtractTimes != null)
                {
                    _optSubtractTimes.CheckedChanged -= optSubtractTimes_CheckedChanged;
                }

                _optSubtractTimes = value;
                if (_optSubtractTimes != null)
                {
                    _optSubtractTimes.CheckedChanged += optSubtractTimes_CheckedChanged;
                }
            }
        }

        public Label Label27;
        internal TabPage AngleAddSubtract;
        private TextBox _txtMin3;

        public TextBox txtMin3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtMin3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtMin3 != null)
                {
                    _txtMin3.TextChanged -= txtMin3_TextChanged;
                    _txtMin3.KeyPress -= txtMin3_KeyPress;
                    _txtMin3.Validating -= txtMin3_Validating;
                    _txtMin3.Enter -= txtTime1_Enter;
                }

                _txtMin3 = value;
                if (_txtMin3 != null)
                {
                    _txtMin3.TextChanged += txtMin3_TextChanged;
                    _txtMin3.KeyPress += txtMin3_KeyPress;
                    _txtMin3.Validating += txtMin3_Validating;
                    _txtMin3.Enter += txtTime1_Enter;
                }
            }
        }

        private TextBox _txtDeg3;

        public TextBox txtDeg3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtDeg3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtDeg3 != null)
                {
                    _txtDeg3.TextChanged -= txtDeg3_TextChanged;
                    _txtDeg3.KeyPress -= txtDeg3_KeyPress;
                    _txtDeg3.Validating -= txtDeg3_Validating;
                    _txtDeg3.Enter -= txtDeg3_Enter;
                }

                _txtDeg3 = value;
                if (_txtDeg3 != null)
                {
                    _txtDeg3.TextChanged += txtDeg3_TextChanged;
                    _txtDeg3.KeyPress += txtDeg3_KeyPress;
                    _txtDeg3.Validating += txtDeg3_Validating;
                    _txtDeg3.Enter += txtDeg3_Enter;
                }
            }
        }

        public TextBox txtResult;
        private TextBox _txtDeg1;

        public TextBox txtDeg1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtDeg1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtDeg1 != null)
                {
                    _txtDeg1.TextChanged -= txtDeg1_TextChanged;
                    _txtDeg1.KeyPress -= txtDeg1_KeyPress;
                    _txtDeg1.Validating -= txtDeg1_Validating;
                    _txtDeg1.Enter -= txtDeg1_Enter;
                }

                _txtDeg1 = value;
                if (_txtDeg1 != null)
                {
                    _txtDeg1.TextChanged += txtDeg1_TextChanged;
                    _txtDeg1.KeyPress += txtDeg1_KeyPress;
                    _txtDeg1.Validating += txtDeg1_Validating;
                    _txtDeg1.Enter += txtDeg1_Enter;
                }
            }
        }

        private TextBox _txtMin1;

        public TextBox txtMin1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtMin1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtMin1 != null)
                {
                    _txtMin1.TextChanged -= txtMin1_TextChanged;
                    _txtMin1.KeyPress -= txtMin1_KeyPress;
                    _txtMin1.Validating -= txtMin1_Validating;
                    _txtMin1.Enter -= txtMin1_Enter;
                }

                _txtMin1 = value;
                if (_txtMin1 != null)
                {
                    _txtMin1.TextChanged += txtMin1_TextChanged;
                    _txtMin1.KeyPress += txtMin1_KeyPress;
                    _txtMin1.Validating += txtMin1_Validating;
                    _txtMin1.Enter += txtMin1_Enter;
                }
            }
        }

        private TextBox _txtDeg2;

        public TextBox txtDeg2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtDeg2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtDeg2 != null)
                {
                    _txtDeg2.TextChanged -= txtDeg2_TextChanged;
                    _txtDeg2.KeyPress -= txtDeg2_KeyPress;
                    _txtDeg2.Validating -= txtDeg2_Validating;
                    _txtDeg2.Enter -= txtDeg2_Enter;
                }

                _txtDeg2 = value;
                if (_txtDeg2 != null)
                {
                    _txtDeg2.TextChanged += txtDeg2_TextChanged;
                    _txtDeg2.KeyPress += txtDeg2_KeyPress;
                    _txtDeg2.Validating += txtDeg2_Validating;
                    _txtDeg2.Enter += txtDeg2_Enter;
                }
            }
        }

        private TextBox _txtMin2;

        public TextBox txtMin2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtMin2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtMin2 != null)
                {
                    _txtMin2.TextChanged -= txtMin2_TextChanged;
                    _txtMin2.KeyPress -= txtMin2_KeyPress;
                    _txtMin2.Validating -= txtMin2_Validating;
                    _txtMin2.Enter -= txtMin2_Enter;
                }

                _txtMin2 = value;
                if (_txtMin2 != null)
                {
                    _txtMin2.TextChanged += txtMin2_TextChanged;
                    _txtMin2.KeyPress += txtMin2_KeyPress;
                    _txtMin2.Validating += txtMin2_Validating;
                    _txtMin2.Enter += txtMin2_Enter;
                }
            }
        }

        public Panel Frame4;
        private RadioButton _optSubtract2;

        public RadioButton optSubtract2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optSubtract2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optSubtract2 != null)
                {
                    _optSubtract2.CheckedChanged -= optSubtract2_CheckedChanged;
                }

                _optSubtract2 = value;
                if (_optSubtract2 != null)
                {
                    _optSubtract2.CheckedChanged += optSubtract2_CheckedChanged;
                }
            }
        }

        private RadioButton _optAdd2;

        public RadioButton optAdd2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optAdd2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optAdd2 != null)
                {
                    _optAdd2.CheckedChanged -= optAdd2_CheckedChanged;
                }

                _optAdd2 = value;
                if (_optAdd2 != null)
                {
                    _optAdd2.CheckedChanged += optAdd2_CheckedChanged;
                }
            }
        }

        private Button _cmdClearAddSubtract;

        public Button cmdClearAddSubtract
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdClearAddSubtract;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdClearAddSubtract != null)
                {
                    _cmdClearAddSubtract.Click -= cmdClearAddSubtract_Click;
                }

                _cmdClearAddSubtract = value;
                if (_cmdClearAddSubtract != null)
                {
                    _cmdClearAddSubtract.Click += cmdClearAddSubtract_Click;
                }
            }
        }

        public Panel Frame1;
        private RadioButton _optAdd1;

        public RadioButton optAdd1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optAdd1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optAdd1 != null)
                {
                    _optAdd1.CheckedChanged -= optAdd1_CheckedChanged;
                }

                _optAdd1 = value;
                if (_optAdd1 != null)
                {
                    _optAdd1.CheckedChanged += optAdd1_CheckedChanged;
                }
            }
        }

        private RadioButton _optSubtract1;

        public RadioButton optSubtract1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optSubtract1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optSubtract1 != null)
                {
                    _optSubtract1.CheckedChanged -= optSubtract1_CheckedChanged;
                }

                _optSubtract1 = value;
                if (_optSubtract1 != null)
                {
                    _optSubtract1.CheckedChanged += optSubtract1_CheckedChanged;
                }
            }
        }

        public Label Label42;
        public Label Label41;
        public Label Label20;
        public Label Label19;
        public Label Label18;
        public Label Label17;
        public Label Label16;
        public Label Label15;
        public Label Label4;
        internal TabPage ConvertAngleorTime;
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

        public TextBox txtConvertedTime;
        public TextBox txtAngle;
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
                    _txtHsMin.TextChanged -= txtHsDeg_TextChanged;
                    _txtHsMin.KeyPress -= txtHsMin_KeyPress;
                    _txtHsMin.Validating -= txtHsMin_Validating;
                    _txtHsMin.Enter -= txtHsMin_Enter;
                }

                _txtHsMin = value;
                if (_txtHsMin != null)
                {
                    _txtHsMin.TextChanged += txtHsDeg_TextChanged;
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

        private Button _cmdClearConverter;

        public Button cmdClearConverter
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdClearConverter;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdClearConverter != null)
                {
                    _cmdClearConverter.Click -= cmdClearConverter_Click;
                }

                _cmdClearConverter = value;
                if (_cmdClearConverter != null)
                {
                    _cmdClearConverter.Click += cmdClearConverter_Click;
                }
            }
        }

        private Button _cmdConvert;

        public Button cmdConvert
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdConvert;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdConvert != null)
                {
                    _cmdConvert.Click -= cmdConvert_Click;
                }

                _cmdConvert = value;
                if (_cmdConvert != null)
                {
                    _cmdConvert.Click += cmdConvert_Click;
                }
            }
        }

        public Label Label3;
        public Label Label2;
        public Label lblHs;
        public Label lblHsDeg;
        public Label lblHsMin;
        public Label lblHsSec;
        private TabControl _TabControl1;

        internal TabControl TabControl1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TabControl1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TabControl1 != null)
                {
                    _TabControl1.SelectedIndexChanged -= TabControl1_SelectedIndexChanged;
                }

                _TabControl1 = value;
                if (_TabControl1 != null)
                {
                    _TabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;
                }
            }
        }

        internal TextBox TextBox1;
        internal PictureBox PictureBox1;
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

        internal DateTimePicker dtTime;
        internal GroupBox GroupBox1;
        private Button _btnAddSubtract;

        public Button btnAddSubtract
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnAddSubtract;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnAddSubtract != null)
                {
                    _btnAddSubtract.Click -= btnAddSubtract_Click;
                }

                _btnAddSubtract = value;
                if (_btnAddSubtract != null)
                {
                    _btnAddSubtract.Click += btnAddSubtract_Click;
                }
            }
        }

        private Button _btnZDCalc;

        public Button btnZDCalc
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnZDCalc;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnZDCalc != null)
                {
                    _btnZDCalc.Click -= btnZDCalc_Click;
                }

                _btnZDCalc = value;
                if (_btnZDCalc != null)
                {
                    _btnZDCalc.Click += btnZDCalc_Click;
                }
            }
        }

        internal Label Label1;
        private Button _btnMoveResult;

        public Button btnMoveResult
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnMoveResult;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnMoveResult != null)
                {
                    _btnMoveResult.Click -= btnMoveResult_Click;
                }

                _btnMoveResult = value;
                if (_btnMoveResult != null)
                {
                    _btnMoveResult.Click += btnMoveResult_Click;
                }
            }
        }

        internal NumericUpDown DTRSeconds;
        internal NumericUpDown DTRMinutes;
        internal NumericUpDown DTRHours;
        internal NumericUpDown DTRDays;
        internal NumericUpDown DT2Seconds;
        internal NumericUpDown DT2Minutes;
        internal NumericUpDown DT2Hours;
        internal NumericUpDown DT2Days;
        internal Label Label8;
        internal NumericUpDown DT1Seconds;
        internal NumericUpDown DT1Minutes;
        internal NumericUpDown DT1Hours;
        internal NumericUpDown DT1Days;
        internal Label Label7;
        internal Label Label6;
        internal Label Label5;
        internal Label Label10;
        internal Label Label9;
        internal Label Label11;
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}