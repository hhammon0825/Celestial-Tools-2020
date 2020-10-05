using System;
using System.Device.Location;
using System.Drawing;
using System.Windows.Forms;
//using Microsoft.VisualBasic;

namespace CelestialTools
{
    public partial class CLSForm
    {
        public CLSForm()
        {
            EPLineLoc = new Point(EPLineLocX, EPLineLocY);
            InitializeComponent();
            _PicBoxCLS.Name = "PicBoxCLS";
            _ExitBtn.Name = "ExitBtn";
            _cmdPrint.Name = "cmdPrint";
            _btnPrtSights.Name = "btnPrtSights";
        }

        private double OneNmPixels = 12d;
        private double OneNMLongPixels;
        private double ToRad = Math.PI / 180d;
        private double ToDeg = 180d / Math.PI;
        private int MidX;
        private int MidY;
        private int BottomY;
        private Point BottomCenter;
        private Point CenterofPlot;
        private int LeftX;
        private int RightX;
        private int TopY;
        private int TopX;
        private Pen myPen = new Pen(Color.Black, 2f);
        // Private myFont As New Font("Arial", 10, FontStyle.Regular)
        private Font ArialFont = new Font("Arial", 8f, FontStyle.Bold);
        // Private TimesNewFont As Font = New Font("Times New Roman", 8, FontStyle.Bold)
        private bool IssuingSendMsgBx = false;
        private double CentralLat = 0d;
        private int CentralLatDeg;
        private int CentralLatMin;
        private string CentralLatNS;
        private double CentralLong = 0d;
        private int CentralLongDeg;
        private int CentralLongMin;
        private string CentralLongEW;

        public struct PlotEntry
        {
            // These 1st 4 fields are common to all plot types and must contain data - they cannot be nothing
            public string PsnName;
            public string SquadronName;
            public string PlotNumber;
            public string PlotType; // Sight or Fix or DR or APSight for sight from Alt SR methods - where Lat/Long are AP and real loc is in DRStartLat/Long fields below
                                    // The next Fields are for Sight, SightFix, and Fix plots
                                    // String field cannot be nothing - must at least contain a null string or " "
            public string PlotBody;
            public string PlotLatNS;
            public string PlotLatDeg;
            public string PlotLatMin;
            public string PlotLatSec;
            public string PlotLongEW;
            public string PlotLongDeg;
            public string PlotLongMin;
            public string PlotLongSec;
            public string PlotAz;
            public string PlotIntercept;
            public string PlotSLEP;
            public DateTime PlotDT;
            public double PlotLat;
            public double PlotLong;
            public string PlotLLoBy; // DR, GPS, KP (Known Position), or AP (Assumed Position from Alt SR)
                                     // The next fields are for DR Plots
            public int PlotDRCourse; // True course NNN
            public double PlotDRSpeed;  // Speed as NN.N knots
            public int PlotDRTimeMin; // Elapsed time in minutes as NNNN
            public DateTime PlotDRDT;
            public DateTime PlotDREndDT;
            public GeoCoordinate PlotDRGeoCoord;
            public double PlotDRStartLat;
            public string PlotDRStartNS;
            public double PlotDRStartLong;
            public string PlotDRStartLongEW;
            public double PlotDREndLat;
            public string PlotDREndNS;
            public double PlotDREndLong;
            public string PlotDREndLongEW;
            public bool PlotExtendedLines;
        }

        public PlotEntry[] PlotArray = new PlotEntry[1];
        private Graphics Grph;
        private Bitmap bm;
        private string BMFname = "./Graphics/CLSPlotForm.jpg";
        private int DrawWidth;
        private Pen DPen = new Pen(Color.Black, 1f);
        private Point ptA;
        private Point ptB;
        private int myIdx = 0;
        private bool FormCLSLoading = false;

        public struct DegMinCalc
        {
            public int CalcDeg;
            public int CalcMin;
        }

        private DegMinCalc DMCalc;
        private double PlotIntCalc;
        private string PlotIntCalcTA;
        private double PlotAzCalc;
        private double PlotLat;
        private string PlotLatNS;
        private double PlotLong;
        private string PlotLongEW;
        private string PlotDRTime = "";
        private double PlotEPLat;
        private string PlotEPLatNS;
        private double PlotEPLong;
        private double PlotEPLongEW;
        private Size OrigFormSize;
        private Size OrigPicBoxSize;
        private int PlotTimeCount = 0;
        private int PlotDRTimeCount = 0;
        private int PlotAPTimeCount = 0;
        private bool isRunningSunSight = false;
        private double LatDelta = 0d;
        private double LongDelta = 0d;
        private int RunSunSightNum = 0;

        public struct SaveSuns
        {
            public int SunIndex;
            public DateTime SunDt;
        }

        public SaveSuns[] SunArray = new SaveSuns[1];
        public int EPLineCount = 0;
        public int EPLineLocX = 255;
        public int EPLineLocY = 650;
        public Point EPLineLoc;

        public void RunningSunSight()
        {
            SunArray = new SaveSuns[1];
            int idx = 0;
            int LastSun = -1;
            int EarlySun = -1;
            if (PlotArray.GetUpperBound(0) >= 1) // is there at least two entries in plot array
            {
                for (int i = 0, loopTo = PlotArray.GetUpperBound(0) - 1; i <= loopTo; i++)
                {
                    if (PlotArray[i].PlotBody.Contains("Sun") & PlotArray[i].PlotType == "FixSight")
                    {
                        SunArray[idx].SunIndex = i;
                        SunArray[idx].SunDt = PlotArray[i].PlotDT;
                        idx += 1;
                        Array.Resize(ref SunArray, idx + 1);
                    }
                }
            }
            else
            {
                return;
            }

            if (idx == 2)
            {
                if (SunArray[0].SunDt == SunArray[1].SunDt & PlotArray[SunArray[0].SunIndex].PlotLat == PlotArray[SunArray[1].SunIndex].PlotLat & PlotArray[SunArray[0].SunIndex].PlotLong == PlotArray[SunArray[1].SunIndex].PlotLong)
                {
                    return; // these will plot just fine as is
                }

                if (SunArray[0].SunDt > SunArray[1].SunDt)
                {
                    LastSun = SunArray[0].SunIndex;
                    EarlySun = SunArray[1].SunIndex;
                }
                else
                {
                    LastSun = SunArray[1].SunIndex;
                    EarlySun = SunArray[0].SunIndex;
                }

                var newplot = PlotArray[EarlySun];
                newplot.PlotBody = newplot.PlotBody + " Original";
                PlotArray[EarlySun].PlotLat = PlotArray[LastSun].PlotLat;
                PlotArray[EarlySun].PlotLatDeg = PlotArray[LastSun].PlotLatDeg;
                PlotArray[EarlySun].PlotLatMin = PlotArray[LastSun].PlotLatMin;
                PlotArray[EarlySun].PlotLatNS = PlotArray[LastSun].PlotLatNS;
                PlotArray[EarlySun].PlotLatSec = PlotArray[LastSun].PlotLatSec;
                PlotArray[EarlySun].PlotLong = PlotArray[LastSun].PlotLong;
                PlotArray[EarlySun].PlotLongDeg = PlotArray[LastSun].PlotLongDeg;
                PlotArray[EarlySun].PlotLongEW = PlotArray[LastSun].PlotLongEW;
                PlotArray[EarlySun].PlotLongMin = PlotArray[LastSun].PlotLongMin;
                PlotArray[EarlySun].PlotLongSec = PlotArray[LastSun].PlotLongSec;
                PlotArray[EarlySun].PlotBody = PlotArray[EarlySun].PlotBody + " Advanced";
                isRunningSunSight = true;
                RunSunSightNum = EarlySun;
                AddPlotEntry(newplot);
            }
            else
            {
                return;
            }

            return;
        }

