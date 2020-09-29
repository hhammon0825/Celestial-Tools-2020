using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    internal partial class FormTVMDC : Form
    {
        // this boolean is shared with DevTable FormDevTable_frm which is set by FormDevTable_frm to signal yes / no it is loaded and open for business
        // this is an alternative to the boolean FormDevTable_frmOpen that is located and maintained inside of FormDevTable_frm program. It is safer to maintain boolean signal in this program
        public bool FormDevTable_frmHasOpenedForBusiness = false;
        public int ClearInputFieldsCounter = 0;
        private double ChartedVariation, CorrVar;
        private double Variation, AnnualChange, Years; // Deviation As Integer
        private int Change;
        private double valtxtDeviation, valtxtVariation, valtxtTrue, valtxtMagnetic, valtxtCompass;
        private bool FlagC = false;
        private bool FlagM = false;
        private int Index = 0;
        private double U1 = 0d;
        private bool FormTVMDCLoaded = false;
        private bool TextMagChgd = false;
        private bool FieldInit = false;

        private void Form_Initialize_Renamed()
        {
            ClearInputFields();
        }

        private void ClearInputFields()
        {
            FieldInit = true;
            // clear out input test fields
            txtTrue.Clear();
            txtMagnetic.Clear();
            txtCompass.Clear();
            txtVariation.Clear();
            txtDeviation.Clear();
            // clear out the local variables which hold the text field values
            valtxtTrue = 0d;
            valtxtVariation = 0d;
            valtxtMagnetic = 0d;
            valtxtDeviation = 0d;
            valtxtCompass = 0d;
            // reset background color of all input fields to default color
            txtCompass.BackColor = DefaultBackColor;
            txtTrue.BackColor = DefaultBackColor;
            txtMagnetic.BackColor = DefaultBackColor;
            txtVariation.BackColor = DefaultBackColor;
            txtDeviation.BackColor = DefaultBackColor;
            FieldInit = false;
            return;
        }

        private void InitChartVarFields()
        {
            txtCY.Clear();
            txtCVDeg.Clear();
            txtCVMin.Clear();
            txtChange.Clear();
            txtYI.Clear();
            txtCorrVar.Clear();
            txtEW.Clear();
            cboCV.SelectedIndex = 0; // g_LongW
            cboIncDec.SelectedIndex = 0; // "Increasing"
            txtYI.Text = DateAndTime.Year(DateAndTime.Today).ToString();
            // when the chart variation calc fields are initialized, the checkbox to use calc'd chart var is turned off
            chkChartVar.Checked = false;
            return;
        }

        private void cboCV_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
        }

        private void cboIncDec_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
        }

        private void cmdPrint_Click(object eventSender, EventArgs eventArgs)
        {
            Print_Renamed.PrintScreen(Bounds);
        }

        private void FormTVMDC_Load(object eventSender, EventArgs eventArgs)
        {
            bool CompFlag;
            bool MagFlag;
            bool TrueFlag;
            cboV.SelectedIndex = 0; // g_LongW
            cboD.SelectedIndex = 0; // g_LongW
            ClearInputFields();
            InitChartVarFields();
            TrueFlag = false;
            MagFlag = false;
            CompFlag = false;
            chkDev.Checked = false;
            optDown.Checked = true;
            optUp.Checked = false;
            FormTVMDCLoaded = true;
        }

        private void CorrectedVariation()
        {
            ChartedVariation = 60d * Conversion.Val(txtCVDeg.Text) + Conversion.Val(txtCVMin.Text);
            AnnualChange = Conversion.Val(txtChange.Text);
            if (cboIncDec.Text == "Decreasing")
            {
                AnnualChange = -AnnualChange;
            }

            Years = Conversion.Val(txtYI.Text) - Conversion.Val(txtCY.Text);
            Change = Conversions.ToInteger(Operators.MultiplyObject(Conversions.ToInteger(AnnualChange), Years));
            CorrVar = ChartedVariation + Change;
            CorrVar = CorrVar / 60d;
            CorrVar = Conversion.Int(CorrVar + 0.5d);
            if (cboCV.SelectedIndex == 0)
            {
                txtEW.Text = CommonGlobals.g_LongW;
            }
            else
            {
                txtEW.Text = CommonGlobals.g_LongE;
            }
            // txtEW.Text = cboCV.Text
            if (CorrVar < 0d & cboCV.Text == "E")
                txtEW.Text = CommonGlobals.g_LongW;
            if (CorrVar < 0d & cboCV.Text == "W")
                txtEW.Text = CommonGlobals.g_LongE;
            if (Math.Abs(CorrVar) > 99d)
            {
                txtCorrVar.BackColor = ColorTranslator.FromOle(0xC8FF);
            }
            else
            {
                txtCorrVar.BackColor = ColorTranslator.FromOle(0xE0E0E0);
            }

            if (Math.Abs(CorrVar) > 99d)
            {
                txtEW.BackColor = ColorTranslator.FromOle(0xC8FF);
            }
            else
            {
                txtEW.BackColor = ColorTranslator.FromOle(0xE0E0E0);
            }

            txtCorrVar.Text = Conversion.Str(Math.Abs(CorrVar));
        }

        private void txtChange_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (FieldInit == true)
                return;
            if (string.IsNullOrEmpty(txtChange.Text))
            {
                txtChange.Text = "0";
            }

            int ParseInt = 0;
            if (int.TryParse(txtChange.Text, out ParseInt))
            {
                if (Conversion.Val(txtChange.Text) > 59d)
                {
                    txtChange.BackColor = ColorTranslator.FromOle(0xFF);
                    ErrorMsgBox("Change Value too large - must be 0 to 59");
                    return;
                }
            }
            else
            {
                txtChange.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Change Value must be numeric between 0 to 59");
                return;
            }

            if (Conversion.Val(txtChange.Text) < 60d)
            {
                txtChange.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtChange_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        private void txtChange_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtChange.Text) > 59d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtChange_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtChange;
            SelectAllText(ref argTB);
            txtChange = argTB;
        }

        private void txtCVDeg_TextChanged(object eventSender, EventArgs eventArgs)
        {
        }

        private void txtCVDeg_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        private void txtCVDeg_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtCVDeg;
            SelectAllText(ref argTB);
            txtCVDeg = argTB;
        }

        private void txtCVMin_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (FieldInit == true)
                return;
            if (string.IsNullOrEmpty(txtCVMin.Text))
            {
                txtCVMin.Text = "0";
            }

            int ParseInt = 0;
            if (int.TryParse(txtCVMin.Text, out ParseInt))
            {
                if (Conversion.Val(txtCVMin.Text) > 59d)
                {
                    txtCVMin.BackColor = ColorTranslator.FromOle(0xFF);
                    ErrorMsgBox("CV Min Value too large - must be 0 to 59");
                    return;
                }
            }
            else
            {
                txtCVMin.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("CV Min Value must be numeric between 0 to 59");
                return;
            }

            if (Conversion.Val(txtCVMin.Text) < 60d)
            {
                txtCVMin.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtCVMin_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        private void txtCVMin_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtCVMin.Text) > 59d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtCVMin_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtCVMin;
            SelectAllText(ref argTB);
            txtCVMin = argTB;
        }

        private void txtCY_TextChanged(object eventSender, EventArgs eventArgs)
        {
        }

        private void txtCY_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        private void txtCY_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtCY;
            SelectAllText(ref argTB);
            txtCY = argTB;
        }

        private void cboD_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            if (!FormTVMDCLoaded)
            {
                return;
            }

            valtxtDeviation = Conversion.Val(txtDeviation.Text);
            if (cboD.Text == "E")
            {
                valtxtDeviation = -valtxtDeviation;
            }
        }

        private void cboV_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            if (!FormTVMDCLoaded)
            {
                return;
            }

            valtxtVariation = Conversion.Val(txtVariation.Text);
            if (cboV.Text == "E")
            {
                valtxtVariation = -valtxtVariation;
            }
        }

        private void txtYI_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (!FormTVMDCLoaded)
                return;
        }

        private void txtYI_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        private void txtYI_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtYI;
            SelectAllText(ref argTB);
            txtYI = argTB;
        }

        private void txtTrue_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            short KeyAscii = (short)Strings.Asc(eventArgs.KeyChar);
            if (Strings.Len(txtTrue.Text) == 3 & KeyAscii >= Strings.Asc("0") & KeyAscii <= Strings.Asc("9"))
            {
                KeyAscii = 0;
            }

            if (KeyAscii >= Strings.Asc("0") & KeyAscii <= Strings.Asc("9"))
            {
                valtxtTrue = Conversions.ToSingle(Conversion.Val(txtTrue.Text).ToString() + Conversion.Val((char)KeyAscii));
            }
            else
            {
                valtxtTrue = Conversion.Val(txtTrue.Text);
            }

            if ((KeyAscii < Strings.Asc("0") | KeyAscii > Strings.Asc("9")) & KeyAscii != (int)Keys.Back)
            {
                KeyAscii = 0;
                Interaction.Beep();
            }

            eventArgs.KeyChar = (char)KeyAscii;
            if (KeyAscii == 0)
            {
                eventArgs.Handled = true;
            }
        }

        private void txtTrue_KeyDown(object eventSender, KeyEventArgs eventArgs)
        {
        }

        private void txtTrue_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (FieldInit == true)
                return;
            if (Conversion.Val(txtTrue.Text) > 359d)
            {
                txtTrue.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("True Value too large - must be 0 to 359");
                return;
            }

            if (Conversion.Val(txtTrue.Text) < 360d)
            {
                txtTrue.BackColor = Control.DefaultBackColor; 
            }
            // DisplayT()
            return;
        }

        private void txtTrue_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtTrue.Text) > 359d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtTrue_Enter(object eventSender, EventArgs eventArgs)
        {
            if (!FormTVMDCLoaded)
                return;
            if (FieldInit == true)
                return;
            var argTB = txtTrue;
            SelectAllText(ref argTB);
            txtTrue = argTB;
        }

        private void txtTrue_Leave(object sender, EventArgs e)
        {
            if (!FormTVMDCLoaded)
                return;
            return;
        }

        private void txtVariation_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            if (!FormTVMDCLoaded)
                return;
            short KeyAscii = (short)Strings.Asc(eventArgs.KeyChar);
            if (Strings.Len(txtVariation.Text) == 2 & KeyAscii >= Strings.Asc("0") & KeyAscii <= Strings.Asc("9"))
            {
                KeyAscii = 0;
            }

            if (KeyAscii >= Strings.Asc("0") & KeyAscii <= Strings.Asc("9"))
            {
                valtxtVariation = Conversions.ToDouble(Conversion.Val(txtVariation.Text).ToString() + KeyAscii);
            }
            else
            {
                valtxtVariation = Conversion.Val(txtVariation.Text);
            }

            if (cboV.Text == "E")
            {
                valtxtVariation = -valtxtVariation;
            }

            if ((KeyAscii < Strings.Asc("0") | KeyAscii > Strings.Asc("9")) & KeyAscii != (int)Keys.Back)
            {
                KeyAscii = 0;
                Interaction.Beep();
            }

            eventArgs.KeyChar = (char)KeyAscii;
            if (KeyAscii == 0)
            {
                eventArgs.Handled = true;
            }
        }

        private void txtVariation_KeyDown(object eventSender, KeyEventArgs eventArgs)
        {
        }

        private void txtVariation_Enter(object eventSender, EventArgs eventArgs)
        {
            if (!FormTVMDCLoaded)
                return;
            if (FieldInit == true)
                return;
            var argTB = txtVariation;
            SelectAllText(ref argTB);
            txtVariation = argTB;
        }

        private void txtVariation_Leave(object sender, EventArgs e)
        {
            return;
        }

        private void txtVariation_TextChanged(object sender, EventArgs e)
        {
            return;
        }

        private void txtMagnetic_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            if (!FormTVMDCLoaded)
                return;
            short KeyAscii = (short)Strings.Asc(eventArgs.KeyChar);
            if (Strings.Len(txtMagnetic.Text) == 3 & KeyAscii >= Strings.Asc("0") & KeyAscii <= Strings.Asc("9"))
            {
                KeyAscii = 0;
            }

            if (KeyAscii >= Strings.Asc("0") & KeyAscii <= Strings.Asc("9"))
            {
                valtxtMagnetic = Conversions.ToSingle(Conversion.Val(txtMagnetic.Text).ToString() + Conversion.Val((char)KeyAscii));
            }
            else
            {
                valtxtMagnetic = Conversion.Val(txtMagnetic.Text);
            }

            if ((KeyAscii < Strings.Asc("0") | KeyAscii > Strings.Asc("9")) & KeyAscii != (int)Keys.Back)
            {
                KeyAscii = 0;
                Interaction.Beep();
            }

            eventArgs.KeyChar = (char)KeyAscii;
            if (KeyAscii == 0)
            {
                eventArgs.Handled = true;
            }
        }

        private void txtMagnetic_KeyDown(object eventSender, KeyEventArgs eventArgs)
        {
            TextMagChgd = true;
        }

        private void txtMagnetic_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (!FormTVMDCLoaded)
                return;
            if (FieldInit == true)
                return;
            if (Conversion.Val(txtMagnetic.Text) > 360d)
            {
                txtMagnetic.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Magnet value too large - must be 0 to 359");
                return;
            }

            if (Conversion.Val(txtMagnetic.Text) < 360d)
            {
                txtMagnetic.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtMagnetic_Leave(object sender, EventArgs e)
        {
            if (!FormTVMDCLoaded)
                return;
            if (Conversion.Val(txtMagnetic.Text) > 360d)
            {
                txtMagnetic.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Magnetic Value too large - must be 0 to 359");
                return;
            }

            if (Conversion.Val(txtMagnetic.Text) < 360d)
            {
                txtMagnetic.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtMagnetic_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            if (!FormTVMDCLoaded)
                return;
            if (FieldInit == true)
                return;
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtMagnetic.Text) > 359d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtMagnetic_Enter(object eventSender, EventArgs eventArgs)
        {
            if (!FormTVMDCLoaded)
                return;
            var argTB = txtMagnetic;
            SelectAllText(ref argTB);
            txtMagnetic = argTB;
        }

        private void txtDeviation_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            short KeyAscii = (short)Strings.Asc(eventArgs.KeyChar);
            if (chkDev.Checked == true)
            {
                KeyAscii = 0;
            }

            if (Strings.Len(txtDeviation.Text) == 1 & KeyAscii >= Strings.Asc("0") & KeyAscii <= Strings.Asc("9"))
            {
                KeyAscii = 0;
            }

            if (KeyAscii >= Strings.Asc("0") & KeyAscii <= Strings.Asc("9"))
            {
                valtxtDeviation = Conversions.ToSingle(Conversion.Val(txtDeviation.Text).ToString() + Conversion.Val((char)KeyAscii));
            }
            else
            {
                valtxtDeviation = Conversion.Val(txtDeviation.Text);
            }

            if (cboD.Text == "E")
                valtxtDeviation = -valtxtDeviation;
            if ((KeyAscii < Strings.Asc("0") | KeyAscii > Strings.Asc("9")) & KeyAscii != (int)Keys.Back)
            {
                KeyAscii = 0;
                Interaction.Beep();
            }

            eventArgs.KeyChar = (char)KeyAscii;
            if (KeyAscii == 0)
            {
                eventArgs.Handled = true;
            }
        }

        private void txtDeviation_KeyDown(object eventSender, KeyEventArgs eventArgs)
        {
        }

        private void txtDeviation_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtDeviation;
            SelectAllText(ref argTB);
            txtDeviation = argTB;
        }

        private void txtDeviation_Leave(object sender, EventArgs e)
        {
            return;
        }

        private void txtDeviation_TextChanged(object sender, EventArgs e)
        {
            return;
        }

        private void txtCompass_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            short KeyAscii = (short)Strings.Asc(eventArgs.KeyChar);
            if (Strings.Len(txtCompass.Text) == 3 & KeyAscii >= Strings.Asc("0") & KeyAscii <= Strings.Asc("9"))
            {
                KeyAscii = 0;
            }

            if (KeyAscii >= Strings.Asc("0") & KeyAscii <= Strings.Asc("9"))
            {
                valtxtCompass = Conversions.ToSingle(Conversion.Val(txtCompass.Text).ToString() + Conversion.Val((char)KeyAscii));
            }
            else
            {
                valtxtCompass = Conversion.Val(txtCompass.Text);
            }

            if ((KeyAscii < Strings.Asc("0") | KeyAscii > Strings.Asc("9")) & KeyAscii != (int)Keys.Back)
            {
                KeyAscii = 0;
                Interaction.Beep();
            }

            eventArgs.KeyChar = (char)KeyAscii;
            if (KeyAscii == 0)
            {
                eventArgs.Handled = true;
            }
        }

        private void txtCompass_KeyDown(object eventSender, KeyEventArgs eventArgs)
        {
        }

        private void txtCompass_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (FieldInit == true)
                return;
            // do nothing since this event gets triggered by anything and cannot be relied on
            if (Conversion.Val(txtCompass.Text) > 360d)
            {
                txtCompass.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Compass Value too large - must be 0 to 359");
                return;
            }

            if (Conversion.Val(txtCompass.Text) < 360d)
            {
                txtCompass.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtCompass_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtCompass.Text) > 359d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtCompass_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtCompass;
            SelectAllText(ref argTB);
            txtCompass = argTB;
        }

        private void txtCompass_Leave(object sender, EventArgs e)
        {
            if (Conversion.Val(txtCompass.Text) > 360d)
            {
                txtCompass.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Compass Value too large - must be 0 to 359");
                return;
            }

            if (Conversion.Val(txtCompass.Text) < 360d)
            {
                txtCompass.BackColor = Control.DefaultBackColor; 
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            if (chkDev.Checked == true)
            {
                My.MyProject.Forms.FormDevTable_frm.CloseFormDevTable_frm();
                chkDev.Checked = false;
            }

            Close();
        }

        private void DisplayTVMDC()
        {
            if (optDown.Checked == true)
            {
                valtxtTrue = Conversion.Val(txtTrue.Text);
                if (chkChartVar.Checked == true)
                {
                    txtVariation.Text = txtCorrVar.Text;
                    txtVariation.ReadOnly = true;
                    txtVariation.Enabled = false;
                    if ((txtEW.Text ?? "") == (CommonGlobals.g_LongW ?? ""))
                    {
                        cboV.SelectedIndex = 0;
                    }
                    else
                    {
                        cboV.SelectedIndex = 1;
                    }

                    cboV.Enabled = false;
                }

                valtxtVariation = Conversion.Val(txtVariation.Text);
                if (cboV.Text == "E")
                {
                    valtxtVariation = -valtxtVariation;
                }

                valtxtMagnetic = valtxtTrue + valtxtVariation;
                if (valtxtMagnetic > 359d)
                {
                    valtxtMagnetic = valtxtMagnetic - 360d;
                }

                if (chkDev.Checked == true)
                {
                    FlagM = true;
                    FlagC = false;
                    DevInterpM();
                }

                valtxtDeviation = Conversion.Val(txtDeviation.Text);
                if (cboD.Text == "E")
                {
                    valtxtDeviation = -valtxtDeviation;
                }

                if (valtxtMagnetic < 0d)
                {
                    valtxtMagnetic = valtxtMagnetic + 360d;
                }

                txtMagnetic.Text = Strings.Format("#00", Math.Abs(valtxtMagnetic).ToString());
                valtxtCompass = valtxtMagnetic + valtxtDeviation;
                if (valtxtCompass > 359d)
                {
                    valtxtCompass = valtxtCompass - 360d;
                }

                if (valtxtCompass < 0d)
                {
                    valtxtCompass = valtxtCompass + 360d;
                }

                txtCompass.Text = Strings.Format("#00", valtxtCompass.ToString());
            }

            if (optUp.Checked == true)
            {
                valtxtCompass = Conversion.Val(txtCompass.Text);
                if (chkDev.Checked == true)
                {
                    FlagC = true;
                    FlagM = false;
                    DevInterpC();
                }
                else
                {
                    valtxtDeviation = Conversion.Val(txtDeviation.Text);
                    if (cboD.Text == "E")
                    {
                        valtxtDeviation = -valtxtDeviation;
                    }
                }

                valtxtMagnetic = valtxtCompass - valtxtDeviation;
                if (valtxtMagnetic > 359d)
                {
                    valtxtMagnetic = valtxtMagnetic - 360d;
                }

                if (valtxtMagnetic < 0d)
                {
                    valtxtMagnetic = valtxtMagnetic + 360d;
                }

                txtMagnetic.Text = Strings.Format("#00", Math.Abs(valtxtMagnetic).ToString());
                if (chkChartVar.Checked == true)
                {
                    txtVariation.Text = txtCorrVar.Text;
                    txtVariation.ReadOnly = true;
                    txtVariation.Enabled = false;
                    if ((txtEW.Text ?? "") == (CommonGlobals.g_LongW ?? ""))
                    {
                        cboV.SelectedIndex = 0;
                    }
                    else
                    {
                        cboV.SelectedIndex = 1;
                    }

                    cboV.Enabled = false;
                }

                valtxtVariation = Conversion.Val(txtVariation.Text);
                if (cboV.Text == "E")
                {
                    valtxtVariation = -valtxtVariation;
                }

                valtxtTrue = valtxtMagnetic - valtxtVariation;
                if (valtxtTrue > 359d)
                {
                    valtxtTrue = valtxtTrue - 360d;
                }

                if (valtxtTrue < 0d)
                {
                    valtxtTrue = valtxtTrue + 360d;
                }

                txtTrue.Text = Strings.Format("#00", valtxtTrue.ToString());
            }
        }

        private void optDown_CheckedChanged(object sender, EventArgs e)
        {
            if (optDown.Checked == true)
            {
                txtCompass.ReadOnly = true;
                txtCompass.Enabled = false;
                txtCompass.BackColor = Color.LightGray;
            }
            else
            {
                txtCompass.ReadOnly = false;
                txtCompass.Enabled = true;
                txtCompass.BackColor = DefaultBackColor;
            }
        }

        private void optUp_CheckedChanged(object sender, EventArgs e)
        {
            if (optUp.Checked == true)
            {
                txtTrue.ReadOnly = true;
                txtTrue.Enabled = false;
                txtTrue.BackColor = Color.LightGray;
            }
            else
            {
                txtTrue.ReadOnly = false;
                txtTrue.Enabled = true;
                txtTrue.BackColor = DefaultBackColor;
            }
        }

        private void ProtectDeviation()
        {
            if (chkDev.Checked == true)
            {
                txtDeviation.ReadOnly = true;
                txtDeviation.Enabled = false;
                txtDeviation.BackColor = Color.LightGray;
                txtDeviation.Clear();
            }
            else
            {
                txtDeviation.ReadOnly = false;
                txtDeviation.Enabled = true;
                txtDeviation.BackColor = DefaultBackColor;
            }
        }

        private void chkDev_CheckedChanged(object sender, EventArgs e)
        {
            ProcessChkDevChg();
            return;
        }

        private void CalcControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!FormTVMDCLoaded)
                return;
            if (CalcControl.SelectedIndex == 0)
            {
                PerformLoadTVMDC();
            }
            else
            {
                CalcChartVariation();
            }

            return;
        }

        private void PerformLoadTVMDC()
        {
            if (optDown.Checked == true)
            {
            }

            if (optUp.Checked == true)
            {
            }
        }

        private void CalcChartVariation()
        {
        }

        private void btnCalcTVMDC_Click(object sender, EventArgs e)
        {
            DisplayTVMDC();
            return;
        }

        private void btnCalcChartVar_Click(object sender, EventArgs e)
        {
            CorrectedVariation();
            return;
        }

        private void btnClearChartVar_Click(object sender, EventArgs e)
        {
            InitChartVarFields();
            return;
        }

        private void chkChartVar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChartVar.Checked == true)
            {
                txtVariation.Text = txtCorrVar.Text;
                txtVariation.ReadOnly = true;
                txtVariation.Enabled = false;
                if ((txtEW.Text ?? "") == (CommonGlobals.g_LongW ?? ""))
                {
                    cboV.SelectedIndex = 0;
                }
                else
                {
                    cboV.SelectedIndex = 1;
                }

                cboV.Enabled = false;
            }
            else
            {
                txtVariation.Clear();
                txtVariation.Text = "0";
                valtxtVariation = 0d;
                txtVariation.ReadOnly = false;
                txtVariation.Enabled = true;
                cboV.SelectedIndex = 0;
                cboV.Enabled = true;
            }
        }

        private void ProcessChkDevChg()
        {
            int LocalIdx = 0;
            if (!FormTVMDCLoaded)
                return;
            if (chkDev.CheckState == CheckState.Checked)
            {
                My.MyProject.Forms.DevForm.Show();
                FormDevTable_frmHasOpenedForBusiness = true;
                // FormDevTable_frm.Show()
                // Do
                // LocalIdx = LocalIdx
                // Loop Until FormDevTable_frmHasOpenedForBusiness = True  ' This semaphore boolean must reside in this FormTVMDC and NOT the original FormDevTable_frm because if it resides in FormDevTable_frm it may not exist
                ProtectDeviation();
                Show();
                if (!string.IsNullOrEmpty(txtMagnetic.Text) & txtMagnetic.Text != "0")
                {
                    txtMagnetic_TextChanged(txtMagnetic, new EventArgs());
                }
                // FlagMChange = True
            }

            if (chkDev.CheckState == CheckState.Unchecked)
            {
                if (FormDevTable_frmHasOpenedForBusiness == true)
                {
                    My.MyProject.Forms.DevForm.SaveDevDataGrid();
                    My.MyProject.Forms.DevForm.Close();
                    // FormDevTable_frm.CloseFormDevTable_frm()
                    FormDevTable_frmHasOpenedForBusiness = false;
                }

                ProtectDeviation();
                Show();
                if (!string.IsNullOrEmpty(txtMagnetic.Text) & txtMagnetic.Text != "0")
                {
                    txtMagnetic_TextChanged(txtMagnetic, new EventArgs());
                }
            }
        }

        public void DevInterpM()
        {
            if (FlagC == true)
                return;
            DevForm.DeviationRec DevRtn;
            if (FormDevTable_frmHasOpenedForBusiness == true)
            {
                DevRtn = My.MyProject.Forms.DevForm.DevInterpolateMagnetic(Convert.ToInt32(valtxtMagnetic));
                txtDeviation.Text = Strings.Format("#00", Math.Abs(DevRtn.TblDev).ToString());
                valtxtDeviation = Convert.ToDouble(Math.Abs(DevRtn.TblDev));
                if (DevRtn.TblDev < 0)
                {
                    cboD.SelectedIndex = 0;
                }
                else
                {
                    cboD.SelectedIndex = 1;
                }
            }
            else
            {
                My.MyProject.Forms.DevForm.Show();
                FormDevTable_frmHasOpenedForBusiness = true;
                DevRtn = My.MyProject.Forms.DevForm.DevInterpolateMagnetic(Convert.ToInt32(valtxtMagnetic));
                txtDeviation.Text = Strings.Format("#00", Math.Abs(DevRtn.TblDev).ToString());
                valtxtDeviation = Convert.ToDouble(Math.Abs(DevRtn.TblDev));
                if (DevRtn.TblDev < 0)
                {
                    cboD.SelectedIndex = 0;
                }
                else
                {
                    cboD.SelectedIndex = 1;
                }
            }

            return;
        }

        public void DevInterpC()
        {
            if (FlagM == true)
            {
                return; // Or FlagMChange = True
            }

            DevForm.DeviationRec DevRtn;
            if (FormDevTable_frmHasOpenedForBusiness == true)
            {
                DevRtn = My.MyProject.Forms.DevForm.DevInterpolateMagnetic(Convert.ToInt32(txtCompass.Text));
                txtDeviation.Text = Strings.Format("#00", Math.Abs(DevRtn.TblDev).ToString());
                valtxtDeviation = Convert.ToDouble(Math.Abs(DevRtn.TblDev));
                if (DevRtn.TblDev < 0)
                {
                    cboD.SelectedIndex = 0;
                }
                else
                {
                    cboD.SelectedIndex = 1;
                }
            }
            else
            {
                My.MyProject.Forms.DevForm.Show();
                FormDevTable_frmHasOpenedForBusiness = true;
                DevRtn = My.MyProject.Forms.DevForm.DevInterpolateMagnetic(Convert.ToInt32(txtCompass.Text));
                txtDeviation.Text = Strings.Format("#00", Math.Abs(DevRtn.TblDev).ToString());
                valtxtDeviation = Convert.ToDouble(Math.Abs(DevRtn.TblDev));
                if (DevRtn.TblDev < 0)
                {
                    cboD.SelectedIndex = 0;
                }
                else
                {
                    cboD.SelectedIndex = 1;
                }
            }

            return;
        }

        public void cmdClear_Click(object eventSender, EventArgs eventArgs)
        {
            FieldInit = true;
            Form_Initialize_Renamed();
            FieldInit = false;
        }

        private void FormTVMDC_FormClosed(object eventSender, FormClosedEventArgs eventArgs)
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