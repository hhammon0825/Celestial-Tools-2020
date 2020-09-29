using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    internal partial class FormArcTime : Form
    {
        private int TimeHours;
        private double TimeMinutes;
        private double TimeSeconds;
        private double ArcDegrees;
        private double ArcMinutes;
        private double Lo;
        private int ConvertedTimeMinutes;
        private int ZM;
        private int ConvertedTimeHours;
        private int ConvertedTimeSeconds;

        public void cmdConvert_Click(object eventSender, EventArgs eventArgs)
        {
            var ConvertedTime = default(double);
            double TimeInSeconds;
            double Tdiff;
            double DLo;
            double ArcInDegrees;
            double DecimalHours;
            double timeinhours;
            double DecimalDegrees;
            if (optArcToTime.Checked == true)
            {
                DecimalDegrees = Conversion.Val(txtDeg.Text) + Conversion.Val(txtMin.Text) / 60d;
                timeinhours = DecimalDegrees / 15d;
                TimeHours = (int)Conversion.Int(timeinhours);
                TimeMinutes = (timeinhours - Conversion.Int(timeinhours)) * 60d;
                TimeSeconds = (TimeMinutes - Conversion.Int(TimeMinutes)) * 60d;
                TimeMinutes = Conversion.Int(TimeMinutes);
                TimeSeconds = Conversion.Int(TimeSeconds + 0.5d);
                if (TimeSeconds == 60d)
                {
                    TimeSeconds = 0d;
                    TimeMinutes = TimeMinutes + 1d;
                }

                if (TimeMinutes == 60d)
                {
                    TimeMinutes = 0d;
                    TimeHours = TimeHours + 1;
                }
                // If TimeHours = 24 Then TimeHours = 0
            }

            if (optTimeToArc.Checked == true)
            {
                // If Len(txtTime.Text) < 6 Then
                // txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
                // ErrorMsgBox("Invalid time entered - must be hhmmss format")
                // Exit Sub
                // End If
                DecimalHours = DTTime.Value.Hour + DTTime.Value.Minute / 60d + DTTime.Value.Second / 3600d;
                // DecimalHours = Val(VB.Left(txtTime.Text, 2)) + Val(Mid(txtTime.Text, 3, 2)) / 60 + Val(Mid(txtTime.Text, 5, 2)) / 3600
                ArcInDegrees = DecimalHours * 15d;
                ArcDegrees = Conversion.Int(ArcInDegrees);
                ArcMinutes = (ArcInDegrees - Conversion.Int(ArcInDegrees)) * 60d;
                ArcMinutes = Conversion.Int(ArcMinutes * 10d + 0.5d) / 10d;
            }

            ZDCalc();
            DLo = Lo - ZM;
            Tdiff = 240d * DLo; // seconds
                                // TimeInSeconds = (DTLMT.Value.Hour * 3600) + (DTLMT.Value.Minute * 60) + (DTLMT.Value.Second)
            var TimeTotSec = new TimeSpan(DTLMT.Value.Hour, DTLMT.Value.Minute, DTLMT.Value.Second);
            TimeInSeconds = TimeTotSec.TotalSeconds;
            // TimeInSeconds = 3600 * Val(VB.Left(txtTime2.Text, 2)) + 60 * Val(Mid(txtTime2.Text, 3, 2)) + Val(VB.Right(txtTime2.Text, 2))
            if (optLMTtoZT.Checked == true)
            {
                ConvertedTime = TimeInSeconds + Tdiff;
            }

            if (optZTtoLMT.Checked == true)
            {
                ConvertedTime = TimeInSeconds - Tdiff;
            }

            if (ConvertedTime > 86400d)
            {
                ConvertedTime = ConvertedTime - 86400d;
            }

            if (ConvertedTime < 0d)
            {
                ConvertedTime = ConvertedTime + 86400d;
            }

            ConvertedTimeHours = (int)Conversion.Int(ConvertedTime / 3600d);
            ConvertedTimeMinutes = (int)Conversion.Int((ConvertedTime - ConvertedTimeHours * 3600) / 60d);
            ConvertedTimeSeconds = (int)(ConvertedTime - ConvertedTimeHours * 3600 - ConvertedTimeMinutes * 60);
            ConvertedTimeSeconds = (int)Conversion.Int(ConvertedTimeSeconds + 0.5d);
            if (ConvertedTimeSeconds == 60)
            {
                ConvertedTimeSeconds = 0;
                ConvertedTimeMinutes = ConvertedTimeMinutes + 1;
            }

            if (ConvertedTimeMinutes == 60)
            {
                ConvertedTimeMinutes = 0;
                ConvertedTimeHours = TimeHours + 1;
            }

            Display();
        }

        private void cmdPrint_Click(object eventSender, EventArgs eventArgs)
        {
            Print_Renamed.PrintScreen(Bounds);
        }

        private void ZDCalc()
        {
            int ZD;
            Lo = Conversion.Val(txtLoDeg.Text) + Conversion.Val(txtLoMin.Text) / 60d;
            ZD = Convert.ToInt32(Lo / 15d + 0.5d);
            if (cboLo.Text == "E")
            {
                ZD = -ZD;
                Lo = -Lo;
            }

            ZM = Conversions.ToInteger(Operators.MultiplyObject(ZD, 15));
        }

        private void FormArcTime_Load(object eventSender, EventArgs eventArgs)
        {
            cboLo.SelectedIndex = 0; // g_LongW
            DTTime.Value = new DateTime(1901, 1, 1, 0, 0, 0);
            DTLMT.Value = new DateTime(1901, 1, 1, 0, 0, 0);
        }

        private void FormArcTime_FormClosed(object eventSender, FormClosedEventArgs eventArgs)
        {
            // Cleanup()
        }

        private void optArcToTime_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            {
                if (optArcToTime.Checked == true)
                {
                    txtDeg.Text = "";
                    txtMin.Text = "";
                    lblTime.Visible = false;
                    DTTime.Visible = false;
                    lblArc.Visible = true;
                    lblDeg.Visible = true;
                    lblMin.Visible = true;
                    txtDeg.Visible = true;
                    txtMin.Visible = true;
                    Refresh();
                }
            }
        }

        private void optLMTtoZT_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            {
                if (optLMTtoZT.Checked == true)
                {
                    // Cls()
                    lblLMT.Visible = true;
                    // DTLMT.Visible = True
                    lblZT.Visible = false;
                    Refresh();
                }
            }
        }

        private void optZTtoLMT_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            {
                if (optZTtoLMT.Checked == true)
                {
                    lblZT.Visible = true;
                    lblLMT.Visible = false;
                    // DTLMT.Visible = False
                    Refresh();
                }
            }
        }

        private void optTimeToArc_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
           {
                if (optTimeToArc.Checked == true)
                {
                    // txtTime.Text = ""
                    DTTime.Value = new DateTime(1901, 1, 1, 0, 0, 0);
                    lblTime.Visible = true;
                    DTTime.Visible = true;
                    lblArc.Visible = false;
                    lblDeg.Visible = false;
                    lblMin.Visible = false;
                    txtDeg.Visible = false;
                    txtMin.Visible = false;
                    Refresh();
                }
            }
        }

        private void txtDeg_TextChanged(object eventSender, EventArgs eventArgs)
        {
            txtDeg.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtDeg.Text) > 359d)
            {
                txtDeg.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }
        }

        private void txtDeg_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        private void txtDeg_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtDeg.Text) > 359d)
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
            txtMin.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtMin.Text) > 59.9d)
            {
                txtMin.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }
        }

        private void txtMin_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            short KeyAscii = (short)Strings.Asc(eventArgs.KeyChar);
            bool optHsDMS = false;
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
                        if (optHsDMS == true)
                        {
                            KeyAscii = 0;
                            Interaction.Beep();
                        }
                        else if (Conversions.ToBoolean(Strings.InStr(txtMin.Text, ".")))
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

        private void txtMin_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtMin.Text) > 59.9d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtMin_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtMin;
            SelectAllText(ref argTB);
            txtMin = argTB;
        }

        private void txtLoDeg_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtLoDeg.Text) != 180d)
                txtLoMin.Enabled = true;
            if (Conversion.Val(txtLoDeg.Text) == 180d)
            {
                txtLoMin.Text = "";
                txtLoMin.Enabled = false;
                txtLoMin.BackColor = Color.Gray;
            }

            txtLoDeg.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtLoDeg.Text) > 180d | Conversion.Val(txtLoDeg.Text) == 180d & Conversion.Val(txtLoMin.Text) != 0d)
            {
                txtLoDeg.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtLoDeg.Text) < 180d)
            {
                txtLoMin.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtLoDeg_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        private void txtLoDeg_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtLoDeg.Text) > 180d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtLoDeg_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtLoDeg;
            SelectAllText(ref argTB);
            txtLoDeg = argTB;
        }

        private void txtLoMin_TextChanged(object eventSender, EventArgs eventArgs)
        {
            txtLoMin.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtLoMin.Text) > 59.9d)
            {
                txtLoMin.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }
        }

        private void txtLoMin_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        if (Conversions.ToBoolean(Strings.InStr(txtLoMin.Text, ".")))
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

        private void txtLoMin_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtLoMin.Text) > 59.9d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtLoMin_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtLoMin;
            SelectAllText(ref argTB);
            txtLoMin = argTB;
        }

        // Private Sub txtTime_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        // txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)

        // If Len(txtTime.Text) = 6 And (Val(VB.Left(txtTime.Text, 2)) > 23 Or Val(Mid(txtTime.Text, 3, 2)) > 59 Or Val(Mid(txtTime.Text, 5, 2)) > 59) Then
        // txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
        // ErrorMsgBox("Invalid time entered - must be hhmmss format")
        // End If
        // End Sub

        // Private Sub txtTime_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
        // Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        // Dim fnumeral As String = vbNullString
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

        // Private Sub txtTime_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs)
        // Dim KeepFocus As Boolean = eventArgs.Cancel
        // If Len(txtTime.Text) < 6 Then
        // txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
        // ErrorMsgBox("Invalid time entered - must be hhmmss format")
        // Exit Sub
        // End If
        // If Val(VB.Left(txtTime.Text, 2)) > 23 Or Val(Mid(txtTime.Text, 3, 2)) > 59 Or Val(Mid(txtTime.Text, 5, 2)) > 59 Or Len(txtTime.Text) <> 6 Then
        // KeepFocus = True
        // End If
        // If Len(txtTime.Text) = 0 Then
        // KeepFocus = False
        // End If
        // eventArgs.Cancel = KeepFocus
        // End Sub
        // Private Sub txtTime_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        // txtTime.SelectAll()
        // Exit Sub
        // End Sub

        public void Display()
        {
            txtArcTime.Clear();
            txtLMTZT.Clear();
            if (optArcToTime.Checked == true & (!string.IsNullOrEmpty(txtDeg.Text) | !string.IsNullOrEmpty(txtMin.Text)))
            {
                txtArcTime.AppendText("Time         " + Strings.Format(TimeHours, "00") + "h" + Strings.Format(TimeMinutes, "00") + "m" + Strings.Format(TimeSeconds, "00") + CommonGlobals.g_LatS);
            }

            if (optTimeToArc.Checked == true)  // And txtTime.Text <> "" Then
            {
                txtArcTime.AppendText(" Arc          " + Strings.Format(ArcDegrees, "0") + '°' + Strings.Format(ArcMinutes, "00.0") + "'");
            }

            if (!string.IsNullOrEmpty(txtLoDeg.Text) | !string.IsNullOrEmpty(txtLoMin.Text)) // Or txtTime2.Text <> "" Then
            {
                if (optLMTtoZT.Checked == true)
                    txtLMTZT.AppendText("ZT         ");
                if (optZTtoLMT.Checked == true)
                    txtLMTZT.AppendText("LMT        ");
                txtLMTZT.AppendText(Strings.Format(ConvertedTimeHours, "00") + "h" + Strings.Format(ConvertedTimeMinutes, "00") + "m" + Strings.Format(ConvertedTimeSeconds, "00") + CommonGlobals.g_LatS + Constants.vbNewLine);
                txtLMTZT.AppendText("ZM            " + Math.Abs(ZM) + '°');
                if (ZM > 0)
                    txtLMTZT.AppendText(CommonGlobals.g_LongW);
                if (ZM < 0)
                    txtLMTZT.AppendText(CommonGlobals.g_LongE);
                if (ZM == 0)
                    txtLMTZT.AppendText("");
            }

            Refresh();
        }
        // Private Sub txtTime2_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        // txtTime2.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        // If Len(txtTime2.Text) = 6 And (Val(VB.Left(txtTime2.Text, 2)) > 23 Or Val(Mid(txtTime2.Text, 3, 2)) > 59 Or Val(Mid(txtTime2.Text, 5, 2)) > 59) Then
        // txtTime2.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
        // ErrorMsgBox("Out of Range")
        // End If
        // End Sub

        // Private Sub txtTime2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
        // Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        // Dim fnumeral As String = vbNullString
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

        // Private Sub txtTime2_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs)
        // Dim KeepFocus As Boolean = eventArgs.Cancel
        // If Val(VB.Left(txtTime2.Text, 2)) > 23 Or Val(Mid(txtTime2.Text, 3, 2)) > 59 Or Val(Mid(txtTime2.Text, 5, 2)) > 59 Or Len(txtTime2.Text) <> 6 Then
        // KeepFocus = True
        // End If
        // If Len(txtTime2.Text) = 0 Then
        // KeepFocus = False
        // End If
        // eventArgs.Cancel = KeepFocus
        // End Sub
        // Private Sub txtTime2_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        // SelectAllText(txtTime2)
        // End Sub

        private void SelectAllText(ref TextBox TB)
        {
            TB.SelectionStart = 0;
            TB.SelectionLength = Strings.Len(TB.Text);
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
            return;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            txtArcTime.Clear();
            txtLMTZT.Clear();
            txtDeg.Clear();
            txtMin.Clear();
            DTTime.Value = new DateTime(1901, 1, 1, 0, 0, 0);
            // txtTime.Clear()
            DTLMT.Value = new DateTime(1901, 1, 1, 0, 0, 0);
            txtLoDeg.Clear();
            txtLoMin.Clear();
            return;
        }

        private void ErrorMsgBox(string ErrMsg)
        {
            MessageBox.Show(ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            return;
        }
    }
}