        public void AddPlotEntry(PlotEntry PlotIn)
        {
            int Idx = PlotArray.GetUpperBound(0);
            myIdx = Idx;
            PlotArray[Idx] = PlotIn;
            Idx += 1;
            Array.Resize(ref PlotArray, Idx + 1);
            return;
        }

        public bool PlotSight()
        {
            FormCLSLoading = true;
            RunningSunSight();
            FirstTimeInitGraphics();
            if (SetCentralLatLong() == false)
            {
                return false;
            }
            // SetPlotInfoFields()
            DrawBasicPlotForm();
            DrawPlots();
            SaveDisplayBMFname();
            FormCLSLoading = false;
            return true;
        }

        private void CLSForm_Load(object sender, EventArgs e)
        {
            FormCLSLoading = true;
            var PlotArray = new object[1];
            OrigFormSize = Size;
            OrigPicBoxSize = PicBoxCLS.Size;
            PicBoxCLS.SizeMode = PictureBoxSizeMode.StretchImage;
            isRunningSunSight = false;
            FormCLSLoading = false;
        }

        private void FirstTimeInitGraphics()
        {
            bm = new Bitmap(PicBoxCLS.Width, PicBoxCLS.Height);
            bm = (Bitmap)Image.FromFile("./CLSForms/cls98plottemplateV1.jpg");
            Grph = PicBoxCLS.CreateGraphics();
            Grph = Graphics.FromImage(bm);
            Grph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Grph.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            Grph.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            Grph.TranslateTransform(0f, 0f);
            var DPen = new Pen(Color.Black, 2f);
            DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            var ptA = new Point();
            var ptB = new Point();
            return;
        }

        private void cmdPrint_Click(object sender, EventArgs e)
        {
            var newpt = new Point(Location.X + 20, Location.Y);
            var newsize = new Size(Size.Width + 120, Size.Height + 40);
            var newrect = new Rectangle(newpt, newsize);
            Print_Renamed.PrintScreen(newrect);
            return;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            DPen.Dispose();
            bm.Dispose();
            myPen.Dispose();
            // myFont.Dispose()
            Grph.Dispose();
            Close();
            return;
        }

        private bool SetCentralLatLong()
        {
            double LowLat = 0d;
            double HighLat = 0d;
            double LowLong = 0d;
            double HighLong = 0d;
            double LatDiff = 0d;
            double LongDiff = 0d;
            double LatDiffMin = 0d;
            double LongDiffMin = 0d;
            int NSFactor = 1;
            int EWFactor = 1;
            bool firsttime = true;
            if (PlotArray.GetUpperBound(0) > 1)
            {
                for (int i = 0, loopTo = PlotArray.GetUpperBound(0); i <= loopTo; i++)
                {
                    if (PlotArray[i].PlotType != null)
                    {
                        PlotArray[i].PlotLat = Math.Abs(PlotArray[i].PlotLat);  // do this to make sure S lats are mathematically correct 
                        PlotArray[i].PlotLong = Math.Abs(PlotArray[i].PlotLong); // do this to make sure S lats are mathematically correct
                        if (i > 1)
                        {
                            if (PlotArray[i].PlotType != null & PlotArray[i - 1].PlotType != null)
                            {
                                if ((PlotArray[i].PlotLatNS ?? "") != (PlotArray[i - 1].PlotLatNS ?? ""))
                                {
                                    SendMsgBx("Error: Plots must be in the same Latitude N or S - Exit and Try Again", MessageBoxIcon.Error);
                                    return false;
                                }

                                if ((PlotArray[i].PlotLongEW ?? "") != (PlotArray[i - 1].PlotLongEW ?? ""))
                                {
                                    SendMsgBx("Error: Plots must be in the same Longitude E or W - Exit and Try Again", MessageBoxIcon.Error);
                                    return false;
                                }
                            }
                        }

                        if (i == 0 | firsttime == true)
                        {
                            LowLat = Math.Abs(PlotArray[i].PlotLat);
                            HighLat = Math.Abs(PlotArray[i].PlotLat);
                            LowLong = Math.Abs(PlotArray[i].PlotLong);
                            HighLong = Math.Abs(PlotArray[i].PlotLong);
                            firsttime = false;
                        }

                        if (i > 0)
                        {
                            if (PlotArray[i].PlotLat < LowLat)
                            {
                                LowLat = Math.Abs(PlotArray[i].PlotLat);
                            }

                            if (PlotArray[i].PlotLat > HighLat)
                            {
                                HighLat = Math.Abs(PlotArray[i].PlotLat);
                            }

                            if (PlotArray[i].PlotLong < LowLong)
                            {
                                LowLong = Math.Abs(PlotArray[i].PlotLong);
                            }

                            if (PlotArray[i].PlotLong > HighLong)
                            {
                                HighLong = Math.Abs(PlotArray[i].PlotLong);
                            }
                        }
                    }
                }

                if (LowLat != HighLat)
                {
                    if (HighLat >= LowLat)
                    {
                        LatDiff = HighLat - LowLat;
                    }
                    else
                    {
                        LatDiff = LowLat - HighLat;
                    }

                    LatDiffMin = (LatDiff - System.Math.Truncate(LatDiff)) * 60d;
                    if (LatDiffMin > 59.9d | System.Math.Truncate(LatDiff) > 1d)
                    {
                        SendMsgBx("Error: Distances between all latitudes must be less than 60 miles to plot", MessageBoxIcon.Error);
                        return false;
                    }
                }

                if (LowLong != HighLong)
                {
                    if (HighLong >= LowLong)
                    {
                        LongDiff = HighLong - LowLong;
                    }
                    else
                    {
                        LongDiff = LowLong - HighLong;
                    }

                    LongDiff = HighLong - LowLong;
                    LongDiffMin = (LongDiff - System.Math.Truncate(LongDiff)) * 60d;
                    if (LongDiffMin > 59.9d | System.Math.Truncate(LongDiff) > 1d)
                    {
                        SendMsgBx("Error: Distances between all longitudes must be less than 60 miles to plot", MessageBoxIcon.Error);
                        return false;
                    }
                }
            }

            if (PlotArray.GetUpperBound(0) == 1)
            {
                CentralLatDeg = Convert.ToInt32(PlotArray[myIdx].PlotLatDeg);
                CentralLatMin = Convert.ToInt32(System.Math.Truncate(Convert.ToDouble(PlotArray[myIdx].PlotLatMin)) / 10d) * 10;
                if (CentralLatMin == 60)
                {
                    CentralLatMin = 0;
                    CentralLatDeg += 1;
                }

                CentralLat = CentralLatDeg + CentralLatMin / 60d;
                CentralLongDeg = Convert.ToInt32(PlotArray[myIdx].PlotLongDeg);
                CentralLongMin = Convert.ToInt32(System.Math.Truncate(Convert.ToDouble(PlotArray[myIdx].PlotLongMin)) / 10d) * 10;
                if (CentralLongMin == 60)
                {
                    CentralLongMin = 0;
                    CentralLongDeg += 1;
                }

                CentralLong = CentralLongDeg + CentralLongMin / 60d;
            }
            else
            {
                double AvgLat = 0d;
                double AvgLong = 0d;
                int PlotCt = 0;
                for (int i = 0, loopTo1 = PlotArray.GetUpperBound(0); i <= loopTo1; i++)
                {
                    if (PlotArray[i].PlotType != null)
                    {
                        AvgLat += PlotArray[i].PlotLat;
                        AvgLong += PlotArray[i].PlotLong;
                        PlotCt += 1;
                    }
                }

                AvgLat = AvgLat / PlotCt;
                AvgLong = AvgLong / PlotCt;
                CentralLatDeg = (int)System.Math.Truncate(AvgLat);
                CentralLatMin = Convert.ToInt32((AvgLat - CentralLatDeg) * 60d / 10d) * 10;
                if (CentralLatMin == 60)
                {
                    CentralLatMin = 0;
                    CentralLatDeg += 1;
                }

                CentralLat = CentralLatDeg + CentralLatMin / 60d;
                CentralLongDeg = (int)System.Math.Truncate(AvgLong);
                CentralLongMin = Convert.ToInt32((AvgLong - CentralLongDeg) * 60d / 10d) * 10;
                if (CentralLongMin == 60)
                {
                    CentralLongMin = 0;
                    CentralLongDeg += 1;
                }

                CentralLong = CentralLongDeg + CentralLongMin / 60d;
            }

            CentralLatNS = PlotArray[myIdx].PlotLatNS.Trim();
            CentralLongEW = PlotArray[myIdx].PlotLongEW.Trim();
            txtLatActive.Text = CentralLatDeg.ToString("##0") + '°' + " " + CentralLatMin.ToString("00.0") + "' " + CentralLatNS;
            txtLongActive.Text = CentralLongDeg.ToString("##0") + '°' + " " + CentralLongMin.ToString("00.0") + "' " + CentralLongEW;
            return true;
        }

