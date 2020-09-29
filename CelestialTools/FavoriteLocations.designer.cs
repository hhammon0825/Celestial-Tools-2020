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
    public partial class FavoriteLocations : Form
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
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblName = new Label();
            txtName = new TextBox();
            txtSightNum = new TextBox();
            lblSightNum = new Label();
            _btnExit = new Button();
            _btnExit.Click += new EventHandler(btnExit_Click);
            txtHE = new TextBox();
            lblHE = new Label();
            cboLo = new ComboBox();
            cboL = new ComboBox();
            txtLDeg = new TextBox();
            txtLoMin = new TextBox();
            txtLoDeg = new TextBox();
            txtLMin = new TextBox();
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
            _btnAddNew = new Button();
            _btnAddNew.Click += new EventHandler(btnAddNew_Click);
            _btnUpdateExisting = new Button();
            _btnUpdateExisting.Click += new EventHandler(btnUpdateExisting_Click);
            _btnDeleteSight = new Button();
            _btnDeleteSight.Click += new EventHandler(btnDeleteSight_Click);
            _btnNewLog = new Button();
            _btnNewLog.Click += new EventHandler(btnNewLog_Click);
            _SEDataGrid = new DataGridView();
            _SEDataGrid.SelectionChanged += new EventHandler(SEDataGrid_SelectionChanged);
            SightNum = new DataGridViewTextBoxColumn();
            PsnName = new DataGridViewTextBoxColumn();
            DRLat = new DataGridViewTextBoxColumn();
            DRLong = new DataGridViewTextBoxColumn();
            ZD = new DataGridViewTextBoxColumn();
            SDST = new DataGridViewTextBoxColumn();
            FromAZ = new DataGridViewTextBoxColumn();
            ToAZ = new DataGridViewTextBoxColumn();
            HorType = new DataGridViewTextBoxColumn();
            HorDist = new DataGridViewTextBoxColumn();
            HE = new DataGridViewTextBoxColumn();
            HorDistType = new DataGridViewTextBoxColumn();
            HSIEFormat = new DataGridViewTextBoxColumn();
            lblUSPSSightLog = new Label();
            lblZD = new Label();
            _cboZD = new ComboBox();
            _cboZD.SelectedIndexChanged += new EventHandler(cboZD_SelectedIndexChanged);
            _btnClearFields = new Button();
            _btnClearFields.Click += new EventHandler(btnClearFields_Click);
            grpSightButtons = new GroupBox();
            _btnShowSharedLoc = new Button();
            _btnShowSharedLoc.Click += new EventHandler(btnShowSharedLoc_Click);
            _btnClearShared = new Button();
            _btnClearShared.Click += new EventHandler(btnClearShared_Click);
            _btnUseLocation = new Button();
            _btnUseLocation.Click += new EventHandler(btnUseLocation_Click);
            Label4 = new Label();
            grpFileButtons = new GroupBox();
            _btnSLReport = new Button();
            _btnSLReport.Click += new EventHandler(btnSLReport_Click);
            _btnPrintDG = new Button();
            _btnPrintDG.Click += new EventHandler(btnPrintDG_Click);
            PrintDialog1 = new PrintDialog();
            _PrintDocument1 = new PrintDocument();
            _PrintDocument1.BeginPrint += new PrintEventHandler(PrintDocument1_BeginPrint);
            _PrintDocument1.PrintPage += new PrintPageEventHandler(PrintDocument1_PrintPage);
            cboHEUnit = new ComboBox();
            lblHSIEFmt = new Label();
            _cboHSIEFmt = new ComboBox();
            _cboHSIEFmt.SelectedIndexChanged += new EventHandler(cboHSIEFmt_SelectedIndexChanged);
            cboApprxBrg = new ComboBox();
            lblApprxBrg = new Label();
            txtFromAZ = new TextBox();
            Label2 = new Label();
            LblFromAZ = new Label();
            txtToAZ = new TextBox();
            Label3 = new Label();
            lblToAZ = new Label();
            chkbxSharedLoc = new CheckBox();
            PictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)_SEDataGrid).BeginInit();
            grpSightButtons.SuspendLayout();
            grpFileButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblName.Location = new Point(130, 40);
            lblName.Name = "lblName";
            lblName.Size = new Size(87, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Location Name";
            // 
            // txtName
            // 
            txtName.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtName.HideSelection = false;
            txtName.Location = new Point(227, 38);
            txtName.Name = "txtName";
            txtName.Size = new Size(391, 22);
            txtName.TabIndex = 1;
            // 
            // txtSightNum
            // 
            txtSightNum.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtSightNum.Location = new Point(66, 36);
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
            lblSightNum.Location = new Point(6, 39);
            lblSightNum.Name = "lblSightNum";
            lblSightNum.Size = new Size(49, 15);
            lblSightNum.TabIndex = 4;
            lblSightNum.Text = "Loc No.";
            // 
            // btnExit
            // 
            _btnExit.BackColor = Color.Red;
            _btnExit.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnExit.ForeColor = SystemColors.ControlLightLight;
            _btnExit.Location = new Point(915, 96);
            _btnExit.Name = "_btnExit";
            _btnExit.Size = new Size(75, 23);
            _btnExit.TabIndex = 14;
            _btnExit.Text = "Exit";
            _btnExit.UseVisualStyleBackColor = false;
            // 
            // txtHE
            // 
            txtHE.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtHE.HideSelection = false;
            txtHE.Location = new Point(64, 100);
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
            lblHE.Location = new Point(37, 103);
            lblHE.Name = "lblHE";
            lblHE.Size = new Size(23, 15);
            lblHE.TabIndex = 18;
            lblHE.Text = "HE";
            // 
            // cboLo
            // 
            cboLo.BackColor = SystemColors.Window;
            cboLo.Cursor = Cursors.Default;
            cboLo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLo.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboLo.ForeColor = SystemColors.WindowText;
            cboLo.Items.AddRange(new object[] { "W", "E" });
            cboLo.Location = new Point(943, 37);
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
            cboL.Location = new Point(744, 37);
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
            txtLDeg.Location = new Point(672, 37);
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
            txtLoMin.Location = new Point(899, 38);
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
            txtLoDeg.Location = new Point(857, 38);
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
            txtLMin.Location = new Point(704, 37);
            txtLMin.MaxLength = 4;
            txtLMin.Name = "txtLMin";
            txtLMin.RightToLeft = RightToLeft.No;
            txtLMin.Size = new Size(33, 22);
            txtLMin.TabIndex = 40;
            // 
            // lblLoMin
            // 
            lblLoMin.BackColor = SystemColors.Window;
            lblLoMin.Cursor = Cursors.Default;
            lblLoMin.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLoMin.ForeColor = SystemColors.ControlText;
            lblLoMin.Location = new Point(932, 39);
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
            lblLoDeg.Location = new Point(890, 39);
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
            lblDRLo.Location = new Point(791, 41);
            lblDRLo.Name = "lblDRLo";
            lblDRLo.RightToLeft = RightToLeft.No;
            lblDRLo.Size = new Size(60, 16);
            lblDRLo.TabIndex = 129;
            lblDRLo.Text = "DR Long";
            // 
            // lblLMin
            // 
            lblLMin.BackColor = SystemColors.Window;
            lblLMin.Cursor = Cursors.Default;
            lblLMin.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLMin.ForeColor = SystemColors.ControlText;
            lblLMin.Location = new Point(737, 36);
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
            lblLDeg.Location = new Point(696, 37);
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
            lblDRL.Location = new Point(619, 41);
            lblDRL.Name = "lblDRL";
            lblDRL.RightToLeft = RightToLeft.No;
            lblDRL.Size = new Size(50, 16);
            lblDRL.TabIndex = 123;
            lblDRL.Text = "DR Lat";
            // 
            // lblHorType
            // 
            lblHorType.AutoSize = true;
            lblHorType.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblHorType.Location = new Point(482, 70);
            lblHorType.Name = "lblHorType";
            lblHorType.Size = new Size(49, 15);
            lblHorType.TabIndex = 137;
            lblHorType.Text = "Horizon";
            // 
            // cbHorizon
            // 
            _cbHorizon.BackColor = SystemColors.Window;
            _cbHorizon.DropDownStyle = ComboBoxStyle.DropDownList;
            _cbHorizon.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cbHorizon.FormattingEnabled = true;
            _cbHorizon.Items.AddRange(new object[] { "Natural", "Dip Short", "Artificial", "Bubble" });
            _cbHorizon.Location = new Point(537, 66);
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
            cbHorDistType.Location = new Point(792, 67);
            cbHorDistType.Name = "cbHorDistType";
            cbHorDistType.Size = new Size(90, 23);
            cbHorDistType.TabIndex = 105;
            cbHorDistType.Visible = false;
            // 
            // lblDistance
            // 
            lblDistance.AutoSize = true;
            lblDistance.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblDistance.Location = new Point(627, 71);
            lblDistance.Name = "lblDistance";
            lblDistance.Size = new Size(72, 15);
            lblDistance.TabIndex = 139;
            lblDistance.Text = "Ds Distance";
            lblDistance.Visible = false;
            // 
            // txtHorDist
            // 
            txtHorDist.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtHorDist.HideSelection = false;
            txtHorDist.Location = new Point(709, 68);
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
            _chkbxDST.Location = new Point(168, 68);
            _chkbxDST.Name = "_chkbxDST";
            _chkbxDST.Size = new Size(50, 19);
            _chkbxDST.TabIndex = 25;
            _chkbxDST.Text = "DST";
            _chkbxDST.UseVisualStyleBackColor = true;
            // 
            // btnOpenLog
            // 
            _btnOpenLog.BackColor = SystemColors.HotTrack;
            _btnOpenLog.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnOpenLog.ForeColor = SystemColors.HighlightText;
            _btnOpenLog.Location = new Point(115, 13);
            _btnOpenLog.Name = "_btnOpenLog";
            _btnOpenLog.Size = new Size(160, 23);
            _btnOpenLog.TabIndex = 145;
            _btnOpenLog.Text = "Open Existing File";
            _btnOpenLog.UseVisualStyleBackColor = false;
            // 
            // btnSaveLog
            // 
            _btnSaveLog.BackColor = SystemColors.HotTrack;
            _btnSaveLog.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnSaveLog.ForeColor = SystemColors.HighlightText;
            _btnSaveLog.Location = new Point(281, 13);
            _btnSaveLog.Name = "_btnSaveLog";
            _btnSaveLog.Size = new Size(160, 23);
            _btnSaveLog.TabIndex = 146;
            _btnSaveLog.Text = "Save This File";
            _btnSaveLog.UseVisualStyleBackColor = false;
            // 
            // btnAddNew
            // 
            _btnAddNew.BackColor = Color.Yellow;
            _btnAddNew.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnAddNew.ForeColor = SystemColors.ControlText;
            _btnAddNew.Location = new Point(32, 12);
            _btnAddNew.Name = "_btnAddNew";
            _btnAddNew.Size = new Size(120, 23);
            _btnAddNew.TabIndex = 148;
            _btnAddNew.Text = "Add Location";
            _btnAddNew.UseVisualStyleBackColor = false;
            // 
            // btnUpdateExisting
            // 
            _btnUpdateExisting.BackColor = Color.Yellow;
            _btnUpdateExisting.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnUpdateExisting.ForeColor = SystemColors.ControlText;
            _btnUpdateExisting.Location = new Point(156, 12);
            _btnUpdateExisting.Name = "_btnUpdateExisting";
            _btnUpdateExisting.Size = new Size(120, 23);
            _btnUpdateExisting.TabIndex = 149;
            _btnUpdateExisting.Text = "Update Location";
            _btnUpdateExisting.UseVisualStyleBackColor = false;
            // 
            // btnDeleteSight
            // 
            _btnDeleteSight.BackColor = Color.Red;
            _btnDeleteSight.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnDeleteSight.ForeColor = SystemColors.HighlightText;
            _btnDeleteSight.Location = new Point(410, 12);
            _btnDeleteSight.Name = "_btnDeleteSight";
            _btnDeleteSight.Size = new Size(120, 23);
            _btnDeleteSight.TabIndex = 150;
            _btnDeleteSight.Text = "Delete Location";
            _btnDeleteSight.UseVisualStyleBackColor = false;
            // 
            // btnNewLog
            // 
            _btnNewLog.BackColor = SystemColors.HotTrack;
            _btnNewLog.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnNewLog.ForeColor = SystemColors.HighlightText;
            _btnNewLog.Location = new Point(448, 13);
            _btnNewLog.Name = "_btnNewLog";
            _btnNewLog.Size = new Size(160, 23);
            _btnNewLog.TabIndex = 151;
            _btnNewLog.Text = "Start A New File";
            _btnNewLog.UseVisualStyleBackColor = false;
            // 
            // SEDataGrid
            // 
            _SEDataGrid.AllowUserToAddRows = false;
            _SEDataGrid.AllowUserToDeleteRows = false;
            _SEDataGrid.AllowUserToResizeColumns = false;
            _SEDataGrid.AllowUserToResizeRows = false;
            _SEDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            _SEDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            _SEDataGrid.BorderStyle = BorderStyle.Fixed3D;
            _SEDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            _SEDataGrid.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle1.BackColor = SystemColors.Control;
            DataGridViewCellStyle1.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            _SEDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1;
            _SEDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _SEDataGrid.Columns.AddRange(new DataGridViewColumn[] { SightNum, PsnName, DRLat, DRLong, ZD, SDST, FromAZ, ToAZ, HorType, HorDist, HE, HorDistType, HSIEFormat });
            _SEDataGrid.Location = new Point(6, 220);
            _SEDataGrid.Name = "_SEDataGrid";
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = SystemColors.Control;
            DataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            _SEDataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle2;
            _SEDataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            _SEDataGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Blue;
            _SEDataGrid.Size = new Size(984, 367);
            _SEDataGrid.TabIndex = 161;
            // 
            // SightNum
            // 
            SightNum.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SightNum.Frozen = true;
            SightNum.HeaderText = "No";
            SightNum.MaxInputLength = 5;
            SightNum.MinimumWidth = 3;
            SightNum.Name = "SightNum";
            SightNum.ReadOnly = true;
            SightNum.Width = 48;
            // 
            // PsnName
            // 
            PsnName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            PsnName.HeaderText = "Name";
            PsnName.Name = "PsnName";
            PsnName.ReadOnly = true;
            PsnName.Width = 62;
            // 
            // DRLat
            // 
            DRLat.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DRLat.HeaderText = "DR Lat";
            DRLat.Name = "DRLat";
            DRLat.ReadOnly = true;
            DRLat.Width = 69;
            // 
            // DRLong
            // 
            DRLong.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DRLong.HeaderText = "DR Long";
            DRLong.Name = "DRLong";
            DRLong.ReadOnly = true;
            DRLong.Width = 80;
            // 
            // ZD
            // 
            ZD.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ZD.HeaderText = "ZD";
            ZD.Name = "ZD";
            ZD.Width = 49;
            // 
            // SDST
            // 
            SDST.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            SDST.HeaderText = "DST";
            SDST.MinimumWidth = 3;
            SDST.Name = "SDST";
            SDST.ReadOnly = true;
            SDST.Width = 56;
            // 
            // FromAZ
            // 
            FromAZ.HeaderText = "From AZ";
            FromAZ.Name = "FromAZ";
            FromAZ.Width = 79;
            // 
            // ToAZ
            // 
            ToAZ.HeaderText = "To AZ";
            ToAZ.Name = "ToAZ";
            ToAZ.Width = 66;
            // 
            // HorType
            // 
            HorType.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            HorType.HeaderText = "Horizon";
            HorType.Name = "HorType";
            HorType.ReadOnly = true;
            HorType.ToolTipText = "Natural / Dip Short / Artificial / Bubble";
            HorType.Width = 74;
            // 
            // HorDist
            // 
            HorDist.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            HorDist.HeaderText = "Ds Distance";
            HorDist.Name = "HorDist";
            HorDist.ReadOnly = true;
            HorDist.Width = 97;
            // 
            // HE
            // 
            HE.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            HE.HeaderText = "HE";
            HE.Name = "HE";
            HE.ReadOnly = true;
            HE.Width = 48;
            // 
            // HorDistType
            // 
            HorDistType.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            HorDistType.HeaderText = "Apprx Brg";
            HorDistType.Name = "HorDistType";
            HorDistType.ReadOnly = true;
            HorDistType.Width = 87;
            // 
            // HSIEFormat
            // 
            HSIEFormat.HeaderText = "hs/IE Fmt";
            HSIEFormat.Name = "HSIEFormat";
            HSIEFormat.Width = 83;
            // 
            // lblUSPSSightLog
            // 
            lblUSPSSightLog.AutoSize = true;
            lblUSPSSightLog.Font = new Font("Arial", 14.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblUSPSSightLog.Location = new Point(348, 9);
            lblUSPSSightLog.Name = "lblUSPSSightLog";
            lblUSPSSightLog.Size = new Size(304, 22);
            lblUSPSSightLog.TabIndex = 162;
            lblUSPSSightLog.Text = "Favorite Locations and Defaults";
            // 
            // lblZD
            // 
            lblZD.AutoSize = true;
            lblZD.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblZD.Location = new Point(37, 68);
            lblZD.Name = "lblZD";
            lblZD.Size = new Size(24, 15);
            lblZD.TabIndex = 163;
            lblZD.Text = "ZD";
            // 
            // cboZD
            // 
            _cboZD.BackColor = SystemColors.Window;
            _cboZD.Cursor = Cursors.Default;
            _cboZD.DropDownStyle = ComboBoxStyle.DropDownList;
            _cboZD.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboZD.ForeColor = SystemColors.WindowText;
            _cboZD.Location = new Point(64, 64);
            _cboZD.Name = "_cboZD";
            _cboZD.RightToLeft = RightToLeft.No;
            _cboZD.Size = new Size(95, 23);
            _cboZD.TabIndex = 32;
            // 
            // btnClearFields
            // 
            _btnClearFields.BackColor = Color.Yellow;
            _btnClearFields.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnClearFields.ForeColor = SystemColors.WindowText;
            _btnClearFields.Location = new Point(280, 12);
            _btnClearFields.Name = "_btnClearFields";
            _btnClearFields.Size = new Size(120, 23);
            _btnClearFields.TabIndex = 164;
            _btnClearFields.Text = "Clear Fields";
            _btnClearFields.UseVisualStyleBackColor = false;
            // 
            // grpSightButtons
            // 
            grpSightButtons.BackColor = SystemColors.ActiveCaption;
            grpSightButtons.Controls.Add(_btnShowSharedLoc);
            grpSightButtons.Controls.Add(_btnClearShared);
            grpSightButtons.Controls.Add(_btnUseLocation);
            grpSightButtons.Controls.Add(Label4);
            grpSightButtons.Controls.Add(_btnClearFields);
            grpSightButtons.Controls.Add(_btnAddNew);
            grpSightButtons.Controls.Add(_btnUpdateExisting);
            grpSightButtons.Controls.Add(_btnDeleteSight);
            grpSightButtons.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            grpSightButtons.Location = new Point(6, 170);
            grpSightButtons.Name = "grpSightButtons";
            grpSightButtons.Size = new Size(984, 44);
            grpSightButtons.TabIndex = 166;
            grpSightButtons.TabStop = false;
            grpSightButtons.Text = "Location Actions";
            // 
            // btnShowSharedLoc
            // 
            _btnShowSharedLoc.BackColor = Color.Blue;
            _btnShowSharedLoc.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnShowSharedLoc.ForeColor = SystemColors.HighlightText;
            _btnShowSharedLoc.Location = new Point(826, 12);
            _btnShowSharedLoc.Name = "_btnShowSharedLoc";
            _btnShowSharedLoc.Size = new Size(140, 23);
            _btnShowSharedLoc.TabIndex = 172;
            _btnShowSharedLoc.Text = "Show Shared Loc";
            _btnShowSharedLoc.UseVisualStyleBackColor = false;
            // 
            // btnClearShared
            // 
            _btnClearShared.BackColor = Color.Blue;
            _btnClearShared.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnClearShared.ForeColor = SystemColors.HighlightText;
            _btnClearShared.Location = new Point(683, 12);
            _btnClearShared.Name = "_btnClearShared";
            _btnClearShared.Size = new Size(140, 23);
            _btnClearShared.TabIndex = 171;
            _btnClearShared.Text = "Clear Shared Loc";
            _btnClearShared.UseVisualStyleBackColor = false;
            // 
            // btnUseLocation
            // 
            _btnUseLocation.BackColor = Color.Blue;
            _btnUseLocation.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnUseLocation.ForeColor = SystemColors.HighlightText;
            _btnUseLocation.Location = new Point(539, 12);
            _btnUseLocation.Name = "_btnUseLocation";
            _btnUseLocation.Size = new Size(140, 23);
            _btnUseLocation.TabIndex = 170;
            _btnUseLocation.Text = "Share Location";
            _btnUseLocation.UseVisualStyleBackColor = false;
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
            // grpFileButtons
            // 
            grpFileButtons.BackColor = SystemColors.ActiveCaption;
            grpFileButtons.Controls.Add(_btnSLReport);
            grpFileButtons.Controls.Add(_btnPrintDG);
            grpFileButtons.Controls.Add(_btnOpenLog);
            grpFileButtons.Controls.Add(_btnSaveLog);
            grpFileButtons.Controls.Add(_btnNewLog);
            grpFileButtons.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            grpFileButtons.Location = new Point(6, 126);
            grpFileButtons.Name = "grpFileButtons";
            grpFileButtons.Size = new Size(984, 40);
            grpFileButtons.TabIndex = 167;
            grpFileButtons.TabStop = false;
            grpFileButtons.Text = "Sight File Actions";
            // 
            // btnSLReport
            // 
            _btnSLReport.BackColor = SystemColors.HotTrack;
            _btnSLReport.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnSLReport.ForeColor = SystemColors.HighlightText;
            _btnSLReport.Location = new Point(780, 13);
            _btnSLReport.Name = "_btnSLReport";
            _btnSLReport.Size = new Size(160, 23);
            _btnSLReport.TabIndex = 153;
            _btnSLReport.Text = "Save Location Report";
            _btnSLReport.UseVisualStyleBackColor = false;
            _btnSLReport.Visible = false;
            // 
            // btnPrintDG
            // 
            _btnPrintDG.BackColor = SystemColors.HotTrack;
            _btnPrintDG.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnPrintDG.ForeColor = SystemColors.HighlightText;
            _btnPrintDG.Location = new Point(615, 13);
            _btnPrintDG.Name = "_btnPrintDG";
            _btnPrintDG.Size = new Size(160, 23);
            _btnPrintDG.TabIndex = 152;
            _btnPrintDG.Text = "Print Location Data";
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
            // cboHEUnit
            // 
            cboHEUnit.BackColor = SystemColors.Window;
            cboHEUnit.Cursor = Cursors.Default;
            cboHEUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHEUnit.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboHEUnit.ForeColor = SystemColors.WindowText;
            cboHEUnit.Items.AddRange(new object[] { "ft", "in", "m", "cm" });
            cboHEUnit.Location = new Point(129, 99);
            cboHEUnit.Name = "cboHEUnit";
            cboHEUnit.RightToLeft = RightToLeft.No;
            cboHEUnit.Size = new Size(41, 23);
            cboHEUnit.TabIndex = 172;
            // 
            // lblHSIEFmt
            // 
            lblHSIEFmt.AutoSize = true;
            lblHSIEFmt.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblHSIEFmt.Location = new Point(331, 103);
            lblHSIEFmt.Name = "lblHSIEFmt";
            lblHSIEFmt.Size = new Size(75, 15);
            lblHSIEFmt.TabIndex = 179;
            lblHSIEFmt.Text = "hs/IE Format";
            // 
            // cboHSIEFmt
            // 
            _cboHSIEFmt.BackColor = SystemColors.Window;
            _cboHSIEFmt.DropDownStyle = ComboBoxStyle.DropDownList;
            _cboHSIEFmt.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboHSIEFmt.FormattingEnabled = true;
            _cboHSIEFmt.Items.AddRange(new object[] { "DM", "DMS" });
            _cboHSIEFmt.Location = new Point(420, 100);
            _cboHSIEFmt.Name = "_cboHSIEFmt";
            _cboHSIEFmt.Size = new Size(70, 23);
            _cboHSIEFmt.TabIndex = 180;
            // 
            // cboApprxBrg
            // 
            cboApprxBrg.BackColor = SystemColors.Window;
            cboApprxBrg.DropDownStyle = ComboBoxStyle.DropDownList;
            cboApprxBrg.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboApprxBrg.FormattingEnabled = true;
            cboApprxBrg.Items.AddRange(new object[] { "N", "NE", "E", "SE", "S", "SW", "W", "NW", "None" });
            cboApprxBrg.Location = new Point(254, 100);
            cboApprxBrg.Name = "cboApprxBrg";
            cboApprxBrg.Size = new Size(70, 23);
            cboApprxBrg.TabIndex = 182;
            // 
            // lblApprxBrg
            // 
            lblApprxBrg.AutoSize = true;
            lblApprxBrg.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblApprxBrg.Location = new Point(178, 103);
            lblApprxBrg.Name = "lblApprxBrg";
            lblApprxBrg.Size = new Size(62, 15);
            lblApprxBrg.TabIndex = 181;
            lblApprxBrg.Text = "Apprx Brg";
            // 
            // txtFromAZ
            // 
            txtFromAZ.AcceptsReturn = true;
            txtFromAZ.BackColor = SystemColors.Window;
            txtFromAZ.Cursor = Cursors.IBeam;
            txtFromAZ.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtFromAZ.ForeColor = SystemColors.WindowText;
            txtFromAZ.HideSelection = false;
            txtFromAZ.Location = new Point(310, 65);
            txtFromAZ.MaxLength = 3;
            txtFromAZ.Name = "txtFromAZ";
            txtFromAZ.RightToLeft = RightToLeft.No;
            txtFromAZ.Size = new Size(30, 22);
            txtFromAZ.TabIndex = 186;
            txtFromAZ.Text = "0";
            // 
            // Label2
            // 
            Label2.BackColor = SystemColors.Window;
            Label2.Cursor = Cursors.Default;
            Label2.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = SystemColors.ControlText;
            Label2.Location = new Point(342, 66);
            Label2.Name = "Label2";
            Label2.RightToLeft = RightToLeft.No;
            Label2.Size = new Size(9, 17);
            Label2.TabIndex = 188;
            Label2.Text = "°";
            // 
            // LblFromAZ
            // 
            LblFromAZ.BackColor = SystemColors.Control;
            LblFromAZ.Cursor = Cursors.Default;
            LblFromAZ.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            LblFromAZ.ForeColor = SystemColors.ControlText;
            LblFromAZ.Location = new Point(221, 69);
            LblFromAZ.Name = "LblFromAZ";
            LblFromAZ.RightToLeft = RightToLeft.No;
            LblFromAZ.Size = new Size(95, 16);
            LblFromAZ.TabIndex = 187;
            LblFromAZ.Text = "From Azimuth";
            // 
            // txtToAZ
            // 
            txtToAZ.BackColor = SystemColors.Window;
            txtToAZ.Cursor = Cursors.IBeam;
            txtToAZ.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtToAZ.ForeColor = SystemColors.WindowText;
            txtToAZ.HideSelection = false;
            txtToAZ.Location = new Point(427, 65);
            txtToAZ.MaxLength = 3;
            txtToAZ.Name = "txtToAZ";
            txtToAZ.RightToLeft = RightToLeft.No;
            txtToAZ.Size = new Size(30, 22);
            txtToAZ.TabIndex = 189;
            txtToAZ.Text = "360";
            // 
            // Label3
            // 
            Label3.BackColor = SystemColors.Window;
            Label3.Cursor = Cursors.Default;
            Label3.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.ForeColor = SystemColors.ControlText;
            Label3.Location = new Point(459, 66);
            Label3.Name = "Label3";
            Label3.RightToLeft = RightToLeft.No;
            Label3.Size = new Size(9, 17);
            Label3.TabIndex = 191;
            Label3.Text = "°";
            // 
            // lblToAZ
            // 
            lblToAZ.BackColor = SystemColors.Control;
            lblToAZ.Cursor = Cursors.Default;
            lblToAZ.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblToAZ.ForeColor = SystemColors.ControlText;
            lblToAZ.Location = new Point(351, 69);
            lblToAZ.Name = "lblToAZ";
            lblToAZ.RightToLeft = RightToLeft.No;
            lblToAZ.Size = new Size(75, 16);
            lblToAZ.TabIndex = 190;
            lblToAZ.Text = "To Azimuth";
            // 
            // chkbxSharedLoc
            // 
            chkbxSharedLoc.AutoSize = true;
            chkbxSharedLoc.Enabled = false;
            chkbxSharedLoc.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            chkbxSharedLoc.Location = new Point(505, 101);
            chkbxSharedLoc.Name = "chkbxSharedLoc";
            chkbxSharedLoc.Size = new Size(113, 19);
            chkbxSharedLoc.TabIndex = 192;
            chkbxSharedLoc.Text = "Location Shared";
            chkbxSharedLoc.UseVisualStyleBackColor = true;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.ABC_white;
            PictureBox1.Location = new Point(9, 5);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(222, 25);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 193;
            PictureBox1.TabStop = false;
            // 
            // FavoriteLocations
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1002, 590);
            Controls.Add(PictureBox1);
            Controls.Add(chkbxSharedLoc);
            Controls.Add(txtToAZ);
            Controls.Add(Label3);
            Controls.Add(lblToAZ);
            Controls.Add(txtFromAZ);
            Controls.Add(Label2);
            Controls.Add(LblFromAZ);
            Controls.Add(_cboHSIEFmt);
            Controls.Add(lblHSIEFmt);
            Controls.Add(cboApprxBrg);
            Controls.Add(lblApprxBrg);
            Controls.Add(cboHEUnit);
            Controls.Add(grpFileButtons);
            Controls.Add(grpSightButtons);
            Controls.Add(_cboZD);
            Controls.Add(lblZD);
            Controls.Add(lblUSPSSightLog);
            Controls.Add(_SEDataGrid);
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
            Controls.Add(lblLoMin);
            Controls.Add(lblLoDeg);
            Controls.Add(lblDRLo);
            Controls.Add(lblLMin);
            Controls.Add(lblLDeg);
            Controls.Add(lblDRL);
            Controls.Add(txtHE);
            Controls.Add(lblHE);
            Controls.Add(_btnExit);
            Controls.Add(txtSightNum);
            Controls.Add(lblSightNum);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Name = "FavoriteLocations";
            Text = "USPS Sight Log";
            ((System.ComponentModel.ISupportInitialize)_SEDataGrid).EndInit();
            grpSightButtons.ResumeLayout(false);
            grpFileButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Load += new EventHandler(FavoriteLocations_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        internal Label lblName;
        internal TextBox txtName;
        internal TextBox txtSightNum;
        internal Label lblSightNum;
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

        internal TextBox txtHE;
        internal Label lblHE;
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
        private ComboBox _cboZD;

        public ComboBox cboZD
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboZD;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboZD != null)
                {
                    _cboZD.SelectedIndexChanged -= cboZD_SelectedIndexChanged;
                }

                _cboZD = value;
                if (_cboZD != null)
                {
                    _cboZD.SelectedIndexChanged += cboZD_SelectedIndexChanged;
                }
            }
        }

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

        internal GroupBox grpSightButtons;
        internal GroupBox grpFileButtons;
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

        public Label Label4;
        public ComboBox cboHEUnit;
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
        public TextBox txtFromAZ;
        public Label Label2;
        public Label LblFromAZ;
        public TextBox txtToAZ;
        public Label Label3;
        public Label lblToAZ;
        internal DataGridViewTextBoxColumn SightNum;
        internal DataGridViewTextBoxColumn PsnName;
        internal DataGridViewTextBoxColumn DRLat;
        internal DataGridViewTextBoxColumn DRLong;
        internal DataGridViewTextBoxColumn ZD;
        internal DataGridViewTextBoxColumn SDST;
        internal DataGridViewTextBoxColumn FromAZ;
        internal DataGridViewTextBoxColumn ToAZ;
        internal DataGridViewTextBoxColumn HorType;
        internal DataGridViewTextBoxColumn HorDist;
        internal DataGridViewTextBoxColumn HE;
        internal DataGridViewTextBoxColumn HorDistType;
        internal DataGridViewTextBoxColumn HSIEFormat;
        private Button _btnUseLocation;

        internal Button btnUseLocation
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnUseLocation;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnUseLocation != null)
                {
                    _btnUseLocation.Click -= btnUseLocation_Click;
                }

                _btnUseLocation = value;
                if (_btnUseLocation != null)
                {
                    _btnUseLocation.Click += btnUseLocation_Click;
                }
            }
        }

        private Button _btnClearShared;

        internal Button btnClearShared
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnClearShared;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnClearShared != null)
                {
                    _btnClearShared.Click -= btnClearShared_Click;
                }

                _btnClearShared = value;
                if (_btnClearShared != null)
                {
                    _btnClearShared.Click += btnClearShared_Click;
                }
            }
        }

        internal CheckBox chkbxSharedLoc;
        private Button _btnShowSharedLoc;

        internal Button btnShowSharedLoc
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnShowSharedLoc;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnShowSharedLoc != null)
                {
                    _btnShowSharedLoc.Click -= btnShowSharedLoc_Click;
                }

                _btnShowSharedLoc = value;
                if (_btnShowSharedLoc != null)
                {
                    _btnShowSharedLoc.Click += btnShowSharedLoc_Click;
                }
            }
        }

        internal PictureBox PictureBox1;
    }
}