using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    public partial class ZTInfo
    {
        public ZTInfo()
        {
            InitializeComponent();
            _cboLocAZD.Name = "cboLocAZD";
            _ExitBtn.Name = "ExitBtn";
            _btnCalc.Name = "btnCalc";
            _btnClearFields.Name = "btnClearFields";
            _btnReloadZT.Name = "btnReloadZT";
            _cboLocBZD.Name = "cboLocBZD";
        }

        public bool InvokedbyDeckLog = false;
        private System.Collections.ObjectModel.ReadOnlyCollection<TimeZoneInfo> LocACollection;
        private TimeZoneInfo[] LongTZInfo;
        private readonly string ZeroVal = "0";
        private readonly string tablename = "Table1";
        private DataSet DataSet1;
        private readonly string[] HdrStr = new[] { "Display Name", "UTC Hours", "UTC Minutes", "Supports DST", "DST Name" };
        private readonly string[] NullStr = new[] { Constants.vbNullString, Constants.vbNullString, Constants.vbNullString, Constants.vbNullString, Constants.vbNullString };

        private void ZTInfo_Load(object sender, EventArgs e)
        {
            LocACollection = TimeZoneInfo.GetSystemTimeZones();
            LongTZInfo = new TimeZoneInfo[1];
            foreach (TimeZoneInfo TZT in LocACollection) // TimeZoneInfo.GetSystemTimeZones
            {
                int unused = cboLocAZD.Items.Add(TZT);
                int unused1 = cboLocBZD.Items.Add(TZT);
            }

            if (InvokedbyDeckLog == false)
            {
                ClearFields();
            }
            else
            {
                FillZTGrid();
                // if ZT Info is invoked by DeckLog then the cboLoA abd cboLoB were set by DeckLog and should not be reset here - the add/subtract default of + is fine
                // cboLoA.SelectedIndex = 0
                // cboLoB.SelectedIndex = 0
                cboAddSub.SelectedIndex = 0;
            }

            return;
        }

        private void ClearFields()
        {
            txtLoDegA.Text = ZeroVal;
            txtLoMinA.Text = ZeroVal;
            txtLoDegB.Text = ZeroVal;
            txtLoMinB.Text = ZeroVal;
            cboLoA.SelectedIndex = 0;
            cboLoB.SelectedIndex = 0;
            cboAddSub.SelectedIndex = 0;
            DTLocA.Value = DateTime.Now;
            DTResult.Value = DateTime.Now;
            DTLocAUTC.Value = DateTime.Now;
            txtLocAZTInfo.Clear();
            txtLocBZTInfo.Clear();
            DT1Days.Value = 0m;
            DT1Hours.Value = 0m;
            DT1Minutes.Value = 0m;
            FillZTGrid();
            return;
        }

        private TimeZoneInfo[] CnvtLongtoTZInfo(double LongIn)
        {
            int LongDegIn = (int)Conversion.Int(LongIn);
            double LongMinIN = LongIn - LongDegIn;
            int ZDLongIn = (int)Math.Round(LongIn / 15d, 0, MidpointRounding.AwayFromZero);
            LongTZInfo = new TimeZoneInfo[1];
            foreach (TimeZoneInfo TZT in LocACollection) // TimeZoneInfo.GetSystemTimeZones
            {
                if (TZT.BaseUtcOffset.Hours == ZDLongIn)
                {
                    int UL = LongTZInfo.GetUpperBound(0);
                    Array.Resize(ref LongTZInfo, UL + 1 + 1);
                    LongTZInfo[UL + 1] = TZT;
                }
            }

            return LongTZInfo;
        }

        private void FillZTGrid()
        {
            DataSet1 = new DataSet();
            var unused = DataSet1.Tables.Add(tablename);
            DataSet1.DataSetName = tablename;
            DGTZ.DataSource = DataSet1;
            for (int i = 0, loopTo = Information.UBound(HdrStr); i <= loopTo; i++)
            {
                var unused1 = DataSet1.Tables[tablename].Columns.Add(HdrStr[i]);
                DataSet1.Tables[tablename].Columns[i].AllowDBNull = false;
                DataSet1.Tables[tablename].Columns[i].DefaultValue = "";
            }

            var unused2 = DataSet1.Tables[tablename].Rows.Add(NullStr);
            // DataSet1.Tables(tablename).Rows.RemoveAt(0)
            DGTZ.DataSource = DataSet1.Tables[0].DefaultView;
            for (int i = 0, loopTo1 = DGTZ.Columns.Count - 1; i <= loopTo1; i++)
            {
                DGTZ.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DGTZ.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                DGTZ.Columns[i].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                DGTZ.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            DGTZ.RowHeadersDefaultCellStyle.BackColor = Color.Yellow;
            DataSet1.Tables[tablename].Clear();
            foreach (TimeZoneInfo TZ in LocACollection)
                DataSet1.Tables[tablename].Rows.Add(TZ.DisplayName, TZ.BaseUtcOffset.Hours.ToString("00"), TZ.BaseUtcOffset.Minutes.ToString("00"), TZ.SupportsDaylightSavingTime.ToString(), TZ.DaylightName);
            DGTZ.Refresh();
            return;
        }

        private void CbLocAZD_MouseEnter(object sender, EventArgs e)
        {
            TimeZoneInfo[] TZList;
            double LoA = Convert.ToDouble(txtLoDegA.Text) + Convert.ToDouble(txtLoMinA.Text) / 60d;
            if (cboLoA.Text == "W")
            {
                LoA = -LoA;
            }

            TZList = CnvtLongtoTZInfo(LoA);
            cboLocAZD.Items.Clear();
            foreach (TimeZoneInfo TZ in TZList)
            {
                if (Information.IsNothing(TZ))
                {
                }
                // ignore first nothing entry in array
                else
                {
                    int unused = cboLocAZD.Items.Add(TZ.DisplayName);
                }
            }

            cboLocAZD.SelectedIndex = 0;
            Refresh();
            return;
        }

        private void CbLocBZone_MouseEnter(object sender, EventArgs e)
        {
            TimeZoneInfo[] TZList;
            double LoB = Convert.ToDouble(txtLoDegB.Text) + Convert.ToDouble(txtLoMinB.Text) / 60d;
            if (cboLoB.Text == "W")
            {
                LoB = -LoB;
            }

            TZList = CnvtLongtoTZInfo(LoB);
            cboLocBZD.Items.Clear();
            foreach (TimeZoneInfo TZ in TZList)
            {
                if (Information.IsNothing(TZ))
                {
                }
                // ignore first nothing entry in array
                else
                {
                    int unused = cboLocBZD.Items.Add(TZ.DisplayName);
                }
            }

            cboLocBZD.SelectedIndex = 0;
            Refresh();
            return;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            if (InvokedbyDeckLog == true)
            {
                InvokedbyDeckLog = false;
                My.MyProject.Forms.DeckLogUpdate.DestDTUpdatedbyZTInfo = true;
            }

            Close();
            return;
        }

        private void BtnReloadZT_Click(object sender, EventArgs e)
        {
            LocACollection = TimeZoneInfo.GetSystemTimeZones();
            FillZTGrid();
            return;
        }

        private string FindZTID(object StrIn)
        {
            foreach (TimeZoneInfo TZ in LocACollection)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(TZ.DisplayName, StrIn, false)))
                {
                    return TZ.Id;
                }
            }

            return "-1";
        }

        private void CboLocAZD_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtLocAZTInfo.Clear();
            var TZA = TimeZoneInfo.FindSystemTimeZoneById(FindZTID(cboLocAZD.Text));
            txtLocAZTInfo.AppendText("UTC Offset Hr: " + TZA.BaseUtcOffset.Hours.ToString("00") + " Min: " + TZA.BaseUtcOffset.Minutes.ToString("00") + Constants.vbCrLf + "Standard Name: " + TZA.StandardName.ToString() + Constants.vbCrLf + "DST Support: " + TZA.SupportsDaylightSavingTime.ToString() + Constants.vbCrLf + "UTC Offset: " + TZA.GetUtcOffset(DTLocA.Value).ToString());
            var DTTemp = new DateTime(DTLocA.Value.Ticks, DateTimeKind.Unspecified);
            DTLocAUTC.Value = TimeZoneInfo.ConvertTimeToUtc(DTTemp, TZA);
            if (!string.IsNullOrEmpty(cboLocBZD.Text))
            {
                PerformEditClick();
            }
        }

        private void CboLocBZD_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtLocBZTInfo.Clear();
            var TZB = TimeZoneInfo.FindSystemTimeZoneById(FindZTID(cboLocBZD.Text));
            txtLocBZTInfo.AppendText("UTC Offset Hr: " + TZB.BaseUtcOffset.Hours.ToString("00") + " Min: " + TZB.BaseUtcOffset.Minutes.ToString("00") + Constants.vbCrLf + "Standard Name: " + TZB.StandardName.ToString() + Constants.vbCrLf + "DST Support: " + TZB.SupportsDaylightSavingTime.ToString() + Constants.vbCrLf + "UTC Offset: " + TZB.GetUtcOffset(DTResult.Value).ToString());
            PerformEditClick();
            return;
        }

        private object DestDT(TimeZoneInfo TZAIn, DateTime DTAIn, TimeSpan TSIn, TimeZoneInfo TZBIn)
        {
            if (cboAddSub.Text == "+")
            {
                var DTTSAdd = new DateTime(DTAIn.AddMinutes(TSIn.TotalMinutes).Ticks, DateTimeKind.Unspecified);
                return TimeZoneInfo.ConvertTime(DTTSAdd, TZAIn, TZBIn);
            }
            else
            {
                var DTTSSubt = new DateTime(DTAIn.AddMinutes(-1 * TSIn.TotalMinutes).Ticks, DateTimeKind.Unspecified);
                return TimeZoneInfo.ConvertTime(DTTSSubt, TZAIn, TZBIn);
            }

            var DTTSAdd1 = new DateTime(DTAIn.AddMinutes(TSIn.TotalMinutes).Ticks, DateTimeKind.Unspecified);
            return TimeZoneInfo.ConvertTime(DTTSAdd1, TZAIn, TZBIn);
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            PerformEditClick();
            return;
        }

        private void PerformEditClick()
        {
            if (EditFields() == true)
            {
                var TS = new TimeSpan(Convert.ToInt32(DT1Days.Value), Convert.ToInt32(DT1Hours.Value), Convert.ToInt32(DT1Minutes.Value), 0);
                var TZA = TimeZoneInfo.FindSystemTimeZoneById(FindZTID(cboLocAZD.Text));
                var TZB = TimeZoneInfo.FindSystemTimeZoneById(FindZTID(cboLocBZD.Text));
                DTResult.Value = Conversions.ToDate(DestDT(TZA, DTLocA.Value, TS, TZB));
                if (InvokedbyDeckLog == true)
                {
                    My.MyProject.Forms.DeckLogUpdate.DestDTUpdatedbyZTInfo = true;
                    My.MyProject.Forms.DeckLogUpdate.DestDTfromZTInfo = DTResult.Value;
                }
            }

            return;
        }

        private bool EditFields()
        {
            if (string.IsNullOrEmpty(txtLoDegA.Text) | string.IsNullOrEmpty(txtLoDegA.Text))
            {
                ErrorMsgBox("Longitude Degrees must be entered");
                return false;
            }

            if (Information.IsNumeric(txtLoDegA.Text) == false)
            {
                ErrorMsgBox("Longitude Degrees must be numeric between 0 and 89");
                return false;
            }

            try
            {
                int LoDegI = Convert.ToInt32(txtLoDegA.Text);
                if (LoDegI < 0 | LoDegI > 180)
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

            if (string.IsNullOrEmpty(txtLoMinA.Text) | string.IsNullOrEmpty(txtLoMinA.Text))
            {
                ErrorMsgBox("Longitude Minutes must be entered");
                return false;
            }

            if (Information.IsNumeric(txtLoMinA.Text) == false)
            {
                ErrorMsgBox("Longitude Minutes be numeric between 0 and 59.9");
                return false;
            }

            try
            {
                double LoMinI = Convert.ToDouble(txtLoMinA.Text);
                string LoEW = cboLoA.Text;
                if (LoMinI < 0d | LoMinI > 59.9d)
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

            if (string.IsNullOrEmpty(txtLoDegB.Text) | string.IsNullOrEmpty(txtLoDegB.Text))
            {
                ErrorMsgBox("Longitude Degrees must be entered");
                return false;
            }

            if (Information.IsNumeric(txtLoDegB.Text) == false)
            {
                ErrorMsgBox("Longitude Degrees must be numeric between 0 and 89");
                return false;
            }

            try
            {
                int LoDegI = Convert.ToInt32(txtLoDegB.Text);
                if (LoDegI < 0 | LoDegI > 180)
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

            if (string.IsNullOrEmpty(txtLoMinB.Text) | string.IsNullOrEmpty(txtLoMinB.Text))
            {
                ErrorMsgBox("Longitude Minutes must be entered");
                return false;
            }

            if (Information.IsNumeric(txtLoMinB.Text) == false)
            {
                ErrorMsgBox("Longitude Minutes be numeric between 0 and 59.9");
                return false;
            }

            try
            {
                double LoMinI = Convert.ToDouble(txtLoMinB.Text);
                string LoEW = cboLoA.Text;
                if (LoMinI < 0d | LoMinI > 59.9d)
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

            if (string.IsNullOrEmpty(cboLocAZD.Text))
            {
                ErrorMsgBox("Time Zone selection is missing - Select a Time Zone and Proceed");
                return false;
            }

            if (string.IsNullOrEmpty(cboLocBZD.Text))
            {
                ErrorMsgBox("Time Zone selection is missing - Select a Time Zone and Proceed");
                return false;
            }

            return true;
        }

        private void ErrorMsgBox(string ErrMsg)
        {
            var unused = MessageBox.Show(ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            return;
        }

        private void BtnClearFields_Click(object sender, EventArgs e)
        {
            ClearFields();
            LongTZInfo = new TimeZoneInfo[1];
            cboLocAZD.Items.Clear();
            cboLocBZD.Items.Clear();
            foreach (TimeZoneInfo TZT in LocACollection) // TimeZoneInfo.GetSystemTimeZones
            {
                int unused = cboLocAZD.Items.Add(TZT);
                int unused1 = cboLocBZD.Items.Add(TZT);
            }

            return;
        }
    }
}