        private void DrawBasicPlotForm()
        {
            MidX = 411 - 20;
            MidY = 509 - 145;
            BottomY = 1070 - 145;
            BottomCenter = new Point(MidX, BottomY);
            CenterofPlot = new Point(MidX, MidY);
            LeftX = 74 - 20;
            RightX = 749 - 20;
            TopY = 172 - 145;
            OneNmPixels = (RightX - MidX) / 30d;
            OneNMLongPixels = OneNmPixels * Math.Cos(CentralLat * ToRad); // (BottomY - MidY) / 50 
            double LineY = BottomY - OneNmPixels * Math.Tan(CentralLat * ToRad) * 30d;
            double LineX = OneNMLongPixels * 30d; // (OneNmPixels * 30) * System.Math.Cos(CentralLat * oRad)

            // draw longitude lines for mid latitude for this plot
            Grph.DrawLine(DPen, BottomCenter, new Point(RightX, Convert.ToInt32(LineY)));
            Grph.DrawLine(DPen, BottomCenter, new Point(LeftX, Convert.ToInt32(LineY)));
            DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            double SingleX = OneNmPixels * Math.Cos(CentralLat * ToRad);
            for (int i = 1; i <= 3; i++)
            {
                LineX = OneNmPixels * i * 10d * Math.Cos(CentralLat * ToRad);
                DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                Grph.DrawLine(DPen, new Point((int)(MidX + LineX), BottomY), new Point((int)(MidX + LineX), TopY));
                Grph.DrawLine(DPen, new Point((int)(MidX - LineX), BottomY), new Point((int)(MidX - LineX), TopY));
                for (int j = 0; j <= 9; j++)
                {
                    DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    if (j == 5)
                    {
                        Grph.DrawLine(DPen, new Point((int)(MidX + LineX - SingleX * j), TopY), new Point((int)(MidX + LineX - SingleX * j), TopY + 15));
                        Grph.DrawLine(DPen, new Point((int)(MidX - LineX + SingleX * j), TopY), new Point((int)(MidX - LineX + SingleX * j), TopY + 15));
                    }
                    else
                    {
                        Grph.DrawLine(DPen, new Point((int)(MidX + LineX - SingleX * j), TopY), new Point((int)(MidX + LineX - SingleX * j), TopY + 10));
                        Grph.DrawLine(DPen, new Point((int)(MidX - LineX + SingleX * j), TopY), new Point((int)(MidX - LineX + SingleX * j), TopY + 10));
                    }
                }
            }

            DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            string TempStr = CentralLatDeg.ToString("##0") + '°' + " " + CentralLatMin.ToString("##0.0") + "' " + CentralLatNS.ToString();
            Grph.DrawString(TempStr, ArialFont, Brushes.Black, RightX + 2, MidY - 5);
            DMCalc.CalcDeg = CentralLatDeg;
            DMCalc.CalcMin = CentralLatMin;
            DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            if ((CentralLatNS ?? "") == (CommonGlobals.g_LatN ?? ""))
            {
                for (int i = 1; i <= 3; i++)
                {
                    int Incr1 = 10 * i;
                    CalcDegMin(DMCalc.CalcDeg, DMCalc.CalcMin, +10);
                    TempStr = DMCalc.CalcDeg.ToString("##0") + '°' + " " + DMCalc.CalcMin.ToString("##0.0") + "' " + CentralLatNS.ToString();
                    Grph.DrawString(TempStr, ArialFont, Brushes.Black, RightX + 2, (float)(MidY - 5 - OneNmPixels * Incr1));
                    if (i < 3)
                    {
                        Grph.DrawLine(DPen, new Point(LeftX, (int)(MidY - OneNmPixels * Incr1)), new Point(RightX, (int)(MidY - OneNmPixels * Incr1)));
                    }
                }

                DMCalc.CalcDeg = CentralLatDeg;
                DMCalc.CalcMin = CentralLatMin;
                for (int i = 1; i <= 3; i++)
                {
                    int Incr2 = -10 * i;
                    CalcDegMin(DMCalc.CalcDeg, DMCalc.CalcMin, -10);
                    TempStr = DMCalc.CalcDeg.ToString("##0") + '°' + " " + DMCalc.CalcMin.ToString("##0.0") + "' " + CentralLatNS.ToString();
                    Grph.DrawString(TempStr, ArialFont, Brushes.Black, RightX + 2, (float)(MidY - 5 - OneNmPixels * Incr2));
                    if (i < 3)
                    {
                        Grph.DrawLine(DPen, new Point(LeftX, (int)(MidY - OneNmPixels * Incr2)), new Point(RightX, (int)(MidY - OneNmPixels * Incr2)));
                    }
                }
            }
            else
            {
                for (int i = 1; i <= 3; i++)
                {
                    int Incr3 = -10 * i;
                    CalcDegMin(DMCalc.CalcDeg, DMCalc.CalcMin, -10);
                    TempStr = DMCalc.CalcDeg.ToString("##0") + '°' + " " + DMCalc.CalcMin.ToString("##0.0") + "' " + CentralLatNS.ToString();
                    Grph.DrawString(TempStr, ArialFont, Brushes.Black, RightX + 2, (float)(MidY - 5 + OneNmPixels * Incr3));
                    if (i < 3)
                    {
                        Grph.DrawLine(DPen, new Point(LeftX, (int)(MidY - OneNmPixels * Incr3)), new Point(RightX, (int)(MidY - OneNmPixels * Incr3)));
                    }
                }

                DMCalc.CalcDeg = CentralLatDeg;
                DMCalc.CalcMin = CentralLatMin;
                for (int i = 1; i <= 3; i++)
                {
                    int Incr4 = +10 * i;
                    CalcDegMin(DMCalc.CalcDeg, DMCalc.CalcMin, +10);
                    TempStr = DMCalc.CalcDeg.ToString("##0") + '°' + " " + DMCalc.CalcMin.ToString("##0.0") + "' " + CentralLatNS.ToString();
                    Grph.DrawString(TempStr, ArialFont, Brushes.Black, RightX + 2, (float)(MidY - 5 + OneNmPixels * Incr4));
                    if (i < 3)
                    {
                        Grph.DrawLine(DPen, new Point(LeftX, (int)(MidY - OneNmPixels * Incr4)), new Point(RightX, (int)(MidY - OneNmPixels * Incr4)));
                    }
                }
            }

            TempStr = CentralLongDeg.ToString("##0") + '°' + " " + CentralLongMin.ToString("##0.0") + "' " + CentralLongEW.ToString();
            Grph.DrawString(TempStr, ArialFont, Brushes.Black, MidX - 20, BottomY + 5);
            Grph.DrawString(TempStr, ArialFont, Brushes.Black, MidX - 20, TopY - 15);
            DMCalc.CalcDeg = CentralLongDeg;
            DMCalc.CalcMin = CentralLongMin;
            if ((CentralLongEW ?? "") == (CommonGlobals.g_LongW ?? ""))
            {
                for (int i = 1; i <= 3; i++)
                {
                    int Incr1 = 10 * i;
                    CalcDegMin(DMCalc.CalcDeg, DMCalc.CalcMin, 10);
                    TempStr = DMCalc.CalcDeg.ToString("##0") + '°' + " " + DMCalc.CalcMin.ToString("##0.0") + "' " + CentralLongEW.ToString();
                    Grph.DrawString(TempStr, ArialFont, Brushes.Black, (float)(MidX - 20 - OneNMLongPixels * Incr1), BottomY + 5);
                    Grph.DrawString(TempStr, ArialFont, Brushes.Black, (float)(MidX - 20 - OneNMLongPixels * Incr1), TopY - 15);
                }

                DMCalc.CalcDeg = CentralLongDeg;
                DMCalc.CalcMin = CentralLongMin;
                for (int i = 1; i <= 3; i++)
                {
                    int Incr2 = -10 * i;
                    CalcDegMin(DMCalc.CalcDeg, DMCalc.CalcMin, -10);
                    TempStr = DMCalc.CalcDeg.ToString("##0") + '°' + " " + DMCalc.CalcMin.ToString("##0.0") + "' " + CentralLongEW.ToString();
                    Grph.DrawString(TempStr, ArialFont, Brushes.Black, (float)(MidX - 20 - OneNMLongPixels * Incr2), BottomY + 5);
                    Grph.DrawString(TempStr, ArialFont, Brushes.Black, (float)(MidX - 20 - OneNMLongPixels * Incr2), TopY - 15);
                }
            }
            else
            {
                for (int i = 1; i <= 3; i++)
                {
                    int Incr3 = 10 * i;
                    CalcDegMin(DMCalc.CalcDeg, DMCalc.CalcMin, 10);
                    TempStr = DMCalc.CalcDeg.ToString("##0") + '°' + " " + DMCalc.CalcMin.ToString("##0.0") + "' " + CentralLongEW.ToString();
                    Grph.DrawString(TempStr, ArialFont, Brushes.Black, (float)(MidX - 20 + OneNMLongPixels * Incr3), BottomY + 5);
                    Grph.DrawString(TempStr, ArialFont, Brushes.Black, (float)(MidX - 20 + OneNMLongPixels * Incr3), TopY - 15);
                }

                DMCalc.CalcDeg = CentralLongDeg;
                DMCalc.CalcMin = CentralLongMin;
                for (int i = 1; i <= 3; i++)
                {
                    int Incr4 = -10 * i;
                    CalcDegMin(DMCalc.CalcDeg, DMCalc.CalcMin, -10);
                    TempStr = DMCalc.CalcDeg.ToString("##0") + '°' + " " + DMCalc.CalcMin.ToString("##0.0") + "' " + CentralLongEW.ToString();
                    Grph.DrawString(TempStr, ArialFont, Brushes.Black, (float)(MidX - 20 + OneNMLongPixels * Incr4), BottomY + 5);
                    Grph.DrawString(TempStr, ArialFont, Brushes.Black, (float)(MidX - 20 + OneNMLongPixels * Incr4), TopY - 15);
                }
            }
            // SaveDisplayBMFname()
            return;
        }

