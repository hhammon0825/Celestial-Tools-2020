using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    internal partial class FormNoonSight : Form
    {
        
        public bool InitLoadComplete = false;
        public bool InvokedBySightLog = false;
        private double Lo, Pi;
        private int ZD;
        private string DateOfSight;
        private int ZTinSeconds;
        private short i;
        private double JD, DecimalDateHour1, DecimalDate, DecimalDateHour2, T;
        private double TP, GA, HG, Lat;
        private string HD, MonthList, SignZD, MonthatG, fnumeral;
        private string MonthDays;
        private short GYearJ;
        private double JDHour1, JDHour2;
        private short GDayOfYear, GHour, DayNumber, GHourLAN;
        private int GMinute, GSecond;
        private short LocalYear, GDay, GMonth, GYear, MonthNumber;
        private int ZDinSeconds, UTinSeconds;
        private bool LeapYear, GLeapYear;
        private double L, C, OE, LMin;
        private string LH, dh;
        private short LDeg;
        private double B, MS;
        private double NL, NO;
        private double WM, LR, GR, VM, QM;
        private short WD, QD;
        private double VD;
        private double RN, LN, NU;
        private double AR = 0;
        private double x, y, DE;
        private double SH;
        private short GRD;
        private double RstdTP, Rstd, Main_Renamed, Raddl, RstdA2;
        private double RA, GRM, DF;
        private bool DateError;
        private short LANMinutes, LANSeconds;
        private double hsinMinutes, ICinMinutes, hainMinutes;
        private double Corr1, Corr1Min;
        private short Corr1Deg;
        private bool BackSight;
        private double PA, HP, r;
        private double HoMin, Corr2Min, HoinMinutes, HoDeg;
        private double PX, DI, TX, DecMinutes;
        private double DecDegrees;
        private short haDeg;
        private double HsMin, Pressure, HEinFeet, haMin, HE, Temperature, DipShortDist, ICMin;
        private double ZenithDistinDeg, ZenithDistMin;
        private short ZenithDistDeg;
        private double ZDMan, DRL;
        private int ZDManinSeconds;
        private bool SunAzN, SunAzS;
        private double Ldiff;
        private string EW;
        private float DecYr, Theta;
        private int TLANObsSec;
        private bool Flag3, Flag, Flag2;
        private double DeltaT; // , FlagLAN As Boolean, Flag2 As Boolean
        private double DE1 = 0;
        private double THour1 = 0;
        private double THour2 = 0;
        private double DE2 = 0;
        private double dvalue, dcorr;
        private short Signdvalue;
        private short TotDecDegrees, Lendcorr;
        private double TotDE, TotDecMinutes, LoforLAN;
        private short GHADeg, LoforLANDeg;
        private double GHAMin, LoforLANMin;
        private double LANTime, GHADiff, GHADiffMin, ZTofLAN, EQTZTofLAN;
        private short GHADiffDeg;
        private short ZTofLANMinutes, ZTofLANHours, ZTofLANSeconds;
        private short EQTZTofLANMinutes, EQTZTofLANHours, EQTZTofLANSeconds;
        private double GHAAriesHour, GHAHour;
        private double NutF, NutM, NutD, NutMprime, NutOmega;
        private int[] NCos = new int[65], NSin = new int[65], NF = new int[65], NM = new int[65], ND = new int[65], NMprime = new int[65], NOmega = new int[65], NSinT = new int[65], NCosT = new int[65];
        private double L1, Ecc, OETrue, L0, JDHour;
        private string DRLMin, LoMin;
        private double RH;
        private double SunHourChange, GHAHour1, GHAHour2, SunGHACorr;
        private short GHourLANDisplay, ZTofLANHoursDisplay;
        private short StarDayNumber;
        // Added March 2017 as part of conversion to DotNet - added bitmap to implement new graphics code in meridian diagram routine
        private Bitmap bm;
        private string BMFname = "./Graphics/Noonsight.jpg";
        private Graphics meridgraphic;
        private bool IssuingSendMsgBx = false;

        public struct EqTimeRec
        {
            public string EqtLat;
            public string EqtLong;
            public string EqTimeDate;
            public string EqTZTLAN;
            public string EqTimeFactor;
            public string EqTimeDec;
            public string EqTimeHo;
        }
        // Public EqtimeTbl() As EqTimeRec
        public string EqTimeFname = "./HelpFiles/EQofTimeData.txt";
        public int ArrCt = 0;
        public double SaveSunMeanEquLo = 0d;
        public double SaveSunRightAsc = 0d;
        public double EqTFactor = 0d;
        public int EqTimeFactorMin = 0;
        public int EqTimeFactorSec = 0;
        public EqTimeRec[] EqtTable;
        public EqTimeRec[] MTTable;
        public DateTime DTInput;

        private void ClearTimeTxt()
        {
            txtTime.Clear();
            txtCalcHo.Clear();
            // txtEqTime.Clear()
            LANTimeTxtBx.Clear();
            return;
        }

        private void cboDRL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InitLoadComplete == false) return;
            ClearTimeTxt();
            cmdNoonSight.Visible = false;
            OldFormBtn.Visible = false;
            NewFormBtn.Visible = false;
            lblN.Visible = false;
            lblS.Visible = false;
            lblZ.Visible = false;
            return;
        }

        private void cboLo_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            if (InitLoadComplete == false) return;
            ClearTimeTxt();
            cmdNoonSight.Visible = false;
            OldFormBtn.Visible = false;
            NewFormBtn.Visible = false;
            lblN.Visible = false;
            lblS.Visible = false;
            lblZ.Visible = false;
            AutoZDCalc();
        }

        private void cboZDm_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            if (InitLoadComplete == false) return;
            // ClearScreen()
            ClearTimeTxt();
            cmdNoonSight.Visible = false;
            OldFormBtn.Visible = false;
            NewFormBtn.Visible = false;
            lblN.Visible = false;
            lblS.Visible = false;
            lblZ.Visible = false;
        }

        private void chkDST_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            // ClearScreen()
            // ClearTimeTxt()

            // cmdNoonSight.Visible = False
            // OldFormBtn.Visible = False
            // NewFormBtn.Visible = False
            // lblN.Visible = False
            // lblS.Visible = False
            // lblZ.Visible = False
            // 'txtLoMin.ForeColor = &H80000008
            // txtLoMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)

        }

        private void LongitudeByLAN()
        {
            Flag2 = true;
            DTInput = DTNoonSight.Value;
            ZTinSeconds = (int)(3600 * DTInput.Hour + 60 * DTInput.Minute + DTInput.Second - (ZD - ZDMan) * 3600d);
            Greenwich();
            Delta_T();
            Julian();
            Nutation();
            Obliquity();
            Aries();
            Sun();
            GA = GR - AR;
            if (GA >= 360d | GA < 0d)
            {
                GA = GA - Conversion.Int(GA / 360d) * 360d;
            }

            EW = CommonGlobals.g_LongW;
            if (GA > 180d)
            {
                GA = 360d - GA;
                EW = CommonGlobals.g_LongE;
            }

            VD = Conversion.Int(GA);
            VM = (GA - VD) * 60d;
            VM = Conversion.Int(VM * 10d + 0.5d) / 10d;
            if (VM == 60d)
            {
                VM = 0d;
                VD = VD + 1d;
            }

            if ((VD == 0d | VD == 180d) & VM == 0d)
            {
                EW = "";
            }

            Flag2 = false;
        }

        private void DisplayLongitudeByDTInput()
        {
            LongitudeCalcTxtBx.Text = Constants.vbNullString;
            LongitudeCalcTxtBx.AppendText("Longitude from observed ZT of LAN " + VD.ToString("0") + '°' + VM.ToString("00.0") + "'" + EW);
        }

        private void cmdLAN_Click(object eventSender, EventArgs eventArgs)
        {
            if (InitLoadComplete == false) return;
          
            if (string.IsNullOrEmpty(txtDRLDeg.Text))
            {
                txtDRLDeg.Text = "0";
            }

            if (string.IsNullOrEmpty(txtLoDeg.Text))
            {
                txtLoDeg.Text = "0";
            }

            if (string.IsNullOrEmpty(txtDRLMin.Text))
            {
                txtDRLMin.Text = "0";
            }

            if (string.IsNullOrEmpty(txtLoMin.Text))
            {
                txtLoMin.Text = "0";
            }

            DTInput = new DateTime(DTNoonSight.Value.Year, DTNoonSight.Value.Month, DTNoonSight.Value.Day, 12, 0, 0);
            // DTInput = DTNoonSight.Value
            LAN();
            GHourLAN = GHour;
            GHourLANDisplay = GHour;
            ZTofLANHoursDisplay = ZTofLANHours;
            EqTFactor = 4d * (SaveSunMeanEquLo - SaveSunRightAsc);
            DisplayLANTime();
            txtTime.Text = ZTofLANHours.ToString("00") + ":" + ZTofLANMinutes.ToString("00") + ":" + ZTofLANSeconds.ToString("00");

            // FormNoonSight.MousePointer = 0
            cmdNoonSight.Visible = true;
            OldFormBtn.Visible = true;
            NewFormBtn.Visible = true;
            Flag = true;
            // FlagLAN = False
            txtTime.Visible = true;
            txtTime.BackColor = Control.DefaultBackColor; 
            double TmpLat = Convert.ToDouble(txtDRLDeg.Text) + Convert.ToDouble(txtDRLMin.Text) / 60d;
            // If cboDRL.Items(cboDRL.SelectedIndex).ToString = g_LatS Then
            if ((cboDRL.Text.ToString().Trim() ?? "") == (CommonGlobals.g_LatS ?? ""))
            {
                TmpLat = -1 * TmpLat;
            }

            double TempHo = 90d - (TmpLat - DE);
            if ((cboDRL.Text.ToString().Trim() ?? "") == (CommonGlobals.g_LatS ?? ""))
            {
                TempHo = 180d - TempHo;
            }

            int TempHoDeg = (int)Conversion.Int(TempHo);
            double TempHoMin = (TempHo - TempHoDeg) * 60d;
            string TempHoStr = TempHoDeg.ToString("#0") + '°' + " " + TempHoMin.ToString("#0.0") + "'";
            txtCalcHo.Text = TempHoStr;
            // BuildEqtTable()
            btnDisplayEQTData.Visible = true;
            return;
        }

        private void LAN()
        {
            Flag2 = true;
            // LANTimeTxtBx.Text = vbNullString
            // txtTime.Text = vbNullString
            lblN.Visible = false;
            lblS.Visible = false;
            lblZ.Visible = false;
            AutoZDCalc();
            Longitude();
            if (cboLo.Text == "W")
            {
                LoforLAN = Lo;
            }
            else
            {
                LoforLAN = 360d - Math.Abs(Lo);
            }

            ZTinSeconds = 43200; // 43,200 in seconds is the same as 12 hr 0 min 0 sec - this effectively sets the time at noon
                                 // DTInput = DTNoonSight.Value
            Greenwich();
            Delta_T();
            Julian();
            Nutation();
            Obliquity();
            Aries();
            Sun();
            GHADec();
            GHADiff = LoforLAN - GA;
            if (GHADiff < 0d)
            {
                GHADiff = GHADiff + 360d;
            }

            if (GHADiff >= 15d)
            {
                ZTinSeconds = 39600; // 11h instead of 12h noon as ZT
                                     // DTInput = DTNoonSight.Value
                Greenwich();
                Delta_T();
                Julian();
                Nutation();
                Obliquity();
                Aries();
                Sun();
                GHADec();
                GHADiff = LoforLAN - GA;
                if (GHADiff < 0d)
                    GHADiff = 360d + GHADiff;
            }

            SaveSunMeanEquLo = LN; // Save Off for Eqt Time calc
            SaveSunRightAsc = AR + C; // Save off Sun Ra + C for EqT Calc
            GHADeg = (short)Conversion.Int(GA);
            GHAMin = (GA - GHADeg) * 60d;
            if (GHAMin >= 60d)
            {
                GHAMin = GHAMin - 60d;
                GHADeg = (short)(GHADeg + 1);
            }

            if (GHADeg >= 360)
            {
                GHADeg = (short)(GHADeg - 360);
            }

            Cursor = Cursors.Default;
            Flag2 = false;
        }

        private void cmdNoonSight_Click(object eventSender, EventArgs eventArgs) // This change was made in V4.9.0 as the easiest way to make Noon Sight without first calculating ZT of LAN work properly.  Fix was wrong in V4.6.1.
        {
            if (InitLoadComplete == false) return;
            ExecNoonSightCmd();
            return;
        }

        public void ExecNoonSightCmd()
        {
            Flag3 = false; // Flag3 used to prevent Sub from continuing if there are messages
            DTInput = new DateTime(DTNoonSight.Value.Year, DTNoonSight.Value.Month, DTNoonSight.Value.Day, 12, 0, 0); // set DT for Greenwich in LAB sub to noon on ZT input
            LAN();
            DTInput = DTNoonSight.Value; // set the DT for Noonsight sub calcs to the ZT input on form
            NoonSight();
            if (Flag3 == true)
                return; // this line was after second NoonSight, but it allowed a second message
                        // NoonSight() 'need this so don't need second click - not sure why this is needed but I left it in because it is so strange and when removed was not certain noonsight was working
            DisplayLANTime();
            DisplayNoonSight();
            DisplayMeridianDiagram();
            DisplayLongitudeByDTInput();
        }

        private void NoonSight()
        {
            Flag2 = true;
            Longitude(); // Added as part of European comma as decimal separator solution
            if (cboIE.Text == "off the arc (rdg.)" & Conversion.Val(txtIEdeg.Text) == 0d)
            {
                ErrorMsgBox("For IE off the arc (rdg.), degree value cannot be zero.", "Input Error", MessageBoxButtons.OK);
                Flag3 = true;
                return;
            }

            if (optLower.Checked == true)
            {
                if (optHorizonBubble.Checked == true)
                {
                    SendMsgBx("Caution:  Improper combination of lower limb and bubble horizon.");
                    Flag3 = true;
                    return;
                }
            }

            if (optUpper.Checked == true)
            {
                if (optHorizonBubble.Checked == true)
                {
                    SendMsgBx("Caution:  Improper combination of upper limb and bubble horizon.");
                    Flag3 = true;
                    return;
                }
            }

            if (optCenter.Checked == true)
            {
                if (optHorizonNatural.Checked == true | optHorizonDipShort.Checked == true)
                {
                    SendMsgBx("Caution:  Improper combination of center and natural or dip short horizon.");
                    Flag3 = true;
                    return;
                }
            }

            ZDinSeconds = (int)(3600 * Math.Sign(ZD) * Conversion.Int(Lo / 15d)); // goes back to normal ZD without (Lo + 1) correction in Greenwich
            ZTinSeconds = (int)(3600d * Conversion.Val(Strings.Left(txtTime.Text, 2)) + 60d * Conversion.Val(Strings.Mid(txtTime.Text, 3, 2)) + Conversion.Val(Strings.Right(txtTime.Text, 2)));
            // ZTinSeconds = (3600 * DTInput.Hour) + (60 * DTInput.Minute) + DTInput.Second - ((ZD - ZDMan) * 3600)
            UTinSeconds = ZTinSeconds + (ZDinSeconds - ZDManinSeconds);
            if ((int)chkDST.CheckState == 1)
            {
                UTinSeconds = UTinSeconds - 3600;
            }
            //Greenwich();
            //Delta_T();
            //Julian();
            //T = THour1;
            //JDHour = JDHour1;
            //Nutation();
            //Obliquity();
            //Aries();
            //Sun();
            //DE1 = DE;
            //HourAnglesHour();
            //GHAHour1 = GHAHour;

            //Greenwich();
            //Delta_T();
            //Julian();
            //T = THour2;
            //JDHour = JDHour2;
            //Nutation();
            //Obliquity();
            //Aries();
            //Sun();
            //DE2 = DE;
            //HourAnglesHour();
            //GHAHour2 = GHAHour;

            GHADec();
            IandC();
            if (optAzN.Checked == false & optAzS.Checked == false & optDRL.Checked == false)
            {
                ErrorMsgBox("You must select a sun azimuth or DR L at LAN.", "Input Error", MessageBoxButtons.OK);
                Flag3 = true;
                return;
            }

            if (optHorizonDipShort.Checked == true & Conversion.Val(txtDsDist.Text) == 0d)
            {
                txtDsDist.Focus();
                ErrorMsgBox("You must enter a non-zero value for Ds distance", "Input Error", MessageBoxButtons.OK);
                Flag3 = true;
                return;
                // End If
            }

            if (Flag3 == true)
            {
                return;
            }

            AltitudeCorrection();
            DecDegrees = Conversion.Int(Math.Abs(DE1));
            DecMinutes = (Math.Abs(DE1) - DecDegrees) * 60d;
            if (Conversion.Val(Strings.Left(txtTime.Text, 2)) > ZTofLANHours)
            {
                DecDegrees = Conversion.Int(Math.Abs(DE2));
                DecMinutes = (Math.Abs(DE2) - DecDegrees) * 60d;
            }

            if (Conversion.Int(DecMinutes * 10d + 0.5d) / 10d == 60d)
            {
                DecMinutes = 0d;
                DecDegrees = DecDegrees + 1d;
            }

            ZenithDistinDeg = (5400d - HoinMinutes) / 60d;
            ZenithDistDeg = (short)Conversion.Int(ZenithDistinDeg);
            ZenithDistMin = (ZenithDistinDeg - ZenithDistDeg) * 60d;
            ZenithDistMin = Conversion.Int(ZenithDistMin * 10d + 0.5d) / 10d;
            if (ZenithDistMin == 60d)
            {
                ZenithDistMin = 0d;
                ZenithDistDeg = (short)(ZenithDistDeg + 1);
            }

            LatCalc();
            LongitudeByLAN();
            GHourLAN = (short)(Conversion.Val(Strings.Left(txtTime.Text, 2)) + ZDMan); // ZDMan was ZD; changed in V5.4.0
            Flag2 = false;
            return;
        }

        private void cmdPrint_Click(object eventSender, EventArgs eventArgs)
        {
            Print_Renamed.PrintScreen(Bounds);
            Focus();
        }

        private void ExitNoonSight_Click(object sender, EventArgs e)
        {
            if (InvokedBySightLog == true)
            {
                My.MyProject.Forms.SightLog.FormNoonSightLoaded = false;
                InvokedBySightLog = false;
            }

            Cleanup();
            Close();
        }

        private void Form_Initialize_Renamed()
        {
            Pi = Math.PI;  //4d * Math.Atan(1.0d);
            cboLo.SelectedIndex = 0; // g_LongW
            cboDRL.SelectedIndex = 0; // g_LatN
            txtZDh.BackColor = Control.DefaultBackColor;  //ColorTranslator.FromOle(0x8000000F);
            // txtTime.BackColor = &H8000000F
            cboZDm.SelectedIndex = 0; // "00"
                                      // AriesFlag = False

            // nutation in longitude and obliquity
            ND = new int[] { 0, -2, 0, 0, 0, 0, -2, 0, 0, -2, -2, -2, 0, 2, 0, 2, 0, 0, -2, 0, 2, 0, 0, -2, 0, -2, 0, 0, 2, -2, 0, -2, 0, 0, 2, 2, 0, -2, 0, 2, 2, -2, -2, 2, 2, 0, -2, -2, 0, -2, -2, 0, -1, -2, 1, 0, 0, -1, 0, 0, 2, 0, 2 };
            NM = new int[] { 0, 0, 0, 0, 1, 0, 1, 0, 0, -1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 2, 1, 0, -1, 0, 0, 0, 1, 1, -1, 0, 0, 0, 0, 0, 0, -1, -1, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, -1, 1, -1, -1, 0, -1 };
            NMprime = new int[] { 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 1, 0, -1, 0, 1, -1, -1, 1, 2, -2, 0, 2, 2, 1, 0, 0, -1, 0, -1, 0, 0, 1, 0, 2, -1, 1, 0, 1, 0, 0, 1, 2, 1, -2, 0, 1, 0, 0, 2, 2, 0, 1, 1, 0, 0, 1, -2, 1, 1, 1, -1, 3, 0 };
            NF = new int[] { 0, 2, 2, 0, 0, 0, 2, 2, 2, 2, 0, 2, 2, 0, 0, 2, 0, 2, 0, 2, 2, 2, 0, 2, 2, 2, 2, 0, 0, 2, 0, 0, 0, -2, 2, 2, 2, 0, 2, 2, 0, 2, 2, 0, 0, 0, 2, 0, 2, 0, 2, -2, 0, 0, 0, 2, 2, 0, 0, 2, 2, 2, 2 };
            NOmega = new int[] { 1, 2, 2, 2, 0, 0, 2, 1, 2, 2, 0, 1, 2, 0, 1, 2, 1, 1, 0, 1, 2, 2, 0, 2, 0, 0, 1, 0, 1, 2, 1, 1, 1, 0, 1, 2, 2, 0, 2, 1, 0, 2, 1, 1, 1, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 2, 0, 0, 2, 2, 2, 2 };
            NSin = new int[] { -171996, -13187, -2274, 2062, 1426, 712, -517, -386, -301, 217, -158, 129, 123, 63, 63, -59, -58, -51, 48, 46, -38, -31, 29, 29, 26, -22, 21, 17, 16, -16, -15, -13, -12, 11, -10, -8, 7, -7, -7, -7, 6, 6, 6, -6, -6, 5, -5, -5, -5, 4, 4, 4, -4, -4, -4, 3, -3, -3, -3, -3, -3, -3, -3 };
            NSinT = new int[] { Convert.ToInt32(-174.2), Convert.ToInt32(-1.6), Convert.ToInt32(-0.2), Convert.ToInt32(0.2), Convert.ToInt32(-3.4), Convert.ToInt32(0.1),
                Convert.ToInt32(1.2), Convert.ToInt32(-0.4), 0, Convert.ToInt32(-0.5), 0, Convert.ToInt32(0.1), 0, 0, Convert.ToInt32(0.1), 0, Convert.ToInt32(-0.1), 
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, Convert.ToInt32(-0.1), 0, Convert.ToInt32(0.1), 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            NCos = new int[] { 92025, 5736, 977, -895, 54, -7, 224, 200, 129, -95, 0, -70, -53, 0, -33, 26, 32, 27, 0, -24, 16, 13, 0, -12, 0, 0, -10, 0, -8, 7, 9, 7, 6, 0, 5, 3, -3, 0, 3, 3, 0, -3, -3, 3, 3, 0, 3, 3, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            NCosT = new int[] { Convert.ToInt32(8.9), Convert.ToInt32(-3.1), Convert.ToInt32(-0.5), Convert.ToInt32(0.5), Convert.ToInt32(-0.1), 0, Convert.ToInt32(-0.6), 
                0, Convert.ToInt32(-0.1), Convert.ToInt32(0.3), 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        }

        private void MeridianPicBx_Paint(object sender, PaintEventArgs e)
        {
        }
        
        private void FormNoonSight_Load(object eventSender, EventArgs eventArgs)
        {
            InitLoadComplete = false;
            Form_Initialize_Renamed();
            // Next two lines center form on screen without StartUpPosition so form stays where last positioned despite graphics
            Left = (int)((Screen.PrimaryScreen.Bounds.Width - Width) / 2d);
            Top = (int)((Screen.PrimaryScreen.Bounds.Height - Height) / 2d);
            MonthList = "JanFebMarAprMayJunJulAugSepOctNovDec";
            if (InvokedBySightLog == false)
            {
                DTNoonSight.Value = DateTime.Now;
            }

            EqtTable = new EqTimeRec[1];
            cboLo.SelectedIndex = 0; // g_LongW
            cboDRL.SelectedIndex = 0; // g_LatN
            cboIE.SelectedIndex = 0; // "on the arc"
            cboHE.SelectedIndex = 0; // "ft"
            cboDsUnit.SelectedIndex = 0; // "yards"
            cboTemperature.SelectedIndex = 0; // "F"
            cboPressure.SelectedIndex = 0; // "in Hg"
            Flag = false;
            optDRL.Checked = true;
            NewFormBtn.Checked = true;
            OldFormBtn.Checked = false;
            optHoSRForm.Checked = true;
            optHoParameters.Checked = false;
            // this subroutine recycle the bitmap jpg file name to a newly created, empty filename
            ClearScreen();
            // FormNoonSight NoonSight load event code

            if (My.MyProject.Forms.FavoriteLocations.SharedLocUse.EntryStatus == "Shared")
            {
                BringToFront();
                if (My.MyProject.Forms.FavoriteLocations.CommonYesNoMsgBox("Shared Location data is available - do you want to use it?") == true)
                {
                    {
                        var withBlock = My.MyProject.Forms.FavoriteLocations.SharedLocUse;
                        optDRL.Checked = true;
                        txtDRLDeg.Text = withBlock.DRLatDeg.ToString();
                        txtDRLMin.Text = withBlock.DRLatMin.ToString();
                        if ((withBlock.DRLatNS ?? "") == (CommonGlobals.g_LatN ?? ""))
                        {
                            cboDRL.SelectedIndex = 0;
                        }
                        else
                        {
                            cboDRL.SelectedIndex = 1;
                        }

                        if (withBlock.DST == "X")
                        {
                            chkDST.Checked = true;
                        }
                        else
                        {
                            chkDST.Checked = false;
                        }

                        txtLoDeg.Text = withBlock.DRLongDeg.ToString();
                        txtLoMin.Text = withBlock.DRLongMin.ToString();
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
                                    txtDsDist.Text = withBlock.HorDist.ToString();
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

                        txtHE.Text = withBlock.HE.ToString();
                        cboHE.SelectedIndex = withBlock.HETypeIndex;
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
                    }
                }
            }

            // this refresh of the meridian pic box will force the graphics entity to be loaded into the meridgraphic variable for global use
            MeridianPicBx.Refresh();
            InitLoadComplete = true;
        }

        private void FormNoonSight_FormClosed(object eventSender, FormClosedEventArgs eventArgs)
        {
            Cleanup();
        }

        private void ClearScrBtn_Click(object sender, EventArgs e)
        {
            ClearScreen();
        }

        private void optAzN_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optAzN.Checked)
            {
                if (optDRL.Checked == false)
                {
                    txtDRLDeg.BackColor = SystemColors.ButtonFace;   //ColorTranslator.FromOle(0x8000000F);
                    txtDRLMin.BackColor = SystemColors.ButtonFace;   //ColorTranslator.FromOle(0x8000000F);
                    cboDRL.BackColor = SystemColors.ButtonFace;   //ColorTranslator.FromOle(0x8000000F);
                    txtDRLDeg.Enabled = false;
                    txtDRLMin.Enabled = false;
                    cboDRL.Enabled = false;
                }
            }
        }

        private void optAzS_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optAzS.Checked)
            {
                if (optDRL.Checked == false)
                {
                    txtDRLDeg.BackColor = Control.DefaultBackColor;  //ColorTranslator.FromOle(0x8000000F);
                    txtDRLMin.BackColor = Control.DefaultBackColor;  //ColorTranslator.FromOle(0x8000000F);
                    cboDRL.BackColor = Control.DefaultBackColor;  //ColorTranslator.FromOle(0x8000000F);
                    txtDRLDeg.Enabled = false;
                    txtDRLMin.Enabled = false;
                    cboDRL.Enabled = false;
                }
            }
        }

        private void optHorizonBubble_CheckedChanged(object sender, EventArgs e)
        {
                if (optHorizonBubble.Checked == true)
                {
                    lblHE.Visible = true;
                    txtHE.Visible = true;
                    // txtHE.Enabled = True
                    cboHE.Visible = true;
                    // cboHE.Enabled = True
                    lblDsDist.Visible = true;
                    txtDsDist.Visible = true;
                    // txtDsDist.Enabled = True
                    cboDsUnit.Visible = true;
                    // cboDsUnit.Enabled = True
                    // optCenter.Visible = False
                }

                if (optUpper.Checked == true | optLower.Checked == true)
                {
                    SendMsgBx("Caution:  Improper combination of limb and horizon.");
                }
        }

        private void OldFormBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (InitLoadComplete == false)
                return;
            if (OldFormBtn.Checked)
            {
                if (OldFormBtn.Checked == true)
                {
                    NewFormBtn.Checked = false;
                    ExecNoonSightCmd();
                }
            }
        }

        private void NewFormBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (InitLoadComplete == false)
                return;
            if (NewFormBtn.Checked)
            {
                if (NewFormBtn.Checked == true)
                {
                    OldFormBtn.Checked = false;
                    ExecNoonSightCmd();
                }
            }
        }

        private void optDRL_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (InitLoadComplete == false)
                return;
                if (optDRL.Checked == true)
                {
                    txtDRLDeg.BackColor = Control.DefaultBackColor; 
                    txtDRLMin.BackColor = Control.DefaultBackColor; 
                    cboDRL.BackColor = Control.DefaultBackColor; 
                    txtDRLDeg.Enabled = true;
                    txtDRLMin.Enabled = true;
                    cboDRL.Enabled = true;
                }
        }

        private void optHoSRForm_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optHoSRForm.Checked)
            {
                ExecNoonSightCmd();
                // If cmdNoonSight.Enabled = True Then cmdNoonSight_Click(cmdNoonSight, New System.EventArgs())
            }
        }

        private void optHoParameters_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optHoParameters.Checked)
            {
                ExecNoonSightCmd();
                // If cmdNoonSight.Enabled = True Then cmdNoonSight_Click(cmdNoonSight, New System.EventArgs())
            }
        }

        private void optZDAuto_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            //if (optZDAuto.Checked)
            {
                // ClearScreen()
                ClearTimeTxt();
                // cmdNoonSight.Visible = False
                // OldFormBtn.Visible = False
                // NewFormBtn.Visible = False
                // cmdNoonSight.Enabled = False
                lblN.Visible = false;
                lblS.Visible = false;
                lblZ.Visible = false;
                if (optZDAuto.Checked == true)
                {
                    txtZDh.BackColor = Color.Gray;
                    txtZDh.Enabled = false;
                    lblZDh.Visible = false;
                    cboZDm.Visible = false;
                    // cboZDm.Enabled = False
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
            //if (optZDManual.Checked)
            {
                // ClearScreen()
                ClearTimeTxt();
                cmdNoonSight.Visible = false;
                OldFormBtn.Visible = false;
                NewFormBtn.Visible = false;
                // cmdNoonSight.Enabled = False
                lblN.Visible = false;
                lblS.Visible = false;
                lblZ.Visible = false;
                if (optZDManual.Checked == true)
                {
                    txtZDh.BackColor = Control.DefaultBackColor; 
                    txtZDh.Enabled = true;
                    lblZDh.Visible = true;
                    cboZDm.Visible = true;
                    chkDST.Visible = true;
                    lblZDDST.Visible = true;
                    // cboZDm.Enabled = True
                    lblZDm.Visible = true;
                }
            }
        }

        private void optZDUT_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            //if (optZDUT.Checked )
            {
                // ClearScreen()
                ClearTimeTxt();
                cmdNoonSight.Visible = false;
                OldFormBtn.Visible = false;
                NewFormBtn.Visible = false;
                // cmdNoonSight.Enabled = False
                lblN.Visible = false;
                lblS.Visible = false;
                lblZ.Visible = false;
                if (optZDUT.Checked == true)
                {
                    txtZDh.BackColor = Color.Gray;
                    txtZDh.Enabled = false;
                    lblZDh.Visible = false;
                    cboZDm.Visible = false;
                    // cboZDm.Enabled = True
                    lblZDm.Visible = false;
                    chkDST.Visible = false;
                    lblZDDST.Visible = false;
                    chkDST.CheckState = CheckState.Unchecked;
                    txtZDh.Text = "0";
                }
            }
        }

        private void txtDRLDeg_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtDRLDeg.Text) != 90d)
            {
                txtDRLMin.Enabled = true;
            }

            if (Conversion.Val(txtDRLDeg.Text) == 90d)
            {
                txtDRLMin.Text = "";
                txtDRLMin.Enabled = false;
                txtDRLMin.BackColor = Color.Gray;
                // txtDRLDeg.ForeColor = &H80000008
            }

            txtDRLDeg.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtDRLDeg.Text) > 90d)
            {
                txtDRLDeg.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range", "Input Error", MessageBoxButtons.OK);
            }

            if (Conversion.Val(txtDRLDeg.Text) < 90d)
            {
                // txtDRLMin.ForeColor = &H80000008
                txtDRLMin.BackColor = Control.DefaultBackColor; 
                // txtDRLMin.Text = "  "
            }
        }

        private void txtDRLDeg_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        private void DTNoonSight_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnDisplayEQTData_Click(object sender, EventArgs e)
        {
            BuildEqtTable();
            My.MyProject.Forms.DisplayEQTData.Show();
            return;
        }

        private void txtDRLDeg_Validating(object eventSender, CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtDRLDeg.Text) > 90d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtDRLDeg_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtDRLDeg;
            SelectAllText(ref argTB);
            txtDRLDeg = argTB;
        }

        private void txtDRLMin_TextChanged(object eventSender, EventArgs eventArgs)
        {
            // txtDRLMin.ForeColor = &H80000008
            txtDRLMin.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtDRLMin.Text) > 59.9d)
            {
                txtDRLMin.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range", "Input Error", MessageBoxButtons.OK);
            }
        }

        private void chkDST_CheckedChanged(object sender, EventArgs e)
        {
            // If the txtTime text box is not blank then a LAN needs to be recalculated
            if (!string.IsNullOrEmpty(txtTime.Text))
            {
                cmdLAN.PerformClick();
            }
            // If the LongitudeCalcTxtBx is not blank then a Noon Sight Calc needs to be execute
            if (!string.IsNullOrEmpty(LongitudeCalcTxtBx.Text))
            {
                cmdNoonSight.PerformClick();
            }
        }

        private void txtDRLMin_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        if (Conversions.ToBoolean(Strings.InStr(txtDRLMin.Text, ".")))
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

        private void txtDRLMin_Validating(object eventSender, CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtDRLMin.Text) > 59.9d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtDRLMin_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtDRLMin;
            SelectAllText(ref argTB);
            txtDRLMin = argTB;
        }

        private void txtIESec_TextChanged(object eventSender, EventArgs eventArgs)
        {
            // txtIESec.ForeColor = &H80000008
            txtIESec.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtIESec.Text) > 59d)
            {
                txtIESec.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range", "Input Error", MessageBoxButtons.OK);
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

        private void txtIESec_Validating(object eventSender, CancelEventArgs eventArgs)
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

        private void txtLoDeg_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (InitLoadComplete == false)
                return;
            ClearTimeTxt();
            if (Conversion.Val(txtLoDeg.Text) != 180d)
            {
                txtLoMin.Enabled = true;
            }

            if (Conversion.Val(txtLoDeg.Text) == 180d)
            {
                txtLoMin.Text = "";
                txtLoMin.Enabled = false;
                txtLoMin.BackColor = Color.Gray;
            }

            cmdNoonSight.Visible = false;
            OldFormBtn.Visible = false;
            NewFormBtn.Visible = false;
            // cmdNoonSight.Enabled = False
            lblN.Visible = false;
            lblS.Visible = false;
            lblZ.Visible = false;
            // txtLoDeg.ForeColor = &H80000008
            txtLoDeg.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtLoDeg.Text) > 180d | Conversion.Val(txtLoDeg.Text) == 180d & Conversion.Val(txtLoMin.Text) != 0d)
            {
                txtLoDeg.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range", "Input Error", MessageBoxButtons.OK);
            }

            if (Conversion.Val(txtLoDeg.Text) < 180d)
            {
                // txtLoMin.ForeColor = &H80000008
                txtLoMin.BackColor = Control.DefaultBackColor; 
                // txtLoMin.Text = "    "
            }

            AutoZDCalc();
        }

        private void txtLoDeg_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtLoDeg;
            SelectAllText(ref argTB);
            txtLoDeg = argTB;
        }

        private void txtLoMin_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (InitLoadComplete == false)
                return;
            ClearTimeTxt();
            cmdNoonSight.Visible = false;
            OldFormBtn.Visible = false;
            NewFormBtn.Visible = false;
            // cmdNoonSight.Enabled = False
            lblN.Visible = false;
            lblS.Visible = false;
            lblZ.Visible = false;
            // txtLoMin.ForeColor = &H80000008
            txtLoMin.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtLoMin.Text) > 59.9d)
            {
                txtLoMin.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range", "Input Error", MessageBoxButtons.OK);
            }
            // ClearScreen()

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

        private void txtLoMin_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtLoMin;
            SelectAllText(ref argTB);
            txtLoMin = argTB;
        }
        // Private Sub txtTime_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTime.TextChanged
        // txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        // If Len(txtTime.Text) = 6 And (Val(VB.Left(txtTime.Text, 2)) > 23 Or Val(Mid(txtTime.Text, 3, 2)) > 59 Or Val(Mid(txtTime.Text, 5, 2)) > 59) Then
        // txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
        // ErrorMsgBox("Out of Range", "Input Error", MessageBoxButtons.OK)
        // End If

        // If Flag = False And Len(txtTime.Text) = 6 Then
        // cmdNoonSight.Visible = True
        // OldFormBtn.Visible = True
        // NewFormBtn.Visible = True
        // Exit Sub
        // End If
        // Longitude()
        // AutoZDCalc()

        // If optZDManual.Checked = False Then
        // ZDMan = ZD
        // End If
        // If optZDManual.Checked = True Then
        // ZDMan = System.Math.Abs(Val(txtZDh.Text)) + Val(cboZDm.Text) / 60
        // End If
        // If optZDUT.Checked = True Then
        // ZDMan = 0 'added in V5.4.0
        // End If
        // If VB.Left(txtZDh.Text, 1) = "-" Then
        // ZDMan = -ZDMan
        // ZD = -ZD
        // End If
        // If chkDST.CheckState = 1 Then
        // ZD = ZD - 1
        // ZDMan = ZDMan - 1 ': GHour = GHour - 1
        // End If
        // txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        // TLANObsSec = 3600 * Val(VB.Left(txtTime.Text, 2)) + 60 * Val(Mid(txtTime.Text, 3, 2)) + Val(Mid(txtTime.Text, 5, 2))
        // If Len(txtTime.Text) = 6 And ((chkDST.CheckState = 0 And (TLANObsSec - (ZD - ZDMan) * 3600 < 40408 Or TLANObsSec - (ZD - ZDMan) * 3600 > 45867) _
        // Or (chkDST.CheckState = 1 And (TLANObsSec - (ZD - ZDMan) * 3600 < 44008 Or TLANObsSec - (ZD - ZDMan) * 3600 > 49467)))) Then
        // txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
        // ErrorMsgBox("Out of Range", "Input Error", MessageBoxButtons.OK)
        // cmdNoonSight.Visible = False
        // OldFormBtn.Visible = False
        // NewFormBtn.Visible = False
        // Else

        // End If
        // txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        // cmdNoonSight.Visible = True
        // If Len(txtTime.Text) < 6 Then
        // cmdNoonSight.Visible = False ': cmdNoonSight.Enabled = False
        // OldFormBtn.Visible = False
        // NewFormBtn.Visible = False
        // End If
        // End Sub
        // Private Sub txtTime_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTime.KeyPress
        // Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        // Select Case KeyAscii
        // Case Asc("0") To Asc("9")
        // fnumeral = fnumeral & Chr(KeyAscii)
        // Case Asc(Chr(8))
        // fnumeral = fnumeral & Chr(KeyAscii)
        // Case Else
        // KeyAscii = 0
        // Beep()
        // End Select
        // eventArgs.KeyChar = Chr(KeyAscii)
        // If KeyAscii = 0 Then
        // eventArgs.Handled = True
        // End If
        // End Sub
        // Private Sub txtTime_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtTime.Validating
        // Dim KeepFocus As Boolean = eventArgs.Cancel
        // If Flag = False And Len(txtTime.Text) = 6 Then
        // cmdNoonSight.Visible = True
        // OldFormBtn.Visible = True
        // NewFormBtn.Visible = True
        // GoTo EventExitSub
        // End If
        // If Len(txtTime.Text) = 6 And chkDST.CheckState = 0 And (TLANObsSec - (ZD - ZDMan) * 3600 < 40408 Or TLANObsSec - (ZD - ZDMan) * 3600 > 45867) Then
        // KeepFocus = True ': txtTime.BackColor = &HFF&: ErrorMsgBox "Out of Range": cmdNoonSight.Visible = False
        // End If
        // If Len(txtTime.Text) = 6 And chkDST.CheckState = 1 And (TLANObsSec - (ZD - ZDMan) * 3600 < 44008 Or TLANObsSec - (ZD - ZDMan) * 3600 > 49467) Then
        // KeepFocus = True ': txtTime.BackColor = &HFF&: ErrorMsgBox "Out of Range": cmdNoonSight.Visible = False
        // End If
        // If Len(txtTime.Text) = 0 Then
        // KeepFocus = False
        // End If
        // EventExitSub:
        // eventArgs.Cancel = KeepFocus
        // End Sub
        // Private Sub txtTime_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTime.Enter
        // SelectAllText(txtTime)
        // End Sub
        // Private Sub txtYear_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        // ClearScreen()
        // ClearTimeTxt()
        // cmdNoonSight.Visible = False
        // OldFormBtn.Visible = False
        // NewFormBtn.Visible = False
        // 'cmdNoonSight.Enabled = False
        // lblN.Visible = False
        // lblS.Visible = False
        // lblZ.Visible = False
        // 'txtYear.ForeColor = &H80000008
        // txtYear.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        // If Len(txtYear.Text) = 4 And (Val(txtYear.Text) < 1901 Or Val(txtYear.Text) > 2099) Then
        // txtYear.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
        // ErrorMsgBox("Out of Range", "Input Error", MessageBoxButtons.OK)
        // End If
        // CheckDate()
        // End Sub
        // Private Sub txtYear_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        // SelectAllText(txtYear)
        // End Sub
        private void txtZDh_TextChanged(object eventSender, EventArgs eventArgs)
        {
            // ClearScreen()
            ClearTimeTxt();
            cmdNoonSight.Visible = false;
            OldFormBtn.Visible = false;
            NewFormBtn.Visible = false;
            // cmdNoonSight.Enabled = False
            lblN.Visible = false;
            lblS.Visible = false;
            lblZ.Visible = false;
            if (optZDAuto.Checked == true | optZDUT.Checked == true)
                txtZDh.BackColor = Color.Gray;
            if (optZDManual.Checked == true)
                txtZDh.BackColor = Control.DefaultBackColor; 
            if (optZDManual.Checked == true & (Conversion.Val(txtZDh.Text) < -14 | Conversion.Val(txtZDh.Text) > 12d))
            {
                txtZDh.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range", "Input Error", MessageBoxButtons.OK);
            }
        }

        private void txtZDh_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            short KeyAscii = (short)Strings.Asc(eventArgs.KeyChar);
            ;
            bool bMinusSignAlready = false; // As Boolean

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
                        // If Len(txtZDh.Text) > 0 Then
                        // KeyAscii = 0
                        // Beep
                        // End If
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
                        // If Len(txtZDh.Text) > 0 Then
                        // KeyAscii = 0
                        // Beep
                        // End If

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

        private void txtZDh_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtZDh;
            SelectAllText(ref argTB);
            txtZDh = argTB;
        }
        // Public Sub CheckDate()
        // On Error GoTo ErrorHandler
        // If cboDay.Text = "" Or cboMonth.Text = "" Or txtYear.Text = "" Or Len(txtYear.Text) <> 4 Then
        // Exit Sub
        // Else
        // Dim tempstr As String = (cboMonth.GetItemText(cboMonth.SelectedIndex) + 1).ToString("00")
        // DateOfSight = tempstr & "/" & cboDay.Text & "/" & txtYear.Text
        // DateOfSight = DateValue(DateOfSight).ToString
        // End If
        // Exit Sub
        // ErrorHandler:
        // ErrorMsgBox("Invalid date", "Input Error", MessageBoxButtons.OK)
        // DateError = True
        // Exit Sub
        // End Sub

        public void Longitude()
        {
            // Next line for problem with commas as decimal points in Europe with Favorite Places, etc.
            LoMin = Strings.Replace(txtLoMin.Text, ",", ".");
            Lo = Conversion.Val(txtLoDeg.Text) + Conversion.Val(LoMin) / 60d;
            if (cboLo.Text == "E")
                Lo = -Lo;
        }

        public int Greenwich()
        {
            // Prefix (or suffix) G for Greenwich, UT = Universal Time
            var DayG = new short[13];
            MonthDays = "312831303130313130313031";
            // Check for local leap year
            LocalYear = (short)DTInput.Year;  // Val(txtYear.Text)
            LeapYear = DateTime.IsLeapYear(DTInput.Year);
            if (LeapYear == true)
            {
                MonthDays = "312931303130313130313031";
            }
            else
            {
                MonthDays = "312831303130313130313031";
            }

            MonthNumber = (short)DTInput.Month;
            DayNumber = 0;
            var loopTo = (short)(MonthNumber - 1);
            for (i = 1; i <= loopTo; i++)
                DayNumber = (short)(Conversion.Val(Strings.Mid(MonthDays, 2 * i - 1, 2)) + DayNumber);
            DayNumber = (short)(DayNumber + DTInput.Day);
            ZDinSeconds = 3600 * Math.Sign(ZD) * Math.Abs(ZD);
            UTinSeconds = ZTinSeconds + ZDinSeconds; // ZT is input prior to this routine being called
            var GrDT = DTInput.AddSeconds(ZDinSeconds);
            if (Flag2 == false)
            {
                StarDayNumber = (short)(DayNumber % 3); // added in V5.3.1 - screws up longitude from observed ZT of LAN
                if (StarDayNumber == 1)
                    DayNumber = (short)(DayNumber + 1);
                if (StarDayNumber == 0)
                    DayNumber = (short)(DayNumber - 1);
                UTinSeconds = 43200; // THIS DOES NOT WANT TO BE 43200 IN IandC
            }

            GHour = (short)GrDT.Hour;
            GMinute = GrDT.Minute;
            GSecond = GrDT.Second;
            GYear = (short)GrDT.Year;
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
                GYear = (short)(GYear - 1);
            // Check for leap year at Greenwich
            GLeapYear = DateTime.IsLeapYear(GYear);
            // Days in year
            if (GDayOfYear == 0 & GLeapYear == false)
                GDayOfYear = 365;
            if (GDayOfYear == 0 & GLeapYear == true)
                GDayOfYear = 366;
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
            return Conversions.ToInteger(true);
        }

        public int Julian()
        {
            DecimalDate = GDay + GHour / 24d + GMinute / 1440d + GSecond / 86400.0f;
            DecimalDateHour1 = GDay + GHour / 24d;
            DecimalDateHour2 = GDay + (GHour + 1) / 24d;
            // DecimalDateHour2 = (GDay + 1) + (GHour / 24)
            GYearJ = GYear;
            if (GMonth < 3)
            {
                GYearJ = (short)(GYear - 1);
                GMonth = (short)(GMonth + 12);
            }

            JD = Conversion.Int(365.25d * (GYearJ + 4716)) + Conversion.Int(30.6001d * (GMonth + 1)) + DecimalDate - 1537.5d;
            JDHour1 = Conversion.Int(365.25d * (GYearJ + 4716)) + Conversion.Int(30.6001d * (GMonth + 1)) + DecimalDateHour1 - 1537.5d;
            JDHour2 = Conversion.Int(365.25d * (GYearJ + 4716)) + Conversion.Int(30.6001d * (GMonth + 1)) + DecimalDateHour2 - 1537.5d;
            T = (JD - 2451545d + DeltaT / 86400d) / 36525.0d; // added in V4.7.1
            THour1 = (JDHour1 - 2451545d + DeltaT / 86400d) / 36525.0d;
            THour2 = (JDHour2 - 2451545d + DeltaT / 86400d) / 36525.0d;
            return Conversions.ToInteger(true);
        }

        public int Obliquity()
        {
            // Obliquity of the ecliptic
            OE = 84381.448d - 46.816d * T - 0.00059d * T * T + 0.001813d * T * T * T; // Mean obliquity of ecliptic, arcseconds
            OE = OE / 3600d; // degrees
            OETrue = OE + NO; // degrees
            return Conversions.ToInteger(true);
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

        public int Aries()
        {
            HG = UTinSeconds / 3600d; // : If AriesFlag = True Then HG = GHour
            TP = (JD - 2451545.0d - HG / 24d) / 36525.0d;
            GR = 6.69737456d + 0.000000000000004d + 2400.051336d * TP;
            GR = GR + 0.0000258622d * TP * TP + 1.002737909d * HG;
            GR = GR * 15d; // convert hours to degrees
            GR = GR + NL;
            if (GR >= 360d | GR < 0d)
            {
                GR = GR - Conversion.Int(GR / 360d) * 360d;
            }

            LR = GR - Lo;
            if (LR >= 360d)
            {
                LR = LR - 360d;
            }

            if (LR < 0d)
            {
                LR = LR + 360d;
            }

            if (VM == 60d)
            {
                VM = 0d;
                VD = VD + 1d;
            }

            WD = (short)Conversion.Int(GR);
            WM = (GR - WD) * 60d;
            WM = Conversion.Int(WM * 10d + 0.5d) / 10d;
            if (WM == 60d)
            {
                WM = 0d;
                WD = (short)(WD + 1);
            }

            QD = (short)Conversion.Int(LR);
            QM = (LR - QD) * 60d;
            QM = Conversion.Int(QM * 10d + 0.5d) / 10d;
            if (QM == 60d)
            {
                QM = 0d;
                QD = (short)(QD + 1);
            }

            return Conversions.ToInteger(true);
        }

        public void Sun()
        {
            Ecc = 0.016708634d - 0.000042037d * T - 0.0000001267d * T * T; // Ecc of Earth's orbit
            MS = 357.52911d + 35999.05029d * T - 0.0001537d * T * T; // mean anomaly of Sun, degrees
            if (MS >= 360d | MS < 0d)
            {
                MS = MS - Conversion.Int(MS / 360d) * 360d;
            }
            // center of Sun, degrees
            C = (1.914602d - 0.004817d * T - 0.000014d * T * T) * Math.Sin(MS * Pi / 180d) + (0.019993d - 0.000101d * T) * Math.Sin(2d * MS * Pi / 180d) + 0.000289d * Math.Sin(3d * MS * Pi / 180d);
            NU = MS + C; // Sun's true anomaly, degrees
            RN = 1.000001018d * (1d - Ecc * Ecc) / (1d + Ecc * Math.Cos(NU * Pi / 180d)); // Sun's radius vector (distance between centers of Sun and Earth), astronomical units
            L0 = 280.46646d + 36000.76983d * T + 0.0003032d * T * T; // geometric mean longitude of Sun, degrees
            if (L0 >= 360d | L0 < 0d)
            {
                L0 = L0 - Conversion.Int(L0 / 360d) * 360d;
            }
            // L0 = L0 + NL - 0.005691611 / RN     'add effects of nutation and Aberration
            // If L0 >= 360 Or L0 < 0 Then L0 = L0 - Int(L0 / 360) * 360
            LN = L0 + C; // Sun's true longitude, degrees
            T = T / 10d;
            // Compute heliocentric, ecliptical Longitude L in radians
            L = EarthFunctions.Earth_L01(ref T) + EarthFunctions.Earth_L02(ref T) + EarthFunctions.Earth_L11(ref T) + EarthFunctions.Earth_L21(ref T) + EarthFunctions.Earth_L31(ref T) + EarthFunctions.Earth_L41(ref T) + EarthFunctions.Earth_L51(ref T); // radians
            if (Math.Abs(L) > 2 * Pi)
            {
                L = L - 2 * Pi * Convert.ToInt32(L / 2 / Pi);
            }
            // Compute heliocentric, ecliptical Latitude B in radians
            B = EarthFunctions.Earth_B01(ref T) + EarthFunctions.Earth_B11(ref T) + EarthFunctions.Earth_B21(ref T) + EarthFunctions.Earth_B31(ref T) + EarthFunctions.Earth_B41(ref T); // radians
                                                                                                                                                                                         // Compute heliocentric distance RH in AU
            RH = EarthFunctions.Earth_R01(ref T) + EarthFunctions.Earth_R02(ref T) + EarthFunctions.Earth_R11(ref T) + EarthFunctions.Earth_R21(ref T) + EarthFunctions.Earth_R31(ref T) + EarthFunctions.Earth_R41(ref T) + EarthFunctions.Earth_R51(ref T);
            L1 = L + Pi; // geocentric longitude, radians
            B = -B; // geocentric latitude, radians
            L1 = L1 * 180d / Pi; // geocentric longitude, degrees
                                 // add nutation to get apparent positions
            L1 = L1 + NL; // degrees
                          // add aberration
            L1 = L1 - 20.4898d / 3600d / RH; // apparent longitude, degrees
                                             // back to radians
            L1 = L1 * Pi / 180d;
            EclipticToEquatorial();
            AR = AR * 180d / Pi; // for Meeus ecl-to-eq
            DE = DE * 180d / Pi; // for Meeus ecl-to-eq
            DI = Math.Atan(0.00465424336d / RN) * 180d / Pi * 60d;
            if (optCenter.Checked == true)
                DI = 0d;
            // DI = (959.63 / RN) / 60        'Meeus
            // back to normal T
            // T = 10 * T
        }

        public int GHADec()
        {
            SH = 360d - AR;
            GA = GR - AR;
            if (GA >= 360d | GA < 0d)
            {
                GA = GA - Conversion.Int(GA / 360d) * 360d;
            }

            Flag2 = true;
            Greenwich();
            Delta_T();
            Julian();
            T = THour1;
            JDHour = JDHour1;
            Nutation();
            Obliquity();
            Aries();
            Sun();
            DE1 = DE;
            HourAnglesHour();
            GHAHour1 = GHAHour;
            Greenwich();
            Delta_T();
            Julian();
            T = THour2;
            JDHour = JDHour2;
            Nutation();
            Obliquity();
            Aries();
            Sun();
            DE2 = DE;
            HourAnglesHour();
            GHAHour2 = GHAHour;
            Flag2 = false;
            SunHourChange = GHAHour2 - GHAHour1;
            if (SunHourChange < 0d)
            {
                SunHourChange = SunHourChange + 360d;
            }

            SunGHACorr = (15d - SunHourChange) / 2d;
            GHAHour1 = GHAHour1 - SunGHACorr;
            GA = GHAHour1;
            SH = Conversion.Int(SH * 10d + 0.5d) / 10d;
            GRD = (short)Conversion.Int(AR);
            GRM = (AR - GRD) * 60d;
            GRM = Conversion.Int(GRM * 10d + 0.5d) / 10d;
            RA = Conversion.Int(AR * 10d + 0.5d) / 10d;
            if (DE == 0d)
                HD = " ";
            if (DE > 0d)
                HD = CommonGlobals.g_LatN;
            if (DE < 0d)
                HD = CommonGlobals.g_LatS;
            DF = Conversion.Int(Math.Abs(DE) * 10d + 0.5d) / 10d;
            VD = Conversion.Int(GA);
            VM = (GA - VD) * 60d;
            VM = Conversion.Int(VM * 10d + 0.5d) / 10d;
            return Conversions.ToInteger(true);
        }

        public void AutoZDCalc()
        {
            Lo = Conversion.Val(txtLoDeg.Text) + Conversion.Val(txtLoMin.Text) / 60d;
            ZD = (int)Conversion.Int(Lo / 15d + 0.5d);
            if (cboLo.Text == "E")
                ZD = -ZD;
            if (optZDAuto.Checked == true)
            {
                SignZD = "+";
                if (cboLo.Text == "E")
                {
                    SignZD = "-";
                }

                txtZDh.Text = SignZD + Math.Abs(ZD);
            }

            return;
        }

        public void EclipticToEquatorial()
        {
            AR = Math.Atan((Math.Sin(L1) * Math.Cos(OETrue * Pi / 180d) - Math.Tan(B) * Math.Sin(OETrue * Pi / 180d)) / Math.Cos(L1)); // radians
            if (Math.Cos(L1) < 0d)
                AR = AR + Pi;
            if (AR >= 2d * Pi)
                AR = AR - 2d * Pi;
            if (AR < 0d)
                AR = AR + 2d * Pi;
            x = Math.Sin(B) * Math.Cos(OETrue * Pi / 180d) + Math.Cos(B) * Math.Sin(OETrue * Pi / 180d) * Math.Sin(L1);
            DE = Math.Atan(x / (Math.Sqrt(-x * x + 1d) + 9.999999E-21d)); // arcsin, radians
                                                                          // AR = AR * 180 / Pi
                                                                          // DE = DE * 180 / Pi
            return;
        }

        private void txtDsDist_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

                case (short)('\b'):
                    {
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                case (short)(','):
                    {
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
                ErrorMsgBox("Out of Range", "Input Error", MessageBoxButtons.OK);
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

        private void txtHsDeg_Validating(object eventSender, CancelEventArgs eventArgs)
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
                ErrorMsgBox("Out of Range", "Input Error", MessageBoxButtons.OK);
            }

            if (optHsDMS.Checked == true & Conversion.Val(txtHsMin.Text) > 59d)
            {
                txtHsMin.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range", "Input Error", MessageBoxButtons.OK);
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

        private void txtHsMin_Validating(object eventSender, CancelEventArgs eventArgs)
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
            // txtHsSec.ForeColor = &H80000008
            txtHsSec.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtHsSec.Text) > 59d)
            {
                txtHsSec.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range", "Input Error", MessageBoxButtons.OK);
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

        private void txtHsSec_Validating(object eventSender, CancelEventArgs eventArgs)
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
            // txtIEdeg.ForeColor = &H80000008
            txtIEdeg.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtIEdeg.Text) > 9d)
            {
                txtIEdeg.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range", "Input Error", MessageBoxButtons.OK);
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

        private void txtIEdeg_Validating(object eventSender, CancelEventArgs eventArgs)
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
                ErrorMsgBox("Out of Range", "Input Error", MessageBoxButtons.OK);
            }

            if (optHsDMS.Checked == true & Conversion.Val(txtIEmin.Text) > 59d)
            {
                txtIEmin.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range", "Input Error", MessageBoxButtons.OK);
            }
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

        private void txtIEmin_Validating(object eventSender, CancelEventArgs eventArgs)
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

        private void txtIEmin_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtIEmin;
            SelectAllText(ref argTB);
            txtIEmin = argTB;
        }

        public int AltitudeCorrection()
        {
            if (optHsDMS.Checked == false)
            {
                txtHsSec.Text = "";
                txtIESec.Text = "";
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
                {
                    ICMin = 0d;
                }

                ICinMinutes = (Conversion.Val(txtIEdeg.Text) - 1d) * 60d + ICMin;
            }

            if (cboIE.Text == "off the arc (val.)")
            {
                ICinMinutes = Conversion.Val(txtIEdeg.Text) * 60d + ICMin;
            }

            Corr1 = ICinMinutes - DipCalc();
            Corr1Deg = (short)Conversion.Int(Math.Abs(Corr1 / 60d));
            Corr1Min = Math.Abs(Corr1) - 60 * Corr1Deg;
            hsinMinutes = 60d * Conversion.Val(txtHsDeg.Text) + Conversion.Val(txtHsMin.Text) + Conversion.Val(txtHsSec.Text) / 60d;
            HsMin = Conversion.Val(txtHsMin.Text) + Conversion.Val(txtHsSec.Text) / 60d;
            hainMinutes = hsinMinutes + Corr1;
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
            HP = 60d * Math.Atan(0.0000426349651d / RN) * 180d / Pi; // 0.0000426349651 is radius of Earth in AU, RN is distance between centers of Earth and Sun in AU
            PA = HP * Math.Cos(hainMinutes / 60d * Pi / 180d);
            if (optCenter.Checked == true)
            {
                DI = 0d;
            }

            if (optCenter.Checked == true & optHoSRForm.Checked == true)
            {
                PA = 0d;
            }

            Corr2Min = -r + PA; // R from Refraction
            if (optHoSRForm.Checked & GMonth >= 4 & GMonth <= 9)
            {
                DI = 15.859d;
                PA = 0.145d * Math.Cos(hainMinutes / 60d * Pi / 180d); // average SD 15.859, median 15.9, Gary LaPook 15.95 (used until V5.4.0), Ron Jones 15.8583; 0.145 is average HP'was 15.859 in V4.9.2, now matches SRF      'these five are the new ones
            }

            if (optHoSRForm.Checked & (GMonth < 4 | GMonth > 9))
            {
                DI = 16.1968d;
                PA = 0.148d * Math.Cos(hainMinutes / 60d * Pi / 180d); // average SD 16.195 (used until V5.4.0) corrected to 16.1968, median 16.15, Gary LaPook 16.15, Ron Jones 16.2167; 0.148 is average HP
            }

            if (optLower.Checked == true)
            {
                Corr2Min = Corr2Min + DI;
            }

            if (optUpper.Checked == true)
            {
                Corr2Min = Corr2Min - DI;
            }

            if (optUpper.Checked == true & GYear >= 1954 & GYear <= 1969)
            {
                Corr2Min = Corr2Min - 1.2d; // 1.2' for irradiation
            }

            Main_Renamed = 0d;
            if (optLower.Checked == true)
            {
                Main_Renamed = -Rstd + PA + DI;
            }

            if (optUpper.Checked == true)
            {
                Main_Renamed = -Rstd + PA - DI;
            }

            if (optCenter.Checked == true)
            {
                Main_Renamed = -Rstd;
            }

            HoinMinutes = hainMinutes + Corr2Min; // minutes
            HoDeg = Conversion.Fix(HoinMinutes / 60d); // min to dec. deg.; Fix was Int
            HoMin = Math.Abs(HoinMinutes - 60d * HoDeg);
            if (Conversion.Int(HoMin * 10d + 0.5d) / 10d == 60d)
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

            return Conversions.ToInteger(true);
        }

        public void DisplayNoonSight()
        {
            ClearTextFields();
            if (string.IsNullOrEmpty(txtHE.Text))
            {
                HE = 0d;
            }
            else
            {
                HE = Conversions.ToDouble(txtHE.Text.ToString());
            }

            DisplayLANTime();
            DisplayAltitudeData();
            DisplayLatitudeData();
            DisplayAlmanacData();
            Refresh();
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
                // If GYear <= 2003 And TX = 10 And ((Val(txtPressure.text) = 1010 And cboPressure.text = "mbar") Or (Val(txtPressure.text) = 29.83 And cboPressure.text = "in Hg")) And hainMinutes >= 596 Then
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

                // If GYear >= 2004 And TX = 10 And ((Val(txtPressure.text) = 1010 And cboPressure.text = "mbar") Or (Val(txtPressure.text) = 29.83 And cboPressure.text = "in Hg")) And hainMinutes >= 595 Then
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
                // R = 58.294 * Tan(Pi / 2 - y) - 0.0668 * Tan(Pi / 2 - y) * Tan(Pi / 2 - y) * Tan(Pi / 2 - y): R = 60 * R
                if (GYear <= 2003)
                {
                    r = y + 7.31d / (y + 4.4d);
                }
                // R = R - 0.06 * Sin((14.7 * R / 60) * Pi / 180) 'correction to improve accuracy from 0.07' to 0.015', 2004 or earlier
                else
                {
                    r = y + 7.32d / (y + 4.32d);
                }

                r = r * Pi / 180d;
                r = 1d / Math.Tan(r);
                if (GYear <= 2003)
                    r = r - 0.06d * Math.Sin((14.7d * (r / 60d) + 13d) * Pi / 180d); // correction to improve accuracy from 0.07' to 0.015', 2004 or earlier
                Rstd = r; // added in 5.1.5
            }
            // R = -0.97 * Tan(((y * Pi / 180) - Atn(12 * (y + 3))))   'formula from The Calculator Afloat - better for some values of y (ha)
            // If (GYear <= 2003 And hainMinutes >= 596) Or (GYear >= 2004 And hainMinutes >= 595) Then RstdTP = Rstd Else RstdTP = r   'removed in 5.1.5
            RstdTP = r; // replaced previous line in 5.1.5
                        // End If
            if (r < 0d)
                r = 0d; // This line added to get rid of negative values at very high altitudes under certain circumstances
                        // Rstd = r    'Standard refraction before temperature and pressure applied
            r = r * (283d / 1010d) * PX / (TX + 273d); // PX=1010, TX=10    Total Refraction    Constant was 0.28019802
            Raddl = r - RstdTP;
            // '    Rstd = RstdTP       'to make the proper Main correction print     removed in 5.1.5
            if (GYear <= 2003 & hainMinutes >= 596d | GYear >= 2004 & hainMinutes >= 595d)
                Rstd = RstdA2;
        }

        public double DipCalc()
        {
            double Dip = 0d;
            HE = Conversion.Val(txtHE.Text);
            if (cboHE.Text == "ft")
                HEinFeet = HE;
            if (cboHE.Text == "m ")
                HEinFeet = HE * 3.28095d;
            if (cboHE.Text == "in")
                HEinFeet = HE / 12d;
            if (cboHE.Text == "cm")
                HEinFeet = HE * 0.0328095d;
            if (cboHE.Text == "ft" | cboHE.Text == "m ")
                HE = Conversion.Int(HE * 10d + 0.5d) / 10d;
            if (cboHE.Text == "in")
                HE = Conversion.Int(HE / 12d * 10d + 0.5d) / 10d;
            if (cboHE.Text == "cm")
                HE = Conversion.Int(HE / 100d * 10d + 0.50000001d) / 10d;
            DipShortDist = Conversion.Val(txtDsDist.Text);
            // Convert distance to dip short horizon to nautical miles
            if (cboDsUnit.Text == "feet")
                DipShortDist = DipShortDist / 6076.1d;
            if (cboDsUnit.Text == "yards")
                DipShortDist = DipShortDist * 3d / 6076.1d;
            if (cboDsUnit.Text == "meters")
                DipShortDist = DipShortDist / 1852d;
            if (cboDsUnit.Text == "statute miles")
                DipShortDist = DipShortDist * 5280d / 6076.1d;
            // Check if dip short distance is greater than distance to natural horizon
            if (optHorizonDipShort.Checked == true & DipShortDist > 1.169d * Math.Sqrt(HEinFeet))
            {
                ErrorMsgBox("Dip short distance exceeded distance to natural horizon.  Natural horizon will be used.", "Input Error", MessageBoxButtons.OK);
                optHorizonNatural.Checked = true;
                txtDsDist.Text = "";
            }

            if (optHorizonDipShort.Checked == true)
                Dip = 10800d / Pi * Math.Atan(HEinFeet / (6076.1d * DipShortDist) + 0.8321d * DipShortDist / 6880.2d);
            // Convert C to F
            Temperature = Conversion.Val(txtTemperature.Text);
            if (cboTemperature.Text == "C ")
                Temperature = 5d / 9d * (Temperature - 32d);
            // Convert mbar to in Hg
            Pressure = Conversion.Val(txtPressure.Text);
            if (cboPressure.Text == "mbar")
                Pressure = 33.858532d * Pressure;
            // Calculate dip
            if (optHorizonNatural.Checked == true & (cboHE.Text == "ft" | cboHE.Text == "in"))
            {
                switch (HE)
                {
                    case var @case when @case < 2d:
                        {
                            Dip = 0.7d * HE;
                            break;
                        }

                    case var case1 when case1 <= 3.9d:
                        {
                            Dip = 1.4d + (HE - 2.0d) * 0.25d;
                            break;
                        }

                    case var case2 when case2 <= 5.9d:
                        {
                            Dip = 1.9d + (HE - 4.0d) * 0.25d;
                            break;
                        }

                    case var case3 when case3 <= 7.6d:
                        {
                            Dip = 2.4d + (HE - 6.0d) * 0.15d;
                            break;
                        }

                    case var case4 when case4 >= 7.7d:
                        {
                            Dip = 0.970003d * Math.Sqrt(HE);
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
                            Dip = 1.79d * HE;
                            break;
                        }

                    case var case6 when case6 <= 1.6d:
                        {
                            Dip = 1.79d * Math.Sqrt(HE);
                            break;
                        }

                    case var case7 when case7 >= 1.7d:
                        {
                            Dip = 1.76d * Math.Sqrt(HE);
                            break;
                        }
                }
            }

            Dip = Conversion.Int(Dip * 10d + 0.5d) / 10d;
            return Dip;
        }

        private void optHorizonArtificial_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            {
                if (optHorizonArtificial.Checked == true)
                {
                    lblHE.Visible = false;
                    txtHE.Visible = false;
                    // txtHE.Enabled = False
                    cboHE.Visible = false;
                    // cboHE.Enabled = False
                    lblDsDist.Visible = false;
                    txtDsDist.Visible = false;
                    // txtDsDist.Enabled = False
                    cboDsUnit.Visible = false;
                    // cboDsUnit.Enabled = False
                    // optCenter.Visible = True
                }
            }
        }

        private void optHorizonDipShort_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            {
                if (optHorizonDipShort.Checked == true)
                {
                    lblHE.Visible = true;
                    txtHE.Visible = true;
                    // txtHE.Enabled = True
                    cboHE.Visible = true;
                    // cboHE.Enabled = True
                    lblDsDist.Visible = true;
                    txtDsDist.Visible = true;
                    // txtDsDist.Enabled = True
                    cboDsUnit.Visible = true;
                    // cboDsUnit.Enabled = True
                    // optCenter.Visible = False
                }

                if (optCenter.Checked == true)
                {
                    SendMsgBx("Caution:  Improper combination of limb and horizon.");
                }
            }
        }

        private void optHorizonNatural_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            {
                if (optHorizonNatural.Checked == true)
                {
                    lblHE.Visible = true;
                    txtHE.Visible = true;
                    // txtHE.Enabled = True
                    cboHE.Visible = true;
                    // cboHE.Enabled = True
                    lblDsDist.Visible = false;
                    txtDsDist.Visible = false;
                    // txtDsDist.Enabled = False
                    cboDsUnit.Visible = false;
                    // cboDsUnit.Enabled = False
                    // optCenter.Visible = False
                }

                if (optCenter.Checked == true)
                {
                    SendMsgBx("Caution:  Improper combination of limb and horizon.");
                }
            }
        }

        private void optHsDMm_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            {
                if (optHsDMm.Checked == true)
                {
                    txtHsSec.Visible = false;
                    lblHsSec.Visible = false;
                    // txtHsSec.Enabled = False
                    txtIESec.Visible = false;
                    lblIEsec.Visible = false;
                    // txtIESec.Enabled = False
                    txtHsMin.Text = "";
                    txtIEmin.Text = "";
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
                    // txtHsSec.Enabled = True
                    txtIESec.Visible = true;
                    lblIEsec.Visible = true;
                    // txtIESec.Enabled = True
                    txtHsMin.Text = "";
                    txtIEmin.Text = "";
                    txtHsSec.Text = "";
                    txtIESec.Text = "";
                }
            }
        }

        public int LatCalc()
        {
            // TotDE = TotDecDegrees + TotDecMinutes / 60
            ZenithDistinDeg = ZenithDistDeg + ZenithDistMin / 60d;
            SunAzN = false;
            SunAzS = false;
            if (optAzN.Checked == true)
                SunAzN = true;
            if (optAzS.Checked == true)
                SunAzS = true;
            if (optDRL.Checked == true)
                Latitude();
            if (optDRL.Checked == true & DRL >= TotDE)
                SunAzS = true;
            if (optDRL.Checked == true & DRL < TotDE)
                SunAzN = true;
            if (SunAzN == true & TotDE >= 0d & ZenithDistinDeg < Math.Abs(TotDE))
            {
                Lat = Math.Abs(TotDE) - ZenithDistinDeg;
                LH = CommonGlobals.g_LatN;
                dh = "-";
            }

            if (SunAzN == true & TotDE >= 0d & ZenithDistinDeg >= Math.Abs(TotDE))
            {
                Lat = ZenithDistinDeg - Math.Abs(TotDE);
                LH = CommonGlobals.g_LatS;
                dh = "-";
            }

            if (SunAzN == true & TotDE < 0d)
            {
                Lat = ZenithDistinDeg + Math.Abs(TotDE);
                LH = CommonGlobals.g_LatS;
                dh = "+";
            }

            if (SunAzS == true & TotDE >= 0d)
            {
                Lat = Math.Abs(TotDE) + ZenithDistinDeg;
                LH = CommonGlobals.g_LatN;
                dh = "+";
            }

            if (SunAzS == true & TotDE < 0d & ZenithDistinDeg >= Math.Abs(TotDE))
            {
                Lat = ZenithDistinDeg - Math.Abs(TotDE);
                LH = CommonGlobals.g_LatN;
                dh = "-";
            }

            if (SunAzS == true & TotDE < 0d & ZenithDistinDeg < Math.Abs(TotDE))
            {
                Lat = Math.Abs(TotDE) - ZenithDistinDeg;
                LH = CommonGlobals.g_LatS;
                dh = "-";
            }

            if (Lat == 0d)
                LH = " ";
            // Lat = Abs(Lat)
            if ((LH ?? "") == (CommonGlobals.g_LatS ?? ""))
                Lat = -Lat;
            LDeg = (short)Conversion.Int(Math.Abs(Lat));
            LMin = (Math.Abs(Lat) - LDeg) * 60d;
            if (LMin == 60d)
            {
                LMin = 0d;
                LDeg = (short)(LDeg + +1);
            }

            if (Math.Sign(Lat) == Math.Sign(DRL))
            {
                Ldiff = Math.Abs(Lat - DRL);
            }

            if (Math.Sign(Lat) != Math.Sign(DRL))
            {
                Ldiff = Math.Abs(Lat) + Math.Abs(DRL);
            }

            Ldiff = 60d * Ldiff;
            return Conversions.ToInteger(true);
        }

        private void DisplayAlmanacData()
        {
            DGAlm.Visible = true;
            var AltHdr = new[] { "Category", "Info1" };
            var DataSet1 = new DataSet();
            DataSet1.Tables.Add("Table1");
            DataSet1.DataSetName = "Table1";
            DGAlm.DataSource = DataSet1;
            for (int i = 0, loopTo = Information.UBound(AltHdr); i <= loopTo; i++)
            {
                DataSet1.Tables["Table1"].Columns.Add(AltHdr[i]);
                DataSet1.Tables["Table1"].Columns[i].AllowDBNull = false;
                DataSet1.Tables["Table1"].Columns[i].DefaultValue = "";
            }

            DGAlm.DataSource = DataSet1.Tables[0].DefaultView;
            for (int i = 0, loopTo1 = DGAlm.Columns.Count - 1; i <= loopTo1; i++)
            {
                DGAlm.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DGAlm.Columns[i].MinimumWidth = 104;
                // DGAlm.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGAlm.Columns[i].DefaultCellStyle.Font = new Font("Arial", 8f, FontStyle.Regular);
            }

            DGAlm.ColumnHeadersVisible = false;
            DGAlm.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DGAlm.DefaultCellStyle.Font = new Font("Arial", 8f, FontStyle.Regular);
            DGAlm.DefaultCellStyle.BackColor = Color.LightGray;
            DGAlm.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            DGAlm.DefaultCellStyle.SelectionForeColor = DGLAN.DefaultCellStyle.ForeColor;
            DGAlm.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DGAlm.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DGAlm.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            // DGAlm.Columns(0).MinimumWidth = 85
            // DGAlm.Columns(1).MinimumWidth = 85
            // DGAlm.Columns(1).MinimumWidth = 85

            // Dim tempstr1 As String = ""
            string tempstr2 = "";
            string tempstr3 = "";
            // alamanc text box  formatting - alignment is centered

            AlmanacTxtBx.Text = "ALMANAC - Dec";
            AlmanacTxtBx.TextAlign = HorizontalAlignment.Center;
            tempstr2 = "Dec " + GHour.ToString("00") + Strings.Space(2) + "hr";
            tempstr3 = Math.Abs(DecDegrees).ToString("0") + '°' + DecMinutes.ToString("00.0") + "'";
            if (DE * 60d >= 0.05d)
            {
                tempstr3 += CommonGlobals.g_LatN;
            }

            if (Math.Abs(DE * 60d) < 0.05d)
            {
                tempstr3 += " ";
            }

            if (DE * 60d < 0.05d)
            {
                tempstr3 += CommonGlobals.g_LatS;
            }

            DataSet1.Tables["Table1"].Rows.Add(tempstr2, tempstr3);
            tempstr3 = "";
            tempstr2 = "d (";
            if (Signdvalue == 0)
            {
                tempstr2 += " ) ";
            }
            else if (Signdvalue == 1)
            {
                tempstr2 += " +) ";
            }
            else if (Signdvalue == -1)
            {
                tempstr2 += "-) ";
            }

            tempstr2 += Strings.Space(1) + Math.Abs(dvalue).ToString("0.0") + "'";
            DataSet1.Tables["Table1"].Rows.Add(tempstr2, tempstr3);
            tempstr3 = "";
            tempstr2 = Strings.Space(3) + "d corr (";
            if (Signdvalue == 0)
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

            tempstr3 = Strings.Space(6) + dcorr.ToString("0.0") + "'";
            DataSet1.Tables["Table1"].Rows.Add(tempstr2, tempstr3);
            tempstr2 = "Dec";
            tempstr3 = Math.Abs(TotDecDegrees).ToString("0") + '°' + TotDecMinutes.ToString("00.0") + "'";
            if (TotDE > 0d)
            {
                tempstr3 += CommonGlobals.g_LatN;
            }

            if (TotDE == 0d)
            {
                tempstr3 += " ";
            }

            if (TotDE < 0d)
            {
                tempstr3 += CommonGlobals.g_LatS;
            }

            DataSet1.Tables["Table1"].Rows.Add(tempstr2, tempstr3);
            DataSet1.Dispose();
            DGAlm.ClearSelection();
            DGAlm.CurrentCell = null;
            return;
        }

        private void DisplayLatitudeData()
        {
            DGLat.Visible = true;
            var AltHdr = new[] { "Category", "Info1" };
            var DataSet1 = new DataSet();
            DataSet1.Tables.Add("Table1");
            DataSet1.DataSetName = "Table1";
            DGLat.DataSource = DataSet1;
            for (int i = 0, loopTo = Information.UBound(AltHdr); i <= loopTo; i++)
            {
                DataSet1.Tables["Table1"].Columns.Add(AltHdr[i]);
                DataSet1.Tables["Table1"].Columns[i].AllowDBNull = false;
                DataSet1.Tables["Table1"].Columns[i].DefaultValue = "";
            }

            DGLat.DataSource = DataSet1.Tables[0].DefaultView;
            for (int i = 0, loopTo1 = DGLat.Columns.Count - 1; i <= loopTo1; i++)
            {
                DGLat.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DGLat.Columns[i].MinimumWidth = 114;
                DGLat.Columns[i].DefaultCellStyle.Font = new Font("Arial", 8f, FontStyle.Regular);
            }

            DGLat.ColumnHeadersVisible = false;
            DGLat.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DGLat.DefaultCellStyle.Font = new Font("Arial", 8f, FontStyle.Regular);
            DGLat.DefaultCellStyle.BackColor = Color.LightGray;
            DGLat.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            DGLat.DefaultCellStyle.SelectionForeColor = DGLAN.DefaultCellStyle.ForeColor;
            DGLat.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DGLat.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGLat.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            // DGLat.Columns(1).MinimumWidth = 85

            string tempstr1 = "";
            string tempstr2 = "";

            // Now format Latitude Text Box
            LatitudeTxtBx.ResetText();
            string TextString = "";
            if (OldFormBtn.Checked == true)
            {
                LatitudeTxtBx.Text = "Latitude Computation";
                tempstr1 = "Z ";
                tempstr2 = "89" + '°' + "60.0'";
                DataSet1.Tables["Table1"].Rows.Add(tempstr1, tempstr2);
                tempstr1 = "Ho (-)";
                if (Math.Sign(HoinMinutes) == -1)
                {
                    tempstr2 = "-";
                }

                tempstr2 += Math.Abs(HoDeg).ToString("0") + '°' + HoMin.ToString("00.0") + "'";
                DataSet1.Tables["Table1"].Rows.Add(tempstr1, tempstr2);
                tempstr1 = "z";
                tempstr2 = ZenithDistDeg.ToString("0") + '°' + ZenithDistMin.ToString("00.0") + "'";
                DataSet1.Tables["Table1"].Rows.Add(tempstr1, tempstr2);
                tempstr1 = "Dec (" + dh + ")";
                TextString = TotDecDegrees.ToString("0") + '°' + TotDecMinutes.ToString("00.0") + "'";
                if (TotDE > 0d)
                    TextString += CommonGlobals.g_LatN;
                if (TotDE == 0d)
                    TextString += " ";
                if (TotDE < 0d)
                    TextString += CommonGlobals.g_LatS;
                tempstr2 = TextString;
                TextString = ((int)Constants.vbNull).ToString();
                DataSet1.Tables["Table1"].Rows.Add(tempstr1, tempstr2);
                tempstr1 = "Lat";
                tempstr2 = LDeg.ToString("0") + '°' + LMin.ToString("00.0") + "'" + LH;
                DataSet1.Tables["Table1"].Rows.Add(tempstr1, tempstr2);
                if (optDRL.Checked == true)
                {
                    tempstr1 = "DR Lat";
                    tempstr2 = Conversion.Val(txtDRLDeg.Text).ToString("0") + '°' + Conversion.Val(DRLMin).ToString("00.0") + "'" + cboDRL.Text;
                    DataSet1.Tables["Table1"].Rows.Add(tempstr1, tempstr2);
                }

                if (optDRL.Checked == true)
                {
                    tempstr1 = "l diff";
                    tempstr2 = Strings.Space(4) + Ldiff.ToString("##0.0") + "'";
                    DataSet1.Tables["Table1"].Rows.Add(tempstr1, tempstr2);
                }
            }

            if (NewFormBtn.Checked == true)
            {
                LatitudeTxtBx.Text = "LATITUDE BY MERIDIAN TRANSIT";
                tempstr1 = "90" + '°' + "=";
                tempstr2 = "89" + '°' + "60.0'";
                DataSet1.Tables["Table1"].Rows.Add(tempstr1, tempstr2);
                tempstr1 = "-Ho";
                tempstr2 = Math.Abs(HoDeg).ToString("0") + '°' + HoMin.ToString("00.0") + "'";
                DataSet1.Tables["Table1"].Rows.Add(tempstr1, tempstr2);
                tempstr1 = "Co-Alt=90" + '°' + "-Ho";
                tempstr2 = ZenithDistDeg.ToString("0") + '°' + ZenithDistMin.ToString("00.0") + "'";
                if (TotDE < Lat)
                    tempstr2 += CommonGlobals.g_LatN;
                if (TotDE > Lat)
                    tempstr2 += CommonGlobals.g_LatS;
                if (TotDE == Lat)
                    tempstr2 += " ";
                DataSet1.Tables["Table1"].Rows.Add(tempstr1, tempstr2);
                tempstr1 = "Dec";
                TextString = TotDecDegrees.ToString("0") + '°' + TotDecMinutes.ToString("00.0") + "'";
                if (TotDE > 0d)
                    TextString += CommonGlobals.g_LatN;
                if (TotDE == 0d)
                    TextString += " ";
                if (TotDE < 0d)
                    TextString += CommonGlobals.g_LatS;
                tempstr2 = TextString;
                DataSet1.Tables["Table1"].Rows.Add(tempstr1, tempstr2);
                TextString = ((int)Constants.vbNull).ToString();
                tempstr1 = "L=Dec+Co-Alt";
                tempstr2 = LDeg.ToString("0") + '°' + LMin.ToString("00.0") + "'" + LH;
                DataSet1.Tables["Table1"].Rows.Add(tempstr1, tempstr2);
                if (optDRL.Checked == true)
                {
                    tempstr1 = "DR Lat";
                    tempstr2 = Conversion.Val(txtDRLDeg.Text).ToString("0") + '°' + Conversion.Val(DRLMin).ToString("00.0") + "'" + cboDRL.Text;
                    DataSet1.Tables["Table1"].Rows.Add(tempstr1, tempstr2);
                    tempstr1 = "Diff between L and DR L in nm:";
                    tempstr2 = Ldiff.ToString("##0.0") + " nm";
                    DataSet1.Tables["Table1"].Rows.Add(tempstr1, tempstr2);
                }
            }

            DataSet1.Dispose();
            DGLat.ClearSelection();
            DGLat.CurrentCell = null;
            return;
        }

        private void DisplayAltitudeData()
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
                DGAlt.Columns[i].MinimumWidth = 69;
                DGAlt.Columns[i].DefaultCellStyle.Font = new Font("Arial", 8f, FontStyle.Regular);
            }

            DGAlt.ColumnHeadersVisible = false;
            DGAlt.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DGAlt.DefaultCellStyle.Font = new Font("Arial", 8f, FontStyle.Regular);
            DGAlt.DefaultCellStyle.BackColor = Color.LightGray;
            DGAlt.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            DGAlt.DefaultCellStyle.SelectionForeColor = DGLAN.DefaultCellStyle.ForeColor;
            DGAlt.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DGAlt.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft;
            DGAlt.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
            DGAlt.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;

            // DGAlt.Columns(0).MinimumWidth = 85
            // DGAlt.Columns(1).MinimumWidth = 85
            // DGAlt.Columns(1).MinimumWidth = 85

            string tempstr1 = "";
            string tempstr2 = "";
            string tempstr3 = "";
            AltitudeTxtBx.AppendText("ALTITUDE");
            tempstr1 = "Ht of eye";
            tempstr2 = HE.ToString("0.0");
            if (cboHE.Text.ToString() == "ft" | cboHE.Text == "in")
            {
                tempstr2 += " ft";
            }
            else if (cboHE.Text == "m " | cboHE.Text == "cm")
            {
                tempstr2 += " m";
            }
            else
            {
                tempstr2 += " ft";
            }

            tempstr3 = "";
            DataSet1.Tables["Table1"].Rows.Add(tempstr1, tempstr2, tempstr3);
            tempstr1 = "hs";
            tempstr2 = "";
            tempstr3 = txtHsDeg.Text.ToString().Trim() + '°' + HsMin.ToString("00.0") + "'";
            if (optHsDMS.Checked == true)
            {
                tempstr3 += txtHsSec.Text.ToString().Trim();
            }

            DataSet1.Tables["Table1"].Rows.Add(tempstr1, tempstr2, tempstr3);
            tempstr1 = "   IC";
            tempstr2 = "(";
            if (ICinMinutes == 0d)
            {
                tempstr2 += " ";
            }
            else if (cboIE.Text == "on the arc" & ICinMinutes != 0d)
            {
                tempstr2 += "-";
            }
            else if ((cboIE.Text == "off the arc (rdg.)" | cboIE.Text == "off the arc (val.)") & ICinMinutes != 0d)
            {
                tempstr2 += "+";
            }

            tempstr2 += ")" + Strings.Space(1);
            string TempIEDeg = txtIEdeg.Text.ToString();
            if (string.IsNullOrEmpty(TempIEDeg))
            {
                TempIEDeg = "0";
            }

            tempstr2 += TempIEDeg.ToString();
            tempstr2 += '°' + ICMin.ToString("00.0") + "'";
            tempstr3 = "";
            DataSet1.Tables["Table1"].Rows.Add(tempstr1, tempstr2, tempstr3);
            if (optHorizonArtificial.Checked == false)
            {
                tempstr1 = "   Dip";
                double LcLDip = DipCalc();
                tempstr2 = "(-)" + Strings.Space(7 - LcLDip.ToString().Length) + LcLDip.ToString("##0.0") + "'";
                tempstr3 = "";
                DataSet1.Tables["Table1"].Rows.Add(tempstr1, tempstr2, tempstr3);
            }
            else
            {
                tempstr1 = "";
                tempstr2 = "";
                tempstr3 = "";
            }

            tempstr1 = "      Corr";
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
                tempstr3 = "-";
            }
            else
            {
                tempstr3 = " ";
            }

            tempstr3 += Math.Abs(haDeg).ToString("0").Trim() + '°' + haMin.ToString("00.0") + "'";
            DataSet1.Tables["Table1"].Rows.Add(tempstr1, tempstr2, tempstr3);
            tempstr1 = "";
            tempstr2 = "";
            tempstr3 = "";
            if (optHoSRForm.Checked == true)
            {
                tempstr1 = Strings.Space(3) + "Main";
                tempstr2 = "(";
                if (Main_Renamed > 0d)
                {
                    tempstr2 += "+";
                }

                if (Main_Renamed == 0d)
                {
                    tempstr2 += " ";
                }

                if (Main_Renamed < 0d)
                {
                    tempstr2 += "-";
                }

                tempstr2 += ")" + Strings.Space(3) + (Conversion.Int(Math.Abs(Main_Renamed * 10d) + 0.5d) / 10d).ToString("00.0") + "'";
                tempstr3 = "";
                DataSet1.Tables["Table1"].Rows.Add(tempstr1, tempstr2, tempstr3);
            }

            if (optHoParameters.Checked)
            {
                tempstr1 = Strings.Space(3) + "Refraction";
                tempstr2 = "(-)" + Strings.Space(3) + (Conversion.Int(r * 1000d + 0.5d) / 1000d).ToString("00.000") + "'";
                tempstr3 = "";
                DataSet1.Tables["Table1"].Rows.Add(tempstr1, tempstr2, tempstr3);
            }

            if (optHoSRForm.Checked == true)
            {
                tempstr1 = Strings.Space(3) + "Add'l Ref";
                tempstr2 = "";
                tempstr3 = "";
                if (optStdTPNo.Checked == true & Math.Sign(Raddl) == 1)
                {
                    tempstr2 = "(-)" + Strings.Space(3) + Math.Abs(Raddl).ToString("0.0") + "'";
                }

                if (optStdTPNo.Checked == true & Math.Sign(Raddl) == -1)
                {
                    tempstr2 = "(+)" + Strings.Space(3) + Math.Abs(Raddl).ToString("0.0") + "'";
                }

                if (OptStdTPYes.Checked == true)
                {
                    tempstr2 = "";
                }

                DataSet1.Tables["Table1"].Rows.Add(tempstr1, tempstr2, tempstr3);
            }

            if (optHoParameters.Checked == true)
            {
                tempstr1 = Strings.Space(3) + "Parallax";
                tempstr2 = "(+)" + Strings.Space(3) + PA.ToString("00.000") + "'";
                tempstr3 = "";
                DataSet1.Tables["Table1"].Rows.Add(tempstr1, tempstr2, tempstr3);
            }

            if (optHoParameters.Checked == true & optCenter.Checked == false)
            {
                tempstr1 = Strings.Space(3) + "Semi-diameter";
                tempstr2 = "";
                tempstr3 = "";
                if (optLower.Checked == true)
                {
                    tempstr2 = "(+)";
                }

                if (optUpper.Checked == true)
                {
                    tempstr2 = "(-)";
                }

                tempstr2 += Strings.Space(3) + DI.ToString("00.000") + "'";
                DataSet1.Tables["Table1"].Rows.Add(tempstr1, tempstr2, tempstr3);
            }

            tempstr1 = Strings.Space(6) + "Corr";
            tempstr2 = "(";
            if (Corr2Min > 0d)
            {
                tempstr2 += "+";
            }

            if (Corr2Min == 0d)
            {
                tempstr2 += " ";
            }

            if (Corr2Min < 0d)
            {
                tempstr2 += "-";
            }

            tempstr2 += ")" + Strings.Space(3) + Math.Abs(Corr2Min).ToString("00.0") + "'";
            tempstr3 = "";
            DataSet1.Tables["Table1"].Rows.Add(tempstr1, tempstr2, tempstr3);
            tempstr1 = "Ho";
            tempstr2 = "";
            if (Math.Sign(HoinMinutes) == -1)
            {
                tempstr3 = "-";
            }
            else
            {
                tempstr3 = " ";
            }

            tempstr3 += Math.Abs(HoDeg).ToString("0") + '°' + HoMin.ToString("00.0") + "'";
            DataSet1.Tables["Table1"].Rows.Add(tempstr1, tempstr2, tempstr3);
            tempstr1 = "";
            tempstr2 = "";
            if (optHorizonArtificial.Checked == true)
            {
                tempstr1 = " ha adjusted for artificial horizon";
            }

            if (BackSight == true & optHorizonArtificial.Checked == false)
            {
                tempstr2 = "ha adjusted for back sight";
            }

            if (optHorizonArtificial.Checked == true | BackSight == true)
            {
                DataSet1.Tables["Table1"].Rows.Add(tempstr1, tempstr2, "");
            }

            DataSet1.Dispose();
            DGAlt.ClearSelection();
            DGAlt.CurrentCell = null;
            return;
        }

        public void DisplayLANTime()
        {
            DGLAN.Visible = true;
            var LANHdr = new[] { "Category", "Info" };
            var DataSet1 = new DataSet();
            DataSet1.Tables.Add("Table1");
            DataSet1.DataSetName = "Table1";
            DGLAN.DataSource = DataSet1;
            for (int i = 0, loopTo = Information.UBound(LANHdr); i <= loopTo; i++)
            {
                DataSet1.Tables["Table1"].Columns.Add(LANHdr[i]);
                DataSet1.Tables["Table1"].Columns[i].AllowDBNull = false;
                DataSet1.Tables["Table1"].Columns[i].DefaultValue = "";
            }

            DGLAN.DataSource = DataSet1.Tables[0].DefaultView;
            for (int i = 0, loopTo1 = DGLAN.Columns.Count - 1; i <= loopTo1; i++)
            {
                DGLAN.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DGLAN.Columns[i].DefaultCellStyle.Font = new Font("Arial", 8f, FontStyle.Regular);
            }

            DGLAN.Columns[0].MinimumWidth = 115;
            DGLAN.Columns[1].MinimumWidth = 105;
            DGLAN.ColumnHeadersVisible = false;
            DGLAN.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DGLAN.DefaultCellStyle.Font = new Font("Arial", 8f, FontStyle.Regular);
            DGLAN.DefaultCellStyle.BackColor = Color.LightGray;
            DGLAN.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            DGLAN.DefaultCellStyle.SelectionForeColor = DGLAN.DefaultCellStyle.ForeColor;
            DGLAN.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DGLAN.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DGLAN.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            EqTFactor = CalcEqTFactor();
            EqTimeFactorMin = (int)Conversion.Int(Math.Abs(EqTFactor));
            EqTimeFactorSec = (int)((Math.Abs(EqTFactor) - EqTimeFactorMin) * 60d);
            int Fld1Len = (int)(LANTimeTxtBx.ToString().Length / 2d);
            string TempStr1 = Strings.Space(Fld1Len);
            string TempStr2 = Strings.Space(Fld1Len);
            ZD = (int)Math.Abs(Conversion.Val(txtZDh.Text));
            if (optZDManual.Checked == false)
            {
                ZDMan = ZD;
            }

            if (optZDManual.Checked == true)
            {
                ZDMan = Math.Abs(ZD) + Conversion.Val(cboZDm.Text) / 60d;
            }

            if (Strings.Left(txtZDh.Text, 1) == "-")
            {
                ZDMan = -ZDMan;
                ZD = -ZD;
            }
            // GHour = GHour - 1   'corrects GHour for additional hour added in Greenwich
            if ((int)chkDST.CheckState == 1)
            {
                ZD = ZD - 1;
                ZDMan = ZDMan - 1d; // : GHour = GHour - 1
            }

            // NEED TO DO TEXT ALIGNMENT IF DO NOT WANT LEADING ZEROS ON Lo AND GHA
            if (cboLo.Text == "W")
            {
                LoforLAN = Lo;
            }
            else
            {
                LoforLAN = 360d - Math.Abs(Lo);
            }

            LoforLANDeg = (short)Conversion.Int(LoforLAN);
            LoforLANMin = (LoforLAN - LoforLANDeg) * 60d;
            LoforLANMin = Conversion.Int(LoforLANMin * 10d + 0.5d) / 10d;
            LANTimeTxtBx.Text = "TIME OF LAN";
            if (cboLo.Text == "E")
            {
                TempStr1 = "360" + '°' + " - LoE";
            }
            else
            {
                TempStr1 = "LoW";
            }

            TempStr2 = LoforLANDeg.ToString("##0") + '°' + LoforLANMin.ToString("00.0") + "'";
            DataSet1.Tables["Table1"].Rows.Add(TempStr1, TempStr2);
            TempStr1 = "GHA Sun " + GHourLAN.ToString("00") + " h";
            TempStr2 = GHADeg.ToString("000") + '°' + GHAMin.ToString("00.0") + "'";
            DataSet1.Tables["Table1"].Rows.Add(TempStr1, TempStr2);
            GHADiffDeg = (short)Conversion.Int(GHADiff);
            GHADiffMin = (GHADiff - GHADiffDeg) * 60d;
            GHADiffMin = Conversion.Int(GHADiffMin * 10d + 0.5d) / 10d;
            if (GHADiffMin == 60d)
            {
                GHADiffMin = 0d;
                GHADiffDeg = (short)(GHADiffDeg + 1);
            }

            TempStr1 = "GHA Difference";
            TempStr2 = GHADiffDeg.ToString("##0") + '°' + GHADiffMin.ToString("00.0") + "'";
            DataSet1.Tables["Table1"].Rows.Add(TempStr1, TempStr2);
            FormatZTLAN();
            TempStr1 = "Actual Lo Corr:" + "(mm:ss)";
            TempStr2 = LANMinutes.ToString("00") + ":" + LANSeconds.ToString("00");
            DataSet1.Tables["Table1"].Rows.Add(TempStr1, TempStr2);
            if (cboLo.SelectedItem.ToString() == "W")
            {
                GHourLANDisplay = (short)(ZTofLANHours + ZD);
            }
            else
            {
                GHourLANDisplay = (short)(ZTofLANHours - ZD);
            }

            if (GHourLANDisplay > 24)
            {
                GHourLANDisplay = (short)(GHourLANDisplay - 24);
            }

            if (GHourLANDisplay < 0)
            {
                GHourLANDisplay = (short)(GHourLANDisplay + 24);
            }

            TempStr1 = "UT of LAN";
            TempStr2 = GHourLANDisplay.ToString("00") + "-" + LANMinutes.ToString("00") + "-" + LANSeconds.ToString("00");
            DataSet1.Tables["Table1"].Rows.Add(TempStr1, TempStr2);
            TempStr1 = "ZD" + "(";
            if (optZDManual.Checked == false)
            {
                if (Math.Sign(ZD) == 1) // LANTimeTxtLeft.AppendText
                {
                    TempStr1 += "+";
                }

                if (Math.Sign(ZD) == -1) // LANTimeTxtLeft.AppendText(
                {
                    TempStr1 += "-";
                }

                if (Math.Sign(ZD) == 0)
                {
                    // LANTimeTxtLeft.AppendText
                    TempStr1 += " ";
                }
            }

            if (optZDManual.Checked == true)
            {
                if (Math.Sign(ZDMan) == 1)
                {
                    TempStr1 += "+";
                }

                if (Math.Sign(ZDMan) == -1)
                {
                    TempStr1 += "-";
                }

                if (Math.Sign(ZDMan) == 0)
                {
                    TempStr1 += " ";
                }
            }

            TempStr1 += ")";
            TempStr2 = Strings.Space(3 - Math.Abs(ZD).ToString().Length) + Math.Abs(ZD).ToString("#0"); // Format(Abs(Val(txtZDh.Text)), "00");
            if (optZDManual.Checked == true & cboZDm.Text != "00")
            {
                TempStr2 += "-" + cboZDm.Text;
            }

            if (optZDManual.Checked == true & cboZDm.Text != "00")
            {
                TempStr2 += "      (rev)";
            }
            else
            {
                TempStr2 += "      (rev)";
            }

            DataSet1.Tables["Table1"].Rows.Add(TempStr1, TempStr2);
            // FormatZTLAN()

            TempStr1 = "ZT of LAN";
            TempStr2 = ZTofLANHours.ToString("00") + "-" + ZTofLANMinutes.ToString("00") + "-" + ZTofLANSeconds.ToString("00");
            DataSet1.Tables["Table1"].Rows.Add(TempStr1, TempStr2);
            TempStr1 = "EqTime Factor:" + "(mm:ss)";
            if (EqTFactor < 0d)
            {
                TempStr2 = "-" + EqTimeFactorMin.ToString("00") + ":" + EqTimeFactorSec.ToString("00") + "(mm:ss)";
            }
            else
            {
                TempStr2 = EqTimeFactorMin.ToString("00") + ":" + EqTimeFactorSec.ToString("00");
            }

            DataSet1.Tables["Table1"].Rows.Add(TempStr1, TempStr2);
            DGLAN.Refresh();
            DGLAN.ClearSelection();
            DGLAN.CurrentCell = null;
            DataSet1.Dispose();
            // txtTime.Text = ZTofLANHours.ToString("00") & ":" & ZTofLANMinutes.ToString("00") & ":" & ZTofLANSeconds.ToString("00")
            if (Math.Abs(ZTofLANHours - DTNoonSight.Value.Hour) >= 2)
            {
                txtZTLANWarn.Visible = true;
            }
            else
            {
                txtZTLANWarn.Visible = false;
            }

            return;
        }

        private void txtLoDeg_Validating(object eventSender, CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtLoDeg.Text) > 180d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtLoMin_Validating(object eventSender, CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtLoMin.Text) > 59.9d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtYear_Validating(object eventSender, CancelEventArgs eventArgs)
        {
            // Dim KeepFocus As Boolean = eventArgs.Cancel
            // If Len(txtYear.Text) <> 4 Or Val(txtYear.Text) < 1901 Or Val(txtYear.Text) > 2099 Then
            // KeepFocus = True
            // End If
            // eventArgs.Cancel = KeepFocus
        }

        private void cboDay_Validating(object eventSender, CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            // If Val(txtDay.Text) > 31 Then
            // KeepFocus = True
            // End If
            eventArgs.Cancel = KeepFocus;
        }

        private void txtZDh_Validating(object eventSender, CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtZDh.Text) < -14 | Conversion.Val(txtZDh.Text) > 12d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void optStdTPYes_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (OptStdTPYes.Checked)
            {
                lblTemperature.Visible = false;
                txtTemperature.Visible = false;
                lblTempDeg.Visible = false;
                cboTemperature.Visible = false;
                // cboTemperature.Enabled = False
                lblPressure.Visible = false;
                txtPressure.Visible = false;
                cboPressure.Visible = false;
                // cboPressure.Enabled = False
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
                // cboTemperature.Enabled = True
                lblPressure.Visible = true;
                txtPressure.Visible = true;
                cboPressure.Visible = true;
                // cboPressure.Enabled = True
            }
        }

        private void cboTemperature_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            if (cboTemperature.Text == "F ")
                txtTemperature.Text = "50";
            if (cboTemperature.Text == "C ")
                txtTemperature.Text = "10";
            txtTemperature_TextChanged(txtTemperature, new EventArgs());
        }

        private void cboPressure_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            if (cboPressure.Text == "in Hg")
                txtPressure.Text = "29.83";
            if (cboPressure.Text == "mbar")
                txtPressure.Text = "1010";
            txtPressure_TextChanged(txtPressure, new EventArgs());
        }

        private void txtPressure_TextChanged(object eventSender, EventArgs eventArgs)
        {
            // txtPressure.ForeColor = &H80000008
            txtPressure.BackColor = Control.DefaultBackColor; 
            if (cboPressure.Text == "in Hg" & (Conversion.Val(txtPressure.Text) < 28d | Conversion.Val(txtPressure.Text) > 32d) & Strings.Len(txtPressure.Text) >= 2)
            {
                txtPressure.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("OutofRange", "Input Error", MessageBoxButtons.OK);
            }

            if (cboPressure.Text == "mbar" & (Conversion.Val(txtPressure.Text) < 950d | Conversion.Val(txtPressure.Text) > 1100d) & Strings.Len(txtPressure.Text) >= 4 & optStdTPNo.Checked == true) // optStdTPNo = True added for bug going back to standard
            {
                txtPressure.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("OutofRange", "Input Error", MessageBoxButtons.OK);
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

        private void txtPressure_Validating(object eventSender, CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            // If cboPressure.Text = "in Hg" And (Val(txtPressure.Text) < 26 Or Val(txtPressure.Text) > 32) Then
            // KeepFocus = True
            // End If
            // If cboPressure.Text = "mbar" And (Val(txtPressure.Text) < 950 Or Val(txtPressure.Text) > 1100) Then
            // KeepFocus = True
            // End If
            eventArgs.Cancel = KeepFocus;
        }

        private void txtPressure_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtPressure;
            SelectAllText(ref argTB);
            txtPressure = argTB;
        }

        private void txtTemperature_TextChanged(object eventSender, EventArgs eventArgs)
        {
            // txtTemperature.ForeColor = &H80000008
            txtTemperature.BackColor = Control.DefaultBackColor; 
            if (cboTemperature.Text == "F " & (Conversion.Val(txtTemperature.Text) < -40 | Conversion.Val(txtTemperature.Text) > 130d))
            {
                txtTemperature.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range", "Input Error", MessageBoxButtons.OK);
            }

            if (cboTemperature.Text == "C " & (Conversion.Val(txtTemperature.Text) < -40 | Conversion.Val(txtTemperature.Text) > 55d))
            {
                txtTemperature.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range", "Input Error", MessageBoxButtons.OK);
            }
        }

        private void txtTemperature_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            short KeyAscii = (short)Strings.Asc(eventArgs.KeyChar);
            ;
            // bDecimalPointUsedUp = False
            bool bMinusSignAlready = false;
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
                        // If Len(txtTemperature.Text) > 0 Then
                        // KeyAscii = 0
                        // Beep
                        // End If

                        if (txtTemperature.SelectionStart != 0 | bMinusSignAlready)
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

                case (short)('.'): // only allows one decimal point
                    {
                        if (Conversions.ToBoolean(Strings.InStr(txtTemperature.Text, ".")))
                        {
                            if (KeyAscii == 46)
                            {
                                KeyAscii = 0;
                                Interaction.Beep();
                            }
                            // If bDecimalPointUsedUp Then
                            // KeyAscii = 0
                            // Beep
                            // Else
                            // bDecimalPointUsedUp = True
                            // End If
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

        private void txtTemperature_Validating(object eventSender, CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            // If cboTemperature.Text = "F " And (Val(txtTemperature.Text) < -40 Or Val(txtTemperature.Text) > 130) Then
            // KeepFocus = True
            // End If
            // If cboTemperature.Text = "C " And (Val(txtTemperature.Text) < -40 Or Val(txtTemperature.Text) > 55) Then
            // KeepFocus = True
            // End If
            eventArgs.Cancel = KeepFocus;
        }

        private void txtTemperature_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtTemperature;
            SelectAllText(ref argTB);
            txtTemperature = argTB;
        }

        public void Latitude()
        {
            // Next line for problem with commas as decimal points in Europe with Favorite Places, etc.
            // DRLMin = Replace(txtDRLMin.Text, ",", ".")
            DRLMin = txtDRLMin.Text.ToString().Replace(",", ".");
            DRL = Conversion.Val(txtDRLDeg.Text) + Conversion.Val(DRLMin) / 60d;
            if (cboDRL.Text == "S")
                DRL = -DRL;
        }

        public void DisplayMeridianDiagram()
        {
            float TwoPi, i;
            int lcnt = -10;
            TwoPi = (float)(8d * Math.Atan(1d));
            int DrawWidth = (int)(MeridianPicBx.Width / 2d - 20d);
            bm = new Bitmap(MeridianPicBx.Width, MeridianPicBx.Height);
            meridgraphic = Graphics.FromImage(bm);
            meridgraphic.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            meridgraphic.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            meridgraphic.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            meridgraphic.TranslateTransform((float)(MeridianPicBx.Width / 2d), MeridianPicBx.Height - 10);
            var DPen = new Pen(Color.Black, 1f);
            DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            var ptA = new Point();
            var ptB = new Point();
            if (OldFormBtn.Checked == true)
            {
                lblN.Visible = true;
                lblS.Visible = true;
                lblZ.Visible = true;
                // set up and draw line across bottom of cirle arc
                ptA.X = -DrawWidth;
                ptA.Y = 0;
                ptB.X = DrawWidth;
                ptB.Y = 0;
                meridgraphic.DrawLine(DPen, ptA, ptB);
                // setup and draw verticle Y axis to circle arc
                ptA.X = 0;
                ptA.Y = 0;
                ptB.X = 0;
                ptB.Y = -DrawWidth;
                meridgraphic.DrawLine(DPen, ptA, ptB);
                // setup and draw tick marks on circle arc 
                int DrawFrom = DrawWidth;
                int DrawTo = DrawWidth - 2;
                DrawFrom = DrawWidth;
                DrawTo = DrawWidth - 4;
                var loopTo = -TwoPi / 2f;
                for (i = 0f; -TwoPi / 72f >= 0 ? i <= loopTo : i >= loopTo; i += -TwoPi / 72f)
                {
                    ptA.X = (int)(DrawFrom * Math.Cos(i));
                    ptA.Y = (int)(DrawFrom * Math.Sin(i));
                    ptB.X = (int)(DrawTo * Math.Cos(i));
                    ptB.Y = (int)(DrawTo * Math.Sin(i));
                    meridgraphic.DrawLine(DPen, ptA, ptB);
                }

                DrawFrom = DrawWidth;
                DrawTo = DrawWidth - 6;
                var loopTo1 = -TwoPi / 2f;
                for (i = 0f; -TwoPi / 36f >= 0 ? i <= loopTo1 : i >= loopTo1; i += -TwoPi / 36f)
                {
                    ptA.X = (int)(DrawFrom * Math.Cos(i));
                    ptA.Y = (int)(DrawFrom * Math.Sin(i));
                    ptB.X = (int)(DrawTo * Math.Cos(i));
                    ptB.Y = (int)(DrawTo * Math.Sin(i));
                    meridgraphic.DrawLine(DPen, ptA, ptB);
                }

                meridgraphic.DrawArc(DPen, -DrawWidth, -DrawWidth, DrawWidth * 2, DrawWidth * 2, 0, -180);

                // Equator
                ptA.X = 0;
                ptA.Y = 0;
                ptB.X = (int)(DrawWidth * Math.Cos(-(90d - Lat) * Pi / 180d));
                ptB.Y = (int)(DrawWidth * Math.Sin(-(90d - Lat) * Pi / 180d));
                meridgraphic.DrawLine(DPen, ptA, ptB);
                if (ptB.X > 0)
                {
                    ptB.Y -= 10;
                }
                else
                {
                    ptB.X -= 10;
                    ptB.Y -= 10;
                }

                meridgraphic.DrawString("Q ", new Font("Arial", 7f, FontStyle.Regular), Brushes.Black, ptB);
                if (Math.Sign(Lat) == 1 | Math.Sign(Lat) == 0)
                {
                    ptA.X = 0; // Me.Width / 2
                    ptA.Y = 0;
                    ptB.X = (int)(DrawWidth * Math.Cos((-90 + (-90 + Lat)) * Pi / 180d));
                    ptB.Y = (int)(DrawWidth * Math.Sin((-90 + (-90 + Lat)) * Pi / 180d));
                    DPen.Brush = Brushes.DarkBlue;
                    meridgraphic.DrawLine(DPen, ptA, ptB);
                    DPen.Brush = Brushes.Black;
                    if (ptB.X > 0)
                    {
                        ptB.Y -= 10;
                    }
                    else
                    {
                        ptB.X -= 10;
                        ptB.Y -= 10;
                    }

                    meridgraphic.DrawString("Pn", new Font("Arial", 7f, FontStyle.Regular), Brushes.DarkBlue, ptB);
                }
                // South Pole
                DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                if (Math.Sign(Lat) == -1)
                {
                    DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                    ptA.X = 0; // me.Width / 2
                    ptA.Y = 0;
                    ptB.X = (int)(-DrawWidth * Math.Cos(-90 + (-90 + Lat) * Pi / 180d));
                    ptB.Y = (int)(DrawWidth * Math.Sin(-90 + (-90 + Lat) * Pi / 180d));
                    DPen.Brush = Brushes.DarkBlue;
                    meridgraphic.DrawLine(DPen, ptA, ptB);
                    DPen.Brush = Brushes.Black;
                    if (ptB.X > 0)
                    {
                        ptB.Y -= 10;
                    }
                    else
                    {
                        ptB.X -= 10;
                        ptB.Y -= 10;
                    }

                    meridgraphic.DrawString("Ps", new Font("Arial", 7f, FontStyle.Regular), Brushes.DarkBlue, ptB);
                }
                // Sun
                if (optAzS.Checked == true | optDRL.Checked == true & DRL >= DE)
                {
                    DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                    ptA.X = 0; // Me.Width / 2
                    ptA.Y = 0;
                    ptB.X = (int)(DrawWidth * Math.Cos(-(HoinMinutes / 60d) * Pi / 180d));
                    ptB.Y = (int)(DrawWidth * Math.Sin(-(HoinMinutes / 60d) * Pi / 180d));
                    meridgraphic.DrawLine(DPen, ptA, ptB);
                    DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    if (ptB.X > 0)
                    {
                        ptB.Y -= 10;
                    }
                    else
                    {
                        ptB.X -= 10;
                        ptB.Y -= 10;
                    }

                    meridgraphic.DrawString("O ", new Font("Arial", 7f, FontStyle.Regular), Brushes.Red, ptB);
                }

                if (optAzN.Checked == true | optDRL.Checked == true & DRL < DE)
                {
                    DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                    ptA.X = 0;
                    ptA.Y = 0;
                    ptB.X = (int)(DrawWidth * Math.Cos((-90 - HoinMinutes / 60d) * Pi / 180d));
                    ptB.Y = (int)(DrawWidth * Math.Sin((-90 - HoinMinutes / 60d) * Pi / 180d));
                    DPen.Brush = Brushes.Red;
                    meridgraphic.DrawLine(DPen, ptA, ptB);
                    DPen.Brush = Brushes.Black;
                    DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    if (ptB.X > 0)
                    {
                        ptB.Y -= 10;
                    }
                    else
                    {
                        ptB.X -= 10;
                        ptB.Y -= 10;
                    }

                    meridgraphic.DrawString("O ", new Font("Arial", 7f, FontStyle.Regular), Brushes.Red, ptB);
                }
            }

            if (NewFormBtn.Checked == true)
            {
                lblN.Visible = false;
                lblS.Visible = false;
                lblZ.Visible = false;
                // setup and draw verticle Y axis to circle arc
                ptA.X = 0;
                ptA.Y = 0;
                ptB.X = 0;
                ptB.Y = -100;
                meridgraphic.DrawLine(DPen, ptA, ptB);
                ptA.X = -10;
                ptA.Y = 0;
                ptB.X = +10;
                ptB.Y = 0;
                meridgraphic.DrawLine(DPen, ptA, ptB);
                ptB.X = -40;
                ptB.Y = -4;
                meridgraphic.DrawString("50" + '°' + CommonGlobals.g_LatS, new Font("Arial", 7f, FontStyle.Bold), Brushes.Black, ptB);
                ptA.X = -10;
                ptA.Y = -100;
                ptB.X = +10;
                ptB.Y = -100;
                meridgraphic.DrawLine(DPen, ptA, ptB);
                ptB.X = -40;
                ptB.Y = -106;
                meridgraphic.DrawString("50" + '°' + CommonGlobals.g_LatN, new Font("Arial", 7f, FontStyle.Bold), Brushes.Black, ptB);
                ptA.X = -10;
                ptA.Y = -50;
                ptB.X = +10;
                ptB.Y = -50;
                meridgraphic.DrawLine(DPen, ptA, ptB);
                ptB.X = +15;
                ptB.Y = -54;
                meridgraphic.DrawString("Equator", new Font("Arial", 7f, FontStyle.Regular), Brushes.Black, ptB);
                ptB.X = -25;
                meridgraphic.DrawString("0" + '°', new Font("Arial", 7f, FontStyle.Bold), Brushes.Black, ptB);
                ptA.X = 0;
                ptA.Y = -10;
                ptB.X = +10;
                ptB.Y = -10;
                lcnt = -10;
                while (lcnt > -100)
                {
                    meridgraphic.DrawLine(DPen, ptA, ptB);
                    lcnt += -10;
                    ptA.Y = lcnt;
                    ptB.Y = lcnt;
                    if (lcnt == -50)
                    {
                        lcnt += -10;
                        ptA.Y = lcnt;
                        ptB.Y = lcnt;
                    }
                }

                string LHTemp = cboDRL.Text.ToString().Trim();
                int TotLat = (int)(Convert.ToInt32(txtDRLDeg.Text) + Convert.ToDouble(DRLMin) / 60d);
                // Dim TotLat As Integer = LDeg + LMin / 60
                if ((LHTemp ?? "") == (CommonGlobals.g_LatN ?? ""))
                {
                    TotLat = -TotLat - 50;
                }

                if (string.IsNullOrEmpty(LHTemp))
                {
                    TotLat = -50;
                }

                if ((LHTemp ?? "") == (CommonGlobals.g_LatS ?? ""))
                {
                    TotLat = TotLat - 50;
                }

                ptB.X = +15;
                ptB.Y = TotLat - 4;
                meridgraphic.DrawString("Observer", new Font("Arial", 7f, FontStyle.Regular), Brushes.Black, ptB);
                ptA.X = -25;
                ptA.Y = TotLat;
                ptB.X = -5;
                ptB.Y = TotLat;
                var ArrowPen = new Pen(Color.Blue);
                ArrowPen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                meridgraphic.DrawLine(ArrowPen, ptA, ptB);
                string TempStr1 = "DRLat=" + Conversion.Val(txtDRLDeg.Text).ToString("0") + '°' + Conversion.Val(DRLMin).ToString("00.0") + "'" + cboDRL.Text;
                int TempStrLen1 = TempStr1.Length;
                ptA.X -= TempStrLen1 * 5;
                meridgraphic.DrawString(TempStr1, new Font("Arial", 7f, FontStyle.Regular), Brushes.Blue, ptA);
                int TotDec = (int)(TotDecDegrees + TotDecMinutes / 60d);
                if (TotDE > 0d) // Dec is North
                {
                    TotDec = -TotDec - 50;
                }

                if (TotDE == 0d) // Dec is at equator
                {
                    TotDec = -50;
                }

                if (TotDE < 0d) // dec is South
                {
                    TotDec = TotDec - 50;
                }

                DPen.Color = Color.DarkRed;
                meridgraphic.FillEllipse(DPen.Brush, -2, TotDec - 2, 4, 4);
                meridgraphic.DrawEllipse(DPen, -3, TotDec - 3, 6, 6);
                ptB.X = +15;
                ptB.Y = TotDec - 4;
                meridgraphic.DrawString("Sun", new Font("Arial", 7f, FontStyle.Regular), Brushes.Black, ptB);
                ptA.X = -25;
                ptA.Y = TotDec;
                ptB.X = -5;
                ptB.Y = TotDec;
                meridgraphic.DrawLine(ArrowPen, ptA, ptB);
                string TempStr = "Dec=" + TotDecDegrees.ToString("0") + '°' + TotDecMinutes.ToString("00.0") + "'";
                if (TotDE > 0d)
                    TempStr += CommonGlobals.g_LatN;
                if (TotDE == 0d)
                    TempStr += " ";
                if (TotDE < 0d)
                    TempStr += CommonGlobals.g_LatS;
                int TempStrLen = TempStr.Length;
                ptA.X -= TempStrLen * 5;
                meridgraphic.DrawString(TempStr, new Font("Arial", 7f, FontStyle.Regular), Brushes.Blue, ptA);
                ArrowPen.Dispose();
            }

            DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            if (My.MyProject.Computer.FileSystem.FileExists(BMFname))
            {
                My.MyProject.Computer.FileSystem.DeleteFile(BMFname);
            }

            bm.Save(BMFname);
            MeridianPicBx.Visible = true;
            MeridianPicBx.ImageLocation = BMFname;
            MeridianPicBx.Refresh();
            DPen.Dispose();
        }

        private void IandC()
        {
            // Flag2 = True 'added in V5.4.0 to prevent 120000 from being used in this calculation
            // Greenwich()
            // Flag2 = False

            dvalue = (Math.Abs(DE2) - Math.Abs(DE1)) * 60d;
            Signdvalue = (short)Math.Sign(Math.Abs(DE2) - Math.Abs(DE1));
            // If dvalue < 0.05 Then Signdvalue = 0
            Signdvalue = 1;
            if (Math.Abs(DE2) < Math.Abs(DE1))
            {
                Signdvalue = -1;
            }
            // If Sgn(DE2) <> Sgn(DE1) And Abs(DE2) > Abs(DE1) Then Signdvalue = -Signdvalue
            if (Math.Sign(DE2) != Math.Sign(DE1) & Math.Sign(DE2) != 0 & Math.Sign(DE1) != 0)
            {
                Signdvalue = -1;
            }

            dvalue = Math.Abs(dvalue);
            if (dvalue < 0.05d)
            {
                Signdvalue = 0;
            }

            dvalue = Math.Round((Math.Abs(dvalue) * 10d + 0.5d) / 10d, 1, MidpointRounding.AwayFromZero);
            dcorr = dvalue * (GMinute + 0.5d) / 60d;
            // dcorr = Int((System.Math.Abs(dcorr) * 10 + 0.50000000000001) / 10)
            dcorr = Math.Round(dcorr, 1, MidpointRounding.AwayFromZero);

            // TotDE = DE1 + Signdvalue * dcorr / 60
            TotDE = Math.Sign(DE1) * (Math.Abs(DE1) + Signdvalue * dcorr / 60d);
            if (Conversion.Val(Strings.Left(txtTime.Text, 2)) > ZTofLANHours)
            {
                TotDE = Math.Sign(DE2) * (Math.Abs(DE2) + Signdvalue * dcorr / 60d);
            }

            if (Math.Sign(DE1) != Math.Sign(DE2) & Math.Abs(dcorr - Math.Abs(DE1 * 60d)) >= 0.05d)
                TotDE = DE1 - Signdvalue * dcorr / 60d; // = Sgn(DE1) * (Abs(DE1) - Signdvalue * dcorr / 60)
            TotDecDegrees = (short)Conversion.Int(Math.Abs(TotDE));
            TotDecMinutes = (Math.Abs(TotDE) - TotDecDegrees) * 60d;
            TotDecMinutes = Conversion.Int(TotDecMinutes * 10d + 0.5d) / 10d;
            if (TotDecMinutes == 60d)
            {
                TotDecMinutes = 0d;
                TotDecDegrees = (short)(TotDecDegrees + 1);
            }

            // Flag2 = False 'added in V5.4.0
        }

        public int Delta_T()  // http://eclipse.gsfc.nasa.gov/SEhelp/deltatpoly2004.html
        {
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

            if (GYear >= 2006 & GYear <= 2050)
            {
                Theta = DecYr - 2000f;
                DeltaT = 62.92d + 0.32217d * Theta + 0.005589d * Math.Pow(Theta, 2d);       // V5.6.1 could replace 2050 with 2009
            }
            // Next line NOT added in V5.6.1.  For June 1, 2017, predicted DeltaT value 70.2481, measured DeltaT value 68.8033.  With this change predicted value becomes 68.7579
            // If GYear >= 2010 And GYear <= 2099 Then DeltaT = 66.0699 + (DecYr - 2010) * 0.3604 'DeltaT increasing an average of about 0.36 seconds per year since the beginning of 2010 (66.0699)
            if (GYear >= 2051 & GYear <= 2099)
            {
                DeltaT = -20 + 32d * Math.Pow((DecYr - 1820f) / 100f, 2d) - 0.5628d * (2150f - DecYr);        // NOT removed in V5.6.1
            }

            return Conversions.ToInteger(true);
        }

        public int HourAnglesHour()
        {
            SH = 360d - AR;
            GHAAriesHour = 280.46061837d + 360.98564736629d * (JDHour - 2451545d) + 0.000387933d * T * T - T * T * T / 38710000d; // mean GHA of Aries, degrees
            GHAAriesHour = GHAAriesHour + NL * Math.Cos(OETrue * Pi / 180d); // true GHA of Aries, degrees
            if (GHAAriesHour >= 360d | GHAAriesHour < 0d)
                GHAAriesHour = GHAAriesHour - Conversion.Int(GHAAriesHour / 360d) * 360d;
            GHAHour = SH + GHAAriesHour;
            if (GHAHour >= 360d | GHAHour < 0d)
                GHAHour = GHAHour - Conversion.Int(GHAHour / 360d) * 360d;
            return Conversions.ToInteger(true);
        }

        private void SelectAllText(ref TextBox TB)
        {
            TB.SelectionStart = 0;
            TB.SelectionLength = Strings.Len(TB.Text);
        }

        public void ClearTextFields()
        {
            MeridianPicBx.Visible = false;
            LatitudeTxtBx.Text = "";
            AltitudeTxtBx.Text = "";
            AlmanacTxtBx.Text = "";
            LANTimeTxtBx.Text = "";
            DGAlt.Visible = false;
            DGLAN.Visible = false;
            DGAlm.Visible = false;
            DGLat.Visible = false;
            return;
        }

        public void ClearScreen()
        {
            ClearTextFields();
            MeridianPicBx.Visible = false;
            txtDRLDeg.Clear();
            txtDRLMin.Clear();
            txtLoDeg.Clear();
            txtLoMin.Clear();
            txtHsDeg.Clear();
            txtHsMin.Clear();
            txtHsSec.Clear();
            txtIEdeg.Clear();
            txtIEmin.Clear();
            txtHE.Clear();
            txtDsDist.Clear();
            txtTime.Clear();
            txtCalcHo.Clear();
            if (InvokedBySightLog == false)
            {
                DTNoonSight.Value = DateTime.Now;
            }

            btnDisplayEQTData.Visible = false;
            MeridianPicBx.Refresh();
            Refresh();
        }

        public void Cleanup()
        {
            // CleanOutOldFiles()

            return;
        }

        private void ErrorMsgBox(string ErrMsg, string TitleStr, MessageBoxButtons MsgBtn)
        {
            MessageBox.Show(ErrMsg, TitleStr, MsgBtn, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            return;
        }

        private void optLower_CheckedChanged(object sender, EventArgs e)
        {
            // If Not InitLoadComplete Then Exit Sub
            if (optLower.Checked == true)
            {
                lblHE.Visible = true;
                txtHE.Visible = true;
                cboHE.Visible = true;
                if (optHorizonDipShort.Checked == true)
                {
                    lblDsDist.Visible = true;
                    txtDsDist.Visible = true;
                    cboDsUnit.Visible = true;
                }

                if (optHorizonBubble.Checked == true)
                {
                    SendMsgBx("Caution:  Improper combination of lower limb and bubble horizon.");
                }
            }
        }

        private void optUpper_CheckedChanged(object sender, EventArgs e)
        {
            // If Not InitLoadComplete Then Exit Sub
            if (optUpper.Checked == true)
            {
                lblHE.Visible = true;
                txtHE.Visible = true;
                cboHE.Visible = true;
                if (optHorizonDipShort.Checked == true)
                {
                    lblDsDist.Visible = true;
                    txtDsDist.Visible = true;
                    cboDsUnit.Visible = true;
                }

                if (optHorizonBubble.Checked == true)
                {
                    SendMsgBx("Caution:  Improper combination of upper limb and bubble horizon.");
                }
            }

            return;
        }

        private void optCenter_CheckedChanged(object sender, EventArgs e)
        {
            // If Not InitLoadComplete Then Exit Sub
            if (optCenter.Checked == true)
            {
                lblHE.Visible = false;
                txtHE.Visible = false;
                cboHE.Visible = false;
                if (optHorizonDipShort.Checked == true)
                {
                    lblDsDist.Visible = false;
                    txtDsDist.Visible = false;
                    cboDsUnit.Visible = false;
                }

                if (optHorizonNatural.Checked == true | optHorizonDipShort.Checked == true)
                {
                    SendMsgBx("Caution:  Improper combination of center and natural or dip short horizon.");
                }
            }
        }

        public void SendMsgBx(string SendStr)
        {
            // this subroutine is required because issuing a raw SendMsgBx call also trigger a Paint event for graphic box on form which cannot be handled properly in error conditions
            IssuingSendMsgBx = true;
            MessageBox.Show(SendStr, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            Show();
            return;
        }

        private void ErrorMsgBox(string ErrMsg)
        {
            MessageBox.Show(ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            return;
        }

        private double CalcEqTFactor()
        {
            // this code is based on Ron Jones Celestial Navigation Workbook spreadsheet - Meridian Transit worksheet - Interlocked formula starting in cell P76
            double ToRad = Pi / 180d;
            double ToDeg = 180d / Pi;
            double JC = (JD - 2451545d) / 36525d; // Julian Century
            double MeanOE = 23d + (26d + (21.448d - JC * (46.815d + JC * (0.00059d - JC * 0.001813d))) / 60d) / 60d; // Mean Obliq Ecliptic
            double OECorr = MeanOE + 0.00256d * Math.Cos((125.04d - 1934.136d * JC) * ToRad); // Obliq Corr 
            double Vary = Math.Tan(OECorr / 2d * ToRad) * Math.Tan(OECorr / 2d * ToRad); // Var y factor 
            double GeoMeanLo = 280.46646d + JC * (36000.76983d + JC * 0.0003032d); // Gemoetric Mean Long of Sun
            if (GeoMeanLo > 360d)
            {
                GeoMeanLo = Norm360(GeoMeanLo);
            }

            double GeoMeanAnom = NutM * ToDeg;  // 357.52911 + JC * (359999.05029 - 0.0001537 * JC)  Geometric Mean Anomaly of Sun 
            double Ecc1 = 0.016708634d - JC * (0.000042037d + 0.0001537d * JC); // Eccentricity of Earth  Orbit
            double Fctr1 = Vary * Math.Sin(2d * GeoMeanLo * ToRad);
            double Fctr2 = 2d * Ecc1 * Math.Sin(GeoMeanAnom * ToRad);
            double Fctr3 = 4d * Ecc1 * Vary * Math.Sin(GeoMeanAnom * ToRad) * Math.Cos(2d * GeoMeanLo * ToRad);
            double Fctr4 = 0.5d * Vary * Vary * Math.Sin(4d * GeoMeanLo * ToRad);
            double Fctr5 = 1.25d * Ecc1 * Ecc1 * Math.Sin(2d * GeoMeanAnom * ToRad);
            double EqtMin = 4d * ToDeg * (Fctr1 - Fctr2 + Fctr3 - Fctr4 - Fctr5);
            return EqtMin;
            return default;
        }

        private double Norm360(double DegIn)
        {
            double Tmp1 = Conversion.Int(DegIn / 360d);
            return DegIn - Tmp1 * 360d;
        }

        private double Norm180(double DegIn)
        {
            double Tmp1 = Conversion.Int(DegIn / 180d);
            return DegIn - Tmp1 * 180d;
        }

        private void BuildEqtTable()
        {
            var SaveDate = DTNoonSight.Value;
            int EqtYear = SaveDate.Year;
            int EqtMonth = SaveDate.Month;
            var EqTTemp = new DateTime(EqtYear, 1, 1, 11, 59, 0);
            int EqtLimit = 365;
            string DegStr = Conversions.ToString('°');
            double TmpLat = Convert.ToDouble(txtDRLDeg.Text) + Convert.ToDouble(txtDRLMin.Text) / 60d;
            string LatStr = TmpLat.ToString("00.00000") + cboDRL.Text.ToString().Trim();
            if ((cboDRL.Text.ToString().Trim() ?? "") == (CommonGlobals.g_LatS ?? ""))
            {
                TmpLat = -1 * TmpLat;
            }

            string LatStrFName = txtDRLDeg.Text.ToString() + cboDRL.Text.ToString().Trim();
            double TempLo = Lo;
            if ((cboLo.Text.ToString().Trim() ?? "") == (CommonGlobals.g_LongE ?? ""))
            {
                TempLo = -Lo;
            }

            string LongStr = TempLo.ToString("##0.0000") + cboLo.Text.ToString().Trim();
            string LongStrFName = txtLoDeg.Text.ToString() + cboLo.Text.ToString().Trim();
            if (DateTime.IsLeapYear(EqtYear) == true)
            {
                EqtLimit += 1;
            }

            int EqtIndex = 0;
            Array.Resize(ref EqtTable, 2);
            string FName = "./Graphics/EQTData.csv"; // & LatStrFName & LongStrFName & EqtYear.ToString & ".csv"
            var objWriter = new System.IO.StreamWriter(FName, false);
            objWriter.WriteLine("Lat,Long,EqtDate,LANTime,EqtFactor,SunDecl,CalcHo"); // write header line with column names in it
            while (EqtIndex <= EqtLimit)
            {
                DTInput = EqTTemp;
                LAN();
                GHourLAN = GHour;
                GHourLANDisplay = GHour;
                FormatZTLAN();
                EqtTable[EqtIndex].EqtLat = LatStr;
                EqtTable[EqtIndex].EqtLong = LongStr;
                EqtTable[EqtIndex].EqTimeDate = EqTTemp.ToShortDateString();
                EqtTable[EqtIndex].EqTimeDec = DE.ToString("00.00000");
                EqtTable[EqtIndex].EqTimeFactor = CalcEqTFactor().ToString("00.00000");
                EqtTable[EqtIndex].EqTZTLAN = ZTofLANHours.ToString("00") + ZTofLANMinutes.ToString("00") + ZTofLANSeconds.ToString("00");
                double TempHo = 90d - (TmpLat - DE);
                if ((cboDRL.Text.ToString().Trim() ?? "") == (CommonGlobals.g_LatS ?? ""))
                {
                    TempHo = 180d - TempHo;
                }

                string TempHoStr = TempHo.ToString("##0.0000");
                EqtTable[EqtIndex].EqTimeHo = TempHoStr;
                objWriter.WriteLine(LatStr + "," + LongStr + "," + EqtTable[EqtIndex].EqTimeDate + "," + EqtTable[EqtIndex].EqTZTLAN + "," + EqtTable[EqtIndex].EqTimeFactor + "," + EqtTable[EqtIndex].EqTimeDec + "," + TempHoStr);
                EqtIndex += 1;
                Array.Resize(ref EqtTable, EqtIndex + 1);
                EqTTemp = EqTTemp.AddDays(1d);
            }

            objWriter.Flush();
            objWriter.Close();
            objWriter.Dispose();
            DTNoonSight.Value = SaveDate;
            DTInput = SaveDate;
            return;
        }

        //private void BuildMeridianTransitTable()
        //{
        //    var SaveDate = DTNoonSight.Value;
        //    int EqtYear = SaveDate.Year;
        //    int EqtMonth = SaveDate.Month;
        //    var EqTTemp = new DateTime(SaveDate.Year, SaveDate.Month, SaveDate.Day, ZTofLANHours, ZTofLANMinutes, ZTofLANSeconds);
        //    EqTTemp = EqTTemp.AddHours(-3);
        //    int EqtLimit = 26;
        //    string DegStr = Conversions.ToString('°');
        //    double TmpLat = Convert.ToDouble(txtDRLDeg.Text) + Convert.ToDouble(txtDRLMin.Text) / 60d;
        //    string LatStr = TmpLat.ToString("00.00000") + cboDRL.Text.ToString().Trim();
        //    if ((cboDRL.Text.ToString().Trim() ?? "") == (CommonGlobals.g_LatS ?? ""))
        //    {
        //        TmpLat = -1 * TmpLat;
        //    }

        //    string LatStrFName = txtDRLDeg.Text.ToString() + cboDRL.Text.ToString().Trim();
        //    double TempLo = Lo;
        //    if ((cboLo.Text.ToString().Trim() ?? "") == (CommonGlobals.g_LongE ?? ""))
        //    {
        //        TempLo = -Lo;
        //    }

        //    string LongStr = TempLo.ToString("##0.0000") + cboLo.Text.ToString().Trim();
        //    string LongStrFName = txtLoDeg.Text.ToString() + cboLo.Text.ToString().Trim();
        //    if (DateTime.IsLeapYear(EqtYear) == true)
        //    {
        //        EqtLimit += 1;
        //    }

        //    int EqtIndex = 0;
        //    Array.Resize(ref MTTable, 2);
        //    string FName = "./Graphics/MeridianTransitData.csv"; // & LatStrFName & LongStrFName & EqtYear.ToString & ".csv"
        //    var objWriter = new System.IO.StreamWriter(FName, false);
        //    objWriter.WriteLine("Lat,Long,MTDate,LANTime,EqtFactor,SunDecl,CalcHo"); // write header line with column names in it
        //                                                                             // Dim SaveHSDeg As String = txtHsDeg.Text
        //                                                                             // Dim SaveHSMin As String = txtHsMin.Text
        //    var SaveDT = DTNoonSight.Value;
        //    string SaveTxtTime = txtTime.Text;
        //    while (EqtIndex <= EqtLimit)
        //    {
        //        DTInput = EqTTemp;
        //        DTNoonSight.Value = EqTTemp;
        //        txtTime.Text = EqTTemp.ToString("HH:mm:ss");
        //        CalcHoForMT();
        //        MTTable[EqtIndex].EqtLat = LatStr;
        //        MTTable[EqtIndex].EqtLong = LongStr;
        //        MTTable[EqtIndex].EqTimeDate = EqTTemp.ToShortDateString();
        //        MTTable[EqtIndex].EqTimeDec = DE.ToString("00.00000");
        //        MTTable[EqtIndex].EqTimeFactor = EqTFactor.ToString("00.00000"); // CalcEqTFactor().ToString("00.00000")
        //        MTTable[EqtIndex].EqTZTLAN = EqTTemp.ToString("HHmmss"); // ZTofLANHours.ToString("00") & ZTofLANMinutes.ToString("00") & ZTofLANSeconds.ToString("00")
        //        TmpLat = Convert.ToDouble(txtDRLDeg.Text) + Convert.ToDouble(txtDRLMin.Text) / 60d;
        //        // If cboDRL.Items(cboDRL.SelectedIndex).ToString = g_LatS Then
        //        if ((cboDRL.Text.ToString().Trim() ?? "") == (CommonGlobals.g_LatS ?? ""))
        //        {
        //            TmpLat = -1 * TmpLat;
        //        }

        //        double TempHo = 90d - (TmpLat - DE);
        //        if ((cboDRL.Text.ToString().Trim() ?? "") == (CommonGlobals.g_LatS ?? ""))
        //        {
        //            TempHo = 180d - TempHo;
        //        }

        //        int TempHoDeg = (int)Conversion.Int(TempHo);
        //        double TempHoMin = (TempHo - TempHoDeg) * 60d;
        //        string TempHoStr = TempHoDeg.ToString("#0") + '°' + " " + TempHoMin.ToString("#0.0") + "'";
        //        MTTable[EqtIndex].EqTimeHo = TempHoStr;
        //        objWriter.WriteLine(LatStr + "," + LongStr + "," + MTTable[EqtIndex].EqTimeDate + "," + MTTable[EqtIndex].EqTZTLAN + "," + MTTable[EqtIndex].EqTimeFactor + "," + MTTable[EqtIndex].EqTimeDec + "," + TempHoStr);
        //        EqtIndex += 1;
        //        Array.Resize(ref MTTable, EqtIndex + 1);
        //        EqTTemp = EqTTemp.AddMinutes(15d);
        //    }

        //    txtTime.Text = SaveTxtTime;
        //    objWriter.Flush();
        //    objWriter.Close();
        //    objWriter.Dispose();
        //    DTNoonSight.Value = SaveDate;
        //    DTInput = SaveDate;
        //    return;
        //}

        //private void CalcHoForMT()
        //{
        //    ZDinSeconds = (int)(3600 * Math.Sign(ZD) * Conversion.Int(Lo / 15d)); // goes back to normal ZD without (Lo + 1) correction in Greenwich
        //                                                                          // ZTinSeconds = 3600 * Val(VB.Left(txtTime.Text, 2)) + 60 * Val(Mid(txtTime.Text, 3, 2)) + Val(VB.Right(txtTime.Text, 2))
        //    ZTinSeconds = (int)(3600 * DTInput.Hour + 60 * DTInput.Minute + DTInput.Second - (ZD - ZDMan) * 3600d);
        //    UTinSeconds = ZTinSeconds + (ZDinSeconds - ZDManinSeconds);
        //    if ((int)chkDST.CheckState == 1)
        //    {
        //        UTinSeconds = UTinSeconds - 3600;
        //    }

        //    GHADec();
        //    IandC();
        //    AltitudeCorrection();
        //    return;
        //}

        private void FormatZTLAN()
        {
            GHADiffDeg = (short)Conversion.Int(GHADiff);
            GHADiffMin = (GHADiff - GHADiffDeg) * 60d;
            GHADiffMin = Conversion.Int(GHADiffMin * 10d + 0.5d) / 10d;
            if (GHADiffMin == 60d)
            {
                GHADiffMin = 0d;
                GHADiffDeg = (short)(GHADiffDeg + 1);
            }

            // LANTime = 4 * (GHADiffDeg + GHADiffMin / 60) 'LANTime is a bad name
            LANTime = 4d * (GHADiffDeg + GHADiffMin / 60d); // LANTime is a bad name
            LANMinutes = (short)Conversion.Int(LANTime);
            LANSeconds = (short)Conversion.Int((LANTime - LANMinutes) * 60d + 0.5d);
            while (LANMinutes > 60)
            {
                GHourLANDisplay = (short)(GHourLANDisplay + 1);
                LANMinutes = (short)(LANMinutes - 60);
            }

            ZTofLAN = (3600 * GHourLANDisplay + 60 * LANMinutes + LANSeconds - 3600 * ZD) / 3600d;
            if (ZTofLAN < 0d)
            {
                ZTofLAN = ZTofLAN + 24d;
            }

            if (ZTofLAN >= 24d)
            {
                ZTofLAN = ZTofLAN - 24d;
            }

            if (optZDManual.Checked == true)
            {
                ZTofLAN = (3600 * GHourLAN + 60 * LANMinutes + LANSeconds - 3600d * ZDMan) / 3600d; // Int(Lo / 15 + 0.5) is AutoZD
            }

            ZTofLANHours = (short)Conversion.Int(ZTofLAN);
            ZTofLANMinutes = (short)Conversion.Int((ZTofLAN - ZTofLANHours) * 3600d / 60d);
            ZTofLANSeconds = (short)((ZTofLAN - ZTofLANHours) * 3600d - ZTofLANMinutes * 60);
            if (ZTofLANSeconds >= 60)
            {
                ZTofLANSeconds = (short)(ZTofLANSeconds - 60);
                ZTofLANMinutes = (short)(ZTofLANMinutes + 1);
            }

            if (ZTofLANMinutes >= 60)
            {
                ZTofLANMinutes = (short)(ZTofLANMinutes - 60);
                ZTofLANHours = (short)(ZTofLANHours + 1);
            }

            return;
        }
    }
}