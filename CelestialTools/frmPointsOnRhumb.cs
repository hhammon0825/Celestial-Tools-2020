using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    internal partial class frmPointsOnRhumb : Form
    {
        public frmPointsOnRhumb()
        {
            InitializeComponent();
            _cmdPrint.Name = "cmdPrint";
            _txtLDeg.Name = "txtLDeg";
            _txtLoMin.Name = "txtLoMin";
            _txtLoDeg.Name = "txtLoDeg";
            _txtLMin.Name = "txtLMin";
            _cmdCalculate.Name = "cmdCalculate";
            _cmdClear.Name = "cmdClear";
            _ExitBtn.Name = "ExitBtn";
        }

        private void cmdPrint_Click(object eventSender, EventArgs eventArgs)
        {
            // FormHeight = PixelsToTwipsY(Me.Height)
            // FormWidth = PixelsToTwipsX(Me.Width)
            Print_Renamed.PrintScreen(Bounds);
        }

        private void cmdCalculate_Click(object eventSender, EventArgs eventArgs)
        {
            bool ExceedFlag;
            double Course, CourseAngle = default;
            double L;
            double Lo;
            double L1, L2, Lo1, Lo2, Distance;
            double LoWest, Lo1West, Lo2West;
            var LDeg = default(short);
            var LoDeg = default(short);
            short Sign;
            double LMin = default, LoMin = default;
            double DLo, LPoint = default, LoPoint = default;
            double Pi;
            ExceedFlag = false;  // :LFlag = False: LoFlag = False
            Pi = 4d * Math.Atan(1.0d);
            L1 = Conversion.Val(My.MyProject.Forms.FormSailings.txtL1Deg.Text) + Conversion.Val(My.MyProject.Forms.FormSailings.txtL1Min.Text) / 60d;
            if (My.MyProject.Forms.FormSailings.cboL1.Text == "S")
                L1 = -L1;
            Lo1 = Conversion.Val(My.MyProject.Forms.FormSailings.txtLo1Deg.Text) + Conversion.Val(My.MyProject.Forms.FormSailings.txtLo1Min.Text) / 60d;
            Lo1West = Lo1;
            if (My.MyProject.Forms.FormSailings.cboLo1.Text == "E")
            {
                Lo1 = -Lo1;
                Lo1West = 360d - Lo1West;
            }
            // L2 = Val(FormSailings.txtL2Deg.text) + Val(FormSailings.txtL2Min.text) / 60
            // If FormSailings.cboL2 = "S" Then L2 = -L2
            // Lo2 = Val(FormSailings.txtLo2Deg.text) + Val(FormSailings.txtLo2Min.text) / 60
            // If FormSailings.cboLo2 = "E" Then Lo2 = -Lo2
            // L1 = FormSailings.L1
            L2 = My.MyProject.Forms.FormSailings.L2;
            // Lo1 = FormSailings.Lo1
            Lo2 = My.MyProject.Forms.FormSailings.Lo2;
            Lo2West = Lo2;
            if (Lo2West < 0d)
                Lo2West = 360d - Math.Abs(Lo2West);
            L = Conversion.Val(txtLDeg.Text) + Conversion.Val(txtLMin.Text) / 60d;
            if (cboL.Text == "S")
                L = -L;
            Lo = Conversion.Val(txtLoDeg.Text) + Conversion.Val(txtLoMin.Text) / 60d;
            LoWest = Lo;
            if (cboLo.Text == "E")
            {
                Lo = -Lo;
                LoWest = 360d - LoWest;
            }

            if (My.MyProject.Forms.FormSailings.optCD.Checked == true | My.MyProject.Forms.FormSailings.optSD.Checked == true)
                CourseAngle = My.MyProject.Forms.FormSailings.CourseAngle;
            if (My.MyProject.Forms.FormSailings.optL2Lo2.Checked == true)
                CourseAngle = My.MyProject.Forms.FormSailings.CourseAngle * Pi / 180d;
            if (!string.IsNullOrEmpty(txtLDeg.Text) & !string.IsNullOrEmpty(txtLMin.Text))
            {
                if (L1 > L2 & (L > L1 | L < L2) | L2 > L1 & (L > L2 | L < L1))
                    ExceedFlag = true;  // LFlag = True 'MsgBox "Latitude exceeds limits of rhumb line.": Exit Sub
            }

            if (!string.IsNullOrEmpty(txtLoDeg.Text) & !string.IsNullOrEmpty(txtLoMin.Text))
            {
                if (Math.Abs(Lo2 - Lo1) <= 180d)
                {
                    if (Lo1 > Lo2 & (Lo < Lo2 | Lo > Lo1) | Lo2 > Lo1 & (Lo < Lo1 | Lo > Lo2))
                        ExceedFlag = true;  // LoFlag = True 'MsgBox "Longitude exceeds limits of rhumb line.": Exit Sub
                }

                if (Math.Abs(Lo2 - Lo1) > 180d)
                {
                    if (Lo1West > Lo2West & (LoWest > Lo1West | LoWest < Lo2West) | Lo2West > Lo1West & (LoWest > Lo2West | LoWest < Lo1West))
                        ExceedFlag = true;  // LoFlag = True 'MsgBox "Longitude exceeds limits of rhumb line.": Exit Sub
                }
            }
            // If LFlag = True And LoFlag = True Then Cls: MsgBox "Warning:  Latitude and longitude exceed limits of rhumb line route.": ExceedFlag = True ': Cls: Exit Sub
            // If LFlag = True And ExceedFlag = False Then Cls: MsgBox "Warning:  Latitude exceeds limits of rhumb line route." ': Exit Sub
            // If LoFlag = True And ExceedFlag = False Then Cls: MsgBox "Warning:  Longitude exceeds limits of rhumb line route." ': Exit Sub

            // Calculate latitude
            if (!string.IsNullOrEmpty(txtLoDeg.Text) | !string.IsNullOrEmpty(txtLoMin.Text))
            {
                Sign = 1;
                if (string.IsNullOrEmpty(My.MyProject.Forms.FormSailings.txtCourse.Text))
                    Course = My.MyProject.Forms.FormSailings.Course;
                else
                    Course = Conversion.Val(My.MyProject.Forms.FormSailings.txtCourse.Text);
                if (LoWest > Lo1West & Course < 90d)
                    Sign = -1;
                if (LoWest < Lo1West & Course >= 90d & Course < 180d)
                    Sign = -1;
                if (LoWest > Lo1West & Course >= 180d & Course < 270d)
                    Sign = -1;
                if (LoWest < Lo1West & Course >= 270d & Course < 360d)
                    Sign = -1;
                DLo = LoWest - Lo1West;
                // Crossing IDL or shorter route
                if (Math.Abs(DLo) > 180d)
                {
                    DLo = -Math.Sign(DLo) * (360d - Math.Abs(DLo));
                    Sign = (short)(-Sign);
                }

                Distance = Math.Abs(DLo * Math.Cos((L1 + L2) / 2d * Pi / 180d) / Math.Sin(CourseAngle));
                LPoint = L1 + Sign * Distance * Math.Cos(CourseAngle);
                LDeg = (short)Conversion.Int(Math.Abs(LPoint));
                LMin = (Math.Abs(LPoint) - LDeg) * 60d;
                LMin = Conversion.Int(LMin * 10d + 0.5d) / 10d;
                if (Conversion.Int(LMin * 10d + 0.5d) / 10d == 60d)
                {
                    LMin = 0d;
                    LDeg = (short)(LDeg + 1);
                }

                LPoint = Math.Sign(LPoint) * (LDeg + LMin / 60d);
            }

            // Calculate longitude
            if (!string.IsNullOrEmpty(txtLDeg.Text) | !string.IsNullOrEmpty(txtLMin.Text))
            {
                Sign = 1;
                if (string.IsNullOrEmpty(My.MyProject.Forms.FormSailings.txtCourse.Text))
                    Course = My.MyProject.Forms.FormSailings.Course;
                else
                    Course = Conversion.Val(My.MyProject.Forms.FormSailings.txtCourse.Text);
                if (L > L1 & Course < 90d)
                    Sign = -1;
                if (L < L1 & Course >= 90d & Course < 180d)
                    Sign = -1;
                if (L > L1 & Course >= 180d & Course < 270d)
                    Sign = -1;
                if (L < L1 & Course >= 270d & Course < 360d)
                    Sign = -1;
                Distance = Math.Abs((L1 - L) / Math.Cos(CourseAngle));
                DLo = Distance * Math.Sin(Math.Abs(CourseAngle)) / Math.Cos((L1 + L2) / 2d * Pi / 180d);
                // Crossing IDL
                if (Math.Abs(DLo) > 180d)
                    DLo = -Math.Sign(DLo) * (360d - Math.Abs(DLo));
                LoPoint = Lo1 + Sign * DLo;
                if (Math.Abs(LoPoint) > 180d)
                    LoPoint = -Math.Sign(LoPoint) * (360d - Math.Abs(LoPoint));
                LoDeg = (short)Conversion.Int(Math.Abs(LoPoint));
                LoMin = (Math.Abs(LoPoint) - LoDeg) * 60d;
                LoMin = Conversion.Int(LoMin * 10d + 0.5d) / 10d;
                if (Conversion.Int(LoMin * 10d + 0.5d) / 10d == 60d)
                {
                    LoMin = 0d;
                    LoDeg = (short)(LoDeg + 1);
                }

                LoPoint = Math.Sign(LoPoint) * (LoDeg + LoMin / 60d);
            }
            // 

            RhumbPointsTxtBx.Clear();
            RhumbPointsTxtBx.AppendText(Strings.Space(15) + "Longitude" + Strings.Space(43) + "Latitude" + Constants.vbNewLine);
            if (!string.IsNullOrEmpty(txtLDeg.Text) | !string.IsNullOrEmpty(txtLMin.Text))
            {
                RhumbPointsTxtBx.AppendText(Strings.Space(14) + Strings.Format(LoDeg, "0") + '°' + Strings.Format(LoMin, "00.0") + "'");
                if (LoPoint > 0d & Math.Abs(LoPoint) != 180d)
                    RhumbPointsTxtBx.AppendText(CommonGlobals.g_LongW);
                if (LoPoint == 0d | Math.Abs(LoPoint) == 180d)
                    RhumbPointsTxtBx.AppendText(CommonGlobals.g_StrSpace);
                if (LoPoint < 0d & Math.Abs(LoPoint) != 180d)
                    RhumbPointsTxtBx.AppendText(CommonGlobals.g_LongE);
            }

            if (!string.IsNullOrEmpty(txtLoDeg.Text) | !string.IsNullOrEmpty(txtLoMin.Text))
            {
                if (!string.IsNullOrEmpty(txtLDeg.Text) | !string.IsNullOrEmpty(txtLMin.Text))
                {
                    RhumbPointsTxtBx.AppendText(Strings.Space(41) + Strings.Format(LDeg, "0") + '°' + Strings.Format(LMin, "00.0") + "'");
                }

                if (string.IsNullOrEmpty(txtLDeg.Text) & string.IsNullOrEmpty(txtLMin.Text))
                {
                    RhumbPointsTxtBx.AppendText(Strings.Space(66) + Strings.Format(LDeg, "0") + '°' + Strings.Format(LMin, "00.0") + "'");
                }

                if (LPoint > 0d)
                    RhumbPointsTxtBx.AppendText(CommonGlobals.g_LatN);
                if (LPoint == 0d)
                    RhumbPointsTxtBx.AppendText(CommonGlobals.g_StrSpace);
                if (LPoint < 0d)
                    RhumbPointsTxtBx.AppendText(CommonGlobals.g_LatS);
            }

            if (string.IsNullOrEmpty(txtLoDeg.Text) & string.IsNullOrEmpty(txtLoMin.Text))
                RhumbPointsTxtBx.AppendText(Constants.vbNewLine);
            // If LFlag = True Or LoFlag = True Then Print Tab(11); "Point(s) beyond limits of rhumb line course."
            if (ExceedFlag == true)
                RhumbPointsTxtBx.AppendText(Strings.Space(7) + "Warning:  Point(s) beyond limits of rhumb line course.");
            My.MyProject.Forms.FormSailings.cmdRhumbPoints.Enabled = false;
        }

        private void txtLDeg_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtLDeg.Text) != 90d)
                txtLMin.Enabled = true;
            if (Conversion.Val(txtLDeg.Text) == 90d)
            {
                txtLMin.Clear();
                txtLMin.Enabled = false;
                txtLMin.BackColor = Color.Gray;
            }
            // txtLDeg.ForeColor = &H80000008
            txtLDeg.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtLDeg.Text) > 90d)
            {
                txtLDeg.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtLDeg.Text) < 90d)
            {
                txtLMin.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtLDeg_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        private void txtLDeg_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtLDeg.Text) > 90d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtLDeg_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtLDeg;
            SelectAllText(ref argTB);
            txtLDeg = argTB;
        }

        private void txtLMin_TextChanged(object eventSender, EventArgs eventArgs)
        {
            txtLMin.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtLMin.Text) > 59.9d)
            {
                txtLMin.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }
        }

        private void txtLMin_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        if (Conversions.ToBoolean(Strings.InStr(txtLMin.Text, ".")))
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

        private void txtLMin_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtLMin.Text) > 59.9d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtLMin_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtLMin;
            SelectAllText(ref argTB);
            txtLMin = argTB;
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

        private void SelectAllText(ref TextBox TB)
        {
            TB.SelectionStart = 0;
            TB.SelectionLength = Strings.Len(TB.Text);
        }

        private void frmPointsOnRhumb_Load(object eventSender, EventArgs eventArgs)
        {
            // Next two lines center form on screen without StartUpPosition so form stays where last positioned despite graphics
            // Me.Left = (Screen.Width - Me.Width) / 2
            // Me.Top = (Screen.Height - Me.Height) / 2
            cboL.SelectedIndex = 0;  // "N"
            cboLo.SelectedIndex = 0; // "W"
        }

        private void frmPointsOnRhumb_FormClosed(object eventSender, FormClosedEventArgs eventArgs)
        {
            // Cleanup()
        }

        private void ErrorMsgBox(string ErrMsg)
        {
            MessageBox.Show(ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            return;
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            txtLDeg.Text = "";
            txtLMin.Text = "";
            txtLoDeg.Text = "";
            txtLoMin.Text = "";
            RhumbPointsTxtBx.Clear();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}