        private void CalcDegMin(int InDeg, int InMin, int InIncr)
        {
            int tempmin = InMin + InIncr;
            if (InMin == 0 & InIncr < 0)
            {
                DMCalc.CalcDeg = InDeg - 1;
                DMCalc.CalcMin = 50;
                return;
            }

            if (InIncr > 0)
            {
                if (tempmin == 60)
                {
                    DMCalc.CalcDeg = InDeg + 1;
                    DMCalc.CalcMin = 0;
                }
                else
                {
                    DMCalc.CalcMin = tempmin;
                }
            }
            else if (tempmin == 0)
            {
                DMCalc.CalcDeg = InDeg;
                DMCalc.CalcMin = 0;
            }
            else
            {
                DMCalc.CalcMin = tempmin;
            }

            return;
        }
        // Private Sub SetPlotInfoFields()
        // txtSummary.Clear()
        // Dim Idx As Integer = 0
        // For Idx = 0 To UBound(PlotArray)
        // If PlotArray(Idx).PlotType <> Nothing Then
        // txtSummary.AppendText(PlotArray(Idx).PlotType.ToString & " # " & PlotArray(Idx).PlotNumber.ToString &
        // " ;Body = " & PlotArray(Idx).PlotBody.ToString & " ;Date/Time = " & PlotArray(Idx).PlotDT.ToString("MM/dd/yyy HH:mm:ss") &
        // " ;L = " & PlotArray(Idx).PlotLatDeg.ToString & Chr(176) & PlotArray(Idx).PlotLatMin.ToString & "' " & PlotArray(Idx).PlotLatNS.ToString &
        // " Lo = " & PlotArray(Idx).PlotLongDeg.ToString & Chr(176) & PlotArray(Idx).PlotLongMin.ToString & "' " & PlotArray(Idx).PlotLongEW.ToString &
        // " ;Int and Az = " & PlotArray(Idx).PlotIntercept.ToString & " at " & PlotArray(Idx).PlotAz.ToString & vbNewLine &
        // vbTab & PlotArray(Idx).PlotLLoBy & " Position = " & PlotArray(Idx).PlotSLEP.ToString & vbNewLine)
        // End If
        // Next
        // Exit Sub
        // End Sub
        private void DrawPlots()
        {
            PlotTimeCount = 0;
            PlotDRTimeCount = 0;
            PlotAPTimeCount = 0;
            EPLineCount = 0;
            EPLineLocY = 650;
            for (int i = 0, loopTo = PlotArray.GetUpperBound(0); i <= loopTo; i++)
            {
                if (PlotArray[i].PlotType != null)
                {
                    switch (PlotArray[i].PlotType ?? "")
                    {
                        case "Sight":
                            {
                                PlotSightType(i);
                                break;
                            }

                        case "FixSight":
                            {
                                PlotSightType(i);
                                break;
                            }

                        case "Fix":
                            {
                                PlotFixType(i);
                                break;
                            }

                        case "DR":
                            {
                                PlotDRType(i);
                                break;
                            }
                    }
                }
            }

            PlotTimeCount = 0;
            PlotDRTimeCount = 0;
            PlotAPTimeCount = 0;
            return;
        }

