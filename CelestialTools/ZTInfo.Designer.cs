using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    [DesignerGenerated()]
    public partial class ZTInfo : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(ZTInfo));
            Label44 = new Label();
            _cboLocAZD = new ComboBox();
            _cboLocAZD.MouseEnter += new EventHandler(CbLocAZD_MouseEnter);
            _cboLocAZD.SelectedIndexChanged += new EventHandler(CboLocAZD_SelectedIndexChanged);
            Label43 = new Label();
            DTLocA = new DateTimePicker();
            cboLoA = new ComboBox();
            txtLoMinA = new TextBox();
            txtLoDegA = new TextBox();
            Label8 = new Label();
            lblDRLo = new Label();
            txtTZInfoA = new Label();
            txtLocAZTInfo = new TextBox();
            _ExitBtn = new Button();
            _ExitBtn.Click += new EventHandler(ExitBtn_Click);
            Label4 = new Label();
            _btnCalc = new Button();
            _btnCalc.Click += new EventHandler(BtnCalc_Click);
            Label6 = new Label();
            Label12 = new Label();
            DTLocAUTC = new DateTimePicker();
            _btnClearFields = new Button();
            _btnClearFields.Click += new EventHandler(BtnClearFields_Click);
            Label13 = new Label();
            txtInfo = new TextBox();
            txtSLDST = new TextBox();
            _btnReloadZT = new Button();
            _btnReloadZT.Click += new EventHandler(BtnReloadZT_Click);
            DGTZ = new DataGridView();
            Label18 = new Label();
            grpDestInfo = new GroupBox();
            Label2 = new Label();
            Label3 = new Label();
            Label16 = new Label();
            Label17 = new Label();
            Label15 = new Label();
            Label14 = new Label();
            Label11 = new Label();
            Label10 = new Label();
            Label7 = new Label();
            DTResult = new DateTimePicker();
            cboAddSub = new ComboBox();
            Label9 = new Label();
            DT1Minutes = new NumericUpDown();
            DT1Hours = new NumericUpDown();
            DT1Days = new NumericUpDown();
            txtLocBZTInfo = new TextBox();
            cboLoB = new ComboBox();
            txtLoMinB = new TextBox();
            txtLoDegB = new TextBox();
            Label1 = new Label();
            _cboLocBZD = new ComboBox();
            _cboLocBZD.MouseEnter += new EventHandler(CbLocBZone_MouseEnter);
            _cboLocBZD.SelectedIndexChanged += new EventHandler(CboLocBZD_SelectedIndexChanged);
            Label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)DGTZ).BeginInit();
            grpDestInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DT1Minutes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DT1Hours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DT1Days).BeginInit();
            SuspendLayout();
            // 
            // Label44
            // 
            Label44.BackColor = SystemColors.Window;
            Label44.BorderStyle = BorderStyle.Fixed3D;
            Label44.Cursor = Cursors.Default;
            Label44.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label44.ForeColor = SystemColors.ControlText;
            Label44.Location = new Point(40, 130);
            Label44.Name = "Label44";
            Label44.RightToLeft = RightToLeft.No;
            Label44.Size = new Size(80, 17);
            Label44.TabIndex = 204;
            Label44.Text = "Time Zone ";
            Label44.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboLocAZD
            // 
            _cboLocAZD.FormattingEnabled = true;
            _cboLocAZD.Location = new Point(133, 128);
            _cboLocAZD.Name = "_cboLocAZD";
            _cboLocAZD.Size = new Size(280, 21);
            _cboLocAZD.TabIndex = 203;
            // 
            // Label43
            // 
            Label43.BackColor = SystemColors.Window;
            Label43.BorderStyle = BorderStyle.Fixed3D;
            Label43.Cursor = Cursors.Default;
            Label43.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label43.ForeColor = SystemColors.ControlText;
            Label43.Location = new Point(40, 104);
            Label43.Name = "Label43";
            Label43.RightToLeft = RightToLeft.No;
            Label43.Size = new Size(80, 17);
            Label43.TabIndex = 201;
            Label43.Text = "Date Time:";
            Label43.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DTLocA
            // 
            DTLocA.CustomFormat = "ddd MM/dd/yyyy HH:mm";
            DTLocA.Format = DateTimePickerFormat.Custom;
            DTLocA.Location = new Point(133, 102);
            DTLocA.Name = "DTLocA";
            DTLocA.Size = new Size(200, 20);
            DTLocA.TabIndex = 200;
            // 
            // cboLoA
            // 
            cboLoA.BackColor = SystemColors.Window;
            cboLoA.Cursor = Cursors.Default;
            cboLoA.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoA.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboLoA.ForeColor = SystemColors.WindowText;
            cboLoA.Items.AddRange(new object[] { "W", "E" });
            cboLoA.Location = new Point(220, 75);
            cboLoA.Name = "cboLoA";
            cboLoA.RightToLeft = RightToLeft.No;
            cboLoA.Size = new Size(41, 22);
            cboLoA.TabIndex = 214;
            // 
            // txtLoMinA
            // 
            txtLoMinA.AcceptsReturn = true;
            txtLoMinA.BackColor = SystemColors.Window;
            txtLoMinA.Cursor = Cursors.IBeam;
            txtLoMinA.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtLoMinA.ForeColor = SystemColors.WindowText;
            txtLoMinA.Location = new Point(177, 76);
            txtLoMinA.MaxLength = 4;
            txtLoMinA.Name = "txtLoMinA";
            txtLoMinA.RightToLeft = RightToLeft.No;
            txtLoMinA.Size = new Size(33, 20);
            txtLoMinA.TabIndex = 213;
            // 
            // txtLoDegA
            // 
            txtLoDegA.AcceptsReturn = true;
            txtLoDegA.BackColor = SystemColors.Window;
            txtLoDegA.Cursor = Cursors.IBeam;
            txtLoDegA.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtLoDegA.ForeColor = SystemColors.WindowText;
            txtLoDegA.Location = new Point(135, 76);
            txtLoDegA.MaxLength = 3;
            txtLoDegA.Name = "txtLoDegA";
            txtLoDegA.RightToLeft = RightToLeft.No;
            txtLoDegA.Size = new Size(33, 20);
            txtLoDegA.TabIndex = 211;
            // 
            // Label8
            // 
            Label8.BackColor = SystemColors.Window;
            Label8.Cursor = Cursors.Default;
            Label8.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label8.ForeColor = SystemColors.ControlText;
            Label8.Location = new Point(167, 79);
            Label8.Name = "Label8";
            Label8.RightToLeft = RightToLeft.No;
            Label8.Size = new Size(9, 17);
            Label8.TabIndex = 212;
            Label8.Text = "°";
            // 
            // lblDRLo
            // 
            lblDRLo.BackColor = SystemColors.Window;
            lblDRLo.BorderStyle = BorderStyle.Fixed3D;
            lblDRLo.Cursor = Cursors.Default;
            lblDRLo.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblDRLo.ForeColor = SystemColors.ControlText;
            lblDRLo.Location = new Point(40, 76);
            lblDRLo.Name = "lblDRLo";
            lblDRLo.RightToLeft = RightToLeft.No;
            lblDRLo.Size = new Size(80, 20);
            lblDRLo.TabIndex = 210;
            lblDRLo.Text = "Longitude:";
            lblDRLo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTZInfoA
            // 
            txtTZInfoA.BackColor = SystemColors.Window;
            txtTZInfoA.BorderStyle = BorderStyle.Fixed3D;
            txtTZInfoA.Cursor = Cursors.Default;
            txtTZInfoA.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtTZInfoA.ForeColor = SystemColors.ControlText;
            txtTZInfoA.Location = new Point(40, 159);
            txtTZInfoA.Name = "txtTZInfoA";
            txtTZInfoA.RightToLeft = RightToLeft.No;
            txtTZInfoA.Size = new Size(80, 17);
            txtTZInfoA.TabIndex = 229;
            txtTZInfoA.Text = "TimeZone Info:";
            txtTZInfoA.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtLocAZTInfo
            // 
            txtLocAZTInfo.Location = new Point(133, 157);
            txtLocAZTInfo.Multiline = true;
            txtLocAZTInfo.Name = "txtLocAZTInfo";
            txtLocAZTInfo.Size = new Size(280, 60);
            txtLocAZTInfo.TabIndex = 230;
            // 
            // ExitBtn
            // 
            _ExitBtn.BackColor = Color.Red;
            _ExitBtn.Cursor = Cursors.Default;
            _ExitBtn.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _ExitBtn.ForeColor = SystemColors.ControlLightLight;
            _ExitBtn.Location = new Point(966, 6);
            _ExitBtn.Name = "_ExitBtn";
            _ExitBtn.RightToLeft = RightToLeft.No;
            _ExitBtn.Size = new Size(111, 30);
            _ExitBtn.TabIndex = 239;
            _ExitBtn.Text = "Exit";
            _ExitBtn.UseVisualStyleBackColor = false;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.BackColor = SystemColors.ButtonShadow;
            Label4.Font = new Font("Arial", 15.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.Location = new Point(6, 9);
            Label4.Name = "Label4";
            Label4.Size = new Size(389, 24);
            Label4.TabIndex = 241;
            Label4.Text = "Time Zone Planner and Calculation Tools";
            // 
            // btnCalc
            // 
            _btnCalc.BackColor = Color.Yellow;
            _btnCalc.Cursor = Cursors.Default;
            _btnCalc.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnCalc.ForeColor = SystemColors.ActiveCaptionText;
            _btnCalc.Location = new Point(37, 284);
            _btnCalc.Name = "_btnCalc";
            _btnCalc.RightToLeft = RightToLeft.No;
            _btnCalc.Size = new Size(112, 30);
            _btnCalc.TabIndex = 242;
            _btnCalc.Text = "Calc Dest Date/Time";
            _btnCalc.UseVisualStyleBackColor = false;
            // 
            // Label6
            // 
            Label6.BackColor = SystemColors.Window;
            Label6.Cursor = Cursors.Default;
            Label6.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label6.ForeColor = SystemColors.ControlText;
            Label6.Location = new Point(210, 78);
            Label6.Name = "Label6";
            Label6.RightToLeft = RightToLeft.No;
            Label6.Size = new Size(10, 17);
            Label6.TabIndex = 245;
            Label6.Text = "'";
            // 
            // Label12
            // 
            Label12.BackColor = SystemColors.Window;
            Label12.BorderStyle = BorderStyle.Fixed3D;
            Label12.Cursor = Cursors.Default;
            Label12.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label12.ForeColor = SystemColors.ControlText;
            Label12.Location = new Point(40, 224);
            Label12.Name = "Label12";
            Label12.RightToLeft = RightToLeft.No;
            Label12.Size = new Size(80, 17);
            Label12.TabIndex = 250;
            Label12.Text = "UTC";
            Label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DTLocAUTC
            // 
            DTLocAUTC.CustomFormat = "ddd MM/dd/yyyy HH:mm";
            DTLocAUTC.Enabled = false;
            DTLocAUTC.Format = DateTimePickerFormat.Custom;
            DTLocAUTC.Location = new Point(133, 222);
            DTLocAUTC.Name = "DTLocAUTC";
            DTLocAUTC.Size = new Size(200, 20);
            DTLocAUTC.TabIndex = 249;
            // 
            // btnClearFields
            // 
            _btnClearFields.BackColor = Color.Yellow;
            _btnClearFields.Cursor = Cursors.Default;
            _btnClearFields.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnClearFields.ForeColor = SystemColors.ActiveCaptionText;
            _btnClearFields.Location = new Point(165, 284);
            _btnClearFields.Name = "_btnClearFields";
            _btnClearFields.RightToLeft = RightToLeft.No;
            _btnClearFields.Size = new Size(112, 30);
            _btnClearFields.TabIndex = 251;
            _btnClearFields.Text = "Initialize All Fields";
            _btnClearFields.UseVisualStyleBackColor = false;
            // 
            // Label13
            // 
            Label13.AutoSize = true;
            Label13.BackColor = Color.Silver;
            Label13.BorderStyle = BorderStyle.Fixed3D;
            Label13.Font = new Font("Arial", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label13.Location = new Point(2, 50);
            Label13.Name = "Label13";
            Label13.Size = new Size(439, 24);
            Label13.TabIndex = 252;
            Label13.Text = "Origin Longitude, Date/Time, Time Zone, and UTC:";
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(69, 574);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(346, 195);
            txtInfo.TabIndex = 260;
            txtInfo.Text = resources.GetString("txtInfo.Text");
            // 
            // txtSLDST
            // 
            txtSLDST.BackColor = Color.Red;
            txtSLDST.ForeColor = Color.White;
            txtSLDST.Location = new Point(94, 574);
            txtSLDST.Multiline = true;
            txtSLDST.Name = "txtSLDST";
            txtSLDST.Size = new Size(290, 111);
            txtSLDST.TabIndex = 261;
            txtSLDST.Text = resources.GetString("txtSLDST.Text");
            txtSLDST.Visible = false;
            // 
            // btnReloadZT
            // 
            _btnReloadZT.BackColor = Color.Yellow;
            _btnReloadZT.Cursor = Cursors.Default;
            _btnReloadZT.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnReloadZT.ForeColor = SystemColors.ActiveCaptionText;
            _btnReloadZT.Location = new Point(1095, 6);
            _btnReloadZT.Name = "_btnReloadZT";
            _btnReloadZT.RightToLeft = RightToLeft.No;
            _btnReloadZT.Size = new Size(112, 30);
            _btnReloadZT.TabIndex = 240;
            _btnReloadZT.Text = "Reload Time Zones";
            _btnReloadZT.UseVisualStyleBackColor = false;
            // 
            // DGTZ
            // 
            DGTZ.AllowUserToAddRows = false;
            DGTZ.AllowUserToDeleteRows = false;
            DGTZ.AllowUserToResizeColumns = false;
            DGTZ.AllowUserToResizeRows = false;
            DGTZ.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            DGTZ.BorderStyle = BorderStyle.Fixed3D;
            DGTZ.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            DGTZ.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGTZ.Location = new Point(445, 48);
            DGTZ.MultiSelect = false;
            DGTZ.Name = "DGTZ";
            DGTZ.ReadOnly = true;
            DGTZ.Size = new Size(762, 721);
            DGTZ.TabIndex = 238;
            // 
            // Label18
            // 
            Label18.AutoSize = true;
            Label18.BackColor = SystemColors.ButtonShadow;
            Label18.Font = new Font("Arial", 15.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label18.Location = new Point(447, 9);
            Label18.Name = "Label18";
            Label18.Size = new Size(204, 24);
            Label18.TabIndex = 259;
            Label18.Text = "Table of Time Zones:";
            // 
            // grpDestInfo
            // 
            grpDestInfo.Controls.Add(Label2);
            grpDestInfo.Controls.Add(Label3);
            grpDestInfo.Controls.Add(Label16);
            grpDestInfo.Controls.Add(Label17);
            grpDestInfo.Controls.Add(_btnClearFields);
            grpDestInfo.Controls.Add(Label15);
            grpDestInfo.Controls.Add(Label14);
            grpDestInfo.Controls.Add(Label11);
            grpDestInfo.Controls.Add(Label10);
            grpDestInfo.Controls.Add(_btnCalc);
            grpDestInfo.Controls.Add(Label7);
            grpDestInfo.Controls.Add(DTResult);
            grpDestInfo.Controls.Add(cboAddSub);
            grpDestInfo.Controls.Add(Label9);
            grpDestInfo.Controls.Add(DT1Minutes);
            grpDestInfo.Controls.Add(DT1Hours);
            grpDestInfo.Controls.Add(DT1Days);
            grpDestInfo.Controls.Add(txtLocBZTInfo);
            grpDestInfo.Controls.Add(cboLoB);
            grpDestInfo.Controls.Add(txtLoMinB);
            grpDestInfo.Controls.Add(txtLoDegB);
            grpDestInfo.Controls.Add(Label1);
            grpDestInfo.Controls.Add(_cboLocBZD);
            grpDestInfo.Controls.Add(Label5);
            grpDestInfo.Location = new Point(3, 248);
            grpDestInfo.Name = "grpDestInfo";
            grpDestInfo.Size = new Size(439, 320);
            grpDestInfo.TabIndex = 262;
            grpDestInfo.TabStop = false;
            // 
            // Label2
            // 
            Label2.BackColor = SystemColors.Window;
            Label2.BorderStyle = BorderStyle.Fixed3D;
            Label2.Cursor = Cursors.Default;
            Label2.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = SystemColors.ControlText;
            Label2.Location = new Point(38, 177);
            Label2.Name = "Label2";
            Label2.RightToLeft = RightToLeft.No;
            Label2.Size = new Size(80, 17);
            Label2.TabIndex = 280;
            Label2.Text = "TimeZone Info:";
            Label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label3
            // 
            Label3.BackColor = SystemColors.Window;
            Label3.BorderStyle = BorderStyle.Fixed3D;
            Label3.Cursor = Cursors.Default;
            Label3.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.ForeColor = SystemColors.ControlText;
            Label3.Location = new Point(38, 115);
            Label3.Name = "Label3";
            Label3.RightToLeft = RightToLeft.No;
            Label3.Size = new Size(80, 20);
            Label3.TabIndex = 279;
            Label3.Text = "Longitude:";
            Label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label16
            // 
            Label16.BackColor = SystemColors.Window;
            Label16.BorderStyle = BorderStyle.Fixed3D;
            Label16.Cursor = Cursors.Default;
            Label16.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label16.ForeColor = SystemColors.ControlText;
            Label16.Location = new Point(38, 147);
            Label16.Name = "Label16";
            Label16.RightToLeft = RightToLeft.No;
            Label16.Size = new Size(80, 17);
            Label16.TabIndex = 278;
            Label16.Text = "Time Zone ";
            Label16.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label17
            // 
            Label17.BackColor = SystemColors.Window;
            Label17.BorderStyle = BorderStyle.Fixed3D;
            Label17.Cursor = Cursors.Default;
            Label17.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label17.ForeColor = SystemColors.ControlText;
            Label17.Location = new Point(38, 252);
            Label17.Name = "Label17";
            Label17.RightToLeft = RightToLeft.No;
            Label17.Size = new Size(85, 19);
            Label17.TabIndex = 277;
            Label17.Text = "Dest Date Time:";
            Label17.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label15
            // 
            Label15.AutoSize = true;
            Label15.BackColor = Color.Silver;
            Label15.BorderStyle = BorderStyle.Fixed3D;
            Label15.Font = new Font("Arial", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label15.Location = new Point(1, 15);
            Label15.Name = "Label15";
            Label15.Size = new Size(437, 24);
            Label15.TabIndex = 276;
            Label15.Text = "Interval of Days/Hrs/Mins to Add/Subtract to Origin ";
            // 
            // Label14
            // 
            Label14.AutoSize = true;
            Label14.BackColor = Color.Silver;
            Label14.BorderStyle = BorderStyle.Fixed3D;
            Label14.Font = new Font("Arial", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label14.Location = new Point(6, 86);
            Label14.Name = "Label14";
            Label14.Size = new Size(429, 24);
            Label14.TabIndex = 275;
            Label14.Text = "Destination Longitude, Time Zone, and Date/Time";
            // 
            // Label11
            // 
            Label11.BackColor = SystemColors.Window;
            Label11.Cursor = Cursors.Default;
            Label11.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label11.ForeColor = SystemColors.ControlText;
            Label11.Location = new Point(306, 50);
            Label11.Name = "Label11";
            Label11.RightToLeft = RightToLeft.No;
            Label11.Size = new Size(25, 17);
            Label11.TabIndex = 274;
            Label11.Text = "Min";
            // 
            // Label10
            // 
            Label10.BackColor = SystemColors.Window;
            Label10.Cursor = Cursors.Default;
            Label10.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label10.ForeColor = SystemColors.ControlText;
            Label10.Location = new Point(239, 50);
            Label10.Name = "Label10";
            Label10.RightToLeft = RightToLeft.No;
            Label10.Size = new Size(25, 17);
            Label10.TabIndex = 273;
            Label10.Text = "Hrs";
            // 
            // Label7
            // 
            Label7.BackColor = SystemColors.Window;
            Label7.Cursor = Cursors.Default;
            Label7.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label7.ForeColor = SystemColors.ControlText;
            Label7.Location = new Point(168, 50);
            Label7.Name = "Label7";
            Label7.RightToLeft = RightToLeft.No;
            Label7.Size = new Size(32, 17);
            Label7.TabIndex = 272;
            Label7.Text = "Days";
            // 
            // DTResult
            // 
            DTResult.CustomFormat = "ddd MM/dd/yyyy HH:mm";
            DTResult.Format = DateTimePickerFormat.Custom;
            DTResult.Location = new Point(129, 251);
            DTResult.Name = "DTResult";
            DTResult.Size = new Size(200, 20);
            DTResult.TabIndex = 270;
            // 
            // cboAddSub
            // 
            cboAddSub.FormattingEnabled = true;
            cboAddSub.Items.AddRange(new object[] { "+", "-" });
            cboAddSub.Location = new Point(337, 48);
            cboAddSub.Name = "cboAddSub";
            cboAddSub.Size = new Size(68, 21);
            cboAddSub.TabIndex = 269;
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.BackColor = SystemColors.Window;
            Label9.BorderStyle = BorderStyle.Fixed3D;
            Label9.Location = new Point(38, 53);
            Label9.Name = "Label9";
            Label9.Size = new Size(47, 15);
            Label9.TabIndex = 268;
            Label9.Text = "Interval ";
            Label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DT1Minutes
            // 
            DT1Minutes.Location = new Point(268, 48);
            DT1Minutes.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            DT1Minutes.Name = "DT1Minutes";
            DT1Minutes.Size = new Size(35, 20);
            DT1Minutes.TabIndex = 267;
            // 
            // DT1Hours
            // 
            DT1Hours.Location = new Point(200, 48);
            DT1Hours.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            DT1Hours.Name = "DT1Hours";
            DT1Hours.Size = new Size(35, 20);
            DT1Hours.TabIndex = 266;
            // 
            // DT1Days
            // 
            DT1Days.Location = new Point(130, 49);
            DT1Days.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            DT1Days.Name = "DT1Days";
            DT1Days.Size = new Size(35, 20);
            DT1Days.TabIndex = 265;
            // 
            // txtLocBZTInfo
            // 
            txtLocBZTInfo.Location = new Point(130, 175);
            txtLocBZTInfo.Multiline = true;
            txtLocBZTInfo.Name = "txtLocBZTInfo";
            txtLocBZTInfo.Size = new Size(280, 60);
            txtLocBZTInfo.TabIndex = 264;
            // 
            // cboLoB
            // 
            cboLoB.BackColor = SystemColors.Window;
            cboLoB.Cursor = Cursors.Default;
            cboLoB.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoB.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboLoB.ForeColor = SystemColors.WindowText;
            cboLoB.Items.AddRange(new object[] { "W", "E" });
            cboLoB.Location = new Point(213, 115);
            cboLoB.Name = "cboLoB";
            cboLoB.RightToLeft = RightToLeft.No;
            cboLoB.Size = new Size(41, 22);
            cboLoB.TabIndex = 263;
            // 
            // txtLoMinB
            // 
            txtLoMinB.AcceptsReturn = true;
            txtLoMinB.BackColor = SystemColors.Window;
            txtLoMinB.Cursor = Cursors.IBeam;
            txtLoMinB.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtLoMinB.ForeColor = SystemColors.WindowText;
            txtLoMinB.Location = new Point(170, 116);
            txtLoMinB.MaxLength = 4;
            txtLoMinB.Name = "txtLoMinB";
            txtLoMinB.RightToLeft = RightToLeft.No;
            txtLoMinB.Size = new Size(33, 20);
            txtLoMinB.TabIndex = 262;
            // 
            // txtLoDegB
            // 
            txtLoDegB.AcceptsReturn = true;
            txtLoDegB.BackColor = SystemColors.Window;
            txtLoDegB.Cursor = Cursors.IBeam;
            txtLoDegB.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtLoDegB.ForeColor = SystemColors.WindowText;
            txtLoDegB.Location = new Point(130, 116);
            txtLoDegB.MaxLength = 3;
            txtLoDegB.Name = "txtLoDegB";
            txtLoDegB.RightToLeft = RightToLeft.No;
            txtLoDegB.Size = new Size(33, 20);
            txtLoDegB.TabIndex = 260;
            // 
            // Label1
            // 
            Label1.BackColor = SystemColors.Window;
            Label1.Cursor = Cursors.Default;
            Label1.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = SystemColors.ControlText;
            Label1.Location = new Point(162, 119);
            Label1.Name = "Label1";
            Label1.RightToLeft = RightToLeft.No;
            Label1.Size = new Size(9, 17);
            Label1.TabIndex = 261;
            Label1.Text = "°";
            // 
            // cboLocBZD
            // 
            _cboLocBZD.FormattingEnabled = true;
            _cboLocBZD.Location = new Point(129, 143);
            _cboLocBZD.Name = "_cboLocBZD";
            _cboLocBZD.Size = new Size(282, 21);
            _cboLocBZD.TabIndex = 259;
            // 
            // Label5
            // 
            Label5.BackColor = SystemColors.Window;
            Label5.Cursor = Cursors.Default;
            Label5.Font = new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label5.ForeColor = SystemColors.ControlText;
            Label5.Location = new Point(203, 118);
            Label5.Name = "Label5";
            Label5.RightToLeft = RightToLeft.No;
            Label5.Size = new Size(9, 17);
            Label5.TabIndex = 271;
            Label5.Text = "'";
            // 
            // ZTInfo
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1222, 781);
            Controls.Add(txtSLDST);
            Controls.Add(txtInfo);
            Controls.Add(Label18);
            Controls.Add(Label13);
            Controls.Add(Label12);
            Controls.Add(DTLocAUTC);
            Controls.Add(Label6);
            Controls.Add(Label4);
            Controls.Add(_btnReloadZT);
            Controls.Add(_ExitBtn);
            Controls.Add(DGTZ);
            Controls.Add(txtLocAZTInfo);
            Controls.Add(txtTZInfoA);
            Controls.Add(cboLoA);
            Controls.Add(txtLoMinA);
            Controls.Add(txtLoDegA);
            Controls.Add(Label8);
            Controls.Add(lblDRLo);
            Controls.Add(Label44);
            Controls.Add(_cboLocAZD);
            Controls.Add(Label43);
            Controls.Add(DTLocA);
            Controls.Add(grpDestInfo);
            Name = "ZTInfo";
            Text = "Time Zone Planner ";
            ((System.ComponentModel.ISupportInitialize)DGTZ).EndInit();
            grpDestInfo.ResumeLayout(false);
            grpDestInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DT1Minutes).EndInit();
            ((System.ComponentModel.ISupportInitialize)DT1Hours).EndInit();
            ((System.ComponentModel.ISupportInitialize)DT1Days).EndInit();
            Load += new EventHandler(ZTInfo_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        public Label Label44;
        private ComboBox _cboLocAZD;

        internal ComboBox cboLocAZD
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboLocAZD;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboLocAZD != null)
                {
                    _cboLocAZD.MouseEnter -= CbLocAZD_MouseEnter;
                    _cboLocAZD.SelectedIndexChanged -= CboLocAZD_SelectedIndexChanged;
                }

                _cboLocAZD = value;
                if (_cboLocAZD != null)
                {
                    _cboLocAZD.MouseEnter += CbLocAZD_MouseEnter;
                    _cboLocAZD.SelectedIndexChanged += CboLocAZD_SelectedIndexChanged;
                }
            }
        }

        public Label Label43;
        internal DateTimePicker DTLocA;
        public ComboBox cboLoA;
        public TextBox txtLoMinA;
        public TextBox txtLoDegA;
        public Label Label8;
        public Label lblDRLo;
        public Label txtTZInfoA;
        internal TextBox txtLocAZTInfo;
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

        internal Label Label4;
        private Button _btnCalc;

        public Button btnCalc
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnCalc;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnCalc != null)
                {
                    _btnCalc.Click -= BtnCalc_Click;
                }

                _btnCalc = value;
                if (_btnCalc != null)
                {
                    _btnCalc.Click += BtnCalc_Click;
                }
            }
        }

        public Label Label6;
        public Label Label12;
        internal DateTimePicker DTLocAUTC;
        private Button _btnClearFields;

        public Button btnClearFields
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
                    _btnClearFields.Click -= BtnClearFields_Click;
                }

                _btnClearFields = value;
                if (_btnClearFields != null)
                {
                    _btnClearFields.Click += BtnClearFields_Click;
                }
            }
        }

        internal Label Label13;
        internal TextBox txtInfo;
        internal TextBox txtSLDST;
        private Button _btnReloadZT;

        public Button btnReloadZT
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnReloadZT;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnReloadZT != null)
                {
                    _btnReloadZT.Click -= BtnReloadZT_Click;
                }

                _btnReloadZT = value;
                if (_btnReloadZT != null)
                {
                    _btnReloadZT.Click += BtnReloadZT_Click;
                }
            }
        }

        internal DataGridView DGTZ;
        internal Label Label18;
        internal GroupBox grpDestInfo;
        public Label Label2;
        public Label Label3;
        public Label Label16;
        public Label Label17;
        internal Label Label15;
        internal Label Label14;
        public Label Label11;
        public Label Label10;
        public Label Label7;
        internal DateTimePicker DTResult;
        internal ComboBox cboAddSub;
        internal Label Label9;
        internal NumericUpDown DT1Minutes;
        internal NumericUpDown DT1Hours;
        internal NumericUpDown DT1Days;
        internal TextBox txtLocBZTInfo;
        public ComboBox cboLoB;
        public TextBox txtLoMinB;
        public TextBox txtLoDegB;
        public Label Label1;
        private ComboBox _cboLocBZD;

        internal ComboBox cboLocBZD
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboLocBZD;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboLocBZD != null)
                {
                    _cboLocBZD.MouseEnter -= CbLocBZone_MouseEnter;
                    _cboLocBZD.SelectedIndexChanged -= CboLocBZD_SelectedIndexChanged;
                }

                _cboLocBZD = value;
                if (_cboLocBZD != null)
                {
                    _cboLocBZD.MouseEnter += CbLocBZone_MouseEnter;
                    _cboLocBZD.SelectedIndexChanged += CboLocBZD_SelectedIndexChanged;
                }
            }
        }

        public Label Label5;
    }
}