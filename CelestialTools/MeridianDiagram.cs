using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace CelestialTools
{
    internal partial class FormMeridianDiagram : Form
    {
        public double L = 0d;
        public double Ho = 0d;
        public double ZN = 0d;
        public double LHA = 0d;
        public double Dec = 0d;
        public bool FormSRFFlagMD = false;
        public bool FormAltSRFlagMD = false;
        private double Pi = Math.PI;
        private float ZNoriginal, LHAoriginal;
        private double TwoPi;
        private float X2, X1, XAlt, YAlt, Y1, Y2;
        // Dim M As Double ', B As Double
        // Dim ColorCode As Color
        // Added March 2017 as part of conversion to DotNet - added bitmap to implement new graphics code in meridian diagram routine
        private Bitmap bm;
        private string BMFname = "./Graphics/MeridDiag.jpg";
        private Graphics meridgraphic;
        private int DrawWidth;
        private bool FormMeridianDiagramLoaded = false;
        public bool DrawBasicEqTDiagram = false;
        public Point PtAInt = new Point();
        public Point PtBInt = new Point();
        public Point PtCInt = new Point();
        public Point PtDInt = new Point();
        public Point PtIntercept = new Point();
        public Point PNpt = new Point();
        public Point PSpt = new Point();
        public Point CtrPt = new Point();
        public string BodyName = "";
        public bool InitialLoad = true;

        private void MeridianPicBx_Paint(object sender, PaintEventArgs e)
        {
            // If Not FormMeridianDiagramLoaded Then Exit Sub
            // MeridianPicBx.Load(BMFname)
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CommonTranslate()
        {
            meridgraphic.ResetTransform();
            CtrPt.X = (int)(MeridianPicBx.Location.X + MeridianPicBx.Width / 2d - 10d);
            CtrPt.Y = (int)(MeridianPicBx.Location.Y + MeridianPicBx.Height / 2d - 35d);
            meridgraphic.TranslateTransform(CtrPt.X, CtrPt.Y);
            return;
        }

        public void DisplayMerDiag()
        {
            double Y2Dec;
            double X2Dec;
            double Y1Dec;
            double X1Dec;
            // Dim Ho As Double
            float i; // , XAlt As Single, YAlt As Single
            ZNoriginal = (float)ZN;
            LHAoriginal = (float)LHA;
            int drawdelta = 35;
            DrawWidth = (int)(MeridianPicBx.Width / 2d - drawdelta);
            bm = new Bitmap(MeridianPicBx.Width, MeridianPicBx.Height);
            meridgraphic = Graphics.FromImage(bm);
            meridgraphic.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            meridgraphic.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            meridgraphic.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            string LatStr = "";
            string Decstr = "";
            string LHAstr = "";
            double tmpLDeg = 0d;
            double tmpLMin = 0d;
            double tmpDec = 0d;
            double tmpLHADeg = 0d;
            double tmpLHAMin = 0d;
            if (DrawBasicEqTDiagram == false)
            {
                double tempLat = 0d;
                if (L < 0d)
                {
                    tempLat = -L;
                }
                // tmpLDeg = -Int(L)
                // tmpLMin = (-L - tmpLDeg) * 60
                else
                {
                    tempLat = L;
                    // tmpLDeg = Int(L)
                    // tmpLMin = (L - tmpLDeg) * 60
                }

                tmpLDeg = Conversion.Int(tempLat);
                tmpLMin = (tempLat - tmpLDeg) * 60d;
                tmpLHADeg = Convert.ToDouble(Conversion.Int(LHAoriginal));
                tmpLHAMin = (LHAoriginal - tmpLHADeg) * 60d;
                LHAstr = tmpLHADeg.ToString("##0") + '°' + " " + tmpLHAMin.ToString("#0.0") + "'";
                LatStr = tmpLDeg.ToString("##0") + '°';
                if (L < 0d)
                {
                    LatStr += tmpLMin.ToString("#0.0") + "'" + CommonGlobals.g_LatS;
                }
                else
                {
                    LatStr += tmpLMin.ToString("#0.0") + "'" + CommonGlobals.g_LatN;
                }

                if (Dec < 0d)
                {
                    tmpDec = -Dec;
                }
                else
                {
                    tmpDec = Dec;
                }

                double DecDeg = Conversion.Int(tmpDec);
                double DecMin = (tmpDec - DecDeg) * 60d;
                Decstr = DecDeg.ToString("#0") + '°' + " " + DecMin.ToString("#0.0") + "'";  // tmpDec.ToString("#0.0") & Chr(176)
                if (Dec < 0d)
                {
                    Decstr += CommonGlobals.g_LatS;
                }
                else
                {
                    Decstr += CommonGlobals.g_LatN;
                }

                int HoDeg = (int)Conversion.Int(Ho);
                double HoMin = (Ho - HoDeg) * 60d;
                string HoStr = HoDeg.ToString("#0") + '°' + " " + HoMin.ToString("#0.0") + "'";
                if (string.IsNullOrEmpty(BodyName))
                {
                    meridgraphic.DrawString("Lat: " + LatStr + Constants.vbCrLf + "LHA: " + LHAstr + Constants.vbCrLf + "Zn : " + Math.Round(ZNoriginal, 0, MidpointRounding.AwayFromZero).ToString("##0") + '°' + Constants.vbCrLf + "Ho : " + HoStr + Constants.vbCrLf + "Dec: " + Decstr, new Font("Arial", 8f, FontStyle.Bold), Brushes.DarkBlue, 15f, 15f);
                }
                else
                {
                    meridgraphic.DrawString("Body: " + BodyName + Constants.vbCrLf + "Lat: " + LatStr + Constants.vbCrLf + "LHA: " + LHAstr + Constants.vbCrLf + "Zn : " + Math.Round(ZN, 0, MidpointRounding.AwayFromZero).ToString("##0") + '°' + Constants.vbCrLf + "Ho : " + HoStr + Constants.vbCrLf + "Dec: " + Decstr, new Font("Arial", 8f, FontStyle.Bold), Brushes.DarkBlue, 15f, 15f);
                }
            }

            CommonTranslate();
            var DPen = new Pen(Color.Black, 2f);
            DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            var ptA = new Point();
            var ptB = new Point();
            ptA.X = 0;
            ptA.Y = 0;
            ptB.X = 0;
            ptB.Y = 0;

            // Me.Circle(0, 0), 3000

            meridgraphic.DrawEllipse(DPen, -DrawWidth, -DrawWidth, 2 * DrawWidth, 2 * DrawWidth);
            meridgraphic.FillEllipse(Brushes.LightGoldenrodYellow, -DrawWidth, -DrawWidth, 2 * DrawWidth, 2 * DrawWidth);
            // draw the N / S horizon line
            ptA.X = -1 * DrawWidth;
            ptA.Y = 0;
            ptB.X = DrawWidth;
            ptB.Y = 0;
            meridgraphic.DrawLine(DPen, ptA, ptB);
            meridgraphic.DrawString(CommonGlobals.g_LatN, new Font("Arial", 10f, FontStyle.Bold), Brushes.DarkBlue, -1 * DrawWidth - 20, -6);
            meridgraphic.DrawString(CommonGlobals.g_LatS, new Font("Arial", 10f, FontStyle.Bold), Brushes.DarkBlue, DrawWidth + 20, 6f);
            meridgraphic.DrawString("Visible Horizon", new Font("Arial", 8f, FontStyle.Bold), Brushes.DarkBlue, 20f, -12);
            // draw the Zenith / Nadir line
            ptA.X = 0;
            ptA.Y = -1 * DrawWidth;
            ptB.X = 0;
            ptB.Y = DrawWidth;
            meridgraphic.DrawLine(DPen, ptA, ptB);
            meridgraphic.DrawString("Z at Lat=" + LatStr, new Font("Arial", 10f, FontStyle.Bold), Brushes.DarkBlue, -10, -DrawWidth - 20);
            meridgraphic.DrawString("Na at Lat=" + LatStr, new Font("Arial", 10f, FontStyle.Bold), Brushes.DarkBlue, -3, DrawWidth + 15);

            // draw the 5 degree and 10 degree tick marks on the surrounding circle
            var DPenC = new Pen(Color.Black, 1f);
            for (i = 0f; i <= 359f; i++)
            {
                if (i % 10f == 0f)
                {
                    ptA.X = DrawWidth + 3;  // * System.Math.Cos(i * Pi / 180)
                                            // ptA.Y = DrawWidth * System.Math.Sin(i * Pi / 180)
                    ptB.X = DrawWidth - 10;   // * System.Math.Cos(i * Pi / 180)
                }
                // ptB.Y = (DrawWidth - 10) * System.Math.Sin(i * Pi / 180)
                else if (i % 5f == 0f)
                {
                    ptA.X = DrawWidth;  // * System.Math.Cos(i * Pi / 180)
                                        // ptA.Y = DrawWidth * System.Math.Sin(i * Pi / 180)
                    ptB.X = DrawWidth - 5;  // * System.Math.Cos(i * Pi / 180)
                }
                // ptB.Y = (DrawWidth - 5) * System.Math.Sin(i * Pi / 180)
                else
                {
                    ptA.X = DrawWidth;  // * System.Math.Cos(i * Pi / 180)
                                        // ptA.Y = DrawWidth * System.Math.Sin(i * Pi / 180)
                    ptB.X = DrawWidth - 3;
                    // ptB.Y = (DrawWidth - 3) * System.Math.Sin(i * Pi / 180)
                } // * System.Math.Cos(i * Pi / 180)

                meridgraphic.DrawLine(DPenC, ptA.X, 0, ptB.X, 0);
                meridgraphic.RotateTransform(1f);
            }

            if (DrawBasicEqTDiagram == true)
            {
                DrawBasicEqTDiagram = false;
                goto ExitDrawTime;
            }

            CommonTranslate();
            meridgraphic.RotateTransform((float)L);
            // Draw the celestial equator line Q / Q' based on the Latitude L. Write the strings Q & Q' at each end
            DPen.Color = Color.Blue;
            meridgraphic.DrawLine(DPen, DrawWidth, 0, -DrawWidth, 0);
            meridgraphic.DrawString("Q ", new Font("Arial", 8f, FontStyle.Bold), Brushes.DarkBlue, 0f, -DrawWidth - 12);
            meridgraphic.DrawString("Q'", new Font("Arial", 8f, FontStyle.Bold), Brushes.DarkBlue, 0f, DrawWidth + 12);
            meridgraphic.RotateTransform(-90);
            meridgraphic.DrawString("Celestial Equator", new Font("Arial", 8f, FontStyle.Bold), Brushes.DarkBlue, 20f, -12);
            CommonTranslate();
            meridgraphic.RotateTransform((float)L);
            DPen.Color = Color.Black;
            DPen.Color = Color.Blue;
            meridgraphic.DrawLine(DPen, 0, -DrawWidth, 0, DrawWidth);
            // Draw the Pole North (Pn) and Pole South (Ps) line and ending strings - based on Latitude L 
            if (Math.Sign(L) == 1 | Math.Sign(L) == 0)
            {
                meridgraphic.DrawString("Pn", new Font("Arial", 8f, FontStyle.Bold), Brushes.DarkBlue, -DrawWidth - 15, 0f);
                meridgraphic.DrawString("Ps", new Font("Arial", 8f, FontStyle.Bold), Brushes.DarkBlue, DrawWidth + 15, 0f);
                DPen.Color = Color.Black;
            }

            // South Pole
            if (Math.Sign(L) == -1)
            {
                meridgraphic.DrawString("Pn", new Font("Arial", 8f, FontStyle.Bold), Brushes.DarkBlue, DrawWidth + 15, 0f);
                meridgraphic.DrawString("Ps", new Font("Arial", 8f, FontStyle.Bold), Brushes.DarkBlue, -DrawWidth - 15, 0f);
                DPen.Color = Color.Black;
            }
            // meridgraphic.ResetTransform()
            CommonTranslate();
            DPen.Color = Color.DarkRed;
            meridgraphic.RotateTransform(90f);
            XAlt = (float)(DrawWidth * Math.Cos(-Ho * Pi / 180d));
            YAlt = (float)(DrawWidth * Math.Sin(-Ho * Pi / 180d));
            CommonTranslate();
            ptA.X = (int)XAlt;
            ptA.Y = (int)YAlt;
            PtAInt = ptA;
            ptB.X = (int)-XAlt;
            ptB.Y = (int)YAlt;
            PtBInt = ptB;
            meridgraphic.DrawLine(DPen, ptA, ptB);
            meridgraphic.DrawString("Ho=" + Ho.ToString("#0.0") + '°' + " above horizon", new Font("Arial", 8f, FontStyle.Bold), Brushes.DarkRed, ptB.X + 25, ptB.Y - 12);
            DPen.Color = Color.Green;
            // Draw the declination line based on Latitude L, Declination dec.
            X1Dec = DrawWidth * Math.Cos(-(90d - L + Dec) * Pi / 180d);
            Y1Dec = DrawWidth * Math.Sin(-(90d - L + Dec) * Pi / 180d);
            ptA.X = (int)X1Dec;
            ptA.Y = (int)Y1Dec;
            PtCInt = ptA;
            X2Dec = -DrawWidth * Math.Cos(-(90d - L - Dec) * Pi / 180d);
            Y2Dec = -DrawWidth * Math.Sin(-(90d - L - Dec) * Pi / 180d);
            ptB.X = (int)X2Dec;
            ptB.Y = (int)Y2Dec;
            PtDInt = ptB;
            meridgraphic.RotateTransform((float)-(90d - L));
            X1Dec = DrawWidth * Math.Cos(-Dec * Pi / 180d);
            Y1Dec = DrawWidth * Math.Sin(-Dec * Pi / 180d);
            ptA.X = (int)X1Dec;
            ptA.Y = (int)Y1Dec;
            ptB.X = (int)-X1Dec;
            ptB.Y = (int)Y1Dec;
            meridgraphic.DrawLine(DPen, ptA, ptB);
            meridgraphic.DrawString("Dec " + Decstr + " of celestial equator", new Font("Arial", 8f, FontStyle.Bold), Brushes.Green, ptB.X + 25, ptB.Y - 12);
            meridgraphic.RotateTransform((float)(90d - L));
            CommonTranslate();
            PtIntercept = GetIntersection(PtAInt, PtBInt, PtCInt, PtDInt);
            // If PtIntercept.X = 0 And PtIntercept.Y = 0 Then ' this is when the Dec and Ho are parallel lines or have no intersection
            // ErrorMsgBox("Dec and Ho lines are parallel lines. They have no intersection for plotting Point M or LHA and Zn ")
            // GoTo ExitDrawTime
            // End If
            meridgraphic.DrawEllipse(DPen, PtIntercept.X - 5, PtIntercept.Y - 5, 10, 10);
            meridgraphic.FillEllipse(DPen.Brush, PtIntercept.X - 5, PtIntercept.Y - 5, 10, 10);
            meridgraphic.DrawString("M", new Font("Arial", 10f, FontStyle.Bold), DPen.Brush, PtIntercept.X - 20, PtIntercept.Y - 20);
            if (chkDispZnLHA.CheckState == CheckState.Checked)
            {
                Ellipses();
            }

            if (chkTwiLites.CheckState == CheckState.Checked)
            {
                DisPlayTwiLights();
            }

        ExitDrawTime:
            ;
            if (System.IO.File.Exists(BMFname))
            {
                System.IO.File.Delete(BMFname);
            }

            bm.Save(BMFname);
            MeridianPicBx.ImageLocation = BMFname;
            bm.Dispose();
            MeridianPicBx.Refresh();
            return;
        }

        private void cmdPrint_Click(object eventSender, EventArgs eventArgs)
        {
            Print_Renamed.PrintScreen(Bounds);
        }

        private void Form_Initialize_Renamed()
        {
            Pi = Math.PI; // 4 * System.Math.Atan(1.0#)
            TwoPi = 8d * Math.PI; // System.Math.Atan(1)
            return;
        }

        private void FormMeridianDiagram_Load(object eventSender, EventArgs eventArgs)
        {
            Form_Initialize_Renamed();
            DisplayMerDiag();
            MeridianPicBx.Refresh();
            FormMeridianDiagramLoaded = true;
        }

        private void chkTwiLites_CheckedChanged(object sender, EventArgs e)
        {
            if (!FormMeridianDiagramLoaded)
                return;
            DisplayMerDiag();
            return;
        }

        private void chkDispZnLHA_CheckedChanged(object sender, EventArgs e)
        {
            if (!FormMeridianDiagramLoaded)
                return;
            DisplayMerDiag();
            return;
        }

        public void Ellipses()
        {
            int Y3 = 0;
            int X3 = 0;
            int SignY3 = 0;
            int SignX3 = 0;
            int Length = 0;
            int y = 0;
            int x = 0;
            var DPen = new Pen(Color.Black, 2f);
            DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            var ptA = new Point();
            var ptB = new Point();
            ptA.X = 0;
            ptA.Y = 0;
            ptB.X = 0;
            ptB.Y = 0;
            double ZNCalc = 0d;
            if (ZN > 180d)
            {
                ZNCalc = 360d - ZN;
            }
            else
            {
                ZNCalc = ZN;
            }

            var ColorCode = Color.Magenta;
            // construction line
            DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            DPen.Color = Color.DarkMagenta;
            x = (int)(DrawWidth * Math.Cos(-((180d - ZNCalc) * Pi / 180d)));
            y = (int)(DrawWidth * Math.Sin(-((180d - ZNCalc) * Pi / 180d)));

            // draw Zn tangent line and label
            ptA.X = x;
            int SaveX = x;
            ptA.Y = y;
            int SaveY = y;
            ptB.X = x;
            ptB.Y = -y;
            meridgraphic.DrawLine(DPen, ptA, ptB);
            // x = 15 * System.Math.Cos(-((180 - ZNCalc) * Pi / 180))
            // y = 15 * System.Math.Sin(-((180 - ZNCalc) * Pi / 180))
            var ZnFont = new Font("Arial", 10f, FontStyle.Bold);
            if (L < 0d) // is Lat South
            {
                meridgraphic.DrawString("Zn", ZnFont, Brushes.DarkMagenta, ptB.X - 10 - StrWidth("Zn", ZnFont), 0f);
            }
            else
            {
                meridgraphic.DrawString("Zn", ZnFont, Brushes.DarkMagenta, ptA.X + 10, 0f);
            }

            DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            // draw ZN arc 
            DPen.Color = Color.DarkBlue;
            if (x < 0)
            {
                meridgraphic.DrawArc(DPen, SaveX, -DrawWidth, 2 * Math.Abs(SaveX), 2 * DrawWidth, 90, 180);
            }
            else
            {
                meridgraphic.DrawArc(DPen, -SaveX, -DrawWidth, 2 * Math.Abs(SaveX), 2 * DrawWidth, 270, 180);
            }

            // X1, Y1 and X2,Y2 are the two possible ends of the construction line, where it hits meridian circle
            DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            double X1Angle = -(LHAoriginal + 90f - L);
            double X2Angle = -(90f - LHAoriginal - L);
            double LSlope = (X2Angle - X1Angle) / 2d;
            int X3calc = (int)(DrawWidth * Math.Cos(LSlope * Pi / 180d));
            int Y3calc = (int)(DrawWidth * Math.Sin(LSlope * Pi / 180d));
            X3 = PtIntercept.X;
            Y3 = PtIntercept.Y;
            X1 = (float)(DrawWidth * Math.Cos(X1Angle * Pi / 180d));
            Y1 = (float)(DrawWidth * Math.Sin(X1Angle * Pi / 180d));
            X2 = (float)(DrawWidth * Math.Cos(X2Angle * Pi / 180d));
            Y2 = (float)(DrawWidth * Math.Sin(X2Angle * Pi / 180d));
            DPen.Color = Color.Crimson;
            DPen.Brush = Brushes.Crimson;
            meridgraphic.DrawEllipse(DPen, X3 - 5, Y3 - 5, 10, 10);
            meridgraphic.FillEllipse(DPen.Brush, X3 - 5, Y3 - 5, 10, 10);
            meridgraphic.DrawString("M", ZnFont, DPen.Brush, X3 - 20, Y3 - 20);

            // DarkGreen is the Pen color for the LHA lines, arcs, and strings
            DPen.Color = Color.DarkGreen;
            // Dim StartAngle As Integer = (-180 + L)
            DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            // draw tangent line to LHA arc
            meridgraphic.DrawLine(DPen, X1, Y1, X2, Y2);

            // get the end points of the Q - Q' line and calculate the intersection with the LHA tangent line - the coordinates value defines the width of LHA arc
            // because of graphics rotation and translation used to prepare plot, the calc below for the Q-Q' line are required
            var tmpPT1 = new Point((int)(DrawWidth * Math.Cos((90d - L) * (Pi / 180d))), (int)(-DrawWidth * Math.Sin((90d - L) * (Pi / 180d))));
            var tmpPT2 = new Point((int)(-DrawWidth * Math.Cos((90d - L) * (Pi / 180d))), (int)(DrawWidth * Math.Sin((90d - L) * (Pi / 180d))));
            // get the intersection of the tangent line and the Q-Q' line
            var tmpInt = GetIntersection(new Point((int)X1, (int)Y1), new Point((int)X2, (int)Y2), tmpPT1, tmpPT2);
            if (tmpInt.X == 0 & tmpInt.Y == 0)
            {
                // this error message editted out due to erratic error messages while plots were good
                // ErrorMsgBox("LHA and Q-Q' have no intersection and cannot be plotted - check data")
                return;
            }

            DPen.Color = Color.DarkGreen;
            Length = (int)Math.Sqrt(Math.Pow(tmpInt.X, 2d) + Math.Pow(tmpInt.Y, 2d));
            var LHAFont = new Font("Arial", 8f, FontStyle.Bold);
            if (L < 0d)
            {
                meridgraphic.DrawString("LHA", LHAFont, Brushes.DarkGreen, tmpInt.X - 10 - StrWidth("LHA", LHAFont), tmpInt.Y);
            }
            else
            {
                meridgraphic.DrawString("LHA", LHAFont, Brushes.DarkGreen, tmpInt.X + 10, tmpInt.Y);
            }

            var PnRect = new Rectangle(new Point(-Length, -DrawWidth), new Size(2 * Math.Abs(Length), 2 * DrawWidth));
            // new reset to standard graphics translate and rotate setting and then rotate drawwing for LHA arc
            CommonTranslate();
            meridgraphic.RotateTransform((float)-(90d - L));
            if (L >= 0d) // if lat is N 
            {
                if (tmpInt.X < 0)
                {
                    meridgraphic.DrawArc(DPen, PnRect, 90f, 180f);
                }
                else
                {
                    meridgraphic.DrawArc(DPen, PnRect, -90, 180f);
                }
            }
            else if (tmpInt.X < 0) // else if Lat is S
            {
                meridgraphic.DrawArc(DPen, PnRect, -90, 180f);
            }
            else
            {
                meridgraphic.DrawArc(DPen, PnRect, +90, 180f);
            }

            DPen.Dispose();
            ZnFont.Dispose();
            CommonTranslate();
            return;
        }
        // Private Sub Circles()
        // Dim sign As Integer = 1
        // Dim M2h As Double = 0
        // Dim M1h As Double = 0
        // Dim Dec As Double = 0
        // Dim Y3 As Double = 0
        // Dim X3 As Double = 0
        // Dim y2h As Double = 0
        // Dim x2h As Double = 0
        // Dim y1h As Double = 0
        // Dim x1h As Double = 0
        // Dim Theta As Double = 0
        // Dim Z As Double = 0
        // Dim EndPoint As Single = 0
        // Dim m2V As Double = 0
        // Dim m1V As Double = 0
        // Dim DPen As Pen = New Pen(Color.Black, 2)
        // DPen.DashStyle = Drawing2D.DashStyle.Solid
        // Dim ptA As Point = New Point
        // Dim ptB As Point = New Point
        // ptA.X = 0
        // ptA.Y = 0
        // ptB.X = 0
        // ptB.Y = 0
        // 'Body is at XBody, YAlt
        // 'vertical circle
        // If XBody = 0 Then
        // XBody = 1.0E-21
        // End If
        // m1V = (YAlt - DrawWidth) / (XBody - 0)
        // m2V = (-(DrawWidth) - YAlt) / (0 - XBody)
        // oxV = (m1V * m2V * (-DrawWidth - DrawWidth) + m1V * (XBody + 0) - m2V * (0 + XBody)) / (2 * (m1V - m2V))
        // oyV = 0
        // radiusV = System.Math.Sqrt((XBody - oxV) * (XBody - oxV) + (YAlt - 0) * (YAlt - 0))
        // If oxV >= 0 Then
        // StartPoint = Pi - System.Math.Atan(DrawWidth / System.Math.Abs(oxV))
        // Else
        // StartPoint = 2 * Pi - System.Math.Atan(DrawWidth / System.Math.Abs(oxV))
        // End If
        // If oxV >= 0 Then
        // EndPoint = Pi + System.Math.Atan(DrawWidth / System.Math.Abs(oxV))
        // Else
        // EndPoint = System.Math.Atan(DrawWidth / System.Math.Abs(oxV))
        // End If
        // If System.Math.Abs(oxV) < 0.0001 And (ZNoriginal < 90 Or ZNoriginal > 270) Then
        // DPen.DashStyle = Drawing2D.DashStyle.Solid
        // DPen.Color = Color.DarkMagenta
        // meridgraphic.DrawArc(DPen, 0, 0, DrawWidth, DrawWidth, Pi / 2, 3 * Pi / 2)
        // End If
        // If System.Math.Abs(oxV) < 0.0001 And (ZNoriginal < 90 And ZNoriginal > 270) Then
        // DPen.DashStyle = Drawing2D.DashStyle.Dash
        // DPen.Color = Color.Magenta
        // meridgraphic.DrawArc(DPen, 0, 0, DrawWidth, DrawWidth, 3 * Pi / 2, Pi / 2)
        // End If
        // DPen.DashStyle = Drawing2D.DashStyle.Solid

        // If ZNoriginal < 180 Then
        // DPen.DashStyle = Drawing2D.DashStyle.Dash
        // End If
        // If ZNoriginal = 90 Then
        // DPen.DashStyle = Drawing2D.DashStyle.Dash
        // DPen.Color = Color.Magenta
        // ptA.X = 0
        // ptA.Y = DrawWidth
        // ptB.X = 0
        // ptB.Y = -DrawWidth
        // meridgraphic.DrawLine(DPen, ptA, ptB)
        // End If
        // If ZNoriginal = 270 Then
        // DPen.DashStyle = Drawing2D.DashStyle.Solid
        // DPen.Color = Color.Magenta
        // ptA.X = 0
        // ptA.Y = DrawWidth
        // ptB.X = 0
        // ptB.Y = -DrawWidth
        // meridgraphic.DrawLine(DPen, ptA, ptB)
        // End If
        // DPen.DashStyle = Drawing2D.DashStyle.Solid
        // If ZNoriginal <> 90 And ZNoriginal <> 270 And System.Math.Abs(oxV) >= 0.0001 And radiusV < 10000000000.0# Then
        // DPen.Color = Color.Magenta
        // meridgraphic.DrawArc(DPen, oxV, Convert.ToInt32(oxH), radiusV, radiusH, StartPoint, EndPoint)
        // 'Me.Circle(oxV, oyV), radiusV, System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Magenta), StartPoint, EndPoint 'And Abs(oxV) >= 0.0001
        // End If

        // 'construction line
        // 'point where vertical circle intersects horizon is (oxV+radiusV,0), but can be on either side of y axis
        // X1 = radiusV - System.Math.Abs(oxV)
        // 'point where construction line intersects meridian circle is (oxV + radiusV,3000*sin(arccos((oxV + radiusV)/3000)
        // Z = X1 / DrawWidth
        // If Z = 1 Then Z = -0.99999999999999
        // Theta = System.Math.Atan(-Z / System.Math.Sqrt(-Z * Z + 1)) + Pi / 2 'arccos
        // Y2 = (DrawWidth * System.Math.Sin(Theta))
        // If ZNoriginal >= 180 Then Y2 = -Y2
        // If oxV >= 0 Then X1 = -X1
        // DPen.DashStyle = Drawing2D.DashStyle.Dot
        // DPen.Color = Color.Magenta
        // ptA.X = X1
        // ptA.Y = 0
        // ptB.X = X1
        // ptB.Y = Y2
        // meridgraphic.DrawLine(DPen, ptA, ptB)
        // 'hour circle
        // 'End points for hour circle are X1H=-3000*cos(L*Pi/180),Y1H=3000*sin(L*Pi/180),X2H=3000*cos(L*Pi/180),Y2H=-3000*sin(L*Pi/180) referred to original circle
        // x1h = -DrawWidth * System.Math.Cos(L * Pi / 180)
        // y1h = DrawWidth * System.Math.Sin(L * Pi / 180)
        // x2h = DrawWidth * System.Math.Cos(L * Pi / 180)
        // y2h = -DrawWidth * System.Math.Sin(L * Pi / 180)
        // If 90 - System.Math.Abs(Dec) <= 0.0006 Then
        // XBody = X3
        // YAlt = Y3
        // End If
        // M1h = (YAlt - y1h) / (XBody - x1h) ': If Abs(YAlt - y1h) < 0.01 Then M1h = 0
        // M2h = (y2h - YAlt) / (x2h - XBody) ': If Abs(y2h - YAlt) < 0.01 Then M2h = 0
        // If M1h = M2h Then Exit Sub
        // oxH = (M1h * M2h * (y2h - y1h) + M1h * (XBody + x2h) - M2h * (x1h + XBody)) / (2 * (M1h - M2h))
        // If oxH > 214716800.0# Then oxH = 214716800.0# 'was 2183349376
        // If oxH < -2183356799.0# Then oxH = -2183356799.0#
        // oyH = ((-1 / M1h) * (oxH - (x1h + XBody) / 2) + (y1h + YAlt) / 2)
        // If oyH > 2199896192.0# Then oyH = 2199896192.0#
        // If oyH < -2199889024.0# Then oyH = -2199889024.0#
        // radiusH = System.Math.Sqrt((XBody - oxH) * (XBody - oxH) + (YAlt - oyH) * (YAlt - oyH))

        // 'NEED FOUR CONDITIONS?
        // If oxH >= 0 And oyH >= 0 Then
        // StartPoint = Pi + System.Math.Atan((y1h - oyH) / (x1h - oxH))
        // EndPoint = System.Math.Atan((y2h - oyH) / (x2h - oxH)) + 2 * Pi
        // sign = -1
        // End If
        // If oxH >= 0 And oyH < 0 Then
        // StartPoint = Pi + System.Math.Atan((y2h - oyH) / (x2h - oxH))
        // EndPoint = Pi + System.Math.Atan((y1h - oyH) / (x1h - oxH))
        // sign = 1
        // End If
        // If oxH < 0 And oyH >= 0 Then
        // StartPoint = Pi + System.Math.Atan((y1h - oyH) / (x1h - oxH))
        // EndPoint = System.Math.Atan((y2h - oyH) / (x2h - oxH)) + 2 * Pi
        // sign = -1
        // End If
        // If oxH < 0 And oyH < 0 Then
        // StartPoint = System.Math.Atan((y2h - oyH) / (x2h - oxH))
        // EndPoint = Pi + System.Math.Atan((y1h - oyH) / (x1h - oxH))
        // sign = 1
        // End If
        // 'x = (y1h - oyH) / radiusH

        // If System.Math.Abs(StartPoint - EndPoint) >= Pi Then EndPoint = EndPoint - Pi
        // If StartPoint < 0 Then StartPoint = StartPoint + 2 * Pi
        // If StartPoint > 2 * Pi Then StartPoint = StartPoint - 2 * Pi
        // If StartPoint > EndPoint And StartPoint < EndPoint + Pi Then StartPoint = StartPoint - Pi
        // If EndPoint < 0 Then EndPoint = EndPoint + 2 * Pi
        // If EndPoint > 2 * Pi Then EndPoint = EndPoint - 2 * Pi

        // If oxH < 0 And oyH >= 0 Then
        // StartPoint = StartPoint + Pi
        // EndPoint = EndPoint + Pi
        // If StartPoint > 2 * Pi Then StartPoint = StartPoint - 2 * Pi
        // If EndPoint > 2 * Pi Then EndPoint = EndPoint - 2 * Pi
        // End If

        // DPen.DashStyle = Drawing2D.DashStyle.Solid

        // If ZNoriginal < 180 Then DPen.DashStyle = Drawing2D.DashStyle.Dash
        // DPen.Color = Color.Magenta
        // meridgraphic.DrawArc(DPen, Convert.ToInt32(oxH), Convert.ToInt32(oyH), radiusV, radiusH, StartPoint, EndPoint)

        // 'construction line
        // 'point where hour circle intersects equator is (X1,Y1)
        // X1 = radiusH * System.Math.Sin(L * Pi / 180) + sign * oxH
        // X1 = sign * X1
        // Y1 = (radiusH * System.Math.Cos(L * Pi / 180) + sign * oyH)
        // Y1 = sign * Y1
        // DPen.DashStyle = Drawing2D.DashStyle.Dot
        // M = -System.Math.Sin(L * Pi / 180) / System.Math.Cos(L * Pi / 180)
        // X2 = X1
        // Do
        // X2 = X2 + SlopeEDir
        // Y2 = Y1 + M * (X2 - X1)
        // 'Debug.Print Abs(9000000 - (X2 * X2 + Y2 * Y2))
        // Loop Until System.Math.Abs(9000000 - (X2 * X2 + Y2 * Y2)) < 15000
        // ptA.X = X1
        // ptA.Y = Y1
        // ptB.X = X2
        // ptB.Y = Y2
        // DPen.Color = Color.DarkBlue
        // meridgraphic.DrawLine(DPen, ptA, ptB)
        // DPen.DashStyle = Drawing2D.DashStyle.Solid
        // Exit Sub
        // End Sub

        private void FormMeridianDiagram_FormClosed(object eventSender, FormClosedEventArgs eventArgs)
        {
            // Cleanup()
        }

        private void optEllipse_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (!FormMeridianDiagramLoaded)
                return;
            DisplayMerDiag();
            return;
        }

        public Point GetIntersection(Point A, Point B, Point C, Point D)
        {
            double dy1 = B.Y - A.Y;
            double dx1 = B.X - A.X;
            double dy2 = D.Y - C.Y;
            double dx2 = D.X - C.X;
            // Dim p As New Point
            // check whether the two line parallel
            if (dy1 * dx2 == dy2 * dx1)
            {
                // ErrorMsgBox("Lines for intersection are parallel - No point of intersection to plot")
                // Return P with a specific data
                var pbad = new Point(0, 0);
                return pbad;
            }
            else
            {
                double x = ((C.Y - A.Y) * dx1 * dx2 + dy1 * dx2 * A.X - dy2 * dx1 * C.X) / (dy1 * dx2 - dy2 * dx1);
                double y = A.Y + dy1 / dx1 * (x - A.X);
                var p = new Point((int)x, (int)y);
                return p;
            }
        }

        private void ErrorMsgBox(string ErrMsg)
        {
            MessageBox.Show(ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            return;
        }

        private void DisPlayTwiLights()
        {
            var DPen = new Pen(Color.Black, 2f) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dot };
            var FontArial8Bold = new Font("Arial", 8f, FontStyle.Bold);
            // DPen.DashStyle = Drawing2D.DashStyle.Dot
            double CivilTwi = 6d * Pi / 180d;
            double NauticalTwi = 12d * Pi / 180d;
            double AstroTwi = 18d * Pi / 180d;
            int x1 = (int)(DrawWidth * Math.Cos(CivilTwi));
            int y1 = (int)(DrawWidth * Math.Sin(CivilTwi));
            int x2 = -x1;
            int y2 = y1;
            meridgraphic.DrawLine(DPen, x1, y1, x2, y2);
            meridgraphic.DrawString("6" + '°' + " Civil Twilight", FontArial8Bold, Brushes.Black, x2 + 20, y2 - 11);
            x1 = (int)(DrawWidth * Math.Cos(NauticalTwi));
            y1 = (int)(DrawWidth * Math.Sin(NauticalTwi));
            x2 = -x1;
            y2 = y1;
            meridgraphic.DrawLine(DPen, x1, y1, x2, y2);
            meridgraphic.DrawString("12" + '°' + " Nautical Twilight", FontArial8Bold, Brushes.Black, x2 + 20, y2 - 11);
            x1 = (int)(DrawWidth * Math.Cos(AstroTwi));
            y1 = (int)(DrawWidth * Math.Sin(AstroTwi));
            x2 = -x1;
            y2 = y1;
            meridgraphic.DrawLine(DPen, x1, y1, x2, y2);
            meridgraphic.DrawString("18" + '°' + " Astronomical Twilight", FontArial8Bold, Brushes.Black, x2 + 20, y2 - 11);
            DPen.Dispose();
            FontArial8Bold.Dispose();
            return;
        }

        private int StrWidth(string StrIn, Font FontIn)
        {
            string measureString = StrIn;
            var stringSize = new SizeF();
            var E = new PaintEventArgs(meridgraphic, Rectangle.Round(meridgraphic.ClipBounds));
            stringSize = E.Graphics.MeasureString(measureString, FontIn);
            return Convert.ToInt32(stringSize.Width);
            return default;
        }
    }
}