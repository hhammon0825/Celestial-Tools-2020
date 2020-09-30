using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    internal partial class FormCurrents : Form
    {
        private double Pi;
        private short TimeFloodMinutes, TimeSlackBeforeFloodMinutes, TimeCount, TimeSlackBeforeEbbMinutes, TimeEbbMinutes;
        private short LocTimeFloodMinutes, LocTimeSlackBeforeFloodMinutes, LocTimeSlackBeforeEbbMinutes, LocTimeEbbMinutes;
        private short LocTimeSlackBeforeEbbHour, LocTimeSlackBeforeFloodHour, DesTimeMinutes, LocTimeSlackBeforeFloodMin, LocTimeSlackBeforeEbbMin;
        private short LocTimeEbbHour, LocTimeFloodHour, LocTimeFloodMin, LocTimeEbbMin;
        private float LocVelFlood, LocVelEbb;
        private short Check3, Check1, CheckCount, Check2, Check4;
        private short TimeIntSlackMaxMinutes, SelectSlack, SelectMax, TimeIntSlackDesMinutes;
        private short TimeIntSlackDesHour, TimeIntSlackMaxHour, TimeIntSlackMaxMin, TimeIntSlackDesMin;
        private short TimeIntDesEbb, TimeIntDesFlood, i;
        private double Ratio, Factor;
        private float DurationStep;
        private float Drift;
        private string fnumeral;
        private short X3Hour, X2Hour, X1Hour, X0Hour, IntMin, X0Min, X1Min, X2Min, X3Min;
        private short SelectMaxHour, SelectSlackHour, SelectSlackMin, SelectMaxMin;
        private string Time2, Time0, Time1, Time3;
        private bool FormCurrentsLoaded = false;
        private DateTime DTTemp = new DateTime(1901, 1, 1, 0, 0, 0);

        private void chkE_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            if ((int)chkE.CheckState == 1)
                chkF.Enabled = false;
            if (chkF.CheckState == 0 & chkE.CheckState == 0)
            {
                chkF.Enabled = true;
                chkE.Enabled = true;
            }

            if (chkE.CheckState == 0)
                CheckDisable();
        }

        private void chkF_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            if ((int)chkF.CheckState == 1)
                chkE.Enabled = false;
            if (chkF.CheckState == 0 & chkE.CheckState == 0)
            {
                chkF.Enabled = true;
                chkE.Enabled = true;
            }

            if (chkF.CheckState == 0)
                CheckDisable();
        }

        private void chkSBE_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            if ((int)chkSBE.CheckState == 1)
                chkSBF.Enabled = false;
            if (chkSBF.CheckState == 0 & chkSBE.CheckState == 0)
            {
                chkSBF.Enabled = true;
                chkSBE.Enabled = true;
            }

            if (chkSBE.CheckState == 0)
                CheckDisable();
        }

        private void chkSBF_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            if ((int)chkSBF.CheckState == 1)
                chkSBE.Enabled = false;
            if (chkSBF.CheckState == 0 & chkSBE.CheckState == 0)
            {
                chkSBF.Enabled = true;
                chkSBE.Enabled = true;
            }

            if (chkSBF.CheckState == 0)
                CheckDisable();
        }

        private void CheckDisable()
        {
            if (DTTimeSlackBeforeFlood.Value.Hour == 0 & DTTimeSlackBeforeFlood.Value.Minute == 0)
            {
                chkSBF.Enabled = false;
                chkSBF.CheckState = CheckState.Unchecked;
            }

            if (DTTimeFlood.Value.Hour == 0 & DTTimeFlood.Value.Minute == 0)
            {
                chkF.Enabled = false;
                chkF.CheckState = CheckState.Unchecked;
            }

            if (DTTimeSlackBeforeEbb.Value.Hour == 0 & DTTimeSlackBeforeEbb.Value.Minute == 0)
            {
                chkSBE.Enabled = false;
                chkSBE.CheckState = CheckState.Unchecked;
            }

            if (DTTimeEbb.Value.Hour == 0 & DTTimeEbb.Value.Minute == 0)
            {
                chkE.Enabled = false;
                chkE.CheckState = CheckState.Unchecked;
            }
        }

        private void cmdClear_Click(object eventSender, EventArgs eventArgs)
        {
            txtLocation.Clear();
            txtLocNo.Clear();
            DTTides.Value = DateAndTime.Now;
            DTTimeSlackBeforeFlood.Value = DTTemp;
            DTTimeFlood.Value = DTTemp;
            DTTimeSlackBeforeEbb.Value = DTTemp;
            DTTimeEbb.Value = DTTemp;
            // txtDesTime.Clear()
            // cboDay.SelectedIndex = -1
            // cboMonth.SelectedIndex = -1
            // txtYear.Clear()
            txtRefSta.Clear();
            // txtTimeSlackBeforeFlood.Clear()
            // txtTimeFlood.Clear()
            txtVelFlood.Clear();
            // txtTimeSlackBeforeEbb.Clear()
            // txtTimeEbb.Clear()
            txtVelEbb.Clear();
            txtTab2SlackFHour.Clear();
            txtTab2SlackFMin.Clear();
            txtTab2SlackEHour.Clear();
            txtTab2SlackEMin.Clear();
            txtTab2FloodHour.Clear();
            txtTab2FloodMin.Clear();
            txtTab2FloodMult.Clear();
            txtTab2EbbHour.Clear();
            txtTab2EbbMin.Clear();
            txtTab2EbbMult.Clear();
            txtSubStaNo.Clear();
            txtSetFlood.Clear();
            txtSetEbb.Clear();
            chkSBF.CheckState = CheckState.Unchecked;
            chkF.CheckState = CheckState.Unchecked;
            chkSBE.CheckState = CheckState.Unchecked;
            chkE.CheckState = CheckState.Unchecked;
            ClearRptTextBox();
        }

        public void ClearRptTextBox()
        {
            Curr1Txtbx.Clear();
            Curr2TxtBx.Clear();
            Curr3TxtBx.Clear();
            Curr4TxtBx.Clear();
            Curr5TxtBx.Clear();
            Curr6TxtBx.Clear();
            Curr7TxtBx.Clear();
            Curr8TxtBx.Clear();
            Curr10TxtBx.Clear();
            Curr11TxtBx.Clear();
            Curr12TxtBx.Clear();
            Curr13TxtBx.Clear();
            Curr14TxtBx.Clear();
            Curr15TxtBx.Clear();
            Curr16TxtBx.Clear();
            Curr17TxtBx.Clear();
            Curr18TxtBx.Clear();
            Curr19TxtBx.Clear();
            Curr20TxtBx.Clear();
            return;
        }

        private void cmdPrint_Click(object eventSender, EventArgs eventArgs)
        {
            Print_Renamed.PrintScreen(Bounds);
        }

        private void cmdCurrents_Click(object eventSender, EventArgs eventArgs)
        {
            if (!FormCurrentsLoaded)
                return;
            Pi = 4d * Math.Atan(1.0d);
            chkSBF.Enabled = false;
            chkSBE.Enabled = false;
            chkF.Enabled = false;
            chkE.Enabled = false;
            chkSBF.CheckState = CheckState.Unchecked;
            chkSBE.CheckState = CheckState.Unchecked;
            chkF.CheckState = CheckState.Unchecked;
            chkE.CheckState = CheckState.Unchecked;
            // CheckDate
            TimeCount = 0;
            // If txtDesTime.Text = "" Then
            // ErrorMsgBox("You must enter a Desired Time.")
            // txtDesTime.Focus()
            // Exit Sub
            // End If

            if (DTTimeSlackBeforeFlood.Value.Hour != 0 | DTTimeSlackBeforeFlood.Value.Minute != 0)
            {
                TimeCount = (short)(TimeCount + 1); // ErrorMsgBox ("You must enter a time of high tide."): txtTimeHigh.SetFocus: Exit Sub
            }

            if (DTTimeFlood.Value.Hour != 0 | DTTimeFlood.Value.Minute != 0)
            {
                TimeCount = (short)(TimeCount + 1); // ErrorMsgBox ("You must enter a time of low tide."): txtTimeLow.SetFocus: Exit Sub
            }

            if (DTTimeSlackBeforeEbb.Value.Hour != 0 | DTTimeSlackBeforeEbb.Value.Minute != 0)
            {
                TimeCount = (short)(TimeCount + 1); // ErrorMsgBox ("You must enter a time of high tide."): txtTimeHigh.SetFocus: Exit Sub
            }

            if (DTTimeEbb.Value.Hour != 0 | DTTimeEbb.Value.Minute != 0)
            {
                TimeCount = (short)(TimeCount + 1); // ErrorMsgBox ("You must enter a time of low tide."): txtTimeLow.SetFocus: Exit Sub
            }

            if (TimeCount < 2)
            {
                ErrorMsgBox("You must have at least one slack time and at least one flood or ebb time entered.");
                return;
            }

            // If txtVelFlood = "" Then  ErrorMsgBox ("Max. Flood Velocity cannot be blank or zero."): Exit Sub
            // If txtVelEbb = "" Then  ErrorMsgBox ("Max. Ebb Velocity cannot be blank or zero."): Exit Sub
            if (string.IsNullOrEmpty(txtVelFlood.Text) & string.IsNullOrEmpty(txtVelEbb.Text))
            {
                ErrorMsgBox("At least one of the Flood or Ebb Velocities must be greater than zero.");
                return;
            }

            if (txtTab2SlackFHour.Text == "-")
                txtTab2SlackFHour.Text = "-0";
            if (string.IsNullOrEmpty(txtTab2SlackFHour.Text))
                txtTab2SlackFHour.Text = "+0";
            if (string.IsNullOrEmpty(txtTab2SlackFMin.Text))
                txtTab2SlackFHour.Text = "0";
            if (txtTab2FloodHour.Text == "-")
                txtTab2FloodHour.Text = "-0";
            if (string.IsNullOrEmpty(txtTab2FloodHour.Text))
                txtTab2FloodHour.Text = "+0";
            if (string.IsNullOrEmpty(txtTab2FloodMin.Text))
                txtTab2FloodHour.Text = "0";
            if (string.IsNullOrEmpty(txtTab2FloodMult.Text))
                txtTab2FloodMult.Text = "1";
            if (txtTab2SlackEHour.Text == "-")
                txtTab2SlackEHour.Text = "-0";
            if (string.IsNullOrEmpty(txtTab2SlackEHour.Text))
                txtTab2SlackEHour.Text = "+0";
            if (string.IsNullOrEmpty(txtTab2SlackEMin.Text))
                txtTab2SlackEHour.Text = "0";
            if (txtTab2EbbHour.Text == "-")
                txtTab2EbbHour.Text = "-0";
            if (string.IsNullOrEmpty(txtTab2EbbHour.Text))
                txtTab2EbbHour.Text = "+0";
            if (string.IsNullOrEmpty(txtTab2EbbMin.Text))
                txtTab2EbbHour.Text = "0";
            if (string.IsNullOrEmpty(txtTab2EbbMult.Text))
                txtTab2EbbMult.Text = "1";
            TimeSlackBeforeFloodMinutes = (short)(60 * DTTimeSlackBeforeFlood.Value.Hour + DTTimeSlackBeforeFlood.Value.Minute);
            TimeSlackBeforeEbbMinutes = (short)(60 * DTTimeSlackBeforeEbb.Value.Hour + DTTimeSlackBeforeEbb.Value.Minute);
            TimeFloodMinutes = (short)(60 * DTTimeFlood.Value.Hour + DTTimeFlood.Value.Minute);
            TimeEbbMinutes = (short)(60 * DTTimeEbb.Value.Hour + DTTimeEbb.Value.Minute);
            // If Abs(TimeHighMinutes - TimeLowMinutes) > 720 Then
            // If TimeHighMinutes < TimeLowMinutes Then TimeHighMinutes = TimeHighMinutes + 1440
            // If TimeLowMinutes < TimeHighMinutes Then TimeLowMinutes = TimeLowMinutes + 1440
            // End If

            LocTimeSlackBeforeFloodMinutes = (short)(TimeSlackBeforeFloodMinutes + (60d * Math.Abs(Conversion.Val(txtTab2SlackFHour.Text)) + Conversion.Val(txtTab2SlackFMin.Text)));
            if (Strings.Left(txtTab2SlackFHour.Text, 1) == "-")
            {
                LocTimeSlackBeforeFloodMinutes = (short)(60 * DTTimeSlackBeforeFlood.Value.Hour + DTTimeSlackBeforeFlood.Value.Minute - (60d * Conversion.Val(Math.Abs(Conversions.ToDouble(txtTab2SlackFHour.Text)).ToString()) + Conversion.Val(txtTab2SlackFMin.Text)));
            }

            if (LocTimeSlackBeforeFloodMinutes >= 1440)
            {
                LocTimeSlackBeforeFloodMinutes = (short)(LocTimeSlackBeforeFloodMinutes - 1440);
            }

            if (LocTimeSlackBeforeFloodMinutes < 0)
            {
                LocTimeSlackBeforeFloodMinutes = (short)(LocTimeSlackBeforeFloodMinutes + 1440);
            }

            LocTimeSlackBeforeEbbMinutes = (short)(TimeSlackBeforeEbbMinutes + (60d * Math.Abs(Conversion.Val(txtTab2SlackEHour.Text)) + Conversion.Val(txtTab2SlackEMin.Text)));
            if (Strings.Left(txtTab2SlackEHour.Text, 1) == "-")
            {
                LocTimeSlackBeforeEbbMinutes = (short)(60 * DTTimeSlackBeforeEbb.Value.Hour + DTTimeSlackBeforeEbb.Value.Minute - (60d * Conversion.Val(Math.Abs(Conversions.ToDouble(txtTab2SlackEHour.Text)).ToString()) + Conversion.Val(txtTab2SlackEMin.Text)));
            }

            if (LocTimeSlackBeforeEbbMinutes >= 1440)
            {
                LocTimeSlackBeforeEbbMinutes = (short)(LocTimeSlackBeforeEbbMinutes - 1440);
            }

            if (LocTimeSlackBeforeEbbMinutes < 0)
            {
                LocTimeSlackBeforeEbbMinutes = (short)(LocTimeSlackBeforeEbbMinutes + 1440);
            }

            LocTimeFloodMinutes = (short)(TimeFloodMinutes + (60d * Math.Abs(Conversion.Val(txtTab2FloodHour.Text)) + Conversion.Val(txtTab2FloodMin.Text)));
            if (Strings.Left(txtTab2FloodHour.Text, 1) == "-")
            {
                LocTimeFloodMinutes = (short)(60 * DTTimeFlood.Value.Hour + DTTimeFlood.Value.Minute - (60d * Conversion.Val(Math.Abs(Conversions.ToDouble(txtTab2FloodHour.Text)).ToString()) + Conversion.Val(txtTab2FloodMin.Text)));
            }

            if (LocTimeFloodMinutes >= 1440)
            {
                LocTimeFloodMinutes = (short)(LocTimeFloodMinutes - 1440);
            }

            if (LocTimeFloodMinutes < 0)
            {
                LocTimeFloodMinutes = (short)(LocTimeFloodMinutes + 1440);
            }

            LocTimeEbbMinutes = (short)(TimeEbbMinutes + (60d * Math.Abs(Conversion.Val(txtTab2EbbHour.Text)) + Conversion.Val(txtTab2EbbMin.Text)));
            if (Strings.Left(txtTab2EbbHour.Text, 1) == "-")
            {
                LocTimeEbbMinutes = (short)(60 * DTTimeEbb.Value.Hour + DTTimeEbb.Value.Minute - (60d * Conversion.Val(Math.Abs(Conversions.ToDouble(txtTab2EbbHour.Text)).ToString()) + Conversion.Val(txtTab2EbbMin.Text)));
            }

            if (LocTimeEbbMinutes >= 1440)
            {
                LocTimeEbbMinutes = (short)(LocTimeEbbMinutes - 1440);
            }

            if (LocTimeEbbMinutes < 0)
            {
                LocTimeEbbMinutes = (short)(LocTimeEbbMinutes + 1440);
            }

            DesTimeMinutes = (short)(60 * DTTides.Value.Day + DTTides.Value.Minute);
            LocTimeSlackBeforeFloodHour = (short)Conversion.Int(LocTimeSlackBeforeFloodMinutes / 60d);
            LocTimeSlackBeforeFloodMin = (short)Conversion.Int(LocTimeSlackBeforeFloodMinutes - LocTimeSlackBeforeFloodHour * 60);
            LocTimeSlackBeforeEbbHour = (short)Conversion.Int(LocTimeSlackBeforeEbbMinutes / 60d);
            LocTimeSlackBeforeEbbMin = (short)Conversion.Int(LocTimeSlackBeforeEbbMinutes - LocTimeSlackBeforeEbbHour * 60);
            LocTimeFloodHour = (short)Conversion.Int(LocTimeFloodMinutes / 60d);
            LocTimeFloodMin = (short)Conversion.Int(LocTimeFloodMinutes - LocTimeFloodHour * 60);
            LocTimeEbbHour = (short)Conversion.Int(LocTimeEbbMinutes / 60d);
            LocTimeEbbMin = (short)Conversion.Int(LocTimeEbbMinutes - LocTimeEbbHour * 60);
            LocVelFlood = (float)(Conversion.Val(txtVelFlood.Text) * Conversion.Val(txtTab2FloodMult.Text));
            if (optRule.Checked == true)
            {
                LocVelFlood = (float)(Conversion.Int(LocVelFlood * 10f + 0.5d) / 10d);
            }
            else
            {
                LocVelFlood = (float)(Conversion.Int(LocVelFlood * 100f + 0.5d) / 100d);
            }

            LocVelEbb = (float)(Conversion.Val(txtVelEbb.Text) * Conversion.Val(txtTab2EbbMult.Text));
            if (optRule.Checked == true)
            {
                LocVelEbb = (float)(Conversion.Int(LocVelEbb * 10f + 0.5d) / 10d);
            }
            else
            {
                LocVelEbb = (float)(Conversion.Int(LocVelEbb * 100f + 0.5d) / 100d);
            }

            chkSBF.Visible = true;
            chkF.Visible = true;
            chkSBE.Visible = true;
            chkE.Visible = true;
            if (LocTimeSlackBeforeFloodHour >= 24)
                LocTimeSlackBeforeFloodHour = (short)(LocTimeSlackBeforeFloodHour - 24);
            if (LocTimeSlackBeforeEbbHour >= 24)
                LocTimeSlackBeforeEbbHour = (short)(LocTimeSlackBeforeEbbHour - 24);
            if (LocTimeFloodHour >= 24)
                LocTimeFloodHour = (short)(LocTimeFloodHour - 24);
            if (LocTimeEbbHour >= 24)
                LocTimeEbbHour = (short)(LocTimeEbbHour - 24);
            ClearRptTextBox();
            DisplayLocalizedData();
            CheckCount = 0;
            if (DTTimeSlackBeforeFlood.Value.Hour != 0 | DTTimeSlackBeforeFlood.Value.Minute != 0)
            {
                chkSBF.Enabled = true;
                CheckCount = (short)(CheckCount + 1);
            }

            if (DTTimeFlood.Value.Hour != 0 | DTTimeFlood.Value.Minute != 0)
            {
                chkF.Enabled = true;
                CheckCount = (short)(CheckCount + 1);
            }

            if (DTTimeSlackBeforeEbb.Value.Hour != 0 | DTTimeSlackBeforeEbb.Value.Minute != 0)
            {
                chkSBE.Enabled = true;
                CheckCount = (short)(CheckCount + 1);
            }

            if (DTTimeEbb.Value.Hour != 0 | DTTimeEbb.Value.Minute != 0)
            {
                chkE.Enabled = true;
                CheckCount = (short)(CheckCount + 1);
            }
            // If txtTimeSlackBeforeFlood.Text <> "" Then chkSBF.Enabled = True : CheckCount = CheckCount + 1
            // If txtTimeFlood.Text <> "" Then chkF.Enabled = True : CheckCount = CheckCount + 1
            // If txtTimeSlackBeforeEbb.Text <> "" Then chkSBE.Enabled = True : CheckCount = CheckCount + 1
            // If txtTimeEbb.Text <> "" Then chkE.Enabled = True : CheckCount = CheckCount + 1

            if (CheckCount == 2)
            {
                if (chkSBF.Enabled == true)
                    chkSBF.CheckState = CheckState.Checked;
                if (chkF.Enabled == true)
                    chkF.CheckState = CheckState.Checked;
                if (chkSBE.Enabled == true)
                    chkSBE.CheckState = CheckState.Checked;
                if (chkE.Enabled == true)
                    chkE.CheckState = CheckState.Checked;
            }


            // CONTINUE

            CheckCount = 0;
            Check1 = 1;
            Check2 = 1;
            Check3 = 1;
            Check4 = 1;
            while (CheckCount < 2)
            {
                Application.DoEvents();
                if ((int)chkSBF.CheckState == 1 & Check1 == 1)
                {
                    CheckCount = (short)(CheckCount + 1);
                    Check1 = 0;
                }

                if ((int)chkSBE.CheckState == 1 & Check2 == 1)
                {
                    CheckCount = (short)(CheckCount + 1);
                    Check2 = 0;
                }

                if ((int)chkF.CheckState == 1 & Check3 == 1)
                {
                    CheckCount = (short)(CheckCount + 1);
                    Check3 = 0;
                }

                if ((int)chkE.CheckState == 1 & Check4 == 1)
                {
                    CheckCount = (short)(CheckCount + 1);
                    Check4 = 0;
                }
            }

            if ((int)chkSBF.CheckState == 1)
                SelectSlack = LocTimeSlackBeforeFloodMinutes;
            if ((int)chkSBE.CheckState == 1)
                SelectSlack = LocTimeSlackBeforeEbbMinutes;
            if ((int)chkF.CheckState == 1)
                SelectMax = LocTimeFloodMinutes;
            if ((int)chkE.CheckState == 1)
                SelectMax = LocTimeEbbMinutes;
            if (((int)chkSBF.CheckState == 1 | (int)chkSBE.CheckState == 1) & DesTimeMinutes == SelectSlack)
            {
                ErrorMsgBox("Check the data.  Desired Time must be between Localized Time of selected Flood and Localized Time of selected Maximum.");
                return;
            }

            if (((int)chkF.CheckState == 1 | (int)chkE.CheckState == 1) & DesTimeMinutes == SelectMax)
            {
                ErrorMsgBox("Check the data.  Desired Time must be between Localized Time of selected Flood and Localized Time of selected Maximum.");
                return;
            }

            TimeIntSlackMaxMinutes = Math.Abs((short)(SelectSlack - SelectMax));
            if (TimeIntSlackMaxMinutes > 720)
                TimeIntSlackMaxMinutes = (short)Math.Abs(TimeIntSlackMaxMinutes - 1440);
            TimeIntSlackDesMinutes = Math.Abs((short)(SelectSlack - DesTimeMinutes));
            if (TimeIntSlackDesMinutes > 720)
                TimeIntSlackDesMinutes = (short)Math.Abs(TimeIntSlackDesMinutes - 1440);
            TimeIntSlackMaxHour = (short)Conversion.Int(TimeIntSlackMaxMinutes / 60d);
            TimeIntSlackMaxMin = (short)Conversion.Int(TimeIntSlackMaxMinutes - TimeIntSlackMaxHour * 60);
            TimeIntSlackDesHour = (short)Conversion.Int(TimeIntSlackDesMinutes / 60d);
            TimeIntSlackDesMin = (short)Conversion.Int(TimeIntSlackDesMinutes - TimeIntSlackDesHour * 60);
            TimeIntDesFlood = Math.Abs((short)(DesTimeMinutes - LocTimeFloodMinutes));
            TimeIntDesEbb = Math.Abs((short)(DesTimeMinutes - LocTimeEbbMinutes));
            if (optA.Checked == true | optB.Checked == true)
            {
                if (TimeIntSlackMaxMin <= 9)
                    TimeIntSlackMaxMinutes = (short)(60 * TimeIntSlackMaxHour);
                if (TimeIntSlackMaxMin > 9 & TimeIntSlackMaxMin <= 29)
                    TimeIntSlackMaxMinutes = (short)(60 * TimeIntSlackMaxHour + 20);
                if (TimeIntSlackMaxMin > 29 & TimeIntSlackMaxMin <= 49)
                    TimeIntSlackMaxMinutes = (short)(60 * TimeIntSlackMaxHour + 40);
                if (TimeIntSlackMaxMin > 49)
                    TimeIntSlackMaxMinutes = (short)(60 * TimeIntSlackMaxHour + 60);
                if (TimeIntSlackDesMin <= 9)
                    TimeIntSlackDesMinutes = (short)(60 * TimeIntSlackDesHour);
                if (TimeIntSlackDesMin > 9 & TimeIntSlackDesMin <= 29)
                    TimeIntSlackDesMinutes = (short)(60 * TimeIntSlackDesHour + 20);
                if (TimeIntSlackDesMin > 29 & TimeIntSlackDesMin <= 49)
                    TimeIntSlackDesMinutes = (short)(60 * TimeIntSlackDesHour + 40);
                if (TimeIntSlackDesMin > 49)
                    TimeIntSlackDesMinutes = (short)(60 * TimeIntSlackDesHour + 60);
            }

            Ratio = TimeIntSlackDesMinutes / (double)TimeIntSlackMaxMinutes;
            if (optCalc.Checked == true | optA.Checked == true | optB.Checked == true)
                Factor = Math.Sin(Pi / 2d * Ratio);
            if (optCalc.Checked == true | optA.Checked == true | optB.Checked == true)
                Factor = Conversion.Int(Factor * 10d + 0.5d) / 10d;
            if (optB.Checked == true)
            {
                switch (Ratio)
                {
                    case var @case when @case <= 0.087d:
                        {
                            Factor = 0.2d;
                            break;
                        }

                    case var case1 when case1 < 0.149d:
                        {
                            Factor = 0.3d;
                            break;
                        }

                    case var case2 when case2 < 0.208d:
                        {
                            Factor = 0.4d;
                            break;
                        }

                    case var case3 when case3 < 0.29d:
                        {
                            Factor = 0.5d;
                            break;
                        }

                    case var case4 when case4 < 0.366d:
                        {
                            Factor = 0.6d;
                            break;
                        }

                    case var case5 when case5 < 0.486d:
                        {
                            Factor = 0.7d;
                            break;
                        }

                    case var case6 when case6 < 0.594d:
                        {
                            Factor = 0.8d;
                            break;
                        }

                    case var case7 when case7 < 0.767d:
                        {
                            Factor = 0.9d;
                            break;
                        }

                    default:
                        {
                            Factor = 1d;
                            break;
                        }
                }

                if (TimeIntSlackDesMinutes == 60 & TimeIntSlackMaxMinutes == 100)
                    Factor = 0.8d; // This is an exception for Ratio + 0.6


                // 50-90 Rule
            };
            //        '50-90 Rule */
            float[] x = new float[6];      //Static x(6) As float
            float[] Diff = new float[6];   //  Static Diff(6) As float
            float[] y = new float[6];      // Static y(6) As float

            if (optRule.Checked == true)
            {
                DurationStep = (float)((double)TimeIntSlackMaxMinutes / 3d);
                DurationStep = (float)Conversion.Int((double)DurationStep + 0.5d);
                if (SelectSlack <= SelectMax)
                    x[0] = (float)SelectSlack;
                else
                    x[0] = (float)SelectMax;
                if (SelectSlack <= SelectMax)
                    y[0] = (float)SelectSlack;
                else
                    y[0] = (float)SelectMax;
                Diff[0] = Math.Abs(x[0] - (float)DesTimeMinutes);
                // This section determines the Time#1-4 values for display
                for (i = (short)1; i <= (short)3; i++)
                {
                    y[(int)i] = y[(int)i - 1] + DurationStep;
                    Diff[(int)i] = Math.Abs(y[(int)i] - (float)DesTimeMinutes);
                }
                // This section determines which Time# to use for the calculation
                for (i = (short)1; i <= (short)3; i++)
                {
                    x[(int)i] = x[(int)i - 1] + DurationStep;
                    Diff[(int)i] = Math.Abs(x[(int)i] - (float)DesTimeMinutes);
                    if (Diff[(int)i] > Diff[(int)i - 1])
                        break;
                }

                i = (short)((int)i - 1);
                // TimeDiff = Int(TimeDiff / 60 + 0.5)
                if ((int)i == 0 & SelectSlack <= SelectMax)
                    Factor = 0d;
                if ((int)i == 1 & SelectSlack <= SelectMax)
                    Factor = 0.5d;
                if ((int)i == 2 & SelectSlack <= SelectMax)
                    Factor = 0.9d;
                if ((int)i == 3 & SelectSlack <= SelectMax)
                    Factor = 1d;
                if ((int)i == 0 & SelectSlack > SelectMax)
                    Factor = 1d;
                if ((int)i == 1 & SelectSlack > SelectMax)
                    Factor = 0.9d;
                if ((int)i == 2 & SelectSlack > SelectMax)
                    Factor = 0.5d;
                if ((int)i == 3 & SelectSlack > SelectMax)
                    Factor = 0d;
                // Range = Int(Range + 0.5)
                // Correction = Range * Factor
                X0Hour = (short)Conversion.Int(y[0] / 60f);
                X0Min = (short)Conversion.Int(y[0] - (float)((int)X0Hour * 60));
                if ((int)X0Min >= 60)
                {
                    X0Min = (short)((int)X0Min - 60);
                    X0Hour = (short)((int)X0Hour + 1);
                }

                X1Hour = (short)Conversion.Int(y[1] / 60f);
                X1Min = (short)Conversion.Int(y[1] - (float)((int)X1Hour * 60));
                if ((int)X1Min >= 60)
                {
                    X1Min = (short)((int)X1Min - 60);
                    X1Hour = (short)((int)X1Hour + 1);
                }

                X2Hour = (short)Conversion.Int(y[2] / 60f);
                X2Min = (short)Conversion.Int(y[2] - (float)((int)X2Hour * 60));
                if ((int)X2Min >= 60)
                {
                    X2Min = (short)((int)X2Min - 60);
                    X2Hour = (short)((int)X2Hour + 1);
                }
                // Next two lines added so Time3 is a result of Time2+TimeDiff, rather than the later of the bracketed times
                X3Hour = (short)Conversion.Int(y[3] / 60f);
                X3Min = (short)Conversion.Int(y[3] - (float)((int)X3Hour * 60));
                if ((int)X3Min >= 60)
                {
                    X3Min = (short)((int)X3Min - 60);
                    X3Hour = (short)((int)X3Hour + 1);
                }

                Time0 = Strings.Format((object)X0Hour, "00") + Strings.Format((object)X0Min, "00");
                Time1 = Strings.Format((object)X1Hour, "00") + Strings.Format((object)X1Min, "00");
                Time2 = Strings.Format((object)X2Hour, "00") + Strings.Format((object)X2Min, "00");
                // These line changed so Time3 is a result of Time2+TimeDiff, rather than the later of the bracketed times
                // SelectSlackHour = Int(SelectSlack / 60)
                // SelectSlackMin = Int((SelectSlack - CLng(SelectSlackHour) * 60))
                // SelectMaxHour = Int(SelectMax / 60)
                // SelectMaxMin = Int((SelectMax - CLng(SelectMaxHour) * 60))
                // If SelectSlack <= SelectMax Then Time3 = Strings.format(SelectMaxHour, "00") & Strings.format(SelectMaxMin, "00")   'Str$(SelectMaxHour) & Str$(SelectMaxMin)
                // If SelectSlack > SelectMax Then Time3 = Strings.format(SelectSlackHour, "00") & Strings.format(SelectSlackMin, "00")                                                          'Str$(SelectSlackHour) & Str$(SelectSlackMin)
                Time3 = Strings.Format((object)X3Hour, "00") + Strings.Format((object)X3Min, "00");
            }


            // Factor = Int(Factor * 10 + 0.5) / 10

            // If TimeIntDesFlood <= TimeIntDesEbb Then Drift = LocVelFlood * Factor
            // If TimeIntDesFlood > TimeIntDesEbb Then Drift = LocVelEbb * Factor
            if ((int)chkF.CheckState == 1)
                Drift = (float)(LocVelFlood * Factor);
            if ((int)chkE.CheckState == 1)
                Drift = (float)(LocVelEbb * Factor);
            ClearRptTextBox();
            DisplayLocalizedData();
            var argTB = Curr8TxtBx;
            SetTxtBxBoldOn(ref argTB);
            Curr8TxtBx = argTB;
            if (optA.Checked == true | optB.Checked == true)
            {
                Curr8TxtBx.AppendText("  Entering Arguments for Table 3 (from Localized Data):");
            }

            if (optCalc.Checked == true)
            {
                Curr8TxtBx.AppendText("  Entering Arguments for Calculation:");
            }

            if (optRule.Checked == true)
            {
                Curr8TxtBx.AppendText("  Entering Arguments for 50-90 Rule:");
            }

            var argTB1 = Curr8TxtBx;
            SetTxtBxtoReg(ref argTB1);
            Curr8TxtBx = argTB1;
            Curr10TxtBx.AppendText(Environment.NewLine);
            Curr8TxtBx.AppendText("     Time Interval Between Selected Slack & Max.  " + Environment.NewLine);
            Curr10TxtBx.AppendText(TimeIntSlackMaxHour.ToString() + " h " + Strings.Format(TimeIntSlackMaxMin, "00") + " m" + " (" + Strings.Format(TimeIntSlackMaxMinutes, "#") + " m)" + Environment.NewLine);
            if (optRule.Checked == false)
            {
                Curr8TxtBx.AppendText("     Time Interval Between Selected Slack & Desired Time  ");
                Curr10TxtBx.AppendText(TimeIntSlackDesHour.ToString() + " h " + Strings.Format(TimeIntSlackDesMin, "00") + " m");
            }

            if (optRule.Checked == true)
            {
                Curr8TxtBx.AppendText("     Time Interval Between Selected Slack & Max./3");
                Curr10TxtBx.AppendText(DurationStep.ToString() + "m");
            }

            if (optRule.Checked == true)
                Curr8TxtBx.AppendText(Environment.NewLine + "     Time#1-4  " + Time0 + Strings.Space(1) + Time1 + Strings.Space(1) + Time2 + Strings.Space(1) + Time3 + Strings.Space(1));
            Curr11TxtBx.AppendText("Velocity Factor from ");
            if (optA.Checked == true | optB.Checked == true)
            {
                Curr11TxtBx.AppendText("Table 3");
            }

            if (optCalc.Checked == true)
            {
                Curr11TxtBx.AppendText("calculation");
            }

            if (optRule.Checked == true)
            {
                Curr11TxtBx.AppendText("50-90 Rule (as percent change)");
            }

            if (optRule.Checked == false)
            {
                Curr12TxtBx.AppendText(Strings.Format(Factor, "0.0"));
            }

            if (optRule.Checked == true)
            {
                Curr12TxtBx.AppendText((Factor * 100d).ToString() + "%");
            }

            var argTB2 = Curr13TxtBx;
            SetTxtBxBoldOn(ref argTB2);
            Curr13TxtBx = argTB2;
            if (optA.Checked == true | optB.Checked == true)
            {
                Curr13TxtBx.AppendText("  Application of Table 3 Factor:");
            }

            if (optCalc.Checked == true)
            {
                Curr13TxtBx.AppendText("  Application of Calculated Factor:");
            }

            if (optRule.Checked == true)
            {
                Curr13TxtBx.AppendText("  Application of 50-90 Rule Factor:");
            }

            var argTB3 = Curr13TxtBx;
            SetTxtBxtoReg(ref argTB3);
            Curr13TxtBx = argTB3;
            Curr13TxtBx.AppendText(Environment.NewLine);
            Curr13TxtBx.AppendText("     Max. Velocity at Local (Table 2) Substation: ");
            // If TimeIntDesFlood <= TimeIntDesEbb Then FormCurrents.Font.Bold = True
            if ((int)chkF.CheckState == 1)
            {
                var argTB4 = Curr13TxtBx;
                SetTxtBxBoldOn(ref argTB4);
                Curr13TxtBx = argTB4;
            }

            Curr13TxtBx.AppendText("Max. F");
            var argTB5 = Curr13TxtBx;
            SetTxtBxtoReg(ref argTB5);
            Curr13TxtBx = argTB5;
            Curr13TxtBx.AppendText(" or ");
            // If TimeIntDesFlood > TimeIntDesEbb Then FormCurrents.Font.Bold = True
            if ((int)chkE.CheckState == 1)
            {
                var argTB6 = Curr13TxtBx;
                SetTxtBxBoldOn(ref argTB6);
                Curr13TxtBx = argTB6;
            }

            Curr13TxtBx.AppendText("Max. E");
            var argTB7 = Curr13TxtBx;
            SetTxtBxtoReg(ref argTB7);
            Curr13TxtBx = argTB7;
            Curr13TxtBx.AppendText(Environment.NewLine);

            // Print " whichever is closer in time";
            // If TimeIntDesFlood <= TimeIntDesEbb Then Print Tab(131); LocVelFlood; " kn"
            // If TimeIntDesFlood > TimeIntDesEbb Then Print Tab(131); LocVelEbb; " kn"
            if ((int)chkF.CheckState == 1)
            {
                if (optRule.Checked == false)
                {
                    Curr14TxtBx.AppendText(Strings.Format(LocVelFlood, "0.00") + " kn");
                }

                if (optRule.Checked == true)
                {
                    Curr14TxtBx.AppendText(Strings.Format(LocVelFlood, "0.0") + " kn");
                }

                Curr14TxtBx.AppendText(Environment.NewLine);
            }

            if ((int)chkE.CheckState == 1)
            {
                if (optRule.Checked == false)
                {
                    Curr13TxtBx.AppendText(Strings.Format(LocVelEbb, "0.00") + " kn");
                }

                if (optRule.Checked == true)
                {
                    Curr13TxtBx.AppendText(Strings.Format(LocVelEbb, "0.0") + " kn");
                }

                Curr14TxtBx.AppendText(Environment.NewLine);
            }

            if (optCalc.Checked == false & optRule.Checked == false)
            {
                Curr13TxtBx.AppendText("     Table 3 Velocity Factor:");
            }

            if (optCalc.Checked == true)
                Curr13TxtBx.AppendText("     Calculated Velocity Factor:");
            if (optRule.Checked == true)
                Curr13TxtBx.AppendText("     50-90 Rule Velocity Factor:");
            Curr13TxtBx.SelectionAlignment = HorizontalAlignment.Center;
            Curr13TxtBx.AppendText("(Multiply)");
            Curr13TxtBx.SelectionAlignment = HorizontalAlignment.Left;
            Curr14TxtBx.AppendText("x " + Strings.Format(Strings.Format(Factor, "0.0")));
            Curr15TxtBx.AppendText("  Predicted Tidal Current Velocity at Desired Time at Local (Table 2) Substation");
            Curr16TxtBx.AppendText("Drift = ");
            Curr17TxtBx.AppendText(Strings.Format(Drift, "0.0") + " kn");
            Curr18TxtBx.AppendText(" DIRECTION");
            Curr18TxtBx.SelectionAlignment = HorizontalAlignment.Center;
            Curr18TxtBx.AppendText("Direction of Tidal Current (");
            if ((int)chkF.CheckState == 1)
            {
                var argTB8 = Curr18TxtBx;
                SetTxtBxBoldOn(ref argTB8);
                Curr18TxtBx = argTB8;
            }

            Curr18TxtBx.AppendText("F");
            var argTB9 = Curr18TxtBx;
            SetTxtBxtoReg(ref argTB9);
            Curr18TxtBx = argTB9;
            Curr18TxtBx.AppendText(" or ");
            if ((int)chkE.CheckState == 1)
            {
                var argTB10 = Curr18TxtBx;
                SetTxtBxBoldOn(ref argTB10);
                Curr18TxtBx = argTB10;
            }

            Curr18TxtBx.AppendText(CommonGlobals.g_LongE);
            var argTB11 = Curr18TxtBx;
            SetTxtBxtoReg(ref argTB11);
            Curr18TxtBx = argTB11;
            Curr18TxtBx.AppendText(") Desired");
            Curr18TxtBx.AppendText(" from Table 2");
            Curr18TxtBx.SelectionAlignment = HorizontalAlignment.Center;
            Curr18TxtBx.AppendText("Time at Local (Table 2) Substation");
            Curr18TxtBx.SelectionAlignment = HorizontalAlignment.Left;
            Curr19TxtBx.AppendText("Set = ");
            if ((int)chkF.CheckState == 1)
                Curr20TxtBx.AppendText(Strings.Format(Conversion.Val(txtSetFlood.Text), "000") + '°');
            if ((int)chkE.CheckState == 1)
                Curr20TxtBx.AppendText(Strings.Format(Conversion.Val(txtSetEbb.Text), "000") + '°');
            return;
        }

        public void DisplayLocalizedData()
        {

            // DISPLAY LOCALIZED DATA
            Curr1Txtbx.AppendText("  Localized Data:  " + txtTab2Diff.Text);
            if (DTTimeSlackBeforeFlood.Value.Hour != 0 | DTTimeSlackBeforeFlood.Value.Minute != 0)
            {
                Curr2TxtBx.AppendText(Strings.Format(LocTimeSlackBeforeFloodHour, "00") + Strings.Format(LocTimeSlackBeforeFloodMin, "00"));
            }

            if (DTTimeFlood.Value.Hour != 0 | DTTimeFlood.Value.Minute != 0)
            {
                Curr3TxtBx.AppendText(Strings.Format(LocTimeFloodHour, "00") + Strings.Format(LocTimeFloodMin, "00"));
                if (optRule.Checked == false)
                    Curr4TxtBx.AppendText(Strings.Format(LocVelFlood, "0.00") + " kn");
                if (optRule.Checked == true)
                    Curr4TxtBx.AppendText(Strings.Format(LocVelFlood, "0.0") + " kn");
            }

            if (DTTimeSlackBeforeEbb.Value.Hour != 0 | DTTimeSlackBeforeEbb.Value.Minute != 0)
            {
                Curr5TxtBx.AppendText(Strings.Format(LocTimeSlackBeforeEbbHour, "00") + Strings.Format(LocTimeSlackBeforeEbbMin, "00"));
            }

            if (DTTimeEbb.Value.Hour != 0 | DTTimeEbb.Value.Minute != 0)
            {
                Curr6TxtBx.AppendText(Strings.Format(LocTimeEbbHour, "00") + Strings.Format(LocTimeEbbMin, "00"));
                if (optRule.Checked == false)
                    Curr7TxtBx.AppendText(Strings.Format(LocVelEbb, "0.00") + " kn");
                if (optRule.Checked == true)
                    Curr7TxtBx.AppendText(Strings.Format(LocVelEbb, "0.0") + " kn");
            }

            return;
        }

        private void optA_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            //if (Conversions.ToBoolean(eventSender.Checked))
            if (optA.Checked)
            {
                cmdCurrents_Click(cmdCurrents, new EventArgs());
            }
        }

        private void optCalc_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optCalc.Checked)
            {
                cmdCurrents_Click(cmdCurrents, new EventArgs());
            }
        }

        private void optB_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optB.Checked)
            {
                cmdCurrents_Click(cmdCurrents, new EventArgs());
            }
        }

        private void optRule_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optRule.Checked)
            {
                cmdCurrents_Click(cmdCurrents, new EventArgs());
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

        private void txtSetFlood_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtSetFlood.Text) > 359d)
            {
                txtSetFlood.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtSetFlood.Text) < 360d)
            {
                txtSetFlood.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtSetFlood_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtSetFlood.Text) > 359d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtSetFlood_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtSetFlood;
            SelectAllText(ref argTB);
            txtSetFlood = argTB;
        }

        private void txtSetEbb_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtSetEbb.Text) > 359d)
            {
                txtSetEbb.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtSetEbb.Text) < 360d)
            {
                txtSetEbb.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtSetEbb_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtSetEbb.Text) > 359d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtSetEbb_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtSetEbb;
            SelectAllText(ref argTB);
            txtSetEbb = argTB;
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

        private void txtTab2FloodHour_TextChanged(object eventSender, EventArgs eventArgs)
        {
            // txtTime.ForeColor = &H80000008
            txtTab2FloodHour.BackColor = Control.DefaultBackColor; 
            // If Len(txtTime.text) = 6 And (Val(Left(txtTime.text, 2)) > 23 Or Val(Mid(txtTime.text, 3, 2)) > 59 Or Val(Mid(txtTime.text, 5, 2)) > 59) Then
            // txtTime.BackColor = &HFF&
            // ErrorMsgBox "Out of Range"
            // End If
        }

        private void txtTab2FloodHour_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        if (txtTab2FloodHour.SelectionStart != 0 | bMinusSignAlready)
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

                        if (txtTab2FloodHour.SelectionStart != 0 | bPlusSignAlready)
                        {
                            KeyAscii = 0;
                            Interaction.Beep();
                        }
                        else
                        {
                            bPlusSignAlready = true;
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

        private void txtTab2FloodHour_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            // If Val(Left(txtTime.text, 2)) > 23 Or Val(Mid(txtTime.text, 3, 2)) > 59 Or Val(Mid(txtTime.text, 5, 2)) > 59 Or Len(txtTime) <> 6 Then
            // KeepFocus = True
            // End If
            // If Len(txtTime) = 0 Then
            // KeepFocus = False
            // End If
            eventArgs.Cancel = KeepFocus;
        }

        private void txtTab2FloodHour_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtTab2FloodHour;
            SelectAllText(ref argTB);
            txtTab2FloodHour = argTB;
        }

        private void txtTab2FloodMin_TextChanged(object eventSender, EventArgs eventArgs)
        {
            // txtTime.ForeColor = &H80000008
            txtTab2FloodMin.BackColor = Control.DefaultBackColor; 
            if (Strings.Len(txtTab2FloodMin.Text) == 2 & Conversion.Val(txtTab2FloodMin.Text) > 59d)
            {
                txtTab2FloodMin.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }
        }

        private void txtTab2FloodMin_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        private void txtTab2FloodMin_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtTab2FloodMin.Text) > 59d)
            {
                KeepFocus = true;
            }
            // If Len(txtTime) = 0 Then
            // KeepFocus = False
            // End If
            eventArgs.Cancel = KeepFocus;
        }

        private void txtTab2FloodMin_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtTab2FloodMin;
            SelectAllText(ref argTB);
            txtTab2FloodMin = argTB;
        }

        private void txtTab2EbbHour_TextChanged(object eventSender, EventArgs eventArgs)
        {
            // txtTime.ForeColor = &H80000008
            txtTab2EbbHour.BackColor = Control.DefaultBackColor; 
            // If Len(txtTime.text) = 6 And (Val(Left(txtTime.text, 2)) > 23 Or Val(Mid(txtTime.text, 3, 2)) > 59 Or Val(Mid(txtTime.text, 5, 2)) > 59) Then
            // txtTime.BackColor = &HFF&
            // ErrorMsgBox "Out of Range"
            // End If
        }

        private void txtTab2EbbHour_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        if (txtTab2EbbHour.SelectionStart != 0 | bMinusSignAlready)
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

                        if (txtTab2EbbHour.SelectionStart != 0 | bPlusSignAlready)
                        {
                            KeyAscii = 0;
                            Interaction.Beep();
                        }
                        else
                        {
                            bPlusSignAlready = true;
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

        private void txtTab2EbbHour_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            // If Val(Left(txtTime.text, 2)) > 23 Or Val(Mid(txtTime.text, 3, 2)) > 59 Or Val(Mid(txtTime.text, 5, 2)) > 59 Or Len(txtTime) <> 6 Then
            // KeepFocus = True
            // End If
            // If Len(txtTime) = 0 Then
            // KeepFocus = False
            // End If
            eventArgs.Cancel = KeepFocus;
        }

        private void txtTab2EbbHour_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtTab2EbbHour;
            SelectAllText(ref argTB);
            txtTab2EbbHour = argTB;
        }

        private void txtTab2EbbMin_TextChanged(object eventSender, EventArgs eventArgs)
        {
            // txtTime.ForeColor = &H80000008
            txtTab2EbbMin.BackColor = Control.DefaultBackColor; 
            if (Strings.Len(txtTab2EbbMin.Text) == 2 & Conversion.Val(txtTab2EbbMin.Text) > 59d)
            {
                txtTab2EbbMin.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }
        }

        private void txtTab2EbbMin_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        private void txtTab2EbbMin_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtTab2EbbMin.Text) > 59d)
            {
                KeepFocus = true;
            }
            // If Len(txtTab2LowMins) = 0 Then
            // KeepFocus = False
            // End If
            eventArgs.Cancel = KeepFocus;
        }

        private void txtTab2EbbMin_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtTab2EbbMin;
            SelectAllText(ref argTB);
            txtTab2EbbMin = argTB;
        }

        private void txtTab2SlackFHour_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        if (txtTab2SlackFHour.SelectionStart != 0 | bMinusSignAlready)
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

                        if (txtTab2SlackFHour.SelectionStart != 0 | bPlusSignAlready)
                        {
                            KeyAscii = 0;
                            Interaction.Beep();
                        }
                        else
                        {
                            bPlusSignAlready = true;
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

        private void txtTab2SlackFHour_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            // If Val(Left(txtTime.text, 2)) > 23 Or Val(Mid(txtTime.text, 3, 2)) > 59 Or Val(Mid(txtTime.text, 5, 2)) > 59 Or Len(txtTime) <> 6 Then
            // KeepFocus = True
            // End If
            // If Len(txtTime) = 0 Then
            // KeepFocus = False
            // End If
            eventArgs.Cancel = KeepFocus;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
            return;
        }

        private void txtTab2SlackFHour_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtTab2SlackFHour;
            SelectAllText(ref argTB);
            txtTab2SlackFHour = argTB;
        }

        // UPGRADE_WARNING: Event txtTab2SlackFMin.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
        private void txtTab2SlackFMin_TextChanged(object eventSender, EventArgs eventArgs)
        {
            // txtTime.ForeColor = &H80000008
            txtTab2SlackFMin.BackColor = Control.DefaultBackColor; 
            if (Strings.Len(txtTab2SlackFMin.Text) == 2 & Conversion.Val(txtTab2SlackFMin.Text) > 59d)
            {
                txtTab2SlackFMin.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }
        }

        private void txtTab2SlackFMin_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        private void FormCurrents_Load(object sender, EventArgs e)
        {
            if (My.MyProject.Computer.Network.IsAvailable)
            {
                LinkNOAACurrentTides.Visible = true;
                LinkNOAACurrentTides.Enabled = true;
            }
            else
            {
                LinkNOAACurrentTides.Visible = false;
                LinkNOAACurrentTides.Enabled = false;
            }

            DTTides.Value = DateAndTime.Now;
            DTTimeSlackBeforeFlood.Value = DTTemp;
            DTTimeFlood.Value = DTTemp;
            DTTimeSlackBeforeEbb.Value = DTTemp;
            DTTimeEbb.Value = DTTemp;
            FormCurrentsLoaded = true;
        }

        private void txtTab2SlackFMin_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtTab2SlackFMin.Text) > 59d)
            {
                KeepFocus = true;
            }
            // If Len(txtTab2LowMins) = 0 Then
            // KeepFocus = False
            // End If
            eventArgs.Cancel = KeepFocus;
        }

        private void LinkNOAACurrentTides_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Dim URLNOAATideCurr As String = "https://oceanservice.noaa.gov/navigation/tidesandcurrents/"
            string URLNOAATideCurr = "https://tidesandcurrents.noaa.gov/noaacurrents/Regions";
            Process.Start(URLNOAATideCurr);
        }

        private void txtTab2SlackFMin_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtTab2SlackFMin;
            SelectAllText(ref argTB);
            txtTab2SlackFMin = argTB;
        }

        private void txtTab2SlackEHour_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        if (txtTab2SlackEHour.SelectionStart != 0 | bMinusSignAlready)
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

                        if (txtTab2SlackEHour.SelectionStart != 0 | bPlusSignAlready)
                        {
                            KeyAscii = 0;
                            Interaction.Beep();
                        }
                        else
                        {
                            bPlusSignAlready = true;
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

        private void txtTab2SlackEHour_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            // If Val(Left(txtTime.text, 2)) > 23 Or Val(Mid(txtTime.text, 3, 2)) > 59 Or Val(Mid(txtTime.text, 5, 2)) > 59 Or Len(txtTime) <> 6 Then
            // KeepFocus = True
            // End If
            // If Len(txtTime) = 0 Then
            // KeepFocus = False
            // End If
            eventArgs.Cancel = KeepFocus;
        }

        private void txtTab2SlackEHour_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtTab2SlackEHour;
            SelectAllText(ref argTB);
            txtTab2SlackEHour = argTB;
        }

        private void txtTab2SlackEMin_TextChanged(object eventSender, EventArgs eventArgs)
        {
            // txtTime.ForeColor = &H80000008
            txtTab2SlackEMin.BackColor = Control.DefaultBackColor; 
            if (Strings.Len(txtTab2SlackEMin.Text) == 2 & Conversion.Val(txtTab2SlackEMin.Text) > 59d)
            {
                txtTab2SlackEMin.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }
        }

        private void txtTab2SlackEMin_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        private void txtTab2SlackEMin_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtTab2SlackEMin.Text) > 59d)
            {
                KeepFocus = true;
            }
            // If Len(txtTab2LowMins) = 0 Then
            // KeepFocus = False
            // End If
            eventArgs.Cancel = KeepFocus;
        }

        private void txtTab2SlackEMin_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtTab2SlackEMin;
            SelectAllText(ref argTB);
            txtTab2SlackEMin = argTB;
        }

        private void FormCurrents_FormClosed(object eventSender, FormClosedEventArgs eventArgs)
        {
            // Cleanup()
        }

        private void txtTab2FloodMult_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

                case (short)('.'): // only allows one decimal point
                    {
                        if (Conversions.ToBoolean(Strings.InStr(txtTab2FloodMult.Text, ".")))
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

        private void txtFloodMult_Validate(ref bool KeepFocus)
        {
            // If Val(Left(txtTime.text, 2)) > 23 Or Val(Mid(txtTime.text, 3, 2)) > 59 Or Val(Mid(txtTime.text, 5, 2)) > 59 Or Len(txtTime) <> 6 Then
            // KeepFocus = True
            // End If
            // If Len(txtTime) = 0 Then
            // KeepFocus = False
            // End If
        }

        private void txtTab2FloodMult_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtTab2FloodMult;
            SelectAllText(ref argTB);
            txtTab2FloodMult = argTB;
        }

        private void txtTab2EbbMult_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

                case (short)('.'): // only allows one decimal point
                    {
                        if (Conversions.ToBoolean(Strings.InStr(txtTab2EbbMult.Text, ".")))
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

        private void txtTab2EbbMult_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            // If Val(Left(txtTime.text, 2)) > 23 Or Val(Mid(txtTime.text, 3, 2)) > 59 Or Val(Mid(txtTime.text, 5, 2)) > 59 Or Len(txtTime) <> 6 Then
            // KeepFocus = True
            // End If
            // If Len(txtTime) = 0 Then
            // KeepFocus = False
            // End If
            eventArgs.Cancel = KeepFocus;
        }

        private void txtTab2EbbMult_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtTab2EbbMult;
            SelectAllText(ref argTB);
            txtTab2EbbMult = argTB;
        }

        // Private Sub txtTimeEbb_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        // 'txtTime.ForeColor = &H80000008
        // txtTimeEbb.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        // If Len(txtTimeEbb.Text) = 4 And (Val(VB.Left(txtTimeEbb.Text, 2)) > 23 Or Val(Mid(txtTimeEbb.Text, 3, 2)) > 59) Then
        // txtTimeEbb.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
        // ErrorMsgBox("Out of Range")
        // Exit Sub
        // End If
        // End Sub
        // Private Sub txtTimeEbb_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
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

        // Private Sub txtTimeEbb_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs)
        // Dim KeepFocus As Boolean = eventArgs.Cancel
        // If Val(VB.Left(txtTimeEbb.Text, 2)) > 23 Or Val(Mid(txtTimeEbb.Text, 3, 2)) > 59 Or Len(txtTimeEbb.Text) <> 4 Then
        // KeepFocus = True
        // End If
        // If Len(txtTimeEbb.Text) = 0 Then
        // KeepFocus = False
        // End If
        // eventArgs.Cancel = KeepFocus
        // End Sub
        // Private Sub txtTimeEbb_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        // SelectAllText(txtTimeEbb)
        // End Sub

        // Private Sub txtTimeFlood_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        // 'txtTime.ForeColor = &H80000008
        // txtTimeFlood.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        // If Len(txtTimeFlood.Text) = 4 And (Val(VB.Left(txtTimeFlood.Text, 2)) > 23 Or Val(Mid(txtTimeFlood.Text, 3, 2)) > 59) Then
        // txtTimeFlood.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
        // ErrorMsgBox("Out of Range")
        // Exit Sub
        // End If
        // End Sub
        // Private Sub txtTimeFlood_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
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

        // Private Sub txtTimeFlood_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs)
        // Dim KeepFocus As Boolean = eventArgs.Cancel
        // If Val(VB.Left(txtTimeFlood.Text, 2)) > 23 Or Val(Mid(txtTimeFlood.Text, 3, 2)) > 59 Or Len(txtTimeFlood.Text) <> 4 Then
        // KeepFocus = True
        // End If
        // If Len(txtTimeFlood.Text) = 0 Then
        // KeepFocus = False
        // End If
        // eventArgs.Cancel = KeepFocus
        // End Sub
        // Private Sub txtTimeFlood_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        // SelectAllText(txtTimeFlood)
        // End Sub

        // Private Sub txtTimeSlackBeforeEbb_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        // 'txtTime.ForeColor = &H80000008
        // txtTimeSlackBeforeEbb.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        // If Len(txtTimeSlackBeforeEbb.Text) = 4 And (Val(VB.Left(txtTimeSlackBeforeEbb.Text, 2)) > 23 Or Val(Mid(txtTimeSlackBeforeEbb.Text, 3, 2)) > 59) Then
        // txtTimeSlackBeforeEbb.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
        // ErrorMsgBox("Out of Range")
        // Exit Sub
        // End If
        // End Sub
        // Private Sub txtTimeSlackBeforeEbb_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
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

        // Private Sub txtTimeSlackBeforeEbb_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs)
        // Dim KeepFocus As Boolean = eventArgs.Cancel
        // If Val(VB.Left(txtTimeSlackBeforeEbb.Text, 2)) > 23 Or Val(Mid(txtTimeSlackBeforeEbb.Text, 3, 2)) > 59 Or Len(txtTimeSlackBeforeEbb.Text) <> 4 Then
        // KeepFocus = True
        // End If
        // If Len(txtTimeSlackBeforeEbb.Text) = 0 Then
        // KeepFocus = False
        // End If
        // eventArgs.Cancel = KeepFocus
        // End Sub
        // Private Sub txtTimeSlackBeforeEbb_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        // SelectAllText(txtTimeSlackBeforeEbb)
        // End Sub

        // Private Sub txtTimeSlackBeforeFlood_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        // 'txtTime.ForeColor = &H80000008
        // txtTimeSlackBeforeFlood.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        // If Len(txtTimeSlackBeforeFlood.Text) = 4 And (Val(VB.Left(txtTimeSlackBeforeFlood.Text, 2)) > 23 Or Val(Mid(txtTimeSlackBeforeFlood.Text, 3, 2)) > 59) Then
        // txtTimeSlackBeforeFlood.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
        // ErrorMsgBox("Out of Range")
        // Exit Sub
        // End If
        // End Sub
        // Private Sub txtTimeSlackBeforeFlood_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
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

        // Private Sub txtTimeSlackBeforeFlood_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs)
        // Dim KeepFocus As Boolean = eventArgs.Cancel
        // If Val(VB.Left(txtTimeSlackBeforeFlood.Text, 2)) > 23 Or Val(Mid(txtTimeSlackBeforeFlood.Text, 3, 2)) > 59 Or Len(txtTimeSlackBeforeFlood.Text) <> 4 Then
        // KeepFocus = True
        // End If
        // If Len(txtTimeSlackBeforeFlood.Text) = 0 Then
        // KeepFocus = False
        // End If
        // eventArgs.Cancel = KeepFocus
        // End Sub
        // Private Sub txtTimeSlackBeforeFlood_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        // SelectAllText(txtTimeSlackBeforeFlood)
        // End Sub

        private void txtVelEbb_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

                case (short)('.'): // only allows one decimal point
                    {
                        if (Conversions.ToBoolean(Strings.InStr(txtVelEbb.Text, ".")))
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

        private void txtVelEbb_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtVelEbb;
            SelectAllText(ref argTB);
            txtVelEbb = argTB;
        }

        private void txtVelFlood_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

                case (short)('.'): // only allows one decimal point
                    {
                        if (Conversions.ToBoolean(Strings.InStr(txtVelFlood.Text, ".")))
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

        private void txtVelFlood_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtVelFlood;
            SelectAllText(ref argTB);
            txtVelFlood = argTB;
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
        // 'Private Sub txtYear_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        // '    SelectAllText(txtYear)
        // 'End Sub

        private void SelectAllText(ref TextBox TB)
        {
            TB.SelectionStart = 0;
            TB.SelectionLength = Strings.Len(TB.Text);
            // 
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