using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    internal partial class FormNavMath : Form
    {
        // Dim U4, U2, U1, U3, U5 As Single
        private string fnumeral;
        private double Degrees, Time, DecimalMinutes;
        private double Angle3, Angle1, Angle2, result;
        private short ResultDeg;
        private float ResultMin;
        private string ResultMinute;
        private int Time1inSeconds;
        private float TimeResult;
        private short TimeResultHours, TimeResultMinutes, Days;
        private float T1Seconds;
        // Dim TimeInSeconds As Double ',H1 As Single, M1 As Single, S1 As Single, H2 As Single, M2 As Single, S2 As Single
        // Dim TimeMinutes, TimeDays, TimeHours, TimeSeconds As Single
        private double ZD1, Lo, ZD, ZD2;
        private string SignZD;
        private int ZD1inseconds, ZD2inseconds;
        private float UTinSeconds;
        // Dim S, H, D, M, As String
        // Dim LocADT As Date
        // Dim LocBDT As Date
        private bool LocADTPicked = false;
        // Dim TZA As TimeZoneInfo
        // Dim TZASelected As Boolean = False
        // Dim TZAID As String
        // Dim TZB As TimeZoneInfo
        // Dim TZBId As String
        private bool TZBSelected = false;

        private void cboZDm1_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            txtTimeResult.Clear();
            txtDays.Clear();
        }

        private void cboZDm2_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            txtTimeResult.Clear();
            txtDays.Clear();
        }

        private void chkDST1_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            txtTimeResult.Clear();
            txtDays.Clear();
        }

        private void chkDST2_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            txtTimeResult.Clear();
            txtDays.Clear();
        }

        // Private Sub cmdClear_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) 
        // txtC1.Clear()
        // txtC2.Clear()
        // txtC3.Clear()
        // txtR1.Clear()
        // txtR2.Clear()
        // txtR3.Clear()
        // txtK1.Clear()
        // txtK2.Clear()
        // txtK3.Clear()
        // txtK4.Clear()
        // txtU1.Clear()
        // txtU2.Clear()
        // txtU3.Clear()
        // txtU4.Clear()
        // txtU5.Clear()
        // End Sub

        private void cmdClearAddSubtract_Click(object eventSender, EventArgs eventArgs)
        {
            txtDeg1.Clear();
            txtMin1.Clear();
            txtDeg2.Clear();
            txtMin2.Clear();
            txtDeg3.Clear();
            txtMin3.Clear();
            txtResult.Clear();
        }

        private void cmdClearConverter_Click(object eventSender, EventArgs eventArgs)
        {
            txtHsDeg.Clear();
            txtHsMin.Clear();
            txtHsSec.Clear();
            // txtTime.Clear()
            txtAngle.Clear();
            txtConvertedTime.Clear();
            dtTime.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
        }

        private void cmdClearTZ_Click(object eventSender, EventArgs eventArgs)
        {
            txtLoDeg.Clear();
            txtLoMin.Clear();
            txtZD.Clear();
        }

        private void cmdConvert_Click(object eventSender, EventArgs eventArgs)
        {
            Degrees = Conversion.Val(txtHsDeg.Text) + Conversion.Val(txtHsMin.Text) / 60d + Conversion.Val(txtHsSec.Text) / 3600d;
            Degrees = Conversion.Int(Degrees * 100000d + 0.5d) / 100000d;
            // Time = Val(VB.Left(txtTime.Text, 2)) + Val(Mid(txtTime.Text, 3, 2)) / 60 + Val(VB.Right(txtTime.Text, 2)) / 3600
            Time = dtTime.Value.Hour + dtTime.Value.Minute / 60d + dtTime.Value.Second / 3600d;
            DecimalMinutes = dtTime.Value.Minute + dtTime.Value.Second / 60d;
            // DecimalMinutes = Val(Mid(txtTime.Text, 3, 2)) + Val(VB.Right(txtTime.Text, 2)) / 60
            // DecimalMinutes = Int(DecimalMinutes * 100000 + 0.5) / 100000
            // Time = Int(Time * 100000 + 0.5) / 100000
            txtAngle.Text = Conversion.Str(Degrees) + " degrees";
            txtConvertedTime.Text = Time.ToString("#0.00") + " h or " + dtTime.Value.Hour.ToString("#0") + " h " + DecimalMinutes.ToString("#0.00") + " m";
        }

        // Private Sub cmdInterpolate_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) 
        // txtU1.Clear() : txtU2.Clear() : txtU3.Clear() : txtU4.Clear() : txtU5.Clear()
        // If txtK1.Text = "" Then ErrorMsgBox("Not enough data.") : Exit Sub
        // If txtK2.Text = "" And txtK3.Text = "" Then ErrorMsgBox("Not enough data.") : Exit Sub
        // If Val(txtC1.Text) = Val(txtC3.Text) And txtC1.Text <> "" Then ErrorMsgBox("Check for incorrect C value(s).") : Exit Sub
        // If Val(txtC1.Text) < Val(txtC3.Text) And (Val(txtC2.Text) <= Val(txtC1.Text) Or Val(txtC2.Text) >= Val(txtC3.Text)) Then ErrorMsgBox("Check for incorrect C value(s).") : Exit Sub
        // If Val(txtC1.Text) > Val(txtC3.Text) And (Val(txtC2.Text) <= Val(txtC3.Text) Or Val(txtC2.Text) >= Val(txtC1.Text)) Then ErrorMsgBox("Check for incorrect C value(s).") : Exit Sub
        // If Val(txtR1.Text) = Val(txtR3.Text) And txtR1.Text <> "" Then ErrorMsgBox("Check for incorrect R value(s).") : Exit Sub
        // If Val(txtR1.Text) < Val(txtR3.Text) And (Val(txtR2.Text) <= Val(txtR1.Text) Or Val(txtR2.Text) >= Val(txtR3.Text)) Then ErrorMsgBox("Check for incorrect R value(s).") : Exit Sub
        // If Val(txtR1.Text) > Val(txtR3.Text) And (Val(txtR2.Text) <= Val(txtR3.Text) Or Val(txtR2.Text) >= Val(txtR1.Text)) Then ErrorMsgBox("Check for incorrect R value(s).") : Exit Sub
        // If txtK4.Text = "" And (txtK2.Text = "" Or txtK3.Text = "") Then InterpType = "Single" Else InterpType = "Double"
        // If InterpType = "Double" Then
        // If Val(txtK1.Text) < Val(txtK2.Text) And Val(txtK3.Text) > Val(txtK4.Text) Then ErrorMsgBox("Check for incorrect K value(s).") : Exit Sub
        // If Val(txtK1.Text) > Val(txtK2.Text) And Val(txtK3.Text) < Val(txtK4.Text) Then ErrorMsgBox("Check for incorrect K value(s).") : Exit Sub
        // If Val(txtK1.Text) < Val(txtK3.Text) And Val(txtK2.Text) > Val(txtK4.Text) Then ErrorMsgBox("Check for incorrect K value(s).") : Exit Sub
        // If Val(txtK1.Text) > Val(txtK2.Text) And Val(txtK2.Text) < Val(txtK4.Text) Then ErrorMsgBox("Check for incorrect K value(s).") : Exit Sub
        // If txtC1.Text = "" Or txtC2.Text = "" Or txtC3.Text = "" Or txtR1.Text = "" Or txtR2.Text = "" Or txtR3.Text = "" Then ErrorMsgBox("Not enough data.") : Exit Sub
        // U1 = (Val(txtC2.Text) - Val(txtC1.Text)) * (Val(txtK3.Text) - Val(txtK1.Text)) / (Val(txtC3.Text) - Val(txtC1.Text))
        // U1 = Val(txtK1.Text) + U1
        // U1 = System.Math.Sign(U1) * Int(System.Math.Abs(U1) * 100000 + 0.5) / 100000                 'Int(U1 * 100000 + 0.5) / 100000  Changed in V5.5.0
        // U2 = (Val(txtC2.Text) - Val(txtC1.Text)) * (Val(txtK4.Text) - Val(txtK2.Text)) / (Val(txtC3.Text) - Val(txtC1.Text))
        // U2 = Val(txtK2.Text) + U2
        // U2 = System.Math.Sign(U2) * Int(System.Math.Abs(U2) * 100000 + 0.5) / 100000                 'Int(U2 * 100000 + 0.5) / 100000  Changed in V5.5.0
        // txtU1.Text = Str(U1)
        // txtU2.Text = Str(U2)
        // U3 = (Val(txtR2.Text) - Val(txtR1.Text)) * (Val(txtK2.Text) - Val(txtK1.Text)) / (Val(txtR3.Text) - Val(txtR1.Text))
        // U3 = Val(txtK1.Text) + U3
        // U3 = System.Math.Sign(U3) * Int(System.Math.Abs(U3) * 100000 + 0.5) / 100000                'Int(U3 * 100000 + 0.5) / 100000  Changed in V5.5.0
        // U4 = (Val(txtR2.Text) - Val(txtR1.Text)) * (Val(txtK4.Text) - Val(txtK3.Text)) / (Val(txtR3.Text) - Val(txtR1.Text))
        // U4 = Val(txtK3.Text) + U4
        // U4 = System.Math.Sign(U4) * Int(System.Math.Abs(U4) * 100000 + 0.5) / 100000                'Int(U4 * 100000 + 0.5) / 100000  Changed in V5.5.0
        // U5 = (Val(txtC2.Text) - Val(txtC1.Text)) * (U4 - U3) / (Val(txtC3.Text) - Val(txtC1.Text))
        // U5 = U3 + U5
        // U5 = System.Math.Sign(U5) * Int(System.Math.Abs(U5) * 100000 + 0.5) / 100000                'Int(U5 * 100000 + 0.5) / 100000  Changed in V5.5.0
        // txtU3.Text = Str(U3)
        // txtU4.Text = Str(U4)
        // txtU5.Text = Str(U5)
        // 'End If
        // End If
        // If InterpType = "Single" Then
        // If txtK2.Text = "" And txtK4.Text = "" Then 'Across
        // If txtC1.Text = "" Or txtC2.Text = "" Or txtC3.Text = "" Then ErrorMsgBox("Not enough data.") : Exit Sub
        // U1 = (Val(txtC2.Text) - Val(txtC1.Text)) * (Val(txtK3.Text) - Val(txtK1.Text)) / (Val(txtC3.Text) - Val(txtC1.Text))
        // U1 = Val(txtK1.Text) + U1
        // U1 = System.Math.Sign(U1) * Int(System.Math.Abs(U1) * 100000 + 0.5) / 100000                'Int(U1 * 100000 + 0.5) / 100000  Changed in V5.5.0
        // txtU1.Text = Str(U1)
        // End If
        // If txtK3.Text = "" And txtK4.Text = "" Then 'Down
        // If txtR1.Text = "" Or txtR2.Text = "" Or txtR3.Text = "" Then ErrorMsgBox("Not enough data.") : Exit Sub
        // U3 = (Val(txtR2.Text) - Val(txtR1.Text)) * (Val(txtK2.Text) - Val(txtK1.Text)) / (Val(txtR3.Text) - Val(txtR1.Text))
        // U3 = Val(txtK1.Text) + U3
        // U3 = System.Math.Sign(U3) * Int(System.Math.Abs(U3) * 100000 + 0.5) / 100000                'Int(U3 * 100000 + 0.5) / 100000  Changed in V5.5.0
        // txtU3.Text = Str(U3)
        // End If
        // End If
        // End Sub

        private void cmdPrint_Click(object eventSender, EventArgs eventArgs)
        {
            Print_Renamed.PrintScreen(Bounds);
        }

        private void optAdd1_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optAdd1.Checked)
            {
                // Calculate()
            }
        }

        private void optAdd2_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optAdd2.Checked)
            {
                // Calculate()
            }
        }

        private void optAddTimes_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optAddTimes.Checked)
            {
                // txtCalcTime1.Clear()
            }
        }

        private void optAddToD_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optAddToD.Checked)
            {
                txtTimeResult.Clear();
                txtDays.Clear();
            }
        }

        private void optHsDMm_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optHsDMm.Checked)
            {
                if (optHsDMm.Checked == true)
                {
                    txtHsSec.Visible = false;
                    lblHsSec.Visible = false;
                    txtHsMin.Clear();
                    txtHsSec.Clear();
                }
            }
        }

        private void optHsDMS_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optHsDMS.Checked)
            {
                if (optHsDMS.Checked == true)
                {
                    txtHsSec.Visible = true;
                    lblHsSec.Visible = true;
                    txtHsMin.Clear();
                    txtHsSec.Clear();
                }
            }
        }

        private void optSubtract1_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optSubtract1.Checked)
            {
                // Calculate()
            }
        }

        private void optSubtract2_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optSubtract2.Checked)
            {
                // Calculate()
            }
        }

        private void optSubtractTimes_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optSubtractTimes.Checked)
                {

                }
            {
                // txtCalcTime1.Clear()

            }
        }

        private void optSubtractToD_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optSubtractToD.Checked)
            {
                txtTimeResult.Clear();
                txtDays.Clear();
            }
        }

        // Private Sub txtC1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) 
        // Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        // Select Case KeyAscii
        // Case Asc("0") To Asc("9")
        // fnumeral = fnumeral & Chr(KeyAscii)
        // Case Asc(".") 'only allows one decimal point
        // If InStr(txtC1.Text, ".") Then
        // If KeyAscii = 46 Then KeyAscii = 0 : Beep()
        // End If
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
        // Private Sub txtC1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) 
        // SelectAllText(txtC1)
        // End Sub

        // Private Sub txtC2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) 
        // Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        // Select Case KeyAscii
        // Case Asc("0") To Asc("9")
        // fnumeral = fnumeral & Chr(KeyAscii)
        // Case Asc(".") 'only allows one decimal point
        // If InStr(txtC2.Text, ".") Then
        // If KeyAscii = 46 Then KeyAscii = 0 : Beep()
        // End If
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
        // Private Sub txtC2_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) 
        // SelectAllText(txtC2)
        // End Sub

        // Private Sub txtC3_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) 
        // Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        // Select Case KeyAscii
        // Case Asc("0") To Asc("9")
        // fnumeral = fnumeral & Chr(KeyAscii)
        // Case Asc(".") 'only allows one decimal point
        // If InStr(txtC3.Text, ".") Then
        // If KeyAscii = 46 Then KeyAscii = 0 : Beep()
        // End If
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
        // Private Sub txtC3_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) 
        // SelectAllText(txtC3)
        // End Sub

        private void txtHsDeg_TextChanged(object eventSender, EventArgs eventArgs)
        {
        }

        private void txtHsDeg_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        private void txtHsDeg_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            eventArgs.Cancel = KeepFocus;
        }

        private void txtHsDeg_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtHsDeg;
            SelectAllText(ref argTB);
            txtHsDeg = argTB;
        }

        private void txtHsMin_TextChanged(object eventSender, EventArgs eventArgs)
        {
            txtHsMin.BackColor = Control.DefaultBackColor; 
            if (optHsDMm.Checked == true & Conversion.Val(txtHsMin.Text) > 59.9d)
            {
                txtHsMin.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (optHsDMS.Checked == true & Conversion.Val(txtHsMin.Text) > 59d)
            {
                txtHsMin.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }
        }

        private void txtHsMin_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        if (optHsDMS.Checked == true)
                        {
                            KeyAscii = 0;
                            Interaction.Beep();
                        }
                        else if (Conversions.ToBoolean(Strings.InStr(txtHsMin.Text, ".")))
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

        private void txtHsMin_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (optHsDMm.Checked == true & Conversion.Val(txtHsMin.Text) > 59.9d)
            {
                KeepFocus = true;
            }

            if (optHsDMS.Checked == true & Conversion.Val(txtHsMin.Text) > 59d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtHsMin_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtHsMin;
            SelectAllText(ref argTB);
            txtHsMin = argTB;
        }

        private void txtHsSec_TextChanged(object eventSender, EventArgs eventArgs)
        {
            txtHsSec.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtHsSec.Text) > 59d)
            {
                txtHsSec.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }
        }

        private void txtHsSec_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        private void txtHsSec_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtHsSec.Text) > 59d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtHsSec_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtHsSec;
            SelectAllText(ref argTB);
            txtHsSec = argTB;
        }

        // Private Sub txtK1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) 
        // Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        // bool MinusSignAlready = false ;
        // bMinusSignAlready = False
        // Select Case KeyAscii
        // Case System.Windows.Forms.Keys.Back, System.Windows.Forms.Keys.Right, System.Windows.Forms.Keys.Left
        // 'do nothing
        // Case Asc("0") To Asc("9")
        // fnumeral = fnumeral & Chr(KeyAscii)
        // Case Asc("-")
        // If txtK1.SelectionStart <> 0 Or bMinusSignAlready Then
        // KeyAscii = 0
        // Beep()
        // Else
        // bMinusSignAlready = True
        // End If

        // Case Asc(".") 'only allows one decimal point
        // If InStr(txtK1.Text, ".") Then
        // If KeyAscii = 46 Then KeyAscii = 0 : Beep()
        // End If
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
        // Private Sub txtK1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) 
        // SelectAllText(txtK1)
        // End Sub

        // Private Sub txtK2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) 
        // Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        // bool MinusSignAlready = false ;
        // bMinusSignAlready = False
        // Select Case KeyAscii
        // Case Asc("0") To Asc("9")
        // fnumeral = fnumeral & Chr(KeyAscii)
        // Case Asc("-")
        // If txtK2.SelectionStart <> 0 Or bMinusSignAlready Then
        // KeyAscii = 0
        // Beep()
        // Else
        // bMinusSignAlready = True
        // End If

        // Case Asc(".") 'only allows one decimal point
        // If InStr(txtK2.Text, ".") Then
        // If KeyAscii = 46 Then KeyAscii = 0 : Beep()
        // End If
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
        // Private Sub txtK2_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) 
        // SelectAllText(txtK2)
        // End Sub

        // Private Sub txtK3_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) 
        // Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        // bool MinusSignAlready = false ;
        // bMinusSignAlready = False
        // Select Case KeyAscii
        // Case Asc("0") To Asc("9")
        // fnumeral = fnumeral & Chr(KeyAscii)
        // Case Asc("-")
        // If txtK3.SelectionStart <> 0 Or bMinusSignAlready Then
        // KeyAscii = 0
        // Beep()
        // Else
        // bMinusSignAlready = True
        // End If

        // Case Asc(".") 'only allows one decimal point
        // If InStr(txtK3.Text, ".") Then
        // If KeyAscii = 46 Then KeyAscii = 0 : Beep()
        // End If
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
        // Private Sub txtK3_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) 
        // SelectAllText(txtK3)
        // End Sub

        // Private Sub txtK4_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) 

        // End Sub
        // Private Sub txtK4_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) 
        // SelectAllText(txtK4)
        // End Sub

        // Private Sub txtR1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) 
        // Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        // Select Case KeyAscii
        // Case Asc("0") To Asc("9")
        // fnumeral = fnumeral & Chr(KeyAscii)
        // Case Asc(".") 'only allows one decimal point
        // If InStr(txtR1.Text, ".") Then
        // If KeyAscii = 46 Then KeyAscii = 0 : Beep()
        // End If
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
        // Private Sub txtR1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) 
        // SelectAllText(txtR1)
        // End Sub

        // Private Sub txtR2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) 
        // Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        // Select Case KeyAscii
        // Case Asc("0") To Asc("9")
        // fnumeral = fnumeral & Chr(KeyAscii)
        // Case Asc(".") 'only allows one decimal point
        // If InStr(txtR2.Text, ".") Then
        // If KeyAscii = 46 Then KeyAscii = 0 : Beep()
        // End If
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
        // Private Sub txtR2_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) 
        // SelectAllText(txtR2)
        // End Sub

        // Private Sub txtR3_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) 
        // Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        // Select Case KeyAscii
        // Case Asc("0") To Asc("9")
        // fnumeral = fnumeral & Chr(KeyAscii)
        // Case Asc(".") 'only allows one decimal point
        // If InStr(txtR3.Text, ".") Then
        // If KeyAscii = 46 Then KeyAscii = 0 : Beep()
        // End If
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
        // Private Sub txtR3_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) 
        // SelectAllText(txtR3)
        // End Sub

        private void FormNavMath_Load(object eventSender, EventArgs eventArgs)
        {
            cboLo.SelectedIndex = 0; // g_LongW
            cboZDm1.SelectedIndex = 0; // "00"
            cboZDm2.SelectedIndex = 0; // "00"
            LocADTPicked = false;
            dtTime.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            // lblLocB.Visible = False
            // Dim LocACollection As ObjectModel.ReadOnlyCollection(Of TimeZoneInfo) = TimeZoneInfo.GetSystemTimeZones
            // For Each TZT As TimeZoneInfo In LocACollection 'TimeZoneInfo.GetSystemTimeZones
            // cbLocAZD.Items.Add(TZT)
            // cbLocBZone.Items.Add(TZT)
            // Next

            // cbLocAZD.SelectedIndex = 0
            // cbLocBZone.SelectedIndex = 0

        }

        private void FormNavMath_FormClosed(object eventSender, FormClosedEventArgs eventArgs)
        {
            // Cleanup()
        }

        // Private Sub txtTime_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        // 'txtTime.ForeColor = &H80000008
        // txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        // If Len(txtTime.Text) = 6 And Val(Mid(txtTime.Text, 3, 2)) > 59 Or Val(Mid(txtTime.Text, 5, 2)) > 59 Then '(Val(Left(txtTime.Text, 2)) > 99 Or
        // txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
        // ErrorMsgBox("Out of Range")
        // End If
        // End Sub

        // Private Sub txtTime_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
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

        // Private Sub txtTime_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs)
        // Dim KeepFocus As Boolean = eventArgs.Cancel
        // If Val(Mid(txtTime.Text, 3, 2)) > 59 Or Val(Mid(txtTime.Text, 5, 2)) > 59 Or Len(txtTime.Text) <> 6 Then 'Val(Left(txtTime.Text, 2)) > 23 Or
        // KeepFocus = True
        // End If
        // If Len(txtTime.Text) = 0 Then
        // KeepFocus = False
        // End If
        // eventArgs.Cancel = KeepFocus
        // End Sub
        // Private Sub txtTime_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        // SelectAllText(txtTime)
        // End Sub

        private void AddSubtractCalculate()
        {
            Angle1 = Conversion.Val(txtDeg1.Text) + Conversion.Val(txtMin1.Text) / 60d;
            Angle2 = Conversion.Val(txtDeg2.Text) + Conversion.Val(txtMin2.Text) / 60d;
            Angle3 = Conversion.Val(txtDeg3.Text) + Conversion.Val(txtMin3.Text) / 60d;
            if (optAdd1.Checked == true & optAdd2.Checked == true)
                result = Angle1 + Angle2 + Angle3;
            if (optAdd1.Checked == true & optSubtract2.Checked == true)
                result = Angle1 + Angle2 - Angle3;
            if (optSubtract1.Checked == true & optAdd2.Checked == true)
                result = Angle1 - Angle2 + Angle3;
            if (optSubtract1.Checked == true & optSubtract2.Checked == true)
                result = Angle1 - Angle2 - Angle3;
            while (result >= 360d)
                result = result - 360d;
            while (result < 0d)
                result = result + 360d;
            ResultDeg = (short)Conversion.Int(result);
            ResultMin = (float)((result - ResultDeg) * 60d);
            ResultMin = (float)(Conversion.Int(ResultMin * 10f + 0.5d) / 10d);
            ResultMinute = Strings.Format(ResultMin, "00.0");
            txtResult.Text = Conversion.Str(ResultDeg) + '°' + ResultMinute + "'";
        }

        private void optAdd_Click()
        {
            // Calculate()
        }

        private void optSubtract_Click()
        {
            // Calculate()
        }

        private void txtDeg1_TextChanged(object eventSender, EventArgs eventArgs)
        {
            // Calculate()
        }

        private void txtDeg1_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        private void txtDeg1_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            eventArgs.Cancel = KeepFocus;
        }

        private void txtDeg1_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtDeg1;
            SelectAllText(ref argTB);
            txtDeg1 = argTB;
        }

        private void txtMin1_TextChanged(object eventSender, EventArgs eventArgs)
        {
            txtMin1.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtMin1.Text) > 59.9d)
            {
                txtMin1.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }
            // Calculate()
        }

        private void txtMin1_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        if (Conversions.ToBoolean(Strings.InStr(txtMin1.Text, ".")))
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

        private void txtMin1_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtMin1.Text) > 59.9d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtMin1_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtMin1;
            SelectAllText(ref argTB);
            txtMin1 = argTB;
        }

        private void txtDeg2_TextChanged(object eventSender, EventArgs eventArgs)
        {
            // Calculate()
        }

        private void txtDeg2_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        private void txtDeg2_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            eventArgs.Cancel = KeepFocus;
        }

        private void txtDeg2_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtDeg2;
            SelectAllText(ref argTB);
            txtDeg2 = argTB;
        }

        private void txtMin2_TextChanged(object eventSender, EventArgs eventArgs)
        {
            txtMin2.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtMin2.Text) > 59.9d)
            {
                txtMin2.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }
            // Calculate()
        }

        private void txtMin2_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        if (Conversions.ToBoolean(Strings.InStr(txtMin2.Text, ".")))
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

        private void txtMin2_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtMin2.Text) > 59.9d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtMin2_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtMin2;
            SelectAllText(ref argTB);
            txtMin2 = argTB;
        }

        private void txtDeg3_TextChanged(object eventSender, EventArgs eventArgs)
        {
            // Calculate()
        }

        private void txtDeg3_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        private void txtDeg3_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            eventArgs.Cancel = KeepFocus;
        }

        private void txtDeg3_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtDeg3;
            SelectAllText(ref argTB);
            txtDeg3 = argTB;
        }

        private void txtMin3_TextChanged(object eventSender, EventArgs eventArgs)
        {
            // txtMin2.ForeColor = &H80000008
            txtMin3.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtMin3.Text) > 59.9d)
            {
                txtMin2.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }
            // Calculate()
        }

        private void txtMin3_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        if (Conversions.ToBoolean(Strings.InStr(txtMin3.Text, ".")))
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

        private void txtMin3_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtMin3.Text) > 59.9d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtMin3_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtMin3;
            SelectAllText(ref argTB);
            txtMin3 = argTB;
        }

        private void txtTime1_TextChanged(object eventSender, EventArgs eventArgs)
        {
            txtTimeResult.Clear();
            txtDays.Clear();
            txtTime1.BackColor = Control.DefaultBackColor; 
            if (Strings.Len(txtTime1.Text) == 4 & (Conversion.Val(Strings.Left(txtTime1.Text, 2)) > 23d | Conversion.Val(Strings.Right(txtTime1.Text, 2)) > 59d))
            {
                txtTime1.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }
        }

        private void txtTime1_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
        }

        private void txtTime1_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            // If Val(Left(txtTime1.text, 2)) > 23 Or Val(Mid(txtTime1.text, 3, 2)) > 59 Or Val(Mid(txtTime1.text, 5, 2)) > 59 Or Len(txtTime1) <> 6 Then
            if (Conversion.Val(Strings.Left(txtTime1.Text, 2)) > 23d | Conversion.Val(Strings.Right(txtTime1.Text, 2)) > 59d | Strings.Len(txtTime1.Text) != 4)
            {
                KeepFocus = true;
            }

            if (Strings.Len(txtTime1.Text) == 0)
            {
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

        private void txtIntD_TextChanged(object eventSender, EventArgs eventArgs)
        {
            txtTimeResult.Clear();
            txtDays.Clear();
        }

        private void txtIntD_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        if (Conversions.ToBoolean(Strings.InStr(txtIntD.Text, ".")))
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

        private void txtIntD_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtIntD;
            SelectAllText(ref argTB);
            txtIntD = argTB;
        }

        private void txtIntH_TextChanged(object eventSender, EventArgs eventArgs)
        {
            txtTimeResult.Clear();
            txtDays.Clear();
        }

        private void txtIntH_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        if (Conversions.ToBoolean(Strings.InStr(txtIntH.Text, ".")))
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

        private void txtIntH_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtIntH;
            SelectAllText(ref argTB);
            txtIntH = argTB;
        }

        private void txtIntM_TextChanged(object eventSender, EventArgs eventArgs)
        {
            txtTimeResult.Clear();
            txtDays.Clear();
        }

        private void txtIntM_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        if (Conversions.ToBoolean(Strings.InStr(txtIntM.Text, ".")))
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

        private void txtIntM_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtIntM;
            SelectAllText(ref argTB);
            txtIntM = argTB;
        }

        private void txtZDh1_TextChanged(object eventSender, EventArgs eventArgs)
        {
            txtTimeResult.Clear();
            txtDays.Clear();
            // txtZDh.ForeColor = &H80000008
            txtZDh1.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtZDh1.Text) < -13 | Conversion.Val(txtZDh1.Text) > 12d)
            {
                txtZDh1.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }
        }

        private void txtZDh1_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            short KeyAscii = (short)Strings.Asc(eventArgs.KeyChar);
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
                        if (txtZDh1.SelectionStart != 0 | bMinusSignAlready)
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
                        if (txtZDh1.SelectionStart != 0 | bPlusSignAlready)
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

        private void txtZDh1_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtZDh1.Text) < -13 | Conversion.Val(txtZDh1.Text) > 12d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtZDh1_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtZDh1;
            SelectAllText(ref argTB);
            txtZDh1 = argTB;
        }

        private void btnMoveResult_Click(object sender, EventArgs e)
        {
            DT1Days.Value = DTRDays.Value;
            DT1Hours.Value = DTRHours.Value;
            DT1Minutes.Value = DTRMinutes.Value;
            DT1Seconds.Value = DTRSeconds.Value;
            DTRDays.Value = 0m;
            DTRHours.Value = 0m;
            DTRMinutes.Value = 0m;
            DTRSeconds.Value = 0m;
            return;
        }

        private void txtZDh2_TextChanged(object eventSender, EventArgs eventArgs)
        {
            txtTimeResult.Clear();
            txtDays.Clear();
            txtZDh2.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtZDh2.Text) < -13 | Conversion.Val(txtZDh2.Text) > 12d)
            {
                txtZDh1.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }
        }

        private void txtZDh2_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            short KeyAscii = (short)Strings.Asc(eventArgs.KeyChar);
            bool bMinusSignAlready = false ;

            bool bPlusSignAlready = false;  //As Boolean

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
                        if (txtZDh2.SelectionStart != 0 | bMinusSignAlready)
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
                        if (txtZDh2.SelectionStart != 0 | bPlusSignAlready)
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

        private void txtZDh2_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtZDh2.Text) < -13 | Conversion.Val(txtZDh2.Text) > 12d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtZDh2_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtZDh2;
            SelectAllText(ref argTB);
            txtZDh2 = argTB;
        }

        private void cmdClearToD_Click(object eventSender, EventArgs eventArgs)
        {
            txtTime1.Clear();
            txtZDh1.Clear();
            txtZDh2.Clear();
            txtIntD.Clear();
            txtIntH.Clear();
            txtIntM.Clear();
            txtTimeResult.Clear();
            txtDays.Visible = false;

            // lblLocB.Visible = False
            // txtLocBDateTime.Clear()
            // txtLocBDateTime.Visible = False
            // cbLocAZD.SelectedIndex = 0
            // cbLocBZone.SelectedIndex = 0

            LocADTPicked = false;
            // TZASelected = False
            TZBSelected = false;
            chkDST1.CheckState = CheckState.Unchecked;
            chkDST2.CheckState = CheckState.Unchecked;
            cboZDm1.SelectedIndex = 0;
            cboZDm2.SelectedIndex = 0;
        }

        private void cmdCalculateToD_Click(object eventSender, EventArgs eventArgs)
        {
            Time1inSeconds = (int)(3600d * Conversion.Val(Strings.Left(txtTime1.Text, 2)) + 60d * Conversion.Val(Strings.Mid(txtTime1.Text, 3, 2)) + Conversion.Val(Strings.Right(txtTime1.Text, 2)));
            ZD1 = Math.Abs(Conversion.Val(txtZDh1.Text)) + Conversion.Val(cboZDm1.Text) / 60d;
            if (Strings.Left(txtZDh1.Text, 1) == "-")
            {
                ZD1 = -ZD1;
            }

            if ((int)chkDST1.CheckState == 1)
            {
                ZD1 = ZD1 - 1d;
            }

            ZD1inseconds = (int)(3600d * ZD1);
            UTinSeconds = Time1inSeconds + ZD1inseconds;
            T1Seconds = (float)(86400d * Conversion.Val(txtIntD.Text) + 3600d * Conversion.Val(txtIntH.Text) + 60d * Conversion.Val(txtIntM.Text)); // + Val(txtIntS.text)
            ZD2 = Math.Abs(Conversion.Val(txtZDh2.Text)) + Conversion.Val(cboZDm2.Text) / 60d;
            if (Strings.Left(txtZDh2.Text, 1) == "-")
            {
                ZD2 = -ZD2;
            }

            if ((int)chkDST2.CheckState == 1)
            {
                ZD2 = ZD2 - 1d;
            }

            ZD2inseconds = (int)(3600d * ZD2);
            if (optAddToD.Checked == true)
            {
                TimeResult = UTinSeconds + T1Seconds;
            }

            if (optSubtractToD.Checked == true)
            {
                TimeResult = UTinSeconds - T1Seconds;
            }

            TimeResult = TimeResult - ZD2inseconds;
            Days = 0;
            while (TimeResult >= 86399f)
            {
                TimeResult = TimeResult - 86400f;
                Days = (short)(Days + 1);
            }

            while (TimeResult < 0f)
            {
                TimeResult = TimeResult + 86400f;
                Days = (short)(Days - 1);
            }

            TimeResultHours = (short)Conversion.Int(TimeResult / 3600f);
            TimeResultMinutes = (short)Conversion.Int((TimeResult - TimeResultHours * 3600f) / 60f);
            txtTimeResult.Text = TimeResultHours.ToString("00") + ":" + TimeResultMinutes.ToString("00"); // & Strings.format(Str$(TimeResultSeconds), "00")

            // If LocADTPicked = True Then

            // 'LocADT = DTLocA.Value
            // 'DateTime.SpecifyKind(LocADT, DateTimeKind.Local)
            // 'DateTime.SpecifyKind(LocBDT, DateTimeKind.Local)
            // 'TZA = cbLocAZD.SelectedItem
            // 'TZB = cbLocBZone.SelectedItem
            // LocBDT = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(LocADT, TZA.Id, TZB.Id)
            // Dim IntDays As Integer = 0
            // Dim IntHours As Integer = 0
            // Dim IntMins As Integer = 0
            // If txtIntD.Text <> vbNullString Then
            // IntDays = Convert.ToInt32(txtIntD.Text)
            // End If
            // If txtIntH.Text <> vbNullString Then
            // IntHours = Convert.ToInt32(txtIntH.Text)
            // End If
            // If txtIntM.Text <> vbNullString Then
            // IntMins = Convert.ToInt32(txtIntM.Text)
            // End If

            // Dim Tspan As TimeSpan = New TimeSpan(IntDays, IntHours, IntMins, 0)
            // If optAddToD.Checked = True Then
            // LocBDT = LocBDT.Add(Tspan)
            // End If
            // If optSubtractToD.Checked = True Then
            // LocBDT = LocBDT.Subtract(Tspan)
            // End If

            // lblLocB.Visible = True
            // txtLocBDateTime.Text = LocBDT.ToString("ddd MM/dd/yyyy HH:mm")
            // txtLocBDateTime.Visible = True

            // End If

            if (Days == 1)
            {
                txtDays.Text = "+ 1 day";
                txtDays.Visible = true;
            }

            if (Days == -1)
            {
                txtDays.Text = "- 1 day";
                txtDays.Visible = true;
            }

            if (Days > 1)
            {
                txtDays.Text = "+" + Conversion.Str(Math.Abs(Days)) + " days";
                txtDays.Visible = true;
            }

            if (Days < -1)
            {
                txtDays.Text = "-" + Conversion.Str(Math.Abs(Days)) + " days";
                txtDays.Visible = true;
            }
        }

        // Private Sub txtD1_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        // txtCalcTime1.Clear()
        // End Sub

        // Private Sub txtD1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
        // Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        // Select Case KeyAscii
        // Case Asc("0") To Asc("9")
        // fnumeral = fnumeral & Chr(KeyAscii)
        // Case Asc(".") 'only allows one decimal point
        // If InStr(txtD1.Text, ".") Then
        // If KeyAscii = 46 Then KeyAscii = 0 : Beep()
        // End If
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

        // Private Sub txtD1_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs)
        // Dim KeepFocus As Boolean = eventArgs.Cancel
        // eventArgs.Cancel = KeepFocus
        // End Sub
        // Private Sub txtD1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        // SelectAllText(txtD1)
        // End Sub

        // Private Sub txtH1_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        // txtCalcTime1.Clear()
        // End Sub

        // Private Sub txtH1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
        // Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        // Select Case KeyAscii
        // Case Asc("0") To Asc("9")
        // fnumeral = fnumeral & Chr(KeyAscii)
        // Case Asc(".") 'only allows one decimal point
        // If InStr(txtH1.Text, ".") Then
        // If KeyAscii = 46 Then KeyAscii = 0 : Beep()
        // End If
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

        // Private Sub txtH1_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs)
        // Dim KeepFocus As Boolean = eventArgs.Cancel
        // eventArgs.Cancel = KeepFocus
        // End Sub
        // Private Sub txtH1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        // SelectAllText(txtH1)
        // End Sub

        // Private Sub txtM1_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        // txtCalcTime1.Clear()
        // End Sub

        // Private Sub txtM1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
        // Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        // Select Case KeyAscii
        // Case Asc("0") To Asc("9")
        // fnumeral = fnumeral & Chr(KeyAscii)
        // Case Asc(".") 'only allows one decimal point
        // If InStr(txtM1.Text, ".") Then
        // If KeyAscii = 46 Then KeyAscii = 0 : Beep()
        // End If
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

        // Private Sub txtM1_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs)
        // Dim KeepFocus As Boolean = eventArgs.Cancel
        // eventArgs.Cancel = KeepFocus
        // End Sub
        // Private Sub txtM1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        // SelectAllText(txtM1)
        // End Sub

        // Private Sub txtS1_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        // txtCalcTime1.Clear()
        // End Sub

        // Private Sub txtS1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
        // Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        // Select Case KeyAscii
        // Case Asc("0") To Asc("9")
        // fnumeral = fnumeral & Chr(KeyAscii)
        // Case Asc(".") 'only allows one decimal point
        // If InStr(txtS1.Text, ".") Then
        // If KeyAscii = 46 Then KeyAscii = 0 : Beep()
        // End If
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

        // Private Sub txtS1_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs)
        // Dim KeepFocus As Boolean = eventArgs.Cancel
        // eventArgs.Cancel = KeepFocus
        // End Sub
        // Private Sub txtS1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        // SelectAllText(txtS1)
        // End Sub

        // Private Sub txtD2_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        // txtCalcTime1.Clear()
        // End Sub

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Private Sub txtD2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
        // Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        // Select Case KeyAscii
        // Case Asc("0") To Asc("9")
        // fnumeral = fnumeral & Chr(KeyAscii)
        // Case Asc(".") 'only allows one decimal point
        // If InStr(txtD2.Text, ".") Then
        // If KeyAscii = 46 Then KeyAscii = 0 : Beep()
        // End If
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

        // Private Sub DTLocA_ValueChanged(sender As Object, e As EventArgs)
        // LocADT = DTLocA.Value
        // LocADTPicked = True
        // txtTime1.Text = LocADT.Hour.ToString("00") & LocADT.Minute.ToString("00")
        // End Sub

        // Private Sub cbLocAZD_SelectedIndexChanged(sender As Object, e As EventArgs)
        // TZA = cbLocAZD.SelectedItem
        // TZAID = TZA.Id
        // TZASelected = True
        // Dim TempHr As Double = TZA.BaseUtcOffset.Hours
        // Dim TempMin As Double = System.Math.Abs(TZA.BaseUtcOffset.Minutes)
        // TempHr = -TempHr
        // txtZDh1.Text = TempHr
        // Select Case TempMin
        // Case 30
        // cboZDm1.SelectedIndex = 1
        // Case 45
        // cboZDm1.SelectedIndex = 2
        // End Select
        // End Sub

        // Private Sub cbLocBZone_SelectedIndexChanged(sender As Object, e As EventArgs)
        // TZB = cbLocBZone.SelectedItem
        // TZBId = TZB.Id
        // TZBSelected = True
        // Dim TempHr As Double = TZB.BaseUtcOffset.Hours
        // Dim TempMin As Double = System.Math.Abs(TZB.BaseUtcOffset.Minutes)
        // TempHr = -TempHr
        // txtZDh2.Text = TempHr
        // Select Case TempMin
        // Case 30
        // cboZDm2.SelectedIndex = 1
        // Case 45
        // cboZDm2.SelectedIndex = 2
        // End Select
        // End Sub

        private void btnAddSubtract_Click(object sender, EventArgs e)
        {
            AddSubtractCalculate();
        }

        private void btnZDCalc_Click(object sender, EventArgs e)
        {
            ZDCalc();
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControl1.SelectedIndex == 1)
            {
                DT1Days.Value = 0m;
                DT1Hours.Value = 0m;
                DT1Minutes.Value = 0m;
                DT1Seconds.Value = 0m;
                DT2Days.Value = 0m;
                DT2Hours.Value = 0m;
                DT2Minutes.Value = 0m;
                DT2Seconds.Value = 0m;
                DTRDays.Value = 0m;
                DTRHours.Value = 0m;
                DTRMinutes.Value = 0m;
                DTRSeconds.Value = 0m;
            }

            return;
        }

        private void txtD2_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            eventArgs.Cancel = KeepFocus;
        }

        private void cmdCalculateTimes_Click(object eventSender, EventArgs eventArgs)
        {
            var T1span = new TimeSpan((int)DT1Days.Value, (int)DT1Hours.Value, (int)DT1Minutes.Value, (int)DT1Seconds.Value);
            var T2span = new TimeSpan((int)DT2Days.Value, (int)DT2Hours.Value, (int)DT2Minutes.Value, (int)DT2Seconds.Value);
            var T3span = default(TimeSpan);
            if (optAddTimes.Checked == true)
                T3span = T1span.Add(T2span);
            if (optSubtractTimes.Checked == true)
                T3span = T1span.Subtract(T2span);
            DTRDays.Value = T3span.Days;
            DTRHours.Value = T3span.Hours;
            DTRMinutes.Value = T3span.Minutes;
            DTRSeconds.Value = T3span.Seconds;
            if (DTRDays.Value > DT1Days.Value)
            {
                DT1Days.Maximum = 2m * DTRDays.Value;
                DT2Days.Maximum = 2m * DTRDays.Value;
            }

            return;
        }

        private void cmdClearTimes_Click(object eventSender, EventArgs eventArgs)
        {
            DT1Days.Value = 0m;
            DT1Hours.Value = 0m;
            DT1Minutes.Value = 0m;
            DT1Seconds.Value = 0m;
            DT2Days.Value = 0m;
            DT2Hours.Value = 0m;
            DT2Minutes.Value = 0m;
            DT2Seconds.Value = 0m;
            DTRDays.Value = 0m;
            DTRHours.Value = 0m;
            DTRMinutes.Value = 0m;
            DTRSeconds.Value = 0m;
            return;
        }

        private void txtLoDeg_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtLoDeg.Text) != 180d)
                txtLoMin.Enabled = true;
            if (Conversion.Val(txtLoDeg.Text) == 180d)
            {
                txtLoMin.Clear();
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
            // AutoZDCalc()
        }

        private void txtLoDeg_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
            // AutoZDCalc()
        }

        private void txtLoMin_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        private void cboLo_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            // AutoZDCalc()
        }

        public void ZDCalc()
        {
            Lo = Conversion.Val(txtLoDeg.Text) + Conversion.Val(txtLoMin.Text) / 60d;
            ZD = Conversion.Int(Lo / 15d + 0.5d);
            if (cboLo.Text == "E")
                ZD = -ZD;
            SignZD = "+";
            if (cboLo.Text == "E")
                SignZD = "-";
            txtZD.Text = SignZD + Math.Abs(ZD);
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