        private void PlotSightType(int idx)
        {
            string Inttemp;
            string Aztemp;
            double AzCalcPlus90 = 0d;
            double AZCalcPlot = 0d;
            bool Leftside = true;
            int FactorNS = 1;
            int FactorEW = +1;
            Inttemp = PlotArray[idx].PlotIntercept;
            Aztemp = PlotArray[idx].PlotAz;
            if (Inttemp.Contains("Tow"))
            {
                PlotIntCalcTA = "T";
            }
            else
            {
                PlotIntCalcTA = "A";
            }

            Inttemp = Inttemp.Substring(0, Inttemp.IndexOf("nm")).Trim();
            Aztemp = Aztemp.Substring(0, Aztemp.IndexOf('°')).Trim();
            PlotIntCalc = Math.Round(Convert.ToDouble(Inttemp), 1, MidpointRounding.AwayFromZero);
            PlotAzCalc = Math.Round(Convert.ToDouble(Aztemp), 0, MidpointRounding.AwayFromZero);
            // PlotIntCalc = Convert.ToDouble(Inttemp)
            // PlotAzCalc = Convert.ToDouble(Aztemp)

            PlotLat = PlotArray[idx].PlotLat;
            PlotLatNS = PlotArray[idx].PlotLatNS;
            PlotLong = PlotArray[idx].PlotLong;
            PlotLongEW = PlotArray[idx].PlotLongEW;
            if (PlotArray[idx].PlotType == "Sight" | PlotArray[idx].PlotType == "FixSight")
            {
                UnStringEP(PlotArray[idx].PlotSLEP, idx);
            }
            else
            {
                PlotEPLat = 0d;
                PlotEPLong = 0d;
            }

            AZCalcPlot = PlotAzCalc;
            if ((PlotLatNS ?? "") == (CommonGlobals.g_LatN ?? ""))
            {
                FactorNS = +1;
            }
            else
            {
                FactorNS = -1;
            }

            if ((PlotLongEW ?? "") == (CommonGlobals.g_LongE ?? ""))
            {
                FactorEW = -1;
            }
            else
            {
                FactorEW = +1;
            }
            // Left side boolean tells me which side of the DR Plot to print the text
            if (AZCalcPlot >= 0d & AZCalcPlot <= 180d)
            {
                if (PlotIntCalcTA == "T")
                {
                    Leftside = true;
                }
                else
                {
                    Leftside = false;
                }
            }

            if (AZCalcPlot > 180d & AZCalcPlot <= 360d)
            {
                if (PlotIntCalcTA == "T")
                {
                    Leftside = false;
                }
                else
                {
                    Leftside = true;
                }
            }
            // this is the direction of the perpendicular line for the LOP at the EP
            AzCalcPlus90 = PlotAzCalc - 90d;
            if (AzCalcPlus90 > 360d)
            {
                AzCalcPlus90 -= 360d;
            }

            var DRPoint = new Point(0, 0);
            int XlateX = (int)(FactorEW * ((CentralLong - PlotLong) * 60d) * OneNMLongPixels);
            int XlateY = (int)(FactorNS * ((CentralLat - PlotLat) * 60d) * OneNmPixels);
            DRPoint.X = MidX + XlateX;
            DRPoint.Y = MidY + XlateY;
            Grph.DrawArc(myPen, DRPoint.X - 2, DRPoint.Y - 2, 4, 4, 0, 360);
            if (PlotArray[idx].PlotLLoBy == "GPS")
            {
                Grph.DrawArc(myPen, DRPoint.X - 6, DRPoint.Y - 6, 12, 12, 0, 360);
            }
            else
            {
                Grph.DrawArc(myPen, DRPoint.X - 6, DRPoint.Y - 6, 12, 12, 180, 180);
            }

            Grph.DrawLine(myPen, DRPoint.X - 6, DRPoint.Y, DRPoint.X + 6, DRPoint.Y);
            int lblHr = PlotArray[idx].PlotDT.Hour;
            int lblMin = PlotArray[idx].PlotDT.Minute;
            int lblSec = PlotArray[idx].PlotDT.Second;
            if (lblSec >= 30)
            {
                lblMin += 1;
            }

            if (lblMin > 59)
            {
                lblMin = 0;
                lblHr += 1;
            }

            PlotDRTime = lblHr.ToString("00") + lblMin.ToString("00");
            if (PlotArray[idx].PlotLLoBy == "AP")
            {
                PlotTimeCount = 0;
                Grph.TranslateTransform(DRPoint.X, DRPoint.Y);
                Grph.RotateTransform(Convert.ToSingle(Math.Round((decimal)-45, 0, MidpointRounding.AwayFromZero)));
                Grph.DrawString(PlotDRTime + " " + PlotArray[idx].PlotLLoBy, ArialFont, Brushes.Blue, 6f, -12);
                Grph.ResetTransform();
            }
            else
            {
                PlotTimeCount = PlotDRTimeCount;
                if (Leftside == true)
                {
                    if (PlotTimeCount == 0)
                    {
                        Grph.DrawString(PlotDRTime + " " + PlotArray[idx].PlotLLoBy, ArialFont, Brushes.Blue, DRPoint.X - 6 - 8 * 8, DRPoint.Y - 12); // HHmm is 4 characters and 1 char = 8 pixels roughly
                    }
                    else
                    {
                        Grph.DrawString(PlotDRTime + " " + PlotArray[idx].PlotLLoBy, ArialFont, Brushes.Blue, DRPoint.X - 6, DRPoint.Y - 12 * (PlotTimeCount + 1));
                    }
                }
                else if (PlotTimeCount == 0)
                {
                    Grph.DrawString(PlotDRTime + " " + PlotArray[idx].PlotLLoBy, ArialFont, Brushes.Blue, DRPoint.X + 6, DRPoint.Y - 12);
                }
                else
                {
                    Grph.DrawString(PlotDRTime + " " + PlotArray[idx].PlotLLoBy, ArialFont, Brushes.Blue, DRPoint.X + 6, DRPoint.Y - 12 * (PlotTimeCount + 1));
                }
            }

            if (PlotArray[idx].PlotLLoBy == "AP")
            {
                PlotAPTimeCount += 1;
            }
            else
            {
                PlotDRTimeCount += 1;
            }

            var DRPointEP = new Point(0, 0);
            int EPXlateX = 0;
            int EPXlateY = 0;
            if (PlotArray[idx].PlotType == "Sight" | PlotArray[idx].PlotType == "FixSight")
            {
                EPXlateX = FactorEW * Convert.ToInt32((CentralLong - PlotEPLong) * 60d * OneNMLongPixels);
                EPXlateY = FactorNS * Convert.ToInt32((CentralLat - PlotEPLat) * 60d * OneNmPixels);
                DRPointEP.X = MidX + EPXlateX;
                DRPointEP.Y = MidY + EPXlateY;
            }

            myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            Grph.DrawLine(myPen, DRPoint, DRPointEP);
            myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            Grph.DrawArc(myPen, DRPointEP.X - 2, DRPointEP.Y - 2, 4, 4, 0, 360);
            myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            double RotateAngle = PlotAzCalc; // AZangle
            double AZLOPAngle = RotateAngle + 90d;
            if (AZLOPAngle > 360d)
            {
                AZLOPAngle -= 360d;
            }

            if (RotateAngle > 90d & RotateAngle < 270d)
            {
                RotateAngle += 180d;
            }

            Grph.TranslateTransform(DRPointEP.X, DRPointEP.Y);
            Grph.RotateTransform(Convert.ToSingle(Math.Round(RotateAngle, 0, MidpointRounding.AwayFromZero)));

            // draw LOP line
            if (PlotArray[idx].PlotExtendedLines == true)
            {
                Grph.DrawLine(myPen, new Point((int)-(40d * OneNMLongPixels), 0), new Point((int)(40d * OneNMLongPixels), 0));
            }
            else
            {
                Grph.DrawLine(myPen, new Point((int)-(20d * OneNMLongPixels), 0), new Point((int)(20d * OneNMLongPixels), 0));
            }

            // for a Fix sight draw square where previous line intersects LOP line - do not draw for Sight type
            // If PlotArray(idx).PlotType = "FixSight" Then
            // Grph.DrawRectangle(myPen, -6, -6, 12, 12)
            // End If

            int Xloc = (int)(20d * OneNMLongPixels);
            var pt = new Point(-Xloc + 30, -14);
            if (PlotArray[idx].PlotLLoBy != "AP")
            {
                Grph.DrawString(PlotDRTime, ArialFont, Brushes.Blue, pt.X, pt.Y);
                pt = new Point(-Xloc + 30, 1);
                Grph.DrawString(PlotArray[idx].PlotBody, ArialFont, Brushes.Blue, pt.X, pt.Y);
            }

            Grph.ResetTransform();
            if (EPLineCount > 0)
            {
                EPLineLocY += 12;
                EPLineLoc = new Point(EPLineLocX, EPLineLocY);
            }

            if (PlotArray[idx].PlotType == "Sight")
            {
                if (PlotArray[idx].PlotLLoBy == "GPS")
                {
                    Grph.DrawString("S/Err: " + PlotIntCalc.ToString("#0.0"), ArialFont, Brushes.Black, EPLineLocX + 100, EPLineLocY);
                }
                else
                {
                    Grph.DrawString(PlotArray[idx].PlotBody + " " + PlotArray[idx].PlotLLoBy + " Position:" + PlotArray[idx].PlotSLEP.ToString().Replace("EP", ""), ArialFont, Brushes.Black, EPLineLocX, EPLineLocY);
                }

                EPLineCount += 1;
            }

            if (PlotArray[idx].PlotType == "FixSight")
            {
                Grph.DrawString(PlotArray[idx].PlotSLEP.ToString(), ArialFont, Brushes.Black, EPLineLocX, EPLineLocY);
                EPLineCount += 1;
            }

            return;
        }

