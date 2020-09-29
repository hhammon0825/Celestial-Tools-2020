using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    internal partial class FormTwoBearings : Form
    {
        private double Pi;
        private short Time2inMinutes, Bearing2, Bearing1, Time1inMinutes, TimeinMinutes;
        private short TimeHours, TimeMinutes;
        private double DistanceToObject, DistanceTraveled, BeamDistance;
        private double TimeOfCPA, DistanceUntilObjectAbeam, TimeToCPA, TimeOfCPAm;
        private short TimeOfCPAh;
        private double DistanceToObjectAbeam;
        private string fnumeral;
        private short MaxTimem;
        private short B2, B1, B3;
        private float I1, I2;
        private short C, MB, y;
        private object[] x = new object[181];
        private double Z;
        private short Course2, Course1, Course;
        private string ResultCourse;
        private double Lfix, L2, L1, Lo1, Lo2, LoFix;
        private short Bg1, Bg2;
        private string L2Min, L1Min, Lo1Min, Lo2Min;
        private short LfixDeg, LofixDeg;
        private double LfixMin, LofixMin;
        private double dst13, ang2, crs21, dst12, w, crs12, ang1, ang3, DLo;
        private string FL, FixL, FixLo, FLo;
        private short r;
        private float Sep;

        private void cmdCalculateD_Click(object eventSender, EventArgs eventArgs)
        {
            Pi = 4d * Math.Atan(1.0d);
            Bearing1 = (short)(Conversion.Val(txtCourse.Text) - Conversion.Val(txtBearing1.Text));
            if (Bearing1 < 0)
                Bearing1 = (short)(Bearing1 + 360);
            if (Bearing1 > 90)
                Bearing1 = (short)(360 - Bearing1);
            Bearing2 = (short)(Conversion.Val(txtCourse.Text) - Conversion.Val(txtBearing2.Text));
            if (Bearing2 < 0)
                Bearing2 = (short)(Bearing2 + 360);
            if (Bearing2 > 90)
                Bearing2 = (short)(360 - Bearing2);
            if (Math.Abs(Bearing1) >= Math.Abs(Bearing2))
            {
                ErrorMsgBox("Incorrect bearings.  Not moving towards object.");
                return;
            }

            Time1inMinutes = (short)(60d * Conversion.Val(Strings.Left(txtTime1.Text, 2)) + Conversion.Val(Strings.Right(txtTime1.Text, 2)));
            Time2inMinutes = (short)(60d * Conversion.Val(Strings.Left(txtTime2.Text, 2)) + Conversion.Val(Strings.Right(txtTime2.Text, 2)));
            TimeinMinutes = (short)(Time2inMinutes - Time1inMinutes);
            TimeHours = (short)Conversion.Int(TimeinMinutes / 60d);
            TimeMinutes = (short)(TimeinMinutes - 60 * TimeHours);
            if (TimeinMinutes < 0)
            {
                ErrorMsgBox("Error:  Time1 later than Time2");
                return;
            }

            if (TimeinMinutes == 0)
                TimeinMinutes = (short)(60d * Conversion.Val(txtTimeh.Text) + Conversion.Val(txtTimem.Text));
            // DistanceTraveled
            if (Conversion.Val(txtLog2.Text) < Conversion.Val(txtLog1.Text))
            {
                ErrorMsgBox("Error:  Log1 greater than Log2");
                return;
            }

            DistanceTraveled = Conversion.Val(txtLog2.Text) - Conversion.Val(txtLog1.Text); // : txtDist.Text = Str$(DistanceTraveled) 'Log values entered
            if (string.IsNullOrEmpty(txtLog1.Text) & string.IsNullOrEmpty(txtLog2.Text))
            {
                DistanceTraveled = Conversion.Val(txtDist.Text); // No log values entered
            }

            if (DistanceTraveled == 0d)
            {
                DistanceTraveled = Conversion.Val(txtSpeed.Text) * TimeinMinutes / 60d; // : txtDist.Text = Str$(DistanceTraveled) 'No log or DistanceTraveled values entered, use speed and time
            }

            DistanceToObject = Math.Abs(DistanceTraveled * Math.Sin(Bearing1 * Pi / 180d) / Math.Sin((Bearing2 - Bearing1) * Pi / 180d));
            BeamDistance = Math.Abs(DistanceToObject * Math.Sin(Bearing2 * Pi / 180d));

            // DistanceToObjectAbeam = DistanceToObject * Cos(Val(txtBearing2.Text * Pi / 180))
            DistanceUntilObjectAbeam = Math.Sqrt(Math.Abs(DistanceToObject * DistanceToObject - BeamDistance * BeamDistance));
            if (!string.IsNullOrEmpty(txtSpeed.Text))
                TimeToCPA = 60d * DistanceUntilObjectAbeam / Conversion.Val(txtSpeed.Text); // CPA is when object is abeam
            if (!string.IsNullOrEmpty(txtTime2.Text))
            {
                TimeOfCPA = Time2inMinutes + TimeToCPA;
                TimeToCPA = Conversion.Int(TimeToCPA * 10d + 0.5d) / 10d;
                TimeOfCPA = TimeOfCPA / 60d; // decimal hours
                TimeOfCPAh = (short)Conversion.Int(TimeOfCPA);
                TimeOfCPAm = (TimeOfCPA - TimeOfCPAh) * 60d;
                TimeOfCPAm = Conversion.Int(TimeOfCPAm + 0.5d);
                if (TimeOfCPAh >= 24)
                    TimeOfCPAh = (short)(TimeOfCPAh - 24);
                TimeOfCPA = 100 * TimeOfCPAh + TimeOfCPAm;
            }

            DistanceTraveled = Conversion.Int(DistanceTraveled * 100d + 0.5d) / 100d;
            BeamDistance = Conversion.Int(BeamDistance * 100d + 0.5d) / 100d;
            DistanceToObjectAbeam = Conversion.Int(DistanceToObjectAbeam * 100d + 0.5d) / 100d;
            TimeToCPA = Conversion.Int(TimeToCPA + 0.5d);
            TimeOfCPA = 100 * TimeOfCPAh + TimeOfCPAm;
            DistanceTxtBx.Clear();
            DistanceTxtBx.SelectionAlignment = HorizontalAlignment.Center;
            DistanceTxtBx.AppendText("Distance of object at second bearing " + Strings.Format(DistanceToObject, "0.00") + " nm" + Constants.vbNewLine);
            DistanceTxtBx.AppendText("Distance of object when abeam " + Strings.Format(BeamDistance, "0.00") + " nm" + Constants.vbNewLine);
            DistanceTxtBx.AppendText("Distance until object is abeam " + Strings.Format(DistanceUntilObjectAbeam, "0.00") + " nm" + Constants.vbNewLine);
            if (string.IsNullOrEmpty(txtDist.Text) & string.IsNullOrEmpty(txtTimeh.Text) & string.IsNullOrEmpty(txtTimem.Text) & !string.IsNullOrEmpty(txtTime1.Text))
            {
                DistanceTxtBx.AppendText("Run Time " + Strings.Format(TimeHours, "##0") + "h" + Strings.Format(TimeMinutes, "00") + "m" + Constants.vbNewLine);
            }

            if (!string.IsNullOrEmpty(txtSpeed.Text))
            {
                DistanceTxtBx.AppendText("Time from second bearing to object abeam " + Strings.Format(TimeToCPA, "0") + " min." + Constants.vbNewLine);
            }

            if (!string.IsNullOrEmpty(txtTime2.Text))
            {
                DistanceTxtBx.AppendText("Time of object abeam " + Strings.Format(TimeOfCPA, "0000") + Constants.vbNewLine);
            }

            return;
        }

        private void cmdCalculateF2_Click(object eventSender, EventArgs eventArgs)
        {
            Label28.Visible = false;
            Sep = (float)Math.Abs(Conversion.Val(txtBg1.Text) - Conversion.Val(txtBg2.Text));
            if (Sep >= 225f)
                Sep = 360f - Sep;
            Pi = 4d * Math.Atan(1.0d);
            r = 180;
            if ((int)chkReciprocal.CheckState == 1)
            {
                r = 0;
            }

            LatLong();
            // Method fails if Lo1=Lo2 (or if L1=0 and L2=0)
            if (Lo1 == Lo2)
                Lo1 = Lo1 + 0.00001d;
            // If (L1=0 and L2=0) then
            w = Math.Sqrt(Math.Pow(Math.Sin((L1 - L2) / 2d * Pi / 180d), 2d) + Math.Cos(L1 * Pi / 180d) * Math.Cos(L2 * Pi / 180d) * Math.Pow(Math.Sin((Lo1 - Lo2) / 2d * Pi / 180d), 2d));
            dst12 = 2d * Math.Atan(w / (Math.Sqrt(-w * w + 1d) + 9.999999E-21d)); // 2*arcsin, radians
            if (Math.Sin((Lo2 - Lo1) * Pi / 180d) < 0d)
            {
                w = (Math.Sin(L2 * Pi / 180d) - Math.Sin(L1 * Pi / 180d) * Math.Cos(dst12)) / (Math.Sin(dst12) * Math.Cos(L1 * Pi / 180d));
                crs12 = Math.Atan(-w / Math.Sqrt(-w * w + 1d)) + Pi / 2d; // arccos, radians
                w = (Math.Sin(L1 * Pi / 180d) - Math.Sin(L2 * Pi / 180d) * Math.Cos(dst12)) / (Math.Sin(dst12) * Math.Cos(L2 * Pi / 180d));
                crs21 = 2d * Pi - (Math.Atan(-w / Math.Sqrt(-w * w + 1d)) + Pi / 2d); // 2*Pi - arccos, radians
            }
            else
            {
                w = (Math.Sin(L2 * Pi / 180d) - Math.Sin(L1 * Pi / 180d) * Math.Cos(dst12)) / (Math.Sin(dst12) * Math.Cos(L1 * Pi / 180d));
                crs12 = 2d * Pi - (Math.Atan(-w / Math.Sqrt(-w * w + 1d)) + Pi / 2d); // 2*Pi - arccos, radians
                w = (Math.Sin(L1 * Pi / 180d) - Math.Sin(L2 * Pi / 180d) * Math.Cos(dst12)) / (Math.Sin(dst12) * Math.Cos(L2 * Pi / 180d));
                crs21 = Math.Atan(-w / Math.Sqrt(-w * w + 1d)) + Pi / 2d;
            } // arccos, radians

            ang1 = (Conversion.Val(txtBg1.Text) + r) * Pi / 180d - crs12 + Pi;
            if (ang1 > 2d * Pi)
                ang1 = ang1 - 2d * Pi;
            ang1 = ang1 - Pi;
            ang2 = crs21 - (Conversion.Val(txtBg2.Text) + r) * Pi / 180d + Pi;
            if (ang2 > 2d * Pi)
                ang2 = ang2 - 2d * Pi;
            ang2 = ang2 - Pi;
            if (Math.Sin(ang1) == 0d & Math.Sin(ang2) == 0d)
            {
                ErrorMsgBox("Check data.  Infinite number of intersections.");
                return;
            }

            if (Math.Sin(ang1) * Math.Sin(ang2) < 0d)
            {
                ErrorMsgBox("Check data.  Ambiguous intersection.");
                return;
            }

            ang1 = Math.Abs(ang1);
            ang2 = Math.Abs(ang2);
            w = -Math.Cos(ang1) * Math.Cos(ang2) + Math.Sin(ang1) * Math.Sin(ang2) * Math.Cos(dst12);
            ang3 = Math.Atan(-w / Math.Sqrt(-w * w + 1d)) + Pi / 2d; // arccos, radians
            dst13 = Atan2(Math.Sin(dst12) * Math.Sin(ang1) * Math.Sin(ang2), Math.Cos(ang2) + Math.Cos(ang1) * Math.Cos(ang3));
            w = Math.Sin(L1 * Pi / 180d) * Math.Cos(dst13) + Math.Cos(L1 * Pi / 180d) * Math.Sin(dst13) * Math.Cos((Conversion.Val(txtBg1.Text) + r) * Pi / 180d);
            Lfix = Math.Atan(w / (Math.Sqrt(-w * w + 1d) + 9.999999E-21d)); // arcsin, radians
            DLo = Atan2(Math.Sin((Conversion.Val(txtBg1.Text) + r) * Pi / 180d) * Math.Sin(dst13) * Math.Cos(L1 * Pi / 180d), Math.Cos(dst13) - Math.Sin(L1 * Pi / 180d) * Math.Sin(Lfix));
            LoFix = Lo1 * Pi / 180d - DLo + Pi;
            if (LoFix > 2d * Pi)
                LoFix = LoFix - 2d * Pi;
            LoFix = LoFix - Pi;
            Lfix = Lfix * 180d / Pi;
            LoFix = LoFix * 180d / Pi;
            if (Math.Abs(LoFix) > 180d)
                LoFix = -Math.Sign(LoFix) * (360d - Math.Abs(LoFix));
            LfixDeg = (short)Conversion.Int(Math.Abs(Lfix));
            LfixMin = (Math.Abs(Lfix) - LfixDeg) * 60d;
            if (Conversion.Int(LfixMin * 10d + 0.5d) / 10d == 60d)
            {
                LfixMin = 0d;
                LfixDeg = (short)(LfixDeg + 1);
            }

            LfixDeg = Math.Abs(LfixDeg);
            LofixDeg = (short)Conversion.Int(Math.Abs(LoFix));
            LofixMin = (Math.Abs(LoFix) - LofixDeg) * 60d;
            if (Conversion.Int(LofixMin * 10d + 0.5d) / 10d == 60d)
            {
                LofixMin = 0d;
                LofixDeg = (short)(LofixDeg + 1);
            }

            if (Lfix > 0d)
                FL = CommonGlobals.g_LatN;
            if (Lfix == 0d)
                FL = " ";
            if (Lfix < 0d)
                FL = CommonGlobals.g_LatS;
            if (LoFix > 0d)
                FLo = CommonGlobals.g_LongW;
            if (LoFix == 0d)
                FLo = " ";
            if (LoFix < 0d)
                FLo = CommonGlobals.g_LongE;
            txtFixL.Clear();
            txtFixLo.Clear();

            // Label26.Visible = True
            // txtFixL.Visible = True

            txtFixL.AppendText(Strings.Format(LfixDeg, "0") + '°' + Strings.Format(LfixMin, "00.0") + "'" + FL);
            // Label27.Visible = True
            // txtFixLo.Visible = True
            txtFixLo.AppendText(string.Format(LofixDeg.ToString(), "0") + '°' + string.Format(LofixMin.ToString(), "00.0") + "'" + FLo);
            if (Sep > 135f | Sep < 45f)
                Label28.Visible = true;
        }

        private void cmdClearC_Click(object eventSender, EventArgs eventArgs)
        {
            txtB1.Clear();
            txtB2.Clear();
            txtB3.Clear();
            txtI1.Clear();
            txtI2.Clear();
            txtResultCourse.Clear();

            // Label14.Visible = False
            // txtResultCourse.Visible = False
        }

        private void cmdClearF2_Click(object eventSender, EventArgs eventArgs)
        {
            txtFixL.Clear();
            txtFixLo.Clear();
            txtBg1.Clear();
            txtBg2.Clear();
            txtL1Deg.Clear();
            txtL1Min.Clear();
            txtLo1Deg.Clear();
            txtLo1Min.Clear();
            txtL2Deg.Clear();
            txtL2Min.Clear();
            txtLo2Deg.Clear();
            txtLo2Min.Clear();
            // Label26.Visible = False
            // Label27.Visible = False
            // txtFixL.Visible = False
            // txtFixLo.Visible = False
            // Label28.Visible = False
            chkReciprocal.CheckState = CheckState.Unchecked;
        }

        private void cmdPrint_Click(object eventSender, EventArgs eventArgs)
        {
            Print_Renamed.PrintScreen(Bounds);
        }

        private void FormTwoBearings_Load(object eventSender, EventArgs eventArgs)
        {
            cboL1.SelectedIndex = 0; // g_LatN
            cboLo1.SelectedIndex = 0; // g_LongW
            cboL2.SelectedIndex = 0; // g_LatN
            cboLo2.SelectedIndex = 0; // g_LongW
        }

        private void FormTwoBearings_FormClosed(object eventSender, FormClosedEventArgs eventArgs)
        {
            // Cleanup()
        }

        private void cmdClearD_Click(object eventSender, EventArgs eventArgs)
        {
            DistanceTxtBx.Clear();
            txtCourse.Clear();
            txtBearing1.Clear();
            txtBearing2.Clear();
            txtDist.Clear();
            txtSpeed.Clear();
            txtTimeh.Clear();
            txtTimem.Clear();
            txtLog1.Clear();
            txtLog2.Clear();
            txtTime1.Clear();
            txtTime2.Clear();
        }

        private void optRel_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optRel.Checked)
            {
                cmdClearD_Click(cmdClearD, new EventArgs());
                lblVesselCourse.Visible = false;
                txtCourse.Visible = false;
                lblCourse.Visible = false;
                lblB1.Text = "° Relative (off the bow)";
                lblB2.Text = "° Relative (off the bow)";
            }
        }

        private void optTrue_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optTrue.Checked)
            {
                cmdClearD_Click(cmdClearD, new EventArgs());
                lblCourse.Text = "° True";
                lblVesselCourse.Visible = true;
                txtCourse.Visible = true;
                lblCourse.Visible = true;
                lblB1.Text = "° True";
                lblB2.Text = "° True";
            }
        }

        private void optMag_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optMag.Checked)
            {
                cmdClearD_Click(cmdClearD, new EventArgs());
                lblCourse.Text = "° Magnetic";
                lblVesselCourse.Visible = true;
                txtCourse.Visible = true;
                lblCourse.Visible = true;
                lblB1.Text = "° Magnetic";
                lblB2.Text = "° Magnetic";
            }
        }

        private void optComp_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optComp.Checked)
            {
                cmdClearD_Click(cmdClearD, new EventArgs());
                lblCourse.Text = "° Compass";
                lblVesselCourse.Visible = true;
                txtCourse.Visible = true;
                lblCourse.Visible = true;
                lblB1.Text = "° Compass";
                lblB2.Text = "° Compass";
            }
        }

        private void txtB1_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtB1.Text) > 359d)
            {
                txtB1.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtB1.Text) < 359d)
            {
                // txtDC.ForeColor = &H80000008
                txtB1.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtB1_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        private void txtB1_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtB1.Text) > 359d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtB1_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtB1;
            SelectAllText(ref argTB);
            txtB1 = argTB;
        }

        private void txtB2_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtB2.Text) > 359d)
            {
                txtB2.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtB2.Text) < 359d)
            {
                // txtDC.ForeColor = &H80000008
                txtB2.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtB2_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        private void txtB2_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtB2.Text) > 359d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtB2_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtB2;
            SelectAllText(ref argTB);
            txtB2 = argTB;
        }

        private void txtB3_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtB3.Text) > 359d)
            {
                txtB3.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtB3.Text) < 359d)
            {
                // txtDC.ForeColor = &H80000008
                txtB3.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtB3_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        private void txtB3_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtB3.Text) > 359d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtB3_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtB3;
            SelectAllText(ref argTB);
            txtB3 = argTB;
        }

        private void txtCourse_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtCourse.Text) > 359d)
            {
                txtCourse.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtCourse.Text) < 360d)
            {
                txtCourse.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtCourse_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            short KeyAscii = (short)Strings.Asc(eventArgs.KeyChar);
            ;
            // 'Static bPlusSignAlready As Boolean
            //bool bMinusSignAlready = false;
            //bool bPlusSignAlready = False;
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

        private void txtCourse_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtCourse.Text) > 359d)
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

        private void txtBearing1_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (optRel.Checked == true & Conversion.Val(txtBearing1.Text) > 90d | Conversion.Val(txtBearing1.Text) < 1d & !string.IsNullOrEmpty(txtBearing1.Text))
            {
                txtBearing1.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (optRel.Checked == true & Conversion.Val(txtBearing1.Text) < 91d & Conversion.Val(txtBearing1.Text) > 0d | string.IsNullOrEmpty(txtBearing1.Text))
            {
                txtBearing1.BackColor = Control.DefaultBackColor; 
            }

            if (optRel.Checked == false & Conversion.Val(txtBearing1.Text) > 359d)
            {
                txtBearing1.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (optRel.Checked == false & Conversion.Val(txtBearing1.Text) < 360d)
            {
                txtBearing1.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtBearing1_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            short KeyAscii = (short)Strings.Asc(eventArgs.KeyChar);
            ;
                bool bMinusSignAlready = false; 

            bMinusSignAlready = false;
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

        private void txtBearing1_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (optRel.Checked == true & Conversion.Val(txtBearing1.Text) > 90d | Conversion.Val(txtBearing1.Text) < 1d & !string.IsNullOrEmpty(txtBearing1.Text))
            {
                KeepFocus = true;
            }

            if (optRel.Checked == false & Conversion.Val(txtBearing1.Text) > 359d)
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
            if (optRel.Checked == true & Conversion.Val(txtBearing2.Text) > 90d | Conversion.Val(txtBearing2.Text) < 1d & !string.IsNullOrEmpty(txtBearing2.Text))
            {
                txtBearing2.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (optRel.Checked == true & Conversion.Val(txtBearing2.Text) < 91d & Conversion.Val(txtBearing2.Text) > 0d | string.IsNullOrEmpty(txtBearing2.Text))
            {
                txtBearing2.BackColor = Control.DefaultBackColor; 
            }

            if (optRel.Checked == false & Conversion.Val(txtBearing2.Text) > 359d)
            {
                txtBearing2.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (optRel.Checked == false & Conversion.Val(txtBearing2.Text) < 360d)
            {
                txtBearing2.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtBearing2_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            short KeyAscii = (short)Strings.Asc(eventArgs.KeyChar);
            ;
            // 'Static bPlusSignAlready As Boolean
            bool bMinusSignAlready = false;
            // bPlusSignAlready = False
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

        private void txtBearing2_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (optRel.Checked == true & Conversion.Val(txtBearing2.Text) > 90d | Conversion.Val(txtBearing2.Text) < 1d & !string.IsNullOrEmpty(txtBearing2.Text))
            {
                KeepFocus = true;
            }

            if (optRel.Checked == false & Conversion.Val(txtBearing2.Text) > 359d)
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

        private void txtI1_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtI1.Text) > 99999d)
            {
                txtI1.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtI1.Text) <= 99999d)
            {
                txtI1.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtI1_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        if (Conversions.ToBoolean(Strings.InStr(txtI1.Text, ".")))
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

        private void txtI1_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtI1.Text) > 99999d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtI1_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtI1;
            SelectAllText(ref argTB);
            txtI1 = argTB;
        }

        private void txtI2_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtI2.Text) > 99999d)
            {
                txtI2.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtI2.Text) <= 99999d)
            {
                txtI2.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtI2_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        if (Conversions.ToBoolean(Strings.InStr(txtI2.Text, ".")))
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

        private void txtI2_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtI2.Text) > 99999d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtI2_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtI2;
            SelectAllText(ref argTB);
            txtI2 = argTB;
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
                txtDist.BackColor = Control.DefaultBackColor; 
                txtLog1.Enabled = true;
                txtLog1.BackColor = Control.DefaultBackColor; 
                txtLog2.Enabled = true;
                txtLog2.BackColor = Control.DefaultBackColor; 
            }

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
                txtSpeed.BackColor = Control.DefaultBackColor; 
                txtTimeh.Enabled = true;
                txtTimeh.BackColor = Control.DefaultBackColor; 
                txtTimem.Enabled = true;
                txtTimem.BackColor = Control.DefaultBackColor; 
                txtLog1.Enabled = true;
                txtLog1.BackColor = Control.DefaultBackColor; 
                txtLog2.Enabled = true;
                txtLog2.BackColor = Control.DefaultBackColor; 
                txtTime1.Enabled = true;
                txtTime1.BackColor = Control.DefaultBackColor; 
                txtTime2.Enabled = true;
                txtTime2.BackColor = Control.DefaultBackColor; 
            }

            if (Conversion.Val(txtDist.Text) > 99.9d)
            {
                txtDist.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtDist.Text) <= 99.9d)
            {
                // txtDist.ForeColor = &H80000008
                txtDist.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtDist_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        if (Conversions.ToBoolean(Strings.InStr(txtDist.Text, ".")))
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

        private void txtDist_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtDist.Text) > 99.9d)
            {
                KeepFocus = true;
            }

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
                txtLog1.BackColor = Control.DefaultBackColor; 
                txtLog2.Enabled = true;
                txtLog2.BackColor = Control.DefaultBackColor; 
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
                txtSpeed.BackColor = Control.DefaultBackColor; 
                txtTimeh.Enabled = true;
                txtTimeh.BackColor = Control.DefaultBackColor; 
                txtTimem.Enabled = true;
                txtTimem.BackColor = Control.DefaultBackColor; 
                txtLog1.Enabled = true;
                txtLog1.BackColor = Control.DefaultBackColor; 
                txtLog2.Enabled = true;
                txtLog2.BackColor = Control.DefaultBackColor; 
                txtTime1.Enabled = true;
                txtTime1.BackColor = Control.DefaultBackColor; 
                txtTime2.Enabled = true;
                txtTime2.BackColor = Control.DefaultBackColor; 
                txtDist.Enabled = true;
                txtDist.BackColor = Control.DefaultBackColor; 
            }

            if (Conversion.Val(txtLog1.Text) > 9999.9d)
            {
                txtLog1.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtLog1.Text) <= 9999.9d)
            {
                // txtLog1.ForeColor = &H80000008
                txtLog1.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtLog1_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                txtLog1.BackColor = Control.DefaultBackColor; 
                txtLog2.Enabled = true;
                txtLog2.BackColor = Control.DefaultBackColor; 
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
                txtSpeed.BackColor = Control.DefaultBackColor; 
                txtTimeh.Enabled = true;
                txtTimeh.BackColor = Control.DefaultBackColor; 
                txtTimem.Enabled = true;
                txtTimem.BackColor = Control.DefaultBackColor; 
                txtLog1.Enabled = true;
                txtLog1.BackColor = Control.DefaultBackColor; 
                txtLog2.Enabled = true;
                txtLog2.BackColor = Control.DefaultBackColor; 
                txtTime1.Enabled = true;
                txtTime1.BackColor = Control.DefaultBackColor; 
                txtTime2.Enabled = true;
                txtTime2.BackColor = Control.DefaultBackColor; 
                txtDist.Enabled = true;
                txtDist.BackColor = Control.DefaultBackColor; 
            }

            if (Conversion.Val(txtLog2.Text) > 9999d)
            {
                txtLog2.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtLog2.Text) <= 9999.9d)
            {
                // txtLog2.ForeColor = &H80000008
                txtLog2.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtLog2_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                txtDist.BackColor = Control.DefaultBackColor; 
                txtTimeh.Enabled = true;
                txtTimeh.BackColor = Control.DefaultBackColor; 
                txtTimem.Enabled = true;
                txtTimem.BackColor = Control.DefaultBackColor; 
                txtLog1.Enabled = true;
                txtLog1.BackColor = Control.DefaultBackColor; 
                txtLog2.Enabled = true;
                txtLog2.BackColor = Control.DefaultBackColor; 
            }

            if (string.IsNullOrEmpty(txtTime1.Text) & string.IsNullOrEmpty(txtTime2.Text))
            {
                // If txtSpeed.Text = "" And txtTime1.Text = "" And txtTime1.Text = "" Then
                txtTimeh.Enabled = true;
                txtTimeh.BackColor = Control.DefaultBackColor; 
                txtTimem.Enabled = true;
                txtTimem.BackColor = Control.DefaultBackColor; 
            }
            // txtTime1.ForeColor = &H80000008
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
                txtDist.BackColor = Control.DefaultBackColor; 
                txtTimeh.Enabled = true;
                txtTimeh.BackColor = Control.DefaultBackColor; 
                txtTimem.Enabled = true;
                txtTimem.BackColor = Control.DefaultBackColor; 
                txtLog1.Enabled = true;
                txtLog1.BackColor = Control.DefaultBackColor; 
                txtLog2.Enabled = true;
                txtLog2.BackColor = Control.DefaultBackColor; 
            }

            if (string.IsNullOrEmpty(txtTime1.Text) & string.IsNullOrEmpty(txtTime2.Text))
            {
                // If txtSpeed.Text = "" And txtTime1.Text = "" And txtTime1.Text = "" Then
                txtTimeh.Enabled = true;
                txtTimeh.BackColor = Control.DefaultBackColor; 
                txtTimem.Enabled = true;
                txtTimem.BackColor = Control.DefaultBackColor; 
            }
            // txtTime2.ForeColor = &H80000008
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
                txtDist.BackColor = Control.DefaultBackColor; 
                txtLog1.Enabled = true;
                txtLog1.BackColor = Control.DefaultBackColor; 
                txtLog2.Enabled = true;
                txtLog2.BackColor = Control.DefaultBackColor; 
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
                txtTime1.BackColor = Control.DefaultBackColor; 
                txtTime1.Enabled = true;
                txtTime1.BackColor = Control.DefaultBackColor; 
                txtTime2.Enabled = true;
                txtTime2.BackColor = Control.DefaultBackColor; 
                txtTime2.Enabled = true;
                txtTime2.BackColor = Control.DefaultBackColor; 
            }

            return;
        }

        private void txtTimeh_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        // UPGRADE_WARNING: Event txtTimem.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
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
                txtDist.BackColor = Control.DefaultBackColor; 
                txtLog1.Enabled = true;
                txtLog1.BackColor = Control.DefaultBackColor; 
                txtLog2.Enabled = true;
                txtLog2.BackColor = Control.DefaultBackColor; 
                txtTime1.Enabled = true;
                txtTime1.BackColor = Control.DefaultBackColor; 
                txtTime1.Enabled = true;
                txtTime1.BackColor = Control.DefaultBackColor; 
                txtTime2.Enabled = true;
                txtTime2.BackColor = Control.DefaultBackColor; 
                txtTime2.Enabled = true;
                txtTime2.BackColor = Control.DefaultBackColor; 
            }

            if (Conversion.Val(txtTimeh.Text) != 0d)
                MaxTimem = 59;
            else
                MaxTimem = 99;
            if (Conversion.Val(txtTimem.Text) > MaxTimem)
            {
                txtTimem.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtTimem.Text) <= MaxTimem)
            {
                // txtTimem.ForeColor = &H80000008
                txtTimem.BackColor = Control.DefaultBackColor; 
            }

            if (Conversion.Val(txtTimem.Text) > 59d)
            {
                txtTimeh.Enabled = false;
                txtTimeh.BackColor = Color.Gray;
            }

            if (Conversion.Val(txtTimem.Text) <= 59d)
            {
                txtTimeh.Enabled = true;
                txtTimeh.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtTimem_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        private void cmdCalculateC_Click(object eventSender, EventArgs eventArgs)
        {
            // Is ARE INTERVALS - CAN BE TIME INTERVALS AT CONSTANT SPEED OR DISTANCES IF SPEED CHANGES
            Pi = 4d * Math.Atan(1.0d);
            B1 = (short)Conversion.Val(txtB1.Text);
            B2 = (short)Conversion.Val(txtB2.Text);
            B3 = (short)Conversion.Val(txtB3.Text);
            I1 = (float)Conversion.Val(txtI1.Text);
            I2 = (float)Conversion.Val(txtI2.Text);
            if (I1 == 0f | I2 == 0f)
            {
                ErrorMsgBox("Intervals cannot be zero or blank.");
                return;
            }

            if (B1 == B2 | B2 == B3 | B3 == B1)
            {
                ErrorMsgBox("Check data.  No two bearings can be the same.");
                return;
            }

            if (B1 > B2 & B2 < B3 & B3 < B1 | B1 < B2 & B2 > B3 & B3 < B1 | B1 > B2 & B2 < B3 & B3 > B1 | B1 < B2 & B2 > B3 & B3 > B1)
            {
                if (MessageBox.Show("Bearing values are not monotonically increasing or decreasing.  If correct (on both sides of 0º) press Yes.  If not, press No.", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly) == DialogResult.No)
                {
                    return;
                }
            }

            // Next four lines allow for bearings on both sides of zero
            if (B1 > B2 & B2 < B3 & B3 < B1)
            {
                B2 = (short)(B2 + 360);
                B3 = (short)(B3 + 360);
                goto Line100;
            }

            if (B1 < B2 & B2 > B3 & B3 < B1)
            {
                B3 = (short)(B3 + 360);
                goto Line100;
            }

            if (B1 > B2 & B2 < B3 & B3 > B1)
            {
                B1 = (short)(B1 + 360);
                B2 = (short)(B2 + 360);
                goto Line100;
            }

            if (B1 < B2 & B2 > B3 & B3 > B1)
            {
                B1 = (short)(B1 + 360);
            }

        Line100:
            ;
            Z = 1000d;
            for (C = 0; C <= 180; C++) // 360
            {
                x[C] = Math.Abs(I1 * Math.Sin((C - B1) * Pi / 180d) / Math.Sin((B1 - B2) * Pi / 180d) - I2 * Math.Sin((180 - C + B3) * Pi / 180d) / Math.Sin((B2 - B3) * Pi / 180d));
                if (C > 0)
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectLess(x[C], Z, false)))
                    {
                        Z = Conversions.ToDouble(x[C]);
                        Course1 = C;
                    }
                }
                // Debug.Print C, x(C)
            }
            // If course1 < 0 Then course1 = course1 + 360
            // If course1 = 360 Then course1 = course1 - 360

            Course2 = (short)(Course1 - 180);
            if (Course2 < 0)
                Course2 = (short)(Course2 + 360);
            if (Course2 >= 360)
                Course2 = (short)(Course2 - 360);
            if (B2 > B1)
                y = (short)(B2 - 90);
            if (B2 < B1)
                y = (short)(B2 + 90);
            if (y >= 360)
                y = (short)(y - 360);
            if (y < 0)
                y = (short)(y + 360);
            Course = Course1;

            // If Course2 - Val(txtDRCourse.Text) > Course1 - Val(txtDRCourse.Text) Then Course = Course1
            // If Abs(course2 - Val(txtDRCourse.Text)) < Abs(course1 - Val(txtDRCourse.Text)) Then Course = course2
            if (Math.Abs((short)(Course2 - y)) < Math.Abs((short)(Course1 - y)))
                Course = Course2;
            txtResultCourse.Clear();
            Label14.Visible = true;
            txtResultCourse.Visible = true;
            txtResultCourse.Text = Strings.Format(Course, "#000") + '°';
            return;
        }

        private void txtL1Deg_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtL1Deg.Text) != 90d)
            {
                txtL1Min.Enabled = true;
            }

            if (Conversion.Val(txtL1Deg.Text) == 90d)
            {
                txtL1Min.Text = "";
                txtL1Min.Enabled = false;
                txtL1Min.BackColor = Color.Gray;
            }

            txtL1Deg.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtL1Deg.Text) > 90d)
            {
                txtL1Deg.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtL1Deg.Text) < 90d)
            {
                txtL1Min.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtL1Deg_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        private void txtL1Deg_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtL1Deg.Text) > 90d)
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

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtL1Min_TextChanged(object eventSender, EventArgs eventArgs)
        {
            txtL1Min.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtL1Min.Text) > 59.9d)
            {
                txtL1Min.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }
        }

        private void txtL1Min_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                txtLo1Min.Enabled = true;
            if (Conversion.Val(txtLo1Deg.Text) == 180d)
            {
                txtLo1Min.Text = "";
                txtLo1Min.Enabled = false;
                txtLo1Min.BackColor = Color.Gray;
            }

            txtLo1Deg.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtLo1Deg.Text) > 180d | Conversion.Val(txtLo1Deg.Text) == 180d & Conversion.Val(txtLo1Min.Text) != 0d)
            {
                txtLo1Deg.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtLo1Deg.Text) < 180d)
            {
                txtLo1Min.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtLo1Deg_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
            txtLo1Min.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtLo1Min.Text) > 59.9d)
            {
                txtLo1Min.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }
        }

        private void txtLo1Min_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        private void txtL2Deg_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtL2Deg.Text) != 90d)
            {
                txtL2Min.Enabled = true;
            }

            if (Conversion.Val(txtL2Deg.Text) == 90d)
            {
                txtL2Min.Text = "";
                txtL2Min.Enabled = false;
                txtL2Min.BackColor = Color.Gray;
            }

            txtL2Deg.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtL2Deg.Text) > 90d)
            {
                txtL2Deg.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtL2Deg.Text) < 90d)
            {
                txtL2Min.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtL2Deg_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        private void txtL2Deg_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtL2Deg.Text) > 90d)
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
            txtL2Min.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtL2Min.Text) > 59.9d)
            {
                txtL2Min.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }
        }

        private void txtL2Min_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        if (Conversions.ToBoolean(Strings.InStr(txtL2Min.Text, ".")))
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

            txtLo2Deg.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtLo2Deg.Text) > 180d | Conversion.Val(txtLo2Deg.Text) == 180d & Conversion.Val(txtLo2Min.Text) != 0d)
            {
                txtLo2Deg.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtLo2Deg.Text) < 180d)
            {
                txtLo2Min.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtLo2Deg_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
            txtLo2Min.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtLo2Min.Text) > 59.9d)
            {
                txtLo2Min.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }
        }

        private void txtLo2Min_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        private void txtBg1_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtBg1.Text) > 359.9d)
            {
                txtBg1.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtBg1.Text) < 359.9d)
            {
                txtBg1.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtBg1_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        if (Conversions.ToBoolean(Strings.InStr(txtBg1.Text, ".")))
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

        private void txtBg1_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtBg1.Text) > 359.9d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtBg1_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtBg1;
            SelectAllText(ref argTB);
            txtBg1 = argTB;
        }

        private void txtBg2_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtBg2.Text) > 359.9d)
            {
                txtBg2.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtBg2.Text) < 359.9d)
            {
                txtBg2.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtBg2_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        if (Conversions.ToBoolean(Strings.InStr(txtBg2.Text, ".")))
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

        private void txtBg2_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtBg2.Text) > 359.9d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtBg2_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtBg2;
            SelectAllText(ref argTB);
            txtBg2 = argTB;
        }

        public void LatLong()
        {
            // Next four lines for problem with commas as decimal points in Europe with Favorite Places, etc.
            L1Min = Strings.Replace(txtL1Min.Text, ",", ".");
            Lo1Min = Strings.Replace(txtLo1Min.Text, ",", ".");
            L2Min = Strings.Replace(txtL2Min.Text, ",", ".");
            Lo2Min = Strings.Replace(txtLo2Min.Text, ",", ".");
            L1 = Conversion.Val(txtL1Deg.Text) + Conversion.Val(L1Min) / 60d;
            if (cboL1.Text == "S")
                L1 = -L1;
            Lo1 = Conversion.Val(txtLo1Deg.Text) + Conversion.Val(Lo1Min) / 60d;
            if (cboLo1.Text == "E")
                Lo1 = -Lo1;
            L2 = Conversion.Val(txtL2Deg.Text) + Conversion.Val(L2Min) / 60d;
            if (cboL2.Text == "S")
                L2 = -L2;
            Lo2 = Conversion.Val(txtLo2Deg.Text) + Conversion.Val(Lo2Min) / 60d;
            if (cboLo2.Text == "E")
                Lo2 = -Lo2;
        }

        public double Atan2(double y, double x)
        {
            double Atan2Ret = default;
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
            // 'If x = 0 And y = 0 Then ErrorMsgBox "Distance cannot be zero."

            // Type 3
            if (x > 0d)
            {
                Atan2Ret = Math.Atan(y / x);
            }
            else if (x < 0d)
            {
                Atan2Ret = Math.Sign(y) * (Pi - Math.Atan(Math.Abs(y / x)));
            }
            else if (y == 0d)
            {
                Atan2Ret = 0d;
            }
            else
            {
                Atan2Ret = Math.Sign(y) * Pi / 2d;
            }

            return Atan2Ret;
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