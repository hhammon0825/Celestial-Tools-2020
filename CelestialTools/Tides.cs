using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    internal partial class FormTides : Form
    {
        private double Pi;
        private short LocTimeHighMinutes, TimeHighMinutes, TimeLowMinutes, LocTimeLowMinutes;
        private short LocTimeHighMin, LocTimeHighHour, LocTimeLowHour, LocTimeLowMin;
        private double LocHtHigh, LocHtLow;
        private short TimeIntHighMinutes, DesTimeMinutes, TimeIntLowMinutes;
        private short TimeIntLowMin, TimeIntHighMin, TimeIntHighHour, TimeIntLowHour, DurationMinutes;
        private short DurationHour, DurationMin;
        private float Factor, Range, RangeDisplay, Correction;
        private short TimeDiff, i;
        private float DurationStep;
        private string fnumeral;
        public float TideHeight;
        public bool Flag;
        private bool FormTidesLoaded = false;

        private void cmdClear_Click(object eventSender, EventArgs eventArgs)
        {
            txtLocation.Clear();
            txtLocNo.Clear();
            DTTides.Value = DateAndTime.Now;
            DTTimeHigh.Value = DateAndTime.Now;
            DTTimeLow.Value = DateAndTime.Now;
            // txtDesTime.Clear()
            // cboDay.SelectedIndex = -1
            // cboMonth.SelectedIndex = -1
            // txtYear.Clear()
            txtRefSta.Clear();
            // txtTimeHigh.Clear()
            txtHtHigh.Clear();
            // txtTimeLow.Clear()
            txtHtLow.Clear();
            txtTab2Diff.Clear();
            txtSubStaNo.Clear();
            txtTab2HighHour.Clear();
            txtTab2HighMin.Clear();
            txtTab2HtHigh.Clear();
            txtTab2LowHour.Clear();
            txtTab2LowMin.Clear();
            txtTab2HtLow.Clear();
            Flag = false;
            ClearTextBoxes();
            return;
        }

        public void ClearTextBoxes()
        {
            Tides1Txt.Clear();
            Tides2Txt.Clear();
            Tides3Txt.Clear();
            Tides4Txt.Clear();
            Tides5Txt.Clear();
            Tides6Txt.Clear();
            Tides7Txt.Clear();
            Tides8Txt.Clear();
            Tides9Txt.Clear();
            Tides10Txt.Clear();
            Tides11Txt.Clear();
            Tides12Txt.Clear();
            Tides13Txt.Clear();
            return;
        }

        private void cmdPrint_Click(object eventSender, EventArgs eventArgs)
        {
            Print_Renamed.PrintScreen(Bounds);
        }

        private void cmdTides_Click(object eventSender, EventArgs eventArgs)
        {
            if (!FormTidesLoaded)
                return;
            Flag = true; // used to check if a tide height has been calculated for Vertical Clearances
            Pi = 4d * Math.Atan(1.0d);
            // CheckDate
            // If txtDesTime.Text = "" Then
            // ErrorMsgBox("You must enter a Desired Time.")
            // txtDesTime.Focus()
            // Exit Sub
            // End If


            TimeHighMinutes = (short)(DTTimeHigh.Value.Hour * 60 + DTTimeHigh.Value.Minute);
            TimeLowMinutes = (short)(DTTimeLow.Value.Hour * 60 + DTTimeLow.Value.Minute);
            // TimeHighMinutes = 60 * Val(VB.Left(txtTimeHigh.Text, 2)) + Val(VB.Right(txtTimeHigh.Text, 2))
            // TimeLowMinutes = 60 * Val(VB.Left(txtTimeLow.Text, 2)) + Val(VB.Right(txtTimeLow.Text, 2))
            if (Math.Abs((short)(TimeHighMinutes - TimeLowMinutes)) > 720)
            {
                if (TimeHighMinutes < TimeLowMinutes)
                    TimeHighMinutes = (short)(TimeHighMinutes + 1440);
                else
                    TimeLowMinutes = (short)(TimeLowMinutes + 1440);
            }

            if (string.IsNullOrEmpty(txtHtHigh.Text))
                txtHtHigh.Text = "0";
            if (txtHtHigh.Text == "-")
                txtHtHigh.Text = "-0";
            if (string.IsNullOrEmpty(txtHtLow.Text))
                txtHtLow.Text = "0";
            if (txtHtLow.Text == "-")
                txtHtLow.Text = "-0";
            if (txtTab2HighHour.Text == "-")
                txtTab2HighHour.Text = "-0";
            if (string.IsNullOrEmpty(txtTab2HighHour.Text))
                txtTab2HighHour.Text = "+0";
            if (string.IsNullOrEmpty(txtTab2HighMin.Text))
                txtTab2HighMin.Text = "0";
            if (string.IsNullOrEmpty(txtTab2HtHigh.Text))
                txtTab2HtHigh.Text = "0";
            if (txtTab2HtHigh.Text == "-")
                txtTab2HtHigh.Text = "-0";
            if (string.IsNullOrEmpty(txtTab2LowHour.Text))
                txtTab2LowHour.Text = "+0";
            if (txtTab2LowHour.Text == "-")
                txtTab2LowHour.Text = "-0";
            if (string.IsNullOrEmpty(txtTab2LowMin.Text))
                txtTab2LowMin.Text = "0";
            if (string.IsNullOrEmpty(txtTab2HtLow.Text))
                txtTab2HtLow.Text = "0";
            if (txtTab2HtLow.Text == "-")
                txtTab2HtLow.Text = "-0";
            LocTimeHighMinutes = (short)(TimeHighMinutes + (60d * Math.Abs(Conversion.Val(txtTab2HighHour.Text)) + Conversion.Val(txtTab2HighMin.Text)));
            if (Strings.Left(txtTab2HighHour.Text, 1) == "-")
                LocTimeHighMinutes = (short)(TimeHighMinutes - (60d * Math.Abs(Conversion.Val(txtTab2HighHour.Text)) + Conversion.Val(txtTab2HighMin.Text)));
            LocTimeHighHour = (short)Conversion.Int(LocTimeHighMinutes / 60d);
            LocTimeHighMin = (short)Conversion.Int(LocTimeHighMinutes - LocTimeHighHour * 60);
            LocTimeLowMinutes = (short)(TimeLowMinutes + (60d * Math.Abs(Conversion.Val(txtTab2LowHour.Text)) + Conversion.Val(txtTab2LowMin.Text)));
            if (Strings.Left(txtTab2LowHour.Text, 1) == "-")
                LocTimeLowMinutes = (short)(TimeLowMinutes - (60d * Math.Abs(Conversion.Val(txtTab2LowHour.Text)) + Conversion.Val(txtTab2LowMin.Text)));
            LocTimeLowHour = (short)Conversion.Int(LocTimeLowMinutes / 60d);
            LocTimeLowMin = (short)Conversion.Int(LocTimeLowMinutes - LocTimeLowHour * 60);
            LocHtHigh = Conversion.Val(txtHtHigh.Text) + Conversion.Val(txtTab2HtHigh.Text);
            if (Strings.Left(txtTab2HtHigh.Text, 1) == "*")
                LocHtHigh = Conversion.Val(txtHtHigh.Text) * Conversion.Val(Strings.Mid(txtTab2HtHigh.Text, 2));
            LocHtHigh = Conversion.Int(LocHtHigh * 10d + 0.5000000000001d) / 10d;
            LocHtLow = Conversion.Val(txtHtLow.Text) + Conversion.Val(txtTab2HtLow.Text);
            if (Strings.Left(txtTab2HtLow.Text, 1) == "*")
                LocHtLow = Conversion.Val(txtHtLow.Text) * Conversion.Val(Strings.Mid(txtTab2HtLow.Text, 2));
            LocHtLow = Conversion.Int(LocHtLow * 10d + 0.5000000000001d) / 10d;
            if (LocHtHigh <= LocHtLow)
            {
                ErrorMsgBox("Check the tide heights.");
                return;
            }

            DesTimeMinutes = (short)(DTTides.Value.Hour * 60 + DTTides.Value.Minute); // 60 * Val(VB.Left(txtDesTime.Text, 2)) + Val(VB.Right(txtDesTime.Text, 2))
            TimeIntHighMinutes = Math.Abs((short)(DesTimeMinutes - LocTimeHighMinutes));
            TimeIntLowMinutes = Math.Abs((short)(DesTimeMinutes - LocTimeLowMinutes));
            TimeIntHighHour = (short)Conversion.Int(TimeIntHighMinutes / 60d);
            TimeIntHighMin = (short)Conversion.Int(TimeIntHighMinutes - TimeIntHighHour * 60);
            TimeIntLowHour = (short)Conversion.Int(TimeIntLowMinutes / 60d);
            TimeIntLowMin = (short)Conversion.Int(TimeIntLowMinutes - TimeIntLowHour * 60);
            // If LocTimeLowMinutes <= LocTimeHighMinutes And (DesTimeMinutes < LocTimeLowMinutes Or DesTimeMinutes > LocTimeHighMinutes) Then  ErrorMsgBox ("Check the data."): Exit Sub
            // If LocTimeLowMinutes > LocTimeHighMinutes And (DesTimeMinutes > LocTimeLowMinutes Or DesTimeMinutes < LocTimeHighMinutes) Then  ErrorMsgBox ("Check the data."): Exit Sub
            // If DesTimeMinutes = LocTimeLowMinutes Or DesTimeMinutes = LocTimeHighMinutes Then  ErrorMsgBox ("Desired Time must be between Localized Time of High and Localized Time of Low."): Exit Sub

            DurationMinutes = (short)(TimeIntHighMinutes + TimeIntLowMinutes);
            if (DurationMinutes == 0)
            {
                ErrorMsgBox("Check the data.");
                return;
            }

            DurationHour = (short)Conversion.Int(DurationMinutes / 60d);
            DurationMin = (short)Conversion.Int(DurationMinutes - DurationHour * 60);
            if (optTable3.Checked == true)
            {
                if (DurationMin <= 9)
                    DurationMinutes = (short)(60 * DurationHour);
                if (DurationMin > 9 & DurationMin <= 29)
                    DurationMinutes = (short)(60 * DurationHour + 20);
                if (DurationMin > 29 & DurationMin <= 49)
                    DurationMinutes = (short)(60 * DurationHour + 40);
                if (DurationMin > 49)
                    DurationMinutes = (short)(60 * DurationHour + 60);
            }

            Range = (float)Math.Abs(LocHtHigh - LocHtLow);
            RangeDisplay = Range;
            if (optTable3.Checked == true)
                Range = (float)(Conversion.Int(2f * Range + 0.5d) / 2d);
            if (TimeIntHighMinutes > TimeIntLowMinutes)
                Factor = (float)Math.Abs((DesTimeMinutes - LocTimeLowMinutes) / (double)DurationMinutes);
            if (TimeIntHighMinutes <= TimeIntLowMinutes)
                Factor = (float)Math.Abs((DesTimeMinutes - LocTimeHighMinutes) / (double)DurationMinutes);
            if (optTable3.Checked == true)
            {
                Factor = Factor * 30f;
                Factor = (float)Conversion.Int(Factor + 0.5d);
                Factor = Factor / 30f;
            }

            Correction = (float)(Range / 2f * (1d - Math.Cos(Pi * Factor)));
            if (optRule.Checked == true)
            {
                if (LocTimeHighMinutes <= DesTimeMinutes)
                    TimeDiff = TimeIntHighMinutes;
                if (LocTimeLowMinutes < DesTimeMinutes)
                    TimeDiff = TimeIntLowMinutes;
                TimeDiff = (short)Conversion.Int(TimeDiff / 60d + 0.5d);
                if (TimeDiff == 0)
                    Factor = 0f;
                if (TimeDiff == 1)
                    Factor = 0.05f;
                if (TimeDiff == 2)
                    Factor = 0.25f;
                if (TimeDiff == 3)
                    Factor = 0.5f;
                if (TimeDiff == 4)
                    Factor = 0.75f;
                if (TimeDiff == 5)
                    Factor = 0.95f;
                if (TimeDiff == 6)
                    Factor = 1f;
                // Range = Int(Range + 0.5)
                Correction = Range * Factor;
            };
                float[] x= new float[6];
                float[] Diff = new float[6];

            ;
            // If optRule = True And Abs(DurationMinutes - 360) >= 60 Then
            if (optAltRule.Checked == true)
            {
                DurationStep = (float)(DurationMinutes / 6d);
                if (LocTimeHighMinutes <= DesTimeMinutes)
                    x[0] = LocTimeHighMinutes;
                if (LocTimeLowMinutes < DesTimeMinutes)
                    x[0] = LocTimeLowMinutes;
                Diff[0] = Math.Abs(x[0] - (float)DesTimeMinutes);
                for (i = 1; i <= 6; i++)
                {
                    x[i] = x[i - 1] + DurationStep;
                    Diff[i] = Math.Abs(x[(int)i] - (float)DesTimeMinutes);
                    if (Diff[i] > Diff[i - 1])
                        break;
                }

                i = (short)(i - 1);
                // TimeDiff = Int(TimeDiff / 60 + 0.5)
                if (i == 0)
                    Factor = 0f;
                if (i == 1)
                    Factor = 0.05f;
                if (i == 2)
                    Factor = 0.25f;
                if (i == 3)
                    Factor = 0.5f;
                if (i == 4)
                    Factor = 0.75f;
                if (i == 5)
                    Factor = 0.95f;
                if (i == 6)
                    Factor = 1f;
                // Range = Int(Range + 0.5)
                Correction = Range * Factor;
            }

            Correction = (float)(Conversion.Int(Correction * 10f + 0.500001d) / 10d);
            // TideHeight = Range / 2 * Cos(Pi * (DesTimeMinutes - LocTimeHighMinutes) / DurationMinutes) + (LocHtHigh + LocHtLow) / 2
            if (optCalc.Checked == true | optTable3.Checked == true)
            {
                if (TimeIntLowMinutes < TimeIntHighMinutes)
                    TideHeight = (float)(LocHtLow + Correction);
                if (TimeIntHighMinutes <= TimeIntLowMinutes)
                    TideHeight = (float)(LocHtHigh - Correction);
            }

            if (optRule.Checked == true | optAltRule.Checked == true)
            {
                if (LocTimeLowMinutes < DesTimeMinutes)
                    TideHeight = (float)(LocHtLow + Correction);
                if (LocTimeHighMinutes <= DesTimeMinutes)
                    TideHeight = (float)(LocHtHigh - Correction);
            }
            // Correction = TideHeight - LocHtLow
            TideHeight = (float)(Conversion.Int(TideHeight * 10f + 0.500001d) / 10d);
            // clear form text boxes for reporting data
            ClearTextBoxes();
            // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> format tides1txt, tides2txt, and tides3txt boxes <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

            if (LocTimeHighHour >= 24)
                LocTimeHighHour = (short)(LocTimeHighHour - 24);
            if (LocTimeLowHour >= 24)
                LocTimeLowHour = (short)(LocTimeLowHour - 24);
            Tides1Txt.AppendText("  Localized Data:  " + txtTab2Diff.Text);
            Tides2Txt.AppendText(Strings.Format(LocTimeHighHour, "00") + Strings.Format(LocTimeHighMin, "00") + Strings.Space(6));
            if (LocHtHigh < 0d)
                Tides2Txt.AppendText("-");
            if (LocHtHigh >= 0d)
                Tides2Txt.AppendText("+");
            Tides2Txt.AppendText(Strings.Format(Math.Abs(LocHtHigh), "0.0"));
            Tides3Txt.AppendText(Strings.Format(LocTimeLowHour, "00") + Strings.Format(LocTimeLowMin, "00") + Strings.Space(6));
            if (LocHtLow < 0d)
                Tides3Txt.AppendText("-");
            if (LocHtLow >= 0d)
                Tides3Txt.AppendText("+");
            Tides3Txt.AppendText(Strings.Format(Math.Abs(LocHtLow), "0.0"));
            // If LocTimeLowMinutes <= LocTimeHighMinutes And (DesTimeMinutes < LocTimeLowMinutes Or DesTimeMinutes > LocTimeHighMinutes) Then ErrorMsgBox("Check the data.  Desired Time must be between Localized Time of High and Localized Time of Low.") : Exit Sub
            // If LocTimeLowMinutes > LocTimeHighMinutes And (DesTimeMinutes > LocTimeLowMinutes Or DesTimeMinutes < LocTimeHighMinutes) Then ErrorMsgBox("Check the data.  Desired Time must be between Localized Time of High and Localized Time of Low.") : Exit Sub
            // If DesTimeMinutes = LocTimeLowMinutes Or DesTimeMinutes = LocTimeHighMinutes Then ErrorMsgBox("Check the data.  Desired Time must be between Localized Time of High and Localized Time of Low.") : Exit Sub
            // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> format tides4txt and tides5txt boxes <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

            var argTB = Tides4Txt;
            SetTxtBxBoldOn(ref argTB);
            Tides4Txt = argTB;
            Tides4Txt.AppendText("  Time Interval Between:");
            var argTB1 = Tides4Txt;
            SetTxtBxtoReg(ref argTB1);
            Tides4Txt = argTB1;
            if (optCalc.Checked == true | optTable3.Checked == true)
            {
                Tides4Txt.AppendText("(Use smaller of the two.)" + Constants.vbNewLine);
                Tides5Txt.AppendText("Time Interval" + Constants.vbNewLine);
            }
            else
            {
                Tides4Txt.AppendText(Constants.vbNewLine);
                Tides5Txt.AppendText(Constants.vbNewLine);
            }

            if (optCalc.Checked == true | optTable3.Checked == true)
            {
                Tides4Txt.AppendText("     Desired Time & Time of Local High Tide  ");
                if (TimeIntHighMinutes < TimeIntLowMinutes & optCalc.Checked == true | optTable3.Checked == true)
                {
                    var argTB2 = Tides4Txt;
                    SetTxtBxBoldOn(ref argTB2);
                    Tides4Txt = argTB2;
                }

                Tides4Txt.AppendText("DT~H");
                var argTB3 = Tides4Txt;
                SetTxtBxtoReg(ref argTB3);
                Tides4Txt = argTB3;
                Tides4Txt.AppendText(Constants.vbNewLine);
                Tides5Txt.AppendText(TimeIntHighHour.ToString() + " h " + Strings.Format(TimeIntHighMin, "00") + " m");
                Tides5Txt.AppendText(Constants.vbNewLine);
                Tides4Txt.AppendText("     Desired Time & Time of Local Low Tide  ");
                if (TimeIntHighMinutes > TimeIntLowMinutes)
                {
                    var argTB4 = Tides4Txt;
                    SetTxtBxBoldOn(ref argTB4);
                    Tides4Txt = argTB4;
                }

                Tides4Txt.AppendText("DT~L");
                var argTB5 = Tides4Txt;
                SetTxtBxtoReg(ref argTB5);
                Tides4Txt = argTB5;
                Tides4Txt.AppendText(Constants.vbNewLine);
                Tides5Txt.AppendText(TimeIntLowHour.ToString() + " h " + Strings.Format(TimeIntLowMin, "00") + " m");
                Tides5Txt.AppendText(Constants.vbNewLine);
            }

            if (optRule.Checked == true | optAltRule.Checked == true)
            {
                Tides4Txt.AppendText("     Desired Time & Time of preceding Local ");
                if (TimeIntHighMinutes <= TimeIntLowMinutes)
                {
                    var argTB6 = Tides4Txt;
                    SetTxtBxBoldOn(ref argTB6);
                    Tides4Txt = argTB6;
                }

                Tides4Txt.AppendText("High");
                var argTB7 = Tides4Txt;
                SetTxtBxtoReg(ref argTB7);
                Tides4Txt = argTB7;
                Tides4Txt.AppendText(" or ");
                if (TimeIntHighMinutes > TimeIntLowMinutes)
                {
                    var argTB8 = Tides4Txt;
                    SetTxtBxBoldOn(ref argTB8);
                    Tides4Txt = argTB8;
                }

                Tides4Txt.AppendText("Low");
                var argTB9 = Tides4Txt;
                SetTxtBxtoReg(ref argTB9);
                Tides4Txt = argTB9;
                Tides4Txt.AppendText(" Tide");
                Tides4Txt.AppendText(Constants.vbNewLine);
                if (TimeIntHighMinutes <= TimeIntLowMinutes)
                {
                    Tides5Txt.AppendText(TimeIntHighHour.ToString() + " h " + Strings.Format(TimeIntHighMin, "00") + " m");
                }

                if (TimeIntHighMinutes > TimeIntLowMinutes)
                {
                    Tides5Txt.AppendText(TimeIntLowHour.ToString() + " h " + Strings.Format(TimeIntLowMin, "00") + " m");
                }

                Tides5Txt.AppendText(Constants.vbNewLine);
                Tides4Txt.AppendText("     Time of Local High Tide & Time of Local Low Tide  ");
                Tides4Txt.AppendText(Constants.vbNewLine);
                Tides5Txt.AppendText(DurationHour.ToString() + " h " + Strings.Format(DurationMin, "00") + " m");
                Tides5Txt.AppendText(Constants.vbNewLine);
            }
            // >>>>>>>>>>>>>>>>>>>>>>>> format tides6txt and tides7txt boxes <<<<<<<<<<<<<<<<<<<<<<<<<<<<

            var argTB10 = Tides6Txt;
            SetTxtBxBoldOn(ref argTB10);
            Tides6Txt = argTB10;
            if (optTable3.Checked == true)
            {
                Tides6Txt.AppendText("  Entering Arguments for Table 3:");
            }

            if (optCalc.Checked == true)
            {
                Tides6Txt.AppendText("  Values for Calculation:");
            }

            var argTB11 = Tides6Txt;
            SetTxtBxtoReg(ref argTB11);
            Tides6Txt = argTB11;
            if (optCalc.Checked == true | optTable3.Checked == true)
            {
                Tides6Txt.AppendText("     Duration of ");
                if (LocTimeLowMinutes <= DesTimeMinutes)
                {
                    var argTB12 = Tides6Txt;
                    SetTxtBxBoldOn(ref argTB12);
                    Tides6Txt = argTB12;
                }

                Tides6Txt.AppendText("Rise (L-H)");
                var argTB13 = Tides6Txt;
                SetTxtBxtoReg(ref argTB13);
                Tides6Txt = argTB13;
                Tides6Txt.AppendText(" or ");
                if (LocTimeHighMinutes <= DesTimeMinutes)
                {
                    var argTB14 = Tides6Txt;
                    SetTxtBxBoldOn(ref argTB14);
                    Tides6Txt = argTB14;
                }

                Tides6Txt.AppendText("Fall (H-L)");
                var argTB15 = Tides6Txt;
                SetTxtBxtoReg(ref argTB15);
                Tides6Txt = argTB15;
                Tides6Txt.AppendText(Constants.vbNewLine);
                Tides7Txt.AppendText(DurationHour.ToString() + " h " + Strings.Format(DurationMin, "00") + " m");
                Tides7Txt.AppendText(Constants.vbNewLine);
                Tides6Txt.AppendText("     Time Interval of ");
                if (TimeIntHighMinutes <= TimeIntLowMinutes)
                {
                    var argTB16 = Tides6Txt;
                    SetTxtBxBoldOn(ref argTB16);
                    Tides6Txt = argTB16;
                }

                Tides6Txt.AppendText("H");
                var argTB17 = Tides6Txt;
                SetTxtBxtoReg(ref argTB17);
                Tides6Txt = argTB17;
                Tides6Txt.AppendText(" or ");
                if (TimeIntHighMinutes > TimeIntLowMinutes)
                {
                    var argTB18 = Tides6Txt;
                    SetTxtBxBoldOn(ref argTB18);
                    Tides6Txt = argTB18;
                }

                Tides6Txt.AppendText("L");
                var argTB19 = Tides6Txt;
                SetTxtBxtoReg(ref argTB19);
                Tides6Txt = argTB19;
                Tides6Txt.AppendText(" (whichever is closer)");
                Tides6Txt.AppendText(Constants.vbNewLine);
                if (TimeIntHighMinutes <= TimeIntLowMinutes)
                {
                    Tides7Txt.AppendText(TimeIntHighHour.ToString() + " h " + Strings.Format(TimeIntHighMin, "00") + " m");
                }

                if (TimeIntHighMinutes > TimeIntLowMinutes)
                {
                    Tides7Txt.AppendText(TimeIntLowHour.ToString() + " h " + Strings.Format(TimeIntLowMin, "00") + " m");
                }

                Tides7Txt.AppendText(Constants.vbNewLine);
            }

            if (optRule.Checked == true | optAltRule.Checked == true)
            {
                var argTB20 = Tides6Txt;
                SetTxtBxBoldOn(ref argTB20);
                Tides6Txt = argTB20;
                Tides6Txt.AppendText("  Values for Rule of Twelfths");
                if (optAltRule.Checked == true)
                {
                    Tides6Txt.AppendText(" (alternate)");
                }

                Tides6Txt.AppendText(":");
                var argTB21 = Tides6Txt;
                SetTxtBxtoReg(ref argTB21);
                Tides6Txt = argTB21;
                Tides6Txt.AppendText(Constants.vbNewLine);
                Tides6Txt.AppendText("     Time Interval from ");
                if (LocTimeHighMinutes < DesTimeMinutes)
                {
                    var argTB22 = Tides6Txt;
                    SetTxtBxBoldOn(ref argTB22);
                    Tides6Txt = argTB22;
                }

                Tides6Txt.AppendText("H");
                var argTB23 = Tides6Txt;
                SetTxtBxtoReg(ref argTB23);
                Tides6Txt = argTB23;
                Tides6Txt.AppendText(" or ");
                if (LocTimeLowMinutes < DesTimeMinutes)
                {
                    var argTB24 = Tides6Txt;
                    SetTxtBxBoldOn(ref argTB24);
                    Tides6Txt = argTB24;
                }

                Tides6Txt.AppendText("L");
                var argTB25 = Tides6Txt;
                SetTxtBxtoReg(ref argTB25);
                Tides6Txt = argTB25;
                Tides6Txt.AppendText(" (whichever precedes desired time)");
                Tides6Txt.AppendText(Constants.vbNewLine);
                // If LocTimeHighMinutes >= 1440 Then LocTimeHighMinutes = LocTimeHighMinutes - 1440
                // If LocTimeLowMinutes >= 1440 Then LocTimeLowMinutes = LocTimeLowMinutes - 1440

                if (LocTimeHighMinutes < DesTimeMinutes)
                {
                    Tides7Txt.AppendText(TimeIntHighHour.ToString() + " h " + Strings.Format(TimeIntHighMin, "00") + " m");
                }

                if (LocTimeLowMinutes < DesTimeMinutes)
                {
                    Tides6Txt.AppendText(TimeIntLowHour.ToString() + " h " + Strings.Format(TimeIntLowMin, "00") + " m");
                }

                Tides7Txt.AppendText(Constants.vbNewLine);
                Tides6Txt.AppendText("     Rounded Time Interval (as percent change)" + Constants.vbNewLine);
                Tides7Txt.AppendText((Factor * 100f).ToString() + "%" + Constants.vbNewLine);
            }

            Tides6Txt.AppendText("     Range of Tide at Local (Table 2) Substation");
            Tides7Txt.AppendText(Strings.Format(RangeDisplay, "0.0") + " ft");
            // >>>>>>>>>>>>>>>>>>>>>>>>> format tides8txt and tides9txt <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            Tides8Txt.AppendText("Height of Tide Correction from ");
            if (optTable3.Checked == true)
            {
                Tides8Txt.AppendText("Table 3");
            }

            if (optCalc.Checked == true)
            {
                Tides8Txt.AppendText("calculation");
            }

            if (optRule.Checked == true)
            {
                Tides8Txt.AppendText("Rule of Twelfths");
            }

            if (optAltRule.Checked == true)
            {
                Tides8Txt.AppendText("Rule of Twelfths (alternate)");
            }

            Tides9Txt.AppendText(Strings.Format(Correction, "0.0") + " ft");
            // >>>>>>>>>>>>>>>>>>> format tides10txt and tides11txt boxes <<<<<<<<<<<<<<<<<<<<<<
            var argTB26 = Tides10Txt;
            SetTxtBxBoldOn(ref argTB26);
            Tides10Txt = argTB26;
            if (optTable3.Checked == true)
            {
                Tides10Txt.AppendText("  Application of Table 3 Correction:");
            }

            if (optCalc.Checked == true)
            {
                Tides10Txt.AppendText("  Application of Calculated Correction:");
            }

            if (optRule.Checked == true | optAltRule.Checked == true)
            {
                Tides10Txt.AppendText("  Application of Rule of Twelfths Correction:");
            }

            var argTB27 = Tides6Txt;
            SetTxtBxtoReg(ref argTB27);
            Tides6Txt = argTB27;
            Tides10Txt.AppendText(Constants.vbNewLine);
            Tides11Txt.AppendText(Constants.vbNewLine);
            if (optCalc.Checked == true | optTable3.Checked == true)
            {
                Tides10Txt.AppendText("     Ht. of Tide at Local Substation:  ");
                if (TimeIntHighMinutes <= TimeIntLowMinutes)
                {
                    var argTB28 = Tides10Txt;
                    SetTxtBxBoldOn(ref argTB28);
                    Tides10Txt = argTB28;
                }

                Tides10Txt.AppendText("H");
                var argTB29 = Tides6Txt;
                SetTxtBxtoReg(ref argTB29);
                Tides6Txt = argTB29;
                Tides10Txt.AppendText(" or ");
                if (TimeIntHighMinutes > TimeIntLowMinutes)
                {
                    var argTB30 = Tides10Txt;
                    SetTxtBxBoldOn(ref argTB30);
                    Tides10Txt = argTB30;
                }

                Tides10Txt.AppendText("L");
                var argTB31 = Tides6Txt;
                SetTxtBxtoReg(ref argTB31);
                Tides6Txt = argTB31;
                Tides10Txt.AppendText(" whichever is closer in time.");
                Tides10Txt.AppendText(Constants.vbNewLine);
                if (TimeIntHighMinutes <= TimeIntLowMinutes)
                {
                    if (LocHtHigh < 0d)
                        Tides11Txt.AppendText("-");
                    if (LocHtHigh >= 0d)
                        Tides11Txt.AppendText("+");
                    Tides11Txt.AppendText(Strings.Format(Math.Abs(LocHtHigh), "0.0") + " ft");
                }

                if (TimeIntHighMinutes > TimeIntLowMinutes)
                {
                    if (LocHtLow < 0d)
                        Tides11Txt.AppendText("-");
                    if (LocHtLow >= 0d)
                        Tides11Txt.AppendText("+");
                    Tides11Txt.AppendText(Strings.Format(Math.Abs(LocHtLow), "0.0") + " ft");
                }

                Tides11Txt.AppendText(Constants.vbNewLine);
            }

            if (optRule.Checked == true | optAltRule.Checked == true)
            {
                Tides10Txt.AppendText("     Ht. of Tide at Local Substation:  ");
                if (LocTimeHighMinutes <= DesTimeMinutes)
                {
                    var argTB32 = Tides10Txt;
                    SetTxtBxBoldOn(ref argTB32);
                    Tides10Txt = argTB32;
                }

                Tides10Txt.AppendText("H");
                var argTB33 = Tides6Txt;
                SetTxtBxtoReg(ref argTB33);
                Tides6Txt = argTB33;
                Tides10Txt.AppendText(" or ");
                if (LocTimeLowMinutes < DesTimeMinutes)
                {
                    var argTB34 = Tides10Txt;
                    SetTxtBxBoldOn(ref argTB34);
                    Tides10Txt = argTB34;
                }

                Tides10Txt.AppendText("L");
                var argTB35 = Tides6Txt;
                SetTxtBxtoReg(ref argTB35);
                Tides6Txt = argTB35;
                Tides10Txt.AppendText(" whichever precedes desired time.");
                Tides10Txt.AppendText(Constants.vbNewLine);
                if (LocTimeHighMinutes <= DesTimeMinutes)
                {
                    if (LocHtHigh < 0d)
                    {
                        Tides11Txt.AppendText("-");
                    }

                    if (LocHtHigh >= 0d)
                    {
                        Tides11Txt.AppendText("+");
                    }

                    Tides11Txt.AppendText(Strings.Format(Math.Abs(LocHtHigh), "0.0") + " ft");
                }

                if (LocTimeLowMinutes < DesTimeMinutes)
                {
                    if (LocHtLow < 0d)
                    {
                        Tides11Txt.AppendText("-");
                    }

                    if (LocHtLow >= 0d)
                    {
                        Tides11Txt.AppendText("+");
                    }

                    Tides11Txt.AppendText(Strings.Format(Math.Abs(LocHtLow), "0.0") + " ft");
                }

                Tides11Txt.AppendText(Constants.vbNewLine);
            }

            if (optTable3.Checked == true)
            {
                Tides10Txt.AppendText("     Table 3 Correction:  ");
            }

            if (optCalc.Checked == true)
            {
                Tides10Txt.AppendText("     Calculated Correction:  ");
            }

            if (optRule.Checked == true | optAltRule.Checked == true)
            {
                Tides10Txt.AppendText("     Rule of Twelfths Correction:  ");
            }

            if (optCalc.Checked == true | optTable3.Checked == true)
            {
                if (TimeIntHighMinutes <= TimeIntLowMinutes)
                {
                    var argTB36 = Tides10Txt;
                    SetTxtBxBoldOn(ref argTB36);
                    Tides10Txt = argTB36;
                }

                Tides10Txt.AppendText(" Subtract from H");
                var argTB37 = Tides6Txt;
                SetTxtBxtoReg(ref argTB37);
                Tides6Txt = argTB37;
                Tides10Txt.AppendText(" or ");
                if (TimeIntHighMinutes > TimeIntLowMinutes)
                {
                    var argTB38 = Tides10Txt;
                    SetTxtBxBoldOn(ref argTB38);
                    Tides10Txt = argTB38;
                }

                Tides10Txt.AppendText("Add to L");
                var argTB39 = Tides6Txt;
                SetTxtBxtoReg(ref argTB39);
                Tides6Txt = argTB39;
                // Tides10Txt.AppendText(vbNewLine)

                if (TimeIntHighMinutes <= TimeIntLowMinutes)
                {
                    Tides11Txt.AppendText("-");
                }

                if (TimeIntHighMinutes > TimeIntLowMinutes)
                {
                    Tides11Txt.AppendText("+");
                }

                Tides11Txt.AppendText(Strings.Format(Math.Abs(Correction), "0.0") + " ft");
                // Tides11Txt.AppendText(vbNewLine)
            }

            if (optRule.Checked == true | optAltRule.Checked == true)
            {
                if (LocTimeHighMinutes <= DesTimeMinutes)
                {
                    var argTB40 = Tides10Txt;
                    SetTxtBxBoldOn(ref argTB40);
                    Tides10Txt = argTB40;
                }

                Tides10Txt.AppendText(" Subtract from H");
                var argTB41 = Tides6Txt;
                SetTxtBxtoReg(ref argTB41);
                Tides6Txt = argTB41;
                Tides10Txt.AppendText(" or ");
                if (LocTimeLowMinutes < DesTimeMinutes)
                {
                    var argTB42 = Tides10Txt;
                    SetTxtBxBoldOn(ref argTB42);
                    Tides10Txt = argTB42;
                }

                Tides10Txt.AppendText("Add to L");
                var argTB43 = Tides6Txt;
                SetTxtBxtoReg(ref argTB43);
                Tides6Txt = argTB43;
                if (LocTimeHighMinutes <= DesTimeMinutes)
                {
                    Tides11Txt.AppendText("-");
                }

                if (LocTimeLowMinutes < DesTimeMinutes)
                {
                    Tides11Txt.AppendText("+");
                }

                Tides11Txt.AppendText(Strings.Format(Math.Abs(Correction), "0.0") + " ft");
            }
            // >>>>>>>>>>>>>>>>>>>>>>>>>>>>> format tides12txt and tides13txt boxes <<<<<<<<<<<<<<<<<<<<<<<<<<<<<

            Tides12Txt.AppendText("Predicted Height of Tide at Desired Time at Local (Table 2) Substation");
            if (TideHeight < 0f)
                Tides13Txt.AppendText("-");
            if (TideHeight >= 0f)
                Tides13Txt.AppendText("+");
            Tides13Txt.AppendText(Strings.Format(Math.Abs(TideHeight), "0.0") + " ft");
        }

        private void cmdVertical_Click(object eventSender, EventArgs eventArgs)
        {
            if (Flag == true)
                My.MyProject.Forms.FormVertical.txtHeight.Text = Strings.Format(Conversion.Str(TideHeight), "0.0");
            else
                My.MyProject.Forms.FormVertical.txtHeight.Text = "";
            // FormVertical.cmdClear
            My.MyProject.Forms.FormVertical.Show();
        }

        private void FormTides_Load(object eventSender, EventArgs eventArgs)
        {
            Flag = false;
            if (My.MyProject.Computer.Network.IsAvailable)
            {
                LinkNOAATideCurr.Visible = true;
                LinkNOAATideCurr.Enabled = true;
            }
            else
            {
                LinkNOAATideCurr.Visible = false;
                LinkNOAATideCurr.Enabled = false;
            }

            DTTides.Value = DateAndTime.Now;
            FormTidesLoaded = true;
        }

        private void optAltRule_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optAltRule.Checked)
            {
                cmdTides_Click(cmdTides, new EventArgs());
            }
        }

        private void optCalc_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optCalc.Checked)
            {
                cmdTides_Click(cmdTides, new EventArgs());
            }
        }

        private void optRule_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optRule.Checked)
            {
                cmdTides_Click(cmdTides, new EventArgs());
            }
        }

        private void optTable3_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optTable3.Checked)
            {
                cmdTides_Click(cmdTides, new EventArgs());
            }
        }

        // Private Sub txtDesTime_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        // 'txtTime.ForeColor = &H80000008
        // txtDesTime.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        // If Len(txtDesTime.Text) = 4 And (Val(VB.Left(txtDesTime.Text, 2)) > 23 Or Val(Mid(txtDesTime.Text, 3, 2)) > 59) Then
        // txtDesTime.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
        // ErrorMsgBox("Out of Range")
        // Exit Sub
        // End If
        // End Sub

        // Private Sub txtDesTime_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
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

        // Private Sub txtDesTime_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs)
        // Dim KeepFocus As Boolean = eventArgs.Cancel
        // If Val(VB.Left(txtDesTime.Text, 2)) > 23 Or Val(Mid(txtDesTime.Text, 3, 2)) > 59 Or Len(txtDesTime.Text) <> 4 Then
        // KeepFocus = True
        // End If
        // If Len(txtDesTime.Text) = 0 Then
        // KeepFocus = False
        // End If
        // eventArgs.Cancel = KeepFocus
        // End Sub
        // Private Sub txtDesTime_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        // SelectAllText(txtDesTime)
        // End Sub

        private void txtLocation_TextChanged(object eventSender, EventArgs eventArgs)
        {
            txtTab2Diff.Text = txtLocation.Text;
        }

        private void txtLocation_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtLocation;
            SelectAllText(ref argTB);
            txtLocation = argTB;
        }

        private void txtLocNo_TextChanged(object eventSender, EventArgs eventArgs)
        {
            txtSubStaNo.Text = txtLocNo.Text;
        }

        private void txtLocNo_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        private void txtLocNo_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtLocNo;
            SelectAllText(ref argTB);
            txtLocNo = argTB;
        }

        private void txtRefSta_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtRefSta;
            SelectAllText(ref argTB);
            txtRefSta = argTB;
        }

        private void txtSubStaNo_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        // Private Sub txtTimeHigh_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        // 'txtTime.ForeColor = &H80000008
        // txtTimeHigh.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        // If Len(txtTimeHigh.Text) = 4 And (Val(VB.Left(txtTimeHigh.Text, 2)) > 23 Or Val(Mid(txtTimeHigh.Text, 3, 2)) > 59) Then
        // txtTimeHigh.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
        // ErrorMsgBox("Out of Range")
        // Exit Sub
        // End If
        // End Sub

        // Private Sub txtTimeHigh_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
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

        // Private Sub txtTimeHigh_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs)
        // Dim KeepFocus As Boolean = eventArgs.Cancel
        // If Val(VB.Left(txtTimeHigh.Text, 2)) > 23 Or Val(Mid(txtTimeHigh.Text, 3, 2)) > 59 Or Len(txtTimeHigh.Text) <> 4 Then
        // KeepFocus = True
        // End If
        // If Len(txtTimeHigh.Text) = 0 Then
        // KeepFocus = False
        // End If
        // eventArgs.Cancel = KeepFocus
        // End Sub
        // Private Sub txtTimeHigh_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        // SelectAllText(txtTimeHigh)
        // End Sub

        // Private Sub txtTimeLow_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        // 'txtTime.ForeColor = &H80000008
        // txtTimeLow.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        // If Len(txtTimeLow.Text) = 4 And (Val(VB.Left(txtTimeLow.Text, 2)) > 23 Or Val(Mid(txtTimeLow.Text, 3, 2)) > 59) Then
        // txtTimeLow.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
        // ErrorMsgBox("Out of Range")
        // Exit Sub
        // End If
        // End Sub

        // Private Sub txtTimeLow_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
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

        // Private Sub txtTimeLow_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs)
        // Dim KeepFocus As Boolean = eventArgs.Cancel
        // If Val(VB.Left(txtTimeLow.Text, 2)) > 23 Or Val(Mid(txtTimeLow.Text, 3, 2)) > 59 Or Len(txtTimeLow.Text) <> 4 Then
        // KeepFocus = True
        // End If
        // If Len(txtTimeLow.Text) = 0 Then
        // KeepFocus = False
        // End If
        // eventArgs.Cancel = KeepFocus
        // End Sub
        // Private Sub txtTimeLow_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        // SelectAllText(txtTimeLow)
        // End Sub

        private void txtTab2HighHour_TextChanged(object eventSender, EventArgs eventArgs)
        {
            // txtTime.ForeColor = &H80000008
            txtTab2HighHour.BackColor = Control.DefaultBackColor; 
        }

        private void txtTab2HighHour_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        if (txtTab2HighHour.SelectionStart != 0 | bMinusSignAlready)
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
                        if (txtTab2HighHour.SelectionStart != 0 | bPlusSignAlready)
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

        private void txtTab2HighHour_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            eventArgs.Cancel = KeepFocus;
        }

        private void txtTab2HighHour_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtTab2HighHour;
            SelectAllText(ref argTB);
            txtTab2HighHour = argTB;
        }

        private void txtTab2HighMin_TextChanged(object eventSender, EventArgs eventArgs)
        {
            // txtTime.ForeColor = &H80000008
            txtTab2HighMin.BackColor = Control.DefaultBackColor; 
            if (Strings.Len(txtTab2HighMin.Text) == 2 & Conversion.Val(txtTab2HighMin.Text) > 59d)
            {
                txtTab2HighMin.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }
        }

        private void txtTab2HighMin_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        private void txtTab2HighMin_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtTab2HighMin.Text) > 59d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtTab2HighMin_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtTab2HighMin;
            SelectAllText(ref argTB);
            txtTab2HighMin = argTB;
        }

        private void txtTab2LowHour_TextChanged(object eventSender, EventArgs eventArgs)
        {
            txtTab2LowHour.BackColor = Control.DefaultBackColor; 
        }

        private void txtTab2LowHour_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        if (txtTab2LowHour.SelectionStart != 0 | bMinusSignAlready)
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
                        if (txtTab2LowHour.SelectionStart != 0 | bPlusSignAlready)
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

        private void txtTab2LowHour_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            eventArgs.Cancel = KeepFocus;
        }

        private void txtTab2LowHour_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtTab2LowHour;
            SelectAllText(ref argTB);
            txtTab2LowHour = argTB;
        }

        private void txtTab2LowMin_TextChanged(object eventSender, EventArgs eventArgs)
        {
            // txtTime.ForeColor = &H80000008
            txtTab2LowMin.BackColor = Control.DefaultBackColor; 
            if (Strings.Len(txtTab2LowMin.Text) == 2 & Conversion.Val(txtTab2LowMin.Text) > 59d)
            {
                txtTab2LowMin.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }
        }

        private void txtTab2LowMin_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        private void txtTab2LowMin_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtTab2LowMin.Text) > 59d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtTab2LowMin_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtTab2LowMin;
            SelectAllText(ref argTB);
            txtTab2LowMin = argTB;
        }

        private void txtHtHigh_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        if (txtHtHigh.SelectionStart != 0 | bMinusSignAlready)
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
                        if (txtHtHigh.SelectionStart != 0 | bPlusSignAlready)
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
                        if (Conversions.ToBoolean(Strings.InStr(txtHtHigh.Text, ".")))
                        {
                            if (KeyAscii == 46)
                            {
                                KeyAscii = 0;
                                Interaction.Beep();
                            }
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

        private void DTTimeHigh_ValueChanged(object sender, EventArgs e)
        {
        }

        private void txtHtHigh_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            eventArgs.Cancel = KeepFocus;
        }

        private void LinkNOAATideCurr_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Dim URLNOAATideCurr As String = "https://oceanservice.noaa.gov/navigation/tidesandcurrents/"
            string URLNOAATideCurr = "https://tidesandcurrents.noaa.gov/tide_predictions.html";
            Process.Start(URLNOAATideCurr);
            return;
        }

        private void txtHtHigh_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtHtHigh;
            SelectAllText(ref argTB);
            txtHtHigh = argTB;
        }

        private void txtHtLow_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        if (txtHtLow.SelectionStart != 0 | bMinusSignAlready)
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
                        if (txtHtLow.SelectionStart != 0 | bPlusSignAlready)
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
                        if (Conversions.ToBoolean(Strings.InStr(txtHtLow.Text, ".")))
                        {
                            if (KeyAscii == 46)
                            {
                                KeyAscii = 0;
                                Interaction.Beep();
                            }
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

        private void txtHtLow_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            eventArgs.Cancel = KeepFocus;
        }

        private void txtHtLow_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtHtLow;
            SelectAllText(ref argTB);
            txtHtLow = argTB;
        }

        private void txtTab2HtHigh_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            short KeyAscii = (short)Strings.Asc(eventArgs.KeyChar);
            ;

            bool bMinusSignAlready = false;
            bool bPlusSignAlready = false;
            bool bAsteriskAlready = false;
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
                        if (txtTab2HtHigh.SelectionStart != 0 | bMinusSignAlready)
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
                        if (txtTab2HtHigh.SelectionStart != 0 | bPlusSignAlready)
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

                case (short)('*'):
                    {
                        if (txtTab2HtHigh.SelectionStart != 0 | bAsteriskAlready)
                        {
                            KeyAscii = 0;
                            Interaction.Beep();
                        }
                        else
                        {
                            bAsteriskAlready = true;
                        }

                        break;
                    }

                case (short)('.'): // only allows one decimal point
                    {
                        if (Conversions.ToBoolean(Strings.InStr(txtTab2HtHigh.Text, ".")))
                        {
                            if (KeyAscii == 46)
                            {
                                KeyAscii = 0;
                                Interaction.Beep();
                            }
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

        private void txtTab2HtHigh_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            eventArgs.Cancel = KeepFocus;
        }

        private void txtTab2HtHigh_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtTab2HtHigh;
            SelectAllText(ref argTB);
            txtTab2HtHigh = argTB;
        }

        private void txtTab2HtLow_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            short KeyAscii = (short)Strings.Asc(eventArgs.KeyChar);
            ;
            bool bMinusSignAlready = false;
            bool bPlusSignAlready = false;
            bool bAsteriskAlready = false;
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
                        if (txtTab2HtLow.SelectionStart != 0 | bMinusSignAlready)
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
                        if (txtTab2HtLow.SelectionStart != 0 | bPlusSignAlready)
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

                case (short)('*'):
                    {
                        if (txtTab2HtLow.SelectionStart != 0 | bAsteriskAlready)
                        {
                            KeyAscii = 0;
                            Interaction.Beep();
                        }
                        else
                        {
                            bAsteriskAlready = true;
                        }

                        break;
                    }

                case (short)('.'): // only allows one decimal point
                    {
                        if (Conversions.ToBoolean(Strings.InStr(txtTab2HtLow.Text, ".")))
                        {
                            if (KeyAscii == 46)
                            {
                                KeyAscii = 0;
                                Interaction.Beep();
                            }
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

        private void txtTab2HtLow_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            eventArgs.Cancel = KeepFocus;
        }

        private void txtTab2HtLow_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtTab2HtLow;
            SelectAllText(ref argTB);
            txtTab2HtLow = argTB;
        }

        private void FormTides_FormClosed(object eventSender, FormClosedEventArgs eventArgs)
        {
            // Cleanup()
        }

        // Private Sub txtYear_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
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
        // Private Sub txtYear_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        // SelectAllText(txtYear)
        // End Sub

        private void SelectAllText(ref TextBox TB)
        {
            TB.SelectionStart = 0;
            TB.SelectionLength = Strings.Len(TB.Text);
        }

        public void SetTxtBxUlineOn(ref RichTextBox TB)
        {
            TB.SelectionFont = new Font(TB.Font, FontStyle.Underline);
        }

        public void SetTxtBxBoldOn(ref RichTextBox TB)
        {
            TB.SelectionFont = new Font(TB.Font, FontStyle.Bold);
        }

        public void SetTxtBxtoReg(ref RichTextBox TB)
        {
            TB.SelectionFont = new Font(TB.Font, FontStyle.Regular);
        }

        private void ErrorMsgBox(string ErrMsg)
        {
            MessageBox.Show(ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            return;
        }
    }
}