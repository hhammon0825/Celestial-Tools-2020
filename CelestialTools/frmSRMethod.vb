Option Strict Off
Option Explicit On
Imports System.Reflection
Imports VB = Microsoft.VisualBasic
Friend Class FormAltSR
    Inherits System.Windows.Forms.Form
    Public InvokedbySightLog As Boolean = False
    'Private ReadOnly DecLOC As Double
    Private Ho As Double
    Private GHA As Double
    Private DE As Double
    Private Hc As Double
    Private A As Double
    Dim i As Short
    Dim APEstLMin, APEstL, APEstLo, APEstLoMin As Double
    Dim APEstLDeg, APEstLoDeg As Double
    Dim LHAMin, EstLMin, EstL, EstLo, EstLoMin, Pi As Double
    Dim L8, L6, L4, L2, L1, L3, L5, L7, Z As Double
    Private LHADeg As Short
    Private EstLDeg As Short
    'Private ReadOnly GHADeg As Short
    Private EstLoDeg As Short
    Private HcDeg As Short
    Dim HcMin As Double
    Dim fnumeral As String
    Dim HoDeg, DecDegrees, AsmLoDeg As Short
    Dim DecMinutes, HoMin As Double
    Dim AsmLHA, GHAAsm, BMin As Double
    Dim AsmLoMin, Z1display As Single
    Dim BDeg As Short 'BMin As Integer
    Dim B1, Z3, A1, Aval, Z1, B As Double
    Dim AvalDeg, AvalMin As Short
    Dim P1, Z4, F, H, H1, Z2, P As Double
    Dim DecMinDisplay As Short
    Dim HDeg, PDeg, FMin, FDeg, AWhole, FWhole, HMin As Short
    Dim Z2Display1, Z2Display2 As Single
    Dim GHAAsmDeg, GHAAsmMin As Short
    Dim SignCorr1, SignF, SignZ1, SignB, SignDE, SignZ2, SignCorr2 As String 'LoDiff As Single
    Dim Ztot, Corr1, Corr2, HoinMinutes As Double
    Dim ZtotDisplay As Single
    Dim HtotDeg, HtotMin As Short ',Htot As Single
    Dim LengthZ2Display, LengthZ1Display, LengthZtotDisplay As Short
    'ReadOnly Z2Deg As Short
    Private IU As Short
    Private II As Short
    'Private ReadOnly IJ As Short
    'ReadOnly ZTTemp As Integer
    'some below not necessary
    ReadOnly FZH(50) As Double
    ReadOnly FZM(50) As Double
    ReadOnly FZS(50) As Double
    ReadOnly FMI(50) As Double
    ReadOnly FZN(50) As Double
    ReadOnly FLD(50) As String
    ReadOnly FLM(50) As String
    ReadOnly FL(50) As Double
    ReadOnly FMD(50) As Double
    ReadOnly FMM(50) As Double
    ReadOnly FM(50) As String
    ReadOnly FZT(50) As Double
    ReadOnly FUT(50) As Double
    ReadOnly FD(50) As String
    ReadOnly FGHA(50) As Double      'added in V5.6.1
    ReadOnly FDec(50) As Double      'added in V5.6.1
    ReadOnly FHo(50) As Double    'added in V5.6.1
    ReadOnly FLA(50) As String
    ReadOnly FLo(50) As String
    ReadOnly FDTSight(50) As Date
    ReadOnly FEP(50) As String
    ReadOnly FBody(50) As String
    'Public FixData4(), FixData2(), FixData1(), FixData3(), FixData5() As SFixData
    'Public FixData9(), FixData7(), FixData6(), FixData8(), FixData10() As SFixData
    'Public FixData11(), FixData12() As SFixData

    Public FixData1, FixData2, FixData3, FixData4, FixData5 As SFixData
    Public FixData6, FixData7, FixData8, FixData9, FixData10 As SFixData
    Public FixData11, FixData12 As SFixData

    Public Structure SFixData
        Public SFZH As Double
        Public SFZM As Double
        Public SFZS As Double
        Public SFMI As Double
        Public SFZN As Double
        Public SFLD As String
        Public SFLM As String
        Public SFL As Double
        Public SFMD As Double
        Public SFMM As Double
        Public SFM As String
        Public SFZT As Double
        Public SFUT As Double
        Public sFD As String
        Public SBF As String
        Public sFLA As String
        Public SFLo As Double
        Public SFGHA As Double
        Public SFDec As Double
        Public SFHo As Double
        Public SEP As String
    End Structure


    Private AsmL, AsmLo As Double 'AsmL was integer
    Private Lo As Double
    Private KPLOPDist As Double
    Private Hk, VL, DL, DLo, VLo As Single
    Private Dec, ZN, L, LHA, Htot As Double
    Private FlagMD, FlagSRFLoCNASR As Boolean ' ,HoinMinutes As Double
    Private D, DecIncr, AsmDec As Single
    Private TabHcDeg, NextHcDeg As Short
    Private NextHc, TabHcMin, NextHcMin As Double
    Private SignD As String
    Private dcorr As Single
    Private Signdcorr As String
    Private TotHc, TotHcMin As Double
    Private sgnHc, TotHcDeg, sgnTotHc As Short
    Private Zdiff, Zcorr1 As Double
    Private SignZdiff, SignTotcorr As String
    Private d1corr, TabZ, Zcorr As Single
    Private Totcorr As Single
    Private DSDcorr, d2corr As Double
    Private SgnD As Short
    Private NextHcDSD1, NextHcDSD1Min As Double
    Private NextHcDSD1Deg As Short
    Private NextHcDSD2, NextHcDSD2Min As Double
    Private NextHcDSD2Deg As Short
    Private NextHctP As Double
    Private NextHcdP As Double
    Private NextHcdM As Double
    'Private ReadOnly NextHctM As Double
    Private DSD3, DSD1, DSD As Single
    Private DSD2 As Double
    Private SgnDSD As Short
    Private DSDcorrFlag As Boolean
    Private ZL8, ZL6, ZL4, ZL5, ZL7, ZC As Double
    Private T, tMin As Double
    Private tDeg As Short
    Private A6, A4, A2, A3, A5, A7 As Single
    Private B4, B2, B3, B5 As Single
    Private k, KMin As Double
    Private KDeg As Short
    Private tDecimal, KL, KLMin, DecDecimal As Double
    Private KLDeg As Short
    Private A3AngleMin, A3Angle, A3AngleDecimal As Double
    Private A3AngleDeg As Short
    Private HcDecimal, HcAngle, ZMin As Double
    Private ZDeg As Short
    Private Flag, Flag0 As Boolean
    Private AsmDecDeg As Short
    Private LHAdiff, AsmDecMin, Ldiff As Single

    Private SignL, Signd2corr, SignA3 As String
    Private B1Deg, A3Deg As Short
    Private A3Min As Double
    Private B1Min As Double
    'Private ReadOnly DB As Double
    Private L2Deg, h1Deg, h2Deg, L3Deg As Short
    Private L2Min, h1Min, h2Min, L3Min As Double
    'Private ReadOnly NextDec As Double
    Private LHADecimal As Double
    'Private ReadOnly r As Double
    'Private ReadOnly NextDecMin As Double
    Private FlagFarley, FlagWeems As Boolean
    'ReadOnly NextDecDeg As Short
    Private Btot, KdMin, N, Kd, AB, B22 As Double

    Private Sub btnNASRFix_Click(sender As Object, e As EventArgs) Handles btnNASRFix.Click
        ' saved NASR AP/EP data to fix interface
        II = II + 1
        IU = IU + 1
        If IU > 12 Then
            ErrorMsgBox("Too many sights saved - the limit is 12 saved sights")
            Exit Sub
        End If
        If IU > 1 Then
            cmdFix.Visible = True
            cmdFix.Enabled = True
            cmdFix.Text = "Establish Fix for " & IU.ToString("#0") & " sights"
        End If
        If InvokedbySightLog = True Then
            FBody(II) = cboBody.Text.ToString.Trim
            If cboBody.Text.ToString.Trim = "Sun" Or cboBody.Text.ToString.Trim = "Moon" Then
                FBody(II) &= " " & cbLimb.Text.ToString.Trim
            End If
        Else
            FBody(II) = " AltSRBody" & txtSightNum.ToString("##0")
        End If


        FZH(II) = DTSight.Value.Hour    '  VB.Left(txtTime.Text, 2)
        FZM(II) = DTSight.Value.Minute      'Mid(txtTime.Text, 3, 2) ': FZS(II) = Right(txtTime.Text, 2)
        FZS(II) = DTSight.Value.Second
        FDTSight(II) = DTSight.Value
        'FZU(II) = DTSight.Value.ToUniversalTime.Subtract(New DateTime(1970, 1, 1, 0, 0, 0))
        'FMI(II) = System.Math.Sign(KPLOPDist) * Int((System.Math.Abs(KPLOPDist) * 10 + 0.5) / 10) 'changed in V4.0.0
        FMI(II) = System.Math.Sign(A) * Int((System.Math.Abs(A) * 10 + 0.5) / 10) 'changed in V4.0.0
        If A > 0 Then
            FD(II) = "A" 'PlotOut.PlotIntercept &= " Away"
        Else
            FD(II) = "T" 'PlotOut.PlotIntercept &= " Toward"
        End If
        FZN(II) = Int(System.Math.Round(ZN, 0)) 'changed in V4.0.0
        FL(II) = AsmL
        'FLD(II) = Int(L).ToString("00")
        FLD(II) = Int(AsmL).ToString("00")
        FLM(II) = "00.0"
        FLA(II) = cboL.Items(cboL.SelectedIndex).ToString
        FLo(II) = AsmLo
        FMD(II) = Convert.ToDouble(AsmLoDeg) 'Int(Lo)
        FMM(II) = Convert.ToDouble(AsmLoMin) 'Lo - Int(Lo)
        FM(II) = cboLo.Items(cboLo.SelectedIndex).ToString

        FGHA(II) = GHA      'added in V5.6.1
        FDec(II) = Dec      'added in V5.6.1
        FHo(II) = Ho        'added in V5.6.1
        'FEP(II) = PlotOut.PlotSLEP
        FEP(II) = "AP/EP L " & APEstLDeg.ToString("#0") & Chr(176) & APEstLMin.ToString("00.0") & "' " & cboL.Items(cboL.SelectedIndex).ToString &
            "AP/EP Lo " & APEstLoDeg.ToString("##0") & Chr(176) & APEstLoMin.ToString("00.0") & "' " & cboLo.Items(cboLo.SelectedIndex).ToString

        ' now add DR position to fix data
        'II = II + 1
        'IU = IU + 1
        'If IU > 12 Then
        '    ErrorMsgBox("Too many sights saved - the limit is 12 saved sights")
        '    Exit Sub
        'End If
        'If IU > 1 Then
        '    cmdFix.Visible = True
        '    cmdFix.Enabled = True
        '    cmdFix.Text = "Establish Fix for " & IU.ToString("#0") & " sights"
        'End If
        'If InvokedbySightLog = True Then
        '    FBody(II) = cboBody.Text.ToString.Trim
        '    If cboBody.Text.ToString.Trim = "Sun" Or cboBody.Text.ToString.Trim = "Moon" Then
        '        FBody(II) &= " " & cbLimb.Text.ToString.Trim
        '    End If
        'Else
        '    FBody(II) = " AltSRBody" & txtSightNum.ToString("##0")
        'End If


        'FZH(II) = DTSight.Value.Hour    '  VB.Left(txtTime.Text, 2)
        'FZM(II) = DTSight.Value.Minute      'Mid(txtTime.Text, 3, 2) ': FZS(II) = Right(txtTime.Text, 2)
        'FZS(II) = DTSight.Value.Second
        'FDTSight(II) = DTSight.Value
        'FMI(II) = System.Math.Sign(KPLOPDist) * Int((System.Math.Abs(KPLOPDist) * 10 + 0.5) / 10) 'changed in V4.0.0
        'If KPLOPDist > 0 Then
        '    FD(II) = "A" 'PlotOut.PlotIntercept &= " Away"
        'Else
        '    FD(II) = "T" 'PlotOut.PlotIntercept &= " Toward"
        'End If
        'FZN(II) = Int(ZN + 0.5) 'changed in V4.0.0
        'FL(II) = L
        'FLD(II) = txtLDeg.Text
        'FLM(II) = txtLMin.Text
        'FLA(II) = cboL.Items(cboL.SelectedIndex).ToString
        'FLo(II) = Lo
        'FMD(II) = txtLoDeg.Text
        'FMM(II) = txtLoMin.Text
        'FM(II) = cboLo.Items(cboLo.SelectedIndex).ToString

        'FGHA(II) = GHA      'added in V5.6.1
        'FDec(II) = Dec      'added in V5.6.1
        'FHo(II) = Ho        'added in V5.6.1
        ''FEP(II) = PlotOut.PlotSLEP
        'FEP(II) = "EP L " & EstLDeg.ToString("#0") & Chr(176) & EstLMin.ToString("00.0") & "' " & cboL.Items(cboL.SelectedIndex).ToString &
        '    "EP Lo " & EstLoDeg.ToString("##0") & Chr(176) & EstLoMin.ToString("00.0") & "' " & cboLo.Items(cboLo.SelectedIndex).ToString

        SendMsgBx("Sight reduction data saved - Enter new sight data", MessageBoxIcon.Information)
        cmdSave.Visible = False
        Exit Sub
    End Sub

    Private KdDeg As Short 'B34 As Double
    Private Z4Deg As Short
    ReadOnly ZnTDeg As Short
    'ReadOnly ZnT As Double
    Private Z4Min As Double
    Private ReadOnly ZnTMin As Double
    Private ZLoc As Double, ZnLoC As Double, ZnLoCDeg As Short, ZnLoCMin As Double         'ZnT As Double, ZnTDeg As Integer, ZnTMin As Double,
    Private FormAltSRLoaded As Boolean = False
    Private Hpv As Double, HpvDeg As Short, HpvMin As Double
    ReadOnly DTInit As DateTime = New DateTime(1901, 1, 1, 1, 1, 1)
    Private PlotOut As CLSForm.PlotEntry
    Private txtSightNum As Integer = 0
    Private LOCSight As Boolean = False
    Private Sub CboDec_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDec.SelectedIndexChanged
        Me.Refresh()
        Exit Sub
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        If CheckOpenWinForms("FormMeridianDiagram") = True Then
            FormMeridianDiagram.ExitBtn.PerformClick()
            FormMeridianDiagram.Close()

        End If
        If InvokedbySightLog = True Then
            SightLog.FormAltSRLoaded = False
            InvokedbySightLog = False
        End If
        Me.Close()
        Exit Sub
    End Sub

    Private Sub chkDSD_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkDSD.CheckStateChanged
        cmd229_Click(cmd229, New System.EventArgs())
    End Sub

    Private Sub chkInterpolateB_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkInterpolateB.CheckStateChanged
        cmdWeems_Click(cmdWeems, New System.EventArgs())
    End Sub

    Private Sub chkSadler_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkSadler.CheckStateChanged
        If chkSadler.CheckState = 1 Then
            chkDSD.Visible = False
            frameNASRUsing.Visible = False
            frame211.Visible = True ': optCompact.Value = True
            frame214.Visible = False
            Label9.Visible = False
            FlagSRFLoCNASR = True
            MainMenu.FormSRFFlagSRFLocNASR = False
            DecimalDegrees()
            Sadler()
            If Flag = True Then Exit Sub
            EstimatedPosition()
            DisplaySadler()
            AssignPlotPosition()
            cmdSave.Visible = False
            btnUseCLS.Visible = True
            btnCustomPlot.Visible = True
            cmdMerDiag.Visible = True
            cmdMerDiag.Enabled = True
        End If

        If chkSadler.CheckState = 0 Then cmd211_Click(cmd211, New System.EventArgs())
    End Sub

    Private Sub cmd208_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmd208.Click
        chkDSD.Visible = False
        chkSadler.Visible = False
        LOCSight = False
        FlagSRFLoCNASR = True
        MainMenu.FormSRFFlagSRFLocNASR = False
        DecimalDegrees()
        HO208()
        If Flag0 = True Then Exit Sub
        APEPNASR()
        KPLOPNASR()
        EPNASR()
        Display208()
        AssignPlotPosition()

        cmdSave.Visible = False
        btnUseCLS.Visible = True
        btnCustomPlot.Visible = True
        cmdMerDiag.Visible = True
        cmdMerDiag.Enabled = True
    End Sub

    Private Sub cmd211_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmd211.Click
        chkDSD.Visible = False
        chkSadler.Visible = False
        LOCSight = False
        chkSadler.CheckState = System.Windows.Forms.CheckState.Unchecked
        FlagSRFLoCNASR = True
        MainMenu.FormSRFFlagSRFLocNASR = False
        DecimalDegrees()
        HO211()
        If Flag = True Then Exit Sub
        EstimatedPosition()
        Display211()
        AssignPlotPosition()
        cmdSave.Visible = False
        btnUseCLS.Visible = True
        btnCustomPlot.Visible = True
        cmdMerDiag.Visible = True
        cmdMerDiag.Enabled = True
    End Sub

    Private Sub cmd214_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmd214.Click
        chkDSD.Visible = False
        chkSadler.Visible = False
        LOCSight = False
        FlagSRFLoCNASR = True
        MainMenu.FormSRFFlagSRFLocNASR = False
        DecimalDegrees()
        HO214()
        If optd.Checked = True Then
            APEPNASR()
            KPLOPNASR()
            EPNASR()
        End If
        If optdt.Checked = True Then
            AsmLo = System.Math.Abs(Lo)
            APEPNASR()
            KPLOPNASR()
            EPNASR()
        End If
        If optdtL.Checked = True Then
            EstimatedPosition()
        End If
        Display214()
        AssignPlotPosition()
        cmdSave.Visible = False
        btnUseCLS.Visible = True
        btnCustomPlot.Visible = True
        cmdMerDiag.Visible = True
        cmdMerDiag.Enabled = True
    End Sub

    Private Sub cmdWeems_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdWeems.Click
        FlagWeems = True
        chkDSD.Visible = False
        chkSadler.Visible = False
        LOCSight = False
        FlagSRFLoCNASR = True
        MainMenu.FormSRFFlagSRFLocNASR = False
        DecimalDegrees()
        Weems()
        APEPNASR()
        KPLOPNASR()
        EPNASR()
        DisplayWeems()
        AssignPlotPosition()
        cmdSave.Visible = False
        btnUseCLS.Visible = True
        btnCustomPlot.Visible = True
        cmdMerDiag.Visible = True
        cmdMerDiag.Enabled = True

    End Sub

    Private Sub cmd229_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmd229.Click
        chkDSD.Visible = True
        chkSadler.Visible = False
        LOCSight = False
        FlagSRFLoCNASR = True
        MainMenu.FormSRFFlagSRFLocNASR = False
        DecimalDegrees()
        HO229()
        APEPNASR()
        KPLOPNASR()
        EPNASR()
        Display229()
        AssignPlotPosition()
        cmdSave.Visible = False
        btnUseCLS.Visible = True
        btnCustomPlot.Visible = True
        cmdMerDiag.Visible = True
        cmdMerDiag.Enabled = True
    End Sub

    Private Sub cmd249_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmd249.Click
        chkDSD.Visible = False
        chkSadler.Visible = False
        LOCSight = False
        frameNASRUsing.Visible = False
        FlagSRFLoCNASR = True
        MainMenu.FormSRFFlagSRFLocNASR = False
        DecimalDegrees()
        HO249()
        APEPNASR()
        KPLOPNASR()
        EPNASR()
        Display249()
        AssignPlotPosition()
        cmdSave.Visible = False
        btnUseCLS.Visible = True
        btnCustomPlot.Visible = True
        cmdMerDiag.Visible = True
        cmdMerDiag.Enabled = True
    End Sub

    Private Sub cmdClear_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClear.Click
        txtGHADeg.Text = ""
        txtGHAMin.Text = ""
        txtDecDeg.Text = ""
        txtDecMin.Text = ""
        txtHoDeg.Text = ""
        txtHoMin.Text = ""
        txtLDeg.Text = ""
        txtLMin.Text = ""
        txtLoDeg.Text = ""
        txtLoMin.Text = ""
        DTSight.Value = DTInit

        frameNASRUsing.Visible = False

        GroupBoxPrecision.Visible = False      'V5.6.1
        chkDSD.CheckState = System.Windows.Forms.CheckState.Unchecked
        chkDSD.Visible = False
        chkSadler.Visible = False
        chkInterpolateB.Visible = False

        chkDSD.CheckState = System.Windows.Forms.CheckState.Unchecked
        chkDSD.Visible = False
        chkSadler.Visible = False
        chkInterpolateB.Visible = False
        btnUseCLS.Visible = False
        btnCustomPlot.Visible = False
        frame211.Visible = False
        frame214.Visible = False
        Label9.Visible = False
        ClearAllRptTextBx()

        cmdMerDiag.Enabled = False
        cmdMerDiag.Visible = False

        txtGHADeg.Focus()
    End Sub
    Private Sub cmdClearSome_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClearSome.Click
        txtGHADeg.Text = ""
        txtGHAMin.Text = ""
        txtDecDeg.Text = ""
        txtDecMin.Text = ""
        txtHoDeg.Text = ""
        txtHoMin.Text = ""
        DTSight.Value = DTInit

        frameNASRUsing.Visible = False
        GroupBoxPrecision.Visible = False      'V5.6.1
        chkDSD.CheckState = System.Windows.Forms.CheckState.Unchecked
        chkDSD.Visible = False
        chkSadler.Visible = False
        chkInterpolateB.Visible = False
        frame211.Visible = False
        frame214.Visible = False
        Label9.Visible = False
        btnUseCLS.Visible = False
        btnCustomPlot.Visible = False
        ClearAllRptTextBx()

        txtGHADeg.Focus()
    End Sub


    Private Sub cmdMerDiag_Click_1(sender As Object, e As EventArgs) Handles cmdMerDiag.Click
        If CheckOpenWinForms("FormMeridianDiagram") = True Then
            FormMeridianDiagram.ExitBtn.PerformClick()
            FormMeridianDiagram.Close()
        End If

        FormMeridianDiagram.Show()
        FormMeridianDiagram.SetDesktopLocation(5,5) '
        FormMeridianDiagram.FormSRFFlagMD = False
        FormMeridianDiagram.FormAltSRFlagMD = True
        FormMeridianDiagram.L = L
        FormMeridianDiagram.Ho = Htot
        FormMeridianDiagram.ZN = ZN
        FormMeridianDiagram.LHA = LHA
        FormMeridianDiagram.Dec = Dec
        FormMeridianDiagram.BodyName = ""
        FormMeridianDiagram.DisplayMerDiag()
        FormMeridianDiagram.FormSRFFlagMD = False
        FormMeridianDiagram.FormAltSRFlagMD = False
        cmdMerDiag.Enabled = False
        cmdMerDiag.Visible = False
        Exit Sub
    End Sub

    'Public Sub cmdMerDiag_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
    '    FormMeridianDiagram.Show()
    '    FormMeridianDiagram.FormSRFFlagMD = False
    '    FormMeridianDiagram.FormAltSRFlagMD = True
    '    FormMeridianDiagram.DisplayMerDiag()
    '    FormMeridianDiagram.FormSRFFlagMD = False
    '    FormMeridianDiagram.FormAltSRFlagMD = False
    '    cmdMerDiag.Enabled = False
    'End Sub

    Private Sub cmdNASR_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNASR.Click
        chkDSD.Visible = False
        chkSadler.Visible = False
        LOCSight = False
        FlagSRFLoCNASR = True
        MainMenu.FormSRFFlagSRFLocNASR = False
        DecimalDegrees()
        NASR()
        APEPNASR()
        KPLOPNASR()
        EPNASR()
        DisplayNASR()
        AssignPlotPosition()
        cmdSave.Visible = False
        btnNASRFix.Visible = True
        btnUseCLS.Visible = True
        btnCustomPlot.Visible = True
        cmdMerDiag.Visible = True
        cmdMerDiag.Enabled = True
    End Sub

    Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
        PrintScreen(Me.Bounds)
    End Sub

    Private Sub cmdSTable_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSTable.Click
        chkDSD.Visible = False
        chkSadler.Visible = False
        LOCSight = False
        FlagSRFLoCNASR = True
        MainMenu.FormSRFFlagSRFLocNASR = False
        DecimalDegrees()
        STable()
        If Flag = True Then Exit Sub 'WHAT IS THIS FOR?
        EstimatedPosition()
        DisplaySTable()
        cmdSave.Visible = False
        btnUseCLS.Visible = True
        btnCustomPlot.Visible = True
        cmdMerDiag.Visible = True
        cmdMerDiag.Enabled = True

    End Sub

    Private Sub Form_Initialize_Renamed()
        Pi = 4 * System.Math.Atan(1.0#)
    End Sub

    Private Sub cmdLawOfCosines_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdLawOfCosines.Click
        If DTSight.Value = DTInit Then
            ErrorMsgBox("Must enter minimum of hhmm time for Law of Cosines sight reduction")
            Exit Sub
        End If
        LOCSight = True
        'If txtTime.Text = "" Or txtTime.Text.Length < 4 Then
        '    ErrorMsgBox("Must enter hhmm time for Law of Cosines sight reduction")
        '    Exit Sub
        'End If
        chkDSD.Visible = False
        chkSadler.Visible = False
        FlagSRFLoCNASR = True
        MainMenu.FormSRFFlagSRFLocNASR = False
        DecimalDegrees()
        LawOfCosines()
        EstimatedPosition()
        DisplayLOC()
        cmdSave.Visible = True
        btnNASRFix.Visible = False
        btnUseCLS.Visible = True
        btnCustomPlot.Visible = True
        cmdMerDiag.Visible = True
        cmdMerDiag.Enabled = True

    End Sub

    Private Sub FormAltSR_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        cboDec.SelectedIndex = 0 '"N"
        cboL.SelectedIndex = 0 '"N"
        cboLo.SelectedIndex = 0 '"W"

        SRHdrTxtBx.Visible = False
        SRHdrTxtBx.Clear()

        SRLgTxtBx.Clear()
        SRLgTxtBx.Visible = False

        SRLeftTxtBx.Clear()
        SRLeftTxtBx.Visible = False

        SRRightTxtBx.Clear()
        SRRightTxtBx.Visible = False

        btnUseCLS.Visible = False
        btnCustomPlot.Visible = False

        LOCSight = False
        ' FormAltSR SR Methods load event code
        If FavoriteLocations.SharedLocUse.EntryStatus = "Shared" Then
            Me.BringToFront()
            If FavoriteLocations.CommonYesNoMsgBox("Shared Location data is available - do you want to use it?") = True Then
                With FavoriteLocations.SharedLocUse
                    txtLDeg.Text = .DRLatDeg.ToString
                    txtLMin.Text = .DRLatMin.ToString
                    If .DRLatNS = g_LatN Then
                        cboL.SelectedIndex = 0
                    Else
                        cboL.SelectedIndex = 1
                    End If
                    txtLoDeg.Text = .DRLongDeg.ToString
                    txtLoMin.Text = .DRLongMin.ToString
                    If .DRLongEW = g_LongW Then
                        cboLo.SelectedIndex = 0
                    Else
                        cboLo.SelectedIndex = 1
                    End If
                End With
            End If
        End If

        FormAltSRLoaded = True
    End Sub
    Public Sub DisplayLOC()
        'Me.Font = New Font(Me.Font, "Courier New")
        SRHdrTxtBx.Visible = True
        SRHdrTxtBx.Clear()
        SRHdrTxtBx.BringToFront()

        SRLgTxtBx.Clear()
        SRLgTxtBx.Visible = True
        SRLgTxtBx.BringToFront()

        SRLeftTxtBx.Clear()
        SRLeftTxtBx.Visible = False
        SRLeftTxtBx.SendToBack()

        SRRightTxtBx.Clear()
        SRRightTxtBx.Visible = False
        SRRightTxtBx.SendToBack()

        NASRAsmTxtBx.Clear()
        NASRAsmTxtBx.Visible = False
        NASRAsmTxtBx.SendToBack()

        NASRAFTxtBx.Clear()
        NASRAFTxtBx.Visible = False
        NASRAFTxtBx.SendToBack()

        DCorrTxtBx.Clear()
        DCorrTxtBx.Visible = False
        DCorrTxtBx.SendToBack()

        WeemsPVTxtBx.Clear()            'V5.6.1
        WeemsPVTxtBx.Visible = False    'V5.6.1
        WeemsPVTxtBx.SendToBack()       'V5.6.1

        frameNASRUsing.Visible = False
        frame211.Visible = False
        frame214.Visible = False
        Label9.Visible = False
        frameS.Visible = False
        GroupBoxPrecision.Visible = True      'V5.6.1
        chkInterpolateB.Visible = False
        'CurrentY = 2260

        AlignCenterRTB(SRHdrTxtBx)
        SRHdrTxtBx.AppendText("INTERCEPT and AZIMUTH by the LAW of COSINES METHOD")

        SRLgTxtBx.AppendText(vbTab & vbTab & vbTab & vbTab & "LHA" & Space(6 - LHADeg.ToString.Length) & Strings.Format(LHADeg, "0") & Chr(176) & Strings.Format(LHAMin, "00.0") & "' " & Space(2) & "-------> LHA" & Space(15 - LHADeg.ToString.Length) & Strings.Format(LHA, "0.00000") & Chr(176) & vbNewLine)
        SRLgTxtBx.AppendText(vbTab & vbTab & vbTab & vbTab & "Lat" & Space(6 - Val(txtLDeg.Text).ToString.Length) & Strings.Format(Val(txtLDeg.Text), "0") & Chr(176) & Strings.Format(Val(txtLMin.Text), "00.0") & "'" & cboL.Text & Space(1) & "-------> Lat (+)" & Space(11 - txtLDeg.Text.Length) & Strings.Format(System.Math.Abs(L), "0.00000") & Chr(176) & vbNewLine)
        SRLgTxtBx.AppendText(vbTab & vbTab & vbTab & vbTab & "Dec" & Space(6 - DecDegrees.ToString.Length) & Strings.Format(System.Math.Abs(DecDegrees), "0") & Chr(176) & Strings.Format(DecMinutes, "00.0") & "'")
        If DE = 0 Then
            SRLgTxtBx.AppendText("")
        Else
            SRLgTxtBx.AppendText(cboDec.Text)
        End If
        SRLgTxtBx.AppendText(Space(1) & "-------> Dec (" & SignDE & ")")
        SRLgTxtBx.AppendText(Space(11 - DecDegrees.ToString.Length) & Strings.Format(System.Math.Abs(DE), "0.00000") & Chr(176) & vbNewLine)

        SRLgTxtBx.AppendText("(cos LHA x cos Lat x cos Dec) + (sin Lat x sin Dec) = sin Hc ---->" & "   Hc " & Strings.Format(Int(Hc * 100000 + 0.5) / 100000, "0.00000") & Chr(176) & vbNewLine)

        SRLgTxtBx.AppendText("(sin Dec - (sin Lat x sin Hc)) / (cos Lat x cos Hc) = cos Z ----->" & "   Z  " & cboL.Text & Space(1) & Strings.Format(Int(Z * 10 + 0.5) / 10, "0.0") & Chr(176))

        If LHA <= 180 Then SRLgTxtBx.AppendText(" W")

        If LHA > 180 Then SRLgTxtBx.AppendText(" E")
        SRLgTxtBx.AppendText(vbNewLine)

        SRLgTxtBx.AppendText("Hc ")

        If System.Math.Sign(Hc) = -1 Then
            SRLgTxtBx.AppendText(vbTab & "-")
        Else
            SRLgTxtBx.AppendText(vbTab & " ")
        End If

        SRLgTxtBx.AppendText(Strings.Format(System.Math.Abs(HcDeg), "0") & Chr(176) & Strings.Format(HcMin, "00.0") & "'" & vbNewLine)

        SRLgTxtBx.AppendText("Ho ")

        If System.Math.Sign(HoinMinutes) = -1 Then
            SRLgTxtBx.AppendText(vbTab & "-")
        Else
            SRLgTxtBx.AppendText(vbTab & " ")
        End If

        SRLgTxtBx.AppendText(Strings.Format(System.Math.Abs(HoDeg), "0") & Chr(176) & Strings.Format(System.Math.Abs(HoMin), "00.0") & "'" & vbNewLine)
        i = Int(System.Math.Abs(A) * 10 + 0.5).ToString.Length
        If System.Math.Abs(A) < 1 Then
            i = i + 1
        End If

        SRLgTxtBx.AppendText(" a" & Space(12 - i) & Strings.Format(System.Math.Abs(A), "0.0") & " nm ")
        PlotOut.PlotIntercept = Strings.Format(System.Math.Abs(A), "0.0") & " nm "
        If A <> 0 And A < 0 Then
            SRLgTxtBx.AppendText("T  Ho > Hc....Toward")
            PlotOut.PlotIntercept &= " Toward"
        End If
        If A <> 0 And A > 0 Then
            SRLgTxtBx.AppendText("A  Hc > Ho....Away")
            PlotOut.PlotIntercept &= " Away"
        End If

        SRLgTxtBx.AppendText(Space(32) & "Zn " & Strings.Format(ZN, "000") & Chr(176) & vbNewLine)
        PlotOut.PlotAz = Strings.Format(ZN, "000") & Chr(176)
        SRLgTxtBx.AppendText("EP L  " & Space(11 - EstLDeg.ToString.Length) & Strings.Format(EstLDeg, "0") & Chr(176) & Strings.Format(EstLMin, "00.0") & "'")
        PlotOut.PlotSLEP = "EP L  " & Strings.Format(EstLDeg, "0") & Chr(176) & Strings.Format(EstLMin, "00.0") & "'"
        If EstL > 0 Then
            SRLgTxtBx.AppendText(g_LatN)
            PlotOut.PlotSLEP &= g_LatN
            PlotOut.PlotLatNS = g_LatN
        End If

        If EstL = 0 Then
            SRLgTxtBx.AppendText(g_StrSpace)
            PlotOut.PlotSLEP &= g_LatN
            PlotOut.PlotLatNS = g_LatN
        End If

        If EstL < 0 Then
            SRLgTxtBx.AppendText(g_LatS)
            PlotOut.PlotSLEP &= g_LatS
            PlotOut.PlotLatNS = g_LatS
        End If
        SRLgTxtBx.AppendText(vbNewLine)

        SRLgTxtBx.AppendText("EP Lo " & Space(11 - EstLoDeg.ToString.Length) & Strings.Format(EstLoDeg, "0") & Chr(176) & Strings.Format(EstLoMin, "00.0") & "'")
        PlotOut.PlotSLEP &= " EP Lo " & Strings.Format(EstLoDeg, "0") & Chr(176) & Strings.Format(EstLoMin, "00.0") & "'"
        If EstLo > 0 Then
            SRLgTxtBx.AppendText(g_LongW)
            PlotOut.PlotSLEP &= g_LongW
            PlotOut.PlotLongEW = g_LongW
        End If

        If EstLo = 0 Then
            SRLgTxtBx.AppendText(g_StrSpace)
            PlotOut.PlotSLEP &= g_LongW
            PlotOut.PlotLongEW = g_LongW
        End If

        If EstLo < 0 Then
            SRLgTxtBx.AppendText(g_LongE)
            PlotOut.PlotSLEP &= g_LongE
            PlotOut.PlotLongEW = g_LongE
        End If

        SRLgTxtBx.Refresh()

    End Sub
    Public Sub LawOfCosines()
        'This section moved from DecimalDegrees in V5.6.1 for LawOfCosines only
        GHA = Val(txtGHADeg.Text) + Val(txtGHAMin.Text) / 60
        'GHA = Int(GHA * 100000 + 0.5) / 100000             NOT ADDED V4.3.0
        DE = Val(txtDecDeg.Text) + Val(txtDecMin.Text) / 60
        If optRound.Checked Then
            DE = Int(DE * 100000 + 0.5) / 100000              'ADDED V4.3.0,  removed in V4.7.1 and moved to LoC only, optRound in V5.6.1
        End If
        Dec = DE
        If cboDec.Text = "S" Then
            Dec = -DE
        End If
        DecDegrees = Int(DE)
        DecMinutes = (DE - DecDegrees) * 60
        If Int(DecMinutes * 10 + 0.5) / 10 = 60 Then
            DecMinutes = 0
            DecDegrees = DecDegrees + 1
        End If
        Ho = Val(txtHoDeg.Text) + Val(txtHoMin.Text) / 60
        'Ho = Int(Ho * 100000 + 0.5) / 100000
        HoinMinutes = Ho * 60
        HoDeg = Fix(HoinMinutes / 60)  'min to dec. deg.; Fix was Int
        HoMin = Math.Abs((HoinMinutes - 60 * HoDeg) + 0.5)
        'HoMin = HoinMinutes - 60 * HoDeg
        'HoMin = Int(HoMin + 0.5)
        If Int(HoMin * 10 + 0.5) / 10 = 60 Then
            HoMin = 0
            HoDeg = HoDeg + 1
        End If
        L = Val(txtLDeg.Text) + Val(txtLMin.Text) / 60
        If optRound.Checked Then L = Int(L * 100000 + 0.5) / 100000                  'ADDED V4.3.0, optRound in V5.6.1
        If cboL.Text = "S" Then L = -L
        Lo = Val(txtLoDeg.Text) + Val(txtLoMin.Text) / 60
        If cboLo.Text = "E" Then Lo = -Lo
        LHA = GHA - Lo
        If optRound.Checked Then LHA = Int(LHA * 100000 + 0.5) / 100000              'ADDED V4.3.0, optRound in V5.6.1
        If LHA >= 360 Then LHA = LHA - 360
        If LHA < 0 Then LHA = LHA + 360
        LHADeg = Int(LHA)
        LHAMin = (LHA - LHADeg) * 60
        LHAMin = Int(LHAMin * 10 + 0.5) / 10
        If Int(LHAMin * 10 + 0.5) / 10 = 60 Then
            LHAMin = 0
            LHADeg = LHADeg + 1
        End If

        'DE = Int(DE * 100000 + 0.5) / 100000 'Moved from DecimalDegrees in V4.7.1
        SignDE = "+"
        If (cboDec.Text = "S" And cboL.Text = "N") Or (cboDec.Text = "N" And cboL.Text = "S") Then
            DE = -DE
            SignDE = "-"
        End If
        L1 = System.Math.Cos(LHA * Pi / 180) * System.Math.Cos(System.Math.Abs(L) * Pi / 180) * System.Math.Cos(DE * Pi / 180)
        L2 = System.Math.Sin(System.Math.Abs(L) * Pi / 180) * System.Math.Sin(DE * Pi / 180)
        L3 = L1 + L2
        If System.Math.Abs(L3) >= 1 Then
            Hc = System.Math.Sign(L3) * Pi / 2
        Else
            Hc = System.Math.Atan(L3 / System.Math.Sqrt(-L3 * L3 + 1))
        End If
        Hc = Hc * 180 / Pi
        If optRound.Checked Then
            Hc = Int(Hc * 10000 + 0.5) / 10000      'added in V5.1.5, optRound in V5.6.1
        End If
        Htot = Hc
        HcDeg = Fix(Hc)
        HcMin = (Hc - HcDeg) * 60
        HcMin = Int(HcMin * 10 + 0.5) / 10
        If HcMin = 60 Then
            HcMin = 0
            If HcDeg >= 0 Then HcDeg = HcDeg + 1
            If HcDeg < 0 Then HcDeg = HcDeg - 1
        End If
        A = (60 * HcDeg + HcMin) - (60 * HoDeg + HoMin)
        A = System.Math.Sign(A) * Int((System.Math.Abs(A) * 10 + 0.5) / 10)
        L4 = System.Math.Sin(DE * Pi / 180)
        L5 = System.Math.Sin(System.Math.Abs(L) * Pi / 180) * System.Math.Sin(Hc * Pi / 180)
        L6 = L4 - L5
        L7 = System.Math.Cos(System.Math.Abs(L) * Pi / 180) * System.Math.Cos(Hc * Pi / 180)
        L8 = L6 / L7
        If System.Math.Abs(L8) >= 1 Then Z = Pi Else Z = System.Math.Atan(-L8 / System.Math.Sqrt(-L8 * L8 + 1)) + Pi / 2
        Z = Z * 180 / Pi
        Z = Int(Z * 10 + 0.5) / 10 'round to one decimal place
        If cboL.Text = "N" And LHA > 180 Then ZN = Z
        If cboL.Text = "N" And LHA <= 180 Then ZN = 360 - Z
        If cboL.Text = "S" And LHA > 180 Then ZN = 180 - Z
        If cboL.Text = "S" And LHA <= 180 Then ZN = 180 + Z

        ZN = Int(ZN + 0.5)
        If ZN = 360 Then ZN = 0
        HcDeg = Fix(Hc)
        HcMin = System.Math.Abs((Hc - HcDeg) * 60)
        If Int(HcMin * 10 + 0.5) / 10 = 60 Then
            HcMin = 0
            If HcDeg >= 0 Then HcDeg = HcDeg + 1
            If HcDeg < 0 Then HcDeg = HcDeg - 1
        End If
        Exit Sub
    End Sub

    Private Sub FormAltSR_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        'Cleanup()
    End Sub

    Private Sub optCompact_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optCompact.CheckedChanged
        If Not FormAltSRLoaded Then Exit Sub

        If optCompact.Checked Then 'eventSender.Checked Then
            cmd211_Click(cmd211, New System.EventArgs())
        End If
    End Sub

    Private Sub optd_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optd.CheckedChanged
        If Not FormAltSRLoaded Then Exit Sub
        If optd.Checked Then   'eventSender.Checked Then
            cmd214_Click(cmd214, New System.EventArgs())
        End If
    End Sub

    Private Sub optdt_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optdt.CheckedChanged
        If Not FormAltSRLoaded Then Exit Sub
        If optd.Checked Then    'eventSender.Checked Then
            cmd214_Click(cmd214, New System.EventArgs())
        End If
    End Sub

    Private Sub optdtL_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optdtL.CheckedChanged
        If Not FormAltSRLoaded Then Exit Sub
        If optdtL.Checked Then   'eventSender.Checked Then
            cmd214_Click(cmd214, New System.EventArgs())
        End If
    End Sub

    Private Sub optFarley_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optFarley.CheckedChanged
        If Not FormAltSRLoaded Then Exit Sub
        If optFarley.Checked Then   'eventSender.Checked Then
            cmdSTable_Click(cmdSTable, New System.EventArgs())
        End If
    End Sub

    Private Sub optNATable_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optNATable.CheckedChanged
        If Not FormAltSRLoaded Then Exit Sub
        If optNATable.Checked Then 'eventSender.Checked Then
            cmdNASR_Click(cmdNASR, New System.EventArgs())
        End If
    End Sub

    Private Sub optOriginal_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optOriginal.CheckedChanged
        If Not FormAltSRLoaded Then Exit Sub
        If optOriginal.Checked Then 'eventSender.Checked Then
            'chkSadler.Value = 0
            cmd211_Click(cmd211, New System.EventArgs())
        End If
    End Sub

    Private Sub optPepperday_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optPepperday.CheckedChanged
        If Not FormAltSRLoaded Then Exit Sub
        If optPepperday.Checked Then 'eventSender.Checked Then
            cmdSTable_Click(cmdSTable, New System.EventArgs())
        End If
    End Sub

    Private Sub optUSPSTable_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optUSPSTable.CheckedChanged
        If Not FormAltSRLoaded Then Exit Sub
        If eventSender.Checked Then
            cmdNASR_Click(cmdNASR, New System.EventArgs())
        End If
    End Sub

    Private Sub txtDecDeg_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDecDeg.TextChanged
        If Val(txtDecDeg.Text) <> 90 Then
            txtDecMin.Enabled = True
        End If
        If Val(txtDecDeg.Text) = 90 Then
            txtDecMin.Enabled = False
            txtDecMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000B)
        End If
        txtDecDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtDecDeg.Text) > 90 Or (Val(txtDecDeg.Text) = 90 And Val(txtDecMin.Text) <> 0) Then
            txtDecDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
        If Val(txtDecDeg.Text) < 90 Then
            txtDecMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        End If
    End Sub

    Private Sub txtDecDeg_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtDecDeg.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(Chr(8))
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Else
                KeyAscii = 0
                Beep()
        End Select
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtDecDeg_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtDecDeg.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtDecDeg.Text) > 90 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtDecDeg_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDecDeg.Enter
        SelectAllText(txtDecDeg)
    End Sub

    Private Sub txtDecMin_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDecMin.TextChanged
        'txtDecMin.ForeColor = &H80000008
        txtDecMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtDecMin.Text) > 59.9 Then
            txtDecMin.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
    End Sub

    Private Sub txtDecMin_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtDecMin.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtDecMin.Text, ".") Then
                    If KeyAscii = 46 Then KeyAscii = 0
                    Beep()
                End If
            Case Asc(Chr(8))
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Else
                KeyAscii = 0
                Beep()
        End Select
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Sub txtDecMin_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtDecMin.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtDecMin.Text) > 59.9 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtDecMin_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDecMin.Enter
        SelectAllText(txtDecMin)
    End Sub

    Private Sub txtGHADeg_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtGHADeg.TextChanged
        txtGHADeg.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtGHADeg.Text) > 719 Then
            txtGHADeg.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
    End Sub
    Private Sub txtGHADeg_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtGHADeg.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(Chr(8))
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Else
                KeyAscii = 0
                Beep()
        End Select
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Sub txtGHADeg_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtGHADeg.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtGHADeg.Text) > 719 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtGHADeg_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtGHADeg.Enter
        SelectAllText(txtGHADeg)
    End Sub

    Private Sub txtGHAMin_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtGHAMin.TextChanged
        txtGHAMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtGHAMin.Text) > 59.9 Then
            txtGHAMin.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
    End Sub

    Private Sub txtGHAMin_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtGHAMin.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtGHAMin.Text, ".") Then
                    If KeyAscii = 46 Then KeyAscii = 0
                    Beep()
                End If
            Case Asc(Chr(8))
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Else
                KeyAscii = 0
                Beep()
        End Select
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Sub txtGHAMin_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtGHAMin.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtGHAMin.Text) > 59.9 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtGHAMin_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtGHAMin.Enter
        SelectAllText(txtGHAMin)
    End Sub

    Private Sub txtHoDeg_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHoDeg.TextChanged
        cmdNASR.Enabled = True
        cmdLawOfCosines.Enabled = True
        cmd229.Enabled = True
        txtHoDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        txtHoMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtHoDeg.Text) = 90 Then
            txtHoMin.Enabled = False
            txtHoMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000B)
        End If
        If Val(txtHoDeg.Text) > 90 Then
            txtHoDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
        If Val(txtHoDeg.Text) > 88 Or (Val(txtHoDeg.Text) = 88 And Val(txtHoMin.Text) <> 0) Then cmdLawOfCosines.Enabled = False
        If Val(txtHoDeg.Text) > 85 Or (Val(txtHoDeg.Text) = 85 And Val(txtHoMin.Text) <> 0) Then cmd229.Enabled = False
        If Val(txtHoDeg.Text) > 75 Or (Val(txtHoDeg.Text) = 75 And Val(txtHoMin.Text) <> 0) Then cmdNASR.Enabled = False
    End Sub

    Private Sub txtHoDeg_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtHoDeg.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(Chr(8))
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Else
                KeyAscii = 0
                Beep()
        End Select
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtHoDeg_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtHoDeg.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtHoDeg.Text) > 90 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtHoDeg_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHoDeg.Enter
        SelectAllText(txtHoDeg)
    End Sub

    Private Sub txtHoMin_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHoMin.TextChanged
        cmdNASR.Enabled = True
        cmdLawOfCosines.Enabled = True
        cmd229.Enabled = True
        txtHoMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtHoMin.Text) > 59.9 Then
            txtHoMin.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
        If Val(txtHoDeg.Text) > 88 Or (Val(txtHoDeg.Text) = 88 And Val(txtHoMin.Text) <> 0) Then
            cmdLawOfCosines.Enabled = False
        End If
        If Val(txtHoDeg.Text) > 85 Or (Val(txtHoDeg.Text) = 85 And Val(txtHoMin.Text) <> 0) Then
            cmd229.Enabled = False
        End If
        If Val(txtHoDeg.Text) > 75 Or (Val(txtHoDeg.Text) = 75 And Val(txtHoMin.Text) <> 0) Then
            cmdNASR.Enabled = False
        End If
    End Sub

    Private Sub txtHoMin_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtHoMin.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Static bMinusSignAlready As Boolean
        Static bPlusSignAlready As Boolean
        bMinusSignAlready = False
        bPlusSignAlready = False
        Select Case KeyAscii
            Case System.Windows.Forms.Keys.Back, System.Windows.Forms.Keys.Right, System.Windows.Forms.Keys.Left
                'do nothing
            Case Asc("0") To Asc("9")
                'do nothing
            Case Asc("-")
                'If txtHoMin.Text) > 0 Then
                '    KeyAscii = 0
                '    Beep
                'End If
                If txtHoMin.SelectionStart <> 0 Or bMinusSignAlready Then
                    KeyAscii = 0
                    Beep()
                Else
                    bMinusSignAlready = True
                End If
            Case Asc("+")
                'If txtHoMin.Text) > 0 Then
                '    KeyAscii = 0
                '    Beep
                'End If

                If txtHoMin.SelectionStart <> 0 Or bPlusSignAlready Then
                    KeyAscii = 0
                    Beep()
                Else
                    bPlusSignAlready = True
                End If

            Case Asc(".") 'only allows one decimal point
                If InStr(txtHoMin.Text, ".") Then
                    If KeyAscii = 46 Then
                        KeyAscii = 0
                        Beep()
                    End If
                End If

            Case Asc(Chr(8))
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Else
                KeyAscii = 0
                Beep()
        End Select

        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtHoMin_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtHoMin.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtHoMin.Text) > 59.9 Or Val(txtHoMin.Text) < -59.9 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtHoMin_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHoMin.Enter
        SelectAllText(txtHoMin)
    End Sub

    Private Sub txtLDeg_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLDeg.TextChanged
        If Val(txtLDeg.Text) <> 90 Then txtLMin.Enabled = True
        If Val(txtLDeg.Text) = 90 Then
            txtLMin.Text = ""
            txtLMin.Enabled = False
            txtLMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000B)
        End If
        txtLDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtLDeg.Text) > 90 Then
            txtLDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
        If Val(txtLDeg.Text) < 90 Then
            txtLMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        End If
    End Sub

    Private Sub txtLDeg_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtLDeg.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(Chr(8))
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Else
                KeyAscii = 0
                Beep()
        End Select
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtLDeg_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtLDeg.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtLDeg.Text) > 90 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtLDeg_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLDeg.Enter
        SelectAllText(txtLDeg)
    End Sub

    Private Sub txtLMin_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLMin.TextChanged
        'txtLMin.ForeColor = &H80000008
        txtLMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtLMin.Text) > 59.9 Then
            txtLMin.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
    End Sub

    Private Sub txtLMin_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtLMin.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtLMin.Text, ".") Then
                    If KeyAscii = 46 Then KeyAscii = 0
                    Beep()
                End If
            Case Asc(Chr(8))
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Else
                KeyAscii = 0
                Beep()
        End Select
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtLMin_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtLMin.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtLMin.Text) > 59.9 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtLMin_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLMin.Enter
        SelectAllText(txtLMin)
    End Sub

    Private Sub txtLoDeg_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLoDeg.TextChanged
        If Val(txtLoDeg.Text) <> 180 Then
            txtLoMin.Enabled = True
        End If
        If Val(txtLoDeg.Text) = 180 Then
            txtLoMin.Text = ""
            txtLoMin.Enabled = False
            txtLoMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000B)
        End If
        txtLoDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtLoDeg.Text) > 180 Or (Val(txtLoDeg.Text) = 180 And Val(txtLoMin.Text) <> 0) Then
            txtLoDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
        If Val(txtLoDeg.Text) < 180 Then
            txtLoMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        End If
    End Sub

    Private Sub txtLoDeg_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtLoDeg.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(Chr(8))
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Else
                KeyAscii = 0
                Beep()
        End Select
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtLoDeg_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtLoDeg.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtLoDeg.Text) > 180 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtLoDeg_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLoDeg.Enter
        SelectAllText(txtLoDeg)
    End Sub

    Private Sub txtLoMin_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLoMin.TextChanged
        txtLoMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtLoMin.Text) > 59.9 Then
            txtLoMin.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
    End Sub

    Private Sub txtLoMin_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtLoMin.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtLoMin.Text, ".") Then
                    If KeyAscii = 46 Then KeyAscii = 0
                    Beep()
                End If
            Case Asc(Chr(8))
                fnumeral = fnumeral & Chr(KeyAscii)
                'Case Asc(",")
            Case Else
                KeyAscii = 0
                Beep()
        End Select
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtLoMin_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtLoMin.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtLoMin.Text) > 59.9 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtLoMin_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLoMin.Enter
        SelectAllText(txtLoMin)
    End Sub

    Public Sub DecimalDegrees()
        GHA = Val(txtGHADeg.Text) + Val(txtGHAMin.Text) / 60
        DE = Val(txtDecDeg.Text) + Val(txtDecMin.Text) / 60
        Dec = DE
        If cboDec.Text = "S" Then
            Dec = -DE
        End If
        DecDegrees = Int(DE)
        DecMinutes = (DE - DecDegrees) * 60
        If Int(DecMinutes * 10 + 0.5) / 10 = 60 Then
            DecMinutes = 0
            DecDegrees = DecDegrees + 1
        End If
        Ho = Val(txtHoDeg.Text) + Val(txtHoMin.Text) / 60
        HoinMinutes = Ho * 60
        HoDeg = Fix(HoinMinutes / 60) 'min to dec. deg.; Fix was Int
        HoMin = HoinMinutes - 60 * HoDeg
        If Int(HoMin * 10 + 0.5) / 10 = 60 Then
            HoMin = 0
            HoDeg = HoDeg + 1
        End If
        L = Val(txtLDeg.Text) + Val(txtLMin.Text) / 60
        L = Int(L * 100000 + 0.5) / 100000 'ADDED V4.3.0
        If cboL.Text = "S" Then L = -L
        Lo = Val(txtLoDeg.Text) + Val(txtLoMin.Text) / 60
        If cboLo.Text = "E" Then Lo = -Lo
        LHA = GHA - Lo
        LHA = Int(LHA * 100000 + 0.5) / 100000 'ADDED V4.3.0
        If LHA >= 360 Then LHA = LHA - 360
        If LHA < 0 Then LHA = LHA + 360
        LHADeg = Int(LHA)
        LHAMin = (LHA - LHADeg) * 60
        LHAMin = Int(LHAMin * 10 + 0.5) / 10
        If Int(LHAMin * 10 + 0.5) / 10 = 60 Then
            LHAMin = 0
            LHADeg = LHADeg + 1
        End If
        Exit Sub
    End Sub

    Public Sub EstimatedPosition()
        EstL = L - (A / 60) * System.Math.Cos(ZN * Pi / 180)
        EstLo = Lo + (A / 60) * System.Math.Sin(ZN * Pi / 180) / System.Math.Cos(L * Pi / 180)
        If System.Math.Abs(EstLo) > 180 Then EstLo = -System.Math.Sign(EstLo) * (360 - System.Math.Abs(EstLo))
        EstLDeg = Int(System.Math.Abs(EstL))
        EstLMin = (System.Math.Abs(EstL) - EstLDeg) * 60
        If Int(EstLMin * 10 + 0.5) / 10 = 60 Then
            EstLMin = 0
            EstLDeg = EstLDeg + 1
        End If
        EstLoDeg = Int(System.Math.Abs(EstLo))
        EstLoMin = (System.Math.Abs(EstLo) - EstLoDeg) * 60
        If Int(EstLoMin * 10 + 0.5) / 10 = 60 Then
            EstLoMin = 0
            EstLoDeg = EstLoDeg + 1
        End If
        EstLoDeg = System.Math.Abs(EstLoDeg)
        Exit Sub
    End Sub

    Public Sub NASR()
        LHA = GHA - Lo
        If LHA >= 360 Then LHA = LHA - 360
        If LHA < 0 Then LHA = LHA + 360
        AsmLHA = Int(LHA + 0.5)
        If AsmLHA = 360 Then AsmLHA = 0
        GHAAsmDeg = Val(txtGHADeg.Text)
        GHAAsmMin = Int(Val(txtGHAMin.Text) + 0.5)
        GHAAsm = GHAAsmDeg + GHAAsmMin / 60 'in degrees
        AsmLo = GHAAsm - AsmLHA
        If System.Math.Abs(AsmLo) < 180 Then AsmLo = 360 - System.Math.Abs(AsmLo)
        If System.Math.Abs(AsmLo) >= 180 And Lo >= 0 Then AsmLo = 360 - System.Math.Abs(AsmLo)
        If System.Math.Abs(AsmLo) >= 180 And Lo < 0 Then AsmLo = -(360 - System.Math.Abs(AsmLo))
        AsmLoDeg = Int(System.Math.Abs(AsmLo))
        If AsmLo > 0 Or txtLoDeg.Text = "180" Then AsmLoMin = Int(Val(txtGHAMin.Text) + 0.5) Else AsmLoMin = 60 - Int(Val(txtGHAMin.Text) + 0.5)
        If AsmLoMin = 60 Then AsmLoMin = 0
        AsmL = Int(L + 0.5)
        A1 = System.Math.Cos(AsmL * Pi / 180) * System.Math.Sin(AsmLHA * Pi / 180)
        If System.Math.Abs(A1) >= 1 Then Aval = System.Math.Sign(A1) * Pi / 2 Else Aval = System.Math.Atan(A1 / System.Math.Sqrt(-A1 * A1 + 1)) 'in radians
        AvalDeg = Int(System.Math.Abs(Aval * 180 / Pi))
        AvalMin = Int((System.Math.Abs(Aval * 180 / Pi) - AvalDeg) * 60 + 0.5)
        If AvalMin = 60 Then
            AvalMin = 0
            AvalDeg = AvalDeg + 1
        End If
        Z3 = System.Math.Cos(AsmLHA * Pi / 180) / System.Math.Cos(Aval) 'Example b p 2-24 bottom of first column makes Z3=1 NG
        'If Abs(Z3) = 1 Then Z3 = 0  'prevents program from crashing with no inputs
        If System.Math.Abs(Z3) >= 1 Then Z1 = System.Math.Sign(Z3) * Pi / 2 Else Z1 = System.Math.Atan(Z3 / System.Math.Sqrt(-Z3 * Z3 + 1)) 'in radians
        Z1display = Int(Z1 * 180 / Pi * 10 + 0.5) / 10
        B1 = System.Math.Cos(AsmL * Pi / 180) * System.Math.Sin(Z1)
        If System.Math.Abs(B1) >= 1 Then B = System.Math.Sign(B1) * Pi / 2 Else B = System.Math.Atan(B1 / System.Math.Sqrt(-B1 * B1 + 1)) 'in radians
        BDeg = Int(System.Math.Abs(B * 180 / Pi))
        BMin = Int((System.Math.Abs(B) * 180 / Pi - BDeg) * 60 + 0.5)
        If BMin = 60 Then
            BMin = 0
            BDeg = BDeg + 1
        End If
        If LHA > 90 And LHA < 270 Then SignB = "-" Else SignB = "+"
        If LHA > 90 And LHA < 270 Then SignZ1 = "-" Else SignZ1 = "+"
        SignDE = "+"
        DecMinDisplay = Int(Val(txtDecMin.Text) + 0.5)
        If DecMinDisplay = 60 Then
            DecMinDisplay = 0
            DecDegrees = DecDegrees + 1
        End If
        B = Int(B * 180 / Pi * 60 + 0.5) 'rounded to whole minutes
        DE = Int(DE * 60 + 0.50000000001) 'rounded to whole minutes
        If (cboDec.Text = "S" And cboL.Text = "N") Or (cboDec.Text = "N" And cboL.Text = "S") Then DE = -DE : SignDE = "-"
        F = B + DE 'in minutes
        F = F / 60 'in degrees
        FWhole = Int(F + 0.5)
        FDeg = Fix(F) 'Int(F)
        FMin = Int((System.Math.Abs(F - FDeg)) * 60 + 0.5) 'Int((F - FDeg) * 60 + 0.5)               'Round((F * 180 / Pi - FDeg) * 60)
        If FMin = 60 Then
            FMin = 0
            FDeg = FDeg + 1
        End If
        If System.Math.Sign(F) = 1 Then SignF = "+"
        If System.Math.Sign(F) = -1 Then SignF = "-"
        If System.Math.Sign(F) = 0 Then SignF = " "
        AWhole = Int(AvalDeg + AvalMin / 60 + 0.5)
        H1 = System.Math.Cos(AWhole * Pi / 180) * System.Math.Sin(System.Math.Abs(FWhole) * Pi / 180) 'Abs(FWhole) was FWhole
        If System.Math.Abs(H1) >= 1 Then H = System.Math.Sign(H1) * Pi / 2 Else H = System.Math.Atan(H1 / System.Math.Sqrt(-H1 * H1 + 1)) 'in radians
        If System.Math.Sign(F) = -1 Then H = -H
        HDeg = Fix(H * 180 / Pi)
        HMin = Int((H * 180 / Pi - HDeg) * 60 + 0.5)
        If HMin = 60 Then
            HMin = 0
            HDeg = HDeg + 1
        End If
        Z4 = System.Math.Cos(FWhole * Pi / 180) / System.Math.Cos(H) '76 with this line
        If System.Math.Abs(Z4) >= 1 Then Z2 = 0 Else Z2 = System.Math.Atan(Z4 / System.Math.Sqrt(-Z4 * Z4 + 1)) 'in radians   arcsine
        If System.Math.Sign(F) = -1 Then Z2 = Pi - Z2 'THIS IS FOR WHEN Z2>90 DEGREES - TABLE DOES NOT SHOW Z2>90 - use supplement, but use original to get corr2
        Z2Display1 = Int(Z2 * 180 / Pi * 10 + 0.5) / 10
        Z2Display2 = Int(Z2Display1 + 0.5) 'added in V5.1.5 to fix rounding
        P1 = System.Math.Abs(System.Math.Cos(AWhole * Pi / 180) * System.Math.Sin(Z2))
        If System.Math.Abs(P1) >= 1 Then P = System.Math.Sign(P1) * Pi / 2 Else P = System.Math.Atan(P1 / System.Math.Sqrt(-P1 * P1 + 1)) 'in radians
        PDeg = Int(P * 180 / Pi + 0.5)
        If PDeg > 80 Then P = 80 * Pi / 180 'If PDeg > 80 Then PDeg = 80
        If System.Math.Abs(Z2Display2) < 10 Then Z2 = 10 * Pi / 180 'If Z2Display < 10 Then Z2Display = 10
        If F > 90 Then SignZ2 = "-" Else SignZ2 = "+"
        If (F - FWhole) >= 0 Then Corr1 = FMin * System.Math.Sin(PDeg * Pi / 180) Else Corr1 = (60 - FMin) * System.Math.Sin(PDeg * Pi / 180)
        If H < 0 Then 'was HoinMinutes < 0
            If System.Math.Abs(F - FWhole) >= 0 Then Corr1 = System.Math.Sign(F) * FMin * System.Math.Sin(PDeg * Pi / 180) Else Corr1 = System.Math.Sign(F) * (60 - FMin) * System.Math.Sin(PDeg * Pi / 180)
        End If
        Corr1 = Int(Corr1 + 0.50000000000001) 'Why isn't 0.5 enough?
        If optNATable.Checked And PDeg = 30 And FMin Mod 2 <> 0 Then Corr1 = Corr1 - 1 'F is odd
        If (F < 90 And FMin > 29) Or (F > 90 And FMin < 30) Then Corr1 = -Corr1
        If System.Math.Sign(Corr1) = 1 Then SignCorr1 = "+"
        If System.Math.Sign(Corr1) = -1 Then SignCorr1 = "-"
        If System.Math.Sign(Corr1) = 0 Then SignCorr1 = " "
        If (System.Math.Abs(Aval * 180 / Pi) - System.Math.Abs(AWhole)) >= 0 Then Corr2 = AvalMin * System.Math.Cos(Z2Display2 * Pi / 180) Else Corr2 = (60 - AvalMin) * System.Math.Cos(Z2Display2 * Pi / 180) 'Added in V5.4.0
        If AvalMin = 0 Then Corr2 = 0
        Corr2 = Int(Corr2 + 0.50000000000001) 'Why isn't 0.5 enough?
        If optNATable.Checked And Int(System.Math.Abs(Z2Display2) + 0.5) = 60 And AvalMin Mod 2 <> 0 Then Corr2 = Corr2 - 1 'AvalMin is odd
        If AvalMin < 30 Then Corr2 = -Corr2
        If System.Math.Sign(Corr2) = 1 Then SignCorr2 = "+"
        If System.Math.Sign(Corr2) = -1 Then SignCorr2 = "-"
        If System.Math.Sign(Corr2) = 0 Then SignCorr2 = " "
        Ztot = (Z1display + Z2Display1)
        ZtotDisplay = Int(Ztot * 10 + 0.5) / 10
        If cboL.Text = "N" And LHA >= 180 Then ZN = ZtotDisplay
        If cboL.Text = "N" And LHA < 180 Then ZN = 360 - ZtotDisplay
        If cboL.Text = "S" And LHA >= 180 Then ZN = 180 - ZtotDisplay
        If cboL.Text = "S" And LHA < 180 Then ZN = 180 + ZtotDisplay
        If ZN < 0 Then ZN = ZN + 360
        If ZN >= 360 Then ZN = ZN - 360
        ZN = Int(ZN + 0.5) 'added in V4.0.0
        Htot = HDeg + (HMin + Corr1 + Corr2) / 60 'degrees
        sgnTotHc = System.Math.Sign(Htot)
        HtotDeg = Int(Htot)
        HtotMin = (Htot - HtotDeg) * 60
        If HtotMin = 60 Then
            HtotMin = 0
            HtotDeg = HtotDeg + 1
        End If
        HoMin = Int(HoMin + 0.5)
        A = (HtotDeg * 60 + HtotMin) - (HoDeg * 60 + HoMin)
        Exit Sub
    End Sub

    Public Sub DisplayNASR()
        cmdSave.Visible = False
        cmdFix.Visible = False
        cmdFix.Enabled = False
        cmdFix.Text = "Establish Fix"
        frame211.Visible = False
        frame214.Visible = False : Label9.Visible = False
        frameS.Visible = False
        GroupBoxPrecision.Visible = False      'V5.6.1
        chkInterpolateB.Visible = False

        SRHdrTxtBx.Clear()
        SRHdrTxtBx.Visible = True
        SRHdrTxtBx.BringToFront()

        SRLgTxtBx.Clear()
        SRLgTxtBx.Visible = False
        SRLgTxtBx.SendToBack()

        SRLeftTxtBx.Clear()
        SRLeftTxtBx.Visible = True
        SRLeftTxtBx.BringToFront()

        SRRightTxtBx.Clear()
        SRRightTxtBx.Visible = True
        SRRightTxtBx.BringToFront()

        NASRAsmTxtBx.Clear()
        NASRAsmTxtBx.Visible = True
        NASRAsmTxtBx.BringToFront()

        NASRAFTxtBx.Clear()
        NASRAFTxtBx.Visible = True
        NASRAFTxtBx.BringToFront()

        DCorrTxtBx.Clear()
        DCorrTxtBx.Visible = False
        DCorrTxtBx.SendToBack()

        WeemsPVTxtBx.Clear()            'V5.6.1
        WeemsPVTxtBx.Visible = False    'V5.6.1
        WeemsPVTxtBx.SendToBack()   'V5.6.1

        frameNASRUsing.Visible = True
        frameNASRUsing.BringToFront()

        AlignCenterRTB(SRHdrTxtBx)
        SRHdrTxtBx.AppendText("INTERCEPT and AZIMUTH by the NAUTICAL ALMANAC SIGHT REDUCTION TABLES")

        ' format left side text box
        AlignCenterRTB(NASRAsmTxtBx)
        SRLeftTxtBx.AppendText("Calc of Asm Lo & Asm LHA" & Space(20) & vbNewLine)
        SRLeftTxtBx.AppendText("   Tot GHA" & Space(7 - GHAAsmDeg.ToString.Length) & Strings.Format(GHAAsmDeg, "0") & Chr(176) & Strings.Format(GHAAsmMin, "00") & "'" & vbNewLine)

        SRLeftTxtBx.AppendText("   Asm Lo (")
        If AsmLo = 0 Then
            SignA3 = " "
            SRLeftTxtBx.AppendText(g_StrSpace)
        End If
        If System.Math.Sign(AsmLo) = 1 Then
            SRLeftTxtBx.AppendText("-")
            SignA3 = g_LongW
        End If
        If System.Math.Sign(AsmLo) = -1 Then
            SRLeftTxtBx.AppendText("+")
            SignA3 = g_LongE
        End If
        If System.Math.Sign(AsmLo) = 0 Then
            SRLeftTxtBx.AppendText(g_StrSpace)
            SignA3 = " "
        End If

        SRLeftTxtBx.AppendText(")" & Space(4 - AsmLoDeg.ToString.Length) & Strings.Format(AsmLoDeg, "0") & Chr(176) & Strings.Format(AsmLoMin, "00") & "'" & SignA3)
        SRLeftTxtBx.AppendText(vbNewLine)

        SRLeftTxtBx.AppendText("   Asm LHA" & Space(7 - AsmLHA.ToString.Length) & Strings.Format(AsmLHA, "0") & Chr(176) & vbNewLine)

        'format right side text box
        NASRAsmTxtBx.AppendText("Asm L " & Strings.Format(System.Math.Abs(AsmL), "0") & Chr(176))
        If AsmL = 0 Then
            NASRAsmTxtBx.AppendText(" " & "    Asm LHA " & Strings.Format(AsmLHA, "0") & Chr(176))
        Else

            NASRAsmTxtBx.AppendText(cboL.Text & "    Asm LHA " & Strings.Format(AsmLHA, "0") & Chr(176))
        End If
        ' newline 2 times to space past the NASR Asm text box
        SRRightTxtBx.AppendText(vbNewLine)
        SRRightTxtBx.AppendText(vbNewLine)
        ' now start writing first report text lines to right side text box
        LengthZ1Display = System.Math.Abs(Z1display).ToString.Length
        If System.Math.Abs(Z1display) - Int(System.Math.Abs(Z1display)) = 0 Then
            LengthZ1Display = LengthZ1Display + 2
        End If

        SRRightTxtBx.AppendText(Space(6) & "A " & Space(4 - AvalDeg.ToString.Length) & Strings.Format(AvalDeg, "0") & Chr(176) & Strings.Format(AvalMin, "00") & "'" & vbTab & vbTab &
                                "  B (" & SignB & ")" & Space(4 - BDeg.ToString.Length) & Strings.Format(System.Math.Abs(BDeg), "0") & Chr(176) & Strings.Format(BMin, "00") & "'" & vbTab & vbTab &
                                "Z1 (" & SignZ1 & ")" & Space(5 - LengthZ1Display) & Strings.Format(System.Math.Abs(Z1display), "0.0") & Chr(176))
        SRRightTxtBx.AppendText(vbNewLine)

        SRRightTxtBx.AppendText(vbTab & vbTab & vbTab & vbTab & "Dec (" & SignDE & ")" & Space(4 - DecDegrees.ToString.Length) & Strings.Format(DecDegrees, "0") & Chr(176) & Strings.Format(DecMinDisplay, "00") & "'" & cboDec.Text)
        SRRightTxtBx.AppendText(vbNewLine)

        SRRightTxtBx.AppendText(vbTab & vbTab & vbTab & vbTab & "  F (" & SignF & ")" & Space(4 - FDeg.ToString.Length) & Strings.Format(System.Math.Abs(FDeg), "0") & Chr(176) & Strings.Format(FMin, "00") & "'")
        SRRightTxtBx.AppendText(vbNewLine)
        SRRightTxtBx.AppendText(vbNewLine)
        SRRightTxtBx.AppendText(vbNewLine)
        AlignCenterRTB(NASRAFTxtBx)
        NASRAFTxtBx.AppendText("A " & Strings.Format(System.Math.Abs(AWhole), "0") & Chr(176) & vbTab & vbTab & "F " & Strings.Format(System.Math.Abs(FWhole), "0") & Chr(176)) 'Abs(FWhole) was FWhole

        LengthZ2Display = System.Math.Abs(Z2Display1).ToString.Length
        If System.Math.Abs(Z2Display1) - Int(System.Math.Abs(Z2Display1)) = 0 Then
            LengthZ2Display = LengthZ2Display + 2
        End If

        SRRightTxtBx.AppendText(Space(6) & "H  ")
        If H < 0 Then SRRightTxtBx.AppendText("    -")

        SRRightTxtBx.AppendText(Space(4 - System.Math.Abs(HDeg).ToString.Length) & Strings.Format(System.Math.Abs(HDeg), "0") & Chr(176) & Strings.Format(System.Math.Abs(HMin), "00") & "'" & vbTab & vbTab _
            & "P " & Strings.Format(PDeg, "0") & Chr(176) & Space(10) & "Z2 (" & SignZ2 & ")" & Space(7 - LengthZ2Display) & Strings.Format(System.Math.Abs(Z2Display1), "0.0") & Chr(176))
        SRRightTxtBx.AppendText(vbNewLine)

        i = PDeg.ToString.Length
        If PDeg < 10 Then
            i = 3
        End If

        SRRightTxtBx.AppendText(Space(6) & "corr 1 (" & SignCorr1 & ")" & Space(2) & Strings.Format(System.Math.Abs(Corr1), "00") & "'" _
                           & Space(5) & "(F' " & Strings.Format(FMin, "00") & ", Pº" & Space(4 - i) & Strings.Format(PDeg, "00") & ")")


        If H < 0 Then
            SRRightTxtBx.AppendText(vbTab & vbTab & "(supplement of " & Strings.Format(180 - Z2Display1, "0.0") & Chr(176) & ")")
        End If 'was HoinMinutes < 0
        SRRightTxtBx.AppendText(vbNewLine)

        SRRightTxtBx.AppendText(Space(6) & "corr 2 (" & SignCorr2 & ")" & Space(2) & Strings.Format(System.Math.Abs(Corr2), "00") & "'" _
                           & Space(5) & "(A' " & Strings.Format(AvalMin, "00") & ", Z2º" & Space(4 - Int(Z2Display2).ToString.Length) & Strings.Format(Int(System.Math.Abs(Z2Display2)), "0") & ")") 'added ABS to Z2Display after Healy tests
        SRRightTxtBx.AppendText(vbNewLine)

        LengthZtotDisplay = System.Math.Abs(ZtotDisplay).ToString.Length
        If System.Math.Abs(ZtotDisplay) - Int(System.Math.Abs(ZtotDisplay)) = 0 Then LengthZtotDisplay = LengthZtotDisplay + 2

        SRRightTxtBx.AppendText(Space(6) & "Hc")

        If sgnTotHc = -1 Then SRRightTxtBx.AppendText("     -")

        SRRightTxtBx.AppendText(Space(4 - System.Math.Abs(HtotDeg).ToString.Length) & Strings.Format(System.Math.Abs(HtotDeg), "0") & Chr(176) & Strings.Format(System.Math.Abs(HtotMin), "00") & "'")

        'If H < 0 Then Print "(Change sign to minus)";     'was HoinMinutes < 0
        SRRightTxtBx.AppendText(vbTab & vbTab & vbTab & "Z   " & cboL.Text & Space(6 - LengthZtotDisplay) & Strings.Format(System.Math.Abs(ZtotDisplay), "0.0") & Chr(176))

        If LHA <= 180 Then SRRightTxtBx.AppendText(" W")

        If LHA > 180 Then SRRightTxtBx.AppendText(" E")
        SRRightTxtBx.AppendText(vbNewLine)

        SRRightTxtBx.AppendText(Space(6) & "Ho ")

        If HoinMinutes < 0 Then
            SRRightTxtBx.AppendText("    -")
        Else
            SRRightTxtBx.AppendText("     ")
        End If

        SRRightTxtBx.AppendText(Space(4 - HoDeg.ToString.Length) & Strings.Format(HoDeg, "0") & Chr(176) & Strings.Format(System.Math.Abs(HoMin), "00") & "'")
        SRRightTxtBx.AppendText(vbNewLine)

        SRRightTxtBx.AppendText(Space(6) & "a" & Space(12 - Int(System.Math.Abs(A)).ToString.Length) & (Int(System.Math.Abs(A) + 0.5)).ToString & "nm ")
        PlotOut.PlotIntercept = (Int(System.Math.Abs(A) + 0.5)).ToString & "nm "
        If A < 0 Then
            SRRightTxtBx.AppendText("T  Ho > Hc....Toward")
            PlotOut.PlotIntercept &= " Toward"
        End If

        If A > 0 Then
            SRRightTxtBx.AppendText("A  Hc > Ho....Away  ")
            PlotOut.PlotIntercept &= " Away"
        End If

        SRRightTxtBx.AppendText(Space(8) & "Zn " & Strings.Format(ZN, "000") & Chr(176))
        SRRightTxtBx.AppendText(vbNewLine)
        PlotOut.PlotAz = Strings.Format(ZN, "000") & Chr(176)
        SRRightTxtBx.AppendText(Space(6) & "AP/EP L " & Strings.Format(APEstLDeg, "0") & Chr(176) & Strings.Format(APEstLMin, "00.0") & "'")

        If APEstL > 0 Then SRRightTxtBx.AppendText(g_LatN)

        If APEstL = 0 Then SRRightTxtBx.AppendText(g_StrSpace)

        If APEstL < 0 Then SRRightTxtBx.AppendText(g_LatS)

        SRRightTxtBx.AppendText("   AP/EP Lo " & Strings.Format(APEstLoDeg, "0") & Chr(176) & Strings.Format(APEstLoMin, "00.0") & "'")

        If APEstLo > 0 Then SRRightTxtBx.AppendText(g_LongW)
        If APEstLo = 0 Then SRRightTxtBx.AppendText(g_StrSpace)
        If APEstLo < 0 Then SRRightTxtBx.AppendText(g_LongE)
        SRRightTxtBx.AppendText(vbNewLine)

        SRRightTxtBx.AppendText(Space(6) & "DR-LOP Distance " & Strings.Format(System.Math.Abs(KPLOPDist), "0.0") & " nm ")

        If KPLOPDist < 0 Then SRRightTxtBx.AppendText("T")
        If KPLOPDist > 0 Then SRRightTxtBx.AppendText("A")
        If KPLOPDist = 0 Then SRRightTxtBx.AppendText(g_StrSpace)
        SRRightTxtBx.AppendText(vbNewLine)

        SRRightTxtBx.AppendText(Space(6) & "   EP L " & Strings.Format(EstLDeg, "0") & Chr(176) & Strings.Format(EstLMin, "00.0") & "'")
        If EstL >= 0 Then
            SRRightTxtBx.AppendText(" N ")
        Else
            SRRightTxtBx.AppendText(" S ")
        End If
        SRRightTxtBx.AppendText("      EP Lo " & Strings.Format(EstLoDeg, "0") & Chr(176) & Strings.Format(EstLoMin, "00.0") & "'")
        If EstLo >= 0 Then
            SRRightTxtBx.AppendText(" W ")
        Else
            SRRightTxtBx.AppendText(" E ")
        End If
        SRRightTxtBx.Refresh()
        SRLeftTxtBx.Refresh()
        SRHdrTxtBx.Refresh()
        NASRAsmTxtBx.Refresh()
        NASRAFTxtBx.Refresh()

    End Sub
    Public Sub APEPNASR()
        APEstL = AsmL - (A / 60) * System.Math.Cos(ZN * Pi / 180) 'Changed in V4.0.0
        APEstLo = AsmLo + (A / 60) * System.Math.Sin(ZN * Pi / 180) / System.Math.Cos(AsmL * Pi / 180) 'Changed in V4.0.0
        If System.Math.Abs(APEstLo) > 180 Then
            APEstLo = -System.Math.Sign(APEstLo) * (360 - System.Math.Abs(APEstLo))
        End If
        APEstLDeg = Int(System.Math.Abs(APEstL))
        APEstLMin = (System.Math.Abs(APEstL) - APEstLDeg) * 60
        If Int(APEstLMin) = 60 Then
            APEstLMin = 0
            APEstLDeg = APEstLDeg + 1
        End If
        APEstLoDeg = Int(System.Math.Abs(APEstLo))
        APEstLoMin = (System.Math.Abs(APEstLo) - APEstLoDeg) * 60
        If Int(APEstLoMin) = 60 Then
            APEstLoMin = 0
            APEstLoDeg = APEstLoDeg + 1
        End If
        APEstLoDeg = System.Math.Abs(APEstLoDeg)
        Exit Sub
    End Sub
    Public Sub AssignPlotPosition()
        PlotOut.PlotSLEP = "EP L " & Strings.Format(EstLDeg, "0") & Chr(176) & Strings.Format(EstLMin, "00.0") & "' "
        If APEstL > 0 Then
            SRRightTxtBx.AppendText(g_LatN)
            PlotOut.PlotSLEP &= g_LatN
            PlotOut.PlotLatNS = g_LatN
        End If
        If APEstL = 0 Then
            SRRightTxtBx.AppendText(g_StrSpace)
            PlotOut.PlotSLEP &= g_LatN
            PlotOut.PlotLatNS = g_LatN
        End If
        If APEstL < 0 Then
            SRRightTxtBx.AppendText(g_LatS)
            PlotOut.PlotSLEP &= g_LatS
            PlotOut.PlotLatNS = g_LatS
        End If

        PlotOut.PlotSLEP &= " EP Lo " & Strings.Format(EstLoDeg, "0") & Chr(176) & Strings.Format(EstLoMin, "00.0") & "'"
        If APEstLo > 0 Then
            SRRightTxtBx.AppendText(g_LongW)
            PlotOut.PlotSLEP &= g_LongW
            PlotOut.PlotLongEW = g_LongW
        End If
        If APEstLo = 0 Then
            SRRightTxtBx.AppendText(g_StrSpace)
            PlotOut.PlotSLEP &= g_LongW
            PlotOut.PlotLongEW = g_LongW
        End If
        If APEstLo < 0 Then
            SRRightTxtBx.AppendText(g_LongE)
            PlotOut.PlotSLEP &= g_LongE
            PlotOut.PlotLongEW = g_LongE
        End If
        Exit Sub
    End Sub
    Public Sub KPLOPNASR()
        If cboLo.Text = "E" Then AsmLo = -AsmLo
        DL = System.Math.Abs(L - AsmL) * 60
        DLo = System.Math.Abs(Lo - AsmLo) * System.Math.Cos(L * Pi / 180) * 60
        VL = System.Math.Abs(DL * System.Math.Cos(ZN * Pi / 180))
        VLo = System.Math.Abs(DLo * System.Math.Sin(ZN * Pi / 180))
        If ((ZN > 270 And ZN <= 360) Or (ZN >= 0 And ZN < 90)) And L < AsmL Then VL = -VL 'Zn north and KP south of AP
        If (ZN >= 90 And ZN < 270) And L >= AsmL Then VL = -VL 'Zn south and KP north of AP
        If (ZN >= 0 And ZN < 180) And Lo >= AsmLo Then VLo = -VLo 'Zn east and KP west of AP
        If (ZN >= 180 And ZN < 360) And Lo < AsmLo Then VLo = -VLo 'Zn west and KP east of AP
        Hk = Htot * 60 + VL + VLo
        KPLOPDist = Hk - (HoDeg * 60 + HoMin)
        'KPLOPDist = Int(KPLOPDist * 10 + 0.5) / 10
    End Sub
    Public Sub EPNASR()
        If cboLo.Text = "E" Then AsmLo = -AsmLo
        EstL = L - (KPLOPDist / 60) * System.Math.Cos(ZN * Pi / 180)
        EstLo = Lo + (KPLOPDist / 60) * System.Math.Sin(ZN * Pi / 180) / System.Math.Cos(L * Pi / 180)
        If System.Math.Abs(EstLo) > 180 Then EstLo = -System.Math.Sign(EstLo) * (360 - System.Math.Abs(EstLo))
        EstLDeg = Int(System.Math.Abs(EstL))
        EstLMin = (System.Math.Abs(EstL) - EstLDeg) * 60
        If Int(EstLMin * 10 + 0.5) / 10 = 60 Then
            EstLMin = 0
            EstLDeg = EstLDeg + 1
        End If
        EstLoDeg = Int(System.Math.Abs(EstLo))
        EstLoMin = (System.Math.Abs(EstLo) - EstLoDeg) * 60
        If Int(EstLoMin * 10 + 0.5) / 10 = 60 Then
            EstLoMin = 0
            EstLoDeg = EstLoDeg + 1
        End If
        EstLoDeg = System.Math.Abs(EstLoDeg)
    End Sub

    Public Sub cmdSave_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSave.Click
        II = II + 1
        IU = IU + 1
        If IU > 12 Then
            ErrorMsgBox("Too many sights saved - the limit is 12 saved sights")
            Exit Sub
        End If
        If InvokedbySightLog = True Then
            FBody(II) = cboBody.Text.ToString.Trim
            If cboBody.Text.ToString.Trim = "Sun" Or cboBody.Text.ToString.Trim = "Moon" Then
                FBody(II) &= " " & cbLimb.Text.ToString.Trim
            End If
        Else
            FBody(II) = " AltSRBody" & txtSightNum.ToString("##0")
        End If

        If InvokedbySightLog = True Then
            FBody(II) = cboBody.Text.ToString.Trim
            If cboBody.Text.ToString.Trim = "Sun" Or cboBody.Text.ToString.Trim = "Moon" Then
                FBody(II) &= " " & cbLimb.Text.ToString.Trim
            End If
        Else
            FBody(II) = " AltSRBody" & txtSightNum.ToString("##0")
        End If
        If IU > 1 Then
            cmdFix.Visible = True
            cmdFix.Enabled = True
            cmdFix.Text = "Establish Fix for " & IU.ToString("#0") & " sights"
        End If
        FZH(II) = DTSight.Value.Hour    '  VB.Left(txtTime.Text, 2)
        FZM(II) = DTSight.Value.Minute      'Mid(txtTime.Text, 3, 2) ': FZS(II) = Right(txtTime.Text, 2)
        FZS(II) = DTSight.Value.Second
        FDTSight(II) = DTSight.Value
        'FZU(II) = DTSight.Value.ToUniversalTime.Subtract(New DateTime(1970, 1, 1, 0, 0, 0))
        FMI(II) = System.Math.Sign(A) * Int((System.Math.Abs(A) * 10 + 0.5) / 10) 'changed in V4.0.0
        FD(II) = "T"
        If A > 0 Then FD(II) = "A"
        If A = 0 Then FD(II) = " "
        FZN(II) = Int(ZN + 0.5) 'changed in V4.0.0
        FL(II) = L
        FLD(II) = txtLDeg.Text
        FLM(II) = txtLMin.Text
        FLA(II) = cboL.Items(cboL.SelectedIndex).ToString
        FLo(II) = Lo
        FMD(II) = txtLoDeg.Text
        FMM(II) = txtLoMin.Text
        FM(II) = cboLo.Items(cboLo.SelectedIndex).ToString

        FGHA(II) = GHA      'added in V5.6.1
        FDec(II) = Dec      'added in V5.6.1
        FHo(II) = Ho        'added in V5.6.1
        FEP(II) = PlotOut.PlotSLEP
        SendMsgBx("Sight reduction data saved - Enter new sight data", MessageBoxIcon.Information)
        cmdSave.Visible = False
        Exit Sub
    End Sub
    Public Sub cmdFix_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFix.Click

        'Form4.IUPass = IU
        FixDG.IUPass = IU
        Dim temp As Integer = 0
        For temp = 1 To 12
            'Form4.FixDataArray(temp) = New Form4.SFixData With {.SFZH = FZH(temp), .SFZM = FZM(temp), .SFZS = FZS(temp),
            '        .SFZN = FZN(temp), .SFMI = FMI(temp), .SFL = FL(temp), .SFLo = FLo(temp), .SBF = "AltSR" & temp.ToString, 'FL(temp),
            '       .SFLD = FLD(temp), .SFLM = FLM(temp), .sFD = FD(temp), .SFMD = FMD(temp), .SFMM = FMM(temp),
            '        .sFLA = FLA(temp), .SFM = FM(temp), .SFGHA = FGHA(temp), .SFDec = FDec(temp), .SFHo = FHo(temp)}

            FixDG.FixDataArray(temp) = New FixDG.SFixData With {.SFZH = FZH(temp), .SFZM = FZM(temp), .SFZS = FZS(temp),
                    .SFZN = FZN(temp), .SFMI = FMI(temp), .SFL = FL(temp), .SFLo = FLo(temp), .SBF = FBody(temp),   '"AltSR" & temp.ToString, 'FL(temp),
                   .SFLD = FLD(temp), .SFLM = FLM(temp), .sFD = FD(temp), .SFMD = FMD(temp), .SFMM = FMM(temp),
                    .sFLA = FLA(temp), .SFM = FM(temp), .SFGHA = FGHA(temp), .SFDec = FDec(temp), .SFHo = FHo(temp), .SDTSight = FDTSight(temp), .SEP = FEP(temp)}
        Next
        'Form4.Show()
        FixDG.txtUserInfo.Text = Me.txtUserInfo.Text
        FixDG.Show()
        FixDG.SetDesktopLocation(5,5) '
        Exit Sub
    End Sub

    Public Sub HO249()
        LHA = GHA - Lo
        If LHA >= 360 Then LHA = LHA - 360
        If LHA < 0 Then LHA = LHA + 360
        AsmLHA = Int(LHA + 0.5)
        If AsmLHA = 360 Then AsmLHA = 0
        GHAAsmDeg = Val(txtGHADeg.Text)
        GHAAsmMin = Int(Val(txtGHAMin.Text) + 0.5)
        GHAAsm = GHAAsmDeg + GHAAsmMin / 60 'in degrees
        AsmLo = GHAAsm - AsmLHA
        If System.Math.Abs(AsmLo) < 180 Then AsmLo = 360 - System.Math.Abs(AsmLo)
        If System.Math.Abs(AsmLo) >= 180 And Lo >= 0 Then AsmLo = 360 - System.Math.Abs(AsmLo)
        If System.Math.Abs(AsmLo) >= 180 And Lo < 0 Then AsmLo = -(360 - System.Math.Abs(AsmLo))
        AsmLoDeg = Int(System.Math.Abs(AsmLo))
        If AsmLo > 0 Or txtLoDeg.Text = "180" Then AsmLoMin = Val(txtGHAMin.Text) Else AsmLoMin = 60 - Val(txtGHAMin.Text)
        If AsmLoMin = 60 Then AsmLoMin = 0
        AsmL = Int(L + 0.5)
        AsmDec = Int(System.Math.Abs(Dec))
        DecIncr = Int(Val(txtDecMin.Text) + 0.5)

        If (cboDec.Text = "S" And cboL.Text = "N") Or (cboDec.Text = "N" And cboL.Text = "S") Then AsmDec = -AsmDec ': SignDE$ = "-"

        Hc = System.Math.Cos(AsmLHA * Pi / 180) * System.Math.Cos(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Cos(AsmDec * Pi / 180) + System.Math.Sin(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Sin(AsmDec * Pi / 180)
        If System.Math.Abs(Hc) >= 1 Then Hc = System.Math.Sign(Hc) * Pi / 2 Else Hc = System.Math.Atan(Hc / System.Math.Sqrt(-Hc * Hc + 1)) 'arcsine
        Hc = Hc * 180 / Pi
        sgnHc = System.Math.Sign(Hc)
        TabHcDeg = Fix(Hc)
        TabHcMin = Hc - TabHcDeg
        TabHcMin = Int(60 * TabHcMin + 0.50023) 'WHY IS 0.50023 NEEDED!!!!!!!!!!!!!!! Extra problem 1 does not work without it.

        i = 1
        If AsmDec < 0 Then
            i = -1
        End If
        NextHc = System.Math.Cos(AsmLHA * Pi / 180) * System.Math.Cos(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Cos((AsmDec + i) * Pi / 180) + System.Math.Sin(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Sin((AsmDec + i) * Pi / 180)
        If System.Math.Abs(NextHc) >= 1 Then
            NextHc = System.Math.Sign(NextHc) * Pi / 2
        Else
            NextHc = System.Math.Atan(NextHc / System.Math.Sqrt(-NextHc * NextHc + 1)) 'arcsine
        End If
        NextHc = NextHc * 180 / Pi
        NextHcDeg = Int(NextHc)
        NextHcMin = NextHc - NextHcDeg
        NextHcMin = Int(60 * NextHcMin + 0.5)
        D = (60 * NextHcDeg + NextHcMin) - (60 * TabHcDeg + TabHcMin)

        D = System.Math.Sign(D) * Int(System.Math.Abs(D) + 0.5)
        SignD = "+"
        If System.Math.Sign(D) = -1 Then
            SignD = "-"
        End If

        dcorr = D * DecIncr / 60
        dcorr = System.Math.Sign(D) * Int(System.Math.Abs(dcorr) + 0.5)
        TotHc = (TabHcDeg * 60 + TabHcMin + dcorr) / 60
        sgnTotHc = System.Math.Sign(TotHc)

        Signdcorr = "+"
        If System.Math.Sign(dcorr) = -1 Then Signdcorr = "-"

        TotHcDeg = Fix(TotHc)
        Htot = TotHc
        TotHcMin = TotHc - TotHcDeg
        TotHcMin = Int(60 * TotHcMin + 0.5)
        If TotHcMin = 60 Then
            TotHcMin = 0
            TotHcDeg = TotHcDeg + 1
        End If

        A = (60 * TotHcDeg + TotHcMin) - (60 * HoDeg + HoMin)

        L4 = System.Math.Sin(AsmDec * Pi / 180)
        L5 = System.Math.Sin(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Sin(Hc * Pi / 180)
        L6 = L4 - L5
        L7 = System.Math.Cos(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Cos(Hc * Pi / 180)
        L8 = L6 / L7
        If System.Math.Abs(L8) >= 1 Then Z = Pi Else Z = System.Math.Atan(-L8 / System.Math.Sqrt(-L8 * L8 + 1)) + Pi / 2 'arccosine
        Z = Z * 180 / Pi
        Z = Int(Z + 0.5)
        If cboL.Text = "N" And LHA > 180 Then ZN = Z
        If cboL.Text = "N" And LHA <= 180 Then ZN = 360 - Z
        If cboL.Text = "S" And LHA > 180 Then ZN = 180 - Z
        If cboL.Text = "S" And LHA <= 180 Then ZN = 180 + Z

        ZN = Int(ZN + 0.5) 'added in V4.0.0
    End Sub
    Public Sub Display249()
        cmdSave.Visible = False
        cmdFix.Visible = False ': 
        cmdFix.Enabled = False
        cmdFix.Text = "Establish Fix"
        'Me.Font = New Font(Me.Font, "Courier New")
        SRHdrTxtBx.Visible = True
        SRHdrTxtBx.Clear()
        SRHdrTxtBx.BringToFront()

        SRLgTxtBx.Clear()
        SRLgTxtBx.Visible = False
        SRLgTxtBx.SendToBack()

        SRLeftTxtBx.Clear()
        SRLeftTxtBx.Visible = True
        SRLeftTxtBx.BringToFront()

        SRRightTxtBx.Clear()
        SRRightTxtBx.Visible = True
        SRRightTxtBx.BringToFront()

        NASRAsmTxtBx.Clear()
        NASRAsmTxtBx.Visible = False
        NASRAsmTxtBx.SendToBack()

        NASRAFTxtBx.Clear()
        NASRAFTxtBx.Visible = False
        NASRAFTxtBx.SendToBack()

        DCorrTxtBx.Clear()
        DCorrTxtBx.Visible = True
        DCorrTxtBx.BringToFront()

        WeemsPVTxtBx.Clear()            'V5.6.1
        WeemsPVTxtBx.Visible = False    'V5.6.1
        WeemsPVTxtBx.SendToBack()   'V5.6.1

        frameNASRUsing.Visible = False
        frame211.Visible = False
        frame214.Visible = False
        Label9.Visible = False
        frameS.Visible = False
        GroupBoxPrecision.Visible = False      'V5.6.1
        'CurrentY = 2260

        AlignCenterRTB(SRHdrTxtBx)
        SRHdrTxtBx.AppendText("INTERCEPT and AZIMUTH by Pub. 249 SIGHT REDUCTION TABLES")

        ' format left side text box 
        SRLeftTxtBx.AppendText("Calc of Asm Lo & Asm LHA")
        SRLeftTxtBx.AppendText(vbNewLine)

        SRLeftTxtBx.AppendText("GHA" & Space(15 - txtGHADeg.Text.ToString.Length) & Strings.Format(Val(txtGHADeg.Text), "##0") & Chr(176) & Strings.Format(Val(txtGHAMin.Text), "00.0") & "'")
        SRLeftTxtBx.AppendText(vbNewLine)

        SRLeftTxtBx.AppendText("Asm Lo (")

        If AsmLo = 0 Then
            SignA3 = " "
            SRLeftTxtBx.AppendText("")
        End If
        If System.Math.Sign(AsmLo) = 1 Then
            SRLeftTxtBx.AppendText("-")
            SignA3 = g_LongW
        End If
        If System.Math.Sign(AsmLo) = -1 Then
            SRLeftTxtBx.AppendText("+")
            SignA3 = g_LongE
        End If
        If System.Math.Sign(AsmLo) = 0 Then
            SRLeftTxtBx.AppendText(g_StrSpace)
            SignA3 = " "
        End If

        SRLeftTxtBx.AppendText(")" & Space(8 - AsmLoDeg.ToString.Length) & Strings.Format(AsmLoDeg, "0") & Chr(176) & Strings.Format(AsmLoMin, "00.0") & "'" & SignA3 & vbNewLine)
        SRLeftTxtBx.AppendText("LHA" & Space(15 - AsmLHA.ToString.Length) & Strings.Format(AsmLHA, "0") & Chr(176) & vbNewLine)

        SRLeftTxtBx.AppendText("Asm L " & Space(12 - AsmL.ToString.Length) & Strings.Format(System.Math.Abs(AsmL), "#0") & Chr(176))
        If AsmL = 0 Then
            SRLeftTxtBx.AppendText(g_StrSpace)
        Else
            SRLeftTxtBx.AppendText(cboL.Text)
        End If
        SRLeftTxtBx.AppendText(vbNewLine)

        SRLeftTxtBx.AppendText("Asm Dec" & Space(11 - DecDegrees.ToString.Length) & Strings.Format(DecDegrees, "#0") & Chr(176) & cboDec.Text & vbNewLine)

        SRLeftTxtBx.AppendText("Dec Incr" & Space(10 - DecIncr.ToString.Length) & Strings.Format(DecIncr, "00") & "'" & vbNewLine)

        ' format right side text box
        SRRightTxtBx.AppendText(Space(3) & "Tab Hc  ")

        If sgnHc = -1 Then
            SRRightTxtBx.AppendText("-")
        Else
            SRRightTxtBx.AppendText(g_StrSpace)
        End If

        SRRightTxtBx.AppendText(Space(4 - System.Math.Abs(TabHcDeg).ToString.Length) & Strings.Format(System.Math.Abs(TabHcDeg), "0") & Chr(176) _
              & Strings.Format(System.Math.Abs(TabHcMin), "00") & "'" & Space(10) & "d (" & SignD & ") " & Strings.Format(System.Math.Abs(D), "00") _
              & "'" & Space(10) & "Tab Z " & cboL.Text & Space(4 - Z.ToString.Length) & Strings.Format(System.Math.Abs(Z), "0") & Chr(176))

        If LHA <= 180 Then SRRightTxtBx.AppendText(" W")

        If LHA > 180 Then SRRightTxtBx.AppendText(" E")
        SRRightTxtBx.AppendText(vbNewLine)
        SRRightTxtBx.AppendText(Space(3) & "d corr. (" & Signdcorr & ") " & Strings.Format(System.Math.Abs(dcorr), "00") & "'")
        SRRightTxtBx.AppendText(vbNewLine)

        SRRightTxtBx.AppendText(Space(3) & "Hc " & Space(5))

        If sgnTotHc = -1 Then
            SRRightTxtBx.AppendText("-")
        Else
            SRRightTxtBx.AppendText(g_StrSpace)
        End If
        SRRightTxtBx.AppendText(Space(4 - System.Math.Abs(TotHcDeg).ToString.Length) & Strings.Format(System.Math.Abs(TotHcDeg), "0") & Chr(176) & Strings.Format(System.Math.Abs(TotHcMin), "00") & "'")
        SRRightTxtBx.AppendText(vbNewLine)

        HoMin = Int(HoMin + 0.5)

        SRRightTxtBx.AppendText(Space(3) & "Ho " & Space(5))

        If HoinMinutes < 0 Then
            SRRightTxtBx.AppendText("-")
        Else
            SRRightTxtBx.AppendText(g_StrSpace)
        End If

        SRRightTxtBx.AppendText(Space(4 - HoDeg.ToString.Length) & Strings.Format(System.Math.Abs(HoDeg), "0") & Chr(176) & Strings.Format(System.Math.Abs(HoMin), "00") & "'")
        SRRightTxtBx.AppendText(vbNewLine)

        SRRightTxtBx.AppendText(Space(4) & "a " & Space(12 - Int(System.Math.Abs(A)).ToString.Length) & (Int(System.Math.Abs(A) + 0.5)).ToString & "nm ")
        PlotOut.PlotIntercept = (Int(System.Math.Abs(A) + 0.5)).ToString & "nm "
        If TotHc < Ho Then
            SRRightTxtBx.AppendText("T  Ho > Hc....Toward")
            PlotOut.PlotIntercept &= " Toward"
        End If

        If TotHc > Ho Then
            SRRightTxtBx.AppendText("A  Hc > Ho....Away")
            PlotOut.PlotIntercept &= " Away"
        End If
        SRRightTxtBx.AppendText(vbNewLine)

        SRRightTxtBx.AppendText(Space(45) & "Zn  " & Strings.Format(ZN, "000") & Chr(176))
        PlotOut.PlotAz = Strings.Format(ZN, "000") & Chr(176)

        SRRightTxtBx.AppendText(vbNewLine)

        SRRightTxtBx.AppendText(vbNewLine)

        DCorrTxtBx.AppendText(Space(6) & "d corr. Interpolation" & vbNewLine)
        DCorrTxtBx.AppendText(Space(3) & "d corr. = " & DecIncr & "x " & CStr(D) & "/ 60 => " & Signdcorr & Strings.Format(System.Math.Abs(dcorr), "00"))
        SRRightTxtBx.AppendText(vbNewLine)
        SRRightTxtBx.AppendText(vbNewLine)
        SRRightTxtBx.AppendText(vbNewLine)

        SRRightTxtBx.AppendText(Space(8) & "AP/EP L " & Strings.Format(APEstLDeg, "0") & Chr(176) & Strings.Format(APEstLMin, "00.0") & "'")

        If APEstL > 0 Then SRRightTxtBx.AppendText(g_LatN)
        If APEstL = 0 Then SRRightTxtBx.AppendText(g_StrSpace)
        If APEstL < 0 Then SRRightTxtBx.AppendText(g_LatS)

        SRRightTxtBx.AppendText("   AP/EP Lo " & Strings.Format(APEstLoDeg, "0") & Chr(176) & Strings.Format(APEstLoMin, "00.0") & "'")

        If APEstLo > 0 Then SRRightTxtBx.AppendText(g_LongW)
        If APEstLo = 0 Then SRRightTxtBx.AppendText(g_StrSpace)
        If APEstLo < 0 Then SRRightTxtBx.AppendText(g_LongE)
        SRRightTxtBx.AppendText(vbNewLine)

        SRRightTxtBx.AppendText(Space(8) & "DR-LOP Distance " & Strings.Format(System.Math.Abs(KPLOPDist), "0.0") & " nm ")

        If KPLOPDist < 0 Then SRRightTxtBx.AppendText("T")
        If KPLOPDist > 0 Then SRRightTxtBx.AppendText("A")
        If KPLOPDist = 0 Then SRRightTxtBx.AppendText(g_StrSpace)
        SRRightTxtBx.AppendText(vbNewLine)

        SRRightTxtBx.AppendText(Space(8) & "   EP L " & Strings.Format(EstLDeg, "0") & Chr(176) & Strings.Format(EstLMin, "00.0") & "'")

        SRRightTxtBx.AppendText("      EP Lo " & Strings.Format(EstLoDeg, "0") & Chr(176) & Strings.Format(EstLoMin, "00.0") & "'")

        SRHdrTxtBx.Refresh()
        SRLeftTxtBx.Refresh()
        SRRightTxtBx.Refresh()


    End Sub

    Public Sub Weems()          'Several changes V5.6.1 and as early as V5.4.1
        B3 = 0
        B4 = 0
        B5 = 0
        Btot = 0
        LHA = GHA - Lo
        LHA = Int(LHA + 0.5)
        If LHA >= 360 Then LHA = LHA - 360
        If LHA < 0 Then LHA = LHA + 360
        If LHA <= 180 Then T = LHA 'W
        If LHA > 180 Then T = 360 - LHA 'E
        tDeg = Int(T + 0.5)
        AsmLHA = Int(LHA + 0.5)
        If AsmLHA = 360 Then AsmLHA = 0
        GHAAsmDeg = Val(txtGHADeg.Text)
        GHAAsmMin = Int(Val(txtGHAMin.Text) + 0.5)
        GHAAsm = GHAAsmDeg + GHAAsmMin / 60 'in degrees
        AsmLo = GHAAsm - AsmLHA
        If System.Math.Abs(AsmLo) < 180 Then AsmLo = 360 - System.Math.Abs(AsmLo)
        If System.Math.Abs(AsmLo) >= 180 And Lo >= 0 Then AsmLo = 360 - System.Math.Abs(AsmLo)
        If System.Math.Abs(AsmLo) >= 180 And Lo < 0 Then AsmLo = -(360 - System.Math.Abs(AsmLo))
        AsmLoDeg = Int(System.Math.Abs(AsmLo))
        If AsmLo > 0 Or txtLoDeg.Text = "180" Then AsmLoMin = Val(txtGHAMin.Text) Else AsmLoMin = 60 - Val(txtGHAMin.Text)
        If AsmLoMin = 60 Then AsmLoMin = 0
        AsmL = Int(L + 0.5)
        N = System.Math.Cos(AsmL * Pi / 180) * System.Math.Sin(LHA * Pi / 180)
        If System.Math.Abs(N) >= 1 Then N = System.Math.Sign(N) * Pi / 2 Else N = System.Math.Atan(N / System.Math.Sqrt(-N * N + 1)) 'arcsin
        If N = 0 Then N = 0.0000000001 * Pi / 180
        A1 = 100000 * (System.Math.Log(1 / System.Math.Cos(N)) / System.Math.Log(10))
        If T >= 21 Then A1 = Int(A1 + 0.65) 'UNCERTAIN ROUNDING SCHEME, SEEMS TO WORK WITH 0.65
        If T <= 20 Then A1 = Int(A1 * 10 + 0.65) / 10
        If T = 0 Then A1 = 0 'do not want to round for 0 latitude
        Z3 = System.Math.Cos(AsmLHA * Pi / 180) / System.Math.Cos(N) 'Example b p 2-24 bottom of first column makes Z3=1 NG
        If System.Math.Abs(Z3) >= 1 Then Z1 = System.Math.Sign(Z3) * Pi / 2 Else Z1 = System.Math.Atan(Z3 / System.Math.Sqrt(-Z3 * Z3 + 1)) 'in radians
        B1 = System.Math.Cos(AsmL * Pi / 180) * System.Math.Sin(Z1)
        If System.Math.Abs(B1) >= 1 Then B = System.Math.Sign(B1) * Pi / 2 Else B = System.Math.Atan(B1 / System.Math.Sqrt(-B1 * B1 + 1)) 'in radians
        B = B * 180 / Pi
        BDeg = Int(System.Math.Abs(B))
        BMin = Int(((System.Math.Abs(B) - BDeg) * 60) * 10 + 0.5) / 10
        If BMin = 60 Then BMin = 0 : BDeg = BDeg + 1
        B = BDeg + BMin / 60
        If (cboDec.Text = "N" And cboL.Text = "S") Or (cboDec.Text = "S" And cboL.Text = "N") Then DE = -DE ': SignDE$ = "-"
        F = B + DE 'in degrees

        Kd = 90 - F ': KdOrig = Kd
        If AsmL = 0 Then k = 0
        KdDeg = Int(System.Math.Abs(Kd))
        KdMin = Int(((System.Math.Abs(Kd) - KdDeg) * 60) * 10 + 0.5) / 10 'UNCERTAIN ROUNDING SCHEME, SEEMS TO WORK WITH 0.65
        If AsmL = 0 Then KdMin = 0
        k = KdDeg + KdMin / 60 + DE
        If T > 90 Then
            k = 180 - k
            Kd = k - DE 'Kd must be 0-90 for a legitimate sight
            If Kd > 90 Then Exit Sub
            KdDeg = Int(System.Math.Abs(Kd))
            KdMin = Int(((System.Math.Abs(Kd) - KdDeg) * 60) * 10 + 0.5) / 10 'UNCERTAIN ROUNDING SCHEME, SEEMS TO WORK WITH 0.65
        End If
        'k = Kd + DE
        KDeg = Int(System.Math.Abs(k))
        KMin = Int(((System.Math.Abs(k) - KDeg) * 60) * 10 + 0.5) / 10
        If AsmL = 0 Then KMin = 0
        B = 100000 * (System.Math.Log(1 / System.Math.Cos((KdDeg + Int(KdMin + 0.5) / 60) * Pi / 180)) / System.Math.Log(10)) 'round to nearest minute
        If Kd >= 10 Then B = Int(B + 0.5) 'SHOULD THIS BE 0.65???????????????????????????
        If Kd < 10 Then B = Int(B * 10 + 0.5) / 10 'SHOULD THIS BE 0.65???????????????????????????
        If chkInterpolateB.CheckState = 1 Then 'this does linear interpolation
            If Int(KdMin + 0.5) > KdMin Then B22 = 100000 * (System.Math.Log(1 / System.Math.Cos((KdDeg + Int(KdMin - 0.5) / 60) * Pi / 180)) / System.Math.Log(10))
            If Int(KdMin + 0.5) < KdMin Then B22 = 100000 * (System.Math.Log(1 / System.Math.Cos((KdDeg + Int(KdMin + 1.5) / 60) * Pi / 180)) / System.Math.Log(10))
            If (Kd + 1 / 60) >= 10 Then B22 = Int(B22 + 0.5) 'SHOULD THIS BE 0.65???????????????????????????
            If (Kd + 1 / 60) < 10 Then B22 = Int(B22 * 10 + 0.5) / 10 'SHOULD THIS BE 0.65???????????????????????????
            If B >= B22 Then B = B22 + (KdMin - Int(KdMin)) * System.Math.Abs(B - B22)
            If B < B22 Then B = B + (KdMin - Int(KdMin)) * System.Math.Abs(B - B22)
            'B = Int(B * 10 + 0.5) / 10
        End If
        If Kd >= 10 Then B = Int(B + 0.5) 'SHOULD THIS BE 0.65???????????????????????????
        If Kd < 10 Then B = Int(B * 10 + 0.5) / 10 'SHOULD THIS BE 0.65???????????????????????????
        AB = A1 + B
        If T <= 20 Or Kd < 10 Or chkInterpolateB.CheckState = 1 Then AB = Int(AB * 10 + 0.5) / 10 Else AB = Int(AB + 0.5) 'SHOULD THIS BE 0.65???????????????????????????
        Hc = 1 / (10 ^ (AB / 100000))
        If System.Math.Abs(Hc) >= 1 Then Hc = System.Math.Sign(Hc) * Pi / 2 Else Hc = System.Math.Atan(Hc / System.Math.Sqrt(-Hc * Hc + 1)) 'arcsine
        Hc = Hc * 180 / Pi
        HcDeg = Int(System.Math.Abs(Hc))
        If chkInterpolateB.CheckState = 0 Then HcMin = Int(((System.Math.Abs(Hc) - HcDeg) * 60) + 0.5)
        If chkInterpolateB.CheckState = 1 Then HcMin = Int(((System.Math.Abs(Hc) - HcDeg) * 60) * 10 + 0.5) / 10
        HcDecimal = HcDeg + HcMin / 60
        Htot = Hc
        A = (60 * HcDeg + HcMin) - (60 * HoDeg + HoMin)

        'For Lat and Dec same name and Dec<Lat, calculate the altitude of the body when on prime vertical
        '(Done for all, but only needed for Lat and Dec same name and Dec<Lat)
        'NO!  Only do if Lat and Dec same name and Dec<Lat or get sqrt of negative number error      
        'V5.6.2
        If cboL.Text = cboDec.Text And DE < L Then      'V5.6.2
            If L = 0 Then L = 0.000000000000001     'Added in V5.6.1 to prevent divide-by-zero error if L = 0
            Hpv = System.Math.Sin(DE * Pi / 180) / System.Math.Sin(L * Pi / 180)
            Hpv = System.Math.Atan(Hpv / System.Math.Sqrt(-Hpv * Hpv + 1)) 'arcsine
            Hpv = Hpv * 180 / Pi
            HpvDeg = Int(Hpv)
            HpvMin = (Hpv - HpvDeg) * 60
            HpvMin = Int(HpvMin * 10 + 0.5) / 10
        End If

        If cboL.Text <> cboDec.Text Then DE = -DE
        L4 = System.Math.Sin(DE * Pi / 180)
        L5 = System.Math.Sin(System.Math.Abs(L) * Pi / 180) * System.Math.Sin(Htot * Pi / 180)
        L6 = L4 - L5
        L7 = System.Math.Cos(System.Math.Abs(L) * Pi / 180) * System.Math.Cos(Htot * Pi / 180)
        L8 = L6 / L7
        If System.Math.Abs(L8) >= 1 Then ZLoc = Pi Else ZLoc = System.Math.Atan(-L8 / System.Math.Sqrt(-L8 * L8 + 1)) + Pi / 2
        ZLoc = ZLoc * 180 / Pi
        If cboL.Text = "N" And LHA > 180 Then ZnLoC = ZLoc
        If cboL.Text = "N" And LHA <= 180 Then ZnLoC = 360 - ZLoc
        If cboL.Text = "S" And LHA > 180 Then ZnLoC = 180 - ZLoc
        If cboL.Text = "S" And LHA <= 180 Then ZnLoC = 180 + ZLoc
        ZnLoC = Int(ZnLoC * 10 + 0.5) / 10
        ZnLoCDeg = Int(ZnLoC)
        ZnLoCMin = (ZnLoC - ZnLoCDeg) * 60
        ZnLoCMin = Int(ZnLoCMin + 0.5)
        If ZnLoCMin = 60 Then ZnLoCMin = 0 : ZnLoCDeg = ZnLoCDeg + 1

        'Z by table
        If T = 0 Then Exit Sub

        B2 = 100000 * (System.Math.Log(1 / System.Math.Sin(T * Pi / 180)) / System.Math.Log(10))
        B3 = Int(B2 + 0.5)
        B2 = 100000 * (System.Math.Log(1 / System.Math.Cos((DecDegrees + Int(DecMinutes + 0.5) / 60) * Pi / 180)) / System.Math.Log(10))
        B4 = Int(B2 + 0.5)
        B2 = 100000 * (System.Math.Log(1 / System.Math.Cos((HcDeg + Int(HcMin + 0.5) / 60) * Pi / 180)) / System.Math.Log(10))
        B5 = Int(B2 + 0.5)
        Btot = B3 + B4 - B5
        Btot = Int(Btot + 0.5)
        Z4 = 1 / (10 ^ (Btot / 100000)) 'Z4 is Z using tables
        If System.Math.Abs(Z4) >= 1 Then Z4 = System.Math.Sign(Z4) * Pi / 2 Else Z4 = System.Math.Atan(Z4 / System.Math.Sqrt(-Z4 * Z4 + 1)) 'arcsine
        Z4 = Z4 * 180 / Pi
        Z4Deg = Int(System.Math.Abs(Z4))
        Z4Min = Int((System.Math.Abs(Z4) - Z4Deg) * 60 + 0.5)
        Z4 = Int(Z4 * 10 + 0.5) / 10

        '       If DE >= L And LHA > 180 Then ZnT = Z4
        '       If DE >= L And LHA <= 180 Then ZnT = 360 - Z4
        '       If DE < L And LHA > 180 Then ZnT = 180 - Z4
        '       If DE < L And LHA <= 180 Then ZnT = 180 + Z4
        '       ZnTDeg = Int(System.Math.Abs(ZnT))
        '       ZnTMin = Int((System.Math.Abs(ZnT) - ZnTDeg) * 60 + 0.5)

    End Sub

    Public Sub DisplayWeems()
        cmdSave.Visible = False
        cmdFix.Visible = False ': 
        cmdFix.Enabled = False
        cmdFix.Text = "Establish Fix"

        frameNASRUsing.Visible = False
        frame214.Visible = False
        Label9.Visible = False
        frameS.Visible = False
        GroupBoxPrecision.Visible = False      'V5.6.1
        chkInterpolateB.Visible = True
        If Kd > 90 Then
            chkInterpolateB.Visible = False
            ErrorMsgBox("Check input data")
            Exit Sub
        End If
        SRHdrTxtBx.Clear()
        SRHdrTxtBx.Visible = True
        SRHdrTxtBx.BringToFront()

        SRLgTxtBx.Clear()
        SRLgTxtBx.Visible = True
        SRLgTxtBx.BringToFront()

        SRLeftTxtBx.Clear()
        SRLeftTxtBx.Visible = False
        SRLeftTxtBx.SendToBack()

        SRRightTxtBx.Clear()
        SRRightTxtBx.Visible = False
        SRRightTxtBx.SendToBack()

        NASRAsmTxtBx.Clear()
        NASRAsmTxtBx.Visible = False
        NASRAsmTxtBx.SendToBack()

        NASRAFTxtBx.Clear()
        NASRAFTxtBx.Visible = False
        NASRAFTxtBx.SendToBack()

        DCorrTxtBx.Clear()
        DCorrTxtBx.Visible = False
        DCorrTxtBx.SendToBack()

        WeemsPVTxtBx.Clear()        'V5.6.1
        WeemsPVTxtBx.Visible = True 'V5.6.1
        WeemsPVTxtBx.BringToFront() 'V5.6.1

        AlignCenterRTB(SRHdrTxtBx)
        SRHdrTxtBx.AppendText("INTERCEPT and AZIMUTH by WEEMS LINE OF POSITION BOOK")


        SRLgTxtBx.AppendText("GHA" & Space(16 - txtGHADeg.Text.ToString.Length) & Strings.Format(Val(txtGHADeg.Text), "##0") & Chr(176) & Strings.Format(Val(txtGHAMin.Text), "00.0") & "'") '; Tab(83); "DEC and LAT "
        SRLgTxtBx.AppendText(vbNewLine)

        SRLgTxtBx.AppendText("Asm Lo (")
        If AsmLo = 0 Then
            SignA3 = " "
            SRLgTxtBx.AppendText("")
        End If
        If System.Math.Sign(AsmLo) = 1 Then
            SRLgTxtBx.AppendText("-")
            SignA3 = g_LongW
        End If
        If System.Math.Sign(AsmLo) = -1 Then
            SRLgTxtBx.AppendText("+")
            SignA3 = g_LongE
        End If
        If System.Math.Sign(AsmLo) = 0 Then
            SRLgTxtBx.AppendText(g_StrSpace)
            SignA3 = " "
        End If

        SRLgTxtBx.AppendText(")" & Space(7 - AsmLoDeg.ToString.Length) & Strings.Format(AsmLoDeg, "0") & Chr(176) & Strings.Format(AsmLoMin, "00.0") & "'" & SignA3)
        SRLgTxtBx.AppendText(Space(23) & "d" & Space(5 - txtDecDeg.Text.ToString.Length) & Strings.Format(Val(txtDecDeg.Text), "0") & Chr(176) & Strings.Format(DecMinutes, "00.0") & "'" & cboDec.Text)
        SRLgTxtBx.AppendText("-->  B")
        i = B4.ToString.Length
        If (B4 - Int(B4)) = 0 Then
            i = i + 2
        End If
        If B4 < 1 And B4 > 0 Then
            i = i + 1
        End If

        SRLgTxtBx.AppendText(Space(8 - i) & Strings.Format(B4, "#0") & "   (top, from d)")
        SRLgTxtBx.AppendText(vbNewLine)

        SRLgTxtBx.AppendText("t*(LHA)" & Space(11 - tDeg.ToString.Length) & Strings.Format(tDeg, "0") & Chr(176))

        If LHA <= 180 Then SRLgTxtBx.AppendText(g_LongW)
        If LHA > 180 Then SRLgTxtBx.AppendText(g_LongE)
        SRLgTxtBx.AppendText(" -----> A")
        i = A1.ToString.Length
        If (A1 - Int(A1)) = 0 Then
            i = i + 2
        End If
        If A1 < 1 And A1 > 0 Then
            i = i + 1
        End If

        If T >= 21 Or A1 = 0 Then
            SRLgTxtBx.AppendText(Space(9 - i) & Strings.Format(A1, "#0"))
        End If
        If T <= 20 And A1 <> 0 Then
            SRLgTxtBx.AppendText(Space(9 - i) & Strings.Format(A1, "#0.0")) '39 was 41
        End If
        i = KDeg.ToString.Length
        If (KDeg - Int(KDeg)) = 0 Then
            i = i + 2
        End If
        If KDeg < 1 And KDeg > 0 Then
            i = i + 1 'is this line necessary?
        End If

        SRLgTxtBx.AppendText(Space(8) & "K" & Space(6 - i) & Strings.Format(KDeg, "0") & Chr(176) & Strings.Format(KMin, "00.0") & "'" & cboL.Text)

        SRLgTxtBx.AppendText("--> +B")
        i = B3.ToString.Length
        If (B3 - Int(B3)) = 0 Then
            i = i + 2
        End If
        If B3 < 1 And B3 > 0 Then
            i = i + 1
        End If

        If T <> 0 Then SRLgTxtBx.AppendText(Space(9 - i) & Strings.Format(B3, "#0") & "   (bottom, from t)")

        If T = 0 Then SRLgTxtBx.AppendText(Space(3) & "infinite (bottom, from t)")
        SRLgTxtBx.AppendText(vbNewLine)


        SRLgTxtBx.AppendText("Asm L* " & Space(12 - Strings.Format(AsmL.ToString, "#0").Length) & Strings.Format(AsmL.ToString, "#0") & Chr(176))

        If AsmL = 0 Then SRLgTxtBx.AppendText(g_StrSpace)

        If AsmL <> 0 Then SRLgTxtBx.AppendText(cboL.Text)

        SRLgTxtBx.AppendText(Space(7) & "B")
        i = B.ToString.Length
        If (B - Int(B)) = 0 Then
            i = i + 2
        End If
        If B < 1 And B > 0 Then
            i = i + 1
        End If
        If Kd < 10 And (KdMin - Int(KdMin)) <> 0 Then
            SRLgTxtBx.AppendText(Space(9 - i) & Strings.Format(B, "#0.0"))
        Else
            SRLgTxtBx.AppendText(Space(9 - i) & Strings.Format(B, "#0"))
        End If

        i = KdDeg.ToString.Length
        If (KdDeg - Int(KdDeg)) = 0 Then
            i = i + 2
        End If
        If KdDeg < 1 And KdDeg > 0 Then
            i = i + 1
        End If

        SRLgTxtBx.AppendText(Space(3) & "<--" & Space(2) & "K~d*" & Space(5 - i) & Strings.Format(KdDeg, "0") & Chr(176) & Strings.Format(KdMin, "00.0") & "'")
        SRLgTxtBx.AppendText(vbNewLine)


        SRLgTxtBx.AppendText(Space(26) & "A+B") 'THIS IS JUST AN ADDITION - DOES NOT NEED CHKINTERPOLATEB?  BUT IT CHANGES WITH CHKINTERPOLATEB
        i = AB.ToString.Length
        If (AB - Int(AB)) = 0 Then
            i = i + 2
        End If
        If AB < 1 And AB > 0 Then
            i = i + 1
        End If

        If (T <= 20 Or Kd < 10 Or chkInterpolateB.CheckState = 1) And ((AB - Int(AB)) <> 0) Then
            SRLgTxtBx.AppendText(Space(7 - i) & Strings.Format(AB, "#0.0") & Space(3) & " -B->" & Space(1) & "Hc" _
                               & Space(5 - HcDeg.ToString.Length) & Strings.Format(HcDeg, "0") & Chr(176) & Strings.Format(HcMin, "00.0") & "'")
        Else
            SRLgTxtBx.AppendText(Space(7 - i) & Strings.Format(AB, "#0") & Space(3) & " -B->" & Space(1) & "Hc" _
                               & Space(5 - HcDeg.ToString.Length) & Strings.Format(HcDeg, "0") & Chr(176) & Strings.Format(HcMin, "00.0") & "'")
        End If

        SRLgTxtBx.AppendText(" ----> -B")
        i = B5.ToString.Length
        If (B5 - Int(B5)) = 0 Then
            i = i + 2
        End If
        If B5 < 1 And B5 > 0 Then
            i = i + 1
        End If

        SRLgTxtBx.AppendText(Space(9 - i) & Strings.Format(B5, "#0") & "   (top, from Hc)")
        SRLgTxtBx.AppendText(vbNewLine)

        SRLgTxtBx.AppendText(Space(44) & "Ho" & Space(5 - HoDeg.ToString.Length) & Strings.Format(HoDeg, "0") & Chr(176) & Strings.Format(HoMin, "00.0") & "'")
        SRLgTxtBx.AppendText(vbNewLine)

        SRLgTxtBx.AppendText("Z ")

        If DE >= L Then SRLgTxtBx.AppendText("N")

        If DE < L Then SRLgTxtBx.AppendText("S")

        SRLgTxtBx.AppendText(Strings.Format(Z, "#00.0") & Chr(176))

        If LHA <= 180 Then SRLgTxtBx.AppendText(" W" & "; ")

        If LHA > 180 Then SRLgTxtBx.AppendText(" E" & "; ")

        SRLgTxtBx.AppendText("Zn " & Strings.Format(ZN, "000.0") & Chr(176))

        SRLgTxtBx.AppendText(Space(22) & "a" & Space(11 - Int(System.Math.Abs(A)).ToString.Length))

        SRLgTxtBx.AppendText(Strings.Format(Int(System.Math.Abs(A) * 10 + 0.5) / 10, "0.0") & " nm")
        PlotOut.PlotIntercept = Strings.Format(Int(System.Math.Abs(A) * 10 + 0.5) / 10, "0.0") & " nm "
        If HcDecimal < Ho Then
            SRLgTxtBx.AppendText(" Towards")
            PlotOut.PlotIntercept &= " Toward"
        End If

        If HcDecimal > Ho Then
            SRLgTxtBx.AppendText(" Away   ")
            PlotOut.PlotIntercept &= " Away"
        End If

        If HcDecimal = Ho Then
            SRLgTxtBx.AppendText("        ")
            PlotOut.PlotIntercept &= " Toward"
        End If
        i = Btot.ToString.Length
        If (Btot - Int(Btot)) = 0 Then
            i = i + 2
        End If
        If Btot < 1 And Btot > 0 Then
            i = i + 1
        End If

        If T <> 0 Then SRLgTxtBx.AppendText(Space(9 - i) & Strings.Format(Btot, "#0") & " ----B->")

        If T = 0 Then SRLgTxtBx.AppendText("infinite --B->")
        SRLgTxtBx.AppendText(Space(1))

        If DE >= L Then SRLgTxtBx.AppendText("Z N ")

        If DE < L Then SRLgTxtBx.AppendText("Z S ")

        SRLgTxtBx.AppendText(Strings.Format(Z4Deg, "#0") & Chr(176) & Strings.Format(Z4Min, "00") & "'")
        If LHA <= 180 Then SRLgTxtBx.AppendText(" W")
        If LHA > 180 Then SRLgTxtBx.AppendText(" E")
        SRLgTxtBx.AppendText(vbNewLine)

        SRLgTxtBx.AppendText("    (by formula)" & Space(9) & "AP/EP L " & Strings.Format(APEstLDeg, "#0") & Chr(176) & Strings.Format(APEstLMin, "00.0") & "'")

        If APEstL > 0 Then SRLgTxtBx.AppendText(g_LatN)

        If APEstL = 0 Then SRLgTxtBx.AppendText(g_StrSpace)

        If APEstL < 0 Then SRLgTxtBx.AppendText(g_LatS)

        SRLgTxtBx.AppendText("   AP/EP Lo " & Strings.Format(APEstLoDeg, "0") & Chr(176) & Strings.Format(APEstLoMin, "00.0") & "'")

        If APEstLo > 0 Then SRLgTxtBx.AppendText(g_LongW)
        If APEstLo = 0 Then SRLgTxtBx.AppendText(g_StrSpace)
        If APEstLo < 0 Then SRLgTxtBx.AppendText(g_LongE)
        SRLgTxtBx.AppendText(Space(8) & "(bottom)")
        SRLgTxtBx.AppendText(Space(3) & "Zn ")

        If chkInterpolateB.CheckState = 0 Then SRLgTxtBx.AppendText(Strings.Format(ZnTDeg, "#0") & Chr(176) & Strings.Format(ZnTMin, "00") & "'")
        If chkInterpolateB.CheckState = 1 Then SRLgTxtBx.AppendText(Strings.Format(ZnTDeg, "#0") & Chr(176) & Strings.Format(ZnTMin, "00.0") & "'")
        SRLgTxtBx.AppendText(vbNewLine)


        SRLgTxtBx.AppendText(Space(25) & "DR-LOP Distance " & Strings.Format(System.Math.Abs(KPLOPDist), "0.0") & " nm ")

        If KPLOPDist < 0 Then SRLgTxtBx.AppendText("Towards")

        If KPLOPDist > 0 Then SRLgTxtBx.AppendText("Away   ")

        If KPLOPDist = 0 Then SRLgTxtBx.AppendText("       ")

        SRLgTxtBx.AppendText(Space(24) & "(by tables)")
        SRLgTxtBx.AppendText(vbNewLine)

        AlignCenterRTB(SRLgTxtBx)
        SRLgTxtBx.AppendText("   EP L " & Strings.Format(EstLDeg, "0") & Chr(176) & Strings.Format(EstLMin, "00.0") & "'")

        SRLgTxtBx.AppendText("      EP Lo " & Strings.Format(EstLoDeg, "0") & Chr(176) & Strings.Format(EstLoMin, "00.0") & "'")

        SRLgTxtBx.AppendText(vbNewLine)

        AlignLeftRTB(SRLgTxtBx)
        SRLgTxtBx.AppendText("*Table entry values")
        SRLgTxtBx.Refresh()
        SRHdrTxtBx.Refresh()

        ' If cboL.Text = cboDec.Text And DE < L Then      'V5.6.1 (actually V5.4.1)
        ' Print TAB(26); "Note:  Body altitude when on prime vertical "; Format(HpvDeg, "#0"); Chr(176); Format(HpvMin, "00.0"); "'."
        ' If ZnLoC <= 90 Or ZnLoC >= 270 Then Print TAB(32); " Body is north of observer"
        ' If ZnLoC > 90 And ZnLoC < 270 Then Print TAB(32); " Body is south of observer"
        ' Print TAB(32); " for Dec and DR L same name and Dec < DR L."
        ' End If

        If cboL.Text = cboDec.Text And DE < L Then
            WeemsPVTxtBx.AppendText("Note:  Body altitude when on prime vertical " & Strings.Format(HpvDeg, "#0") & Chr(176) & Strings.Format(HpvMin, "00.0") & "'.")
            WeemsPVTxtBx.AppendText(vbNewLine)
            If ZnLoC <= 90 Or ZnLoC >= 270 Then WeemsPVTxtBx.AppendText(" Body is north of observer")
            If ZnLoC > 90 And ZnLoC < 270 Then WeemsPVTxtBx.AppendText(" Body is south of observer")
            WeemsPVTxtBx.AppendText(vbNewLine)
            WeemsPVTxtBx.AppendText(" for Dec and DR L same name and Dec < DR L.")
        End If

    End Sub

    Public Sub HO229()
        DSDcorrFlag = False
        LHA = GHA - Lo
        If LHA >= 360 Then LHA = LHA - 360
        If LHA < 0 Then LHA = LHA + 360
        AsmLHA = Int(LHA + 0.5)
        If AsmLHA = 360 Then AsmLHA = 0
        GHAAsmDeg = Val(txtGHADeg.Text)
        GHAAsmMin = Int(Val(txtGHAMin.Text) + 0.5)
        GHAAsm = GHAAsmDeg + GHAAsmMin / 60 'in degrees
        AsmLo = GHAAsm - AsmLHA
        If System.Math.Abs(AsmLo) < 180 Then AsmLo = 360 - System.Math.Abs(AsmLo)
        If System.Math.Abs(AsmLo) >= 180 And Lo >= 0 Then AsmLo = 360 - System.Math.Abs(AsmLo)
        If System.Math.Abs(AsmLo) >= 180 And Lo < 0 Then AsmLo = -(360 - System.Math.Abs(AsmLo))
        AsmLoDeg = Int(System.Math.Abs(AsmLo))
        If AsmLo > 0 Or txtLoDeg.Text = "180" Then AsmLoMin = Val(txtGHAMin.Text) Else AsmLoMin = 60 - Val(txtGHAMin.Text)
        If AsmLoMin = 60 Then AsmLoMin = 0
        AsmL = Int(L + 0.5)
        AsmDec = Int(System.Math.Abs(Dec))
        DecIncr = Val(txtDecMin.Text)
        If (cboDec.Text = "S" And cboL.Text = "N") Or (cboDec.Text = "N" And cboL.Text = "S") Then AsmDec = -AsmDec ': SignDE$ = "-"
        Hc = System.Math.Cos(AsmLHA * Pi / 180) * System.Math.Cos(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Cos(AsmDec * Pi / 180) + System.Math.Sin(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Sin(AsmDec * Pi / 180)
        If System.Math.Abs(Hc) >= 1 Then Hc = System.Math.Sign(Hc) * Pi / 2 Else Hc = System.Math.Atan(Hc / System.Math.Sqrt(-Hc * Hc + 1)) 'arcsine
        Hc = Hc * 180 / Pi
        TabHcDeg = Fix(Hc) 'was Int
        TabHcMin = Hc - TabHcDeg
        TabHcMin = Int((60 * TabHcMin) * 10 + 0.5) / 10 'WHY IS 0.50023 NEEDED!!!!!!!!!!!!!!! Extra problem 1 does not work without it.

        i = 1
        If AsmDec < 0 Then
            i = -1
        End If
        NextHc = System.Math.Cos(AsmLHA * Pi / 180) * System.Math.Cos(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Cos((AsmDec + i) * Pi / 180) + System.Math.Sin(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Sin((AsmDec + i) * Pi / 180)
        If System.Math.Abs(NextHc) >= 1 Then NextHc = System.Math.Sign(NextHc) * Pi / 2 Else NextHc = System.Math.Atan(NextHc / System.Math.Sqrt(-NextHc * NextHc + 1)) 'arcsine
        NextHc = NextHc * 180 / Pi
        NextHcDeg = Int(NextHc)
        NextHcMin = NextHc - NextHcDeg
        NextHcMin = Int((60 * NextHcMin) * 10 + 0.5) / 10

        i = -1
        If AsmDec < 0 Then
            i = 1
        End If
        NextHcDSD1 = System.Math.Cos(AsmLHA * Pi / 180) * System.Math.Cos(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Cos((AsmDec + i) * Pi / 180) + System.Math.Sin(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Sin((AsmDec + i) * Pi / 180)
        If System.Math.Abs(NextHcDSD1) >= 1 Then NextHcDSD1 = System.Math.Sign(NextHcDSD1) * Pi / 2 Else NextHcDSD1 = System.Math.Atan(NextHcDSD1 / System.Math.Sqrt(-NextHcDSD1 * NextHcDSD1 + 1)) 'arcsine
        NextHcDSD1 = NextHcDSD1 * 180 / Pi
        NextHcDSD1Deg = Int(NextHcDSD1)
        NextHcDSD1Min = NextHcDSD1 - NextHcDSD1Deg
        NextHcDSD1Min = Int((60 * NextHcDSD1Min) * 10 + 0.5) / 10

        i = 2
        If AsmDec < 0 Then
            i = -2
        End If
        NextHcDSD2 = System.Math.Cos(AsmLHA * Pi / 180) * System.Math.Cos(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Cos((AsmDec + i) * Pi / 180) + System.Math.Sin(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Sin((AsmDec + i) * Pi / 180)
        If System.Math.Abs(NextHcDSD2) >= 1 Then NextHcDSD2 = System.Math.Sign(NextHcDSD2) * Pi / 2 Else NextHcDSD2 = System.Math.Atan(NextHcDSD2 / System.Math.Sqrt(-NextHcDSD2 * NextHcDSD2 + 1)) 'arcsine
        NextHcDSD2 = NextHcDSD2 * 180 / Pi
        NextHcDSD2Deg = Int(NextHcDSD2)
        NextHcDSD2Min = NextHcDSD2 - NextHcDSD2Deg
        NextHcDSD2Min = Int((60 * NextHcDSD2Min) * 10 + 0.5) / 10

        D = (60 * NextHcDeg + NextHcMin) - (60 * TabHcDeg + TabHcMin)
        SgnD = System.Math.Sign(D)
        SignD = "+"
        If System.Math.Sign(D) = -1 Then
            SignD = "-"
        End If
        d1corr = Int((Int(System.Math.Abs(D) / 10) * DecIncr / 60) * 100 + 0.5) / 10
        d2corr = Int(((System.Math.Abs(D) - 10 * Int(System.Math.Abs(D) / 10)) * DecIncr / 60) * 10 + 0.5) / 10

        DSD1 = (60 * TabHcDeg + TabHcMin) - (60 * NextHcDSD1Deg + NextHcDSD1Min)
        DSD3 = (60 * NextHcDSD2Deg + NextHcDSD2Min) - (60 * NextHcDeg + NextHcMin)
        DSD = (D - DSD1) + (DSD3 - D)
        SgnDSD = System.Math.Sign(DSD)

        DSDcorr = 2.1 * System.Math.Sin(DecIncr * 3 * Pi / 180) * System.Math.Abs(DSD) / 33
        DSDcorr = Int(DSDcorr * 10 + 0.5) / 10
        If chkDSD.CheckState = 0 And DSDcorr <= 0.25 Then
            DSDcorr = 0
            DSDcorrFlag = True
        End If

        Totcorr = SgnD * (d1corr + d2corr) + System.Math.Abs(DSDcorr)
        SignTotcorr = "+"
        If Totcorr < 0 Then SignTotcorr = "-"

        TotHc = (TabHcDeg * 60 + TabHcMin + Totcorr) / 60

        TotHcDeg = Fix(TotHc)
        Htot = TotHc 'was Int
        TotHcMin = TotHc - TotHcDeg
        TotHcMin = Int(600 * TotHcMin + 0.5) / 10
        If TotHcMin = 60 Then TotHcMin = 0
        TotHcDeg = TotHcDeg + 1

        A = (60 * TotHcDeg + TotHcMin) - (60 * HoDeg + HoMin)

        L4 = System.Math.Sin(AsmDec * Pi / 180)
        L5 = System.Math.Sin(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Sin(Hc * Pi / 180)
        L6 = L4 - L5
        L7 = System.Math.Cos(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Cos(Hc * Pi / 180)
        L8 = L6 / L7
        If System.Math.Abs(L8) >= 1 Then Z = Pi Else Z = System.Math.Atan(-L8 / System.Math.Sqrt(-L8 * L8 + 1)) + Pi / 2 'arccosine
        Z = Z * 180 / Pi
        TabZ = Int(Z * 10 + 0.5) / 10

        'For calculating Z corr
        i = 1
        If AsmDec < 0 Then
            i = -1
        End If
        ZL4 = System.Math.Sin((AsmDec + i) * Pi / 180)
        ZL5 = System.Math.Sin(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Sin(NextHc * Pi / 180)
        ZL6 = ZL4 - ZL5
        ZL7 = System.Math.Cos(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Cos(NextHc * Pi / 180)
        ZL8 = ZL6 / ZL7
        If System.Math.Abs(ZL8) >= 1 Then
            ZC = Pi
        Else
            ZC = System.Math.Atan(-ZL8 / System.Math.Sqrt(-ZL8 * ZL8 + 1)) + Pi / 2 'arccosine
        End If
        ZC = ZC * 180 / Pi
        ZC = Int(ZC * 10 + 0.5) / 10

        Zdiff = ZC - TabZ
        If System.Math.Sign(Zdiff) = 0 Then SignZdiff = " "
        If System.Math.Sign(Zdiff) > 0 Then SignZdiff = "+"
        If System.Math.Sign(Zdiff) < 0 Then SignZdiff = "-"

        Zcorr = DecIncr / 60 * Zdiff
        Zcorr = Int(Zcorr * 10 + 0.5) / 10
        Ztot = TabZ + Zcorr
        Ztot = Int(Ztot * 10 + 0.5) / 10

        If cboL.Text = "N" And LHA > 180 Then ZN = Ztot
        If cboL.Text = "N" And LHA <= 180 Then ZN = 360 - Ztot
        If cboL.Text = "S" And LHA > 180 Then ZN = 180 - Ztot
        If cboL.Text = "S" And LHA <= 180 Then ZN = 180 + Ztot

        ZN = Int(ZN + 0.5) 'added in V4.0.0

    End Sub

    Public Sub Display229()
        cmdSave.Visible = False
        cmdFix.Visible = False
        cmdFix.Text = "Establish Fix"

        SRHdrTxtBx.Clear()
        SRHdrTxtBx.Visible = True
        SRHdrTxtBx.BringToFront()

        SRLgTxtBx.Clear()
        SRLgTxtBx.Visible = True
        SRLgTxtBx.BringToFront()

        SRLeftTxtBx.Clear()
        SRLeftTxtBx.Visible = False
        SRLeftTxtBx.SendToBack()

        SRRightTxtBx.Clear()
        SRRightTxtBx.Visible = False
        SRRightTxtBx.SendToBack()

        NASRAsmTxtBx.Clear()
        NASRAsmTxtBx.Visible = False
        NASRAsmTxtBx.SendToBack()

        NASRAFTxtBx.Clear()
        NASRAFTxtBx.Visible = False
        NASRAFTxtBx.SendToBack()

        DCorrTxtBx.Clear()
        DCorrTxtBx.Visible = False
        DCorrTxtBx.SendToBack()

        WeemsPVTxtBx.Clear()            'V5.6.1
        WeemsPVTxtBx.Visible = False    'V5.6.1
        WeemsPVTxtBx.SendToBack()   'V5.6.1

        frameNASRUsing.Visible = False
        frame211.Visible = False
        frame214.Visible = False
        Label9.Visible = False
        frameS.Visible = False
        GroupBoxPrecision.Visible = False      'V5.6.1

        chkInterpolateB.Visible = False
        chkDSD.Enabled = True
        If DSDcorr > 0.25 Then
            chkDSD.Enabled = False
        End If

        AlignCenterRTB(SRHdrTxtBx)
        SRHdrTxtBx.AppendText("Pub. 229")

        SRLgTxtBx.AppendText("Calc. of Asm Lo and LHA" & Space(58) & "Asm L " & Space(4 - AsmL.ToString.Length) & Strings.Format(System.Math.Abs(AsmL), "#0") & Chr(176))

        If AsmL = 0 Then
            SRLgTxtBx.AppendText(g_StrSpace)
        Else

            SRLgTxtBx.AppendText(cboL.Text)
        End If
        SRLgTxtBx.AppendText(vbNewLine)

        SRLgTxtBx.AppendText("Tot GHA" & Space(9 - txtGHADeg.Text.ToString.Length) & Strings.Format(Val(txtGHADeg.Text), "##0") & Chr(176) _
                           & Strings.Format(Val(txtGHAMin.Text), "00.0") & "'" & Space(60) & "DEC and LAT ")
        SRLgTxtBx.AppendText(vbNewLine)

        SRLgTxtBx.AppendText("Asm Lo (")
        If AsmLo = 0 Then
            SignA3 = " "

            SRLgTxtBx.AppendText("")
        End If
        If System.Math.Sign(AsmLo) = 1 Then

            SRLgTxtBx.AppendText("-")
            SignA3 = g_LongW
        End If
        If System.Math.Sign(AsmLo) = -1 Then

            SRLgTxtBx.AppendText("+")
            SignA3 = g_LongE
        End If
        If System.Math.Sign(AsmLo) = 0 Then

            SRLgTxtBx.AppendText(g_StrSpace)
            SignA3 = " "
        End If

        SRLgTxtBx.AppendText(")" & Space(6 - AsmLoDeg.ToString.Length) & Strings.Format(AsmLoDeg, "0") & Chr(176) & Strings.Format(AsmLoMin, "00.0") & "'" & SignA3)

        SRLgTxtBx.AppendText(Space(5) & "Dec" & Space(4 - DecDegrees.ToString.Length) & Strings.Format(DecDegrees, "#0") & Chr(176) & cboDec.Text)

        SRLgTxtBx.AppendText(Space(10) & "Dec Incr " & Strings.Format(DecIncr, "00.0") & "'")

        If cboL.Text = cboDec.Text Then
            SRLgTxtBx.AppendText(Space(21) & "SAME NAME    ")
        End If

        If cboL.Text <> cboDec.Text Then
            SRLgTxtBx.AppendText(Space(21) & "CONTRARY NAME")
        End If
        SRLgTxtBx.AppendText(vbNewLine)

        i = 89
        If TabZ < 100 Then
            i = 90
            If TabZ < 10 Then i = 91
        End If

        SRLgTxtBx.AppendText("LHA" & Space(13 - AsmLHA.ToString.Length) & Strings.Format(AsmLHA, "0") & Chr(176))

        SRLgTxtBx.AppendText(Space(11) & "d (" & SignD & ") " & Strings.Format(System.Math.Abs(D), "0.0") & "'")

        If DSDcorrFlag = False Then
            SRLgTxtBx.AppendText(Space(4) & "DSD " & Strings.Format(System.Math.Abs(DSD), "00.0") & "'")
        End If

        If chkDSD.CheckState = 0 And DSDcorrFlag = True Then
            SRLgTxtBx.AppendText(Space(4) & "DSD " & "    '")
        End If

        SRLgTxtBx.AppendText(Space(9) & "Z diff (" & SignZdiff & ") " & Strings.Format(System.Math.Abs(Zdiff), "0.0") & Chr(176))

        SRLgTxtBx.AppendText(Space(6) & "Tab Z " & Space(6 - TabZ.ToString.Length) & Strings.Format(TabZ, "0.0") & Chr(176))
        '"Hc "; Tab(42 - Str$(TotHcDeg))); Format(TotHcDeg, "0"); Chr$(176); Format(TotHcMin, "00"); "'"
        SRLgTxtBx.AppendText(vbNewLine)
        'i = 18: If Sgn(Hc) = -1 Then i = 17

        SRLgTxtBx.AppendText("Tab Hc " & Space(5))

        If System.Math.Sign(Hc) = -1 Then
            SRLgTxtBx.AppendText("-")
        Else
            SRLgTxtBx.AppendText(g_StrSpace)
        End If

        SRLgTxtBx.AppendText(Space(4 - System.Math.Abs(TabHcDeg).ToString.Length) & Strings.Format(System.Math.Abs(TabHcDeg), "0") & Chr(176) & Strings.Format(System.Math.Abs(TabHcMin), "00.0") & "'")
        i = 53
        If d1corr < 10 Then
            i = 54
        End If

        SRLgTxtBx.AppendText(Space(17) & "d1 corr. (" & SignD & ") " & Space(5 - Strings.Format(d1corr.ToString, "0.0").Length) & Strings.Format(System.Math.Abs(d1corr), "0.0") & "'")

        SRLgTxtBx.AppendText(Space(18) & "Z corr (" & SignZdiff & ") " & Strings.Format(System.Math.Abs(Zcorr), "0.0") & Chr(176))
        SRLgTxtBx.AppendText(vbNewLine)

        i = 18
        If System.Math.Abs(Totcorr) < 10 Then
            i = 19
        End If

        SRLgTxtBx.AppendText("Tot corr" & Space(2) & " (" & SignTotcorr & ") " & Space(5 - Strings.Format(Totcorr.ToString, "0.0").Length) & Strings.Format(System.Math.Abs(Totcorr), "0.0") & "'")
        i = 53
        If d2corr < 10 Then
            i = 54
        End If

        SRLgTxtBx.AppendText(Space(17) & "d2 corr. (" & SignD & ") " & Space(5 - Strings.Format(d2corr.ToString, "0.0").Length) & Strings.Format(System.Math.Abs(d2corr), "0.0") & "'")
        SRLgTxtBx.AppendText(vbNewLine)

        'i = 18: If Sgn(TotHc) = -1 Then i = 17

        SRLgTxtBx.AppendText("Hc " & Space(9))

        If System.Math.Sign(TotHc) = -1 Then
            SRLgTxtBx.AppendText("-")
        Else
            SRLgTxtBx.AppendText(g_StrSpace)
        End If

        SRLgTxtBx.AppendText(Space(4 - System.Math.Abs(TotHcDeg).ToString.Length) & Strings.Format(System.Math.Abs(TotHcDeg), "0") & Chr(176) _
                           & Strings.Format(System.Math.Abs(TotHcMin), "00.0") & "'")
        i = 53
        If DSDcorr < 10 Then
            i = 54
        End If

        If DSDcorrFlag = False Then
            SRLgTxtBx.AppendText(Space(17) & "DSD corr (+) " & Space(4 - Strings.Format(DSDcorr.ToString, "0.0").Length) & Strings.Format(System.Math.Abs(DSDcorr), "0.0") & "'")
        End If

        If chkDSD.CheckState = 0 And DSDcorrFlag = True Then
            SRLgTxtBx.AppendText(Space(17) & "DSD corr (+)    '")
        End If
        i = 89
        If Ztot < 100 Then
            i = 90

        End If
        If Ztot < 10 Then
            i = 91
        End If

        SRLgTxtBx.AppendText(Space(21) & "Z " & cboL.Text & Space(5 - Strings.Format(Ztot.ToString, "0.0").Length) & Strings.Format(System.Math.Abs(Ztot), "0.0") & Chr(176))

        If LHA <= 180 Then SRLgTxtBx.AppendText(" W")

        If LHA > 180 Then SRLgTxtBx.AppendText(" E")
        SRLgTxtBx.AppendText(vbNewLine)

        i = 53
        If System.Math.Abs(Totcorr) < 10 Then
            i = 54
        End If
        'HoMin = Int(HoMin + 0.5)

        SRLgTxtBx.AppendText("Ho " & Space(9))

        If HoinMinutes < 0 Then
            SRLgTxtBx.AppendText("-")
        Else
            SRLgTxtBx.AppendText(g_StrSpace)
        End If

        SRLgTxtBx.AppendText(Space(4 - HoDeg.ToString.Length) & Strings.Format(System.Math.Abs(HoDeg), "0") & Chr(176) & Strings.Format(System.Math.Abs(HoMin), "00.0") & "'")

        SRLgTxtBx.AppendText(Space(17) & "Tot corr (" & SignTotcorr & ") " & Space(5 - Strings.Format(Totcorr.ToString, "0.0").Length) & Strings.Format(System.Math.Abs(Totcorr), "0.0") & "'")
        SRLgTxtBx.AppendText(vbNewLine)

        SRLgTxtBx.AppendText(Space(13) & "a " & Space(7 - Int(System.Math.Abs(A)).ToString.Length) & Strings.Format((Int(System.Math.Abs(A) * 10 + 0.5)) / 10, "0.0") & " miles ")
        PlotOut.PlotIntercept = Strings.Format((Int(System.Math.Abs(A) * 10 + 0.5)) / 10, "0.0") & " nm "
        If A < 0 Then
            SRLgTxtBx.AppendText("T  Observed greater - Toward")
            PlotOut.PlotIntercept &= " Toward"
        End If

        If A > 0 Then
            SRLgTxtBx.AppendText("A  Computed greater - Away")
            PlotOut.PlotIntercept &= " Away"
        End If

        SRLgTxtBx.AppendText(Space(19) & "Zn    " & Strings.Format(ZN, "000") & Chr(176))
        PlotOut.PlotAz = Strings.Format(ZN, "000") & Chr(176)
        SRLgTxtBx.AppendText(vbNewLine)

        SRLgTxtBx.AppendText(vbNewLine)

        SRLgTxtBx.AppendText(Space(34) & "AP/EP L " & Strings.Format(APEstLDeg, "0") & Chr(176) & Strings.Format(APEstLMin, "00.0") & "'")

        Select Case APEstL
            Case > 0
                SRLgTxtBx.AppendText(g_LatN)
            Case < 0
                SRLgTxtBx.AppendText(g_LatS)
            Case Else
                SRLgTxtBx.AppendText(g_StrSpace)
        End Select
        'If APEstL > 0 Then SRLgTxtBx.AppendText(g_LatN)
        'If APEstL = 0 Then SRLgTxtBx.AppendText(g_StrSpace)
        'If APEstL < 0 Then SRLgTxtBx.AppendText(g_LatS)

        SRLgTxtBx.AppendText("   AP/EP Lo " & Strings.Format(APEstLoDeg, "0") & Chr(176) & Strings.Format(APEstLoMin, "00.0") & "'")

        Select Case APEstLo
            Case > 0
                SRLgTxtBx.AppendText(g_LongW)
            Case < 0
                SRLgTxtBx.AppendText(g_LongE)
            Case Else
                SRLgTxtBx.AppendText(g_StrSpace)
        End Select
        'If APEstLo > 0 Then SRLgTxtBx.AppendText(g_LongW)
        'If APEstLo = 0 Then SRLgTxtBx.AppendText(g_StrSpace)
        'If APEstLo < 0 Then SRLgTxtBx.AppendText(g_LongE)
        SRLgTxtBx.AppendText(vbNewLine)

        SRLgTxtBx.AppendText(Space(34) & "DR-LOP Distance " & Strings.Format(System.Math.Abs(KPLOPDist), "0.0") & " nm ")

        Select Case KPLOPDist
            Case > 0
                SRLgTxtBx.AppendText("A")
            Case < 0
                SRLgTxtBx.AppendText("T")
            Case Else
                SRLgTxtBx.AppendText(g_StrSpace)
        End Select
        'If KPLOPDist < 0 Then SRLgTxtBx.AppendText("T")
        'If KPLOPDist > 0 Then SRLgTxtBx.AppendText("A")
        'If KPLOPDist = 0 Then SRLgTxtBx.AppendText(g_StrSpace)
        SRLgTxtBx.AppendText(vbNewLine)
        SRLgTxtBx.AppendText(Space(34) & "   EP L " & Strings.Format(EstLDeg, "0") & Chr(176) & Strings.Format(EstLMin, "00.0") & "'")

        SRLgTxtBx.AppendText("      EP Lo " & Strings.Format(EstLoDeg, "0") & Chr(176) & Strings.Format(EstLoMin, "00.0") & "'")

        SRLgTxtBx.AppendText(vbNewLine)

        SRLgTxtBx.Refresh()
        SRHdrTxtBx.Refresh()


    End Sub
    Public Sub HO211()
        frame211.Visible = False

        Flag = False 'Part of avoiding divide-by-zero errors
        LHA = GHA - Lo
        If LHA >= 360 Then LHA = LHA - 360
        If LHA < 0 Then LHA = LHA + 360
        If LHA <= 180 Then T = LHA 'W
        If LHA > 180 Then T = 360 - LHA 'E
        tDeg = Int(T)
        tMin = (T - tDeg) * 60
        If optCompact.Checked = True Then tMin = Int(tMin + 0.50000001)
        If optOriginal.Checked = True Then tMin = Int(2 * tMin + 0.5) / 2
        If tMin = 60 Then tMin = 0 : tDeg = tDeg + 1
        tDecimal = tDeg + tMin / 60 ': If tDecimal = 0 Then tDecimal = 0.00000001
        If optCompact.Checked = True And tDecimal = 0 Then
            ErrorMsgBox("For Compact H.O. 211 without interpolation, meridian angle t must be at least 0.5'.")
            Flag = True
            Exit Sub
        End If
        If optOriginal.Checked = True And tDecimal = 0 Then
            ErrorMsgBox("For Original H.O. 211 without interpolation, meridian angle t must be at least 0.3'.")
            Flag = True
            Exit Sub
        End If
        A1 = Csc211(tDecimal)
        If (optCompact.Checked = True And A1 < 166) Or (optOriginal.Checked = True And A1 < 239) Then
            A1 = Int(10 * A1 + 0.5) / 10
        Else
            A1 = Int(A1 + 0.5)
        End If
        If optCompact.Checked = True Then DecMinutes = Int(Val(txtDecMin.Text) + 0.5)
        If optOriginal.Checked = True Then DecMinutes = Int(2 * Val(txtDecMin.Text) + 0.5) / 2
        DecDecimal = Val(txtDecDeg.Text) + DecMinutes / 60

        If optCompact.Checked = True And DecDecimal = 0 Then
            ErrorMsgBox("For Compact H.O. 211 without interpolation, Dec must be at least 0.5'.")
            Flag = True
            Exit Sub
        End If
        If optOriginal.Checked = True And DecDecimal = 0 Then
            ErrorMsgBox("For Original H.O. 211 without interpolation, Dec must be at least 0.3'.")
            Flag = True
            Exit Sub
        End If
        frame211.Visible = True
        B1 = Sec211(DecDecimal)
        If (optCompact.Checked = True And B1 < 166) Or (optOriginal.Checked = True And B1 < 239) Then
            B1 = Int(10 * B1 + 0.5) / 10
        Else
            B1 = Int(B1 + 0.5)
        End If
        A2 = Csc211(DecDecimal)
        If (optCompact.Checked = True And A2 < 166) Or (optOriginal.Checked = True And A2 < 239) Then
            A2 = Int(10 * A2 + 0.5) / 10
        Else
            A2 = Int(A2 + 0.5)
        End If
        A3 = A1 + B1
        A3 = Int(A3 * 10 + 0.5) / 10 'is this line necessary?
        A4 = A3
        A3Angle = 1 / (10 ^ (A3 / 100000))
        A3Angle = System.Math.Atan(A3Angle / System.Math.Sqrt(-A3Angle * A3Angle + 1) + 9.999999E-21) 'arcsin
        A3Angle = A3Angle * 180 / Pi
        A3AngleDeg = Int(A3Angle)
        A3AngleMin = (A3Angle - A3AngleDeg) * 60
        If optCompact.Checked = True Then A3AngleMin = Int(A3AngleMin + 0.5)
        If optOriginal.Checked = True Then A3AngleMin = Int(2 * A3AngleMin + 0.5) / 2
        A3AngleDecimal = A3AngleDeg + A3AngleMin / 60
        B2 = Sec211(A3AngleDecimal)
        If (optCompact.Checked = True And B2 < 166) Or (optOriginal.Checked = True And B2 < 239) Then
            B2 = Int(10 * B2 + 0.5) / 10
        Else
            B2 = Int(B2 + 0.5)
        End If
        B3 = B2
        A5 = A2 - B2
        A5 = Int(A5 * 10 + 0.5) / 10 'is this line necessary?
        k = 1 / (10 ^ (A5 / 100000))
        If k >= 1 Then k = Pi / 2 Else k = System.Math.Atan(k / System.Math.Sqrt(-k * k + 1) + 9.999999E-21) 'arcsin            Was If k = 1 before V5.4.1
        k = k * 180 / Pi

        If k >= 82 And k <= 98 Then
            B2 = Sec211(A3Angle)
            B2 = Int(1000 * B2 + 0.5) / 1000
            B3 = B2
            A5 = A2 - B2
            'A5 = CscS(DecDecimal) - SecS(A3Angle)
            'A5 = Int(1000 * A5 + 0.5) / 1000
            k = 1 / (10 ^ (A5 / 100000))
            If k >= 1 Then k = Pi / 2 Else k = System.Math.Atan(k / System.Math.Sqrt(-k * k + 1) + 9.999999E-21) 'arcsin        Was If k = 1 before V5.4.1
            k = k * 180 / Pi
            A5 = Int(1000 * A5 + 0.5) / 1000
        End If

        If tDecimal > 90 Then k = 180 - k '????????????90-K or 180-K????????
        KDeg = Int(k)
        KMin = (k - KDeg) * 60
        If optCompact.Checked = True Then KMin = Int(KMin + 0.5)
        If optOriginal.Checked = True Then KMin = Int(2 * KMin + 0.5) / 2
        If optCompact.Checked = True Then L = Val(txtLDeg.Text) + Int(Val(txtLMin.Text) + 0.5) / 60
        If optOriginal.Checked = True Then L = Val(txtLDeg.Text) + Val(txtLMin.Text) / 60
        If cboDec.Text = cboL.Text Then KL = System.Math.Abs(L - KDeg - KMin / 60)
        If cboDec.Text <> cboL.Text Then KL = System.Math.Abs(L + KDeg + KMin / 60)
        'If KL > 90 Then KL = KL + 180
        KLDeg = Int(KL)
        KLMin = (KL - KLDeg) * 60
        If KLDeg > 90 Then KLDeg = KLDeg + 180
        If optCompact.Checked = True Then KLMin = Int(KLMin + 0.5)
        If optOriginal.Checked = True Then KLMin = Int(2 * KLMin + 0.5) / 2
        If KLMin >= 60 Then KLMin = KLMin - 60 : KLDeg = KLDeg + 1

        B4 = Sec211(KLDeg + KLMin / 60)
        If KLDeg > 270 Then KLDeg = KLDeg - 180
        If (optCompact.Checked = True And B4 < 166) Or (optOriginal.Checked = True And B4 < 239) Then B4 = Int(10 * B4 + 0.5) / 10 Else B4 = Int(B4 + 0.5)
        A6 = B3 + B4
        A6 = Int(A6 * 10 + 0.5) / 10 'is this line necessary?
        HcAngle = 1 / (10 ^ (A6 / 100000))
        If HcAngle = 1 Then HcAngle = Pi / 2 Else HcAngle = System.Math.Atan(HcAngle / System.Math.Sqrt(-HcAngle * HcAngle + 1) + 9.999999E-21) 'arcsin
        HcAngle = HcAngle * 180 / Pi : Htot = HcAngle
        HcDeg = Int(HcAngle)
        HcMin = (HcAngle - HcDeg) * 60
        If optCompact.Checked = True Then HcMin = Int(HcMin + 0.5)
        If optOriginal.Checked = True Then HcMin = Int(2 * HcMin + 0.5) / 2
        If HcMin >= 60 Then HcMin = HcMin - 60 : HcDeg = HcDeg + 1
        HcDecimal = HcDeg + HcMin / 60
        If KL > 90 Then HcDecimal = -HcDecimal
        B5 = Sec211(HcDecimal)
        If (optCompact.Checked = True And B5 < 166) Or (optOriginal.Checked = True And B5 < 239) Then B5 = Int(10 * B5 + 0.5) / 10 Else B5 = Int(B5 + 0.5)
        Ho = Val(txtHoDeg.Text) + Val(txtHoMin.Text) / 60
        'HoDeg = Int(Ho)
        'HoMin = (Ho - HoDeg) * 60
        HoDeg = Val(txtHoDeg.Text)
        HoMin = Val(txtHoMin.Text)
        If optCompact.Checked = True Then HoMin = Int(HoMin + 0.5)
        If optOriginal.Checked = True Then HoMin = Int(HoMin * 10 + 0.5) / 10
        A = System.Math.Sign(HcDecimal) * (60 * HcDeg + HcMin) - (60 * HoDeg + HoMin)
        If HoinMinutes < 0 Then A = (60 * HcDeg + HcMin) + (60 * HoDeg + HoMin)
        A7 = A4 - B5
        If A7 <= 0 Then A7 = 0 : Z = 90 'When the body is near or on the Prime Vertical, A7 may be negative.  Use zero for A7 and Z will be 90 degrees.
        If A7 <> 0 Then
            Z = 1 / (10 ^ (A7 / 100000))
            Z = System.Math.Atan(Z / System.Math.Sqrt(-Z * Z + 1) + 9.999999E-21) 'arcsin
            Z = Z * 180 / Pi
        End If
        A7 = Int(A7 * 10 + 0.5) / 10 'this line was necessary for low value of A7
        If cboDec.Text = cboL.Text And k > L Then Z = Z Else Z = 180 - Z
        ZDeg = Int(Z)
        ZMin = (Z - ZDeg) * 60
        'If optCompact = True Then Z = Int(Z + 0.5)  'For Z in whole degrees
        If optCompact.Checked = True Then ZMin = Int(ZMin + 0.5)
        If optOriginal.Checked = True Then ZMin = Int(2 * ZMin + 0.5) / 2
        If cboL.Text = "N" And LHA > 180 Then ZN = Z
        If cboL.Text = "N" And LHA <= 180 Then ZN = 360 - Z
        If cboL.Text = "S" And LHA > 180 Then ZN = 180 - Z
        If cboL.Text = "S" And LHA <= 180 Then ZN = 180 + Z

        If cboL.Text = "S" Then L = -L

    End Sub
    Public Sub HO208()
        '    frame211.Visible = False

        Flag = False : Flag0 = False
        LHA = GHA - Lo
        If LHA >= 360 Then LHA = LHA - 360
        If LHA < 0 Then LHA = LHA + 360
        AsmLHA = Int(LHA + 0.5)
        If AsmLHA = 0 Or AsmLHA = 360 Or AsmLHA = 180 Then
            ErrorMsgBox("For H.O. 208, LHA (GHA - LoW, GHA + LoE) to nearest whole degree cannot be 0º or 180º.")
            Flag0 = True
            Exit Sub
        End If
        If LHA <= 180 Then T = AsmLHA 'W
        If LHA > 180 Then T = 360 - AsmLHA 'E

        AsmLo = GHAAsm - AsmLHA

        If System.Math.Abs(AsmLo) < 180 Then AsmLo = 360 - System.Math.Abs(AsmLo)
        If System.Math.Abs(AsmLo) >= 180 And Lo >= 0 Then AsmLo = 360 - System.Math.Abs(AsmLo)
        If System.Math.Abs(AsmLo) >= 180 And Lo < 0 Then AsmLo = -(360 - System.Math.Abs(AsmLo))

        AsmLoDeg = Int(System.Math.Abs(AsmLo))
        If AsmLo > 0 Or txtLoDeg.Text = "180" Then AsmLoMin = Val(txtGHAMin.Text) Else AsmLoMin = 60 - Val(txtGHAMin.Text)
        If AsmLoMin = 60 Then AsmLoMin = 0

        AsmL = Int(L + 0.5)

        DecDecimal = System.Math.Abs(Val(txtDecDeg.Text) + DecMinutes / 60)

        If AsmL = 0 Then AsmL = 0.0000000001
        B1 = (1 / System.Math.Tan(AsmL * Pi / 180)) * System.Math.Cos(T * Pi / 180) : B1 = System.Math.Atan(B1) * 180 / Pi 'B1 is b
        B1Deg = Int(System.Math.Abs(B1))
        B1Min = (System.Math.Abs(B1) - B1Deg) * 60
        B1Min = Int(B1Min * 10 + 0.5) / 10
        If B1Min = 60 Then B1Min = 0 : B1Deg = B1Deg + 1
        B1 = System.Math.Abs(B1Deg + B1Min / 60)

        If T <= 90 Then SignB = cboL.Text
        If T > 90 Then
            If cboL.Text = "N" Then SignB = g_LatS
            If cboL.Text = "S" Then SignB = g_LatN
        End If
        If System.Math.Abs(AsmL) <= 0.5 Then SignB = cboDec.Text 'For L=0, b gets same name as Dec

        A1 = System.Math.Cos(AsmL * Pi / 180) * System.Math.Sin(T * Pi / 180)
        A1 = System.Math.Atan(A1 / System.Math.Sqrt(-A1 * A1 + 1)) 'arcsin        A1 is a
        If A1 = 0 Then A1 = 0.0000000001 * Pi / 180
        A2 = 100000 * (System.Math.Log(1 / System.Math.Cos(A1)) / System.Math.Log(10))
        A2 = Int(A2 + 0.5) 'A2 is A
        A4 = 1000 * System.Math.Abs(System.Math.Log(1 / (System.Math.Sin(A1))) / System.Math.Log(10))
        A4 = Int(A4 + 0.5) 'A4 is C
        If AsmL = 0 Or T = 0 Then Z1 = 0 Else Z1 = System.Math.Sin(AsmL * Pi / 180) * System.Math.Tan(T * Pi / 180) : Z1 = System.Math.Atan(1 / Z1) * 180 / Pi
        Z1 = Int(System.Math.Abs(Z1) * 10 + 0.5) / 10 'Z1 is Z'
        SignZ1 = SignB

        If cboDec.Text = SignB Then A3 = System.Math.Abs(DecDecimal + B1) Else A3 = System.Math.Abs(DecDecimal - B1) 'A3 is d + b
        If System.Math.Abs(DecDecimal) >= System.Math.Abs(B1) Then SignA3 = cboDec.Text
        If System.Math.Abs(DecDecimal) < System.Math.Abs(B1) Then SignA3 = SignB
        A3Deg = Int(A3)
        A3Min = (A3 - Int(A3)) * 60
        A3Min = Int(A3Min * 10 + 0.5) / 10
        If A3Min = 60 Then A3Min = 0 : A3Deg = A3Deg + 1
        A3 = A3Deg + A3Min / 60

        'If A3 > 90 Then A3 = 180 - A3: Flag = True

        B2 = 100000 * (System.Math.Log(1 / System.Math.Sin(A3 * Pi / 180)) / System.Math.Log(10))
        B2 = Int(B2 + 0.5) 'B2 is B

        If cboDec.Text <> cboL.Text Then DecDecimal = -DecDecimal

        A5 = A2 + B2 'A + B
        Hc = System.Math.Cos(A1) * System.Math.Sin(A3 * Pi / 180)
        If Hc = 1 Then Hc = Pi / 2 Else Hc = System.Math.Atan(Hc / System.Math.Sqrt(-Hc * Hc + 1) + 9.999999E-21) 'arcsin
        Hc = Hc * 180 / Pi ': Htot = Hc
        HcDeg = Int(Hc)
        HcMin = (Hc - HcDeg) * 60
        HcMin = Int(HcMin * 10 + 0.5) / 10
        If HcMin = 60 Then HcMin = 0 : HcDeg = HcDeg + 1
        Hc = HcDeg + HcMin / 60
        'If (DecDecimal + B1) < 0 Then Hc = -Hc
        If SignA3 <> cboL.Text Then Hc = -Hc
        Htot = Hc

        'B3 = 1 / Tan(A3 * Pi / 180)
        B3 = System.Math.Abs(1 / System.Math.Tan(A3 * Pi / 180))
        B3 = 1000 * (System.Math.Log(B3) / System.Math.Log(10)) 'B3 is D
        B3 = Int(B3 + 0.5)
        If A3 = 90 Then B3 = 0
        If B3 < 0 Then B3 = 10000 + B3 'WHY?
        'B3 = Int(B3 + 0.5)

        A6 = A4 + B3 'A6 is C + D
        If A6 > 10000 Then A6 = A6 - 10000
        Z2 = (1 / (System.Math.Sin(A1))) * (1 / System.Math.Tan(A3 * Pi / 180))
        Z2 = System.Math.Abs(System.Math.Atan(Z2))
        Z2 = Z2 * 180 / Pi
        Z2 = Int(Z2 * 10 + 0.5) / 10
        'If cboDec.text <> cboL.text Then DecDecimal = -DecDecimal
        If (DecDecimal + B1) < 0 Then Z2 = 180 - Z2
        SignZ2 = SignA3



        'If Flag = True Then Z2 = -Z2
        'If A3 > 90 Then Z2 = -Z2
        If A3 > 90 Then
            If SignA3 = "N" Then SignZ2 = g_LatS
            If SignA3 = "S" Then SignZ2 = g_LatN
        End If

        'Z = Z1 + Z2
        If SignZ1 = SignZ2 Then Z = System.Math.Abs(Z1 + Z2) Else Z = System.Math.Abs(Z1 - Z2)
        If System.Math.Abs(AsmL) <= 0.5 Then cboL.Text = cboDec.Text 'For L=0, L gets same name as Dec
        If cboL.Text = "N" And LHA > 180 Then ZN = Z
        If cboL.Text = "N" And LHA <= 180 Then ZN = 360 - Z
        If cboL.Text = "S" And LHA > 180 Then ZN = 180 - Z
        If cboL.Text = "S" And LHA <= 180 Then ZN = 180 + Z

        A = System.Math.Sign(Hc) * (60 * HcDeg + HcMin) - (60 * HoDeg + HoMin)
        If HoinMinutes < 0 Then A = (60 * HcDeg + HcMin) + (60 * HoDeg + HoMin)

    End Sub

    Public Sub Display211()
        cmdSave.Visible = False
        cmdFix.Visible = False '
        cmdFix.Enabled = False
        cmdFix.Text = "Establish Fix"
        'Me.Font = New Font(Me.Font, "Courier New")

        SRHdrTxtBx.Clear()
        SRHdrTxtBx.Visible = True
        SRHdrTxtBx.BringToFront()

        SRLgTxtBx.Clear()
        SRLgTxtBx.Visible = True
        SRLgTxtBx.BringToFront()

        SRLeftTxtBx.Clear()
        SRLeftTxtBx.Visible = False
        SRLeftTxtBx.SendToBack()

        SRRightTxtBx.Clear()
        SRRightTxtBx.Visible = False
        SRRightTxtBx.SendToBack()

        NASRAsmTxtBx.Clear()
        NASRAsmTxtBx.Visible = False
        NASRAsmTxtBx.SendToBack()

        NASRAFTxtBx.Clear()
        NASRAFTxtBx.Visible = False
        NASRAFTxtBx.SendToBack()

        DCorrTxtBx.Clear()
        DCorrTxtBx.Visible = False
        DCorrTxtBx.SendToBack()

        WeemsPVTxtBx.Clear()            'V5.6.1
        WeemsPVTxtBx.Visible = False    'V5.6.1
        WeemsPVTxtBx.SendToBack()   'V5.6.1

        frameNASRUsing.Visible = False
        'frame211.Visible = True        'moved to HO211 so it doesn't appear if LHA or Dec are near zero
        frame214.Visible = False
        Label9.Visible = False
        frameS.Visible = False
        GroupBoxPrecision.Visible = False      'V5.6.1
        chkInterpolateB.Visible = False

        AlignCenterRTB(SRHdrTxtBx)
        SRHdrTxtBx.AppendText("INTERCEPT and AZIMUTH by AGETON'S METHOD (H.O. 211)")

        'Print

        If optCompact.Checked = True Then
            SRLgTxtBx.AppendText("t*" & Space(11 - tDeg.ToString.Length) & Strings.Format(tDeg, "0") & Chr(176) & Strings.Format(tMin, "00") & "'")
        End If

        If optOriginal.Checked = True Then
            SRLgTxtBx.AppendText("t*" & Space(11 - tDeg.ToString.Length) & Strings.Format(tDeg, "0") & Chr(176) & Strings.Format(tMin, "00.0") & "'")
        End If

        If LHA <= 180 Then SRLgTxtBx.AppendText(g_LongW)
        If LHA > 180 Then SRLgTxtBx.AppendText(g_LongE)
        i = A1.ToString.Length
        If (A1 - Int(A1)) = 0 Then
            i = i + 2
        End If
        If A1 < 1 And A1 > 0 Then
            i = i + 1
        End If

        If (optCompact.Checked = True And A1 < 166) Or (optOriginal.Checked = True And A1 < 239) Then
            SRLgTxtBx.AppendText(Space(8) & "A " & Space(9 - i) & Strings.Format(A1, "0.0"))
        Else
            SRLgTxtBx.AppendText(Space(8) & "A " & Space(9 - i) & Strings.Format(A1, "0"))
        End If
        SRLgTxtBx.AppendText(vbNewLine)

        If optCompact.Checked = True Then
            SRLgTxtBx.AppendText("Dec*" & Space(9 - txtDecDeg.Text.ToString.Length) & Strings.Format(Val(txtDecDeg.Text), "0") _
                               & Chr(176) & Strings.Format(DecMinutes, "00") & "'" & cboDec.Text)
        End If

        If optOriginal.Checked = True Then
            SRLgTxtBx.AppendText("Dec*" & Space(9 - txtDecDeg.Text.ToString.Length) & Strings.Format(Val(txtDecDeg.Text), "0") _
                               & Chr(176) & Strings.Format(DecMinutes, "00.0") & "'" & cboDec.Text)
        End If
        i = B1.ToString.Length
        If (B1 - Int(B1)) = 0 Then
            i = i + 2
        End If


        If (optCompact.Checked = True And B1 < 166) Or (optOriginal.Checked = True And B1 < 239) Then
            SRLgTxtBx.AppendText(Space(7) & "B+" & Space(9 - i))
            SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Underline)
            SRLgTxtBx.AppendText(Strings.Format(B1, "0.0"))
            SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Regular)
        Else
            SRLgTxtBx.AppendText(Space(7) & "B+" & Space(9 - i))
            SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Underline)
            SRLgTxtBx.AppendText(Strings.Format(B1, "0"))
            SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Regular)
        End If
        i = A2.ToString.Length
        If (A2 - Int(A2)) = 0 Then
            i = i + 2
        End If

        If (optCompact.Checked = True And A2 < 166) Or (optOriginal.Checked = True And A2 < 239) Then
            SRLgTxtBx.AppendText(Space(11) & "A " & Space(9 - i) & Strings.Format(A2, "0.0"))
        Else
            SRLgTxtBx.AppendText(Space(11) & "A " & Space(9 - i) & Strings.Format(A2, "0"))
        End If
        SRLgTxtBx.AppendText(vbNewLine)

        i = A3.ToString.Length
        If (A3 - Int(A3)) = 0 Then
            i = i + 2 '7
        End If

        If A3 - Int(A3) <> 0 Then
            SRLgTxtBx.AppendText(Space(25) & "A " & Space(9 - i) & Strings.Format(A3, "0.0"))
        End If

        If A3 - Int(A3) = 0 Then
            SRLgTxtBx.AppendText(Space(25) & "A " & Space(9 - i) & Strings.Format(A3, "0"))
        End If

        i = B2.ToString.Length
        If (B2 - Int(B2)) = 0 Then
            i = i + 2
        End If

        If (optCompact.Checked = True And B2 < 166) Or (optOriginal.Checked = True And B2 < 239) Then
            SRLgTxtBx.AppendText(Space(11) & "B-" & Space(9 - i))
            SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Underline)
            SRLgTxtBx.AppendText(Strings.Format(B2, "0.0"))
            SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Regular)
        Else
            SRLgTxtBx.AppendText(Space(11) & "B-" & Space(9 - i))
            SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Underline)
            SRLgTxtBx.AppendText(Strings.Format(B2, "0"))
            SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Regular)
        End If

        If k >= 82 And k <= 98 Then
            SRLgTxtBx.AppendText("** ")
        Else
            SRLgTxtBx.AppendText("   ")
        End If
        i = B3.ToString.Length
        If (B3 - Int(B3)) = 0 Then
            i = i + 2
        End If

        If (optCompact.Checked = True And B3 < 166) Or (optOriginal.Checked = True And B3 < 239) Then
            SRLgTxtBx.AppendText(Space(9) & "B " & Space(9 - i) & Strings.Format(B3, "0.0"))
        Else
            SRLgTxtBx.AppendText(Space(9) & "B " & Space(9 - i) & Strings.Format(B3, "0"))
        End If

        i = A4.ToString.Length
        If (A4 - Int(A4)) = 0 Then
            i = i + 2
        End If
        'If (optCompact = True And A4 < 166) Or (optOriginal = True And A4 < 239) Then Print Tab(85); "A"; Tab(97 - i); Format(A4, "0.0") Else _
        'Print Tab(85); "A"; Tab(97 - i); Format(A4, "0")

        If A4 - Int(A4) <> 0 Then
            SRLgTxtBx.AppendText(Space(11) & "A " & Space(9 - i) & Strings.Format(A4, "0.0"))
        End If
        If A4 - Int(A4) = 0 Then
            SRLgTxtBx.AppendText(Space(11) & "A " & Space(9 - i) & Strings.Format(A4, "0"))
        End If
        SRLgTxtBx.AppendText(vbNewLine)

        If optCompact.Checked = True Then
            SRLgTxtBx.AppendText("K    " & Space(8 - KDeg.ToString.Length) & Strings.Format(KDeg, "0") & Chr(176) & Strings.Format(KMin, "00") & "'" & cboDec.Text)
        End If

        If optOriginal.Checked = True Then
            SRLgTxtBx.AppendText("K    " & Space(8 - KDeg.ToString.Length) & Strings.Format(KDeg, "0") & Chr(176) & Strings.Format(KMin, "00.0") & "'" & cboDec.Text)
        End If
        'If k >= 82 And k <= 98 Then Print "**";

        SRLgTxtBx.AppendText("  <- <- <- <- <- <- <-")

        If optCompact.Checked = True Then
            SRLgTxtBx.AppendText(" <- ")
        Else
            SRLgTxtBx.AppendText("    ")
        End If
        i = A5.ToString.Length
        If (A5 - Int(A5)) = 0 Then
            i = i + 2
        End If

        If A5 - Int(A5) <> 0 Then
            SRLgTxtBx.AppendText("A " & Space(9 - i) & Strings.Format(A5, "0.0"))
        End If

        If A5 - Int(A5) = 0 Then
            SRLgTxtBx.AppendText("A " & Space(9 - i) & Strings.Format(A5, "0"))
        End If
        SRLgTxtBx.AppendText(vbNewLine)

        If optCompact.Checked = True Then
            SRLgTxtBx.AppendText("DR L " & Space(8 - txtLDeg.Text.ToString.Length))
            SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Underline)
            SRLgTxtBx.AppendText(Strings.Format(Val(txtLDeg.Text), "0") & Chr(176) & Strings.Format(Int(Val(txtLMin.Text) + 0.5), "00") & "'" & cboL.Text)
            SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Regular)
        End If

        If optOriginal.Checked = True Then
            SRLgTxtBx.AppendText("DR L " & Space(8 - txtLDeg.Text.ToString.Length))
            SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Underline)
            SRLgTxtBx.AppendText(Strings.Format(Val(txtLDeg.Text), "0") & Chr(176) & Strings.Format(Val(txtLMin.Text), "00.0") & "'" & cboL.Text)
            SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Regular)
        End If
        SRLgTxtBx.AppendText(vbNewLine)

        If optCompact.Checked = True Then
            SRLgTxtBx.AppendText("K ~ L" & Space(8 - KLDeg.ToString.Length) & Strings.Format(KLDeg, "0") & Chr(176) & Strings.Format(KLMin, "00") & "'")
        End If

        If optOriginal.Checked = True Then
            SRLgTxtBx.AppendText("K ~ L" & Space(8 - KLDeg.ToString.Length) & Strings.Format(KLDeg, "0") & Chr(176) & Strings.Format(KLMin, "00.0") & "'")
        End If

        SRLgTxtBx.AppendText("   -> -> -> -> -> -> -> -> -> -> -> -> -> ->")

        If optCompact.Checked = True Then
            SRLgTxtBx.AppendText(" -> ")
        Else
            SRLgTxtBx.AppendText("    ")
        End If
        i = B4.ToString.Length
        If (B4 - Int(B4)) = 0 Then
            i = i + 2
        End If

        If (optCompact.Checked = True And B4 < 166) Or (optOriginal.Checked = True And B4 < 239) Then
            SRLgTxtBx.AppendText("B+" & Space(9 - i))
            SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Underline)
            SRLgTxtBx.AppendText(Strings.Format(B4, "0.0"))
            SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Regular)
        Else
            SRLgTxtBx.AppendText("B+" & Space(9 - i))
            SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Underline)
            SRLgTxtBx.AppendText(Strings.Format(B4, "0"))
            SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Regular)
        End If
        SRLgTxtBx.AppendText(vbNewLine)

        SRLgTxtBx.AppendText("Hc")

        If KL > 90 Then
            SRLgTxtBx.AppendText(Space(9 - HcDeg.ToString.Length) & "-")
        Else
            SRLgTxtBx.AppendText(Space(9 - HcDeg.ToString.Length) & " ")
        End If

        If optCompact.Checked = True Then
            SRLgTxtBx.AppendText(Space(4 - HcDeg.ToString.Length) & Strings.Format(HcDeg, "0") & Chr(176) & Strings.Format(HcMin, "00") & "'")
        End If

        If optOriginal.Checked = True Then
            SRLgTxtBx.AppendText(Space(4 - HcDeg.ToString.Length) & Strings.Format(HcDeg, "0") & Chr(176) & Strings.Format(HcMin, "00.0") & "'")
        End If

        SRLgTxtBx.AppendText("   <- <- <- <- <- <- <- <- <- <- <- <- <- <- ")

        If optCompact.Checked = True Then
            SRLgTxtBx.AppendText("<- ")
        Else
            SRLgTxtBx.AppendText("   ")
        End If
        i = A6.ToString.Length
        If (A6 - Int(A6)) = 0 Then
            i = i + 2
        End If

        If A6 - Int(A6) <> 0 Then
            SRLgTxtBx.AppendText("A " & Space(9 - i) & Strings.Format(A6, "0.0"))
        End If

        If A6 - Int(A6) = 0 Then
            SRLgTxtBx.AppendText("A " & Space(9 - i) & Strings.Format(A6, "0"))
        End If
        i = B5.ToString.Length
        If (B5 - Int(B5)) = 0 Then
            i = i + 2
        End If
        If optOriginal.Checked = True And B5 < 1 Then i = 4
        'If (optCompact = True And B5 < 166) Or (optOriginal = True And B5 < 239) Then Print Tab(85); "B-"; Tab(97 - Str$(B5))); Format(B5, "0.0") Else _
        'Print Tab(85); "B-"; Tab(95 - Str$(B5))); Format(B5, "0")

        If (optCompact.Checked = True And B5 < 166) Or (optOriginal.Checked = True And B5 < 239) Then
            SRLgTxtBx.AppendText(Space(11) & "B-" & Space(9 - i))
            SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Underline)
            SRLgTxtBx.AppendText(Strings.Format(B5, "0.0"))
            SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Regular)
        Else
            SRLgTxtBx.AppendText(Space(11) & "B-" & Space(9 - i))
            SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Underline)
            SRLgTxtBx.AppendText(Strings.Format(B5, "0"))
            SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Regular)
        End If
        SRLgTxtBx.AppendText(vbNewLine)

        SRLgTxtBx.AppendText("Ho")

        If HoMin < 0 Then
            SRLgTxtBx.AppendText(Space(9 - HoDeg.ToString.Length) & "-")
        Else
            SRLgTxtBx.AppendText(Space(9 - HoDeg.ToString.Length) & " ")
        End If

        SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Underline)
        If optCompact.Checked = True Then
            SRLgTxtBx.AppendText(Space(4 - txtHoDeg.Text.ToString.Length) & Strings.Format(HoDeg, "0") & Chr(176) & Strings.Format(System.Math.Abs(HoMin), "00") & "'")
        End If

        If optOriginal.Checked = True Then
            SRLgTxtBx.AppendText(Space(4 - txtHoDeg.Text.ToString.Length) & Strings.Format(HoDeg, "0") & Chr(176) & Strings.Format(System.Math.Abs(HoMin), "00.0") & "'")
        End If
        SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Regular)

        If Ho > HcDecimal Then SRLgTxtBx.AppendText("    Observed greater - Toward")
        If Ho < HcDecimal Then SRLgTxtBx.AppendText("    Computed greater - Away")

        SRLgTxtBx.AppendText(vbNewLine)

        SRLgTxtBx.AppendText("a" & Space(15 - Int(System.Math.Abs(A)).ToString.Length))

        If optCompact.Checked = True Then
            SRLgTxtBx.AppendText(Strings.Format(Int(System.Math.Abs(A) + 0.5), "0") & " miles ")
            PlotOut.PlotIntercept = Strings.Format(Int(System.Math.Abs(A) + 0.5), "0") & " nm "
        End If

        If optOriginal.Checked = True Then
            SRLgTxtBx.AppendText(Strings.Format(Int(System.Math.Abs(A) * 10 + 0.5) / 10, "0.0") & " miles ")
            PlotOut.PlotIntercept = Strings.Format(Int(System.Math.Abs(A) * 10 + 0.5) / 10, "0.0") & " nm "
        End If

        If HcDecimal < Ho Then
            SRLgTxtBx.AppendText("T")
            PlotOut.PlotIntercept &= " Toward"
        End If

        If HcDecimal > Ho Then
            SRLgTxtBx.AppendText("A")
            PlotOut.PlotIntercept &= " Away"
        End If

        If HcDecimal = Ho Then
            SRLgTxtBx.AppendText(g_StrSpace)
            PlotOut.PlotIntercept &= " Toward"
        End If

        SRLgTxtBx.AppendText(Space(7) & "Zn " & Strings.Format(ZN, "000") & Chr(176) & " <- <- <- <- <- ")
        PlotOut.PlotAz = Strings.Format(ZN, "000") & Chr(176)

        If optCompact.Checked = True Then
            SRLgTxtBx.AppendText("Z " & cboL.Text & Space(1) & Strings.Format(ZDeg, "0") & Chr(176) & Strings.Format(ZMin, "00") & "'") 'Format(Z, "0"); Chr$(176); for whole degrees
        End If

        If optOriginal.Checked = True Then
            SRLgTxtBx.AppendText("Z " & cboL.Text & Space(1) & Strings.Format(ZDeg, "0") & Chr(176) & Strings.Format(ZMin, "00.0") & "'")
        End If

        If LHA <= 180 Then SRLgTxtBx.AppendText(" W" & "  <- <- <- <- ")

        If LHA > 180 Then SRLgTxtBx.AppendText(" E" & "  <- <- <- <- ")

        If optCompact.Checked = True Then
            SRLgTxtBx.AppendText("<-")
        Else
            SRLgTxtBx.AppendText("  ")
        End If
        i = A7.ToString.Length
        If (A7 - Int(A7)) = 0 Then
            i = i + 2
        End If

        If A7 - Int(A7) <> 0 Then
            SRLgTxtBx.AppendText("A " & Space(9 - i) & Strings.Format(A7, "0.0"))
        End If

        If A7 - Int(A7) = 0 Then
            SRLgTxtBx.AppendText("A " & Space(9 - i) & Strings.Format(A7, "0"))
        End If
        SRLgTxtBx.AppendText(vbNewLine)

        SRLgTxtBx.AppendText(Space(30) & "EP L " & Strings.Format(EstLDeg, "0") & Chr(176) & Strings.Format(EstLMin, "00.0") & "'")
        PlotOut.PlotSLEP = "EP L " & Strings.Format(EstLDeg, "0") & Chr(176) & Strings.Format(EstLMin, "00.0") & "'"
        If EstL > 0 Then
            SRLgTxtBx.AppendText(g_LatN)
            PlotOut.PlotSLEP &= g_LatN
            PlotOut.PlotLatNS = g_LatN
        End If
        If EstL = 0 Then
            SRLgTxtBx.AppendText(g_StrSpace)
            PlotOut.PlotSLEP &= g_LatN
            PlotOut.PlotLatNS = g_LatN
        End If
        If EstL < 0 Then
            SRLgTxtBx.AppendText(g_LatS)
            PlotOut.PlotSLEP &= g_LatS
            PlotOut.PlotLatNS = g_LatS
        End If

        SRLgTxtBx.AppendText("      EP Lo " & Strings.Format(EstLoDeg, "0") & Chr(176) & Strings.Format(EstLoMin, "00.0") & "'")
        PlotOut.PlotSLEP &= " EP Lo " & Strings.Format(EstLoDeg, "0") & Chr(176) & Strings.Format(EstLoMin, "00.0") & "'"
        If EstLo > 0 Then
            SRLgTxtBx.AppendText(g_LongW)
            PlotOut.PlotSLEP &= g_LongW
            PlotOut.PlotLongEW = g_LongW
        End If
        If EstLo = 0 Then
            SRLgTxtBx.AppendText(g_StrSpace)
            PlotOut.PlotSLEP &= g_LongW
            PlotOut.PlotLongEW = g_LongW
        End If
        If EstLo < 0 Then
            SRLgTxtBx.AppendText(g_LongE)
            PlotOut.PlotSLEP &= g_LongE
            PlotOut.PlotLongEW = g_LongE
        End If
        SRLgTxtBx.AppendText(vbNewLine)

        SRLgTxtBx.AppendText("*Table entry values")
        If k >= 82 And k <= 98 Then
            'Print Tab(23); "**An error of several miles can occur if K is between 82 and 98 degrees."

            SRLgTxtBx.AppendText(Space(23) & "**If K is between 82" & Chr(176) & " and 98" & Chr(176) & " this B is interpolated." & vbNewLine)

            SRLgTxtBx.AppendText(Space(25) & "USPS rule:  Discard the sight if K is between 82" & Chr(176) & " and 98" & Chr(176) & vbNewLine)

            SRLgTxtBx.AppendText(Space(36) & " or use Sadler Technique." & vbNewLine)
            chkSadler.Visible = True
        End If

        SRLgTxtBx.Refresh()
        SRHdrTxtBx.Refresh()


    End Sub

    Public Sub Display208()
        cmdSave.Visible = False
        cmdFix.Visible = False ': 
        cmdFix.Enabled = False
        cmdFix.Text = "Establish Fix"
        'Me.Font = New Font(Me.Font, "Courier New")

        SRHdrTxtBx.Clear()
        SRHdrTxtBx.Visible = True
        SRHdrTxtBx.BringToFront()

        SRLgTxtBx.Clear()
        SRLgTxtBx.Visible = True
        SRLgTxtBx.BringToFront()

        SRLeftTxtBx.Clear()
        SRLeftTxtBx.Visible = False
        SRLeftTxtBx.SendToBack()

        SRRightTxtBx.Clear()
        SRRightTxtBx.Visible = False
        SRRightTxtBx.SendToBack()

        NASRAsmTxtBx.Clear()
        NASRAsmTxtBx.Visible = False
        NASRAsmTxtBx.SendToBack()

        NASRAFTxtBx.Clear()
        NASRAFTxtBx.Visible = False
        NASRAFTxtBx.SendToBack()

        DCorrTxtBx.Clear()
        DCorrTxtBx.Visible = False
        DCorrTxtBx.SendToBack()

        WeemsPVTxtBx.Clear()            'V5.6.1
        WeemsPVTxtBx.Visible = False    'V5.6.1
        WeemsPVTxtBx.SendToBack()   'V5.6.1

        frameNASRUsing.Visible = False
        frame211.Visible = False
        frame214.Visible = False : Label9.Visible = False
        frameS.Visible = False
        GroupBoxPrecision.Visible = False      'V5.6.1
        chkInterpolateB.Visible = False

        AlignCenterRTB(SRHdrTxtBx)
        SRHdrTxtBx.AppendText("H.O. 208")

        SRLgTxtBx.AppendText("GHA" & Space(12 - txtGHADeg.Text.ToString.Length) & Strings.Format(Val(txtGHADeg.Text), "##0") & Chr(176) & Strings.Format(Val(txtGHAMin.Text), "00.0") & "'")
        SRLgTxtBx.AppendText(vbNewLine)

        SRLgTxtBx.AppendText("Asm Lo (")
        If AsmLo = 0 Then
            SignF = " "
            SRLgTxtBx.AppendText("")
        End If
        If System.Math.Sign(AsmLo) = 1 Then
            SRLgTxtBx.AppendText("-")
            SignF = g_LongW
        End If
        If System.Math.Sign(AsmLo) = -1 Then
            SRLgTxtBx.AppendText("+")
            SignF = g_LongE
        End If
        If System.Math.Sign(AsmLo) = 0 Then
            SRLgTxtBx.AppendText(g_StrSpace)
            SignF = " "
        End If

        SRLgTxtBx.AppendText(")" & Space(4 - AsmLoDeg.ToString.Length) & Strings.Format(AsmLoDeg, "0") & Chr(176) & Strings.Format(AsmLoMin, "00.0") & "'" & SignF)
        SRLgTxtBx.AppendText(vbNewLine)

        SRLgTxtBx.AppendText("Asm LHA" & Space(7 - AsmLHA.ToString.Length) & Strings.Format(AsmLHA, "0") & Chr(176))
        SRLgTxtBx.AppendText(vbNewLine)

        T = Int(T)
        SRLgTxtBx.AppendText("t" & Space(14 - T.ToString.Length) & Strings.Format(T, "0") & Chr(176))

        If LHA <= 180 Then SRLgTxtBx.AppendText(g_LongW)
        If LHA > 180 Then SRLgTxtBx.AppendText(g_LongE)

        SRLgTxtBx.AppendText(Space(8) & "d" & Space(4 - txtDecDeg.Text.ToString.Length) & Strings.Format(Val(txtDecDeg.Text), "0") _
                           & Chr(176) & Strings.Format(DecMinutes, "00.0") & "'" & cboDec.Text)
        SRLgTxtBx.AppendText(vbNewLine)

        AsmL = Int(AsmL)

        SRLgTxtBx.AppendText("Asm L " & Space(9 - AsmL.ToString.Length) & Strings.Format(System.Math.Abs(AsmL), "#0") & Chr(176) & cboL.Text)
        i = B1Deg.ToString.Length

        SRLgTxtBx.AppendText(Space(7) & "b" & Space(4 - i))
        SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Underline)
        SRLgTxtBx.AppendText(Strings.Format(B1Deg, "0") & Chr(176) & Strings.Format(B1Min, "00.0") & "'")
        SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Regular)
        SRLgTxtBx.AppendText(SignB)
        SRLgTxtBx.AppendText("   ->  ")

        SRLgTxtBx.AppendText("A" & Space(8 - A2.ToString.Length) & Strings.Format(A2, "0"))

        SRLgTxtBx.AppendText(Space(11) & "C" & Space(8 - A4.ToString.Length) & Strings.Format(A4, "0"))
        i = Z1.ToString.Length
        If (Z1 - Int(Z1)) = 0 Then
            i = i + 2
        End If

        SRLgTxtBx.AppendText(Space(11) & "Z'" & Space(7 - i) & Strings.Format(System.Math.Abs(Z1), "0.0") & Chr(176) & Space(1) & SignZ1)
        SRLgTxtBx.AppendText(vbNewLine)

        SRLgTxtBx.AppendText(Space(22) & "d+b" & Space(4 - A3Deg.ToString.Length) & Strings.Format(A3Deg, "0") & Chr(176) & Strings.Format(A3Min, "00.0") & "'" & SignA3)

        SRLgTxtBx.AppendText("  ->  ")

        i = B2.ToString.Length
        If (B2 - Int(B2)) = 0 Then
            i = i + 2
        End If

        SRLgTxtBx.AppendText("B" & Space(10 - i))
        SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Underline)
        SRLgTxtBx.AppendText(Strings.Format(B2, "0"))
        SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Regular)

        i = B3.ToString.Length
        If (B3 - Int(B3)) = 0 Then
            i = i + 2
        End If

        SRLgTxtBx.AppendText(Space(11) & "D" & Space(10 - i))
        SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Underline)
        SRLgTxtBx.AppendText(Strings.Format(B3, "0"))
        SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Regular)
        SRLgTxtBx.AppendText(vbNewLine)

        SRLgTxtBx.AppendText("Hc")

        If Hc < 0 Then
            SRLgTxtBx.AppendText(Space(10 - HcDeg.ToString.Length) & "-")
        Else
            SRLgTxtBx.AppendText(Space(10 - HcDeg.ToString.Length) & " ")
        End If

        SRLgTxtBx.AppendText(Space(4 - Strings.Format(HcDeg, "0").Length) & Strings.Format(HcDeg, "0") & Chr(176) & Strings.Format(HcMin, "00.0") & "'")

        SRLgTxtBx.AppendText(Space(10) & "<-")

        i = A5.ToString.Length
        If (A5 - Int(A5)) = 0 Then
            i = i + 2
        End If

        SRLgTxtBx.AppendText(Space(8) & "A+B" & Space(10 - i) & Strings.Format(A5, "0"))

        i = A6.ToString.Length
        If (A6 - Int(A6)) = 0 Then
            i = i + 2
        End If

        SRLgTxtBx.AppendText(Space(9) & "C+D" & Space(10 - i) & Strings.Format(A6, "0"))

        SRLgTxtBx.AppendText(Space(4) & "->")
        i = Z2.ToString.Length
        If (Z2 - Int(Z2)) = 0 Then
            i = i + 2
        End If

        SRLgTxtBx.AppendText(Space(5) & "Z""" & Space(7 - i))
        SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Underline)
        SRLgTxtBx.AppendText(Strings.Format(System.Math.Abs(Z2), "0.0") & Chr(176))
        SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Regular)
        'If Flag = True And cboL.text = "S" Then Print " N"
        'If Flag = True And cboL.text = "N" Then Print " S"
        'If Flag = False Then Print Spc(1); cboL.text

        SRLgTxtBx.AppendText(Space(1) & SignZ2)
        SRLgTxtBx.AppendText(vbNewLine)

        SRLgTxtBx.AppendText("Ho")

        If HoinMinutes < 0 Then
            SRLgTxtBx.AppendText(Space(11 - HoDeg.ToString.Length) & "-")
        Else
            SRLgTxtBx.AppendText(Space(11 - HoDeg.ToString.Length) & " ")
        End If

        SRLgTxtBx.AppendText(Space(4 - txtHoDeg.Text.ToString.Length))
        SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Underline)
        SRLgTxtBx.AppendText(Strings.Format(HoDeg, "0") & Chr(176) & Strings.Format(System.Math.Abs(HoMin), "00.0") & "'")
        SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Regular)

        i = Z.ToString.Length
        If (Z - Int(Z)) = 0 Then
            i = i + 2
        End If

        SRLgTxtBx.AppendText(Space(60) & "Z " & cboL.Text & Space(7 - i) & Strings.Format(Z, "0.0") & Chr(176))
        If LHA <= 180 Then SRLgTxtBx.AppendText(" W")
        If LHA > 180 Then SRLgTxtBx.AppendText(" E")
        SRLgTxtBx.AppendText(vbNewLine)

        SRLgTxtBx.AppendText("a" & Space(16 - Int(System.Math.Abs(A)).ToString.Length) & Strings.Format(Int(System.Math.Abs(A) * 10 + 0.5) / 10, "0.0") & " nm ")
        PlotOut.PlotIntercept = Strings.Format(Int(System.Math.Abs(A) * 10 + 0.5) / 10, "0.0") & " nm "

        If Hc < Ho Then
            SRLgTxtBx.AppendText("T     Observed greater - Toward")
            PlotOut.PlotIntercept &= " Toward"
        End If
        If Hc > Ho Then
            SRLgTxtBx.AppendText("A     Computed greater - Away  ")
            PlotOut.PlotIntercept &= " Away"
        End If

        SRLgTxtBx.AppendText(Space(23) & "Zn" & Space(4) & Strings.Format(ZN, "000") & Chr(176))
        PlotOut.PlotAz = Strings.Format(ZN, "000") & Chr(176)
        SRLgTxtBx.AppendText(vbNewLine)

        SRLgTxtBx.AppendText(vbNewLine)
        AlignCenterRTB(SRLgTxtBx)
        SRLgTxtBx.AppendText("AP/EP L " & Strings.Format(APEstLDeg, "0") & Chr(176) & Strings.Format(APEstLMin, "00.0") & "'")

        If APEstL > 0 Then SRLgTxtBx.AppendText(g_LatN)
        If APEstL = 0 Then SRLgTxtBx.AppendText(g_StrSpace)
        If APEstL < 0 Then SRLgTxtBx.AppendText(g_LatS)

        SRLgTxtBx.AppendText("   AP/EP Lo " & Strings.Format(APEstLoDeg, "0") & Chr(176) & Strings.Format(APEstLoMin, "00.0") & "'")
        If APEstLo > 0 Then SRLgTxtBx.AppendText(g_LongW)
        If APEstLo = 0 Then SRLgTxtBx.AppendText(g_StrSpace)
        If APEstLo < 0 Then SRLgTxtBx.AppendText(g_LongE)
        SRLgTxtBx.AppendText(vbNewLine)

        SRLgTxtBx.AppendText("DR-LOP Distance " & Strings.Format(System.Math.Abs(KPLOPDist), "0.0") & " nm ")
        If KPLOPDist < 0 Then SRLgTxtBx.AppendText("T")
        If KPLOPDist > 0 Then SRLgTxtBx.AppendText("A")
        If KPLOPDist = 0 Then SRLgTxtBx.AppendText(g_StrSpace)
        SRLgTxtBx.AppendText(vbNewLine)

        SRLgTxtBx.AppendText("   EP L " & Strings.Format(EstLDeg, "0") & Chr(176) & Strings.Format(EstLMin, "00.0") & "'")

        SRLgTxtBx.AppendText("      EP Lo " & Strings.Format(EstLoDeg, "0") & Chr(176) & Strings.Format(EstLoMin, "00.0") & "'")

        SRLgTxtBx.AppendText(vbNewLine)

        SRLgTxtBx.Refresh()
        SRHdrTxtBx.Refresh()


    End Sub

    Public Function Csc211(ByRef x As Double) As Single
        Dim LclCsc211 As Single = 0
        If x < 0 Or x > 180 Then
            x = 360 - x
        End If
        LclCsc211 = 100000 * (System.Math.Log(1 / System.Math.Sin(x * Pi / 180)) / System.Math.Log(10))
        If (optCompact.Checked = True And Csc211 < 166) Or (optOriginal.Checked = True And Csc211 < 239) Then
            LclCsc211 = Int(LclCsc211 * 10 + 0.5) / 10
        Else
            LclCsc211 = Int(LclCsc211 + 0.5)
        End If
        Return LclCsc211
        Exit Function
    End Function

    Public Function Sec211(ByRef x As Double) As Single
        Dim LclSec211 As Single = 0
        If x >= 90 And x <= 270 Then
            x = x - 180
        End If
        LclSec211 = 100000 * (System.Math.Log(1 / System.Math.Cos(x * Pi / 180)) / System.Math.Log(10))
        If (optCompact.Checked = True And Sec211 < 166) Or (optOriginal.Checked = True And Sec211 < 239) Then
            LclSec211 = Int(LclSec211 * 10 + 0.5) / 10
        Else
            LclSec211 = Int(LclSec211 + 0.5)
        End If
        Return LclSec211
        Exit Function
    End Function
    Public Function CscS(ByRef x As Double) As Single
        Dim LclCscS As Single = 0
        If x > 180 Or x < 0 Then
            x = 360 - x
        End If
        If optPepperday.Checked = True And x = 0 Then
            LclCscS = 999.999
            Return LclCscS
            Exit Function
        End If
        If optFarley.Checked = True And x = 0 Then
            LclCscS = 1000
            Return LclCscS
            Exit Function
        End If
        LclCscS = (System.Math.Log(1 / System.Math.Sin(x * Pi / 180)) / System.Math.Log(10))
        If optPepperday.Checked = True Then
            LclCscS = 94.2932531 * LclCscS
        End If
        If optFarley.Checked = True Then
            LclCscS = 100 * LclCscS
        End If
        Return LclCscS
        Exit Function
    End Function
    Public Function SecS(ByRef x As Double) As Single
        Dim LclSecS As Single = 0
        If x >= 90 And x <= 270 Then
            x = x - 180
        End If
        LclSecS = (System.Math.Log(1 / System.Math.Cos(x * Pi / 180)) / System.Math.Log(10))
        If optPepperday.Checked = True Then
            LclSecS = 94.2932531 * LclSecS
        End If
        If optFarley.Checked = True Then
            LclSecS = 100 * LclSecS
        End If
        Return LclSecS
        Exit Function
    End Function
    Public Sub Display214()
        cmdSave.Visible = False
        cmdFix.Visible = False ': 
        cmdFix.Enabled = False
        cmdFix.Text = "Establish Fix"
        'Me.Font = New Font(Me.Font, "Courier New")
        SRHdrTxtBx.Clear()
        SRHdrTxtBx.Visible = True
        SRHdrTxtBx.BringToFront()

        SRLgTxtBx.Clear()
        SRLgTxtBx.Visible = True
        SRLgTxtBx.BringToFront()

        SRLeftTxtBx.Clear()
        SRLeftTxtBx.Visible = False
        SRLeftTxtBx.SendToBack()

        SRRightTxtBx.Clear()
        SRRightTxtBx.Visible = False
        SRRightTxtBx.SendToBack()

        NASRAsmTxtBx.Clear()
        NASRAsmTxtBx.Visible = False
        NASRAsmTxtBx.SendToBack()

        NASRAFTxtBx.Clear()
        NASRAFTxtBx.Visible = False
        NASRAFTxtBx.SendToBack()

        DCorrTxtBx.Clear()
        DCorrTxtBx.Visible = False
        DCorrTxtBx.SendToBack()

        WeemsPVTxtBx.Clear()            'V5.6.1
        WeemsPVTxtBx.Visible = False    'V5.6.1
        WeemsPVTxtBx.SendToBack()   'V5.6.1

        frameNASRUsing.Visible = False
        frame211.Visible = False
        frame214.Visible = True
        Label9.Visible = True
        frameS.Visible = False
        GroupBoxPrecision.Visible = False      'V5.6.1
        chkInterpolateB.Visible = False

        AlignCenterRTB(SRHdrTxtBx)
        SRHdrTxtBx.AppendText("H.O. 214")

        If optd.Checked = True Then
            SRLgTxtBx.AppendText("Calc. of Asm Lo and LHA")
        End If

        If optdt.Checked = True Or optdtL.Checked = True Then
            SRLgTxtBx.AppendText("   Calc. of Asm LHA")
        End If
        SRLgTxtBx.AppendText(vbNewLine)

        SRLgTxtBx.AppendText("Tot GHA" & Space(9 - txtGHADeg.Text.ToString.Length) & Strings.Format(Val(txtGHADeg.Text), "##0") _
                           & Chr(176) & Strings.Format(Val(txtGHAMin.Text), "00.0") & "'")
        SRLgTxtBx.AppendText(vbNewLine)

        If optd.Checked = True Then
            SRLgTxtBx.AppendText("Asm Lo (")
            If AsmLo = 0 Then
                SignA3 = " "
                SRLgTxtBx.AppendText("")
            End If
            If System.Math.Sign(AsmLo) = 1 Then
                SRLgTxtBx.AppendText("-")
                SignA3 = g_LongW
            End If
            If System.Math.Sign(AsmLo) = -1 Then
                SRLgTxtBx.AppendText("+")
                SignA3 = g_LongE
            End If
            If System.Math.Sign(AsmLo) = 0 Then
                SRLgTxtBx.AppendText(g_StrSpace)
                SignA3 = " "
            End If
        End If
        If optdt.Checked = True Or optdtL.Checked = True Then
            SRLgTxtBx.AppendText("DR Lo  (")
            If cboLo.Text = "W" Then SRLgTxtBx.AppendText("-")
            If cboLo.Text = "E" Then SRLgTxtBx.AppendText("+")
        End If

        If optd.Checked = True Then
            SRLgTxtBx.AppendText(")" & Space(6 - AsmLoDeg.ToString.Length) & Strings.Format(AsmLoDeg, "0") _
                                                       & Chr(176) & Strings.Format(AsmLoMin, "00.0") & "'" & SignA3)
        End If

        If optdt.Checked = True Or optdtL.Checked = True Then
            SRLgTxtBx.AppendText(")" & Space(6 - txtLoDeg.Text.ToString.Length) & Strings.Format(Val(txtLoDeg.Text), "0") _
                               & Chr(176) & Strings.Format(Val(txtLoMin.Text), "00.0") & "'" & cboLo.Text)
        End If


        SRLgTxtBx.AppendText(vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab)
        SRLgTxtBx.AppendText(" DEC and LAT ")
        SRLgTxtBx.AppendText(vbNewLine)


        If optd.Checked = True Then
            SRLgTxtBx.AppendText("H.A." & Space(12 - T.ToString.Length) & Strings.Format(T, "0") & Chr(176))
            If LHA <= 180 Then SRLgTxtBx.AppendText(g_LongW)
            If LHA > 180 Then SRLgTxtBx.AppendText(g_LongE)
        End If
        If optdt.Checked = True Or optdtL.Checked = True Then
            SRLgTxtBx.AppendText("LHA" & Space(13 - LHADeg.ToString.Length) & Strings.Format(LHADeg, "#0") & Chr(176) _
                               & Strings.Format(LHAMin, "00.0") & "'->" & "H.A. " & Strings.Format(T, "0") & Chr(176))
        End If

        SRLgTxtBx.AppendText(Space(11) & "Dec" & Space(4 - AsmDecDeg.ToString.Length) & Strings.Format(AsmDecDeg, "#0") & Chr(176) & Strings.Format(AsmDecMin, "00") & "'" & cboDec.Text)

        SRLgTxtBx.AppendText(Space(13) & "Asm L " & Space(4 - Strings.Format(AsmL.ToString, "#0").Length) & Strings.Format(System.Math.Abs(AsmL), "#0") & Chr(176))

        If AsmL = 0 Then SRLgTxtBx.AppendText(g_StrSpace)
        If AsmL <> 0 Then SRLgTxtBx.AppendText(cboL.Text)

        SRLgTxtBx.AppendText(vbTab & vbTab)
        If cboL.Text = cboDec.Text Then
            SRLgTxtBx.AppendText("SAME NAME    ")
        End If
        If cboL.Text <> cboDec.Text Then
            SRLgTxtBx.AppendText("CONTRARY NAME")
        End If
        SRLgTxtBx.AppendText(vbNewLine)

        SRLgTxtBx.AppendText("Tab Alt. ")
        If System.Math.Sign(Hc) = -1 Then
            SRLgTxtBx.AppendText(Space(1) & "-")
        Else
            SRLgTxtBx.AppendText(Space(1) & " ")
        End If

        SRLgTxtBx.AppendText(Space(4 - System.Math.Abs(TabHcDeg).ToString.Length) & Strings.Format(System.Math.Abs(TabHcDeg), "0") _
                           & Chr(176) & Strings.Format(System.Math.Abs(TabHcMin), "00.0") & "'")
        SRLgTxtBx.AppendText(Space(8) & "Dec diff " & Strings.Format(System.Math.Abs(DecIncr), "00.0") & "'")
        SRLgTxtBx.AppendText(Space(3))

        SRLgTxtBx.SelectionFont = New Font("Symbol", 8, FontStyle.Regular)
        SRLgTxtBx.AppendText("D") 'this prints a Greek capital delta
        SRLgTxtBx.SelectionFont = New Font("Courier New", 8, FontStyle.Regular)
        SRLgTxtBx.AppendText("d " & Strings.Format(System.Math.Abs(D * 100), "00"))
        SRLgTxtBx.AppendText(Space(4))
        SRLgTxtBx.SelectionFont = New Font("Symbol", 8, FontStyle.Regular)
        SRLgTxtBx.AppendText("D") 'this prints a Greek capital delta
        SRLgTxtBx.SelectionFont = New Font("Courier New", 8, FontStyle.Regular)
        SRLgTxtBx.AppendText("d corr." & Space(1) & "(" & SignD & ") " & Space(5 - Strings.Format(d1corr.ToString, "0.0").Length) & Strings.Format(System.Math.Abs(d1corr), "0.0") & "'")
        SRLgTxtBx.AppendText(Space(3) & "Tab Az. " & Space(5 - Strings.Format(TabZ.ToString, "0.0").Length) & Strings.Format(TabZ, "0.0") & Chr(176))
        SRLgTxtBx.AppendText(vbNewLine)

        SRLgTxtBx.AppendText("Tot corr" & " (" & SignTotcorr & ") " & Space(6 - Strings.Format(Totcorr.ToString, "0.0").Length) & Strings.Format(System.Math.Abs(Totcorr), "0.0") & "'")
        If optdt.Checked = True Or optdtL.Checked = True Then
            SRLgTxtBx.AppendText(Space(11) & "LHA diff " & Strings.Format(LHAdiff, "00.0") & "'")
        End If
        If optdt.Checked = True Or optdtL.Checked = True Then
            SRLgTxtBx.AppendText(Space(3))
            SRLgTxtBx.SelectionFont = New Font("Symbol", 8, FontStyle.Regular)
            SRLgTxtBx.AppendText("D") 'this prints a Greek capital delta
            SRLgTxtBx.SelectionFont = New Font("Courier New", 8, FontStyle.Regular)
            SRLgTxtBx.AppendText("t " & Strings.Format(System.Math.Abs(DSD2 * 100), "00"))
        End If
        If optdt.Checked = True Or optdtL.Checked = True Then
            i = 73
            If System.Math.Abs(d2corr) < 10 Then i = 74
            SRLgTxtBx.AppendText(Space(3))
            SRLgTxtBx.SelectionFont = New Font("Symbol", 8, FontStyle.Regular)
            SRLgTxtBx.AppendText("D") 'this prints a Greek capital delta
            SRLgTxtBx.SelectionFont = New Font("Courier New", 8, FontStyle.Regular)
            SRLgTxtBx.AppendText("t corr." & Space(1) & "(" & Signd2corr & ") " & Space(5 - Strings.Format(d2corr.ToString, "0.0").ToString) & Strings.Format(System.Math.Abs(d2corr), "0.0") & "'")
        End If
        SRLgTxtBx.AppendText(vbNewLine)

        SRLgTxtBx.AppendText("Hc ")
        If System.Math.Sign(TotHc) = -1 Then
            SRLgTxtBx.AppendText(Space(7) & "-")
        Else
            SRLgTxtBx.AppendText(Space(7) & " ")
        End If

        SRLgTxtBx.AppendText(Space(4 - System.Math.Abs(TotHcDeg).ToString.Length) & Strings.Format(System.Math.Abs(TotHcDeg), "0") & Chr(176) _
                           & Strings.Format(System.Math.Abs(TotHcMin), "00.0") & "'")

        If optdtL.Checked = True Then
            SRLgTxtBx.AppendText(Space(11) & "L diff   " & Strings.Format(Ldiff, "00.0") & "'")
        End If
        If optdtL.Checked = True Then
            SRLgTxtBx.AppendText(Space(3))
            SRLgTxtBx.SelectionFont = New Font("Symbol", 8, FontStyle.Regular)
            SRLgTxtBx.AppendText("D") 'this prints a Greek capital delta
            SRLgTxtBx.SelectionFont = New Font("Courier New", 8, FontStyle.Regular)
            SRLgTxtBx.AppendText("L corr." & Space(1) & "(" & SignL & ") " & Space(5 - Strings.Format(Zcorr.ToString, "0.0").Length) & Strings.Format(System.Math.Abs(Zcorr), "0.0") & "'")
            SRLgTxtBx.AppendText(vbTab & vbTab & vbTab & vbTab & vbTab & vbTab)
        Else
            SRLgTxtBx.AppendText(vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab)
        End If

        'SRLgTxtBx.AppendText(vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab)
        SRLgTxtBx.AppendText("Z " & cboL.Text & Space(5 - Strings.Format(Ztot.ToString, "0.0").Length) & Strings.Format(System.Math.Abs(Ztot), "0.0") & Chr(176))
        If LHA <= 180 Then SRLgTxtBx.AppendText(" W")
        If LHA > 180 Then SRLgTxtBx.AppendText(" E")
        SRLgTxtBx.AppendText(vbNewLine)

        SRLgTxtBx.AppendText("Ho ")
        If HoinMinutes < 0 Then
            SRLgTxtBx.AppendText(Space(7) & "-")
        Else
            SRLgTxtBx.AppendText(Space(7) & " ")
        End If

        SRLgTxtBx.AppendText(Space(4 - HoDeg.ToString.Length) & Strings.Format(System.Math.Abs(HoDeg), "0") & Chr(176) & Strings.Format(System.Math.Abs(HoMin), "00.0") & "'")
        SRLgTxtBx.AppendText(Space(34) & "Tot corr" & Space(1) & "(" & SignTotcorr & ") " & Space(5 - Strings.Format(Totcorr.ToString, "0.0").Length) & Strings.Format(System.Math.Abs(Totcorr), "0.0") & "'")
        SRLgTxtBx.AppendText(vbNewLine)

        SRLgTxtBx.AppendText(Space(13) & "a " & Space(7 - Int(System.Math.Abs(A)).ToString.Length) & Strings.Format((Int(System.Math.Abs(A) * 10 + 0.5)) / 10, "0.0") & " miles ")
        PlotOut.PlotIntercept = Strings.Format((Int(System.Math.Abs(A) * 10 + 0.5)) / 10, "0.0") & " nm "
        If A < 0 Then
            SRLgTxtBx.AppendText("T  Observed greater - Toward")
            PlotOut.PlotIntercept &= " Toward"
        End If
        If A > 0 Then
            SRLgTxtBx.AppendText("A  Computed greater - Away")
            PlotOut.PlotIntercept &= " Away"
        End If
        SRLgTxtBx.AppendText(vbTab & vbTab & vbTab)
        SRLgTxtBx.AppendText("Zn    " & Strings.Format(ZN, "000") & Chr(176))
        PlotOut.PlotAz = Strings.Format(ZN, "000") & Chr(176)
        SRLgTxtBx.AppendText(vbNewLine)

        AlignCenterRTB(SRLgTxtBx)
        If optd.Checked = True Then
            SRLgTxtBx.AppendText("Plot LOP from Asm L, Asm Lo")
        End If
        If optdt.Checked = True Then
            SRLgTxtBx.AppendText("Plot LOP from Asm L, DR Lo")
        End If
        If optdtL.Checked = True Then
            SRLgTxtBx.AppendText("Plot LOP from DR L, DR Lo")
        End If
        SRLgTxtBx.AppendText(vbNewLine)
        SRLgTxtBx.AppendText(vbNewLine)

        'AlignLeftRTB(SRLgTxtBx)

        If optdtL.Checked = False Then
            SRLgTxtBx.AppendText("AP/EP L " & Strings.Format(APEstLDeg, "0") & Chr(176) & Strings.Format(APEstLMin, "00.0") & "'")
            If APEstL > 0 Then
                SRLgTxtBx.AppendText(g_LatN)
            End If
            If APEstL = 0 Then
                SRLgTxtBx.AppendText(g_StrSpace)
            End If
            If APEstL < 0 Then
                SRLgTxtBx.AppendText(g_LatS)
            End If
            SRLgTxtBx.AppendText("   AP/EP Lo " & Strings.Format(APEstLoDeg, "0") & Chr(176) & Strings.Format(APEstLoMin, "00.0") & "'")
            If APEstLo > 0 Then
                SRLgTxtBx.AppendText(g_LongW)
            End If
            If APEstLo = 0 Then
                SRLgTxtBx.AppendText(g_StrSpace)
            End If
            If APEstLo < 0 Then
                SRLgTxtBx.AppendText(g_LongE)
            End If
            SRLgTxtBx.AppendText(vbNewLine)

            SRLgTxtBx.AppendText("DR-LOP Distance " & Strings.Format(System.Math.Abs(KPLOPDist), "0.0") & " nm ")
            If KPLOPDist < 0 Then SRLgTxtBx.AppendText("T")
            If KPLOPDist > 0 Then SRLgTxtBx.AppendText("A")
            If KPLOPDist = 0 Then SRLgTxtBx.AppendText(g_StrSpace)
            SRLgTxtBx.AppendText(vbNewLine)

        End If

        SRLgTxtBx.AppendText("   EP L " & Strings.Format(EstLDeg, "0") & Chr(176) & Strings.Format(EstLMin, "00.0") & "'")

        SRLgTxtBx.AppendText("      EP Lo " & Strings.Format(EstLoDeg, "0") & Chr(176) & Strings.Format(EstLoMin, "00.0") & "'")

        SRLgTxtBx.AppendText(vbNewLine)
        SRLgTxtBx.Refresh()

    End Sub

    Public Sub HO214()
        LHA = GHA - Lo
        If LHA >= 360 Then LHA = LHA - 360
        If LHA < 0 Then LHA = LHA + 360
        If LHA <= 180 Then T = LHA 'W           'T is H.A.
        If LHA > 180 Then T = 360 - LHA 'E
        'tDeg = Int(T)
        'tMin = (T - tDeg) * 60
        'tMin = Int(tMin + 0.50000001)
        T = Int(T + 0.5)
        AsmLHA = Int(LHA + 0.5)
        If AsmLHA = 360 Then AsmLHA = 0
        GHAAsmDeg = Val(txtGHADeg.Text)
        GHAAsmMin = Val(txtGHAMin.Text)
        GHAAsm = GHAAsmDeg + GHAAsmMin / 60 'in degrees
        'If Lo >= 0 Then AsmLo = GHAAsm - AsmLHA Else AsmLo = -(AsmLHA - GHAAsm) 'AsmLoDeg = Val(txtLoDeg.Text)
        AsmLo = GHAAsm - AsmLHA
        'If AsmLo >= 360 Then AsmLo = AsmLo - 360
        If System.Math.Abs(AsmLo) < 180 Then AsmLo = 360 - System.Math.Abs(AsmLo)
        If System.Math.Abs(AsmLo) >= 180 And Lo >= 0 Then AsmLo = 360 - System.Math.Abs(AsmLo)
        If System.Math.Abs(AsmLo) >= 180 And Lo < 0 Then AsmLo = -(360 - System.Math.Abs(AsmLo))
        '    If Abs(AsmLo) >= 180 Then AsmLo = -(360 - Abs(AsmLo))
        '    If AsmLo < 0 And Lo >= 0 Then AsmLo = AsmLo + 360
        AsmLoDeg = Int(System.Math.Abs(AsmLo))
        If AsmLo > 0 Or txtLoDeg.Text = "180" Then AsmLoMin = Val(txtGHAMin.Text) Else AsmLoMin = 60 - Val(txtGHAMin.Text)
        If AsmLoMin = 60 Then AsmLoMin = 0
        AsmL = Int(L + 0.5)
        AsmDec = Int(System.Math.Abs(Dec) * 2 + 0.5) / 2
        If System.Math.Abs(Dec) > 29.5 And System.Math.Abs(Dec) < 31 Then AsmDec = 30
        If System.Math.Abs(Dec) >= 31 And System.Math.Abs(Dec) < 33 Then AsmDec = 32
        If System.Math.Abs(Dec) >= 33 And System.Math.Abs(Dec) < 34.25 Then AsmDec = 34
        If System.Math.Abs(Dec) >= 34.25 And System.Math.Abs(Dec) < 35 Then AsmDec = 34.5
        If System.Math.Abs(Dec) >= 35 And System.Math.Abs(Dec) < 35.75 Then AsmDec = 35.5
        If System.Math.Abs(Dec) >= 35.5 And System.Math.Abs(Dec) < 36.5 Then AsmDec = 36
        If System.Math.Abs(Dec) >= 36 And System.Math.Abs(Dec) < 37.75 Then AsmDec = 37
        If System.Math.Abs(Dec) >= 37.75 And System.Math.Abs(Dec) < 39.25 Then AsmDec = 38.5
        If System.Math.Abs(Dec) >= 39.25 And System.Math.Abs(Dec) < 41 Then AsmDec = 40
        If System.Math.Abs(Dec) >= 41 And System.Math.Abs(Dec) < 42.25 Then AsmDec = 42
        If System.Math.Abs(Dec) >= 42.25 And System.Math.Abs(Dec) < 44 Then AsmDec = 43
        If System.Math.Abs(Dec) >= 44 And System.Math.Abs(Dec) < 45.5 Then AsmDec = 45
        If System.Math.Abs(Dec) >= 45.5 And System.Math.Abs(Dec) < 46.5 Then AsmDec = 46
        If System.Math.Abs(Dec) >= 46.5 And System.Math.Abs(Dec) < 47.75 Then AsmDec = 47
        If System.Math.Abs(Dec) >= 47.75 And System.Math.Abs(Dec) < 49 Then AsmDec = 48.5
        If System.Math.Abs(Dec) >= 49 And System.Math.Abs(Dec) < 50 Then AsmDec = 49.5
        If System.Math.Abs(Dec) >= 50 And System.Math.Abs(Dec) < 51 Then AsmDec = 50.5
        If System.Math.Abs(Dec) >= 51 And System.Math.Abs(Dec) < 52 Then AsmDec = 51.5
        If System.Math.Abs(Dec) >= 52 And System.Math.Abs(Dec) < 53.25 Then AsmDec = 52.5
        If System.Math.Abs(Dec) >= 53.25 And System.Math.Abs(Dec) < 54.25 Then AsmDec = 54
        If System.Math.Abs(Dec) >= 54.25 And System.Math.Abs(Dec) < 54.75 Then AsmDec = 54.5
        If System.Math.Abs(Dec) >= 54.75 And System.Math.Abs(Dec) < 55.5 Then AsmDec = 55
        If System.Math.Abs(Dec) >= 55.5 And System.Math.Abs(Dec) < 56.25 Then AsmDec = 56
        If System.Math.Abs(Dec) >= 56.25 And System.Math.Abs(Dec) < 56.75 Then AsmDec = 56.5
        If System.Math.Abs(Dec) >= 56.75 And System.Math.Abs(Dec) < 57.25 Then AsmDec = 57
        If System.Math.Abs(Dec) >= 57.25 And System.Math.Abs(Dec) < 58.25 Then AsmDec = 57.5
        If System.Math.Abs(Dec) >= 58.25 And System.Math.Abs(Dec) < 59.25 Then AsmDec = 59
        If System.Math.Abs(Dec) >= 59.25 And System.Math.Abs(Dec) < 59.75 Then AsmDec = 59.5
        If System.Math.Abs(Dec) >= 59.75 And System.Math.Abs(Dec) < 60.25 Then AsmDec = 60
        If System.Math.Abs(Dec) >= 60.25 And System.Math.Abs(Dec) < 61.25 Then AsmDec = 60.5
        If System.Math.Abs(Dec) >= 61.25 And System.Math.Abs(Dec) < 62.25 Then AsmDec = 62
        If System.Math.Abs(Dec) >= 62.25 And System.Math.Abs(Dec) < 62.75 Then AsmDec = 62.5
        If System.Math.Abs(Dec) >= 62.75 And System.Math.Abs(Dec) < 66 Then AsmDec = 63
        If System.Math.Abs(Dec) >= 66 And System.Math.Abs(Dec) < 69.25 Then AsmDec = 69
        If System.Math.Abs(Dec) >= 69.25 And System.Math.Abs(Dec) < 72 Then AsmDec = 69.5
        If System.Math.Abs(Dec) >= 72 Then AsmDec = 74.5

        AsmDecDeg = Int(AsmDec)
        AsmDecMin = (AsmDec - AsmDecDeg) * 60
        DecIncr = (System.Math.Abs(Dec) - AsmDec) * 60 'this is really Dec diff for HO214
        DecIncr = Int(DecIncr * 10 + 0.5) / 10
        LHAdiff = System.Math.Abs((LHA - AsmLHA) * 60)
        Ldiff = System.Math.Abs((L - AsmL) * 60)
        Ldiff = Int(Ldiff * 10 + 0.5) / 10

        If (cboDec.Text = "S" And cboL.Text = "N") Or (cboDec.Text = "N" And cboL.Text = "S") Then AsmDec = -AsmDec : DE = -DE ': SignDE$ = "-" 'sign of Dec was already set in DecimalDegrees

        'Hc is altitude for Asm L, Asm Dec, Asm LHA
        Hc = System.Math.Cos(AsmLHA * Pi / 180) * System.Math.Cos(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Cos(AsmDec * Pi / 180) + System.Math.Sin(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Sin(AsmDec * Pi / 180)
        If System.Math.Abs(Hc) >= 1 Then Hc = System.Math.Sign(Hc) * Pi / 2 Else Hc = System.Math.Atan(Hc / System.Math.Sqrt(-Hc * Hc + 1)) 'arcsine
        Hc = Hc * 180 / Pi
        TabHcDeg = Fix(Hc) 'was Int
        TabHcMin = Hc - TabHcDeg
        TabHcMin = Int((60 * TabHcMin) * 10 + 0.5) / 10

        'The next group is for determining delta d

        i = 1 : If AsmDec < 0 Then i = -1
        NextHcdP = System.Math.Cos(AsmLHA * Pi / 180) * System.Math.Cos(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Cos((AsmDec + i / 60) * Pi / 180) + System.Math.Sin(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Sin((AsmDec + i / 60) * Pi / 180)
        If System.Math.Abs(NextHcdP) >= 1 Then NextHcdP = System.Math.Sign(NextHcdP) * Pi / 2 Else NextHcdP = System.Math.Atan(NextHcdP / System.Math.Sqrt(-NextHcdP * NextHcdP + 1)) 'arcsine
        NextHcdP = NextHcdP * 180 / Pi

        i = -1 : If AsmDec < 0 Then i = 1
        NextHcdM = System.Math.Cos(AsmLHA * Pi / 180) * System.Math.Cos(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Cos((AsmDec + i / 60) * Pi / 180) + System.Math.Sin(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Sin((AsmDec + i / 60) * Pi / 180)
        If System.Math.Abs(NextHcdM) >= 1 Then NextHcdM = System.Math.Sign(NextHcdM) * Pi / 2 Else NextHcdM = System.Math.Atan(NextHcdM / System.Math.Sqrt(-NextHcdM * NextHcdM + 1)) 'arcsine
        NextHcdM = NextHcdM * 180 / Pi

        'NextHcDSD1 is altitude for Asm L, Asm LHA, actual Dec
        NextHcDSD1 = System.Math.Cos(AsmLHA * Pi / 180) * System.Math.Cos(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Cos(DE * Pi / 180) + System.Math.Sin(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Sin(DE * Pi / 180)
        If System.Math.Abs(NextHcDSD1) >= 1 Then NextHcDSD1 = System.Math.Sign(NextHcDSD1) * Pi / 2 Else NextHcDSD1 = System.Math.Atan(NextHcDSD1 / System.Math.Sqrt(-NextHcDSD1 * NextHcDSD1 + 1)) 'arcsine
        NextHcDSD1 = NextHcDSD1 * 180 / Pi

        D = ((NextHcdP - NextHcdM) / (2 / 60)) 'D is delta d, d1corr is delta d corr
        D = Int(System.Math.Abs(D) * 100 + 0.5) / 100
        SignD = "+" ': If Sgn(D) = -1 Then SignD$ = "-"
        'd1corr = Abs(DecIncr * D)                                                  'This is the the mathematically correct delta d corr
        i = 0 : d1corr = 0 : If System.Math.Abs(DecIncr) > 30.9 Then i = 30 'This and next lines emulate multiplication table.  This lineif DecDiff >30.9'
        d1corr = Int(i * D * 10 + 0.50001) / 10 'This line for units of DecDiff from 1' to 30'
        d1corr = d1corr + Int(Int(System.Math.Abs(DecIncr) - i) * D * 10 + 0.50001) / 10 'This line for tenths of DecDiff
        d1corr = d1corr + Int((System.Math.Abs(DecIncr) - Int(System.Math.Abs(DecIncr))) * D * 10 + 0.5) / 10
        d1corr = Int(d1corr * 10 + 0.5) / 10
        If Hc > NextHcDSD1 Then d1corr = -d1corr : SignD = "-"

        'the next group is for determining delta t
        i = 1 : If LHA > 180 Then i = -1 'this seems to help
        NextHctP = System.Math.Cos((AsmLHA + i) * Pi / 180) * System.Math.Cos(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Cos(AsmDec * Pi / 180) + System.Math.Sin(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Sin(AsmDec * Pi / 180)
        If System.Math.Abs(NextHctP) >= 1 Then NextHctP = System.Math.Sign(NextHctP) * Pi / 2 Else NextHctP = System.Math.Atan(NextHctP / System.Math.Sqrt(-NextHctP * NextHctP + 1)) 'arcsine
        NextHctP = NextHctP * 180 / Pi

        NextHcDSD2 = System.Math.Cos(LHA * Pi / 180) * System.Math.Cos(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Cos((AsmDec) * Pi / 180) + System.Math.Sin(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Sin((AsmDec) * Pi / 180)
        If System.Math.Abs(NextHcDSD2) >= 1 Then NextHcDSD2 = System.Math.Sign(NextHcDSD2) * Pi / 2 Else NextHcDSD2 = System.Math.Atan(NextHcDSD2 / System.Math.Sqrt(-NextHcDSD2 * NextHcDSD2 + 1)) 'arcsine
        NextHcDSD2 = NextHcDSD2 * 180 / Pi

        DSD2 = 0 : d2corr = 0 'd2corr is delta t corr
        If optdt.Checked = True Or optdtL.Checked = True Then
            DSD2 = (NextHctP - Hc) 'this is delta t
            DSD2 = Int(System.Math.Abs(DSD2) * 100 + 0.5) / 100
            Signd2corr = "+" ': If Sgn(DSD2) = -1 Then Signd2corr$ = "-"
            'd2corr = 0: If optdt.Value = True Or optdtL.Value = True Then d2corr = Abs(LHAdiff * DSD2)     'this is the mathematically correct delta t corr
            If optdt.Checked = True Or optdtL.Checked = True Then
                d2corr = Int(Int(System.Math.Abs(LHAdiff)) * DSD2 * 10 + 0.5) / 10 'this and next line emulate multiplication table
                d2corr = d2corr + Int((System.Math.Abs(LHAdiff) - Int(System.Math.Abs(LHAdiff))) * DSD2 * 10 + 0.5) / 10
            End If
            d2corr = Int(d2corr * 10 + 0.5) / 10
            If Hc > NextHcDSD2 Then d2corr = -d2corr : Signd2corr = "-"
        End If


        L4 = System.Math.Sin(AsmDec * Pi / 180)
        L5 = System.Math.Sin(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Sin(Hc * Pi / 180)
        L6 = L4 - L5
        L7 = System.Math.Cos(System.Math.Abs(AsmL) * Pi / 180) * System.Math.Cos(Hc * Pi / 180)
        L8 = L6 / L7
        'If Abs(L8) - 1 < 0.000000000001 Then L8 = 0
        If System.Math.Abs(L8) >= 1 Then Z = Pi Else Z = System.Math.Atan(-L8 / System.Math.Sqrt(-L8 * L8 + 1)) + Pi / 2 'arccosine
        Z = Z * 180 / Pi
        TabZ = Int(Z * 10 + 0.5) / 10

        Ztot = TabZ

        'If L > 0 And LHA > 180 Then ZN = Ztot
        'If L > 0 And LHA <= 180 Then ZN = 360 - Ztot
        'If L <= 0 And LHA > 180 Then ZN = 180 - Ztot
        'If L <= 0 And LHA <= 180 Then ZN = 180 + Ztot
        If cboL.Text = "N" And LHA > 180 Then ZN = Ztot
        If cboL.Text = "N" And LHA <= 180 Then ZN = 360 - Ztot
        If cboL.Text = "S" And LHA > 180 Then ZN = 180 - Ztot
        If cboL.Text = "S" And LHA <= 180 Then ZN = 180 + Ztot


        Zcorr = 0 'Zcorr is delta L corr
        If optdtL.Checked = True Then
            Zcorr1 = System.Math.Abs(System.Math.Cos(ZN * Pi / 180)) 'cos(ZN) is the same as cos(TabZ rounded to whole degrees)
            'Zcorr = Zcorr * Ldiff                 'this is the mathematically correct delta L corr
            Zcorr = Int(Int(System.Math.Abs(Ldiff)) * Zcorr1 * 10 + 0.5) / 10 'this and next line emulate multiplication table
            Zcorr = Zcorr + Int((System.Math.Abs(Ldiff) - Int(System.Math.Abs(Ldiff))) * Zcorr1 * 10 + 0.5) / 10
            Zcorr = Int(Zcorr * 10 + 0.5) / 10
            SignL = "+"
            If System.Math.Abs(L) > System.Math.Abs(AsmL) And TabZ > 90 Then Zcorr = -Zcorr : SignL = "-"
            If System.Math.Abs(L) < System.Math.Abs(AsmL) And TabZ < 90 Then Zcorr = -Zcorr : SignL = "-"
        End If

        ZN = Int(ZN + 0.5) 'added in V4.0.0

        Totcorr = (d1corr + d2corr) + Zcorr
        SignTotcorr = "+" : If Totcorr < 0 Then SignTotcorr = "-"

        TotHc = (TabHcDeg * 60 + TabHcMin + Totcorr) / 60

        TotHcDeg = Fix(TotHc) : Htot = TotHc 'was Int
        TotHcMin = TotHc - TotHcDeg
        TotHcMin = Int(600 * TotHcMin + 0.5) / 10
        If TotHcMin = 60 Then TotHcMin = 0 : TotHcDeg = TotHcDeg + 1

        A = (60 * TotHcDeg + TotHcMin) - (60 * HoDeg + HoMin)

    End Sub

    Public Sub Sadler()
        If L = 0 Then L = 0.000000000000001 'Prevents divide-by-zero error if latitude is 0º
        frame211.Visible = False


        Flag = False 'Part of avoiding divide-by-zero errors
        LHA = GHA - Lo
        If LHA >= 360 Then LHA = LHA - 360
        If LHA < 0 Then LHA = LHA + 360
        If LHA <= 180 Then T = LHA 'W
        If LHA > 180 Then T = 360 - LHA 'E
        tDeg = Int(T)
        tMin = (T - tDeg) * 60
        If optCompact.Checked = True Then tMin = Int(tMin + 0.50000001)
        If optOriginal.Checked = True Then tMin = Int(2 * tMin + 0.5) / 2
        If tMin = 60 Then tMin = 0 : tDeg = tDeg + 1
        tDecimal = tDeg + tMin / 60 ': If tDecimal = 0 Then tDecimal = 0.00000001
        If optCompact.Checked = True And tDecimal = 0 Then
            ErrorMsgBox("For Compact H.O. 211 without interpolation, meridian angle t must be at least 0.5'.")
            Flag = True
            Exit Sub
        End If
        If optOriginal.Checked = True And tDecimal = 0 Then
            ErrorMsgBox("For Original H.O. 211 without interpolation, meridian angle t must be at least 0.3'.")
            Flag = True
            Exit Sub
        End If
        If optCompact.Checked = True And tDecimal = 90 Then
            ErrorMsgBox("For Sadler Technique using Compact H.O. 211 without interpolation, meridian angle t must be at least 0.5' away from 90º.")
            cmd211_Click(cmd211, New System.EventArgs())
            Flag = True
            Exit Sub
        End If
        If optOriginal.Checked = True And tDecimal = 90 Then
            ErrorMsgBox("For Sadler Technique using Original H.O. 211 without interpolation, meridian angle t must be at least 0.3' away from 90º.")
            cmd211_Click(cmd211, New System.EventArgs())
            Flag = True
            Exit Sub
        End If
        B1 = Sec211(tDecimal)
        If (optCompact.Checked = True And B1 < 166) Or (optOriginal.Checked = True And B1 < 239) Then B1 = Int(10 * A1 + 0.5) / 10 Else B1 = Int(B1 + 0.5)
        A1 = Csc211(tDecimal)
        If (optCompact.Checked = True And A1 < 166) Or (optOriginal.Checked = True And A1 < 239) Then A1 = Int(10 * A1 + 0.5) / 10 Else A1 = Int(A1 + 0.5)
        DecDecimal = Val(txtDecDeg.Text) + DecMinutes / 60

        If optCompact.Checked = True And DecDecimal = 0 Then
            ErrorMsgBox("For Compact H.O. 211 without interpolation, Dec must be at least 0.5'.")
            Flag = True
            Exit Sub
        End If
        If optOriginal.Checked = True And DecDecimal = 0 Then
            ErrorMsgBox("For Original H.O. 211 without interpolation, Dec must be at least 0.3'.")
            Flag = True
            Exit Sub
        End If
        frame211.Visible = True
        A2 = Csc211(DecDecimal)
        If (optCompact.Checked = True And A2 < 166) Or (optOriginal.Checked = True And A2 < 239) Then A2 = Int(10 * A2 + 0.5) / 10 Else A2 = Int(A2 + 0.5)
        B2 = Sec211(DecDecimal)
        If (optCompact.Checked = True And B2 < 166) Or (optOriginal.Checked = True And B2 < 239) Then B2 = Int(10 * B2 + 0.5) / 10 Else B2 = Int(B2 + 0.5)
        A3 = Csc211(System.Math.Abs(L))
        If (optCompact.Checked = True And A3 < 166) Or (optOriginal.Checked = True And A3 < 239) Then A3 = Int(10 * A3 + 0.5) / 10 Else A3 = Int(A3 + 0.5)
        B3 = Sec211(System.Math.Abs(L))
        If (optCompact.Checked = True And B3 < 166) Or (optOriginal.Checked = True And B3 < 239) Then B3 = Int(10 * B3 + 0.5) / 10 Else B3 = Int(B3 + 0.5)
        A4 = A2 + A3
        A4 = Int(A4 * 10 + 0.5) / 10 'is this line necessary?
        L1 = 1 / (10 ^ (A4 / 100000)) 'L1 is h1
        If L1 = 1 Then L1 = Pi / 2 Else L1 = System.Math.Atan(L1 / System.Math.Sqrt(-L1 * L1 + 1) + 9.999999E-21) 'arcsin
        L1 = L1 * 180 / Pi
        If cboL.Text <> cboDec.Text Then L1 = -L1
        h1Deg = Int(System.Math.Abs(L1)) : h1Min = (System.Math.Abs(L1) - h1Deg) * 60
        If optCompact.Checked = True Then h1Min = Int(h1Min + 0.5)
        If optOriginal.Checked = True Then h1Min = Int(2 * h1Min + 0.5) / 2
        If h1Min >= 60 Then h1Min = h1Min - 60 : h1Deg = h1Deg + 1
        L2 = L1 + Ho 'h1 + Ho
        L2Deg = Int(System.Math.Abs(L2)) : L2Min = (System.Math.Abs(L2) - L2Deg) * 60
        If L2Min >= 60 Then L2Min = L2Min - 60 : L2Deg = L2Deg + 1
        L3 = L2 / 2 '(h1 + Ho)/2
        L3Deg = Int(System.Math.Abs(L3)) : L3Min = (System.Math.Abs(L3) - L3Deg) * 60
        If optCompact.Checked = True Then L3Min = Int(L3Min + 0.5)
        If optOriginal.Checked = True Then L3Min = Int(L3Min * 10 + 0.5) / 10
        If L3Min >= 60 Then L3Min = L3Min - 60 : L3Deg = L3Deg + 1
        B4 = Sec211(L3)
        A5 = B1 + B2 + B3 - B4
        L4 = 1 / (10 ^ (A5 / 100000)) 'L4 is h2
        If L4 = 1 Then L4 = Pi / 2 Else L4 = System.Math.Atan(L4 / System.Math.Sqrt(-L4 * L4 + 1) + 9.999999E-21) 'arcsin
        L4 = L4 * 180 / Pi
        If T < 90 Then L4 = System.Math.Abs(L4)
        If T > 90 Then L4 = -System.Math.Abs(L4)
        If T = 90 Then L4 = 0
        h2Deg = Int(L4) : h2Min = (L4 - h2Deg) * 60
        If optCompact.Checked = True Then h2Min = Int(h2Min + 0.5)
        If optOriginal.Checked = True Then h2Min = Int(2 * h2Min + 0.5) / 2
        If h2Min >= 60 Then h2Min = h2Min - 60 : h2Deg = h2Deg + 1
        Hc = h1Deg + h2Deg + (h1Min + h2Min) / 60 'h1 + h2
        HcDeg = Int(Hc) : HcMin = (Hc - HcDeg) * 60
        If HcMin >= 60 Then HcMin = HcMin - 60 : HcDeg = HcDeg + 1
        B5 = Sec211(Hc)
        If (L1 + L4) < 0 Then Hc = -Hc

        Ho = Val(txtHoDeg.Text) + Val(txtHoMin.Text) / 60

        HoDeg = Val(txtHoDeg.Text)
        HoMin = Val(txtHoMin.Text)
        If optCompact.Checked = True Then HoMin = Int(HoMin + 0.5)
        If optOriginal.Checked = True Then HoMin = Int(HoMin * 10 + 0.5) / 10
        A = System.Math.Sign(Hc) * (60 * HcDeg + HcMin) - (60 * HoDeg + HoMin)
        If HoinMinutes < 0 Then A = (60 * HcDeg + HcMin) + (60 * HoDeg + HoMin)

        If (optCompact.Checked = True And B5 < 166) Or (optOriginal.Checked = True And B5 < 239) Then B5 = Int(10 * B5 + 0.5) / 10 Else B5 = Int(B5 + 0.5)
        A6 = A1 + B2 - B5
        If A6 <= 0 Then A6 = 0 : Z = 90 'When the body is near or on the Prime Vertical, A7 may be negative.  Use zero for A7 and Z will be 90 degrees.
        If A6 <> 0 Then
            Z = 1 / (10 ^ (A6 / 100000))
            Z = System.Math.Atan(Z / System.Math.Sqrt(-Z * Z + 1) + 9.999999E-21) 'arcsin
            Z = Z * 180 / Pi
        End If
        A6 = Int(A6 * 10 + 0.5) / 10 'this line was necessary for low value of A7
        If cboDec.Text = cboL.Text And k > L Then Z = Z Else Z = 180 - Z
        ZDeg = Int(Z)
        ZMin = (Z - ZDeg) * 60
        'If optCompact = True Then Z = Int(Z + 0.5)  'For Z in whole degrees
        If optCompact.Checked = True Then ZMin = Int(ZMin + 0.5)
        If optOriginal.Checked = True Then ZMin = Int(2 * ZMin + 0.5) / 2
        If cboL.Text = "N" And LHA > 180 Then ZN = Z
        If cboL.Text = "N" And LHA <= 180 Then ZN = 360 - Z
        If cboL.Text = "S" And LHA > 180 Then ZN = 180 - Z
        If cboL.Text = "S" And LHA <= 180 Then ZN = 180 + Z

        'If cboL.text = "S" Then L = -L

    End Sub

    Public Sub DisplaySadler()
        cmdSave.Visible = False
        cmdFix.Visible = False ': 
        cmdFix.Enabled = False
        cmdFix.Text = "Establish Fix"
        'Me.Font = New Font(Me.Font, "Courier New")
        SRHdrTxtBx.Clear()
        SRHdrTxtBx.Visible = True
        SRHdrTxtBx.BringToFront()

        SRLgTxtBx.Clear()
        SRLgTxtBx.Visible = True
        SRLgTxtBx.BringToFront()

        SRLeftTxtBx.Clear()
        SRLeftTxtBx.Visible = False
        SRLeftTxtBx.SendToBack()

        SRRightTxtBx.Clear()
        SRRightTxtBx.Visible = False
        SRRightTxtBx.SendToBack()

        NASRAsmTxtBx.Clear()
        NASRAsmTxtBx.Visible = False
        NASRAsmTxtBx.SendToBack()

        NASRAFTxtBx.Clear()
        NASRAFTxtBx.Visible = False
        NASRAFTxtBx.SendToBack()

        DCorrTxtBx.Clear()
        DCorrTxtBx.Visible = False
        DCorrTxtBx.SendToBack()

        WeemsPVTxtBx.Clear()            'V5.6.1
        WeemsPVTxtBx.Visible = False    'V5.6.1
        WeemsPVTxtBx.SendToBack()   'V5.6.1

        frameNASRUsing.Visible = False
        'frame211.Visible = True        'moved to HO211 so it doesn't appear if LHA or Dec are near zero
        frame214.Visible = False
        Label9.Visible = False
        frameS.Visible = False
        GroupBoxPrecision.Visible = False      'V5.6.1
        chkInterpolateB.Visible = False

        AlignCenterRTB(SRHdrTxtBx)
        SRHdrTxtBx.AppendText("INTERCEPT and AZIMUTH by SADLER'S TECHNIQUE (H.O. 211)")

        If optCompact.Checked = True Then
            SRLgTxtBx.AppendText("t*" & Space(12 - Strings.Format(tDeg.ToString, "0").Length) & Strings.Format(tDeg.ToString, "0") & Chr(176) & Strings.Format(tMin.ToString, "00") & "'")
        End If

        If optOriginal.Checked = True Then
            SRLgTxtBx.AppendText("t*" & Space(12 - Strings.Format(tDeg.ToString, "0").Length) & Strings.Format(tDeg, "0") & Chr(176) & Strings.Format(tMin, "00.0") & "'")
        End If

        If LHA <= 180 Then
            SRLgTxtBx.AppendText(g_LongW)
        End If

        If LHA > 180 Then
            SRLgTxtBx.AppendText(g_LongE)
        End If

        SRLgTxtBx.AppendText(" -> -> -> -> -> -> -> -> ")

        If (optCompact.Checked = True And B1 < 166) Or (optOriginal.Checked = True And B1 < 239) Then
            SRLgTxtBx.AppendText("B " & Space(9 - i) & Strings.Format(B1, "0.0"))
        Else
            SRLgTxtBx.AppendText("B " & Space(7 - i) & Strings.Format(B1, "0") & "  ")
        End If
        i = A1.ToString.Length 'i = A1))
        If (A1 - Int(A1)) = 0 Then
            i = i + 2
        End If
        If A1 < 1 And A1 > 0 Then
            i = i + 1
        End If

        If (optCompact.Checked = True And A1 < 166) Or (optOriginal.Checked = True And A1 < 239) Then
            SRLgTxtBx.AppendText(Space(11) & "A " & Space(9 - i) & Strings.Format(A1, "0.0"))
        Else

            SRLgTxtBx.AppendText(Space(11) & "A " & Space(7 - i) & Strings.Format(A1, "0") & "  ")
        End If
        SRLgTxtBx.AppendText(vbNewLine)

        If optCompact.Checked = True Then
            SRLgTxtBx.AppendText("Dec*" & Space(10 - txtDecDeg.Text.Length) & Strings.Format(Val(txtDecDeg.Text), "0") _
                               & Chr(176) & Strings.Format(DecMinutes, "00") & "'" & cboDec.Text)
        End If

        If optOriginal.Checked = True Then
            SRLgTxtBx.AppendText("Dec*" & Space(10 - txtDecDeg.Text.Length) & Strings.Format(Val(txtDecDeg.Text), "0") _
                               & Chr(176) & Strings.Format(DecMinutes, "00.0") & "'" & cboDec.Text)
        End If
        i = A2.ToString.Length
        If (A2 - Int(A2)) = 0 Then
            i = i + 2
        End If

        If (optCompact.Checked = True And A2 < 166) Or (optOriginal.Checked = True And A2 < 239) Then
            SRLgTxtBx.AppendText(Space(11) & "A" & Space(9 - i) & Strings.Format(A2, "0.0"))
        Else

            SRLgTxtBx.AppendText(Space(11) & "A" * Space(7 - i) & Strings.Format(A2, "0") & "  ")
        End If
        i = B2.ToString.Length
        If (B2 - Int(B2)) = 0 Then
            i = i + 2
        End If

        If (optCompact.Checked = True And B2 < 166) Or (optOriginal.Checked = True And B2 < 239) Then
            SRLgTxtBx.AppendText(Space(11) & "B+" & Space(9 - i) & Strings.Format(B2, "0.0"))
        Else

            SRLgTxtBx.AppendText(Space(11) & "B+" & Space(7 - i) & Strings.Format(B2, "0") & "  ")
        End If
        i = B2.ToString.Length
        If (B2 - Int(B2)) = 0 Then
            i = i + 2
        End If

        If (optCompact.Checked = True And B2 < 166) Or (optOriginal.Checked = True And B2 < 239) Then
            SRLgTxtBx.AppendText(Space(11) & "B+" & Space(9 - i) & Strings.Format(B2, "0.0"))
        Else

            SRLgTxtBx.AppendText(Space(11) & "B+" & Space(7 - i) & Strings.Format(B2, "0") & "  ")
        End If
        SRLgTxtBx.AppendText(vbNewLine)

        If optCompact.Checked = True Then SRLgTxtBx.AppendText("DR L" & Space(10 - txtLDeg.Text.Length) & Strings.Format(Val(txtLDeg.Text), "0") & Chr(176) & Strings.Format(Int(Val(txtLMin.Text) + 0.5), "00") & "'" & cboL.Text)

        If optOriginal.Checked = True Then SRLgTxtBx.AppendText("DR L" & Space(10 - txtLDeg.Text.Length) & Strings.Format(Val(txtLDeg.Text), "0") & Chr(176) & Strings.Format(Val(txtLMin.Text), "00.0") & "'" & cboL.Text)
        i = A3.ToString.Length
        If (A3 - Int(A3)) = 0 Then
            i = i + 2
        End If

        If (optCompact.Checked = True And A3 < 166) Or (optOriginal.Checked = True And A3 < 239) Then
            SRLgTxtBx.AppendText(Space(11) & "A+" & Space(9 - i) & Strings.Format(A3, "0.0"))
        Else

            SRLgTxtBx.AppendText(Space(11) & "A+" & Space(7 - i) & Strings.Format(A3, "0") & "  ")
        End If
        i = B3.ToString.Length
        If (B3 - Int(B3)) = 0 Then
            i = i + 2
        End If

        If (optCompact.Checked = True And B3 < 166) Or (optOriginal.Checked = True And B3 < 239) Then
            SRLgTxtBx.AppendText(Space(11) & "B+" & Space(9 - i) & Strings.Format(B3, "0.0"))
        Else

            SRLgTxtBx.AppendText(Space(11) & "B+" & Space(7 - i) & Strings.Format(B3, "0") & "  ")
        End If
        SRLgTxtBx.AppendText(vbNewLine)


        SRLgTxtBx.AppendText("h1")

        If L1 < 0 Then
            SRLgTxtBx.AppendText(Space(11) & "-")
        Else
            SRLgTxtBx.AppendText(Space(11) & " ")
        End If

        If optCompact.Checked = True Then
            SRLgTxtBx.AppendText(Space(4 - h1Deg.ToString.Length) & Strings.Format(h1Deg, "0") & Chr(176) & Strings.Format(Int(h1Min), "00") & "'") 'cboL.text;
        End If

        If optOriginal.Checked = True Then
            SRLgTxtBx.AppendText(Space(4 - h1Deg.ToString.Length) & Strings.Format(h1Deg, "0") & Chr(176) & Strings.Format(Int(h1Min), "00.0") & "'") 'cboL.text;
        End If

        SRLgTxtBx.AppendText("  <-  ")
        i = A4.ToString.Length
        If (A4 - Int(A4)) = 0 Then
            i = i + 2
        End If

        If (optCompact.Checked = True And A4 < 166) Or (optOriginal.Checked = True And A4 < 239) Then
            SRLgTxtBx.AppendText(Space(11) & "A " & Space(9 - i) & Strings.Format(A4, "0.0"))
        Else

            SRLgTxtBx.AppendText(Space(11) & "A" & Space(7 - i) & Strings.Format(A4, "0") & "  ")
        End If
        SRLgTxtBx.AppendText(vbNewLine)

        If optCompact.Checked = True Then
            SRLgTxtBx.AppendText("Ho" & Space(12 - txtHoDeg.Text.Length) & Strings.Format(HoDeg, "0") & Chr(176) & Strings.Format(System.Math.Abs(HoMin), "00") & "'")
        End If

        If optOriginal.Checked = True Then
            SRLgTxtBx.AppendText("Ho" & Space(12 - txtHoDeg.Text.Length) & Strings.Format(HoDeg, "0") & Chr(176) & Strings.Format(System.Math.Abs(HoMin), "00.0") & "'")
        End If
        SRLgTxtBx.AppendText(vbNewLine)

        SRLgTxtBx.AppendText("h1+Ho")

        If L2 < 0 Then
            SRLgTxtBx.AppendText(Space(11 - L2Deg.ToString.Length) & "-")
        Else
            SRLgTxtBx.AppendText(Space(11 - L2Deg.ToString.Length) & " ")
        End If

        If optCompact.Checked = True Then
            SRLgTxtBx.AppendText(Space(12 - L2Deg.ToString.Length) & Strings.Format(L2Deg, "0") & Chr(176) & Strings.Format(L2Min, "00") & "'")
        End If

        If optOriginal.Checked = True Then
            SRLgTxtBx.AppendText(Space(12 - L2Deg.ToString.Length) & Strings.Format(L2Deg, "0") & Chr(176) & Strings.Format(L2Min, "00.0") & "'")
        End If
        SRLgTxtBx.AppendText(vbNewLine)

        SRLgTxtBx.AppendText("(h1+Ho)/2")

        If L3 < 0 Then
            SRLgTxtBx.AppendText(Space(11 - L3Deg.ToString.Length) & "-")
        Else
            SRLgTxtBx.AppendText(Space(11 - L3Deg.ToString.Length) & " ")
        End If

        If optCompact.Checked = True Then
            SRLgTxtBx.AppendText(Space(11 - L3Deg.ToString.Length) & Strings.Format(L3Deg, "0") & Chr(176) & Strings.Format(L3Min, "00") & "'")
        End If

        If optOriginal.Checked = True Then
            SRLgTxtBx.AppendText(Space(11 - L3Deg.ToString.Length) & Strings.Format(L3Deg, "0") & Chr(176) & Strings.Format(L3Min, "00.0") & "'")
        End If

        SRLgTxtBx.AppendText(" -> -> -> -> -> -> -> -> ")
        i = B4.ToString.Length
        If (B4 - Int(B4)) = 0 Then
            i = i + 2
        End If
        If B4 < 1 And B4 > 0 Then
            i = i + 1
        End If

        If (optCompact.Checked = True And B4 < 166) Or (optOriginal.Checked = True And B4 < 239) Then
            SRLgTxtBx.AppendText(Space(25) & "B-" & Space(9 - i) & Strings.Format(B4, "0.0"))
        Else
            SRLgTxtBx.AppendText(Space(25) & "B-" & Space(9 - i) & Strings.Format(B4, "0") & "  ")
        End If
        SRLgTxtBx.AppendText(vbNewLine)

        SRLgTxtBx.AppendText("h2")

        If L4 < 0 Then
            SRLgTxtBx.AppendText(Space(13 - h2Deg.ToString.Length) & "-")
        Else
            SRLgTxtBx.AppendText(Space(13 - h2Deg.ToString.Length) & " ")

        End If

        If optCompact.Checked = True Then
            SRLgTxtBx.AppendText(Space(4 - h2Deg.ToString.Length) & Strings.Format(System.Math.Abs(h2Deg), "0") & Chr(176) & Strings.Format(System.Math.Abs(h2Min), "00") & "'")
        End If

        If optOriginal.Checked = True Then
            SRLgTxtBx.AppendText(Space(4 - h2Deg.ToString.Length) & Strings.Format(System.Math.Abs(h2Deg), "0") & Chr(176) & Strings.Format(System.Math.Abs(h2Min), "00.0") & "'")
        End If

        SRLgTxtBx.AppendText(" <- <- <- <- <- <- <- <- ")
        i = A5.ToString.Length
        If (A5 - Int(A5)) = 0 Then
            i = i + 2
        End If

        If (optCompact.Checked = True And A5 < 166) Or (optOriginal.Checked = True And A5 < 239) Then
            SRLgTxtBx.AppendText(Space(24) & "A " & Space(9 - i) & Strings.Format(A5, "0.0"))
        Else

            SRLgTxtBx.AppendText(Space(24) & "A " & Space(7 - i) & Strings.Format(A5, "0") & "  ")
        End If
        SRLgTxtBx.AppendText(vbNewLine)

        SRLgTxtBx.AppendText("Hc(h1+h2)")
        If (L1 + L4) < 0 Then
            SRLgTxtBx.AppendText(Space(4 - HcDeg.ToString.Length) & "-")
            Hc = -Hc
        Else
            SRLgTxtBx.AppendText(Space(4 - HcDeg.ToString.Length) & " ")
        End If

        If optCompact.Checked = True Then
            SRLgTxtBx.AppendText(Space(4 - HcDeg.ToString.Length) & Strings.Format(HcDeg, "0") & Chr(176) & Strings.Format(HcMin, "00") & "'")
        End If

        If optOriginal.Checked = True Then
            SRLgTxtBx.AppendText(Space(4 - HcDeg.ToString.Length) & Strings.Format(HcDeg, "0") & Chr(176) & Strings.Format(HcMin, "00.0") & "'")
        End If

        SRLgTxtBx.AppendText(" -> -> -> -> -> -> -> -> -> -> -> -> -> -> -> ")
        i = B5.ToString.Length
        If (B5 - Int(B5)) = 0 Then
            i = i + 2
        End If

        If (optCompact.Checked = True And B5 < 166) Or (optOriginal.Checked = True And B5 < 239) Then
            SRLgTxtBx.AppendText(Space(45) & "B-" & Space(9 - i) & Strings.Format(B5, "0.0"))
        Else
            SRLgTxtBx.AppendText(Space(45) & "B-" & Space(7 - i) & Strings.Format(B5, "0") & "  ")
        End If
        SRLgTxtBx.AppendText(vbNewLine)

        If optCompact.Checked = True Then
            SRLgTxtBx.AppendText("Ho" & Space(12 - txtHoDeg.Text.Length) & Strings.Format(HoDeg, "0") & Chr(176) & Strings.Format(HoMin, "00") & "'")
        End If

        If optOriginal.Checked = True Then
            SRLgTxtBx.AppendText("Ho" & Space(12 - txtHoDeg.Text.Length) & Strings.Format(HoDeg, "0") & Chr(176) & Strings.Format(HoMin, "00.0") & "'")
        End If

        If Ho > Hc Then
            SRLgTxtBx.AppendText("    Observed greater - Toward")
        End If

        If Ho < Hc Then
            SRLgTxtBx.AppendText("    Computed greater - Away")
        End If
        SRLgTxtBx.AppendText(vbNewLine)

        SRLgTxtBx.AppendText("a" & Space(16 - (Int(System.Math.Abs(A))).ToString.Length))

        If optCompact.Checked = True Then
            SRLgTxtBx.AppendText(Strings.Format(Int(System.Math.Abs(A) + 0.5), "0") & " miles ")
            PlotOut.PlotIntercept = Strings.Format(Int(System.Math.Abs(A) + 0.5), "0") & " nm "
        End If

        If optOriginal.Checked = True Then
            SRLgTxtBx.AppendText(Strings.Format(Int(System.Math.Abs(A) * 10 + 0.5) / 10, "0.0") & " miles ")
            PlotOut.PlotIntercept = Strings.Format(Int(System.Math.Abs(A) * 10 + 0.5) / 10, "0.0") & " nm "
        End If

        If Hc < Ho Then
            SRLgTxtBx.AppendText("T")
            PlotOut.PlotIntercept &= "Toward"
        End If

        If Hc > Ho Then
            SRLgTxtBx.AppendText("A")
            PlotOut.PlotIntercept &= "Away"
        End If

        SRLgTxtBx.AppendText(Space(5) & "Zn" & Space(1) & Strings.Format(ZN, "000") & Chr(176) & " <- <- ")
        PlotOut.PlotAz = Strings.Format(ZN, "000") & Chr(176)

        If optCompact.Checked = True Then
            SRLgTxtBx.AppendText(Space(3) & "Z " & cboL.Text & Space(1) & Strings.Format(ZDeg, "0") & Chr(176) & Strings.Format(ZMin, "00") & "'") 'Format(Z, "0"); Chr$(176); for whole degrees
        End If

        If optOriginal.Checked = True Then
            SRLgTxtBx.AppendText(Space(3) & "Z " & cboL.Text & Space(1) & Strings.Format(ZDeg, "0") & Chr(176) & Strings.Format(ZMin, "00.0") & "'")
        End If

        If LHA <= 180 Then SRLgTxtBx.AppendText(" W" & " <- <- ")

        If LHA > 180 Then SRLgTxtBx.AppendText(" E" & " <- <- ")

        If optCompact.Checked = True Then SRLgTxtBx.AppendText("<-")
        i = A6.ToString.Length
        If (A6 - Int(A6)) = 0 Then
            i = i + 2
        End If

        If A6 - Int(A6) <> 0 Then SRLgTxtBx.AppendText(Space(11) & "A " & Space(9 - i) & Strings.Format(A6, "0.0"))

        If A6 - Int(A6) = 0 Then SRLgTxtBx.AppendText(Space(11) & "A" & Space(7 - i) & Strings.Format(A6, "0") & "  ")
        SRLgTxtBx.AppendText(vbNewLine)


        SRLgTxtBx.AppendText(Space(25) & "EP L " & Strings.Format(EstLDeg, "0") & Chr(176) & Strings.Format(EstLMin, "00.0") & "'")
        PlotOut.PlotSLEP = "EP L " & Strings.Format(EstLDeg, "0") & Chr(176) & Strings.Format(EstLMin, "00.0") & "'"

        If EstL > 0 Then
            SRLgTxtBx.AppendText(g_LatN)
            PlotOut.PlotSLEP &= g_LatN
            PlotOut.PlotLatNS = g_LatN
        End If
        If EstL = 0 Then
            SRLgTxtBx.AppendText(g_StrSpace)
            PlotOut.PlotSLEP &= g_LatN
            PlotOut.PlotLatNS = g_LatN
        End If
        If EstL < 0 Then
            SRLgTxtBx.AppendText(g_LatS)
            PlotOut.PlotSLEP &= g_LatS
            PlotOut.PlotLatNS = g_LatS
        End If

        SRLgTxtBx.AppendText("    EP Lo " & Strings.Format(EstLoDeg, "0") & Chr(176) & Strings.Format(EstLoMin, "00.0") & "'")
        PlotOut.PlotSLEP &= " EP Lo " & Strings.Format(EstLoDeg, "0") & Chr(176) & Strings.Format(EstLoMin, "00.0") & "'"
        If EstLo > 0 Then
            SRLgTxtBx.AppendText(g_LongW)
            PlotOut.PlotSLEP &= g_LongW
            PlotOut.PlotLongEW = g_LongW
        End If
        If EstLo = 0 Then
            SRLgTxtBx.AppendText(g_StrSpace)
            PlotOut.PlotSLEP &= g_LongW
            PlotOut.PlotLongEW = g_LongW
        End If
        If EstLo < 0 Then
            SRLgTxtBx.AppendText(g_LongE)
            PlotOut.PlotSLEP &= g_LongE
            PlotOut.PlotLongEW = g_LongE
        End If
        SRLgTxtBx.AppendText(vbNewLine)

        SRLgTxtBx.AppendText(Space(25) & "*Table entry values")
        SRLgTxtBx.AppendText(vbNewLine)

        SRLgTxtBx.Refresh()
        SRHdrTxtBx.Refresh()

    End Sub

    Private Sub STable()
        frame211.Visible = False

        Flag = False 'Part of avoiding divide-by-zero errors
        LHA = GHA - Lo
        If LHA >= 360 Then LHA = LHA - 360
        If LHA < 0 Then LHA = LHA + 360
        LHADeg = Int(LHA)
        LHAMin = (LHA - LHADeg) * 60
        LHAMin = Int(LHAMin + 0.50000001)
        If LHAMin = 60 Then
            LHAMin = 0
            LHADeg = LHADeg + 1
        End If
        LHADecimal = LHADeg + LHAMin / 60
        If LHADecimal = 0 Then
            A1 = 999.999
        Else
            A1 = CscS(LHADecimal)
        End If
        A1 = Int(1000 * A1 + 0.5) / 1000
        DecDecimal = Val(txtDecDeg.Text) + DecMinutes / 60
        frameS.Visible = True
        B1 = SecS(DecDecimal)
        B1 = Int(1000 * B1 + 0.5) / 1000
        A2 = CscS(DecDecimal)
        A2 = Int(1000 * A2 + 0.5) / 1000
        A3 = A1 + B1
        '        A3 = Int(A3 * 10 + 0.5) / 10    'is this line necessary?
        A4 = A3
        If optPepperday.Checked = True Then
            A3Angle = 1 / (10 ^ (A3 / 94.2932531))
        End If
        If optFarley.Checked = True Then
            A3Angle = 1 / (10 ^ (A3 / 100))
        End If
        A3Angle = System.Math.Atan(A3Angle / System.Math.Sqrt(-A3Angle * A3Angle + 1) + 9.999999E-21) 'arcsin
        A3Angle = A3Angle * 180 / Pi
        A3AngleDeg = Int(A3Angle)
        A3AngleMin = (A3Angle - A3AngleDeg) * 60
        A3AngleMin = Int(A3AngleMin + 0.5)
        A3AngleDecimal = A3AngleDeg + A3AngleMin / 60
        B2 = SecS(A3AngleDecimal)
        B2 = Int(1000 * B2 + 0.5) / 1000
        B3 = B2
        A5 = A2 - B2
        '        A5 = Int(A5 * 10 + 0.5) / 10    'is this line necessary?
        If optPepperday.Checked = True Then k = 1 / (10 ^ (A5 / 94.2932531))
        If optFarley.Checked = True Then k = 1 / (10 ^ (A5 / 100))
        If k >= 1 Then
            k = Pi / 2
        Else
            k = System.Math.Atan(k / System.Math.Sqrt(-k * k + 1) + 9.999999E-21) 'arcsin        Was If k = 1 before V5.4.1
        End If
        k = k * 180 / Pi
        '    If tDecimal > 90 Then k = 180 - k       '????????????90-K or 180-K????????

        If k >= 82 And k <= 98 Then
            B2 = SecS(A3Angle)
            B2 = Int(1000 * B2 + 0.5) / 1000
            B3 = B2
            A5 = A2 - B2
            'A5 = CscS(DecDecimal) - SecS(A3Angle)
            'A5 = Int(1000 * A5 + 0.5) / 1000
            If optPepperday.Checked = True Then
                k = 1 / (10 ^ (A5 / 94.2932531))
            End If
            If optFarley.Checked = True Then
                k = 1 / (10 ^ (A5 / 100))
            End If
            If k >= 1 Then
                k = Pi / 2
            Else
                k = System.Math.Atan(k / System.Math.Sqrt(-k * k + 1) + 9.999999E-21) 'arcsin        Was If k = 1 before V5.4.1
            End If
            k = k * 180 / Pi
            A5 = Int(1000 * A5 + 0.5) / 1000
        End If

        If LHADecimal >= 90 And LHADecimal <= 270 Then
            k = 180 - k
        End If
        KDeg = Int(k)
        KMin = (k - KDeg) * 60
        KMin = Int(KMin + 0.5)
        L = Val(txtLDeg.Text) + Int(Val(txtLMin.Text) + 0.5) / 60
        If cboDec.Text = cboL.Text Then
            KL = System.Math.Abs(L - KDeg - KMin / 60)
        End If
        If cboDec.Text <> cboL.Text Then
            KL = System.Math.Abs(L + KDeg + KMin / 60)
        End If
        'If KL > 90 Then KL = KL + 180
        KLDeg = Int(KL)
        KLMin = (KL - KLDeg) * 60
        'If KLDeg > 90 Then KLDeg = KLDeg + 180
        KLMin = Int(KLMin + 0.5)
        If KLMin >= 60 Then
            KLMin = KLMin - 60
            KLDeg = KLDeg + 1
        End If
        B4 = SecS(KLDeg + KLMin / 60)
        B4 = Int(1000 * B4 + 0.5) / 1000
        If KLDeg > 270 Then
            KLDeg = KLDeg - 180
        End If
        A6 = B3 + B4
        '        A6 = Int(A6 * 10 + 0.5) / 10    'is this line necessary?
        If optPepperday.Checked = True Then
            HcAngle = 1 / (10 ^ (A6 / 94.2932531))
        End If
        If optFarley.Checked = True Then
            HcAngle = 1 / (10 ^ (A6 / 100))
        End If
        If HcAngle = 1 Then
            HcAngle = Pi / 2
        Else
            HcAngle = System.Math.Atan(HcAngle / System.Math.Sqrt(-HcAngle * HcAngle + 1) + 9.999999E-21) 'arcsin
        End If
        HcAngle = HcAngle * 180 / Pi
        If KL > 90 Then
            HcAngle = -HcAngle
        End If
        Htot = HcAngle
        HcDeg = Fix(HcAngle) 'was Int
        HcMin = (HcAngle - HcDeg) * 60
        HcMin = Int(HcMin + 0.5)
        If HcMin >= 60 Then HcMin = HcMin - 60 : HcDeg = HcDeg + 1
        HcDecimal = HcDeg + HcMin / 60
        'If KL > 90 Then HcDecimal = -HcDecimal
        B5 = SecS(HcDecimal)
        B5 = Int(1000 * B5 + 0.5) / 1000
        Ho = Val(txtHoDeg.Text) + Int(Val(txtHoMin.Text) + 0.5) / 60 'WHY THIS LINE???????????????????
        'HoDeg = Int(Ho)
        'HoMin = (Ho - HoDeg) * 60
        HoDeg = Val(txtHoDeg.Text)
        HoMin = Val(txtHoMin.Text)
        HoMin = Int(HoMin + 0.5)
        'A = Sgn(HcDecimal) * (60 * HcDeg + HcMin) - (60 * HoDeg + HoMin)
        A = (60 * HoDeg + HoMin) - (60 * HcDeg + HcMin)
        'If HoinMinutes < 0 Then A = (60 * HcDeg + HcMin) + (60 * HoDeg + HoMin)
        A7 = A4 - B5
        If A7 <= 0 Then
            A7 = 0
            Z = 90 'When the body is near or on the Prime Vertical, A7 may be negative.  Use zero for A7 and Z will be 90 degrees.
        End If
        'A7 = Int(1000 * A7 + 0.5) / 1000
        If A7 <> 0 Then
            If optPepperday.Checked = True Then Z = 1 / (10 ^ (A7 / 94.2932531))
            If optFarley.Checked = True Then Z = 1 / (10 ^ (A7 / 100))
            Z = System.Math.Atan(Z / System.Math.Sqrt(-Z * Z + 1) + 9.999999E-21) 'arcsin
            Z = Z * 180 / Pi
        End If
        A7 = Int(A7 * 1000 + 0.5) / 1000 'this line was necessary for low value of A7
        If cboDec.Text = cboL.Text And k > L Then Z = Z Else Z = 180 - Z
        Z = Int(Z + 0.5)
        If cboL.Text = "N" And LHA > 180 Then ZN = Z
        If cboL.Text = "N" And LHA <= 180 Then ZN = 360 - Z
        If cboL.Text = "S" And LHA > 180 Then ZN = 180 - Z
        If cboL.Text = "S" And LHA <= 180 Then ZN = 180 + Z

        If cboL.Text = "S" Then L = -L

    End Sub
    Private Sub DisplaySTable()
        cmdSave.Visible = False
        cmdFix.Visible = False ': 
        cmdFix.Enabled = False
        cmdFix.Text = "Establish Fix"
        'Me.Font = New Font(Me.Font, "Courier New")
        SRHdrTxtBx.Clear()
        SRHdrTxtBx.Visible = True
        SRHdrTxtBx.BringToFront()

        SRLgTxtBx.Clear()
        SRLgTxtBx.Visible = True
        SRLgTxtBx.BringToFront()

        SRLeftTxtBx.Clear()
        SRLeftTxtBx.Visible = False
        SRLeftTxtBx.SendToBack()

        SRRightTxtBx.Clear()
        SRRightTxtBx.Visible = False
        SRRightTxtBx.SendToBack()

        NASRAsmTxtBx.Clear()
        NASRAsmTxtBx.Visible = False
        NASRAsmTxtBx.SendToBack()

        NASRAFTxtBx.Clear()
        NASRAFTxtBx.Visible = False
        NASRAFTxtBx.SendToBack()

        DCorrTxtBx.Clear()
        DCorrTxtBx.Visible = False
        DCorrTxtBx.SendToBack()

        WeemsPVTxtBx.Clear()            'V5.6.1
        WeemsPVTxtBx.Visible = False    'V5.6.1     
        WeemsPVTxtBx.SendToBack()   'V5.6.1

        frameNASRUsing.Visible = False
        frame214.Visible = False
        Label9.Visible = False
        chkInterpolateB.Visible = False
        frameS.Visible = True
        GroupBoxPrecision.Visible = False      'V5.6.1

        AlignCenterRTB(SRHdrTxtBx)
        SRHdrTxtBx.AppendText("S TABLE SIGHT COMPUTATION")

        FlagFarley = False
        If optFarley.Checked = True And LHA > 180 Then
            LHA = (360 - LHA)
            LHADeg = Int(LHA)
            LHAMin = (LHA - LHADeg) * 60
            LHAMin = Int(LHAMin + 0.50000001)
            If LHAMin = 60 Then
                LHAMin = 0
                LHADeg = LHADeg + 1
            End If
            FlagFarley = True
        End If

        SRLgTxtBx.AppendText("LHA*")

        If FlagFarley = True Then
            SRLgTxtBx.AppendText("    -")
        Else
            SRLgTxtBx.AppendText("     ")
        End If

        SRLgTxtBx.AppendText(Space(5 - LHADeg.ToString.Length) & Strings.Format(LHADeg, "0") & Chr(176) & Strings.Format(LHAMin, "00") & "'")
        i = Int(A1).ToString.Length + 4

        If optPepperday.Checked = True Then
            SRLgTxtBx.AppendText(Space(8) & "S" & Space(9 - i) & Strings.Format(A1, "0.000"))
        End If

        If optFarley.Checked = True Then
            SRLgTxtBx.AppendText(Space(8) & "S1" & Space(9 - i) & Strings.Format(A1, "0.000"))
        End If
        SRLgTxtBx.AppendText(vbNewLine)

        If optPepperday.Checked = True Then
            SRLgTxtBx.AppendText("Dec*    " & cboDec.Text & Space(4 - txtDecDeg.Text.ToString.Length) & Strings.Format(Val(txtDecDeg.Text), "0") _
                               & Chr(176) & Strings.Format(DecMinutes, "00") & "'")
        End If
        If optFarley.Checked = True Then
            SRLgTxtBx.AppendText("DEC*    ")
            If cboDec.Text = "N" Then SRLgTxtBx.AppendText("+")
            If cboDec.Text = "S" Then SRLgTxtBx.AppendText("-")
            SRLgTxtBx.AppendText(Space(4 - txtDecDeg.Text.ToString.Length) & Strings.Format(Val(txtDecDeg.Text), "0") & Chr(176) & Strings.Format(DecMinutes, "00") & "'")
        End If
        i = Int(B1).ToString.Length + 4

        If optPepperday.Checked = True Then
            SRLgTxtBx.AppendText(Space(8) & "C+" & Space(9 - i))
            SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Underline)
            SRLgTxtBx.AppendText(Strings.Format(B1, "0.000"))
            SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Regular)
        End If

        If optFarley.Checked = True Then
            SRLgTxtBx.AppendText(Space(8) & "C2" & Space(9 - i))
            SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Underline)
            SRLgTxtBx.AppendText(Strings.Format(B1, "0.000"))
            SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Regular)
        End If
        i = Int(A2).ToString.Length + 4

        If optPepperday.Checked = True Then
            SRLgTxtBx.AppendText(Space(9) & "S" & Space(9 - i) & Strings.Format(A2, "0.000"))
        End If

        If optFarley.Checked = True Then
            SRLgTxtBx.AppendText(Space(9) & "S2" & Space(9 - i) & Strings.Format(A2, "0.000"))
        End If
        SRLgTxtBx.AppendText(vbNewLine)

        i = Int(A3).ToString.Length + 4

        If optPepperday.Checked = True Then
            SRLgTxtBx.AppendText(Space(25) & "S" & Space(9 - i) & Strings.Format(A3, "0.000"))
        End If

        If optFarley.Checked = True Then
            SRLgTxtBx.AppendText(Space(24) & "S3" & Space(9 - i) & Strings.Format(A3, "0.000"))
        End If
        i = Int(B2).ToString.Length + 4

        If optPepperday.Checked = True Then
            SRLgTxtBx.AppendText(Space(9) & "C-" & Space(9 - i))
            SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Underline)
            SRLgTxtBx.AppendText(Strings.Format(B2, "0.000"))
            SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Regular)
        End If

        If optFarley.Checked = True Then
            SRLgTxtBx.AppendText(Space(9) & "C3" & Space(9 - i))
            SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Underline)
            SRLgTxtBx.AppendText(Strings.Format(B2, "0.000"))
            SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Regular)
        End If

        If k >= 82 And k <= 98 Then
            SRLgTxtBx.AppendText("**")
        Else
            SRLgTxtBx.AppendText("  ")
        End If
        i = Int(B3).ToString.Length + 4

        If optPepperday.Checked = True Then
            SRLgTxtBx.AppendText(Space(6) & "C " & Space(9 - i) & Strings.Format(B3, "0.000"))
        End If

        If optFarley.Checked = True Then
            SRLgTxtBx.AppendText(Space(6) & "C3" & Space(9 - i) & Strings.Format(B3, "0.000"))
        End If
        i = Int(A4).ToString.Length + 4

        If optPepperday.Checked = True Then
            SRLgTxtBx.AppendText(Space(9) & "S" & Space(9 - i) & Strings.Format(A4, "0.000"))
        End If

        If optFarley.Checked = True Then
            SRLgTxtBx.AppendText(Space(9) & "S3" & Space(9 - i) & Strings.Format(A4, "0.000"))
        End If
        SRLgTxtBx.AppendText(vbNewLine)

        SRLgTxtBx.AppendText("K" & Space(13 - KDeg.ToString.Length) & Strings.Format(KDeg, "0") & Chr(176) & Strings.Format(KMin, "00") & "'")

        SRLgTxtBx.AppendText("<- <- <- <- <- <- <- <- <- ")
        i = Int(A5).ToString.Length + 4

        If optPepperday.Checked = True Then
            SRLgTxtBx.AppendText("S" & Space(9 - i) & Strings.Format(A5, "0.000"))
        End If

        If optFarley.Checked = True Then
            SRLgTxtBx.AppendText("S4" & Space(9 - i) & Strings.Format(A5, "0.000"))
        End If
        SRLgTxtBx.AppendText(vbNewLine)

        If optPepperday.Checked = True Then
            SRLgTxtBx.AppendText("lat    " & cboL.Text & Space(5 - txtLDeg.Text.ToString.Length))
            SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Underline)
            SRLgTxtBx.AppendText(Strings.Format(Val(txtLDeg.Text), "0") & Chr(176) & Strings.Format(Int(Val(txtLMin.Text) + 0.5), "00") & "'")
            SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Regular)
        End If

        If optFarley.Checked = True Then
            SRLgTxtBx.AppendText("LAT     ")
            If cboL.Text = "N" Then
                SRLgTxtBx.AppendText("+")
            End If
            If cboL.Text = "S" Then
                SRLgTxtBx.AppendText("-")
            End If
            SRLgTxtBx.AppendText(Space(5 - txtLDeg.Text.ToString.Length))
            SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Underline)
            SRLgTxtBx.AppendText(Strings.Format(Val(txtLDeg.Text), "0") & Chr(176) & Strings.Format(Int(Val(txtLMin.Text) + 0.5), "00") & "'")
            SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Regular)
        End If
        SRLgTxtBx.AppendText(vbNewLine)

        SRLgTxtBx.AppendText("K")

        If cboDec.Text = cboL.Text Then
            SRLgTxtBx.AppendText("-")
        End If

        If cboDec.Text <> cboL.Text Then
            SRLgTxtBx.AppendText("+")
        End If

        If optPepperday.Checked = True Then
            SRLgTxtBx.AppendText("lat" & Space(9 - KLDeg.ToString.Length) & Strings.Format(KLDeg, "0") & Chr(176) & Strings.Format(KLMin, "00") & "'")
        End If

        If optFarley.Checked = True Then
            SRLgTxtBx.AppendText("lat(K')" & Space(7 - KLDeg.ToString.Length) & Strings.Format(KLDeg, "0") & Chr(176) & Strings.Format(KLMin, "00") & "'")
        End If

        SRLgTxtBx.AppendText("-> -> -> -> -> -> -> -> -> -> -> -> -> -> -> ")
        i = Int(B4).ToString.Length + 4

        If optPepperday.Checked = True Then
            SRLgTxtBx.AppendText("C+" & Space(9 - i))
            SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Underline)
            SRLgTxtBx.AppendText(Strings.Format(B4, "0.000"))
            SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Regular)
        End If

        If optFarley.Checked = True Then
            SRLgTxtBx.AppendText("C5" & Space(9 - i))
            SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Underline)
            SRLgTxtBx.AppendText(Strings.Format(B4, "0.000"))
            SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Regular)
        End If
        SRLgTxtBx.AppendText(vbNewLine)

        If optPepperday.Checked = True Then
            SRLgTxtBx.AppendText("Comp. alt")
        End If

        If optFarley.Checked = True Then
            SRLgTxtBx.AppendText("Hc       ")
        End If

        If KL > 90 Then
            SRLgTxtBx.AppendText("-")
        Else
            SRLgTxtBx.AppendText(Space(1))
        End If

        SRLgTxtBx.AppendText(Space(4 - HcDeg.ToString.Length) & Strings.Format(HcDeg, "0") & Chr(176) & Strings.Format(System.Math.Abs(HcMin), "00") & "'")

        SRLgTxtBx.AppendText("<- <- <- <- <- <- <- <- <- <- <- <- <- <- <- ")
        i = Int(A6).ToString.Length + 4

        If optPepperday.Checked = True Then
            SRLgTxtBx.AppendText("S" & Space(9 - i) & Strings.Format(A6, "0.000"))
        End If

        If optFarley.Checked = True Then
            SRLgTxtBx.AppendText("S6" & Space(9 - i) & Strings.Format(A6, "0.000"))
        End If
        i = Int(B5).ToString.Length + 4

        If optPepperday.Checked = True Then
            SRLgTxtBx.AppendText(Space(9) & "C-" & Space(9 - i))
            SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Underline)
            SRLgTxtBx.AppendText(Strings.Format(B5, "0.000"))
            SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Regular)
        End If

        If optFarley.Checked = True Then
            SRLgTxtBx.AppendText(Space(9) & "C6" & Space(9 - i))
            SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Underline)
            SRLgTxtBx.AppendText(Strings.Format(B5, "0.000"))
            SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Regular)
        End If
        SRLgTxtBx.AppendText(vbNewLine)

        If optPepperday.Checked = True Then
            SRLgTxtBx.AppendText("obs.alt  ")
        End If

        If optFarley.Checked = True Then
            SRLgTxtBx.AppendText("Ho       ")
        End If

        If HoMin < 0 Then
            SRLgTxtBx.AppendText("-")
        Else
            SRLgTxtBx.AppendText(g_StrSpace)
        End If

        SRLgTxtBx.AppendText(Space(4 - txtHoDeg.Text.ToString.Length))
        SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Underline)
        SRLgTxtBx.AppendText(Strings.Format(HoDeg, "0") & Chr(176) & Strings.Format(System.Math.Abs(HoMin), "00") & "'")
        SRLgTxtBx.SelectionFont = New Font(SRLgTxtBx.Font, FontStyle.Regular)
        SRLgTxtBx.AppendText(vbNewLine)

        If optPepperday.Checked = True Then
            SRLgTxtBx.AppendText("intercept" & Space(7 - Int(System.Math.Abs(A)).ToString.Length))
        End If

        If optFarley.Checked = True Then
            SRLgTxtBx.AppendText("Doffset" & Space(9 - Int(System.Math.Abs(A)).ToString.Length))
        End If

        If System.Math.Sign(A) = 1 Then
            SRLgTxtBx.AppendText("+")
        End If

        If System.Math.Sign(A) = -1 Then
            SRLgTxtBx.AppendText("-")
        End If

        If System.Math.Sign(A) = 0 Then
            SRLgTxtBx.AppendText(g_StrSpace)
        End If

        SRLgTxtBx.AppendText(Strings.Format(Int(System.Math.Abs(A) + 0.5), "0"))
        PlotOut.PlotIntercept = Strings.Format(Int(System.Math.Abs(A) + 0.5), "0") & " nm "
        If optPepperday.Checked = True Then
            If HcDecimal < Ho Then
                SRLgTxtBx.AppendText(" Toward")
                PlotOut.PlotIntercept &= "Toward"
            End If
            If HcDecimal > Ho Then
                SRLgTxtBx.AppendText(" Away")
                PlotOut.PlotIntercept &= " Away"
            End If
            If HcDecimal = Ho Then
                SRLgTxtBx.AppendText(g_StrSpace)
                PlotOut.PlotIntercept &= " Toward"
            End If
        End If
        If optFarley.Checked = True Then
            If System.Math.Sign(A) = -1 Then
                SRLgTxtBx.AppendText("(Away)")
                PlotOut.PlotIntercept &= " Away"
            End If
            If System.Math.Sign(A) = 1 Then
                SRLgTxtBx.AppendText("(Toward)")
                PlotOut.PlotIntercept &= " Toward"
            End If
            If System.Math.Sign(A) = 0 Then
                SRLgTxtBx.AppendText(g_StrSpace)
                PlotOut.PlotIntercept &= " Toward"
            End If
        End If
        PlotOut.PlotAz = Strings.Format(ZN, "000") & Chr(176)

        If optPepperday.Checked = True Then
            SRLgTxtBx.AppendText("  Azimuth" & Space(1) & Strings.Format(ZN, "000") & Chr(176) & " <- <- <- ")
        End If

        If optFarley.Checked = True Then
            SRLgTxtBx.AppendText("  Zn" & Space(1) & Strings.Format(ZN, "000") & Chr(176) & " <- <- <- ")
        End If

        If optPepperday.Checked = True Then
            SRLgTxtBx.AppendText("Mer. Bg. " & cboL.Text & Space(1) & Strings.Format(Z, "0") & Chr(176))
        End If

        If optFarley.Checked = True Then
            SRLgTxtBx.AppendText("  Zo " & cboL.Text & Space(1) & Strings.Format(Z, "0") & Chr(176))
        End If

        If LHA <= 180 Then SRLgTxtBx.AppendText(" W" & " <- <- <- <- <-")

        If LHA > 180 Then SRLgTxtBx.AppendText(" E" & " <- <- <- <- <-")
        i = Int(A7).ToString.Length + 4

        If optPepperday.Checked = True Then SRLgTxtBx.AppendText(" S " & Space(9 - i) & Strings.Format(A7, "0.000"))
        If optFarley.Checked = True Then SRLgTxtBx.AppendText(" S7 " & Space(9 - i) & Strings.Format(A7, "0.000"))
        SRLgTxtBx.AppendText(vbNewLine)

        'Print ': Print
        AlignCenterRTB(SRLgTxtBx)
        SRLgTxtBx.AppendText("EP L " & Strings.Format(EstLDeg, "0") & Chr(176) & Strings.Format(EstLMin, "00.0") & "'")
        PlotOut.PlotSLEP = "EP L " & Strings.Format(EstLDeg, "0") & Chr(176) & Strings.Format(EstLMin, "00.0") & "'"
        If EstL > 0 Then
            SRLgTxtBx.AppendText(g_LatN)
            PlotOut.PlotSLEP &= g_LatN
            PlotOut.PlotLatNS = g_LatN
        End If
        If EstL = 0 Then
            SRLgTxtBx.AppendText(g_StrSpace)
            PlotOut.PlotSLEP &= g_LatN
            PlotOut.PlotLatNS = g_LatN
        End If
        If EstL < 0 Then
            SRLgTxtBx.AppendText(g_LatS)
            PlotOut.PlotSLEP &= g_LatS
            PlotOut.PlotLatNS = g_LatS
        End If

        SRLgTxtBx.AppendText("      EP Lo " & Strings.Format(EstLoDeg, "0") & Chr(176) & Strings.Format(EstLoMin, "00.0") & "'")
        PlotOut.PlotSLEP &= " EP Lo " & Strings.Format(EstLoDeg, "0") & Chr(176) & Strings.Format(EstLoMin, "00.0") & "'"
        If EstLo > 0 Then
            SRLgTxtBx.AppendText(g_LongW)
            PlotOut.PlotSLEP &= g_LongW
            PlotOut.PlotLongEW = g_LongW
        End If
        If EstLo = 0 Then
            SRLgTxtBx.AppendText(g_StrSpace)
            PlotOut.PlotSLEP &= g_LongW
            PlotOut.PlotLongEW = g_LongW
        End If
        If EstLo < 0 Then
            SRLgTxtBx.AppendText(g_LongE)
            PlotOut.PlotSLEP &= g_LongE
            PlotOut.PlotLongEW = g_LongE
        End If
        SRLgTxtBx.AppendText(vbNewLine)
        AlignLeftRTB(SRLgTxtBx)


        SRLgTxtBx.AppendText("*Table entry values")
        If k >= 82 And k <= 98 Then
            SRLgTxtBx.AppendText(Space(4) & "**If K is between 82" & Chr(176) & " and 98" & Chr(176) & " this C is interpolated.")
        End If
        SRLgTxtBx.AppendText(vbNewLine)

        SRLgTxtBx.Refresh()

    End Sub
    Private Sub SelectAllText(ByRef TB As System.Windows.Forms.TextBox)
        TB.SelectionStart = 0
        TB.SelectionLength = TB.Text.ToString.Length
    End Sub
    Public Sub SetTxtBxUlineOn(ByRef TB As System.Windows.Forms.RichTextBox)
        TB.SelectionFont = New Font(TB.Font, FontStyle.Underline)
    End Sub
    Public Sub SetTxtBxBoldOn(ByRef TB As System.Windows.Forms.RichTextBox)
        TB.SelectionFont = New Font(TB.Font, FontStyle.Bold)
    End Sub
    Public Sub SetTxtBxtoReg(ByRef TB As System.Windows.Forms.RichTextBox)
        TB.SelectionFont = New Font(TB.Font, FontStyle.Regular)
    End Sub
    Public Sub AlignCenterRTB(ByRef TB As System.Windows.Forms.RichTextBox)
        TB.SelectionAlignment = HorizontalAlignment.Center
        Exit Sub
    End Sub
    Public Sub AlignLeftRTB(ByRef TB As System.Windows.Forms.RichTextBox)
        TB.SelectionAlignment = HorizontalAlignment.Left
        Exit Sub
    End Sub
    'Public Sub AlignRightRTB(ByRef TB As System.Windows.Forms.RichTextBox)
    '    TB.SelectionAlignment = HorizontalAlignment.Right
    '    Exit Sub
    'End Sub
    Public Sub ClearAllRptTextBx()
        SRHdrTxtBx.Visible = False
        SRHdrTxtBx.Clear()
        SRHdrTxtBx.SendToBack()

        SRLgTxtBx.Clear()
        SRLgTxtBx.Visible = False
        SRLgTxtBx.SendToBack()

        SRLeftTxtBx.Clear()
        SRLeftTxtBx.Visible = False
        SRLeftTxtBx.SendToBack()

        SRRightTxtBx.Clear()
        SRRightTxtBx.Visible = False
        SRRightTxtBx.SendToBack()

        NASRAsmTxtBx.Clear()
        NASRAsmTxtBx.Visible = False
        NASRAsmTxtBx.SendToBack()

        NASRAFTxtBx.Clear()
        NASRAFTxtBx.Visible = False
        NASRAFTxtBx.SendToBack()

        DCorrTxtBx.Clear()
        DCorrTxtBx.Visible = False
        DCorrTxtBx.SendToBack()
        Exit Sub
    End Sub
    Private Sub ErrorMsgBox(ByVal ErrMsg As String)
        System.Windows.Forms.MessageBox.Show(ErrMsg, "Error",
                                                System.Windows.Forms.MessageBoxButtons.OK,
                                                System.Windows.Forms.MessageBoxIcon.Error,
                                                System.Windows.Forms.MessageBoxDefaultButton.Button1,
                                                System.Windows.Forms.MessageBoxOptions.DefaultDesktopOnly)
        Exit Sub
    End Sub

    Private Sub btnUseCLS_Click(sender As Object, e As EventArgs) Handles btnUseCLS.Click
        PlotOut.PsnName = "Alt SR Method"
        PlotOut.SquadronName = "Alt SR Method"
        PlotOut.PlotType = "Sight"

        txtSightNum += 1
        PlotOut.PlotNumber = txtSightNum.ToString("##0")
        PlotOut.PlotDT = DTSight.Value
        PlotOut.PlotLLoBy = cboLLoBy.Text.ToString
        If InvokedbySightLog = True Then
            PlotOut.PlotBody = cboBody.Text.ToString.Trim
            If PlotOut.PlotBody = "Sun" Or PlotOut.PlotBody = "Moon" Then
                PlotOut.PlotBody &= " " & cbLimb.Text.ToString.Trim
            End If
        Else
            PlotOut.PlotBody = txtSightNum.ToString("##0") & " AltSRBody"
        End If

        PlotOut.PlotLat = Convert.ToDouble(txtLDeg.Text) + (Convert.ToDouble(txtLMin.Text) / 60.0)
        PlotOut.PlotLatDeg = txtLDeg.Text
        PlotOut.PlotLatMin = txtLMin.Text
        PlotOut.PlotLatSec = "0"
        PlotOut.PlotLatNS = cboL.Items(cboL.SelectedIndex).ToString.Trim

        PlotOut.PlotLong = Convert.ToDouble(txtLoDeg.Text) + (Convert.ToDouble(txtLoMin.Text) / 60.0)
        PlotOut.PlotLongDeg = txtLoDeg.Text
        PlotOut.PlotLongMin = txtLoMin.Text
        PlotOut.PlotLongSec = "0"
        PlotOut.PlotLongEW = cboLo.Items(cboLo.SelectedIndex).ToString.Trim

        PlotOut.PlotIntercept = System.Math.Abs(KPLOPDist).ToString("#0.0") & "nm"
        If KPLOPDist > 0 Then
            PlotOut.PlotIntercept &= " Away"
        Else
            PlotOut.PlotIntercept &= " Toward"
        End If
        PlotOut.PlotExtendedLines = True
        PlotOut.PlotSLEP = "EP L " & EstLDeg.ToString("#0") & Chr(176) & EstLMin.ToString("00.0") & "' " & PlotOut.PlotLatNS & " " &
                                "EP Lo " & EstLoDeg.ToString("##0") & Chr(176) & EstLoMin.ToString("00.0") & "' " & PlotOut.PlotLongEW
        Dim PlotSave As CLSForm.PlotEntry = PlotOut
        CLSForm.AddPlotEntry(PlotOut)

        ' if this is NOT a Law of Cosines sight reduction (it is a tabular ALT SR Method) then format Assumed Position and its intercept
        If LOCSight = False Then
            txtSightNum += 1
            PlotOut.PlotNumber = txtSightNum.ToString("##0")
            PlotOut.PlotDT = DTSight.Value
            PlotOut.PlotLLoBy = "AP"
            If InvokedbySightLog = True Then
                PlotOut.PlotBody = cboBody.Text.ToString.Trim
                If PlotOut.PlotBody = "Sun" Or PlotOut.PlotBody = "Moon" Then
                    PlotOut.PlotBody &= " " & cbLimb.Text.ToString.Trim
                End If
            Else
                PlotOut.PlotBody = txtSightNum.ToString("##0") & " AltSRBody"
            End If
            Dim tmpLatD As Double = APEstL
            PlotOut.PlotLat = System.Math.Abs(AsmL)
            PlotOut.PlotLatDeg = System.Math.Abs(AsmL).ToString("#0")
            PlotOut.PlotLatMin = "00.0"
            PlotOut.PlotLatSec = "0"
            If APEstL > 0 Then
                PlotOut.PlotLatNS = g_LatN
            Else
                PlotOut.PlotLatNS = g_LatS
            End If

            PlotOut.PlotLong = AsmLo
            PlotOut.PlotLongDeg = AsmLoDeg.ToString("##0")
            PlotOut.PlotLongMin = AsmLoMin.ToString("00.0")
            PlotOut.PlotLongSec = "0"
            If APEstLo >= 0 Then
                PlotOut.PlotLongEW = g_LongW
            Else
                PlotOut.PlotLongEW = g_LongE
            End If

            ' these next three fields are formatted in each of the separate calculation routines and formated in the PlotOut structure
            'PlotOut.PlotAz = Ztot.ToString("##0.0") & Chr(176)
            PlotOut.PlotIntercept = System.Math.Abs(A).ToString("#0.0") & "nm"
            If A > 0 Then
                PlotOut.PlotIntercept &= " Away"
            Else
                PlotOut.PlotIntercept &= " Toward"
            End If
            PlotOut.PlotSLEP = "EP L " & APEstLDeg.ToString("#0") & Chr(176) & APEstLMin.ToString("00.0") & "' " & PlotOut.PlotLatNS & " " &
                                "EP Lo " & APEstLoDeg.ToString("##0") & Chr(176) & APEstLoMin.ToString("00.0") & "' " & PlotOut.PlotLongEW

            CLSForm.AddPlotEntry(PlotOut)
        End If

        CLSForm.txtUserInfo.Text = Me.txtUserInfo.Text
        If CLSForm.PlotSight() = True Then
            CLSForm.Show()
            CLSForm.SetDesktopLocation(5,5) '
            CLSForm.BringToFront()
        End If
        ' restore original PlotOut since an AP may have been done over the top of it
        PlotOut = PlotSave
        Exit Sub
    End Sub
    Private Sub btnCustomPlot_Click(sender As Object, e As EventArgs) Handles btnCustomPlot.Click
        PlotOut.PsnName = "Alt SR Method"
        PlotOut.SquadronName = "Alt SR Method"
        PlotOut.PlotType = "Sight"

        txtSightNum += 1
        PlotOut.PlotNumber = txtSightNum.ToString("##0")
        PlotOut.PlotDT = DTSight.Value
        PlotOut.PlotLLoBy = cboLLoBy.Text.ToString
        If InvokedbySightLog = True Then
            PlotOut.PlotBody = cboBody.Text.ToString.Trim
            If PlotOut.PlotBody = "Sun" Or PlotOut.PlotBody = "Moon" Then
                PlotOut.PlotBody &= " " & cbLimb.Text.ToString.Trim
            End If
        Else
            PlotOut.PlotBody = txtSightNum.ToString("##0") & " AltSRBody"
        End If

        PlotOut.PlotLat = Convert.ToDouble(txtLDeg.Text) + (Convert.ToDouble(txtLMin.Text) / 60.0)
        PlotOut.PlotLatDeg = txtLDeg.Text
        PlotOut.PlotLatMin = txtLMin.Text
        PlotOut.PlotLatSec = "0"
        PlotOut.PlotLatNS = cboL.Items(cboL.SelectedIndex).ToString.Trim

        PlotOut.PlotLong = Convert.ToDouble(txtLoDeg.Text) + (Convert.ToDouble(txtLoMin.Text) / 60.0)
        PlotOut.PlotLongDeg = txtLoDeg.Text
        PlotOut.PlotLongMin = txtLoMin.Text
        PlotOut.PlotLongSec = "0"
        PlotOut.PlotLongEW = cboLo.Items(cboLo.SelectedIndex).ToString.Trim

        PlotOut.PlotIntercept = System.Math.Abs(KPLOPDist).ToString("#0.0") & "nm"
        If KPLOPDist > 0 Then
            PlotOut.PlotIntercept &= " Away"
        Else
            PlotOut.PlotIntercept &= " Toward"
        End If
        PlotOut.PlotExtendedLines = True
        Dim PlotSave As CLSForm.PlotEntry = PlotOut
        CustomPlot.AddPlotEntry(PlotOut)

        If LOCSight = False Then
            txtSightNum += 1
            PlotOut.PlotNumber = txtSightNum.ToString("##0")
            PlotOut.PlotDT = DTSight.Value
            PlotOut.PlotLLoBy = "AP"
            If InvokedbySightLog = True Then
                PlotOut.PlotBody = cboBody.Text.ToString.Trim
                If PlotOut.PlotBody = "Sun" Or PlotOut.PlotBody = "Moon" Then
                    PlotOut.PlotBody &= " " & cbLimb.Text.ToString.Trim
                End If
            Else
                PlotOut.PlotBody = txtSightNum.ToString("##0") & " AltSRBody"
            End If
            Dim tmpLatD As Double = APEstL
            PlotOut.PlotLat = System.Math.Abs(AsmL)
            PlotOut.PlotLatDeg = System.Math.Abs(AsmL).ToString("#0")
            PlotOut.PlotLatMin = "00.0"
            PlotOut.PlotLatSec = "0"
            If APEstL > 0 Then
                PlotOut.PlotLatNS = g_LatN
            Else
                PlotOut.PlotLatNS = g_LatS
            End If

            PlotOut.PlotLong = AsmLo
            PlotOut.PlotLongDeg = AsmLoDeg.ToString("##0")
            PlotOut.PlotLongMin = AsmLoMin.ToString("00.0")
            PlotOut.PlotLongSec = "0"
            If APEstLo >= 0 Then
                PlotOut.PlotLongEW = g_LongW
            Else
                PlotOut.PlotLongEW = g_LongE
            End If

            ' these next three fields are formatted in each of the separate calculation routines and formated in the PlotOut structure
            'PlotOut.PlotAz = Ztot.ToString("##0.0") & Chr(176)
            PlotOut.PlotIntercept = System.Math.Abs(A).ToString("#0.0") & "nm"
            If A > 0 Then
                PlotOut.PlotIntercept &= " Away"
            Else
                PlotOut.PlotIntercept &= " Toward"
            End If
            PlotOut.PlotSLEP = "EP L " & APEstLDeg.ToString("#0") & Chr(176) & APEstLMin.ToString("00.0") & "'" & PlotOut.PlotLatNS & " " &
                                "EP Lo " & APEstLoDeg.ToString("##0") & Chr(176) & APEstLoMin.ToString("00.0") & "'" & PlotOut.PlotLongEW

            CustomPlot.AddPlotEntry(PlotOut)
        End If

        CustomPlot.txtUserInfo.Text = Me.txtUserInfo.Text
        If CustomPlot.PlotSight() = True Then
            CustomPlot.Show()
            CustomPlot.SetDesktopLocation(5,5) '
            CustomPlot.BringToFront()
        End If
        PlotOut = PlotSave
        Exit Sub
    End Sub
    Public Shared Function CheckOpenWinForms(ByVal FormNameIn As String) As Boolean
        For Each frm As Form In Application.OpenForms
            If frm.Name.Equals(FormNameIn, StringComparison.CurrentCulture) Then
                Return True
                Exit Function
            End If
        Next
        Return False
        Exit Function
    End Function
    Public Sub SendMsgBx(ByVal SendStr As String, ByVal IconType As MessageBoxIcon)
        ' this subroutine is required because issuing a raw SendMsgBx call also trigger a Paint event for graphic box on form which cannot be handled properly in error conditions
        'IssuingSendMsgBx = True
        Dim HdrStr As String = vbNullString
        'HdrStr = IconType.ToString
        If IconType = MessageBoxIcon.Error Then
            HdrStr = "Input Error"
        ElseIf IconType = MessageBoxIcon.Warning Then
            HdrStr = "Warning Message"
        ElseIf IconType = MessageBoxIcon.Information Then
            HdrStr = "Information Message"
        ElseIf IconType = MessageBoxIcon.Stop Then
            HdrStr = "STOP - Program Error"
        Else
            HdrStr = "General Message"
        End If
        System.Windows.Forms.MessageBox.Show(SendStr, HdrStr,
                                                System.Windows.Forms.MessageBoxButtons.OK,
                                                IconType,
                                                System.Windows.Forms.MessageBoxDefaultButton.Button1,
                                                System.Windows.Forms.MessageBoxOptions.DefaultDesktopOnly)
        Me.Show()
        Exit Sub
    End Sub
End Class