        private void PlotFixType(int idx)
        {
            int index = idx;
            string Inttemp;
            string Aztemp;
            double AzCalcPlus90 = 0d;
            double AZCalcPlot = 0d;
            bool Leftside = true;
            int FactorNS = 1;
            int FactorEW = +1;
            Inttemp = PlotArray[idx].PlotIntercept;
            Aztemp = PlotArray[idx].PlotAz;
            if (Inttemp.Contains("Tow"))
            {
                PlotIntCalcTA = "T";
            }
            else
            {
                PlotIntCalcTA = "A";
            }

            Inttemp = Inttemp.Substring(0, Inttemp.IndexOf(g_nm)).Trim();
            Aztemp = Aztemp.Substring(0, Aztemp.IndexOf('°')).Trim();
            PlotIntCalc = Convert.ToDouble(Inttemp);
            PlotAzCalc = Convert.ToDouble(Aztemp);
            if (PlotIntCalcTA == "A")
            {
                PlotAzCalc = -PlotAzCalc;
            }

            PlotLat = PlotArray[idx].PlotLat;
            PlotLatNS = PlotArray[idx].PlotLatNS;
            PlotLong = PlotArray[idx].PlotLong;
            PlotLongEW = PlotArray[idx].PlotLongEW;
            AZCalcPlot = PlotAzCalc;
            if ((PlotLatNS ?? "") == (CommonGlobals.g_LatN ?? ""))
            {
                FactorNS = +1;
            }
            else
            {
                FactorNS = -1;
            }

            if ((PlotLongEW ?? "") == (CommonGlobals.g_LongE ?? ""))
            {
                FactorEW = -1;
            }
            else
            {
                FactorEW = +1;
            }
            // Left side boolean tells me which side of the DR Plot to print the text
            if (Math.Abs(AZCalcPlot) >= 0d & Math.Abs(AZCalcPlot) <= 180d)
            {
                if (PlotIntCalcTA == "T")
                {
                    Leftside = true;
                }
                else
                {
                    Leftside = false;
                }
            }

            if (Math.Abs(AZCalcPlot) > 180d & Math.Abs(AZCalcPlot) <= 360d)
            {
                if (PlotIntCalcTA == "T")
                {
                    Leftside = false;
                }
                else
                {
                    Leftside = true;
                }
            }
            // this is the direction of the perpendicular line for the LOP at the EP
            AzCalcPlus90 = PlotAzCalc - 90d;
            if (AzCalcPlus90 > 360d)
            {
                AzCalcPlus90 -= 360d;
            }

            var DRPoint = new Point(0, 0);
            int XlateX = (int)(FactorEW * ((CentralLong - PlotLong) * 60d) * OneNMLongPixels);
            int XlateY = (int)(FactorNS * ((CentralLat - PlotLat) * 60d) * OneNmPixels);
            DRPoint.X = MidX + XlateX;
            DRPoint.Y = MidY + XlateY;
            Grph.DrawArc(myPen, DRPoint.X - 1, DRPoint.Y - 1, 2, 2, 0, 360);
            Grph.DrawArc(myPen, DRPoint.X - 2, DRPoint.Y - 2, 4, 4, 0, 360);
            Grph.DrawArc(myPen, DRPoint.X - 8, DRPoint.Y - 8, 16, 16, 0, 360);
            int lblHr = PlotArray[idx].PlotDT.Hour;
            int lblMin = PlotArray[idx].PlotDT.Minute;
            int lblSec = PlotArray[idx].PlotDT.Second;
            if (lblSec >= 30)
            {
                lblMin += 1;
            }

            if (lblMin > 59)
            {
                lblMin = 0;
                lblHr += 1;
            }

            PlotDRTime = lblHr.ToString("00") + lblMin.ToString("00") + " Fix";

            // If PlotArray(idx).PlotLLoBy = "AP" Then
            // PlotTimeCount = PlotAPTimeCount
            // Else
            // PlotTimeCount = PlotDRTimeCount
            // End If

            if (Leftside == true)
            {
                // If PlotTimeCount = 0 Then
                Grph.DrawString(PlotDRTime, ArialFont, Brushes.Blue, DRPoint.X - 6 - PlotDRTime.Length * 8, DRPoint.Y - 12); // HHmm is 4 characters and 1 char = 8 pixels roughly
            }
            // Else
            // Grph.DrawString(PlotDRTime & ",", ArialFont, Brushes.Blue, DRPoint.X - 6 - (PlotDRTime.Length * 8 * (PlotTimeCount + 1)), DRPoint.Y - 12) ' HHmm is 4 characters and 1 char = 8 pixels roughly
            // End If
            else
            {
                // If PlotTimeCount = 0 Then
                Grph.DrawString(PlotDRTime, ArialFont, Brushes.Blue, DRPoint.X + 6, DRPoint.Y - 12);
                // Else
                // Grph.DrawString("," & PlotDRTime, ArialFont, Brushes.Blue, DRPoint.X + 6 + (PlotDRTime.Length * 8 * PlotTimeCount), DRPoint.Y - 12)
                // end If
            }

            PlotTimeCount += 1;
            if (EPLineCount > 0)
            {
                EPLineLocY += 12;
                EPLineLoc = new Point(EPLineLocX, EPLineLocY);
            }

            Grph.DrawString(PlotArray[idx].PlotSLEP.ToString().Replace("EP", ""), ArialFont, Brushes.Black, EPLineLocX, EPLineLocY);
            EPLineCount += 1;
            return;
        }

