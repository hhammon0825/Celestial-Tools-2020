using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    // Imports Microsoft.VisualBasic.Compatibility.VB6

    internal partial class Form60DST : Form
    {
        private double Speed, Distance, Time;
        private TimeSpan TSpan;
        private double TSpanDbl;
        private bool Flag1, Flag2;
        private string fnumeral;

        private void cmdClear_Click(object eventSender, EventArgs eventArgs)
        {
            // Cls
            txtDistance.Clear();
            txtSpeed.Clear();
            txtTime.Clear();
            txtd.Clear();
            txth.Clear();
            txtm.Clear();
            Flag1 = false;
            txtTime_TextChanged(txtTime, new EventArgs());
            txtd_TextChanged(txtd, new EventArgs());
            txth_TextChanged(txth, new EventArgs());
            txtm_TextChanged(txtm, new EventArgs());
            Refresh();
        }

        private void cmdPrint_Click(object eventSender, EventArgs eventArgs)
        {
            Print_Renamed.PrintScreen(Bounds);
        }

        private void cmdDistance_Click(object eventSender, EventArgs eventArgs)
        {
            Flag1 = true;
            if (!string.IsNullOrEmpty(txtTime.Text))
            {
                Distance = Conversion.Val(txtSpeed.Text) * Conversion.Val(txtTime.Text) / 60d;
            }

            if (string.IsNullOrEmpty(txtTime.Text))
            {
                Distance = Conversion.Val(txtSpeed.Text) * (Conversion.Val(txtd.Text) * 1440d + Conversion.Val(txth.Text) * 60d + Conversion.Val(txtm.Text)) / 60d;
            }

            if (Distance > 9999.9d)
            {
                txtDistance.Text = "------";
                ExceedsLimit();
                return;
            }

            txtDistance.Text = (Conversion.Int(Distance * 10d + 0.50000000000001d) / 10d).ToString("0.0");
            Flag1 = false;
        }

        private void cmdSpeed_Click(object eventSender, EventArgs eventArgs)
        {
            Flag1 = true;
            if (Conversion.Val(txtTime.Text) == 0d & Conversion.Val(txtd.Text) == 0d & Conversion.Val(txth.Text) == 0d & Conversion.Val(txtm.Text) == 0d)
            {
                ErrorMsgBox("Not enough or illegal inputs");
                return;
            }

            if (!string.IsNullOrEmpty(txtTime.Text))
                Speed = 60d * Conversion.Val(txtDistance.Text) / Conversion.Val(txtTime.Text);
            if (string.IsNullOrEmpty(txtTime.Text))
                Speed = 60d * Conversion.Val(txtDistance.Text) / (Conversion.Val(txtd.Text) * 1440d + Conversion.Val(txth.Text) * 60d + Conversion.Val(txtm.Text));
            if (Speed > 99.9d)
            {
                txtSpeed.Text = "-----";
                ExceedsLimit();
                return;
            }

            txtSpeed.Text = (Conversion.Int(Speed * 10d + 0.50000000000001d) / 10d).ToString("0.0");
            Flag1 = false;
        }

        private void cmdTime_Click(object eventSender, EventArgs eventArgs)
        {
            Flag1 = true;
            txtTime.Enabled = true;
            txtd.Enabled = true;
            txth.Enabled = true;
            txtm.Enabled = true;
            txtTime.BackColor = Control.DefaultBackColor;
            txth.BackColor = Control.DefaultBackColor; 
            txtm.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtSpeed.Text) == 0d)
            {
                ErrorMsgBox("Not enough or illegal inputs");
                return;
            }

            Time = 60d * Conversion.Val(txtDistance.Text) / Conversion.Val(txtSpeed.Text);
            if (Time > 59999d)
            {
                txtTime.Text = "-----";
                txth.Text = "---";
                txtm.Text = "--";
                ExceedsLimit();
                return;
            }

            TSpanDbl = Time + 0.50000000000001d;
            TSpan = TimeSpan.FromMinutes(TSpanDbl);
            txtTime.Text = Conversion.Int(TSpanDbl).ToString("0");
            txtd.Text = TSpan.Days.ToString("0");
            txth.Text = TSpan.Hours.ToString("0");
            txtm.Text = TSpan.Minutes.ToString("0");
            Flag1 = false;
        }

        private void txtTime_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Flag1 == true)
                return;
            Flag2 = true;
            if (!string.IsNullOrEmpty(txtTime.Text))
            {
                txtd.Enabled = false;
                txtd.BackColor = Color.Gray;  //Color.Gray; // : txtd.ForeColor = &H80000011
                txth.Enabled = false;
                txth.BackColor = Color.Gray; // : txth.ForeColor = &H80000011
                txtm.Enabled = false;
                txtm.BackColor = Color.Gray; // : txtm.ForeColor = &H80000011
                txtd.Clear();
                txth.Clear();
                txtm.Clear();
            }
            else
            {
                txtd.Enabled = true;
                txtd.BackColor = Control.DefaultBackColor;  // : txtd.ForeColor = &H80000005
                txth.Enabled = true;
                txth.BackColor = Control.DefaultBackColor;  // : txth.ForeColor = &H80000005
                txtm.Enabled = true;
                txtm.BackColor = Control.DefaultBackColor; 
            } // : txtm.ForeColor = &H80000005

            if (Conversion.Val(txtTime.Text) > 59999d)
            {
                txtTime.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtTime.Text) <= 59999d)
            {
                txtTime.BackColor = Control.DefaultBackColor; 
            }

            Flag2 = false;
        }

        private void txtTime_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        private void txtTime_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtTime.Text) > 59999d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtTime_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtTime;
            SelectAllText(ref argTB);
            txtTime = argTB;
        }

        private void txtd_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Flag1 == true)
                return;
            if (Flag2 == true)
                return;
            if (!string.IsNullOrEmpty(txtd.Text) | !string.IsNullOrEmpty(txth.Text) | !string.IsNullOrEmpty(txtm.Text))
            {
                txtTime.Enabled = false;
                txtTime.BackColor = Color.Gray; // : txtTime = ""
            }
            else
            {
                txtTime.Enabled = true;
                txtTime.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtd_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        private void txtd_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtd;
            SelectAllText(ref argTB);
            txtd = argTB;
        }

        private void txth_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Flag1 == true)
                return;
            if (Flag2 == true)
                return;
            // If txth.Enabled = False Then txth.Clear()
            if (!string.IsNullOrEmpty(txth.Text) | !string.IsNullOrEmpty(txtm.Text))
            {
                txtTime.Enabled = false;
                txtTime.BackColor = Color.Gray; // : txtTime = ""
            }
            else
            {
                txtTime.Enabled = true;
                txtTime.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txth_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        private void txth_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txth;
            SelectAllText(ref argTB);
            txth = argTB;
        }

        private void txtm_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Flag1 == true)
                return;
            if (Flag2 == true)
                return;
            // If txtm.Enabled = False Then txtm.Clear()
            if (!string.IsNullOrEmpty(txth.Text) | !string.IsNullOrEmpty(txtm.Text))
            {
                txtTime.Enabled = false;
                txtTime.BackColor = Color.Gray;
                txtTime.Clear();
            }
            else
            {
                txtTime.Enabled = true;
                txtTime.BackColor = Control.DefaultBackColor; 
            }

            if (Conversion.Val(txtm.Text) > 59d)
            {
                txtm.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtm.Text) <= 59d)
                txtm.BackColor = Control.DefaultBackColor; 
        }

        private void txtm_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        private void txtm_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtm.Text) > 59d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtm_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtm;
            SelectAllText(ref argTB);
            txtm = argTB;
        }

        private void txtDistance_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtDistance.Text) > 9999.9d)
            {
                txtDistance.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtDistance.Text) <= 9999.9d)
                txtDistance.BackColor = Control.DefaultBackColor; 
        }

        private void txtDistance_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        if (Conversions.ToBoolean(Strings.InStr(txtDistance.Text, ".")))
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

        private void txtDistance_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtDistance;
            SelectAllText(ref argTB);
            txtDistance = argTB;
        }

        private void txtSpeed_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtSpeed.Text) > 99.9d)
            {
                txtSpeed.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtSpeed.Text) <= 99.9d)
                txtSpeed.BackColor = Control.DefaultBackColor; 
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

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private static void ExceedsLimit()
        {
            ErrorMsgBox("Calculated value exceeds allowed limit.");
        }

        private void Form60DST_FormClosed(object eventSender, FormClosedEventArgs eventArgs)
        {
            // Cleanup()
        }

        private static void SelectAllText(ref TextBox TB)
        {
            TB.SelectionStart = 0;
            TB.SelectionLength = Strings.Len(TB.Text);
        }

        private static void ErrorMsgBox(string ErrMsg)
        {
            MessageBox.Show(ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            return;
        }
    }
}