// sighttxtOption 'Strict Off
// Option Explicit On
// Imports VB = Microsoft.VisualBasic
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    internal partial class FormSRF : Form
    {
        public bool InvokedbySightLog = false;
        public DateTime SightZoneDatetime;
        public double Lat, ZN, Hc, LHA, TotDE;
        public bool FlagMD, FlagSRFLoCNASR;
        public double EstLoDeg, EstLDeg, EstL, DecimalDate, EstLo, EstLMin, EstLoMin;
        public short DecDegrees;
        public double DecMinutes;
        public double Pressure, HEinFeet, HE, Temperature, DipShortDist;
        public double hsinMinutes, ZD, Lo, ICinMinutes, hainMinutes;
        public string MonthDays, DateOfSight, SignZD, fnumeral, MonthList;
        public short GDayOfYear, GMonth;
        public double[] RA = new double[58], Dec = new double[58];
        public double[] PMRA = new double[58], PMDec = new double[58];
        public short PlusCount, i;
        public double DeltaT;
        public float DecYr, Theta; // Tdelta As Double, Theta As Double
        public double E, L0, PM, LP, P0, DecLOC;
        public double dHP, h3, H2, DSD, h4; // ,h4UL As Double, h4LL As Double,havg As Double
        public double AR, Pi, SH, DE;
        public int BN;
        public string BNType;
        public string BNBodyName;
        public double DI, EA, NO, OE, NU, RN, AL;
        public double GHAAriesMin, GHAAries, GHAAriesHour;
        public short GHAAriesDeg;
        public double TotGHA, GHA, GHAMin, TotGHAMin;
        public double SaveGHA;
        public short GHADeg, TotGHADeg;
        public short LHADeg;
        public double LHAMin;
        public double RstdTP, Main_Corr, Rstd, PX, GHAHour, GHAMinSec, TX, Raddl, Addl, RstdA2;
        public bool BackSight;
        public double r, HP, PA, HPA;
        public short GHAHourDeg1, GHAHourDeg2;
        public double GHAHourMin1, GHAHourMin2; // , GHAMinSecDeg As Integer, GHAMinSecMin As Double
        public double y, x, S;
        public double HG;
        public double MA, TN, NL, M;
        public double NY;
        public double B, T, A, C, MS;
        public double LN, HoinMinutes;
        public int ZTinSeconds;
        public short ZTSeconds, ZTHours, ZTMinutes, WEinSeconds;
        public short GHour;
        public int WTinSeconds, GMinute, GSecond, ZTTemp;
        public short LocalYear, GYear, GDay, GYearJ, MonthNumber;
        public string MonthatG;
        public double Corr1, Corr1Min;
        public short Corr1Deg, DayNumber;
        public int ZDinSeconds;
        public double HoDeg, Corr2Min, HoMin, D;
        public string HD; // , Hc As Double
        public short HcDeg;
        public double HsMin, HcMin, ICMin;
        public double L8, L6, L4, L2, L1, L3, L5, L7, Z;
        public short haDeg;
        public double SHdeg, haMin, SHmin;
        public int UTinSeconds;
        public double PC, LR, XM, PCmin;
        public short XD, PCdeg;
        public double PD2, Aug;
        public string PL;
        // fix data index variables
        public int IU = 0;
        public int IJ = 0;
        public int II = 0;
        public short IV, IW;
        public double THour1, DecimalDateHour1, DecimalDateHour2, THour2;
        public double PCorr, Pola0min, Pola2, Pola0, Pola1, Pola0deg, LbyPol, LforPol;
        public double Ldiff, ldiffMin;
        public short ldiffDeg;
        public double LHAPol, TotGHAPol, TotGHAPolMin, LHAPolMin;
        public short TotGHAPolDeg, LHAPolDeg;
        public double MeanSHAPol, MeanDecPol;
        public short MonthPolaris;
        public bool LeapYear, GLeapYear;
        public short[] DayG = new short[13];
        public int EqTinSeconds;
        public float EqTminutes, EqTseconds;
        public bool DateError;
        public double HourChange, vvalue;
        public double vcorr, k, GHAIncrement, GHAIncrementMin;
        public short GHAIncrementDeg;
        public double dvalue, DE1, DE2, dcorr;
        public short Signdvalue, SignHourChange;
        public short Lendcorr, TotDecDegrees, Lenvcorr, LenCorr2Min;
        public double TotDecMinutes;
        public double Intercept, GHAHour1, GHAHour2, L;
        public double AberrL, Ecc, PeriLo, AberrB;
        public double Pre2, JDHour2, JDHour, JD, JDHour1, Pre1, Pre3;
        public double AberrRA, NutRA, NutDec, AberrDec;
        public double OETrue, Tfull;
        public double[] MSinA = new double[60], MMprimeA = new double[60], MDA = new double[60], MMA = new double[60], MFA = new double[60], MCosA = new double[60];
        public double[] MFB = new double[60], MMB = new double[60], MDB = new double[60], MMprimeB = new double[60], MSinB = new double[60];
        public double A2, MF, MM, MLprime, MD, MMprime, A1, A3;
        public double r0, KB, Delta, SigmaR, SigmaL, SigmaB, KA, B0, Tau;
        public double NutF, NutM, NutD, NutMprime, NutOmega;
        public double[] NCos = new double[63], NSin = new double[63], NF = new double[63], NM = new double[63], ND = new double[63], NMprime = new double[63], NOmega = new double[63], NSinT = new double[63], NCosT = new double[63];
        public double TFK5, DecDegrees2, DecMinutes2, Lprime; // , L0Sun As Double
        public string LMin, LoMin;
        public double SunHourChange, SunGHACorr;
        public double Corr2forParallax;
        public short StarDayNumber;
        public bool StarNAFlag;
        public double SHminDisplay, SHdegDisplay, DENA;
        public bool FlagPlanets;
        public double DENA1, DENA2; // vvalueP As Double, dvalueP As Double, SigndvalueP As Integer
        public Bitmap bm;
        public string BMFname = "./Graphics/SRF1.jpg";
        public Graphics SRF1graphic;
        public int DrawWidth;
        public Pen DPen;
        public Point ptA;
        public Point ptB;
        private bool bMinusSignAlready = false;

        private void EqTPicBx_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.SRFTimeDiagram.Show();
            My.MyProject.Forms.SRFTimeDiagram.SetDesktopLocation(5, 5); // 
            My.MyProject.Forms.SRFTimeDiagram.BringToFront();
            return;
        }

        private void btnExpandTimeDiag_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.SRFTimeDiagram.Show();
            My.MyProject.Forms.SRFTimeDiagram.SetDesktopLocation(5, 5); // 
            My.MyProject.Forms.SRFTimeDiagram.BringToFront();
        }

        private bool FormSRFLoaded = false;
        // Dim TxtBxFont As Font = New Font("Arial", 8) ', FontStyle.Bold)
        private readonly Font TxtBxFont = new Font("Courier New", 8f); // , FontStyle.Bold)
        private readonly Font DGFont = new Font("Arial", 8f, FontStyle.Regular);
        private bool DrawBasicTimeDiagram = false;
        private readonly bool DrawEqTDiagram = false;
        private bool IssuingSendMsgBx = false;
        // fix data fields - set SFixData structure below as it is shared with Form4 / Fix Form
        public double[] FZH = new double[51];
        public double[] FZM = new double[51];
        public double[] FZS = new double[51];
        public double[] FMI = new double[51];
        public double[] FZN = new double[51];
        public string[] FLD = new string[51];
        public string[] FLM = new string[51];
        public double[] FL = new double[51];
        public double[] FMD = new double[51];
        public double[] FMM = new double[51];
        public string[] FM = new string[51];
        public double[] FZT = new double[51];
        public double[] FUT = new double[51];
        public string[] FD = new string[51];
        public string[] BF = new string[51];
        public string[] FLA = new string[51];
        public double[] FLo = new double[51];
        public double[] FGHA = new double[51];
        public double[] FDec = new double[51];
        public double[] FHo = new double[51];    // added in V5.6.1
        public DateTime[] FDTSight = new DateTime[51];
        public string[] EP = new string[51];
        public CLSForm.PlotEntry PlotOut;
        public double LHAOriginal;

        private struct SunSDRec
        {
            public DateTime SunSDStart;
            public DateTime SunSDEnd;
            public double SunSD;
            public double DailyChg;
        }

        private SunSDRec[] SunSDArray;

        public void Load_SunSDData()
        {
            SunSDArray = new SunSDRec[12];
            SunSDArray[0] = new SunSDRec() { SunSDStart = new DateTime(2020, 1, 1), SunSDEnd = new DateTime(2020, 2, 5), SunSD = 16.3d, DailyChg = -0.00278d };
            SunSDArray[1] = new SunSDRec() { SunSDStart = new DateTime(2020, 2, 6), SunSDEnd = new DateTime(2020, 3, 2), SunSD = 16.2d, DailyChg = -0.00385d };
            SunSDArray[2] = new SunSDRec() { SunSDStart = new DateTime(2020, 3, 3), SunSDEnd = new DateTime(2020, 3, 27), SunSD = 16.1d, DailyChg = -0.00400d };
            SunSDArray[3] = new SunSDRec() { SunSDStart = new DateTime(2020, 3, 28), SunSDEnd = new DateTime(2020, 4, 17), SunSD = 16.0d, DailyChg = -0.00476d };
            SunSDArray[4] = new SunSDRec() { SunSDStart = new DateTime(2020, 4, 18), SunSDEnd = new DateTime(2020, 5, 14), SunSD = 15.9d, DailyChg = -0.0037d };
            SunSDArray[5] = new SunSDRec() { SunSDStart = new DateTime(2020, 5, 15), SunSDEnd = new DateTime(2020, 8, 24), SunSD = 15.8d, DailyChg = +0.00098d };
            SunSDArray[6] = new SunSDRec() { SunSDStart = new DateTime(2020, 8, 25), SunSDEnd = new DateTime(2020, 9, 20), SunSD = 15.9d, DailyChg = +0.003704d };
            SunSDArray[7] = new SunSDRec() { SunSDStart = new DateTime(2020, 9, 21), SunSDEnd = new DateTime(2020, 10, 11), SunSD = 16.0d, DailyChg = +0.004762d };
            SunSDArray[8] = new SunSDRec() { SunSDStart = new DateTime(2020, 10, 12), SunSDEnd = new DateTime(2020, 11, 1), SunSD = 16.1d, DailyChg = +0.004762d };
            SunSDArray[9] = new SunSDRec() { SunSDStart = new DateTime(2020, 11, 2), SunSDEnd = new DateTime(2020, 12, 1), SunSD = 16.2d, DailyChg = +0.003333d };
            SunSDArray[10] = new SunSDRec() { SunSDStart = new DateTime(2020, 12, 2), SunSDEnd = new DateTime(2020, 12, 31), SunSD = 16.3d, DailyChg = +0.0d };
        }

        public double GetSunSD(DateTime DateIn)
        {
            for (int i = 0; i <= 11; i++)
            {
                if (DateIn >= SunSDArray[i].SunSDStart & DateIn <= SunSDArray[i].SunSDEnd)
                {
                    if (DateIn == SunSDArray[i].SunSDStart)
                    {
                        return SunSDArray[i].SunSD;
                    }

                    if (DateIn == SunSDArray[i].SunSDEnd)
                    {
                        return SunSDArray[i + 1].SunSD;
                    }

                    var TS1 = DateIn - SunSDArray[i].SunSDStart;
                    double TmpRtn = SunSDArray[i].SunSD + TS1.Days * SunSDArray[i].DailyChg;
                    return TmpRtn;
                }
            }

            if (DateIn.Month >= 4 & DateIn.Month <= 9)
            {
                return 15.859d;
            }
            else
            {
                return 16.1968d;
            }
        }

        public struct BodyData
        {
            public string Bname;
            public int BIndex;
            public string BType;
        }

        public BodyData[] BNData;

        public void LoadBNData()
        {
            BNData = new BodyData[67];
            BNData.Initialize();
            // CONVERSION from VB6 to DOTNET NOTE: the value of BIndex on each name below was determined in the original VB6 FRx file drop down list and in interlinked with the RA, DEC, and other table used in the
            // LHA  / SHA  calculations. Because of the interlinking of the index with the order and use of RA / DEC calc tables these values must be preserved. DO NOT Change this table or 
            // the Bname and BIndex values on any record. Reference file SRFcbobodyDropDownListBuilder.xlsx in visual studio project folder
            BNData[0] = new BodyData() { Bname = "Loaded", BIndex = 100, BType = "Status" };
            BNData[1] = new BodyData() { Bname = "Sun L.L.", BIndex = 64, BType = "Sun" };
            BNData[2] = new BodyData() { Bname = "Sun U.L.", BIndex = 65, BType = "Sun" };
            BNData[3] = new BodyData() { Bname = "Moon L.L.", BIndex = 62, BType = "Moon" };
            BNData[4] = new BodyData() { Bname = "Moon U.L.", BIndex = 63, BType = "Moon" };
            BNData[5] = new BodyData() { Bname = "Venus", BIndex = 58, BType = "Planets" };
            BNData[6] = new BodyData() { Bname = "Mars", BIndex = 59, BType = "Planets" };
            BNData[7] = new BodyData() { Bname = "Jupiter", BIndex = 60, BType = "Planets" };
            BNData[8] = new BodyData() { Bname = "Saturn", BIndex = 61, BType = "Planets" };
            BNData[9] = new BodyData() { Bname = "Acamar", BIndex = 7, BType = "Stars" };
            BNData[10] = new BodyData() { Bname = "Achernar", BIndex = 5, BType = "Stars" };
            BNData[11] = new BodyData() { Bname = "Acrux", BIndex = 30, BType = "Stars" };
            BNData[12] = new BodyData() { Bname = "Adhara", BIndex = 19, BType = "Stars" };
            BNData[13] = new BodyData() { Bname = "Aldebaran", BIndex = 10, BType = "Stars" };
            BNData[14] = new BodyData() { Bname = "Alioth", BIndex = 32, BType = "Stars" };
            BNData[15] = new BodyData() { Bname = "Alkaid", BIndex = 34, BType = "Stars" };
            BNData[16] = new BodyData() { Bname = "Al Na'ir", BIndex = 55, BType = "Stars" };
            BNData[17] = new BodyData() { Bname = "Alnilam", BIndex = 15, BType = "Stars" };
            BNData[18] = new BodyData() { Bname = "Alphard", BIndex = 25, BType = "Stars" };
            BNData[19] = new BodyData() { Bname = "Alphecca", BIndex = 41, BType = "Stars" };
            BNData[20] = new BodyData() { Bname = "Alpheratz", BIndex = 1, BType = "Stars" };
            BNData[21] = new BodyData() { Bname = "Altair", BIndex = 51, BType = "Stars" };
            BNData[22] = new BodyData() { Bname = "Ankaa", BIndex = 2, BType = "Stars" };
            BNData[23] = new BodyData() { Bname = "Antares", BIndex = 42, BType = "Stars" };
            BNData[24] = new BodyData() { Bname = "Arcturus", BIndex = 37, BType = "Stars" };
            BNData[25] = new BodyData() { Bname = "Atria", BIndex = 43, BType = "Stars" };
            BNData[26] = new BodyData() { Bname = "Avior", BIndex = 22, BType = "Stars" };
            BNData[27] = new BodyData() { Bname = "Bellatrix", BIndex = 13, BType = "Stars" };
            BNData[28] = new BodyData() { Bname = "Betelgeuse", BIndex = 16, BType = "Stars" };
            BNData[29] = new BodyData() { Bname = "Canopus", BIndex = 17, BType = "Stars" };
            BNData[30] = new BodyData() { Bname = "Capella", BIndex = 12, BType = "Stars" };
            BNData[31] = new BodyData() { Bname = "Deneb", BIndex = 53, BType = "Stars" };
            BNData[32] = new BodyData() { Bname = "Denebola", BIndex = 28, BType = "Stars" };
            BNData[33] = new BodyData() { Bname = "Diphda", BIndex = 4, BType = "Stars" };
            BNData[34] = new BodyData() { Bname = "Dubhe", BIndex = 27, BType = "Stars" };
            BNData[35] = new BodyData() { Bname = "Elnath", BIndex = 14, BType = "Stars" };
            BNData[36] = new BodyData() { Bname = "Eltanin", BIndex = 47, BType = "Stars" };
            BNData[37] = new BodyData() { Bname = "Enif", BIndex = 54, BType = "Stars" };
            BNData[38] = new BodyData() { Bname = "Fomalhaut", BIndex = 56, BType = "Stars" };
            BNData[39] = new BodyData() { Bname = "Gacrux", BIndex = 31, BType = "Stars" };
            BNData[40] = new BodyData() { Bname = "Gienah", BIndex = 29, BType = "Stars" };
            BNData[41] = new BodyData() { Bname = "Hadar", BIndex = 35, BType = "Stars" };
            BNData[42] = new BodyData() { Bname = "Hamal", BIndex = 6, BType = "Stars" };
            BNData[43] = new BodyData() { Bname = "Kaus Australis", BIndex = 48, BType = "Stars" };
            BNData[44] = new BodyData() { Bname = "Kochab", BIndex = 40, BType = "Stars" };
            BNData[45] = new BodyData() { Bname = "Markab", BIndex = 57, BType = "Stars" };
            BNData[46] = new BodyData() { Bname = "Menkar", BIndex = 8, BType = "Stars" };
            BNData[47] = new BodyData() { Bname = "Menkent", BIndex = 36, BType = "Stars" };
            BNData[48] = new BodyData() { Bname = "Miaplacidus", BIndex = 24, BType = "Stars" };
            BNData[49] = new BodyData() { Bname = "Mirfak", BIndex = 9, BType = "Stars" };
            BNData[50] = new BodyData() { Bname = "Nunki", BIndex = 50, BType = "Stars" };
            BNData[51] = new BodyData() { Bname = "Peacock", BIndex = 52, BType = "Stars" };
            BNData[52] = new BodyData() { Bname = "Polaris", BIndex = 0, BType = "Stars" };
            BNData[53] = new BodyData() { Bname = "Pollux", BIndex = 21, BType = "Stars" };
            BNData[54] = new BodyData() { Bname = "Procyon", BIndex = 20, BType = "Stars" };
            BNData[55] = new BodyData() { Bname = "Rasalhague", BIndex = 46, BType = "Stars" };
            BNData[56] = new BodyData() { Bname = "Regulus", BIndex = 26, BType = "Stars" };
            BNData[57] = new BodyData() { Bname = "Rigel", BIndex = 11, BType = "Stars" };
            BNData[58] = new BodyData() { Bname = "Rigil Kentaurus", BIndex = 38, BType = "Stars" };
            BNData[59] = new BodyData() { Bname = "Sabik", BIndex = 44, BType = "Stars" };
            BNData[60] = new BodyData() { Bname = "Schedar", BIndex = 3, BType = "Stars" };
            BNData[61] = new BodyData() { Bname = "Shaula", BIndex = 45, BType = "Stars" };
            BNData[62] = new BodyData() { Bname = "Sirius", BIndex = 18, BType = "Stars" };
            BNData[63] = new BodyData() { Bname = "Spica", BIndex = 33, BType = "Stars" };
            BNData[64] = new BodyData() { Bname = "Suhail", BIndex = 23, BType = "Stars" };
            BNData[65] = new BodyData() { Bname = "Vega", BIndex = 49, BType = "Stars" };
            BNData[66] = new BodyData() { Bname = "Zubenelgenubi", BIndex = 39, BType = "Stars" };
            return;
        }

        public int getBNIndex(string BdyName)
        {
            // this function uses the selected body name from the input form (or any body name sent into it) and returns the valid Index from the table above
            // The Index is usually widely in the analysis and computational code in this module  as an table index into computation tables for RA, DEc, etc.
            int Limit = BNData.GetUpperBound(0);
            int I = 0;
            // first check to see if BNData has been loaded - this value set in form load / initiatilization routines - if for some reason this function gets called before 
            // that load routine completes, then the load takes place here. This can occur as the form is initially loaded and form field events are fired off prior to load 
            if (!(BNData[0].Bname == "Loaded"))
            {
                LoadBNData();
            }

            var loopTo = Limit;
            for (I = 0; I <= loopTo; I++)
            {
                if ((BNData[I].Bname ?? "") == (BdyName ?? ""))
                {
                    BN = BNData[I].BIndex;
                    BNType = BNData[I].BType;
                    BNBodyName = BNData[I].Bname;
                    return BNData[I].BIndex;
                    return default;
                }
            }

            return 999;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            if (CheckOpenWinForms("FormMeridianDiagram") == true)
            {
                My.MyProject.Forms.FormMeridianDiagram.ExitBtn.PerformClick();
                My.MyProject.Forms.FormMeridianDiagram.Close();
            }

            if (InvokedbySightLog == true)
            {
                My.MyProject.Forms.SightLog.FormSRFLoaded = false;
                InvokedbySightLog = false;
            }
            // Cleanup()
            Close();
            return;
        }

        private void optLower_CheckedChanged(object sender, EventArgs e)
        {
            if (!FormSRFLoaded)
                return;
            if (optLower.Checked)
            {
                if (optHorizonBubble.Checked == true)
                {
                    SendMsgBx("Caution:  Improper combination of limb and horizon. Lower limb cannot combine with Bubble horizon", MessageBoxIcon.Error);
                }
            }
        }

        private void optUpper_CheckedChanged(object sender, EventArgs e)
        {
            if (!FormSRFLoaded)
                return;
            if (optUpper.Checked)
            {
                if (optHorizonBubble.Checked == true)
                {
                    SendMsgBx("Caution:  Improper combination of limb and horizon. Upper limb cannot combine with Bubble horizon", MessageBoxIcon.Error);
                }
            }

            return;
        }

        private void optCenter_CheckedChanged(object sender, EventArgs e)
        {
            if (!FormSRFLoaded)
                return;
            if (optCenter.Checked)
            {
                lblHE.Visible = false;
                txtHE.Visible = false;
                cboHE.Visible = false;
                lblDsDist.Visible = false;
                txtDsDist.Visible = false;
                cboDsUnit.Visible = false;
                if (optHorizonNatural.Checked == true | optHorizonDipShort.Checked == true)
                {
                    SendMsgBx("Caution:  Improper combination of limb and horizon. Natural or Dip Short Horizon cannot combine with Center limb", MessageBoxIcon.Error);
                }
            }
        }

        public void GetValidBN()
        {
            string SBName = cboBody.SelectedItem.ToString();
            SBName = GetValidBodyName();
            BN = getBNIndex(SBName);
            if (BN == 999)
            {
                // this error should mean that someone changed the form drop down list without syncing it to the internal table to get a valid BN
                SendMsgBx("Error: Invalid BN returned - check selection list on form to BN code in program", MessageBoxIcon.Stop);
            }

            return;
        }

        public string GetValidBodyName()
        {
            string SBName = cboBody.SelectedItem.ToString();
            string SunStr = "Sun";
            string MoonStr = "Moon";
            if ((SBName ?? "") == (SunStr ?? "") | (SBName ?? "") == (MoonStr ?? ""))
            {
                if (optUpper.Checked)
                {
                    SBName += " U.L.";
                }
                else if (optLower.Checked)
                {
                    SBName += " L.L.";
                }
                else
                {
                    SBName += " L.L.";
                    // optLower.Checked = True
                }
            }

            return SBName;
            return default;
        }

        private void optHorizonBubble_CheckedChanged(object sender, EventArgs e)
        {
            if (!FormSRFLoaded)
                return;
            {
                if (optHorizonBubble.Checked == true)
                {
                    lblHE.Visible = false;
                    txtHE.Visible = false;
                    cboHE.Visible = false;
                    lblDsDist.Visible = false;
                    txtDsDist.Visible = false;
                    cboDsUnit.Visible = false;
                }

                if (optUpper.Checked == true | optLower.Checked == true)
                {
                    SendMsgBx("Caution:  Improper combination of limb and horizon.", MessageBoxIcon.Warning);
                }
            }
        }

        private void cboBody_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            if (!FormSRFLoaded)
                return;
            if (cboBody.SelectedItem.ToString() == "Polaris")
            {
                cboPolaris.Visible = true;
                cboPolaris.BringToFront();
                cboSun.Visible = false;
                cboStars.Visible = false;
                cboPlanets.Visible = false;
                LimbTxt.Visible = false;
                frmLimb.Visible = false;
                optUpper.Visible = false;
                optLower.Visible = false;
                optCenter.Visible = false;
            }
            else if (cboBody.SelectedItem.ToString() == "Sun")
            {
                cboSun.Visible = true;
                cboSun.BringToFront();
                cboPolaris.Visible = false;
                cboStars.Visible = false;
                cboPlanets.Visible = false;
                LimbTxt.Visible = true;
                frmLimb.Visible = true;
                optUpper.Visible = true;
                optLower.Visible = true;
                optCenter.Visible = true;
            }
            else if (cboBody.SelectedItem.ToString() == "Moon")
            {
                cboSun.Visible = false;
                cboPolaris.Visible = false;
                cboStars.Visible = false;
                cboPlanets.Visible = false;
                LimbTxt.Visible = true;
                frmLimb.Visible = true;
                optUpper.Visible = true;
                optLower.Visible = true;
                optCenter.Visible = true;
            }
            else if (cboBody.SelectedItem.ToString() != "Polaris" & cboBody.SelectedItem.ToString() != "Sun" & cboBody.SelectedItem.ToString() != "Moon")
            {
                cboPolaris.Visible = false;
                cboSun.Visible = false;
                cboStars.Visible = false;
                cboPlanets.Visible = false;
                lblDRL.Visible = true;
                txtLDeg.Visible = true;
                lblLDeg.Visible = true;
                txtLMin.Visible = true;
                lblLMin.Visible = true;
                cboL.Visible = true;
                if (cboBody.SelectedItem.ToString() != "Polaris")
                {
                    cboPolaris.Text = "Latitude by altitude of Polaris";
                }

                LimbTxt.Visible = false;
                frmLimb.Visible = false;
                optUpper.Visible = false;
                optLower.Visible = false;
                optCenter.Visible = false;
            }
            else if (cboBody.SelectedItem.ToString() != "Polaris" & cboBody.SelectedItem.ToString() != "Sun" & cboBody.SelectedItem.ToString() != "Moon" & cboBody.SelectedItem.ToString() != "Venus" & cboBody.SelectedItem.ToString() != "Mars" & cboBody.SelectedItem.ToString() != "Jupiter" & cboBody.SelectedItem.ToString() != "Saturn") // stars othr than Polaris
            {
                cboPolaris.Visible = false;
                cboSun.Visible = false;
                cboStars.Visible = true;
                cboPlanets.Visible = false;
                LimbTxt.Visible = false;
                frmLimb.Visible = false;
                optUpper.Visible = false;
                optLower.Visible = false;
                optCenter.Visible = false;
            }
            else if (cboBody.SelectedItem.ToString() == "Venus" | cboBody.SelectedItem.ToString() == "Mars" | cboBody.SelectedItem.ToString() == "Jupiter" | cboBody.SelectedItem.ToString() == "Saturn") // spelled Staurn before V5.4.1
            {
                cboPolaris.Visible = false;
                cboSun.Visible = false;
                cboStars.Visible = false;
                cboPlanets.Visible = true;
                LimbTxt.Visible = false;
                frmLimb.Visible = false;
                optUpper.Visible = false;
                optLower.Visible = false;
                optCenter.Visible = false;
            }
            else
            {
                cboSun.Visible = true;
                cboSun.BringToFront();
                cboPolaris.Visible = false;
                cboStars.Visible = false;
                cboPlanets.Visible = false;
                LimbTxt.Visible = true;
                frmLimb.Visible = true;
                optUpper.Visible = true;
                optLower.Visible = true;
                optCenter.Visible = true;
            }

            GetValidBN();
            if (BNType == "Moon" | BNType == "Sun") // Sun or Moon
            {
                if (optCenter.Checked == true & (optHorizonNatural.Checked == true | optHorizonDipShort.Checked == true))
                {
                    SendMsgBx("Caution:  Improper combination of limb and horizon.", MessageBoxIcon.Warning); // Sun or Moon
                }

                if ((optLower.Checked == true | optUpper.Checked == true) & optHorizonBubble.Checked == true)
                {
                    SendMsgBx("Caution:  Improper combination of limb and horizon.", MessageBoxIcon.Warning);
                }
            }
        }

        private void cboLo_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            AutoZDCalc();
        }

        public void cboMonth_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            // If Not FormSRFLoaded Then Exit Sub
            // CheckDate()
        }

        private void cboPolaris_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            if (!FormSRFLoaded)
                return;
            if (cboBody.SelectedItem.ToString() != "Polaris" | cboPolaris.Text != "Latitude by altitude of Polaris")
            {
                lblDRL.Visible = true;
                txtLDeg.Visible = true;
                lblLDeg.Visible = true;
                txtLMin.Visible = true;
                lblLMin.Visible = true;
                cboL.Visible = true;
            }
        }

        private void cboPressure_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            if (cboPressure.Text == "in Hg")
                txtPressure.Text = "29.83";
            if (cboPressure.Text == "mbar")
                txtPressure.Text = "1010";
            txtPressure_TextChanged(txtPressure, new EventArgs());
        }

        private void cboTemperature_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            if (cboTemperature.Text == "F ")
                txtTemperature.Text = "50";
            if (cboTemperature.Text == "C ")
                txtTemperature.Text = "10";
            txtTemperature_TextChanged(txtTemperature, new EventArgs());
        }

        public void cmdFix_Click(object eventSender, EventArgs eventArgs)
        {
            // Form4.IUPass = IU
            My.MyProject.Forms.FixDG.IUPass = IU;
            int temp = 0;
            for (temp = 1; temp <= 12; temp++)
                // Form4.FixDataArray(temp) = New Form4.SFixData With {.SFZH = FZH(temp), .SFZM = FZM(temp), .SFZS = FZS(temp),
                // .SFZN = FZN(temp), .SFMI = FMI(temp), .SFL = FL(temp), .SFLo = FLo(temp), .SBF = BF(temp),
                // .SFLD = FLD(temp), .SFLM = FLM(temp), .sFD = FD(temp), .SFMD = FMD(temp), .SFMM = FMM(temp),
                // .sFLA = FLA(temp), .SFM = FM(temp), .SFGHA = FGHA(temp), .SFDec = FDec(temp), .SFHo = FHo(temp)}
                My.MyProject.Forms.FixDG.FixDataArray[temp] = new FixDG.SFixData()
                {
                    SFZH = FZH[temp],
                    SFZM = FZM[temp],
                    SFZS = FZS[temp],
                    SFZN = FZN[temp],
                    SFMI = FMI[temp],
                    SFL = FL[temp],
                    SFLo = FLo[temp],
                    SBF = BF[temp],
                    SFLD = FLD[temp],
                    SFLM = FLM[temp],
                    sFD = FD[temp],
                    SFMD = FMD[temp],
                    SFMM = FMM[temp],
                    sFLA = FLA[temp],
                    SFM = FM[temp],
                    SFGHA = FGHA[temp],
                    SFDec = FDec[temp],
                    SFHo = FHo[temp],
                    SDTSight = FDTSight[temp],
                    SEP = EP[temp]
                };
            // Form4.Show()
            My.MyProject.Forms.FixDG.txtUserInfo.Text = txtUserInfo.Text;
            My.MyProject.Forms.FixDG.Show();
            My.MyProject.Forms.FixDG.SetDesktopLocation(5, 5); // 
            return;
        }

        public void cmdMerDiag_Click(object eventSender, EventArgs eventArgs)
        {
            if (CheckOpenWinForms("FormMeridianDiagram") == true)
            {
                My.MyProject.Forms.FormMeridianDiagram.ExitBtn.PerformClick();
                My.MyProject.Forms.FormMeridianDiagram.Close();
            }

            if (FlagMD == true)
            {
                // sight reduction method form
                My.MyProject.Forms.MainMenu.FormAltSRFlagMD = false;
            }

            My.MyProject.Forms.FormMeridianDiagram.Show();
            My.MyProject.Forms.FormSightPlan.SetDesktopLocation(5, 5); // 
            My.MyProject.Forms.FormMeridianDiagram.FormSRFFlagMD = true;
            My.MyProject.Forms.FormMeridianDiagram.FormAltSRFlagMD = false;
            My.MyProject.Forms.FormMeridianDiagram.L = Lat;
            My.MyProject.Forms.FormMeridianDiagram.Ho = Hc;
            My.MyProject.Forms.FormMeridianDiagram.ZN = ZN;
            My.MyProject.Forms.FormMeridianDiagram.LHA = LHAOriginal;  // FormSRF.LHADeg + FormSRF.LHAMin / 60
            My.MyProject.Forms.FormMeridianDiagram.Dec = TotDE;
            My.MyProject.Forms.FormMeridianDiagram.BodyName = BNBodyName;
            My.MyProject.Forms.FormMeridianDiagram.DisplayMerDiag();
            My.MyProject.Forms.FormMeridianDiagram.FormSRFFlagMD = false;
            My.MyProject.Forms.FormMeridianDiagram.FormAltSRFlagMD = false;
            // cmdMerDiag.Enabled = False
            // cmdMerDiag.Visible = False

        }

        private void cmdPrint_Click(object eventSender, EventArgs eventArgs)
        {
            // ScreenCapture()
            Print_Renamed.PrintScreen(Bounds);
            Focus();
            return;
        }

        private void ScreenCapture()
        {
            Bitmap bmpScreenShot;
            Graphics gfxScreenshot;
            string filename = "./Graphics/SRFScreenCapture" + DateAndTime.Now.ToString("yyyyMMddHHmmss") + ".jpg";
            bmpScreenShot = new Bitmap(Bounds.Width, Bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            gfxScreenshot = Graphics.FromImage(bmpScreenShot);
            gfxScreenshot.CopyFromScreen(Bounds.X, Bounds.Y, 0, 0, Bounds.Size, CopyPixelOperation.SourceCopy);
            if (My.MyProject.Computer.FileSystem.FileExists(filename))
            {
                My.MyProject.Computer.FileSystem.DeleteFile(filename);
            }

            bmpScreenShot.Save(filename, System.Drawing.Imaging.ImageFormat.Jpeg);
            IssuingSendMsgBx = true;
            MessageBox.Show("Screen Capture can be found at:" + filename);
            IssuingSendMsgBx = false;
            return;
        }

        private void cmdReduce_Click(object eventSender, EventArgs eventArgs)
        {
            if (!FormSRFLoaded)
                return;
            FlagSRFLoCNASR = true;
            DateError = false;
            // CheckDate()
            // If DateError = True Then
            // DateError = False
            // Exit Sub
            // End If
            if (cboIE.Text == "off the arc (rdg.)" & Conversion.Val(txtIEdeg.Text) == 0d)
            {
                cboIE.BackColor = ColorTranslator.FromOle(0xFF);
                cboIE.Focus();
                SendMsgBx("For IE off the arc (rdg.), degree value cannot be zero.", MessageBoxIcon.Error);
                return;
            }

            if (optHorizonDipShort.Checked == true & Conversion.Val(txtDsDist.Text) == 0d)
            {
                txtDsDist.BackColor = ColorTranslator.FromOle(0xFF);
                txtDsDist.Focus();
                SendMsgBx("You must enter a non-zero value for Ds distance", MessageBoxIcon.Error);
                return;
            }

            if (cboTemperature.Text == "F " & (Conversion.Val(txtTemperature.Text) < -40 | Conversion.Val(txtTemperature.Text) > 130d))
            {
                txtTemperature.BackColor = ColorTranslator.FromOle(0xFF);
                txtTemperature.Focus();
                SendMsgBx("Temperature Out of Range", MessageBoxIcon.Error);
                return;
            }

            if (cboTemperature.Text == "C " & (Conversion.Val(txtTemperature.Text) < -40 | Conversion.Val(txtTemperature.Text) > 55d))
            {
                txtTemperature.BackColor = ColorTranslator.FromOle(0xFF);
                txtTemperature.Focus();
                SendMsgBx("Temperature Out of Range", MessageBoxIcon.Error);
                return;
            }

            if (cboPressure.Text == "in Hg" & (Conversion.Val(txtPressure.Text) < 28d | Conversion.Val(txtPressure.Text) > 32d))
            {
                txtPressure.BackColor = ColorTranslator.FromOle(0xFF);
                txtPressure.Focus();
                SendMsgBx("Pressure Out of Range", MessageBoxIcon.Error);
                return;
            }

            if (cboPressure.Text == "mbar" & (Conversion.Val(txtPressure.Text) < 950d | Conversion.Val(txtPressure.Text) > 1100d))
            {
                txtPressure.BackColor = ColorTranslator.FromOle(0xFF);
                txtPressure.Focus();
                SendMsgBx("Pressure Out of Range", MessageBoxIcon.Error);
                return;
            }
            // BN is Body Number from the body selected on the drop down body list - goes back to the order of the drop down list in VB6 - ugh.
            // GetValidBN access cboBody name selected and then finds the associated valid BN number for processing in the rest of the program
            // The BN is the body number  Associated with this function are the BNBodyType and the BNBodyName - See translation table at front of this module that GetValidBN uses
            GetValidBN();
            if (BNBodyName == "Polaris" & cboPolaris.Text == "Latitude by altitude of Polaris")
            {
                LatByPolaris();
                if (HoinMinutes > 4139.9d)
                {
                    SendMsgBx("Approximate latitude exceeds range of Nautical Almanac Polaris Tables.  Calculation aborted.", MessageBoxIcon.Error);
                    return;
                }

                LatByPolaris(); // need to do LatByPolaris twice to make it work
                return;
            }
            // next line added sun stuff in V5.3.1
            StarNAFlag = false;
            if (BNType == "Stars" & cboStars.Text == "NA vals. of SHA/Dec" | BNType == "Planets" & cboPlanets.Text == "NA vals. of v/d" | BNType == "Sun" & cboSun.Text == "NA val. of hourly GHA/d" | BNType == "Moon" & cboSun.Text == "NA val. of hourly GHA/d")
            {
                StarNAFlag = true;
            }

            if (StarNAFlag == true) // 1st pass for 12h of middle day
            {
                LatLong();
                ZoneTime();
                Greenwich();
                Delta_T();
                Julian();
                if (BNType == "Stars")
                {
                    Stars();
                    DENA = DE;
                    HourAngles();
                }

                if (BNType == "Planets" | BNType == "Sun" | BNType == "Moon")
                {
                    T = THour1;
                    JDHour = JDHour1;
                    Nutation();
                    Obliquity();
                    JD = JDHour1;
                    if (BNType == "Planets")
                    {
                        Planets();
                    }

                    if (BNType == "Sun" | BNType == "Moon")
                    {
                        Sun();
                    }

                    DENA1 = DE;
                    HourAnglesHour();
                    GHAHour1 = GHAHour;
                    if (BNType == "Planets")
                    {
                        FlagPlanets = true;
                    }

                    Greenwich();
                    Delta_T();
                    Julian();
                    T = THour2;
                    JDHour = JDHour2;
                    Nutation();
                    Obliquity();
                    JD = JDHour2;
                    if (BNType == "Planets")
                    {
                        Planets();
                    }

                    if (BNType == "Sun" | BNType == "Moon")
                    {
                        Sun();
                    }

                    DENA2 = DE;
                    HourAnglesHour();
                    GHAHour2 = GHAHour;
                    IandC();
                    if (BNType == "Planets")
                    {
                        FlagPlanets = false;
                    }
                }
            }

            StarNAFlag = false; // 2nd pass for date and time of sight
            LatLong();
            ZoneTime();
            Greenwich();
            Delta_T();
            Julian();
            if (BNType == "Stars")
            {
                Stars();
                DE1 = DE;
                HourAngles();
            }

            // Make StarNAFlag true again if necc.
            if (BNType == "Stars" & cboStars.Text == "NA vals. of SHA/Dec" | BNType == "Planets" & cboPlanets.Text == "NA vals. of v/d" | BNType == "Sun" & cboSun.Text == "NA val. of hourly GHA/d" | BNType == "Moon" & cboSun.Text == "NA val. of hourly GHA/d")
            {
                StarNAFlag = true;
            }

            // all bodies; does Aries for stars
            T = THour1;
            JDHour = JDHour1;
            Nutation();
            Obliquity();
            if (BNType == "Moon")
            {
                Moon();
                if (GMinute < 30)
                {
                    HPA = HP; // This is for nearest whole hour 'HPA = HP without GMinute<30 for using previous whole hour
                }
            }

            if (BNType == "Sun")
            {
                Sun();
            }

            if (BNType == "Planets")
            {
                JD = JDHour1;
                Planets();
            }

            DE1 = DE;
            HourAnglesHour();
            GHAHour1 = GHAHour;
            // not for stars
            if (BNType == "Planets" | BNType == "Moon" | BNType == "Sun")
            {
                T = THour2;
                JDHour = JDHour2;
                Nutation();
                Obliquity();
                if (BNType == "Moon")
                {
                    Moon();
                    if (GMinute >= 30)
                    {
                        HPA = HP; // This is for nearest whole hour
                    }
                }

                if (BNType == "Sun")
                {
                    Sun();
                }

                if (BNType == "Planets")
                {
                    JD = JDHour2;
                    Planets();
                }

                DE2 = DE;
                HourAnglesHour();
                GHAHour2 = GHAHour;
            }

            if (BNType == "Sun" & cboSun.Text == "NA val. of hourly GHA/d") // for Nautical Almanac value of hourly GHA of Sun
            {
                SunHourChange = GHAHour2 - GHAHour1;
                if (SunHourChange < 0d)
                {
                    SunHourChange = SunHourChange + 360d;
                }

                SunGHACorr = (15d - SunHourChange) / 2d;
                GHAHour1 = GHAHour1 - SunGHACorr;
                GHAHourDeg1 = (short)Conversion.Int(GHAHour1);
                GHAHourMin1 = (GHAHour1 - GHAHourDeg1) * 60d;
                GHAHourMin1 = Conversion.Int(GHAHourMin1 * 10d + 0.5d) / 10d;
                if (GHAHourMin1 == 60d)
                {
                    GHAHourMin1 = 0d;
                    GHAHourDeg1 = (short)(GHAHourDeg1 + 1);
                }

                TotGHA = GHAHourDeg1 + GHAHourMin1 / 60d + GHAIncrementDeg + GHAIncrementMin / 60d; // + Sgn(HourChange) * vcorr / 60
                TotGHADeg = (short)Conversion.Int(TotGHA);
                TotGHAMin = (TotGHA - TotGHADeg) * 60d;
                TotGHAMin = Conversion.Int(TotGHAMin * 10d + 0.50000000001d) / 10d; // THIS MAKES ROUNDING COME OUT RIGHT BUT GHA BETTER WITHOUT IT
                if (TotGHAMin == 60d)
                {
                    TotGHAMin = 0d;
                    TotGHADeg = (short)(TotGHADeg + 1);
                }

                if (TotGHADeg >= 360)
                {
                    TotGHADeg = (short)(TotGHADeg - 360);
                }

                LHA = TotGHADeg + TotGHAMin / 60d - Lo;
                if (LHA >= 360d)
                {
                    LHA = LHA - 360d;
                }

                if (LHA < 0d)
                {
                    LHA = LHA + 360d;
                }

                LHADeg = (short)Conversion.Int(LHA);
                LHAMin = (LHA - LHADeg) * 60d;
                if (Conversion.Int(LHAMin * 10d + 0.5d) / 10d == 60d)
                {
                    LHAMin = 0d;
                    LHADeg = (short)(LHADeg + 1);
                }
            }

            // IandC
            if (BNType == "Moon" | BNType == "Sun" | BNType == "Stars")
            {
                IandC();
            }

            if (BNType == "Planets")
            {
                if (cboPlanets.Text == "Accurate vals. of v/d")
                {
                    IandC();
                }
                else
                {
                    // If (BNType = "Planets" And cboPlanets.Text = "NA vals. of v/d") Then
                    IandCP();
                }
            }
            // Parallax PA removed from AltitudeCorrection and done here in case Parameters is done before SR Form
            AltitudeCorrection();
            if (BNType != "Moon")
            {
                HPA = HP;
            }

            PA = HPA * Math.Cos((hainMinutes + Corr2forParallax) / 60d * Pi / 180d); // the next three lines are approximated by this
            AltitudeCorrection(); // this is needed if Parameters done first
            LawOfCosines();
            if (BNType == "Moon") // Moon
            {
                PA = PA - 0.192d * Math.Sin(Lat * Pi / 180d) * Math.Sin(Lat * Pi / 180d) * Math.Cos((hainMinutes + Corr2forParallax) / 60d * Pi / 180d) + 0.192d * Math.Sin(2d * Lat * Pi / 180d) * Math.Cos(ZN * Pi / 180d) * Math.Sin((hainMinutes + Corr2forParallax) / 60d * Pi / 180d); // Nautical Almanac formula
                if (PA < 0d)
                {
                    PA = 0d;
                }

                LawOfCosines(); // in case oblateness made a difference
            }

            SaveGHA = TotGHA;
            EstimatedPosition();
            DisplaySR();
            DisplayLOC();
            btnCLSPlot.Visible = true;
            btnCustomPlot.Visible = true;
            cmdSave.Visible = true;
            cmdMerDiag.Visible = true;
            btnExpandTimeDiag.Visible = true;
            cmdMerDiag.Enabled = true;
            if (InvokedbySightLog == true)
            {
                My.MyProject.Forms.SightLog.SRFFormIntercept = Intercept;
                My.MyProject.Forms.SightLog.SRFFormZN = ZN;
            }

            return;
        }

        public void cmdSave_Click(object eventSender, EventArgs eventArgs)
        {
            II += 1;
            IU += 1;
            if (IU > 12)
            {
                SendMsgBx("Fix Form can only handle 12 fixes - A 13th fix cannot be added", MessageBoxIcon.Error);
                return;
            }

            if (IU > 1)
            {
                cmdFix.Visible = true;
                cmdFix.Enabled = true;
                cmdFix.Text = "Establish Fix for " + IU.ToString("#0") + " sights";
            }

            FDTSight[II] = DTSight.Value;
            FZT[II] = ZTTemp;
            FZH[II] = ZTHours;
            FZM[II] = ZTMinutes;
            FZS[II] = ZTSeconds;
            FUT[II] = UTinSeconds;
            FMI[II] = Intercept;
            FD[II] = "T";
            if (Intercept > 0d)
            {
                FD[II] = "A";
            }

            if (Intercept == 0d)
            {
                FD[II] = " ";
            }

            FZN[II] = ZN;
            BF[II] = GetValidBodyName();
            FL[II] = Lat;
            FLD[II] = txtLDeg.Text;
            FLM[II] = txtLMin.Text;
            FLA[II] = cboL.Text;
            FLo[II] = Lo;
            FMD[II] = Convert.ToDouble(txtLoDeg.Text);
            if (string.IsNullOrEmpty(txtLoMin.Text))
            {
                FMM[II] = 0.0d;
            }
            else
            {
                FMM[II] = Convert.ToDouble(txtLoMin.Text);
            }

            FM[II] = cboLo.Text;
            cmdSave.Visible = false;
            btnCLSPlot.Visible = false;
            btnCustomPlot.Visible = false;
            // this if statement added 9/21/2019 by hhammond. TotGHA can be zeroed out or changed in AngleHours subroutine called in DrawTimeDiagram subroutine. TotGHA is protected in SaveGHA prior to that call
            FGHA[II] = SaveGHA;
            FDec[II] = DE;       // added in V5.6.1
            FHo[II] = HoinMinutes / 60d;      // added in V5.6.1
            EP[II] = PlotOut.PlotSLEP;
            SendMsgBx("Sight reduction data saved - Enter new sight data", MessageBoxIcon.Information);
            return;
        }

        private void Form_Initialize_Renamed()
        {
            Pi = Math.PI;   // 4 * System.Math.Atan(1.0#)
            if (InvokedbySightLog == true & IU > 0)
            {
                IU = IU;
            }
            else
            {
                IU = 0;
            }

            txtZDh.BackColor = SystemColors.ButtonFace;  //ColorTranslator.FromOle(0x8000000F);
            cboZDm.SelectedIndex = 0; // "00"
            frmLimb.Visible = true;
            optLower.Checked = true;
            BNData = new BodyData[2];
            BNData[0].Bname = "Empty";
            BNData[0].BIndex = 999;
            BNData[0].BType = "Empty";

            // RA is Right Ascension hours of stars
            RA = new double[] { 2.53030102d, 0.13979405d, 0.43806971d, 0.67512237d, 0.72649196d, 1.62856849d, 2.11955753d, 2.97102075d, 3.03799227d, 3.40538065d, 4.59867741d, 5.24229787d, 5.27815529d, 5.41885085d, 5.43819817d, 5.60355929d, 5.91952924d, 6.39919719d, 6.75247703d, 6.97709679d, 7.65503287d, 7.75526399d, 8.37523211d, 9.13326624d, 9.21999319d, 9.4597898d, 10.13953074d, 11.06213019d, 11.81766044d, 12.26343617d, 12.44330439d, 12.51943314d, 12.90048595d, 13.41988313d, 13.79234379d, 14.06372347d, 14.11137457d, 14.26102008d, 14.66013772d, 14.84797587d, 14.84509067d, 15.57813003d, 16.49012803d, 16.81108191d, 17.1729687d, 17.56014444d, 17.58224182d, 17.94343608d, 18.4028662d, 18.61564901d, 18.92109048d, 19.84638861d, 20.42846051d, 20.69053187d, 21.73643281d, 22.13721819d, 22.96084625d, 23.07934827d };
            // Dec is Declination degrees of stars
            Dec = new double[] { 89.26410951d, 29.09043199d, -42.30598151d, 56.53733109d, -17.9866046d, -57.23675749d, 23.46242313d, -40.30467242d, 4.08973396d, 49.86117959d, 16.50930139d, -8.20164055d, 45.99799111d, 6.34970223d, 28.60745001d, -1.20191983d, 7.40706274d, -52.69566046d, -16.71611582d, -28.97208374d, 5.22499306d, 28.02619862d, -59.50948307d, -43.43258935d, -69.71720773d, -8.65860253d, 11.96720706d, 61.7510332d, 14.57206032d, -17.54192947d, -63.09909166d, -57.11321169d, 55.95982116d, -11.16132203d, 49.31326506d, -60.37303931d, -36.36995445d, 19.18241331d, -60.83397468d, -16.04177818d, 74.15550491d, 26.71469302d, -26.43200249d, -69.02771504d, -15.72491023d, -37.10382115d, 12.56003477d, 51.48889499d, -34.38461611d, 38.7836918d, -26.29672225d, 8.86832198d, -56.7350901d, 45.280338d, 9.87501126d, -46.96097543d, -29.62223615d, 15.20526442d };
            // RA is Right Ascension hours of stars
            // RA = New Double() {2.53030102, 0.13979405, 0.43806971, 0.67512237, 0.72649196, 1.62856849, 2.11955753, 2.97102075, 3.03799227, 3.40538065, 4.59867741, 5.24229787, 5.27815529, 5.41885085, 5.43819817, 5.60355929, 5.91952924, 6.39919719, 6.75247703, 6.97709679, 7.65503287, 7.75526399, 8.37523211, 9.13326624, 9.21999319, 9.4597898, 10.13953074, 11.06213019, 11.81766044, 12.26343617, 12.44330439, 12.51943314, 12.90048595, 13.41988313, 13.79234379, 14.06372347, 14.11137457, 14.26102008, 14.66013772, 14.84797587, 14.84509067, 15.57813003, 16.49012803, 16.81108191, 17.1729687, 17.56014444, 17.58224182, 17.94343608, 18.4028662, 18.61564901, 18.92109048, 19.84638861, 20.42746051, 20.69053187, 21.73643281, 22.13721819, 22.96084625, 23.07934827} 'RA of Peacock was 20.42846051 before V5.4.1
            // Dec is Declination degrees of stars
            // Dec = New Double() {89.26410951, 29.09043199, -42.30598151, 56.53733109, -17.9866046, -57.23675749, 23.46242313, -40.30467242, 4.08973396, 49.86117959, 16.50930139, -8.20164055, 45.99799111, 6.34970223, 28.60745001, -1.20191983, 7.40706274, -52.69566046, -16.71611582, -28.97208374, 5.22499306, 28.02619862, -59.50948307, -43.43258935, -69.71720773, -8.65860253, 11.96720706, 61.7510332, 14.57206032, -17.54192947, -63.09909166, -57.11321169, 55.95982116, -11.16132203, 49.31326506, -60.37303931, -36.36995445, 19.18241331, -60.83397468, -16.04177818, 74.15550491, 26.71469302, -26.43200249, -69.02771504, -15.72491023, -37.10382115, 12.56003477, 51.48889499, -34.38461611, 38.7836918, -26.29672225, 8.86832198, -56.7350901, 45.280338, 9.87501126, -46.96097543, -29.62223615, 15.20526442}
            // Proper motion right ascension in seconds/century
            PMRA = new double[] { 22.9526d, 1.0351d, 2.0982d, 0.6089d, 1.6317d, 1.0843d, 1.3861d, -0.468d, -0.0789d, 0.2493d, 0.4365d, 0.0126d, 0.7247d, -0.0587d, 0.1768d, 0.0099d, 0.1837d, 0.2199d, -3.8007d, 0.02d, -4.797d, -4.7254d, -0.3329d, -0.2131d, -3.032d, -0.0977d, -1.6996d, -1.9221d, -3.4374d, -1.1158d, -0.5212d, 0.3431d, 1.3308d, -0.2888d, -1.2397d, -0.458d, -4.2995d, -7.718d, -50.3145d, -0.7331d, -0.7884d, 0.8984d, -0.0756d, 0.3325d, 0.2851d, -0.0744d, 0.7519d, -0.0912d, -0.32d, 1.7192d, 0.1031d, 3.6221d, 0.0937d, 0.0148d, 0.2031d, 1.2464d, 2.5248d, 0.4221d };
            // Proper motion declination in arcseconds/century
            PMDec = new double[] { -1.1746d, -16.295d, -35.3638d, -3.217d, 3.2711d, -4.0079d, -14.5771d, 2.571d, -7.876d, -2.601d, -18.936d, -0.056d, -42.713d, -1.328d, -17.422d, -0.106d, 1.086d, 2.367d, -122.3076d, 0.229d, -103.4582d, -4.5959d, 2.272d, 1.428d, 10.8913d, 3.325d, 0.4909d, -3.5251d, 11.3783d, 2.231d, -1.473d, -26.433d, -0.8991d, -3.173d, -1.5561d, -2.506d, -51.7862d, -199.9418d, 48.2868d, -6.9d, 1.191d, -8.944d, -2.321d, -3.292d, 9.765d, -2.995d, -22.261d, -2.305d, -12.405d, 28.7459d, -5.265d, 38.5538d, -8.615d, 0.155d, 0.138d, -14.7909d, -16.4217d, -4.256d };
            // Moon
            // Table 47.A longitude and distance  +


            MDA = new double[] { 0d, 2d, 2d, 0d, 0d, 0d, 2d, 2d, 2d, 2d, 0d, 1d, 0d, 2d, 0d, 0d, 4d, 0d, 4d, 2d, 2d, 1d, 1d, 2d, 2d, 4d, 2d, 0d, 2d, 2d, 1d, 2d, 0d, 0d, 2d, 2d, 2d, 4d, 0d, 3d, 2d, 4d, 0d, 2d, 2d, 2d, 4d, 0d, 4d, 1d, 2d, 0d, 1d, 3d, 4d, 2d, 0d, 1d, 2d, 2d };
            MMA = new double[] { 0d, 0d, 0d, 0d, 1d, 0d, 0d, -1, 0d, -1, 1d, 0d, 1d, 0d, 0d, 0d, 0d, 0d, 0d, 1d, 1d, 0d, 1d, -1, 0d, 0d, 0d, 1d, 0d, -1, 0d, -2, 1d, 2d, -2, 0d, 0d, -1, 0d, 0d, 1d, -1, 2d, 2d, 1d, -1, 0d, 0d, -1, 0d, 1d, 0d, 1d, 0d, 0d, -1, 2d, 1d, 0d, 0d };
            MMprimeA = new double[] { 1d, -1, 0d, 2d, 0d, 0d, -2, -1, 1d, 0d, -1, 0d, 1d, 0d, 1d, 1d, -1, 3d, -2, -1, 0d, -1, 0d, 1d, 2d, 0d, -3, -2, -1, -2, 1d, 0d, 2d, 0d, -1, 1d, 0d, -1, 2d, -1, 1d, -2, -1, -1, -2, 0d, 1d, 4d, 0d, -2, 0d, 2d, 1d, -2, -3, 2d, 1d, -1, 3d, -1 };
            MFA = new double[] { 0d, 0d, 0d, 0d, 0d, 2d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, -2, 2d, -2, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 2d, 0d, 0d, 0d, 0d, 0d, 0d, -2, 2d, 0d, 2d, 0d, 0d, 0d, 0d, 0d, 0d, -2, 0d, 0d, 0d, 0d, -2, -2, 0d, 0d, 0d, 0d, 0d, 0d, 0d, -2 };
            MSinA = new double[] { 6288774d, 1274027d, 658314d, 213618d, -185116, -114332, 58793d, 57066d, 53322d, 45758d, -40923, -34720, -30383, 15327d, -12528, 10980d, 10675d, 10034d, 8548d, -7888, -6766, -5163, 4987d, 4036d, 3994d, 3861d, 3665d, -2689, -2602, 2390d, -2348, 2236d, -2120, -2069, 2048d, -1773, -1595, 1215d, -1110, -892, -810, 759d, -713, -700, 691d, 596d, 549d, 537d, 520d, -487, -399, -381, 351d, -340, 330d, 327d, -323, 299d, 294d, 0d };
            MCosA = new double[] { -20905355, -3699111, -2955968, -569925, 48888d, -3149, 246158d, -152138, -170733, -204586, -129620, 108743d, 104755d, 10321d, 0d, 79661d, -34782, -23210, -21636, 24208d, 30824d, -8379, -16675, -12831, -10445, -11650, 14403d, -7003, 0d, 10056d, 6322d, -9884, 5751d, 0d, -4950, 4130d, 0d, -3958, 0d, 3258d, 2616d, -1897, -2117, 2354d, 0d, 0d, -1423, -1117, -1571, -1739, 0d, -4421, 0d, 0d, 0d, 0d, 1165d, 0d, 0d, 8752d };
            // Table 47.B latitude
            MDB = new double[] { 0d, 0d, 0d, 2d, 2d, 2d, 2d, 0d, 2d, 0d, 2d, 2d, 2d, 2d, 2d, 2d, 2d, 0d, 4d, 0d, 0d, 0d, 1d, 0d, 0d, 0d, 1d, 0d, 4d, 4d, 0d, 4d, 2d, 2d, 2d, 2d, 0d, 2d, 2d, 2d, 2d, 4d, 2d, 2d, 0d, 2d, 1d, 1d, 0d, 2d, 1d, 2d, 0d, 4d, 4d, 1d, 4d, 1d, 4d, 2d };
            MMB = new double[] { 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, -1, 0d, 0d, 1d, -1, -1, -1, 1d, 0d, 1d, 0d, 1d, 0d, 1d, 1d, 1d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, -1, 0d, 0d, 0d, 0d, 1d, 1d, 0d, -1, -2, 0d, 1d, 1d, 1d, 1d, 1d, 0d, -1, 1d, 0d, -1, 0d, 0d, 0d, -1, -2 };
            MMprimeB = new double[] { 0d, 1d, 1d, 0d, -1, -1, 0d, 2d, 1d, 2d, 0d, -2, 1d, 0d, -1, 0d, -1, -1, -1, 0d, 0d, -1, 0d, 1d, 1d, 0d, 0d, 3d, 0d, -1, 1d, -2, 0d, 2d, 1d, -2, 3d, 2d, -3, -1, 0d, 0d, 1d, 0d, 1d, 1d, 0d, 0d, -2, -1, 1d, -2, 2d, -2, -1, 1d, 1d, -1, 0d, 0d };
            MFB = new double[] { 1d, 1d, -1, -1, 1d, -1, 1d, 1d, -1, -1, -1, -1, 1d, -1, 1d, 1d, -1, -1, -1, 1d, 3d, 1d, 1d, 1d, -1, -1, -1, 1d, -1, 1d, -3, 1d, -3, -1, -1, 1d, -1, 1d, -1, 1d, 1d, 1d, 1d, -1, 3d, -1, -1, 1d, -1, -1, 1d, -1, 1d, -1, -1, -1, -1, -1, -1, 1d };
            MSinB = new double[] { 5128122d, 280602d, 277693d, 173237d, 55413d, 46271d, 32573d, 17198d, 9266d, 8822d, 8216d, 4324d, 4200d, -3359, 2463d, 2211d, 2065d, -1870, 1828d, -1794, -1749, -1565, -1491, -1475, -1410, -1344, -1335, 1107d, 1021d, 833d, 777d, 671d, 607d, 596d, 491d, -451, 439d, 422d, 421d, -366, -351, 331d, 315d, 302d, -283, -229, 223d, 223d, -220, -220, -185, 181d, -177, 176d, 166d, -164, 132d, -119, 115d, 107d };
            // nutation in longitude and obliquity
            ND = new double[] { 0d, -2, 0d, 0d, 0d, 0d, -2, 0d, 0d, -2, -2, -2, 0d, 2d, 0d, 2d, 0d, 0d, -2, 0d, 2d, 0d, 0d, -2, 0d, -2, 0d, 0d, 2d, -2, 0d, -2, 0d, 0d, 2d, 2d, 0d, -2, 0d, 2d, 2d, -2, -2, 2d, 2d, 0d, -2, -2, 0d, -2, -2, 0d, -1, -2, 1d, 0d, 0d, -1, 0d, 0d, 2d, 0d, 2d };
            NM = new double[] { 0d, 0d, 0d, 0d, 1d, 0d, 1d, 0d, 0d, -1, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 2d, 0d, 2d, 1d, 0d, -1, 0d, 0d, 0d, 1d, 1d, -1, 0d, 0d, 0d, 0d, 0d, 0d, -1, -1, 0d, 0d, 0d, 1d, 0d, 0d, 1d, 0d, 0d, 0d, -1, 1d, -1, -1, 0d, -1 };
            NMprime = new double[] { 0d, 0d, 0d, 0d, 0d, 1d, 0d, 0d, 1d, 0d, 1d, 0d, -1, 0d, 1d, -1, -1, 1d, 2d, -2, 0d, 2d, 2d, 1d, 0d, 0d, -1, 0d, -1, 0d, 0d, 1d, 0d, 2d, -1, 1d, 0d, 1d, 0d, 0d, 1d, 2d, 1d, -2, 0d, 1d, 0d, 0d, 2d, 2d, 0d, 1d, 1d, 0d, 0d, 1d, -2, 1d, 1d, 1d, -1, 3d, 0d };
            NF = new double[] { 0d, 2d, 2d, 0d, 0d, 0d, 2d, 2d, 2d, 2d, 0d, 2d, 2d, 0d, 0d, 2d, 0d, 2d, 0d, 2d, 2d, 2d, 0d, 2d, 2d, 2d, 2d, 0d, 0d, 2d, 0d, 0d, 0d, -2, 2d, 2d, 2d, 0d, 2d, 2d, 0d, 2d, 2d, 0d, 0d, 0d, 2d, 0d, 2d, 0d, 2d, -2, 0d, 0d, 0d, 2d, 2d, 0d, 0d, 2d, 2d, 2d, 2d };
            NOmega = new double[] { 1d, 2d, 2d, 2d, 0d, 0d, 2d, 1d, 2d, 2d, 0d, 1d, 2d, 0d, 1d, 2d, 1d, 1d, 0d, 1d, 2d, 2d, 0d, 2d, 0d, 0d, 1d, 0d, 1d, 2d, 1d, 1d, 1d, 0d, 1d, 2d, 2d, 0d, 2d, 1d, 0d, 2d, 1d, 1d, 1d, 0d, 1d, 1d, 1d, 1d, 1d, 0d, 0d, 0d, 0d, 0d, 2d, 0d, 0d, 2d, 2d, 2d, 2d };
            NSin = new double[] { -171996, -13187, -2274, 2062d, 1426d, 712d, -517, -386, -301, 217d, -158, 129d, 123d, 63d, 63d, -59, -58, -51, 48d, 46d, -38, -31, 29d, 29d, 26d, -22, 21d, 17d, 16d, -16, -15, -13, -12, 11d, -10, -8, 7d, -7, -7, -7, 6d, 6d, 6d, -6, -6, 5d, -5, -5, -5, 4d, 4d, 4d, -4, -4, -4, 3d, -3, -3, -3, -3, -3, -3, -3 };
            NSinT = new double[] { -174.2d, -1.6d, -0.2d, 0.2d, -3.4d, 0.1d, 1.2d, -0.4d, 0d, -0.5d, 0d, 0.1d, 0d, 0d, 0.1d, 0d, -0.1d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, -0.1d, 0d, 0.1d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d };
            NCos = new double[] { 92025d, 5736d, 977d, -895, 54d, -7, 224d, 200d, 129d, -95, 0d, -70, -53, 0d, -33, 26d, 32d, 27d, 0d, -24, 16d, 13d, 0d, -12, 0d, 0d, -10, 0d, -8, 7d, 9d, 7d, 6d, 0d, 5d, 3d, -3, 0d, 3d, 3d, 0d, -3, -3, 3d, 3d, 0d, 3d, 3d, 3d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d };
            NCosT = new double[] { 8.9d, -3.1d, -0.5d, 0.5d, -0.1d, 0d, -0.6d, 0d, -0.1d, 0.3d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d };
        }

        private void FormSRF_Load(object eventSender, EventArgs eventArgs)
        {
            Form_Initialize_Renamed();
            DrawWidth = (int)(EqTPicBx.Width / 2d - 20d);
            DPen = new Pen(Color.Black, 1f);
            ptA = new Point();
            ptB = new Point();
            LoadBNData();
            Load_SunSDData();
            ClearScreen();
            if (My.MyProject.Forms.FavoriteLocations.SharedLocUse.EntryStatus == "Shared")
            {
                BringToFront();
                if (My.MyProject.Forms.FavoriteLocations.CommonYesNoMsgBox("Shared Location data is available - do you want to use it?") == true)
                {
                    {
                        var withBlock = My.MyProject.Forms.FavoriteLocations.SharedLocUse;
                        txtLDeg.Text = withBlock.DRLatDeg.ToString("00");
                        txtLMin.Text = withBlock.DRLatMin.ToString("00.0");
                        if ((withBlock.DRLatNS ?? "") == (CommonGlobals.g_LatN ?? ""))
                        {
                            cboL.SelectedIndex = 0;
                        }
                        else
                        {
                            cboL.SelectedIndex = 1;
                        }

                        txtLoDeg.Text = withBlock.DRLongDeg.ToString("00");
                        txtLoMin.Text = withBlock.DRLongMin.ToString("00.0");
                        if ((withBlock.DRLongEW ?? "") == (CommonGlobals.g_LongW ?? ""))
                        {
                            cboLo.SelectedIndex = 0;
                        }
                        else
                        {
                            cboLo.SelectedIndex = 1;
                        }

                        switch (withBlock.HorType ?? "")
                        {
                            case "Dip Short":
                                {
                                    optHorizonDipShort.Checked = true;
                                    txtDsDist.Text = withBlock.HorDist.ToString("##0.0");
                                    cboDsUnit.SelectedIndex = withBlock.HorDistIndex;
                                    break;
                                }

                            case "Artificial":
                                {
                                    optHorizonArtificial.Checked = true;
                                    break;
                                }

                            case "Natural":
                                {
                                    optHorizonNatural.Checked = true;
                                    break;
                                }

                            case "Bubble":
                                {
                                    optHorizonBubble.Checked = true;
                                    break;
                                }

                            default:
                                {
                                    optHorizonNatural.Checked = true;
                                    break;
                                }
                        }

                        if (withBlock.DST == "X")
                        {
                            chkDST.Checked = true;
                        }
                        else
                        {
                            chkDST.Checked = false;
                        }

                        if (withBlock.ZDAutoSelect == true)
                        {
                            optZDAuto.Checked = true;
                        }
                        else
                        {
                            optZDManual.Checked = true;
                            txtZDh.Text = withBlock.ZDhr.ToString();
                            if (withBlock.ZDmin == "0")
                            {
                                cboZDm.SelectedIndex = 0;
                                cboZDm.Visible = false;
                            }
                            else
                            {
                                cboZDm.Visible = true;
                                if (withBlock.ZDmin == "30")
                                {
                                    cboZDm.SelectedIndex = 1;
                                }
                                else if (withBlock.ZDmin == "45")
                                {
                                    cboZDm.SelectedIndex = 2;
                                }
                                else
                                {
                                    cboZDm.SelectedIndex = 0;
                                }
                            }
                        }

                        txtHE.Text = withBlock.HE.ToString("#0.0");
                        cboHE.SelectedIndex = withBlock.HETypeIndex;
                    }
                }
            }

            EqTPicBx.Visible = false;
            CleanOutOldFiles();
            // drawbasictimediagram causes an empty time diagram with only the verticle meridian line to be drawn
            DrawBasicTimeDiagram = true;
            DisplayTimeDiagram();
            // this toggle the boolean off so that call calls from here cause a full diagram to be drawn using data
            DrawBasicTimeDiagram = false;
            EqTPicBx.Refresh();
            FormSRFLoaded = true;
            frmLimb.Visible = true;
            frmLimb.Refresh();
        }

        private void FormSRF_FormClosed(object eventSender, FormClosedEventArgs eventArgs)
        {
            // Cleanup()
        }

        private void optHoParameters_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optHoParameters.Checked)
            {
                cmdReduce_Click(cmdReduce, new EventArgs());
            }
        }

        private void optHorizonArtificial_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optHorizonArtificial.Checked)
            {
                if (optHorizonArtificial.Checked == true)
                {
                    lblHE.Visible = false;
                    txtHE.Visible = false;
                    cboHE.Visible = false;
                    lblDsDist.Visible = false;
                    txtDsDist.Visible = false;
                    cboDsUnit.Visible = false;
                    optHorizonBubble.Checked = false;
                }
            }
        }

        private void optHorizonDipShort_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optHorizonDipShort.Checked)
            {
                if (optHorizonDipShort.Checked == true)
                {
                    lblHE.Visible = true;
                    txtHE.Visible = true;
                    cboHE.Visible = true;
                    lblDsDist.Visible = true;
                    txtDsDist.Visible = true;
                    cboDsUnit.Visible = true;
                    optHorizonBubble.Checked = false;
                }

                if (optCenter.Checked == true)
                {
                    SendMsgBx("Caution:  Improper combination of limb and horizon.", MessageBoxIcon.Warning);
                }
            }
        }

        private void optHorizonNatural_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optHorizonNatural.Checked)
            {
                if (optHorizonNatural.Checked == true)
                {
                    lblHE.Visible = true;
                    txtHE.Visible = true;
                    cboHE.Visible = true;
                    lblDsDist.Visible = false;
                    txtDsDist.Visible = false;
                    cboDsUnit.Visible = false;
                    optHorizonBubble.Checked = false;
                }

                if (optCenter.Checked == true)
                {
                    SendMsgBx("Caution:  Improper combination of limb and horizon.", MessageBoxIcon.Warning);
                }
            }
        }

        private void optHoSRForm_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optHoSRForm.Checked)
            {
                cmdReduce_Click(cmdReduce, new EventArgs());
            }
        }

        private void optHsDMm_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            {
                if (optHsDMm.Checked == true)
                {
                    txtHsSec.Visible = false;
                    lblHsSec.Visible = false;
                    txtIESec.Visible = false;
                    lblIEsec.Visible = false;
                    txtHsMin.Clear();
                    txtIEmin.Clear();
                }
            }
        }

        private void optHsDMS_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            {
                if (optHsDMS.Checked == true)
                {
                    txtHsSec.Visible = true;
                    lblHsSec.Visible = true;
                    txtIESec.Visible = true;
                    lblIEsec.Visible = true;
                    txtHsMin.Clear();
                    txtIEmin.Clear();
                    txtHsSec.Clear();
                    txtIESec.Clear();
                }
            }
        }

        private void optStdTPYes_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optStdTPYes.Checked)
            {
                lblTemperature.Visible = false;
                txtTemperature.Visible = false;
                lblTempDeg.Visible = false;
                cboTemperature.Visible = false;
                lblPressure.Visible = false;
                txtPressure.Visible = false;
                cboPressure.Visible = false;
                txtTemperature.Text = "50";
                cboTemperature.SelectedIndex = 0; // "F "
                txtPressure.Text = "29.83";
                cboPressure.SelectedIndex = 0; // "in Hg"
            }
        }

        private void optStdTPNo_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optStdTPNo.Checked)
            {
                lblTemperature.Visible = true;
                txtTemperature.Visible = true;
                lblTempDeg.Visible = true;
                cboTemperature.Visible = true;
                lblPressure.Visible = true;
                txtPressure.Visible = true;
                cboPressure.Visible = true;
            }
        }

        private void optZDAuto_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (!FormSRFLoaded)
                return;
            {
                if (optZDAuto.Checked == true)
                {
                    txtZDh.BackColor = Color.Gray;
                    txtZDh.Enabled = false;
                    lblZDh.Visible = false;
                    cboZDm.Visible = false;
                    chkDST.Visible = true;
                    lblZDDST.Visible = true;
                    lblZDm.Visible = false;
                    cboZDm.SelectedIndex = 0; // "00"
                    AutoZDCalc();
                }
            }
        }

        private void optZDManual_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            {
                if (optZDManual.Checked == true)
                {
                    txtZDh.BackColor = Control.DefaultBackColor; 
                    txtZDh.Enabled = true;
                    lblZDh.Visible = true;
                    cboZDm.Visible = true;
                    chkDST.Visible = true;
                    lblZDDST.Visible = true;
                    lblZDm.Visible = true;
                }
            }
        }

        private void optZDUT_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            {
                if (optZDUT.Checked == true)
                {
                    txtZDh.BackColor = Color.Gray;
                    txtZDh.Enabled = false;
                    lblZDh.Visible = false;
                    cboZDm.Visible = false;
                    lblZDm.Visible = false;
                    chkDST.Visible = false;
                    lblZDDST.Visible = false;
                    chkDST.CheckState = CheckState.Unchecked;
                    txtZDh.Text = "0";
                }
            }
        }

        public void cboDay_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            // If Not FormSRFLoaded Then Exit Sub
            // CheckDate()
        }

        char Period = '.';
        private void txtDsDist_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            int KeyAscii = (int)Strings.Asc(eventArgs.KeyChar);
            switch (KeyAscii)
            {
                case var @case when Strings.Asc("0") <= @case && @case <= Strings.Asc("9"):
                    {
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                case (short)('.'): // Strings.Asc('.'):
                    {
                        if (Conversions.ToBoolean(Strings.InStr(txtDsDist.Text, ".")))
                        {
                            if (KeyAscii == 46)
                            {
                                KeyAscii = 0;
                                Interaction.Beep();
                            }
                        }

                        break;
                    }

                case (char)('\b'): // (short)('\b'):
                    {
                        // Case Asc(",")
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                default:
                    {
                        KeyAscii = 0;
                        Interaction.Beep();
                        break;
                    }
            }

            eventArgs.KeyChar = (char)KeyAscii;
            if (KeyAscii == 0)
            {
                eventArgs.Handled = true;
            }
        }

        private void txtDsDist_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtDsDist;
            SelectAllText(ref argTB);
            txtDsDist = argTB;
        }

        private void txtHE_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            short KeyAscii = (short)Strings.Asc(eventArgs.KeyChar);
            switch (KeyAscii)
            {
                case var @case when Strings.Asc("0") <= @case && @case <= Strings.Asc("9"):
                    {
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                case (short)('.'): // only allows one decimal point
                    {
                        if (Conversions.ToBoolean(Strings.InStr(txtHE.Text, ".")))
                        {
                            if (KeyAscii == 46)
                            {
                                KeyAscii = 0;
                                Interaction.Beep();
                            }
                        }

                        break;
                    }

                case (short)('\b'):
                    {
                        // Case Asc(",")
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                default:
                    {
                        KeyAscii = 0;
                        Interaction.Beep();
                        break;
                    }
            }

            eventArgs.KeyChar = (char)KeyAscii;
            if (KeyAscii == 0)
            {
                eventArgs.Handled = true;
            }
        }

        private void txtHE_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtHE;
            SelectAllText(ref argTB);
            txtHE = argTB;
        }

        private void txtHsDeg_TextChanged(object eventSender, EventArgs eventArgs)
        {
            // txtHsDeg.ForeColor = &H80000008
            txtHsDeg.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtHsDeg.Text) > 145d)
            {
                txtHsDeg.BackColor = ColorTranslator.FromOle(0xFF);
                SendMsgBx("Out of Range", MessageBoxIcon.Error);
            }
        }

        private void txtHsDeg_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            short KeyAscii = (short)Strings.Asc(eventArgs.KeyChar);
            switch (KeyAscii)
            {
                case var @case when Strings.Asc("0") <= @case && @case <= Strings.Asc("9"):
                    {
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                case (short)('\b'):
                    {
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                default:
                    {
                        KeyAscii = 0;
                        Interaction.Beep();
                        break;
                    }
            }

            eventArgs.KeyChar = (char)KeyAscii;
            if (KeyAscii == 0)
            {
                eventArgs.Handled = true;
            }
        }

        private void txtHsDeg_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtHsDeg.Text) > 145d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtHsDeg_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtHsDeg;
            SelectAllText(ref argTB);
            txtHsDeg = argTB;
        }

        private void txtHsMin_TextChanged(object eventSender, EventArgs eventArgs)
        {
            // txtHsMin.ForeColor = &H80000008
            txtHsMin.BackColor = Control.DefaultBackColor; 
            if (optHsDMm.Checked == true & Conversion.Val(txtHsMin.Text) > 59.9d)
            {
                txtHsMin.BackColor = ColorTranslator.FromOle(0xFF);
                SendMsgBx("Out of Range", MessageBoxIcon.Error);
            }

            if (optHsDMS.Checked == true & Conversion.Val(txtHsMin.Text) > 59d)
            {
                txtHsMin.BackColor = ColorTranslator.FromOle(0xFF);
                SendMsgBx("Out of Range", MessageBoxIcon.Error);
            }
        }

        private void txtHsMin_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            short KeyAscii = (short)Strings.Asc(eventArgs.KeyChar);
            switch (KeyAscii)
            {
                case var @case when Strings.Asc("0") <= @case && @case <= Strings.Asc("9"):
                    {
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                case (short)('.'): // only allows one decimal point
                    {
                        if (optHsDMS.Checked == true)
                        {
                            KeyAscii = 0;
                            Interaction.Beep();
                        }
                        else if (Conversions.ToBoolean(Strings.InStr(txtHsMin.Text, ".")))
                        {
                            if (KeyAscii == 46)
                            {
                                KeyAscii = 0;
                                Interaction.Beep();
                            }
                        }

                        break;
                    }

                case (short)('\b'):
                    {
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                default:
                    {
                        KeyAscii = 0;
                        Interaction.Beep();
                        break;
                    }
            }

            eventArgs.KeyChar = (char)KeyAscii;
            if (KeyAscii == 0)
            {
                eventArgs.Handled = true;
            }
        }

        private void txtHsMin_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (optHsDMm.Checked == true & Conversion.Val(txtHsMin.Text) > 59.9d)
            {
                KeepFocus = true;
            }

            if (optHsDMS.Checked == true & Conversion.Val(txtHsMin.Text) > 59d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtHsMin_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtHsMin;
            SelectAllText(ref argTB);
            txtHsMin = argTB;
        }

        private void txtHsSec_TextChanged(object eventSender, EventArgs eventArgs)
        {
            txtHsSec.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtHsSec.Text) > 59d)
            {
                txtHsSec.BackColor = ColorTranslator.FromOle(0xFF);
                SendMsgBx("Out of Range", MessageBoxIcon.Error);
            }
        }

        private void txtHsSec_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            short KeyAscii = (short)Strings.Asc(eventArgs.KeyChar);
            switch (KeyAscii)
            {
                case var @case when Strings.Asc("0") <= @case && @case <= Strings.Asc("9"):
                    {
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                case (short)('\b'):
                    {
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                default:
                    {
                        KeyAscii = 0;
                        Interaction.Beep();
                        break;
                    }
            }

            eventArgs.KeyChar = (char)KeyAscii;
            if (KeyAscii == 0)
            {
                eventArgs.Handled = true;
            }
        }

        private void txtHsSec_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtHsSec.Text) > 59d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtHsSec_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtHsSec;
            SelectAllText(ref argTB);
            txtHsSec = argTB;
        }

        private void txtIEdeg_TextChanged(object eventSender, EventArgs eventArgs)
        {
            // This is not really necessary since only one digit is allowed
            txtIEdeg.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtIEdeg.Text) > 9d)
            {
                txtIEdeg.BackColor = ColorTranslator.FromOle(0xFF);
                SendMsgBx("Out of Range", MessageBoxIcon.Error);
            }
        }

        private void txtIEdeg_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            short KeyAscii = (short)Strings.Asc(eventArgs.KeyChar);
            switch (KeyAscii)
            {
                case var @case when Strings.Asc("0") <= @case && @case <= Strings.Asc("9"):
                    {
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                case (short)('\b'):
                    {
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                default:
                    {
                        KeyAscii = 0;
                        Interaction.Beep();
                        break;
                    }
            }

            eventArgs.KeyChar = (char)KeyAscii;
            if (KeyAscii == 0)
            {
                eventArgs.Handled = true;
            }
        }

        private void txtIEdeg_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            // This is not really necessary since only one digit is allowed
            if (Conversion.Val(txtIEdeg.Text) > 9d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtIEDeg_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtIEdeg;
            SelectAllText(ref argTB);
            txtIEdeg = argTB;
        }

        private void txtIEmin_TextChanged(object eventSender, EventArgs eventArgs)
        {
            // txtIEmin.ForeColor = &H80000008
            txtIEmin.BackColor = Control.DefaultBackColor; 
            if (optHsDMm.Checked == true & Conversion.Val(txtIEmin.Text) > 59.9d)
            {
                txtIEmin.BackColor = ColorTranslator.FromOle(0xFF);
                SendMsgBx("Out of Range", MessageBoxIcon.Error);
            }

            if (optHsDMS.Checked == true & Conversion.Val(txtIEmin.Text) > 59d)
            {
                txtIEmin.BackColor = ColorTranslator.FromOle(0xFF);
                SendMsgBx("Out of Range", MessageBoxIcon.Error);
            }
        }

        private void txtIEmin_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtIEmin;
            SelectAllText(ref argTB);
            txtIEmin = argTB;
        }

        private void txtIEmin_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            short KeyAscii = (short)Strings.Asc(eventArgs.KeyChar);
            switch (KeyAscii)
            {
                case var @case when Strings.Asc("0") <= @case && @case <= Strings.Asc("9"):
                    {
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                case (short)('.'): // only allows one decimal point
                    {
                        if (optHsDMS.Checked == true)
                        {
                            KeyAscii = 0;
                            Interaction.Beep();
                        }
                        else if (Conversions.ToBoolean(Strings.InStr(txtIEmin.Text, ".")))
                        {
                            if (KeyAscii == 46)
                            {
                                KeyAscii = 0;
                                Interaction.Beep();
                            }
                        }

                        break;
                    }

                case (short)('\b'):
                    {
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                default:
                    {
                        KeyAscii = 0;
                        Interaction.Beep();
                        break;
                    }
            }

            eventArgs.KeyChar = (char)KeyAscii;
            if (KeyAscii == 0)
            {
                eventArgs.Handled = true;
            }
        }

        private void txtIEmin_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (optHsDMm.Checked == true & Conversion.Val(txtIEmin.Text) > 59.9d)
            {
                KeepFocus = true;
            }

            if (optHsDMS.Checked == true & Conversion.Val(txtIEmin.Text) > 59d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtIESec_TextChanged(object eventSender, EventArgs eventArgs)
        {
            // txtIESec.ForeColor = &H80000008
            txtIESec.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtIESec.Text) > 59d)
            {
                txtIESec.BackColor = ColorTranslator.FromOle(0xFF);
                SendMsgBx("Out of Range", MessageBoxIcon.Error);
            }
        }

        private void txtIESec_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            short KeyAscii = (short)Strings.Asc(eventArgs.KeyChar);
            switch (KeyAscii)
            {
                case var @case when Strings.Asc("0") <= @case && @case <= Strings.Asc("9"):
                    {
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                case (short)('\b'):
                    {
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                default:
                    {
                        KeyAscii = 0;
                        Interaction.Beep();
                        break;
                    }
            }

            eventArgs.KeyChar = (char)KeyAscii;
            if (KeyAscii == 0)
            {
                eventArgs.Handled = true;
            }
        }

        private void txtIESec_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtIESec.Text) > 59d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtIESec_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtIESec;
            SelectAllText(ref argTB);
            txtIESec = argTB;
        }

        private void txtLDeg_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtLDeg.Text) != 90d)
                txtLMin.Enabled = true;
            if (Conversion.Val(txtLDeg.Text) == 90d)
            {
                txtLMin.Clear();
                txtLMin.Enabled = false;
                txtLMin.BackColor = Color.Gray;
            }
            // txtLDeg.ForeColor = &H80000008
            txtLDeg.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtLDeg.Text) > 90d)
            {
                txtLDeg.BackColor = ColorTranslator.FromOle(0xFF);
                SendMsgBx("Out of Range", MessageBoxIcon.Error);
            }

            if (Conversion.Val(txtLDeg.Text) < 90d)
            {
                txtLMin.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtLDeg_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            short KeyAscii = (short)Strings.Asc(eventArgs.KeyChar);
            switch (KeyAscii)
            {
                case var @case when Strings.Asc("0") <= @case && @case <= Strings.Asc("9"):
                    {
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                case (short)('\b'):
                    {
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                default:
                    {
                        KeyAscii = 0;
                        Interaction.Beep();
                        break;
                    }
            }

            eventArgs.KeyChar = (char)KeyAscii;
            if (KeyAscii == 0)
            {
                eventArgs.Handled = true;
            }
        }

        private void txtLDeg_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtLDeg.Text) > 90d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtLDeg_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtLDeg;
            SelectAllText(ref argTB);
            txtLDeg = argTB;
        }

        private void txtLMin_TextChanged(object eventSender, EventArgs eventArgs)
        {
            txtLMin.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtLMin.Text) > 59.9d)
            {
                txtLMin.BackColor = ColorTranslator.FromOle(0xFF);
                SendMsgBx("Out of Range", MessageBoxIcon.Error);
            }
        }

        private void txtLMin_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            short KeyAscii = (short)Strings.Asc(eventArgs.KeyChar);
            switch (KeyAscii)
            {
                case var @case when Strings.Asc("0") <= @case && @case <= Strings.Asc("9"):
                    {
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                case (short)('.'): // only allows one decimal point
                    {
                        if (Conversions.ToBoolean(Strings.InStr(txtLMin.Text, ".")))
                        {
                            if (KeyAscii == 46)
                            {
                                KeyAscii = 0;
                                Interaction.Beep();
                            }
                        }

                        break;
                    }

                case (short)('\b'):
                    {
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                default:
                    {
                        KeyAscii = 0;
                        Interaction.Beep();
                        break;
                    }
            }

            eventArgs.KeyChar = (char)KeyAscii;
            if (KeyAscii == 0)
            {
                eventArgs.Handled = true;
            }
        }

        private void txtLMin_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtLMin.Text) > 59.9d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtLMin_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtLMin;
            SelectAllText(ref argTB);
            txtLMin = argTB;
        }

        private void txtLoDeg_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtLoDeg.Text) != 180d)
                txtLoMin.Enabled = true;
            if (Conversion.Val(txtLoDeg.Text) == 180d)
            {
                txtLoMin.Clear();
                txtLoMin.Enabled = false;
                txtLoMin.BackColor = Color.Gray;
            }

            txtLoDeg.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtLoDeg.Text) > 180d | Conversion.Val(txtLoDeg.Text) == 180d & Conversion.Val(txtLoMin.Text) != 0d)
            {
                txtLoDeg.BackColor = ColorTranslator.FromOle(0xFF);
                SendMsgBx("Out of Range", MessageBoxIcon.Error);
            }

            if (Conversion.Val(txtLoDeg.Text) < 180d)
            {
                txtLoMin.BackColor = Control.DefaultBackColor; 
            }

            AutoZDCalc();
        }

        private void txtLoDeg_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            short KeyAscii = (short)Strings.Asc(eventArgs.KeyChar);
            switch (KeyAscii)
            {
                case var @case when Strings.Asc("0") <= @case && @case <= Strings.Asc("9"):
                    {
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                case (short)('\b'):
                    {
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                default:
                    {
                        KeyAscii = 0;
                        Interaction.Beep();
                        break;
                    }
            }

            eventArgs.KeyChar = (char)KeyAscii;
            if (KeyAscii == 0)
            {
                eventArgs.Handled = true;
            }
        }

        private void txtLoDeg_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtLoDeg.Text) > 180d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtLoDeg_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtLoDeg;
            SelectAllText(ref argTB);
            txtLoDeg = argTB;
        }

        private void txtLoMin_TextChanged(object eventSender, EventArgs eventArgs)
        {
            txtLoMin.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtLoMin.Text) > 59.9d)
            {
                txtLoMin.BackColor = ColorTranslator.FromOle(0xFF);
                SendMsgBx("Out of Range", MessageBoxIcon.Error);
            }

            AutoZDCalc();
        }

        private void txtLoMin_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            short KeyAscii = (short)Strings.Asc(eventArgs.KeyChar);
            switch (KeyAscii)
            {
                case var @case when Strings.Asc("0") <= @case && @case <= Strings.Asc("9"):
                    {
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                case (short)('.'): // only allows one decimal point
                    {
                        if (Conversions.ToBoolean(Strings.InStr(txtLoMin.Text, ".")))
                        {
                            if (KeyAscii == 46)
                            {
                                KeyAscii = 0;
                                Interaction.Beep();
                            }
                        }

                        break;
                    }

                case (short)('\b'):
                    {
                        // Case Asc(",")
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                default:
                    {
                        KeyAscii = 0;
                        Interaction.Beep();
                        break;
                    }
            }

            eventArgs.KeyChar = (char)KeyAscii;
            if (KeyAscii == 0)
            {
                eventArgs.Handled = true;
            }
        }

        private void txtLoMin_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtLoMin.Text) > 59.9d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtLoMin_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtLoMin;
            SelectAllText(ref argTB);
            txtLoMin = argTB;
        }

        private void txtSightNo_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            short KeyAscii = (short)Strings.Asc(eventArgs.KeyChar);
            switch (KeyAscii)
            {
                case var @case when Strings.Asc("0") <= @case && @case <= Strings.Asc("9"):
                    {
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                case (short)('\b'):
                    {
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                default:
                    {
                        KeyAscii = 0;
                        Interaction.Beep();
                        break;
                    }
            }

            eventArgs.KeyChar = (char)KeyAscii;
            if (KeyAscii == 0)
            {
                eventArgs.Handled = true;
            }
        }

        private void txtSightNo_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtSightNo;
            SelectAllText(ref argTB);
            txtSightNo = argTB;
        }

        private void txtWEMin_TextChanged(object eventSender, EventArgs eventArgs)
        {
            txtWEMin.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtWEMin.Text) > 9d)
            {
                txtWEMin.BackColor = ColorTranslator.FromOle(0xFF);
                SendMsgBx("Out of Range", MessageBoxIcon.Error);
            }
        }

        private void txtWEMin_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            short KeyAscii = (short)Strings.Asc(eventArgs.KeyChar);
            switch (KeyAscii)
            {
                case var @case when Strings.Asc("0") <= @case && @case <= Strings.Asc("9"):
                    {
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                case (short)('\b'):
                    {
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                default:
                    {
                        KeyAscii = 0;
                        Interaction.Beep();
                        break;
                    }
            }

            eventArgs.KeyChar = (char)KeyAscii;
            if (KeyAscii == 0)
            {
                eventArgs.Handled = true;
            }
        }

        private void txtWEMin_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtWEMin;
            SelectAllText(ref argTB);
            txtWEMin = argTB;
        }

        private void txtMin_Change()
        {
            // nothing in this subroutine
        }

        private void txtPressure_TextChanged(object eventSender, EventArgs eventArgs)
        {
            txtPressure.BackColor = Control.DefaultBackColor; 
            if (cboPressure.Text == "in Hg" & (Conversion.Val(txtPressure.Text) < 28d | Conversion.Val(txtPressure.Text) > 32d) & Strings.Len(txtPressure.Text) >= 2)
            {
                txtPressure.BackColor = ColorTranslator.FromOle(0xFF);
                SendMsgBx("Out of Range", MessageBoxIcon.Error);
            }

            if (cboPressure.Text == "mbar" & (Conversion.Val(txtPressure.Text) < 950d | Conversion.Val(txtPressure.Text) > 1100d) & Strings.Len(txtPressure.Text) >= 4 & optStdTPNo.Checked == true) // optStdTPNo = True added for bug going back to standard
            {
                txtPressure.BackColor = ColorTranslator.FromOle(0xFF);
                SendMsgBx("Out of Range", MessageBoxIcon.Error);
            }
        }

        private void txtPressure_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            short KeyAscii = (short)Strings.Asc(eventArgs.KeyChar);
            switch (KeyAscii)
            {
                case var @case when Strings.Asc("0") <= @case && @case <= Strings.Asc("9"):
                    {
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                case (short)('.'): // only allows one decimal point
                    {
                        if (cboPressure.Text == "mbar")
                        {
                            KeyAscii = 0;
                            Interaction.Beep();
                        }

                        if (Conversions.ToBoolean(Strings.InStr(txtPressure.Text, ".")))
                        {
                            if (KeyAscii == 46)
                            {
                                KeyAscii = 0;
                                Interaction.Beep();
                            }
                        }

                        break;
                    }

                case (short)('\b'):
                    {
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                default:
                    {
                        KeyAscii = 0;
                        Interaction.Beep();
                        break;
                    }
            }

            eventArgs.KeyChar = (char)KeyAscii;
            if (KeyAscii == 0)
            {
                eventArgs.Handled = true;
            }
        }

        private void txtPressure_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtPressure;
            SelectAllText(ref argTB);
            txtPressure = argTB;
        }

        private void txtWESec_TextChanged(object eventSender, EventArgs eventArgs)
        {
            txtWESec.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtWESec.Text) > 59d)
            {
                txtWESec.BackColor = ColorTranslator.FromOle(0xFF);
                SendMsgBx("Out of Range", MessageBoxIcon.Error);
            }
        }

        private void txtWESec_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            short KeyAscii = (short)Strings.Asc(eventArgs.KeyChar);
            switch (KeyAscii)
            {
                case var @case when Strings.Asc("0") <= @case && @case <= Strings.Asc("9"):
                    {
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                case (short)('\b'):
                    {
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                default:
                    {
                        KeyAscii = 0;
                        Interaction.Beep();
                        break;
                    }
            }

            eventArgs.KeyChar = (char)KeyAscii;
            if (KeyAscii == 0)
            {
                eventArgs.Handled = true;
            }
        }

        private void txtWESec_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtWESec.Text) > 59d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtWESec_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtWESec;
            SelectAllText(ref argTB);
            txtWESec = argTB;
        }

        private void txtTemperature_TextChanged(object eventSender, EventArgs eventArgs)
        {
            txtTemperature.BackColor = Control.DefaultBackColor; 
            if (cboTemperature.Text == "F " & (Conversion.Val(txtTemperature.Text) < -40 | Conversion.Val(txtTemperature.Text) > 130d))
            {
                txtTemperature.BackColor = ColorTranslator.FromOle(0xFF);
                SendMsgBx("Out of Range", MessageBoxIcon.Error);
            }

            if (cboTemperature.Text == "C " & (Conversion.Val(txtTemperature.Text) < -40 | Conversion.Val(txtTemperature.Text) > 55d))
            {
                txtTemperature.BackColor = ColorTranslator.FromOle(0xFF);
                SendMsgBx("Out of Range", MessageBoxIcon.Error);
            }
        }

        private void txtTemperature_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtTemperature;
            SelectAllText(ref argTB);
            txtTemperature = argTB;
        }

        private void txtTime_TextChanged(object eventSender, EventArgs eventArgs)
        {
            // txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
            // If Len(txtTime.Text) = 6 And (Val(VB.Left(txtTime.Text, 2)) > 23 Or Val(Mid(txtTime.Text, 3, 2)) > 59 Or Val(Mid(txtTime.Text, 5, 2)) > 59) Then
            // txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            // SendMsgBx("Out of Range")
            // End If
        }

        private void txtTime_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            short KeyAscii = (short)Strings.Asc(eventArgs.KeyChar);
            switch (KeyAscii)
            {
                case var @case when Strings.Asc("0") <= @case && @case <= Strings.Asc("9"):
                    {
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                case (short)('\b'):
                    {
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                default:
                    {
                        KeyAscii = 0;
                        Interaction.Beep();
                        break;
                    }
            }

            eventArgs.KeyChar = (char)KeyAscii;
            if (KeyAscii == 0)
            {
                eventArgs.Handled = true;
            }
        }

        private void txtTime_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            // Dim KeepFocus As Boolean = eventArgs.Cancel
            // If Val(VB.Left(txtTime.Text, 2)) > 23 Or Val(Mid(txtTime.Text, 3, 2)) > 59 Or Val(Mid(txtTime.Text, 5, 2)) > 59 Or Len(txtTime.Text) <> 6 Then
            // SendMsgBx("Invalid or Incomplete Time Entered")
            // KeepFocus = True
            // End If
            // If Len(txtTime.Text) = 0 Then
            // KeepFocus = False
            // End If
            // eventArgs.Cancel = KeepFocus
        }

        private void txtTime_Enter(object eventSender, EventArgs eventArgs)
        {
            // SelectAllText(txtTime)
        }

        private void txtYear_TextChanged(object eventSender, EventArgs eventArgs)
        {
            // If Not FormSRFLoaded Then Exit Sub
            // txtYear.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
            // If Len(txtYear.Text) = 4 And (Val(txtYear.Text) < 1901 Or Val(txtYear.Text) > 2099) Then
            // txtYear.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            // SendMsgBx("Out of Range")
            // End If
            // CheckDate()
        }

        private void txtYear_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            short KeyAscii = (short)Strings.Asc(eventArgs.KeyChar);
            switch (KeyAscii)
            {
                case var @case when Strings.Asc("0") <= @case && @case <= Strings.Asc("9"):
                    {
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                case (short)('\b'):
                    {
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                default:
                    {
                        KeyAscii = 0;
                        Interaction.Beep();
                        break;
                    }
            }

            eventArgs.KeyChar = (char)KeyAscii;
            if (KeyAscii == 0)
            {
                eventArgs.Handled = true;
            }
        }

        private void txtYear_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            // Dim KeepFocus As Boolean = eventArgs.Cancel
            // If Len(txtYear.Text) <> 4 Or Val(txtYear.Text) < 1901 Or Val(txtYear.Text) > 2099 Then
            // KeepFocus = True
            // End If
            // eventArgs.Cancel = KeepFocus
        }

        private void txtYear_Enter(object eventSender, EventArgs eventArgs)
        {
            // SelectAllText(txtYear)
        }

        private void txtZDh_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (optZDAuto.Checked == true | optZDUT.Checked == true)
                txtZDh.BackColor = Color.Gray;
            if (optZDManual.Checked == true)
                txtZDh.BackColor = Control.DefaultBackColor; 
            if (optZDManual.Checked == true & (Conversion.Val(txtZDh.Text) < -14 | Conversion.Val(txtZDh.Text) > 12d))
            {
                txtZDh.BackColor = ColorTranslator.FromOle(0xFF);
                SendMsgBx("Out of Range", MessageBoxIcon.Error);
            }
        }

        private void txtZDh_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            short KeyAscii = (short)Strings.Asc(eventArgs.KeyChar);
            ;
            bool bPlusSignAlready = false; // As Boolean

            bMinusSignAlready = false;
            bPlusSignAlready = false;
            switch (KeyAscii)
            {
                case (short)Keys.Back:
                case (short)Keys.Right:
                case (short)Keys.Left:
                    {
                        break;
                    }
                // do nothing
                case var @case when Strings.Asc("0") <= @case && @case <= Strings.Asc("9"):
                    {
                        break;
                    }
                // do nothing
                case (short)('-'):
                    {
                        if (txtZDh.SelectionStart != 0 | bMinusSignAlready)
                        {
                            KeyAscii = 0;
                            Interaction.Beep();
                        }
                        else
                        {
                            bMinusSignAlready = true;
                        }

                        break;
                    }

                case (short)('+'):
                    {
                        if (txtZDh.SelectionStart != 0 | bPlusSignAlready)
                        {
                            KeyAscii = 0;
                            Interaction.Beep();
                        }
                        else
                        {
                            bPlusSignAlready = true;
                        }

                        break;
                    }

                default:
                    {
                        KeyAscii = 0;
                        Interaction.Beep();
                        break;
                    }
            }

            eventArgs.KeyChar = (char)KeyAscii;
            if (KeyAscii == 0)
            {
                eventArgs.Handled = true;
            }
        }

        private void txtZDh_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtZDh.Text) < -14 | Conversion.Val(txtZDh.Text) > 12d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtZDh_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtZDh;
            SelectAllText(ref argTB);
            txtZDh = argTB;
        }

        public void AutoZDCalc()
        {
            if (optZDAuto.Checked == true)
            {
                Lo = Conversion.Val(txtLoDeg.Text) + Conversion.Val(txtLoMin.Text) / 60d;
                ZD = Conversion.Int(Lo / 15d + 0.5d);
                if (cboLo.Text == "E")
                {
                    ZD = -ZD;
                }

                if (cboLo.Text == "E")
                {
                    SignZD = "-";
                }
                else
                {
                    SignZD = "+";
                }

                txtZDh.Text = SignZD + Math.Abs(ZD);
            }

            return;
        }

        // Public Sub CheckDate()
        // On Error GoTo ErrorHandler
        // If cboDay.Text = "" Or cboMonth.Text = "" Or txtYear.Text = "" Or Len(txtYear.Text) <> 4 Then
        // Exit Sub
        // Else
        // 'DateOfSight = cboDay.Text & "/" & cboMonth.SelectedItem & "/" & txtYear.Text
        // 'Dim TempTime As String = Mid(txtTime.Text, 1, 2) & ":" & Mid(txtTime.Text, 3, 2) & ":" & Mid(txtTime.Text, 5, 2)
        // 'SightZoneDatetime = Convert.ToDateTime(DateOfSight & " " & TempTime)
        // DateOfSight = cboDay.Text & " " & cboMonth.SelectedItem & " " & txtYear.Text
        // DateOfSight = CStr(DateValue(DateOfSight))
        // End If
        // Exit Sub
        // ErrorHandler:
        // SendMsgBx("Invalid Date")
        // DateError = True
        // Exit Sub
        // End Sub

        private void cboDay_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            eventArgs.Cancel = KeepFocus;
        }

        public void LatLong()
        {
            // Next two lines for problem with commas as decimal points in Europe with Favorite Places, etc.
            LMin = Strings.Replace(txtLMin.Text, ",", ".");
            LoMin = Strings.Replace(txtLoMin.Text, ",", ".");
            Lat = Conversion.Val(txtLDeg.Text) + Conversion.Val(LMin) / 60d;
            if (cboL.Text == "S")
                Lat = -Lat;
            Lo = Conversion.Val(txtLoDeg.Text) + Conversion.Val(LoMin) / 60d;
            if (cboLo.Text == "E")
                Lo = -Lo;
        }

        public void ZoneTime()
        {
            // WT = Watch Time, WE = Watch Error, ZT = Zone Time
            WTinSeconds = 3600 * DTSight.Value.Hour + 60 * DTSight.Value.Minute + DTSight.Value.Second;
            WEinSeconds = (short)(60d * Conversion.Val(txtWEMin.Text) + Conversion.Val(txtWESec.Text));
            if (cboWE.Text == "fast")
                WEinSeconds = (short)(-WEinSeconds);
            ZTinSeconds = WTinSeconds + WEinSeconds;
            // Be sure Zone Time is not less than 0 or greater than 24 hours (86400 seconds)
            // Use ZTTemp as temporary variable
            ZTTemp = ZTinSeconds;
            if (ZTTemp > 86400)
                ZTTemp = ZTTemp - 86400;
            if (ZTTemp < 0)
                ZTTemp = ZTTemp + 86400;
            ZTHours = (short)Conversion.Int(ZTTemp / 3600d);
            ZTMinutes = (short)Conversion.Int((ZTTemp - ZTHours * 3600) / 60d);
            ZTSeconds = (short)(ZTTemp - ZTHours * 3600 - ZTMinutes * 60);
            return;
        }

        public void Greenwich()
        {
            // Prefix (or suffix) G for Greenwich, UT = Universal Time
            MonthDays = "312831303130313130313031";
            // Check for local leap year

            LocalYear = (short)DTSight.Value.Year;

            // If (LocalYear Mod 4) = 0 Then
            // LeapYear = True
            // End If
            // If (LocalYear Mod 100) = 0 And (LocalYear Mod 400) <> 0 Then
            // LeapYear = False
            // End If
            LeapYear = DateTime.IsLeapYear(LocalYear);
            if (LeapYear == true)
            {
                MonthDays = "312931303130313130313031";
            }
            else
            {
                MonthDays = "312831303130313130313031";
            }

            MonthNumber = (short)DTSight.Value.Month;
            DayNumber = (short)DTSight.Value.Day;
            var loopTo = (short)(MonthNumber - 1);
            for (i = 1; i <= loopTo; i++)
                DayNumber = (short)(Conversion.Val(Strings.Mid(MonthDays, 2 * i - 1, 2)) + DayNumber);
            // If MonthNumber >= 3 And LeapYear = True Then ' this code commented out when if leapyear monthdays statements added June 2020 
            // DayNumber = DayNumber + 1
            // End If
            // DayNumber = DTSight.Value.DayOfYear ' this does not work for some reason produces day of year one less than one provide by logic above

            ZD = Math.Abs(Conversion.Val(txtZDh.Text));
            if (optZDManual.Checked == true)
            {
                ZD = Math.Abs(ZD) + Conversion.Val(cboZDm.Text) / 60d;
            }

            if (txtZDh.Text.Substring(0, 1) == "-")
            {
                ZD = -ZD;
            }

            if ((int)chkDST.CheckState == 1)
            {
                ZD = ZD - 1d;
            }

            ZDinSeconds = (int)(3600d * ZD);
            UTinSeconds = ZTinSeconds + ZDinSeconds;
            if (StarNAFlag == true & BN != 0) // added And BN <> 0 in V5.3.1
            {
                StarDayNumber = (short)(DayNumber % 3);
                if (StarDayNumber == 1)
                    DayNumber = (short)(DayNumber + 1);
                if (StarDayNumber == 0)
                    DayNumber = (short)(DayNumber - 1);
                UTinSeconds = 43200; // 12h
                if (FlagPlanets == true)
                    UTinSeconds = 46800;
            }

            GHour = (short)Conversion.Int(UTinSeconds / 3600d);
            GMinute = (int)Conversion.Int((UTinSeconds - GHour * 3600) / 60d);
            // If (BN > 57 And BN < 62 And cboPlanets.text = "NA vals. of v/d") Then GMinuteP
            GSecond = UTinSeconds - GHour * 3600 - GMinute * 60;
            GYear = (short)DTSight.Value.Year;
            GDayOfYear = DayNumber;
            if (GHour >= 24)
            {
                GHour = (short)(GHour - 24);
                GDayOfYear = (short)(GDayOfYear + 1);
            }

            if (GDayOfYear == 366 & LeapYear == false | GDayOfYear == 367)
            {
                GDayOfYear = 1;
                GYear = (short)(GYear + 1);
                goto GreenwichDate;
            }

            if (GHour < 0)
            {
                GHour = (short)(GHour + 24);
                GDayOfYear = (short)(GDayOfYear - 1);
            }

            if (GDayOfYear == 0)
            {
                GYear = (short)(GYear - 1);
            }
            // Check for leap year at Greenwich
            // If (GYear Mod 4) = 0 Then
            // GLeapYear = True
            // End If
            // If (GYear Mod 100) = 0 And (GYear Mod 400) <> 0 Then
            // GLeapYear = False
            // End If
            GLeapYear = DateTime.IsLeapYear(GYear);
            // Days in year
            if (GDayOfYear == 0 & GLeapYear == false)
            {
                GDayOfYear = 365;
            }

            if (GDayOfYear == 0 & GLeapYear == true)
            {
                GDayOfYear = 366;
            }

        GreenwichDate:
            ;
            DayG[0] = GDayOfYear;
            if (GLeapYear == true)
            {
                MonthDays = "312931303130313130313031";
            }
            else
            {
                MonthDays = "312831303130313130313031";
            }

            for (i = 1; i <= 12; i++)
            {
                DayG[i] = (short)(DayG[i - 1] - Conversion.Val(Strings.Mid(MonthDays, 2 * i - 1, 2)));
                if (DayG[i] <= 0)
                {
                    GMonth = i;
                    GDay = DayG[i - 1];
                    goto GetMonth;
                }
            }

        GetMonth:
            ;
            MonthatG = Strings.Mid(MonthList, 3 * GMonth - 2, 3);
            return;
        }

        public void Julian()
        {
            if (StarNAFlag == true & BN != 0)
            {
                GHour = 12;
                GMinute = 0;
                GSecond = 0; // added And BN <> 0 in V5.3.1
            }

            DecimalDate = GDay + GHour / 24d + GMinute / 1440d + GSecond / 86400.0f;
            DecimalDateHour1 = GDay + GHour / 24d;
            DecimalDateHour2 = GDay + (GHour + 1) / 24d;
            GYearJ = GYear;
            if (GMonth < 3)
            {
                GYearJ = (short)(GYear - 1);
                GMonth = (short)(GMonth + 12);
            }

            JD = Conversion.Int(365.25d * (GYearJ + 4716)) + Conversion.Int(30.6001d * (GMonth + 1)) + DecimalDate - 1537.5d;
            JDHour1 = Conversion.Int(365.25d * (GYearJ + 4716)) + Conversion.Int(30.6001d * (GMonth + 1)) + DecimalDateHour1 - 1537.5d;
            JDHour2 = Conversion.Int(365.25d * (GYearJ + 4716)) + Conversion.Int(30.6001d * (GMonth + 1)) + DecimalDateHour2 - 1537.5d;
            T = (JD - 2451545d + DeltaT / 86400d) / 36525.0d;
            Tfull = T;
            THour1 = (JDHour1 - 2451545d + DeltaT / 86400d) / 36525.0d;
            THour2 = (JDHour2 - 2451545d + DeltaT / 86400d) / 36525.0d;
            return;
        }

        public void DisplaySR()
        {
            if (cboBody.SelectedItem.ToString() == "Polaris" & cboPolaris.Text == "Latitude by altitude of Polaris")
            {
            }
            // cmdEqT.Visible = False
            else
            {
                // cmdEqT.Visible = True
            }

            FormatTimeTxtBx();
            FormatLHATxtBox();
            FormatSightTxtBx();
            FormatDecTxtBx();
            FormatAltitudeTxtBx();
            return;
        }

        public void FormatTimeTxtBx()
        {
            DGTime.Visible = true;
            var AltHdr = new[] { "Category", "Info1" };
            var DataSet1 = new DataSet();
            DataSet1.Tables.Add("Table1");
            DataSet1.DataSetName = "Table1";
            DGTime.DataSource = DataSet1;
            for (int i = 0, loopTo = Information.UBound(AltHdr); i <= loopTo; i++)
            {
                DataSet1.Tables["Table1"].Columns.Add(AltHdr[i]);
                DataSet1.Tables["Table1"].Columns[i].AllowDBNull = false;
                DataSet1.Tables["Table1"].Columns[i].DefaultValue = "";
            }

            DGTime.DataSource = DataSet1.Tables[0].DefaultView;
            for (int i = 0, loopTo1 = DGTime.Columns.Count - 1; i <= loopTo1; i++)
            {
                DGTime.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DGTime.Columns[i].MinimumWidth = 112;
                // DGTime.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                DGTime.Columns[i].DefaultCellStyle.Font = DGFont; // New Font("Arial", 7, FontStyle.Regular)
            }

            DGTime.ColumnHeadersVisible = false;
            DGTime.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DGTime.DefaultCellStyle.Font = DGFont; // New Font("Arial", 7, FontStyle.Regular)
            DGTime.DefaultCellStyle.BackColor = Color.LightGray;
            DGTime.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DGTime.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGTime.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            DGTime.DefaultCellStyle.SelectionForeColor = DGTime.DefaultCellStyle.ForeColor;
            // DGTime.DefaultCellStyle.WrapMode = DataGridViewTriState.True
            // DGTime.Columns(0).MinimumWidth = 85
            // DGTime.Columns(1).MinimumWidth = 85
            // DGTime.Columns(1).MinimumWidth = 85

            // Dim tempstr1 As String = ""
            string tempstr2 = "";
            string tempstr3 = "";

            // format TIME data text box
            TimeTxtBx.Clear();
            TimeTxtBx.Font = DGFont; // New Font("Arial", 7, FontStyle.Regular)
            TimeTxtBx.SelectionAlignment = HorizontalAlignment.Center;
            TimeTxtBx.Text = "TIME";
            tempstr2 = "Date";
            tempstr3 = DTSight.Value.ToString("dd MMM yyyy");
            DataSet1.Tables["Table1"].Rows.Add(tempstr2, tempstr3);
            tempstr2 = "WT";
            tempstr3 = DTSight.Value.ToString("HH-mm-ss");
            DataSet1.Tables["Table1"].Rows.Add(tempstr2, tempstr3);
            tempstr2 = "WE" + Strings.Space(9) + "(";
            if (WEinSeconds != 0 & cboWE.Text == "fast")
            {
                tempstr2 += "-)";
            }

            if (WEinSeconds != 0 & cboWE.Text == "slow")
            {
                tempstr2 += "+)";
            }

            if (WEinSeconds == 0)
            {
                tempstr2 += " )";
            }

            tempstr3 = Strings.Space(4) + txtWEMin.Text + "-" + Conversion.Val(txtWESec.Text).ToString("00");
            DataSet1.Tables["Table1"].Rows.Add(tempstr2, tempstr3);
            tempstr2 = "ZT";
            tempstr3 = ZTHours.ToString("00") + "-" + ZTMinutes.ToString("00") + "-" + ZTSeconds.ToString("00");
            DataSet1.Tables["Table1"].Rows.Add(tempstr2, tempstr3);
            tempstr2 = "ZD" + Strings.Space(9) + "(";
            if (Math.Sign(ZD) == 1)
            {
                tempstr2 += "+)";
            }

            if (Math.Sign(ZD) == -1)
            {
                tempstr2 += "-)";
            }

            if (Math.Sign(ZD) == 0)
            {
                tempstr2 += " )";
            }

            tempstr3 = Conversion.Int(Math.Abs(ZD)).ToString("#0");
            if (optZDManual.Checked == true & cboZDm.Text != "00")
            {
                tempstr3 += "-" + cboZDm.Text;
            }

            DataSet1.Tables["Table1"].Rows.Add(tempstr2, tempstr3);
            tempstr2 = "UT (GMT)" + Strings.Space(6);
            tempstr3 = GHour.ToString("00") + "-" + GMinute.ToString("00") + "-" + GSecond.ToString("00");
            DataSet1.Tables["Table1"].Rows.Add(tempstr2, tempstr3);
            tempstr2 = "G Day/Mo/Yr" + Strings.Space(2);
            tempstr3 = Conversion.Str(GDay) + Strings.Space(1) + MonthatG + Conversion.Str(GYear);
            DataSet1.Tables["Table1"].Rows.Add(tempstr2, tempstr3);
            DGTime.ClearSelection();
            DGTime.CurrentCell = null;
            DataSet1.Dispose();
            return;
        }

        public void FormatSightTxtBx()
        {
            DGSight.Visible = true;
            var AltHdr = new[] { "Category", "Info1" };
            var DataSet1 = new DataSet();
            DataSet1.Tables.Add("Table1");
            DataSet1.DataSetName = "Table1";
            DGSight.DataSource = DataSet1;
            for (int i = 0, loopTo = Information.UBound(AltHdr); i <= loopTo; i++)
            {
                DataSet1.Tables["Table1"].Columns.Add(AltHdr[i]);
                DataSet1.Tables["Table1"].Columns[i].AllowDBNull = false;
                DataSet1.Tables["Table1"].Columns[i].DefaultValue = "";
            }

            DGSight.DataSource = DataSet1.Tables[0].DefaultView;
            for (int i = 0, loopTo1 = DGSight.Columns.Count - 1; i <= loopTo1; i++)
            {
                DGSight.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DGSight.Columns[i].MinimumWidth = 86;
                // DGSight.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                DGSight.Columns[i].DefaultCellStyle.Font = DGFont; // New Font("Arial", 7, FontStyle.Regular)
            }

            DGSight.ColumnHeadersVisible = false;
            DGSight.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DGSight.DefaultCellStyle.Font = DGFont; // New Font("Arial", 7, FontStyle.Regular)
            DGSight.DefaultCellStyle.BackColor = Color.LightGray;
            DGSight.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            DGSight.DefaultCellStyle.SelectionForeColor = DGSight.DefaultCellStyle.ForeColor;
            DGSight.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DGSight.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // DGSight.DefaultCellStyle.WrapMode = DataGridViewTriState.True
            // DGSight.Columns(0).MinimumWidth = 85
            // DGSight.Columns(1).MinimumWidth = 85
            // DGSight.Columns(1).MinimumWidth = 85

            // Dim tempstr1 As String = ""
            string tempstr2 = "";
            string tempstr3 = "";
            SightTxtBx.Clear();
            SightTxtBx.Font = TxtBxFont;
            SightTxtBx.TextAlign = HorizontalAlignment.Center;
            SightTxtBx.Font = DGFont; // New Font("Arial", 7, FontStyle.Regular)
                                      // Format SIGHT Data text box
            SightTxtBx.Text = "SIGHT DATA";
            tempstr2 = "Sight No.";
            tempstr3 = txtSightNo.Text;
            DataSet1.Tables["Table1"].Rows.Add(tempstr2, tempstr3);
            tempstr2 = "Body ";
            tempstr3 = GetValidBodyName();
            DataSet1.Tables["Table1"].Rows.Add(tempstr2, tempstr3);
            if (BN != 0 | BNBodyName == "Polaris" & cboPolaris.Text != "Latitude by altitude of Polaris" | BNBodyName == "Polaris" & cboPolaris.Text == "Latitude by altitude of Polaris" & (!string.IsNullOrEmpty(txtLDeg.Text) | !string.IsNullOrEmpty(txtLMin.Text)))
            {
                tempstr2 = "DR L ";
                tempstr3 = Strings.Format(Conversion.Val(txtLDeg.Text), "0") + '°' + Strings.Format(Conversion.Val(LMin), "00.0") + "'" + cboL.Text;
                DataSet1.Tables["Table1"].Rows.Add(tempstr2, tempstr3);
            }

            tempstr2 = "DR Lo";
            tempstr3 = Strings.Format(Conversion.Val(txtLoDeg.Text), "0") + '°' + Strings.Format(Conversion.Val(LoMin), "00.0") + "'" + cboLo.Text;
            DataSet1.Tables["Table1"].Rows.Add(tempstr2, tempstr3);
            DGSight.ClearSelection();
            DGSight.CurrentCell = null;
            DataSet1.Dispose();
            return;
        }

        public void FormatAltitudeTxtBx()
        {
            DGAlt.Visible = true;
            var AltHdr = new[] { "Category", "Info1", "Info2" };
            var DataSet1 = new DataSet();
            DataSet1.Tables.Add("Table1");
            DataSet1.DataSetName = "Table1";
            DGAlt.DataSource = DataSet1;
            for (int i = 0, loopTo = Information.UBound(AltHdr); i <= loopTo; i++)
            {
                DataSet1.Tables["Table1"].Columns.Add(AltHdr[i]);
                DataSet1.Tables["Table1"].Columns[i].AllowDBNull = false;
                DataSet1.Tables["Table1"].Columns[i].DefaultValue = "";
            }

            DGAlt.DataSource = DataSet1.Tables[0].DefaultView;
            for (int i = 0, loopTo1 = DGAlt.Columns.Count - 1; i <= loopTo1; i++)
            {
                DGAlt.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                // DGAlt.Columns(i).MinimumWidth = 86
                // DGAlt.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                DGAlt.Columns[i].DefaultCellStyle.Font = DGFont; // New Font("Arial", 7, FontStyle.Regular)
            }

            DGAlt.ColumnHeadersVisible = false;
            DGAlt.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DGAlt.DefaultCellStyle.Font = DGFont; // New Font("Arial", 7, FontStyle.Regular)
            DGAlt.DefaultCellStyle.BackColor = Color.LightGray;
            DGAlt.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            DGAlt.DefaultCellStyle.SelectionForeColor = DGAlt.DefaultCellStyle.ForeColor;
            DGAlt.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DGAlt.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGAlt.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            // DGAlt.DefaultCellStyle.WrapMode = DataGridViewTriState.True

            DGAlt.Columns[0].MinimumWidth = 85;
            DGAlt.Columns[1].MinimumWidth = 85;
            DGAlt.Columns[2].MinimumWidth = 85;
            string tempstr1 = "";
            string tempstr2 = "";
            string tempstr3 = "";
            AltitudeTxtBx.Font = DGFont; // New Font("Arial", 7, FontStyle.Regular)
                                         // Format ALTITUDE text box 
            AltitudeTxtBx.SelectionAlignment = HorizontalAlignment.Center;
            AltitudeTxtBx.Text = "ALTITUDE";
            tempstr1 = "Ht of eye";
            if (optHorizonArtificial.Checked == false)
            {
                tempstr2 = HE.ToString("0.0");
                if (cboHE.Text == "ft" | cboHE.Text == "in")
                    tempstr2 += "ft";
                if (cboHE.Text == "m " | cboHE.Text == "cm")
                    tempstr2 += "m";
            }

            tempstr3 = "";
            DataSet1.Tables["Table1"].Rows.Add(tempstr1, tempstr2, tempstr3);
            tempstr1 = "hs";
            tempstr2 = "";
            tempstr3 = "";
            tempstr3 = Conversion.Val(txtHsDeg.Text).ToString("0") + '°' + HsMin.ToString("00.0") + "'";
            DataSet1.Tables["Table1"].Rows.Add(tempstr1, tempstr2, tempstr3);
            tempstr1 = Strings.Space(4) + "IC";
            tempstr2 = "(";
            tempstr3 = "";
            if (ICinMinutes == 0d)
            {
                tempstr2 += " ";
            }

            if (cboIE.Text == "on the arc" & ICinMinutes != 0d)
            {
                tempstr2 += "-";
            }

            if ((cboIE.Text == "off the arc (rdg.)" | cboIE.Text == "off the arc (val.)") & ICinMinutes != 0d)
            {
                tempstr2 += "+";
            }

            tempstr2 += ")" + Strings.Space(1);
            if (cboIE.Text == "on the arc" | cboIE.Text == "off the arc (val.)")
            {
                tempstr2 += Conversion.Val(txtIEdeg.Text).ToString("0");
            }
            else if (cboIE.Text == "off the arc (rdg.)")
            {
                tempstr2 += Conversion.Val(Conversions.ToDouble(txtIEdeg.Text) - 1d).ToString("0");
            }
            else
            {
                tempstr2 += "0";
            }

            tempstr2 += '°' + ICMin.ToString("00.0") + "'";
            DataSet1.Tables["Table1"].Rows.Add(tempstr1, tempstr2, tempstr3);
            tempstr1 = Strings.Space(4) + "Dip";
            if (optHorizonArtificial.Checked == false)
            {
                tempstr2 = "(-) 0" + '°' + Dip().ToString("00.0") + "'";
            }
            else
            {
                tempstr2 = "";
            }

            tempstr3 = "";
            DataSet1.Tables["Table1"].Rows.Add(tempstr1, tempstr2, tempstr3);
            tempstr1 = "Total Corr";
            tempstr2 = "(";
            if (Corr1 > 0d)
                tempstr2 += "+";
            if (Corr1 == 0d)
                tempstr2 += " ";
            if (Corr1 < 0d)
                tempstr2 += "-";
            tempstr2 += ")" + Strings.Space(1) + Corr1Deg.ToString("0") + '°' + Corr1Min.ToString("00.0") + "'";
            tempstr3 = "";
            DataSet1.Tables["Table1"].Rows.Add(tempstr1, tempstr2, tempstr3);
            tempstr1 = "ha";
            tempstr2 = "";
            tempstr3 = "";
            if (Math.Sign(hainMinutes) == -1)
            {
                tempstr3 += "(-)";
            }
            else
            {
                tempstr3 += " ";
            }

            tempstr3 += Math.Abs(haDeg).ToString("0") + '°' + haMin.ToString("00.0") + "'";
            DataSet1.Tables["Table1"].Rows.Add(tempstr1, tempstr2, tempstr3);
            tempstr1 = Constants.vbTab + "HP Moon";
            if (BNType == "Moon")
            {
                tempstr2 = ((HPA * 10d + 0.5d) / 10d).ToString("00.0") + "'";
            }
            else
            {
                tempstr2 = "";
            }

            tempstr3 = "";
            DataSet1.Tables["Table1"].Rows.Add(tempstr1, tempstr2, tempstr3);
            if (optHoParameters.Checked)
            {
                tempstr1 = Conversions.ToString((Strings.Space(4) + "Refraction" + Strings.Space(4) + tempstr2 ?? "") == ("(-)" + Strings.Space(3 - Conversion.Int(Math.Abs(r)).ToString().Length) + (Conversion.Int(Math.Abs(r) * 1000d + 0.5d) / 1000d).ToString("0.000") + "'" ?? ""));
                tempstr3 = "";
                DataSet1.Tables["Table1"].Rows.Add(tempstr1, tempstr2, tempstr3);
            }

            if (optHoSRForm.Checked)
            {
                tempstr1 = Strings.Space(4) + "Main";
                tempstr2 = "(";
            }

            if (optHoSRForm.Checked & Main_Corr > 0d)
            {
                tempstr2 += "+";
            }

            if (optHoSRForm.Checked & Main_Corr == 0d)
            {
                tempstr2 += " ";
            }

            if (optHoSRForm.Checked & Main_Corr < 0d)
            {
                tempstr2 += "-";
            }

            if (optHoSRForm.Checked)
            {
                tempstr2 += ")";
                tempstr2 += Strings.Space(4 - Strings.Len(Conversion.Str(Conversion.Int(Main_Corr)))) + Math.Round(Math.Abs(Main_Corr), 2, MidpointRounding.AwayFromZero).ToString("00.0") + "'";
                DataSet1.Tables["Table1"].Rows.Add(tempstr1, tempstr2, tempstr3);
            }

            if (optHoParameters.Checked)
            {
                tempstr1 = Strings.Space(4) + "Parallax";
                tempstr2 = "(+)" + Strings.Space(4 - Strings.Len(Conversion.Str(Conversion.Int(PA)))) + PA.ToString("0.000") + "'";
                tempstr3 = "";
                DataSet1.Tables["Table1"].Rows.Add(tempstr1, tempstr2, tempstr3);
            }

            if (optHoSRForm.Checked)
            {
                if (BNBodyName == "Venus" | BNBodyName == "Mars" | BNType == "Moon") // for Mars, Venus, or the Moon
                {
                    tempstr1 = Strings.Space(4) + "Add'l (+)";
                    tempstr2 = Addl.ToString("00.0") + "'";
                    tempstr3 = "";
                    DataSet1.Tables["Table1"].Rows.Add(tempstr1, tempstr2, tempstr3);
                }
                else
                {
                    tempstr1 = "";
                    tempstr2 = "";
                    tempstr3 = "";
                }
            }

            if (optCenter.Checked)
                tempstr1 = "";
            if ((optLower.Checked | optUpper.Checked) & optHoParameters.Checked)
            {
                tempstr1 = Strings.Space(4) + "Semi-diameter" + Strings.Space(1) + "(";
            }

            if (optHoParameters.Checked & (optLower.Checked | optUpper.Checked))
            {
                if (BN == 62 | BN == 64)
                    tempstr1 += "+)"; // lower limb sun or moon
                if (BN == 63 | BN == 65)
                    tempstr1 += "-)"; // upper limb sun or moon
                if (BN < 62 | BN > 65)
                    tempstr1 += " )"; // planets or stars
                tempstr1 += Strings.Space(1) + DI.ToString("00.000") + "'";
            }

            if (optHoSRForm.Checked & BNType == "Moon") // And chkAH.CheckState = 0 Then
            {
                if (optUpper.Checked | optLower.Checked)
                {
                    tempstr1 = Strings.Space(4) + "UL ( -30.0')"; // always prints label if SR format except if artificial horizon with superimposition
                    if (optUpper.Checked == true)
                    {
                        tempstr2 = Strings.Space(3) + "(-)" + Strings.Space(3) + "30.0'";
                    }
                    else
                    {
                        tempstr2 = "";
                    }

                    tempstr3 = "";
                    DataSet1.Tables["Table1"].Rows.Add(tempstr1, tempstr2, tempstr3);
                }
            }

            if (optHoSRForm.Checked & BNType == "Moon" & optHorizonArtificial.Checked & optCenter.Checked) // And chkAH.CheckState = 1 Then
            {
                tempstr1 = Strings.Space(4) + "AH ( superimp." + "(-)" + Strings.Space(3) + "15.0'"; // artificial horizon with superimposition
            }

            if (optHoSRForm.Checked & BNType == "Moon" & optHorizonArtificial.Checked == false & optCenter.Checked)     // bubble sextant
            {
                tempstr1 = Strings.Space(4) + "Bubble sextant" + "(-)" + Strings.Space(3) + "15.0'";
            }

            // If optHoSRForm.Checked And (BNType <> "Moon") And (optUpper.Checked Or optLower.Checked) Then 'And chkAH.CheckState <> 1 Then
            // tempstr1 &= ")"
            // tempstr2 = ""
            // tempstr3 = ""
            // DataSet1.Tables("Table1").Rows.Add(tempstr1, tempstr2, tempstr3)
            // End If
            if (optHoParameters.Checked & optCenter.Checked)
            {
                tempstr1 += ")";
                tempstr2 = "";
                tempstr3 = "";
                DataSet1.Tables["Table1"].Rows.Add(tempstr1, tempstr2, tempstr3);
            }

            if (optHoParameters.Checked & BNType == "Moon" & (optLower.Checked | optUpper.Checked)) // And chkAH.CheckState = 0 Then
            {
                tempstr1 = Strings.Space(4) + "Augmentation";
                tempstr2 = "(";
                if (optHoParameters.Checked & BN == 62)
                    tempstr2 += "+)"; // Moon lower limb
                if (optHoParameters.Checked & BN == 63)
                    tempstr2 += "-)"; // Moon upper limb
                if (optHoParameters.Checked)
                    tempstr1 = Strings.Space(2) + Aug.ToString("0.000") + "'";
                DataSet1.Tables["Table1"].Rows.Add(tempstr1, tempstr2, tempstr3);
            }

            tempstr1 = "";
            tempstr2 = "";
            tempstr3 = "";
            if (optHoParameters.Checked & BN == 65 & GYear >= 1954 & GYear <= 1969)
                tempstr1 = Strings.Space(4) + "Irradiation   (-)    1.2'";
            DataSet1.Tables["Table1"].Rows.Add(tempstr1, tempstr2, tempstr3);

            // If optHoParameters.Checked And BN = 64 And GYear >= 1954 And GYear <= 1969 Then tempstr1 = 
            if (optHoSRForm.Checked)
            {
                tempstr1 = Strings.Space(4) + "Add'l Ref";
                tempstr2 = "";
                tempstr3 = "";
                DataSet1.Tables["Table1"].Rows.Add(tempstr1, tempstr2, tempstr3);
            }

            if (optHoSRForm.Checked & optStdTPNo.Checked == true)
            {
                tempstr1 = "T&B Corr";
                if (Math.Sign(Raddl) == 1)
                {
                    tempstr2 = "(-)" + Strings.Space(4) + Math.Abs(Raddl).ToString("0.0") + "'";
                }

                if (Math.Sign(Raddl) == -1)
                {
                    tempstr2 = "(+)" + Strings.Space(4) + Math.Abs(Raddl).ToString("0.0") + "'";
                }

                if (Math.Sign(Raddl) == 0)
                {
                    tempstr2 = "( )" + Strings.Space(4) + Math.Abs(Raddl).ToString("0.0") + "'";
                }

                tempstr3 = "";
                DataSet1.Tables["Table1"].Rows.Add(tempstr1, tempstr2, tempstr3);
            }
            // If optHoParameters.Checked And (GYear < 1954 Or GYear > 1969) Then
            // DataSet1.Tables("Table1").Rows.Add(tempstr1, tempstr2, tempstr3)
            // End If

            tempstr1 = "Total Corr";
            tempstr2 = "(";
            if (Corr2Min > 0d)
                tempstr2 += "+";
            if (Corr2Min == 0d)
                tempstr2 += " ";
            if (Corr2Min < 0d)
                tempstr2 += "-";
            LenCorr2Min = (short)Strings.Len(Math.Abs(Corr2Min).ToString("00.0"));
            if (Corr2Min - Conversion.Int(Corr2Min) == 0d)
            {
                LenCorr2Min = (short)(LenCorr2Min + 2);
            }

            if (LenCorr2Min < 4)
            {
                LenCorr2Min = 4;
            }

            tempstr2 += ")" + Strings.Space(8 - LenCorr2Min) + Math.Abs(Corr2Min).ToString("00.0") + "'";
            DataSet1.Tables["Table1"].Rows.Add(tempstr1, tempstr2, tempstr3);
            tempstr1 = "Ho";
            tempstr2 = "";
            tempstr3 = "";
            if (Math.Sign(HoinMinutes) == -1)
            {
                tempstr3 += "-";
            }
            else
            {
                tempstr3 += " ";
            }

            tempstr3 = Math.Abs(HoDeg).ToString("0") + '°' + Math.Abs(HoMin).ToString("00.0") + "'";
            DataSet1.Tables["Table1"].Rows.Add(tempstr1, tempstr2, tempstr3);
            if (optHorizonArtificial.Checked == true)
            {
                tempstr1 = "ha adjusted for artificial horizon";
                tempstr2 = "";
                tempstr3 = "";
                DataSet1.Tables["Table1"].Rows.Add(tempstr1, tempstr2, tempstr3);
            }

            if (BackSight == true & optHorizonArtificial.Checked == false)
            {
                tempstr1 = "ha adjusted for back sight";
                tempstr2 = "";
                tempstr3 = "";
                DataSet1.Tables["Table1"].Rows.Add(tempstr1, tempstr2, tempstr3);
            }

            DGAlt.ClearSelection();
            DGAlt.CurrentCell = null;
            DataSet1.Dispose();
            return;
        }

        public void FormatLHATxtBox()
        {
            DGLHA.Visible = true;
            var AltHdr = new[] { "Category", "Info1" };
            var DataSet1 = new DataSet();
            DataSet1.Tables.Add("Table1");
            DataSet1.DataSetName = "Table1";
            DGLHA.DataSource = DataSet1;
            for (int i = 0, loopTo = Information.UBound(AltHdr); i <= loopTo; i++)
            {
                DataSet1.Tables["Table1"].Columns.Add(AltHdr[i]);
                DataSet1.Tables["Table1"].Columns[i].AllowDBNull = false;
                DataSet1.Tables["Table1"].Columns[i].DefaultValue = "";
            }

            DGLHA.DataSource = DataSet1.Tables[0].DefaultView;
            for (int i = 0, loopTo1 = DGLHA.Columns.Count - 1; i <= loopTo1; i++)
            {
                DGLHA.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DGLHA.Columns[i].MinimumWidth = 112;
                // DGLHA.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                DGLHA.Columns[i].DefaultCellStyle.Font = DGFont; // New Font("Arial", 7, FontStyle.Regular)
            }

            DGLHA.ColumnHeadersVisible = false;
            DGLHA.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DGLHA.DefaultCellStyle.Font = DGFont; // New Font("Arial", 7, FontStyle.Regular)
            DGLHA.DefaultCellStyle.BackColor = Color.LightGray;
            DGLHA.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            DGLHA.DefaultCellStyle.SelectionForeColor = DGLHA.DefaultCellStyle.ForeColor;
            DGLHA.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DGLHA.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // DGLHA.DefaultCellStyle.WrapMode = DataGridViewTriState.True
            // DGLHA.Columns(0).MinimumWidth = 85
            // DGLHA.Columns(1).MinimumWidth = 85

            // Dim tempstr1 As String = ""
            string tempstr2 = "";
            string tempstr3 = "";
            LHATxtBx.Font = DGFont; // New Font("Arial", 7, FontStyle.Regular)
                                    // format Almanac/LHA text box data
            LHATxtBx.SelectionAlignment = HorizontalAlignment.Center;
            LHATxtBx.Text = "ALMANAC - LHA";
            tempstr2 = "SHA *";
            if (BNType == "Stars" & BN != 0 & StarNAFlag == true) // object is a star but not Polaris
            {
                tempstr3 = SHdegDisplay.ToString("0") + '°' + SHminDisplay.ToString("00.0") + "'";
            }

            if (BNType == "Stars" & BN != 0 & StarNAFlag == false)
            {
                tempstr3 = SHdeg.ToString("0") + '°' + SHmin.ToString("00.0") + "'";
            }

            if (BNBodyName == "Polaris" & cboPolaris.Text == "Full reduction of Polaris sight")
            {
                tempstr3 = SHdeg.ToString("0") + '°' + SHmin.ToString("00.0") + "'";
            }

            DataSet1.Tables["Table1"].Rows.Add(tempstr2, tempstr3);
            tempstr2 = "GHA ";
            switch (BNType ?? "")
            {
                case "Stars":
                    {
                        tempstr2 += "Aries";
                        break;
                    }

                case "Planets":
                    {
                        tempstr2 += cboBody.SelectedItem.ToString();
                        break;
                    }

                case "Moon":
                    {
                        tempstr2 += "Moon";
                        break;
                    }

                case "Sun":
                    {
                        tempstr2 += "Sun";
                        break;
                    }

                default:
                    {
                        tempstr2 += "??? Type";
                        break;
                    }
            }
            // If BNType = "Stars" Then
            // tempstr2 &= "Aries"
            // End If
            // If BNType = "Planets" Then
            // tempstr2 &= cboBody.SelectedItem.ToString
            // End If
            // If BNType = "Moon" Then
            // tempstr2 &= "Moon"
            // End If
            // If BNType = "Sun" Then
            // tempstr2 &= "Sun"
            // End If
            tempstr3 = "";
            DataSet1.Tables["Table1"].Rows.Add(tempstr2, tempstr3);
            int fmtstrint = GHAHourDeg1.ToString("0").Length;
            tempstr2 = GHour.ToString("00") + Strings.Space(1) + "hr";
            tempstr3 = GHAHourDeg1.ToString("#00") + '°' + GHAHourMin1.ToString("00.0") + "'";
            DataSet1.Tables["Table1"].Rows.Add(tempstr2, tempstr3);
            tempstr2 = Strings.Space(8) + GMinute.ToString("00") + Strings.Space(1) + "m" + Strings.Space(1) + GSecond.ToString("00") + Strings.Space(1) + "s";
            if (GMinute + GSecond != 0)
            {
                tempstr3 = Strings.Space(2) + GHAIncrementDeg.ToString("#00") + '°' + GHAIncrementMin.ToString("00.0") + "'";
            }
            else
            {
                tempstr3 = "";
            }

            DataSet1.Tables["Table1"].Rows.Add(tempstr2, tempstr3);
            tempstr2 = "v (";
            if (SignHourChange == 0 | (BN == 64 | BN == 65) & cboSun.Text == "NA val. of hourly GHA/d" | BN <= 57 | GMinute == 0 & GSecond == 0)
            {
                tempstr2 += " ) ";
            }
            else if (SignHourChange == 1)
            {
                tempstr2 += "+) ";
            }
            else if (SignHourChange == -1)
            {
                tempstr2 += "-) ";
            }

            if (BNType == "Sun" & cboSun.Text == "Accurate val. of hourly GHA" | (BNType == "Planets" | BNType == "Moon") & GMinute + GSecond != 0)
            {
                tempstr2 += Math.Abs(vvalue).ToString("0.0") + "'"; // add this for no v or d for whole hour:  And (GMinute + GSecond <> 0)
            }
            else
            {
                tempstr2 += "";
            }

            tempstr3 = "";
            DataSet1.Tables["Table1"].Rows.Add(tempstr2, tempstr3);
            Lenvcorr = (short)Strings.Len(Conversion.Str(Math.Abs(vcorr)));
            if (Lenvcorr < 4)
                Lenvcorr = 4;
            tempstr2 = Strings.Space(7) + "v corr (";
            if (SignHourChange == 0 | BNType == "Sun" & cboSun.Text == "NA val. of hourly GHA/d" | BNType == "Stars" | GMinute == 0 & GSecond == 0) // add this for no v or d for whole hour:  Or (GMinute = 0 And GSecond = 0)
            {
                tempstr2 += " ) "; // Tab(40); "ALMANAC - Dec"    'sun or stars
            }
            else if (SignHourChange == 1)
            {
                tempstr2 += "+) ";
            }
            else if (SignHourChange == -1)
            {
                tempstr2 += "-) ";
            }

            if (BNType == "Sun" & cboSun.Text == "Accurate val. of hourly GHA" | BN > 57 & BN < 64 & GMinute + GSecond != 0)
            {
                tempstr3 = Strings.Space(7) + Math.Abs(vcorr).ToString("0.0") + "'";
            }

            DataSet1.Tables["Table1"].Rows.Add(tempstr2, tempstr3);
            if (BNBodyName == "Polaris" & cboPolaris.Text == "Latitude by altitude of Polaris")
            {
                tempstr2 = "Tot GHA";
                tempstr3 = TotGHAPolDeg.ToString("0") + '°' + TotGHAPolMin.ToString("00.0") + "'";
            }
            else
            {
                tempstr2 = "Tot GHA";
                tempstr3 = TotGHADeg.ToString("0") + '°' + TotGHAMin.ToString("00.0") + "'";
            }

            DataSet1.Tables["Table1"].Rows.Add(tempstr2, tempstr3);
            tempstr2 = "DR Lo (";
            if (Lo != 0d & cboLo.Text == "W")
                tempstr2 += "-";
            if (Lo != 0d & cboLo.Text == "E")
                tempstr2 += "+";
            if (Lo == 0d)
                tempstr2 += " ";
            tempstr2 += ")";
            tempstr3 = Conversion.Val(txtLoDeg.Text).ToString("0") + '°' + Conversion.Val(LoMin).ToString("00.0") + "'";
            if (Lo != 0d)
                tempstr3 += cboLo.Text;
            DataSet1.Tables["Table1"].Rows.Add(tempstr2, tempstr3);
            if (BNBodyName == "Polaris" & cboPolaris.Text == "Latitude by altitude of Polaris")
            {
                tempstr2 = "LHA";
                tempstr3 = LHAPolDeg.ToString("0") + '°' + LHAPolMin.ToString("00.0") + "'";
            }
            else
            {
                tempstr2 = "LHA";
                tempstr3 = LHADeg.ToString("0") + '°' + LHAMin.ToString("00.0") + "'";
            }

            DataSet1.Tables["Table1"].Rows.Add(tempstr2, tempstr3);
            DGLHA.ClearSelection();
            DGLHA.CurrentCell = null;
            DataSet1.Dispose();
            return;
            // tempstr2 = vbNewLine)
        }

        public void FormatDecTxtBx()
        {
            DGDec.Visible = true;
            var AltHdr = new[] { "Category", "Info1" };
            var DataSet1 = new DataSet();
            DataSet1.Tables.Add("Table1");
            DataSet1.DataSetName = "Table1";
            DGDec.DataSource = DataSet1;
            for (int i = 0, loopTo = Information.UBound(AltHdr); i <= loopTo; i++)
            {
                DataSet1.Tables["Table1"].Columns.Add(AltHdr[i]);
                DataSet1.Tables["Table1"].Columns[i].AllowDBNull = false;
                DataSet1.Tables["Table1"].Columns[i].DefaultValue = "";
            }

            DGDec.DataSource = DataSet1.Tables[0].DefaultView;
            for (int i = 0, loopTo1 = DGDec.Columns.Count - 1; i <= loopTo1; i++)
            {
                DGDec.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DGDec.Columns[i].MinimumWidth = 86;
                // DGDec.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                DGDec.Columns[i].DefaultCellStyle.Font = DGFont; // New Font("Arial", 7, FontStyle.Regular)
            }

            DGDec.ColumnHeadersVisible = false;
            DGDec.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DGDec.DefaultCellStyle.Font = DGFont; // New Font("Arial", 7, FontStyle.Regular)
            DGDec.DefaultCellStyle.BackColor = Color.LightGray;
            DGDec.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            DGDec.DefaultCellStyle.SelectionForeColor = DGDec.DefaultCellStyle.ForeColor;
            DGDec.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DGDec.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // DGDec.DefaultCellStyle.WrapMode = DataGridViewTriState.True
            // DGDec.Columns(0).MinimumWidth = 85
            // DGDec.Columns(1).MinimumWidth = 85
            // DGDec.Columns(1).MinimumWidth = 85

            // Dim tempstr1 As String = ""
            string tempstr2 = "";
            string tempstr3 = "";
            DecTxtBx.Clear();
            DecTxtBx.Font = DGFont; // New Font("Arial", 7, FontStyle.Regular)
                                    // format Almanac DEC text box data
            DecTxtBx.TextAlign = HorizontalAlignment.Center;
            DecTxtBx.Text = "ALMANAC - Dec";
            if (BNType == "Stars")
            {
                tempstr2 = "Dec " + Strings.Space(4) + "hr";
            }
            else
            {
                tempstr2 = "Dec " + GHour.ToString("00") + " hr";
                tempstr3 = Math.Abs(DecDegrees).ToString("0") + '°' + DecMinutes.ToString("00.0") + "'";
                if (DE1 > 0d)
                    tempstr3 += CommonGlobals.g_LatN;
                if (DE1 == 0d)
                    tempstr3 += " ";
                if (DE1 < 0d)
                    tempstr3 += CommonGlobals.g_LatS;
            }

            DataSet1.Tables["Table1"].Rows.Add(tempstr2, tempstr3);
            tempstr2 = "d ("; // stars have no d correction
            if (Signdvalue == 0 | BN <= 57 | GMinute == 0 & GSecond == 0) // add this for no v or d for whole hour:  Or (GMinute = 0 And GSecond = 0)
            {
                tempstr2 += " ) ";
            }
            else if (Signdvalue == 1)
            {
                tempstr2 += "+) ";
            }
            else if (Signdvalue == -1)
            {
                tempstr2 += "-) ";
            }

            if (BNType != "Stars" & GMinute + GSecond != 0)
            {
                tempstr2 += Math.Abs(dvalue).ToString("0.0") + "'";
            }
            else
            {
                tempstr2 += "";
            }

            tempstr3 = "";
            DataSet1.Tables["Table1"].Rows.Add(tempstr2, tempstr3);
            Lendcorr = (short)Strings.Len(Conversion.Str(dcorr));
            if (Lendcorr < 4)
            {
                Lendcorr = 4;
            }

            tempstr2 = Strings.Space(4) + "d corr (";
            if (Signdvalue == 0 | BN <= 57 | GMinute == 0 & GSecond == 0) // add this for no v or d for whole hour:  Or (GMinute = 0 And GSecond = 0)
            {
                tempstr2 += " ) ";
            }
            else if (Signdvalue == 1)
            {
                tempstr2 += "+) ";
            }
            else if (Signdvalue == -1)
            {
                tempstr2 += "-) ";
            }

            if (BNType != "Stars" & GMinute + GSecond != 0)
            {
                tempstr3 = Strings.Space(7 - Lendcorr) + dcorr.ToString("0.0") + "'"; // add this for no v or d for whole hour:  And (GMinute + GSecond <> 0)
            }
            else
            {
                tempstr3 = "";
            }

            DataSet1.Tables["Table1"].Rows.Add(tempstr2, tempstr3);
            tempstr2 = "Dec";
            tempstr3 = Math.Abs(TotDecDegrees).ToString("0") + '°' + TotDecMinutes.ToString("00.0") + "'";
            if (TotDE > 0d)
                tempstr3 += CommonGlobals.g_LatN;
            if (TotDE == 0d)
                tempstr3 += " ";
            if (TotDE < 0d)
                tempstr3 += CommonGlobals.g_LatS;
            DataSet1.Tables["Table1"].Rows.Add(tempstr2, tempstr3);
            DGDec.ClearSelection();
            DGDec.CurrentCell = null;
            DataSet1.Dispose();
            return;
        }

        public double Dip()
        {
            double DipRet = default;
            HE = Conversion.Val(txtHE.Text);
            if (cboHE.Text == "ft")
            {
                HEinFeet = HE;
            }

            if (cboHE.Text == "m ")
            {
                HEinFeet = HE * 3.28095d;
            }

            if (cboHE.Text == "in")
            {
                HEinFeet = HE / 12d;
            }

            if (cboHE.Text == "cm")
            {
                HEinFeet = HE * 0.0328095d;
            }

            if (cboHE.Text == "ft" | cboHE.Text == "m ")
            {
                HE = Conversion.Int(HE * 10d + 0.5d) / 10d;
            }

            if (cboHE.Text == "in")
            {
                HE = Conversion.Int(HE / 12d * 10d + 0.5d) / 10d;
            }

            if (cboHE.Text == "cm")
            {
                HE = Conversion.Int(HE / 100d * 10d + 0.50000001d) / 10d;
            }

            DipShortDist = Conversion.Val(txtDsDist.Text);
            // Convert distance to dip short horizon to nautical miles
            if (cboDsUnit.Text == "feet")
            {
                DipShortDist = DipShortDist / 6076.1d;
            }

            if (cboDsUnit.Text == "yards")
            {
                DipShortDist = DipShortDist * 3d / 6076.1d;
            }

            if (cboDsUnit.Text == "meters")
            {
                DipShortDist = DipShortDist / 1852d;
            }

            if (cboDsUnit.Text == "statute miles")
            {
                DipShortDist = DipShortDist * 5280d / 6076.1d;
            }
            // Check if dip short distance is greater than distance to natural horizon
            if (optHorizonDipShort.Checked == true & DipShortDist > 1.169d * Math.Sqrt(HEinFeet))
            {
                SendMsgBx("Dip short distance exceeded distance to natural horizon.  Natural horizon will be used.", MessageBoxIcon.Information);
                optHorizonNatural.Checked = true;
                txtDsDist.Clear();
            }

            if (optHorizonDipShort.Checked == true)
            {
                DipRet = 10800d / Pi * Math.Atan(HEinFeet / (6076.1d * DipShortDist) + 0.8321d * DipShortDist / 6880.2d);
            }

            // Convert C to F
            Temperature = Conversion.Val(txtTemperature.Text);
            if (cboTemperature.Text == "C ")
            {
                Temperature = 5d / 9d * (Temperature - 32d);
            }
            // Convert mbar to in Hg
            Pressure = Conversion.Val(txtPressure.Text);
            if (cboPressure.Text == "mbar")
            {
                Pressure = 33.858532d * Pressure;
            }
            // Calculate dip
            if (optHorizonNatural.Checked == true & (cboHE.Text == "ft" | cboHE.Text == "in"))
            {
                switch (HE)
                {
                    case var @case when @case < 2d:
                        {
                            DipRet = 0.7d * HE;
                            break;
                        }

                    case var case1 when case1 <= 3.9d:
                        {
                            DipRet = 1.4d + (HE - 2d) * 0.25d;
                            break;
                        }

                    case var case2 when case2 <= 5.9d:
                        {
                            DipRet = 1.9d + (HE - 4d) * 0.25d;
                            break;
                        }

                    case var case3 when case3 <= 7.6d:
                        {
                            DipRet = 2.4d + (HE - 6d) * 0.15d;
                            break;
                        }

                    case var case4 when case4 >= 7.7d:
                        {
                            DipRet = 0.970003d * Math.Sqrt(HE);
                            break;
                        }
                }
            }

            if (optHorizonNatural.Checked == true & (cboHE.Text == "m " | cboHE.Text == "cm"))
            {
                switch (HE)
                {
                    case var case5 when case5 < 1d:
                        {
                            DipRet = 1.79d * HE;
                            break;
                        }

                    case var case6 when case6 <= 1.6d:
                        {
                            DipRet = 1.79d * Math.Sqrt(HE);
                            break;
                        }

                    case var case7 when case7 >= 1.7d:
                        {
                            DipRet = 1.76d * Math.Sqrt(HE);
                            break;
                        }
                }
            }

            DipRet = Conversion.Int(DipRet * 10d + 0.500000000001d) / 10d;
            return DipRet;
        }

        public void Obliquity()
        {
            // Obliquity of the ecliptic
            OE = 84381.448d - 46.816d * T - 0.00059d * T * T + 0.001813d * T * T * T; // Mean obliquity of ecliptic, arcseconds
            OE = OE / 3600d; // degrees
            OETrue = OE + NO; // degrees
            return;
        }

        public void Nutation()
        {
            NL = 0d;
            NO = 0d;
            NutD = 297.85036d + 445267.11148d * T - 0.0019142d * T * T + T * T * T / 189474d; // mean elongation of moon from sun, degrees
            if (NutD >= 360d | NutD < 0d)
                NutD = NutD - Conversion.Int(NutD / 360d) * 360d;
            NutD = NutD * Pi / 180d; // radians
            NutM = 357.52772d + 35999.05034d * T - 0.0001603d * T * T - T * T * T / 300000d; // mean anomaly of the sun (Earth), degrees
            if (NutM >= 360d | NutM < 0d)
                NutM = NutM - Conversion.Int(NutM / 360d) * 360d;
            NutM = NutM * Pi / 180d; // radians
            NutMprime = 134.96298d + 477198.867398d * T + 0.0086972d * T * T + T * T * T / 56250d; // mean anomaly of the moon, degrees
            if (NutMprime >= 360d | NutMprime < 0d)
                NutMprime = NutMprime - Conversion.Int(NutMprime / 360d) * 360d;
            NutMprime = NutMprime * Pi / 180d; // radians
            NutF = 93.27191d + 483202.017538d * T - 0.0036825d * T * T + T * T * T / 327270d; // moon's argument of latitude, degrees
            if (NutF >= 360d | NutF < 0d)
                NutF = NutF - Conversion.Int(NutF / 360d) * 360d;
            NutF = NutF * Pi / 180d; // radians
            NutOmega = 125.04452d - 1934.136261d * T + 0.0020708d * T * T + T * T * T / 450000d; // longitude of ascending node of moon..., degrees
            if (NutOmega >= 360d | NutOmega < 0d)
                NutOmega = NutOmega - Conversion.Int(NutOmega / 360d) * 360d;
            NutOmega = NutOmega * Pi / 180d; // radians
            for (i = 0; i <= 62; i++)
            {
                NL = NL + (NSin[i] + NSinT[i] * T) * Math.Sin(ND[i] * NutD + NM[i] * NutM + NMprime[i] * NutMprime + NF[i] * NutF + NOmega[i] * NutOmega); // arcseconds x 10000
                NO = NO + (NCos[i] + NCosT[i] * T) * Math.Cos(ND[i] * NutD + NM[i] * NutM + NMprime[i] * NutMprime + NF[i] * NutF + NOmega[i] * NutOmega); // arcseconds x 10000
            }

            NL = NL / 10000d / 3600d; // degrees
            NO = NO / 10000d / 3600d; // degrees
        }

        public void Stars()
        {
            AR = RA[BN];
            DE = Dec[BN];
            AR = AR * 15d; // converts AR to degrees
            NY = (JD - 2451545.0d) / 365.25d;
            // Add Proper Motion
            AR = AR + PMRA[BN] * NY * 15d / 360000d; // 'PMRA(BN) in seconds/century - divide by 100 to get seconds/year, by 3600 to get hours, mult. by 15 to get degrees
            DE = DE + PMDec[BN] * NY / 360000d; // PMDec(BN) arcseconds/century - divide by 100 to get arcseconds/year, by 3600 to get degrees
                                                // Precession
            Precession(); // this is the rigorous method; goes in with degrees, comes back as radians
            Sun(); // for sun's (mean longitude, L0, used in Nutation, and) true longitude, LN, in degrees, and Eccentricity, both used in AberrationRADec
            Nutation(); // returns nutation in longitude (NL) and nutation in obliquity (NO), both in degrees
            Obliquity(); // returns mean obliquity of the ecliptic (OE) and true obliquity (OETrue), both in degrees
            AberrationRADec(); // returns Aberration corrections to RA and Dec, AberrRA and AberrDec, both in degrees
            OETrue = OETrue * Pi / 180d; // radians
            NutRA = (Math.Cos(OETrue) + Math.Sin(OETrue) * Math.Sin(AR) * Math.Tan(DE)) * NL - Math.Cos(AR) * Math.Tan(DE) * NO; // nutation correction to RA, degrees
            NutDec = Math.Sin(OETrue) * Math.Cos(AR) * NL + Math.Sin(AR) * NO; // nutation correction to Dec, degrees
            AR = AR * 180d / Pi + NutRA + AberrRA; // RA corrected for nutation and Aberration, degrees
            DE = DE * 180d / Pi + NutDec + AberrDec; // Dec corrected for nutation and Aberration, degrees
            return;
        }

        public void AberrationRADec()
        {
            // Ecc comes from Sun
            PeriLo = 102.93735d + 1.71946d * T + 0.00046d * T * T; // Meeus pi in degrees
            PeriLo = PeriLo * Pi / 180d; // in radians
                                         // Kappa = 20.49552" (/3600) = 0.0056932º
            AberrRA = -0.0056932d * (Math.Cos(AR) * Math.Cos(LN * Pi / 180d) * Math.Cos(OETrue * Pi / 180d) + Math.Sin(AR) * Math.Sin(LN * Pi / 180d)) / Math.Cos(DE) + Ecc * 0.0056932d * (Math.Cos(AR) * Math.Cos(PeriLo) * Math.Cos(OETrue * Pi / 180d) + Math.Sin(AR) * Math.Sin(PeriLo)) / Math.Cos(DE); // degrees
            AberrDec = -0.0056932d * (Math.Cos(LN * Pi / 180d) * Math.Cos(OETrue * Pi / 180d) * (Math.Tan(OETrue * Pi / 180d) * Math.Cos(DE) - Math.Sin(AR) * Math.Sin(DE)) + Math.Cos(AR) * Math.Sin(DE) * Math.Sin(LN * Pi / 180d)) + Ecc * 0.0056932d * (Math.Cos(PeriLo) * Math.Cos(OETrue * Pi / 180d) * (Math.Tan(OETrue * Pi / 180d) * Math.Cos(DE) - Math.Sin(AR) * Math.Sin(DE)) + Math.Cos(AR) * Math.Sin(DE) * Math.Sin(PeriLo)); // degrees
        }

        public void AberrationLB()
        {
            // Ecc comes from Sun
            PeriLo = 102.93735d + 1.71946d * T + 0.00046d * T * T; // Meeus pi in degrees
            PeriLo = PeriLo * Pi / 180d; // in radians
                                         // Kappa = 20.49552" (/3600) = 0.0056932º
            AberrL = (-0.0056932d * Math.Cos(LN * Pi / 180d - L1) + 0.0056932d * Ecc * Math.Cos(PeriLo - L1)) / Math.Cos(B); // degrees
            AberrB = -0.0056932d * Math.Sin(B) * (Math.Sin(LN * Pi / 180d - L1) - Ecc * Math.Sin(PeriLo - L1)); // degrees
        }

        public void EclipticToEquatorial()
        {
            AR = Math.Atan((Math.Sin(L1) * Math.Cos(OETrue * Pi / 180d) - Math.Tan(B) * Math.Sin(OETrue * Pi / 180d)) / Math.Cos(L1)); // radians
            if (Math.Cos(L1) < 0d)
            {
                AR = AR + Pi;
            }

            if (AR >= 2d * Pi)
            {
                AR = AR - 2d * Pi;
            }

            if (AR < 0d)
            {
                AR = AR + 2d * Pi;
            }

            x = Math.Sin(B) * Math.Cos(OETrue * Pi / 180d) + Math.Cos(B) * Math.Sin(OETrue * Pi / 180d) * Math.Sin(L1);
            DE = Math.Atan(x / (Math.Sqrt(-x * x + 1d) + 9.999999E-21d)); // arcsin, radians
                                                                          // AR = AR * 180 / Pi
                                                                          // DE = DE * 180 / Pi
        }

        public void Sun()
        {
            Ecc = 0.016708634d - 0.000042037d * T - 0.0000001267d * T * T; // Ecc of Earth's orbit
            MS = 357.52911d + 35999.05029d * T - 0.0001537d * T * T; // mean anomaly of Sun, degrees
            if (MS >= 360d | MS < 0d)
                MS = MS - Conversion.Int(MS / 360d) * 360d;
            C = (1.914602d - 0.004817d * T - 0.000014d * T * T) * Math.Sin(MS * Pi / 180d) + (0.019993d - 0.000101d * T) * Math.Sin(2d * MS * Pi / 180d) + 0.000289d * Math.Sin(3d * MS * Pi / 180d); // center of Sun, degrees
            NU = MS + C; // Sun's true anomaly, degrees
            RN = 1.000001018d * (1d - Ecc * Ecc) / (1d + Ecc * Math.Cos(NU * Pi / 180d)); // Sun's radius vector (distance between centers of Sun and Earth), astronomical units
            L0 = 280.46646d + 36000.76983d * T + 0.0003032d * T * T; // geometric mean longitude of Sun, degrees
            if (L0 >= 360d | L0 < 0d)
                L0 = L0 - Conversion.Int(L0 / 360d) * 360d;
            LN = L0 + C; // Sun's true longitude, degrees
            if (BN != 64 & BN != 65)
                return; // no need to go further if not sun sight
            T = T / 10d;
            // Compute heliocentric, ecliptical Longitude L in radians
            L = EarthFunctions.Earth_L01(ref T) + EarthFunctions.Earth_L02(ref T) + EarthFunctions.Earth_L11(ref T) + EarthFunctions.Earth_L21(ref T) + EarthFunctions.Earth_L31(ref T) + EarthFunctions.Earth_L41(ref T) + EarthFunctions.Earth_L51(ref T); // radians
            if (Math.Abs(L) > 2d * Pi)
                L = L - 2d * Pi * Conversion.Int(L / 2d / Pi);
            // Compute heliocentric, ecliptical Latitude B in radians
            B = EarthFunctions.Earth_B01(ref T) + EarthFunctions.Earth_B11(ref T) + EarthFunctions.Earth_B21(ref T) + EarthFunctions.Earth_B31(ref T) + EarthFunctions.Earth_B41(ref T); // radians
                                                                                                                                                                                         // Compute heliocentric distance R in AU
            r = EarthFunctions.Earth_R01(ref T) + EarthFunctions.Earth_R02(ref T) + EarthFunctions.Earth_R11(ref T) + EarthFunctions.Earth_R21(ref T) + EarthFunctions.Earth_R31(ref T) + EarthFunctions.Earth_R41(ref T) + EarthFunctions.Earth_R51(ref T);
            L1 = L + Pi; // geocentric longitude, radians
            B = -B; // geocentric latitude, radians
            L1 = L1 * 180d / Pi; // geocentric longitude, degrees
                                 // add nutation to get apparent positions
            L1 = L1 + NL; // degrees
                          // add aberration
            L1 = L1 - 20.4898d / 3600d / r; // apparent longitude, degrees
                                            // back to radians
            L1 = L1 * Pi / 180d;
            EclipticToEquatorial();
            AR = AR * 180d / Pi; // for Meeus ecl-to-eq
            DE = DE * 180d / Pi; // for Meeus ecl-to-eq
            DI = Math.Atan(0.00465424336d / RN) * 180d / Pi * 60d;
            // back to normal T
            T = 10d * T;
        }

        public void HourAngles()
        {
            SH = 360d - AR;
            SHdeg = Conversion.Int(SH);
            SHmin = (SH - SHdeg) * 60d;
            SHmin = Conversion.Int(SHmin * 10d + 0.5d) / 10d;
            if (SHmin == 60d)
            {
                SHmin = 0d;
                SHdeg = SHdeg + 1d;
            }

            if (StarNAFlag == true) // this must be True for SHA to remain constant throughout a day
            {
                SHdegDisplay = SHdeg;
                SHminDisplay = SHmin;
                // SH = SHdegDisplay + SHminDisplay / 60
            }

            HG = UTinSeconds / 3600d;
            GHAAries = 280.46061837d + 360.98564736629d * (JD - 2451545d) + 0.000387933d * T * T - T * T * T / 38710000d; // mean GHA of Aries, degrees, only used for Time Diagram
            GHAAries = GHAAries + NL * Math.Cos(OETrue); // true GHA of Aries, degrees
            if (GHAAries >= 360d | GHAAries < 0d)
            {
                GHAAries = GHAAries - Conversion.Int(GHAAries / 360d) * 360d;
            }

            GHAAriesDeg = (short)Conversion.Int(GHAAries);
            GHAAriesMin = (GHAAries - GHAAriesDeg) * 60d;
            GHAAriesMin = Conversion.Int(GHAAriesMin * 10d + 0.5d) / 10d;
            if (GHAAriesMin == 60d)
            {
                GHAAriesMin = 0d;
                GHAAriesDeg = (short)(GHAAriesDeg + 1);
            }

            // If BN <= 57 Then GHA = GHAAries Else GHA = SH + GHAAries
            // The next three V5.6.2 changes made to correct fixes when a body was a planet
            if (BN <= 57)
            {
                GHA = GHAAriesDeg + GHAAriesMin / 60d;            // V5.6.2
            }
            // If BN<=58 and BN<=61 then use TotGHA from IandC or IandCP      'V5.6.2
            if (BN > 61)
            {
                GHA = SHdeg + SHmin / 60d + GHAAriesDeg + GHAAriesMin / 60d;       // V5.6.2
            }

            if (GHA >= 360d | GHA < 0d)
            {
                GHA = GHA - Conversion.Int(GHA / 360d) * 360d;
            }

            if (BN <= 57)
            {
                TotGHA = SH + GHA;
            }
            else
            {
                TotGHA = GHA;
            }

            if (TotGHA >= 360d | TotGHA < 0d)
            {
                TotGHA = TotGHA - Conversion.Int(TotGHA / 360d) * 360d;
            }

            TotGHAPol = TotGHA - SH;
            if (TotGHAPol >= 360d)
            {
                TotGHAPol = TotGHAPol - 360d;
            }

            if (TotGHAPol < 0d)
            {
                TotGHAPol = TotGHAPol + 360d;
            }

            TotGHAPolDeg = (short)Conversion.Int(TotGHAPol);
            TotGHAPolMin = (TotGHAPol - TotGHAPolDeg) * 60d;
            if (Conversion.Int(TotGHAPolMin * 10d + 0.5d) / 10d == 60d)
            {
                TotGHAPolMin = 0d;
                TotGHAPolDeg = (short)(TotGHAPolDeg + 1);
            }

            LHA = TotGHA - Lo;
            if (LHA >= 360d)
            {
                LHA = LHA - 360d;
            }

            if (LHA < 0d)
            {
                LHA = LHA + 360d;
            }

            LHAPol = LHA - SH;
            if (LHAPol >= 360d)
            {
                LHAPol = LHAPol - 360d;
            }

            if (LHAPol < 0d)
            {
                LHAPol = LHAPol + 360d;
            }

            TotGHADeg = (short)Conversion.Int(TotGHA);
            TotGHAMin = (TotGHA - TotGHADeg) * 60d;
            if (Conversion.Int(TotGHAMin * 10d + 0.5d) / 10d == 60d)
            {
                TotGHAMin = 0d;
                TotGHADeg = (short)(TotGHADeg + 1);
            }

            if (TotGHADeg >= 360)
            {
                TotGHADeg = (short)(TotGHADeg - 360);
            }

            LHADeg = (short)Conversion.Int(LHA);
            LHAMin = (LHA - LHADeg) * 60d;
            if (Conversion.Int(LHAMin * 10d + 0.5d) / 10d == 60d)
            {
                LHAMin = 0d;
                LHADeg = (short)(LHADeg + 1);
            }

            LHAPolDeg = (short)Conversion.Int(LHAPol);
            LHAPolMin = (LHAPol - LHAPolDeg) * 60d;
            if (Conversion.Int(LHAPolMin * 10d + 0.5d) / 10d == 60d)
            {
                LHAPolMin = 0d;
                LHAPolDeg = (short)(LHAPolDeg + 1);
            }

            if (LHAPolDeg >= 360)
            {
                LHAPolDeg = (short)(LHAPolDeg - 360);
            }

            return;
        }

        public void HourAnglesHour()
        {
            SH = 360d - AR;
            GHAAriesHour = 280.46061837d + 360.98564736629d * (JDHour - 2451545d) + 0.000387933d * T * T - T * T * T / 38710000d; // mean GHA of Aries, degrees
            GHAAriesHour = GHAAriesHour + NL * Math.Cos(OETrue * Pi / 180d); // true GHA of Aries, degrees
            if (GHAAriesHour >= 360d | GHAAriesHour < 0d)
            {
                GHAAriesHour = GHAAriesHour - Conversion.Int(GHAAriesHour / 360d) * 360d;
            }

            if (BN <= 57)
            {
                GHAHour = GHAAriesHour;
            }
            else
            {
                GHAHour = SH + GHAAriesHour;
            }

            if (GHAHour >= 360d | GHAHour < 0d)
            {
                GHAHour = GHAHour - Conversion.Int(GHAHour / 360d) * 360d;
            }

            return;
        }

        public void AltitudeCorrection()
        {
            // If optHorizonNatural.Checked = True Or optHorizonDipShort.Checked = True Then chkAH.CheckState = System.Windows.Forms.CheckState.Unchecked 'Added in V5.1.7
            if (optHsDMS.Checked == false)
            {
                txtHsSec.Clear();
                txtIESec.Clear();
            }

            ICMin = Conversion.Val(txtIEmin.Text) + Conversion.Val(txtIESec.Text) / 60d;
            if (cboIE.Text == "on the arc")
            {
                ICinMinutes = -(Conversion.Val(txtIEdeg.Text) * 60d + ICMin);
            }

            if (cboIE.Text == "off the arc (rdg.)")
            {
                ICMin = 60d - ICMin;
                if (ICMin == 60d)
                    ICMin = 0d;
                ICinMinutes = (Conversion.Val(txtIEdeg.Text) - 1d) * 60d + ICMin;
            }

            if (cboIE.Text == "off the arc (val.)")
            {
                ICinMinutes = Conversion.Val(txtIEdeg.Text) * 60d + ICMin;
            }

            Corr1 = ICinMinutes - Dip();
            Corr1Deg = (short)Conversion.Int(Math.Abs(Corr1 / 60d));
            Corr1Min = Math.Abs(Corr1) - 60 * Corr1Deg;
            hsinMinutes = 60d * Conversion.Val(txtHsDeg.Text) + Conversion.Val(txtHsMin.Text) + Conversion.Val(txtHsSec.Text) / 60d;
            HsMin = Conversion.Val(txtHsMin.Text) + Conversion.Val(txtHsSec.Text) / 60d;
            hainMinutes = hsinMinutes + Corr1;
            // SendMsgBx ("Back sight with artificial horizon not permitted."): BSwithAH = True: Exit Function
            if (optHorizonArtificial.Checked == true)
            {
                hainMinutes = (hsinMinutes + ICinMinutes) / 2d;
            }

            BackSight = false;
            if (hainMinutes >= 5400d)
            {
                hainMinutes = 10800d - hainMinutes;
                BackSight = true;
            }

            Refraction();
            if (BN == 64 | BN == 65)
            {
                HP = 60d * Math.Atan(0.0000426349651d / RN) * 180d / Pi; // 0.0000426349651 is radius of Earth in AU, RN is distance between centers of Earth and Sun in AU
            }

            if (BN == 58 | BN == 59)
            {
                HP = 60 * 180 / Pi * Math.Atan(6378.16d / (Delta * 149597871d));
            }

            if (BN <= 57 | BN == 60 | BN == 61)
            {
                HP = 0d;
            }

            var S0 = default(double);
            if (BN < 58)
            {
                DI = 0d; // stars
            }

            if (BN == 58)
            {
                S0 = 8.41d / 60d;
            }

            if (BN == 59)
            {
                S0 = 4.68d / 60d;
            }

            if (BN == 60)
            {
                S0 = 95.25d / 60d; // average of equatorial and polar values (new values) for Jupiter
            }

            if (BN == 61)
            {
                S0 = 78.275d / 60d; // 'average of equatorial and polar values (new values) for Saturn
            }

            if (BN > 57 & BN < 62)
            {
                DI = S0 / Delta;
            }
            // Semi-diameter of Moon is set in Moon sub
            if ((BN == 64 | BN == 65) & optHoSRForm.Checked)
            {
                // DI = GetSunSD(New Date(2020, GMonth, GDay)) 'Added 6/30/2020 copied Sun SD data from 2004 and 2020 almanacs and setup load sub and getSD functions using Gday and Gmonth - year is irrelevant 
                if (GMonth >= 4 & GMonth <= 9)
                {
                    DI = 15.859d;
                    PA = 0.145d * Math.Cos(hainMinutes / 60d * (Pi / 180d)); // average SD 15.859, median 15.9, Gary LaPook 15.95 (used until V5.4.0), Ron Jones 15.8583; 0.145 is average HP
                }
                else
                {
                    DI = 16.1968d;
                    PA = 0.148d * Math.Cos(hainMinutes / 60d * (Pi / 180d));
                } // average SD 16.195 (used until V5.4.0) corrected to 16.1968, median 16.15, Gary LaPook 16.15, Ron Jones 16.2167; 0.148 is average HP
            }

            if ((BN == 62 | BN == 63 | BN == 64 | BN == 65) & optCenter.Checked) // And chkAH.CheckState = 1 Then
            {
                DI = 0d;
            }

            if ((BN == 62 | BN == 63 | BN == 64 | BN == 65) & optCenter.Checked & optHoSRForm.Checked == true)  // And chkAH.CheckState = 1
            {
                PA = 0d;
            }

            Corr2Min = -r; // Was If BN <= 57 Then Corr2Min = -r, but should apply refraction to all bodies.  Changed in V5.4.0

            // Augmentation of the semi-diameter of the moon
            Aug = 0d; // Augmentation increases the size of the semi-diameter correction, whether positive or negative
            if (BN == 62 | BN == 63)
            {
                Aug = (1738d / 6378d * HPA / 60d / (1d - Math.Sin(HPA / 60d * Pi / 180d) * Math.Sin(hainMinutes / 60d * Pi / 180d)) - DI / 60d) * 60d;
                Aug = Conversion.Int(Aug * 1000d + 0.5d) / 1000d;
            }

            if ((BN == 62 | BN == 63) & optCenter.Checked) // And chkAH.CheckState = 1 Then
            {
                Aug = 0d;
            }

            if (BN == 62 | BN == 64)
            {
                Corr2Min = DI - r; // + PA 'r from Refraction
            }

            if (BN == 63 | BN == 65)
            {
                Corr2Min = -DI - r; // + PA 'r from Refraction
            }

            if (BN == 62)
            {
                Corr2Min = Corr2Min + Aug;
            }

            if (BN == 63)
            {
                Corr2Min = Corr2Min - Aug;
            }

            if (optHoParameters.Checked & BN == 65 & GYear >= 1954 & GYear <= 1969)
            {
                Corr2Min = Corr2Min - 1.2d;     // added in V5.6.2 when irradiation was removed from semi-diameter
            }

            Corr2forParallax = Corr2Min;
            Corr2Min = Corr2Min + PA; // previously calculated refraction + parallax

            // Corrections for SR Form format
            Main_Corr = 0d;
            Addl = 0d;
            if (BN <= 57 | BN == 60 | BN == 61) // stars, Jupiter, Saturn
            {
                Main_Corr = -Rstd;
                Addl = 0d;
            }

            if (BN == 58 | BN == 59) // Venus, Mars
            {
                Main_Corr = -Rstd;
                Addl = PA;
            }

            if (BN == 64 & optHoSRForm.Checked)
            {
                Main_Corr = -Rstd + PA + DI;
                Addl = 0d;
            }

            if (BN == 65 & optHoSRForm.Checked)
            {
                Main_Corr = -Rstd + PA - DI;
                if (GYear >= 1954 & GYear <= 1969)
                {
                    Main_Corr = Main_Corr - 1.2d; // 1.2' for irradiation
                }

                Addl = 0d;
            }
            // 'double comments are original based on Frank Reed
            if (BN == 62 | BN == 63) // Moon            57.7 better as 57.66
            {
                h3 = 57.66d * Math.Cos(hainMinutes / 60d * Pi / 180d);
                // Use refraction formulas from Nautical Almanac, standard temperature and pressure, dependent on year
                H2 = hainMinutes / 60d; // ha in degrees
                if (GYear <= 2003)
                {
                    r = H2 + 7.31d / (H2 + 4.4d);
                }
                else
                {
                    r = H2 + 7.32d / (H2 + 4.32d);
                }

                r = r * Pi / 180d;
                r = 1.002d / Math.Tan(r); // 1.002 is 0.0167º in minutes, actually 0.01666666.... becomes 1, but 1.002 makes it match moon table better
                Main_Corr = h3 - r + 0.2724d * 57.66d - 5d;
                h4 = Main_Corr; // h4 is Main before rounding
                Main_Corr = Conversion.Int(Main_Corr * 10d + 0.5d) / 10d;
            }

            dHP = Conversion.Int(HPA * 10d + 0.5d) / 10d; // rounds HP to 0.1'
            if (BN == 62)
                Addl = dHP * Math.Cos(H2 * Pi / 180d) - r + DI - h4;
            if (BN == 63)
                Addl = dHP * Math.Cos(H2 * Pi / 180d) - r - DI + 30d - h4;

            // If (BN = 62 Or BN = 63) And optHorizonArtificial.Checked = True Then 'And chkAH.CheckState = 1 Then
            if ((BN == 62 | BN == 63) & optCenter.Checked == true)
            {
                Addl = dHP * Math.Cos(H2 * Pi / 180d) - r - h4 + 15d;
            }

            Addl = Conversion.Int(Addl * 10d + 0.5d) / 10d;
            Raddl = Conversion.Int(Raddl * 10d + 0.5d) / 10d;
            if (optHoSRForm.Checked)
            {
                Corr2Min = Main_Corr + Addl - Raddl;
                if (BNType == "Moon" & optUpper.Checked == true) // BN = 63 Then ' Moon UL
                {
                    Corr2Min = Corr2Min - 30d;
                }

                if (BNType == "Moon" & optCenter.Checked) // And chkAH.CheckState = 1 Then
                {
                    Corr2Min = Corr2Min - 15d;
                }
            }
            // Corr2Min = System.Math.Sign(Corr2Min) * Int(System.Math.Abs(Corr2Min) * 10 + 0.5) / 10
            // Totals
            HoinMinutes = hainMinutes + Corr2Min; // minutes
            HoDeg = Conversion.Fix(HoinMinutes / 60d); // min to dec. deg.; Fix was Int
            HoMin = HoinMinutes - 60d * HoDeg;
            HoMin = Conversion.Int(HoMin * 10d + 0.5d) / 10d;
            if (HoMin == 60d)
            {
                HoMin = 0d;
                HoDeg = HoDeg + 1d;
            }

            haDeg = (short)Conversion.Fix(hainMinutes / 60d); // min. to dec. deg
            haMin = Math.Abs(hainMinutes - 60 * haDeg);
            if (Conversion.Int(haMin * 10d + 0.5d) / 10d == 60d)
            {
                haMin = 0d;
                haDeg = (short)(haDeg + 1);
            }

            return;
        }

        public void LawOfCosines()
        {
            // DecLOC = Abs(TotDE)
            DecLOC = Math.Abs(TotDecDegrees + TotDecMinutes / 60d);
            if (Math.Sign(Lat) == -Math.Sign(TotDE))
            {
                DecLOC = -DecLOC; // does not work of L=0
            }

            if (Math.Sign(Lat) == 0 & cboL.Text == "N" & TotDE <= 0d)
            {
                DecLOC = -DecLOC;
            }

            if (Math.Sign(Lat) == 0 & cboL.Text == "S" & TotDE >= 0d)
            {
                DecLOC = -DecLOC;
            }

            L1 = Math.Cos(LHA * Pi / 180d) * Math.Cos(Math.Abs(Lat) * Pi / 180d) * Math.Cos(DecLOC * Pi / 180d);
            L2 = Math.Sin(Math.Abs(Lat) * Pi / 180d) * Math.Sin(DecLOC * Pi / 180d);
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
            HcDeg = (short)Conversion.Fix(Hc);
            HcMin = (Hc - HcDeg) * 60d;
            HcMin = Conversion.Int(HcMin * 10d + 0.5d) / 10d;
            if (HcMin == 60d)
            {
                HcMin = 0d;
                if (HcDeg >= 0)
                    HcDeg = (short)(HcDeg + 1);
                if (HcDeg < 0)
                    HcDeg = (short)(HcDeg - 1);
            }

            Intercept = 60 * HcDeg + HcMin - (60d * HoDeg + HoMin);
            Intercept = Math.Sign(Intercept) * Conversion.Int(Math.Abs(Intercept) * 10d + 0.5d) / 10d;
            L4 = Math.Sin(DecLOC * Pi / 180d);
            L5 = Math.Sin(Math.Abs(Lat) * Pi / 180d) * Math.Sin(Hc * Pi / 180d);
            L6 = L4 - L5;
            L7 = Math.Cos(Math.Abs(Lat) * Pi / 180d) * Math.Cos(Hc * Pi / 180d);
            L8 = L6 / L7;
            if (Math.Abs(L8) >= 1d)
            {
                Z = Pi;
            }
            else
            {
                Z = Math.Atan(-L8 / Math.Sqrt(-L8 * L8 + 1d)) + Pi / 2d;
            }

            Z = Z * 180d / Pi;
            if (cboL.Text == "N" & LHA > 180d)
            {
                ZN = Z;
            }

            if (cboL.Text == "N" & LHA <= 180d)
            {
                ZN = 360d - Z;
            }

            if (cboL.Text == "S" & LHA > 180d)
            {
                ZN = 180d - Z;
            }

            if (cboL.Text == "S" & LHA <= 180d)
            {
                ZN = 180d + Z;
            }

            if (BN != 0 | BNBodyName == "Polaris" & cboPolaris.Text == "Full reduction of Polaris sight")
            {
                ZN = Conversion.Int(ZN + 0.5d);
            }

            if (ZN == 360d)
            {
                ZN = 0d;
            }

            return;
        }

        public void Refraction()
        {
            // Atmospheric refraction
            TX = Conversion.Val(txtTemperature.Text);
            if (cboTemperature.Text == "F ")
                TX = 5d / 9d * (TX - 32d);
            PX = Conversion.Val(txtPressure.Text);
            if (cboPressure.Text == "in Hg")
                PX = 33.85853168d * PX;
            if (optHoSRForm.Checked == true)
            {
                if (GYear <= 2003 & hainMinutes >= 596d) // And TX = 10 And ((Val(txtPressure.text) = 1010 And cboPressure.text = "mbar") Or (Val(txtPressure.text) = 29.83 And cboPressure.text = "in Hg")) And hainMinutes >= 596 Then
                {
                    switch (hainMinutes)
                    {
                        case var @case when @case <= 608d:
                            {
                                r = 5.3d;
                                break;
                            }

                        case var case1 when case1 <= 620d:
                            {
                                r = 5.2d;
                                break;
                            }

                        case var case2 when case2 <= 633d:
                            {
                                r = 5.1d;
                                break;
                            }

                        case var case3 when case3 <= 646d:
                            {
                                r = 5d;
                                break;
                            }

                        case var case4 when case4 <= 660d:
                            {
                                r = 4.9d;
                                break;
                            }

                        case var case5 when case5 <= 674d:
                            {
                                r = 4.8d;
                                break;
                            }

                        case var case6 when case6 <= 689d:
                            {
                                r = 4.7d;
                                break;
                            }

                        case var case7 when case7 <= 705d:
                            {
                                r = 4.6d;
                                break;
                            }

                        case var case8 when case8 <= 721d:
                            {
                                r = 4.5d;
                                break;
                            }

                        case var case9 when case9 <= 738d:
                            {
                                r = 4.4d;
                                break;
                            }

                        case var case10 when case10 <= 755d:
                            {
                                r = 4.3d;
                                break;
                            }

                        case var case11 when case11 <= 774d:
                            {
                                r = 4.2d;
                                break;
                            }

                        case var case12 when case12 <= 793d:
                            {
                                r = 4.1d;
                                break;
                            }

                        case var case13 when case13 <= 813d:
                            {
                                r = 4d;
                                break;
                            }

                        case var case14 when case14 <= 834d:
                            {
                                r = 3.9d;
                                break;
                            }

                        case var case15 when case15 <= 856d:
                            {
                                r = 3.8d;
                                break;
                            }

                        case var case16 when case16 <= 880d:
                            {
                                r = 3.7d;
                                break;
                            }

                        case var case17 when case17 <= 904d:
                            {
                                r = 3.6d;
                                break;
                            }

                        case var case18 when case18 <= 930d:
                            {
                                r = 3.5d;
                                break;
                            }

                        case var case19 when case19 <= 957d:
                            {
                                r = 3.4d;
                                break;
                            }

                        case var case20 when case20 <= 986d:
                            {
                                r = 3.3d;
                                break;
                            }

                        case var case21 when case21 <= 1016d:
                            {
                                r = 3.2d;
                                break;
                            }

                        case var case22 when case22 <= 1048d:
                            {
                                r = 3.1d;
                                break;
                            }

                        case var case23 when case23 <= 1082d:
                            {
                                r = 3d;
                                break;
                            }

                        case var case24 when case24 <= 1118d:
                            {
                                r = 2.9d;
                                break;
                            }

                        case var case25 when case25 <= 1157d:
                            {
                                r = 2.8d;
                                break;
                            }

                        case var case26 when case26 <= 1198d:
                            {
                                r = 2.7d;
                                break;
                            }

                        case var case27 when case27 <= 1242d:
                            {
                                r = 2.6d;
                                break;
                            }

                        case var case28 when case28 <= 1288d:
                            {
                                r = 2.5d;
                                break;
                            }

                        case var case29 when case29 <= 1339d:
                            {
                                r = 2.4d;
                                break;
                            }

                        case var case30 when case30 <= 1393d:
                            {
                                r = 2.3d;
                                break;
                            }

                        case var case31 when case31 <= 1451d:
                            {
                                r = 2.2d;
                                break;
                            }

                        case var case32 when case32 <= 1514d:
                            {
                                r = 2.1d;
                                break;
                            }

                        case var case33 when case33 <= 1582d:
                            {
                                r = 2d;
                                break;
                            }

                        case var case34 when case34 <= 1656d:
                            {
                                r = 1.9d;
                                break;
                            }

                        case var case35 when case35 <= 1736d:
                            {
                                r = 1.8d;
                                break;
                            }

                        case var case36 when case36 <= 1824d:
                            {
                                r = 1.7d;
                                break;
                            }

                        case var case37 when case37 <= 1920d:
                            {
                                r = 1.6d;
                                break;
                            }

                        case var case38 when case38 <= 2025d:
                            {
                                r = 1.5d;
                                break;
                            }

                        case var case39 when case39 <= 2140d:
                            {
                                r = 1.4d;
                                break;
                            }

                        case var case40 when case40 <= 2268d:
                            {
                                r = 1.3d;
                                break;
                            }

                        case var case41 when case41 <= 2408d:
                            {
                                r = 1.2d;
                                break;
                            }

                        case var case42 when case42 <= 2564d:
                            {
                                r = 1.1d;
                                break;
                            }

                        case var case43 when case43 <= 2736d:
                            {
                                r = 1d;
                                break;
                            }

                        case var case44 when case44 <= 2927d:
                            {
                                r = 0.9d;
                                break;
                            }

                        case var case45 when case45 <= 3138d:
                            {
                                r = 0.8d;
                                break;
                            }

                        case var case46 when case46 <= 3371d:
                            {
                                r = 0.7d;
                                break;
                            }

                        case var case47 when case47 <= 3628d:
                            {
                                r = 0.6d;
                                break;
                            }

                        case var case48 when case48 <= 3908d:
                            {
                                r = 0.5d;
                                break;
                            }

                        case var case49 when case49 <= 4211d:
                            {
                                r = 0.4d;
                                break;
                            }

                        case var case50 when case50 <= 4534d:
                            {
                                r = 0.3d;
                                break;
                            }

                        case var case51 when case51 <= 4873d:
                            {
                                r = 0.2d;
                                break;
                            }

                        case var case52 when case52 <= 5223d:
                            {
                                r = 0.1d;
                                break;
                            }

                        case var case53 when case53 <= 5400d:
                            {
                                r = 0d;
                                break;
                            }
                    }
                }

                if (GYear >= 2004 & hainMinutes >= 595d) // And TX = 10 And ((Val(txtPressure.text) = 1010 And cboPressure.text = "mbar") Or (Val(txtPressure.text) = 29.83 And cboPressure.text = "in Hg")) And hainMinutes >= 595 Then
                {
                    switch (hainMinutes)
                    {
                        case var case54 when case54 <= 607d:
                            {
                                r = 5.3d;
                                break;
                            }

                        case var case55 when case55 <= 620d:
                            {
                                r = 5.2d;
                                break;
                            }

                        case var case56 when case56 <= 632d:
                            {
                                r = 5.1d;
                                break;
                            }

                        case var case57 when case57 <= 646d:
                            {
                                r = 5d;
                                break;
                            }

                        case var case58 when case58 <= 659d:
                            {
                                r = 4.9d;
                                break;
                            }

                        case var case59 when case59 <= 674d:
                            {
                                r = 4.8d;
                                break;
                            }

                        case var case60 when case60 <= 689d:
                            {
                                r = 4.7d;
                                break;
                            }

                        case var case61 when case61 <= 704d:
                            {
                                r = 4.6d;
                                break;
                            }

                        case var case62 when case62 <= 720d:
                            {
                                r = 4.5d;
                                break;
                            }

                        case var case63 when case63 <= 737d:
                            {
                                r = 4.4d;
                                break;
                            }

                        case var case64 when case64 <= 755d:
                            {
                                r = 4.3d;
                                break;
                            }

                        case var case65 when case65 <= 773d:
                            {
                                r = 4.2d;
                                break;
                            }

                        case var case66 when case66 <= 792d:
                            {
                                r = 4.1d;
                                break;
                            }

                        case var case67 when case67 <= 812d:
                            {
                                r = 4d;
                                break;
                            }

                        case var case68 when case68 <= 833d:
                            {
                                r = 3.9d;
                                break;
                            }

                        case var case69 when case69 <= 856d:
                            {
                                r = 3.8d;
                                break;
                            }

                        case var case70 when case70 <= 879d:
                            {
                                r = 3.7d;
                                break;
                            }

                        case var case71 when case71 <= 903d:
                            {
                                r = 3.6d;
                                break;
                            }

                        case var case72 when case72 <= 929d:
                            {
                                r = 3.5d;
                                break;
                            }

                        case var case73 when case73 <= 956d:
                            {
                                r = 3.4d;
                                break;
                            }

                        case var case74 when case74 <= 985d:
                            {
                                r = 3.3d;
                                break;
                            }

                        case var case75 when case75 <= 1015d:
                            {
                                r = 3.2d;
                                break;
                            }

                        case var case76 when case76 <= 1047d:
                            {
                                r = 3.1d;
                                break;
                            }

                        case var case77 when case77 <= 1081d:
                            {
                                r = 3d;
                                break;
                            }

                        case var case78 when case78 <= 1117d:
                            {
                                r = 2.9d;
                                break;
                            }

                        case var case79 when case79 <= 1156d:
                            {
                                r = 2.8d;
                                break;
                            }

                        case var case80 when case80 <= 1196d:
                            {
                                r = 2.7d;
                                break;
                            }

                        case var case81 when case81 <= 1240d:
                            {
                                r = 2.6d;
                                break;
                            }

                        case var case82 when case82 <= 1287d:
                            {
                                r = 2.5d;
                                break;
                            }

                        case var case83 when case83 <= 1337d:
                            {
                                r = 2.4d;
                                break;
                            }

                        case var case84 when case84 <= 1391d:
                            {
                                r = 2.3d;
                                break;
                            }

                        case var case85 when case85 <= 1449d:
                            {
                                r = 2.2d;
                                break;
                            }

                        case var case86 when case86 <= 1512d:
                            {
                                r = 2.1d;
                                break;
                            }

                        case var case87 when case87 <= 1580d:
                            {
                                r = 2d;
                                break;
                            }

                        case var case88 when case88 <= 1654d:
                            {
                                r = 1.9d;
                                break;
                            }

                        case var case89 when case89 <= 1734d:
                            {
                                r = 1.8d;
                                break;
                            }

                        case var case90 when case90 <= 1822d:
                            {
                                r = 1.7d;
                                break;
                            }

                        case var case91 when case91 <= 1918d:
                            {
                                r = 1.6d;
                                break;
                            }

                        case var case92 when case92 <= 2023d:
                            {
                                r = 1.5d;
                                break;
                            }

                        case var case93 when case93 <= 2138d:
                            {
                                r = 1.4d;
                                break;
                            }

                        case var case94 when case94 <= 2265d:
                            {
                                r = 1.3d;
                                break;
                            }

                        case var case95 when case95 <= 2406d:
                            {
                                r = 1.2d;
                                break;
                            }

                        case var case96 when case96 <= 2562d:
                            {
                                r = 1.1d;
                                break;
                            }

                        case var case97 when case97 <= 2734d:
                            {
                                r = 1d;
                                break;
                            }

                        case var case98 when case98 <= 2925d:
                            {
                                r = 0.9d;
                                break;
                            }

                        case var case99 when case99 <= 3136d:
                            {
                                r = 0.8d;
                                break;
                            }

                        case var case100 when case100 <= 3369d:
                            {
                                r = 0.7d;
                                break;
                            }

                        case var case101 when case101 <= 3626d:
                            {
                                r = 0.6d;
                                break;
                            }

                        case var case102 when case102 <= 3906d:
                            {
                                r = 0.5d;
                                break;
                            }

                        case var case103 when case103 <= 4209d:
                            {
                                r = 0.4d;
                                break;
                            }

                        case var case104 when case104 <= 4532d:
                            {
                                r = 0.3d;
                                break;
                            }

                        case var case105 when case105 <= 4872d:
                            {
                                r = 0.2d;
                                break;
                            }

                        case var case106 when case106 <= 5223d:
                            {
                                r = 0.1d;
                                break;
                            }

                        case var case107 when case107 <= 5400d:
                            {
                                r = 0d;
                                break;
                            }
                    }
                }
            }

            RstdA2 = r; // Standard refraction before temperature and pressure applied, from Table A2
            if (GYear <= 2003 & hainMinutes < 596d | GYear >= 2004 & hainMinutes < 595d | GYear <= 2003 & hainMinutes >= 596d | GYear >= 2004 & hainMinutes >= 595d & (Conversion.Val(txtPressure.Text) != 1010d & cboPressure.Text == "mbar" | Conversion.Val(txtPressure.Text) != 29.83d & cboPressure.Text == "in Hg") | Conversion.Val(txtTemperature.Text) != 50d & cboTemperature.Text == "F " | Conversion.Val(txtTemperature.Text) != 10d & cboTemperature.Text == "C " | optHoParameters.Checked == true)
            {
                y = hainMinutes / 60d;
                if (GYear <= 2003)
                {
                    r = y + 7.31d / (y + 4.4d);
                }
                else
                {
                    r = y + 7.32d / (y + 4.32d);
                }

                r = r * Pi / 180d;
                r = 1d / Math.Tan(r);
                if (GYear <= 2003)
                {
                    r = r - 0.06d * Math.Sin((14.7d * (r / 60d) + 13d) * Pi / 180d); // correction to improve accuracy from 0.07' to 0.015', 2004 or earlier
                }

                Rstd = r; // added in 5.1.4
            }

            RstdTP = r; // replaced previous line in 5.1.4
            if (r < 0d)
            {
                r = 0d; // This line added to get rid of negative values at very high altitudes under certain circumstances
            }

            r = r * (283d / 1010d) * PX / (TX + 273d); // PX=1010, TX=10    Total Refraction    Constant was 0.28019802
            Raddl = r - RstdTP;
            if (GYear <= 2003 & hainMinutes >= 596d | GYear >= 2004 & hainMinutes >= 595d)
            {
                Rstd = RstdA2;
            }
        }

        public void EstimatedPosition()
        {
            Intercept = Math.Sign(Intercept) * Conversion.Int(Math.Abs(Intercept) * 10d + 0.5d) / 10d; // added in V4.0.0
            if (cboPolaris.Text != "Latitude by altitude of Polaris")
            {
                ZN = Conversion.Int(ZN + 0.5d); // changed above line to this in V4.3.1
            }

            EstL = Lat - Intercept / 60d * Math.Cos(ZN * Pi / 180d);
            EstLo = Lo + Intercept / 60d * Math.Sin(ZN * Pi / 180d) / Math.Cos(Lat * Pi / 180d);
            if (Math.Abs(EstLo) > 180d)
            {
                EstLo = -Math.Sign(EstLo) * (360d - Math.Abs(EstLo));
            }

            EstLDeg = Conversion.Int(Math.Abs(EstL));
            EstLMin = (Math.Abs(EstL) - EstLDeg) * 60d;
            if (Conversion.Int(EstLMin * 10d + 0.5d) / 10d == 60d)
            {
                EstLMin = 0d;
                EstLDeg = EstLDeg + 1d;
            }

            EstLoDeg = Conversion.Int(Math.Abs(EstLo));
            EstLoMin = (Math.Abs(EstLo) - EstLoDeg) * 60d;
            if (Conversion.Int(EstLoMin * 10d + 0.5d) / 10d == 60d)
            {
                EstLoMin = 0d;
                EstLoDeg = EstLoDeg + 1d;
            }

            EstLoDeg = Math.Abs(EstLoDeg);
            return;
        }

        public void Moon()
        {
            MLprime = 218.3164477d + 481267.88123421d * T - 0.0015786d * T * T + T * T * T / 538841d - T * T * T * T / 65194000d; // Moon's mean longitude, degrees
            if (MLprime >= 360d | MLprime < 0d)
                MLprime = MLprime - Conversion.Int(MLprime / 360d) * 360d;
            MLprime = MLprime * Pi / 180d;
            MD = 297.8501921d + 445267.1114034d * T - 0.0018819d * T * T + T * T * T / 545868d - T * T * T * T / 113065000d; // Moon'smean elongation, degrees
            if (MD >= 360d | MD < 0d)
                MD = MD - Conversion.Int(MD / 360d) * 360d;
            MD = MD * Pi / 180d; // radians
            MM = 357.5291092d + 35999.0502909d * T - 0.0001536d * T * T + T * T * T / 24490000d; // Sun's mean anomaly, degrees
            if (MM >= 360d | MM < 0d)
                MM = MM - Conversion.Int(MM / 360d) * 360d;
            MM = MM * Pi / 180d; // radians
            MMprime = 134.9633964d + 477198.8675055d * T + 0.0087414d * T * T + T * T * T / 69699d - T * T * T * T / 14712000d; // Moon's mean anomaly, degrees
            if (MMprime >= 360d | MMprime < 0d)
                MMprime = MMprime - Conversion.Int(MMprime / 360d) * 360d;
            MMprime = MMprime * Pi / 180d; // radians
            MF = 93.272095d + 483202.0175233d * T - 0.0036539d * T * T - T * T * T / 3526000d + T * T * T * T / 863310000d; // Moon's argument of altitude, degrees
            if (MF >= 360d | MF < 0d)
                MF = MF - Conversion.Int(MF / 360d) * 360d;
            MF = MF * Pi / 180d; // radians
            A1 = 119.75d + 131.849d * T; // degrees
            if (A1 >= 360d | A1 < 0d)
                A1 = A1 - Conversion.Int(A1 / 360d) * 360d;
            A1 = A1 * Pi / 180d; // radians
            A2 = 53.09d + 479264.29d * T; // degrees
            if (A2 >= 360d | A2 < 0d)
                A2 = A2 - Conversion.Int(A2 / 360d) * 360d;
            A2 = A2 * Pi / 180d; // radians
            A3 = 313.45d + 481266.484d * T; // degrees
            if (A3 >= 360d | A3 < 0d)
                A3 = A3 - Conversion.Int(A3 / 360d) * 360d;
            A3 = A3 * Pi / 180d; // radians
            E = 1d - 0.002516d * T - 0.0000074d * T * T;
            SigmaL = 0d;
            SigmaR = 0d;
            SigmaB = 0d;
            for (i = 0; i <= 59; i++)
            {
                KA = 1d;
                KB = 1d;
                if (MMA[i] == 1d | MMA[i] == -1)
                    KA = E;
                if (MMB[i] == 1d | MMB[i] == -1)
                    KB = E;
                if (MMA[i] == 2d | MMA[i] == -2)
                    KA = E * E;
                if (MMB[i] == 2d | MMB[i] == -2)
                    KB = E * E;
                SigmaL = SigmaL + KA * MSinA[i] * Math.Sin(MDA[i] * MD + MMA[i] * MM + MMprimeA[i] * MMprime + MFA[i] * MF);
                SigmaR = SigmaR + KA * MCosA[i] * Math.Cos(MDA[i] * MD + MMA[i] * MM + MMprimeA[i] * MMprime + MFA[i] * MF);
                SigmaB = SigmaB + KB * MSinB[i] * Math.Sin(MDB[i] * MD + MMB[i] * MM + MMprimeB[i] * MMprime + MFB[i] * MF);
            }

            SigmaL = SigmaL + 3958d * Math.Sin(A1) + 1962d * Math.Sin(MLprime - MF) + 318d * Math.Sin(A2);
            SigmaB = SigmaB - 2235d * Math.Sin(MLprime) + 382d * Math.Sin(A3) + 175d * Math.Sin(A1 - MF) + 175d * Math.Sin(A1 + MF) + 127d * Math.Sin(MLprime - MMprime) - 115d * Math.Sin(MLprime + MMprime);
            L1 = MLprime * 180d / Pi + SigmaL / 1000000d; // geocentric longitude, degrees
            B = SigmaB / 1000000d; // geocentric latitude, degrees
            Delta = 385000.56d + SigmaR / 1000d; // distance between centers of Earth and Moon, kilometers
            x = 6378.14d / Delta;
            HP = Math.Atan(x / Math.Sqrt(-x * x + 1d)); // radians   arcsine
            DI = 5974556.667d / Delta; // this is geocentric semidiameter, simple formula from Meeus (was in arcseconds)
            HP = HP * 180d / Pi * 60d; // arcminutes
            L1 = L1 + NL; // apparent longitude
            L1 = L1 * Pi / 180d;
            B = B * Pi / 180d;
            EclipticToEquatorial();
            AR = AR * 180d / Pi; // for Meeus ecl-to-eq
            DE = DE * 180d / Pi; // for Meeus ecl-to-eq
            return;
        }

        public void Planets()
        {
            // L is heliocentric, ecliptic longitude, radians
            // B is heliocentric, ecliptic latitude, radians
            // r is heliocentric distance, astronomical units
            Delta = 0d;
            Tau = 0d;
            T = T / 10d;
            for (i = 1; i <= 3; i++)
            {
                if (i > 1)
                    T = (JD - 2451545d - Tau) / 365250d;
                if (BN == 58)
                {
                    L = VenusFunctions.Venus_L01(ref T) + VenusFunctions.Venus_L11(ref T) + VenusFunctions.Venus_L21(ref T) + VenusFunctions.Venus_L31(ref T) + VenusFunctions.Venus_L41(ref T) + VenusFunctions.Venus_L51(ref T);
                    if (Math.Abs(L) > 2d * Pi)
                        L = L - 2d * Pi * Conversion.Int(L / 2d / Pi);
                    B = VenusFunctions.Venus_B01(ref T) + VenusFunctions.Venus_B11(ref T) + VenusFunctions.Venus_B21(ref T) + VenusFunctions.Venus_B31(ref T) + VenusFunctions.Venus_B41(ref T) + VenusFunctions.Venus_B51(ref T);
                    r = VenusFunctions.Venus_R01(ref T) + VenusFunctions.Venus_R11(ref T) + VenusFunctions.Venus_R21(ref T) + VenusFunctions.Venus_R31(ref T) + VenusFunctions.Venus_R41(ref T) + VenusFunctions.Venus_R51(ref T);
                }

                if (BN == 59)
                {
                    L = MarsFunctions.Mars_L01(ref T) + MarsFunctions.Mars_L02(ref T) + MarsFunctions.Mars_L03(ref T) + MarsFunctions.Mars_L11(ref T) + MarsFunctions.Mars_L12(ref T) + MarsFunctions.Mars_L21(ref T) + MarsFunctions.Mars_L31(ref T) + MarsFunctions.Mars_L41(ref T) + MarsFunctions.Mars_L51(ref T);
                    if (Math.Abs(L) > 2d * Pi)
                        L = L - 2d * Pi * Conversion.Int(L / 2d / Pi);
                    B = MarsFunctions.Mars_B01(ref T) + MarsFunctions.Mars_B11(ref T) + MarsFunctions.Mars_B21(ref T) + MarsFunctions.Mars_B31(ref T) + MarsFunctions.Mars_B41(ref T) + MarsFunctions.Mars_B51(ref T);
                    r = MarsFunctions.Mars_R01(ref T) + MarsFunctions.Mars_R02(ref T) + MarsFunctions.Mars_R03(ref T) + MarsFunctions.Mars_R11(ref T) + MarsFunctions.Mars_R12(ref T) + MarsFunctions.Mars_R21(ref T) + MarsFunctions.Mars_R31(ref T) + MarsFunctions.Mars_R41(ref T) + MarsFunctions.Mars_R51(ref T);
                }

                if (BN == 60)
                {
                    object localJupiter_L51() { object argT = T; var ret = JupiterFunctions.Jupiter_L51(ref argT); return ret; }

                    L = Conversions.ToDouble(Operators.AddObject(JupiterFunctions.Jupiter_L01(ref T) + JupiterFunctions.Jupiter_L02(ref T) + JupiterFunctions.Jupiter_L11(ref T) + JupiterFunctions.Jupiter_L21(ref T) + JupiterFunctions.Jupiter_L31(ref T) + JupiterFunctions.Jupiter_L41(ref T), localJupiter_L51()));
                    if (Math.Abs(L) > 2d * Pi)
                        L = L - 2d * Pi * Conversion.Int(L / 2d / Pi);
                    object localJupiter_B01() { object argT = T; var ret = JupiterFunctions.Jupiter_B01(ref argT); return ret; }

                    object localJupiter_B11() { object argT = T; var ret = JupiterFunctions.Jupiter_B11(ref argT); return ret; }

                    object localJupiter_B21() { object argT = T; var ret = JupiterFunctions.Jupiter_B21(ref argT); return ret; }

                    object localJupiter_B31() { object argT = T; var ret = JupiterFunctions.Jupiter_B31(ref argT); return ret; }

                    object localJupiter_B41() { object argT = T; var ret = JupiterFunctions.Jupiter_B41(ref argT); return ret; }

                    object localJupiter_B51() { object argT = T; var ret = JupiterFunctions.Jupiter_B51(ref argT); return ret; }

                    B = Conversions.ToDouble(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(localJupiter_B01(), localJupiter_B11()), localJupiter_B21()), localJupiter_B31()), localJupiter_B41()), localJupiter_B51()));
                    object localJupiter_R01() { object argT = T; var ret = JupiterFunctions.Jupiter_R01(ref argT); return ret; }

                    object localJupiter_R02() { object argT = T; var ret = JupiterFunctions.Jupiter_R02(ref argT); return ret; }

                    object localJupiter_R11() { object argT = T; var ret = JupiterFunctions.Jupiter_R11(ref argT); return ret; }

                    object localJupiter_R21() { object argT = T; var ret = JupiterFunctions.Jupiter_R21(ref argT); return ret; }

                    object localJupiter_R31() { object argT = T; var ret = JupiterFunctions.Jupiter_R31(ref argT); return ret; }

                    object localJupiter_R41() { object argT = T; var ret = JupiterFunctions.Jupiter_R41(ref argT); return ret; }

                    object localJupiter_R51() { object argT = T; var ret = JupiterFunctions.Jupiter_R51(ref argT); return ret; }

                    r = Conversions.ToDouble(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(localJupiter_R01(), localJupiter_R02()), localJupiter_R11()), localJupiter_R21()), localJupiter_R31()), localJupiter_R41()), localJupiter_R51()));
                }

                if (BN == 61)
                {
                    L = SaturnFunctions.Saturn_L01(ref T) + SaturnFunctions.Saturn_L02(ref T) + SaturnFunctions.Saturn_L03(ref T) + SaturnFunctions.Saturn_L11(ref T) + SaturnFunctions.Saturn_L12(ref T) + SaturnFunctions.Saturn_L21(ref T) + SaturnFunctions.Saturn_L31(ref T) + SaturnFunctions.Saturn_L41(ref T) + SaturnFunctions.Saturn_L51(ref T);
                    if (Math.Abs(L) > 2d * Pi)
                        L = L - 2d * Pi * Conversion.Int(L / 2d / Pi);
                    B = SaturnFunctions.Saturn_B01(ref T) + SaturnFunctions.Saturn_B02(ref T) + SaturnFunctions.Saturn_B11(ref T) + SaturnFunctions.Saturn_B21(ref T) + SaturnFunctions.Saturn_B31(ref T) + SaturnFunctions.Saturn_B41(ref T) + SaturnFunctions.Saturn_B51(ref T);
                    r = SaturnFunctions.Saturn_R01(ref T) + SaturnFunctions.Saturn_R02(ref T) + SaturnFunctions.Saturn_R03(ref T) + SaturnFunctions.Saturn_R11(ref T) + SaturnFunctions.Saturn_R12(ref T) + SaturnFunctions.Saturn_R21(ref T) + SaturnFunctions.Saturn_R31(ref T) + SaturnFunctions.Saturn_R41(ref T) + SaturnFunctions.Saturn_R51(ref T);
                }
                // convert from heliocentric to geocentric coordinates
                if (i == 1)
                {
                    L0 = EarthFunctions.Earth_L01(ref T) + EarthFunctions.Earth_L02(ref T) + EarthFunctions.Earth_L11(ref T) + EarthFunctions.Earth_L21(ref T) + EarthFunctions.Earth_L31(ref T) + EarthFunctions.Earth_L41(ref T) + EarthFunctions.Earth_L51(ref T);
                    if (Math.Abs(L0) > 2d * Pi)
                        L0 = L0 - 2d * Pi * Conversion.Int(L0 / 2d / Pi);
                    // L0Sun = L0
                    B0 = EarthFunctions.Earth_B01(ref T) + EarthFunctions.Earth_B11(ref T) + EarthFunctions.Earth_B21(ref T) + EarthFunctions.Earth_B31(ref T) + EarthFunctions.Earth_B41(ref T);
                    r0 = EarthFunctions.Earth_R01(ref T) + EarthFunctions.Earth_R02(ref T) + EarthFunctions.Earth_R11(ref T) + EarthFunctions.Earth_R21(ref T) + EarthFunctions.Earth_R31(ref T) + EarthFunctions.Earth_R41(ref T) + EarthFunctions.Earth_R51(ref T);
                }

                x = r * Math.Cos(B) * Math.Cos(L) - r0 * Math.Cos(B0) * Math.Cos(L0);
                y = r * Math.Cos(B) * Math.Sin(L) - r0 * Math.Cos(B0) * Math.Sin(L0);
                Z = r * Math.Sin(B) - r0 * Math.Sin(B0);

                // Effect of light-time
                Delta = Math.Sqrt(x * x + y * y + Z * Z);
                Tau = 0.0057755183d * Delta;
            }
            // geocentric longitude and latitude
            if (Math.Abs(x) < 9.999999E-21d)
                x = 9.999999E-21d;
            L1 = Math.Atan(y / x); // geocentric longitude, radians
            if (x < 0d)
                L1 = L1 + Pi;
            if (L1 >= 2d * Pi | L1 < 0d)
                L1 = L1 - Conversion.Int(L1 / (2d * Pi)) * 2d * Pi;
            B = Math.Atan(Z / Math.Sqrt(x * x + y * y)); // geocentric latitude, radians

            // Back to normal times
            T = T * 10d;
            // Apply Aberration
            Sun(); // for LN, Ecc needed in AberrationLB
            AberrationLB();
            L1 = L1 + AberrL * Pi / 180d; // radians
            B = B + AberrB * Pi / 180d; // radians    'IS THIS LINE NEEDED????????????????????????????????????
            L1 = L1 + NL * Pi / 180d; // apparent longitude
            EclipticToEquatorial();
            AR = AR * 180d / Pi;
            DE = DE * 180d / Pi;
            return;
        }

        public void LatByPolaris()
        {
            PolarisMeans();
            LatLong();
            ZoneTime();
            Greenwich();
            Delta_T();
            Julian();
            Stars();
            DE1 = DE;
            HourAngles();
            LR = GHAAries - Lo;
            if (LR < 0d)
                LR = LR + 360d;
            if (LR >= 360d)
                LR = LR - 360d;
            XD = (short)Conversion.Int(LR);
            XM = (LR - XD) * 60d;
            XM = Conversion.Int(XM * 10d + 0.5d) / 10d;
            if (XM == 60d)
            {
                XM = 0d;
                XD = (short)(XD + 1);
            }

            Pola0 = -(90d - MeanDecPol) * Math.Cos((LR + MeanSHAPol) * Pi / 180d) + 0.5d * (90d - MeanDecPol) * Math.Sin((90d - MeanDecPol) * Pi / 180d) * Math.Pow(Math.Sin((LR + MeanSHAPol) * Pi / 180d), 2d) * Math.Tan(50d * Pi / 180d);
            Pola0 = 60d * Pola0 + 58.8d;
            Pola0deg = 0d;
            Pola0min = Pola0;
            if (Pola0 >= 60d)
            {
                Pola0deg = 1d;
                Pola0min = Pola0 - 60d;
            }

            LforPol = Lat;
            if (string.IsNullOrEmpty(txtLDeg.Text) & string.IsNullOrEmpty(txtLMin.Text))
            {
                LforPol = HoinMinutes / 60d; // Hoinminutes/60 is approximate latitude in degrees
            }

            switch (LforPol)
            {
                case var @case when @case < 5d:
                    {
                        LforPol = 0d;
                        break;
                    }

                case var case1 when case1 < 15d:
                    {
                        LforPol = 10d;
                        break;
                    }

                case var case2 when case2 < 25d:
                    {
                        LforPol = 20d;
                        break;
                    }

                case var case3 when case3 < 35d:
                    {
                        LforPol = 30d;
                        break;
                    }

                case var case4 when case4 < 42.5d:
                    {
                        LforPol = 40d;
                        break;
                    }

                case var case5 when case5 < 47.5d:
                    {
                        LforPol = 45d;
                        break;
                    }

                case var case6 when case6 < 52.5d:
                    {
                        LforPol = 50d;
                        break;
                    }

                case var case7 when case7 < 57.5d:
                    {
                        LforPol = 55d;
                        break;
                    }

                case var case8 when case8 < 61d:
                    {
                        LforPol = 60d;
                        break;
                    }

                case var case9 when case9 < 63d:
                    {
                        LforPol = 62d;
                        break;
                    }

                case var case10 when case10 < 65d:
                    {
                        LforPol = 64d;
                        break;
                    }

                case var case11 when case11 < 67d:
                    {
                        LforPol = 66d;
                        break;
                    }

                case var case12 when case12 < 69d:
                    {
                        LforPol = 68d;
                        break;
                    }
            }

            Pola1 = 0.5d * (90d - DE) * Math.Sin((90d - DE) * Pi / 180d) * Math.Pow(Math.Sin((LR + SH) * Pi / 180d), 2d) * Math.Tan(LforPol * Pi / 180d) - 0.5d * (90d - MeanDecPol) * Math.Sin((90d - MeanDecPol) * Pi / 180d) * Math.Pow(Math.Sin((LR + MeanSHAPol) * Pi / 180d), 2d) * Math.Tan(50d * Pi / 180d);
            Pola1 = 60d * Pola1 + 0.6d;
            Pola2 = (90d - MeanDecPol) * Math.Cos((LR + MeanSHAPol) * Pi / 180d) - (90d - DE) * Math.Cos((LR + SH) * Pi / 180d);
            Pola2 = 60d * Pola2 + 0.6d;
            Pola0min = Conversion.Int(10d * Pola0min + 0.5d) / 10d;
            Pola1 = Conversion.Int(10d * Pola1 + 0.5d) / 10d;
            Pola2 = Conversion.Int(10d * Pola2 + 0.5d) / 10d;
            PC = Pola0deg * 60d + Pola0min + Pola1 + Pola2;
            PCdeg = 0;
            PCmin = PC;
            if (PC >= 60d)
            {
                PCdeg = 1;
                PCmin = PC - 60d;
            }

            PCorr = PC - 60d;
            Stars();
            HourAngles();
            T = THour1;
            JDHour = JDHour1; // : AR = AR1
            Obliquity();
            Nutation();
            HourAnglesHour();
            GHAHour1 = GHAHour;
            IandC();
            AltitudeCorrection();
            LawOfCosines();
            LP = LHA * Pi / 180d;
            HD = CommonGlobals.g_LatN;
            P0 = 90d - DE; // polar distance (degrees)
                           // 'L0 = Ho
            L0 = HoinMinutes / 60d;
        Line9820:
            ;
            LbyPol = (HoDeg * 60d + HoMin + PCorr) / 60d; // changed to this in V5.1.5 to make math work better
            if (Math.Abs(LbyPol - L0) < 0.000001d)
                goto Line9870;
            L0 = LbyPol;
            goto Line9820;
        Line9870:
            ;
            PD2 = Conversion.Fix(LbyPol);
            PM = (LbyPol - PD2) * 60d;
            PM = Conversion.Int(PM * 10d + 0.5d) / 10d;
            if (PM == 60d)
            {
                PM = 0d;
                PD2 = PD2 + 1d;
            }

            Ldiff = Math.Abs(LbyPol - Lat);
            ldiffDeg = (short)Conversion.Int(Ldiff);
            ldiffMin = (Ldiff - ldiffDeg) * 60d;
            ldiffMin = Conversion.Int(ldiffMin * 10d + 0.5d) / 10d;
            if (ldiffMin == 60d)
            {
                ldiffMin = 0d;
                ldiffDeg = (short)(ldiffDeg + 1);
            }

            EstimatedPosition();
            DisplaySR();
            DisplayPolaris();
            cmdSave.Visible = false;
            btnCLSPlot.Visible = false;
            btnCustomPlot.Visible = false;
            cmdMerDiag.Visible = false;
            btnExpandTimeDiag.Visible = false;
            return;
        }

        public void DisplayPolaris()
        {
            IntAzTxtBx.Clear();
            IntAzTxtBx.Font = new Font(IntAzTxtBx.Font, FontStyle.Bold);
            IntAzTxtBx.SelectionAlignment = HorizontalAlignment.Center;
            IntAzTxtBx.AppendText("LATITUDE by ALTITUDE of POLARIS" + Constants.vbNewLine);
            IntAzTxtBx.SelectionAlignment = HorizontalAlignment.Left;
            IntAzTxtBx.AppendText("LHA Aries      " + Strings.Format(XD, "##0") + '°' + Strings.Format(XM, "00.0") + "'" + Constants.vbTab + "Polaris Correction" + Constants.vbTab + Constants.vbTab + "Latitude Computation" + Constants.vbNewLine);
            IntAzTxtBx.AppendText(Constants.vbTab + Constants.vbTab + Constants.vbTab + Constants.vbTab + "a0     " + Strings.Format(Pola0deg, "0") + '°' + Strings.Format(Pola0min, "00.0") + "'" + Constants.vbTab + Constants.vbTab + "Ho     ");
            if (Math.Sign(HoinMinutes) == -1)
            {
                IntAzTxtBx.AppendText(Strings.Space(35 - HoDeg.ToString().Length) + "-");
            }

            IntAzTxtBx.AppendText(Strings.Space(1) + Strings.Format(HoDeg, "##0") + '°' + Strings.Format(HoMin, "00.0") + "'" + Constants.vbNewLine);
            IntAzTxtBx.AppendText(Constants.vbTab + Constants.vbTab + Constants.vbTab + Constants.vbTab + "a1       " + Strings.Format(Pola1, "00.0") + "'" + Constants.vbTab + Constants.vbTab + "Corr (");
            if (PCorr == 0d)
            {
                IntAzTxtBx.AppendText(" )   00.0'"); // PCorr was PCorr2
            }

            if (PCorr > 0d)
            {
                IntAzTxtBx.AppendText("+)   "); // PCorr was PCorr2
            }

            if (PCorr < 0d)
            {
                IntAzTxtBx.AppendText("-)   "); // PCorr was PCorr2
            }

            if (PCorr != 0d)
            {
                IntAzTxtBx.AppendText(Strings.Format(Math.Abs(PCorr), "00.0") + "'" + Constants.vbNewLine); // PCorr was PCorr2
            }

            PL = CommonGlobals.g_LatN;
            if (LbyPol < 0d)
            {
                PL = CommonGlobals.g_LatS;
            }

            if (LbyPol == 0d)
            {
                PL = " ";
            }

            IntAzTxtBx.AppendText(Constants.vbTab + Constants.vbTab + Constants.vbTab + Constants.vbTab + "a2       " + Strings.Format(Pola2, "00.0") + "'" + Constants.vbTab + Constants.vbTab + "Lat     " + Strings.Space(6 - Strings.Len(Conversion.Str(PD2))) + Strings.Format(Math.Abs(PD2), "#0") + '°' + Strings.Format(Math.Abs(PM), "00.0") + "'" + PL + Constants.vbNewLine);
            IntAzTxtBx.AppendText(Constants.vbTab + Constants.vbTab + Constants.vbTab + Constants.vbTab + "Total" + Strings.Space(4 - Strings.Len(Conversion.Str(PCdeg))) + Strings.Format(PCdeg, "0") + '°' + Strings.Format(PCmin, "00.0") + "'" + Constants.vbTab + Constants.vbTab);
            if (BNBodyName == "Polaris" & cboPolaris.Text != "Latitude by altitude of Polaris" | BNBodyName == "Polaris" & cboPolaris.Text == "Latitude by altitude of Polaris" & (!string.IsNullOrEmpty(txtLDeg.Text) | !string.IsNullOrEmpty(txtLMin.Text)))
            {
                IntAzTxtBx.AppendText("DR Lat   " + Strings.Space(5 - Strings.Len(Conversion.Str(Conversion.Val(txtLDeg.Text)))) + Strings.Format(Conversion.Val(txtLDeg.Text), "0") + '°' + Strings.Format(Conversion.Val(txtLMin.Text), "00.0") + "'" + cboL.Text);
            }

            IntAzTxtBx.AppendText(Constants.vbNewLine);
            IntAzTxtBx.AppendText(Constants.vbTab + Constants.vbTab + Constants.vbTab + Constants.vbTab + "    (-)1" + '°' + "00.0'" + Constants.vbTab + Constants.vbTab);
            if (BNBodyName == "Polaris" & cboPolaris.Text != "Latitude by altitude of Polaris" | BNBodyName == "Polaris" & cboPolaris.Text == "Latitude by altitude of Polaris" & (!string.IsNullOrEmpty(txtLDeg.Text) | !string.IsNullOrEmpty(txtLMin.Text)))
            {
                IntAzTxtBx.AppendText("l diff   " + Strings.Space(5 - Strings.Len(Conversion.Str(ldiffDeg))) + Strings.Format(ldiffDeg, "0") + '°' + Strings.Format(ldiffMin, "00.0") + "'");
            }

            IntAzTxtBx.AppendText(Constants.vbNewLine);
            IntAzTxtBx.AppendText(Constants.vbTab + Constants.vbTab + Constants.vbTab + Constants.vbTab + "Corr(");
            if (PCorr == 0d)
                IntAzTxtBx.AppendText(" )  00.0'");
            if (PCorr > 0d)
                IntAzTxtBx.AppendText("+)  ");
            if (PCorr < 0d)
                IntAzTxtBx.AppendText("-)  ");
            if (PCorr != 0d)
                IntAzTxtBx.AppendText(Strings.Format(Math.Abs(PCorr), "00.0") + "'" + Constants.vbTab + Constants.vbTab + "Zn       " + Strings.Space(5 - Strings.Len(Conversion.Str(Conversion.Int(ZN)))) + Strings.Format(Conversion.Int(ZN * 10d + 0.5d) / 10d, "##0.0") + '°' + Constants.vbNewLine);
            IntAzTxtBx.AppendText("EP L  " + Strings.Space(11 - Strings.Len(Conversion.Str(PD2))) + Strings.Format(Math.Abs(PD2), "#0") + '°' + Strings.Format(Math.Abs(PM), "00.0") + "'" + PL + Constants.vbNewLine);
            IntAzTxtBx.AppendText("EP Lo " + Strings.Space(11 - Strings.Len(Conversion.Str(Conversion.Val(txtLoDeg.Text)))) + Strings.Format(Conversion.Val(txtLoDeg.Text), "0") + '°' + Strings.Format(Conversion.Val(txtLoMin.Text), "00.0") + "'" + cboLo.Text);
            return;
        }

        public void DisplayLOC()
        {
            IntAzTxtBx.Clear();
            IntAzTxtBx.Font = TxtBxFont;
            IntAzTxtBx.Font = new Font(IntAzTxtBx.Font, FontStyle.Bold);
            IntAzTxtBx.SelectionAlignment = HorizontalAlignment.Center;
            IntAzTxtBx.AppendText("INTERCEPT and AZIMUTH by the LAW of COSINES METHOD" + Constants.vbNewLine);
            IntAzTxtBx.SelectionAlignment = HorizontalAlignment.Left;
            LHAOriginal = LHADeg + LHAMin / 60d;
            IntAzTxtBx.AppendText(Strings.Space(25) + "LHA" + Strings.Space(5 - Strings.Len(Conversion.Str(LHADeg))) + Strings.Format(LHADeg, "0") + '°' + Strings.Format(LHAMin, "00.0") + "'" + Strings.Space(2) + "-------> LHA" + Strings.Space(9 - Strings.Len(Conversion.Str(LHADeg))) + Strings.Format(LHA, "0.00000") + '°' + Constants.vbNewLine);
            IntAzTxtBx.AppendText(Strings.Space(25) + "Lat" + Strings.Space(5 - Strings.Len(Conversion.Str(Conversion.Val(txtLDeg.Text)))) + Strings.Format(Conversion.Val(txtLDeg.Text), "0") + '°' + Strings.Format(Conversion.Val(LMin), "00.0") + "'" + cboL.Text + "-------> Lat (+)" + Strings.Space(5 - Strings.Len(Conversion.Str(Conversion.Val(txtLDeg.Text)))) + Strings.Format(Math.Abs(Lat), "0.00000") + '°' + Constants.vbNewLine);
            IntAzTxtBx.AppendText(Strings.Space(25) + "Dec" + Strings.Space(5 - Strings.Len(Conversion.Str(TotDecDegrees))) + Strings.Format(Math.Abs(TotDecDegrees), "0") + '°' + Strings.Format(TotDecMinutes, "00.0") + "'");
            if (TotDE > 0d)
            {
                IntAzTxtBx.AppendText(CommonGlobals.g_LatN);
            }

            if (TotDE == 0d)
            {
                IntAzTxtBx.AppendText(CommonGlobals.g_StrSpace);
            }

            if (TotDE < 0d)
            {
                IntAzTxtBx.AppendText(CommonGlobals.g_LatS);
            }

            IntAzTxtBx.AppendText(" -------> Dec (");
            if (TotDE <= 0d & cboL.Text == "N" | TotDE >= 0d & cboL.Text == "S")
            {
                IntAzTxtBx.AppendText("-)");
            }
            else
            {
                IntAzTxtBx.AppendText("+)");
            }

            IntAzTxtBx.AppendText(Strings.Space(5 - Strings.Len(Conversion.Str(TotDecDegrees))) + Strings.Format(Math.Abs(TotDE), "0.00000") + '°' + Constants.vbNewLine);
            IntAzTxtBx.AppendText(Strings.Space(5) + " (cos LHA x cos Lat x cos Dec) + (sin Lat x sin Dec) = sin Hc" + " ---->" + Strings.Space(3) + "Hc " + Strings.Format(Conversion.Int(Hc * 100000d + 0.5d) / 100000d, "0.00000") + '°' + Constants.vbNewLine);
            IntAzTxtBx.AppendText(Strings.Space(5) + " (sin Dec - (sin Lat x sin Hc)) / (cos Lat x cos Hc) = cos Z" + " ----->" + Strings.Space(3) + "Z  " + cboL.Text + Strings.Format(Conversion.Int(Z * 10d + 0.5d) / 10d, "0.0") + '°');
            if (LHA <= 180d)
            {
                IntAzTxtBx.AppendText(" W");
            }

            if (LHA > 180d)
            {
                IntAzTxtBx.AppendText(" E");
            }

            IntAzTxtBx.AppendText(Constants.vbNewLine);
            IntAzTxtBx.AppendText(Strings.Space(25) + " Hc");
            if (Math.Sign(Hc) == -1)
            {
                IntAzTxtBx.AppendText(Strings.Space(4 - Strings.Len(Conversion.Str(HcDeg))) + "-");
            }

            IntAzTxtBx.AppendText(Strings.Space(5 - Strings.Len(Conversion.Str(HcDeg))) + Strings.Format(Math.Abs(HcDeg), "0") + '°' + Strings.Format(Math.Abs(HcMin), "00.0") + "'" + Constants.vbNewLine);
            IntAzTxtBx.AppendText(Strings.Space(25) + " Ho");
            if (Math.Sign(HoinMinutes) == -1)
            {
                IntAzTxtBx.AppendText(Strings.Space(4 - Strings.Len(Conversion.Str(HoDeg))) + "-");
            }

            IntAzTxtBx.AppendText(Strings.Space(5 - Strings.Len(Conversion.Str(HoDeg))) + Strings.Format(Math.Abs(HoDeg), "0") + '°' + Strings.Format(Math.Abs(HoMin), "00.0") + "'" + Constants.vbNewLine);
            i = (short)Strings.Len(Conversion.Str(Conversion.Int(Math.Abs(Intercept) * 10d + 0.5d)));
            if (Math.Abs(Intercept) < 1d)
            {
                i = (short)(i + 1);
            }

            IntAzTxtBx.AppendText(Strings.Space(25) + " a =" + Strings.Space(9 - i) + Strings.Format(Conversion.Int(Math.Abs(Intercept) * 10d + 0.5d) / 10d, "0.0") + " nm ");
            PlotOut.PlotIntercept = Strings.Format(Conversion.Int(Math.Abs(Intercept) * 10d + 0.5d) / 10d, "0.0") + " nm ";
            if (Conversion.Int(Math.Abs(Intercept) * 10d + 0.5d) / 10d != 0d & Intercept < 0d)
            {
                IntAzTxtBx.AppendText("T  Ho > Hc....Toward");
                PlotOut.PlotIntercept += " Toward";
            }

            if (Conversion.Int(Math.Abs(Intercept) * 10d + 0.5d) / 10d != 0d & Intercept > 0d)
            {
                IntAzTxtBx.AppendText("A  Hc > Ho....Away  ");
                PlotOut.PlotIntercept += " Away";
            }

            IntAzTxtBx.AppendText(Strings.Space(5) + "Zn = " + Strings.Format(ZN, "000") + '°' + Constants.vbNewLine);
            PlotOut.PlotAz = Strings.Format(ZN, "000") + '°';
            My.MyProject.Forms.SightLog.SRFFormEP = "";
            IntAzTxtBx.AppendText(Strings.Space(25) + " EP L " + Strings.Format(EstLDeg, "0") + '°' + Strings.Format(EstLMin, "00.0") + "'"); // Tab(10 - Len(Str$(EstLDeg)));
            My.MyProject.Forms.SightLog.SRFFormEP = " EP L " + Strings.Format(EstLDeg, "0") + '°' + Strings.Format(EstLMin, "00.0") + "'";
            PlotOut.PlotSLEP = " EP L " + Strings.Format(EstLDeg, "0") + '°' + Strings.Format(EstLMin, "00.0") + "'";
            if (EstL > 0d)
            {
                IntAzTxtBx.AppendText(CommonGlobals.g_LatN);
                My.MyProject.Forms.SightLog.SRFFormEP += CommonGlobals.g_LatN;
                PlotOut.PlotSLEP += CommonGlobals.g_LatN;
            }

            if (EstL == 0d)
            {
                IntAzTxtBx.AppendText(CommonGlobals.g_StrSpace);
                My.MyProject.Forms.SightLog.SRFFormEP += " ";
                PlotOut.PlotSLEP += " ";
            }

            if (EstL < 0d)
            {
                IntAzTxtBx.AppendText(CommonGlobals.g_LatS);
                My.MyProject.Forms.SightLog.SRFFormEP += CommonGlobals.g_LatS;
                PlotOut.PlotSLEP += CommonGlobals.g_LatS;
            }

            IntAzTxtBx.AppendText("   EP Lo " + Strings.Format(EstLoDeg, "0") + '°' + Strings.Format(EstLoMin, "00.0") + "'"); // Tab(28 - Len(Str$(EstLoDeg)));
            My.MyProject.Forms.SightLog.SRFFormEP += "   EP Lo " + Strings.Format(EstLoDeg, "0") + '°' + Strings.Format(EstLoMin, "00.0") + "'";
            PlotOut.PlotSLEP += "   EP Lo " + Strings.Format(EstLoDeg, "0") + '°' + Strings.Format(EstLoMin, "00.0") + "'";
            if (EstLo > 0d)
            {
                IntAzTxtBx.AppendText(CommonGlobals.g_LongW);
                My.MyProject.Forms.SightLog.SRFFormEP += CommonGlobals.g_LongW;
                PlotOut.PlotSLEP += CommonGlobals.g_LongW;
            }

            if (EstLo == 0d)
            {
                IntAzTxtBx.AppendText(CommonGlobals.g_StrSpace);
                My.MyProject.Forms.SightLog.SRFFormEP += " ";
                PlotOut.PlotSLEP += " ";
            }

            if (EstLo < 0d)
            {
                IntAzTxtBx.AppendText(CommonGlobals.g_LongE);
                My.MyProject.Forms.SightLog.SRFFormEP += CommonGlobals.g_LongE;
                PlotOut.PlotSLEP += CommonGlobals.g_LongE;
            }

            DisplayTimeDiagram();
            return;
        }
        // THE FOLLOWING TWO SUB ROUTINES MOVED INTO THE FIX FORM 9/27/2019 BY H HAMMOND. RESTRUCTURED INTERFACE TO FIX FORM TO CLEAN UP AND MAKE FIX MORE INDEPENDENT OF SRF AND REUSABLE
        // Public Sub FixData()
        // the various fix data element arrays are dim at 50 elements but only 12 are used reliably and the indexing starts 1 - artifact of original vb6 code that is strung between SRF FormSRF and Fix Form4
        // Dim temp As Integer = 0
        // For temp = 1 To 12
        // Form4.FixDataArray(temp) = New Form4.SFixData With {.SFZH = FZH(temp), .SFZM = FZM(temp), .SFZS = FZS(temp),
        // .SFZN = FZN(temp), .SFMI = FMI(temp), .SFL = FL(temp), .SFLo = FLo(temp), .SBF = BF(temp),
        // .SFLD = FLD(temp), .SFLM = FLM(temp), .sFD = FD(temp), .SFMD = FMD(temp), .SFMM = FMM(temp),
        // .sFLA = FLA(temp), .SFM = FM(temp), .SFGHA = FGHA(temp), .SFDec = FDec(temp), .SFHo = FHo(temp)}
        // Next
        // Added FGHA, FDec, and FHo om V5.6.1
        // FixData1 = New SFixData With {.SFZH = FZH(1), .SFZM = FZM(1), .SFZS = FZS(1), .SFZN = FZN(1), .SFMI = FMI(1), .SFL = FL(1), .SFLo = FLo(1), .SBF = BF(1), .SFLD = FLD(1), .SFLM = FLM(1), .sFD = FD(1), .SFMD = FMD(1), .SFMM = FMM(1), .sFLA = FLA(1), .SFM = FM(1), .SFGHA = FGHA(1), .SFDec = FDec(1), .SFHo = FHo(1)}
        // FixData2 = New SFixData With {.SFZH = FZH(2), .SFZM = FZM(2), .SFZS = FZS(2), .SFZN = FZN(2), .SFMI = FMI(2), .SFL = FL(2), .SFLo = FLo(2), .SBF = BF(2), .SFLD = FLD(2), .SFLM = FLM(2), .sFD = FD(2), .SFMD = FMD(2), .SFMM = FMM(2), .sFLA = FLA(2), .SFM = FM(2), .SFGHA = FGHA(2), .SFDec = FDec(2), .SFHo = FHo(2)}
        // FixData3 = New SFixData With {.SFZH = FZH(3), .SFZM = FZM(3), .SFZS = FZS(3), .SFZN = FZN(3), .SFMI = FMI(3), .SFL = FL(3), .SFLo = FLo(3), .SBF = BF(3), .SFLD = FLD(3), .SFLM = FLM(3), .sFD = FD(3), .SFMD = FMD(3), .SFMM = FMM(3), .sFLA = FLA(3), .SFM = FM(3), .SFGHA = FGHA(3), .SFDec = FDec(3), .SFHo = FHo(3)}
        // FixData4 = New SFixData With {.SFZH = FZH(4), .SFZM = FZM(4), .SFZS = FZS(4), .SFZN = FZN(4), .SFMI = FMI(4), .SFL = FL(4), .SFLo = FLo(4), .SBF = BF(4), .SFLD = FLD(4), .SFLM = FLM(4), .sFD = FD(4), .SFMD = FMD(4), .SFMM = FMM(4), .sFLA = FLA(4), .SFM = FM(4), .SFGHA = FGHA(4), .SFDec = FDec(4), .SFHo = FHo(4)}
        // FixData5 = New SFixData With {.SFZH = FZH(5), .SFZM = FZM(5), .SFZS = FZS(5), .SFZN = FZN(5), .SFMI = FMI(5), .SFL = FL(5), .SFLo = FLo(5), .SBF = BF(5), .SFLD = FLD(5), .SFLM = FLM(5), .sFD = FD(5), .SFMD = FMD(5), .SFMM = FMM(5), .sFLA = FLA(5), .SFM = FM(5), .SFGHA = FGHA(5), .SFDec = FDec(5), .SFHo = FHo(5)}
        // FixData6 = New SFixData With {.SFZH = FZH(6), .SFZM = FZM(6), .SFZS = FZS(6), .SFZN = FZN(6), .SFMI = FMI(6), .SFL = FL(6), .SFLo = FLo(6), .SBF = BF(6), .SFLD = FLD(6), .SFLM = FLM(6), .sFD = FD(6), .SFMD = FMD(6), .SFMM = FMM(6), .sFLA = FLA(6), .SFM = FM(6), .SFGHA = FGHA(6), .SFDec = FDec(6), .SFHo = FHo(6)}
        // FixData7 = New SFixData With {.SFZH = FZH(7), .SFZM = FZM(7), .SFZS = FZS(7), .SFZN = FZN(7), .SFMI = FMI(7), .SFL = FL(7), .SFLo = FLo(7), .SBF = BF(7), .SFLD = FLD(7), .SFLM = FLM(7), .sFD = FD(7), .SFMD = FMD(7), .SFMM = FMM(7), .sFLA = FLA(7), .SFM = FM(7), .SFGHA = FGHA(7), .SFDec = FDec(7), .SFHo = FHo(7)}
        // FixData8 = New SFixData With {.SFZH = FZH(8), .SFZM = FZM(8), .SFZS = FZS(8), .SFZN = FZN(8), .SFMI = FMI(8), .SFL = FL(8), .SFLo = FLo(8), .SBF = BF(8), .SFLD = FLD(8), .SFLM = FLM(8), .sFD = FD(8), .SFMD = FMD(8), .SFMM = FMM(8), .sFLA = FLA(8), .SFM = FM(8), .SFGHA = FGHA(8), .SFDec = FDec(8), .SFHo = FHo(8)}
        // FixData9 = New SFixData With {.SFZH = FZH(9), .SFZM = FZM(9), .SFZS = FZS(9), .SFZN = FZN(9), .SFMI = FMI(9), .SFL = FL(9), .SFLo = FLo(9), .SBF = BF(9), .SFLD = FLD(9), .SFLM = FLM(9), .sFD = FD(9), .SFMD = FMD(9), .SFMM = FMM(9), .sFLA = FLA(9), .SFM = FM(9), .SFGHA = FGHA(9), .SFDec = FDec(9), .SFHo = FHo(9)}
        // FixData10 = New SFixData With {.SFZH = FZH(10), .SFZM = FZM(10), .SFZS = FZS(10), .SFZN = FZN(10), .SFMI = FMI(10), .SFL = FL(10), .SFLo = FLo(10), .SBF = BF(10), .SFLD = FLD(10), .SFLM = FLM(10), .sFD = FD(10), .SFMD = FMD(10), .SFMM = FMM(10), .sFLA = FLA(10), .SFM = FM(10), .SFGHA = FGHA(10), .SFDec = FDec(10), .SFHo = FHo(10)}
        // FixData11 = New SFixData With {.SFZH = FZH(11), .SFZM = FZM(11), .SFZS = FZS(11), .SFZN = FZN(11), .SFMI = FMI(11), .SFL = FL(11), .SFLo = FLo(11), .SBF = BF(11), .SFLD = FLD(11), .SFLM = FLM(11), .sFD = FD(11), .SFMD = FMD(11), .SFMM = FMM(11), .sFLA = FLA(11), .SFM = FM(11), .SFGHA = FGHA(11), .SFDec = FDec(11), .SFHo = FHo(11)}
        // FixData12 = New SFixData With {.SFZH = FZH(12), .SFZM = FZM(12), .SFZS = FZS(12), .SFZN = FZN(12), .SFMI = FMI(12), .SFL = FL(12), .SFLo = FLo(12), .SBF = BF(12), .SFLD = FLD(12), .SFLM = FLM(12), .sFD = FD(12), .SFMD = FMD(12), .SFMM = FMM(12), .sFLA = FLA(12), .SFM = FM(12), .SFGHA = FGHA(12), .SFDec = FDec(12), .SFHo = FHo(12)}
        // Exit Sub
        // End Sub

        // Public Sub WriteFixScreen()
        // 'load up fix data from SRF1 form into Form4 / Fix form
        // Form4.FixSelectTxtBx.Clear()

        // IV = IU
        // If IU > 12 Then
        // IV = 12
        // End If
        // For IW = 1 To IV
        // i = IW
        // If IU > 12 Then
        // i = IW + IU - Int((IU - 1) / 12) * 12
        // End If
        // Form4.FixSelectTxtBx.AppendText(BF(i) & vbTab & vbTab & Strings.Format(FZH(i), "00") & "-" & Strings.Format(FZM(i), "00") & "-" & Strings.Format(FZS(i), "00") _
        // & vbTab & vbTab & Strings.Format(System.Math.Abs(FMI(i)), "0.0") & " " & FD(i) _
        // & vbTab & Strings.Format(FZN(i), "000") & Chr(176) _
        // & vbTab & Strings.Format(Val(FLD(i)), "00") & Chr(176) & Strings.Format(Val(FLM(i)), "00.0") & "'" & FLA(i) _
        // & Space(4) & Strings.Format(Val(FMD(i)), "##0") & Chr(176) & Strings.Format(Val(FMM(i)), "00.0") & "'" & FM(i) & vbNewLine & vbNewLine)
        // Next IW
        // Form4.FixSelectTxtBx.Refresh()
        // Form4.Show()
        // Exit Sub
        // End Sub

        public void DisplayTimeDiagram()
        {
            float XTD1, YTD1;
            float XTD2, YTD2;
            float TwoPi, i;
            // FormSRF.Font.Name = "MS Sans Serif"
            TwoPi = (float)(8d * Math.Atan(1d));
            EqTPicBx.Enabled = true;
            EqTPicBx.Visible = true;
            // RecycleSRF1Jpg()

            // set up fresh / new bitmap and graphics drawwing object for diagram and later additions
            int DrawWidth = (int)(EqTPicBx.Height / 2d - 20d);
            bm = new Bitmap(EqTPicBx.Width, EqTPicBx.Height);
            SRF1graphic = Graphics.FromImage(bm);
            SRF1graphic.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            SRF1graphic.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            SRF1graphic.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            SRF1graphic.TranslateTransform((float)(EqTPicBx.Width / 2d), (float)(EqTPicBx.Height / 2d));
            var DPen = new Pen(Color.Black, 1f);
            var DFontArial7Reg = new Font("Arial", 7f, FontStyle.Regular);
            var DFontArial8Reg = new Font("Arial", 8f, FontStyle.Regular);
            DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            var ptA = new Point();
            var ptB = new Point();
            int CircleRadii = DrawWidth + 5;
            SRF1graphic.DrawEllipse(DPen, -CircleRadii, -CircleRadii, 2 * CircleRadii, 2 * CircleRadii);
            var loopTo = TwoPi;
            for (i = 0f; TwoPi / 72f >= 0 ? i <= loopTo : i >= loopTo; i += TwoPi / 72f)
            {
                XTD1 = (float)(DrawWidth * Math.Cos(i)); // 600
                YTD1 = (float)(DrawWidth * Math.Sin(i)); // 600
                XTD2 = (float)((DrawWidth + 5) * Math.Cos(i));
                YTD2 = (float)((DrawWidth + 5) * Math.Sin(i));
                SRF1graphic.DrawLine(DPen, XTD1, YTD1, XTD2, YTD2);
            }

            var loopTo1 = TwoPi;
            for (i = 0f; TwoPi / 24f >= 0 ? i <= loopTo1 : i >= loopTo1; i += TwoPi / 24f)
            {
                XTD1 = (float)((DrawWidth - 5) * Math.Cos(i)); // 600
                YTD1 = (float)((DrawWidth - 5) * Math.Sin(i)); // 600
                XTD2 = (float)(DrawWidth * Math.Cos(i));
                YTD2 = (float)(DrawWidth * Math.Sin(i));
                SRF1graphic.DrawLine(DPen, XTD1, YTD1, XTD2, YTD2);
            }
            // make M / m meridian lables appear
            // draw meridian line to the top
            SRF1graphic.DrawLine(DPen, 0, 0, 0, -CircleRadii);
            SRF1graphic.DrawString("M", DFontArial8Reg, Brushes.Black, -6, -CircleRadii - 15);
            // draw lower meridian line
            DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            SRF1graphic.DrawLine(DPen, 0, 0, 0, CircleRadii);
            SRF1graphic.DrawString("m", DFontArial7Reg, Brushes.Black, -5, CircleRadii + 5);
            // if only drawwing basic time circle for initial load then stop here and exit - set true in form load 
            if (DrawBasicTimeDiagram == true)
            {
                DrawBasicTimeDiagram = false;
                goto ExitDrawTime;
            }
            // otherwise continue on drawwing rest of time diagram for sight reduction data entered
            // Greenwich lower branch
            XTD1 = (float)(CircleRadii * Math.Cos((90d + Lo) * Pi / 180d));
            YTD1 = (float)(CircleRadii * Math.Sin((90d + Lo) * Pi / 180d));
            SRF1graphic.DrawLine(DPen, 0f, 0f, XTD1, YTD1);
            var PtText = new Point((int)XTD1, (int)YTD1);
            PtText = SetPrintTextPt(PtText, 10, 10);
            SRF1graphic.DrawString("g", DFontArial7Reg, Brushes.Black, PtText);
            DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            // Greenwich upper branch
            XTD1 = (float)(CircleRadii * Math.Cos((-90 + Lo) * Pi / 180d));
            YTD1 = (float)(CircleRadii * Math.Sin((-90 + Lo) * Pi / 180d));
            SRF1graphic.DrawLine(DPen, 0f, 0f, XTD1, YTD1);
            PtText = new Point((int)XTD1, (int)YTD1);
            PtText = SetPrintTextPt(PtText, 10, 10);
            SRF1graphic.DrawString("G", DFontArial7Reg, Brushes.Black, PtText);

            // Aries (if star sight)
            if (BN <= 57)
            {
                XTD1 = (float)(CircleRadii * Math.Cos((-90 + Lo - GHAAries) * Pi / 180d));
                YTD1 = (float)(CircleRadii * Math.Sin((-90 + Lo - GHAAries) * Pi / 180d));
                SRF1graphic.DrawLine(DPen, 0f, 0f, XTD1, YTD1);
                PtText = new Point((int)XTD1, (int)YTD1);
                PtText = SetPrintTextPt(PtText, 10, 10);
                SRF1graphic.DrawString(Conversions.ToString(CommonGlobals.Aries_Uchar), DFontArial7Reg, Brushes.Black, PtText);
                // SRF1graphic.DrawString("V", DFontArial7Reg, Brushes.Black, PtText)
            }

            string DString = Constants.vbNullString;

            // Any body other than Sun
            if (BN < 64)
            {
                XTD1 = (float)(CircleRadii * Math.Cos((-LHA - 90d) * Pi / 180d));
                YTD1 = (float)(CircleRadii * Math.Sin((-LHA - 90d) * Pi / 180d));
                SRF1graphic.DrawLine(DPen, 0f, 0f, XTD1, YTD1);
                if (BN <= 57)
                {
                    DString = CommonGlobals.Black_Star_Uchar.ToString(); // "*"
                }

                if (BN >= 58 & BN <= 61)
                {
                    switch (BNBodyName ?? "")
                    {
                        case "Mercury":
                            {
                                DString = Conversions.ToString(CommonGlobals.Mercury_Uchar);
                                break;
                            }

                        case "Venus":
                            {
                                DString = Conversions.ToString(CommonGlobals.Venus_Uchar);
                                break;
                            }

                        case "Mars":
                            {
                                DString = Conversions.ToString(CommonGlobals.Mars_Uchar);
                                break;
                            }

                        case "Jupiter":
                            {
                                DString = Conversions.ToString(CommonGlobals.Jupiter_Uchar);
                                break;
                            }

                        case "Saturn":
                            {
                                DString = Conversions.ToString(CommonGlobals.Saturn_Uchar);
                                break;
                            }

                        case "Neptune":
                            {
                                DString = Conversions.ToString(CommonGlobals.Neptune_Uchar);
                                break;
                            }

                        case "Uranus":
                            {
                                DString = Conversions.ToString(CommonGlobals.Uranus_Uchar);
                                break;
                            }

                        case "Pluto":
                            {
                                DString = Conversions.ToString(CommonGlobals.Pluto_Uchar);
                                break;
                            }

                        default:
                            {
                                DString = "P";
                                break;
                            }
                    }
                }

                if (BN == 62 | BN == 63)
                {
                    switch (BNBodyName ?? "")
                    {
                        case "Moon":
                            {
                                DString = Conversions.ToString(CommonGlobals.Moon_FirstQtr_Uchar);
                                break;
                            }

                        default:
                            {
                                DString = "(";
                                break;
                            }
                    }
                }

                PtText = new Point((int)XTD1, (int)YTD1);
                PtText = SetPrintTextPt(PtText, 10, 10);
                SRF1graphic.DrawString(DString, DFontArial7Reg, Brushes.Black, PtText);
            }

            GetValidBN();
            // Mean Sun for all sights except sun
            if (BNType != "Sun")
            {

                // If BN <= 63 Then
                // T = Tfull
                Sun();
                HourAngles();
                XTD1 = (float)(CircleRadii * Math.Cos((90d + Lo - HG * 15d) * Pi / 180d));
                YTD1 = (float)(CircleRadii * Math.Sin((90d + Lo - HG * 15d) * Pi / 180d));
                SRF1graphic.DrawLine(DPen, 0f, 0f, XTD1, YTD1);
                PtText = new Point((int)XTD1, (int)YTD1);
                PtText = SetPrintTextPt(PtText, 10, 10);
                SRF1graphic.DrawString(CommonGlobals.Sun_Uchar.ToString(), DFontArial8Reg, Brushes.Black, PtText);
            }
            else
            {
                // GetValidBN()
                // Apparent sun for sun sight
                // If BN = 64 Or BN = 65 Then

                // T = Tfull
                Sun();
                HourAngles();
                XTD1 = (float)(CircleRadii * Math.Cos((90d + Lo - HG * 15d) * Pi / 180d));
                YTD1 = (float)(CircleRadii * Math.Sin((90d + Lo - HG * 15d) * Pi / 180d));
                SRF1graphic.DrawLine(DPen, 0f, 0f, XTD1, YTD1);
                PtText = new Point((int)XTD1, (int)YTD1);
                PtText = SetPrintTextPt(PtText, 10, 10);
                SRF1graphic.DrawString(CommonGlobals.Sun_Uchar.ToString(), DFontArial8Reg, Brushes.Black, PtText);
                XTD1 = (float)(CircleRadii * Math.Cos((-90 + Lo - HG * 15d) * Pi / 180d));
                YTD1 = (float)(CircleRadii * Math.Sin((-90 + Lo - HG * 15d) * Pi / 180d));
                // XTD1 = CircleRadii * (System.Math.Cos((-90 - LHA) * (Pi / 180)))
                // YTD1 = CircleRadii * (System.Math.Sin((-90 - LHA) * (Pi / 180)))
                SRF1graphic.DrawLine(DPen, 0f, 0f, XTD1, YTD1);
                PtText = new Point((int)XTD1, (int)YTD1);
                PtText = SetPrintTextPt(PtText, 10, 10);
                SRF1graphic.DrawString(CommonGlobals.Sun_Uchar.ToString(), DFontArial7Reg, Brushes.Blue, PtText);
            }

            if (DrawEqTDiagram == false)
            {
                goto ExitDrawTime;
            }

            JD = Conversion.Int(365.25d * (GYearJ + 4716)) + Conversion.Int(30.6001d * (GMonth + 1)) + DecimalDate - 1537.5d; // or else JD incorrect for planets
            int x = 0;
            int y = 0;

            // Mean Sun for sun sight
            if (BN == 64 | BN == 65)
            {
                Sun();
                HourAngles();
                DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                EqTinSeconds = (int)(GHA * 240d - UTinSeconds);
                while (Math.Abs(EqTinSeconds) >= 1020) // 17 minutes
                {
                    if (EqTinSeconds >= 0)
                    {
                        EqTinSeconds = EqTinSeconds - 43200; // 43200 is 12 hours in second
                        if (EqTinSeconds < 0)
                            break;
                    }

                    if (EqTinSeconds < 0)
                    {
                        EqTinSeconds = EqTinSeconds + 43200; // 43200 is 12 hours in seconds
                        if (EqTinSeconds >= 0)
                            break;
                    }
                }

                double HGCalc = EqTinSeconds / 60d;
                XTD1 = (float)(CircleRadii * Math.Cos((-90 - LHA + HGCalc) * Pi / 180d));
                YTD1 = (float)(CircleRadii * Math.Sin((-90 - LHA + HGCalc) * Pi / 180d));
                SRF1graphic.DrawLine(DPen, 0f, 0f, XTD1, YTD1);
                PtText = new Point((int)XTD1, (int)YTD1);
                PtText = SetPrintTextPt(PtText, 10, 10);
                SRF1graphic.DrawString(CommonGlobals.Sun_Uchar.ToString().ToString(), DFontArial8Reg, Brushes.Black, PtText);
                // SRF1graphic.DrawString("O", DFontArial7Reg, Brushes.Black, PtText)
            }

            T = Tfull;
            // Apparent sun for all sights except sun
            if (BN <= 63)
            {
                BN = 64;
                Sun();
                HourAngles();
                DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                XTD1 = (float)(CircleRadii * Math.Cos((-LHA - 90d) * Pi / 180d));
                YTD1 = (float)(CircleRadii * Math.Sin((-LHA - 90d) * Pi / 180d));
                SRF1graphic.DrawLine(DPen, 0f, 0f, XTD1, YTD1);
                PtText = new Point((int)XTD1, (int)YTD1);
                PtText = SetPrintTextPt(PtText, 10, 10);
                SRF1graphic.DrawString(CommonGlobals.Sun_Uchar.ToString(), DFontArial8Reg, Brushes.Black, PtText);
                // SRF1graphic.DrawString("o", DFontArial7Reg, Brushes.Black, PtText)
            }
            // Get LHA Sun for EqT
            BN = 64;
            Sun();
            HourAngles();
            // If GHA < 180 Then EqTinSeconds = GHA * 240 - (UTinSeconds - 43200) '43200 is 12 hours in seconds
            // If GHA >= 180 Then EqTinSeconds = GHA * 240 - (UTinSeconds + 43200) '43200 is 12 hours in seconds
            EqTinSeconds = (int)(GHA * 240d - UTinSeconds);
            while (Math.Abs(EqTinSeconds) >= 1020) // 17 minutes
            {
                if (EqTinSeconds >= 0)
                {
                    EqTinSeconds = EqTinSeconds - 43200; // 43200 is 12 hours in second
                    if (EqTinSeconds < 0)
                        break;
                }

                if (EqTinSeconds < 0)
                {
                    EqTinSeconds = EqTinSeconds + 43200; // 43200 is 12 hours in seconds
                    if (EqTinSeconds >= 0)
                        break;
                }
            }

            EqTminutes = (float)Conversion.Int(Math.Abs(EqTinSeconds / 60d));
            EqTseconds = Math.Abs(EqTinSeconds) - EqTminutes * 60f;
            XTD1 = -(CircleRadii + 10);
            YTD1 = -(CircleRadii + 10);
            if (Math.Sign(EqTinSeconds) == 1)
                DString = "(+)";
            if (Math.Sign(EqTinSeconds) == 0)
                DString = "   ";
            if (Math.Sign(EqTinSeconds) == -1)
                DString = "(-)";
            DString += Strings.Format(EqTminutes, "00") + "m" + Strings.Format(EqTseconds, "00") + "s";
            SRF1graphic.DrawString(DString, DFontArial7Reg, Brushes.Black, XTD1, YTD1);
        ExitDrawTime:
            ;
            if (File.Exists(BMFname))
            {
                File.Delete(BMFname);
            }

            bm.Save(BMFname);
            EqTPicBx.ImageLocation = BMFname;
            EqTPicBx.Refresh();
            bm.Dispose();
            DPen.Dispose();
            DFontArial7Reg.Dispose();
            DFontArial8Reg.Dispose();
            return;
        }

        // Public Sub SaveDisplayBMFname()
        // Try
        // RecycleSRF1Jpg()
        // bm.Save(BMFname)
        // EqTPicBx.Refresh()
        // Exit Sub
        // Catch ex1 As System.Runtime.InteropServices.ExternalException
        // Exit Sub
        // Catch ex As Exception
        // Dim file As System.IO.StreamWriter
        // file = My.Computer.FileSystem.OpenTextFileWriter("SRF1Log.txt", True)
        // file.WriteLine(Now.ToLongDateString & Space(2) & Now.ToLongTimeString & " - " & "Try #1 - Exception on BM Save: Name = " & BMFname & Space(2) & "  Exception: " & ex.ToString)
        // file.Close()
        // GoTo TryAgain
        // Finally
        // End Try
        // TryAgain:
        // Try
        // RecycleSRF1Jpg()
        // bm.Save(BMFname)
        // EqTPicBx.Refresh()
        // Exit Sub
        // Catch ex1 As System.Runtime.InteropServices.ExternalException
        // Exit Sub
        // Catch ex As Exception
        // Dim file As System.IO.StreamWriter
        // file = My.Computer.FileSystem.OpenTextFileWriter("SRF1Log.txt", True)
        // file.WriteLine(Now.ToLongDateString & Space(2) & Now.ToLongTimeString & " - " & "Try #2 - Exception on BM Save: Name =" & BMFname & "Exception: " & ex.ToString)
        // file.Close()
        // Exit Sub
        // End Try
        // EqTPicBx.Refresh()
        // Exit Sub
        // End Sub
        // Public Sub RecycleSRF1Jpg()
        // Dim NowTimeStr As String = Now.ToLongTimeString.Replace(":", "").Replace(" ", "").Replace("-", "").Replace("/", "").Trim
        // Randomize()
        // Dim RandomInt As Single = Rnd().ToString("####0")
        // BMFname = "./Graphics/SRFForm" & NowTimeStr & RandomInt.ToString.Replace(".", "") + ".jpg"
        // Exit Sub
        // End Sub

        public void PolarisMeans()
        {
            MeanSHAPol = 0d;
            MeanDecPol = 0d; // : GHour = 12 : GMinute = 0: GSecond = 0
            for (MonthPolaris = 1; MonthPolaris <= 12; MonthPolaris++)
            {
                GreenwichForPolaris();
                Delta_T();
                JulianForPolaris();
                // Obliquity
                // Nutation
                Stars();
                HourAngles();
                MeanSHAPol = MeanSHAPol + SH;
                MeanDecPol = MeanDecPol + DE;
            }

            MeanSHAPol = MeanSHAPol / 12d; // - 0.033333       'without -0.033333 MeanSHAPol averages about 2' greater than stated on page 256 of the Nautical Almanac (2009-2015 tested)
            MeanDecPol = MeanDecPol / 12d;
            return;
        }

        public void GreenwichForPolaris()
        {
            // Prefix (or suffix) G for Greenwich, UT = Universal Time
            MonthDays = "312831303130313130313031";
            // Check for local leap year
            LocalYear = (short)DTSight.Value.Year;

            // If (LocalYear Mod 4) = 0 Then
            // LeapYear = True
            // End If
            // If (LocalYear Mod 100) = 0 And (LocalYear Mod 400) <> 0 Then
            // LeapYear = False
            // End If
            LeapYear = DateTime.IsLeapYear(LocalYear);
            if (LeapYear == true)
            {
                MonthDays = "312931303130313130313031";
            }
            else
            {
                MonthDays = "312831303130313130313031";
            }

            DayNumber = 0;
            var loopTo = (short)(MonthPolaris - 1);
            for (i = 1; i <= loopTo; i++)
                DayNumber = (short)(Conversion.Val(Strings.Mid(MonthDays, 2 * i - 1, 2)) + DayNumber);
            if (MonthPolaris >= 3 & LeapYear == true)
            {
                DayNumber = (short)(DayNumber + 1);
            }

            GYear = (short)DTSight.Value.Year;
            GDayOfYear = DayNumber;
            if (GDayOfYear == 366 & LeapYear == false | GDayOfYear == 367)
            {
                GDayOfYear = 1;
                GYear = (short)(GYear + 1);
                goto GreenwichDate;
            }
            // Check for leap year at Greenwich
            // If (GYear Mod 4) = 0 Then
            // GLeapYear = True
            // End If
            // If (GYear Mod 100) = 0 And (GYear Mod 400) <> 0 Then
            // GLeapYear = False
            // End If
            GLeapYear = DateTime.IsLeapYear(GYear);
            // Days in year
            if (GDayOfYear == 0 & GLeapYear == false)
            {
                GDayOfYear = 365;
            }

            if (GDayOfYear == 0 & GLeapYear == true)
            {
                GDayOfYear = 366;
            }

        GreenwichDate:
            ;
            DayG[0] = GDayOfYear;
            if (GLeapYear == true)
            {
                MonthDays = "312931303130313130313031";
            }
            else
            {
                MonthDays = "312831303130313130313031";
            }

            for (i = 1; i <= 12; i++)
            {
                DayG[i] = (short)(DayG[i - 1] - Conversion.Val(Strings.Mid(MonthDays, 2 * i - 1, 2)));
                if (DayG[i] <= 0)
                {
                    GMonth = i;
                    GDay = DayG[i - 1];
                    goto GetMonth;
                }
            }

        GetMonth:
            ;
            MonthatG = Strings.Mid(MonthList, 3 * GMonth - 2, 3);
            return;
        }

        public void JulianForPolaris()  // UNFINISHED?
        {
            DecimalDate = GDay + GHour / 24d + GMinute / 1440d + GSecond / 86400.0f;
            DecimalDateHour1 = GDay + GHour / 24d;
            DecimalDateHour2 = GDay + (GHour + 1) / 24d;
            GYearJ = GYear;
            GMonth = MonthPolaris;
            if (GMonth < 3)
                GYearJ = (short)(GYear - 1);
            GMonth = (short)(GMonth + 12);
            JD = Conversion.Int(365.25d * (GYearJ + 4716)) + Conversion.Int(30.6001d * (GMonth + 1)) + DecimalDate - 1537.5d;
            T = (JD - 2451545d + DeltaT / 86400d) / 36525.0d;
            return;
        }

        public void Delta_T()
        {
            // reference this URL: http://eclipse.gsfc.nasa.gov/SEhelp/deltatpoly2004.html for concepts for this code
            DecYr = (float)(GYear + (GMonth - 0.5d) / 12d);
            if (GYear >= 1901 & GYear <= 1920)
            {
                Theta = DecYr - 1900f;
                DeltaT = -2.79d + 1.494119d * Theta - 0.0598939d * Math.Pow(Theta, 2d) + 0.0061966d * Math.Pow(Theta, 3d) - 0.000197d * Math.Pow(Theta, 4d);
            }

            if (GYear >= 1921 & GYear <= 1941)
            {
                Theta = DecYr - 1920f;
                DeltaT = 21.2d + 0.84493d * Theta - 0.0761d * Math.Pow(Theta, 2d) + 0.0020936d * Math.Pow(Theta, 3d);
            }

            if (GYear >= 1942 & GYear <= 1961)
            {
                Theta = DecYr - 1950f;
                DeltaT = 29.07d + 0.407d * Theta - Math.Pow(Theta, 2d) / 233d + Math.Pow(Theta, 3d) / 2547d;
            }

            if (GYear >= 1962 & GYear <= 1986)
            {
                Theta = DecYr - 1975f;
                DeltaT = 45.45d + 1.067d * Theta - Math.Pow(Theta, 2d) / 260d - Math.Pow(Theta, 3d) / 718d;
            }

            if (GYear >= 1987 & GYear <= 2005)
            {
                Theta = DecYr - 2000f;
                DeltaT = 63.86d + 0.3345d * Theta - 0.060374d * Math.Pow(Theta, 2d) + 0.0017275d * Math.Pow(Theta, 3d) + 0.000651814d * Math.Pow(Theta, 4d) + 0.00002373599d * Math.Pow(Theta, 5d);
            }

            if (GYear >= 2006 & GYear <= 2050)             // V5.6.1 could replace 2050 with 2009
            {
                Theta = DecYr - 2000f;
                DeltaT = 62.92d + 0.32217d * Theta + 0.005589d * Math.Pow(Theta, 2d);
            }
            // Next line NOT added in V5.6.1.  For June 1, 2017, predicted DeltaT value 70.2481, measured DeltaT value 68.8033.  With this change predicted value becomes 68.7579
            // If GYear >= 2010 And GYear <= 2099 Then DeltaT = 66.0699 + (DecYr - 2010) * 0.3604 'DeltaT increasing an average of about 0.36 seconds per year since the beginning of 2010 (66.0699)
            if (GYear >= 2051 & GYear <= 2099)
            {
                DeltaT = -20 + 32d * Math.Pow((DecYr - 1820f) / 100f, 2d) - 0.5628d * (2150f - DecYr);        // NOT removed in V5.6.1
            }

            return;
        }

        public void IandC()
        {
            switch (BN)
            {
                case var @case when 0 <= @case && @case <= 57: // is this a star sight
                    {
                        k = CommonGlobals.g_AriesHrDeg;
                        break;
                    }
                // k = 15.04106864
                case var case1 when 58 <= case1 && case1 <= 61: // is this a planet sight
                    {
                        k = CommonGlobals.g_SunPlanetsHrDeg;
                        break;
                    }
                // k = 15
                case 62:
                case 63: // is this a moon sight
                    {
                        k = CommonGlobals.g_MoonHrDeg;
                        break;
                    }
                // k = 14 + 19 / 60
                case 64:
                case 65: // is this a sun sight UL or LL
                    {
                        k = CommonGlobals.g_SunPlanetsHrDeg;
                        break;
                    }
                    // k = 15
            }
            // is this a moon sight (BN = 62 or 63),use rounded values
            if (BN == 62 | BN == 63)
            {
                GHAHourDeg1 = (short)Conversion.Int(GHAHour1);
                GHAHourMin1 = (GHAHour1 - GHAHourDeg1) * 60d;
                GHAHourMin1 = Conversion.Int(GHAHourMin1 * 10d + 0.5d) / 10d;
                if (GHAHourMin1 == 60d)
                {
                    GHAHourMin1 = 0d;
                    GHAHourDeg1 = (short)(GHAHourDeg1 + 1);
                }

                GHAHourDeg2 = (short)Conversion.Int(GHAHour2);
                GHAHourMin2 = (GHAHour2 - GHAHourDeg2) * 60d;
                GHAHourMin2 = Conversion.Int(GHAHourMin2 * 10d + 0.5d) / 10d;
                if (GHAHourMin2 == 60d)
                {
                    GHAHourMin2 = 0d;
                    GHAHourDeg2 = (short)(GHAHourDeg2 + 1);
                }

                HourChange = GHAHourDeg2 + GHAHourMin2 / 60d - (GHAHourDeg1 + GHAHourMin1 / 60d);
            }

            // not moon
            if (BN != 62 & BN != 63)
            {
                HourChange = GHAHour2 - GHAHour1;
            }

            if (HourChange < 0d)
            {
                HourChange = HourChange + 360d;
            }

            vvalue = HourChange - k;
            vvalue = vvalue * 60d;
            vvalue = Conversion.Int(vvalue * 10d + 0.5d) / 10d; // This line was lower
            if (BN <= 57 & BN >= 62 | BN > 57 & BN < 62 & cboPlanets.Text == "Accurate vals. of v/d" & GMinute == 0 & GSecond == 0)
            {
                vvalue = 0d;
            }

            SignHourChange = (short)Math.Sign(vvalue);
            GHAIncrement = k * (GMinute + GSecond / 60d) / 60d;
            vcorr = vvalue * (GMinute + 0.5d) / 60d;
            GHAIncrementDeg = (short)Conversion.Int(GHAIncrement);
            GHAIncrementMin = (GHAIncrement - GHAIncrementDeg) * 60d;
            GHAIncrementMin = Conversion.Int(GHAIncrementMin * 10d + 0.500000000001d) / 10d;
            // vvalue = Int(vvalue * 10 + 0.5) / 10
            // vcorr = Int(vcorr * 10 + 0.50000000000001) / 10
            vcorr = Math.Sign(vcorr) * Conversion.Int(Math.Abs(vcorr) * 10d + 0.50000000000001d) / 10d;
            if (GMinute == 22 & vvalue == 2.8d)
            {
                vcorr = 1.0d;
            }

            if (GMinute == 22 & vvalue == 16.4d)
            {
                vcorr = 6.1d;
            }

            if (GMinute == 42 & vvalue == 15.6d)
            {
                vcorr = 11.1d;
            }

            if (GMinute == 52 & vvalue == 13.2d)
            {
                vcorr = 11.6d;
            }

            if (GMinute == 52 & vvalue == 17.2d)
            {
                vcorr = 15.1d;
            }

            if (GMinute == 55 & vvalue == 18d)
            {
                vcorr = 16.7d;
            }

            if (GMinute == 57 & vvalue == 13.2d)
            {
                vcorr = 12.7d;
            }

            if (GMinute == 0 & GSecond == 0)
            {
                vcorr = 0d; // Add this line to not add correction to whole hour value
            }

            if (GYear <= 2001 & GMinute == 22 & vvalue == 2.8d)
            {
                vcorr = 1.0d;
            }

            if (GYear <= 2001 & GMinute == 22 & vvalue == 16.4d)
            {
                vcorr = 6.1d;
            }

            if (GYear <= 2001 & GMinute == 52 & vvalue == 9.2d)
            {
                vcorr = 8.1d;
            }

            if (GYear <= 2001 & GMinute == 52 & vvalue == 16.4d)
            {
                vcorr = 14.4d;
            }

            GHAHourDeg1 = (short)Conversion.Int(GHAHour1);
            GHAHourMin1 = (GHAHour1 - GHAHourDeg1) * 60d;
            GHAHourMin1 = Conversion.Int(GHAHourMin1 * 10d + 0.5d) / 10d;
            if (GHAHourMin1 == 60d)
            {
                GHAHourMin1 = 0d;
                GHAHourDeg1 = (short)(GHAHourDeg1 + 1);
            }

            if (BN <= 57)
            {
                if (StarNAFlag == false)
                {
                    TotGHA = SHdeg + SHmin / 60d + GHAHourDeg1 + GHAHourMin1 / 60d + GHAIncrementDeg + GHAIncrementMin / 60d;
                }

                if (StarNAFlag == true)
                {
                    TotGHA = SHdegDisplay + SHminDisplay / 60d + GHAHourDeg1 + GHAHourMin1 / 60d + GHAIncrementDeg + GHAIncrementMin / 60d;
                }
            }

            if (BN >= 58)
            {
                TotGHA = GHAHourDeg1 + GHAHourMin1 / 60d + GHAIncrementDeg + GHAIncrementMin / 60d; // + Sgn(HourChange) * vcorr / 60
                if (BN != 64 & BN != 65 | (BN == 64 | BN == 65) & cboSun.Text == "Accurate val. of hourly GHA")
                {
                    TotGHA = TotGHA + Math.Sign(HourChange) * vcorr / 60d;
                }
            }
            // If BN >= 58 Then TotGHA = GHAHourDeg1 * 60 + GHAHourMin1 + Int(GHAIncrement * 600 + 0.5) / 10 + Sgn(HourChange) * vcorr: TotGHA = TotGHA / 60
            TotGHADeg = (short)Conversion.Int(TotGHA);
            TotGHAMin = (TotGHA - TotGHADeg) * 60d;
            TotGHAMin = Conversion.Int(TotGHAMin * 10d + 0.50000000001d) / 10d; // THIS MAKES ROUNDING COME OUT RIGHT BUT GHA BETTER WITHOUT IT
            if (TotGHAMin == 60d)
            {
                TotGHAMin = 0d;
                TotGHADeg = (short)(TotGHADeg + 1);
            }

            if (TotGHADeg >= 360)
            {
                TotGHADeg = (short)(TotGHADeg - 360);
            }
            // LHA = TotGHA - Lo
            LHA = TotGHADeg + TotGHAMin / 60d - Lo;
            if (LHA >= 360d)
            {
                LHA = LHA - 360d;
            }

            if (LHA < 0d)
                LHA = LHA + 360d;
            LHADeg = (short)Conversion.Int(LHA);
            LHAMin = (LHA - LHADeg) * 60d;
            if (Conversion.Int(LHAMin * 10d + 0.5d) / 10d == 60d)
            {
                LHAMin = 0d;
                LHADeg = (short)(LHADeg + 1);
            }

            if (BN == 62 | BN == 63) // moon, use rounded values
            {
                DecDegrees = (short)Conversion.Int(Math.Abs(DE1));
                DecMinutes = (Math.Abs(DE1) - DecDegrees) * 60d;
                DecMinutes = Conversion.Int(DecMinutes * 10d + 0.5d) / 10d;
                if (Conversion.Int(DecMinutes * 10d + 0.5d) / 10d == 60d)
                {
                    DecMinutes = 0d;
                    DecDegrees = (short)(DecDegrees + 1);
                }

                DecDegrees2 = Conversion.Int(Math.Abs(DE2));
                DecMinutes2 = (Math.Abs(DE2) - DecDegrees2) * 60d;
                DecMinutes2 = Conversion.Int(DecMinutes2 * 10d + 0.5d) / 10d;
                if (Conversion.Int(DecMinutes2 * 10d + 0.5d) / 10d == 60d)
                {
                    DecMinutes2 = 0d;
                    DecDegrees2 = DecDegrees2 + 1d;
                }

                dvalue = (Math.Sign(DE2) * (DecDegrees2 + DecMinutes2 / 60d) - Math.Sign(DE1) * (DecDegrees + DecMinutes / 60d)) * 60d;
            }
            // not moon
            if (BN != 62 & BN != 63)
            {
                dvalue = (DE2 - DE1) * 60d;
            }
            // next line added sun stuff in V5.3.1
            if (BN > 57 & BN < 62 & cboPlanets.Text == "NA vals. of v/d" | BN == 64 | BN == 65 & cboSun.Text == "NA val. of hourly GHA/d")
            {
                dvalue = (DENA2 - DENA1) * 60d;
            }

            dvalue = Conversion.Int(Math.Abs(dvalue) * 10d + 0.5d) / 10d; // This line was lower
            Signdvalue = 1;
            if (Math.Abs(DE2) < Math.Abs(DE1))
            {
                Signdvalue = -1;
            }

            DecDegrees = (short)Conversion.Int(Math.Abs(DE1));
            DecMinutes = (Math.Abs(DE1) - DecDegrees) * 60d;
            if (Conversion.Int(DecMinutes * 10d + 0.5d) / 10d == 60d)
            {
                DecMinutes = 0d;
                DecDegrees = (short)(DecDegrees + 1);
            }

            if (Math.Sign(DE2) != Math.Sign(DE1) & Math.Sign(DE2) != 0 & Math.Sign(DE1) != 0)
            {
                Signdvalue = -1;
            }

            dvalue = Math.Abs(dvalue);
            if (GMinute == 0 & GSecond == 0)
                dvalue = 0d; // Add this line to not add correction to whole hour value
            if (dvalue < 0.05d)
                Signdvalue = 0;
            dcorr = dvalue * (GMinute + 0.5d) / 60d;
            dcorr = Conversion.Int(Math.Abs(dcorr) * 10d + 0.50000000000001d) / 10d;
            if (GMinute == 0 & GSecond == 0)
            {
                dcorr = 0d; // Add this line to not add correction to whole hour value
            }

            if (GYear <= 2001 & GMinute == 22 & dvalue == 2.8d)
            {
                dcorr = 1.0d;
            }

            if (GYear <= 2001 & GMinute == 22 & dvalue == 16.4d)
            {
                dcorr = 6.1d;
            }

            if (GYear <= 2001 & GMinute == 52 & dvalue == 9.2d)
            {
                dcorr = 8.1d;
            }

            if (GYear <= 2001 & GMinute == 52 & dvalue == 16.4d)
            {
                dcorr = 14.4d;
            }

            if (BN <= 57 & StarNAFlag == false)
            {
                TotDE = DE1;
            }

            if (BN <= 57 & StarNAFlag == true)
            {
                TotDE = DENA;
            }

            if (BN > 57)
            {
                TotDE = Math.Sign(DE1) * (Conversion.Int(Math.Abs(DE1) * 600d + 0.5d) / 10d + Signdvalue * dcorr);
                TotDE = TotDE / 60d;
            }

            TotDecDegrees = (short)Conversion.Int(Math.Abs(TotDE));
            TotDecMinutes = (Math.Abs(TotDE) - TotDecDegrees) * 60d;
            TotDecMinutes = Conversion.Int(TotDecMinutes * 10d + 0.5d) / 10d;
            if (TotDecMinutes == 60d)
            {
                TotDecMinutes = 0d;
                TotDecDegrees = (short)(TotDecDegrees + 1);
            }
        }

        public void IandCP()
        {
            SignHourChange = (short)Math.Sign(vvalue);
            GHAIncrement = 15d * (GMinute + GSecond / 60d) / 60d;
            GHAIncrementDeg = (short)Conversion.Int(GHAIncrement);
            GHAIncrementMin = (GHAIncrement - GHAIncrementDeg) * 60d;
            GHAIncrementMin = Conversion.Int(GHAIncrementMin * 10d + 0.500000000001d) / 10d;
            vcorr = vvalue * (GMinute + 0.5d) / 60d;
            vcorr = Math.Sign(vcorr) * Conversion.Int(Math.Abs(vcorr) * 10d + 0.50000000000001d) / 10d;
            if (GMinute == 22 & vvalue == 2.8d)
            {
                vcorr = 1.0d;
            }

            if (GMinute == 22 & vvalue == 16.4d)
            {
                vcorr = 6.1d;
            }

            if (GMinute == 42 & vvalue == 15.6d)
            {
                vcorr = 11.1d;
            }

            if (GMinute == 52 & vvalue == 13.2d)
            {
                vcorr = 11.6d;
            }

            if (GMinute == 52 & vvalue == 17.2d)
            {
                vcorr = 15.1d;
            }

            if (GMinute == 55 & vvalue == 18d)
            {
                vcorr = 16.7d;
            }

            if (GMinute == 57 & vvalue == 13.2d)
            {
                vcorr = 12.7d;
            }

            if (GMinute == 0 & GSecond == 0)
            {
                vcorr = 0d; // Add this line to not add correction to whole hour value
            }

            if (GYear <= 2001 & GMinute == 22 & vvalue == 2.8d)
            {
                vcorr = 1.0d;
            }

            if (GYear <= 2001 & GMinute == 22 & vvalue == 16.4d)
            {
                vcorr = 6.1d;
            }

            if (GYear <= 2001 & GMinute == 52 & vvalue == 9.2d)
            {
                vcorr = 8.1d;
            }

            if (GYear <= 2001 & GMinute == 52 & vvalue == 16.4d)
            {
                vcorr = 14.4d;
            }

            GHAHourDeg1 = (short)Conversion.Int(GHAHour1);
            GHAHourMin1 = (GHAHour1 - GHAHourDeg1) * 60d;
            GHAHourMin1 = Conversion.Int(GHAHourMin1 * 10d + 0.5d) / 10d;
            if (GHAHourMin1 == 60d)
            {
                GHAHourMin1 = 0d;
                GHAHourDeg1 = (short)(GHAHourDeg1 + 1);
            }

            TotGHA = GHAHourDeg1 + GHAHourMin1 / 60d + GHAIncrementDeg + GHAIncrementMin / 60d; // + Sgn(HourChange) * vcorr / 60
            TotGHA = TotGHA + Math.Sign(HourChange) * vcorr / 60d;
            TotGHADeg = (short)Conversion.Int(TotGHA);
            TotGHAMin = (TotGHA - TotGHADeg) * 60d;
            TotGHAMin = Conversion.Int(TotGHAMin * 10d + 0.50000000001d) / 10d; // THIS MAKES ROUNDING COME OUT RIGHT BUT GHA BETTER WITHOUT IT
            if (TotGHAMin == 60d)
            {
                TotGHAMin = 0d;
                TotGHADeg = (short)(TotGHADeg + 1);
            }

            if (TotGHADeg >= 360)
            {
                TotGHADeg = (short)(TotGHADeg - 360);
            }
            // LHA = TotGHA - Lo
            LHA = TotGHADeg + TotGHAMin / 60d - Lo;
            if (LHA >= 360d)
            {
                LHA = LHA - 360d;
            }

            if (LHA < 0d)
            {
                LHA = LHA + 360d;
            }

            LHADeg = (short)Conversion.Int(LHA);
            LHAMin = (LHA - LHADeg) * 60d;
            if (Conversion.Int(LHAMin * 10d + 0.5d) / 10d == 60d)
            {
                LHAMin = 0d;
                LHADeg = (short)(LHADeg + 1);
            }

            // next two lines try to fix Egbert's problem of 2/20/2016
            DecDegrees = (short)Conversion.Int(Math.Abs(DE1));
            DecMinutes = (Math.Abs(DE1) - DecDegrees) * 60d;
            if (Conversion.Int(DecMinutes * 10d + 0.5d) / 10d == 60d)
            {
                DecMinutes = 0d;
                DecDegrees = (short)(DecDegrees + 1);
            }

            dvalue = (DENA2 - DENA1) * 60d;
            dvalue = Conversion.Int(Math.Abs(dvalue) * 10d + 0.5d) / 10d; // This line was lower
            Signdvalue = 1;
            if (Math.Abs(DE2) < Math.Abs(DE1))
            {
                Signdvalue = -1;
            }

            if (Math.Sign(DE2) != Math.Sign(DE1) & Math.Sign(DE2) != 0 & Math.Sign(DE1) != 0)
            {
                Signdvalue = -1;
            }

            dvalue = Math.Abs(dvalue);
            if (GMinute == 0 & GSecond == 0)
            {
                dvalue = 0d; // Add this line to not add correction to whole hour value
            }

            if (dvalue < 0.05d)
            {
                Signdvalue = 0;
            }

            dcorr = dvalue * (GMinute + 0.5d) / 60d;
            dcorr = Conversion.Int(Math.Abs(dcorr) * 10d + 0.50000000000001d) / 10d;
            if (GMinute == 0 & GSecond == 0)
            {
                dcorr = 0d; // Add this line to not add correction to whole hour value
            }

            if (GYear <= 2001 & GMinute == 22 & dvalue == 2.8d)
            {
                dcorr = 1.0d;
            }

            if (GYear <= 2001 & GMinute == 22 & dvalue == 16.4d)
            {
                dcorr = 6.1d;
            }

            if (GYear <= 2001 & GMinute == 52 & dvalue == 9.2d)
            {
                dcorr = 8.1d;
            }

            if (GYear <= 2001 & GMinute == 52 & dvalue == 16.4d)
            {
                dcorr = 14.4d;
            }

            TotDE = Math.Sign(DE1) * (Conversion.Int(Math.Abs(DE1) * 600d + 0.5d) / 10d + Signdvalue * dcorr);
            TotDE = TotDE / 60d;
            TotDecDegrees = (short)Conversion.Int(Math.Abs(TotDE));
            TotDecMinutes = (Math.Abs(TotDE) - TotDecDegrees) * 60d;
            TotDecMinutes = Conversion.Int(TotDecMinutes * 10d + 0.5d) / 10d;
            if (TotDecMinutes == 60d)
            {
                TotDecMinutes = 0d;
                TotDecDegrees = (short)(TotDecDegrees + 1);
            }

            return;
        }

        private void Precession()
        {
            // coming in AR in degrees, DE in degrees
            AR = AR * Pi / 180d; // convert to radians
            DE = DE * Pi / 180d;
            T = (JD - 2451545d) / 36525d;
            Pre1 = 2306.2181d * T + 0.30188d * T * T + 0.017998d * T * T * T;
            Pre1 = Pre1 * Pi / 648000d; // radians (/3600 gives degress, *Pi/180 gives radians)
            Pre2 = 2306.2181d * T + 1.09468d * T * T + 0.018203d * T * T * T;
            Pre2 = Pre2 * Pi / 648000d; // radians (/3600 gives degress, *Pi/180 gives radians)
            Pre3 = 2004.3109d * T - 0.42665d * T * T - 0.041833d * T * T * T;
            Pre3 = Pre3 * Pi / 648000d; // radians (/3600 gives degress, *Pi/180 gives radians)
            A = Math.Cos(DE) * Math.Sin(AR + Pre1);
            B = Math.Cos(Pre3) * Math.Cos(DE) * Math.Cos(AR + Pre1) - Math.Sin(Pre3) * Math.Sin(DE);
            C = Math.Sin(Pre3) * Math.Cos(DE) * Math.Cos(AR + Pre1) + Math.Cos(Pre3) * Math.Sin(DE);
            D = Math.Atan(A / B);
            if (B < 0d)
                D = D + Pi;
            if (D >= 2d * Pi | D < 0d)
            {
                D = D - Conversion.Int(D / (2d * Pi)) * 2d * Pi;
            }

            AR = D + Pre2; // radians
            DE = Math.Atan(C / (Math.Sqrt(-C * C + 1d) + 9.999999E-21d)); // arcsin(C), radians
            return;
        }

        private void SelectAllText(ref TextBox TB)
        {
            TB.SelectionStart = 0;
            TB.SelectionLength = Strings.Len(TB.Text);
        }

        public void SetTxtBxUlineOn(ref TextBox TB)
        {
            TB.Font = new Font(TB.Font, FontStyle.Underline);
        }

        public void SetTxtBxBoldOn(ref TextBox TB)
        {
            TB.Font = new Font(TB.Font, FontStyle.Bold);
        }

        public void SetTxtBxtoReg(ref TextBox TB)
        {
            TB.Font = new Font(TB.Font, FontStyle.Regular);
        }

        public void CleanOutOldFiles()
        {
            foreach (string foundFile in My.MyProject.Computer.FileSystem.GetFiles(My.MyProject.Computer.FileSystem.CurrentDirectory + "./Graphics", Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, "SRF*.jpg"))
                My.MyProject.Computer.FileSystem.DeleteFile(foundFile);
            BMFname = "./Graphics/SRF1.jpg";
            return;
        }

        public void ClearScreen()
        {
            var g = EqTPicBx.CreateGraphics();
            g.Clear(Color.Empty);
            g.Dispose();
            EqTPicBx.Visible = false;
            EqTPicBx.Enabled = false;
            ClearTextBoxes();
            CleanOutOldFiles();
            EqTPicBx.Refresh();
            // cboDay.SelectedIndex = VB.Day(Today) - 1 '-1 because ListIndex starts with 0
            MonthList = "JanFebMarAprMayJunJulAugSepOctNovDec";
            // only preset Sight DT to Now IF FormSRF is not yet loaded - on the initial form load. If it is loaded then leave this field as it is
            if (FormSRFLoaded == false)
            {
                DTSight.Value = DateTime.Now;
                cboPolaris.SelectedIndex = 0; // "Latitude by altitude of Polaris"
                cboSun.SelectedIndex = 0; // "NA val. of hourly GHA/d"
                cboStars.SelectedIndex = 0; // "NA val. of SHA and Dec"
                cboPlanets.SelectedIndex = 0; // NA val. of v/d
                cboWE.SelectedIndex = 0; // "fast"
                cboL.SelectedIndex = 0; // "N"
                cboLo.SelectedIndex = 0; // "W"
                cboIE.SelectedIndex = 0; // "on the arc"
                cboHE.SelectedIndex = 0; // "ft"
                cboDsUnit.SelectedIndex = 1; // "yards"
                cboTemperature.SelectedIndex = 0; // "F "
                cboPressure.SelectedIndex = 0; // "in Hg"
                cboBody.SelectedIndex = 0; // "Sun"
                cboSun.Visible = true;
                cboSun.BringToFront();
                cboSun.SelectedIndex = 0;
                optLower.Checked = true;
                frmLimb.Visible = true;
                frmLimb.Refresh();
            }

            Refresh();
            return;
        }

        public void ClearTextBoxes()
        {
            TimeTxtBx.Clear();
            LHATxtBx.Clear();
            SightTxtBx.Clear();
            DecTxtBx.Clear();
            AltitudeTxtBx.Clear();
            IntAzTxtBx.Clear();
            DGTime.Visible = false;
            DGLHA.Visible = false;
            DGSight.Visible = false;
            DGDec.Visible = false;
            DGAlt.Visible = false;
            return;
        }

        private void ClearAllBtn_Click(object sender, EventArgs e)
        {
            FormSRF_Load(sender, e);
            // ClearScreen()
        }

        private void EqTPicBx_Paint(object sender, PaintEventArgs e)
        {
            // If IssuingSendMsgBx = True Then
            // IssuingSendMsgBx = False
            // Exit Sub
            // End If
            // If My.Computer.FileSystem.FileExists(BMFname) Then
            // EqTPicBx.Load(BMFname)
            // Else
            // System.IO.File.Create(BMFname)
            // 'EqTPicBx.Load(BMFname)
            // End If
            // Exit Sub
        }

        public void SendMsgBx(string SendStr, MessageBoxIcon IconType)
        {
            // this subroutine is required because issuing a raw SendMsgBx call also trigger a Paint event for graphic box on form which cannot be handled properly in error conditions
            IssuingSendMsgBx = true;
            string HdrStr = Constants.vbNullString;
            // HdrStr = IconType.ToString
            if (IconType == MessageBoxIcon.Error)
            {
                HdrStr = "Input Error";
            }
            else if (IconType == MessageBoxIcon.Warning)
            {
                HdrStr = "Warning Message";
            }
            else if (IconType == MessageBoxIcon.Information)
            {
                HdrStr = "Information Message";
            }
            else if (IconType == MessageBoxIcon.Stop)
            {
                HdrStr = "STOP - Program Error";
            }
            else
            {
                HdrStr = "General Message";
            }

            MessageBox.Show(SendStr, HdrStr, MessageBoxButtons.OK, IconType, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            Show();
            return;
        }

        public Point SetPrintTextPt(Point Ptin, int CxIn, int CyIn)
        {
            var PtOut = new Point(0, 0);
            if (Ptin.X >= 0)
            {
                if (Ptin.Y >= 0)
                {
                    PtOut.X = (int)(Ptin.X + CxIn / 2d);
                    PtOut.Y = (int)(Ptin.Y + CyIn / 2d);
                }
                else
                {
                    PtOut.X = (int)(Ptin.X + CxIn / 2d);
                    PtOut.Y = Ptin.Y - CyIn;
                }
            }
            else if (Ptin.Y >= 0)
            {
                PtOut.X = Ptin.X - CxIn;
                PtOut.Y = (int)(Ptin.Y + CyIn / 2d);
            }
            else
            {
                PtOut.X = Ptin.X - CxIn;
                PtOut.Y = Ptin.Y - CyIn;
            }

            return PtOut;
        }

        private void btnCLSPlot_Click(object sender, EventArgs e)
        {
            PlotOut.PsnName = "SRF Sight";
            PlotOut.SquadronName = "SRF Sight Reduction";
            PlotOut.PlotType = "Sight";
            PlotOut.PlotNumber = txtSightNo.Text;
            PlotOut.PlotDT = DTSight.Value;
            PlotOut.PlotBody = cboBody.Items[cboBody.SelectedIndex].ToString();
            PlotOut.PlotLat = Convert.ToDouble(txtLDeg.Text) + Convert.ToDouble(txtLMin.Text) / 60.0d;
            PlotOut.PlotLatDeg = txtLDeg.Text;
            PlotOut.PlotLatMin = txtLMin.Text;
            PlotOut.PlotLatSec = "0";
            PlotOut.PlotLatNS = cboL.Items[cboL.SelectedIndex].ToString().Trim();
            PlotOut.PlotLong = Convert.ToDouble(txtLoDeg.Text) + Convert.ToDouble(txtLoMin.Text) / 60.0d;
            PlotOut.PlotLongDeg = txtLoDeg.Text;
            PlotOut.PlotLongMin = txtLoMin.Text;
            PlotOut.PlotLongSec = "0";
            PlotOut.PlotLongEW = cboLo.Items[cboLo.SelectedIndex].ToString().Trim();
            PlotOut.PlotLLoBy = cboLLoBy.Text.ToString();
            PlotOut.PlotExtendedLines = false;
            // the formatting of these next three fields is done in the routine that formats the intaztxtbx 
            // PlotOut.PlotAz = PlotAzimuth
            // PlotOut.PlotIntercept = PlotIntercept

            // PlotOut.PlotSLEP = txtSRFEP.Text.ToString

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
            PlotOut.PsnName = "SRF Sight";
            PlotOut.SquadronName = "SRF Sight Reduction";
            PlotOut.PlotType = "Sight";
            PlotOut.PlotNumber = txtSightNo.Text;
            PlotOut.PlotDT = DTSight.Value;
            PlotOut.PlotBody = cboBody.Items[cboBody.SelectedIndex].ToString();
            PlotOut.PlotLat = Convert.ToDouble(txtLDeg.Text) + Convert.ToDouble(txtLMin.Text) / 60.0d;
            PlotOut.PlotLatDeg = txtLDeg.Text;
            PlotOut.PlotLatMin = txtLMin.Text;
            PlotOut.PlotLatSec = "0";
            PlotOut.PlotLatNS = cboL.Items[cboL.SelectedIndex].ToString().Trim();
            PlotOut.PlotLong = Convert.ToDouble(txtLoDeg.Text) + Convert.ToDouble(txtLoMin.Text) / 60.0d;
            PlotOut.PlotLongDeg = txtLoDeg.Text;
            PlotOut.PlotLongMin = txtLoMin.Text;
            PlotOut.PlotLongSec = "0";
            PlotOut.PlotLongEW = cboLo.Items[cboLo.SelectedIndex].ToString().Trim();
            PlotOut.PlotLLoBy = cboLLoBy.Text.ToString();
            PlotOut.PlotExtendedLines = false;
            // the formatting of these next three fields is done in the routine that formats the intaztxtbx 
            // PlotOut.PlotAz = PlotAzimuth
            // PlotOut.PlotIntercept = PlotIntercept

            // PlotOut.PlotSLEP = txtSRFEP.Text.ToString

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

        public bool CheckOpenWinForms(string FormNameIn)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name.Equals(FormNameIn, StringComparison.CurrentCultureIgnoreCase))
                {
                    return true;
                    return default;
                }
            }

            return false;
            return default;
        }

        private void DGTime_SelectionChanged(object sender, EventArgs e)
        {
            DGTime.ClearSelection();
            return;
        }

        private void DGLHA_SelectionChanged(object sender, EventArgs e)
        {
            DGLHA.ClearSelection();
            return;
        }

        private void DGSight_SelectionChanged(object sender, EventArgs e)
        {
            DGSight.ClearSelection();
            return;
        }

        private void DGDec_SelectionChanged(object sender, EventArgs e)
        {
            DGDec.ClearSelection();
            return;
        }

        private void DGAlt_SelectionChanged(object sender, EventArgs e)
        {
            DGAlt.ClearSelection();
            return;
        }
    }
}