        private void PlotDRType(int idx)
        {
            int index = idx;
            SendMsgBx("PlotType = DR not implemented yet - Contact Celestial Tools Support", MessageBoxIcon.Hand);
            return;
        }

        private string g_EPLat = "EP L ";
        private string g_EPLong = "EP Lo ";
        private string g_SingleQuote = "'";
        private string g_nm = "nm";

        public void UnStringEP(string EPStrIn, int idx)
        {
            int EPLLoc = EPStrIn.IndexOf(g_EPLat, StringComparison.CurrentCulture) + 5;
            int EPLDegLoc = EPStrIn.IndexOf('°');
            int EPLMinLoc = EPStrIn.IndexOf(g_SingleQuote, StringComparison.CurrentCulture);
            int EPLoLoc = EPStrIn.IndexOf(g_EPLong, StringComparison.CurrentCulture) + 6;
            int EPLoDegLoc = EPStrIn.LastIndexOf('°');
            int EPLoMinLoc = EPStrIn.LastIndexOf(g_SingleQuote, StringComparison.CurrentCulture);
            double EPLDeg = Convert.ToDouble(EPStrIn.Substring(EPLLoc, EPLDegLoc - EPLLoc));
            double EPLMin = Convert.ToDouble(EPStrIn.Substring(EPLDegLoc + 1, EPLMinLoc - (EPLDegLoc + 1)));
            PlotEPLat = EPLDeg + EPLMin / 60d;
            double EPLoDeg = Convert.ToDouble(EPStrIn.Substring(EPLoLoc, EPLoDegLoc - EPLoLoc));
            double EPLoMin = Convert.ToDouble(EPStrIn.Substring(EPLoDegLoc + 1, EPLoMinLoc - (EPLoDegLoc + 1)));
            PlotEPLong = EPLoDeg + EPLoMin / 60d;
            if (isRunningSunSight == true & idx == RunSunSightNum)
            {
                string Inttemp = PlotArray[idx].PlotIntercept;
                string Aztemp = PlotArray[idx].PlotAz;
                if (Inttemp.Contains("Tow"))
                {
                    PlotIntCalcTA = "T";
                }
                else
                {
                    PlotIntCalcTA = "A";
                }

                Inttemp = Inttemp.Substring(0, Inttemp.IndexOf(g_nm, StringComparison.CurrentCulture)).Trim();
                Aztemp = Aztemp.Substring(0, Aztemp.IndexOf('°')).Trim();
                double PlotIntCalc1 = Math.Round(Convert.ToDouble(Inttemp), 1, MidpointRounding.AwayFromZero);
                double PlotAzCalc1 = Math.Round(Convert.ToDouble(Aztemp), 0, MidpointRounding.AwayFromZero);
                if (PlotArray[idx].PlotType == "FixSight" & PlotIntCalcTA == "A")
                {
                    PlotAzCalc1 = 180d + PlotAzCalc1;
                    if (PlotAzCalc1 > 360d)
                    {
                        PlotAzCalc1 = PlotAzCalc1 - 360d;
                    }
                }

                double TmpLat = PlotArray[idx].PlotLat;
                if ((PlotArray[idx].PlotLatNS ?? "") == (CommonGlobals.g_LatS ?? ""))
                {
                    TmpLat = -1 * TmpLat;
                }

                double TmpLong = PlotArray[idx].PlotLong;
                if ((PlotArray[idx].PlotLongEW ?? "") == (CommonGlobals.g_LongW ?? ""))
                {
                    TmpLong = -1 * TmpLong;
                }

                var GeoTmp = FindDestLatLong(TmpLat, TmpLong, PlotIntCalc1, PlotAzCalc1);
                PlotEPLat = Math.Abs(GeoTmp.Latitude);
                PlotEPLong = Math.Abs(GeoTmp.Longitude);
            }

            return;
        }

        public void SaveDisplayBMFname()
        {
            if (System.IO.File.Exists(BMFname))
            {
                System.IO.File.Delete(BMFname);
            }

            bm.Save(BMFname);
            PicBoxCLS.ImageLocation = BMFname;
            PicBoxCLS.Refresh();
            bm.Dispose();
            return;
        }

        private void PicBoxCLS_Paint(object sender, PaintEventArgs e)
        {
            // Exit Sub
        }

