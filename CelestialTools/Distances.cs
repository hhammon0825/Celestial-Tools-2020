using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    internal partial class FormDistances : Form
    {
        private string fnumeral; // , Location$, ChangeCount As Integer, VisibleFormCount As Integer
        private float HE, Ho;
        private double Pi = Math.PI;
        private double HOinFeet, HEinFeet, Dist, hainDegrees, HEinNM;
        private double hsinMinutes, Corr1, ICinMinutes, ICMin, Dip, Corr1Min, HsMin;
        private short Corr1Deg;
        private double B, A, haMinutes;
        private short haDegrees;

        private void cmdCalculate_Click(object eventSender, EventArgs eventArgs)
        {
            TextBoxFormDistances.Clear();
            HeightConversion();
            if (optVertSeaTop.Checked == true & HEinFeet > HOinFeet)
            {
                ErrorMsgBox("Height of Eye cannot be greater than height of object.");
                return;
            }

            if (optDistHorizon.Checked == true)
            {
                Dist = 1.169497d * Math.Sqrt(HEinFeet);
                TextBoxFormDistances.AppendText("Distance of the Horizon: " + Strings.Format(Dist, "#0.0") + " nm = " + Strings.Format(Dist * 1.1507765d, "#0.0") + " mi" + Constants.vbCrLf);
            }

            if (optGeogRange.Checked == true)
            {
                Dist = 1.169497d * (Math.Sqrt(HEinFeet) + Math.Sqrt(HOinFeet));
                TextBoxFormDistances.AppendText("Geographical Range of Visibility: " + Strings.Format(Dist, "#0.0") + " nm = " + Strings.Format(Dist * 1.1507765d, "#0.0") + " mi" + Constants.vbCrLf);
            }

            if (optVertWaterTop.Checked == true) // Table 16 (Bowditch 2002)
            {
                Dip = 0d;
                AltitudeCorrection();
                if (hainDegrees <= 0d)
                {
                    ErrorMsgBox("Corrected altitude must be greater than zero");
                    return;
                }

                if (hainDegrees > 90d)
                {
                    ErrorMsgBox("Corrected altitude cannot exceed 90º");
                    return;
                }

                Dist = HOinFeet / Math.Tan(hainDegrees * Pi / 180d); // feet
                Dist = Dist / 6076.1154d; // nautical miles
                                          // Dist = Int(Dist * 100 + 0.5) / 100
                TextBoxFormDistances.AppendText("Distance to Object: " + Strings.Format(Dist, "#0.00") + " nm = " + Strings.Format(Dist * 1.1507765d, "#0.00") + " mi" + Constants.vbCrLf);
            }

            if (optVertWaterSea.Checked == true) // Table 17 (Bowditch 2002)
            {
                Dip = 0d;
                AltitudeCorrection();
                if (hainDegrees <= 0d)
                {
                    ErrorMsgBox("Corrected altitude must be greater than zero");
                    return;
                }

                if (hainDegrees > 90d)
                {
                    ErrorMsgBox("Corrected altitude cannot exceed 90º");
                    return;
                }

                HEinNM = HEinFeet / 6076.1154d;
                B = Math.Sqrt(2d * 0.8279d * (HEinNM / 3440.1d));
                A = (Math.Tan(hainDegrees * Pi / 180d) + B) * (1d - Math.Tan(hainDegrees * Pi / 180d) * B);
                Dist = 2025.3718d * (A * 3440.1d - Math.Sqrt(Math.Pow(A * 3440.1d, 2d) - 2d * HEinNM * 3440.1d * 0.8279d)) / 0.8279d;
                TextBoxFormDistances.AppendText("Distance to Object: " + Strings.Format(Dist, "#0") + " yards = " + Strings.Format(Dist / 2025.3718d, "#0.00") + " nm = " + Strings.Format(Dist / 1760d, "#0.00") + " mi" + Constants.vbCrLf);
            }

            if (optVertSeaTop.Checked == true) // Table 15 (Bowditch 2002)
            {
                if (cboHE.Text == "ft" | cboHE.Text == "in")
                {
                    switch (HE)
                    {
                        case var @case when @case < 2f:
                            {
                                Dip = 0.7d * HE;
                                break;
                            }

                        case var case1 when case1 <= 3.9f:
                            {
                                Dip = 1.4d + (HE - 2f) * 0.25d;
                                break;
                            }

                        case var case2 when case2 <= 5.9f:
                            {
                                Dip = 1.9d + (HE - 4f) * 0.25d;
                                break;
                            }

                        case var case3 when case3 <= 7.6f:
                            {
                                Dip = 2.4d + (HE - 6f) * 0.15d;
                                break;
                            }

                        case var case4 when case4 >= 7.7f:
                            {
                                Dip = 0.970003d * Math.Sqrt(HE);
                                break;
                            }
                    }
                }

                if (cboHE.Text == "m " | cboHE.Text == "cm")
                {
                    switch (HE)
                    {
                        case var case5 when case5 < 1f:
                            {
                                Dip = 1.79d * HE;
                                break;
                            }

                        case var case6 when case6 <= 1.6f:
                            {
                                Dip = 1.79d * Math.Sqrt(HE);
                                break;
                            }

                        case var case7 when case7 >= 1.7f:
                            {
                                Dip = 1.76d * Math.Sqrt(HE);
                                break;
                            }
                    }
                }

                AltitudeCorrection();
                if (hainDegrees > 90d)
                {
                    ErrorMsgBox("Corrected altitude cannot exceed 90º");
                    return;
                }

                Dist = Math.Sqrt(Math.Pow(Math.Tan(hainDegrees * Pi / 180d) / 0.0002419d, 2d) + (HOinFeet - HEinFeet) / 0.7349d) - Math.Tan(hainDegrees * Pi / 180d) / 0.0002419d;
                TextBoxFormDistances.AppendText("Distance to Object: " + Strings.Format(Dist, "#0.0") + " nm = " + Strings.Format(Dist * 1.1507765d, "#0.0") + " mi" + Constants.vbCrLf);
            }

            if (optVertWaterTop.Checked == true | optVertWaterSea.Checked == true | optVertSeaTop.Checked == true)
            {
                TextBoxFormDistances.AppendText("Corrected Vertical Angle: " + Strings.Format(Dist, "#0.0") + " nm = " + Strings.Format(Dist * 1.1507765d, "#0.0") + " mi" + Constants.vbCrLf);
                if (hainDegrees < 0d)
                {
                    TextBoxFormDistances.AppendText("Corrected Vertical Angle: " + "-" + Strings.Format(haDegrees, "0") + '°' + Strings.Format(haMinutes, "00.0") + Constants.vbCrLf);
                }
                else if (haMinutes >= 60d)
                {
                    haMinutes = haMinutes - 60d;
                    haDegrees = (short)(haDegrees + 1);
                    TextBoxFormDistances.AppendText("Corrected Vertical Angle: " + Strings.Format(haDegrees, "0") + '°' + Strings.Format(haMinutes, "00.0") + Constants.vbCrLf);
                }
                else
                {
                    TextBoxFormDistances.AppendText("Corrected Vertical Angle: " + Strings.Format(haDegrees, "0") + '°' + Strings.Format(haMinutes, "00.0") + Constants.vbCrLf);
                }
            }

            Refresh();
        }

        public object HeightConversion()
        {
            int rtnObject = 0;
            HE = (float)Conversion.Val(txtHE.Text);
            if (cboHE.Text == "ft")
                HEinFeet = HE;
            if (cboHE.Text == "m ")
                HEinFeet = HE * 3.28095d;
            if (cboHE.Text == "in")
                HEinFeet = HE / 12f;
            if (cboHE.Text == "cm")
                HEinFeet = HE * 0.0328095d;
            if (cboHE.Text == "ft" | cboHE.Text == "m ")
                HE = (float)(Conversion.Int(HE * 10f + 0.5d) / 10d);
            Ho = (float)Conversion.Val(txtHO.Text);
            if (cboHO.Text == "ft")
                HOinFeet = Ho;
            if (cboHO.Text == "m ")
                HOinFeet = Ho * 3.28095d;
            Ho = (float)(Conversion.Int(Ho * 10f + 0.5d) / 10d);
            return rtnObject;
        }

        private void cmdPrint_Click(object eventSender, EventArgs eventArgs)
        {
            Print_Renamed.PrintScreen(Bounds);
        }

        private void Form_Initialize_Renamed()
        {
            // Pi = 4 * System.Math.Atan(1.0#)
        }

        private void FormDistances_Load(object eventSender, EventArgs eventArgs)
        {
            cboIE.SelectedIndex = 0; // "on the arc"
            cboHE.SelectedIndex = 0; // "ft"
            cboHO.SelectedIndex = 0; // "ft"
        }

        private void optDistHorizon_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optDistHorizon.Checked)
            {
                TextBoxFormDistances.Clear();
                txtHE.Text = "";
                txtHO.Text = "";
                txtHsDeg.Text = "";
                txtHsMin.Text = "";
                txtHsSec.Text = "";
                txtIEdeg.Text = "";
                txtIEmin.Text = "";
                txtIESec.Text = "";
                lblHE.Visible = true;
                txtHE.Visible = true;
                cboHE.Visible = true;
                lblHO.Visible = false;
                txtHO.Visible = false;
                cboHO.Visible = false;
                lblHsFormat.Visible = false;
                optHsDMm.Visible = false;
                optHsDMS.Visible = false;
                lblHs.Visible = false;
                txtHsDeg.Visible = false;
                lblHsDeg.Visible = false;
                txtHsMin.Visible = false;
                lblHsMin.Visible = false;
                txtHsSec.Visible = false;
                lblHsSec.Visible = false;
                lblIE.Visible = false;
                txtIEdeg.Visible = false;
                lblIEdeg.Visible = false;
                txtIEmin.Visible = false;
                lblIEMin.Visible = false;
                txtIESec.Visible = false;
                lblIEsec.Visible = false;
                cboIE.Visible = false;
                Refresh();
            }
        }

        private void optGeogRange_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optGeogRange.Checked)
            {
                TextBoxFormDistances.Clear();
                txtHE.Text = "";
                txtHO.Text = "";
                txtHsDeg.Text = "";
                txtHsMin.Text = "";
                txtHsSec.Text = "";
                txtIEdeg.Text = "";
                txtIEmin.Text = "";
                txtIESec.Text = "";
                lblHE.Visible = true;
                txtHE.Visible = true;
                cboHE.Visible = true;
                lblHO.Visible = true;
                txtHO.Visible = true;
                cboHO.Visible = true;
                lblHsFormat.Visible = false;
                optHsDMm.Visible = false;
                optHsDMS.Visible = false;
                lblHs.Visible = false;
                txtHsDeg.Visible = false;
                lblHsDeg.Visible = false;
                txtHsMin.Visible = false;
                lblHsMin.Visible = false;
                txtHsSec.Visible = false;
                lblHsSec.Visible = false;
                lblIE.Visible = false;
                txtIEdeg.Visible = false;
                lblIEdeg.Visible = false;
                txtIEmin.Visible = false;
                lblIEMin.Visible = false;
                txtIESec.Visible = false;
                lblIEsec.Visible = false;
                cboIE.Visible = false;
                Refresh();
            }
        }

        private void optVertWaterTop_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optVertWaterTop.Checked)
            {
                TextBoxFormDistances.Clear();
                txtHE.Text = "";
                txtHO.Text = "";
                txtHsDeg.Text = "";
                txtHsMin.Text = "";
                txtHsSec.Text = "";
                txtIEdeg.Text = "";
                txtIEmin.Text = "";
                txtIESec.Text = "";
                lblHE.Visible = false;
                txtHE.Visible = false;
                cboHE.Visible = false;
                lblHO.Visible = true;
                txtHO.Visible = true;
                cboHO.Visible = true;
                lblHsFormat.Visible = true;
                optHsDMm.Visible = true;
                optHsDMS.Visible = true;
                lblHs.Visible = true;
                txtHsDeg.Visible = true;
                lblHsDeg.Visible = true;
                txtHsMin.Visible = true;
                lblHsMin.Visible = true;
                lblIE.Visible = true;
                txtIEdeg.Visible = true;
                lblIEdeg.Visible = true;
                txtIEmin.Visible = true;
                lblIEMin.Visible = true;
                cboIE.Visible = true;
                txtHsSec.Visible = false;
                lblHsSec.Visible = false;
                txtIESec.Visible = false;
                lblIEsec.Visible = false;
                if (optHsDMS.Checked == true)
                {
                    txtHsSec.Visible = true;
                    lblHsSec.Visible = true;
                    txtIESec.Visible = true;
                    lblIEsec.Visible = true;
                }
            }

            Refresh();
        }

        private void optVertWaterSea_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optVertWaterSea.Checked)
            {
                TextBoxFormDistances.Clear();
                txtHE.Text = "";
                txtHO.Text = "";
                txtHsDeg.Text = "";
                txtHsMin.Text = "";
                txtHsSec.Text = "";
                txtIEdeg.Text = "";
                txtIEmin.Text = "";
                txtIESec.Text = "";
                lblHE.Visible = true;
                txtHE.Visible = true;
                cboHE.Visible = true;
                lblHO.Visible = false;
                txtHO.Visible = false;
                cboHO.Visible = false;
                lblHsFormat.Visible = true;
                optHsDMm.Visible = true;
                optHsDMS.Visible = true;
                lblHs.Visible = true;
                txtHsDeg.Visible = true;
                lblHsDeg.Visible = true;
                txtHsMin.Visible = true;
                lblHsMin.Visible = true;
                lblIE.Visible = true;
                txtIEdeg.Visible = true;
                lblIEdeg.Visible = true;
                txtIEmin.Visible = true;
                lblIEMin.Visible = true;
                cboIE.Visible = true;
                txtHsSec.Visible = false;
                lblHsSec.Visible = false;
                txtIESec.Visible = false;
                lblIEsec.Visible = false;
                if (optHsDMS.Checked == true)
                {
                    txtHsSec.Visible = true;
                    lblHsSec.Visible = true;
                    txtIESec.Visible = true;
                    lblIEsec.Visible = true;
                }
            }

            Refresh();
        }

        private void optVertSeaTop_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (optVertSeaTop.Checked)
            {
                TextBoxFormDistances.Clear();
                txtHE.Text = "";
                txtHO.Text = "";
                txtHsDeg.Text = "";
                txtHsMin.Text = "";
                txtHsSec.Text = "";
                txtIEdeg.Text = "";
                txtIEmin.Text = "";
                txtIESec.Text = "";
                lblHE.Visible = true;
                txtHE.Visible = true;
                cboHE.Visible = true;
                lblHO.Visible = true;
                txtHO.Visible = true;
                cboHO.Visible = true;
                lblHsFormat.Visible = true;
                optHsDMm.Visible = true;
                optHsDMS.Visible = true;
                lblHs.Visible = true;
                txtHsDeg.Visible = true;
                lblHsDeg.Visible = true;
                txtHsMin.Visible = true;
                lblHsMin.Visible = true;
                lblIE.Visible = true;
                txtIEdeg.Visible = true;
                lblIEdeg.Visible = true;
                txtIEmin.Visible = true;
                lblIEMin.Visible = true;
                cboIE.Visible = true;
                txtHsSec.Visible = false;
                lblHsSec.Visible = false;
                txtIESec.Visible = false;
                lblIEsec.Visible = false;
                if (optHsDMS.Checked == true)
                {
                    txtHsSec.Visible = true;
                    lblHsSec.Visible = true;
                    txtIESec.Visible = true;
                    lblIEsec.Visible = true;
                }
            }

            Refresh();
        }

        private void txtHE_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        if (Conversions.ToBoolean(Strings.InStr(txtHE.Text, ".")))
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

        private void txtHE_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtHE;
            SelectAllText(ref argTB);
            txtHE = argTB;
        }

        private void txtHO_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        if (Conversions.ToBoolean(Strings.InStr(txtHO.Text, ".")))
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

        private void txtHO_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtHO;
            SelectAllText(ref argTB);
            txtHO = argTB;
        }

        private void FormDistances_FormClosed(object eventSender, FormClosedEventArgs eventArgs)
        {
            // Cleanup()
        }

        private void txtHsDeg_TextChanged(object eventSender, EventArgs eventArgs)
        {
            txtHsDeg.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtHsDeg.Text) > 89d)
            {
                txtHsDeg.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }
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
            if (Conversion.Val(txtHsDeg.Text) > 89d)
            {
                KeepFocus = true;
            }

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
            if (optHsDMm.Checked == true & (Conversion.Val(txtHsMin.Text) > 59.9d | Conversion.Val(txtHsMin.Text) < -59.9d))
            {
                KeepFocus = true;
            }

            if (optHsDMS.Checked == true & (Conversion.Val(txtHsMin.Text) > 59d | Conversion.Val(txtHsMin.Text) < -59.9d))
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
            if (Conversion.Val(txtHsSec.Text) > 59d | Conversion.Val(txtHsSec.Text) < -59)
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

        private void txtIEdeg_TextChanged(object eventSender, EventArgs eventArgs)
        {
            // This is not really necessary since only one digit is allowed
            txtIEdeg.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtIEdeg.Text) > 9d)
            {
                txtIEdeg.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }
        }

        private void txtIEdeg_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtIEdeg_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            // This is not really necessary since only one digit is allowed
            if (Conversion.Val(txtIEdeg.Text) > 9d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtIEDeg_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtIEdeg;
            SelectAllText(ref argTB);
            txtIEdeg = argTB;
        }

        private void txtIEmin_TextChanged(object eventSender, EventArgs eventArgs)
        {
            // txtIEmin.ForeColor = &H80000008
            txtIEmin.BackColor = Control.DefaultBackColor; 
            if (optHsDMm.Checked == true & Conversion.Val(txtIEmin.Text) > 59.9d)
            {
                txtIEmin.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (optHsDMS.Checked == true & Conversion.Val(txtIEmin.Text) > 59d)
            {
                txtIEmin.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }
        }

        private void txtIEmin_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        else if (Conversions.ToBoolean(Strings.InStr(txtIEmin.Text, ".")))
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

        private void txtIEmin_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (optHsDMm.Checked == true & Conversion.Val(txtHsMin.Text) > 59.9d)
            {
                KeepFocus = true;
            }

            if (optHsDMS.Checked == true & Conversion.Val(txtIEmin.Text) > 59d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtIEmin_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtIEmin;
            SelectAllText(ref argTB);
            txtIEmin = argTB;
        }

        private void txtIESec_TextChanged(object eventSender, EventArgs eventArgs)
        {
            txtIESec.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtIESec.Text) > 59d)
            {
                txtIESec.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }
        }

        private void txtIESec_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        private void txtIESec_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtIESec.Text) > 59d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtIESec_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtIESec;
            SelectAllText(ref argTB);
            txtIESec = argTB;
        }

        public void AltitudeCorrection()
        {
            if (optHsDMS.Checked == false)
            {
                txtHsSec.Text = "";
                txtIESec.Text = "";
            }

            ICMin = Conversion.Val(txtIEmin.Text) + Conversion.Val(txtIESec.Text) / 60d;
            if (cboIE.Text == "on the arc")
            {
                ICinMinutes = -(Conversion.Val(txtIEdeg.Text) * 60d + ICMin);
            }

            if (cboIE.Text == "off the arc (rdg.)")
            {
                ICMin = 60d - ICMin;
                if (ICMin == 60d)
                    ICMin = 0d;
                ICinMinutes = (Conversion.Val(txtIEdeg.Text) - 1d) * 60d + ICMin;
            }

            if (cboIE.Text == "off the arc (val.)")
            {
                ICinMinutes = Conversion.Val(txtIEdeg.Text) * 60d + ICMin;
            }

            Corr1 = ICinMinutes - Dip;
            Corr1Deg = (short)Conversion.Int(Math.Abs(Corr1 / 60d));
            Corr1Min = Math.Abs(Corr1) - 60 * Corr1Deg;
            hsinMinutes = 60d * Conversion.Val(txtHsDeg.Text) + Conversion.Val(txtHsMin.Text) + Conversion.Val(txtHsSec.Text) / 60d;
            HsMin = Conversion.Val(txtHsMin.Text) + Conversion.Val(txtHsSec.Text) / 60d;
            hainDegrees = (hsinMinutes + Corr1) / 60d;
            haDegrees = (short)(Math.Sign(hainDegrees) * Conversion.Int(Math.Abs(hainDegrees)));
            haMinutes = Math.Abs(hainDegrees - haDegrees) * 60d;
            haMinutes = Conversion.Int(haMinutes * 10d + 0.5d) / 10d;
        }

        private void optHsDMm_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            {
                if (optHsDMm.Checked == true)
                {
                    txtHsSec.Visible = false;
                    lblHsSec.Visible = false;
                    txtIESec.Visible = false;
                    lblIEsec.Visible = false;
                    txtHsMin.Text = "";
                    txtIEmin.Text = "";
                }
            }
        }

        private void optHsDMS_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            {
                if (optHsDMS.Checked == true)
                {
                    txtHsSec.Visible = true;
                    lblHsSec.Visible = true;
                    txtIESec.Visible = true;
                    lblIEsec.Visible = true;
                    txtHsMin.Text = "";
                    txtIEmin.Text = "";
                    txtHsSec.Text = "";
                    txtIESec.Text = "";
                }
            }
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