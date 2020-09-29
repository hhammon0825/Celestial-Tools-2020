using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    public partial class SightLog
    {
        public SightLog()
        {
            InitializeComponent();
            _btnExit.Name = "btnExit";
            _cboBody.Name = "cboBody";
            _cbHorizon.Name = "cbHorizon";
            _chkbxDST.Name = "chkbxDST";
            _btnOpenLog.Name = "btnOpenLog";
            _btnSaveLog.Name = "btnSaveLog";
            _btnAddNew.Name = "btnAddNew";
            _btnUpdateExisting.Name = "btnUpdateExisting";
            _btnDeleteSight.Name = "btnDeleteSight";
            _btnNewLog.Name = "btnNewLog";
            _btnSightReduce.Name = "btnSightReduce";
            _SEDataGrid.Name = "SEDataGrid";
            _btnClearFields.Name = "btnClearFields";
            _btnPlanSight.Name = "btnPlanSight";
            _btnCustomPlot.Name = "btnCustomPlot";
            _btnUseCLS.Name = "btnUseCLS";
            _btnNoonSight.Name = "btnNoonSight";
            _btnAltSR.Name = "btnAltSR";
            _btnSLReport.Name = "btnSLReport";
            _btnPrintDG.Name = "btnPrintDG";
            _cboHSIEFmt.Name = "cboHSIEFmt";
            _CheckBoxShowAvg.Name = "CheckBoxShowAvg";
            _CheckBoxAutoReduce.Name = "CheckBoxAutoReduce";
            _chkDispGHADecHo.Name = "chkDispGHADecHo";
            _chkClearFields.Name = "chkClearFields";
            _btnSaveLogAsTxt.Name = "btnSaveLogAsTxt";
        }

        public struct SightEntry : IEquatable<SightEntry>
        {
            public string EntryStatus;
            public string SLName;
            public string SLSquadron;
            public string SightNum;
            public DateTime SightDateTime;
            public string DST;
            public string WE; // format MMSS, - = Fast and + = Slow
            public string WEType; // F - Fast or S - Slow
            public string DRLat; // format NN*NN.N'N or S where * = CHR(176) degree
            public string DRLong; // format NNN*NN.N'E or W where * = CHR(176) degree 
            public string LLoBy; // DR or GPS or KP for Known Position to match current Nav class 
            public string HS; // NN*NN.N'
            public string IC; // NN.N + is off the arc / - is on the arc
            public string ICType; // ON = on the arc, OFF = Off the arc
            public string HE; // N.N feet
            public string HorType; // N - Natural, D - Dip, or A - Artificial 
            public string BodyName;
            public string BodyLimb; // U - upper, L - lower , C - central
            public string HorDist;
            public string HorDistType; // F - Feet, Y - Yards, M - Statute Mile, N - Nautical Mile
            public string Intercept;
            public string Zn;
            public string ZD;
            public string Remarks;
            public string EP;
            public string ApprxBrg;
            public double HSDouble;
            public string WTDiff;
            public string HSDiff;
            public string HSWTRate;
            public string SRGHA;
            public string SRDec;
            public string SRHo;
            public string UserInfo;

            public SightEntry(string entryStatus, string sLName, string sLSquadron, string sightNum, DateTime sightDateTime, string dST, string wE, string wEType, string dRLat, string dRLong, string lLoBy, string hS, string iC, string iCType, string hE, string horType, string bodyName, string bodyLimb, string horDist, string horDistType, string intercept, string zn, string zD, string remarks, string eP, string apprxBrg, double hSDouble, string wTDiff, string hSDiff, string hSWTRate, string sRGHA, string sRDec, string sRHo, string userInfo)
            {
                EntryStatus = entryStatus;
                SLName = sLName;
                SLSquadron = sLSquadron;
                SightNum = sightNum;
                SightDateTime = sightDateTime;
                DST = dST;
                WE = wE;
                WEType = wEType;
                DRLat = dRLat;
                DRLong = dRLong;
                LLoBy = lLoBy;
                HS = hS;
                IC = iC;
                ICType = iCType;
                HE = hE;
                HorType = horType;
                BodyName = bodyName;
                BodyLimb = bodyLimb;
                HorDist = horDist;
                HorDistType = horDistType;
                Intercept = intercept;
                Zn = zn;
                ZD = zD;
                Remarks = remarks;
                EP = eP;
                ApprxBrg = apprxBrg;
                HSDouble = hSDouble;
                WTDiff = wTDiff;
                HSDiff = hSDiff;
                HSWTRate = hSWTRate;
                SRGHA = sRGHA;
                SRDec = sRDec;
                SRHo = sRHo;
                UserInfo = userInfo;
            }

            public override bool Equals(object obj)
            {
                return base.Equals(obj);
            }

            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            public override string ToString()
            {
                return base.ToString();
            }

            public bool Equals(SightEntry other)
            {
                throw new NotImplementedException();
            }

            public static bool operator ==(SightEntry left, SightEntry right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(SightEntry left, SightEntry right)
            {
                return !(left == right);
            }
        }

        public struct ZDParms : IEquatable<ZDParms>
        {
            public string ZDField;
            public int ZDIndex;
            public int ZDHhours;
            public int ZDMin;

            public ZDParms(string strIn, int intIn, int HourIn, int MinIn) : this()
            {
                ZDField = strIn;
                ZDIndex = intIn;
                ZDHhours = HourIn;
                ZDMin = MinIn;
            }

            public override bool Equals(object obj)
            {
                return base.Equals(obj);
            }

            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            public override string ToString()
            {
                return base.ToString();
            }

            public bool Equals(ZDParms other)
            {
                throw new NotImplementedException();
            }

            public static bool operator ==(ZDParms left, ZDParms right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(ZDParms left, ZDParms right)
            {
                return !(left == right);
            }
        }

        //private string SaveCLSFileName;
        //private double SRFa = 0d;
        //private double SRFZn = 0d;
        //private bool SRFSightUpd = false;
        private SightEntry[] SightLogArray;
        private string SLFName = Constants.vbNullString;
        private string SLDir = @"\SightLogs";
        // Private GraphDir As String = "./Graphics/"
        // Private SLDefName As String = "SightLog" & Now.ToShortDateString.Replace("/", "").Replace("-", "") & Now.ToLongTimeString.Replace(":", "").Replace(" ", "") & ".txt"
        private string SLOpenFName = Constants.vbNullString;
        private int EntryIndex = 0;
        private readonly string[] BNameArray = new[] { "Sun", "Moon", "Venus", "Mars", "Jupiter", "Saturn", "Acamar", "Achernar", "Acrux", "Adhara", "Aldebaran", "Alioth", "Alkaid", "Al Na'ir", "Alnilam", "Alphard", "Alphecca", "Alpheratz", "Altair", "Ankaa", "Antares", "Arcturus", "Atria", "Avior", "Bellatrix", "Betelgeuse", "Canopus", "Capella", "Deneb", "Denebola", "Diphda", "Dubhe", "Elnath", "Eltanin", "Enif", "Fomalhaut", "Gacrux", "Gienah", "Hadar", "Hamal", "Kaus Australis", "Kochab", "Markab", "Menkar", "Menkent", "Miaplacidus", "Mirfak", "Nunki", "Peacock", "Polaris", "Pollux", "Procyon", "Rasalhague", "Regulus", "Rigel", "Rigil Kentaurus", "Sabik", "Schedar", "Shaula", "Sirius", "Spica", "Suhail", "Vega", "Zubenelgenubi" };
        private bool FileUpdated = false;
        private SightEntry CommonSE;
        private bool ReadError = false;
        private bool FileLoading = false;
        private ZDParms[] ZDArray = new[] { new ZDParms("+01", 0, 1, 0), new ZDParms("+02", 1, 2, 0), new ZDParms("+03", 2, 3, 0), new ZDParms("+03:30", 3, 3, 30), new ZDParms("+04", 4, 4, 0), new ZDParms("+04:30", 5, 4, 30), new ZDParms("+05", 6, 5, 0), new ZDParms("+05:30", 7, 5, 30), new ZDParms("+05:45", 8, 5, 45), new ZDParms("+06", 9, 6, 0), new ZDParms("+06:30", 10, 6, 30), new ZDParms("+07", 11, 7, 0), new ZDParms("+08", 12, 8, 0), new ZDParms("+08:45", 13, 8, 45), new ZDParms("+09", 14, 9, 0), new ZDParms("+09:30", 15, 9, 30), new ZDParms("+10", 16, 10, 0), new ZDParms("+10:30", 17, 10, 30), new ZDParms("+11", 18, 11, 0), new ZDParms("+12", 19, 12, 0), new ZDParms("+12:45", 20, 12, 45), new ZDParms("+13", 21, 13, 0), new ZDParms("+13:45", 22, 13, 45), new ZDParms("+14", 23, 14, 0), new ZDParms("+00", 24, 0, 0), new ZDParms("-01", 25, -1, 0), new ZDParms("-02", 26, -2, 0), new ZDParms("-02:30", 27, -2, 30), new ZDParms("-03", 28, -3, 0), new ZDParms("-03:30", 29, -3, 30), new ZDParms("-04", 30, -4, 0), new ZDParms("-05", 31, -5, 0), new ZDParms("-06", 32, -6, 0), new ZDParms("-07", 33, -7, 0), new ZDParms("-08", 34, -8, 0), new ZDParms("-09", 35, -9, 0), new ZDParms("-09:30", 36, -9, 30), new ZDParms("-10", 37, -10, 0), new ZDParms("-11", 38, -11, 0), new ZDParms("-12", 39, -12, 0), new ZDParms("Auto", 40, 0, 0) };
        //private int ZDGMTIdx = 24;
        private int ZDInitIdx = 40;
        public double SRFFormZN;
        public double SRFFormIntercept;
        public string SRFFormEP;
        public double SRFFormGHADeg;
        public double SRFFormGHAMin;
        public double SRFFormDecDeg;
        public double SRFFormDecMin;
        public string SRFFormDecNS;
        public double SRFFormHoDeg;
        public double SRFFormHoMin;
        public bool FormSRFLoaded = false;  // SRF form
        public bool FormNoonSightLoaded = false;  // Noon Sight Form
        public bool FormSightPlanLoaded = false;  // Noon Sight Form
        public bool FormAltSRLoaded = false;  // Alt SR Method form
                                              // these are the indexes for the data grid view cells and they must ALWAY be kept in sync with the datagridview order of cells.
        private int SightNumCell = 0;
        private int SightDateTimeCell = 1;
        private int BodyNameCell = 2;
        private int BodyLimbCell = 3;
        private int DSTCell = 4;
        private int WECell = 5;
        private int WETypeCell = 6;
        private int ZDCell = 7;
        private int HSCell = 8;
        private int HorTypeCell = 9;
        private int HorDistCell = 10;
        private int ApprxBrgCell = 11;
        private int HECell = 12;
        private int ICCell = 13;
        private int ICTypeCell = 14;
        private int DRLatCell = 15;
        private int DRLongCell = 16;
        private int LLoByCell = 17;
        private int InterceptCell = 18;
        private int ZnCell = 19;
        private int SLEP = 20;
        private int SLNameCell = 21;
        private int SLSquadron = 22;
        private int SLWTDiff = 23;
        private int SLhsdiff = 24;
        private int SLhsWT = 25;
        private int RemarksCell = 26;
        private int SLGHACell = 27;
        private int SLDecCell = 28;
        private int SLHoCell = 29;
        private int UserInfoCell = 30;
        // Public HorDistTypeCell As Integer = 25
        public string[] HdrStr = new[] { "Num", "DateTime", "Body", "Limb", "DST", "WE", "WEtype", "ZD", "Hs", "HorType", "HorDist", "Apprx Brg", "HEye", "IC", "ICType", "Lat", "Long", "LLoBy", "Int", "Az", "SLEP", "Name", "Squadron", "Remarks" };
        public string[] NullStr = new[] { Constants.vbNullString, Constants.vbNullString, Constants.vbNullString, Constants.vbNullString, Constants.vbNullString, Constants.vbNullString, Constants.vbNullString, Constants.vbNullString, Constants.vbNullString, Constants.vbNullString, Constants.vbNullString, Constants.vbNullString, Constants.vbNullString, Constants.vbNullString, Constants.vbNullString, Constants.vbNullString, Constants.vbNullString, Constants.vbNullString, Constants.vbNullString, Constants.vbNullString, Constants.vbNullString, Constants.vbNullString };
        public bool EditError = false;
        public bool MasterDST = false;
        public CLSForm.PlotEntry PlotOut;
        public string PlotIntercept;
        public string PlotAzimuth;

        // Print Data Grid variable
        private struct pageDetails
        {
            public int columns;
            public int rows;
            public int startCol;
            public int startRow;
        }

        private Dictionary<int, pageDetails> pages;
        private int maxPagesWide;
        private int maxPagesTall;

        private void LoadZDDropDown()
        {
            cboZD.Items.Clear();
            int lim = 0;
            var loopTo = Information.UBound(ZDArray);
            for (lim = 0; lim <= loopTo; lim++)
                cboZD.Items.Add(ZDArray[lim].ZDField);
            cboZD.SelectedIndex = ZDInitIdx;
            return;
        }

        public void QuickExit()
        {
            ExitSRFandAltSR();
            if (FileUpdated == true)
            {
                ExecFileSave();
            }

            Close();
            return;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitSRFandAltSR();

            // Dim DYesNo As DialogResult
            if (FileUpdated == true)
            {
                if (MessageBox.Show("Save Current File?  Yes / No ?", "Save File?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification) == DialogResult.Yes)
                {
                    ExecFileSave();
                }
                else
                {
                    Close();
                }
            }
            else
            {
                Close();
            }

            Close();
            return;
        }

        private void SightLog_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            LoadZDDropDown();
            ExecInitScreen();
            SEDataGrid.Rows.Clear();
            SEDataGrid.ClearSelection();
            SEDataGrid.CurrentCell = null;
            SEDataGrid.Refresh();
            cboHSIEFmt.SelectedIndex = 0;
            cboLLoBy.SelectedIndex = 0;
            return;
        }

        private void ExecInitScreen()
        {
            string CurrDir = My.MyProject.Computer.FileSystem.CurrentDirectory;
            FileUpdated = false;
            SLDir = CurrDir + @"\SightLogs";
            // check if Sight Log Dir for files exists - if not then create dir - this protects the very first time program is run
            if (My.MyProject.Computer.FileSystem.DirectoryExists(SLDir) == false)
            {
                My.MyProject.Computer.FileSystem.CreateDirectory(SLDir);
            }

            SightLogArray = new SightEntry[3];
            SightLogArray[0].EntryStatus = "Deleted";
            SightLogArray[0].SightDateTime = DateAndTime.Now.AddDays(365d);
            SightLogArray[1].EntryStatus = "Empty";
            SightLogArray[1].SightDateTime = DateAndTime.Now.AddDays(365d);
            ExitSRFandAltSR();
            btnUpdateExisting.Visible = false;
            btnDeleteSight.Visible = false;
            btnSightReduce.Visible = false;
            btnAltSR.Visible = false;
            btnPlanSight.Visible = false;
            btnSaveLog.Visible = false;
            btnPrintDG.Visible = false;
            btnSLReport.Visible = false;
            btnSaveLogAsTxt.Visible = false;
            // btnNewLog.Visible = False
            ExecClearScreenFields();
            SEDataGrid.Rows.Clear();
            SEDataGrid.ClearSelection();
            SEDataGrid.CurrentCell = null;
            SEDataGrid.Refresh();
            return;
        }

        private void ExecClearScreenFields()
        {
            SightDateTime.Value = DateTime.Now; // ToString("MM/dd/yyyy HH:mm:ss")
            txtWE.Clear();
            cboLo.SelectedIndex = 0; // W
            cboL.SelectedIndex = 0; // N
            cboZD.SelectedIndex = ZDInitIdx;
            cbWEType.SelectedIndex = 0;
            cboBody.SelectedIndex = 0;
            cbLimb.SelectedIndex = 0;
            cbHorizon.SelectedIndex = 0;
            cbHorDistType.SelectedIndex = 0;
            cbIEType.SelectedIndex = 0;
            cboHEUnit.SelectedIndex = 0;
            cboApprxBrg.SelectedIndex = 8; // None
            chkbxDST.Checked = false;
            txtSightNum.Clear();
            txtLDeg.Clear();
            txtLMin.Clear();
            txtLoDeg.Clear();
            txtLoMin.Clear();
            txtIEDeg.Clear();
            txtIE.Clear();
            txtIESec.Clear();
            txtHSDeg.Clear();
            txtHSMin.Clear();
            txtHSDeg.Clear();
            txtWE.Clear();
            txtHE.Clear();
            txtIntZn.Clear();
            txtSRFEP.Clear();
            txtRemarks.Clear();
            txtHorDist.Clear();
            txtSRFEP.Clear();
            txtSRGHA.Clear();
            txtSRDec.Clear();
            txtSRHo.Clear();
            txtUserInfo.Clear();
            InitSRFFormFields();
            SRFFormEP = Constants.vbNullString;
            txtWE.Text = "0000";
            btnAddNew.Visible = true;
            btnSightReduce.Visible = false;
            btnPlanSight.Visible = false;
            btnUpdateExisting.Visible = false;
            btnClearFields.Visible = false;
            btnDeleteSight.Visible = false;
            btnAltSR.Visible = false;
            return;
        }

        private void btnOpenLog_Click(object sender, EventArgs e)
        {
            if (FileUpdated == true)
            {
                if (MessageBox.Show("Save Current File?  Yes / No ?", "Save File?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification) == DialogResult.Yes)
                {
                    ExecFileSave();
                }
                else
                {
                    // nothing to do
                }
            }
            else
            {
                // nothing to do
            }

            StreamReader myStream = null;
            var openFileDialog1 = new OpenFileDialog();
            string rdline = Constants.vbNullString;
            string CurrDir = Directory.GetCurrentDirectory();
            openFileDialog1.Reset();
            openFileDialog1.InitialDirectory = CurrDir + @"\SightLogs";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.Title = "Open Sight Log Text File";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.AutoUpgradeEnabled = true;
            ExecClearScreenFields();
            SightLogArray = new SightEntry[2];
            SightLogArray[0].EntryStatus = "Empty";
            SightLogArray[0].SightDateTime = DateAndTime.Now.AddDays(365d);
            ExitSRFandAltSR();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(openFileDialog1.FileName))
                {
                    return;
                }

                ReadError = false;
                FileLoading = true;
                try
                {
                    myStream = new StreamReader(openFileDialog1.FileName);
                    if (myStream is object)
                    {
                        SLOpenFName = openFileDialog1.FileName;
                        SLFName = SLOpenFName;
                        SEDataGrid.Rows.Clear();
                        SEDataGrid.Refresh();
                        while (myStream.Peek() >= 0)
                        {
                            rdline = myStream.ReadLine();
                            if (!string.IsNullOrEmpty(rdline))
                            {
                                ParseReadLine(rdline);
                                rdline = Constants.vbNullString;
                                if (ReadError == true)
                                {
                                    goto LeaveReadLoop;
                                }
                            }
                        }

                    LeaveReadLoop:
                        ;
                        myStream.Close();
                        PrepareSightArray();
                        BuildDGFromSightArray();
                    }

                    myStream.Dispose();
                    openFileDialog1.Dispose();
                    SEDataGrid.ClearSelection();
                    SEDataGrid.CurrentCell = null;
                    SEDataGrid.Refresh();
                    FileLoading = false;
                    btnPrintDG.Visible = true;
                    btnSLReport.Visible = true;
                    btnSaveLogAsTxt.Visible = true;
                }
                catch (Exception Ex)
                {
                    ErrorMsgBox("Cannot read file from disk. Original error: " + Ex.Message);
                }
                finally
                {
                    // Check this again, since we need to make sure we didn't throw an exception on open.
                    if (myStream is object)
                    {
                        myStream.Close();
                    }
                }
            }
        }

        private void btnSaveLog_Click(object sender, EventArgs e)
        {
            ExitSRFandAltSR();
            ExecFileSave();
            FileUpdated = false;
            return;
        }

        private void InitSRFFormFields()
        {
            SRFFormIntercept = 0d;
            SRFFormZN = 0d;
            SRFFormGHADeg = 0d;
            SRFFormGHAMin = 0d;
            SRFFormDecDeg = 0d;
            SRFFormDecMin = 0d;
            SRFFormHoDeg = 0d;
            SRFFormHoMin = 0d;
            // SRFFormEP = vbNullString
            SRFFormGHADeg = 0d;
            SRFFormGHAMin = 0d;
            SRFFormDecDeg = 0d;
            SRFFormDecMin = 0d;
            SRFFormHoDeg = 0d;
            SRFFormHoMin = 0d;
            return;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            InitSRFFormFields();
            txtIntZn.Clear();
            txtSRFEP.Clear();
            SRFFormEP = Constants.vbNullString;

            // ExitSRFandAltSR()

            EditError = false;
            ExecAddNew();
            if (EditError == false)
            {
                if (chkClearFields.Checked == true)
                {
                    ExecClearScreenFields();
                }
            }

            return;
        }

        private void btnSightReduce_Click(object sender, EventArgs e)
        {
            if (EditScreenFields() == true)
            {
                EditError = false;
                PerformSRF();
                ExecUpdateExisting();
                if (chkClearFields.Checked == true)
                {
                    ExecClearScreenFields();
                }
            }
            else
            {
                EditError = true;
            }

            return;
        }

        public void PerformAltSR()
        {
            if (CheckOpenWinForms("FormAltSR") == true)
            {
                FormAltSRLoaded = true;
                My.MyProject.Forms.FormAltSR.cmdClear.PerformClick();
                My.MyProject.Forms.FormAltSR.Show();
                My.MyProject.Forms.FormAltSR.BringToFront();
                My.MyProject.Forms.FormAltSR.SetDesktopLocation(5, 5); // 
                My.MyProject.Forms.FormAltSR.InvokedbySightLog = true;
            }
            else
            {
                FormAltSRLoaded = false;
                My.MyProject.Forms.FormAltSR.Show();
                My.MyProject.Forms.FormAltSR.SetDesktopLocation(5, 5); // 
                My.MyProject.Forms.FormAltSR.InvokedbySightLog = true;
                FormAltSRLoaded = true;
            }

            int IndexofDeg = txtSRGHA.Text.IndexOf('°');
            int IndexofMin = txtSRGHA.Text.IndexOf("'");
            string ghadeg = txtSRGHA.Text.Substring(0, IndexofDeg);
            string ghamin = txtSRGHA.Text.Substring(IndexofDeg + 1, IndexofMin - (IndexofDeg + 1)).Trim();
            My.MyProject.Forms.FormAltSR.txtGHADeg.Text = ghadeg;
            My.MyProject.Forms.FormAltSR.txtGHAMin.Text = ghamin;
            My.MyProject.Forms.FormAltSR.cboBody.SelectedIndex = cboBody.SelectedIndex;
            My.MyProject.Forms.FormAltSR.cbLimb.SelectedIndex = cbLimb.SelectedIndex;
            My.MyProject.Forms.FormAltSR.cboLLoBy.SelectedIndex = cboLLoBy.SelectedIndex;
            My.MyProject.Forms.FormAltSR.grpSLInfo.Visible = true;
            IndexofDeg = txtSRDec.Text.IndexOf('°');
            IndexofMin = txtSRDec.Text.IndexOf("'");
            string decdeg = txtSRDec.Text.Substring(0, IndexofDeg);
            string decmin = txtSRDec.Text.Substring(IndexofDeg + 1, IndexofMin - (IndexofDeg + 1));
            string decNS = txtSRDec.Text.Substring(IndexofMin + 2, 1);
            My.MyProject.Forms.FormAltSR.txtDecDeg.Text = decdeg;
            My.MyProject.Forms.FormAltSR.txtDecMin.Text = decmin;
            switch (decNS ?? "")
            {
                case var @case when @case == (CommonGlobals.g_LatS ?? ""):
                    {
                        My.MyProject.Forms.FormAltSR.cboDec.SelectedIndex = 1;
                        break;
                    }

                case var case1 when case1 == (CommonGlobals.g_LatN ?? ""):
                    {
                        My.MyProject.Forms.FormAltSR.cboDec.SelectedIndex = 0;
                        break;
                    }

                default:
                    {
                        My.MyProject.Forms.FormAltSR.cboDec.SelectedIndex = 0;
                        break;
                    }
            }

            IndexofDeg = txtSRHo.Text.IndexOf('°');
            IndexofMin = txtSRHo.Text.IndexOf("'");
            string hodeg = txtSRHo.Text.Substring(0, IndexofDeg);
            string homin = txtSRHo.Text.Substring(IndexofDeg + 1, IndexofMin - (IndexofDeg + 1));
            My.MyProject.Forms.FormAltSR.txtHoDeg.Text = hodeg;
            My.MyProject.Forms.FormAltSR.txtHoMin.Text = homin;
            My.MyProject.Forms.FormAltSR.txtLDeg.Text = txtLDeg.Text;
            My.MyProject.Forms.FormAltSR.txtLMin.Text = txtLMin.Text;
            My.MyProject.Forms.FormAltSR.cboL.SelectedIndex = cboL.SelectedIndex;
            My.MyProject.Forms.FormAltSR.txtLoDeg.Text = txtLoDeg.Text;
            My.MyProject.Forms.FormAltSR.txtLoMin.Text = txtLoMin.Text;
            My.MyProject.Forms.FormAltSR.cboLo.SelectedIndex = cboLo.SelectedIndex;
            My.MyProject.Forms.FormAltSR.DTSight.Value = SightDateTime.Value;
            My.MyProject.Forms.FormAltSR.txtUserInfo.Text = txtUserInfo.Text;
            My.MyProject.Forms.FormAltSR.Show();
            return;
        }

        public void PerformSRF()
        {
            if (CheckOpenWinForms("FormSRF") == true)
            {
                FormSRFLoaded = true;
                My.MyProject.Forms.FormSRF.SetDesktopLocation(5, 5); // 
                My.MyProject.Forms.FormSRF.BringToFront();
                My.MyProject.Forms.FormSRF.ClearAllBtn.PerformClick();
                My.MyProject.Forms.FormSRF.Refresh();
                My.MyProject.Forms.FormSRF.InvokedbySightLog = true;
            }
            else
            {
                FormSRFLoaded = false;
                My.MyProject.Forms.FormSRF.Show();
                My.MyProject.Forms.FormSRF.SetDesktopLocation(5, 5); // 
                                                                     // FormSRF.ClearAllBtn.PerformClick()
                My.MyProject.Forms.FormSRF.InvokedbySightLog = true;
                FormSRFLoaded = true;
            }

            InitSRFFormFields();
            SRFFormEP = Constants.vbNullString;
            string DTHr = Strings.Format(SightDateTime.Value.Hour, "00");
            string DTMin = Strings.Format(SightDateTime.Value.Minute, "00");
            string DTSec = Strings.Format(SightDateTime.Value.Second, "00");
            string DTYear = Strings.Format(SightDateTime.Value.Year, "0000");
            My.MyProject.Forms.FormSRF.DTSight.Value = SightDateTime.Value;
            // FormSRF.cboDay.SelectedIndex = SightDateTime.Value.Day - 1
            // FormSRF.cboMonth.SelectedIndex = SightDateTime.Value.Month - 1
            // FormSRF.txtYear.Text = DTYear
            // FormSRF.txtTime.Text = DTHr & DTMin & DTSec
            My.MyProject.Forms.FormSRF.cboLLoBy.SelectedIndex = cboLLoBy.SelectedIndex;
            My.MyProject.Forms.FormSRF.txtWEMin.Text = txtWE.Text.Substring(0, 2);
            My.MyProject.Forms.FormSRF.txtWESec.Text = txtWE.Text.Substring(2, 2);
            if (cbWEType.Items[cbWEType.SelectedIndex].ToString() == "Fast")
            {
                My.MyProject.Forms.FormSRF.cboWE.SelectedIndex = 0;
            }
            else
            {
                My.MyProject.Forms.FormSRF.cboWE.SelectedIndex = 1;
            }

            // by default FormSRF SRF sets ZD to auto calc from Long - only change to manual if ZD Minutes is nonzero then select Manual Calc option
            if (cboZD.SelectedIndex == ZDInitIdx)
            {
                My.MyProject.Forms.FormSRF.optZDAuto.Checked = true;
            }
            else
            {
                My.MyProject.Forms.FormSRF.optZDManual.Checked = true;
                int ZDHours = GetZDHour(cboZD.Items[cboZD.SelectedIndex].ToString());
                int ZDMin = GetZDMin(cboZD.Items[cboZD.SelectedIndex].ToString());
                My.MyProject.Forms.FormSRF.txtZDh.Text = ZDHours.ToString();
                switch (ZDMin)
                {
                    case 30:
                        {
                            My.MyProject.Forms.FormSRF.cboZDm.SelectedIndex = 1;
                            My.MyProject.Forms.FormSRF.optZDManual.Checked = true;
                            break;
                        }

                    case 45:
                        {
                            My.MyProject.Forms.FormSRF.cboZDm.SelectedIndex = 2;
                            My.MyProject.Forms.FormSRF.optZDManual.Checked = true;
                            break;
                        }

                    default:
                        {
                            My.MyProject.Forms.FormSRF.cboZDm.SelectedIndex = 0;
                            break;
                        }
                }
            }

            if (chkbxDST.Checked == true)
            {
                My.MyProject.Forms.FormSRF.chkDST.Checked = true;
            }
            else
            {
                My.MyProject.Forms.FormSRF.chkDST.Checked = false;
            }

            My.MyProject.Forms.FormSRF.txtSightNo.Text = txtSightNum.Text;
            My.MyProject.Forms.FormSRF.cboBody.SelectedIndex = cboBody.SelectedIndex;
            switch (cbLimb.SelectedIndex)
            {
                case 0:
                    {
                        My.MyProject.Forms.FormSRF.optLower.Checked = true;
                        break;
                    }

                case 1:
                    {
                        My.MyProject.Forms.FormSRF.optUpper.Checked = true;
                        break;
                    }

                case 2:
                    {
                        My.MyProject.Forms.FormSRF.optCenter.Checked = true;
                        break;
                    }

                default:
                    {
                        My.MyProject.Forms.FormSRF.optLower.Checked = true;
                        break;
                    }
            }

            My.MyProject.Forms.FormSRF.txtLoDeg.Text = txtLoDeg.Text;
            My.MyProject.Forms.FormSRF.txtLoMin.Text = txtLoMin.Text;
            switch (cboLo.SelectedIndex)
            {
                case 0:
                    {
                        My.MyProject.Forms.FormSRF.cboLo.SelectedIndex = 0;
                        break;
                    }

                case 1:
                    {
                        My.MyProject.Forms.FormSRF.cboLo.SelectedIndex = 1;
                        break;
                    }
            }

            My.MyProject.Forms.FormSRF.txtLDeg.Text = txtLDeg.Text;
            My.MyProject.Forms.FormSRF.txtLMin.Text = txtLMin.Text;
            switch (cboL.SelectedIndex)
            {
                case 0:
                    {
                        My.MyProject.Forms.FormSRF.cboL.SelectedIndex = 0;
                        break;
                    }

                case 1:
                    {
                        My.MyProject.Forms.FormSRF.cboL.SelectedIndex = 1;
                        break;
                    }
            }

            My.MyProject.Forms.FormSRF.txtHE.Text = txtHE.Text;
            My.MyProject.Forms.FormSRF.cboHE.SelectedIndex = cboHEUnit.SelectedIndex;
            My.MyProject.Forms.FormSRF.txtDsDist.Text = txtHorDist.Text;
            switch (cbHorDistType.SelectedIndex)
            {
                case 0:
                    {
                        My.MyProject.Forms.FormSRF.cboDsUnit.SelectedIndex = 0;
                        break;
                    }

                case 1:
                    {
                        My.MyProject.Forms.FormSRF.cboDsUnit.SelectedIndex = 1;
                        break;
                    }

                case 2:
                    {
                        My.MyProject.Forms.FormSRF.cboDsUnit.SelectedIndex = 2;
                        break;
                    }

                case 3:
                    {
                        My.MyProject.Forms.FormSRF.cboDsUnit.SelectedIndex = 3;
                        break;
                    }

                case 4:
                    {
                        My.MyProject.Forms.FormSRF.cboDsUnit.SelectedIndex = 4;
                        break;
                    }
            }

            if (cboHSIEFmt.SelectedIndex == 1)
            {
                My.MyProject.Forms.FormSRF.optHsDMS.Checked = true;
            }
            else
            {
                My.MyProject.Forms.FormSRF.optHsDMm.Checked = true;
            }

            My.MyProject.Forms.FormSRF.txtIEdeg.Text = txtIEDeg.Text;
            My.MyProject.Forms.FormSRF.txtIEmin.Text = txtIE.Text;
            if (cboHSIEFmt.SelectedIndex == 1)
            {
                My.MyProject.Forms.FormSRF.txtIESec.Text = txtIESec.Text;
            }

            switch (cbIEType.SelectedIndex)
            {
                case 0:
                    {
                        My.MyProject.Forms.FormSRF.cboIE.SelectedIndex = 0;
                        break;
                    }

                case 1:
                    {
                        My.MyProject.Forms.FormSRF.cboIE.SelectedIndex = 1;
                        break;
                    }
            }

            My.MyProject.Forms.FormSRF.txtHsDeg.Text = txtHSDeg.Text;
            My.MyProject.Forms.FormSRF.txtHsMin.Text = txtHSMin.Text;
            if (cboHSIEFmt.SelectedIndex == 1)
            {
                My.MyProject.Forms.FormSRF.txtHsSec.Text = txtHsSec.Text;
            }

            switch (cbHorizon.SelectedIndex)
            {
                case 0:
                    {
                        My.MyProject.Forms.FormSRF.optHorizonNatural.Checked = true;
                        break;
                    }

                case 1:
                    {
                        My.MyProject.Forms.FormSRF.optHorizonDipShort.Checked = true;
                        break;
                    }

                case 2:
                    {
                        My.MyProject.Forms.FormSRF.optHorizonArtificial.Checked = true;
                        break;
                    }

                case 3:
                    {
                        My.MyProject.Forms.FormSRF.optHorizonBubble.Checked = true;
                        break;
                    }

                default:
                    {
                        My.MyProject.Forms.FormSRF.optHorizonNatural.Checked = true;
                        break;
                    }
            }

            My.MyProject.Forms.FormSRF.txtUserInfo.Text = txtUserInfo.Text;
            My.MyProject.Forms.FormSRF.cmdReduce.PerformClick();
            My.MyProject.Forms.FormSRF.BringToFront();
            SRFFormZN = My.MyProject.Forms.FormSRF.ZN;
            SRFFormIntercept = My.MyProject.Forms.FormSRF.Intercept;
            double TempTotGHA = My.MyProject.Forms.FormSRF.SaveGHA;
            if (TempTotGHA > 360d)
            {
                TempTotGHA -= 360d;
            }

            int TempGHADeg = (int)Conversion.Int(TempTotGHA);
            double TempGHAMin = (TempTotGHA - TempGHADeg) * 60d;
            SRFFormGHADeg = TempGHADeg;
            SRFFormGHAMin = TempGHAMin;
            SRFFormDecDeg = My.MyProject.Forms.FormSRF.TotDecDegrees;
            SRFFormDecMin = My.MyProject.Forms.FormSRF.TotDecMinutes;
            SRFFormHoDeg = My.MyProject.Forms.FormSRF.HoDeg;
            SRFFormHoMin = My.MyProject.Forms.FormSRF.HoMin;
            if (My.MyProject.Forms.FormSRF.DE1 > 0d)
                SRFFormDecNS = CommonGlobals.g_LatN;
            if (My.MyProject.Forms.FormSRF.DE1 == 0d)
                SRFFormDecNS = CommonGlobals.g_StrSpace;
            if (My.MyProject.Forms.FormSRF.DE1 < 0d)
                SRFFormDecNS = CommonGlobals.g_LatS;
            btnAltSR.Visible = true;
            txtIntZn.Clear();
            txtSRFEP.Clear();
            txtSRGHA.Clear();
            txtSRDec.Clear();
            txtSRHo.Clear();
            txtSRGHA.Text = Convert.ToInt32(SRFFormGHADeg).ToString("##0") + '°' + " " + SRFFormGHAMin.ToString("00.0") + "'";
            txtSRDec.Text = Convert.ToInt32(SRFFormDecDeg).ToString("##0") + '°' + " " + SRFFormDecMin.ToString("00.0") + "' " + SRFFormDecNS.ToString();
            txtSRHo.Text = Convert.ToInt32(SRFFormHoDeg).ToString("##0") + '°' + " " + SRFFormHoMin.ToString("00.0") + "'";
            txtSRFEP.Text = SRFFormEP;
            if (SRFFormIntercept >= 0d)
            {
                txtIntZn.AppendText("a = " + Math.Abs(SRFFormIntercept).ToString() + " nm Away ");
            }

            if (SRFFormIntercept < 0d)
            {
                txtIntZn.AppendText("a = " + Math.Abs(SRFFormIntercept).ToString() + " nm Toward ");
            }

            if (SRFFormIntercept != 0d)
            {
                txtIntZn.AppendText(" Zn = " + Math.Abs(SRFFormZN).ToString() + '°');
            }

            return;
        }

        private void btnUpdateExisting_Click(object sender, EventArgs e)
        {
            // updating a sight entry do not carry forward the old sight reduction - may no longer be valid so zero out Int and Zn fields

            InitSRFFormFields();
            SRFFormEP = Constants.vbNullString;
            txtIntZn.Clear();
            txtSRFEP.Clear();
            txtSRGHA.Clear();
            txtSRDec.Clear();
            txtSRHo.Clear();
            FileUpdated = false;
            EditError = false;
            if (EditScreenFields() == false)
            {
                EditError = true;
            }

            if (EditError == false) // was there an error in the updated info - No error then check to see if auto reduce is on else clear screen fields
            {
                if (CheckBoxAutoReduce.Checked == true)
                {
                    PerformSRF();    // do sight reduction first then update existing info
                    ExecUpdateExisting();
                    if (chkClearFields.Checked == true)
                    {
                        ExecClearScreenFields();
                    }
                }
                else
                {
                    ExecUpdateExisting();
                    if (chkClearFields.Checked == true)
                    {
                        ExecClearScreenFields();
                    }
                }
            }
            else
            {
                // do nothing if there was an error in the updated info
            }

            return;
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            ExitSRFandAltSR();
            ExecClearScreenFields();
            return;
        }

        private void ExecUpdateExisting()
        {
            string SaveSightNum = txtSightNum.Text;
            var SaveSightDT = SightDateTime.Value;
            string SaveBodyName = cboBody.Items[cboBody.SelectedIndex].ToString();
            FileUpdated = true;
            EditError = false;
            if (EditScreenFields() == true)
            {
                // Mark the current sight num entry in sight log array as 'Deleted' 
                int i = 0;
                bool DidDelete = false;
                var loopTo = Information.UBound(SightLogArray);
                for (i = 0; i <= loopTo; i++)
                {
                    if ((SightLogArray[i].SightNum ?? "") == (SaveSightNum ?? ""))
                    {
                        if (SightLogArray[i].EntryStatus == "Active")
                        {
                            SightLogArray[i].EntryStatus = "Deleted";
                            DidDelete = true;
                        }
                    }
                }

                if (DidDelete == false)
                {
                    ErrorMsgBox("Did Not Mark Old Entry as Deleted - Debug This");
                    return;
                }
                // build new sight entry into array from screen data
                BuildArrayFromscreen();
                // now rebuild list box display of sight array
                PrepareSightArray();
                BuildDGFromSightArray();
                if (CountActiveSEArray() > 0)
                {
                    btnSaveLog.Visible = true;
                    btnPrintDG.Visible = true;
                    btnSLReport.Visible = true;
                    btnSaveLogAsTxt.Visible = true;
                    btnUpdateExisting.Visible = true;
                    btnDeleteSight.Visible = true;
                    btnSightReduce.Visible = false;
                    btnPlanSight.Visible = false;
                    btnAltSR.Visible = false;
                }

                SelectDGRow(SaveSightDT, SaveBodyName);
                FileUpdated = true;
                FileLoading = false;
            }
            else
            {
                EditError = true;
            }

            return;
        }

        private void btnDeleteSight_Click(object sender, EventArgs e)
        {
            FileUpdated = true;
            int i = 0;
            bool DidDelete = false;
            var loopTo = Information.UBound(SightLogArray);
            for (i = 0; i <= loopTo; i++)
            {
                if ((SightLogArray[i].SightNum ?? "") == (txtSightNum.Text ?? ""))
                {
                    if (SightLogArray[i].EntryStatus == "Active")
                    {
                        SightLogArray[i].EntryStatus = "Deleted";
                        DidDelete = true;
                    }
                }
            }

            if (DidDelete == false)
            {
                ErrorMsgBox("Did Not Mark Old Entry as Deleted - Debug This");
                return;
            }

            ExitSRFandAltSR();
            PrepareSightArray();
            BuildDGFromSightArray();
            ExecClearScreenFields();
            return;
        }

        private void btnNewLog_Click(object sender, EventArgs e)
        {
            DialogResult DYesNo;
            FileLoading = true;
            if (FileUpdated == true)
            {
                DYesNo = MessageBox.Show("Save Current File? Yes / No", "Save file?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                if (DYesNo == DialogResult.Yes)
                {
                    ExecFileSave();
                }
                else
                {
                    ExecInitScreen();
                }
            }
            else
            {
                ExecInitScreen();
            }

            SEDataGrid.Rows.Clear();
            SEDataGrid.ClearSelection();
            SEDataGrid.CurrentCell = null;
            SEDataGrid.Refresh();
            FileLoading = false;
            return;
        }

        private void ExecFileSave()
        {
            int i = 0;
            int iCnt = 0;
            var SE = new SightEntry();
            var loopTo = Information.UBound(SightLogArray);
            for (i = 0; i <= loopTo; i++)
            {
                SE = SightLogArray[i];
                if (SE.EntryStatus == "Active")
                {
                    iCnt += 1;
                }
            }

            if (iCnt == 0)
            {
                ErrorMsgBox("No Data to Save to File - Add Data or Exit");
                FileUpdated = false;
                Show();
                return;
            }

            var saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Title = "Save an Sight Log Text File";
            saveFileDialog1.InitialDirectory = SLDir;
            saveFileDialog1.FileName = SLOpenFName;
            saveFileDialog1.ShowDialog(this);
            if (!string.IsNullOrEmpty(saveFileDialog1.FileName))
            {
                SLOpenFName = saveFileDialog1.FileName;
                var objWriter = new StreamWriter(saveFileDialog1.FileName, false);
                i = 0;
                var loopTo1 = Information.UBound(SightLogArray);
                for (i = 0; i <= loopTo1; i++)
                {
                    SE = SightLogArray[i];
                    if (SE.EntryStatus == "Active")
                    {
                        objWriter.WriteLine(FormatSightForSave(SE));
                    }
                }

                objWriter.Close();
                objWriter.Dispose();
            }

            FileUpdated = false;
            return;
        }

        private string FormatSightForSave(SightEntry SE)
        {
            string SaveStr = Constants.vbNullString;
            string StrParm = ";";
            SaveStr = "No=" + SE.SightNum + StrParm + "Date/Time=" + SE.SightDateTime.ToString("MM/dd/yyyy HH:mm:ss") + StrParm + "SDate=" + SE.SightDateTime.ToString("MM/dd/yyyy") + StrParm + "STime=" + SE.SightDateTime.ToString("HH:mm:ss") + StrParm + "BodyName=" + SE.BodyName + StrParm + "BodyLimb=" + SE.BodyLimb + StrParm + "DST=" + SE.DST + StrParm + "WE=" + SE.WE + StrParm + "WEType=" + SE.WEType + StrParm + "DRLat=" + SE.DRLat + StrParm + "DRLong=" + SE.DRLong + StrParm + "LLoBy=" + SE.LLoBy + StrParm + "HS=" + SE.HS + StrParm + "IC=" + SE.IC + StrParm + "ICType=" + SE.ICType + StrParm + "HE=" + SE.HE + StrParm + "HorDist=" + SE.HorDist + StrParm + "HorDistType=" + SE.HorDistType + StrParm + "HorType=" + SE.HorType + StrParm + "a=" + SE.Intercept + StrParm + "Zn=" + SE.Zn + StrParm + "Name=" + SE.SLName + StrParm + "Squadron=" + SE.SLSquadron + StrParm + "ZD=" + SE.ZD + StrParm + "EP=" + SE.EP + StrParm + "ApprxBrg=" + SE.ApprxBrg + StrParm + "Remarks=" + SE.Remarks + StrParm + "SRGHA=" + SE.SRGHA + StrParm + "SRDEC=" + SE.SRDec + StrParm + "SRHO=" + SE.SRHo + StrParm + "UserInfo=" + SE.UserInfo;
            return SaveStr;
        }

        private void ExecDataSaveasCSV()
        {
            int i = 0;
            int iCnt = 0;
            var SE = new SightEntry();
            var builder = new System.Text.StringBuilder();
            var saveFileDialog1 = new SaveFileDialog();
            var loopTo = Information.UBound(SightLogArray);
            for (i = 0; i <= loopTo; i++)
            {
                SE = SightLogArray[i];
                if (SE.EntryStatus == "Active")
                {
                    iCnt += 1;
                }
            }

            if (iCnt == 0)
            {
                ErrorMsgBox("No Data to Print - Add Data or Exit");
                FileUpdated = false;
                Show();
                return;
            }

            string SLReportFname = SLOpenFName.Replace(".txt", "SLReport.csv");
            saveFileDialog1.InitialDirectory = "./DeckLog/";
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|csv files (*.csv)|*.csv";
            saveFileDialog1.Title = "Save Sight Log as a CSV File";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FileName = SLReportFname;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(saveFileDialog1.FileName))
                {
                    return;
                }

                SLReportFname = saveFileDialog1.FileName;
            }
            else
            {
                return;
            }

            var textstr = new System.Text.StringBuilder();
            string FileHdrStr = Constants.vbNullString;
            for (int idx = 0, loopTo1 = Information.UBound(HdrStr); idx <= loopTo1; idx++)
            {
                if (idx > 0)
                {
                    textstr.Append(",");
                }

                textstr.Append(HdrStr[idx].Trim());
            }

            textstr.AppendLine();
            for (int x = 0, loopTo2 = SEDataGrid.Rows.Count - 1; x <= loopTo2; x++)
            {
                if (Information.IsNothing(SEDataGrid.Rows[x].Cells[0].Value) == false)
                {
                    for (int v = 0, loopTo3 = SEDataGrid.Columns.Count - 8; v <= loopTo3; v++)
                    {
                        // extracting cell value from 0 to 9 and add it on list
                        if (v > 0)
                        {
                            textstr.Append(",");
                        }

                        if (Information.IsNothing(SEDataGrid.Rows[x].Cells[v].Value) == false)
                        {
                            string tempstr = SEDataGrid.Rows[x].Cells[v].Value.ToString().Trim();
                            tempstr = tempstr.Replace(",", ""); // remove any commas input into any field so csv file is not corrupted
                            textstr.Append(tempstr);
                        }
                        else
                        {
                            textstr.Append("");
                        }
                    }
                }
                // adding new line to text
                textstr.AppendLine();
            }

            File.WriteAllText(SLReportFname, textstr.ToString(), System.Text.Encoding.GetEncoding("iso-8859-1"));
            return;
        }

        private void FormatSightintoDG(SightEntry SE)
        {
            try
            {
                // The order of these Sight Array fields must be same as the display order of the grid view field order
                SEDataGrid.Rows.Add(SE.SightNum, SE.SightDateTime.ToString("MM/dd/yyyy HH:mm:ss"), SE.BodyName, SE.BodyLimb, SE.DST, SE.WE, SE.WEType, SE.ZD, SE.HS, SE.HorType, SE.HorDist + " " + SE.HorDistType, SE.ApprxBrg, SE.HE, SE.IC, SE.ICType, SE.DRLat, SE.DRLong, SE.LLoBy, SE.Intercept, SE.Zn, SE.EP, SE.SLName, SE.SLSquadron, SE.WTDiff, SE.HSDiff, SE.HSWTRate, SE.Remarks, SE.SRGHA, SE.SRDec, SE.SRHo, SE.UserInfo);
                return;
            }
            catch (Exception Ex)
            {
                ErrorMsgBox("Error Adding DataGrid Record: " + Ex.Message);
                return;
            }
        }

        private void SelectDGRow(DateTime SightDT, string SightBody)
        {
            int DGLimit = SEDataGrid.DisplayedRowCount(true);
            int cellct = 0;
            int rowct = 0;
            bool FoundDT = false;
            bool FoundBody = false;
            bool FoundRow = false;
            string SearchDT = SightDT.ToString("MM/dd/yyyy HH:mm:ss");
            SEDataGrid.ClearSelection();
            foreach (DataGridViewRow row in SEDataGrid.Rows)
            {
                FoundDT = false;
                FoundBody = false;
                FoundRow = false;
                cellct = 0;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cellct == 1)
                    {
                        if ((cell.Value.ToString() ?? "") == (SearchDT ?? ""))
                        {
                            FoundDT = true;
                        }
                    }

                    if (cellct == 2)
                    {
                        if ((cell.Value.ToString() ?? "") == (SightBody ?? ""))
                        {
                            FoundBody = true;
                        }
                    }

                    if (FoundDT == true & FoundBody == true)
                    {
                        SEDataGrid.ClearSelection();
                        SEDataGrid.CurrentCell = SEDataGrid.Rows.SharedRow(rowct).Cells[cellct];
                        SEDataGrid.Rows[rowct].Selected = true;
                        // row.Selected = True

                        return;
                    }

                    cellct += 1;
                }

                rowct += 1;
            }

            return;
        }

        private void BuildDGFromSightArray()
        {
            int i = 0;
            SEDataGrid.Rows.Clear();
            SEDataGrid.Refresh();
            var loopTo = Information.UBound(SightLogArray);
            for (i = 0; i <= loopTo; i++)
            {
                var SE = SightLogArray[i];
                if (SE.EntryStatus == "Active")
                {
                    FormatSightintoDG(SE);
                }
            }

            SEDataGrid.Refresh();
            return;
        }

        private void ParseReadLine(string rdline)
        {
            EntryIndex = Information.UBound(SightLogArray);
            if (ParseLineIntoSLArray(rdline) == true)
            {
                SightLogArray[EntryIndex] = CommonSE;
                SightLogArray[EntryIndex].EntryStatus = "Active";
                EntryIndex += 1;
                Array.Resize(ref SightLogArray, EntryIndex + 1);
                SightLogArray[EntryIndex].EntryStatus = "Empty";
                SightLogArray[EntryIndex].SightDateTime = DateAndTime.Now.AddDays(365d);
                return;
            }

            return;
        }

        private bool ParseLineIntoSLArray(string rdline)
        {
            var SE = new SightEntry();
            SE.LLoBy = "DR"; // new field added June 2020 - default is DR so preset field to this in case it does not come in on an older file
            string[] ParseArray;
            ParseArray = new string[23];
            ParseArray = Strings.Split(rdline, ";");
            int i = 0;
            int Idx = 0;
            string Param = Constants.vbNullString;
            int DataSt = 0;
            int DataEnd = 0;
            var loopTo = Information.UBound(ParseArray);
            for (i = 0; i <= loopTo; i++)
            {
                Idx = ParseArray[i].IndexOf("=");
                if (Idx > 0)
                {
                    Param = ParseArray[i].Substring(0, Idx);
                    DataSt = Idx + 1;
                    DataEnd = ParseArray[i].Length - (Idx + 1);
                    switch (Param ?? "")
                    {
                        case "Name":
                            {
                                SE.SLName = ParseArray[i].Substring(DataSt, DataEnd);
                                break;
                            }

                        case "Squadron":
                            {
                                SE.SLSquadron = ParseArray[i].Substring(DataSt, DataEnd);
                                break;
                            }

                        case "Num":
                        case "No":
                            {
                                SE.SightNum = ParseArray[i].Substring(DataSt, DataEnd);
                                break;
                            }

                        case "Date/Time":
                            {
                                string tempDT = ParseArray[i].Substring(DataSt, DataEnd).Replace("-", "/");
                                SE.SightDateTime = Convert.ToDateTime(ParseArray[i].Substring(DataSt, DataEnd));
                                break;
                            }

                        case "SDate":
                            {
                                break;
                            }
                        // Dim tempDT1 As String = ParseArray(i).Substring(DataSt, DataEnd).Replace("-", "/")
                        // SE.SightDate = Convert.ToDateTime(tempDT1) 'ParseArray(i).Substring(DataSt, DataEnd)
                        case "STime":
                            {
                                break;
                            }
                        // SE.SightTime = ParseArray(i).Substring(DataSt, DataEnd)
                        case "DST":
                            {
                                SE.DST = ParseArray[i].Substring(DataSt, DataEnd);
                                break;
                            }

                        case "WE":
                            {
                                SE.WE = ParseArray[i].Substring(DataSt, DataEnd);
                                break;
                            }

                        case "WEType":
                            {
                                SE.WEType = ParseArray[i].Substring(DataSt, DataEnd);
                                break;
                            }

                        case "DRLat":
                            {
                                SE.DRLat = ParseArray[i].Substring(DataSt, DataEnd);
                                break;
                            }

                        case "DRLong":
                            {
                                SE.DRLong = ParseArray[i].Substring(DataSt, DataEnd);
                                break;
                            }

                        case "HS":
                            {
                                SE.HS = ParseArray[i].Substring(DataSt, DataEnd);
                                break;
                            }

                        case "IC":
                            {
                                SE.IC = ParseArray[i].Substring(DataSt, DataEnd);
                                break;
                            }

                        case "ICType":
                            {
                                SE.ICType = ParseArray[i].Substring(DataSt, DataEnd);
                                break;
                            }

                        case "HE":
                            {
                                SE.HE = ParseArray[i].Substring(DataSt, DataEnd);
                                break;
                            }

                        case "HorType":
                            {
                                SE.HorType = ParseArray[i].Substring(DataSt, DataEnd);
                                break;
                            }

                        case "BodyName":
                            {
                                SE.BodyName = ParseArray[i].Substring(DataSt, DataEnd);
                                break;
                            }

                        case "BodyLimb":
                            {
                                SE.BodyLimb = ParseArray[i].Substring(DataSt, DataEnd);
                                break;
                            }

                        case "HorDist":
                            {
                                SE.HorDist = ParseArray[i].Substring(DataSt, DataEnd);
                                break;
                            }

                        case "HorDistType":
                            {
                                SE.HorDistType = ParseArray[i].Substring(DataSt, DataEnd);
                                break;
                            }

                        case "Remarks":
                            {
                                SE.Remarks = ParseArray[i].Substring(DataSt, DataEnd);
                                break;
                            }

                        case "a":
                            {
                                SE.Intercept = ParseArray[i].Substring(DataSt, DataEnd);
                                break;
                            }

                        case "Zn":
                            {
                                SE.Zn = ParseArray[i].Substring(DataSt, DataEnd);
                                break;
                            }

                        case "ZD":
                            {
                                SE.ZD = ParseArray[i].Substring(DataSt, DataEnd);
                                break;
                            }

                        case "EP":
                            {
                                SE.EP = ParseArray[i].Substring(DataSt, DataEnd);
                                break;
                            }

                        case "ApprxBrg":
                            {
                                SE.ApprxBrg = ParseArray[i].Substring(DataSt, DataEnd);
                                break;
                            }

                        case "SRGHA":
                            {
                                SE.SRGHA = ParseArray[i].Substring(DataSt, DataEnd);
                                break;
                            }

                        case "SRDEC":
                            {
                                SE.SRDec = ParseArray[i].Substring(DataSt, DataEnd);
                                break;
                            }

                        case "SRHO":
                            {
                                SE.SRHo = ParseArray[i].Substring(DataSt, DataEnd);
                                break;
                            }

                        case "UserInfo":
                            {
                                SE.UserInfo = ParseArray[i].Substring(DataSt, DataEnd);
                                break;
                            }

                        case "LLoBy":
                            {
                                SE.LLoBy = ParseArray[i].Substring(DataSt, DataEnd);
                                break;
                            }

                        default:
                            {
                                var Msg = MessageBox.Show("Invalid Record Read: " + rdline + Constants.vbNewLine + "Ignore & Continue = Yes; Stop = No", "Invalid Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                                if (Msg == DialogResult.Yes)
                                {
                                    ReadError = false;
                                    return false;
                                    return default;
                                }
                                else
                                {
                                    ReadError = true;
                                    return false;
                                    return default;
                                }

                                break;
                            }
                    }
                }
            }

            CommonSE = SE;
            return true;
            return default;
        }

        private void PrepareSightArray()
        {
            bool FirstActive = true;
            // first sort sight log array by sight date/time and assign result back to sight log array

            SightLogArray = SightLogArray.OrderBy(SE => SE.SightDateTime.ToString("yyyy/MM/dd HH:mm:ss")).ToArray();
            // now run through sight log array and for each active entry assign sight number from index 
            int i = 0;
            int LastActiveIdx = -1;
            int SightNumTmp = 1;
            var loopTo = Information.UBound(SightLogArray);
            for (i = 0; i <= loopTo; i++)
            {
                if (SightLogArray[i].EntryStatus == "Active")
                {
                    SightLogArray[i].SightNum = SightNumTmp.ToString();
                    SightNumTmp += 1;
                    if (CheckBoxShowAvg.Checked == false)
                        goto EvalNextSE;
                    SightLogArray[i].HSDouble = CnvtHSStrtoDouble(SightLogArray[i].HS);
                    if (FirstActive == true)
                    {
                        FirstActive = false;
                        SightLogArray[i].WTDiff = "Skipped - 1st Sight";
                        SightLogArray[i].HSDiff = "Skipped - 1st Sight";
                        SightLogArray[i].HSWTRate = "Skipped - 1st Sight";
                    }
                    else if (i > 0 & LastActiveIdx != -1)
                    {
                        if ((SightLogArray[i].BodyName ?? "") != (SightLogArray[i - 1].BodyName ?? "") | (SightLogArray[i].BodyLimb ?? "") != (SightLogArray[i - 1].BodyLimb ?? ""))
                        {
                            SightLogArray[i].WTDiff = "Not the same body";
                            SightLogArray[i].HSDiff = "Not the same body";
                            SightLogArray[i].HSWTRate = "Not the same body";
                            goto EvalNextSE;
                        }

                        var TempTS1 = SightLogArray[i].SightDateTime - SightLogArray[LastActiveIdx].SightDateTime;
                        if (TempTS1.Days != 0 | TempTS1.Hours != 0 | TempTS1.Minutes > 30)
                        {
                            if (TempTS1.Days != 0)
                            {
                                SightLogArray[i].WTDiff = "WT=" + TempTS1.Days.ToString("#0") + "Dy " + TempTS1.Hours.ToString("#0") + "Hr, " + TempTS1.Minutes.ToString("#0") + "Min," + TempTS1.Seconds.ToString("#0") + "Sec";
                            }
                            else if (TempTS1.Hours != 0)
                            {
                                SightLogArray[i].WTDiff = "WT Diff =" + TempTS1.Hours.ToString("#0") + "Hr, " + TempTS1.Minutes.ToString("#0") + "Min, " + TempTS1.Seconds.ToString("#0") + "Sec";
                            }
                            else if (TempTS1.TotalMinutes > 30d)
                            {
                                SightLogArray[i].WTDiff = "WT=" + TempTS1.Minutes.ToString("#0") + "Min," + TempTS1.Seconds.ToString("#0") + "Sec";
                            }

                            SightLogArray[i].HSDiff = "WT Diff Too Large";
                            SightLogArray[i].HSWTRate = "WT Diff Too Large";
                        }
                        else
                        {
                            if (TempTS1.TotalSeconds == 0d)
                            {
                                SightLogArray[i].WTDiff = "0 Sec";
                                SightLogArray[i].HSWTRate = "0 '/sec";
                            }
                            else
                            {
                                SightLogArray[i].WTDiff = TempTS1.TotalSeconds.ToString("##00") + " Sec";
                            }

                            double HSTemp = (SightLogArray[i].HSDouble - SightLogArray[LastActiveIdx].HSDouble) * 60d;
                            if (HSTemp == 0d)
                            {
                                SightLogArray[i].HSDiff = "0 '";
                                SightLogArray[i].HSWTRate = "0 '/sec";
                            }
                            else
                            {
                                SightLogArray[i].HSDiff = ((SightLogArray[i].HSDouble - SightLogArray[LastActiveIdx].HSDouble) * 60d).ToString("F2") + " '";
                            }

                            if (TempTS1.TotalSeconds != 0d & HSTemp != 0d)
                            {
                                SightLogArray[i].HSWTRate = (HSTemp / TempTS1.TotalSeconds).ToString("F2") + " '/sec";
                            }
                        }
                    }

                    LastActiveIdx = i;
                }

            EvalNextSE:
                ;
            }

            return;
        }

        public double CnvtHSStrtoDouble(object HSStr)
        {
            double HSDbl = 0d;
            int HSDegLoc = Strings.InStr(Conversions.ToString(HSStr), Conversions.ToString('°'));
            int HSMinLoc = Strings.InStr(Conversions.ToString(HSStr), "'");
            int HSSecLoc = Strings.InStr(Conversions.ToString(HSStr), Conversions.ToString('"'));
            HSDbl = Convert.ToDouble(Strings.Mid(Conversions.ToString(HSStr), 1, HSDegLoc - 1));
            HSDbl += Convert.ToDouble(Strings.Mid(Conversions.ToString(HSStr), HSDegLoc + 1, HSMinLoc - HSDegLoc - 1)) / 60d;
            if (HSSecLoc != 0)
            {
                HSDbl += Convert.ToDouble(Strings.Mid(Conversions.ToString(HSStr), HSMinLoc + 1, HSSecLoc - HSMinLoc - 1)) / 3600d;
            }

            return HSDbl;
        }

        private void ExecAddNew()
        {
            string SaveSightNum = txtSightNum.Text;
            var SaveSightDT = SightDateTime.Value;
            string SaveBodyName = cboBody.Items[cboBody.SelectedIndex].ToString();
            FileLoading = true;
            EditError = false;
            if (EditScreenFields() == true)
            {
                // 
                if (CheckBoxAutoReduce.Checked == true)
                {
                    PerformSRF();
                }
                // build new sight entry into array from screen data
                BuildArrayFromscreen();
                // now rebuild list box display of sight array
                PrepareSightArray();
                BuildDGFromSightArray();
                if (CountActiveSEArray() > 0)
                {
                    btnSaveLog.Visible = true;
                    btnPrintDG.Visible = true;
                    btnSLReport.Visible = true;
                    btnSaveLogAsTxt.Visible = true;
                    btnUpdateExisting.Visible = true;
                    btnDeleteSight.Visible = true;
                    btnSightReduce.Visible = false;
                    btnAltSR.Visible = false;
                    btnPlanSight.Visible = false;
                }

                FileUpdated = true;
                FileLoading = false;
            }
            else
            {
                EditError = true;
            }

            SelectDGRow(SaveSightDT, SaveBodyName);
            return;
        }

        private void BuildArrayFromscreen()
        {
            int Idx = Information.UBound(SightLogArray);
            int SightNumTemp = Idx + 1;
            SightLogArray[Idx].SightNum = SightNumTemp.ToString("###0");
            // txtSightNum.Text = SightNumTemp.ToString("###0")
            SightLogArray[Idx].EntryStatus = "Active";
            SightLogArray[Idx].SLName = txtName.Text;
            SightLogArray[Idx].SLSquadron = txtSquadron.Text;
            SightLogArray[Idx].SightDateTime = SightDateTime.Value;
            // SightLogArray(Idx).SightDate = SightDateTime.Value.ToShortDateString
            // SightLogArray(Idx).SightTime = SightDateTime.Value.ToLongTimeString
            // If SightLogArray(Idx).SightDateTime.IsDaylightSavingTime Then
            // SightLogArray(Idx).DST = "X"
            // Else
            if (chkbxDST.Checked == true)
            {
                SightLogArray[Idx].DST = "X";
            }
            else
            {
                SightLogArray[Idx].DST = "";
            }
            // End If
            SightLogArray[Idx].WE = txtWE.Text;
            if (cbWEType.SelectedIndex == 0)
            {
                SightLogArray[Idx].WEType = "Fast";
            }
            else
            {
                SightLogArray[Idx].WEType = "Slow";
            }

            string LatStr = txtLDeg.Text.ToString() + '°' + string.Format(txtLMin.Text.ToString(), "00.0") + "'";
            if (cboL.SelectedIndex == 0)
            {
                LatStr = LatStr + CommonGlobals.g_LatN;
            }
            else
            {
                LatStr = LatStr + CommonGlobals.g_LatS;
            }

            SightLogArray[Idx].DRLat = LatStr;
            string LongStr = txtLoDeg.Text.ToString() + '°' + string.Format(txtLoMin.Text.ToString(), "00.0") + "'";
            if (cboLo.SelectedIndex == 0)
            {
                LongStr = LongStr + CommonGlobals.g_LongW;
            }
            else
            {
                LongStr = LongStr + CommonGlobals.g_LongE;
            }

            SightLogArray[Idx].DRLong = LongStr;
            SightLogArray[Idx].LLoBy = cboLLoBy.Items[cboLLoBy.SelectedIndex].ToString();
            if (cboHSIEFmt.SelectedIndex == 0)
            {
                SightLogArray[Idx].HS = txtHSDeg.Text.ToString() + '°' + string.Format(txtHSMin.Text.ToString(), "00.0") + "'";
                SightLogArray[Idx].HSDouble = Convert.ToDouble(txtHSDeg.Text.ToString()) + Convert.ToDouble(txtHSMin.Text.ToString()) / 60d;
            }
            else
            {
                SightLogArray[Idx].HS = txtHSDeg.Text.ToString() + '°' + string.Format(txtHSMin.Text.ToString(), "00") + "'" + string.Format(txtHsSec.Text.ToString(), "00") + '"';
                SightLogArray[Idx].HSDouble = Convert.ToDouble(txtHSDeg.Text.ToString()) + Convert.ToDouble(txtHSMin.Text.ToString()) / 60d + Convert.ToDouble(txtHsSec.Text.ToString()) / 3600d;
            }

            // SightLogArray(Idx).WTDiff = 0
            // SightLogArray(Idx).HSDiff = 0
            // SightLogArray(Idx).HSWTRate = 0

            if (cboHSIEFmt.SelectedIndex == 0)
            {
                SightLogArray[Idx].IC = txtIEDeg.Text.ToString() + '°' + string.Format(txtIE.Text.ToString(), "00.0") + "'";
            }
            else
            {
                SightLogArray[Idx].IC = txtIEDeg.Text.ToString() + '°' + string.Format(txtIE.Text.ToString(), "00") + "'" + string.Format(txtIESec.Text.ToString(), "00") + '"';
            }

            if (cbIEType.SelectedIndex == 0)
            {
                SightLogArray[Idx].ICType = "On";
            }
            else
            {
                SightLogArray[Idx].ICType = "Off";
            }

            SightLogArray[Idx].HE = txtHE.Text.ToString();
            switch (cboHEUnit.SelectedIndex)
            {
                case 0:
                    {
                        SightLogArray[Idx].HE += " ft";
                        break;
                    }

                case 1:
                    {
                        SightLogArray[Idx].HE += " in";
                        break;
                    }

                case 2:
                    {
                        SightLogArray[Idx].HE += " m ";
                        break;
                    }

                case 3:
                    {
                        SightLogArray[Idx].HE += " cm";
                        break;
                    }
            }

            switch (cbHorizon.SelectedIndex)
            {
                case 0:
                    {
                        SightLogArray[Idx].HorType = "Natural";
                        break;
                    }

                case 1:
                    {
                        SightLogArray[Idx].HorType = "Dip Short";
                        break;
                    }

                case 2:
                    {
                        SightLogArray[Idx].HorType = "Artificial";
                        break;
                    }

                case 3:
                    {
                        SightLogArray[Idx].HorType = "Bubble";
                        break;
                    }

                default:
                    {
                        SightLogArray[Idx].HorType = "Natural";
                        break;
                    }
            }

            SightLogArray[Idx].BodyName = cboBody.Items[cboBody.SelectedIndex].ToString();
            switch (cbLimb.SelectedIndex)
            {
                case 0:
                    {
                        SightLogArray[Idx].BodyLimb = "Lower";
                        break;
                    }

                case 1:
                    {
                        SightLogArray[Idx].BodyLimb = "Upper";
                        break;
                    }

                case 2:
                    {
                        SightLogArray[Idx].BodyLimb = "Center";
                        break;
                    }
            }

            SightLogArray[Idx].HorDist = txtHorDist.Text.ToString();
            switch (cbHorDistType.SelectedIndex)
            {
                case 0:
                    {
                        SightLogArray[Idx].HorDistType = "Feet";
                        break;
                    }

                case 1:
                    {
                        SightLogArray[Idx].HorDistType = "Yards";
                        break;
                    }

                case 2:
                    {
                        SightLogArray[Idx].HorDistType = "Meters";
                        break;
                    }

                case 3:
                    {
                        SightLogArray[Idx].HorDistType = "Statute Mile";
                        break;
                    }

                case 4:
                    {
                        SightLogArray[Idx].HorDistType = "Nautical Mile";
                        break;
                    }

                default:
                    {
                        SightLogArray[Idx].HorDistType = "Feet";
                        break;
                    }
            }

            SightLogArray[Idx].Remarks = txtRemarks.Text.ToString();
            SightLogArray[Idx].ZD = cboZD.Items[cboZD.SelectedIndex].ToString();
            SightLogArray[Idx].EP = txtSRFEP.Text.ToString();
            SightLogArray[Idx].SRGHA = txtSRGHA.Text;
            SightLogArray[Idx].SRDec = txtSRDec.Text;
            SightLogArray[Idx].SRHo = txtSRHo.Text;
            SightLogArray[Idx].UserInfo = txtUserInfo.Text;
            if (SRFFormIntercept != 0d | SRFFormZN != 0d)
            {
                if (SRFFormIntercept >= 0d)
                {
                    SightLogArray[Idx].Intercept = Math.Abs(SRFFormIntercept).ToString() + " nm Away";
                }
                else
                {
                    SightLogArray[Idx].Intercept = Math.Abs(SRFFormIntercept).ToString() + " nm Toward";
                }

                SightLogArray[Idx].Zn = SRFFormZN.ToString() + '°';
            }
            else
            {
                SightLogArray[Idx].Intercept = Constants.vbNullString;
                SightLogArray[Idx].Zn = Constants.vbNullString;
            }

            SightLogArray[Idx].ApprxBrg = cboApprxBrg.Items[cboApprxBrg.SelectedIndex].ToString();

            // sort sight array by date/time field and assign sight num to each record
            PrepareSightArray();
            EntryIndex = Information.UBound(SightLogArray);
            EntryIndex += 1;
            Array.Resize(ref SightLogArray, EntryIndex + 1);
            SightLogArray[EntryIndex].EntryStatus = "Empty";
            SightLogArray[EntryIndex].SightDateTime = DateAndTime.Now.AddDays(365d);
            return;
        }

        private bool EditScreenFields()
        {
            if (!EditNameField())
            {
                return false;
            }

            if (!EditSquadronField())
            {
                return false;
            }

            if (!EditWEField())
            {
                return false;
            }

            if (!EditDRLatField())
            {
                return false;
            }

            if (!EditDRLongField())
            {
                return false;
            }

            if (!EditDSTField()) // the DST edits need to occur after Lat & Long edits because it will use ZTInfo form to populate DST field
            {
                return false;
            }

            if (!EditHSField())
            {
                return false;
            }

            if (!EditIEField())
            {
                return false;
            }

            if (!EditHEField())
            {
                return false;
            }

            if (!EditDSField())
            {
                return false;
            }

            if (!EditLimbHorizon())
            {
                return false;
            }

            if (!EditApprxBrg())
            {
                return false;
            }

            return true;
        }

        private bool EditApprxBrg()
        {
            if (cboApprxBrg.Items[cboApprxBrg.SelectedIndex].ToString() == "None")
            {
                cboApprxBrg.SelectedIndex = 4; // default to S - south approx bearing
                                               // ErrorMsgBox("Approximate Bearing Selection Required")
            }

            return true;
            return default;
        }

        private bool EditLimbHorizon()
        {
            if (cbHorizon.SelectedText == "Bubble")
            {
                if (cbLimb.SelectedText == "Upper" | cbLimb.SelectedText == "Lower")
                {
                    ErrorMsgBox("Invalid combination of Horizon and Limb selected");
                    return false;
                }
            }

            if (cbLimb.SelectedText == "Center")
            {
                if (cbHorizon.SelectedText == "Natural" | cbHorizon.SelectedText == "Dip Short")
                {
                    ErrorMsgBox("Invalid combination of Horizon and Limb selected");
                    return false;
                }
            }

            if (cbLimb.SelectedText == "Center")
            {
                if (cboBody.SelectedText == "Sun" | cboBody.SelectedText == "Moon")
                {
                    ErrorMsgBox("Invalid combination of Horizon and Limb selected");
                    return false;
                }
            }

            return true;
            return default;
        }

        private bool EditNameField()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                ErrorMsgBox("Missing Name - Enter A Name");
                return false;
            }

            return true;
        }

        private bool EditSquadronField()
        {
            if (string.IsNullOrEmpty(txtSquadron.Text))
            {
                ErrorMsgBox("Missing Squadron Name - Enter Squadron Name");
                return false;
            }

            return true;
        }

        private bool EditWEField()
        {
            if (string.IsNullOrEmpty(txtWE.Text) | Conversions.ToBoolean("0") | Conversions.ToBoolean("00") | Conversions.ToBoolean("000"))
            {
                txtWE.Text = "0000";
            }

            if (txtWE.Text.Length < 4)
            {
                ErrorMsgBox("Watch Error format is mmss and must be 4 numbers in length - Correct And Reenter");
                return false;
            }

            if (Information.IsNumeric(txtWE.Text))
            {
                int WEMin = Conversions.ToInteger(txtWE.Text.Substring(0, 2));
                if (WEMin < 0 | WEMin > 59)
                {
                    ErrorMsgBox("Invalid Watch Error Minutes - Must be 0 to 59 - Correct And Reenter");
                    return false;
                }

                int WESec = Conversions.ToInteger(txtWE.Text.Substring(2, 2));
                if (WESec < 0 | WESec > 59)
                {
                    ErrorMsgBox("Invalid Watch Error Second - must be 0 to 59 - Correct And Reenter");
                    return false;
                }
            }
            else
            {
                ErrorMsgBox("Watch Error Format is mmss and must be 4 numbers in length - Correct And Reenter");
                return false;
            }

            return true;
        }

        private bool EditDSTField()
        {
            // If chkUseZTInfo.Checked = True Then
            // ZTInfo.Show()
            // ZTInfo.txtLoDegA.Text = txtLoDeg.Text
            // ZTInfo.txtLoMinA.Text = txtLoMin.Text
            // ZTInfo.cboLoA.SelectedIndex = cboLo.SelectedIndex
            // ZTInfo.DTLocA.Value = SightDateTime.Value
            // ZTInfo.UpdateSLDST = True
            // 'If ZTInfo.LocALLoDTisDST = True Then
            // '    chkbxDST.Checked = True
            // 'Else
            // '    chkbxDST.Checked = False
            // 'End If
            // Else
            // ZTInfo.UpdateSLDST = False
            // End If
            return true;
        }

        private bool EditDRLatField()
        {
            if (string.IsNullOrEmpty(txtLDeg.Text))
            {
                ErrorMsgBox("Missing DRLat Degrees - Required Field");
                return false;
            }

            if (string.IsNullOrEmpty(txtLMin.Text))
            {
                txtLMin.Text = "00";
            }

            try // if either the Deg or Min field has data that will not convert to Int or Double, catch the exception and show error message
            {
                int DRLatDeg = Convert.ToInt32(txtLDeg.Text.ToString());
                if (DRLatDeg < 0 | DRLatDeg > 89)
                {
                    ErrorMsgBox("Invalid DR Lat Degrees Entered - Must > 0 And < 90");
                    return false;
                }

                double DRLatMin = Convert.ToDouble(txtLMin.Text.ToString().Trim());
                if (DRLatMin < 0d | DRLatMin > 59.9d)
                {
                    ErrorMsgBox("Invalid DRLat Minutes Entered - Must >= 0 And < 60");
                    return false;
                }

                return true;
            }
            catch (Exception Ex)
            {
                ErrorMsgBox("Error in DRLat Degree Or Minutes Field.  Original error: " + Ex.Message);
                return false;
            }

            return true;
            return default;
        }

        private bool EditDRLongField()
        {
            if (string.IsNullOrEmpty(txtLoDeg.Text))
            {
                ErrorMsgBox("Missing DRLong Degrees - Required Field");
                return false;
            }

            if (string.IsNullOrEmpty(txtLoMin.Text))
            {
                txtLoMin.Text = "00";
            }

            try
            {
                int DRLongDeg = Convert.ToInt32(txtLoDeg.Text.ToString());
                if (DRLongDeg < 0 | DRLongDeg > 179)
                {
                    ErrorMsgBox("Invalid DR Long Degrees Entered - Must > 0 And < 90");
                    return false;
                }

                double DRLongMin = Convert.ToDouble(txtLoMin.Text.ToString());
                if (DRLongMin < 0d | DRLongMin > 59.9d)
                {
                    ErrorMsgBox("Invalid DRLong Minutes Entered - Must >= 0 And < 60");
                    return false;
                }

                return true;
            }
            catch (Exception Ex)
            {
                ErrorMsgBox("Error in DRLong Degree Or Minutes Fields.  Original error: " + Ex.Message);
                return false;
            }

            return true;
            return default;
        }

        private bool EditHSField()
        {
            if (string.IsNullOrEmpty(txtHSDeg.Text))
            {
                ErrorMsgBox("Missing HS Degrees - Required Field");
                return false;
            }

            if (string.IsNullOrEmpty(txtHSMin.Text))
            {
                txtHSMin.Text = "00";
            }

            if (cboHSIEFmt.SelectedIndex == 1)
            {
                if (string.IsNullOrEmpty(txtHsSec.Text))
                {
                    txtHsSec.Text = "00";
                }

                if (txtHSMin.Text.ToString().Contains("."))
                {
                    ErrorMsgBox("Invalid HS Min and Sec Entered - Min can not contain decimal");
                    return false;
                }
            }

            try
            {
                int HSDeg = Convert.ToInt32(txtHSDeg.Text.ToString());
                if (HSDeg < 0 | HSDeg > 89)
                {
                    ErrorMsgBox("Invalid HS Degrees Entered - Must >= 0 And < 90");
                    return false;
                }

                double HSMin = Convert.ToDouble(txtHSMin.Text.ToString());
                if (HSMin < 0d | HSMin > 59.9d)
                {
                    ErrorMsgBox("Invalid HS Minutes Entered - Must >= 0 And < 60");
                    return false;
                }

                if (cboHSIEFmt.SelectedIndex == 1)
                {
                    double HSSec = Convert.ToDouble(txtHsSec.Text.ToString());
                    if (HSSec < 0d | HSSec > 59.9d)
                    {
                        ErrorMsgBox("Invalid HS Seconds Entered - Must >= 0 And < 60");
                        return false;
                    }
                }

                return true;
            }
            catch (Exception Ex)
            {
                ErrorMsgBox("Error in HS Degree Or Minutes Fields.  Original error: " + Ex.Message);
                return false;
            }

            return true;
            return default;
        }

        private bool EditIEField()
        {
            if (string.IsNullOrEmpty(txtIE.Text))
            {
                txtIE.Text = "00";
            }

            if (string.IsNullOrEmpty(txtIEDeg.Text))
            {
                txtIEDeg.Text = "00";
            }

            if (cboHSIEFmt.SelectedIndex == 1)
            {
                if (string.IsNullOrEmpty(txtIESec.Text))
                {
                    txtIESec.Text = "00";
                }

                if (txtIESec.Text.ToString().Contains("."))
                {
                    ErrorMsgBox("Invalid IE Min and Sec Entered - Min can not contain decimal");
                    return false;
                }
            }

            try
            {
                double IEdCalc = Convert.ToDouble(txtIEDeg.Text.ToString());
                if (IEdCalc < 0d | IEdCalc > 59.9d)
                {
                    ErrorMsgBox("Invalid IE Deg Entered - Must >= 0 And < 60");
                    return false;
                }

                double IECalc = Convert.ToDouble(txtIE.Text.ToString());
                if (IECalc < 0d | IECalc > 59.9d)
                {
                    ErrorMsgBox("Invalid IE Min Entered - Must >= 0 And < 60");
                    return false;
                }

                if (cboHSIEFmt.SelectedIndex == 1)
                {
                    double IESec = Convert.ToDouble(txtIESec.Text.ToString());
                    if (IESec < 0d | IESec > 59.9d)
                    {
                        ErrorMsgBox("Invalid IE Seconds Entered - Must >= 0 And < 60");
                        return false;
                    }
                }

                return true;
            }
            catch (Exception Ex)
            {
                ErrorMsgBox("Error in IE Fields.  Original error: " + Ex.Message);
                return false;
            }

            return true;
            return default;
        }

        private bool EditHEField()
        {
            if (string.IsNullOrEmpty(txtHE.Text))
            {
                txtHE.Text = "00";
            }

            try
            {
                double HECalc = Convert.ToDouble(txtHE.Text.ToString());
                if (HECalc < 0d | HECalc >= 99.9d)
                {
                    ErrorMsgBox("Invalid HE Entered - Must >= 0 Or < 100 ");
                    return false;
                }

                return true;
            }
            catch (Exception Ex)
            {
                ErrorMsgBox("Error in HE Fields.  Original error: " + Ex.Message);
                return false;
            }

            return true;
            return default;
        }

        private bool EditDSField()
        {
            if (string.IsNullOrEmpty(txtHorDist.Text))
            {
                txtHorDist.Text = "00";
            }

            try
            {
                double DSCalc = Convert.ToDouble(txtHorDist.Text.ToString());
                if (DSCalc < 0d | DSCalc > 9999.9d)
                {
                    ErrorMsgBox("Invalid Dip Short Distance - Must >= 0 Or < 100 ");
                    return false;
                }

                return true;
                if (cbHorizon.SelectedIndex == 1 & DSCalc == 0d)
                {
                    ErrorMsgBox("Missing Dip Short Distance Entered - Cannot be Zero  ");
                    return false;
                }
            }
            catch (Exception Ex)
            {
                ErrorMsgBox("Error in Dis Distance.  Original error: " + Ex.Message);
                return false;
            }

            return true;
            return default;
        }

        private int CountActiveSEArray()
        {
            int ActiveCnt = 0;
            int i = 0;
            var loopTo = Information.UBound(SightLogArray);
            for (i = 0; i <= loopTo; i++)
            {
                if (SightLogArray[i].EntryStatus == "Active")
                {
                    ActiveCnt += 1;
                }
            }

            return ActiveCnt;
        }

        private int GetBNameIdx(string NameStr)
        {
            int i = 0;
            var loopTo = Information.UBound(BNameArray);
            for (i = 0; i <= loopTo; i++)
            {
                if ((BNameArray[i] ?? "") == (NameStr ?? ""))
                {
                    return i;
                    return default;
                }
            }

            return 0;
            return default;
        }

        private void SEDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (FileLoading == true)
                return;
            int n = SEDataGrid.CurrentRow.Index;
            // The order of these variable and the integer indexs contained in each MUST match the order of the fields in the data grid
            btnNoonSight.Visible = false;
            txtName.Text = Conversions.ToString(SEDataGrid.Rows[n].Cells[SLNameCell].Value);
            txtSquadron.Text = Conversions.ToString(SEDataGrid.Rows[n].Cells[SLSquadron].Value);
            txtSightNum.Text = Conversions.ToString(SEDataGrid.Rows[n].Cells[SightNumCell].Value);
            SightDateTime.Value = Conversions.ToDate(SEDataGrid.Rows[n].Cells[SightDateTimeCell].Value);
            if (SEDataGrid.Rows[n].Cells[DSTCell].Value.ToString() == "X")
            {
                chkbxDST.Checked = true;
            }
            else
            {
                chkbxDST.Checked = false;
            }

            txtWE.Text = Conversions.ToString(SEDataGrid.Rows[n].Cells[WECell].Value);
            if (SEDataGrid.Rows[n].Cells[WETypeCell].Value.ToString() == "Fast")
            {
                cbWEType.SelectedIndex = 0;
            }
            else
            {
                cbWEType.SelectedIndex = 1;
            }

            int DegIdx = SEDataGrid.Rows[n].Cells[DRLatCell].Value.ToString().IndexOf('°'.ToString());
            txtLDeg.Text = SEDataGrid.Rows[n].Cells[DRLatCell].Value.ToString().Substring(0, DegIdx);
            int MinIdx = SEDataGrid.Rows[n].Cells[DRLatCell].Value.ToString().IndexOf("'") - 1;
            txtLMin.Text = SEDataGrid.Rows[n].Cells[DRLatCell].Value.ToString().Substring(DegIdx + 1, MinIdx - DegIdx);
            MinIdx = SEDataGrid.Rows[n].Cells[DRLatCell].Value.ToString().IndexOf("'");
            if ((SEDataGrid.Rows[n].Cells[DRLatCell].Value.ToString().Substring(MinIdx + 1, 1) ?? "") == (CommonGlobals.g_LatN ?? ""))
            {
                cboL.SelectedIndex = 0;
            }
            else
            {
                cboL.SelectedIndex = 1;
            }

            DegIdx = SEDataGrid.Rows[n].Cells[DRLongCell].Value.ToString().IndexOf('°'.ToString());
            txtLoDeg.Text = SEDataGrid.Rows[n].Cells[DRLongCell].Value.ToString().Substring(0, DegIdx);
            MinIdx = SEDataGrid.Rows[n].Cells[DRLongCell].Value.ToString().IndexOf("'") - 1;
            txtLoMin.Text = SEDataGrid.Rows[n].Cells[DRLongCell].Value.ToString().Substring(DegIdx + 1, MinIdx - DegIdx);
            MinIdx = SEDataGrid.Rows[n].Cells[DRLongCell].Value.ToString().IndexOf("'");
            if ((SEDataGrid.Rows[n].Cells[DRLongCell].Value.ToString().Substring(MinIdx + 1, 1) ?? "") == (CommonGlobals.g_LongW ?? ""))
            {
                cboLo.SelectedIndex = 0;
            }
            else
            {
                cboLo.SelectedIndex = 1;
            }

            if (SEDataGrid.Rows[n].Cells[HSCell].Value.ToString().Contains(Conversions.ToString('"')) | SEDataGrid.Rows[n].Cells[ICCell].Value.ToString().Contains(Conversions.ToString('"')))
            {
                cboHSIEFmt.SelectedIndex = 1;
            }
            else
            {
                cboHSIEFmt.SelectedIndex = 0;
            }

            DegIdx = SEDataGrid.Rows[n].Cells[HSCell].Value.ToString().IndexOf('°'.ToString());
            txtHSDeg.Text = SEDataGrid.Rows[n].Cells[HSCell].Value.ToString().Substring(0, DegIdx);
            MinIdx = SEDataGrid.Rows[n].Cells[HSCell].Value.ToString().IndexOf("'") - 1;
            txtHSMin.Text = SEDataGrid.Rows[n].Cells[HSCell].Value.ToString().Substring(DegIdx + 1, MinIdx - DegIdx);
            if (SEDataGrid.Rows[n].Cells[HSCell].Value.ToString().Contains(Conversions.ToString('"')))
            {
                int SecIdx = SEDataGrid.Rows[n].Cells[HSCell].Value.ToString().IndexOf('"') - 1;
                txtHsSec.Text = SEDataGrid.Rows[n].Cells[HSCell].Value.ToString().Substring(MinIdx + 2, SecIdx - 1 - MinIdx);
            }
            else
            {
                txtHsSec.Clear();
            }

            DegIdx = SEDataGrid.Rows[n].Cells[ICCell].Value.ToString().IndexOf('°'.ToString());
            txtIEDeg.Text = SEDataGrid.Rows[n].Cells[ICCell].Value.ToString().Substring(0, DegIdx);
            MinIdx = SEDataGrid.Rows[n].Cells[ICCell].Value.ToString().IndexOf("'") - 1;
            txtIE.Text = SEDataGrid.Rows[n].Cells[ICCell].Value.ToString().Substring(DegIdx + 1, MinIdx - DegIdx);
            if (SEDataGrid.Rows[n].Cells[ICCell].Value.ToString().Contains(Conversions.ToString('"')))
            {
                int SecIdx = SEDataGrid.Rows[n].Cells[ICCell].Value.ToString().IndexOf('"') - 1;
                txtIESec.Text = SEDataGrid.Rows[n].Cells[ICCell].Value.ToString().Substring(MinIdx + 2, SecIdx - 1 - MinIdx);
            }
            else
            {
                txtIESec.Clear();
            }

            if (SEDataGrid.Rows[n].Cells[ICTypeCell].Value.ToString().Substring(0, 2) == "On")
            {
                cbIEType.SelectedIndex = 0;
            }
            else
            {
                cbIEType.SelectedIndex = 1;
            }

            int firstSpace = SEDataGrid.Rows[n].Cells[HECell].Value.ToString().IndexOf(CommonGlobals.g_StrSpace);
            string HEstr = string.Empty;
            string HEUnit = string.Empty;
            if (firstSpace == -1)
            {
                HEstr = SEDataGrid.Rows[n].Cells[HECell].Value.ToString();
            }
            else
            {
                HEstr = SEDataGrid.Rows[n].Cells[HECell].Value.ToString().Substring(0, firstSpace);
                HEUnit = SEDataGrid.Rows[n].Cells[HECell].Value.ToString().Substring(firstSpace);
            }

            txtHE.Text = HEstr;
            switch (HEUnit ?? "")
            {
                case " ft":
                    {
                        cboHEUnit.SelectedIndex = 0;
                        break;
                    }

                case " in":
                    {
                        cboHEUnit.SelectedIndex = 1;
                        break;
                    }

                case " m ":
                    {
                        cboHEUnit.SelectedIndex = 2;
                        break;
                    }

                case " cm":
                    {
                        cboHEUnit.SelectedIndex = 3;
                        break;
                    }

                default:
                    {
                        cboHEUnit.SelectedIndex = 0;
                        break;
                    }
            }

            string HorType1 = SEDataGrid.Rows[n].Cells[HorTypeCell].Value.ToString().Substring(0, 1);
            switch (HorType1 ?? "")
            {
                case var @case when @case == (CommonGlobals.g_LatN ?? ""):
                    {
                        cbHorizon.SelectedIndex = 0;
                        break;
                    }

                case "D":
                    {
                        cbHorizon.SelectedIndex = 1;
                        break;
                    }

                case "A":
                    {
                        cbHorizon.SelectedIndex = 2;
                        break;
                    }

                case "B":
                    {
                        cbHorizon.SelectedIndex = 3;
                        break;
                    }
            }

            if (SEDataGrid.Rows[n].Cells[BodyNameCell].Value.ToString() == "Sun")
            {
                btnNoonSight.Visible = true;
            }

            cboBody.SelectedIndex = GetBNameIdx(SEDataGrid.Rows[n].Cells[BodyNameCell].Value.ToString());
            string Limb = SEDataGrid.Rows[n].Cells[BodyLimbCell].Value.ToString().Substring(0, 1);
            switch (Limb ?? "")
            {
                case "L":
                    {
                        cbLimb.SelectedIndex = 0;
                        break;
                    }

                case "U":
                    {
                        cbLimb.SelectedIndex = 1;
                        break;
                    }

                case "C":
                    {
                        cbLimb.SelectedIndex = 2;
                        break;
                    }

                default:
                    {
                        cbLimb.SelectedIndex = 3;
                        break;
                    }
            }

            int DSSpace = SEDataGrid.Rows[n].Cells[HorDistCell].Value.ToString().IndexOf(CommonGlobals.g_StrSpace);
            int DSLen = SEDataGrid.Rows[n].Cells[HorDistCell].Value.ToString().Length;
            txtHorDist.Text = SEDataGrid.Rows[n].Cells[HorDistCell].Value.ToString().Substring(0, DSSpace);
            string HDType = SEDataGrid.Rows[n].Cells[HorDistCell].Value.ToString().Substring(DSSpace + 1, DSLen - (DSSpace + 1));
            switch (HDType ?? "")
            {
                case "Feet":
                    {
                        cbHorDistType.SelectedIndex = 0;
                        break;
                    }

                case "Yards":
                    {
                        cbHorDistType.SelectedIndex = 1;
                        break;
                    }

                case "Meters":
                    {
                        cbHorDistType.SelectedIndex = 2;
                        break;
                    }

                case "Statute Mile":
                    {
                        cbHorDistType.SelectedIndex = 3;
                        break;
                    }

                case "Nautical Mile":
                    {
                        cbHorDistType.SelectedIndex = 4;
                        break;
                    }

                default:
                    {
                        cbHorDistType.SelectedIndex = 0;
                        break;
                    }
            }

            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(SEDataGrid.Rows[n].Cells[RemarksCell].Value, Constants.vbNullString, false)))
            {
                txtRemarks.Clear();
            }
            else
            {
                txtRemarks.Text = SEDataGrid.Rows[n].Cells[RemarksCell].Value.ToString();
            }

            // If SEDataGrid.Rows(n).Cells(InterceptCell).Value = Nothing Or SEDataGrid.Rows(n).Cells(InterceptCell).Value = vbNullString Then
            // txtIntZn.Clear()
            // Else
            // txtIntZn.AppendText(" a= " & SEDataGrid.Rows(n).Cells(InterceptCell).Value.ToString & "  ")
            // End If

            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(SEDataGrid.Rows[n].Cells[LLoByCell].Value, Constants.vbNullString, false)))
            {
                cboLLoBy.SelectedIndex = 0;
            }
            else
            {
                cboLLoBy.Text = SEDataGrid.Rows[n].Cells[LLoByCell].Value.ToString();
            }

            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(SEDataGrid.Rows[n].Cells[SLEP].Value, Constants.vbNullString, false)))
            {
                txtSRFEP.Clear();
            }
            else
            {
                txtSRFEP.Clear();
                txtSRFEP.AppendText(SEDataGrid.Rows[n].Cells[SLEP].Value.ToString());
            }

            // If SEDataGrid.Rows(n).Cells(ZnCell).Value = vbNullString Then
            // txtIntZn.Clear()
            // Else
            // txtIntZn.AppendText(" a= " & SEDataGrid.Rows(n).Cells(ZnCell).Value.ToString & "  ")
            // End If

            if (Conversions.ToBoolean(Operators.OrObject(Operators.ConditionalCompareObjectEqual(SEDataGrid.Rows[n].Cells[InterceptCell].Value, null, false), Operators.ConditionalCompareObjectEqual(SEDataGrid.Rows[n].Cells[InterceptCell].Value, Constants.vbNullString, false))))
            {
                txtIntZn.Clear();
                PlotIntercept = Constants.vbNullString;
                PlotAzimuth = Constants.vbNullString;
                btnUseCLS.Visible = false;
                btnCustomPlot.Visible = false;
            }
            else
            {
                txtIntZn.Clear();
                txtIntZn.AppendText(SEDataGrid.Rows[n].Cells[InterceptCell].Value.ToString() + " " + SEDataGrid.Rows[n].Cells[ZnCell].Value.ToString());
                PlotIntercept = SEDataGrid.Rows[n].Cells[InterceptCell].Value.ToString();
                PlotAzimuth = SEDataGrid.Rows[n].Cells[ZnCell].Value.ToString();
                btnUseCLS.Visible = true;
                btnCustomPlot.Visible = true;
            }

            int TurnAltSROn = 0;
            if (Conversions.ToBoolean(Operators.OrObject(Operators.ConditionalCompareObjectEqual(SEDataGrid.Rows[n].Cells[SLGHACell].Value, null, false), Operators.ConditionalCompareObjectEqual(SEDataGrid.Rows[n].Cells[SLGHACell].Value, Constants.vbNullString, false))))
            {
                txtSRGHA.Clear();
            }
            else
            {
                txtSRGHA.Clear();
                txtSRGHA.AppendText(SEDataGrid.Rows[n].Cells[SLGHACell].Value.ToString());
                TurnAltSROn += 1;
            }

            if (Conversions.ToBoolean(Operators.OrObject(Operators.ConditionalCompareObjectEqual(SEDataGrid.Rows[n].Cells[SLDecCell].Value, null, false), Operators.ConditionalCompareObjectEqual(SEDataGrid.Rows[n].Cells[SLDecCell].Value, Constants.vbNullString, false))))
            {
                txtSRDec.Clear();
            }
            else
            {
                txtSRDec.Clear();
                txtSRDec.AppendText(SEDataGrid.Rows[n].Cells[SLDecCell].Value.ToString());
                TurnAltSROn += 1;
            }

            if (Conversions.ToBoolean(Operators.OrObject(Operators.ConditionalCompareObjectEqual(SEDataGrid.Rows[n].Cells[SLHoCell].Value, null, false), Operators.ConditionalCompareObjectEqual(SEDataGrid.Rows[n].Cells[SLHoCell].Value, Constants.vbNullString, false))))
            {
                txtSRHo.Clear();
            }
            else
            {
                txtSRHo.Clear();
                txtSRHo.AppendText(SEDataGrid.Rows[n].Cells[SLHoCell].Value.ToString());
                TurnAltSROn += 1;
            }

            if (Conversions.ToBoolean(Operators.OrObject(Operators.ConditionalCompareObjectEqual(SEDataGrid.Rows[n].Cells[UserInfoCell].Value, null, false), Operators.ConditionalCompareObjectEqual(SEDataGrid.Rows[n].Cells[UserInfoCell].Value, Constants.vbNullString, false))))
            {
                txtUserInfo.Clear();
            }
            else
            {
                txtUserInfo.Clear();
                txtUserInfo.AppendText(SEDataGrid.Rows[n].Cells[UserInfoCell].Value.ToString());
            }

            if (TurnAltSROn == 3)
            {
                btnAltSR.Visible = true;
            }
            // btnSightReduce.Visible = True
            // btnPlanSight.Visible = True

            else
            {
                btnAltSR.Visible = false;
                // btnSightReduce.Visible = False
                // btnPlanSight.Visible = False
            }

            int ZDIdx = GetZDIndex(SEDataGrid.Rows[n].Cells[ZDCell].Value.ToString());
            if (ZDIdx != 99)
            {
                cboZD.SelectedIndex = ZDIdx;
            }
            else
            {
                cboZD.SelectedIndex = 0;
            }

            if (Information.IsNothing(SEDataGrid.Rows[n].Cells[ApprxBrgCell].Value))
            {
                cboApprxBrg.SelectedIndex = 8;
            }
            else
            {
                switch (SEDataGrid.Rows[n].Cells[ApprxBrgCell].Value.ToString() ?? "")
                {
                    case var case1 when case1 == (CommonGlobals.g_LatN ?? ""):
                        {
                            cboApprxBrg.SelectedIndex = 0;
                            break;
                        }

                    case "NE":
                        {
                            cboApprxBrg.SelectedIndex = 1;
                            break;
                        }

                    case var case2 when case2 == (CommonGlobals.g_LongE ?? ""):
                        {
                            cboApprxBrg.SelectedIndex = 2;
                            break;
                        }

                    case "SE":
                        {
                            cboApprxBrg.SelectedIndex = 3;
                            break;
                        }

                    case var case3 when case3 == (CommonGlobals.g_LatS ?? ""):
                        {
                            cboApprxBrg.SelectedIndex = 4;
                            break;
                        }

                    case "SW":
                        {
                            cboApprxBrg.SelectedIndex = 5;
                            break;
                        }

                    case var case4 when case4 == (CommonGlobals.g_LongW ?? ""):
                        {
                            cboApprxBrg.SelectedIndex = 6;
                            break;
                        }

                    case "NW":
                        {
                            cboApprxBrg.SelectedIndex = 7;
                            break;
                        }

                    case "None":
                        {
                            cboApprxBrg.SelectedIndex = 8;
                            break;
                        }

                    default:
                        {
                            cboApprxBrg.SelectedIndex = 8;
                            break;
                        }
                }
            }
            // btnAddNew.Visible = False
            btnClearFields.Visible = true;
            btnUpdateExisting.Visible = true;
            btnDeleteSight.Visible = true;
            btnPlanSight.Visible = true;
            if (CheckBoxAutoReduce.Checked == true)
            {
                btnSightReduce.Visible = false;
            }
            else
            {
                btnSightReduce.Visible = true;
            }

            return;
        }

        private int GetZDIndex(string ZDFldin)
        {
            int i = 0;
            var loopTo = Information.UBound(ZDArray);
            for (i = 0; i <= loopTo; i++)
            {
                if ((ZDArray[i].ZDField ?? "") == (ZDFldin ?? ""))
                {
                    return ZDArray[i].ZDIndex;
                    return default;
                }
            }

            return 99;
            return default;
        }

        private int GetZDHour(string ZDFldin)
        {
            int i = 0;
            var loopTo = Information.UBound(ZDArray);
            for (i = 0; i <= loopTo; i++)
            {
                if ((ZDArray[i].ZDField ?? "") == (ZDFldin ?? ""))
                {
                    return ZDArray[i].ZDHhours;
                    return default;
                }
            }

            return 99;
            return default;
        }

        private int GetZDMin(string ZDFldin)
        {
            int i = 0;
            var loopTo = Information.UBound(ZDArray);
            for (i = 0; i <= loopTo; i++)
            {
                if ((ZDArray[i].ZDField ?? "") == (ZDFldin ?? ""))
                {
                    return ZDArray[i].ZDMin;
                    return default;
                }
            }

            return 99;
            return default;
        }

        private void btnPrintDG_Click(object sender, EventArgs e)
        {
            // Dim PrintDialog As PrintDialog = New PrintDialog()
            PrintDialog1.Document = PrintDocument1;
            PrintDialog1.UseEXDialog = true;
            if (PrintDialog1.ShowDialog() == DialogResult.OK)
            {
                PrintDocument1.DocumentName = "Sight Log: " + SLFName;
                PrintDocument1.Print();
            }

            return;
        }

        private void btnSLReport_Click(object sender, EventArgs e)
        {
            ExecDataSaveasCSV();
            return;
        }

        private void PrintDocument1_BeginPrint(object sender, PrintEventArgs e)
        {
            // 'this removes the printed page margins
            PrintDocument1.OriginAtMargins = true;
            PrintDocument1.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
            PrintDocument1.DefaultPageSettings.Landscape = true;
            PrintDocument1.DocumentName = SLOpenFName.ToString();
            pages = new Dictionary<int, pageDetails>();
            // transpose for landscape printing
            int maxWidth = (int)PrintDocument1.DefaultPageSettings.PrintableArea.Height - 40;
            int maxHeight = (int)PrintDocument1.DefaultPageSettings.PrintableArea.Width - 40 + Label1.Height;
            int pageCounter = 0;
            pages.Add(pageCounter, new pageDetails());
            int columnCounter = 0;
            int columnSum = SEDataGrid.RowHeadersWidth;
            for (int c = 0, loopTo = SEDataGrid.Columns.Count - 1; c <= loopTo; c++)
            {
                if (columnSum + SEDataGrid.Columns[c].Width < maxWidth)
                {
                    columnSum += SEDataGrid.Columns[c].Width;
                    columnCounter += 1;
                }
                else
                {
                    pages[pageCounter] = new pageDetails() { columns = columnCounter, rows = 0, startCol = pages[pageCounter].startCol };
                    columnSum = SEDataGrid.RowHeadersWidth + SEDataGrid.Columns[c].Width;
                    columnCounter = 1;
                    pageCounter += 1;
                    pages.Add(pageCounter, new pageDetails() { startCol = c });
                }

                if (c == SEDataGrid.Columns.Count - 1)
                {
                    if (pages[pageCounter].columns == 0)
                    {
                        pages[pageCounter] = new pageDetails() { columns = columnCounter, rows = 0, startCol = pages[pageCounter].startCol };
                    }
                }
            }

            maxPagesWide = pages.Keys.Max() + 1;
            pageCounter = 0;
            int rowCounter = 0;
            int rowSum = SEDataGrid.ColumnHeadersHeight;
            for (int r = 0, loopTo1 = SEDataGrid.Rows.Count - 1; r <= loopTo1; r++)
            {
                if (rowSum + SEDataGrid.Rows[r].Height < maxHeight)
                {
                    rowSum += SEDataGrid.Rows[r].Height;
                    rowCounter += 1;
                }
                else
                {
                    pages[pageCounter] = new pageDetails() { columns = pages[pageCounter].columns, rows = rowCounter, startCol = pages[pageCounter].startCol, startRow = pages[pageCounter].startRow };
                    for (int x = 1, loopTo2 = maxPagesWide - 1; x <= loopTo2; x++)
                        pages[pageCounter + x] = new pageDetails() { columns = pages[pageCounter + x].columns, rows = rowCounter, startCol = pages[pageCounter + x].startCol, startRow = pages[pageCounter].startRow };
                    pageCounter += maxPagesWide;
                    for (int x = 0, loopTo3 = maxPagesWide - 1; x <= loopTo3; x++)
                        pages.Add(pageCounter + x, new pageDetails() { columns = pages[x].columns, rows = 0, startCol = pages[x].startCol, startRow = r });
                    rowSum = SEDataGrid.ColumnHeadersHeight + SEDataGrid.Rows[r].Height;
                    rowCounter = 1;
                }

                if (r == SEDataGrid.Rows.Count - 1)
                {
                    for (int x = 0, loopTo4 = maxPagesWide - 1; x <= loopTo4; x++)
                    {
                        if (pages[pageCounter + x].rows == 0)
                        {
                            pages[pageCounter + x] = new pageDetails() { columns = pages[pageCounter + x].columns, rows = rowCounter, startCol = pages[pageCounter + x].startCol, startRow = pages[pageCounter + x].startRow };
                        }
                    }
                }
            }

            maxPagesTall = pages.Count / maxPagesWide;
        }

        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            var rect = new Rectangle(20, 20, (int)PrintDocument1.DefaultPageSettings.PrintableArea.Width, Label1.Height);
            var sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString(Label1.Text, Label1.Font, Brushes.Black, rect, sf);
            sf.Alignment = StringAlignment.Near;
            int startX = 50;
            int startY = rect.Bottom;
            ;

            int startPage = 0; // As Integer = 0

            for (int p = startPage, loopTo = pages.Count - 1; p <= loopTo; p++)
            {
                var cell = new Rectangle(startX, startY, SEDataGrid.RowHeadersWidth, SEDataGrid.ColumnHeadersHeight);
                e.Graphics.FillRectangle(new SolidBrush(SystemColors.ControlLight), cell);
                e.Graphics.DrawRectangle(Pens.Black, cell);
                startY += SEDataGrid.ColumnHeadersHeight;
                for (int r = pages[p].startRow, loopTo1 = pages[p].startRow + pages[p].rows - 1; r <= loopTo1; r++)
                {
                    cell = new Rectangle(startX, startY, SEDataGrid.RowHeadersWidth, SEDataGrid.Rows[r].Height);
                    e.Graphics.FillRectangle(new SolidBrush(SystemColors.ControlLight), cell);
                    e.Graphics.DrawRectangle(Pens.Black, cell);
                    e.Graphics.DrawString(Conversions.ToString(SEDataGrid.Rows[r].HeaderCell.Value), SEDataGrid.Font, Brushes.Black, cell, sf);
                    startY += SEDataGrid.Rows[r].Height;
                }

                startX += cell.Width;
                startY = rect.Bottom;
                for (int c = pages[p].startCol, loopTo2 = pages[p].startCol + pages[p].columns - 1; c <= loopTo2; c++)
                {
                    cell = new Rectangle(startX, startY, SEDataGrid.Columns[c].Width, SEDataGrid.ColumnHeadersHeight);
                    e.Graphics.FillRectangle(new SolidBrush(SystemColors.ControlLight), cell);
                    e.Graphics.DrawRectangle(Pens.Black, cell);
                    e.Graphics.DrawString(Conversions.ToString(SEDataGrid.Columns[c].HeaderCell.Value), SEDataGrid.Font, Brushes.Black, cell, sf);
                    startX += SEDataGrid.Columns[c].Width;
                }

                startY = rect.Bottom + SEDataGrid.ColumnHeadersHeight;
                for (int r = pages[p].startRow, loopTo3 = pages[p].startRow + pages[p].rows - 1; r <= loopTo3; r++)
                {
                    startX = 50 + SEDataGrid.RowHeadersWidth;
                    for (int c = pages[p].startCol, loopTo4 = pages[p].startCol + pages[p].columns - 1; c <= loopTo4; c++)
                    {
                        cell = new Rectangle(startX, startY, SEDataGrid.Columns[c].Width, SEDataGrid.Rows[r].Height);
                        e.Graphics.DrawRectangle(Pens.Black, cell);
                        e.Graphics.DrawString(Conversions.ToString(SEDataGrid[c, r].Value), SEDataGrid.Font, Brushes.Black, cell, sf);
                        startX += SEDataGrid.Columns[c].Width;
                    }

                    startY += SEDataGrid.Rows[r].Height;
                }

                if (p != pages.Count - 1)
                {
                    startPage = p + 1;
                    e.HasMorePages = true;
                    return;
                }
                else
                {
                    startPage = 0;
                }
            }
        }

        private void cboHSIEFmt_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboHSIEFmt.SelectedIndex)
            {
                case 0:
                    {
                        txtHsSec.Visible = false;
                        lblHsSec.Visible = false;
                        txtIESec.Visible = false;
                        lblIEsec.Visible = false;
                        break;
                    }

                case 1:
                    {
                        txtHsSec.Visible = true;
                        lblHsSec.Visible = true;
                        txtIESec.Visible = true;
                        lblIEsec.Visible = true;
                        break;
                    }
            }

            Refresh();
        }

        private void cbHorizon_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbHorizon.SelectedIndex)
            {
                case 0:
                case 2:
                case 3:
                    {
                        lblDistance.Visible = false;
                        txtHorDist.Visible = false;
                        cbHorDistType.Visible = false;
                        txtHorDist.Clear();
                        break;
                    }

                case 1:
                    {
                        lblDistance.Visible = true;
                        txtHorDist.Visible = true;
                        cbHorDistType.Visible = true;
                        break;
                    }

                default:
                    {
                        lblDistance.Visible = false;
                        txtHorDist.Visible = false;
                        cbHorDistType.Visible = false;
                        txtHorDist.Clear();
                        break;
                    }
            }

            Refresh();
            return;
        }

        private static void ErrorMsgBox(string ErrMsg)
        {
            MessageBox.Show(ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            return;
        }

        private void CheckBoxShowAvg_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxShowAvg.Checked == true)
            {
                SEDataGrid.Columns[22].Visible = true;
                SEDataGrid.Columns[23].Visible = true;
                SEDataGrid.Columns[24].Visible = true;
                PrepareSightArray();
                BuildDGFromSightArray();
                SEDataGrid.ClearSelection();
                SEDataGrid.CurrentCell = null;
                SEDataGrid.Refresh();
                Refresh();
            }

            if (CheckBoxShowAvg.Checked == false)
            {
                SEDataGrid.Columns[22].Visible = false;
                SEDataGrid.Columns[23].Visible = false;
                SEDataGrid.Columns[24].Visible = false;
                PrepareSightArray();
                BuildDGFromSightArray();
                SEDataGrid.ClearSelection();
                SEDataGrid.CurrentCell = null;
                SEDataGrid.Refresh();
                Refresh();
            }

            return;
        }

        private void CheckBoxAutoReduce_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxAutoReduce.Checked == true & chkClearFields.Checked == true)
            {
                ErrorMsgBox("Can not set Auto Reduce On while Clear Fields is On");
                CheckBoxAutoReduce.Checked = false;
                return;
            }
            // now the auto reduce options overrides the sight reduction button and makes it invisible at all times. 
            // Otherwise clicking the sight reduction button with auto reduce option on cause duplicate and erroneous processing in sightlog and in SRF forms
            // if auto reduce is set off (checked = false) and sight reduction button is not visible then set sight reduction button to visible
            if (CheckBoxAutoReduce.Checked == false & btnSightReduce.Visible == false)
            {
                btnSightReduce.Visible = true;
                return;
            }
            // conversely if you are setting the auto reduce option on and the sight reduction button is visible then set the sight reduction button visible off
            if (CheckBoxAutoReduce.Checked == true & btnSightReduce.Visible == true)
            {
                btnSightReduce.Visible = false;
                return;
            }

            return;
        }

        private void cboBody_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBody.SelectedIndex > 1) // index of 0 is sun and 1 is moon so upper or lower limb is okay. Anything else limb must be set to center
            {
                cbLimb.SelectedIndex = 0; // default to lower limb for objects other than sun or moon
                cbLimb.Visible = false; // but hide limb for those objects other than sun and moon
                lblLimb.Visible = false;
            }
            else
            {
                cbLimb.Visible = true;
                lblLimb.Visible = true;
            }

            Refresh();
        }

        private void chkbxDST_CheckedChanged(object sender, EventArgs e)
        {
            // If chkbxDST.Checked = True Then
            // MasterDST = True
            // Else
            // MasterDST = False
            // End If

        }

        private void ChkClearFields_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxAutoReduce.Checked == true & chkClearFields.Checked == true)
            {
                ErrorMsgBox("Can not set Clear Fields On while Auto Reduce is On");
                chkClearFields.Checked = false;
            }

            return;
        }

        private void BtnAltSR_Click(object sender, EventArgs e)
        {
            PerformAltSR();
            return;
        }

        private void ChkDispGHADecHo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDispGHADecHo.Checked == true)
            {
                SEDataGrid.Columns[SLGHACell].Visible = true;
                SEDataGrid.Columns[SLDecCell].Visible = true;
                SEDataGrid.Columns[SLHoCell].Visible = true;
                PrepareSightArray();
                BuildDGFromSightArray();
                SEDataGrid.ClearSelection();
                SEDataGrid.CurrentCell = null;
                SEDataGrid.Refresh();
                Refresh();
            }
            else
            {
                SEDataGrid.Columns[SLGHACell].Visible = false;
                SEDataGrid.Columns[SLDecCell].Visible = false;
                SEDataGrid.Columns[SLHoCell].Visible = false;
                PrepareSightArray();
                BuildDGFromSightArray();
                SEDataGrid.ClearSelection();
                SEDataGrid.CurrentCell = null;
                SEDataGrid.Refresh();
                Refresh();
            }
        }

        private void ExitSRFandAltSR()
        {
            if (FormSRFLoaded == true)
            {
                My.MyProject.Forms.FormSRF.ExitBtn.PerformClick();
                FormSRFLoaded = false;
            }

            if (FormAltSRLoaded == true)
            {
                My.MyProject.Forms.FormAltSR.ExitBtn.PerformClick();
                FormAltSRLoaded = false;
            }

            if (FormNoonSightLoaded == true)
            {
                My.MyProject.Forms.FormNoonSight.ExitNoonSight.PerformClick();
                FormNoonSightLoaded = false;
            }

            if (FormSightPlanLoaded == true)
            {
                My.MyProject.Forms.FormSightPlan.ExitBtn.PerformClick();
                FormSightPlanLoaded = false;
            }
            if (CheckOpenWinForms("ZTInfo") == true)
            {
                My.MyProject.Forms.ZTInfo.ExitBtn.PerformClick();
            }

            return;
        }

        private void btnNoonSight_Click(object sender, EventArgs e)
        {
            PerformNoonSight();
            return;
        }

        private void PerformNoonSight()
        {
            if (CheckOpenWinForms("FormNoonSight") == true)
            {
                FormNoonSightLoaded = true;
                My.MyProject.Forms.FormNoonSight.ClearScrBtn.PerformClick();
                My.MyProject.Forms.FormNoonSight.SetDesktopLocation(5, 5); // 
                My.MyProject.Forms.FormNoonSight.BringToFront();
            }
            else
            {
                FormNoonSightLoaded = false;
                My.MyProject.Forms.FormNoonSight.Show();
                My.MyProject.Forms.FormNoonSight.SetDesktopLocation(5, 5); // 
                FormNoonSightLoaded = true;
            }

            My.MyProject.Forms.FormNoonSight.InvokedBySightLog = true;
            string DTHr = Strings.Format(SightDateTime.Value.Hour, "00");
            string DTMin = Strings.Format(SightDateTime.Value.Minute, "00");
            string DTSec = Strings.Format(SightDateTime.Value.Second, "00");
            string DTYear = Strings.Format(SightDateTime.Value.Year, "0000");
            My.MyProject.Forms.FormNoonSight.DTNoonSight.Value = SightDateTime.Value;
            // FormNoonSight.txtTime.Text = DTHr & DTMin & DTSec

            // by default FormSRF SRF sets ZD to auto calc from Long - only change to manual if ZD Minutes is nonzero then select Manual Calc option
            if (cboZD.SelectedIndex == ZDInitIdx)
            {
                My.MyProject.Forms.FormNoonSight.optZDAuto.Checked = true;
            }
            else
            {
                My.MyProject.Forms.FormNoonSight.optZDManual.Checked = true;
                int ZDHours = GetZDHour(cboZD.Items[cboZD.SelectedIndex].ToString());
                int ZDMin = GetZDMin(cboZD.Items[cboZD.SelectedIndex].ToString());
                My.MyProject.Forms.FormNoonSight.txtZDh.Text = ZDHours.ToString();
                switch (ZDMin)
                {
                    case 30:
                        {
                            My.MyProject.Forms.FormNoonSight.cboZDm.SelectedIndex = 1;
                            My.MyProject.Forms.FormNoonSight.optZDManual.Checked = true;
                            break;
                        }

                    case 45:
                        {
                            My.MyProject.Forms.FormNoonSight.cboZDm.SelectedIndex = 2;
                            My.MyProject.Forms.FormNoonSight.optZDManual.Checked = true;
                            break;
                        }

                    default:
                        {
                            My.MyProject.Forms.FormNoonSight.cboZDm.SelectedIndex = 0;
                            break;
                        }
                }
            }

            if (chkbxDST.Checked == true)
            {
                My.MyProject.Forms.FormNoonSight.chkDST.Checked = true;
            }
            else
            {
                My.MyProject.Forms.FormNoonSight.chkDST.Checked = false;
            }

            switch (cbLimb.SelectedIndex)
            {
                case 0:
                    {
                        My.MyProject.Forms.FormNoonSight.optLower.Checked = true;
                        break;
                    }

                case 1:
                    {
                        My.MyProject.Forms.FormNoonSight.optUpper.Checked = true;
                        break;
                    }

                case 2:
                    {
                        My.MyProject.Forms.FormNoonSight.optCenter.Checked = true;
                        break;
                    }

                default:
                    {
                        My.MyProject.Forms.FormNoonSight.optLower.Checked = true;
                        break;
                    }
            }

            My.MyProject.Forms.FormNoonSight.txtLoDeg.Text = txtLoDeg.Text;
            My.MyProject.Forms.FormNoonSight.txtLoMin.Text = txtLoMin.Text;
            switch (cboLo.SelectedIndex)
            {
                case 0:
                    {
                        My.MyProject.Forms.FormNoonSight.cboLo.SelectedIndex = 0;
                        break;
                    }

                case 1:
                    {
                        My.MyProject.Forms.FormNoonSight.cboLo.SelectedIndex = 1;
                        break;
                    }
            }

            My.MyProject.Forms.FormNoonSight.optDRL.Checked = true;
            My.MyProject.Forms.FormNoonSight.txtDRLDeg.Text = txtLDeg.Text;
            My.MyProject.Forms.FormNoonSight.txtDRLMin.Text = txtLMin.Text;
            switch (cboL.SelectedIndex)
            {
                case 0:
                    {
                        My.MyProject.Forms.FormNoonSight.cboDRL.SelectedIndex = 0;
                        break;
                    }

                case 1:
                    {
                        My.MyProject.Forms.FormNoonSight.cboDRL.SelectedIndex = 1;
                        break;
                    }
            }

            My.MyProject.Forms.FormNoonSight.txtHE.Text = txtHE.Text;
            My.MyProject.Forms.FormNoonSight.cboHE.SelectedIndex = cboHEUnit.SelectedIndex;
            My.MyProject.Forms.FormNoonSight.txtDsDist.Text = txtHorDist.Text;
            switch (cbHorDistType.SelectedIndex)
            {
                case 0:
                    {
                        My.MyProject.Forms.FormNoonSight.cboDsUnit.SelectedIndex = 0;
                        break;
                    }

                case 1:
                    {
                        My.MyProject.Forms.FormNoonSight.cboDsUnit.SelectedIndex = 1;
                        break;
                    }

                case 2:
                    {
                        My.MyProject.Forms.FormNoonSight.cboDsUnit.SelectedIndex = 2;
                        break;
                    }

                case 3:
                    {
                        My.MyProject.Forms.FormNoonSight.cboDsUnit.SelectedIndex = 3;
                        break;
                    }

                case 4:
                    {
                        My.MyProject.Forms.FormNoonSight.cboDsUnit.SelectedIndex = 4;
                        break;
                    }
            }

            if (cboHSIEFmt.SelectedIndex == 1)
            {
                My.MyProject.Forms.FormNoonSight.optHsDMS.Checked = true;
            }
            else
            {
                My.MyProject.Forms.FormNoonSight.optHsDMm.Checked = true;
            }

            My.MyProject.Forms.FormNoonSight.txtIEdeg.Text = txtIEDeg.Text;
            My.MyProject.Forms.FormNoonSight.txtIEmin.Text = txtIE.Text;
            if (cboHSIEFmt.SelectedIndex == 1)
            {
                My.MyProject.Forms.FormNoonSight.txtIESec.Text = txtIESec.Text;
            }

            switch (cbIEType.SelectedIndex)
            {
                case 0:
                    {
                        My.MyProject.Forms.FormNoonSight.cboIE.SelectedIndex = 0;
                        break;
                    }

                case 1:
                    {
                        My.MyProject.Forms.FormNoonSight.cboIE.SelectedIndex = 1;
                        break;
                    }
            }

            My.MyProject.Forms.FormNoonSight.txtHsDeg.Text = txtHSDeg.Text;
            My.MyProject.Forms.FormNoonSight.txtHsMin.Text = txtHSMin.Text;
            if (cboHSIEFmt.SelectedIndex == 1)
            {
                My.MyProject.Forms.FormNoonSight.txtHsSec.Text = txtHsSec.Text;
            }

            switch (cbHorizon.SelectedIndex)
            {
                case 0:
                    {
                        My.MyProject.Forms.FormNoonSight.optHorizonNatural.Checked = true;
                        break;
                    }

                case 1:
                    {
                        My.MyProject.Forms.FormNoonSight.optHorizonDipShort.Checked = true;
                        break;
                    }

                case 2:
                    {
                        My.MyProject.Forms.FormNoonSight.optHorizonArtificial.Checked = true;
                        break;
                    }

                case 3:
                    {
                        My.MyProject.Forms.FormNoonSight.optHorizonBubble.Checked = true;
                        break;
                    }

                default:
                    {
                        My.MyProject.Forms.FormNoonSight.optHorizonNatural.Checked = true;
                        break;
                    }
            }

            My.MyProject.Forms.FormNoonSight.txtUserInfo.Text = txtUserInfo.Text;
            My.MyProject.Forms.FormNoonSight.cmdLAN.PerformClick();
            My.MyProject.Forms.FormNoonSight.cmdNoonSight.PerformClick();
            My.MyProject.Forms.FormNoonSight.BringToFront();
            return;
        }

        public static bool CheckOpenWinForms(string FormNameIn)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name.Equals(FormNameIn, StringComparison.CurrentCulture))
                {
                    return true;
                    return default;
                }
            }

            return false;
            return default;
        }

        private void btnUseCLS_Click(object sender, EventArgs e)
        {
            // If CheckOpenWinForms("CLSForm") = True Then
            // CLSForm.ExitBtn.PerformClick()
            // End If
            PlotOut.PsnName = txtName.Text;
            PlotOut.SquadronName = txtSquadron.Text;
            PlotOut.PlotType = "Sight";
            PlotOut.PlotNumber = txtSightNum.Text;
            PlotOut.PlotDT = SightDateTime.Value;
            PlotOut.PlotBody = cboBody.Items[cboBody.SelectedIndex].ToString();
            PlotOut.PlotLat = Convert.ToDouble(txtLDeg.Text) + Convert.ToDouble(txtLMin.Text) / 60.0d;
            PlotOut.PlotLatDeg = txtLDeg.Text;
            PlotOut.PlotLatMin = txtLMin.Text;
            PlotOut.PlotLatSec = "0";
            PlotOut.PlotLatNS = cboL.Items[cboL.SelectedIndex].ToString();
            PlotOut.PlotLong = Convert.ToDouble(txtLoDeg.Text) + Convert.ToDouble(txtLoMin.Text) / 60.0d;
            PlotOut.PlotLongDeg = txtLoDeg.Text;
            PlotOut.PlotLongMin = txtLoMin.Text;
            PlotOut.PlotLongSec = "0";
            PlotOut.PlotLongEW = cboLo.Items[cboLo.SelectedIndex].ToString();
            PlotOut.PlotAz = PlotAzimuth;
            PlotOut.PlotIntercept = PlotIntercept;
            PlotOut.PlotSLEP = txtSRFEP.Text.ToString();
            PlotOut.PlotLLoBy = cboLLoBy.Text.ToString();
            PlotOut.PlotExtendedLines = false;
            My.MyProject.Forms.CLSForm.AddPlotEntry(PlotOut);
            My.MyProject.Forms.CLSForm.txtUserInfo.Text = txtUserInfo.Text;
            if (My.MyProject.Forms.CLSForm.PlotSight() == true)
            {
                My.MyProject.Forms.CLSForm.Show();
                My.MyProject.Forms.CLSForm.SetDesktopLocation(5, 5); // (Me.Location.X - 40, Me.Location.Y - 40)
                My.MyProject.Forms.CLSForm.BringToFront();
            }
            else
            {
                // If CheckOpenWinForms("CLSForm") = True Then
                // CLSForm.ExitBtn.PerformClick()
                // End If
            }

            return;
        }

        private void SightLog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CheckOpenWinForms("CLSForm") == true)
            {
                My.MyProject.Forms.CLSForm.ExitBtn.PerformClick();
            }
        }

        private void btnCustomPlot_Click(object sender, EventArgs e)
        {
            // If CheckOpenWinForms("CLSForm") = True Then
            // CLSForm.ExitBtn.PerformClick()
            // End If
            PlotOut.PsnName = txtName.Text;
            PlotOut.SquadronName = txtSquadron.Text;
            PlotOut.PlotType = "Sight";
            PlotOut.PlotNumber = txtSightNum.Text;
            PlotOut.PlotDT = SightDateTime.Value;
            PlotOut.PlotBody = cboBody.Items[cboBody.SelectedIndex].ToString();
            PlotOut.PlotLat = Convert.ToDouble(txtLDeg.Text) + Convert.ToDouble(txtLMin.Text) / 60.0d;
            PlotOut.PlotLatDeg = txtLDeg.Text;
            PlotOut.PlotLatMin = txtLMin.Text;
            PlotOut.PlotLatSec = "0";
            PlotOut.PlotLatNS = cboL.Items[cboL.SelectedIndex].ToString();
            PlotOut.PlotLong = Convert.ToDouble(txtLoDeg.Text) + Convert.ToDouble(txtLoMin.Text) / 60.0d;
            PlotOut.PlotLongDeg = txtLoDeg.Text;
            PlotOut.PlotLongMin = txtLoMin.Text;
            PlotOut.PlotLongSec = "0";
            PlotOut.PlotLongEW = cboLo.Items[cboLo.SelectedIndex].ToString();
            PlotOut.PlotAz = PlotAzimuth;
            PlotOut.PlotIntercept = PlotIntercept;
            PlotOut.PlotSLEP = txtSRFEP.Text.ToString();
            PlotOut.PlotLLoBy = cboLLoBy.Text.ToString();
            PlotOut.PlotExtendedLines = false;
            My.MyProject.Forms.CustomPlot.AddPlotEntry(PlotOut);
            My.MyProject.Forms.CustomPlot.txtUserInfo.Text = txtUserInfo.Text;
            if (My.MyProject.Forms.CustomPlot.PlotSight() == true)
            {
                My.MyProject.Forms.CustomPlot.Show();
                My.MyProject.Forms.CustomPlot.SetDesktopLocation(5, 5); // 
                My.MyProject.Forms.CustomPlot.BringToFront();
            }
            else
            {
                // If CheckOpenWinForms("CustomPlot") = True Then
                // CustomPlot.ExitBtn.PerformClick()
                // End If
            }

            return;
        }

        private void btnPlanSight_Click(object sender, EventArgs e)
        {
            if (CheckOpenWinForms("FormSightPlan") == true)
            {
                FormSightPlanLoaded = true;
                // FormSightPlan.ClearScrBtn.PerformClick()
                My.MyProject.Forms.FormSightPlan.SetDesktopLocation(5, 5); // 
                My.MyProject.Forms.FormSightPlan.BringToFront();
            }
            else
            {
                FormSightPlanLoaded = false;
                My.MyProject.Forms.FormSightPlan.Show();
                My.MyProject.Forms.FormSightPlan.SetDesktopLocation(5, 5); // 
                FormSightPlanLoaded = true;
            }

            // FormSightPlan.InvokedBySightLog = True
            string DTHr = Strings.Format(SightDateTime.Value.Hour, "00");
            string DTMin = Strings.Format(SightDateTime.Value.Minute, "00");
            string DTSec = Strings.Format(SightDateTime.Value.Second, "00");
            string DTYear = Strings.Format(SightDateTime.Value.Year, "0000");
            My.MyProject.Forms.FormSightPlan.DTPlan.Value = SightDateTime.Value;
            // FormSightPlan.txtTime.Text = DTHr & DTMin & DTSec

            // by default FormSRF SRF sets ZD to auto calc from Long - only change to manual if ZD Minutes is nonzero then select Manual Calc option
            if (cboZD.SelectedIndex == ZDInitIdx)
            {
                My.MyProject.Forms.FormSightPlan.optZDAuto.Checked = true;
            }
            else
            {
                My.MyProject.Forms.FormSightPlan.optZDManual.Checked = true;
                int ZDHours = GetZDHour(cboZD.Items[cboZD.SelectedIndex].ToString());
                int ZDMin = GetZDMin(cboZD.Items[cboZD.SelectedIndex].ToString());
                My.MyProject.Forms.FormSightPlan.txtZDh.Text = ZDHours.ToString();
                switch (ZDMin)
                {
                    case 30:
                        {
                            My.MyProject.Forms.FormSightPlan.cboZDm.SelectedIndex = 1;
                            My.MyProject.Forms.FormSightPlan.optZDManual.Checked = true;
                            break;
                        }

                    case 45:
                        {
                            My.MyProject.Forms.FormSightPlan.cboZDm.SelectedIndex = 2;
                            My.MyProject.Forms.FormSightPlan.optZDManual.Checked = true;
                            break;
                        }

                    default:
                        {
                            My.MyProject.Forms.FormSightPlan.cboZDm.SelectedIndex = 0;
                            break;
                        }
                }
            }

            if (chkbxDST.Checked == true)
            {
                My.MyProject.Forms.FormSightPlan.chkDST.Checked = true;
            }
            else
            {
                My.MyProject.Forms.FormSightPlan.chkDST.Checked = false;
            }

            My.MyProject.Forms.FormSightPlan.txtLoDeg.Text = txtLoDeg.Text;
            My.MyProject.Forms.FormSightPlan.txtLoMin.Text = txtLoMin.Text;
            switch (cboLo.SelectedIndex)
            {
                case 0:
                    {
                        My.MyProject.Forms.FormSightPlan.cboLo.SelectedIndex = 0;
                        break;
                    }

                case 1:
                    {
                        My.MyProject.Forms.FormSightPlan.cboLo.SelectedIndex = 1;
                        break;
                    }
            }

            My.MyProject.Forms.FormSightPlan.txtLDeg.Text = txtLDeg.Text;
            My.MyProject.Forms.FormSightPlan.txtLMin.Text = txtLMin.Text;
            switch (cboL.SelectedIndex)
            {
                case 0:
                    {
                        My.MyProject.Forms.FormSightPlan.cboL.SelectedIndex = 0;
                        break;
                    }

                case 1:
                    {
                        My.MyProject.Forms.FormSightPlan.cboL.SelectedIndex = 1;
                        break;
                    }
            }

            My.MyProject.Forms.FormSightPlan.txtUserInfo.Text = txtUserInfo.Text;
            My.MyProject.Forms.FormSightPlan.cmdTwilights.PerformClick();
            My.MyProject.Forms.FormSightPlan.BringToFront();
            return;
        }

        private void btnSaveLogAsTxt_Click(object sender, EventArgs e)
        {
            ExecDataSaveasTXT();
        }

        private void ExecDataSaveasTXT()
        {
            int i = 0;
            int iCnt = 0;
            var SE = new SightEntry();
            var builder = new System.Text.StringBuilder();
            var saveFileDialog1 = new SaveFileDialog();
            var loopTo = Information.UBound(SightLogArray);
            for (i = 0; i <= loopTo; i++)
            {
                SE = SightLogArray[i];
                if (SE.EntryStatus == "Active")
                {
                    iCnt += 1;
                }
            }

            if (iCnt == 0)
            {
                ErrorMsgBox("No Data to Print - Add Data or Exit");
                FileUpdated = false;
                Show();
                return;
            }

            string SLReportFname = SLOpenFName.Replace(".txt", "SLTextFile.txt");
            saveFileDialog1.InitialDirectory = "./DeckLog/";
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog1.Title = "Save Sight Log File as Formatted Text File";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FileName = SLReportFname;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(saveFileDialog1.FileName))
                {
                    return;
                }

                SLReportFname = saveFileDialog1.FileName;
            }
            else
            {
                return;
            }

            var textstr = new System.Text.StringBuilder();
            // Dim FileHdrStr As String = vbNullString
            // For idx As Integer = 0 To UBound(HdrStr)
            // If idx > 0 Then
            // textstr.Append("," & vbTab)
            // End If
            // textstr.Append(HdrStr(idx))
            // Next)
            // textstr.AppendLine()
            var loopTo1 = Information.UBound(SightLogArray);
            for (i = 0; i <= loopTo1; i++)
            {
                if (SightLogArray[i].EntryStatus == "Active")
                {
                    textstr.Append(FormatSightForPrint(SightLogArray[i]));
                    textstr.AppendLine();
                }
            }
            // For x As Integer = 0 To SEDataGrid.Rows.Count - 1
            // If IsNothing(SEDataGrid.Rows(x).Cells(0).Value) = False Then
            // For v As Integer = 0 To SEDataGrid.Columns.Count - 8
            // 'extracting cell value from 0 to 9 and add it on list
            // If v > 0 Then
            // textstr.Append("," & vbTab)
            // End If
            // Dim tempstr As String = SEDataGrid.Rows(x).Cells(v).Value.ToString()
            // tempstr = tempstr.Replace(",", "") ' remove any commas input into any field so csv file is not corrupted
            // textstr.Append(tempstr)
            // Next
            // End If
            // 'adding new line to text
            // textstr.AppendLine()
            // Next
            File.WriteAllText(SLReportFname, textstr.ToString(), System.Text.Encoding.GetEncoding("iso-8859-1"));
            return;
        }

        private static string FormatSightForPrint(SightEntry SE)
        {
            string SaveStr = Constants.vbNullString;
            string StrParm = Strings.Space(3);
            string SepLine = "__________________________________________________________________________________________";
            SaveStr = "Sight # = " + SE.SightNum + StrParm + "Body = " + SE.BodyName + StrParm + "Limb = " + SE.BodyLimb + StrParm + "Lat = " + SE.DRLat + StrParm + "Long = " + SE.DRLong + StrParm + "L/Lo By = " + SE.LLoBy + Constants.vbNewLine + "Date/Zone Time = " + SE.SightDateTime.ToString("MM/dd/yyyy HH:mm:ss") + StrParm + "DST = " + SE.DST + StrParm + "ZD = " + SE.ZD + StrParm + StrParm + "WE = " + SE.WE + " " + SE.WEType + Constants.vbNewLine + "HS = " + SE.HS + StrParm + "ApprxBrg=" + SE.ApprxBrg + StrParm + "IC = " + SE.IC + " " + SE.ICType + StrParm + "HE = " + SE.HE + StrParm + "Horizon = " + SE.HorType + StrParm; // SepLine & vbNewLine &
            if (SE.HorType == "Dip Short")
            {
                SaveStr += "Dip Short = " + SE.HorDist + " " + SE.HorDistType;
            }

            SaveStr += Constants.vbNewLine + "SR Intercept = " + SE.Intercept + StrParm + "SR Azimuth = " + SE.Zn + StrParm + "SR EP = " + SE.EP + Constants.vbNewLine + "SR GHA = " + SE.SRGHA + StrParm + "SR Dec = " + SE.SRDec + StrParm + "SR Ho = " + SE.SRHo + Constants.vbNewLine + "Name = " + SE.SLName + StrParm + "Squadron = " + SE.SLSquadron;
            if (!string.IsNullOrEmpty(SE.WTDiff))
            {
                SaveStr += Constants.vbNewLine + "WT Diff = " + SE.WTDiff + StrParm + "hs Diff = " + SE.HSDiff + StrParm + "hs/WT = " + SE.HSWTRate;
            }

            if (!string.IsNullOrEmpty(SE.Remarks))
            {
                SaveStr += Constants.vbNewLine + "Remarks=" + SE.Remarks;
            }

            if (!string.IsNullOrEmpty(SE.UserInfo))
            {
                SaveStr += Constants.vbNewLine + "UserInfo=" + SE.UserInfo;
            }

            SaveStr += Constants.vbNewLine;
            return SaveStr;
            return default;
        }

        // Private Sub chkUseZTInfo_CheckedChanged(sender As Object, e As EventArgs)
        // If chkUseZTInfo.Checked = True Then
        // ZTInfo.UpdateSLDST = True
        // Else
        // ZTInfo.UpdateSLDST = False
        // If CheckOpenWinForms("ZTInfo") = True Then
        // ZTInfo.ExitBtn.PerformClick()
        // End If
        // End If
        // End Sub
    }
}