        public void SendMsgBx(string SendStr, MessageBoxIcon IconType)
        {
            // this subroutine is required because issuing a raw SendMsgBx call also trigger a Paint event for graphic box on form which cannot be handled properly in error conditions
            IssuingSendMsgBx = true;
            string HdrStr = "";
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

        private void Button1_Click(object sender, EventArgs e)
        {
            Print_Renamed.PrintScreen(PicBoxCLS.Bounds);
            return;
        }
        private string CaptionStr = "CLS Plot Sight Data";
        private void btnPrtSights_Click(object sender, EventArgs e)
        {
            int Idx = 0;
            // Dim NowTimeStr As String = Now.ToLongTimeString.Replace(":", "").Replace(" ", "").Replace("-", "")
            // Randomize()
            // Dim RandomInt As Single = Rnd()
            // Dim ReportName As String = "./CLSForms/CLSPlotReport" + NowTimeStr + RandomInt.ToString.Replace(".", "") + ".txt"
            // Dim file As System.IO.StreamWriter
            // file = My.Computer.FileSystem.OpenTextFileWriter(ReportName, False)
            string TxtMsg = "Plotted Sight Data: ";
            var loopTo = PlotArray.GetUpperBound(0);
            for (Idx = 0; Idx <= loopTo; Idx++)
            {
                if (PlotArray[Idx].PlotType != null)
                {
                    string TmpStr = Environment.NewLine + "Type= " + PlotArray[Idx].PlotType + " " + " Sight #" + PlotArray[Idx].PlotNumber.ToString() + " Name = " + PlotArray[Idx].PsnName.ToString() + " Squadron = " + PlotArray[Idx].SquadronName.ToString() + " Body = " + PlotArray[Idx].PlotBody.ToString() + " Date/Time = " + PlotArray[Idx].PlotDT.ToString("MM/dd/yyy HH:mm:ss") + Environment.NewLine + " L = " + PlotArray[Idx].PlotLatDeg.ToString() + '°' + PlotArray[Idx].PlotLatMin.ToString() + "' " + PlotArray[Idx].PlotLatNS.ToString() + " Lo = " + PlotArray[Idx].PlotLongDeg.ToString() + '°' + PlotArray[Idx].PlotLongMin.ToString() + "' " + PlotArray[Idx].PlotLongEW.ToString() + " Int and Az = " + PlotArray[Idx].PlotIntercept.ToString() + " at " + PlotArray[Idx].PlotAz.ToString() + " " + PlotArray[Idx].PlotLLoBy + " Est Position = " + PlotArray[Idx].PlotSLEP.ToString() + Environment.NewLine;
                    // file.WriteLine(TmpStr)
                    TxtMsg += TmpStr;
                }
            }
            // file.Close()
            var unused = MessageBox.Show(TxtMsg, CaptionStr, MessageBoxButtons.OK, MessageBoxIcon.Information);
            // SendMsgBx(TxtMsg.ToString & vbNewLine & "Report of Plotted Sights saved in text file: " & ReportName, MessageBoxIcon.Information)
            return;
        }

        private static GeoCoordinate FindDestLatLong(double LatIn, double LonIn, double Dist, double Course)
        {
            double L2 = Math.Sin(LatIn * Math.PI / 180d) * Math.Cos(Dist / 3437.75d) + Math.Cos(LatIn * Math.PI / 180d) * Math.Sin(Dist / 3437.75d) * Math.Cos(Course * Math.PI / 180d);
            L2 = Math.Atan(L2 / Math.Sqrt(-L2 * L2 + 1d));
            double Lo2 = -1 * LonIn * Math.PI / 180d - Math.Atan2(Math.Sin(Course * Math.PI / 180d) * Math.Sin(Dist / 3437.75d) * Math.Cos(LatIn * Math.PI / 180d), Math.Cos(Dist / 3437.75d) - Math.Sin(LatIn * Math.PI / 180d) * Math.Sin(L2));
            L2 = L2 * 180d / Math.PI;
            Lo2 = Lo2 * 180d / Math.PI;
            if (Course == 0d & Dist > (90d - LatIn) * 60d)
            {
                Lo2 = -(180d - Lo2);
            }

            if (Math.Abs(Lo2) > 180d)
            {
                Lo2 = -Math.Sign(Lo2) * (360d - Math.Abs(Lo2));
            }

            var RtnGC = new GeoCoordinate(L2, -1 * Lo2);
            return RtnGC;
        }

        private void PicBoxPlot_MouseClick(object sender, MouseEventArgs e)
        {
            var CLoc1 = new Point(e.X - 11, e.Y - 5);
            int XFctr = (int)((MidX - CLoc1.X) / 600d * 10d); // * (OneNMLongPixels / OneNmPixels)
            int YFctr = (int)((MidY - CLoc1.Y) / 600d * 10d); // * 0.1
            CLoc1.X += XFctr;
            CLoc1.Y += YFctr;
            double TmpLat = 0d;
            if (CentralLatNS == "N")   // North Latitude
            {
                TmpLat = CentralLat + Convert.ToDouble((MidY - CLoc1.Y) / OneNmPixels / 60d);
            }
            else
            {
                TmpLat = CentralLat - Convert.ToDouble((MidY - CLoc1.Y) / OneNmPixels / 60d);
            }

            double TmpLong = 0d;
            if (CentralLongEW == "W")   // West Longitude
            {
                TmpLong = CentralLong + Convert.ToDouble((MidX - CLoc1.X) / OneNMLongPixels / 60d);
            }
            else
            {
                TmpLong = CentralLong - Convert.ToDouble((MidX - CLoc1.X) / OneNMLongPixels / 60d);
            }

            double TmpLatD = System.Math.Truncate(Math.Abs(TmpLat));
            double TmpLatM = Math.Round((Math.Abs(TmpLat) - TmpLatD) * 60d, 1);
            string TmpLatNS = "N";
            if (CentralLat < 0d)
            {
                TmpLatNS = "S";
            }

            double TmpLongD = System.Math.Truncate(Math.Abs(TmpLong));
            double TmpLongM = Math.Round((Math.Abs(TmpLong) - TmpLongD) * 60d, 1);
            string TmpLongEW = "W";
            if (CentralLong < 0d)
            {
                TmpLongEW = "E";
            }

            txtDispLoc.Text = "Lat=" + TmpLatD.ToString() + '°' + " " + TmpLatM.ToString("00.0") + "'" + TmpLatNS + " Lo=" + TmpLongD.ToString() + '°' + " " + TmpLongM.ToString("00.0") + "'" + TmpLongEW;
            Grph.Clear(Color.White);
            FormCLSLoading = false;
            FirstTimeInitGraphics();
            if (SetCentralLatLong() == false)
            {
                return;
            }

            // SetPlotSideSize()
            DrawBasicPlotForm();
            DrawPlots();
            var dpen1 = new Pen(Color.DarkBlue);
            dpen1.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            dpen1.Width = 2f;
            dpen1.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            Grph.DrawLine(dpen1, CLoc1.X, CLoc1.Y, RightX, CLoc1.Y);
            Grph.DrawLine(dpen1, CLoc1.X, CLoc1.Y, LeftX, CLoc1.Y);
            Grph.DrawLine(dpen1, CLoc1.X, CLoc1.Y, CLoc1.X, TopY);
            Grph.DrawLine(dpen1, CLoc1.X, CLoc1.Y, CLoc1.X, BottomY);
            dpen1.Dispose();
            SaveDisplayBMFname();
            Refresh();
            BringToFront();
            Show();
        }

        private void PicBoxPlot_MouseEnter(object sender, EventArgs e)
        {
            // txtDispLoc.Clear()
            // txtDispLoc.Visible = True
            Cursor = Cursors.UpArrow;
        }

        private void PicBoxPlot_MouseLeave(object sender, EventArgs e)
        {
            // txtDispLoc.Clear()
            // txtDispLoc.Visible = False
            Cursor = Cursors.Default;
        }
    }
}