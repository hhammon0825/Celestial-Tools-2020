using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    public partial class FixDG
    {
        public FixDG()
        {
            InitializeComponent();
            _DGFix.Name = "DGFix";
            _ExitBtn.Name = "ExitBtn";
            _btnPrint.Name = "btnPrint";
            _btnUseCLS.Name = "btnUseCLS";
            _btnCustomPlot.Name = "btnCustomPlot";
        }

        private double Pi = Math.PI;
        private double DegtoRad = Math.PI / 180d;
        private double RadtoDeg = 180d / Math.PI;
        private short i, IL, IV, FixIL;
        private double TimeOfFix;
        private bool[] XSelected = new bool[14];
        private double[] XZH = new double[14];
        private double[] XZM = new double[14];
        private double[] XZS = new double[14];
        private double[] XZT = new double[14];
        private double[] XZN = new double[14];
        private double[] XMI = new double[14];
        private double[] DZT = new double[14];
        private double[] DL = new double[14];
        private double[] DLo = new double[14];
        private double[] XLD = new double[14];
        private double[] XLM = new double[14];
        private double[] XMD = new double[14];
        private double[] XMM = new double[14];
        private double[] XL = new double[14];
        private double[] XLo = new double[14];
        private double[] XBF = new double[14];
        private double[] XD = new double[14];
        private double[] XLA = new double[14];
        private double[] XM = new double[14];
        private double[] XGHA = new double[14];          // added in V5.6.1
        private double[] XDec = new double[14];          // added in V5.6.1
        private double[] XHo = new double[14];        // added in V5.6.1
        private double[] AF = new double[14];
        private string[] EP = new string[14];
        private DateTime[] XDTSight = new DateTime[14];
        private double EX, CX, AX, BX, DX, GX;
        private double BI, BF, LI, LF, BD, DF, BM;
        private double FD;
        private double FM;
        private string LH, BH;
        private short IA, II;
        private double CourseAngleDeg, Lm, LatDiff, LongDiff, CourseAngle, Course;
        // Following variables added for changes for 5.6.1 for LoC subroutine
        private double L;
        private double Lo;
        private double GHA;
        private double DE;
        private double Ho;
        private double LHA;
        private double L1, L2, L3, L4, L5, L6, L7, L8;
        private double A, Z, ZN;
        private double Hc;
        public bool CalcFixError = false;

        public struct SFixData
        {
            public bool SightSelect;
            public double SFZH;
            public double SFZM;
            public double SFZS;
            public double SFMI;
            public double SFZN;
            public string SFLD;
            public string SFLM;
            public double SFL;
            public double SFMD;
            public double SFMM;
            public string SFM;
            public double SFZT;
            public double SFUT;
            public string sFD;
            public string SBF;
            public string sFLA;
            public double SFLo;
            public double SFGHA;
            public double SFDec;
            public double SFHo;
            public DateTime SDTSight;
            public string SEP;
        }

        public int IUPass;
        public int SelectedFix = 0;
        private bool FormLoaded = false;
        public SFixData[] FixDataArray = new SFixData[14];
        public CLSForm.PlotEntry PlotOut;

        private void FixDG_Load(object sender, EventArgs e)
        {
            InitLocalFixArray();
            // txtFixCalc.Clear()
            DGFix.Rows.Clear();
            IV = (short)IUPass;
            btnUseCLS.Visible = true;
            btnCustomPlot.Visible = true;
            WriteFixScreen();
            FormLoaded = true;
            return;
        }

        private void InitLocalFixArray()
        {
            for (i = 0; i <= 12; i++)
            {
                XSelected[i] = false;
                XZH[i] = 0d;
                XZM[i] = 0d;
                XZS[i] = 0d;
                XZT[i] = 0d;
                XZN[i] = 0d;
                XMI[i] = 0d;
                DZT[i] = 0d;
                DL[i] = 0d;
                DLo[i] = 0d;
                XLD[i] = 0d;
                XLM[i] = 0d;
                XMD[i] = 0d;
                XMM[i] = 0d;
                XL[i] = 0d;
                XLo[i] = 0d;
                XBF[i] = 0d;
                XD[i] = 0d;
                XLA[i] = 0d;
                XM[i] = 0d;
                XGHA[i] = 0d;
                XDec[i] = 0d;
                XHo[i] = 0d;
                AF[i] = 0d;
                EP[i] = "";
            }

            return;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            if (CheckOpenWinForms("CLSForm") == true)
            {
                My.MyProject.Forms.CLSForm.ExitBtn.PerformClick();
            }

            Close();
            return;
        }

        public bool CheckOpenWinForms(string FormNameIn)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name.Equals(FormNameIn))
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
            if (CheckOpenWinForms("CLSForm") == true)
            {
                My.MyProject.Forms.CLSForm.ExitBtn.PerformClick();
            }

            string TempTA = "T";
            int SaveI = 0;
            var loopTo = IL;
            for (i = 1; i <= loopTo; i++)
            {
                if (XSelected[i] == true)
                {
                    PlotOut.PsnName = "CLS Plot Fix";
                    PlotOut.SquadronName = "CLS Plot Fix";
                    PlotOut.PlotType = "FixSight";
                    PlotOut.PlotNumber = i.ToString("##0");
                    PlotOut.PlotDT = FixDataArray[i].SDTSight;
                    PlotOut.PlotBody = FixDataArray[i].SBF;
                    PlotOut.PlotLat = FixDataArray[i].SFL;
                    PlotOut.PlotLatDeg = FixDataArray[i].SFLD;
                    PlotOut.PlotLatMin = FixDataArray[i].SFLM;
                    PlotOut.PlotLatSec = "0";
                    PlotOut.PlotLatNS = FixDataArray[i].sFLA.Trim();
                    PlotOut.PlotLong = FixDataArray[i].SFLo;
                    PlotOut.PlotLongDeg = FixDataArray[i].SFMD.ToString("##0");
                    PlotOut.PlotLongMin = FixDataArray[i].SFMM.ToString("00.0");
                    PlotOut.PlotLongSec = "0";
                    if (FixDataArray[i].SFM == null)
                    {
                        PlotOut.PlotLongEW = Constants.vbNullString;
                    }
                    else
                    {
                        PlotOut.PlotLongEW = FixDataArray[i].SFM.Trim();
                    }
                    // PlotOut.PlotLongEW = FixDataArray(i).SFM.Trim

                    PlotOut.PlotAz = FixDataArray[i].SFZN.ToString("000") + '°';
                    TempTA = " Towards";
                    if (FixDataArray[i].SFMI > 0d)
                    {
                        TempTA = "Away";
                    }

                    PlotOut.PlotIntercept = Math.Abs(FixDataArray[i].SFMI).ToString("##0.0") + " nm " + TempTA;
                    PlotOut.PlotSLEP = FixDataArray[i].SEP; // "Fix Sight" & PlotOut.PlotNumber & " on " & FixDataArray(i).SDTSight.ToString("MM/dd/yyy HH:mm:ss")
                    PlotOut.PlotExtendedLines = true;
                    My.MyProject.Forms.CLSForm.AddPlotEntry(PlotOut);
                    SaveI = i;
                }
            }

            PlotOut.PsnName = "CLS Plot Fix";
            PlotOut.SquadronName = "CLS Plot Fix";
            PlotOut.PlotType = "Fix";
            PlotOut.PlotNumber = (SaveI + 1).ToString("##0");
            PlotOut.PlotDT = FixDataArray[FixIL].SDTSight;
            PlotOut.PlotBody = "Fix";
            PlotOut.PlotLat = BD + BM / 60d;
            PlotOut.PlotLatDeg = BD.ToString("#0");
            PlotOut.PlotLatMin = BM.ToString("00.0");
            PlotOut.PlotLatSec = "0";
            PlotOut.PlotLatNS = BH;
            PlotOut.PlotLong = FD + FM / 60d;
            PlotOut.PlotLongDeg = FD.ToString("##0");
            PlotOut.PlotLongMin = FM.ToString("00.0");
            PlotOut.PlotLongSec = "0";
            PlotOut.PlotLongEW = LH;
            TempTA = " Towards";
            if (DF > 0d)
            {
                TempTA = " Away";
            }

            PlotOut.PlotAz = Course.ToString("000") + '°';
            PlotOut.PlotIntercept = Math.Abs(DF).ToString("##0.0") + " nm " + TempTA;
            PlotOut.PlotSLEP = "Fix at ZT " + Strings.Format(XZH[FixIL], "00") + "-" + Strings.Format(XZM[FixIL], "00") + "-" + Strings.Format(XZS[FixIL], "00") + " Loc = " + Strings.Format(BD, "#0") + '°' + Strings.Format(BM, "00.0") + "'" + BH + " " + Strings.Format(FD, "##0") + '°' + Strings.Format(FM, "00.0") + "'" + LH + " " + "a= " + Strings.Format(DF, "##0.0") + TempTA + " Zn= " + Strings.Format(Course, "000") + '°';
            My.MyProject.Forms.CLSForm.AddPlotEntry(PlotOut);
            My.MyProject.Forms.CLSForm.txtUserInfo.Text = txtUserInfo.Text;
            if (My.MyProject.Forms.CLSForm.PlotSight() == true)
            {
                My.MyProject.Forms.CLSForm.Show();
                My.MyProject.Forms.CLSForm.SetDesktopLocation(5, 5); // 
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

        private void btnCustomPlot_Click(object sender, EventArgs e)
        {
            if (CheckOpenWinForms("CustomPlot") == true)
            {
                My.MyProject.Forms.CustomPlot.ExitBtn.PerformClick();
            }

            string TempTA = "T";
            int SaveI = 0;
            var loopTo = IL;
            for (i = 1; i <= loopTo; i++)
            {
                if (XSelected[i] == true)
                {
                    PlotOut.PsnName = "Custom Plot Fix";
                    PlotOut.SquadronName = "Custom Plot Fix";
                    PlotOut.PlotType = "FixSight";
                    PlotOut.PlotNumber = i.ToString("##0");
                    PlotOut.PlotDT = FixDataArray[i].SDTSight;
                    PlotOut.PlotBody = FixDataArray[i].SBF;
                    PlotOut.PlotLat = FixDataArray[i].SFL;
                    PlotOut.PlotLatDeg = FixDataArray[i].SFLD;
                    PlotOut.PlotLatMin = FixDataArray[i].SFLM;
                    PlotOut.PlotLatSec = "0";
                    PlotOut.PlotLatNS = FixDataArray[i].sFLA.Trim();
                    PlotOut.PlotLong = FixDataArray[i].SFLo;
                    PlotOut.PlotLongDeg = FixDataArray[i].SFMD.ToString("##0");
                    PlotOut.PlotLongMin = FixDataArray[i].SFMM.ToString("00.0");
                    PlotOut.PlotLongSec = "0";
                    if (FixDataArray[i].SFM == null)
                    {
                        PlotOut.PlotLongEW = Constants.vbNullString;
                    }
                    else
                    {
                        PlotOut.PlotLongEW = FixDataArray[i].SFM.Trim();
                    }
                    // PlotOut.PlotLongEW = FixDataArray(i).SFM.Trim

                    PlotOut.PlotAz = FixDataArray[i].SFZN.ToString("000") + '°';
                    TempTA = " Towards";
                    if (FixDataArray[i].SFMI > 0d)
                    {
                        TempTA = "Away";
                    }

                    PlotOut.PlotIntercept = Math.Abs(FixDataArray[i].SFMI).ToString("##0.0") + " nm " + TempTA;
                    PlotOut.PlotExtendedLines = true;
                    PlotOut.PlotSLEP = FixDataArray[i].SEP; // "Fix Sight" & PlotOut.PlotNumber & " on " & FixDataArray(i).SDTSight.ToString("MM/dd/yyy HH:mm:ss")
                    My.MyProject.Forms.CustomPlot.AddPlotEntry(PlotOut);
                    SaveI = i;
                }
            }

            PlotOut.PsnName = "Custom Plot Fix";
            PlotOut.SquadronName = "Custom Plot Fix";
            PlotOut.PlotType = "Fix";
            PlotOut.PlotNumber = (SaveI + 1).ToString("##0");
            PlotOut.PlotDT = FixDataArray[FixIL].SDTSight;
            PlotOut.PlotBody = "Fix";
            PlotOut.PlotLat = BD + BM / 60d;
            PlotOut.PlotLatDeg = BD.ToString("#0");
            PlotOut.PlotLatMin = BM.ToString("00.0");
            PlotOut.PlotLatSec = "0";
            PlotOut.PlotLatNS = BH;
            PlotOut.PlotLong = FD + FM / 60d;
            PlotOut.PlotLongDeg = FD.ToString("##0");
            PlotOut.PlotLongMin = FM.ToString("00.0");
            PlotOut.PlotLongSec = "0";
            PlotOut.PlotLongEW = LH;
            TempTA = " Towards";
            if (DF > 0d)
            {
                TempTA = " Away";
            }

            PlotOut.PlotAz = Course.ToString("000") + '°';
            PlotOut.PlotIntercept = Math.Abs(DF).ToString("##0.0") + " nm " + TempTA;
            PlotOut.PlotSLEP = "Fix at ZT " + Strings.Format(XZH[FixIL], "00") + "-" + Strings.Format(XZM[FixIL], "00") + "-" + Strings.Format(XZS[FixIL], "00") + " Loc = " + Strings.Format(BD, "#0") + '°' + Strings.Format(BM, "00.0") + "'" + BH + " " + Strings.Format(FD, "##0") + '°' + Strings.Format(FM, "00.0") + "'" + LH + " " + "a= " + Strings.Format(DF, "##0.0") + TempTA + " Zn= " + Strings.Format(Course, "000") + '°';
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
                // If CheckOpenWinForms("CLSForm") = True Then
                // CLSForm.ExitBtn.PerformClick()
                // End If
            }

            return;
        }

        private void DGFix_SelectionChanged(object sender, EventArgs e)
        {
            if (FormLoaded == false)
                return;
            int n = DGFix.CurrentRow.Index;
            // The order of these variable and the integer indexs contained in each MUST match the order of the fields in the data grid
            int SelIndex = Convert.ToInt32(DGFix.Rows[n].Cells[1].Value);
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(DGFix.CurrentRow.Cells[0].Value, true, false)))
            {
                FixDataArray[SelIndex].SightSelect = false;
                XSelected[SelIndex] = false;
                DGFix.CurrentRow.Cells[0].Value = false;
            }
            else
            {
                FixDataArray[SelIndex].SightSelect = true;
                XSelected[SelIndex] = true;
                DGFix.CurrentRow.Cells[0].Value = true;
            }

            int temp = 0;
            var loopTo = (short)IUPass;
            for (i = 1; i <= loopTo; i++)
            {
                if (XSelected[i] == true)
                {
                    temp += 1;
                    // restore the original ZN and Intercept in the event an item has been deselected and a prior 3 body sight was done
                    XZH[i] = FixDataArray[i].SFZH;
                    XZM[i] = FixDataArray[i].SFZM;
                    XZS[i] = FixDataArray[i].SFZS;
                    XZT[i] = XZH[i] + XZM[i] / 60d + XZS[i] / 3600d;
                    XZN[i] = FixDataArray[i].SFZN;
                    XMI[i] = FixDataArray[i].SFMI;
                    XL[i] = FixDataArray[i].SFL;
                    XLo[i] = FixDataArray[i].SFLo;
                    XGHA[i] = FixDataArray[i].SFGHA;
                    XDec[i] = FixDataArray[i].SFDec;
                    XHo[i] = FixDataArray[i].SFHo;
                    XDTSight[i] = FixDataArray[i].SDTSight;
                    EP[i] = FixDataArray[i].SEP;
                }
            }

            if (temp < 2)
            {
                ErrorMsgBox("Selection Rejected - At least two sights must be selected", "Selection Rejected - Too Few Sights Selected", MessageBoxButtons.OK);
                FixDataArray[SelIndex].SightSelect = true;
                XSelected[SelIndex] = true;
                DGFix.CurrentRow.Cells[0].Value = true;
                DGFix.Refresh();
                Refresh();
                return;
            }

            CalculateFix();
            DGFix.Refresh();
            Refresh();
            return;
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            Print_Renamed.PrintScreen(Bounds);
        }

        private void WriteFixScreen()
        {
            // load up fix data from SRF1 form into Form4 / Fix form
            IV = (short)IUPass;
            for (int IW = 1, loopTo = IV; IW <= loopTo; IW++)
            {
                i = (short)IW;
                DGFix.Rows.Add(true, IW.ToString(), FixDataArray[IW].SBF, Strings.Format(FixDataArray[IW].SFZH, "00") + "-" + Strings.Format(FixDataArray[IW].SFZM, "00") + "-" + Strings.Format(FixDataArray[IW].SFZS, "00"), Strings.Format(Math.Abs(FixDataArray[IW].SFMI), "0.0") + " " + FixDataArray[IW].sFD, Strings.Format(FixDataArray[IW].SFZN, "000") + '°', Strings.Format(Conversion.Val(FixDataArray[IW].SFLD), "00") + '°' + Strings.Format(Conversion.Val(FixDataArray[IW].SFLM), "00.0") + "'" + FixDataArray[IW].sFLA, Strings.Format(Conversion.Val(FixDataArray[IW].SFMD), "##0") + '°' + Strings.Format(Conversion.Val(FixDataArray[IW].SFMM), "00.0") + "'" + FixDataArray[IW].SFM);
                FixDataArray[IW].SightSelect = true;
                XSelected[IW] = true;
                XZH[IW] = FixDataArray[IW].SFZH;
                XZM[IW] = FixDataArray[IW].SFZM;
                XZS[IW] = FixDataArray[IW].SFZS;
                XZT[IW] = XZH[IW] + XZM[IW] / 60d + XZS[IW] / 3600d;
                XZN[IW] = FixDataArray[IW].SFZN;
                XMI[IW] = FixDataArray[IW].SFMI;
                XL[IW] = FixDataArray[IW].SFL;
                XLo[IW] = FixDataArray[IW].SFLo;
                XGHA[IW] = FixDataArray[IW].SFGHA;
                XDec[IW] = FixDataArray[IW].SFDec;
                XHo[IW] = FixDataArray[IW].SFHo;
                XDTSight[IW] = FixDataArray[IW].SDTSight;
                EP[IW] = FixDataArray[IW].SEP;
            }
            // DGFix.ClearSelection()
            // DGFix.CurrentCell = Nothing
            DGFix.Refresh();
            CalculateFix();
            Show();
            return;
        }

        private void CalculateFix()
        {
            IL = (short)IUPass;
            TimeOfFix = 0d;
            FixIL = 0;
            SelectedFix = 0;
            var loopTo = IL;
            for (i = 1; i <= loopTo; i++)
            {
                if (XSelected[i] == true)
                {
                    SelectedFix += 1;
                    if (XZT[i] > TimeOfFix)
                    {
                        TimeOfFix = XZT[i];
                        FixIL = i;
                    }
                }
            }
            // L and Lo of the sight with the most recent (largest) time and will be the basis of the fix calculation
            BF = XL[FixIL];
            LF = XLo[FixIL];
            double BFinRads = 0.0d; // BF * DegtoRad
            int LoopCt = 0;
            double ZNinRads = 0.0d;
        Line1849:
            ;
            AX = 0.0d;
            BX = 0.0d;
            CX = 0.0d;
            DX = 0.0d;
            EX = 0.0d;
            GX = 0.0d;
            var loopTo1 = IL;
            for (i = 1; i <= loopTo1; i++)
            {
                if (XSelected[i] == true)
                {
                    ZNinRads = XZN[i] * DegtoRad;
                    AX += Math.Pow(Math.Cos(ZNinRads), 2d);
                    BX += Math.Cos(ZNinRads) * Math.Sin(ZNinRads);
                    CX += Math.Pow(Math.Sin(ZNinRads), 2d);
                    DX += XMI[i] / 60d * Math.Cos(ZNinRads);
                    EX += XMI[i] / 60d * Math.Sin(ZNinRads);
                }
            }

            GX = AX * CX - BX * BX;
            if (GX == 0d) // there is no convergence of the intercepts and azimuths for this fix
            {
                goto Line2200;
            }

            BFinRads = BF * DegtoRad;
            LI = LF + (AX * EX - BX * DX) / (GX * Math.Cos(BFinRads));
            BI = BF - (CX * DX - BX * EX) / GX; // Sign is correct for sign of XMI
            DF = 60d * Math.Sqrt(Math.Pow(LI - LF, 2d) * Math.Pow(Math.Cos(BFinRads), 2d) + Math.Pow(BI - BF, 2d));
            L = BI;
            BF = BI;
            Lo = LI;
            LF = LI;
            // if there are only 2 sites to fix their position then the previous lines of code determine the intersection of the two intercepts and no more is needed
            if (SelectedFix == 2)
            {
                goto FixPosition;
            }
            // test if too many calc loops have been done
            LoopCt += 1;
            if (LoopCt > 1000) // if DF value can not be resolved into 1000 iterations then this fix is a bust
            {
                goto Line2200;
            }
            // keep looping until the derived intercept length is within the equivalent of 0.01' roughly equal to 0'36" or 0.5 nm
            if (DF > 0.001d)
            {
                Loc();  // this faux law of cosines calc is only needed when three body fixes are done - two body fixes only require simple math above for intersection of intercepts
                goto Line1849;      // NA says D>20.  Changed in V5.6.1 to 0.01, equivalent of 0.01'.  Ron uses 0.001
            }

        FixPosition:
            ;
            if (Math.Abs(LI) > 180d)
            {
                LI = -Math.Sign(LI) * (360d - Math.Abs(LI)) % 180d; // In case fix is on other side of IDL
            }
            // What if fix is on other side of equator?
            // extract latitude minutes from calculated fix latitude BF
            BD = Conversion.Int(Math.Abs(BI));
            BM = (Math.Abs(BI) - BD) * 60.0d;
            if (BM >= 60d)
            {
                BM = BM - 60d;
                BD += 1d;
            }

            BM = Math.Round(BM, 1, MidpointRounding.AwayFromZero);
            BH = CommonGlobals.g_LatN;
            if (XL[FixIL] < 0d)
            {
                BH = CommonGlobals.g_LatS;
            }

            if (XL[FixIL] == 0d)
            {
                BH = " ";
            }
            // extract longitude minutes from calculated fix longitude LI
            FD = Conversion.Int(Math.Abs(LI));
            FM = (Math.Abs(LI) - FD) * 60.0d;
            if (FM >= 60d)
            {
                FM = FM - 60d;
                FD = FD + 1d;
            }

            FM = Math.Round(FM, 1, MidpointRounding.AwayFromZero);
            LH = CommonGlobals.g_LongW;
            if (XLo[FixIL] < 0d)
            {
                LH = CommonGlobals.g_LongE;
            }

            if (XLo[FixIL] == 0d)
            {
                LH = " ";
            }
            // Calculate bearing using mid-latitude sailing
            LatDiff = BI - XL[FixIL];   // BF
            LongDiff = LI - XLo[FixIL]; // LF
                                        // Crossing IDL
            if (Math.Abs(LongDiff) > 180d)
            {
                LongDiff = -Math.Sign(LongDiff) * (360d - Math.Abs(LongDiff));
            }

            Lm = (BI + XL[FixIL]) / 2d; // Mid-latitude   'XL(FixIL)
            if (LatDiff == 0d)
            {
                CourseAngle = Pi / 2d;
            }
            else
            {
                double tmpdbl = LongDiff * 60d * Math.Cos(Lm * DegtoRad);
                CourseAngle = Math.Abs(Math.Atan(tmpdbl / (LatDiff * 60d)));
            }

            CourseAngleDeg = CourseAngle * RadtoDeg;
            // CourseAngleDeg = CourseAngle * 180 / Pi
            if (LatDiff >= 0d & LongDiff < 0d)
            {
                Course = CourseAngleDeg; // Added Abs to CourseAngleDeg
            }

            if (LatDiff >= 0d & LongDiff >= 0d)
            {
                Course = 360d - CourseAngleDeg; // Added Abs to CourseAngleDeg
            }

            if (LatDiff < 0d & LongDiff < 0d)
            {
                Course = 180d - CourseAngleDeg; // Added Abs to CourseAngleDeg
            }

            if (LatDiff < 0d & LongDiff >= 0d)
            {
                Course = 180d + CourseAngleDeg; // Added Abs to CourseAngleDeg
            }
            // DF is distance from DR to Fix 
            // DF = 60 * LatDiff / System.Math.Cos(CourseAngle)
            // DF = Int(System.Math.Abs(DF) * 10 + 0.5) / 10
            DF = Math.Round(Math.Abs(DF), 1, MidpointRounding.AwayFromZero);
            // Course is the True Bearing frm DR to Fix
            // Course = Int(System.Math.Abs(Course) + 0.5)
            Course = Math.Round(Course, 0, MidpointRounding.AwayFromZero);
            if (FixIL == 0)
            {
                XZH[FixIL] = 0d;
                XZM[FixIL] = 0d;
                XZS[FixIL] = 0d;
            }

            txtFixZT.Text = Strings.Format(XZH[FixIL], "00") + "-" + Strings.Format(XZM[FixIL], "00") + "-" + Strings.Format(XZS[FixIL], "00");
            txtFixLat.Text = Strings.Format(BD, "#0") + '°' + Strings.Format(BM, "00.0") + "'" + BH;
            txtFixLong.Text = Strings.Format(FD, "##0") + '°' + Strings.Format(FM, "00.0") + "'" + LH;
            txtFixIntercept.Text = Strings.Format(DF, "##0.0");
            txtFixBearing.Text = Strings.Format(Course, "000") + '°';

            // txtFixCalc.Clear()
            // txtFixCalc.AppendText(vbNewLine & "Fix at ZT = " & Strings.Format(XZH(FixIL), "00") & "-" & Strings.Format(XZM(FixIL), "00") & "-" & Strings.Format(XZS(FixIL), "00") & vbNewLine)
            // txtFixCalc.AppendText("Fix L  =  " & Strings.Format(BD, "#0") & Chr(176) & Strings.Format(BM, "00.0") & "'" & BH & vbNewLine)
            // txtFixCalc.AppendText("Fix Lo = " & Strings.Format(FD, "##0") & Chr(176) & Strings.Format(FM, "00.0") & "'" & LH & vbNewLine)
            // txtFixCalc.AppendText("Fix is " & Strings.Format(DF, "##0.0") & " nm from " & Strings.Format(XZH(FixIL), "00") & "-" & Strings.Format(XZM(FixIL), "00") & "-" & Strings.Format(XZS(FixIL), "00") & " DR")
            // txtFixCalc.AppendText(", at a bearing of " & Strings.Format(Course, "000") & Chr(176) & " True")
            return;
        // Line2200 is error exit from Fix routine - error message says it all
        Line2200:
            ;

            // txtFixCalc.Clear()
            // txtFixCalc.AppendText("Fix cannot be established.")
            // txtFixCalc.AppendText("Selected sights have unacceptable cuts or excessively large intercepts.")
            ErrorMsgBox("Selected sights have unacceptable cuts or excessively large intercepts.", "Fix cannot be established.", MessageBoxButtons.OK);
            return;
        }

        private void ErrorMsgBox(string ErrMsg, string TitleStr, MessageBoxButtons MsgBtn)
        {
            MessageBox.Show(ErrMsg, TitleStr, MsgBtn, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            return;
        }

        private void Loc()
        {
            var loopTo = IL;
            for (i = 1; i <= loopTo; i++)
            {
                if (XSelected[i] == true)
                {
                    GHA = XGHA[i];
                    DE = XDec[i];
                    Ho = XHo[i];
                    LHA = GHA - Lo;
                    if (LHA >= 360d)
                        LHA = LHA - 360d;
                    if (LHA < 0d)
                        LHA = LHA + 360d;
                    L1 = Math.Cos(LHA * DegtoRad) * Math.Cos(L * DegtoRad) * Math.Cos(DE * DegtoRad);
                    L2 = Math.Sin(L * DegtoRad) * Math.Sin(DE * DegtoRad);
                    L3 = L1 + L2;
                    if (Math.Abs(L3) >= 1d)
                    {
                        Hc = Math.Sign(L3) * Pi / 2d;
                    }
                    else
                    {
                        Hc = Math.Atan(L3 / Math.Sqrt(-L3 * L3 + 1d));
                    }

                    Hc = Hc * 180d / Pi;
                    A = 60d * (Hc - Ho);      // Ho>Hc (T) is -
                    L4 = Math.Sin(DE * DegtoRad);
                    L5 = Math.Sin(L * DegtoRad) * Math.Sin(Hc * DegtoRad);
                    L6 = L4 - L5;
                    L7 = Math.Cos(L * DegtoRad) * Math.Cos(Hc * DegtoRad);
                    L8 = L6 / L7;
                    if (Math.Abs(L8) >= 1d)
                    {
                        Z = Pi;
                    }
                    else
                    {
                        Z = Math.Atan(-L8 / Math.Sqrt(-L8 * L8 + 1d)) + Pi / 2d;
                    }      // This is really Zc, not Z (always determined from north pole

                    Z = Z * 180d / Pi;
                    if (LHA > 180d)
                        ZN = Z;
                    if (LHA <= 180d)
                        ZN = 360d - Z;
                    if (ZN == 360d)
                        ZN = 0d;
                    XZN[i] = ZN;
                    XMI[i] = A;
                }
            }
        }
    }
}