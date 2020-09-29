using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    [DesignerGenerated()]
    public partial class SightLog : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            var DataGridViewCellStyle11 = new DataGridViewCellStyle();
            var DataGridViewCellStyle14 = new DataGridViewCellStyle();
            var DataGridViewCellStyle15 = new DataGridViewCellStyle();
            var DataGridViewCellStyle12 = new DataGridViewCellStyle();
            var DataGridViewCellStyle13 = new DataGridViewCellStyle();
            lblName = new Label();
            txtName = new TextBox();
            txtSquadron = new TextBox();
            lblSquadron = new Label();
            txtSightNum = new TextBox();
            lblSightNum = new Label();
            SightDateTime = new DateTimePicker();
            lblSightDate = new Label();
            lblWE = new Label();
            txtWE = new TextBox();
            cbWEType = new ComboBox();
            _btnExit = new Button();
            _btnExit.Click += new EventHandler(btnExit_Click);
            cbIEType = new ComboBox();
            txtIE = new TextBox();
            txtHE = new TextBox();
            lblHE = new Label();
            cboLo = new ComboBox();
            cboL = new ComboBox();
            txtLDeg = new TextBox();
            txtLoMin = new TextBox();
            txtLoDeg = new TextBox();
            txtLMin = new TextBox();
            _cboBody = new ComboBox();
            _cboBody.SelectedIndexChanged += new EventHandler(cboBody_SelectedIndexChanged);
            lblLoMin = new Label();
            lblLoDeg = new Label();
            lblDRLo = new Label();
            lblLMin = new Label();
            lblLDeg = new Label();
            lblDRL = new Label();
            lblHorType = new Label();
            _cbHorizon = new ComboBox();
            _cbHorizon.SelectedIndexChanged += new EventHandler(cbHorizon_SelectedIndexChanged);
            cbHorDistType = new ComboBox();
            lblDistance = new Label();
            txtHorDist = new TextBox();
            _chkbxDST = new CheckBox();
            _chkbxDST.CheckedChanged += new EventHandler(chkbxDST_CheckedChanged);
            _btnOpenLog = new Button();
            _btnOpenLog.Click += new EventHandler(btnOpenLog_Click);
            _btnSaveLog = new Button();
            _btnSaveLog.Click += new EventHandler(btnSaveLog_Click);
            txtRemarks = new RichTextBox();
            _btnAddNew = new Button();
            _btnAddNew.Click += new EventHandler(btnAddNew_Click);
            _btnUpdateExisting = new Button();
            _btnUpdateExisting.Click += new EventHandler(btnUpdateExisting_Click);
            _btnDeleteSight = new Button();
            _btnDeleteSight.Click += new EventHandler(btnDeleteSight_Click);
            _btnNewLog = new Button();
            _btnNewLog.Click += new EventHandler(btnNewLog_Click);
            _btnSightReduce = new Button();
            _btnSightReduce.Click += new EventHandler(btnSightReduce_Click);
            cbLimb = new ComboBox();
            lblLimb = new Label();
            txtHSDeg = new TextBox();
            txtHSMin = new TextBox();
            Label1 = new Label();
            Label2 = new Label();
            lvlHS = new Label();
            txtIntZn = new TextBox();
            _SEDataGrid = new DataGridView();
            _SEDataGrid.SelectionChanged += new EventHandler(SEDataGrid_SelectionChanged);
            SightNum = new DataGridViewTextBoxColumn();
            SDateTime = new DataGridViewTextBoxColumn();
            BodyName = new DataGridViewTextBoxColumn();
            BodyLimb = new DataGridViewTextBoxColumn();
            SDST = new DataGridViewTextBoxColumn();
            SWE = new DataGridViewTextBoxColumn();
            SWEType = new DataGridViewTextBoxColumn();
            ZD = new DataGridViewTextBoxColumn();
            HS = new DataGridViewTextBoxColumn();
            HorType = new DataGridViewTextBoxColumn();
            HorDist = new DataGridViewTextBoxColumn();
            HorDistType = new DataGridViewTextBoxColumn();
            HE = new DataGridViewTextBoxColumn();
            IC = new DataGridViewTextBoxColumn();
            ICType = new DataGridViewTextBoxColumn();
            DRLat = new DataGridViewTextBoxColumn();
            DRLong = new DataGridViewTextBoxColumn();
            LLoBy = new DataGridViewTextBoxColumn();
            Intercept = new DataGridViewTextBoxColumn();
            Aziumuth = new DataGridViewTextBoxColumn();
            EP = new DataGridViewTextBoxColumn();
            PsnName = new DataGridViewTextBoxColumn();
            Squadron = new DataGridViewTextBoxColumn();
            WTDiff = new DataGridViewTextBoxColumn();
            HSDiff = new DataGridViewTextBoxColumn();
            HSWTRate = new DataGridViewTextBoxColumn();
            Remarks = new DataGridViewTextBoxColumn();
            SRGHA = new DataGridViewTextBoxColumn();
            SRDec = new DataGridViewTextBoxColumn();
            SRHo = new DataGridViewTextBoxColumn();
            UserInfo = new DataGridViewTextBoxColumn();
            lblUSPSSightLog = new Label();
            lblZD = new Label();
            cboZD = new ComboBox();
            _btnClearFields = new Button();
            _btnClearFields.Click += new EventHandler(btnClearFields_Click);
            Label3 = new Label();
            grpSightButtons = new GroupBox();
            _btnPlanSight = new Button();
            _btnPlanSight.Click += new EventHandler(btnPlanSight_Click);
            _btnCustomPlot = new Button();
            _btnCustomPlot.Click += new EventHandler(btnCustomPlot_Click);
            _btnUseCLS = new Button();
            _btnUseCLS.Click += new EventHandler(btnUseCLS_Click);
            _btnNoonSight = new Button();
            _btnNoonSight.Click += new EventHandler(btnNoonSight_Click);
            _btnAltSR = new Button();
            _btnAltSR.Click += new EventHandler(BtnAltSR_Click);
            Label4 = new Label();
            _btnSLReport = new Button();
            _btnSLReport.Click += new EventHandler(btnSLReport_Click);
            _btnPrintDG = new Button();
            _btnPrintDG.Click += new EventHandler(btnPrintDG_Click);
            PrintDialog1 = new PrintDialog();
            _PrintDocument1 = new PrintDocument();
            _PrintDocument1.BeginPrint += new PrintEventHandler(PrintDocument1_BeginPrint);
            _PrintDocument1.PrintPage += new PrintPageEventHandler(PrintDocument1_PrintPage);
            lblBodyNm = new Label();
            Label5 = new Label();
            txtIEDeg = new TextBox();
            Label6 = new Label();
            lblIE = new Label();
            cboHEUnit = new ComboBox();
            lblSRFEP = new Label();
            txtSRFEP = new TextBox();
            txtHsSec = new TextBox();
            lblHsSec = new Label();
            txtIESec = new TextBox();
            lblIEsec = new Label();
            lblHSIEFmt = new Label();
            _cboHSIEFmt = new ComboBox();
            _cboHSIEFmt.SelectedIndexChanged += new EventHandler(cboHSIEFmt_SelectedIndexChanged);
            cboApprxBrg = new ComboBox();
            lblApprxBrg = new Label();
            _CheckBoxShowAvg = new CheckBox();
            _CheckBoxShowAvg.CheckedChanged += new EventHandler(CheckBoxShowAvg_CheckedChanged);
            _CheckBoxAutoReduce = new CheckBox();
            _CheckBoxAutoReduce.CheckedChanged += new EventHandler(CheckBoxAutoReduce_CheckedChanged);
            SLOptions = new GroupBox();
            _chkDispGHADecHo = new CheckBox();
            _chkDispGHADecHo.CheckedChanged += new EventHandler(ChkDispGHADecHo_CheckedChanged);
            _chkClearFields = new CheckBox();
            _chkClearFields.CheckedChanged += new EventHandler(ChkClearFields_CheckedChanged);
            Label8 = new Label();
            lblSRGHA = new Label();
            txtSRGHA = new TextBox();
            lblSRDec = new Label();
            txtSRDec = new TextBox();
            lblSRHo = new Label();
            txtSRHo = new TextBox();
            GroupBox1 = new GroupBox();
            txtUserInfo = new TextBox();
            Label7 = new Label();
            grpFileButtons = new GroupBox();
            _btnSaveLogAsTxt = new Button();
            _btnSaveLogAsTxt.Click += new EventHandler(btnSaveLogAsTxt_Click);
            PictureBox2 = new PictureBox();
            cboLLoBy = new ComboBox();
            Label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)_SEDataGrid).BeginInit();
            grpSightButtons.SuspendLayout();
            SLOptions.SuspendLayout();
            GroupBox1.SuspendLayout();
            grpFileButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblName.Location = new Point(139, 89);
            lblName.Name = "lblName";
            lblName.Size = new Size(37, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            txtName.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtName.HideSelection = false;
            txtName.Location = new Point(187, 86);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 22);
            txtName.TabIndex = 1;
            // 
            // txtSquadron
            // 
            txtSquadron.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtSquadron.HideSelection = false;
            txtSquadron.Location = new Point(513, 87);
            txtSquadron.Name = "txtSquadron";
            txtSquadron.Size = new Size(250, 22);
            txtSquadron.TabIndex = 5;
            // 
            // lblSquadron
            // 
            lblSquadron.AutoSize = true;
            lblSquadron.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblSquadron.Location = new Point(445, 90);
            lblSquadron.Name = "lblSquadron";
            lblSquadron.Size = new Size(59, 15);
            lblSquadron.TabIndex = 2;
            lblSquadron.Text = "Squadron";
            lblSquadron.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSightNum
            // 
            txtSightNum.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtSightNum.Location = new Point(71, 86);
            txtSightNum.Name = "txtSightNum";
            txtSightNum.ReadOnly = true;
            txtSightNum.Size = new Size(60, 22);
            txtSightNum.TabIndex = 5;
            txtSightNum.TabStop = false;
            // 
            // lblSightNum
            // 
            lblSightNum.AutoSize = true;
            lblSightNum.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblSightNum.Location = new Point(6, 89);
            lblSightNum.Name = "lblSightNum";
            lblSightNum.Size = new Size(57, 15);
            lblSightNum.TabIndex = 4;
            lblSightNum.Text = "Sight No.";
            lblSightNum.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SightDateTime
            // 
            SightDateTime.CustomFormat = "MM/dd/yyyy HH:mm:ss ";
            SightDateTime.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            SightDateTime.Format = DateTimePickerFormat.Custom;
            SightDateTime.Location = new Point(100, 115);
            SightDateTime.Name = "SightDateTime";
            SightDateTime.ShowUpDown = true;
            SightDateTime.Size = new Size(155, 22);
            SightDateTime.TabIndex = 10;
            SightDateTime.Value = new DateTime(2017, 6, 7, 0, 0, 0, 0);
            // 
            // lblSightDate
            // 
            lblSightDate.AutoSize = true;
            lblSightDate.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblSightDate.Location = new Point(6, 118);
            lblSightDate.Name = "lblSightDate";
            lblSightDate.Size = new Size(93, 15);
            lblSightDate.TabIndex = 7;
            lblSightDate.Text = "Sight Date/Time";
            lblSightDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWE
            // 
            lblWE.AutoSize = true;
            lblWE.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblWE.Location = new Point(262, 119);
            lblWE.Name = "lblWE";
            lblWE.Size = new Size(68, 15);
            lblWE.TabIndex = 11;
            lblWE.Text = "WE (mmss)";
            lblWE.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtWE
            // 
            txtWE.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtWE.HideSelection = false;
            txtWE.Location = new Point(334, 116);
            txtWE.MaxLength = 4;
            txtWE.Name = "txtWE";
            txtWE.Size = new Size(59, 22);
            txtWE.TabIndex = 15;
            // 
            // cbWEType
            // 
            cbWEType.BackColor = SystemColors.Window;
            cbWEType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbWEType.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cbWEType.FormattingEnabled = true;
            cbWEType.Items.AddRange(new object[] { "Fast", "Slow" });
            cbWEType.Location = new Point(395, 115);
            cbWEType.Name = "cbWEType";
            cbWEType.Size = new Size(100, 23);
            cbWEType.TabIndex = 20;
            // 
            // btnExit
            // 
            _btnExit.BackColor = Color.Red;
            _btnExit.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnExit.ForeColor = SystemColors.ControlLightLight;
            _btnExit.Location = new Point(1253, 87);
            _btnExit.Name = "_btnExit";
            _btnExit.Size = new Size(75, 23);
            _btnExit.TabIndex = 14;
            _btnExit.Text = "Exit";
            _btnExit.UseVisualStyleBackColor = false;
            // 
            // cbIEType
            // 
            cbIEType.BackColor = SystemColors.Window;
            cbIEType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbIEType.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cbIEType.FormattingEnabled = true;
            cbIEType.Items.AddRange(new object[] { "On Arc (-)", "Off Arc (+)" });
            cbIEType.Location = new Point(741, 148);
            cbIEType.Name = "cbIEType";
            cbIEType.Size = new Size(90, 23);
            cbIEType.TabIndex = 80;
            // 
            // txtIE
            // 
            txtIE.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtIE.HideSelection = false;
            txtIE.Location = new Point(652, 148);
            txtIE.MaxLength = 4;
            txtIE.Name = "txtIE";
            txtIE.Size = new Size(35, 22);
            txtIE.TabIndex = 75;
            // 
            // txtHE
            // 
            txtHE.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtHE.HideSelection = false;
            txtHE.Location = new Point(860, 147);
            txtHE.MaxLength = 4;
            txtHE.Name = "txtHE";
            txtHE.Size = new Size(60, 22);
            txtHE.TabIndex = 90;
            // 
            // lblHE
            // 
            lblHE.AutoSize = true;
            lblHE.Cursor = Cursors.Default;
            lblHE.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblHE.Location = new Point(833, 151);
            lblHE.Name = "lblHE";
            lblHE.Size = new Size(23, 15);
            lblHE.TabIndex = 18;
            lblHE.Text = "HE";
            lblHE.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cboLo
            // 
            cboLo.BackColor = SystemColors.Window;
            cboLo.Cursor = Cursors.Default;
            cboLo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLo.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboLo.ForeColor = SystemColors.WindowText;
            cboLo.Items.AddRange(new object[] { "W", "E" });
            cboLo.Location = new Point(331, 147);
            cboLo.Name = "cboLo";
            cboLo.RightToLeft = RightToLeft.No;
            cboLo.Size = new Size(41, 23);
            cboLo.TabIndex = 60;
            // 
            // cboL
            // 
            cboL.BackColor = SystemColors.Window;
            cboL.Cursor = Cursors.Default;
            cboL.DropDownStyle = ComboBoxStyle.DropDownList;
            cboL.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboL.ForeColor = SystemColors.WindowText;
            cboL.Items.AddRange(new object[] { "N", "S" });
            cboL.Location = new Point(132, 147);
            cboL.Name = "cboL";
            cboL.RightToLeft = RightToLeft.No;
            cboL.Size = new Size(41, 23);
            cboL.TabIndex = 45;
            // 
            // txtLDeg
            // 
            txtLDeg.AcceptsReturn = true;
            txtLDeg.BackColor = SystemColors.Window;
            txtLDeg.Cursor = Cursors.IBeam;
            txtLDeg.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtLDeg.ForeColor = SystemColors.WindowText;
            txtLDeg.HideSelection = false;
            txtLDeg.Location = new Point(60, 147);
            txtLDeg.MaxLength = 2;
            txtLDeg.Name = "txtLDeg";
            txtLDeg.RightToLeft = RightToLeft.No;
            txtLDeg.Size = new Size(25, 22);
            txtLDeg.TabIndex = 35;
            // 
            // txtLoMin
            // 
            txtLoMin.AcceptsReturn = true;
            txtLoMin.BackColor = SystemColors.Window;
            txtLoMin.Cursor = Cursors.IBeam;
            txtLoMin.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtLoMin.ForeColor = SystemColors.WindowText;
            txtLoMin.HideSelection = false;
            txtLoMin.Location = new Point(287, 148);
            txtLoMin.MaxLength = 4;
            txtLoMin.Name = "txtLoMin";
            txtLoMin.RightToLeft = RightToLeft.No;
            txtLoMin.Size = new Size(33, 22);
            txtLoMin.TabIndex = 55;
            // 
            // txtLoDeg
            // 
            txtLoDeg.AcceptsReturn = true;
            txtLoDeg.BackColor = SystemColors.Window;
            txtLoDeg.Cursor = Cursors.IBeam;
            txtLoDeg.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtLoDeg.ForeColor = SystemColors.WindowText;
            txtLoDeg.HideSelection = false;
            txtLoDeg.Location = new Point(245, 148);
            txtLoDeg.MaxLength = 3;
            txtLoDeg.Name = "txtLoDeg";
            txtLoDeg.RightToLeft = RightToLeft.No;
            txtLoDeg.Size = new Size(33, 22);
            txtLoDeg.TabIndex = 50;
            // 
            // txtLMin
            // 
            txtLMin.AcceptsReturn = true;
            txtLMin.BackColor = SystemColors.Window;
            txtLMin.Cursor = Cursors.IBeam;
            txtLMin.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtLMin.ForeColor = SystemColors.WindowText;
            txtLMin.HideSelection = false;
            txtLMin.Location = new Point(92, 147);
            txtLMin.MaxLength = 4;
            txtLMin.Name = "txtLMin";
            txtLMin.RightToLeft = RightToLeft.No;
            txtLMin.Size = new Size(33, 22);
            txtLMin.TabIndex = 40;
            // 
            // cboBody
            // 
            _cboBody.BackColor = SystemColors.Window;
            _cboBody.Cursor = Cursors.Default;
            _cboBody.DropDownStyle = ComboBoxStyle.DropDownList;
            _cboBody.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboBody.ForeColor = SystemColors.WindowText;
            _cboBody.Items.AddRange(new object[] { "Sun", "Moon", "Venus", "Mars", "Jupiter", "Saturn", "Acamar", "Achernar", "Acrux", "Adhara", "Aldebaran", "Alioth", "Alkaid", "Al Na'ir", "Alnilam", "Alphard", "Alphecca", "Alpheratz", "Altair", "Ankaa", "Antares", "Arcturus", "Atria", "Avior", "Bellatrix", "Betelgeuse", "Canopus", "Capella", "Deneb", "Denebola", "Diphda", "Dubhe", "Elnath", "Eltanin", "Enif", "Fomalhaut", "Gacrux", "Gienah", "Hadar", "Hamal", "Kaus Australis", "Kochab", "Markab", "Menkar", "Menkent", "Miaplacidus", "Mirfak", "Nunki", "Peacock", "Polaris", "Pollux", "Procyon", "Rasalhague", "Regulus", "Rigel", "Rigil Kentaurus", "Sabik", "Schedar", "Shaula", "Sirius", "Spica", "Suhail", "Vega", "Zubenelgenubi" + '\t' });
            _cboBody.Location = new Point(719, 115);
            _cboBody.Name = "_cboBody";
            _cboBody.RightToLeft = RightToLeft.No;
            _cboBody.Size = new Size(175, 23);
            _cboBody.TabIndex = 25;
            // 
            // lblLoMin
            // 
            lblLoMin.BackColor = SystemColors.Window;
            lblLoMin.Cursor = Cursors.Default;
            lblLoMin.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLoMin.ForeColor = SystemColors.ControlText;
            lblLoMin.Location = new Point(320, 149);
            lblLoMin.Name = "lblLoMin";
            lblLoMin.RightToLeft = RightToLeft.No;
            lblLoMin.Size = new Size(9, 17);
            lblLoMin.TabIndex = 134;
            lblLoMin.Text = "'";
            // 
            // lblLoDeg
            // 
            lblLoDeg.BackColor = SystemColors.Window;
            lblLoDeg.Cursor = Cursors.Default;
            lblLoDeg.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLoDeg.ForeColor = SystemColors.ControlText;
            lblLoDeg.Location = new Point(279, 149);
            lblLoDeg.Name = "lblLoDeg";
            lblLoDeg.RightToLeft = RightToLeft.No;
            lblLoDeg.Size = new Size(9, 17);
            lblLoDeg.TabIndex = 133;
            lblLoDeg.Text = "°";
            // 
            // lblDRLo
            // 
            lblDRLo.BackColor = SystemColors.Control;
            lblDRLo.Cursor = Cursors.Default;
            lblDRLo.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblDRLo.ForeColor = SystemColors.ControlText;
            lblDRLo.Location = new Point(179, 151);
            lblDRLo.Name = "lblDRLo";
            lblDRLo.RightToLeft = RightToLeft.No;
            lblDRLo.Size = new Size(60, 16);
            lblDRLo.TabIndex = 129;
            lblDRLo.Text = "DR Long";
            lblDRLo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLMin
            // 
            lblLMin.BackColor = SystemColors.Window;
            lblLMin.Cursor = Cursors.Default;
            lblLMin.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLMin.ForeColor = SystemColors.ControlText;
            lblLMin.Location = new Point(125, 146);
            lblLMin.Name = "lblLMin";
            lblLMin.RightToLeft = RightToLeft.No;
            lblLMin.Size = new Size(9, 17);
            lblLMin.TabIndex = 128;
            lblLMin.Text = "'";
            // 
            // lblLDeg
            // 
            lblLDeg.BackColor = SystemColors.Window;
            lblLDeg.Cursor = Cursors.Default;
            lblLDeg.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLDeg.ForeColor = SystemColors.ControlText;
            lblLDeg.Location = new Point(85, 147);
            lblLDeg.Name = "lblLDeg";
            lblLDeg.RightToLeft = RightToLeft.No;
            lblLDeg.Size = new Size(9, 17);
            lblLDeg.TabIndex = 127;
            lblLDeg.Text = "°";
            // 
            // lblDRL
            // 
            lblDRL.BackColor = SystemColors.Control;
            lblDRL.Cursor = Cursors.Default;
            lblDRL.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblDRL.ForeColor = SystemColors.ControlText;
            lblDRL.Location = new Point(7, 151);
            lblDRL.Name = "lblDRL";
            lblDRL.RightToLeft = RightToLeft.No;
            lblDRL.Size = new Size(50, 16);
            lblDRL.TabIndex = 123;
            lblDRL.Text = "DR Lat";
            lblDRL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHorType
            // 
            lblHorType.AutoSize = true;
            lblHorType.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblHorType.Location = new Point(965, 151);
            lblHorType.Name = "lblHorType";
            lblHorType.Size = new Size(49, 15);
            lblHorType.TabIndex = 137;
            lblHorType.Text = "Horizon";
            lblHorType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbHorizon
            // 
            _cbHorizon.BackColor = SystemColors.Window;
            _cbHorizon.DropDownStyle = ComboBoxStyle.DropDownList;
            _cbHorizon.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cbHorizon.FormattingEnabled = true;
            _cbHorizon.Items.AddRange(new object[] { "Natural", "Dip Short", "Artificial", "Bubble" });
            _cbHorizon.Location = new Point(1018, 147);
            _cbHorizon.Name = "_cbHorizon";
            _cbHorizon.Size = new Size(80, 23);
            _cbHorizon.TabIndex = 95;
            // 
            // cbHorDistType
            // 
            cbHorDistType.BackColor = SystemColors.Window;
            cbHorDistType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbHorDistType.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cbHorDistType.FormattingEnabled = true;
            cbHorDistType.Items.AddRange(new object[] { "Feet", "Yards", "Meters", "Statute Mile", "Nautical Mile" });
            cbHorDistType.Location = new Point(1234, 147);
            cbHorDistType.Name = "cbHorDistType";
            cbHorDistType.Size = new Size(90, 23);
            cbHorDistType.TabIndex = 105;
            cbHorDistType.Visible = false;
            // 
            // lblDistance
            // 
            lblDistance.AutoSize = true;
            lblDistance.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblDistance.Location = new Point(1100, 152);
            lblDistance.Name = "lblDistance";
            lblDistance.Size = new Size(51, 15);
            lblDistance.TabIndex = 139;
            lblDistance.Text = "Dip Dist";
            lblDistance.TextAlign = ContentAlignment.MiddleCenter;
            lblDistance.Visible = false;
            // 
            // txtHorDist
            // 
            txtHorDist.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtHorDist.HideSelection = false;
            txtHorDist.Location = new Point(1155, 148);
            txtHorDist.MaxLength = 8;
            txtHorDist.Name = "txtHorDist";
            txtHorDist.Size = new Size(75, 22);
            txtHorDist.TabIndex = 100;
            txtHorDist.Visible = false;
            // 
            // chkbxDST
            // 
            _chkbxDST.AutoSize = true;
            _chkbxDST.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _chkbxDST.Location = new Point(625, 118);
            _chkbxDST.Name = "_chkbxDST";
            _chkbxDST.Size = new Size(50, 19);
            _chkbxDST.TabIndex = 25;
            _chkbxDST.Text = "DST";
            _chkbxDST.UseVisualStyleBackColor = true;
            // 
            // btnOpenLog
            // 
            _btnOpenLog.BackColor = SystemColors.HotTrack;
            _btnOpenLog.Font = new Font("Times New Roman", 9.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnOpenLog.ForeColor = SystemColors.HighlightText;
            _btnOpenLog.Location = new Point(136, 12);
            _btnOpenLog.Name = "_btnOpenLog";
            _btnOpenLog.Size = new Size(120, 23);
            _btnOpenLog.TabIndex = 145;
            _btnOpenLog.Text = "Open Existing Log";
            _btnOpenLog.UseVisualStyleBackColor = false;
            // 
            // btnSaveLog
            // 
            _btnSaveLog.BackColor = SystemColors.HotTrack;
            _btnSaveLog.Font = new Font("Times New Roman", 9.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnSaveLog.ForeColor = SystemColors.HighlightText;
            _btnSaveLog.Location = new Point(11, 37);
            _btnSaveLog.Name = "_btnSaveLog";
            _btnSaveLog.Size = new Size(120, 23);
            _btnSaveLog.TabIndex = 146;
            _btnSaveLog.Text = "Save This Log";
            _btnSaveLog.UseVisualStyleBackColor = false;
            // 
            // txtRemarks
            // 
            txtRemarks.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtRemarks.Location = new Point(698, 180);
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new Size(630, 69);
            txtRemarks.TabIndex = 147;
            txtRemarks.Text = "Remarks";
            // 
            // btnAddNew
            // 
            _btnAddNew.BackColor = Color.Yellow;
            _btnAddNew.Font = new Font("Arial Narrow", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnAddNew.ForeColor = SystemColors.ControlText;
            _btnAddNew.Location = new Point(11, 12);
            _btnAddNew.Name = "_btnAddNew";
            _btnAddNew.Size = new Size(110, 23);
            _btnAddNew.TabIndex = 148;
            _btnAddNew.Text = "Add Sight";
            _btnAddNew.UseVisualStyleBackColor = false;
            // 
            // btnUpdateExisting
            // 
            _btnUpdateExisting.BackColor = Color.Yellow;
            _btnUpdateExisting.Font = new Font("Arial Narrow", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnUpdateExisting.ForeColor = SystemColors.ControlText;
            _btnUpdateExisting.Location = new Point(127, 12);
            _btnUpdateExisting.Name = "_btnUpdateExisting";
            _btnUpdateExisting.Size = new Size(110, 23);
            _btnUpdateExisting.TabIndex = 149;
            _btnUpdateExisting.Text = "Update Sight";
            _btnUpdateExisting.UseVisualStyleBackColor = false;
            // 
            // btnDeleteSight
            // 
            _btnDeleteSight.BackColor = Color.Red;
            _btnDeleteSight.Font = new Font("Arial Narrow", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnDeleteSight.ForeColor = SystemColors.HighlightText;
            _btnDeleteSight.Location = new Point(240, 12);
            _btnDeleteSight.Name = "_btnDeleteSight";
            _btnDeleteSight.Size = new Size(110, 23);
            _btnDeleteSight.TabIndex = 150;
            _btnDeleteSight.Text = "Delete Sight";
            _btnDeleteSight.UseVisualStyleBackColor = false;
            // 
            // btnNewLog
            // 
            _btnNewLog.BackColor = SystemColors.HotTrack;
            _btnNewLog.Font = new Font("Times New Roman", 9.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnNewLog.ForeColor = SystemColors.HighlightText;
            _btnNewLog.Location = new Point(11, 12);
            _btnNewLog.Name = "_btnNewLog";
            _btnNewLog.Size = new Size(120, 23);
            _btnNewLog.TabIndex = 151;
            _btnNewLog.Text = "Start A New Log";
            _btnNewLog.UseVisualStyleBackColor = false;
            // 
            // btnSightReduce
            // 
            _btnSightReduce.BackColor = Color.Blue;
            _btnSightReduce.Font = new Font("Arial Narrow", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnSightReduce.ForeColor = SystemColors.HighlightText;
            _btnSightReduce.Location = new Point(11, 40);
            _btnSightReduce.Name = "_btnSightReduce";
            _btnSightReduce.Size = new Size(110, 23);
            _btnSightReduce.TabIndex = 152;
            _btnSightReduce.Text = "Sight Reduction";
            _btnSightReduce.UseVisualStyleBackColor = false;
            // 
            // cbLimb
            // 
            cbLimb.BackColor = SystemColors.Window;
            cbLimb.Cursor = Cursors.Default;
            cbLimb.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLimb.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cbLimb.ForeColor = SystemColors.WindowText;
            cbLimb.Items.AddRange(new object[] { "Lower", "Upper", "Center" });
            cbLimb.Location = new Point(937, 115);
            cbLimb.Name = "cbLimb";
            cbLimb.RightToLeft = RightToLeft.No;
            cbLimb.Size = new Size(100, 23);
            cbLimb.TabIndex = 30;
            // 
            // lblLimb
            // 
            lblLimb.BackColor = SystemColors.Control;
            lblLimb.Cursor = Cursors.Default;
            lblLimb.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLimb.ForeColor = SystemColors.ControlText;
            lblLimb.Location = new Point(897, 118);
            lblLimb.Name = "lblLimb";
            lblLimb.RightToLeft = RightToLeft.No;
            lblLimb.Size = new Size(38, 17);
            lblLimb.TabIndex = 154;
            lblLimb.Text = "Limb";
            lblLimb.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtHSDeg
            // 
            txtHSDeg.AcceptsReturn = true;
            txtHSDeg.BackColor = SystemColors.Window;
            txtHSDeg.Cursor = Cursors.IBeam;
            txtHSDeg.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtHSDeg.ForeColor = SystemColors.WindowText;
            txtHSDeg.HideSelection = false;
            txtHSDeg.Location = new Point(457, 148);
            txtHSDeg.MaxLength = 2;
            txtHSDeg.Name = "txtHSDeg";
            txtHSDeg.RightToLeft = RightToLeft.No;
            txtHSDeg.Size = new Size(30, 22);
            txtHSDeg.TabIndex = 65;
            // 
            // txtHSMin
            // 
            txtHSMin.AcceptsReturn = true;
            txtHSMin.BackColor = SystemColors.Window;
            txtHSMin.Cursor = Cursors.IBeam;
            txtHSMin.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtHSMin.ForeColor = SystemColors.WindowText;
            txtHSMin.HideSelection = false;
            txtHSMin.Location = new Point(497, 148);
            txtHSMin.MaxLength = 4;
            txtHSMin.Name = "txtHSMin";
            txtHSMin.RightToLeft = RightToLeft.No;
            txtHSMin.Size = new Size(33, 22);
            txtHSMin.TabIndex = 70;
            // 
            // Label1
            // 
            Label1.BackColor = SystemColors.Window;
            Label1.Cursor = Cursors.Default;
            Label1.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = SystemColors.ControlText;
            Label1.Location = new Point(532, 149);
            Label1.Name = "Label1";
            Label1.RightToLeft = RightToLeft.No;
            Label1.Size = new Size(9, 17);
            Label1.TabIndex = 159;
            Label1.Text = "'";
            // 
            // Label2
            // 
            Label2.BackColor = SystemColors.Window;
            Label2.Cursor = Cursors.Default;
            Label2.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = SystemColors.ControlText;
            Label2.Location = new Point(487, 150);
            Label2.Name = "Label2";
            Label2.RightToLeft = RightToLeft.No;
            Label2.Size = new Size(9, 17);
            Label2.TabIndex = 158;
            Label2.Text = "°";
            // 
            // lvlHS
            // 
            lvlHS.BackColor = SystemColors.Control;
            lvlHS.Cursor = Cursors.Default;
            lvlHS.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lvlHS.ForeColor = SystemColors.ControlText;
            lvlHS.Location = new Point(429, 150);
            lvlHS.Name = "lvlHS";
            lvlHS.RightToLeft = RightToLeft.No;
            lvlHS.Size = new Size(25, 19);
            lvlHS.TabIndex = 155;
            lvlHS.Text = "Hs";
            lvlHS.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtIntZn
            // 
            txtIntZn.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtIntZn.Location = new Point(83, 19);
            txtIntZn.Name = "txtIntZn";
            txtIntZn.ReadOnly = true;
            txtIntZn.Size = new Size(259, 22);
            txtIntZn.TabIndex = 160;
            // 
            // SEDataGrid
            // 
            _SEDataGrid.AllowUserToAddRows = false;
            _SEDataGrid.AllowUserToDeleteRows = false;
            _SEDataGrid.AllowUserToResizeColumns = false;
            _SEDataGrid.AllowUserToResizeRows = false;
            _SEDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            _SEDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            _SEDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            _SEDataGrid.BorderStyle = BorderStyle.Fixed3D;
            _SEDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            _SEDataGrid.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle11.BackColor = SystemColors.ActiveCaption;
            DataGridViewCellStyle11.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            _SEDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11;
            _SEDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _SEDataGrid.Columns.AddRange(new DataGridViewColumn[] { SightNum, SDateTime, BodyName, BodyLimb, SDST, SWE, SWEType, ZD, HS, HorType, HorDist, HorDistType, HE, IC, ICType, DRLat, DRLong, LLoBy, Intercept, Aziumuth, EP, PsnName, Squadron, WTDiff, HSDiff, HSWTRate, Remarks, SRGHA, SRDec, SRHo, UserInfo });
            DataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle14.BackColor = SystemColors.Window;
            DataGridViewCellStyle14.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle14.ForeColor = SystemColors.ControlText;
            DataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            _SEDataGrid.DefaultCellStyle = DataGridViewCellStyle14;
            _SEDataGrid.Location = new Point(9, 331);
            _SEDataGrid.Name = "_SEDataGrid";
            DataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle15.BackColor = SystemColors.Control;
            DataGridViewCellStyle15.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle15.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle15.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle15.WrapMode = DataGridViewTriState.False;
            _SEDataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle15;
            _SEDataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            _SEDataGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Blue;
            _SEDataGrid.Size = new Size(1320, 432);
            _SEDataGrid.TabIndex = 161;
            // 
            // SightNum
            // 
            SightNum.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SightNum.HeaderText = "No";
            SightNum.MaxInputLength = 5;
            SightNum.MinimumWidth = 3;
            SightNum.Name = "SightNum";
            SightNum.ReadOnly = true;
            SightNum.Resizable = DataGridViewTriState.True;
            SightNum.SortMode = DataGridViewColumnSortMode.NotSortable;
            SightNum.Width = 29;
            // 
            // SDateTime
            // 
            SDateTime.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DataGridViewCellStyle12.Format = "MM/dd/yyyy HH:mm:ss";
            DataGridViewCellStyle12.NullValue = null;
            SDateTime.DefaultCellStyle = DataGridViewCellStyle12;
            SDateTime.HeaderText = "Date/Time";
            SDateTime.MaxInputLength = 22;
            SDateTime.Name = "SDateTime";
            SDateTime.ReadOnly = true;
            SDateTime.Resizable = DataGridViewTriState.True;
            SDateTime.SortMode = DataGridViewColumnSortMode.NotSortable;
            SDateTime.Width = 68;
            // 
            // BodyName
            // 
            BodyName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            BodyName.HeaderText = "Body";
            BodyName.Name = "BodyName";
            BodyName.ReadOnly = true;
            BodyName.Resizable = DataGridViewTriState.True;
            BodyName.SortMode = DataGridViewColumnSortMode.NotSortable;
            BodyName.Width = 42;
            // 
            // BodyLimb
            // 
            BodyLimb.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            BodyLimb.HeaderText = "Limb";
            BodyLimb.Name = "BodyLimb";
            BodyLimb.ReadOnly = true;
            BodyLimb.Resizable = DataGridViewTriState.True;
            BodyLimb.SortMode = DataGridViewColumnSortMode.NotSortable;
            BodyLimb.Width = 39;
            // 
            // SDST
            // 
            SDST.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            SDST.HeaderText = "DST";
            SDST.MinimumWidth = 3;
            SDST.Name = "SDST";
            SDST.ReadOnly = true;
            SDST.Resizable = DataGridViewTriState.True;
            SDST.SortMode = DataGridViewColumnSortMode.NotSortable;
            SDST.Width = 37;
            // 
            // SWE
            // 
            SWE.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SWE.HeaderText = "WE";
            SWE.Name = "SWE";
            SWE.ReadOnly = true;
            SWE.Resizable = DataGridViewTriState.True;
            SWE.SortMode = DataGridViewColumnSortMode.NotSortable;
            SWE.Width = 33;
            // 
            // SWEType
            // 
            SWEType.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SWEType.HeaderText = "F/S";
            SWEType.Name = "SWEType";
            SWEType.ReadOnly = true;
            SWEType.Resizable = DataGridViewTriState.True;
            SWEType.SortMode = DataGridViewColumnSortMode.NotSortable;
            SWEType.Width = 31;
            // 
            // ZD
            // 
            ZD.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ZD.HeaderText = "ZD";
            ZD.Name = "ZD";
            ZD.ReadOnly = true;
            ZD.Resizable = DataGridViewTriState.True;
            ZD.SortMode = DataGridViewColumnSortMode.NotSortable;
            ZD.Width = 30;
            // 
            // HS
            // 
            HS.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            HS.HeaderText = "HS";
            HS.Name = "HS";
            HS.ReadOnly = true;
            HS.Resizable = DataGridViewTriState.True;
            HS.SortMode = DataGridViewColumnSortMode.NotSortable;
            HS.Width = 29;
            // 
            // HorType
            // 
            HorType.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            HorType.HeaderText = "Horizon";
            HorType.Name = "HorType";
            HorType.ReadOnly = true;
            HorType.Resizable = DataGridViewTriState.True;
            HorType.SortMode = DataGridViewColumnSortMode.NotSortable;
            HorType.ToolTipText = "Natural / Dip Short / Artificial / Bubble";
            HorType.Width = 55;
            // 
            // HorDist
            // 
            HorDist.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            HorDist.HeaderText = "Dip Dist";
            HorDist.Name = "HorDist";
            HorDist.ReadOnly = true;
            HorDist.Resizable = DataGridViewTriState.True;
            HorDist.SortMode = DataGridViewColumnSortMode.NotSortable;
            HorDist.Width = 57;
            // 
            // HorDistType
            // 
            HorDistType.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            HorDistType.HeaderText = "Apprx Brg";
            HorDistType.Name = "HorDistType";
            HorDistType.ReadOnly = true;
            HorDistType.Resizable = DataGridViewTriState.True;
            HorDistType.SortMode = DataGridViewColumnSortMode.NotSortable;
            HorDistType.Width = 68;
            // 
            // HE
            // 
            HE.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            HE.HeaderText = "HE";
            HE.Name = "HE";
            HE.ReadOnly = true;
            HE.Resizable = DataGridViewTriState.True;
            HE.SortMode = DataGridViewColumnSortMode.NotSortable;
            HE.Width = 29;
            // 
            // IC
            // 
            IC.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            IC.HeaderText = "IE";
            IC.Name = "IC";
            IC.ReadOnly = true;
            IC.SortMode = DataGridViewColumnSortMode.NotSortable;
            IC.Width = 24;
            // 
            // ICType
            // 
            ICType.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ICType.HeaderText = "Arc";
            ICType.MinimumWidth = 4;
            ICType.Name = "ICType";
            ICType.ReadOnly = true;
            ICType.Resizable = DataGridViewTriState.True;
            ICType.SortMode = DataGridViewColumnSortMode.NotSortable;
            ICType.Width = 33;
            // 
            // DRLat
            // 
            DRLat.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DRLat.HeaderText = "Lat";
            DRLat.Name = "DRLat";
            DRLat.ReadOnly = true;
            DRLat.Resizable = DataGridViewTriState.True;
            DRLat.SortMode = DataGridViewColumnSortMode.NotSortable;
            DRLat.Width = 30;
            // 
            // DRLong
            // 
            DRLong.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DRLong.HeaderText = "Long";
            DRLong.Name = "DRLong";
            DRLong.ReadOnly = true;
            DRLong.SortMode = DataGridViewColumnSortMode.NotSortable;
            DRLong.Width = 41;
            // 
            // LLoBy
            // 
            LLoBy.HeaderText = "LLoBy";
            LLoBy.Name = "LLoBy";
            LLoBy.ReadOnly = true;
            LLoBy.Width = 68;
            // 
            // Intercept
            // 
            Intercept.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Intercept.HeaderText = "a (nm)";
            Intercept.Name = "Intercept";
            Intercept.ReadOnly = true;
            Intercept.Resizable = DataGridViewTriState.True;
            Intercept.SortMode = DataGridViewColumnSortMode.NotSortable;
            Intercept.Width = 46;
            // 
            // Aziumuth
            // 
            Aziumuth.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Aziumuth.HeaderText = "Zn";
            Aziumuth.Name = "Aziumuth";
            Aziumuth.ReadOnly = true;
            Aziumuth.Resizable = DataGridViewTriState.True;
            Aziumuth.SortMode = DataGridViewColumnSortMode.NotSortable;
            Aziumuth.Width = 28;
            // 
            // EP
            // 
            EP.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            EP.HeaderText = "SR Est Position";
            EP.Name = "EP";
            EP.ReadOnly = true;
            EP.Resizable = DataGridViewTriState.True;
            EP.SortMode = DataGridViewColumnSortMode.NotSortable;
            EP.Width = 95;
            // 
            // PsnName
            // 
            PsnName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            PsnName.HeaderText = "Name";
            PsnName.Name = "PsnName";
            PsnName.ReadOnly = true;
            PsnName.Resizable = DataGridViewTriState.True;
            PsnName.SortMode = DataGridViewColumnSortMode.NotSortable;
            PsnName.Width = 43;
            // 
            // Squadron
            // 
            Squadron.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Squadron.HeaderText = "Squadron";
            Squadron.Name = "Squadron";
            Squadron.ReadOnly = true;
            Squadron.Resizable = DataGridViewTriState.True;
            Squadron.SortMode = DataGridViewColumnSortMode.NotSortable;
            Squadron.Width = 65;
            // 
            // WTDiff
            // 
            WTDiff.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            WTDiff.HeaderText = "WT diff (sec)";
            WTDiff.Name = "WTDiff";
            WTDiff.ReadOnly = true;
            WTDiff.Resizable = DataGridViewTriState.True;
            WTDiff.SortMode = DataGridViewColumnSortMode.NotSortable;
            WTDiff.Visible = false;
            // 
            // HSDiff
            // 
            HSDiff.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            HSDiff.HeaderText = "hs diff (')";
            HSDiff.Name = "HSDiff";
            HSDiff.ReadOnly = true;
            HSDiff.Resizable = DataGridViewTriState.True;
            HSDiff.SortMode = DataGridViewColumnSortMode.NotSortable;
            HSDiff.Visible = false;
            // 
            // HSWTRate
            // 
            HSWTRate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            HSWTRate.HeaderText = "hs/WT ('/sec)";
            HSWTRate.Name = "HSWTRate";
            HSWTRate.ReadOnly = true;
            HSWTRate.Resizable = DataGridViewTriState.True;
            HSWTRate.SortMode = DataGridViewColumnSortMode.NotSortable;
            HSWTRate.Visible = false;
            // 
            // Remarks
            // 
            Remarks.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.TopLeft;
            Remarks.DefaultCellStyle = DataGridViewCellStyle13;
            Remarks.HeaderText = "Remarks";
            Remarks.Name = "Remarks";
            Remarks.ReadOnly = true;
            Remarks.Resizable = DataGridViewTriState.True;
            Remarks.SortMode = DataGridViewColumnSortMode.NotSortable;
            Remarks.Width = 58;
            // 
            // SRGHA
            // 
            SRGHA.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SRGHA.HeaderText = "SR GHA";
            SRGHA.Name = "SRGHA";
            SRGHA.ReadOnly = true;
            SRGHA.SortMode = DataGridViewColumnSortMode.NotSortable;
            SRGHA.Visible = false;
            // 
            // SRDec
            // 
            SRDec.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SRDec.HeaderText = "SR Dec";
            SRDec.Name = "SRDec";
            SRDec.ReadOnly = true;
            SRDec.SortMode = DataGridViewColumnSortMode.NotSortable;
            SRDec.Visible = false;
            // 
            // SRHo
            // 
            SRHo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SRHo.HeaderText = "SR Ho";
            SRHo.Name = "SRHo";
            SRHo.ReadOnly = true;
            SRHo.SortMode = DataGridViewColumnSortMode.NotSortable;
            SRHo.Visible = false;
            // 
            // UserInfo
            // 
            UserInfo.HeaderText = "User Info";
            UserInfo.Name = "UserInfo";
            UserInfo.ReadOnly = true;
            UserInfo.SortMode = DataGridViewColumnSortMode.NotSortable;
            UserInfo.Width = 63;
            // 
            // lblUSPSSightLog
            // 
            lblUSPSSightLog.AutoSize = true;
            lblUSPSSightLog.Font = new Font("Arial", 14.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblUSPSSightLog.Location = new Point(511, 15);
            lblUSPSSightLog.Name = "lblUSPSSightLog";
            lblUSPSSightLog.Size = new Size(286, 22);
            lblUSPSSightLog.TabIndex = 162;
            lblUSPSSightLog.Text = "Celestial Navigation Sight Log";
            // 
            // lblZD
            // 
            lblZD.AutoSize = true;
            lblZD.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblZD.Location = new Point(499, 119);
            lblZD.Name = "lblZD";
            lblZD.Size = new Size(24, 15);
            lblZD.TabIndex = 163;
            lblZD.Text = "ZD";
            lblZD.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cboZD
            // 
            cboZD.BackColor = SystemColors.Window;
            cboZD.Cursor = Cursors.Default;
            cboZD.DropDownStyle = ComboBoxStyle.DropDownList;
            cboZD.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboZD.ForeColor = SystemColors.WindowText;
            cboZD.Location = new Point(526, 115);
            cboZD.Name = "cboZD";
            cboZD.RightToLeft = RightToLeft.No;
            cboZD.Size = new Size(95, 23);
            cboZD.TabIndex = 32;
            // 
            // btnClearFields
            // 
            _btnClearFields.BackColor = Color.Yellow;
            _btnClearFields.Font = new Font("Arial Narrow", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnClearFields.ForeColor = SystemColors.WindowText;
            _btnClearFields.Location = new Point(356, 12);
            _btnClearFields.Name = "_btnClearFields";
            _btnClearFields.Size = new Size(110, 23);
            _btnClearFields.TabIndex = 164;
            _btnClearFields.Text = "Clear Fields";
            _btnClearFields.UseVisualStyleBackColor = false;
            // 
            // Label3
            // 
            Label3.BackColor = Color.AntiqueWhite;
            Label3.Cursor = Cursors.Default;
            Label3.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.ForeColor = SystemColors.ControlText;
            Label3.Location = new Point(4, 22);
            Label3.Name = "Label3";
            Label3.RightToLeft = RightToLeft.No;
            Label3.Size = new Size(77, 16);
            Label3.TabIndex = 165;
            Label3.Text = "SR Int && Az";
            // 
            // grpSightButtons
            // 
            grpSightButtons.BackColor = SystemColors.ActiveCaption;
            grpSightButtons.Controls.Add(_btnPlanSight);
            grpSightButtons.Controls.Add(_btnCustomPlot);
            grpSightButtons.Controls.Add(_btnUseCLS);
            grpSightButtons.Controls.Add(_btnNoonSight);
            grpSightButtons.Controls.Add(_btnAltSR);
            grpSightButtons.Controls.Add(Label4);
            grpSightButtons.Controls.Add(_btnClearFields);
            grpSightButtons.Controls.Add(_btnAddNew);
            grpSightButtons.Controls.Add(_btnUpdateExisting);
            grpSightButtons.Controls.Add(_btnDeleteSight);
            grpSightButtons.Controls.Add(_btnSightReduce);
            grpSightButtons.Location = new Point(698, 255);
            grpSightButtons.Name = "grpSightButtons";
            grpSightButtons.Size = new Size(630, 70);
            grpSightButtons.TabIndex = 166;
            grpSightButtons.TabStop = false;
            grpSightButtons.Text = "Sight Actions";
            // 
            // btnPlanSight
            // 
            _btnPlanSight.BackColor = Color.Gold;
            _btnPlanSight.Font = new Font("Arial Narrow", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnPlanSight.ForeColor = SystemColors.ControlText;
            _btnPlanSight.Location = new Point(356, 40);
            _btnPlanSight.Name = "_btnPlanSight";
            _btnPlanSight.Size = new Size(110, 23);
            _btnPlanSight.TabIndex = 175;
            _btnPlanSight.Text = "Plan Sight";
            _btnPlanSight.UseVisualStyleBackColor = false;
            _btnPlanSight.Visible = false;
            // 
            // btnCustomPlot
            // 
            _btnCustomPlot.BackColor = Color.Yellow;
            _btnCustomPlot.Font = new Font("Arial Narrow", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnCustomPlot.ForeColor = SystemColors.WindowText;
            _btnCustomPlot.Location = new Point(472, 41);
            _btnCustomPlot.Name = "_btnCustomPlot";
            _btnCustomPlot.Size = new Size(110, 23);
            _btnCustomPlot.TabIndex = 174;
            _btnCustomPlot.Text = "Custom Plot Form";
            _btnCustomPlot.UseVisualStyleBackColor = false;
            _btnCustomPlot.Visible = false;
            // 
            // btnUseCLS
            // 
            _btnUseCLS.BackColor = Color.Yellow;
            _btnUseCLS.Font = new Font("Arial Narrow", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnUseCLS.ForeColor = SystemColors.WindowText;
            _btnUseCLS.Location = new Point(472, 12);
            _btnUseCLS.Name = "_btnUseCLS";
            _btnUseCLS.Size = new Size(110, 23);
            _btnUseCLS.TabIndex = 173;
            _btnUseCLS.Text = "CLS Form Plot";
            _btnUseCLS.UseVisualStyleBackColor = false;
            _btnUseCLS.Visible = false;
            // 
            // btnNoonSight
            // 
            _btnNoonSight.BackColor = Color.Gold;
            _btnNoonSight.Font = new Font("Arial Narrow", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnNoonSight.ForeColor = SystemColors.ControlText;
            _btnNoonSight.Location = new Point(240, 40);
            _btnNoonSight.Name = "_btnNoonSight";
            _btnNoonSight.Size = new Size(110, 23);
            _btnNoonSight.TabIndex = 171;
            _btnNoonSight.Text = "Noon Sight Form";
            _btnNoonSight.UseVisualStyleBackColor = false;
            _btnNoonSight.Visible = false;
            // 
            // btnAltSR
            // 
            _btnAltSR.BackColor = Color.DarkSlateGray;
            _btnAltSR.Font = new Font("Arial Narrow", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnAltSR.ForeColor = SystemColors.HighlightText;
            _btnAltSR.Location = new Point(127, 40);
            _btnAltSR.Name = "_btnAltSR";
            _btnAltSR.Size = new Size(110, 23);
            _btnAltSR.TabIndex = 170;
            _btnAltSR.Text = "Alt SR Method";
            _btnAltSR.UseVisualStyleBackColor = false;
            _btnAltSR.Visible = false;
            // 
            // Label4
            // 
            Label4.BackColor = SystemColors.Window;
            Label4.Cursor = Cursors.Default;
            Label4.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.ForeColor = SystemColors.ControlText;
            Label4.Location = new Point(305, -53);
            Label4.Name = "Label4";
            Label4.RightToLeft = RightToLeft.No;
            Label4.Size = new Size(9, 17);
            Label4.TabIndex = 169;
            Label4.Text = "'";
            // 
            // btnSLReport
            // 
            _btnSLReport.BackColor = SystemColors.HotTrack;
            _btnSLReport.Font = new Font("Times New Roman", 9.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnSLReport.ForeColor = SystemColors.HighlightText;
            _btnSLReport.Location = new Point(260, 12);
            _btnSLReport.Name = "_btnSLReport";
            _btnSLReport.Size = new Size(185, 23);
            _btnSLReport.TabIndex = 153;
            _btnSLReport.Text = "Save Log As Formatted CSV File";
            _btnSLReport.UseVisualStyleBackColor = false;
            _btnSLReport.Visible = false;
            // 
            // btnPrintDG
            // 
            _btnPrintDG.BackColor = SystemColors.HotTrack;
            _btnPrintDG.Font = new Font("Times New Roman", 9.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnPrintDG.ForeColor = SystemColors.HighlightText;
            _btnPrintDG.Location = new Point(134, 37);
            _btnPrintDG.Name = "_btnPrintDG";
            _btnPrintDG.Size = new Size(120, 23);
            _btnPrintDG.TabIndex = 152;
            _btnPrintDG.Text = "Print Data Grid Data";
            _btnPrintDG.UseVisualStyleBackColor = false;
            _btnPrintDG.Visible = false;
            // 
            // PrintDialog1
            // 
            PrintDialog1.UseEXDialog = true;
            // 
            // PrintDocument1
            // 
            _PrintDocument1.DocumentName = "Sight Log ";
            // 
            // lblBodyNm
            // 
            lblBodyNm.BackColor = SystemColors.Control;
            lblBodyNm.Cursor = Cursors.Default;
            lblBodyNm.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblBodyNm.ForeColor = SystemColors.ControlText;
            lblBodyNm.Location = new Point(673, 118);
            lblBodyNm.Name = "lblBodyNm";
            lblBodyNm.RightToLeft = RightToLeft.No;
            lblBodyNm.Size = new Size(45, 17);
            lblBodyNm.TabIndex = 168;
            lblBodyNm.Text = "Body";
            lblBodyNm.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label5
            // 
            Label5.BackColor = SystemColors.Window;
            Label5.Cursor = Cursors.Default;
            Label5.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label5.ForeColor = SystemColors.ControlText;
            Label5.Location = new Point(689, 149);
            Label5.Name = "Label5";
            Label5.RightToLeft = RightToLeft.No;
            Label5.Size = new Size(9, 17);
            Label5.TabIndex = 169;
            Label5.Text = "'";
            // 
            // txtIEDeg
            // 
            txtIEDeg.AcceptsReturn = true;
            txtIEDeg.BackColor = SystemColors.Window;
            txtIEDeg.Cursor = Cursors.IBeam;
            txtIEDeg.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtIEDeg.ForeColor = SystemColors.WindowText;
            txtIEDeg.HideSelection = false;
            txtIEDeg.Location = new Point(610, 148);
            txtIEDeg.MaxLength = 2;
            txtIEDeg.Name = "txtIEDeg";
            txtIEDeg.RightToLeft = RightToLeft.No;
            txtIEDeg.Size = new Size(30, 22);
            txtIEDeg.TabIndex = 72;
            // 
            // Label6
            // 
            Label6.BackColor = SystemColors.Window;
            Label6.Cursor = Cursors.Default;
            Label6.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label6.ForeColor = SystemColors.ControlText;
            Label6.Location = new Point(642, 150);
            Label6.Name = "Label6";
            Label6.RightToLeft = RightToLeft.No;
            Label6.Size = new Size(9, 17);
            Label6.TabIndex = 171;
            Label6.Text = "°";
            // 
            // lblIE
            // 
            lblIE.AutoSize = true;
            lblIE.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblIE.Location = new Point(589, 151);
            lblIE.Name = "lblIE";
            lblIE.Size = new Size(18, 15);
            lblIE.TabIndex = 15;
            lblIE.Text = "IE";
            lblIE.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cboHEUnit
            // 
            cboHEUnit.BackColor = SystemColors.Window;
            cboHEUnit.Cursor = Cursors.Default;
            cboHEUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHEUnit.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboHEUnit.ForeColor = SystemColors.WindowText;
            cboHEUnit.Items.AddRange(new object[] { "ft", "in", "m", "cm" });
            cboHEUnit.Location = new Point(924, 147);
            cboHEUnit.Name = "cboHEUnit";
            cboHEUnit.RightToLeft = RightToLeft.No;
            cboHEUnit.Size = new Size(41, 23);
            cboHEUnit.TabIndex = 172;
            // 
            // lblSRFEP
            // 
            lblSRFEP.BackColor = Color.AntiqueWhite;
            lblSRFEP.Cursor = Cursors.Default;
            lblSRFEP.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblSRFEP.ForeColor = SystemColors.ControlText;
            lblSRFEP.Location = new Point(3, 47);
            lblSRFEP.Name = "lblSRFEP";
            lblSRFEP.RightToLeft = RightToLeft.No;
            lblSRFEP.Size = new Size(60, 16);
            lblSRFEP.TabIndex = 174;
            lblSRFEP.Text = "SR EP";
            // 
            // txtSRFEP
            // 
            txtSRFEP.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtSRFEP.Location = new Point(83, 44);
            txtSRFEP.Name = "txtSRFEP";
            txtSRFEP.ReadOnly = true;
            txtSRFEP.Size = new Size(259, 22);
            txtSRFEP.TabIndex = 173;
            // 
            // txtHsSec
            // 
            txtHsSec.AcceptsReturn = true;
            txtHsSec.BackColor = SystemColors.Window;
            txtHsSec.Cursor = Cursors.IBeam;
            txtHsSec.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtHsSec.ForeColor = SystemColors.WindowText;
            txtHsSec.Location = new Point(543, 148);
            txtHsSec.MaxLength = 2;
            txtHsSec.Name = "txtHsSec";
            txtHsSec.RightToLeft = RightToLeft.No;
            txtHsSec.Size = new Size(33, 22);
            txtHsSec.TabIndex = 71;
            txtHsSec.Visible = false;
            // 
            // lblHsSec
            // 
            lblHsSec.BackColor = SystemColors.Window;
            lblHsSec.Cursor = Cursors.Default;
            lblHsSec.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblHsSec.ForeColor = SystemColors.ControlText;
            lblHsSec.Location = new Point(578, 150);
            lblHsSec.Name = "lblHsSec";
            lblHsSec.RightToLeft = RightToLeft.No;
            lblHsSec.Size = new Size(9, 17);
            lblHsSec.TabIndex = 176;
            lblHsSec.Text = "\"";
            lblHsSec.Visible = false;
            // 
            // txtIESec
            // 
            txtIESec.AcceptsReturn = true;
            txtIESec.BackColor = SystemColors.Window;
            txtIESec.Cursor = Cursors.IBeam;
            txtIESec.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtIESec.ForeColor = SystemColors.WindowText;
            txtIESec.Location = new Point(697, 148);
            txtIESec.MaxLength = 2;
            txtIESec.Name = "txtIESec";
            txtIESec.RightToLeft = RightToLeft.No;
            txtIESec.Size = new Size(33, 22);
            txtIESec.TabIndex = 76;
            txtIESec.Visible = false;
            // 
            // lblIEsec
            // 
            lblIEsec.BackColor = SystemColors.Window;
            lblIEsec.Cursor = Cursors.Default;
            lblIEsec.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblIEsec.ForeColor = SystemColors.ControlText;
            lblIEsec.Location = new Point(729, 149);
            lblIEsec.Name = "lblIEsec";
            lblIEsec.RightToLeft = RightToLeft.No;
            lblIEsec.Size = new Size(9, 17);
            lblIEsec.TabIndex = 178;
            lblIEsec.Text = "\"";
            lblIEsec.Visible = false;
            // 
            // lblHSIEFmt
            // 
            lblHSIEFmt.AutoSize = true;
            lblHSIEFmt.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblHSIEFmt.Location = new Point(468, 22);
            lblHSIEFmt.Name = "lblHSIEFmt";
            lblHSIEFmt.Size = new Size(120, 14);
            lblHSIEFmt.TabIndex = 179;
            lblHSIEFmt.Text = "Default SR hs/IE Format";
            // 
            // cboHSIEFmt
            // 
            _cboHSIEFmt.BackColor = SystemColors.Window;
            _cboHSIEFmt.DropDownStyle = ComboBoxStyle.DropDownList;
            _cboHSIEFmt.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboHSIEFmt.FormattingEnabled = true;
            _cboHSIEFmt.Items.AddRange(new object[] { "DM", "DMS" });
            _cboHSIEFmt.Location = new Point(596, 18);
            _cboHSIEFmt.Name = "_cboHSIEFmt";
            _cboHSIEFmt.Size = new Size(70, 22);
            _cboHSIEFmt.TabIndex = 180;
            // 
            // cboApprxBrg
            // 
            cboApprxBrg.BackColor = SystemColors.Window;
            cboApprxBrg.DropDownStyle = ComboBoxStyle.DropDownList;
            cboApprxBrg.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboApprxBrg.FormattingEnabled = true;
            cboApprxBrg.Items.AddRange(new object[] { "N", "NE", "E", "SE", "S", "SW", "W", "NW", "None" });
            cboApprxBrg.Location = new Point(1242, 116);
            cboApprxBrg.Name = "cboApprxBrg";
            cboApprxBrg.Size = new Size(70, 23);
            cboApprxBrg.TabIndex = 182;
            // 
            // lblApprxBrg
            // 
            lblApprxBrg.AutoSize = true;
            lblApprxBrg.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblApprxBrg.Location = new Point(1175, 120);
            lblApprxBrg.Name = "lblApprxBrg";
            lblApprxBrg.Size = new Size(62, 15);
            lblApprxBrg.TabIndex = 181;
            lblApprxBrg.Text = "Apprx Brg";
            lblApprxBrg.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CheckBoxShowAvg
            // 
            _CheckBoxShowAvg.AutoSize = true;
            _CheckBoxShowAvg.Location = new Point(10, 43);
            _CheckBoxShowAvg.Name = "_CheckBoxShowAvg";
            _CheckBoxShowAvg.Size = new Size(220, 17);
            _CheckBoxShowAvg.TabIndex = 183;
            _CheckBoxShowAvg.Text = "Show Sight WT and hs Diff's for all sights";
            _CheckBoxShowAvg.UseVisualStyleBackColor = true;
            // 
            // CheckBoxAutoReduce
            // 
            _CheckBoxAutoReduce.AutoSize = true;
            _CheckBoxAutoReduce.Location = new Point(10, 21);
            _CheckBoxAutoReduce.Name = "_CheckBoxAutoReduce";
            _CheckBoxAutoReduce.Size = new Size(211, 17);
            _CheckBoxAutoReduce.TabIndex = 184;
            _CheckBoxAutoReduce.Text = "Auto Reduce New and Updated Sights";
            _CheckBoxAutoReduce.UseVisualStyleBackColor = true;
            // 
            // SLOptions
            // 
            SLOptions.BackColor = SystemColors.ActiveCaption;
            SLOptions.Controls.Add(_chkDispGHADecHo);
            SLOptions.Controls.Add(_chkClearFields);
            SLOptions.Controls.Add(Label8);
            SLOptions.Controls.Add(_CheckBoxShowAvg);
            SLOptions.Controls.Add(_CheckBoxAutoReduce);
            SLOptions.Controls.Add(_cboHSIEFmt);
            SLOptions.Controls.Add(lblHSIEFmt);
            SLOptions.Location = new Point(9, 255);
            SLOptions.Name = "SLOptions";
            SLOptions.Size = new Size(683, 70);
            SLOptions.TabIndex = 186;
            SLOptions.TabStop = false;
            SLOptions.Text = "SightLog Options";
            // 
            // chkDispGHADecHo
            // 
            _chkDispGHADecHo.AutoSize = true;
            _chkDispGHADecHo.Location = new Point(236, 43);
            _chkDispGHADecHo.Name = "_chkDispGHADecHo";
            _chkDispGHADecHo.Size = new Size(241, 17);
            _chkDispGHADecHo.TabIndex = 186;
            _chkDispGHADecHo.Text = "Display Sight Reduction GHA/DEC/Ho Fields";
            _chkDispGHADecHo.UseVisualStyleBackColor = true;
            // 
            // chkClearFields
            // 
            _chkClearFields.AutoSize = true;
            _chkClearFields.Location = new Point(235, 22);
            _chkClearFields.Name = "_chkClearFields";
            _chkClearFields.Size = new Size(226, 17);
            _chkClearFields.TabIndex = 185;
            _chkClearFields.Text = "Clear Fields after New and Updated Sights";
            _chkClearFields.UseVisualStyleBackColor = true;
            // 
            // Label8
            // 
            Label8.BackColor = SystemColors.Window;
            Label8.Cursor = Cursors.Default;
            Label8.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label8.ForeColor = SystemColors.ControlText;
            Label8.Location = new Point(305, -53);
            Label8.Name = "Label8";
            Label8.RightToLeft = RightToLeft.No;
            Label8.Size = new Size(9, 17);
            Label8.TabIndex = 169;
            Label8.Text = "'";
            // 
            // lblSRGHA
            // 
            lblSRGHA.BackColor = Color.AntiqueWhite;
            lblSRGHA.Cursor = Cursors.Default;
            lblSRGHA.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblSRGHA.ForeColor = SystemColors.ControlText;
            lblSRGHA.Location = new Point(348, 22);
            lblSRGHA.Name = "lblSRGHA";
            lblSRGHA.RightToLeft = RightToLeft.No;
            lblSRGHA.Size = new Size(60, 19);
            lblSRGHA.TabIndex = 189;
            lblSRGHA.Text = "SR GHA";
            // 
            // txtSRGHA
            // 
            txtSRGHA.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtSRGHA.Location = new Point(409, 20);
            txtSRGHA.Name = "txtSRGHA";
            txtSRGHA.ReadOnly = true;
            txtSRGHA.Size = new Size(90, 22);
            txtSRGHA.TabIndex = 188;
            txtSRGHA.TextAlign = HorizontalAlignment.Center;
            // 
            // lblSRDec
            // 
            lblSRDec.BackColor = Color.AntiqueWhite;
            lblSRDec.Cursor = Cursors.Default;
            lblSRDec.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblSRDec.ForeColor = SystemColors.ControlText;
            lblSRDec.Location = new Point(502, 22);
            lblSRDec.Name = "lblSRDec";
            lblSRDec.RightToLeft = RightToLeft.No;
            lblSRDec.Size = new Size(55, 19);
            lblSRDec.TabIndex = 191;
            lblSRDec.Text = "SR Dec";
            // 
            // txtSRDec
            // 
            txtSRDec.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtSRDec.Location = new Point(559, 21);
            txtSRDec.Name = "txtSRDec";
            txtSRDec.ReadOnly = true;
            txtSRDec.Size = new Size(90, 22);
            txtSRDec.TabIndex = 190;
            txtSRDec.TextAlign = HorizontalAlignment.Center;
            // 
            // lblSRHo
            // 
            lblSRHo.BackColor = Color.AntiqueWhite;
            lblSRHo.Cursor = Cursors.Default;
            lblSRHo.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblSRHo.ForeColor = SystemColors.ControlText;
            lblSRHo.Location = new Point(348, 47);
            lblSRHo.Name = "lblSRHo";
            lblSRHo.RightToLeft = RightToLeft.No;
            lblSRHo.Size = new Size(60, 19);
            lblSRHo.TabIndex = 193;
            lblSRHo.Text = "SR Ho";
            // 
            // txtSRHo
            // 
            txtSRHo.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtSRHo.Location = new Point(409, 45);
            txtSRHo.Name = "txtSRHo";
            txtSRHo.ReadOnly = true;
            txtSRHo.Size = new Size(90, 22);
            txtSRHo.TabIndex = 192;
            txtSRHo.TextAlign = HorizontalAlignment.Center;
            // 
            // GroupBox1
            // 
            GroupBox1.BackColor = Color.AntiqueWhite;
            GroupBox1.Controls.Add(txtIntZn);
            GroupBox1.Controls.Add(lblSRHo);
            GroupBox1.Controls.Add(Label3);
            GroupBox1.Controls.Add(txtSRHo);
            GroupBox1.Controls.Add(txtSRFEP);
            GroupBox1.Controls.Add(lblSRDec);
            GroupBox1.Controls.Add(lblSRFEP);
            GroupBox1.Controls.Add(txtSRDec);
            GroupBox1.Controls.Add(lblSRGHA);
            GroupBox1.Controls.Add(txtSRGHA);
            GroupBox1.FlatStyle = FlatStyle.Flat;
            GroupBox1.Location = new Point(10, 175);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(682, 76);
            GroupBox1.TabIndex = 194;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Sight Reduction Form Results";
            // 
            // txtUserInfo
            // 
            txtUserInfo.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtUserInfo.HideSelection = false;
            txtUserInfo.Location = new Point(835, 87);
            txtUserInfo.Name = "txtUserInfo";
            txtUserInfo.Size = new Size(375, 22);
            txtUserInfo.TabIndex = 196;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label7.Location = new Point(771, 90);
            Label7.Name = "Label7";
            Label7.Size = new Size(57, 15);
            Label7.TabIndex = 195;
            Label7.Text = "User Info";
            Label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpFileButtons
            // 
            grpFileButtons.BackColor = SystemColors.ActiveCaption;
            grpFileButtons.Controls.Add(_btnSaveLogAsTxt);
            grpFileButtons.Controls.Add(_btnSLReport);
            grpFileButtons.Controls.Add(_btnPrintDG);
            grpFileButtons.Controls.Add(_btnOpenLog);
            grpFileButtons.Controls.Add(_btnSaveLog);
            grpFileButtons.Controls.Add(_btnNewLog);
            grpFileButtons.Location = new Point(874, 12);
            grpFileButtons.Name = "grpFileButtons";
            grpFileButtons.Size = new Size(454, 68);
            grpFileButtons.TabIndex = 167;
            grpFileButtons.TabStop = false;
            grpFileButtons.Text = "Sight File Actions";
            // 
            // btnSaveLogAsTxt
            // 
            _btnSaveLogAsTxt.BackColor = SystemColors.HotTrack;
            _btnSaveLogAsTxt.Font = new Font("Times New Roman", 9.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnSaveLogAsTxt.ForeColor = SystemColors.HighlightText;
            _btnSaveLogAsTxt.Location = new Point(260, 37);
            _btnSaveLogAsTxt.Name = "_btnSaveLogAsTxt";
            _btnSaveLogAsTxt.Size = new Size(185, 23);
            _btnSaveLogAsTxt.TabIndex = 154;
            _btnSaveLogAsTxt.Text = "Save Log As Formatted Txt File";
            _btnSaveLogAsTxt.UseVisualStyleBackColor = false;
            _btnSaveLogAsTxt.Visible = false;
            // 
            // PictureBox2
            // 
            PictureBox2.Image = My.Resources.Resources.ABC_white;
            PictureBox2.Location = new Point(10, 4);
            PictureBox2.Name = "PictureBox2";
            PictureBox2.Size = new Size(447, 68);
            PictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox2.TabIndex = 197;
            PictureBox2.TabStop = false;
            // 
            // cboLLoBy
            // 
            cboLLoBy.BackColor = SystemColors.Window;
            cboLLoBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLLoBy.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboLLoBy.FormattingEnabled = true;
            cboLLoBy.Items.AddRange(new object[] { "DR", "GPS", "KP" });
            cboLLoBy.Location = new Point(1100, 116);
            cboLLoBy.Name = "cboLLoBy";
            cboLLoBy.Size = new Size(70, 23);
            cboLLoBy.TabIndex = 199;
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label9.Location = new Point(1043, 120);
            Label9.Name = "Label9";
            Label9.Size = new Size(52, 15);
            Label9.TabIndex = 198;
            Label9.Text = "L/Lo by:";
            Label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SightLog
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1336, 771);
            Controls.Add(cboLLoBy);
            Controls.Add(Label9);
            Controls.Add(txtUserInfo);
            Controls.Add(Label7);
            Controls.Add(GroupBox1);
            Controls.Add(SLOptions);
            Controls.Add(cboApprxBrg);
            Controls.Add(txtIESec);
            Controls.Add(lblIEsec);
            Controls.Add(txtHsSec);
            Controls.Add(lblHsSec);
            Controls.Add(lblApprxBrg);
            Controls.Add(grpFileButtons);
            Controls.Add(cboHEUnit);
            Controls.Add(txtIEDeg);
            Controls.Add(Label6);
            Controls.Add(Label5);
            Controls.Add(lblBodyNm);
            Controls.Add(grpSightButtons);
            Controls.Add(cboZD);
            Controls.Add(lblZD);
            Controls.Add(lblUSPSSightLog);
            Controls.Add(_SEDataGrid);
            Controls.Add(txtHSDeg);
            Controls.Add(txtHSMin);
            Controls.Add(Label1);
            Controls.Add(Label2);
            Controls.Add(lvlHS);
            Controls.Add(lblLimb);
            Controls.Add(cbLimb);
            Controls.Add(txtRemarks);
            Controls.Add(_chkbxDST);
            Controls.Add(txtHorDist);
            Controls.Add(cbHorDistType);
            Controls.Add(lblDistance);
            Controls.Add(_cbHorizon);
            Controls.Add(lblHorType);
            Controls.Add(cboLo);
            Controls.Add(cboL);
            Controls.Add(txtLDeg);
            Controls.Add(txtLoMin);
            Controls.Add(txtLoDeg);
            Controls.Add(txtLMin);
            Controls.Add(_cboBody);
            Controls.Add(lblLoMin);
            Controls.Add(lblLoDeg);
            Controls.Add(lblDRLo);
            Controls.Add(lblLMin);
            Controls.Add(lblLDeg);
            Controls.Add(lblDRL);
            Controls.Add(txtHE);
            Controls.Add(lblHE);
            Controls.Add(cbIEType);
            Controls.Add(txtIE);
            Controls.Add(lblIE);
            Controls.Add(_btnExit);
            Controls.Add(cbWEType);
            Controls.Add(txtWE);
            Controls.Add(lblWE);
            Controls.Add(lblSightDate);
            Controls.Add(SightDateTime);
            Controls.Add(txtSightNum);
            Controls.Add(lblSightNum);
            Controls.Add(txtSquadron);
            Controls.Add(lblSquadron);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(PictureBox2);
            Name = "SightLog";
            Text = "USPS Sight Log";
            ((System.ComponentModel.ISupportInitialize)_SEDataGrid).EndInit();
            grpSightButtons.ResumeLayout(false);
            SLOptions.ResumeLayout(false);
            SLOptions.PerformLayout();
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            grpFileButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox2).EndInit();
            Load += new EventHandler(SightLog_Load);
            FormClosing += new FormClosingEventHandler(SightLog_FormClosing);
            ResumeLayout(false);
            PerformLayout();
        }

        internal Label lblName;
        internal TextBox txtName;
        internal TextBox txtSquadron;
        internal Label lblSquadron;
        internal TextBox txtSightNum;
        internal Label lblSightNum;
        internal DateTimePicker SightDateTime;
        internal Label lblSightDate;
        internal Label lblWE;
        internal TextBox txtWE;
        internal ComboBox cbWEType;
        private Button _btnExit;

        internal Button btnExit
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnExit;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnExit != null)
                {
                    _btnExit.Click -= btnExit_Click;
                }

                _btnExit = value;
                if (_btnExit != null)
                {
                    _btnExit.Click += btnExit_Click;
                }
            }
        }

        internal ComboBox cbIEType;
        internal TextBox txtIE;
        internal TextBox txtHE;
        internal Label lblHE;
        public ComboBox cboLo;
        public ComboBox cboL;
        public TextBox txtLDeg;
        public TextBox txtLoMin;
        public TextBox txtLoDeg;
        public TextBox txtLMin;
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

        public Label lblLoMin;
        public Label lblLoDeg;
        public Label lblDRLo;
        public Label lblLMin;
        public Label lblLDeg;
        public Label lblDRL;
        internal Label lblHorType;
        private ComboBox _cbHorizon;

        internal ComboBox cbHorizon
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cbHorizon;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cbHorizon != null)
                {
                    _cbHorizon.SelectedIndexChanged -= cbHorizon_SelectedIndexChanged;
                }

                _cbHorizon = value;
                if (_cbHorizon != null)
                {
                    _cbHorizon.SelectedIndexChanged += cbHorizon_SelectedIndexChanged;
                }
            }
        }

        internal ComboBox cbHorDistType;
        internal Label lblDistance;
        internal TextBox txtHorDist;
        private CheckBox _chkbxDST;

        internal CheckBox chkbxDST
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _chkbxDST;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_chkbxDST != null)
                {
                    _chkbxDST.CheckedChanged -= chkbxDST_CheckedChanged;
                }

                _chkbxDST = value;
                if (_chkbxDST != null)
                {
                    _chkbxDST.CheckedChanged += chkbxDST_CheckedChanged;
                }
            }
        }

        private Button _btnOpenLog;

        internal Button btnOpenLog
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnOpenLog;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnOpenLog != null)
                {
                    _btnOpenLog.Click -= btnOpenLog_Click;
                }

                _btnOpenLog = value;
                if (_btnOpenLog != null)
                {
                    _btnOpenLog.Click += btnOpenLog_Click;
                }
            }
        }

        private Button _btnSaveLog;

        internal Button btnSaveLog
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSaveLog;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSaveLog != null)
                {
                    _btnSaveLog.Click -= btnSaveLog_Click;
                }

                _btnSaveLog = value;
                if (_btnSaveLog != null)
                {
                    _btnSaveLog.Click += btnSaveLog_Click;
                }
            }
        }

        internal RichTextBox txtRemarks;
        private Button _btnAddNew;

        internal Button btnAddNew
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnAddNew;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnAddNew != null)
                {
                    _btnAddNew.Click -= btnAddNew_Click;
                }

                _btnAddNew = value;
                if (_btnAddNew != null)
                {
                    _btnAddNew.Click += btnAddNew_Click;
                }
            }
        }

        private Button _btnUpdateExisting;

        internal Button btnUpdateExisting
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnUpdateExisting;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnUpdateExisting != null)
                {
                    _btnUpdateExisting.Click -= btnUpdateExisting_Click;
                }

                _btnUpdateExisting = value;
                if (_btnUpdateExisting != null)
                {
                    _btnUpdateExisting.Click += btnUpdateExisting_Click;
                }
            }
        }

        private Button _btnDeleteSight;

        internal Button btnDeleteSight
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnDeleteSight;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnDeleteSight != null)
                {
                    _btnDeleteSight.Click -= btnDeleteSight_Click;
                }

                _btnDeleteSight = value;
                if (_btnDeleteSight != null)
                {
                    _btnDeleteSight.Click += btnDeleteSight_Click;
                }
            }
        }

        private Button _btnNewLog;

        internal Button btnNewLog
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnNewLog;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnNewLog != null)
                {
                    _btnNewLog.Click -= btnNewLog_Click;
                }

                _btnNewLog = value;
                if (_btnNewLog != null)
                {
                    _btnNewLog.Click += btnNewLog_Click;
                }
            }
        }

        private Button _btnSightReduce;

        internal Button btnSightReduce
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSightReduce;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSightReduce != null)
                {
                    _btnSightReduce.Click -= btnSightReduce_Click;
                }

                _btnSightReduce = value;
                if (_btnSightReduce != null)
                {
                    _btnSightReduce.Click += btnSightReduce_Click;
                }
            }
        }

        public ComboBox cbLimb;
        public Label lblLimb;
        public TextBox txtHSDeg;
        public TextBox txtHSMin;
        public Label Label1;
        public Label Label2;
        public Label lvlHS;
        internal TextBox txtIntZn;
        private DataGridView _SEDataGrid;

        internal DataGridView SEDataGrid
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SEDataGrid;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SEDataGrid != null)
                {
                    _SEDataGrid.SelectionChanged -= SEDataGrid_SelectionChanged;
                }

                _SEDataGrid = value;
                if (_SEDataGrid != null)
                {
                    _SEDataGrid.SelectionChanged += SEDataGrid_SelectionChanged;
                }
            }
        }

        internal Label lblUSPSSightLog;
        internal Label lblZD;
        public ComboBox cboZD;
        private Button _btnClearFields;

        internal Button btnClearFields
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnClearFields;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnClearFields != null)
                {
                    _btnClearFields.Click -= btnClearFields_Click;
                }

                _btnClearFields = value;
                if (_btnClearFields != null)
                {
                    _btnClearFields.Click += btnClearFields_Click;
                }
            }
        }

        public Label Label3;
        internal GroupBox grpSightButtons;
        private Button _btnPrintDG;

        internal Button btnPrintDG
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnPrintDG;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnPrintDG != null)
                {
                    _btnPrintDG.Click -= btnPrintDG_Click;
                }

                _btnPrintDG = value;
                if (_btnPrintDG != null)
                {
                    _btnPrintDG.Click += btnPrintDG_Click;
                }
            }
        }

        internal PrintDialog PrintDialog1;
        private PrintDocument _PrintDocument1;

        internal PrintDocument PrintDocument1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PrintDocument1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PrintDocument1 != null)
                {
                    _PrintDocument1.BeginPrint -= PrintDocument1_BeginPrint;
                    _PrintDocument1.PrintPage -= PrintDocument1_PrintPage;
                }

                _PrintDocument1 = value;
                if (_PrintDocument1 != null)
                {
                    _PrintDocument1.BeginPrint += PrintDocument1_BeginPrint;
                    _PrintDocument1.PrintPage += PrintDocument1_PrintPage;
                }
            }
        }

        public Label lblBodyNm;
        public Label Label4;
        public Label Label5;
        public TextBox txtIEDeg;
        public Label Label6;
        internal Label lblIE;
        public ComboBox cboHEUnit;
        public Label lblSRFEP;
        internal TextBox txtSRFEP;
        private Button _btnSLReport;

        internal Button btnSLReport
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSLReport;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSLReport != null)
                {
                    _btnSLReport.Click -= btnSLReport_Click;
                }

                _btnSLReport = value;
                if (_btnSLReport != null)
                {
                    _btnSLReport.Click += btnSLReport_Click;
                }
            }
        }

        public TextBox txtHsSec;
        public Label lblHsSec;
        public TextBox txtIESec;
        public Label lblIEsec;
        internal Label lblHSIEFmt;
        private ComboBox _cboHSIEFmt;

        internal ComboBox cboHSIEFmt
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboHSIEFmt;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboHSIEFmt != null)
                {
                    _cboHSIEFmt.SelectedIndexChanged -= cboHSIEFmt_SelectedIndexChanged;
                }

                _cboHSIEFmt = value;
                if (_cboHSIEFmt != null)
                {
                    _cboHSIEFmt.SelectedIndexChanged += cboHSIEFmt_SelectedIndexChanged;
                }
            }
        }

        internal ComboBox cboApprxBrg;
        internal Label lblApprxBrg;
        private CheckBox _CheckBoxShowAvg;

        internal CheckBox CheckBoxShowAvg
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CheckBoxShowAvg;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CheckBoxShowAvg != null)
                {
                    _CheckBoxShowAvg.CheckedChanged -= CheckBoxShowAvg_CheckedChanged;
                }

                _CheckBoxShowAvg = value;
                if (_CheckBoxShowAvg != null)
                {
                    _CheckBoxShowAvg.CheckedChanged += CheckBoxShowAvg_CheckedChanged;
                }
            }
        }

        private CheckBox _CheckBoxAutoReduce;

        internal CheckBox CheckBoxAutoReduce
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CheckBoxAutoReduce;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CheckBoxAutoReduce != null)
                {
                    _CheckBoxAutoReduce.CheckedChanged -= CheckBoxAutoReduce_CheckedChanged;
                }

                _CheckBoxAutoReduce = value;
                if (_CheckBoxAutoReduce != null)
                {
                    _CheckBoxAutoReduce.CheckedChanged += CheckBoxAutoReduce_CheckedChanged;
                }
            }
        }

        internal GroupBox SLOptions;
        public Label Label8;
        private CheckBox _chkClearFields;

        internal CheckBox chkClearFields
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _chkClearFields;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_chkClearFields != null)
                {
                    _chkClearFields.CheckedChanged -= ChkClearFields_CheckedChanged;
                }

                _chkClearFields = value;
                if (_chkClearFields != null)
                {
                    _chkClearFields.CheckedChanged += ChkClearFields_CheckedChanged;
                }
            }
        }

        private Button _btnAltSR;

        internal Button btnAltSR
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnAltSR;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnAltSR != null)
                {
                    _btnAltSR.Click -= BtnAltSR_Click;
                }

                _btnAltSR = value;
                if (_btnAltSR != null)
                {
                    _btnAltSR.Click += BtnAltSR_Click;
                }
            }
        }

        private CheckBox _chkDispGHADecHo;

        internal CheckBox chkDispGHADecHo
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _chkDispGHADecHo;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_chkDispGHADecHo != null)
                {
                    _chkDispGHADecHo.CheckedChanged -= ChkDispGHADecHo_CheckedChanged;
                }

                _chkDispGHADecHo = value;
                if (_chkDispGHADecHo != null)
                {
                    _chkDispGHADecHo.CheckedChanged += ChkDispGHADecHo_CheckedChanged;
                }
            }
        }

        public Label lblSRGHA;
        internal TextBox txtSRGHA;
        public Label lblSRDec;
        internal TextBox txtSRDec;
        public Label lblSRHo;
        internal TextBox txtSRHo;
        internal GroupBox GroupBox1;
        private Button _btnNoonSight;

        internal Button btnNoonSight
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnNoonSight;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnNoonSight != null)
                {
                    _btnNoonSight.Click -= btnNoonSight_Click;
                }

                _btnNoonSight = value;
                if (_btnNoonSight != null)
                {
                    _btnNoonSight.Click += btnNoonSight_Click;
                }
            }
        }

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

        internal TextBox txtUserInfo;
        internal Label Label7;
        internal GroupBox grpFileButtons;
        internal PictureBox PictureBox2;
        private Button _btnPlanSight;

        internal Button btnPlanSight
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnPlanSight;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnPlanSight != null)
                {
                    _btnPlanSight.Click -= btnPlanSight_Click;
                }

                _btnPlanSight = value;
                if (_btnPlanSight != null)
                {
                    _btnPlanSight.Click += btnPlanSight_Click;
                }
            }
        }

        internal ComboBox cboLLoBy;
        internal Label Label9;
        internal DataGridViewTextBoxColumn SightNum;
        internal DataGridViewTextBoxColumn SDateTime;
        internal DataGridViewTextBoxColumn BodyName;
        internal DataGridViewTextBoxColumn BodyLimb;
        internal DataGridViewTextBoxColumn SDST;
        internal DataGridViewTextBoxColumn SWE;
        internal DataGridViewTextBoxColumn SWEType;
        internal DataGridViewTextBoxColumn ZD;
        internal DataGridViewTextBoxColumn HS;
        internal DataGridViewTextBoxColumn HorType;
        internal DataGridViewTextBoxColumn HorDist;
        internal DataGridViewTextBoxColumn HorDistType;
        internal DataGridViewTextBoxColumn HE;
        internal DataGridViewTextBoxColumn IC;
        internal DataGridViewTextBoxColumn ICType;
        internal DataGridViewTextBoxColumn DRLat;
        internal DataGridViewTextBoxColumn DRLong;
        internal DataGridViewTextBoxColumn LLoBy;
        internal DataGridViewTextBoxColumn Intercept;
        internal DataGridViewTextBoxColumn Aziumuth;
        internal DataGridViewTextBoxColumn EP;
        internal DataGridViewTextBoxColumn PsnName;
        internal DataGridViewTextBoxColumn Squadron;
        internal DataGridViewTextBoxColumn WTDiff;
        internal DataGridViewTextBoxColumn HSDiff;
        internal DataGridViewTextBoxColumn HSWTRate;
        internal DataGridViewTextBoxColumn Remarks;
        internal DataGridViewTextBoxColumn SRGHA;
        internal DataGridViewTextBoxColumn SRDec;
        internal DataGridViewTextBoxColumn SRHo;
        internal DataGridViewTextBoxColumn UserInfo;
        private Button _btnSaveLogAsTxt;

        internal Button btnSaveLogAsTxt
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSaveLogAsTxt;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSaveLogAsTxt != null)
                {
                    _btnSaveLogAsTxt.Click -= btnSaveLogAsTxt_Click;
                }

                _btnSaveLogAsTxt = value;
                if (_btnSaveLogAsTxt != null)
                {
                    _btnSaveLogAsTxt.Click += btnSaveLogAsTxt_Click;
                }
            }
        }
    }
}