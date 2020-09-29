using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    internal partial class FormVertical : Form
    {
        private float DC, H1, VC, AC;
        private string fnumeral;

        private void cmdCalcVert_Click(object eventSender, EventArgs eventArgs)
        {
            H1 = (float)(0.5d * Conversion.Val(txtMTR.Text) + Conversion.Val(txtMTL.Text)); // H1 is height of MHW above MLLW
            H1 = (float)(Conversion.Int(H1 * 10f + 0.5d) / 10d);
            VC = (float)(Conversion.Val(txtCH.Text) + H1 - Conversion.Val(txtHeight.Text));
            AC = (float)(VC - Conversion.Val(txtBH.Text));
            AC = (float)(Conversion.Int(AC * 10f + 0.5d) / 10d);
            DC = (float)(Conversion.Val(txtCD.Text) + Conversion.Val(txtHeight.Text) - Conversion.Val(txtDraft.Text));
            VerticalTxtBx.SelectionAlignment = HorizontalAlignment.Center;
            VerticalTxtBx.AppendText("Height of MHW above MLLW = 1/2 Mean Range + Mean Tide");
            VerticalTxtBx.AppendText(" = 1/2 (" + Conversion.Val(txtMTR.Text) + ") + " + Conversion.Val(txtMTL.Text).ToString() + " = " + H1.ToString() + Constants.vbNewLine);
            VerticalTxtBx.AppendText("Vertical Clearance = Charted Height + Height of MHW above MLLW - Height of Tide above MLLW");
            VerticalTxtBx.AppendText(" = " + Conversion.Val(txtCH.Text) + " + " + H1.ToString() + " - " + Conversion.Val(txtHeight.Text).ToString() + " = " + VC.ToString() + Constants.vbNewLine);
            VerticalTxtBx.AppendText("Actual Clearance = Vertical Clearance - Boat Height");
            VerticalTxtBx.AppendText(" = " + VC + " - " + Conversion.Val(txtBH.Text).ToString() + " = " + AC.ToString() + Constants.vbNewLine);
            DepthTxtBx.SelectionAlignment = HorizontalAlignment.Center;
            DepthTxtBx.AppendText("Depth Clearance (under keel) = Charted Depth + Height of Tide above MLLW - Boat's Draft");
            DepthTxtBx.AppendText(" = " + Conversion.Val(txtCD.Text) + " + " + Conversion.Val(txtHeight.Text).ToString() + " - " + Conversion.Val(txtDraft.Text).ToString() + " = " + DC.ToString());
        }

        private void cmdClear_Click(object eventSender, EventArgs eventArgs)
        {
            txtHeight.Clear();
            txtCH.Clear();
            txtMTR.Clear();
            txtMTL.Clear();
            txtCD.Clear();
            txtDraft.Clear();
            txtBH.Clear();
            VerticalTxtBx.Clear();
            DepthTxtBx.Clear();
            return;
        }

        private void cmdPrint_Click(object eventSender, EventArgs eventArgs)
        {
            Print_Renamed.PrintScreen(Bounds);
        }

        private void FormVertical_Load(object eventSender, EventArgs eventArgs)
        {
            if (My.MyProject.Forms.FormTides.Flag == false)
            {
                txtHeight.Clear();
            }

            txtCH.Clear();
            txtMTR.Clear();
            txtMTL.Clear();
            txtCD.Clear();
            txtDraft.Clear();
            txtBH.Clear();
            VerticalTxtBx.Clear();
            DepthTxtBx.Clear();
        }

        private void txtBH_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtBH.Text) > 999.9d)
            {
                txtBH.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtBH.Text) <= 999.9d)
            {
                txtCH.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtBH_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        if (Conversions.ToBoolean(Strings.InStr(txtCH.Text, ".")))
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

        private void txtBH_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtBH.Text) > 999.9d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtBH_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtBH;
            SelectAllText(ref argTB);
            txtBH = argTB;
        }

        private void txtCD_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtCD.Text) > 99.9d)
            {
                txtCD.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtCD.Text) <= 99.9d)
            {
                txtCD.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtCD_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        if (Conversions.ToBoolean(Strings.InStr(txtCH.Text, ".")))
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

        private void txtCD_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtCD.Text) > 99.9d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtCD_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtCD;
            SelectAllText(ref argTB);
            txtCD = argTB;
        }

        private void txtCH_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtCH.Text) > 999.9d)
            {
                txtCH.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtCH.Text) <= 999.9d)
            {
                txtCH.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtCH_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        if (Conversions.ToBoolean(Strings.InStr(txtCH.Text, ".")))
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

        private void txtCH_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtCH.Text) > 999.9d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtCH_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtCH;
            SelectAllText(ref argTB);
            txtCH = argTB;
        }

        private void txtDraft_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtDraft.Text) > 99.9d)
            {
                txtDraft.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtDraft.Text) <= 99.9d)
            {
                txtDraft.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtDraft_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        if (Conversions.ToBoolean(Strings.InStr(txtDraft.Text, ".")))
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

        private void txtDraft_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtDraft.Text) > 99.9d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtDraft_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtDraft;
            SelectAllText(ref argTB);
            txtDraft = argTB;
        }

        private void txtMTR_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtMTR.Text) > 99.9d)
            {
                txtMTR.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtMTR.Text) <= 99.9d)
            {
                txtMTR.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtMTR_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        if (Conversions.ToBoolean(Strings.InStr(txtMTR.Text, ".")))
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

        private void txtMTR_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtMTR.Text) > 99.9d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtMTR_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtMTR;
            SelectAllText(ref argTB);
            txtMTR = argTB;
        }

        private void txtMTL_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtMTL.Text) > 99.9d)
            {
                txtMTL.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtMTL.Text) <= 99.9d)
            {
                txtMTL.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtMTL_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        if (Conversions.ToBoolean(Strings.InStr(txtMTL.Text, ".")))
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

        private void txtMTL_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtMTL.Text) > 99.9d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtMTL_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtMTL;
            SelectAllText(ref argTB);
            txtMTL = argTB;
        }

        // UPGRADE_WARNING: Event txtHeight.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
        private void txtHeight_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Math.Abs(Conversion.Val(txtHeight.Text)) > 99.9d)
            {
                txtHeight.BackColor = ColorTranslator.FromOle(0xFF);
                MessageBox.Show("Out of Range");
            }
            // If Val(txtHeight.text) <= 99.9 Then
            // txtHeight.BackColor = &H80000005
            // End If
            if (Math.Abs(Conversion.Val(txtHeight.Text)) <= 99.9d)
            {
                txtHeight.Enabled = true;
                txtHeight.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtHeight_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            short KeyAscii = (short)Strings.Asc(eventArgs.KeyChar);
            ;
            // Static bPlusSignAlready As Boolean
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
                case (short)('-'):
                    {
                        // If Len(txtHoMin.Text) > 0 Then
                        // KeyAscii = 0
                        // Beep
                        // End If
                        if (txtHeight.SelectionStart != 0 | bMinusSignAlready)
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
                // Case Asc("+")
                // If Len(txtHeight.Text) > 0 Then
                // KeyAscii = 0
                // Beep
                // End If

                // If txtHeight.SelStart <> 0 Or bPlusSignAlready Then
                // KeyAscii = 0
                // Beep
                // Else
                // bPlusSignAlready = True
                // End If

                case (short)('.'): // only allows one decimal point
                    {
                        if (Conversions.ToBoolean(Strings.InStr(txtHeight.Text, ".")))
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

        private void txtHeight_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtHeight.Text) > 99.9d | Conversion.Val(txtHeight.Text) < -99.9d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtHeight_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtHeight;
            SelectAllText(ref argTB);
            txtHeight = argTB;
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