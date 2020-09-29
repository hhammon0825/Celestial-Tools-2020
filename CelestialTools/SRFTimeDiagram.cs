using System;
using System.Drawing;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    public partial class SRFTimeDiagram
    {
        public SRFTimeDiagram()
        {
            InitializeComponent();
            _ExitBtn.Name = "ExitBtn";
            _cmdPrint.Name = "cmdPrint";
            _chkDispEqt.Name = "chkDispEqt";
        }

        private Bitmap bm;
        private string BMFname = "./Graphics/TimeDiagram.jpg";
        private Graphics TDgraphics;
        private bool DrawBasicTimeDiagram = false;

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
            return;
        }

        private void SRFTimeDiagram_Load(object sender, EventArgs e)
        {
            // DrawEqTDiagram = False
            if (My.MyProject.Forms.FormSRF.BNType == "Sun")
            {
                chkDispEqt.Visible = true;
            }
            else
            {
                chkDispEqt.Visible = false;
            }

            DisplayTimeDiagram();
            return;
        }

        public void DisplayTimeDiagram()
        {
            float XTD1, YTD1;
            float XTD2;
            float TwoPi, i;
            // FormSRF.Font.Name = "MS Sans Serif"
            TwoPi = (float)(8d * Math.Atan(1d));
            EqtPicBx.Enabled = true;
            EqtPicBx.Visible = true;

            // set up fresh / new bitmap and graphics drawwing object for diagram and later additions
            // The EqtPicBx width and height MUST be exactly equal in pixel size for all the graphics drawwing to work properly
            int DrawWidth = (int)(EqtPicBx.Width / 2d - 40d);
            int CircleRadii = (int)(EqtPicBx.Width / 2d - 35d);
            bm = new Bitmap(EqtPicBx.Width, EqtPicBx.Height);
            TDgraphics = Graphics.FromImage(bm);
            TDgraphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            TDgraphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            TDgraphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            TDgraphics.TranslateTransform((float)(EqtPicBx.Width / 2d), (float)(EqtPicBx.Height / 2d));
            var DPen = new Pen(Color.Black, 1f);
            var DPen2 = new Pen(Color.Blue, 2f);
            DPen2.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            DPen2.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            TDgraphics.DrawString("SRF Time Diagram Expanded", new Font("Arial", 14f, FontStyle.Bold), Brushes.Blue, (float)(-EqtPicBx.Width / 2d), (float)(-EqtPicBx.Height / 2d));

            // draw the basic circle for the time diagram
            TDgraphics.DrawEllipse(DPen, -CircleRadii, -CircleRadii, 2 * CircleRadii, 2 * CircleRadii);
            TDgraphics.FillEllipse(Brushes.LightGoldenrodYellow, -CircleRadii, -CircleRadii, 2 * CircleRadii, 2 * CircleRadii);
            // draww the small ticks on main circle for every 20 minutes or every 5 degrees of arc
            for (i = 0f; i <= 360f; i += 1f)
            {
                XTD1 = DrawWidth + 2; // * System.Math.Cos(i)
                XTD2 = DrawWidth + 5; // * System.Math.Cos(i)
                TDgraphics.DrawLine(DPen, XTD1, 0f, XTD2, 0f);
                TDgraphics.RotateTransform(1f);
            }

            TDgraphics.ResetTransform();
            TDgraphics.TranslateTransform((float)(EqtPicBx.Width / 2d), (float)(EqtPicBx.Height / 2d));
            var loopTo = TwoPi;
            for (i = 0f; TwoPi / 72f >= 0 ? i <= loopTo : i >= loopTo; i += TwoPi / 72f)
            {
                XTD1 = DrawWidth - 1; // * System.Math.Cos(i)
                XTD2 = DrawWidth + 5; // * System.Math.Cos(i)
                TDgraphics.DrawLine(DPen, XTD1, 0f, XTD2, 0f);
                TDgraphics.RotateTransform((float)(TwoPi / 72f * (180d / Math.PI)));
            }

            TDgraphics.ResetTransform();
            TDgraphics.TranslateTransform((float)(EqtPicBx.Width / 2d), (float)(EqtPicBx.Height / 2d));
            // draw the major ticks on the main circle for every hour or 15 degrees of arc
            var loopTo1 = TwoPi;
            for (i = 0f; TwoPi / 24f >= 0 ? i <= loopTo1 : i >= loopTo1; i += TwoPi / 24f)
            {
                XTD1 = DrawWidth - 5;   // * System.Math.Cos(i) '600
                XTD2 = DrawWidth + 10;   // * System.Math.Cos(i)
                TDgraphics.DrawLine(DPen, XTD1, 0f, XTD2, 0f);
                TDgraphics.RotateTransform((float)(TwoPi / 24f * (180d / Math.PI)));
                // TDgraphics.DrawLine(DPen, XTD1, YTD1, XTD2, YTD2)
            }

            TDgraphics.ResetTransform();
            TDgraphics.TranslateTransform((float)(EqtPicBx.Width / 2d), (float)(EqtPicBx.Height / 2d));

            // if only drawwing basic time circle for initial load then stop here and exit - set true in form load 
            if (DrawBasicTimeDiagram == true)
            {
                DrawBasicTimeDiagram = false;
                goto ExitDrawTime;
            }

            // recap info from SRF form in upper left corner
            TDgraphics.DrawString("Body: " + My.MyProject.Forms.FormSRF.BNBodyName + Constants.vbCrLf + " Lat: " + CnvtDbltoDegMin(Math.Abs(My.MyProject.Forms.FormSRF.Lat)).ToString() + My.MyProject.Forms.FormSRF.cboL.Text + Constants.vbCrLf + " Lo : " + CnvtDbltoDegMin(Math.Abs(My.MyProject.Forms.FormSRF.Lo)).ToString() + My.MyProject.Forms.FormSRF.cboLo.Text + Constants.vbCrLf + " ZT : " + My.MyProject.Forms.FormSRF.ZTHours.ToString("00") + ":" + My.MyProject.Forms.FormSRF.ZTMinutes.ToString("00") + ":" + My.MyProject.Forms.FormSRF.ZTSeconds.ToString("00") + Constants.vbCrLf + " LHA: " + CnvtDbltoDegMin(My.MyProject.Forms.FormSRF.LHAOriginal) + Constants.vbCrLf, new Font("Arial", 8f, FontStyle.Bold), Brushes.Blue, (float)(-EqtPicBx.Width / 2d), (float)(-EqtPicBx.Height / 2d + 25d));
            TDgraphics.DrawString("Major Arc Ticks = 1 hour of time or 15" + '°' + " of arc" + Constants.vbCrLf + "Minor Ticks = 20 minutes of time or 5" + '°' + " of arc" + Constants.vbCrLf + "Smallest Ticks = 4 minutes of time or 1" + '°' + " of arc", new Font("Arial", 8f, FontStyle.Regular), Brushes.Blue, (float)(-EqtPicBx.Width / 2d), (float)(EqtPicBx.Height / 2d - 35d));

            // draw meridian line to the top
            TDgraphics.DrawLine(DPen2, 0, 0, 0, -CircleRadii);
            // Label the Main meridian line with cap M and 12H (noon) text - add longitude for this sight on the Main Meridian Line
            TDgraphics.DrawString("M", new Font("Arial", 10f, FontStyle.Bold), Brushes.Blue, -5, -(CircleRadii + 20));
            TDgraphics.RotateTransform(-90);
            TDgraphics.DrawString("Lo=" + CnvtDbltoDegMin(My.MyProject.Forms.FormSRF.Lo).ToString() + My.MyProject.Forms.FormSRF.cboLo.Text, new Font("Arial", 8f, FontStyle.Bold), Brushes.Blue, (float)(CircleRadii / 2d), -15);
            TDgraphics.ResetTransform();
            TDgraphics.TranslateTransform((float)(EqtPicBx.Width / 2d), (float)(EqtPicBx.Height / 2d));

            // draw lower meridian line for 0/24 Hr (local midnight) and label accordingly
            DPen2.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            DPen2.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            TDgraphics.DrawLine(DPen2, 0, 0, 0, CircleRadii);
            TDgraphics.DrawString("m", new Font("Arial", 10f, FontStyle.Bold), Brushes.Red, -5, CircleRadii + 15);

            // draw an arc from the lower meridian line for 45 degrees to the right and label to show that time and arc degrees increase thru rotation to the right
            var ArcPen = new Pen(Color.Blue, 3f);
            ArcPen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            var Rect = new Rectangle(-CircleRadii - 10, -CircleRadii - 10, 2 * CircleRadii + 20, 2 * CircleRadii + 20);
            TDgraphics.DrawArc(ArcPen, Rect, 90f, -45);
            XTD1 = (float)((CircleRadii + 15) * Math.Cos(45 * Math.PI / 180d));
            YTD1 = (float)((CircleRadii + 15) * Math.Sin(45 * Math.PI / 180d));
            var PtText1 = new Point((int)XTD1, (int)YTD1);
            TDgraphics.DrawString("Time & Angles" + Constants.vbCrLf + "Increase In" + Constants.vbCrLf + "This Direction", new Font("Arial", 8f, FontStyle.Regular), Brushes.Blue, PtText1);

            // otherwise continue on drawwing rest of time diagram for sight reduction data entered
            // Greenwich lower branch - rotate drawing according to whether the lower greenwich meridian is in positive or negative x location and label
            XTD1 = (float)(CircleRadii * Math.Cos((90d + My.MyProject.Forms.FormSRF.Lo) * Math.PI / 180d));
            YTD1 = (float)(CircleRadii * Math.Sin((90d + My.MyProject.Forms.FormSRF.Lo) * Math.PI / 180d));
            if (XTD1 < 0f)
            {
                TDgraphics.RotateTransform((float)(180 + 90 + My.MyProject.Forms.FormSRF.Lo));
                DPen2.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                TDgraphics.DrawLine(DPen2, 0, 0, -CircleRadii, 0);
                TDgraphics.DrawString("g", new Font("Arial", 12f, FontStyle.Bold), Brushes.Red, -(CircleRadii + 20), 0f);
                TDgraphics.ResetTransform();
                TDgraphics.TranslateTransform((float)(EqtPicBx.Width / 2d), (float)(EqtPicBx.Height / 2d));
            }
            else
            {
                TDgraphics.RotateTransform((float)(+90 + My.MyProject.Forms.FormSRF.Lo));
                DPen2.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                TDgraphics.DrawLine(DPen2, 0, 0, CircleRadii, 0);
                TDgraphics.DrawString("g", new Font("Arial", 12f, FontStyle.Bold), Brushes.Red, CircleRadii + 8, 0f);
                TDgraphics.ResetTransform();
                TDgraphics.TranslateTransform((float)(EqtPicBx.Width / 2d), (float)(EqtPicBx.Height / 2d));
            }

            // Greenwich upper branch - rotate drawing according to whether the Upper Greenwich Meridina is in positive or negative x location and label 
            XTD1 = (float)(CircleRadii * Math.Cos((-90 + My.MyProject.Forms.FormSRF.Lo) * Math.PI / 180d));
            YTD1 = (float)(CircleRadii * Math.Sin((-90 + My.MyProject.Forms.FormSRF.Lo) * Math.PI / 180d));
            if (XTD1 < 0f)
            {
                TDgraphics.RotateTransform((float)(180 - 90 + My.MyProject.Forms.FormSRF.Lo));
                DPen2.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                DPen2.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                TDgraphics.DrawLine(DPen2, 0, 0, -CircleRadii, 0);
                TDgraphics.DrawString("Greenwich Meridian", new Font("Arial", 8f, FontStyle.Bold), Brushes.Blue, (float)(-CircleRadii / 2d), -15);
                TDgraphics.DrawString("G", new Font("Arial", 12f, FontStyle.Bold), Brushes.Blue, -(CircleRadii + 20), -10);
                TDgraphics.ResetTransform();
                TDgraphics.TranslateTransform((float)(EqtPicBx.Width / 2d), (float)(EqtPicBx.Height / 2d));
            }
            else
            {
                TDgraphics.RotateTransform((float)(-90 + My.MyProject.Forms.FormSRF.Lo));
                DPen2.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                DPen2.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                TDgraphics.DrawLine(DPen2, 0, 0, CircleRadii, 0);
                TDgraphics.DrawString("Greenwich Meridian", new Font("Arial", 8f, FontStyle.Bold), Brushes.Blue, (float)(CircleRadii / 2d), -15);
                TDgraphics.DrawString("G", new Font("Arial", 12f, FontStyle.Bold), Brushes.Blue, CircleRadii + 8, -10);
                TDgraphics.ResetTransform();
                TDgraphics.TranslateTransform((float)(EqtPicBx.Width / 2d), (float)(EqtPicBx.Height / 2d));
            }


            // if doing a star sight then put up Aries and GHA of Aries on drawwing 
            if (My.MyProject.Forms.FormSRF.BN <= 57)
            {
                XTD1 = (float)(CircleRadii * Math.Cos((-90 + My.MyProject.Forms.FormSRF.Lo - My.MyProject.Forms.FormSRF.GHAAries) * Math.PI / 180d));
                YTD1 = (float)(CircleRadii * Math.Sin((-90 + My.MyProject.Forms.FormSRF.Lo - My.MyProject.Forms.FormSRF.GHAAries) * Math.PI / 180d));
                if (XTD1 < 0f)
                {
                    TDgraphics.RotateTransform((float)(180 - 90 + My.MyProject.Forms.FormSRF.Lo - My.MyProject.Forms.FormSRF.GHAAries));
                    DPen2.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                    DPen2.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    TDgraphics.DrawLine(DPen2, 0, 0, -CircleRadii, 0);
                    TDgraphics.DrawString(Conversions.ToString(CommonGlobals.Aries_Uchar), new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, -(CircleRadii + 20), -10);
                    TDgraphics.DrawString("GHA Aries: " + CnvtDbltoDegMin(My.MyProject.Forms.FormSRF.GHAAries).ToString(), new Font("Arial", 8f, FontStyle.Bold), Brushes.Blue, (float)(-0.75d * CircleRadii), -15);
                    TDgraphics.ResetTransform();
                    TDgraphics.TranslateTransform((float)(EqtPicBx.Width / 2d), (float)(EqtPicBx.Height / 2d));
                }
                else
                {
                    TDgraphics.RotateTransform((float)(-90 + My.MyProject.Forms.FormSRF.Lo - My.MyProject.Forms.FormSRF.GHAAries));
                    DPen2.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                    DPen2.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    TDgraphics.DrawLine(DPen2, 0, 0, CircleRadii, 0);
                    TDgraphics.DrawString(Conversions.ToString(CommonGlobals.Aries_Uchar), new Font("Arial", 12f, FontStyle.Bold), Brushes.Black, CircleRadii + 8, -10);
                    TDgraphics.DrawString("GHA Aries: " + CnvtDbltoDegMin(My.MyProject.Forms.FormSRF.GHAAries).ToString(), new Font("Arial", 8f, FontStyle.Bold), Brushes.Blue, (float)(CircleRadii / 2d), -15);
                    TDgraphics.ResetTransform();
                    TDgraphics.TranslateTransform((float)(EqtPicBx.Width / 2d), (float)(EqtPicBx.Height / 2d));
                }
            }

            string DString = Constants.vbNullString;

            // Any body other than Sun: Is this a star sight, a planet sight, or a moon sight
            if (My.MyProject.Forms.FormSRF.BNType != "Sun") // 64 Then
            {
                if (My.MyProject.Forms.FormSRF.BNType == "Stars") // <= 57 Then
                {
                    DString = CommonGlobals.Black_Star_Uchar.ToString(); // "*"
                }

                if (My.MyProject.Forms.FormSRF.BNType == "Planets")  // >= 58 And FormSRF.BN <= 61 Then
                {
                    switch (My.MyProject.Forms.FormSRF.BNBodyName ?? "")
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

                if (My.MyProject.Forms.FormSRF.BNType == "Moon")  // = 62 Or FormSRF.BN = 63 Then
                {
                    DString = Conversions.ToString(CommonGlobals.Moon_Uchar);
                }

                XTD1 = (float)(CircleRadii * Math.Cos((-90 - My.MyProject.Forms.FormSRF.LHAOriginal) * Math.PI / 180d));
                YTD1 = (float)(CircleRadii * Math.Sin((-90 - My.MyProject.Forms.FormSRF.LHAOriginal) * Math.PI / 180d));
                // rotate drawing according to whether x location of end of line is positive or negative then draw sight object character and label line with body LHA
                if (XTD1 < 0f)
                {
                    TDgraphics.RotateTransform((float)(180 - 90 - My.MyProject.Forms.FormSRF.LHAOriginal));
                    DPen2.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                    DPen2.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    TDgraphics.DrawLine(DPen2, 0, 0, -CircleRadii, 0);
                    TDgraphics.DrawString(My.MyProject.Forms.FormSRF.BNBodyName.ToString() + " LHA: " + CnvtDbltoDegMin(My.MyProject.Forms.FormSRF.LHAOriginal).ToString(), new Font("Arial", 8f, FontStyle.Bold), Brushes.Blue, -CircleRadii + 20, -15);
                    TDgraphics.DrawString(DString, new Font("Arial", 10f, FontStyle.Bold), Brushes.Black, -(CircleRadii + 20), -10);
                    TDgraphics.ResetTransform();
                    TDgraphics.TranslateTransform((float)(EqtPicBx.Width / 2d), (float)(EqtPicBx.Height / 2d));
                }
                else
                {
                    TDgraphics.RotateTransform((float)(-90 - My.MyProject.Forms.FormSRF.LHAOriginal));
                    DPen2.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                    DPen2.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    TDgraphics.DrawLine(DPen2, 0, 0, CircleRadii, 0);
                    TDgraphics.DrawString(My.MyProject.Forms.FormSRF.BNBodyName.ToString() + " LHA: " + CnvtDbltoDegMin(My.MyProject.Forms.FormSRF.LHAOriginal).ToString(), new Font("Arial", 8f, FontStyle.Bold), Brushes.Blue, (float)(CircleRadii / 2d), -15);
                    TDgraphics.DrawString(DString, new Font("Arial", 10f, FontStyle.Bold), Brushes.Black, CircleRadii + 8, -10);
                    TDgraphics.ResetTransform();
                    TDgraphics.TranslateTransform((float)(EqtPicBx.Width / 2d), (float)(EqtPicBx.Height / 2d));
                }
            }

            My.MyProject.Forms.FormSRF.GetValidBN();
            // Mean Sun for all sights except sun - add mean sun location for all sights but Sun sight
            if (My.MyProject.Forms.FormSRF.BNType != "Sun")
            {
                My.MyProject.Forms.FormSRF.Sun();
                My.MyProject.Forms.FormSRF.HourAngles();
                XTD1 = (float)(CircleRadii * Math.Cos((90d + My.MyProject.Forms.FormSRF.Lo - My.MyProject.Forms.FormSRF.HG * 15d) * Math.PI / 180d));
                YTD1 = (float)(CircleRadii * Math.Sin((90d + My.MyProject.Forms.FormSRF.Lo - My.MyProject.Forms.FormSRF.HG * 15d) * Math.PI / 180d));
                string StrDisp = "Sun GMT: " + CnvtDbltoHrMin(My.MyProject.Forms.FormSRF.HG).ToString();
                if (XTD1 < 0f)
                {
                    // TDgraphics.DrawString(StrDisp, New Font("Arial", 8, FontStyle.Bold), Brushes.Blue, PtText.X + 25, PtText.Y)
                    TDgraphics.RotateTransform((float)(180 + 90 + My.MyProject.Forms.FormSRF.Lo - My.MyProject.Forms.FormSRF.HG * 15d));
                    DPen2.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                    DPen2.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    TDgraphics.DrawLine(DPen2, 0, 0, -CircleRadii, 0);
                    TDgraphics.DrawString(StrDisp, new Font("Arial", 8f, FontStyle.Bold), Brushes.Blue, -CircleRadii + 20, -15);
                    TDgraphics.DrawString(CommonGlobals.Sun_Uchar.ToString(), new Font("Arial", 12f, FontStyle.Bold), Brushes.Blue, -(CircleRadii + 20), -10);
                    TDgraphics.ResetTransform();
                    TDgraphics.TranslateTransform((float)(EqtPicBx.Width / 2d), (float)(EqtPicBx.Height / 2d));
                }
                else
                {
                    TDgraphics.RotateTransform((float)(90d + My.MyProject.Forms.FormSRF.Lo - My.MyProject.Forms.FormSRF.HG * 15d));
                    DPen2.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                    DPen2.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    TDgraphics.DrawLine(DPen2, 0, 0, CircleRadii, 0);
                    TDgraphics.DrawString(StrDisp, new Font("Arial", 8f, FontStyle.Bold), Brushes.Blue, (float)(CircleRadii / 2d), -15);
                    TDgraphics.DrawString(CommonGlobals.Sun_Uchar.ToString(), new Font("Arial", 12f, FontStyle.Bold), Brushes.Blue, CircleRadii + 8, -10);
                    TDgraphics.ResetTransform();
                    TDgraphics.TranslateTransform((float)(EqtPicBx.Width / 2d), (float)(EqtPicBx.Height / 2d));
                }
            }
            else
            {
                // for Sun sight add upper and lower mean meridian and label with both GMT and ZT (corrected) 
                My.MyProject.Forms.FormSRF.Sun();
                My.MyProject.Forms.FormSRF.HourAngles();
                // calculate and draw Sun mean time Upper / Main  meridian line and mark with Main sun character and GMT and ZT (corrected)
                XTD1 = (float)(CircleRadii * Math.Cos((90d + My.MyProject.Forms.FormSRF.Lo - My.MyProject.Forms.FormSRF.HG * 15d) * Math.PI / 180d));
                YTD1 = (float)(CircleRadii * Math.Sin((90d + My.MyProject.Forms.FormSRF.Lo - My.MyProject.Forms.FormSRF.HG * 15d) * Math.PI / 180d));
                DPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                TDgraphics.DrawLine(DPen, 0f, 0f, XTD1, YTD1);
                string StrDisp = " GMT: " + CnvtDbltoHrMin(My.MyProject.Forms.FormSRF.HG).ToString() + " ";
                if (XTD1 < 0f)
                {
                    TDgraphics.RotateTransform((float)(180 + 90 + My.MyProject.Forms.FormSRF.Lo - My.MyProject.Forms.FormSRF.HG * 15d));
                    DPen2.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                    DPen2.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    TDgraphics.DrawLine(DPen2, 0, 0, -CircleRadii, 0);
                    TDgraphics.DrawString(My.MyProject.Forms.FormSRF.BNBodyName.ToString() + StrDisp, new Font("Arial", 8f, FontStyle.Bold), Brushes.Blue, -CircleRadii + 20, -15);
                    TDgraphics.DrawString(CommonGlobals.Sun_Uchar.ToString(), new Font("Arial", 12f, FontStyle.Bold), Brushes.Blue, -(CircleRadii + 20), -10);
                    TDgraphics.ResetTransform();
                    TDgraphics.TranslateTransform((float)(EqtPicBx.Width / 2d), (float)(EqtPicBx.Height / 2d));
                }
                else
                {
                    TDgraphics.RotateTransform((float)(90d + My.MyProject.Forms.FormSRF.Lo - My.MyProject.Forms.FormSRF.HG * 15d));
                    DPen2.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                    DPen2.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    TDgraphics.DrawLine(DPen2, 0, 0, CircleRadii, 0);
                    TDgraphics.DrawString(My.MyProject.Forms.FormSRF.BNBodyName.ToString() + StrDisp, new Font("Arial", 8f, FontStyle.Bold), Brushes.Blue, (float)(CircleRadii / 2d), -15);
                    TDgraphics.DrawString(CommonGlobals.Sun_Uchar.ToString(), new Font("Arial", 12f, FontStyle.Bold), Brushes.Blue, CircleRadii + 8, -10);
                    TDgraphics.ResetTransform();
                    TDgraphics.TranslateTransform((float)(EqtPicBx.Width / 2d), (float)(EqtPicBx.Height / 2d));
                }

                // calculate and draw Sun mean time lower meridian line and mark with lesser sun character
                XTD1 = (float)(CircleRadii * Math.Cos((-90 + My.MyProject.Forms.FormSRF.Lo - My.MyProject.Forms.FormSRF.HG * 15d) * Math.PI / 180d));
                YTD1 = (float)(CircleRadii * Math.Sin((-90 + My.MyProject.Forms.FormSRF.Lo - My.MyProject.Forms.FormSRF.HG * 15d) * Math.PI / 180d));
                if (XTD1 < 0f)
                {
                    TDgraphics.RotateTransform((float)(180 - 90 + My.MyProject.Forms.FormSRF.Lo - My.MyProject.Forms.FormSRF.HG * 15d));
                    DPen2.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                    DPen2.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                    TDgraphics.DrawLine(DPen2, 0, 0, -CircleRadii, 0);
                    TDgraphics.DrawString(CommonGlobals.Sun_Uchar.ToString(), new Font("Arial", 12f, FontStyle.Bold), Brushes.Red, -(CircleRadii + 20), -10);
                    TDgraphics.ResetTransform();
                    TDgraphics.TranslateTransform((float)(EqtPicBx.Width / 2d), (float)(EqtPicBx.Height / 2d));
                }
                else
                {
                    TDgraphics.RotateTransform((float)(-90 + My.MyProject.Forms.FormSRF.Lo - My.MyProject.Forms.FormSRF.HG * 15d));
                    DPen2.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                    DPen2.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                    TDgraphics.DrawLine(DPen2, 0, 0, CircleRadii, 0);
                    TDgraphics.DrawString(CommonGlobals.Sun_Uchar.ToString(), new Font("Arial", 12f, FontStyle.Bold), Brushes.Red, CircleRadii + 8, -10);
                    TDgraphics.ResetTransform();
                    TDgraphics.TranslateTransform((float)(EqtPicBx.Width / 2d), (float)(EqtPicBx.Height / 2d));
                }

                if (chkDispEqt.Checked == true)
                {
                    // now display apparent sun and EqT factor
                    My.MyProject.Forms.FormSRF.EqTinSeconds = (int)(My.MyProject.Forms.FormSRF.GHA * 240d - My.MyProject.Forms.FormSRF.UTinSeconds);
                    while (Math.Abs(My.MyProject.Forms.FormSRF.EqTinSeconds) >= 1020) // 17 minutes
                    {
                        if (My.MyProject.Forms.FormSRF.EqTinSeconds >= 0)
                        {
                            My.MyProject.Forms.FormSRF.EqTinSeconds = My.MyProject.Forms.FormSRF.EqTinSeconds - 43200; // 43200 is 12 hours in second
                            if (My.MyProject.Forms.FormSRF.EqTinSeconds < 0)
                                break;
                        }

                        if (My.MyProject.Forms.FormSRF.EqTinSeconds < 0)
                        {
                            My.MyProject.Forms.FormSRF.EqTinSeconds = My.MyProject.Forms.FormSRF.EqTinSeconds + 43200; // 43200 is 12 hours in seconds
                            if (My.MyProject.Forms.FormSRF.EqTinSeconds >= 0)
                                break;
                        }
                    }

                    double HGCalc = My.MyProject.Forms.FormSRF.EqTinSeconds / 60d;
                    My.MyProject.Forms.FormSRF.EqTminutes = (float)Conversion.Int(Math.Abs(My.MyProject.Forms.FormSRF.EqTinSeconds / 60d));
                    My.MyProject.Forms.FormSRF.EqTseconds = Math.Abs(My.MyProject.Forms.FormSRF.EqTinSeconds) - My.MyProject.Forms.FormSRF.EqTminutes * 60f;
                    double HGCalcHR = My.MyProject.Forms.FormSRF.HG + My.MyProject.Forms.FormSRF.EqTinSeconds / 3600d; // convert HGCalc Minutes/second into Hours for subsequent calcs
                    var DTTemp = new DateTime(My.MyProject.Forms.FormSRF.DTSight.Value.Year, My.MyProject.Forms.FormSRF.DTSight.Value.Month, My.MyProject.Forms.FormSRF.DTSight.Value.Day, My.MyProject.Forms.FormSRF.ZTHours, My.MyProject.Forms.FormSRF.ZTMinutes, My.MyProject.Forms.FormSRF.ZTSeconds);
                    DTTemp = DTTemp.AddMinutes(HGCalc);
                    string EQTsign = "";
                    StrDisp = "Apparent Sun: " + DTTemp.Hour.ToString("00") + ":" + DTTemp.Minute.ToString("00") + ":" + DTTemp.Second.ToString("00") + Constants.vbCrLf;
                    if (Math.Sign(My.MyProject.Forms.FormSRF.EqTinSeconds) == 1)
                        EQTsign = "(+)";
                    if (Math.Sign(My.MyProject.Forms.FormSRF.EqTinSeconds) == 0)
                        EQTsign = "   ";
                    if (Math.Sign(My.MyProject.Forms.FormSRF.EqTinSeconds) == -1)
                        EQTsign = "(-)";
                    StrDisp += "Eqt Factor: " + EQTsign.ToString() + Strings.Format(My.MyProject.Forms.FormSRF.EqTminutes, "00") + "m" + Strings.Format(My.MyProject.Forms.FormSRF.EqTseconds, "00") + "s";
                    // redraw the general info block to include the App Sun ZT and Eqt factor
                    TDgraphics.DrawString("Body: " + My.MyProject.Forms.FormSRF.BNBodyName + Constants.vbCrLf + " Lat: " + CnvtDbltoDegMin(Math.Abs(My.MyProject.Forms.FormSRF.Lat)).ToString() + My.MyProject.Forms.FormSRF.cboL.Text + Constants.vbCrLf + " Lo : " + CnvtDbltoDegMin(Math.Abs(My.MyProject.Forms.FormSRF.Lo)).ToString() + My.MyProject.Forms.FormSRF.cboLo.Text + Constants.vbCrLf + " ZT : " + My.MyProject.Forms.FormSRF.ZTHours.ToString("00") + ":" + My.MyProject.Forms.FormSRF.ZTMinutes.ToString("00") + ":" + My.MyProject.Forms.FormSRF.ZTSeconds.ToString("00") + Constants.vbCrLf + " LHA: " + CnvtDbltoDegMin(My.MyProject.Forms.FormSRF.LHAOriginal) + Constants.vbCrLf + StrDisp, new Font("Arial", 8f, FontStyle.Bold), Brushes.Blue, (float)(-EqtPicBx.Width / 2d), (float)(-EqtPicBx.Height / 2d + 25d));

                    // calculate and draw Sun mean time lower meridian line and mark with lesser sun character
                    XTD1 = (float)(CircleRadii * Math.Cos((90d + My.MyProject.Forms.FormSRF.Lo - HGCalcHR * 15d) * Math.PI / 180d));
                    YTD1 = (float)(CircleRadii * Math.Sin((90d + My.MyProject.Forms.FormSRF.Lo - HGCalcHR * 15d) * Math.PI / 180d));
                    if (XTD1 < 0f)
                    {
                        TDgraphics.RotateTransform((float)(180 + 90 + My.MyProject.Forms.FormSRF.Lo - HGCalcHR * 15d));
                        DPen2.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                        DPen2.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                        TDgraphics.DrawLine(DPen2, 0, 0, -CircleRadii, 0);
                        TDgraphics.DrawString(My.MyProject.Forms.FormSRF.BNBodyName.ToString() + " App Sun", new Font("Arial", 8f, FontStyle.Bold), Brushes.Blue, -CircleRadii + 20, -15);
                        TDgraphics.DrawString(CommonGlobals.Sun_Uchar.ToString(), new Font("Arial", 12f, FontStyle.Bold), Brushes.LightBlue, -(CircleRadii + 20), -10);
                        TDgraphics.ResetTransform();
                        TDgraphics.TranslateTransform((float)(EqtPicBx.Width / 2d), (float)(EqtPicBx.Height / 2d));
                    }
                    else
                    {
                        TDgraphics.RotateTransform((float)(90d + My.MyProject.Forms.FormSRF.Lo - HGCalcHR * 15d));
                        DPen2.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                        DPen2.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                        TDgraphics.DrawLine(DPen2, 0, 0, CircleRadii, 0);
                        TDgraphics.DrawString(My.MyProject.Forms.FormSRF.BNBodyName.ToString() + " App Sun", new Font("Arial", 8f, FontStyle.Bold), Brushes.Blue, (float)(CircleRadii / 2d), -15);
                        TDgraphics.DrawString(CommonGlobals.Sun_Uchar.ToString(), new Font("Arial", 12f, FontStyle.Bold), Brushes.LightBlue, CircleRadii + 8, -10);
                        TDgraphics.ResetTransform();
                        TDgraphics.TranslateTransform((float)(EqtPicBx.Width / 2d), (float)(EqtPicBx.Height / 2d));
                    }
                }
            }

        ExitDrawTime:
            ;

            // draw a small circle in the middle and fill it with red
            TDgraphics.DrawEllipse(DPen, -4, -4, 8, 8);
            TDgraphics.FillEllipse(Brushes.Red, -4, -4, 8, 8);
            // save off this graphics object into single file name - delete that file name if it already exists then save to it and lodge file name into ImageLocation
            if (System.IO.File.Exists(BMFname))
            {
                System.IO.File.Delete(BMFname);
            }

            bm.Save(BMFname);
            EqtPicBx.ImageLocation = BMFname;
            EqtPicBx.Refresh();
            // dispose of bitmap graphics object so garbage cleanup can free the Save links asserted
            bm.Dispose();
            return;
        }

        private string CnvtDbltoDegMin(double DblIn)
        {
            int DegIn = (int)Conversion.Int(DblIn);
            double MinIn = (DblIn - DegIn) * 60d;
            return DegIn.ToString("##0") + '°' + " " + MinIn.ToString("#0.0") + "'";
        }

        private string CnvtDbltoHrMin(double DblIn)
        {
            int HrIn = (int)Conversion.Int(DblIn);
            double MinIn = (DblIn - HrIn) * 60d;
            int MinInInt = (int)Conversion.Int(MinIn);
            double SecIn = (MinIn - MinInInt) * 60d;
            if (HrIn >= 24)
                HrIn = 24 - HrIn;
            if (HrIn < 0)
                HrIn = Math.Abs(HrIn);
            return HrIn.ToString("00") + ":" + MinInInt.ToString("00") + ":" + SecIn.ToString("00");
        }

        private void cmdPrint_Click(object sender, EventArgs e)
        {
            Print_Renamed.PrintScreen(Bounds);
            Focus();
            return;
        }

        private void chkDispEqt_CheckedChanged(object sender, EventArgs e)
        {
            DisplayTimeDiagram();
            return;
        }
    }
}