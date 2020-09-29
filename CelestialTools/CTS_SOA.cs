using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    internal partial class FormCTSSOA : Form
    {
        private int DesiredCourse;
        private double CurrentSet;
        private double CruisingSpeed, CurrentDrift;
        private double CTS;
        private double RequiredSpeed, SWC, SOA, Pi, SMG;
        private short SetComp;
        private string fnumeral;
        private short PortStarboard;
        private float CTSwithLeeway;
        private double Heading;
        private double CMG, x, y, CMGWithLeeway;

        private void cmdCalculate_Click(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtDriftAngle.Text) != 0d & cboWind.SelectedIndex == -1)
            {
                ErrorMsgBox("'Wind from' cannot be blank if 'Drift Angle' is not zero.");
                return;
            }

            Pi = Math.PI;
            CurrentSet = Conversion.Val(txtSet.Text);
            CurrentDrift = Conversion.Val(txtDrift.Text);
            CruisingSpeed = Conversion.Val(txtCS.Text);
            if (CruisingSpeed == 0d)
            {
                {
                    var withBlock = txtCS;
                    withBlock.Focus();
                }

                MessageBox.Show("Cruising Speed cannot be 0.");
                return;
            }

            if (optCTSSOA.Checked == true)
            {
                DesiredCourse = (int)Conversion.Val(txtDC.Text);
                SetComp = (short)(180d + CurrentSet);
                if (SetComp >= 360)
                {
                    SetComp = (short)(SetComp - 360);
                }

                SWC = CurrentDrift / CruisingSpeed * Math.Sin((SetComp - DesiredCourse) * Pi / 180d);
                if (Math.Abs(SWC) > 1d)
                {
                    txtWindCurrent.Clear();
                    txtWindCurrent.Text = "You cannot achieve the desired course under these conditions.";
                    Refresh();
                    return;
                }

                CTS = DesiredCourse + Math.Atan(SWC / Math.Sqrt(-SWC * SWC + 1d)) * 180d / Pi; // desired course + correction angle
                if (CTS < 0d)
                {
                    CTS = CTS + 360d;
                }

                if (CTS >= 360d)
                {
                    CTS = CTS - 360d;
                }

                SOA = CruisingSpeed * Math.Sqrt(1d - SWC * SWC) - CurrentDrift * Math.Cos((SetComp - DesiredCourse) * Pi / 180d);
                RequiredSpeed = (CruisingSpeed + CurrentDrift * Math.Cos((SetComp - DesiredCourse) * Pi / 180d)) / Math.Sqrt(1d - SWC * SWC);
                CTS = Conversion.Int(CTS + 0.5d);
                SOA = Conversion.Int(SOA * 10d + 0.5d) / 10d;
                RequiredSpeed = Conversion.Int(RequiredSpeed * 10d + 0.5d) / 10d;
                if (Conversion.Val(txtDriftAngle.Text) != 0d)
                {
                    PortStarboard = (short)(DesiredCourse - Convert.ToInt32(Conversion.Val(txtDriftAngle.Text)));
                }

                if (PortStarboard < 0)
                {
                    PortStarboard = (short)(PortStarboard + 360);
                }

                if (PortStarboard < 180)
                {
                    CTSwithLeeway = (float)(CTS - Conversion.Val(txtDriftAngle.Text));
                }
                else
                {
                    CTSwithLeeway = (float)(CTS + Conversion.Val(txtDriftAngle.Text));
                }

                if (cboWind.Text == "Port")
                {
                    CTSwithLeeway = (float)(CTS - Conversion.Val(txtDriftAngle.Text));
                }

                if (cboWind.Text == "Starboard")
                {
                    CTSwithLeeway = (float)(CTS + Conversion.Val(txtDriftAngle.Text));
                }

                CTSwithLeeway = (float)Conversion.Int(CTSwithLeeway + 0.5d);
                txtWindCurrent.Clear();
                txtWindCurrent.AppendText("Course to Steer (CTS) without leeway  " + Strings.Format(CTS, "000") + '°' + Constants.vbNewLine); // ; " *" '" True *"
                txtWindCurrent.AppendText("Course to Steer (CTS) with leeway       " + Strings.Format(CTSwithLeeway, "000") + '°' + Constants.vbNewLine); // ; " *" '" True *"
                txtWindCurrent.AppendText("Speed of Advance (SOA)  " + Strings.Format(SOA, "0.0") + " knots" + Constants.vbNewLine);
                txtWindCurrent.AppendText("Speed required to achieve planned cruising speed  " + Strings.Format(RequiredSpeed, "0.0") + " knots" + Constants.vbNewLine);
            }

            if (optCMGSMG.Checked == true)
            {
                Heading = Conversion.Val(txtDC.Text);
                x = CruisingSpeed * Math.Sin(Heading * Pi / 180d) + CurrentDrift * Math.Sin(CurrentSet * Pi / 180d);
                y = CruisingSpeed * Math.Cos(Heading * Pi / 180d) + CurrentDrift * Math.Cos(CurrentSet * Pi / 180d);
                SMG = Math.Sqrt(x * x + y * y);
                CMG = 90d - Math.Atan(y / x) * 180d / Pi;
                if (x < 0d)
                {
                    CMG = CMG + 180d;
                }

                if (CMG < 0d)
                {
                    CMG = CMG + 360d;
                }

                if (CMG >= 360d)
                {
                    CMG = CMG - 360d;
                }

                SMG = Conversion.Int(SMG * 10d + 0.5d) / 10d;
                CMG = Conversion.Int(CMG + 0.5d);
                if (Conversion.Val(txtDriftAngle.Text) != 0d)
                {
                    PortStarboard = (short)(CMG - Conversion.Val(txtDriftAngle.Text));
                }

                if (PortStarboard < 0)
                {
                    PortStarboard = (short)(PortStarboard + 360);
                }

                if (PortStarboard < 180)
                {
                    CMGWithLeeway = CMG + Conversion.Val(txtDriftAngle.Text);
                }
                else
                {
                    CMGWithLeeway = CMG - Conversion.Val(txtDriftAngle.Text);
                }

                if (cboWind.Text == "Port")
                {
                    CMGWithLeeway = CMG + Conversion.Val(txtDriftAngle.Text);
                }

                if (cboWind.Text == "Starboard")
                {
                    CMGWithLeeway = CMG - Conversion.Val(txtDriftAngle.Text);
                }

                CMGWithLeeway = Conversion.Int(CMGWithLeeway + 0.5d);
                txtWindCurrent.Clear();
                txtWindCurrent.AppendText("Course Made Good (CMG) without leeway " + Strings.Format(CMG, "000") + '°' + Constants.vbNewLine);
                txtWindCurrent.AppendText("Course Made Good (CMG) with leeway " + Strings.Format(CMGWithLeeway, "000") + '°' + Constants.vbNewLine);
                txtWindCurrent.AppendText("Speed Made Good (SMG)  " + Strings.Format(SMG, "0.0") + " knots" + Constants.vbNewLine);
            }

            Refresh();
        }

        private void cmdClear_Click(object eventSender, EventArgs eventArgs)
        {
            txtWindCurrent.Clear();
            txtDC.Text = "";
            txtCS.Text = "";
            txtSet.Text = "";
            txtDrift.Text = "";
            txtDriftAngle.Text = "";
            cboWind.SelectedIndex = -1;
            Refresh();
        }

        private void cmdPrint_Click(object eventSender, EventArgs eventArgs)
        {
            Print_Renamed.PrintScreen(Bounds);
        }

        private void FormCTSSOA_FormClosed(object eventSender, FormClosedEventArgs eventArgs)
        {
            // Cleanup()
        }

        private void Form_Initialize_Renamed()
        {
            Pi = Math.PI; // 4 * System.Math.Atan(1.0#)
            Label2.Visible = true;
            Label4.Visible = true;
            Label14.Visible = false;
            Label1.Visible = false;
        }

        private void optCTSSOA_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optCTSSOA.Checked)
            {
                Label2.Visible = true;
                Label4.Visible = true;
                Label14.Visible = false;
                Label1.Visible = false;
            }
        }

        private void optCMGSMG_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optCMGSMG.Checked)
            {
                Label2.Visible = false;
                Label4.Visible = false;
                Label14.Visible = true;
                Label1.Visible = true;
            }
        }

        private void txtCS_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtCS.Text) > 99.9d) // Or Val(txtCS.Text) < 0.1 Then
            {
                txtCS.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtCS.Text) <= 99.9d & Conversion.Val(txtCS.Text) >= 0.1d)
            {
                txtCS.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtCS_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        if (Conversions.ToBoolean(Strings.InStr(txtCS.Text, ".")))
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

        private void txtCS_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtCS.Text) > 99.9d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtCS_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtCS;
            SelectAllText(ref argTB);
            txtCS = argTB;
        }

        private void txtDC_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtDC.Text) > 359d)
            {
                txtDC.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtDC.Text) < 359d)
            {
                txtDC.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtDC_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        private void txtDC_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtDC.Text) > 359d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtDC_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtDC;
            SelectAllText(ref argTB);
            txtDC = argTB;
        }

        private void txtDrift_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtDrift.Text) > 99.9d)
            {
                txtDrift.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtDrift.Text) <= 99.9d)
            {
                txtDrift.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtDrift_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        if (Conversions.ToBoolean(Strings.InStr(txtDrift.Text, ".")))
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

        private void txtDrift_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtDrift.Text) > 99.9d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtDrift_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtDrift;
            SelectAllText(ref argTB);
            txtDrift = argTB;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            return;
        }

        private void txtDriftAngle_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtDriftAngle.Text) > 90d)
            {
                txtSet.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtSet.Text) <= 90d)
            {
                txtSet.BackColor = Control.DefaultBackColor; 
            }

            if (Conversion.Val(txtDriftAngle.Text) != 0d)
            {
                cboWind.Enabled = true;
            }
            else
            {
                cboWind.Enabled = false;
                cboWind.SelectedIndex = -1;
            }
        }

        private void txtDriftAngle_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        private void txtDriftAngle_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtDriftAngle.Text) > 90d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtDriftAngle_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtDriftAngle;
            SelectAllText(ref argTB);
            txtDriftAngle = argTB;
        }

        private void txtSet_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtSet.Text) > 359d)
            {
                txtSet.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtSet.Text) < 359d)
            {
                txtSet.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtSet_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

                case (short)('.'):
                    {
                        if (Conversions.ToBoolean(Strings.InStr(txtDrift.Text, ".")))
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

        private void txtSet_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtSet.Text) > 359d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtSet_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtSet;
            SelectAllText(ref argTB);
            txtSet = argTB;
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