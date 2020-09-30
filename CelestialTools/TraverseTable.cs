using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    public partial class TraverseTable
    {
        public TraverseTable()
        {
            InitializeComponent();
            _txtLo1Min.Name = "txtLo1Min";
            _txtLo1Deg.Name = "txtLo1Deg";
            _txtL1Deg.Name = "txtL1Deg";
            _txtL1Min.Name = "txtL1Min";
            _txtCourse.Name = "txtCourse";
            _txtDist.Name = "txtDist";
            _cmdCalculate.Name = "cmdCalculate";
            _ExitBtn.Name = "ExitBtn";
            _btnPrintScreen.Name = "btnPrintScreen";
        }

        private string fnumeral;
        private double L1, Lo1, Distance;  // L2,Lo2,CourseAngle,
        private double Lm, LatDiff, DLo;
        private int L2Deg, Lo2Deg;
        private double Lo2Min, L2Min;
        private bool BadCLS;
        private double dphi, q;
        private double Fix1L, Fix1Lo;
        private string Prefix, Suffix;
        private float Departure, Factor, CompC, LmMin;
        private int IntLmMin, IntLatDiff, LmDeg, IntDLo;
        private double CourseAngle, L2, Lo2;

        private void cmdCalculate_Click(object sender, EventArgs e)
        {
            LatLong();
            string CString = txtCourse.Text + '°';
            if (Conversion.Val(txtCourse.Text) >= 0d & Conversion.Val(txtCourse.Text) < 90d)
            {
                CourseAngle = Conversion.Val(txtCourse.Text);
                Prefix = CommonGlobals.g_LatN;
                Suffix = CommonGlobals.g_LongE;
            }

            if (Conversion.Val(txtCourse.Text) >= 90d & Conversion.Val(txtCourse.Text) < 180d)
            {
                CourseAngle = 180d - Conversion.Val(txtCourse.Text);
                CString = "180" + '°' + "-" + txtCourse.Text + '°';
                Prefix = CommonGlobals.g_LatS;
                Suffix = CommonGlobals.g_LongE;
            }

            if (Conversion.Val(txtCourse.Text) >= 180d & Conversion.Val(txtCourse.Text) < 270d)
            {
                CourseAngle = Conversion.Val(txtCourse.Text) - 180d;
                CString = CString + "- 180" + '°';
                Prefix = CommonGlobals.g_LatS;
                Suffix = CommonGlobals.g_LongW;
            }

            if (Conversion.Val(txtCourse.Text) >= 270d & Conversion.Val(txtCourse.Text) < 360d)
            {
                CourseAngle = 360d - Conversion.Val(txtCourse.Text);
                CString = "360" + '°' + "-" + txtCourse.Text + '°';
                Prefix = CommonGlobals.g_LatN;
                Suffix = CommonGlobals.g_LongW;
            }

            if (Math.Abs(L2) > 90d)
            {
                ErrorMsgBox("Distance too large.  Cannot go this far along this rhumb line.");
                return;
            }

            Distance = Conversion.Val(txtDist.Text);
            Factor = (float)Math.Abs(Math.Cos(CourseAngle * Math.PI / 180d));
            Factor = (float)(Conversion.Int(Factor * 10f + 0.5d) / 10d);
            double Cfactor = Conversion.Int((Math.Cos(CourseAngle * Math.PI / 180d) * 10d + 0.5d) / 10d);
            LatDiff = Distance * Factor;
            LatDiff = Conversion.Int(LatDiff * 10d + 0.5d) / 10d;
            IntLatDiff = (int)Conversion.Int(LatDiff + 0.5d);
            txtSailings.Clear();
            txtSailings.AppendText(Constants.vbTab + Constants.vbTab + Constants.vbTab + " Simplified Traverse Table Worksheet" + Environment.NewLine + Environment.NewLine);
            txtSailings.SelectionAlignment = HorizontalAlignment.Left;
            txtSailings.WordWrap = true;
            txtSailings.AppendText("1." + Constants.vbTab + "Course: " + CString + "T => C = " + Prefix + " " + Math.Abs(CourseAngle).ToString() + '°' + " " + Suffix + Constants.vbTab + Constants.vbTab + "factor (C) = " + Math.Abs(Factor).ToString() + Environment.NewLine);
            Cfactor = Factor;
            CompC = (float)(90d - CourseAngle);
            Factor = (float)Math.Abs(Math.Cos(CompC * Math.PI / 180d));
            Factor = (float)(Conversion.Int(Factor * 10f + 0.5d) / 10d);
            Departure = (float)(Distance * Factor);
            Departure = (float)(Conversion.Int(Departure * 10f + 0.5d) / 10d);
            txtSailings.AppendText("2." + Constants.vbTab + "Complement C = 90" + '°' + "- C " + Environment.NewLine + "   " + Constants.vbTab + Constants.vbTab + "= 90" + '°' + "-" + CourseAngle.ToString("##0") + Environment.NewLine + "   " + Constants.vbTab + Constants.vbTab + "= " + CompC.ToString() + '°' + Constants.vbTab + Constants.vbTab + Constants.vbTab + Constants.vbTab + "factor (Comp C) = " + Factor.ToString() + Environment.NewLine);
            txtSailings.AppendText("3." + Constants.vbTab + "Diff Lat = D x factor(C) " + Environment.NewLine + "   " + Constants.vbTab + Constants.vbTab + "= " + Distance.ToString("##0.0") + " nm x " + Cfactor.ToString("#0.0") + Environment.NewLine + "   " + Constants.vbTab + Constants.vbTab + "= " + LatDiff.ToString("#0.0") + "'" + " rounded to " + IntLatDiff.ToString("#0") + "'" + Environment.NewLine);
            txtSailings.AppendText("4." + Constants.vbTab + "Departure = D x factor(Comp C) " + Environment.NewLine + "   " + Constants.vbTab + Constants.vbTab + "= " + Distance.ToString("##0.0") + " nm x " + Factor.ToString("#0.0") + Environment.NewLine + "   " + Constants.vbTab + Constants.vbTab + "= " + Math.Abs(Departure).ToString("#0.0") + " nm" + Environment.NewLine);
            string PlusMinusStr = "+";
            if (Conversion.Val(txtCourse.Text) > 90d & Conversion.Val(txtCourse.Text) < 270d)
            {
                IntLatDiff = -IntLatDiff;
                PlusMinusStr = "-";
            }

            L2 = L1 + IntLatDiff / 60d;
            if (Math.Abs(L2) >= 85d)
            {
                ErrorMsgBox("Latitude too high for Simplified Traverse Table, a form of mid-latitude sailing.");
                return;
            }

            L2Deg = (int)Conversion.Int(Math.Abs(L2));
            L2Min = (Math.Abs(L2) - L2Deg) * 60d;
            L2Min = Conversion.Int(L2Min + 0.5d);
            if (L2Min == 60d)
            {
                L2Min = 0d;
                L2Deg = L2Deg + 1;
            }

            if (Lo2Min == 60d)
            {
                Lo2Min = 0d;
                Lo2Deg = Lo2Deg + 1;
            }

            txtSailings.AppendText("5." + Constants.vbTab + "L2 = L1 (+/-) Diff Lat" + Environment.NewLine + "   " + Constants.vbTab + Constants.vbTab + "= " + txtL1Deg.Text.ToString() + '°' + txtL1Min.Text + "'" + cboL1.Text + " " + PlusMinusStr + " " + Math.Abs(IntLatDiff).ToString("0") + "'" + Environment.NewLine + "   " + Constants.vbTab + Constants.vbTab + "= " + L2Deg.ToString("0") + '°' + Strings.Format(L2Min, "00") + "'");
            if (Math.Abs(L2) < 0.01d)
            {
                L2 = 0d;
                txtSailings.AppendText("");
            }

            if (L2 > 0d & Math.Abs(L2) > 0.01d)
            {
                txtSailings.AppendText(CommonGlobals.g_LatN);
            }

            if (L2 < 0d & Math.Abs(L2) > 0.01d)
            {
                txtSailings.AppendText(CommonGlobals.g_LatS);
            }

            txtSailings.AppendText(Environment.NewLine);
            L2 = Math.Sign(L2) * (L2Deg + L2Min / 60d);
            Lm = (L1 + L2) / 2d; // Mid-latitude
            Factor = (float)Math.Abs(Math.Cos(Lm * Math.PI / 180d));
            Factor = (float)(Conversion.Int(Factor * 10f + 0.5d) / 10d);
            LmDeg = (int)Conversion.Int(Math.Abs(Lm));
            LmMin = (float)((Math.Abs(Lm) - LmDeg) * 60d);
            LmMin = (float)(Conversion.Int(LmMin * 10f + 0.5d) / 10d);
            IntLmMin = (int)Conversion.Int(LmMin + 0.5d);
            txtSailings.AppendText("6." + Constants.vbTab + "Mid Lat = L1 (+/-) (Diff Lat / 2) " + Environment.NewLine + "   " + Constants.vbTab + Constants.vbTab + "= " + txtL1Deg.Text.ToString() + '°' + txtL1Min.Text + "'" + cboL1.Text + " " + PlusMinusStr + " " + Math.Abs(IntLatDiff).ToString("0") + "/2'" + Environment.NewLine + "   " + Constants.vbTab + Constants.vbTab + "= " + Strings.Format(LmDeg, "0") + '°' + Strings.Format(LmMin, "00.0") + "'");
            if (Lm >= 0d)
            {
                txtSailings.AppendText(CommonGlobals.g_LatN);
            }

            if (Lm < 0d)
            {
                txtSailings.AppendText(CommonGlobals.g_LatS);
            }

            txtSailings.AppendText(" rounded to " + Strings.Format(LmDeg, "0") + '°' + Strings.Format(IntLmMin, "00") + "'");
            if (Lm >= 0d)
            {
                txtSailings.AppendText(CommonGlobals.g_LatN);
            }

            if (Lm < 0d)
            {
                txtSailings.AppendText(CommonGlobals.g_LatS);
            }

            // txtSailings.AppendText(vbNewLine)
            txtSailings.AppendText(Constants.vbTab + "factor (Mid-Lat) = " + Factor.ToString() + Environment.NewLine);
            DLo = Conversion.Int(Departure / Factor * 10f + 0.5d) / 10d;
            IntDLo = (int)(Math.Sign(DLo) * Conversion.Int(Math.Abs(DLo) + 0.5d));
            txtSailings.AppendText("7." + Constants.vbTab + "Diff Lo = Departure / factor (Mid-Lat)" + Environment.NewLine + "   " + Constants.vbTab + Constants.vbTab + "= " + Departure.ToString("#0.0") + " / " + Factor.ToString() + Environment.NewLine + "   " + Constants.vbTab + Constants.vbTab + "= " + DLo.ToString("#0.0") + "' rounded to " + IntDLo.ToString() + "'" + Environment.NewLine);
            if (Conversion.Val(txtCourse.Text) > 0d & Conversion.Val(txtCourse.Text) < 180d)
            {
                IntDLo = -IntDLo;
            }

            PlusMinusStr = " + ";
            if (IntDLo < 0)
            {
                PlusMinusStr = " - ";
            }

            Lo2 = Lo1 + IntDLo / 60d;
            while (Lo2 >= 360d)
                Lo2 = Lo2 - 360d;
            // Crossing IDL
            if (Math.Abs(Lo2) > 180d)
            {
                Lo2 = -Math.Sign(Lo2) * (360d - Math.Abs(Lo2));
            }

            Lo2Deg = (int)Conversion.Int(Math.Abs(Lo2));
            Lo2Min = (Math.Abs(Lo2) - Lo2Deg) * 60d;
            Lo2Min = Conversion.Int(Lo2Min + 0.5d);
            txtSailings.AppendText("8." + Constants.vbTab + "Lo2 = Lo1 (+/-) Diff Lo" + Environment.NewLine + "   " + Constants.vbTab + Constants.vbTab + "= " + txtLo1Deg.Text + '°' + " " + txtLo1Min.Text + "'" + cboLo1.Text + " " + PlusMinusStr + Math.Abs(IntDLo).ToString() + Environment.NewLine + "   " + Constants.vbTab + Constants.vbTab + "= " + Strings.Format(Lo2Deg, "0") + '°' + Strings.Format(Lo2Min, "00") + "'");
            if (Math.Abs(Lo2) < 0.01d)
            {
                Lo2 = 0d;
                txtSailings.AppendText("");
            }

            if (Math.Abs(Lo2) > 179.999d)
                txtSailings.AppendText("");
            if (Lo2 > 0d & Math.Abs(Lo2) < 179.999d)
            {
                txtSailings.AppendText(CommonGlobals.g_LongW);
            }

            if (Lo2 < 0d & Math.Abs(Lo2) < 179.999d)
            {
                txtSailings.AppendText(CommonGlobals.g_LongE);
            }

            txtSailings.AppendText(Environment.NewLine);
            txtSailings.AppendText(Environment.NewLine);
            txtSailings.AppendText("Arrival Position" + Constants.vbTab + "L2: " + Strings.Format(L2Deg, "0") + '°' + Strings.Format(L2Min, "00") + "'");
            if (Math.Abs(L2) < 0.01d)
            {
                L2 = 0d;
                txtSailings.AppendText("");
            }

            if (L2 > 0d & Math.Abs(L2) > 0.01d)
            {
                txtSailings.AppendText(CommonGlobals.g_LatN);
            }

            if (L2 < 0d & Math.Abs(L2) > 0.01d)
            {
                txtSailings.AppendText(CommonGlobals.g_LatS);
            }

            txtSailings.AppendText(Constants.vbTab + "Lo2: " + Strings.Format(Lo2Deg, "0") + '°' + Strings.Format(Lo2Min, "00") + "'");
            if (Math.Abs(Lo2) < 0.01d)
            {
                Lo2 = 0d;
                txtSailings.AppendText("");
            }

            if (Math.Abs(Lo2) > 179.999d)
            {
                txtSailings.AppendText("");
            }

            if (Lo2 > 0d & Math.Abs(Lo2) < 179.999d)
            {
                txtSailings.AppendText(CommonGlobals.g_LongW);
            }

            if (Lo2 < 0d & Math.Abs(Lo2) < 179.999d)
            {
                txtSailings.AppendText(CommonGlobals.g_LongE);
            }

            txtTraverseTbl.Clear();
            txtTraverseTbl.AppendText(Constants.vbTab + Constants.vbTab + Constants.vbTab + "Simplified Traverse Table" + Environment.NewLine);
            txtTraverseTbl.AppendText(Strings.Space(5) + "Angle  0" + '°' + Strings.Space(5) + "18" + '°' + Strings.Space(5) + "31" + '°' + Strings.Space(5) + "41" + '°' + Strings.Space(5) + "49" + '°' + Strings.Space(5) + "56" + '°' + Strings.Space(5) + "63" + '°' + Strings.Space(5) + "69" + '°' + Strings.Space(5) + "75" + '°' + Strings.Space(5) + "81" + '°' + Strings.Space(5) + "87" + '°' + Strings.Space(5) + "90" + '°');
            txtTraverseTbl.AppendText(Environment.NewLine);
            txtTraverseTbl.AppendText(Strings.Space(5) + "Factor" + Strings.Space(5) + "1.0" + Strings.Space(6) + "0.9" + Strings.Space(5) + "0.8" + Strings.Space(6) + "0.7" + Strings.Space(5) + "0.6" + Strings.Space(6) + "0.5" + Strings.Space(5) + "0.4" + Strings.Space(6) + "0.3" + Strings.Space(5) + "0.2" + Strings.Space(6) + "0.1" + Strings.Space(5) + "0.0");
            // if txtDist.Text = "" Then
            // txtSailings.AppendText("Distance   " & Format(Distance, "##0.0") & " nm")
            // End If
        }

        public void LatLong()
        {
            BadCLS = false;
            L1 = Conversion.Val(txtL1Deg.Text) + Conversion.Val(txtL1Min.Text) / 60d;
            if (cboL1.Text == "S")
                L1 = -L1;
            Lo1 = Conversion.Val(txtLo1Deg.Text) + Conversion.Val(txtLo1Min.Text) / 60d;
            if (cboLo1.Text == "E")
                Lo1 = -Lo1;
            // L2 = Val(txtL2Deg.Text) + Val(txtL2Min.Text) / 60
            // If cboL2.Text = "S" Then L2 = -L2
            // Lo2 = Val(txtLo2Deg.Text) + Val(txtLo2Min.Text) / 60
            // If cboLo2.Text = "E" Then Lo2 = -Lo2
            // If optMidLat.Checked = True And chkML.CheckState = 1 Then
            // If (optCD.Checked = True Or optSD.Checked = True) And Math.Abs(L1 - L2) > 1 Then
            // ErrorMsgBox("Maximum difference in latitude for CLS SAPS plot is 1º.")
            // BadCLS = True
            // Exit Sub
            // End If
            // If (optCD.Checked = True Or optSD.Checked = True) And Math.Abs(Lo1 - Lo2) > 1 Then
            // ErrorMsgBox("Maximum difference in longitude for CLS SAPS plot is 1º.")
            // BadCLS = True
            // Exit Sub
            // End If
            // LmML = Val(txtMLDeg.Text) + Val(cboMLmin.Text) / 60
            // If cboML.Text = "S" Then
            // LmML = -LmML
            // End If
            // TestML()
            // End If

            // Fix1L = Val(txtFix1LD.Text) + Val(txtFix1LM.Text) / 60
            // If cboFix1L.Text = "S" Then
            // Fix1L = -Fix1L
            // End If
            // Fix1Lo = Val(txtFix1LoD.Text) + Val(txtFix1LoM.Text) / 60
            // If cboFix1Lo.Text = "E" Then
            // Fix1Lo = -Fix1Lo
            // End If

        }

        private void txtL1Deg_TextChanged(object eventSender, EventArgs eventArgs)
        {
            txtL1Deg.BackColor = SystemColors.Window;
            if (Conversion.Val(txtL1Deg.Text) > 89d) // Or (Val(txtL1Deg.Text) = 90 And Val(txtL1Min.Text) <> 0) Then
            {
                txtL1Deg.BackColor = Color.Red;
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtL1Deg.Text) <= 89d)
            {
                txtL1Min.BackColor = SystemColors.Window;
            }
        }

        private void txtL1Deg_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            int KeyAscii = Strings.Asc(eventArgs.KeyChar);
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

        private void txtL1Deg_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtL1Deg.Text) > 89d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtL1Deg_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtL1Deg;
            SelectAllText(ref argTB);
            txtL1Deg = argTB;
        }

        private void txtL1Min_TextChanged(object eventSender, EventArgs eventArgs)
        {
            txtL1Min.BackColor = SystemColors.Window;
            if (Conversion.Val(txtL1Min.Text) > 59.9d)
            {
                txtL1Min.BackColor = Color.Red;
                ErrorMsgBox("Out of Range");
            }
        }

        private void txtL1Min_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            int KeyAscii = Strings.Asc(eventArgs.KeyChar);
            switch (KeyAscii)
            {
                case var @case when Strings.Asc("0") <= @case && @case <= Strings.Asc("9"):
                    {
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                case (short)('.'): // only allows one decimal point
                    {
                        if (Conversions.ToBoolean(Strings.InStr(txtL1Min.Text, ".")))
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

        private void txtL1Min_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtL1Min.Text) > 59.9d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtL1Min_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtL1Min;
            SelectAllText(ref argTB);
            txtL1Min = argTB;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtLo1Deg_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtLo1Deg.Text) != 180d)
            {
                txtLo1Min.Enabled = true;
            }

            if (Conversion.Val(txtLo1Deg.Text) == 180d)
            {
                txtLo1Min.Text = "";
                txtLo1Min.Enabled = false;
                txtLo1Min.BackColor = Color.Gray;
            }

            txtLo1Deg.BackColor = SystemColors.Window;
            if (Conversion.Val(txtLo1Deg.Text) > 180d | Conversion.Val(txtLo1Deg.Text) == 180d & Conversion.Val(txtLo1Min.Text) != 0d)
            {
                txtLo1Deg.BackColor = Color.Red;
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtLo1Deg.Text) < 180d)
            {
                txtLo1Min.BackColor = SystemColors.Window;
            }
        }

        private bool FormLoading = false;

        private void TraverseTable_Load(object sender, EventArgs e)
        {
            FormLoading = true;
            cboL1.SelectedIndex = 0;
            cboLo1.SelectedIndex = 0;
            FormLoading = false;
            return;
        }

        private void btnPrintScreen_Click(object sender, EventArgs e)
        {
            // ScreenCapture()
            Print_Renamed.PrintScreen(Bounds);
            Focus();
            return;
        }

        private void txtLo1Deg_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            int KeyAscii = Strings.Asc(eventArgs.KeyChar);
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

        private void txtLo1Deg_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtLo1Deg.Text) > 180d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtLo1Deg_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtLo1Deg;
            SelectAllText(ref argTB);
            txtLo1Deg = argTB;
        }

        private void txtLo1Min_TextChanged(object eventSender, EventArgs eventArgs)
        {
            txtLo1Min.BackColor = SystemColors.Window;
            if (Conversion.Val(txtLo1Min.Text) > 59.9d)
            {
                txtLo1Min.BackColor = Color.Red;
                ErrorMsgBox("Out of Range");
            }
        }

        private void txtLo1Min_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            int KeyAscii = Strings.Asc(eventArgs.KeyChar);
            switch (KeyAscii)
            {
                case var @case when Strings.Asc("0") <= @case && @case <= Strings.Asc("9"):
                    {
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                case (short)('.'): // only allows one decimal point
                    {
                        if (Conversions.ToBoolean(Strings.InStr(txtLo1Min.Text, ".")))
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

        private void txtLo1Min_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtLo1Min.Text) > 59.9d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtLo1Min_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtLo1Min;
            SelectAllText(ref argTB);
            txtLo1Min = argTB;
        }

        private void txtCourse_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtCourse.Text) > 359.9d)
            {
                txtCourse.BackColor = Color.Red;
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtCourse.Text) < 359.9d)
            {
                txtCourse.BackColor = SystemColors.Window;
            }
        }

        private void txtCourse_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            int KeyAscii = Strings.Asc(eventArgs.KeyChar);
            switch (KeyAscii)
            {
                case var @case when Strings.Asc("0") <= @case && @case <= Strings.Asc("9"):
                    {
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                case (short)('.'): // only allows one decimal point
                    {
                        if (Conversions.ToBoolean(Strings.InStr(txtCourse.Text, ".")))
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

        private void txtCourse_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtCourse.Text) > 359.9d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtCourse_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtCourse;
            SelectAllText(ref argTB);
            txtCourse = argTB;
        }

        private void txtDist_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtDist.Text) > 10800d)
            {
                txtDist.BackColor = Color.Red;
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtDist.Text) <= 10800d)
            {
                // txtDist.ForeColor = &H80000008
                txtDist.BackColor = SystemColors.Window;
            }
        }

        private void txtDist_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            int KeyAscii = Strings.Asc(eventArgs.KeyChar);
            switch (KeyAscii)
            {
                case var @case when Strings.Asc("0") <= @case && @case <= Strings.Asc("9"):
                    {
                        fnumeral = fnumeral + (char)KeyAscii;
                        break;
                    }

                case (short)('.'): // only allows one decimal point
                    {
                        if (Conversions.ToBoolean(Strings.InStr(txtDist.Text, ".")))
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

            eventArgs.KeyChar = (char)KeyAscii;
            if (KeyAscii == 0)
            {
                eventArgs.Handled = true;
            }
        }

        private void txtDist_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            eventArgs.Cancel = KeepFocus;
        }

        private void txtDist_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtDist;
            SelectAllText(ref argTB);
            txtDist = argTB;
        }

        private static void SelectAllText(ref TextBox TB)
        {
            TB.SelectionStart = 0;
            TB.SelectionLength = TB.Text.ToString().Length;
        }

        private static void ErrorMsgBox(string ErrMsg)
        {
            MessageBox.Show(ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            return;
        }
    }
}