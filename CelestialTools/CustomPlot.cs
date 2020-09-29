using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace CelestialTools
{
    public partial class CustomPlot
    {
        public CustomPlot()
        {
            EPLineLoc = new System.Windows.Point(EPLineLocX, EPLineLocY);
            InitializeComponent();
            _btnPrtSights.Name = "btnPrtSights";
            _ExitBtn.Name = "ExitBtn";
            _cboPlotSize.Name = "cboPlotSize";
            _chkDisplayRose.Name = "chkDisplayRose";
            _txtLatActive.Name = "txtLatActive";
            _txtLongActive.Name = "txtLongActive";
            _PicBoxPlot.Name = "PicBoxPlot";
            _cmdPrint.Name = "cmdPrint";
        }

        private int OneNmPixels = 0;
        // Private DefaultPixels As Double = 11
        private int OneNMLongPixels = 0;
        private int NMSizeonSide = 0;
        private readonly double ToRad = Math.PI / 180d;
        private readonly double ToDeg = 180d / Math.PI;
        private int MidX;
        private int MidY;
        private int BottomY;
        private int BottomX;
        private System.Windows.Point BottomCenter;
        private System.Windows.Point CenterofPlot;
        private int LeftX;
        private int RightX;
        private int TopY;
        private int TopX;
        private double ULLat;
        private double ULLong;
        private double URLat;
        private double URLong;
        private double LLLat;
        private double LLLong;
        private double LRLat;
        private double LRLong;
        private readonly Pen myPen = new Pen(Color.Black, 2f);
        private readonly Pen DPen = new Pen(Color.Black, 1f);
        private readonly Pen CompRosePen = new Pen(Color.DarkBlue, 1f);
        private readonly Font myFont = new Font("Arial", 10f, System.Drawing.FontStyle.Regular);
        private readonly Font ArialFont = new Font("Arial", 8f, System.Drawing.FontStyle.Bold);
        private readonly Font TimesNewFont = new Font("Times New Roman", 8f, System.Drawing.FontStyle.Bold);
        private readonly Font myFontBold = new Font("Arial", 10f, System.Drawing.FontStyle.Bold);
        private bool IssuingSendMsgBx = false;
        private double CentralLat = 0d;
        private int CentralLatDeg;
        private int CentralLatMin;
        private string CentralLatNS;
        private double CentralLong = 0d;
        private int CentralLongDeg;
        private int CentralLongMin;
        private string CentralLongEW;
        private double TopLeftLat = 0d;
        private int TopLeftLatDeg;
        private double TopLeftLatMin;
        private string TopLeftLatNS;
        private double TopLeftLong = 0d;
        private int TopLeftLongDeg;
        private double TopLeftLongMin;
        private string TopLeftLongEW;
        private int TopEdge = 40;
        private int SideEdge = 48;
        private int SideY = 0;
        private int SideX = 0;
        private CLSForm.PlotEntry[] PlotArray = new CLSForm.PlotEntry[1];
        private Graphics Grph;
        private Bitmap bm;
        private readonly string BMFname = "./Graphics/CustomPlotForm.jpg";
        private int DrawWidth;
        // Private ptA As Point
        // Private ptB As Point
        private int myIdx = 0;
        private bool FormCLSLoading = false;

        public struct DegMinCalc
        {
            public int CalcDeg;
            public double CalcMin;
            public double CalcDMS;
            public int CalcMouseLoc;
        }

        private DegMinCalc DMCalc;
        // Private XAxisArray As DegMinCalc()
        // Private YAxisArray As DegMinCalc()
        private int XAxisArrayCtr = 0;
        private int YAxisArrayCtr = 0;
        private double PlotIntCalc;
        private string PlotIntCalcTA;
        private double PlotAzCalc;
        private double PlotLat;
        private string PlotLatNS;
        private double PlotLong;
        private string PlotLongEW;
        private string PlotDRTime = Constants.vbNullString;
        private double PlotEPLat;
        // Private ReadOnly PlotEPLatNS As String
        private double PlotEPLong;
        // Private ReadOnly PlotEPLongEW As Double
        private System.Windows.Size OrigFormSize;
        private System.Windows.Size OrigPicBoxSize;
        private int PlotTimeCount = 0;
        private int PlotDRTimeCount = 0;
        private int PlotAPTimeCount = 0;
        private bool isRunningSunSight = false;
        // Private ReadOnly LatDelta As Double = 0
        // Private ReadOnly LongDelta As Double = 0
        private int RunSunSightNum = 0;
        private int EPLineCount = 0;
        private int EPLineLocX = 255;
        private int EPLineLocY = 575;
        private System.Windows.Point EPLineLoc;
        // Private Toggle As Boolean = False

        public struct SaveSuns
        {
            public int SunIndex;
            public DateTime SunDt;
        }

        public SaveSuns[] SunArray = new SaveSuns[1];

        public void RunningSunSight()
        {
            SunArray = new SaveSuns[1];
            int idx = 0;
            int LastSun = -1;
            int EarlySun = -1;
            if (Information.UBound(PlotArray) >= 1) // is there at least two entries in plot array
            {
                for (int i = 0, loopTo = Information.UBound(PlotArray) - 1; i <= loopTo; i++)
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

        public void AddPlotEntry(CLSForm.PlotEntry PlotIn)
        {
            int Idx = Information.UBound(PlotArray);
            myIdx = Idx;
            PlotArray[Idx] = PlotIn;
            Idx += 1;
            Array.Resize(ref PlotArray, Idx + 1);
            return;
        }

        public bool PlotSight()
        {
            FormCLSLoading = true;
            PlotTimeCount = 0;
            FirstTimeInit();
            RunningSunSight();
            if (SetandEditCentralLatLong() == false)
            {
                // SendMsgBx("Error in Lat/Long Plot data - unrecoverable error in code - contact support to correct", MessageBoxIcon.Hand)
                return false;
                return default;
            }

            SetPlotSideSize();
            // SetPlotInfoFields()
            DrawBasicPlotForm();
            DrawPlots();
            SaveDisplayBMFname();
            FormCLSLoading = false;
            cboPlotSize.Enabled = true;
            Refresh();
            BringToFront();
            Show();
            return true;
            return default;
        }

        private void CustomPlot_Load(object sender, EventArgs e)
        {
            FormCLSLoading = true;
            var PlotArray = new object[1];
            var MapLattoY = new object[1];
            var MapLongtoX = new object[1];
            var XAxisArray = new object[1];
            var YAxisArray = new object[1];
            XAxisArrayCtr = 0;
            YAxisArrayCtr = 0;
            // txtPlots.ReadOnly = True
            // OrigFormSize = Me.Size
            // OrigPicBoxSize = PicBoxPlot.Size
            PicBoxPlot.SizeMode = PictureBoxSizeMode.StretchImage;
            cboPlotSize.SelectedIndex = 2; // Default size of 60 nm on a side
            cboPlotSize.Enabled = false;
            FormCLSLoading = false;
        }

        private void FirstTimeInit()
        {
            // CleanOutOldFiles()
            // RenamePlotJpg()

            var DPen = new Pen(Color.Black, 2f);
            DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            bm = new Bitmap(PicBoxPlot.Width, PicBoxPlot.Height);
            bm = (Bitmap)Image.FromFile("./CLSForms/customplottemplateV1.jpg");
            Grph = PicBoxPlot.CreateGraphics();
            Grph = Graphics.FromImage(bm);
            Grph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Grph.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            Grph.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            Grph.TranslateTransform(0f, 0f);
            // SaveDisplayBMFname()
            if (FormCLSLoading == true)
            {
                cboPlotSize.SelectedIndex = 2; // Default size of 60 nm on a side
                chkDisplayRose.Checked = true;
            }

            return;
        }

        private PrintDocument _PrtDoc;

        private PrintDocument PrtDoc
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PrtDoc;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PrtDoc != null)
                {
                    _PrtDoc.PrintPage -= PrtDoc_PrintPage;
                }

                _PrtDoc = value;
                if (_PrtDoc != null)
                {
                    _PrtDoc.PrintPage += PrtDoc_PrintPage;
                }
            }
        }

        private PrintDocument PrtDocTxt;
        private string PrtFileName = "./PrtScnCustomPlot.jpg";

        private void cmdPrint_Click(object sender, EventArgs e)
        {
            // This code needs to be here instead of in PrintScreen module because the code here works and produces full image - the code in PrintScreen while identical does not ????
            var PrintDialog1 = new PrintDialog();
            PrintDialog1.UseEXDialog = true;
            PrintDialog1.AllowPrintToFile = false;
            PrintDialog1.AllowCurrentPage = false;
            PrintDialog1.AllowSelection = false;
            PrintDialog1.AllowSomePages = false;
            var PrtDoc = new PrintDocument();
            PrtDoc.PrintPage += PrtDoc_PrintPage;
            Bitmap capture;
            Graphics graph;
            capture = new Bitmap(Width, Height); // System.Drawing.Imaging.PixelFormat.Format32bppArgb)
            graph = Graphics.FromImage(capture);
            graph.CopyFromScreen(Location.X + 10, Location.Y, 0, 0, Size); // CopyPixelOperation.SourceCopy)
            if (My.MyProject.Computer.FileSystem.FileExists(PrtFileName))
            {
                My.MyProject.Computer.FileSystem.DeleteFile(PrtFileName);
            }

            capture.Save(PrtFileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            PrtDoc.DocumentName = PrtFileName;
            PrintDialog1.Document = PrtDoc;
            if (PrintDialog1.ShowDialog() == DialogResult.OK)
            {
                PrtDoc.Print();
            }

            graph.Dispose();
            capture.Dispose();
            PrintDialog1.Dispose();
            PrtDoc.Dispose();
            return;
        }

        private void PrtDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            var img = Image.FromFile(PrtFileName);
            e.Graphics.DrawImage(img, 0, 0, Width - 90, Height);
            img.Dispose();
            return;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            myPen.Dispose();
            myFont.Dispose();
            DPen.Dispose();
            CompRosePen.Dispose();
            ArialFont.Dispose();
            TimesNewFont.Dispose();
            myFontBold.Dispose();
            Grph.Dispose();
            Close();
            return;
        }

        private bool SetandEditCentralLatLong()
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
            if (Information.UBound(PlotArray) > 1)
            {
                for (int i = 0, loopTo = Information.UBound(PlotArray); i <= loopTo; i++)
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
                                    return default;
                                }

                                if ((PlotArray[i].PlotLongEW ?? "") != (PlotArray[i - 1].PlotLongEW ?? ""))
                                {
                                    SendMsgBx("Error: Plots must be in the same Longitude E or W - Exit and Try Again", MessageBoxIcon.Error);
                                    return false;
                                    return default;
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

                    LatDiffMin = (LatDiff - Conversion.Int(LatDiff)) * 60d;
                    if (LatDiffMin > 59.9d | Conversion.Int(LatDiff) > 1d)
                    {
                        SendMsgBx("Error: Distances between all latitudes must be less than 60 miles to plot", MessageBoxIcon.Error);
                        return false;
                        return default;
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
                    // LongDiff = HighLong - LowLong
                    LongDiffMin = (LongDiff - Conversion.Int(LongDiff)) * 60d;
                    if (LongDiffMin > 59.9d | Conversion.Int(LongDiff) > 1d)
                    {
                        SendMsgBx("Error: Distances between all longitudes must be less than 60 miles to plot", MessageBoxIcon.Error);
                        return false;
                        return default;
                    }
                }
            }

            if (Information.UBound(PlotArray) == 1)
            {
                CentralLatDeg = Math.Abs(Convert.ToInt32(PlotArray[myIdx].PlotLatDeg));
                CentralLatMin = Math.Abs(Convert.ToInt32(Conversion.Int(Convert.ToDouble(PlotArray[myIdx].PlotLatMin)) / 10d) * 10);
                if (CentralLatMin == 60)
                {
                    CentralLatMin = 0;
                    CentralLatDeg += 1;
                }

                CentralLat = CentralLatDeg + CentralLatMin / 60d;
                CentralLongDeg = Math.Abs(Convert.ToInt32(PlotArray[myIdx].PlotLongDeg));
                CentralLongMin = Math.Abs(Convert.ToInt32(Conversion.Int(Convert.ToDouble(PlotArray[myIdx].PlotLongMin)) / 10d) * 10);
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
                for (int i = 0, loopTo1 = Information.UBound(PlotArray); i <= loopTo1; i++)
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
                CentralLatDeg = (int)Conversion.Int(AvgLat);
                CentralLatMin = Convert.ToInt32((AvgLat - CentralLatDeg) * 60d / 10d) * 10;
                if (CentralLatMin == 60)
                {
                    CentralLatMin = 0;
                    CentralLatDeg += 1;
                }

                CentralLat = CentralLatDeg + CentralLatMin / 60d;
                CentralLongDeg = (int)Conversion.Int(AvgLong);
                CentralLongMin = Convert.ToInt32((AvgLong - CentralLongDeg) * 60d / 10d) * 10;
                if (CentralLongMin == 60)
                {
                    CentralLongMin = 0;
                    CentralLongDeg += 1;
                }

                CentralLong = CentralLongDeg + CentralLongMin / 60d;
            }

            CentralLatNS = PlotArray[myIdx].PlotLatNS.Trim();
            txtLatActive.Text = CentralLatDeg.ToString("##0") + '°' + " " + CentralLatMin.ToString("00.0") + "' " + CentralLatNS;
            // cboMidLat.SelectedIndex = 0
            CentralLongEW = PlotArray[myIdx].PlotLongEW.Trim();
            txtLongActive.Text = CentralLongDeg.ToString("##0") + '°' + " " + CentralLongMin.ToString("00.0") + "' " + CentralLongEW;
            // cboMidLong.SelectedIndex = 0
            double TopLeftAdjMin = NMSizeonSide / 2d / 60d; // Take NM on a side divide by 2 to get total minutes then divide by 60 to get degrees
            if ((CentralLatNS ?? "") == (CommonGlobals.g_LatN ?? ""))
            {
                TopLeftLat = CentralLat + TopLeftAdjMin;
            }
            else
            {
                TopLeftLat = CentralLat - TopLeftAdjMin;
            }

            if ((CentralLongEW ?? "") == (CommonGlobals.g_LongW ?? ""))
            {
                TopLeftLong = CentralLong + TopLeftAdjMin;
            }
            else
            {
                TopLeftLong = CentralLong - TopLeftAdjMin;
            }

            TopLeftLatDeg = (int)Math.Truncate(TopLeftLat);
            TopLeftLatMin = (TopLeftLat - TopLeftLatDeg) * 60d;
            TopLeftLatNS = CentralLatNS;
            TopLeftLongDeg = (int)Math.Truncate(TopLeftLong);
            TopLeftLongMin = (TopLeftLong - TopLeftLongDeg) * 60d;
            TopLeftLongEW = CentralLongEW;
            Refresh();
            Show();
            return true;
            return default;
        }

        public void SetPlotSideSize()
        {
            string tempStr = cboPlotSize.Text;   // Items(cboPlotSize.SelectedIndex).ToString
            tempStr = tempStr.Substring(tempStr.IndexOf("to") + 2, tempStr.IndexOf("nm") - (tempStr.IndexOf("to") + 2)).Trim();
            int tempSize = Convert.ToInt32(tempStr);
            NMSizeonSide = tempSize;
            switch (NMSizeonSide)
            {
                case 100:
                    {
                        // OneNmPixels = 6
                        OneNmPixels = (int)((PicBoxPlot.Width - 6 * SideEdge) / 100d);
                        OneNMLongPixels = (int)(OneNmPixels * Math.Cos(CentralLat * ToRad));
                        break;
                    }

                case 80:
                    {
                        // OneNmPixels = 8
                        OneNmPixels = (int)((PicBoxPlot.Width - 6 * SideEdge) / 80d);
                        OneNMLongPixels = (int)(OneNmPixels * Math.Cos(CentralLat * ToRad));
                        break;
                    }

                case 60:
                    {
                        // OneNmPixels = 11
                        OneNmPixels = (int)((PicBoxPlot.Width - 6 * SideEdge) / 60d);
                        OneNMLongPixels = (int)(OneNmPixels * Math.Cos(CentralLat * ToRad));
                        break;
                    }

                case 40:
                    {
                        // OneNmPixels = 15
                        OneNmPixels = (int)((PicBoxPlot.Width - 6 * SideEdge) / 40d);
                        OneNMLongPixels = (int)(OneNmPixels * Math.Cos(CentralLat * ToRad));
                        break;
                    }

                case 20:
                    {
                        // OneNmPixels = 30
                        OneNmPixels = (int)((PicBoxPlot.Width - 6 * SideEdge) / 20d);
                        OneNMLongPixels = (int)(OneNmPixels * Math.Cos(CentralLat * ToRad));
                        break;
                    }

                default:
                    {
                        // OneNmPixels = 11
                        OneNmPixels = (int)((PicBoxPlot.Width - 6 * SideEdge) / 60d);
                        OneNMLongPixels = (int)(OneNmPixels * Math.Cos(CentralLat * ToRad));
                        break;
                    }
            }

            return;
        }

        private void DrawBasicPlotForm()
        {
            // ReDim XAxisArray(0)
            // ReDim YAxisArray(0)
            XAxisArrayCtr = 0;
            YAxisArrayCtr = 0;
            SideY = OneNmPixels * NMSizeonSide;
            SideX = OneNmPixels * NMSizeonSide;
            TopY = PicBoxPlot.Location.Y + TopEdge;
            TopX = PicBoxPlot.Location.X + SideEdge;
            LeftX = PicBoxPlot.Location.X + SideEdge;
            RightX = PicBoxPlot.Location.X + SideEdge + SideX;
            MidX = (int)(PicBoxPlot.Location.X + SideEdge + SideX / 2d);
            MidY = (int)(PicBoxPlot.Location.Y + TopEdge + SideY / 2d);
            BottomY = PicBoxPlot.Location.Y + TopEdge + SideY;
            BottomX = PicBoxPlot.Location.X + SideEdge + SideX;
            BottomCenter = new System.Windows.Point(MidX, BottomY);
            CenterofPlot = new System.Windows.Point(MidX, MidY);

            // Clear the pic box and then draw a rectangle
            Grph.Clear(Color.White);
            Grph.DrawRectangle(DPen, TopX, TopY, SideX, SideY);

            // Draw the mid lat and mid long lines
            Grph.DrawLine(DPen, MidX, BottomY, MidX, TopY);
            Grph.DrawLine(DPen, RightX, MidY, LeftX, MidY);

            // Now draw the tic marks on each axis - starting with the x-axis
            int TempXlen = 0;
            int TempYLen = 0;
            int i = 0;
            // Dim TempLat As Double = CentralLat
            // Dim TempPt As Integer = MidX
            // AddXAxisArray(TempLat, TempPt)
            var loopTo = (int)(NMSizeonSide / 2d);
            for (i = 1; i <= loopTo; i++)
            {
                TempXlen = (int)(MidX + Math.Round((decimal)Convert.ToInt32(i * OneNMLongPixels), 0, MidpointRounding.AwayFromZero));
                if (i % 10 == 0)
                {
                    DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                    Grph.DrawLine(DPen, TempXlen, BottomY, TempXlen, TopY);
                }
                else if (i % 5 == 0)
                {
                    DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    Grph.DrawLine(DPen, TempXlen, BottomY, TempXlen, BottomY - 10);
                    Grph.DrawLine(DPen, TempXlen, TopY, TempXlen, TopY + 10);
                }
                else
                {
                    DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    Grph.DrawLine(DPen, TempXlen, BottomY, TempXlen, BottomY - 5);
                    Grph.DrawLine(DPen, TempXlen, TopY, TempXlen, TopY + 5);
                }
                // TempLat = CalcDMSAxis(XAxisArray(i - 1), +1)
                // TempPt = TempXlen
                // AddXAxisArray(TempLat, TempPt)
            }
            // TempLat = CentralLat
            // TempPt = MidX
            var loopTo1 = (int)(NMSizeonSide / 2d);
            for (i = 1; i <= loopTo1; i++)
            {
                TempXlen = MidX - Convert.ToInt32(i * OneNMLongPixels);
                if (i % 10 == 0)
                {
                    DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                    Grph.DrawLine(DPen, TempXlen, BottomY, TempXlen, TopY);
                }
                else if (i % 5 == 0)
                {
                    DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    Grph.DrawLine(DPen, TempXlen, BottomY, TempXlen, BottomY - 10);
                    Grph.DrawLine(DPen, TempXlen, TopY, TempXlen, TopY + 10);
                }
                else
                {
                    DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    Grph.DrawLine(DPen, TempXlen, BottomY, TempXlen, BottomY - 5);
                    Grph.DrawLine(DPen, TempXlen, TopY, TempXlen, TopY + 5);
                }
                // TempLat = CalcDMSAxis(XAxisArray(i - 1), -1)
                // TempPt = TempXlen
                // AddXAxisArray(TempLat, TempPt)
            }
            // SortXAxisArray()
            // Dim TempLong As Double = CentralLong
            // TempPt = MidY
            // AddYAxisArray(TempLat, TempPt)
            var loopTo2 = (int)(NMSizeonSide / 2d);
            for (i = 1; i <= loopTo2; i++)
            {
                TempYLen = MidY + Convert.ToInt32(i * OneNmPixels);
                if (i % 10 == 0)
                {
                    DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                    Grph.DrawLine(DPen, LeftX, TempYLen, RightX, TempYLen);
                }
                else if (i % 5 == 0)
                {
                    DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    Grph.DrawLine(DPen, RightX, TempYLen, RightX - 10, TempYLen);
                    Grph.DrawLine(DPen, LeftX, TempYLen, LeftX + 10, TempYLen);
                }
                else
                {
                    DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    Grph.DrawLine(DPen, RightX, TempYLen, RightX - 5, TempYLen);
                    Grph.DrawLine(DPen, LeftX, TempYLen, LeftX + 5, TempYLen);
                }
                // TempLong = CalcDMSAxis(YAxisArray(i - 1), +1)
                // TempPt = TempXlen
                // AddYAxisArray(TempLat, TempPt)
            }
            // TempLong = CentralLong
            // TempPt = MidY
            var loopTo3 = (int)(NMSizeonSide / 2d);
            for (i = 1; i <= loopTo3; i++)
            {
                TempYLen = MidY - Convert.ToInt32(i * OneNmPixels);
                if (i % 10 == 0)
                {
                    DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                    Grph.DrawLine(DPen, LeftX, TempYLen, RightX, TempYLen);
                }
                else if (i % 5 == 0)
                {
                    DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    Grph.DrawLine(DPen, RightX, TempYLen, RightX - 10, TempYLen);
                    Grph.DrawLine(DPen, LeftX, TempYLen, LeftX + 10, TempYLen);
                }
                else
                {
                    DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    Grph.DrawLine(DPen, RightX, TempYLen, RightX - 5, TempYLen);
                    Grph.DrawLine(DPen, LeftX, TempYLen, LeftX + 5, TempYLen);
                }
                // TempLong = CalcDMSAxis(YAxisArray(i - 1), -1)
                // TempPt = TempXlen
                // AddYAxisArray(TempLat, TempPt)
            }
            // SortYAxisArray()

            // Draw compass rose if the check box is checked
            DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            if (chkDisplayRose.Checked == true)
            {
                // Dim CircleX As Integer = PicBoxPlot.Location.X + SideEdge + (SideX / 4)
                // Dim CircleY As Integer = PicBoxPlot.Location.Y + TopEdge + (SideY / 4)

                // Dim rectSide As Integer = Convert.ToInt32(System.Math.Round(SideX / 2, 0, MidpointRounding.AwayFromZero))
                var tempRect = new Rectangle((int)(MidX - SideX / 4d), (int)(MidY - SideX / 4d), (int)(SideX / 2d), (int)(SideX / 2d));
                Grph.DrawArc(CompRosePen, tempRect, 0f, 360f);
                // Grph.DrawEllipse(CompRosePen, tempRect)
                DrawWidth = (int)Math.Round(SideX / 4d, 0, MidpointRounding.AwayFromZero);
                int tempDeg = 0;
                for (int j = 0; j <= 179; j += 1)
                {
                    Grph.TranslateTransform(MidX, MidY);
                    Grph.RotateTransform(-90 + j);
                    if (j % 5 == 0)
                    {
                        Grph.DrawLine(CompRosePen, DrawWidth - 5, 0, DrawWidth + 5, 0);
                        Grph.DrawLine(CompRosePen, -DrawWidth + 5, 0, -DrawWidth - 5, 0);
                    }
                    else
                    {
                        Grph.DrawLine(CompRosePen, DrawWidth - 3, 0, DrawWidth + 3, 0);
                        Grph.DrawLine(CompRosePen, -DrawWidth + 3, 0, -DrawWidth - 3, 0);
                    }

                    if (j % 10 == 0)
                    {
                        Grph.DrawString(j.ToString("##0") + '°', ArialFont, Brushes.DarkBlue, DrawWidth + 3, -7);
                        Grph.DrawString((j + 180).ToString("##0") + '°', ArialFont, Brushes.DarkBlue, -DrawWidth - 25, -7);
                    }

                    Grph.ResetTransform();
                }
            }

            var Efont = new Font("Arial", 7f, System.Drawing.FontStyle.Bold);
            // now draw the lat and long test strings on the axis of this plot
            string TempStr = CentralLatDeg.ToString("##0") + '°' + " " + CentralLatMin.ToString("##0.0") + "' " + CentralLatNS.ToString();
            Grph.DrawString(TempStr, Efont, Brushes.Black, RightX + 2, MidY - 5);
            Grph.DrawString(TempStr, Efont, Brushes.Black, LeftX - 25 - TempStr.Length, MidY - 5);
            DMCalc.CalcDeg = CentralLatDeg;
            DMCalc.CalcMin = CentralLatMin;
            DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            int tmpLim = (int)(NMSizeonSide / 2d / 10d);
            if ((CentralLatNS ?? "") == (CommonGlobals.g_LatN ?? ""))
            {
                var loopTo4 = tmpLim;
                for (i = 1; i <= loopTo4; i++)
                {
                    int Incr1 = 10 * i;
                    CalcDegMin(DMCalc.CalcDeg, (int)DMCalc.CalcMin, +10);
                    TempStr = DMCalc.CalcDeg.ToString("##0") + '°' + " " + DMCalc.CalcMin.ToString("##0.0") + "' " + CentralLatNS.ToString();
                    Grph.DrawString(TempStr, Efont, Brushes.Black, RightX + 2, MidY - 5 - OneNmPixels * Incr1);
                    Grph.DrawString(TempStr, Efont, Brushes.Black, LeftX - 25 - TempStr.Length, MidY - 5 - OneNmPixels * Incr1);
                    if (i < tmpLim)
                    {
                        Grph.DrawLine(DPen, new PointF(LeftX, MidY - OneNmPixels * Incr1), new PointF(RightX, MidY - OneNmPixels * Incr1));
                    }
                }

                URLat = DMCalc.CalcDeg + DMCalc.CalcMin / 60d;
                ULLat = DMCalc.CalcDeg + DMCalc.CalcMin / 60d;
                DMCalc.CalcDeg = CentralLatDeg;
                DMCalc.CalcMin = CentralLatMin;
                var loopTo5 = tmpLim;
                for (i = 1; i <= loopTo5; i++)
                {
                    int Incr2 = -10 * i;
                    CalcDegMin(DMCalc.CalcDeg, (int)DMCalc.CalcMin, -10);
                    TempStr = DMCalc.CalcDeg.ToString("##0") + '°' + " " + DMCalc.CalcMin.ToString("##0.0") + "' " + CentralLatNS.ToString();
                    Grph.DrawString(TempStr, Efont, Brushes.Black, RightX + 2, MidY - 5 - OneNmPixels * Incr2);
                    Grph.DrawString(TempStr, Efont, Brushes.Black, LeftX - 25 - TempStr.Length, MidY - 5 - OneNmPixels * Incr2);
                    if (i < tmpLim)
                    {
                        Grph.DrawLine(DPen, new PointF(LeftX, MidY - OneNmPixels * Incr2), new PointF(RightX, MidY - OneNmPixels * Incr2));
                    }
                }

                LLLat = DMCalc.CalcDeg + DMCalc.CalcMin / 60d;
                LRLat = DMCalc.CalcDeg + DMCalc.CalcMin / 60d;
            }
            else
            {
                var loopTo6 = tmpLim;
                for (i = 1; i <= loopTo6; i++)
                {
                    int Incr3 = -10 * i;
                    CalcDegMin(DMCalc.CalcDeg, (int)DMCalc.CalcMin, -10);
                    TempStr = DMCalc.CalcDeg.ToString("##0") + '°' + " " + DMCalc.CalcMin.ToString("##0.0") + "' " + CentralLatNS.ToString();
                    Grph.DrawString(TempStr, Efont, Brushes.Black, RightX + 2, MidY - 5 + OneNmPixels * Incr3);
                    Grph.DrawString(TempStr, Efont, Brushes.Black, LeftX - 25 - TempStr.Length, MidY - 5 + OneNmPixels * Incr3);
                    if (i < tmpLim)
                    {
                        Grph.DrawLine(DPen, new PointF(LeftX, MidY - OneNmPixels * Incr3), new PointF(RightX, MidY - OneNmPixels * Incr3));
                    }
                }

                URLat = -1 * DMCalc.CalcDeg + DMCalc.CalcMin / 60d;
                ULLat = -1 * DMCalc.CalcDeg + DMCalc.CalcMin / 60d;
                DMCalc.CalcDeg = CentralLatDeg;
                DMCalc.CalcMin = CentralLatMin;
                var loopTo7 = tmpLim;
                for (i = 1; i <= loopTo7; i++)
                {
                    int Incr4 = +10 * i;
                    CalcDegMin(DMCalc.CalcDeg, (int)DMCalc.CalcMin, +10);
                    TempStr = DMCalc.CalcDeg.ToString("##0") + '°' + " " + DMCalc.CalcMin.ToString("##0.0") + "' " + CentralLatNS.ToString();
                    Grph.DrawString(TempStr, Efont, Brushes.Black, RightX + 2, MidY - 5 + OneNmPixels * Incr4);
                    Grph.DrawString(TempStr, Efont, Brushes.Black, LeftX - 25 - TempStr.Length, MidY - 5 + OneNmPixels * Incr4);
                    if (i < tmpLim)
                    {
                        Grph.DrawLine(DPen, new PointF(LeftX, MidY - OneNmPixels * Incr4), new PointF(RightX, MidY - OneNmPixels * Incr4));
                    }
                }

                LLLat = -1 * DMCalc.CalcDeg + DMCalc.CalcMin / 60d;
                LRLat = -1 * DMCalc.CalcDeg + DMCalc.CalcMin / 60d;
            }

            TempStr = CentralLongDeg.ToString("##0") + '°' + " " + CentralLongMin.ToString("##0.0") + "' " + CentralLongEW.ToString();
            Grph.DrawString(TempStr, Efont, Brushes.Black, MidX - 20, BottomY + 5);
            Grph.DrawString(TempStr, Efont, Brushes.Black, MidX - 20, TopY - 15);
            DMCalc.CalcDeg = CentralLongDeg;
            DMCalc.CalcMin = CentralLongMin;
            if ((CentralLongEW ?? "") == (CommonGlobals.g_LongW ?? ""))
            {
                var loopTo8 = tmpLim;
                for (i = 1; i <= loopTo8; i++)
                {
                    int Incr1 = 10 * i;
                    CalcDegMin(DMCalc.CalcDeg, (int)DMCalc.CalcMin, 10);
                    TempStr = DMCalc.CalcDeg.ToString("##0") + '°' + " " + DMCalc.CalcMin.ToString("##0.0") + "' " + CentralLongEW.ToString();
                    Grph.DrawString(TempStr, Efont, Brushes.Black, MidX - 20 - OneNMLongPixels * Incr1, BottomY + 5);
                    Grph.DrawString(TempStr, Efont, Brushes.Black, MidX - 20 - OneNMLongPixels * Incr1, TopY - 15);
                }

                URLong = DMCalc.CalcDeg + DMCalc.CalcMin / 60d;
                LRLong = DMCalc.CalcDeg + DMCalc.CalcMin / 60d;
                DMCalc.CalcDeg = CentralLongDeg;
                DMCalc.CalcMin = CentralLongMin;
                var loopTo9 = tmpLim;
                for (i = 1; i <= loopTo9; i++)
                {
                    int Incr2 = -10 * i;
                    CalcDegMin(DMCalc.CalcDeg, (int)DMCalc.CalcMin, -10);
                    TempStr = DMCalc.CalcDeg.ToString("##0") + '°' + " " + DMCalc.CalcMin.ToString("##0.0") + "' " + CentralLongEW.ToString();
                    Grph.DrawString(TempStr, Efont, Brushes.Black, MidX - 20 - OneNMLongPixels * Incr2, BottomY + 5);
                    Grph.DrawString(TempStr, Efont, Brushes.Black, MidX - 20 - OneNMLongPixels * Incr2, TopY - 15);
                }

                ULLong = DMCalc.CalcDeg + DMCalc.CalcMin / 60d;
                LLLong = DMCalc.CalcDeg + DMCalc.CalcMin / 60d;
            }
            else
            {
                var loopTo10 = tmpLim;
                for (i = 1; i <= loopTo10; i++)
                {
                    int Incr3 = 10 * i;
                    CalcDegMin(DMCalc.CalcDeg, (int)DMCalc.CalcMin, 10);
                    TempStr = DMCalc.CalcDeg.ToString("##0") + '°' + " " + DMCalc.CalcMin.ToString("##0.0") + "' " + CentralLongEW.ToString();
                    Grph.DrawString(TempStr, Efont, Brushes.Black, MidX - 20 + OneNMLongPixels * Incr3, BottomY + 5);
                    Grph.DrawString(TempStr, Efont, Brushes.Black, MidX - 20 + OneNMLongPixels * Incr3, TopY - 15);
                }

                URLong = -1 * DMCalc.CalcDeg + DMCalc.CalcMin / 60d;
                LRLong = -1 * DMCalc.CalcDeg + DMCalc.CalcMin / 60d;
                DMCalc.CalcDeg = CentralLongDeg;
                DMCalc.CalcMin = CentralLongMin;
                var loopTo11 = tmpLim;
                for (i = 1; i <= loopTo11; i++)
                {
                    int Incr4 = -10 * i;
                    CalcDegMin(DMCalc.CalcDeg, (int)DMCalc.CalcMin, -10);
                    TempStr = DMCalc.CalcDeg.ToString("##0") + '°' + " " + DMCalc.CalcMin.ToString("##0.0") + "' " + CentralLongEW.ToString();
                    Grph.DrawString(TempStr, Efont, Brushes.Black, MidX - 20 + OneNMLongPixels * Incr4, BottomY + 5);
                    Grph.DrawString(TempStr, Efont, Brushes.Black, MidX - 20 + OneNMLongPixels * Incr4, TopY - 15);
                }

                ULLong = -1 * DMCalc.CalcDeg + DMCalc.CalcMin / 60d;
                LLLong = -1 * DMCalc.CalcDeg + DMCalc.CalcMin / 60d;
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
                DMCalc.CalcMin = 50d;
                return;
            }

            if (InIncr > 0)
            {
                if (tempmin == 60)
                {
                    DMCalc.CalcDeg = InDeg + 1;
                    DMCalc.CalcMin = 0d;
                }
                else
                {
                    DMCalc.CalcMin = tempmin;
                }
            }
            else if (tempmin == 0)
            {
                DMCalc.CalcDeg = InDeg;
                DMCalc.CalcMin = 0d;
            }
            else
            {
                DMCalc.CalcMin = tempmin;
            }

            return;
        }

        private double CalcDMSAxis(DegMinCalc DMSIn, int InIncr)
        {
            int tempmin = (int)(DMSIn.CalcMin + InIncr);
            var TempDMS = DMSIn;
            if (TempDMS.CalcMin == 0d & InIncr < 0)
            {
                TempDMS.CalcDeg = DMSIn.CalcDeg - 1;
                TempDMS.CalcMin = 50d;
                TempDMS.CalcDMS = TempDMS.CalcDeg + TempDMS.CalcMin / 60d;
                return TempDMS.CalcDMS;
            }

            if (InIncr > 0)
            {
                if (tempmin == 60)
                {
                    TempDMS.CalcDeg = DMSIn.CalcDeg + 1;
                    TempDMS.CalcMin = 0d;
                }
                else
                {
                    TempDMS.CalcMin = tempmin;
                }
            }
            else if (tempmin == 0)
            {
                TempDMS.CalcDeg = DMSIn.CalcDeg;
                TempDMS.CalcMin = 0d;
            }
            else
            {
                TempDMS.CalcMin = tempmin;
            }

            TempDMS.CalcDMS = TempDMS.CalcDeg + TempDMS.CalcMin / 60d;
            return TempDMS.CalcDMS;
            return default;
        }
        // Private Sub SetPlotInfoFields()
        // txtSummary.Clear()
        // Dim Idx As Integer = 0
        // For Idx = 0 To UBound(PlotArray)
        // If PlotArray(Idx).PlotType <> Nothing Then
        // txtSummary.AppendText(PlotArray(Idx).PlotType.ToString & " # " & PlotArray(Idx).PlotNumber.ToString & '" Name = " & PlotArray(Idx).PsnName.ToString & " Squadron = " & PlotArray(Idx).SquadronName.ToString &
        // " ;Body = " & PlotArray(Idx).PlotBody.ToString & " ;Date/Time = " & PlotArray(Idx).PlotDT.ToString("MM/dd/yyy HH:mm:ss") & 'vbNewLine &
        // " ;L = " & PlotArray(Idx).PlotLatDeg.ToString & Chr(176) & PlotArray(Idx).PlotLatMin.ToString & "' " & PlotArray(Idx).PlotLatNS.ToString &
        // " Lo = " & PlotArray(Idx).PlotLongDeg.ToString & Chr(176) & PlotArray(Idx).PlotLongMin.ToString & "' " & PlotArray(Idx).PlotLongEW.ToString & 'vbNewLine &
        // " ;Int and Az = " & PlotArray(Idx).PlotIntercept.ToString & " at " & PlotArray(Idx).PlotAz.ToString & vbNewLine &
        // vbTab & PlotArray(Idx).PlotLLoBy & " Position = " & PlotArray(Idx).PlotSLEP.ToString & vbNewLine)
        // End If
        // Next
        // Exit Sub
        // End Sub
        private void DrawPlots()
        {
            // txtPlots.Clear()
            PlotTimeCount = 0;
            PlotAPTimeCount = 0;
            PlotDRTimeCount = 0;
            EPLineCount = 0;
            EPLineLocY = 575;
            for (int i = 0, loopTo = Information.UBound(PlotArray); i <= loopTo; i++)
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
            PlotAPTimeCount = 0;
            PlotDRTimeCount = 0;
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

            var DRPoint = new PointF(0f, 0f);
            int XlateX = (int)(FactorEW * ((CentralLong - PlotLong) * 60d) * OneNMLongPixels);
            int XlateY = (int)(FactorNS * ((CentralLat - PlotLat) * 60d) * OneNmPixels);
            DRPoint.X = MidX + XlateX;
            DRPoint.Y = MidY + XlateY;
            Grph.DrawArc(myPen, Convert.ToInt32(DRPoint.X - 2f), Convert.ToInt32(DRPoint.Y - 2f), 4, 4, 0, 360);
            if (PlotArray[idx].PlotLLoBy == "GPS")
            {
                Grph.DrawArc(myPen, Convert.ToInt32(DRPoint.X - 6f), Convert.ToInt32(DRPoint.Y - 6f), 12, 12, 0, 360);
            }
            else
            {
                Grph.DrawArc(myPen, Convert.ToInt32(DRPoint.X - 6f), Convert.ToInt32(DRPoint.Y - 6f), 12, 12, 180, 180);
            }

            Grph.DrawLine(myPen, Convert.ToInt32(DRPoint.X - 6f), Convert.ToInt32(DRPoint.Y), Convert.ToInt32(DRPoint.X + 6f), Convert.ToInt32(DRPoint.Y));
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
                        Grph.DrawString(PlotDRTime + " " + PlotArray[idx].PlotLLoBy, ArialFont, Brushes.Blue, DRPoint.X - 6f - 8 * 8, DRPoint.Y - 12f); // HHmm is 4 characters and 1 char = 8 pixels roughly
                    }
                    else
                    {
                        Grph.DrawString(PlotDRTime + " " + PlotArray[idx].PlotLLoBy, ArialFont, Brushes.Blue, DRPoint.X - 6f, DRPoint.Y - 12 * (PlotTimeCount + 1));
                    }
                }
                else if (PlotTimeCount == 0)
                {
                    Grph.DrawString(PlotDRTime + " " + PlotArray[idx].PlotLLoBy, ArialFont, Brushes.Blue, DRPoint.X + 6f, DRPoint.Y - 12f);
                }
                else
                {
                    Grph.DrawString(PlotDRTime + " " + PlotArray[idx].PlotLLoBy, ArialFont, Brushes.Blue, DRPoint.X + 6f, DRPoint.Y - 12 * (PlotTimeCount + 1));
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

            var DRPointEP = new PointF(0f, 0f);
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
            Grph.DrawArc(myPen, Convert.ToInt32(DRPointEP.X - 2f), Convert.ToInt32(DRPointEP.Y - 2f), 4, 4, 0, 360);
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
            if (PlotArray[idx].PlotExtendedLines == true)
            {
                Grph.DrawLine(myPen, new PointF(-(40 * OneNMLongPixels), 0f), new PointF(40 * OneNMLongPixels, 0f));
            }
            else
            {
                Grph.DrawLine(myPen, new PointF(-(20 * OneNMLongPixels), 0f), new PointF(20 * OneNMLongPixels, 0f));
            }

            // End If
            // Grph.DrawRectangle(myPen, -6, -6, 12, 12)
            int Xloc = 20 * OneNMLongPixels;
            var pt = new System.Windows.Point(-Xloc + 30, -14);
            if (PlotArray[idx].PlotLLoBy != "AP")
            {
                Grph.DrawString(PlotDRTime, ArialFont, Brushes.Blue, (float)pt.X, (float)pt.Y);
                pt = new System.Windows.Point(-Xloc + 30, 1d);
                Grph.DrawString(PlotArray[idx].PlotBody, ArialFont, Brushes.Blue, (float)pt.X, (float)pt.Y);
            }

            Grph.ResetTransform();
            if (EPLineCount > 0)
            {
                EPLineLocY += 12;
                EPLineLoc = new System.Windows.Point(EPLineLocX, EPLineLocY);
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

            Inttemp = Inttemp.Substring(0, Inttemp.IndexOf("nm")).Trim();
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

            var DRPoint = new System.Windows.Point(0d, 0d);
            int XlateX = FactorEW * Convert.ToInt32((CentralLong - PlotLong) * 60d * OneNMLongPixels);
            int XlateY = FactorNS * Convert.ToInt32((CentralLat - PlotLat) * 60d * OneNmPixels);
            DRPoint.X = MidX + XlateX;
            DRPoint.Y = MidY + XlateY;
            Grph.TranslateTransform((float)DRPoint.X, (float)DRPoint.Y);
            Grph.DrawArc(myPen, -1, -1, 2, 2, 0, 360);
            Grph.DrawArc(myPen, -2, -2, 4, 4, 0, 360);
            Grph.DrawArc(myPen, -8, -8, 16, 16, 0, 360);
            Grph.ResetTransform();
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

            // the following logic will not print properly IF there are three or more plots and the third or later lat/long match the first lat/long and not the second
            // are we on the second or later plotarray item
            // If idx > 0 Then ' if we are plotting the same lat / long as previous plot then leave plottimecount along to align printing properly
            // If PlotArray(idx - 1).PlotLat <> PlotArray(idx).PlotLat Or PlotArray(idx - 1).PlotLong <> PlotArray(idx).PlotLong Then
            // PlotTimeCount = 0 ' if this lat or long is not the same as the previous time then reset plottimecount to 0 so plot DR time printing is done properly
            // End If
            // End If

            if (Leftside == true)
            {
                // If PlotTimeCount = 0 Then
                Grph.DrawString(PlotDRTime, ArialFont, Brushes.Blue, (float)(DRPoint.X - 6d - PlotDRTime.Length * 8), (float)(DRPoint.Y - 12d)); // HHmm is 4 characters and 1 char = 8 pixels roughly
            }
            // Else
            // Grph.DrawString(PlotDRTime & ",", ArialFont, Brushes.Blue, DRPoint.X - 6 - (PlotDRTime.Length * 8 * (PlotTimeCount + 1)), DRPoint.Y - 12) ' HHmm is 4 characters and 1 char = 8 pixels roughly
            // End If
            else
            {
                // If PlotTimeCount = 0 Then
                Grph.DrawString(PlotDRTime, ArialFont, Brushes.Blue, (float)(DRPoint.X + 6d), (float)(DRPoint.Y - 12d));
                // Else
                // Grph.DrawString("," & PlotDRTime, ArialFont, Brushes.Blue, DRPoint.X + 6 + (PlotDRTime.Length * 8 * PlotTimeCount), DRPoint.Y - 12)
                // end If
            }

            PlotTimeCount += 1;
            if (EPLineCount > 0)
            {
                EPLineLocY += 12;
                EPLineLoc = new System.Windows.Point(EPLineLocX, EPLineLocY);
            }

            Grph.DrawString(PlotArray[idx].PlotSLEP.ToString().Replace("EP", ""), ArialFont, Brushes.Black, EPLineLocX, EPLineLocY);
            EPLineCount += 1;
            return;
        }

        private int LastDR = 0;

        private void PlotDRType(int idx)
        {
            int index = idx;
            if (LastDR == 0)
            {
                LastDR = idx;
                // plot dr lat long as 
            }

            SendMsgBx("PlotType = DR not implemented yet - Contact Support", MessageBoxIcon.Hand);
            return;
        }

        public void UnStringEP(string EPStrIn, int idx)
        {
            int EPLLoc = EPStrIn.IndexOf("EP L ") + 5;
            int EPLDegLoc = EPStrIn.IndexOf('°');
            int EPLMinLoc = EPStrIn.IndexOf("'");
            int EPLoLoc = EPStrIn.IndexOf("EP Lo ") + 6;
            int EPLoDegLoc = EPStrIn.LastIndexOf('°');
            int EPLoMinLoc = EPStrIn.LastIndexOf("'");
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

                Inttemp = Inttemp.Substring(0, Inttemp.IndexOf("nm")).Trim();
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
            PicBoxPlot.ImageLocation = BMFname;
            PicBoxPlot.Refresh();
            bm.Dispose();
            return;
        }

        private void PicBoxPlot_Paint(object sender, PaintEventArgs e)
        {
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

        private void Button1_Click(object sender, EventArgs e)
        {
            Print_Renamed.PrintScreen(PicBoxPlot.Bounds);
            return;
        }

        private void btnPrtSights_Click(object sender, EventArgs e)
        {
            int Idx = 0;
            string TxtMsg = "Plotted Sight Data: ";
            var loopTo = Information.UBound(PlotArray);
            for (Idx = 0; Idx <= loopTo; Idx++)
            {
                if (PlotArray[Idx].PlotType != null)
                {
                    string TmpStr = Constants.vbNewLine + "Type= " + PlotArray[Idx].PlotType + " " + " Sight #" + PlotArray[Idx].PlotNumber.ToString() + " Name = " + PlotArray[Idx].PsnName.ToString() + " Squadron = " + PlotArray[Idx].SquadronName.ToString() + " Body = " + PlotArray[Idx].PlotBody.ToString() + " Date/Time = " + PlotArray[Idx].PlotDT.ToString("MM/dd/yyy HH:mm:ss") + Constants.vbNewLine + " L = " + PlotArray[Idx].PlotLatDeg.ToString() + '°' + PlotArray[Idx].PlotLatMin.ToString() + "' " + PlotArray[Idx].PlotLatNS.ToString() + " Lo = " + PlotArray[Idx].PlotLongDeg.ToString() + '°' + PlotArray[Idx].PlotLongMin.ToString() + "' " + PlotArray[Idx].PlotLongEW.ToString() + " Int and Az = " + PlotArray[Idx].PlotIntercept.ToString() + " at " + PlotArray[Idx].PlotAz.ToString() + " " + PlotArray[Idx].PlotLLoBy + " Est Position = " + PlotArray[Idx].PlotSLEP.ToString() + Constants.vbNewLine;
                    TxtMsg += TmpStr;
                }
            }

            string CaptionStr = "CLS Plot Sight Data";
            var unused = System.Windows.MessageBox.Show(TxtMsg, CaptionStr, (MessageBoxButton)MessageBoxButtons.OK, (MessageBoxImage)MessageBoxIcon.Information);
            // Dim NowTimeStr As String = Now.ToLongTimeString.Replace(":", "").Replace(" ", "").Replace("-", "")
            // Randomize()
            // Dim RandomInt As Single = Rnd()
            // Dim ReportName As String = "./CLSForms/CustomPlotReport" + NowTimeStr + RandomInt.ToString.Replace(".", "") + ".txt"
            // Dim file As System.IO.StreamWriter
            // file = My.Computer.FileSystem.OpenTextFileWriter(ReportName, False)

            // For Idx = 0 To UBound(PlotArray)
            // If PlotArray(Idx).PlotType <> Nothing Then
            // file.WriteLine(("Type= " & PlotArray(Idx).PlotType & " " & " Sight #" & PlotArray(Idx).PlotNumber.ToString & " Name = " & PlotArray(Idx).PsnName.ToString & " Squadron = " & PlotArray(Idx).SquadronName.ToString &
            // " Body = " & PlotArray(Idx).PlotBody.ToString & " Date/Time = " & PlotArray(Idx).PlotDT.ToString("MM/dd/yyy HH:mm:ss") & vbNewLine &
            // " L = " & PlotArray(Idx).PlotLatDeg.ToString & Chr(176) & PlotArray(Idx).PlotLatMin.ToString & "' " & PlotArray(Idx).PlotLatNS.ToString &
            // " Lo = " & PlotArray(Idx).PlotLongDeg.ToString & Chr(176) & PlotArray(Idx).PlotLongMin.ToString & "' " & PlotArray(Idx).PlotLongEW.ToString &
            // " Int and Az = " & PlotArray(Idx).PlotIntercept.ToString & " at " & PlotArray(Idx).PlotAz.ToString & " Est Position = " & PlotArray(Idx).PlotSLEP.ToString & vbNewLine))
            // End If

            // Next
            // file.Close()
            // SendMsgBx("Report of Plotted Sights saved in text file: " & ReportName, MessageBoxIcon.Information)
            return;
        }

        private void cboPlotSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FormCLSLoading == true)
                return;
            // SaveDisplayBMFname()

            SetupandDisplayPlot();
            return;
        }

        private void chkDisplayRose_CheckedChanged(object sender, EventArgs e)
        {
            if (FormCLSLoading == true)
                return;
            SetupandDisplayPlot();
        }

        private void SetupandDisplayPlot()
        {
            Grph.Clear(Color.White);
            FormCLSLoading = false;
            FirstTimeInit();
            if (SetandEditCentralLatLong() == false)
            {
                return;
            }

            SetPlotSideSize();
            // SetPlotInfoFields()
            DrawBasicPlotForm();
            DrawPlots();
            SaveDisplayBMFname();
            Refresh();
            BringToFront();
            Show();
            return;
        }

        private void txtLatActive_TextChanged(object sender, EventArgs e)
        {
            // SaveDisplayBMFname()
            Refresh();
            return;
        }

        private void txtLongActive_TextChanged(object sender, EventArgs e)
        {
            // SaveDisplayBMFname()
            Refresh();
            return;
        }

        private System.Device.Location.GeoCoordinate FindDestLatLong(double LatIn, double LonIn, double Dist, double Course)
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

            var RtnGC = new System.Device.Location.GeoCoordinate(L2, -1 * Lo2);
            return RtnGC;
        }

        private void PicBoxPlot_MouseClick(object sender, MouseEventArgs e)
        {
            int XFactor = PanelPlot.Location.X + PicBoxPlot.Location.X + LeftX - 15; // + PanelPlot.AutoScrollMargin.Width
            int YFactor = PanelPlot.Location.Y + PicBoxPlot.Location.Y + TopY - 20; // + PanelPlot.AutoScrollMargin.Height - 20
            var CLoc1 = new System.Windows.Point(e.X - XFactor, e.Y - YFactor);
            int XFctr = (int)((MidX - CLoc1.X) / 50d * 10d * (OneNMLongPixels / (double)OneNmPixels));
            int YFctr = (int)((MidY - CLoc1.Y) / 50d * 10d); // * OneNmPixels
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

            double TmpLatD = Conversion.Int(Math.Abs(TmpLat));
            double TmpLatM = Math.Round((Math.Abs(TmpLat) - TmpLatD) * 60d, 1);
            string TmpLatNS = "N";
            if (ULLat < 0d)
            {
                TmpLatNS = "S";
            }

            double TmpLongD = Conversion.Int(Math.Abs(TmpLong));
            double TmpLongM = Math.Round((Math.Abs(TmpLong) - TmpLongD) * 60d, 1);
            string TmpLongEW = "W";
            if (ULLong < 0d)
            {
                TmpLongEW = "E";
            }

            txtDispLoc.Text = "Lat=" + TmpLatD.ToString() + '°' + " " + TmpLatM.ToString("00.0") + "'" + TmpLatNS + " Lo=" + TmpLongD.ToString() + '°' + " " + TmpLongM.ToString("00.0") + "'" + TmpLongEW;
            Grph.Clear(Color.White);
            FormCLSLoading = false;
            EPLineCount = 0;
            EPLineLocY = 575;
            FirstTimeInit();
            if (SetandEditCentralLatLong() == false)
            {
                return;
            }

            SetPlotSideSize();
            DrawBasicPlotForm();
            DrawPlots();
            var dpen1 = new Pen(Color.DarkBlue);
            dpen1.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            dpen1.Width = 2f;
            dpen1.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            Grph.DrawLine(dpen1, Convert.ToInt32(CLoc1.X), Convert.ToInt32(CLoc1.Y), RightX, Convert.ToInt32(CLoc1.Y));
            Grph.DrawLine(dpen1, Convert.ToInt32(CLoc1.X), Convert.ToInt32(CLoc1.Y), LeftX, Convert.ToInt32(CLoc1.Y));
            Grph.DrawLine(dpen1, Convert.ToInt32(CLoc1.X), Convert.ToInt32(CLoc1.Y), Convert.ToInt32(CLoc1.X), TopY);
            Grph.DrawLine(dpen1, Convert.ToInt32(CLoc1.X), Convert.ToInt32(CLoc1.Y), Convert.ToInt32(CLoc1.X), BottomY);
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