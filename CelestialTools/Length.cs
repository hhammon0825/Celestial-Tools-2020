using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    internal partial class FormLength : Form
    {
        private float LengthDegLSpherefeet, LengthDegLSpherenm, LengthDegLSpheremeters, LengthDegLSpheresm;
        private float LengthDegLoSpherefeet, LengthDegLoSpherenm, LengthDegLoSpheremeters, LengthDegLoSpheresm;
        private float LengthDegLWGS84feet, LengthDegLWGS84nm, LengthDegLWGS84meters, LengthDegLWGS84sm;
        private float LengthDegLoWGS84feet, LengthDegLoWGS84nm, LengthDegLoWGS84meters, LengthDegLoWGS84sm;
        private double LatIn, LatInRad, Pi;
        private string fnumeral;
        private bool FormLengthLoaded = false;
        private string FileTextLine = Constants.vbNullString;

        private void FormLength_Load(object sender, EventArgs e)
        {
            // txtLDeg.Clear()
            txtLDeg.Text = "0";
            // txtLMin.Clear()
            txtLMin.Text = "0";
            FormLengthLoaded = true;
            WriteLengthCSV();
            string FName = "./Graphics/Length1Degree" + ".csv";
            string tablename = "export";
            var DataSet = new DataSet();
            DataSet.Tables.Add(tablename);
            DataSet.Tables[tablename].Columns.Add("Latitude");
            DataSet.Tables[tablename].Columns.Add("Lat Feet");
            DataSet.Tables[tablename].Columns.Add("Lat Meter");
            DataSet.Tables[tablename].Columns.Add("Lat StatMile");
            DataSet.Tables[tablename].Columns.Add("Lat NautMile");
            DataSet.Tables[tablename].Columns.Add("Lo  Feet");
            DataSet.Tables[tablename].Columns.Add("Lo  Meter");
            DataSet.Tables[tablename].Columns.Add("Lo  StatMile");
            DataSet.Tables[tablename].Columns.Add("Lo  NautMile");
            var SR = new System.IO.StreamReader(FName);
            string allData = SR.ReadToEnd();
            var rows = allData.Split(Conversions.ToChar(Constants.vbCrLf)); // ("\r".ToCharArray())
            foreach (string r in rows)
            {
                var items = r.Split(',');
                if ((items[0] ?? "") != Constants.vbLf)
                {
                    DataSet.Tables[tablename].Rows.Add(items);
                }
            }

            DataGridView1.DataSource = DataSet.Tables[0].DefaultView;
            return;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void cmdPrint_Click(object eventSender, EventArgs eventArgs)
        {
            Print_Renamed.PrintScreen(Bounds);
        }

        private void Calculate()
        {

            // Pi = 4 * System.Math.Atan(1.0#)
            Pi = Math.PI;
            txtLength.Clear();
            if (string.IsNullOrEmpty(txtLDeg.Text))
            {
                txtLDeg.Text = "0";
            }

            if (string.IsNullOrEmpty(txtLMin.Text))
            {
                txtLMin.Text = "0";
            }

            LatIn = Convert.ToDouble(txtLDeg.Text) + Convert.ToDouble(txtLMin.Text) / 60d;
            LatInRad = LatIn * (Pi / 180d);

            // 1 degree of latitude spherical is constant at all latitudes so the next 4 statements remain the same no matter what latitude was entered
            LengthDegLSpherenm = 60f;
            LengthDegLSpheremeters = LengthDegLSpherenm * 1852f;
            LengthDegLSpherefeet = (float)(LengthDegLSpheremeters * 3.2808399d);
            LengthDegLSpheresm = LengthDegLSpherefeet / 5280f;
            // now the 1 degree of lat or long from here are calculated using latitude angle entered converted to radians
            LengthDegLoSpherenm = (float)(60d * Math.Cos(LatInRad));
            LengthDegLoSpheremeters = LengthDegLoSpherenm * 1852f;
            LengthDegLoSpherefeet = (float)(LengthDegLoSpheremeters * 3.2808399d);
            LengthDegLoSpheresm = LengthDegLoSpherefeet / 5280f;
            LengthDegLWGS84meters = (float)(111132.92d - 559.82d * Math.Cos(2d * LatInRad) + 1.175d * Math.Cos(4d * LatInRad) - 0.0023d * Math.Cos(6d * LatInRad));
            LengthDegLWGS84feet = (float)(LengthDegLWGS84meters * 3.2808399d);
            LengthDegLWGS84sm = LengthDegLWGS84feet / 5280f;
            LengthDegLWGS84nm = LengthDegLWGS84meters / 1852f;
            LengthDegLoWGS84meters = (float)(111412.84d * Math.Cos(LatInRad) - 93.5d * Math.Cos(3d * LatInRad) + 0.118d * Math.Cos(5d * LatInRad));
            LengthDegLoWGS84feet = (float)(LengthDegLoWGS84meters * 3.2808399d);
            LengthDegLoWGS84sm = LengthDegLoWGS84feet / 5280f;
            LengthDegLoWGS84nm = LengthDegLoWGS84meters / 1852f;
            txtLength.AppendText(Constants.vbNewLine + Constants.vbTab + "At Latitude: " + Strings.Format(Convert.ToInt32(txtLDeg.Text), "#0") + '°' + Strings.Space(1) + Strings.Format(Convert.ToDouble(txtLMin.Text), "#0.0") + "'" + Constants.vbNewLine + Constants.vbNewLine);
            txtLength.AppendText(Constants.vbTab + "Length of 1" + '°' + " of LATITUDE:" + Constants.vbNewLine);
            txtLength.AppendText(Constants.vbTab + Constants.vbTab + Constants.vbTab + "Sphere" + Constants.vbTab + "WGS84 Spheroid" + Constants.vbNewLine);
            txtLength.AppendText(Constants.vbTab + "Feet" + Constants.vbTab + Constants.vbTab + Strings.Format(LengthDegLSpherefeet, "#,0") + Constants.vbTab + Strings.Format(LengthDegLWGS84feet, "#,0") + Constants.vbNewLine);
            txtLength.AppendText(Constants.vbTab + "Meters" + Constants.vbTab + Constants.vbTab + Strings.Format(LengthDegLSpheremeters, "#,0") + Constants.vbTab + Strings.Format(LengthDegLWGS84meters, "#,0") + Constants.vbNewLine);
            txtLength.AppendText(Constants.vbTab + "Statute Miles" + Constants.vbTab + Strings.Format(LengthDegLSpheresm, "#0.000") + Constants.vbTab + Strings.Format(LengthDegLWGS84sm, "#0.000") + Constants.vbNewLine);
            txtLength.AppendText(Constants.vbTab + "Nautical Miles" + Constants.vbTab + Strings.Format(LengthDegLSpherenm, "#0.000") + Constants.vbTab + Strings.Format(LengthDegLWGS84nm, "#0.000") + Constants.vbNewLine + Constants.vbNewLine);
            txtLength.AppendText(Constants.vbTab + "Length of 1" + '°' + " of LONGITUDE:" + Constants.vbNewLine);
            txtLength.AppendText(Constants.vbTab + Constants.vbTab + Constants.vbTab + "Sphere" + Constants.vbTab + "WGS84 Spheroid" + Constants.vbNewLine);
            txtLength.AppendText(Constants.vbTab + "Feet" + Constants.vbTab + Constants.vbTab + Strings.Format(LengthDegLoSpherefeet, "#,0") + Constants.vbTab + Strings.Format(LengthDegLoWGS84feet, "#,0") + Constants.vbNewLine);
            txtLength.AppendText(Constants.vbTab + "Meters" + Constants.vbTab + Constants.vbTab + Strings.Format(LengthDegLoSpheremeters, "#,0") + Constants.vbTab + Strings.Format(LengthDegLoWGS84meters, "#,0") + Constants.vbNewLine);
            txtLength.AppendText(Constants.vbTab + "Statute Miles" + Constants.vbTab + Strings.Format(LengthDegLoSpheresm, "#0.000") + Constants.vbTab + Strings.Format(LengthDegLoWGS84sm, "#0.000") + Constants.vbNewLine);
            txtLength.AppendText(Constants.vbTab + "Nautical Miles" + Constants.vbTab + Strings.Format(LengthDegLoSpherenm, "#0.000") + Constants.vbTab + Strings.Format(LengthDegLoWGS84nm, "#0.000") + Constants.vbNewLine);
        }

        private void txtLDeg_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (FormLengthLoaded == false)
                return;
            if (Conversion.Val(txtLDeg.Text) != 90d)
            {
                txtLMin.Enabled = true;
            }

            if (Conversion.Val(txtLDeg.Text) == 90d)
            {
                txtLMin.Text = "0.0";
                txtLMin.Enabled = false;
                txtLMin.BackColor = Color.Gray;
            }

            txtLDeg.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtLDeg.Text) > 90d)
            {
                txtLDeg.BackColor = ColorTranslator.FromOle(0xFF);
                txtLDeg.SelectAll();
                ErrorMsgBox("Out of Range - Latitude Degree value must be 0 thru 90");
                return;
            }

            if (Conversion.Val(txtLDeg.Text) == 90d & Conversion.Val(txtLMin.Text) != 0d)
            {
                txtLDeg.BackColor = ColorTranslator.FromOle(0xFF);
                txtLDeg.SelectAll();
                ErrorMsgBox("Out of Range - Latitude Minutes value must be 0 if Degrees is 90");
                return;
            }

            if (Conversion.Val(txtLDeg.Text) < 90d)
            {
                txtLMin.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtLDeg_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            if (FormLengthLoaded == false)
                return;
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
                        ErrorMsgBox("Invalid Latitude Degree");
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
            if (FormLengthLoaded == false)
                return;
            // Dim KeepFocus As Boolean = eventArgs.Cancel
            // If Val(txtLDeg.Text) > 90 Then
            // KeepFocus = True
            // End If
            // eventArgs.Cancel = KeepFocus
        }

        private void txtLDeg_Enter(object eventSender, EventArgs eventArgs)
        {
            if (FormLengthLoaded == false)
                return;
            // txtLDeg.SelectAll()

        }

        private void txtLMin_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (FormLengthLoaded == false)
                return;
            // txtLMin.ForeColor = &H80000008
            txtLMin.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtLMin.Text) > 59.9d)
            {
                txtLMin.BackColor = ColorTranslator.FromOle(0xFF);
                txtLMin.SelectAll();
                ErrorMsgBox("Out of Range - - Latitude Minutes value must be 0 thru 59.9");
                return;
            }
        }

        private void txtLMin_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            if (FormLengthLoaded == false)
                return;
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
                        ErrorMsgBox("Invalid Latitude Minute");
                        return;
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
            if (FormLengthLoaded == false)
                return;
            // Dim KeepFocus As Boolean = eventArgs.Cancel
            // If Val(txtLMin.Text) > 59.9 Then
            // KeepFocus = True
            // End If
            // eventArgs.Cancel = KeepFocus
        }

        private void txtLMin_Enter(object eventSender, EventArgs eventArgs)
        {
            if (FormLengthLoaded == false)
                return;
            // txtLMin.SelectAll()

        }

        private void FormLength_FormClosed(object eventSender, FormClosedEventArgs eventArgs)
        {
            // Cleanup()
        }

        private void ErrorMsgBox(string ErrMsg)
        {
            MessageBox.Show(ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            return;
        }

        private string CalculateForFile(double LatParmIn)
        {
            // Pi = 4 * System.Math.Atan(1.0#)

            Pi = Math.PI;
            txtLength.Clear();

            // LatIn = Convert.ToDouble(txtLDeg.Text) + (Convert.ToDouble(txtLMin.Text) / 60)
            LatInRad = LatParmIn * (Pi / 180d);

            // 1 degree of latitude spherical is constant at all latitudes so the next 4 statements remain the same no matter what latitude was entered
            LengthDegLSpherenm = 60f;
            LengthDegLSpheremeters = LengthDegLSpherenm * 1852f;
            LengthDegLSpherefeet = (float)(LengthDegLSpheremeters * 3.2808399d);
            LengthDegLSpheresm = LengthDegLSpherefeet / 5280f;
            // now the 1 degree of lat or long from here are calculated using latitude angle entered converted to radians
            LengthDegLoSpherenm = (float)(60d * Math.Cos(LatInRad));
            LengthDegLoSpheremeters = LengthDegLoSpherenm * 1852f;
            LengthDegLoSpherefeet = (float)(LengthDegLoSpheremeters * 3.2808399d);
            LengthDegLoSpheresm = LengthDegLoSpherefeet / 5280f;
            LengthDegLWGS84meters = (float)(111132.92d - 559.82d * Math.Cos(2d * LatInRad) + 1.175d * Math.Cos(4d * LatInRad) - 0.0023d * Math.Cos(6d * LatInRad));
            LengthDegLWGS84feet = (float)(LengthDegLWGS84meters * 3.2808399d);
            LengthDegLWGS84sm = LengthDegLWGS84feet / 5280f;
            LengthDegLWGS84nm = LengthDegLWGS84meters / 1852f;
            LengthDegLoWGS84meters = (float)(111412.84d * Math.Cos(LatInRad) - 93.5d * Math.Cos(3d * LatInRad) + 0.118d * Math.Cos(5d * LatInRad));
            LengthDegLoWGS84feet = (float)(LengthDegLoWGS84meters * 3.2808399d);
            LengthDegLoWGS84sm = LengthDegLoWGS84feet / 5280f;
            LengthDegLoWGS84nm = LengthDegLoWGS84meters / 1852f;
            FileTextLine = LatParmIn.ToString("#0") + "," + LengthDegLSpherefeet.ToString("#0") + "," + LengthDegLSpheremeters.ToString("#0") + "," + LengthDegLSpheresm.ToString("#0.000") + "," + LengthDegLSpherenm.ToString("#0.000") + "," + LengthDegLoSpherefeet.ToString("#0") + "," + LengthDegLoSpheremeters.ToString("#0") + "," + LengthDegLoSpheresm.ToString("#0.000") + "," + LengthDegLoSpherenm.ToString("#0.000");
            // LengthDegLWGS84feet.ToString("#.0") & "," &
            // LengthDegLWGS84meters.ToString("#.0") & "," &
            // LengthDegLWGS84sm.ToString("#0.000") & "," &
            // LengthDegLWGS84nm.ToString("#0.000") & "," &
            // LengthDegLoWGS84feet.ToString("#0") & "," &
            // LengthDegLoWGS84meters.ToString("#0") & "," &
            // LengthDegLoWGS84sm.ToString("#0.000") & "," &
            // LengthDegLoWGS84nm.ToString("#0.000")
            return FileTextLine;
            return default;
        }

        private void WriteLengthCSV()
        {
            int limit = 0;
            string FName = "./Graphics/Length1Degree" + ".csv";
            var objWriter = new System.IO.StreamWriter(FName, false);
            // objWriter.WriteLine("Latitude, LatDegSphFeet, LatDegSphMeter, LatDegSphSM, LatDegSphNM, LongDegSphFeet, LongDegSphMeter, LongDegSphSM, LongDegSphNM") ' LatDegWGS84Feet, LatDegWGS84Meter, LatDegWGS84SM, LatDegWGS84NM, LongDegWGS84Feet, LongDegWGS84Meter, LongDegWGS84SM, LongDegWGS84NM") ' write header line with column names in it
            while (limit <= 89)
            {
                objWriter.WriteLine(CalculateForFile(Convert.ToDouble(limit)));
                limit += 5;
            }

            limit = 89;
            objWriter.WriteLine(CalculateForFile(Convert.ToDouble(limit)));
            objWriter.Close();
            objWriter.Dispose();
            return;
        }
    }
}