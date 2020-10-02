using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    public partial class DeckLogUpdate
    {
        public DeckLogUpdate()
        {
            InitializeComponent();
            _DataGridView1.Name = "DataGridView1";
            _btnExit.Name = "btnExit";
            _btnExitNoSave.Name = "btnExitNoSave";
            _btnOpenCSV.Name = "btnOpenCSV";
            _btnSaveFile.Name = "btnSaveFile";
            _btnInfoForm.Name = "btnInfoForm";
            _cboAdvType.Name = "cboAdvType";
            _DTDateZoneTime.Name = "DTDateZoneTime";
            _txtCompass.Name = "txtCompass";
            _txtCTrue.Name = "txtCTrue";
            _chkPlanGCR.Name = "chkPlanGCR";
            _cboDisplayRows.Name = "cboDisplayRows";
            _btnUseZTInfoForm.Name = "btnUseZTInfoForm";
            _btnUseTVMDC.Name = "btnUseTVMDC";
            _linkLblNOAAVar.Name = "linkLblNOAAVar";
            _chkHideFirst4Col.Name = "chkHideFirst4Col";
            _cboLocType.Name = "cboLocType";
            _chkDev.Name = "chkDev";
            _btnClearFields.Name = "btnClearFields";
            _btnAddNew.Name = "btnAddNew";
            _btnUpdateExisting.Name = "btnUpdateExisting";
            _btnDeleteSight.Name = "btnDeleteSight";
            _btnStartFresh.Name = "btnStartFresh";
            _btnEvalDG.Name = "btnEvalDG";
            _btnExportGPX.Name = "btnExportGPX";
        }

        private string FName = "./DeckLog/";
        private bool ReadError = false;
        private bool FileLoading = false;
        private bool InitialLoad = false;
        private bool SelectedRow = false;
        // Private FileRead As Boolean = False
        private bool SortingDG = false;
        private bool IsUpdated = false;
        private string SLOpenFName = "";
        private readonly string tablename = "Table1";
        private DataSet DataSet1;
        private DateTime DestEstArrival;
        private bool DRAdvanceMode = false;
        // Private DRAdvanceDGSave As Integer = 0
        private bool DTChanged = false;
        public bool DestDTUpdatedbyZTInfo = false;
        public DateTime DestDTfromZTInfo;
        private bool AutoGCRMode = false;
        private readonly int GCRThreshhold = 500; // Per documentation at 500 nm in distance it makes sense to plot a Great Circle Route instead of a Rhumb Line
        private string DTFormatString = "yyyy/MM/dd HH:mm:ss";
        private DateTime MaxDate = new DateTime(2999, 12, 31, 23, 59, 59);
        //private DateTime DefaultDT = new DateTime(100L);
        private readonly string[] HdrStr = new[] { "Vessel", "Navigator", "From", "To", "Log Type", "Log DateTime", "Course Psc", "Var", "Dev", "Course True", "Speed", "Position L/Lo", "Weather Notes", "Log Entry Notes", "ElapsedTime", "Distance", "Calc Dest", "Calc True", "Calc Speed", "Set", "Drift", "Eval Basis", "ZD", "KnotLog", "Wind", "WindDir", "Seas", "Use4Eval" };
        private readonly string[] NullStr = new[] { Constants.vbNullString, Constants.vbNullString, Constants.vbNullString, Constants.vbNullString, Constants.vbNullString, Constants.vbNullString, Constants.vbNullString, Constants.vbNullString, Constants.vbNullString, Constants.vbNullString, Constants.vbNullString, Constants.vbNullString, Constants.vbNullString, Constants.vbNullString, Constants.vbNullString, Constants.vbNullString, Constants.vbNullString, Constants.vbNullString, Constants.vbNullString, Constants.vbNullString, Constants.vbNullString, Constants.vbNullString, Constants.vbNullString, Constants.vbNullString };

        private struct GCRRec
        {
            public string LatStr;
            public string LongStr;
            public string CTrue;
            public string GCRDist;
        }

        private GCRRec[] GCRArray;
        private int UpdtRow = default;

        private struct DLUpdate
        {
            public string Vessel;
            public string Navigator;
            public string LocFrom;
            public string LocTo;
            public string DateZoneTime;
            public string Compass;
            public int CompassI;
            public string Var;
            public string VarEW;
            public double VarI;
            public string Dev;
            public string DevEW;
            public double DevI;
            public string CTrue;
            public int CTrueI;
            public string Speed;
            public double SpeedI;
            public string PositionLatLong;
            public int LDegI;
            public double LMinI;
            public string LNS;
            public double LatDouble;
            public int LoDegI;
            public double LoMinI;
            public string LoEW;
            public double LongDouble;
            public string LogType;
            public string Weather;
            public string Remarks;
            public double Distance;
            public TimeSpan Elapsed;
            public int CMG;
            public double SMG;
            public int SetDir;
            public double Drift;
            public int DBRowNum;
            public string DestLatLongStr;
            public int DestLDegI;
            public double DestLMinI;
            public string DestLNS;
            public double DestLatDouble;
            public int DestLoDegI;
            public double DestLoMinI;
            public string DestLoEW;
            public double DestLongDouble;
            public int DestTrueI;
            public double DestDistance;
            public double DestSpeed;
            public string DestEstArrival;
            public string DestEstElapsed;
            public string ZD;
            public string DestZD;
            public string KnotLog;
            public string Wind;
            public string WindDir;
            public string Seas;
            public string UseForEval;
        }

        private DLUpdate UpdtRtn;
        public bool DevformLoaded = false;
        private int AdvMin = 0;
        private double AdvNm = 0.0d;
        private DateTime DTAdvDTSave;
        private bool AddNewMode = false;
        // the next 4 log types require Date/Time, L/Lo, and TVMDC entries
        private readonly string g_LogTypeDR = "DR Track";
        private readonly string g_LogTypeOldDR = "DR";
        private readonly string g_LogTypePlan = "Plan/Route";
        private readonly string g_LogTypeOldPlan = "Plan";
        private readonly string g_LogTypeDRAdv = "DRAdvance";
        private readonly string g_LogTypeGPS = "GPS Track";
        private readonly string g_LogTypeOldGPS = "GPS";
        // the next 2 log types require Date/Time, L/Lo but NO TVMDC - they are fixed points in time not moving point. GPS Track is a moving 
        private readonly string g_LogTypeFix = "Fix";
        private readonly string g_LogTypeWayPoint = "Waypoint";

        // The order of these variable and the integer indexs contained in each MUST match the order of the fields in the data grid
        // Cell 0 = Vessel name  
        // Cell 1 = Navigator name  
        // Cell 2 = From location name   
        // Cell 3 = To location name 
        // Cell 4 = L/Lo loc type 
        // Cell 5 = Zone Date & time String MM/dd/yyyy HH:mm:ss 
        // Cell 6 = Compass course string 
        // Cell 7 = Variation string 
        // Cell 8 = Deviation string
        // Cell 9 = Computed True Course string  
        // Cell 10 = DR Speed string  
        // Cell 11 = Latitude / Longitude string 
        // Cell 12 = Weather string   
        // Cell 13 = Remarks string
        // Cell 14 = Elapsed Time from Lat/Long to Dest Lat/Long
        // Cell 15 = Distance in nm from Lat/Long to Dest Lat/Long
        // Cell 16 = Calculated Destination Lat/Long
        // Cell 17 = Calculated True Course to destination
        // Cell 18 = Calculated Speed to make destination
        // Cell 19 = Calculated Set between two GPS/Fix locations
        // Cell 20 = Calculated Drift between two GPS/Fix locations
        // Cell 21 = Eval Based On string (filled in in EvaluatedDG subroutine)
        private readonly int VesselCell = 0;
        private readonly int NavigatorCell = 1;
        private readonly int FromCell = 2;
        private readonly int ToCell = 3;
        private readonly int LogTypeCell = 4;
        private readonly int DTCell = 5;
        private readonly int CompassCell = 6;
        private readonly int VarCell = 7;
        private readonly int DevCell = 8;
        private readonly int TrueCell = 9;
        private readonly int DRSpeedCell = 10;
        private readonly int DestLogTypeCell = 11;
        private readonly int WeatherCell = 12;
        private readonly int NotesCell = 13;
        private readonly int ElapsedCell = 14;
        private readonly int DistCell = 15;
        private readonly int CalcDestLogTypeCell = 16;
        private readonly int CalcDestTrueCell = 17;
        private readonly int CalcDestSpeedCell = 18;
        private readonly int CalcSetCell = 19;
        private readonly int CalcDriftCell = 20;
        private readonly int EvalCell = 21;
        private readonly int ZDCell = 22;
        private readonly int KnotLogCell = 23;
        private readonly int WindCell = 24;
        private readonly int WindDirCell = 25;
        private readonly int SeasCell = 26;
        private readonly int UseForEvalCell = 27;
        private string CurrDir;
        private bool CompassInput = false;
        private bool TrueInput = false;

        private void FormDeckLogUpdate_Load(object sender, EventArgs e)
        {
            string DefFName = "DeckLog" + DateAndTime.Now.ToString("yyyyMMddHHmmss", CultureInfo.CurrentCulture) + ".csv";
            CurrDir = Microsoft.VisualBasic.FileIO.FileSystem.CurrentDirectory + @"\DeckLog";
            InitialLoad = true;
            FName += CurrDir + "/" + DefFName;
            CompassInput = false;
            TrueInput = false;
            DataSet1 = new DataSet();
            DataSet1.Tables.Add(tablename);
            DataSet1.DataSetName = tablename;
            DataGridView1.DataSource = DataSet1;
            for (int i = 0, loopTo = Information.UBound(HdrStr); i <= loopTo; i++)
            {
                DataSet1.Tables[tablename].Columns.Add(HdrStr[i]);
                DataSet1.Tables[tablename].Columns[i].AllowDBNull = false;
                DataSet1.Tables[tablename].Columns[i].DefaultValue = "";
            }

            DataSet1.Tables[tablename].Rows.Add(NullStr);
            DataGridView1.DataSource = DataSet1.Tables[0].DefaultView;
            for (int i = 0, loopTo1 = DataGridView1.Columns.Count - 1; i <= loopTo1; i++)
            {
                DataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DataGridView1.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DataGridView1.Columns[i].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                DataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DataGridView1.Columns[12].MinimumWidth = 250;
            DataGridView1.Columns[13].MinimumWidth = 250;
            txtVar.Clear();
            txtDev.Clear();
            SortDataGridonDate();
            DataGridView1.Refresh();
            ResetAllScreenFields();
            btnDeleteSight.Visible = false;
            btnUpdateExisting.Visible = false;
            cboAdvHrs.Value = 0m;
            cboAdvMin.Value = 0m;
            cboAdvNm.Value = 0m;
            cboAdvType.SelectedIndex = 0;
            AddNewMode = false;
            DRAdvanceMode = false;
            if (My.MyProject.Computer.Network.IsAvailable)
            {
                linkLblNOAAVar.Visible = true;
                linkLblNOAAVar.Enabled = true;
            }
            else
            {
                linkLblNOAAVar.Visible = false;
                linkLblNOAAVar.Enabled = false;
            }

            cboDisplayRows.SelectedIndex = 0;
            chkHideFirst4Col.Checked = true;
            AutoGCRMode = false;
            InitialLoad = false;
            if (System.Windows.Forms.Application.OpenForms.OfType<FormSailings>().Any())
            {
                if (My.MyProject.Forms.FormSailings.GCRAvailable == true)
                {
                    chkImportGCR.Visible = true;
                    chkImportGCR.Checked = true;
                }
                else
                {
                    chkImportGCR.Visible = false;
                    chkImportGCR.Checked = false;
                }
            }
            else
            {
                chkImportGCR.Visible = false;
                chkImportGCR.Checked = false;
            }

            Show();
            Refresh();
            return;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            SaveDataGrid();
            IsUpdated = false;
            DataSet1.Dispose();
            CleanUp();
            Close();
        }

        public void QuickExit()
        {
            var openFileDialog1 = new OpenFileDialog();
            if (IsUpdated == true)
            {
                var MsgBack = Interaction.MsgBox("Data has been updated - Save to File - Yes or No", MsgBoxStyle.YesNo, "Save Updated Data");
                if (MsgBack == MsgBoxResult.Yes)
                {
                    SaveDataGrid();
                }

                IsUpdated = false;
            }

            openFileDialog1.Dispose();
            DataSet1.Dispose();
            return;
        }

        private void SaveDataGrid()
        {

            // Dim dirstr As String = FileIO.FileSystem.CurrentDirectory
            var saveFileDialog1 = new SaveFileDialog()
            {
                InitialDirectory = CurrDir,
                Filter = "txt files (*.txt)|*.txt|csv files (*.csv)|*.csv",
                Title = "Save Deck Log File",
                FilterIndex = 2,
                RestoreDirectory = true
            };
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(saveFileDialog1.FileName))
                {
                    saveFileDialog1.Dispose();
                    return;
                }

                FName = saveFileDialog1.FileName;
            }

            var textstr = new System.Text.StringBuilder();
            string FileHdrStr = Constants.vbNullString;
            for (int i = 0, loopTo = Information.UBound(HdrStr); i <= loopTo; i++)
            {
                if (i > 0)
                {
                    textstr.Append(",");
                }

                textstr.Append(HdrStr[i]);
            }

            textstr.AppendLine();
            for (int x = 0, loopTo1 = DataGridView1.Rows.Count - 1; x <= loopTo1; x++)
            {
                if (Information.IsNothing(DataGridView1.Rows[x].Cells[VesselCell].Value) == false)
                {
                    for (int v = 0, loopTo2 = DataGridView1.Columns.Count - 1; v <= loopTo2; v++)
                    {
                        // extracting cell value from 0 to 9 and add it on list
                        if (v > 0)
                        {
                            textstr.Append(",");
                        }

                        string tempstr = DataGridView1.Rows[x].Cells[v].Value.ToString();
                        tempstr = tempstr.Replace(",", ""); // remove any commas input into any field so csv file is not corrupted
                        textstr.Append(tempstr);
                    }
                }
                // adding new line to text
                textstr.AppendLine();
            }

            System.IO.File.WriteAllText(FName, textstr.ToString(), System.Text.Encoding.GetEncoding("iso-8859-1"));
            SLOpenFName = FName;
            lblOpenFN.Visible = true;
            txtOpenFN.Visible = true;
            txtOpenFN.Text = SLOpenFName;
            saveFileDialog1.Dispose();
            return;
        }

        private void btnExitNoSave_Click(object sender, EventArgs e)
        {
            if (IsUpdated == true)
            {
                var MsgBack = Interaction.MsgBox("Data has been updated - Save to File - Yes or No", MsgBoxStyle.YesNo, "Save Updated Data");
                if (MsgBack == MsgBoxResult.Yes)
                {
                    SaveDataGrid();
                }

                IsUpdated = false;
            }

            CleanUp();
            Close();
            return;
        }

        private void btnOpenCSV_Click(object sender, EventArgs e)
        {
            System.IO.StreamReader myStream = null;
            var openFileDialog2 = new OpenFileDialog();
            // Dim CurrDir As String = FileIO.FileSystem.CurrentDirectory()

            if (IsUpdated == true)
            {
                var MsgBack = Interaction.MsgBox("Data has been updated - Save to File - Yes or No", MsgBoxStyle.YesNo, "Save Updated Data");
                if (MsgBack == MsgBoxResult.Yes)
                {
                    SaveDataGrid();
                }

                IsUpdated = false;
            }

            FileLoading = true;
            DataSet1.Tables[tablename].Clear();

            // Dim dirstr As String = FileIO.FileSystem.CurrentDirectory
            openFileDialog2.Reset();
            openFileDialog2.InitialDirectory = CurrDir;
            openFileDialog2.Filter = "txt files (*.txt)|*.txt|csv files (*.csv)|*.csv";
            openFileDialog2.Title = "Open Deck Log File";
            openFileDialog2.FilterIndex = 2;
            openFileDialog2.RestoreDirectory = true;
            openFileDialog2.AutoUpgradeEnabled = true;
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(openFileDialog2.FileName))
                {
                    openFileDialog2.Dispose();
                    return;
                }

                ReadError = false;
                int ReadNum = 0;
                try
                {
                    myStream = new System.IO.StreamReader(openFileDialog2.FileName, System.Text.Encoding.Default);
                    if (myStream is object)
                    {
                        FName = openFileDialog2.FileName;
                        SLOpenFName = openFileDialog2.FileName;
                        lblOpenFN.Visible = true;
                        txtOpenFN.Visible = true;
                        txtOpenFN.Text = SLOpenFName;
                        string allData = myStream.ReadToEnd();
                        var rows = allData.Split(Conversions.ToChar(Constants.vbCrLf)); // ("\r".ToCharArray())
                        int incr1 = 0;
                        foreach (string r1 in rows)
                        {
                            string r = r1;
                            r = r.Trim(Conversions.ToChar(Constants.vbLf)).Trim();
                            if (ReadNum == 0)
                            {
                                r = r.Trim(Conversions.ToChar(Constants.vbLf)).Trim();
                                var items = r.Split(',');
                            }
                            // For ctr As Integer = 0 To UBound(items)
                            // Set1.Tables(tablename).Columns.Add(items(ctr))
                            // Next
                            else
                            {
                                r = r.Trim(Conversions.ToChar(Constants.vbLf)).Trim();
                                var items1 = r.Split(',');
                                if (!string.IsNullOrEmpty(items1[0]) & items1[0] != null)
                                {
                                    DataSet1.Tables[tablename].Rows.Add(items1);
                                }
                            }

                            ReadNum += 1;
                            incr1 += 1;
                        }

                        myStream.Close();
                        DisplayCommonButtons();
                    }

                    openFileDialog2.Dispose();
                    myStream.Dispose();
                    DataGridView1.DataSource = DataSet1.Tables[0].DefaultView;
                    DataGridView1.ClearSelection();
                    DataGridView1.CurrentCell = null;
                    DisplayHideFirst4Col();
                    SortDataGridonDate();
                    evaluateDG();
                    DisplayDGRows();
                    DataGridView1.Refresh();
                    FileLoading = false;
                    Refresh();
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
            else
            {
                HideCommonButtons();
            }

            openFileDialog2.Dispose();
        }

        private static void ErrorMsgBox(string ErrMsg)
        {
            System.Windows.Forms.MessageBox.Show(ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, System.Windows.Forms.MessageBoxOptions.DefaultDesktopOnly);
            return;
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            SaveDataGrid();
            IsUpdated = false;
            return;
        }

        private void btnInfoForm_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.DeckLogHelp.Show();
            return;
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (FileLoading == true)
            {
                return;
            }

            if (InitialLoad == true)
            {
                return;
            }

            if (SortingDG == true)
            {
                return;
            }

            if (DRAdvanceMode == true)
            {
                return;
            }

            if (AddNewMode == true)
            {
                return;
            }

            UpdtRow = default;
            int n = default;
            // if a selection has occured but there are now rows in the datagridview then exit sub
            if (DataGridView1.Rows.Count == 0)
            {
                return;
            }

            if (Information.IsNothing(DataGridView1.CurrentRow.Index)) // Or DataGridView1.CurrentRow.Index = vbNull Then
            {
                return;
            }
            // if the selected row somehow has a blank or nullstring in the LogTypeCell then exit sub
            if (string.IsNullOrEmpty(DataGridView1.Rows[DataGridView1.CurrentRow.Index].Cells[LogTypeCell].Value.ToString() ) )         
            {
                return;
            }

            SelectedRow = true;
            n = DataGridView1.CurrentRow.Index;
            UpdtRow = DataGridView1.CurrentRow.Index;

            // The order of these variable and the integer indexs contained in each MUST match the order of the fields in the data grid
            // Cell 0 = Vessel name  
            // Cell 1 = Navigator name  
            // Cell 2 = From location name   
            // Cell 3 = To location name 
            // Cell 4 = L/Lo loc type 
            // Cell 5 = Zone Date & time String MM/dd/yyyy HH:mm:ss 
            // Cell 6 = Compass course string 
            // Cell 7 = Variation string 
            // Cell 8 = Deviation string
            // Cell 9 = Computed True Course string  
            // Cell 10 = DR Speed string  
            // Cell 11 = Latitude / Longitude string 
            // Cell 12 = Weather string   
            // Cell 13 = Remarks string
            // Cell 14 = Elapsed Time from Lat/Long to Dest Lat/Long
            // Cell 15 = Distance in nm from Lat/Long to Dest Lat/Long
            // Cell 16 = Calculated Destination Lat/Long
            // Cell 17 = Calculated True Course to destination
            // Cell 18 = Calculated Speed to make destination
            // Cell 19 = Calculated Set between two GPS/Fix locations
            // Cell 20 = Calculated Drift between two GPS/Fix locations
            // Cell 21 = Eval Based On string (filled in in EvaluatedDG subroutine)
            // Cell 22 = ZD 
            // Cell 23 = Knot Log
            // Cell 24 =  Wind info
            // Cell 25 =  Wind Direction
            // Cell 26 =  Seas Height info
            // Cell 27 =  UseForEval Y/N 

            if (DataGridView1.Rows[n].Cells[VesselCell].Value.ToString() != Constants.vbNullString)
            {
                UpdtRtn.Vessel = Conversions.ToString(DataGridView1.Rows[n].Cells[VesselCell].Value);
                txtVessel.Text = Conversions.ToString(DataGridView1.Rows[n].Cells[VesselCell].Value);
            }
            else
            {
                UpdtRtn.Vessel = Constants.vbNullString;
                txtVessel.Text = Constants.vbNullString;
            }

            if (DataGridView1.Rows[n].Cells[NavigatorCell].Value.ToString() != Constants.vbNullString)
            {
                UpdtRtn.Navigator = Conversions.ToString(DataGridView1.Rows[n].Cells[NavigatorCell].Value);
                txtNavigator.Text = Conversions.ToString(DataGridView1.Rows[n].Cells[NavigatorCell].Value);
            }
            else
            {
                UpdtRtn.Navigator = Constants.vbNullString;
                txtNavigator.Text = Constants.vbNullString;
            }

            if (DataGridView1.Rows[n].Cells[FromCell].Value.ToString() != Constants.vbNullString)
            {
                UpdtRtn.LocFrom = Conversions.ToString(DataGridView1.Rows[n].Cells[FromCell].Value);
                txtFrom.Text = Conversions.ToString(DataGridView1.Rows[n].Cells[FromCell].Value);
            }

            if (DataGridView1.Rows[n].Cells[ToCell].Value.ToString() != Constants.vbNullString)
            {
                UpdtRtn.LocTo = Conversions.ToString(DataGridView1.Rows[n].Cells[ToCell].Value);
                txtTo.Text = Conversions.ToString(DataGridView1.Rows[n].Cells[ToCell].Value);
            }
            else
            {
                UpdtRtn.LocTo = Constants.vbNullString;
                txtTo.Text = Constants.vbNullString;
            }

            if (DataGridView1.Rows[n].Cells[LogTypeCell].Value.ToString() != Constants.vbNullString)
            {
                UpdtRtn.LogType = Conversions.ToString(DataGridView1.Rows[n].Cells[LogTypeCell].Value);
                cboLocType.Text = Conversions.ToString(DataGridView1.Rows[n].Cells[LogTypeCell].Value);
            }
            else
            {
                UpdtRtn.LogType = Constants.vbNullString;
                cboLocType.Text = Constants.vbNullString;
            }

            if (DataGridView1.Rows[n].Cells[DTCell].Value.ToString() != Constants.vbNullString)
            {
                UpdtRtn.DateZoneTime = Conversions.ToString(DataGridView1.Rows[n].Cells[DTCell].Value);
                DTDateZoneTime.Value = Convert.ToDateTime(DataGridView1.Rows[n].Cells[DTCell].Value);
            }
            else
            {
                UpdtRtn.DateZoneTime = DateAndTime.Now.ToString(DTFormatString); // ("MM/dd/yyyy HH:mm:ss")
                DTDateZoneTime.Value = DateAndTime.Now;
            }

            if (DataGridView1.Rows[n].Cells[CompassCell].Value.ToString() != Constants.vbNullString)
            {
                int tlen = DataGridView1.Rows[n].Cells[CompassCell].Value.ToString().Length;
                UpdtRtn.Compass = DataGridView1.Rows[n].Cells[CompassCell].Value.ToString().Substring(0, tlen - 1);
                txtCompass.Text = DataGridView1.Rows[n].Cells[CompassCell].Value.ToString().Substring(0, tlen - 1);
            }
            else
            {
                UpdtRtn.Compass = Constants.vbNullString;
                txtCompass.Text = Constants.vbNullString;
            }

            if (DataGridView1.Rows[n].Cells[VarCell].Value.ToString() != Constants.vbNullString)
            {
                UpdtRtn.Var = Conversions.ToString(DataGridView1.Rows[n].Cells[VarCell].Value);
                UpdtRtn.VarEW = Conversions.ToString(UpdtRtn.Var.Last());
                UpdtRtn.Var = UpdtRtn.Var.Substring(0, UpdtRtn.Var.Length - 1);
                txtVar.Text = UpdtRtn.Var;
                cboVar.Text = UpdtRtn.VarEW;
            }
            else
            {
                UpdtRtn.Var = "";
                txtVar.Clear();
            }

            if (DataGridView1.Rows[n].Cells[DevCell].Value.ToString() != Constants.vbNullString)
            {
                UpdtRtn.Dev = Conversions.ToString(DataGridView1.Rows[n].Cells[DevCell].Value);
                UpdtRtn.DevEW = Conversions.ToString(UpdtRtn.Dev.Last());
                UpdtRtn.Dev = UpdtRtn.Dev.Substring(0, UpdtRtn.Dev.Length - 1);
                txtDev.Text = UpdtRtn.Dev;
                cboDev.Text = UpdtRtn.DevEW;
            }
            else
            {
                UpdtRtn.Dev = "";
                txtDev.Clear();
                cboDev.Text = CommonGlobals.g_LongW;
            }
            // End If


            if (DataGridView1.Rows[n].Cells[TrueCell].Value.ToString() != Constants.vbNullString)
            {
                int tlen = DataGridView1.Rows[n].Cells[TrueCell].Value.ToString().Length;
                UpdtRtn.CTrue = DataGridView1.Rows[n].Cells[TrueCell].Value.ToString().Substring(0, tlen - 1);
                txtCTrue.Text = DataGridView1.Rows[n].Cells[TrueCell].Value.ToString().Substring(0, tlen - 1);
            }
            else
            {
                UpdtRtn.CTrue = Constants.vbNullString;
                txtCTrue.Text = Constants.vbNullString;
            }

            if (DataGridView1.Rows[n].Cells[DRSpeedCell].Value.ToString() != Constants.vbNullString)
            {
                int tlen = DataGridView1.Rows[n].Cells[DRSpeedCell].Value.ToString().Length;
                UpdtRtn.Speed = DataGridView1.Rows[n].Cells[DRSpeedCell].Value.ToString().Substring(0, tlen - 2);
                txtSpeed.Text = DataGridView1.Rows[n].Cells[DRSpeedCell].Value.ToString().Substring(0, tlen - 2);
            }
            else
            {
                UpdtRtn.Speed = Constants.vbNullString;
                txtSpeed.Text = Constants.vbNullString;
            }

            if (DataGridView1.Rows[n].Cells[DestLogTypeCell].Value.ToString() != Constants.vbNullString)
            {
                UpdtRtn.PositionLatLong = Conversions.ToString(DataGridView1.Rows[n].Cells[DestLogTypeCell].Value);
                string LLo = Conversions.ToString(DataGridView1.Rows[n].Cells[DestLogTypeCell].Value);
                int LPos = LLo.IndexOf("=", StringComparison.OrdinalIgnoreCase);
                int LDegPos = LLo.IndexOf('°');
                int LMinPos = LLo.IndexOf("'", StringComparison.OrdinalIgnoreCase);
                int LoPos = LLo.IndexOf("=", LPos + 1, StringComparison.OrdinalIgnoreCase);
                int LoDegPos = LLo.IndexOf('°', LDegPos + 1);
                int LoMinPos = LLo.IndexOf("'", LMinPos + 1, StringComparison.OrdinalIgnoreCase);
                txtLDeg.Text = LLo.Substring(LPos + 1, LDegPos - 1 - (LPos + 1) + 1);
                txtLMin.Text = LLo.Substring(LDegPos + 1, LMinPos - 1 - (LDegPos + 1) + 1);
                cboL.Text = LLo.Substring(LMinPos + 1, 1);
                txtLoDeg.Text = LLo.Substring(LoPos + 1, LoDegPos - 1 - (LoPos + 1) + 1);
                txtLoMin.Text = LLo.Substring(LoDegPos + 1, LoMinPos - 1 - (LoDegPos + 1) + 1);
                cboLo.Text = LLo.Substring(LoMinPos + 1, 1);
            }
            else
            {
                UpdtRtn.PositionLatLong = Constants.vbNullString;
                txtLDeg.Clear();
                txtLMin.Clear();
                cboL.SelectedIndex = 0;
                txtLoDeg.Clear();
                txtLoMin.Clear();
                cboLo.SelectedIndex = 0;
            }

            if (DataGridView1.Rows[n].Cells[ZDCell].Value.ToString() != Constants.vbNullString)
            {
                UpdtRtn.ZD = Conversions.ToString(DataGridView1.Rows[n].Cells[ZDCell].Value);
                txtZD.Text = Conversions.ToString(DataGridView1.Rows[n].Cells[ZDCell].Value);
            }
            else
            {
                int TempZD = (int)Math.Abs(Math.Round(Convert.ToDouble(txtLoDeg.Text) + Convert.ToDouble(txtLoMin.Text) / 60d / 15d, 0));
                if ((cboLo.Text.ToString() == CommonGlobals.g_LongW ))
                {
                    UpdtRtn.ZD = "-" + TempZD.ToString("#0");
                    txtZD.Text = "-" + TempZD.ToString("#0");
                }
                else
                {
                    UpdtRtn.ZD = "+" + TempZD.ToString("#0");
                    txtZD.Text = "+" + TempZD.ToString("#0");
                }
            }

            if (DataGridView1.Rows[n].Cells[KnotLogCell].Value.ToString() != Constants.vbNullString)
            {
                UpdtRtn.KnotLog = Conversions.ToString(DataGridView1.Rows[n].Cells[KnotLogCell].Value);
                txtKnotLog.Text = Conversions.ToString(DataGridView1.Rows[n].Cells[KnotLogCell].Value);
            }
            else
            {
                UpdtRtn.KnotLog = Constants.vbNullString;
                txtKnotLog.Text = Constants.vbNullString;
            }

            if (DataGridView1.Rows[n].Cells[WeatherCell].Value.ToString() != Constants.vbNullString)
            {
                UpdtRtn.Weather = Conversions.ToString(DataGridView1.Rows[n].Cells[WeatherCell].Value);
                txtWeather.Text = Conversions.ToString(DataGridView1.Rows[n].Cells[WeatherCell].Value);
            }
            else
            {
                UpdtRtn.Weather = Constants.vbNullString;
                txtWeather.Text = Constants.vbNullString;
            }

            if (DataGridView1.Rows[n].Cells[WindCell].Value.ToString() != Constants.vbNullString)
            {
                UpdtRtn.Wind = Conversions.ToString(DataGridView1.Rows[n].Cells[WindCell].Value);
                txtWind.Text = Conversions.ToString(DataGridView1.Rows[n].Cells[WindCell].Value);
            }
            else
            {
                UpdtRtn.Wind = Constants.vbNullString;
                txtWind.Text = Constants.vbNullString;
            }

            if (DataGridView1.Rows[n].Cells[WindDirCell].Value.ToString() != Constants.vbNullString)
            {
                UpdtRtn.WindDir = Conversions.ToString(DataGridView1.Rows[n].Cells[WindDirCell].Value);
                cboWindDir.Text = Conversions.ToString(DataGridView1.Rows[n].Cells[WindDirCell].Value);
            }
            else
            {
                UpdtRtn.WindDir = Constants.vbNullString;
                cboWindDir.Text = Constants.vbNullString;
            }

            if (DataGridView1.Rows[n].Cells[UseForEvalCell].Value.ToString() == "Y")
            {
                chkUseForEval.Checked = true;
                UpdtRtn.UseForEval = "Y";
            }
            else
            {
                chkUseForEval.Checked = false;
                UpdtRtn.UseForEval = "N";
            }

            if (DataGridView1.Rows[n].Cells[NotesCell].Value.ToString() != Constants.vbNullString)
            {
                UpdtRtn.Remarks = Conversions.ToString(DataGridView1.Rows[n].Cells[NotesCell].Value);
                txtRemarks.Text = Conversions.ToString(DataGridView1.Rows[n].Cells[NotesCell].Value);
            }
            else
            {
                UpdtRtn.Remarks = Constants.vbNullString;
                txtRemarks.Text = Constants.vbNullString;
            }

            if ((UpdtRtn.LogType ) != (g_LogTypeDRAdv ))
            {
                lblAdvHrMin.Visible = false;
                cboAdvHrs.Visible = false;
                cboAdvMin.Visible = false;
                cboAdvType.Visible = false;
                lblAdvNm.Visible = false;
                cboAdvNm.Visible = false;
                grpAdvInfo.Visible = false;
            }
            
            if ((UpdtRtn.LogType ) == (g_LogTypePlan ))
            {
                txtDestElapsed.Text = (DataGridView1.Rows[n].Cells[ElapsedCell].Value.ToString());
                UpdtRtn.DestEstElapsed = (DataGridView1.Rows[n].Cells[ElapsedCell].Value.ToString());
                if ((string.IsNullOrEmpty(DataGridView1.Rows[n].Cells[DistCell].Value.ToString())) == false )
                {
                    txtDestDist.Text = Conversions.ToString(DataGridView1.Rows[n].Cells[DistCell].Value);
                    UpdtRtn.DestDistance = Convert.ToDouble(DataGridView1.Rows[n].Cells[DistCell].Value.ToString().Substring(0, txtDestDist.Text.ToString().Length - 2));
                }

                if ((string.IsNullOrEmpty(DataGridView1.Rows[n].Cells[CalcDestLogTypeCell].Value.ToString())) == false)
                 //   if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(DataGridView1.Rows[n].Cells[CalcDestLogTypeCell].Value, "", false)))
                {
                    UpdtRtn.DestLatLongStr = Conversions.ToString(DataGridView1.Rows[n].Cells[CalcDestLogTypeCell].Value);
                    string DestLLo = Conversions.ToString(DataGridView1.Rows[n].Cells[CalcDestLogTypeCell].Value);
                    int LPos = DestLLo.IndexOf("=", StringComparison.OrdinalIgnoreCase);
                    int LDegPos = DestLLo.IndexOf('°');
                    int LMinPos = DestLLo.IndexOf("'", StringComparison.OrdinalIgnoreCase);
                    int LoPos = DestLLo.IndexOf("=", LPos + 1, StringComparison.OrdinalIgnoreCase);
                    int LoDegPos = DestLLo.IndexOf('°', LDegPos + 1);
                    int LoMinPos = DestLLo.IndexOf("'", LMinPos + 1, StringComparison.OrdinalIgnoreCase);
                    txtDestLDeg.Text = DestLLo.Substring(LPos + 1, LDegPos - 1 - (LPos + 1) + 1);
                    txtDestLMin.Text = DestLLo.Substring(LDegPos + 1, LMinPos - 1 - (LDegPos + 1) + 1);
                    cboDestL.Text = DestLLo.Substring(LMinPos + 1, 1);
                    txtDestLoDeg.Text = DestLLo.Substring(LoPos + 1, LoDegPos - 1 - (LoPos + 1) + 1);
                    txtDestLoMin.Text = DestLLo.Substring(LoDegPos + 1, LoMinPos - 1 - (LoDegPos + 1) + 1);
                    cboDestLo.Text = DestLLo.Substring(LoMinPos + 1, 1);
                    txtDestTrue.Text = (DataGridView1.Rows[n].Cells[CalcDestTrueCell].Value.ToString());
                    UpdtRtn.DestTrueI = Convert.ToInt32(DataGridView1.Rows[n].Cells[CalcDestTrueCell].Value.ToString().Substring(0, txtDestTrue.Text.ToString().Length - 1));
                    int Pos1 = txtRemarks.Text.IndexOf(":", StringComparison.OrdinalIgnoreCase);
                    int Len1 = txtRemarks.Text.Length - (Pos1 + 1);
                    txtEstArrival.Text = txtRemarks.Text.Substring(Pos1 + 1, Len1);
                }
            }

            cboLocType.Items.Clear();
            cboLocType.Enabled = false;
            switch (UpdtRtn.LogType )
            {
                case var @case when @case == (g_LogTypeDR ):
                case var case1 when case1 == (g_LogTypeOldDR ):
                    {
                        cboLocType.Items.Add(g_LogTypeDR);
                        cboLocType.Items.Add(g_LogTypeDRAdv);
                        cboLocType.Items.Add(g_LogTypeGPS);
                        cboLocType.Items.Add(g_LogTypeFix);
                        cboLocType.Items.Add(g_LogTypeWayPoint);
                        cboLocType.Items.Add(g_LogTypePlan);
                        btnUpdateExisting.Visible = true;
                        btnDeleteSight.Visible = true;
                        break;
                    }

                case var case2 when case2 == (g_LogTypeFix ):
                case var case3 when case3 == (g_LogTypeWayPoint ):
                    {
                        cboLocType.Items.Add(g_LogTypeDR);
                        cboLocType.Items.Add(g_LogTypeGPS);
                        cboLocType.Items.Add(g_LogTypeFix);
                        cboLocType.Items.Add(g_LogTypeWayPoint);
                        cboLocType.Items.Add(g_LogTypePlan);
                        btnUpdateExisting.Visible = true;
                        btnDeleteSight.Visible = true;
                        break;
                    }

                case var case4 when case4 == (g_LogTypeGPS ):
                case var case5 when case5 == (g_LogTypeOldGPS ):
                    {
                        cboLocType.Items.Add(g_LogTypeDR);
                        cboLocType.Items.Add(g_LogTypeGPS);
                        cboLocType.Items.Add(g_LogTypeFix);
                        cboLocType.Items.Add(g_LogTypeWayPoint);
                        cboLocType.Items.Add(g_LogTypePlan);
                        btnUpdateExisting.Visible = true;
                        btnDeleteSight.Visible = true;
                        break;
                    }

                case var case6 when case6 == (g_LogTypePlan ):
                    {
                        cboLocType.Items.Add(g_LogTypeDR);
                        cboLocType.Items.Add(g_LogTypeGPS);
                        cboLocType.Items.Add(g_LogTypeFix);
                        cboLocType.Items.Add(g_LogTypeWayPoint);
                        cboLocType.Items.Add(g_LogTypePlan);
                        btnUpdateExisting.Visible = true;
                        btnDeleteSight.Visible = true;
                        break;
                    }

                default:
                    {
                        ErrorMsgBox("The Log Entry you have selected has an invalid Log Type. Select a new log type for this entry and update it. This error occurs because of changing log types and old file formats");
                        cboLocType.Items.Add(g_LogTypeDR);
                        cboLocType.Items.Add(g_LogTypeGPS);
                        cboLocType.Items.Add(g_LogTypeFix);
                        cboLocType.Items.Add(g_LogTypeWayPoint);
                        cboLocType.Items.Add(g_LogTypePlan);
                        btnUpdateExisting.Visible = false;
                        btnDeleteSight.Visible = false;
                        break;
                    }
            }

            cboLocType.Enabled = true;
            Refresh();
            SelectedRow = false;
            return;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ProcessAddNew();
            SortingDG = true;
            RemoveEmptyRowsinDG();
            SortingDG = false;
            return;
        }

        private readonly string G_UseDestData = "Use Dest Data";

        private void ProcessAddNew()
        {
            AddNewMode = true;
            if ((cboLocType.Text.ToString() == g_LogTypeDR ))
            {
                if (My.MyProject.Forms.ZTInfo.InvokedbyDeckLog == true)
                {
                    if (DestDTUpdatedbyZTInfo == true)
                    {
                        DTDateZoneTime.Value = DestDTfromZTInfo;
                        DestDTUpdatedbyZTInfo = false;
                        My.MyProject.Forms.ZTInfo.InvokedbyDeckLog = false;
                    }
                    else
                    {
                        My.MyProject.Forms.ZTInfo.InvokedbyDeckLog = false;
                        DestDTUpdatedbyZTInfo = false;
                    }
                }
                else
                {
                    My.MyProject.Forms.ZTInfo.InvokedbyDeckLog = false;
                    DestDTUpdatedbyZTInfo = false;
                }
            }

            if ((cboLocType.Text.ToString() == g_LogTypeDRAdv ))
            {
                DRAdvanceMode = true;
                FindInstallAdvancedDR();
                cboLocType.Text = g_LogTypeDR;
                if (EditUpdtFields() == false)
                {
                    DRAdvanceMode = false;
                    Refresh();
                    AddNewMode = false;
                    return;
                }

                lblAdvHrMin.Visible = false;
                cboAdvHrs.Visible = false;
                cboAdvMin.Visible = false;
                lblAdvNm.Visible = false;
                cboAdvNm.Visible = false;
                grpAdvInfo.Visible = false;
                cboAdvHrs.Value = 0m;
                cboAdvMin.Value = 0m;
                DRAdvanceMode = false;
                SortDataGridonDate();
                evaluateDG();
                DisplayDGRows();
                DataGridView1.CurrentCell.Selected = true;
                DataGridView1.Refresh();
                ResetSomeScreenFields();
                DisplayCommonButtons();
                Refresh();
                IsUpdated = true;
                DTChanged = false;
                AddNewMode = false;
                return;
            }

            if (EditUpdtFields() == false)
            {
                Refresh();
                AddNewMode = false;
                return;
            }

            if ((cboLocType.Text.ToString() == g_LogTypePlan ))
            {
                if (EditPlanFields() == false)
                {
                    Refresh();
                    AddNewMode = false;
                    return;
                }
            }

            string LLo = "L=" + txtLDeg.Text.ToString() + '°' + txtLMin.Text.ToString() + "'" + cboL.Text.ToString() + " Lo=" + txtLoDeg.Text.ToString() + '°' + txtLoMin.Text.ToString() + "'" + cboLo.Text.ToString();
            string TempEval4Use = "N";
            if (chkUseForEval.Checked == true)
            {
                TempEval4Use = "Y";
            }

            if ((cboLocType.Text.ToString() == g_LogTypePlan ) | (cboLocType.Text.ToString() == g_LogTypeOldPlan ))
            {
                string DestLLo = "L=" + txtDestLDeg.Text.ToString() + '°' + txtDestLMin.Text.ToString() + "'" + cboDestL.Text.ToString() + " Lo=" + txtDestLoDeg.Text.ToString() + '°' + txtDestLoMin.Text.ToString() + "'" + cboDestLo.Text.ToString();
                DataSet1.Tables[tablename].Rows.Add(txtVessel.Text.ToString(), txtNavigator.Text.ToString(), txtFrom.Text.ToString(), txtTo.Text.ToString(), cboLocType.Text.ToString(), DTDateZoneTime.Value.ToString(DTFormatString), txtCompass.Text.ToString() + '°', txtVar.Text.ToString() + cboVar.Text, txtDev.Text.ToString() + cboDev.Text, txtCTrue.Text.ToString() + '°', txtSpeed.Text.ToString() + "kn", LLo, txtWeather.Text.ToString(), txtRemarks.Text.ToString(), txtDestElapsed.Text, txtDestDist.Text, DestLLo, txtDestTrue.Text, "", "", "", "Plan Entry", txtZD.Text, txtKnotLog.Text, txtWind.Text, cboWindDir.Text.ToString(), txtSeas.Text.ToString(), TempEval4Use);
            }
            else if ((cboLocType.Text.ToString() == g_LogTypeFix ) | (cboLocType.Text.ToString() == g_LogTypeWayPoint ))
            {
                DataSet1.Tables[tablename].Rows.Add(txtVessel.Text.ToString(), txtNavigator.Text.ToString(), txtFrom.Text.ToString(), txtTo.Text.ToString(), cboLocType.Text.ToString(), DTDateZoneTime.Value.ToString(DTFormatString), "", "", "", "", "", LLo, txtWeather.Text.ToString(), txtRemarks.Text.ToString(), "", "", "", "", "", "", "", "", txtZD.Text, txtKnotLog.Text, txtWind.Text, cboWindDir.Text.ToString(), txtSeas.Text.ToString(), TempEval4Use);
            }
            else
            {
                DataSet1.Tables[tablename].Rows.Add(txtVessel.Text.ToString(), txtNavigator.Text.ToString(), txtFrom.Text.ToString(), txtTo.Text.ToString(), cboLocType.Text.ToString(), DTDateZoneTime.Value.ToString(DTFormatString), txtCompass.Text.ToString() + '°', txtVar.Text.ToString() + cboVar.Text, txtDev.Text.ToString() + cboDev.Text, txtCTrue.Text.ToString() + '°', txtSpeed.Text.ToString() + "kn", LLo, txtWeather.Text.ToString(), txtRemarks.Text.ToString(), "", "", "", "", "", "", "", "", txtZD.Text, txtKnotLog.Text, txtWind.Text, cboWindDir.Text.ToString(), txtSeas.Text.ToString(), TempEval4Use);
            }

            // transfer destination info to input fields for next Plan log entry

            if ((cboLocType.Text.ToString() == g_LogTypePlan ))
            {
                if (AutoGCRMode == false)
                {
                    // Dim result As DialogResult = MessageBox.Show("Use Destination data to build next Plan Log entry - Yes/No", G_UseDestData, MessageBoxButtons.YesNo)
                    // If result = DialogResult.Yes Then
                    DTDateZoneTime.Value = DestEstArrival;
                    txtLDeg.Text = txtDestLDeg.Text;
                    txtLMin.Text = txtDestLMin.Text;
                    cboL.SelectedIndex = cboDestL.SelectedIndex;
                    txtLoDeg.Text = txtDestLoDeg.Text;
                    txtLoMin.Text = txtDestLoMin.Text;
                    cboLo.SelectedIndex = cboDestLo.SelectedIndex;
                    txtSpeed.Text = UpdtRtn.SpeedI.ToString("#0.0");
                    txtCTrue.Text = UpdtRtn.CTrueI.ToString("##0");   // txtDestTrue.Text.ToString.Substring(0, txtDestTrue.Text.ToString.Length - 1)
                    txtDev.Text = Math.Abs(UpdtRtn.DevI).ToString("#0");
                    if ((UpdtRtn.DevEW ) == (CommonGlobals.g_LongW ))
                    {
                        cboDev.SelectedIndex = 0;
                    }
                    else
                    {
                        cboDev.SelectedIndex = 1;
                    }
                    // Dim DtrueI As Integer = Convert.ToInt32(txtDestTrue.Text.ToString.Replace(Chr(176), "").Trim)
                    // Dim DDevI As Integer = Convert.ToInt32(txtDev.Text.ToString.Replace(Chr(176), "").Trim)
                    txtCompass.Text = (UpdtRtn.CTrueI + UpdtRtn.DevI + UpdtRtn.VarI).ToString("##0");
                    txtZD.Text = txtDestZD.Text;
                    txtDestLDeg.Clear();
                    txtDestLMin.Clear();
                    txtDestLoDeg.Clear();
                    txtDestLoMin.Clear();
                    txtDestTrue.Clear();
                    txtDestDist.Clear();
                    txtDestElapsed.Clear();
                    txtDestZD.Clear();
                    txtEstArrival.Clear();
                    txtWeather.Clear();
                    txtRemarks.Clear();
                    lblAdvHrMin.Visible = true;
                    cboAdvHrs.Visible = true;
                    cboAdvMin.Visible = true;
                    lblAdvNm.Visible = true;
                    cboAdvNm.Visible = true;
                    grpAdvInfo.Visible = true;
                    cboAdvType.Visible = true;
                }
                else
                {
                    DTDateZoneTime.Value = DestEstArrival;
                    txtLDeg.Text = txtDestLDeg.Text;
                    txtLMin.Text = txtDestLMin.Text;
                    cboL.SelectedIndex = cboDestL.SelectedIndex;
                    txtLoDeg.Text = txtDestLoDeg.Text;
                    txtLoMin.Text = txtDestLoMin.Text;
                    cboLo.SelectedIndex = cboDestLo.SelectedIndex;
                    txtSpeed.Text = UpdtRtn.SpeedI.ToString("#0.0");
                    txtCTrue.Text = UpdtRtn.CTrueI.ToString("##0");   // txtDestTrue.Text.ToString.Substring(0, txtDestTrue.Text.ToString.Length - 1)
                    txtDev.Text = Math.Abs(UpdtRtn.DevI).ToString("#0");
                    if ((UpdtRtn.DevEW ) == (CommonGlobals.g_LongW ))
                    {
                        cboDev.SelectedIndex = 0;
                    }
                    else
                    {
                        cboDev.SelectedIndex = 1;
                    }

                    // Dim DtrueI As Integer = Convert.ToInt32(txtDestTrue.Text.ToString.Replace(Chr(176), "").Trim)
                    // Dim DDevI As Integer = Convert.ToInt32(txtDev.Text.ToString.Replace(Chr(176), "").Trim)
                    // txtCompass.Text = (DtrueI + DDevI + UpdtRtn.VarI).ToString("##0")

                    txtCompass.Text = (UpdtRtn.CTrueI + UpdtRtn.DevI + UpdtRtn.VarI).ToString("##0");
                    txtZD.Text = txtDestZD.Text;
                    txtDestLDeg.Clear();
                    txtDestLMin.Clear();
                    txtDestLoDeg.Clear();
                    txtDestLoMin.Clear();
                    txtDestTrue.Clear();
                    txtDestDist.Clear();
                    txtDestElapsed.Clear();
                    txtDestZD.Clear();
                    txtEstArrival.Clear();
                    txtWeather.Clear();
                    txtRemarks.Clear();
                    lblAdvHrMin.Visible = true;
                    cboAdvHrs.Visible = true;
                    cboAdvMin.Visible = true;
                    lblAdvNm.Visible = true;
                    cboAdvNm.Visible = true;
                    grpAdvInfo.Visible = true;
                    cboAdvType.Visible = true;
                }
            }

            if ((cboLocType.Text.ToString() != g_LogTypePlan ) & DRAdvanceMode == false & AutoGCRMode == false)
            {
                ResetSomeScreenFields();
                DisplayCommonButtons();
            }

            if (AutoGCRMode == false)
            {
                SortDataGridonDate();
                evaluateDG();
                DisplayDGRows();
                // DataGridView1.ClearSelection()
                DataGridView1.CurrentCell.Selected = true;
                DataGridView1.Refresh();
                DisplayCommonButtons();
            }

            // DataGridView1.ClearSelection()
            DataGridView1.CurrentCell.Selected = true;
            DataGridView1.Refresh();
            Refresh();
            IsUpdated = true;
            DTChanged = false;
            AddNewMode = false;
            return;
        }

        private void btnUpdateExisting_Click(object sender, EventArgs e)
        {
            ProcessUpdateExisting();
            return;
        }

        private readonly string g_DrAdvError1 = "Can Not Update DRAdvance Entry";

        private void ProcessUpdateExisting()
        {
            AddNewMode = false;
            if ((cboLocType.Text.ToString() == g_LogTypeDRAdv ))
            {
                var result = System.Windows.MessageBox.Show("Error - Can Not Update a DRAdvance type log entry - Change to DR type entry = Yes or No to exit", g_DrAdvError1, (MessageBoxButton)MessageBoxButtons.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    cboLocType.Text = g_LogTypeDR;
                    lblAdvHrMin.Visible = false;
                    cboAdvHrs.Visible = false;
                    cboAdvMin.Visible = false;
                    lblAdvNm.Visible = false;
                    cboAdvNm.Visible = false;
                    grpAdvInfo.Visible = false;
                    cboAdvType.Visible = false;
                    AdvMin = Convert.ToInt32(cboAdvHrs.Value.ToString()) * 60 + Convert.ToInt32(cboAdvMin.Value.ToString());
                    DTDateZoneTime.Value = DTDateZoneTime.Value.AddMinutes(AdvMin);
                }
                else
                {
                    return;
                }
            }

            if (EditUpdtFields() == false)
            {
                Refresh();
                return;
            }

            if ((cboLocType.Text.ToString() == g_LogTypePlan ))
            {
                if (EditPlanFields() == false)
                {
                    Refresh();
                    return;
                }
            }

            bool PlanDTChg = false;
            bool DRGPSSightDTChg = false;
            DateTime NewDT;
            var OriginalDT = default(DateTime);
            var TDiff = default(TimeSpan);
            if (Convert.ToDateTime(DataGridView1.Rows[UpdtRow].Cells[DTCell].Value) != DTDateZoneTime.Value)
            {
                if ((cboLocType.Text.ToString() == g_LogTypePlan ) | (cboLocType.Text.ToString() == g_LogTypeOldPlan ))
                {
                    // if this is a planned route entry and the date/time has changed, ask if user wants to autocalc subsequent entries to new date / time and execute updat
                    if (UpdtRow < DataGridView1.Rows.Count)
                    {
                        var MsgBack = Interaction.MsgBox("Plan Entry Date/Time has been updated - Do You Want to AutoUpdate the Date/Time for subsequent Plan entries - Yes or No", MsgBoxStyle.YesNo, "Save Updated Data");
                        if (MsgBack == MsgBoxResult.Yes)
                        {
                            NewDT = DTDateZoneTime.Value;
                            OriginalDT = Convert.ToDateTime(DataGridView1.Rows[UpdtRow].Cells[DTCell].Value);
                            TDiff = NewDT - OriginalDT;
                            PlanDTChg = true;
                        }
                        else
                        {
                            PlanDTChg = false;
                        }
                    }
                }
                else if ((cboLocType.Text == g_LogTypeDR ) | (cboLocType.Text == g_LogTypeOldDR ) | 
                    (cboLocType.Text  == g_LogTypeOldGPS ) | (cboLocType.Text == g_LogTypeGPS ))
                {
                    if (UpdtRow < DataGridView1.Rows.Count)
                    {
                        var MsgBack = Interaction.MsgBox("DR/GPS Entry Date/Time has been updated - Do You Want to AutoUpdate the Date/Time for subsequent DR/GPS entries - Yes or No", MsgBoxStyle.YesNo, "Save Updated Data");
                        if (MsgBack == MsgBoxResult.Yes)
                        {
                            NewDT = DTDateZoneTime.Value;
                            OriginalDT = Convert.ToDateTime(DataGridView1.Rows[UpdtRow].Cells[DTCell].Value);
                            TDiff = NewDT - OriginalDT;
                            DRGPSSightDTChg = true;
                        }
                        else
                        {
                            DRGPSSightDTChg = false;
                        }
                    }
                }
            }

            string LLo = "";
            LLo = "L=" + UpdtRtn.LDegI.ToString("00") + '°' + UpdtRtn.LMinI.ToString("00.0") + "'" + cboL.Text.ToString() + " Lo=" + UpdtRtn.LoDegI.ToString("00") + '°' + UpdtRtn.LoMinI.ToString("00.0") + "'" + cboLo.Text.ToString();
            DataGridView1.Rows[UpdtRow].Cells[VesselCell].Value = txtVessel.Text;
            DataGridView1.Rows[UpdtRow].Cells[NavigatorCell].Value = txtNavigator.Text;
            DataGridView1.Rows[UpdtRow].Cells[FromCell].Value = txtFrom.Text;
            DataGridView1.Rows[UpdtRow].Cells[ToCell].Value = txtTo.Text;
            DataGridView1.Rows[UpdtRow].Cells[LogTypeCell].Value = cboLocType.Text;
            DataGridView1.Rows[UpdtRow].Cells[DTCell].Value = DTDateZoneTime.Value.ToString(DTFormatString);
            if ((cboLocType.Text.ToString() == g_LogTypeWayPoint ) | (cboLocType.Text.ToString() == g_LogTypeFix ))
            {
                DataGridView1.Rows[UpdtRow].Cells[CompassCell].Value = "";
                DataGridView1.Rows[UpdtRow].Cells[VarCell].Value = "";
                DataGridView1.Rows[UpdtRow].Cells[DevCell].Value = "";
                DataGridView1.Rows[UpdtRow].Cells[TrueCell].Value = "";
                DataGridView1.Rows[UpdtRow].Cells[DRSpeedCell].Value = "";
            }
            else
            {
                DataGridView1.Rows[UpdtRow].Cells[CompassCell].Value = txtCompass.Text + '°';
                DataGridView1.Rows[UpdtRow].Cells[VarCell].Value = txtVar.Text + cboVar.Text;
                DataGridView1.Rows[UpdtRow].Cells[DevCell].Value = txtDev.Text + cboDev.Text;
                DataGridView1.Rows[UpdtRow].Cells[TrueCell].Value = txtCTrue.Text + '°';
                DataGridView1.Rows[UpdtRow].Cells[DRSpeedCell].Value = txtSpeed.Text + "kn";
            }

            DataGridView1.Rows[UpdtRow].Cells[DestLogTypeCell].Value = LLo;
            DataGridView1.Rows[UpdtRow].Cells[WeatherCell].Value = txtWeather.Text;
            DataGridView1.Rows[UpdtRow].Cells[NotesCell].Value = txtRemarks.Text;
            DataGridView1.Rows[UpdtRow].Cells[KnotLogCell].Value = txtKnotLog.Text;
            DataGridView1.Rows[UpdtRow].Cells[WindCell].Value = txtWind.Text;
            DataGridView1.Rows[UpdtRow].Cells[WindDirCell].Value = cboWindDir.Text.ToString();
            DataGridView1.Rows[UpdtRow].Cells[SeasCell].Value = txtSeas.Text;
            if (chkUseForEval.Checked == true)
            {
                DataGridView1.Rows[UpdtRow].Cells[UseForEvalCell].Value = "Y";
            }
            else
            {
                DataGridView1.Rows[UpdtRow].Cells[UseForEvalCell].Value = "N";
            }

            if ((cboLocType.Text.ToString() == g_LogTypePlan ) | (cboLocType.Text.ToString()  == g_LogTypeOldPlan))
            {
                string DestLLo = "L=" + txtDestLDeg.Text.ToString() + '°' + txtDestLMin.Text.ToString() + "'" + cboDestL.Text.ToString() + " Lo=" + txtDestLoDeg.Text.ToString() + '°' + txtDestLoMin.Text.ToString() + "'" + cboDestLo.Text.ToString();
                DataGridView1.Rows[UpdtRow].Cells[ElapsedCell].Value = txtDestElapsed.Text;
                DataGridView1.Rows[UpdtRow].Cells[DistCell].Value = txtDestDist.Text;
                DataGridView1.Rows[UpdtRow].Cells[CalcDestLogTypeCell].Value = DestLLo;
                DataGridView1.Rows[UpdtRow].Cells[CalcDestTrueCell].Value = txtDestTrue.Text;
            }

            if (PlanDTChg == true)
            {
                for (int i = UpdtRow + 1, loopTo = DataGridView1.Rows.Count - 1; i <= loopTo; i++)
                {
                    if ((DataGridView1.Rows[i].Cells[LogTypeCell].Value.ToString() == g_LogTypePlan) & (i != UpdtRow))
                    {
                        var DTTemp = Convert.ToDateTime(DataGridView1.Rows[i].Cells[DTCell].Value);
                        if (DTTemp > OriginalDT)
                        {
                            DTTemp = DTTemp.AddSeconds(TDiff.TotalSeconds);
                            DataGridView1.Rows[i].Cells[DTCell].Value = DTTemp.ToString(DTFormatString); // ("MM/dd/yyyy HH:mm:ss")
                        }
                    }
                }
            }

            if (DRGPSSightDTChg == true)
            {
                for (int i = UpdtRow + 1, loopTo1 = DataGridView1.Rows.Count - 1; i <= loopTo1; i++)
                {
                    if (((DataGridView1.Rows[i].Cells[LogTypeCell].Value.ToString() ==  g_LogTypeDR) |
                        (DataGridView1.Rows[i].Cells[LogTypeCell].Value.ToString() == g_LogTypeOldDR) |
                        (DataGridView1.Rows[i].Cells[LogTypeCell].Value.ToString() == g_LogTypeGPS) |
                        (DataGridView1.Rows[i].Cells[LogTypeCell].Value.ToString() == g_LogTypeOldGPS)) & (i != UpdtRow))
                        //if (Conversions.ToBoolean(Operators.AndObject(Operators.ConditionalCompareObjectNotEqual(DataGridView1.Rows[i].Cells[LogTypeCell].Value, g_LogTypePlan, false), i != UpdtRow)))
                    {
                        var DTTemp = Convert.ToDateTime(DataGridView1.Rows[i].Cells[DTCell].Value);
                        if (DTTemp > OriginalDT)
                        {
                            DTTemp = DTTemp.AddSeconds(TDiff.TotalSeconds);
                            DataGridView1.Rows[i].Cells[DTCell].Value = DTTemp.ToString(DTFormatString); // ("MM/dd/yyyy HH:mm:ss")
                        }
                    }
                }
            }

            SortDataGridonDate();
            evaluateDG();
            DisplayDGRows();
            DataGridView1.ClearSelection();
            DataGridView1.CurrentCell = null;
            ResetSomeScreenFields();
            DisplayCommonButtons();
            DataGridView1.Refresh();
            Refresh();
            IsUpdated = true;
            DTChanged = false;
            return;
        }

        private void btnDeleteSight_Click(object sender, EventArgs e)
        {
            // turn addnewmode on so that any side effects of selecting / deleting a row is suppressed
            AddNewMode = true;
            // first remove selected row from DataSet and suppress side effects of updating row
            CurrencyManager currencyManager1;
            currencyManager1 = (CurrencyManager)BindingContext[DataSet1];
            currencyManager1.SuspendBinding();
            DataSet1.Tables[tablename].Rows.RemoveAt(UpdtRow);
            // now remove the selected row from the datagridview
            var DltRow = DataGridView1.Rows[UpdtRow];
            DataGridView1.Rows.Remove(DltRow);
            currencyManager1.ResumeBinding();
            AddNewMode = false;
            SortDataGridonDate();
            evaluateDG();
            DisplayDGRows();
            DataGridView1.ClearSelection();
            DataGridView1.CurrentCell = null;
            ResetSomeScreenFields();
            DisplayCommonButtons();
            DataGridView1.Refresh();
            Refresh();
            IsUpdated = true;
            DTChanged = false;
            return;
        }

        private bool EditUpdtFields()
        {
            TrueInput = false;
            CompassInput = false;
            // all entry types require vessel, navigator, from and to text boxes with something in them
            if (string.IsNullOrEmpty(txtVessel.Text) | string.IsNullOrEmpty(txtVessel.Text))
            {
                ErrorMsgBox("Vessel Name must be entered");
                return false;
            }

            if (string.IsNullOrEmpty(txtNavigator.Text) | string.IsNullOrEmpty(txtNavigator.Text))
            {
                ErrorMsgBox("Navigator Name must be entered");
                return false;
            }

            if (string.IsNullOrEmpty(txtFrom.Text) | string.IsNullOrEmpty(txtFrom.Text))
            {
                ErrorMsgBox("From Location must be entered");
                return false;
            }

            if (string.IsNullOrEmpty(txtTo.Text) | string.IsNullOrEmpty(txtTo.Text))
            {
                ErrorMsgBox("Destination Location must be entered");
                return false;
            }

            // all entries require location lat / long data be input so edit those fields
            if (string.IsNullOrEmpty(txtLDeg.Text) | string.IsNullOrEmpty(txtLDeg.Text))
            {
                ErrorMsgBox("Latitude Degrees must be entered");
                return false;
            }

            if (Information.IsNumeric(txtLDeg.Text) == false)
            {
                ErrorMsgBox("Latitude Degrees must be numeric between 0 and 89");
                return false;
            }

            try
            {
                UpdtRtn.LDegI = Convert.ToInt32(txtLDeg.Text);
                if (UpdtRtn.LDegI < 0 | UpdtRtn.LDegI > 89)
                {
                    ErrorMsgBox("Latitude Degrees must be numeric between 0 and 89");
                    return false;
                }
            }
            catch (Exception ex)
            {
                ErrorMsgBox("Latitude Degrees must be numeric between 0 and 89");
                return false;
            }

            if (string.IsNullOrEmpty(txtLMin.Text) | string.IsNullOrEmpty(txtLMin.Text))
            {
                ErrorMsgBox("Latitude Minutes must be entered");
                return false;
            }

            if (Information.IsNumeric(txtLMin.Text) == false)
            {
                ErrorMsgBox("Latitude Minutes be numeric between 0 and 59.9");
                return false;
            }

            try
            {
                UpdtRtn.LMinI = Convert.ToDouble(txtLMin.Text);
                UpdtRtn.LNS = cboL.Text;
                if ((cboL.Text.ToString() == CommonGlobals.g_LatN))
                {
                    UpdtRtn.LatDouble = Convert.ToDouble(UpdtRtn.LDegI) + UpdtRtn.LMinI / 60d;
                }
                else
                {
                    UpdtRtn.LatDouble = -1 * (Convert.ToDouble(UpdtRtn.LDegI) + UpdtRtn.LMinI / 60d);
                }

                if (UpdtRtn.LMinI < 0d | UpdtRtn.LMinI > 59.9d)
                {
                    ErrorMsgBox("Latitude Minutes must be numeric between 0 and 59.9");
                    return false;
                }
            }
            catch (Exception ex)
            {
                ErrorMsgBox("Latitude Minutes must be numeric between 0 and 59.9");
                return false;
            }

            if (string.IsNullOrEmpty(txtLoDeg.Text) | string.IsNullOrEmpty(txtLoDeg.Text))
            {
                ErrorMsgBox("Longitude Degrees must be entered");
                return false;
            }

            if (Information.IsNumeric(txtLoDeg.Text) == false)
            {
                ErrorMsgBox("Longitude Degrees must be numeric between 0 and 89");
                return false;
            }

            try
            {
                UpdtRtn.LoDegI = Convert.ToInt32(txtLoDeg.Text);
                if (UpdtRtn.LoDegI < 0 | UpdtRtn.LoDegI > 180)
                {
                    ErrorMsgBox("Longitude Degrees must be numeric between 0 and 180");
                    return false;
                }
            }
            catch (Exception ex)
            {
                ErrorMsgBox("Longitude Degrees must be numeric between 0 and 180");
                return false;
            }

            if (string.IsNullOrEmpty(txtLoMin.Text) | string.IsNullOrEmpty(txtLoMin.Text))
            {
                ErrorMsgBox("Longitude Minutes must be entered");
                return false;
            }

            if (Information.IsNumeric(txtLoMin.Text) == false)
            {
                ErrorMsgBox("Longitude Minutes be numeric between 0 and 59.9");
                return false;
            }

            try
            {
                UpdtRtn.LoMinI = Convert.ToDouble(txtLoMin.Text);
                UpdtRtn.LoEW = cboLo.Text;
                if ((cboLo.Text.ToString() == CommonGlobals.g_LongW ))
                {
                    UpdtRtn.LongDouble = -1 * (Convert.ToDouble(UpdtRtn.LoDegI) + UpdtRtn.LoMinI / 60d);
                }
                else
                {
                    UpdtRtn.LongDouble = Convert.ToDouble(UpdtRtn.LoDegI) + UpdtRtn.LoMinI / 60d;
                }

                if (UpdtRtn.LoMinI < 0d | UpdtRtn.LoMinI > 59.9d)
                {
                    ErrorMsgBox("Longitude Minutes must be numeric between 0 and 59.9");
                    return false;
                }
            }
            catch (Exception ex)
            {
                ErrorMsgBox("Longitude Minutes must be numeric between 0 and 59.9");
                return false;
            }

            if ((cboLocType.Text.ToString() == g_LogTypeFix ) & (string.IsNullOrEmpty(txtRemarks.Text) | string.IsNullOrEmpty(txtRemarks.Text)))
            {
                ErrorMsgBox("An Entry Type of Fix requires Remarks describing Fix data be entered");
                return false;
            }
            // due to csv file format for decklog file, all commas, line feeds, and CR/line feeds must be removed
            txtRemarks.Text = txtRemarks.Text.ToString().Replace(Constants.vbCr, "").Replace(Constants.vbCrLf, "").Replace(",", "");
            txtWeather.Text = txtWeather.Text.ToString().Replace(Constants.vbCr, "").Replace(Constants.vbCrLf, "").Replace(",", "");
            UpdtRtn.Wind = txtWind.Text.ToString();
            UpdtRtn.WindDir = cboWindDir.Text.ToString();
            UpdtRtn.Seas = txtSeas.Text.ToString();
            if (chkUseForEval.Checked == true)
            {
                UpdtRtn.UseForEval = "Y";
            }
            else
            {
                UpdtRtn.UseForEval = "N";
            }

            int TempZD = (int)Math.Round((Convert.ToDouble(UpdtRtn.LoDegI) + UpdtRtn.LoMinI / 60d) / 15d, 0);
            if ((cboLo.Text.ToString() == CommonGlobals.g_LongE ))
            {
                TempZD = -1 * TempZD;
            }

            txtZD.Text = TempZD.ToString();
            UpdtRtn.ZD = TempZD.ToString();

            // Now if this is a Fix or Waypoint type of entry then edits are done because those types only require/allow date/time and location inputs
            if ((cboLocType.Text.ToString() == g_LogTypeFix ) | (cboLocType.Text.ToString() == g_LogTypeWayPoint ))
            {
                return true;
            }

            // A DR Track entry must have a compass course entered that is non-blank - a zero course is valid
            CompassInput = false;
            if ((cboLocType.Text.ToString() == g_LogTypeDR ) | (cboLocType.Text.ToString() == g_LogTypeOldDR ))
            {
                if (string.IsNullOrEmpty(txtCompass.Text) | string.IsNullOrEmpty(txtCompass.Text))
                {
                    ErrorMsgBox("For DR Track Entry Compass Course must be entered - input one and try again");
                    return false;
                }
                else
                {
                    CompassInput = true;
                }
            }
            else if (string.IsNullOrEmpty(txtCompass.Text) | string.IsNullOrEmpty(txtCompass.Text))
            {
            }
            // Nothing()
            else
            {
                CompassInput = true;
            }

            // GPS track log entries and Plan log entries must have True Course entries made - a zero true course is valid
            TrueInput = false;
            if ((cboLocType.Text.ToString() == g_LogTypeGPS ) | (cboLocType.Text.ToString() == g_LogTypeOldGPS ) | (cboLocType.Text.ToString() == g_LogTypePlan ) | (cboLocType.Text.ToString() == g_LogTypeOldPlan ))
            {
                if (string.IsNullOrEmpty(txtCTrue.Text) & string.IsNullOrEmpty(txtCTrue.Text))
                {
                    ErrorMsgBox("For GPS Track or Plan Entry a True Course must be entered - input one and try again");
                    return false;
                }
                else
                {
                    TrueInput = true;
                }
            }
            else if (string.IsNullOrEmpty(txtCTrue.Text) & string.IsNullOrEmpty(txtCTrue.Text))
            {
            }
            // nothing
            else
            {
                TrueInput = true;
            }

            if (CompassInput == false & TrueInput == false & string.IsNullOrEmpty(txtCTrue.Text) & string.IsNullOrEmpty(txtCompass.Text))
            {
                // neither was input - issue an error message
                ErrorMsgBox("Either Compass or True Course must be entered - input one and try again");
                return false;
            }

            // if log type is GPS, DR, or Fix = Not a Plan type
            if ((cboLocType.Text.ToString() == g_LogTypeDR ) | (cboLocType.Text.ToString() == g_LogTypeOldDR ))
            {
                if (string.IsNullOrEmpty(txtKnotLog.Text) | string.IsNullOrEmpty(txtKnotLog.Text))
                {
                }
                // ignore - nothing to do
                else if (Information.IsNumeric(txtKnotLog.Text) == false)
                {
                    ErrorMsgBox("KnotLog value must be numeric text string");
                    return false;
                }
            }

            if (CompassInput == true)
            {
                if (string.IsNullOrEmpty(txtCompass.Text) | string.IsNullOrEmpty(txtCompass.Text))
                {
                    if ((cboLocType.Text.ToString() == g_LogTypeFix ))
                    {
                        txtCompass.Text = "0";
                        UpdtRtn.CompassI = 0;
                        // Else
                        // ErrorMsgBox("Compass Course must be entered")
                        // Return False

                    }
                }

                if (Information.IsNumeric(txtCompass.Text) == false)
                {
                    ErrorMsgBox("Compass Course must be numeric between 0 and 360");
                    return false;
                }

                try
                {
                    UpdtRtn.CompassI = Convert.ToInt32(txtCompass.Text);
                    if (UpdtRtn.CompassI < 0 | UpdtRtn.CompassI > 359)
                    {
                        ErrorMsgBox("Compass Course must be numeric between 0 and 360");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    ErrorMsgBox("Compass Course must be numeric between 0 and 360");
                    return false;
                }
            }

            if (TrueInput == true)
            {
                if (Information.IsNumeric(txtCTrue.Text) == false)
                {
                    ErrorMsgBox("True Course must be numeric between 0 and 360");
                    return false;
                }

                try
                {
                    UpdtRtn.CTrueI = Convert.ToInt32(txtCTrue.Text);
                    UpdtRtn.CTrue = txtCTrue.Text.ToString();
                    if (UpdtRtn.CTrueI < 0 | UpdtRtn.CTrueI > 359)
                    {
                        ErrorMsgBox("True Course must be numeric between 0 and 360");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    ErrorMsgBox("True Course must be numeric between 0 and 360");
                    return false;
                }
            }

            if (string.IsNullOrEmpty(txtVar.Text) | string.IsNullOrEmpty(txtVar.Text))
            {
                ErrorMsgBox("Variation must be entered");
                return false;
            }
            else if (Information.IsNumeric(txtVar.Text) == false)
            {
                ErrorMsgBox("Variation must be numeric between 0 and 20");
                return false;
            }
            else
            {
                try
                {
                    UpdtRtn.VarI = Convert.ToDouble(txtVar.Text);
                    // If cboVar.Text = g_LongE Then
                    // UpdtRtn.VarI = -1 * UpdtRtn.VarI
                    // End If
                    UpdtRtn.Var = txtVar.Text.ToString();
                    UpdtRtn.VarEW = cboVar.Text;
                    if (UpdtRtn.VarI < -20 | UpdtRtn.VarI > 20d)
                    {
                        ErrorMsgBox("Var Course must be numeric between -20 (E) and +20 (W)");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    ErrorMsgBox("Var Course must be numeric between 0 and 20");
                    return false;
                }
            }

            if (chkDev.Checked == true & AutoGCRMode == false)
            {
                // if GPS or Plan log type then true route and var were input; use True and Var to compute Magnetic and intepolate Mag to get Dev and then compute Compass
                if ((cboLocType.Text.ToString() == g_LogTypeGPS ) | (cboLocType.Text.ToString() == g_LogTypeOldGPS ) | (cboLocType.Text.ToString() == g_LogTypePlan ) | (cboLocType.Text.ToString() == g_LogTypeOldPlan ))
                {
                    int tempvar = Convert.ToInt32(txtVar.Text.ToString());
                    if ((cboVar.Text.ToString() == CommonGlobals.g_LongE ))
                    {
                        tempvar = -1 * tempvar;
                    }

                    int TempMag = UpdtRtn.CTrueI + tempvar;
                    var rtnrec1 = My.MyProject.Forms.DevForm.DevInterpolateMagnetic(TempMag);
                    UpdtRtn.Dev = Math.Abs(rtnrec1.TblDev).ToString("#0");
                    UpdtRtn.DevEW = rtnrec1.TblDevEW;
                    txtDev.Text = Math.Abs(rtnrec1.TblDev).ToString("#0");
                    if ((rtnrec1.TblDevEW ) == (CommonGlobals.g_LongW ))
                    {
                        cboDev.SelectedIndex = 0;
                    }
                    else
                    {
                        cboDev.SelectedIndex = 1;
                    }

                    UpdtRtn.Compass = (TempMag + rtnrec1.TblDev).ToString("000");
                    UpdtRtn.CompassI = TempMag + rtnrec1.TblDev;
                    txtCompass.Text = UpdtRtn.Compass;
                }

                // if compass route was input then interpolate compass heading to get Dev and calculate True using Dev and Var
                else if ((UpdtRtn.LogType ) == (g_LogTypeDR ) | (UpdtRtn.LogType ) == (g_LogTypeDRAdv ) | (UpdtRtn.LogType ) == (g_LogTypeOldDR ))
                {
                    var rtnrec = My.MyProject.Forms.DevForm.DevInterpolateCompass(Convert.ToInt32(txtCompass.Text.ToString()));
                    UpdtRtn.Dev = Math.Abs(rtnrec.TblDev).ToString("#0");
                    UpdtRtn.DevEW = rtnrec.TblDevEW;
                    txtDev.Text = Math.Abs(rtnrec.TblDev).ToString("#0");
                    if ((rtnrec.TblDevEW ) == (CommonGlobals.g_LongW ))
                    {
                        cboDev.SelectedIndex = 0;
                    }
                    else
                    {
                        cboDev.SelectedIndex = 1;
                    }

                    int tempvar = Convert.ToInt32(txtVar.Text.ToString());
                    if ((cboVar.Text.ToString() == CommonGlobals.g_LongW ))
                    {
                        tempvar = -1 * tempvar;
                    }

                    UpdtRtn.CTrue = (UpdtRtn.CompassI + rtnrec.TblDev + tempvar).ToString("000");
                    UpdtRtn.CTrueI = UpdtRtn.CompassI + rtnrec.TblDev + tempvar;
                    txtCTrue.Text = UpdtRtn.CTrue;
                }
            }

            // now edit Dev field - if Dev check box is checked then the previous code has taken care of Dev field - only do this code if Dev check box is unchecked
            if (chkDev.Checked == false)
            {
                if (string.IsNullOrEmpty(txtDev.Text) | string.IsNullOrEmpty(txtDev.Text))
                {
                    // 'txtDev.Text = 0
                    // UpdtRtn.DevI = 0
                    ErrorMsgBox("Deviation must be entered");
                    return false;
                }
                else if (Information.IsNumeric(txtDev.Text) == false)
                {
                    ErrorMsgBox("Deviation must be numeric between 0 and 20");
                    return false;
                }
                else
                {
                    try
                    {
                        UpdtRtn.DevI = Convert.ToDouble(txtDev.Text);
                        UpdtRtn.Dev = txtDev.Text.ToString();
                        UpdtRtn.DevEW = cboDev.Text.ToString();
                        if (UpdtRtn.DevI < 0d | UpdtRtn.DevI > 20d)
                        {
                            ErrorMsgBox("Dev Course must be numeric between 0 and 20");
                            return false;
                        }
                    }
                    catch (Exception ex)
                    {
                        ErrorMsgBox("Dev Course must be numeric between 0 and 20");
                        return false;
                    }
                }
            }

            if ((cboLocType.Text.ToString() != g_LogTypePlan ) & chkDev.Checked == false) // must be  DR track or GPS track log type and Dev check box is not checked
            {
                if ((cboLocType.Text.ToString() == g_LogTypeDR ) | (cboLocType.Text.ToString() == g_LogTypeOldDR ) | (UpdtRtn.LogType ) == (g_LogTypeDRAdv ))
                {
                    if ((cboVar.Text.ToString() == CommonGlobals.g_LongW ))
                    {
                        UpdtRtn.VarI = -UpdtRtn.VarI;
                    }

                    if ((cboDev.Text.ToString() == CommonGlobals.g_LongW ))
                    {
                        UpdtRtn.DevI = -UpdtRtn.DevI;
                    }

                    UpdtRtn.CTrueI = (int)(UpdtRtn.CompassI + UpdtRtn.VarI + UpdtRtn.DevI);
                    txtCTrue.Text = UpdtRtn.CTrueI.ToString("000");
                    UpdtRtn.CTrue = UpdtRtn.CTrueI.ToString("000");
                }

                if ((cboLocType.Text.ToString() == g_LogTypeGPS ) | (cboLocType.Text.ToString() == g_LogTypeOldGPS ) | (cboLocType.Text.ToString() == g_LogTypePlan ) | (cboLocType.Text.ToString() == g_LogTypeOldPlan ))
                {
                    if ((cboVar.Text.ToString() == CommonGlobals.g_LongE ))
                    {
                        UpdtRtn.VarI = -UpdtRtn.VarI;
                    }

                    if ((cboDev.Text.ToString() == CommonGlobals.g_LongE ))
                    {
                        UpdtRtn.DevI = -UpdtRtn.DevI;
                    }

                    UpdtRtn.CompassI = (int)(Convert.ToInt32(txtCTrue.Text.ToString()) + UpdtRtn.VarI + UpdtRtn.DevI);
                    txtCompass.Text = UpdtRtn.CompassI.ToString("000");
                    UpdtRtn.Compass = UpdtRtn.CompassI.ToString("000");
                }
            }

            if (((cboLocType.Text.ToString() == g_LogTypePlan ) | (cboLocType.Text.ToString() == g_LogTypeOldPlan )) & chkDev.Checked == false)
            {
                if ((cboVar.Text.ToString() == CommonGlobals.g_LongE ))
                {
                    UpdtRtn.VarI = -UpdtRtn.VarI;
                }

                if ((cboDev.Text.ToString() == CommonGlobals.g_LongE ))
                {
                    UpdtRtn.DevI = -UpdtRtn.DevI;
                }

                UpdtRtn.CompassI = (int)(Convert.ToInt32(txtCTrue.Text.ToString()) + UpdtRtn.VarI + UpdtRtn.DevI);
                txtCompass.Text = UpdtRtn.CompassI.ToString("000");
                UpdtRtn.Compass = UpdtRtn.CompassI.ToString("000");
                // as insurance move deviation  to text field
                txtDev.Text = UpdtRtn.Dev;
                if ((UpdtRtn.DevEW  == CommonGlobals.g_LongW ))
                {
                    cboDev.SelectedIndex = 0;
                }
                else
                {
                    cboDev.SelectedIndex = 1;
                }
            }

            if ((cboLocType.Text.ToString() == g_LogTypeFix ) | (cboLocType.Text.ToString() == g_LogTypeWayPoint ))
            {
                // nothing to do
                txtSpeed.Text = "";
                UpdtRtn.SpeedI = 0d;
            }
            else
            {
                if (string.IsNullOrEmpty(txtSpeed.Text) | string.IsNullOrEmpty(txtSpeed.Text))
                {
                    ErrorMsgBox("Speed must be entered");
                    return false;
                }

                if (Information.IsNumeric(txtSpeed.Text) == false)
                {
                    ErrorMsgBox("Speed must be numeric between 0 and 99");
                    return false;
                }

                try
                {
                    UpdtRtn.SpeedI = Convert.ToDouble(txtSpeed.Text);
                    if (UpdtRtn.SpeedI < 0d | UpdtRtn.SpeedI > 99d)
                    {
                        ErrorMsgBox("Speed must be numeric between 0 and 99");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    ErrorMsgBox("Speed must be numeric between 0 and 99");
                    return false;
                }
            }

            return true;
            return default;
        }

        private bool EditPlanFields()
        {

            // If AddNewMode = True And AutoGCRMode = False Then
            // If cboAdvType.SelectedIndex = 0 Then
            // If cboAdvHrs.Value <> 0 Or cboAdvMin.Value <> 0 Then
            // FindInstallAdvancedPlan()
            // ' turn off Hr/Min fields for advancing time
            // cboAdvType.Visible = False
            // lblAdvNm.Visible = False
            // cboAdvNm.Visible = False
            // lblAdvHrMin.Visible = False
            // cboAdvHrs.Visible = False
            // cboAdvMin.Visible = False
            // grpAdvInfo.Visible = False
            // cboAdvNm.Value = 0
            // cboAdvHrs.Value = 0
            // cboAdvMin.Value = 0
            // End If
            // End If
            // If cboAdvType.SelectedIndex = 1 Then
            // If cboAdvNm.Value <> 0.0 Then
            // FindInstallAdvancedPlan()
            // ' turn off Hr/Min fields for advancing time
            // cboAdvType.Visible = False
            // lblAdvNm.Visible = False
            // cboAdvNm.Visible = False
            // lblAdvHrMin.Visible = False
            // cboAdvHrs.Visible = False
            // cboAdvMin.Visible = False
            // grpAdvInfo.Visible = False
            // cboAdvNm.Value = 0
            // cboAdvHrs.Value = 0
            // cboAdvMin.Value = 0
            // End If
            // End If

            // End If

            if (string.IsNullOrEmpty(txtDestLDeg.Text) | string.IsNullOrEmpty(txtDestLDeg.Text))
            {
                ErrorMsgBox("For Plan Entry, Destination Latitude Degrees must be entered");
                return false;
            }

            if (Information.IsNumeric(txtDestLDeg.Text) == false)
            {
                ErrorMsgBox("For Plan Entry, Destination Latitude Degrees must be numeric between 0 and 89");
                return false;
            }

            try
            {
                UpdtRtn.DestLDegI = Convert.ToInt32(txtDestLDeg.Text);
                if (UpdtRtn.DestLDegI < 0 | UpdtRtn.DestLDegI > 89)
                {
                    ErrorMsgBox("For Plan Entry, Destination Latitude Degrees must be numeric between 0 and 89");
                    return false;
                }
            }
            catch (Exception ex)
            {
                ErrorMsgBox("For Plan Entry, DestinationLatitude Degrees must be numeric between 0 and 89");
                return false;
            }

            if (string.IsNullOrEmpty(txtDestLMin.Text) | string.IsNullOrEmpty(txtDestLMin.Text))
            {
                ErrorMsgBox("For Plan Entry, Latitude Minutes must be entered");
                return false;
            }

            if (Information.IsNumeric(txtDestLMin.Text) == false)
            {
                ErrorMsgBox("For Plan Entry, Latitude Minutes be numeric between 0 and 59.9");
                return false;
            }

            try
            {
                UpdtRtn.DestLMinI = Convert.ToDouble(txtDestLMin.Text);
                UpdtRtn.DestLNS = cboDestL.Text;
                if ((UpdtRtn.DestLNS ) == (CommonGlobals.g_LatN ))
                {
                    UpdtRtn.DestLatDouble = UpdtRtn.DestLDegI + UpdtRtn.DestLMinI / 60d;
                }
                else
                {
                    UpdtRtn.DestLatDouble = -1 * (UpdtRtn.DestLDegI + UpdtRtn.DestLMinI / 60d);
                }

                if (UpdtRtn.DestLMinI < 0d | UpdtRtn.DestLMinI > 59.9d)
                {
                    ErrorMsgBox("For Plan Entry, Latitude Minutes must be numeric between 0 and 59.9");
                    return false;
                }
            }
            catch (Exception ex)
            {
                ErrorMsgBox("For Plan Entry, Latitude Minutes must be numeric between 0 and 59.9");
                return false;
            }

            if (string.IsNullOrEmpty(txtDestLoDeg.Text) | string.IsNullOrEmpty(txtDestLDeg.Text))
            {
                ErrorMsgBox("For Plan Entry, Longitude Degrees must be entered");
                return false;
            }

            if (Information.IsNumeric(txtDestLoDeg.Text) == false)
            {
                ErrorMsgBox("For Plan Entry, Longitude Degrees must be numeric between 0 and 89");
                return false;
            }

            try
            {
                UpdtRtn.DestLoDegI = Convert.ToInt32(txtDestLoDeg.Text);
                if (UpdtRtn.DestLoDegI < 0 | UpdtRtn.DestLoDegI > 180)
                {
                    ErrorMsgBox("For Plan Entry, Longitude Degrees must be numeric between 0 and 180");
                    return false;
                }
            }
            catch (Exception ex)
            {
                ErrorMsgBox("For Plan Entry, Longitude Degrees must be numeric between 0 and 180");
                return false;
            }

            if (string.IsNullOrEmpty(txtDestLoMin.Text) | string.IsNullOrEmpty(txtDestLoMin.Text))
            {
                ErrorMsgBox("For Plan Entry, Longitude Minutes must be entered");
                return false;
            }

            if (Information.IsNumeric(txtDestLoMin.Text) == false)
            {
                ErrorMsgBox("For Plan Entry, Longitude Minutes be numeric between 0 and 59.9");
                return false;
            }

            try
            {
                UpdtRtn.DestLoMinI = Convert.ToDouble(txtDestLoMin.Text);
                UpdtRtn.DestLoEW = cboDestLo.Text;
                if ((UpdtRtn.DestLoEW ) == (CommonGlobals.g_LongW ))
                {
                    UpdtRtn.DestLongDouble = -1 * (UpdtRtn.DestLoDegI + UpdtRtn.DestLoMinI / 60.0d);
                }
                else
                {
                    UpdtRtn.DestLongDouble = UpdtRtn.DestLoDegI + UpdtRtn.DestLoMinI / 60.0d;
                }
                // If the destination Longitude is 0 degrees 0 minutes then the minutes must reset to 1 minute for other math to work elsewhere
                if (UpdtRtn.DestLoDegI == 0 & UpdtRtn.DestLoMinI == 0d)
                {
                    UpdtRtn.DestLoMinI = 1d;
                }

                if (UpdtRtn.DestLoMinI < 0d | UpdtRtn.DestLoMinI > 59.9d)
                {
                    ErrorMsgBox("For Plan Entry, Longitude Minutes must be numeric between 0 and 59.9");
                    return false;
                }
            }
            catch (Exception ex)
            {
                ErrorMsgBox("For Plan Entry, Longitude Minutes must be numeric between 0 and 59.9");
                return false;
            }

            // the evaluation of these plan entry fields are done here because the evaluateDB routine works on pairs of entries together. A plan entry has all its data in one entry
            // now create a GeoCoordinate object for each set of Lat & Long for subsequent function calls
            var Loc1 = new System.Device.Location.GeoCoordinate(UpdtRtn.LatDouble, UpdtRtn.LongDouble);
            var Loc2 = new System.Device.Location.GeoCoordinate(UpdtRtn.DestLatDouble, UpdtRtn.DestLongDouble);
            // Get the distance from origin Lat/Long to destination Lat/Long and format results into text display field
            double DestDist = GetDistance(UpdtRtn.LatDouble, UpdtRtn.LongDouble, UpdtRtn.DestLatDouble, UpdtRtn.DestLongDouble);
            txtDestDist.Text = DestDist.ToString("##0.0") + "nm";
            // Get the true heading from origin Lat/Long to destination Lat/Long and format display text field
            int TempHeading = (int)Conversion.Int(GetHeading(UpdtRtn.LatDouble, UpdtRtn.LongDouble, UpdtRtn.DestLatDouble, UpdtRtn.DestLongDouble));
            txtDestTrue.Text = TempHeading.ToString("##0") + '°';
            // no matter what was entered the true bearing to steer is the calculated one - so it is installed along with the compass bearing recalculated.
            txtCTrue.Text = TempHeading.ToString("##0");    // txtDestTrue.Text.Trim(Chr(176))
            UpdtRtn.CTrue = TempHeading.ToString("##0"); // txtDestTrue.Text.Trim(Chr(176))
            UpdtRtn.CTrueI = TempHeading; // Convert.ToInt32(txtDestTrue.Text.Trim(Chr(176)))
            UpdtRtn.CompassI = (int)(UpdtRtn.CTrueI + UpdtRtn.VarI + UpdtRtn.DevI);
            txtCompass.Text = UpdtRtn.CompassI.ToString("000");
            // Using the calculated distance to destination, get the elapsed time to destination using declared speed and starting date/time
            var DestElapsed = Calc60DSTElapsed(DTDateZoneTime.Value, Convert.ToDouble(txtSpeed.Text), DestDist);
            if (DestElapsed.Days == 0)
            {
                txtDestElapsed.Text = DestElapsed.ToString(@"hh\:mm\:ss");
            }
            else
            {
                txtDestElapsed.Text = DestElapsed.ToString(@"d\d\y\ hh\:mm\:ss");
            }

            DestEstArrival = DTDateZoneTime.Value.AddMinutes(DestElapsed.TotalMinutes);

            // Is the Celestial Tools Sailings form open
            if (System.Windows.Forms.Application.OpenForms.OfType<FormSailings>().Any())
            {
                // check if the Sailings form has a Great Circle Route ready generated and we must be in AddNew mode and not in generating a GCR in this module
                if (My.MyProject.Forms.FormSailings.GCRAvailable == true & chkImportGCR.Checked == true & AddNewMode == true & AutoGCRMode == false)
                {
                    var MsgBack = Interaction.MsgBox("Great Circle Route Plan availble to load from Sailings form. Load? - Yes or No", MsgBoxStyle.YesNo, "Save Updated Data");
                    if (MsgBack == MsgBoxResult.Yes)
                    {
                        GCRArray = new GCRRec[Information.UBound(My.MyProject.Forms.FormSailings.GCRArray) + 1];
                        for (int i = 0, loopTo = Information.UBound(My.MyProject.Forms.FormSailings.GCRArray); i <= loopTo; i++)
                        {
                            GCRArray[i].LongStr = My.MyProject.Forms.FormSailings.GCRArray[i].LongStr;
                            GCRArray[i].LatStr = My.MyProject.Forms.FormSailings.GCRArray[i].LatStr;
                            GCRArray[i].CTrue = My.MyProject.Forms.FormSailings.GCRArray[i].CTrue;
                            GCRArray[i].GCRDist = My.MyProject.Forms.FormSailings.GCRArray[i].GCRDist;
                        }

                        // Process the captured GCR array into new Plan entries 
                        ProcessGCRArray();
                        // Clean out the capture GCR array in case this is done back to back 
                        GCRArray = new GCRRec[1];
                        My.MyProject.Forms.FormSailings.GCRArray = new FormSailings.GCRRec[1];
                        My.MyProject.Forms.FormSailings.GCRAvailable = false;
                        chkImportGCR.Checked = false;
                        chkImportGCR.Visible = false;
                        return true;
                    }
                }
            }

            // Is the Distance of this Plan Entry > 500 nm and are we doing the Add of New Entry and is this a manual entry not an auto generated entry - see ProcessGCRArray() below
            if (DestDist > GCRThreshhold & AddNewMode == true & AutoGCRMode == false)
            {
                if (chkPlanGCR.Checked == true)
                {
                    var MsgBack = Interaction.MsgBox("Use Sailings GCR Form to create Great Circle Route = Yes or Use Rhumb Line of two Plan Entries = No", MsgBoxStyle.YesNo, "Use Sailings Greate Circle Route Form?");
                    if (MsgBack == MsgBoxResult.Yes)
                    {
                        // Pop up the Sailings form, fill in the start Lat/Long for this entry and the destination lat/long - click calculate button and then click the GCR cmdPoints button
                        My.MyProject.Forms.FormSailings.Show();
                        My.MyProject.Forms.FormSailings.txtL1Deg.Text = txtLDeg.Text;
                        My.MyProject.Forms.FormSailings.txtL1Min.Text = txtLMin.Text;
                        My.MyProject.Forms.FormSailings.cboL1.Text = cboL.Text;
                        My.MyProject.Forms.FormSailings.txtLo1Deg.Text = txtLoDeg.Text;
                        My.MyProject.Forms.FormSailings.txtLo1Min.Text = txtLoMin.Text;
                        My.MyProject.Forms.FormSailings.cboLo1.Text = cboLo.Text;
                        My.MyProject.Forms.FormSailings.txtL2Deg.Text = txtDestLDeg.Text;
                        My.MyProject.Forms.FormSailings.txtL2Min.Text = txtDestLMin.Text;
                        My.MyProject.Forms.FormSailings.cboL2.Text = cboDestL.Text;
                        My.MyProject.Forms.FormSailings.txtLo2Deg.Text = txtDestLoDeg.Text;
                        My.MyProject.Forms.FormSailings.txtLo2Min.Text = txtDestLoMin.Text;
                        My.MyProject.Forms.FormSailings.cboLo2.Text = cboDestLo.Text;
                        My.MyProject.Forms.FormSailings.optGreatCircle.Checked = true;
                        My.MyProject.Forms.FormSailings.cmdCalculate.PerformClick();
                        My.MyProject.Forms.FormSailings.cmdPoints.PerformClick();

                        // now the frmPointsOnGCR form will display - on it will be a datagridview DGGCR with each Long / Lat / True course / Distance in nm - capture them in local array
                        GCRArray = new GCRRec[My.MyProject.Forms.frmPointsOnGCR.DGGCR.Rows.Count - 2 + 1];
                        for (int i = 0, loopTo1 = My.MyProject.Forms.frmPointsOnGCR.DGGCR.Rows.Count - 2; i <= loopTo1; i++)
                        {
                            GCRArray[i].LongStr = Conversions.ToString(My.MyProject.Forms.frmPointsOnGCR.DGGCR.Rows[i].Cells[0].Value);
                            GCRArray[i].LatStr = Conversions.ToString(My.MyProject.Forms.frmPointsOnGCR.DGGCR.Rows[i].Cells[1].Value);
                            GCRArray[i].CTrue = Conversions.ToString(My.MyProject.Forms.frmPointsOnGCR.DGGCR.Rows[i].Cells[2].Value);
                            GCRArray[i].GCRDist = Conversions.ToString(My.MyProject.Forms.frmPointsOnGCR.DGGCR.Rows[i].Cells[3].Value);
                        }

                        // now close the GCR form and then close the Sailings form
                        My.MyProject.Forms.frmPointsOnGCR.ExitBtn.PerformClick();
                        My.MyProject.Forms.FormSailings.ExitBtn.PerformClick();

                        // Process the captured GCR array into new Plan entries 
                        ProcessGCRArray();
                        // Clean out the capture GCR array in case this is done back to back 
                        GCRArray = new GCRRec[1];
                        return true;
                    }
                }
            }

            int ZDLoc1 = (int)Math.Round(Loc1.Longitude / 15d, 0, MidpointRounding.AwayFromZero);
            int ZDLoc2 = (int)Math.Round(Loc2.Longitude / 15d, 0, MidpointRounding.AwayFromZero);
            if ((cboDestLo.Text.ToString() == CommonGlobals.g_LongE ))
            {
                txtDestZD.Text = "+" + Math.Abs(ZDLoc2).ToString();
            }
            else
            {
                txtDestZD.Text = "-" + Math.Abs(ZDLoc2).ToString();
            }

            if (ZDLoc1 != ZDLoc2) // Origin to Destination ZD are the not the same then we have passed into next time zone - use ZTInfo to plan arrival time
            {
                if (AutoGCRMode == false)
                {
                    var MsgBack = Interaction.MsgBox("Destination Longitude passes into new Time Zone. Do you want to use ZTInfo form to plan arrival time? Yes = Use ZTInfo OR No = Use Default Info", MsgBoxStyle.YesNo, "Calculate Destination ZD Info?");
                    if (MsgBack == MsgBoxResult.Yes)
                    {
                        My.MyProject.Forms.ZTInfo.InvokedbyDeckLog = true;
                        DestDTUpdatedbyZTInfo = false;
                        My.MyProject.Forms.ZTInfo.txtLoDegA.Text = txtLoDeg.Text;
                        My.MyProject.Forms.ZTInfo.txtLoMinA.Text = txtLoMin.Text;
                        My.MyProject.Forms.ZTInfo.cboLoA.Text = cboLo.Text;
                        My.MyProject.Forms.ZTInfo.DTLocA.Value = DTDateZoneTime.Value;
                        My.MyProject.Forms.ZTInfo.txtLoDegB.Text = txtDestLoDeg.Text;
                        My.MyProject.Forms.ZTInfo.txtLoMinB.Text = txtDestLoMin.Text;
                        My.MyProject.Forms.ZTInfo.cboLoB.Text = CommonGlobals.g_LongE;
                        if (Loc2.Longitude < 0d)
                        {
                            My.MyProject.Forms.ZTInfo.cboLoB.Text = CommonGlobals.g_LongW;
                        }

                        My.MyProject.Forms.ZTInfo.DT1Days.Value = 0m;
                        My.MyProject.Forms.ZTInfo.DT1Hours.Value = Convert.ToInt32(cboAdvHrs.Value.ToString());
                        My.MyProject.Forms.ZTInfo.DT1Minutes.Value = Convert.ToInt32(cboAdvMin.Value.ToString());
                        DestDTUpdatedbyZTInfo = false;
                        My.MyProject.Forms.ZTInfo.Show();
                        My.MyProject.Forms.ZTInfo.cboLocAZD.SelectedIndex = 0;
                        My.MyProject.Forms.ZTInfo.cboLocBZD.SelectedIndex = 0;
                        while (DestDTUpdatedbyZTInfo == false)
                        {
                            Thread.Sleep(500); // sleep for 500 milliseconds or 1/2 second
                            System.Windows.Forms.Application.DoEvents();
                        }

                        My.MyProject.Forms.ZTInfo.SendToBack();
                        if (My.MyProject.Forms.ZTInfo.InvokedbyDeckLog == true)
                        {
                            if (DestDTUpdatedbyZTInfo == true)
                            {
                                DestEstArrival = DestDTfromZTInfo;
                                DestDTUpdatedbyZTInfo = false;
                                My.MyProject.Forms.ZTInfo.InvokedbyDeckLog = false;
                            }
                            else
                            {
                                SetDestinationZoneTime(ZDLoc1, ZDLoc2, DestElapsed.TotalMinutes);
                                My.MyProject.Forms.ZTInfo.InvokedbyDeckLog = false;
                                DestDTUpdatedbyZTInfo = false;
                            }
                        }
                        else
                        {
                            SetDestinationZoneTime(ZDLoc1, ZDLoc2, DestElapsed.TotalMinutes);
                            My.MyProject.Forms.ZTInfo.InvokedbyDeckLog = false;
                            DestDTUpdatedbyZTInfo = false;
                        }
                    }
                    else
                    {
                        SetDestinationZoneTime(ZDLoc1, ZDLoc2, DestElapsed.TotalMinutes);
                        My.MyProject.Forms.ZTInfo.InvokedbyDeckLog = false;
                        DestDTUpdatedbyZTInfo = false;
                    }

                    txtRemarks.Text = "Estimated Arrival Time for Plan Log Entry:" + DestEstArrival.ToString(DTFormatString); // ("MM/dd/yyyy HH:mm:ss")
                    txtEstArrival.Text = DestEstArrival.ToString(DTFormatString); // ("MM/dd/yyyy HH:mm:ss")
                }
                else
                {
                    My.MyProject.Forms.ZTInfo.InvokedbyDeckLog = true;
                    DestDTUpdatedbyZTInfo = false;
                    My.MyProject.Forms.ZTInfo.txtLoDegA.Text = txtLoDeg.Text;
                    My.MyProject.Forms.ZTInfo.txtLoMinA.Text = txtLoMin.Text;
                    My.MyProject.Forms.ZTInfo.cboLoA.Text = cboLo.Text;
                    My.MyProject.Forms.ZTInfo.DTLocA.Value = DTDateZoneTime.Value;
                    My.MyProject.Forms.ZTInfo.txtLoDegB.Text = txtDestLoDeg.Text;
                    My.MyProject.Forms.ZTInfo.txtLoMinB.Text = txtDestLoMin.Text;
                    My.MyProject.Forms.ZTInfo.cboLoB.Text = CommonGlobals.g_LongE;
                    if (Loc2.Longitude < 0d)
                    {
                        My.MyProject.Forms.ZTInfo.cboLoB.Text = CommonGlobals.g_LongW;
                    }

                    My.MyProject.Forms.ZTInfo.DT1Days.Value = 0m;
                    My.MyProject.Forms.ZTInfo.DT1Hours.Value = Convert.ToInt32(cboAdvHrs.Value.ToString());
                    My.MyProject.Forms.ZTInfo.DT1Minutes.Value = Convert.ToInt32(cboAdvMin.Value.ToString());
                    DestDTUpdatedbyZTInfo = false;
                    My.MyProject.Forms.ZTInfo.Show();
                    My.MyProject.Forms.ZTInfo.cboLocAZD.SelectedIndex = 0;
                    My.MyProject.Forms.ZTInfo.cboLocBZD.SelectedIndex = 0;
                    while (DestDTUpdatedbyZTInfo == false)
                    {
                        Thread.Sleep(500); // sleep for 500 milliseconds or 1/2 second
                        System.Windows.Forms.Application.DoEvents();
                    }

                    My.MyProject.Forms.ZTInfo.SendToBack();
                    if (My.MyProject.Forms.ZTInfo.InvokedbyDeckLog == true)
                    {
                        if (DestDTUpdatedbyZTInfo == true)
                        {
                            DestEstArrival = DestDTfromZTInfo;
                            DestDTUpdatedbyZTInfo = false;
                            My.MyProject.Forms.ZTInfo.InvokedbyDeckLog = false;
                        }
                        else
                        {
                            SetDestinationZoneTime(ZDLoc1, ZDLoc2, DestElapsed.TotalMinutes);
                            My.MyProject.Forms.ZTInfo.InvokedbyDeckLog = false;
                            DestDTUpdatedbyZTInfo = false;
                        }
                    }
                    else
                    {
                        SetDestinationZoneTime(ZDLoc1, ZDLoc2, DestElapsed.TotalMinutes);
                        My.MyProject.Forms.ZTInfo.InvokedbyDeckLog = false;
                        DestDTUpdatedbyZTInfo = false;
                    }

                    My.MyProject.Forms.ZTInfo.ExitBtn.PerformClick();
                    SetDestinationZoneTime(ZDLoc1, ZDLoc2, DestElapsed.TotalMinutes);
                    txtRemarks.Text = "Entry #" + RcdCount.ToString("##0") + " on generated Great Circle Route. Estimated Arrival Time for Plan Log Entry:" + DestEstArrival.ToString(DTFormatString); // ("MM/dd/yyyy HH:mm:ss")
                    txtEstArrival.Text = DestEstArrival.ToString(DTFormatString); // ("MM/dd/yyyy HH:mm:ss")
                                                                                  // now do autotransfer of plan dest info calc'd for auto GCR entry to entry fields
                    DTDateZoneTime.Value = DestEstArrival;
                }
            }
            else if (AutoGCRMode == true)
            {
                DestEstArrival = DTDateZoneTime.Value.AddMinutes(DestElapsed.TotalMinutes);
                txtRemarks.Text = "Entry #" + RcdCount.ToString("##0") + " on generated Great Circle Route. Estimated Arrival Time for Plan Log Entry:" + DestEstArrival.ToString(DTFormatString); // ("MM/dd/yyyy HH:mm:ss")
                txtEstArrival.Text = DestEstArrival.ToString(DTFormatString); // ("MM/dd/yyyy HH:mm:ss")
                // now do autotransfer of plan dest info calc'd for auto GCR entry to entry fields
                DTDateZoneTime.Value = DestEstArrival;
            }
            else
            {
                SetDestinationZoneTime(ZDLoc1, ZDLoc2, DestElapsed.TotalMinutes);
                My.MyProject.Forms.ZTInfo.InvokedbyDeckLog = false;
                DestDTUpdatedbyZTInfo = false;
                txtRemarks.Text = "Estimated Arrival Time for Plan Log Entry:" + DestEstArrival.ToString(DTFormatString); // ("MM/dd/yyyy HH:mm:ss")
                txtEstArrival.Text = DestEstArrival.ToString(DTFormatString);
            } // ("MM/dd/yyyy HH:mm:ss")

            return true;
        }

        private void SetDestinationZoneTime(int ZDLoc1, int ZDLoc2, double TotMin)
        {
            int IncrHr = ZDLoc2 - ZDLoc1;
            if (Math.Sign(ZDLoc1) != Math.Sign(ZDLoc2)) // we have crossed the IDL
            {
                if (ZDLoc1 < 0 & ZDLoc2 > 0) // moving from West (ZD negative) to East (ZD positive)
                {
                    IncrHr = -1 * ZDLoc1 - ZDLoc2;
                }

                if (ZDLoc1 > 0 & ZDLoc2 < 0) // moving from East (ZD positive) to West (ZD negative)
                {
                    IncrHr = -1 * ZDLoc1 + ZDLoc2;
                }
            }
            // Set the destination time to the origin DTDate plus elapsed total minutes - then add or subtract time zone difference of 1 hour
            DestEstArrival = DTDateZoneTime.Value.AddMinutes(TotMin);
            DestEstArrival = DestEstArrival.AddHours(IncrHr);
            return;
        }

        private DateTime ReturnDestinationZoneTime(int ZDLoc1, int ZDLoc2, double TotMin, DateTime TimeIn)
        {
            int IncrHr = 0;
            var RtnDatetime = TimeIn;
            if (Math.Sign(ZDLoc1) != Math.Sign(ZDLoc2)) // we have crossed the IDL
            {
                if (ZDLoc1 < 0 & ZDLoc2 > 0) // moving from West (ZD negative) to East (ZD positive)
                {
                    IncrHr = -1 * ZDLoc1 - ZDLoc2;
                }

                if (ZDLoc1 > 0 & ZDLoc2 < 0) // moving from East (ZD positive) to West (ZD negative)
                {
                    IncrHr = -1 * ZDLoc1 + ZDLoc2;
                }
            }
            else
            {
                IncrHr = ZDLoc2 - ZDLoc1;
            }
            // Set the destination time to the origin DTDate plus elapsed total minutes - then add or subtract time zone difference of 1 hour
            RtnDatetime = DTDateZoneTime.Value.AddMinutes(TotMin);
            RtnDatetime = RtnDatetime.AddHours(IncrHr);
            return RtnDatetime;
            return default;
        }

        public void ResetSomeScreenFields()
        {
            // txtVessel.Clear()
            // txtNavigator.Clear()
            // txtFrom.Clear()
            // txtTo.Clear()
            // DTDateZoneTime.Value = Now
            // txtCompass.Clear()
            // txtVar.Clear()
            // txtDev.Clear()
            // txtCTrue.Clear()
            // txtSpeed.Clear()
            // txtLDeg.Clear()
            // txtLMin.Clear()
            // txtLoDeg.Clear()
            // txtLoMin.Clear()
            txtWeather.Clear();
            txtRemarks.Clear();

            // txtWind.Clear()
            // cboWindDir.Text = ""
            // txtSeas.Clear()

            // cboLocType.Text = ""
            // cboL.SelectedIndex = 0
            // cboLo.SelectedIndex = 0
            // cboVar.SelectedIndex = 0
            // cboDev.SelectedIndex = 0
            // chkDev.Checked = False
            // clear and make invisible the advance fields and the plan dest fields
            txtDestLDeg.Clear();
            txtDestLMin.Clear();
            txtDestLoDeg.Clear();
            txtDestLoMin.Clear();
            txtDestTrue.Clear();
            txtDestDist.Clear();
            txtDestElapsed.Clear();
            txtEstArrival.Clear();
            lblAdvHrMin.Visible = false;
            cboAdvHrs.Visible = false;
            cboAdvMin.Visible = false;
            lblAdvNm.Visible = false;
            cboAdvNm.Visible = false;
            cboAdvType.Visible = false;
            grpAdvInfo.Visible = false;
            grpbxPlan.Visible = false;
            DTChanged = false;
            DRAdvanceMode = false;
            // UpdtRow = Nothing
            AddNewMode = false;
            HideCommonButtons();
            return;
        }

        private void ResetScreenFieldsforPlan()
        {
            // make visible plan dest fields and enable 
            grpbxPlan.Visible = true;
            grpbxPlan.BackColor = PlanBackColor;
            grpbxPlan.ForeColor = PlanForeColor;
            chkPlanGCR.Visible = true;
            txtSpeed.Enabled = true;
            txtSpeed.BackColor = Color.Yellow;
            txtDev.Enabled = true;
            txtDev.BackColor = Color.Yellow;
            cboDev.Enabled = true;
            chkDev.Visible = true;
            txtCompass.Enabled = false;
            txtCompass.BackColor = Color.Aqua;
            txtCTrue.Enabled = true;
            txtCTrue.BackColor = Color.Yellow;
            // txtCTrue.Text = ""
            txtDev.Enabled = true;
            txtVar.Enabled = true;
            txtVar.BackColor = Color.Yellow;
            cboVar.Enabled = true;
            lblKnotLog.Visible = false;
            txtKnotLog.Visible = false;
            txtKnotLog.BackColor = Color.Aqua;
            cboAdvHrs.Value = 0m;
            cboAdvMin.Value = 0m;
            cboAdvNm.Value = 0.0m;
            cboAdvType.Visible = false;
            lblAdvNm.Visible = false;
            cboAdvNm.Visible = false;
            lblAdvHrMin.Visible = false;
            cboAdvHrs.Visible = false;
            cboAdvMin.Visible = false;
            grpAdvInfo.Visible = false;
            DRAdvanceMode = false;
            return;
        }

        private void ResetScreenFieldsforGPS()
        {
            grpbxPlan.Visible = false;
            grpWeather.Visible = true;
            chkPlanGCR.Visible = false;
            txtSpeed.Enabled = true;
            txtSpeed.BackColor = Color.Yellow;
            txtDev.Enabled = true;
            txtDev.BackColor = Color.Yellow;
            cboDev.Enabled = true;
            chkDev.Visible = true;
            txtCompass.Clear();
            txtCompass.Enabled = false;
            txtCompass.BackColor = Color.Aqua;
            txtCTrue.Enabled = true;
            // txtCTrue.Text = 0
            txtCTrue.BackColor = Color.Yellow;
            txtVar.Enabled = true;
            txtVar.BackColor = Color.Yellow;
            cboVar.Enabled = true;
            cboAdvHrs.Value = 0m;
            cboAdvMin.Value = 0m;
            cboAdvNm.Value = 0.0m;
            cboAdvType.Visible = false;
            lblAdvNm.Visible = false;
            cboAdvNm.Visible = false;
            lblAdvHrMin.Visible = false;
            cboAdvHrs.Visible = false;
            cboAdvMin.Visible = false;
            grpAdvInfo.Visible = false;
            DRAdvanceMode = false;
            lblKnotLog.Visible = true;
            txtKnotLog.Visible = true;
            txtKnotLog.BackColor = Color.Yellow;
            return;
        }

        private void ResetScreenFieldsforDRAdvance()
        {
            cboAdvHrs.Value = 0m;
            cboAdvMin.Value = 0m;
            cboAdvNm.Value = 0.0m;
            cboAdvType.Visible = true;
            cboAdvType.Enabled = true;
            lblAdvNm.Visible = true;
            cboAdvNm.Visible = true;
            lblAdvHrMin.Visible = true;
            cboAdvHrs.Visible = true;
            cboAdvMin.Visible = true;
            grpAdvInfo.Visible = true;
            cboAdvType.SelectedIndex = 0;

            // DRAdvanceDGSave = DataGridView1.CurrentCell.RowIndex
            DTAdvDTSave = DTDateZoneTime.Value;
            // the DR Advance processing takes place when the Zone Date/Time field is changed and the subroutine to advance the DR is activated
            // For a DR calc (Advance this DR to future time) 
            btnAddNew.Visible = true;
            btnClearFields.Visible = true;
            btnUpdateExisting.Visible = false;
            btnDeleteSight.Visible = false;
            // make invisible plan dest fields and disable 
            grpbxPlan.Visible = false;
            chkPlanGCR.Visible = false;
            // protect all speed, heading, variation, and deviation fields because we are advancing using them
            txtSpeed.Enabled = true;
            txtSpeed.BackColor = Color.Yellow;
            txtDev.Enabled = true;
            txtDev.BackColor = Color.Yellow;
            cboDev.Enabled = true;
            chkDev.Visible = true;
            txtCompass.Enabled = false;
            txtCompass.BackColor = Color.Aqua;
            txtCTrue.Enabled = false;
            txtCTrue.BackColor = Color.Aqua;
            txtVar.BackColor = Color.Aqua;
            txtVar.Enabled = false;
            txtDev.Enabled = false;
            txtDev.BackColor = Color.Aqua;
            // txtSpeed.Enabled = False
            // txtSpeed.BackColor = Color.Aqua
            lblKnotLog.Visible = true;
            txtKnotLog.Visible = true;
            txtKnotLog.BackColor = Color.Yellow;
            grpWeather.Visible = true;
            return;
        }

        private void ResetScreenFieldsforDR()
        {
            grpWeather.Visible = true;
            cboAdvHrs.Value = 0m;
            cboAdvMin.Value = 0m;
            cboAdvNm.Value = 0.0m;
            cboAdvType.Visible = false;
            lblAdvNm.Visible = false;
            cboAdvNm.Visible = false;
            lblAdvHrMin.Visible = false;
            cboAdvHrs.Visible = false;
            cboAdvMin.Visible = false;
            grpAdvInfo.Visible = false;
            DRAdvanceMode = false;
            // make invisible plan dest fields and disable 
            grpbxPlan.Visible = false;
            chkPlanGCR.Visible = false;
            txtSpeed.Enabled = true;
            txtSpeed.BackColor = Color.Yellow;
            txtDev.Enabled = true;
            txtDev.BackColor = Color.Yellow;
            cboDev.Enabled = true;
            chkDev.Visible = true;
            txtCompass.Enabled = true;
            txtCompass.BackColor = Color.Yellow;
            txtCTrue.Enabled = false;
            txtCTrue.BackColor = Color.Aqua;
            txtCTrue.Clear();
            txtVar.Enabled = true;
            txtVar.BackColor = Color.Yellow;
            cboVar.Enabled = true;
            // cboVar.SelectedIndex = 0
            lblKnotLog.Visible = true;
            txtKnotLog.Visible = true;
            txtKnotLog.BackColor = Color.Yellow;
            return;
        }

        private void ResetScreenFieldsForWPFix()
        {
            txtCompass.Clear();
            txtCompass.Enabled = false;
            txtCompass.BackColor = Color.Aqua;
            txtVar.Clear();
            txtVar.Enabled = false;
            txtVar.BackColor = Color.Aqua;
            cboVar.Enabled = false;
            cboVar.SelectedIndex = 0;
            txtDev.Clear();
            txtDev.Enabled = false;
            txtDev.BackColor = Color.Aqua;
            cboDev.Enabled = false;
            chkDev.Visible = false;
            txtCTrue.Clear();
            txtCTrue.Enabled = false;
            txtCTrue.BackColor = Color.Aqua;
            txtSpeed.Clear();
            txtSpeed.Enabled = false;
            txtSpeed.BackColor = Color.Aqua;
            txtWeather.Clear();
            txtWeather.Enabled = false;
            txtRemarks.Clear();
            txtRemarks.Enabled = false;
            txtWind.Clear();
            cboWindDir.Text = "";
            txtSeas.Clear();
            grpWeather.Visible = false;
            txtDestLDeg.Clear();
            txtDestLMin.Clear();
            txtDestLoDeg.Clear();
            txtDestLoMin.Clear();
            txtDestTrue.Clear();
            txtDestDist.Clear();
            txtDestElapsed.Clear();
            txtEstArrival.Clear();
            cboAdvHrs.Value = 0m;
            cboAdvMin.Value = 0m;
            cboAdvNm.Value = 0.0m;
            lblAdvHrMin.Visible = false;
            cboAdvHrs.Visible = false;
            cboAdvMin.Visible = false;
            lblAdvNm.Visible = false;
            cboAdvNm.Visible = false;
            cboAdvType.Visible = false;
            grpAdvInfo.Visible = false;
            grpbxPlan.Visible = false;
            chkPlanGCR.Visible = false;
            lblKnotLog.Visible = false;
            txtKnotLog.Visible = false;
            txtKnotLog.BackColor = Color.Aqua;
            DTChanged = false;
            DRAdvanceMode = false;
            // UpdtRow = Nothing
            AddNewMode = false;
            // HideCommonButtons()
            return;
        }

        public void ResetAllScreenFields()
        {
            txtVessel.Clear();
            txtNavigator.Clear();
            txtFrom.Clear();
            txtTo.Clear();
            DTDateZoneTime.Value = DateAndTime.Now;
            txtCompass.Clear();
            txtVar.Clear();
            txtDev.Clear();
            txtCTrue.Clear();
            txtSpeed.Clear();
            txtLDeg.Clear();
            txtLMin.Clear();
            txtLoDeg.Clear();
            txtLoMin.Clear();
            txtWeather.Clear();
            txtWind.Clear();
            cboWindDir.Text = "";
            txtSeas.Clear();
            txtRemarks.Clear();
            cboLocType.Text = "";
            cboL.SelectedIndex = 0;
            cboLo.SelectedIndex = 0;
            cboVar.SelectedIndex = 0;
            cboDev.SelectedIndex = 0;
            chkDev.Checked = false;
            txtDestLDeg.Clear();
            txtDestLMin.Clear();
            txtDestLoDeg.Clear();
            txtDestLoMin.Clear();
            txtDestTrue.Clear();
            txtDestDist.Clear();
            txtDestElapsed.Clear();
            txtEstArrival.Clear();
            lblAdvHrMin.Visible = false;
            cboAdvHrs.Visible = false;
            cboAdvMin.Visible = false;
            lblAdvNm.Visible = false;
            cboAdvNm.Visible = false;
            cboAdvType.Visible = false;
            grpAdvInfo.Visible = false;
            grpbxPlan.Visible = false;
            txtVar.Clear();
            txtDev.Clear();
            CompassInput = false;
            TrueInput = false;
            DTChanged = false;
            DRAdvanceMode = false;
            UpdtRow = default;
            AddNewMode = false;
            HideCommonButtons();
            return;
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            btnDeleteSight.Visible = false;
            btnUpdateExisting.Visible = false;
            ResetAllScreenFields();
            return;
        }

        private int FindDeleteRows()
        {
            int DGLimit = DataGridView1.Rows.Count;
            for (int i = 0, loopTo = DGLimit - 1; i <= loopTo; i++)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(DataGridView1.Rows[i].Cells[LogTypeCell].Value, "Delete", false)))
                {
                    return i;
                }
            }

            return -1;
        }

        private void RemoveEmptyRowsinDG()
        {
            int DGLimit = DataGridView1.Rows.Count;
            for (int i = 0, loopTo = DGLimit - 1; i <= loopTo; i++)
            {
                if (Conversions.ToBoolean(Operators.OrObject(Operators.ConditionalCompareObjectEqual(DataGridView1.Rows[i].Cells[LogTypeCell].Value, Constants.vbNullString, false), Operators.ConditionalCompareObjectEqual(DataGridView1.Rows[i].Cells[LogTypeCell].Value, "", false))))
                {
                    DataGridView1.Rows[i].Cells[LogTypeCell].Value = "Delete";
                    DataGridView1.Rows[i].Cells[DTCell].Value = MaxDate;
                }
            }

            int DltRow = FindDeleteRows();
            while (DltRow != -1)
            {
                var RowToDlt = DataGridView1.Rows[DltRow];
                DataGridView1.Rows.Remove(RowToDlt);
                DltRow = FindDeleteRows();
            }

            return;
        }

        private void SortDataGridonDate()
        {
            SortingDG = true;
            DataGridView1.Sort(DataGridView1.Columns[DTCell], System.ComponentModel.ListSortDirection.Ascending);
            // For i As Integer = 0 To DataGridView1.Columns.Count - 1
            // DataGridView1.AutoResizeColumn(i)
            // Next
            // select last row in data grid - this code removed when filtering display on all/plan/track added. It was making the filtering impossible.
            // Dim LastRow As Integer = DataGridView1.Rows.Count - 1
            // DataGridView1.CurrentCell = DataGridView1.Rows(LastRow).Cells(4)
            // DataGridView1.Rows(LastRow).Selected = True
            SortingDG = false;
            return;
        }

        private void evaluateDG()
        {
            if (InitialLoad == true)
                return;
            if (FileLoading == true)
                return;
            int DGlimit = DataGridView1.Rows.Count;
            bool PrevGPSFIXExists = false;
            int PrevGPSFix = 0;
            bool PrevDRExists = false;
            int PrevDR = 0;
            bool PrevWPTFixExists = false;
            int PrevWPTFix = 0;
            if (DGlimit == 1)
            {
                // ErrorMsgBox("Nothing to evaluate - the Data Grid only has one entry")
                return;
            }

            // spin thru the datagridview and install the current and correct ZD based on the longitude
            for (int i = 0, loopTo = DGlimit - 1; i <= loopTo; i++)
            {
                if (string.IsNullOrEmpty(DataGridView1.Rows[i].Cells[LogTypeCell].Value.ToString()))
                { // nothing
                }
                else
                { // install ZD based on Lat/Long cell
                    var GeoLLo1 = ParseLatLong(DataGridView1.Rows[i].Cells[DestLogTypeCell].Value.ToString());
                    DataGridView1.Rows[i].Cells[ZDCell].Value = Math.Round(GeoLLo1.Longitude / 15d, 0);
                }
            }

            if ((DataGridView1.Rows[0].Cells[LogTypeCell].Value.ToString() == g_LogTypeGPS) | 
                (DataGridView1.Rows[0].Cells[LogTypeCell].Value.ToString() == g_LogTypeOldGPS))
            {
                if ((DataGridView1.Rows[0].Cells[UseForEvalCell].Value.ToString() == "Y"))
                {
                    PrevGPSFIXExists = true;
                    PrevGPSFix = 0;
                }
            }

            if ((DataGridView1.Rows[0].Cells[LogTypeCell].Value.ToString() == g_LogTypeDR) | 
                (DataGridView1.Rows[0].Cells[LogTypeCell].Value.ToString() == g_LogTypeOldDR))
            {
                if ((DataGridView1.Rows[0].Cells[UseForEvalCell].Value.ToString() == "Y"))
                {
                    PrevDRExists = true;
                    PrevDR = 0;
                }
            }

            if ((DataGridView1.Rows[0].Cells[LogTypeCell].Value.ToString() == g_LogTypeFix) |
               (DataGridView1.Rows[0].Cells[LogTypeCell].Value.ToString() == g_LogTypeWayPoint))
            {
                if ((DataGridView1.Rows[0].Cells[UseForEvalCell].Value.ToString() == "Y"))
                {
                    PrevDRExists = true;
                    PrevDR = 0;
                }
            }

            // now pass thru the data grid from the second record to the end evaluate each pair of records and calculating the final route results
            for (int i = 1, loopTo1 = DGlimit - 1; i <= loopTo1; i++)
            {
                if ((DataGridView1.Rows[i].Cells[LogTypeCell].Value.ToString() == g_LogTypePlan))
                {
                    DataGridView1.Rows[i].Cells[ElapsedCell].Value = ""; // Elapsed Time
                    DataGridView1.Rows[i].Cells[DistCell].Value = ""; // Distance
                    DataGridView1.Rows[i].Cells[CalcDestLogTypeCell].Value = ""; // Calc Loc L/Lo
                    DataGridView1.Rows[i].Cells[CalcDestTrueCell].Value = ""; // CMG
                    DataGridView1.Rows[i].Cells[CalcDestSpeedCell].Value = ""; // SMG
                    DataGridView1.Rows[i].Cells[CalcSetCell].Value = ""; // Set 
                    DataGridView1.Rows[i].Cells[CalcDriftCell].Value = ""; // Drift
                    DataGridView1.Rows[i].Cells[EvalCell].Value = ""; // Eval Based On
                }
                else
                {
                    DataGridView1.Rows[i].Cells[CalcSetCell].Value = ""; // Set 
                    DataGridView1.Rows[i].Cells[CalcDriftCell].Value = ""; // Drift
                    DataGridView1.Rows[i].Cells[EvalCell].Value = "";
                } // Eval Based On

                // now pass thru the datagridview and evaluate pairs of log entries - GPS entries, DR and Fix entries, and WayPoints. 
                // Ignore Plan entries because they are analyzed when they are created
                if (DataGridView1.Rows[i].Cells[LogTypeCell].Value.ToString() == g_LogTypePlan)
                {
                    DataGridView1.Rows[i].Cells[EvalCell].Value = "Planned Route Entry";
                }
                else if ((DataGridView1.Rows[i].Cells[LogTypeCell].Value.ToString() == g_LogTypeGPS) | 
                    (DataGridView1.Rows[i].Cells[LogTypeCell].Value.ToString() == g_LogTypeOldGPS))
                {
                    if (PrevGPSFIXExists == true)
                    {
                        EvaluateDBPairs(i, PrevGPSFix, true);
                        DataGridView1.Rows[i].Cells[EvalCell].Value = ("GPS Track: " + DataGridView1.Rows[PrevGPSFix].Cells[DTCell].Value);
                        if (DataGridView1.Rows[i].Cells[UseForEvalCell].Value.ToString() == "Y")
                        {
                            PrevGPSFix = i;
                        }
                    }
                    else if (DataGridView1.Rows[i].Cells[UseForEvalCell].Value.ToString() == "Y")
                    {
                        PrevGPSFIXExists = true;
                        PrevGPSFix = i;
                    }
                }
                // evaluate DR Tracks and Fixes together since a Fix should be taken relative to the DR track (although a GPS basis could be argued as needed here)
                else if ((DataGridView1.Rows[i].Cells[LogTypeCell].Value.ToString() == g_LogTypeDR)| 
                    (DataGridView1.Rows[i].Cells[LogTypeCell].Value.ToString() == g_LogTypeOldDR)|
                    (DataGridView1.Rows[i].Cells[LogTypeCell].Value.ToString() == g_LogTypeFix))
                {
                    if (PrevDRExists == true)
                    {
                        EvaluateDBPairs(i, PrevDR, false);
                        DataGridView1.Rows[i].Cells[EvalCell].Value = ("DR/Fix from: "+ DataGridView1.Rows[PrevDR].Cells[DTCell].Value.ToString());
                        if (DataGridView1.Rows[i].Cells[UseForEvalCell].Value.ToString() == "Y")
                        {
                            PrevDR = i;
                        }
                    }
                    else if (DataGridView1.Rows[i].Cells[UseForEvalCell].Value.ToString() == "Y")
                    {
                        PrevDRExists = true;
                        PrevDR = i;
                    }
                }
                // evaluate the distances and courses between waypoints - if they are flagged with use for eval indicator = Y
                else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(DataGridView1.Rows[i].Cells[LogTypeCell].Value, g_LogTypeWayPoint, false)))
                {
                    if (PrevWPTFixExists == true)
                    {
                        EvaluateDBPairs(i, PrevWPTFix, false);
                        DataGridView1.Rows[i].Cells[EvalCell].Value = ("WPT from: " + DataGridView1.Rows[PrevWPTFix].Cells[DTCell].Value.ToString());
                        if (DataGridView1.Rows[i].Cells[UseForEvalCell].Value.ToString() == "Y")
                        {
                            PrevWPTFix = i;
                        }
                    }
                    else if (DataGridView1.Rows[i].Cells[UseForEvalCell].Value.ToString() == "Y")
                    {
                        PrevWPTFixExists = true;
                        PrevWPTFix = i;
                    }
                }
            }

            return;
        }

        private void EvaluateDBPairs(int CurrRec, int PrevRec, bool GPSFixEntry)
        {
            // evaluate Elapsed time from last entry
            var DT1 = Convert.ToDateTime(DataGridView1.Rows[PrevRec].Cells[DTCell].Value);
            var DT2 = Convert.ToDateTime(DataGridView1.Rows[CurrRec].Cells[DTCell].Value);
            int ZDLoc1 = Convert.ToInt32(DataGridView1.Rows[PrevRec].Cells[ZDCell].Value);
            int ZDLoc2 = Convert.ToInt32(DataGridView1.Rows[CurrRec].Cells[ZDCell].Value);
            var TS = DT2 - DT1;
            if (ZDLoc1 != ZDLoc2)
            {
                int IncrHr = 0;
                if (Math.Sign(ZDLoc1) != Math.Sign(ZDLoc2)) // we have crossed the IDL
                {
                    if (ZDLoc1 < 0 & ZDLoc2 > 0) // moving from West (ZD negative) to East (ZD positive)
                    {
                        IncrHr = ZDLoc1 - ZDLoc2;
                    }

                    if (ZDLoc1 > 0 & ZDLoc2 < 0) // moving from East (ZD positive) to West (ZD negative)
                    {
                        IncrHr = ZDLoc1 + ZDLoc2;
                    }
                }
                else
                {
                    IncrHr = -1 * (ZDLoc2 - ZDLoc1);
                }

                var TmpTS = new TimeSpan(IncrHr, 0, 0);
                TS = TS.Add(TmpTS);
            }

            if (TS.Days == 0)
            {
                DataGridView1.Rows[CurrRec].Cells[ElapsedCell].Value = TS.ToString(@"hh\:mm\:ss");
            }
            else
            {
                DataGridView1.Rows[CurrRec].Cells[ElapsedCell].Value = TS.ToString(@"d\d\y\ hh\:mm\:ss");
            }

            // evaluate Calculate destination location - start with location of previous entry 
            var GeoLLo1 = ParseLatLong(Conversions.ToString(DataGridView1.Rows[PrevRec].Cells[DestLogTypeCell].Value));
            string TempcboL1 = CommonGlobals.g_LatN;
            double TempL1 = GeoLLo1.Latitude;
            double TempL1Disp = GeoLLo1.Latitude;
            if (GeoLLo1.Latitude < 0d)
            {
                TempcboL1 = CommonGlobals.g_LatS;
                TempL1Disp = -1 * TempL1; // A South latitude value is set to negative in the ParseLatLong routine
            }
            else
            {
                TempcboL1 = CommonGlobals.g_LatN;
                TempL1Disp = TempL1;
            }

            string TempcboLo1 = "";
            double TempLo1Disp = GeoLLo1.Longitude;
            double TempLo1 = GeoLLo1.Longitude;
            if (GeoLLo1.Longitude < 0d)
            {
                TempcboLo1 = CommonGlobals.g_LongW;
                TempLo1Disp = -1 * TempLo1; // An West longitude value is set to negative in the ParseLatLong routine
            }
            else
            {
                TempcboLo1 = CommonGlobals.g_LongE;
                TempLo1Disp = TempLo1;
            }

            // now calculate the location for the current entry
            var GeoLLo2 = ParseLatLong(Conversions.ToString(DataGridView1.Rows[CurrRec].Cells[DestLogTypeCell].Value));
            string TempcboL = CommonGlobals.g_LatN;
            double TempL = GeoLLo2.Latitude;
            double TempLDisp = GeoLLo2.Latitude;
            if (GeoLLo2.Latitude < 0d)
            {
                TempcboL = CommonGlobals.g_LatS;
                TempLDisp = -1 * TempL; // A South latitude value is set to negative in the ParseLatLong routine
            }
            else
            {
                TempcboL = CommonGlobals.g_LatN;
                TempLDisp = TempL;
            }

            string TempcboLo = "";
            double TempLoDisp = GeoLLo2.Longitude;
            double TempLo = GeoLLo2.Longitude;
            if (GeoLLo2.Longitude < 0d)
            {
                TempcboLo = CommonGlobals.g_LongW;
                TempLoDisp = -1 * TempLo;  // An West longitude value is set to negative in the ParseLatLong routine
            }
            else
            {
                TempcboLo = CommonGlobals.g_LongE;
                TempLoDisp = TempLo;
            }

            int tlen = DataGridView1.Rows[PrevRec].Cells[TrueCell].Value.ToString().Length;
            double TempTrue = 0d;
            double TempSpeed = 0d;
            // get the distance from the previous location to the current entry location
            double Dist = 0d;
            if ((DataGridView1.Rows[PrevRec].Cells[LogTypeCell].Value.ToString() ) == (g_LogTypeFix ) | (DataGridView1.Rows[PrevRec].Cells[LogTypeCell].Value.ToString() ) == (g_LogTypeWayPoint ))
            {
                Dist = GetDistance(GeoLLo1.Latitude, GeoLLo1.Longitude, GeoLLo2.Latitude, GeoLLo2.Longitude);
            }
            else
            {
                Dist = GetDistanceDG(PrevRec, CurrRec);
            }

            if ((DataGridView1.Rows[CurrRec].Cells[LogTypeCell].Value.ToString() == g_LogTypeFix)| 
                (DataGridView1.Rows[CurrRec].Cells[LogTypeCell].Value.ToString() == g_LogTypeWayPoint))
            {
                TempTrue = GetHeading(GeoLLo1.Latitude, GeoLLo1.Longitude, GeoLLo2.Latitude, GeoLLo2.Longitude);
                // TempSpeed = Calc60DSTSpeed(DT1, DT2, Dist)
                TempSpeed = Calc60DSTSpeedTS(TS, Dist);
            }
            else
            {
                TempTrue = Convert.ToDouble(DataGridView1.Rows[PrevRec].Cells[TrueCell].Value.ToString().Substring(0, tlen - 1));
                tlen = DataGridView1.Rows[PrevRec].Cells[DRSpeedCell].Value.ToString().Length;
                TempSpeed = Convert.ToDouble(DataGridView1.Rows[PrevRec].Cells[DRSpeedCell].Value.ToString().Substring(0, tlen - 2));
            }

            DataGridView1.Rows[CurrRec].Cells[DistCell].Value = Dist.ToString("#0.0") + " nm";

            // now calculate the destination location using the previous loc, the distance using prev speed and elapsed time, and true course of prev entry
            var TempLoc = CommonGlobals.SailingsFindDestLLo(TempL1, TempLo1, Dist, TempTrue);
            // Dim TempLoc As System.Device.Location.GeoCoordinate = C_FindDestLatLong(TempL1, TempLo1, Dist, TempTrue)
            double TempL3 = TempLoc.Latitude;
            string TempL3NS = TempcboL;
            double TempL3Disp = 0d;
            if (TempL3 < 0d)
            {
                TempL3NS = CommonGlobals.g_LatS;
                TempL3Disp = -1 * TempL3;
            }
            else
            {
                TempL3NS = CommonGlobals.g_LatN;
                TempL3Disp = TempL3;
            }

            int TempL3Deg = (int)Conversion.Int(TempL3Disp);
            double TempL3Min = (TempL3Disp - TempL3Deg) * 60d;
            double TempLo3 = TempLoc.Longitude;
            string TempLo3EW = TempcboLo;
            double TempLo3Disp = 0d;
            if (TempLo3 < 0d)
            {
                TempLo3EW = CommonGlobals.g_LongW;
                TempLo3Disp = -1 * TempLo3;
            }
            else
            {
                TempLo3EW = CommonGlobals.g_LongE;
                TempLo3Disp = TempLo3;
            }

            int TempLo3Deg = (int)Conversion.Int(TempLo3Disp);
            double TempLo3Min = (TempLo3Disp - TempLo3Deg) * 60d;
            DataGridView1.Rows[CurrRec].Cells[CalcDestLogTypeCell].Value = "L=" + TempL3Deg.ToString("##0") + '°' + TempL3Min.ToString("#0.0") + "'" + TempL3NS + " " + "Lo=" + TempLo3Deg.ToString("##0") + '°' + TempLo3Min.ToString("#0.0") + "'" + TempLo3EW;

            // if the previous date/time is the same as the current record date/time then no true course or speed is available
            if (TS.Days == 0 & TS.Hours == 0 & TS.Minutes == 0 & TS.Seconds == 0)
            {
                DataGridView1.Rows[CurrRec].Cells[CalcDestTrueCell].Value = "0" + '°';
                DataGridView1.Rows[CurrRec].Cells[CalcDestSpeedCell].Value = "0kn";
            }
            else
            {
                // Calculate the actual course between the previous loc and the current loc 
                double CMG = GetHeading(TempL1, TempLo1, TempL3, TempLo3);
                DataGridView1.Rows[CurrRec].Cells[CalcDestTrueCell].Value = CMG.ToString("##0") + '°';
                // Calculate the actual speed using the calculate distance between previous loc and current loc and the elapsed time
                double SMG = Calc60DSTSpeedTS(TS, Dist);
                DataGridView1.Rows[CurrRec].Cells[CalcDestSpeedCell].Value = SMG.ToString("##0.0") + "kn ";
            }

            if (GPSFixEntry == true)
            {
                // calculate the Direction of Set from current loc to actual computed loc 
                double SetCalc = GetHeading(TempL, TempLo, TempL3, TempLo3);
                DataGridView1.Rows[CurrRec].Cells[CalcSetCell].Value = SetCalc.ToString("##0.0") + '°';
                // Calculate Drift distance and speed from current loc to actual computed loc
                double DistDrift = GetDistance(TempL, TempLo, TempL3, TempLo3);
                double DriftSpeed = Calc60DSTSpeedTS(TS, DistDrift);
                DataGridView1.Rows[CurrRec].Cells[CalcDriftCell].Value = DriftSpeed.ToString("##0.0") + "kn ";
            }

            return;
        }

        private double GetDistanceDG(int PrevRec, int CurrRec)
        {
            var DT1 = Convert.ToDateTime(DataGridView1.Rows[PrevRec].Cells[DTCell].Value);
            var DT2 = Convert.ToDateTime(DataGridView1.Rows[CurrRec].Cells[DTCell].Value);
            int ZDLoc1 = Convert.ToInt32(DataGridView1.Rows[PrevRec].Cells[ZDCell].Value);
            int ZDLoc2 = Convert.ToInt32(DataGridView1.Rows[CurrRec].Cells[ZDCell].Value);
            var TS = DT2 - DT1;
            if (ZDLoc1 != ZDLoc2)
            {
                int IncrHr = 0;
                if (Math.Sign(ZDLoc1) != Math.Sign(ZDLoc2)) // we have crossed the IDL
                {
                    if (ZDLoc1 < 0 & ZDLoc2 > 0) // moving from West (ZD negative) to East (ZD positive)
                    {
                        IncrHr = ZDLoc1 - ZDLoc2;
                    }

                    if (ZDLoc1 > 0 & ZDLoc2 < 0) // moving from East (ZD positive) to West (ZD negative)
                    {
                        IncrHr = ZDLoc1 + ZDLoc2;
                    }
                }
                else
                {
                    IncrHr = -1 * (ZDLoc2 - ZDLoc1);
                }

                var TmpTS = new TimeSpan(IncrHr, 0, 0);
                TS = TS.Add(TmpTS);
            }

            int tlen = DataGridView1.Rows[PrevRec].Cells[TrueCell].Value.ToString().Length;
            double TempTrue = Convert.ToDouble(DataGridView1.Rows[PrevRec].Cells[TrueCell].Value.ToString().Substring(0, tlen - 1));
            tlen = DataGridView1.Rows[PrevRec].Cells[DRSpeedCell].Value.ToString().Length;
            double TempSpeed = Convert.ToDouble(DataGridView1.Rows[PrevRec].Cells[DRSpeedCell].Value.ToString().Substring(0, tlen - 2));
            // get the distance from the previous location to the current entry location
            double Dist = TempSpeed * (TS.TotalMinutes / 60d);
            return Dist;
        }

        private static double GetDistance(double Lat1In, double Long1In, double Lat2In, double Long2In)
        {
            var Coord1 = new System.Device.Location.GeoCoordinate(Lat1In, Long1In);
            var Coord2 = new System.Device.Location.GeoCoordinate(Lat2In, Long2In);
            return Coord1.GetDistanceTo(Coord2) / 1852.0d;  // GetDistanceTo returns distance between geo coords in meters - there are 1852 meters in a nautical mile
        }

        private static double GetHeading(double lat1, double long1, double lat2, double long2)
        {
            double x = Math.Cos(DegreesToRadians(lat1)) * Math.Sin(DegreesToRadians(lat2)) - Math.Sin(DegreesToRadians(lat1)) * Math.Cos(DegreesToRadians(lat2)) * Math.Cos(DegreesToRadians(long2) - DegreesToRadians(long1));
            double y = Math.Sin(DegreesToRadians(long2) - DegreesToRadians(long1)) * Math.Cos(DegreesToRadians(lat2));
            // Dim DegX As Double = RadiansToDegrees(x)
            // Dim DegY As Double = RadiansToDegrees(y)
            double Angle = RadiansToDegrees(Math.Atan2(y, x));
            return (Angle + 360d) % 360d;
        }

        private static double DegreesToRadians(double angle)
        {
            return angle * Math.PI / 180d;
        }

        private static double RadiansToDegrees(double angle)
        {
            return angle * 180d / Math.PI;
        }

        private static double Calc60DSTDistance(DateTime DT1, DateTime DT2, double Speed)
        {
            var TS = DT2 - DT1;
            return Speed * TS.TotalHours;
        }

        private static double Calc60DSTSpeed(DateTime DT1, DateTime DT2, double Dist)
        {
            var TS = DT2 - DT1;
            return 60d * Dist / TS.TotalMinutes;
        }

        private static double Calc60DSTSpeedTS(TimeSpan TSIn, double Dist)
        {
            return 60d * Dist / TSIn.TotalMinutes;
        }

        private static TimeSpan Calc60DSTElapsed(DateTime DT1, double Speed, double Distance)
        {
            double ElapsedMin = 60d * Distance / Speed;
            var newDT = DT1;
            newDT = newDT.AddMinutes(ElapsedMin);
            var TS = newDT - DT1;
            return TS;
        }

        private static System.Device.Location.GeoCoordinate ParseLatLong(string StrIn)
        {
            // evaluate Calculate destination location - start with location of previous entry 
            string LLo1 = StrIn;  // DataGridView1.Rows(i - 1).Cells(DestLogTypeCell).Value
            int LPos1 = LLo1.IndexOf("=", StringComparison.CurrentCultureIgnoreCase);
            int LDegPos1 = LLo1.IndexOf('°');
            int LMinPos1 = LLo1.IndexOf("'", StringComparison.CurrentCultureIgnoreCase);
            int LoPos1 = LLo1.IndexOf("=", LPos1 + 1, StringComparison.CurrentCultureIgnoreCase);
            int LoDegPos1 = LLo1.IndexOf('°', LDegPos1 + 1);
            int LoMinPos1 = LLo1.IndexOf("'", LMinPos1 + 1, StringComparison.CurrentCultureIgnoreCase);
            double TempL1 = Convert.ToDouble(LLo1.Substring(LPos1 + 1, LDegPos1 - 1 - (LPos1 + 1) + 1)) + Convert.ToDouble(Conversions.ToDouble(LLo1.Substring(LDegPos1 + 1, LMinPos1 - 1 - (LDegPos1 + 1) + 1)) / 60d);
            string TempcboL1 = LLo1.Substring(LMinPos1 + 1, 1);
            double TempL1Disp = 0d;
            if ((TempcboL1 ) == (CommonGlobals.g_LatS ))
            {
                TempL1Disp = -1 * TempL1;
            }
            else
            {
                TempL1Disp = TempL1;
            }

            double TempLo1 = Convert.ToDouble(LLo1.Substring(LoPos1 + 1, LoDegPos1 - 1 - (LoPos1 + 1) + 1)) + Convert.ToDouble(Conversions.ToDouble(LLo1.Substring(LoDegPos1 + 1, LoMinPos1 - 1 - (LoDegPos1 + 1) + 1)) / 60d);
            string TempcboLo1 = LLo1.Substring(LoMinPos1 + 1, 1);
            double TempLo1Disp = 0d;
            if ((TempcboLo1 ) == (CommonGlobals.g_LongW ))
            {
                TempLo1Disp = -1 * TempLo1;
            }
            else
            {
                TempLo1Disp = TempLo1;
            }

            var RtnLLo = new System.Device.Location.GeoCoordinate(TempL1Disp, TempLo1Disp);
            return RtnLLo;
        }

        private void cboLocType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InitialLoad == true)
                return;
            if (FileLoading == true)
                return;
            if (DRAdvanceMode == true)
                return;
            CompassInput = false;
            TrueInput = false;
            cboAdvHrs.Value = 0m;
            cboAdvMin.Value = 0m;
            cboAdvNm.Value = 0.0m;
            cboAdvType.Visible = false;
            lblAdvNm.Visible = false;
            cboAdvNm.Visible = false;
            lblAdvHrMin.Visible = false;
            cboAdvHrs.Visible = false;
            cboAdvMin.Visible = false;
            // DRAdvanceDGSave = 0
            DRAdvanceMode = false;
            // set default colors - input fields are encoded yellow while those protected from input are encoded in aqua

            txtLDeg.BackColor = Color.Yellow;
            txtLMin.BackColor = Color.Yellow;
            txtLoDeg.BackColor = Color.Yellow;
            txtLoMin.BackColor = Color.Yellow;
            txtSpeed.BackColor = Color.Yellow;
            txtDestLDeg.BackColor = Color.Yellow;
            txtDestLMin.BackColor = Color.Yellow;
            txtDestLoDeg.BackColor = Color.Yellow;
            txtDestLoMin.BackColor = Color.Yellow;
            txtCompass.BackColor = Color.Aqua;
            txtDev.BackColor = Color.Aqua;
            txtVar.BackColor = Color.Aqua;
            txtCTrue.BackColor = Color.Aqua;
            txtKnotLog.BackColor = Color.Aqua;
            // now set fields access and color according to Entry type
            // no matter what type of entry is selected, the deviation field must be set according to whether the use Devform check box is checked
            if (chkDev.Checked == true)
            {
                txtDev.Enabled = false;
                cboDev.Enabled = false;
                txtDev.BackColor = Color.Aqua;
            }
            else
            {
                txtDev.Enabled = true;
                cboDev.Enabled = true;
                txtDev.BackColor = Color.Yellow;
            }

            txtSpeed.Visible = true;
            txtDev.Visible = true;
            cboDev.Visible = true;
            chkDev.Visible = true;
            txtCompass.Visible = true;
            txtVar.Visible = true;
            cboVar.Visible = true;
            txtCTrue.Visible = true;
            grpLogNotes.Visible = true;
            grpWeather.Visible = false;
            if ((cboLocType.Text.ToString() == g_LogTypePlan ))
            {
                ResetScreenFieldsforPlan();
            }
            else if ((cboLocType.Text.ToString() == g_LogTypeGPS ))
            {
                ResetScreenFieldsforGPS();
            }
            else if ((cboLocType.Text.ToString() == g_LogTypeDRAdv ))
            {
                if (Information.IsNothing(UpdtRow) | (DataGridView1.Rows[UpdtRow].Cells[LogTypeCell].Value.ToString() ) != (g_LogTypeDR ))
                {
                    ErrorMsgBox("You can only Advance a DR Entry - This Entry Type Selection is Invalid - Selection is reset to DR");
                    cboLocType.SelectedIndex = 0;
                    DRAdvanceMode = false;
                    Refresh();
                    return;
                }
                else
                {
                    ResetScreenFieldsforDRAdvance();
                    cboAdvType_SelectedIndexChanged(sender, e);
                }
            }
            else if ((cboLocType.Text.ToString() == g_LogTypeDR ))
            {
                ResetScreenFieldsforDR();
            }
            else if ((cboLocType.Text.ToString() == g_LogTypeFix ) | (cboLocType.Text.ToString() == g_LogTypeWayPoint ))
            {
                ResetScreenFieldsForWPFix();
                DRAdvanceMode = false;
            }
            // you can only update the currently selected row with the same log type - if it is changed then you must add or delete not change to a new type
            if (UpdtRow != default & DataGridView1.Rows.Count != 0 & (cboLocType.Text.ToString() ) == (DataGridView1.Rows[UpdtRow].Cells[LogTypeCell].Value.ToString() ))
            {
                btnUpdateExisting.Visible = true;
            }
            else
            {
                btnUpdateExisting.Visible = false;
            }
            // now set color coding of grpLogEntryInfo box to match the color coding for entries in the datagridview
            switch (cboLocType.Text.ToString() )
            {
                case var @case when @case == (g_LogTypeGPS ):
                case var case1 when case1 == (g_LogTypeOldGPS ):
                    {
                        grpLogEntryInfo.BackColor = GPSBackColor;
                        grpLogEntryInfo.ForeColor = GPSForeColor;
                        break;
                    }

                case var case2 when case2 == (g_LogTypeDR ):
                case var case3 when case3 == (g_LogTypeOldDR ):
                    {
                        grpLogEntryInfo.BackColor = DRBackColor;
                        grpLogEntryInfo.ForeColor = DRForeColor;
                        break;
                    }

                case var case4 when case4 == (g_LogTypeDRAdv ):
                    {
                        grpLogEntryInfo.BackColor = DRBackColor;
                        grpLogEntryInfo.ForeColor = DRForeColor;
                        grpAdvInfo.BackColor = DRBackColor;
                        grpAdvInfo.ForeColor = DRForeColor;
                        break;
                    }

                case var case5 when case5 == (g_LogTypePlan ):
                case var case6 when case6 == (g_LogTypeOldPlan ):
                    {
                        grpLogEntryInfo.BackColor = PlanBackColor;
                        grpLogEntryInfo.ForeColor = PlanForeColor;
                        break;
                    }

                case var case7 when case7 == (g_LogTypeFix ):
                    {
                        grpLogEntryInfo.BackColor = FixBackColor;
                        grpLogEntryInfo.ForeColor = FixForeColor;
                        break;
                    }

                case var case8 when case8 == (g_LogTypeWayPoint ):
                    {
                        grpLogEntryInfo.BackColor = WPTBackColor;
                        grpLogEntryInfo.ForeColor = WPTForeColor;
                        break;
                    }

                default:
                    {
                        grpLogEntryInfo.BackColor = DefBackColor;
                        grpLogEntryInfo.ForeColor = DefForeColor;
                        break;
                    }
            }

            ClearPlanFields();
            Refresh();
            return;
        }

        private void ClearPlanFields()
        {
            txtDestLDeg.Clear();
            txtDestLMin.Clear();
            txtDestLoDeg.Clear();
            txtDestLoMin.Clear();
            cboDestL.SelectedIndex = 0;
            cboDestLo.SelectedIndex = 0;
            txtDestTrue.Clear();
            txtDestDist.Clear();
            txtDestElapsed.Clear();
            txtEstArrival.Clear();
            // txtWeather.Clear()
            // txtRemarks.Clear()
            return;
        }

        private void chkHideFirst4Col_CheckedChanged(object sender, EventArgs e)
        {
            DisplayHideFirst4Col();
            SortDataGridonDate();
            DataGridView1.ClearSelection();
            DataGridView1.CurrentCell = null;
            DataGridView1.Refresh();
            Refresh();
            return;
        }

        private void DisplayHideFirst4Col()
        {
            if (chkHideFirst4Col.Checked == true)
            {
                DataGridView1.Columns[0].Visible = false;
                DataGridView1.Columns[1].Visible = false;
                DataGridView1.Columns[2].Visible = false;
                DataGridView1.Columns[3].Visible = false;
                DataGridView1.Columns[12].Visible = false;
            }
            else
            {
                DataGridView1.Columns[0].Visible = true;
                DataGridView1.Columns[1].Visible = true;
                DataGridView1.Columns[2].Visible = true;
                DataGridView1.Columns[3].Visible = true;
                DataGridView1.Columns[12].Visible = true;
            }
        }

        private void btnStartFresh_Click(object sender, EventArgs e)
        {
            if (IsUpdated == true)
            {
                var MsgBack = Interaction.MsgBox("Data has been updated - Save to File - Yes or No", MsgBoxStyle.YesNo, "Save Updated Data");
                if (MsgBack == MsgBoxResult.Yes)
                {
                    SaveDataGrid();
                }

                IsUpdated = false;
            }

            FormDeckLogUpdate_Load(sender, e);
            // FileLoading = True
            // DataSet1.Tables(tablename).Clear()
            // ClearPlanFields()
            // ResetAllScreenFields()
            // Me.Refresh()
            // FileLoading = False
            return;
        }

        private readonly string BadLLoStr = "L=°'N Lo=°'W";

        private void btnExportGPX_Click(object sender, EventArgs e)
        {
            // Dim dirstr As String = FileIO.FileSystem.CurrentDirectory
            var saveFileDialog1 = new SaveFileDialog()
            {
                InitialDirectory = "./DeckLog/",
                Filter = "gpx files (*.gpx)|*.gpx",
                Title = "Export Deck Log Plan Entries to GPX",
                FilterIndex = 2,
                RestoreDirectory = true
            };
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(saveFileDialog1.FileName))
                {
                    saveFileDialog1.Dispose();
                    return;
                }

                FName = saveFileDialog1.FileName;
            }

            var textstr = new System.Text.StringBuilder();
            textstr.AppendLine(GetGPXHdr());
            for (int x = 0, loopTo = DataGridView1.Rows.Count - 1; x <= loopTo; x++)
            {
                if (Information.IsNothing(DataGridView1.Rows[x].Cells[VesselCell].Value) == false & !string.IsNullOrEmpty(DataGridView1.Rows[x].Cells[DestLogTypeCell].Value.ToString()) & (DataGridView1.Rows[x].Cells[DestLogTypeCell].Value.ToString() ) != (BadLLoStr ))
                {
                    // If DataGridView1.Rows(x).Cells(LogTypeCell).Value <> g_LogTypePlan Then ' if this is NOT a Plan type log entry then it is GPS or Fix or a WPT as a WayPoint type
                    if ((DataGridView1.Rows[x].Cells[LogTypeCell].Value.ToString() == g_LogTypeGPS)| 
                        (DataGridView1.Rows[x].Cells[LogTypeCell].Value.ToString() == g_LogTypeOldGPS) |
                        (DataGridView1.Rows[x].Cells[LogTypeCell].Value.ToString() ==  g_LogTypeWayPoint)|
                        (DataGridView1.Rows[x].Cells[LogTypeCell].Value.ToString() ==  g_LogTypeFix))
                    {
                        var TmpGeo = ParseLatLong(Conversions.ToString(DataGridView1.Rows[x].Cells[DestLogTypeCell].Value));
                        string TmpLat = TmpGeo.Latitude.ToString("00.00000");
                        double TmpLong = Conversions.ToDouble(TmpGeo.Longitude.ToString("000.00000"));
                        int TimeZone = (int)Math.Round(TmpLong / 15d, 0, MidpointRounding.AwayFromZero);
                        string displayName = "Custom TZ ";
                        string standardName = "Custom TZ";
                        var offset = new TimeSpan(TimeZone, 0, 0);
                        var customtz = TimeZoneInfo.CreateCustomTimeZone(standardName, offset, displayName, standardName);
                        var ZT = Convert.ToDateTime(DataGridView1.Rows[x].Cells[DTCell].Value);
                        var UT = TimeZoneInfo.ConvertTimeToUtc(ZT, customtz);
                        string UTStr = UT.ToString("yyyy-MM-ddTHH:mm:ssZ");
                        string LocalNm = DataGridView1.Rows[x].Cells[FromCell].Value.ToString() + "/" + DataGridView1.Rows[x].Cells[LogTypeCell].Value.ToString() + " WayPt";
                        string GPSFixType = "<fix>" + "dgps" + "</fix>";
                        string FixFixType = "<fix>" + "2d" + "</fix>";
                        string WPTName = "WPT" + (x + 1).ToString();
                        string WptStr1 = "";
                        if ((DataGridView1.Rows[x].Cells[LogTypeCell].Value.ToString() ) == (g_LogTypeGPS ) | (DataGridView1.Rows[x].Cells[LogTypeCell].Value.ToString() ) == (g_LogTypeOldGPS ))
                        {
                            WptStr1 = "<wpt lat=\"" + TmpLat + "\" lon=\"" + TmpLong + "\">" + "<time>" + UTStr + "</time><name>" + WPTName + "</name>" + GPSFixType + Environment.NewLine + "</wpt>";
                        }
                        else if ((DataGridView1.Rows[x].Cells[LogTypeCell].Value.ToString() ) == (g_LogTypeFix ))
                        {
                            WptStr1 = "<wpt lat=\"" + TmpLat + "\" lon=\"" + TmpLong + "\">" + "<time>" + UTStr + "</time><name>" + WPTName + "</name>" + FixFixType + Environment.NewLine + "</wpt>";
                        }
                        else if ((DataGridView1.Rows[x].Cells[LogTypeCell].Value.ToString() ) == (g_LogTypeWayPoint ))
                        {
                            WptStr1 = "<wpt lat=\"" + TmpLat + "\" lon=\"" + TmpLong + "\">" + "<time>" + UTStr + "</time><name>" + WPTName + "</name>" + GPSFixType + Environment.NewLine + "</wpt>";
                        }
                        else
                        {
                            WptStr1 = "<wpt lat=\"" + TmpLat + "\" lon=\"" + TmpLong + "\">" + "<time>" + UTStr + "</time><name>" + WPTName + "</name>" + "</wpt>";
                        }

                        textstr.AppendLine(WptStr1);
                    }
                }
            }

            textstr.Append(Environment.NewLine + "<rte>");
            for (int x = 0, loopTo1 = DataGridView1.Rows.Count - 1; x <= loopTo1; x++)
            {
                if (Information.IsNothing(DataGridView1.Rows[x].Cells[VesselCell].Value) == false & !string.IsNullOrEmpty(DataGridView1.Rows[x].Cells[DestLogTypeCell].Value.ToString()) & (DataGridView1.Rows[x].Cells[DestLogTypeCell].Value.ToString() ) != (BadLLoStr ))
                {
                    // If this entry type is a Plan Entry or Waypoint Entry then it is a RTE candidate
                    if ((DataGridView1.Rows[x].Cells[LogTypeCell].Value.ToString() == g_LogTypePlan)|
                        (DataGridView1.Rows[x].Cells[LogTypeCell].Value.ToString() == g_LogTypeOldPlan))
                    {
                        // DataGridView1.Rows(x).Cells(LogTypeCell).Value = g_LogTypeWayPoint Then
                        if (x == 0)
                        {
                            textstr.Append("<name>" + DataGridView1.Rows[x].Cells[FromCell].Value.ToString() + "/" + DataGridView1.Rows[x].Cells[ToCell].Value.ToString() + "/" + "Planned Route" + "</name>");
                        }

                        var TmpGeo = ParseLatLong(Conversions.ToString(DataGridView1.Rows[x].Cells[DestLogTypeCell].Value));
                        string TmpLat = TmpGeo.Latitude.ToString("00.00000");
                        double TmpLong = Conversions.ToDouble(TmpGeo.Longitude.ToString("000.00000"));
                        int TimeZone = (int)Math.Round(TmpLong / 15d, 0, MidpointRounding.AwayFromZero);
                        string displayName = "Custom TZ ";
                        string standardName = "Custom TZ";
                        var offset = new TimeSpan(TimeZone, 0, 0);
                        var customtz = TimeZoneInfo.CreateCustomTimeZone(standardName, offset, displayName, standardName);
                        var ZT = Convert.ToDateTime(DataGridView1.Rows[x].Cells[DTCell].Value);
                        var UT = TimeZoneInfo.ConvertTimeToUtc(ZT, customtz);
                        string UTStr = UT.ToString("yyyy-MM-ddTHH:mm:ssZ");
                        string LocalNm = "RtePt" + (x + 1).ToString();     //DataGridView1.Rows[x].Cells[FromCell].Value.ToString() + "/" + DataGridView1.Rows[x].Cells[ToCell].Value.ToString() + "/" + DataGridView1.Rows[x].Cells[LogTypeCell].Value.ToString() + " RoutePt";
                        string RteStr = "<rtept lat=\"" + TmpLat + "\" lon=\"" + TmpLong + "\">" + "<time>" + UTStr + "</time><name>" + LocalNm + "</name>" + Environment.NewLine + "</rtept>";
                        textstr.AppendLine(RteStr);
                    }
                }
            }

            textstr.Append(Environment.NewLine + "</rte>");
            textstr.Append(Environment.NewLine + "<trk>");
            textstr.Append(Environment.NewLine + "<trkseg>");
            for (int x = 0, loopTo2 = DataGridView1.Rows.Count - 1; x <= loopTo2; x++)
            {
                if (Information.IsNothing(DataGridView1.Rows[x].Cells[VesselCell].Value) == false & !string.IsNullOrEmpty(DataGridView1.Rows[x].Cells[DestLogTypeCell].Value.ToString()) & (DataGridView1.Rows[x].Cells[DestLogTypeCell].Value.ToString() ) != (BadLLoStr ))
                {
                    // if this is a  DR Track or GPS Track or Fix type it is a TRK candidate (exclude Plan and WPT entries)
                    if ((DataGridView1.Rows[x].Cells[LogTypeCell].Value.ToString() == g_LogTypeGPS) |
                        (DataGridView1.Rows[x].Cells[LogTypeCell].Value.ToString() == g_LogTypeOldGPS)|
                        (DataGridView1.Rows[x].Cells[LogTypeCell].Value.ToString() == g_LogTypeDR)|
                        (DataGridView1.Rows[x].Cells[LogTypeCell].Value.ToString() == g_LogTypeOldDR)|
                        (DataGridView1.Rows[x].Cells[LogTypeCell].Value.ToString() == g_LogTypeFix))
                    {
                        var TmpGeo = ParseLatLong(Conversions.ToString(DataGridView1.Rows[x].Cells[DestLogTypeCell].Value));
                        string TmpLat = TmpGeo.Latitude.ToString("00.00000");
                        double TmpLong = Conversions.ToDouble(TmpGeo.Longitude.ToString("000.00000"));
                        int TimeZone = (int)Math.Round(TmpLong / 15d, 0, MidpointRounding.AwayFromZero);
                        string displayName = "Custom TZ ";
                        string standardName = "Custom TZ";
                        var offset = new TimeSpan(TimeZone, 0, 0);
                        var customtz = TimeZoneInfo.CreateCustomTimeZone(standardName, offset, displayName, standardName);
                        var ZT = Convert.ToDateTime(DataGridView1.Rows[x].Cells[DTCell].Value);
                        var UT = TimeZoneInfo.ConvertTimeToUtc(ZT, customtz);
                        string UTStr = UT.ToString("yyyy-MM-ddTHH:mm:ssZ");
                        string LocalNm = "TrkPt" + (x + 1).ToString();    //DataGridView1.Rows[x].Cells[FromCell].Value.ToString() + "/" + DataGridView1.Rows[x].Cells[ToCell].Value.ToString() + " TrackPt";
                        string TrkStr = "<trkpt lat=\"" + TmpLat + "\" lon=\"" + TmpLong + "\">" + "<time>" + UTStr + "</time><name>" + LocalNm + "</name>" + Environment.NewLine + "</trkpt>";
                        textstr.AppendLine(TrkStr);
                    }
                }
            }

            textstr.Append(Environment.NewLine + "</trkseg>");
            textstr.Append(Environment.NewLine + "</trk>");
            textstr.Append(Environment.NewLine + "</gpx>");
            System.IO.File.WriteAllText(FName, textstr.ToString(), System.Text.Encoding.Default);
            saveFileDialog1.Dispose();
            return;
        }

        private string GetGPXHdr()
        {
            //string tmpstr = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<gpx xmlns=\"http://www.topografix.com/GPX/1/1\" " + Environment.NewLine + "xmlns:xsi = \"http://www.w3.org/2001/XMLSchema-instance\" " + Environment.NewLine + "xsi:schemaLocation=\"http://www.topografix.com/GPX/1/1 http://www.topografix.com/GPX/1/1/gpx.xsd\"" + Environment.NewLine + "version=\"1.1\"" + Environment.NewLine + "creator=\"", DataGridView1.Rows[0].Cells[VesselCell].Value), " "), DataGridView1.Rows[0].Cells[FromCell].Value), "Plan Entries"), "\">"), Environment.NewLine));

            string tmpstr = "<gpx xmlns=\"http://www.topografix.com/GPX/1/1\" " + Environment.NewLine + 
                "xmlns:xsi = \"http://www.w3.org/2001/XMLSchema-instance\" " + Environment.NewLine + 
                "xsi:schemaLocation=\"http://www.topografix.com/GPX/1/1 http://www.topografix.com/GPX/1/1/gpx.xsd\"" + Environment.NewLine + 
                "version=\"1.1\"" + Environment.NewLine + 
                "creator=\""+ DataGridView1.Rows[0].Cells[VesselCell].Value.ToString() + " "+
                DataGridView1.Rows[0].Cells[FromCell].Value.ToString() + "Plan Entries" + "\">" + Environment.NewLine;

            return tmpstr;
        }

        private void DTDateZoneTime_ValueChanged(object sender, EventArgs e)
        {
            // If DRAdvanceMode = True Then
            // If AdvMin = 0 Then
            // Dim TS As TimeSpan = DTDateZoneTime.Value - DTAdvDTSave
            // AdvMin = Convert.ToInt32(TS.TotalMinutes)
            // End If
            // FindInstallAdvancedDR()
            // 'DTChanged = False
            // DRAdvanceMode = False
            // DRAdvanceDGSave = 0
            // End If
            // Me.Refresh()
            return;
        }

        private void FindInstallAdvancedDR()
        {
            if (DRAdvanceMode == true)
            {
                double TmpTrue = Convert.ToDouble(txtCTrue.Text);
                double TempSpeed = Convert.ToDouble(txtSpeed.Text.ToString());
                if (cboAdvType.SelectedIndex == 1)
                {
                    AdvNm = Convert.ToDouble(cboAdvNm.Value);
                    AdvMin = (int)(60d * AdvNm / TempSpeed);
                    double tmpHrMinD = AdvMin / 60d;
                    if (Conversion.Int(tmpHrMinD) > (double)cboAdvHrs.Maximum)
                    {
                        cboAdvHrs.Maximum = (decimal)(tmpHrMinD + 24d);
                    }

                    cboAdvHrs.Value = (decimal)Conversion.Int(tmpHrMinD);
                    cboAdvMin.Value = (decimal)((tmpHrMinD - Conversion.Int(tmpHrMinD)) * 60d);
                }
                else if (cboAdvType.SelectedIndex == 0)
                {
                    AdvMin = Convert.ToInt32(cboAdvHrs.Value.ToString()) * 60 + Convert.ToInt32(cboAdvMin.Value.ToString());
                    AdvNm = TempSpeed * AdvMin / 60d;
                    if (AdvNm > (double)cboAdvNm.Maximum)
                    {
                        cboAdvNm.Maximum = (decimal)(AdvNm + 1d);
                    }

                    cboAdvNm.Value = (decimal)AdvNm;
                }
                else
                {
                    AdvMin = 0;
                    AdvNm = 0d;
                    cboAdvHrs.Value = 0m;
                    cboAdvMin.Value = 0m;
                    cboAdvNm.Value = 0m;
                    System.Windows.MessageBox.Show("Invalid AdvType selected index - Advancing DR edits stopped");
                    return;
                }

                DTAdvDTSave = DTDateZoneTime.Value;
                DTAdvDTSave = DTAdvDTSave.AddHours((double)cboAdvHrs.Value);
                DTAdvDTSave = DTAdvDTSave.AddMinutes((double)cboAdvMin.Value);
                DTDateZoneTime.Value = DTAdvDTSave;
                // DTDateZoneTime.Value = DTDateZoneTime.Value.AddMinutes(AdvMin)

                string TempLLo = "L=" + txtLDeg.Text.ToString() + '°' + txtLMin.Text.ToString() + "'" + cboL.Text.ToString() + " Lo=" + txtLoDeg.Text.ToString() + '°' + txtLoMin.Text.ToString() + "'" + cboLo.Text.ToString();
                var TempLoc = ParseLatLong(TempLLo);
                // Dim TempDist As Double = TempSpeed * (AdvMin / 60)
                var TempLoc1 = CommonGlobals.SailingsFindDestLLo(TempLoc.Latitude, TempLoc.Longitude, AdvNm, TmpTrue);
                double TmpLoc1Lat = TempLoc1.Latitude;
                if (TempLoc1.Latitude < 0d) // if temploc1.latitude is negative it is South latitude
                {
                    cboL.SelectedIndex = 1;
                    TmpLoc1Lat = -1 * TempLoc1.Latitude;
                }
                else
                {
                    cboL.SelectedIndex = 0;
                    TmpLoc1Lat = TempLoc1.Latitude;
                }

                txtLDeg.Text = Conversion.Int(TmpLoc1Lat).ToString("#0");
                txtLMin.Text = ((TmpLoc1Lat - Conversion.Int(TmpLoc1Lat)) * 60d).ToString("00.0");
                double TmpLoc1Long = TempLoc1.Longitude;
                if (TempLoc1.Longitude < 0d) // if temploc1.longitude is negative, it is West longitude
                {
                    cboLo.SelectedIndex = 0;
                    TmpLoc1Long = -1 * TempLoc1.Longitude;
                }
                else
                {
                    cboLo.SelectedIndex = 1;
                    TmpLoc1Long = TempLoc1.Longitude;
                }

                txtLoDeg.Text = Conversion.Int(TmpLoc1Long).ToString("##0");
                txtLoMin.Text = ((TmpLoc1Long - Conversion.Int(TmpLoc1Long)) * 60d).ToString("00.0");
                cboLocType.SelectedIndex = 0; // set log entry type to DR Track (index = 0)
                int TmpZD = (int)Math.Round(TempLoc.Longitude / 15d, 0);
                int TmpZD1 = (int)Math.Round(TempLoc1.Longitude / 15d, 0);
                if (TmpZD != TmpZD1)
                {
                    // ProcessAddNew()
                    DTDateZoneTime.Value = ReturnDestinationZoneTime(TmpZD, TmpZD1, 0d, DTDateZoneTime.Value);
                    if (!string.IsNullOrEmpty(txtRemarks.Text))
                    {
                        txtRemarks.AppendText(Environment.NewLine);
                    }

                    txtRemarks.AppendText("DR Advance moved L/Lo from ZD " + TmpZD.ToString("#0") + " To ZD " + TmpZD1.ToString("#0"));
                }

                ProcessAddNew();
            }
            // now process adding this new DR entry

            return;
        }

        private void FindInstallAdvancedPlan()
        {
            double TmpTrue = Convert.ToDouble(txtCTrue.Text.ToString());
            double TempSpeed = Convert.ToDouble(txtSpeed.Text.ToString());
            if (cboAdvType.SelectedIndex == 1)
            {
                AdvNm = Convert.ToDouble(cboAdvNm.Value);
                AdvMin = (int)(60d * AdvNm / TempSpeed);
                double tmpHrMinD = AdvMin / 60d;
                cboAdvHrs.Value = (decimal)Conversion.Int(tmpHrMinD);
                cboAdvMin.Value = (decimal)((tmpHrMinD - Conversion.Int(tmpHrMinD)) * 60d);
            }
            else if (cboAdvType.SelectedIndex == 0)
            {
                AdvMin = Convert.ToInt32(cboAdvHrs.Value.ToString()) * 60 + Convert.ToInt32(cboAdvMin.Value.ToString());
                AdvNm = TempSpeed * AdvMin / 60d;
                cboAdvNm.Value = (decimal)AdvNm;
            }
            else
            {
                // AdvMin = 0
                // AdvNm = 0
                // cboAdvHrs.Value = 0
                // cboAdvMin.Value = 0
                // cboAdvNm.Value = 0
                System.Windows.MessageBox.Show("Invalid AdvType selected index - Advancing DR edits stopped");
                return;
            }

            string TempLLo = "L=" + txtLDeg.Text.ToString() + '°' + txtLMin.Text.ToString() + "'" + cboL.Text.ToString() + " Lo=" + txtLoDeg.Text.ToString() + '°' + txtLoMin.Text.ToString() + "'" + cboLo.Text.ToString();
            var TempLoc = ParseLatLong(TempLLo);
            double TempDist = AdvNm;  // TempSpeed * (AdvMin / 60)
            var TempLoc1 = CommonGlobals.C_FindDestLatLong(TempLoc.Latitude, TempLoc.Longitude, TempDist, TmpTrue);
            double TmpLoc1Lat = TempLoc1.Latitude;
            if (TempLoc1.Latitude < 0d)
            {
                cboDestL.SelectedIndex = 1;
                TmpLoc1Lat = -1 * TempLoc1.Latitude;
            }
            else
            {
                cboDestL.SelectedIndex = 0;
                TmpLoc1Lat = TempLoc1.Latitude;
            }

            txtDestLDeg.Text = Conversion.Int(TmpLoc1Lat).ToString("#0");
            txtDestLMin.Text = ((TmpLoc1Lat - Conversion.Int(TmpLoc1Lat)) * 60d).ToString("00.0");
            double TmpLoc1Long = TempLoc1.Longitude;
            if (TempLoc1.Longitude < 0d)
            {
                cboDestLo.SelectedIndex = 0;
                TmpLoc1Long = -1 * TempLoc1.Longitude;
            }
            else
            {
                cboDestLo.SelectedIndex = 1;
                TmpLoc1Long = TempLoc1.Longitude;
            }

            txtDestLoDeg.Text = Conversion.Int(TmpLoc1Long).ToString("##0");
            txtDestLoMin.Text = ((TmpLoc1Long - Conversion.Int(TmpLoc1Long)) * 60d).ToString("00.0");
            return;
        }

        private void linkLblNOAAVar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string URLNOAAMagVar = "https://www.ngdc.noaa.gov/geomag/calculators/magcalc.shtml";
            Process.Start(URLNOAAMagVar);
        }

        private void btnCreateReportFile_Click(object sender, EventArgs e)
        {
            // Dim dirstr As String = FileIO.FileSystem.CurrentDirectory
            var saveFileDialog1 = new SaveFileDialog()
            {
                InitialDirectory = "./DeckLog/",
                Filter = "txt files (*.txt)|*.txt|csv files (*.csv)|*.csv",
                Title = "Save Deck Log File",
                FilterIndex = 2,
                RestoreDirectory = true
            };
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(saveFileDialog1.FileName))
                {
                    saveFileDialog1.Dispose();
                    return;
                }

                FName = saveFileDialog1.FileName;
            }

            var textstr = new System.Text.StringBuilder();
            string FileHdrStr = Constants.vbNullString;
            for (int i = 0, loopTo = Information.UBound(HdrStr); i <= loopTo; i++)
            {
                if (i > 0)
                {
                    textstr.Append("," + Constants.vbTab);
                }

                textstr.Append(HdrStr[i]);
            }

            textstr.AppendLine();
            for (int x = 0, loopTo1 = DataGridView1.Rows.Count - 1; x <= loopTo1; x++)
            {
                if (Information.IsNothing(DataGridView1.Rows[x].Cells[VesselCell].Value) == false)
                {
                    for (int v = 0, loopTo2 = DataGridView1.Columns.Count - 1; v <= loopTo2; v++)
                    {
                        // extracting cell value from 0 to 9 and add it on list
                        if (v > 0)
                        {
                            textstr.Append("," + Constants.vbTab);
                        }

                        string tempstr = DataGridView1.Rows[x].Cells[v].Value.ToString();
                        tempstr = tempstr.Replace(",", ""); // remove any commas input into any field so csv file is not corrupted
                        textstr.Append(tempstr);
                    }
                }
                // adding new line to text
                textstr.AppendLine();
            }

            System.IO.File.WriteAllText(FName, textstr.ToString(), System.Text.Encoding.GetEncoding("iso-8859-1"));
            saveFileDialog1.Dispose();
            return;
        }

        private void btnUseTVMDC_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FormTVMDC.Show();
            return;
        }

        private readonly string g_ZeroStr = "0";

        private void btnUseZTInfoForm_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.ZTInfo.InvokedbyDeckLog = true;
            DestDTUpdatedbyZTInfo = false;
            My.MyProject.Forms.ZTInfo.txtLoDegA.Text = txtLoDeg.Text;
            My.MyProject.Forms.ZTInfo.txtLoMinA.Text = txtLoMin.Text;
            My.MyProject.Forms.ZTInfo.cboLoA.Text = cboLo.Text;
            My.MyProject.Forms.ZTInfo.DTLocA.Value = DTDateZoneTime.Value;
            if (cboAdvHrs.Value != 0m | cboAdvMin.Value != 0m)
            {
                My.MyProject.Forms.ZTInfo.DT1Days.Value = 0m;
                My.MyProject.Forms.ZTInfo.DT1Hours.Value = Convert.ToInt32(value: cboAdvHrs.Value.ToString(), CultureInfo.CurrentCulture);
                My.MyProject.Forms.ZTInfo.DT1Minutes.Value = Convert.ToInt32(value: cboAdvMin.Value.ToString(), CultureInfo.CurrentCulture);
            }
            else
            {
                My.MyProject.Forms.ZTInfo.DT1Days.Value = 0m;
                My.MyProject.Forms.ZTInfo.DT1Hours.Value = 0m;
                My.MyProject.Forms.ZTInfo.DT1Minutes.Value = 0m;
            }

            if ((cboLocType.Text.ToString() == g_LogTypePlan ) | DRAdvanceMode == true)
            {
                My.MyProject.Forms.ZTInfo.txtLoDegB.Text = txtDestLoDeg.Text;
                My.MyProject.Forms.ZTInfo.txtLoMinB.Text = txtDestLoMin.Text;
                My.MyProject.Forms.ZTInfo.cboLoB.Text = cboDestLo.Text;
            }
            else
            {
                My.MyProject.Forms.ZTInfo.txtLoDegB.Text = g_ZeroStr;
                My.MyProject.Forms.ZTInfo.txtLoMinB.Text = g_ZeroStr;
                My.MyProject.Forms.ZTInfo.cboLoB.Text = CommonGlobals.g_LongW;
            }

            My.MyProject.Forms.ZTInfo.Show();
            My.MyProject.Forms.ZTInfo.InvokedbyDeckLog = false;
            return;
        }

        private void CleanUp()
        {
            if (System.Windows.Forms.Application.OpenForms.OfType<FormTVMDC>().Any())
            {
                My.MyProject.Forms.FormTVMDC.Close();
            }

            if (System.Windows.Forms.Application.OpenForms.OfType<ZTInfo>().Any())
            {
                My.MyProject.Forms.ZTInfo.Close();
            }

            if (System.Windows.Forms.Application.OpenForms.OfType<DevForm>().Any())
            {
                My.MyProject.Forms.DevForm.SaveDevDataGrid();
                My.MyProject.Forms.DevForm.Close();
            }

            DataSet1.Dispose();
            return;
        }

        private void cboDisplayRows_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InitialLoad == true)
                return;
            DataGridView1.ClearSelection();
            DataGridView1.CurrentCell = null;
            DisplayDGRows();
            ResetAllScreenFields();
            DisplayCommonButtons();
            DataGridView1.Refresh();
            Refresh();
            SortingDG = false;
            return;
        }

        private void DisplayDGRows()
        {
            CurrencyManager currencyManager1;
            currencyManager1 = (CurrencyManager)BindingContext[DataSet1];
            SortingDG = true;

            // DataGridView1.ClearSelection()
            // DataGridView1.CurrentCell = Nothing
            currencyManager1.SuspendBinding();

            // All
            // Plan/Route
            // DR/GPS Track
            // Fix/WPT
            // DR/GPS/Fix/WPT

            switch (cboDisplayRows.Text.ToString())
            {
                case "All":
                    {
                        for (int x = 0, loopTo = DataGridView1.Rows.Count - 1; x <= loopTo; x++)
                        {
                            // If DataGridView1.Rows(x).Cells(LogTypeCell).Value.ToString = g_LogTypeGPS Or
                            // DataGridView1.Rows(x).Cells(LogTypeCell).Value.ToString = g_LogTypeOldGPS Or
                            // DataGridView1.Rows(x).Cells(LogTypeCell).Value.ToString = g_LogTypeDR Or
                            // DataGridView1.Rows(x).Cells(LogTypeCell).Value.ToString = g_LogTypeOldDR Or
                            // DataGridView1.Rows(x).Cells(LogTypeCell).Value.ToString = g_LogTypeFix Or
                            // DataGridView1.Rows(x).Cells(LogTypeCell).Value.ToString = g_LogTypeWayPoint Or
                            // DataGridView1.Rows(x).Cells(LogTypeCell).Value.ToString = g_LogTypePlan Or
                            // DataGridView1.Rows(x).Cells(LogTypeCell).Value.ToString = g_LogTypeOldPlan Then
                            DataGridView1.Rows[x].Visible = true;
                            ColorDisplayRow(x);
                            // Else
                            // DataGridView1.Rows(x).Visible = False
                            // End If
                        }

                        break;
                    }

                case "Fix/WPT":
                    {
                        for (int x = 0, loopTo1 = DataGridView1.Rows.Count - 1; x <= loopTo1; x++)
                        {
                            if ((DataGridView1.Rows[x].Cells[LogTypeCell].Value.ToString() ) == (g_LogTypeFix ) | (DataGridView1.Rows[x].Cells[LogTypeCell].Value.ToString() ) == (g_LogTypeWayPoint ))
                            {
                                DataGridView1.Rows[x].Visible = true;
                                ColorDisplayRow(x);
                            }
                            else
                            {
                                DataGridView1.Rows[x].Visible = false;
                            }
                        }

                        break;
                    }

                case "Plan/Route":
                    {
                        for (int x = 0, loopTo2 = DataGridView1.Rows.Count - 1; x <= loopTo2; x++)
                        {
                            if ((DataGridView1.Rows[x].Cells[LogTypeCell].Value.ToString() ) == (g_LogTypePlan ) | (DataGridView1.Rows[x].Cells[LogTypeCell].Value.ToString() ) == (g_LogTypeOldPlan ))
                            {
                                DataGridView1.Rows[x].Visible = true;
                                ColorDisplayRow(x);
                            }
                            else
                            {
                                DataGridView1.Rows[x].Visible = false;
                            }
                        }

                        break;
                    }

                case "DR/GPS Track":
                    {
                        for (int x = 0, loopTo3 = DataGridView1.Rows.Count - 1; x <= loopTo3; x++)
                        {
                            if ((DataGridView1.Rows[x].Cells[LogTypeCell].Value.ToString() ) == (g_LogTypeDR ) | (DataGridView1.Rows[x].Cells[LogTypeCell].Value.ToString() ) == (g_LogTypeOldDR ) | (DataGridView1.Rows[x].Cells[LogTypeCell].Value.ToString() ) == (g_LogTypeGPS ) | (DataGridView1.Rows[x].Cells[LogTypeCell].Value.ToString() ) == (g_LogTypeOldGPS ))
                            {
                                DataGridView1.Rows[x].Visible = true;
                                ColorDisplayRow(x);
                            }
                            else
                            {
                                DataGridView1.Rows[x].Visible = false;
                            }
                        }

                        break;
                    }

                case "DR/GPS Track/Fix/WPT":
                    {
                        for (int x = 0, loopTo4 = DataGridView1.Rows.Count - 1; x <= loopTo4; x++)
                        {
                            if ((DataGridView1.Rows[x].Cells[LogTypeCell].Value.ToString() ) == (g_LogTypeGPS ) | (DataGridView1.Rows[x].Cells[LogTypeCell].Value.ToString() ) == (g_LogTypeOldGPS ) | (DataGridView1.Rows[x].Cells[LogTypeCell].Value.ToString() ) == (g_LogTypeDR ) | (DataGridView1.Rows[x].Cells[LogTypeCell].Value.ToString() ) == (g_LogTypeOldDR ) | (DataGridView1.Rows[x].Cells[LogTypeCell].Value.ToString() ) == (g_LogTypeWayPoint ) | (DataGridView1.Rows[x].Cells[LogTypeCell].Value.ToString() ) == (g_LogTypeFix ))
                            {
                                DataGridView1.Rows[x].Visible = true;
                                ColorDisplayRow(x);
                            }
                            else
                            {
                                DataGridView1.Rows[x].Visible = false;
                            }
                        }

                        break;
                    }
            }

            currencyManager1.ResumeBinding();
            SortingDG = false;
            return;
        }

        // background and foreground colors for each type of Log Type - whether displayed in grid or for entry fields at top of form
        private Color GPSBackColor = Color.DeepSkyBlue;
        private Color GPSForeColor = Color.DarkBlue;
        private Color DRBackColor = Color.LimeGreen;
        private Color DRForeColor = Color.DarkBlue;
        private Color PlanBackColor = Color.AntiqueWhite;
        private Color PlanForeColor = Color.DarkBlue;
        private Color FixBackColor = Color.LawnGreen;
        private Color FixForeColor = Color.DarkBlue;
        private Color WPTBackColor = Color.SeaGreen;
        private Color WPTForeColor = Color.DarkBlue;
        private Color DefBackColor = Color.White;
        private Color DefForeColor = Color.DarkBlue;

        private void ColorDisplayRow(int rowin)
        {
            switch (DataGridView1.Rows[rowin].Cells[LogTypeCell].Value.ToString() )
            {
                case var @case when @case == (g_LogTypeGPS ):
                case var case1 when case1 == (g_LogTypeOldGPS ):
                    {
                        DataGridView1.Rows[rowin].DefaultCellStyle.BackColor = GPSBackColor;
                        DataGridView1.Rows[rowin].DefaultCellStyle.ForeColor = GPSForeColor;
                        break;
                    }

                case var case2 when case2 == (g_LogTypeDR ):
                case var case3 when case3 == (g_LogTypeOldDR ):
                    {
                        DataGridView1.Rows[rowin].DefaultCellStyle.BackColor = DRBackColor;
                        DataGridView1.Rows[rowin].DefaultCellStyle.ForeColor = DRForeColor;
                        break;
                    }

                case var case4 when case4 == (g_LogTypePlan ):
                case var case5 when case5 == (g_LogTypeOldPlan ):
                    {
                        DataGridView1.Rows[rowin].DefaultCellStyle.BackColor = PlanBackColor;
                        DataGridView1.Rows[rowin].DefaultCellStyle.ForeColor = PlanForeColor;
                        break;
                    }

                case var case6 when case6 == (g_LogTypeFix ):
                    {
                        DataGridView1.Rows[rowin].DefaultCellStyle.BackColor = FixBackColor;
                        DataGridView1.Rows[rowin].DefaultCellStyle.ForeColor = FixForeColor;
                        break;
                    }

                case var case7 when case7 == (g_LogTypeWayPoint ):
                    {
                        DataGridView1.Rows[rowin].DefaultCellStyle.BackColor = WPTBackColor;
                        DataGridView1.Rows[rowin].DefaultCellStyle.ForeColor = WPTForeColor;
                        break;
                    }

                default:
                    {
                        DataGridView1.Rows[rowin].DefaultCellStyle.BackColor = DefBackColor;
                        DataGridView1.Rows[rowin].DefaultCellStyle.ForeColor = DefForeColor;
                        break;
                    }
            }

            return;
        }

        private void HideCommonButtons()
        {
            linkLblNOAAVar.Visible = false;
            chkHideFirst4Col.Visible = false;
            Label14.Visible = false;
            cboDisplayRows.Visible = false;
            btnUseTVMDC.Visible = false;
            btnUseZTInfoForm.Visible = false;
            btnSaveFile.Visible = false;
            btnExit.Visible = false;
            // btnCreateReportFile.Visible = False
            btnEvalDG.Visible = false;
            btnExportGPX.Visible = false;
            btnUpdateExisting.Visible = false;
            btnDeleteSight.Visible = false;
            return;
        }

        private void DisplayCommonButtons()
        {
            if (My.MyProject.Computer.Network.IsAvailable)
            {
                linkLblNOAAVar.Visible = true;
                linkLblNOAAVar.Enabled = true;
            }

            chkHideFirst4Col.Visible = true;
            Label14.Visible = true;
            cboDisplayRows.Visible = true;
            btnUseTVMDC.Visible = true;
            btnUseZTInfoForm.Visible = true;
            btnSaveFile.Visible = true;
            btnExit.Visible = true;
            // btnCreateReportFile.Visible = True
            btnEvalDG.Visible = true;
            btnExportGPX.Visible = true;
            return;
        }

        private void chkDev_CheckedChanged(object sender, EventArgs e)
        {
            if (InitialLoad == true)
                return;
            if (chkDev.CheckState == CheckState.Checked)
            {
                txtDev.Enabled = false;
                cboDev.Enabled = false;
                txtDev.BackColor = Color.Aqua;
                // cboDev.BackColor = Color.Aqua
                My.MyProject.Forms.DevForm.Show();
                DevformLoaded = true;
                My.MyProject.Forms.DevForm.SignalDeckLog = true;
                return;
            }

            if (chkDev.CheckState == CheckState.Unchecked)
            {
                if (DevformLoaded == true)
                {
                    txtDev.Enabled = true;
                    cboDev.Enabled = true;
                    txtDev.BackColor = Color.Yellow;
                    // cboDev.BackColor = Color.Yellow
                    // DevForm.btnExit.PerformClick()
                    // DevForm.Close()
                    // DevformLoaded = False
                    return;
                }
            }

            return;
        }

        private void chkPlanGCR_CheckedChanged(object sender, EventArgs e)
        {
            // If InitialLoad = True Then Exit Sub
            // MessageBox.Show("You have changed the Convert Plan to GCR Pts selection - Now Click either the Add New or Change Existing button to make any changes in this Plan Log Entry")
        }

        private int RcdCount = 0;

        private void ProcessGCRArray()
        {
            AutoGCRMode = true;
            for (int i = 1, loopTo = Information.UBound(GCRArray); i <= loopTo; i++)
            {
                RcdCount += 1;
                // encode the Lat/Long entries in array into same encoding from saved DeckLog file 
                if (i == 1)
                {
                    UpdtRtn.PositionLatLong = "L=" + GCRArray[i - 1].LatStr + "Lo=" + GCRArray[i - 1].LongStr;
                    string LLo1 = "L=" + GCRArray[i - 1].LatStr + "Lo=" + GCRArray[i - 1].LongStr;
                    int LPos1 = LLo1.IndexOf("=", StringComparison.OrdinalIgnoreCase);
                    int LDegPos1 = LLo1.IndexOf('°');
                    int LMinPos1 = LLo1.IndexOf("'", StringComparison.OrdinalIgnoreCase);
                    int LoPos1 = LLo1.IndexOf("=", LPos1 + 1, StringComparison.OrdinalIgnoreCase);
                    int LoDegPos1 = LLo1.IndexOf('°', LDegPos1 + 1);
                    int LoMinPos1 = LLo1.IndexOf("'", LMinPos1 + 1, StringComparison.OrdinalIgnoreCase);
                    txtLDeg.Text = LLo1.Substring(LPos1 + 1, LDegPos1 - 1 - (LPos1 + 1) + 1);
                    txtLMin.Text = LLo1.Substring(LDegPos1 + 1, LMinPos1 - 1 - (LDegPos1 + 1) + 1);
                    cboL.Text = LLo1.Substring(LMinPos1 + 1, 1);
                    txtLoDeg.Text = LLo1.Substring(LoPos1 + 1, LoDegPos1 - 1 - (LoPos1 + 1) + 1);
                    txtLoMin.Text = LLo1.Substring(LoDegPos1 + 1, LoMinPos1 - 1 - (LoDegPos1 + 1) + 1);
                    cboLo.Text = LLo1.Substring(LoMinPos1 + 1, 1);
                }

                // Now Destring the encode Long & Lat into the screen fields the same as opening a file
                UpdtRtn.DestLatLongStr = "L=" + GCRArray[i].LatStr + "Lo=" + GCRArray[i].LongStr;
                string DestLLo = "L=" + GCRArray[i].LatStr + "Lo=" + GCRArray[i].LongStr;
                int LPos = DestLLo.IndexOf("=", StringComparison.OrdinalIgnoreCase);
                int LDegPos = DestLLo.IndexOf('°');
                int LMinPos = DestLLo.IndexOf("'", StringComparison.OrdinalIgnoreCase);
                int LoPos = DestLLo.IndexOf("=", LPos + 1, StringComparison.OrdinalIgnoreCase);
                int LoDegPos = DestLLo.IndexOf('°', LDegPos + 1);
                int LoMinPos = DestLLo.IndexOf("'", LMinPos + 1, StringComparison.OrdinalIgnoreCase);
                txtDestLDeg.Text = DestLLo.Substring(LPos + 1, LDegPos - 1 - (LPos + 1) + 1);
                txtDestLMin.Text = DestLLo.Substring(LDegPos + 1, LMinPos - 1 - (LDegPos + 1) + 1);
                cboDestL.Text = DestLLo.Substring(LMinPos + 1, 1);
                txtDestLoDeg.Text = DestLLo.Substring(LoPos + 1, LoDegPos - 1 - (LoPos + 1) + 1);
                txtDestLoMin.Text = DestLLo.Substring(LoDegPos + 1, LoMinPos - 1 - (LoDegPos + 1) + 1);
                // IF the destination Longitude is 0 degree 0 minutes then it is possible an E or W is not formatted by the Sailings FormSailings - take that into account in this last edit
                if (LoMinPos + 1 > DestLLo.Length - 1)
                {
                    cboDestLo.Text = CommonGlobals.g_LongW;
                }
                else
                {
                    cboDestLo.Text = DestLLo.Substring(LoMinPos + 1, 1);
                }
                // the entry distance and true course are calculated in the ProcessAddNew() subroutine, and are not entered here
                ProcessAddNew();
                // all the hard work is done in the ProcessAddNew() - go there and trace the path where AutoGCRMode = true

            }

            System.Windows.MessageBox.Show(RcdCount.ToString("##0", CultureInfo.CurrentCulture) + " Records were added to this DeckLog using Great Circle Route calculations");
            AutoGCRMode = false;
            cboLocType.SelectedIndex = 0;
            DisplayCommonButtons();
            ResetAllScreenFields();
            return;
        }

        private void LoadGCRSaved()
        {
            GCRArray = new GCRRec[Information.UBound(My.MyProject.Forms.FormSailings.GCRArray) + 1];
            for (int i = 0, loopTo = Information.UBound(My.MyProject.Forms.FormSailings.GCRArray); i <= loopTo; i++)
            {
                GCRArray[i].LongStr = My.MyProject.Forms.FormSailings.GCRArray[i].LongStr;
                GCRArray[i].LatStr = My.MyProject.Forms.FormSailings.GCRArray[i].LatStr;
                GCRArray[i].CTrue = My.MyProject.Forms.FormSailings.GCRArray[i].CTrue;
                GCRArray[i].GCRDist = My.MyProject.Forms.FormSailings.GCRArray[i].GCRDist;
            }

            // Process the captured GCR array into new Plan entries 
            ProcessGCRArray();
            // Clean out the capture GCR array in case this is done back to back 
            GCRArray = new GCRRec[1];
        }

        private void chkImportGCR_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void cboAdvType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAdvType.SelectedIndex == 0)
            {
                cboAdvHrs.ReadOnly = false;
                cboAdvMin.ReadOnly = false;
                cboAdvNm.ReadOnly = true;
                cboAdvNm.Value = 0.0m;
                cboAdvHrs.Visible = true;
                cboAdvMin.Visible = true;
                lblAdvHrMin.Visible = true;
                cboAdvNm.Visible = false;
                lblAdvNm.Visible = false;
                return;
            }

            if (cboAdvType.SelectedIndex == 1)
            {
                cboAdvHrs.ReadOnly = true;
                cboAdvMin.ReadOnly = true;
                cboAdvNm.ReadOnly = false;
                cboAdvHrs.Value = 0m;
                cboAdvMin.Value = 0m;
                cboAdvHrs.Visible = false;
                cboAdvMin.Visible = false;
                lblAdvHrMin.Visible = false;
                cboAdvNm.Visible = true;
                lblAdvNm.Visible = true;
                return;
            }
        }

        private void btnEvalDG_Click(object sender, EventArgs e)
        {
            SortDataGridonDate();
            evaluateDG();
            DisplayDGRows();
            DataGridView1.ClearSelection();
            DataGridView1.CurrentCell = null;
            DataGridView1.Refresh();
            IsUpdated = true;
            return;
        }

        private void txtCompass_TextChanged(object sender, EventArgs e)
        {
            return;
        }

        private void txtCTrue_TextChanged(object sender, EventArgs e)
        {
            return;
        }

        private void txtCompass_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If InitialLoad = True Then Exit Sub
            // If FileLoading = True Then Exit Sub
            // If DRAdvanceMode = True Then Exit Sub

            // CompassInput = True
        }

        private void txtCTrue_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If InitialLoad = True Then Exit Sub
            // If FileLoading = True Then Exit Sub
            // If DRAdvanceMode = True Then Exit Sub

            // TrueInput = True
        }
    }
}