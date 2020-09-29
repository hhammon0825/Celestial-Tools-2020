using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    public partial class DevForm
    {
        public DevForm()
        {
            InitializeComponent();
            _btnExit.Name = "btnExit";
            _btnSaveInput.Name = "btnSaveInput";
            _btnReset.Name = "btnReset";
            _DGDev.Name = "DGDev";
            _btnTestInterp.Name = "btnTestInterp";
            _btnOpenDev.Name = "btnOpenDev";
        }

        public string FName = "./DeviationTbl/Deviation_Table.csv";
        public bool IsUpdated = false;
        public DataSet DataSet1 = new DataSet();
        public string tablename = "Table1";
        public bool SignalDeckLog = false;

        public struct DeviationRec
        {
            public int TblCompass;
            public int TblMagnetic;
            public int TblDev;
            public string TblDevEW;
        }

        public DeviationRec[] DevTbl;

        private void FormSRF_Load(object sender, EventArgs e)
        {
            IsUpdated = false;
            // Dim DataSet1 As DataSet = New DataSet()
            DataSet1.Tables.Add(tablename);
            DataSet1.Tables[tablename].Columns.Add("Compass");
            DataSet1.Tables[tablename].Columns.Add("Magnetic");
            DataSet1.Tables[tablename].Columns.Add("Dev");
            DataSet1.Tables[tablename].Columns.Add("Dev E/W");
            DataSet1.Tables[tablename].Columns[0].MaxLength = 4;
            DataSet1.Tables[tablename].Columns[1].MaxLength = 4;
            DataSet1.Tables[tablename].Columns[2].MaxLength = 4;
            DataSet1.Tables[tablename].Columns[3].MaxLength = 3;
            DGDev.DataSource = DataSet1.Tables[0].DefaultView;
            DGDev.Columns[0].ReadOnly = true;
            DGDev.Columns[2].ReadOnly = true;
            DGDev.Columns[3].ReadOnly = true;
            DGDev.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGDev.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGDev.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGDev.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGDev.Columns[0].DefaultCellStyle.BackColor = Color.LightGray;
            DGDev.Columns[1].DefaultCellStyle.BackColor = Color.Yellow;
            DGDev.Columns[2].DefaultCellStyle.BackColor = Color.LightGray;
            DGDev.Columns[3].DefaultCellStyle.BackColor = Color.LightGray;
            ApplyDefaultValues();
            Show();
            IsUpdated = false;
            OpenDevFile();
            if (DGDev.RowCount == 0)
            {
                // if for some reason the deviation table csv file is corrupted or empty then simply apply defaults to reinit the datagrid
                var MsgBack = Interaction.MsgBox("Default Deviation_Tbl.csv has no data in it. Apply default deviation values? - Yes=Apply or No=Exit ", MsgBoxStyle.YesNo, "Input File Has No Data");
                if (MsgBack == MsgBoxResult.Yes)
                {
                    ApplyDefaultValues();
                }
                else
                {
                    Close();
                    return;
                }
            }

            DGDev.Rows[8].Cells[1].ReadOnly = true;
            DGDev.Rows[0].Cells[1].Selected = true;
            Refresh();
            return;
        }

        private void OpenDevFile()
        {
            bool ReadError = false;
            System.IO.StreamReader myStream = null;
            var openFileDialog2 = new OpenFileDialog();
            string CurrDir = System.IO.Directory.GetCurrentDirectory();
            if (IsUpdated == true)
            {
                var MsgBack = Interaction.MsgBox("Data has been updated - Save to File - Yes or No", MsgBoxStyle.YesNo, "Save Updated Data");
                if (MsgBack == MsgBoxResult.Yes)
                {
                    SaveDevDataGrid();
                    IsUpdated = false;
                }
                else
                {
                    // Exit Sub
                }
            }

            openFileDialog2.Reset();
            openFileDialog2.InitialDirectory = CurrDir + @"\DeviationTbl";
            openFileDialog2.Filter = "csv files (*.csv)|*.csv";
            openFileDialog2.Title = "Open Deviation Table File";
            openFileDialog2.FilterIndex = 2;
            openFileDialog2.RestoreDirectory = true;
            openFileDialog2.AutoUpgradeEnabled = true;
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(openFileDialog2.FileName))
                {
                    return;
                }

                DataSet1.Tables[tablename].Clear();
                ReadError = false;
                int ReadNum = 0;
                try
                {
                    myStream = new System.IO.StreamReader(openFileDialog2.FileName);
                    if (myStream is object)
                    {
                        FName = openFileDialog2.FileName;
                        string SLOpenFName = openFileDialog2.FileName;
                        txtOpenFile.Text = "Current Deviation File is: " + SLOpenFName;
                        string allData = myStream.ReadToEnd();
                        var rows = allData.Split(Conversions.ToChar(Constants.vbCrLf)); // ("\r".ToCharArray())
                        int incr1 = 0;
                        foreach (string r1 in rows)
                        {
                            string r = r1;
                            r = r.Trim(Conversions.ToChar(Constants.vbLf)).Trim();
                            r = r.Trim(Conversions.ToChar(Constants.vbLf)).Trim();
                            var items1 = r.Split(',');
                            if (!string.IsNullOrEmpty(items1[0]) & items1[0] != null)
                            {
                                DataSet1.Tables[tablename].Rows.Add(items1);
                            }

                            ReadNum += 1;
                            incr1 += 1;
                        }

                        myStream.Close();
                    }

                    openFileDialog2.Dispose();
                    myStream.Dispose();
                    DGDev.DataSource = DataSet1.Tables[0].DefaultView;
                    DGDev.ClearSelection();
                    DGDev.CurrentCell = null;
                    DGDev.Refresh();
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
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (SignalDeckLog == true)
            {
                My.MyProject.Forms.DeckLogUpdate.DevformLoaded = false;
                My.MyProject.Forms.DeckLogUpdate.chkDev.Checked = false;
            }

            if (CheckOpenWinForms("FormTVMDC") == true)
            {
                My.MyProject.Forms.FormTVMDC.FormDevTable_frmHasOpenedForBusiness = false;
                My.MyProject.Forms.FormTVMDC.chkDev.Checked = false;
            }

            SaveDevDataGrid();
            Close();
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

        // Public Sub SaveDataGrid()
        // Dim textstr As New System.Text.StringBuilder()
        // For x As Integer = 0 To DGDev.Rows.Count - 1
        // If IsNothing(DGDev.Rows(x).Cells(0).Value) = False Then
        // For v As Integer = 0 To DGDev.Columns.Count - 1
        // 'extracting cell value from 0 to 9 and add it on list
        // If v > 0 Then
        // textstr.Append(",")
        // End If
        // Dim tempstr As String = DGDev.Rows(x).Cells(v).Value.ToString()
        // tempstr = tempstr.Replace(",", "") ' remove any commas input into any field so csv file is not corrupted
        // textstr.Append(tempstr)
        // Next
        // End If
        // 'adding new line to text
        // textstr.AppendLine()
        // Next
        // IO.File.WriteAllText(FName, textstr.ToString())

        // Exit Sub
        // End Sub

        private void btnExitNoSave_Click(object sender, EventArgs e)
        {
            if (SignalDeckLog == true)
            {
                My.MyProject.Forms.DeckLogUpdate.DevformLoaded = false;
                My.MyProject.Forms.DeckLogUpdate.chkDev.Checked = false;
            }

            Close();
            return;
        }

        private void btnSaveInput_Click(object sender, EventArgs e)
        {
            SaveDevDataGrid();
            return;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ApplyDefaultValues();
            return;
        }

        private void ApplyDefaultValues()
        {
            DataSet1.Tables[tablename].Clear();
            DataSet1.Tables[tablename].Rows.Add("0", "0", "0", CommonGlobals.g_LongW);
            DataSet1.Tables[tablename].Rows.Add("45", "45", "0", CommonGlobals.g_LongW);
            DataSet1.Tables[tablename].Rows.Add("90", "90", "0", CommonGlobals.g_LongW);
            DataSet1.Tables[tablename].Rows.Add("135", "135", "0", CommonGlobals.g_LongW);
            DataSet1.Tables[tablename].Rows.Add("180", "180", "0", CommonGlobals.g_LongW);
            DataSet1.Tables[tablename].Rows.Add("225", "225", "0", CommonGlobals.g_LongW);
            DataSet1.Tables[tablename].Rows.Add("270", "270", "0", CommonGlobals.g_LongW);
            DataSet1.Tables[tablename].Rows.Add("315", "315", "0", CommonGlobals.g_LongW);
            DataSet1.Tables[tablename].Rows.Add("360", "360", "0", CommonGlobals.g_LongW);
            DGDev.Rows[0].Cells[1].Selected = true;
            IsUpdated = true;
            Refresh();
            return;
        }

        private void DGDev_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx == 8)
                return;
            int TryInt = 0;
            if (int.TryParse(Conversions.ToString(DGDev.Rows[idx].Cells[1].Value), out TryInt))
            {
                if (TryInt > 359)
                {
                    DGDev.Rows[idx].Cells[1].Selected = true;
                    ErrorMsgBox("Dev Mag Value too large - must be 0 to 359");
                    Interaction.Beep();
                    return;
                }
            }
            else
            {
                DGDev.Rows[idx].Cells[1].Selected = true;
                ErrorMsgBox("Dev Mag Value Must an Integer between 0 to 359");
                Interaction.Beep();
                return;
            }

            int tempdev = 0;  // DGDev.Rows(idx).Cells(2).Value
            tempdev = Convert.ToInt32(DGDev.Rows[idx].Cells[0].Value) - TryInt;
            if (idx == 0 & TryInt > 180)
            {
                tempdev = 360 - Math.Abs(tempdev);
            }

            DGDev.Rows[idx].Cells[2].Value = Math.Abs(tempdev).ToString("#0");
            if (tempdev < 0)
            {
                DGDev.Rows[idx].Cells[3].Value = CommonGlobals.g_LongE;
            }
            else
            {
                DGDev.Rows[idx].Cells[3].Value = CommonGlobals.g_LongW;
            }

            if (idx == 0)
            {
                DGDev.Rows[8].Cells[1].Value = DGDev.Rows[idx].Cells[1].Value;
                DGDev.Rows[8].Cells[2].Value = Math.Abs(tempdev).ToString("#0");
                DGDev.Rows[8].Cells[3].Value = DGDev.Rows[idx].Cells[3].Value;
            }

            IsUpdated = true;
            return;
        }

        private void BuildTblFromDG()
        {
            DevTbl = new DeviationRec[10];
            for (int i = 0; i <= 8; i++)
            {
                DevTbl[i].TblCompass = Convert.ToInt32(DGDev.Rows[i].Cells[0].Value);
                DevTbl[i].TblMagnetic = Convert.ToInt32(DGDev.Rows[i].Cells[1].Value);
                DevTbl[i].TblDevEW = Conversions.ToString(DGDev.Rows[i].Cells[3].Value);
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(DGDev.Rows[i].Cells[3].Value, CommonGlobals.g_LongW, false)))
                {
                    DevTbl[i].TblDev = Convert.ToInt32(DGDev.Rows[i].Cells[2].Value) * -1;
                }
                else
                {
                    DevTbl[i].TblDev = Convert.ToInt32(DGDev.Rows[i].Cells[2].Value);
                }
            }

            if (DevTbl[8].TblMagnetic < 10)
            {
                DevTbl[8].TblMagnetic += 360;
            }

            return;
        }

        public DeviationRec DevInterpolateCompass(int CompassIn)
        {
            DeviationRec RtnRec;
            RtnRec.TblCompass = 0;
            RtnRec.TblMagnetic = 0;
            RtnRec.TblDev = 0;
            RtnRec.TblDevEW = CommonGlobals.g_LongW;
            BuildTblFromDG();
            int lastIdx = 0;
            for (int i = 0; i <= 7; i++)
            {
                if (DevTbl[i].TblCompass == CompassIn)
                {
                    RtnRec.TblCompass = CompassIn;
                    RtnRec.TblMagnetic = DevTbl[i].TblMagnetic;
                    RtnRec.TblDev = DevTbl[i].TblDev;
                    RtnRec.TblDevEW = DevTbl[i].TblDevEW;
                    return RtnRec;
                    return default;
                }

                int MagCompare1 = 0;
                int MagCompare2 = 0;
                // If i = 0 And DevTbl(i).TblMagnetic > 270 Then
                // MagCompare1 = 360 - DevTbl(i).TblMagnetic
                // Else
                // MagCompare1 = DevTbl(i).TblMagnetic
                // End If
                // If i = 7 And DevTbl(i + 1).TblMagnetic > 0 And DevTbl(i + 1).TblMagnetic < 90 Then
                // MagCompare2 = 360 - DevTbl(i + 1).TblMagnetic
                // Else
                // MagCompare2 = DevTbl(i + 1).TblMagnetic
                // End If
                if (CompassIn > DevTbl[i].TblCompass & CompassIn < DevTbl[i + 1].TblCompass)
                {
                    double DeltaCinC1 = CompassIn - DevTbl[i].TblCompass;
                    double DeltaC2C1 = DevTbl[i + 1].TblCompass - DevTbl[i].TblCompass;
                    double DeltaM2M1 = DevTbl[i + 1].TblMagnetic - DevTbl[i].TblMagnetic;
                    if (i == 0 & DevTbl[i].TblMagnetic > 270)
                    {
                        DeltaM2M1 = DevTbl[i + 1].TblMagnetic + (360 - DevTbl[i].TblMagnetic);
                    }

                    if (i == 7 & DevTbl[i + 1].TblMagnetic > 0 & DevTbl[i + 1].TblMagnetic < 90)
                    {
                        DeltaM2M1 = 360 - DevTbl[i + 1].TblMagnetic + DevTbl[i].TblMagnetic;
                    }

                    double DeltaD2D1 = DevTbl[i + 1].TblDev - DevTbl[i].TblDev;
                    double DevRtn = DeltaCinC1 / DeltaC2C1 * DeltaD2D1 + DevTbl[i].TblDev;
                    double MagRtn = DeltaCinC1 / DeltaC2C1 * DeltaM2M1 + DevTbl[i].TblMagnetic;
                    if (MagRtn >= 360d)
                    {
                        MagRtn = Math.Abs(360d - MagRtn);
                    }

                    RtnRec.TblCompass = CompassIn;
                    RtnRec.TblMagnetic = Convert.ToInt32(MagRtn);
                    RtnRec.TblDev = Convert.ToInt32(Math.Round(DevRtn, 0, MidpointRounding.AwayFromZero));
                    if (DevRtn < 0d)
                    {
                        RtnRec.TblDevEW = CommonGlobals.g_LongW;
                    }
                    else
                    {
                        RtnRec.TblDevEW = CommonGlobals.g_LongE;
                    }

                    return RtnRec;
                    return default;
                }
            }

            return RtnRec;
            return default;
        }

        public DeviationRec DevInterpolateMagnetic(int MagneticIn)
        {
            DeviationRec RtnRec;
            RtnRec.TblCompass = 0;
            RtnRec.TblMagnetic = 0;
            RtnRec.TblDev = 0;
            RtnRec.TblDevEW = CommonGlobals.g_LongW;
            BuildTblFromDG();
            if (MagneticIn < DevTbl[0].TblMagnetic & DevTbl[0].TblMagnetic <= DevTbl[0].TblDev)
            {
                MagneticIn = DevTbl[0].TblMagnetic;
            }

            for (int i = 0; i <= 7; i++)
            {
                if (DevTbl[i].TblMagnetic == MagneticIn)
                {
                    RtnRec.TblCompass = DevTbl[i].TblCompass;
                    RtnRec.TblMagnetic = MagneticIn;
                    RtnRec.TblDev = DevTbl[i].TblDev;
                    RtnRec.TblDevEW = DevTbl[i].TblDevEW;
                    return RtnRec;
                    return default;
                }

                int MagCompare1 = 0;
                int MagCompare2 = 0;
                if (i == 0 & DevTbl[i].TblMagnetic > 270)
                {
                    MagCompare1 = DevTbl[i].TblMagnetic - 360;
                }
                else
                {
                    MagCompare1 = DevTbl[i].TblMagnetic;
                }

                if (i == 7 & DevTbl[i + 1].TblMagnetic > 0 & DevTbl[i + 1].TblMagnetic < 90)
                {
                    MagCompare2 = DevTbl[i + 1].TblMagnetic - 360;
                }
                else
                {
                    MagCompare2 = DevTbl[i + 1].TblMagnetic;
                }

                if (MagneticIn > MagCompare1 & MagneticIn < DevTbl[i + 1].TblMagnetic)
                {
                    double DeltaMinM1 = MagneticIn - MagCompare1;
                    double DeltaC2C1 = DevTbl[i + 1].TblCompass - DevTbl[i].TblCompass;
                    double DeltaM2M1 = MagCompare2 - MagCompare1; // DevTbl(i).TblMagnetic
                                                                  // If i = 0 And DevTbl(i).TblMagnetic > 270 Then
                                                                  // DeltaM2M1 = DevTbl(i + 1).TblMagnetic - MagCompare '(360 - DevTbl(i).TblMagnetic)
                                                                  // End If
                                                                  // If i = 7 And DevTbl(i + 1).TblMagnetic > 0 And DevTbl(i + 1).TblMagnetic < 90 Then
                                                                  // DeltaM2M1 = (360 - DevTbl(i + 1).TblMagnetic) - DevTbl(i).TblMagnetic
                                                                  // End If
                    double DeltaD2D1 = DevTbl[i + 1].TblDev - DevTbl[i].TblDev;
                    double DevRtn = DeltaMinM1 / DeltaM2M1 * DeltaD2D1 + DevTbl[i].TblDev;
                    double CompassRtn = DeltaMinM1 / DeltaM2M1 * DeltaC2C1 + DevTbl[i].TblCompass;
                    if (CompassRtn >= 360d)
                    {
                        CompassRtn = 360d - CompassRtn;
                    }

                    RtnRec.TblCompass = Convert.ToInt32(CompassRtn);
                    RtnRec.TblMagnetic = MagneticIn;
                    RtnRec.TblDev = Convert.ToInt32(Math.Round(DevRtn, 0, MidpointRounding.AwayFromZero));
                    if (DevRtn < 0d)
                    {
                        RtnRec.TblDevEW = CommonGlobals.g_LongW;
                    }
                    else
                    {
                        RtnRec.TblDevEW = CommonGlobals.g_LongE;
                    }

                    return RtnRec;
                    return default;
                }
            }

            if (MagneticIn > DevTbl[8].TblMagnetic)
            {
                double DeltaMinM1 = MagneticIn - DevTbl[0].TblMagnetic;
                double DeltaC2C1 = DevTbl[1].TblCompass - DevTbl[0].TblCompass;
                double DeltaM2M1 = DevTbl[1].TblMagnetic - (DevTbl[0].TblMagnetic - 360); // DevTbl(i).TblMagnetic
                double DeltaD2D1 = DevTbl[1].TblDev - DevTbl[0].TblDev;
                double DevRtn = DeltaMinM1 / DeltaM2M1 * DeltaD2D1 + DevTbl[0].TblDev;
                double CompassRtn = DeltaMinM1 / DeltaM2M1 * DeltaC2C1 + DevTbl[0].TblCompass;
                if (CompassRtn >= 360d)
                {
                    CompassRtn = 360d - CompassRtn;
                }

                RtnRec.TblCompass = Convert.ToInt32(CompassRtn);
                RtnRec.TblMagnetic = MagneticIn;
                RtnRec.TblDev = Convert.ToInt32(Math.Round(DevRtn, 0, MidpointRounding.AwayFromZero));
                if (DevRtn < 0d)
                {
                    RtnRec.TblDevEW = CommonGlobals.g_LongW;
                }
                else
                {
                    RtnRec.TblDevEW = CommonGlobals.g_LongE;
                }

                return RtnRec;
            }

            return RtnRec;
            return default;
        }

        private void ErrorMsgBox(string ErrMsg)
        {
            MessageBox.Show(ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            return;
        }

        private void btnTestInterp_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.TestDev.Show();
            return;
        }

        private void btnOpenDev_Click(object sender, EventArgs e)
        {
            OpenDevFile();
        }

        public void SaveDevDataGrid()
        {
            if (IsUpdated == false)
                return;
            var saveFileDialog1 = new SaveFileDialog();

            // Dim dirstr As String = FileIO.FileSystem.CurrentDirectory
            saveFileDialog1.InitialDirectory = "./DeviationTbl/";
            saveFileDialog1.Filter = "csv files (*.csv)|*.csv";
            saveFileDialog1.Title = "Save Deviation Table File";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(saveFileDialog1.FileName))
                {
                    return;
                }

                FName = saveFileDialog1.FileName;
            }

            var textstr = new System.Text.StringBuilder();
            for (int x = 0, loopTo = DGDev.Rows.Count - 1; x <= loopTo; x++)
            {
                if (Information.IsNothing(DGDev.Rows[x].Cells[0].Value) == false)
                {
                    for (int v = 0, loopTo1 = DGDev.Columns.Count - 1; v <= loopTo1; v++)
                    {
                        // extracting cell value from 0 to 9 and add it on list
                        if (v > 0)
                        {
                            textstr.Append(",");
                        }

                        string tempstr = DGDev.Rows[x].Cells[v].Value.ToString();
                        tempstr = tempstr.Replace(",", ""); // remove any commas input into any field so csv file is not corrupted
                        textstr.Append(tempstr);
                    }
                }
                // adding new line to text
                textstr.AppendLine();
            }

            System.IO.File.WriteAllText(FName, textstr.ToString());
            txtOpenFile.Text = "Open and Saved File Name is: " + FName;
            return;
        }
    }
}