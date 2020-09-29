using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    [DesignerGenerated()]
    public partial class DeckLogUpdate : Form
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
            components = new System.ComponentModel.Container();
            var DataGridViewCellStyle8 = new DataGridViewCellStyle();
            var DataGridViewCellStyle9 = new DataGridViewCellStyle();
            var DataGridViewCellStyle10 = new DataGridViewCellStyle();
            var DataGridViewCellStyle11 = new DataGridViewCellStyle();
            var DataGridViewCellStyle12 = new DataGridViewCellStyle();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(DeckLogUpdate));
            var DataGridViewCellStyle13 = new DataGridViewCellStyle();
            var DataGridViewCellStyle14 = new DataGridViewCellStyle();
            _DataGridView1 = new DataGridView();
            _DataGridView1.SelectionChanged += new EventHandler(DataGridView1_SelectionChanged);
            _btnExit = new Button();
            _btnExit.Click += new EventHandler(btnExit_Click);
            _btnExitNoSave = new Button();
            _btnExitNoSave.Click += new EventHandler(btnExitNoSave_Click);
            CommonNameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            CommonNameDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            WebLocationDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            _btnOpenCSV = new Button();
            _btnOpenCSV.Click += new EventHandler(btnOpenCSV_Click);
            lblOpenFN = new Label();
            txtOpenFN = new TextBox();
            _btnSaveFile = new Button();
            _btnSaveFile.Click += new EventHandler(btnSaveFile_Click);
            _btnInfoForm = new Button();
            _btnInfoForm.Click += new EventHandler(btnInfoForm_Click);
            GroupBox1 = new GroupBox();
            chkUseForEval = new CheckBox();
            grpLogNotes = new GroupBox();
            txtRemarks = new TextBox();
            grpWeather = new GroupBox();
            lblWind = new Label();
            txtSeas = new TextBox();
            txtWeather = new TextBox();
            lbWaves = new Label();
            txtWind = new TextBox();
            cboWindDir = new ComboBox();
            lblWind2 = new Label();
            grpAdvInfo = new GroupBox();
            _cboAdvType = new ComboBox();
            _cboAdvType.SelectedIndexChanged += new EventHandler(cboAdvType_SelectedIndexChanged);
            cboAdvMin = new NumericUpDown();
            lblAdvHrMin = new Label();
            cboAdvHrs = new NumericUpDown();
            cboAdvNm = new NumericUpDown();
            lblAdvNm = new Label();
            grpLogEntryInfo = new GroupBox();
            lblKnotLog = new Label();
            txtKnotLog = new TextBox();
            Label19 = new Label();
            txtZD = new TextBox();
            lblZoneDT = new Label();
            _DTDateZoneTime = new DateTimePicker();
            _DTDateZoneTime.ValueChanged += new EventHandler(DTDateZoneTime_ValueChanged);
            lblCompass = new Label();
            _txtCompass = new TextBox();
            _txtCompass.TextChanged += new EventHandler(txtCompass_TextChanged);
            _txtCompass.KeyPress += new KeyPressEventHandler(txtCompass_KeyPress);
            Label1 = new Label();
            Label6 = new Label();
            lblVariation = new Label();
            txtVar = new TextBox();
            cboVar = new ComboBox();
            Label18 = new Label();
            lblDev = new Label();
            txtDev = new TextBox();
            cboDev = new ComboBox();
            Label2 = new Label();
            Label3 = new Label();
            lblDRL = new Label();
            lblLDeg = new Label();
            lblLMin = new Label();
            lblDRLo = new Label();
            lblLoDeg = new Label();
            lblLoMin = new Label();
            txtLMin = new TextBox();
            txtLoDeg = new TextBox();
            txtLoMin = new TextBox();
            txtLDeg = new TextBox();
            txtSpeed = new TextBox();
            cboL = new ComboBox();
            lblSpeed = new Label();
            cboLo = new ComboBox();
            Label4 = new Label();
            lblCTrue = new Label();
            _txtCTrue = new TextBox();
            _txtCTrue.TextChanged += new EventHandler(txtCTrue_TextChanged);
            _txtCTrue.KeyPress += new KeyPressEventHandler(txtCTrue_KeyPress);
            chkImportGCR = new CheckBox();
            _chkPlanGCR = new CheckBox();
            _chkPlanGCR.CheckedChanged += new EventHandler(chkPlanGCR_CheckedChanged);
            _cboDisplayRows = new ComboBox();
            _cboDisplayRows.SelectedIndexChanged += new EventHandler(cboDisplayRows_SelectedIndexChanged);
            Label14 = new Label();
            _btnUseZTInfoForm = new Button();
            _btnUseZTInfoForm.Click += new EventHandler(btnUseZTInfoForm_Click);
            _btnUseTVMDC = new Button();
            _btnUseTVMDC.Click += new EventHandler(btnUseTVMDC_Click);
            _linkLblNOAAVar = new LinkLabel();
            _linkLblNOAAVar.LinkClicked += new LinkLabelLinkClickedEventHandler(linkLblNOAAVar_LinkClicked);
            _chkHideFirst4Col = new CheckBox();
            _chkHideFirst4Col.CheckedChanged += new EventHandler(chkHideFirst4Col_CheckedChanged);
            grpbxPlan = new GroupBox();
            Label20 = new Label();
            txtDestZD = new TextBox();
            txtEstArrival = new TextBox();
            lblEstArrival = new Label();
            txtDestElapsed = new TextBox();
            Label17 = new Label();
            txtDestDist = new TextBox();
            Label16 = new Label();
            txtDestTrue = new TextBox();
            Label15 = new Label();
            cboDestLo = new ComboBox();
            cboDestL = new ComboBox();
            txtDestLDeg = new TextBox();
            txtDestLoMin = new TextBox();
            txtDestLoDeg = new TextBox();
            txtDestLMin = new TextBox();
            Label8 = new Label();
            Label9 = new Label();
            Label10 = new Label();
            Label11 = new Label();
            Label12 = new Label();
            Label13 = new Label();
            _cboLocType = new ComboBox();
            _cboLocType.SelectedIndexChanged += new EventHandler(cboLocType_SelectedIndexChanged);
            _chkDev = new CheckBox();
            _chkDev.CheckedChanged += new EventHandler(chkDev_CheckedChanged);
            Label5 = new Label();
            _btnClearFields = new Button();
            _btnClearFields.Click += new EventHandler(btnClearFields_Click);
            _btnAddNew = new Button();
            _btnAddNew.Click += new EventHandler(btnAddNew_Click);
            _btnUpdateExisting = new Button();
            _btnUpdateExisting.Click += new EventHandler(btnUpdateExisting_Click);
            _btnDeleteSight = new Button();
            _btnDeleteSight.Click += new EventHandler(btnDeleteSight_Click);
            txtTo = new TextBox();
            lblTo = new Label();
            txtFrom = new TextBox();
            lblFrom = new Label();
            txtNavigator = new TextBox();
            lblNavigator = new Label();
            txtVessel = new TextBox();
            lblVessel = new Label();
            Label7 = new Label();
            VesselDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            NavigatorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            FromDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ToDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ZoneDateTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            CompassDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            VarDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            DevDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            TrueDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            SpeedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            LocLatLongDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            LocTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            WeatherDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            RemarksDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ActualLoc = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            VesselDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            NavigatorDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            FromDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ToDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            LocTypeDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ZoneDateTimeDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            CompassDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            VarDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            DevDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            TrueDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            SpeedDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            LocLatLongDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            WeatherDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            RemarksDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            TimetoDest = new DataGridViewTextBoxColumn();
            _btnStartFresh = new Button();
            _btnStartFresh.Click += new EventHandler(btnStartFresh_Click);
            PictureBox1 = new PictureBox();
            _btnEvalDG = new Button();
            _btnEvalDG.Click += new EventHandler(btnEvalDG_Click);
            _btnExportGPX = new Button();
            _btnExportGPX.Click += new EventHandler(btnExportGPX_Click);
            ToolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)_DataGridView1).BeginInit();
            GroupBox1.SuspendLayout();
            grpLogNotes.SuspendLayout();
            grpWeather.SuspendLayout();
            grpAdvInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cboAdvMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cboAdvHrs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cboAdvNm).BeginInit();
            grpLogEntryInfo.SuspendLayout();
            grpbxPlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // DataGridView1
            // 
            _DataGridView1.AllowUserToAddRows = false;
            _DataGridView1.AllowUserToDeleteRows = false;
            _DataGridView1.AllowUserToResizeColumns = false;
            _DataGridView1.AllowUserToResizeRows = false;
            DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle8.BackColor = Color.LightGray;
            DataGridViewCellStyle8.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle8;
            _DataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            _DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            _DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            _DataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            _DataGridView1.BorderStyle = BorderStyle.Fixed3D;
            _DataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle9.BackColor = Color.Yellow;
            DataGridViewCellStyle9.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle9.ForeColor = SystemColors.InfoText;
            DataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle9.SelectionForeColor = Color.Gold;
            DataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            _DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9;
            _DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle10.BackColor = SystemColors.Window;
            DataGridViewCellStyle10.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            DataGridViewCellStyle10.NullValue = " ";
            DataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            _DataGridView1.DefaultCellStyle = DataGridViewCellStyle10;
            _DataGridView1.Location = new Point(9, 304);
            _DataGridView1.MultiSelect = false;
            _DataGridView1.Name = "_DataGridView1";
            _DataGridView1.ReadOnly = true;
            DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle11.BackColor = Color.Yellow;
            DataGridViewCellStyle11.Font = new Font("Arial Rounded MT Bold", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            _DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle11;
            DataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle12.BackColor = Color.Yellow;
            DataGridViewCellStyle12.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle12.ForeColor = SystemColors.InfoText;
            DataGridViewCellStyle12.SelectionBackColor = Color.Red;
            DataGridViewCellStyle12.SelectionForeColor = Color.White;
            _DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle12;
            _DataGridView1.RowTemplate.DefaultCellStyle.BackColor = Color.Yellow;
            _DataGridView1.RowTemplate.DefaultCellStyle.ForeColor = SystemColors.InfoText;
            _DataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Red;
            _DataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            _DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _DataGridView1.Size = new Size(1403, 566);
            _DataGridView1.TabIndex = 0;
            // 
            // btnExit
            // 
            _btnExit.BackColor = Color.Red;
            _btnExit.ForeColor = Color.White;
            _btnExit.Location = new Point(1292, 8);
            _btnExit.Name = "_btnExit";
            _btnExit.Size = new Size(118, 23);
            _btnExit.TabIndex = 1;
            _btnExit.Text = "Exit and Save Input";
            _btnExit.UseVisualStyleBackColor = false;
            // 
            // btnExitNoSave
            // 
            _btnExitNoSave.BackColor = Color.Red;
            _btnExitNoSave.ForeColor = Color.White;
            _btnExitNoSave.Location = new Point(1292, 33);
            _btnExitNoSave.Name = "_btnExitNoSave";
            _btnExitNoSave.Size = new Size(118, 23);
            _btnExitNoSave.TabIndex = 2;
            _btnExitNoSave.Text = "Exit with No Save";
            _btnExitNoSave.UseVisualStyleBackColor = false;
            // 
            // CommonNameDataGridViewTextBoxColumn1
            // 
            CommonNameDataGridViewTextBoxColumn1.DataPropertyName = "Common Name";
            CommonNameDataGridViewTextBoxColumn1.HeaderText = "Common Name";
            CommonNameDataGridViewTextBoxColumn1.Name = "CommonNameDataGridViewTextBoxColumn1";
            CommonNameDataGridViewTextBoxColumn1.Width = 140;
            // 
            // CommonNameDataGridViewTextBoxColumn2
            // 
            CommonNameDataGridViewTextBoxColumn2.DataPropertyName = "Common Name";
            CommonNameDataGridViewTextBoxColumn2.HeaderText = "Common Name";
            CommonNameDataGridViewTextBoxColumn2.Name = "CommonNameDataGridViewTextBoxColumn2";
            CommonNameDataGridViewTextBoxColumn2.Width = 140;
            // 
            // WebLocationDataGridViewTextBoxColumn1
            // 
            WebLocationDataGridViewTextBoxColumn1.DataPropertyName = "Web Location";
            WebLocationDataGridViewTextBoxColumn1.HeaderText = "Web Location";
            WebLocationDataGridViewTextBoxColumn1.Name = "WebLocationDataGridViewTextBoxColumn1";
            WebLocationDataGridViewTextBoxColumn1.Width = 130;
            // 
            // btnOpenCSV
            // 
            _btnOpenCSV.BackColor = Color.Yellow;
            _btnOpenCSV.ForeColor = Color.Black;
            _btnOpenCSV.Location = new Point(1046, 8);
            _btnOpenCSV.Name = "_btnOpenCSV";
            _btnOpenCSV.Size = new Size(118, 23);
            _btnOpenCSV.TabIndex = 3;
            _btnOpenCSV.Text = "Open a Deck Log";
            _btnOpenCSV.UseVisualStyleBackColor = false;
            // 
            // lblOpenFN
            // 
            lblOpenFN.AutoSize = true;
            lblOpenFN.Location = new Point(332, 63);
            lblOpenFN.Name = "lblOpenFN";
            lblOpenFN.Size = new Size(58, 13);
            lblOpenFN.TabIndex = 4;
            lblOpenFN.Text = "Open File: ";
            lblOpenFN.Visible = false;
            // 
            // txtOpenFN
            // 
            txtOpenFN.Location = new Point(391, 59);
            txtOpenFN.Name = "txtOpenFN";
            txtOpenFN.ReadOnly = true;
            txtOpenFN.Size = new Size(635, 20);
            txtOpenFN.TabIndex = 5;
            txtOpenFN.TextAlign = HorizontalAlignment.Center;
            txtOpenFN.Visible = false;
            // 
            // btnSaveFile
            // 
            _btnSaveFile.BackColor = Color.Blue;
            _btnSaveFile.ForeColor = Color.White;
            _btnSaveFile.Location = new Point(1169, 32);
            _btnSaveFile.Name = "_btnSaveFile";
            _btnSaveFile.Size = new Size(118, 23);
            _btnSaveFile.TabIndex = 6;
            _btnSaveFile.Text = "Save Current File";
            _btnSaveFile.UseVisualStyleBackColor = false;
            // 
            // btnInfoForm
            // 
            _btnInfoForm.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnInfoForm.ForeColor = Color.Black;
            _btnInfoForm.Location = new Point(1293, 58);
            _btnInfoForm.Name = "_btnInfoForm";
            _btnInfoForm.Size = new Size(118, 23);
            _btnInfoForm.TabIndex = 7;
            _btnInfoForm.Text = "Display Help Info";
            _btnInfoForm.UseVisualStyleBackColor = false;
            // 
            // GroupBox1
            // 
            GroupBox1.BackColor = Color.Silver;
            GroupBox1.Controls.Add(chkUseForEval);
            GroupBox1.Controls.Add(grpLogNotes);
            GroupBox1.Controls.Add(grpWeather);
            GroupBox1.Controls.Add(grpAdvInfo);
            GroupBox1.Controls.Add(grpLogEntryInfo);
            GroupBox1.Controls.Add(chkImportGCR);
            GroupBox1.Controls.Add(_chkPlanGCR);
            GroupBox1.Controls.Add(_cboDisplayRows);
            GroupBox1.Controls.Add(Label14);
            GroupBox1.Controls.Add(_btnUseZTInfoForm);
            GroupBox1.Controls.Add(_btnUseTVMDC);
            GroupBox1.Controls.Add(_linkLblNOAAVar);
            GroupBox1.Controls.Add(_chkHideFirst4Col);
            GroupBox1.Controls.Add(grpbxPlan);
            GroupBox1.Controls.Add(_cboLocType);
            GroupBox1.Controls.Add(_chkDev);
            GroupBox1.Controls.Add(Label5);
            GroupBox1.Controls.Add(_btnClearFields);
            GroupBox1.Controls.Add(_btnAddNew);
            GroupBox1.Controls.Add(_btnUpdateExisting);
            GroupBox1.Controls.Add(_btnDeleteSight);
            GroupBox1.Controls.Add(txtTo);
            GroupBox1.Controls.Add(lblTo);
            GroupBox1.Controls.Add(txtFrom);
            GroupBox1.Controls.Add(lblFrom);
            GroupBox1.Controls.Add(txtNavigator);
            GroupBox1.Controls.Add(lblNavigator);
            GroupBox1.Controls.Add(txtVessel);
            GroupBox1.Controls.Add(lblVessel);
            GroupBox1.Location = new Point(9, 83);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(1403, 215);
            GroupBox1.TabIndex = 8;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Update Fields";
            // 
            // chkUseForEval
            // 
            chkUseForEval.AutoSize = true;
            chkUseForEval.Location = new Point(707, 192);
            chkUseForEval.Name = "chkUseForEval";
            chkUseForEval.Size = new Size(169, 17);
            chkUseForEval.TabIndex = 236;
            chkUseForEval.Text = "Mark Log Entry For Evaluation";
            chkUseForEval.UseVisualStyleBackColor = true;
            // 
            // grpLogNotes
            // 
            grpLogNotes.Controls.Add(txtRemarks);
            grpLogNotes.Location = new Point(941, 85);
            grpLogNotes.Name = "grpLogNotes";
            grpLogNotes.Size = new Size(456, 60);
            grpLogNotes.TabIndex = 16;
            grpLogNotes.TabStop = false;
            grpLogNotes.Text = "Log Notes";
            // 
            // txtRemarks
            // 
            txtRemarks.BackColor = Color.White;
            txtRemarks.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtRemarks.Location = new Point(12, 15);
            txtRemarks.MaxLength = 250;
            txtRemarks.Multiline = true;
            txtRemarks.Name = "txtRemarks";
            txtRemarks.ScrollBars = ScrollBars.Both;
            txtRemarks.Size = new Size(440, 39);
            txtRemarks.TabIndex = 210;
            // 
            // grpWeather
            // 
            grpWeather.Controls.Add(lblWind);
            grpWeather.Controls.Add(txtSeas);
            grpWeather.Controls.Add(txtWeather);
            grpWeather.Controls.Add(lbWaves);
            grpWeather.Controls.Add(txtWind);
            grpWeather.Controls.Add(cboWindDir);
            grpWeather.Controls.Add(lblWind2);
            grpWeather.Location = new Point(942, 149);
            grpWeather.Name = "grpWeather";
            grpWeather.Size = new Size(455, 60);
            grpWeather.TabIndex = 16;
            grpWeather.TabStop = false;
            grpWeather.Text = "Weather Notes";
            // 
            // lblWind
            // 
            lblWind.AutoSize = true;
            lblWind.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblWind.Location = new Point(6, 16);
            lblWind.Name = "lblWind";
            lblWind.Size = new Size(39, 15);
            lblWind.TabIndex = 246;
            lblWind.Text = "Wind:";
            lblWind.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtSeas
            // 
            txtSeas.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtSeas.Location = new Point(48, 35);
            txtSeas.Name = "txtSeas";
            txtSeas.Size = new Size(45, 22);
            txtSeas.TabIndex = 251;
            ToolTip1.SetToolTip(txtSeas, "Log Entry From Location Name " + '\r' + '\n' + "Required for all entries" + '\r' + '\n' + "Provides detailed waypoi" + "nt, route, and track " + '\r' + '\n' + "from / to location names on log and on GPX" + '\r' + '\n' + "export file.");
            // 
            // txtWeather
            // 
            txtWeather.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtWeather.Location = new Point(186, 14);
            txtWeather.MaxLength = 250;
            txtWeather.Multiline = true;
            txtWeather.Name = "txtWeather";
            txtWeather.ScrollBars = ScrollBars.Both;
            txtWeather.Size = new Size(265, 39);
            txtWeather.TabIndex = 208;
            // 
            // lbWaves
            // 
            lbWaves.AutoSize = true;
            lbWaves.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lbWaves.Location = new Point(6, 38);
            lbWaves.Name = "lbWaves";
            lbWaves.Size = new Size(35, 15);
            lbWaves.TabIndex = 250;
            lbWaves.Text = "Seas:";
            lbWaves.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtWind
            // 
            txtWind.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtWind.Location = new Point(48, 13);
            txtWind.Name = "txtWind";
            txtWind.Size = new Size(45, 22);
            txtWind.TabIndex = 247;
            ToolTip1.SetToolTip(txtWind, "Log Entry From Location Name " + '\r' + '\n' + "Required for all entries" + '\r' + '\n' + "Provides detailed waypoi" + "nt, route, and track " + '\r' + '\n' + "from / to location names on log and on GPX" + '\r' + '\n' + "export file.");
            // 
            // cboWindDir
            // 
            cboWindDir.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboWindDir.FormattingEnabled = true;
            cboWindDir.Items.AddRange(new object[] { "N", "NE", "E", "SE", "S", "SW", "W", "NW" });
            cboWindDir.Location = new Point(135, 14);
            cboWindDir.Name = "cboWindDir";
            cboWindDir.Size = new Size(45, 23);
            cboWindDir.TabIndex = 249;
            ToolTip1.SetToolTip(cboWindDir, "Variation E/W field - required if Variation field is used");
            // 
            // lblWind2
            // 
            lblWind2.AutoSize = true;
            lblWind2.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblWind2.Location = new Point(96, 17);
            lblWind2.Name = "lblWind2";
            lblWind2.Size = new Size(37, 15);
            lblWind2.TabIndex = 248;
            lblWind2.Text = "from: ";
            lblWind2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // grpAdvInfo
            // 
            grpAdvInfo.Controls.Add(_cboAdvType);
            grpAdvInfo.Controls.Add(cboAdvMin);
            grpAdvInfo.Controls.Add(lblAdvHrMin);
            grpAdvInfo.Controls.Add(cboAdvHrs);
            grpAdvInfo.Controls.Add(cboAdvNm);
            grpAdvInfo.Controls.Add(lblAdvNm);
            grpAdvInfo.Location = new Point(941, 38);
            grpAdvInfo.Name = "grpAdvInfo";
            grpAdvInfo.Size = new Size(456, 44);
            grpAdvInfo.TabIndex = 245;
            grpAdvInfo.TabStop = false;
            grpAdvInfo.Text = "DR Advance Info";
            grpAdvInfo.Visible = false;
            // 
            // cboAdvType
            // 
            _cboAdvType.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboAdvType.FormattingEnabled = true;
            _cboAdvType.Items.AddRange(new object[] { "Adv Hr/Min", "Adv Nm" });
            _cboAdvType.Location = new Point(11, 15);
            _cboAdvType.Name = "_cboAdvType";
            _cboAdvType.Size = new Size(90, 23);
            _cboAdvType.TabIndex = 242;
            _cboAdvType.Visible = false;
            // 
            // cboAdvMin
            // 
            cboAdvMin.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboAdvMin.Location = new Point(245, 16);
            cboAdvMin.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            cboAdvMin.Name = "cboAdvMin";
            cboAdvMin.Size = new Size(58, 22);
            cboAdvMin.TabIndex = 235;
            cboAdvMin.Visible = false;
            // 
            // lblAdvHrMin
            // 
            lblAdvHrMin.AutoSize = true;
            lblAdvHrMin.BackColor = Color.Aqua;
            lblAdvHrMin.BorderStyle = BorderStyle.Fixed3D;
            lblAdvHrMin.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblAdvHrMin.Location = new Point(110, 18);
            lblAdvHrMin.Name = "lblAdvHrMin";
            lblAdvHrMin.Size = new Size(78, 17);
            lblAdvHrMin.TabIndex = 236;
            lblAdvHrMin.Text = "Adv Hr/Min:";
            lblAdvHrMin.TextAlign = ContentAlignment.MiddleRight;
            lblAdvHrMin.Visible = false;
            // 
            // cboAdvHrs
            // 
            cboAdvHrs.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboAdvHrs.Location = new Point(192, 16);
            cboAdvHrs.Name = "cboAdvHrs";
            cboAdvHrs.Size = new Size(50, 22);
            cboAdvHrs.TabIndex = 237;
            cboAdvHrs.Visible = false;
            // 
            // cboAdvNm
            // 
            cboAdvNm.DecimalPlaces = 1;
            cboAdvNm.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboAdvNm.Location = new Point(372, 16);
            cboAdvNm.Maximum = new decimal(new int[] { 50000, 0, 0, 65536 });
            cboAdvNm.Name = "cboAdvNm";
            cboAdvNm.ReadOnly = true;
            cboAdvNm.Size = new Size(58, 22);
            cboAdvNm.TabIndex = 241;
            cboAdvNm.Visible = false;
            // 
            // lblAdvNm
            // 
            lblAdvNm.AutoSize = true;
            lblAdvNm.BackColor = Color.Aqua;
            lblAdvNm.BorderStyle = BorderStyle.Fixed3D;
            lblAdvNm.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblAdvNm.Location = new Point(310, 18);
            lblAdvNm.Name = "lblAdvNm";
            lblAdvNm.Size = new Size(57, 17);
            lblAdvNm.TabIndex = 240;
            lblAdvNm.Text = "Adv Nm:";
            lblAdvNm.TextAlign = ContentAlignment.MiddleRight;
            lblAdvNm.Visible = false;
            // 
            // grpLogEntryInfo
            // 
            grpLogEntryInfo.Controls.Add(lblKnotLog);
            grpLogEntryInfo.Controls.Add(txtKnotLog);
            grpLogEntryInfo.Controls.Add(Label19);
            grpLogEntryInfo.Controls.Add(txtZD);
            grpLogEntryInfo.Controls.Add(lblZoneDT);
            grpLogEntryInfo.Controls.Add(_DTDateZoneTime);
            grpLogEntryInfo.Controls.Add(lblCompass);
            grpLogEntryInfo.Controls.Add(_txtCompass);
            grpLogEntryInfo.Controls.Add(Label1);
            grpLogEntryInfo.Controls.Add(Label6);
            grpLogEntryInfo.Controls.Add(lblVariation);
            grpLogEntryInfo.Controls.Add(txtVar);
            grpLogEntryInfo.Controls.Add(cboVar);
            grpLogEntryInfo.Controls.Add(Label18);
            grpLogEntryInfo.Controls.Add(lblDev);
            grpLogEntryInfo.Controls.Add(txtDev);
            grpLogEntryInfo.Controls.Add(cboDev);
            grpLogEntryInfo.Controls.Add(Label2);
            grpLogEntryInfo.Controls.Add(Label3);
            grpLogEntryInfo.Controls.Add(lblDRL);
            grpLogEntryInfo.Controls.Add(lblLDeg);
            grpLogEntryInfo.Controls.Add(lblLMin);
            grpLogEntryInfo.Controls.Add(lblDRLo);
            grpLogEntryInfo.Controls.Add(lblLoDeg);
            grpLogEntryInfo.Controls.Add(lblLoMin);
            grpLogEntryInfo.Controls.Add(txtLMin);
            grpLogEntryInfo.Controls.Add(txtLoDeg);
            grpLogEntryInfo.Controls.Add(txtLoMin);
            grpLogEntryInfo.Controls.Add(txtLDeg);
            grpLogEntryInfo.Controls.Add(txtSpeed);
            grpLogEntryInfo.Controls.Add(cboL);
            grpLogEntryInfo.Controls.Add(lblSpeed);
            grpLogEntryInfo.Controls.Add(cboLo);
            grpLogEntryInfo.Controls.Add(Label4);
            grpLogEntryInfo.Controls.Add(lblCTrue);
            grpLogEntryInfo.Controls.Add(_txtCTrue);
            grpLogEntryInfo.Location = new Point(9, 38);
            grpLogEntryInfo.Name = "grpLogEntryInfo";
            grpLogEntryInfo.Size = new Size(930, 64);
            grpLogEntryInfo.TabIndex = 244;
            grpLogEntryInfo.TabStop = false;
            grpLogEntryInfo.Text = "Log Entry Info";
            // 
            // lblKnotLog
            // 
            lblKnotLog.AutoSize = true;
            lblKnotLog.BackColor = Color.Aqua;
            lblKnotLog.BorderStyle = BorderStyle.Fixed3D;
            lblKnotLog.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblKnotLog.Location = new Point(779, 17);
            lblKnotLog.Name = "lblKnotLog";
            lblKnotLog.Size = new Size(60, 17);
            lblKnotLog.TabIndex = 234;
            lblKnotLog.Text = "Knot Log";
            lblKnotLog.TextAlign = ContentAlignment.MiddleRight;
            lblKnotLog.Visible = false;
            // 
            // txtKnotLog
            // 
            txtKnotLog.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtKnotLog.Location = new Point(780, 35);
            txtKnotLog.MaxLength = 7;
            txtKnotLog.Name = "txtKnotLog";
            txtKnotLog.Size = new Size(60, 22);
            txtKnotLog.TabIndex = 235;
            txtKnotLog.Visible = false;
            // 
            // Label19
            // 
            Label19.AutoSize = true;
            Label19.BackColor = Color.Aqua;
            Label19.BorderStyle = BorderStyle.Fixed3D;
            Label19.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label19.Location = new Point(747, 17);
            Label19.Name = "Label19";
            Label19.Size = new Size(26, 17);
            Label19.TabIndex = 232;
            Label19.Text = "ZD";
            Label19.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtZD
            // 
            txtZD.Enabled = false;
            txtZD.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtZD.Location = new Point(746, 35);
            txtZD.MaxLength = 3;
            txtZD.Name = "txtZD";
            txtZD.ReadOnly = true;
            txtZD.Size = new Size(30, 22);
            txtZD.TabIndex = 233;
            // 
            // lblZoneDT
            // 
            lblZoneDT.AutoSize = true;
            lblZoneDT.BackColor = Color.Aqua;
            lblZoneDT.BorderStyle = BorderStyle.Fixed3D;
            lblZoneDT.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblZoneDT.Location = new Point(7, 17);
            lblZoneDT.Name = "lblZoneDT";
            lblZoneDT.Size = new Size(141, 17);
            lblZoneDT.TabIndex = 8;
            lblZoneDT.Text = "   Zone Date and Time:    ";
            lblZoneDT.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DTDateZoneTime
            // 
            _DTDateZoneTime.CalendarMonthBackground = Color.Yellow;
            _DTDateZoneTime.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            _DTDateZoneTime.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _DTDateZoneTime.Format = DateTimePickerFormat.Custom;
            _DTDateZoneTime.Location = new Point(7, 35);
            _DTDateZoneTime.Name = "_DTDateZoneTime";
            _DTDateZoneTime.ShowUpDown = true;
            _DTDateZoneTime.Size = new Size(144, 22);
            _DTDateZoneTime.TabIndex = 9;
            // 
            // lblCompass
            // 
            lblCompass.AutoSize = true;
            lblCompass.BackColor = Color.Aqua;
            lblCompass.BorderStyle = BorderStyle.Fixed3D;
            lblCompass.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblCompass.Location = new Point(475, 18);
            lblCompass.Name = "lblCompass";
            lblCompass.Size = new Size(61, 17);
            lblCompass.TabIndex = 10;
            lblCompass.Text = "Compass:";
            lblCompass.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtCompass
            // 
            _txtCompass.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtCompass.Location = new Point(483, 35);
            _txtCompass.MaxLength = 3;
            _txtCompass.Name = "_txtCompass";
            _txtCompass.Size = new Size(30, 22);
            _txtCompass.TabIndex = 11;
            ToolTip1.SetToolTip(_txtCompass, "Compass heading - required for DR and Fix entries" + '\r' + '\n' + "For Plan and GPS entries this " + "field is protected from" + '\r' + '\n' + "input and calculated using other fields");
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.Location = new Point(640, 37);
            Label1.Name = "Label1";
            Label1.Size = new Size(0, 15);
            Label1.TabIndex = 12;
            // 
            // Label6
            // 
            Label6.BackColor = SystemColors.Window;
            Label6.Cursor = Cursors.Default;
            Label6.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label6.ForeColor = SystemColors.ControlText;
            Label6.Location = new Point(515, 38);
            Label6.Name = "Label6";
            Label6.RightToLeft = RightToLeft.No;
            Label6.Size = new Size(9, 17);
            Label6.TabIndex = 172;
            Label6.Text = "°";
            // 
            // lblVariation
            // 
            lblVariation.AutoSize = true;
            lblVariation.BackColor = Color.Aqua;
            lblVariation.BorderStyle = BorderStyle.Fixed3D;
            lblVariation.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblVariation.Location = new Point(629, 17);
            lblVariation.Name = "lblVariation";
            lblVariation.Size = new Size(68, 17);
            lblVariation.TabIndex = 173;
            lblVariation.Text = "  Variation: ";
            lblVariation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtVar
            // 
            txtVar.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtVar.Location = new Point(627, 35);
            txtVar.MaxLength = 2;
            txtVar.Name = "txtVar";
            txtVar.Size = new Size(25, 22);
            txtVar.TabIndex = 174;
            ToolTip1.SetToolTip(txtVar, "Magnetic Variation field - optional for all inputs");
            // 
            // cboVar
            // 
            cboVar.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboVar.FormattingEnabled = true;
            cboVar.Items.AddRange(new object[] { "W", "E" });
            cboVar.Location = new Point(662, 35);
            cboVar.Name = "cboVar";
            cboVar.Size = new Size(35, 23);
            cboVar.TabIndex = 175;
            ToolTip1.SetToolTip(cboVar, "Variation E/W field - required if Variation field is used");
            // 
            // Label18
            // 
            Label18.BackColor = SystemColors.Window;
            Label18.Cursor = Cursors.Default;
            Label18.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label18.ForeColor = SystemColors.ControlText;
            Label18.Location = new Point(446, 38);
            Label18.Name = "Label18";
            Label18.RightToLeft = RightToLeft.No;
            Label18.Size = new Size(20, 17);
            Label18.TabIndex = 231;
            Label18.Text = "kn";
            // 
            // lblDev
            // 
            lblDev.AutoSize = true;
            lblDev.BackColor = Color.Aqua;
            lblDev.BorderStyle = BorderStyle.Fixed3D;
            lblDev.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblDev.Location = new Point(546, 17);
            lblDev.Name = "lblDev";
            lblDev.Size = new Size(70, 17);
            lblDev.TabIndex = 176;
            lblDev.Text = " Deviation: ";
            lblDev.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtDev
            // 
            txtDev.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtDev.Location = new Point(545, 35);
            txtDev.MaxLength = 2;
            txtDev.Name = "txtDev";
            txtDev.Size = new Size(25, 22);
            txtDev.TabIndex = 177;
            ToolTip1.SetToolTip(txtDev, resources.GetString("txtDev.ToolTip"));
            // 
            // cboDev
            // 
            cboDev.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboDev.FormattingEnabled = true;
            cboDev.Items.AddRange(new object[] { "W", "E" });
            cboDev.Location = new Point(582, 35);
            cboDev.Name = "cboDev";
            cboDev.Size = new Size(35, 23);
            cboDev.TabIndex = 178;
            ToolTip1.SetToolTip(cboDev, "Deviation E/W field - required if Deviation field is used");
            // 
            // Label2
            // 
            Label2.BackColor = SystemColors.Window;
            Label2.Cursor = Cursors.Default;
            Label2.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = SystemColors.ControlText;
            Label2.Location = new Point(652, 39);
            Label2.Name = "Label2";
            Label2.RightToLeft = RightToLeft.No;
            Label2.Size = new Size(9, 17);
            Label2.TabIndex = 179;
            Label2.Text = "°";
            // 
            // Label3
            // 
            Label3.BackColor = SystemColors.Window;
            Label3.Cursor = Cursors.Default;
            Label3.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.ForeColor = SystemColors.ControlText;
            Label3.Location = new Point(571, 39);
            Label3.Name = "Label3";
            Label3.RightToLeft = RightToLeft.No;
            Label3.Size = new Size(9, 17);
            Label3.TabIndex = 180;
            Label3.Text = "°";
            // 
            // lblDRL
            // 
            lblDRL.BackColor = Color.Aqua;
            lblDRL.BorderStyle = BorderStyle.Fixed3D;
            lblDRL.Cursor = Cursors.Default;
            lblDRL.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblDRL.ForeColor = SystemColors.ControlText;
            lblDRL.Location = new Point(156, 17);
            lblDRL.Name = "lblDRL";
            lblDRL.RightToLeft = RightToLeft.No;
            lblDRL.Size = new Size(114, 17);
            lblDRL.TabIndex = 201;
            lblDRL.Text = "Latitude:";
            lblDRL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLDeg
            // 
            lblLDeg.BackColor = SystemColors.Window;
            lblLDeg.Cursor = Cursors.Default;
            lblLDeg.Enabled = false;
            lblLDeg.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLDeg.ForeColor = SystemColors.ControlText;
            lblLDeg.Location = new Point(181, 37);
            lblLDeg.Name = "lblLDeg";
            lblLDeg.RightToLeft = RightToLeft.No;
            lblLDeg.Size = new Size(9, 17);
            lblLDeg.TabIndex = 202;
            lblLDeg.Text = "°";
            // 
            // lblLMin
            // 
            lblLMin.BackColor = SystemColors.Window;
            lblLMin.Cursor = Cursors.Default;
            lblLMin.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLMin.ForeColor = SystemColors.ControlText;
            lblLMin.Location = new Point(223, 36);
            lblLMin.Name = "lblLMin";
            lblLMin.RightToLeft = RightToLeft.No;
            lblLMin.Size = new Size(9, 17);
            lblLMin.TabIndex = 203;
            lblLMin.Text = "'";
            // 
            // lblDRLo
            // 
            lblDRLo.BackColor = Color.Aqua;
            lblDRLo.BorderStyle = BorderStyle.Fixed3D;
            lblDRLo.Cursor = Cursors.Default;
            lblDRLo.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblDRLo.ForeColor = SystemColors.ControlText;
            lblDRLo.Location = new Point(279, 17);
            lblDRLo.Name = "lblDRLo";
            lblDRLo.RightToLeft = RightToLeft.No;
            lblDRLo.Size = new Size(124, 17);
            lblDRLo.TabIndex = 204;
            lblDRLo.Text = "Longitude:";
            lblDRLo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLoDeg
            // 
            lblLoDeg.BackColor = SystemColors.Window;
            lblLoDeg.Cursor = Cursors.Default;
            lblLoDeg.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLoDeg.ForeColor = SystemColors.ControlText;
            lblLoDeg.Location = new Point(311, 37);
            lblLoDeg.Name = "lblLoDeg";
            lblLoDeg.RightToLeft = RightToLeft.No;
            lblLoDeg.Size = new Size(9, 17);
            lblLoDeg.TabIndex = 205;
            lblLoDeg.Text = "°";
            // 
            // lblLoMin
            // 
            lblLoMin.BackColor = SystemColors.Window;
            lblLoMin.Cursor = Cursors.Default;
            lblLoMin.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLoMin.ForeColor = SystemColors.ControlText;
            lblLoMin.Location = new Point(353, 37);
            lblLoMin.Name = "lblLoMin";
            lblLoMin.RightToLeft = RightToLeft.No;
            lblLoMin.Size = new Size(9, 17);
            lblLoMin.TabIndex = 206;
            lblLoMin.Text = "'";
            // 
            // txtLMin
            // 
            txtLMin.AcceptsReturn = true;
            txtLMin.BackColor = SystemColors.Window;
            txtLMin.Cursor = Cursors.IBeam;
            txtLMin.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtLMin.ForeColor = SystemColors.WindowText;
            txtLMin.HideSelection = false;
            txtLMin.Location = new Point(190, 35);
            txtLMin.MaxLength = 5;
            txtLMin.Name = "txtLMin";
            txtLMin.RightToLeft = RightToLeft.No;
            txtLMin.Size = new Size(33, 22);
            txtLMin.TabIndex = 196;
            // 
            // txtLoDeg
            // 
            txtLoDeg.AcceptsReturn = true;
            txtLoDeg.BackColor = SystemColors.Window;
            txtLoDeg.Cursor = Cursors.IBeam;
            txtLoDeg.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtLoDeg.ForeColor = SystemColors.WindowText;
            txtLoDeg.HideSelection = false;
            txtLoDeg.Location = new Point(278, 35);
            txtLoDeg.MaxLength = 3;
            txtLoDeg.Name = "txtLoDeg";
            txtLoDeg.RightToLeft = RightToLeft.No;
            txtLoDeg.Size = new Size(33, 22);
            txtLoDeg.TabIndex = 198;
            // 
            // txtLoMin
            // 
            txtLoMin.AcceptsReturn = true;
            txtLoMin.BackColor = SystemColors.Window;
            txtLoMin.Cursor = Cursors.IBeam;
            txtLoMin.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtLoMin.ForeColor = SystemColors.WindowText;
            txtLoMin.HideSelection = false;
            txtLoMin.Location = new Point(320, 35);
            txtLoMin.MaxLength = 5;
            txtLoMin.Name = "txtLoMin";
            txtLoMin.RightToLeft = RightToLeft.No;
            txtLoMin.Size = new Size(33, 22);
            txtLoMin.TabIndex = 199;
            // 
            // txtLDeg
            // 
            txtLDeg.AcceptsReturn = true;
            txtLDeg.BackColor = SystemColors.Window;
            txtLDeg.Cursor = Cursors.IBeam;
            txtLDeg.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtLDeg.ForeColor = SystemColors.WindowText;
            txtLDeg.HideSelection = false;
            txtLDeg.Location = new Point(156, 35);
            txtLDeg.MaxLength = 2;
            txtLDeg.Name = "txtLDeg";
            txtLDeg.RightToLeft = RightToLeft.No;
            txtLDeg.Size = new Size(25, 22);
            txtLDeg.TabIndex = 195;
            // 
            // txtSpeed
            // 
            txtSpeed.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtSpeed.Location = new Point(411, 35);
            txtSpeed.MaxLength = 4;
            txtSpeed.Name = "txtSpeed";
            txtSpeed.Size = new Size(35, 22);
            txtSpeed.TabIndex = 215;
            ToolTip1.SetToolTip(txtSpeed, "Assumed or actual ship speed in knots. Decimal field" + '\r' + '\n' + "of nn.n format");
            // 
            // cboL
            // 
            cboL.BackColor = SystemColors.Window;
            cboL.Cursor = Cursors.Default;
            cboL.DropDownStyle = ComboBoxStyle.DropDownList;
            cboL.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboL.ForeColor = SystemColors.WindowText;
            cboL.Items.AddRange(new object[] { "N", "S" });
            cboL.Location = new Point(231, 34);
            cboL.Name = "cboL";
            cboL.RightToLeft = RightToLeft.No;
            cboL.Size = new Size(41, 23);
            cboL.TabIndex = 197;
            // 
            // lblSpeed
            // 
            lblSpeed.AutoSize = true;
            lblSpeed.BackColor = Color.Aqua;
            lblSpeed.BorderStyle = BorderStyle.Fixed3D;
            lblSpeed.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblSpeed.Location = new Point(412, 17);
            lblSpeed.Name = "lblSpeed";
            lblSpeed.Size = new Size(51, 17);
            lblSpeed.TabIndex = 214;
            lblSpeed.Text = " Speed: ";
            lblSpeed.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cboLo
            // 
            cboLo.BackColor = SystemColors.Window;
            cboLo.Cursor = Cursors.Default;
            cboLo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLo.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboLo.ForeColor = SystemColors.WindowText;
            cboLo.Items.AddRange(new object[] { "W", "E" });
            cboLo.Location = new Point(363, 34);
            cboLo.Name = "cboLo";
            cboLo.RightToLeft = RightToLeft.No;
            cboLo.Size = new Size(41, 23);
            cboLo.TabIndex = 200;
            // 
            // Label4
            // 
            Label4.BackColor = SystemColors.Window;
            Label4.Cursor = Cursors.Default;
            Label4.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.ForeColor = SystemColors.ControlText;
            Label4.Location = new Point(734, 38);
            Label4.Name = "Label4";
            Label4.RightToLeft = RightToLeft.No;
            Label4.Size = new Size(9, 17);
            Label4.TabIndex = 213;
            Label4.Text = "°";
            // 
            // lblCTrue
            // 
            lblCTrue.AutoSize = true;
            lblCTrue.BackColor = Color.Aqua;
            lblCTrue.BorderStyle = BorderStyle.Fixed3D;
            lblCTrue.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblCTrue.Location = new Point(704, 17);
            lblCTrue.Name = "lblCTrue";
            lblCTrue.Size = new Size(37, 17);
            lblCTrue.TabIndex = 211;
            lblCTrue.Text = "True:";
            lblCTrue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtCTrue
            // 
            _txtCTrue.Enabled = false;
            _txtCTrue.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtCTrue.Location = new Point(703, 35);
            _txtCTrue.MaxLength = 3;
            _txtCTrue.Name = "_txtCTrue";
            _txtCTrue.Size = new Size(30, 22);
            _txtCTrue.TabIndex = 212;
            ToolTip1.SetToolTip(_txtCTrue, "True heading - required for Plan and GPS entries." + '\r' + '\n' + "For DR and Fix entries it is p" + "rotected and calculated" + '\r' + '\n' + "using Compass, Variation, and Deviation fields.");
            // 
            // chkImportGCR
            // 
            chkImportGCR.AutoSize = true;
            chkImportGCR.Checked = true;
            chkImportGCR.CheckState = CheckState.Checked;
            chkImportGCR.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            chkImportGCR.Location = new Point(546, 170);
            chkImportGCR.Name = "chkImportGCR";
            chkImportGCR.Size = new Size(160, 19);
            chkImportGCR.TabIndex = 243;
            chkImportGCR.Text = "Import GCR from Sailings";
            chkImportGCR.TextAlign = ContentAlignment.TopLeft;
            chkImportGCR.UseVisualStyleBackColor = true;
            chkImportGCR.Visible = false;
            // 
            // chkPlanGCR
            // 
            _chkPlanGCR.AutoSize = true;
            _chkPlanGCR.Checked = true;
            _chkPlanGCR.CheckState = CheckState.Checked;
            _chkPlanGCR.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _chkPlanGCR.Location = new Point(323, 171);
            _chkPlanGCR.Name = "_chkPlanGCR";
            _chkPlanGCR.Size = new Size(221, 19);
            _chkPlanGCR.TabIndex = 238;
            _chkPlanGCR.Text = "Convert Plan Entry > 500 nm  to GCR";
            _chkPlanGCR.TextAlign = ContentAlignment.MiddleCenter;
            ToolTip1.SetToolTip(_chkPlanGCR, "When this field is checked, Plan entries with Longitude change" + '\r' + '\n' + "> 30 degress will" + " be converted to Great Circle Route steps" + '\r' + '\n' + "using the Sailings and Points on Grea" + "t Circle Route forms." + '\r' + '\n');
            _chkPlanGCR.UseVisualStyleBackColor = true;
            _chkPlanGCR.Visible = false;
            // 
            // cboDisplayRows
            // 
            _cboDisplayRows.FormattingEnabled = true;
            _cboDisplayRows.Items.AddRange(new object[] { "All", "Plan/Route", "DR/GPS Track", "Fix/WPT", "DR/GPS Track/Fix/WPT" });
            _cboDisplayRows.Location = new Point(141, 192);
            _cboDisplayRows.Name = "_cboDisplayRows";
            _cboDisplayRows.Size = new Size(110, 21);
            _cboDisplayRows.TabIndex = 229;
            _cboDisplayRows.Visible = false;
            // 
            // Label14
            // 
            Label14.BackColor = Color.Silver;
            Label14.BorderStyle = BorderStyle.Fixed3D;
            Label14.Cursor = Cursors.Default;
            Label14.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label14.ForeColor = SystemColors.ControlText;
            Label14.Location = new Point(14, 193);
            Label14.Name = "Label14";
            Label14.RightToLeft = RightToLeft.No;
            Label14.Size = new Size(122, 18);
            Label14.TabIndex = 228;
            Label14.Text = "Filter Row for Display:";
            Label14.TextAlign = ContentAlignment.MiddleCenter;
            Label14.Visible = false;
            // 
            // btnUseZTInfoForm
            // 
            _btnUseZTInfoForm.BackColor = Color.Yellow;
            _btnUseZTInfoForm.Font = new Font("Arial Narrow", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnUseZTInfoForm.ForeColor = SystemColors.ControlText;
            _btnUseZTInfoForm.Location = new Point(355, 190);
            _btnUseZTInfoForm.Name = "_btnUseZTInfoForm";
            _btnUseZTInfoForm.Size = new Size(90, 23);
            _btnUseZTInfoForm.TabIndex = 227;
            _btnUseZTInfoForm.Text = "ZoneTime Form";
            _btnUseZTInfoForm.UseVisualStyleBackColor = false;
            _btnUseZTInfoForm.Visible = false;
            // 
            // btnUseTVMDC
            // 
            _btnUseTVMDC.BackColor = Color.Yellow;
            _btnUseTVMDC.Font = new Font("Arial Narrow", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnUseTVMDC.ForeColor = SystemColors.ControlText;
            _btnUseTVMDC.Location = new Point(266, 190);
            _btnUseTVMDC.Name = "_btnUseTVMDC";
            _btnUseTVMDC.Size = new Size(79, 23);
            _btnUseTVMDC.TabIndex = 226;
            _btnUseTVMDC.Text = "TVMDC Form";
            _btnUseTVMDC.UseVisualStyleBackColor = false;
            _btnUseTVMDC.Visible = false;
            // 
            // linkLblNOAAVar
            // 
            _linkLblNOAAVar.AutoSize = true;
            _linkLblNOAAVar.Location = new Point(470, 193);
            _linkLblNOAAVar.Name = "_linkLblNOAAVar";
            _linkLblNOAAVar.Size = new Size(229, 13);
            _linkLblNOAAVar.TabIndex = 224;
            _linkLblNOAAVar.TabStop = true;
            _linkLblNOAAVar.Text = "Use NOAA web page to calculate the Variation";
            _linkLblNOAAVar.Visible = false;
            // 
            // chkHideFirst4Col
            // 
            _chkHideFirst4Col.AutoSize = true;
            _chkHideFirst4Col.Font = new Font("Times New Roman", 9.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _chkHideFirst4Col.Location = new Point(14, 171);
            _chkHideFirst4Col.Name = "_chkHideFirst4Col";
            _chkHideFirst4Col.Size = new Size(309, 19);
            _chkHideFirst4Col.TabIndex = 223;
            _chkHideFirst4Col.Text = "Hide Vessel, Navigator, From, To, Weather Notes Columns";
            _chkHideFirst4Col.UseVisualStyleBackColor = true;
            _chkHideFirst4Col.Visible = false;
            // 
            // grpbxPlan
            // 
            grpbxPlan.BackColor = Color.Silver;
            grpbxPlan.Controls.Add(Label20);
            grpbxPlan.Controls.Add(txtDestZD);
            grpbxPlan.Controls.Add(txtEstArrival);
            grpbxPlan.Controls.Add(lblEstArrival);
            grpbxPlan.Controls.Add(txtDestElapsed);
            grpbxPlan.Controls.Add(Label17);
            grpbxPlan.Controls.Add(txtDestDist);
            grpbxPlan.Controls.Add(Label16);
            grpbxPlan.Controls.Add(txtDestTrue);
            grpbxPlan.Controls.Add(Label15);
            grpbxPlan.Controls.Add(cboDestLo);
            grpbxPlan.Controls.Add(cboDestL);
            grpbxPlan.Controls.Add(txtDestLDeg);
            grpbxPlan.Controls.Add(txtDestLoMin);
            grpbxPlan.Controls.Add(txtDestLoDeg);
            grpbxPlan.Controls.Add(txtDestLMin);
            grpbxPlan.Controls.Add(Label8);
            grpbxPlan.Controls.Add(Label9);
            grpbxPlan.Controls.Add(Label10);
            grpbxPlan.Controls.Add(Label11);
            grpbxPlan.Controls.Add(Label12);
            grpbxPlan.Controls.Add(Label13);
            grpbxPlan.Cursor = Cursors.Default;
            grpbxPlan.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            grpbxPlan.Location = new Point(10, 105);
            grpbxPlan.Margin = new Padding(5);
            grpbxPlan.Name = "grpbxPlan";
            grpbxPlan.Size = new Size(839, 62);
            grpbxPlan.TabIndex = 222;
            grpbxPlan.TabStop = false;
            grpbxPlan.Text = "Plan Entry Destination Data";
            grpbxPlan.Visible = false;
            // 
            // Label20
            // 
            Label20.AutoSize = true;
            Label20.BackColor = Color.Aqua;
            Label20.BorderStyle = BorderStyle.Fixed3D;
            Label20.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label20.Location = new Point(774, 15);
            Label20.Name = "Label20";
            Label20.Size = new Size(26, 17);
            Label20.TabIndex = 234;
            Label20.Text = "ZD";
            Label20.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtDestZD
            // 
            txtDestZD.BackColor = Color.Cyan;
            txtDestZD.Enabled = false;
            txtDestZD.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtDestZD.Location = new Point(773, 33);
            txtDestZD.MaxLength = 3;
            txtDestZD.Name = "txtDestZD";
            txtDestZD.ReadOnly = true;
            txtDestZD.Size = new Size(30, 22);
            txtDestZD.TabIndex = 235;
            // 
            // txtEstArrival
            // 
            txtEstArrival.BackColor = Color.Cyan;
            txtEstArrival.Location = new Point(624, 33);
            txtEstArrival.MaxLength = 35;
            txtEstArrival.Name = "txtEstArrival";
            txtEstArrival.ReadOnly = true;
            txtEstArrival.Size = new Size(145, 22);
            txtEstArrival.TabIndex = 227;
            txtEstArrival.TextAlign = HorizontalAlignment.Center;
            // 
            // lblEstArrival
            // 
            lblEstArrival.AutoSize = true;
            lblEstArrival.BackColor = Color.Aqua;
            lblEstArrival.BorderStyle = BorderStyle.Fixed3D;
            lblEstArrival.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblEstArrival.Location = new Point(624, 14);
            lblEstArrival.Name = "lblEstArrival";
            lblEstArrival.Size = new Size(144, 17);
            lblEstArrival.TabIndex = 226;
            lblEstArrival.Text = "Estimated Arrival at Dest:";
            lblEstArrival.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDestElapsed
            // 
            txtDestElapsed.BackColor = Color.Cyan;
            txtDestElapsed.Location = new Point(490, 33);
            txtDestElapsed.MaxLength = 35;
            txtDestElapsed.Name = "txtDestElapsed";
            txtDestElapsed.ReadOnly = true;
            txtDestElapsed.Size = new Size(125, 22);
            txtDestElapsed.TabIndex = 225;
            txtDestElapsed.TextAlign = HorizontalAlignment.Center;
            // 
            // Label17
            // 
            Label17.AutoSize = true;
            Label17.BackColor = Color.Aqua;
            Label17.BorderStyle = BorderStyle.Fixed3D;
            Label17.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label17.Location = new Point(490, 14);
            Label17.Name = "Label17";
            Label17.Size = new Size(125, 17);
            Label17.TabIndex = 224;
            Label17.Text = "Elapsed Time to Dest:";
            Label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDestDist
            // 
            txtDestDist.BackColor = Color.Cyan;
            txtDestDist.Location = new Point(382, 33);
            txtDestDist.MaxLength = 5;
            txtDestDist.Name = "txtDestDist";
            txtDestDist.ReadOnly = true;
            txtDestDist.Size = new Size(100, 22);
            txtDestDist.TabIndex = 223;
            txtDestDist.TextAlign = HorizontalAlignment.Center;
            // 
            // Label16
            // 
            Label16.AutoSize = true;
            Label16.BackColor = Color.Aqua;
            Label16.BorderStyle = BorderStyle.Fixed3D;
            Label16.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label16.Location = new Point(382, 14);
            Label16.Name = "Label16";
            Label16.Size = new Size(101, 17);
            Label16.TabIndex = 222;
            Label16.Text = "Distance to Dest:";
            Label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDestTrue
            // 
            txtDestTrue.BackColor = Color.Cyan;
            txtDestTrue.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtDestTrue.Location = new Point(259, 33);
            txtDestTrue.MaxLength = 3;
            txtDestTrue.Name = "txtDestTrue";
            txtDestTrue.ReadOnly = true;
            txtDestTrue.Size = new Size(120, 22);
            txtDestTrue.TabIndex = 220;
            txtDestTrue.TextAlign = HorizontalAlignment.Center;
            // 
            // Label15
            // 
            Label15.AutoSize = true;
            Label15.BackColor = Color.Aqua;
            Label15.BorderStyle = BorderStyle.Fixed3D;
            Label15.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label15.Location = new Point(258, 15);
            Label15.Name = "Label15";
            Label15.Size = new Size(120, 17);
            Label15.TabIndex = 219;
            Label15.Text = "True Course to Dest:";
            Label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cboDestLo
            // 
            cboDestLo.BackColor = SystemColors.Window;
            cboDestLo.Cursor = Cursors.Default;
            cboDestLo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDestLo.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboDestLo.ForeColor = SystemColors.WindowText;
            cboDestLo.Items.AddRange(new object[] { "W", "E" });
            cboDestLo.Location = new Point(212, 33);
            cboDestLo.Name = "cboDestLo";
            cboDestLo.RightToLeft = RightToLeft.No;
            cboDestLo.Size = new Size(41, 23);
            cboDestLo.TabIndex = 212;
            // 
            // cboDestL
            // 
            cboDestL.BackColor = SystemColors.Window;
            cboDestL.Cursor = Cursors.Default;
            cboDestL.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDestL.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboDestL.ForeColor = SystemColors.WindowText;
            cboDestL.Items.AddRange(new object[] { "N", "S" });
            cboDestL.Location = new Point(81, 34);
            cboDestL.Name = "cboDestL";
            cboDestL.RightToLeft = RightToLeft.No;
            cboDestL.Size = new Size(41, 23);
            cboDestL.TabIndex = 209;
            // 
            // txtDestLDeg
            // 
            txtDestLDeg.AcceptsReturn = true;
            txtDestLDeg.BackColor = SystemColors.Window;
            txtDestLDeg.Cursor = Cursors.IBeam;
            txtDestLDeg.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtDestLDeg.ForeColor = SystemColors.WindowText;
            txtDestLDeg.HideSelection = false;
            txtDestLDeg.Location = new Point(9, 35);
            txtDestLDeg.MaxLength = 2;
            txtDestLDeg.Name = "txtDestLDeg";
            txtDestLDeg.RightToLeft = RightToLeft.No;
            txtDestLDeg.Size = new Size(25, 22);
            txtDestLDeg.TabIndex = 207;
            // 
            // txtDestLoMin
            // 
            txtDestLoMin.AcceptsReturn = true;
            txtDestLoMin.BackColor = SystemColors.Window;
            txtDestLoMin.Cursor = Cursors.IBeam;
            txtDestLoMin.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtDestLoMin.ForeColor = SystemColors.WindowText;
            txtDestLoMin.HideSelection = false;
            txtDestLoMin.Location = new Point(168, 34);
            txtDestLoMin.MaxLength = 5;
            txtDestLoMin.Name = "txtDestLoMin";
            txtDestLoMin.RightToLeft = RightToLeft.No;
            txtDestLoMin.Size = new Size(33, 22);
            txtDestLoMin.TabIndex = 211;
            // 
            // txtDestLoDeg
            // 
            txtDestLoDeg.AcceptsReturn = true;
            txtDestLoDeg.BackColor = SystemColors.Window;
            txtDestLoDeg.Cursor = Cursors.IBeam;
            txtDestLoDeg.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtDestLoDeg.ForeColor = SystemColors.WindowText;
            txtDestLoDeg.HideSelection = false;
            txtDestLoDeg.Location = new Point(126, 34);
            txtDestLoDeg.MaxLength = 3;
            txtDestLoDeg.Name = "txtDestLoDeg";
            txtDestLoDeg.RightToLeft = RightToLeft.No;
            txtDestLoDeg.Size = new Size(33, 22);
            txtDestLoDeg.TabIndex = 210;
            // 
            // txtDestLMin
            // 
            txtDestLMin.AcceptsReturn = true;
            txtDestLMin.BackColor = SystemColors.Window;
            txtDestLMin.Cursor = Cursors.IBeam;
            txtDestLMin.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtDestLMin.ForeColor = SystemColors.WindowText;
            txtDestLMin.HideSelection = false;
            txtDestLMin.Location = new Point(41, 35);
            txtDestLMin.MaxLength = 5;
            txtDestLMin.Name = "txtDestLMin";
            txtDestLMin.RightToLeft = RightToLeft.No;
            txtDestLMin.Size = new Size(33, 22);
            txtDestLMin.TabIndex = 208;
            // 
            // Label8
            // 
            Label8.BackColor = SystemColors.Window;
            Label8.Cursor = Cursors.Default;
            Label8.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label8.ForeColor = SystemColors.ControlText;
            Label8.Location = new Point(201, 35);
            Label8.Name = "Label8";
            Label8.RightToLeft = RightToLeft.No;
            Label8.Size = new Size(9, 17);
            Label8.TabIndex = 218;
            Label8.Text = "'";
            // 
            // Label9
            // 
            Label9.BackColor = SystemColors.Window;
            Label9.Cursor = Cursors.Default;
            Label9.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label9.ForeColor = SystemColors.ControlText;
            Label9.Location = new Point(159, 35);
            Label9.Name = "Label9";
            Label9.RightToLeft = RightToLeft.No;
            Label9.Size = new Size(9, 17);
            Label9.TabIndex = 217;
            Label9.Text = "°";
            // 
            // Label10
            // 
            Label10.BackColor = Color.Aqua;
            Label10.BorderStyle = BorderStyle.Fixed3D;
            Label10.Cursor = Cursors.Default;
            Label10.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label10.ForeColor = SystemColors.ControlText;
            Label10.Location = new Point(126, 14);
            Label10.Name = "Label10";
            Label10.RightToLeft = RightToLeft.No;
            Label10.Size = new Size(127, 18);
            Label10.TabIndex = 216;
            Label10.Text = "Dest Longitude:";
            Label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label11
            // 
            Label11.BackColor = SystemColors.Window;
            Label11.Cursor = Cursors.Default;
            Label11.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label11.ForeColor = SystemColors.ControlText;
            Label11.Location = new Point(74, 37);
            Label11.Name = "Label11";
            Label11.RightToLeft = RightToLeft.No;
            Label11.Size = new Size(9, 17);
            Label11.TabIndex = 215;
            Label11.Text = "'";
            // 
            // Label12
            // 
            Label12.BackColor = SystemColors.Window;
            Label12.Cursor = Cursors.Default;
            Label12.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label12.ForeColor = SystemColors.ControlText;
            Label12.Location = new Point(33, 37);
            Label12.Name = "Label12";
            Label12.RightToLeft = RightToLeft.No;
            Label12.Size = new Size(9, 17);
            Label12.TabIndex = 214;
            Label12.Text = "°";
            // 
            // Label13
            // 
            Label13.BackColor = Color.Aqua;
            Label13.BorderStyle = BorderStyle.Fixed3D;
            Label13.Cursor = Cursors.Default;
            Label13.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label13.ForeColor = SystemColors.ControlText;
            Label13.Location = new Point(9, 13);
            Label13.Name = "Label13";
            Label13.RightToLeft = RightToLeft.No;
            Label13.Size = new Size(109, 20);
            Label13.TabIndex = 213;
            Label13.Text = "Dest Latitude:";
            Label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cboLocType
            // 
            _cboLocType.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboLocType.FormattingEnabled = true;
            _cboLocType.Items.AddRange(new object[] { "DR Track", "DRAdvance", "GPS Track", "Waypoint", "Fix", "Plan/Route" });
            _cboLocType.Location = new Point(76, 15);
            _cboLocType.Name = "_cboLocType";
            _cboLocType.Size = new Size(85, 23);
            _cboLocType.TabIndex = 221;
            ToolTip1.SetToolTip(_cboLocType, resources.GetString("cboLocType.ToolTip"));
            // 
            // chkDev
            // 
            _chkDev.AutoSize = true;
            _chkDev.Location = new Point(707, 173);
            _chkDev.Name = "_chkDev";
            _chkDev.Size = new Size(187, 17);
            _chkDev.TabIndex = 230;
            _chkDev.Text = "Use Deviation Form for Dev Value";
            ToolTip1.SetToolTip(_chkDev, resources.GetString("chkDev.ToolTip"));
            _chkDev.UseVisualStyleBackColor = true;
            // 
            // Label5
            // 
            Label5.BackColor = Color.Silver;
            Label5.Cursor = Cursors.Default;
            Label5.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label5.ForeColor = SystemColors.ControlText;
            Label5.Location = new Point(13, 15);
            Label5.Name = "Label5";
            Label5.RightToLeft = RightToLeft.No;
            Label5.Size = new Size(65, 18);
            Label5.TabIndex = 220;
            Label5.Text = "Log Type:";
            Label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnClearFields
            // 
            _btnClearFields.BackColor = Color.Yellow;
            _btnClearFields.Font = new Font("Arial Narrow", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnClearFields.ForeColor = SystemColors.WindowText;
            _btnClearFields.Location = new Point(1299, 16);
            _btnClearFields.Name = "_btnClearFields";
            _btnClearFields.Size = new Size(100, 23);
            _btnClearFields.TabIndex = 219;
            _btnClearFields.Text = "Clear Input Fields";
            _btnClearFields.UseVisualStyleBackColor = false;
            // 
            // btnAddNew
            // 
            _btnAddNew.BackColor = Color.Yellow;
            _btnAddNew.Font = new Font("Arial Narrow", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnAddNew.ForeColor = SystemColors.ControlText;
            _btnAddNew.Location = new Point(999, 15);
            _btnAddNew.Name = "_btnAddNew";
            _btnAddNew.Size = new Size(100, 23);
            _btnAddNew.TabIndex = 216;
            _btnAddNew.Text = "Add New Entry";
            _btnAddNew.UseVisualStyleBackColor = false;
            // 
            // btnUpdateExisting
            // 
            _btnUpdateExisting.BackColor = Color.Yellow;
            _btnUpdateExisting.Font = new Font("Arial Narrow", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnUpdateExisting.ForeColor = SystemColors.ControlText;
            _btnUpdateExisting.Location = new Point(1099, 15);
            _btnUpdateExisting.Name = "_btnUpdateExisting";
            _btnUpdateExisting.Size = new Size(100, 23);
            _btnUpdateExisting.TabIndex = 217;
            _btnUpdateExisting.Text = "Update This Entry";
            _btnUpdateExisting.UseVisualStyleBackColor = false;
            _btnUpdateExisting.Visible = false;
            // 
            // btnDeleteSight
            // 
            _btnDeleteSight.BackColor = Color.Red;
            _btnDeleteSight.Font = new Font("Arial Narrow", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnDeleteSight.ForeColor = SystemColors.HighlightText;
            _btnDeleteSight.Location = new Point(1199, 16);
            _btnDeleteSight.Name = "_btnDeleteSight";
            _btnDeleteSight.Size = new Size(100, 23);
            _btnDeleteSight.TabIndex = 218;
            _btnDeleteSight.Text = "Delete This Entry";
            _btnDeleteSight.UseVisualStyleBackColor = false;
            _btnDeleteSight.Visible = false;
            // 
            // txtTo
            // 
            txtTo.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtTo.Location = new Point(835, 15);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(160, 22);
            txtTo.TabIndex = 7;
            ToolTip1.SetToolTip(txtTo, "Log Entry To Location Name " + '\r' + '\n' + "Required for all entries" + '\r' + '\n' + "Provides detailed waypoint" + ", route, and track " + '\r' + '\n' + "from / to location names on log and on GPX" + '\r' + '\n' + "export file." + '\r' + '\n');
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblTo.Location = new Point(806, 18);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(24, 15);
            lblTo.TabIndex = 6;
            lblTo.Text = "To:";
            lblTo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtFrom
            // 
            txtFrom.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtFrom.Location = new Point(644, 15);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(160, 22);
            txtFrom.TabIndex = 5;
            ToolTip1.SetToolTip(txtFrom, "Log Entry From Location Name " + '\r' + '\n' + "Required for all entries" + '\r' + '\n' + "Provides detailed waypoi" + "nt, route, and track " + '\r' + '\n' + "from / to location names on log and on GPX" + '\r' + '\n' + "export file.");
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblFrom.Location = new Point(604, 18);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(37, 15);
            lblFrom.TabIndex = 4;
            lblFrom.Text = "From:";
            lblFrom.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtNavigator
            // 
            txtNavigator.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtNavigator.Location = new Point(442, 15);
            txtNavigator.Name = "txtNavigator";
            txtNavigator.Size = new Size(160, 22);
            txtNavigator.TabIndex = 3;
            ToolTip1.SetToolTip(txtNavigator, "Vessel navigator name - required for all entries");
            // 
            // lblNavigator
            // 
            lblNavigator.AutoSize = true;
            lblNavigator.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblNavigator.Location = new Point(376, 18);
            lblNavigator.Name = "lblNavigator";
            lblNavigator.Size = new Size(63, 15);
            lblNavigator.TabIndex = 2;
            lblNavigator.Text = "Navigator:";
            lblNavigator.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtVessel
            // 
            txtVessel.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtVessel.Location = new Point(214, 15);
            txtVessel.Name = "txtVessel";
            txtVessel.Size = new Size(160, 22);
            txtVessel.TabIndex = 1;
            ToolTip1.SetToolTip(txtVessel, "Vessel Name - Required for all entries");
            // 
            // lblVessel
            // 
            lblVessel.AutoSize = true;
            lblVessel.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblVessel.Location = new Point(164, 18);
            lblVessel.Name = "lblVessel";
            lblVessel.Size = new Size(47, 15);
            lblVessel.TabIndex = 0;
            lblVessel.Text = "Vessel: ";
            lblVessel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Microsoft Sans Serif", 21.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label7.Location = new Point(450, 15);
            Label7.Name = "Label7";
            Label7.Size = new Size(509, 33);
            Label7.TabIndex = 9;
            Label7.Text = "Route Planning and Deck Log Form";
            // 
            // VesselDataGridViewTextBoxColumn
            // 
            VesselDataGridViewTextBoxColumn.DataPropertyName = "Vessel";
            VesselDataGridViewTextBoxColumn.HeaderText = "Vessel";
            VesselDataGridViewTextBoxColumn.Name = "VesselDataGridViewTextBoxColumn";
            VesselDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            VesselDataGridViewTextBoxColumn.Width = 49;
            // 
            // NavigatorDataGridViewTextBoxColumn
            // 
            NavigatorDataGridViewTextBoxColumn.DataPropertyName = "Navigator";
            NavigatorDataGridViewTextBoxColumn.HeaderText = "Navigator";
            NavigatorDataGridViewTextBoxColumn.Name = "NavigatorDataGridViewTextBoxColumn";
            NavigatorDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            NavigatorDataGridViewTextBoxColumn.Width = 66;
            // 
            // FromDataGridViewTextBoxColumn
            // 
            FromDataGridViewTextBoxColumn.DataPropertyName = "From";
            FromDataGridViewTextBoxColumn.HeaderText = "From";
            FromDataGridViewTextBoxColumn.Name = "FromDataGridViewTextBoxColumn";
            FromDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            FromDataGridViewTextBoxColumn.Width = 42;
            // 
            // ToDataGridViewTextBoxColumn
            // 
            ToDataGridViewTextBoxColumn.DataPropertyName = "To";
            ToDataGridViewTextBoxColumn.HeaderText = "To";
            ToDataGridViewTextBoxColumn.Name = "ToDataGridViewTextBoxColumn";
            ToDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            ToDataGridViewTextBoxColumn.Width = 26;
            // 
            // ZoneDateTimeDataGridViewTextBoxColumn
            // 
            ZoneDateTimeDataGridViewTextBoxColumn.DataPropertyName = "ZoneDateTime";
            ZoneDateTimeDataGridViewTextBoxColumn.HeaderText = "ZoneDateTime";
            ZoneDateTimeDataGridViewTextBoxColumn.Name = "ZoneDateTimeDataGridViewTextBoxColumn";
            ZoneDateTimeDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            ZoneDateTimeDataGridViewTextBoxColumn.Width = 93;
            // 
            // CompassDataGridViewTextBoxColumn
            // 
            CompassDataGridViewTextBoxColumn.DataPropertyName = "Compass";
            CompassDataGridViewTextBoxColumn.HeaderText = "Compass";
            CompassDataGridViewTextBoxColumn.Name = "CompassDataGridViewTextBoxColumn";
            CompassDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            CompassDataGridViewTextBoxColumn.Width = 62;
            // 
            // VarDataGridViewTextBoxColumn
            // 
            VarDataGridViewTextBoxColumn.DataPropertyName = "Var";
            VarDataGridViewTextBoxColumn.HeaderText = "Var";
            VarDataGridViewTextBoxColumn.Name = "VarDataGridViewTextBoxColumn";
            VarDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            VarDataGridViewTextBoxColumn.Width = 33;
            // 
            // DevDataGridViewTextBoxColumn
            // 
            DevDataGridViewTextBoxColumn.DataPropertyName = "Dev";
            DevDataGridViewTextBoxColumn.HeaderText = "Dev";
            DevDataGridViewTextBoxColumn.Name = "DevDataGridViewTextBoxColumn";
            DevDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            DevDataGridViewTextBoxColumn.Width = 33;
            // 
            // TrueDataGridViewTextBoxColumn
            // 
            TrueDataGridViewTextBoxColumn.DataPropertyName = "True";
            TrueDataGridViewTextBoxColumn.HeaderText = "True";
            TrueDataGridViewTextBoxColumn.Name = "TrueDataGridViewTextBoxColumn";
            TrueDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            TrueDataGridViewTextBoxColumn.Width = 39;
            // 
            // SpeedDataGridViewTextBoxColumn
            // 
            SpeedDataGridViewTextBoxColumn.DataPropertyName = "Speed";
            SpeedDataGridViewTextBoxColumn.HeaderText = "Speed";
            SpeedDataGridViewTextBoxColumn.Name = "SpeedDataGridViewTextBoxColumn";
            SpeedDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            SpeedDataGridViewTextBoxColumn.Width = 45;
            // 
            // LocLatLongDataGridViewTextBoxColumn
            // 
            LocLatLongDataGridViewTextBoxColumn.DataPropertyName = "Loc Lat Long";
            LocLatLongDataGridViewTextBoxColumn.HeaderText = "Loc Lat Long";
            LocLatLongDataGridViewTextBoxColumn.Name = "LocLatLongDataGridViewTextBoxColumn";
            LocLatLongDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            LocLatLongDataGridViewTextBoxColumn.Width = 85;
            // 
            // LocTypeDataGridViewTextBoxColumn
            // 
            LocTypeDataGridViewTextBoxColumn.DataPropertyName = "LocType";
            LocTypeDataGridViewTextBoxColumn.HeaderText = "LocType";
            LocTypeDataGridViewTextBoxColumn.Name = "LocTypeDataGridViewTextBoxColumn";
            LocTypeDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            LocTypeDataGridViewTextBoxColumn.Width = 58;
            // 
            // WeatherDataGridViewTextBoxColumn
            // 
            WeatherDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            WeatherDataGridViewTextBoxColumn.DataPropertyName = "Weather";
            DataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.TopLeft;
            DataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            WeatherDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle13;
            WeatherDataGridViewTextBoxColumn.HeaderText = "Weather";
            WeatherDataGridViewTextBoxColumn.MinimumWidth = 100;
            WeatherDataGridViewTextBoxColumn.Name = "WeatherDataGridViewTextBoxColumn";
            WeatherDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // RemarksDataGridViewTextBoxColumn
            // 
            RemarksDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            RemarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks";
            DataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.TopLeft;
            DataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            RemarksDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle14;
            RemarksDataGridViewTextBoxColumn.HeaderText = "Remarks";
            RemarksDataGridViewTextBoxColumn.MinimumWidth = 100;
            RemarksDataGridViewTextBoxColumn.Name = "RemarksDataGridViewTextBoxColumn";
            RemarksDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ActualLoc
            // 
            ActualLoc.DataPropertyName = "Calc'd Loc";
            ActualLoc.HeaderText = "Calc'd Loc";
            ActualLoc.Name = "ActualLoc";
            ActualLoc.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn1
            // 
            DataGridViewTextBoxColumn1.DataPropertyName = "CMG";
            DataGridViewTextBoxColumn1.HeaderText = "CMG";
            DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // VesselDataGridViewTextBoxColumn1
            // 
            VesselDataGridViewTextBoxColumn1.DataPropertyName = "Vessel";
            VesselDataGridViewTextBoxColumn1.HeaderText = "Vessel";
            VesselDataGridViewTextBoxColumn1.Name = "VesselDataGridViewTextBoxColumn1";
            VesselDataGridViewTextBoxColumn1.Width = 68;
            // 
            // NavigatorDataGridViewTextBoxColumn1
            // 
            NavigatorDataGridViewTextBoxColumn1.DataPropertyName = "Navigator";
            NavigatorDataGridViewTextBoxColumn1.HeaderText = "Navigator";
            NavigatorDataGridViewTextBoxColumn1.Name = "NavigatorDataGridViewTextBoxColumn1";
            NavigatorDataGridViewTextBoxColumn1.Width = 85;
            // 
            // FromDataGridViewTextBoxColumn1
            // 
            FromDataGridViewTextBoxColumn1.DataPropertyName = "From";
            FromDataGridViewTextBoxColumn1.HeaderText = "From";
            FromDataGridViewTextBoxColumn1.Name = "FromDataGridViewTextBoxColumn1";
            FromDataGridViewTextBoxColumn1.Width = 61;
            // 
            // ToDataGridViewTextBoxColumn1
            // 
            ToDataGridViewTextBoxColumn1.DataPropertyName = "To";
            ToDataGridViewTextBoxColumn1.HeaderText = "To";
            ToDataGridViewTextBoxColumn1.Name = "ToDataGridViewTextBoxColumn1";
            ToDataGridViewTextBoxColumn1.Width = 45;
            // 
            // LocTypeDataGridViewTextBoxColumn1
            // 
            LocTypeDataGridViewTextBoxColumn1.DataPropertyName = "LocType";
            LocTypeDataGridViewTextBoxColumn1.HeaderText = "LocType";
            LocTypeDataGridViewTextBoxColumn1.Name = "LocTypeDataGridViewTextBoxColumn1";
            LocTypeDataGridViewTextBoxColumn1.Width = 77;
            // 
            // ZoneDateTimeDataGridViewTextBoxColumn1
            // 
            ZoneDateTimeDataGridViewTextBoxColumn1.DataPropertyName = "ZoneDateTime";
            ZoneDateTimeDataGridViewTextBoxColumn1.HeaderText = "ZoneDateTime";
            ZoneDateTimeDataGridViewTextBoxColumn1.Name = "ZoneDateTimeDataGridViewTextBoxColumn1";
            ZoneDateTimeDataGridViewTextBoxColumn1.Width = 112;
            // 
            // CompassDataGridViewTextBoxColumn1
            // 
            CompassDataGridViewTextBoxColumn1.DataPropertyName = "Compass";
            CompassDataGridViewTextBoxColumn1.HeaderText = "Compass";
            CompassDataGridViewTextBoxColumn1.Name = "CompassDataGridViewTextBoxColumn1";
            CompassDataGridViewTextBoxColumn1.Width = 81;
            // 
            // VarDataGridViewTextBoxColumn1
            // 
            VarDataGridViewTextBoxColumn1.DataPropertyName = "Var";
            VarDataGridViewTextBoxColumn1.HeaderText = "Var";
            VarDataGridViewTextBoxColumn1.Name = "VarDataGridViewTextBoxColumn1";
            VarDataGridViewTextBoxColumn1.Width = 52;
            // 
            // DevDataGridViewTextBoxColumn1
            // 
            DevDataGridViewTextBoxColumn1.DataPropertyName = "Dev";
            DevDataGridViewTextBoxColumn1.HeaderText = "Dev";
            DevDataGridViewTextBoxColumn1.Name = "DevDataGridViewTextBoxColumn1";
            DevDataGridViewTextBoxColumn1.Width = 52;
            // 
            // TrueDataGridViewTextBoxColumn1
            // 
            TrueDataGridViewTextBoxColumn1.DataPropertyName = "True";
            TrueDataGridViewTextBoxColumn1.HeaderText = "True";
            TrueDataGridViewTextBoxColumn1.Name = "TrueDataGridViewTextBoxColumn1";
            TrueDataGridViewTextBoxColumn1.Width = 58;
            // 
            // SpeedDataGridViewTextBoxColumn1
            // 
            SpeedDataGridViewTextBoxColumn1.DataPropertyName = "Speed";
            SpeedDataGridViewTextBoxColumn1.HeaderText = "Speed";
            SpeedDataGridViewTextBoxColumn1.Name = "SpeedDataGridViewTextBoxColumn1";
            SpeedDataGridViewTextBoxColumn1.Width = 64;
            // 
            // LocLatLongDataGridViewTextBoxColumn1
            // 
            LocLatLongDataGridViewTextBoxColumn1.DataPropertyName = "Loc Lat Long";
            LocLatLongDataGridViewTextBoxColumn1.HeaderText = "Loc Lat Long";
            LocLatLongDataGridViewTextBoxColumn1.Name = "LocLatLongDataGridViewTextBoxColumn1";
            LocLatLongDataGridViewTextBoxColumn1.Width = 104;
            // 
            // WeatherDataGridViewTextBoxColumn1
            // 
            WeatherDataGridViewTextBoxColumn1.DataPropertyName = "Weather";
            WeatherDataGridViewTextBoxColumn1.HeaderText = "Weather";
            WeatherDataGridViewTextBoxColumn1.Name = "WeatherDataGridViewTextBoxColumn1";
            WeatherDataGridViewTextBoxColumn1.Width = 79;
            // 
            // RemarksDataGridViewTextBoxColumn1
            // 
            RemarksDataGridViewTextBoxColumn1.DataPropertyName = "Remarks";
            RemarksDataGridViewTextBoxColumn1.HeaderText = "Remarks";
            RemarksDataGridViewTextBoxColumn1.Name = "RemarksDataGridViewTextBoxColumn1";
            RemarksDataGridViewTextBoxColumn1.Width = 83;
            // 
            // TimetoDest
            // 
            TimetoDest.DataPropertyName = "ElapsedTime";
            TimetoDest.HeaderText = "TimeToDest";
            TimetoDest.Name = "TimetoDest";
            TimetoDest.ReadOnly = true;
            TimetoDest.Width = 98;
            // 
            // btnStartFresh
            // 
            _btnStartFresh.BackColor = Color.Yellow;
            _btnStartFresh.ForeColor = Color.Black;
            _btnStartFresh.Location = new Point(1046, 33);
            _btnStartFresh.Name = "_btnStartFresh";
            _btnStartFresh.Size = new Size(118, 23);
            _btnStartFresh.TabIndex = 11;
            _btnStartFresh.Text = "Start New Deck Log";
            _btnStartFresh.UseVisualStyleBackColor = false;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.ABC_white;
            PictureBox1.Location = new Point(10, 8);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(304, 71);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 13;
            PictureBox1.TabStop = false;
            // 
            // btnEvalDG
            // 
            _btnEvalDG.BackColor = Color.Blue;
            _btnEvalDG.ForeColor = Color.White;
            _btnEvalDG.Location = new Point(1170, 8);
            _btnEvalDG.Name = "_btnEvalDG";
            _btnEvalDG.Size = new Size(118, 23);
            _btnEvalDG.TabIndex = 14;
            _btnEvalDG.Text = "Evaluate Log Entries";
            _btnEvalDG.UseVisualStyleBackColor = false;
            _btnEvalDG.Visible = false;
            // 
            // btnExportGPX
            // 
            _btnExportGPX.BackColor = Color.Blue;
            _btnExportGPX.ForeColor = Color.White;
            _btnExportGPX.Location = new Point(1170, 56);
            _btnExportGPX.Name = "_btnExportGPX";
            _btnExportGPX.Size = new Size(118, 23);
            _btnExportGPX.TabIndex = 15;
            _btnExportGPX.Text = "Export Data to GPX";
            _btnExportGPX.UseVisualStyleBackColor = false;
            _btnExportGPX.Visible = false;
            // 
            // DeckLogUpdate
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1413, 879);
            Controls.Add(_btnExportGPX);
            Controls.Add(_btnEvalDG);
            Controls.Add(PictureBox1);
            Controls.Add(_btnStartFresh);
            Controls.Add(Label7);
            Controls.Add(GroupBox1);
            Controls.Add(_btnInfoForm);
            Controls.Add(_btnSaveFile);
            Controls.Add(txtOpenFN);
            Controls.Add(lblOpenFN);
            Controls.Add(_btnOpenCSV);
            Controls.Add(_btnExitNoSave);
            Controls.Add(_btnExit);
            Controls.Add(_DataGridView1);
            Name = "DeckLogUpdate";
            Text = "Deck Log Updater";
            ((System.ComponentModel.ISupportInitialize)_DataGridView1).EndInit();
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            grpLogNotes.ResumeLayout(false);
            grpLogNotes.PerformLayout();
            grpWeather.ResumeLayout(false);
            grpWeather.PerformLayout();
            grpAdvInfo.ResumeLayout(false);
            grpAdvInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cboAdvMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)cboAdvHrs).EndInit();
            ((System.ComponentModel.ISupportInitialize)cboAdvNm).EndInit();
            grpLogEntryInfo.ResumeLayout(false);
            grpLogEntryInfo.PerformLayout();
            grpbxPlan.ResumeLayout(false);
            grpbxPlan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Load += new EventHandler(FormDeckLogUpdate_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView _DataGridView1;

        internal DataGridView DataGridView1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _DataGridView1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_DataGridView1 != null)
                {
                    _DataGridView1.SelectionChanged -= DataGridView1_SelectionChanged;
                }

                _DataGridView1 = value;
                if (_DataGridView1 != null)
                {
                    _DataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
                }
            }
        }

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

        private Button _btnExitNoSave;

        internal Button btnExitNoSave
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnExitNoSave;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnExitNoSave != null)
                {
                    _btnExitNoSave.Click -= btnExitNoSave_Click;
                }

                _btnExitNoSave = value;
                if (_btnExitNoSave != null)
                {
                    _btnExitNoSave.Click += btnExitNoSave_Click;
                }
            }
        }

        internal DataGridViewTextBoxColumn CommonNameDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn CommonNameDataGridViewTextBoxColumn2;
        internal DataGridViewTextBoxColumn WebLocationDataGridViewTextBoxColumn1;
        private Button _btnOpenCSV;

        internal Button btnOpenCSV
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnOpenCSV;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnOpenCSV != null)
                {
                    _btnOpenCSV.Click -= btnOpenCSV_Click;
                }

                _btnOpenCSV = value;
                if (_btnOpenCSV != null)
                {
                    _btnOpenCSV.Click += btnOpenCSV_Click;
                }
            }
        }

        internal Label lblOpenFN;
        internal TextBox txtOpenFN;
        private Button _btnSaveFile;

        internal Button btnSaveFile
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSaveFile;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSaveFile != null)
                {
                    _btnSaveFile.Click -= btnSaveFile_Click;
                }

                _btnSaveFile = value;
                if (_btnSaveFile != null)
                {
                    _btnSaveFile.Click += btnSaveFile_Click;
                }
            }
        }

        private Button _btnInfoForm;

        internal Button btnInfoForm
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnInfoForm;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnInfoForm != null)
                {
                    _btnInfoForm.Click -= btnInfoForm_Click;
                }

                _btnInfoForm = value;
                if (_btnInfoForm != null)
                {
                    _btnInfoForm.Click += btnInfoForm_Click;
                }
            }
        }

        internal GroupBox GroupBox1;
        internal Label Label1;
        private TextBox _txtCompass;

        internal TextBox txtCompass
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
                    _txtCompass.TextChanged -= txtCompass_TextChanged;
                    _txtCompass.KeyPress -= txtCompass_KeyPress;
                }

                _txtCompass = value;
                if (_txtCompass != null)
                {
                    _txtCompass.TextChanged += txtCompass_TextChanged;
                    _txtCompass.KeyPress += txtCompass_KeyPress;
                }
            }
        }

        internal Label lblCompass;
        private DateTimePicker _DTDateZoneTime;

        internal DateTimePicker DTDateZoneTime
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _DTDateZoneTime;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_DTDateZoneTime != null)
                {
                    _DTDateZoneTime.ValueChanged -= DTDateZoneTime_ValueChanged;
                }

                _DTDateZoneTime = value;
                if (_DTDateZoneTime != null)
                {
                    _DTDateZoneTime.ValueChanged += DTDateZoneTime_ValueChanged;
                }
            }
        }

        internal TextBox txtTo;
        internal Label lblTo;
        internal TextBox txtFrom;
        internal Label lblFrom;
        internal TextBox txtNavigator;
        internal Label lblNavigator;
        internal TextBox txtVessel;
        internal Label lblVessel;
        internal TextBox txtVar;
        internal Label lblVariation;
        public Label Label6;
        internal ComboBox cboDev;
        internal TextBox txtDev;
        internal Label lblDev;
        internal ComboBox cboVar;
        public Label Label3;
        public Label Label2;
        internal TextBox txtSpeed;
        internal Label lblSpeed;
        public Label Label4;
        private TextBox _txtCTrue;

        internal TextBox txtCTrue
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtCTrue;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtCTrue != null)
                {
                    _txtCTrue.TextChanged -= txtCTrue_TextChanged;
                    _txtCTrue.KeyPress -= txtCTrue_KeyPress;
                }

                _txtCTrue = value;
                if (_txtCTrue != null)
                {
                    _txtCTrue.TextChanged += txtCTrue_TextChanged;
                    _txtCTrue.KeyPress += txtCTrue_KeyPress;
                }
            }
        }

        internal Label lblCTrue;
        internal TextBox txtRemarks;
        internal TextBox txtWeather;
        public ComboBox cboLo;
        public ComboBox cboL;
        public TextBox txtLDeg;
        public TextBox txtLoMin;
        public TextBox txtLoDeg;
        public TextBox txtLMin;
        public Label lblLoMin;
        public Label lblLoDeg;
        public Label lblDRLo;
        public Label lblLMin;
        public Label lblLDeg;
        public Label lblDRL;
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

        private ComboBox _cboLocType;

        internal ComboBox cboLocType
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboLocType;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboLocType != null)
                {
                    _cboLocType.SelectedIndexChanged -= cboLocType_SelectedIndexChanged;
                }

                _cboLocType = value;
                if (_cboLocType != null)
                {
                    _cboLocType.SelectedIndexChanged += cboLocType_SelectedIndexChanged;
                }
            }
        }

        public Label Label5;
        internal Label Label7;
        internal DataGridViewTextBoxColumn VesselDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn NavigatorDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn FromDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn ToDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn ZoneDateTimeDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn CompassDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn VarDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn DevDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn TrueDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn SpeedDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn LocLatLongDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn LocTypeDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn WeatherDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn RemarksDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn ActualLoc;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn VesselDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn NavigatorDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn FromDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn ToDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn LocTypeDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn ZoneDateTimeDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn CompassDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn VarDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn DevDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn TrueDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn SpeedDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn LocLatLongDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn WeatherDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn RemarksDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn TimetoDest;
        internal Button btnEval;
        internal GroupBox grpbxPlan;
        internal TextBox txtDestElapsed;
        internal Label Label17;
        internal TextBox txtDestDist;
        internal Label Label16;
        internal TextBox txtDestTrue;
        internal Label Label15;
        public ComboBox cboDestLo;
        public ComboBox cboDestL;
        public TextBox txtDestLDeg;
        public TextBox txtDestLoMin;
        public TextBox txtDestLoDeg;
        public TextBox txtDestLMin;
        public Label Label8;
        public Label Label9;
        public Label Label10;
        public Label Label11;
        public Label Label12;
        public Label Label13;
        private CheckBox _chkHideFirst4Col;

        internal CheckBox chkHideFirst4Col
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _chkHideFirst4Col;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_chkHideFirst4Col != null)
                {
                    _chkHideFirst4Col.CheckedChanged -= chkHideFirst4Col_CheckedChanged;
                }

                _chkHideFirst4Col = value;
                if (_chkHideFirst4Col != null)
                {
                    _chkHideFirst4Col.CheckedChanged += chkHideFirst4Col_CheckedChanged;
                }
            }
        }

        internal TextBox txtEstArrival;
        internal Label lblEstArrival;
        private Button _btnStartFresh;

        internal Button btnStartFresh
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnStartFresh;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnStartFresh != null)
                {
                    _btnStartFresh.Click -= btnStartFresh_Click;
                }

                _btnStartFresh = value;
                if (_btnStartFresh != null)
                {
                    _btnStartFresh.Click += btnStartFresh_Click;
                }
            }
        }

        internal PictureBox PictureBox1;
        private Button _btnEvalDG;

        internal Button btnEvalDG
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnEvalDG;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnEvalDG != null)
                {
                    _btnEvalDG.Click -= btnEvalDG_Click;
                }

                _btnEvalDG = value;
                if (_btnEvalDG != null)
                {
                    _btnEvalDG.Click += btnEvalDG_Click;
                }
            }
        }

        private Button _btnExportGPX;

        internal Button btnExportGPX
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnExportGPX;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnExportGPX != null)
                {
                    _btnExportGPX.Click -= btnExportGPX_Click;
                }

                _btnExportGPX = value;
                if (_btnExportGPX != null)
                {
                    _btnExportGPX.Click += btnExportGPX_Click;
                }
            }
        }

        private LinkLabel _linkLblNOAAVar;

        internal LinkLabel linkLblNOAAVar
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _linkLblNOAAVar;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_linkLblNOAAVar != null)
                {
                    _linkLblNOAAVar.LinkClicked -= linkLblNOAAVar_LinkClicked;
                }

                _linkLblNOAAVar = value;
                if (_linkLblNOAAVar != null)
                {
                    _linkLblNOAAVar.LinkClicked += linkLblNOAAVar_LinkClicked;
                }
            }
        }

        internal TextBox txtTypeDesc;
        private Button _btnUseTVMDC;

        internal Button btnUseTVMDC
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnUseTVMDC;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnUseTVMDC != null)
                {
                    _btnUseTVMDC.Click -= btnUseTVMDC_Click;
                }

                _btnUseTVMDC = value;
                if (_btnUseTVMDC != null)
                {
                    _btnUseTVMDC.Click += btnUseTVMDC_Click;
                }
            }
        }

        private Button _btnUseZTInfoForm;

        internal Button btnUseZTInfoForm
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnUseZTInfoForm;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnUseZTInfoForm != null)
                {
                    _btnUseZTInfoForm.Click -= btnUseZTInfoForm_Click;
                }

                _btnUseZTInfoForm = value;
                if (_btnUseZTInfoForm != null)
                {
                    _btnUseZTInfoForm.Click += btnUseZTInfoForm_Click;
                }
            }
        }

        private ComboBox _cboDisplayRows;

        internal ComboBox cboDisplayRows
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboDisplayRows;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboDisplayRows != null)
                {
                    _cboDisplayRows.SelectedIndexChanged -= cboDisplayRows_SelectedIndexChanged;
                }

                _cboDisplayRows = value;
                if (_cboDisplayRows != null)
                {
                    _cboDisplayRows.SelectedIndexChanged += cboDisplayRows_SelectedIndexChanged;
                }
            }
        }

        public Label Label14;
        private CheckBox _chkDev;

        internal CheckBox chkDev
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

        public Label Label18;
        protected internal Label lblZoneDT;
        internal ToolTip ToolTip1;
        internal Label lblAdvHrMin;
        internal NumericUpDown cboAdvMin;
        internal NumericUpDown cboAdvHrs;
        private CheckBox _chkPlanGCR;

        internal CheckBox chkPlanGCR
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _chkPlanGCR;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_chkPlanGCR != null)
                {
                    _chkPlanGCR.CheckedChanged -= chkPlanGCR_CheckedChanged;
                }

                _chkPlanGCR = value;
                if (_chkPlanGCR != null)
                {
                    _chkPlanGCR.CheckedChanged += chkPlanGCR_CheckedChanged;
                }
            }
        }

        internal NumericUpDown cboAdvNm;
        internal Label lblAdvNm;
        private ComboBox _cboAdvType;

        internal ComboBox cboAdvType
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboAdvType;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboAdvType != null)
                {
                    _cboAdvType.SelectedIndexChanged -= cboAdvType_SelectedIndexChanged;
                }

                _cboAdvType = value;
                if (_cboAdvType != null)
                {
                    _cboAdvType.SelectedIndexChanged += cboAdvType_SelectedIndexChanged;
                }
            }
        }

        internal CheckBox chkImportGCR;
        internal GroupBox grpAdvInfo;
        internal GroupBox grpLogEntryInfo;
        internal Label Label19;
        internal TextBox txtZD;
        internal Label Label20;
        internal TextBox txtDestZD;
        internal Label lblKnotLog;
        internal TextBox txtKnotLog;
        internal GroupBox grpLogNotes;
        internal GroupBox grpWeather;
        internal Label lblWind;
        internal TextBox txtSeas;
        internal Label lbWaves;
        internal TextBox txtWind;
        internal ComboBox cboWindDir;
        internal Label lblWind2;
        internal CheckBox chkUseForEval;
    }
}