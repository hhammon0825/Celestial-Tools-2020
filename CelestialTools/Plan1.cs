using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows;
using System.Windows.Forms;
using VB = Microsoft.VisualBasic;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    internal partial class FormSightPlan : Form
    {

        // Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Integer)
        // Private Heart As Char = ChrW(&H2665)
        // Private SmileyFace As Char = Char.ConvertFromUtf32(&H1F600) ' this does not work
        public bool IsMouseDown = false;
        private short i;
        private short k;
        public double[] PMRA, RAStars, DecStars, PMDec;
        private short GYearJ;
        private double JD;
        private double[] SH = new double[58];
        private double[] GA = new double[58];
        private double[] RA = new double[58];
        private string[] Body;
        private string[] Magnitude;
        private string[] Mag = new string[64];
        private int BN;
        private string[] HD = new string[58];
        private double[] DF = new double[58];    // Integer
        private string[] C3 = new string[11];
        private string[] D3 = new string[11];
        private string fnumeral;
        private short j;
        private double H;
        private double T0;
        private string C30;
        private double ZN, PZ, ZN1;
        private string[] Body1 = new string[28];
        private string[] Mag1 = new string[28];
        private double[] Z1 = new double[28];
        private double TZ, TH;
        private string TB, TM;
        private double[] Z2 = new double[35];
        private string[] Body2 = new string[35];
        private string[] Mag2 = new string[35];
        private double[] H2A = new double[35];
        private double[] Z3 = new double[7];
        private string[] Body3 = new string[7];
        private string[] Mag3 = new string[7];
        private double[] H3A = new double[7];
        private bool bShowToolTips;
        private double q, CP;
        private int[] GRD = new int[58];
        private double[] GRM = new double[58];   // Integer 'Not sure about (57)
        private short IC;
        private double CT, Lat, Pi, DE, TA;
        private double V, AR, Lo, ZD, GR, T1, N1;
        private double HG, C2, TP;
        // Private N2, NT, X3 As String
        private int IB;
        private double[] VM = new double[58];    // Integer
        private int[] VD = new int[58];
        private double[] H1A = new double[28];
        private double NO, NL, LR;
        private short WD, QD;
        private float MV;
        private double WM, QM;
        private string MonthatG, SignZD, DateOfSight;
        private string[] MonthList;
        private double DeltaT;
        private float DecYr, Theta; // Tdelta As Double, Theta As Double
        private string MonthDays;
        private short MonthNumber, LocalYear, DayNumber;
        private int ZDinSeconds;
        private int GMinute, ZTinSeconds, UTinSeconds, GSecond;
        private short GHour;
        private short GMonth, GYear, GDayOfYear, GDay;
        private bool GLeapYear, LeapYear;
        private double A, DecimalDate, T;
        private double OE, C, OETrue;
        private short I2, I3;
        private double B, MS;
        private double RN, LN, NU;
        private double x, y;
        private double M, SQ;
        private short P;
        private double N, NY;
        private short KK0, I1, KK, IJ;
        private double KKFull, Ho;
        private double D, L1, E;
        private double L0;    // also had SM as Double
        private int SM;
        private short LowAz, HighAz;
        private double[] Z1Temp = new double[28];
        private double[] Z2Temp = new double[35];
        private double[] Z3Temp = new double[7];
        private double RotateX, ShiftX, AutoZD, ShiftAz, RotateY;
        private float rad;
        private bool View;
        private int[] DMHelper = new int[71], RSHelper = new int[71], RDHelper = new int[71], RMHelper = new int[71], DDHelper = new int[71], DSHelper = new int[71];
        private double[] MagHelper = new double[71];
        private int DMHelper1, RSHelper1, RDHelper1, RMHelper1, DDHelper1, DSHelper1;
        private double[] MagH1 = new double[71];
        private int[] ZH1 = new int[71];
        private double[] MagH2 = new double[71];
        private int[] ZH2 = new int[71];
        private double[] MagH3 = new double[71];
        private int[] ZH3 = new int[71];
        private double[] MagH4 = new double[71];
        private int[] ZH4 = new int[71];
        private int[] HH1A = new int[71];
        private int[] HH2A = new int[71];
        private int[] HH3A = new int[71];
        private int[] HH4A = new int[71];
        private int NumberOfHelpers;
        private bool DateError, BlankTimeFlag;
        private int[] ZH1Temp = new int[71];
        private int[] ZH2Temp = new int[71];
        private int[] ZH3Temp = new int[71];
        private int[] ZH4Temp = new int[71];
        private bool TempThird, TempFirst, TempSecond, AzTest;
        private int StartTime, EndTime;
        private bool SunMoon;
        private float HoSun, ZNSun, ZNMoon, HoMoon;
        private double FirstTime, LastTime;
        private bool FT;
        private short LastTimeHours, FirstTimeHours, FirstTimeMinutes, LastTimeMinutes;
        private string LTHours, FTHours, FTMinutes, LTMinutes;
        private float MoonPhaseFirst, MoonPhaseLast;
        private short ZNDiff; // , MoonPhase$
        private float ZNAmpSR, ZNSS, ZNSR, WhichWay, ZNAmpSS;
        private double Amp, ZNAmp; // , ZNAmpString$
        private double r;
        private double[,] MMoon = new double[4, 4];
        private double A0, Z1Moon, Z, D0;
        private short M8, W8; // , HP As Double, DI As Double
        private double PMoon, SMoon, Z0, L5, TMoon, CMoon, L0Moon;
        private double C0Moon;
        private double K1, V2Moon, A2Moon, F1, F0, F2, D2Moon, T0Moon, L2;
        private double D1Moon, H2Moon, H0Moon, H1Moon, H3Moon, V0Moon;
        private double D7, H7, EMoon, AMoon, BMoon, M3, N7, A7;
        private double T3;
        private string T3String; // , A7String$
        private double NMoon, FMoon, LMoon, R5, A5, D5, MMMoon, DMoon, GMoon;
        private short PrintCount;
        private double KK1, WMoon, VMoon, UMoon, V1Moon, KK2;
        private bool MoonFlag, TwilightFlag; // , DSTFlag As Boolean
        private float SweepStep2, SweepStep3;
        private float XTB3, XTB2, XTB1, YTB1, YTB2, YTB3;
        private float XTB7, XTB6, XTB5, XTB4, YTB4, YTB5, YTB6, YTB7;
        private float XTB11, XTB10, XTB9, XTB8, YTB8, YTB9, YTB10, YTB11;
        private float XTB15, XTB14, XTB13, XTB12, YTB12, YTB13, YTB14, YTB15;
        private float XTB16, YTB16; // , XTB17 As Single, YTB17 As Single, XTB18 As Single, YTB18 As Single, XTB19 As Single, YTB19 As Single
        private short C36, C34, C32, Time, C33, C35, C37;
        private double NutF, NutM, NutD, NutMprime, NutOmega;
        private int[] NCos, NSin, NF, NM, ND, NMprime, NOmega;
        private double[] NSinT, NCosT;
        private double LH, Ecc, HP; // , L0Sun As Double              'HP in Moon - not needed
        private int[] MSinA, MMprimeA, MDA, MMA, MFA, MCosA;
        private int[] MFB = new int[71], MMB = new int[71], MDB = new int[71], MMprimeB = new int[71], MSinB = new int[71];
        private double A2, MF, MM, MLprime, MD, MMprime, A1, A3;
        private double r0, KB, Delta, SigmaR, SigmaL, SigmaB, KA, B0, Tau;
        private double Pre2, AberrDec, NutDec, PhaseAngle, NutRA, AberrRA, Pre1, Pre3;
        private double cosi, AberrB, PeriLo, AberrL, L, xmag;
        private bool BodiesFlag;
        private string LMin, LoMin;
        private Bitmap bm;
        private string BMFname = "./Graphics/PlanForm.jpg";
        private Graphics Plan1graphic;
        // Private DrawWidth As Integer
        private Pen DPen;
        private System.Windows.Point ptA = new System.Windows.Point();
        private System.Windows.Point ptB = new System.Windows.Point();
        private bool FormSightPlanLoaded = false;
        private bool DisplayInitialView = true;
        private bool PhaseFlag;        // V5.4.1
        private bool FlagSRSS;         // V5.6.2
        public bool IssuingSendMsgBx = false;

        public struct BodyInfo
        {
            public string BodyName;
            public System.Windows.Point BodyLoc;
            public int BodyLocSz;
            public string BodyAlt;
            public string BodyAz;
        }

        private BodyInfo[] VwBody1;
        private BodyInfo[] VwBody2;
        private BodyInfo[] VwBody3;

        private void chkDST_CheckedChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTime.Text)) // The TxtTime field gets formatted when the cmdTwiLights button has been clicked already. chkDst being set before that time does not invoke button click
            {
                cmdTwilights.PerformClick();
            }
        }

        private void cboLineWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!FormSightPlanLoaded)
                return;
            DisplaySunRiseSunSet();
            return;
        }

        private void chkNoonSightLAN_CheckedChanged(object sender, EventArgs e)
        {
            if (!FormSightPlanLoaded)
                return;
            if (chkNoonSightLAN.Checked)
            {
                txtLAN.Visible = true;
                GetLANtime();
            }
            else
            {
                txtLAN.Text = "";
                txtLAN.Visible = false;
            }
        }

        private void DGMag1_SelectionChanged(object sender, EventArgs e)
        {
            DGMag1.ClearSelection();
            return;
        }

        private void DGMag3_SelectionChanged(object sender, EventArgs e)
        {
            DGMag3.ClearSelection();
            return;
        }

        private void DGMag2_SelectionChanged(object sender, EventArgs e)
        {
            DGMag2.ClearSelection();
            return;
        }

        private void DTPlan_ValueChanged(object sender, EventArgs e)
        {
            // If DTPlan.Value.IsDaylightSavingTime = True Then
            // chkDST.Checked = True
            // End If
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.OpenForms.OfType<FormNoonSight>().Any())
            {
                My.MyProject.Forms.FormNoonSight.ExitNoonSight.PerformClick();
            }

            Close();
        }

        private void Plan1TabCntl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!FormSightPlanLoaded)
                return;
            SelectTabToDisplay();
            return;
        }

        public void SelectTabToDisplay()
        {
            Plan1TabCntl.Visible = true;
            txtTime.Text = DTPlan.Value.Hour.ToString("00") + DTPlan.Value.Minute.ToString("00");
            lblLineWidth.Visible = false;
            cboLineWidth.Visible = false;
            cboLineWidth.Enabled = false;
            switch (Plan1TabCntl.SelectedIndex)
            {
                case 0:
                    {
                        ListVisibleBodies();
                        break;
                    }

                case 1:
                    {
                        ViewVisibleBodies();
                        break;
                    }

                case 2:
                    {
                        StarFinder();
                        break;
                    }

                case 3:
                    {
                        lblLineWidth.Visible = true;
                        cboLineWidth.Visible = true;
                        cboLineWidth.Enabled = true;
                        DisplaySunRiseSunSet();
                        break;
                    }

                default:
                    {
                        ListVisibleBodies();
                        break;
                    }
            }

            Plan1TabCntl.SelectedTab.Show();
            return;
        }

        private void SkyPicBx_MouseDown(object sender, MouseEventArgs e)
        {
            DisplayAzAltText(new System.Windows.Point(e.Location.X, e.Location.Y));
        }

        private void SkyPicBx_MouseUp(object sender, MouseEventArgs e)
        {
            lblAlt.Text = "";
            lblAz.Text = "";
            lblBodyName.Text = "";
        }

        private void SkyPicBx_MouseMove(object sender, MouseEventArgs e)
        {
            DisplayAzAltText(new System.Windows.Point(e.Location.X, e.Location.Y));
        }

        private void SkyPicBx_MouseEnter(object sender, EventArgs e)
        {
            lblAlt.Text = "";
            lblAz.Text = "";
            lblBodyName.Text = "";
        }

        private void SkyPicBx_MouseLeave(object sender, EventArgs e)
        {
            lblAlt.Text = "";
            lblAz.Text = "";
            lblBodyName.Text = "";
        }

        private void Calculate()
        {
            ZTinSeconds = 3600 * DTPlan.Value.Hour + 60 * DTPlan.Value.Minute;
            Greenwich(DTPlan.Value);
            Delta_T();
            Julian();
            Obliquity();
            Nutation();
            Aries();
            NY = (JD - 2451545.0d) / 365.2425d;
            SolarSystem();
            Stars1();
            Sorting();
            BN = 0;
            Helpers();
        }

        private void chkLimit_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            if (!FormSightPlanLoaded)
                return;
            BlankTimeFlag = false;
            ExecCmdTwilights();
            ViewVisibleBodies();
            return;
        }

        private void chkMoon_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            if (!FormSightPlanLoaded)
                return;
            ExecCmdTwilights();
            SelectTabToDisplay();
            return;
        }

        private void cmdCW_MouseDown(object sender, MouseEventArgs e)
        {
            int RotIncr = Convert.ToInt32(RotateIncr.SelectedItem);
            WhichWay = (float)(RotIncr * Pi / 180d);
            IsMouseDown = true;
            BestBodies();
        }

        private void cmdCCW_MouseDown(object sender, MouseEventArgs e)
        {
            int RotIncr = Convert.ToInt32(RotateIncr.SelectedItem);
            WhichWay = (float)(-RotIncr * Pi / 180d);
            IsMouseDown = true;
            BestBodies();
        }

        private void ResetRotateBtn_Click(object sender, EventArgs e)
        {
            SweepStep2 = 0f;
            SweepStep3 = 0f;
            RotateIncr.SelectedIndex = 1;
            DisplayView();
            return;
        }

        private void cmdCCW_MouseUp(object eventSender, MouseEventArgs eventArgs)
        {
            IsMouseDown = false;
            // System.Windows.Forms.Application.DoEvents()
        }

        private void cmdCW_MouseUp(object eventSender, MouseEventArgs eventArgs)
        {
            IsMouseDown = false;
            // System.Windows.Forms.Application.DoEvents()
        }

        private void SunRiseSet_Paint(object sender, PaintEventArgs e)
        {
            return;
        }

        private void SkyPicBx_Paint(object sender, PaintEventArgs e)
        {
            if (!FormSightPlanLoaded)
                return;
            if (IssuingSendMsgBx == true)
            {
                IssuingSendMsgBx = false;
                return;
            }
            // SaveDisplayBMFname()

            if (My.MyProject.Computer.FileSystem.FileExists(BMFname))
            {
                SkyPicBx.Load(BMFname);
            }
            else
            {
                System.IO.File.Create(BMFname);
                SendMsgBx("Fatal Error: Error loading" + BMFname + " filename - Restarting default display no data", MessageBoxIcon.Hand);
                DisplayInitialView = true;
                DisplayView();
                DisplayInitialView = false;
            }

            return;
        }

        public void StarFinder()
        {
            if (!FormSightPlanLoaded)
                return;
            BodiesFlag = true;
            View = false;
            BlankTimeFlag = false;
            DateError = false;
            CheckDate();
            Warning();
            StarMagnitudes();
            Calculate();
            DisplayData();
            BodiesFlag = false;
        }

        private void SunMoonFix()
        {
            SunMoon = true;
            FirstTime = 0d;
            LastTime = 0d;
            FT = false;
            LowAz = (short)Conversion.Val(txtLowAz.Text);
            HighAz = (short)Conversion.Val(txtHighAz.Text);
            // Convert sunrise time to minutes (and round up to nearest five?)
            StartTime = (int)((60d * Conversion.Val(Strings.Left(C3[4], 2)) + Conversion.Val(Strings.Right(C3[4], 2))) * 60d);
            EndTime = (int)((60d * Conversion.Val(Strings.Left(C3[5], 2)) + Conversion.Val(Strings.Right(C3[5], 2))) * 60d);
            // Increment in five minute intervals (300 seconds)
            var loopTo = EndTime;
            for (ZTinSeconds = StartTime; ZTinSeconds <= loopTo; ZTinSeconds += 300)
            {
                var TSTmp = TimeSpan.FromSeconds(ZTinSeconds);
                var DTTmp = new DateTime(DTPlan.Value.Year, DTPlan.Value.Month, DTPlan.Value.Day, TSTmp.Hours, TSTmp.Minutes, TSTmp.Seconds);
                Greenwich(DTTmp);
                Delta_T();
                Julian();
                Obliquity();
                Nutation();
                Aries();
                NY = (JD - 2451545.0d) / 365.2425d;
                BN = 58;
                Sun();
                AltAz();
                ZNSun = (float)ZN;
                HoSun = (float)Ho;
                Moon();
                MoonPhase();
                AltAz();
                ZNMoon = (float)ZN;
                HoMoon = (float)Ho;
                ZNDiff = (short)Math.Abs(ZNSun - ZNMoon);
                if (ZNDiff > 180)
                {
                    ZNDiff = (short)(ZNDiff - 180);
                }

                if (FT == false & HoSun >= Conversion.Val(txtMinimumAltitude.Text) & HoMoon >= Conversion.Val(txtMinimumAltitude.Text) & ZNDiff >= 45 & ZNDiff <= 135 & ZNSun >= LowAz & ZNSun <= HighAz & ZNMoon >= LowAz & ZNMoon <= HighAz)
                {
                    FirstTime = ZTinSeconds;
                    MoonPhaseFirst = KK;
                    FT = true; // And HoSun > 0 And HoMoon > 0 not needed since already determined in AltAz
                }

                if (HoSun >= Conversion.Val(txtMinimumAltitude.Text) & HoMoon >= Conversion.Val(txtMinimumAltitude.Text) & ZNDiff >= 45 & ZNDiff <= 135 & ZNSun >= LowAz & ZNSun <= HighAz & ZNMoon >= LowAz & ZNMoon <= HighAz)
                {
                    LastTime = ZTinSeconds;
                    MoonPhaseLast = KK; // ZTinSeconds = EndTime 'HoSun > 0 And HoMoon > 0 And not needed since already determined in AltAz
                }
            }

            var TSFT = TimeSpan.FromSeconds(FirstTime);
            if (TSFT.Seconds >= 30)
            {
                var tmpTS = new TimeSpan(0, 1, 0);
                TSFT = TSFT.Add(tmpTS);
            }

            FirstTimeHours = (short)TSFT.Hours;
            FirstTimeMinutes = (short)TSFT.Minutes;
            // FirstTime = FirstTime / 3600 'hours
            // FirstTimeHours = Int(FirstTime)
            // rstTimeMinutes = Int((FirstTime - FirstTimeHours) * 60 + 0.5) 'rounded to nearest minute
            FTHours = FirstTimeHours.ToString("00");
            FTMinutes = FirstTimeMinutes.ToString("00");
            var TSLT = TimeSpan.FromSeconds(LastTime);
            if (TSLT.Seconds >= 30)
            {
                var tmpTS = new TimeSpan(0, 1, 0);
                TSLT = TSLT.Add(tmpTS);
            }

            LastTimeHours = (short)TSLT.Hours;
            LastTimeMinutes = (short)TSLT.Minutes;

            // LastTime = LastTime / 3600
            // LastTimeHours = Int(LastTime)
            // LastTimeMinutes = Int((LastTime - LastTimeHours) * 60 + 0.5) 'rounded to nearest minute
            LTHours = LastTimeHours.ToString("00");
            LTMinutes = LastTimeMinutes.ToString("00");
        }

        private void MoonData()
        {
            MoonTxtBx.Clear();
            MoonTxtBxRight.Clear();
            DateError = false;
            CheckDate();
            ZTinSeconds = 0; // Changing this does not seem to change anything
            LatLong();
            L5 = -Lo / 360d;
            Z0 = ZD / 24d;
            // If chkMoon.Checked = True Then L5 = 0 : Z0 = 0 'added in V5.3.0
            MoonFlag = true;
            var DTTmp = new DateTime(DTPlan.Value.Year, DTPlan.Value.Month, DTPlan.Value.Day, 0, 0, 0);
            Greenwich(DTTmp);     // THIS LINE WAS MAKING EAST LONGITUDE RISE And SET TIMES WRONG!!!!!Removed in 5.1.3        NO - NEEDED. PUT BACK IN v5.4.1
            GDay = (short)DTPlan.Value.Day; // Val(cboDay.Text) 'was not in 3.1.0
            GHour = 0;
            GMinute = 0;
            GSecond = 0;
            Julian();
            TMoon = JD - 2451545d; // 3.1.0 had +FF
            MoonFlag = false;
            LST();
            TMoon = TMoon + Z0;
            // POSITION LOOP
            for (i = 1; i <= 3; i++)
            {
                FundamentalArguments();
                MMoon[i, 1] = A5;
                MMoon[i, 2] = D5;
                MMoon[i, 3] = R5;
                TMoon = TMoon + 0.5d;
            }

            if (MMoon[2, 1] > MMoon[1, 1])
                goto Line85;
            MMoon[2, 1] = MMoon[2, 1] + 2d * Pi;
        Line85:
            ;
            if (MMoon[3, 1] > MMoon[2, 1])
                goto Line95;
            MMoon[3, 1] = MMoon[3, 1] + 2d * Pi;
        Line95:
            ;
            Z1Moon = Pi / 180d * (90.567d - 41.685d / MMoon[2, 3]);
            SMoon = Math.Sin(Lat * Pi / 180d);
            CMoon = Math.Cos(Lat * Pi / 180d);
            Z = Math.Cos(Z1Moon);
            M8 = 0;
            W8 = 0;
            A0 = MMoon[1, 1];
            D0 = MMoon[1, 2];
            PrintCount = 0;
            for (C0Moon = 0d; C0Moon <= 23d; C0Moon += 1d)
            {
                PMoon = (C0Moon + 1d) / 24d;
                F0 = MMoon[1, 1];
                F1 = MMoon[2, 1];
                F2 = MMoon[3, 1];
                ThreePointInterpolation();
                A2Moon = FMoon;
                F0 = MMoon[1, 2];
                F1 = MMoon[2, 2];
                F2 = MMoon[3, 2];
                ThreePointInterpolation();
                D2Moon = FMoon;
                MoonPosition();
                A0 = A2Moon;
                D0 = D2Moon;
                V0Moon = V2Moon;
            }
            // If DSTFlag = False Then SpecialMessages   'eliminated "If DSTFlag=False Then" in V2.7.3
            SpecialMessages();

            // Added next three lines in V5.1.3 so Moon phase shown for 1200 ZT instead of 0000 ZT, corrected in V5.4.1
            var DTTmp1 = new DateTime(DTPlan.Value.Year, DTPlan.Value.Month, DTPlan.Value.Day, 12, 0, 0);
            Greenwich(DTTmp1);
            GDay = (short)DTPlan.Value.Day;
            PhaseFlag = true;
            GHour = (short)(12d + ZD);
            GMinute = 0;
            GSecond = 0;
            Julian();
            // TMoon = JD - 2451545
            // PhaseFlag = False

            Moon();
            MoonPhase();
            KK1 = KKFull;
            T = T + 0.00000001d; // approx. 32 seconds (to determine if waxing or waning?)         was 0.00001 in 3.1.0
            Moon();
            MoonPhase();
            KK2 = KKFull;
            KK0 = (short)Conversion.Int(KK1 * 100d + 0.5d);
            MoonTxtBxRight.SelectionAlignment = (System.Windows.Forms.HorizontalAlignment)System.Windows.HorizontalAlignment.Right;
            MoonTxtBxRight.AppendText("Moon " + KK0 + "% illuminated, ");
            if (KK2 < KK1)
            {
                MoonTxtBxRight.AppendText("waning" + "  ");
            }
            else
            {
                MoonTxtBxRight.AppendText("waxing" + "  ");
            }

            return;
        }

        private void MoonPhase()
        {
            // lowest accuracy version
            PhaseAngle = 180d - MD * 180d / Pi - 6.289d * Math.Sin(MMprime) + 2.1d * Math.Sin(MM) - 1.274d * Math.Sin(2d * MD - MMprime) - 0.658d * Math.Sin(2d * MD) - 0.214d * Math.Sin(2d * MMprime) - 0.11d * Math.Sin(MD); // degrees
            KKFull = (1d + Math.Cos(PhaseAngle * Pi / 180d)) / 2d;
            KK = (short)Conversion.Int(KKFull * 100d + 0.5d);
            return;
        }

        private void LST()
        {
            // LST at 0h zone time
            T0Moon = TMoon / 36525.0d;
            SMoon = 24110.5d + 8640184.813d * T0Moon;
            SMoon = SMoon + 86636.6d * Z0 + 86400.0d * L5;
            SMoon = SMoon / 86400.0d;
            SMoon = SMoon - Conversion.Int(SMoon);
            T0Moon = SMoon * 360d * Pi / 180d;
            return;
        }

        private void ThreePointInterpolation()
        {
            AMoon = F1 - F0;
            BMoon = F2 - F1 - AMoon;
            FMoon = F0 + PMoon * (2d * AMoon + BMoon * (2d * PMoon - 1d));
            return;
        }

        private void SpecialMessages()
        {
            if (M8 == 0 & W8 == 0)
            {
                goto Line475;
            }

            if (M8 == 0)
            {
                MoonTxtBx.AppendText("No moonrise this Date." + Strings.Space(4));
            }

            if (W8 == 0)
            {
                MoonTxtBx.AppendText("No moonset  this Date." + Strings.Space(4));
            }

            return;
        Line475:
            ;
            if (V2Moon < 0d)
            {
                MoonTxtBx.AppendText("Moon down all day." + Strings.Space(4));
            }

            if (V2Moon > 0d)
            {
                MoonTxtBx.AppendText("Moon up all day." + Strings.Space(4));
            }

            return;
        }

        private void FundamentalArguments()
        {
            LMoon = 0.606434d + 0.03660110129d * TMoon;
            MMMoon = 0.374897d + 0.03629164709d * TMoon;
            FMoon = 0.259091d + 0.0367481952d * TMoon;
            DMoon = 0.827362d + 0.03386319198d * TMoon;
            NMoon = 0.347343d - 0.00014709391d * TMoon;
            GMoon = 0.993126d + 0.0027377785d * TMoon;
            LMoon = LMoon - Conversion.Int(LMoon);
            MMMoon = MMMoon - Conversion.Int(MMMoon);
            FMoon = FMoon - Conversion.Int(FMoon);
            DMoon = DMoon - Conversion.Int(DMoon);
            NMoon = NMoon - Conversion.Int(NMoon);
            GMoon = GMoon - Conversion.Int(GMoon);
            LMoon = LMoon * 2d * Pi;
            MMMoon = MMMoon * 2d * Pi;
            FMoon = FMoon * 2d * Pi;
            DMoon = DMoon * 2d * Pi;
            NMoon = NMoon * 2d * Pi;
            GMoon = GMoon * 2d * Pi;
            VMoon = 0.39558d * Math.Sin(FMoon + NMoon) + 0.082d * Math.Sin(FMoon) + 0.03257d * Math.Sin(MMMoon - FMoon - NMoon) + 0.01092d * Math.Sin(MMMoon + FMoon + NMoon) + 0.00666d * Math.Sin(MMMoon - FMoon) - 0.00644d * Math.Sin(MMMoon + FMoon - 2d * DMoon + NMoon);
            VMoon = VMoon - 0.00331d * Math.Sin(FMoon - 2d * DMoon + NMoon) - 0.00304d * Math.Sin(FMoon - 2d * DMoon) - 0.0024d * Math.Sin(MMMoon - FMoon - 2d * DMoon - NMoon) + 0.00226d * Math.Sin(MMMoon + FMoon) - 0.00108d * Math.Sin(MMMoon + FMoon - 2d * DMoon);
            VMoon = VMoon - 0.00079d * Math.Sin(FMoon - NMoon) + 0.00078d * Math.Sin(FMoon + 2d * DMoon + NMoon);
            UMoon = 1d - 0.10828d * Math.Cos(MMMoon) - 0.0188d * Math.Cos(MMMoon - 2d * DMoon) - 0.01479d * Math.Cos(2d * DMoon) + 0.00181d * Math.Cos(2d * MMMoon - 2d * DMoon) - 0.00147d * Math.Cos(2d * MMMoon);
            UMoon = UMoon - 0.00105d * Math.Cos(2d * DMoon - GMoon) - 0.00075d * Math.Cos(MMMoon - 2d * DMoon + GMoon);
            WMoon = 0.10478d * Math.Sin(MMMoon) - 0.04105d * Math.Sin(2d * FMoon + 2d * NMoon) - 0.0213d * Math.Sin(MMMoon - 2d * DMoon) - 0.01779d * Math.Sin(2d * FMoon + NMoon) + 0.01774d * Math.Sin(NMoon);
            WMoon = WMoon + 0.00987d * Math.Sin(2d * DMoon) - 0.00338d * Math.Sin(MMMoon - 2d * FMoon - 2d * NMoon) - 0.00309d * Math.Sin(GMoon) - 0.0019d * Math.Sin(2d * FMoon) - 0.00144d * Math.Sin(MMMoon + NMoon);
            WMoon = WMoon - 0.00144d * Math.Sin(MMMoon - 2d * FMoon - NMoon) - 0.00113d * Math.Sin(MMMoon + 2d * FMoon + 2d * NMoon) - 0.00094d * Math.Sin(MMMoon - 2d * DMoon + GMoon) - 0.00092d * Math.Sin(2d * MMMoon - 2d * DMoon);
            // COMPUTE RA, DEC, DIST
            SMoon = WMoon / Math.Sqrt(UMoon - VMoon * VMoon);
            A5 = LMoon + Math.Atan(SMoon / Math.Sqrt(1d - SMoon * SMoon));
            SMoon = VMoon / Math.Sqrt(UMoon);
            D5 = Math.Atan(SMoon / Math.Sqrt(1d - SMoon * SMoon));
            R5 = 60.40974d * Math.Sqrt(UMoon);
            return;
        }

        private void MoonPosition()
        {
            K1 = 15d * (Pi / 180d) * 1.0027379d;
            L0Moon = T0Moon + C0Moon * K1;
            L2 = L0Moon + K1;
            if (A2Moon < A0)
            {
                A2Moon = A2Moon + 2d * Pi;
            }

            H0Moon = L0Moon - A0;
            H2Moon = L2 - A2Moon;
            H1Moon = (H2Moon + H0Moon) / 2d; // HOUR ANGLE
            D1Moon = (D2Moon + D0) / 2d; // DEC
            if (C0Moon > 0d)
            {
                goto Line325;
            }

            V0Moon = SMoon * Math.Sin(D0) + CMoon * Math.Cos(D0) * Math.Cos(H0Moon) - Z;
        Line325:
            ;
            V2Moon = SMoon * Math.Sin(D2Moon) + CMoon * Math.Cos(D2Moon) * Math.Cos(H2Moon) - Z;
            if (Math.Sign(V0Moon) == Math.Sign(V2Moon))
            {
                return;
            }

            V1Moon = SMoon * Math.Sin(D1Moon) + CMoon * Math.Cos(D1Moon) * Math.Cos(H1Moon) - Z;
            AMoon = 2d * V2Moon - 4d * V1Moon + 2d * V0Moon;
            BMoon = 4d * V1Moon - 3d * V0Moon - V2Moon;
            DMoon = BMoon * BMoon - 4d * AMoon * V0Moon;
            if (DMoon < 0d)
            {
                return;
            }

            DMoon = Math.Sqrt(DMoon);
            if (V0Moon < 0d & V2Moon > 0d)
            {
                MoonTxtBx.AppendText("Moonrise at ZT ");
                M8 = 1;
            }

            if (V0Moon > 0d & V2Moon < 0d)
            {
                MoonTxtBx.AppendText("Moonset  at ZT ");
                W8 = 1;
            }

            EMoon = (-BMoon + DMoon) / (2d * AMoon);
            if (EMoon > 1d | EMoon < 0d)
            {
                EMoon = (-BMoon - DMoon) / (2d * AMoon);
            }

            T3 = C0Moon + EMoon + 1d / 120d; // ROUND OFF, tried eliminating 1/120 in V2.7.3, sometimes better, sometimes worse
            var TS = TimeSpan.FromHours(T3);
            H3Moon = TS.Hours;
            M3 = TS.Minutes;
            if (chkDST.Checked == true & TwilightFlag == false)
            {
                H3Moon += 1d;
            }

            T3String = H3Moon.ToString("00") + M3.ToString("00");

            // H3Moon = Int(CDbl(T3))
            // M3 = Int((T3 - H3Moon) * 60)
            // T3 = H3Moon * 100 + M3
            // If chkMoon.Checked = True Then
            // T3 = T3 - Int((ZD * 15 - Lo) * 4 + 0.5) 'added in V5.3.0
            // End If
            // If CDbl(VB.Right(Str(T3), 2)) >= 60 Then
            // T3 = T3 + 40 'added in V5.3.0 - prevents times like 1060
            // End If
            // T3String = Str(10000 + T3)
            // If chkDST.Checked = True And TwilightFlag = False Then
            // T3String = Str(10100 + T3)
            // End If
            // T3String = VB.Right(T3String, 4)

            MoonTxtBx.AppendText(T3String);
            // Print(T3String)
            H7 = H0Moon + EMoon * (H2Moon - H0Moon);
            N7 = -Math.Cos(D1Moon) * Math.Sin(H7);
            D7 = CMoon * Math.Sin(D1Moon) - SMoon * Math.Cos(D1Moon) * Math.Cos(H7);
            A7 = Math.Atan(N7 / D7) / (Pi / 180d);
            if (D7 < 0d)
            {
                A7 = A7 + 180d;
            }

            if (A7 < 0d)
            {
                A7 = A7 + 360d;
            }

            if (A7 > 360d)
            {
                A7 = A7 - 360d;
            }

            A7 = Conversion.Int(A7 * 10d + 0.5d) / 10d;
            if (V0Moon < 0d & V2Moon > 0d)
            {
                Amp = (Math.Sin(D1Moon) - Math.Sin(Lat * Pi / 180d) * Math.Sin(0.365d * Pi / 180d)) / (Math.Cos(Lat * Pi / 180d) * Math.Cos(0.365d * Pi / 180d));
                if (Amp > 1d)
                    Amp = 1d; // added in V5.4.0 to avoid Dec. 21 90ºS type error
                Amp = Math.Atan(Amp / (Math.Sqrt(-Amp * Amp + 1d) + 9.999999E-21d)); // arcsin
                Amp = Amp * 180d / Pi;
                ZNAmp = 90d - Amp;
                ZNAmp = Conversion.Int(ZNAmp * 10d + 0.5d) / 10d;
            }

            if (V0Moon > 0d & V2Moon < 0d)
            {
                Amp = (Math.Sin(D1Moon) - Math.Sin(Lat * Pi / 180d) * Math.Sin(0.365d * Pi / 180d)) / (Math.Cos(Lat * Pi / 180d) * Math.Cos(0.365d * Pi / 180d));
                if (Amp < -1)
                    Amp = -1; // added in V5.4.0 to avoid Dec. 21 90ºN type error
                Amp = Math.Atan(Amp / (Math.Sqrt(-Amp * Amp + 1d) + 9.999999E-21d)); // arcsin
                Amp = Amp * 180d / Pi;
                ZNAmp = 270d + Amp;
                ZNAmp = Conversion.Int(ZNAmp * 10d + 0.5d) / 10d;
            }

            if (optLimb.Checked == true)
            {
                MoonTxtBx.AppendText(", Zn " + Strings.Format(A7, "000") + '°' + Strings.Space(4));
                PrintCount = (short)(PrintCount + 1);
            } // was "000" before V5.1.5

            if (optCenter.Checked == true)
            {
                MoonTxtBx.AppendText(", Zn " + Strings.Format(ZNAmp, "000") + '°' + Strings.Space(4));
                PrintCount = (short)(PrintCount + 1);
            }

            if (PrintCount == 2)
                TwilightFlag = false;
            return;
        }

        public void ViewVisibleBodies()
        {
            if (!FormSightPlanLoaded)
            {
                return;
            }

            BodiesFlag = true;
            BlankTimeFlag = false;
            DateError = false;
            CheckDate();
            Shape1.Visible = false;
            SkyPicBx.Visible = true;
            SkyPicBx.Cursor = Cursors.Cross;
            View = true;
            BuildMagnitudes();
            Warning();
            Calculate();
            if (optHorizon.Checked == false)
            {
                DisplayView();
            }
            else
            {
                DisplayHorizonView();
            }

            BodiesFlag = false;
            return;
        }

        private void BuildMagnitudes()
        {
            if (GYear <= 2005)
            {
                Magnitude = new string[] { " 2.1", " 2.2", " 2.4", " 2.5", " 2.2", " 0.6", " 2.2", " 3.1", " 2.8", " 1.9", " 1.1", " 0.3", " 0.2", " 1.7", " 1.8", " 1.8", " 0.1 - 1.2", " -0.9", " -1.6", " 1.6", " 0.5", " 1.2", " 1.7", " 2.2", " 1.8", " 2.2", " 1.3", " 2.0", " 2.2", " 2.8", " 1.1", " 1.6", " 1.7", " 1.2", " 1.9", " 0.9", " 2.3", " 0.2", " 0.1", " 2.9", " 2.2", " 2.3", " 1.2", " 1.9", " 2.6", " 1.7", " 2.1", " 2.4", " 2.0", " 0.1", " 2.1", " 0.9", " 2.1", " 1.3", " 2.5", " 2.2", " 1.3", " 2.6" };
            }
            else
            {
                Magnitude = new string[] { " 2.1", " 2.1", " 2.4", " 2.2", " 2.0", " 0.5", " 2.0", " 3.2", " 2.5", " 1.8", " 0.9", " 0.1", " 0.1", " 1.6", " 1.7", " 1.7", " 0.1 - 1.2", " -0.7", " -1.5", " 1.5", " 0.4", " 1.1", " 1.9", " 2.2", " 1.7", " 2.0", " 1.4", " 1.8", " 2.1", " 2.6", " 1.3", " 1.6", " 1.8", " 1.0", " 1.9", " 0.6", " 2.1", " 0.0", " -0.3", " 2.8", " 2.1", " 2.2", " 1.0", " 1.9", " 2.4", " 1.6", " 2.1", " 2.2", " 1.9", " 0.0", " 2.0", " 0.8", " 1.9", " 1.3", " 2.4", " 1.7", " 1.2", " 2.5" };
            }

            for (i = 0; i <= 57; i++)
                Mag[i] = Magnitude[i];
            return;
        }

        public void ListVisibleBodies()
        {
            if (!FormSightPlanLoaded)
                return;
            BodiesFlag = true;
            View = false;
            BlankTimeFlag = false;
            DateError = false;
            CheckDate();
            BuildMagnitudes();
            Greenwich(DTPlan.Value);
            Delta_T();
            Julian();
            Warning();
            Calculate();
            SunMoonFix();
            DisplayFirst();
            DisplaySecond();
            DisplayThird();
            Shape1.Clear();
            DisplaySunMoon();
            DGMag1.Refresh();
            DGMag2.Refresh();
            DGMag3.Refresh();
            BodiesFlag = false;
        }

        private void cmdPrint_Click(object eventSender, EventArgs eventArgs)
        {
            var temp = new Rect(Location.X, Location.Y, Width + 40, Height);
            Print_Renamed.PrintScreen(temp);
        }

        private void cmdTwilights_Click(object eventSender, EventArgs eventArgs)
        {
            ExecCmdTwilights();
            txtTime.Text = DTPlan.Value.Hour.ToString("00") + DTPlan.Value.Minute.ToString("00");
            if (chkNoonSightLAN.Checked == true)
            {
                txtLAN.Visible = true;
                GetLANtime();
            }
            else
            {
                txtLAN.Visible = false;
                txtLAN.Text = "";
            }

            SelectTabToDisplay();
            return;
        }

        public void ExecCmdTwilights()
        {
            txtTime.Text = DTPlan.Value.Hour.ToString("00") + DTPlan.Value.Minute.ToString("00");
            BodiesFlag = false;
            txtWarning.Visible = false;
            TwilightFlag = true;
            DateError = false;
            CheckDate();
            if (string.IsNullOrEmpty(txtLDeg.Text))
            {
                txtLDeg.Text = CommonGlobals.g_TextZero;
            }

            if (string.IsNullOrEmpty(txtLMin.Text))
            {
                txtLMin.Text = CommonGlobals.g_TextZero;
            }

            if (string.IsNullOrEmpty(txtLoDeg.Text))
            {
                txtLoDeg.Text = CommonGlobals.g_TextZero;
            }

            if (string.IsNullOrEmpty(txtLoMin.Text))
            {
                txtLoMin.Text = CommonGlobals.g_TextZero;
            }
            // If DateError = True Then
            // DateError = False
            // Exit Sub
            // End If
            ZTinSeconds = 6 * 3600; // set hour at 6am and convert to seconds * 3600
            var TSTmp = TimeSpan.FromSeconds(ZTinSeconds);
            LatLong();
            var DTTmp = new DateTime(DTPlan.Value.Year, DTPlan.Value.Month, DTPlan.Value.Day, TSTmp.Hours, TSTmp.Minutes, TSTmp.Seconds);
            Greenwich(DTTmp);
            Delta_T();
            Julian();
            Twilights();
            DisplayTwilights();
            // If BlankTimeFlag = True Then
            // txtTime.Text = ""
            // End If
            // BlankTimeFlag = True
            MoonData();
            BodiesFlag = true;
        }

        private void Form_Initialize_Renamed()
        {
            // DSTFlag = False    'eliminated in V2.7.3
            Pi = Math.PI;  // 4 * System.Math.Atan(1.0)
                           // NT = "00010203040506070809101112131415161718192021222324252627282930"
                           // NT = NT & "3132333435363738394041424344454647484950515253545556575859"
            cboL.SelectedIndex = 0; // g_LatN
            cboLo.SelectedIndex = 0; // g_LongW
                                     // lblZDh.Visible = False
            txtZDh.BackColor = System.Drawing.SystemColors.ButtonFace; //ColorTranslator.FromOle(0x8000000F);
            cboZDm.SelectedIndex = 0; // "00"

            // RA is Right Ascension hours of stars
            RAStars = new double[] { 2.53030102d, 0.13979405d, 0.43806971d, 0.67512237d, 0.72649196d, 1.62856849d, 2.11955753d, 2.97102075d, 3.03799227d, 3.40538065d, 4.59867741d, 5.24229787d, 5.27815529d, 5.41885085d, 5.43819817d, 5.60355929d, 5.91952924d, 6.39919719d, 6.75247703d, 6.97709679d, 7.65503287d, 7.75526399d, 8.37523211d, 9.13326624d, 9.21999319d, 9.4597898d, 10.13953074d, 11.06213019d, 11.81766044d, 12.26343617d, 12.44330439d, 12.51943314d, 12.90048595d, 13.41988313d, 13.79234379d, 14.06372347d, 14.11137457d, 14.26102008d, 14.66013772d, 14.84797587d, 14.84509067d, 15.57813003d, 16.49012803d, 16.81108191d, 17.1729687d, 17.56014444d, 17.58224182d, 17.94343608d, 18.4028662d, 18.61564901d, 18.92109048d, 19.84638861d, 20.42746051d, 20.69053187d, 21.73643281d, 22.13721819d, 22.96084625d, 23.07934827d };    // RA of Peacock was 20.42846051 before V5.4.1

            // Dec is Declination degrees of stars
            DecStars = new double[] { 89.26410951d, 29.09043199d, -42.30598151d, 56.53733109d, -17.9866046d, -57.23675749d, 23.46242313d, -40.30467242d, 4.08973396d, 49.86117959d, 16.50930139d, -8.20164055d, 45.99799111d, 6.34970223d, 28.60745001d, -1.20191983d, 7.40706274d, -52.69566046d, -16.71611582d, -28.97208374d, 5.22499306d, 28.02619862d, -59.50948307d, -43.43258935d, -69.71720773d, -8.65860253d, 11.96720706d, 61.7510332d, 14.57206032d, -17.54192947d, -63.09909166d, -57.11321169d, 55.95982116d, -11.16132203d, 49.31326506d, -60.37303931d, -36.36995445d, 19.18241331d, -60.83397468d, -16.04177818d, 74.15550491d, 26.71469302d, -26.43200249d, -69.02771504d, -15.72491023d, -37.10382115d, 12.56003477d, 51.48889499d, -34.38461611d, 38.7836918d, -26.29672225d, 8.86832198d, -56.7350901d, 45.280338d, 9.87501126d, -46.96097543d, -29.62223615d, 15.20526442d };
            // body names in BN order - Polaris is BN = 0, stars are BN 1 thru 57 and Sun, moon, venus, mars, Jupiter, saturn are 58, 59, 60, 61, 62, 63
            Body = new string[] { "Polaris", "Alpheratz", "Ankaa", "Schedar", "Diphda", "Achernar", "Hamal", "Acamar", "Menkar", "Mirfak", "Aldebaran", "Rigel", "Capella", "Bellatrix", "Elnath", "Alnilam", "Betelgeuse", "Canopus", "Sirius", "Adhara", "Procyon", "Pollux", "Avior", "Suhail", "Miaplacidus", "Alphard", "Regulus", "Dubhe", "Denebola", "Gienah", "Acrux", "Gacrux", "Alioth", "Spica", "Alkaid", "Hadar", "Menkent", "Arcturus", "Rigil Kentaurus", "Zubenelgenubi", "Kochab", "Alphecca", "Antares", "Atria", "Sabik", "Shaula", "Rasalhague", "Eltanin", "Kaus Australis", "Vega", "Nunki", "Altair", "Peacock", "Deneb", "Enif", "Al Na'ir", "Fomalhaut", "Markab", "Sun", "Moon", "Venus", "Mars", "Jupiter", "Saturn" };
            // Proper motion right ascension in seconds/century
            PMRA = new double[] { 22.9526d, 1.0351d, 2.0982d, 0.6089d, 1.6317d, 1.0843d, 1.3861d, -0.468d, -0.0789d, 0.2493d, 0.4365d, 0.0126d, 0.7247d, -0.0587d, 0.1768d, 0.0099d, 0.1837d, 0.2199d, -3.8007d, 0.02d, -4.797d, -4.7254d, -0.3329d, -0.2131d, -3.032d, -0.0977d, -1.6996d, -1.9221d, -3.4374d, -1.1158d, -0.5212d, 0.3431d, 1.3308d, -0.2888d, -1.2397d, -0.458d, -4.2995d, -7.718d, -50.3145d, -0.7331d, -0.7884d, 0.8984d, -0.0756d, 0.3325d, 0.2851d, -0.0744d, 0.7519d, -0.0912d, -0.32d, 1.7192d, 0.1031d, 3.6221d, 0.0937d, 0.0148d, 0.2031d, 1.2464d, 2.5248d, 0.4221d };
            // Proper motion declination in arcseconds/century
            PMDec = new double[] { -1.1746d, -16.295d, -35.3638d, -3.217d, 3.2711d, -4.0079d, -14.5771d, 2.571d, -7.876d, -2.601d, -18.936d, -0.056d, -42.713d, -1.328d, -17.422d, -0.106d, 1.086d, 2.367d, -122.3076d, 0.229d, -103.4582d, -4.5959d, 2.272d, 1.428d, 10.8913d, 3.325d, 0.4909d, -3.5251d, 11.3783d, 2.231d, -1.473d, -26.433d, -0.8991d, -3.173d, -1.5561d, -2.506d, -51.7862d, -199.9418d, 48.2868d, -6.9d, 1.191d, -8.944d, -2.321d, -3.292d, 9.765d, -2.995d, -22.261d, -2.305d, -12.405d, 28.7459d, -5.265d, 38.5538d, -8.615d, 0.155d, 0.138d, -14.7909d, -16.4217d, -4.256d };
            // Star magnitudes were here
            // nutation in longitude and obliquity
            ND = new int[] { 0, -2, 0, 0, 0, 0, -2, 0, 0, -2, -2, -2, 0, 2, 0, 2, 0, 0, -2, 0, 2, 0, 0, -2, 0, -2, 0, 0, 2, -2, 0, -2, 0, 0, 2, 2, 0, -2, 0, 2, 2, -2, -2, 2, 2, 0, -2, -2, 0, -2, -2, 0, -1, -2, 1, 0, 0, -1, 0, 0, 2, 0, 2 };
            NM = new int[] { 0, 0, 0, 0, 1, 0, 1, 0, 0, -1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 2, 1, 0, -1, 0, 0, 0, 1, 1, -1, 0, 0, 0, 0, 0, 0, -1, -1, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, -1, 1, -1, -1, 0, -1 };
            NMprime = new int[] { 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 1, 0, -1, 0, 1, -1, -1, 1, 2, -2, 0, 2, 2, 1, 0, 0, -1, 0, -1, 0, 0, 1, 0, 2, -1, 1, 0, 1, 0, 0, 1, 2, 1, -2, 0, 1, 0, 0, 2, 2, 0, 1, 1, 0, 0, 1, -2, 1, 1, 1, -1, 3, 0 };
            NF = new int[] { 0, 2, 2, 0, 0, 0, 2, 2, 2, 2, 0, 2, 2, 0, 0, 2, 0, 2, 0, 2, 2, 2, 0, 2, 2, 2, 2, 0, 0, 2, 0, 0, 0, -2, 2, 2, 2, 0, 2, 2, 0, 2, 2, 0, 0, 0, 2, 0, 2, 0, 2, -2, 0, 0, 0, 2, 2, 0, 0, 2, 2, 2, 2 };
            NOmega = new int[] { 1, 2, 2, 2, 0, 0, 2, 1, 2, 2, 0, 1, 2, 0, 1, 2, 1, 1, 0, 1, 2, 2, 0, 2, 0, 0, 1, 0, 1, 2, 1, 1, 1, 0, 1, 2, 2, 0, 2, 1, 0, 2, 1, 1, 1, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 2, 0, 0, 2, 2, 2, 2 };
            NSin = new int[] { -171996, -13187, -2274, 2062, 1426, 712, -517, -386, -301, 217, -158, 129, 123, 63, 63, -59, -58, -51, 48, 46, -38, -31, 29, 29, 26, -22, 21, 17, 16, -16, -15, -13, -12, 11, -10, -8, 7, -7, -7, -7, 6, 6, 6, -6, -6, 5, -5, -5, -5, 4, 4, 4, -4, -4, -4, 3, -3, -3, -3, -3, -3, -3, -3 };
            NSinT = new double[] { -174.2d, -1.6d, -0.2d, 0.2d, -3.4d, 0.1d, 1.2d, -0.4d, 0d, -0.5d, 0d, 0.1d, 0d, 0d, 0.1d, 0d, -0.1d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, -0.1d, 0d, 0.1d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d };
            NCos = new int[] { 92025, 5736, 977, -895, 54, -7, 224, 200, 129, -95, 0, -70, -53, 0, -33, 26, 32, 27, 0, -24, 16, 13, 0, -12, 0, 0, -10, 0, -8, 7, 9, 7, 6, 0, 5, 3, -3, 0, 3, 3, 0, -3, -3, 3, 3, 0, 3, 3, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            NCosT = new double[] { 8.9d, -3.1d, -0.5d, 0.5d, -0.1d, 0d, -0.6d, 0d, -0.1d, 0.3d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d };
            // Moon
            // Table 47.A longitude and distance
            MDA = new int[] { 0, 2, 2, 0, 0, 0, 2, 2, 2, 2, 0, 1, 0, 2, 0, 0, 4, 0, 4, 2, 2, 1, 1, 2, 2, 4, 2, 0, 2, 2, 1, 2, 0, 0, 2, 2, 2, 4, 0, 3, 2, 4, 0, 2, 2, 2, 4, 0, 4, 1, 2, 0, 1, 3, 4, 2, 0, 1, 2, 2 };
            MMA = new int[] { 0, 0, 0, 0, 1, 0, 0, -1, 0, -1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 1, 1, 0, 1, -1, 0, 0, 0, 1, 0, -1, 0, -2, 1, 2, -2, 0, 0, -1, 0, 0, 1, -1, 2, 2, 1, -1, 0, 0, -1, 0, 1, 0, 1, 0, 0, -1, 2, 1, 0, 0 };
            MMprimeA = new int[] { 1, -1, 0, 2, 0, 0, -2, -1, 1, 0, -1, 0, 1, 0, 1, 1, -1, 3, -2, -1, 0, -1, 0, 1, 2, 0, -3, -2, -1, -2, 1, 0, 2, 0, -1, 1, 0, -1, 2, -1, 1, -2, -1, -1, -2, 0, 1, 4, 0, -2, 0, 2, 1, -2, -3, 2, 1, -1, 3, -1 };
            MFA = new int[] { 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, -2, 2, -2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, -2, 2, 0, 2, 0, 0, 0, 0, 0, 0, -2, 0, 0, 0, 0, -2, -2, 0, 0, 0, 0, 0, 0, 0, -2 };
            MSinA = new int[] { 6288774, 1274027, 658314, 213618, -185116, -114332, 58793, 57066, 53322, 45758, -40923, -34720, -30383, 15327, -12528, 10980, 10675, 10034, 8548, -7888, -6766, -5163, 4987, 4036, 3994, 3861, 3665, -2689, -2602, 2390, -2348, 2236, -2120, -2069, 2048, -1773, -1595, 1215, -1110, -892, -810, 759, -713, -700, 691, 596, 549, 537, 520, -487, -399, -381, 351, -340, 330, 327, -323, 299, 294, 0 };
            MCosA = new int[] { -20905355, -3699111, -2955968, -569925, 48888, -3149, 246158, -152138, -170733, -204586, -129620, 108743, 104755, 10321, 0, 79661, -34782, -23210, -21636, 24208, 30824, -8379, -16675, -12831, -10445, -11650, 14403, -7003, 0, 10056, 6322, -9884, 5751, 0, -4950, 4130, 0, -3958, 0, 3258, 2616, -1897, -2117, 2354, 0, 0, -1423, -1117, -1571, -1739, 0, -4421, 0, 0, 0, 0, 1165, 0, 0, 8752 };
            // Table 47.B latitude
            MDB = new int[] { 0, 0, 0, 2, 2, 2, 2, 0, 2, 0, 2, 2, 2, 2, 2, 2, 2, 0, 4, 0, 0, 0, 1, 0, 0, 0, 1, 0, 4, 4, 0, 4, 2, 2, 2, 2, 0, 2, 2, 2, 2, 4, 2, 2, 0, 2, 1, 1, 0, 2, 1, 2, 0, 4, 4, 1, 4, 1, 4, 2 };
            MMB = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -1, 0, 0, 1, -1, -1, -1, 1, 0, 1, 0, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, -1, 0, 0, 0, 0, 1, 1, 0, -1, -2, 0, 1, 1, 1, 1, 1, 0, -1, 1, 0, -1, 0, 0, 0, -1, -2 };
            MMprimeB = new int[] { 0, 1, 1, 0, -1, -1, 0, 2, 1, 2, 0, -2, 1, 0, -1, 0, -1, -1, -1, 0, 0, -1, 0, 1, 1, 0, 0, 3, 0, -1, 1, -2, 0, 2, 1, -2, 3, 2, -3, -1, 0, 0, 1, 0, 1, 1, 0, 0, -2, -1, 1, -2, 2, -2, -1, 1, 1, -1, 0, 0 };
            MFB = new int[] { 1, 1, -1, -1, 1, -1, 1, 1, -1, -1, -1, -1, 1, -1, 1, 1, -1, -1, -1, 1, 3, 1, 1, 1, -1, -1, -1, 1, -1, 1, -3, 1, -3, -1, -1, 1, -1, 1, -1, 1, 1, 1, 1, -1, 3, -1, -1, 1, -1, -1, 1, -1, 1, -1, -1, -1, -1, -1, -1, 1 };
            MSinB = new int[] { 5128122, 280602, 277693, 173237, 55413, 46271, 32573, 17198, 9266, 8822, 8216, 4324, 4200, -3359, 2463, 2211, 2065, -1870, 1828, -1794, -1749, -1565, -1491, -1475, -1410, -1344, -1335, 1107, 1021, 833, 777, 671, 607, 596, 491, -451, 439, 422, 421, -366, -351, 331, 315, 302, -283, -229, 223, 223, -220, -220, -185, 181, -177, 176, 166, -164, 132, -119, 115, 107 };
            // Helper stars
            NumberOfHelpers = 70;
            RDHelper = new int[] { 11, 11, 12, 13, 15, 16, 15, 16, 17, 0, 0, 1, 1, 23, 0, 5, 5, 5, 5, 7, 19, 20, 19, 20, 19, 12, 12, 12, 12, 12, 16, 16, 15, 16, 16, 16, 17, 17, 17, 15, 15, 15, 15, 15, 10, 11, 9, 10, 9, 11, 18, 18, 18, 19, 19, 18, 18, 19, 4, 4, 4, 5, 19, 19, 19, 19, 19, 20, 1, 2 };
            RMHelper = new int[] { 1, 53, 15, 23, 20, 17, 44, 45, 32, 9, 56, 25, 54, 3, 13, 40, 32, 47, 35, 34, 30, 22, 44, 46, 56, 34, 29, 10, 47, 15, 5, 0, 58, 35, 50, 51, 12, 37, 42, 27, 32, 55, 57, 42, 19, 14, 45, 16, 45, 14, 5, 21, 27, 2, 9, 17, 45, 6, 28, 19, 28, 37, 55, 46, 5, 6, 25, 11, 9, 3 };
            RSHelper = new int[] { 50, 50, 26, 56, 44, 30, 3, 58, 13, 11, 42, 49, 24, 46, 14, 46, 0, 45, 26, 36, 43, 14, 58, 13, 18, 23, 52, 7, 43, 9, 26, 20, 51, 53, 10, 52, 9, 19, 29, 50, 56, 48, 35, 45, 58, 6, 51, 41, 51, 14, 48, 0, 58, 37, 46, 38, 39, 56, 37, 48, 40, 39, 19, 15, 24, 15, 30, 18, 44, 54 };
            DDHelper = new int[] { 56, 53, 57, 54, 71, 75, 77, 82, 86, 59, 60, 60, 63, 28, 15, -1, -0, -9, -5, 31, 27, 40, 45, 33, 35, -23, -16, -22, -59, -58, -19, -22, -26, -28, -34, -38, -43, -42, -39, 29, 31, 26, 26, 26, 19, 20, 23, 23, 23, 15, -30, -29, -25, -29, -21, -36, -26, -27, 19, 15, 15, 21, 6, 10, 13, -4, 3, -0, 35, 42 };
            DMHelper = new int[] { 22, 41, 1, 55, 50, 45, 47, 2, 35, 8, 43, 14, 40, 4, 11, 56, -17, 40, 54, 53, 57, 15, 7, 58, 5, 23, 30, 37, 41, 44, 48, 37, 6, 12, 17, 2, 14, 59, 1, 6, 21, 4, 52, 17, 50, 31, 46, 25, 46, 25, 25, 49, 25, 52, 1, 45, 59, 40, 10, 37, 52, 8, 24, 36, 51, 52, 6, -49, 37, 19 };
            DSHelper = new int[] { 56, 41, 57, 31, 2, 19, 40, 14, 11, 59, 0, 7, 13, 58, 1, 34, 57, 11, 36, 18, 35, 24, 51, 13, 0, 48, 55, 11, 19, 55, 19, 18, 50, 58, 36, 51, 21, 52, 48, 20, 32, 49, 40, 44, 30, 25, 27, 2, 27, 46, 26, 42, 18, 49, 25, 42, 27, 13, 49, 39, 15, 33, 24, 48, 48, 57, 53, 17, 14, 47 };
            MagHelper = new double[] { 2.4d, 2.4d, 3.3d, 2.3d, 3.1d, 5d, 4.3d, 4.2d, 4.4d, 2.3d, 2.5d, 2.7d, 3.4d, 2.4d, 2.8d, 1.8d, 2.2d, 2.1d, 2.8d, 1.6d, 3.1d, 2.2d, 2.9d, 2.5d, 3.9d, 2.7d, 3d, 3d, 1.3d, 2.8d, 2.6d, 2.3d, 2.9d, 2.8d, 2.3d, 3d, 3.3d, 1.9d, 2.4d, 3.7d, 4.1d, 5.5d, 4.2d, 3.8d, 2.3d, 2.6d, 3d, 3.4d, 3d, 3.3d, 3d, 2.7d, 2.8d, 3d, 2.9d, 3.1d, 3.2d, 3.3d, 3.5d, 3.7d, 3.4d, 3d, 3.7d, 2.7d, 3d, 3.4d, 3.4d, 3.2d, 2.1d, 2.2d };
            // Big Dipper 4, Little Dipper 5, Cassiopeia 4
            // Pegasus 2, Orion 4, Gemini 1, Cygnus 5, Corvus 3, Crux 2
            // Scorpius 9, Corona Borealis 5
            // Leo 6, Sagittarius 8
            // Taurus 4, Aquila 6, Andromeda 2
            MoonFlag = false; // is this necessary?
            VwBody1 = new BodyInfo[1];
            VwBody2 = new BodyInfo[1];
            VwBody3 = new BodyInfo[1];
            bShowToolTips = false; // set to true to display body name tooltip
        }

        private void FormSightPlan_Load(object eventSender, EventArgs eventArgs)
        {
            int DrawWidth = (int)(SkyPicBx.Width / 2d - 25d);
            DPen = new Pen(Color.Black, 1f);
            DTPlan.Value = DateTime.Now;
            cboLineWidth.SelectedIndex = 1; // Rising/Setting Line Width = 2 Regular Width
                                            // cboDay.SelectedIndex = DateAndTime.Today.Day - 1
            MonthList = new string[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            // cboMonth.Text = MonthList(DateAndTime.Today.Month - 1)
            // txtYear.Text = DateAndTime.Today.Year.ToString      'CStr(Year(Today))
            cboL.SelectedIndex = 0; // g_LatN
            cboLo.SelectedIndex = 0; // g_LongW
            RotateIncr.SelectedIndex = 2;
            cboLineWidth.SelectedIndex = 2;
            SweepStep2 = 0f;
            SweepStep3 = 0f;
            IsMouseDown = false;
            // delete graphics files from last Plan Form session
            CleanOutOldFiles();
            ToolTip1.Active = true;
            bm = new Bitmap(SkyPicBx.Width, SkyPicBx.Height);
            Plan1graphic = Graphics.FromImage(bm);
            Plan1graphic.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Plan1graphic.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            Plan1graphic.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            Plan1graphic.TranslateTransform((float)(SkyPicBx.Width / 2d), (float)(SkyPicBx.Height / 2d));
            SkyPicBx.Visible = true;
            DisplayInitialView = true;
            DisplayView();
            DisplayInitialView = false;
            SkyPicBx.Visible = false;
            lblN.Visible = false;
            lblE.Visible = false;
            lblS.Visible = false;
            lblW.Visible = false;

            // lblMinimumAltitude.Visible = False
            // txtMinimumAltitude.Visible = False
            // lblAz1.Visible = False
            // lblAzDeg.Visible = False
            // Label2.Visible = False
            // Label3.Visible = False
            // txtLowAz.Visible = False
            // txtHighAz.Visible = False
            // lblAltDeg.Visible = False
            // FormSightPlan Plan load event code
            if (My.MyProject.Forms.FavoriteLocations.SharedLocUse.EntryStatus == "Shared")
            {
                BringToFront();
                if (My.MyProject.Forms.FavoriteLocations.CommonYesNoMsgBox("Shared Location data is available - do you want to use it?") == true)
                {
                    {
                        var withBlock = My.MyProject.Forms.FavoriteLocations.SharedLocUse;
                        txtLDeg.Text = withBlock.DRLatDeg.ToString();
                        txtLMin.Text = withBlock.DRLatMin.ToString();
                        if ((withBlock.DRLatNS ?? "") == (CommonGlobals.g_LatN ?? ""))
                        {
                            cboL.SelectedIndex = 0;
                        }
                        else
                        {
                            cboL.SelectedIndex = 1;
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

                        txtLowAz.Text = withBlock.FromAZ.ToString();
                        txtHighAz.Text = withBlock.ToAZ.ToString();
                        txtLowAz.Visible = true;
                        txtHighAz.Visible = true;
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
                    }
                }
            }

            Plan1TabCntl.SelectedIndex = 0;
            Plan1TabCntl.Visible = false;
            FormSightPlanLoaded = true;
            BringToFront();
            Refresh();
            return;
        }

        private void cboDay_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            CheckDate();
        }

        private void cboDay_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            short KeyAscii = (short)Strings.Asc(eventArgs.KeyChar);
            eventArgs.KeyChar = (char)KeyAscii;
            if (KeyAscii == 0)
            {
                eventArgs.Handled = true;
            }
        }

        private void cboMonth_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            CheckDate();
        }

        private void FormSightPlan_FormClosed(object eventSender, FormClosedEventArgs eventArgs)
        {
            bm.Dispose();
            // Cleanup()
        }

        private void optCenter_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (!FormSightPlanLoaded)
                return;
            if (optCenter.Checked)
            {
                ExecCmdTwilights();
                SelectTabToDisplay();
            }

            return;
        }

        private void optHorizon_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (!FormSightPlanLoaded)
                return;
            if (optHorizon.Checked)
            {
                FrameDirection.Visible = true;
                if (optN.Checked == true)
                    optN_CheckedChanged(optN, new EventArgs());
                if (optS.Checked == true)
                    optS_CheckedChanged(optS, new EventArgs());
                if (optE.Checked == true)
                    optE_CheckedChanged(optE, new EventArgs());
                if (optW.Checked == true)
                    optW_CheckedChanged(optW, new EventArgs());
                ViewVisibleBodies();
            }
        }

        private void optOverhead_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (!FormSightPlanLoaded)
                return;
            if (optOverhead.Checked)
            {
                FrameDirection.Visible = true; // False
                if (optN.Checked == true)
                    optN_CheckedChanged(optN, new EventArgs());
                if (optS.Checked == true)
                    optS_CheckedChanged(optS, new EventArgs());
                if (optE.Checked == true)
                    optE_CheckedChanged(optE, new EventArgs());
                if (optW.Checked == true)
                    optW_CheckedChanged(optW, new EventArgs());
                BlankTimeFlag = false;
                ViewVisibleBodies();
            }

            return;
        }

        private void optLimb_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (!FormSightPlanLoaded)
                return;
            if (optLimb.Checked)
            {
                ExecCmdTwilights();
                SelectTabToDisplay();
            }

            return;
        }

        private void optN_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (!FormSightPlanLoaded)
                return;
            if (optN.Checked)
            {
                if (optHorizon.Checked == true)
                {
                    ShiftAz = 270d; // 180
                    lblN.Visible = false;
                    lblE.Visible = false;
                    lblS.Visible = true;
                    lblW.Visible = false;
                    lblSRight.Visible = true;
                    lblSLeft.Visible = true;
                    lblS.Text = CommonGlobals.g_LatN;
                    lblSRight.Text = CommonGlobals.g_LongE;
                    lblSLeft.Text = CommonGlobals.g_LongW;
                }
                else
                {
                    RotateX = 180d;
                    RotateY = 180d;
                    lblN.Visible = true;
                    lblE.Visible = true;
                    lblS.Visible = true;
                    lblW.Visible = true;
                    lblSRight.Visible = false;
                    lblSLeft.Visible = false;
                    if (optStarFinder.Checked == true)
                    {
                        lblN.Text = CommonGlobals.g_LatS;
                        lblE.Text = CommonGlobals.g_LongE;
                        lblS.Text = CommonGlobals.g_LatN;
                        lblW.Text = CommonGlobals.g_LongW;
                    }
                    else
                    {
                        lblN.Text = CommonGlobals.g_LatS;
                        lblE.Text = CommonGlobals.g_LongW;
                        lblS.Text = CommonGlobals.g_LatN;
                        lblW.Text = CommonGlobals.g_LongE;
                    }
                }

                BlankTimeFlag = false;
                ExecCmdTwilights();
                ViewVisibleBodies();
            }
        }

        private void optS_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (!FormSightPlanLoaded)
                return;
            if (optS.Checked)
            {
                if (optHorizon.Checked == true)
                {
                    ShiftAz = 90d; // 0
                                   // DisplayTwilights
                    lblN.Visible = false;
                    lblE.Visible = false;
                    lblS.Visible = true;
                    lblW.Visible = false;
                    lblSRight.Visible = true;
                    lblSLeft.Visible = true;
                    lblS.Text = CommonGlobals.g_LatS;
                    lblSRight.Text = CommonGlobals.g_LongW;
                    lblSLeft.Text = CommonGlobals.g_LongE;
                }
                else
                {
                    RotateX = 0d;
                    RotateY = 0d;
                    lblN.Visible = true;
                    lblE.Visible = true;
                    lblS.Visible = true;
                    lblW.Visible = true;
                    lblSRight.Visible = false;
                    lblSLeft.Visible = false;
                    if (optStarFinder.Checked == true)
                    {
                        lblN.Text = CommonGlobals.g_LatN;
                        lblE.Text = CommonGlobals.g_LongW;
                        lblS.Text = CommonGlobals.g_LatS;
                        lblW.Text = CommonGlobals.g_LongE;
                    }
                    else
                    {
                        lblN.Text = CommonGlobals.g_LatN;
                        lblE.Text = CommonGlobals.g_LongE;
                        lblS.Text = CommonGlobals.g_LatS;
                        lblW.Text = CommonGlobals.g_LongW;
                    }
                }

                BlankTimeFlag = false;
                ExecCmdTwilights();
                ViewVisibleBodies();
            }
        }

        private void optE_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (!FormSightPlanLoaded)
                return;
            if (optE.Checked)
            {
                if (optHorizon.Checked == true)
                {
                    ShiftX = 0d; // 1620
                    ShiftAz = 0d; // -90
                                  // DisplayTwilights
                    lblN.Visible = false;
                    lblE.Visible = false;
                    lblS.Visible = true;
                    lblW.Visible = false;
                    lblSRight.Visible = true;
                    lblSLeft.Visible = true;
                    lblS.Text = CommonGlobals.g_LongE;
                    lblSRight.Text = CommonGlobals.g_LatS;
                    lblSLeft.Text = CommonGlobals.g_LatN;
                }
                else
                {
                    RotateX = 90d;
                    RotateY = 90d;
                    lblN.Visible = true;
                    lblE.Visible = true;
                    lblS.Visible = true;
                    lblW.Visible = true;
                    lblSRight.Visible = false;
                    lblSLeft.Visible = false;
                    lblN.Text = CommonGlobals.g_LongW;
                    lblE.Text = CommonGlobals.g_LatN;
                    lblS.Text = CommonGlobals.g_LongE;
                    lblW.Text = CommonGlobals.g_LatS;
                    if (optStarFinder.Checked == true)
                    {
                        RotateX = 270d;
                        RotateY = 270d;
                    }
                    else
                    {
                        // nothing
                    }
                }
                // Warning
                BlankTimeFlag = false;
                ExecCmdTwilights();
                ViewVisibleBodies();
            }
        }

        private void optW_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (!FormSightPlanLoaded)
                return;
            if (optW.Checked)
            {
                // ScaleFormSightPlan()

                if (optHorizon.Checked == true)
                {
                    ShiftAz = 180d; // 90
                    lblN.Visible = false;
                    lblE.Visible = false;
                    lblS.Visible = true;
                    lblW.Visible = false;
                    lblSRight.Visible = true;
                    lblSLeft.Visible = true;
                    lblS.Text = CommonGlobals.g_LongW;
                    lblSRight.Text = CommonGlobals.g_LatN;
                    lblSLeft.Text = CommonGlobals.g_LatS;
                }
                else
                {
                    RotateX = 270d;
                    RotateY = 270d;
                    lblN.Visible = true;
                    lblE.Visible = true;
                    lblS.Visible = true;
                    lblW.Visible = true;
                    lblSRight.Visible = false;
                    lblSLeft.Visible = false;
                    lblN.Text = CommonGlobals.g_LongE;
                    lblE.Text = CommonGlobals.g_LatS;
                    lblS.Text = CommonGlobals.g_LongW;
                    lblW.Text = CommonGlobals.g_LatN;
                    if (optStarFinder.Checked == true)
                    {
                        RotateX = 90d;
                        RotateY = 90d;
                    }
                    else
                    {
                        // Nothing
                    }
                }

                BlankTimeFlag = false;
                ExecCmdTwilights();
                ViewVisibleBodies();
            }
        }

        private void optStarFinder_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (!FormSightPlanLoaded)
                return;
            if (optStarFinder.Checked)
            {
                FrameDirection.Visible = true; // False
                if (optN.Checked == true)
                    optN_CheckedChanged(optN, new EventArgs());
                if (optS.Checked == true)
                    optS_CheckedChanged(optS, new EventArgs());
                if (optE.Checked == true)
                    optE_CheckedChanged(optE, new EventArgs());
                if (optW.Checked == true)
                    optW_CheckedChanged(optW, new EventArgs());
                BlankTimeFlag = false;
                ExecCmdTwilights();
                ViewVisibleBodies();
            }
        }

        private void optThreeBoat_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optThreeBoat.Checked)
            {
                cmdCW.Enabled = true;
                cmdCCW.Enabled = true;
                ResetRotateBtn.Enabled = true;
                RotateIncr.Enabled = true;
                ViewVisibleBodies();
            }
        }

        private void optThreeBeach_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optThreeBeach.Checked)
            {
                cmdCW.Enabled = true;
                cmdCCW.Enabled = true;
                ResetRotateBtn.Enabled = true;
                RotateIncr.Enabled = true;
                ViewVisibleBodies();
            }
        }

        private void optTwo_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optTwo.Checked)
            {
                cmdCW.Enabled = true;
                cmdCCW.Enabled = true;
                ResetRotateBtn.Enabled = true;
                RotateIncr.Enabled = true;
                ViewVisibleBodies();
            }
        }

        private void optOff_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optOff.Checked)
            {
                // ScaleFormSightPlan()
                ViewVisibleBodies();
                cmdCW.Enabled = false;
                cmdCCW.Enabled = false;
                ResetRotateBtn.Enabled = false;
                RotateIncr.Enabled = false;
            }
        }

        public void DisplayAzAltText(System.Windows.Point MousePos)
        {
            bool bBodyFound;
            int DrawWidth = (int)(SkyPicBx.Width / 2d - 25d);
            int MidX = (int)(SkyPicBx.Width / 2d);
            int MidY = (int)(SkyPicBx.Height / 2d);
            int MaxRad = DrawWidth;
            int PosX = (int)MousePos.X;
            int PosY = (int)MousePos.Y;
            if (optHorizon.Checked == false)
            {
                PosX = PosX - MidX;
                PosY = PosY - MidY;
                rad = (float)Math.Sqrt(Math.Pow(Math.Abs(PosX), 2d) + Math.Pow(Math.Abs(PosY), 2d));
                if (rad > MaxRad | View == false)
                {
                    SkyPicBx.Cursor = Cursors.Default;
                    lblAlt.Text = "";
                    lblAz.Text = "";
                    lblBodyName.Text = "";
                }
                else
                {
                    SkyPicBx.Cursor = Cursors.Cross;
                    lblAlt.Text = Math.Round((DrawWidth - rad) * (90d / DrawWidth)).ToString();
                    if (PosX == 0 & PosY >= 0)
                        lblAz.Text = "180";
                    if (PosX == 0 & PosY < 0)
                        lblAz.Text = "0";
                    // If optOverhead.Checked = True Then
                    if (PosX > 0 & PosY > 0)
                    {
                        lblAz.Text = Math.Round(270d - Math.Atan(PosY / (double)PosX) * 180d / Pi).ToString();
                    }
                    else if (PosX < 0 & PosY > 0)
                    {
                        lblAz.Text = Math.Round(90d - Math.Atan(PosY / (double)PosX) * 180d / Pi).ToString();
                    }
                    else if (PosX < 0 & PosY < 0)
                    {
                        lblAz.Text = Math.Round(90d - Math.Atan(PosY / (double)PosX) * 180d / Pi).ToString();
                    }
                    else if (PosX > 0 & PosY < 0)
                    {
                        lblAz.Text = Math.Round(270d - Math.Atan(PosY / (double)PosX) * 180d / Pi).ToString();
                    }
                    else if (PosX == 0 & PosY > 0)
                    {
                        lblAz.Text = "0";
                    }
                    else if (PosX == 0 & PosY < 0)
                    {
                        lblAz.Text = "180";
                    }
                    else if (PosX > 0 & PosY == 0)
                    {
                        lblAz.Text = "90";
                    }
                    else if (PosX < 0 & PosY == 0)
                    {
                        lblAz.Text = "270";
                    }
                    // End If
                    if (optStarFinder.Checked == true)
                    {
                        lblAz.Text = (Conversions.ToDouble(lblAz.Text) + 270d).ToString();
                    }

                    if (optS.Checked == true)
                    {
                        lblAz.Text = lblAz.Text;
                    }

                    if (optN.Checked == true)
                    {
                        lblAz.Text = (Conversions.ToDouble(lblAz.Text) + 180d).ToString();
                    }

                    if (optE.Checked == true)
                    {
                        lblAz.Text = (Conversions.ToDouble(lblAz.Text) + 270d).ToString();
                    }

                    if (optW.Checked == true)
                    {
                        lblAz.Text = (Conversions.ToDouble(lblAz.Text) + 90d).ToString();
                    }
                    // now see if mouse position matches to any of the bodies projected on the visible view
                    bBodyFound = false;
                    var loopTo = (short)Information.UBound(VwBody1, 1);
                    for (i = 0; i <= loopTo; i++)
                    {
                        if (IsBodyInLoc(VwBody1[i], PosX, PosY))
                        {
                            lblBodyName.Text = VwBody1[i].BodyName;
                            lblAlt.Text = VwBody1[i].BodyAlt;
                            lblAz.Text = VwBody1[i].BodyAz;
                            bBodyFound = true;
                            break;
                        }
                    }

                    if (!bBodyFound)
                    {
                        var loopTo1 = (short)Information.UBound(VwBody2, 1);
                        for (i = 0; i <= loopTo1; i++)
                        {
                            if (IsBodyInLoc(VwBody2[i], PosX, PosY))
                            {
                                lblBodyName.Text = VwBody2[i].BodyName;
                                lblAlt.Text = VwBody2[i].BodyAlt;
                                lblAz.Text = VwBody2[i].BodyAz;
                                bBodyFound = true;
                                break;
                            }
                        }
                    }

                    if (!bBodyFound)
                    {
                        var loopTo2 = (short)Information.UBound(VwBody3, 1);
                        for (i = 0; i <= loopTo2; i++)
                        {
                            if (IsBodyInLoc(VwBody3[i], PosX, PosY))
                            {
                                lblBodyName.Text = VwBody3[i].BodyName;
                                lblAlt.Text = VwBody3[i].BodyAlt;
                                lblAz.Text = VwBody3[i].BodyAz;
                                bBodyFound = true;
                                break;
                            }
                        }
                    }

                    if (!bBodyFound)
                    {
                        lblBodyName.Text = "";
                    }
                }
            }
            else // for Horizon View
            {
                lblAlt.Text = Math.Round(90d - PosY / ((SkyPicBx.Width - 10) / 90d)).ToString();
                lblAz.Text = (Math.Round(PosX / (SkyPicBx.Width / 180d)) + ShiftAz).ToString();
                if (Conversion.Val(lblAz.Text) >= 360d)
                    lblAz.Text = (Conversion.Val(lblAz.Text) - 360d).ToString();
                if (Conversion.Val(lblAz.Text) < 0d)
                    lblAz.Text = (Conversion.Val(lblAz.Text) + 360d).ToString();
                bBodyFound = false;
                var loopTo3 = (short)Information.UBound(VwBody1, 1);
                for (i = 0; i <= loopTo3; i++)
                {
                    if (IsBodyInLoc(VwBody1[i], PosX, PosY))
                    {
                        lblBodyName.Text = VwBody1[i].BodyName;
                        lblAlt.Text = VwBody1[i].BodyAlt;
                        lblAz.Text = VwBody1[i].BodyAz;
                        bBodyFound = true;
                        break;
                    }
                }

                if (!bBodyFound)
                {
                    var loopTo4 = (short)Information.UBound(VwBody2, 1);
                    for (i = 0; i <= loopTo4; i++)
                    {
                        if (IsBodyInLoc(VwBody2[i], PosX, PosY))
                        {
                            lblBodyName.Text = VwBody2[i].BodyName;
                            lblAlt.Text = VwBody2[i].BodyAlt;
                            lblAz.Text = VwBody2[i].BodyAz;
                            bBodyFound = true;
                            break;
                        }
                    }
                }

                if (!bBodyFound)
                {
                    var loopTo5 = (short)Information.UBound(VwBody3, 1);
                    for (i = 0; i <= loopTo5; i++)
                    {
                        if (IsBodyInLoc(VwBody3[i], PosX, PosY))
                        {
                            lblBodyName.Text = VwBody3[i].BodyName;
                            lblAlt.Text = VwBody3[i].BodyAlt;
                            lblAz.Text = VwBody3[i].BodyAz;
                            bBodyFound = true;
                            break;
                        }
                    }
                }

                if (!bBodyFound)
                {
                    lblBodyName.Text = "";
                }
            }
        }

        public static bool IsBodyInLoc(BodyInfo BodyInf, int locx, int locy)
        {
            if (locx >= BodyInf.BodyLoc.X & locx <= BodyInf.BodyLoc.X + BodyInf.BodyLocSz & locy >= BodyInf.BodyLoc.Y & locy <= BodyInf.BodyLoc.Y + BodyInf.BodyLocSz)
            {
                return true;
            }
            else
            {
                return false;
            }

            return default;
        }

        private void txtMinimumAltitude_TextChanged(object eventSender, EventArgs eventArgs)
        {
            txtMinimumAltitude.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtMinimumAltitude.Text) > 90d) // Or Val(txtMinimumAltitude.Text) < 1 Then     90 was 15
            {
                txtMinimumAltitude.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range", "Entry Error", MessageBoxButtons.OK);
            }

            txtTime_TextChanged(eventSender, eventArgs);
        }

        private void txtMinimumAltitude_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        private void txtMinimumAltitude_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtMinimumAltitude.Text) > 90d) // Or Val(txtMinimumAltitude.Text) < 1 Then     90 was 15
            {
                KeepFocus = true;
                if (string.IsNullOrEmpty(txtMinimumAltitude.Text))
                    KeepFocus = false;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtMinimumAltitude_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtMinimumAltitude;
            SelectAllText(ref argTB);
            txtMinimumAltitude = argTB;
            txtTime_TextChanged(eventSender, eventArgs);
        }

        private void txtTime_TextChanged(object eventSender, EventArgs eventArgs)
        {
        }

        private void txtTime_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
        }

        private void txtTime_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
        }

        private void txtTime_Enter(object eventSender, EventArgs eventArgs)
        {
        }

        private void txtLDeg_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtLDeg.Text) != 90d)
            {
                txtLMin.Enabled = true;
            }

            if (Conversion.Val(txtLDeg.Text) == 90d)
            {
                txtLMin.Text = "";
                txtLMin.Enabled = false;
                txtLMin.BackColor = Color.Gray;
            }

            txtLDeg.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtLDeg.Text) > 90d)
            {
                txtLDeg.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range", "Entry Error", MessageBoxButtons.OK);
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
                ErrorMsgBox("Out of Range", "Entry Error", MessageBoxButtons.OK);
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
                txtLoMin.Text = "";
                txtLoMin.Enabled = false;
                txtLoMin.BackColor = Color.Gray;
            }

            txtLoDeg.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtLoDeg.Text) > 180d | Conversion.Val(txtLoDeg.Text) == 180d & Conversion.Val(txtLoMin.Text) != 0d)
            {
                txtLoDeg.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range", "Entry Error", MessageBoxButtons.OK);
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
                ErrorMsgBox("Out of Range", "Entry Error", MessageBoxButtons.OK);
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

        public bool Twilights()
        {
            j = -1;
            T0 = 6d; // J=-1 am phenomena; T0 is 0600 (6AM) for initial estimate
            H = -18; // am astronomical twilight
            C3[1] = Times();
            H = -12; // am nautical twilight
            C3[2] = Times();
            H = -6; // am civil twilight
            C3[3] = Times();
            H = -0.833d; // sunrise
            C3[4] = Times();
            ZTinSeconds = (int)(3600d * N1 + 60d * C2); // these lines added for azimuth of sunrise
            SRSSAz(ZTinSeconds);
            ZNSR = (float)ZN;
            H = -0.7d; // center of sun on visible horizon
            C3[9] = Times();
            ZTinSeconds = (int)(3600d * N1 + 60d * C2);
            SRSSAz(ZTinSeconds);
            ZNAmpSR = (float)ZN1;
            j = 1;
            T0 = 18d; // J=1 pm phenomena; T0 is 1800 (6PM) for initial estimate
            H = -0.833d; // sunset
            C3[5] = Times();
            ZTinSeconds = (int)(3600d * N1 + 60d * C2); // these lines added for azimuth of sunset
            SRSSAz(ZTinSeconds);
            ZNSS = (float)ZN;
            H = -0.7d; // center of sun on visible horizon
            C3[10] = Times();
            ZTinSeconds = (int)(3600d * N1 + 60d * C2);
            SRSSAz(ZTinSeconds);
            ZNAmpSS = (float)ZN1;
            H = -6; // pm civil twilight
            Times();
            C3[6] = C30;
            H = -12; // pm nautical twilight
            C3[7] = Times();
            H = -18; // pm astronomical twilight
            C3[8] = Times();
            D3[1] = C3[1];
            D3[2] = C3[2];
            D3[3] = C3[3];
            D3[4] = C3[4];
            D3[5] = C3[5];
            D3[6] = C3[6];
            D3[7] = C3[7];
            D3[8] = C3[8];
            D3[9] = C3[9];
            D3[10] = C3[10];
            if ((D3[1] ?? "") == (D3[2] ?? ""))
            {
                C3[1] = "----";
                C3[2] = "----";
            }

            if ((D3[2] ?? "") == (D3[3] ?? ""))
            {
                C3[2] = "----";
                C3[3] = "----";
            }

            if ((D3[3] ?? "") == (D3[4] ?? ""))
            {
                C3[3] = "----";
                C3[4] = "----";
            }

            if ((D3[8] ?? "") == (D3[7] ?? ""))
            {
                C3[8] = "----";
                C3[7] = "----";
            }

            if ((D3[7] ?? "") == (D3[6] ?? ""))
            {
                C3[7] = "----";
                C3[6] = "----";
            }

            if ((D3[6] ?? "") == (D3[5] ?? ""))
            {
                C3[6] = "----";
                C3[5] = "----";
            }

            if ((D3[1] ?? "") == (D3[8] ?? ""))
            {
                C3[1] = "----";
                C3[8] = "----";
            }

            if (C3[4] == "----")
            {
                C3[9] = "----"; // these two lines assume if there is no sunrise or sunset there is no corresponding amplitude
            }

            if (C3[5] == "----")
            {
                C3[10] = "----";
            }

            return true;
        }

        public bool SRSSAz(int ZTSecIn)
        {
            FlagSRSS = true;
            var TSTmp = TimeSpan.FromSeconds(ZTSecIn);
            var DTTmp = new DateTime(DTPlan.Value.Year, DTPlan.Value.Month, DTPlan.Value.Day, TSTmp.Hours, TSTmp.Minutes, TSTmp.Seconds);
            Greenwich(DTTmp);
            Delta_T();
            Julian();
            Obliquity();
            Nutation();
            Aries();
            NY = (JD - 2451545.0d) / 365.2425d;
            Sun();
            GHADec();
            AltAz();
            FlagSRSS = false;
            return true;
        }

        public string Times()
        {
            IC = 0;
        Line2202:
            ;
            if (IC == 4)
            {
                C30 = "----";
                return Conversions.ToString(true);
                return default; // V1.0.5 had IC = 3
            }

            ZTinSeconds = (int)(T0 * 3600d);
            var TSTmp1 = TimeSpan.FromSeconds(ZTinSeconds);
            var DTTmp1 = new DateTime(DTPlan.Value.Year, DTPlan.Value.Month, DTPlan.Value.Day, TSTmp1.Hours, TSTmp1.Minutes, TSTmp1.Seconds);
            Greenwich(DTTmp1);
            Delta_T();
            Julian();
            Nutation();
            Obliquity();
            Aries();
            Sun();
            CT = (Math.Sin(H * Pi / 180d) - Math.Sin(Lat * Pi / 180d) * Math.Sin(DE * Pi / 180d)) / (Math.Cos(Lat * Pi / 180d) * Math.Cos(DE * Pi / 180d));
            if (CT >= 1d)
            {
                TA = 0d;
                goto Line2250;
            }

            if (CT <= -1)
            {
                TA = 180d;
                goto Line2250;
            }

            TA = -Math.Atan(CT / Math.Sqrt(-CT * CT + 1d)) + Pi / 2d;
            TA = TA * 180d / Pi;
        Line2250:
            ;
            T1 = T0 + ZD + (j * TA + Lo - GR + AR) / 15d;
            if (T1 >= 24d + 2d * 0.008000001d | T1 < 0d)
            {
                T1 = T1 - Conversion.Int(T1 / 24d) * 24d; // THIS WAS ORIGINALLY 24, THEN CHANGED TO 25, BUT THAT CAUSED THE PROBLEM FIXED IN V3.4.1, FIXED BY CHANGING BACK TO 24 - NO - FIXED(?) BY MAKING IT (24 + 2*0.008000001)
            }

            if (Math.Abs(T1 - T0) > 0.008000001d)
            {
                T0 = T1;
                IC = (short)(IC + 1);
                goto Line2202;
            }

            V = T1 - ZD;
            if (V < 0d)
            {
                V = V + 24d;
            }

            if (V >= 24d)
            {
                V = V - 24d;
            }

            var TS = TimeSpan.FromHours(V);
            if (TS.Seconds >= 30)
            {
                var TmpTS = new TimeSpan(0, 1, 0);
                TS = TS.Add(TmpTS);
            }

            N1 = TS.Hours;
            C2 = TS.Minutes;
            C30 = N1.ToString("00") + C2.ToString("00");
            return C30;
        }

        public bool Aries()
        {
            HG = UTinSeconds / 3600d;
            TP = (JD - 2451545.0d - HG / 24d) / 36525.0d;
            GR = 6.69737456d + 0.000000000000004d + 2400.051336d * TP;
            GR = GR + 0.0000258622d * TP * TP + 1.002737909d * HG;
            GR = GR * 15d; // convert hours to degrees
            if (GRM[IB] == 60d)
            {
                GRM[IB] = 0d;
                GRD[IB] = GRD[IB] + 1;
            }

            if (GRD[IB] == 360)
            {
                GRD[IB] = 0;
            }

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

            if (VM[IB] == 60d)
            {
                VM[IB] = 0d;
                VD[IB] = VD[IB] + 1;
            }

            if (VD[IB] == 360)
            {
                VD[IB] = 0;
            }

            WD = (short)Conversion.Int(GR);
            WM = (GR - WD) * 60d;
            WM = Conversion.Int(WM * 10d + 0.5d) / 10d;
            if (WM == 60d)
            {
                WM = 0d;
                ;

            }
            WD = (short)(WD + 1);
            if (WD == 360)
            {
                WD = 0;
            }

            QD = (short)Conversion.Int(LR);
            QM = (LR - QD) * 60d;
            QM = Conversion.Int(QM * 10d + 0.5d) / 10d;
            if (QM == 60d)
            {
                QM = 0d;
                QD = (short)(QD + 1);
            }

            if (QD == 360)
            {
                QD = 0;
            }

            return true;
        }

        private void cboLo_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            if (optZDAuto.Checked == true)
                txtZDh.BackColor = Color.Gray;
            AutoZDCalc();
        }

        private void optZDAuto_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (!FormSightPlanLoaded)
                return;
            {
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
            if (!FormSightPlanLoaded)
                return;
            {
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
            if (!FormSightPlanLoaded)
                return;
            {
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

        private void txtZDh_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (optZDAuto.Checked == true | optZDUT.Checked == true)
                txtZDh.BackColor = Color.Gray;
            if (optZDManual.Checked == true)
                txtZDh.BackColor = Control.DefaultBackColor; 
            if (optZDManual.Checked == true & (Conversion.Val(txtZDh.Text) < -14 | Conversion.Val(txtZDh.Text) > 12d))
            {
                txtZDh.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range", "Entry Error", MessageBoxButtons.OK);
            }
        }

        private void txtZDh_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            short KeyAscii = (short)Strings.Asc(eventArgs.KeyChar);
            ;

            bool bMinusSignAlready = false;
            bool bPlusSignAlready = false;
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
                            // Case Asc(".")
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

        public bool AutoZDCalc()
        {
            if (optZDAuto.Checked == true)
            {
                txtZDh.BackColor = Color.Gray;
                Lo = Conversion.Val(txtLoDeg.Text) + Conversion.Val(txtLoMin.Text) / 60d;
                ZD = Conversion.Int(Lo / 15d + 0.5d); // ZD = Round(Lo / 15)
                if (cboLo.Text == "E")
                {
                    ZD = -ZD;
                }

                AutoZD = ZD;
                SignZD = "+";
                if (cboLo.Text == "E")
                {
                    SignZD = "-";
                }

                txtZDh.Text = SignZD + Math.Abs(ZD);
            }

            return true;
        }

        public void DisplayTwilights()
        {
            Shape1.Visible = false;
            // lblAltitude.Visible = False
            // lblAzimuth.Visible = False
            // lblAz.Visible = False
            // lblAlt.Visible = False
            // Label5.Visible = False
            // Label7.Visible = False
            // lblN.Visible = False
            // lblE.Visible = False
            // lblS.Visible = False
            // lblW.Visible = False
            // lblBody.Visible = False
            // lblBodyName.Visible = False
            // chkFirst.Visible = False
            // chkSecond.Visible = False
            // chkThird.Visible = False
            // chkNames.Visible = False
            // chkLimit.Visible = False
            // chkHelper.Visible = False
            // FrameView.Visible = False
            // FrameDirection.Visible = False
            // FrameBest.Visible = False
            // Me.Font = New Font("Arial", 8, FontStyle.Bold)
            // CurrentY = 1100
            // Me.Font = FontChangeBold(Me.Font, True)
            SunTxtBx.Clear();
            SunTxtBx.SelectionAlignment = (System.Windows.Forms.HorizontalAlignment)System.Windows.HorizontalAlignment.Left;
            var argTB = SunTxtBx;
            SetTxtBxBoldOn(ref argTB);
            SunTxtBx = argTB;
            SunTxtBx.AppendText("Sun Rising and Setting Phenomena and Moon Data for " + DTPlan.Value.ToString("dd MMMM yyyy") + " at L " + Strings.Format(Conversion.Val(txtLDeg.Text), "0") + '°' + Strings.Format(Conversion.Val(LMin), "00.0") + "'" + cboL.Text + ", Lo " + Strings.Format(Conversion.Val(txtLoDeg.Text), "0") + '°' + Strings.Format(Conversion.Val(LoMin), "00.0") + "'" + cboLo.Text + Environment.NewLine);
            SunTxtBx.SelectionAlignment = (System.Windows.Forms.HorizontalAlignment)System.Windows.HorizontalAlignment.Center;
            var argTB1 = SunTxtBx;
            SetTxtBxtoReg(ref argTB1);
            SunTxtBx = argTB1;
            // SunTxtBx.AppendText(vbNewLine)
            SunTxtBx.SelectionAlignment = (System.Windows.Forms.HorizontalAlignment)System.Windows.HorizontalAlignment.Left;
            SunTxtBx.SelectionFont = new Font(SunTxtBx.Font, System.Drawing.FontStyle.Underline);
            SunTxtBx.AppendText("Morning Phenomena"); // & vbTab & vbTab &  & vbTab & vbTab & "Approx. ZT" & vbNewLine)
            SunTxtBx.SelectionFont = new Font(SunTxtBx.Font, System.Drawing.FontStyle.Regular);
            SunTxtBx.AppendText(Constants.vbTab + Constants.vbTab);
            SunTxtBx.SelectionFont = new Font(SunTxtBx.Font, System.Drawing.FontStyle.Underline);
            SunTxtBx.AppendText("Approx. ZT");
            SunTxtBx.SelectionFont = new Font(SunTxtBx.Font, System.Drawing.FontStyle.Regular);
            SunTxtBx.AppendText(Constants.vbTab + Constants.vbTab);
            SunTxtBx.SelectionFont = new Font(SunTxtBx.Font, System.Drawing.FontStyle.Underline);
            SunTxtBx.AppendText("Evening Phenomena");
            SunTxtBx.SelectionFont = new Font(SunTxtBx.Font, System.Drawing.FontStyle.Regular);
            SunTxtBx.AppendText(Constants.vbTab + Constants.vbTab);
            SunTxtBx.SelectionFont = new Font(SunTxtBx.Font, System.Drawing.FontStyle.Underline);
            SunTxtBx.AppendText("Approx. ZT");
            SunTxtBx.SelectionFont = new Font(SunTxtBx.Font, System.Drawing.FontStyle.Regular);
            SunTxtBx.AppendText(Environment.NewLine);
            SunTxtBx.AppendText("Start Of AM Astronomical Twilight" + Constants.vbTab + C3[1] + Constants.vbTab + Constants.vbTab + Constants.vbTab + "Sunset" + Constants.vbTab + Constants.vbTab + Constants.vbTab + Constants.vbTab + C3[5]);
            if (C3[5] != "----" & optLimb.Checked == true)
            {
                SunTxtBx.AppendText(" (Zn " + Strings.Format(ZNSS, "000") + "º)");
            }
            else
            {
                // nothing
            }

            if (C3[5] != "----" & optCenter.Checked == true)
            {
                SunTxtBx.AppendText(" (Zn " + Strings.Format(ZNAmpSS, "000") + "º)");
            }
            else
            {
                // nothing
            }

            SunTxtBx.AppendText(Environment.NewLine);
            SunTxtBx.AppendText("Start Of AM Nautical Twilight" + Constants.vbTab + Constants.vbTab + C3[2] + Constants.vbTab + Constants.vbTab + Constants.vbTab + "End Of PM Civil Twilight" + Constants.vbTab + Constants.vbTab + C3[6] + Environment.NewLine);
            SunTxtBx.AppendText("Start Of AM Civil Twilight" + Constants.vbTab + Constants.vbTab + C3[3] + Constants.vbTab + Constants.vbTab + Constants.vbTab + "End Of PM Nautical Twilight" + Constants.vbTab + Constants.vbTab + C3[7] + Environment.NewLine);
            // Print("Start of AM Civil Twilight", TAB(44), C3(3), TAB(80), "End of PM Nautical Twilight", TAB(124), C3(7))
            SunTxtBx.AppendText("Sunrise" + Constants.vbTab + Constants.vbTab + Constants.vbTab + Constants.vbTab + C3[4]);
            if (C3[4] != "----" & optLimb.Checked == true)
            {
                SunTxtBx.AppendText(" (Zn " + Strings.Format(ZNSR, "000") + "º)"); // was "000" before V5.1.5
            }
            else
            {
                SunTxtBx.AppendText(Constants.vbTab);
            }

            if (C3[4] != "----" & optCenter.Checked == true)
            {
                SunTxtBx.AppendText(" (Zn " + Strings.Format(ZNAmpSR, "000") + "º)");
            }
            else
            {
                SunTxtBx.AppendText(Constants.vbTab);
            }

            // If C3(4) <> "----" Then Print " (Zn "; Strings.format(ZNAmpSR, "000.0"); "º)";

            SunTxtBx.AppendText(Constants.vbTab + "End Of PM Astronomical Twilight" + Constants.vbTab + C3[8]);
            lblEnterTime.Visible = true;
            lblEnterTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;    //System.Drawing.SystemColors.ButtonHighlight    //
            txtTime.Visible = true;
            // txtTime.Enabled = True
            txtTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;    //
            lblMinimumAltitude.Visible = true;
            txtMinimumAltitude.Visible = true;
            lblAz1.Visible = true;
            lblAzDeg.Visible = true;
            Label2.Visible = true;
            Label3.Visible = true;
            txtLowAz.Visible = true;
            txtHighAz.Visible = true;
            lblAltDeg.Visible = true;
            // txtTime.Text = ""
            Plan1TabCntl.Visible = true;
            if (!string.IsNullOrEmpty(txtTime.Text))
            {
                SelectTabToDisplay();
            }
        }

        public void LatLong()
        {
            // Next two lines for problem with commas as decimal points in Europe with Favorite Places, etc.
            LMin = Strings.Replace(txtLMin.Text, ",", ".");
            LoMin = Strings.Replace(txtLoMin.Text, ",", ".");
            Lat = Conversion.Val(txtLDeg.Text) + Conversion.Val(LMin) / 60d;
            if (Lat == 90d)
                Lat = 89.999999999d;
            if (cboL.Text == "S")
                Lat = -Lat;
            Lo = Conversion.Val(txtLoDeg.Text) + Conversion.Val(LoMin) / 60d;
            if (cboLo.Text == "E")
                Lo = -Lo;
        }

        public bool Greenwich(DateTime DTin)
        {
            // Prefix (or suffix) G for Greenwich, UT = Universal Time
            var DayG = new short[13];
            MonthDays = "312831303130313130313031";
            // Check for local leap year
            LocalYear = (short)DTin.Year;
            LeapYear = DateTime.IsLeapYear(DTin.Year);
            // If DateTime.IsLeapYear(DTIn.Year) Then
            // LeapYear = True
            // End If
            // If (LocalYear Mod 4) = 0 Then LeapYear = True
            // If (LocalYear Mod 100) = 0 And (LocalYear Mod 400) <> 0 Then
            // LeapYear = False
            // End If 
            if (LeapYear == true)
            {
                MonthDays = "312931303130313130313031";
            }
            else
            {
                MonthDays = "312831303130313130313031";
            }

            MonthNumber = (short)DTin.Month; // cboMonth.SelectedIndex + 1
            DayNumber = 0; // DTIn.DayOfYear
            var loopTo = (short)(MonthNumber - 1);
            for (i = 1; i <= loopTo; i++)
                DayNumber = (short)(DayNumber + Conversion.Val(Strings.Mid(MonthDays, 2 * i - 1, 2))); // + DayNumber
                                                                                                       // If MonthNumber >= 3 And LeapYear = True Then DayNumber = DayNumber + 1
            DayNumber = (short)(DayNumber + DTin.Day); // Val(cboDay.Text)
            ZD = Math.Abs(Conversion.Val(txtZDh.Text));
            if (optZDManual.Checked == true)
            {
                ZD = Math.Abs(ZD) + Conversion.Val(cboZDm.Text) / 60d;
            }
            // If Val(txtZDh.Text) < 0 Then ZD = -ZD
            if (Strings.Left(txtZDh.Text, 1) == "-")
            {
                ZD = -ZD;
            }
            // ''''If Sgn(Val(txtZDh.Text)) = -1 Then ZD = -ZD
            if (chkDST.Checked == true & MoonFlag == false)
            {
                ZD = ZD - 1d;
            }

            ZDinSeconds = (int)(3600d * ZD);
            UTinSeconds = ZTinSeconds + ZDinSeconds;
            var ts = TimeSpan.FromSeconds(UTinSeconds);
            GHour = (short)ts.Hours;
            GMinute = ts.Minutes;
            GSecond = ts.Seconds;

            // GHour = UTinSeconds / 3600
            // GMinute = (UTinSeconds - (GHour * 3600)) / 60
            // GSecond = UTinSeconds = GHour * 3600 - GMinute * 60
            // GMinute = Int((UTinSeconds - CInt(GHour) * 3600) / 60)
            // GSecond = UTinSeconds - CInt(GHour) * 3600 - GMinute * 60

            GYear = (short)DTin.Year;
            GDayOfYear = DayNumber;

            // If GHour >= 24 Then
            // GHour = GHour - 24
            // GDayOfYear = GDayOfYear + 1
            // End If
            // If (GDayOfYear = 366 And LeapYear = False) Or GDayOfYear = 367 Then
            // GDayOfYear = 1
            // GYear = GYear + 1
            // GoTo GreenwichDate
            // End If
            // If GHour < 0 Then
            // GHour = GHour + 24
            // GDayOfYear = GDayOfYear - 1
            // End If
            // If GDayOfYear = 0 Then GYear = GYear - 1

            GLeapYear = DateTime.IsLeapYear(GYear);

        // Check for leap year at Greenwich
        // If (GYear Mod 4) = 0 Then GLeapYear = True
        // If (GYear Mod 100) = 0 And (GYear Mod 400) <> 0 Then GLeapYear = False
        // Days in year
        // If GDayOfYear = 0 And GLeapYear = False Then GDayOfYear = 365
        // If GDayOfYear = 0 And GLeapYear = True Then GDayOfYear = 366

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

            // MonthList$ = "JanFebMarAprMayJunJulAugSepOctNovDec"
            MonthatG = MonthList[GMonth - 1].ToString();
            return true;
        }

        public bool Julian()
        {
            DecimalDate = GDay + GHour / 24d + GMinute / 1440d + GSecond / 86400.0f;
            GYearJ = GYear;
            if (GMonth < 3)
            {
                GYearJ = (short)(GYear - 1);
                GMonth = (short)(GMonth + 12);
            }

            JD = Conversion.Int(365.25d * (GYearJ + 4716)) + Conversion.Int(30.6001d * (GMonth + 1)) + DecimalDate - 1537.5d;
            if (BN == 58)
            {
                T = (JD - 2451545d) / 36525.0d;
            }
            else
            {
                T = (JD - 2451545d + DeltaT / 86400d) / 36525.0d;
            }

            return true;
        }

        public bool Obliquity()
        {
            // Obliquity of the ecliptic
            OE = 84381.448d - 46.816d * T - 0.00059d * T * T + 0.001813d * T * T * T; // Mean obliquity of ecliptic, arcseconds
            OE = OE / 3600d; // degrees
            OETrue = OE + NO; // degrees
            return true;
        }

        public bool Nutation()
        {
            // Nutation
            NL = 0d;
            NO = 0d;
            NutD = 297.85036d + 445267.11148d * T - 0.0019142d * T * T + T * T * T / 189474d; // mean elongation of moon from sun, degrees
            if (NutD >= 360d | NutD < 0d)
            {
                NutD = NutD - Conversion.Int(NutD / 360d) * 360d;
            }

            NutD = NutD * Pi / 180d; // radians
            NutM = 357.52772d + 35999.05034d * T - 0.0001603d * T * T - T * T * T / 300000d; // mean anomaly of the sun (Earth), degrees
            if (NutM >= 360d | NutM < 0d)
            {
                NutM = NutM - Conversion.Int(NutM / 360d) * 360d;
            }

            NutM = NutM * Pi / 180d; // radians
            NutMprime = 134.96298d + 477198.867398d * T + 0.0086972d * T * T + T * T * T / 56250d; // mean anomaly of the moon, degrees
            if (NutMprime >= 360d | NutMprime < 0d)
            {
                NutMprime = NutMprime - Conversion.Int(NutMprime / 360d) * 360d;
            }

            NutMprime = NutMprime * Pi / 180d; // radians
            NutF = 93.27191d + 483202.017538d * T - 0.0036825d * T * T + T * T * T / 327270d; // moon's argument of latitude, degrees
            if (NutF >= 360d | NutF < 0d)
            {
                NutF = NutF - Conversion.Int(NutF / 360d) * 360d;
            }

            NutF = NutF * Pi / 180d; // radians
            NutOmega = 125.04452d - 1934.136261d * T + 0.0020708d * T * T + T * T * T / 450000d; // longitude of ascending node of moon..., degrees
            if (NutOmega >= 360d | NutOmega < 0d)
            {
                NutOmega = NutOmega - Conversion.Int(NutOmega / 360d) * 360d;
            }

            NutOmega = NutOmega * Pi / 180d; // radians
            for (i = 0; i <= 62; i++)
            {
                NL = NL + (NSin[i] + NSinT[i] * T) * Math.Sin(ND[i] * NutD + NM[i] * NutM + NMprime[i] * NutMprime + NF[i] * NutF + NOmega[i] * NutOmega); // arcseconds x 10000
                NO = NO + (NCos[i] + NCosT[i] * T) * Math.Cos(ND[i] * NutD + NM[i] * NutM + NMprime[i] * NutMprime + NF[i] * NutF + NOmega[i] * NutOmega); // arcseconds x 10000
            }

            NL = NL / 10000d / 3600d; // degrees
            NO = NO / 10000d / 3600d; // degrees
            return true;
        }

        public void Sun()
        {
            Ecc = 0.016708634d - 0.000042037d * T - 0.0000001267d * T * T; // Ecc of Earth's orbit oO0
            MS = 357.52911d + 35999.05029d * T - 0.0001537d * T * T; // mean anomaly of Sun, degrees
                                                                     // MS=357.52772 + 35999.05034 * T + 0.0001603 * T * T +T*T*T/30000                   'mean anomaly of Sun, degrees
            if (MS >= 360d | MS < 0d)
            {
                MS = MS - Conversion.Int(MS / 360d) * 360d;
            }

            C = (1.914602d - 0.004817d * T - 0.000014d * T * T) * Math.Sin(MS * Pi / 180d) + (0.019993d - 0.000101d * T) * Math.Sin(2d * MS * Pi / 180d) + 0.000289d * Math.Sin(3d * MS * Pi / 180d); // center of Sun, degrees
            NU = MS + C; // Sun's true anomaly, degrees
            RN = 1.000001018d * (1d - Ecc * Ecc) / (1d + Ecc * Math.Cos(NU * Pi / 180d)); // Sun's radius vector (distance between centers of Sun and Earth), astronomical units
            L0 = 280.46646d + 36000.76983d * T + 0.0003032d * T * T; // geometric mean longitude of Sun, degrees
            if (L0 >= 360d | L0 < 0d)
            {
                L0 = L0 - Conversion.Int(L0 / 360d) * 360d;
            }

            LN = L0 + C; // Sun's true longitude, degrees
            if (TwilightFlag == false & BN != 58)
            {
                return; // do not go further if not twilights and not sun sight
            }

            if (TwilightFlag == true & BN >= 60 & BN <= 63)
            {
                return; // do not go further if twilights and planets
            }

            if (BodiesFlag == true & TwilightFlag == true & BN <= 57)
            {
                return; // want this line only for list, not for twilights
            }

            T = T / 10d;
            // Compute heliocentric, ecliptical Longitude L in radians
            LH = EarthFunctions.Earth_L01(ref T) + EarthFunctions.Earth_L02(ref T) + EarthFunctions.Earth_L11(ref T) + EarthFunctions.Earth_L21(ref T) + EarthFunctions.Earth_L31(ref T) + EarthFunctions.Earth_L41(ref T) + EarthFunctions.Earth_L51(ref T); // radians
            if (Math.Abs(LH) > 2d * Pi)
            {
                LH = LH - 2d * Pi * Conversion.Int(LH / 2d / Pi);
            }
            // Compute heliocentric, ecliptical Latitude B in radians
            B = EarthFunctions.Earth_B01(ref T) + EarthFunctions.Earth_B11(ref T) + EarthFunctions.Earth_B21(ref T) + EarthFunctions.Earth_B31(ref T) + EarthFunctions.Earth_B41(ref T); // radians
                                                                                                                                                                                         // Compute heliocentric distance r in AU
            r = EarthFunctions.Earth_R01(ref T) + EarthFunctions.Earth_R02(ref T) + EarthFunctions.Earth_R11(ref T) + EarthFunctions.Earth_R21(ref T) + EarthFunctions.Earth_R31(ref T) + EarthFunctions.Earth_R41(ref T) + EarthFunctions.Earth_R51(ref T);
            L1 = LH + Pi; // geocentric longitude, radians
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
            T = 10d * T;
        }

        public bool EclipticToEquatorial()
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
            return true;
        }

        public bool SolarSystem()
        {
            I1 = 0;
            // PlanOrbEl
            for (BN = 58; BN <= 63; BN++)
            {
                if (BN == 58)
                {
                    Sun();
                    Mag[58] = (-26.8d).ToString();
                }
                // GoTo Line2406
                // End If 'sun
                else if (BN == 59)
                {
                    T = (JD - 2451545d) / 36525d;
                    Moon();
                    MoonPhase();
                    Mag[59] = KK + "% ill.";
                }
                // GoTo Line2406
                // End If 'moon
                else
                {
                    Planets(); // planets
                    PlanetMags();
                }

            Line2406:
                ;
                IB = BN - 57;
                GHADec();
                AltAz();
                if (Ho > 0d)
                {
                    First_Mag();
                }
            }

            return true;
        }

        public bool Moon()
        {
            // T = (JD - 2451545) / 36525
            MLprime = 218.3164477d + 481267.88123421d * T - 0.0015786d * T * T + T * T * T / 538841d - T * T * T * T / 65194000d; // Moon's mean longitude, degrees
            if (MLprime >= 360d | MLprime < 0d)
            {
                MLprime = MLprime - Conversion.Int(MLprime / 360d) * 360d;
            }

            MLprime = MLprime * Pi / 180d;
            MD = 297.8501921d + 445267.1114034d * T - 0.0018819d * T * T + T * T * T / 545868d - T * T * T * T / 113065000d; // Moon's mean elongation, degrees
            if (MD >= 360d | MD < 0d)
            {
                MD = MD - Conversion.Int(MD / 360d) * 360d;
            }

            MD = MD * Pi / 180d; // radians
            MM = 357.5291092d + 35999.0502909d * T - 0.0001536d * T * T + T * T * T / 24490000d; // Sun's mean anomaly, degrees
            if (MM >= 360d | MM < 0d)
            {
                MM = MM - Conversion.Int(MM / 360d) * 360d;
            }

            MM = MM * Pi / 180d; // radians
            MMprime = 134.9633964d + 477198.8675055d * T + 0.0087414d * T * T + T * T * T / 69699d - T * T * T * T / 14712000d; // Moon's mean anomaly, degrees
            if (MMprime >= 360d | MMprime < 0d)
            {
                MMprime = MMprime - Conversion.Int(MMprime / 360d) * 360d;
            }

            MMprime = MMprime * Pi / 180d; // radians
            MF = 93.272095d + 483202.0175233d * T - 0.0036539d * T * T - T * T * T / 3526000d + T * T * T * T / 863310000d; // Moon's argument of altitude, degrees
            if (MF >= 360d | MF < 0d)
            {
                MF = MF - Conversion.Int(MF / 360d) * 360d;
            }

            MF = MF * Pi / 180d; // radians
            A1 = 119.75d + 131.849d * T; // degrees
            if (A1 >= 360d | A1 < 0d)
            {
                A1 = A1 - Conversion.Int(A1 / 360d) * 360d;
            }

            A1 = A1 * Pi / 180d; // radians
            A2 = 53.09d + 479264.29d * T; // degrees
            if (A2 >= 360d | A2 < 0d)
            {
                A2 = A2 - Conversion.Int(A2 / 360d) * 360d;
            }

            A2 = A2 * Pi / 180d; // radians
            A3 = 313.45d + 481266.484d * T; // degrees
            if (A3 >= 360d | A3 < 0d)
            {
                A3 = A3 - Conversion.Int(A3 / 360d) * 360d;
            }

            A3 = A3 * Pi / 180d; // radians
            E = 1d - 0.002516d * T - 0.0000074d * T * T;
            SigmaL = 0d;
            SigmaR = 0d;
            SigmaB = 0d;
            for (i = 0; i <= 59; i++)
            {
                KA = 1d;
                KB = 1d;
                if (MMA[i] == 1 | MMA[i] == -1)
                    KA = E;
                if (MMB[i] == 1 | MMB[i] == -1)
                    KB = E;
                if (MMA[i] == 2 | MMA[i] == -2)
                    KA = E * E;
                if (MMB[i] == 2 | MMB[i] == -2)
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
            HP = HP * 180d / Pi * 60d; // arcminutes
            L1 = L1 + NL; // apparent longitude
            L1 = L1 * Pi / 180d;
            B = B * Pi / 180d;
            EclipticToEquatorial();
            AR = AR * 180d / Pi; // for Meeus ecl-to-eq
            DE = DE * 180d / Pi; // for Meeus ecl-to-eq
            return true;
        }

        public bool Planets()
        {
            // L is heliocentric, ecliptic longitude, radians
            // B is heliocentric, ecliptic latitude, radians
            // r is heliocentric distance, astronomical units
            Delta = 0d;
            Tau = 0d;
            T = T / 10d;
            // For BN = 60 To 63
            for (i = 1; i <= 3; i++)
            {
                if (i > 1)
                {
                    T = (JD - 2451545d - Tau) / 365250d;
                }

                if (BN == 60)
                {
                    L = VenusFunctions.Venus_L01(ref T) + VenusFunctions.Venus_L11(ref T) + VenusFunctions.Venus_L21(ref T) + VenusFunctions.Venus_L31(ref T) + VenusFunctions.Venus_L41(ref T) + VenusFunctions.Venus_L51(ref T);
                    if (Math.Abs(L) > 2d * Pi)
                    {
                        L = L - 2d * Pi * Conversion.Int(L / 2d / Pi);
                    }

                    B = VenusFunctions.Venus_B01(ref T) + VenusFunctions.Venus_B11(ref T) + VenusFunctions.Venus_B21(ref T) + VenusFunctions.Venus_B31(ref T) + VenusFunctions.Venus_B41(ref T) + VenusFunctions.Venus_B51(ref T);
                    r = VenusFunctions.Venus_R01(ref T) + VenusFunctions.Venus_R11(ref T) + VenusFunctions.Venus_R21(ref T) + VenusFunctions.Venus_R31(ref T) + VenusFunctions.Venus_R41(ref T) + VenusFunctions.Venus_R51(ref T);
                }

                if (BN == 61)
                {
                    L = MarsFunctions.Mars_L01(ref T) + MarsFunctions.Mars_L02(ref T) + MarsFunctions.Mars_L03(ref T) + MarsFunctions.Mars_L11(ref T) + MarsFunctions.Mars_L12(ref T) + MarsFunctions.Mars_L21(ref T) + MarsFunctions.Mars_L31(ref T) + MarsFunctions.Mars_L41(ref T) + MarsFunctions.Mars_L51(ref T);
                    if (Math.Abs(L) > 2d * Pi)
                    {
                        L = L - 2d * Pi * Conversion.Int(L / 2d / Pi);
                    }

                    B = MarsFunctions.Mars_B01(ref T) + MarsFunctions.Mars_B11(ref T) + MarsFunctions.Mars_B21(ref T) + MarsFunctions.Mars_B31(ref T) + MarsFunctions.Mars_B41(ref T) + MarsFunctions.Mars_B51(ref T);
                    r = MarsFunctions.Mars_R01(ref T) + MarsFunctions.Mars_R02(ref T) + MarsFunctions.Mars_R03(ref T) + MarsFunctions.Mars_R11(ref T) + MarsFunctions.Mars_R12(ref T) + MarsFunctions.Mars_R21(ref T) + MarsFunctions.Mars_R31(ref T) + MarsFunctions.Mars_R41(ref T) + MarsFunctions.Mars_R51(ref T);
                }

                if (BN == 62)
                {
                    object localJupiter_L51() { object argT = T; var ret = JupiterFunctions.Jupiter_L51(ref argT); return ret; }

                    L = Conversions.ToDouble(Operators.AddObject(JupiterFunctions.Jupiter_L01(ref T) + JupiterFunctions.Jupiter_L02(ref T) + JupiterFunctions.Jupiter_L11(ref T) + JupiterFunctions.Jupiter_L21(ref T) + JupiterFunctions.Jupiter_L31(ref T) + JupiterFunctions.Jupiter_L41(ref T), localJupiter_L51()));
                    if (Math.Abs(L) > 2d * Pi)
                    {
                        L = L - 2d * Pi * Conversion.Int(L / 2d / Pi);
                    }

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

                if (BN == 63)
                {
                    L = SaturnFunctions.Saturn_L01(ref T) + SaturnFunctions.Saturn_L02(ref T) + SaturnFunctions.Saturn_L03(ref T) + SaturnFunctions.Saturn_L11(ref T) + SaturnFunctions.Saturn_L12(ref T) + SaturnFunctions.Saturn_L21(ref T) + SaturnFunctions.Saturn_L31(ref T) + SaturnFunctions.Saturn_L41(ref T) + SaturnFunctions.Saturn_L51(ref T);
                    if (Math.Abs(L) > 2d * Pi)
                    {
                        L = L - 2d * Pi * Conversion.Int(L / 2d / Pi);
                    }

                    B = SaturnFunctions.Saturn_B01(ref T) + SaturnFunctions.Saturn_B02(ref T) + SaturnFunctions.Saturn_B11(ref T) + SaturnFunctions.Saturn_B21(ref T) + SaturnFunctions.Saturn_B31(ref T) + SaturnFunctions.Saturn_B41(ref T) + SaturnFunctions.Saturn_B51(ref T);
                    r = SaturnFunctions.Saturn_R01(ref T) + SaturnFunctions.Saturn_R02(ref T) + SaturnFunctions.Saturn_R03(ref T) + SaturnFunctions.Saturn_R11(ref T) + SaturnFunctions.Saturn_R12(ref T) + SaturnFunctions.Saturn_R21(ref T) + SaturnFunctions.Saturn_R31(ref T) + SaturnFunctions.Saturn_R41(ref T) + SaturnFunctions.Saturn_R51(ref T);
                }
                // convert from heliocentric to geocentric coordinates
                if (i == 1)
                {
                    L0 = EarthFunctions.Earth_L01(ref T) + EarthFunctions.Earth_L02(ref T) + EarthFunctions.Earth_L11(ref T) + EarthFunctions.Earth_L21(ref T) + EarthFunctions.Earth_L31(ref T) + EarthFunctions.Earth_L41(ref T) + EarthFunctions.Earth_L51(ref T);
                    // L0Sun = L0
                    if (Math.Abs(L0) > 2d * Pi)
                    {
                        L0 = L0 - 2d * Pi * Conversion.Int(L0 / 2d / Pi);
                    }

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
            {
                x = 9.999999E-21d;
            }

            L1 = Math.Atan(y / x); // geocentric longitude, radians
            if (x < 0d)
            {
                L1 = L1 + Pi;
            }

            if (L1 >= 2d * Pi | L1 < 0d)
            {
                L1 = L1 - Conversion.Int(L1 / (2d * Pi)) * 2d * Pi;
            }

            B = Math.Atan(Z / Math.Sqrt(x * x + y * y)); // geocentric latitude, radians

            // Back to normal times
            T = T * 10d;
            // Apply Aberration
            Sun(); // for LN, Ecc needed in AberrationLB


            // LN = L0Sun
            AberrationLB();
            L1 = L1 + AberrL * Pi / 180d; // radians
            B = B + AberrB * Pi / 180d; // radians    'IS THIS LINE NEEDED????????????????????????????????????

            // apply nutation in longitude and obliquity; NL and NO come in as degrees
            L1 = L1 + NL * Pi / 180d; // apparent longitude
            xmag = x; // used in PlanetMags so x does not get changed by EclipticToEquatorial
            EclipticToEquatorial();
            AR = AR * 180d / Pi;
            DE = DE * 180d / Pi;
            return true;
        }

        private void PlanetMags()
        {
            cosi = (xmag * Math.Cos(B) * Math.Cos(L) + y * Math.Cos(B) * Math.Sin(L) + Z * Math.Sin(B)) / Delta;
            x = -cosi * cosi + 1d;
            if (x <= 0d)
            {
                x = 9.999999E-21d;
            }

            PhaseAngle = Math.Atan(-cosi / Math.Sqrt(x)) + Pi / 2d; // phase angle, arc cosine
            PhaseAngle = PhaseAngle * 180d / Pi;
            if (GYear >= 1984)
            {
                if (BN == 60)
                    Mag[BN] = (-4.4d + 5d * Math.Log(r * Delta) / Math.Log(10d) + 0.0009d * PhaseAngle + 0.000239d * PhaseAngle * PhaseAngle - 0.00000065d * PhaseAngle * PhaseAngle * PhaseAngle).ToString();
                if (BN == 61)
                    Mag[BN] = (-1.52d + 5d * Math.Log(r * Delta) / Math.Log(10d) + 0.016d * PhaseAngle).ToString();
                if (BN == 62)
                    Mag[BN] = (-9.4d + 5d * Math.Log(r * Delta) / Math.Log(10d) + 0.005d * PhaseAngle).ToString();
                if (BN == 63)
                    Mag[BN] = (-8.88d + 5d * Math.Log(r * Delta) / Math.Log(10d) + 0.044d * PhaseAngle - 2.6d * Math.Sin(17d * Pi / 180d) + 1.25d * Math.Sin(17d * Pi / 180d) * Math.Sin(17d * Pi / 180d)).ToString(); // Gross approximation
            }

            if (GYear < 1984)
            {
                if (BN == 60)
                    Mag[BN] = (-4 + 5d * Math.Log(r * Delta) / Math.Log(10d) + 0.01322d * PhaseAngle - 0.0000004247d * PhaseAngle * PhaseAngle * PhaseAngle).ToString();
                if (BN == 61)
                    Mag[BN] = (-1.3d + 5d * Math.Log(r * Delta) / Math.Log(10d) + 0.01486d * PhaseAngle).ToString();
                if (BN == 62)
                    Mag[BN] = (-8.93d + 5d * Math.Log(r * Delta) / Math.Log(10d)).ToString();
                if (BN == 63)
                    Mag[BN] = (-8.68d + 5d * Math.Log(r * Delta) / Math.Log(10d) + 0.044d * PhaseAngle - 2.6d * Math.Sin(17d * Pi / 180d) + 1.25d * Math.Sin(17d * Pi / 180d) * Math.Sin(17d * Pi / 180d)).ToString(); // Gross approximation
            }

            Mag[BN] = (Conversion.Int(Conversions.ToDouble(Mag[BN]) * 10d + 0.5d) / 10d).ToString();
            SM = Math.Sign(Conversion.Val(Mag[BN]));
            Mag[BN] = (10.01d + Math.Abs(Conversion.Val(Mag[BN]))).ToString();
            if (SM == 1)
                Mag[BN] = " " + Strings.Mid(Conversion.Str(Mag[BN]), 3, 3);
            if (SM == -1)
                Mag[BN] = "-" + Strings.Mid(Conversion.Str(Mag[BN]), 3, 3);
            if (SM == 0)
                Mag[BN] = " 0.0";
        }

        public bool GHADec()
        {
            SH[IB] = 360d - AR;
            GA[IB] = GR - AR;
            if (GA[IB] >= 360d | GA[IB] < 0d)
            {
                GA[IB] = GA[IB] - Conversion.Int(GA[IB] / 360d) * 360d;
            }

            SH[IB] = Conversion.Int(SH[IB] * 10d + 0.5d) / 10d;
            GRD[IB] = (int)Conversion.Int(AR);
            GRM[IB] = (AR - GRD[IB]) * 60d;
            GRM[IB] = Conversion.Int(GRM[IB] * 10d + 0.5d) / 10d;
            if (GRM[IB] == 60d)
            {
                GRM[IB] = 0d;
                GRD[IB] = GRD[IB] + 1;
            }

            RA[IB] = Conversion.Int(AR * 10d + 0.5d) / 10d;
            if (DE == 0d)
            {
                HD[IB] = " ";
            }

            if (DE > 0d)
            {
                HD[IB] = CommonGlobals.g_LatN;
            }

            if (DE < 0d)
            {
                HD[IB] = CommonGlobals.g_LatS;
            }

            DF[IB] = Conversion.Int(Math.Abs(DE) * 10d + 0.5d) / 10d;
            VD[IB] = (int)Conversion.Int(GA[IB]);
            VM[IB] = (GA[IB] - VD[IB]) * 60d;
            VM[IB] = Conversion.Int(VM[IB] * 10d + 0.5d) / 10d;
            if (VM[IB] == 60d)
            {
                VM[IB] = 0d;
                VD[IB] = VD[IB] + 1;
            }

            if (VD[IB] == 360)
            {
                VD[IB] = 0;
            }

            return true;
        }

        public bool AltAz()
        {
            SQ = Math.Sin(DE * Pi / 180d) * Math.Sin(Lat * Pi / 180d) + Math.Cos(DE * Pi / 180d) * Math.Cos(Lat * Pi / 180d) * Math.Cos((GR - Lo - AR) * Pi / 180d);
            q = Math.Atan(SQ / (Math.Sqrt(-SQ * SQ + 1d) + 9.999999E-21d));
            if (TwilightFlag == false & q < 0d)
            {
                Ho = -1;
                return true;
                return default;
            }

            A = Math.Cos(Lat * Pi / 180d) * Math.Cos(q);
            if (A < 9.999999E-21d)
            {
                A = 9.999999E-21d;
            }

            CP = (Math.Sin(DE * Pi / 180d) - Math.Sin(Lat * Pi / 180d) * SQ) / A;
            if (CP > 1d)
            {
                CP = 1d; // added in V5.4.0 to avoid Dec. 21 90ºN type of error
            }

            if (CP < -1)
            {
                CP = -1; // added in V5.4.0 to avoid Dec. 21 90ºN type of error
            }

            PZ = Math.Atan(-CP / (Math.Sqrt(-CP * CP + 1d) + 9.999999E-21d)) + Pi / 2d;
            if (Math.Sin((GR - Lo - AR) * Pi / 180d) > 0d)
                PZ = 2d * Pi - PZ;
            ZN = PZ * 180d / Pi;
            Ho = q * 180d / Pi;
            Ho = Conversion.Int(Ho + 0.5d);
            ZN1 = Conversion.Int(ZN * 10d + 0.5d) / 10d;
            if (FlagSRSS == true)
                ZN = ZN1;
            else
                ZN = Conversion.Int(ZN + 0.5d);    // V5.6.2
            return true;
        }

        public bool Stars1()
        {
            I2 = 0;
            I3 = 0; // stars
            for (BN = 0; BN <= 57; BN++)
            {
                Stars2();
                AltAz();
                MV = (float)Conversion.Val(Mag[BN]);
                if (Ho > 0d & MV < 1.55d)
                {
                    First_Mag();
                }

                if (Ho > 0d & MV > 1.55d & MV < 2.55d)
                {
                    Second_Mag();
                }

                if (Ho > 0d & MV > 2.55d)
                {
                    Third_Mag();
                }
            }

            return true;
        }

        public bool Stars2()
        {
            AR = RAStars[BN];
            DE = DecStars[BN];
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
            return true;
        }

        public bool Sorting()
        {
            if (I1 <= 1)
            {
                goto Line2720;
            }

            var loopTo = (short)(I1 - 1);
            for (i = 1; i <= loopTo; i++)
            {
                P = i;
                var loopTo1 = I1;
                for (IJ = (short)(i + 1); IJ <= loopTo1; IJ++)
                {
                    if (Z1[P] > Z1[IJ])
                        P = IJ;
                }

                TZ = Z1[i];
                Z1[i] = Z1[P];
                Z1[P] = TZ;
                TB = Body1[i];
                Body1[i] = Body1[P];
                Body1[P] = TB;
                TM = Mag1[i];
                Mag1[i] = Mag1[P];
                Mag1[P] = TM;
                TH = H1A[i];
                H1A[i] = H1A[P];
                H1A[P] = TH;
            }

        Line2720:
            ;
            if (I2 <= 1)
            {
                goto Line2740;
            }

            var loopTo2 = (short)(I2 - 1);
            for (i = 1; i <= loopTo2; i++)
            {
                P = i;
                var loopTo3 = I2;
                for (IJ = (short)(i + 1); IJ <= loopTo3; IJ++)
                {
                    if (Z2[P] > Z2[IJ])
                        P = IJ;
                }

                TZ = Z2[i];
                Z2[i] = Z2[P];
                Z2[P] = TZ;
                TB = Body2[i];
                Body2[i] = Body2[P];
                Body2[P] = TB;
                TM = Mag2[i];
                Mag2[i] = Mag2[P];
                Mag2[P] = TM;
                TH = H2A[i];
                H2A[i] = H2A[P];
                H2A[P] = TH;
            }

        Line2740:
            ;
            if (I3 <= 1)
            {
                goto Line2760;
            }

            var loopTo4 = (short)(I3 - 1);
            for (i = 1; i <= loopTo4; i++)
            {
                P = i;
                var loopTo5 = I3;
                for (IJ = (short)(i + 1); IJ <= loopTo5; IJ++)
                {
                    if (Z3[P] > Z3[IJ])
                        P = IJ;
                }

                TZ = Z3[i];
                Z3[i] = Z3[P];
                Z3[P] = TZ;
                TB = Body3[i];
                Body3[i] = Body3[P];
                Body3[P] = TB;
                TM = Mag3[i];
                Mag3[i] = Mag3[P];
                Mag3[P] = TM;
                TH = H3A[i];
                H3A[i] = H3A[P];
                H3A[P] = TH;
            }

        Line2760:
            ;
            var loopTo6 = I1;
            for (i = 1; i <= loopTo6; i++)
                Z1[i] = Conversions.ToDouble(Strings.Right(Conversion.Str(1000d + Z1[i]), 3));
            var loopTo7 = I2;
            for (i = 1; i <= loopTo7; i++)
                Z2[i] = Conversions.ToDouble(Strings.Right(Conversion.Str(1000d + Z2[i]), 3));
            var loopTo8 = I3;
            for (i = 1; i <= loopTo8; i++)
                Z3[i] = Conversions.ToDouble(Strings.Right(Conversion.Str(1000d + Z3[i]), 3));
            return true;
        }

        public void DisplayFirst()
        {
            var Mag1Hdr = new[] { "Body", "Zn" + '°', "h" + '°', "Mag." };
            var DataSet1 = new DataSet();
            DataSet1.Tables.Add("Table1");
            DataSet1.DataSetName = "Table1";
            DGMag1.DataSource = DataSet1;
            for (int i = 0, loopTo = Information.UBound(Mag1Hdr); i <= loopTo; i++)
            {
                DataSet1.Tables["Table1"].Columns.Add(Mag1Hdr[i]);
                DataSet1.Tables["Table1"].Columns[i].AllowDBNull = false;
                DataSet1.Tables["Table1"].Columns[i].DefaultValue = "";
            }

            DGMag1.DataSource = DataSet1.Tables[0].DefaultView;
            for (int i = 0, loopTo1 = DGMag1.Columns.Count - 1; i <= loopTo1; i++)
            {
                DGMag1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DGMag1.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGMag1.Columns[i].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                DGMag1.Columns[i].SortMode = DataGridViewColumnSortMode.Programmatic;
            }

            DGMag1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DGMag1.DefaultCellStyle.SelectionBackColor = DGMag1.DefaultCellStyle.BackColor;
            DGMag1.DefaultCellStyle.SelectionForeColor = DGMag1.DefaultCellStyle.ForeColor;
            DGMag1.Columns[0].MinimumWidth = 90;
            DGMag1.Columns[1].MinimumWidth = 15;
            DGMag1.Columns[2].MinimumWidth = 15;
            DGMag1.Columns[3].MinimumWidth = 30;
            LowAz = (short)Conversion.Val(txtLowAz.Text);
            HighAz = (short)Conversion.Val(txtHighAz.Text);
            if (LowAz > HighAz)
            {
                HighAz = (short)(HighAz + 360);
            }

            int RowCt = 0;
            var loopTo2 = I1;
            for (i = 1; i <= loopTo2; i++)
            {
                Z1Temp[i] = Z1[i];
                if (Z1[i] < LowAz)
                {
                    Z1Temp[i] = Z1[i] + 360d;
                }

                if (Z1Temp[i] >= LowAz & Z1Temp[i] <= HighAz)
                {
                    DataSet1.Tables["Table1"].Rows.Add(Body1[i], Strings.Format(Z1[i], "000") + '°', Strings.Format(H1A[i], "00") + '°', Mag1[i]);
                    if (H1A[i] >= 15d & H1A[i] <= 75d)
                    {
                        switch (Body1[i].ToString().Trim() ?? "")
                        {
                            case "Sun":
                                {
                                    DGMag1.Rows[RowCt].DefaultCellStyle.Font = new Font("Times New Roman", 8f, System.Drawing.FontStyle.Bold);
                                    DGMag1.Rows[RowCt].DefaultCellStyle.BackColor = Color.Yellow;
                                    break;
                                }

                            case "Jupiter":
                            case "Moon":
                            case "Mars":
                            case "Saturn":
                            case "Venus":
                                {
                                    DGMag1.Rows[RowCt].DefaultCellStyle.Font = new Font("Times New Roman", 8f, System.Drawing.FontStyle.Bold);
                                    DGMag1.Rows[RowCt].DefaultCellStyle.BackColor = Color.LightGreen;
                                    break;
                                }

                            default:
                                {
                                    DGMag1.Rows[RowCt].DefaultCellStyle.Font = new Font("Times New Roman", 8f, System.Drawing.FontStyle.Bold);
                                    DGMag1.Rows[RowCt].DefaultCellStyle.BackColor = Color.LightGray;
                                    break;
                                }
                        }
                    }
                    else
                    {
                        switch (Body1[i].ToString().Trim() ?? "")
                        {
                            case "Sun":
                                {
                                    DGMag1.Rows[RowCt].DefaultCellStyle.Font = new Font("Times New Roman", 8f, System.Drawing.FontStyle.Regular);
                                    DGMag1.Rows[RowCt].DefaultCellStyle.BackColor = Color.Yellow;
                                    break;
                                }

                            case "Jupiter":
                            case "Moon":
                            case "Mars":
                            case "Saturn":
                            case "Venus":
                                {
                                    DGMag1.Rows[RowCt].DefaultCellStyle.Font = new Font("Times New Roman", 8f, System.Drawing.FontStyle.Regular);
                                    DGMag1.Rows[RowCt].DefaultCellStyle.BackColor = Color.AntiqueWhite;
                                    break;
                                }

                            default:
                                {
                                    DGMag1.Rows[RowCt].DefaultCellStyle.Font = new Font("Times New Roman", 8f, System.Drawing.FontStyle.Regular);
                                    DGMag1.Rows[RowCt].DefaultCellStyle.BackColor = Color.White;
                                    break;
                                }
                        }
                    }

                    RowCt += 1;
                }
            }

            DataSet1.Dispose();
            DGMag1.ClearSelection();
            DGMag1.CurrentCell = null;
            return;
        }

        public void DisplaySecond()
        {
            var Mag1Hdr = new[] { "Body", "Zn" + '°', "h" + '°', "Mag." };
            var Dataset2 = new DataSet();
            Dataset2.Tables.Add("Table1");
            Dataset2.DataSetName = "Table1";
            DGMag2.DataSource = Dataset2;
            for (int i = 0, loopTo = Information.UBound(Mag1Hdr); i <= loopTo; i++)
            {
                Dataset2.Tables["Table1"].Columns.Add(Mag1Hdr[i]);
                Dataset2.Tables["Table1"].Columns[i].AllowDBNull = false;
                Dataset2.Tables["Table1"].Columns[i].DefaultValue = "";
            }

            DGMag2.DataSource = Dataset2.Tables[0].DefaultView;
            for (int i = 0, loopTo1 = DGMag2.Columns.Count - 1; i <= loopTo1; i++)
            {
                DGMag2.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DGMag2.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGMag2.Columns[i].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                DGMag2.Columns[i].SortMode = DataGridViewColumnSortMode.Programmatic;
            }

            DGMag2.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DGMag2.DefaultCellStyle.SelectionBackColor = DGMag2.DefaultCellStyle.BackColor;
            DGMag2.DefaultCellStyle.SelectionForeColor = DGMag2.DefaultCellStyle.ForeColor;
            DGMag2.Columns[0].MinimumWidth = 90;
            DGMag2.Columns[1].MinimumWidth = 15;
            DGMag2.Columns[2].MinimumWidth = 15;
            DGMag2.Columns[3].MinimumWidth = 30;
            LowAz = (short)Conversion.Val(txtLowAz.Text);
            HighAz = (short)Conversion.Val(txtHighAz.Text);
            if (LowAz > HighAz)
            {
                HighAz = (short)(HighAz + 360);
            }

            int rowct = 0;
            var loopTo2 = I2;
            for (i = 1; i <= loopTo2; i++)
            {
                Z2Temp[i] = Z2[i];
                if (Z2[i] < LowAz)
                {
                    Z2Temp[i] = Z2[i] + 360d;
                }

                if (Z2Temp[i] >= LowAz & Z2Temp[i] <= HighAz)
                {
                    Dataset2.Tables["Table1"].Rows.Add(Body2[i], Strings.Format(Z2[i], "000") + '°', Strings.Format(H2A[i], "00") + '°', Mag2[i]);
                    if (H2A[i] >= 15d & H2A[i] <= 75d)
                    {
                        DGMag2.Rows[rowct].DefaultCellStyle.Font = new Font("Times New Roman", 8f, System.Drawing.FontStyle.Bold);
                        DGMag2.Rows[rowct].DefaultCellStyle.BackColor = Color.LightGray;
                    }
                    else
                    {
                        DGMag2.Rows[rowct].DefaultCellStyle.Font = new Font("Times New Roman", 8f, System.Drawing.FontStyle.Regular);
                        DGMag2.Rows[rowct].DefaultCellStyle.BackColor = Color.White;
                    }

                    rowct += 1;
                }

                Dataset2.Dispose();
            }

            DGMag2.ClearSelection();
            DGMag2.CurrentCell = null;
            return;
        }

        public void DisplayThird()
        {
            var Mag1Hdr = new[] { "Body", "Zn" + '°', "h" + '°', "Mag." };
            var Dataset3 = new DataSet();
            Dataset3.Tables.Add("Table1");
            Dataset3.DataSetName = "Table1";
            DGMag3.DataSource = Dataset3;
            for (int i = 0, loopTo = Information.UBound(Mag1Hdr); i <= loopTo; i++)
            {
                Dataset3.Tables["Table1"].Columns.Add(Mag1Hdr[i]);
                Dataset3.Tables["Table1"].Columns[i].AllowDBNull = false;
                Dataset3.Tables["Table1"].Columns[i].DefaultValue = "";
            }

            DGMag3.DataSource = Dataset3.Tables[0].DefaultView;
            for (int i = 0, loopTo1 = DGMag3.Columns.Count - 1; i <= loopTo1; i++)
            {
                DGMag3.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DGMag3.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGMag3.Columns[i].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                DGMag3.Columns[i].SortMode = DataGridViewColumnSortMode.Programmatic;
            }

            DGMag3.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DGMag3.DefaultCellStyle.SelectionBackColor = DGMag3.DefaultCellStyle.BackColor;
            DGMag3.DefaultCellStyle.SelectionForeColor = DGMag3.DefaultCellStyle.ForeColor;
            DGMag3.Columns[0].MinimumWidth = 90;
            DGMag3.Columns[1].MinimumWidth = 15;
            DGMag3.Columns[2].MinimumWidth = 15;
            DGMag3.Columns[3].MinimumWidth = 30;
            LowAz = (short)Conversion.Val(txtLowAz.Text);
            HighAz = (short)Conversion.Val(txtHighAz.Text);
            if (LowAz > HighAz)
            {
                HighAz = (short)(HighAz + 360);
            }

            int rowct = 0;
            var loopTo2 = I3;
            for (i = 1; i <= loopTo2; i++)
            {
                Z3Temp[i] = Z3[i];
                if (Z3[i] < LowAz)
                {
                    Z3Temp[i] = Z3[i] + 360d;
                }

                if (Z3Temp[i] >= LowAz & Z3Temp[i] <= HighAz)
                {
                    Dataset3.Tables["Table1"].Rows.Add(Body3[i], Strings.Format(Z3[i], "000") + '°', Strings.Format(H3A[i], "00") + '°', Mag3[i]);
                    if (H3A[i] >= 15d & H3A[i] <= 75d)
                    {
                        DGMag3.Rows[rowct].DefaultCellStyle.Font = new Font("Times New Roman", 8f, System.Drawing.FontStyle.Bold);
                        DGMag3.Rows[rowct].DefaultCellStyle.BackColor = Color.LightGray;
                    }
                    else
                    {
                        DGMag3.Rows[rowct].DefaultCellStyle.Font = new Font("Times New Roman", 8f, System.Drawing.FontStyle.Regular);
                        DGMag3.Rows[rowct].DefaultCellStyle.BackColor = Color.White;
                    }

                    rowct += 1;
                }

                Dataset3.Dispose();
            }

            DGMag3.ClearSelection();
            DGMag3.CurrentCell = null;
            return;
        }

        public void DisplayData()
        {
            ReportTxtBx.Visible = true;
            ReportTxtBx.BringToFront();
            ReportTxtBx.Clear();
            ReportTxtBx.AppendText("Date" + Constants.vbTab + Constants.vbTab + DTPlan.Value.ToString("dd MMM yyyy") + Constants.vbTab + Constants.vbTab + "DR L" + Strings.Space(5 + (3 - txtLDeg.Text.Length)) + Strings.Format(Conversion.Val(txtLDeg.Text), "0") + '°' + Strings.Format(Conversion.Val(LMin), "00.0") + "'" + cboL.Text + Environment.NewLine);
            ReportTxtBx.AppendText("ZT" + Constants.vbTab + Constants.vbTab + txtTime.Text + Constants.vbTab + Constants.vbTab + Constants.vbTab + "DR Lo" + Strings.Space(5 + (3 - txtLoDeg.Text.Length)) + Strings.Format(Conversion.Val(txtLoDeg.Text), "0") + '°' + Strings.Format(Conversion.Val(LoMin), "00.0") + "'" + cboLo.Text + Environment.NewLine);
            ReportTxtBx.AppendText("ZD" + Constants.vbTab + Constants.vbTab + "(");
            if (Math.Sign(ZD) == 1)
                ReportTxtBx.AppendText("+");
            if (Math.Sign(ZD) == -1)
                ReportTxtBx.AppendText("-");
            if (Math.Sign(ZD) == 0)
                ReportTxtBx.AppendText(CommonGlobals.g_StrSpace);
            ReportTxtBx.AppendText(")" + Strings.Space(1) + Strings.Format(Math.Abs(ZD), "00")); // Strings.format(Abs(Val(txtZDh.Text)), "00");
            if (optZDManual.Checked == true & cboZDm.Text != "00")
            {
                ReportTxtBx.AppendText(cboZDm.Text + Environment.NewLine);
            }
            else
            {
                ReportTxtBx.AppendText(Environment.NewLine);
            }

            ReportTxtBx.AppendText("UT (GMT)" + Constants.vbTab + Constants.vbTab + Strings.Format(GHour, "00") + Strings.Format(GMinute, "00") + Environment.NewLine);
            ReportTxtBx.AppendText("G Day/Mo/Yr" + Constants.vbTab + Conversion.Str(GDay) + Strings.Space(1) + MonthatG + Conversion.Str(GYear) + Environment.NewLine);
            ReportTxtBx.AppendText(Environment.NewLine);
            ReportTxtBx.AppendText("GHA Aries     " + Constants.vbTab + Strings.Format(WD, "##0") + '°' + Strings.Format(WM, "00.0") + "'" + Environment.NewLine);
            if (Math.Sign(Lo) == 1)
                ReportTxtBx.AppendText("DR Lo       (-)");
            if (Math.Sign(Lo) == -1)
                ReportTxtBx.AppendText("DR Lo       (+)");
            if (Math.Sign(Lo) == 0)
                ReportTxtBx.AppendText("DR Lo       ( )");
            ReportTxtBx.AppendText(Constants.vbTab + Strings.Format(Conversion.Val(txtLoDeg.Text), "0") + '°' + Strings.Format(Conversion.Val(LoMin), "00.0") + "'" + cboLo.Text + Environment.NewLine);
            ReportTxtBx.AppendText("LHA Aries     " + Constants.vbTab + Strings.Format(QD, "##0") + '°' + Strings.Format(QM, "00.0") + "' = " + Strings.Format(LR, "##0.0") + '°' + Environment.NewLine);
            ReportTxtBx.AppendText(Environment.NewLine);
            ReportTxtBx.AppendText("GHA Sun       " + Constants.vbTab + Strings.Format(VD[1], "##0") + '°' + Strings.Format(VM[1], "00.0") + "'" + Constants.vbTab + Constants.vbTab + "GHA Moon       " + Strings.Space(4 - Strings.Len(Conversion.Str(VD[2]))) + Strings.Format(VD[2], "##0") + '°' + Strings.Format(VM[2], "00.0") + "'" + Environment.NewLine);
            ReportTxtBx.AppendText("RA  Sun       " + Constants.vbTab + Strings.Format(GRD[1], "##0") + '°' + Strings.Format(GRM[1], "00.0") + "' = " + Strings.Format(RA[1], "##0.0") + '°' + Constants.vbTab + "RA  Moon       " + Strings.Space(4 - Strings.Len(Conversion.Str(GRD[2]))) + Strings.Format(GRD[2], "##0") + '°' + Strings.Format(GRM[2], "00.0") + "' = " + Strings.Format(RA[2], "##0.0") + '°' + Environment.NewLine);
            ReportTxtBx.AppendText("Dec Sun       " + Constants.vbTab + Strings.Format(DF[1], "0.0") + '°' + HD[1] + Constants.vbTab + Constants.vbTab + "Dec Moon       " + Constants.vbTab + Strings.Format(DF[2], "0.0") + '°' + HD[2] + Environment.NewLine);
            ReportTxtBx.AppendText(Environment.NewLine);
            ReportTxtBx.AppendText("Planet " + Constants.vbTab + "SHA" + Constants.vbTab + Constants.vbTab + "RA" + Constants.vbTab + Constants.vbTab + "Dec" + Environment.NewLine);
            ReportTxtBx.AppendText("Venus  " + Constants.vbTab + Strings.Format(SH[3], "##0.0") + '°' + Constants.vbTab + Constants.vbTab + Strings.Format(RA[3], "##0.0") + '°' + Constants.vbTab + Constants.vbTab + Strings.Format(DF[3], "#0.0") + '°' + HD[3] + Environment.NewLine);
            ReportTxtBx.AppendText("Mars   " + Constants.vbTab + Strings.Format(SH[4], "##0.0") + '°' + Constants.vbTab + Constants.vbTab + Strings.Format(RA[4], "##0.0") + '°' + Constants.vbTab + Constants.vbTab + Strings.Format(DF[4], "#0.0") + '°' + HD[4] + Environment.NewLine);
            ReportTxtBx.AppendText("Jupiter" + Constants.vbTab + Strings.Format(SH[5], "##0.0") + '°' + Constants.vbTab + Constants.vbTab + Strings.Format(RA[5], "##0.0") + '°' + Constants.vbTab + Constants.vbTab + Strings.Format(DF[5], "#0.0") + '°' + HD[5] + Environment.NewLine);
            ReportTxtBx.AppendText("Saturn " + Constants.vbTab + Strings.Format(SH[6], "##0.0") + '°' + Constants.vbTab + Constants.vbTab + Strings.Format(RA[6], "##0.0") + '°' + Constants.vbTab + Constants.vbTab + Strings.Format(DF[6], "#0.0") + '°' + HD[6] + Environment.NewLine);
            return;
        }

        public bool First_Mag()
        {
            I1 = (short)(I1 + 1);
            Body1[I1] = Body[BN];
            Mag1[I1] = Mag[BN];
            Z1[I1] = ZN;
            H1A[I1] = Ho;
            return true;
        }

        public bool Second_Mag()
        {
            I2 = (short)(I2 + 1);
            Body2[I2] = Body[BN];
            Mag2[I2] = Mag[BN];
            Z2[I2] = ZN;
            H2A[I2] = Ho;
            return true;
        }

        public bool Third_Mag() // was Sub2523
        {
            I3 = (short)(I3 + 1);
            Body3[I3] = Body[BN];
            Mag3[I3] = Mag[BN];
            Z3[I3] = ZN;
            H3A[I3] = Ho;
            return true;
        }

        public bool CheckDate()
        {
            DateOfSight = DTPlan.Value.ToString("dd MMMM yyyy");
            return false;
            return default;
        }

        private void txtLowAz_TextChanged(object eventSender, EventArgs eventArgs)
        {
            // txtLowAz.ForeColor = &H80000008
            txtLowAz.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtLowAz.Text) > 360d)
            {
                txtLowAz.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range", "Entry Error", MessageBoxButtons.OK);
            }
            // ExecCmdTwilights()
            // SelectTabToDisplay()
        }

        private void txtLowAz_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        private void txtLowAz_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtLowAz.Text) > 360d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtLowAz_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtLowAz;
            SelectAllText(ref argTB);
            txtLowAz = argTB;
            ExecCmdTwilights();
            SelectTabToDisplay();
        }

        private void txtLowAz_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTime.Text))
            {
                var argTB = txtLowAz;
                SelectAllText(ref argTB);
                txtLowAz = argTB;
                ExecCmdTwilights();
                SelectTabToDisplay();
            }
        }

        private void txtHighAz_TextChanged(object eventSender, EventArgs eventArgs)
        {
            // txtHighAz.ForeColor = &H80000008
            txtHighAz.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtHighAz.Text) > 360d)
            {
                txtHighAz.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range", "Entry Error", MessageBoxButtons.OK);
            }
            // ExecCmdTwilights()
            // SelectTabToDisplay()
        }

        private void txtHighAz_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        private void txtHighAz_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtHighAz.Text) > 360d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtHighAz_Enter(object eventSender, EventArgs eventArgs)
        {
            if (!string.IsNullOrEmpty(txtTime.Text))
            {
                var argTB = txtHighAz;
                SelectAllText(ref argTB);
                txtHighAz = argTB;
                ExecCmdTwilights();
                SelectTabToDisplay();
            }
        }

        private void StarMagnitudes()
        {
            if (GYear <= 2005)
            {
                Magnitude = new string[] { " 2.1", " 2.2", " 2.4", " 2.5", " 2.2", " 0.6", " 2.2", " 3.1", " 2.8", " 1.9", " 1.1", " 0.3", " 0.2", " 1.7", " 1.8", " 1.8", " 0.1 - 1.2", " -0.9", " -1.6", " 1.6", " 0.5", " 1.2", " 1.7", " 2.2", " 1.8", " 2.2", " 1.3", " 2.0", " 2.2", " 2.8", " 1.1", " 1.6", " 1.7", " 1.2", " 1.9", " 0.9", " 2.3", " 0.2", " 0.1", " 2.9", " 2.2", " 2.3", " 1.2", " 1.9", " 2.6", " 1.7", " 2.1", " 2.4", " 2.0", " 0.1", " 2.1", " 0.9", " 2.1", " 1.3", " 2.5", " 2.2", " 1.3", " 2.6" };
            }
            else
            {
                Magnitude = new string[] { " 2.1", " 2.1", " 2.4", " 2.2", " 2.0", " 0.5", " 2.0", " 3.2", " 2.5", " 1.8", " 0.9", " 0.1", " 0.1", " 1.6", " 1.7", " 1.7", " 0.1 - 1.2", " -0.7", " -1.5", " 1.5", " 0.4", " 1.1", " 1.9", " 2.2", " 1.7", " 2.0", " 1.4", " 1.8", " 2.1", " 2.6", " 1.3", " 1.6", " 1.8", " 1.0", " 1.9", " 0.6", " 2.1", " 0.0", " -0.3", " 2.8", " 2.1", " 2.2", " 1.0", " 1.9", " 2.4", " 1.6", " 2.1", " 2.2", " 1.9", " 0.0", " 2.0", " 0.8", " 1.9", " 1.3", " 2.4", " 1.7", " 1.2", " 2.5" };
            }

            var loopTo = (short)Information.UBound(Magnitude, 1);
            for (i = 0; i <= loopTo; i++)
                Mag[i] = Magnitude[i];
        }

        public void DrawCelestialCircles()
        {
            var DPen = new Pen(Color.Black, 1f);
            DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            double DrawWidth = SkyPicBx.Width / 2d - 25d;
            int CircleDiam = (int)DrawWidth;
            float XTD1, YTD1;
            float XTD2, YTD2;
            float TwoPi, i;
            // redefined from global variables for local use 
            int x = 0;
            int y = 0;
            TwoPi = (float)(8d * Math.Atan(1d));
            DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            var loopTo = TwoPi;
            for (i = 0f; TwoPi / 24f >= 0 ? i <= loopTo : i >= loopTo; i += TwoPi / 24f)
            {
                XTD1 = (float)(-DrawWidth * Math.Cos(i));
                YTD1 = (float)(-DrawWidth * Math.Sin(i));
                XTD2 = (float)(DrawWidth * Math.Cos(i));
                YTD2 = (float)(DrawWidth * Math.Sin(i));
                Plan1graphic.DrawLine(DPen, XTD1, YTD1, XTD2, YTD2);
                // Plan1graphic.DrawString(i.ToString, DFont2, DPen.Brush, XTD2, YTD2) 'debugging statement to allow visualization of rotation direction
            }

            int CircleDiamDelta = (int)(DrawWidth / 6d); // every 15 degrees from horizon to zenith = 6 circles
            Plan1graphic.DrawEllipse(DPen, -CircleDiam, CircleDiam, 2 * CircleDiam, -(2 * CircleDiam)); // horizon circle
            CircleDiam -= CircleDiamDelta;
            Plan1graphic.DrawEllipse(DPen, -CircleDiam, CircleDiam, 2 * CircleDiam, -(2 * CircleDiam)); // 15 degree circle
            CircleDiam -= CircleDiamDelta;
            DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            Plan1graphic.DrawEllipse(DPen, -CircleDiam, CircleDiam, 2 * CircleDiam, -(2 * CircleDiam)); // 30 degree circle
            CircleDiam -= CircleDiamDelta;
            Plan1graphic.DrawEllipse(DPen, -CircleDiam, CircleDiam, 2 * CircleDiam, -(2 * CircleDiam)); // 45 degree circle
            CircleDiam -= CircleDiamDelta;
            Plan1graphic.DrawEllipse(DPen, -CircleDiam, CircleDiam, 2 * CircleDiam, -(2 * CircleDiam)); // 60 degree circle
            CircleDiam -= CircleDiamDelta;
            DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            Plan1graphic.DrawEllipse(DPen, -CircleDiam, CircleDiam, 2 * CircleDiam, -(2 * CircleDiam)); // 75 degree circle
            Plan1graphic.FillEllipse(Brushes.White, -(CircleDiam - 1), CircleDiam - 1, 2 * (CircleDiam - 1), -(2 * CircleDiam - 1)); // cler out circle 75 - 90 degree circle
            return;
        }

        public void DisplayView()
        {
            int ttx = 0;
            int tty = 0;
            Warning();
            if (DisplayInitialView == false) // GoTo skipVisibles
            {
                lblAltitude.Visible = true;
                lblAzimuth.Visible = true;
                lblAz.Visible = true;
                lblAlt.Visible = true;
                Label5.Visible = true;
                Label7.Visible = true;
                lblBody.Visible = true;
                lblBodyName.Visible = true;
                chkFirst.Visible = true;
                chkSecond.Visible = true;
                chkThird.Visible = true;
                chkNames.Visible = true;
                chkLimit.Visible = true;
                chkHelper.Visible = true;
                FrameView.Visible = true;
                FrameDirection.Visible = true;
                FrameBest.Visible = true;
                bShowToolTips = true;
            }

        skipVisibles:
            ;
            lblN.Visible = true;
            lblE.Visible = true;
            lblS.Visible = true;
            lblW.Visible = true;
            lblSRight.Visible = false;
            lblSLeft.Visible = false;
            if (optOff.Checked == false)
            {
                cmdCCW.Enabled = true;
                cmdCW.Enabled = true;
                ResetRotateBtn.Enabled = true;
                RotateIncr.Enabled = true;
            }

            float TwoPi, i;
            // redefined from global variables for local use 
            int x = 0;
            int y = 0;
            TwoPi = (float)(8d * Math.Atan(1d));
            var DFont1 = new Font("Times New Roman", 10f);
            var DFont2 = new Font("Times New Roman", 8f);
            var DFont3 = new Font("Times New Roman", 6f);

            // RecyclePlan1Jpg()

            // set up fresh / new bitmap and graphics drawwing object for diagram and later additions
            double DrawWidth = SkyPicBx.Width / 2d - 25d;
            bm = new Bitmap(SkyPicBx.Width, SkyPicBx.Height);
            SkyPicBx.ImageLocation = null;
            Plan1graphic = Graphics.FromImage(bm);
            Plan1graphic.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Plan1graphic.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            Plan1graphic.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            Plan1graphic.TranslateTransform((float)(SkyPicBx.Width / 2d), (float)(SkyPicBx.Height / 2d));
            var DPen = new Pen(Color.Black);
            DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            var ptA = new System.Windows.Point();
            var ptB = new System.Windows.Point();
            DrawCelestialCircles();

            // on form load, an initial display of the basic celestial circle is drawn with nothing else
            if (DisplayInitialView == true)
            {
                DisplayInitialView = false;
                goto SaveBMandDisplay;
            }
            // otherwise we are drawwing the visible stars and objects
            DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            DPen.Brush = Brushes.Black;
            LowAz = (short)Conversion.Val(txtLowAz.Text);
            HighAz = (short)Conversion.Val(txtHighAz.Text);
            if (LowAz > HighAz)
                HighAz = (short)(HighAz + 360);

            // First magnitude bodies
            var loopTo = (float)Information.UBound(VwBody1, 1);
            for (i = 0f; i <= loopTo; i++)
                VwBody1.Initialize();
            var Lpt = new System.Windows.Point();
            Lpt.X = Plan1TabCntl.Location.X + SkyPicBx.Location.X;
            Lpt.Y = Plan1TabCntl.ItemSize.Height + Plan1TabCntl.Location.Y + SkyPicBx.Location.Y;
            if (chkFirst.Checked == true)
            {
                VwBody1 = new BodyInfo[(I1 + 1)];
                var loopTo1 = (float)I1;
                for (i = 1f; i <= loopTo1; i++)
                {
                    rad = (float)(DrawWidth * (1d - H1A[(int)i] / 90d));
                    Z1[(int)i] = Conversion.Val(Z1[(int)i]);
                    Z1Temp[(int)i] = Z1[(int)i];
                    if (Z1[(int)i] < LowAz)
                    {
                        Z1Temp[(int)i] = Z1[(int)i] + 360d;
                    }
                    // Z1(i) is the ZN measured clockwise to the east from due north. This graphic starts its rotation due East and rotates counter clockwise
                    // so Zn must be made negative and reduced by 90 degress to get the proper rotation and proper north orientation for start. The Rotate X
                    // and RotateY corrections are due to selections of east up, south up and west up for diagram and should be rotated negative the same as the other angles
                    // These corrections and math should be true for all x / y calculations for DisplayView and DisplayHorizonView angles
                    x = (int)(rad * Math.Cos(-1 * (Z1[(int)i] + 90d + RotateX) * Pi / 180d));
                    y = (int)(rad * Math.Sin(-1 * (Z1[(int)i] + 90d + RotateY) * Pi / 180d));
                    if (optStarFinder.Checked == true & (optN.Checked == true | optS.Checked == true))
                    {
                        x = -x;
                    }

                    if (optStarFinder.Checked == true & (optE.Checked == true | optW.Checked == true))
                    {
                        y = -y;
                    }

                    int Mag1size = (int)DFont1.SizeInPoints;
                    int Mag1delta = (int)(Mag1size / 2d);
                    int UleftX = x - Mag1delta;
                    int UleftY = y - Mag1delta;
                    if (chkLimit.Checked == true & Z1Temp[(int)i] >= LowAz & Z1Temp[(int)i] <= HighAz)
                    {
                        Plan1graphic.DrawEllipse(DPen, UleftX, UleftY, Mag1size, Mag1size);
                        if (Body1[(int)i].ToString() == "Sun")
                        {
                            Plan1graphic.FillEllipse(Brushes.Yellow, UleftX, UleftY, Mag1size, Mag1size);
                        }
                        else if (Body1[(int)i].ToString() == "Moon")
                        {
                            Plan1graphic.FillEllipse(Brushes.LightGreen, UleftX, UleftY, Mag1size, Mag1size);
                        }
                        else if (Body1[(int)i].ToString() == "Venus" | Body1[(int)i].ToString() == "Mars" | Body1[(int)i].ToString() == "Jupiter" | Body1[(int)i].ToString() == "Saturn")
                        {
                            Plan1graphic.FillEllipse(Brushes.Red, UleftX, UleftY, Mag1size, Mag1size);
                        }
                        else
                        {
                            Plan1graphic.FillEllipse(Brushes.Blue, UleftX, UleftY, Mag1size, Mag1size);
                        }
                    }

                    if (chkLimit.Checked == false)
                    {
                        Plan1graphic.DrawEllipse(DPen, UleftX, UleftY, Mag1size, Mag1size);
                        if (Body1[(int)i].ToString() == "Sun")
                        {
                            Plan1graphic.FillEllipse(Brushes.Yellow, UleftX, UleftY, Mag1size, Mag1size);
                        }
                        else if (Body1[(int)i].ToString() == "Moon")
                        {
                            Plan1graphic.FillEllipse(Brushes.LightGreen, UleftX, UleftY, Mag1size, Mag1size);
                        }
                        else if (Body1[(int)i].ToString() == "Venus" | Body1[(int)i].ToString() == "Mars" | Body1[(int)i].ToString() == "Jupiter" | Body1[(int)i].ToString() == "Saturn")
                        {
                            Plan1graphic.FillEllipse(Brushes.Red, UleftX, UleftY, Mag1size, Mag1size);
                        }
                        else
                        {
                            Plan1graphic.FillEllipse(Brushes.Blue, UleftX, UleftY, Mag1size, Mag1size);
                        }
                    }

                    VwBody1[(int)i] = new BodyInfo();
                    VwBody1[(int)i].BodyName = Body1[(int)i];
                    VwBody1[(int)i].BodyLoc.X = UleftX;
                    VwBody1[(int)i].BodyLoc.Y = UleftY;
                    VwBody1[(int)i].BodyLocSz = 12;
                    VwBody1[(int)i].BodyAlt = H1A[(int)i].ToString();
                    VwBody1[(int)i].BodyAz = Z1[(int)i].ToString();
                    if (chkNames.Checked == true & Z1Temp[(int)i] >= LowAz & Z1Temp[(int)i] <= HighAz | chkNames.Checked == true & chkLimit.Checked == false)
                    {
                        Plan1graphic.DrawString(Body1[(int)i].ToString(), new Font("Arial", 7f, System.Drawing.FontStyle.Regular), Brushes.Blue, x + Mag1delta, y + Mag1delta);
                        Plan1graphic.DrawString("Az:" + Z1[(int)i].ToString() + '°' + " Alt:" + H1A[(int)i].ToString() + '°', new Font("Arial", 7f, System.Drawing.FontStyle.Regular), Brushes.Blue, x + Mag1delta, y + 3 * Mag1delta);
                    }
                }
            }

            // Second magnitude bodies
            var loopTo2 = (float)Information.UBound(VwBody2, 1);
            for (i = 0f; i <= loopTo2; i++)
                VwBody2.Initialize();
            if (chkSecond.Checked == true)
            {
                VwBody2 = new BodyInfo[(I2 + 1)];
                var loopTo3 = (float)I2;
                for (i = 1f; i <= loopTo3; i++)
                {
                    rad = (float)(DrawWidth * (1d - H2A[(int)i] / 90d));
                    Z2[(int)i] = Conversion.Val(Z2[(int)i]);
                    Z2Temp[(int)i] = Z2[(int)i];
                    if (Z2[(int)i] < LowAz)
                        Z2Temp[(int)i] = Z2[(int)i] + 360d;
                    x = (int)(rad * Math.Cos(-1 * (Z2[(int)i] + 90d + RotateX) * Pi / 180d));
                    y = (int)(rad * Math.Sin(-1 * (Z2[(int)i] + 90d + RotateY) * Pi / 180d));
                    if (optStarFinder.Checked == true & (optN.Checked == true | optS.Checked == true))
                    {
                        x = -x;
                    }

                    if (optStarFinder.Checked == true & (optE.Checked == true | optW.Checked == true))
                    {
                        y = -y;
                    }

                    int Mag1size = (int)DFont2.SizeInPoints;
                    int Mag1delta = (int)(Mag1size / 2d);
                    int UleftX = x - Mag1delta;
                    int UleftY = y - Mag1delta;
                    if (chkLimit.Checked == true & Z2Temp[(int)i] >= LowAz & Z2Temp[(int)i] <= HighAz)
                    {
                        Plan1graphic.DrawEllipse(DPen, UleftX, UleftY, Mag1size, Mag1size);
                        Plan1graphic.FillEllipse(Brushes.DarkGray, UleftX, UleftY, Mag1size, Mag1size);
                    }

                    if (chkLimit.Checked == false)
                    {
                        Plan1graphic.DrawEllipse(DPen, UleftX, UleftY, Mag1size, Mag1size);
                        Plan1graphic.FillEllipse(Brushes.DarkGray, UleftX, UleftY, Mag1size, Mag1size);
                    }

                    VwBody2[(int)i] = new BodyInfo();
                    VwBody2[(int)i].BodyName = Body2[(int)i];
                    VwBody2[(int)i].BodyLoc.X = UleftX;
                    VwBody2[(int)i].BodyLoc.Y = UleftY;
                    VwBody2[(int)i].BodyLocSz = 12;
                    VwBody2[(int)i].BodyAlt = H2A[(int)i].ToString();
                    VwBody2[(int)i].BodyAz = Z2[(int)i].ToString();
                    if (chkNames.Checked == true & chkLimit.Checked == true & Z2Temp[(int)i] >= LowAz & Z2Temp[(int)i] <= HighAz | chkNames.Checked == true & chkLimit.Checked == false)
                    {
                        Plan1graphic.DrawString(Body2[(int)i].ToString(), new Font("Arial", 7f, System.Drawing.FontStyle.Regular), Brushes.DarkGray, x + Mag1delta, y + Mag1delta);
                        Plan1graphic.DrawString("Az:" + Z2[(int)i].ToString() + '°' + " Alt:" + H2A[(int)i].ToString() + '°', new Font("Arial", 7f, System.Drawing.FontStyle.Regular), Brushes.DarkGray, x + Mag1delta, y + 3 * Mag1delta);
                    }
                }
            }
            // Third magnitude bodies
            var loopTo4 = (float)Information.UBound(VwBody3, 1);
            for (i = 0f; i <= loopTo4; i++)
                VwBody3.Initialize();
            if (chkThird.Checked == true)
            {
                VwBody3 = new BodyInfo[(I3 + 1)];
                var loopTo5 = (float)I3;
                for (i = 1f; i <= loopTo5; i++)
                {
                    rad = (float)(DrawWidth * (1d - H3A[(int)i] / 90d));
                    Z3[(int)i] = Conversion.Val(Z3[(int)i]);
                    Z3Temp[(int)i] = Z3[(int)i];
                    if (Z3[(int)i] < LowAz)
                        Z3Temp[(int)i] = Z3[(int)i] + 360d;
                    x = (int)(rad * Math.Cos(-1 * (Z3[(int)i] + 90d + RotateX) * Pi / 180d));
                    y = (int)(rad * Math.Sin(-1 * (Z3[(int)i] + 90d + RotateY) * Pi / 180d));
                    if (optStarFinder.Checked == true & (optN.Checked == true | optS.Checked == true))
                    {
                        x = -x;
                    }

                    if (optStarFinder.Checked == true & (optE.Checked == true | optW.Checked == true))
                    {
                        y = -y;
                    }

                    int Mag1size = (int)DFont3.SizeInPoints;
                    int Mag1delta = 3;
                    int UleftX = x - Mag1delta;
                    int UleftY = y - Mag1delta;
                    if (chkLimit.Checked == true & Z3Temp[(int)i] >= LowAz & Z3Temp[(int)i] <= HighAz)
                    {
                        Plan1graphic.DrawEllipse(DPen, UleftX, UleftY, Mag1size, Mag1size);
                        Plan1graphic.FillEllipse(Brushes.LightGray, UleftX, UleftY, Mag1size, Mag1size);
                    }

                    if (chkLimit.Checked == false)
                    {
                        Plan1graphic.DrawEllipse(DPen, UleftX, UleftY, Mag1size, Mag1size);
                        Plan1graphic.FillEllipse(Brushes.LightGray, UleftX, UleftY, Mag1size, Mag1size);
                    }

                    VwBody3[(int)i] = new BodyInfo();
                    VwBody3[(int)i].BodyName = Body3[(int)i];
                    VwBody3[(int)i].BodyLoc.X = UleftX;
                    VwBody3[(int)i].BodyLoc.Y = UleftY;
                    VwBody3[(int)i].BodyLocSz = 12;
                    VwBody3[(int)i].BodyAlt = H3A[(int)i].ToString();
                    VwBody3[(int)i].BodyAz = Z3[(int)i].ToString();
                    if (chkNames.Checked == true & Z3Temp[(int)i] >= LowAz & Z3Temp[(int)i] <= HighAz | chkNames.Checked == true & chkLimit.Checked == false)
                    {
                        Plan1graphic.DrawString(Body3[(int)i].ToString(), new Font("Arial", 6f, System.Drawing.FontStyle.Regular), Brushes.LightGray, x + Mag1delta, y + Mag1delta);
                        Plan1graphic.DrawString("Az:" + Z3[(int)i].ToString() + '°' + " Alt:" + H3A[(int)i].ToString() + '°', new Font("Arial", 6f, System.Drawing.FontStyle.Regular), Brushes.LightGray, x + Mag1delta, y + 3 * Mag1delta);
                    }
                }
            }

            DPen.Brush = Brushes.Transparent;
            DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            if (chkHelper.Checked == true)
            {
                // First magnitude Helper stars
                var loopTo6 = (float)(NumberOfHelpers - 1);
                for (i = 0f; i <= loopTo6; i++)
                {
                    rad = (float)(2400d * (1d - HH1A[(int)i] / 90d));
                    ZH1Temp[(int)i] = ZH1[(int)i];
                    if (ZH1[(int)i] < LowAz)
                        ZH1Temp[(int)i] = ZH1[(int)i] + 360;
                    x = (int)(rad * Math.Cos(-1 * (ZH1[(int)i] + 90 + RotateX) * Pi / 180d));
                    y = (int)(rad * Math.Sin(-1 * (ZH1[(int)i] + 90 + RotateY) * Pi / 180d));
                    if (optStarFinder.Checked == true & (optN.Checked == true | optS.Checked == true))
                        x = -x;
                    if (optStarFinder.Checked == true & (optE.Checked == true | optW.Checked == true))
                        y = -y;
                    int Mag1size = 8;
                    int Mag1delta = (int)(Mag1size / 2d);
                    int UleftX = x - Mag1delta;
                    int UleftY = y - Mag1delta;
                    if (chkLimit.Checked == true & ZH1Temp[(int)i] >= LowAz & ZH1Temp[(int)i] <= HighAz & HH1A[(int)i] != 0)
                    {
                        Plan1graphic.DrawEllipse(DPen, UleftX, UleftY, Mag1size, Mag1size);
                    }

                    if (chkLimit.Checked == false & HH1A[(int)i] != 0)
                    {
                        Plan1graphic.DrawEllipse(DPen, UleftX, UleftY, Mag1size, Mag1size);
                    }
                }
                // Second magnitude Helper stars
                var loopTo7 = (float)(NumberOfHelpers - 1);
                for (i = 0f; i <= loopTo7; i++)
                {
                    rad = (float)(2400d * (1d - HH2A[(int)i] / 90d));
                    ZH2Temp[(int)i] = ZH2[(int)i];
                    if (ZH2[(int)i] < LowAz)
                        ZH2Temp[(int)i] = ZH2[(int)i] + 360;
                    x = (int)(rad * Math.Cos(-1 * (ZH2[(int)i] + 90 + RotateX) * Pi / 180d));
                    y = (int)(rad * Math.Sin(-1 * (ZH2[(int)i] + 90 + RotateY) * Pi / 180d));
                    if (optStarFinder.Checked == true & (optN.Checked == true | optS.Checked == true))
                        x = -x;
                    if (optStarFinder.Checked == true & (optE.Checked == true | optW.Checked == true))
                        y = -y;
                    int Mag1size = 6;
                    int Mag1delta = (int)(Mag1size / 2d);
                    int UleftX = x - Mag1delta;
                    int UleftY = y - Mag1delta;
                    if (chkLimit.Checked == true & ZH2Temp[(int)i] >= LowAz & ZH2Temp[(int)i] <= HighAz & HH2A[(int)i] != 0)
                    {
                        Plan1graphic.DrawEllipse(DPen, UleftX, UleftY, Mag1size, Mag1size);
                    }

                    if (chkLimit.Checked == false & HH2A[(int)i] != 0)
                    {
                        Plan1graphic.DrawEllipse(DPen, UleftX, UleftY, Mag1size, Mag1size);
                    }
                }
                // Third magnitude Helper stars
                var loopTo8 = (float)(NumberOfHelpers - 1);
                for (i = 0f; i <= loopTo8; i++)
                {
                    rad = (float)(2400d * (1d - HH3A[(int)i] / 90d));
                    ZH3Temp[(int)i] = ZH3[(int)i];
                    if (ZH3[(int)i] < LowAz)
                        ZH3Temp[(int)i] = ZH3[(int)i] + 360;
                    x = (int)(rad * Math.Cos(-1 * (ZH3[(int)i] + 90 + RotateX) * Pi / 180d));
                    y = (int)(rad * Math.Sin(-1 * (ZH3[(int)i] + 90 + RotateY) * Pi / 180d));
                    if (optStarFinder.Checked == true & (optN.Checked == true | optS.Checked == true))
                        x = -x;
                    if (optStarFinder.Checked == true & (optE.Checked == true | optW.Checked == true))
                        y = -y;
                    int Mag1size = 4;
                    int Mag1delta = (int)(Mag1size / 2d);
                    int UleftX = x - Mag1delta;
                    int UleftY = y - Mag1delta;
                    if (chkLimit.Checked == true & ZH3Temp[(int)i] >= LowAz & ZH3Temp[(int)i] <= HighAz & HH3A[(int)i] != 0)
                    {
                        Plan1graphic.DrawEllipse(DPen, UleftX, UleftY, Mag1size, Mag1size);
                    }

                    if (chkLimit.Checked == false & HH3A[(int)i] != 0)
                    {
                        Plan1graphic.DrawEllipse(DPen, UleftX, UleftY, Mag1size, Mag1size);
                    }
                }
                // Fourth+ magnitude Helper stars
                var loopTo9 = (float)(NumberOfHelpers - 1);
                for (i = 0f; i <= loopTo9; i++)
                {
                    rad = (float)(2400d * (1d - HH4A[(int)i] / 90d));
                    ZH4Temp[(int)i] = ZH4[(int)i];
                    if (ZH4[(int)i] < LowAz)
                        ZH4Temp[(int)i] = ZH4[(int)i] + 360;
                    x = (int)(rad * Math.Cos(-1 * (ZH4[(int)i] + 90 + RotateX) * Pi / 180d));
                    y = (int)(rad * Math.Sin(-1 * (ZH4[(int)i] + 90 + RotateY) * Pi / 180d));
                    if (optStarFinder.Checked == true & (optN.Checked == true | optS.Checked == true))
                        x = -x;
                    if (optStarFinder.Checked == true & (optE.Checked == true | optW.Checked == true))
                        y = -y;
                    int Mag1size = 4;
                    int Mag1delta = (int)(Mag1size / 2d);
                    int UleftX = x - Mag1delta;
                    int UleftY = y - Mag1delta;
                    if (chkLimit.Checked == true & ZH4Temp[(int)i] >= LowAz & ZH4Temp[(int)i] <= HighAz & HH4A[(int)i] != 0)
                    {
                        Plan1graphic.DrawEllipse(DPen, UleftX, UleftY, Mag1size, Mag1size);
                    }

                    if (chkLimit.Checked == false & HH4A[(int)i] != 0)
                    {
                        Plan1graphic.DrawEllipse(DPen, UleftX, UleftY, Mag1size, Mag1size);
                    }
                }
            }
            // now draw 2 and 3 body best fix lines if the options are selected
            DPen = new Pen(Color.Red, 2f);
            Plan1graphic.RotateTransform(-90);
            if (optHorizon.Checked == false & optTwo.Checked == true)
            {
                DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                XTB1 = (float)(DrawWidth * Math.Cos(SweepStep2));
                YTB1 = (float)(DrawWidth * Math.Sin(SweepStep2));
                XTB2 = (float)(DrawWidth * Math.Cos(SweepStep2 + Pi / 2d));
                YTB2 = (float)(DrawWidth * Math.Sin(SweepStep2 + Pi / 2d));
                Plan1graphic.DrawLine(DPen, 0f, 0f, XTB1, YTB1);
                Plan1graphic.DrawLine(DPen, 0f, 0f, XTB2, YTB2);
                XTB4 = (float)(DrawWidth * Math.Cos(SweepStep2 - Pi / 8d));
                YTB4 = (float)(DrawWidth * Math.Sin(SweepStep2 - Pi / 8d));
                XTB5 = (float)(DrawWidth * Math.Cos(SweepStep2 + Pi / 8d));
                YTB5 = (float)(DrawWidth * Math.Sin(SweepStep2 + Pi / 8d));
                XTB6 = (float)(DrawWidth * Math.Cos(SweepStep2 + Pi / 2d - Pi / 8d));
                YTB6 = (float)(DrawWidth * Math.Sin(SweepStep2 + Pi / 2d - Pi / 8d));
                XTB7 = (float)(DrawWidth * Math.Cos(SweepStep2 + Pi / 2d + Pi / 8d));
                YTB7 = (float)(DrawWidth * Math.Sin(SweepStep2 + Pi / 2d + Pi / 8d));
                DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                Plan1graphic.DrawLine(DPen, 0f, 0f, XTB4, YTB4);
                Plan1graphic.DrawLine(DPen, 0f, 0f, XTB5, YTB5);
                DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
                Plan1graphic.DrawLine(DPen, 0f, 0f, XTB6, YTB6);
                Plan1graphic.DrawLine(DPen, 0f, 0f, XTB7, YTB7);
            }

            if (optHorizon.Checked == false & (optThreeBoat.Checked == true | optThreeBeach.Checked == true))
            {
                XTB1 = (float)(DrawWidth * Math.Cos(SweepStep3));
                YTB1 = (float)(DrawWidth * Math.Sin(SweepStep3));
                XTB2 = (float)(DrawWidth * Math.Cos(SweepStep3 + 2d * Pi / 3d));
                YTB2 = (float)(DrawWidth * Math.Sin(SweepStep3 + 2d * Pi / 3d));
                XTB3 = (float)(DrawWidth * Math.Cos(SweepStep3 + 4d * Pi / 3d));
                YTB3 = (float)(DrawWidth * Math.Sin(SweepStep3 + 4d * Pi / 3d));
                XTB8 = (float)(DrawWidth * Math.Cos(SweepStep3 + Pi));
                YTB8 = (float)(DrawWidth * Math.Sin(SweepStep3 + Pi));
                XTB9 = (float)(DrawWidth * Math.Cos(SweepStep3 - Pi / 12d));
                YTB9 = (float)(DrawWidth * Math.Sin(SweepStep3 - Pi / 12d));
                XTB10 = (float)(DrawWidth * Math.Cos(SweepStep3 + Pi / 12d));
                YTB10 = (float)(DrawWidth * Math.Sin(SweepStep3 + Pi / 12d));
                XTB11 = (float)(DrawWidth * Math.Cos(SweepStep3 + 2d * Pi / 3d - Pi / 12d));
                YTB11 = (float)(DrawWidth * Math.Sin(SweepStep3 + 2d * Pi / 3d - Pi / 12d));
                XTB12 = (float)(DrawWidth * Math.Cos(SweepStep3 + 2d * Pi / 3d + Pi / 12d));
                YTB12 = (float)(DrawWidth * Math.Sin(SweepStep3 + 2d * Pi / 3d + Pi / 12d));
                XTB13 = (float)(DrawWidth * Math.Cos(SweepStep3 + 4d * Pi / 3d - Pi / 12d));
                YTB13 = (float)(DrawWidth * Math.Sin(SweepStep3 + 4d * Pi / 3d - Pi / 12d));
                XTB14 = (float)(DrawWidth * Math.Cos(SweepStep3 + 4d * Pi / 3d + Pi / 12d));
                YTB14 = (float)(DrawWidth * Math.Sin(SweepStep3 + 4d * Pi / 3d + Pi / 12d));
                XTB15 = (float)(DrawWidth * Math.Cos(SweepStep3 + Pi - Pi / 12d));
                YTB15 = (float)(DrawWidth * Math.Sin(SweepStep3 + Pi - Pi / 12d));
                XTB16 = (float)(DrawWidth * Math.Cos(SweepStep3 + Pi + Pi / 12d));
                YTB16 = (float)(DrawWidth * Math.Sin(SweepStep3 + Pi + Pi / 12d));
                DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                Plan1graphic.DrawLine(DPen, 0f, 0f, XTB2, YTB2);
                Plan1graphic.DrawLine(DPen, 0f, 0f, XTB3, YTB3);
                if (optThreeBoat.Checked == true)
                {
                    DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    DPen.Color = Color.Red;
                    Plan1graphic.DrawLine(DPen, 0f, 0f, XTB1, YTB1);
                    DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                    Plan1graphic.DrawLine(DPen, 0f, 0f, XTB9, YTB9);
                    Plan1graphic.DrawLine(DPen, 0f, 0f, XTB10, YTB10);
                    DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
                    Plan1graphic.DrawLine(DPen, 0f, 0f, XTB11, YTB11);
                    Plan1graphic.DrawLine(DPen, 0f, 0f, XTB12, YTB12);
                    DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
                    Plan1graphic.DrawLine(DPen, 0f, 0f, XTB13, YTB13);
                    Plan1graphic.DrawLine(DPen, 0f, 0f, XTB14, YTB14);
                }

                if (optThreeBeach.Checked == true)
                {
                    DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    DPen.Color = Color.Red;
                    Plan1graphic.DrawLine(DPen, 0f, 0f, XTB8, YTB8);
                    DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                    Plan1graphic.DrawLine(DPen, 0f, 0f, XTB11, YTB11);
                    Plan1graphic.DrawLine(DPen, 0f, 0f, XTB14, YTB14);
                }
            }

        SaveBMandDisplay:
            ;
            SaveDisplayBMFname();
            return;
        }

        private void DisplayHorizonView()
        {
            Warning();
            var DFont1 = new Font("Times New Roman", 10f);
            var DFont2 = new Font("Times New Roman", 8f);
            var DFont3 = new Font("Times New Roman", 8f);

            // RecyclePlan1Jpg()

            // set up fresh / new bitmap and graphics drawwing object for diagram and later additions
            int DrawWidth = SkyPicBx.Width - 10;
            bm = new Bitmap(SkyPicBx.Width, SkyPicBx.Height);
            SkyPicBx.ImageLocation = null;
            Plan1graphic = Graphics.FromImage(bm);
            Plan1graphic.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Plan1graphic.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            Plan1graphic.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            // Plan1graphic.TranslateTransform(15, 0)

            var DPen = new Pen(Color.Black, 1f);
            DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            var ptA = new System.Windows.Point();
            var ptB = new System.Windows.Point();
            int x = 0;
            int y = 0;
            lblAltitude.Visible = true;
            lblAzimuth.Visible = true;
            lblAz.Visible = true;
            lblAlt.Visible = true;
            Label5.Visible = true;
            Label7.Visible = true;
            lblBody.Visible = true;
            lblBodyName.Visible = true;

            // lblOverhead.Visible = True
            chkFirst.Visible = true;
            chkSecond.Visible = true;
            chkThird.Visible = true;
            chkNames.Visible = true;
            chkLimit.Visible = true;
            chkHelper.Visible = true;
            FrameView.Visible = true;
            FrameDirection.Visible = true;
            lblN.Visible = false;
            lblS.Visible = true;
            lblSRight.Visible = true;
            lblSLeft.Visible = true;
            lblE.Visible = false;
            lblW.Visible = false;
            FrameBest.Visible = false;
            float i; // TwoPi,
            int Xdiv = 20;
            int Ydiv = 6;
            int drawYdelta = (int)(DrawWidth / (double)Ydiv);
            int drawY = 0;
            int drawXdelta = (int)(DrawWidth / (double)Xdiv);
            int drawX = drawXdelta;
            int MinZn = 0;
            int MaxZn = 0;
            int XPlotDelta = (int)(180d / Xdiv);
            int YPlotDelta = (int)(90d / Ydiv);
            var Lpt = new System.Windows.Point();
            Lpt = new System.Windows.Point(SkyPicBx.Location.X, SkyPicBx.Location.Y);
            Plan1graphic.DrawRectangle(DPen, 0, 0, DrawWidth, DrawWidth);
            drawY += drawYdelta;
            Plan1graphic.DrawLine(DPen, 0, drawY, DrawWidth, drawY);  // 75 degree altitude line
            Plan1graphic.DrawString("75" + '°', DFont3, DPen.Brush, DrawWidth - 18, drawY);
            Plan1graphic.DrawString("75" + '°', DFont3, DPen.Brush, +3, drawY);
            drawY += drawYdelta;
            DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            Plan1graphic.DrawLine(DPen, 0, drawY, DrawWidth, drawY); // 60 degree altitude line
            Plan1graphic.DrawString("60" + '°', DFont3, DPen.Brush, DrawWidth - 18, drawY);
            Plan1graphic.DrawString("60" + '°', DFont3, DPen.Brush, +3, drawY);
            drawY += drawYdelta;
            Plan1graphic.DrawLine(DPen, 0, drawY, DrawWidth, drawY);  // 45 degree altitude line
            Plan1graphic.DrawString("45" + '°', DFont3, DPen.Brush, DrawWidth - 18, drawY);
            Plan1graphic.DrawString("45" + '°', DFont3, DPen.Brush, +3, drawY);
            drawY += drawYdelta;
            Plan1graphic.DrawLine(DPen, 0, drawY, DrawWidth, drawY);  // 30 degree altitude line
            Plan1graphic.DrawString("30" + '°', DFont3, DPen.Brush, DrawWidth - 18, drawY);
            Plan1graphic.DrawString("30" + '°', DFont3, DPen.Brush, +3, drawY);
            DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            drawY += drawYdelta;
            Plan1graphic.DrawLine(DPen, 0, drawY, DrawWidth, drawY);  // 15 degree altitude line
            Plan1graphic.DrawString("15" + '°', DFont3, DPen.Brush, DrawWidth - 18, drawY);
            Plan1graphic.DrawString("15" + '°', DFont3, DPen.Brush, +3, drawY);
            DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            var loopTo = (float)Xdiv;
            for (i = 1f; i <= loopTo; i++)
            {
                Plan1graphic.DrawLine(DPen, drawX, 0, drawX, DrawWidth);
                drawX += drawXdelta;
            }

            if (optE.Checked == true)
            {
                MinZn = 0;
                MaxZn = 180;
            }

            if (optW.Checked == true)
            {
                MinZn = 180;
                MaxZn = 360;
            }

            if (optN.Checked == true)
            {
                MinZn = 270;
                MaxZn = 90;
            }

            if (optS.Checked == true)
            {
                MinZn = 90;
                MaxZn = 270;
            }

            DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            DPen.Brush = Brushes.Black;
            LowAz = (short)Conversion.Val(txtLowAz.Text);
            HighAz = (short)Conversion.Val(txtHighAz.Text);
            if (LowAz > HighAz)
            {
                HighAz = (short)(HighAz + 360);
            }

            var loopTo1 = (float)Information.UBound(VwBody1, 1);
            for (i = 0f; i <= loopTo1; i++)
                VwBody1.Initialize();
            // First magnitude bodies
            if (chkFirst.Checked == true)
            {
                VwBody1 = new BodyInfo[(I1 + 1)];
                var loopTo2 = (float)I1;
                for (i = 1f; i <= loopTo2; i++)
                {
                    Z1[(int)i] = Conversion.Val(Z1[(int)i]);
                    Z1Temp[(int)i] = Z1[(int)i];
                    if (Z1[(int)i] < LowAz)
                    {
                        Z1Temp[(int)i] = Z1[(int)i] + 360d;
                    }

                    if (optN.Checked == true)
                    {
                        if (Z1[(int)i] >= MinZn & Z1[(int)i] <= 360d)
                        {
                            x = (int)((Z1[(int)i] - MinZn) / XPlotDelta * drawXdelta);
                        }
                        else if (Z1[(int)i] >= 0d & Z1[(int)i] <= MaxZn)
                        {
                            x = (int)((Z1[(int)i] + 90d) / XPlotDelta * drawXdelta);
                        }
                        else
                        {
                            goto Next1Mag;
                        }
                    }
                    else
                    {
                        if (Z1[(int)i] < MinZn | Z1[(int)i] > MaxZn)
                        {
                            goto Next1Mag;
                        }

                        x = (int)((Z1[(int)i] - MinZn) / XPlotDelta * drawXdelta);
                    }

                    y = (int)((90d - H1A[(int)i]) / YPlotDelta * drawYdelta);
                    int Mag1size = 10;
                    int UleftX = x - 5;
                    int UleftY = y - 5;
                    Plan1graphic.DrawEllipse(DPen, UleftX, UleftY, Mag1size, Mag1size);
                    if (Body1[(int)i].ToString() == "Sun")
                    {
                        Plan1graphic.FillEllipse(Brushes.Yellow, UleftX, UleftY, Mag1size, Mag1size);
                    }
                    else if (Body1[(int)i].ToString() == "Moon")
                    {
                        Plan1graphic.FillEllipse(Brushes.LawnGreen, UleftX, UleftY, Mag1size, Mag1size);
                    }
                    else if (Body1[(int)i].ToString() == "Venus" | Body1[(int)i].ToString() == "Mars" | Body1[(int)i].ToString() == "Jupiter" | Body1[(int)i].ToString() == "Saturn")
                    {
                        Plan1graphic.FillEllipse(Brushes.Red, UleftX, UleftY, Mag1size, Mag1size);
                    }
                    else
                    {
                        Plan1graphic.FillEllipse(Brushes.Blue, UleftX, UleftY, Mag1size, Mag1size);
                    }

                    VwBody1[(int)i] = new BodyInfo();
                    VwBody1[(int)i].BodyName = Body1[(int)i];
                    VwBody1[(int)i].BodyLoc.X = x;
                    VwBody1[(int)i].BodyLoc.Y = y;
                    VwBody1[(int)i].BodyLocSz = 10;
                    VwBody1[(int)i].BodyAlt = H1A[(int)i].ToString();
                    VwBody1[(int)i].BodyAz = Z1[(int)i].ToString();
                    if (chkNames.Checked == true & chkLimit.Checked == false)
                    {
                        Plan1graphic.DrawString(Body1[(int)i].ToString(), new Font("Arial", 7f, System.Drawing.FontStyle.Regular), Brushes.Blue, x + 5, y + 5);
                        Plan1graphic.DrawString("Az:" + Z1[(int)i].ToString() + '°' + " Alt:" + H1A[(int)i].ToString() + '°', new Font("Arial", 7f, System.Drawing.FontStyle.Regular), Brushes.Blue, x + 5, y + (5 + DFont1.Height));
                    }

                Next1Mag:
                    ;
                }
            }

            var loopTo3 = (float)Information.UBound(VwBody2, 1);
            for (i = 0f; i <= loopTo3; i++)
                VwBody2.Initialize();
            // Second magnitude bodies
            if (chkSecond.Checked == true)
            {
                VwBody2 = new BodyInfo[(I2 + 1)];
                var loopTo4 = (float)I2;
                for (i = 1f; i <= loopTo4; i++)
                {
                    Z2[(int)i] = Conversion.Val(Z2[(int)i]);
                    Z2Temp[(int)i] = Z2[(int)i];
                    if (Z2[(int)i] < LowAz)
                        Z2Temp[(int)i] = Z2[(int)i] + 360d;
                    if (optN.Checked == true)
                    {
                        if (Z2[(int)i] >= MinZn & Z2[(int)i] <= 360d)
                        {
                            x = (int)((Z2[(int)i] - MinZn) / XPlotDelta * drawXdelta);
                        }
                        else if (Z2[(int)i] >= 0d & Z2[(int)i] <= MaxZn)
                        {
                            x = (int)((Z2[(int)i] + 90d) / XPlotDelta * drawXdelta);
                        }
                        else
                        {
                            goto Next2Mag;
                        }
                    }
                    else
                    {
                        if (Z2[(int)i] < MinZn | Z2[(int)i] > MaxZn)
                        {
                            goto Next2Mag;
                        }

                        x = (int)((Z2[(int)i] - MinZn) / XPlotDelta * drawXdelta);
                    }

                    y = (int)((90d - H2A[(int)i]) / YPlotDelta * drawYdelta);
                    int Mag1size = 8;
                    int UleftX = x - 4;
                    int UleftY = y - 4;
                    Plan1graphic.DrawEllipse(DPen, UleftX, UleftY, Mag1size, Mag1size);
                    Plan1graphic.FillEllipse(Brushes.DarkGray, UleftX, UleftY, Mag1size, Mag1size);
                    VwBody2[(int)i] = new BodyInfo();
                    VwBody2[(int)i].BodyName = Body2[(int)i];
                    VwBody2[(int)i].BodyLoc.X = x;
                    VwBody2[(int)i].BodyLoc.Y = y;
                    VwBody2[(int)i].BodyLocSz = 10;
                    VwBody2[(int)i].BodyAlt = H2A[(int)i].ToString();
                    VwBody2[(int)i].BodyAz = Z2[(int)i].ToString();
                    if (chkNames.Checked == true & chkLimit.Checked == false)
                    {
                        Plan1graphic.DrawString(Body2[(int)i].ToString(), new Font("Arial", 7f, System.Drawing.FontStyle.Regular), Brushes.DarkGray, x + 5, y + 5);
                        Plan1graphic.DrawString("Az:" + Z2[(int)i].ToString() + '°' + " Alt:" + H2A[(int)i].ToString() + '°', new Font("Arial", 7f, System.Drawing.FontStyle.Regular), Brushes.DarkGray, x + 5, y + (5 + DFont1.Height));
                    }

                Next2Mag:
                    ;
                }
            }
            // Third magnitude bodies
            var loopTo5 = (float)Information.UBound(VwBody3, 1);
            for (i = 0f; i <= loopTo5; i++)
                VwBody3.Initialize();
            if (chkThird.Checked == true)
            {
                VwBody3 = new BodyInfo[(I3 + 1)];
                var loopTo6 = (float)I3;
                for (i = 1f; i <= loopTo6; i++)
                {
                    Z3[(int)i] = Conversion.Val(Z3[(int)i]);
                    Z3Temp[(int)i] = Z3[(int)i];
                    if (Z3[(int)i] < LowAz)
                    {
                        Z3Temp[(int)i] = Z3[(int)i] + 360d;
                    }

                    if (optN.Checked == true)
                    {
                        if (Z3[(int)i] >= MinZn & Z3[(int)i] <= 360d)
                        {
                            x = (int)((Z3[(int)i] - MinZn) / XPlotDelta * drawXdelta);
                        }
                        else if (Z3[(int)i] >= 0d & Z3[(int)i] <= MaxZn)
                        {
                            x = (int)((Z3[(int)i] + 90d) / XPlotDelta * drawXdelta);
                        }
                        else
                        {
                            goto Next3Mag;
                        }
                    }
                    else
                    {
                        if (Z3[(int)i] < MinZn | Z3[(int)i] > MaxZn)
                        {
                            goto Next3Mag;
                        }

                        x = (int)((Z3[(int)i] - MinZn) / XPlotDelta * drawXdelta);
                    }

                    y = (int)((90d - H3A[(int)i]) / YPlotDelta * drawYdelta);
                    Plan1graphic.DrawEllipse(DPen, x, y, 6, 6);
                    Plan1graphic.FillEllipse(Brushes.LightGray, x, y, 6, 6);
                    VwBody3[(int)i] = new BodyInfo();
                    VwBody3[(int)i].BodyName = Body3[(int)i];
                    VwBody3[(int)i].BodyLoc.X = x;
                    VwBody3[(int)i].BodyLoc.Y = y;
                    VwBody3[(int)i].BodyLocSz = 10;
                    VwBody3[(int)i].BodyAlt = H3A[(int)i].ToString();
                    VwBody3[(int)i].BodyAz = Z3[(int)i].ToString();
                    if (chkNames.Checked == true & chkLimit.Checked == false)
                    {
                        Plan1graphic.DrawString(Body3[(int)i].ToString(), new Font("Arial", 7f, System.Drawing.FontStyle.Regular), Brushes.LightGray, x + 5, y + 5);
                        Plan1graphic.DrawString("Az:" + Z3[(int)i].ToString() + '°' + " Alt:" + H3A[(int)i].ToString() + '°', new Font("Arial", 7f, System.Drawing.FontStyle.Regular), Brushes.LightGray, x + 5, y + (5 + DFont1.Height));
                    }

                Next3Mag:
                    ;
                }
            }

            // See if Helper stars need to be shown
            if (chkHelper.Checked == true)
            {
                // First magnitude Helper stars
                var loopTo7 = (float)(NumberOfHelpers - 1);
                for (i = 0f; i <= loopTo7; i++)
                {
                    ZH1Temp[(int)i] = ZH1[(int)i];
                    if (ZH1[(int)i] < LowAz)
                    {
                        ZH1Temp[(int)i] = ZH1[(int)i] + 360;
                    }

                    if (optN.Checked == true)
                    {
                        if (ZH1[(int)i] >= MinZn & ZH1[(int)i] <= 360)
                        {
                            x = (int)((ZH1[(int)i] - MinZn) / (double)XPlotDelta * drawXdelta);
                        }
                        else if (ZH1[(int)i] >= 0 & ZH1[(int)i] <= MaxZn)
                        {
                            x = (int)((ZH1[(int)i] + 90) / (double)XPlotDelta * drawXdelta);
                        }
                        else
                        {
                            goto Next1MagHelp;
                        }
                    }
                    else
                    {
                        if (ZH1[(int)i] < MinZn | ZH1[(int)i] > MaxZn)
                        {
                            goto Next1MagHelp;
                        }

                        x = (int)((ZH1[(int)i] - MinZn) / (double)XPlotDelta * drawXdelta);
                    }

                    y = (int)((90 - HH1A[(int)i]) / (double)YPlotDelta * drawYdelta);
                    Plan1graphic.DrawEllipse(DPen, x, y, 6, 6);
                    Plan1graphic.FillEllipse(DPen.Brush, x, y, 6, 6);
                Next1MagHelp:
                    ;
                }

                // Second magnitude Helper stars
                var loopTo8 = (float)(NumberOfHelpers - 1);
                for (i = 0f; i <= loopTo8; i++)
                {
                    ZH2Temp[(int)i] = ZH2[(int)i];
                    if (ZH2[(int)i] < LowAz)
                    {
                        ZH2Temp[(int)i] = ZH2[(int)i] + 360;
                    }

                    if (optN.Checked == true)
                    {
                        if (ZH2[(int)i] >= MinZn & ZH2[(int)i] <= 360)
                        {
                            x = (int)((ZH2[(int)i] - MinZn) / (double)XPlotDelta * drawXdelta);
                        }
                        else if (ZH2[(int)i] >= 0 & ZH2[(int)i] <= MaxZn)
                        {
                            x = (int)((ZH2[(int)i] + 90) / (double)XPlotDelta * drawXdelta);
                        }
                        else
                        {
                            goto Next2MagHelp;
                        }
                    }
                    else
                    {
                        if (ZH2[(int)i] < MinZn | ZH2[(int)i] > MaxZn)
                        {
                            goto Next2MagHelp;
                        }

                        x = (int)((ZH2[(int)i] - MinZn) / (double)XPlotDelta * drawXdelta);
                    }

                    y = (int)((90 - HH2A[(int)i]) / (double)YPlotDelta * drawYdelta);
                    Plan1graphic.DrawEllipse(DPen, x, y, 6, 6);
                    Plan1graphic.FillEllipse(DPen.Brush, x, y, 6, 6);
                Next2MagHelp:
                    ;
                }

                // Third magnitude Helper stars
                var loopTo9 = (float)(NumberOfHelpers - 1);
                for (i = 0f; i <= loopTo9; i++)
                {
                    ZH3Temp[(int)i] = ZH3[(int)i];
                    if (ZH3[(int)i] < LowAz)
                    {
                        ZH3Temp[(int)i] = ZH3[(int)i] + 360;
                    }

                    if (optN.Checked == true)
                    {
                        if (ZH3[(int)i] >= MinZn & ZH3[(int)i] <= 360)
                        {
                            x = (int)((ZH3[(int)i] - MinZn) / (double)XPlotDelta * drawXdelta);
                        }
                        else if (ZH3[(int)i] >= 0 & ZH3[(int)i] <= MaxZn)
                        {
                            x = (int)((ZH3[(int)i] + 90) / (double)XPlotDelta * drawXdelta);
                        }
                        else
                        {
                            goto Next3MagHelp;
                        }
                    }
                    else
                    {
                        if (ZH3[(int)i] < MinZn | ZH3[(int)i] > MaxZn)
                        {
                            goto Next3MagHelp;
                        }

                        x = (int)((ZH3[(int)i] - MinZn) / (double)XPlotDelta * drawXdelta);
                    }

                    y = (int)((90 - HH3A[(int)i]) / (double)YPlotDelta * drawYdelta);
                    Plan1graphic.DrawEllipse(DPen, x, y, 6, 6);
                    Plan1graphic.FillEllipse(DPen.Brush, x, y, 6, 6);
                Next3MagHelp:
                    ;
                }
                // Fourth+ magnitude Helper stars
                var loopTo10 = (float)(NumberOfHelpers - 1);
                for (i = 0f; i <= loopTo10; i++)
                {
                    ZH4Temp[(int)i] = ZH4[(int)i];
                    if (ZH4[(int)i] < LowAz)
                    {
                        ZH4Temp[(int)i] = ZH4[(int)i] + 360;
                    }

                    if (optN.Checked == true)
                    {
                        if (ZH4[(int)i] >= MinZn & ZH3[(int)i] <= 360)
                        {
                            x = (int)((ZH3[(int)i] - MinZn) / (double)XPlotDelta * drawXdelta);
                        }
                        else if (ZH3[(int)i] >= 0 & ZH3[(int)i] <= MaxZn)
                        {
                            x = (int)((ZH3[(int)i] + 90) / (double)XPlotDelta * drawXdelta);
                        }
                        else
                        {
                            goto Next4MagHelp;
                        }
                    }
                    else
                    {
                        if (ZH3[(int)i] < MinZn | ZH3[(int)i] > MaxZn)
                        {
                            goto Next4MagHelp;
                        }

                        x = (int)((ZH3[(int)i] - MinZn) / (double)XPlotDelta * drawXdelta);
                    }

                    y = (int)((90 - HH4A[(int)i]) / (double)YPlotDelta * drawYdelta);
                    Plan1graphic.DrawEllipse(DPen, x, y, 6, 6);
                    Plan1graphic.FillEllipse(DPen.Brush, x, y, 6, 6);
                Next4MagHelp:
                    ;
                }
            }

        EndofDisHorizon:
            ;
            SaveDisplayBMFname();
            return;
        }

        public void SaveDisplayBMFname()
        {
            // Try
            if (System.IO.File.Exists(BMFname))
            {
                if (CommonGlobals.C_IsFileInUse(BMFname) == true)
                {
                    RecyclePlan1Jpg();
                }
                else
                {
                    System.IO.File.Delete(BMFname);
                    RecyclePlan1Jpg();
                }
            }

            bm.Save(BMFname);
            SkyPicBx.ImageLocation = BMFname;
            // bm.Save(BMFname)
            SkyPicBx.Refresh();
            ViewVisiblePg.Refresh();
            SkyPicBx.Image = null;
            bm.Dispose();
            return;
            // Catch ex1 As System.Runtime.InteropServices.ExternalException
            // Exit Sub
            // Catch ex As Exception
            // Dim file As System.IO.StreamWriter
            // file = My.Computer.FileSystem.OpenTextFileWriter("Plan1Log.txt", True)
            // file.WriteLine(Now.ToLongDateString & Space(2) & Now.ToLongTimeString & " - " & "Try #1 - Exception on BM Save: Name = " & BMFname & Space(2) & "  Exception: " & ex.ToString)
            // file.Close()
            // GoTo TryAgain
            // Finally

            // End Try
            // TryAgain:
            // Try
            // RecyclePlan1Jpg()
            // bm.Save(BMFname)
            // SkyPicBx.Refresh()
            // ViewVisiblePg.Refresh()
            // Exit Sub
            // Catch ex1 As System.Runtime.InteropServices.ExternalException
            // Exit Sub
            // Catch ex As Exception
            // Dim file As System.IO.StreamWriter
            // file = My.Computer.FileSystem.OpenTextFileWriter("Plan1Log.txt", True)
            // file.WriteLine(Now.ToLongDateString & Space(2) & Now.ToLongTimeString & " - " & "Try #2 - Exception on BM Save: Name =" & BMFname & "Exception: " & ex.ToString)
            // file.Close()
            // Exit Sub
            // End Try
            // SkyPicBx.Refresh()
            // ViewVisiblePg.Refresh()
            // Exit Sub
        }

        public int MouseX(int hWnd = 0)
        {
            return PointToClient(MousePosition).X;
        }

        public int MouseY(int hWnd = 0)
        {
            return PointToClient(MousePosition).Y;
        }

        private void chkNames_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            if (!FormSightPlanLoaded)
                return;
            BlankTimeFlag = false;
            ExecCmdTwilights();
            ViewVisibleBodies();
        }

        private void chkFirst_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            if (!FormSightPlanLoaded)
                return;
            BlankTimeFlag = false;
            ExecCmdTwilights();
            ViewVisibleBodies();
        }

        private void chkSecond_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            if (!FormSightPlanLoaded)
                return;
            BlankTimeFlag = false;
            ExecCmdTwilights();
            ViewVisibleBodies();
        }

        private void chkThird_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            if (!FormSightPlanLoaded)
                return;
            BlankTimeFlag = false;
            ExecCmdTwilights();
            ViewVisibleBodies();
        }

        public bool Helpers()
        {
            var loopTo = (short)(NumberOfHelpers - 1);
            for (k = 0; k <= loopTo; k++)
            {
                RDHelper1 = RDHelper[k];
                RMHelper1 = RMHelper[k];
                RSHelper1 = RSHelper[k];
                DDHelper1 = DDHelper[k];
                DMHelper1 = DMHelper[k];
                DSHelper1 = DSHelper[k];
                AR = RDHelper1 + RMHelper1 / 60d + RSHelper1 / 3600d;
                DE = Math.Abs(DDHelper1) + Math.Abs(DMHelper1) / 60d + Math.Abs(DSHelper1) / 3600d;
                if (Math.Sign(DDHelper1) == -1 | Math.Sign(DMHelper1) == -1 | Math.Sign(DSHelper1) == -1)
                {
                    DE = -DE;
                }

                AR = AR * 15d; // : AR = AR * Pi / 180: DE = DE * Pi / 180
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
                var loopTo1 = (short)(NumberOfHelpers - 1);
                for (j = 0; j <= loopTo1; j++)
                {
                    MagH1[k] = 0d;
                    ZH1[k] = 0;
                    HH1A[k] = 0;
                    MagH2[k] = 0d;
                    ZH2[k] = 0;
                    HH2A[k] = 0;
                    MagH3[k] = 0d;
                    ZH3[k] = 0;
                    HH3A[k] = 0;
                    MagH4[k] = 0d;
                    ZH4[k] = 0;
                    HH4A[k] = 0;
                }

                AltAz(); // go in with degrees
                if (Ho > 0d & MagHelper[k] < 1.55d)
                {
                    MagH1[k] = MagHelper[k];
                    ZH1[k] = (int)ZN;
                    HH1A[k] = (int)Ho;
                }

                if (Ho > 0d & MagHelper[k] > 1.55d & MagHelper[k] < 2.55d)
                {
                    MagH2[k] = MagHelper[k];
                    ZH2[k] = (int)ZN;
                    HH2A[k] = (int)Ho;
                }

                if (Ho > 0d & MagHelper[k] > 2.55d & MagHelper[k] < 3.55d)
                {
                    MagH3[k] = MagHelper[k];
                    ZH3[k] = (int)ZN;
                    HH3A[k] = (int)Ho;
                }

                if (Ho > 0d & MagHelper[k] > 3.55d)
                {
                    MagH4[k] = MagHelper[k];
                    ZH4[k] = (int)ZN;
                    HH4A[k] = (int)Ho;
                }
            }

            return true;
        }

        private void chkHelper_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            if (!FormSightPlanLoaded)
                return;
            if (chkHelper.Checked == true)
            {
                TempFirst = Conversions.ToBoolean(chkFirst.CheckState);
                TempSecond = Conversions.ToBoolean(chkSecond.CheckState);
                TempThird = Conversions.ToBoolean(chkThird.CheckState);
                chkFirst.CheckState = CheckState.Checked;
                chkFirst.Enabled = false;
                chkSecond.CheckState = CheckState.Checked;
                chkSecond.Enabled = false;
                chkThird.CheckState = CheckState.Checked;
                chkThird.Enabled = false;
            }

            if (chkHelper.Checked == false)
            {
                chkFirst.Enabled = true;
                if (TempFirst == true)
                {
                    chkFirst.CheckState = CheckState.Checked;
                }
                else
                {
                    chkFirst.CheckState = CheckState.Unchecked;
                }

                chkSecond.Enabled = true;
                if (TempSecond == true)
                {
                    chkSecond.CheckState = CheckState.Checked;
                }
                else
                {
                    chkSecond.CheckState = CheckState.Unchecked;
                }

                chkThird.Enabled = true;
                if (TempThird == true)
                {
                    chkThird.CheckState = CheckState.Checked;
                }
                else
                {
                    chkThird.CheckState = CheckState.Unchecked;
                }
            }

            BlankTimeFlag = false;
            ExecCmdTwilights();
            ViewVisibleBodies();
            return;
        }

        public void DisplaySunMoon()
        {
            Shape1.Visible = true;
            Shape1.Clear();
            if (FirstTime != 0d)
            {
                Shape1.Text = "Acceptable Sun-Moon fix from " + FTHours + FTMinutes + " To " + LTHours + LTMinutes + Environment.NewLine;
                Shape1.AppendText("Moon from " + Strings.Format(MoonPhaseFirst, "#0") + "% to " + Strings.Format(MoonPhaseLast, "#0") + "% illuminated" + Environment.NewLine);
            }

            if (FirstTime == 0d)
            {
                Shape1.Text = "No acceptable Sun-Moon fix this Date, location," + Environment.NewLine + "azimuth range, and minimum altitude ";
            }
        }

        public void Warning()
        {
            if (!FormSightPlanLoaded)
                return;
            txtTime.Text = DTPlan.Value.Hour.ToString("00") + DTPlan.Value.Minute.ToString("00");

            // If txtTime.Text = "" Then
            // rMsgBox("You must enter a desired ZT for body visibility Or Star Finder Data.", "Entry Error", MessageBoxButtons.OK)
            // txtTime.Focus()
            // Exit Sub
            // End If
            txtWarning.Visible = true;


            // Calculate AutoZD
            AutoZD = Conversion.Int(Lo / 15d + 0.5d);
            Time = (short)(60d * Conversion.Val(Strings.Left(txtTime.Text, 2)) + Conversion.Val(Strings.Right(txtTime.Text, 2)) - (AutoZD - ZD) * 60d);
            if (Time < 0)
                Time = (short)(Time + 1440);
            if (Time > 1440)
                Time = (short)(Time - 1440);
            C32 = (short)(60d * Conversion.Val(Strings.Left(C3[2], 2)) + Conversion.Val(Strings.Right(C3[2], 2)) - (AutoZD - ZD) * 60d);
            C33 = (short)(60d * Conversion.Val(Strings.Left(C3[3], 2)) + Conversion.Val(Strings.Right(C3[3], 2)) - (AutoZD - ZD) * 60d);
            C34 = (short)(60d * Conversion.Val(Strings.Left(C3[4], 2)) + Conversion.Val(Strings.Right(C3[4], 2)) - (AutoZD - ZD) * 60d);
            C35 = (short)(60d * Conversion.Val(Strings.Left(C3[5], 2)) + Conversion.Val(Strings.Right(C3[5], 2)) - (AutoZD - ZD) * 60d);
            C36 = (short)(60d * Conversion.Val(Strings.Left(C3[6], 2)) + Conversion.Val(Strings.Right(C3[6], 2)) - (AutoZD - ZD) * 60d);
            C37 = (short)(60d * Conversion.Val(Strings.Left(C3[7], 2)) + Conversion.Val(Strings.Right(C3[7], 2)) - (AutoZD - ZD) * 60d);
            if (C32 > 1440)
                C32 = (short)(C32 - 1440);
            if (C33 > 1440)
                C33 = (short)(C33 - 1440);
            if (C34 > 1440)
                C34 = (short)(C34 - 1440);
            if (C35 < 0)
                C35 = (short)(C35 + 1440);
            if (C36 < 0)
                C36 = (short)(C36 + 1440);
            if (C37 < 0)
                C37 = (short)(C37 + 1440);
            if (Time < C32 | Time >= C37)
            {
                txtWarning.ForeColor = Color.White;
                txtWarning.BackColor = Color.Black;
                txtWarning.Text = "Night"; // Else
            }

            if (Time >= C34 & Time < C35)
            {
                txtWarning.ForeColor = Color.Black;
                txtWarning.BackColor = Color.Yellow;
                txtWarning.Text = "Day"; // Else
            }

            if (Time >= C32 & Time < C34 | Time >= C35 & Time < C37)
            {
                txtWarning.ForeColor = Color.White;
                txtWarning.BackColor = Color.Blue;
                txtWarning.Text = "Twilight";
            }

            txtWarning.Refresh();
        }

        public bool Delta_T()
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
                DeltaT = 62.92d + 0.32217d * Theta + 0.005589d * Math.Pow(Theta, 2d);
            }       // V5.6.1 could replace 2050 with 2009
                    // Next line NOT added in V5.6.1.  For June 1, 2017, predicted DeltaT value 70.2481, measured DeltaT value 68.8033.  With this change predicted value becomes 68.7579
                    // If GYear >= 2010 And GYear <= 2099 Then DeltaT = 66.0699 + (DecYr - 2010) * 0.3604 'DeltaT increasing an average of about 0.36 seconds per year since the beginning of 2010 (66.0699)
            if (GYear >= 2051 & GYear <= 2099)
                DeltaT = -20 + 32d * Math.Pow((DecYr - 1820f) / 100f, 2d) - 0.5628d * (2150f - DecYr);        // NOT removed in V5.6.1
            return true;
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
                D = D - Conversion.Int(D / (2d * Pi)) * 2d * Pi;
            AR = D + Pre2; // radians
            DE = Math.Atan(C / (Math.Sqrt(-C * C + 1d) + 9.999999E-21d)); // arcsin(C), radians
                                                                          // AR = AR * 180 / Pi
                                                                          // DE = DE * 180 / Pi

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

        public void BestBodies()
        {
            if (!FormSightPlanLoaded)
                return;
            // IsMouseDown = True
            Activate();
            SweepStep2 = SweepStep2 + WhichWay;
            SweepStep3 = SweepStep3 + WhichWay;
            BlankTimeFlag = false;
            // ExecCmdTwilights()
            DisplayView();
            System.Windows.Forms.Application.DoEvents();
            while (IsMouseDown == true)
            {
                SweepStep2 = SweepStep2 + WhichWay;
                SweepStep3 = SweepStep3 + WhichWay;
                BlankTimeFlag = false;
                DisplayView();
                Show();
                System.Windows.Forms.Application.DoEvents();
                SkyPicBx.Focus();
                Thread.Sleep(100);
            }

            return;
        }

        private void SelectAllText(ref TextBox TB)
        {
            TB.SelectionStart = 0;
            TB.SelectionLength = Strings.Len(TB.Text);
        }

        public void ScaleFormSightPlanVar(SizeF SZ)
        {
            Scale(SZ);
        }

        public void SetTxtBxUlineOn(ref RichTextBox TB)
        {
            TB.SelectionFont = new Font(TB.Font, System.Drawing.FontStyle.Underline);
        }

        public void SetTxtBxBoldOn(ref RichTextBox TB)
        {
            TB.SelectionFont = new Font(TB.Font, System.Drawing.FontStyle.Bold);
        }

        public void SetTxtBxtoReg(ref RichTextBox TB)
        {
            TB.SelectionFont = new Font(TB.Font, System.Drawing.FontStyle.Regular);
        }

        public void RecyclePlan1Jpg()
        {
            // Dim NowTimeStr As String = Now.ToLongTimeString.Replace(":", "").Replace(" ", "").Replace("-", "").Replace("/", "").Trim
            string NowTimeStr = DateAndTime.Now.ToString("HHmmssff");
            VBMath.Randomize();
            float RandomInt = Conversions.ToSingle(VBMath.Rnd().ToString("0000"));
            BMFname = "./Graphics/PlanForm" + NowTimeStr + RandomInt.ToString().Replace(".", "") + ".jpg";
            return;
        }

        public void CleanOutOldFiles()
        {
                foreach (string foundFile in My.MyProject.Computer.FileSystem.GetFiles(My.MyProject.Computer.FileSystem.CurrentDirectory + "/Graphics", VB.FileIO.SearchOption.SearchTopLevelOnly, "PlanForm*.jpg"))
                    My.MyProject.Computer.FileSystem.DeleteFile(foundFile);
            return;
        }

        private void ErrorMsgBox(string ErrMsg, string TitleStr, MessageBoxButtons MsgBtn)
        {
            System.Windows.Forms.MessageBox.Show(ErrMsg, TitleStr, MsgBtn, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, System.Windows.Forms.MessageBoxOptions.DefaultDesktopOnly);
            return;
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

            System.Windows.Forms.MessageBox.Show(SendStr, HdrStr, MessageBoxButtons.OK, IconType, MessageBoxDefaultButton.Button1, System.Windows.Forms.MessageBoxOptions.DefaultDesktopOnly);
            Show();
            return;
        }

        private void DisplaySunRiseSunSet()
        {
            Graphics SRSSGraphic;
            string SRSSFileName = "./Graphics/SunRiseSunSet.jpg";
            Bitmap bmsrss;
            short XTD1, YTD1;
            short XTD2, YTD2;
            double TwoPi, i;
            // FormSRF.Font.Name = "MS Sans Serif"
            TwoPi = 8d * Math.Atan(1d);
            SunRiseSet.Enabled = true;
            SunRiseSet.Visible = true;
            // set up fresh / new bitmap and graphics drawwing object for diagram and later additions
            double DrawWidth = SunRiseSet.Height / 2d - 20d;
            bmsrss = new Bitmap(SunRiseSet.Width, SunRiseSet.Height);
            SRSSGraphic = Graphics.FromImage(bmsrss);
            SRSSGraphic.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            SRSSGraphic.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            SRSSGraphic.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            SRSSGraphic.TranslateTransform((float)(SunRiseSet.Width / 2d), (float)(SunRiseSet.Height / 2d));
            var DPen = new Pen(Color.Black, 1f);
            DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            var ptA = new System.Windows.Point();
            var ptB = new System.Windows.Point();
            // standard code intro to any of the 4 major processing routines for this form.
            CheckDate();
            Warning();
            StarMagnitudes();
            Calculate();
            // Now display the sunrise / sunset data 
            int CircleRadii = (int)(DrawWidth + 5d);
            SRSSGraphic.DrawEllipse(DPen, -CircleRadii, -CircleRadii, 2 * CircleRadii, 2 * CircleRadii);
            SRSSGraphic.FillEllipse(Brushes.LightGoldenrodYellow, -CircleRadii, -CircleRadii, 2 * CircleRadii, 2 * CircleRadii);
            int Hr = 18;
            var StrFormat = new StringFormat();
            StrFormat.Alignment = StringAlignment.Center;
            StrFormat.LineAlignment = StringAlignment.Center;
            var loopTo = TwoPi;
            for (i = 0d; TwoPi / 24d >= 0 ? i <= loopTo : i >= loopTo; i += TwoPi / 24d)
            {
                XTD1 = (short)((DrawWidth - 5d) * Math.Cos(i));
                YTD1 = (short)((DrawWidth - 5d) * Math.Sin(i));
                XTD2 = (short)((DrawWidth + 5d) * Math.Cos(i));
                YTD2 = (short)((DrawWidth + 5d) * Math.Sin(i));
                SRSSGraphic.DrawLine(DPen, XTD1, YTD1, XTD2, YTD2);
                XTD1 = (short)((DrawWidth - 10d) * Math.Cos(i));
                YTD1 = (short)((DrawWidth - 10d) * Math.Sin(i));
                SRSSGraphic.DrawString(Hr.ToString("00") + "Hr", new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold), Brushes.Black, XTD1, YTD1, StrFormat);
                Hr += 1;
                if (Hr > 24)
                {
                    Hr -= 24;
                }
            }

            var loopTo1 = TwoPi;
            for (i = 0d; TwoPi / 96d >= 0 ? i <= loopTo1 : i >= loopTo1; i += TwoPi / 96d)
            {
                XTD1 = (short)((DrawWidth + 2d) * Math.Cos(i)); // 600
                YTD1 = (short)((DrawWidth + 2d) * Math.Sin(i)); // 600
                XTD2 = (short)((DrawWidth + 5d) * Math.Cos(i));
                YTD2 = (short)((DrawWidth + 5d) * Math.Sin(i));
                SRSSGraphic.DrawLine(DPen, XTD1, YTD1, XTD2, YTD2);
            }

            SRSSGraphic.DrawLine(DPen, 0, 0, 0, -CircleRadii);
            SRSSGraphic.DrawString("Noon", new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold), Brushes.Black, 0f, (float)(-CircleRadii - 8.25d), StrFormat);
            SRSSGraphic.DrawLine(DPen, 0, 0, 0, CircleRadii);
            SRSSGraphic.DrawString("MidNight", new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold), Brushes.Black, 0f, (float)(CircleRadii + 8.25d), StrFormat);
            SRSSGraphic.DrawLine(DPen, 0, 0, -CircleRadii, 0);
            SRSSGraphic.DrawString("6am", new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold), Brushes.Black, -CircleRadii - 25, 0f, StrFormat);
            SRSSGraphic.DrawLine(DPen, 0, 0, CircleRadii, 0);
            SRSSGraphic.DrawString("6pm", new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold), Brushes.Black, CircleRadii + 25, 0f, StrFormat);
            switch (cboLineWidth.SelectedIndex)
            {
                case 0:
                    {
                        DPen.Width = 1f; // Thin
                        break;
                    }

                case 1:
                    {
                        DPen.Width = 2f; // Regular
                        break;
                    }

                case 2:
                    {
                        DPen.Width = 3f; // Large
                        break;
                    }

                case 3:
                    {
                        DPen.Width = 4f; // X-Large
                        break;
                    }

                default:
                    {
                        DPen.Width = 1f; // Oops
                        break;
                    }
            }

            DPen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            DPen.StartCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;
            string TStr = "";
            double Angle = 0d;
            string Dashes4 = "----";
            if ((C3[1] ?? "") != (Dashes4 ?? ""))
            {
                Angle = CTimetoAngle(C3[1]);
                XTD1 = (short)(DrawWidth * Math.Cos(Angle));
                YTD1 = (short)(DrawWidth * Math.Sin(Angle));
                DPen.Color = Color.Navy;
                SRSSGraphic.DrawLine(DPen, 0, 0, XTD1, YTD1);
                XTD1 = (short)(1.1d * DrawWidth * Math.Cos(Angle));
                YTD1 = (short)(1.1d * DrawWidth * Math.Sin(Angle));
                TStr = "AM Astro Twilight: " + C3[1];
                SRSSGraphic.DrawString(TStr, new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold), Brushes.Navy, XTD1 - TStr.Length * 5, YTD1);
            }

            if ((C3[2] ?? "") != (Dashes4 ?? ""))
            {
                Angle = CTimetoAngle(C3[2]);
                XTD1 = (short)(DrawWidth * Math.Cos(Angle));
                YTD1 = (short)(DrawWidth * Math.Sin(Angle));
                DPen.Color = Color.DarkViolet;
                SRSSGraphic.DrawLine(DPen, 0, 0, XTD1, YTD1);
                XTD1 = (short)(1.1d * DrawWidth * Math.Cos(Angle));
                YTD1 = (short)(1.1d * DrawWidth * Math.Sin(Angle));
                TStr = "AM Nautical Twilight: " + C3[2];
                SRSSGraphic.DrawString(TStr, new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold), Brushes.DarkViolet, XTD1 - TStr.Length * 5, YTD1);
            }

            if ((C3[3] ?? "") != (Dashes4 ?? ""))
            {
                Angle = CTimetoAngle(C3[3]);
                XTD1 = (short)(DrawWidth * Math.Cos(Angle));
                YTD1 = (short)(DrawWidth * Math.Sin(Angle));
                DPen.Color = Color.BlueViolet;
                SRSSGraphic.DrawLine(DPen, 0, 0, XTD1, YTD1);
                XTD1 = (short)(1.1d * DrawWidth * Math.Cos(Angle));
                YTD1 = (short)(1.1d * DrawWidth * Math.Sin(Angle));
                TStr = "AM Civil Twilight: " + C3[3];
                SRSSGraphic.DrawString(TStr, new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold), Brushes.BlueViolet, XTD1 - TStr.Length * 5, YTD1);
            }

            double AMSunRise = 0d;
            double PMSunSet = 0d;
            if ((C3[4] ?? "") != (Dashes4 ?? ""))
            {
                Angle = CTimetoAngle(C3[4]);
                XTD1 = (short)(DrawWidth * Math.Cos(Angle));
                YTD1 = (short)(DrawWidth * Math.Sin(Angle));
                DPen.Color = Color.Blue;
                SRSSGraphic.DrawLine(DPen, 0, 0, XTD1, YTD1);
                XTD1 = (short)(1.1d * DrawWidth * Math.Cos(Angle));
                YTD1 = (short)(1.1d * DrawWidth * Math.Sin(Angle));
                TStr = "AM Sunrise: " + C3[4];
                SRSSGraphic.DrawString(TStr, new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold), Brushes.Blue, XTD1 - TStr.Length * 5, YTD1);
                AMSunRise = Angle;
            }

            if ((C3[5] ?? "") != (Dashes4 ?? ""))
            {
                Angle = CTimetoAngle(C3[5]);
                XTD1 = (short)(DrawWidth * Math.Cos(Angle));
                YTD1 = (short)(DrawWidth * Math.Sin(Angle));
                DPen.Color = Color.Blue;
                SRSSGraphic.DrawLine(DPen, 0, 0, XTD1, YTD1);
                XTD1 = (short)(1.1d * DrawWidth * Math.Cos(Angle));
                YTD1 = (short)(1.1d * DrawWidth * Math.Sin(Angle));
                SRSSGraphic.DrawString("PM Sunset: " + C3[5], new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold), Brushes.Blue, XTD1, YTD1);
                PMSunSet = Angle;
            }

            if ((C3[6] ?? "") != (Dashes4 ?? ""))
            {
                Angle = CTimetoAngle(C3[6]);
                XTD1 = (short)(DrawWidth * Math.Cos(Angle));
                YTD1 = (short)(DrawWidth * Math.Sin(Angle));
                DPen.Color = Color.BlueViolet;
                SRSSGraphic.DrawLine(DPen, 0, 0, XTD1, YTD1);
                XTD1 = (short)(1.1d * DrawWidth * Math.Cos(Angle));
                YTD1 = (short)(1.1d * DrawWidth * Math.Sin(Angle));
                SRSSGraphic.DrawString("PM Civil Twilight: " + C3[6], new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold), Brushes.BlueViolet, XTD1, YTD1);
            }

            if ((C3[7] ?? "") != (Dashes4 ?? ""))
            {
                Angle = CTimetoAngle(C3[7]);
                XTD1 = (short)(DrawWidth * Math.Cos(Angle));
                YTD1 = (short)(DrawWidth * Math.Sin(Angle));
                DPen.Color = Color.DarkViolet;
                SRSSGraphic.DrawLine(DPen, 0, 0, XTD1, YTD1);
                XTD1 = (short)(1.1d * DrawWidth * Math.Cos(Angle));
                YTD1 = (short)(1.1d * DrawWidth * Math.Sin(Angle));
                SRSSGraphic.DrawString("PM Nautical Twilight: " + C3[7], new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold), Brushes.DarkViolet, XTD1, YTD1);
            }

            if ((C3[8] ?? "") != (Dashes4 ?? ""))
            {
                Angle = CTimetoAngle(C3[8]);
                XTD1 = (short)(DrawWidth * Math.Cos(Angle));
                YTD1 = (short)(DrawWidth * Math.Sin(Angle));
                DPen.Color = Color.Navy;
                SRSSGraphic.DrawLine(DPen, 0, 0, XTD1, YTD1);
                XTD1 = (short)(1.1d * DrawWidth * Math.Cos(Angle));
                YTD1 = (short)(1.1d * DrawWidth * Math.Sin(Angle));
                SRSSGraphic.DrawString("PM Astro Twilight: " + C3[8], new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold), Brushes.Navy, XTD1, YTD1);
            }

            // Get moonrise and moonset data from text field on form and then parse out the time fields on it
            string MoonStr = MoonTxtBx.Text.ToString();
            string MoonRiseFixed = "Moonrise at ZT ";
            string MoonSetFixed = "Moonset  at ZT ";
            int MoonRiseLoc = MoonStr.IndexOf(MoonRiseFixed);
            int MoonSetLoc = MoonStr.IndexOf(MoonSetFixed);
            double MoonRiseAngle = 0d;
            double MoonSetAngle = 0d;
            System.Windows.Point MoonRisePt;
            System.Windows.Point MoonSetPt;

            // Now parse out moonrise time and draw it

            if (MoonRiseLoc != -1)
            {
                string MoonRiseTime = MoonStr.Substring(MoonRiseLoc + MoonRiseFixed.Length, 4);
                Angle = CTimetoAngle(MoonRiseTime);
                MoonRiseAngle = Angle;
                XTD1 = (short)(DrawWidth * Math.Cos(Angle));
                YTD1 = (short)(DrawWidth * Math.Sin(Angle));
                DPen.Color = Color.Red;
                SRSSGraphic.DrawLine(DPen, 0, 0, XTD1, YTD1);
                MoonRisePt = new System.Windows.Point(XTD1, YTD1);
                XTD1 = (short)(1.1d * DrawWidth * Math.Cos(Angle));
                YTD1 = (short)(1.1d * DrawWidth * Math.Sin(Angle));
                TStr = "Moonrise at: " + MoonRiseTime;
                double AngleDeg = Angle * 180d / Pi;
                if (AngleDeg > 90d & AngleDeg < 270d)
                {
                    SRSSGraphic.DrawString(TStr, new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold), Brushes.Red, XTD1 - TStr.Length * 5, YTD1);
                }
                else
                {
                    SRSSGraphic.DrawString(TStr, new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold), Brushes.Red, XTD1, YTD1);
                }
            }
            else
            {
                SRSSGraphic.DrawString("No MoonRise for this Date & time", new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold), Brushes.Red, (float)-(SunRiseSet.Width / 2d - 40d), (float)-(SunRiseSet.Height / 2d - 40d));
            }
            // now parse out moonset time and draw it
            if (MoonSetLoc != -1)
            {
                string MoonSetTime = MoonStr.Substring(MoonSetLoc + MoonSetFixed.Length, 4);
                Angle = CTimetoAngle(MoonSetTime);
                MoonSetAngle = Angle;
                XTD1 = (short)(DrawWidth * Math.Cos(Angle));
                YTD1 = (short)(DrawWidth * Math.Sin(Angle));
                DPen.Color = Color.Red;
                SRSSGraphic.DrawLine(DPen, 0, 0, XTD1, YTD1);
                MoonSetPt = new System.Windows.Point(XTD1, YTD1);
                XTD1 = (short)(1.1d * DrawWidth * Math.Cos(Angle));
                YTD1 = (short)(1.1d * DrawWidth * Math.Sin(Angle));
                TStr = "Moonset at: " + MoonSetTime;
                double AngleDeg = Angle * 180d / Pi;
                if (AngleDeg > 90d & AngleDeg < 270d)
                {
                    SRSSGraphic.DrawString(TStr, new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold), Brushes.Red, XTD1 - TStr.Length * 5, YTD1);
                }
                else
                {
                    SRSSGraphic.DrawString(TStr, new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold), Brushes.Red, XTD1, YTD1);
                }
            }
            else
            {
                SRSSGraphic.DrawString("No MoonSet for this Date & time", new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold), Brushes.Red, (float)-(SunRiseSet.Width / 2d - 40d), (float)-(SunRiseSet.Height / 2d - 50d));
            }
            // draw arc from moonrise to moonset to illustrate when moon is visible
            int MRDeg = (int)(MoonRiseAngle * 180d / Pi);
            if (MRDeg > 360)
            {
                MRDeg = MRDeg - 360;
            }

            int MSDeg = (int)(MoonSetAngle * 180d / Pi);
            if (MSDeg > 360)
            {
                MSDeg = MSDeg - 360;
            }

            double Quad = Pi / 2d;
            if (MoonRiseLoc != -1 & MoonSetLoc != -1)
            {
                var Rect = new RectangleF((float)-(CircleRadii / 2d), (float)-(CircleRadii / 2d), CircleRadii, CircleRadii);
                float Sweep = 0f; // -1 *( Convert.ToSingle(MoonRiseAngle * 180 / Pi) - Convert.ToSingle(MoonSetAngle * 180 / Pi))
                if (MRDeg > 270 & MRDeg <= 359)
                {
                    MRDeg = MRDeg - 360;
                }

                if (MSDeg > 270 & MSDeg <= 359)
                {
                    MSDeg = MSDeg - 360;
                }

                Sweep = 360 - (MRDeg - MSDeg);
                if (Sweep >= 360f)
                {
                    Sweep = Math.Abs(360f - Sweep);
                }

                // If MSDeg < MRDeg Then
                // If MRDeg > 270 And MRDeg < 360 Then
                // Sweep = MRDeg - MSDeg
                // Else
                // Sweep = -1 * (MRDeg - MSDeg)
                // End If
                // Else
                // If MRDeg > 270 And MRDeg < 360 Then
                // Sweep = MRDeg - MSDeg
                // Else
                // Sweep = -1 * ((MRDeg - MSDeg))
                // End If
                // End If

                DPen.Color = Color.Red;
                if (Sweep > 0f)
                {
                    Sweep = Sweep - 2f;
                }
                else
                {
                    Sweep = Sweep + 2f;
                }

                SRSSGraphic.DrawArc(DPen, Rect, Convert.ToSingle(MoonRiseAngle * 180d / Pi), Sweep);
                System.Windows.Point WrtPt;
                if (MRDeg >= 0 & MRDeg < 90)
                {
                    WrtPt = new System.Windows.Point(-(CircleRadii / 3d), CircleRadii / 3d);
                    Quad = Pi / 2d;
                }
                else if (MRDeg >= 90 & MRDeg < 180)
                {
                    WrtPt = new System.Windows.Point(-(CircleRadii / 3d), -(CircleRadii / 3d));
                    Quad = Pi;
                }
                else
                {
                    WrtPt = new System.Windows.Point(CircleRadii / 3d, CircleRadii / 3d);
                    Quad = 3d * Pi / 2d;
                }

                SRSSGraphic.DrawString("Moon is Visible", new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold), Brushes.Red, (float)WrtPt.X, (float)WrtPt.Y);
            }

            double LanAngle = 0d;
            if (chkNoonSightLAN.Checked == true)
            {
                string[] TmpTime;
                TmpTime = new string[4];
                TmpTime = txtLAN.Text.ToString().Split(':');
                var TS = new TimeSpan(Convert.ToInt32(TmpTime[0]), Convert.ToInt32(TmpTime[1]), Convert.ToInt32(TmpTime[2]));
                if (TS.Seconds >= 30)
                {
                    TS = TS.Add(new TimeSpan(0, 1, 0));
                }

                string TSStr = TS.ToString("hhmm");
                Angle = CTimetoAngle(TSStr);
                XTD1 = (short)(DrawWidth * Math.Cos(Angle));
                YTD1 = (short)(DrawWidth * Math.Sin(Angle));
                DPen.Color = Color.Blue;
                SRSSGraphic.DrawLine(DPen, 0, 0, XTD1, YTD1);
                LanAngle = Angle;
                XTD1 = (short)(1.1d * DrawWidth * Math.Cos(Angle));
                YTD1 = (short)(1.1d * DrawWidth * Math.Sin(Angle));
                TStr = "LAN Time: " + TSStr;
                double AngleDeg = Angle * 180d / Pi;
                if (AngleDeg > 90d & AngleDeg < 270d)
                {
                    SRSSGraphic.DrawString(TStr, new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold), Brushes.Blue, XTD1 - TStr.Length * 5, YTD1);
                }
                else
                {
                    SRSSGraphic.DrawString(TStr, new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold), Brushes.Blue, XTD1, YTD1);
                }
            }

            double SRDeg = AMSunRise * 180d / Pi;
            if (SRDeg > 360d)
            {
                SRDeg = SRDeg - 360d;
            }

            double SSDeg = PMSunSet * 180d / Pi;
            if (MSDeg > 360)
            {
                MSDeg = MSDeg - 360;
            }

            DPen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            DPen.StartCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;
            var Rect1 = new RectangleF((float)-(CircleRadii / 3d), (float)-(CircleRadii / 3d), (float)(CircleRadii * (2d / 3d)), (float)(CircleRadii * (2d / 3d)));
            float Sweep1 = Convert.ToSingle(PMSunSet * 180d / Pi) - Convert.ToSingle(AMSunRise * 180d / Pi);
            if (SSDeg < SRDeg)
            {
                Sweep1 = (float)(-1 * (360d - (SRDeg - SSDeg)));
            }
            else
            {
                Sweep1 = (float)(-1 * (SRDeg - SSDeg));
            }
            // Sweep1 = Convert.ToSingle(360 - (AMSunRise * 180 / Pi)) + Convert.ToSingle(PMSunSet * 180 / Pi)
            // Else
            // Sweep1 = Convert.ToSingle(PMSunSet * 180 / Pi) - Convert.ToSingle(AMSunRise * 180 / Pi)
            // End If
            DPen.Color = Color.Blue;
            if (Sweep1 > 0f)
            {
                Sweep1 = Sweep1 - 3f;
            }
            else
            {
                Sweep1 = Sweep1 + 3f;
            }

            SRSSGraphic.DrawArc(DPen, Rect1, Convert.ToSingle(AMSunRise * 180d / Pi), Sweep1);
            var WrtPt1 = new System.Windows.Point(-35, -(CircleRadii / 3d) + 15d);
            SRSSGraphic.DrawString("DayLight Hours", new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold), Brushes.Blue, (float)WrtPt1.X, (float)WrtPt1.Y);

            // draw mini-sun on line in yellow rimmed in blue to illustrate where sun rises and sets
            if (chkNoonSightLAN.Checked == true)
            {
                DPen.Color = Color.Blue;
                XTD1 = (short)(1d / 3d * DrawWidth * Math.Cos(LanAngle));
                YTD1 = (short)(1d / 3d * DrawWidth * Math.Sin(LanAngle));
                var SunRect = new Rectangle(XTD1 - 4, YTD1 - 4, 8, 8);
                SRSSGraphic.DrawEllipse(DPen, SunRect);
                SRSSGraphic.FillEllipse(Brushes.Yellow, SunRect);
            }
            // draw mini-sun on line in yellow rimmed in blue to illustrate where sun rises and sets
            DPen.Color = Color.Blue;
            XTD1 = (short)(1d / 3d * DrawWidth * Math.Cos(AMSunRise));
            YTD1 = (short)(1d / 3d * DrawWidth * Math.Sin(AMSunRise));
            var SunRect1 = new Rectangle(XTD1 - 4, YTD1 - 4, 8, 8);
            SRSSGraphic.DrawEllipse(DPen, SunRect1);
            SRSSGraphic.FillEllipse(Brushes.Yellow, SunRect1);
            // draw mini-sun on line in yellow rimmed in blue to illustrate where sun rises and sets
            DPen.Color = Color.Blue;
            XTD1 = (short)(1d / 3d * DrawWidth * Math.Cos(PMSunSet));
            YTD1 = (short)(1d / 3d * DrawWidth * Math.Sin(PMSunSet));
            var SunRect2 = new Rectangle(XTD1 - 4, YTD1 - 4, 8, 8);
            SRSSGraphic.DrawEllipse(DPen, SunRect2);
            SRSSGraphic.FillEllipse(Brushes.Yellow, SunRect2);

            // draw mini-moon on line in yellow rimmed in blue to illustrate where moon rises and sets
            // DPen.Color = Color.Red
            // XTD1 = (1 / 2) * (CircleRadii) * System.Math.Cos(Quad)
            // YTD1 = (1 / 2) * (CircleRadii) * System.Math.Sin(Quad)
            // Dim moonRect As Rectangle = New Rectangle(XTD1 - 4, YTD1 - 4, 8, 8)
            // SRSSGraphic.DrawEllipse(DPen, moonRect)
            // SRSSGraphic.FillEllipse(Brushes.Cyan, moonRect)
            // draw mini-moon on line in yellow rimmed in blue to illustrate where moon rises and sets
            DPen.Color = Color.Red;
            XTD1 = (short)(1d / 2d * CircleRadii * Math.Cos(MoonRiseAngle));
            YTD1 = (short)(1d / 2d * CircleRadii * Math.Sin(MoonRiseAngle));
            var moonRect1 = new Rectangle(XTD1 - 4, YTD1 - 4, 8, 8);
            SRSSGraphic.DrawEllipse(DPen, moonRect1);
            SRSSGraphic.FillEllipse(Brushes.Cyan, moonRect1);
            // draw mini-moon on line in yellow rimmed in blue to illustrate where moon rises and sets
            DPen.Color = Color.Red;
            XTD1 = (short)(1d / 2d * CircleRadii * Math.Cos(MoonSetAngle));
            YTD1 = (short)(1d / 2d * CircleRadii * Math.Sin(MoonSetAngle));
            var moonRect2 = new Rectangle(XTD1 - 4, YTD1 - 4, 8, 8);
            SRSSGraphic.DrawEllipse(DPen, moonRect2);
            SRSSGraphic.FillEllipse(Brushes.Cyan, moonRect2);
            if (VB.FileIO.FileSystem.FileExists(SRSSFileName))
            {
                VB.FileIO.FileSystem.DeleteFile(SRSSFileName);
            }

            bmsrss.Save(SRSSFileName);
            SunRiseSet.ImageLocation = SRSSFileName;
            SunRiseSet.Visible = true;
            SunRiseSet.Refresh();
            bmsrss.Dispose();
            return;
        }

        public System.Windows.Point SetPrintTextPt(System.Windows.Point Ptin, int CxIn, int CyIn)
        {
            var PtOut = new System.Windows.Point(0d, 0d);
            if (Ptin.X >= 0d)
            {
                if (Ptin.Y >= 0d)
                {
                    PtOut.X = Ptin.X + CxIn / 2d;
                    PtOut.Y = Ptin.Y + CyIn / 2d;
                }
                else
                {
                    PtOut.X = Ptin.X + CxIn / 2d;
                    PtOut.Y = Ptin.Y - CyIn;
                }
            }
            else if (Ptin.Y >= 0d)
            {
                PtOut.X = Ptin.X - CxIn;
                PtOut.Y = Ptin.Y + CyIn / 2d;
            }
            else
            {
                PtOut.X = Ptin.X - CxIn;
                PtOut.Y = Ptin.Y - CyIn;
            }

            return PtOut;
        }

        private double CTimetoAngle(string StrIn)
        {
            double TwoPi = 8d * Math.Atan(1d);
            double HrIn = Convert.ToDouble(StrIn.Substring(0, 2));
            double MinIn = Convert.ToDouble(StrIn.Substring(2, 2));
            double Time = HrIn + MinIn / 60.0d;
            double TimeRad = Time * TwoPi / 24d + 90d * Pi / 180d;
            return TimeRad;
        }

        private void GetLANtime()
        {
            // first check that Lat and Long degrees / minutes are entered
            if (string.IsNullOrEmpty(txtLDeg.Text) | string.IsNullOrEmpty(txtLMin.Text) | string.IsNullOrEmpty(txtLoDeg.Text) | string.IsNullOrEmpty(txtLoMin.Text))
            {
                SendMsgBx("Lat or Long Degrees or Minutes Are Missing - Must Enter all values to access LAN from NoonSight", MessageBoxIcon.Error);
                chkNoonSightLAN.CheckState = CheckState.Unchecked;
                return;
            }
            // if NoonSight FormNoonSight is already open then exec clear button click to clear out form
            if (System.Windows.Forms.Application.OpenForms.OfType<FormNoonSight>().Any())
            {
                My.MyProject.Forms.FormNoonSight.ClearScrBtn.PerformClick();
            }

            My.MyProject.Forms.FormNoonSight.Show();
            My.MyProject.Forms.FormNoonSight.DTNoonSight.Value = DTPlan.Value;
            My.MyProject.Forms.FormNoonSight.txtDRLDeg.Text = txtLDeg.Text;
            My.MyProject.Forms.FormNoonSight.txtDRLMin.Text = txtLMin.Text;
            My.MyProject.Forms.FormNoonSight.cboDRL.SelectedIndex = cboL.SelectedIndex;
            My.MyProject.Forms.FormNoonSight.txtLoDeg.Text = txtLoDeg.Text;
            My.MyProject.Forms.FormNoonSight.txtLoMin.Text = txtLoMin.Text;
            My.MyProject.Forms.FormNoonSight.cboLo.SelectedIndex = cboLo.SelectedIndex;
            
            if (chkDST.Checked == true)
            {
                My.MyProject.Forms.FormNoonSight.chkDST.Checked = true;
            }
            else
            {
                My.MyProject.Forms.FormNoonSight.chkDST.Checked = false;
            }

            My.MyProject.Forms.FormNoonSight.cmdLAN.PerformClick();
            // sleep this program / thread for 2 seconds
            Thread.Sleep(500);
            txtLAN.Text = My.MyProject.Forms.FormNoonSight.txtTime.Text;
            My.MyProject.Forms.FormNoonSight.Refresh();

            // FormNoonSight.Close()
            Show();
            return;
        }

        private void btnAdd1Month_Click(object sender, EventArgs e)
        {
            if (!FormSightPlanLoaded)
                return;
            DTPlan.Value = DTPlan.Value.AddMonths(+1);
            cmdTwilights.PerformClick();
        }

        private void btnAdd1Year_Click(object sender, EventArgs e)
        {
            if (!FormSightPlanLoaded)
                return;
            DTPlan.Value = DTPlan.Value.AddYears(+1);
            cmdTwilights.PerformClick();
        }

        private void btnSub30Min_Click(object sender, EventArgs e)
        {
            if (!FormSightPlanLoaded)
                return;
            DTPlan.Value = DTPlan.Value.AddMinutes(-30);
            cmdTwilights.PerformClick();
        }

        private void btnSub1Hour_Click(object sender, EventArgs e)
        {
            if (!FormSightPlanLoaded)
                return;
            DTPlan.Value = DTPlan.Value.AddHours(-1);
            cmdTwilights.PerformClick();
        }

        private void btnSub1Day_Click(object sender, EventArgs e)
        {
            DTPlan.Value = DTPlan.Value.AddDays(-1);
            cmdTwilights.PerformClick();
        }

        private void btnSub1Week_Click(object sender, EventArgs e)
        {
            if (!FormSightPlanLoaded)
                return;
            DTPlan.Value = DTPlan.Value.AddDays(-7);
            cmdTwilights.PerformClick();
        }

        private void btnSub1Month_Click(object sender, EventArgs e)
        {
            if (!FormSightPlanLoaded)
                return;
            DTPlan.Value = DTPlan.Value.AddMonths(-1);
            cmdTwilights.PerformClick();
        }

        private void btnSub1Year_Click(object sender, EventArgs e)
        {
            if (!FormSightPlanLoaded)
                return;
            DTPlan.Value = DTPlan.Value.AddYears(-1);
            cmdTwilights.PerformClick();
        }

        private void btnAdd1Week_Click(object sender, EventArgs e)
        {
            if (!FormSightPlanLoaded)
                return;
            DTPlan.Value = DTPlan.Value.AddDays(+7);
            cmdTwilights.PerformClick();
        }

        private void btnAdd1Day_Click(object sender, EventArgs e)
        {
            if (!FormSightPlanLoaded)
                return;
            DTPlan.Value = DTPlan.Value.AddDays(+1);
            cmdTwilights.PerformClick();
        }

        private void btnAdd1Hour_Click(object sender, EventArgs e)
        {
            if (!FormSightPlanLoaded)
                return;
            DTPlan.Value = DTPlan.Value.AddHours(+1);
            cmdTwilights.PerformClick();
        }

        private void btnAdd30Min_Click(object sender, EventArgs e)
        {
            if (!FormSightPlanLoaded)
                return;
            DTPlan.Value = DTPlan.Value.AddMinutes(+30);
            cmdTwilights.PerformClick();
        }

        private void btnResetDTtoNow_Click(object sender, EventArgs e)
        {
            DTPlan.Value = DateTime.Now;
            cmdTwilights.PerformClick();
        }
    }
}