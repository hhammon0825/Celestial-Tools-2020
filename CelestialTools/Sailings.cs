using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    internal partial class FormSailings : Form
    {
        private int TimeHours, Time1inMinutes, TimeinMinutes, Time2inMinutes, TimeMinutes;
        private string fnumeral;
        public double L1, Lo1, Distance;  // L2,Lo2,CourseAngle,
        private int MaxTimem; // , L1forMaxLat As Double
        private double Lm, Pi, LatDiff, DLo;
        private int L2Deg, Lo2Deg;
        private double CourseAngleDeg, Lo2Min, L2Min, Drift; // Course,
        private int Direction;
        private double MP, MP1, LmML, MP2, MaxLat;
        private int SignL2, SignL1, MaxLatDeg;
        private double MaxLatMin;
        private bool BadCLS;
        private double dphi, q;
        private bool Flag1, Flag, Flag2; // Flag used to retain values when switching sailing, Flag1 to exit if positions are the same, Flag2 to exit if composite sailing cannot be used
        private double LPoint, LPointMin;
        private int LastLo, Increment, LoPoint, FirstLo, LPointDeg;
        private double LoPointPrint;
        private int TabVal; // Case5 As Boolean, Case8 As Boolean, LoPointPrint As Integer
        private int DirectionFinal;
        private double DLoFinal, L2Final, L1Final, Lo1Final, Lo2Final, DistanceFinal;
        private int SignL1Final, SignL2Final;
        private double CourseAngleDegFinal, CourseFinal, CourseAngleFinal;
        private int InitialQuadrant, FinalQuadrant;
        private double Lo1Rhumb, L1Rhumb, L2Rhumb, Lo2Rhumb;
        private string Dist;
        private float TotalDistance;
        private double Fix1L, Fix1Lo;
        private double CourseToFix, CourseToDR, DriftAng;
        private double Lon32, DLon, C, A, L3, B, Lon, Lon31, x; // for GCCrossings
        private int Lon31Deg, Lon32Deg;
        private double Lon31Min, Lon32Min;
        public double Distance2, Course3, Course1, Distance1, Distance3;
        private int SignL1CD, DirectionCD, SignL2CD;
        private double L1CD, Lo2CD, DLoCD, Lo1CD, L2CD;
        private double CourseCD, DistanceCD, CourseAngleCD, CourseAngleDegCD;
        private float DistanceComposite;
        private double LoVertexMin, DLoVertex, LoVertex;
        private int LoVertexDeg, Segment;
        private double DLo1, DLo2;
        private bool Flag3, Flag4; // Flag3 used for PointsM2, Flag4 for Drift Angle port or starboard
        private bool ReachedMaxLat, AtMaxLat, LeftMaxLat;
        private double LoPointPrintMin, SavedLoPoint, LPointPrint;
        private int ReachedMaxLatCount, LoPointPrintDeg, LeftMaxLatCount;
        private int LPointPrintDeg, CoursePrevious;
        private double Lo2Initial, L1Initial, LPointPrintMin, Lo1Initial, LPointPrior;
        private string Prefix, Suffix;
        private float Departure, Factor, CompC, LmMin;
        private int IntLmMin, IntLatDiff, LmDeg, IntDLo;
        private double SMG;
        public double L2, Lo2, Course, CourseAngle;
        private string lcl_PtOnCompRte = "Points on Composite Route";
        private string lcl_PtOnCompRteM1 = "Points on Composite Route, Method 1";
        private string lcl_PtOnCompRteM2 = "Points on Composite Route, Method 2";
        private string lcl_PtonGCR = "Points on Great Circle Route";
        public DataSet DatasetGCR;
        public string tablenameGCR = "TableGCR";
        public string[] HdrStrGCR = new[] { "Longitude", "Latitude", '°' + "True", "Dist (nm)" };
        public string[] NullStrGCR = new[] { Constants.vbNullString, Constants.vbNullString, Constants.vbNullString, Constants.vbNullString };
        public bool GCRAvailable = false;

        public struct GCRRec
        {
            public string LatStr;
            public string LongStr;
            public string CTrue;
            public string GCRDist;
        }

        public GCRRec[] GCRArray;

        private void chkComposite_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            if ((int)chkComposite.CheckState == 1)
            {
                Frame3.Visible = true;
                lblLimLat.Visible = true;
                txtL3Deg.Visible = true;
                Label16.Visible = true;
                cboL3.Visible = true;
                cmdPoints.Text = lcl_PtOnCompRte;
                txtL3Min.Visible = true;
                Label15.Visible = true; // :optMethod1.Visible = True: optMethod2.Visible = True
            }

            if (chkComposite.CheckState == 0)
            {
                Frame3.Visible = false;
                lblLimLat.Visible = false;
                txtL3Deg.Visible = false;
                Label16.Visible = false;
                cboL3.Visible = false;
                cmdPoints.Text = lcl_PtonGCR;
                txtL3Min.Visible = false;
                Label15.Visible = false;
            }

            if ((int)chkComposite.CheckState == 1 & optMethod1.Checked == true)
            {
                cmdPoints.Text = lcl_PtOnCompRte; // 
            }

            if ((int)chkComposite.CheckState == 1 & optMethod2.Checked == true)
            {
                cmdPoints.Text = lcl_PtOnCompRte; // 
            }

            if (chkComposite.CheckState == 0)
            {
                cmdPoints.Text = lcl_PtonGCR;
            }
        }

        private void chkDriftAngle_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            if ((int)chkDriftAngle.CheckState == 1)
            {
                Label14.Visible = true;
                Label13.Visible = true;
                Label12.Visible = true;
                Label11.Visible = true;
                Label10.Visible = true;
                Label9.Visible = true;
                txtFix1LD.Visible = true;
                txtFix1LM.Visible = true;
                txtFix1LoD.Visible = true;
                txtFix1LoM.Visible = true;
                cboFix1L.Visible = true;
                cboFix1Lo.Visible = true;
            }

            if (chkDriftAngle.CheckState == 0)
            {
                Label14.Visible = false;
                Label13.Visible = false;
                Label12.Visible = false;
                Label11.Visible = false;
                Label10.Visible = false;
                Label9.Visible = false;
                txtFix1LD.Visible = false;
                txtFix1LM.Visible = false;
                txtFix1LoD.Visible = false;
                txtFix1LoM.Visible = false;
                cboFix1L.Visible = false;
                cboFix1Lo.Visible = false;
                txtFix1LD.Text = "";
                txtFix1LM.Text = "";
                txtFix1LoD.Text = "";
                txtFix1LoM.Text = "";
            }
        }

        private void cmdCalculate_Click(object eventSender, EventArgs eventArgs)
        {
            // if previous calculate has done GCR array then redim(0) clean out and tell DeckLog an array is not available to load
            GCRArray = new GCRRec[1];
            GCRAvailable = false;
            Flag1 = false;
            LatLong();
            if (BadCLS == true)
            {
                txtMLDeg.Focus();
                return;
            }

            if (chkDriftAngle.Checked == true)
            {
                DriftAngle();
            }

            if (optMidLat.Checked == true | optMercatorE.Checked == true | optMercatorS.Checked == true | optAccurateRhumb.Checked == true)
            {
                RhumbLine();
                cmdRhumbPoints.Enabled = true;
                My.MyProject.Forms.frmPointsOnRhumb.RhumbPointsTxtBx.Clear();
            }

            if (optGreatCircle.Checked == true)
            {
                GreatCircle();
                cmdPoints.Enabled = true;
                // frmPointsOnGCR.txtGCR.Clear()
                // frmPointsOnGCR.DGGCR.Rows.Clear()
                My.MyProject.Forms.frmPointsOnGCR.txtLoPointDeg.Text = "";
                My.MyProject.Forms.frmPointsOnGCR.txtLoPointMin.Text = "";
            }

            if (optGreatCircle.Checked == true & optICD.Checked == true & (Lo1 == Lo2 | Math.Sign(Lo1) != Math.Sign(Lo2) & Math.Abs(Lo1) + Math.Abs(Lo2) == 180d) | L1 == 90d | L1 == -90 | L2 == 90d | L2 == -90)
            {
                cmdPoints.Enabled = false;
            }

            if (optGreatCircle.Checked == true & optL2Lo2GC.Checked == true & (Conversion.Val(txtCourse.Text) == 0d | Conversion.Val(txtCourse.Text) == 180d))
            {
                cmdPoints.Enabled = false;
            }

            if (Flag1 == true)
            {
                return;
            }

            return;
        }

        private void RhumbLine()
        {
            // Calculate destination position
            if (optL2Lo2.Checked == true)
            {
                // Time
                Time1inMinutes = (int)(60d * Conversion.Val(Strings.Left(txtTime1.Text, 2)) + Conversion.Val(Strings.Right(txtTime1.Text, 2)));
                Time2inMinutes = (int)(60d * Conversion.Val(Strings.Left(txtTime2.Text, 2)) + Conversion.Val(Strings.Right(txtTime2.Text, 2)));
                TimeinMinutes = Time2inMinutes - Time1inMinutes;
                TimeHours = (int)Conversion.Int(TimeinMinutes / 60d);
                TimeMinutes = TimeinMinutes - 60 * TimeHours;
                if (TimeinMinutes < 0)
                {
                    ErrorMsgBox("Error:  Time1 later than Time2");
                    return;
                }

                if (TimeinMinutes == 0)
                {
                    TimeinMinutes = (int)(60d * Conversion.Val(txtTimeh.Text) + Conversion.Val(txtTimem.Text));
                }
                // Distance
                if (Conversion.Val(txtLog2.Text) < Conversion.Val(txtLog1.Text))
                {
                    ErrorMsgBox("Error:  Log1 greater than Log2");
                    return;
                }

                Distance = Conversion.Val(txtLog2.Text) - Conversion.Val(txtLog1.Text); // : txtDist.Text = Str$(Distance) 'Log values entered
                if (string.IsNullOrEmpty(txtLog1.Text) & string.IsNullOrEmpty(txtLog2.Text))
                {
                    Distance = Conversion.Val(txtDist.Text); // No log values entered
                }

                if (Distance == 0d)
                {
                    Distance = Conversion.Val(txtSpeed.Text) * TimeinMinutes / 60d; // : txtDist.Text = Str$(Distance) 'No log or distance values entered, use speed and time
                }

                if (Conversion.Val(txtCourse.Text) >= 0d & Conversion.Val(txtCourse.Text) < 90d)
                {
                    CourseAngle = -Conversion.Val(txtCourse.Text);
                }

                if (Conversion.Val(txtCourse.Text) >= 90d & Conversion.Val(txtCourse.Text) < 180d)
                {
                    CourseAngle = -(180d - Conversion.Val(txtCourse.Text));
                }

                if (Conversion.Val(txtCourse.Text) >= 180d & Conversion.Val(txtCourse.Text) < 270d)
                {
                    CourseAngle = Conversion.Val(txtCourse.Text) - 180d;
                }

                if (Conversion.Val(txtCourse.Text) >= 270d & Conversion.Val(txtCourse.Text) < 360d)
                {
                    CourseAngle = 360d - Conversion.Val(txtCourse.Text);
                }

                LatDiff = Distance * Math.Cos(CourseAngle * Pi / 180d) / 60d;
                if (Conversion.Val(txtCourse.Text) > 90d & Conversion.Val(txtCourse.Text) < 270d)
                {
                    LatDiff = -LatDiff;
                }

                L2 = L1 + LatDiff;
                if (optMidLat.Checked == true & Math.Abs(L2) >= 85d)
                {
                    ErrorMsgBox("Latitude too high for Mid-Latitude sailing.");
                    return;
                }

                if ((optMercatorE.Checked == true | optMercatorS.Checked == true | optAccurateRhumb.Checked == true) & (Conversion.Val(txtCourse.Text) == 0d | Conversion.Val(txtCourse.Text) == 180d))
                {
                    ErrorMsgBox("Course crosses pole into other hemisphere.");
                    return;
                }

                if (Math.Abs(L2) > 90d & Conversion.Val(txtCourse.Text) != 0d & Conversion.Val(txtCourse.Text) != 180d)
                {
                    ErrorMsgBox("Distance too large.  Cannot go this far along this rhumb line.");
                    return;
                }

                if (optMidLat.Checked == true)
                {
                    Lm = (L1 + L2) / 2d; // Mid-latitude
                    if ((int)chkML.CheckState == 1)
                    {
                        if (Math.Abs(L1 - L2) > 1d)
                        {
                            ErrorMsgBox("Calculated L2 more than 1º from L1.  CLS SAPS cannot be used.");
                            return;
                        }

                        Lm = LmML;
                    }

                    DLo = Distance * Math.Sin(CourseAngle * Pi / 180d) / Math.Cos(Lm * Pi / 180d) / 60d;
                    if ((int)chkML.CheckState == 1 & Math.Abs(DLo) > 1d)
                    {
                        ErrorMsgBox("Calculated Lo2 more than 1º from Lo1.  CLS SAPS cannot be used.");
                        return;
                    }
                }

                if ((optMercatorE.Checked == true | optMercatorS.Checked == true) & Math.Abs(CourseAngle) != 90d)
                {
                    MeridionalParts();
                    DLo = Math.Tan(CourseAngle * Pi / 180d) * MP / 60d; // degrees
                }

                if ((optMercatorE.Checked == true | optMercatorS.Checked == true) & Math.Abs(CourseAngle) == 90d) // This section not in versions prior to V4.2.1
                {
                    MeridionalParts();
                    DLo = Distance * Math.Sin(CourseAngle * Pi / 180d) / Math.Cos(L1 * Pi / 180d) / 60d;
                }

                if (optAccurateRhumb.Checked == true)
                {
                    Course = Conversion.Val(txtCourse.Text);
                    L2 = L1 * Pi / 180d + Distance / 60d * Pi / 180d * Math.Cos(Course * Pi / 180d);
                    if (Math.Abs(L2) > 90d)
                    {
                        ErrorMsgBox("Distance too large.  Cannot go this far along this rhumb line.");
                        return;
                    }

                    if (Math.Abs(LatDiff) < Math.Sqrt(0.000000000000001d))
                    {
                        q = Math.Cos(L1 * Pi / 180d);
                    }
                    else
                    {
                        dphi = Math.Log(Math.Tan(L2 / 2d + Pi / 4d) / Math.Tan(L1 * Pi / 180d / 2d + Pi / 4d));
                        q = LatDiff * Pi / 180d / dphi;
                    }

                    DLo = -(Distance / 60d * Pi / 180d) * Math.Sin(Course * Pi / 180d) / q;
                    DLo = DLo * 180d / Pi;
                    L2 = L2 * 180d / Pi;
                }

                Lo2 = Lo1 + DLo;
                while (Lo2 >= 360d)
                    Lo2 = Lo2 - 360d;
                // Crossing IDL
                if (Math.Abs(Lo2) > 180d)
                    Lo2 = -Math.Sign(Lo2) * (360d - Math.Abs(Lo2));
                DisplayDestination();
            }
            // Calculate course and distance
            if (optCD.Checked == true)
            {
                CDandSD();
                Course = Conversion.Int(Course * 10d + 0.5d) / 10d;
                DisplayCD();
            }
            // Calculate set and drift
            if (optSD.Checked == true)
            {
                Time1inMinutes = (int)(60d * Conversion.Val(Strings.Left(txtTime1.Text, 2)) + Conversion.Val(Strings.Right(txtTime1.Text, 2)));
                Time2inMinutes = (int)(60d * Conversion.Val(Strings.Left(txtTime2.Text, 2)) + Conversion.Val(Strings.Right(txtTime2.Text, 2)));
                TimeinMinutes = Time2inMinutes - Time1inMinutes;
                TimeHours = (int)Conversion.Int(TimeinMinutes / 60d);
                TimeMinutes = TimeinMinutes - 60 * TimeHours;
                if (TimeinMinutes < 0)
                {
                    ErrorMsgBox("Error:  Time1 later than Time2");
                    return;
                }

                if (TimeinMinutes == 0)
                {
                    TimeinMinutes = (int)(60d * Conversion.Val(txtTimeh.Text) + Conversion.Val(txtTimem.Text));
                }

                CDandSD();
                if (TimeinMinutes != 0)
                {
                    Drift = Math.Abs(Distance / (TimeinMinutes / 60d));
                }

                DisplaySD();
                if ((int)chkDriftAngle.CheckState == 1)
                {
                    L1 = Fix1L;
                    Lo1 = Fix1Lo;
                    CDandSD();
                    Distance = Math.Abs(Conversion.Int(Distance * 10d + 0.5d) / 10d);
                    if (TimeinMinutes != 0)
                    {
                        SMG = Distance / (TimeinMinutes / 60d);
                    }

                    SMG = Conversion.Int(SMG * 10d + 0.5d) / 10d;
                    DisplayCMGSMG();
                }
            }
        }

        private void CDandSD()
        {
            if (BadCLS == true)
                return;
            if (L1 == L2 & Lo1 == Lo2)
            {
                ErrorMsgBox("Initial and final positions are the same.");
                Flag1 = true;
                return;
            }

            LatDiff = L2 - L1;
            DLo = Lo2 - Lo1;
            // Crossing IDL
            if (Math.Abs(DLo) > 180d)
            {
                DLo = -Math.Sign(DLo) * (360d - Math.Abs(DLo));
            }

            if (optMidLat.Checked == true)
            {
                Lm = (L1 + L2) / 2d; // Mid-latitude
                if ((int)chkML.CheckState == 1)
                {
                    Lm = LmML;
                    TestML();
                }

                if (LatDiff == 0d)
                {
                    CourseAngle = Pi / 2d;
                }
                else
                {
                    CourseAngle = Math.Abs(Math.Atan(DLo * 60d * Math.Cos(Lm * Pi / 180d) / (LatDiff * 60d)));
                }

                CourseAngleDeg = CourseAngle * 180d / Pi;
            }

            if (optMercatorE.Checked == true | optMercatorS.Checked == true)
            {
                MeridionalParts();
                if (MP == 0d)
                {
                    CourseAngle = Pi / 2d;
                }
                else
                {
                    CourseAngle = Math.Atan(DLo * 60d / MP);
                }

                CourseAngleDeg = CourseAngle * 180d / Pi;
            }

            if (optAccurateRhumb.Checked == true)
            {
                dphi = Math.Log(Math.Tan(L2 * Pi / 180d / 2d + Pi / 4d) / Math.Tan(L1 * Pi / 180d / 2d + Pi / 4d));
                if (Math.Abs(LatDiff) < Math.Sqrt(0.000000000000001d))
                {
                    q = Math.Cos(L1 * Pi / 180d);
                }
                else
                {
                    q = LatDiff * Pi / 180d / dphi;
                }
                // End If
                // If optAccurateRhumb = True Then
                Distance = Math.Sqrt(q * q * DLo * DLo + LatDiff * LatDiff);
                // If Abs(dphi) < 0.008 Then dphi = 0    'Added in V4.9.3 to eliminte problem when course was exactly 0º; added abs in V5.0.4; value was 0.02  ELIMINATED THIS LINE IN v5.0.4
                CourseAngle = 2d * Math.Atan((Math.Sqrt(DLo * Pi / 180d * DLo * Pi / 180d + dphi * dphi) - dphi) / ((DLo + 9.999999E-21d) * Pi / 180d));
                CourseAngleDeg = CourseAngle * 180d / Pi;
                if (DLo == 0d & L2 > L1)
                {
                    CourseAngleDeg = 0d; // ADDED THIS LINE IN V5.0.4 FOR WHEN COURSE WAS EXACTLY 0º
                }
            }
            // CourseAngleDeg = CourseAngle * 180 / Pi
            if (optMidLat.Checked == true | optMercatorE.Checked == true | optMercatorS.Checked == true)
            {
                if (LatDiff >= 0d & DLo < 0d)
                {
                    Course = Math.Abs(CourseAngleDeg); // Added Abs to CourseAngleDeg
                }

                if (LatDiff >= 0d & DLo >= 0d)
                {
                    Course = 360d - Math.Abs(CourseAngleDeg); // Added Abs to CourseAngleDeg
                }

                if (LatDiff < 0d & DLo < 0d)
                {
                    Course = 180d - Math.Abs(CourseAngleDeg); // Added Abs to CourseAngleDeg
                }

                if (LatDiff < 0d & DLo >= 0d)
                {
                    Course = 180d + Math.Abs(CourseAngleDeg); // Added Abs to CourseAngleDeg
                }
            }

            if (optAccurateRhumb.Checked == true)
            {
                if (LatDiff >= 0d & DLo < 0d)
                {
                    Course = Math.Abs(CourseAngleDeg);
                }

                if (LatDiff >= 0d & DLo >= 0d)
                {
                    Course = 360d - Math.Abs(CourseAngleDeg);
                }

                if (LatDiff < 0d & DLo < 0d)
                {
                    Course = Math.Abs(CourseAngleDeg);
                }

                if (LatDiff < 0d & DLo >= 0d)
                {
                    Course = 360d - Math.Abs(CourseAngleDeg);
                }
            }

            if (Course >= 360d)
            {
                Course = Course - 360d; // Added in V4.9.3
            }

            if (optMidLat.Checked == true | optMercatorE.Checked == true | optMercatorS.Checked == true)
            {
                Distance = LatDiff / Math.Cos(CourseAngle); // for both mid-latitude and Mercator; total drift for S&D
            }
            // The next line is called for in text but makes answers worse
            // If Abs(CourseAngleDeg) >= 85 And Abs(CourseAngleDeg) <= 90 Then Distance = (DLo * Cos(Lm * Pi / 180)) / Sin(CourseAngle) 'for both mid-latitude and Mercator; total drift for S&D 'CourseAngle = (90 * Pi / 180) - Abs(CourseAngle)
            if (L1 == L2)
            {
                Distance = DLo * Math.Cos(L1 * Pi / 180d);
            }

            Distance = 60d * Distance;
            return;
        }

        private void cmdClearAll_Click(object eventSender, EventArgs eventArgs)
        {
            txtL1Deg.Text = "";
            txtL1Min.Text = "";
            txtLo1Deg.Text = "";
            txtLo1Min.Text = "";
            txtL2Deg.Text = "";
            txtL2Min.Text = "";
            txtLo2Deg.Text = "";
            txtLo2Min.Text = "";
            txtCourse.Text = "";
            txtDist.Text = "";
            txtSpeed.Text = "";
            txtTimeh.Text = "";
            txtTimem.Text = "";
            txtMLDeg.Text = "";
            cboMLmin.SelectedIndex = -1;
            chkML.CheckState = CheckState.Unchecked;
            txtLog1.Text = "";
            txtLog2.Text = "";
            txtTime1.Text = "";
            txtTime2.Text = "";
            txtFix1LD.Text = "";
            txtFix1LM.Text = "";
            txtFix1LoD.Text = "";
            txtFix1LoM.Text = "";
            txtL3Deg.Text = "";
            txtL3Min.Text = "";
            chkComposite.CheckState = CheckState.Unchecked;
            optMethod1.Checked = false;
            optMethod2.Checked = false;
            return;
        }

        private void cmdClearSwap_Click(object eventSender, EventArgs eventArgs)
        {
            if (optL2Lo2.Checked == true)
            {
                txtL1Deg.Text = Strings.Format(L2Deg, "#0");
                txtL1Min.Text = Strings.Format(L2Min, "00.0");
                txtLo1Deg.Text = Strings.Format(Lo2Deg, "##0");
                txtLo1Min.Text = Strings.Format(Lo2Min, "00.0");
                if (L2 >= 0d) // North latitudes from equator to 89.9 are positive while South latitudes below equator are negative
                {
                    cboL1.SelectedIndex = 0; // If L2 is >= 0 then N - selectedindex 0
                }
                else
                {
                    cboL1.SelectedIndex = 1;
                } // else S - selectedindex 1

                if (Lo2 >= 0d) // East Longitudes >= 0 are psoitive while West Longitudes are negative
                {
                    cboLo1.SelectedIndex = 1; // If Lo2 is >= 0 then E - selectedindex 1
                }
                else
                {
                    cboLo1.SelectedIndex = 0;
                } // else W - selectedindex 0
            }

            if (optCD.Checked == true)
            {
                txtL1Deg.Text = txtL2Deg.Text;
                txtL1Min.Text = txtL2Min.Text;
                txtLo1Deg.Text = txtLo2Deg.Text;
                txtLo1Min.Text = txtLo2Min.Text;
                cboL1.Text = cboL2.Text;
                cboLo1.Text = cboLo2.Text;
            }

            txtL2Deg.Text = "";
            txtL2Min.Text = "";
            txtLo2Deg.Text = "";
            txtLo2Min.Text = "";
            cboL2.SelectedIndex = 0; // N Latitude default
            cboLo2.SelectedIndex = 0;  // W Longitude default
            txtCourse.Text = "";
            txtDist.Text = "";
            txtSpeed.Text = "";
            txtTime1.Text = "";
            txtTime2.Text = "";
            txtTimeh.Text = "";
            txtTimem.Text = "";
            if (chkML.Checked == true)
            {
                return;
            }

            txtMLDeg.Text = "";
            // cboMLmin.Text = ""
            cboMLmin.SelectedIndex = -1;
            cboML.SelectedIndex = 0; // "N"
            chkML.Checked = false;
            txtLog1.Text = "";
            txtLog2.Text = "";
            return;
        }

        public void cmdPoints_Click(object eventSender, EventArgs eventArgs)
        {
            My.MyProject.Forms.frmPointsOnGCR.DGGCR.DataSource = Constants.vbNull;
            if (chkComposite.CheckState == 0)
            {
                My.MyProject.Forms.frmPointsOnGCR.Text = lcl_PtonGCR;
            }

            if ((int)chkComposite.CheckState == 1 & optMethod1.Checked == true)
            {
                My.MyProject.Forms.frmPointsOnGCR.Text = lcl_PtOnCompRteM1;
            }

            if ((int)chkComposite.CheckState == 1 & optMethod2.Checked == true)
            {
                My.MyProject.Forms.frmPointsOnGCR.Text = lcl_PtOnCompRteM2;
            }

            My.MyProject.Forms.frmPointsOnGCR.cmdWaypoint.Enabled = true;
            if ((int)chkComposite.CheckState == 1 & optMethod2.Checked == true)
            {
                My.MyProject.Forms.frmPointsOnGCR.cmdWaypoint.Enabled = false;
                PointsM2();
                return;
            }

            string LongStr = "";
            string LatStr = "";
            string CourseStr = "";
            string DistanceStr = "";
            DatasetGCR = new DataSet();
            DatasetGCR.Tables.Add(tablenameGCR);
            DatasetGCR.DataSetName = tablenameGCR;
            My.MyProject.Forms.frmPointsOnGCR.DGGCR.DataSource = DatasetGCR;
            for (int i = 0, loopTo = Information.UBound(HdrStrGCR); i <= loopTo; i++)
            {
                DatasetGCR.Tables[tablenameGCR].Columns.Add(HdrStrGCR[i]);
                DatasetGCR.Tables[tablenameGCR].Columns[i].AllowDBNull = false;
                DatasetGCR.Tables[tablenameGCR].Columns[i].DefaultValue = "";
            }
            // DatasetGCR.Tables(tablenameGCR).Rows.Add(NullStrGCR)
            My.MyProject.Forms.frmPointsOnGCR.DGGCR.DataSource = DatasetGCR.Tables[0].DefaultView;
            My.MyProject.Forms.frmPointsOnGCR.DGGCR.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            My.MyProject.Forms.frmPointsOnGCR.DGGCR.ColumnHeadersDefaultCellStyle.BackColor = Color.Yellow;
            for (int i = 0, loopTo1 = My.MyProject.Forms.frmPointsOnGCR.DGGCR.Columns.Count - 1; i <= loopTo1; i++)
            {
                My.MyProject.Forms.frmPointsOnGCR.DGGCR.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                My.MyProject.Forms.frmPointsOnGCR.DGGCR.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                My.MyProject.Forms.frmPointsOnGCR.DGGCR.Columns[i].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                My.MyProject.Forms.frmPointsOnGCR.DGGCR.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                My.MyProject.Forms.frmPointsOnGCR.DGGCR.Columns[i].DefaultCellStyle.BackColor = Color.LightBlue;
            }

            My.MyProject.Forms.frmPointsOnGCR.Show();
            TotalDistance = 0f;
            Distance = 0d;
            Lo1Initial = Lo1;
            Lo2Initial = Lo2;
            ReachedMaxLatCount = 0;
            LeftMaxLatCount = 0;
            Flag3 = false;
            // convert all east longitudes to west
            if (Lo1 < 0d)
            {
                Lo1 = 360d - Math.Abs(Lo1);
            }

            if (Lo2 < 0d)
            {
                Lo2 = 360d - Math.Abs(Lo2);
            }

            if (Lon31 < 0d)
            {
                Lon31 = 360d - Math.Abs(Lon31);
            }

            if (Lon32 < 0d)
            {
                Lon32 = 360d - Math.Abs(Lon32);
            }
            // determine whether traveling should be eastward or westward and increment
            DLo = Lo2 - Lo1;
            Increment = 5;
            if (DLo < 0d)
            {
                Increment = -5;
            }
            // If Abs(DLo) > 180 Then DLo = 360 - DLo
            if (Lo2 > Lo1 & Math.Abs(DLo) > 180d & Increment == 5)
            {
                Lo1 = Lo1 + 360d;
                Increment = -5;
                Flag3 = true; // skip next line if this line is used
            }

            if (Flag3 == false & Lo2 < Lo1 & Math.Abs(DLo) > 180d & Increment == -5)
            {
                Lo2 = Lo2 + 360d;
                Increment = 5;
            }
            // make Lon31 and Lon32 fall between Lo1 and Lo2
            if (Lo2 > Lo1 & (Lon31 > Lo2 | Lon31 < Lo1))
            {
                Lon31 = Lon31 + 360d;
            }

            if (Lo1 > Lo2 & (Lon31 > Lo1 | Lon31 < Lo2))
            {
                Lon31 = Lon31 + 360d;
            }

            if (Lo2 > Lo1 & (Lon32 > Lo2 | Lon32 < Lo1))
            {
                Lon32 = Lon32 + 360d;
            }

            if (Lo1 > Lo2 & (Lon32 > Lo1 | Lon32 < Lo2))
            {
                Lon32 = Lon32 + 360d;
            }

            DLo = Math.Abs(Lo2 - Lo1);
            Increment = 5;
            Direction = 1;
            if (Lo2 < Lo1)
            {
                Increment = -5;
                Direction = -1;
            }

            if (DLo > 180d)
            {
                DLo = 360d - DLo;
                Increment = -Increment;
                Direction = -Direction;
            }

            if (Increment == -5 & Lo1 < Lo2)
            {
                Lo1 = Lo1 + 360d;
            }

            if (Increment == 5 & Lo1 > Lo2)
            {
                Lo2 = Lo2 + 360d;
            }

            if ((int)chkComposite.CheckState == 1 & L1 != L3 | chkComposite.CheckState == 0)
            {
                TabVal = 5;
                if (string.IsNullOrEmpty(txtLo1Deg.Text))
                {
                    TabVal = 4;
                }

                if (Conversion.Val(txtLo1Deg.Text) != 0d)            // added this If..End if in V5.6.1
                {
                    LongStr = Conversion.Val(txtLo1Deg.Text).ToString("0") + '°' + Conversion.Val(txtLo1Min.Text).ToString("00.0") + "'" + cboLo1.Text; // If ModFP(Lo1, 5) <> 0 Then
                    TabVal = 2;
                    if (string.IsNullOrEmpty(txtL1Deg.Text))
                    {
                        TabVal = 1;        // were 16 15
                    }

                    LatStr = Conversion.Val(txtL1Deg.Text).ToString("0") + '°' + Conversion.Val(txtL1Min.Text).ToString("00.0") + "'"; // If ModFP(Lo1, 5) <> 0 Then
                    if (L1 != 0d)
                    {
                        LatStr += Strings.Left(cboL1.Text, 1);
                    }
                }
            }

            if (Increment == -5)
            {
                FirstLo = (int)(Lo1 - ModFP(Lo1, 5d));
                LastLo = (int)(Lo2 - ModFP(Lo2, 5d));
                if (ModFP(Lo2, 5d) == 0d)
                {
                    LastLo = (int)Lo2;
                }
            }

            if (Increment == 5)
            {
                FirstLo = (int)(Lo1 - ModFP(Lo1, 5d));
                LastLo = (int)(Lo2 - ModFP(Lo2, 5d));
                if (ModFP(Lo1, 5d) != 0d)
                {
                    FirstLo = FirstLo + 5; // : If Segment = 1 Then LastLo = LastLo + 5
                }

                if (ModFP(Lo2, 5d) == 0d)
                {
                    LastLo = (int)Lo2;
                }
            }

            TotalDistance = 0f;
            if (L1 != L3 & FirstLo - Lon31 > 5d & LastLo - Lon31 > 5d)
            {
                Lon31 = Lon31 + 360d;
            }

            if (L2 != L3 & FirstLo - Lon32 > 5d & LastLo - Lon32 > 5d)
            {
                Lon32 = Lon32 + 360d;
            }

            AtMaxLat = false;
            ReachedMaxLat = false;
            ReachedMaxLatCount = 0;
            LeftMaxLat = false;
            LeftMaxLatCount = 0;
            var loopTo2 = LastLo;
            for (LoPoint = FirstLo; Increment >= 0 ? LoPoint <= loopTo2 : LoPoint >= loopTo2; LoPoint += Increment)
            {
                if (ReachedMaxLatCount == 1 | LeftMaxLatCount == 1)
                {
                    LoPoint = (int)SavedLoPoint;
                }

                LPoint = Math.Atan((Math.Sin(L1 * Pi / 180d) * Math.Cos(L2 * Pi / 180d) * Math.Sin((LoPoint - Lo2) * Pi / 180d) - Math.Sin(L2 * Pi / 180d) * Math.Cos(L1 * Pi / 180d) * Math.Sin((LoPoint - Lo1) * Pi / 180d)) / (Math.Cos(L1 * Pi / 180d) * Math.Cos(L2 * Pi / 180d) * Math.Sin((Lo1 - Lo2) * Pi / 180d)));
                LPoint = LPoint * 180d / Pi;
                LoPointPrint = LoPoint;
                if ((int)chkComposite.CheckState == 1)
                {
                    if (LoPoint > Lon31 & Increment == 5 | LoPoint < Lon31 & Increment == -5 & Math.Abs(LoPoint - Lon31) <= 5d & ReachedMaxLatCount == 0)
                    {
                        AtMaxLat = true;
                        ReachedMaxLat = true;
                        SavedLoPoint = LoPoint;
                        ReachedMaxLatCount = ReachedMaxLatCount + 1;
                    }

                    if (AtMaxLat == true & ReachedMaxLat == false)
                    {
                        ReachedMaxLatCount = ReachedMaxLatCount + 1; // to make ReachedMaxLatCount>1
                    }

                    if (ReachedMaxLat == false)
                    {
                        LPointPrint = LPoint;
                        LoPointPrint = LoPoint;
                    }

                    if (AtMaxLat == true & ReachedMaxLatCount != 1)
                    {
                        LPointPrint = L3;
                        LoPointPrint = LoPoint;
                    }

                    if (AtMaxLat == true & ReachedMaxLatCount == 1)
                    {
                        LPointPrint = L3;
                        LoPointPrint = Lon31;
                        ReachedMaxLat = false;
                    }

                    if (AtMaxLat == false)
                    {
                        LoPointPrint = LoPoint;
                        LPointPrint = LPoint;
                    }

                    if (LoPoint > Lon32 & Increment == 5 | LoPoint < Lon32 & Increment == -5 & Math.Abs(LoPoint - Lon32) <= 5d)
                    {
                        LPointPrint = L3;
                        LoPointPrint = Lon32;
                        AtMaxLat = false;
                        LeftMaxLat = true;
                        SavedLoPoint = LoPoint;
                        LeftMaxLatCount = LeftMaxLatCount + 1;
                    }

                    if (AtMaxLat == true & LeftMaxLat == true)
                    {
                        LeftMaxLatCount = LeftMaxLatCount + 1; // to make LeftMaxLatCount>1
                    }

                    if (AtMaxLat == false & LeftMaxLatCount > 1)
                    {
                        LPointPrint = LPoint;
                        LoPointPrint = LoPoint;
                    }
                }

                if (chkComposite.CheckState == 0)
                {
                    LPointPrint = LPoint;
                    LoPointPrint = LoPoint;
                }

                LPointDeg = (int)Conversion.Int(Math.Abs(LPointPrint));
                LPointMin = (Math.Abs(LPointPrint) - LPointDeg) * 60d;
                if (Conversion.Int(LPointMin * 10d + 0.5d) / 10d == 60d)
                {
                    LPointMin = 0d;
                    LPointDeg = LPointDeg + 1;
                }

                if (LoPointPrint > 180d)
                {
                    LoPointPrint = -Math.Sign(LoPointPrint) * (360d - Math.Abs(LoPointPrint));
                }

                LoPointPrintDeg = (int)Conversion.Int(Math.Abs(LoPointPrint));
                LoPointPrintMin = (Math.Abs(LoPointPrint) - LoPointPrintDeg) * 60d;
                if (Conversion.Int(LoPointPrintMin * 10d + 0.5d) / 10d == 60d)
                {
                    LoPointPrintMin = 0d;
                    LoPointPrintDeg = LoPointPrintDeg + 1;
                }

                // uses Accurate Rhumb Line for course and distance
                L2Rhumb = LPointPrint;
                Lo2Rhumb = LoPointPrint;
                if (LoPoint == FirstLo)
                {
                    L1Rhumb = L1;
                    Lo1Rhumb = Lo1;
                }

                LatDiff = L2Rhumb - L1Rhumb;
                DLo = Lo2Rhumb - Lo1Rhumb;
                // Crossing IDL
                if (Math.Abs(DLo) > 180d)
                {
                    DLo = -Math.Sign(DLo) * (360d - Math.Abs(DLo));
                }

                dphi = Math.Log(Math.Tan(L2Rhumb * Pi / 180d / 2d + Pi / 4d) / Math.Tan(L1Rhumb * Pi / 180d / 2d + Pi / 4d));
                if (Math.Abs(LatDiff) < Math.Sqrt(0.000000000000001d))
                {
                    q = Math.Cos(L1Rhumb * Pi / 180d);
                }
                else
                {
                    q = LatDiff * Pi / 180d / dphi;
                }

                Distance = 60d * Math.Sqrt(q * q * DLo * DLo + LatDiff * LatDiff);
                CourseAngle = 2d * Math.Atan((Math.Sqrt(DLo * Pi / 180d * DLo * Pi / 180d + dphi * dphi) - dphi) / ((DLo + 9.999999E-21d) * Pi / 180d));
                CourseAngleDeg = CourseAngle * 180d / Pi;
                if (LatDiff >= 0d & DLo < 0d)
                {
                    Course = Math.Abs(CourseAngleDeg);
                }

                if (LatDiff >= 0d & DLo >= 0d)
                {
                    Course = 360d - Math.Abs(CourseAngleDeg);
                }

                if (LatDiff < 0d & DLo < 0d)
                {
                    Course = Math.Abs(CourseAngleDeg);
                }

                if (LatDiff < 0d & DLo >= 0d)
                {
                    Course = 360d - Math.Abs(CourseAngleDeg);
                }

                Course = Conversion.Int(Course + 0.5d);
                Distance = Conversion.Int(Distance * 10d + 0.5d) / 10d;
                if (LeftMaxLatCount == 1)
                {
                    Distance = Distance2;
                }

                if (AtMaxLat == true & ReachedMaxLatCount > 1)
                {
                    Distance = 0d;
                }

                TotalDistance = (float)(TotalDistance + Distance);
                Dist = (Conversions.ToLong(Conversion.Str(Distance)) | Conversions.ToLong("000.0")).ToString();
                if (LPoint != L3)
                {
                    if (AtMaxLat == false | AtMaxLat == true & ReachedMaxLatCount == 1)
                    {
                        // frmPointsOnGCR.txtGCR.AppendText(Space(7) & Format(Course, "000"))
                        // frmPointsOnGCR.txtGCR.AppendText(Space(14 - Distance.ToString.Length) & Strings.Format(Distance, "##0.0"))
                        // frmPointsOnGCR.txtGCR.AppendText(Space(13 - Dist.ToString.Length) & Format(Distance, "##0.0"))
                        DatasetGCR.Tables[tablenameGCR].Rows.Add(LongStr, LatStr, Course.ToString("000"), Distance.ToString("##0.0"));
                        // frmPointsOnGCR.txtGCR.AppendText(vbNewLine)
                        LongStr = Math.Abs(LoPointPrintDeg).ToString("0") + '°' + Math.Abs(LoPointPrintMin).ToString("00.0") + "'";
                        if (LoPointPrint > 0d & Math.Abs(LoPointPrint) != 180d)
                        {
                            LongStr += CommonGlobals.g_LongW;
                        }

                        if (LoPointPrint == 0d | Math.Abs(LoPointPrint) == 180d)
                        {
                            LongStr += CommonGlobals.g_LongW;
                        }

                        if (LoPointPrint < 0d & Math.Abs(LoPointPrint) != 180d)
                        {
                            LongStr += CommonGlobals.g_LongE;
                        }

                        LatStr = LPointDeg.ToString("0") + '°' + LPointMin.ToString("00.0") + "'";
                        if (LPoint > 0d)
                        {
                            LatStr += CommonGlobals.g_LatN;
                        }

                        if (LPoint == 0d)
                        {
                            LatStr += CommonGlobals.g_LatN;
                        }

                        if (LPoint < 0d)
                        {
                            LatStr += CommonGlobals.g_LatS;
                        }
                    }
                }

                L1Rhumb = L2Rhumb;
                Lo1Rhumb = Lo2Rhumb;
                if (chkComposite.CheckState == 0 & Math.Abs(LoPoint - Lo2) <= 5d)
                {
                    goto TheLastPoint; // LoPointPrint = Lo2: LPointPrint = L2:
                }

                ReachedMaxLat = false; // IS THIS LINE NEEDED?
                CoursePrevious = (int)Course;
                // The next line sometimes needs -5 and 5 swapped  WHEN?????  #1 REVERSED WANTS FIRST LINE, #5 FORWARD WANTS SECOND LINE,     problem if L2=L3
                // Want third line if L2=L3
                if (L2 != L3)
                {
                    if ((LoPoint > Lo2 & Increment == -5 | LoPoint < Lo2 & Increment == 5) & Math.Abs(LoPoint - Lo2) <= 5d & Math.Abs(Lo2 - Lon32) >= 5d)
                    {
                        goto TheLastPoint; // LoPointPrint = Lo2: LPointPrint = L2:   'THIS LINE IS TROUBLE!!!!
                    }

                    if ((LoPoint > Lo2 & Increment == 5 | LoPoint < Lo2 & Increment == -5) & Math.Abs(LoPoint - Lo2) <= 5d & Math.Abs(Lo2 - Lon32) < 5d)
                    {
                        goto TheLastPoint; // LoPointPrint = Lo2: LPointPrint = L2:   'THIS LINE IS TROUBLE!!!!
                    }
                }

                if (L2 == L3 & (LoPoint > Lo2 & Increment == -5 | LoPoint < Lo2 & Increment == 5) & Math.Abs(LoPoint - Lo2) <= 5d)
                {
                    goto TheLastPoint;
                }
            }

            // TabVal = 6: If L2 = 0 Then TabVal = 5
            if (optL2Lo2GC.Checked == true)
            {
                txtL2Deg.Text = Conversion.Int(Math.Abs(L2)).ToString();
                txtL2Min.Text = ((Math.Abs(L2) - Conversion.Int(Math.Abs(L2))) * 60d).ToString();
                txtLo2Deg.Text = Conversion.Int(Math.Abs(Lo2)).ToString();
                txtLo2Min.Text = ((Math.Abs(Lo2) - Conversion.Int(Math.Abs(Lo2))) * 60d).ToString();
            }

            TabVal = 5;
            if (string.IsNullOrEmpty(txtLo2Deg.Text))
            {
                TabVal = 4;
            }

            if (ModFP(Lo2, 5d) != 0d)
            {
                LongStr = Conversion.Val(txtLo2Deg.Text).ToString("0") + '°' + Conversion.Val(txtLo2Min.Text).ToString("00.0") + "'";
            }

            if (Lo2 != 0d & ModFP(Lo2, 5d) != 0d)
            {
                if (LoPointPrint > 0d & Math.Abs(LoPointPrint) != 180d)
                {
                    LongStr += CommonGlobals.g_LongW;
                }

                if (LoPointPrint == 0d | Math.Abs(LoPointPrint) == 180d)
                {
                    LongStr += CommonGlobals.g_LongW;
                }

                if (LoPointPrint < 0d & Math.Abs(LoPointPrint) != 180d)
                {
                    LongStr += CommonGlobals.g_LongE;
                }
            }

            TabVal = 16;
            if (string.IsNullOrEmpty(txtL2Deg.Text))
            {
                TabVal = 15;
            }

            if (ModFP(Lo2, 5d) != 0d)
            {
                LatStr = Conversion.Val(txtL2Deg.Text).ToString("0") + '°' + Conversion.Val(txtL2Min.Text).ToString("00.0") + "'";
            }

            if (optL2Lo2GC.Checked == false & ModFP(Lo2, 5d) != 0d)
            {
                LatStr += cboL2.Text;
            }

            if (optL2Lo2GC.Checked == true)
            {
                if (Math.Sign(L2) == 1)
                {
                    LatStr += CommonGlobals.g_LatN;
                }

                if (Math.Sign(L2) == 0)
                {
                    LatStr += CommonGlobals.g_LatN;
                }

                if (Math.Sign(L2) == -1)
                {
                    LatStr += CommonGlobals.g_LatS;
                }
            }

        TheLastPoint:
            ;

            // calculate rhumb line course and distance to last point if Lo is not divisible by 5 and destination is not at latitude limit
            if (L2 != L3 | chkComposite.CheckState == 0) // ModFP(Lo2, 5) <> 0 And
            {
                L1Rhumb = LPoint;
                Lo1Rhumb = LoPoint - Increment;
                if (Lo1Rhumb > 180d)
                {
                    Lo1Rhumb = -(360d - Math.Abs(Lo1Rhumb)); // Lo1Rhumb = LoPoint - Increment
                }
                // Lo1Rhumb = LoPoint '- Increment: If Lo1Rhumb > 180 Then Lo1Rhumb = -(360 - Abs(Lo1Rhumb))
                if (Math.Abs(LoPoint - Lo2) <= 5d & Increment == 5)
                {
                    Lo1Rhumb = LoPointPrint;
                    L1Rhumb = LPointPrint;
                }

                if (Math.Abs(LoPoint - Lo2) <= 5d & Increment == -5)
                {
                    Lo1Rhumb = LoPointPrint;
                    L1Rhumb = LPointPrint;
                }

                if (chkComposite.CheckState == 0 & Math.Abs(LoPoint - Lo2) <= 5d & Increment == -5)
                {
                    Lo1Rhumb = LoPointPrint;
                    L1Rhumb = LPointPrint;
                }

                if (optICD.Checked)
                {
                    L2Rhumb = Conversion.Val(txtL2Deg.Text) + Conversion.Val(txtL2Min.Text) / 60d;
                    if (cboL2.Text == "S")
                    {
                        L2Rhumb = -L2Rhumb;
                    }
                }

                if (optL2Lo2GC.Checked)
                {
                    L2Rhumb = L2Deg + L2Min / 60d;
                    if (cboL2.Text == "S")
                    {
                        L2Rhumb = -L2Rhumb;
                    }
                }

                if (optICD.Checked)
                {
                    Lo2Rhumb = Conversion.Val(txtLo2Deg.Text) + Conversion.Val(txtLo2Min.Text) / 60d;
                    if (cboLo2.Text == "E")
                    {
                        Lo2Rhumb = -Lo2Rhumb;
                    }
                }

                if (optL2Lo2GC.Checked)
                {
                    Lo2Rhumb = Lo2Deg + Lo2Min / 60d;
                    if (cboLo2.Text == "E")
                    {
                        Lo2Rhumb = -Lo2Rhumb;
                    }
                }

                if (Lo2Rhumb < 0d)
                {
                    Lo2Rhumb = 360d - Math.Abs(Lo2Rhumb);
                }

                LatDiff = L2Rhumb - L1Rhumb;
                DLo = Lo2Rhumb - Lo1Rhumb;
                // Crossing IDL
                if (Math.Abs(DLo) > 180d)
                {
                    DLo = -Math.Sign(DLo) * (360d - Math.Abs(DLo));
                }

                dphi = Math.Log(Math.Tan(L2Rhumb * Pi / 180d / 2d + Pi / 4d) / Math.Tan(L1Rhumb * Pi / 180d / 2d + Pi / 4d));
                if (Math.Abs(LatDiff) < Math.Sqrt(0.000000000000001d))
                {
                    q = Math.Cos(L1Rhumb * Pi / 180d);
                }
                else
                {
                    q = LatDiff * Pi / 180d / dphi;
                }

                Distance = 60d * Math.Sqrt(q * q * DLo * DLo + LatDiff * LatDiff);
                CourseAngle = 2d * Math.Atan((Math.Sqrt(DLo * Pi / 180d * DLo * Pi / 180d + dphi * dphi) - dphi) / ((DLo + 9.999999E-21d) * Pi / 180d));
                CourseAngleDeg = CourseAngle * 180d / Pi;
                if (LatDiff >= 0d & DLo < 0d)
                {
                    Course = Math.Abs(CourseAngleDeg);
                }

                if (LatDiff >= 0d & DLo >= 0d)
                {
                    Course = 360d - Math.Abs(CourseAngleDeg);
                }

                if (LatDiff < 0d & DLo < 0d)
                {
                    Course = Math.Abs(CourseAngleDeg);
                }

                if (LatDiff < 0d & DLo >= 0d)
                {
                    Course = 360d - Math.Abs(CourseAngleDeg);
                }

                Course = Conversion.Int(Course + 0.5d);
                Distance = Conversion.Int(Distance * 10d + 0.5d) / 10d;
                TotalDistance = (float)(TotalDistance + Distance);
            }

            if (L2 == L3 & (int)chkComposite.CheckState == 1)
            {
                Distance = Distance2; // this and next line removed because of total distance of #6
                TotalDistance = (float)(TotalDistance + Distance);
                if (CoursePrevious > 0 & CoursePrevious < 180)
                {
                    Course = 90d;
                }
                else
                {
                    Course = 270d;
                }
            }

            TotalDistance = (float)(Conversion.Int(TotalDistance * 10f + 0.5d) / 10d);
            Dist = (Conversions.ToLong(Conversion.Str(Distance)) | Conversions.ToLong("000.0")).ToString();
            // frmPointsOnGCR.txtGCR.AppendText(Space(7) & Format(Course, "000"))
            // frmPointsOnGCR.txtGCR.AppendText(Space(13 - Dist.ToString.Length) & Format(Distance, "##0.0") & vbNewLine)
            DatasetGCR.Tables[tablenameGCR].Rows.Add(LongStr, LatStr, Course.ToString("000"), Distance.ToString("##0.0"));
            // frmPointsOnGCR.CurrentY = frmPointsOnGCR.CurrentY + 210
            if (LoPointPrint != Lo2)
            {
                TabVal = 5;
                if (string.IsNullOrEmpty(txtLo2Deg.Text))
                {
                    TabVal = 4;
                }

                if (optICD.Checked)
                {
                    LongStr = Conversion.Val(txtLo2Deg.Text).ToString("0") + '°' + Conversion.Val(txtLo2Min.Text).ToString("00.0") + "'";
                }

                if (optL2Lo2GC.Checked)
                {
                    LongStr = Conversion.Val(Lo2Deg).ToString("0") + '°' + Conversion.Val(Lo2Min).ToString("00.0") + "'";
                }

                if (Lo2 != 0d)
                {
                    LongStr += cboLo2.Text.ToString().Trim();
                }

                TabVal = 3;
                if (string.IsNullOrEmpty(txtL2Deg.Text))
                {
                    TabVal = 2;              // extra space provided by space after single-character in drop-down lists
                }

                if (optICD.Checked)
                {
                    LatStr = Conversion.Val(txtL2Deg.Text).ToString("0") + '°' + Conversion.Val(txtL2Min.Text).ToString("00.0") + "'" + cboL2.Text;
                }

                if (optL2Lo2GC.Checked)
                {
                    LatStr = Conversion.Val(L2Deg).ToString("0") + '°' + Conversion.Val(L2Min).ToString("00.0") + "'" + cboL2.Text;
                }

                CourseStr = "";
                DistanceStr = "";
            }

            DatasetGCR.Tables[tablenameGCR].Rows.Add(LongStr, LatStr, Course.ToString("000"), Distance.ToString("##0.0"));
            // frmPointsOnGCR.txtGCR.AppendText(vbNewLine)
            LongStr = "Total distance";
            LatStr = "on rhumb line";
            CourseStr = "";
            DistanceStr = TotalDistance.ToString("0.0") + " nm";
            DatasetGCR.Tables[tablenameGCR].Rows.Add(LongStr, LatStr, "", TotalDistance.ToString("##0.0"));
            // frmPointsOnGCR.txtGCR.AppendText(Space(13) & "Total rhumb line distance = " & Format(TotalDistance, "0.0") & " nm")
            cmdPoints.Enabled = false;
            GCRArray = new GCRRec[My.MyProject.Forms.frmPointsOnGCR.DGGCR.Rows.Count - 2 + 1];
            for (int i = 0, loopTo3 = My.MyProject.Forms.frmPointsOnGCR.DGGCR.Rows.Count - 2; i <= loopTo3; i++)
            {
                GCRArray[i].LongStr = Conversions.ToString(My.MyProject.Forms.frmPointsOnGCR.DGGCR.Rows[i].Cells[0].Value);
                GCRArray[i].LatStr = Conversions.ToString(My.MyProject.Forms.frmPointsOnGCR.DGGCR.Rows[i].Cells[1].Value);
                GCRArray[i].CTrue = Conversions.ToString(My.MyProject.Forms.frmPointsOnGCR.DGGCR.Rows[i].Cells[2].Value);
                GCRArray[i].GCRDist = Conversions.ToString(My.MyProject.Forms.frmPointsOnGCR.DGGCR.Rows[i].Cells[3].Value);
            }

            GCRAvailable = true;
            DatasetGCR.Dispose();
        }

        private void cmdRhumbPoints_Click()      // V5.6.1
        {
            if (optGreatCircle.Checked == false)
                cmdRhumbPoints.Visible = true;
            My.MyProject.Forms.frmPointsOnRhumb.Show();
            cmdRhumbPoints.Enabled = false;
        }

        private void cmdTraverse_Click(object eventSender, EventArgs eventArgs)
        {
            LatLong();
            // Time
            Time1inMinutes = (int)(60d * Conversion.Val(Strings.Left(txtTime1.Text, 2)) + Conversion.Val(Strings.Right(txtTime1.Text, 2)));
            Time2inMinutes = (int)(60d * Conversion.Val(Strings.Left(txtTime2.Text, 2)) + Conversion.Val(Strings.Right(txtTime2.Text, 2)));
            TimeinMinutes = Time2inMinutes - Time1inMinutes;
            TimeHours = (int)Conversion.Int(TimeinMinutes / 60d);
            TimeMinutes = TimeinMinutes - 60 * TimeHours;
            if (TimeinMinutes < 0)
            {
                ErrorMsgBox("Error:  Time1 later than Time2");
                return;
            }

            if (TimeinMinutes == 0)
            {
                TimeinMinutes = (int)(60d * Conversion.Val(txtTimeh.Text) + Conversion.Val(txtTimem.Text));
            }
            // Distance
            if (Conversion.Val(txtLog2.Text) < Conversion.Val(txtLog1.Text))
            {
                ErrorMsgBox("Error:  Log1 greater than Log2");
                return;
            }

            Distance = Conversion.Val(txtLog2.Text) - Conversion.Val(txtLog1.Text);
            if (string.IsNullOrEmpty(txtLog1.Text) & string.IsNullOrEmpty(txtLog2.Text))
            {
                Distance = Conversion.Val(txtDist.Text); // No log values entered
            }

            if (Distance == 0d)
            {
                Distance = Conversion.Val(txtSpeed.Text) * TimeinMinutes / 60d;
            }

            if (Conversion.Val(txtCourse.Text) >= 0d & Conversion.Val(txtCourse.Text) < 90d)
            {
                CourseAngle = Conversion.Val(txtCourse.Text);
                Prefix = CommonGlobals.g_LatN;
                Suffix = CommonGlobals.g_LongE;
            }

            if (Conversion.Val(txtCourse.Text) >= 90d & Conversion.Val(txtCourse.Text) < 180d)
            {
                CourseAngle = 180d - Conversion.Val(txtCourse.Text);
                Prefix = CommonGlobals.g_LatS;
                Suffix = CommonGlobals.g_LongE;
            }

            if (Conversion.Val(txtCourse.Text) >= 180d & Conversion.Val(txtCourse.Text) < 270d)
            {
                CourseAngle = Conversion.Val(txtCourse.Text) - 180d;
                Prefix = CommonGlobals.g_LatS;
                Suffix = CommonGlobals.g_LongW;
            }

            if (Conversion.Val(txtCourse.Text) >= 270d & Conversion.Val(txtCourse.Text) < 360d)
            {
                CourseAngle = 360d - Conversion.Val(txtCourse.Text);
                Prefix = CommonGlobals.g_LatN;
                Suffix = CommonGlobals.g_LongW;
            }

            if (Math.Abs(L2) > 90d)
            {
                ErrorMsgBox("Distance too large.  Cannot go this far along this rhumb line.");
                return;
            }

            Factor = (float)Math.Cos(CourseAngle * Pi / 180d);
            Factor = (float)(Conversion.Int(Factor * 10f + 0.5d) / 10d);
            LatDiff = Distance * Factor;
            LatDiff = Conversion.Int(LatDiff * 10d + 0.5d) / 10d;
            IntLatDiff = (int)Conversion.Int(LatDiff + 0.5d);
            txtSailings.Clear();
            txtSailings.SelectionAlignment = HorizontalAlignment.Left;
            txtSailings.WordWrap = true;
            txtSailings.AppendText(Strings.Space(50) + "1. C = " + Prefix + Math.Abs(CourseAngle).ToString() + '°' + " " + Suffix + "    factor (C) = " + Math.Abs(Factor).ToString() + Environment.NewLine);
            CompC = (float)(90d - CourseAngle);
            Factor = (float)Math.Cos(CompC * Pi / 180d);
            Factor = (float)(Conversion.Int(Factor * 10f + 0.5d) / 10d);
            Departure = (float)(Distance * Factor);
            Departure = (float)(Conversion.Int(Departure * 10f + 0.5d) / 10d);
            txtSailings.AppendText(Strings.Space(50) + "2. Complement C = " + CompC.ToString() + '°' + "    factor (Comp C) = " + Math.Abs(Factor).ToString() + Environment.NewLine);
            txtSailings.AppendText(Strings.Space(50) + "3. Diff Lat = " + LatDiff.ToString() + "' rounded to " + IntLatDiff.ToString() + "'" + Environment.NewLine);
            txtSailings.AppendText(Strings.Space(50) + "4. Departure = " + Math.Abs(Departure).ToString() + " nm" + Environment.NewLine);
            if (Conversion.Val(txtCourse.Text) > 90d & Conversion.Val(txtCourse.Text) < 270d)
                IntLatDiff = -IntLatDiff;
            L2 = L1 + IntLatDiff / 60d;
            if (Math.Abs(L2) >= 85d)
            {
                ErrorMsgBox("Latitude too high for Simplified Traverse Table, a form of mid-latitude sailing.");
                return;
            }

            L2Deg = (int)Conversion.Int(Math.Abs(L2));
            L2Min = (Math.Abs(L2) - L2Deg) * 60d;
            L2Min = Conversion.Int(L2Min + 0.5d);
            if (L2Min == 60d)
            {
                L2Min = 0d;
                L2Deg = L2Deg + 1;
            }

            if (Lo2Min == 60d)
            {
                Lo2Min = 0d;
                Lo2Deg = Lo2Deg + 1;
            }

            txtSailings.AppendText(Strings.Space(50) + "5. L2 = " + Strings.Format(L2Deg, "0") + '°' + Strings.Format(L2Min, "00") + "'");
            if (Math.Abs(L2) < 0.01d)
            {
                L2 = 0d;
                txtSailings.AppendText("");
            }

            if (L2 > 0d & Math.Abs(L2) > 0.01d)
            {
                txtSailings.AppendText(CommonGlobals.g_LatN);
            }

            if (L2 < 0d & Math.Abs(L2) > 0.01d)
            {
                txtSailings.AppendText(CommonGlobals.g_LatS);
            }

            txtSailings.AppendText(Environment.NewLine);
            L2 = Math.Sign(L2) * (L2Deg + L2Min / 60d);
            Lm = (L1 + L2) / 2d; // Mid-latitude
            Factor = (float)Math.Abs(Math.Cos(Lm * Pi / 180d));
            Factor = (float)(Conversion.Int(Factor * 10f + 0.5d) / 10d);
            LmDeg = (int)Conversion.Int(Math.Abs(Lm));
            LmMin = (float)((Math.Abs(Lm) - LmDeg) * 60d);
            LmMin = (float)(Conversion.Int(LmMin * 10f + 0.5d) / 10d);
            IntLmMin = (int)Conversion.Int(LmMin + 0.5d);
            txtSailings.AppendText(Strings.Space(50) + "6. Mid Lat = " + Strings.Format(LmDeg, "0") + '°' + Strings.Format(LmMin, "00.0") + "'");
            if (Lm >= 0d)
            {
                txtSailings.AppendText(CommonGlobals.g_LatN);
            }

            if (Lm < 0d)
            {
                txtSailings.AppendText(CommonGlobals.g_LatS);
            }

            txtSailings.AppendText(" rounded to " + Strings.Format(LmDeg, "0") + '°' + Strings.Format(IntLmMin, "00") + "'");
            if (Lm >= 0d)
            {
                txtSailings.AppendText(CommonGlobals.g_LatN);
            }

            if (Lm < 0d)
            {
                txtSailings.AppendText(CommonGlobals.g_LatS);
            }

            txtSailings.AppendText(Environment.NewLine);
            txtSailings.AppendText(Strings.Space(54) + "factor (Mid-Lat) = " + Factor.ToString() + Environment.NewLine);
            DLo = Conversion.Int(Departure / Factor * 10f + 0.5d) / 10d;
            IntDLo = (int)(Math.Sign(DLo) * Conversion.Int(Math.Abs(DLo) + 0.5d));
            txtSailings.AppendText(Strings.Space(50) + "7. Diff Lo = " + Math.Abs(DLo).ToString() + "' rounded to " + Math.Abs(IntDLo).ToString() + "'" + Environment.NewLine);
            if (Conversion.Val(txtCourse.Text) > 0d & Conversion.Val(txtCourse.Text) < 180d)
            {
                IntDLo = -IntDLo;
            }

            Lo2 = Lo1 + IntDLo / 60d;
            while (Lo2 >= 360d)
                Lo2 = Lo2 - 360d;
            // Crossing IDL
            if (Math.Abs(Lo2) > 180d)
            {
                Lo2 = -Math.Sign(Lo2) * (360d - Math.Abs(Lo2));
            }

            Lo2Deg = (int)Conversion.Int(Math.Abs(Lo2));
            Lo2Min = (Math.Abs(Lo2) - Lo2Deg) * 60d;
            Lo2Min = Conversion.Int(Lo2Min + 0.5d);
            txtSailings.AppendText(Strings.Space(50) + "8. Lo2 = " + Strings.Format(Lo2Deg, "0") + '°' + Strings.Format(Lo2Min, "00") + "'");
            if (Math.Abs(Lo2) < 0.01d)
            {
                Lo2 = 0d;
                txtSailings.AppendText("");
            }

            if (Math.Abs(Lo2) > 179.999d)
                txtSailings.AppendText("");
            if (Lo2 > 0d & Math.Abs(Lo2) < 179.999d)
            {
                txtSailings.AppendText(CommonGlobals.g_LongW);
            }

            if (Lo2 < 0d & Math.Abs(Lo2) < 179.999d)
            {
                txtSailings.AppendText(CommonGlobals.g_LongE);
            }

            txtSailings.AppendText(Environment.NewLine);
            txtSailings.AppendText(Strings.Space(50) + "Answer:  Arrival Position = L2 " + Strings.Format(L2Deg, "0") + '°' + Strings.Format(L2Min, "00") + "'");
            if (Math.Abs(L2) < 0.01d)
            {
                L2 = 0d;
                txtSailings.AppendText("");
            }

            if (L2 > 0d & Math.Abs(L2) > 0.01d)
            {
                txtSailings.AppendText(CommonGlobals.g_LatN);
            }

            if (L2 < 0d & Math.Abs(L2) > 0.01d)
            {
                txtSailings.AppendText(CommonGlobals.g_LatS);
            }

            txtSailings.AppendText("  Lo2 " + Strings.Format(Lo2Deg, "0") + '°' + Strings.Format(Lo2Min, "00") + "'");
            if (Math.Abs(Lo2) < 0.01d)
            {
                Lo2 = 0d;
                txtSailings.AppendText("");
            }

            if (Math.Abs(Lo2) > 179.999d)
            {
                txtSailings.AppendText("");
            }

            if (Lo2 > 0d & Math.Abs(Lo2) < 179.999d)
            {
                txtSailings.AppendText(CommonGlobals.g_LongW);
            }

            if (Lo2 < 0d & Math.Abs(Lo2) < 179.999d)
            {
                txtSailings.AppendText(CommonGlobals.g_LongE);
            }

            txtSailings.AppendText(" by Simplified Traverse Table" + Environment.NewLine);
            if (string.IsNullOrEmpty(txtDist.Text) & string.IsNullOrEmpty(txtTimeh.Text) & string.IsNullOrEmpty(txtTimem.Text) & !string.IsNullOrEmpty(txtTime1.Text))
            {
                txtSailings.AppendText(Strings.Space(10) + "Run Time  " + Strings.Format(TimeHours, "##0") + "h" + Strings.Format(TimeMinutes, "00") + "m" + Environment.NewLine);
            }

            if (string.IsNullOrEmpty(txtDist.Text))
            {
                txtSailings.AppendText(Strings.Space(10) + "Distance   " + Strings.Format(Distance, "##0.0") + " nm");
            }

            return;
        }

        private void FormSailings_FormClosed(object eventSender, FormClosedEventArgs eventArgs)
        {
            // Cleanup()
        }

        private void optAccurateRhumb_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optAccurateRhumb.Checked)
            {
                if (optAccurateRhumb.Checked == true)
                {
                    cmdTraverse.Visible = false;
                    cmdRhumbPoints.Visible = true;
                }

                chkComposite.Visible = false;
                Frame3.Visible = false;
                lblLimLat.Visible = false;
                txtL3Deg.Visible = false;
                Label16.Visible = false;
                cboL3.Visible = false;
                optMethod1.Checked = false;
                optMethod2.Checked = false;
                txtL3Min.Visible = false;
                Label15.Visible = false;
                frameCalculate.Visible = true;
                frameCalculateGC.Visible = false;
                Flag = true;
                if (optL2Lo2.Checked == true)
                {
                    // optL2Lo2.Checked = False
                    optL2Lo2_CheckedChanged(optL2Lo2, new EventArgs());
                }

                if (optCD.Checked == true)
                {
                    // optCD.Checked = False
                    optCD_CheckedChanged(optCD, new EventArgs());
                }

                if (optSD.Checked == true)
                {
                    // optCD.Checked = False
                    optSD_CheckedChanged(optSD, new EventArgs());
                }

                Flag = false;
                optICD.Visible = false;
                lblInitial.Visible = false;
                optL2Lo2.Visible = true;
                optL2Lo2GC.Visible = false;
                optCD.Visible = true;
                optSD.Visible = true;
                chkML.Visible = false;
                txtMLDeg.Visible = false;
                Label4.Visible = false;
                cboMLmin.Visible = false;
                Label1.Visible = false;
                cboML.Visible = false;
                cmdPoints.Visible = false;
                // cmdPoints.Enabled = False
                txtL1Deg_TextChanged(txtL1Deg, new EventArgs());
                txtL2Deg_TextChanged(txtL2Deg, new EventArgs());
                LatLong();
                if (L1 != L2 | Lo1 != Lo2)
                {
                    // cmdCalculate_Click(cmdCalculate, New System.EventArgs())
                    cmdCalculate.PerformClick();
                }
            }
        }

        private void optGreatCircle_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optGreatCircle.Checked)
            {
                if (optGreatCircle.Checked == true)
                {
                    cmdTraverse.Visible = false;
                    ToolTip1.SetToolTip(txtL1Deg, "Range 0 to 90");
                    ToolTip1.SetToolTip(txtL2Deg, "Range 0 to 90");
                    cmdRhumbPoints.Visible = false;
                }

                chkComposite.CheckState = CheckState.Unchecked;
                if (optGreatCircle.Checked == true & optICD.Checked == true)
                {
                    chkComposite.Visible = true;
                }

                if (optGreatCircle.Checked == true)
                {
                    chkDriftAngle.Visible = false;
                }

                frameCalculate.Visible = false;
                frameCalculateGC.Visible = true;
                Flag = true;
                if (optL2Lo2GC.Checked == true)
                {
                    // optL2Lo2GC.Checked = False
                    optL2Lo2GC_CheckedChanged(optL2Lo2GC, new EventArgs());
                }

                if (optICD.Checked == true)
                {
                    // optICD.Checked = False
                    optICD_CheckedChanged(optICD, new EventArgs());
                }

                Flag = false;
                cmdPoints.Visible = true;
                // cmdPoints.Enabled = False
                optL2Lo2.Visible = false;
                optL2Lo2GC.Visible = true;
                optCD.Visible = false;
                // optCD = True
                optSD.Visible = false;
                optICD.Visible = true;
                // optICD.Value = True
                cmdClearSwap.Visible = true;
                // cmdClearSwap.Enabled = True
                chkML.Visible = false;
                txtMLDeg.Visible = false;
                Label4.Visible = false;
                cboMLmin.Visible = false;
                Label1.Visible = false;
                cboML.Visible = false;
                txtL1Deg_TextChanged(txtL1Deg, new EventArgs());
                txtL2Deg_TextChanged(txtL2Deg, new EventArgs());
                LatLong();
                if (L1 != L2 | Lo1 != Lo2)
                {
                    // cmdCalculate_Click(cmdCalculate, New System.EventArgs())
                    cmdCalculate.PerformClick();
                }
            }
        }

        private void optICD_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optICD.Checked)
            {
                if (optGreatCircle.Checked == true)
                {
                    chkComposite.Visible = true;
                }

                // If Flag = False Then
                // cmdClearAll_Click(cmdClearAll, New System.EventArgs()) 'If optL2Lo2.Value = True Then
                // End If
                // cmdClearAll_Click
                // txtTimeh.Text = ""
                // txtTimem.Text = ""
                lblL2.Visible = true;
                txtL2Deg.Visible = true;
                lblLDeg.Visible = true;
                txtL2Min.Visible = true;
                lblLMin.Visible = true;
                cboL2.Visible = true;
                lblLo2.Visible = true;
                txtLo2Deg.Visible = true;
                lblLoDeg.Visible = true;
                txtLo2Min.Visible = true;
                lblLoMin.Visible = true;
                cboLo2.Visible = true;
                lblCourse.Visible = false;
                txtCourse.Visible = false;
                lblInitial.Visible = false;
                lblCourseDeg.Visible = false;
                lblDistance.Visible = false;
                txtDist.Visible = false;
                lblnm.Visible = false;
                lblor.Visible = false;
                lblor2.Visible = false;
                lblSpeed.Visible = false;
                txtSpeed.Visible = false;
                lblkn.Visible = false;
                lblTime.Visible = false;
                txtTimeh.Visible = false;
                lblh.Visible = false;
                txtTimem.Visible = false;
                lblm.Visible = false;
                cmdClearSwap.Visible = true;
                // cmdClearSwap.Enabled = True
                lblDRL.Visible = false;
                lblDRLo.Visible = false;
                lblFixL.Visible = false;
                lblFixLo.Visible = false;
                lblLog1.Visible = false;
                lblLog2.Visible = false;
                lblTime1.Visible = false;
                lblTime2.Visible = false;
                lblLog1nm.Visible = false;
                lblLog2nm.Visible = false;
                // 'txtTime1.Text = ""
                // 'txtTime2.Text = ""
                txtLog1.Visible = false;
                txtLog2.Visible = false;
                txtTime1.Visible = false;
                txtTime2.Visible = false;
                // Shape1.Visible = False
                // Line2.Visible = False
                // Line3.Visible = False
                // Line4.Visible = False
                // Line5.Visible = False
                // Line6.Visible = False
                Label14.Visible = false;
                Label13.Visible = false;
                Label12.Visible = false;
                Label11.Visible = false;
                Label10.Visible = false;
                Label9.Visible = false;
                txtFix1LD.Visible = false;
                txtFix1LM.Visible = false;
                txtFix1LoD.Visible = false;
                txtFix1LoM.Visible = false;
                cboFix1L.Visible = false;
                cboFix1Lo.Visible = false;
                txtFix1LD.Text = "";
                txtFix1LM.Text = "";
                txtFix1LoD.Text = "";
                txtFix1LoM.Text = "";
                if (optCD.Checked == true)
                {
                    chkDriftAngle.Visible = false;
                }

                chkDriftAngle.CheckState = CheckState.Unchecked;
                // End If
            }
        }

        private void optL2Lo2GC_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optL2Lo2GC.Checked)
            {
                chkComposite.Visible = false;
                Frame3.Visible = false;
                lblLimLat.Visible = false;
                txtL3Deg.Visible = false;
                Label16.Visible = false;
                cboL3.Visible = false;
                optMethod1.Checked = false;
                optMethod2.Checked = false;
                txtL3Min.Visible = false;
                Label15.Visible = false;
                // If Flag = False Then
                // cmdClearAll_Click(cmdClearAll, New System.EventArgs()) 'If optL2Lo2.Value = True Then
                // End If
                // cmdClearAll_Click
                // txtTimeh.Text = ""
                // txtTimem.Text = ""
                lblL2.Visible = false;
                txtL2Deg.Visible = false;
                lblLDeg.Visible = false;
                txtL2Min.Visible = false;
                lblLMin.Visible = false;
                cboL2.Visible = false;
                lblLo2.Visible = false;
                txtLo2Deg.Visible = false;
                lblLoDeg.Visible = false;
                txtLo2Min.Visible = false;
                lblLoMin.Visible = false;
                cboLo2.Visible = false;
                lblCourse.Visible = true;
                txtCourse.Visible = true;
                lblInitial.Visible = true;
                lblCourseDeg.Visible = true;
                lblDistance.Visible = true;
                txtDist.Visible = true;
                lblnm.Visible = true;
                lblor.Visible = false;
                lblor2.Visible = false;
                lblSpeed.Visible = false;
                txtSpeed.Visible = false;
                lblkn.Visible = false;
                lblTime.Visible = false;
                txtTimeh.Visible = false;
                lblh.Visible = false;
                txtTimem.Visible = false;
                lblm.Visible = false;
                cmdClearSwap.Visible = true;
                // cmdClearSwap.Enabled = True
                lblDRL.Visible = false;
                lblDRLo.Visible = false;
                lblFixL.Visible = false;
                lblFixLo.Visible = false;
                lblLog1.Visible = false;
                lblLog2.Visible = false;
                lblTime1.Visible = false;
                lblTime2.Visible = false;
                lblLog1nm.Visible = false;
                lblLog2nm.Visible = false;
                // 'txtTime1.Text = ""
                // 'txtTime2.Text = ""
                txtLog1.Visible = false;
                txtLog2.Visible = false;
                txtTime1.Visible = false;
                txtTime2.Visible = false;
                // Shape1.Visible = False
                // Line2.Visible = False
                // Line3.Visible = False
                // Line4.Visible = False
                // Line5.Visible = False
                // Line6.Visible = False
                chkDriftAngle.Visible = false;
                chkDriftAngle.CheckState = CheckState.Unchecked;
                // End If
            }
        }

        private void optMercator_Click()
        {
            
            if (optMercatorE.Checked == true | optMercatorS.Checked == true)
            {
                cmdTraverse.Visible = false;
            }

            chkComposite.Visible = false;
            Frame3.Visible = false;
            lblLimLat.Visible = false;
            txtL3Deg.Visible = false;
            Label16.Visible = false;
            cboL3.Visible = false;
            optMethod1.Checked = false;
            optMethod2.Checked = false;
            txtL3Min.Visible = false;
            Label15.Visible = false;
            frameCalculate.Visible = true;
            frameCalculateGC.Visible = false;
            Flag = true;
            if (optL2Lo2.Checked == true)
            {
                // optL2Lo2.Checked = False
                optL2Lo2_CheckedChanged(optL2Lo2, new EventArgs());
            }

            if (optCD.Checked == true)
            {
                // optCD.Checked = False
                optCD_CheckedChanged(optCD, new EventArgs());
            }

            if (optSD.Checked == true)
            {
                // optCD.Checked = False
                optSD_CheckedChanged(optSD, new EventArgs());
            }

            Flag = false;
            optICD.Visible = false;
            lblInitial.Visible = false;
            optL2Lo2.Visible = true;
            optL2Lo2GC.Visible = false;
            optCD.Visible = true;
            optSD.Visible = true;
            chkML.Visible = false;
            txtMLDeg.Visible = false;
            Label4.Visible = false;
            cboMLmin.Visible = false;
            Label1.Visible = false;
            cboML.Visible = false;
            cmdPoints.Visible = false;
            // cmdPoints.Enabled = False
            txtL1Deg_TextChanged(txtL1Deg, new EventArgs());
            txtL2Deg_TextChanged(txtL2Deg, new EventArgs());
            // cmdCalculate_Click(cmdCalculate, New System.EventArgs())
            cmdCalculate.PerformClick();
        }

        private void optMercatorE_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optMercatorE.Checked)
            {
                // If optMercatorE = True Then
                cmdTraverse.Visible = false;
                ToolTip1.SetToolTip(txtL1Deg, "Range 0 to 89");
                ToolTip1.SetToolTip(txtL2Deg, "Range 0 to 89");
                cmdRhumbPoints.Visible = true;
                chkComposite.Visible = false;
                Frame3.Visible = false;
                lblLimLat.Visible = false;
                txtL3Deg.Visible = false;
                Label16.Visible = false;
                cboL3.Visible = false;
                optMethod1.Checked = false;
                optMethod2.Checked = false;
                txtL3Min.Visible = false;
                Label15.Visible = false;
                frameCalculate.Visible = true;
                frameCalculateGC.Visible = false;
                Flag = true;
                if (optL2Lo2.Checked == true)
                {
                    // optL2Lo2.Checked = False
                    optL2Lo2_CheckedChanged(optL2Lo2, new EventArgs());
                }

                if (optCD.Checked == true)
                {
                    // optCD.Checked = False
                    optCD_CheckedChanged(optCD, new EventArgs());
                }

                if (optSD.Checked == true)
                {
                    // optCD.Checked = False
                    optSD_CheckedChanged(optSD, new EventArgs());
                }

                Flag = false;
                optICD.Visible = false;
                lblInitial.Visible = false;
                optL2Lo2.Visible = true;
                optL2Lo2GC.Visible = false;
                optCD.Visible = true;
                optSD.Visible = true;
                chkML.Visible = false;
                txtMLDeg.Visible = false;
                Label4.Visible = false;
                cboMLmin.Visible = false;
                Label1.Visible = false;
                cboML.Visible = false;
                cmdPoints.Visible = false;
                // cmdPoints.Enabled = False
                txtL1Deg_TextChanged(txtL1Deg, new EventArgs());
                txtL2Deg_TextChanged(txtL2Deg, new EventArgs());
                LatLong();
                if (L1 != L2 | Lo1 != Lo2)
                {
                    // cmdCalculate_Click(cmdCalculate, New System.EventArgs())
                    cmdCalculate.PerformClick();
                }
            }
        }

        private void optMercatorS_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optMercatorS.Checked)
            {
                // If optMercatorS = True Then
                cmdTraverse.Visible = false;
                ToolTip1.SetToolTip(txtL1Deg, "Range 0 to 89");
                ToolTip1.SetToolTip(txtL2Deg, "Range 0 to 89");
                cmdRhumbPoints.Visible = true;
                chkComposite.Visible = false;
                Frame3.Visible = false;
                lblLimLat.Visible = false;
                txtL3Deg.Visible = false;
                Label16.Visible = false;
                cboL3.Visible = false;
                optMethod1.Checked = false;
                optMethod2.Checked = false;
                txtL3Min.Visible = false;
                Label15.Visible = false;
                frameCalculate.Visible = true;
                frameCalculateGC.Visible = false;
                Flag = true;
                if (optL2Lo2.Checked == true)
                {
                    // optL2Lo2.Checked = False
                    optL2Lo2_CheckedChanged(optL2Lo2, new EventArgs());
                }

                if (optCD.Checked == true)
                {
                    // optCD.Checked = False
                    optCD_CheckedChanged(optCD, new EventArgs());
                }

                if (optSD.Checked == true)
                {
                    // optCD.Checked = False
                    optSD_CheckedChanged(optSD, new EventArgs());
                }

                Flag = false;
                optICD.Visible = false;
                lblInitial.Visible = false;
                optL2Lo2.Visible = true;
                optL2Lo2GC.Visible = false;
                optCD.Visible = true;
                optSD.Visible = true;
                chkML.Visible = false;
                txtMLDeg.Visible = false;
                Label4.Visible = false;
                cboMLmin.Visible = false;
                Label1.Visible = false;
                cboML.Visible = false;
                cmdPoints.Visible = false;
                // cmdPoints.Enabled = False
                txtL1Deg_TextChanged(txtL1Deg, new EventArgs());
                txtL2Deg_TextChanged(txtL2Deg, new EventArgs());
                LatLong();
                if (L1 != L2 | Lo1 != Lo2)
                {
                    // cmdCalculate_Click(cmdCalculate, New System.EventArgs())
                    cmdCalculate.PerformClick();
                }
            }
        }

        private string PtsOnCompStr = "Points on a Composite Route";
        private string PtsOnCompStrM1 = "Points on Composite Route, Method 1";
        private string PtsOnCompStrM2 = "Points on Composite Route, Method 2";

        private void optMethod1_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optMethod1.Checked)
            {
                if (string.IsNullOrEmpty(txtL3Deg.Text))
                {
                    ErrorMsgBox("Enter a latitude limit from 1 to 89 degrees");
                    return;
                }

                cmdPoints.Text = PtsOnCompStr;
                cmdCalculate_Click(eventSender, eventArgs);
                My.MyProject.Forms.frmPointsOnGCR.Text = PtsOnCompStrM1;
            }
        }

        private void optMethod2_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optMethod2.Checked)
            {
                if (string.IsNullOrEmpty(txtL3Deg.Text))
                {
                    ErrorMsgBox("Enter a latitude limit from 1 to 89 degrees");
                    return;
                }

                cmdPoints.Text = PtsOnCompStr;
                cmdCalculate_Click(eventSender, eventArgs);
                My.MyProject.Forms.frmPointsOnGCR.Text = PtsOnCompStrM2;
            }
        }

        private void optMidLat_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optMidLat.Checked == true)
            {
                if (optMidLat.Checked == true)
                {
                    ToolTip1.SetToolTip(txtL1Deg, "Range 0 to 84");
                    ToolTip1.SetToolTip(txtL2Deg, "Range 0 to 84");
                    cmdRhumbPoints.Visible = true;
                }

                if (optMidLat.Checked == true & optL2Lo2.Checked == true)
                {
                    cmdTraverse.Visible = true;
                }

                chkComposite.Visible = false;
                Frame3.Visible = false;
                lblLimLat.Visible = false;
                txtL3Deg.Visible = false;
                Label16.Visible = false;
                cboL3.Visible = false;
                optMethod1.Checked = false;
                optMethod2.Checked = false;
                txtL3Min.Visible = false;
                Label15.Visible = false;
                frameCalculate.Visible = true;
                frameCalculateGC.Visible = false;
                Flag = true;
                if (optL2Lo2.Checked == true)
                {
                    // optL2Lo2.Checked = False
                    optL2Lo2_CheckedChanged(optL2Lo2, new EventArgs());
                }

                if (optCD.Checked == true)
                {
                    // optCD.Checked = False
                    optCD_CheckedChanged(optCD, new EventArgs());
                }

                if (optSD.Checked == true)
                {
                    // optCD.Checked = False
                    optSD_CheckedChanged(optSD, new EventArgs());
                }

                Flag = false;
                optICD.Visible = false;
                lblInitial.Visible = false;
                optL2Lo2GC.Visible = false;
                optL2Lo2.Visible = true;
                optCD.Visible = true;
                optSD.Visible = true;
                chkML.Visible = true;
                txtMLDeg.Visible = true;
                Label4.Visible = true;
                cboMLmin.Visible = true;
                Label1.Visible = true;
                cboML.Visible = true;
                cmdPoints.Visible = false;
                // cmdPoints.Enabled = False
                txtL1Deg_TextChanged(txtL1Deg, new EventArgs());
                txtL2Deg_TextChanged(txtL2Deg, new EventArgs());
                LatLong();
                if (L1 != L2 | Lo1 != Lo2)
                {
                    // cmdCalculate_Click(cmdCalculate, New System.EventArgs())
                    cmdCalculate.PerformClick();
                }
            }
        }

        private void optL2Lo2_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optL2Lo2.Checked)
            {
                if (optMidLat.Checked == true & optL2Lo2.Checked == true)
                {
                    cmdTraverse.Visible = true;
                }
                // If Flag = False Then
                // cmdClearAll_Click(cmdClearAll, New System.EventArgs())
                // End If
                lblL2.Visible = false;
                txtL2Deg.Visible = false;
                lblLDeg.Visible = false;
                txtL2Min.Visible = false;
                lblLMin.Visible = false;
                cboL2.Visible = false;
                lblLo2.Visible = false;
                txtLo2Deg.Visible = false;
                lblLoDeg.Visible = false;
                txtLo2Min.Visible = false;
                lblLoMin.Visible = false;
                cboLo2.Visible = false;
                lblCourse.Visible = true;
                txtCourse.Visible = true;
                lblCourseDeg.Visible = true;
                lblDistance.Visible = true;
                txtDist.Visible = true;
                lblnm.Visible = true;
                lblor.Visible = true;
                lblor2.Visible = false;
                lblSpeed.Visible = true;
                txtSpeed.Visible = true;
                lblkn.Visible = true;
                lblTime.Visible = true;
                txtTimeh.Visible = true;
                lblh.Visible = true;
                txtTimem.Visible = true;
                lblm.Visible = true;
                cmdClearSwap.Visible = true;
                lblDRL.Visible = false;
                lblDRLo.Visible = false;
                lblFixL.Visible = false;
                lblFixLo.Visible = false;
                lblLog1.Visible = true;
                lblLog2.Visible = true;
                lblTime1.Visible = true;
                lblTime2.Visible = true;
                lblLog1nm.Visible = true;
                lblLog2nm.Visible = true;
                txtLog1.Visible = true;
                txtLog2.Visible = true;
                txtTime1.Visible = true;
                txtTime2.Visible = true;
                // Shape1.Visible = True
                // Line2.Visible = True
                // Line3.Visible = True
                // Line4.Visible = True
                // Line5.Visible = True
                // Line6.Visible = True
                Label14.Visible = false;
                Label13.Visible = false;
                Label12.Visible = false;
                Label11.Visible = false;
                Label10.Visible = false;
                Label9.Visible = false;
                txtFix1LD.Visible = false;
                txtFix1LM.Visible = false;
                txtFix1LoD.Visible = false;
                txtFix1LoM.Visible = false;
                cboFix1L.Visible = false;
                cboFix1Lo.Visible = false;
                txtFix1LD.Text = "";
                txtFix1LM.Text = "";
                txtFix1LoD.Text = "";
                txtFix1LoM.Text = "";
                chkDriftAngle.Visible = false;
                chkDriftAngle.Checked = false;
                // End If
            }
        }

        private void optCD_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            {
                if (optCD.Checked == true)
                {
                    cmdTraverse.Visible = false;
                }
                // If Flag = False Then
                // cmdClearAll_Click(cmdClearAll, New System.EventArgs()) 'If optCD.Value = True Then
                // End If

                lblL2.Visible = true;
                txtL2Deg.Visible = true;
                lblLDeg.Visible = true;
                txtL2Min.Visible = true;
                lblLMin.Visible = true;
                cboL2.Visible = true;
                lblLo2.Visible = true;
                txtLo2Deg.Visible = true;
                lblLoDeg.Visible = true;
                txtLo2Min.Visible = true;
                lblLoMin.Visible = true;
                cboLo2.Visible = true;
                lblCourse.Visible = false;
                txtCourse.Visible = false;
                lblCourseDeg.Visible = false;
                lblDistance.Visible = false;
                txtDist.Visible = false;
                lblnm.Visible = false;
                lblor.Visible = false;
                lblor2.Visible = false;
                lblSpeed.Visible = false;
                txtSpeed.Visible = false;
                lblkn.Visible = false;
                lblTime.Visible = false;
                txtTimeh.Visible = false;
                lblh.Visible = false;
                txtTimem.Visible = false;
                lblm.Visible = false;
                cmdClearSwap.Visible = true;
                lblDRL.Visible = false;
                lblDRLo.Visible = false;
                lblFixL.Visible = false;
                lblFixLo.Visible = false;
                lblLog1.Visible = false;
                lblLog2.Visible = false;
                lblTime1.Visible = false;
                lblTime2.Visible = false;
                lblLog1nm.Visible = false;
                lblLog2nm.Visible = false;
                txtLog1.Visible = false;
                txtLog2.Visible = false;
                txtTime1.Visible = false;
                txtTime2.Visible = false;
                // Shape1.Visible = False
                // Line2.Visible = False
                // Line3.Visible = False
                // Line4.Visible = False
                // Line5.Visible = False
                // Line6.Visible = False
                chkDriftAngle.Visible = false;
                chkDriftAngle.CheckState = CheckState.Unchecked;
            }
        }

        private void optSD_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            {
                if (optSD.Checked == true)
                {
                    cmdTraverse.Visible = false;
                }
                // If Flag = False Then
                // ClearAll_Click(cmdClearAll, New System.EventArgs()) 'If optSD.Value = True Then
                // End If
                lblL2.Visible = true;
                txtL2Deg.Visible = true;
                lblLDeg.Visible = true;
                txtL2Min.Visible = true;
                lblLMin.Visible = true;
                cboL2.Visible = true;
                lblLo2.Visible = true;
                txtLo2Deg.Visible = true;
                lblLoDeg.Visible = true;
                txtLo2Min.Visible = true;
                lblLoMin.Visible = true;
                cboLo2.Visible = true;
                lblCourse.Visible = false;
                txtCourse.Visible = false;
                lblCourseDeg.Visible = false;
                lblDistance.Visible = false;
                txtDist.Visible = false;
                lblnm.Visible = false;
                lblor.Visible = false;
                lblor2.Visible = true;
                lblSpeed.Visible = false;
                txtSpeed.Visible = false;
                lblkn.Visible = false;
                lblTime.Visible = true;
                txtTimeh.Visible = true;
                lblh.Visible = true;
                txtTimem.Visible = true;
                lblm.Visible = true;
                cmdClearSwap.Visible = false;
                lblDRL.Visible = true;
                lblDRLo.Visible = true;
                lblFixL.Visible = true;
                lblFixLo.Visible = true;
                lblLog1.Visible = false;
                lblLog2.Visible = false;
                lblTime1.Visible = true;
                lblTime2.Visible = true;
                lblLog1nm.Visible = false;
                lblLog2nm.Visible = false;
                txtLog1.Visible = false;
                txtLog2.Visible = false;
                txtTime1.Visible = true;
                txtTime2.Visible = true;
                // Shape1.Visible = False
                // Line2.Visible = False
                // Line3.Visible = False
                // Line4.Visible = False
                // Line5.Visible = True
                // Line6.Visible = False
                if (optSD.Checked == true)
                {
                    chkDriftAngle.Visible = true;
                }
            }
        }

        private void txtL1Deg_TextChanged(object eventSender, EventArgs eventArgs)
        {
            txtL1Deg.BackColor = SystemColors.Window;
            if (optGreatCircle.Checked == true & Conversion.Val(txtL1Deg.Text) > 90d | (optMercatorE.Checked == true | optMercatorS.Checked == true | optAccurateRhumb.Checked == true) & Conversion.Val(txtL1Deg.Text) > 89d | optMidLat.Checked == true & Conversion.Val(txtL1Deg.Text) > 84d) // Or (Val(txtL1Deg.Text) = 90 And Val(txtL1Min.Text) <> 0) Then
            {
                txtL1Deg.BackColor = Color.Red;
                ErrorMsgBox("Out of Range");
            }

            if ((optMercatorE.Checked == true | optMercatorS.Checked == true | optAccurateRhumb.Checked == true) & Conversion.Val(txtL1Deg.Text) <= 89d | optMidLat.Checked == true & Conversion.Val(txtL1Deg.Text) <= 84d)
            {
                txtL1Min.BackColor = SystemColors.Window;
            }

            if (optGreatCircle.Checked == true)
            {
                if (Conversion.Val(txtL1Deg.Text) != 90d)
                {
                    txtL1Min.Enabled = true;
                    txtL1Min.BackColor = SystemColors.Window;
                }

                if (Conversion.Val(txtL1Deg.Text) == 90d)
                {
                    txtL1Min.Text = "";
                    txtL1Min.Enabled = false;
                    txtL1Min.BackColor = Color.Gray;
                }
                // txtL1Deg.ForeColor = System.Drawing.SystemColors.InactiveBorder
            }
        }

        private void txtL1Deg_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            int KeyAscii = Strings.Asc(eventArgs.KeyChar);
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

        private void txtL1Deg_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if ((optMercatorE.Checked == true | optMercatorS.Checked == true | optAccurateRhumb.Checked == true) & Conversion.Val(txtL1Deg.Text) > 89d | optMidLat.Checked == true & Conversion.Val(txtL1Deg.Text) > 84d)
            {
                KeepFocus = true;
            }

            if (optGreatCircle.Checked == true & Conversion.Val(txtL1Deg.Text) > 90d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtL1Deg_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtL1Deg;
            SelectAllText(ref argTB);
            txtL1Deg = argTB;
        }

        private void txtL1Min_TextChanged(object eventSender, EventArgs eventArgs)
        {
            txtL1Min.BackColor = SystemColors.Window;
            if (Conversion.Val(txtL1Min.Text) > 59.9d)
            {
                txtL1Min.BackColor = Color.Red;
                ErrorMsgBox("Out of Range");
            }
        }

        private void txtL1Min_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            int KeyAscii = Strings.Asc(eventArgs.KeyChar);
            switch (KeyAscii)
            {
                case var @case when Strings.Asc("0") <= @case && @case <= Strings.Asc("9"):
                    {
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                case (short)('.'): // only allows one decimal point
                    {
                        if (Conversions.ToBoolean(Strings.InStr(txtL1Min.Text, ".")))
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

        private void txtL1Min_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtL1Min.Text) > 59.9d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtL1Min_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtL1Min;
            SelectAllText(ref argTB);
            txtL1Min = argTB;
        }

        private void txtLo1Deg_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtLo1Deg.Text) != 180d)
            {
                txtLo1Min.Enabled = true;
            }

            if (Conversion.Val(txtLo1Deg.Text) == 180d)
            {
                txtLo1Min.Text = "";
                txtLo1Min.Enabled = false;
                txtLo1Min.BackColor = Color.Gray;
            }

            txtLo1Deg.BackColor = SystemColors.Window;
            if (Conversion.Val(txtLo1Deg.Text) > 180d | Conversion.Val(txtLo1Deg.Text) == 180d & Conversion.Val(txtLo1Min.Text) != 0d)
            {
                txtLo1Deg.BackColor = Color.Red;
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtLo1Deg.Text) < 180d)
            {
                txtLo1Min.BackColor = SystemColors.Window;
            }
        }

        private void txtLo1Deg_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            int KeyAscii = Strings.Asc(eventArgs.KeyChar);
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

        private void txtLo1Deg_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtLo1Deg.Text) > 180d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtLo1Deg_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtLo1Deg;
            SelectAllText(ref argTB);
            txtLo1Deg = argTB;
        }

        private void txtLo1Min_TextChanged(object eventSender, EventArgs eventArgs)
        {
            txtLo1Min.BackColor = SystemColors.Window;
            if (Conversion.Val(txtLo1Min.Text) > 59.9d)
            {
                txtLo1Min.BackColor = Color.Red;
                ErrorMsgBox("Out of Range");
            }
        }

        private void txtLo1Min_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            int KeyAscii = Strings.Asc(eventArgs.KeyChar);
            switch (KeyAscii)
            {
                case var @case when Strings.Asc("0") <= @case && @case <= Strings.Asc("9"):
                    {
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                case (short)('.'): // only allows one decimal point
                    {
                        if (Conversions.ToBoolean(Strings.InStr(txtLo1Min.Text, ".")))
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

        private void txtLo1Min_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtLo1Min.Text) > 59.9d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtLo1Min_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtLo1Min;
            SelectAllText(ref argTB);
            txtLo1Min = argTB;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            GCRArray = new GCRRec[1];
            GCRAvailable = false;
            Close();
        }

        private void txtL2Deg_TextChanged(object eventSender, EventArgs eventArgs)
        {
            txtL2Deg.BackColor = SystemColors.Window;
            if (optGreatCircle.Checked == true & Conversion.Val(txtL2Deg.Text) > 90d | (optMercatorE.Checked == true | optMercatorS.Checked == true | optAccurateRhumb.Checked == true) & Conversion.Val(txtL2Deg.Text) > 89d | optMidLat.Checked == true & Conversion.Val(txtL2Deg.Text) > 84d) // Or (Val(txtL2Deg.Text) = 90 And Val(txtL2Min.Text) <> 0) Then
            {
                txtL2Deg.BackColor = Color.Red;
                ErrorMsgBox("Out of Range");
            }

            if ((optMercatorE.Checked == true | optMercatorS.Checked == true | optAccurateRhumb.Checked == true) & Conversion.Val(txtL2Deg.Text) <= 89d | optMidLat.Checked == true & Conversion.Val(txtL2Deg.Text) <= 84d)
            {
                txtL2Min.BackColor = SystemColors.Window;
            }

            if (optGreatCircle.Checked == true)
            {
                if (Conversion.Val(txtL2Deg.Text) != 90d)
                {
                    txtL2Min.Enabled = true;
                    txtL2Min.BackColor = SystemColors.Window;
                }

                if (Conversion.Val(txtL2Deg.Text) == 90d)
                {
                    txtL2Min.Text = "";
                    txtL2Min.Enabled = false;
                    txtL2Min.BackColor = SystemColors.Window;    // ColorTranslator.FromOle(&H8000000B)
                }

                txtL2Deg.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtL2Deg_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            int KeyAscii = Strings.Asc(eventArgs.KeyChar);
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

        private void cmdRhumbPoints_Click(object sender, EventArgs e)
        {
            if (optGreatCircle.Checked == false)
            {
                cmdRhumbPoints.Visible = true;
            }

            My.MyProject.Forms.frmPointsOnRhumb.Show();
            cmdRhumbPoints.Enabled = false;
        }

        private void txtL2Deg_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if ((optMercatorE.Checked == true | optMercatorS.Checked == true | optAccurateRhumb.Checked == true) & Conversion.Val(txtL2Deg.Text) > 89d | optMidLat.Checked == true & Conversion.Val(txtL2Deg.Text) > 84d)
            {
                KeepFocus = true;
            }

            if (optGreatCircle.Checked == true & Conversion.Val(txtL1Deg.Text) > 90d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtL2Deg_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtL2Deg;
            SelectAllText(ref argTB);
            txtL2Deg = argTB;
        }

        private void txtL2Min_TextChanged(object eventSender, EventArgs eventArgs)
        {
            txtL2Min.BackColor = SystemColors.Window;
            if (Conversion.Val(txtL2Min.Text) > 59.9d)
            {
                txtL2Min.BackColor = Color.Red; // Color.red
                ErrorMsgBox("Out of Range");
            }
        }

        private void txtL2Min_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            int KeyAscii = Strings.Asc(eventArgs.KeyChar);
            switch (KeyAscii)
            {
                case var @case when Strings.Asc("0") <= @case && @case <= Strings.Asc("9"):
                    {
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                case (short)('.'): // only allows one decimal point
                    {
                        if (Conversions.ToBoolean(Strings.InStr(txtL2Min.Text, ".")))
                        {
                            if (KeyAscii == 46)
                                KeyAscii = 0;
                            Interaction.Beep();
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

        private void txtL2Min_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtL2Min.Text) > 59.9d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtL2Min_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtL2Min;
            SelectAllText(ref argTB);
            txtL2Min = argTB;
        }

        private void txtLo2Deg_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtLo2Deg.Text) != 180d)
            {
                txtLo2Min.Enabled = true;
            }

            if (Conversion.Val(txtLo2Deg.Text) == 180d)
            {
                txtLo2Min.Text = "";
                txtLo2Min.Enabled = false;
                txtLo2Min.BackColor = Color.Gray;
            }

            txtLo2Deg.BackColor = SystemColors.Window;
            if (Conversion.Val(txtLo2Deg.Text) > 180d | Conversion.Val(txtLo2Deg.Text) == 180d & Conversion.Val(txtLo2Min.Text) != 0d)
            {
                txtLo2Deg.BackColor = Color.Red;
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtLo2Deg.Text) < 180d)
            {
                txtLo2Min.BackColor = SystemColors.Window;
            }
        }

        private void txtLo2Deg_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            int KeyAscii = Strings.Asc(eventArgs.KeyChar);
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

        private void txtLo2Deg_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtLo2Deg.Text) > 180d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtLo2Deg_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtLo2Deg;
            SelectAllText(ref argTB);
            txtLo2Deg = argTB;
        }

        private void txtLo2Min_TextChanged(object eventSender, EventArgs eventArgs)
        {
            txtLo2Min.BackColor = SystemColors.Window;
            if (Conversion.Val(txtLo2Min.Text) > 59.9d)
            {
                txtLo2Min.BackColor = Color.Red;
                ErrorMsgBox("Out of Range");
            }
        }

        private void txtLo2Min_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            int KeyAscii = Strings.Asc(eventArgs.KeyChar);
            switch (KeyAscii)
            {
                case var @case when Strings.Asc("0") <= @case && @case <= Strings.Asc("9"):
                    {
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                case (short)('.'): // only allows one decimal point
                    {
                        if (Conversions.ToBoolean(Strings.InStr(txtLo2Min.Text, ".")))
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

        private void txtLo2Min_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtLo2Min.Text) > 59.9d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtLo2Min_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtLo2Min;
            SelectAllText(ref argTB);
            txtLo2Min = argTB;
        }

        private void txtCourse_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtCourse.Text) > 359.9d)
            {
                txtCourse.BackColor = Color.Red;
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtCourse.Text) < 359.9d)
            {
                txtCourse.BackColor = SystemColors.Window;
            }
        }

        private void txtCourse_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            int KeyAscii = Strings.Asc(eventArgs.KeyChar);
            switch (KeyAscii)
            {
                case var @case when Strings.Asc("0") <= @case && @case <= Strings.Asc("9"):
                    {
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                case (short)('.'): // only allows one decimal point
                    {
                        if (Conversions.ToBoolean(Strings.InStr(txtCourse.Text, ".")))
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

        private void txtCourse_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtCourse.Text) > 359.9d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtCourse_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtCourse;
            SelectAllText(ref argTB);
            txtCourse = argTB;
        }

        // UPGRADE_WARNING: Event txtDist.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
        private void txtDist_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (!string.IsNullOrEmpty(txtDist.Text))
            {
                txtSpeed.Enabled = false;
                txtSpeed.BackColor = Color.Gray;
                txtTimeh.Enabled = false;
                txtTimeh.BackColor = Color.Gray;
                txtTimem.Enabled = false;
                txtTimem.BackColor = Color.Gray;
                txtLog1.Enabled = false;
                txtLog1.BackColor = Color.Gray;
                txtLog2.Enabled = false;
                txtLog2.BackColor = Color.Gray;
                txtTime1.Enabled = false;
                txtTime1.BackColor = Color.Gray;
                txtTime2.Enabled = false;
                txtTime2.BackColor = Color.Gray;
            }
            else
            {
                txtSpeed.Enabled = true;
                txtSpeed.BackColor = SystemColors.Window;
                txtTimeh.Enabled = true;
                txtTimeh.BackColor = SystemColors.Window;
                txtTimem.Enabled = true;
                txtTimem.BackColor = SystemColors.Window;
                txtLog1.Enabled = true;
                txtLog1.BackColor = SystemColors.Window;
                txtLog2.Enabled = true;
                txtLog2.BackColor = SystemColors.Window;
                txtTime1.Enabled = true;
                txtTime1.BackColor = SystemColors.Window;
                txtTime2.Enabled = true;
                txtTime2.BackColor = SystemColors.Window;
            }

            if (Conversion.Val(txtDist.Text) > 10800d)
            {
                txtDist.BackColor = Color.Red;
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtDist.Text) <= 10800d)
            {
                // txtDist.ForeColor = &H80000008
                txtDist.BackColor = SystemColors.Window;
            }
        }

        private void txtDist_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            int KeyAscii = Strings.Asc(eventArgs.KeyChar);
            switch (KeyAscii)
            {
                case var @case when Strings.Asc("0") <= @case && @case <= Strings.Asc("9"):
                    {
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                case (short)('.'): // only allows one decimal point
                    {
                        if (Conversions.ToBoolean(Strings.InStr(txtDist.Text, ".")))
                        {
                            if (KeyAscii == 46)
                                KeyAscii = 0;
                            Interaction.Beep();
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

        private void txtDist_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            eventArgs.Cancel = KeepFocus;
        }

        private void txtDist_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtDist;
            SelectAllText(ref argTB);
            txtDist = argTB;
        }

        private void txtLog1_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (!string.IsNullOrEmpty(txtLog1.Text))
            {
                txtSpeed.Enabled = false;
                txtSpeed.BackColor = Color.Gray;
                txtTimeh.Enabled = false;
                txtTimeh.BackColor = Color.Gray;
                txtTimem.Enabled = false;
                txtTimem.BackColor = Color.Gray;
                txtLog1.Enabled = true;
                txtLog1.BackColor = SystemColors.Window;
                txtLog2.Enabled = true;
                txtLog2.BackColor = SystemColors.Window;
                txtTime1.Enabled = false;
                txtTime1.BackColor = Color.Gray;
                txtTime2.Enabled = false;
                txtTime2.BackColor = Color.Gray;
                txtDist.Enabled = false;
                txtDist.BackColor = Color.Gray;
            }
            else
            {
                txtSpeed.Enabled = true;
                txtSpeed.BackColor = SystemColors.Window;
                txtTimeh.Enabled = true;
                txtTimeh.BackColor = SystemColors.Window;
                txtTimem.Enabled = true;
                txtTimem.BackColor = SystemColors.Window;
                txtLog1.Enabled = true;
                txtLog1.BackColor = SystemColors.Window;
                txtLog2.Enabled = true;
                txtLog2.BackColor = SystemColors.Window;
                txtTime1.Enabled = true;
                txtTime1.BackColor = SystemColors.Window;
                txtTime2.Enabled = true;
                txtTime2.BackColor = SystemColors.Window;
                txtDist.Enabled = true;
                txtDist.BackColor = SystemColors.Window;
            }

            if (Conversion.Val(txtLog1.Text) > 9999.9d)
            {
                txtLog1.BackColor = Color.Red;
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtLog1.Text) <= 9999.9d)
            {
                // txtLog1.ForeColor = &H80000008
                txtLog1.BackColor = SystemColors.Window;
            }
        }

        private void txtLog1_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            int KeyAscii = Strings.Asc(eventArgs.KeyChar);
            switch (KeyAscii)
            {
                case var @case when Strings.Asc("0") <= @case && @case <= Strings.Asc("9"):
                    {
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                case (short)('.'): // only allows one decimal point
                    {
                        if (Conversions.ToBoolean(Strings.InStr(txtLog1.Text, ".")))
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

        private void txtLog1_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtLog1.Text) > 9999.9d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtLog1_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtLog1;
            SelectAllText(ref argTB);
            txtLog1 = argTB;
        }

        // UPGRADE_WARNING: Event txtLog2.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
        private void txtLog2_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (!string.IsNullOrEmpty(txtLog2.Text))
            {
                txtSpeed.Enabled = false;
                txtSpeed.BackColor = Color.Gray;
                txtTimeh.Enabled = false;
                txtTimeh.BackColor = Color.Gray;
                txtTimem.Enabled = false;
                txtTimem.BackColor = Color.Gray;
                txtLog1.Enabled = true;
                txtLog1.BackColor = SystemColors.Window;
                txtLog2.Enabled = true;
                txtLog2.BackColor = SystemColors.Window;
                txtTime1.Enabled = false;
                txtTime1.BackColor = Color.Gray;
                txtTime2.Enabled = false;
                txtTime2.BackColor = Color.Gray;
                txtDist.Enabled = false;
                txtDist.BackColor = Color.Gray;
            }
            else
            {
                txtSpeed.Enabled = true;
                txtSpeed.BackColor = SystemColors.Window;
                txtTimeh.Enabled = true;
                txtTimeh.BackColor = SystemColors.Window;
                txtTimem.Enabled = true;
                txtTimem.BackColor = SystemColors.Window;
                txtLog1.Enabled = true;
                txtLog1.BackColor = SystemColors.Window;
                txtLog2.Enabled = true;
                txtLog2.BackColor = SystemColors.Window;
                txtTime1.Enabled = true;
                txtTime1.BackColor = SystemColors.Window;
                txtTime2.Enabled = true;
                txtTime2.BackColor = SystemColors.Window;
                txtDist.Enabled = true;
                txtDist.BackColor = SystemColors.Window;
            }

            if (Conversion.Val(txtLog2.Text) > 9999d)
            {
                txtLog2.BackColor = Color.Red;
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtLog2.Text) <= 9999.9d)
            {
                // txtLog2.ForeColor = &H80000008
                txtLog2.BackColor = SystemColors.Window;
            }
        }

        private void txtLog2_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            int KeyAscii = Strings.Asc(eventArgs.KeyChar);
            switch (KeyAscii)
            {
                case var @case when Strings.Asc("0") <= @case && @case <= Strings.Asc("9"):
                    {
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                case (short)('.'): // only allows one decimal point
                    {
                        if (Conversions.ToBoolean(Strings.InStr(txtLog2.Text, ".")))
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

        private void txtLog2_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtLog2.Text) > 9999.9d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtLog2_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtLog2;
            SelectAllText(ref argTB);
            txtLog2 = argTB;
        }

        private void txtMLDeg_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtMLDeg.Text) <= 54d)
            {
                cboMLmin.Enabled = true;
            }
            else
            {
                cboMLmin.Enabled = false;
            }

            if (Conversion.Val(txtMLDeg.Text) == 54d & Conversion.Val(cboMLmin.Text) > 30d | Conversion.Val(txtMLDeg.Text) > 55d) // : cboMLmin.BackColor = &H8000000B
            {
                txtMLDeg.BackColor = Color.Red;
                cboMLmin.BackColor = Color.Red;
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtMLDeg.Text) < 55d | Conversion.Val(txtMLDeg.Text) == 55d & Conversion.Val(cboMLmin.Text) <= 30d)
            {
                txtMLDeg.BackColor = SystemColors.Window;
                cboMLmin.BackColor = SystemColors.Window;
            }
        }

        private void txtMLDeg_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            int KeyAscii = Strings.Asc(eventArgs.KeyChar);
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

        private void txtMLDeg_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtMLDeg.Text) > 90d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtMLDeg_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtMLDeg;
            SelectAllText(ref argTB);
            txtMLDeg = argTB;
        }

        private void txtSpeed_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (!string.IsNullOrEmpty(txtSpeed.Text) | !string.IsNullOrEmpty(txtTime1.Text) | !string.IsNullOrEmpty(txtTime1.Text))
            {
                txtDist.Enabled = false;
                txtDist.BackColor = Color.Gray;
                txtLog1.Enabled = false;
                txtLog1.BackColor = Color.Gray;
                txtLog2.Enabled = false;
                txtLog2.BackColor = Color.Gray;
            }
            else
            {
                txtDist.Enabled = true;
                txtDist.BackColor = SystemColors.Window;
                txtLog1.Enabled = true;
                txtLog1.BackColor = SystemColors.Window;
                txtLog2.Enabled = true;
                txtLog2.BackColor = SystemColors.Window;
            }

            if (Conversion.Val(txtSpeed.Text) > 99.9d)
            {
                txtSpeed.BackColor = Color.Red;
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtSpeed.Text) <= 99.9d)
            {
                txtSpeed.BackColor = SystemColors.Window;
            }
        }

        private void txtSpeed_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            int KeyAscii = Strings.Asc(eventArgs.KeyChar);
            switch (KeyAscii)
            {
                case var @case when Strings.Asc("0") <= @case && @case <= Strings.Asc("9"):
                    {
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                case (short)('.'): // only allows one decimal point
                    {
                        if (Conversions.ToBoolean(Strings.InStr(txtSpeed.Text, ".")))
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

        private void txtSpeed_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtSpeed.Text) > 99.9d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtSpeed_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtSpeed;
            SelectAllText(ref argTB);
            txtSpeed = argTB;
        }

        private void txtTime1_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (!string.IsNullOrEmpty(txtSpeed.Text) | !string.IsNullOrEmpty(txtTime1.Text) | !string.IsNullOrEmpty(txtTime2.Text))
            {
                txtDist.Enabled = false;
                txtDist.BackColor = Color.Gray;
                txtTimeh.Enabled = false;
                txtTimeh.BackColor = Color.Gray;
                txtTimem.Enabled = false;
                txtTimem.BackColor = Color.Gray;
                txtLog1.Enabled = false;
                txtLog1.BackColor = Color.Gray;
                txtLog2.Enabled = false;
                txtLog2.BackColor = Color.Gray;
            }
            else
            {
                txtDist.Enabled = true;
                txtDist.BackColor = SystemColors.Window;
                txtTimeh.Enabled = true;
                txtTimeh.BackColor = SystemColors.Window;
                txtTimem.Enabled = true;
                txtTimem.BackColor = SystemColors.Window;
                txtLog1.Enabled = true;
                txtLog1.BackColor = SystemColors.Window;
                txtLog2.Enabled = true;
                txtLog2.BackColor = SystemColors.Window;
            }

            if (string.IsNullOrEmpty(txtTime1.Text) & string.IsNullOrEmpty(txtTime2.Text))
            {
                txtTimeh.Enabled = true;
                txtTimeh.BackColor = SystemColors.Window;
                txtTimem.Enabled = true;
                txtTimem.BackColor = SystemColors.Window;
            }

            txtTime1.BackColor = SystemColors.Window;
            if (txtTime1.Text.ToString().Length == 4 & (Conversion.Val(Strings.Left(txtTime1.Text, 2)) > 23d | Conversion.Val(Strings.Mid(txtTime1.Text, 3, 2)) > 59d))
            {
                txtTime1.BackColor = Color.Red;
                ErrorMsgBox("Out of Range");
            }
        }

        private void txtTime1_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            int KeyAscii = Strings.Asc(eventArgs.KeyChar);
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

        private void txtTime1_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(Strings.Left(txtTime1.Text, 2)) > 23d | Conversion.Val(Strings.Mid(txtTime1.Text, 3, 2)) > 59d | txtTime1.Text.ToString().Length != 4)
            {
                KeepFocus = true;
                if (string.IsNullOrEmpty(txtTime1.Text))
                    KeepFocus = false;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtTime1_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtTime1;
            SelectAllText(ref argTB);
            txtTime1 = argTB;
        }

        private void txtTime2_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (!string.IsNullOrEmpty(txtSpeed.Text) | !string.IsNullOrEmpty(txtTime1.Text) | !string.IsNullOrEmpty(txtTime2.Text))
            {
                txtDist.Enabled = false;
                txtDist.BackColor = Color.Gray;
                txtTimeh.Enabled = false;
                txtTimeh.BackColor = Color.Gray;
                txtTimem.Enabled = false;
                txtTimem.BackColor = Color.Gray;
                txtLog1.Enabled = false;
                txtLog1.BackColor = Color.Gray;
                txtLog2.Enabled = false;
                txtLog2.BackColor = Color.Gray;
            }
            else
            {
                txtDist.Enabled = true;
                txtDist.BackColor = SystemColors.Window;
                txtTimeh.Enabled = true;
                txtTimeh.BackColor = SystemColors.Window;
                txtTimem.Enabled = true;
                txtTimem.BackColor = SystemColors.Window;
                txtLog1.Enabled = true;
                txtLog1.BackColor = SystemColors.Window;
                txtLog2.Enabled = true;
                txtLog2.BackColor = SystemColors.Window;
            }

            if (string.IsNullOrEmpty(txtTime1.Text) & string.IsNullOrEmpty(txtTime2.Text))
            {
                txtTimeh.Enabled = true;
                txtTimeh.BackColor = SystemColors.Window;
                txtTimem.Enabled = true;
                txtTimem.BackColor = SystemColors.Window;
            }

            txtTime2.BackColor = SystemColors.Window;
            if (txtTime2.Text.ToString().Length == 4 & (Conversion.Val(Strings.Left(txtTime2.Text, 2)) > 23d | Conversion.Val(Strings.Mid(txtTime2.Text, 3, 2)) > 59d))
            {
                txtTime2.BackColor = Color.Red;
                ErrorMsgBox("Out of Range");
            }
        }

        private void txtTime2_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            int KeyAscii = Strings.Asc(eventArgs.KeyChar);
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

        private void txtTime2_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(Strings.Left(txtTime2.Text, 2)) > 23d | Conversion.Val(Strings.Mid(txtTime2.Text, 3, 2)) > 59d | txtTime2.Text.ToString().Length != 4)
            {
                KeepFocus = true;
                if (string.IsNullOrEmpty(txtTime2.Text))
                    KeepFocus = false;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtTime2_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtTime2;
            SelectAllText(ref argTB);
            txtTime2 = argTB;
        }

        private void txtTimeh_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (!string.IsNullOrEmpty(txtSpeed.Text) | !string.IsNullOrEmpty(txtTimeh.Text) | !string.IsNullOrEmpty(txtTimem.Text))
            {
                txtDist.Enabled = false;
                txtDist.BackColor = Color.Gray;
                txtLog1.Enabled = false;
                txtLog1.BackColor = Color.Gray;
                txtLog2.Enabled = false;
                txtLog2.BackColor = Color.Gray;
            }
            else
            {
                txtDist.Enabled = true;
                txtDist.BackColor = SystemColors.Window;
                txtLog1.Enabled = true;
                txtLog1.BackColor = SystemColors.Window;
                txtLog2.Enabled = true;
                txtLog2.BackColor = SystemColors.Window;
            }

            if (!string.IsNullOrEmpty(txtTimeh.Text) | !string.IsNullOrEmpty(txtTimem.Text))
            {
                txtTime1.Enabled = false;
                txtTime1.BackColor = Color.Gray;
                txtTime1.Enabled = false;
                txtTime1.BackColor = Color.Gray;
                txtTime2.Enabled = false;
                txtTime2.BackColor = Color.Gray;
                txtTime2.Enabled = false;
                txtTime2.BackColor = Color.Gray;
            }
            else
            {
                txtTime1.Enabled = true;
                txtTime1.BackColor = SystemColors.Window;
                txtTime1.Enabled = true;
                txtTime1.BackColor = SystemColors.Window;
                txtTime2.Enabled = true;
                txtTime2.BackColor = SystemColors.Window;
                txtTime2.Enabled = true;
                txtTime2.BackColor = SystemColors.Window;
            }
        }

        private void txtTimeh_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            int KeyAscii = Strings.Asc(eventArgs.KeyChar);
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

        private void txtTimeh_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtTimeh.Text) > 99d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtTimeh_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtTimeh;
            SelectAllText(ref argTB);
            txtTimeh = argTB;
        }

        private void txtTimem_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (!string.IsNullOrEmpty(txtSpeed.Text) | !string.IsNullOrEmpty(txtTimeh.Text) | !string.IsNullOrEmpty(txtTimem.Text))
            {
                txtDist.Enabled = false;
                txtDist.BackColor = Color.Gray;
                txtLog1.Enabled = false;
                txtLog1.BackColor = Color.Gray;
                txtLog2.Enabled = false;
                txtLog2.BackColor = Color.Gray;
                txtTime1.Enabled = false;
                txtTime1.BackColor = Color.Gray;
                txtTime1.Enabled = false;
                txtTime1.BackColor = Color.Gray;
                txtTime2.Enabled = false;
                txtTime2.BackColor = Color.Gray;
                txtTime2.Enabled = false;
                txtTime2.BackColor = Color.Gray;
            }
            else
            {
                txtDist.Enabled = true;
                txtDist.BackColor = SystemColors.Window;
                txtLog1.Enabled = true;
                txtLog1.BackColor = SystemColors.Window;
                txtLog2.Enabled = true;
                txtLog2.BackColor = SystemColors.Window;
                txtTime1.Enabled = true;
                txtTime1.BackColor = SystemColors.Window;
                txtTime1.Enabled = true;
                txtTime1.BackColor = SystemColors.Window;
                txtTime2.Enabled = true;
                txtTime2.BackColor = SystemColors.Window;
                txtTime2.Enabled = true;
                txtTime2.BackColor = SystemColors.Window;
            }

            if (Conversion.Val(txtTimeh.Text) != 0d)
                MaxTimem = 59;
            else
                MaxTimem = 999;
            if (Conversion.Val(txtTimem.Text) > MaxTimem)
            {
                txtTimem.BackColor = Color.Red;
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtTimem.Text) <= MaxTimem)
            {
                txtTimem.BackColor = SystemColors.Window;
            }

            if (Conversion.Val(txtTimem.Text) > 59d)
            {
                txtTimeh.Enabled = false;
                txtTimeh.BackColor = Color.Gray;
            }

            if (Conversion.Val(txtTimem.Text) <= 59d)
            {
                txtTimeh.Enabled = true;
                txtTimeh.BackColor = SystemColors.Window;
            }
        }

        private void txtTimem_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            int KeyAscii = Strings.Asc(eventArgs.KeyChar);
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

        private void txtTimem_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            // If Val(txtTimem.Text) > 59 Then
            // KeepFocus = True
            // End If
            eventArgs.Cancel = KeepFocus;
        }

        private void txtTimem_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtTimem;
            SelectAllText(ref argTB);
            txtTimem = argTB;
        }

        public void LatLong()
        {
            BadCLS = false;
            L1 = Conversion.Val(txtL1Deg.Text) + Conversion.Val(txtL1Min.Text) / 60d;
            if (cboL1.Text == "S")
                L1 = -L1;
            Lo1 = Conversion.Val(txtLo1Deg.Text) + Conversion.Val(txtLo1Min.Text) / 60d;
            if (cboLo1.Text == "E")
                Lo1 = -Lo1;
            L2 = Conversion.Val(txtL2Deg.Text) + Conversion.Val(txtL2Min.Text) / 60d;
            if (cboL2.Text == "S")
                L2 = -L2;
            Lo2 = Conversion.Val(txtLo2Deg.Text) + Conversion.Val(txtLo2Min.Text) / 60d;
            if (cboLo2.Text == "E")
                Lo2 = -Lo2;
            if (optMidLat.Checked == true & (int)chkML.CheckState == 1)
            {
                if ((optCD.Checked == true | optSD.Checked == true) & Math.Abs(L1 - L2) > 1d)
                {
                    ErrorMsgBox("Maximum difference in latitude for CLS SAPS plot is 1º.");
                    BadCLS = true;
                    return;
                }

                if ((optCD.Checked == true | optSD.Checked == true) & Math.Abs(Lo1 - Lo2) > 1d)
                {
                    ErrorMsgBox("Maximum difference in longitude for CLS SAPS plot is 1º.");
                    BadCLS = true;
                    return;
                }

                LmML = Conversion.Val(txtMLDeg.Text) + Conversion.Val(cboMLmin.Text) / 60d;
                if (cboML.Text == "S")
                {
                    LmML = -LmML;
                }

                TestML();
            }

            Fix1L = Conversion.Val(txtFix1LD.Text) + Conversion.Val(txtFix1LM.Text) / 60d;
            if (cboFix1L.Text == "S")
            {
                Fix1L = -Fix1L;
            }

            Fix1Lo = Conversion.Val(txtFix1LoD.Text) + Conversion.Val(txtFix1LoM.Text) / 60d;
            if (cboFix1Lo.Text == "E")
            {
                Fix1Lo = -Fix1Lo;
            }
        }

        private void Form_Initialize_Renamed()
        {
            Pi = Math.PI;  // 4 * System.Math.Atan(1.0#)
                           // lblICD.Visible = False
            BadCLS = false;
        }

        private void FormSailings_Load(object eventSender, EventArgs eventArgs)
        {
            chkComposite.Visible = false;
            lblLimLat.Visible = false;
            txtL3Deg.Visible = false;
            Label16.Visible = false;
            Frame3.Visible = false;
            txtL3Min.Visible = false;
            Label15.Visible = false;
            frameCalculate.Visible = true;
            frameCalculateGC.Visible = false;
            optL2Lo2.Visible = true;
            optL2Lo2.Checked = false;
            optCD.Visible = true;
            optCD.Checked = true;
            optSD.Visible = true;
            optSD.Checked = false;
            cboL1.SelectedIndex = 0; // g_LatN
            cboLo1.SelectedIndex = 0; // g_LongW
            cboL2.SelectedIndex = 0; // g_LatN
            cboLo2.SelectedIndex = 0; // g_LongW
            cboFix1L.SelectedIndex = 0; // g_LatN
            cboFix1Lo.SelectedIndex = 0; // g_LongW
            cboML.SelectedIndex = 0; // g_LatN
            optCD_CheckedChanged(optCD, new EventArgs());
            cboL3.SelectedIndex = 0; // g_LatN
        }

        public void DisplayDestination()
        {
            txtSailings.Clear();
            if (BadCLS == true)
            {
                return;
            }
            // CurrentY = 4600
            L2Deg = (int)Conversion.Int(Math.Abs(L2));
            L2Min = (Math.Abs(L2) - L2Deg) * 60d;
            L2Min = Conversion.Int(L2Min * 10d + 0.5d) / 10d;
            if (L2Min == 60d)
            {
                L2Min = 0d;
                L2Deg = L2Deg + 1;
            }

            Lo2Deg = (int)Conversion.Int(Math.Abs(Lo2));
            Lo2Min = (Math.Abs(Lo2) - Lo2Deg) * 60d;
            Lo2Min = Conversion.Int(Lo2Min * 10d + 0.5d) / 10d;
            if (Lo2Min == 60d)
            {
                Lo2Min = 0d;
                Lo2Deg = Lo2Deg + 1;
            }

            txtSailings.Clear();
            txtSailings.SelectionAlignment = HorizontalAlignment.Left;
            txtSailings.WordWrap = true;
            txtSailings.AppendText(Strings.Space(65) + "L2" + Strings.Space(14) + Strings.Format(L2Deg, "0") + '°' + Strings.Format(L2Min, "00.0") + "'");
            if (Math.Abs(L2) < 0.01d)
            {
                L2 = 0d;
                txtSailings.AppendText("");
            }

            if (L2 > 0d & Math.Abs(L2) > 0.01d)
                txtSailings.AppendText(CommonGlobals.g_LatN);
            if (L2 < 0d & Math.Abs(L2) > 0.01d)
                txtSailings.AppendText(CommonGlobals.g_LatS);
            txtSailings.AppendText(Environment.NewLine);
            txtSailings.AppendText(Strings.Space(65) + "Lo2" + Strings.Space(11) + Strings.Format(Lo2Deg, "0") + '°' + Strings.Format(Lo2Min, "00.0") + "'");
            if (Math.Abs(Lo2) < 0.01d)
            {
                Lo2 = 0d;
                txtSailings.AppendText("");
            }

            if (Math.Abs(Lo2) > 179.999d)
            {
                txtSailings.AppendText("");
            }

            if (Lo2 > 0d & Math.Abs(Lo2) < 179.999d)
            {
                txtSailings.AppendText(CommonGlobals.g_LongW);
            }

            if (Lo2 < 0d & Math.Abs(Lo2) < 179.999d)
            {
                txtSailings.AppendText(CommonGlobals.g_LongE);
            }

            txtSailings.AppendText(Environment.NewLine);
            if (string.IsNullOrEmpty(txtDist.Text) & string.IsNullOrEmpty(txtTimeh.Text) & string.IsNullOrEmpty(txtTimem.Text) & !string.IsNullOrEmpty(txtTime1.Text))
            {
                txtSailings.AppendText(Strings.Space(65) + "Run Time  " + Strings.Format(TimeHours, "##0") + "h" + Strings.Format(TimeMinutes, "00") + "m" + Environment.NewLine);
            }

            if (optL2Lo2GC.Checked == false & string.IsNullOrEmpty(txtDist.Text))
            {
                txtSailings.AppendText(Strings.Space(65) + "Distance    " + Strings.Format(Distance, "##0.0") + " nm" + Environment.NewLine);
            }

            if ((optMercatorE.Checked == true | optMercatorS.Checked == true) & Math.Abs(CourseAngle) != 90d) // < 85 Then
            {
                txtSailings.AppendText(Strings.Space(65) + "M1" + Strings.Space(11) + Strings.Format(Math.Abs(MP1), "###0.0") + Environment.NewLine);
                txtSailings.AppendText(Strings.Space(65) + "M2" + Strings.Space(11) + Strings.Format(Math.Abs(MP2), "###0.0") + Environment.NewLine);
                txtSailings.AppendText(Strings.Space(65) + "m" + Strings.Space(13) + Strings.Format(Math.Abs(MP), "###0.0"));
            }

            txtSailings.AppendText(Environment.NewLine);
            if ((optMercatorE.Checked == true | optMercatorS.Checked == true) & Math.Abs(CourseAngle) == 90d)
            {
                txtSailings.AppendText(Strings.Space(10) + "Calculated by conventional mid-latitude sailing for courses directly east or west." + Environment.NewLine);
            }

            if (optGreatCircle.Checked == true)
            {
                MaxLatDeg = (int)Conversion.Int(Math.Abs(MaxLat));
                MaxLatMin = (Math.Abs(MaxLat) - MaxLatDeg) * 60d;
                MaxLatMin = Conversion.Int(MaxLatMin * 10d + 0.5d) / 10d;
                if (MaxLatMin == 60d)
                {
                    MaxLatMin = 0d;
                    MaxLatDeg = MaxLatDeg + 1;
                }

                txtSailings.AppendText(Strings.Space(46) + "Maximum latitude            " + Strings.Format(MaxLatDeg, "0") + '°' + Strings.Format(MaxLatMin, "00.0") + "'");
                if (optICD.Checked == true & CourseAngleDeg < 90d)
                {
                    txtSailings.AppendText(cboL2.Text);
                }

                if (optICD.Checked == true & CourseAngleDeg >= 90d)
                {
                    txtSailings.AppendText(cboL1.Text); // need Abs?
                }

                if (optL2Lo2GC.Checked == true & Math.Abs(MaxLat) < 0.01d)
                {
                    MaxLat = 0d;
                    txtSailings.AppendText("");
                }

                if (optL2Lo2GC.Checked == true & MaxLat > 0d & Math.Abs(MaxLat) > 0.01d)
                {
                    txtSailings.AppendText(CommonGlobals.g_LatN);
                }

                if (optL2Lo2GC.Checked == true & MaxLat < 0d & Math.Abs(MaxLat) > 0.01d)
                {
                    txtSailings.AppendText(CommonGlobals.g_LatS);
                }

                txtSailings.AppendText(" at " + Strings.Format(LoVertexDeg, "0") + '°' + Strings.Format(LoVertexMin, "00.0") + "'");
                if (LoVertex < 0d)
                {
                    txtSailings.AppendText(CommonGlobals.g_LongE);
                }

                if (LoVertex > 0d)
                {
                    txtSailings.AppendText(CommonGlobals.g_LongW);
                }

                if (LoVertex == 0d)
                {
                    txtSailings.AppendText(CommonGlobals.g_StrSpace);
                }

                txtSailings.AppendText(Environment.NewLine);
                txtSailings.AppendText(Strings.Space(53) + "Final course           " + Strings.Format(CourseFinal, "000.00") + '°' + " True => " + Strings.Format(CourseFinal, "000") + '°' + " True");
            }
        }

        public void DisplayCD()
        {
            txtSailings.Clear();
            if (BadCLS == true)
            {
                return;
            }
            // txtSailings.Clear()

            // CurrentY = 4600
            // CourseAngleDeg = Int(CourseAngleDeg + 0.5)
            Distance = Math.Abs(Conversion.Int(Distance * 10d + 0.5d) / 10d);
            if (optGreatCircle.Checked == true & chkComposite.CheckState == 0)
            {
                txtSailings.AppendText("Great Circle Sailing results:" + Environment.NewLine);
            }

            if (optGreatCircle.Checked == true & (int)chkComposite.CheckState == 1)
            {
                if (optMethod1.Checked == true)
                {
                    txtSailings.AppendText("Composite Sailing results, Method 1:" + Environment.NewLine);
                }

                if (optMethod2.Checked == true)
                {
                    txtSailings.AppendText("Composite Sailing results, Method 2:" + Environment.NewLine);
                }
            }
            // If optGreatCircle.Checked = True Then CurrentY = 4800

            if (optGreatCircle.Checked == true)
                txtSailings.AppendText(Strings.Space(40) + "Initial ");
            // CurrentY = 4600
            // If optGreatCircle = True And chkComposite = 1 And optMethod2 = True Then Course = Course1: CourseFinal = Course3
            if (optGreatCircle.Checked == true & (int)chkComposite.CheckState == 1)
            {
                Course = Course1;
                // If L2 <> L3 Then CourseFinal = Course3
                CourseFinal = Course3;
            }

            Course = Conversion.Int(Course * 100d + 0.5d) / 100d;
            if (Course >= 360d)
                Course = Course - 360d;
            CourseFinal = Conversion.Int(CourseFinal * 100d + 0.5d) / 100d;
            if (CourseFinal >= 360d)
                CourseFinal = CourseFinal - 360d;

            // If optGreatCircle = True And chkComposite = 1 And optMethod2 = True Then Course = Course1: CourseFinal = Course3

            if (optGreatCircle.Checked == false) // txtSailings.AppendText(Space(40))
            {
                txtSailings.AppendText(Strings.Space(40) + "Course" + Strings.Space(35) + Strings.Format(Course, "000.00") + '°' + " True => " + Strings.Format(Course, "000") + '°' + " True" + Environment.NewLine);
            }

            if (optGreatCircle.Checked == true) // txtSailings.AppendText(Space(40))
            {
                txtSailings.AppendText("Course" + Strings.Space(28) + Strings.Format(Course, "000.00") + '°' + " True => " + Strings.Format(Course, "000") + '°' + " True" + Environment.NewLine);
            }

            if (optGreatCircle.Checked == true & chkComposite.CheckState == 0 | optGreatCircle.Checked == false)
            {
                txtSailings.AppendText(Strings.Space(40) + "Distance" + Strings.Space(34) + Strings.Format(Distance, "0.0") + " nm" + Environment.NewLine);
            }

            if (optMercatorE.Checked == true | optMercatorS.Checked == true)
            {
                txtSailings.AppendText(Strings.Space(40) + "M1" + Strings.Space(41) + Strings.Format(Math.Abs(MP1), "###0.0") + Environment.NewLine);
                txtSailings.AppendText(Strings.Space(40) + "M2" + Strings.Space(41) + Strings.Format(Math.Abs(MP2), "###0.0") + Environment.NewLine);
                txtSailings.AppendText(Strings.Space(40) + "m " + Strings.Space(42) + Strings.Format(Math.Abs(MP), "###0.0") + Environment.NewLine);
            }

            if (optGreatCircle.Checked == true & chkComposite.CheckState == 0)
            {
                MaxLatDeg = (int)Conversion.Int(Math.Abs(MaxLat));
                MaxLatMin = (Math.Abs(MaxLat) - MaxLatDeg) * 60d;
                MaxLatMin = Conversion.Int(MaxLatMin * 10d + 0.5d) / 10d;
                if (MaxLatMin == 60d)
                {
                    MaxLatMin = 0d;
                    MaxLatDeg = MaxLatDeg + 1;
                }

                txtSailings.AppendText(Strings.Space(40) + "Maximum latitude" + Strings.Space(21) + Strings.Format(MaxLatDeg, "0") + '°' + Strings.Format(MaxLatMin, "00.0") + "'");
                if (Math.Sign(MaxLat) == 1)
                    txtSailings.AppendText(CommonGlobals.g_LatN);
                if (Math.Sign(MaxLat) == -1)
                    txtSailings.AppendText(CommonGlobals.g_LatS);
                if (MaxLat != 90d) // added If MaxLat <> 90 in V5.1.2
                {
                    txtSailings.AppendText(" at " + Strings.Format(LoVertexDeg, "0") + '°' + Strings.Format(LoVertexMin, "00.0") + "'");
                    if (LoVertex < 0d)
                        txtSailings.AppendText(CommonGlobals.g_LongE);
                    if (LoVertex > 0d)
                        txtSailings.AppendText(CommonGlobals.g_LongW);
                    if (LoVertex == 0d)
                        txtSailings.AppendText(CommonGlobals.g_StrSpace);
                }

                txtSailings.AppendText(Environment.NewLine);
                txtSailings.AppendText(Strings.Space(40) + "Final Course" + Strings.Space(28) + Strings.Format(CourseFinal, "000.00") + '°' + " True => " + Strings.Format(CourseFinal, "000") + '°' + " True");
                txtSailings.AppendText(Environment.NewLine);
            }

            L3 = Conversion.Val(txtL3Deg.Text) + Conversion.Val(txtL3Min.Text) / 60d;
            if (cboL3.Text == "S")
            {
                L3 = -L3;
            }

            if (optGreatCircle.Checked == true & (int)chkComposite.CheckState == 1)
            {
                if (L1 != L3)
                {
                    txtSailings.AppendText(Strings.Space(40) + "Route reaches latitude limit at      " + Strings.Format(Lon31Deg, "0") + '°' + Strings.Format(Lon31Min, "00.0") + "'");
                    if (Lon31 > 0d)
                        txtSailings.AppendText(CommonGlobals.g_LongW);
                    if (Lon31 < 0d)
                        txtSailings.AppendText(CommonGlobals.g_LongE);
                    if (Lon31 == 0d)
                        txtSailings.AppendText(CommonGlobals.g_StrSpace);
                }

                txtSailings.AppendText(Environment.NewLine);
                if (L2 != L3)
                {
                    txtSailings.AppendText(Strings.Space(40) + "Route leaves latitude limit at        " + Strings.Format(Lon32Deg, "0") + '°' + Strings.Format(Lon32Min, "00.0") + "'");
                    if (Lon32 > 0d)
                        txtSailings.AppendText(CommonGlobals.g_LongW);
                    if (Lon32 < 0d)
                        txtSailings.AppendText(CommonGlobals.g_LongE);
                    if (Lon32 == 0d)
                        txtSailings.AppendText(CommonGlobals.g_StrSpace);
                }

                txtSailings.AppendText(Environment.NewLine);
                if (L1 != L3)
                {
                    txtSailings.AppendText(Strings.Space(27) + "Distance from departure to latitude limit       " + Strings.Format(Distance1, "0.0") + " nm" + Environment.NewLine);
                }

                txtSailings.AppendText(Strings.Space(29) + "Distance along limiting latitude parallel      " + Strings.Format(Distance2, "0.0") + " nm" + Environment.NewLine);
                if (L2 != L3)
                {
                    txtSailings.AppendText(Strings.Space(27) + "Distance from latitude limit to destination     " + Strings.Format(Distance3, "0.0") + " nm" + Environment.NewLine);
                }

                txtSailings.AppendText(Strings.Space(37) + "Total composite sailing distance      " + Strings.Format(DistanceComposite, "0.0") + " nm" + Environment.NewLine);
                txtSailings.AppendText(Strings.Space(40) + "Final Course" + Strings.Space(29) + Strings.Format(CourseFinal, "000.00") + '°' + " True => " + Strings.Format(CourseFinal, "000") + '°' + " True");
            }
            // End If
        }

        public void DisplaySD()
        {
            txtSailings.Clear();
            if (BadCLS == true)
            {
                return;
            }
            // txtSailings.Clear()

            Distance = Math.Abs(Conversion.Int(Distance * 10d + 0.5d) / 10d);
            txtSailings.AppendText(Strings.Space(40) + "Set" + Strings.Space(34) + Strings.Format(Course, "000.00") + '°' + " True => " + Strings.Format(Course, "000") + '°' + " True" + Environment.NewLine); // was Format(Course, "000"); Chr$(176); " True" until V5.4.0
            txtSailings.AppendText(Strings.Space(40) + "Total Drift" + Strings.Space(26) + Strings.Format(Distance, "0.0") + " nm" + Environment.NewLine);
            if (TimeinMinutes != 0)
            {
                txtSailings.AppendText(Strings.Space(40) + "Drift" + Strings.Space(34) + Strings.Format(Drift, "0.0") + " kn" + Environment.NewLine);
            }

            if ((int)chkDriftAngle.CheckState == 1)
            {
                txtSailings.AppendText(Strings.Space(40) + "Drift Angle" + Strings.Space(25) + Strings.Format(DriftAng, "#0") + '°');
                if (CourseToFix < CourseToDR & Flag4 == false)
                {
                    txtSailings.AppendText(" to port");
                }

                if (CourseToFix > CourseToDR & Flag4 == false)
                {
                    txtSailings.AppendText(" to starboard");
                }

                if (CourseToFix < CourseToDR & Flag4 == true)
                {
                    txtSailings.AppendText(" to starboard");
                }

                if (CourseToFix > CourseToDR & Flag4 == true)
                {
                    txtSailings.AppendText(" to port");
                }

                txtSailings.AppendText(Environment.NewLine);
            }

            if (string.IsNullOrEmpty(txtTimeh.Text) & string.IsNullOrEmpty(txtTimem.Text) & TimeinMinutes != 0)
            {
                txtSailings.AppendText(Strings.Space(40) + "Run Time" + Strings.Space(25) + Strings.Format(TimeHours, "##0") + "h" + Strings.Format(TimeMinutes, "00") + "m" + Environment.NewLine);
            }

            if (optMercatorE.Checked == true | optMercatorS.Checked == true)
            {
                txtSailings.AppendText(Strings.Space(40) + "M1" + Strings.Space(34) + Strings.Format((Math.Abs(MP1) * 10d + 0.5d) / 10d, "###0.0") + Environment.NewLine);
                txtSailings.AppendText(Strings.Space(40) + "M2" + Strings.Space(34) + Strings.Format((Math.Abs(MP2) * 10d + 0.5d) / 10d, "###0.0") + Environment.NewLine);
                txtSailings.AppendText(Strings.Space(40) + "m " + Strings.Space(35) + Strings.Format(Math.Abs(MP), "###0.0") + Environment.NewLine);
            }
        }

        public void DisplayCMGSMG()
        {

            // txtSailings.Clear()

            txtSailings.AppendText(Strings.Space(40) + "Distance between fixes       " + Strings.Format(Distance, "0.0") + " nm" + Environment.NewLine);
            txtSailings.AppendText(Strings.Space(40) + "Course Made Good (CMG)  " + Strings.Format(Course, "000.00") + '°' + " True => " + Strings.Format(Course, "000") + '°' + " True" + Environment.NewLine);
            if (TimeinMinutes != 0)
                txtSailings.AppendText(Strings.Space(40) + "Speed Made Good (SMG)    " + Strings.Format(SMG, "0.0") + " kn" + Environment.NewLine);
        }

        private void cmdPrint_Click(object eventSender, EventArgs eventArgs)
        {
            Print_Renamed.PrintScreen(Bounds);
        }

        public void MeridionalParts()
        {
            if (optMercatorS.Checked)
            {
                MP1 = 7915.704468d * Math.Log(Math.Tan((45d + Math.Abs(L1) / 2d) * Pi / 180d)) / Math.Log(10d) - 23.268932d * Math.Sin(Math.Abs(L1) * Pi / 180d) - 0.0525d * Math.Pow(Math.Sin(Math.Abs(L1) * Pi / 180d), 3d) - 0.000213d * Math.Pow(Math.Sin(Math.Abs(L1) * Pi / 180d), 5d);
                MP2 = 7915.704468d * Math.Log(Math.Tan((45d + Math.Abs(L2) / 2d) * Pi / 180d)) / Math.Log(10d) - 23.268932d * Math.Sin(Math.Abs(L2) * Pi / 180d) - 0.0525d * Math.Pow(Math.Sin(Math.Abs(L2) * Pi / 180d), 3d) - 0.000213d * Math.Pow(Math.Sin(Math.Abs(L2) * Pi / 180d), 5d);
            }

            if (optMercatorE.Checked)
            {
                // From Bowditch 2002
                MP1 = 7915.704468d * Math.Log(Math.Tan((45d + Math.Abs(L1) / 2d) * Pi / 180d)) / Math.Log(10d) - 23.0133633d * Math.Sin(Math.Abs(L1) * Pi / 180d) - 0.051353d * Math.Pow(Math.Sin(Math.Abs(L1) * Pi / 180d), 3d) - 0.000206d * Math.Pow(Math.Sin(Math.Abs(L1) * Pi / 180d), 5d);
                MP2 = 7915.704468d * Math.Log(Math.Tan((45d + Math.Abs(L2) / 2d) * Pi / 180d)) / Math.Log(10d) - 23.0133633d * Math.Sin(Math.Abs(L2) * Pi / 180d) - 0.051353d * Math.Pow(Math.Sin(Math.Abs(L2) * Pi / 180d), 3d) - 0.000206d * Math.Pow(Math.Sin(Math.Abs(L2) * Pi / 180d), 5d);
            }

            if (Math.Sign(L1) == Math.Sign(L2))
                MP = Math.Abs(MP2 - MP1);
            if (Math.Sign(L1) != Math.Sign(L2))
                MP = Math.Abs(MP2) + Math.Abs(MP1);
        }

        private void GreatCircle()
        {

            // Convert east longitudes to west, >180
            // If Lo1 < 0 Then Lo1 = 360 - Abs(Lo1)
            // If Lo2 < 0 Then Lo2 = 360 - Abs(Lo2)
            // DLo = Lo2 - Lo1
            // If Abs(DLo) > 180 Then DLo = -(360 - Abs(DLo))
            // Direction = 1 'west
            // If DLo < 0 Then Direction = -1
            // If optICD.Value = True And chkComposite = 1 And optMethod1 = False And optMethod2 = False Then  ErrorMsgBox ("You must select a method.")

            if (optICD.Checked == true)
            {
                if (L1 == L2 & Lo1 == Lo2)
                {
                    ErrorMsgBox("Initial and final positions are the same.");
                    Flag1 = true;
                    return;
                }

                if (optGreatCircle.Checked == true & L1 == -L2 & Math.Sign(Lo1) != Math.Sign(Lo2) & Math.Abs(Lo1) + Math.Abs(Lo2) == 180d)
                {
                    ErrorMsgBox("Distance 10800 nm.  Course between antipodal points is undefined.");
                    return;
                }
                // If optGreatCircle = True And L1 = -L2 And DLo = 180 Then Cls:  ErrorMsgBox "Distance 10800 nm.  Course between antipodal points is undefined.": Exit Sub
                if (Lo1 != Lo2 & (int)chkComposite.CheckState == 1 & optMethod1.Checked == false & optMethod2.Checked == false)
                {
                    ErrorMsgBox("You must select a method.");
                    return; // added Lo1<>LO2 in V5.1.2
                }
                // If Lo1 = Lo2 And L1 > L2 Then Course = 180: Distance = Abs(L2 - L1) * 60: FinalGCCourse: DisplayCD: Exit Sub
                // If Lo1 = Lo2 And L1 < L2 Then Course = 0: Distance = Abs(L2 - L1) * 60: FinalGCCourse: DisplayCD: Exit Sub
                if (Lo1 == Lo2)
                {
                    if (chkComposite.Checked == true)
                    {
                        ErrorMsgBox("Composite Sailing not needed and will be disabled.");
                        chkComposite.CheckState = CheckState.Unchecked; // added If chkComposite = 1 Then in V5.1.2
                    }

                    if (L1 > L2)
                    {
                        Course = 180d;
                        CourseFinal = 180d;
                    }

                    if (L1 < L2)
                    {
                        Course = 0d;
                        CourseFinal = 0d;
                    }

                    Distance = Math.Abs(L2 - L1) * 60d;
                    if (Math.Abs(L1) > Math.Abs(L2))
                    {
                        MaxLat = L1;
                    }

                    if (Math.Abs(L1) < Math.Abs(L2) | Math.Abs(L1) == Math.Abs(L2))
                    {
                        MaxLat = L2;
                    }
                    // MaxLatDeg = Int(Abs(MaxLat))
                    // MaxLatMin = (Abs(MaxLat) - MaxLatDeg) * 60
                    // FinalGCCourse
                    DisplayCD();
                    return;
                }

                if (Math.Sign(Lo1) != Math.Sign(Lo2) & Math.Abs(Lo1) + Math.Abs(Lo2) == 180d)
                {
                    // If DLo = 180 Then
                    // If Abs(L1) > Abs(L2) Then Course = 0
                    // If Abs(L1) < Abs(L2) Then Course = 180
                    // Distance = Abs(L2 - L1) * 60
                    // If Abs(L1) > Abs(L2) Then MaxLat = L1
                    // If Abs(L1) < Abs(L2) Then MaxLat = L2
                    if (Math.Abs(L1) >= Math.Abs(L2) & Math.Sign(L1) == Math.Sign(L2) & L1 > 0d)
                    {
                        Course = 0d;
                        Distance = (180d - Math.Abs(L2) - Math.Abs(L1)) * 60d;
                        MaxLat = 90d;
                        CourseFinal = 180d;
                    }

                    if (Math.Abs(L1) >= Math.Abs(L2) & Math.Sign(L1) == Math.Sign(L2) & L1 < 0d)
                    {
                        Course = 180d;
                        Distance = (180d - Math.Abs(L2) - Math.Abs(L1)) * 60d;
                        MaxLat = -90;
                        CourseFinal = 0d;
                    }

                    if (Math.Abs(L1) >= Math.Abs(L2) & Math.Sign(L1) != Math.Sign(L2) & L1 > 0d)
                    {
                        Course = 0d;
                        Distance = (180d + Math.Abs(L2) - Math.Abs(L1)) * 60d;
                        MaxLat = 90d;
                        CourseFinal = 180d;
                    }

                    if (Math.Abs(L1) >= Math.Abs(L2) & Math.Sign(L1) != Math.Sign(L2) & L1 < 0d)
                    {
                        Course = 180d;
                        Distance = (180d + Math.Abs(L2) - Math.Abs(L1)) * 60d;
                        MaxLat = -90;
                        CourseFinal = 0d;
                    }

                    if (Math.Abs(L1) < Math.Abs(L2) & Math.Sign(L1) == Math.Sign(L2) & L1 > 0d)
                    {
                        Course = 0d;
                        Distance = (180d - Math.Abs(L2) - Math.Abs(L1)) * 60d;
                        MaxLat = 90d;
                        CourseFinal = 180d;
                    }

                    if (Math.Abs(L1) < Math.Abs(L2) & Math.Sign(L1) == Math.Sign(L2) & L1 < 0d)
                    {
                        Course = 180d;
                        Distance = (180d - Math.Abs(L2) - Math.Abs(L1)) * 60d;
                        MaxLat = -90;
                        CourseFinal = 0d;
                    }

                    if (Math.Abs(L1) < Math.Abs(L2) & Math.Sign(L1) != Math.Sign(L2) & L1 > 0d)
                    {
                        Course = 180d;
                        Distance = (180d - Math.Abs(L2) + Math.Abs(L1)) * 60d;
                        MaxLat = -90;
                        CourseFinal = 0d;
                    }

                    if (Math.Abs(L1) < Math.Abs(L2) & Math.Sign(L1) != Math.Sign(L2) & L1 < 0d)
                    {
                        Course = 0d;
                        Distance = (180d - Math.Abs(L2) + Math.Abs(L1)) * 60d;
                        MaxLat = 90d;
                        CourseFinal = 180d;
                    }
                    // MaxLatDeg = Int(Abs(MaxLat))
                    // MaxLatMin = (Abs(MaxLat) - MaxLatDeg) * 60
                    // FinalGCCourse
                    DisplayCD();
                    return;
                }

                if (Math.Abs(L1) == 90d | Math.Abs(L2) == 90d)
                {
                    if (L1 == 90d | L2 == -90)
                    {
                        Course = 180d;
                        CourseFinal = 180d;
                    }

                    if (L1 == -90 | L2 == 90d)
                    {
                        Course = 0d;
                        CourseFinal = 0d;
                    }

                    if (L1 == 90d)
                        MaxLat = 90d;
                    if (L1 == -90)
                        MaxLat = -90;
                    if (Math.Sign(L1) == Math.Sign(L2))
                    {
                        Distance = 60d * Math.Abs(L1 - L2);
                    }

                    if (Math.Sign(L1) != Math.Sign(L2))
                    {
                        Distance = 60d * (Math.Abs(L1) + Math.Abs(L2));
                    }

                    DisplayCD();
                    return;
                }

                Direction = 1; // West
                DLo = Lo2 - Lo1;
                if (DLo < 0d)
                {
                    Direction = -1;
                }

                if (DLo > 180d)
                {
                    DLo = 360d - DLo;
                    Direction = -1;
                }

                if (DLo < -180)
                {
                    DLo = 360d - Math.Abs(DLo);
                    Direction = 1;
                }
                // If DLo < 0 Then Direction = -1
                SignL1 = Math.Sign(L1);
                SignL2 = Math.Sign(L2);
                if (Math.Sign(L1) != Math.Sign(L2) & Math.Sign(L1) != 0 & Math.Sign(L2) != 0)
                {
                    L2 = -Math.Abs(L2);
                }
                else
                {
                    L2 = Math.Abs(L2);
                }

                L1 = Math.Abs(L1);
                Distance = Math.Sin(L1 * Pi / 180d) * Math.Sin(L2 * Pi / 180d) + Math.Cos(L1 * Pi / 180d) * Math.Cos(L2 * Pi / 180d) * Math.Cos(DLo * Pi / 180d);
                Distance = Math.Atan(-Distance / (Math.Sqrt(-Distance * Distance + 1d) + 9.999999E-21d)) + Pi / 2d;
                CourseAngle = (Math.Sin(L2 * Pi / 180d) - Math.Sin(L1 * Pi / 180d) * Math.Cos(Distance)) / (Math.Cos(L1 * Pi / 180d) * Math.Sin(Distance)); // add SignL1?
                if (DLo != 0d & Math.Abs(DLo) != 180d)
                {
                    CourseAngle = Math.Atan(-CourseAngle / (Math.Sqrt(-CourseAngle * CourseAngle + 1d) + 9.999999E-21d)) + Pi / 2d;
                }

                Distance = Distance * 180d / Pi * 60d;
                CourseAngleDeg = CourseAngle * 180d / Pi;
                if (SignL1 >= 0 & Direction == 1)
                {
                    Course = 360d - CourseAngleDeg;
                }

                if (SignL1 >= 0 & Direction == -1)
                {
                    Course = CourseAngleDeg;
                }

                if (SignL1 < 0 & Direction == 1)
                {
                    Course = 180d + CourseAngleDeg;
                }

                if (SignL1 < 0 & Direction == -1)
                {
                    Course = 180d - CourseAngleDeg;
                }

                if (Lo1 == Lo2 & L1 > L2)
                {
                    Course = 180d;
                }

                if (Lo1 == Lo2 & L1 < L2)
                {
                    Course = 0d;
                }

                InitialQuadrant = (int)(Conversion.Int(Course / 90d) + 1d);
                FinalGCCourse();
                if ((int)chkComposite.CheckState == 1 & optMethod1.Checked == true)
                {
                    GCCrossings();
                }

                if ((int)chkComposite.CheckState == 1 & optMethod2.Checked == true)
                {
                    GCVertices();
                }

                if (Flag2 == true)
                {
                    return;
                }
            }

            if (optL2Lo2GC.Checked == true) // Mathematically radius of spherical Earth = (360 * 60)/(2 * Pi) = 3437.75
            {
                L2 = Math.Sin(L1 * Pi / 180d) * Math.Cos(Conversion.Val(txtDist.Text) / 3437.75d) + Math.Cos(L1 * Pi / 180d) * Math.Sin(Conversion.Val(txtDist.Text) / 3437.75d) * Math.Cos(Conversion.Val(txtCourse.Text) * Pi / 180d);
                L2 = Math.Atan(L2 / Math.Sqrt(-L2 * L2 + 1d));
                Lo2 = Lo1 * Pi / 180d - Math.Atan2(Math.Sin(Conversion.Val(txtCourse.Text) * Pi / 180d) * Math.Sin(Conversion.Val(txtDist.Text) / 3437.75d) * Math.Cos(L1 * Pi / 180d), Math.Cos(Conversion.Val(txtDist.Text) / 3437.75d) - Math.Sin(L1 * Pi / 180d) * Math.Sin(L2));
                L2 = L2 * 180d / Pi;
                Lo2 = Lo2 * 180d / Pi;
                if (Conversion.Val(txtCourse.Text) == 0d & Conversion.Val(txtDist.Text) > (90d - L1) * 60d)
                {
                    Lo2 = -(180d - Lo2);
                }
                // If Val(txtCourse.Text) = 0 And L1 > 0 And Val(txtDist.Text) > (90 - L1) * 60 Then Lo2 = -(180 - Lo2)
                // If Val(txtCourse.Text) = 180 And L1 < 0 And Val(txtDist.Text) > (90 - Abs(L1)) * 60 Then Lo2 = -(180 - Lo2)
                if (Math.Abs(Lo2) > 180d)
                {
                    Lo2 = -Math.Sign(Lo2) * (360d - Math.Abs(Lo2));
                }

                Direction = 1; // West
                DLo = Lo2 - Lo1;
                if (DLo < 0d)
                {
                    Direction = -1;
                }

                if (DLo > 180d)
                {
                    DLo = 360d - DLo;
                    Direction = -1;
                }

                if (DLo < -180)
                {
                    DLo = 360d - Math.Abs(DLo);
                    Direction = 1;
                }

                InitialQuadrant = (int)(Conversion.Int(Conversion.Val(txtCourse.Text) / 90d) + 1d);
            }
            // Formula for maximum latitude (vertex) of entire great circle, not necessarily on route
            if (optICD.Checked == true)
            {
                MaxLat = Math.Abs(Math.Sin(Course * Pi / 180d) * Math.Cos(L1 * Pi / 180d));
            }

            if (optL2Lo2GC.Checked == true)
            {
                MaxLat = Math.Abs(Math.Sin(Conversion.Val(txtCourse.Text) * Pi / 180d) * Math.Cos(L1 * Pi / 180d));
            }

            if (MaxLat == 1d)
            {
                MaxLat = L2;
                goto Degrees; // ACos(1)=0     what is this line for??????????
            }

            MaxLat = Math.Atan(-MaxLat / Math.Sqrt(-MaxLat * MaxLat + 1d)) + Pi / 2d; // this is ACos(MaxLat)
            FinalGCCourse();
            // This makes it maximum latitude on route        DOESN'T SEEM TO WORK IF MAX LAT IS AT BEGINNING OR END OF ROUTE
            if (InitialQuadrant == FinalQuadrant)
            {
                MaxLat = L2 * Pi / 180d;
                LoVertex = Lo2;
                if (Math.Abs(L1) > Math.Abs(L2))
                {
                    MaxLat = L1;
                    LoVertex = Lo1;
                }

                goto Degrees;
            }

            MaxLat = Math.Abs(MaxLat);
            if (Math.Abs(L1) > Math.Abs(L2))
            {
                MaxLat = Math.Sign(L1) * MaxLat;
            }

            if (Math.Abs(L1) < Math.Abs(L2))
            {
                MaxLat = Math.Sign(L2) * MaxLat;
            }

            if (optICD.Checked == true)
            {
                DLoVertex = Math.Cos(Course * Pi / 180d) / Math.Sin(MaxLat);
            }

            if (optL2Lo2GC.Checked == true)
            {
                DLoVertex = Math.Cos(Conversion.Val(txtCourse.Text) * Pi / 180d) / Math.Sin(MaxLat);
            }

            DLoVertex = Math.Atan(DLoVertex / (Math.Sqrt(-DLoVertex * DLoVertex + 1d) + 9.999999E-21d)); // arcsin
            if (Direction == -1)
            {
                DLoVertex = -DLoVertex;
            }

            LoVertex = Lo1 + DLoVertex * 180d / Pi;
            if (Math.Abs(LoVertex) > 180d)
            {
                LoVertex = -Math.Sign(LoVertex) * (360d - Math.Abs(LoVertex));
            }
        // LoVertexDeg = Int(Abs(LoVertex))
        // LoVertexMin = (Abs(LoVertex) - LoVertexDeg) * 60
        // LoVertexMin = Int(LoVertexMin * 10 + 0.5) / 10
        // If LoVertexMin = 60 Then LoVertexMin = 0: LoVertexDeg = LoVertexDeg + 1


        Degrees:
            ;
            MaxLat = MaxLat * 180d / Pi; // this is maximum latitude of entire great circle, not just of route
            LoVertexDeg = (int)Conversion.Int(Math.Abs(LoVertex));
            LoVertexMin = (Math.Abs(LoVertex) - LoVertexDeg) * 60d;
            LoVertexMin = Conversion.Int(LoVertexMin * 10d + 0.5d) / 10d;
            if (LoVertexMin == 60d)
            {
                LoVertexMin = 0d;
                LoVertexDeg = LoVertexDeg + 1;
            }

            // If SignL1 = 1 And Course > 90 And Course < 270 Then    'maybe SignL1>=0
            // If Abs(SignL1 * Abs(L1)) > Abs(SignL2 * Abs(L2)) Then MaxLat = SignL1 * Abs(L1): CourseAngleDeg = 180
            // If Abs(SignL1 * Abs(L1)) <= Abs(SignL2 * Abs(L2)) Then MaxLat = SignL2 * Abs(L2): CourseAngleDeg = 0
            // End If
            // If SignL1 = -1 And (Course > 270 Or Course < 90) Then
            // If Abs(SignL1 * Abs(L1)) > Abs(SignL2 * Abs(L2)) Then MaxLat = SignL1 * Abs(L1): CourseAngleDeg = 180
            // If Abs(SignL1 * Abs(L1)) <= Abs(SignL2 * Abs(L2)) Then MaxLat = SignL2 * Abs(L2): CourseAngleDeg = 0
            // End If
            // If DLo = 0 Then
            // If DLo < 0.0000001 Then
            // Course = 0: MaxLat = SignL2 * Abs(L2): CourseAngleDeg = 0
            // If Abs(SignL1 * Abs(L1)) > Abs(SignL2 * Abs(L2)) Then MaxLat = SignL1 * Abs(L1): CourseAngleDeg = 180
            // If SignL1 * Abs(L1) > SignL2 * Abs(L2) Then Course = 180
            // 'If L1 > L2 Then Course = 180
            // 'If L1 < L2 Then Course = 0
            // End If
            // 'If InitialQuadrant = FinalQuadrant Then MaxLat = L2: If Abs(L1) > Abs(L2) Then MaxLat = L1
            // If Abs(DLo) = 180 Then
            // Course = 0: MaxLat = 90: CourseAngleDeg = 0
            // If Abs(SignL1 * Abs(L1)) > Abs(SignL2 * Abs(L2)) Then MaxLat = -90: CourseAngleDeg = 180
            // If SignL1 * Abs(L1) > SignL2 * Abs(L2) Then Course = 180
            // End If
            if (optL2Lo2GC.Checked == true)
            {
                if ((Conversion.Val(txtCourse.Text) == 0d | Conversion.Val(txtCourse.Text) == 180d) & (Math.Sign(Lo1) == Math.Sign(Lo2) | Math.Sign(Lo1) == 0))
                {
                    if (Math.Abs(L1) > Math.Abs(L2))
                        MaxLat = L1;
                    if (Math.Abs(L1) < Math.Abs(L2))
                        MaxLat = L2;
                }

                if (Conversion.Val(txtCourse.Text) == 0d & (Math.Sign(Lo1) != Math.Sign(Lo2) | Math.Sign(Lo1) == 0))
                    MaxLat = 90d;
                if (Conversion.Val(txtCourse.Text) == 180d & Math.Sign(Lo1) != Math.Sign(Lo2))
                    MaxLat = -90;
            }
            // MaxLatDeg = Int(Abs(MaxLat))
            // MaxLatMin = (Abs(MaxLat) - MaxLatDeg) * 60: MaxLatMin = Int(MaxLatMin * 10 + 0.5) / 10
            // If MaxLatMin = 60 Then MaxLatMin = 0: MaxLatDeg = MaxLatDeg + 1
            // InitialQuadrant = Int(Course / 90) + 1
            FinalGCCourse();
            if (InitialQuadrant == FinalQuadrant)
            {
                MaxLat = L2;
                if (Math.Abs(L1) > Math.Abs(L2))
                    MaxLat = L1;
            }
            // If Lo1 > 180 Then Lo1 = 360 - Lo1
            // If Lo2 > 180 Then Lo2 = 360 - Lo1
            if (optICD.Checked == true)
            {
                DisplayCD();
            }

            if (optL2Lo2GC.Checked == true)
            {
                DisplayDestination();
            }
        }

        public void TestML()
        {
            // 'If ((Abs(L1) >= Abs(L2) And Abs(Abs(L1) - Abs(LmML)) > 0.5)) Or ((Abs(L2) >= Abs(L1) And Abs(Abs(L2) - Abs(LmML)) > 0.5)) Then
            // If Sgn(L1) = Sgn(L2) And _
            // '    (Abs(L1) >= Abs(L2) And Abs(L2) >= Abs(LmML) And Abs(L1 - LmML) > 0.5) Or _
            // '    (Abs(L2) >= Abs(L1) And Abs(L1) >= Abs(LmML) And Abs(L2 - LmML) > 0.5) Or _
            // '    (Abs(L1) >= Abs(L2) And Abs(LmML) >= Abs(L1) And Abs(L2 - LmML) > 0.5) Or _
            // '    (Abs(L2) >= Abs(L1) And Abs(LmML) >= Abs(L2) And Abs(L1 - LmML) > 0.5) Then
            // 'txtMLDeg.BackColor = &HFF&
            // 'cboMLmin.BackColor = &HFF&
            // 'cboML.BackColor = &HFF&
            // ErrorMsgBox "Unacceptable mid-latitude.  Requires more than 1º of latitude for CLS SAPS.": Cls: BadCLS = True
            // 'Else
            // 'txtMLDeg.BackColor = &H80000005
            // 'cboMLmin.BackColor = &H80000005
            // 'cboML.BackColor = &H80000005
            // End If
            // If Sgn(L1) <> Sgn(L2) And (Abs(L2 - LmML) > 0.5 Or Abs(L1 - LmML) > 0.5) Then _
            // '     ErrorMsgBox "Unacceptable mid-latitude.  Requires more than 1º of latitude for CLS SAPS.": Cls: BadCLS = True
            // If Abs(L2 - LmML) > 0.5 Or Abs(L1 - LmML) > 0.5 Then _
            // Messagebox.show "Unacceptable mid-latitude.  Requires more than 1º of latitude for CLS SAPS.": Cls: BadCLS = True
            if (optL2Lo2.Checked == false & Math.Abs(L2 - LmML) > 0.5d | Math.Abs(L1 - LmML) > 0.5d)
            {
                ErrorMsgBox("Unacceptable mid-latitude.  Requires more than 1º of latitude for CLS SAPS.");
                BadCLS = true;
            }
        }
        // Public Function Atan2(ByVal y As Double, ByVal x As Double) As Double
        // Type 1
        // If y > 0 Then
        // If x >= y Then
        // Atan2 = Atn(y / x)
        // ElseIf x <= -y Then
        // Atan2 = Atn(y / x) + Pi
        // Else
        // Atan2 = Pi / 2 - Atn(x / y)
        // End If
        // Else
        // If x >= -y Then
        // Atan2 = Atn(y / x)
        // ElseIf x <= y Then
        // Atan2 = Atn(y / x) - Pi
        // Else
        // Atan2 = -Atn(x / y) - Pi / 2
        // End If
        // End If
        // Type 2
        // If x > 0 And y >= 0 Then Atan2 = Atn(y / x)                  'added and y>=0
        // If x < 0 And y >= 0 Then Atan2 = Atn(y / x) + Pi
        // If x = 0 And y > 0 Then Atan2 = Pi / 2
        // If x < 0 And y < 0 Then Atan2 = Atn(y / x) - Pi
        // If x = 0 And y < 0 Then Atan2 = -Pi / 2
        // 'If x = 0 And y = 0 Then  ErrorMsgBox "Distance cannot be zero."
        // Type 3
        // If x > 0 Then
        // Atan2 = Math.Atan(y / x)
        // ElseIf x < 0 Then
        // Atan2 = Math.Sign(y) * (Pi - Math.Atan(Math.Abs(y / x)))
        // ElseIf y = 0 Then
        // Atan2 = 0
        // Else
        // Atan2 = Math.Sign(y) * Pi / 2
        // End If
        // End Function

        public void FinalGCCourse()
        {
            // Final course is initial course going the other way +180
            if (optICD.Checked == true)
            {
                LatLong();
            }

            L3 = Conversion.Val(txtL3Deg.Text) + Conversion.Val(txtL3Min.Text) / 60d;
            if (cboL3.Text == "S")
            {
                L3 = -L3;
            }
            // If chkComposite = 1 Then
            // If Abs(L1) = Abs(L3) Then If Course >= 0 And Course < 180 Then Course1 = 90 Else Course1 = 270: Exit Sub
            // If Abs(L2) = Abs(L3) Then If Course >= 0 And Course < 180 Then Course3 = 90 Else Course3 = 270: Exit Sub
            // 'Exit Sub
            // End If
            if ((int)chkComposite.CheckState == 1 & L2 == L3)
            {
                return; // (L1 = L3 Or L2 = L3)
            }

            L1Final = L2;
            L2Final = L1;
            Lo1Final = Lo2;
            Lo2Final = Lo1;
            // If optICD.Value = True Then
            DirectionFinal = 1; // West
            DLoFinal = Lo2Final - Lo1Final;
            if (DLoFinal < 0d)
            {
                DirectionFinal = -1;
            }

            if (DLoFinal > 180d)
            {
                DLoFinal = 360d - DLoFinal;
                DirectionFinal = -1;
            }

            if (DLoFinal < -180)
            {
                DLoFinal = 360d - Math.Abs(DLoFinal);
                DirectionFinal = 1;
            }

            if (Math.Abs(DLoFinal) < 0.000001d)
            {
                DLoFinal = 0d;
                DirectionFinal = 0;
            }

            SignL1Final = Math.Sign(L1Final);
            SignL2Final = Math.Sign(L2Final);
            if (Math.Sign(L1Final) != Math.Sign(L2Final) & Math.Sign(L1Final) != 0 & Math.Sign(L2Final) != 0)
            {
                L2Final = -Math.Abs(L2Final);
            }
            else
            {
                L2Final = Math.Abs(L2Final);
            }

            L1Final = Math.Abs(L1Final);
            DistanceFinal = Math.Sin(L1Final * Pi / 180d) * Math.Sin(L2Final * Pi / 180d) + Math.Cos(L1Final * Pi / 180d) * Math.Cos(L2Final * Pi / 180d) * Math.Cos(DLoFinal * Pi / 180d);
            DistanceFinal = Math.Atan(-DistanceFinal / (Math.Sqrt(-DistanceFinal * DistanceFinal + 1d) + 9.999999E-21d)) + Pi / 2d;
            CourseAngleFinal = (Math.Sin(L2Final * Pi / 180d) - Math.Sin(L1Final * Pi / 180d) * Math.Cos(DistanceFinal)) / (Math.Cos(L1Final * Pi / 180d) * Math.Sin(DistanceFinal)); // add SignL1?
            if (Math.Abs(DLoFinal) != 0d & Math.Abs(DLoFinal) != 180d)
            {
                CourseAngleFinal = Math.Atan(-CourseAngleFinal / (Math.Sqrt(-CourseAngleFinal * CourseAngleFinal + 1d) + 9.999999E-21d)) + Pi / 2d;
            }

            DistanceFinal = DistanceFinal * 180d / Pi * 60d;
            CourseAngleDegFinal = CourseAngleFinal * 180d / Pi;
            if (SignL1Final >= 0 & DirectionFinal == 1)
            {
                CourseFinal = 360d - CourseAngleDegFinal;
            }

            if (SignL1Final >= 0 & DirectionFinal == -1)
            {
                CourseFinal = CourseAngleDegFinal;
            }

            if (SignL1Final < 0 & DirectionFinal == 1)
            {
                CourseFinal = 180d + CourseAngleDegFinal;
            }

            if (SignL1Final < 0 & DirectionFinal == -1)
            {
                CourseFinal = 180d - CourseAngleDegFinal;
            }
            // If DirectionFinal = 0 And L1Final > L2Final Then CourseFinal = 0
            // If DirectionFinal = 0 And L1Final < L2Final Then CourseFinal = 180
            // End If
            // If optL2Lo2GC.Value = True Then
            // L2Final = Sin(L1Final * Pi / 180) * Cos(Val(txtDist.Text) / 3440.07) + Cos(L1Final * Pi / 180) * Sin(Val(txtDist.Text) / 3440.07) * Cos((Val(txtCourse.Text) + 180) * Pi / 180)
            // L2Final = Atn(L2Final / Sqr(-L2Final * L2Final + 1))

            // DLo = Atan2(Sin(Val(txtCourse.Text) * Pi / 180) * Sin(Val(txtDist.Text) * Pi / 180) * Cos(L1 * Pi / 180), Cos(Val(txtDist.Text) * Pi / 180) - Sin(L1 * Pi / 180) * Sin(L2))
            // Lo2 = (Lo1 * Pi / 180 - DLo + Pi) Mod (2 * Pi) - Pi

            // Lo2Final = Lo1Final * Pi / 180 - Atan2(Sin((Val(txtCourse.Text) + 180) * Pi / 180) * Sin(Val(txtDist.Text) / 3440.07) * Cos(L1Final * Pi / 180), Cos(Val(txtDist.Text) / 3440.07) - Sin(L1 * Pi / 180) * Sin(L2Final))
            // L2Final = L2Final * 180 / Pi
            // Lo2Final = Lo2Final * 180 / Pi
            // If Abs(Lo2Final) > 180 Then Lo2Final = -Sgn(Lo2Final) * (360 - Abs(Lo2Final))
            // DirectionFinal = 1 'West
            // DLoFinal = Lo2Final - Lo1Final: If DLoFinal < 0 Then DirectionFinal = -1
            // If DLoFinal > 180 Then DLoFinal = 360 - DLoFinal: DirectionFinal = -1
            // If DLoFinal < -180 Then DLoFinal = 360 - Abs(DLoFinal): DirectionFinal = 1
            // End If
            if (optL2Lo2GC.Checked == true)
            {
                if (Math.Abs(Lo1Final) < 0.00001d)
                {
                    Lo1Final = 0d;
                }

                if ((Conversion.Val(txtCourse.Text) == 0d | Conversion.Val(txtCourse.Text) == 180d) & Math.Sign(Lo1Final) == Math.Sign(Lo2Final))
                {
                    CourseFinal = Conversion.Val(txtCourse.Text) + 180d;
                }

                if ((Conversion.Val(txtCourse.Text) == 0d | Conversion.Val(txtCourse.Text) == 180d) & Math.Sign(Lo1Final) != Math.Sign(Lo2Final))
                {
                    CourseFinal = Conversion.Val(txtCourse.Text);
                }
            }
            // If L2 = 90 Or L2 = -90 Then CourseFinal = CourseFinal + 180
            CourseFinal = CourseFinal + 180d;
            if (CourseFinal >= 360d)
            {
                CourseFinal = CourseFinal - 360d;
            }

            if ((int)chkComposite.CheckState == 1 & optMethod1.Checked == true)
            {
                Course3 = CourseFinal; // for composite sailing Method 1
            }

            // If Lo1Final = Lo2Final Then CourseFinal = Course
            FinalQuadrant = (int)(Conversion.Int(CourseFinal / 90d) + 1d);
        }

        public double ModFP(double y, double x)
        {
            // Modulus function that works with floating point numbers
            return y - x * Conversion.Fix(y / x);
        }

        private void DriftAngle()
        {
            LatDiff = L2 - Fix1L;
            DLo = Lo2 - Fix1Lo;
            // Crossing IDL
            if (Math.Abs(DLo) > 180d)
            {
                DLo = -Math.Sign(DLo) * (360d - Math.Abs(DLo));
            }

            dphi = Math.Log(Math.Tan(L2 * Pi / 180d / 2d + Pi / 4d) / Math.Tan(Fix1L * Pi / 180d / 2d + Pi / 4d));
            if (Math.Abs(LatDiff) < Math.Sqrt(0.000000000000001d))
            {
                q = Math.Cos(Fix1L * Pi / 180d);
            }
            else
            {
                q = LatDiff * Pi / 180d / dphi;
            }

            CourseAngle = 2d * Math.Atan((Math.Sqrt(DLo * Pi / 180d * DLo * Pi / 180d + dphi * dphi) - dphi) / ((DLo + 9.999999E-21d) * Pi / 180d));
            CourseAngleDeg = CourseAngle * 180d / Pi;
            if (LatDiff >= 0d & DLo < 0d)
            {
                Course = Math.Abs(CourseAngleDeg);
            }

            if (LatDiff >= 0d & DLo >= 0d)
            {
                Course = 360d - Math.Abs(CourseAngleDeg);
            }

            if (LatDiff < 0d & DLo < 0d)
            {
                Course = Math.Abs(CourseAngleDeg);
            }

            if (LatDiff < 0d & DLo >= 0d)
            {
                Course = 360d - Math.Abs(CourseAngleDeg);
            }

            CourseToFix = Course; // course to fix
            LatDiff = L1 - Fix1L;
            DLo = Lo1 - Fix1Lo;
            // Crossing IDL
            if (Math.Abs(DLo) > 180d)
            {
                DLo = -Math.Sign(DLo) * (360d - Math.Abs(DLo));
            }

            dphi = Math.Log(Math.Tan(L1 * Pi / 180d / 2d + Pi / 4d) / Math.Tan(Fix1L * Pi / 180d / 2d + Pi / 4d));
            if (Math.Abs(LatDiff) < Math.Sqrt(0.000000000000001d))
            {
                q = Math.Cos(Fix1L * Pi / 180d);
            }
            else
            {
                q = LatDiff * Pi / 180d / dphi;
            }

            CourseAngle = 2d * Math.Atan((Math.Sqrt(DLo * Pi / 180d * DLo * Pi / 180d + dphi * dphi) - dphi) / ((DLo + 9.999999E-21d) * Pi / 180d));
            CourseAngleDeg = CourseAngle * 180d / Pi;
            if (LatDiff >= 0d & DLo < 0d)
            {
                Course = Math.Abs(CourseAngleDeg);
            }

            if (LatDiff >= 0d & DLo >= 0d)
            {
                Course = 360d - Math.Abs(CourseAngleDeg);
            }

            if (LatDiff < 0d & DLo < 0d)
            {
                Course = Math.Abs(CourseAngleDeg);
            }

            if (LatDiff < 0d & DLo >= 0d)
            {
                Course = 360d - Math.Abs(CourseAngleDeg);
            }

            CourseToDR = Course; // course to DR
            DriftAng = Math.Abs(CourseToFix - CourseToDR);
            // DriftAng = CourseToFix - CourseToDR
            Flag4 = false;
            if (DriftAng > 180d)
            {
                DriftAng = 360d - DriftAng;
                Flag4 = true;
            }

            DriftAng = Conversion.Int(DriftAng + 0.5d);
        }

        private void txtFix1LD_TextChanged(object eventSender, EventArgs eventArgs)
        {
            txtFix1LD.BackColor = SystemColors.Window;
            if (Conversion.Val(txtFix1LD.Text) > 89d)
            {
                txtFix1LD.BackColor = Color.Red;
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtFix1LD.Text) <= 89d)
            {
                txtFix1LM.BackColor = SystemColors.Window;
            }
        }

        private void txtFix1LD_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            int KeyAscii = Strings.Asc(eventArgs.KeyChar);
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

        private void txtFix1LD_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtFix1LD.Text) > 89d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtFix1LD_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtFix1LD;
            SelectAllText(ref argTB);
            txtFix1LD = argTB;
        }

        private void txtFix1LM_TextChanged(object eventSender, EventArgs eventArgs)
        {
            txtFix1LM.BackColor = SystemColors.Window;
            if (Conversion.Val(txtFix1LM.Text) > 59.9d)
            {
                txtFix1LM.BackColor = Color.Red;
                ErrorMsgBox("Out of Range");
            }
        }

        private void txtFix1LM_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            int KeyAscii = Strings.Asc(eventArgs.KeyChar);
            switch (KeyAscii)
            {
                case var @case when Strings.Asc("0") <= @case && @case <= Strings.Asc("9"):
                    {
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                case (short)('.'): // only allows one decimal point
                    {
                        if (Conversions.ToBoolean(Strings.InStr(txtFix1LM.Text, ".")))
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

        private void txtFix1LM_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtFix1LM.Text) > 59.9d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtFix1LM_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtFix1LM;
            SelectAllText(ref argTB);
            txtFix1LM = argTB;
        }

        private void txtFix1LoD_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtFix1LoD.Text) != 180d)
            {
                txtFix1LoM.Enabled = true;
            }

            if (Conversion.Val(txtFix1LoD.Text) == 180d)
            {
                txtFix1LoM.Enabled = false;
                txtFix1LoM.BackColor = Color.Gray;
            }

            txtFix1LoD.BackColor = SystemColors.Window;
            if (Conversion.Val(txtFix1LoD.Text) > 180d | Conversion.Val(txtFix1LoD.Text) == 180d & Conversion.Val(txtFix1LoM.Text) != 0d)
            {
                txtFix1LoD.BackColor = Color.Red;
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtFix1LoD.Text) < 180d)
            {
                txtFix1LoM.BackColor = SystemColors.Window;
            }
        }

        private void txtFix1LoD_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            int KeyAscii = Strings.Asc(eventArgs.KeyChar);
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

        private void txtFix1LoD_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtFix1LoD.Text) > 180d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtFix1LoD_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtFix1LoD;
            SelectAllText(ref argTB);
            txtFix1LoD = argTB;
        }

        private void txtFix1LoM_TextChanged(object eventSender, EventArgs eventArgs)
        {
            txtFix1LoM.BackColor = SystemColors.Window;
            if (Conversion.Val(txtFix1LoM.Text) > 59.9d)
            {
                txtFix1LoM.BackColor = Color.Red;
                ErrorMsgBox("Out of Range");
            }
        }

        private void txtFix1LoM_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            int KeyAscii = Strings.Asc(eventArgs.KeyChar);
            switch (KeyAscii)
            {
                case var @case when Strings.Asc("0") <= @case && @case <= Strings.Asc("9"):
                    {
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                case (short)('.'): // only allows one decimal point
                    {
                        if (Conversions.ToBoolean(Strings.InStr(txtFix1LoM.Text, ".")))
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

        private void txtFix1LoM_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtFix1LoM.Text) > 59.9d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtFix1LoM_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtFix1LoM;
            SelectAllText(ref argTB);
            txtFix1LoM = argTB;
        }

        public void GCCrossings() // for use with Composite Method 1
        {
            // Suppose a great circle passes through (L1,Lo1) and (L2,Lo2). It crosses the parallel L3 at longitudes Lon31 and Lon32 given by:
            L3 = (Conversion.Val(txtL3Deg.Text) + Conversion.Val(txtL3Min.Text) / 60d) * Pi / 180d;
            if (cboL3.Text == "S")
            {
                L3 = -L3;
            }
            // If vertex (maximum latitude) is not between the ends of the great circle route, message and exit sub
            // If (Abs(MaxLat) = Abs(L1) Or Abs(MaxLat) = Abs(L2)) And Abs(L3) < Abs(L2 * Pi / 180) And Abs(L3) > Abs(L1 * Pi / 180) Then  ErrorMsgBox ("Destination cannot be reached without exceeding latitude limit."): Exit Sub
            // If Abs(L3 * 180 / Pi) < Abs(L2) Or Abs(L3 * 180 / Pi) < Abs(L1) Then  ErrorMsgBox ("Destination cannot be reached without exceeding latitude limit."): Exit Sub
            Flag2 = false;
            if (Math.Abs(L2) - Math.Abs(L3 * 180d / Pi) > 0.001d | Math.Abs(L1) - Math.Abs(L3 * 180d / Pi) > 0.001d)
            {
                ErrorMsgBox("Destination cannot be reached without exceeding latitude limit.");
                Flag2 = true;
                return;
            }

            DLo = Lo1 - Lo2; // east is + for DLo<=180,
                             // If DLo > 180 Then DLo = -(360 - DLo)
                             // If Course > 180 And Course < 360 Then x = Lo1: Lo1 = Lo2: Lo2 = x
                             // If DLo > 0 Then x = Lo1: Lo1 = Lo2: Lo2 = x
                             // If DLo > 0 Then Lo1 = Lo2
                             // DLo = Lo2 - Lo1
                             // If Abs(DLo) > 180 Then DLo = -Sgn(DLo) * (360 - Abs(DLo))

            A = Math.Sin(L1 * Pi / 180d) * Math.Cos(L2 * Pi / 180d) * Math.Cos(L3) * Math.Sin(DLo * Pi / 180d);
            B = Math.Sin(L1 * Pi / 180d) * Math.Cos(L2 * Pi / 180d) * Math.Cos(L3) * Math.Cos(DLo * Pi / 180d) - Math.Cos(L1 * Pi / 180d) * Math.Sin(L2 * Pi / 180d) * Math.Cos(L3);
            C = Math.Cos(L1 * Pi / 180d) * Math.Cos(L2 * Pi / 180d) * Math.Sin(L3) * Math.Sin(DLo * Pi / 180d);
            Lon = Math.Atan2(B, A); // atan2(y,x) convention
            x = C / Math.Sqrt(Math.Pow(A, 2d) + Math.Pow(B, 2d));
            if (Math.Abs(C) > Math.Sqrt(Math.Pow(A, 2d) + Math.Pow(B, 2d)))
            {
                ErrorMsgBox("Great Circle does not cross latitude limit.  Composite Sailing will not be used.");
                chkComposite.CheckState = CheckState.Unchecked;
                GreatCircle();
                return;
            }
            else
            {
                DLon = Math.Atan(-x / Math.Sqrt(-x * x + 1d)) + Pi / 2d; // arc cosine
                                                                         // If Course > 180 And Course < 360 Then DLon = -DLon
                                                                         // DLon = -DLon
                Lon31 = Lo1 * Pi / 180d - DLon + Lon + Pi;
                // Lon31 = Lon31 - 2 * Pi * Int(Lon31 / (2 * Pi))     'equiv. of next three lines
                while (Lon31 >= 2d * Pi)
                    Lon31 = Lon31 - 2d * Pi;
                Lon31 = Lon31 - Pi;
                Lon31 = Lon31 * 180d / Pi;
                // If Lon31 < 0 Then Lon31 = Lon31 + 180
                if (Math.Abs(Lon31) > 180d)
                    Lon31 = -Math.Sign(Lon31) * (360d - Math.Abs(Lon31));
                Lon32 = Lo1 * Pi / 180d + DLon + Lon + Pi;
                // Lon32 = Lon32 - 2 * Pi * Int(Lon32 / (2 * Pi))     'equiv. of next three lines
                while (Lon32 >= 2d * Pi)
                    Lon32 = Lon32 - 2d * Pi;
                Lon32 = Lon32 - Pi;
                Lon32 = Lon32 * 180d / Pi;
                // If Lon32 < 0 Then Lon32 = Lon32 + 180
                if (Math.Abs(Lon32) > 180d)
                    Lon32 = -Math.Sign(Lon32) * (360d - Math.Abs(Lon32));
            }
            // Interchange Lon31 and Lon32 if course is westward
            // If DLo < 0 Or DLo > 180 Then x = Lon32: Lon32 = Lon31: Lon31 = x
            if (Lon < 0d)
            {
                x = Lon32;
                Lon32 = Lon31;
                Lon31 = x;
            }

            Lon31Deg = (int)Conversion.Int(Math.Abs(Lon31));
            Lon31Min = (Math.Abs(Lon31) - Lon31Deg) * 60d;
            if (Conversion.Int(Lon31Min * 10d + 0.5d) / 10d == 60d)
            {
                Lon31Min = 0d;
                Lon31Deg = Lon31Deg + 1;
            }

            Lon32Deg = (int)Conversion.Int(Math.Abs(Lon32));
            Lon32Min = (Math.Abs(Lon32) - Lon32Deg) * 60d;
            if (Conversion.Int(Lon32Min * 10d + 0.5d) / 10d == 60d)
            {
                Lon32Min = 0d;
                Lon32Deg = Lon32Deg + 1;
            }

            // Calculate initial course and distance of first segment
            L1CD = L1;
            Lo1CD = Lo1;
            L2CD = L3 * 180d / Pi;
            Lo2CD = Lon31;
            CD();
            Course1 = CourseCD;
            if ((int)chkComposite.CheckState == 1 & L1 == L3 * 180d / Pi)
            {
                if (Course >= 0d & Course < 180d)
                {
                    Course1 = 90d;
                }
                else
                {
                    Course1 = 270d;
                }
            }

            Distance1 = DistanceCD;
            // Calculate (course and) distance of second segment
            DLoCD = Lon32 - Lon31;
            if (Math.Abs(DLoCD) > 180d)
            {
                DLoCD = -Math.Sign(DLoCD) * (360d - Math.Abs(DLoCD));
            }

            Distance2 = Math.Cos(L3) * Math.Abs(DLoCD) * 60d;
            // Calculate distance of second segment and final course          1s and 2s swapped in this segment    Was this necessary, since FinalGCCourse is used anyway?
            L2CD = L2;
            L1CD = L3 * 180d / Pi;
            Lo2CD = Conversion.Val(txtLo2Deg.Text) + Conversion.Val(txtLo2Min.Text) / 60d;
            if (cboLo2.Text == "E")
            {
                Lo2CD = -Lo2CD;
            }

            Lo1CD = Lon32;
            CD();
            Distance3 = DistanceCD;
            FinalGCCourse();
            Course3 = CourseFinal; // CourseCD
            if ((int)chkComposite.CheckState == 1 & L2 == L3)
            {
                if (Course >= 0d & Course < 180d)
                {
                    Course3 = 90d;
                }
                else
                {
                    Course3 = 270d;
                }
            }
            // Course3 = CourseCD + 180: If Course3 >= 360 Then Course3 = Course3 - 360

            // If L2 = L3 * 180 / Pi Then FinalGCCourse
            // Course3 = CourseCD


            Distance1 = Conversion.Int(Distance1 * 10d + 0.5d) / 10d;
            Distance2 = Conversion.Int(Distance2 * 10d + 0.5d) / 10d;
            Distance3 = Conversion.Int(Distance3 * 10d + 0.5d) / 10d;
            DistanceComposite = (float)(Distance1 + Distance2 + Distance3);
        }

        public void GCVertices() // for use with Composite Method 2
        {
            // L3 = (Val(txtL3Deg.text) + Val(txtL3Min.text) / 60) * Pi / 180: If cboL3 = "S" Then L3 = -L3

            MaxLat = Math.Abs(Math.Sin(Course * Pi / 180d) * Math.Cos(L1 * Pi / 180d));
            if (MaxLat == 1d)
            {
                MaxLat = L2; // : GoTo Degrees        'ACos(1)=0     what is this line for??????????
            }

            MaxLat = Math.Atan(-MaxLat / Math.Sqrt(-MaxLat * MaxLat + 1d)) + Pi / 2d; // this is ACos(MaxLat)
            MaxLat = MaxLat * 180d / Pi;
            FinalGCCourse();
            // This makes it maximum latitude on route
            if (InitialQuadrant == FinalQuadrant)
            {
                MaxLat = L2 * Pi / 180d;
                LoVertex = Lo2;
                if (Math.Abs(L1) > Math.Abs(L2))
                {
                    MaxLat = L1;
                    LoVertex = Lo1;
                }
                // GoTo Degrees
            }

            MaxLat = Math.Abs(MaxLat);
            if (Math.Abs(L1) > Math.Abs(L2))
            {
                MaxLat = Math.Sign(L1) * MaxLat;
            }

            if (Math.Abs(L1) < Math.Abs(L2))
            {
                MaxLat = Math.Sign(L2) * MaxLat;
            }

            L3 = (Conversion.Val(txtL3Deg.Text) + Conversion.Val(txtL3Min.Text) / 60d) * Pi / 180d;
            if (cboL3.Text == "S")
            {
                L3 = -L3;
            }

            // If vertex (maximum latitude) is not between the ends of the great circle route, message and exit sub
            // If (Abs(MaxLat) = Abs(L1) Or Abs(MaxLat) = Abs(L2)) And Abs(L3 * 180 / Pi) < Abs(L2) And Abs(L3 * 180 / Pi) > Abs(L1) Then  ErrorMsgBox ("Destination cannot be reached without exceeding latitude limit."): Exit Sub
            // If Abs(L3 * 180 / Pi) < Abs(L2) Or Abs(L3 * 180 / Pi) < Abs(L1) Then  ErrorMsgBox ("Destination cannot be reached without exceeding latitude limit."): Exit Sub
            Flag2 = false;
            if (Math.Abs(L2) - Math.Abs(L3 * 180d / Pi) > 0.001d | Math.Abs(L1) - Math.Abs(L3 * 180d / Pi) > 0.001d)
            {
                ErrorMsgBox("Destination cannot be reached without exceeding latitude limit.");
                Flag2 = true;
                return;
            }

            if (Math.Abs(MaxLat) < Math.Abs(L3 * 180d / Pi))
            {
                ErrorMsgBox("Great Circle does not cross latitude limit.  Composite Sailing will not be used.");
                chkComposite.CheckState = CheckState.Unchecked;
                GreatCircle();
                return;
            }

            DLo = Lo2 - Lo1;
            if (Math.Abs(DLo) > 180d)
            {
                DLo = -Math.Sign(DLo) * (360d - Math.Abs(DLo));
            }

            DLo1 = Math.Tan(L1 * Pi / 180d) / Math.Tan(L3);
            if (DLo1 == 1d)
            {
                DLo1 = -0.99999999999999d;
            }

            DLo1 = Math.Atan(-DLo1 / Math.Sqrt(-DLo1 * DLo1 + 1d)) + Pi / 2d; // arc cosine
            if (DLo < 0d)
            {
                DLo1 = -DLo1; // should this be If DLo1 < 0?
            }

            Lon31 = Lo1 * Pi / 180d + DLo1;
            while (Lon31 >= 2d * Pi)
                Lon31 = Lon31 - 2d * Pi;
            if (Lon31 < 0d)
            {
                Lon31 = Lon31 + 2d * Pi;
            }

            Lon31 = Lon31 * 180d / Pi;
            if (Math.Abs(Lon31) > 180d)
            {
                Lon31 = -Math.Sign(Lon31) * (360d - Math.Abs(Lon31));
            }
            // If Abs(L1 - L3 * 180 / Pi) < 0.001 Then Lon31 = Lo1     'less that 0.1' (0.06')
            if (L1 * Pi / 180d == L3)
            {
                Lon31 = Lo1;
            }

            DLo2 = Math.Tan(L2 * Pi / 180d) / Math.Tan(L3);
            if (Math.Abs(DLo2) == 1d)
            {
                DLo2 = -0.99999999999999d;
            }

            DLo2 = Math.Atan(-DLo2 / Math.Sqrt(-DLo2 * DLo2 + 1d)) + Pi / 2d; // arc cosine
            if (DLo < 0d)
            {
                DLo2 = -DLo2; // should this be If DLo2 < 0?
            }

            Lon32 = Lo2 * Pi / 180d - DLo2;
            while (Lon32 >= 2d * Pi)
                Lon32 = Lon32 - 2d * Pi;
            if (Lon32 < 0d)
            {
                Lon32 = Lon32 + 2d * Pi;
            }

            Lon32 = Lon32 * 180d / Pi;
            if (Math.Abs(Lon32) > 180d)
            {
                Lon32 = -Math.Sign(Lon32) * (360d - Math.Abs(Lon32));
            }
            // If Abs(L2 - L3 * 180 / Pi) < 0.001 Then Lon32 = Lo2     'less that 0.1' (0.06')
            if (L2 * Pi / 180d == L3)
            {
                Lon32 = Lo2;
            }

            Lon31Deg = (int)Conversion.Int(Math.Abs(Lon31));
            Lon31Min = (Math.Abs(Lon31) - Lon31Deg) * 60d;
            if (Conversion.Int(Lon31Min * 10d + 0.5d) / 10d == 60d)
            {
                Lon31Min = 0d;
                Lon31Deg = Lon31Deg + 1;
            }

            Lon32Deg = (int)Conversion.Int(Math.Abs(Lon32));
            Lon32Min = (Math.Abs(Lon32) - Lon32Deg) * 60d;
            if (Conversion.Int(Lon32Min * 10d + 0.5d) / 10d == 60d)
            {
                Lon32Min = 0d;
                Lon32Deg = Lon32Deg + 1;
            }

            // L3 = Val(txtL3Deg.text) + Val(txtL3Min.text) / 60: If cboL3 = "S" Then L3 = -L3
            // Calculate initial course and distance of first segment
            Segment = 1;
            L1CD = L1;
            Lo1CD = Lo1;
            L2CD = L3 * 180d / Pi;
            Lo2CD = Lon31;
            CD();
            Course1 = CourseCD;
            Distance1 = DistanceCD;
            if (L1 * Pi / 180d == L3)
                Distance1 = 0d;


            // Calculate (course and) distance of second segment
            Segment = 2;
            DLoCD = Lon32 - Lon31;
            // If L1 = L3 Then DLoCD = Lon31 - Lo1
            // If L2 = L3 Then DLoCD = Lo2 - Lon31
            if (Math.Abs(DLoCD) > 180d)
            {
                DLoCD = -Math.Sign(DLoCD) * (360d - Math.Abs(DLoCD));
            }

            Distance2 = Math.Cos(L3) * Math.Abs(DLoCD) * 60d;
            // Calculate distance of third segment and final course
            Segment = 3;
            L1CD = L2;
            L2CD = L3 * 180d / Pi;
            Lo1CD = Conversion.Val(txtLo2Deg.Text) + Conversion.Val(txtLo2Min.Text) / 60d;
            if (cboLo2.Text == "E")
            {
                Lo1CD = -Lo1CD;
            }

            Lo2CD = Lon32;
            CD();
            Course3 = CourseCD + 180d;
            if (Course3 >= 360d)
                Course3 = Course3 - 360d;
            Distance3 = DistanceCD;
            if (L2 * Pi / 180d == L3)
            {
                Distance3 = 0d;
            }

            FinalGCCourse();
            if (L2 == L3)
            {
                // If Course1 > 0 And Course1 < 180 Then CourseFinal = 90 Else CourseFinal = 270
                if (Course1 > 0d & Course1 < 180d)
                    Course3 = 90d;
                else
                    Course3 = 270d;
            }

            Distance1 = Conversion.Int(Distance1 * 10d + 0.5d) / 10d;
            Distance2 = Conversion.Int(Distance2 * 10d + 0.5d) / 10d;
            Distance3 = Conversion.Int(Distance3 * 10d + 0.5d) / 10d;
            DistanceComposite = (float)(Distance1 + Distance2 + Distance3);
        }

        private void txtL3Deg_TextChanged(object eventSender, EventArgs eventArgs)
        {
            txtL3Deg.BackColor = SystemColors.Window;
            if (Conversion.Val(txtL3Deg.Text) > 89d | Conversion.Val(txtL3Deg.Text) < 1d & !string.IsNullOrEmpty(txtL3Deg.Text))
            {
                txtL3Deg.BackColor = Color.Red;
                ErrorMsgBox("Out of Range");
            }
        }

        private void txtL3Deg_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            int KeyAscii = Strings.Asc(eventArgs.KeyChar);
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

        private void txtL3Deg_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtL3Deg.Text) > 89d | Conversion.Val(txtL3Deg.Text) < 1d & !string.IsNullOrEmpty(txtL3Deg.Text))
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtL3Deg_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtL3Deg;
            SelectAllText(ref argTB);
            txtL3Deg = argTB;
        }

        private void txtL3Min_TextChanged(object eventSender, EventArgs eventArgs)
        {
            // txtL1Min.ForeColor = &H80000008
            txtL3Min.BackColor = SystemColors.Window;
            if (Conversion.Val(txtL3Min.Text) > 59.9d)
            {
                txtL3Min.BackColor = Color.Red;
                ErrorMsgBox("Out of Range");
            }
        }

        private void txtL3Min_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            int KeyAscii = Strings.Asc(eventArgs.KeyChar);
            switch (KeyAscii)
            {
                case var @case when Strings.Asc("0") <= @case && @case <= Strings.Asc("9"):
                    {
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                case (short)('.'): // only allows one decimal point
                    {
                        if (Conversions.ToBoolean(Strings.InStr(txtL3Min.Text, ".")))
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

        private void txtL3Min_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtL3Min.Text) > 59.9d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtL3Min_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtL3Min;
            SelectAllText(ref argTB);
            txtL3Min = argTB;
        }

        public void CD()
        {
            DirectionCD = 1; // West
            DLoCD = Lo2CD - Lo1CD;
            if (DLoCD < 0d)
            {
                DirectionCD = -1;
            }

            if (DLoCD > 180d)
            {
                DLoCD = 360d - DLoCD;
                DirectionCD = -1;
            }

            if (DLoCD < -180)
            {
                DLoCD = 360d - Math.Abs(DLoCD);
                DirectionCD = 1;
            }

            SignL1CD = Math.Sign(L1CD);
            SignL2CD = Math.Sign(L2CD);
            if (Math.Sign(L1CD) != Math.Sign(L2CD) & Math.Sign(L1CD) != 0 & Math.Sign(L2CD) != 0)
            {
                L2CD = -Math.Abs(L2CD);
            }
            else
            {
                L2CD = Math.Abs(L2CD);
            }

            L1CD = Math.Abs(L1CD);
            DistanceCD = Math.Sin(L1CD * Pi / 180d) * Math.Sin(L2CD * Pi / 180d) + Math.Cos(L1CD * Pi / 180d) * Math.Cos(L2CD * Pi / 180d) * Math.Cos(DLoCD * Pi / 180d);
            DistanceCD = Math.Atan(-DistanceCD / (Math.Sqrt(-DistanceCD * DistanceCD + 1d) + 9.999999E-21d)) + Pi / 2d;
            CourseAngleCD = (Math.Sin(L2CD * Pi / 180d) - Math.Sin(L1CD * Pi / 180d) * Math.Cos(DistanceCD)) / (Math.Cos(L1 * Pi / 180d) * Math.Sin(DistanceCD)); // add SignL1?
                                                                                                                                                                  // If CourseAngleCD > 1 Then CourseAngleCD = CourseAngleCD - 1
            if (DLoCD != 0d & Math.Abs(DLoCD) != 180d)
            {
                CourseAngleCD = Math.Atan(-CourseAngleCD / (Math.Sqrt(-CourseAngleCD * CourseAngleCD + 1d) + 9.999999E-21d)) + Pi / 2d;
            }

            DistanceCD = DistanceCD * 180d / Pi * 60d;
            DistanceCD = Conversion.Int(DistanceCD * 10d + 0.5d) / 10d;
            CourseAngleDegCD = CourseAngleCD * 180d / Pi; // course in quadrant
            if (SignL1CD >= 0 & DirectionCD == 1)
            {
                CourseCD = 360d - CourseAngleDegCD;
            }

            if (SignL1CD >= 0 & DirectionCD == -1)
            {
                CourseCD = CourseAngleDegCD;
            }

            if (SignL1CD < 0 & DirectionCD == 1)
            {
                CourseCD = 180d + CourseAngleDegCD;
            }

            if (SignL1CD < 0 & DirectionCD == -1)
            {
                CourseCD = 180d - CourseAngleDegCD;
            }

            if (Lo1CD == Lo2CD & L1CD > L2CD)
            {
                CourseCD = 180d;
            }

            if (Lo1CD == Lo2CD & L1CD < L2CD)
            {
                CourseCD = 0d;
            }

            if (Segment == 1 & L1 == L3 * 180d / Pi)
            {
                if (DirectionCD == 1)
                {
                    CourseCD = 270d;
                }
                else
                {
                    CourseCD = 90d;
                }
            }
        }

        public void PointsM2()
        {
            string LongStr = "";
            string LatStr = "";
            string CourseStr = "";
            string DistanceStr = "";
            DatasetGCR = new DataSet();
            DatasetGCR.Tables.Add(tablenameGCR);
            DatasetGCR.DataSetName = tablenameGCR;
            My.MyProject.Forms.frmPointsOnGCR.DGGCR.DataSource = DatasetGCR;
            for (int i = 0, loopTo = Information.UBound(HdrStrGCR); i <= loopTo; i++)
            {
                DatasetGCR.Tables[tablenameGCR].Columns.Add(HdrStrGCR[i]);
                DatasetGCR.Tables[tablenameGCR].Columns[i].AllowDBNull = false;
                DatasetGCR.Tables[tablenameGCR].Columns[i].DefaultValue = "";
            }
            // DatasetGCR.Tables(tablenameGCR).Rows.Add(NullStrGCR)
            My.MyProject.Forms.frmPointsOnGCR.DGGCR.DataSource = DatasetGCR.Tables[0].DefaultView;
            My.MyProject.Forms.frmPointsOnGCR.DGGCR.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            My.MyProject.Forms.frmPointsOnGCR.DGGCR.ColumnHeadersDefaultCellStyle.BackColor = Color.Yellow;
            for (int i = 0, loopTo1 = My.MyProject.Forms.frmPointsOnGCR.DGGCR.Columns.Count - 1; i <= loopTo1; i++)
            {
                My.MyProject.Forms.frmPointsOnGCR.DGGCR.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                My.MyProject.Forms.frmPointsOnGCR.DGGCR.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                My.MyProject.Forms.frmPointsOnGCR.DGGCR.Columns[i].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                My.MyProject.Forms.frmPointsOnGCR.DGGCR.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                My.MyProject.Forms.frmPointsOnGCR.DGGCR.Columns[i].DefaultCellStyle.BackColor = Color.LightBlue;
            }

            My.MyProject.Forms.frmPointsOnGCR.Show();
            TotalDistance = 0f;
            Distance = 0d;
            Lo1Initial = Lo1;
            Lo2Initial = Lo2;
            ReachedMaxLatCount = 0;
            LeftMaxLatCount = 0;
            Flag3 = false;
            // convert all east longitudes to west
            if (Lo1 < 0d)
            {
                Lo1 = 360d - Math.Abs(Lo1);
            }

            if (Lo2 < 0d)
            {
                Lo2 = 360d - Math.Abs(Lo2);
            }

            if (Lon31 < 0d)
            {
                Lon31 = 360d - Math.Abs(Lon31);
            }

            if (Lon32 < 0d)
            {
                Lon32 = 360d - Math.Abs(Lon32);
            }
            // determine whether traveling should be eastward or westward and increment
            DLo = Lo2 - Lo1;
            Increment = 5;
            if (DLo < 0d)
            {
                Increment = -5;
            }
            // If Abs(DLo) > 180 Then DLo = 360 - DLo
            if (Lo2 > Lo1 & Math.Abs(DLo) > 180d & Increment == 5)
            {
                Lo1 = Lo1 + 360d;
                Increment = -5;
                Flag3 = true; // skip next line if this line is used
            }

            if (Flag3 == false & Lo2 < Lo1 & Math.Abs(DLo) > 180d & Increment == -5)
            {
                Lo2 = Lo2 + 360d;
                Increment = 5;
            }
            // make Lon31 and Lon32 fall between Lo1 and Lo2
            if (Lo2 > Lo1 & (Lon31 > Lo2 | Lon31 < Lo1))
            {
                Lon31 = Lon31 + 360d;
            }

            if (Lo1 > Lo2 & (Lon31 > Lo1 | Lon31 < Lo2))
            {
                Lon31 = Lon31 + 360d;
            }

            if (Lo2 > Lo1 & (Lon32 > Lo2 | Lon32 < Lo1))
            {
                Lon32 = Lon32 + 360d;
            }

            if (Lo1 > Lo2 & (Lon32 > Lo1 | Lon32 < Lo2))
            {
                Lon32 = Lon32 + 360d;
            }

            Segment = 1;
            for (Segment = 1; Segment <= 3; Segment++) // 1 is first great circle, 2 is parallel, 3 is second great circle
            {
                if (Segment == 1)
                {
                    L1 = Math.Abs(L1);
                    if (cboL1.Text == "S")
                    {
                        L1 = -L1;
                    }

                    L2 = Math.Abs(L3);
                    if (cboL3.Text == "S")
                    {
                        L2 = -L2;
                    }
                    // Lo1 is what it was
                    Lo2 = Lon31;
                }

                if (Segment == 2) // IS ALL THIS NECESSARY????????????????????????????????????????????????????????
                {
                    L1 = L3; // LPoint
                    L2 = L3; // LPoint
                    Lo1 = Lon31; // LoPoint ': If LoPoint < 0 Then Lo1 = 360 - Abs(LoPoint)
                    Lo2 = Lon32; // last Lo before leaving parallel, close to Lon32
                }

                if (Segment == 3)
                {
                    L1 = L3; // LPoint 'Print
                    L2 = Conversion.Val(txtL2Deg.Text) + Conversion.Val(txtL2Min.Text) / 60d; // make this L2Initial!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                    if (cboL2.Text == "S")
                    {
                        L2 = -L2;
                    }

                    Lo1 = Lon32; // last Lo before leaving parallel, close to Lon32
                    Lo2 = Lo2Initial;
                    if (Lo2 < 0d)
                    {
                        Lo2 = 360d - Math.Abs(Lo2);
                    }

                    if (Math.Abs(Lo2 - Lo1) > 180d)
                    {
                        Lo1 = Lo1 - 360d; // : Increment = -Increment
                    }
                }
                // frmPointsOnGCR.txtGCR.Clear()

                if (Segment == 1) // And L1 <> L3 Then
                {
                    TabVal = 4;
                    if (string.IsNullOrEmpty(txtLo1Deg.Text))
                    {
                        TabVal = 3;
                    }

                    if (ModFP(Lo1, 5d) != 0d)
                    {
                        LongStr = Conversion.Val(txtLo1Deg.Text).ToString("0") + '°' + Conversion.Val(txtLo1Min.Text).ToString("00.0") + "'" + cboLo1.Text;
                    }
                    // frmPointsOnGCR.txtGCR.AppendText Tab(18 - txtLo1Deg.Text)); Format(Val(txtLo1Deg.Text), "0"); Chr$(176); Format(Val(txtLo1Min.Text), "00.0"); "'"; cboLo1.Text
                    TabVal = 3;
                    if (string.IsNullOrEmpty(txtL1Deg.Text))
                    {
                        TabVal = 2;
                    }

                    if (ModFP(Lo1, 5d) != 0d)
                    {
                        LatStr = Conversion.Val(txtL1Deg.Text).ToString("0") + '°' + Conversion.Val(txtL1Min.Text).ToString("00.0") + "'" + Strings.Left(cboL1.Text, 1);
                    }
                    // frmPointsOnGCR.txtGCR.AppendText Tab(6 - txtL1Deg.Text)); Format(Val(txtL1Deg.Text), "0"); Chr$(176); Format(Val(txtL1Min), "00.0"); "'";  '6 was TabVal
                }

                if (Increment == -5)
                {
                    FirstLo = (int)(Lo1 - ModFP(Lo1, 5d));
                    LastLo = (int)(Lo2 - ModFP(Lo2, 5d));
                    if (ModFP(Lo2, 5d) == 0d)
                    {
                        LastLo = (int)Lo2;
                    }
                }

                if (Increment == 5)
                {
                    FirstLo = (int)(Lo1 - ModFP(Lo1, 5d));
                    LastLo = (int)(Lo2 - ModFP(Lo2, 5d));
                    if (ModFP(Lo1, 5d) != 0d)
                    {
                        FirstLo = FirstLo + 5;
                        if (Segment == 1)
                            LastLo = LastLo + 5;
                    }

                    if (ModFP(Lo2, 5d) == 0d)
                    {
                        LastLo = (int)Lo2;
                    }
                }

                var loopTo2 = LastLo;
                for (LoPoint = FirstLo; Increment >= 0 ? LoPoint <= loopTo2 : LoPoint >= loopTo2; LoPoint += Increment)
                {
                    // If Segment = 1 Or Segment = 3 Then

                    // If ReachedMaxLatCount < 2 Then  ' Or LeftMaxLatCount = 1 Then LoPoint = SavedLoPoint
                    LPointPrior = LPoint;
                    if (Lo1 != Lo2)
                    {
                        LPoint = Math.Atan((Math.Sin(L1 * Pi / 180d) * Math.Cos(L2 * Pi / 180d) * Math.Sin((LoPoint - Lo2) * Pi / 180d) - Math.Sin(L2 * Pi / 180d) * Math.Cos(L1 * Pi / 180d) * Math.Sin((LoPoint - Lo1) * Pi / 180d)) / (Math.Cos(L1 * Pi / 180d) * Math.Cos(L2 * Pi / 180d) * Math.Sin((Lo1 - Lo2) * Pi / 180d)));
                    }

                    LPoint = LPoint * 180d / Pi;
                    LoPointPrint = LoPoint;
                    LPointPrint = LPoint;
                    if (LoPoint == FirstLo)
                    {
                        L1Rhumb = L1;
                        Lo1Rhumb = Lo1;
                    }

                    if (LoPoint > Lon31 & Increment == 5 | LoPoint < Lon31 & Increment == -5)
                    {
                        ReachedMaxLatCount = ReachedMaxLatCount + 1;
                    }

                    if (ReachedMaxLatCount == 1)
                    {
                        LoPointPrint = Lon31;
                        LPointPrint = L3;
                    }

                    if (Segment == 3 & (LoPoint > Lo1 & Increment == 5 | LoPoint < Lo1 & Increment == -5))
                    {
                        LeftMaxLatCount = LeftMaxLatCount + 1;
                    }

                    if (Segment == 3 & (LoPoint > Lo2 & Increment == 5 | LoPoint < Lo2 & Increment == -5))
                    {
                        goto TheLastPoint;
                    }

                    // uses Accurate Rhumb Line for course and distance
                    if (Segment == 1 & L1 != L3 | Segment == 3 & L2 != L3 | Segment == 2 & ReachedMaxLatCount == 1)
                    {
                        L2Rhumb = LPointPrint;
                        Lo2Rhumb = LoPointPrint;
                        // If Segment=3 and Lo1Rhumb = Lo1
                        if (Segment == 1 & LoPoint == FirstLo)
                        {
                            L1Rhumb = L1;
                            Lo1Rhumb = Lo1;
                        }
                        // If Segment = 3 And LeftMaxLatCount = 1 Then frmPointsOnGCR.CurrentY = frmPointsOnGCR.CurrentY - 210
                        // If Segment = 3 And Increment = -5 And LeftMaxLatCount = 2 Then Lo1Rhumb = Lo1            'WHY???????????????????????
                        // Lo1Rhumb = Lo1Print          'added??????????????????
                        // If Segment = 3 And Increment = 5 And Lo1Rhumb > Lo2Rhumb Then Lo1Rhumb = Lo1Rhumb - 360 'WHY?????????????????????????
                        LatDiff = L2Rhumb - L1Rhumb;
                        DLo = Lo2Rhumb - Lo1Rhumb;
                        if (Segment == 3 & LeftMaxLatCount == 1)
                        {
                            // frmPointsOnGCR.CurrentY = frmPointsOnGCR.CurrentY + 210
                            DLo = Lo2Rhumb - Lon32;
                        }
                        // Crossing IDL
                        if (Math.Abs(DLo) > 180d)
                        {
                            DLo = -Math.Sign(DLo) * (360d - Math.Abs(DLo));
                        }

                        dphi = Math.Log(Math.Tan(L2Rhumb * Pi / 180d / 2d + Pi / 4d) / Math.Tan(L1Rhumb * Pi / 180d / 2d + Pi / 4d));
                        if (Math.Abs(LatDiff) < Math.Sqrt(0.000000000000001d))
                        {
                            q = Math.Cos(L1Rhumb * Pi / 180d);
                        }
                        else
                        {
                            q = LatDiff * Pi / 180d / dphi;
                        }

                        Distance = 60d * Math.Sqrt(q * q * DLo * DLo + LatDiff * LatDiff);
                        CourseAngle = 2d * Math.Atan((Math.Sqrt(DLo * Pi / 180d * DLo * Pi / 180d + dphi * dphi) - dphi) / ((DLo + 9.999999E-21d) * Pi / 180d));
                        CourseAngleDeg = CourseAngle * 180d / Pi;
                        if (LatDiff >= 0d & DLo < 0d)
                        {
                            Course = Math.Abs(CourseAngleDeg);
                        }

                        if (LatDiff >= 0d & DLo >= 0d)
                        {
                            Course = 360d - Math.Abs(CourseAngleDeg);
                        }

                        if (LatDiff < 0d & DLo < 0d)
                        {
                            Course = Math.Abs(CourseAngleDeg);
                        }

                        if (LatDiff < 0d & DLo >= 0d)
                        {
                            Course = 360d - Math.Abs(CourseAngleDeg);
                        }
                        // If (Segment = 2 And ReachedMaxLatCount = 1) Then
                        Course = Conversion.Int(Course + 0.5d);
                        // '                    If Segment = 3 And LeftMaxLatCount = 1 Then Distance = 0
                        if (Segment == 2 & ReachedMaxLatCount == 1 & L1Initial == L3)
                        {
                            Distance = 0d; // want this if L1=L3
                        }

                        Distance = Conversion.Int(Distance * 10d + 0.5d) / 10d;
                        TotalDistance = (float)(TotalDistance + Distance);
                        Dist = (Conversions.ToLong(Conversion.Str(Distance)) | Conversions.ToLong("000.0")).ToString();
                        // End If

                        // frmPointsOnGCR.txtGCR.AppendText(Space(7) & Format(Course, "000"))
                        // If Segment = 3 And LeftMaxLatCount = 1 Then
                        // frmPointsOnGCR.txtGCR.AppendText(Space(13 - Dist.ToString.Length) & Format(Distance, "##0.0"))
                        DatasetGCR.Tables[tablenameGCR].Rows.Add(LongStr, LatStr, Course.ToString("000"), Distance.ToString("##0.0"));
                        // End If
                        // If ReachedMaxLatCount = 0 Then frmPointsOnGCR.txtGCR.AppendText(vbNewLine)

                        LPointPrintDeg = (int)Conversion.Int(Math.Abs(LPointPrint));
                        LPointPrintMin = (Math.Abs(LPointPrint) - LPointPrintDeg) * 60d;
                        if (Conversion.Int(LPointPrintMin * 10d + 0.5d) / 10d == 60d)
                        {
                            LPointPrintMin = 0d;
                            LPointPrintDeg = LPointPrintDeg + 1;
                        }

                        if (LoPointPrint > 180d)
                        {
                            LoPointPrint = -(360d - Math.Abs(LoPointPrint));
                        }

                        LoPointPrintDeg = (int)Conversion.Int(Math.Abs(LoPointPrint));
                        LoPointPrintMin = (Math.Abs(LoPointPrint) - LoPointPrintDeg) * 60d;
                        if (Conversion.Int(LoPointPrintMin * 10d + 0.5d) / 10d == 60d)
                        {
                            LoPointPrintMin = 0d;
                            LoPointPrintDeg = LoPointPrintDeg + 1;
                        }

                        LongStr = Math.Abs(LoPointPrintDeg).ToString("0") + '°' + Math.Abs(LoPointPrintMin).ToString("00.0") + "'";
                        if (LoPointPrint > 0d & Math.Abs(LoPointPrint) != 180d)
                        {
                            LongStr += CommonGlobals.g_LongW;
                        }

                        if (LoPointPrint == 0d | Math.Abs(LoPointPrint) == 180d)
                        {
                            LongStr += CommonGlobals.g_StrSpace;
                        }

                        if (LoPointPrint < 0d & Math.Abs(LoPointPrint) != 180d)
                        {
                            LongStr += CommonGlobals.g_LongE;
                        }
                        // frmPointsOnGCR.txtGCR.AppendText Tab(17 - Str$(LPointDeg))); Format(LPointDeg, "0"); Chr$(176); Format(LPointMin, "00.0"); "'";
                        LatStr = LPointPrintDeg.ToString("0") + '°' + LPointPrintMin.ToString("00.0") + "'";
                        if (LPoint > 0d)
                        {
                            LatStr += CommonGlobals.g_LatN;
                        }

                        if (LPoint == 0d)
                        {
                            LatStr += CommonGlobals.g_StrSpace;
                        }

                        if (LPoint < 0d)
                        {
                            LatStr += CommonGlobals.g_LatS;
                        }
                        // frmPointsOnGCR.CurrentY = frmPointsOnGCR.CurrentY - 210
                        // If L1Initial <> L3 Then '(Segment = 2 And ReachedMaxLatCount <> 1) Then
                        // frmPointsOnGCR.txtGCR.AppendText(Space(2) & Strings.Format(Course, "000"))
                        // If Segment = 3 And LeftMaxLatCount = 1 Then
                        // frmPointsOnGCR.txtGCR.AppendText(Space(7 - Dist)) & Strings.Format(Distance, "##0.0"))
                        // Else
                        // frmPointsOnGCR.txtGCR.AppendText(Space(7 - Dist)) & Strings.Format(Distance, "##0.0"))
                        // End If
                        // frmPointsOnGCR.txtGCR.AppendText(vbNewLine)
                        // End If
                        // frmPointsOnGCR.CurrentY = frmPointsOnGCR.CurrentY + 210
                        L1Rhumb = L2Rhumb;
                        Lo1Rhumb = Lo2Rhumb;
                        // ReachedMaxLat = False                                                   'IS THIS LINE NEEDED?
                    }
                    // End If

                    // Segment=2
                    if (ReachedMaxLatCount == 1) // Segment = 2 Then 'And
                    {
                        LPointPrintDeg = (int)Conversion.Int(Math.Abs(LPointPrint));
                        LPointPrintMin = (Math.Abs(LPointPrint) - LPointPrintDeg) * 60d;
                        if (Conversion.Int(LPointPrintMin * 10d + 0.5d) / 10d == 60d)
                        {
                            LPointPrintMin = 0d;
                            LPointPrintDeg = LPointPrintDeg + 1;
                        }

                        LoPointPrint = Lon32;
                        if (LoPointPrint > 180d)
                        {
                            LoPointPrint = -(360d - Math.Abs(LoPointPrint));
                        }

                        LoPointPrintDeg = (int)Conversion.Int(Math.Abs(LoPointPrint));
                        LoPointPrintMin = (Math.Abs(LoPointPrint) - LoPointPrintDeg) * 60d;
                        if (Conversion.Int(LoPointPrintMin * 10d + 0.5d) / 10d == 60d)
                        {
                            LoPointPrintMin = 0d;
                            LoPointPrintDeg = LoPointPrintDeg + 1;
                        }

                        DLo = Math.Abs(Lon32 - Lon31);
                        if (DLo > 180d)
                        {
                            DLo = 360d - Math.Abs(DLo);
                        }

                        Distance = 60d * DLo * Math.Cos(L3 * Pi / 180d);
                        Distance = Conversion.Int(Distance * 10d + 0.5d) / 10d;
                        TotalDistance = (float)(TotalDistance + Distance);
                        if (L1Initial != L3)
                        {
                            if (Course > 0d & Course < 180d)
                                Course = 90d;
                            else
                                Course = 270d;
                        }

                        if (L1Initial == L3)
                        {
                            if (Direction == 1)
                                Course = 270d;
                            else
                                Course = 90d;
                        }

                        Dist = (Conversions.ToLong(Conversion.Str(Distance)) | Conversions.ToLong("000.0")).ToString();
                        // frmPointsOnGCR.txtGCR.AppendText(Space(7) & Format(Course, "000"))
                        // frmPointsOnGCR.txtGCR.AppendText(Space(13 - Dist.ToString.Length) & Format(Distance, "##0.0"))
                        DatasetGCR.Tables[tablenameGCR].Rows.Add(LongStr, LatStr, Course.ToString("000"), Distance.ToString("##0.0"));
                        // frmPointsOnGCR.txtGCR.AppendText(vbNewLine)
                        // frmPointsOnGCR.CurrentY = frmPointsOnGCR.CurrentY + 210 'THIS IS THE LINE THT CAUSES EXTRA SPACE

                        // frmPointsOnGCR.txtGCR.AppendText(Space(5 - Str(Math.Abs(LoPointPrintDeg))) & Format(Math.Abs(LoPointPrintDeg), "0") & Chr(176) & Format(Math.Abs(LoPointPrintMin), "00.0") & "'")
                        // If LoPointPrint > 0 And Math.Abs(LoPointPrint) <> 180 Then
                        // frmPointsOnGCR.txtGCR.AppendText(g_LongW)
                        // End If
                        // If LoPointPrint = 0 Or Math.Abs(LoPointPrint) = 180 Then
                        // frmPointsOnGCR.txtGCR.AppendText(g_StrSpace)
                        // End If
                        // If LoPointPrint < 0 And Math.Abs(LoPointPrint) <> 180 Then
                        // frmPointsOnGCR.txtGCR.AppendText(g_LongE)
                        // End If
                        // 'frmPointsOnGCR.txtGCR.AppendText Tab(17 - Str$(LPointDeg))); Format(LPointDeg, "0"); Chr$(176); Format(LPointMin, "00.0"); "'";
                        // frmPointsOnGCR.txtGCR.AppendText(Space(5 - LPointPrintDeg.ToString.Length) & Format(LPointPrintDeg, "0") & Chr(176) & Format(LPointPrintMin, "00.0") & "'")
                        // If LPoint > 0 Then
                        // frmPointsOnGCR.txtGCR.AppendText(g_LatN)
                        // End If
                        // If LPoint = 0 Then
                        // frmPointsOnGCR.txtGCR.AppendText(g_StrSpace)
                        // End If
                        // If LPoint < 0 Then
                        // frmPointsOnGCR.txtGCR.AppendText(g_LatS)
                        // End If

                        LongStr = Math.Abs(LoPointPrintDeg).ToString("0") + '°' + Math.Abs(LoPointPrintMin).ToString("00.0") + "'";
                        if (LoPointPrint > 0d & Math.Abs(LoPointPrint) != 180d)
                        {
                            LongStr += CommonGlobals.g_LongW;
                        }

                        if (LoPointPrint == 0d | Math.Abs(LoPointPrint) == 180d)
                        {
                            LongStr += CommonGlobals.g_StrSpace;
                        }

                        if (LoPointPrint < 0d & Math.Abs(LoPointPrint) != 180d)
                        {
                            LongStr += CommonGlobals.g_LongE;
                        }
                        // frmPointsOnGCR.txtGCR.AppendText Tab(17 - Str$(LPointDeg))); Format(LPointDeg, "0"); Chr$(176); Format(LPointMin, "00.0"); "'";
                        LatStr = LPointPrintDeg.ToString("0") + '°' + LPointPrintMin.ToString("00.0") + "'";
                        if (LPoint > 0d)
                        {
                            LatStr += CommonGlobals.g_LatN;
                        }

                        if (LPoint == 0d)
                        {
                            LatStr += CommonGlobals.g_StrSpace;
                        }

                        if (LPoint < 0d)
                        {
                            LatStr += CommonGlobals.g_LatS;
                        }
                    }
                }
            }

        TheLastPoint:
            ;

            // calculate rhumb line course and distance to last point if Lo is not divisible by 5 and destination is not at latitude limit
            if (ModFP(Lo2, 5d) != 0d & L2 != L3)
            {
                if (Math.Abs(Lo2 - Lon32) >= 5d)
                {
                    if (Increment == -5)
                    {
                        L1Rhumb = LPointPrior;
                    }

                    if (Increment == 5)
                    {
                        L1Rhumb = LPointPrint;
                    }

                    Lo1Rhumb = LoPoint - Increment;
                    if (Lo1Rhumb > 180d)
                    {
                        Lo1Rhumb = -(360d - Math.Abs(Lo1Rhumb));
                    }
                }

                L2Rhumb = Conversion.Val(txtL2Deg.Text) + Conversion.Val(txtL2Min.Text) / 60d;
                if (cboL2.Text == "S")
                {
                    L2Rhumb = -L2Rhumb;
                }

                Lo2Rhumb = Conversion.Val(txtLo2Deg.Text) + Conversion.Val(txtLo2Min.Text) / 60d;
                if (cboLo2.Text == "E")
                {
                    Lo2Rhumb = -Lo2Rhumb;
                }
                // If Lo2Rhumb < 0 Then Lo2Rhumb = 360 - Abs(Lo2Rhumb)
                LatDiff = L2Rhumb - L1Rhumb;
                DLo = Lo2Rhumb - Lo1Rhumb;
                // Crossing IDL
                if (Math.Abs(DLo) > 180d)
                {
                    DLo = -Math.Sign(DLo) * (360d - Math.Abs(DLo));
                }

                dphi = Math.Log(Math.Tan(L2Rhumb * Pi / 180d / 2d + Pi / 4d) / Math.Tan(L1Rhumb * Pi / 180d / 2d + Pi / 4d));
                if (Math.Abs(LatDiff) < Math.Sqrt(0.000000000000001d))
                {
                    q = Math.Cos(L1Rhumb * Pi / 180d);
                }
                else
                {
                    q = LatDiff * Pi / 180d / dphi;
                }

                Distance = 60d * Math.Sqrt(q * q * DLo * DLo + LatDiff * LatDiff);
                CourseAngle = 2d * Math.Atan((Math.Sqrt(DLo * Pi / 180d * DLo * Pi / 180d + dphi * dphi) - dphi) / ((DLo + 9.999999E-21d) * Pi / 180d));
                CourseAngleDeg = CourseAngle * 180d / Pi;
                if (LatDiff >= 0d & DLo < 0d)
                {
                    Course = Math.Abs(CourseAngleDeg);
                }

                if (LatDiff >= 0d & DLo >= 0d)
                {
                    Course = 360d - Math.Abs(CourseAngleDeg);
                }

                if (LatDiff < 0d & DLo < 0d)
                {
                    Course = Math.Abs(CourseAngleDeg);
                }

                if (LatDiff < 0d & DLo >= 0d)
                {
                    Course = 360d - Math.Abs(CourseAngleDeg);
                }

                Course = Conversion.Int(Course + 0.5d);
                Distance = Conversion.Int(Distance * 10d + 0.5d) / 10d;
                TotalDistance = (float)(TotalDistance + Distance);
                TotalDistance = (float)(Conversion.Int(TotalDistance * 10f + 0.5d) / 10d);
                Dist = (Conversions.ToLong(Conversion.Str(Distance)) | Conversions.ToLong("000.0")).ToString();
                // frmPointsOnGCR.CurrentY = frmPointsOnGCR.CurrentY - 210
                // frmPointsOnGCR.txtGCR.AppendText(Space(7) & Format(Course, "000"))
                // frmPointsOnGCR.txtGCR.AppendText(Space(13 - Dist.ToString.Length) & Format(Distance, "##0.0"))
                DatasetGCR.Tables[tablenameGCR].Rows.Add(LongStr, LatStr, Course.ToString("000"), Distance.ToString("##0.0"));
                TabVal = 9;
                if (string.IsNullOrEmpty(txtLo1Deg.Text))
                {
                    TabVal = 8;
                }

                if (ModFP(Lo2, 5d) != 0d)
                {
                    LongStr = Conversion.Val(txtLo2Deg.Text).ToString("0") + '°' + Conversion.Val(txtLo2Min.Text).ToString("00.0") + "'";
                }

                if (Lo2 != 0d & ModFP(Lo2, 5d) != 0d)
                {
                    if (Lo2 < 180d)
                    {
                        LongStr += CommonGlobals.g_LongW;
                    }

                    if (Lo2 == 180d)
                    {
                        LongStr += "";
                    }

                    if (Lo2 > 180d)
                    {
                        LongStr += CommonGlobals.g_LongE;
                    }
                }
                // frmPointsOnGCR.txtGCR.AppendText(vbNewLine)
            }

            if (Lo1Rhumb != Lo2)
            {
                TabVal = 4;
                if (string.IsNullOrEmpty(txtL2Deg.Text))
                {
                    TabVal = 3;
                }

                if (ModFP(Lo2, 5d) != 0d)
                {
                    LatStr = Conversion.Val(txtL2Deg.Text).ToString("0") + '°' + Conversion.Val(txtL2Min.Text).ToString("00.0") + "'";
                }

                if (optL2Lo2GC.Checked == false & ModFP(Lo2, 5d) != 0d)
                {
                    LongStr += cboL2.Text.ToString();
                }

                if (optL2Lo2GC.Checked == true)
                {
                    if (Math.Sign(L2) == 1)
                    {
                        LongStr += CommonGlobals.g_LatN;
                    }

                    if (Math.Sign(L2) == 0)
                    {
                        LongStr += "";
                    }

                    if (Math.Sign(L2) == -1)
                    {
                        LongStr += CommonGlobals.g_LatS;
                    }
                }
                // frmPointsOnGCR.txtGCR.AppendText(vbNewLine)
                DatasetGCR.Tables[tablenameGCR].Rows.Add(LongStr, LatStr, "", "");
            }

            LongStr = "Total distance";
            LatStr = "on rhumb line";
            CourseStr = "";
            DistanceStr = TotalDistance.ToString("0.0") + " nm";
            DatasetGCR.Tables[tablenameGCR].Rows.Add(LongStr, LatStr, "", TotalDistance.ToString("##0.0"));
            // frmPointsOnGCR.txtGCR.AppendText(Space(13) & "Total rhumb line distance = " & Format(TotalDistance, "0.0") & " nm")
            cmdPoints.Enabled = false;
            GCRArray = new GCRRec[My.MyProject.Forms.frmPointsOnGCR.DGGCR.Rows.Count - 2 + 1];
            for (int i = 0, loopTo3 = My.MyProject.Forms.frmPointsOnGCR.DGGCR.Rows.Count - 2; i <= loopTo3; i++)
            {
                GCRArray[i].LongStr = Conversions.ToString(My.MyProject.Forms.frmPointsOnGCR.DGGCR.Rows[i].Cells[0].Value);
                GCRArray[i].LatStr = Conversions.ToString(My.MyProject.Forms.frmPointsOnGCR.DGGCR.Rows[i].Cells[1].Value);
                GCRArray[i].CTrue = Conversions.ToString(My.MyProject.Forms.frmPointsOnGCR.DGGCR.Rows[i].Cells[2].Value);
                GCRArray[i].GCRDist = Conversions.ToString(My.MyProject.Forms.frmPointsOnGCR.DGGCR.Rows[i].Cells[3].Value);
            }

            GCRAvailable = true;
            DatasetGCR.Dispose();
        }

        private void SelectAllText(ref TextBox TB)
        {
            TB.SelectionStart = 0;
            TB.SelectionLength = TB.Text.ToString().Length;
        }

        private void ErrorMsgBox(string ErrMsg)
        {
            MessageBox.Show(ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            return;
        }
    }
}