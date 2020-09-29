using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    internal partial class FormMoBoard : Form
    {
        private double Y1, X1, Pi, CPABearing, X2, Y2;
        private float Time1Minutes, Time2Minutes;
        private double Dist2, A, Range, Dist, k, D, DRM;
        private float SRM;
        private float TimeOfCPA, TimeToCPA, TimeOfCPAm;
        private short TimeOfCPAh;
        private double dot, xVel, x, y, yVel, B;
        private string fnumeral;
        private short intResponse;
        private bool CPAexists;
        private float V1Course, V1Speed;
        private double V2Course, V2Speed;
        private double DRMZ, Z1;
        private short SignZ1;
        private short xV1S, xDRM, yDRM, yV1S;
        private double DeltaX, DeltaY;
        private double V11y, V21y, V20y, V2Dist, V1Dist, V20x, V21x, V11x, Bearing;
        private short xV11, xV21, xV20, yV20, yV21, yV11;
        private float Course1, Course2;
        private float ApparentWindDir;
        private double TrueWindSpeed, Course, TrueWindDir, ApparentWindSpeed;
        private double PointingAngle;

        private void cmdCalculate_Click(object eventSender, EventArgs eventArgs)
        {
            Pi = 4d * Math.Atan(1.0d);
            CPAexists = true;
            if (optCPATypeA.Checked == true)
            {
                txtMoB.Clear();
                if (Conversion.Val(txtRange1.Text) == 0d | Conversion.Val(txtRange2.Text) == 0d)
                {
                    ErrorMsgBox("Ranges cannot be zero or blank.");
                    return;
                }

                Time1Minutes = (float)(60d * Conversion.Val(Strings.Left(txtTime1.Text, 2)) + Conversion.Val(Strings.Right(txtTime1.Text, 2)));
                Time2Minutes = (float)(60d * Conversion.Val(Strings.Left(txtTime2.Text, 2)) + Conversion.Val(Strings.Right(txtTime2.Text, 2)));
                if (Time2Minutes <= Time1Minutes)
                {
                    if (MessageBox.Show("Is Time2 on the day after Time1?", "Same Day?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) == DialogResult.Yes)
                    {
                        Time2Minutes = Time2Minutes + 1440f;
                    }
                    else
                    {
                        txtTime2.BackColor = Color.Red;
                        txtTime2.Focus();
                        return;
                    }
                }

                if (Conversion.Val(txtBearing1.Text) != Conversion.Val(txtBearing2.Text) + 180d & Conversion.Val(txtBearing1.Text) != Conversion.Val(txtBearing2.Text) - 180d & Conversion.Val(txtRange2.Text) >= Conversion.Val(txtRange1.Text))
                {
                    txtMoB.AppendText("No further closure between vessels." + Constants.vbNewLine);
                    CPAexists = false;
                } // Exit Sub

                if (Conversion.Val(txtRange1.Text) * Math.Sin(Conversion.Val(txtBearing1.Text) * Pi / 180d) - Conversion.Val(txtRange2.Text) * Math.Sin(Conversion.Val(txtBearing2.Text) * Pi / 180d) < 0.0000001d)
                    CPABearing = 0d;
                else
                {
                }

                CPABearing = Math.Atan((Conversion.Val(txtRange2.Text) * Math.Cos(Conversion.Val(txtBearing2.Text) * Pi / 180d) - Conversion.Val(txtRange1.Text) * Math.Cos(Conversion.Val(txtBearing1.Text) * Pi / 180d)) / (Conversion.Val(txtRange1.Text) * Math.Sin(Conversion.Val(txtBearing1.Text) * Pi / 180d) - Conversion.Val(txtRange2.Text) * Math.Sin(Conversion.Val(txtBearing2.Text) * Pi / 180d) + 9.999999E-21d));
                Y1 = Conversion.Val(txtRange1.Text) * Math.Cos(Conversion.Val(txtBearing1.Text) * Pi / 180d); // Y is NS component
                Y2 = Conversion.Val(txtRange2.Text) * Math.Cos(Conversion.Val(txtBearing2.Text) * Pi / 180d);
                X1 = Conversion.Val(txtRange1.Text) * Math.Sin(Conversion.Val(txtBearing1.Text) * Pi / 180d); // X is EW component
                X2 = Conversion.Val(txtRange2.Text) * Math.Sin(Conversion.Val(txtBearing2.Text) * Pi / 180d);
                Dist = Math.Sqrt((X2 - X1) * (X2 - X1) + (Y2 - Y1) * (Y2 - Y1));
                Range = Conversion.Val(txtRange2.Text) * Math.Cos(CPABearing - Conversion.Val(txtBearing2.Text) * Pi / 180d); // Does not agree with Allen, agrees with Lapook
                if (Range < 0d)
                    CPABearing = CPABearing + Pi;
                DRMZ = Math.Atan((X2 - X1) / (Y2 - Y1)) * 180d / Pi;
                DRMZ = Math.Abs(DRMZ);
                DRM = Math.Abs(DRMZ);
                if (X2 - X1 >= 0d & Y2 - Y1 >= 0d)
                {
                    DRM = DRM;
                    xDRM = 1;
                    yDRM = 1;
                }

                if (X2 - X1 >= 0d & Y2 - Y1 < 0d)
                {
                    DRM = 180d - DRM;
                    xDRM = 1;
                    yDRM = -1;
                }

                if (X2 - X1 < 0d & Y2 - Y1 < 0d)
                {
                    DRM = DRM - 180d;
                    xDRM = -1;
                    yDRM = -1;
                }

                if (X2 - X1 < 0d & Y2 - Y1 >= 0d)
                {
                    DRM = 360d - DRM;
                    xDRM = -1;
                    yDRM = 1;
                }

                k = Math.Sin(Math.Abs(Conversion.Val(txtBearing1.Text) - Conversion.Val(txtBearing2.Text)) * Pi / 180d) * Conversion.Val(txtRange1.Text) / Dist;
                A = Math.Atan(k / Math.Sqrt(-k * k + 1d));
                if (A < 0d)
                    A = A + 2d * Pi;
                D = Conversion.Val(txtRange2.Text) * Math.Sin(A);
                Dist2 = Conversion.Val(txtRange2.Text) * Math.Sin(Pi / 2d - A);
                CPABearing = CPABearing * 180d / Pi;
                if (CPABearing > 360d)
                    CPABearing = CPABearing - 360d;
                if (CPABearing < 0d)
                    CPABearing = CPABearing + 360d;
                if (DRM > 360d)
                    DRM = DRM - 360d;
                if (DRM < 0d)
                    DRM = DRM + 360d;
                SRM = (float)(Dist / (Time2Minutes - Time1Minutes) * 60d);
                if (Conversion.Val(txtV1Course.Text) >= 0d & Conversion.Val(txtV1Course.Text) < 90d)
                {
                    V1Course = (float)Conversion.Val(txtV1Course.Text);
                    xV1S = 1;
                    yV1S = 1;
                }

                if (Conversion.Val(txtV1Course.Text) >= 90d & Conversion.Val(txtV1Course.Text) < 180d)
                {
                    V1Course = (float)(180d - Conversion.Val(txtV1Course.Text));
                    xV1S = 1;
                    yV1S = -1;
                }

                if (Conversion.Val(txtV1Course.Text) >= 180d & Conversion.Val(txtV1Course.Text) < 270d)
                {
                    V1Course = (float)(Conversion.Val(txtV1Course.Text) - 180d);
                    xV1S = -1;
                    yV1S = -1;
                }

                if (Conversion.Val(txtV1Course.Text) >= 270d & Conversion.Val(txtV1Course.Text) < 360d)
                {
                    V1Course = (float)(360d - Conversion.Val(txtV1Course.Text));
                    xV1S = -1;
                    yV1S = 1;
                }

                DeltaX = xV1S * Conversion.Val(txtV1Speed.Text) * Math.Sin(V1Course * Pi / 180d) + xDRM * SRM * Math.Sin(DRMZ * Pi / 180d);
                DeltaY = yV1S * Conversion.Val(txtV1Speed.Text) * Math.Cos(V1Course * Pi / 180d) + yDRM * SRM * Math.Cos(DRMZ * Pi / 180d);
                V2Course = Math.Atan(Math.Abs(DeltaY) / (Math.Abs(DeltaX) + 9.999999E-21d)) * 180d / Pi;
                if (DeltaY >= 0d & DeltaX >= 0d)
                    V2Course = 90d - V2Course;
                if (DeltaY >= 0d & DeltaX < 0d)
                    V2Course = 270d + V2Course;
                if (DeltaY < 0d & DeltaX >= 0d)
                    V2Course = 90d + V2Course;
                if (DeltaY < 0d & DeltaX < 0d)
                    V2Course = 270d - V2Course;
                if (Conversion.Val(txtV1Speed.Text) == 0d)
                    V2Course = DRM;
                V2Speed = Math.Sqrt(DeltaX * DeltaX + DeltaY * DeltaY);
                if (V2Course >= 360d)
                    V2Course = V2Course - 360d;
                if (V2Course < 0d)
                    V2Course = V2Course + 360d;
                V2Course = Conversion.Int(V2Course * 10d + 0.5d) / 10d;
                V2Speed = Conversion.Int(V2Speed * 10d + 0.5d) / 10d;
                TimeToCPA = (float)(Dist2 / Dist * (Time2Minutes - Time1Minutes));
                if (A > Pi / 2d)
                    TimeToCPA = -TimeToCPA;
                TimeOfCPA = Time2Minutes + TimeToCPA;
                Range = Math.Abs(Range);
                Range = Conversion.Int(Range * 100d + 0.5d) / 100d;
                CPABearing = Conversion.Int(CPABearing * 10d + 0.5d) / 10d;
                TimeToCPA = (float)(Conversion.Int(TimeToCPA * 10f + 0.5d) / 10d);
                SRM = (float)(Conversion.Int(SRM * 10f + 0.5d) / 10d);
                TimeOfCPA = TimeOfCPA / 60f; // decimal hours
                TimeOfCPAh = (short)Conversion.Int(TimeOfCPA);
                TimeOfCPAm = (TimeOfCPA - TimeOfCPAh) * 60f;
                TimeOfCPAm = (float)Conversion.Int(TimeOfCPAm + 0.5d);
                if (TimeOfCPAh >= 24)
                    TimeOfCPAh = (short)(TimeOfCPAh - 24);
                TimeOfCPA = 100 * TimeOfCPAh + TimeOfCPAm;
                DRM = Conversion.Int(DRM * 10d + 0.5d) / 10d;
                if (CPAexists == true)
                {
                    txtMoB.AppendText("CPA = " + Strings.Format(Range, "0.00") + " nm in " + Strings.Format(TimeToCPA, "0.0") + " minutes" + Constants.vbNewLine); // ;
                    txtMoB.AppendText("Bearing at CPA = " + Strings.Format(CPABearing, "000.0") + '°' + Constants.vbNewLine);
                    txtMoB.AppendText("Time of CPA = " + Strings.Format(TimeOfCPA, "0000") + Constants.vbNewLine);
                }

                if (CPAexists == false)
                {
                }

                txtMoB.AppendText("DRM = " + Strings.Format(DRM, "000.0") + '°' + Constants.vbNewLine);
                txtMoB.AppendText("SRM = " + Strings.Format(SRM, "0.0") + " knots" + Constants.vbNewLine);
                txtMoB.AppendText("Vessel 2 Course = " + Strings.Format(V2Course, "000.0") + '°' + Constants.vbNewLine);
                txtMoB.AppendText("Vessel 2 Speed = " + Strings.Format(V2Speed, "0.0") + " knots" + Constants.vbNewLine);
            }

            if (optCPATypeB.Checked == true)
            {
                txtMoB.Clear();
                x = Conversion.Val(txtRange.Text) * Math.Cos(Conversion.Val(txtBearing.Text) * Pi / 180d);
                y = Conversion.Val(txtRange.Text) * Math.Sin(Conversion.Val(txtBearing.Text) * Pi / 180d);
                xVel = Conversion.Val(txtSpeed2.Text) * Math.Cos(Conversion.Val(txtCourse2.Text) * Pi / 180d) - Conversion.Val(txtSpeed1.Text) * Math.Cos(Conversion.Val(txtCourse1.Text) * Pi / 180d);
                yVel = Conversion.Val(txtSpeed2.Text) * Math.Sin(Conversion.Val(txtCourse2.Text) * Pi / 180d) - Conversion.Val(txtSpeed1.Text) * Math.Sin(Conversion.Val(txtCourse1.Text) * Pi / 180d);
                dot = x * xVel + y * yVel;
                if (dot >= 0d)
                {
                    txtMoB.AppendText("No further closure between vessels.");
                    CPAexists = false;
                } // Exit Sub

                A = xVel * xVel + yVel * yVel + 9.999999E-21d;
                DRM = Math.Atan(yVel / (xVel + 9.999999E-21d)) * 180d / Pi;
                if (xVel >= 0d & yVel >= 0d)
                    DRM = DRM;
                if (xVel >= 0d & yVel < 0d)
                    DRM = 180d - DRM;
                if (xVel < 0d & yVel >= 0d)
                    DRM = 360d - DRM;
                if (xVel < 0d & yVel < 0d)
                    DRM = 180d + DRM;
                if (DRM < 0d)
                    DRM = DRM + 360d;
                if (DRM > 360d)
                    DRM = DRM - 360d;
                SRM = (float)Math.Sqrt(A);
                SRM = (float)(Conversion.Int(SRM * 10f + 0.5d) / 10d);
                B = 2d * dot;
                Range = Math.Abs(Conversion.Val(txtRange.Text) * Conversion.Val(txtRange.Text) - B * B / (4d * A)); // Abs prevents slightly negative numbers from creating error in Sqr(Range)
                TimeToCPA = (float)(60d * (-B / (2d * A)));
                V1Dist = Conversion.Val(txtSpeed1.Text) * TimeToCPA / 60d;
                V2Dist = Conversion.Val(txtSpeed2.Text) * TimeToCPA / 60d;
                if (Conversion.Val(txtBearing.Text) >= 0d & Conversion.Val(txtBearing.Text) < 90d)
                {
                    Bearing = Conversion.Val(txtBearing.Text);
                    xV20 = 1;
                    yV20 = 1;
                }

                if (Conversion.Val(txtBearing.Text) >= 90d & Conversion.Val(txtBearing.Text) < 180d)
                {
                    Bearing = 180d - Conversion.Val(txtBearing.Text);
                    xV20 = 1;
                    yV20 = -1;
                }

                if (Conversion.Val(txtBearing.Text) >= 180d & Conversion.Val(txtBearing.Text) < 270d)
                {
                    Bearing = Conversion.Val(txtBearing.Text) - 180d;
                    xV20 = -1;
                    yV20 = -1;
                }

                if (Conversion.Val(txtBearing.Text) >= 270d & Conversion.Val(txtBearing.Text) < 360d)
                {
                    Bearing = 360d - Conversion.Val(txtBearing.Text);
                    xV20 = -1;
                    yV20 = 1;
                }

                V20x = xV20 * Conversion.Val(txtRange.Text) * Math.Sin(Bearing * Pi / 180d);
                V20y = yV20 * Conversion.Val(txtRange.Text) * Math.Cos(Bearing * Pi / 180d);
                if (Conversion.Val(txtCourse1.Text) >= 0d & Conversion.Val(txtCourse1.Text) < 90d)
                {
                    Course1 = (float)Conversion.Val(txtCourse1.Text);
                    xV11 = 1;
                    yV11 = 1;
                }

                if (Conversion.Val(txtCourse1.Text) >= 90d & Conversion.Val(txtCourse1.Text) < 180d)
                {
                    Course1 = (float)(180d - Conversion.Val(txtCourse1.Text));
                    xV11 = 1;
                    yV11 = -1;
                }

                if (Conversion.Val(txtCourse1.Text) >= 180d & Conversion.Val(txtCourse1.Text) < 270d)
                {
                    Course1 = (float)(Conversion.Val(txtCourse1.Text) - 180d);
                    xV11 = -1;
                    yV11 = -1;
                }

                if (Conversion.Val(txtCourse1.Text) >= 270d & Conversion.Val(txtCourse1.Text) < 360d)
                {
                    Course1 = (float)(360d - Conversion.Val(txtCourse1.Text));
                    xV11 = -1;
                    yV11 = 1;
                }

                V11x = xV11 * V1Dist * Math.Sin(Course1 * Pi / 180d);
                V11y = yV11 * V1Dist * Math.Cos(Course1 * Pi / 180d);
                if (Conversion.Val(txtCourse2.Text) >= 0d & Conversion.Val(txtCourse2.Text) < 90d)
                {
                    Course2 = (float)Conversion.Val(txtCourse2.Text);
                    xV21 = 1;
                    yV21 = 1;
                }

                if (Conversion.Val(txtCourse2.Text) >= 90d & Conversion.Val(txtCourse2.Text) < 180d)
                {
                    Course2 = (float)(180d - Conversion.Val(txtCourse2.Text));
                    xV21 = 1;
                    yV21 = -1;
                }

                if (Conversion.Val(txtCourse2.Text) >= 180d & Conversion.Val(txtCourse2.Text) < 270d)
                {
                    Course2 = (float)(Conversion.Val(txtCourse2.Text) - 180d);
                    xV21 = -1;
                    yV21 = -1;
                }

                if (Conversion.Val(txtCourse2.Text) >= 270d & Conversion.Val(txtCourse2.Text) < 360d)
                {
                    Course2 = (float)(360d - Conversion.Val(txtCourse2.Text));
                    xV21 = -1;
                    yV21 = 1;
                }

                V21x = V20x + xV21 * V2Dist * Math.Sin(Course2 * Pi / 180d);
                V21y = V20y + yV21 * V2Dist * Math.Cos(Course2 * Pi / 180d);
                DeltaX = V21x - V11x;
                DeltaY = V21y - V11y;
                CPABearing = Math.Atan(Math.Abs(DeltaY) / (Math.Abs(DeltaX) + 9.999999E-21d)) * 180d / Pi;
                if (DeltaY >= 0d & DeltaX >= 0d)
                    CPABearing = 90d - CPABearing;
                if (DeltaY >= 0d & DeltaX < 0d)
                    CPABearing = 270d + CPABearing;
                if (DeltaY < 0d & DeltaX >= 0d)
                    CPABearing = 90d + CPABearing;
                if (DeltaY < 0d & DeltaX < 0d)
                    CPABearing = 270d - CPABearing;
                CPABearing = Conversion.Int(CPABearing * 10d + 0.5d) / 10d;
                TimeToCPA = (float)(Conversion.Int(TimeToCPA * 10f + 0.5d) / 10d);
                Range = Math.Sqrt(Range);
                Range = Conversion.Int(Range * 100d + 0.5d) / 100d;
                if (CPAexists == true)
                {
                    txtMoB.AppendText("CPA = " + Strings.Format(Range, "0.00") + " nm in " + Strings.Format(TimeToCPA, "0.0") + " minutes" + Constants.vbNewLine); // ;
                    txtMoB.AppendText("Bearing at CPA = " + Strings.Format(CPABearing, "000.0") + '°' + Constants.vbNewLine);
                }

                if (CPAexists == false)
                {
                }

                txtMoB.AppendText("DRM = " + Strings.Format(DRM, "000.0") + '°' + Constants.vbNewLine);
                txtMoB.AppendText("SRM = " + Strings.Format(SRM, "0.0") + " knots" + Constants.vbNewLine);
            }

            if (optWind.Checked == true)
            {
                txtMoB.Clear();
                ApparentWindDir = (float)(Conversion.Val(txtCourse.Text) + Conversion.Val(txtWindDir.Text));
                if (ApparentWindDir >= 360f)
                    ApparentWindDir = ApparentWindDir - 360f;
                if (Conversion.Val(txtCourse.Text) >= 0d & Conversion.Val(txtCourse.Text) < 90d)
                {
                    Course = Conversion.Val(txtCourse.Text);
                    xV1S = 1;
                    yV1S = 1;
                }

                if (Conversion.Val(txtCourse.Text) >= 90d & Conversion.Val(txtCourse.Text) < 180d)
                {
                    Course = 180d - Conversion.Val(txtCourse.Text);
                    xV1S = 1;
                    yV1S = -1;
                }

                if (Conversion.Val(txtCourse.Text) >= 180d & Conversion.Val(txtCourse.Text) < 270d)
                {
                    Course = Conversion.Val(txtCourse.Text) - 180d;
                    xV1S = -1;
                    yV1S = -1;
                }

                if (Conversion.Val(txtCourse.Text) >= 270d & Conversion.Val(txtCourse.Text) < 360d)
                {
                    Course = 360d - Conversion.Val(txtCourse.Text);
                    xV1S = -1;
                    yV1S = 1;
                }

                DeltaX = xV1S * Conversion.Val(txtSpeed.Text) * Math.Sin(Course * Pi / 180d) + Conversion.Val(txtWindSpeed.Text) * Math.Sin((ApparentWindDir - 180f) * Pi / 180d);
                DeltaY = yV1S * Conversion.Val(txtSpeed.Text) * Math.Cos(Course * Pi / 180d) + Conversion.Val(txtWindSpeed.Text) * Math.Cos((ApparentWindDir - 180f) * Pi / 180d);
                TrueWindDir = Math.Atan(Math.Abs(DeltaY) / Math.Abs(DeltaX + 9.999999E-21d)) * 180d / Pi;
                if (DeltaY >= 0d & DeltaX >= 0d)
                    TrueWindDir = 90d - TrueWindDir;
                if (DeltaY >= 0d & DeltaX < 0d)
                    TrueWindDir = 270d + TrueWindDir;
                if (DeltaY < 0d & DeltaX >= 0d)
                    TrueWindDir = 90d + TrueWindDir;
                if (DeltaY < 0d & DeltaX < 0d)
                    TrueWindDir = 270d - TrueWindDir;
                TrueWindDir = TrueWindDir - 180d;
                TrueWindSpeed = Math.Sqrt(DeltaX * DeltaX + DeltaY * DeltaY);
                if (TrueWindDir >= 360d)
                    TrueWindDir = TrueWindDir - 360d;
                if (TrueWindDir < 0d)
                    TrueWindDir = TrueWindDir + 360d;
                TrueWindDir = Conversion.Int(TrueWindDir * 10d + 0.5d) / 10d;
                TrueWindSpeed = Conversion.Int(TrueWindSpeed * 10d + 0.5d) / 10d;
                txtMoB.AppendText("True wind from " + Strings.Format(TrueWindDir, "000.0") + '°' + " at " + Strings.Format(TrueWindSpeed, "0.0") + " knots" + Constants.vbNewLine);
            }

            if (optWindApp.Checked == true)
            {
                txtMoB.Clear();
                PointingAngle = Conversion.Val(txtWindDir.Text) - Conversion.Val(txtCourse.Text); // if both the same, gives 0 (upwind), should give 180 (downwind)
                if (PointingAngle < 0d)
                    PointingAngle = PointingAngle + 360d;
                PointingAngle = PointingAngle * Pi / 180d; // radians
                if (PointingAngle < 0d)
                    PointingAngle = PointingAngle + 2d * Pi;
                ApparentWindSpeed = Math.Sqrt(Conversion.Val(txtWindSpeed.Text) * Conversion.Val(txtWindSpeed.Text) + Conversion.Val(txtSpeed.Text) * Conversion.Val(txtSpeed.Text) + 2d * Conversion.Val(txtWindSpeed.Text) * Conversion.Val(txtSpeed.Text) * Math.Cos(PointingAngle));
                if (ApparentWindSpeed == 0d)
                    ApparentWindSpeed = 1.0E-21d; // prevents overflow error
                ApparentWindDir = (float)((Conversion.Val(txtWindSpeed.Text) * Math.Cos(PointingAngle) + Conversion.Val(txtSpeed.Text)) / ApparentWindSpeed);
                if (ApparentWindDir == 1f)
                    ApparentWindDir = (float)(ApparentWindDir - 0.0000001d); // prevents divide-by-zero error
                ApparentWindDir = (float)(Math.Atan(-ApparentWindDir / Math.Sqrt(-ApparentWindDir * ApparentWindDir + 1f)) + Pi / 2d); // arccos in radians
                ApparentWindDir = (float)(ApparentWindDir * 180f / Pi);
                if (PointingAngle > Pi)
                    ApparentWindDir = 360f - ApparentWindDir; // 180º
                ApparentWindDir = (float)(Conversion.Int(ApparentWindDir * 10f + 0.5d) / 10d);
                ApparentWindSpeed = Conversion.Int(ApparentWindSpeed * 10d + 0.5d) / 10d;
                txtMoB.AppendText("Apparent wind from " + Strings.Format(ApparentWindDir, "000.0") + '°' + " relative at " + Strings.Format(ApparentWindSpeed, "0.0") + " knots" + Constants.vbNewLine);
            }
            // intResponse = ErrorMsgBoxResult.Ignore
        }

        private void cmdClear_Click(object eventSender, EventArgs eventArgs)
        {
            if (optCPATypeA.Checked == true)
            {
                txtTime1.Text = "";
                txtTime2.Text = "";
                txtRange1.Text = "";
                txtRange2.Text = "";
                txtBearing1.Text = "";
                txtBearing2.Text = "";
                txtV1Speed.Text = "";
                txtV1Course.Text = "";
                txtMoB.Clear();
                txtTime1.Focus();
            }

            if (optCPATypeB.Checked == true)
            {
                txtSpeed1.Text = "";
                txtSpeed2.Text = "";
                txtCourse1.Text = "";
                txtCourse2.Text = "";
                txtRange.Text = "";
                txtBearing.Text = "";
                txtMoB.Clear();
                txtCourse1.Focus();
            }

            if (optWind.Checked == true | optWindApp.Checked == true)
            {
                txtCourse.Text = "";
                txtSpeed.Text = "";
                txtWindSpeed.Text = "";
                txtWindDir.Text = "";
                txtMoB.Clear();
                txtCourse.Focus();
            }
        }

        private void cmdPrint_Click(object eventSender, EventArgs eventArgs)
        {
            Print_Renamed.PrintScreen(Bounds);
        }

        private void optCPATypeA_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optCPATypeA.Checked)
            {
                if (optCPATypeA.Checked == true)
                {
                    cmdCalculate.TabIndex = 14;
                    Label1.Visible = true;
                    Label2.Visible = true;
                    Label3.Visible = true;
                    Label4.Visible = true;
                    Label5.Visible = true;
                    Label6.Visible = true;
                    Label8.Visible = false;
                    Label9.Visible = false;
                    Label10.Visible = false;
                    Label11.Visible = false;
                    Label12.Visible = false;
                    Label13.Visible = false;
                    Label14.Visible = false;
                    Label15.Visible = false;
                    txtTime1.Visible = true;
                    txtTime2.Visible = true;
                    txtRange1.Visible = true;
                    txtRange2.Visible = true;
                    txtBearing1.Visible = true;
                    txtBearing2.Visible = true;
                    txtSpeed1.Visible = false;
                    txtSpeed2.Visible = false;
                    txtCourse1.Visible = false;
                    txtCourse2.Visible = false;
                    txtRange.Visible = false;
                    txtBearing.Visible = false;
                    Label16.Visible = true;
                    Label17.Visible = true;
                    txtV1Course.Visible = true;
                    txtV1Speed.Visible = true;
                    txtTime1.Focus();
                    Label18.Visible = false;
                    Label19.Visible = false;
                    Label20.Visible = false;
                    Label21.Visible = false;
                    Label22.Visible = false;
                    Label23.Visible = false;
                    txtCourse.Visible = false;
                    txtSpeed.Visible = false;
                    txtWindSpeed.Visible = false;
                    txtWindDir.Visible = false;
                }

                txtMoB.Clear();
            }
        }

        private void optCPATypeB_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optCPATypeB.Checked)
            {
                if (optCPATypeB.Checked == true)
                {
                    cmdCalculate.TabIndex = 27;
                    Label1.Visible = false;
                    Label2.Visible = false;
                    Label3.Visible = false;
                    Label4.Visible = false;
                    Label5.Visible = false;
                    Label6.Visible = false;
                    Label8.Visible = true;
                    Label9.Visible = true;
                    Label10.Visible = true;
                    Label11.Visible = true;
                    Label12.Visible = true;
                    Label13.Visible = true;
                    Label14.Visible = true;
                    Label15.Visible = true;
                    txtTime1.Visible = false;
                    txtTime2.Visible = false;
                    txtRange1.Visible = false;
                    txtRange2.Visible = false;
                    txtBearing1.Visible = false;
                    txtBearing2.Visible = false;
                    txtSpeed1.Visible = true;
                    txtSpeed2.Visible = true;
                    txtCourse1.Visible = true;
                    txtCourse2.Visible = true;
                    txtRange.Visible = true;
                    txtBearing.Visible = true;
                    Label16.Visible = false;
                    Label17.Visible = false;
                    txtV1Course.Visible = false;
                    txtV1Speed.Visible = false;
                    txtCourse1.Focus();
                    Label18.Visible = false;
                    Label19.Visible = false;
                    Label20.Visible = false;
                    Label21.Visible = false;
                    Label22.Visible = false;
                    Label23.Visible = false;
                    txtCourse.Visible = false;
                    txtSpeed.Visible = false;
                    txtWindSpeed.Visible = false;
                    txtWindDir.Visible = false;
                }

                txtMoB.Clear();
            }
        }

        private void optWind_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optWind.Checked)
            {
                if (optWind.Checked == true)
                {
                    cmdCalculate.TabIndex = 27;
                    Label1.Visible = false;
                    Label2.Visible = false;
                    Label3.Visible = false;
                    Label4.Visible = false;
                    Label5.Visible = false;
                    Label6.Visible = false;
                    Label8.Visible = false;
                    Label9.Visible = false;
                    Label10.Visible = false;
                    Label11.Visible = false;
                    Label12.Visible = false;
                    Label13.Visible = false;
                    Label14.Visible = false;
                    Label15.Visible = false;
                    txtTime1.Visible = false;
                    txtTime2.Visible = false;
                    txtRange1.Visible = false;
                    txtRange2.Visible = false;
                    txtBearing1.Visible = false;
                    txtBearing2.Visible = false;
                    txtSpeed1.Visible = false;
                    txtSpeed2.Visible = false;
                    txtCourse1.Visible = false;
                    txtCourse2.Visible = false;
                    txtRange.Visible = false;
                    txtBearing.Visible = false;
                    Label16.Visible = false;
                    Label17.Visible = false;
                    txtV1Course.Visible = false;
                    txtV1Speed.Visible = false;
                    Label18.Visible = true;
                    Label19.Visible = true;
                    Label20.Visible = true;
                    Label21.Visible = true;
                    Label22.Visible = false;
                    Label23.Visible = false;
                    txtCourse.Visible = true;
                    txtCourse.Focus();
                    txtSpeed.Visible = true;
                    txtWindSpeed.Visible = true;
                    txtWindDir.Visible = true;
                }

                cmdClear_Click(cmdClear, new EventArgs());
            }
        }

        private void optWindApp_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optWindApp.Checked)
            {
                if (optWindApp.Checked == true)
                {
                    cmdCalculate.TabIndex = 27;
                    Label1.Visible = false;
                    Label2.Visible = false;
                    Label3.Visible = false;
                    Label4.Visible = false;
                    Label5.Visible = false;
                    Label6.Visible = false;
                    Label8.Visible = false;
                    Label9.Visible = false;
                    Label10.Visible = false;
                    Label11.Visible = false;
                    Label12.Visible = false;
                    Label13.Visible = false;
                    Label14.Visible = false;
                    Label15.Visible = false;
                    txtTime1.Visible = false;
                    txtTime2.Visible = false;
                    txtRange1.Visible = false;
                    txtRange2.Visible = false;
                    txtBearing1.Visible = false;
                    txtBearing2.Visible = false;
                    txtSpeed1.Visible = false;
                    txtSpeed2.Visible = false;
                    txtCourse1.Visible = false;
                    txtCourse2.Visible = false;
                    txtRange.Visible = false;
                    txtBearing.Visible = false;
                    Label16.Visible = false;
                    Label17.Visible = false;
                    txtV1Course.Visible = false;
                    txtV1Speed.Visible = false;
                    Label18.Visible = true;
                    Label19.Visible = true;
                    Label20.Visible = false;
                    Label21.Visible = false;
                    Label22.Visible = true;
                    Label23.Visible = true;
                    txtCourse.Visible = true;
                    txtCourse.Focus();
                    txtSpeed.Visible = true;
                    txtWindSpeed.Visible = true;
                    txtWindDir.Visible = true;
                }

                cmdClear_Click(cmdClear, new EventArgs());
            }
        }

        private void txtBearing_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtBearing.Text) > 359.9d)
            {
                txtBearing.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtBearing.Text) < 359.9d)
            {
                txtBearing.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtBearing_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        if (Conversions.ToBoolean(Strings.InStr(txtBearing.Text, ".")))
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

        private void txtBearing_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtBearing.Text) > 359.9d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtBearing_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtBearing;
            SelectAllText(ref argTB);
            txtBearing = argTB;
        }

        private void txtBearing1_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtBearing1.Text) > 359.9d)
            {
                txtBearing1.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtBearing1.Text) < 359.9d)
            {
                txtBearing1.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtBearing1_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        if (Conversions.ToBoolean(Strings.InStr(txtBearing1.Text, ".")))
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

        private void txtBearing1_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtBearing1.Text) > 359.9d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtBearing1_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtBearing1;
            SelectAllText(ref argTB);
            txtBearing1 = argTB;
        }

        private void txtBearing2_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtBearing2.Text) > 359.9d)
            {
                txtBearing2.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtBearing2.Text) < 359.9d)
            {
                txtBearing2.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtBearing2_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        if (Conversions.ToBoolean(Strings.InStr(txtBearing2.Text, ".")))
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

        private void txtBearing2_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtBearing2.Text) > 359.9d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtBearing2_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtBearing2;
            SelectAllText(ref argTB);
            txtBearing2 = argTB;
        }

        private void txtCourse1_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtCourse1.Text) > 359.9d)
            {
                txtCourse1.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtCourse1.Text) < 359.9d)
            {
                // txtCourse.ForeColor = &H80000008
                txtCourse1.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtCourse1_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        if (Conversions.ToBoolean(Strings.InStr(txtCourse1.Text, ".")))
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

        private void txtCourse1_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtCourse1.Text) > 359.9d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtCourse1_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtCourse1;
            SelectAllText(ref argTB);
            txtCourse1 = argTB;
        }

        private void txtCourse2_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtCourse2.Text) > 359.9d)
            {
                txtCourse2.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtCourse2.Text) < 359.9d)
            {
                txtCourse2.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtCourse2_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        if (Conversions.ToBoolean(Strings.InStr(txtCourse2.Text, ".")))
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

        private void txtCourse2_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtCourse2.Text) > 359.9d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtCourse2_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtCourse2;
            SelectAllText(ref argTB);
            txtCourse2 = argTB;
        }

        private void txtRange_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtRange.Text) > 99.99d)
            {
                txtRange.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtRange.Text) <= 99.99d)
            {
                // txtDist.ForeColor = &H80000008
                txtRange.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtRange_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        if (Conversions.ToBoolean(Strings.InStr(txtRange.Text, ".")))
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

        private void txtRange_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            // If Val(txtDist.Text) > 600 Then
            // KeepFocus = True
            // End If
            eventArgs.Cancel = KeepFocus;
        }

        private void txtRange_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtRange;
            SelectAllText(ref argTB);
            txtRange = argTB;
        }

        private void txtRange1_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtRange1.Text) > 99.99d)
            {
                txtRange1.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtRange1.Text) <= 99.99d)
            {
                txtRange1.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtRange1_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        if (Conversions.ToBoolean(Strings.InStr(txtRange1.Text, ".")))
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

        private void txtRange1_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            // If Val(txtDist.Text) > 600 Then
            // KeepFocus = True
            // End If
            eventArgs.Cancel = KeepFocus;
        }

        private void txtRange1_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtRange1;
            SelectAllText(ref argTB);
            txtRange1 = argTB;
        }

        private void txtRange2_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtRange2.Text) > 99.99d)
            {
                txtRange2.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtRange2.Text) <= 99.99d)
            {
                txtRange2.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtRange2_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        if (Conversions.ToBoolean(Strings.InStr(txtRange2.Text, ".")))
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

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtRange2_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            // If Val(txtDist.Text) > 600 Then
            // KeepFocus = True
            // End If
            eventArgs.Cancel = KeepFocus;
        }

        private void txtRange2_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtRange2;
            SelectAllText(ref argTB);
            txtRange2 = argTB;
        }

        private void txtSpeed1_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtSpeed1.Text) > 99.9d)
            {
                txtSpeed1.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtSpeed1.Text) <= 99.9d)
            {
                txtSpeed1.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtSpeed1_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        if (Conversions.ToBoolean(Strings.InStr(txtSpeed1.Text, ".")))
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

        private void txtSpeed1_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtSpeed1.Text) > 99.9d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtSpeed1_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtSpeed1;
            SelectAllText(ref argTB);
            txtSpeed1 = argTB;
        }

        private void txtSpeed2_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtSpeed2.Text) > 99.9d)
            {
                txtSpeed2.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtSpeed2.Text) <= 99.9d)
            {
                txtSpeed2.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtSpeed2_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        if (Conversions.ToBoolean(Strings.InStr(txtSpeed2.Text, ".")))
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

        private void txtSpeed2_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtSpeed2.Text) > 99.9d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtSpeed2_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtSpeed2;
            SelectAllText(ref argTB);
            txtSpeed2 = argTB;
        }

        private void txtTime1_TextChanged(object eventSender, EventArgs eventArgs)
        {
            txtTime1.BackColor = Control.DefaultBackColor; 
            if (Strings.Len(txtTime1.Text) == 4 & (Conversion.Val(Strings.Left(txtTime1.Text, 2)) > 23d | Conversion.Val(Strings.Mid(txtTime1.Text, 3, 2)) > 59d))
            {
                txtTime1.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }
        }

        private void txtTime1_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        private void txtTime1_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(Strings.Left(txtTime1.Text, 2)) > 23d | Conversion.Val(Strings.Mid(txtTime1.Text, 3, 2)) > 59d | Strings.Len(txtTime1.Text) != 4)
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
            txtTime2.BackColor = Control.DefaultBackColor; 
            if (Strings.Len(txtTime2.Text) == 4 & (Conversion.Val(Strings.Left(txtTime2.Text, 2)) > 23d | Conversion.Val(Strings.Mid(txtTime2.Text, 3, 2)) > 59d))
            {
                txtTime2.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }
        }

        private void txtTime2_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        private void txtTime2_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(Strings.Left(txtTime2.Text, 2)) > 23d | Conversion.Val(Strings.Mid(txtTime2.Text, 3, 2)) > 59d | Strings.Len(txtTime2.Text) != 4)
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

        private void txtV1Course_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtV1Course.Text) > 359.9d)
            {
                txtV1Course.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtV1Course.Text) < 359.9d)
            {
                txtV1Course.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtV1Course_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        if (Conversions.ToBoolean(Strings.InStr(txtV1Course.Text, ".")))
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

        private void txtV1Course_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtV1Course.Text) > 359.9d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtV1Course_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtV1Course;
            SelectAllText(ref argTB);
            txtV1Course = argTB;
        }

        private void txtV1Speed_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtV1Speed.Text) > 99.9d)
            {
                txtV1Speed.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtV1Speed.Text) <= 99.9d)
            {
                txtV1Speed.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtV1Speed_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        if (Conversions.ToBoolean(Strings.InStr(txtV1Speed.Text, ".")))
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

        private void txtV1Speed_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtV1Speed.Text) > 99.9d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtV1Speed_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtV1Speed;
            SelectAllText(ref argTB);
            txtV1Speed = argTB;
        }

        private void txtCourse_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtCourse.Text) > 359.9d)
            {
                txtCourse.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtCourse.Text) < 359.9d)
            {
                txtCourse.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtCourse_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        private void txtSpeed_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtSpeed.Text) > 99.9d)
            {
                txtSpeed.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtSpeed.Text) <= 99.9d)
            {
                txtSpeed.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtSpeed_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        private void txtWindDir_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Math.Abs(Conversion.Val(txtWindDir.Text)) > 359.9d)
            {
                txtWindDir.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Math.Abs(Conversion.Val(txtWindDir.Text)) < 359.9d)
            {
                txtWindDir.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtWindDir_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            short KeyAscii = (short)Strings.Asc(eventArgs.KeyChar);
            ;
            bool bMinusSignAlready = false; // As Boolean

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
                        // If Len(txtWindDir.Text) > 0 Then
                        // KeyAscii = 0
                        // Beep
                        // End If
                        if (txtWindDir.SelectionStart != 0 | bMinusSignAlready)
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
                        // If Len(txtWindDir.Text) > 0 Then
                        // KeyAscii = 0
                        // Beep
                        // End If

                        if (txtWindDir.SelectionStart != 0 | bPlusSignAlready)
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

                case (short)('.'): // only allows one decimal point
                    {
                        if (Conversions.ToBoolean(Strings.InStr(txtWindDir.Text, ".")))
                        {
                            if (KeyAscii == 46)
                            {
                                KeyAscii = 0;
                                Interaction.Beep();
                            }
                        }

                        break;
                    }

                case var case1 when case1 == (short)('\b'):
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

        private void txtWindDir_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtWindDir.Text) > 359.9d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtWindDir_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtWindDir;
            SelectAllText(ref argTB);
            txtWindDir = argTB;
        }

        private void txtWindSpeed_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtWindSpeed.Text) > 99.9d)
            {
                txtWindSpeed.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtWindSpeed.Text) <= 99.9d)
            {
                txtWindSpeed.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtWindSpeed_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        if (Conversions.ToBoolean(Strings.InStr(txtWindSpeed.Text, ".")))
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

        private void txtWindSpeed_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtWindSpeed.Text) > 99.9d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtWindSpeed_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtWindSpeed;
            SelectAllText(ref argTB);
            txtWindSpeed = argTB;
        }

        private void SelectAllText(ref TextBox TB)
        {
            TB.SelectionStart = 0;
            TB.SelectionLength = Strings.Len(TB.Text);
        }

        private void ErrorMsgBox(string ErrMsg)
        {
            MessageBox.Show(ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            return;
        }
    }
}