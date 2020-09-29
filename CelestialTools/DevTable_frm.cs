using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    internal partial class FormDevTable_frm : Form
    {
        public string fnumeral;
        public short i;
        public string[] DevValue = new string[9]; // , D(8) As Variant
        public int[] Dev = new int[9];
        public TextBox[] D1 = new TextBox[9]; // = {_D_0, _D_1, _D_2, _D_3, _D_4, _D_5, _D_6, _D_7}
        public TextBox[] txtM1 = new TextBox[9]; // = {_txtM_0, _txtM_1, _txtM_2, _txtM_3, _txtM_4, _txtM_5, _txtM_6, _txtM_7}
        public TextBox[] txtEW1 = new TextBox[9]; // = {_txtEW_0, _txtEW_1, _txtEW_2, _txtEW_3, _txtEW_4, _txtEW_5, _txtEW_6, _txtEW_7}
        public TextBox[] txtC1 = new TextBox[9]; // = {_txtC_0, _txtC_1, _txtC_2, _txtC_3, _txtC_4, _txtC_5, _txtC_6, _txtC_7}
        public bool FileOpenChk = false;
        public bool FormDevTable_frmOpen = false;
        public string SLDir = "./DeviationTbl/";
        public string SLDefName = "Deviation_Table.txt"; // & Now.ToShortDateString.Replace("/", "").Replace("-", "") & Now.ToLongTimeString.Replace(":", "").Replace(" ", "") & ".txt"
        public string SLOpenFName;
        // Public SLDefNameDG As String = "DeviationDG_Table.txt" '& Now.ToShortDateString.Replace("/", "").Replace("-", "") & Now.ToLongTimeString.Replace(":", "").Replace(" ", "") & ".txt"
        // Public SLOpenFNameDG As String = SLDir & SLDefNameDG
        public int Index = 0;
        public bool ClearingFields = false;
        // Public DataSet2 As DataSet = New DataSet
        public bool CellHasChg = false;
        public int CellRowIdxChg = 0;
        // Public FlagMChange As Boolean

        private void cmdPrint_Click(object eventSender, EventArgs eventArgs)
        {
            Print_Renamed.PrintScreen(Bounds);
        }

        private void FormDevTable_frm_Load(object eventSender, EventArgs eventArgs)
        {
            FileOpenChk = false;
            int InitMag = 0;
            D1 = new[] { _D_0, _D_1, _D_2, _D_3, _D_4, _D_5, _D_6, _D_7 };
            txtM1 = new[] { _txtM_0, _txtM_1, _txtM_2, _txtM_3, _txtM_4, _txtM_5, _txtM_6, _txtM_7 };
            txtEW1 = new[] { _txtEW_0, _txtEW_1, _txtEW_2, _txtEW_3, _txtEW_4, _txtEW_5, _txtEW_6, _txtEW_7 };
            txtC1 = new[] { _txtC_0, _txtC_1, _txtC_2, _txtC_3, _txtC_4, _txtC_5, _txtC_6, _txtC_7 };
            ClearingFields = true;
            for (i = 0; i <= 7; i++)
            {
                DevValue[i] = Constants.vbNullString;
                txtM1[i].Clear();
                D1[i].Clear();
                txtEW1[i].Clear();
                txtM1[i].Text = Strings.Format("##0", InitMag.ToString());
                InitMag += 45;
            }

            // Dim DevHdr As String() = {"Compass", "Magnetic", "Deviation"}
            // Dim DataSet1 As DataSet = New DataSet()
            // DataSet2.Tables.Add("Table1")
            // DataSet2.DataSetName = "Table1"
            // DGDev.DataSource = DataSet1
            // For i As Integer = 0 To UBound(DevHdr)
            // DataSet2.Tables("Table1").Columns.Add(DevHdr(i))
            // DataSet2.Tables("Table1").Columns(i).AllowDBNull = False
            // DataSet2.Tables("Table1").Columns(i).DefaultValue = ""
            // Next
            // DGDev.DataSource = DataSet2.Tables(0).DefaultView
            // For i As Integer = 0 To DGDev.Columns.Count - 1
            // DGDev.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            // DGDev.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            // DGDev.Columns(i).DefaultCellStyle.WrapMode = DataGridViewTriState.True
            // Next
            // DGDev.Columns(0).ReadOnly = True
            // DGDev.Columns(2).ReadOnly = True
            // DGDev.DefaultCellStyle.WrapMode = DataGridViewTriState.True
            // 'DGDev.DefaultCellStyle.SelectionBackColor = DGDev.DefaultCellStyle.BackColor
            // 'DGDev.DefaultCellStyle.SelectionForeColor = DGDev.DefaultCellStyle.ForeColor
            // DGDev.Columns(0).MinimumWidth = 15
            // DGDev.Columns(1).MinimumWidth = 15
            // DGDev.Columns(2).MinimumWidth = 15
            // Dim Compass As Integer = 0
            // For i As Integer = 0 To 8
            // DataSet2.Tables("Table1").Rows.Add(Compass, Compass, "0 W")
            // Compass += 45
            // Next
            // DGDev.Rows(8).Cells(1).ReadOnly = True

            ClearingFields = false;
            ReadDevTblFile();
            FileOpenChk = true;
            FormDevTable_frmOpen = true;
            My.MyProject.Forms.FormTVMDC.FormDevTable_frmHasOpenedForBusiness = true;
            return;
        }

        private void cmdClear_Click(object eventSender, EventArgs eventArgs)
        {
            // Confirm is Clear is really requested
            if (MessageBox.Show("Clear All Deviation Entries - Are you sure? Yes / No ?", "Clear Entries?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly) == DialogResult.No)
            {
                return;
            }
            // Clear all entries in Dev Table
            int InitMag = 0;
            ClearingFields = true;
            for (i = 0; i <= 7; i++)
            {
                txtM1[i].Clear();
                D1[i].Clear();
                txtEW1[i].Clear();
                txtM1[i].Text = Strings.Format("##0", InitMag.ToString());
                InitMag += 45;
            }

            ClearingFields = false;
        }

        private void Save()
        {
            if (FileOpenChk == false)
            {
                return;
            }

            var objWriter = new System.IO.StreamWriter(SLOpenFName, false);
            i = 0;
            for (i = 0; i <= 7; i++)
                objWriter.WriteLine(txtM1[i].Text);
            objWriter.Close();
            // objWriter.Dispose()
            FileOpenChk = false;
            return;
        }

        private void txtM_TextChanged()
        {
            // Dim Index As Integer = txtM1.GetIndex(eventSender)
            int TryInt = 0;
            txtM1[Index].BackColor = Control.DefaultBackColor; 
            if (int.TryParse(txtM1[Index].Text, out TryInt))
            {
                if (TryInt > 359)
                {
                    txtM1[Index].BackColor = ColorTranslator.FromOle(0xFF);
                    ErrorMsgBox("Dev Mag Value too large - must be 0 to 359");
                    Interaction.Beep();
                }
            }
            else
            {
                txtM1[Index].BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Dev Mag Value Must an Integer between 0 to 359");
                Interaction.Beep();
            }

            Deviation(ref Index);
            D1[Index].Text = Math.Abs(Dev[Index]).ToString();
            if (Conversions.ToDouble(D1[Index].Text) > 7d)
            {
                txtM1[Index].BackColor = Color.Yellow;
            }
            else
            {
                txtM1[Index].BackColor = Control.DefaultBackColor; 
            }

            if (Dev[Index] < 0)
                txtEW1[Index].Text = CommonGlobals.g_LongE;
            else
                txtEW1[Index].Text = CommonGlobals.g_LongW;
            return;
        }

        private void SelectAllText(ref TextBox TB)
        {
            TB.SelectionStart = 0;
            TB.SelectionLength = Strings.Len(TB.Text);
        }

        private void FormDevTable_frm_FormClosed(object eventSender, FormClosedEventArgs eventArgs)
        {
            CloseFormDevTable_frm();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            CloseFormDevTable_frm();
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            Save();
            MessageBox.Show("Data saved to " + SLOpenFName.ToString() + " file");
            return;
        }

        public void CloseFormDevTable_frm()
        {
            if (FormDevTable_frmOpen == true)
            {
                Save();
                FormDevTable_frmOpen = false;
                My.MyProject.Forms.FormTVMDC.FormDevTable_frmHasOpenedForBusiness = false;
                My.MyProject.Forms.FormTVMDC.chkDev.CheckState = CheckState.Unchecked;
                Close();
            }

            return;
        }

        private void ErrorMsgBox(string ErrMsg)
        {
            MessageBox.Show(ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            return;
        }

        private void ReadDevTblFile()
        {
            string SLFName = Constants.vbNullString;
            bool ReadError = false;
            bool FileLoading = false;
            System.IO.StreamReader myStream = null;
            string rdline = Constants.vbNullString;
            ReadError = false;
            FileLoading = true;
            try
            {
                myStream = new System.IO.StreamReader(SLOpenFName);
                if (myStream is object)
                {
                    i = 0;
                    while (myStream.Peek() != -1)
                    {
                        rdline = myStream.ReadLine();
                        if (!string.IsNullOrEmpty(rdline))
                        {
                            DevValue[i] = rdline;
                            txtM1[i].Text = DevValue[i];
                            i = (short)(i + 1);
                            rdline = Constants.vbNullString;
                        }
                    }

                    myStream.Close();
                }

                myStream.Dispose();
                FileLoading = false;
                return;
            }
            catch (Exception Ex)
            {
                ErrorMsgBox("Dev Table Form will be closed - Cannot read Dev Table file from disk. Original error: " + Ex.Message);
            }
            finally
            {
                // Check this again, since we need to make sure we didn't throw an exception on open.
                if (myStream is object)
                {
                    myStream.Close();
                }

                CloseFormDevTable_frm();
            }
            // End If
            return;
        }

        private void _txtM_0_TextChanged(object sender, EventArgs e)
        {
            if (ClearingFields == true)
                return;
            Index = 0;
            txtM_TextChanged();
        }

        private void _txtM_1_TextChanged(object sender, EventArgs e)
        {
            if (ClearingFields == true)
                return;
            Index = 1;
            txtM_TextChanged();
        }

        private void _txtM_2_TextChanged(object sender, EventArgs e)
        {
            if (ClearingFields == true)
                return;
            Index = 2;
            txtM_TextChanged();
        }

        private void _txtM_3_TextChanged(object sender, EventArgs e)
        {
            Index = 3;
            txtM_TextChanged();
        }

        private void _txtM_4_TextChanged(object sender, EventArgs e)
        {
            Index = 4;
            txtM_TextChanged();
        }

        private void _txtM_5_TextChanged(object sender, EventArgs e)
        {
            if (ClearingFields == true)
                return;
            Index = 5;
            txtM_TextChanged();
        }

        private void _txtM_6_TextChanged(object sender, EventArgs e)
        {
            if (ClearingFields == true)
                return;
            Index = 6;
            txtM_TextChanged();
        }

        private void _txtM_7_TextChanged(object sender, EventArgs e)
        {
            if (ClearingFields == true)
                return;
            Index = 7;
            txtM_TextChanged();
        }

        public void Deviation(ref int Index)
        {
            Dev[Index] = (int)(Conversion.Val(txtC1[Index].Text) - Conversion.Val(txtM1[Index].Text));
            if (Index == 0 & Conversion.Val(txtM1[Index].Text) > 180d)
            {
                Dev[Index] = 360 - Math.Abs(Dev[Index]);      // added in V5.6.1
            }

            Dev[8] = Dev[0];
        }

        // Private Sub DGDev_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs)

        // If EditDGCellChg(e.RowIndex) = True Then
        // Exit Sub
        // End If
        // Exit Sub
        // End Sub

        // Private Sub DGDev_CellLeave(sender As Object, e As DataGridViewCellEventArgs)

        // End Sub
        // Private Function EditDGCellChg(ByVal Idx As Integer) As Boolean
        // Dim TryInt As Integer = 0
        // If Integer.TryParse(DGDev.Rows(Idx).Cells(1).Value, TryInt) Then
        // If TryInt > 359 Then
        // DGDev.Rows(Idx).Cells(1).Selected = True
        // ErrorMsgBox("Magnetic Heading Value too large - must be 0 to 359")
        // Beep()
        // Return False
        // End If
        // Else
        // DGDev.Rows(Idx).Cells(1).Selected = True
        // ErrorMsgBox("Magnetic Heading Value Must an Integer between 0 to 359")
        // Beep()
        // Return False
        // End If
        // If Idx = 0 And TryInt > 180 Then
        // TryInt = 360 - TryInt
        // End If
        // Dim tempdev As Integer = Convert.ToInt32(DGDev.Rows(Idx).Cells(0).Value) - TryInt
        // If Index = 0 And tempdev > 180 Then
        // tempdev = (360 - Math.Abs(tempdev))     'added in V5.6.1
        // End If
        // Dim tempdevew As String
        // If tempdev < 0 Then
        // tempdevew = g_LongE
        // Else
        // tempdevew = g_LongW
        // End If
        // DGDev.Rows(Idx).Cells(2).Value = System.Math.Abs(tempdev).ToString("#0") & tempdevew

        // If Idx = 0 Then
        // DGDev.Rows(8).Cells(2).Value = DGDev.Rows(Idx).Cells(2).Value
        // DGDev.Rows(8).Cells(1).Value = DGDev.Rows(Idx).Cells(1).Value
        // DGDev.Rows(8).Cells(1).ReadOnly = True
        // End If
        // Return True
        // End Function
    }
}