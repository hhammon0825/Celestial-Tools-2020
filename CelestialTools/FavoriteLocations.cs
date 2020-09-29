using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    public partial class FavoriteLocations
    {
        public FavoriteLocations()
        {
            InitializeComponent();
            _btnExit.Name = "btnExit";
            _cbHorizon.Name = "cbHorizon";
            _chkbxDST.Name = "chkbxDST";
            _btnOpenLog.Name = "btnOpenLog";
            _btnSaveLog.Name = "btnSaveLog";
            _btnAddNew.Name = "btnAddNew";
            _btnUpdateExisting.Name = "btnUpdateExisting";
            _btnDeleteSight.Name = "btnDeleteSight";
            _btnNewLog.Name = "btnNewLog";
            _SEDataGrid.Name = "SEDataGrid";
            _cboZD.Name = "cboZD";
            _btnClearFields.Name = "btnClearFields";
            _btnShowSharedLoc.Name = "btnShowSharedLoc";
            _btnClearShared.Name = "btnClearShared";
            _btnUseLocation.Name = "btnUseLocation";
            _btnSLReport.Name = "btnSLReport";
            _btnPrintDG.Name = "btnPrintDG";
            _cboHSIEFmt.Name = "cboHSIEFmt";
        }

        public struct FavoriteLoc
        {
            public string EntryStatus;
            public string SLName;
            public string SightNum;
            public string DST;
            public string DRLat; // format NN*NN.N'N or S where * = CHR(176) degree
            public string DRLong; // format NNN*NN.N'E or W where * = CHR(176) degree 
            public string HE; // N.N feet
            public string HorType; // N - Natural, D - Dip, or A - Artificial 
            public string HorDist;
            public string HorDistType; // F - Feet, Y - Yards, M - Statute Mile, N - Nautical Mile
            public string ZD;
            public string Remarks;
            public string ApprxBrg;
            public string FromAZ;
            public string ToAZ;
            public string hsIEFormat;
        }

        public struct SharedLoc
        {
            public string EntryStatus;
            public string SLName;
            public string SightNum;
            public string DST;
            public string DRLat; // format NN*NN.N'N or S where * = CHR(176) degree
            public int DRLatDeg;
            public double DRLatMin;
            public string DRLatNS;
            public string DRLong; // format NNN*NN.N'E or W where * = CHR(176) degree 
            public int DRLongDeg;
            public double DRLongMin;
            public string DRLongEW;
            public double HE; // N.N feet
            public string HEType;
            public string HorType; // N - Natural, D - Dip, or A - Artificial 
            public double HorDist;
            public string HorDistType; // F - Feet, Y - Yards, M - Statute Mile, N - Nautical Mile
            public string ZD;
            public string ZDhr;
            public string ZDmin;
            public string Remarks;
            public string ApprxBrg;
            public int FromAZ;
            public int ToAZ;
            public string hsIEFormat;
            public int HorDistIndex;
            public int HETypeIndex;
            public bool ZDAutoSelect;
        }

        public struct ZDParms
        {
            public string ZDField;
            public int ZDIndex;
            public string ZDHhours;
            public string ZDMin;

            public ZDParms(string strIn, int intIn, int HourIn, int MinIn) : this()
            {
                ZDField = strIn;
                ZDIndex = intIn;
                ZDHhours = HourIn.ToString();
                ZDMin = MinIn.ToString();
            }
        }

        public SharedLoc SharedLocUse;
        public double SRFa = 0d;
        public double SRFZn = 0d;
        public bool SRFSightUpd = false;
        private FavoriteLoc[] FavoriteLocArray;
        private string SLFName = Constants.vbNullString;
        private string SLDir = "./FavoriteLocs/";
        // Private SLDefName As String = "FavoriteLoc" & Now.ToShortDateString.Replace("/", "").Replace("-", "") & Now.ToLongTimeString.Replace(":", "").Replace(" ", "") & ".txt"
        private string SLOpenFName = Constants.vbNullString;
        private int EntryIndex = 0;
        private bool FileUpdated = false;
        private FavoriteLoc CommonSE;
        private bool ReadError = false;
        private bool FileLoading = false;
        private ZDParms[] ZDArray = new[] { new ZDParms("+01", 0, 1, 0), new ZDParms("+02", 1, 2, 0), new ZDParms("+03", 2, 3, 0), new ZDParms("+03:30", 3, 3, 30), new ZDParms("+04", 4, 4, 0), new ZDParms("+04:30", 5, 4, 30), new ZDParms("+05", 6, 5, 0), new ZDParms("+05:30", 7, 5, 30), new ZDParms("+05:45", 8, 5, 45), new ZDParms("+06", 9, 6, 0), new ZDParms("+06:30", 10, 6, 30), new ZDParms("+07", 11, 7, 0), new ZDParms("+08", 12, 8, 0), new ZDParms("+08:45", 13, 8, 45), new ZDParms("+09", 14, 9, 0), new ZDParms("+09:30", 15, 9, 30), new ZDParms("+10", 16, 10, 0), new ZDParms("+10:30", 17, 10, 30), new ZDParms("+11", 18, 11, 0), new ZDParms("+12", 19, 12, 0), new ZDParms("+12:45", 20, 12, 45), new ZDParms("+13", 21, 13, 0), new ZDParms("+13:45", 22, 13, 45), new ZDParms("+14", 23, 14, 0), new ZDParms("+00", 24, 0, 0), new ZDParms("-01", 25, -1, 0), new ZDParms("-02", 26, -2, 0), new ZDParms("-02:30", 27, -2, 30), new ZDParms("-03", 28, -3, 0), new ZDParms("-03:30", 29, -3, 30), new ZDParms("-04", 30, -4, 0), new ZDParms("-05", 31, -5, 0), new ZDParms("-06", 32, -6, 0), new ZDParms("-07", 33, -7, 0), new ZDParms("-08", 34, -8, 0), new ZDParms("-09", 35, -9, 0), new ZDParms("-09:30", 36, -9, 30), new ZDParms("-10", 37, -10, 0), new ZDParms("-11", 38, -11, 0), new ZDParms("-12", 39, -12, 0), new ZDParms("Auto", 40, 0, 0) };
        public int ZDGMTIdx = 24;
        public int ZDInitIdx = 40;

        // these are the indexes for the data grid view cells and they must ALWAY be kept in sync with the datagridview order of cells.
        public int SightNumCell = 0;
        public int SLNameCell = 1;
        public int DRLatCell = 2;
        public int DRLongCell = 3;
        public int ZDCell = 4;
        public int DSTCell = 5;
        public int FromAZCell = 6;
        public int ToAZCell = 7;
        public int HorTypeCell = 8;
        public int HorDistCell = 9;
        public int HECell = 10;
        public int ApprxBrgCell = 11;
        public int hsIEFmtCell = 12;
        public bool EditError = false;
        public bool MasterDSTChecked = false;
        public bool AutoZDSelected = false;
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

        public void GetSharedLoc(ref SharedLoc SharedLocIn)
        {
            // Init the SharedLocIn variable sent into this prog as a ref and only format it with real info if there is shared data otherwise it is an empty structure
            // Program calling this subroutine must allocate local variable as ShareLoc and send it to this subroutine as a ref for local use in that prog 
            {
                var withBlock = SharedLocIn;
                withBlock.EntryStatus = "Empty";
                withBlock.SightNum = Constants.vbNullString;
                withBlock.SLName = Constants.vbNullString;
                withBlock.DRLat = Constants.vbNullString;
                withBlock.DRLatDeg = 0;
                withBlock.DRLatMin = 0d;
                withBlock.DRLong = Constants.vbNullString;
                withBlock.DRLongDeg = 0;
                withBlock.DRLongMin = 0d;
                withBlock.ZD = Constants.vbNullString;
                withBlock.DST = Constants.vbNullString;
                withBlock.FromAZ = Conversions.ToInteger(Constants.vbNullString);
                withBlock.ToAZ = Conversions.ToInteger(Constants.vbNullString);
                withBlock.HorType = Constants.vbNullString;
                withBlock.HorDist = 0d;
                withBlock.HorDistType = Constants.vbNullString;
                withBlock.HE = 0d;
                withBlock.HEType = Constants.vbNullString;
                withBlock.ApprxBrg = Constants.vbNullString;
                withBlock.hsIEFormat = Constants.vbNullString;
                withBlock.ZDAutoSelect = false;
            }

            if (SharedLocUse.EntryStatus == "Shared")
            {
                SharedLocIn = SharedLocUse;
            }

            return;
        }

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

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Before starting to exit, check to see if a location is shared. If a location is shared this form must offer the option to stay open so other programs can access shared loc data. 
            if (SharedLocUse.EntryStatus == "Shared")
            {
                if (MessageBox.Show("A Location is Shared - Confirm Exit with Yes - Cancel Exit with No and Clear Shared Location?", "A Location is Shared - Confirm Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) == DialogResult.No)
                {
                    return;
                }

                ExecInitSharedLoc();
            }
            // Now to exit properly, see if the location data has been updated but not saved to a file. Offer the option to save location data to a file then exit
            if (FileUpdated == true)
            {
                if (MessageBox.Show("Save Current File?  Yes / No ?", "Save File?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) == DialogResult.Yes)
                {
                    ExecFileSave();
                }
                else
                {
                    // Me.Close()
                }
            }
            else
            {
                // Me.Close()
            }

            Close();
            return;
        }

        public void QuickExit()
        {
            if (SharedLocUse.EntryStatus == "Shared")
            {
                ExecInitSharedLoc();
            }

            if (FileUpdated == true)
            {
                ExecFileSave();
            }

            Close();
            return;
        }

        private void FavoriteLocations_Load(object sender, EventArgs e)
        {
            SharedLocUse = new SharedLoc();
            SharedLocUse.EntryStatus = "Empty";
            LoadZDDropDown();
            ExecInitScreen();
            SEDataGrid.Rows.Clear();
            SEDataGrid.Refresh();
            cboHSIEFmt.SelectedIndex = 0;
            return;
        }

        private void ExecInitScreen()
        {
            string CurrDir = My.MyProject.Computer.FileSystem.CurrentDirectory;
            FileUpdated = false;
            SLDir = CurrDir + @"\FavoriteLocs";
            // check if Sight Log Dir for files exists - if not then create dir - this protects the very first time program is run
            if (My.MyProject.Computer.FileSystem.DirectoryExists(SLDir) == false)
            {
                My.MyProject.Computer.FileSystem.CreateDirectory(SLDir);
            }

            ExecInitSharedLoc();
            FavoriteLocArray = new FavoriteLoc[2];
            FavoriteLocArray[0].EntryStatus = "Empty";
            btnUpdateExisting.Visible = false;
            btnDeleteSight.Visible = false;
            btnShowSharedLoc.Visible = false;
            btnUseLocation.Visible = false;
            btnClearShared.Visible = false;
            btnSaveLog.Visible = false;
            btnPrintDG.Visible = false;
            btnSLReport.Visible = false;
            // btnNewLog.Visible = False
            ExecClearScreenFields();
            SEDataGrid.Rows.Clear();
            SEDataGrid.Refresh();
            return;
        }

        private void ExecClearScreenFields()
        {
            // when you clear the input fields turn off the update button. when a row is selected from the data then this button appears
            btnUpdateExisting.Visible = false;
            btnClearFields.Visible = false;
            btnDeleteSight.Visible = false;
            btnShowSharedLoc.Visible = false;
            btnUseLocation.Visible = false;
            btnClearShared.Visible = false;
            txtName.Clear();
            cboLo.SelectedIndex = 0; // W
            cboL.SelectedIndex = 0; // N
            cboZD.SelectedIndex = ZDInitIdx;
            chkbxDST.Checked = false;
            cbHorizon.SelectedIndex = 0;
            cbHorDistType.SelectedIndex = 0;
            cboHEUnit.SelectedIndex = 0;
            cboApprxBrg.SelectedIndex = 8; // None
            txtSightNum.Clear();
            txtLDeg.Clear();
            txtLMin.Clear();
            cboL.SelectedIndex = 0;
            txtLoDeg.Clear();
            txtLoMin.Clear();
            cboLo.SelectedIndex = 0;
            txtFromAZ.Text = "0";
            txtToAZ.Text = "360";
            txtHorDist.Clear();
            cbHorizon.SelectedIndex = 0;
            cbHorDistType.SelectedIndex = 0;
            txtHE.Clear();
            cboHEUnit.SelectedIndex = 0;
            cboApprxBrg.SelectedIndex = 0;
            cboHSIEFmt.SelectedIndex = 0;
            chkbxSharedLoc.Checked = false;
            int ArraySize = Information.UBound(FavoriteLocArray);
            int ActiveArray = 0;
            for (int i = 0, loopTo = ArraySize; i <= loopTo; i++)
            {
                if (FavoriteLocArray[i].EntryStatus == "Active")
                {
                    ActiveArray += 1;
                }
            }

            if (ActiveArray == 0)
            {
                btnUpdateExisting.Visible = false;
                btnClearFields.Visible = false;
                btnDeleteSight.Visible = false;
                btnShowSharedLoc.Visible = false;
                btnUseLocation.Visible = false;
                btnClearShared.Visible = false;
            }

            return;
        }

        private void btnOpenLog_Click(object sender, EventArgs e)
        {
            System.IO.StreamReader myStream = null;
            var openFileDialog1 = new OpenFileDialog();
            string rdline = Constants.vbNullString;
            openFileDialog1.InitialDirectory = SLDir;
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.Title = "Open Sight Log Text File";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            ExecInitSharedLoc();
            ExecClearScreenFields();
            FavoriteLocArray = new FavoriteLoc[2];
            FavoriteLocArray[0].EntryStatus = "Empty";
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
                    myStream = new System.IO.StreamReader(openFileDialog1.FileName);
                    if (myStream is object)
                    {
                        SLOpenFName = openFileDialog1.FileName;
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
                    // myStream.Dispose()
                    SEDataGrid.Refresh();
                    FileLoading = false;
                    btnPrintDG.Visible = true;
                    btnSLReport.Visible = true;
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
            ExecFileSave();
            FileUpdated = false;
            return;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ExecAddNew();
            ExecClearScreenFields();
            return;
        }

        private void btnUpdateExisting_Click(object sender, EventArgs e)
        {
            // updating a sight entry do not carry forward the old sight reduction - may no longer be valid so zero out Int and Zn fields
            ExecUpdateExisting();
            ExecClearScreenFields();
            return;
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            ExecClearScreenFields();
            return;
        }

        private void ExecUpdateExisting()
        {
            string SaveSightNum = txtSightNum.Text;
            FileUpdated = true;
            EditError = false;
            if (EditScreenFields() == true)
            {
                // Mark the current sight num entry in sight log array as 'Deleted' 
                int i = 0;
                bool DidDelete = false;
                var loopTo = Information.UBound(FavoriteLocArray);
                for (i = 0; i <= loopTo; i++)
                {
                    if ((FavoriteLocArray[i].SightNum ?? "") == (SaveSightNum ?? ""))
                    {
                        if (FavoriteLocArray[i].EntryStatus == "Active")
                        {
                            FavoriteLocArray[i].EntryStatus = "Deleted";
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
                    btnUpdateExisting.Visible = true;
                    btnDeleteSight.Visible = true;
                    btnShowSharedLoc.Visible = true;
                    btnUseLocation.Visible = true;
                    btnClearShared.Visible = true;
                }

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
            // to delete a location, you must first select it and bring its info to the top. 
            // first check if selected info for deletion is a shared set of info - if so, then set shared check box off and init shared loc block info
            if (chkbxSharedLoc.Checked == true)
            {
                DialogResult DYesNo;
                DYesNo = MessageBox.Show("This location is shared. Delete shared location? Yes / No", "Delete Shared Location?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                if (DYesNo == DialogResult.Yes)
                {
                    chkbxSharedLoc.Checked = false;
                    {
                        var withBlock = SharedLocUse;
                        withBlock.EntryStatus = "Empty";
                        withBlock.SightNum = Constants.vbNullString;
                        withBlock.SLName = Constants.vbNullString;
                        withBlock.DRLat = Constants.vbNullString;
                        withBlock.DRLatDeg = 0;
                        withBlock.DRLatMin = 0d;
                        withBlock.DRLong = Constants.vbNullString;
                        withBlock.DRLongDeg = 0;
                        withBlock.DRLongMin = 0d;
                        withBlock.ZD = Constants.vbNullString;
                        withBlock.DST = Constants.vbNullString;
                        withBlock.FromAZ = Conversions.ToInteger(Constants.vbNullString);
                        withBlock.ToAZ = Conversions.ToInteger(Constants.vbNullString);
                        withBlock.HorType = Constants.vbNullString;
                        withBlock.HorDist = 0d;
                        withBlock.HorDistType = Constants.vbNullString;
                        withBlock.HE = 0d;
                        withBlock.HEType = Constants.vbNullString;
                        withBlock.ApprxBrg = Constants.vbNullString;
                        withBlock.hsIEFormat = Constants.vbNullString;
                    }
                }
                else
                {
                    return;
                }
            }

            int i = 0;
            bool DidDelete = false;
            var loopTo = Information.UBound(FavoriteLocArray);
            for (i = 0; i <= loopTo; i++)
            {
                if ((FavoriteLocArray[i].SightNum ?? "") == (txtSightNum.Text ?? ""))
                {
                    if (FavoriteLocArray[i].EntryStatus == "Active")
                    {
                        FavoriteLocArray[i].EntryStatus = "Deleted";
                        DidDelete = true;
                    }
                }
            }

            if (DidDelete == false)
            {
                ErrorMsgBox("Did Not Mark Old Entry as Deleted - Debug This");
                return;
            }

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
            SEDataGrid.Refresh();
            FileLoading = false;
            return;
        }

        private void ExecFileSave()
        {
            int i = 0;
            int iCnt = 0;
            var SE = new FavoriteLoc();
            var loopTo = Information.UBound(FavoriteLocArray);
            for (i = 0; i <= loopTo; i++)
            {
                SE = FavoriteLocArray[i];
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

            BringToFront();
            var saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Title = "Save this Shared Location Data File";
            saveFileDialog1.InitialDirectory = SLDir;
            saveFileDialog1.FileName = SLOpenFName;
            saveFileDialog1.ShowDialog(this);
            if (!string.IsNullOrEmpty(saveFileDialog1.FileName))
            {
                SLOpenFName = saveFileDialog1.FileName;
                var objWriter = new System.IO.StreamWriter(saveFileDialog1.FileName, false);
                i = 0;
                var loopTo1 = Information.UBound(FavoriteLocArray);
                for (i = 0; i <= loopTo1; i++)
                {
                    SE = FavoriteLocArray[i];
                    if (SE.EntryStatus == "Active")
                    {
                        objWriter.WriteLine(FormatSightForSave(SE));
                    }
                }

                objWriter.Close();
                // objWriter.Dispose()
            }

            FileUpdated = false;
            return;
        }

        private string FormatSightForSave(FavoriteLoc SE)
        {
            string SaveStr = Constants.vbNullString;
            string StrParm = ";";
            SaveStr = "No=" + SE.SightNum + StrParm + "Name=" + SE.SLName + StrParm + "DRLat=" + SE.DRLat + StrParm + "DRLong=" + SE.DRLong + StrParm + "ZD=" + SE.ZD + StrParm + "DST=" + SE.DST + StrParm + "HorType=" + SE.HorType + StrParm + "HorDist=" + SE.HorDist + StrParm + "HorDistType=" + SE.HorDistType + StrParm + "HE=" + SE.HE + StrParm + "ApprxBrg=" + SE.ApprxBrg + StrParm + "FromAZ=" + SE.FromAZ + StrParm + "ToAZ=" + SE.ToAZ + StrParm + "hsIEFmt=" + SE.hsIEFormat;
            return SaveStr;
        }

        private void ExecFilePrint()
        {
            int i = 0;
            int iCnt = 0;
            var SE = new FavoriteLoc();
            var builder = new System.Text.StringBuilder();
            var loopTo = Information.UBound(FavoriteLocArray);
            for (i = 0; i <= loopTo; i++)
            {
                SE = FavoriteLocArray[i];
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

            string SLReportFname = SLOpenFName.Replace(".txt", "SLReport.txt");
            var saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Title = "Save an Sight Log Text File";
            saveFileDialog1.InitialDirectory = SLDir;
            saveFileDialog1.FileName = SLReportFname;
            saveFileDialog1.ShowDialog();
            if (!string.IsNullOrEmpty(saveFileDialog1.FileName))
            {
                SLOpenFName = saveFileDialog1.FileName;
                var objWriter = new System.IO.StreamWriter(saveFileDialog1.FileName, false);
                i = 0;
                var loopTo1 = Information.UBound(FavoriteLocArray);
                for (i = 0; i <= loopTo1; i++)
                {
                    SE = FavoriteLocArray[i];
                    if (SE.EntryStatus == "Active")
                    {
                        objWriter.WriteLine(FormatSightForPrint(SE));
                    }
                }

                objWriter.Close();
                // objWriter.Dispose()
            }
        }

        private string FormatSightForPrint(FavoriteLoc SE)
        {
            string SaveStr = Constants.vbNullString;
            string StrParm = Constants.vbTab;
            string SepLine = "__________________________________________________________________________________________";
            SaveStr = "Name = " + SE.SLName + StrParm + "No = " + SE.SightNum + StrParm + "DST = " + SE.DST + StrParm + "ZD = " + SE.ZD + StrParm + "DR Lat = " + SE.DRLat + StrParm + "DR Long = " + SE.DRLong + Constants.vbNewLine + "ApprxBrg=" + SE.ApprxBrg + StrParm + "HE = " + SE.HE + StrParm + "Horizon = " + SE.HorType + StrParm + "Dip Short = " + SE.HorDist + " " + SE.HorDistType + Constants.vbNewLine + "From AZ =" + SE.FromAZ + Constants.vbNewLine + "To AZ = " + SE.ToAZ + Constants.vbNewLine + "hsIEFmt =" + SE.hsIEFormat + Constants.vbNewLine + "Remarks = " + SE.Remarks + Constants.vbNewLine + SepLine.ToString() + Constants.vbNewLine;
            return SaveStr;
            return default;
        }

        private void FormatSightintoDG(FavoriteLoc SE)
        {
            try
            {
                // The order of these Sight Array fields must be same as the display order of the grid view field order
                SEDataGrid.Rows.Add(SE.SightNum, SE.SLName, SE.DRLat, SE.DRLong, SE.ZD, SE.DST, SE.FromAZ, SE.ToAZ, SE.HorType, SE.HorDist + " " + SE.HorDistType, SE.HE, SE.ApprxBrg, SE.hsIEFormat);
                return;
            }
            catch (Exception Ex)
            {
                ErrorMsgBox("Error Adding DataGrid Record: " + Ex.Message);
            }
        }

        private void BuildDGFromSightArray()
        {
            int i = 0;
            // SEDataGrid.SelectAll()
            // SEDataGrid.ClearSelection()
            SEDataGrid.Rows.Clear();
            SEDataGrid.Refresh();
            var loopTo = Information.UBound(FavoriteLocArray);
            for (i = 0; i <= loopTo; i++)
            {
                var SE = FavoriteLocArray[i];
                if (SE.EntryStatus == "Active")
                {
                    FormatSightintoDG(SE);
                }
            }

            SEDataGrid.ClearSelection();
            SEDataGrid.CurrentCell = null;
            SEDataGrid.Refresh();
            return;
        }

        private void ParseReadLine(string rdline)
        {
            EntryIndex = Information.UBound(FavoriteLocArray);
            if (ParseLineIntoSLArray(rdline) == true)
            {
                FavoriteLocArray[EntryIndex] = CommonSE;
                FavoriteLocArray[EntryIndex].EntryStatus = "Active";
                EntryIndex += 1;
                Array.Resize(ref FavoriteLocArray, EntryIndex + 1);
                FavoriteLocArray[EntryIndex].EntryStatus = "Empty";
                return;
            }

            return;
        }

        private bool ParseLineIntoSLArray(string rdline)
        {
            var SE = new FavoriteLoc();
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

                        case "Num":
                        case "No":
                            {
                                SE.SightNum = ParseArray[i].Substring(DataSt, DataEnd);
                                break;
                            }

                        case "DST":
                            {
                                SE.DST = ParseArray[i].Substring(DataSt, DataEnd);
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

                        case "ZD":
                            {
                                SE.ZD = ParseArray[i].Substring(DataSt, DataEnd);
                                break;
                            }

                        case "ApprxBrg":
                            {
                                SE.ApprxBrg = ParseArray[i].Substring(DataSt, DataEnd);
                                break;
                            }

                        case "FromAZ":
                            {
                                SE.FromAZ = ParseArray[i].Substring(DataSt, DataEnd);
                                break;
                            }

                        case "ToAZ":
                            {
                                SE.ToAZ = ParseArray[i].Substring(DataSt, DataEnd);
                                break;
                            }

                        case "hsIEFmt":
                            {
                                SE.hsIEFormat = ParseArray[i].Substring(DataSt, DataEnd);
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
            int i = 0;
            int LastActiveIdx = -1;
            var loopTo = Information.UBound(FavoriteLocArray);
            for (i = 0; i <= loopTo; i++)
            {
                if (FavoriteLocArray[i].EntryStatus == "Active")
                {
                    FavoriteLocArray[i].SightNum = i.ToString();
                    if (FirstActive == true)
                    {
                        FirstActive = false;
                    }
                    else if (i > 0 & LastActiveIdx != -1)
                    {
                        // Dim TempTS1 As TimeSpan = FavoriteLocArray(i).SightDateTime - FavoriteLocArray(LastActiveIdx).SightDateTime
                    }

                    LastActiveIdx = i;
                }

            EvalNextSE:
                ;
            }

            FavoriteLocArray = FavoriteLocArray.OrderBy(SE => SE.SightNum).ToArray();
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
            FileLoading = true;
            EditError = false;
            if (EditScreenFields() == true)
            {
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
                    btnUpdateExisting.Visible = true;
                    btnDeleteSight.Visible = true;
                    btnShowSharedLoc.Visible = true;
                    btnUseLocation.Visible = true;
                    btnClearShared.Visible = true;
                }

                FileUpdated = true;
                FileLoading = false;
            }
            else
            {
                EditError = true;
            }

            return;
        }

        private void BuildArrayFromscreen()
        {
            int Idx = Information.UBound(FavoriteLocArray);
            if (FavoriteLocArray[Idx].EntryStatus == "Active")
            {
                Idx += 1;
                Array.Resize(ref FavoriteLocArray, Idx + 1);
            }

            FavoriteLocArray[Idx].SightNum = Idx.ToString();
            FavoriteLocArray[Idx].EntryStatus = "Active";
            FavoriteLocArray[Idx].SLName = txtName.Text;
            if (chkbxDST.Checked == true)
            {
                FavoriteLocArray[Idx].DST = "X";
            }
            else
            {
                FavoriteLocArray[Idx].DST = "";
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

            FavoriteLocArray[Idx].DRLat = LatStr;
            string LongStr = txtLoDeg.Text.ToString() + '°' + string.Format(txtLoMin.Text.ToString(), "00.0") + "'";
            if (cboLo.SelectedIndex == 0)
            {
                LongStr = LongStr + CommonGlobals.g_LongW;
            }
            else
            {
                LongStr = LongStr + CommonGlobals.g_LongE;
            }

            FavoriteLocArray[Idx].DRLong = LongStr;
            FavoriteLocArray[Idx].HE = txtHE.Text.ToString();
            switch (cboHEUnit.SelectedIndex)
            {
                case 0:
                    {
                        FavoriteLocArray[Idx].HE += " ft";
                        break;
                    }

                case 1:
                    {
                        FavoriteLocArray[Idx].HE += " in";
                        break;
                    }

                case 2:
                    {
                        FavoriteLocArray[Idx].HE += " m ";
                        break;
                    }

                case 3:
                    {
                        FavoriteLocArray[Idx].HE += " cm";
                        break;
                    }
            }

            switch (cbHorizon.SelectedIndex)
            {
                case 0:
                    {
                        FavoriteLocArray[Idx].HorType = "Natural";
                        break;
                    }

                case 1:
                    {
                        FavoriteLocArray[Idx].HorType = "Dip Short";
                        break;
                    }

                case 2:
                    {
                        FavoriteLocArray[Idx].HorType = "Artificial";
                        break;
                    }

                case 3:
                    {
                        FavoriteLocArray[Idx].HorType = "Bubble";
                        break;
                    }

                default:
                    {
                        FavoriteLocArray[Idx].HorType = "Natural";
                        break;
                    }
            }

            FavoriteLocArray[Idx].HorDist = txtHorDist.Text.ToString();
            switch (cbHorDistType.SelectedIndex)
            {
                case 0:
                    {
                        FavoriteLocArray[Idx].HorDistType = "Feet";
                        break;
                    }

                case 1:
                    {
                        FavoriteLocArray[Idx].HorDistType = "Yards";
                        break;
                    }

                case 2:
                    {
                        FavoriteLocArray[Idx].HorDistType = "Meters";
                        break;
                    }

                case 3:
                    {
                        FavoriteLocArray[Idx].HorDistType = "Statute Mile";
                        break;
                    }

                case 4:
                    {
                        FavoriteLocArray[Idx].HorDistType = "Nautical Mile";
                        break;
                    }

                default:
                    {
                        FavoriteLocArray[Idx].HorDistType = "Feet";
                        break;
                    }
            }

            FavoriteLocArray[Idx].ZD = cboZD.Items[cboZD.SelectedIndex].ToString();
            FavoriteLocArray[Idx].ApprxBrg = cboApprxBrg.Items[cboApprxBrg.SelectedIndex].ToString();
            FavoriteLocArray[Idx].FromAZ = txtFromAZ.Text.ToString();
            FavoriteLocArray[Idx].ToAZ = txtToAZ.Text.ToString();
            switch (cboHSIEFmt.SelectedIndex)
            {
                case 0:
                    {
                        FavoriteLocArray[Idx].hsIEFormat = "DM ";
                        break;
                    }

                case 1:
                    {
                        FavoriteLocArray[Idx].hsIEFormat = "DMS";
                        break;
                    }

                default:
                    {
                        FavoriteLocArray[Idx].hsIEFormat = "UNK";
                        break;
                    }
            }
            // sort sight array by date/time field and assign sight num to each record
            PrepareSightArray();
            EntryIndex = Information.UBound(FavoriteLocArray);
            EntryIndex += 1;
            Array.Resize(ref FavoriteLocArray, EntryIndex + 1);
            FavoriteLocArray[EntryIndex].EntryStatus = "Empty";
            return;
        }

        private bool EditScreenFields()
        {
            if (!EditNameField())
            {
                return false;
            }

            if (!EditDSTField())
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

            if (!EditHEField())
            {
                return false;
            }

            if (!EditDSField())
            {
                return false;
            }

            if (!EditFromAZField())
            {
                return false;
            }

            if (!EditToAZField())
            {
                return false;
            }

            if (!EditApprxBrg())
            {
                return false;
            }

            return true;
        }

        private bool EditFromAZField()
        {
            string TestStr = txtFromAZ.Text.ToString();
            if (string.IsNullOrEmpty(TestStr) | string.IsNullOrEmpty(TestStr))
            {
                ErrorMsgBox("From AZ is Required");
                return false;
            }

            if (!Information.IsNumeric(TestStr))
            {
                ErrorMsgBox("From AZ must be numeric");
                return false;
            }

            int TestInt = Convert.ToInt32(TestStr);
            if (TestInt < 0 | TestInt > 360)
            {
                ErrorMsgBox("From AZ values must be between 0 and 360");
                return false;
            }

            return true;
            return default;
        }

        private bool EditToAZField()
        {
            string TestStr = txtToAZ.Text.ToString();
            if (string.IsNullOrEmpty(TestStr) | string.IsNullOrEmpty(TestStr))
            {
                ErrorMsgBox("To AZ is Required");
                return false;
            }

            if (!Information.IsNumeric(TestStr))
            {
                ErrorMsgBox("To AZ must be numeric");
                return false;
            }

            int TestInt = Convert.ToInt32(TestStr);
            if (TestInt < 0 | TestInt > 360)
            {
                ErrorMsgBox("To AZ values must be between 0 and 360");
                return false;
            }

            int TestFromAZ = Convert.ToInt32(txtFromAZ.Text.ToString());
            if (TestFromAZ >= TestInt)
            {
                ErrorMsgBox("To AZ  must be greater than From AZ");
                return false;
            }

            return true;
            return default;
        }

        private bool EditApprxBrg()
        {
            if (cboApprxBrg.Items[cboApprxBrg.SelectedIndex].ToString() == "None")
            {
                ErrorMsgBox("Approximate Bearing Selection Required");
                return false;
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

        private bool EditDSTField()
        {
            // if the DST box is unchecked and the Date/Time select is DayLightSavingsTime = true then set DST to checked

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
                ErrorMsgBox("Error in DRLat Degree Or Minutes Field.  Original error:  " + Ex.Message);
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
                // If cboZD.SelectedIndex = ZDInitIdx Then ' Is the ZD Type "Auto" - then calc the ZD based on longitude (ignore DST) and set the cboZD index to correct time zone value
                // Dim DRZDLoEW As String = vbNullString
                // If cboLo.SelectedIndex = 0 Then
                // DRZDLoEW = g_LongW
                // Else
                // DRZDLoEW = g_LongE
                // End If

                // Dim DRZDCalc As Integer = Convert.ToInt32((DRLongDeg + (DRLongMin / 60.0)) / 15)

                // Dim DRLongZDStr As String = String.Format(DRZDCalc.ToString, "00")
                // If DRLongZDStr.Length = 1 Then ' failsafe edit so ZD is always two positions
                // DRLongZDStr = "0" & DRLongZDStr
                // End If
                // If DRZDLoEW = g_LongW Then
                // DRLongZDStr = "+" & DRLongZDStr
                // Else
                // DRLongZDStr = "-" & DRLongZDStr
                // End If
                // cboZD.SelectedIndex = GetZDIndex(DRLongZDStr)
                // End If

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

        private bool EditHEField()
        {
            if (string.IsNullOrEmpty(txtHE.Text))
            {
                txtHE.Text = "00";
            }

            try
            {
                double HECalc = Convert.ToDouble(txtHE.Text.ToString());
                if (HECalc <= 0d | HECalc > 99.9d)
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
            var loopTo = Information.UBound(FavoriteLocArray);
            for (i = 0; i <= loopTo; i++)
            {
                if (FavoriteLocArray[i].EntryStatus == "Active")
                {
                    ActiveCnt += 1;
                }
            }

            return ActiveCnt;
        }

        private void SEDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (FileLoading == true)
                return;
            int n = SEDataGrid.CurrentRow.Index;
            // The order of these variable and the integer indexs contained in each MUST match the order of the fields in the data grid

            txtName.Text = Conversions.ToString(SEDataGrid.Rows[n].Cells[SLNameCell].Value);
            txtSightNum.Text = Conversions.ToString(SEDataGrid.Rows[n].Cells[SightNumCell].Value);
            // If there is a shared location and the sight number being selected is the shared location number then set check box to checked
            if (Conversions.ToBoolean(Operators.AndObject(SharedLocUse.EntryStatus == "Shared", Operators.ConditionalCompareObjectEqual(SharedLocUse.SightNum, SEDataGrid.Rows[n].Cells[SightNumCell].Value, false))))
            {
                chkbxSharedLoc.Checked = true;
            }
            else
            {
                chkbxSharedLoc.Checked = false;
            }

            if (SEDataGrid.Rows[n].Cells[DSTCell].Value.ToString() == "X")
            {
                chkbxDST.Checked = true;
            }
            else
            {
                chkbxDST.Checked = false;
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

            txtFromAZ.Text = SEDataGrid.Rows[n].Cells[FromAZCell].Value.ToString();
            txtToAZ.Text = SEDataGrid.Rows[n].Cells[ToAZCell].Value.ToString();
            switch (SEDataGrid.Rows[n].Cells[hsIEFmtCell].Value.ToString() ?? "")
            {
                case "DMS":
                    {
                        cboHSIEFmt.SelectedIndex = 1;
                        break;
                    }

                case "DM":
                    {
                        cboHSIEFmt.SelectedIndex = 0;
                        break;
                    }

                default:
                    {
                        cboHSIEFmt.SelectedIndex = 0;
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

            btnClearFields.Visible = true;
            btnUpdateExisting.Visible = true;
            btnDeleteSight.Visible = true;
            btnShowSharedLoc.Visible = true;
            btnUseLocation.Visible = true;
            btnClearShared.Visible = true;
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
                    return Conversions.ToInteger(ZDArray[i].ZDHhours);
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
                    return Conversions.ToInteger(ZDArray[i].ZDMin);
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
            ExecFilePrint();
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
            int maxHeight = (int)PrintDocument1.DefaultPageSettings.PrintableArea.Width - 40 + lblName.Height;
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
            var rect = new Rectangle(20, 20, (int)PrintDocument1.DefaultPageSettings.PrintableArea.Width, lblName.Height);
            var sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString(lblName.Text, lblName.Font, Brushes.Black, rect, sf);
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
                        break;
                    }

                case 1:
                    {
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
                        txtHorDist.Clear();
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

        private void ErrorMsgBox(string ErrMsg)
        {
            MessageBox.Show(ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            return;
        }

        private void CheckBoxAutoReduce_CheckedChanged(object sender, EventArgs e)
        {
            // handler for change to automatically reduce all error free new or changed sights
            return;
        }

        private void btnUseLocation_Click(object sender, EventArgs e)
        {
            chkbxSharedLoc.Checked = true;
            string LatStr = txtLDeg.Text.ToString() + '°' + string.Format(txtLMin.Text.ToString(), "00.0") + "'";
            if (cboL.SelectedIndex == 0)
            {
                LatStr = LatStr + CommonGlobals.g_LatN;
            }
            else
            {
                LatStr = LatStr + CommonGlobals.g_LatS;
            }

            string LongStr = txtLoDeg.Text.ToString() + '°' + string.Format(txtLoMin.Text.ToString(), "00.0") + "'";
            if (cboLo.SelectedIndex == 0)
            {
                LongStr = LongStr + CommonGlobals.g_LongW;
            }
            else
            {
                LongStr = LongStr + CommonGlobals.g_LongE;
            }

            {
                var withBlock = SharedLocUse;
                withBlock.EntryStatus = "Shared";
                withBlock.SightNum = txtSightNum.Text;
                withBlock.SLName = txtName.Text;
                withBlock.DRLat = LatStr;
                withBlock.DRLatDeg = Convert.ToInt32(txtLDeg.Text);
                withBlock.DRLatMin = Convert.ToDouble(txtLMin.Text);
                withBlock.DRLatNS = Strings.Right(LatStr, 1);
                withBlock.DRLong = LongStr;
                withBlock.DRLongDeg = Convert.ToInt32(txtLoDeg.Text);
                withBlock.DRLongMin = Convert.ToDouble(txtLoMin.Text);
                withBlock.DRLongEW = Strings.Right(LongStr, 1);
                withBlock.ZD = cboZD.Items[cboZD.SelectedIndex].ToString();
                withBlock.ZDhr = GetZDHour(withBlock.ZD).ToString();
                withBlock.ZDmin = GetZDMin(withBlock.ZD).ToString();
                if (MasterDSTChecked == true)
                {
                    // If chkbxDST.Checked = True Then
                    withBlock.DST = "X";
                }
                else
                {
                    withBlock.DST = Constants.vbNullString;
                }

                withBlock.FromAZ = Convert.ToInt32(txtFromAZ.Text.ToString());
                withBlock.ToAZ = Convert.ToInt32(txtToAZ.Text.ToString());
                withBlock.HorType = cbHorizon.Items[cbHorizon.SelectedIndex].ToString();
                withBlock.HorDist = Convert.ToDouble(txtHorDist.Text);
                withBlock.HorDistType = cbHorDistType.Items[cbHorDistType.SelectedIndex].ToString();
                withBlock.HE = Convert.ToDouble(txtHE.Text);
                withBlock.HEType = cboHEUnit.Items[cboHEUnit.SelectedIndex].ToString();
                withBlock.ApprxBrg = cboApprxBrg.Items[cboApprxBrg.SelectedIndex].ToString();
                withBlock.hsIEFormat = cboHSIEFmt.Items[cboHSIEFmt.SelectedIndex].ToString();
                withBlock.HorDistIndex = cbHorDistType.SelectedIndex;
                withBlock.HETypeIndex = cboHEUnit.SelectedIndex;
                withBlock.ZDAutoSelect = AutoZDSelected;
            }
            // update the common working area stored in the Menu / MainMenu 
            {
                var withBlock1 = SharedLocUse;
                // Now check if SRF / FormSRF is already open and being used
                if (Application.OpenForms.OfType<FormSRF>().Any())
                {
                    if (CommonYesNoMsgBox("The Sight Reduction Form is already open - Confirm you want to push shared location data to it") == true)
                    {
                        My.MyProject.Forms.FormSRF.txtLDeg.Text = withBlock1.DRLatDeg.ToString();
                        My.MyProject.Forms.FormSRF.txtLMin.Text = withBlock1.DRLatMin.ToString();
                        if ((withBlock1.DRLatNS ?? "") == (CommonGlobals.g_LatN ?? ""))
                        {
                            My.MyProject.Forms.FormSRF.cboL.SelectedIndex = 0;
                        }
                        else
                        {
                            My.MyProject.Forms.FormSRF.cboL.SelectedIndex = 1;
                        }

                        My.MyProject.Forms.FormSRF.txtLoDeg.Text = withBlock1.DRLongDeg.ToString();
                        My.MyProject.Forms.FormSRF.txtLoMin.Text = withBlock1.DRLongMin.ToString();
                        if ((withBlock1.DRLongEW ?? "") == (CommonGlobals.g_LongW ?? ""))
                        {
                            My.MyProject.Forms.FormSRF.cboLo.SelectedIndex = 0;
                        }
                        else
                        {
                            My.MyProject.Forms.FormSRF.cboLo.SelectedIndex = 1;
                        }

                        switch (withBlock1.HorType ?? "")
                        {
                            case "Dip Short":
                                {
                                    My.MyProject.Forms.FormSRF.optHorizonDipShort.Checked = true;
                                    My.MyProject.Forms.FormSRF.txtDsDist.Text = withBlock1.HorDist.ToString();
                                    My.MyProject.Forms.FormSRF.cboDsUnit.SelectedIndex = withBlock1.HorDistIndex;
                                    break;
                                }

                            case "Artificial":
                                {
                                    My.MyProject.Forms.FormSRF.optHorizonArtificial.Checked = true;
                                    break;
                                }

                            case "Natural":
                                {
                                    My.MyProject.Forms.FormSRF.optHorizonNatural.Checked = true;
                                    break;
                                }

                            case "Bubble":
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

                        if (withBlock1.DST == "X")
                        {
                            My.MyProject.Forms.FormSRF.chkDST.Checked = true;
                        }
                        else
                        {
                            My.MyProject.Forms.FormSRF.chkDST.Checked = false;
                        }

                        My.MyProject.Forms.FormSRF.txtHE.Text = withBlock1.HE.ToString();
                        My.MyProject.Forms.FormSRF.cboHE.SelectedIndex = withBlock1.HETypeIndex;
                        if (withBlock1.ZDAutoSelect == true)
                        {
                            My.MyProject.Forms.FormSRF.optZDAuto.Checked = true;
                        }
                        else
                        {
                            My.MyProject.Forms.FormSRF.optZDManual.Checked = true;
                            My.MyProject.Forms.FormSRF.txtZDh.Text = withBlock1.ZDhr.ToString();
                            if (withBlock1.ZDmin == "0")
                            {
                                My.MyProject.Forms.FormSRF.cboZDm.SelectedIndex = 0;
                                My.MyProject.Forms.FormSRF.cboZDm.Visible = false;
                            }
                            else
                            {
                                My.MyProject.Forms.FormSRF.cboZDm.Visible = true;
                                if (withBlock1.ZDmin == "30")
                                {
                                    My.MyProject.Forms.FormSRF.cboZDm.SelectedIndex = 1;
                                }
                                else if (withBlock1.ZDmin == "45")
                                {
                                    My.MyProject.Forms.FormSRF.cboZDm.SelectedIndex = 2;
                                }
                                else
                                {
                                    My.MyProject.Forms.FormSRF.cboZDm.SelectedIndex = 0;
                                }
                            }
                        }
                    }
                }
                // Now check if Plan1 / FormSightPlan is already open and in use
                if (Application.OpenForms.OfType<FormSightPlan>().Any())
                {
                    if (CommonYesNoMsgBox("The Sight Planning Form is already open - Confirm you want to push shared location data to it") == true)
                    {
                        My.MyProject.Forms.FormSightPlan.txtLDeg.Text = withBlock1.DRLatDeg.ToString();
                        My.MyProject.Forms.FormSightPlan.txtLMin.Text = withBlock1.DRLatMin.ToString();
                        if ((withBlock1.DRLatNS ?? "") == (CommonGlobals.g_LatN ?? ""))
                        {
                            My.MyProject.Forms.FormSightPlan.cboL.SelectedIndex = 0;
                        }
                        else
                        {
                            My.MyProject.Forms.FormSightPlan.cboL.SelectedIndex = 1;
                        }

                        My.MyProject.Forms.FormSightPlan.txtLoDeg.Text = withBlock1.DRLongDeg.ToString();
                        My.MyProject.Forms.FormSightPlan.txtLoMin.Text = withBlock1.DRLongMin.ToString();
                        if ((withBlock1.DRLongEW ?? "") == (CommonGlobals.g_LongW ?? ""))
                        {
                            My.MyProject.Forms.FormSightPlan.cboLo.SelectedIndex = 0;
                        }
                        else
                        {
                            My.MyProject.Forms.FormSightPlan.cboLo.SelectedIndex = 1;
                        }

                        if (withBlock1.FromAZ != 0)
                        {
                            My.MyProject.Forms.FormSightPlan.txtLowAz.Text = withBlock1.FromAZ.ToString();
                            My.MyProject.Forms.FormSightPlan.txtLowAz.Visible = true;
                        }

                        if (withBlock1.ToAZ != 0)
                        {
                            My.MyProject.Forms.FormSightPlan.txtHighAz.Text = withBlock1.ToAZ.ToString();
                            My.MyProject.Forms.FormSightPlan.txtHighAz.Visible = true;
                        }

                        if (withBlock1.ZDAutoSelect == true)
                        {
                            My.MyProject.Forms.FormSightPlan.optZDAuto.Checked = true;
                        }
                        else
                        {
                            My.MyProject.Forms.FormSightPlan.optZDManual.Checked = true;
                            My.MyProject.Forms.FormSightPlan.txtZDh.Text = withBlock1.ZDhr.ToString();
                            if (withBlock1.ZDmin == "0")
                            {
                                My.MyProject.Forms.FormSightPlan.cboZDm.SelectedIndex = 0;
                                My.MyProject.Forms.FormSightPlan.cboZDm.Visible = false;
                            }
                            else
                            {
                                My.MyProject.Forms.FormSightPlan.cboZDm.Visible = true;
                                if (withBlock1.ZDmin == "30")
                                {
                                    My.MyProject.Forms.FormSightPlan.cboZDm.SelectedIndex = 1;
                                }
                                else if (withBlock1.ZDmin == "45")
                                {
                                    My.MyProject.Forms.FormSightPlan.cboZDm.SelectedIndex = 2;
                                }
                                else
                                {
                                    My.MyProject.Forms.FormSightPlan.cboZDm.SelectedIndex = 0;
                                }
                            }
                        }
                    }
                }
                // Now check if NoonSight / FormNoonSight is already open and in use
                if (Application.OpenForms.OfType<FormNoonSight>().Any())
                {
                    if (CommonYesNoMsgBox("The Noonsight Form is already open - Confirm you want to push shared location data to it") == true)
                    {
                        My.MyProject.Forms.FormNoonSight.optDRL.Checked = true;
                        My.MyProject.Forms.FormNoonSight.txtDRLDeg.Text = withBlock1.DRLatDeg.ToString();
                        My.MyProject.Forms.FormNoonSight.txtDRLMin.Text = withBlock1.DRLatMin.ToString();
                        if ((withBlock1.DRLatNS ?? "") == (CommonGlobals.g_LatN ?? ""))
                        {
                            My.MyProject.Forms.FormNoonSight.cboDRL.SelectedIndex = 0;
                        }
                        else
                        {
                            My.MyProject.Forms.FormNoonSight.cboDRL.SelectedIndex = 1;
                        }

                        My.MyProject.Forms.FormNoonSight.txtLoDeg.Text = withBlock1.DRLongDeg.ToString();
                        My.MyProject.Forms.FormNoonSight.txtLoMin.Text = withBlock1.DRLongMin.ToString();
                        if ((withBlock1.DRLongEW ?? "") == (CommonGlobals.g_LongW ?? ""))
                        {
                            My.MyProject.Forms.FormNoonSight.cboLo.SelectedIndex = 0;
                        }
                        else
                        {
                            My.MyProject.Forms.FormNoonSight.cboLo.SelectedIndex = 1;
                        }

                        switch (withBlock1.HorType ?? "")
                        {
                            case "Dip Short":
                                {
                                    My.MyProject.Forms.FormNoonSight.optHorizonDipShort.Checked = true;
                                    My.MyProject.Forms.FormNoonSight.txtDsDist.Text = withBlock1.HorDist.ToString();
                                    My.MyProject.Forms.FormNoonSight.cboDsUnit.SelectedIndex = withBlock1.HorDistIndex;
                                    break;
                                }

                            case "Artificial":
                                {
                                    My.MyProject.Forms.FormNoonSight.optHorizonArtificial.Checked = true;
                                    break;
                                }

                            case "Natural":
                                {
                                    My.MyProject.Forms.FormNoonSight.optHorizonNatural.Checked = true;
                                    break;
                                }

                            case "Bubble":
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

                        My.MyProject.Forms.FormNoonSight.txtHE.Text = withBlock1.HE.ToString();
                        My.MyProject.Forms.FormNoonSight.cboHE.SelectedIndex = withBlock1.HETypeIndex;
                        if (withBlock1.ZDAutoSelect == true)
                        {
                            My.MyProject.Forms.FormNoonSight.optZDAuto.Checked = true;
                        }
                        else
                        {
                            My.MyProject.Forms.FormNoonSight.optZDManual.Checked = true;
                            My.MyProject.Forms.FormNoonSight.txtZDh.Text = withBlock1.ZDhr.ToString();
                            if (withBlock1.ZDmin == "0")
                            {
                                My.MyProject.Forms.FormNoonSight.cboZDm.SelectedIndex = 0;
                                My.MyProject.Forms.FormNoonSight.cboZDm.Visible = false;
                            }
                            else
                            {
                                My.MyProject.Forms.FormNoonSight.cboZDm.Visible = true;
                                if (withBlock1.ZDmin == "30")
                                {
                                    My.MyProject.Forms.FormNoonSight.cboZDm.SelectedIndex = 1;
                                }
                                else if (withBlock1.ZDmin == "45")
                                {
                                    My.MyProject.Forms.FormNoonSight.cboZDm.SelectedIndex = 2;
                                }
                                else
                                {
                                    My.MyProject.Forms.FormNoonSight.cboZDm.SelectedIndex = 0;
                                }
                            }
                        }
                    }
                }
                // Now check if SRMethods / FormAltSR is already open and in use
                if (Application.OpenForms.OfType<FormAltSR>().Any())
                {
                    if (CommonYesNoMsgBox("The SR Alt Methods Form is already open - Confirm you want to push shared location data to it") == true)
                    {
                        My.MyProject.Forms.FormAltSR.txtLDeg.Text = withBlock1.DRLatDeg.ToString();
                        My.MyProject.Forms.FormAltSR.txtLMin.Text = withBlock1.DRLatDeg.ToString();
                        if ((withBlock1.DRLatNS ?? "") == (CommonGlobals.g_LatN ?? ""))
                        {
                            My.MyProject.Forms.FormAltSR.cboL.SelectedIndex = 0;
                        }
                        else
                        {
                            My.MyProject.Forms.FormAltSR.cboL.SelectedIndex = 1;
                        }

                        My.MyProject.Forms.FormAltSR.txtLoDeg.Text = withBlock1.DRLongDeg.ToString();
                        My.MyProject.Forms.FormAltSR.txtLoMin.Text = withBlock1.DRLongMin.ToString();
                        if ((withBlock1.DRLongEW ?? "") == (CommonGlobals.g_LongW ?? ""))
                        {
                            My.MyProject.Forms.FormAltSR.cboLo.SelectedIndex = 0;
                        }
                        else
                        {
                            My.MyProject.Forms.FormAltSR.cboLo.SelectedIndex = 1;
                        }
                    }
                }
            }

            return;
        }

        private void btnClearShared_Click(object sender, EventArgs e)
        {
            ExecInitSharedLoc();
            return;
        }

        private void ExecInitSharedLoc()
        {
            chkbxSharedLoc.Checked = false;
            {
                var withBlock = SharedLocUse;
                withBlock.EntryStatus = "Empty";
                withBlock.SightNum = Constants.vbNullString;
                withBlock.SLName = Constants.vbNullString;
                withBlock.DRLat = Constants.vbNullString;
                withBlock.DRLatDeg = 0;
                withBlock.DRLatMin = 0d;
                withBlock.DRLong = Constants.vbNullString;
                withBlock.DRLongDeg = 0;
                withBlock.DRLongMin = 0d;
                withBlock.ZD = Constants.vbNullString;
                withBlock.ZDhr = Constants.vbNullString;
                withBlock.ZDmin = Constants.vbNullString;
                withBlock.DST = Constants.vbNullString;
                withBlock.FromAZ = Conversions.ToInteger(Constants.vbNullString);
                withBlock.ToAZ = Conversions.ToInteger(Constants.vbNullString);
                withBlock.HorType = Constants.vbNullString;
                withBlock.HorDist = 0d;
                withBlock.HorDistType = Constants.vbNullString;
                withBlock.HE = 0d;
                withBlock.HEType = Constants.vbNullString;
                withBlock.ApprxBrg = Constants.vbNullString;
                withBlock.hsIEFormat = Constants.vbNullString;
            }

            return;
        }

        private void btnShowSharedLoc_Click(object sender, EventArgs e)
        {
            if (SharedLocUse.EntryStatus == "Empty")
            {
                ErrorMsgBox("There is no Shared Location to display");
                return;
            }

            MessageBox.Show("Shared Location: Number = " + SharedLocUse.SightNum.ToString() + " Name = " + SharedLocUse.SLName.ToString(), "Shared Location Num and Name", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            return;
        }

        public bool CommonYesNoMsgBox(string MsgString)
        {
            if (MessageBox.Show(MsgString, "Confirm Pushing Shared Location Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) == DialogResult.Yes)
            {
                return true;
                return default;
            }

            return false;
            return default;
        }

        private void chkbxDST_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxDST.Checked == true)
            {
                MasterDSTChecked = true;
            }
            else
            {
                MasterDSTChecked = false;
            }
        }

        private void cboZD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboZD.SelectedIndex == ZDInitIdx) // this is auto ZD calc
            {
                AutoZDSelected = true;
            }
            else
            {
                AutoZDSelected = false;
            }
        }
    }
}