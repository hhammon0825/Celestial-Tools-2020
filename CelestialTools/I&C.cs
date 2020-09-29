using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    internal partial class FormIandC : Form
    {
        private string fnumeral;
        private double vcorr, dcorr, k, GHAIncrement, GHAIncrementMin;
        private short GHAIncrementDeg;
        private double Time, TimeSec;
        private short TimeMin;
        // Dim corr2k As Double
        // Dim Flag As Boolean
        private void cmdPrint_Click(object eventSender, EventArgs eventArgs)
        {
            Print_Renamed.PrintScreen(Bounds);
        }

        private void FormIandC_Activated(object eventSender, EventArgs eventArgs)
        {
            // Calculate()
        }

        private void optAries_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optAries.Checked)
            {
                txtDeg_TextChanged(txtDeg, new EventArgs());
                txtMin_TextChanged(txtMin, new EventArgs());
            }

            Calculate();
        }

        private void optMoon_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optMoon.Checked)
            {
                txtDeg_TextChanged(txtDeg, new EventArgs());
                txtMin_TextChanged(txtMin, new EventArgs());
            }

            Calculate();
        }

        private void optSunPlanets_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optSunPlanets.Checked)
            {
                txtDeg_TextChanged(txtDeg, new EventArgs());
                txtMin_TextChanged(txtMin, new EventArgs());
            }

            Calculate();
        }

        private void optFwd_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optFwd.Checked)
            {
                if (optFwd.Checked == true)
                {
                    txtv.Clear();
                    txtd.Clear();
                    txtUTm.Clear();
                    txtUTs.Clear();
                    txtUTm.ReadOnly = false;
                    txtUTs.ReadOnly = false;
                    txtv.ReadOnly = false;
                    txtd.ReadOnly = false;
                    txtUTm.Enabled = true;
                    txtUTs.Enabled = true;
                    txtv.Enabled = true;
                    txtd.Enabled = true;
                    txtDeg.Clear();
                    txtMin.Clear();
                    txtvcorr.Clear();
                    txtdcorr.Clear();
                    txtDeg.ReadOnly = true;
                    txtMin.ReadOnly = true;
                    txtvcorr.ReadOnly = true;
                    txtdcorr.ReadOnly = true;
                    txtDeg.Enabled = false;
                    txtMin.Enabled = false;
                    txtvcorr.Enabled = false;
                    txtdcorr.Enabled = false;
                    txtv.Visible = true;
                    txtd.Visible = true;
                    txtvcorr.Visible = true;
                    txtdcorr.Visible = true;
                    Label4.Visible = true;
                    Label5.Visible = true;
                    Label6.Visible = true;
                    Label10.Visible = true;
                    Label11.Visible = true;
                    Label12.Visible = true;
                    Label13.Visible = true;
                    Label14.Visible = true;
                }
            }
        }

        private void optBack_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optBack.Checked)
            {
                if (optBack.Checked == true)
                {
                    txtv.Clear();
                    txtd.Clear();
                    txtUTm.Clear();
                    txtUTs.Clear();
                    txtUTm.ReadOnly = true;
                    txtUTs.ReadOnly = true;
                    txtv.ReadOnly = true;
                    txtd.ReadOnly = true;
                    txtUTm.Enabled = false;
                    txtUTs.Enabled = false;
                    txtv.Enabled = false;
                    txtd.Enabled = false;
                    txtDeg.Clear();
                    txtMin.Clear();
                    txtvcorr.Clear();
                    txtdcorr.Clear();
                    txtDeg.ReadOnly = false;
                    txtMin.ReadOnly = false;
                    txtvcorr.ReadOnly = true;
                    txtdcorr.ReadOnly = true;
                    txtDeg.Enabled = true;
                    txtMin.Enabled = true;
                    txtvcorr.Enabled = false;
                    txtdcorr.Enabled = false;
                    txtv.Visible = false;
                    txtd.Visible = false;
                    txtvcorr.Visible = false;
                    txtdcorr.Visible = false;
                    Label4.Visible = false;
                    Label5.Visible = false;
                    Label6.Visible = false;
                    Label10.Visible = false;
                    Label11.Visible = false;
                    Label12.Visible = false;
                    Label13.Visible = false;
                    Label14.Visible = false;
                }
                // Calculate
            }
        }

        private void txtUTm_TextChanged(object eventSender, EventArgs eventArgs)
        {
            txtUTm.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtUTm.Text) > 59d)
            {
                txtUTm.BackColor = ColorTranslator.FromOle(0xFF);
                txtUTm.Focus();
                ErrorMsgBox("Out of Range");
                return;
            }
        }

        private void txtUTm_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        private void txtUTm_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtUTm.Text) > 59d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtUTm_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtUTm;
            SelectAllText(ref argTB);
            txtUTm = argTB;
        }

        private void txtUTs_TextChanged(object eventSender, EventArgs eventArgs)
        {
            txtUTs.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtUTs.Text) > 60d)
            {
                txtUTs.BackColor = ColorTranslator.FromOle(0xFF);
                txtUTs.Focus();
                ErrorMsgBox("Out of Range");
                return;
            }
            // Calculate()
        }

        private void txtUTs_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        private void txtUTs_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtUTs.Text) > 60d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtUTs_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtUTs;
            SelectAllText(ref argTB);
            txtUTs = argTB;
        }

        private void txtvd_TextChanged(object eventSender, EventArgs eventArgs)
        {
            txtv.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtv.Text) > 18d)
            {
                txtv.BackColor = ColorTranslator.FromOle(0xFF);
                txtv.Focus();
                ErrorMsgBox("Value must be <= 18");
                return;
            }
        }

        private void txtvd_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        if (Conversions.ToBoolean(Strings.InStr(txtv.Text, ".")))
                        {
                            if ((int)KeyAscii == 46)
                            {
                                KeyAscii = (short)0;
                                ;
                            }
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
                        KeyAscii = (short)0;
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

        private void txtvd_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtv.Text) > 18d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtvd_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtv;
            SelectAllText(ref argTB);
            txtv = argTB;
        }

        private void Calculate()
        {
            bool FlagV = false; // this and corr2k used for pre-2001 values of the four corrections that changed in 2001
            bool FlagD = false;
            double corr2kv = 0d;
            double corr2kd = 0d;
            txtvcorrx.Visible = false;
            txtdcorrx.Visible = false;
            txtvcorrx.Clear();
            txtdcorrx.Clear();
            if (optSunPlanets.Checked == false & optAries.Checked == false & optMoon.Checked == false & (optFwd.Checked == true & (!string.IsNullOrEmpty(txtUTm.Text) | !string.IsNullOrEmpty(txtUTs.Text) | !string.IsNullOrEmpty(txtv.Text)) | optBack.Checked == true & (!string.IsNullOrEmpty(txtDeg.Text) | !string.IsNullOrEmpty(txtMin.Text))))
            {
                ErrorMsgBox("You must select an object.");
                return;
            }

            if (optSunPlanets.Checked == true)
            {
                // k = 15
                k = CommonGlobals.g_SunPlanetsHrDeg;
            }

            if (optAries.Checked == true)
            {
                k = CommonGlobals.g_AriesHrDeg;
                // k = 15.04106864 ' same as value used in SRF FormSRF code
                // k = 15 + (36000 / 36535) / 24            '=15.0410677618... but this works
            }

            if (optMoon.Checked == true)
            {
                k = CommonGlobals.g_MoonHrDeg;
                // k = 14 + 19 / 60
            }

            if (optFwd.Checked == true) // optFwd is the UTC to GHA I&C conversion
            {
                // UTHrs  = (UTMin + UTSec/60)/60
                // GHA Incr = Body 1 hr Degrees Factor(k) * UTHrs 
                GHAIncrement = k * (Conversion.Val(txtUTm.Text) + Conversion.Val(txtUTs.Text) / 60d) / 60d;
                // Corr factor = Daily page factor * (UTMin + 0.5) / 60
                vcorr = Conversion.Val(txtv.Text) * (Conversion.Val(txtUTm.Text) + 0.5d) / 60d;
                dcorr = Conversion.Val(txtd.Text) * (Conversion.Val(txtUTm.Text) + 0.5d) / 60d;
                // Arcane rounding of vcorr and dcorr to make certain they match almanac values
                vcorr = Conversion.Int(vcorr * 10d + 0.50000000000001d) / 10d;
                dcorr = Conversion.Int(dcorr * 10d + 0.50000000000001d) / 10d;
                GHAIncrementDeg = (short)Conversion.Int(GHAIncrement);
                GHAIncrementMin = (GHAIncrement - GHAIncrementDeg) * 60d;
                GHAIncrementMin = Conversion.Int(GHAIncrementMin * 10d + 0.500000000001d) / 10d;
                if (Conversion.Val(txtUTm.Text) == 22d & Conversion.Val(txtv.Text) == 2.8d)
                {
                    vcorr = 1.0d;
                    corr2kv = 1.1d;
                    FlagV = true;
                }

                if (Conversion.Val(txtUTm.Text) == 22d & Conversion.Val(txtv.Text) == 16.4d)
                {
                    vcorr = 6.1d;
                    corr2kv = 6.2d;
                    FlagV = true;
                }

                if (Conversion.Val(txtUTm.Text) == 42d & Conversion.Val(txtv.Text) == 15.6d)
                {
                    vcorr = 11.1d;
                }

                if (Conversion.Val(txtUTm.Text) == 52d & Conversion.Val(txtv.Text) == 13.2d)
                {
                    vcorr = 11.6d;
                }

                if (Conversion.Val(txtUTm.Text) == 52d & Conversion.Val(txtv.Text) == 17.2d)
                {
                    vcorr = 15.1d;
                }

                if (Conversion.Val(txtUTm.Text) == 55d & Conversion.Val(txtv.Text) == 18d)
                {
                    vcorr = 16.7d;
                }

                if (Conversion.Val(txtUTm.Text) == 57d & Conversion.Val(txtv.Text) == 13.2d)
                {
                    vcorr = 12.7d;
                }

                if (Conversion.Val(txtUTm.Text) == 52d & Conversion.Val(txtv.Text) == 9.2d)
                {
                    corr2kv = 8.1d;
                    FlagV = true;
                }

                if (Conversion.Val(txtUTm.Text) == 52d & Conversion.Val(txtv.Text) == 16.4d)
                {
                    corr2kv = 14.4d;
                    FlagV = true;
                }

                if (Conversion.Val(txtUTm.Text) == 22d & Conversion.Val(txtd.Text) == 16.4d)
                {
                    dcorr = 6.1d;
                    corr2kd = 6.2d;
                    FlagD = true;
                }

                if (Conversion.Val(txtUTm.Text) == 42d & Conversion.Val(txtd.Text) == 15.6d)
                {
                    dcorr = 11.1d;
                }

                if (Conversion.Val(txtUTm.Text) == 52d & Conversion.Val(txtd.Text) == 13.2d)
                {
                    dcorr = 11.6d;
                }

                if (Conversion.Val(txtUTm.Text) == 52d & Conversion.Val(txtd.Text) == 17.2d)
                {
                    dcorr = 15.1d;
                }

                if (Conversion.Val(txtUTm.Text) == 55d & Conversion.Val(txtd.Text) == 18d)
                {
                    dcorr = 16.7d;
                }

                if (Conversion.Val(txtUTm.Text) == 57d & Conversion.Val(txtd.Text) == 13.2d)
                {
                    dcorr = 12.7d;
                }

                if (Conversion.Val(txtUTm.Text) == 52d & Conversion.Val(txtd.Text) == 9.2d)
                {
                    corr2kd = 8.1d;
                    FlagD = true;
                }

                if (Conversion.Val(txtUTm.Text) == 52d & Conversion.Val(txtd.Text) == 16.4d)
                {
                    corr2kd = 14.4d;
                    FlagD = true;
                }

                txtDeg.Text = GHAIncrementDeg.ToString("0", CultureInfo.CurrentCulture);
                txtMin.Text = GHAIncrementMin.ToString("00.0", CultureInfo.CurrentCulture);
                txtvcorr.Text = vcorr.ToString("0.0", CultureInfo.CurrentCulture);
                txtdcorr.Text = dcorr.ToString("0.0", CultureInfo.CurrentCulture);
                if (FlagV == true)
                {
                    txtvcorrx.Text = "v-corr value is Post-2001. Pre-2001 value is " + Strings.Format(corr2kv, "0.0");
                    txtvcorrx.Visible = true;
                }
                else
                {
                    txtvcorrx.Clear();
                    txtvcorrx.Visible = false;
                }

                if (FlagD == true)
                {
                    txtdcorrx.Text = "d-corr value is Post-2001. Pre-2001 value is " + Strings.Format(corr2kd, "0.0");
                    txtdcorrx.Visible = true;
                }
                else
                {
                    txtdcorrx.Clear();
                    txtdcorrx.Visible = false;
                }
            }

            if (optBack.Checked == true)
            {
                Time = 60d * (Conversion.Val(txtDeg.Text) + Conversion.Val(txtMin.Text) / 60d) / k;
                TimeMin = (short)Conversion.Int(Time);
                TimeSec = Conversion.Int((Time - TimeMin) * 60d + 0.5d);
                txtUTm.Text = TimeMin.ToString("0", CultureInfo.CurrentCulture);
                txtUTs.Text = TimeSec.ToString("00", CultureInfo.CurrentCulture);
                txtv.Clear();
                txtd.Clear();

                // txtIC.AppendText("Time " & Strings.Format(TimeMin, "0") & "m" & Strings.Format(TimeSec, "00") & g_LatS)
            }
        }

        private void txtDeg_TextChanged(object eventSender, EventArgs eventArgs)
        {
            txtDeg.BackColor = DefaultBackColor;
            if (optMoon.Checked == false & Conversion.Val(txtDeg.Text) > 15d | optMoon.Checked == true & Conversion.Val(txtDeg.Text) > 14d)
            {
                txtDeg.BackColor = Color.Red; // System.Drawing.ColorTranslator.FromOle(&HFF)
                txtDeg.Focus();
                ErrorMsgBox("Degree value must between 0 to 15 for Sun/Aries or Planets or 0 to 14 for Moon");
                return;
            }
        }

        private void txtDeg_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        private void txtDeg_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (optMoon.Checked == false & Conversion.Val(txtDeg.Text) > 15d | optMoon.Checked == true & Conversion.Val(txtDeg.Text) > 14d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtDeg_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtDeg;
            SelectAllText(ref argTB);
            txtDeg = argTB;
        }

        private void txtMin_TextChanged(object eventSender, EventArgs eventArgs)
        {
            txtMin.BackColor = DefaultBackColor;    // System.Drawing.ColorTranslator.FromOle(&H80000005)
            if (Conversion.Val(txtMin.Text) > 59.9d)
            {
                txtMin.BackColor = Color.Red;     // System.Drawing.ColorTranslator.FromOle(&HFF)
                ErrorMsgBox("Minutes value must be between 0 and 59.9");
                return;
            }

            if (optSunPlanets.Checked == true & Conversion.Val(txtDeg.Text) == 15d & Conversion.Val(txtMin.Text) != 0d)
            {
                txtMin.BackColor = Color.Red;     // System.Drawing.ColorTranslator.FromOle(&HFF)
                txtMin.Focus();
                ErrorMsgBox("For Sun/Planets and Degrees = 15, the Minutes value must be 0");
                return;
            }
            else if (optAries.Checked == true & Conversion.Val(txtDeg.Text) == 15d & Conversion.Val(txtMin.Text) > 2.5d)
            {
                txtMin.BackColor = Color.Red;     // System.Drawing.ColorTranslator.FromOle(&HFF)
                txtMin.Focus();
                ErrorMsgBox("For Aries and Degrees = 15, the Minutes must be 0");
                return;
            }
            else if (optMoon.Checked == true & Conversion.Val(txtDeg.Text) == 14d & Conversion.Val(txtMin.Text) > 19d)
            {
                txtMin.BackColor = Color.Red;     // System.Drawing.ColorTranslator.FromOle(&HFF)
                txtMin.Focus();
                ErrorMsgBox("For Moon and Degrees = 14, the Minutes must be <= 19");
                return;
            }

            return;
        }

        private void txtMin_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        if (Conversions.ToBoolean(Strings.InStr(txtMin.Text, ".")))
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

        private void txtMin_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtMin.Text) > 59.9d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            txtv.Clear();
            txtd.Clear();
            txtUTm.Clear();
            txtUTs.Clear();
            txtDeg.Clear();
            txtMin.Clear();
            txtvcorr.Clear();
            txtdcorr.Clear();
        }

        private void txtd_Enter(object sender, EventArgs e)
        {
            var argTB = txtd;
            SelectAllText(ref argTB);
            txtd = argTB;
        }

        private void txtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            short KeyAscii = (short)Strings.Asc(e.KeyChar);
            switch (KeyAscii)
            {
                case var @case when Strings.Asc("0") <= @case && @case <= Strings.Asc("9"):
                    {
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                case (short)('.'): // only allows one decimal point
                    {
                        if (Conversions.ToBoolean(Strings.InStr(txtd.Text, ".")))
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

            e.KeyChar = (char)KeyAscii;
            if (KeyAscii == 0)
            {
                e.Handled = true;
            }
        }

        private void txtd_TextChanged(object sender, EventArgs e)
        {
            txtd.BackColor = DefaultBackColor;   // System.Drawing.ColorTranslator.FromOle(&H80000005)
            if (Conversion.Val(txtd.Text) > 18d)
            {
                txtd.BackColor = Color.Red;    // System.Drawing.ColorTranslator.FromOle(&HFF)
                txtd.Focus();
                ErrorMsgBox("Value must be <= 18");
                return;
            }
        }

        private void txtd_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool KeepFocus = e.Cancel;
            if (Conversion.Val(txtd.Text) > 18d)
            {
                KeepFocus = true;
            }

            e.Cancel = KeepFocus;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtMin_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtMin;
            SelectAllText(ref argTB);
            txtMin = argTB;
        }

        private void FormIandC_FormClosed(object eventSender, FormClosedEventArgs eventArgs)
        {
            // Cleanup()
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