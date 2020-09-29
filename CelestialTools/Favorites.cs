using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    internal partial class Form7 : Form
    {
        private string fnumeral, Location_Renamed;
        private short ChangeCount, i, VisibleFormCount;
        private string TypeHorizon = "NH";
        private string FavDir = "./Favorites/";
        private string[] Favorites;
        private string SLOpenFname = "";

        private void cmdAddLocation_Click(object eventSender, EventArgs eventArgs)
        {
            if (optHorizonNatural.Checked == true)
            {
                TypeHorizon = "NH";
                txtDsDist.Text = "";
            }

            if (optHorizonArtificial.Checked == true)
            {
                TypeHorizon = "AH";
                txtDsDist.Text = "";
            }

            if (optHorizonDipShort.Checked == true)
            {
                TypeHorizon = "DS";
            }

            Location_Renamed = txtNewName.Text + Strings.Space(37 - Strings.Len(txtNewName.Text));
            Location_Renamed = Location_Renamed + Strings.Space(3 - Strings.Len(Conversion.Str(Conversion.Val(txtLDeg.Text)))) + Strings.Format(Conversion.Val(txtLDeg.Text), "0") + '°';
            Location_Renamed = Location_Renamed + Strings.Format(Conversion.Val(txtLMin.Text), "00.0") + "'" + cboL.Text + Strings.Space(2);
            Location_Renamed = Location_Renamed + Strings.Space(4 - Strings.Len(Conversion.Str(Conversion.Val(txtLoDeg.Text)))) + Strings.Format(Conversion.Val(txtLoDeg.Text), "0") + '°';
            Location_Renamed = Location_Renamed + Strings.Format(Conversion.Val(txtLoMin.Text), "00.0") + "'" + cboLo.Text + Strings.Space(4);
            Location_Renamed = Location_Renamed + Strings.Space(4 - Strings.Len(Conversion.Str(Conversion.Val(txtMinAz.Text)))) + Strings.Format(Conversion.Val(txtMinAz.Text), "0") + '°' + Strings.Space(5);
            Location_Renamed = Location_Renamed + Strings.Space(4 - Strings.Len(Conversion.Str(Conversion.Val(txtMaxAz.Text)))) + Strings.Format(Conversion.Val(txtMaxAz.Text), "0") + '°';
            Location_Renamed = Location_Renamed + Strings.Space(4) + TypeHorizon + Strings.Space(3);
            Location_Renamed = Location_Renamed + Strings.Space(6 - Strings.Len(Conversion.Str(Conversion.Val(txtDsDist.Text)))) + txtDsDist.Text + Strings.Space(1);
            if (optHorizonDipShort.Checked == true)
            {
                Location_Renamed = Location_Renamed + cboDsUnit.Text;
            }

            if (optHorizonDipShort.Checked == true & Conversion.Val(txtDsDist.Text) == 0d)
            {
                {
                    var withBlock = txtDsDist;
                    withBlock.Focus();
                }

                ErrorMsgBox("You must enter a non-zero value for Ds distance");
                return;
            }

            lstFavorites.Items.Add(Location_Renamed);
            ChangeCount = (short)(ChangeCount + 1);
        }

        private void cmdRemoveLocation_Click(object eventSender, EventArgs eventArgs)
        {
            if (lstFavorites.SelectedIndex == -1)
            {
                ErrorMsgBox("No location selected");
                return;
            }

            if (MessageBox.Show("Are you sure? Delete No / Yes?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly) == DialogResult.No)
            {
                return;
            }

            lstFavorites.Items.RemoveAt(lstFavorites.SelectedIndex);
            ChangeCount = (short)(ChangeCount + 1);
            return;
        }

        private void cmdSave_Click(object eventSender, EventArgs eventArgs)
        {
            ExecFileSave();
            return;
        }

        private void ExecFileSave()
        {
            int i = 0;
            int iCnt = 0;
            var saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Title = "Save an Favorites List Text File";
            saveFileDialog1.InitialDirectory = FavDir;
            saveFileDialog1.FileName = SLOpenFname;
            saveFileDialog1.ShowDialog();
            if (!string.IsNullOrEmpty(saveFileDialog1.FileName))
            {
                SLOpenFname = saveFileDialog1.FileName;
                var objWriter = new System.IO.StreamWriter(saveFileDialog1.FileName, false);
                i = 0;
                var loopTo = lstFavorites.Items.Count - 1;
                for (i = 0; i <= loopTo; i++)
                    objWriter.WriteLine(lstFavorites.Items[i]);
                objWriter.Close();
                // objWriter.Dispose()
                ChangeCount = 0;
            }

            return;
        }

        private void ClearFavInfo()
        {
            // With MainMenu.UseFav
            // .UseThisFav = False
            // .txtLDeg = vbNullString
            // .txtLMin = vbNullString
            // .txtLNS = vbNullString
            // .txtLoDeg = vbNullString
            // .txtLoMin = vbNullString
            // .txtLoEW = vbNullString
            // .txtLowAz = vbNullString
            // .txtHighAz = vbNullString
            // .txtHorizon = vbNullString
            // .txtHorDist = vbNullString
            // .txtHorUnit = vbNullString
            // .HorUnitIdx = 0
            // End With
            return;
        }

        private void cmdUse_Click(object eventSender, EventArgs eventArgs)
        {
            if (lstFavorites.SelectedIndex == -1)
            {
                ErrorMsgBox("No location selected");
                return;
            }
            // With MainMenu.UseFav
            // .txtLDeg = Mid(lstFavorites.Text, 38, 2)
            // .txtLMin = Mid(lstFavorites.Text, 41, 4)
            // .txtLNS = Mid(lstFavorites.Text, 46, 1)
            // .txtLoDeg = Mid(lstFavorites.Text, 50, 3)
            // .txtLoMin = Mid(lstFavorites.Text, 54, 4)
            // .txtLoEW = Mid(lstFavorites.Text, 59, 1)
            // .txtLowAz = Mid(lstFavorites.Text, 65, 3)
            // .txtHighAz = Mid(lstFavorites.Text, 74, 3)
            // .txtHorizon = Mid(lstFavorites.Text, 82, 2)
            // .txtHorDist = Mid(lstFavorites.Text, 87, 5)
            // .txtHorUnit = Mid(lstFavorites.Text, 92, 15)

            // Select Case Mid(lstFavorites.Text, 92, 15).Trim
            // Case "feet"
            // .HorUnitIdx = 0
            // Case "yards"
            // .HorUnitIdx = 1
            // Case "meters"
            // .HorUnitIdx = 2
            // Case "statute miles"
            // .HorUnitIdx = 3
            // Case "nautical miles"
            // .HorUnitIdx = 4
            // Case Else
            // .HorUnitIdx = 0
            // End Select

            // .UseThisFav = True

            // End With
            // Now check if SRF / FormSRF is already open and being used
            // If Application.OpenForms().OfType(Of FormSRF).Any Then

            // FormSRF.txtLDeg.Text = MainMenu.UseFav.txtLDeg
            // FormSRF.txtLMin.Text = MainMenu.UseFav.txtLMin
            // If MainMenu.UseFav.txtLNS = g_LatN Then
            // FormSRF.cboL.SelectedIndex = 0
            // Else
            // FormSRF.cboL.SelectedIndex = 1
            // End If
            // FormSRF.txtLoDeg.Text = MainMenu.UseFav.txtLoDeg
            // FormSRF.txtLoMin.Text = MainMenu.UseFav.txtLoMin
            // If MainMenu.UseFav.txtLoEW = g_LongW Then
            // FormSRF.cboLo.SelectedIndex = 0
            // Else
            // FormSRF.cboLo.SelectedIndex = 1
            // End If
            // Select Case MainMenu.UseFav.txtHorizon
            // Case "DS"
            // FormSRF.optHorizonDipShort.Checked = True
            // FormSRF.txtDsDist.Text = MainMenu.UseFav.txtHorDist
            // FormSRF.cboDsUnit.SelectedIndex = MainMenu.UseFav.HorUnitIdx
            // Case "AH"
            // FormSRF.optHorizonArtificial.Checked = True
            // Case "NH"
            // FormSRF.optHorizonNatural.Checked = True
            // Case Else
            // FormSRF.optHorizonNatural.Checked = True
            // End Select
            // End If
            // ' Now check if Plan1 / FormSightPlan is already open and in use
            // If Application.OpenForms().OfType(Of FormSightPlan).Any Then
            // FormSightPlan.txtLDeg.Text = MainMenu.UseFav.txtLDeg
            // FormSightPlan.txtLMin.Text = MainMenu.UseFav.txtLMin
            // If MainMenu.UseFav.txtLNS = g_LatN Then
            // FormSightPlan.cboL.SelectedIndex = 0
            // Else
            // FormSightPlan.cboL.SelectedIndex = 1
            // End If
            // FormSightPlan.txtLoDeg.Text = MainMenu.UseFav.txtLoDeg
            // FormSightPlan.txtLoMin.Text = MainMenu.UseFav.txtLoMin
            // If MainMenu.UseFav.txtLoEW = g_LongW Then
            // FormSightPlan.cboLo.SelectedIndex = 0
            // Else
            // FormSightPlan.cboLo.SelectedIndex = 1
            // End If
            // FormSightPlan.txtLowAz.Text = MainMenu.UseFav.txtLowAz
            // FormSightPlan.txtHighAz.Text = MainMenu.UseFav.txtHighAz
            // FormSightPlan.txtLowAz.Visible = True
            // FormSightPlan.txtHighAz.Visible = True
            // End If
            // ' Now check if NoonSight / FormNoonSight is already open and in use
            // If Application.OpenForms().OfType(Of FormNoonSight).Any Then
            // FormNoonSight.optDRL.Checked = True
            // FormNoonSight.txtDRLDeg.Text = MainMenu.UseFav.txtLDeg
            // FormNoonSight.txtDRLMin.Text = MainMenu.UseFav.txtLMin
            // If MainMenu.UseFav.txtLNS = g_LatN Then
            // FormNoonSight.cboDRL.SelectedIndex = 0
            // Else
            // FormNoonSight.cboDRL.SelectedIndex = 1
            // End If

            // FormNoonSight.txtLoDeg.Text = MainMenu.UseFav.txtLoDeg
            // FormNoonSight.txtLoMin.Text = MainMenu.UseFav.txtLoMin
            // If MainMenu.UseFav.txtLoEW = g_LongW Then
            // FormNoonSight.cboLo.SelectedIndex = 0
            // Else
            // FormNoonSight.cboLo.SelectedIndex = 1
            // End If

            // Select Case MainMenu.UseFav.txtHorizon
            // Case "DS"
            // FormNoonSight.optHorizonDipShort.Checked = True
            // FormNoonSight.txtDsDist.Text = MainMenu.UseFav.txtHorDist
            // FormNoonSight.cboDsUnit.SelectedIndex = MainMenu.UseFav.HorUnitIdx
            // Case "AH"
            // FormNoonSight.optHorizonArtificial.Checked = True
            // Case "NH"
            // FormNoonSight.optHorizonNatural.Checked = True
            // Case Else
            // FormNoonSight.optHorizonNatural.Checked = True
            // End Select
            // End If
            // ' Now check if SRMethods / FormAltSR is already open and in use
            // If Application.OpenForms().OfType(Of FormAltSR).Any Then
            // FormAltSR.txtLDeg.Text = MainMenu.UseFav.txtLDeg
            // FormAltSR.txtLMin.Text = MainMenu.UseFav.txtLMin
            // If MainMenu.UseFav.txtLNS = g_LatN Then
            // FormAltSR.cboL.SelectedIndex = 0
            // Else
            // FormAltSR.cboL.SelectedIndex = 1
            // End If
            // FormAltSR.txtLoDeg.Text = MainMenu.UseFav.txtLoDeg
            // FormAltSR.txtLoMin.Text = MainMenu.UseFav.txtLoMin
            // If MainMenu.UseFav.txtLoEW = g_LongW Then
            // FormAltSR.cboLo.SelectedIndex = 0
            // Else
            // FormAltSR.cboLo.SelectedIndex = 1
            // End If
            // End If
            return;
        }

        private void Form7_Load(object eventSender, EventArgs eventArgs)
        {
            ChangeCount = 0;
            // On Error GoTo DiskErrorHandler
            cboL.SelectedIndex = 0; // g_LatN    '0
            cboLo.SelectedIndex = 0; // g_LongW   '0
            cboDsUnit.SelectedIndex = 1; // "yards"   '1
            lstFavorites.Items.Clear();
            ClearFavInfo();

            // i = 0
            // Dim favorite(0) As Object 'Was (0 to 25) How to change this on the fly?????
            // FileOpen(1, "Favorite_Places.txt", OpenMode.Input)
            // Do Until EOF(1)
            // favorite(i) = LineInput(1)
            // lstFavorites.Items.Insert(i - 1, favorite(i))
            // Loop
            // FileClose(1)
            // Exit Sub
            // DiskErrorHandler:
            // Select Case Err.Number
            // Case 53
            // FileOpen(1, "Favorite_Places.txt", OpenMode.Output)
            // FileClose(1)
            // Case Else
            // End Select
            // Resume
            return;
        }

        private void Form7_FormClosing(object eventSender, FormClosingEventArgs eventArgs)
        {
            bool Cancel = eventArgs.Cancel;
            var UnloadMode = eventArgs.CloseReason;
            if (ChangeCount == 0)
            {
                // Cleanup()
                return;
            }

            Focus();
            if (MessageBox.Show("Save Location List?  No / Yes", "Save File?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) == DialogResult.Yes)
            {
                ExecFileSave();
                Cancel = false;
                return;
            }

            eventArgs.Cancel = Cancel;
            return;
        }

        private void Form7_FormClosed(object eventSender, FormClosedEventArgs eventArgs)
        {
            // Cleanup()
        }

        private void lstFavorites_DoubleClick(object eventSender, EventArgs eventArgs)
        {
            cmdUse_Click(cmdUse, new EventArgs());
        }

        private void optHorizonArtificial_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            {
                if (optHorizonArtificial.Checked == true)
                {
                    lblDsDist.Visible = false;
                    txtDsDist.Visible = false;
                    cboDsUnit.Visible = false;
                }
            }
        }

        private void optHorizonDipShort_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            {
                if (optHorizonDipShort.Checked == true)
                {
                    lblDsDist.Visible = true;
                    txtDsDist.Visible = true;
                    cboDsUnit.Visible = true;
                }
            }
        }

        private void optHorizonNatural_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            {
                if (optHorizonNatural.Checked == true)
                {
                    lblDsDist.Visible = false;
                    txtDsDist.Visible = false;
                    cboDsUnit.Visible = false;
                }
            }
        }

        private void txtDsDist_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        if (Conversions.ToBoolean(Strings.InStr(txtDsDist.Text, ".")))
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

        private void txtDsDist_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtDsDist;
            SelectAllText(ref argTB);
            txtDsDist = argTB;
        }

        private void txtLDeg_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtLDeg.Text) != 90d)
            {
                txtLMin.Enabled = true;
            }

            if (Conversion.Val(txtLDeg.Text) == 90d)
            {
                txtLMin.Text = "";
                txtLMin.Enabled = false;
                txtLMin.BackColor = Color.Gray;
            }

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
            txtLoDeg.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtLoDeg.Text) > 180d)
            {
                txtLoDeg.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtLoDeg.Text) == 180d)
            {
                txtLoMin.Text = "";
                txtLoMin.Enabled = false;
                txtLoMin.BackColor = Color.Gray;
            }
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

        private void txtMinAz_TextChanged(object eventSender, EventArgs eventArgs)
        {
            txtMinAz.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtMinAz.Text) > 360d)
            {
                txtMinAz.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }
        }

        private void txtMinAz_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        private void txtMinAz_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtMinAz.Text) > 360d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtMinAz_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtMinAz;
            SelectAllText(ref argTB);
            txtMinAz = argTB;
        }

        private void txtMaxAz_TextChanged(object eventSender, EventArgs eventArgs)
        {
            txtMaxAz.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtMaxAz.Text) > 360d)
            {
                txtMaxAz.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            return;
        }

        private void txtMaxAz_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        private void txtMaxAz_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtMaxAz.Text) > 360d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOpenLocList_Click(object sender, EventArgs e)
        {
            System.IO.StreamReader myStream = null;
            var openFileDialog1 = new OpenFileDialog();
            string rdline = Constants.vbNullString;
            int Ictr = 0;
            lstFavorites.Items.Clear();
            openFileDialog1.InitialDirectory = FavDir;
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.Title = "Open Favorites List File";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(openFileDialog1.FileName))
                {
                    return;
                }

                try
                {
                    myStream = new System.IO.StreamReader(openFileDialog1.FileName);
                    if (myStream is object)
                    {
                        SLOpenFname = openFileDialog1.FileName;
                        while (myStream.Peek() >= 0)
                        {
                            rdline = myStream.ReadLine();
                            if (!string.IsNullOrEmpty(rdline))
                            {
                                lstFavorites.Items.Insert(Ictr, rdline);
                            }
                        }

                        myStream.Close();
                    }

                    myStream.Dispose();
                    ClearFavInfo();
                }
                catch (Exception Ex)
                {
                    ErrorMsgBox("Cannot read file from disk. Original error: " + Ex.Message);
                }
                finally
                {
                    // Check this again, since we need to make sure we didn't throw an exception on open.
                    if (myStream is object)
                    {
                        myStream.Close();
                    }
                }
            }

            return;
        }

        private void txtMaxAz_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtMaxAz;
            SelectAllText(ref argTB);
            txtMaxAz = argTB;
        }

        private void txtNewName_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtNewName;
            SelectAllText(ref argTB);
            txtNewName = argTB;
        }

        private void SelectAllText(ref TextBox TB)
        {
            TB.SelectionStart = 0;
            TB.SelectionLength = Strings.Len(TB.Text);
            return;
        }

        private void ErrorMsgBox(string ErrMsg)
        {
            MessageBox.Show(ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            return;
        }
    }
}