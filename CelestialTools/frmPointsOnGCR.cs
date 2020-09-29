using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    internal partial class frmPointsOnGCR : Form
    {
        private void cmdPrint_Click(object eventSender, EventArgs eventArgs)
        {
            // FormHeight = PixelsToTwipsY(Me.Height)
            // FormWidth = PixelsToTwipsX(Me.Width)
            Print_Renamed.PrintScreen(Bounds);
        }

        private void cmdWaypoint_Click(object eventSender, EventArgs eventArgs)
        {
            double LPointMin;
            double LPointDeg;
            double LPoint;
            double LoPoint;
            double Lo2;
            double L2;
            double Lo1;
            double L1;
            double Pi;
            Pi = 4d * Math.Atan(1.0d);
            L1 = Conversion.Val(My.MyProject.Forms.FormSailings.txtL1Deg.Text) + Conversion.Val(My.MyProject.Forms.FormSailings.txtL1Min.Text) / 60d;
            if (My.MyProject.Forms.FormSailings.cboL1.Text == "S")
                L1 = -L1;
            Lo1 = Conversion.Val(My.MyProject.Forms.FormSailings.txtLo1Deg.Text) + Conversion.Val(My.MyProject.Forms.FormSailings.txtLo1Min.Text) / 60d;
            if (My.MyProject.Forms.FormSailings.cboLo1.Text == "E")
                Lo1 = -Lo1;
            L2 = Conversion.Val(My.MyProject.Forms.FormSailings.txtL2Deg.Text) + Conversion.Val(My.MyProject.Forms.FormSailings.txtL2Min.Text) / 60d;
            if (My.MyProject.Forms.FormSailings.cboL2.Text == "S")
                L2 = -L2;
            Lo2 = Conversion.Val(My.MyProject.Forms.FormSailings.txtLo2Deg.Text) + Conversion.Val(My.MyProject.Forms.FormSailings.txtLo2Min.Text) / 60d;
            if (My.MyProject.Forms.FormSailings.cboLo2.Text == "E")
                Lo2 = -Lo2;
            LoPoint = Conversion.Val(txtLoPointDeg.Text) + Conversion.Val(txtLoPointMin.Text) / 60d;
            if (cboLoPoint.Text == "E")
                LoPoint = -LoPoint;
            LPoint = Math.Atan((Math.Sin(L1 * Pi / 180d) * Math.Cos(L2 * Pi / 180d) * Math.Sin((LoPoint - Lo2) * Pi / 180d) - Math.Sin(L2 * Pi / 180d) * Math.Cos(L1 * Pi / 180d) * Math.Sin((LoPoint - Lo1) * Pi / 180d)) / (Math.Cos(L1 * Pi / 180d) * Math.Cos(L2 * Pi / 180d) * Math.Sin((Lo1 - Lo2) * Pi / 180d)));
            LPoint = LPoint * 180d / Pi;
            LPointDeg = Conversion.Int(Math.Abs(LPoint));
            LPointMin = (Math.Abs(LPoint) - LPointDeg) * 60d;
            if (Conversion.Int(LPointMin * 10d + 0.5d) / 10d == 60d)
            {
                LPointMin = 0d;
                LPointDeg = LPointDeg + 1d;
            }

            My.MyProject.Forms.FormSailings.cmdPoints_Click(null, new EventArgs());
            // txtGCR.AppendText(Strings.Format(LPointDeg, "0") & Chr(176) & Strings.Format(LPointMin, "00.0") & "'")
            // If LPoint > 0 Then
            // txtGCR.AppendText(g_LatN)
            // End If
            // If LPoint = 0 Then
            // txtGCR.AppendText(g_StrSpace)
            // End If
            // If LPoint < 0 Then
            // txtGCR.AppendText(g_LatS)
            // End If
            // txtGCR.AppendText(vbNewLine)
        }

        private void frmPointsOnGCR_Load(object eventSender, EventArgs eventArgs)
        {
            // Me.Left = TwipsToPixelsX((PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - PixelsToTwipsX(Me.Width)) / 2)
            // Me.Top = TwipsToPixelsY((PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - PixelsToTwipsY(Me.Height)) / 2)
            cboLoPoint.SelectedIndex = 0; // g_LongW
        }

        private void frmPointsOnGCR_FormClosed(object eventSender, FormClosedEventArgs eventArgs)
        {
            // Cleanup()
        }

        private void txtLoPointDeg_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtLoPointDeg.Text) != 180d)
                txtLoPointMin.Enabled = true;
            if (Conversion.Val(txtLoPointDeg.Text) == 180d)
            {
                txtLoPointMin.Text = "";
                txtLoPointMin.Enabled = false;
                txtLoPointMin.BackColor = Color.Gray;
            }
            // txtLoPointDeg.ForeColor = &H80000008
            txtLoPointDeg.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtLoPointDeg.Text) > 180d | Conversion.Val(txtLoPointDeg.Text) == 180d & Conversion.Val(txtLoPointMin.Text) != 0d)
            {
                txtLoPointDeg.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtLoPointDeg.Text) < 180d)
            {
                // txtLoPointMin.ForeColor = &H80000008
                txtLoPointMin.BackColor = Control.DefaultBackColor; 
                // txtLoPointMin.Text = "    "
            }
        }

        private void txtLoPointDeg_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            short KeyAscii = (short)Strings.Asc(eventArgs.KeyChar);
            string fnumeral = Constants.vbNullString;
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

        private void txtLoPointDeg_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtLoPointDeg.Text) > 180d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtLoPointDeg_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtLoPointDeg;
            SelectAllText(ref argTB);
            txtLoPointDeg = argTB;
        }

        private void txtLoPointMin_TextChanged(object eventSender, EventArgs eventArgs)
        {
            // txtLoPointMin.ForeColor = &H80000008
            txtLoPointMin.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtLoPointMin.Text) > 59.9d)
            {
                txtLoPointMin.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }
        }

        private void txtLoPointMin_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            short KeyAscii = (short)Strings.Asc(eventArgs.KeyChar);
            string fnumeral = Constants.vbNullString;
            switch (KeyAscii)
            {
                case var @case when Strings.Asc("0") <= @case && @case <= Strings.Asc("9"):
                    {
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                case (short)('.'): // only allows one decimal point
                    {
                        if (Conversions.ToBoolean(Strings.InStr(txtLoPointMin.Text, ".")))
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

        private void txtLoPointMin_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtLoPointMin.Text) > 59.9d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtLoPointMin_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtLoPointMin;
            SelectAllText(ref argTB);
            txtLoPointMin = argTB;
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

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}