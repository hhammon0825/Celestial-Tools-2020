using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace CelestialTools
{
    public partial class HelpV2
    {
        public HelpV2()
        {
            InitializeComponent();
            _ExitBtn.Name = "ExitBtn";
            _cboHelpList.Name = "cboHelpList";
            _btnPrintThisInfo.Name = "btnPrintThisInfo";
        }

        public struct CTHelpFile
        {
            public int ScrIdx;
            public string ScrnName;
            public string HelpFileName;
        }

        public CTHelpFile[] HelpScrnTbl;
        public string LDFname;

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadTextFiletoTxtBx(string FName, ref RichTextBox TxtBx)
        {
            TxtBx.Clear();
            System.IO.StreamReader streamToPrint;
            string line = null;
            try
            {
                streamToPrint = new System.IO.StreamReader(FName);
                try
                {
                    line = streamToPrint.ReadLine();
                    while (line is object)
                    {
                        TxtBx.AppendText(line + Constants.vbNewLine);
                        line = streamToPrint.ReadLine();
                    }
                }
                finally
                {
                    streamToPrint.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return;
        }

        private void HelpV2_Load(object sender, EventArgs e)
        {
            HelpScrnTbl = new CTHelpFile[22];
            HelpScrnTbl[0] = InitHSTbl(0, "General Celestial Tools", "GeneralTxtBx.txt");
            HelpScrnTbl[1] = InitHSTbl(1, "Sight Planning", "SightPlanTxtBx.txt");
            HelpScrnTbl[2] = InitHSTbl(2, "Sight Reduction And Fix (SRF)", "SRFixTxtBx.txt");
            HelpScrnTbl[3] = InitHSTbl(3, "Noon Sight Planning", "NoonSightTxtBx.txt");
            HelpScrnTbl[4] = InitHSTbl(4, "Alternate Sight Reduction Methods", "SRMethodsTxtBx.txt");
            HelpScrnTbl[5] = InitHSTbl(5, "Sight Log", "SightLogTxtBx.txt");
            HelpScrnTbl[6] = InitHSTbl(6, "Shared Locations", "SharedLocsTxtBx.txt");
            HelpScrnTbl[7] = InitHSTbl(7, "I&C Yellow Pages", "YellowPagesTxtBx.txt");
            HelpScrnTbl[8] = InitHSTbl(8, "Arc Time", "ArcTimeTxtBx.txt");
            HelpScrnTbl[9] = InitHSTbl(9, "Navigational Math", "NavMathTxtBx.txt");
            HelpScrnTbl[10] = InitHSTbl(10, "Degree Length", "DegLenTxtBx.txt");
            HelpScrnTbl[11] = InitHSTbl(11, "Sailings", "SailingxTxtBx.txt");
            HelpScrnTbl[12] = InitHSTbl(12, "60 DST", "SixtyDSTTxtBx.txt");
            HelpScrnTbl[13] = InitHSTbl(13, "TVMDC", "TVMDCTxtBx.txt");
            HelpScrnTbl[14] = InitHSTbl(14, "Maneuvering Board", "MoBoardTxtBx.txt");
            HelpScrnTbl[15] = InitHSTbl(15, "2/3 Bearings", "BearingsTxtBx.txt");
            HelpScrnTbl[16] = InitHSTbl(16, "Wind And Current", "WindCurrTxtBx.txt");
            HelpScrnTbl[17] = InitHSTbl(17, "Distances", "DistantcesTxtBx.txt");
            HelpScrnTbl[18] = InitHSTbl(18, "Tides", "TidesTxtBx.txt");
            HelpScrnTbl[19] = InitHSTbl(19, "Currents", "CurrentsTxtBx.txt");
            HelpScrnTbl[20] = InitHSTbl(20, "CLS Plot", "CLSPlotFormTxtBx.txt");
            HelpScrnTbl[21] = InitHSTbl(21, "Custom Plot", "CustomPlotFormTxtBx.txt");
            for (int idx = 0, loopTo = Information.UBound(HelpScrnTbl); idx <= loopTo; idx++)
                cboHelpList.Items.Add(HelpScrnTbl[idx].ScrnName);
            cboHelpList.SelectedIndex = 0;
        }

        public CTHelpFile InitHSTbl(int ScrIdx, string ScrNm, string HFName)
        {
            CTHelpFile rtn;
            rtn.ScrIdx = ScrIdx;
            rtn.ScrnName = ScrNm;
            rtn.HelpFileName = HFName;
            return rtn;
        }

        private void cboHelpList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = cboHelpList.SelectedIndex;
            LDFname = @".\HelpFiles\" + HelpScrnTbl[idx].HelpFileName.ToString();
            var argTxtBx = txtHelpInfo;
            LoadTextFiletoTxtBx(LDFname, ref argTxtBx);
            txtHelpInfo = argTxtBx;
        }

        private void btnPrintThisInfo_Click(object sender, EventArgs e)
        {
            Print_Renamed.printTxtFile1(LDFname);
        }
    }
}