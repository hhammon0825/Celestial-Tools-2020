using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Windows.Media;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CelestialTools
{
    internal partial class FormAltSR : Form
    {
        public bool InvokedbySightLog = false;
        // Private ReadOnly DecLOC As Double
        private double Ho;
        private double GHA;
        private double DE;
        private double Hc;
        private double A;
        private short i;
        private double APEstLMin, APEstL, APEstLo, APEstLoMin;
        private double APEstLDeg, APEstLoDeg;
        private double LHAMin, EstLMin, EstL, EstLo, EstLoMin, Pi;
        private double L8, L6, L4, L2, L1, L3, L5, L7, Z;
        private short LHADeg;
        private short EstLDeg;
        // Private ReadOnly GHADeg As Short
        private short EstLoDeg;
        private short HcDeg;
        private double HcMin;
        private string fnumeral;
        private short HoDeg, DecDegrees, AsmLoDeg;
        private double DecMinutes, HoMin;
        private double AsmLHA, GHAAsm, BMin;
        private float AsmLoMin, Z1display;
        private short BDeg; // BMin As Integer
        private double B1, Z3, A1, Aval, Z1, B;
        private short AvalDeg, AvalMin;
        private double P1, Z4, F, H, H1, Z2, P;
        private short DecMinDisplay;
        private short HDeg, PDeg, FMin, FDeg, AWhole, FWhole, HMin;
        private float Z2Display1, Z2Display2;
        private short GHAAsmDeg, GHAAsmMin;
        private string SignCorr1, SignF, SignZ1, SignB, SignDE, SignZ2, SignCorr2; // LoDiff As Single
        private double Ztot, Corr1, Corr2, HoinMinutes;
        private float ZtotDisplay;
        private short HtotDeg, HtotMin; // ,Htot As Single
        private short LengthZ2Display, LengthZ1Display, LengthZtotDisplay;
        // ReadOnly Z2Deg As Short
        private short IU;
        private short II;
        // Private ReadOnly IJ As Short
        // ReadOnly ZTTemp As Integer
        // some below not necessary
        private readonly double[] FZH = new double[51];
        private readonly double[] FZM = new double[51];
        private readonly double[] FZS = new double[51];
        private readonly double[] FMI = new double[51];
        private readonly double[] FZN = new double[51];
        private readonly string[] FLD = new string[51];
        private readonly string[] FLM = new string[51];
        private readonly double[] FL = new double[51];
        private readonly double[] FMD = new double[51];
        private readonly double[] FMM = new double[51];
        private readonly string[] FM = new string[51];
        private readonly double[] FZT = new double[51];
        private readonly double[] FUT = new double[51];
        private readonly string[] FD = new string[51];
        private readonly double[] FGHA = new double[51];      // added in V5.6.1
        private readonly double[] FDec = new double[51];      // added in V5.6.1
        private readonly double[] FHo = new double[51];    // added in V5.6.1
        private readonly string[] FLA = new string[51];
        private readonly string[] FLo = new string[51];
        private readonly DateTime[] FDTSight = new DateTime[51];
        private readonly string[] FEP = new string[51];
        private readonly string[] FBody = new string[51];
        // Public FixData4(), FixData2(), FixData1(), FixData3(), FixData5() As SFixData
        // Public FixData9(), FixData7(), FixData6(), FixData8(), FixData10() As SFixData
        // Public FixData11(), FixData12() As SFixData

        public SFixData FixData1, FixData2, FixData3, FixData4, FixData5;
        public SFixData FixData6, FixData7, FixData8, FixData9, FixData10;
        public SFixData FixData11, FixData12;

        public struct SFixData
        {
            public double SFZH;
            public double SFZM;
            public double SFZS;
            public double SFMI;
            public double SFZN;
            public string SFLD;
            public string SFLM;
            public double SFL;
            public double SFMD;
            public double SFMM;
            public string SFM;
            public double SFZT;
            public double SFUT;
            public string sFD;
            public string SBF;
            public string sFLA;
            public double SFLo;
            public double SFGHA;
            public double SFDec;
            public double SFHo;
            public string SEP;
        }

        private double AsmL, AsmLo; // AsmL was integer
        private double Lo;
        private double KPLOPDist;
        private float Hk, VL, DL, DLo, VLo;
        private double Dec, ZN, L, LHA, Htot;
        private bool FlagMD, FlagSRFLoCNASR; // ,HoinMinutes As Double
        private float D, DecIncr, AsmDec;
        private short TabHcDeg, NextHcDeg;
        private double NextHc, TabHcMin, NextHcMin;
        private string SignD;
        private float dcorr;
        private string Signdcorr;
        private double TotHc, TotHcMin;
        private short sgnHc, TotHcDeg, sgnTotHc;
        private double Zdiff, Zcorr1;
        private string SignZdiff, SignTotcorr;
        private float d1corr, TabZ, Zcorr;
        private float Totcorr;
        private double DSDcorr, d2corr;
        private short SgnD;
        private double NextHcDSD1, NextHcDSD1Min;
        private short NextHcDSD1Deg;
        private double NextHcDSD2, NextHcDSD2Min;
        private short NextHcDSD2Deg;
        private double NextHctP;
        private double NextHcdP;
        private double NextHcdM;
        // Private ReadOnly NextHctM As Double
        private float DSD3, DSD1, DSD;
        private double DSD2;
        private short SgnDSD;
        private bool DSDcorrFlag;
        private double ZL8, ZL6, ZL4, ZL5, ZL7, ZC;
        private double T, tMin;
        private short tDeg;
        private float A6, A4, A2, A3, A5, A7;
        private float B4, B2, B3, B5;
        private double k, KMin;
        private short KDeg;
        private double tDecimal, KL, KLMin, DecDecimal;
        private short KLDeg;
        private double A3AngleMin, A3Angle, A3AngleDecimal;
        private short A3AngleDeg;
        private double HcDecimal, HcAngle, ZMin;
        private short ZDeg;
        private bool Flag, Flag0;
        private short AsmDecDeg;
        private float LHAdiff, AsmDecMin, Ldiff;
        private string SignL, Signd2corr, SignA3;
        private short B1Deg, A3Deg;
        private double A3Min;
        private double B1Min;
        // Private ReadOnly DB As Double
        private short L2Deg, h1Deg, h2Deg, L3Deg;
        private double L2Min, h1Min, h2Min, L3Min;
        // Private ReadOnly NextDec As Double
        private double LHADecimal;
        // Private ReadOnly r As Double
        // Private ReadOnly NextDecMin As Double
        private bool FlagFarley, FlagWeems;
        // ReadOnly NextDecDeg As Short
        private double Btot, KdMin, N, Kd, AB, B22;

        private void btnNASRFix_Click(object sender, EventArgs e)
        {
            // saved NASR AP/EP data to fix interface
            II = (short)(II + 1);
            IU = (short)(IU + 1);
            if (IU > 12)
            {
                ErrorMsgBox("Too many sights saved - the limit is 12 saved sights");
                return;
            }

            if (IU > 1)
            {
                cmdFix.Visible = true;
                cmdFix.Enabled = true;
                cmdFix.Text = "Establish Fix for " + IU.ToString("#0") + " sights";
            }

            if (InvokedbySightLog == true)
            {
                FBody[II] = cboBody.Text.ToString().Trim();
                if (cboBody.Text.ToString().Trim() == "Sun" | cboBody.Text.ToString().Trim() == "Moon")
                {
                    FBody[II] += " " + cbLimb.Text.ToString().Trim();
                }
            }
            else
            {
                FBody[II] = " AltSRBody" + txtSightNum.ToString("##0");
            }

            FZH[II] = DTSight.Value.Hour;    // VB.Left(txtTime.Text, 2)
            FZM[II] = DTSight.Value.Minute;      // Mid(txtTime.Text, 3, 2) ': FZS(II) = Right(txtTime.Text, 2)
            FZS[II] = DTSight.Value.Second;
            FDTSight[II] = DTSight.Value;
            // FZU(II) = DTSight.Value.ToUniversalTime.Subtract(New DateTime(1970, 1, 1, 0, 0, 0))
            // FMI(II) = System.Math.Sign(KPLOPDist) * Int((System.Math.Abs(KPLOPDist) * 10 + 0.5) / 10) 'changed in V4.0.0
            FMI[II] = Math.Sign(A) * Conversion.Int((Math.Abs(A) * 10d + 0.5d) / 10d); // changed in V4.0.0
            if (A > 0d)
            {
                FD[II] = "A"; // PlotOut.PlotIntercept &= " Away"
            }
            else
            {
                FD[II] = "T";
            } // PlotOut.PlotIntercept &= " Toward"

            FZN[II] = Conversion.Int(Math.Round(ZN, 0)); // changed in V4.0.0
            FL[II] = AsmL;
            // FLD(II) = Int(L).ToString("00")
            FLD[II] = Conversion.Int(AsmL).ToString("00");
            FLM[II] = "00.0";
            FLA[II] = cboL.Items[cboL.SelectedIndex].ToString();
            FLo[II] = AsmLo.ToString();
            FMD[II] = Convert.ToDouble(AsmLoDeg); // Int(Lo)
            FMM[II] = Convert.ToDouble(AsmLoMin); // Lo - Int(Lo)
            FM[II] = cboLo.Items[cboLo.SelectedIndex].ToString();
            FGHA[II] = GHA;      // added in V5.6.1
            FDec[II] = Dec;      // added in V5.6.1
            FHo[II] = Ho;        // added in V5.6.1
                                 // FEP(II) = PlotOut.PlotSLEP
            FEP[II] = "AP/EP L " + APEstLDeg.ToString("#0") + '°' + APEstLMin.ToString("00.0") + "' " + cboL.Items[cboL.SelectedIndex].ToString() + "AP/EP Lo " + APEstLoDeg.ToString("##0") + '°' + APEstLoMin.ToString("00.0") + "' " + cboLo.Items[cboLo.SelectedIndex].ToString();

            //'now add DR position to fix data
            II = (short)(II + 1);
            IU = (short)(IU + 1);
            if (IU > 12)
            {
                ErrorMsgBox("Too many sights saved - the limit is 12 saved sights");
                return;
            }

            if (IU > 1)
            {
                cmdFix.Visible = true;
                cmdFix.Enabled = true;
                cmdFix.Text = "Establish Fix for " + IU.ToString("#0") + " sights";
            }

            if (InvokedbySightLog == true)
            {
                FBody[II] = cboBody.Text.ToString().Trim();
                if (cboBody.Text.ToString().Trim() == "Sun" | cboBody.Text.ToString().Trim() == "Moon")
                {
                    FBody[II] += " " + cbLimb.Text.ToString().Trim();
                }
            }
            else
            {
                FBody[II] = " AltSRBody" + txtSightNum.ToString("##0");
            }

            FZH[II] = DTSight.Value.Hour;    // VB.Left(txtTime.Text, 2)
            FZM[II] = DTSight.Value.Minute;      // Mid(txtTime.Text, 3, 2) ': FZS(II) = Right(txtTime.Text, 2)
            FZS[II] = DTSight.Value.Second;
            FDTSight[II] = DTSight.Value;
            // FZU(II) = DTSight.Value.ToUniversalTime.Subtract(New DateTime(1970, 1, 1, 0, 0, 0))
            FMI[II] = System.Math.Sign(KPLOPDist) * Conversion.Int((System.Math.Abs(KPLOPDist) * 10 + 0.5) / 10); // 'changed in V4.0.0
            //FMI[II] = Math.Sign(A) * Conversion.Int((Math.Abs(A) * 10d + 0.5d) / 10d); // changed in V4.0.0
            if (KPLOPDist > 0d)
            {
                FD[II] = "A"; // PlotOut.PlotIntercept &= " Away"
            }
            else
            {
                FD[II] = "T";
            } // PlotOut.PlotIntercept &= " Toward"

            FZN[II] = Conversion.Int(Math.Round(ZN, 0)); // changed in V4.0.0
            FL[II] = L;
            // FLD(II) = Int(L).ToString("00")
            FLD[II] = txtLDeg.Text.ToString();
            FLM[II] = txtLMin.Text.ToString();
            FLA[II] = cboL.Items[cboL.SelectedIndex].ToString();
            FLo[II] = Lo.ToString();
            FMD[II] = Convert.ToDouble(txtLoDeg.Text.ToString()); // Int(Lo)
            FMM[II] = Convert.ToDouble(txtLoMin.Text.ToString()); // Lo - Int(Lo)
            FM[II] = cboLo.Items[cboLo.SelectedIndex].ToString();
            FGHA[II] = GHA;      // added in V5.6.1
            FDec[II] = Dec;      // added in V5.6.1
            FHo[II] = Ho;        // added in V5.6.1
                                 // FEP(II) = PlotOut.PlotSLEP
            FEP[II] = "AP/EP L " + EstLDeg.ToString("#0") + '°' + EstLMin.ToString("00.0") + "' " +
                cboL.Items[cboL.SelectedIndex].ToString() + "AP/EP Lo " + EstLoDeg.ToString("##0") +
                '°' + EstLoMin.ToString("00.0") + "' " + cboLo.Items[cboLo.SelectedIndex].ToString();

            
             //FMI(II) = System.Math.Sign(KPLOPDist) * Int((System.Math.Abs(KPLOPDist) * 10 + 0.5) / 10) 'changed in V4.0.0
             //If KPLOPDist > 0 Then
             //FD(II) = "A" 'PlotOut.PlotIntercept &= " Away"
             //Else
             //FD(II) = "T" 'PlotOut.PlotIntercept &= " Toward"
             //End If
             //FZN(II) = Int(ZN + 0.5) 'changed in V4.0.0
             //FL(II) = L
             //FLD(II) = txtLDeg.Text
             //FLM(II) = txtLMin.Text
             //FLA(II) = cboL.Items(cboL.SelectedIndex).ToString
             //FLo(II) = Lo
             //FMD(II) = txtLoDeg.Text
             //FMM(II) = txtLoMin.Text
             //FM(II) = cboLo.Items(cboLo.SelectedIndex).ToString
             //FGHA(II) = GHA      'added in V5.6.1
             //FDec(II) = Dec      'added in V5.6.1
             //FHo(II) = Ho        'added in V5.6.1
             //'FEP(II) = PlotOut.PlotSLEP
             //FEP(II) = "EP L " & EstLDeg.ToString("#0") & Chr(176) & EstLMin.ToString("00.0") & "' " & cboL.Items(cboL.SelectedIndex).ToString &
             //"EP Lo " & EstLoDeg.ToString("##0") & Chr(176) & EstLoMin.ToString("00.0") & "' " & cboLo.Items(cboLo.SelectedIndex).ToString

            SendMsgBx("Sight reduction data saved - Enter new sight data", MessageBoxIcon.Information);
            cmdSave.Visible = false;
            return;
        }

        private short KdDeg; // B34 As Double
        private short Z4Deg;
        private readonly short ZnTDeg;
        // ReadOnly ZnT As Double
        private double Z4Min;
        private readonly double ZnTMin;
        private double ZLoc;         // ZnT As Double, ZnTDeg As Integer, ZnTMin As Double,
        private double ZnLoC;
        private short ZnLoCDeg;
        private double ZnLoCMin;
        private bool FormAltSRLoaded = false;
        private double Hpv;
        private short HpvDeg;
        private double HpvMin;
        private readonly DateTime DTInit = new DateTime(1901, 1, 1, 1, 1, 1);
        private CLSForm.PlotEntry PlotOut;
        private int txtSightNum = 0;
        private bool LOCSight = false;

        private void CboDec_SelectedIndexChanged(object sender, EventArgs e)
        {
            Refresh();
            return;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            if (CheckOpenWinForms("FormMeridianDiagram") == true)
            {
                My.MyProject.Forms.FormMeridianDiagram.ExitBtn.PerformClick();
                My.MyProject.Forms.FormMeridianDiagram.Close();
            }

            if (InvokedbySightLog == true)
            {
                My.MyProject.Forms.SightLog.FormAltSRLoaded = false;
                InvokedbySightLog = false;
            }

            Close();
            return;
        }

        private void chkDSD_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            cmd229_Click(cmd229, new EventArgs());
        }

        private void chkInterpolateB_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            cmdWeems_Click(cmdWeems, new EventArgs());
        }

        private void chkSadler_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            if ((int)chkSadler.CheckState == 1)
            {
                chkDSD.Visible = false;
                frameNASRUsing.Visible = false;
                frame211.Visible = true; // : optCompact.Value = True
                frame214.Visible = false;
                Label9.Visible = false;
                FlagSRFLoCNASR = true;
                My.MyProject.Forms.MainMenu.FormSRFFlagSRFLocNASR = false;
                DecimalDegrees();
                Sadler();
                if (Flag == true)
                    return;
                EstimatedPosition();
                DisplaySadler();
                AssignPlotPosition();
                cmdSave.Visible = false;
                btnUseCLS.Visible = true;
                btnCustomPlot.Visible = true;
                cmdMerDiag.Visible = true;
                cmdMerDiag.Enabled = true;
            }

            if (chkSadler.CheckState == 0)
                cmd211_Click(cmd211, new EventArgs());
        }

        private void cmd208_Click(object eventSender, EventArgs eventArgs)
        {
            chkDSD.Visible = false;
            chkSadler.Visible = false;
            LOCSight = false;
            FlagSRFLoCNASR = true;
            My.MyProject.Forms.MainMenu.FormSRFFlagSRFLocNASR = false;
            DecimalDegrees();
            HO208();
            if (Flag0 == true)
                return;
            APEPNASR();
            KPLOPNASR();
            EPNASR();
            Display208();
            AssignPlotPosition();
            cmdSave.Visible = false;
            btnUseCLS.Visible = true;
            btnCustomPlot.Visible = true;
            cmdMerDiag.Visible = true;
            cmdMerDiag.Enabled = true;
        }

        private void cmd211_Click(object eventSender, EventArgs eventArgs)
        {
            chkDSD.Visible = false;
            chkSadler.Visible = false;
            LOCSight = false;
            chkSadler.CheckState = CheckState.Unchecked;
            FlagSRFLoCNASR = true;
            My.MyProject.Forms.MainMenu.FormSRFFlagSRFLocNASR = false;
            DecimalDegrees();
            HO211();
            if (Flag == true)
                return;
            EstimatedPosition();
            Display211();
            AssignPlotPosition();
            cmdSave.Visible = false;
            btnUseCLS.Visible = true;
            btnCustomPlot.Visible = true;
            cmdMerDiag.Visible = true;
            cmdMerDiag.Enabled = true;
        }

        private void cmd214_Click(object eventSender, EventArgs eventArgs)
        {
            chkDSD.Visible = false;
            chkSadler.Visible = false;
            LOCSight = false;
            FlagSRFLoCNASR = true;
            My.MyProject.Forms.MainMenu.FormSRFFlagSRFLocNASR = false;
            DecimalDegrees();
            HO214();
            if (optd.Checked == true)
            {
                APEPNASR();
                KPLOPNASR();
                EPNASR();
            }

            if (optdt.Checked == true)
            {
                AsmLo = Math.Abs(Lo);
                APEPNASR();
                KPLOPNASR();
                EPNASR();
            }

            if (optdtL.Checked == true)
            {
                EstimatedPosition();
            }

            Display214();
            AssignPlotPosition();
            cmdSave.Visible = false;
            btnUseCLS.Visible = true;
            btnCustomPlot.Visible = true;
            cmdMerDiag.Visible = true;
            cmdMerDiag.Enabled = true;
        }

        private void cmdWeems_Click(object eventSender, EventArgs eventArgs)
        {
            FlagWeems = true;
            chkDSD.Visible = false;
            chkSadler.Visible = false;
            LOCSight = false;
            FlagSRFLoCNASR = true;
            My.MyProject.Forms.MainMenu.FormSRFFlagSRFLocNASR = false;
            DecimalDegrees();
            Weems();
            APEPNASR();
            KPLOPNASR();
            EPNASR();
            DisplayWeems();
            AssignPlotPosition();
            cmdSave.Visible = false;
            btnUseCLS.Visible = true;
            btnCustomPlot.Visible = true;
            cmdMerDiag.Visible = true;
            cmdMerDiag.Enabled = true;
        }

        private void cmd229_Click(object eventSender, EventArgs eventArgs)
        {
            chkDSD.Visible = true;
            chkSadler.Visible = false;
            LOCSight = false;
            FlagSRFLoCNASR = true;
            My.MyProject.Forms.MainMenu.FormSRFFlagSRFLocNASR = false;
            DecimalDegrees();
            HO229();
            APEPNASR();
            KPLOPNASR();
            EPNASR();
            Display229();
            AssignPlotPosition();
            cmdSave.Visible = false;
            btnUseCLS.Visible = true;
            btnCustomPlot.Visible = true;
            cmdMerDiag.Visible = true;
            cmdMerDiag.Enabled = true;
        }

        private void cmd249_Click(object eventSender, EventArgs eventArgs)
        {
            chkDSD.Visible = false;
            chkSadler.Visible = false;
            LOCSight = false;
            frameNASRUsing.Visible = false;
            FlagSRFLoCNASR = true;
            My.MyProject.Forms.MainMenu.FormSRFFlagSRFLocNASR = false;
            DecimalDegrees();
            HO249();
            APEPNASR();
            KPLOPNASR();
            EPNASR();
            Display249();
            AssignPlotPosition();
            cmdSave.Visible = false;
            btnUseCLS.Visible = true;
            btnCustomPlot.Visible = true;
            cmdMerDiag.Visible = true;
            cmdMerDiag.Enabled = true;
        }

        private void cmdClear_Click(object eventSender, EventArgs eventArgs)
        {
            txtGHADeg.Text = "";
            txtGHAMin.Text = "";
            txtDecDeg.Text = "";
            txtDecMin.Text = "";
            txtHoDeg.Text = "";
            txtHoMin.Text = "";
            txtLDeg.Text = "";
            txtLMin.Text = "";
            txtLoDeg.Text = "";
            txtLoMin.Text = "";
            DTSight.Value = DTInit;
            frameNASRUsing.Visible = false;
            GroupBoxPrecision.Visible = false;      // V5.6.1
            chkDSD.CheckState = CheckState.Unchecked;
            chkDSD.Visible = false;
            chkSadler.Visible = false;
            chkInterpolateB.Visible = false;
            chkDSD.CheckState = CheckState.Unchecked;
            chkDSD.Visible = false;
            chkSadler.Visible = false;
            chkInterpolateB.Visible = false;
            btnUseCLS.Visible = false;
            btnCustomPlot.Visible = false;
            frame211.Visible = false;
            frame214.Visible = false;
            Label9.Visible = false;
            ClearAllRptTextBx();
            cmdMerDiag.Enabled = false;
            cmdMerDiag.Visible = false;
            txtGHADeg.Focus();
        }

        private void cmdClearSome_Click(object eventSender, EventArgs eventArgs)
        {
            txtGHADeg.Text = "";
            txtGHAMin.Text = "";
            txtDecDeg.Text = "";
            txtDecMin.Text = "";
            txtHoDeg.Text = "";
            txtHoMin.Text = "";
            DTSight.Value = DTInit;
            frameNASRUsing.Visible = false;
            GroupBoxPrecision.Visible = false;      // V5.6.1
            chkDSD.CheckState = CheckState.Unchecked;
            chkDSD.Visible = false;
            chkSadler.Visible = false;
            chkInterpolateB.Visible = false;
            frame211.Visible = false;
            frame214.Visible = false;
            Label9.Visible = false;
            btnUseCLS.Visible = false;
            btnCustomPlot.Visible = false;
            ClearAllRptTextBx();
            txtGHADeg.Focus();
        }

        private void cmdMerDiag_Click_1(object sender, EventArgs e)
        {
            if (CheckOpenWinForms("FormMeridianDiagram") == true)
            {
                My.MyProject.Forms.FormMeridianDiagram.ExitBtn.PerformClick();
                My.MyProject.Forms.FormMeridianDiagram.Close();
            }

            My.MyProject.Forms.FormMeridianDiagram.Show();
            My.MyProject.Forms.FormMeridianDiagram.SetDesktopLocation(5, 5); // 
            My.MyProject.Forms.FormMeridianDiagram.FormSRFFlagMD = false;
            My.MyProject.Forms.FormMeridianDiagram.FormAltSRFlagMD = true;
            My.MyProject.Forms.FormMeridianDiagram.L = L;
            My.MyProject.Forms.FormMeridianDiagram.Ho = Htot;
            My.MyProject.Forms.FormMeridianDiagram.ZN = ZN;
            My.MyProject.Forms.FormMeridianDiagram.LHA = LHA;
            My.MyProject.Forms.FormMeridianDiagram.Dec = Dec;
            My.MyProject.Forms.FormMeridianDiagram.BodyName = "";
            My.MyProject.Forms.FormMeridianDiagram.DisplayMerDiag();
            My.MyProject.Forms.FormMeridianDiagram.FormSRFFlagMD = false;
            My.MyProject.Forms.FormMeridianDiagram.FormAltSRFlagMD = false;
            cmdMerDiag.Enabled = false;
            cmdMerDiag.Visible = false;
            return;
        }

        // Public Sub cmdMerDiag_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        // FormMeridianDiagram.Show()
        // FormMeridianDiagram.FormSRFFlagMD = False
        // FormMeridianDiagram.FormAltSRFlagMD = True
        // FormMeridianDiagram.DisplayMerDiag()
        // FormMeridianDiagram.FormSRFFlagMD = False
        // FormMeridianDiagram.FormAltSRFlagMD = False
        // cmdMerDiag.Enabled = False
        // End Sub

        private void cmdNASR_Click(object eventSender, EventArgs eventArgs)
        {
            chkDSD.Visible = false;
            chkSadler.Visible = false;
            LOCSight = false;
            FlagSRFLoCNASR = true;
            My.MyProject.Forms.MainMenu.FormSRFFlagSRFLocNASR = false;
            DecimalDegrees();
            NASR();
            APEPNASR();
            KPLOPNASR();
            EPNASR();
            DisplayNASR();
            AssignPlotPosition();
            cmdSave.Visible = false;
            btnNASRFix.Visible = true;
            btnUseCLS.Visible = true;
            btnCustomPlot.Visible = true;
            cmdMerDiag.Visible = true;
            cmdMerDiag.Enabled = true;
        }

        private void cmdPrint_Click(object eventSender, EventArgs eventArgs)
        {
            Print_Renamed.PrintScreen(Bounds);
        }

        private void cmdSTable_Click(object eventSender, EventArgs eventArgs)
        {
            chkDSD.Visible = false;
            chkSadler.Visible = false;
            LOCSight = false;
            FlagSRFLoCNASR = true;
            My.MyProject.Forms.MainMenu.FormSRFFlagSRFLocNASR = false;
            DecimalDegrees();
            STable();
            if (Flag == true)
                return; // WHAT IS THIS FOR?
            EstimatedPosition();
            DisplaySTable();
            cmdSave.Visible = false;
            btnUseCLS.Visible = true;
            btnCustomPlot.Visible = true;
            cmdMerDiag.Visible = true;
            cmdMerDiag.Enabled = true;
        }

        private void Form_Initialize_Renamed()
        {
            Pi = 4d * Math.Atan(1.0d);
        }

        private void cmdLawOfCosines_Click(object eventSender, EventArgs eventArgs)
        {
            if (DTSight.Value == DTInit)
            {
                ErrorMsgBox("Must enter minimum of hhmm time for Law of Cosines sight reduction");
                return;
            }

            LOCSight = true;
            // If txtTime.Text = "" Or txtTime.Text.Length < 4 Then
            // ErrorMsgBox("Must enter hhmm time for Law of Cosines sight reduction")
            // Exit Sub
            // End If
            chkDSD.Visible = false;
            chkSadler.Visible = false;
            FlagSRFLoCNASR = true;
            My.MyProject.Forms.MainMenu.FormSRFFlagSRFLocNASR = false;
            DecimalDegrees();
            LawOfCosines();
            EstimatedPosition();
            DisplayLOC();
            cmdSave.Visible = true;
            btnNASRFix.Visible = false;
            btnUseCLS.Visible = true;
            btnCustomPlot.Visible = true;
            cmdMerDiag.Visible = true;
            cmdMerDiag.Enabled = true;
        }

        private void FormAltSR_Load(object eventSender, EventArgs eventArgs)
        {
            cboDec.SelectedIndex = 0; // "N"
            cboL.SelectedIndex = 0; // "N"
            cboLo.SelectedIndex = 0; // "W"
            SRHdrTxtBx.Visible = false;
            SRHdrTxtBx.Clear();
            SRLgTxtBx.Clear();
            SRLgTxtBx.Visible = false;
            SRLeftTxtBx.Clear();
            SRLeftTxtBx.Visible = false;
            SRRightTxtBx.Clear();
            SRRightTxtBx.Visible = false;
            btnUseCLS.Visible = false;
            btnCustomPlot.Visible = false;
            LOCSight = false;
            // FormAltSR SR Methods load event code
            if (My.MyProject.Forms.FavoriteLocations.SharedLocUse.EntryStatus == "Shared")
            {
                BringToFront();
                if (My.MyProject.Forms.FavoriteLocations.CommonYesNoMsgBox("Shared Location data is available - do you want to use it?") == true)
                {
                    {
                        var withBlock = My.MyProject.Forms.FavoriteLocations.SharedLocUse;
                        txtLDeg.Text = withBlock.DRLatDeg.ToString();
                        txtLMin.Text = withBlock.DRLatMin.ToString();
                        if ((withBlock.DRLatNS ?? "") == (CommonGlobals.g_LatN ?? ""))
                        {
                            cboL.SelectedIndex = 0;
                        }
                        else
                        {
                            cboL.SelectedIndex = 1;
                        }

                        txtLoDeg.Text = withBlock.DRLongDeg.ToString();
                        txtLoMin.Text = withBlock.DRLongMin.ToString();
                        if ((withBlock.DRLongEW ?? "") == (CommonGlobals.g_LongW ?? ""))
                        {
                            cboLo.SelectedIndex = 0;
                        }
                        else
                        {
                            cboLo.SelectedIndex = 1;
                        }
                    }
                }
            }

            FormAltSRLoaded = true;
        }

        public void DisplayLOC()
        {
            // Me.Font = New Font(Me.Font, "Courier New")
            SRHdrTxtBx.Visible = true;
            SRHdrTxtBx.Clear();
            SRHdrTxtBx.BringToFront();
            SRLgTxtBx.Clear();
            SRLgTxtBx.Visible = true;
            SRLgTxtBx.BringToFront();
            SRLeftTxtBx.Clear();
            SRLeftTxtBx.Visible = false;
            SRLeftTxtBx.SendToBack();
            SRRightTxtBx.Clear();
            SRRightTxtBx.Visible = false;
            SRRightTxtBx.SendToBack();
            NASRAsmTxtBx.Clear();
            NASRAsmTxtBx.Visible = false;
            NASRAsmTxtBx.SendToBack();
            NASRAFTxtBx.Clear();
            NASRAFTxtBx.Visible = false;
            NASRAFTxtBx.SendToBack();
            DCorrTxtBx.Clear();
            DCorrTxtBx.Visible = false;
            DCorrTxtBx.SendToBack();
            WeemsPVTxtBx.Clear();            // V5.6.1
            WeemsPVTxtBx.Visible = false;    // V5.6.1
            WeemsPVTxtBx.SendToBack();       // V5.6.1
            frameNASRUsing.Visible = false;
            frame211.Visible = false;
            frame214.Visible = false;
            Label9.Visible = false;
            frameS.Visible = false;
            GroupBoxPrecision.Visible = true;      // V5.6.1
            chkInterpolateB.Visible = false;
            // CurrentY = 2260

            var argTB = SRHdrTxtBx;
            AlignCenterRTB(ref argTB);
            SRHdrTxtBx = argTB;
            SRHdrTxtBx.AppendText("INTERCEPT and AZIMUTH by the LAW of COSINES METHOD");
            SRLgTxtBx.AppendText(Constants.vbTab + Constants.vbTab + Constants.vbTab + Constants.vbTab + "LHA" + Strings.Space(6 - LHADeg.ToString().Length) + Strings.Format(LHADeg, "0") + '°' + Strings.Format(LHAMin, "00.0") + "' " + Strings.Space(2) + "-------> LHA" + Strings.Space(15 - LHADeg.ToString().Length) + Strings.Format(LHA, "0.00000") + '°' + Environment.NewLine);
            SRLgTxtBx.AppendText(Constants.vbTab + Constants.vbTab + Constants.vbTab + Constants.vbTab + "Lat" + Strings.Space(6 - Conversion.Val(txtLDeg.Text).ToString().Length) + Strings.Format(Conversion.Val(txtLDeg.Text), "0") + '°' + Strings.Format(Conversion.Val(txtLMin.Text), "00.0") + "'" + cboL.Text + Strings.Space(1) + "-------> Lat (+)" + Strings.Space(11 - txtLDeg.Text.Length) + Strings.Format(Math.Abs(L), "0.00000") + '°' + Environment.NewLine);
            SRLgTxtBx.AppendText(Constants.vbTab + Constants.vbTab + Constants.vbTab + Constants.vbTab + "Dec" + Strings.Space(6 - DecDegrees.ToString().Length) + Strings.Format(Math.Abs(DecDegrees), "0") + '°' + Strings.Format(DecMinutes, "00.0") + "'");
            if (DE == 0d)
            {
                SRLgTxtBx.AppendText("");
            }
            else
            {
                SRLgTxtBx.AppendText(cboDec.Text);
            }

            SRLgTxtBx.AppendText(Strings.Space(1) + "-------> Dec (" + SignDE + ")");
            SRLgTxtBx.AppendText(Strings.Space(11 - DecDegrees.ToString().Length) + Strings.Format(Math.Abs(DE), "0.00000") + '°' + Environment.NewLine);
            SRLgTxtBx.AppendText("(cos LHA x cos Lat x cos Dec) + (sin Lat x sin Dec) = sin Hc ---->" + "   Hc " + Strings.Format(Conversion.Int(Hc * 100000d + 0.5d) / 100000d, "0.00000") + '°' + Environment.NewLine);
            SRLgTxtBx.AppendText("(sin Dec - (sin Lat x sin Hc)) / (cos Lat x cos Hc) = cos Z ----->" + "   Z  " + cboL.Text + Strings.Space(1) + Strings.Format(Conversion.Int(Z * 10d + 0.5d) / 10d, "0.0") + '°');
            if (LHA <= 180d)
                SRLgTxtBx.AppendText(" W");
            if (LHA > 180d)
                SRLgTxtBx.AppendText(" E");
            SRLgTxtBx.AppendText(Environment.NewLine);
            SRLgTxtBx.AppendText("Hc ");
            if (Math.Sign(Hc) == -1)
            {
                SRLgTxtBx.AppendText(Constants.vbTab + "-");
            }
            else
            {
                SRLgTxtBx.AppendText(Constants.vbTab + " ");
            }

            SRLgTxtBx.AppendText(Strings.Format(Math.Abs(HcDeg), "0") + '°' + Strings.Format(HcMin, "00.0") + "'" + Environment.NewLine);
            SRLgTxtBx.AppendText("Ho ");
            if (Math.Sign(HoinMinutes) == -1)
            {
                SRLgTxtBx.AppendText(Constants.vbTab + "-");
            }
            else
            {
                SRLgTxtBx.AppendText(Constants.vbTab + " ");
            }

            SRLgTxtBx.AppendText(Strings.Format(Math.Abs(HoDeg), "0") + '°' + Strings.Format(Math.Abs(HoMin), "00.0") + "'" + Environment.NewLine);
            i = (short)Conversion.Int(Math.Abs(A) * 10d + 0.5d).ToString().Length;
            if (Math.Abs(A) < 1d)
            {
                i = (short)(i + 1);
            }

            SRLgTxtBx.AppendText(" a" + Strings.Space(12 - i) + Strings.Format(Math.Abs(A), "0.0") + " nm ");
            PlotOut.PlotIntercept = Strings.Format(Math.Abs(A), "0.0") + " nm ";
            if (A != 0d & A < 0d)
            {
                SRLgTxtBx.AppendText("T  Ho > Hc....Toward");
                PlotOut.PlotIntercept += " Toward";
            }

            if (A != 0d & A > 0d)
            {
                SRLgTxtBx.AppendText("A  Hc > Ho....Away");
                PlotOut.PlotIntercept += " Away";
            }

            SRLgTxtBx.AppendText(Strings.Space(32) + "Zn " + Strings.Format(ZN, "000") + '°' + Environment.NewLine);
            PlotOut.PlotAz = Strings.Format(ZN, "000") + '°';
            SRLgTxtBx.AppendText("EP L  " + Strings.Space(11 - EstLDeg.ToString().Length) + Strings.Format(EstLDeg, "0") + '°' + Strings.Format(EstLMin, "00.0") + "'");
            PlotOut.PlotSLEP = "EP L  " + Strings.Format(EstLDeg, "0") + '°' + Strings.Format(EstLMin, "00.0") + "'";
            if (EstL > 0d)
            {
                SRLgTxtBx.AppendText(CommonGlobals.g_LatN);
                PlotOut.PlotSLEP += CommonGlobals.g_LatN;
                PlotOut.PlotLatNS = CommonGlobals.g_LatN;
            }

            if (EstL == 0d)
            {
                SRLgTxtBx.AppendText(CommonGlobals.g_StrSpace);
                PlotOut.PlotSLEP += CommonGlobals.g_LatN;
                PlotOut.PlotLatNS = CommonGlobals.g_LatN;
            }

            if (EstL < 0d)
            {
                SRLgTxtBx.AppendText(CommonGlobals.g_LatS);
                PlotOut.PlotSLEP += CommonGlobals.g_LatS;
                PlotOut.PlotLatNS = CommonGlobals.g_LatS;
            }

            SRLgTxtBx.AppendText(Environment.NewLine);
            SRLgTxtBx.AppendText("EP Lo " + Strings.Space(11 - EstLoDeg.ToString().Length) + Strings.Format(EstLoDeg, "0") + '°' + Strings.Format(EstLoMin, "00.0") + "'");
            PlotOut.PlotSLEP += " EP Lo " + Strings.Format(EstLoDeg, "0") + '°' + Strings.Format(EstLoMin, "00.0") + "'";
            if (EstLo > 0d)
            {
                SRLgTxtBx.AppendText(CommonGlobals.g_LongW);
                PlotOut.PlotSLEP += CommonGlobals.g_LongW;
                PlotOut.PlotLongEW = CommonGlobals.g_LongW;
            }

            if (EstLo == 0d)
            {
                SRLgTxtBx.AppendText(CommonGlobals.g_StrSpace);
                PlotOut.PlotSLEP += CommonGlobals.g_LongW;
                PlotOut.PlotLongEW = CommonGlobals.g_LongW;
            }

            if (EstLo < 0d)
            {
                SRLgTxtBx.AppendText(CommonGlobals.g_LongE);
                PlotOut.PlotSLEP += CommonGlobals.g_LongE;
                PlotOut.PlotLongEW = CommonGlobals.g_LongE;
            }

            SRLgTxtBx.Refresh();
        }

        public void LawOfCosines()
        {
            // This section moved from DecimalDegrees in V5.6.1 for LawOfCosines only
            GHA = Conversion.Val(txtGHADeg.Text) + Conversion.Val(txtGHAMin.Text) / 60d;
            // GHA = Int(GHA * 100000 + 0.5) / 100000             NOT ADDED V4.3.0
            DE = Conversion.Val(txtDecDeg.Text) + Conversion.Val(txtDecMin.Text) / 60d;
            if (optRound.Checked)
            {
                DE = Conversion.Int(DE * 100000d + 0.5d) / 100000d;              // ADDED V4.3.0,  removed in V4.7.1 and moved to LoC only, optRound in V5.6.1
            }

            Dec = DE;
            if (cboDec.Text == "S")
            {
                Dec = -DE;
            }

            DecDegrees = (short)Conversion.Int(DE);
            DecMinutes = (DE - DecDegrees) * 60d;
            if (Conversion.Int(DecMinutes * 10d + 0.5d) / 10d == 60d)
            {
                DecMinutes = 0d;
                DecDegrees = (short)(DecDegrees + 1);
            }

            Ho = Conversion.Val(txtHoDeg.Text) + Conversion.Val(txtHoMin.Text) / 60d;
            // Ho = Int(Ho * 100000 + 0.5) / 100000
            HoinMinutes = Ho * 60d;
            HoDeg = (short)Conversion.Fix(HoinMinutes / 60d);  // min to dec. deg.; Fix was Int
            HoMin = Math.Abs(HoinMinutes - 60 * HoDeg + 0.5d);
            // HoMin = HoinMinutes - 60 * HoDeg
            // HoMin = Int(HoMin + 0.5)
            if (Conversion.Int(HoMin * 10d + 0.5d) / 10d == 60d)
            {
                HoMin = 0d;
                HoDeg = (short)(HoDeg + 1);
            }

            L = Conversion.Val(txtLDeg.Text) + Conversion.Val(txtLMin.Text) / 60d;
            if (optRound.Checked)
                L = Conversion.Int(L * 100000d + 0.5d) / 100000d;                  // ADDED V4.3.0, optRound in V5.6.1
            if (cboL.Text == "S")
                L = -L;
            Lo = Conversion.Val(txtLoDeg.Text) + Conversion.Val(txtLoMin.Text) / 60d;
            if (cboLo.Text == "E")
                Lo = -Lo;
            LHA = GHA - Lo;
            if (optRound.Checked)
                LHA = Conversion.Int(LHA * 100000d + 0.5d) / 100000d;              // ADDED V4.3.0, optRound in V5.6.1
            if (LHA >= 360d)
                LHA = LHA - 360d;
            if (LHA < 0d)
                LHA = LHA + 360d;
            LHADeg = (short)Conversion.Int(LHA);
            LHAMin = (LHA - LHADeg) * 60d;
            LHAMin = Conversion.Int(LHAMin * 10d + 0.5d) / 10d;
            if (Conversion.Int(LHAMin * 10d + 0.5d) / 10d == 60d)
            {
                LHAMin = 0d;
                LHADeg = (short)(LHADeg + 1);
            }

            // DE = Int(DE * 100000 + 0.5) / 100000 'Moved from DecimalDegrees in V4.7.1
            SignDE = "+";
            if (cboDec.Text == "S" & cboL.Text == "N" | cboDec.Text == "N" & cboL.Text == "S")
            {
                DE = -DE;
                SignDE = "-";
            }

            L1 = Math.Cos(LHA * Pi / 180d) * Math.Cos(Math.Abs(L) * Pi / 180d) * Math.Cos(DE * Pi / 180d);
            L2 = Math.Sin(Math.Abs(L) * Pi / 180d) * Math.Sin(DE * Pi / 180d);
            L3 = L1 + L2;
            if (Math.Abs(L3) >= 1d)
            {
                Hc = Math.Sign(L3) * Pi / 2d;
            }
            else
            {
                Hc = Math.Atan(L3 / Math.Sqrt(-L3 * L3 + 1d));
            }

            Hc = Hc * 180d / Pi;
            if (optRound.Checked)
            {
                Hc = Conversion.Int(Hc * 10000d + 0.5d) / 10000d;      // added in V5.1.5, optRound in V5.6.1
            }

            Htot = Hc;
            HcDeg = (short)Conversion.Fix(Hc);
            HcMin = (Hc - HcDeg) * 60d;
            HcMin = Conversion.Int(HcMin * 10d + 0.5d) / 10d;
            if (HcMin == 60d)
            {
                HcMin = 0d;
                if (HcDeg >= 0)
                    HcDeg = (short)(HcDeg + 1);
                if (HcDeg < 0)
                    HcDeg = (short)(HcDeg - 1);
            }

            A = 60 * HcDeg + HcMin - (60 * HoDeg + HoMin);
            A = Math.Sign(A) * Conversion.Int((Math.Abs(A) * 10d + 0.5d) / 10d);
            L4 = Math.Sin(DE * Pi / 180d);
            L5 = Math.Sin(Math.Abs(L) * Pi / 180d) * Math.Sin(Hc * Pi / 180d);
            L6 = L4 - L5;
            L7 = Math.Cos(Math.Abs(L) * Pi / 180d) * Math.Cos(Hc * Pi / 180d);
            L8 = L6 / L7;
            if (Math.Abs(L8) >= 1d)
                Z = Pi;
            else
                Z = Math.Atan(-L8 / Math.Sqrt(-L8 * L8 + 1d)) + Pi / 2d;
            Z = Z * 180d / Pi;
            Z = Conversion.Int(Z * 10d + 0.5d) / 10d; // round to one decimal place
            if (cboL.Text == "N" & LHA > 180d)
                ZN = Z;
            if (cboL.Text == "N" & LHA <= 180d)
                ZN = 360d - Z;
            if (cboL.Text == "S" & LHA > 180d)
                ZN = 180d - Z;
            if (cboL.Text == "S" & LHA <= 180d)
                ZN = 180d + Z;
            ZN = Conversion.Int(ZN + 0.5d);
            if (ZN == 360d)
                ZN = 0d;
            HcDeg = (short)Conversion.Fix(Hc);
            HcMin = Math.Abs((Hc - HcDeg) * 60d);
            if (Conversion.Int(HcMin * 10d + 0.5d) / 10d == 60d)
            {
                HcMin = 0d;
                if (HcDeg >= 0)
                    HcDeg = (short)(HcDeg + 1);
                if (HcDeg < 0)
                    HcDeg = (short)(HcDeg - 1);
            }

            return;
        }

        private void FormAltSR_FormClosed(object eventSender, FormClosedEventArgs eventArgs)
        {
            // Cleanup()
        }

        private void optCompact_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (!FormAltSRLoaded)
                return;
            if (optCompact.Checked) // eventSender.Checked Then
            {
                cmd211_Click(cmd211, new EventArgs());
            }
        }

        private void optd_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (!FormAltSRLoaded)
                return;
            if (optd.Checked)   // eventSender.Checked Then
            {
                cmd214_Click(cmd214, new EventArgs());
            }
        }

        private void optdt_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (!FormAltSRLoaded)
                return;
            if (optd.Checked)    // eventSender.Checked Then
            {
                cmd214_Click(cmd214, new EventArgs());
            }
        }

        private void optdtL_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (!FormAltSRLoaded)
                return;
            if (optdtL.Checked)   // eventSender.Checked Then
            {
                cmd214_Click(cmd214, new EventArgs());
            }
        }

        private void optFarley_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (!FormAltSRLoaded)
                return;
            if (optFarley.Checked)   // eventSender.Checked Then
            {
                cmdSTable_Click(cmdSTable, new EventArgs());
            }
        }

        private void optNATable_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (!FormAltSRLoaded)
                return;
            if (optNATable.Checked) // eventSender.Checked Then
            {
                cmdNASR_Click(cmdNASR, new EventArgs());
            }
        }

        private void optOriginal_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (!FormAltSRLoaded)
                return;
            if (optOriginal.Checked) // eventSender.Checked Then
            {
                // chkSadler.Value = 0
                cmd211_Click(cmd211, new EventArgs());
            }
        }

        private void optPepperday_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (!FormAltSRLoaded)
                return;
            if (optPepperday.Checked) // eventSender.Checked Then
            {
                cmdSTable_Click(cmdSTable, new EventArgs());
            }
        }

        private void optUSPSTable_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (!FormAltSRLoaded)
                return;
            if (optUSPSTable.Checked)
            {
                cmdNASR_Click(cmdNASR, new EventArgs());
            }
        }

        private void txtDecDeg_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtDecDeg.Text) != 90d)
            {
                txtDecMin.Enabled = true;
            }

            if (Conversion.Val(txtDecDeg.Text) == 90d)
            {
                txtDecMin.Enabled = false;
                txtDecMin.BackColor = System.Drawing.Color.Gray;   //Color.Gray;
            }

            txtDecDeg.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtDecDeg.Text) > 90d | Conversion.Val(txtDecDeg.Text) == 90d & Conversion.Val(txtDecMin.Text) != 0d)
            {
                txtDecDeg.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtDecDeg.Text) < 90d)
            {
                txtDecMin.BackColor = Control.DefaultBackColor; 
            }
        }

        private void txtDecDeg_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        private void txtDecDeg_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtDecDeg.Text) > 90d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtDecDeg_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtDecDeg;
            SelectAllText(ref argTB);
            txtDecDeg = argTB;
        }

        private void txtDecMin_TextChanged(object eventSender, EventArgs eventArgs)
        {
            // txtDecMin.ForeColor = &H80000008
            txtDecMin.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtDecMin.Text) > 59.9d)
            {
                txtDecMin.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }
        }

        private void txtDecMin_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        if (Conversions.ToBoolean(Strings.InStr(txtDecMin.Text, ".")))
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

        private void txtDecMin_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtDecMin.Text) > 59.9d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtDecMin_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtDecMin;
            SelectAllText(ref argTB);
            txtDecMin = argTB;
        }

        private void txtGHADeg_TextChanged(object eventSender, EventArgs eventArgs)
        {
            txtGHADeg.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtGHADeg.Text) > 719d)
            {
                txtGHADeg.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }
        }

        private void txtGHADeg_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        private void txtGHADeg_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtGHADeg.Text) > 719d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtGHADeg_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtGHADeg;
            SelectAllText(ref argTB);
            txtGHADeg = argTB;
        }

        private void txtGHAMin_TextChanged(object eventSender, EventArgs eventArgs)
        {
            txtGHAMin.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtGHAMin.Text) > 59.9d)
            {
                txtGHAMin.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }
        }

        private void txtGHAMin_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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
                        if (Conversions.ToBoolean(Strings.InStr(txtGHAMin.Text, ".")))
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

        private void txtGHAMin_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtGHAMin.Text) > 59.9d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtGHAMin_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtGHAMin;
            SelectAllText(ref argTB);
            txtGHAMin = argTB;
        }

        private void txtHoDeg_TextChanged(object eventSender, EventArgs eventArgs)
        {
            cmdNASR.Enabled = true;
            cmdLawOfCosines.Enabled = true;
            cmd229.Enabled = true;
            txtHoDeg.BackColor = Control.DefaultBackColor; 
            txtHoMin.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtHoDeg.Text) == 90d)
            {
                txtHoMin.Enabled = false;
                txtHoMin.BackColor = System.Drawing.Color.Gray; //Color.Gray;
            }

            if (Conversion.Val(txtHoDeg.Text) > 90d)
            {
                txtHoDeg.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtHoDeg.Text) > 88d | Conversion.Val(txtHoDeg.Text) == 88d & Conversion.Val(txtHoMin.Text) != 0d)
                cmdLawOfCosines.Enabled = false;
            if (Conversion.Val(txtHoDeg.Text) > 85d | Conversion.Val(txtHoDeg.Text) == 85d & Conversion.Val(txtHoMin.Text) != 0d)
                cmd229.Enabled = false;
            if (Conversion.Val(txtHoDeg.Text) > 75d | Conversion.Val(txtHoDeg.Text) == 75d & Conversion.Val(txtHoMin.Text) != 0d)
                cmdNASR.Enabled = false;
        }

        private void txtHoDeg_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
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

        private void txtHoDeg_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtHoDeg.Text) > 90d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtHoDeg_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtHoDeg;
            SelectAllText(ref argTB);
            txtHoDeg = argTB;
        }

        private void txtHoMin_TextChanged(object eventSender, EventArgs eventArgs)
        {
            cmdNASR.Enabled = true;
            cmdLawOfCosines.Enabled = true;
            cmd229.Enabled = true;
            txtHoMin.BackColor = System.Drawing.Color.Red;
            //txtHoMin.BackColor = Control.DefaultBackColor; 
            if (Conversion.Val(txtHoMin.Text) > 59.9d)
            {
                txtHoMin.BackColor = ColorTranslator.FromOle(0xFF);
                ErrorMsgBox("Out of Range");
            }

            if (Conversion.Val(txtHoDeg.Text) > 88d | Conversion.Val(txtHoDeg.Text) == 88d & Conversion.Val(txtHoMin.Text) != 0d)
            {
                cmdLawOfCosines.Enabled = false;
            }

            if (Conversion.Val(txtHoDeg.Text) > 85d | Conversion.Val(txtHoDeg.Text) == 85d & Conversion.Val(txtHoMin.Text) != 0d)
            {
                cmd229.Enabled = false;
            }

            if (Conversion.Val(txtHoDeg.Text) > 75d | Conversion.Val(txtHoDeg.Text) == 75d & Conversion.Val(txtHoMin.Text) != 0d)
            {
                cmdNASR.Enabled = false;
            }
        }

        private void txtHoMin_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            short KeyAscii = (short)Strings.Asc(eventArgs.KeyChar);
            ;

            bool bMinusSignAlready = false; // As Boolean
            bool bPlusSignAlready = false;  // As Boolean

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
                        // If txtHoMin.Text) > 0 Then
                        // KeyAscii = 0
                        // Beep
                        // End If
                        if (txtHoMin.SelectionStart != 0 | bMinusSignAlready)
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
                        // If txtHoMin.Text) > 0 Then
                        // KeyAscii = 0
                        // Beep
                        // End If

                        if (txtHoMin.SelectionStart != 0 | bPlusSignAlready)
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

                case (short)('.'): // only allows one decimal point
                    {
                        if (Conversions.ToBoolean(Strings.InStr(txtHoMin.Text, ".")))
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

        private void txtHoMin_Validating(object eventSender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            bool KeepFocus = eventArgs.Cancel;
            if (Conversion.Val(txtHoMin.Text) > 59.9d | Conversion.Val(txtHoMin.Text) < -59.9d)
            {
                KeepFocus = true;
            }

            eventArgs.Cancel = KeepFocus;
        }

        private void txtHoMin_Enter(object eventSender, EventArgs eventArgs)
        {
            var argTB = txtHoMin;
            SelectAllText(ref argTB);
            txtHoMin = argTB;
        }

        private void txtLDeg_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversion.Val(txtLDeg.Text) != 90d)
                txtLMin.Enabled = true;
            if (Conversion.Val(txtLDeg.Text) == 90d)
            {
                txtLMin.Text = "";
                txtLMin.Enabled = false;
                txtLMin.BackColor = System.Drawing.Color.Gray;
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
            // txtLMin.ForeColor = &H80000008
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
            {
                txtLoMin.Enabled = true;
            }

            if (Conversion.Val(txtLoDeg.Text) == 180d)
            {
                txtLoMin.Text = "";
                txtLoMin.Enabled = false;
                txtLoMin.BackColor = System.Drawing.Color.Gray;
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
                                KeyAscii = 0;
                            Interaction.Beep();
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

        public void DecimalDegrees()
        {
            GHA = Conversion.Val(txtGHADeg.Text) + Conversion.Val(txtGHAMin.Text) / 60d;
            DE = Conversion.Val(txtDecDeg.Text) + Conversion.Val(txtDecMin.Text) / 60d;
            Dec = DE;
            if (cboDec.Text == "S")
            {
                Dec = -DE;
            }

            DecDegrees = (short)Conversion.Int(DE);
            DecMinutes = (DE - DecDegrees) * 60d;
            if (Conversion.Int(DecMinutes * 10d + 0.5d) / 10d == 60d)
            {
                DecMinutes = 0d;
                DecDegrees = (short)(DecDegrees + 1);
            }

            Ho = Conversion.Val(txtHoDeg.Text) + Conversion.Val(txtHoMin.Text) / 60d;
            HoinMinutes = Ho * 60d;
            HoDeg = (short)Conversion.Fix(HoinMinutes / 60d); // min to dec. deg.; Fix was Int
            HoMin = HoinMinutes - 60 * HoDeg;
            if (Conversion.Int(HoMin * 10d + 0.5d) / 10d == 60d)
            {
                HoMin = 0d;
                HoDeg = (short)(HoDeg + 1);
            }

            L = Conversion.Val(txtLDeg.Text) + Conversion.Val(txtLMin.Text) / 60d;
            L = Conversion.Int(L * 100000d + 0.5d) / 100000d; // ADDED V4.3.0
            if (cboL.Text == "S")
                L = -L;
            Lo = Conversion.Val(txtLoDeg.Text) + Conversion.Val(txtLoMin.Text) / 60d;
            if (cboLo.Text == "E")
                Lo = -Lo;
            LHA = GHA - Lo;
            LHA = Conversion.Int(LHA * 100000d + 0.5d) / 100000d; // ADDED V4.3.0
            if (LHA >= 360d)
                LHA = LHA - 360d;
            if (LHA < 0d)
                LHA = LHA + 360d;
            LHADeg = (short)Conversion.Int(LHA);
            LHAMin = (LHA - LHADeg) * 60d;
            LHAMin = Conversion.Int(LHAMin * 10d + 0.5d) / 10d;
            if (Conversion.Int(LHAMin * 10d + 0.5d) / 10d == 60d)
            {
                LHAMin = 0d;
                LHADeg = (short)(LHADeg + 1);
            }

            return;
        }

        public void EstimatedPosition()
        {
            EstL = L - A / 60d * Math.Cos(ZN * Pi / 180d);
            EstLo = Lo + A / 60d * Math.Sin(ZN * Pi / 180d) / Math.Cos(L * Pi / 180d);
            if (Math.Abs(EstLo) > 180d)
                EstLo = -Math.Sign(EstLo) * (360d - Math.Abs(EstLo));
            EstLDeg = (short)Conversion.Int(Math.Abs(EstL));
            EstLMin = (Math.Abs(EstL) - EstLDeg) * 60d;
            if (Conversion.Int(EstLMin * 10d + 0.5d) / 10d == 60d)
            {
                EstLMin = 0d;
                EstLDeg = (short)(EstLDeg + 1);
            }

            EstLoDeg = (short)Conversion.Int(Math.Abs(EstLo));
            EstLoMin = (Math.Abs(EstLo) - EstLoDeg) * 60d;
            if (Conversion.Int(EstLoMin * 10d + 0.5d) / 10d == 60d)
            {
                EstLoMin = 0d;
                EstLoDeg = (short)(EstLoDeg + 1);
            }

            EstLoDeg = Math.Abs(EstLoDeg);
            return;
        }

        public void NASR()
        {
            LHA = GHA - Lo;
            if (LHA >= 360d)
                LHA = LHA - 360d;
            if (LHA < 0d)
                LHA = LHA + 360d;
            AsmLHA = Conversion.Int(LHA + 0.5d);
            if (AsmLHA == 360d)
                AsmLHA = 0d;
            GHAAsmDeg = (short)Conversion.Val(txtGHADeg.Text);
            GHAAsmMin = (short)Conversion.Int(Conversion.Val(txtGHAMin.Text) + 0.5d);
            GHAAsm = GHAAsmDeg + GHAAsmMin / 60d; // in degrees
            AsmLo = GHAAsm - AsmLHA;
            if (Math.Abs(AsmLo) < 180d)
                AsmLo = 360d - Math.Abs(AsmLo);
            if (Math.Abs(AsmLo) >= 180d & Lo >= 0d)
                AsmLo = 360d - Math.Abs(AsmLo);
            if (Math.Abs(AsmLo) >= 180d & Lo < 0d)
                AsmLo = -(360d - Math.Abs(AsmLo));
            AsmLoDeg = (short)Conversion.Int(Math.Abs(AsmLo));
            if (AsmLo > 0d | txtLoDeg.Text == "180")
                AsmLoMin = (float)Conversion.Int(Conversion.Val(txtGHAMin.Text) + 0.5d);
            else
                AsmLoMin = (float)(60d - Conversion.Int(Conversion.Val(txtGHAMin.Text) + 0.5d));
            if (AsmLoMin == 60f)
                AsmLoMin = 0f;
            AsmL = Conversion.Int(L + 0.5d);
            A1 = Math.Cos(AsmL * Pi / 180d) * Math.Sin(AsmLHA * Pi / 180d);
            if (Math.Abs(A1) >= 1d)
                Aval = Math.Sign(A1) * Pi / 2d;
            else
                Aval = Math.Atan(A1 / Math.Sqrt(-A1 * A1 + 1d)); // in radians
            AvalDeg = (short)Conversion.Int(Math.Abs(Aval * 180d / Pi));
            AvalMin = (short)Conversion.Int((Math.Abs(Aval * 180d / Pi) - AvalDeg) * 60d + 0.5d);
            if (AvalMin == 60)
            {
                AvalMin = 0;
                AvalDeg = (short)(AvalDeg + 1);
            }

            Z3 = Math.Cos(AsmLHA * Pi / 180d) / Math.Cos(Aval); // Example b p 2-24 bottom of first column makes Z3=1 NG
                                                                // If Abs(Z3) = 1 Then Z3 = 0  'prevents program from crashing with no inputs
            if (Math.Abs(Z3) >= 1d)
                Z1 = Math.Sign(Z3) * Pi / 2d;
            else
                Z1 = Math.Atan(Z3 / Math.Sqrt(-Z3 * Z3 + 1d)); // in radians
            Z1display = (float)(Conversion.Int(Z1 * 180d / Pi * 10d + 0.5d) / 10d);
            B1 = Math.Cos(AsmL * Pi / 180d) * Math.Sin(Z1);
            if (Math.Abs(B1) >= 1d)
                B = Math.Sign(B1) * Pi / 2d;
            else
                B = Math.Atan(B1 / Math.Sqrt(-B1 * B1 + 1d)); // in radians
            BDeg = (short)Conversion.Int(Math.Abs(B * 180d / Pi));
            BMin = Conversion.Int((Math.Abs(B) * 180d / Pi - BDeg) * 60d + 0.5d);
            if (BMin == 60d)
            {
                BMin = 0d;
                BDeg = (short)(BDeg + 1);
            }

            if (LHA > 90d & LHA < 270d)
                SignB = "-";
            else
                SignB = "+";
            if (LHA > 90d & LHA < 270d)
                SignZ1 = "-";
            else
                SignZ1 = "+";
            SignDE = "+";
            DecMinDisplay = (short)Conversion.Int(Conversion.Val(txtDecMin.Text) + 0.5d);
            if (DecMinDisplay == 60)
            {
                DecMinDisplay = 0;
                DecDegrees = (short)(DecDegrees + 1);
            }

            B = Conversion.Int(B * 180d / Pi * 60d + 0.5d); // rounded to whole minutes
            DE = Conversion.Int(DE * 60d + 0.50000000001d); // rounded to whole minutes
            if (cboDec.Text == "S" & cboL.Text == "N" | cboDec.Text == "N" & cboL.Text == "S")
            {
                DE = -DE;
                SignDE = "-";
            }

            F = B + DE; // in minutes
            F = F / 60d; // in degrees
            FWhole = (short)Conversion.Int(F + 0.5d);
            FDeg = (short)Conversion.Fix(F); // Int(F)
            FMin = (short)Conversion.Int(Math.Abs(F - FDeg) * 60d + 0.5d); // Int((F - FDeg) * 60 + 0.5)               'Round((F * 180 / Pi - FDeg) * 60)
            if (FMin == 60)
            {
                FMin = 0;
                FDeg = (short)(FDeg + 1);
            }

            if (Math.Sign(F) == 1)
                SignF = "+";
            if (Math.Sign(F) == -1)
                SignF = "-";
            if (Math.Sign(F) == 0)
                SignF = " ";
            AWhole = (short)Conversion.Int(AvalDeg + AvalMin / 60d + 0.5d);
            H1 = Math.Cos(AWhole * Pi / 180d) * Math.Sin(Math.Abs(FWhole) * Pi / 180d); // Abs(FWhole) was FWhole
            if (Math.Abs(H1) >= 1d)
                H = Math.Sign(H1) * Pi / 2d;
            else
                H = Math.Atan(H1 / Math.Sqrt(-H1 * H1 + 1d)); // in radians
            if (Math.Sign(F) == -1)
                H = -H;
            HDeg = (short)Conversion.Fix(H * 180d / Pi);
            HMin = (short)Conversion.Int((H * 180d / Pi - HDeg) * 60d + 0.5d);
            if (HMin == 60)
            {
                HMin = 0;
                HDeg = (short)(HDeg + 1);
            }

            Z4 = Math.Cos(FWhole * Pi / 180d) / Math.Cos(H); // 76 with this line
            if (Math.Abs(Z4) >= 1d)
                Z2 = 0d;
            else
                Z2 = Math.Atan(Z4 / Math.Sqrt(-Z4 * Z4 + 1d)); // in radians   arcsine
            if (Math.Sign(F) == -1)
                Z2 = Pi - Z2; // THIS IS FOR WHEN Z2>90 DEGREES - TABLE DOES NOT SHOW Z2>90 - use supplement, but use original to get corr2
            Z2Display1 = (float)(Conversion.Int(Z2 * 180d / Pi * 10d + 0.5d) / 10d);
            Z2Display2 = (float)Conversion.Int(Z2Display1 + 0.5d); // added in V5.1.5 to fix rounding
            P1 = Math.Abs(Math.Cos(AWhole * Pi / 180d) * Math.Sin(Z2));
            if (Math.Abs(P1) >= 1d)
                P = Math.Sign(P1) * Pi / 2d;
            else
                P = Math.Atan(P1 / Math.Sqrt(-P1 * P1 + 1d)); // in radians
            PDeg = (short)Conversion.Int(P * 180d / Pi + 0.5d);
            if (PDeg > 80)
                P = 80d * Pi / 180d; // If PDeg > 80 Then PDeg = 80
            if (Math.Abs(Z2Display2) < 10f)
                Z2 = 10d * Pi / 180d; // If Z2Display < 10 Then Z2Display = 10
            if (F > 90d)
                SignZ2 = "-";
            else
                SignZ2 = "+";
            if (F - FWhole >= 0d)
                Corr1 = FMin * Math.Sin(PDeg * Pi / 180d);
            else
                Corr1 = (60 - FMin) * Math.Sin(PDeg * Pi / 180d);
            if (H < 0d) // was HoinMinutes < 0
            {
                if (Math.Abs(F - FWhole) >= 0d)
                    Corr1 = Math.Sign(F) * FMin * Math.Sin(PDeg * Pi / 180d);
                else
                    Corr1 = Math.Sign(F) * (60 - FMin) * Math.Sin(PDeg * Pi / 180d);
            }

            Corr1 = Conversion.Int(Corr1 + 0.50000000000001d); // Why isn't 0.5 enough?
            if (optNATable.Checked & PDeg == 30 & FMin % 2 != 0)
                Corr1 = Corr1 - 1d; // F is odd
            if (F < 90d & FMin > 29 | F > 90d & FMin < 30)
                Corr1 = -Corr1;
            if (Math.Sign(Corr1) == 1)
                SignCorr1 = "+";
            if (Math.Sign(Corr1) == -1)
                SignCorr1 = "-";
            if (Math.Sign(Corr1) == 0)
                SignCorr1 = " ";
            if (Math.Abs(Aval * 180d / Pi) - Math.Abs(AWhole) >= 0d)
                Corr2 = AvalMin * Math.Cos(Z2Display2 * Pi / 180d);
            else
                Corr2 = (60 - AvalMin) * Math.Cos(Z2Display2 * Pi / 180d); // Added in V5.4.0
            if (AvalMin == 0)
                Corr2 = 0d;
            Corr2 = Conversion.Int(Corr2 + 0.50000000000001d); // Why isn't 0.5 enough?
            if (optNATable.Checked & Conversion.Int(Math.Abs(Z2Display2) + 0.5d) == 60d & AvalMin % 2 != 0)
                Corr2 = Corr2 - 1d; // AvalMin is odd
            if (AvalMin < 30)
                Corr2 = -Corr2;
            if (Math.Sign(Corr2) == 1)
                SignCorr2 = "+";
            if (Math.Sign(Corr2) == -1)
                SignCorr2 = "-";
            if (Math.Sign(Corr2) == 0)
                SignCorr2 = " ";
            Ztot = Z1display + Z2Display1;
            ZtotDisplay = (float)(Conversion.Int(Ztot * 10d + 0.5d) / 10d);
            if (cboL.Text == "N" & LHA >= 180d)
                ZN = ZtotDisplay;
            if (cboL.Text == "N" & LHA < 180d)
                ZN = 360f - ZtotDisplay;
            if (cboL.Text == "S" & LHA >= 180d)
                ZN = 180f - ZtotDisplay;
            if (cboL.Text == "S" & LHA < 180d)
                ZN = 180f + ZtotDisplay;
            if (ZN < 0d)
                ZN = ZN + 360d;
            if (ZN >= 360d)
                ZN = ZN - 360d;
            ZN = Conversion.Int(ZN + 0.5d); // added in V4.0.0
            Htot = HDeg + (HMin + Corr1 + Corr2) / 60d; // degrees
            sgnTotHc = (short)Math.Sign(Htot);
            HtotDeg = (short)Conversion.Int(Htot);
            HtotMin = (short)((Htot - HtotDeg) * 60d);
            if (HtotMin == 60)
            {
                HtotMin = 0;
                HtotDeg = (short)(HtotDeg + 1);
            }

            HoMin = Conversion.Int(HoMin + 0.5d);
            A = HtotDeg * 60 + HtotMin - (HoDeg * 60 + HoMin);
            return;
        }

        public void DisplayNASR()
        {
            cmdSave.Visible = false;
            cmdFix.Visible = false;
            cmdFix.Enabled = false;
            cmdFix.Text = "Establish Fix";
            frame211.Visible = false;
            frame214.Visible = false;
            Label9.Visible = false;
            frameS.Visible = false;
            GroupBoxPrecision.Visible = false;      // V5.6.1
            chkInterpolateB.Visible = false;
            SRHdrTxtBx.Clear();
            SRHdrTxtBx.Visible = true;
            SRHdrTxtBx.BringToFront();
            SRLgTxtBx.Clear();
            SRLgTxtBx.Visible = false;
            SRLgTxtBx.SendToBack();
            SRLeftTxtBx.Clear();
            SRLeftTxtBx.Visible = true;
            SRLeftTxtBx.BringToFront();
            SRRightTxtBx.Clear();
            SRRightTxtBx.Visible = true;
            SRRightTxtBx.BringToFront();
            NASRAsmTxtBx.Clear();
            NASRAsmTxtBx.Visible = true;
            NASRAsmTxtBx.BringToFront();
            NASRAFTxtBx.Clear();
            NASRAFTxtBx.Visible = true;
            NASRAFTxtBx.BringToFront();
            DCorrTxtBx.Clear();
            DCorrTxtBx.Visible = false;
            DCorrTxtBx.SendToBack();
            WeemsPVTxtBx.Clear();            // V5.6.1
            WeemsPVTxtBx.Visible = false;    // V5.6.1
            WeemsPVTxtBx.SendToBack();   // V5.6.1
            frameNASRUsing.Visible = true;
            frameNASRUsing.BringToFront();
            var argTB = SRHdrTxtBx;
            AlignCenterRTB(ref argTB);
            SRHdrTxtBx = argTB;
            SRHdrTxtBx.AppendText("INTERCEPT and AZIMUTH by the NAUTICAL ALMANAC SIGHT REDUCTION TABLES");

            // format left side text box
            var argTB1 = NASRAsmTxtBx;
            AlignCenterRTB(ref argTB1);
            NASRAsmTxtBx = argTB1;
            SRLeftTxtBx.AppendText("Calc of Asm Lo & Asm LHA" + Strings.Space(20) + Environment.NewLine);
            SRLeftTxtBx.AppendText("   Tot GHA" + Strings.Space(7 - GHAAsmDeg.ToString().Length) + Strings.Format(GHAAsmDeg, "0") + '°' + Strings.Format(GHAAsmMin, "00") + "'" + Environment.NewLine);
            SRLeftTxtBx.AppendText("   Asm Lo (");
            if (AsmLo == 0d)
            {
                SignA3 = " ";
                SRLeftTxtBx.AppendText(CommonGlobals.g_StrSpace);
            }

            if (Math.Sign(AsmLo) == 1)
            {
                SRLeftTxtBx.AppendText("-");
                SignA3 = CommonGlobals.g_LongW;
            }

            if (Math.Sign(AsmLo) == -1)
            {
                SRLeftTxtBx.AppendText("+");
                SignA3 = CommonGlobals.g_LongE;
            }

            if (Math.Sign(AsmLo) == 0)
            {
                SRLeftTxtBx.AppendText(CommonGlobals.g_StrSpace);
                SignA3 = " ";
            }

            SRLeftTxtBx.AppendText(")" + Strings.Space(4 - AsmLoDeg.ToString().Length) + Strings.Format(AsmLoDeg, "0") + '°' + Strings.Format(AsmLoMin, "00") + "'" + SignA3);
            SRLeftTxtBx.AppendText(Environment.NewLine);
            SRLeftTxtBx.AppendText("   Asm LHA" + Strings.Space(7 - AsmLHA.ToString().Length) + Strings.Format(AsmLHA, "0") + '°' + Environment.NewLine);

            // format right side text box
            NASRAsmTxtBx.AppendText("Asm L " + Strings.Format(Math.Abs(AsmL), "0") + '°');
            if (AsmL == 0d)
            {
                NASRAsmTxtBx.AppendText(" " + "    Asm LHA " + Strings.Format(AsmLHA, "0") + '°');
            }
            else
            {
                NASRAsmTxtBx.AppendText(cboL.Text + "    Asm LHA " + Strings.Format(AsmLHA, "0") + '°');
            }
            // newline 2 times to space past the NASR Asm text box
            SRRightTxtBx.AppendText(Environment.NewLine);
            SRRightTxtBx.AppendText(Environment.NewLine);
            // now start writing first report text lines to right side text box
            LengthZ1Display = (short)Math.Abs(Z1display).ToString().Length;
            if (Math.Abs(Z1display) - Conversion.Int(Math.Abs(Z1display)) == 0f)
            {
                LengthZ1Display = (short)(LengthZ1Display + 2);
            }

            SRRightTxtBx.AppendText(Strings.Space(6) + "A " + Strings.Space(4 - AvalDeg.ToString().Length) + Strings.Format(AvalDeg, "0") + '°' + Strings.Format(AvalMin, "00") + "'" + Constants.vbTab + Constants.vbTab + "  B (" + SignB + ")" + Strings.Space(4 - BDeg.ToString().Length) + Strings.Format(Math.Abs(BDeg), "0") + '°' + Strings.Format(BMin, "00") + "'" + Constants.vbTab + Constants.vbTab + "Z1 (" + SignZ1 + ")" + Strings.Space(5 - LengthZ1Display) + Strings.Format(Math.Abs(Z1display), "0.0") + '°');
            SRRightTxtBx.AppendText(Environment.NewLine);
            SRRightTxtBx.AppendText(Constants.vbTab + Constants.vbTab + Constants.vbTab + Constants.vbTab + "Dec (" + SignDE + ")" + Strings.Space(4 - DecDegrees.ToString().Length) + Strings.Format(DecDegrees, "0") + '°' + Strings.Format(DecMinDisplay, "00") + "'" + cboDec.Text);
            SRRightTxtBx.AppendText(Environment.NewLine);
            SRRightTxtBx.AppendText(Constants.vbTab + Constants.vbTab + Constants.vbTab + Constants.vbTab + "  F (" + SignF + ")" + Strings.Space(4 - FDeg.ToString().Length) + Strings.Format(Math.Abs(FDeg), "0") + '°' + Strings.Format(FMin, "00") + "'");
            SRRightTxtBx.AppendText(Environment.NewLine);
            SRRightTxtBx.AppendText(Environment.NewLine);
            SRRightTxtBx.AppendText(Environment.NewLine);
            var argTB2 = NASRAFTxtBx;
            AlignCenterRTB(ref argTB2);
            NASRAFTxtBx = argTB2;
            NASRAFTxtBx.AppendText("A " + Strings.Format(Math.Abs(AWhole), "0") + '°' + Constants.vbTab + Constants.vbTab + "F " + Strings.Format(Math.Abs(FWhole), "0") + '°'); // Abs(FWhole) was FWhole
            LengthZ2Display = (short)Math.Abs(Z2Display1).ToString().Length;
            if (Math.Abs(Z2Display1) - Conversion.Int(Math.Abs(Z2Display1)) == 0f)
            {
                LengthZ2Display = (short)(LengthZ2Display + 2);
            }

            SRRightTxtBx.AppendText(Strings.Space(6) + "H  ");
            if (H < 0d)
                SRRightTxtBx.AppendText("    -");
            SRRightTxtBx.AppendText(Strings.Space(4 - Math.Abs(HDeg).ToString().Length) + Strings.Format(Math.Abs(HDeg), "0") + '°' + Strings.Format(Math.Abs(HMin), "00") + "'" + Constants.vbTab + Constants.vbTab + "P " + Strings.Format(PDeg, "0") + '°' + Strings.Space(10) + "Z2 (" + SignZ2 + ")" + Strings.Space(7 - LengthZ2Display) + Strings.Format(Math.Abs(Z2Display1), "0.0") + '°');
            SRRightTxtBx.AppendText(Environment.NewLine);
            i = (short)PDeg.ToString().Length;
            if (PDeg < 10)
            {
                i = 3;
            }

            SRRightTxtBx.AppendText(Strings.Space(6) + "corr 1 (" + SignCorr1 + ")" + Strings.Space(2) + Strings.Format(Math.Abs(Corr1), "00") + "'" + Strings.Space(5) + "(F' " + Strings.Format(FMin, "00") + ", Pº" + Strings.Space(4 - i) + Strings.Format(PDeg, "00") + ")");
            if (H < 0d)
            {
                SRRightTxtBx.AppendText(Constants.vbTab + Constants.vbTab + "(supplement of " + Strings.Format(180f - Z2Display1, "0.0") + '°' + ")");
            } // was HoinMinutes < 0

            SRRightTxtBx.AppendText(Environment.NewLine);
            SRRightTxtBx.AppendText(Strings.Space(6) + "corr 2 (" + SignCorr2 + ")" + Strings.Space(2) + Strings.Format(Math.Abs(Corr2), "00") + "'" + Strings.Space(5) + "(A' " + Strings.Format(AvalMin, "00") + ", Z2º" + Strings.Space(4 - Conversion.Int(Z2Display2).ToString().Length) + Strings.Format(Conversion.Int(Math.Abs(Z2Display2)), "0") + ")");
            // added ABS to Z2Display after Healy tests
            SRRightTxtBx.AppendText(Environment.NewLine);
            LengthZtotDisplay = (short)Math.Abs(ZtotDisplay).ToString().Length;
            if (Math.Abs(ZtotDisplay) - Conversion.Int(Math.Abs(ZtotDisplay)) == 0f)
                LengthZtotDisplay = (short)(LengthZtotDisplay + 2);
            SRRightTxtBx.AppendText(Strings.Space(6) + "Hc");
            if (sgnTotHc == -1)
                SRRightTxtBx.AppendText("     -");
            SRRightTxtBx.AppendText(Strings.Space(4 - Math.Abs(HtotDeg).ToString().Length) + Strings.Format(Math.Abs(HtotDeg), "0") + '°' + Strings.Format(Math.Abs(HtotMin), "00") + "'");

            // If H < 0 Then Print "(Change sign to minus)";     'was HoinMinutes < 0
            SRRightTxtBx.AppendText(Constants.vbTab + Constants.vbTab + Constants.vbTab + "Z   " + cboL.Text + Strings.Space(6 - LengthZtotDisplay) + Strings.Format(Math.Abs(ZtotDisplay), "0.0") + '°');
            if (LHA <= 180d)
                SRRightTxtBx.AppendText(" W");
            if (LHA > 180d)
                SRRightTxtBx.AppendText(" E");
            SRRightTxtBx.AppendText(Environment.NewLine);
            SRRightTxtBx.AppendText(Strings.Space(6) + "Ho ");
            if (HoinMinutes < 0d)
            {
                SRRightTxtBx.AppendText("    -");
            }
            else
            {
                SRRightTxtBx.AppendText("     ");
            }

            SRRightTxtBx.AppendText(Strings.Space(4 - HoDeg.ToString().Length) + Strings.Format(HoDeg, "0") + '°' + Strings.Format(Math.Abs(HoMin), "00") + "'");
            SRRightTxtBx.AppendText(Environment.NewLine);
            SRRightTxtBx.AppendText(Strings.Space(6) + "a" + Strings.Space(12 - Conversion.Int(Math.Abs(A)).ToString().Length) + Conversion.Int(Math.Abs(A) + 0.5d).ToString() + "nm ");
            PlotOut.PlotIntercept = Conversion.Int(Math.Abs(A) + 0.5d).ToString() + "nm ";
            if (A < 0d)
            {
                SRRightTxtBx.AppendText("T  Ho > Hc....Toward");
                PlotOut.PlotIntercept += " Toward";
            }

            if (A > 0d)
            {
                SRRightTxtBx.AppendText("A  Hc > Ho....Away  ");
                PlotOut.PlotIntercept += " Away";
            }

            SRRightTxtBx.AppendText(Strings.Space(8) + "Zn " + Strings.Format(ZN, "000") + '°');
            SRRightTxtBx.AppendText(Environment.NewLine);
            PlotOut.PlotAz = Strings.Format(ZN, "000") + '°';
            SRRightTxtBx.AppendText(Strings.Space(6) + "AP/EP L " + Strings.Format(APEstLDeg, "0") + '°' + Strings.Format(APEstLMin, "00.0") + "'");
            if (APEstL > 0d)
                SRRightTxtBx.AppendText(CommonGlobals.g_LatN);
            if (APEstL == 0d)
                SRRightTxtBx.AppendText(CommonGlobals.g_StrSpace);
            if (APEstL < 0d)
                SRRightTxtBx.AppendText(CommonGlobals.g_LatS);
            SRRightTxtBx.AppendText("   AP/EP Lo " + Strings.Format(APEstLoDeg, "0") + '°' + Strings.Format(APEstLoMin, "00.0") + "'");
            if (APEstLo > 0d)
                SRRightTxtBx.AppendText(CommonGlobals.g_LongW);
            if (APEstLo == 0d)
                SRRightTxtBx.AppendText(CommonGlobals.g_StrSpace);
            if (APEstLo < 0d)
                SRRightTxtBx.AppendText(CommonGlobals.g_LongE);
            SRRightTxtBx.AppendText(Environment.NewLine);
            SRRightTxtBx.AppendText(Strings.Space(6) + "DR-LOP Distance " + Strings.Format(Math.Abs(KPLOPDist), "0.0") + " nm ");
            if (KPLOPDist < 0d)
                SRRightTxtBx.AppendText("T");
            if (KPLOPDist > 0d)
                SRRightTxtBx.AppendText("A");
            if (KPLOPDist == 0d)
                SRRightTxtBx.AppendText(CommonGlobals.g_StrSpace);
            SRRightTxtBx.AppendText(Environment.NewLine);
            SRRightTxtBx.AppendText(Strings.Space(6) + "   EP L " + Strings.Format(EstLDeg, "0") + '°' + Strings.Format(EstLMin, "00.0") + "'");
            if (EstL >= 0d)
            {
                SRRightTxtBx.AppendText(" N ");
            }
            else
            {
                SRRightTxtBx.AppendText(" S ");
            }

            SRRightTxtBx.AppendText("      EP Lo " + Strings.Format(EstLoDeg, "0") + '°' + Strings.Format(EstLoMin, "00.0") + "'");
            if (EstLo >= 0d)
            {
                SRRightTxtBx.AppendText(" W ");
            }
            else
            {
                SRRightTxtBx.AppendText(" E ");
            }

            SRRightTxtBx.Refresh();
            SRLeftTxtBx.Refresh();
            SRHdrTxtBx.Refresh();
            NASRAsmTxtBx.Refresh();
            NASRAFTxtBx.Refresh();
        }

        public void APEPNASR()
        {
            APEstL = AsmL - A / 60d * Math.Cos(ZN * Pi / 180d); // Changed in V4.0.0
            APEstLo = AsmLo + A / 60d * Math.Sin(ZN * Pi / 180d) / Math.Cos(AsmL * Pi / 180d); // Changed in V4.0.0
            if (Math.Abs(APEstLo) > 180d)
            {
                APEstLo = -Math.Sign(APEstLo) * (360d - Math.Abs(APEstLo));
            }

            APEstLDeg = Conversion.Int(Math.Abs(APEstL));
            APEstLMin = (Math.Abs(APEstL) - APEstLDeg) * 60d;
            if (Conversion.Int(APEstLMin) == 60d)
            {
                APEstLMin = 0d;
                APEstLDeg = APEstLDeg + 1d;
            }

            APEstLoDeg = Conversion.Int(Math.Abs(APEstLo));
            APEstLoMin = (Math.Abs(APEstLo) - APEstLoDeg) * 60d;
            if (Conversion.Int(APEstLoMin) == 60d)
            {
                APEstLoMin = 0d;
                APEstLoDeg = APEstLoDeg + 1d;
            }

            APEstLoDeg = Math.Abs(APEstLoDeg);
            return;
        }

        public void AssignPlotPosition()
        {
            PlotOut.PlotSLEP = "EP L " + Strings.Format(EstLDeg, "0") + '°' + Strings.Format(EstLMin, "00.0") + "' ";
            if (APEstL > 0d)
            {
                SRRightTxtBx.AppendText(CommonGlobals.g_LatN);
                PlotOut.PlotSLEP += CommonGlobals.g_LatN;
                PlotOut.PlotLatNS = CommonGlobals.g_LatN;
            }

            if (APEstL == 0d)
            {
                SRRightTxtBx.AppendText(CommonGlobals.g_StrSpace);
                PlotOut.PlotSLEP += CommonGlobals.g_LatN;
                PlotOut.PlotLatNS = CommonGlobals.g_LatN;
            }

            if (APEstL < 0d)
            {
                SRRightTxtBx.AppendText(CommonGlobals.g_LatS);
                PlotOut.PlotSLEP += CommonGlobals.g_LatS;
                PlotOut.PlotLatNS = CommonGlobals.g_LatS;
            }

            PlotOut.PlotSLEP += " EP Lo " + Strings.Format(EstLoDeg, "0") + '°' + Strings.Format(EstLoMin, "00.0") + "'";
            if (APEstLo > 0d)
            {
                SRRightTxtBx.AppendText(CommonGlobals.g_LongW);
                PlotOut.PlotSLEP += CommonGlobals.g_LongW;
                PlotOut.PlotLongEW = CommonGlobals.g_LongW;
            }

            if (APEstLo == 0d)
            {
                SRRightTxtBx.AppendText(CommonGlobals.g_StrSpace);
                PlotOut.PlotSLEP += CommonGlobals.g_LongW;
                PlotOut.PlotLongEW = CommonGlobals.g_LongW;
            }

            if (APEstLo < 0d)
            {
                SRRightTxtBx.AppendText(CommonGlobals.g_LongE);
                PlotOut.PlotSLEP += CommonGlobals.g_LongE;
                PlotOut.PlotLongEW = CommonGlobals.g_LongE;
            }

            return;
        }

        public void KPLOPNASR()
        {
            if (cboLo.Text == "E")
                AsmLo = -AsmLo;
            DL = (float)(Math.Abs(L - AsmL) * 60d);
            DLo = (float)(Math.Abs(Lo - AsmLo) * Math.Cos(L * Pi / 180d) * 60d);
            VL = (float)Math.Abs(DL * Math.Cos(ZN * Pi / 180d));
            VLo = (float)Math.Abs(DLo * Math.Sin(ZN * Pi / 180d));
            if ((ZN > 270d & ZN <= 360d | ZN >= 0d & ZN < 90d) & L < AsmL)
                VL = -VL; // Zn north and KP south of AP
            if (ZN >= 90d & ZN < 270d & L >= AsmL)
                VL = -VL; // Zn south and KP north of AP
            if (ZN >= 0d & ZN < 180d & Lo >= AsmLo)
                VLo = -VLo; // Zn east and KP west of AP
            if (ZN >= 180d & ZN < 360d & Lo < AsmLo)
                VLo = -VLo; // Zn west and KP east of AP
            Hk = (float)(Htot * 60d + VL + VLo);
            KPLOPDist = Hk - (HoDeg * 60 + HoMin);
            // KPLOPDist = Int(KPLOPDist * 10 + 0.5) / 10
        }

        public void EPNASR()
        {
            if (cboLo.Text == "E")
                AsmLo = -AsmLo;
            EstL = L - KPLOPDist / 60d * Math.Cos(ZN * Pi / 180d);
            EstLo = Lo + KPLOPDist / 60d * Math.Sin(ZN * Pi / 180d) / Math.Cos(L * Pi / 180d);
            if (Math.Abs(EstLo) > 180d)
                EstLo = -Math.Sign(EstLo) * (360d - Math.Abs(EstLo));
            EstLDeg = (short)Conversion.Int(Math.Abs(EstL));
            EstLMin = (Math.Abs(EstL) - EstLDeg) * 60d;
            if (Conversion.Int(EstLMin * 10d + 0.5d) / 10d == 60d)
            {
                EstLMin = 0d;
                EstLDeg = (short)(EstLDeg + 1);
            }

            EstLoDeg = (short)Conversion.Int(Math.Abs(EstLo));
            EstLoMin = (Math.Abs(EstLo) - EstLoDeg) * 60d;
            if (Conversion.Int(EstLoMin * 10d + 0.5d) / 10d == 60d)
            {
                EstLoMin = 0d;
                EstLoDeg = (short)(EstLoDeg + 1);
            }

            EstLoDeg = Math.Abs(EstLoDeg);
        }

        public void cmdSave_Click(object eventSender, EventArgs eventArgs)
        {
            II = (short)(II + 1);
            IU = (short)(IU + 1);
            if (IU > 12)
            {
                ErrorMsgBox("Too many sights saved - the limit is 12 saved sights");
                return;
            }

            if (InvokedbySightLog == true)
            {
                FBody[II] = cboBody.Text.ToString().Trim();
                if (cboBody.Text.ToString().Trim() == "Sun" | cboBody.Text.ToString().Trim() == "Moon")
                {
                    FBody[II] += " " + cbLimb.Text.ToString().Trim();
                }
            }
            else
            {
                FBody[II] = " AltSRBody" + txtSightNum.ToString("##0");
            }

            if (InvokedbySightLog == true)
            {
                FBody[II] = cboBody.Text.ToString().Trim();
                if (cboBody.Text.ToString().Trim() == "Sun" | cboBody.Text.ToString().Trim() == "Moon")
                {
                    FBody[II] += " " + cbLimb.Text.ToString().Trim();
                }
            }
            else
            {
                FBody[II] = " AltSRBody" + txtSightNum.ToString("##0");
            }

            if (IU > 1)
            {
                cmdFix.Visible = true;
                cmdFix.Enabled = true;
                cmdFix.Text = "Establish Fix for " + IU.ToString("#0") + " sights";
            }

            FZH[II] = DTSight.Value.Hour;    // VB.Left(txtTime.Text, 2)
            FZM[II] = DTSight.Value.Minute;      // Mid(txtTime.Text, 3, 2) ': FZS(II) = Right(txtTime.Text, 2)
            FZS[II] = DTSight.Value.Second;
            FDTSight[II] = DTSight.Value;
            // FZU(II) = DTSight.Value.ToUniversalTime.Subtract(New DateTime(1970, 1, 1, 0, 0, 0))
            FMI[II] = Math.Sign(A) * Conversion.Int((Math.Abs(A) * 10d + 0.5d) / 10d); // changed in V4.0.0
            FD[II] = "T";
            if (A > 0d)
                FD[II] = "A";
            if (A == 0d)
                FD[II] = " ";
            FZN[II] = Conversion.Int(ZN + 0.5d); // changed in V4.0.0
            FL[II] = L;
            FLD[II] = txtLDeg.Text;
            FLM[II] = txtLMin.Text;
            FLA[II] = cboL.Items[cboL.SelectedIndex].ToString();
            FLo[II] = Lo.ToString();
            FMD[II] = Conversions.ToDouble(txtLoDeg.Text);
            FMM[II] = Conversions.ToDouble(txtLoMin.Text);
            FM[II] = cboLo.Items[cboLo.SelectedIndex].ToString();
            FGHA[II] = GHA;      // added in V5.6.1
            FDec[II] = Dec;      // added in V5.6.1
            FHo[II] = Ho;        // added in V5.6.1
            FEP[II] = PlotOut.PlotSLEP;
            SendMsgBx("Sight reduction data saved - Enter new sight data", MessageBoxIcon.Information);
            cmdSave.Visible = false;
            return;
        }

        public void cmdFix_Click(object eventSender, EventArgs eventArgs)
        {

            // Form4.IUPass = IU
            My.MyProject.Forms.FixDG.IUPass = IU;
            int temp = 0;
            for (temp = 1; temp <= 12; temp++)
                // Form4.FixDataArray(temp) = New Form4.SFixData With {.SFZH = FZH(temp), .SFZM = FZM(temp), .SFZS = FZS(temp),
                // .SFZN = FZN(temp), .SFMI = FMI(temp), .SFL = FL(temp), .SFLo = FLo(temp), .SBF = "AltSR" & temp.ToString, 'FL(temp),
                // .SFLD = FLD(temp), .SFLM = FLM(temp), .sFD = FD(temp), .SFMD = FMD(temp), .SFMM = FMM(temp),
                // .sFLA = FLA(temp), .SFM = FM(temp), .SFGHA = FGHA(temp), .SFDec = FDec(temp), .SFHo = FHo(temp)}

                My.MyProject.Forms.FixDG.FixDataArray[temp] = new FixDG.SFixData()
                {
                    SFZH = FZH[temp],
                    SFZM = FZM[temp],
                    SFZS = FZS[temp],
                    SFZN = FZN[temp],
                    SFMI = FMI[temp],
                    SFL = FL[temp],
                    SFLo = Conversions.ToDouble(FLo[temp]),
                    SBF = FBody[temp],   // "AltSR" & temp.ToString, 'FL(temp),
                    SFLD = FLD[temp],
                    SFLM = FLM[temp],
                    sFD = FD[temp],
                    SFMD = FMD[temp],
                    SFMM = FMM[temp],
                    sFLA = FLA[temp],
                    SFM = FM[temp],
                    SFGHA = FGHA[temp],
                    SFDec = FDec[temp],
                    SFHo = FHo[temp],
                    SDTSight = FDTSight[temp],
                    SEP = FEP[temp]
                };
            // Form4.Show()
            My.MyProject.Forms.FixDG.txtUserInfo.Text = txtUserInfo.Text;
            My.MyProject.Forms.FixDG.Show();
            My.MyProject.Forms.FixDG.SetDesktopLocation(5, 5); // 
            return;
        }

        public void HO249()
        {
            LHA = GHA - Lo;
            if (LHA >= 360d)
                LHA = LHA - 360d;
            if (LHA < 0d)
                LHA = LHA + 360d;
            AsmLHA = Conversion.Int(LHA + 0.5d);
            if (AsmLHA == 360d)
                AsmLHA = 0d;
            GHAAsmDeg = (short)Conversion.Val(txtGHADeg.Text);
            GHAAsmMin = (short)Conversion.Int(Conversion.Val(txtGHAMin.Text) + 0.5d);
            GHAAsm = GHAAsmDeg + GHAAsmMin / 60d; // in degrees
            AsmLo = GHAAsm - AsmLHA;
            if (Math.Abs(AsmLo) < 180d)
                AsmLo = 360d - Math.Abs(AsmLo);
            if (Math.Abs(AsmLo) >= 180d & Lo >= 0d)
                AsmLo = 360d - Math.Abs(AsmLo);
            if (Math.Abs(AsmLo) >= 180d & Lo < 0d)
                AsmLo = -(360d - Math.Abs(AsmLo));
            AsmLoDeg = (short)Conversion.Int(Math.Abs(AsmLo));
            if (AsmLo > 0d | txtLoDeg.Text == "180")
                AsmLoMin = (float)Conversion.Val(txtGHAMin.Text);
            else
                AsmLoMin = (float)(60d - Conversion.Val(txtGHAMin.Text));
            if (AsmLoMin == 60f)
                AsmLoMin = 0f;
            AsmL = Conversion.Int(L + 0.5d);
            AsmDec = (float)Conversion.Int(Math.Abs(Dec));
            DecIncr = (float)Conversion.Int(Conversion.Val(txtDecMin.Text) + 0.5d);
            if (cboDec.Text == "S" & cboL.Text == "N" | cboDec.Text == "N" & cboL.Text == "S")
                AsmDec = -AsmDec; // : SignDE$ = "-"
            Hc = Math.Cos(AsmLHA * Pi / 180d) * Math.Cos(Math.Abs(AsmL) * Pi / 180d) * Math.Cos(AsmDec * Pi / 180d) + Math.Sin(Math.Abs(AsmL) * Pi / 180d) * Math.Sin(AsmDec * Pi / 180d);
            if (Math.Abs(Hc) >= 1d)
                Hc = Math.Sign(Hc) * Pi / 2d;
            else
                Hc = Math.Atan(Hc / Math.Sqrt(-Hc * Hc + 1d)); // arcsine
            Hc = Hc * 180d / Pi;
            sgnHc = (short)Math.Sign(Hc);
            TabHcDeg = (short)Conversion.Fix(Hc);
            TabHcMin = Hc - TabHcDeg;
            TabHcMin = Conversion.Int(60d * TabHcMin + 0.50023d); // WHY IS 0.50023 NEEDED!!!!!!!!!!!!!!! Extra problem 1 does not work without it.
            i = 1;
            if (AsmDec < 0f)
            {
                i = -1;
            }

            NextHc = Math.Cos(AsmLHA * Pi / 180d) * Math.Cos(Math.Abs(AsmL) * Pi / 180d) * Math.Cos((AsmDec + i) * Pi / 180d) + Math.Sin(Math.Abs(AsmL) * Pi / 180d) * Math.Sin((AsmDec + i) * Pi / 180d);
            if (Math.Abs(NextHc) >= 1d)
            {
                NextHc = Math.Sign(NextHc) * Pi / 2d;
            }
            else
            {
                NextHc = Math.Atan(NextHc / Math.Sqrt(-NextHc * NextHc + 1d));
            } // arcsine

            NextHc = NextHc * 180d / Pi;
            NextHcDeg = (short)Conversion.Int(NextHc);
            NextHcMin = NextHc - NextHcDeg;
            NextHcMin = Conversion.Int(60d * NextHcMin + 0.5d);
            D = (float)(60 * NextHcDeg + NextHcMin - (60 * TabHcDeg + TabHcMin));
            D = (float)(Math.Sign(D) * Conversion.Int(Math.Abs(D) + 0.5d));
            SignD = "+";
            if (Math.Sign(D) == -1)
            {
                SignD = "-";
            }

            dcorr = D * DecIncr / 60f;
            dcorr = (float)(Math.Sign(D) * Conversion.Int(Math.Abs(dcorr) + 0.5d));
            TotHc = (TabHcDeg * 60 + TabHcMin + dcorr) / 60d;
            sgnTotHc = (short)Math.Sign(TotHc);
            Signdcorr = "+";
            if (Math.Sign(dcorr) == -1)
                Signdcorr = "-";
            TotHcDeg = (short)Conversion.Fix(TotHc);
            Htot = TotHc;
            TotHcMin = TotHc - TotHcDeg;
            TotHcMin = Conversion.Int(60d * TotHcMin + 0.5d);
            if (TotHcMin == 60d)
            {
                TotHcMin = 0d;
                TotHcDeg = (short)(TotHcDeg + 1);
            }

            A = 60 * TotHcDeg + TotHcMin - (60 * HoDeg + HoMin);
            L4 = Math.Sin(AsmDec * Pi / 180d);
            L5 = Math.Sin(Math.Abs(AsmL) * Pi / 180d) * Math.Sin(Hc * Pi / 180d);
            L6 = L4 - L5;
            L7 = Math.Cos(Math.Abs(AsmL) * Pi / 180d) * Math.Cos(Hc * Pi / 180d);
            L8 = L6 / L7;
            if (Math.Abs(L8) >= 1d)
                Z = Pi;
            else
                Z = Math.Atan(-L8 / Math.Sqrt(-L8 * L8 + 1d)) + Pi / 2d; // arccosine
            Z = Z * 180d / Pi;
            Z = Conversion.Int(Z + 0.5d);
            if (cboL.Text == "N" & LHA > 180d)
                ZN = Z;
            if (cboL.Text == "N" & LHA <= 180d)
                ZN = 360d - Z;
            if (cboL.Text == "S" & LHA > 180d)
                ZN = 180d - Z;
            if (cboL.Text == "S" & LHA <= 180d)
                ZN = 180d + Z;
            ZN = Conversion.Int(ZN + 0.5d); // added in V4.0.0
        }

        public void Display249()
        {
            cmdSave.Visible = false;
            cmdFix.Visible = false; // : 
            cmdFix.Enabled = false;
            cmdFix.Text = "Establish Fix";
            // Me.Font = New Font(Me.Font, "Courier New")
            SRHdrTxtBx.Visible = true;
            SRHdrTxtBx.Clear();
            SRHdrTxtBx.BringToFront();
            SRLgTxtBx.Clear();
            SRLgTxtBx.Visible = false;
            SRLgTxtBx.SendToBack();
            SRLeftTxtBx.Clear();
            SRLeftTxtBx.Visible = true;
            SRLeftTxtBx.BringToFront();
            SRRightTxtBx.Clear();
            SRRightTxtBx.Visible = true;
            SRRightTxtBx.BringToFront();
            NASRAsmTxtBx.Clear();
            NASRAsmTxtBx.Visible = false;
            NASRAsmTxtBx.SendToBack();
            NASRAFTxtBx.Clear();
            NASRAFTxtBx.Visible = false;
            NASRAFTxtBx.SendToBack();
            DCorrTxtBx.Clear();
            DCorrTxtBx.Visible = true;
            DCorrTxtBx.BringToFront();
            WeemsPVTxtBx.Clear();            // V5.6.1
            WeemsPVTxtBx.Visible = false;    // V5.6.1
            WeemsPVTxtBx.SendToBack();   // V5.6.1
            frameNASRUsing.Visible = false;
            frame211.Visible = false;
            frame214.Visible = false;
            Label9.Visible = false;
            frameS.Visible = false;
            GroupBoxPrecision.Visible = false;      // V5.6.1
                                                    // CurrentY = 2260

            var argTB = SRHdrTxtBx;
            AlignCenterRTB(ref argTB);
            SRHdrTxtBx = argTB;
            SRHdrTxtBx.AppendText("INTERCEPT and AZIMUTH by Pub. 249 SIGHT REDUCTION TABLES");

            // format left side text box 
            SRLeftTxtBx.AppendText("Calc of Asm Lo & Asm LHA");
            SRLeftTxtBx.AppendText(Environment.NewLine);
            SRLeftTxtBx.AppendText("GHA" + Strings.Space(15 - txtGHADeg.Text.ToString().Length) + Strings.Format(Conversion.Val(txtGHADeg.Text), "##0") + '°' + Strings.Format(Conversion.Val(txtGHAMin.Text), "00.0") + "'");
            SRLeftTxtBx.AppendText(Environment.NewLine);
            SRLeftTxtBx.AppendText("Asm Lo (");
            if (AsmLo == 0d)
            {
                SignA3 = " ";
                SRLeftTxtBx.AppendText("");
            }

            if (Math.Sign(AsmLo) == 1)
            {
                SRLeftTxtBx.AppendText("-");
                SignA3 = CommonGlobals.g_LongW;
            }

            if (Math.Sign(AsmLo) == -1)
            {
                SRLeftTxtBx.AppendText("+");
                SignA3 = CommonGlobals.g_LongE;
            }

            if (Math.Sign(AsmLo) == 0)
            {
                SRLeftTxtBx.AppendText(CommonGlobals.g_StrSpace);
                SignA3 = " ";
            }

            SRLeftTxtBx.AppendText(")" + Strings.Space(8 - AsmLoDeg.ToString().Length) + Strings.Format(AsmLoDeg, "0") + '°' + Strings.Format(AsmLoMin, "00.0") + "'" + SignA3 + Environment.NewLine);
            SRLeftTxtBx.AppendText("LHA" + Strings.Space(15 - AsmLHA.ToString().Length) + Strings.Format(AsmLHA, "0") + '°' + Environment.NewLine);
            SRLeftTxtBx.AppendText("Asm L " + Strings.Space(12 - AsmL.ToString().Length) + Strings.Format(Math.Abs(AsmL), "#0") + '°');
            if (AsmL == 0d)
            {
                SRLeftTxtBx.AppendText(CommonGlobals.g_StrSpace);
            }
            else
            {
                SRLeftTxtBx.AppendText(cboL.Text);
            }

            SRLeftTxtBx.AppendText(Environment.NewLine);
            SRLeftTxtBx.AppendText("Asm Dec" + Strings.Space(11 - DecDegrees.ToString().Length) + Strings.Format(DecDegrees, "#0") + '°' + cboDec.Text + Environment.NewLine);
            SRLeftTxtBx.AppendText("Dec Incr" + Strings.Space(10 - DecIncr.ToString().Length) + Strings.Format(DecIncr, "00") + "'" + Environment.NewLine);

            // format right side text box
            SRRightTxtBx.AppendText(Strings.Space(3) + "Tab Hc  ");
            if (sgnHc == -1)
            {
                SRRightTxtBx.AppendText("-");
            }
            else
            {
                SRRightTxtBx.AppendText(CommonGlobals.g_StrSpace);
            }

            SRRightTxtBx.AppendText(Strings.Space(4 - Math.Abs(TabHcDeg).ToString().Length) + Strings.Format(Math.Abs(TabHcDeg), "0") + '°' + Strings.Format(Math.Abs(TabHcMin), "00") + "'" + Strings.Space(10) + "d (" + SignD + ") " + Strings.Format(Math.Abs(D), "00") + "'" + Strings.Space(10) + "Tab Z " + cboL.Text + Strings.Space(4 - Z.ToString().Length) + Strings.Format(Math.Abs(Z), "0") + '°');

            if (LHA <= 180d)
                SRRightTxtBx.AppendText(" W");
            if (LHA > 180d)
                SRRightTxtBx.AppendText(" E");
            SRRightTxtBx.AppendText(Environment.NewLine);
            SRRightTxtBx.AppendText(Strings.Space(3) + "d corr. (" + Signdcorr + ") " + Strings.Format(Math.Abs(dcorr), "00") + "'");
            SRRightTxtBx.AppendText(Environment.NewLine);
            SRRightTxtBx.AppendText(Strings.Space(3) + "Hc " + Strings.Space(5));
            if (sgnTotHc == -1)
            {
                SRRightTxtBx.AppendText("-");
            }
            else
            {
                SRRightTxtBx.AppendText(CommonGlobals.g_StrSpace);
            }

            SRRightTxtBx.AppendText(Strings.Space(4 - Math.Abs(TotHcDeg).ToString().Length) + Strings.Format(Math.Abs(TotHcDeg), "0") + '°' + Strings.Format(Math.Abs(TotHcMin), "00") + "'");
            SRRightTxtBx.AppendText(Environment.NewLine);
            HoMin = Conversion.Int(HoMin + 0.5d);
            SRRightTxtBx.AppendText(Strings.Space(3) + "Ho " + Strings.Space(5));
            if (HoinMinutes < 0d)
            {
                SRRightTxtBx.AppendText("-");
            }
            else
            {
                SRRightTxtBx.AppendText(CommonGlobals.g_StrSpace);
            }

            SRRightTxtBx.AppendText(Strings.Space(4 - HoDeg.ToString().Length) + Strings.Format(Math.Abs(HoDeg), "0") + '°' + Strings.Format(Math.Abs(HoMin), "00") + "'");
            SRRightTxtBx.AppendText(Environment.NewLine);
            SRRightTxtBx.AppendText(Strings.Space(4) + "a " + Strings.Space(12 - Conversion.Int(Math.Abs(A)).ToString().Length) + Conversion.Int(Math.Abs(A) + 0.5d).ToString() + "nm ");
            PlotOut.PlotIntercept = Conversion.Int(Math.Abs(A) + 0.5d).ToString() + "nm ";
            if (TotHc < Ho)
            {
                SRRightTxtBx.AppendText("T  Ho > Hc....Toward");
                PlotOut.PlotIntercept += " Toward";
            }

            if (TotHc > Ho)
            {
                SRRightTxtBx.AppendText("A  Hc > Ho....Away");
                PlotOut.PlotIntercept += " Away";
            }

            SRRightTxtBx.AppendText(Environment.NewLine);
            SRRightTxtBx.AppendText(Strings.Space(45) + "Zn  " + Strings.Format(ZN, "000") + '°');
            PlotOut.PlotAz = Strings.Format(ZN, "000") + '°';
            SRRightTxtBx.AppendText(Environment.NewLine);
            SRRightTxtBx.AppendText(Environment.NewLine);
            DCorrTxtBx.AppendText(Strings.Space(6) + "d corr. Interpolation" + Environment.NewLine);
            DCorrTxtBx.AppendText(Strings.Space(3) + "d corr. = " + DecIncr + "x " + D.ToString() + "/ 60 => " + Signdcorr + Strings.Format(Math.Abs(dcorr), "00"));
            SRRightTxtBx.AppendText(Environment.NewLine);
            SRRightTxtBx.AppendText(Environment.NewLine);
            SRRightTxtBx.AppendText(Environment.NewLine);
            SRRightTxtBx.AppendText(Strings.Space(8) + "AP/EP L " + Strings.Format(APEstLDeg, "0") + '°' + Strings.Format(APEstLMin, "00.0") + "'");
            if (APEstL > 0d)
                SRRightTxtBx.AppendText(CommonGlobals.g_LatN);
            if (APEstL == 0d)
                SRRightTxtBx.AppendText(CommonGlobals.g_StrSpace);
            if (APEstL < 0d)
                SRRightTxtBx.AppendText(CommonGlobals.g_LatS);
            SRRightTxtBx.AppendText("   AP/EP Lo " + Strings.Format(APEstLoDeg, "0") + '°' + Strings.Format(APEstLoMin, "00.0") + "'");
            if (APEstLo > 0d)
                SRRightTxtBx.AppendText(CommonGlobals.g_LongW);
            if (APEstLo == 0d)
                SRRightTxtBx.AppendText(CommonGlobals.g_StrSpace);
            if (APEstLo < 0d)
                SRRightTxtBx.AppendText(CommonGlobals.g_LongE);
            SRRightTxtBx.AppendText(Environment.NewLine);
            SRRightTxtBx.AppendText(Strings.Space(8) + "DR-LOP Distance " + Strings.Format(Math.Abs(KPLOPDist), "0.0") + " nm ");
            if (KPLOPDist < 0d)
                SRRightTxtBx.AppendText("T");
            if (KPLOPDist > 0d)
                SRRightTxtBx.AppendText("A");
            if (KPLOPDist == 0d)
                SRRightTxtBx.AppendText(CommonGlobals.g_StrSpace);
            SRRightTxtBx.AppendText(Environment.NewLine);
            SRRightTxtBx.AppendText(Strings.Space(8) + "   EP L " + Strings.Format(EstLDeg, "0") + '°' + Strings.Format(EstLMin, "00.0") + "'");
            SRRightTxtBx.AppendText("      EP Lo " + Strings.Format(EstLoDeg, "0") + '°' + Strings.Format(EstLoMin, "00.0") + "'");
            SRHdrTxtBx.Refresh();
            SRLeftTxtBx.Refresh();
            SRRightTxtBx.Refresh();
        }

        public void Weems()          // Several changes V5.6.1 and as early as V5.4.1
        {
            B3 = 0f;
            B4 = 0f;
            B5 = 0f;
            Btot = 0d;
            LHA = GHA - Lo;
            LHA = Conversion.Int(LHA + 0.5d);
            if (LHA >= 360d)
                LHA = LHA - 360d;
            if (LHA < 0d)
                LHA = LHA + 360d;
            if (LHA <= 180d)
                T = LHA; // W
            if (LHA > 180d)
                T = 360d - LHA; // E
            tDeg = (short)Conversion.Int(T + 0.5d);
            AsmLHA = Conversion.Int(LHA + 0.5d);
            if (AsmLHA == 360d)
                AsmLHA = 0d;
            GHAAsmDeg = (short)Conversion.Val(txtGHADeg.Text);
            GHAAsmMin = (short)Conversion.Int(Conversion.Val(txtGHAMin.Text) + 0.5d);
            GHAAsm = GHAAsmDeg + GHAAsmMin / 60d; // in degrees
            AsmLo = GHAAsm - AsmLHA;
            if (Math.Abs(AsmLo) < 180d)
                AsmLo = 360d - Math.Abs(AsmLo);
            if (Math.Abs(AsmLo) >= 180d & Lo >= 0d)
                AsmLo = 360d - Math.Abs(AsmLo);
            if (Math.Abs(AsmLo) >= 180d & Lo < 0d)
                AsmLo = -(360d - Math.Abs(AsmLo));
            AsmLoDeg = (short)Conversion.Int(Math.Abs(AsmLo));
            if (AsmLo > 0d | txtLoDeg.Text == "180")
                AsmLoMin = (float)Conversion.Val(txtGHAMin.Text);
            else
                AsmLoMin = (float)(60d - Conversion.Val(txtGHAMin.Text));
            if (AsmLoMin == 60f)
                AsmLoMin = 0f;
            AsmL = Conversion.Int(L + 0.5d);
            N = Math.Cos(AsmL * Pi / 180d) * Math.Sin(LHA * Pi / 180d);
            if (Math.Abs(N) >= 1d)
                N = Math.Sign(N) * Pi / 2d;
            else
                N = Math.Atan(N / Math.Sqrt(-N * N + 1d)); // arcsin
            if (N == 0d)
                N = 0.0000000001d * Pi / 180d;
            A1 = 100000d * (Math.Log(1d / Math.Cos(N)) / Math.Log(10d));
            if (T >= 21d)
                A1 = Conversion.Int(A1 + 0.65d); // UNCERTAIN ROUNDING SCHEME, SEEMS TO WORK WITH 0.65
            if (T <= 20d)
                A1 = Conversion.Int(A1 * 10d + 0.65d) / 10d;
            if (T == 0d)
                A1 = 0d; // do not want to round for 0 latitude
            Z3 = Math.Cos(AsmLHA * Pi / 180d) / Math.Cos(N); // Example b p 2-24 bottom of first column makes Z3=1 NG
            if (Math.Abs(Z3) >= 1d)
                Z1 = Math.Sign(Z3) * Pi / 2d;
            else
                Z1 = Math.Atan(Z3 / Math.Sqrt(-Z3 * Z3 + 1d)); // in radians
            B1 = Math.Cos(AsmL * Pi / 180d) * Math.Sin(Z1);
            if (Math.Abs(B1) >= 1d)
                B = Math.Sign(B1) * Pi / 2d;
            else
                B = Math.Atan(B1 / Math.Sqrt(-B1 * B1 + 1d)); // in radians
            B = B * 180d / Pi;
            BDeg = (short)Conversion.Int(Math.Abs(B));
            BMin = Conversion.Int((Math.Abs(B) - BDeg) * 60d * 10d + 0.5d) / 10d;
            if (BMin == 60d)
            {
                BMin = 0d;
                BDeg = (short)(BDeg + 1);
            }

            B = BDeg + BMin / 60d;
            if (cboDec.Text == "N" & cboL.Text == "S" | cboDec.Text == "S" & cboL.Text == "N")
                DE = -DE; // : SignDE$ = "-"
            F = B + DE; // in degrees
            Kd = 90d - F; // : KdOrig = Kd
            if (AsmL == 0d)
                k = 0d;
            KdDeg = (short)Conversion.Int(Math.Abs(Kd));
            KdMin = Conversion.Int((Math.Abs(Kd) - KdDeg) * 60d * 10d + 0.5d) / 10d; // UNCERTAIN ROUNDING SCHEME, SEEMS TO WORK WITH 0.65
            if (AsmL == 0d)
                KdMin = 0d;
            k = KdDeg + KdMin / 60d + DE;
            if (T > 90d)
            {
                k = 180d - k;
                Kd = k - DE; // Kd must be 0-90 for a legitimate sight
                if (Kd > 90d)
                    return;
                KdDeg = (short)Conversion.Int(Math.Abs(Kd));
                KdMin = Conversion.Int((Math.Abs(Kd) - KdDeg) * 60d * 10d + 0.5d) / 10d; // UNCERTAIN ROUNDING SCHEME, SEEMS TO WORK WITH 0.65
            }
            // k = Kd + DE
            KDeg = (short)Conversion.Int(Math.Abs(k));
            KMin = Conversion.Int((Math.Abs(k) - KDeg) * 60d * 10d + 0.5d) / 10d;
            if (AsmL == 0d)
                KMin = 0d;
            B = 100000d * (Math.Log(1d / Math.Cos((KdDeg + Conversion.Int(KdMin + 0.5d) / 60d) * Pi / 180d)) / Math.Log(10d)); // round to nearest minute
            if (Kd >= 10d)
                B = Conversion.Int(B + 0.5d); // SHOULD THIS BE 0.65???????????????????????????
            if (Kd < 10d)
                B = Conversion.Int(B * 10d + 0.5d) / 10d; // SHOULD THIS BE 0.65???????????????????????????
            if ((int)chkInterpolateB.CheckState == 1) // this does linear interpolation
            {
                if (Conversion.Int(KdMin + 0.5d) > KdMin)
                    B22 = 100000d * (Math.Log(1d / Math.Cos((KdDeg + Conversion.Int(KdMin - 0.5d) / 60d) * Pi / 180d)) / Math.Log(10d));
                if (Conversion.Int(KdMin + 0.5d) < KdMin)
                    B22 = 100000d * (Math.Log(1d / Math.Cos((KdDeg + Conversion.Int(KdMin + 1.5d) / 60d) * Pi / 180d)) / Math.Log(10d));
                if (Kd + 1d / 60d >= 10d)
                    B22 = Conversion.Int(B22 + 0.5d); // SHOULD THIS BE 0.65???????????????????????????
                if (Kd + 1d / 60d < 10d)
                    B22 = Conversion.Int(B22 * 10d + 0.5d) / 10d; // SHOULD THIS BE 0.65???????????????????????????
                if (B >= B22)
                    B = B22 + (KdMin - Conversion.Int(KdMin)) * Math.Abs(B - B22);
                if (B < B22)
                    B = B + (KdMin - Conversion.Int(KdMin)) * Math.Abs(B - B22);
                // B = Int(B * 10 + 0.5) / 10
            }

            if (Kd >= 10d)
                B = Conversion.Int(B + 0.5d); // SHOULD THIS BE 0.65???????????????????????????
            if (Kd < 10d)
                B = Conversion.Int(B * 10d + 0.5d) / 10d; // SHOULD THIS BE 0.65???????????????????????????
            AB = A1 + B;
            if (T <= 20d | Kd < 10d | (int)chkInterpolateB.CheckState == 1)
                AB = Conversion.Int(AB * 10d + 0.5d) / 10d;
            else
                AB = Conversion.Int(AB + 0.5d); // SHOULD THIS BE 0.65???????????????????????????
            Hc = 1d / Math.Pow(10d, AB / 100000d);
            if (Math.Abs(Hc) >= 1d)
                Hc = Math.Sign(Hc) * Pi / 2d;
            else
                Hc = Math.Atan(Hc / Math.Sqrt(-Hc * Hc + 1d)); // arcsine
            Hc = Hc * 180d / Pi;
            HcDeg = (short)Conversion.Int(Math.Abs(Hc));
            if (chkInterpolateB.CheckState == 0)
                HcMin = Conversion.Int((Math.Abs(Hc) - HcDeg) * 60d + 0.5d);
            if ((int)chkInterpolateB.CheckState == 1)
                HcMin = Conversion.Int((Math.Abs(Hc) - HcDeg) * 60d * 10d + 0.5d) / 10d;
            HcDecimal = HcDeg + HcMin / 60d;
            Htot = Hc;
            A = 60 * HcDeg + HcMin - (60 * HoDeg + HoMin);

            // For Lat and Dec same name and Dec<Lat, calculate the altitude of the body when on prime vertical
            // (Done for all, but only needed for Lat and Dec same name and Dec<Lat)
            // NO!  Only do if Lat and Dec same name and Dec<Lat or get sqrt of negative number error      
            // V5.6.2
            if ((cboL.Text ?? "") == (cboDec.Text ?? "") & DE < L)      // V5.6.2
            {
                if (L == 0d)
                    L = 0.000000000000001d;     // Added in V5.6.1 to prevent divide-by-zero error if L = 0
                Hpv = Math.Sin(DE * Pi / 180d) / Math.Sin(L * Pi / 180d);
                Hpv = Math.Atan(Hpv / Math.Sqrt(-Hpv * Hpv + 1d)); // arcsine
                Hpv = Hpv * 180d / Pi;
                HpvDeg = (short)Conversion.Int(Hpv);
                HpvMin = (Hpv - HpvDeg) * 60d;
                HpvMin = Conversion.Int(HpvMin * 10d + 0.5d) / 10d;
            }

            if ((cboL.Text ?? "") != (cboDec.Text ?? ""))
                DE = -DE;
            L4 = Math.Sin(DE * Pi / 180d);
            L5 = Math.Sin(Math.Abs(L) * Pi / 180d) * Math.Sin(Htot * Pi / 180d);
            L6 = L4 - L5;
            L7 = Math.Cos(Math.Abs(L) * Pi / 180d) * Math.Cos(Htot * Pi / 180d);
            L8 = L6 / L7;
            if (Math.Abs(L8) >= 1d)
                ZLoc = Pi;
            else
                ZLoc = Math.Atan(-L8 / Math.Sqrt(-L8 * L8 + 1d)) + Pi / 2d;
            ZLoc = ZLoc * 180d / Pi;
            if (cboL.Text == "N" & LHA > 180d)
                ZnLoC = ZLoc;
            if (cboL.Text == "N" & LHA <= 180d)
                ZnLoC = 360d - ZLoc;
            if (cboL.Text == "S" & LHA > 180d)
                ZnLoC = 180d - ZLoc;
            if (cboL.Text == "S" & LHA <= 180d)
                ZnLoC = 180d + ZLoc;
            ZnLoC = Conversion.Int(ZnLoC * 10d + 0.5d) / 10d;
            ZnLoCDeg = (short)Conversion.Int(ZnLoC);
            ZnLoCMin = (ZnLoC - ZnLoCDeg) * 60d;
            ZnLoCMin = Conversion.Int(ZnLoCMin + 0.5d);
            if (ZnLoCMin == 60d)
            {
                ZnLoCMin = 0d;
                ZnLoCDeg = (short)(ZnLoCDeg + 1);
            }

            // Z by table
            if (T == 0d)
                return;
            B2 = (float)(100000d * (Math.Log(1d / Math.Sin(T * Pi / 180d)) / Math.Log(10d)));
            B3 = (float)Conversion.Int(B2 + 0.5d);
            B2 = (float)(100000d * (Math.Log(1d / Math.Cos((DecDegrees + Conversion.Int(DecMinutes + 0.5d) / 60d) * Pi / 180d)) / Math.Log(10d)));
            B4 = (float)Conversion.Int(B2 + 0.5d);
            B2 = (float)(100000d * (Math.Log(1d / Math.Cos((HcDeg + Conversion.Int(HcMin + 0.5d) / 60d) * Pi / 180d)) / Math.Log(10d)));
            B5 = (float)Conversion.Int(B2 + 0.5d);
            Btot = B3 + B4 - B5;
            Btot = Conversion.Int(Btot + 0.5d);
            Z4 = 1d / Math.Pow(10d, Btot / 100000d); // Z4 is Z using tables
            if (Math.Abs(Z4) >= 1d)
                Z4 = Math.Sign(Z4) * Pi / 2d;
            else
                Z4 = Math.Atan(Z4 / Math.Sqrt(-Z4 * Z4 + 1d)); // arcsine
            Z4 = Z4 * 180d / Pi;
            Z4Deg = (short)Conversion.Int(Math.Abs(Z4));
            Z4Min = Conversion.Int((Math.Abs(Z4) - Z4Deg) * 60d + 0.5d);
            Z4 = Conversion.Int(Z4 * 10d + 0.5d) / 10d;

            // If DE >= L And LHA > 180 Then ZnT = Z4
            // If DE >= L And LHA <= 180 Then ZnT = 360 - Z4
            // If DE < L And LHA > 180 Then ZnT = 180 - Z4
            // If DE < L And LHA <= 180 Then ZnT = 180 + Z4
            // ZnTDeg = Int(System.Math.Abs(ZnT))
            // ZnTMin = Int((System.Math.Abs(ZnT) - ZnTDeg) * 60 + 0.5)

        }

        public void DisplayWeems()
        {
            cmdSave.Visible = false;
            cmdFix.Visible = false; // : 
            cmdFix.Enabled = false;
            cmdFix.Text = "Establish Fix";
            frameNASRUsing.Visible = false;
            frame214.Visible = false;
            Label9.Visible = false;
            frameS.Visible = false;
            GroupBoxPrecision.Visible = false;      // V5.6.1
            chkInterpolateB.Visible = true;
            if (Kd > 90d)
            {
                chkInterpolateB.Visible = false;
                ErrorMsgBox("Check input data");
                return;
            }

            SRHdrTxtBx.Clear();
            SRHdrTxtBx.Visible = true;
            SRHdrTxtBx.BringToFront();
            SRLgTxtBx.Clear();
            SRLgTxtBx.Visible = true;
            SRLgTxtBx.BringToFront();
            SRLeftTxtBx.Clear();
            SRLeftTxtBx.Visible = false;
            SRLeftTxtBx.SendToBack();
            SRRightTxtBx.Clear();
            SRRightTxtBx.Visible = false;
            SRRightTxtBx.SendToBack();
            NASRAsmTxtBx.Clear();
            NASRAsmTxtBx.Visible = false;
            NASRAsmTxtBx.SendToBack();
            NASRAFTxtBx.Clear();
            NASRAFTxtBx.Visible = false;
            NASRAFTxtBx.SendToBack();
            DCorrTxtBx.Clear();
            DCorrTxtBx.Visible = false;
            DCorrTxtBx.SendToBack();
            WeemsPVTxtBx.Clear();        // V5.6.1
            WeemsPVTxtBx.Visible = true; // V5.6.1
            WeemsPVTxtBx.BringToFront(); // V5.6.1
            var argTB = SRHdrTxtBx;
            AlignCenterRTB(ref argTB);
            SRHdrTxtBx = argTB;
            SRHdrTxtBx.AppendText("INTERCEPT and AZIMUTH by WEEMS LINE OF POSITION BOOK");
            SRLgTxtBx.AppendText("GHA" + Strings.Space(16 - txtGHADeg.Text.ToString().Length) + Strings.Format(Conversion.Val(txtGHADeg.Text), "##0") + '°' + Strings.Format(Conversion.Val(txtGHAMin.Text), "00.0") + "'"); // ; Tab(83); "DEC and LAT "
            SRLgTxtBx.AppendText(Environment.NewLine);
            SRLgTxtBx.AppendText("Asm Lo (");
            if (AsmLo == 0d)
            {
                SignA3 = " ";
                SRLgTxtBx.AppendText("");
            }

            if (Math.Sign(AsmLo) == 1)
            {
                SRLgTxtBx.AppendText("-");
                SignA3 = CommonGlobals.g_LongW;
            }

            if (Math.Sign(AsmLo) == -1)
            {
                SRLgTxtBx.AppendText("+");
                SignA3 = CommonGlobals.g_LongE;
            }

            if (Math.Sign(AsmLo) == 0)
            {
                SRLgTxtBx.AppendText(CommonGlobals.g_StrSpace);
                SignA3 = " ";
            }

            SRLgTxtBx.AppendText(")" + Strings.Space(7 - AsmLoDeg.ToString().Length) + Strings.Format(AsmLoDeg, "0") + '°' + Strings.Format(AsmLoMin, "00.0") + "'" + SignA3);
            SRLgTxtBx.AppendText(Strings.Space(23) + "d" + Strings.Space(5 - txtDecDeg.Text.ToString().Length) + Strings.Format(Conversion.Val(txtDecDeg.Text), "0") + '°' + Strings.Format(DecMinutes, "00.0") + "'" + cboDec.Text);
            SRLgTxtBx.AppendText("-->  B");
            i = (short)B4.ToString().Length;
            if (B4 - Conversion.Int(B4) == 0f)
            {
                i = (short)(i + 2);
            }

            if (B4 < 1f & B4 > 0f)
            {
                i = (short)(i + 1);
            }

            SRLgTxtBx.AppendText(Strings.Space(8 - i) + Strings.Format(B4, "#0") + "   (top, from d)");
            SRLgTxtBx.AppendText(Environment.NewLine);
            SRLgTxtBx.AppendText("t*(LHA)" + Strings.Space(11 - tDeg.ToString().Length) + Strings.Format(tDeg, "0") + '°');
            if (LHA <= 180d)
                SRLgTxtBx.AppendText(CommonGlobals.g_LongW);
            if (LHA > 180d)
                SRLgTxtBx.AppendText(CommonGlobals.g_LongE);
            SRLgTxtBx.AppendText(" -----> A");
            i = (short)A1.ToString().Length;
            if (A1 - Conversion.Int(A1) == 0d)
            {
                i = (short)(i + 2);
            }

            if (A1 < 1d & A1 > 0d)
            {
                i = (short)(i + 1);
            }

            if (T >= 21d | A1 == 0d)
            {
                SRLgTxtBx.AppendText(Strings.Space(9 - i) + Strings.Format(A1, "#0"));
            }

            if (T <= 20d & A1 != 0d)
            {
                SRLgTxtBx.AppendText(Strings.Space(9 - i) + Strings.Format(A1, "#0.0")); // 39 was 41
            }

            i = (short)KDeg.ToString().Length;
            if (KDeg - Conversion.Int(KDeg) == 0)
            {
                i = (short)(i + 2);
            }

            if (KDeg < 1 & KDeg > 0)
            {
                i = (short)(i + 1); // is this line necessary?
            }

            SRLgTxtBx.AppendText(Strings.Space(8) + "K" + Strings.Space(6 - i) + Strings.Format(KDeg, "0") + '°' + Strings.Format(KMin, "00.0") + "'" + cboL.Text);
            SRLgTxtBx.AppendText("--> +B");
            i = (short)B3.ToString().Length;
            if (B3 - Conversion.Int(B3) == 0f)
            {
                i = (short)(i + 2);
            }

            if (B3 < 1f & B3 > 0f)
            {
                i = (short)(i + 1);
            }

            if (T != 0d)
                SRLgTxtBx.AppendText(Strings.Space(9 - i) + Strings.Format(B3, "#0") + "   (bottom, from t)");
            if (T == 0d)
                SRLgTxtBx.AppendText(Strings.Space(3) + "infinite (bottom, from t)");
            SRLgTxtBx.AppendText(Environment.NewLine);
            SRLgTxtBx.AppendText("Asm L* " + Strings.Space(12 - Strings.Format(AsmL.ToString(), "#0").Length) + Strings.Format(AsmL.ToString(), "#0") + '°');
            if (AsmL == 0d)
                SRLgTxtBx.AppendText(CommonGlobals.g_StrSpace);
            if (AsmL != 0d)
                SRLgTxtBx.AppendText(cboL.Text);
            SRLgTxtBx.AppendText(Strings.Space(7) + "B");
            i = (short)B.ToString().Length;
            if (B - Conversion.Int(B) == 0d)
            {
                i = (short)(i + 2);
            }

            if (B < 1d & B > 0d)
            {
                i = (short)(i + 1);
            }

            if (Kd < 10d & KdMin - Conversion.Int(KdMin) != 0d)
            {
                SRLgTxtBx.AppendText(Strings.Space(9 - i) + Strings.Format(B, "#0.0"));
            }
            else
            {
                SRLgTxtBx.AppendText(Strings.Space(9 - i) + Strings.Format(B, "#0"));
            }

            i = (short)KdDeg.ToString().Length;
            if (KdDeg - Conversion.Int(KdDeg) == 0)
            {
                i = (short)(i + 2);
            }

            if (KdDeg < 1 & KdDeg > 0)
            {
                i = (short)(i + 1);
            }

            SRLgTxtBx.AppendText(Strings.Space(3) + "<--" + Strings.Space(2) + "K~d*" + Strings.Space(5 - i) + Strings.Format(KdDeg, "0") + '°' + Strings.Format(KdMin, "00.0") + "'");
            SRLgTxtBx.AppendText(Environment.NewLine);
            SRLgTxtBx.AppendText(Strings.Space(26) + "A+B"); // THIS IS JUST AN ADDITION - DOES NOT NEED CHKINTERPOLATEB?  BUT IT CHANGES WITH CHKINTERPOLATEB
            i = (short)AB.ToString().Length;
            if (AB - Conversion.Int(AB) == 0d)
            {
                i = (short)(i + 2);
            }

            if (AB < 1d & AB > 0d)
            {
                i = (short)(i + 1);
            }

            if ((T <= 20d | Kd < 10d | (int)chkInterpolateB.CheckState == 1) & AB - Conversion.Int(AB) != 0d)
            {
                SRLgTxtBx.AppendText(Strings.Space(7 - i) + Strings.Format(AB, "#0.0") + Strings.Space(3) + " -B->" + Strings.Space(1) + "Hc" + Strings.Space(5 - HcDeg.ToString().Length) + Strings.Format(HcDeg, "0") + '°' + Strings.Format(HcMin, "00.0") + "'");
            }
            else
            {
                SRLgTxtBx.AppendText(Strings.Space(7 - i) + Strings.Format(AB, "#0") + Strings.Space(3) + " -B->" + Strings.Space(1) + "Hc" + Strings.Space(5 - HcDeg.ToString().Length) + Strings.Format(HcDeg, "0") + '°' + Strings.Format(HcMin, "00.0") + "'");
            }

            SRLgTxtBx.AppendText(" ----> -B");
            i = (short)B5.ToString().Length;
            if (B5 - Conversion.Int(B5) == 0f)
            {
                i = (short)(i + 2);
            }

            if (B5 < 1f & B5 > 0f)
            {
                i = (short)(i + 1);
            }

            SRLgTxtBx.AppendText(Strings.Space(9 - i) + Strings.Format(B5, "#0") + "   (top, from Hc)");
            SRLgTxtBx.AppendText(Environment.NewLine);
            SRLgTxtBx.AppendText(Strings.Space(44) + "Ho" + Strings.Space(5 - HoDeg.ToString().Length) + Strings.Format(HoDeg, "0") + '°' + Strings.Format(HoMin, "00.0") + "'");
            SRLgTxtBx.AppendText(Environment.NewLine);
            SRLgTxtBx.AppendText("Z ");
            if (DE >= L)
                SRLgTxtBx.AppendText("N");
            if (DE < L)
                SRLgTxtBx.AppendText("S");
            SRLgTxtBx.AppendText(Strings.Format(Z, "#00.0") + '°');
            if (LHA <= 180d)
                SRLgTxtBx.AppendText(" W" + "; ");
            if (LHA > 180d)
                SRLgTxtBx.AppendText(" E" + "; ");
            SRLgTxtBx.AppendText("Zn " + Strings.Format(ZN, "000.0") + '°');
            SRLgTxtBx.AppendText(Strings.Space(22) + "a" + Strings.Space(11 - Conversion.Int(Math.Abs(A)).ToString().Length));
            SRLgTxtBx.AppendText(Strings.Format(Conversion.Int(Math.Abs(A) * 10d + 0.5d) / 10d, "0.0") + " nm");
            PlotOut.PlotIntercept = Strings.Format(Conversion.Int(Math.Abs(A) * 10d + 0.5d) / 10d, "0.0") + " nm ";
            if (HcDecimal < Ho)
            {
                SRLgTxtBx.AppendText(" Towards");
                PlotOut.PlotIntercept += " Toward";
            }

            if (HcDecimal > Ho)
            {
                SRLgTxtBx.AppendText(" Away   ");
                PlotOut.PlotIntercept += " Away";
            }

            if (HcDecimal == Ho)
            {
                SRLgTxtBx.AppendText("        ");
                PlotOut.PlotIntercept += " Toward";
            }

            i = (short)Btot.ToString().Length;
            if (Btot - Conversion.Int(Btot) == 0d)
            {
                i = (short)(i + 2);
            }

            if (Btot < 1d & Btot > 0d)
            {
                i = (short)(i + 1);
            }

            if (T != 0d)
                SRLgTxtBx.AppendText(Strings.Space(9 - i) + Strings.Format(Btot, "#0") + " ----B->");
            if (T == 0d)
                SRLgTxtBx.AppendText("infinite --B->");
            SRLgTxtBx.AppendText(Strings.Space(1));
            if (DE >= L)
                SRLgTxtBx.AppendText("Z N ");
            if (DE < L)
                SRLgTxtBx.AppendText("Z S ");
            SRLgTxtBx.AppendText(Strings.Format(Z4Deg, "#0") + '°' + Strings.Format(Z4Min, "00") + "'");
            if (LHA <= 180d)
                SRLgTxtBx.AppendText(" W");
            if (LHA > 180d)
                SRLgTxtBx.AppendText(" E");
            SRLgTxtBx.AppendText(Environment.NewLine);
            SRLgTxtBx.AppendText("    (by formula)" + Strings.Space(9) + "AP/EP L " + Strings.Format(APEstLDeg, "#0") + '°' + Strings.Format(APEstLMin, "00.0") + "'");
            if (APEstL > 0d)
                SRLgTxtBx.AppendText(CommonGlobals.g_LatN);
            if (APEstL == 0d)
                SRLgTxtBx.AppendText(CommonGlobals.g_StrSpace);
            if (APEstL < 0d)
                SRLgTxtBx.AppendText(CommonGlobals.g_LatS);
            SRLgTxtBx.AppendText("   AP/EP Lo " + Strings.Format(APEstLoDeg, "0") + '°' + Strings.Format(APEstLoMin, "00.0") + "'");
            if (APEstLo > 0d)
                SRLgTxtBx.AppendText(CommonGlobals.g_LongW);
            if (APEstLo == 0d)
                SRLgTxtBx.AppendText(CommonGlobals.g_StrSpace);
            if (APEstLo < 0d)
                SRLgTxtBx.AppendText(CommonGlobals.g_LongE);
            SRLgTxtBx.AppendText(Strings.Space(8) + "(bottom)");
            SRLgTxtBx.AppendText(Strings.Space(3) + "Zn ");
            if (chkInterpolateB.CheckState == 0)
                SRLgTxtBx.AppendText(Strings.Format(ZnTDeg, "#0") + '°' + Strings.Format(ZnTMin, "00") + "'");
            if ((int)chkInterpolateB.CheckState == 1)
                SRLgTxtBx.AppendText(Strings.Format(ZnTDeg, "#0") + '°' + Strings.Format(ZnTMin, "00.0") + "'");
            SRLgTxtBx.AppendText(Environment.NewLine);
            SRLgTxtBx.AppendText(Strings.Space(25) + "DR-LOP Distance " + Strings.Format(Math.Abs(KPLOPDist), "0.0") + " nm ");
            if (KPLOPDist < 0d)
                SRLgTxtBx.AppendText("Towards");
            if (KPLOPDist > 0d)
                SRLgTxtBx.AppendText("Away   ");
            if (KPLOPDist == 0d)
                SRLgTxtBx.AppendText("       ");
            SRLgTxtBx.AppendText(Strings.Space(24) + "(by tables)");
            SRLgTxtBx.AppendText(Environment.NewLine);
            var argTB1 = SRLgTxtBx;
            AlignCenterRTB(ref argTB1);
            SRLgTxtBx = argTB1;
            SRLgTxtBx.AppendText("   EP L " + Strings.Format(EstLDeg, "0") + '°' + Strings.Format(EstLMin, "00.0") + "'");
            SRLgTxtBx.AppendText("      EP Lo " + Strings.Format(EstLoDeg, "0") + '°' + Strings.Format(EstLoMin, "00.0") + "'");
            SRLgTxtBx.AppendText(Environment.NewLine);
            var argTB2 = SRLgTxtBx;
            AlignLeftRTB(ref argTB2);
            SRLgTxtBx = argTB2;
            SRLgTxtBx.AppendText("*Table entry values");
            SRLgTxtBx.Refresh();
            SRHdrTxtBx.Refresh();

            // If cboL.Text = cboDec.Text And DE < L Then      'V5.6.1 (actually V5.4.1)
            // Print TAB(26); "Note:  Body altitude when on prime vertical "; Format(HpvDeg, "#0"); Chr(176); Format(HpvMin, "00.0"); "'."
            // If ZnLoC <= 90 Or ZnLoC >= 270 Then Print TAB(32); " Body is north of observer"
            // If ZnLoC > 90 And ZnLoC < 270 Then Print TAB(32); " Body is south of observer"
            // Print TAB(32); " for Dec and DR L same name and Dec < DR L."
            // End If

            if ((cboL.Text ?? "") == (cboDec.Text ?? "") & DE < L)
            {
                WeemsPVTxtBx.AppendText("Note:  Body altitude when on prime vertical " + Strings.Format(HpvDeg, "#0") + '°' + Strings.Format(HpvMin, "00.0") + "'.");
                WeemsPVTxtBx.AppendText(Environment.NewLine);
                if (ZnLoC <= 90d | ZnLoC >= 270d)
                    WeemsPVTxtBx.AppendText(" Body is north of observer");
                if (ZnLoC > 90d & ZnLoC < 270d)
                    WeemsPVTxtBx.AppendText(" Body is south of observer");
                WeemsPVTxtBx.AppendText(Environment.NewLine);
                WeemsPVTxtBx.AppendText(" for Dec and DR L same name and Dec < DR L.");
            }
        }

        public void HO229()
        {
            DSDcorrFlag = false;
            LHA = GHA - Lo;
            if (LHA >= 360d)
                LHA = LHA - 360d;
            if (LHA < 0d)
                LHA = LHA + 360d;
            AsmLHA = Conversion.Int(LHA + 0.5d);
            if (AsmLHA == 360d)
                AsmLHA = 0d;
            GHAAsmDeg = (short)Conversion.Val(txtGHADeg.Text);
            GHAAsmMin = (short)Conversion.Int(Conversion.Val(txtGHAMin.Text) + 0.5d);
            GHAAsm = GHAAsmDeg + GHAAsmMin / 60d; // in degrees
            AsmLo = GHAAsm - AsmLHA;
            if (Math.Abs(AsmLo) < 180d)
                AsmLo = 360d - Math.Abs(AsmLo);
            if (Math.Abs(AsmLo) >= 180d & Lo >= 0d)
                AsmLo = 360d - Math.Abs(AsmLo);
            if (Math.Abs(AsmLo) >= 180d & Lo < 0d)
                AsmLo = -(360d - Math.Abs(AsmLo));
            AsmLoDeg = (short)Conversion.Int(Math.Abs(AsmLo));
            if (AsmLo > 0d | txtLoDeg.Text == "180")
                AsmLoMin = (float)Conversion.Val(txtGHAMin.Text);
            else
                AsmLoMin = (float)(60d - Conversion.Val(txtGHAMin.Text));
            if (AsmLoMin == 60f)
                AsmLoMin = 0f;
            AsmL = Conversion.Int(L + 0.5d);
            AsmDec = (float)Conversion.Int(Math.Abs(Dec));
            DecIncr = (float)Conversion.Val(txtDecMin.Text);
            if (cboDec.Text == "S" & cboL.Text == "N" | cboDec.Text == "N" & cboL.Text == "S")
                AsmDec = -AsmDec; // : SignDE$ = "-"
            Hc = Math.Cos(AsmLHA * Pi / 180d) * Math.Cos(Math.Abs(AsmL) * Pi / 180d) * Math.Cos(AsmDec * Pi / 180d) + Math.Sin(Math.Abs(AsmL) * Pi / 180d) * Math.Sin(AsmDec * Pi / 180d);
            if (Math.Abs(Hc) >= 1d)
                Hc = Math.Sign(Hc) * Pi / 2d;
            else
                Hc = Math.Atan(Hc / Math.Sqrt(-Hc * Hc + 1d)); // arcsine
            Hc = Hc * 180d / Pi;
            TabHcDeg = (short)Conversion.Fix(Hc); // was Int
            TabHcMin = Hc - TabHcDeg;
            TabHcMin = Conversion.Int(60d * TabHcMin * 10d + 0.5d) / 10d; // WHY IS 0.50023 NEEDED!!!!!!!!!!!!!!! Extra problem 1 does not work without it.
            i = 1;
            if (AsmDec < 0f)
            {
                i = -1;
            }

            NextHc = Math.Cos(AsmLHA * Pi / 180d) * Math.Cos(Math.Abs(AsmL) * Pi / 180d) * Math.Cos((AsmDec + i) * Pi / 180d) + Math.Sin(Math.Abs(AsmL) * Pi / 180d) * Math.Sin((AsmDec + i) * Pi / 180d);
            if (Math.Abs(NextHc) >= 1d)
                NextHc = Math.Sign(NextHc) * Pi / 2d;
            else
                NextHc = Math.Atan(NextHc / Math.Sqrt(-NextHc * NextHc + 1d)); // arcsine
            NextHc = NextHc * 180d / Pi;
            NextHcDeg = (short)Conversion.Int(NextHc);
            NextHcMin = NextHc - NextHcDeg;
            NextHcMin = Conversion.Int(60d * NextHcMin * 10d + 0.5d) / 10d;
            i = -1;
            if (AsmDec < 0f)
            {
                i = 1;
            }

            NextHcDSD1 = Math.Cos(AsmLHA * Pi / 180d) * Math.Cos(Math.Abs(AsmL) * Pi / 180d) * Math.Cos((AsmDec + i) * Pi / 180d) + Math.Sin(Math.Abs(AsmL) * Pi / 180d) * Math.Sin((AsmDec + i) * Pi / 180d);
            if (Math.Abs(NextHcDSD1) >= 1d)
                NextHcDSD1 = Math.Sign(NextHcDSD1) * Pi / 2d;
            else
                NextHcDSD1 = Math.Atan(NextHcDSD1 / Math.Sqrt(-NextHcDSD1 * NextHcDSD1 + 1d)); // arcsine
            NextHcDSD1 = NextHcDSD1 * 180d / Pi;
            NextHcDSD1Deg = (short)Conversion.Int(NextHcDSD1);
            NextHcDSD1Min = NextHcDSD1 - NextHcDSD1Deg;
            NextHcDSD1Min = Conversion.Int(60d * NextHcDSD1Min * 10d + 0.5d) / 10d;
            i = 2;
            if (AsmDec < 0f)
            {
                i = -2;
            }

            NextHcDSD2 = Math.Cos(AsmLHA * Pi / 180d) * Math.Cos(Math.Abs(AsmL) * Pi / 180d) * Math.Cos((AsmDec + i) * Pi / 180d) + Math.Sin(Math.Abs(AsmL) * Pi / 180d) * Math.Sin((AsmDec + i) * Pi / 180d);
            if (Math.Abs(NextHcDSD2) >= 1d)
                NextHcDSD2 = Math.Sign(NextHcDSD2) * Pi / 2d;
            else
                NextHcDSD2 = Math.Atan(NextHcDSD2 / Math.Sqrt(-NextHcDSD2 * NextHcDSD2 + 1d)); // arcsine
            NextHcDSD2 = NextHcDSD2 * 180d / Pi;
            NextHcDSD2Deg = (short)Conversion.Int(NextHcDSD2);
            NextHcDSD2Min = NextHcDSD2 - NextHcDSD2Deg;
            NextHcDSD2Min = Conversion.Int(60d * NextHcDSD2Min * 10d + 0.5d) / 10d;
            D = (float)(60 * NextHcDeg + NextHcMin - (60 * TabHcDeg + TabHcMin));
            SgnD = (short)Math.Sign(D);
            SignD = "+";
            if (Math.Sign(D) == -1)
            {
                SignD = "-";
            }

            d1corr = (float)(Conversion.Int(Conversion.Int(Math.Abs(D) / 10f) * DecIncr / 60f * 100f + 0.5d) / 10d);
            d2corr = Conversion.Int((Math.Abs(D) - 10f * Conversion.Int(Math.Abs(D) / 10f)) * DecIncr / 60f * 10f + 0.5d) / 10d;
            DSD1 = (float)(60 * TabHcDeg + TabHcMin - (60 * NextHcDSD1Deg + NextHcDSD1Min));
            DSD3 = (float)(60 * NextHcDSD2Deg + NextHcDSD2Min - (60 * NextHcDeg + NextHcMin));
            DSD = D - DSD1 + (DSD3 - D);
            SgnDSD = (short)Math.Sign(DSD);
            DSDcorr = 2.1d * Math.Sin(DecIncr * 3f * Pi / 180d) * Math.Abs(DSD) / 33d;
            DSDcorr = Conversion.Int(DSDcorr * 10d + 0.5d) / 10d;
            if (chkDSD.CheckState == 0 & DSDcorr <= 0.25d)
            {
                DSDcorr = 0d;
                DSDcorrFlag = true;
            }

            Totcorr = (float)(SgnD * (d1corr + d2corr) + Math.Abs(DSDcorr));
            SignTotcorr = "+";
            if (Totcorr < 0f)
                SignTotcorr = "-";
            TotHc = (TabHcDeg * 60 + TabHcMin + Totcorr) / 60d;
            TotHcDeg = (short)Conversion.Fix(TotHc);
            Htot = TotHc; // was Int
            TotHcMin = TotHc - TotHcDeg;
            TotHcMin = Conversion.Int(600d * TotHcMin + 0.5d) / 10d;
            if (TotHcMin == 60d)
                TotHcMin = 0d;
            TotHcDeg = (short)(TotHcDeg + 1);
            A = 60 * TotHcDeg + TotHcMin - (60 * HoDeg + HoMin);
            L4 = Math.Sin(AsmDec * Pi / 180d);
            L5 = Math.Sin(Math.Abs(AsmL) * Pi / 180d) * Math.Sin(Hc * Pi / 180d);
            L6 = L4 - L5;
            L7 = Math.Cos(Math.Abs(AsmL) * Pi / 180d) * Math.Cos(Hc * Pi / 180d);
            L8 = L6 / L7;
            if (Math.Abs(L8) >= 1d)
                Z = Pi;
            else
                Z = Math.Atan(-L8 / Math.Sqrt(-L8 * L8 + 1d)) + Pi / 2d; // arccosine
            Z = Z * 180d / Pi;
            TabZ = (float)(Conversion.Int(Z * 10d + 0.5d) / 10d);

            // For calculating Z corr
            i = 1;
            if (AsmDec < 0f)
            {
                i = -1;
            }

            ZL4 = Math.Sin((AsmDec + i) * Pi / 180d);
            ZL5 = Math.Sin(Math.Abs(AsmL) * Pi / 180d) * Math.Sin(NextHc * Pi / 180d);
            ZL6 = ZL4 - ZL5;
            ZL7 = Math.Cos(Math.Abs(AsmL) * Pi / 180d) * Math.Cos(NextHc * Pi / 180d);
            ZL8 = ZL6 / ZL7;
            if (Math.Abs(ZL8) >= 1d)
            {
                ZC = Pi;
            }
            else
            {
                ZC = Math.Atan(-ZL8 / Math.Sqrt(-ZL8 * ZL8 + 1d)) + Pi / 2d;
            } // arccosine

            ZC = ZC * 180d / Pi;
            ZC = Conversion.Int(ZC * 10d + 0.5d) / 10d;
            Zdiff = ZC - TabZ;
            if (Math.Sign(Zdiff) == 0)
                SignZdiff = " ";
            if (Math.Sign(Zdiff) > 0)
                SignZdiff = "+";
            if (Math.Sign(Zdiff) < 0)
                SignZdiff = "-";
            Zcorr = (float)(DecIncr / 60f * Zdiff);
            Zcorr = (float)(Conversion.Int(Zcorr * 10f + 0.5d) / 10d);
            Ztot = TabZ + Zcorr;
            Ztot = Conversion.Int(Ztot * 10d + 0.5d) / 10d;
            if (cboL.Text == "N" & LHA > 180d)
                ZN = Ztot;
            if (cboL.Text == "N" & LHA <= 180d)
                ZN = 360d - Ztot;
            if (cboL.Text == "S" & LHA > 180d)
                ZN = 180d - Ztot;
            if (cboL.Text == "S" & LHA <= 180d)
                ZN = 180d + Ztot;
            ZN = Conversion.Int(ZN + 0.5d); // added in V4.0.0
        }

        public void Display229()
        {
            cmdSave.Visible = false;
            cmdFix.Visible = false;
            cmdFix.Text = "Establish Fix";
            SRHdrTxtBx.Clear();
            SRHdrTxtBx.Visible = true;
            SRHdrTxtBx.BringToFront();
            SRLgTxtBx.Clear();
            SRLgTxtBx.Visible = true;
            SRLgTxtBx.BringToFront();
            SRLeftTxtBx.Clear();
            SRLeftTxtBx.Visible = false;
            SRLeftTxtBx.SendToBack();
            SRRightTxtBx.Clear();
            SRRightTxtBx.Visible = false;
            SRRightTxtBx.SendToBack();
            NASRAsmTxtBx.Clear();
            NASRAsmTxtBx.Visible = false;
            NASRAsmTxtBx.SendToBack();
            NASRAFTxtBx.Clear();
            NASRAFTxtBx.Visible = false;
            NASRAFTxtBx.SendToBack();
            DCorrTxtBx.Clear();
            DCorrTxtBx.Visible = false;
            DCorrTxtBx.SendToBack();
            WeemsPVTxtBx.Clear();            // V5.6.1
            WeemsPVTxtBx.Visible = false;    // V5.6.1
            WeemsPVTxtBx.SendToBack();   // V5.6.1
            frameNASRUsing.Visible = false;
            frame211.Visible = false;
            frame214.Visible = false;
            Label9.Visible = false;
            frameS.Visible = false;
            GroupBoxPrecision.Visible = false;      // V5.6.1
            chkInterpolateB.Visible = false;
            chkDSD.Enabled = true;
            if (DSDcorr > 0.25d)
            {
                chkDSD.Enabled = false;
            }

            var argTB = SRHdrTxtBx;
            AlignCenterRTB(ref argTB);
            SRHdrTxtBx = argTB;
            SRHdrTxtBx.AppendText("Pub. 229");
            SRLgTxtBx.AppendText("Calc. of Asm Lo and LHA" + Strings.Space(58) + "Asm L " + Strings.Space(4 - AsmL.ToString().Length) + Strings.Format(Math.Abs(AsmL), "#0") + '°');
            if (AsmL == 0d)
            {
                SRLgTxtBx.AppendText(CommonGlobals.g_StrSpace);
            }
            else
            {
                SRLgTxtBx.AppendText(cboL.Text);
            }

            SRLgTxtBx.AppendText(Environment.NewLine);
            SRLgTxtBx.AppendText("Tot GHA" + Strings.Space(9 - txtGHADeg.Text.ToString().Length) + Strings.Format(Conversion.Val(txtGHADeg.Text), "##0") + '°' + Strings.Format(Conversion.Val(txtGHAMin.Text), "00.0") + "'" + Strings.Space(60) + "DEC and LAT ");
            SRLgTxtBx.AppendText(Environment.NewLine);
            SRLgTxtBx.AppendText("Asm Lo (");
            if (AsmLo == 0d)
            {
                SignA3 = " ";
                SRLgTxtBx.AppendText("");
            }

            if (Math.Sign(AsmLo) == 1)
            {
                SRLgTxtBx.AppendText("-");
                SignA3 = CommonGlobals.g_LongW;
            }

            if (Math.Sign(AsmLo) == -1)
            {
                SRLgTxtBx.AppendText("+");
                SignA3 = CommonGlobals.g_LongE;
            }

            if (Math.Sign(AsmLo) == 0)
            {
                SRLgTxtBx.AppendText(CommonGlobals.g_StrSpace);
                SignA3 = " ";
            }

            SRLgTxtBx.AppendText(")" + Strings.Space(6 - AsmLoDeg.ToString().Length) + Strings.Format(AsmLoDeg, "0") + '°' + Strings.Format(AsmLoMin, "00.0") + "'" + SignA3);
            SRLgTxtBx.AppendText(Strings.Space(5) + "Dec" + Strings.Space(4 - DecDegrees.ToString().Length) + Strings.Format(DecDegrees, "#0") + '°' + cboDec.Text);
            SRLgTxtBx.AppendText(Strings.Space(10) + "Dec Incr " + Strings.Format(DecIncr, "00.0") + "'");
            if ((cboL.Text ?? "") == (cboDec.Text ?? ""))
            {
                SRLgTxtBx.AppendText(Strings.Space(21) + "SAME NAME    ");
            }

            if ((cboL.Text ?? "") != (cboDec.Text ?? ""))
            {
                SRLgTxtBx.AppendText(Strings.Space(21) + "CONTRARY NAME");
            }

            SRLgTxtBx.AppendText(Environment.NewLine);
            i = 89;
            if (TabZ < 100f)
            {
                i = 90;
                if (TabZ < 10f)
                    i = 91;
            }

            SRLgTxtBx.AppendText("LHA" + Strings.Space(13 - AsmLHA.ToString().Length) + Strings.Format(AsmLHA, "0") + '°');
            SRLgTxtBx.AppendText(Strings.Space(11) + "d (" + SignD + ") " + Strings.Format(Math.Abs(D), "0.0") + "'");
            if (DSDcorrFlag == false)
            {
                SRLgTxtBx.AppendText(Strings.Space(4) + "DSD " + Strings.Format(Math.Abs(DSD), "00.0") + "'");
            }

            if (chkDSD.CheckState == 0 & DSDcorrFlag == true)
            {
                SRLgTxtBx.AppendText(Strings.Space(4) + "DSD " + "    '");
            }

            SRLgTxtBx.AppendText(Strings.Space(9) + "Z diff (" + SignZdiff + ") " + Strings.Format(Math.Abs(Zdiff), "0.0") + '°');
            SRLgTxtBx.AppendText(Strings.Space(6) + "Tab Z " + Strings.Space(6 - TabZ.ToString().Length) + Strings.Format(TabZ, "0.0") + '°');
            // "Hc "; Tab(42 - Str$(TotHcDeg))); Format(TotHcDeg, "0"); Chr$(176); Format(TotHcMin, "00"); "'"
            SRLgTxtBx.AppendText(Environment.NewLine);
            // i = 18: If Sgn(Hc) = -1 Then i = 17

            SRLgTxtBx.AppendText("Tab Hc " + Strings.Space(5));
            if (Math.Sign(Hc) == -1)
            {
                SRLgTxtBx.AppendText("-");
            }
            else
            {
                SRLgTxtBx.AppendText(CommonGlobals.g_StrSpace);
            }

            SRLgTxtBx.AppendText(Strings.Space(4 - Math.Abs(TabHcDeg).ToString().Length) + Strings.Format(Math.Abs(TabHcDeg), "0") + '°' + Strings.Format(Math.Abs(TabHcMin), "00.0") + "'");
            i = 53;
            if (d1corr < 10f)
            {
                i = 54;
            }

            SRLgTxtBx.AppendText(Strings.Space(17) + "d1 corr. (" + SignD + ") " + Strings.Space(5 - Strings.Format(d1corr.ToString(), "0.0").Length) + Strings.Format(Math.Abs(d1corr), "0.0") + "'");
            SRLgTxtBx.AppendText(Strings.Space(18) + "Z corr (" + SignZdiff + ") " + Strings.Format(Math.Abs(Zcorr), "0.0") + '°');
            SRLgTxtBx.AppendText(Environment.NewLine);
            i = 18;
            if (Math.Abs(Totcorr) < 10f)
            {
                i = 19;
            }

            SRLgTxtBx.AppendText("Tot corr" + Strings.Space(2) + " (" + SignTotcorr + ") " + Strings.Space(5 - Strings.Format(Totcorr.ToString(), "0.0").Length) + Strings.Format(Math.Abs(Totcorr), "0.0") + "'");
            i = 53;
            if (d2corr < 10d)
            {
                i = 54;
            }

            SRLgTxtBx.AppendText(Strings.Space(17) + "d2 corr. (" + SignD + ") " + Strings.Space(5 - Strings.Format(d2corr.ToString(), "0.0").Length) + Strings.Format(Math.Abs(d2corr), "0.0") + "'");
            SRLgTxtBx.AppendText(Environment.NewLine);

            // i = 18: If Sgn(TotHc) = -1 Then i = 17

            SRLgTxtBx.AppendText("Hc " + Strings.Space(9));
            if (Math.Sign(TotHc) == -1)
            {
                SRLgTxtBx.AppendText("-");
            }
            else
            {
                SRLgTxtBx.AppendText(CommonGlobals.g_StrSpace);
            }

            SRLgTxtBx.AppendText(Strings.Space(4 - Math.Abs(TotHcDeg).ToString().Length) + Strings.Format(Math.Abs(TotHcDeg), "0") + '°' + Strings.Format(Math.Abs(TotHcMin), "00.0") + "'");
            i = 53;
            if (DSDcorr < 10d)
            {
                i = 54;
            }

            if (DSDcorrFlag == false)
            {
                SRLgTxtBx.AppendText(Strings.Space(17) + "DSD corr (+) " + Strings.Space(4 - Strings.Format(DSDcorr.ToString(), "0.0").Length) + Strings.Format(Math.Abs(DSDcorr), "0.0") + "'");
            }

            if (chkDSD.CheckState == 0 & DSDcorrFlag == true)
            {
                SRLgTxtBx.AppendText(Strings.Space(17) + "DSD corr (+)    '");
            }

            i = 89;
            if (Ztot < 100d)
            {
                i = 90;
            }

            if (Ztot < 10d)
            {
                i = 91;
            }

            SRLgTxtBx.AppendText(Strings.Space(21) + "Z " + cboL.Text + Strings.Space(5 - Strings.Format(Ztot.ToString(), "0.0").Length) + Strings.Format(Math.Abs(Ztot), "0.0") + '°');
            if (LHA <= 180d)
                SRLgTxtBx.AppendText(" W");
            if (LHA > 180d)
                SRLgTxtBx.AppendText(" E");
            SRLgTxtBx.AppendText(Environment.NewLine);
            i = 53;
            if (Math.Abs(Totcorr) < 10f)
            {
                i = 54;
            }
            // HoMin = Int(HoMin + 0.5)

            SRLgTxtBx.AppendText("Ho " + Strings.Space(9));
            if (HoinMinutes < 0d)
            {
                SRLgTxtBx.AppendText("-");
            }
            else
            {
                SRLgTxtBx.AppendText(CommonGlobals.g_StrSpace);
            }

            SRLgTxtBx.AppendText(Strings.Space(4 - HoDeg.ToString().Length) + Strings.Format(Math.Abs(HoDeg), "0") + '°' + Strings.Format(Math.Abs(HoMin), "00.0") + "'");
            SRLgTxtBx.AppendText(Strings.Space(17) + "Tot corr (" + SignTotcorr + ") " + Strings.Space(5 - Strings.Format(Totcorr.ToString(), "0.0").Length) + Strings.Format(Math.Abs(Totcorr), "0.0") + "'");
            SRLgTxtBx.AppendText(Environment.NewLine);
            SRLgTxtBx.AppendText(Strings.Space(13) + "a " + Strings.Space(7 - Conversion.Int(Math.Abs(A)).ToString().Length) + Strings.Format(Conversion.Int(Math.Abs(A) * 10d + 0.5d) / 10d, "0.0") + " miles ");
            PlotOut.PlotIntercept = Strings.Format(Conversion.Int(Math.Abs(A) * 10d + 0.5d) / 10d, "0.0") + " nm ";
            if (A < 0d)
            {
                SRLgTxtBx.AppendText("T  Observed greater - Toward");
                PlotOut.PlotIntercept += " Toward";
            }

            if (A > 0d)
            {
                SRLgTxtBx.AppendText("A  Computed greater - Away");
                PlotOut.PlotIntercept += " Away";
            }

            SRLgTxtBx.AppendText(Strings.Space(19) + "Zn    " + Strings.Format(ZN, "000") + '°');
            PlotOut.PlotAz = Strings.Format(ZN, "000") + '°';
            SRLgTxtBx.AppendText(Environment.NewLine);
            SRLgTxtBx.AppendText(Environment.NewLine);
            SRLgTxtBx.AppendText(Strings.Space(34) + "AP/EP L " + Strings.Format(APEstLDeg, "0") + '°' + Strings.Format(APEstLMin, "00.0") + "'");
            switch (APEstL)
            {
                case var @case when @case > 0d:
                    {
                        SRLgTxtBx.AppendText(CommonGlobals.g_LatN);
                        break;
                    }

                case var case1 when case1 < 0d:
                    {
                        SRLgTxtBx.AppendText(CommonGlobals.g_LatS);
                        break;
                    }

                default:
                    {
                        SRLgTxtBx.AppendText(CommonGlobals.g_StrSpace);
                        break;
                    }
            }
            // If APEstL > 0 Then SRLgTxtBx.AppendText(g_LatN)
            // If APEstL = 0 Then SRLgTxtBx.AppendText(g_StrSpace)
            // If APEstL < 0 Then SRLgTxtBx.AppendText(g_LatS)

            SRLgTxtBx.AppendText("   AP/EP Lo " + Strings.Format(APEstLoDeg, "0") + '°' + Strings.Format(APEstLoMin, "00.0") + "'");
            switch (APEstLo)
            {
                case var case2 when case2 > 0d:
                    {
                        SRLgTxtBx.AppendText(CommonGlobals.g_LongW);
                        break;
                    }

                case var case3 when case3 < 0d:
                    {
                        SRLgTxtBx.AppendText(CommonGlobals.g_LongE);
                        break;
                    }

                default:
                    {
                        SRLgTxtBx.AppendText(CommonGlobals.g_StrSpace);
                        break;
                    }
            }
            // If APEstLo > 0 Then SRLgTxtBx.AppendText(g_LongW)
            // If APEstLo = 0 Then SRLgTxtBx.AppendText(g_StrSpace)
            // If APEstLo < 0 Then SRLgTxtBx.AppendText(g_LongE)
            SRLgTxtBx.AppendText(Environment.NewLine);
            SRLgTxtBx.AppendText(Strings.Space(34) + "DR-LOP Distance " + Strings.Format(Math.Abs(KPLOPDist), "0.0") + " nm ");
            switch (KPLOPDist)
            {
                case var case4 when case4 > 0d:
                    {
                        SRLgTxtBx.AppendText("A");
                        break;
                    }

                case var case5 when case5 < 0d:
                    {
                        SRLgTxtBx.AppendText("T");
                        break;
                    }

                default:
                    {
                        SRLgTxtBx.AppendText(CommonGlobals.g_StrSpace);
                        break;
                    }
            }
            // If KPLOPDist < 0 Then SRLgTxtBx.AppendText("T")
            // If KPLOPDist > 0 Then SRLgTxtBx.AppendText("A")
            // If KPLOPDist = 0 Then SRLgTxtBx.AppendText(g_StrSpace)
            SRLgTxtBx.AppendText(Environment.NewLine);
            SRLgTxtBx.AppendText(Strings.Space(34) + "   EP L " + Strings.Format(EstLDeg, "0") + '°' + Strings.Format(EstLMin, "00.0") + "'");
            SRLgTxtBx.AppendText("      EP Lo " + Strings.Format(EstLoDeg, "0") + '°' + Strings.Format(EstLoMin, "00.0") + "'");
            SRLgTxtBx.AppendText(Environment.NewLine);
            SRLgTxtBx.Refresh();
            SRHdrTxtBx.Refresh();
        }

        public void HO211()
        {
            frame211.Visible = false;
            Flag = false; // Part of avoiding divide-by-zero errors
            LHA = GHA - Lo;
            if (LHA >= 360d)
                LHA = LHA - 360d;
            if (LHA < 0d)
                LHA = LHA + 360d;
            if (LHA <= 180d)
                T = LHA; // W
            if (LHA > 180d)
                T = 360d - LHA; // E
            tDeg = (short)Conversion.Int(T);
            tMin = (T - tDeg) * 60d;
            if (optCompact.Checked == true)
                tMin = Conversion.Int(tMin + 0.50000001d);
            if (optOriginal.Checked == true)
                tMin = Conversion.Int(2d * tMin + 0.5d) / 2d;
            if (tMin == 60d)
            {
                tMin = 0d;
                tDeg = (short)(tDeg + 1);
            }

            tDecimal = tDeg + tMin / 60d; // : If tDecimal = 0 Then tDecimal = 0.00000001
            if (optCompact.Checked == true & tDecimal == 0d)
            {
                ErrorMsgBox("For Compact H.O. 211 without interpolation, meridian angle t must be at least 0.5'.");
                Flag = true;
                return;
            }

            if (optOriginal.Checked == true & tDecimal == 0d)
            {
                ErrorMsgBox("For Original H.O. 211 without interpolation, meridian angle t must be at least 0.3'.");
                Flag = true;
                return;
            }

            A1 = Csc211(ref tDecimal);
            if (optCompact.Checked == true & A1 < 166d | optOriginal.Checked == true & A1 < 239d)
            {
                A1 = Conversion.Int(10d * A1 + 0.5d) / 10d;
            }
            else
            {
                A1 = Conversion.Int(A1 + 0.5d);
            }

            if (optCompact.Checked == true)
                DecMinutes = Conversion.Int(Conversion.Val(txtDecMin.Text) + 0.5d);
            if (optOriginal.Checked == true)
                DecMinutes = Conversion.Int(2d * Conversion.Val(txtDecMin.Text) + 0.5d) / 2d;
            DecDecimal = Conversion.Val(txtDecDeg.Text) + DecMinutes / 60d;
            if (optCompact.Checked == true & DecDecimal == 0d)
            {
                ErrorMsgBox("For Compact H.O. 211 without interpolation, Dec must be at least 0.5'.");
                Flag = true;
                return;
            }

            if (optOriginal.Checked == true & DecDecimal == 0d)
            {
                ErrorMsgBox("For Original H.O. 211 without interpolation, Dec must be at least 0.3'.");
                Flag = true;
                return;
            }

            frame211.Visible = true;
            B1 = Sec211(ref DecDecimal);
            if (optCompact.Checked == true & B1 < 166d | optOriginal.Checked == true & B1 < 239d)
            {
                B1 = Conversion.Int(10d * B1 + 0.5d) / 10d;
            }
            else
            {
                B1 = Conversion.Int(B1 + 0.5d);
            }

            A2 = Csc211(ref DecDecimal);
            if (optCompact.Checked == true & A2 < 166f | optOriginal.Checked == true & A2 < 239f)
            {
                A2 = (float)(Conversion.Int(10f * A2 + 0.5d) / 10d);
            }
            else
            {
                A2 = (float)Conversion.Int(A2 + 0.5d);
            }

            A3 = (float)(A1 + B1);
            A3 = (float)(Conversion.Int(A3 * 10f + 0.5d) / 10d); // is this line necessary?
            A4 = A3;
            A3Angle = 1d / Math.Pow(10d, A3 / 100000f);
            A3Angle = Math.Atan(A3Angle / Math.Sqrt(-A3Angle * A3Angle + 1d) + 9.999999E-21d); // arcsin
            A3Angle = A3Angle * 180d / Pi;
            A3AngleDeg = (short)Conversion.Int(A3Angle);
            A3AngleMin = (A3Angle - A3AngleDeg) * 60d;
            if (optCompact.Checked == true)
                A3AngleMin = Conversion.Int(A3AngleMin + 0.5d);
            if (optOriginal.Checked == true)
                A3AngleMin = Conversion.Int(2d * A3AngleMin + 0.5d) / 2d;
            A3AngleDecimal = A3AngleDeg + A3AngleMin / 60d;
            B2 = Sec211(ref A3AngleDecimal);
            if (optCompact.Checked == true & B2 < 166f | optOriginal.Checked == true & B2 < 239f)
            {
                B2 = (float)(Conversion.Int(10f * B2 + 0.5d) / 10d);
            }
            else
            {
                B2 = (float)Conversion.Int(B2 + 0.5d);
            }

            B3 = B2;
            A5 = A2 - B2;
            A5 = (float)(Conversion.Int(A5 * 10f + 0.5d) / 10d); // is this line necessary?
            k = 1d / Math.Pow(10d, A5 / 100000f);
            if (k >= 1d)
                k = Pi / 2d;
            else
                k = Math.Atan(k / Math.Sqrt(-k * k + 1d) + 9.999999E-21d); // arcsin            Was If k = 1 before V5.4.1
            k = k * 180d / Pi;
            if (k >= 82d & k <= 98d)
            {
                B2 = Sec211(ref A3Angle);
                B2 = (float)(Conversion.Int(1000f * B2 + 0.5d) / 1000d);
                B3 = B2;
                A5 = A2 - B2;
                // A5 = CscS(DecDecimal) - SecS(A3Angle)
                // A5 = Int(1000 * A5 + 0.5) / 1000
                k = 1d / Math.Pow(10d, A5 / 100000f);
                if (k >= 1d)
                    k = Pi / 2d;
                else
                    k = Math.Atan(k / Math.Sqrt(-k * k + 1d) + 9.999999E-21d); // arcsin        Was If k = 1 before V5.4.1
                k = k * 180d / Pi;
                A5 = (float)(Conversion.Int(1000f * A5 + 0.5d) / 1000d);
            }

            if (tDecimal > 90d)
                k = 180d - k; // ????????????90-K or 180-K????????
            KDeg = (short)Conversion.Int(k);
            KMin = (k - KDeg) * 60d;
            if (optCompact.Checked == true)
                KMin = Conversion.Int(KMin + 0.5d);
            if (optOriginal.Checked == true)
                KMin = Conversion.Int(2d * KMin + 0.5d) / 2d;
            if (optCompact.Checked == true)
                L = Conversion.Val(txtLDeg.Text) + Conversion.Int(Conversion.Val(txtLMin.Text) + 0.5d) / 60d;
            if (optOriginal.Checked == true)
                L = Conversion.Val(txtLDeg.Text) + Conversion.Val(txtLMin.Text) / 60d;
            if ((cboDec.Text ?? "") == (cboL.Text ?? ""))
                KL = Math.Abs(L - KDeg - KMin / 60d);
            if ((cboDec.Text ?? "") != (cboL.Text ?? ""))
                KL = Math.Abs(L + KDeg + KMin / 60d);
            // If KL > 90 Then KL = KL + 180
            KLDeg = (short)Conversion.Int(KL);
            KLMin = (KL - KLDeg) * 60d;
            if (KLDeg > 90)
                KLDeg = (short)(KLDeg + 180);
            if (optCompact.Checked == true)
                KLMin = Conversion.Int(KLMin + 0.5d);
            if (optOriginal.Checked == true)
                KLMin = Conversion.Int(2d * KLMin + 0.5d) / 2d;
            if (KLMin >= 60d)
            {
                KLMin = KLMin - 60d;
                KLDeg = (short)(KLDeg + 1);
            }

            float localSec211() { double argx = KLDeg + KLMin / 60d; var ret = Sec211(ref argx); return ret; }

            B4 = localSec211();
            if (KLDeg > 270)
                KLDeg = (short)(KLDeg - 180);
            if (optCompact.Checked == true & B4 < 166f | optOriginal.Checked == true & B4 < 239f)
                B4 = (float)(Conversion.Int(10f * B4 + 0.5d) / 10d);
            else
                B4 = (float)Conversion.Int(B4 + 0.5d);
            A6 = B3 + B4;
            A6 = (float)(Conversion.Int(A6 * 10f + 0.5d) / 10d); // is this line necessary?
            HcAngle = 1d / Math.Pow(10d, A6 / 100000f);
            if (HcAngle == 1d)
                HcAngle = Pi / 2d;
            else
                HcAngle = Math.Atan(HcAngle / Math.Sqrt(-HcAngle * HcAngle + 1d) + 9.999999E-21d); // arcsin
            HcAngle = HcAngle * 180d / Pi;
            Htot = HcAngle;
            HcDeg = (short)Conversion.Int(HcAngle);
            HcMin = (HcAngle - HcDeg) * 60d;
            if (optCompact.Checked == true)
                HcMin = Conversion.Int(HcMin + 0.5d);
            if (optOriginal.Checked == true)
                HcMin = Conversion.Int(2d * HcMin + 0.5d) / 2d;
            if (HcMin >= 60d)
            {
                HcMin = HcMin - 60d;
                HcDeg = (short)(HcDeg + 1);
            }

            HcDecimal = HcDeg + HcMin / 60d;
            if (KL > 90d)
                HcDecimal = -HcDecimal;
            B5 = Sec211(ref HcDecimal);
            if (optCompact.Checked == true & B5 < 166f | optOriginal.Checked == true & B5 < 239f)
                B5 = (float)(Conversion.Int(10f * B5 + 0.5d) / 10d);
            else
                B5 = (float)Conversion.Int(B5 + 0.5d);
            Ho = Conversion.Val(txtHoDeg.Text) + Conversion.Val(txtHoMin.Text) / 60d;
            // HoDeg = Int(Ho)
            // HoMin = (Ho - HoDeg) * 60
            HoDeg = (short)Conversion.Val(txtHoDeg.Text);
            HoMin = Conversion.Val(txtHoMin.Text);
            if (optCompact.Checked == true)
                HoMin = Conversion.Int(HoMin + 0.5d);
            if (optOriginal.Checked == true)
                HoMin = Conversion.Int(HoMin * 10d + 0.5d) / 10d;
            A = Math.Sign(HcDecimal) * (60 * HcDeg + HcMin) - (60 * HoDeg + HoMin);
            if (HoinMinutes < 0d)
                A = 60 * HcDeg + HcMin + (60 * HoDeg + HoMin);
            A7 = A4 - B5;
            if (A7 <= 0f)
            {
                A7 = 0f;
                Z = 90d;
            } // When the body is near or on the Prime Vertical, A7 may be negative.  Use zero for A7 and Z will be 90 degrees.

            if (A7 != 0f)
            {
                Z = 1d / Math.Pow(10d, A7 / 100000f);
                Z = Math.Atan(Z / Math.Sqrt(-Z * Z + 1d) + 9.999999E-21d); // arcsin
                Z = Z * 180d / Pi;
            }

            A7 = (float)(Conversion.Int(A7 * 10f + 0.5d) / 10d); // this line was necessary for low value of A7
            if ((cboDec.Text ?? "") == (cboL.Text ?? "") & k > L)
                Z = Z;
            else
                Z = 180d - Z;
            ZDeg = (short)Conversion.Int(Z);
            ZMin = (Z - ZDeg) * 60d;
            // If optCompact = True Then Z = Int(Z + 0.5)  'For Z in whole degrees
            if (optCompact.Checked == true)
                ZMin = Conversion.Int(ZMin + 0.5d);
            if (optOriginal.Checked == true)
                ZMin = Conversion.Int(2d * ZMin + 0.5d) / 2d;
            if (cboL.Text == "N" & LHA > 180d)
                ZN = Z;
            if (cboL.Text == "N" & LHA <= 180d)
                ZN = 360d - Z;
            if (cboL.Text == "S" & LHA > 180d)
                ZN = 180d - Z;
            if (cboL.Text == "S" & LHA <= 180d)
                ZN = 180d + Z;
            if (cboL.Text == "S")
                L = -L;
        }

        public void HO208()
        {
            // frame211.Visible = False

            Flag = false;
            Flag0 = false;
            LHA = GHA - Lo;
            if (LHA >= 360d)
                LHA = LHA - 360d;
            if (LHA < 0d)
                LHA = LHA + 360d;
            AsmLHA = Conversion.Int(LHA + 0.5d);
            if (AsmLHA == 0d | AsmLHA == 360d | AsmLHA == 180d)
            {
                ErrorMsgBox("For H.O. 208, LHA (GHA - LoW, GHA + LoE) to nearest whole degree cannot be 0º or 180º.");
                Flag0 = true;
                return;
            }

            if (LHA <= 180d)
                T = AsmLHA; // W
            if (LHA > 180d)
                T = 360d - AsmLHA; // E
            AsmLo = GHAAsm - AsmLHA;
            if (Math.Abs(AsmLo) < 180d)
                AsmLo = 360d - Math.Abs(AsmLo);
            if (Math.Abs(AsmLo) >= 180d & Lo >= 0d)
                AsmLo = 360d - Math.Abs(AsmLo);
            if (Math.Abs(AsmLo) >= 180d & Lo < 0d)
                AsmLo = -(360d - Math.Abs(AsmLo));
            AsmLoDeg = (short)Conversion.Int(Math.Abs(AsmLo));
            if (AsmLo > 0d | txtLoDeg.Text == "180")
                AsmLoMin = (float)Conversion.Val(txtGHAMin.Text);
            else
                AsmLoMin = (float)(60d - Conversion.Val(txtGHAMin.Text));
            if (AsmLoMin == 60f)
                AsmLoMin = 0f;
            AsmL = Conversion.Int(L + 0.5d);
            DecDecimal = Math.Abs(Conversion.Val(txtDecDeg.Text) + DecMinutes / 60d);
            if (AsmL == 0d)
                AsmL = 0.0000000001d;
            B1 = 1d / Math.Tan(AsmL * Pi / 180d) * Math.Cos(T * Pi / 180d);
            B1 = Math.Atan(B1) * 180d / Pi; // B1 is b
            B1Deg = (short)Conversion.Int(Math.Abs(B1));
            B1Min = (Math.Abs(B1) - B1Deg) * 60d;
            B1Min = Conversion.Int(B1Min * 10d + 0.5d) / 10d;
            if (B1Min == 60d)
            {
                B1Min = 0d;
                B1Deg = (short)(B1Deg + 1);
            }

            B1 = Math.Abs(B1Deg + B1Min / 60d);
            if (T <= 90d)
                SignB = cboL.Text;
            if (T > 90d)
            {
                if (cboL.Text == "N")
                    SignB = CommonGlobals.g_LatS;
                if (cboL.Text == "S")
                    SignB = CommonGlobals.g_LatN;
            }

            if (Math.Abs(AsmL) <= 0.5d)
                SignB = cboDec.Text; // For L=0, b gets same name as Dec
            A1 = Math.Cos(AsmL * Pi / 180d) * Math.Sin(T * Pi / 180d);
            A1 = Math.Atan(A1 / Math.Sqrt(-A1 * A1 + 1d)); // arcsin        A1 is a
            if (A1 == 0d)
                A1 = 0.0000000001d * Pi / 180d;
            A2 = (float)(100000d * (Math.Log(1d / Math.Cos(A1)) / Math.Log(10d)));
            A2 = (float)Conversion.Int(A2 + 0.5d); // A2 is A
            A4 = (float)(1000d * Math.Abs(Math.Log(1d / Math.Sin(A1)) / Math.Log(10d)));
            A4 = (float)Conversion.Int(A4 + 0.5d); // A4 is C
            if (AsmL == 0d | T == 0d)
                Z1 = 0d;
            else
            {
                Z1 = Math.Sin(AsmL * Pi / 180d) * Math.Tan(T * Pi / 180d);
                Z1 = Math.Atan(1d / Z1) * 180d / Pi;
            }

            Z1 = Conversion.Int(Math.Abs(Z1) * 10d + 0.5d) / 10d; // Z1 is Z'
            SignZ1 = SignB;
            if ((cboDec.Text ?? "") == (SignB ?? ""))
                A3 = (float)Math.Abs(DecDecimal + B1);
            else
                A3 = (float)Math.Abs(DecDecimal - B1); // A3 is d + b
            if (Math.Abs(DecDecimal) >= Math.Abs(B1))
                SignA3 = cboDec.Text;
            if (Math.Abs(DecDecimal) < Math.Abs(B1))
                SignA3 = SignB;
            A3Deg = (short)Conversion.Int(A3);
            A3Min = (A3 - Conversion.Int(A3)) * 60f;
            A3Min = Conversion.Int(A3Min * 10d + 0.5d) / 10d;
            if (A3Min == 60d)
            {
                A3Min = 0d;
                A3Deg = (short)(A3Deg + 1);
            }

            A3 = (float)(A3Deg + A3Min / 60d);

            // If A3 > 90 Then A3 = 180 - A3: Flag = True

            B2 = (float)(100000d * (Math.Log(1d / Math.Sin(A3 * Pi / 180d)) / Math.Log(10d)));
            B2 = (float)Conversion.Int(B2 + 0.5d); // B2 is B
            if ((cboDec.Text ?? "") != (cboL.Text ?? ""))
                DecDecimal = -DecDecimal;
            A5 = A2 + B2; // A + B
            Hc = Math.Cos(A1) * Math.Sin(A3 * Pi / 180d);
            if (Hc == 1d)
                Hc = Pi / 2d;
            else
                Hc = Math.Atan(Hc / Math.Sqrt(-Hc * Hc + 1d) + 9.999999E-21d); // arcsin
            Hc = Hc * 180d / Pi; // : Htot = Hc
            HcDeg = (short)Conversion.Int(Hc);
            HcMin = (Hc - HcDeg) * 60d;
            HcMin = Conversion.Int(HcMin * 10d + 0.5d) / 10d;
            if (HcMin == 60d)
            {
                HcMin = 0d;
                HcDeg = (short)(HcDeg + 1);
            }

            Hc = HcDeg + HcMin / 60d;
            // If (DecDecimal + B1) < 0 Then Hc = -Hc
            if ((SignA3 ?? "") != (cboL.Text ?? ""))
                Hc = -Hc;
            Htot = Hc;

            // B3 = 1 / Tan(A3 * Pi / 180)
            B3 = (float)Math.Abs(1d / Math.Tan(A3 * Pi / 180d));
            B3 = (float)(1000d * (Math.Log(B3) / Math.Log(10d))); // B3 is D
            B3 = (float)Conversion.Int(B3 + 0.5d);
            if (A3 == 90f)
                B3 = 0f;
            if (B3 < 0f)
                B3 = 10000f + B3; // WHY?
                                  // B3 = Int(B3 + 0.5)

            A6 = A4 + B3; // A6 is C + D
            if (A6 > 10000f)
                A6 = A6 - 10000f;
            Z2 = 1d / Math.Sin(A1) * (1d / Math.Tan(A3 * Pi / 180d));
            Z2 = Math.Abs(Math.Atan(Z2));
            Z2 = Z2 * 180d / Pi;
            Z2 = Conversion.Int(Z2 * 10d + 0.5d) / 10d;
            // If cboDec.text <> cboL.text Then DecDecimal = -DecDecimal
            if (DecDecimal + B1 < 0d)
                Z2 = 180d - Z2;
            SignZ2 = SignA3;



            // If Flag = True Then Z2 = -Z2
            // If A3 > 90 Then Z2 = -Z2
            if (A3 > 90f)
            {
                if (SignA3 == "N")
                    SignZ2 = CommonGlobals.g_LatS;
                if (SignA3 == "S")
                    SignZ2 = CommonGlobals.g_LatN;
            }

            // Z = Z1 + Z2
            if ((SignZ1 ?? "") == (SignZ2 ?? ""))
                Z = Math.Abs(Z1 + Z2);
            else
                Z = Math.Abs(Z1 - Z2);
            if (Math.Abs(AsmL) <= 0.5d)
                cboL.Text = cboDec.Text; // For L=0, L gets same name as Dec
            if (cboL.Text == "N" & LHA > 180d)
                ZN = Z;
            if (cboL.Text == "N" & LHA <= 180d)
                ZN = 360d - Z;
            if (cboL.Text == "S" & LHA > 180d)
                ZN = 180d - Z;
            if (cboL.Text == "S" & LHA <= 180d)
                ZN = 180d + Z;
            A = Math.Sign(Hc) * (60 * HcDeg + HcMin) - (60 * HoDeg + HoMin);
            if (HoinMinutes < 0d)
                A = 60 * HcDeg + HcMin + (60 * HoDeg + HoMin);
        }

        public void Display211()
        {
            cmdSave.Visible = false;
            cmdFix.Visible = false; // 
            cmdFix.Enabled = false;
            cmdFix.Text = "Establish Fix";
            // Me.Font = New Font(Me.Font, "Courier New")

            SRHdrTxtBx.Clear();
            SRHdrTxtBx.Visible = true;
            SRHdrTxtBx.BringToFront();
            SRLgTxtBx.Clear();
            SRLgTxtBx.Visible = true;
            SRLgTxtBx.BringToFront();
            SRLeftTxtBx.Clear();
            SRLeftTxtBx.Visible = false;
            SRLeftTxtBx.SendToBack();
            SRRightTxtBx.Clear();
            SRRightTxtBx.Visible = false;
            SRRightTxtBx.SendToBack();
            NASRAsmTxtBx.Clear();
            NASRAsmTxtBx.Visible = false;
            NASRAsmTxtBx.SendToBack();
            NASRAFTxtBx.Clear();
            NASRAFTxtBx.Visible = false;
            NASRAFTxtBx.SendToBack();
            DCorrTxtBx.Clear();
            DCorrTxtBx.Visible = false;
            DCorrTxtBx.SendToBack();
            WeemsPVTxtBx.Clear();            // V5.6.1
            WeemsPVTxtBx.Visible = false;    // V5.6.1
            WeemsPVTxtBx.SendToBack();   // V5.6.1
            frameNASRUsing.Visible = false;
            // frame211.Visible = True        'moved to HO211 so it doesn't appear if LHA or Dec are near zero
            frame214.Visible = false;
            Label9.Visible = false;
            frameS.Visible = false;
            GroupBoxPrecision.Visible = false;      // V5.6.1
            chkInterpolateB.Visible = false;
            var argTB = SRHdrTxtBx;
            AlignCenterRTB(ref argTB);
            SRHdrTxtBx = argTB;
            SRHdrTxtBx.AppendText("INTERCEPT and AZIMUTH by AGETON'S METHOD (H.O. 211)");

            // Print

            if (optCompact.Checked == true)
            {
                SRLgTxtBx.AppendText("t*" + Strings.Space(11 - tDeg.ToString().Length) + Strings.Format(tDeg, "0") + '°' + Strings.Format(tMin, "00") + "'");
            }

            if (optOriginal.Checked == true)
            {
                SRLgTxtBx.AppendText("t*" + Strings.Space(11 - tDeg.ToString().Length) + Strings.Format(tDeg, "0") + '°' + Strings.Format(tMin, "00.0") + "'");
            }

            if (LHA <= 180d)
                SRLgTxtBx.AppendText(CommonGlobals.g_LongW);
            if (LHA > 180d)
                SRLgTxtBx.AppendText(CommonGlobals.g_LongE);
            i = (short)A1.ToString().Length;
            if (A1 - Conversion.Int(A1) == 0d)
            {
                i = (short)(i + 2);
            }

            if (A1 < 1d & A1 > 0d)
            {
                i = (short)(i + 1);
            }

            if (optCompact.Checked == true & A1 < 166d | optOriginal.Checked == true & A1 < 239d)
            {
                SRLgTxtBx.AppendText(Strings.Space(8) + "A " + Strings.Space(9 - i) + Strings.Format(A1, "0.0"));
            }
            else
            {
                SRLgTxtBx.AppendText(Strings.Space(8) + "A " + Strings.Space(9 - i) + Strings.Format(A1, "0"));
            }

            SRLgTxtBx.AppendText(Environment.NewLine);
            if (optCompact.Checked == true)
            {
                SRLgTxtBx.AppendText("Dec*" + Strings.Space(9 - txtDecDeg.Text.ToString().Length) + Strings.Format(Conversion.Val(txtDecDeg.Text), "0") + '°' + Strings.Format(DecMinutes, "00") + "'" + cboDec.Text);
            }

            if (optOriginal.Checked == true)
            {
                SRLgTxtBx.AppendText("Dec*" + Strings.Space(9 - txtDecDeg.Text.ToString().Length) + Strings.Format(Conversion.Val(txtDecDeg.Text), "0") + '°' + Strings.Format(DecMinutes, "00.0") + "'" + cboDec.Text);
            }

            i = (short)B1.ToString().Length;
            if (B1 - Conversion.Int(B1) == 0d)
            {
                i = (short)(i + 2);
            }

            if (optCompact.Checked == true & B1 < 166d | optOriginal.Checked == true & B1 < 239d)
            {
                SRLgTxtBx.AppendText(Strings.Space(7) + "B+" + Strings.Space(9 - i));
                SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Underline);
                SRLgTxtBx.AppendText(Strings.Format(B1, "0.0"));
                SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Regular);
            }
            else
            {
                SRLgTxtBx.AppendText(Strings.Space(7) + "B+" + Strings.Space(9 - i));
                SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Underline);
                SRLgTxtBx.AppendText(Strings.Format(B1, "0"));
                SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Regular);
            }

            i = (short)A2.ToString().Length;
            if (A2 - Conversion.Int(A2) == 0f)
            {
                i = (short)(i + 2);
            }

            if (optCompact.Checked == true & A2 < 166f | optOriginal.Checked == true & A2 < 239f)
            {
                SRLgTxtBx.AppendText(Strings.Space(11) + "A " + Strings.Space(9 - i) + Strings.Format(A2, "0.0"));
            }
            else
            {
                SRLgTxtBx.AppendText(Strings.Space(11) + "A " + Strings.Space(9 - i) + Strings.Format(A2, "0"));
            }

            SRLgTxtBx.AppendText(Environment.NewLine);
            i = (short)A3.ToString().Length;
            if (A3 - Conversion.Int(A3) == 0f)
            {
                i = (short)(i + 2); // 7
            }

            if (A3 - Conversion.Int(A3) != 0f)
            {
                SRLgTxtBx.AppendText(Strings.Space(25) + "A " + Strings.Space(9 - i) + Strings.Format(A3, "0.0"));
            }

            if (A3 - Conversion.Int(A3) == 0f)
            {
                SRLgTxtBx.AppendText(Strings.Space(25) + "A " + Strings.Space(9 - i) + Strings.Format(A3, "0"));
            }

            i = (short)B2.ToString().Length;
            if (B2 - Conversion.Int(B2) == 0f)
            {
                i = (short)(i + 2);
            }

            if (optCompact.Checked == true & B2 < 166f | optOriginal.Checked == true & B2 < 239f)
            {
                SRLgTxtBx.AppendText(Strings.Space(11) + "B-" + Strings.Space(9 - i));
                SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Underline);
                SRLgTxtBx.AppendText(Strings.Format(B2, "0.0"));
                SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Regular);
            }
            else
            {
                SRLgTxtBx.AppendText(Strings.Space(11) + "B-" + Strings.Space(9 - i));
                SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Underline);
                SRLgTxtBx.AppendText(Strings.Format(B2, "0"));
                SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Regular);
            }

            if (k >= 82d & k <= 98d)
            {
                SRLgTxtBx.AppendText("** ");
            }
            else
            {
                SRLgTxtBx.AppendText("   ");
            }

            i = (short)B3.ToString().Length;
            if (B3 - Conversion.Int(B3) == 0f)
            {
                i = (short)(i + 2);
            }

            if (optCompact.Checked == true & B3 < 166f | optOriginal.Checked == true & B3 < 239f)
            {
                SRLgTxtBx.AppendText(Strings.Space(9) + "B " + Strings.Space(9 - i) + Strings.Format(B3, "0.0"));
            }
            else
            {
                SRLgTxtBx.AppendText(Strings.Space(9) + "B " + Strings.Space(9 - i) + Strings.Format(B3, "0"));
            }

            i = (short)A4.ToString().Length;
            if (A4 - Conversion.Int(A4) == 0f)
            {
                i = (short)(i + 2);
            }
            // If (optCompact = True And A4 < 166) Or (optOriginal = True And A4 < 239) Then Print Tab(85); "A"; Tab(97 - i); Format(A4, "0.0") Else _
            // Print Tab(85); "A"; Tab(97 - i); Format(A4, "0")

            if (A4 - Conversion.Int(A4) != 0f)
            {
                SRLgTxtBx.AppendText(Strings.Space(11) + "A " + Strings.Space(9 - i) + Strings.Format(A4, "0.0"));
            }

            if (A4 - Conversion.Int(A4) == 0f)
            {
                SRLgTxtBx.AppendText(Strings.Space(11) + "A " + Strings.Space(9 - i) + Strings.Format(A4, "0"));
            }

            SRLgTxtBx.AppendText(Environment.NewLine);
            if (optCompact.Checked == true)
            {
                SRLgTxtBx.AppendText("K    " + Strings.Space(8 - KDeg.ToString().Length) + Strings.Format(KDeg, "0") + '°' + Strings.Format(KMin, "00") + "'" + cboDec.Text);
            }

            if (optOriginal.Checked == true)
            {
                SRLgTxtBx.AppendText("K    " + Strings.Space(8 - KDeg.ToString().Length) + Strings.Format(KDeg, "0") + '°' + Strings.Format(KMin, "00.0") + "'" + cboDec.Text);
            }
            // If k >= 82 And k <= 98 Then Print "**";

            SRLgTxtBx.AppendText("  <- <- <- <- <- <- <-");
            if (optCompact.Checked == true)
            {
                SRLgTxtBx.AppendText(" <- ");
            }
            else
            {
                SRLgTxtBx.AppendText("    ");
            }

            i = (short)A5.ToString().Length;
            if (A5 - Conversion.Int(A5) == 0f)
            {
                i = (short)(i + 2);
            }

            if (A5 - Conversion.Int(A5) != 0f)
            {
                SRLgTxtBx.AppendText("A " + Strings.Space(9 - i) + Strings.Format(A5, "0.0"));
            }

            if (A5 - Conversion.Int(A5) == 0f)
            {
                SRLgTxtBx.AppendText("A " + Strings.Space(9 - i) + Strings.Format(A5, "0"));
            }

            SRLgTxtBx.AppendText(Environment.NewLine);
            if (optCompact.Checked == true)
            {
                SRLgTxtBx.AppendText("DR L " + Strings.Space(8 - txtLDeg.Text.ToString().Length));
                SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Underline);
                SRLgTxtBx.AppendText(Strings.Format(Conversion.Val(txtLDeg.Text), "0") + '°' + Strings.Format(Conversion.Int(Conversion.Val(txtLMin.Text) + 0.5d), "00") + "'" + cboL.Text);
                SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Regular);
            }

            if (optOriginal.Checked == true)
            {
                SRLgTxtBx.AppendText("DR L " + Strings.Space(8 - txtLDeg.Text.ToString().Length));
                SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Underline);
                SRLgTxtBx.AppendText(Strings.Format(Conversion.Val(txtLDeg.Text), "0") + '°' + Strings.Format(Conversion.Val(txtLMin.Text), "00.0") + "'" + cboL.Text);
                SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Regular);
            }

            SRLgTxtBx.AppendText(Environment.NewLine);
            if (optCompact.Checked == true)
            {
                SRLgTxtBx.AppendText("K ~ L" + Strings.Space(8 - KLDeg.ToString().Length) + Strings.Format(KLDeg, "0") + '°' + Strings.Format(KLMin, "00") + "'");
            }

            if (optOriginal.Checked == true)
            {
                SRLgTxtBx.AppendText("K ~ L" + Strings.Space(8 - KLDeg.ToString().Length) + Strings.Format(KLDeg, "0") + '°' + Strings.Format(KLMin, "00.0") + "'");
            }

            SRLgTxtBx.AppendText("   -> -> -> -> -> -> -> -> -> -> -> -> -> ->");
            if (optCompact.Checked == true)
            {
                SRLgTxtBx.AppendText(" -> ");
            }
            else
            {
                SRLgTxtBx.AppendText("    ");
            }

            i = (short)B4.ToString().Length;
            if (B4 - Conversion.Int(B4) == 0f)
            {
                i = (short)(i + 2);
            }

            if (optCompact.Checked == true & B4 < 166f | optOriginal.Checked == true & B4 < 239f)
            {
                SRLgTxtBx.AppendText("B+" + Strings.Space(9 - i));
                SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Underline);
                SRLgTxtBx.AppendText(Strings.Format(B4, "0.0"));
                SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Regular);
            }
            else
            {
                SRLgTxtBx.AppendText("B+" + Strings.Space(9 - i));
                SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Underline);
                SRLgTxtBx.AppendText(Strings.Format(B4, "0"));
                SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Regular);
            }

            SRLgTxtBx.AppendText(Environment.NewLine);
            SRLgTxtBx.AppendText("Hc");
            if (KL > 90d)
            {
                SRLgTxtBx.AppendText(Strings.Space(9 - HcDeg.ToString().Length) + "-");
            }
            else
            {
                SRLgTxtBx.AppendText(Strings.Space(9 - HcDeg.ToString().Length) + " ");
            }

            if (optCompact.Checked == true)
            {
                SRLgTxtBx.AppendText(Strings.Space(4 - HcDeg.ToString().Length) + Strings.Format(HcDeg, "0") + '°' + Strings.Format(HcMin, "00") + "'");
            }

            if (optOriginal.Checked == true)
            {
                SRLgTxtBx.AppendText(Strings.Space(4 - HcDeg.ToString().Length) + Strings.Format(HcDeg, "0") + '°' + Strings.Format(HcMin, "00.0") + "'");
            }

            SRLgTxtBx.AppendText("   <- <- <- <- <- <- <- <- <- <- <- <- <- <- ");
            if (optCompact.Checked == true)
            {
                SRLgTxtBx.AppendText("<- ");
            }
            else
            {
                SRLgTxtBx.AppendText("   ");
            }

            i = (short)A6.ToString().Length;
            if (A6 - Conversion.Int(A6) == 0f)
            {
                i = (short)(i + 2);
            }

            if (A6 - Conversion.Int(A6) != 0f)
            {
                SRLgTxtBx.AppendText("A " + Strings.Space(9 - i) + Strings.Format(A6, "0.0"));
            }

            if (A6 - Conversion.Int(A6) == 0f)
            {
                SRLgTxtBx.AppendText("A " + Strings.Space(9 - i) + Strings.Format(A6, "0"));
            }

            i = (short)B5.ToString().Length;
            if (B5 - Conversion.Int(B5) == 0f)
            {
                i = (short)(i + 2);
            }

            if (optOriginal.Checked == true & B5 < 1f)
                i = 4;
            // If (optCompact = True And B5 < 166) Or (optOriginal = True And B5 < 239) Then Print Tab(85); "B-"; Tab(97 - Str$(B5))); Format(B5, "0.0") Else _
            // Print Tab(85); "B-"; Tab(95 - Str$(B5))); Format(B5, "0")

            if (optCompact.Checked == true & B5 < 166f | optOriginal.Checked == true & B5 < 239f)
            {
                SRLgTxtBx.AppendText(Strings.Space(11) + "B-" + Strings.Space(9 - i));
                SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Underline);
                SRLgTxtBx.AppendText(Strings.Format(B5, "0.0"));
                SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Regular);
            }
            else
            {
                SRLgTxtBx.AppendText(Strings.Space(11) + "B-" + Strings.Space(9 - i));
                SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Underline);
                SRLgTxtBx.AppendText(Strings.Format(B5, "0"));
                SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Regular);
            }

            SRLgTxtBx.AppendText(Environment.NewLine);
            SRLgTxtBx.AppendText("Ho");
            if (HoMin < 0d)
            {
                SRLgTxtBx.AppendText(Strings.Space(9 - HoDeg.ToString().Length) + "-");
            }
            else
            {
                SRLgTxtBx.AppendText(Strings.Space(9 - HoDeg.ToString().Length) + " ");
            }

            SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Underline);
            if (optCompact.Checked == true)
            {
                SRLgTxtBx.AppendText(Strings.Space(4 - txtHoDeg.Text.ToString().Length) + Strings.Format(HoDeg, "0") + '°' + Strings.Format(Math.Abs(HoMin), "00") + "'");
            }

            if (optOriginal.Checked == true)
            {
                SRLgTxtBx.AppendText(Strings.Space(4 - txtHoDeg.Text.ToString().Length) + Strings.Format(HoDeg, "0") + '°' + Strings.Format(Math.Abs(HoMin), "00.0") + "'");
            }

            SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Regular);
            if (Ho > HcDecimal)
                SRLgTxtBx.AppendText("    Observed greater - Toward");
            if (Ho < HcDecimal)
                SRLgTxtBx.AppendText("    Computed greater - Away");
            SRLgTxtBx.AppendText(Environment.NewLine);
            SRLgTxtBx.AppendText("a" + Strings.Space(15 - Conversion.Int(Math.Abs(A)).ToString().Length));
            if (optCompact.Checked == true)
            {
                SRLgTxtBx.AppendText(Strings.Format(Conversion.Int(Math.Abs(A) + 0.5d), "0") + " miles ");
                PlotOut.PlotIntercept = Strings.Format(Conversion.Int(Math.Abs(A) + 0.5d), "0") + " nm ";
            }

            if (optOriginal.Checked == true)
            {
                SRLgTxtBx.AppendText(Strings.Format(Conversion.Int(Math.Abs(A) * 10d + 0.5d) / 10d, "0.0") + " miles ");
                PlotOut.PlotIntercept = Strings.Format(Conversion.Int(Math.Abs(A) * 10d + 0.5d) / 10d, "0.0") + " nm ";
            }

            if (HcDecimal < Ho)
            {
                SRLgTxtBx.AppendText("T");
                PlotOut.PlotIntercept += " Toward";
            }

            if (HcDecimal > Ho)
            {
                SRLgTxtBx.AppendText("A");
                PlotOut.PlotIntercept += " Away";
            }

            if (HcDecimal == Ho)
            {
                SRLgTxtBx.AppendText(CommonGlobals.g_StrSpace);
                PlotOut.PlotIntercept += " Toward";
            }

            SRLgTxtBx.AppendText(Strings.Space(7) + "Zn " + Strings.Format(ZN, "000") + '°' + " <- <- <- <- <- ");
            PlotOut.PlotAz = Strings.Format(ZN, "000") + '°';
            if (optCompact.Checked == true)
            {
                SRLgTxtBx.AppendText("Z " + cboL.Text + Strings.Space(1) + Strings.Format(ZDeg, "0") + '°' + Strings.Format(ZMin, "00") + "'"); // Format(Z, "0"); Chr$(176); for whole degrees
            }

            if (optOriginal.Checked == true)
            {
                SRLgTxtBx.AppendText("Z " + cboL.Text + Strings.Space(1) + Strings.Format(ZDeg, "0") + '°' + Strings.Format(ZMin, "00.0") + "'");
            }

            if (LHA <= 180d)
                SRLgTxtBx.AppendText(" W" + "  <- <- <- <- ");
            if (LHA > 180d)
                SRLgTxtBx.AppendText(" E" + "  <- <- <- <- ");
            if (optCompact.Checked == true)
            {
                SRLgTxtBx.AppendText("<-");
            }
            else
            {
                SRLgTxtBx.AppendText("  ");
            }

            i = (short)A7.ToString().Length;
            if (A7 - Conversion.Int(A7) == 0f)
            {
                i = (short)(i + 2);
            }

            if (A7 - Conversion.Int(A7) != 0f)
            {
                SRLgTxtBx.AppendText("A " + Strings.Space(9 - i) + Strings.Format(A7, "0.0"));
            }

            if (A7 - Conversion.Int(A7) == 0f)
            {
                SRLgTxtBx.AppendText("A " + Strings.Space(9 - i) + Strings.Format(A7, "0"));
            }

            SRLgTxtBx.AppendText(Environment.NewLine);
            SRLgTxtBx.AppendText(Strings.Space(30) + "EP L " + Strings.Format(EstLDeg, "0") + '°' + Strings.Format(EstLMin, "00.0") + "'");
            PlotOut.PlotSLEP = "EP L " + Strings.Format(EstLDeg, "0") + '°' + Strings.Format(EstLMin, "00.0") + "'";
            if (EstL > 0d)
            {
                SRLgTxtBx.AppendText(CommonGlobals.g_LatN);
                PlotOut.PlotSLEP += CommonGlobals.g_LatN;
                PlotOut.PlotLatNS = CommonGlobals.g_LatN;
            }

            if (EstL == 0d)
            {
                SRLgTxtBx.AppendText(CommonGlobals.g_StrSpace);
                PlotOut.PlotSLEP += CommonGlobals.g_LatN;
                PlotOut.PlotLatNS = CommonGlobals.g_LatN;
            }

            if (EstL < 0d)
            {
                SRLgTxtBx.AppendText(CommonGlobals.g_LatS);
                PlotOut.PlotSLEP += CommonGlobals.g_LatS;
                PlotOut.PlotLatNS = CommonGlobals.g_LatS;
            }

            SRLgTxtBx.AppendText("      EP Lo " + Strings.Format(EstLoDeg, "0") + '°' + Strings.Format(EstLoMin, "00.0") + "'");
            PlotOut.PlotSLEP += " EP Lo " + Strings.Format(EstLoDeg, "0") + '°' + Strings.Format(EstLoMin, "00.0") + "'";
            if (EstLo > 0d)
            {
                SRLgTxtBx.AppendText(CommonGlobals.g_LongW);
                PlotOut.PlotSLEP += CommonGlobals.g_LongW;
                PlotOut.PlotLongEW = CommonGlobals.g_LongW;
            }

            if (EstLo == 0d)
            {
                SRLgTxtBx.AppendText(CommonGlobals.g_StrSpace);
                PlotOut.PlotSLEP += CommonGlobals.g_LongW;
                PlotOut.PlotLongEW = CommonGlobals.g_LongW;
            }

            if (EstLo < 0d)
            {
                SRLgTxtBx.AppendText(CommonGlobals.g_LongE);
                PlotOut.PlotSLEP += CommonGlobals.g_LongE;
                PlotOut.PlotLongEW = CommonGlobals.g_LongE;
            }

            SRLgTxtBx.AppendText(Environment.NewLine);
            SRLgTxtBx.AppendText("*Table entry values");
            if (k >= 82d & k <= 98d)
            {
                // Print Tab(23); "**An error of several miles can occur if K is between 82 and 98 degrees."

                SRLgTxtBx.AppendText(Strings.Space(23) + "**If K is between 82" + '°' + " and 98" + '°' + " this B is interpolated." + Environment.NewLine);
                SRLgTxtBx.AppendText(Strings.Space(25) + "USPS rule:  Discard the sight if K is between 82" + '°' + " and 98" + '°' + Environment.NewLine);
                SRLgTxtBx.AppendText(Strings.Space(36) + " or use Sadler Technique." + Environment.NewLine);
                chkSadler.Visible = true;
            }

            SRLgTxtBx.Refresh();
            SRHdrTxtBx.Refresh();
        }

        public void Display208()
        {
            cmdSave.Visible = false;
            cmdFix.Visible = false; // : 
            cmdFix.Enabled = false;
            cmdFix.Text = "Establish Fix";
            // Me.Font = New Font(Me.Font, "Courier New")

            SRHdrTxtBx.Clear();
            SRHdrTxtBx.Visible = true;
            SRHdrTxtBx.BringToFront();
            SRLgTxtBx.Clear();
            SRLgTxtBx.Visible = true;
            SRLgTxtBx.BringToFront();
            SRLeftTxtBx.Clear();
            SRLeftTxtBx.Visible = false;
            SRLeftTxtBx.SendToBack();
            SRRightTxtBx.Clear();
            SRRightTxtBx.Visible = false;
            SRRightTxtBx.SendToBack();
            NASRAsmTxtBx.Clear();
            NASRAsmTxtBx.Visible = false;
            NASRAsmTxtBx.SendToBack();
            NASRAFTxtBx.Clear();
            NASRAFTxtBx.Visible = false;
            NASRAFTxtBx.SendToBack();
            DCorrTxtBx.Clear();
            DCorrTxtBx.Visible = false;
            DCorrTxtBx.SendToBack();
            WeemsPVTxtBx.Clear();            // V5.6.1
            WeemsPVTxtBx.Visible = false;    // V5.6.1
            WeemsPVTxtBx.SendToBack();   // V5.6.1
            frameNASRUsing.Visible = false;
            frame211.Visible = false;
            frame214.Visible = false;
            Label9.Visible = false;
            frameS.Visible = false;
            GroupBoxPrecision.Visible = false;      // V5.6.1
            chkInterpolateB.Visible = false;
            var argTB = SRHdrTxtBx;
            AlignCenterRTB(ref argTB);
            SRHdrTxtBx = argTB;
            SRHdrTxtBx.AppendText("H.O. 208");
            SRLgTxtBx.AppendText("GHA" + Strings.Space(12 - txtGHADeg.Text.ToString().Length) + Strings.Format(Conversion.Val(txtGHADeg.Text), "##0") + '°' + Strings.Format(Conversion.Val(txtGHAMin.Text), "00.0") + "'");
            SRLgTxtBx.AppendText(Environment.NewLine);
            SRLgTxtBx.AppendText("Asm Lo (");
            if (AsmLo == 0d)
            {
                SignF = " ";
                SRLgTxtBx.AppendText("");
            }

            if (Math.Sign(AsmLo) == 1)
            {
                SRLgTxtBx.AppendText("-");
                SignF = CommonGlobals.g_LongW;
            }

            if (Math.Sign(AsmLo) == -1)
            {
                SRLgTxtBx.AppendText("+");
                SignF = CommonGlobals.g_LongE;
            }

            if (Math.Sign(AsmLo) == 0)
            {
                SRLgTxtBx.AppendText(CommonGlobals.g_StrSpace);
                SignF = " ";
            }

            SRLgTxtBx.AppendText(")" + Strings.Space(4 - AsmLoDeg.ToString().Length) + Strings.Format(AsmLoDeg, "0") + '°' + Strings.Format(AsmLoMin, "00.0") + "'" + SignF);
            SRLgTxtBx.AppendText(Environment.NewLine);
            SRLgTxtBx.AppendText("Asm LHA" + Strings.Space(7 - AsmLHA.ToString().Length) + Strings.Format(AsmLHA, "0") + '°');
            SRLgTxtBx.AppendText(Environment.NewLine);
            T = Conversion.Int(T);
            SRLgTxtBx.AppendText("t" + Strings.Space(14 - T.ToString().Length) + Strings.Format(T, "0") + '°');
            if (LHA <= 180d)
                SRLgTxtBx.AppendText(CommonGlobals.g_LongW);
            if (LHA > 180d)
                SRLgTxtBx.AppendText(CommonGlobals.g_LongE);
            SRLgTxtBx.AppendText(Strings.Space(8) + "d" + Strings.Space(4 - txtDecDeg.Text.ToString().Length) + Strings.Format(Conversion.Val(txtDecDeg.Text), "0") + '°' + Strings.Format(DecMinutes, "00.0") + "'" + cboDec.Text);
            SRLgTxtBx.AppendText(Environment.NewLine);
            AsmL = Conversion.Int(AsmL);
            SRLgTxtBx.AppendText("Asm L " + Strings.Space(9 - AsmL.ToString().Length) + Strings.Format(Math.Abs(AsmL), "#0") + '°' + cboL.Text);
            i = (short)B1Deg.ToString().Length;
            SRLgTxtBx.AppendText(Strings.Space(7) + "b" + Strings.Space(4 - i));
            SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Underline);
            SRLgTxtBx.AppendText(Strings.Format(B1Deg, "0") + '°' + Strings.Format(B1Min, "00.0") + "'");
            SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Regular);
            SRLgTxtBx.AppendText(SignB);
            SRLgTxtBx.AppendText("   ->  ");
            SRLgTxtBx.AppendText("A" + Strings.Space(8 - A2.ToString().Length) + Strings.Format(A2, "0"));
            SRLgTxtBx.AppendText(Strings.Space(11) + "C" + Strings.Space(8 - A4.ToString().Length) + Strings.Format(A4, "0"));
            i = (short)Z1.ToString().Length;
            if (Z1 - Conversion.Int(Z1) == 0d)
            {
                i = (short)(i + 2);
            }

            SRLgTxtBx.AppendText(Strings.Space(11) + "Z'" + Strings.Space(7 - i) + Strings.Format(Math.Abs(Z1), "0.0") + '°' + Strings.Space(1) + SignZ1);
            SRLgTxtBx.AppendText(Environment.NewLine);
            SRLgTxtBx.AppendText(Strings.Space(22) + "d+b" + Strings.Space(4 - A3Deg.ToString().Length) + Strings.Format(A3Deg, "0") + '°' + Strings.Format(A3Min, "00.0") + "'" + SignA3);
            SRLgTxtBx.AppendText("  ->  ");
            i = (short)B2.ToString().Length;
            if (B2 - Conversion.Int(B2) == 0f)
            {
                i = (short)(i + 2);
            }

            SRLgTxtBx.AppendText("B" + Strings.Space(10 - i));
            SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Underline);
            SRLgTxtBx.AppendText(Strings.Format(B2, "0"));
            SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Regular);
            i = (short)B3.ToString().Length;
            if (B3 - Conversion.Int(B3) == 0f)
            {
                i = (short)(i + 2);
            }

            SRLgTxtBx.AppendText(Strings.Space(11) + "D" + Strings.Space(10 - i));
            SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Underline);
            SRLgTxtBx.AppendText(Strings.Format(B3, "0"));
            SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Regular);
            SRLgTxtBx.AppendText(Environment.NewLine);
            SRLgTxtBx.AppendText("Hc");
            if (Hc < 0d)
            {
                SRLgTxtBx.AppendText(Strings.Space(10 - HcDeg.ToString().Length) + "-");
            }
            else
            {
                SRLgTxtBx.AppendText(Strings.Space(10 - HcDeg.ToString().Length) + " ");
            }

            SRLgTxtBx.AppendText(Strings.Space(4 - Strings.Format(HcDeg, "0").Length) + Strings.Format(HcDeg, "0") + '°' + Strings.Format(HcMin, "00.0") + "'");
            SRLgTxtBx.AppendText(Strings.Space(10) + "<-");
            i = (short)A5.ToString().Length;
            if (A5 - Conversion.Int(A5) == 0f)
            {
                i = (short)(i + 2);
            }

            SRLgTxtBx.AppendText(Strings.Space(8) + "A+B" + Strings.Space(10 - i) + Strings.Format(A5, "0"));
            i = (short)A6.ToString().Length;
            if (A6 - Conversion.Int(A6) == 0f)
            {
                i = (short)(i + 2);
            }

            SRLgTxtBx.AppendText(Strings.Space(9) + "C+D" + Strings.Space(10 - i) + Strings.Format(A6, "0"));
            SRLgTxtBx.AppendText(Strings.Space(4) + "->");
            i = (short)Z2.ToString().Length;
            if (Z2 - Conversion.Int(Z2) == 0d)
            {
                i = (short)(i + 2);
            }

            SRLgTxtBx.AppendText(Strings.Space(5) + "Z\"" + Strings.Space(7 - i));
            SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Underline);
            SRLgTxtBx.AppendText(Strings.Format(Math.Abs(Z2), "0.0") + '°');
            SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Regular);
            // If Flag = True And cboL.text = "S" Then Print " N"
            // If Flag = True And cboL.text = "N" Then Print " S"
            // If Flag = False Then Print Spc(1); cboL.text

            SRLgTxtBx.AppendText(Strings.Space(1) + SignZ2);
            SRLgTxtBx.AppendText(Environment.NewLine);
            SRLgTxtBx.AppendText("Ho");
            if (HoinMinutes < 0d)
            {
                SRLgTxtBx.AppendText(Strings.Space(11 - HoDeg.ToString().Length) + "-");
            }
            else
            {
                SRLgTxtBx.AppendText(Strings.Space(11 - HoDeg.ToString().Length) + " ");
            }

            SRLgTxtBx.AppendText(Strings.Space(4 - txtHoDeg.Text.ToString().Length));
            SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Underline);
            SRLgTxtBx.AppendText(Strings.Format(HoDeg, "0") + '°' + Strings.Format(Math.Abs(HoMin), "00.0") + "'");
            SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Regular);
            i = (short)Z.ToString().Length;
            if (Z - Conversion.Int(Z) == 0d)
            {
                i = (short)(i + 2);
            }

            SRLgTxtBx.AppendText(Strings.Space(60) + "Z " + cboL.Text + Strings.Space(7 - i) + Strings.Format(Z, "0.0") + '°');
            if (LHA <= 180d)
                SRLgTxtBx.AppendText(" W");
            if (LHA > 180d)
                SRLgTxtBx.AppendText(" E");
            SRLgTxtBx.AppendText(Environment.NewLine);
            SRLgTxtBx.AppendText("a" + Strings.Space(16 - Conversion.Int(Math.Abs(A)).ToString().Length) + Strings.Format(Conversion.Int(Math.Abs(A) * 10d + 0.5d) / 10d, "0.0") + " nm ");
            PlotOut.PlotIntercept = Strings.Format(Conversion.Int(Math.Abs(A) * 10d + 0.5d) / 10d, "0.0") + " nm ";
            if (Hc < Ho)
            {
                SRLgTxtBx.AppendText("T     Observed greater - Toward");
                PlotOut.PlotIntercept += " Toward";
            }

            if (Hc > Ho)
            {
                SRLgTxtBx.AppendText("A     Computed greater - Away  ");
                PlotOut.PlotIntercept += " Away";
            }

            SRLgTxtBx.AppendText(Strings.Space(23) + "Zn" + Strings.Space(4) + Strings.Format(ZN, "000") + '°');
            PlotOut.PlotAz = Strings.Format(ZN, "000") + '°';
            SRLgTxtBx.AppendText(Environment.NewLine);
            SRLgTxtBx.AppendText(Environment.NewLine);
            var argTB1 = SRLgTxtBx;
            AlignCenterRTB(ref argTB1);
            SRLgTxtBx = argTB1;
            SRLgTxtBx.AppendText("AP/EP L " + Strings.Format(APEstLDeg, "0") + '°' + Strings.Format(APEstLMin, "00.0") + "'");
            if (APEstL > 0d)
                SRLgTxtBx.AppendText(CommonGlobals.g_LatN);
            if (APEstL == 0d)
                SRLgTxtBx.AppendText(CommonGlobals.g_StrSpace);
            if (APEstL < 0d)
                SRLgTxtBx.AppendText(CommonGlobals.g_LatS);
            SRLgTxtBx.AppendText("   AP/EP Lo " + Strings.Format(APEstLoDeg, "0") + '°' + Strings.Format(APEstLoMin, "00.0") + "'");
            if (APEstLo > 0d)
                SRLgTxtBx.AppendText(CommonGlobals.g_LongW);
            if (APEstLo == 0d)
                SRLgTxtBx.AppendText(CommonGlobals.g_StrSpace);
            if (APEstLo < 0d)
                SRLgTxtBx.AppendText(CommonGlobals.g_LongE);
            SRLgTxtBx.AppendText(Environment.NewLine);
            SRLgTxtBx.AppendText("DR-LOP Distance " + Strings.Format(Math.Abs(KPLOPDist), "0.0") + " nm ");
            if (KPLOPDist < 0d)
                SRLgTxtBx.AppendText("T");
            if (KPLOPDist > 0d)
                SRLgTxtBx.AppendText("A");
            if (KPLOPDist == 0d)
                SRLgTxtBx.AppendText(CommonGlobals.g_StrSpace);
            SRLgTxtBx.AppendText(Environment.NewLine);
            SRLgTxtBx.AppendText("   EP L " + Strings.Format(EstLDeg, "0") + '°' + Strings.Format(EstLMin, "00.0") + "'");
            SRLgTxtBx.AppendText("      EP Lo " + Strings.Format(EstLoDeg, "0") + '°' + Strings.Format(EstLoMin, "00.0") + "'");
            SRLgTxtBx.AppendText(Environment.NewLine);
            SRLgTxtBx.Refresh();
            SRHdrTxtBx.Refresh();
        }

        public float Csc211(ref double x)
        {
            float Csc211Ret = default;
            float LclCsc211 = 0f;
            if (x < 0d | x > 180d)
            {
                x = 360d - x;
            }

            LclCsc211 = (float)(100000d * (Math.Log(1d / Math.Sin(x * Pi / 180d)) / Math.Log(10d)));
            if (optCompact.Checked == true & Csc211Ret < 166f | optOriginal.Checked == true & Csc211Ret < 239f)
            {
                LclCsc211 = (float)(Conversion.Int(LclCsc211 * 10f + 0.5d) / 10d);
            }
            else
            {
                LclCsc211 = (float)Conversion.Int(LclCsc211 + 0.5d);
            }

            return LclCsc211;
            return Csc211Ret;
        }

        public float Sec211(ref double x)
        {
            float Sec211Ret = default;
            float LclSec211 = 0f;
            if (x >= 90d & x <= 270d)
            {
                x = x - 180d;
            }

            LclSec211 = (float)(100000d * (Math.Log(1d / Math.Cos(x * Pi / 180d)) / Math.Log(10d)));
            if (optCompact.Checked == true & Sec211Ret < 166f | optOriginal.Checked == true & Sec211Ret < 239f)
            {
                LclSec211 = (float)(Conversion.Int(LclSec211 * 10f + 0.5d) / 10d);
            }
            else
            {
                LclSec211 = (float)Conversion.Int(LclSec211 + 0.5d);
            }

            return LclSec211;
            return Sec211Ret;
        }

        public float CscS(ref double x)
        {
            float LclCscS = 0f;
            if (x > 180d | x < 0d)
            {
                x = 360d - x;
            }

            if (optPepperday.Checked == true & x == 0d)
            {
                LclCscS = 999.999f;
                return LclCscS;
                return default;
            }

            if (optFarley.Checked == true & x == 0d)
            {
                LclCscS = 1000f;
                return LclCscS;
                return default;
            }

            LclCscS = (float)(Math.Log(1d / Math.Sin(x * Pi / 180d)) / Math.Log(10d));
            if (optPepperday.Checked == true)
            {
                LclCscS = (float)(94.2932531d * LclCscS);
            }

            if (optFarley.Checked == true)
            {
                LclCscS = 100f * LclCscS;
            }

            return LclCscS;
            return default;
        }

        public float SecS(ref double x)
        {
            float LclSecS = 0f;
            if (x >= 90d & x <= 270d)
            {
                x = x - 180d;
            }

            LclSecS = (float)(Math.Log(1d / Math.Cos(x * Pi / 180d)) / Math.Log(10d));
            if (optPepperday.Checked == true)
            {
                LclSecS = (float)(94.2932531d * LclSecS);
            }

            if (optFarley.Checked == true)
            {
                LclSecS = 100f * LclSecS;
            }

            return LclSecS;
            return default;
        }

        public void Display214()
        {
            cmdSave.Visible = false;
            cmdFix.Visible = false; // : 
            cmdFix.Enabled = false;
            cmdFix.Text = "Establish Fix";
            // Me.Font = New Font(Me.Font, "Courier New")
            SRHdrTxtBx.Clear();
            SRHdrTxtBx.Visible = true;
            SRHdrTxtBx.BringToFront();
            SRLgTxtBx.Clear();
            SRLgTxtBx.Visible = true;
            SRLgTxtBx.BringToFront();
            SRLeftTxtBx.Clear();
            SRLeftTxtBx.Visible = false;
            SRLeftTxtBx.SendToBack();
            SRRightTxtBx.Clear();
            SRRightTxtBx.Visible = false;
            SRRightTxtBx.SendToBack();
            NASRAsmTxtBx.Clear();
            NASRAsmTxtBx.Visible = false;
            NASRAsmTxtBx.SendToBack();
            NASRAFTxtBx.Clear();
            NASRAFTxtBx.Visible = false;
            NASRAFTxtBx.SendToBack();
            DCorrTxtBx.Clear();
            DCorrTxtBx.Visible = false;
            DCorrTxtBx.SendToBack();
            WeemsPVTxtBx.Clear();            // V5.6.1
            WeemsPVTxtBx.Visible = false;    // V5.6.1
            WeemsPVTxtBx.SendToBack();   // V5.6.1
            frameNASRUsing.Visible = false;
            frame211.Visible = false;
            frame214.Visible = true;
            Label9.Visible = true;
            frameS.Visible = false;
            GroupBoxPrecision.Visible = false;      // V5.6.1
            chkInterpolateB.Visible = false;
            var argTB = SRHdrTxtBx;
            AlignCenterRTB(ref argTB);
            SRHdrTxtBx = argTB;
            SRHdrTxtBx.AppendText("H.O. 214");
            if (optd.Checked == true)
            {
                SRLgTxtBx.AppendText("Calc. of Asm Lo and LHA");
            }

            if (optdt.Checked == true | optdtL.Checked == true)
            {
                SRLgTxtBx.AppendText("   Calc. of Asm LHA");
            }

            SRLgTxtBx.AppendText(Environment.NewLine);
            SRLgTxtBx.AppendText("Tot GHA" + Strings.Space(9 - txtGHADeg.Text.ToString().Length) + Strings.Format(Conversion.Val(txtGHADeg.Text), "##0") + '°' + Strings.Format(Conversion.Val(txtGHAMin.Text), "00.0") + "'");
            SRLgTxtBx.AppendText(Environment.NewLine);
            if (optd.Checked == true)
            {
                SRLgTxtBx.AppendText("Asm Lo (");
                if (AsmLo == 0d)
                {
                    SignA3 = " ";
                    SRLgTxtBx.AppendText("");
                }

                if (Math.Sign(AsmLo) == 1)
                {
                    SRLgTxtBx.AppendText("-");
                    SignA3 = CommonGlobals.g_LongW;
                }

                if (Math.Sign(AsmLo) == -1)
                {
                    SRLgTxtBx.AppendText("+");
                    SignA3 = CommonGlobals.g_LongE;
                }

                if (Math.Sign(AsmLo) == 0)
                {
                    SRLgTxtBx.AppendText(CommonGlobals.g_StrSpace);
                    SignA3 = " ";
                }
            }

            if (optdt.Checked == true | optdtL.Checked == true)
            {
                SRLgTxtBx.AppendText("DR Lo  (");
                if (cboLo.Text == "W")
                    SRLgTxtBx.AppendText("-");
                if (cboLo.Text == "E")
                    SRLgTxtBx.AppendText("+");
            }

            if (optd.Checked == true)
            {
                SRLgTxtBx.AppendText(")" + Strings.Space(6 - AsmLoDeg.ToString().Length) + Strings.Format(AsmLoDeg, "0") + '°' + Strings.Format(AsmLoMin, "00.0") + "'" + SignA3);
            }

            if (optdt.Checked == true | optdtL.Checked == true)
            {
                SRLgTxtBx.AppendText(")" + Strings.Space(6 - txtLoDeg.Text.ToString().Length) + Strings.Format(Conversion.Val(txtLoDeg.Text), "0") + '°' + Strings.Format(Conversion.Val(txtLoMin.Text), "00.0") + "'" + cboLo.Text);
            }

            SRLgTxtBx.AppendText(Constants.vbTab + Constants.vbTab + Constants.vbTab + Constants.vbTab + Constants.vbTab + Constants.vbTab + Constants.vbTab + Constants.vbTab);
            SRLgTxtBx.AppendText(" DEC and LAT ");
            SRLgTxtBx.AppendText(Environment.NewLine);
            if (optd.Checked == true)
            {
                SRLgTxtBx.AppendText("H.A." + Strings.Space(12 - T.ToString().Length) + Strings.Format(T, "0") + '°');
                if (LHA <= 180d)
                    SRLgTxtBx.AppendText(CommonGlobals.g_LongW);
                if (LHA > 180d)
                    SRLgTxtBx.AppendText(CommonGlobals.g_LongE);
            }

            if (optdt.Checked == true | optdtL.Checked == true)
            {
                SRLgTxtBx.AppendText("LHA" + Strings.Space(13 - LHADeg.ToString().Length) + Strings.Format(LHADeg, "#0") + '°' + Strings.Format(LHAMin, "00.0") + "'->" + "H.A. " + Strings.Format(T, "0") + '°');
            }

            SRLgTxtBx.AppendText(Strings.Space(11) + "Dec" + Strings.Space(4 - AsmDecDeg.ToString().Length) + Strings.Format(AsmDecDeg, "#0") + '°' + Strings.Format(AsmDecMin, "00") + "'" + cboDec.Text);
            SRLgTxtBx.AppendText(Strings.Space(13) + "Asm L " + Strings.Space(4 - Strings.Format(AsmL.ToString(), "#0").Length) + Strings.Format(Math.Abs(AsmL), "#0") + '°');
            if (AsmL == 0d)
                SRLgTxtBx.AppendText(CommonGlobals.g_StrSpace);
            if (AsmL != 0d)
                SRLgTxtBx.AppendText(cboL.Text);
            SRLgTxtBx.AppendText(Constants.vbTab + Constants.vbTab);
            if ((cboL.Text ?? "") == (cboDec.Text ?? ""))
            {
                SRLgTxtBx.AppendText("SAME NAME    ");
            }

            if ((cboL.Text ?? "") != (cboDec.Text ?? ""))
            {
                SRLgTxtBx.AppendText("CONTRARY NAME");
            }

            SRLgTxtBx.AppendText(Environment.NewLine);
            SRLgTxtBx.AppendText("Tab Alt. ");
            if (Math.Sign(Hc) == -1)
            {
                SRLgTxtBx.AppendText(Strings.Space(1) + "-");
            }
            else
            {
                SRLgTxtBx.AppendText(Strings.Space(1) + " ");
            }

            SRLgTxtBx.AppendText(Strings.Space(4 - Math.Abs(TabHcDeg).ToString().Length) + Strings.Format(Math.Abs(TabHcDeg), "0") + '°' + Strings.Format(Math.Abs(TabHcMin), "00.0") + "'");
            SRLgTxtBx.AppendText(Strings.Space(8) + "Dec diff " + Strings.Format(Math.Abs(DecIncr), "00.0") + "'");
            SRLgTxtBx.AppendText(Strings.Space(3));
            SRLgTxtBx.SelectionFont = new Font("Symbol", 8f, FontStyle.Regular);
            SRLgTxtBx.AppendText("D"); // this prints a Greek capital delta
            SRLgTxtBx.SelectionFont = new Font("Courier New", 8f, FontStyle.Regular);
            SRLgTxtBx.AppendText("d " + Strings.Format(Math.Abs(D * 100f), "00"));
            SRLgTxtBx.AppendText(Strings.Space(4));
            SRLgTxtBx.SelectionFont = new Font("Symbol", 8f, FontStyle.Regular);
            SRLgTxtBx.AppendText("D"); // this prints a Greek capital delta
            SRLgTxtBx.SelectionFont = new Font("Courier New", 8f, FontStyle.Regular);
            SRLgTxtBx.AppendText("d corr." + Strings.Space(1) + "(" + SignD + ") " + Strings.Space(5 - Strings.Format(d1corr.ToString(), "0.0").Length) + Strings.Format(Math.Abs(d1corr), "0.0") + "'");
            SRLgTxtBx.AppendText(Strings.Space(3) + "Tab Az. " + Strings.Space(5 - Strings.Format(TabZ.ToString(), "0.0").Length) + Strings.Format(TabZ, "0.0") + '°');
            SRLgTxtBx.AppendText(Environment.NewLine);
            SRLgTxtBx.AppendText("Tot corr" + " (" + SignTotcorr + ") " + Strings.Space(6 - Strings.Format(Totcorr.ToString(), "0.0").Length) + Strings.Format(Math.Abs(Totcorr), "0.0") + "'");
            if (optdt.Checked == true | optdtL.Checked == true)
            {
                SRLgTxtBx.AppendText(Strings.Space(11) + "LHA diff " + Strings.Format(LHAdiff, "00.0") + "'");
            }

            if (optdt.Checked == true | optdtL.Checked == true)
            {
                SRLgTxtBx.AppendText(Strings.Space(3));
                SRLgTxtBx.SelectionFont = new Font("Symbol", 8f, FontStyle.Regular);
                SRLgTxtBx.AppendText("D"); // this prints a Greek capital delta
                SRLgTxtBx.SelectionFont = new Font("Courier New", 8f, FontStyle.Regular);
                SRLgTxtBx.AppendText("t " + Strings.Format(Math.Abs(DSD2 * 100d), "00"));
            }

            if (optdt.Checked == true | optdtL.Checked == true)
            {
                i = 73;
                if (Math.Abs(d2corr) < 10d)
                    i = 74;
                SRLgTxtBx.AppendText(Strings.Space(3));
                SRLgTxtBx.SelectionFont = new Font("Symbol", 8f, FontStyle.Regular);
                SRLgTxtBx.AppendText("D"); // this prints a Greek capital delta
                SRLgTxtBx.SelectionFont = new Font("Courier New", 8f, FontStyle.Regular);
                SRLgTxtBx.AppendText("t corr." + Strings.Space(1) + "(" + Signd2corr + ") " + Strings.Space((int)(5d - Conversions.ToDouble(Strings.Format(d2corr.ToString(), "0.0").ToString()))) + Strings.Format(Math.Abs(d2corr), "0.0") + "'");
            }

            SRLgTxtBx.AppendText(Environment.NewLine);
            SRLgTxtBx.AppendText("Hc ");
            if (Math.Sign(TotHc) == -1)
            {
                SRLgTxtBx.AppendText(Strings.Space(7) + "-");
            }
            else
            {
                SRLgTxtBx.AppendText(Strings.Space(7) + " ");
            }

            SRLgTxtBx.AppendText(Strings.Space(4 - Math.Abs(TotHcDeg).ToString().Length) + Strings.Format(Math.Abs(TotHcDeg), "0") + '°' + Strings.Format(Math.Abs(TotHcMin), "00.0") + "'");
            if (optdtL.Checked == true)
            {
                SRLgTxtBx.AppendText(Strings.Space(11) + "L diff   " + Strings.Format(Ldiff, "00.0") + "'");
            }

            if (optdtL.Checked == true)
            {
                SRLgTxtBx.AppendText(Strings.Space(3));
                SRLgTxtBx.SelectionFont = new Font("Symbol", 8f, FontStyle.Regular);
                SRLgTxtBx.AppendText("D"); // this prints a Greek capital delta
                SRLgTxtBx.SelectionFont = new Font("Courier New", 8f, FontStyle.Regular);
                SRLgTxtBx.AppendText("L corr." + Strings.Space(1) + "(" + SignL + ") " + Strings.Space(5 - Strings.Format(Zcorr.ToString(), "0.0").Length) + Strings.Format(Math.Abs(Zcorr), "0.0") + "'");
                SRLgTxtBx.AppendText(Constants.vbTab + Constants.vbTab + Constants.vbTab + Constants.vbTab + Constants.vbTab + Constants.vbTab);
            }
            else
            {
                SRLgTxtBx.AppendText(Constants.vbTab + Constants.vbTab + Constants.vbTab + Constants.vbTab + Constants.vbTab + Constants.vbTab + Constants.vbTab + Constants.vbTab + Constants.vbTab);
            }

            // SRLgTxtBx.AppendText(vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab)
            SRLgTxtBx.AppendText("Z " + cboL.Text + Strings.Space(5 - Strings.Format(Ztot.ToString(), "0.0").Length) + Strings.Format(Math.Abs(Ztot), "0.0") + '°');
            if (LHA <= 180d)
                SRLgTxtBx.AppendText(" W");
            if (LHA > 180d)
                SRLgTxtBx.AppendText(" E");
            SRLgTxtBx.AppendText(Environment.NewLine);
            SRLgTxtBx.AppendText("Ho ");
            if (HoinMinutes < 0d)
            {
                SRLgTxtBx.AppendText(Strings.Space(7) + "-");
            }
            else
            {
                SRLgTxtBx.AppendText(Strings.Space(7) + " ");
            }

            SRLgTxtBx.AppendText(Strings.Space(4 - HoDeg.ToString().Length) + Strings.Format(Math.Abs(HoDeg), "0") + '°' + Strings.Format(Math.Abs(HoMin), "00.0") + "'");
            SRLgTxtBx.AppendText(Strings.Space(34) + "Tot corr" + Strings.Space(1) + "(" + SignTotcorr + ") " + Strings.Space(5 - Strings.Format(Totcorr.ToString(), "0.0").Length) + Strings.Format(Math.Abs(Totcorr), "0.0") + "'");
            SRLgTxtBx.AppendText(Environment.NewLine);
            SRLgTxtBx.AppendText(Strings.Space(13) + "a " + Strings.Space(7 - Conversion.Int(Math.Abs(A)).ToString().Length) + Strings.Format(Conversion.Int(Math.Abs(A) * 10d + 0.5d) / 10d, "0.0") + " miles ");
            PlotOut.PlotIntercept = Strings.Format(Conversion.Int(Math.Abs(A) * 10d + 0.5d) / 10d, "0.0") + " nm ";
            if (A < 0d)
            {
                SRLgTxtBx.AppendText("T  Observed greater - Toward");
                PlotOut.PlotIntercept += " Toward";
            }

            if (A > 0d)
            {
                SRLgTxtBx.AppendText("A  Computed greater - Away");
                PlotOut.PlotIntercept += " Away";
            }

            SRLgTxtBx.AppendText(Constants.vbTab + Constants.vbTab + Constants.vbTab);
            SRLgTxtBx.AppendText("Zn    " + Strings.Format(ZN, "000") + '°');
            PlotOut.PlotAz = Strings.Format(ZN, "000") + '°';
            SRLgTxtBx.AppendText(Environment.NewLine);
            var argTB1 = SRLgTxtBx;
            AlignCenterRTB(ref argTB1);
            SRLgTxtBx = argTB1;
            if (optd.Checked == true)
            {
                SRLgTxtBx.AppendText("Plot LOP from Asm L, Asm Lo");
            }

            if (optdt.Checked == true)
            {
                SRLgTxtBx.AppendText("Plot LOP from Asm L, DR Lo");
            }

            if (optdtL.Checked == true)
            {
                SRLgTxtBx.AppendText("Plot LOP from DR L, DR Lo");
            }

            SRLgTxtBx.AppendText(Environment.NewLine);
            SRLgTxtBx.AppendText(Environment.NewLine);

            // AlignLeftRTB(SRLgTxtBx)

            if (optdtL.Checked == false)
            {
                SRLgTxtBx.AppendText("AP/EP L " + Strings.Format(APEstLDeg, "0") + '°' + Strings.Format(APEstLMin, "00.0") + "'");
                if (APEstL > 0d)
                {
                    SRLgTxtBx.AppendText(CommonGlobals.g_LatN);
                }

                if (APEstL == 0d)
                {
                    SRLgTxtBx.AppendText(CommonGlobals.g_StrSpace);
                }

                if (APEstL < 0d)
                {
                    SRLgTxtBx.AppendText(CommonGlobals.g_LatS);
                }

                SRLgTxtBx.AppendText("   AP/EP Lo " + Strings.Format(APEstLoDeg, "0") + '°' + Strings.Format(APEstLoMin, "00.0") + "'");
                if (APEstLo > 0d)
                {
                    SRLgTxtBx.AppendText(CommonGlobals.g_LongW);
                }

                if (APEstLo == 0d)
                {
                    SRLgTxtBx.AppendText(CommonGlobals.g_StrSpace);
                }

                if (APEstLo < 0d)
                {
                    SRLgTxtBx.AppendText(CommonGlobals.g_LongE);
                }

                SRLgTxtBx.AppendText(Environment.NewLine);
                SRLgTxtBx.AppendText("DR-LOP Distance " + Strings.Format(Math.Abs(KPLOPDist), "0.0") + " nm ");
                if (KPLOPDist < 0d)
                    SRLgTxtBx.AppendText("T");
                if (KPLOPDist > 0d)
                    SRLgTxtBx.AppendText("A");
                if (KPLOPDist == 0d)
                    SRLgTxtBx.AppendText(CommonGlobals.g_StrSpace);
                SRLgTxtBx.AppendText(Environment.NewLine);
            }

            SRLgTxtBx.AppendText("   EP L " + Strings.Format(EstLDeg, "0") + '°' + Strings.Format(EstLMin, "00.0") + "'");
            SRLgTxtBx.AppendText("      EP Lo " + Strings.Format(EstLoDeg, "0") + '°' + Strings.Format(EstLoMin, "00.0") + "'");
            SRLgTxtBx.AppendText(Environment.NewLine);
            SRLgTxtBx.Refresh();
        }

        public void HO214()
        {
            LHA = GHA - Lo;
            if (LHA >= 360d)
                LHA = LHA - 360d;
            if (LHA < 0d)
                LHA = LHA + 360d;
            if (LHA <= 180d)
                T = LHA; // W           'T is H.A.
            if (LHA > 180d)
                T = 360d - LHA; // E
                                // tDeg = Int(T)
                                // tMin = (T - tDeg) * 60
                                // tMin = Int(tMin + 0.50000001)
            T = Conversion.Int(T + 0.5d);
            AsmLHA = Conversion.Int(LHA + 0.5d);
            if (AsmLHA == 360d)
                AsmLHA = 0d;
            GHAAsmDeg = (short)Conversion.Val(txtGHADeg.Text);
            GHAAsmMin = (short)Conversion.Val(txtGHAMin.Text);
            GHAAsm = GHAAsmDeg + GHAAsmMin / 60d; // in degrees
                                                  // If Lo >= 0 Then AsmLo = GHAAsm - AsmLHA Else AsmLo = -(AsmLHA - GHAAsm) 'AsmLoDeg = Val(txtLoDeg.Text)
            AsmLo = GHAAsm - AsmLHA;
            // If AsmLo >= 360 Then AsmLo = AsmLo - 360
            if (Math.Abs(AsmLo) < 180d)
                AsmLo = 360d - Math.Abs(AsmLo);
            if (Math.Abs(AsmLo) >= 180d & Lo >= 0d)
                AsmLo = 360d - Math.Abs(AsmLo);
            if (Math.Abs(AsmLo) >= 180d & Lo < 0d)
                AsmLo = -(360d - Math.Abs(AsmLo));
            // If Abs(AsmLo) >= 180 Then AsmLo = -(360 - Abs(AsmLo))
            // If AsmLo < 0 And Lo >= 0 Then AsmLo = AsmLo + 360
            AsmLoDeg = (short)Conversion.Int(Math.Abs(AsmLo));
            if (AsmLo > 0d | txtLoDeg.Text == "180")
                AsmLoMin = (float)Conversion.Val(txtGHAMin.Text);
            else
                AsmLoMin = (float)(60d - Conversion.Val(txtGHAMin.Text));
            if (AsmLoMin == 60f)
                AsmLoMin = 0f;
            AsmL = Conversion.Int(L + 0.5d);
            AsmDec = (float)(Conversion.Int(Math.Abs(Dec) * 2d + 0.5d) / 2d);
            if (Math.Abs(Dec) > 29.5d & Math.Abs(Dec) < 31d)
                AsmDec = 30f;
            if (Math.Abs(Dec) >= 31d & Math.Abs(Dec) < 33d)
                AsmDec = 32f;
            if (Math.Abs(Dec) >= 33d & Math.Abs(Dec) < 34.25d)
                AsmDec = 34f;
            if (Math.Abs(Dec) >= 34.25d & Math.Abs(Dec) < 35d)
                AsmDec = 34.5f;
            if (Math.Abs(Dec) >= 35d & Math.Abs(Dec) < 35.75d)
                AsmDec = 35.5f;
            if (Math.Abs(Dec) >= 35.5d & Math.Abs(Dec) < 36.5d)
                AsmDec = 36f;
            if (Math.Abs(Dec) >= 36d & Math.Abs(Dec) < 37.75d)
                AsmDec = 37f;
            if (Math.Abs(Dec) >= 37.75d & Math.Abs(Dec) < 39.25d)
                AsmDec = 38.5f;
            if (Math.Abs(Dec) >= 39.25d & Math.Abs(Dec) < 41d)
                AsmDec = 40f;
            if (Math.Abs(Dec) >= 41d & Math.Abs(Dec) < 42.25d)
                AsmDec = 42f;
            if (Math.Abs(Dec) >= 42.25d & Math.Abs(Dec) < 44d)
                AsmDec = 43f;
            if (Math.Abs(Dec) >= 44d & Math.Abs(Dec) < 45.5d)
                AsmDec = 45f;
            if (Math.Abs(Dec) >= 45.5d & Math.Abs(Dec) < 46.5d)
                AsmDec = 46f;
            if (Math.Abs(Dec) >= 46.5d & Math.Abs(Dec) < 47.75d)
                AsmDec = 47f;
            if (Math.Abs(Dec) >= 47.75d & Math.Abs(Dec) < 49d)
                AsmDec = 48.5f;
            if (Math.Abs(Dec) >= 49d & Math.Abs(Dec) < 50d)
                AsmDec = 49.5f;
            if (Math.Abs(Dec) >= 50d & Math.Abs(Dec) < 51d)
                AsmDec = 50.5f;
            if (Math.Abs(Dec) >= 51d & Math.Abs(Dec) < 52d)
                AsmDec = 51.5f;
            if (Math.Abs(Dec) >= 52d & Math.Abs(Dec) < 53.25d)
                AsmDec = 52.5f;
            if (Math.Abs(Dec) >= 53.25d & Math.Abs(Dec) < 54.25d)
                AsmDec = 54f;
            if (Math.Abs(Dec) >= 54.25d & Math.Abs(Dec) < 54.75d)
                AsmDec = 54.5f;
            if (Math.Abs(Dec) >= 54.75d & Math.Abs(Dec) < 55.5d)
                AsmDec = 55f;
            if (Math.Abs(Dec) >= 55.5d & Math.Abs(Dec) < 56.25d)
                AsmDec = 56f;
            if (Math.Abs(Dec) >= 56.25d & Math.Abs(Dec) < 56.75d)
                AsmDec = 56.5f;
            if (Math.Abs(Dec) >= 56.75d & Math.Abs(Dec) < 57.25d)
                AsmDec = 57f;
            if (Math.Abs(Dec) >= 57.25d & Math.Abs(Dec) < 58.25d)
                AsmDec = 57.5f;
            if (Math.Abs(Dec) >= 58.25d & Math.Abs(Dec) < 59.25d)
                AsmDec = 59f;
            if (Math.Abs(Dec) >= 59.25d & Math.Abs(Dec) < 59.75d)
                AsmDec = 59.5f;
            if (Math.Abs(Dec) >= 59.75d & Math.Abs(Dec) < 60.25d)
                AsmDec = 60f;
            if (Math.Abs(Dec) >= 60.25d & Math.Abs(Dec) < 61.25d)
                AsmDec = 60.5f;
            if (Math.Abs(Dec) >= 61.25d & Math.Abs(Dec) < 62.25d)
                AsmDec = 62f;
            if (Math.Abs(Dec) >= 62.25d & Math.Abs(Dec) < 62.75d)
                AsmDec = 62.5f;
            if (Math.Abs(Dec) >= 62.75d & Math.Abs(Dec) < 66d)
                AsmDec = 63f;
            if (Math.Abs(Dec) >= 66d & Math.Abs(Dec) < 69.25d)
                AsmDec = 69f;
            if (Math.Abs(Dec) >= 69.25d & Math.Abs(Dec) < 72d)
                AsmDec = 69.5f;
            if (Math.Abs(Dec) >= 72d)
                AsmDec = 74.5f;
            AsmDecDeg = (short)Conversion.Int(AsmDec);
            AsmDecMin = (AsmDec - AsmDecDeg) * 60f;
            DecIncr = (float)((Math.Abs(Dec) - AsmDec) * 60d); // this is really Dec diff for HO214
            DecIncr = (float)(Conversion.Int(DecIncr * 10f + 0.5d) / 10d);
            LHAdiff = (float)Math.Abs((LHA - AsmLHA) * 60d);
            Ldiff = (float)Math.Abs((L - AsmL) * 60d);
            Ldiff = (float)(Conversion.Int(Ldiff * 10f + 0.5d) / 10d);
            if (cboDec.Text == "S" & cboL.Text == "N" | cboDec.Text == "N" & cboL.Text == "S")
            {
                AsmDec = -AsmDec;
                DE = -DE;
            } // : SignDE$ = "-" 'sign of Dec was already set in DecimalDegrees

            // Hc is altitude for Asm L, Asm Dec, Asm LHA
            Hc = Math.Cos(AsmLHA * Pi / 180d) * Math.Cos(Math.Abs(AsmL) * Pi / 180d) * Math.Cos(AsmDec * Pi / 180d) + Math.Sin(Math.Abs(AsmL) * Pi / 180d) * Math.Sin(AsmDec * Pi / 180d);
            if (Math.Abs(Hc) >= 1d)
                Hc = Math.Sign(Hc) * Pi / 2d;
            else
                Hc = Math.Atan(Hc / Math.Sqrt(-Hc * Hc + 1d)); // arcsine
            Hc = Hc * 180d / Pi;
            TabHcDeg = (short)Conversion.Fix(Hc); // was Int
            TabHcMin = Hc - TabHcDeg;
            TabHcMin = Conversion.Int(60d * TabHcMin * 10d + 0.5d) / 10d;

            // The next group is for determining delta d

            i = 1;
            if (AsmDec < 0f)
                i = -1;
            NextHcdP = Math.Cos(AsmLHA * Pi / 180d) * Math.Cos(Math.Abs(AsmL) * Pi / 180d) * Math.Cos((AsmDec + i / 60d) * Pi / 180d) + Math.Sin(Math.Abs(AsmL) * Pi / 180d) * Math.Sin((AsmDec + i / 60d) * Pi / 180d);
            if (Math.Abs(NextHcdP) >= 1d)
                NextHcdP = Math.Sign(NextHcdP) * Pi / 2d;
            else
                NextHcdP = Math.Atan(NextHcdP / Math.Sqrt(-NextHcdP * NextHcdP + 1d)); // arcsine
            NextHcdP = NextHcdP * 180d / Pi;
            i = -1;
            if (AsmDec < 0f)
                i = 1;
            NextHcdM = Math.Cos(AsmLHA * Pi / 180d) * Math.Cos(Math.Abs(AsmL) * Pi / 180d) * Math.Cos((AsmDec + i / 60d) * Pi / 180d) + Math.Sin(Math.Abs(AsmL) * Pi / 180d) * Math.Sin((AsmDec + i / 60d) * Pi / 180d);
            if (Math.Abs(NextHcdM) >= 1d)
                NextHcdM = Math.Sign(NextHcdM) * Pi / 2d;
            else
                NextHcdM = Math.Atan(NextHcdM / Math.Sqrt(-NextHcdM * NextHcdM + 1d)); // arcsine
            NextHcdM = NextHcdM * 180d / Pi;

            // NextHcDSD1 is altitude for Asm L, Asm LHA, actual Dec
            NextHcDSD1 = Math.Cos(AsmLHA * Pi / 180d) * Math.Cos(Math.Abs(AsmL) * Pi / 180d) * Math.Cos(DE * Pi / 180d) + Math.Sin(Math.Abs(AsmL) * Pi / 180d) * Math.Sin(DE * Pi / 180d);
            if (Math.Abs(NextHcDSD1) >= 1d)
                NextHcDSD1 = Math.Sign(NextHcDSD1) * Pi / 2d;
            else
                NextHcDSD1 = Math.Atan(NextHcDSD1 / Math.Sqrt(-NextHcDSD1 * NextHcDSD1 + 1d)); // arcsine
            NextHcDSD1 = NextHcDSD1 * 180d / Pi;
            D = (float)((NextHcdP - NextHcdM) / (2d / 60d)); // D is delta d, d1corr is delta d corr
            D = (float)(Conversion.Int(Math.Abs(D) * 100f + 0.5d) / 100d);
            SignD = "+"; // : If Sgn(D) = -1 Then SignD$ = "-"
                         // d1corr = Abs(DecIncr * D)                                                  'This is the the mathematically correct delta d corr
            i = 0;
            d1corr = 0f;
            if (Math.Abs(DecIncr) > 30.9d)
                i = 30; // This and next lines emulate multiplication table.  This lineif DecDiff >30.9'
            d1corr = (float)(Conversion.Int(i * D * 10f + 0.50001d) / 10d); // This line for units of DecDiff from 1' to 30'
            d1corr = (float)(d1corr + Conversion.Int(Conversion.Int(Math.Abs(DecIncr) - i) * D * 10f + 0.50001d) / 10d); // This line for tenths of DecDiff
            d1corr = (float)(d1corr + Conversion.Int((Math.Abs(DecIncr) - Conversion.Int(Math.Abs(DecIncr))) * D * 10f + 0.5d) / 10d);
            d1corr = (float)(Conversion.Int(d1corr * 10f + 0.5d) / 10d);
            if (Hc > NextHcDSD1)
            {
                d1corr = -d1corr;
                SignD = "-";
            }

            // the next group is for determining delta t
            i = 1;
            if (LHA > 180d)
                i = -1; // this seems to help
            NextHctP = Math.Cos((AsmLHA + i) * Pi / 180d) * Math.Cos(Math.Abs(AsmL) * Pi / 180d) * Math.Cos(AsmDec * Pi / 180d) + Math.Sin(Math.Abs(AsmL) * Pi / 180d) * Math.Sin(AsmDec * Pi / 180d);
            if (Math.Abs(NextHctP) >= 1d)
                NextHctP = Math.Sign(NextHctP) * Pi / 2d;
            else
                NextHctP = Math.Atan(NextHctP / Math.Sqrt(-NextHctP * NextHctP + 1d)); // arcsine
            NextHctP = NextHctP * 180d / Pi;
            NextHcDSD2 = Math.Cos(LHA * Pi / 180d) * Math.Cos(Math.Abs(AsmL) * Pi / 180d) * Math.Cos(AsmDec * Pi / 180d) + Math.Sin(Math.Abs(AsmL) * Pi / 180d) * Math.Sin(AsmDec * Pi / 180d);
            if (Math.Abs(NextHcDSD2) >= 1d)
                NextHcDSD2 = Math.Sign(NextHcDSD2) * Pi / 2d;
            else
                NextHcDSD2 = Math.Atan(NextHcDSD2 / Math.Sqrt(-NextHcDSD2 * NextHcDSD2 + 1d)); // arcsine
            NextHcDSD2 = NextHcDSD2 * 180d / Pi;
            DSD2 = 0d;
            d2corr = 0d; // d2corr is delta t corr
            if (optdt.Checked == true | optdtL.Checked == true)
            {
                DSD2 = NextHctP - Hc; // this is delta t
                DSD2 = Conversion.Int(Math.Abs(DSD2) * 100d + 0.5d) / 100d;
                Signd2corr = "+"; // : If Sgn(DSD2) = -1 Then Signd2corr$ = "-"
                                  // d2corr = 0: If optdt.Value = True Or optdtL.Value = True Then d2corr = Abs(LHAdiff * DSD2)     'this is the mathematically correct delta t corr
                if (optdt.Checked == true | optdtL.Checked == true)
                {
                    d2corr = Conversion.Int(Conversion.Int(Math.Abs(LHAdiff)) * DSD2 * 10d + 0.5d) / 10d; // this and next line emulate multiplication table
                    d2corr = d2corr + Conversion.Int((Math.Abs(LHAdiff) - Conversion.Int(Math.Abs(LHAdiff))) * DSD2 * 10d + 0.5d) / 10d;
                }

                d2corr = Conversion.Int(d2corr * 10d + 0.5d) / 10d;
                if (Hc > NextHcDSD2)
                {
                    d2corr = -d2corr;
                    Signd2corr = "-";
                }
            }

            L4 = Math.Sin(AsmDec * Pi / 180d);
            L5 = Math.Sin(Math.Abs(AsmL) * Pi / 180d) * Math.Sin(Hc * Pi / 180d);
            L6 = L4 - L5;
            L7 = Math.Cos(Math.Abs(AsmL) * Pi / 180d) * Math.Cos(Hc * Pi / 180d);
            L8 = L6 / L7;
            // If Abs(L8) - 1 < 0.000000000001 Then L8 = 0
            if (Math.Abs(L8) >= 1d)
                Z = Pi;
            else
                Z = Math.Atan(-L8 / Math.Sqrt(-L8 * L8 + 1d)) + Pi / 2d; // arccosine
            Z = Z * 180d / Pi;
            TabZ = (float)(Conversion.Int(Z * 10d + 0.5d) / 10d);
            Ztot = TabZ;

            // If L > 0 And LHA > 180 Then ZN = Ztot
            // If L > 0 And LHA <= 180 Then ZN = 360 - Ztot
            // If L <= 0 And LHA > 180 Then ZN = 180 - Ztot
            // If L <= 0 And LHA <= 180 Then ZN = 180 + Ztot
            if (cboL.Text == "N" & LHA > 180d)
                ZN = Ztot;
            if (cboL.Text == "N" & LHA <= 180d)
                ZN = 360d - Ztot;
            if (cboL.Text == "S" & LHA > 180d)
                ZN = 180d - Ztot;
            if (cboL.Text == "S" & LHA <= 180d)
                ZN = 180d + Ztot;
            Zcorr = 0f; // Zcorr is delta L corr
            if (optdtL.Checked == true)
            {
                Zcorr1 = Math.Abs(Math.Cos(ZN * Pi / 180d)); // cos(ZN) is the same as cos(TabZ rounded to whole degrees)
                                                             // Zcorr = Zcorr * Ldiff                 'this is the mathematically correct delta L corr
                Zcorr = (float)(Conversion.Int(Conversion.Int(Math.Abs(Ldiff)) * Zcorr1 * 10d + 0.5d) / 10d); // this and next line emulate multiplication table
                Zcorr = (float)(Zcorr + Conversion.Int((Math.Abs(Ldiff) - Conversion.Int(Math.Abs(Ldiff))) * Zcorr1 * 10d + 0.5d) / 10d);
                Zcorr = (float)(Conversion.Int(Zcorr * 10f + 0.5d) / 10d);
                SignL = "+";
                if (Math.Abs(L) > Math.Abs(AsmL) & TabZ > 90f)
                {
                    Zcorr = -Zcorr;
                    SignL = "-";
                }

                if (Math.Abs(L) < Math.Abs(AsmL) & TabZ < 90f)
                {
                    Zcorr = -Zcorr;
                    SignL = "-";
                }
            }

            ZN = Conversion.Int(ZN + 0.5d); // added in V4.0.0
            Totcorr = (float)(d1corr + d2corr + Zcorr);
            SignTotcorr = "+";
            if (Totcorr < 0f)
                SignTotcorr = "-";
            TotHc = (TabHcDeg * 60 + TabHcMin + Totcorr) / 60d;
            TotHcDeg = (short)Conversion.Fix(TotHc);
            Htot = TotHc; // was Int
            TotHcMin = TotHc - TotHcDeg;
            TotHcMin = Conversion.Int(600d * TotHcMin + 0.5d) / 10d;
            if (TotHcMin == 60d)
            {
                TotHcMin = 0d;
                TotHcDeg = (short)(TotHcDeg + 1);
            }

            A = 60 * TotHcDeg + TotHcMin - (60 * HoDeg + HoMin);
        }

        public void Sadler()
        {
            if (L == 0d)
                L = 0.000000000000001d; // Prevents divide-by-zero error if latitude is 0º
            frame211.Visible = false;
            Flag = false; // Part of avoiding divide-by-zero errors
            LHA = GHA - Lo;
            if (LHA >= 360d)
                LHA = LHA - 360d;
            if (LHA < 0d)
                LHA = LHA + 360d;
            if (LHA <= 180d)
                T = LHA; // W
            if (LHA > 180d)
                T = 360d - LHA; // E
            tDeg = (short)Conversion.Int(T);
            tMin = (T - tDeg) * 60d;
            if (optCompact.Checked == true)
                tMin = Conversion.Int(tMin + 0.50000001d);
            if (optOriginal.Checked == true)
                tMin = Conversion.Int(2d * tMin + 0.5d) / 2d;
            if (tMin == 60d)
            {
                tMin = 0d;
                tDeg = (short)(tDeg + 1);
            }

            tDecimal = tDeg + tMin / 60d; // : If tDecimal = 0 Then tDecimal = 0.00000001
            if (optCompact.Checked == true & tDecimal == 0d)
            {
                ErrorMsgBox("For Compact H.O. 211 without interpolation, meridian angle t must be at least 0.5'.");
                Flag = true;
                return;
            }

            if (optOriginal.Checked == true & tDecimal == 0d)
            {
                ErrorMsgBox("For Original H.O. 211 without interpolation, meridian angle t must be at least 0.3'.");
                Flag = true;
                return;
            }

            if (optCompact.Checked == true & tDecimal == 90d)
            {
                ErrorMsgBox("For Sadler Technique using Compact H.O. 211 without interpolation, meridian angle t must be at least 0.5' away from 90º.");
                cmd211_Click(cmd211, new EventArgs());
                Flag = true;
                return;
            }

            if (optOriginal.Checked == true & tDecimal == 90d)
            {
                ErrorMsgBox("For Sadler Technique using Original H.O. 211 without interpolation, meridian angle t must be at least 0.3' away from 90º.");
                cmd211_Click(cmd211, new EventArgs());
                Flag = true;
                return;
            }

            B1 = Sec211(ref tDecimal);
            if (optCompact.Checked == true & B1 < 166d | optOriginal.Checked == true & B1 < 239d)
                B1 = Conversion.Int(10d * A1 + 0.5d) / 10d;
            else
                B1 = Conversion.Int(B1 + 0.5d);
            A1 = Csc211(ref tDecimal);
            if (optCompact.Checked == true & A1 < 166d | optOriginal.Checked == true & A1 < 239d)
                A1 = Conversion.Int(10d * A1 + 0.5d) / 10d;
            else
                A1 = Conversion.Int(A1 + 0.5d);
            DecDecimal = Conversion.Val(txtDecDeg.Text) + DecMinutes / 60d;
            if (optCompact.Checked == true & DecDecimal == 0d)
            {
                ErrorMsgBox("For Compact H.O. 211 without interpolation, Dec must be at least 0.5'.");
                Flag = true;
                return;
            }

            if (optOriginal.Checked == true & DecDecimal == 0d)
            {
                ErrorMsgBox("For Original H.O. 211 without interpolation, Dec must be at least 0.3'.");
                Flag = true;
                return;
            }

            frame211.Visible = true;
            A2 = Csc211(ref DecDecimal);
            if (optCompact.Checked == true & A2 < 166f | optOriginal.Checked == true & A2 < 239f)
                A2 = (float)(Conversion.Int(10f * A2 + 0.5d) / 10d);
            else
                A2 = (float)Conversion.Int(A2 + 0.5d);
            B2 = Sec211(ref DecDecimal);
            if (optCompact.Checked == true & B2 < 166f | optOriginal.Checked == true & B2 < 239f)
                B2 = (float)(Conversion.Int(10f * B2 + 0.5d) / 10d);
            else
                B2 = (float)Conversion.Int(B2 + 0.5d);
            float localCsc211() { double argx = Math.Abs(L); var ret = Csc211(ref argx); return ret; }

            A3 = localCsc211();
            if (optCompact.Checked == true & A3 < 166f | optOriginal.Checked == true & A3 < 239f)
                A3 = (float)(Conversion.Int(10f * A3 + 0.5d) / 10d);
            else
                A3 = (float)Conversion.Int(A3 + 0.5d);
            float localSec211() { double argx = Math.Abs(L); var ret = Sec211(ref argx); return ret; }

            B3 = localSec211();
            if (optCompact.Checked == true & B3 < 166f | optOriginal.Checked == true & B3 < 239f)
                B3 = (float)(Conversion.Int(10f * B3 + 0.5d) / 10d);
            else
                B3 = (float)Conversion.Int(B3 + 0.5d);
            A4 = A2 + A3;
            A4 = (float)(Conversion.Int(A4 * 10f + 0.5d) / 10d); // is this line necessary?
            L1 = 1d / Math.Pow(10d, A4 / 100000f); // L1 is h1
            if (L1 == 1d)
                L1 = Pi / 2d;
            else
                L1 = Math.Atan(L1 / Math.Sqrt(-L1 * L1 + 1d) + 9.999999E-21d); // arcsin
            L1 = L1 * 180d / Pi;
            if ((cboL.Text ?? "") != (cboDec.Text ?? ""))
                L1 = -L1;
            h1Deg = (short)Conversion.Int(Math.Abs(L1));
            h1Min = (Math.Abs(L1) - h1Deg) * 60d;
            if (optCompact.Checked == true)
                h1Min = Conversion.Int(h1Min + 0.5d);
            if (optOriginal.Checked == true)
                h1Min = Conversion.Int(2d * h1Min + 0.5d) / 2d;
            if (h1Min >= 60d)
            {
                h1Min = h1Min - 60d;
                h1Deg = (short)(h1Deg + 1);
            }

            L2 = L1 + Ho; // h1 + Ho
            L2Deg = (short)Conversion.Int(Math.Abs(L2));
            L2Min = (Math.Abs(L2) - L2Deg) * 60d;
            if (L2Min >= 60d)
            {
                L2Min = L2Min - 60d;
                L2Deg = (short)(L2Deg + 1);
            }

            L3 = L2 / 2d; // (h1 + Ho)/2
            L3Deg = (short)Conversion.Int(Math.Abs(L3));
            L3Min = (Math.Abs(L3) - L3Deg) * 60d;
            if (optCompact.Checked == true)
                L3Min = Conversion.Int(L3Min + 0.5d);
            if (optOriginal.Checked == true)
                L3Min = Conversion.Int(L3Min * 10d + 0.5d) / 10d;
            if (L3Min >= 60d)
            {
                L3Min = L3Min - 60d;
                L3Deg = (short)(L3Deg + 1);
            }

            B4 = Sec211(ref L3);
            A5 = (float)(B1 + B2 + B3 - B4);
            L4 = 1d / Math.Pow(10d, A5 / 100000f); // L4 is h2
            if (L4 == 1d)
                L4 = Pi / 2d;
            else
                L4 = Math.Atan(L4 / Math.Sqrt(-L4 * L4 + 1d) + 9.999999E-21d); // arcsin
            L4 = L4 * 180d / Pi;
            if (T < 90d)
                L4 = Math.Abs(L4);
            if (T > 90d)
                L4 = -Math.Abs(L4);
            if (T == 90d)
                L4 = 0d;
            h2Deg = (short)Conversion.Int(L4);
            h2Min = (L4 - h2Deg) * 60d;
            if (optCompact.Checked == true)
                h2Min = Conversion.Int(h2Min + 0.5d);
            if (optOriginal.Checked == true)
                h2Min = Conversion.Int(2d * h2Min + 0.5d) / 2d;
            if (h2Min >= 60d)
            {
                h2Min = h2Min - 60d;
                h2Deg = (short)(h2Deg + 1);
            }

            Hc = h1Deg + h2Deg + (h1Min + h2Min) / 60d; // h1 + h2
            HcDeg = (short)Conversion.Int(Hc);
            HcMin = (Hc - HcDeg) * 60d;
            if (HcMin >= 60d)
            {
                HcMin = HcMin - 60d;
                HcDeg = (short)(HcDeg + 1);
            }

            B5 = Sec211(ref Hc);
            if (L1 + L4 < 0d)
                Hc = -Hc;
            Ho = Conversion.Val(txtHoDeg.Text) + Conversion.Val(txtHoMin.Text) / 60d;
            HoDeg = (short)Conversion.Val(txtHoDeg.Text);
            HoMin = Conversion.Val(txtHoMin.Text);
            if (optCompact.Checked == true)
                HoMin = Conversion.Int(HoMin + 0.5d);
            if (optOriginal.Checked == true)
                HoMin = Conversion.Int(HoMin * 10d + 0.5d) / 10d;
            A = Math.Sign(Hc) * (60 * HcDeg + HcMin) - (60 * HoDeg + HoMin);
            if (HoinMinutes < 0d)
                A = 60 * HcDeg + HcMin + (60 * HoDeg + HoMin);
            if (optCompact.Checked == true & B5 < 166f | optOriginal.Checked == true & B5 < 239f)
                B5 = (float)(Conversion.Int(10f * B5 + 0.5d) / 10d);
            else
                B5 = (float)Conversion.Int(B5 + 0.5d);
            A6 = (float)(A1 + B2 - B5);
            if (A6 <= 0f)
            {
                A6 = 0f;
                Z = 90d;
            } // When the body is near or on the Prime Vertical, A7 may be negative.  Use zero for A7 and Z will be 90 degrees.

            if (A6 != 0f)
            {
                Z = 1d / Math.Pow(10d, A6 / 100000f);
                Z = Math.Atan(Z / Math.Sqrt(-Z * Z + 1d) + 9.999999E-21d); // arcsin
                Z = Z * 180d / Pi;
            }

            A6 = (float)(Conversion.Int(A6 * 10f + 0.5d) / 10d); // this line was necessary for low value of A7
            if ((cboDec.Text ?? "") == (cboL.Text ?? "") & k > L)
                Z = Z;
            else
                Z = 180d - Z;
            ZDeg = (short)Conversion.Int(Z);
            ZMin = (Z - ZDeg) * 60d;
            // If optCompact = True Then Z = Int(Z + 0.5)  'For Z in whole degrees
            if (optCompact.Checked == true)
                ZMin = Conversion.Int(ZMin + 0.5d);
            if (optOriginal.Checked == true)
                ZMin = Conversion.Int(2d * ZMin + 0.5d) / 2d;
            if (cboL.Text == "N" & LHA > 180d)
                ZN = Z;
            if (cboL.Text == "N" & LHA <= 180d)
                ZN = 360d - Z;
            if (cboL.Text == "S" & LHA > 180d)
                ZN = 180d - Z;
            if (cboL.Text == "S" & LHA <= 180d)
                ZN = 180d + Z;

            // If cboL.text = "S" Then L = -L

        }

        public void DisplaySadler()
        {
            cmdSave.Visible = false;
            cmdFix.Visible = false; // : 
            cmdFix.Enabled = false;
            cmdFix.Text = "Establish Fix";
            // Me.Font = New Font(Me.Font, "Courier New")
            SRHdrTxtBx.Clear();
            SRHdrTxtBx.Visible = true;
            SRHdrTxtBx.BringToFront();
            SRLgTxtBx.Clear();
            SRLgTxtBx.Visible = true;
            SRLgTxtBx.BringToFront();
            SRLeftTxtBx.Clear();
            SRLeftTxtBx.Visible = false;
            SRLeftTxtBx.SendToBack();
            SRRightTxtBx.Clear();
            SRRightTxtBx.Visible = false;
            SRRightTxtBx.SendToBack();
            NASRAsmTxtBx.Clear();
            NASRAsmTxtBx.Visible = false;
            NASRAsmTxtBx.SendToBack();
            NASRAFTxtBx.Clear();
            NASRAFTxtBx.Visible = false;
            NASRAFTxtBx.SendToBack();
            DCorrTxtBx.Clear();
            DCorrTxtBx.Visible = false;
            DCorrTxtBx.SendToBack();
            WeemsPVTxtBx.Clear();            // V5.6.1
            WeemsPVTxtBx.Visible = false;    // V5.6.1
            WeemsPVTxtBx.SendToBack();   // V5.6.1
            frameNASRUsing.Visible = false;
            // frame211.Visible = True        'moved to HO211 so it doesn't appear if LHA or Dec are near zero
            frame214.Visible = false;
            Label9.Visible = false;
            frameS.Visible = false;
            GroupBoxPrecision.Visible = false;      // V5.6.1
            chkInterpolateB.Visible = false;
            var argTB = SRHdrTxtBx;
            AlignCenterRTB(ref argTB);
            SRHdrTxtBx = argTB;
            SRHdrTxtBx.AppendText("INTERCEPT and AZIMUTH by SADLER'S TECHNIQUE (H.O. 211)");
            if (optCompact.Checked == true)
            {
                SRLgTxtBx.AppendText("t*" + Strings.Space(12 - Strings.Format(tDeg.ToString(), "0").Length) + Strings.Format(tDeg.ToString(), "0") + '°' + Strings.Format(tMin.ToString(), "00") + "'");
            }

            if (optOriginal.Checked == true)
            {
                SRLgTxtBx.AppendText("t*" + Strings.Space(12 - Strings.Format(tDeg.ToString(), "0").Length) + Strings.Format(tDeg, "0") + '°' + Strings.Format(tMin, "00.0") + "'");
            }

            if (LHA <= 180d)
            {
                SRLgTxtBx.AppendText(CommonGlobals.g_LongW);
            }

            if (LHA > 180d)
            {
                SRLgTxtBx.AppendText(CommonGlobals.g_LongE);
            }

            SRLgTxtBx.AppendText(" -> -> -> -> -> -> -> -> ");
            if (optCompact.Checked == true & B1 < 166d | optOriginal.Checked == true & B1 < 239d)
            {
                SRLgTxtBx.AppendText("B " + Strings.Space(9 - i) + Strings.Format(B1, "0.0"));
            }
            else
            {
                SRLgTxtBx.AppendText("B " + Strings.Space(7 - i) + Strings.Format(B1, "0") + "  ");
            }

            i = (short)A1.ToString().Length; // i = A1))
            if (A1 - Conversion.Int(A1) == 0d)
            {
                i = (short)(i + 2);
            }

            if (A1 < 1d & A1 > 0d)
            {
                i = (short)(i + 1);
            }

            if (optCompact.Checked == true & A1 < 166d | optOriginal.Checked == true & A1 < 239d)
            {
                SRLgTxtBx.AppendText(Strings.Space(11) + "A " + Strings.Space(9 - i) + Strings.Format(A1, "0.0"));
            }
            else
            {
                SRLgTxtBx.AppendText(Strings.Space(11) + "A " + Strings.Space(7 - i) + Strings.Format(A1, "0") + "  ");
            }

            SRLgTxtBx.AppendText(Environment.NewLine);
            if (optCompact.Checked == true)
            {
                SRLgTxtBx.AppendText("Dec*" + Strings.Space(10 - txtDecDeg.Text.Length) + Strings.Format(Conversion.Val(txtDecDeg.Text), "0") + '°' + Strings.Format(DecMinutes, "00") + "'" + cboDec.Text);
            }

            if (optOriginal.Checked == true)
            {
                SRLgTxtBx.AppendText("Dec*" + Strings.Space(10 - txtDecDeg.Text.Length) + Strings.Format(Conversion.Val(txtDecDeg.Text), "0") + '°' + Strings.Format(DecMinutes, "00.0") + "'" + cboDec.Text);
            }

            i = (short)A2.ToString().Length;
            if (A2 - Conversion.Int(A2) == 0f)
            {
                i = (short)(i + 2);
            }

            if (optCompact.Checked == true & A2 < 166f | optOriginal.Checked == true & A2 < 239f)
            {
                SRLgTxtBx.AppendText(Strings.Space(11) + "A" + Strings.Space(9 - i) + Strings.Format(A2, "0.0"));
            }
            else
            {
                SRLgTxtBx.AppendText(Strings.Space(11) + Conversions.ToDouble("A") * Conversions.ToDouble(Strings.Space(7 - i)) + Strings.Format(A2, "0") + "  ");
            }

            i = (short)B2.ToString().Length;
            if (B2 - Conversion.Int(B2) == 0f)
            {
                i = (short)(i + 2);
            }

            if (optCompact.Checked == true & B2 < 166f | optOriginal.Checked == true & B2 < 239f)
            {
                SRLgTxtBx.AppendText(Strings.Space(11) + "B+" + Strings.Space(9 - i) + Strings.Format(B2, "0.0"));
            }
            else
            {
                SRLgTxtBx.AppendText(Strings.Space(11) + "B+" + Strings.Space(7 - i) + Strings.Format(B2, "0") + "  ");
            }

            i = (short)B2.ToString().Length;
            if (B2 - Conversion.Int(B2) == 0f)
            {
                i = (short)(i + 2);
            }

            if (optCompact.Checked == true & B2 < 166f | optOriginal.Checked == true & B2 < 239f)
            {
                SRLgTxtBx.AppendText(Strings.Space(11) + "B+" + Strings.Space(9 - i) + Strings.Format(B2, "0.0"));
            }
            else
            {
                SRLgTxtBx.AppendText(Strings.Space(11) + "B+" + Strings.Space(7 - i) + Strings.Format(B2, "0") + "  ");
            }

            SRLgTxtBx.AppendText(Environment.NewLine);
            if (optCompact.Checked == true)
                SRLgTxtBx.AppendText("DR L" + Strings.Space(10 - txtLDeg.Text.Length) + Strings.Format(Conversion.Val(txtLDeg.Text), "0") + '°' + Strings.Format(Conversion.Int(Conversion.Val(txtLMin.Text) + 0.5d), "00") + "'" + cboL.Text);
            if (optOriginal.Checked == true)
                SRLgTxtBx.AppendText("DR L" + Strings.Space(10 - txtLDeg.Text.Length) + Strings.Format(Conversion.Val(txtLDeg.Text), "0") + '°' + Strings.Format(Conversion.Val(txtLMin.Text), "00.0") + "'" + cboL.Text);
            i = (short)A3.ToString().Length;
            if (A3 - Conversion.Int(A3) == 0f)
            {
                i = (short)(i + 2);
            }

            if (optCompact.Checked == true & A3 < 166f | optOriginal.Checked == true & A3 < 239f)
            {
                SRLgTxtBx.AppendText(Strings.Space(11) + "A+" + Strings.Space(9 - i) + Strings.Format(A3, "0.0"));
            }
            else
            {
                SRLgTxtBx.AppendText(Strings.Space(11) + "A+" + Strings.Space(7 - i) + Strings.Format(A3, "0") + "  ");
            }

            i = (short)B3.ToString().Length;
            if (B3 - Conversion.Int(B3) == 0f)
            {
                i = (short)(i + 2);
            }

            if (optCompact.Checked == true & B3 < 166f | optOriginal.Checked == true & B3 < 239f)
            {
                SRLgTxtBx.AppendText(Strings.Space(11) + "B+" + Strings.Space(9 - i) + Strings.Format(B3, "0.0"));
            }
            else
            {
                SRLgTxtBx.AppendText(Strings.Space(11) + "B+" + Strings.Space(7 - i) + Strings.Format(B3, "0") + "  ");
            }

            SRLgTxtBx.AppendText(Environment.NewLine);
            SRLgTxtBx.AppendText("h1");
            if (L1 < 0d)
            {
                SRLgTxtBx.AppendText(Strings.Space(11) + "-");
            }
            else
            {
                SRLgTxtBx.AppendText(Strings.Space(11) + " ");
            }

            if (optCompact.Checked == true)
            {
                SRLgTxtBx.AppendText(Strings.Space(4 - h1Deg.ToString().Length) + Strings.Format(h1Deg, "0") + '°' + Strings.Format(Conversion.Int(h1Min), "00") + "'"); // cboL.text;
            }

            if (optOriginal.Checked == true)
            {
                SRLgTxtBx.AppendText(Strings.Space(4 - h1Deg.ToString().Length) + Strings.Format(h1Deg, "0") + '°' + Strings.Format(Conversion.Int(h1Min), "00.0") + "'"); // cboL.text;
            }

            SRLgTxtBx.AppendText("  <-  ");
            i = (short)A4.ToString().Length;
            if (A4 - Conversion.Int(A4) == 0f)
            {
                i = (short)(i + 2);
            }

            if (optCompact.Checked == true & A4 < 166f | optOriginal.Checked == true & A4 < 239f)
            {
                SRLgTxtBx.AppendText(Strings.Space(11) + "A " + Strings.Space(9 - i) + Strings.Format(A4, "0.0"));
            }
            else
            {
                SRLgTxtBx.AppendText(Strings.Space(11) + "A" + Strings.Space(7 - i) + Strings.Format(A4, "0") + "  ");
            }

            SRLgTxtBx.AppendText(Environment.NewLine);
            if (optCompact.Checked == true)
            {
                SRLgTxtBx.AppendText("Ho" + Strings.Space(12 - txtHoDeg.Text.Length) + Strings.Format(HoDeg, "0") + '°' + Strings.Format(Math.Abs(HoMin), "00") + "'");
            }

            if (optOriginal.Checked == true)
            {
                SRLgTxtBx.AppendText("Ho" + Strings.Space(12 - txtHoDeg.Text.Length) + Strings.Format(HoDeg, "0") + '°' + Strings.Format(Math.Abs(HoMin), "00.0") + "'");
            }

            SRLgTxtBx.AppendText(Environment.NewLine);
            SRLgTxtBx.AppendText("h1+Ho");
            if (L2 < 0d)
            {
                SRLgTxtBx.AppendText(Strings.Space(11 - L2Deg.ToString().Length) + "-");
            }
            else
            {
                SRLgTxtBx.AppendText(Strings.Space(11 - L2Deg.ToString().Length) + " ");
            }

            if (optCompact.Checked == true)
            {
                SRLgTxtBx.AppendText(Strings.Space(12 - L2Deg.ToString().Length) + Strings.Format(L2Deg, "0") + '°' + Strings.Format(L2Min, "00") + "'");
            }

            if (optOriginal.Checked == true)
            {
                SRLgTxtBx.AppendText(Strings.Space(12 - L2Deg.ToString().Length) + Strings.Format(L2Deg, "0") + '°' + Strings.Format(L2Min, "00.0") + "'");
            }

            SRLgTxtBx.AppendText(Environment.NewLine);
            SRLgTxtBx.AppendText("(h1+Ho)/2");
            if (L3 < 0d)
            {
                SRLgTxtBx.AppendText(Strings.Space(11 - L3Deg.ToString().Length) + "-");
            }
            else
            {
                SRLgTxtBx.AppendText(Strings.Space(11 - L3Deg.ToString().Length) + " ");
            }

            if (optCompact.Checked == true)
            {
                SRLgTxtBx.AppendText(Strings.Space(11 - L3Deg.ToString().Length) + Strings.Format(L3Deg, "0") + '°' + Strings.Format(L3Min, "00") + "'");
            }

            if (optOriginal.Checked == true)
            {
                SRLgTxtBx.AppendText(Strings.Space(11 - L3Deg.ToString().Length) + Strings.Format(L3Deg, "0") + '°' + Strings.Format(L3Min, "00.0") + "'");
            }

            SRLgTxtBx.AppendText(" -> -> -> -> -> -> -> -> ");
            i = (short)B4.ToString().Length;
            if (B4 - Conversion.Int(B4) == 0f)
            {
                i = (short)(i + 2);
            }

            if (B4 < 1f & B4 > 0f)
            {
                i = (short)(i + 1);
            }

            if (optCompact.Checked == true & B4 < 166f | optOriginal.Checked == true & B4 < 239f)
            {
                SRLgTxtBx.AppendText(Strings.Space(25) + "B-" + Strings.Space(9 - i) + Strings.Format(B4, "0.0"));
            }
            else
            {
                SRLgTxtBx.AppendText(Strings.Space(25) + "B-" + Strings.Space(9 - i) + Strings.Format(B4, "0") + "  ");
            }

            SRLgTxtBx.AppendText(Environment.NewLine);
            SRLgTxtBx.AppendText("h2");
            if (L4 < 0d)
            {
                SRLgTxtBx.AppendText(Strings.Space(13 - h2Deg.ToString().Length) + "-");
            }
            else
            {
                SRLgTxtBx.AppendText(Strings.Space(13 - h2Deg.ToString().Length) + " ");
            }

            if (optCompact.Checked == true)
            {
                SRLgTxtBx.AppendText(Strings.Space(4 - h2Deg.ToString().Length) + Strings.Format(Math.Abs(h2Deg), "0") + '°' + Strings.Format(Math.Abs(h2Min), "00") + "'");
            }

            if (optOriginal.Checked == true)
            {
                SRLgTxtBx.AppendText(Strings.Space(4 - h2Deg.ToString().Length) + Strings.Format(Math.Abs(h2Deg), "0") + '°' + Strings.Format(Math.Abs(h2Min), "00.0") + "'");
            }

            SRLgTxtBx.AppendText(" <- <- <- <- <- <- <- <- ");
            i = (short)A5.ToString().Length;
            if (A5 - Conversion.Int(A5) == 0f)
            {
                i = (short)(i + 2);
            }

            if (optCompact.Checked == true & A5 < 166f | optOriginal.Checked == true & A5 < 239f)
            {
                SRLgTxtBx.AppendText(Strings.Space(24) + "A " + Strings.Space(9 - i) + Strings.Format(A5, "0.0"));
            }
            else
            {
                SRLgTxtBx.AppendText(Strings.Space(24) + "A " + Strings.Space(7 - i) + Strings.Format(A5, "0") + "  ");
            }

            SRLgTxtBx.AppendText(Environment.NewLine);
            SRLgTxtBx.AppendText("Hc(h1+h2)");
            if (L1 + L4 < 0d)
            {
                SRLgTxtBx.AppendText(Strings.Space(4 - HcDeg.ToString().Length) + "-");
                Hc = -Hc;
            }
            else
            {
                SRLgTxtBx.AppendText(Strings.Space(4 - HcDeg.ToString().Length) + " ");
            }

            if (optCompact.Checked == true)
            {
                SRLgTxtBx.AppendText(Strings.Space(4 - HcDeg.ToString().Length) + Strings.Format(HcDeg, "0") + '°' + Strings.Format(HcMin, "00") + "'");
            }

            if (optOriginal.Checked == true)
            {
                SRLgTxtBx.AppendText(Strings.Space(4 - HcDeg.ToString().Length) + Strings.Format(HcDeg, "0") + '°' + Strings.Format(HcMin, "00.0") + "'");
            }

            SRLgTxtBx.AppendText(" -> -> -> -> -> -> -> -> -> -> -> -> -> -> -> ");
            i = (short)B5.ToString().Length;
            if (B5 - Conversion.Int(B5) == 0f)
            {
                i = (short)(i + 2);
            }

            if (optCompact.Checked == true & B5 < 166f | optOriginal.Checked == true & B5 < 239f)
            {
                SRLgTxtBx.AppendText(Strings.Space(45) + "B-" + Strings.Space(9 - i) + Strings.Format(B5, "0.0"));
            }
            else
            {
                SRLgTxtBx.AppendText(Strings.Space(45) + "B-" + Strings.Space(7 - i) + Strings.Format(B5, "0") + "  ");
            }

            SRLgTxtBx.AppendText(Environment.NewLine);
            if (optCompact.Checked == true)
            {
                SRLgTxtBx.AppendText("Ho" + Strings.Space(12 - txtHoDeg.Text.Length) + Strings.Format(HoDeg, "0") + '°' + Strings.Format(HoMin, "00") + "'");
            }

            if (optOriginal.Checked == true)
            {
                SRLgTxtBx.AppendText("Ho" + Strings.Space(12 - txtHoDeg.Text.Length) + Strings.Format(HoDeg, "0") + '°' + Strings.Format(HoMin, "00.0") + "'");
            }

            if (Ho > Hc)
            {
                SRLgTxtBx.AppendText("    Observed greater - Toward");
            }

            if (Ho < Hc)
            {
                SRLgTxtBx.AppendText("    Computed greater - Away");
            }

            SRLgTxtBx.AppendText(Environment.NewLine);
            SRLgTxtBx.AppendText("a" + Strings.Space(16 - Conversion.Int(Math.Abs(A)).ToString().Length));
            if (optCompact.Checked == true)
            {
                SRLgTxtBx.AppendText(Strings.Format(Conversion.Int(Math.Abs(A) + 0.5d), "0") + " miles ");
                PlotOut.PlotIntercept = Strings.Format(Conversion.Int(Math.Abs(A) + 0.5d), "0") + " nm ";
            }

            if (optOriginal.Checked == true)
            {
                SRLgTxtBx.AppendText(Strings.Format(Conversion.Int(Math.Abs(A) * 10d + 0.5d) / 10d, "0.0") + " miles ");
                PlotOut.PlotIntercept = Strings.Format(Conversion.Int(Math.Abs(A) * 10d + 0.5d) / 10d, "0.0") + " nm ";
            }

            if (Hc < Ho)
            {
                SRLgTxtBx.AppendText("T");
                PlotOut.PlotIntercept += "Toward";
            }

            if (Hc > Ho)
            {
                SRLgTxtBx.AppendText("A");
                PlotOut.PlotIntercept += "Away";
            }

            SRLgTxtBx.AppendText(Strings.Space(5) + "Zn" + Strings.Space(1) + Strings.Format(ZN, "000") + '°' + " <- <- ");
            PlotOut.PlotAz = Strings.Format(ZN, "000") + '°';
            if (optCompact.Checked == true)
            {
                SRLgTxtBx.AppendText(Strings.Space(3) + "Z " + cboL.Text + Strings.Space(1) + Strings.Format(ZDeg, "0") + '°' + Strings.Format(ZMin, "00") + "'"); // Format(Z, "0"); Chr$(176); for whole degrees
            }

            if (optOriginal.Checked == true)
            {
                SRLgTxtBx.AppendText(Strings.Space(3) + "Z " + cboL.Text + Strings.Space(1) + Strings.Format(ZDeg, "0") + '°' + Strings.Format(ZMin, "00.0") + "'");
            }

            if (LHA <= 180d)
                SRLgTxtBx.AppendText(" W" + " <- <- ");
            if (LHA > 180d)
                SRLgTxtBx.AppendText(" E" + " <- <- ");
            if (optCompact.Checked == true)
                SRLgTxtBx.AppendText("<-");
            i = (short)A6.ToString().Length;
            if (A6 - Conversion.Int(A6) == 0f)
            {
                i = (short)(i + 2);
            }

            if (A6 - Conversion.Int(A6) != 0f)
                SRLgTxtBx.AppendText(Strings.Space(11) + "A " + Strings.Space(9 - i) + Strings.Format(A6, "0.0"));
            if (A6 - Conversion.Int(A6) == 0f)
                SRLgTxtBx.AppendText(Strings.Space(11) + "A" + Strings.Space(7 - i) + Strings.Format(A6, "0") + "  ");
            SRLgTxtBx.AppendText(Environment.NewLine);
            SRLgTxtBx.AppendText(Strings.Space(25) + "EP L " + Strings.Format(EstLDeg, "0") + '°' + Strings.Format(EstLMin, "00.0") + "'");
            PlotOut.PlotSLEP = "EP L " + Strings.Format(EstLDeg, "0") + '°' + Strings.Format(EstLMin, "00.0") + "'";
            if (EstL > 0d)
            {
                SRLgTxtBx.AppendText(CommonGlobals.g_LatN);
                PlotOut.PlotSLEP += CommonGlobals.g_LatN;
                PlotOut.PlotLatNS = CommonGlobals.g_LatN;
            }

            if (EstL == 0d)
            {
                SRLgTxtBx.AppendText(CommonGlobals.g_StrSpace);
                PlotOut.PlotSLEP += CommonGlobals.g_LatN;
                PlotOut.PlotLatNS = CommonGlobals.g_LatN;
            }

            if (EstL < 0d)
            {
                SRLgTxtBx.AppendText(CommonGlobals.g_LatS);
                PlotOut.PlotSLEP += CommonGlobals.g_LatS;
                PlotOut.PlotLatNS = CommonGlobals.g_LatS;
            }

            SRLgTxtBx.AppendText("    EP Lo " + Strings.Format(EstLoDeg, "0") + '°' + Strings.Format(EstLoMin, "00.0") + "'");
            PlotOut.PlotSLEP += " EP Lo " + Strings.Format(EstLoDeg, "0") + '°' + Strings.Format(EstLoMin, "00.0") + "'";
            if (EstLo > 0d)
            {
                SRLgTxtBx.AppendText(CommonGlobals.g_LongW);
                PlotOut.PlotSLEP += CommonGlobals.g_LongW;
                PlotOut.PlotLongEW = CommonGlobals.g_LongW;
            }

            if (EstLo == 0d)
            {
                SRLgTxtBx.AppendText(CommonGlobals.g_StrSpace);
                PlotOut.PlotSLEP += CommonGlobals.g_LongW;
                PlotOut.PlotLongEW = CommonGlobals.g_LongW;
            }

            if (EstLo < 0d)
            {
                SRLgTxtBx.AppendText(CommonGlobals.g_LongE);
                PlotOut.PlotSLEP += CommonGlobals.g_LongE;
                PlotOut.PlotLongEW = CommonGlobals.g_LongE;
            }

            SRLgTxtBx.AppendText(Environment.NewLine);
            SRLgTxtBx.AppendText(Strings.Space(25) + "*Table entry values");
            SRLgTxtBx.AppendText(Environment.NewLine);
            SRLgTxtBx.Refresh();
            SRHdrTxtBx.Refresh();
        }

        private void STable()
        {
            frame211.Visible = false;
            Flag = false; // Part of avoiding divide-by-zero errors
            LHA = GHA - Lo;
            if (LHA >= 360d)
                LHA = LHA - 360d;
            if (LHA < 0d)
                LHA = LHA + 360d;
            LHADeg = (short)Conversion.Int(LHA);
            LHAMin = (LHA - LHADeg) * 60d;
            LHAMin = Conversion.Int(LHAMin + 0.50000001d);
            if (LHAMin == 60d)
            {
                LHAMin = 0d;
                LHADeg = (short)(LHADeg + 1);
            }

            LHADecimal = LHADeg + LHAMin / 60d;
            if (LHADecimal == 0d)
            {
                A1 = 999.999d;
            }
            else
            {
                A1 = CscS(ref LHADecimal);
            }

            A1 = Conversion.Int(1000d * A1 + 0.5d) / 1000d;
            DecDecimal = Conversion.Val(txtDecDeg.Text) + DecMinutes / 60d;
            frameS.Visible = true;
            B1 = SecS(ref DecDecimal);
            B1 = Conversion.Int(1000d * B1 + 0.5d) / 1000d;
            A2 = CscS(ref DecDecimal);
            A2 = (float)(Conversion.Int(1000f * A2 + 0.5d) / 1000d);
            A3 = (float)(A1 + B1);
            // A3 = Int(A3 * 10 + 0.5) / 10    'is this line necessary?
            A4 = A3;
            if (optPepperday.Checked == true)
            {
                A3Angle = 1d / Math.Pow(10d, A3 / 94.2932531d);
            }

            if (optFarley.Checked == true)
            {
                A3Angle = 1d / Math.Pow(10d, A3 / 100f);
            }

            A3Angle = Math.Atan(A3Angle / Math.Sqrt(-A3Angle * A3Angle + 1d) + 9.999999E-21d); // arcsin
            A3Angle = A3Angle * 180d / Pi;
            A3AngleDeg = (short)Conversion.Int(A3Angle);
            A3AngleMin = (A3Angle - A3AngleDeg) * 60d;
            A3AngleMin = Conversion.Int(A3AngleMin + 0.5d);
            A3AngleDecimal = A3AngleDeg + A3AngleMin / 60d;
            B2 = SecS(ref A3AngleDecimal);
            B2 = (float)(Conversion.Int(1000f * B2 + 0.5d) / 1000d);
            B3 = B2;
            A5 = A2 - B2;
            // A5 = Int(A5 * 10 + 0.5) / 10    'is this line necessary?
            if (optPepperday.Checked == true)
                k = 1d / Math.Pow(10d, A5 / 94.2932531d);
            if (optFarley.Checked == true)
                k = 1d / Math.Pow(10d, A5 / 100f);
            if (k >= 1d)
            {
                k = Pi / 2d;
            }
            else
            {
                k = Math.Atan(k / Math.Sqrt(-k * k + 1d) + 9.999999E-21d);
            } // arcsin        Was If k = 1 before V5.4.1

            k = k * 180d / Pi;
            // If tDecimal > 90 Then k = 180 - k       '????????????90-K or 180-K????????

            if (k >= 82d & k <= 98d)
            {
                B2 = SecS(ref A3Angle);
                B2 = (float)(Conversion.Int(1000f * B2 + 0.5d) / 1000d);
                B3 = B2;
                A5 = A2 - B2;
                // A5 = CscS(DecDecimal) - SecS(A3Angle)
                // A5 = Int(1000 * A5 + 0.5) / 1000
                if (optPepperday.Checked == true)
                {
                    k = 1d / Math.Pow(10d, A5 / 94.2932531d);
                }

                if (optFarley.Checked == true)
                {
                    k = 1d / Math.Pow(10d, A5 / 100f);
                }

                if (k >= 1d)
                {
                    k = Pi / 2d;
                }
                else
                {
                    k = Math.Atan(k / Math.Sqrt(-k * k + 1d) + 9.999999E-21d);
                } // arcsin        Was If k = 1 before V5.4.1

                k = k * 180d / Pi;
                A5 = (float)(Conversion.Int(1000f * A5 + 0.5d) / 1000d);
            }

            if (LHADecimal >= 90d & LHADecimal <= 270d)
            {
                k = 180d - k;
            }

            KDeg = (short)Conversion.Int(k);
            KMin = (k - KDeg) * 60d;
            KMin = Conversion.Int(KMin + 0.5d);
            L = Conversion.Val(txtLDeg.Text) + Conversion.Int(Conversion.Val(txtLMin.Text) + 0.5d) / 60d;
            if ((cboDec.Text ?? "") == (cboL.Text ?? ""))
            {
                KL = Math.Abs(L - KDeg - KMin / 60d);
            }

            if ((cboDec.Text ?? "") != (cboL.Text ?? ""))
            {
                KL = Math.Abs(L + KDeg + KMin / 60d);
            }
            // If KL > 90 Then KL = KL + 180
            KLDeg = (short)Conversion.Int(KL);
            KLMin = (KL - KLDeg) * 60d;
            // If KLDeg > 90 Then KLDeg = KLDeg + 180
            KLMin = Conversion.Int(KLMin + 0.5d);
            if (KLMin >= 60d)
            {
                KLMin = KLMin - 60d;
                KLDeg = (short)(KLDeg + 1);
            }

            float localSecS() { double argx = KLDeg + KLMin / 60d; var ret = SecS(ref argx); return ret; }

            B4 = localSecS();
            B4 = (float)(Conversion.Int(1000f * B4 + 0.5d) / 1000d);
            if (KLDeg > 270)
            {
                KLDeg = (short)(KLDeg - 180);
            }

            A6 = B3 + B4;
            // A6 = Int(A6 * 10 + 0.5) / 10    'is this line necessary?
            if (optPepperday.Checked == true)
            {
                HcAngle = 1d / Math.Pow(10d, A6 / 94.2932531d);
            }

            if (optFarley.Checked == true)
            {
                HcAngle = 1d / Math.Pow(10d, A6 / 100f);
            }

            if (HcAngle == 1d)
            {
                HcAngle = Pi / 2d;
            }
            else
            {
                HcAngle = Math.Atan(HcAngle / Math.Sqrt(-HcAngle * HcAngle + 1d) + 9.999999E-21d);
            } // arcsin

            HcAngle = HcAngle * 180d / Pi;
            if (KL > 90d)
            {
                HcAngle = -HcAngle;
            }

            Htot = HcAngle;
            HcDeg = (short)Conversion.Fix(HcAngle); // was Int
            HcMin = (HcAngle - HcDeg) * 60d;
            HcMin = Conversion.Int(HcMin + 0.5d);
            if (HcMin >= 60d)
            {
                HcMin = HcMin - 60d;
                HcDeg = (short)(HcDeg + 1);
            }

            HcDecimal = HcDeg + HcMin / 60d;
            // If KL > 90 Then HcDecimal = -HcDecimal
            B5 = SecS(ref HcDecimal);
            B5 = (float)(Conversion.Int(1000f * B5 + 0.5d) / 1000d);
            Ho = Conversion.Val(txtHoDeg.Text) + Conversion.Int(Conversion.Val(txtHoMin.Text) + 0.5d) / 60d; // WHY THIS LINE???????????????????
                                                                                                             // HoDeg = Int(Ho)
                                                                                                             // HoMin = (Ho - HoDeg) * 60
            HoDeg = (short)Conversion.Val(txtHoDeg.Text);
            HoMin = Conversion.Val(txtHoMin.Text);
            HoMin = Conversion.Int(HoMin + 0.5d);
            // A = Sgn(HcDecimal) * (60 * HcDeg + HcMin) - (60 * HoDeg + HoMin)
            A = 60 * HoDeg + HoMin - (60 * HcDeg + HcMin);
            // If HoinMinutes < 0 Then A = (60 * HcDeg + HcMin) + (60 * HoDeg + HoMin)
            A7 = A4 - B5;
            if (A7 <= 0f)
            {
                A7 = 0f;
                Z = 90d; // When the body is near or on the Prime Vertical, A7 may be negative.  Use zero for A7 and Z will be 90 degrees.
            }
            // A7 = Int(1000 * A7 + 0.5) / 1000
            if (A7 != 0f)
            {
                if (optPepperday.Checked == true)
                    Z = 1d / Math.Pow(10d, A7 / 94.2932531d);
                if (optFarley.Checked == true)
                    Z = 1d / Math.Pow(10d, A7 / 100f);
                Z = Math.Atan(Z / Math.Sqrt(-Z * Z + 1d) + 9.999999E-21d); // arcsin
                Z = Z * 180d / Pi;
            }

            A7 = (float)(Conversion.Int(A7 * 1000f + 0.5d) / 1000d); // this line was necessary for low value of A7
            if ((cboDec.Text ?? "") == (cboL.Text ?? "") & k > L)
                Z = Z;
            else
                Z = 180d - Z;
            Z = Conversion.Int(Z + 0.5d);
            if (cboL.Text == "N" & LHA > 180d)
                ZN = Z;
            if (cboL.Text == "N" & LHA <= 180d)
                ZN = 360d - Z;
            if (cboL.Text == "S" & LHA > 180d)
                ZN = 180d - Z;
            if (cboL.Text == "S" & LHA <= 180d)
                ZN = 180d + Z;
            if (cboL.Text == "S")
                L = -L;
        }

        private void DisplaySTable()
        {
            cmdSave.Visible = false;
            cmdFix.Visible = false; // : 
            cmdFix.Enabled = false;
            cmdFix.Text = "Establish Fix";
            // Me.Font = New Font(Me.Font, "Courier New")
            SRHdrTxtBx.Clear();
            SRHdrTxtBx.Visible = true;
            SRHdrTxtBx.BringToFront();
            SRLgTxtBx.Clear();
            SRLgTxtBx.Visible = true;
            SRLgTxtBx.BringToFront();
            SRLeftTxtBx.Clear();
            SRLeftTxtBx.Visible = false;
            SRLeftTxtBx.SendToBack();
            SRRightTxtBx.Clear();
            SRRightTxtBx.Visible = false;
            SRRightTxtBx.SendToBack();
            NASRAsmTxtBx.Clear();
            NASRAsmTxtBx.Visible = false;
            NASRAsmTxtBx.SendToBack();
            NASRAFTxtBx.Clear();
            NASRAFTxtBx.Visible = false;
            NASRAFTxtBx.SendToBack();
            DCorrTxtBx.Clear();
            DCorrTxtBx.Visible = false;
            DCorrTxtBx.SendToBack();
            WeemsPVTxtBx.Clear();            // V5.6.1
            WeemsPVTxtBx.Visible = false;    // V5.6.1     
            WeemsPVTxtBx.SendToBack();   // V5.6.1
            frameNASRUsing.Visible = false;
            frame214.Visible = false;
            Label9.Visible = false;
            chkInterpolateB.Visible = false;
            frameS.Visible = true;
            GroupBoxPrecision.Visible = false;      // V5.6.1
            var argTB = SRHdrTxtBx;
            AlignCenterRTB(ref argTB);
            SRHdrTxtBx = argTB;
            SRHdrTxtBx.AppendText("S TABLE SIGHT COMPUTATION");
            FlagFarley = false;
            if (optFarley.Checked == true & LHA > 180d)
            {
                LHA = 360d - LHA;
                LHADeg = (short)Conversion.Int(LHA);
                LHAMin = (LHA - LHADeg) * 60d;
                LHAMin = Conversion.Int(LHAMin + 0.50000001d);
                if (LHAMin == 60d)
                {
                    LHAMin = 0d;
                    LHADeg = (short)(LHADeg + 1);
                }

                FlagFarley = true;
            }

            SRLgTxtBx.AppendText("LHA*");
            if (FlagFarley == true)
            {
                SRLgTxtBx.AppendText("    -");
            }
            else
            {
                SRLgTxtBx.AppendText("     ");
            }

            SRLgTxtBx.AppendText(Strings.Space(5 - LHADeg.ToString().Length) + Strings.Format(LHADeg, "0") + '°' + Strings.Format(LHAMin, "00") + "'");
            i = (short)(Conversion.Int(A1).ToString().Length + 4);
            if (optPepperday.Checked == true)
            {
                SRLgTxtBx.AppendText(Strings.Space(8) + "S" + Strings.Space(9 - i) + Strings.Format(A1, "0.000"));
            }

            if (optFarley.Checked == true)
            {
                SRLgTxtBx.AppendText(Strings.Space(8) + "S1" + Strings.Space(9 - i) + Strings.Format(A1, "0.000"));
            }

            SRLgTxtBx.AppendText(Environment.NewLine);
            if (optPepperday.Checked == true)
            {
                SRLgTxtBx.AppendText("Dec*    " + cboDec.Text + Strings.Space(4 - txtDecDeg.Text.ToString().Length) + Strings.Format(Conversion.Val(txtDecDeg.Text), "0") + '°' + Strings.Format(DecMinutes, "00") + "'");
            }

            if (optFarley.Checked == true)
            {
                SRLgTxtBx.AppendText("DEC*    ");
                if (cboDec.Text == "N")
                    SRLgTxtBx.AppendText("+");
                if (cboDec.Text == "S")
                    SRLgTxtBx.AppendText("-");
                SRLgTxtBx.AppendText(Strings.Space(4 - txtDecDeg.Text.ToString().Length) + Strings.Format(Conversion.Val(txtDecDeg.Text), "0") + '°' + Strings.Format(DecMinutes, "00") + "'");
            }

            i = (short)(Conversion.Int(B1).ToString().Length + 4);
            if (optPepperday.Checked == true)
            {
                SRLgTxtBx.AppendText(Strings.Space(8) + "C+" + Strings.Space(9 - i));
                SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Underline);
                SRLgTxtBx.AppendText(Strings.Format(B1, "0.000"));
                SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Regular);
            }

            if (optFarley.Checked == true)
            {
                SRLgTxtBx.AppendText(Strings.Space(8) + "C2" + Strings.Space(9 - i));
                SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Underline);
                SRLgTxtBx.AppendText(Strings.Format(B1, "0.000"));
                SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Regular);
            }

            i = (short)(Conversion.Int(A2).ToString().Length + 4);
            if (optPepperday.Checked == true)
            {
                SRLgTxtBx.AppendText(Strings.Space(9) + "S" + Strings.Space(9 - i) + Strings.Format(A2, "0.000"));
            }

            if (optFarley.Checked == true)
            {
                SRLgTxtBx.AppendText(Strings.Space(9) + "S2" + Strings.Space(9 - i) + Strings.Format(A2, "0.000"));
            }

            SRLgTxtBx.AppendText(Environment.NewLine);
            i = (short)(Conversion.Int(A3).ToString().Length + 4);
            if (optPepperday.Checked == true)
            {
                SRLgTxtBx.AppendText(Strings.Space(25) + "S" + Strings.Space(9 - i) + Strings.Format(A3, "0.000"));
            }

            if (optFarley.Checked == true)
            {
                SRLgTxtBx.AppendText(Strings.Space(24) + "S3" + Strings.Space(9 - i) + Strings.Format(A3, "0.000"));
            }

            i = (short)(Conversion.Int(B2).ToString().Length + 4);
            if (optPepperday.Checked == true)
            {
                SRLgTxtBx.AppendText(Strings.Space(9) + "C-" + Strings.Space(9 - i));
                SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Underline);
                SRLgTxtBx.AppendText(Strings.Format(B2, "0.000"));
                SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Regular);
            }

            if (optFarley.Checked == true)
            {
                SRLgTxtBx.AppendText(Strings.Space(9) + "C3" + Strings.Space(9 - i));
                SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Underline);
                SRLgTxtBx.AppendText(Strings.Format(B2, "0.000"));
                SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Regular);
            }

            if (k >= 82d & k <= 98d)
            {
                SRLgTxtBx.AppendText("**");
            }
            else
            {
                SRLgTxtBx.AppendText("  ");
            }

            i = (short)(Conversion.Int(B3).ToString().Length + 4);
            if (optPepperday.Checked == true)
            {
                SRLgTxtBx.AppendText(Strings.Space(6) + "C " + Strings.Space(9 - i) + Strings.Format(B3, "0.000"));
            }

            if (optFarley.Checked == true)
            {
                SRLgTxtBx.AppendText(Strings.Space(6) + "C3" + Strings.Space(9 - i) + Strings.Format(B3, "0.000"));
            }

            i = (short)(Conversion.Int(A4).ToString().Length + 4);
            if (optPepperday.Checked == true)
            {
                SRLgTxtBx.AppendText(Strings.Space(9) + "S" + Strings.Space(9 - i) + Strings.Format(A4, "0.000"));
            }

            if (optFarley.Checked == true)
            {
                SRLgTxtBx.AppendText(Strings.Space(9) + "S3" + Strings.Space(9 - i) + Strings.Format(A4, "0.000"));
            }

            SRLgTxtBx.AppendText(Environment.NewLine);
            SRLgTxtBx.AppendText("K" + Strings.Space(13 - KDeg.ToString().Length) + Strings.Format(KDeg, "0") + '°' + Strings.Format(KMin, "00") + "'");
            SRLgTxtBx.AppendText("<- <- <- <- <- <- <- <- <- ");
            i = (short)(Conversion.Int(A5).ToString().Length + 4);
            if (optPepperday.Checked == true)
            {
                SRLgTxtBx.AppendText("S" + Strings.Space(9 - i) + Strings.Format(A5, "0.000"));
            }

            if (optFarley.Checked == true)
            {
                SRLgTxtBx.AppendText("S4" + Strings.Space(9 - i) + Strings.Format(A5, "0.000"));
            }

            SRLgTxtBx.AppendText(Environment.NewLine);
            if (optPepperday.Checked == true)
            {
                SRLgTxtBx.AppendText("lat    " + cboL.Text + Strings.Space(5 - txtLDeg.Text.ToString().Length));
                SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Underline);
                SRLgTxtBx.AppendText(Strings.Format(Conversion.Val(txtLDeg.Text), "0") + '°' + Strings.Format(Conversion.Int(Conversion.Val(txtLMin.Text) + 0.5d), "00") + "'");
                SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Regular);
            }

            if (optFarley.Checked == true)
            {
                SRLgTxtBx.AppendText("LAT     ");
                if (cboL.Text == "N")
                {
                    SRLgTxtBx.AppendText("+");
                }

                if (cboL.Text == "S")
                {
                    SRLgTxtBx.AppendText("-");
                }

                SRLgTxtBx.AppendText(Strings.Space(5 - txtLDeg.Text.ToString().Length));
                SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Underline);
                SRLgTxtBx.AppendText(Strings.Format(Conversion.Val(txtLDeg.Text), "0") + '°' + Strings.Format(Conversion.Int(Conversion.Val(txtLMin.Text) + 0.5d), "00") + "'");
                SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Regular);
            }

            SRLgTxtBx.AppendText(Environment.NewLine);
            SRLgTxtBx.AppendText("K");
            if ((cboDec.Text ?? "") == (cboL.Text ?? ""))
            {
                SRLgTxtBx.AppendText("-");
            }

            if ((cboDec.Text ?? "") != (cboL.Text ?? ""))
            {
                SRLgTxtBx.AppendText("+");
            }

            if (optPepperday.Checked == true)
            {
                SRLgTxtBx.AppendText("lat" + Strings.Space(9 - KLDeg.ToString().Length) + Strings.Format(KLDeg, "0") + '°' + Strings.Format(KLMin, "00") + "'");
            }

            if (optFarley.Checked == true)
            {
                SRLgTxtBx.AppendText("lat(K')" + Strings.Space(7 - KLDeg.ToString().Length) + Strings.Format(KLDeg, "0") + '°' + Strings.Format(KLMin, "00") + "'");
            }

            SRLgTxtBx.AppendText("-> -> -> -> -> -> -> -> -> -> -> -> -> -> -> ");
            i = (short)(Conversion.Int(B4).ToString().Length + 4);
            if (optPepperday.Checked == true)
            {
                SRLgTxtBx.AppendText("C+" + Strings.Space(9 - i));
                SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Underline);
                SRLgTxtBx.AppendText(Strings.Format(B4, "0.000"));
                SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Regular);
            }

            if (optFarley.Checked == true)
            {
                SRLgTxtBx.AppendText("C5" + Strings.Space(9 - i));
                SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Underline);
                SRLgTxtBx.AppendText(Strings.Format(B4, "0.000"));
                SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Regular);
            }

            SRLgTxtBx.AppendText(Environment.NewLine);
            if (optPepperday.Checked == true)
            {
                SRLgTxtBx.AppendText("Comp. alt");
            }

            if (optFarley.Checked == true)
            {
                SRLgTxtBx.AppendText("Hc       ");
            }

            if (KL > 90d)
            {
                SRLgTxtBx.AppendText("-");
            }
            else
            {
                SRLgTxtBx.AppendText(Strings.Space(1));
            }

            SRLgTxtBx.AppendText(Strings.Space(4 - HcDeg.ToString().Length) + Strings.Format(HcDeg, "0") + '°' + Strings.Format(Math.Abs(HcMin), "00") + "'");
            SRLgTxtBx.AppendText("<- <- <- <- <- <- <- <- <- <- <- <- <- <- <- ");
            i = (short)(Conversion.Int(A6).ToString().Length + 4);
            if (optPepperday.Checked == true)
            {
                SRLgTxtBx.AppendText("S" + Strings.Space(9 - i) + Strings.Format(A6, "0.000"));
            }

            if (optFarley.Checked == true)
            {
                SRLgTxtBx.AppendText("S6" + Strings.Space(9 - i) + Strings.Format(A6, "0.000"));
            }

            i = (short)(Conversion.Int(B5).ToString().Length + 4);
            if (optPepperday.Checked == true)
            {
                SRLgTxtBx.AppendText(Strings.Space(9) + "C-" + Strings.Space(9 - i));
                SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Underline);
                SRLgTxtBx.AppendText(Strings.Format(B5, "0.000"));
                SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Regular);
            }

            if (optFarley.Checked == true)
            {
                SRLgTxtBx.AppendText(Strings.Space(9) + "C6" + Strings.Space(9 - i));
                SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Underline);
                SRLgTxtBx.AppendText(Strings.Format(B5, "0.000"));
                SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Regular);
            }

            SRLgTxtBx.AppendText(Environment.NewLine);
            if (optPepperday.Checked == true)
            {
                SRLgTxtBx.AppendText("obs.alt  ");
            }

            if (optFarley.Checked == true)
            {
                SRLgTxtBx.AppendText("Ho       ");
            }

            if (HoMin < 0d)
            {
                SRLgTxtBx.AppendText("-");
            }
            else
            {
                SRLgTxtBx.AppendText(CommonGlobals.g_StrSpace);
            }

            SRLgTxtBx.AppendText(Strings.Space(4 - txtHoDeg.Text.ToString().Length));
            SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Underline);
            SRLgTxtBx.AppendText(Strings.Format(HoDeg, "0") + '°' + Strings.Format(Math.Abs(HoMin), "00") + "'");
            SRLgTxtBx.SelectionFont = new Font(SRLgTxtBx.Font, FontStyle.Regular);
            SRLgTxtBx.AppendText(Environment.NewLine);
            if (optPepperday.Checked == true)
            {
                SRLgTxtBx.AppendText("intercept" + Strings.Space(7 - Conversion.Int(Math.Abs(A)).ToString().Length));
            }

            if (optFarley.Checked == true)
            {
                SRLgTxtBx.AppendText("Doffset" + Strings.Space(9 - Conversion.Int(Math.Abs(A)).ToString().Length));
            }

            if (Math.Sign(A) == 1)
            {
                SRLgTxtBx.AppendText("+");
            }

            if (Math.Sign(A) == -1)
            {
                SRLgTxtBx.AppendText("-");
            }

            if (Math.Sign(A) == 0)
            {
                SRLgTxtBx.AppendText(CommonGlobals.g_StrSpace);
            }

            SRLgTxtBx.AppendText(Strings.Format(Conversion.Int(Math.Abs(A) + 0.5d), "0"));
            PlotOut.PlotIntercept = Strings.Format(Conversion.Int(Math.Abs(A) + 0.5d), "0") + " nm ";
            if (optPepperday.Checked == true)
            {
                if (HcDecimal < Ho)
                {
                    SRLgTxtBx.AppendText(" Toward");
                    PlotOut.PlotIntercept += "Toward";
                }

                if (HcDecimal > Ho)
                {
                    SRLgTxtBx.AppendText(" Away");
                    PlotOut.PlotIntercept += " Away";
                }

                if (HcDecimal == Ho)
                {
                    SRLgTxtBx.AppendText(CommonGlobals.g_StrSpace);
                    PlotOut.PlotIntercept += " Toward";
                }
            }

            if (optFarley.Checked == true)
            {
                if (Math.Sign(A) == -1)
                {
                    SRLgTxtBx.AppendText("(Away)");
                    PlotOut.PlotIntercept += " Away";
                }

                if (Math.Sign(A) == 1)
                {
                    SRLgTxtBx.AppendText("(Toward)");
                    PlotOut.PlotIntercept += " Toward";
                }

                if (Math.Sign(A) == 0)
                {
                    SRLgTxtBx.AppendText(CommonGlobals.g_StrSpace);
                    PlotOut.PlotIntercept += " Toward";
                }
            }

            PlotOut.PlotAz = Strings.Format(ZN, "000") + '°';
            if (optPepperday.Checked == true)
            {
                SRLgTxtBx.AppendText("  Azimuth" + Strings.Space(1) + Strings.Format(ZN, "000") + '°' + " <- <- <- ");
            }

            if (optFarley.Checked == true)
            {
                SRLgTxtBx.AppendText("  Zn" + Strings.Space(1) + Strings.Format(ZN, "000") + '°' + " <- <- <- ");
            }

            if (optPepperday.Checked == true)
            {
                SRLgTxtBx.AppendText("Mer. Bg. " + cboL.Text + Strings.Space(1) + Strings.Format(Z, "0") + '°');
            }

            if (optFarley.Checked == true)
            {
                SRLgTxtBx.AppendText("  Zo " + cboL.Text + Strings.Space(1) + Strings.Format(Z, "0") + '°');
            }

            if (LHA <= 180d)
                SRLgTxtBx.AppendText(" W" + " <- <- <- <- <-");
            if (LHA > 180d)
                SRLgTxtBx.AppendText(" E" + " <- <- <- <- <-");
            i = (short)(Conversion.Int(A7).ToString().Length + 4);
            if (optPepperday.Checked == true)
                SRLgTxtBx.AppendText(" S " + Strings.Space(9 - i) + Strings.Format(A7, "0.000"));
            if (optFarley.Checked == true)
                SRLgTxtBx.AppendText(" S7 " + Strings.Space(9 - i) + Strings.Format(A7, "0.000"));
            SRLgTxtBx.AppendText(Environment.NewLine);

            // Print ': Print
            var argTB1 = SRLgTxtBx;
            AlignCenterRTB(ref argTB1);
            SRLgTxtBx = argTB1;
            SRLgTxtBx.AppendText("EP L " + Strings.Format(EstLDeg, "0") + '°' + Strings.Format(EstLMin, "00.0") + "'");
            PlotOut.PlotSLEP = "EP L " + Strings.Format(EstLDeg, "0") + '°' + Strings.Format(EstLMin, "00.0") + "'";
            if (EstL > 0d)
            {
                SRLgTxtBx.AppendText(CommonGlobals.g_LatN);
                PlotOut.PlotSLEP += CommonGlobals.g_LatN;
                PlotOut.PlotLatNS = CommonGlobals.g_LatN;
            }

            if (EstL == 0d)
            {
                SRLgTxtBx.AppendText(CommonGlobals.g_StrSpace);
                PlotOut.PlotSLEP += CommonGlobals.g_LatN;
                PlotOut.PlotLatNS = CommonGlobals.g_LatN;
            }

            if (EstL < 0d)
            {
                SRLgTxtBx.AppendText(CommonGlobals.g_LatS);
                PlotOut.PlotSLEP += CommonGlobals.g_LatS;
                PlotOut.PlotLatNS = CommonGlobals.g_LatS;
            }

            SRLgTxtBx.AppendText("      EP Lo " + Strings.Format(EstLoDeg, "0") + '°' + Strings.Format(EstLoMin, "00.0") + "'");
            PlotOut.PlotSLEP += " EP Lo " + Strings.Format(EstLoDeg, "0") + '°' + Strings.Format(EstLoMin, "00.0") + "'";
            if (EstLo > 0d)
            {
                SRLgTxtBx.AppendText(CommonGlobals.g_LongW);
                PlotOut.PlotSLEP += CommonGlobals.g_LongW;
                PlotOut.PlotLongEW = CommonGlobals.g_LongW;
            }

            if (EstLo == 0d)
            {
                SRLgTxtBx.AppendText(CommonGlobals.g_StrSpace);
                PlotOut.PlotSLEP += CommonGlobals.g_LongW;
                PlotOut.PlotLongEW = CommonGlobals.g_LongW;
            }

            if (EstLo < 0d)
            {
                SRLgTxtBx.AppendText(CommonGlobals.g_LongE);
                PlotOut.PlotSLEP += CommonGlobals.g_LongE;
                PlotOut.PlotLongEW = CommonGlobals.g_LongE;
            }

            SRLgTxtBx.AppendText(Environment.NewLine);
            var argTB2 = SRLgTxtBx;
            AlignLeftRTB(ref argTB2);
            SRLgTxtBx = argTB2;
            SRLgTxtBx.AppendText("*Table entry values");
            if (k >= 82d & k <= 98d)
            {
                SRLgTxtBx.AppendText(Strings.Space(4) + "**If K is between 82" + '°' + " and 98" + '°' + " this C is interpolated.");
            }

            SRLgTxtBx.AppendText(Environment.NewLine);
            SRLgTxtBx.Refresh();
        }

        private void SelectAllText(ref TextBox TB)
        {
            TB.SelectionStart = 0;
            TB.SelectionLength = TB.Text.ToString().Length;
        }

        public void SetTxtBxUlineOn(ref RichTextBox TB)
        {
            TB.SelectionFont = new Font(TB.Font, FontStyle.Underline);
        }

        public void SetTxtBxBoldOn(ref RichTextBox TB)
        {
            TB.SelectionFont = new Font(TB.Font, FontStyle.Bold);
        }

        public void SetTxtBxtoReg(ref RichTextBox TB)
        {
            TB.SelectionFont = new Font(TB.Font, FontStyle.Regular);
        }

        public void AlignCenterRTB(ref RichTextBox TB)
        {
            TB.SelectionAlignment = HorizontalAlignment.Center;
            return;
        }

        public void AlignLeftRTB(ref RichTextBox TB)
        {
            TB.SelectionAlignment = HorizontalAlignment.Left;
            return;
        }
        // Public Sub AlignRightRTB(ByRef TB As System.Windows.Forms.RichTextBox)
        // TB.SelectionAlignment = HorizontalAlignment.Right
        // Exit Sub
        // End Sub
        public void ClearAllRptTextBx()
        {
            SRHdrTxtBx.Visible = false;
            SRHdrTxtBx.Clear();
            SRHdrTxtBx.SendToBack();
            SRLgTxtBx.Clear();
            SRLgTxtBx.Visible = false;
            SRLgTxtBx.SendToBack();
            SRLeftTxtBx.Clear();
            SRLeftTxtBx.Visible = false;
            SRLeftTxtBx.SendToBack();
            SRRightTxtBx.Clear();
            SRRightTxtBx.Visible = false;
            SRRightTxtBx.SendToBack();
            NASRAsmTxtBx.Clear();
            NASRAsmTxtBx.Visible = false;
            NASRAsmTxtBx.SendToBack();
            NASRAFTxtBx.Clear();
            NASRAFTxtBx.Visible = false;
            NASRAFTxtBx.SendToBack();
            DCorrTxtBx.Clear();
            DCorrTxtBx.Visible = false;
            DCorrTxtBx.SendToBack();
            return;
        }

        private void ErrorMsgBox(string ErrMsg)
        {
            MessageBox.Show(ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            return;
        }

        private void btnUseCLS_Click(object sender, EventArgs e)
        {
            PlotOut.PsnName = "Alt SR Method";
            PlotOut.SquadronName = "Alt SR Method";
            PlotOut.PlotType = "Sight";
            txtSightNum += 1;
            PlotOut.PlotNumber = txtSightNum.ToString("##0");
            PlotOut.PlotDT = DTSight.Value;
            PlotOut.PlotLLoBy = cboLLoBy.Text.ToString();
            if (InvokedbySightLog == true)
            {
                PlotOut.PlotBody = cboBody.Text.ToString().Trim();
                if (PlotOut.PlotBody == "Sun" | PlotOut.PlotBody == "Moon")
                {
                    PlotOut.PlotBody += " " + cbLimb.Text.ToString().Trim();
                }
            }
            else
            {
                PlotOut.PlotBody = txtSightNum.ToString("##0") + " AltSRBody";
            }

            PlotOut.PlotLat = Convert.ToDouble(txtLDeg.Text) + Convert.ToDouble(txtLMin.Text) / 60.0d;
            PlotOut.PlotLatDeg = txtLDeg.Text;
            PlotOut.PlotLatMin = txtLMin.Text;
            PlotOut.PlotLatSec = "0";
            PlotOut.PlotLatNS = cboL.Items[cboL.SelectedIndex].ToString().Trim();
            PlotOut.PlotLong = Convert.ToDouble(txtLoDeg.Text) + Convert.ToDouble(txtLoMin.Text) / 60.0d;
            PlotOut.PlotLongDeg = txtLoDeg.Text;
            PlotOut.PlotLongMin = txtLoMin.Text;
            PlotOut.PlotLongSec = "0";
            PlotOut.PlotLongEW = cboLo.Items[cboLo.SelectedIndex].ToString().Trim();
            PlotOut.PlotIntercept = Math.Abs(KPLOPDist).ToString("#0.0") + "nm";
            if (KPLOPDist > 0d)
            {
                PlotOut.PlotIntercept += " Away";
            }
            else
            {
                PlotOut.PlotIntercept += " Toward";
            }

            PlotOut.PlotExtendedLines = true;
            PlotOut.PlotSLEP = "EP L " + EstLDeg.ToString("#0") + '°' + EstLMin.ToString("00.0") + "' " + PlotOut.PlotLatNS + " " + "EP Lo " + EstLoDeg.ToString("##0") + '°' + EstLoMin.ToString("00.0") + "' " + PlotOut.PlotLongEW;
            var PlotSave = PlotOut;
            My.MyProject.Forms.CLSForm.AddPlotEntry(PlotOut);

            // if this is NOT a Law of Cosines sight reduction (it is a tabular ALT SR Method) then format Assumed Position and its intercept
            if (LOCSight == false)
            {
                txtSightNum += 1;
                PlotOut.PlotNumber = txtSightNum.ToString("##0");
                PlotOut.PlotDT = DTSight.Value;
                PlotOut.PlotLLoBy = "AP";
                if (InvokedbySightLog == true)
                {
                    PlotOut.PlotBody = cboBody.Text.ToString().Trim();
                    if (PlotOut.PlotBody == "Sun" | PlotOut.PlotBody == "Moon")
                    {
                        PlotOut.PlotBody += " " + cbLimb.Text.ToString().Trim();
                    }
                }
                else
                {
                    PlotOut.PlotBody = txtSightNum.ToString("##0") + " AltSRBody";
                }

                double tmpLatD = APEstL;
                PlotOut.PlotLat = Math.Abs(AsmL);
                PlotOut.PlotLatDeg = Math.Abs(AsmL).ToString("#0");
                PlotOut.PlotLatMin = "00.0";
                PlotOut.PlotLatSec = "0";
                if (APEstL > 0d)
                {
                    PlotOut.PlotLatNS = CommonGlobals.g_LatN;
                }
                else
                {
                    PlotOut.PlotLatNS = CommonGlobals.g_LatS;
                }

                PlotOut.PlotLong = AsmLo;
                PlotOut.PlotLongDeg = AsmLoDeg.ToString("##0");
                PlotOut.PlotLongMin = AsmLoMin.ToString("00.0");
                PlotOut.PlotLongSec = "0";
                if (APEstLo >= 0d)
                {
                    PlotOut.PlotLongEW = CommonGlobals.g_LongW;
                }
                else
                {
                    PlotOut.PlotLongEW = CommonGlobals.g_LongE;
                }

                // these next three fields are formatted in each of the separate calculation routines and formated in the PlotOut structure
                // PlotOut.PlotAz = Ztot.ToString("##0.0") & Chr(176)
                PlotOut.PlotIntercept = Math.Abs(A).ToString("#0.0") + "nm";
                if (A > 0d)
                {
                    PlotOut.PlotIntercept += " Away";
                }
                else
                {
                    PlotOut.PlotIntercept += " Toward";
                }

                PlotOut.PlotSLEP = "EP L " + APEstLDeg.ToString("#0") + '°' + APEstLMin.ToString("00.0") + "' " + PlotOut.PlotLatNS + " " + "EP Lo " + APEstLoDeg.ToString("##0") + '°' + APEstLoMin.ToString("00.0") + "' " + PlotOut.PlotLongEW;
                My.MyProject.Forms.CLSForm.AddPlotEntry(PlotOut);
            }

            My.MyProject.Forms.CLSForm.txtUserInfo.Text = txtUserInfo.Text;
            if (My.MyProject.Forms.CLSForm.PlotSight() == true)
            {
                My.MyProject.Forms.CLSForm.Show();
                My.MyProject.Forms.CLSForm.SetDesktopLocation(5, 5); // 
                My.MyProject.Forms.CLSForm.BringToFront();
            }
            // restore original PlotOut since an AP may have been done over the top of it
            PlotOut = PlotSave;
            return;
        }

        private void btnCustomPlot_Click(object sender, EventArgs e)
        {
            PlotOut.PsnName = "Alt SR Method";
            PlotOut.SquadronName = "Alt SR Method";
            PlotOut.PlotType = "Sight";
            txtSightNum += 1;
            PlotOut.PlotNumber = txtSightNum.ToString("##0");
            PlotOut.PlotDT = DTSight.Value;
            PlotOut.PlotLLoBy = cboLLoBy.Text.ToString();
            if (InvokedbySightLog == true)
            {
                PlotOut.PlotBody = cboBody.Text.ToString().Trim();
                if (PlotOut.PlotBody == "Sun" | PlotOut.PlotBody == "Moon")
                {
                    PlotOut.PlotBody += " " + cbLimb.Text.ToString().Trim();
                }
            }
            else
            {
                PlotOut.PlotBody = txtSightNum.ToString("##0") + " AltSRBody";
            }

            PlotOut.PlotLat = Convert.ToDouble(txtLDeg.Text) + Convert.ToDouble(txtLMin.Text) / 60.0d;
            PlotOut.PlotLatDeg = txtLDeg.Text;
            PlotOut.PlotLatMin = txtLMin.Text;
            PlotOut.PlotLatSec = "0";
            PlotOut.PlotLatNS = cboL.Items[cboL.SelectedIndex].ToString().Trim();
            PlotOut.PlotLong = Convert.ToDouble(txtLoDeg.Text) + Convert.ToDouble(txtLoMin.Text) / 60.0d;
            PlotOut.PlotLongDeg = txtLoDeg.Text;
            PlotOut.PlotLongMin = txtLoMin.Text;
            PlotOut.PlotLongSec = "0";
            PlotOut.PlotLongEW = cboLo.Items[cboLo.SelectedIndex].ToString().Trim();
            PlotOut.PlotIntercept = Math.Abs(KPLOPDist).ToString("#0.0") + "nm";
            if (KPLOPDist > 0d)
            {
                PlotOut.PlotIntercept += " Away";
            }
            else
            {
                PlotOut.PlotIntercept += " Toward";
            }

            PlotOut.PlotExtendedLines = true;
            var PlotSave = PlotOut;
            My.MyProject.Forms.CustomPlot.AddPlotEntry(PlotOut);
            if (LOCSight == false)
            {
                txtSightNum += 1;
                PlotOut.PlotNumber = txtSightNum.ToString("##0");
                PlotOut.PlotDT = DTSight.Value;
                PlotOut.PlotLLoBy = "AP";
                if (InvokedbySightLog == true)
                {
                    PlotOut.PlotBody = cboBody.Text.ToString().Trim();
                    if (PlotOut.PlotBody == "Sun" | PlotOut.PlotBody == "Moon")
                    {
                        PlotOut.PlotBody += " " + cbLimb.Text.ToString().Trim();
                    }
                }
                else
                {
                    PlotOut.PlotBody = txtSightNum.ToString("##0") + " AltSRBody";
                }

                double tmpLatD = APEstL;
                PlotOut.PlotLat = Math.Abs(AsmL);
                PlotOut.PlotLatDeg = Math.Abs(AsmL).ToString("#0");
                PlotOut.PlotLatMin = "00.0";
                PlotOut.PlotLatSec = "0";
                if (APEstL > 0d)
                {
                    PlotOut.PlotLatNS = CommonGlobals.g_LatN;
                }
                else
                {
                    PlotOut.PlotLatNS = CommonGlobals.g_LatS;
                }

                PlotOut.PlotLong = AsmLo;
                PlotOut.PlotLongDeg = AsmLoDeg.ToString("##0");
                PlotOut.PlotLongMin = AsmLoMin.ToString("00.0");
                PlotOut.PlotLongSec = "0";
                if (APEstLo >= 0d)
                {
                    PlotOut.PlotLongEW = CommonGlobals.g_LongW;
                }
                else
                {
                    PlotOut.PlotLongEW = CommonGlobals.g_LongE;
                }

                // these next three fields are formatted in each of the separate calculation routines and formated in the PlotOut structure
                // PlotOut.PlotAz = Ztot.ToString("##0.0") & Chr(176)
                PlotOut.PlotIntercept = Math.Abs(A).ToString("#0.0") + "nm";
                if (A > 0d)
                {
                    PlotOut.PlotIntercept += " Away";
                }
                else
                {
                    PlotOut.PlotIntercept += " Toward";
                }

                PlotOut.PlotSLEP = "EP L " + APEstLDeg.ToString("#0") + '°' + APEstLMin.ToString("00.0") + "'" + PlotOut.PlotLatNS + " " + "EP Lo " + APEstLoDeg.ToString("##0") + '°' + APEstLoMin.ToString("00.0") + "'" + PlotOut.PlotLongEW;
                My.MyProject.Forms.CustomPlot.AddPlotEntry(PlotOut);
            }

            My.MyProject.Forms.CustomPlot.txtUserInfo.Text = txtUserInfo.Text;
            if (My.MyProject.Forms.CustomPlot.PlotSight() == true)
            {
                My.MyProject.Forms.CustomPlot.Show();
                My.MyProject.Forms.CustomPlot.SetDesktopLocation(5, 5); // 
                My.MyProject.Forms.CustomPlot.BringToFront();
            }

            PlotOut = PlotSave;
            return;
        }

        public static bool CheckOpenWinForms(string FormNameIn)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name.Equals(FormNameIn, StringComparison.CurrentCulture))
                {
                    return true;
                    return default;
                }
            }

            return false;
            return default;
        }

        public void SendMsgBx(string SendStr, MessageBoxIcon IconType)
        {
            // this subroutine is required because issuing a raw SendMsgBx call also trigger a Paint event for graphic box on form which cannot be handled properly in error conditions
            // IssuingSendMsgBx = True
            string HdrStr = Constants.vbNullString;
            // HdrStr = IconType.ToString
            if (IconType == MessageBoxIcon.Error)
            {
                HdrStr = "Input Error";
            }
            else if (IconType == MessageBoxIcon.Warning)
            {
                HdrStr = "Warning Message";
            }
            else if (IconType == MessageBoxIcon.Information)
            {
                HdrStr = "Information Message";
            }
            else if (IconType == MessageBoxIcon.Stop)
            {
                HdrStr = "STOP - Program Error";
            }
            else
            {
                HdrStr = "General Message";
            }

            MessageBox.Show(SendStr, HdrStr, MessageBoxButtons.OK, IconType, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            Show();
            return;
        }
    }
}