Option Strict Off
Option Explicit On
Imports System.ComponentModel
Imports System.Net.Http.Headers
Imports System.Windows.Forms.DataVisualization.Charting
Imports VB = Microsoft.VisualBasic
Friend Class FormNoonSight
    Inherits System.Windows.Forms.Form
    Public InitLoadComplete As Boolean = False
    Public InvokedBySightLog As Boolean = False
    Dim Lo, Pi As Double
    Dim ZD As Integer
    Dim DateOfSight As String
    Dim ZTinSeconds As Integer
    Dim i As Short
    Dim JD, DecimalDateHour1, DecimalDate, DecimalDateHour2, T As Double
    Dim TP, GA, HG, Lat As Double
    Dim HD, MonthList, SignZD, MonthatG, fnumeral As String
    Dim MonthDays As String
    Dim GYearJ As Short
    Dim JDHour1, JDHour2 As Double
    Dim GDayOfYear, GHour, DayNumber, GHourLAN As Short
    Dim GMinute, GSecond As Integer
    Dim LocalYear, GDay, GMonth, GYear, MonthNumber As Short
    Dim ZDinSeconds, UTinSeconds As Integer
    Dim LeapYear, GLeapYear As Boolean
    Dim L, C, OE, LMin As Double
    Dim LH, dh As String
    Dim LDeg As Short
    Dim B, MS As Double
    Dim NL, NO As Double
    Dim WM, LR, GR, VM, QM As Double
    Dim WD, QD As Short
    Dim VD As Double
    Dim RN, LN, NU As Double
    Dim AR As Double = 0
    Dim x, y, DE As Double
    Dim SH As Double
    Dim GRD As Short
    Dim RstdTP, Rstd, Main_Renamed, Raddl, RstdA2 As Double
    Dim RA, GRM, DF As Double
    Dim DateError As Boolean
    Dim LANMinutes, LANSeconds As Short
    Dim hsinMinutes, ICinMinutes, hainMinutes As Double
    Dim Corr1, Corr1Min As Double
    Dim Corr1Deg As Short
    Dim BackSight As Boolean
    Dim PA, HP, r As Double
    Dim HoMin, Corr2Min, HoinMinutes, HoDeg As Double
    Dim PX, DI, TX, DecMinutes As Double
    Dim DecDegrees As Double
    Dim haDeg As Short
    Dim HsMin, Pressure, HEinFeet, haMin, HE, Temperature, DipShortDist, ICMin As Double
    Dim ZenithDistinDeg, ZenithDistMin As Double
    Dim ZenithDistDeg As Short
    Dim ZDMan, DRL As Double
    Dim ZDManinSeconds As Integer
    Dim SunAzN, SunAzS As Boolean
    Dim Ldiff As Double
    Dim EW As String
    Dim DecYr, Theta As Single
    Dim TLANObsSec As Integer
    Dim Flag3, Flag, Flag2 As Boolean
    Dim DeltaT As Double ', FlagLAN As Boolean, Flag2 As Boolean
    Dim DE1, THour1, THour2, DE2 As Double
    Dim dvalue, dcorr As Double
    Dim Signdvalue As Short
    Dim TotDecDegrees, Lendcorr As Short
    Dim TotDE, TotDecMinutes, LoforLAN As Double
    Dim GHADeg, LoforLANDeg As Short
    Dim GHAMin, LoforLANMin As Double
    Dim LANTime, GHADiff, GHADiffMin, ZTofLAN, EQTZTofLAN As Double
    Dim GHADiffDeg As Short
    Dim ZTofLANMinutes, ZTofLANHours, ZTofLANSeconds As Short
    Dim EQTZTofLANMinutes, EQTZTofLANHours, EQTZTofLANSeconds As Short
    Dim GHAAriesHour, GHAHour As Double
    Dim NutF, NutM, NutD, NutMprime, NutOmega As Double
    Dim NCos(64), NSin(64), NF(64), NM(64), ND(64), NMprime(64), NOmega(64), NSinT(64), NCosT(64) As Integer
    Dim L1, Ecc, OETrue, L0, JDHour As Double
    Dim DRLMin, LoMin As String
    Dim RH As Double
    Dim SunHourChange, GHAHour1, GHAHour2, SunGHACorr As Double
    Dim GHourLANDisplay, ZTofLANHoursDisplay As Short
    Dim StarDayNumber As Short
    ' Added March 2017 as part of conversion to DotNet - added bitmap to implement new graphics code in meridian diagram routine
    Dim bm As Bitmap
    Dim BMFname As String = "./Graphics/Noonsight.jpg"
    Dim meridgraphic As Graphics
    'Dim FormNoonSightLoaded As Boolean = False
    Dim IssuingSendMsgBx As Boolean = False
    Public Structure EqTimeRec
        Public EqtLat As String
        Public EqtLong As String
        Public EqTimeDate As String
        Public EqTZTLAN As String
        Public EqTimeFactor As String
        Public EqTimeDec As String
        Public EqTimeHo As String
    End Structure
    'Public EqtimeTbl() As EqTimeRec
    Public EqTimeFname As String = "./HelpFiles/EQofTimeData.txt"
    Public ArrCt As Integer = 0
    Public SaveSunMeanEquLo As Double = 0
    Public SaveSunRightAsc As Double = 0
    Public EqTFactor As Double = 0
    Public EqTimeFactorMin As Integer = 0
    Public EqTimeFactorSec As Integer = 0
    Public EqtTable() As EqTimeRec
    Public MTTable() As EqTimeRec
    Public DTInput As DateTime

    Private Sub ClearTimeTxt()
        txtTime.Clear()
        txtCalcHo.Clear()
        'txtEqTime.Clear()
        LANTimeTxtBx.Clear()
        Exit Sub
    End Sub
    Private Sub cboDRL_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDRL.SelectedIndexChanged
        ClearTimeTxt()
        cmdNoonSight.Visible = False
        OldFormBtn.Visible = False
        NewFormBtn.Visible = False
        lblN.Visible = False
        lblS.Visible = False
        lblZ.Visible = False

        Exit Sub
    End Sub
    Private Sub cboLo_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboLo.SelectedIndexChanged
        ClearTimeTxt()
        cmdNoonSight.Visible = False
        OldFormBtn.Visible = False
        NewFormBtn.Visible = False
        lblN.Visible = False
        lblS.Visible = False
        lblZ.Visible = False
        AutoZDCalc()
    End Sub
    Private Sub cboZDm_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboZDm.SelectedIndexChanged
        'ClearScreen()
        ClearTimeTxt()
        cmdNoonSight.Visible = False
        OldFormBtn.Visible = False
        NewFormBtn.Visible = False
        lblN.Visible = False
        lblS.Visible = False
        lblZ.Visible = False
    End Sub
    Private Sub chkDST_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkDST.CheckStateChanged
        'ClearScreen()
        'ClearTimeTxt()

        'cmdNoonSight.Visible = False
        'OldFormBtn.Visible = False
        'NewFormBtn.Visible = False
        'lblN.Visible = False
        'lblS.Visible = False
        'lblZ.Visible = False
        ''txtLoMin.ForeColor = &H80000008
        'txtLoMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)

    End Sub

    Private Sub LongitudeByLAN()
        Flag2 = True
        DTInput = DTNoonSight.Value
        ZTinSeconds = (3600 * DTInput.Hour) + (60 * DTInput.Minute) + DTInput.Second - ((ZD - ZDMan) * 3600)
        Greenwich()
        Delta_T()
        Julian()
        Nutation()
        Obliquity()
        Aries()
        Sun()

        GA = GR - AR
        If GA >= 360 Or GA < 0 Then
            GA = GA - Int(GA / 360) * 360
        End If
        EW = g_LongW
        If GA > 180 Then
            GA = 360 - GA
            EW = g_LongE
        End If
        VD = Int(GA)
        VM = (GA - VD) * 60
        VM = Int(VM * 10 + 0.5) / 10
        If VM = 60 Then
            VM = 0
            VD = VD + 1
        End If
        If (VD = 0 Or VD = 180) And VM = 0 Then
            EW = ""
        End If
        Flag2 = False
    End Sub
    Private Sub DisplayLongitudeByDTInput()
        LongitudeCalcTxtBx.Text = vbNullString
        LongitudeCalcTxtBx.AppendText("Longitude from observed ZT of LAN " & VD.ToString("0") & Chr(176) & VM.ToString("00.0") & "'" & EW)
    End Sub
    Private Sub cmdLAN_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdLAN.Click
        If txtDRLDeg.Text = "" Then
            txtDRLDeg.Text = "0"
        End If
        If txtLoDeg.Text = "" Then
            txtLoDeg.Text = "0"
        End If
        If txtDRLMin.Text = "" Then
            txtDRLMin.Text = "0"
        End If
        If txtLoMin.Text = "" Then
            txtLoMin.Text = "0"
        End If
        DTInput = New Date(DTNoonSight.Value.Year, DTNoonSight.Value.Month, DTNoonSight.Value.Day, 12, 0, 0)
        'DTInput = DTNoonSight.Value
        LAN()
        GHourLAN = GHour
        GHourLANDisplay = GHour
        ZTofLANHoursDisplay = ZTofLANHours
        EqTFactor = 4 * (SaveSunMeanEquLo - SaveSunRightAsc)
        DisplayLANTime()
        txtTime.Text = ZTofLANHours.ToString("00") & ":" & ZTofLANMinutes.ToString("00") & ":" & ZTofLANSeconds.ToString("00")

        '    FormNoonSight.MousePointer = 0
        cmdNoonSight.Visible = True
        OldFormBtn.Visible = True
        NewFormBtn.Visible = True
        Flag = True
        'FlagLAN = False
        txtTime.Visible = True
        txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        Dim TmpLat As Double = Convert.ToDouble(txtDRLDeg.Text) + Convert.ToDouble(txtDRLMin.Text) / 60
        'If cboDRL.Items(cboDRL.SelectedIndex).ToString = g_LatS Then
        If cboDRL.Text.ToString.Trim = g_LatS Then
            TmpLat = -1 * TmpLat
        End If
        Dim TempHo As Double = 90 - (TmpLat - DE)
        If cboDRL.Text.ToString.Trim = g_LatS Then
            TempHo = 180 - TempHo
        End If
        Dim TempHoDeg As Integer = Int(TempHo)
        Dim TempHoMin As Double = ((TempHo - TempHoDeg) * 60)
        Dim TempHoStr As String = TempHoDeg.ToString("#0") & Chr(176) & " " & TempHoMin.ToString("#0.0") & "'"
        txtCalcHo.Text = TempHoStr
        'BuildEqtTable()
        btnDisplayEQTData.Visible = True
        Exit Sub
    End Sub
    Private Sub LAN()
        Flag2 = True
        'LANTimeTxtBx.Text = vbNullString
        'txtTime.Text = vbNullString
        lblN.Visible = False
        lblS.Visible = False
        lblZ.Visible = False

        AutoZDCalc()
        Longitude()
        If cboLo.Text = "W" Then
            LoforLAN = Lo
        Else
            LoforLAN = 360 - System.Math.Abs(Lo)
        End If
        ZTinSeconds = 43200 ' 43,200 in seconds is the same as 12 hr 0 min 0 sec - this effectively sets the time at noon
        'DTInput = DTNoonSight.Value
        Greenwich()
        Delta_T()
        Julian()
        Nutation()
        Obliquity()
        Aries()
        Sun()
        GHADec()

        GHADiff = LoforLAN - GA
        If GHADiff < 0 Then
            GHADiff = GHADiff + 360
        End If

        If GHADiff >= 15 Then
            ZTinSeconds = 39600 '11h instead of 12h noon as ZT
            'DTInput = DTNoonSight.Value
            Greenwich()
            Delta_T()
            Julian()
            Nutation()
            Obliquity()
            Aries()
            Sun()
            GHADec()
            GHADiff = LoforLAN - GA
            If GHADiff < 0 Then GHADiff = 360 + GHADiff
        End If

        SaveSunMeanEquLo = LN ' Save Off for Eqt Time calc
        SaveSunRightAsc = AR + C ' Save off Sun Ra + C for EqT Calc

        GHADeg = Int(GA)
        GHAMin = (GA - GHADeg) * 60
        If GHAMin >= 60 Then
            GHAMin = GHAMin - 60
            GHADeg = GHADeg + 1
        End If
        If GHADeg >= 360 Then
            GHADeg = GHADeg - 360
        End If

        Me.Cursor = System.Windows.Forms.Cursors.Default
        Flag2 = False
    End Sub

    Private Sub cmdNoonSight_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNoonSight.Click 'This change was made in V4.9.0 as the easiest way to make Noon Sight without first calculating ZT of LAN work properly.  Fix was wrong in V4.6.1.
        ExecNoonSightCmd()
        Exit Sub
    End Sub

    Public Sub ExecNoonSightCmd()
        Flag3 = False 'Flag3 used to prevent Sub from continuing if there are messages
        DTInput = New Date(DTNoonSight.Value.Year, DTNoonSight.Value.Month, DTNoonSight.Value.Day, 12, 0, 0) ' set DT for Greenwich in LAB sub to noon on ZT input
        LAN()
        DTInput = DTNoonSight.Value ' set the DT for Noonsight sub calcs to the ZT input on form
        NoonSight()
        If Flag3 = True Then Exit Sub 'this line was after second NoonSight, but it allowed a second message
        'NoonSight() 'need this so don't need second click - not sure why this is needed but I left it in because it is so strange and when removed was not certain noonsight was working
        DisplayLANTime()
        DisplayNoonSight()
        DisplayMeridianDiagram()
        DisplayLongitudeByDTInput()
    End Sub
    Private Sub NoonSight()
        Flag2 = True
        Longitude() 'Added as part of European comma as decimal separator solution
        If cboIE.Text = "off the arc (rdg.)" And Val(txtIEdeg.Text) = 0 Then
            ErrorMsgBox("For IE off the arc (rdg.), degree value cannot be zero.", "Input Error", MessageBoxButtons.OK)
            Flag3 = True
            Exit Sub
        End If
        If optLower.Checked = True Then
            If optHorizonBubble.Checked = True Then
                SendMsgBx("Caution:  Improper combination of lower limb and bubble horizon.")
                Flag3 = True
                Exit Sub
            End If
        End If
        If optUpper.Checked = True Then
            If optHorizonBubble.Checked = True Then
                SendMsgBx("Caution:  Improper combination of upper limb and bubble horizon.")
                Flag3 = True
                Exit Sub
            End If
        End If
        If optCenter.Checked = True Then
            If (optHorizonNatural.Checked = True Or optHorizonDipShort.Checked = True) Then
                SendMsgBx("Caution:  Improper combination of center and natural or dip short horizon.")
                Flag3 = True
                Exit Sub
            End If
        End If

        ZDinSeconds = 3600 * System.Math.Sign(ZD) * Int(Lo / 15) 'goes back to normal ZD without (Lo + 1) correction in Greenwich
        ZTinSeconds = 3600 * Val(VB.Left(txtTime.Text, 2)) + 60 * Val(Mid(txtTime.Text, 3, 2)) + Val(VB.Right(txtTime.Text, 2))
        'ZTinSeconds = (3600 * DTInput.Hour) + (60 * DTInput.Minute) + DTInput.Second - ((ZD - ZDMan) * 3600)
        UTinSeconds = ZTinSeconds + (ZDinSeconds - ZDManinSeconds)
        If chkDST.CheckState = 1 Then
            UTinSeconds = UTinSeconds - 3600
        End If
        'Greenwich()
        'Delta_T()
        'Julian()
        'T = THour1
        'JDHour = JDHour1
        'Nutation()
        'Obliquity()
        'Aries()
        'Sun()
        'DE1 = DE
        'HourAnglesHour()
        'GHAHour1 = GHAHour

        'Greenwich()
        'Delta_T()
        'Julian()
        'T = THour2
        'JDHour = JDHour2
        'Nutation()
        'Obliquity()
        'Aries()
        'Sun()
        'DE2 = DE
        'HourAnglesHour()
        'GHAHour2 = GHAHour

        GHADec()
        IandC()
        If optAzN.Checked = False And optAzS.Checked = False And optDRL.Checked = False Then
            ErrorMsgBox("You must select a sun azimuth or DR L at LAN.", "Input Error", MessageBoxButtons.OK)
            Flag3 = True
            Exit Sub
        End If
        If optHorizonDipShort.Checked = True And Val(txtDsDist.Text) = 0 Then
            txtDsDist.Focus()
            ErrorMsgBox("You must enter a non-zero value for Ds distance", "Input Error", MessageBoxButtons.OK)
            Flag3 = True
            Exit Sub
            '        End If
        End If
        If Flag3 = True Then
            Exit Sub
        End If
        AltitudeCorrection()
        DecDegrees = Int(System.Math.Abs(DE1))
        DecMinutes = (System.Math.Abs(DE1) - DecDegrees) * 60
        If Val(VB.Left(txtTime.Text, 2)) > ZTofLANHours Then
            DecDegrees = Int(System.Math.Abs(DE2))
            DecMinutes = (System.Math.Abs(DE2) - DecDegrees) * 60
        End If
        If Int(DecMinutes * 10 + 0.5) / 10 = 60 Then
            DecMinutes = 0
            DecDegrees = DecDegrees + 1
        End If
        ZenithDistinDeg = (5400 - HoinMinutes) / 60
        ZenithDistDeg = Int(ZenithDistinDeg)
        ZenithDistMin = (ZenithDistinDeg - ZenithDistDeg) * 60
        ZenithDistMin = Int(ZenithDistMin * 10 + 0.5) / 10
        If ZenithDistMin = 60 Then
            ZenithDistMin = 0
            ZenithDistDeg = ZenithDistDeg + 1
        End If
        LatCalc()
        LongitudeByLAN()

        GHourLAN = Val(VB.Left(txtTime.Text, 2)) + ZDMan 'ZDMan was ZD; changed in V5.4.0
        Flag2 = False
        Exit Sub
    End Sub

    Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
        PrintScreen(Me.Bounds)
        Me.Focus()
    End Sub

    Private Sub ExitNoonSight_Click(sender As Object, e As EventArgs) Handles ExitNoonSight.Click
        If InvokedBySightLog = True Then
            SightLog.FormNoonSightLoaded = False
            InvokedBySightLog = False
        End If

        Cleanup()
        Close()
    End Sub
    Private Sub Form_Initialize_Renamed()
        Pi = 4 * System.Math.Atan(1.0#)
        cboLo.SelectedIndex = 0 ' g_LongW
        cboDRL.SelectedIndex = 0 ' g_LatN
        txtZDh.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000F)
        'txtTime.BackColor = &H8000000F
        cboZDm.SelectedIndex = 0 ' "00"
        'AriesFlag = False

        'nutation in longitude and obliquity
        ND = New Integer() {0, -2, 0, 0, 0, 0, -2, 0, 0, -2, -2, -2, 0, 2, 0, 2, 0, 0, -2, 0, 2, 0, 0, -2, 0, -2, 0, 0, 2, -2, 0, -2, 0, 0, 2, 2, 0, -2, 0, 2, 2, -2, -2, 2, 2, 0, -2, -2, 0, -2, -2, 0, -1, -2, 1, 0, 0, -1, 0, 0, 2, 0, 2}
        NM = New Integer() {0, 0, 0, 0, 1, 0, 1, 0, 0, -1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 2, 1, 0, -1, 0, 0, 0, 1, 1, -1, 0, 0, 0, 0, 0, 0, -1, -1, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, -1, 1, -1, -1, 0, -1}
        NMprime = New Integer() {0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 1, 0, -1, 0, 1, -1, -1, 1, 2, -2, 0, 2, 2, 1, 0, 0, -1, 0, -1, 0, 0, 1, 0, 2, -1, 1, 0, 1, 0, 0, 1, 2, 1, -2, 0, 1, 0, 0, 2, 2, 0, 1, 1, 0, 0, 1, -2, 1, 1, 1, -1, 3, 0}
        NF = New Integer() {0, 2, 2, 0, 0, 0, 2, 2, 2, 2, 0, 2, 2, 0, 0, 2, 0, 2, 0, 2, 2, 2, 0, 2, 2, 2, 2, 0, 0, 2, 0, 0, 0, -2, 2, 2, 2, 0, 2, 2, 0, 2, 2, 0, 0, 0, 2, 0, 2, 0, 2, -2, 0, 0, 0, 2, 2, 0, 0, 2, 2, 2, 2}
        NOmega = New Integer() {1, 2, 2, 2, 0, 0, 2, 1, 2, 2, 0, 1, 2, 0, 1, 2, 1, 1, 0, 1, 2, 2, 0, 2, 0, 0, 1, 0, 1, 2, 1, 1, 1, 0, 1, 2, 2, 0, 2, 1, 0, 2, 1, 1, 1, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 2, 0, 0, 2, 2, 2, 2}
        NSin = New Integer() {-171996, -13187, -2274, 2062, 1426, 712, -517, -386, -301, 217, -158, 129, 123, 63, 63, -59, -58, -51, 48, 46, -38, -31, 29, 29, 26, -22, 21, 17, 16, -16, -15, -13, -12, 11, -10, -8, 7, -7, -7, -7, 6, 6, 6, -6, -6, 5, -5, -5, -5, 4, 4, 4, -4, -4, -4, 3, -3, -3, -3, -3, -3, -3, -3}
        NSinT = New Integer() {-174.2, -1.6, -0.2, 0.2, -3.4, 0.1, 1.2, -0.4, 0, -0.5, 0, 0.1, 0, 0, 0.1, 0, -0.1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -0.1, 0, 0.1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        NCos = New Integer() {92025, 5736, 977, -895, 54, -7, 224, 200, 129, -95, 0, -70, -53, 0, -33, 26, 32, 27, 0, -24, 16, 13, 0, -12, 0, 0, -10, 0, -8, 7, 9, 7, 6, 0, 5, 3, -3, 0, 3, 3, 0, -3, -3, 3, 3, 0, 3, 3, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        NCosT = New Integer() {8.9, -3.1, -0.5, 0.5, -0.1, 0, -0.6, 0, -0.1, 0.3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}

    End Sub

    Private Sub MeridianPicBx_Paint(sender As Object, e As PaintEventArgs) Handles MeridianPicBx.Paint

    End Sub

    Private Sub FormNoonSight_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        'Next two lines center form on screen without StartUpPosition so form stays where last positioned despite graphics
        Me.Left = ((System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - (Me.Width)) / 2
        Me.Top = ((System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - (Me.Height)) / 2

        MonthList = "JanFebMarAprMayJunJulAugSepOctNovDec"
        If InvokedBySightLog = False Then
            DTNoonSight.Value = DateTime.Now
        End If
        ReDim EqtTable(0)
        cboLo.SelectedIndex = 0 'g_LongW
        cboDRL.SelectedIndex = 0 'g_LatN
        cboIE.SelectedIndex = 0 '"on the arc"
        cboHE.SelectedIndex = 0 '"ft"
        cboDsUnit.SelectedIndex = 0 '"yards"
        cboTemperature.SelectedIndex = 0 '"F"
        cboPressure.SelectedIndex = 0 '"in Hg"
        Flag = False
        optDRL.Checked = True
        NewFormBtn.Checked = True
        OldFormBtn.Checked = False
        optHoSRForm.Checked = True
        optHoParameters.Checked = False
        ' this subroutine recycle the bitmap jpg file name to a newly created, empty filename
        ClearScreen()
        ' FormNoonSight NoonSight load event code

        If FavoriteLocations.SharedLocUse.EntryStatus = "Shared" Then
            Me.BringToFront()
            If FavoriteLocations.CommonYesNoMsgBox("Shared Location data is available - do you want to use it?") = True Then
                With FavoriteLocations.SharedLocUse
                    optDRL.Checked = True
                    txtDRLDeg.Text = .DRLatDeg.ToString
                    txtDRLMin.Text = .DRLatMin.ToString
                    If .DRLatNS = g_LatN Then
                        cboDRL.SelectedIndex = 0
                    Else
                        cboDRL.SelectedIndex = 1
                    End If

                    If .DST = "X" Then
                        chkDST.Checked = True
                    Else
                        chkDST.Checked = False
                    End If
                    txtLoDeg.Text = .DRLongDeg.ToString
                    txtLoMin.Text = .DRLongMin.ToString
                    If .DRLongEW = g_LongW Then
                        cboLo.SelectedIndex = 0
                    Else
                        cboLo.SelectedIndex = 1
                    End If

                    Select Case .HorType
                        Case "Dip Short"
                            optHorizonDipShort.Checked = True
                            txtDsDist.Text = .HorDist
                            cboDsUnit.SelectedIndex = .HorDistIndex
                        Case "Artificial"
                            optHorizonArtificial.Checked = True
                        Case "Natural"
                            optHorizonNatural.Checked = True
                        Case "Bubble"
                            optHorizonBubble.Checked = True
                        Case Else
                            optHorizonNatural.Checked = True
                    End Select

                    txtHE.Text = .HE.ToString
                    cboHE.SelectedIndex = .HETypeIndex

                    If .ZDAutoSelect = True Then
                        optZDAuto.Checked = True
                    Else
                        optZDManual.Checked = True
                        txtZDh.Text = .ZDhr.ToString
                        If .ZDmin = "0" Then
                            cboZDm.SelectedIndex = 0
                            cboZDm.Visible = False
                        Else
                            cboZDm.Visible = True
                            If .ZDmin = "30" Then
                                cboZDm.SelectedIndex = 1
                            ElseIf .ZDmin = "45" Then
                                cboZDm.SelectedIndex = 2
                            Else
                                cboZDm.SelectedIndex = 0
                            End If
                        End If
                    End If
                End With
            End If
        End If

        ' this refresh of the meridian pic box will force the graphics entity to be loaded into the meridgraphic variable for global use
        MeridianPicBx.Refresh()
        InitLoadComplete = True
    End Sub

    Private Sub FormNoonSight_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Cleanup()
    End Sub

    Private Sub ClearScrBtn_Click(sender As Object, e As EventArgs) Handles ClearScrBtn.Click
        ClearScreen()
    End Sub

    Private Sub optAzN_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optAzN.CheckedChanged
        If eventSender.Checked Then
            If optDRL.Checked = False Then
                txtDRLDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000F)
                txtDRLMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000F)
                cboDRL.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000F)
                txtDRLDeg.Enabled = False
                txtDRLMin.Enabled = False
                cboDRL.Enabled = False
            End If
        End If
    End Sub
    Private Sub optAzS_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optAzS.CheckedChanged
        If eventSender.Checked Then
            If optDRL.Checked = False Then
                txtDRLDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000F)
                txtDRLMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000F)
                cboDRL.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000F)
                txtDRLDeg.Enabled = False
                txtDRLMin.Enabled = False
                cboDRL.Enabled = False
            End If
        End If
    End Sub

    Private Sub optHorizonBubble_CheckedChanged(sender As Object, e As EventArgs) Handles optHorizonBubble.CheckedChanged
        If sender.Checked Then
            If optHorizonBubble.Checked = True Then
                lblHE.Visible = True
                txtHE.Visible = True
                'txtHE.Enabled = True
                cboHE.Visible = True
                'cboHE.Enabled = True
                lblDsDist.Visible = True
                txtDsDist.Visible = True
                'txtDsDist.Enabled = True
                cboDsUnit.Visible = True
                'cboDsUnit.Enabled = True
                'optCenter.Visible = False
            End If

            If optUpper.Checked = True Or optLower.Checked = True Then
                SendMsgBx("Caution:  Improper combination of limb and horizon.")
            End If
        End If
    End Sub

    Private Sub OldFormBtn_CheckedChanged(sender As Object, e As EventArgs) Handles OldFormBtn.CheckedChanged
        If InitLoadComplete = False Then Exit Sub
        If sender.Checked Then
            If OldFormBtn.Checked = True Then
                NewFormBtn.Checked = False
                ExecNoonSightCmd()
            End If
        End If
    End Sub

    Private Sub NewFormBtn_CheckedChanged(sender As Object, e As EventArgs) Handles NewFormBtn.CheckedChanged
        If InitLoadComplete = False Then Exit Sub
        If sender.Checked Then
            If NewFormBtn.Checked = True Then
                OldFormBtn.Checked = False
                ExecNoonSightCmd()
            End If
        End If
    End Sub

    Private Sub optDRL_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optDRL.CheckedChanged
        If InitLoadComplete = False Then Exit Sub
        If eventSender.Checked Then
            If optDRL.Checked = True Then
                txtDRLDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
                txtDRLMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
                cboDRL.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
                txtDRLDeg.Enabled = True
                txtDRLMin.Enabled = True
                cboDRL.Enabled = True
            End If

        End If
    End Sub
    Private Sub optHoSRForm_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optHoSRForm.CheckedChanged
        If eventSender.Checked And eventSender.Text <> "" Then
            ExecNoonSightCmd()
            'If cmdNoonSight.Enabled = True Then cmdNoonSight_Click(cmdNoonSight, New System.EventArgs())
        End If
    End Sub
    Private Sub optHoParameters_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optHoParameters.CheckedChanged
        If eventSender.Checked And eventSender.Text <> "" Then
            ExecNoonSightCmd()
            'If cmdNoonSight.Enabled = True Then cmdNoonSight_Click(cmdNoonSight, New System.EventArgs())
        End If
    End Sub
    Private Sub optZDAuto_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optZDAuto.CheckedChanged
        If eventSender.Checked And eventSender.Text <> "" Then
            'ClearScreen()
            ClearTimeTxt()
            'cmdNoonSight.Visible = False
            'OldFormBtn.Visible = False
            'NewFormBtn.Visible = False
            'cmdNoonSight.Enabled = False
            lblN.Visible = False
            lblS.Visible = False
            lblZ.Visible = False
            If optZDAuto.Checked = True Then
                txtZDh.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000B)
                txtZDh.Enabled = False
                lblZDh.Visible = False
                cboZDm.Visible = False
                'cboZDm.Enabled = False
                chkDST.Visible = True
                lblZDDST.Visible = True
                lblZDm.Visible = False
                cboZDm.SelectedIndex = 0 '"00"
                AutoZDCalc()
            End If
        End If
    End Sub

    Private Sub optZDManual_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optZDManual.CheckedChanged
        If eventSender.Checked And eventSender.Text <> "" Then
            'ClearScreen()
            ClearTimeTxt()
            cmdNoonSight.Visible = False
            OldFormBtn.Visible = False
            NewFormBtn.Visible = False
            'cmdNoonSight.Enabled = False
            lblN.Visible = False
            lblS.Visible = False
            lblZ.Visible = False
            If optZDManual.Checked = True Then
                txtZDh.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
                txtZDh.Enabled = True
                lblZDh.Visible = True
                cboZDm.Visible = True
                chkDST.Visible = True
                lblZDDST.Visible = True
                'cboZDm.Enabled = True
                lblZDm.Visible = True
            End If
        End If
    End Sub
    Private Sub optZDUT_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optZDUT.CheckedChanged
        If eventSender.Checked And eventSender.Text <> "" Then
            'ClearScreen()
            ClearTimeTxt()
            cmdNoonSight.Visible = False
            OldFormBtn.Visible = False
            NewFormBtn.Visible = False
            'cmdNoonSight.Enabled = False
            lblN.Visible = False
            lblS.Visible = False
            lblZ.Visible = False
            If optZDUT.Checked = True Then
                txtZDh.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000B)
                txtZDh.Enabled = False
                lblZDh.Visible = False
                cboZDm.Visible = False
                'cboZDm.Enabled = True
                lblZDm.Visible = False
                chkDST.Visible = False
                lblZDDST.Visible = False
                chkDST.CheckState = System.Windows.Forms.CheckState.Unchecked
                txtZDh.Text = "0"
            End If
        End If
    End Sub

    Private Sub txtDRLDeg_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDRLDeg.TextChanged
        If Val(txtDRLDeg.Text) <> 90 Then
            txtDRLMin.Enabled = True
        End If
        If Val(txtDRLDeg.Text) = 90 Then
            txtDRLMin.Text = ""
            txtDRLMin.Enabled = False
            txtDRLMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000B)
            'txtDRLDeg.ForeColor = &H80000008
        End If
        txtDRLDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtDRLDeg.Text) > 90 Then
            txtDRLDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range", "Input Error", MessageBoxButtons.OK)
        End If
        If Val(txtDRLDeg.Text) < 90 Then
            'txtDRLMin.ForeColor = &H80000008
            txtDRLMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
            'txtDRLMin.Text = "  "
        End If
    End Sub
    Private Sub txtDRLDeg_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtDRLDeg.KeyPress
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



    Private Sub btnDisplayEQTData_Click(sender As Object, e As EventArgs) Handles btnDisplayEQTData.Click
        BuildEqtTable()
        DisplayEQTData.Show()
        Exit Sub
    End Sub

    Private Sub txtDRLDeg_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtDRLDeg.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtDRLDeg.Text) > 90 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtDRLDeg_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDRLDeg.Enter
        SelectAllText(txtDRLDeg)
    End Sub
    Private Sub txtDRLMin_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDRLMin.TextChanged
        'txtDRLMin.ForeColor = &H80000008
        txtDRLMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtDRLMin.Text) > 59.9 Then
            txtDRLMin.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range", "Input Error", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub chkDST_CheckedChanged(sender As Object, e As EventArgs) Handles chkDST.CheckedChanged
        ' If the txtTime text box is not blank then a LAN needs to be recalculated
        If txtTime.Text <> "" Then
            cmdLAN.PerformClick()
        End If
        ' If the LongitudeCalcTxtBx is not blank then a Noon Sight Calc needs to be execute
        If LongitudeCalcTxtBx.Text <> "" Then
            cmdNoonSight.PerformClick()
        End If
    End Sub

    Private Sub txtDRLMin_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtDRLMin.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtDRLMin.Text, ".") Then
                    If KeyAscii = 46 Then KeyAscii = 0 : Beep()
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
    Private Sub txtDRLMin_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtDRLMin.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtDRLMin.Text) > 59.9 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtDRLMin_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDRLMin.Enter
        SelectAllText(txtDRLMin)
    End Sub
    Private Sub txtIESec_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtIESec.TextChanged
        'txtIESec.ForeColor = &H80000008
        txtIESec.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtIESec.Text) > 59 Then
            txtIESec.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range", "Input Error", MessageBoxButtons.OK)
        End If
    End Sub
    Private Sub txtIESec_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtIESec.KeyPress
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
    Private Sub txtIESec_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtIESec.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtIESec.Text) > 59 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtIESec_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtIESec.Enter
        SelectAllText(txtIESec)
    End Sub
    Private Sub txtLoDeg_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLoDeg.TextChanged
        If InitLoadComplete = False Then Exit Sub
        ClearTimeTxt()
        If Val(txtLoDeg.Text) <> 180 Then
            txtLoMin.Enabled = True
        End If
        If Val(txtLoDeg.Text) = 180 Then
            txtLoMin.Text = ""
            txtLoMin.Enabled = False
            txtLoMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000B)
        End If
        cmdNoonSight.Visible = False
        OldFormBtn.Visible = False
        NewFormBtn.Visible = False
        'cmdNoonSight.Enabled = False
        lblN.Visible = False
        lblS.Visible = False
        lblZ.Visible = False
        'txtLoDeg.ForeColor = &H80000008
        txtLoDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtLoDeg.Text) > 180 Or (Val(txtLoDeg.Text) = 180 And Val(txtLoMin.Text) <> 0) Then
            txtLoDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range", "Input Error", MessageBoxButtons.OK)
        End If
        If Val(txtLoDeg.Text) < 180 Then
            'txtLoMin.ForeColor = &H80000008
            txtLoMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
            'txtLoMin.Text = "    "
        End If
        AutoZDCalc()
    End Sub
    Private Sub txtLoDeg_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLoDeg.Enter
        SelectAllText(txtLoDeg)
    End Sub
    Private Sub txtLoMin_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLoMin.TextChanged
        If InitLoadComplete = False Then Exit Sub
        ClearTimeTxt()
        cmdNoonSight.Visible = False
        OldFormBtn.Visible = False
        NewFormBtn.Visible = False
        'cmdNoonSight.Enabled = False
        lblN.Visible = False
        lblS.Visible = False
        lblZ.Visible = False
        'txtLoMin.ForeColor = &H80000008
        txtLoMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtLoMin.Text) > 59.9 Then
            txtLoMin.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range", "Input Error", MessageBoxButtons.OK)
        End If
        'ClearScreen()

        AutoZDCalc()
    End Sub

    Private Sub txtLoMin_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtLoMin.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtLoMin.Text, ".") Then
                    If KeyAscii = 46 Then
                        KeyAscii = 0
                        Beep()
                    End If
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
    Private Sub txtLoMin_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLoMin.Enter
        SelectAllText(txtLoMin)
    End Sub
    'Private Sub txtTime_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTime.TextChanged
    'txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
    'If Len(txtTime.Text) = 6 And (Val(VB.Left(txtTime.Text, 2)) > 23 Or Val(Mid(txtTime.Text, 3, 2)) > 59 Or Val(Mid(txtTime.Text, 5, 2)) > 59) Then
    '    txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
    '    ErrorMsgBox("Out of Range", "Input Error", MessageBoxButtons.OK)
    'End If

    'If Flag = False And Len(txtTime.Text) = 6 Then
    '    cmdNoonSight.Visible = True
    '    OldFormBtn.Visible = True
    '    NewFormBtn.Visible = True
    '    Exit Sub
    'End If
    'Longitude()
    'AutoZDCalc()

    'If optZDManual.Checked = False Then
    '    ZDMan = ZD
    'End If
    'If optZDManual.Checked = True Then
    '    ZDMan = System.Math.Abs(Val(txtZDh.Text)) + Val(cboZDm.Text) / 60
    'End If
    'If optZDUT.Checked = True Then
    '    ZDMan = 0 'added in V5.4.0
    'End If
    'If VB.Left(txtZDh.Text, 1) = "-" Then
    '    ZDMan = -ZDMan
    '    ZD = -ZD
    'End If
    'If chkDST.CheckState = 1 Then
    '    ZD = ZD - 1
    '    ZDMan = ZDMan - 1 ': GHour = GHour - 1
    'End If
    'txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
    'TLANObsSec = 3600 * Val(VB.Left(txtTime.Text, 2)) + 60 * Val(Mid(txtTime.Text, 3, 2)) + Val(Mid(txtTime.Text, 5, 2))
    'If Len(txtTime.Text) = 6 And ((chkDST.CheckState = 0 And (TLANObsSec - (ZD - ZDMan) * 3600 < 40408 Or TLANObsSec - (ZD - ZDMan) * 3600 > 45867) _
    '        Or (chkDST.CheckState = 1 And (TLANObsSec - (ZD - ZDMan) * 3600 < 44008 Or TLANObsSec - (ZD - ZDMan) * 3600 > 49467)))) Then
    '    txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
    '    ErrorMsgBox("Out of Range", "Input Error", MessageBoxButtons.OK)
    '    cmdNoonSight.Visible = False
    '    OldFormBtn.Visible = False
    '    NewFormBtn.Visible = False
    'Else

    'End If
    'txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
    'cmdNoonSight.Visible = True
    'If Len(txtTime.Text) < 6 Then
    '    cmdNoonSight.Visible = False ': cmdNoonSight.Enabled = False
    '    OldFormBtn.Visible = False
    '    NewFormBtn.Visible = False
    'End If
    'End Sub
    'Private Sub txtTime_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTime.KeyPress
    'Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
    'Select Case KeyAscii
    '    Case Asc("0") To Asc("9")
    '        fnumeral = fnumeral & Chr(KeyAscii)
    '    Case Asc(Chr(8))
    '        fnumeral = fnumeral & Chr(KeyAscii)
    '    Case Else
    '        KeyAscii = 0
    '        Beep()
    'End Select
    'eventArgs.KeyChar = Chr(KeyAscii)
    'If KeyAscii = 0 Then
    '    eventArgs.Handled = True
    'End If
    'End Sub
    'Private Sub txtTime_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtTime.Validating
    '        Dim KeepFocus As Boolean = eventArgs.Cancel
    '        If Flag = False And Len(txtTime.Text) = 6 Then
    '            cmdNoonSight.Visible = True
    '            OldFormBtn.Visible = True
    '            NewFormBtn.Visible = True
    '            GoTo EventExitSub
    '        End If
    '        If Len(txtTime.Text) = 6 And chkDST.CheckState = 0 And (TLANObsSec - (ZD - ZDMan) * 3600 < 40408 Or TLANObsSec - (ZD - ZDMan) * 3600 > 45867) Then
    '            KeepFocus = True ': txtTime.BackColor = &HFF&: ErrorMsgBox "Out of Range": cmdNoonSight.Visible = False
    '        End If
    '        If Len(txtTime.Text) = 6 And chkDST.CheckState = 1 And (TLANObsSec - (ZD - ZDMan) * 3600 < 44008 Or TLANObsSec - (ZD - ZDMan) * 3600 > 49467) Then
    '            KeepFocus = True ': txtTime.BackColor = &HFF&: ErrorMsgBox "Out of Range": cmdNoonSight.Visible = False
    '        End If
    '        If Len(txtTime.Text) = 0 Then
    '            KeepFocus = False
    '        End If
    'EventExitSub:
    '        eventArgs.Cancel = KeepFocus
    'End Sub
    'Private Sub txtTime_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTime.Enter
    'SelectAllText(txtTime)
    'End Sub
    'Private Sub txtYear_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
    'ClearScreen()
    'ClearTimeTxt()
    'cmdNoonSight.Visible = False
    'OldFormBtn.Visible = False
    'NewFormBtn.Visible = False
    ''cmdNoonSight.Enabled = False
    'lblN.Visible = False
    'lblS.Visible = False
    'lblZ.Visible = False
    ''txtYear.ForeColor = &H80000008
    'txtYear.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
    'If Len(txtYear.Text) = 4 And (Val(txtYear.Text) < 1901 Or Val(txtYear.Text) > 2099) Then
    '    txtYear.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
    '    ErrorMsgBox("Out of Range", "Input Error", MessageBoxButtons.OK)
    'End If
    'CheckDate()
    'End Sub
    'Private Sub txtYear_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
    'SelectAllText(txtYear)
    'End Sub
    Private Sub txtZDh_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtZDh.TextChanged
        'ClearScreen()
        ClearTimeTxt()
        cmdNoonSight.Visible = False
        OldFormBtn.Visible = False
        NewFormBtn.Visible = False
        'cmdNoonSight.Enabled = False
        lblN.Visible = False
        lblS.Visible = False
        lblZ.Visible = False
        If optZDAuto.Checked = True Or optZDUT.Checked = True Then txtZDh.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000B)
        If optZDManual.Checked = True Then txtZDh.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If optZDManual.Checked = True And (Val(txtZDh.Text) < -14 Or Val(txtZDh.Text) > 12) Then
            txtZDh.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range", "Input Error", MessageBoxButtons.OK)
        End If
    End Sub
    Private Sub txtZDh_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtZDh.KeyPress
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
                'If Len(txtZDh.Text) > 0 Then
                '    KeyAscii = 0
                '    Beep
                'End If
                If txtZDh.SelectionStart <> 0 Or bMinusSignAlready Then
                    KeyAscii = 0
                    Beep()
                Else
                    bMinusSignAlready = True
                End If
            Case Asc("+")
                'If Len(txtZDh.Text) > 0 Then
                '    KeyAscii = 0
                '    Beep
                'End If

                If txtZDh.SelectionStart <> 0 Or bPlusSignAlready Then
                    KeyAscii = 0
                    Beep()
                Else
                    bPlusSignAlready = True
                End If
            Case Else
                KeyAscii = 0
                Beep()
        End Select
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Sub txtZDh_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtZDh.Enter
        SelectAllText(txtZDh)
    End Sub
    'Public Sub CheckDate()
    'On Error GoTo ErrorHandler
    'If cboDay.Text = "" Or cboMonth.Text = "" Or txtYear.Text = "" Or Len(txtYear.Text) <> 4 Then
    '    Exit Sub
    'Else
    '    Dim tempstr As String = (cboMonth.GetItemText(cboMonth.SelectedIndex) + 1).ToString("00")
    '    DateOfSight = tempstr & "/" & cboDay.Text & "/" & txtYear.Text
    '    DateOfSight = DateValue(DateOfSight).ToString
    'End If
    'Exit Sub
    'ErrorHandler:
    'ErrorMsgBox("Invalid date", "Input Error", MessageBoxButtons.OK)
    'DateError = True
    'Exit Sub
    'End Sub

    Public Sub Longitude()
        'Next line for problem with commas as decimal points in Europe with Favorite Places, etc.
        LoMin = Replace(txtLoMin.Text, ",", ".")
        Lo = Val(txtLoDeg.Text) + Val(LoMin) / 60
        If cboLo.Text = "E" Then Lo = -Lo
    End Sub

    Public Function Greenwich() As Integer
        'Prefix (or suffix) G for Greenwich, UT = Universal Time
        Dim DayG(12) As Short
        MonthDays = "312831303130313130313031"
        'Check for local leap year
        LocalYear = DTInput.Year  'Val(txtYear.Text)
        LeapYear = DateTime.IsLeapYear(DTInput.Year)
        If LeapYear = True Then
            MonthDays = "312931303130313130313031"
        Else
            MonthDays = "312831303130313130313031"
        End If
        MonthNumber = DTInput.Month
        DayNumber = 0
        For i = 1 To MonthNumber - 1
            DayNumber = Val(Mid(MonthDays, 2 * i - 1, 2)) + DayNumber
        Next i
        DayNumber = DayNumber + DTInput.Day

        ZDinSeconds = 3600 * System.Math.Sign(ZD) * System.Math.Abs(ZD)
        UTinSeconds = ZTinSeconds + ZDinSeconds ' ZT is input prior to this routine being called
        Dim GrDT As DateTime = DTInput.AddSeconds(ZDinSeconds)

        If Flag2 = False Then
            StarDayNumber = DayNumber Mod 3 'added in V5.3.1 - screws up longitude from observed ZT of LAN
            If StarDayNumber = 1 Then DayNumber = DayNumber + 1
            If StarDayNumber = 0 Then DayNumber = DayNumber - 1
            UTinSeconds = 43200 'THIS DOES NOT WANT TO BE 43200 IN IandC
        End If

        GHour = GrDT.Hour
        GMinute = GrDT.Minute
        GSecond = GrDT.Second
        GYear = GrDT.Year
        GDayOfYear = DayNumber

        If GHour >= 24 Then
            GHour = GHour - 24
            GDayOfYear = GDayOfYear + 1
        End If
        If (GDayOfYear = 366 And LeapYear = False) Or GDayOfYear = 367 Then
            GDayOfYear = 1
            GYear = GYear + 1
            GoTo GreenwichDate
        End If
        If GHour < 0 Then
            GHour = GHour + 24
            GDayOfYear = GDayOfYear - 1
        End If
        If GDayOfYear = 0 Then GYear = GYear - 1
        'Check for leap year at Greenwich
        GLeapYear = DateTime.IsLeapYear(GYear)
        'Days in year
        If GDayOfYear = 0 And GLeapYear = False Then GDayOfYear = 365
        If GDayOfYear = 0 And GLeapYear = True Then GDayOfYear = 366
GreenwichDate:
        DayG(0) = GDayOfYear
        If GLeapYear = True Then
            MonthDays = "312931303130313130313031"
        Else
            MonthDays = "312831303130313130313031"
        End If
        For i = 1 To 12
            DayG(i) = DayG(i - 1) - Val(Mid(MonthDays, 2 * i - 1, 2))
            If DayG(i) <= 0 Then
                GMonth = i
                GDay = DayG(i - 1)
                GoTo GetMonth
            End If
        Next i
GetMonth:
        MonthatG = Mid(MonthList, 3 * GMonth - 2, 3)
        Return True
    End Function
    Public Function Julian() As Integer
        DecimalDate = GDay + (GHour / 24) + (GMinute / 1440) + (GSecond / 86400.0!)
        DecimalDateHour1 = GDay + (GHour / 24)
        DecimalDateHour2 = GDay + ((GHour + 1) / 24)
        'DecimalDateHour2 = (GDay + 1) + (GHour / 24)
        GYearJ = GYear
        If GMonth < 3 Then
            GYearJ = GYear - 1
            GMonth = GMonth + 12
        End If
        JD = Int(365.25 * (GYearJ + 4716)) + Int(30.6001 * (GMonth + 1)) + DecimalDate - 1537.5
        JDHour1 = Int(365.25 * (GYearJ + 4716)) + Int(30.6001 * (GMonth + 1)) + DecimalDateHour1 - 1537.5
        JDHour2 = Int(365.25 * (GYearJ + 4716)) + Int(30.6001 * (GMonth + 1)) + DecimalDateHour2 - 1537.5
        T = (JD - 2451545 + DeltaT / 86400) / 36525.0 'added in V4.7.1
        THour1 = (JDHour1 - 2451545 + DeltaT / 86400) / 36525.0
        THour2 = (JDHour2 - 2451545 + DeltaT / 86400) / 36525.0
        Return True
    End Function
    Public Function Obliquity() As Integer
        'Obliquity of the ecliptic
        OE = 84381.448 - 46.816 * T - 0.00059 * T * T + 0.001813 * T * T * T 'Mean obliquity of ecliptic, arcseconds
        OE = OE / 3600 'degrees
        OETrue = OE + NO 'degrees
        Return True
    End Function

    Public Sub Nutation()
        NL = 0
        NO = 0

        NutD = 297.85036 + 445267.11148 * T - 0.0019142 * T * T + T * T * T / 189474 'mean elongation of moon from sun, degrees
        If NutD >= 360 Or NutD < 0 Then NutD = NutD - Int(NutD / 360) * 360
        NutD = NutD * Pi / 180 'radians

        NutM = 357.52772 + 35999.05034 * T - 0.0001603 * T * T - T * T * T / 300000 'mean anomaly of the sun (Earth), degrees
        If NutM >= 360 Or NutM < 0 Then NutM = NutM - Int(NutM / 360) * 360
        NutM = NutM * Pi / 180 'radians

        NutMprime = 134.96298 + 477198.867398 * T + 0.0086972 * T * T + T * T * T / 56250 'mean anomaly of the moon, degrees
        If NutMprime >= 360 Or NutMprime < 0 Then NutMprime = NutMprime - Int(NutMprime / 360) * 360
        NutMprime = NutMprime * Pi / 180 'radians

        NutF = 93.27191 + 483202.017538 * T - 0.0036825 * T * T + T * T * T / 327270 'moon's argument of latitude, degrees
        If NutF >= 360 Or NutF < 0 Then NutF = NutF - Int(NutF / 360) * 360
        NutF = NutF * Pi / 180 'radians

        NutOmega = 125.04452 - 1934.136261 * T + 0.0020708 * T * T + T * T * T / 450000 'longitude of ascending node of moon..., degrees
        If NutOmega >= 360 Or NutOmega < 0 Then NutOmega = NutOmega - Int(NutOmega / 360) * 360
        NutOmega = NutOmega * Pi / 180 'radians

        For i = 0 To 62
            NL = NL + (NSin(i) + NSinT(i) * T) * System.Math.Sin(ND(i) * NutD + NM(i) * NutM + NMprime(i) * NutMprime + NF(i) * NutF + NOmega(i) * NutOmega) 'arcseconds x 10000
            NO = NO + (NCos(i) + NCosT(i) * T) * System.Math.Cos(ND(i) * NutD + NM(i) * NutM + NMprime(i) * NutMprime + NF(i) * NutF + NOmega(i) * NutOmega) 'arcseconds x 10000
        Next i
        NL = (NL / 10000) / 3600 'degrees
        NO = (NO / 10000) / 3600 'degrees
    End Sub
    Public Function Aries() As Integer
        HG = UTinSeconds / 3600 ': If AriesFlag = True Then HG = GHour
        TP = (JD - 2451545.0! - HG / 24) / 36525.0!
        GR = 6.69737456 + 0.000000000000004 + (2400.051336 * TP)
        GR = GR + (0.0000258622 * TP * TP) + (1.002737909 * HG)
        GR = GR * 15 '  convert hours to degrees
        GR = GR + NL
        If GR >= 360 Or GR < 0 Then
            GR = GR - Int(GR / 360) * 360
        End If
        LR = GR - Lo
        If LR >= 360 Then
            LR = LR - 360
        End If
        If LR < 0 Then
            LR = LR + 360
        End If
        If VM = 60 Then
            VM = 0
            VD = VD + 1
        End If
        WD = Int(GR)
        WM = (GR - WD) * 60
        WM = Int(WM * 10 + 0.5) / 10
        If WM = 60 Then
            WM = 0
            WD = WD + 1
        End If
        QD = Int(LR)
        QM = (LR - QD) * 60
        QM = Int(QM * 10 + 0.5) / 10
        If QM = 60 Then
            QM = 0
            QD = QD + 1
        End If
        Return True
    End Function

    Public Sub Sun()
        Ecc = 0.016708634 - 0.000042037 * T - 0.0000001267 * T * T 'Ecc of Earth's orbit
        MS = 357.52911 + 35999.05029 * T - 0.0001537 * T * T 'mean anomaly of Sun, degrees
        If MS >= 360 Or MS < 0 Then
            MS = MS - Int(MS / 360) * 360
        End If
        'center of Sun, degrees
        C = (1.914602 - 0.004817 * T - 0.000014 * T * T) * System.Math.Sin(MS * Pi / 180) +
            (0.019993 - 0.000101 * T) * System.Math.Sin(2 * MS * Pi / 180) +
            0.000289 * System.Math.Sin(3 * MS * Pi / 180)
        NU = MS + C 'Sun's true anomaly, degrees
        RN = (1.000001018 * (1 - Ecc * Ecc)) / (1 + Ecc * System.Math.Cos(NU * Pi / 180)) 'Sun's radius vector (distance between centers of Sun and Earth), astronomical units
        L0 = 280.46646 + 36000.76983 * T + 0.0003032 * T * T 'geometric mean longitude of Sun, degrees
        If L0 >= 360 Or L0 < 0 Then
            L0 = L0 - Int(L0 / 360) * 360
        End If
        'L0 = L0 + NL - 0.005691611 / RN     'add effects of nutation and Aberration
        'If L0 >= 360 Or L0 < 0 Then L0 = L0 - Int(L0 / 360) * 360
        LN = L0 + C 'Sun's true longitude, degrees

        T = T / 10
        ' Compute heliocentric, ecliptical Longitude L in radians
        L = Earth_L01(T) + Earth_L02(T) + Earth_L11(T) + Earth_L21(T) + Earth_L31(T) + Earth_L41(T) + Earth_L51(T) 'radians
        If System.Math.Abs(L) > (2 * Pi) Then
            L = L - 2 * Pi * Int(L / 2 / Pi)
        End If
        ' Compute heliocentric, ecliptical Latitude B in radians
        B = Earth_B01(T) + Earth_B11(T) + Earth_B21(T) + Earth_B31(T) + Earth_B41(T) 'radians
        ' Compute heliocentric distance RH in AU
        RH = Earth_R01(T) + Earth_R02(T) + Earth_R11(T) + Earth_R21(T) + Earth_R31(T) + Earth_R41(T) + Earth_R51(T)

        L1 = L + Pi 'geocentric longitude, radians
        B = -B 'geocentric latitude, radians

        L1 = L1 * 180 / Pi 'geocentric longitude, degrees
        'add nutation to get apparent positions
        L1 = L1 + NL 'degrees
        'add aberration
        L1 = L1 - (20.4898 / 3600) / RH 'apparent longitude, degrees
        'back to radians
        L1 = L1 * Pi / 180
        EclipticToEquatorial()
        AR = AR * 180 / Pi 'for Meeus ecl-to-eq
        DE = DE * 180 / Pi 'for Meeus ecl-to-eq

        DI = System.Math.Atan(0.00465424336 / RN) * 180 / Pi * 60
        If optCenter.Checked = True Then DI = 0
        'DI = (959.63 / RN) / 60        'Meeus
        'back to normal T
        '    T = 10 * T
    End Sub
    Public Function GHADec() As Integer

        SH = 360 - AR
        GA = GR - AR
        If GA >= 360 Or GA < 0 Then
            GA = GA - Int(GA / 360) * 360
        End If
        Flag2 = True
        Greenwich()
        Delta_T()
        Julian()
        T = THour1
        JDHour = JDHour1
        Nutation()
        Obliquity()
        Aries()
        Sun()
        DE1 = DE
        HourAnglesHour()
        GHAHour1 = GHAHour
        Greenwich()
        Delta_T()
        Julian()
        T = THour2
        JDHour = JDHour2
        Nutation()
        Obliquity()
        Aries()
        Sun()
        DE2 = DE
        HourAnglesHour()
        GHAHour2 = GHAHour
        Flag2 = False

        SunHourChange = GHAHour2 - GHAHour1
        If SunHourChange < 0 Then
            SunHourChange = SunHourChange + 360
        End If
        SunGHACorr = (15 - SunHourChange) / 2
        GHAHour1 = GHAHour1 - SunGHACorr
        GA = GHAHour1

        SH = Int(SH * 10 + 0.5) / 10
        GRD = Int(AR)
        GRM = (AR - GRD) * 60
        GRM = Int(GRM * 10 + 0.5) / 10
        RA = Int(AR * 10 + 0.5) / 10
        If DE = 0 Then HD = " "
        If DE > 0 Then HD = g_LatN
        If DE < 0 Then HD = g_LatS
        DF = Int(System.Math.Abs(DE) * 10 + 0.5) / 10
        VD = Int(GA)
        VM = (GA - VD) * 60
        VM = Int(VM * 10 + 0.5) / 10
        Return True

    End Function
    Public Sub AutoZDCalc()
        Lo = Val(txtLoDeg.Text) + Val(txtLoMin.Text) / 60
        ZD = Int(Lo / 15 + 0.5)
        If cboLo.Text = "E" Then ZD = -ZD
        If optZDAuto.Checked = True Then
            SignZD = "+"
            If cboLo.Text = "E" Then
                SignZD = "-"
            End If
            txtZDh.Text = SignZD & System.Math.Abs(ZD)
        End If
        Exit Sub
    End Sub
    Public Sub EclipticToEquatorial()
        AR = System.Math.Atan((System.Math.Sin(L1) * System.Math.Cos(OETrue * Pi / 180) - System.Math.Tan(B) * System.Math.Sin(OETrue * Pi / 180)) / System.Math.Cos(L1)) 'radians
        If System.Math.Cos(L1) < 0 Then AR = AR + Pi
        If AR >= 2 * Pi Then AR = AR - 2 * Pi
        If AR < 0 Then AR = AR + 2 * Pi
        x = System.Math.Sin(B) * System.Math.Cos(OETrue * Pi / 180) + System.Math.Cos(B) * System.Math.Sin(OETrue * Pi / 180) * System.Math.Sin(L1)
        DE = System.Math.Atan(x / (System.Math.Sqrt(-x * x + 1) + 9.999999E-21)) 'arcsin, radians
        'AR = AR * 180 / Pi
        'DE = DE * 180 / Pi
        Exit Sub

    End Sub
    Private Sub txtDsDist_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtDsDist.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtDsDist.Text, ".") Then
                    If KeyAscii = 46 Then
                        KeyAscii = 0
                        Beep()
                    End If
                End If
            Case Asc(Chr(8))
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(",")
            Case Else
                KeyAscii = 0
                Beep()
        End Select
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Sub txtDsDist_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDsDist.Enter
        SelectAllText(txtDsDist)
    End Sub
    Private Sub txtHE_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtHE.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtHE.Text, ".") Then
                    If KeyAscii = 46 Then
                        KeyAscii = 0
                        Beep()
                    End If
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
    Private Sub txtHE_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHE.Enter
        SelectAllText(txtHE)
    End Sub
    Private Sub txtHsDeg_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHsDeg.TextChanged
        'txtHsDeg.ForeColor = &H80000008
        txtHsDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtHsDeg.Text) > 145 Then
            txtHsDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range", "Input Error", MessageBoxButtons.OK)
        End If
    End Sub
    Private Sub txtHsDeg_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtHsDeg.KeyPress
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
    Private Sub txtHsDeg_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtHsDeg.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtHsDeg.Text) > 145 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtHsDeg_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHsDeg.Enter
        SelectAllText(txtHsDeg)
    End Sub
    Private Sub txtHsMin_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHsMin.TextChanged
        'txtHsMin.ForeColor = &H80000008
        txtHsMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If optHsDMm.Checked = True And Val(txtHsMin.Text) > 59.9 Then
            txtHsMin.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range", "Input Error", MessageBoxButtons.OK)
        End If
        If optHsDMS.Checked = True And Val(txtHsMin.Text) > 59 Then
            txtHsMin.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range", "Input Error", MessageBoxButtons.OK)
        End If
    End Sub
    Private Sub txtHsMin_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtHsMin.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If optHsDMS.Checked = True Then
                    KeyAscii = 0
                    Beep()
                Else
                    If InStr(txtHsMin.Text, ".") Then
                        If KeyAscii = 46 Then
                            KeyAscii = 0
                            Beep()
                        End If
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
    Private Sub txtHsMin_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtHsMin.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If optHsDMm.Checked = True And Val(txtHsMin.Text) > 59.9 Then
            KeepFocus = True
        End If
        If optHsDMS.Checked = True And Val(txtHsMin.Text) > 59 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtHsMin_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHsMin.Enter
        SelectAllText(txtHsMin)
    End Sub
    Private Sub txtHsSec_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHsSec.TextChanged
        'txtHsSec.ForeColor = &H80000008
        txtHsSec.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtHsSec.Text) > 59 Then
            txtHsSec.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range", "Input Error", MessageBoxButtons.OK)
        End If
    End Sub
    Private Sub txtHsSec_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtHsSec.KeyPress
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
    Private Sub txtHsSec_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtHsSec.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtHsSec.Text) > 59 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtHsSec_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHsSec.Enter
        SelectAllText(txtHsSec)
    End Sub
    Private Sub txtIEdeg_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtIEdeg.TextChanged
        'This is not really necessary since only one digit is allowed
        'txtIEdeg.ForeColor = &H80000008
        txtIEdeg.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtIEdeg.Text) > 9 Then
            txtIEdeg.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range", "Input Error", MessageBoxButtons.OK)
        End If
    End Sub
    Private Sub txtIEdeg_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtIEdeg.KeyPress
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
    Private Sub txtIEdeg_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtIEdeg.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        'This is not really necessary since only one digit is allowed
        If Val(txtIEdeg.Text) > 9 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtIEDeg_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtIEdeg.Enter
        SelectAllText(txtIEdeg)
    End Sub
    Private Sub txtIEmin_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtIEmin.TextChanged
        'txtIEmin.ForeColor = &H80000008
        txtIEmin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If optHsDMm.Checked = True And Val(txtIEmin.Text) > 59.9 Then
            txtIEmin.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range", "Input Error", MessageBoxButtons.OK)
        End If
        If optHsDMS.Checked = True And Val(txtIEmin.Text) > 59 Then
            txtIEmin.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range", "Input Error", MessageBoxButtons.OK)
        End If
    End Sub
    Private Sub txtIEmin_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtIEmin.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If optHsDMS.Checked = True Then
                    KeyAscii = 0
                    Beep()
                Else
                    If InStr(txtIEmin.Text, ".") Then
                        If KeyAscii = 46 Then
                            KeyAscii = 0
                            Beep()
                        End If
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
    Private Sub txtIEmin_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtIEmin.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If optHsDMm.Checked = True And Val(txtIEmin.Text) > 59.9 Then
            KeepFocus = True
        End If
        If optHsDMS.Checked = True And Val(txtIEmin.Text) > 59 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtIEmin_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtIEmin.Enter
        SelectAllText(txtIEmin)
    End Sub
    Public Function AltitudeCorrection() As Integer
        If optHsDMS.Checked = False Then
            txtHsSec.Text = ""
            txtIESec.Text = ""
        End If
        ICMin = Val(txtIEmin.Text) + Val(txtIESec.Text) / 60
        If cboIE.Text = "on the arc" Then
            ICinMinutes = -(Val(txtIEdeg.Text) * 60 + ICMin)
        End If
        If cboIE.Text = "off the arc (rdg.)" Then
            ICMin = 60 - ICMin
            If ICMin = 60 Then
                ICMin = 0
            End If
            ICinMinutes = (Val(txtIEdeg.Text) - 1) * 60 + ICMin
        End If
        If cboIE.Text = "off the arc (val.)" Then
            ICinMinutes = Val(txtIEdeg.Text) * 60 + ICMin
        End If
        Corr1 = ICinMinutes - DipCalc()
        Corr1Deg = Int(System.Math.Abs(Corr1 / 60))
        Corr1Min = System.Math.Abs(Corr1) - 60 * Corr1Deg
        hsinMinutes = 60 * Val(txtHsDeg.Text) + Val(txtHsMin.Text) + Val(txtHsSec.Text) / 60
        HsMin = Val(txtHsMin.Text) + Val(txtHsSec.Text) / 60
        hainMinutes = hsinMinutes + Corr1
        If optHorizonArtificial.Checked = True Then
            hainMinutes = (hsinMinutes + ICinMinutes) / 2
        End If
        BackSight = False
        If hainMinutes >= 5400 Then
            hainMinutes = 10800 - hainMinutes
            BackSight = True
        End If
        Refraction()
        HP = 60 * System.Math.Atan(0.0000426349651 / RN) * 180 / Pi '0.0000426349651 is radius of Earth in AU, RN is distance between centers of Earth and Sun in AU
        PA = HP * System.Math.Cos((hainMinutes / 60) * Pi / 180)
        If optCenter.Checked = True Then
            DI = 0
        End If
        If optCenter.Checked = True And optHoSRForm.Checked = True Then
            PA = 0
        End If
        Corr2Min = -r + PA 'R from Refraction
        If optHoSRForm.Checked And GMonth >= 4 And GMonth <= 9 Then
            DI = 15.859
            PA = 0.145 * System.Math.Cos(hainMinutes / 60 * Pi / 180) 'average SD 15.859, median 15.9, Gary LaPook 15.95 (used until V5.4.0), Ron Jones 15.8583; 0.145 is average HP'was 15.859 in V4.9.2, now matches SRF      'these five are the new ones
        End If
        If optHoSRForm.Checked And (GMonth < 4 Or GMonth > 9) Then
            DI = 16.1968
            PA = 0.148 * System.Math.Cos(hainMinutes / 60 * Pi / 180) 'average SD 16.195 (used until V5.4.0) corrected to 16.1968, median 16.15, Gary LaPook 16.15, Ron Jones 16.2167; 0.148 is average HP
        End If
        If optLower.Checked = True Then
            Corr2Min = Corr2Min + DI
        End If
        If optUpper.Checked = True Then
            Corr2Min = Corr2Min - DI
        End If
        If optUpper.Checked = True And GYear >= 1954 And GYear <= 1969 Then
            Corr2Min = Corr2Min - 1.2 '1.2' for irradiation
        End If
        Main_Renamed = 0
        If optLower.Checked = True Then
            Main_Renamed = -Rstd + PA + DI
        End If
        If optUpper.Checked = True Then
            Main_Renamed = -Rstd + PA - DI
        End If
        If optCenter.Checked = True Then
            Main_Renamed = -Rstd
        End If
        HoinMinutes = hainMinutes + Corr2Min 'minutes
        HoDeg = Fix(HoinMinutes / 60) 'min to dec. deg.; Fix was Int
        HoMin = System.Math.Abs(HoinMinutes - 60 * HoDeg)
        If Int(HoMin * 10 + 0.5) / 10 = 60 Then
            HoMin = 0
            HoDeg = HoDeg + 1
        End If
        haDeg = Fix(hainMinutes / 60) 'min. to dec. deg
        haMin = System.Math.Abs(hainMinutes - 60 * haDeg)
        If Int(haMin * 10 + 0.5) / 10 = 60 Then
            haMin = 0
            haDeg = haDeg + 1
        End If
        Return True
    End Function
    Public Sub DisplayNoonSight()
        ClearTextFields()

        If txtHE.Text = "" Then
            HE = 0
        Else
            HE = txtHE.Text.ToString
        End If
        DisplayLANTime()
        DisplayAltitudeData()
        DisplayLatitudeData()
        DisplayAlmanacData()
        Me.Refresh()
        Exit Sub
    End Sub
    Public Sub Refraction()
        'Atmospheric refraction
        TX = Val(txtTemperature.Text)
        If cboTemperature.Text = "F " Then TX = (5 / 9) * (TX - 32)
        PX = Val(txtPressure.Text)
        If cboPressure.Text = "in Hg" Then PX = 33.85853168 * PX

        If optHoSRForm.Checked = True Then
            '        If GYear <= 2003 And TX = 10 And ((Val(txtPressure.text) = 1010 And cboPressure.text = "mbar") Or (Val(txtPressure.text) = 29.83 And cboPressure.text = "in Hg")) And hainMinutes >= 596 Then
            If GYear <= 2003 And hainMinutes >= 596 Then 'And TX = 10 And ((Val(txtPressure.text) = 1010 And cboPressure.text = "mbar") Or (Val(txtPressure.text) = 29.83 And cboPressure.text = "in Hg")) And hainMinutes >= 596 Then

                Select Case hainMinutes
                    Case Is <= 608
                        r = 5.3
                    Case Is <= 620
                        r = 5.2
                    Case Is <= 633
                        r = 5.1
                    Case Is <= 646
                        r = 5
                    Case Is <= 660
                        r = 4.9
                    Case Is <= 674
                        r = 4.8
                    Case Is <= 689
                        r = 4.7
                    Case Is <= 705
                        r = 4.6
                    Case Is <= 721
                        r = 4.5
                    Case Is <= 738
                        r = 4.4
                    Case Is <= 755
                        r = 4.3
                    Case Is <= 774
                        r = 4.2
                    Case Is <= 793
                        r = 4.1
                    Case Is <= 813
                        r = 4
                    Case Is <= 834
                        r = 3.9
                    Case Is <= 856
                        r = 3.8
                    Case Is <= 880
                        r = 3.7
                    Case Is <= 904
                        r = 3.6
                    Case Is <= 930
                        r = 3.5
                    Case Is <= 957
                        r = 3.4
                    Case Is <= 986
                        r = 3.3
                    Case Is <= 1016
                        r = 3.2
                    Case Is <= 1048
                        r = 3.1
                    Case Is <= 1082
                        r = 3
                    Case Is <= 1118
                        r = 2.9
                    Case Is <= 1157
                        r = 2.8
                    Case Is <= 1198
                        r = 2.7
                    Case Is <= 1242
                        r = 2.6
                    Case Is <= 1288
                        r = 2.5
                    Case Is <= 1339
                        r = 2.4
                    Case Is <= 1393
                        r = 2.3
                    Case Is <= 1451
                        r = 2.2
                    Case Is <= 1514
                        r = 2.1
                    Case Is <= 1582
                        r = 2
                    Case Is <= 1656
                        r = 1.9
                    Case Is <= 1736
                        r = 1.8
                    Case Is <= 1824
                        r = 1.7
                    Case Is <= 1920
                        r = 1.6
                    Case Is <= 2025
                        r = 1.5
                    Case Is <= 2140
                        r = 1.4
                    Case Is <= 2268
                        r = 1.3
                    Case Is <= 2408
                        r = 1.2
                    Case Is <= 2564
                        r = 1.1
                    Case Is <= 2736
                        r = 1
                    Case Is <= 2927
                        r = 0.9
                    Case Is <= 3138
                        r = 0.8
                    Case Is <= 3371
                        r = 0.7
                    Case Is <= 3628
                        r = 0.6
                    Case Is <= 3908
                        r = 0.5
                    Case Is <= 4211
                        r = 0.4
                    Case Is <= 4534
                        r = 0.3
                    Case Is <= 4873
                        r = 0.2
                    Case Is <= 5223
                        r = 0.1
                    Case Is <= 5400
                        r = 0
                End Select
            End If

            '            If GYear >= 2004 And TX = 10 And ((Val(txtPressure.text) = 1010 And cboPressure.text = "mbar") Or (Val(txtPressure.text) = 29.83 And cboPressure.text = "in Hg")) And hainMinutes >= 595 Then
            If GYear >= 2004 And hainMinutes >= 595 Then 'And TX = 10 And ((Val(txtPressure.text) = 1010 And cboPressure.text = "mbar") Or (Val(txtPressure.text) = 29.83 And cboPressure.text = "in Hg")) And hainMinutes >= 595 Then

                Select Case hainMinutes
                    Case Is <= 607
                        r = 5.3
                    Case Is <= 620
                        r = 5.2
                    Case Is <= 632
                        r = 5.1
                    Case Is <= 646
                        r = 5
                    Case Is <= 659
                        r = 4.9
                    Case Is <= 674
                        r = 4.8
                    Case Is <= 689
                        r = 4.7
                    Case Is <= 704
                        r = 4.6
                    Case Is <= 720
                        r = 4.5
                    Case Is <= 737
                        r = 4.4
                    Case Is <= 755
                        r = 4.3
                    Case Is <= 773
                        r = 4.2
                    Case Is <= 792
                        r = 4.1
                    Case Is <= 812
                        r = 4
                    Case Is <= 833
                        r = 3.9
                    Case Is <= 856
                        r = 3.8
                    Case Is <= 879
                        r = 3.7
                    Case Is <= 903
                        r = 3.6
                    Case Is <= 929
                        r = 3.5
                    Case Is <= 956
                        r = 3.4
                    Case Is <= 985
                        r = 3.3
                    Case Is <= 1015
                        r = 3.2
                    Case Is <= 1047
                        r = 3.1
                    Case Is <= 1081
                        r = 3
                    Case Is <= 1117
                        r = 2.9
                    Case Is <= 1156
                        r = 2.8
                    Case Is <= 1196
                        r = 2.7
                    Case Is <= 1240
                        r = 2.6
                    Case Is <= 1287
                        r = 2.5
                    Case Is <= 1337
                        r = 2.4
                    Case Is <= 1391
                        r = 2.3
                    Case Is <= 1449
                        r = 2.2
                    Case Is <= 1512
                        r = 2.1
                    Case Is <= 1580
                        r = 2
                    Case Is <= 1654
                        r = 1.9
                    Case Is <= 1734
                        r = 1.8
                    Case Is <= 1822
                        r = 1.7
                    Case Is <= 1918
                        r = 1.6
                    Case Is <= 2023
                        r = 1.5
                    Case Is <= 2138
                        r = 1.4
                    Case Is <= 2265
                        r = 1.3
                    Case Is <= 2406
                        r = 1.2
                    Case Is <= 2562
                        r = 1.1
                    Case Is <= 2734
                        r = 1
                    Case Is <= 2925
                        r = 0.9
                    Case Is <= 3136
                        r = 0.8
                    Case Is <= 3369
                        r = 0.7
                    Case Is <= 3626
                        r = 0.6
                    Case Is <= 3906
                        r = 0.5
                    Case Is <= 4209
                        r = 0.4
                    Case Is <= 4532
                        r = 0.3
                    Case Is <= 4872
                        r = 0.2
                    Case Is <= 5223
                        r = 0.1
                    Case Is <= 5400
                        r = 0
                End Select
            End If
        End If
        RstdA2 = r 'Standard refraction before temperature and pressure applied, from Table A2

        If (GYear <= 2003 And hainMinutes < 596) Or (GYear >= 2004 And hainMinutes < 595) Or ((GYear <= 2003 And hainMinutes >= 596) Or (GYear >= 2004 And hainMinutes >= 595) And ((Val(txtPressure.Text) <> 1010 And cboPressure.Text = "mbar") Or (Val(txtPressure.Text) <> 29.83 And cboPressure.Text = "in Hg")) Or ((Val(txtTemperature.Text) <> 50 And cboTemperature.Text = "F ") Or (Val(txtTemperature.Text) <> 10 And cboTemperature.Text = "C "))) Or optHoParameters.Checked = True Then
            y = hainMinutes / 60
            'R = 58.294 * Tan(Pi / 2 - y) - 0.0668 * Tan(Pi / 2 - y) * Tan(Pi / 2 - y) * Tan(Pi / 2 - y): R = 60 * R
            If GYear <= 2003 Then
                r = y + 7.31 / (y + 4.4)
                'R = R - 0.06 * Sin((14.7 * R / 60) * Pi / 180) 'correction to improve accuracy from 0.07' to 0.015', 2004 or earlier
            Else
                r = y + 7.32 / (y + 4.32)
            End If
            r = r * Pi / 180
            r = 1 / System.Math.Tan(r)
            If GYear <= 2003 Then r = r - 0.06 * System.Math.Sin((14.7 * (r / 60) + 13) * Pi / 180) 'correction to improve accuracy from 0.07' to 0.015', 2004 or earlier
            Rstd = r 'added in 5.1.5
        End If
        'R = -0.97 * Tan(((y * Pi / 180) - Atn(12 * (y + 3))))   'formula from The Calculator Afloat - better for some values of y (ha)
        '        If (GYear <= 2003 And hainMinutes >= 596) Or (GYear >= 2004 And hainMinutes >= 595) Then RstdTP = Rstd Else RstdTP = r   'removed in 5.1.5
        RstdTP = r 'replaced previous line in 5.1.5
        'End If
        If r < 0 Then r = 0 'This line added to get rid of negative values at very high altitudes under certain circumstances
        '    Rstd = r    'Standard refraction before temperature and pressure applied
        r = r * (283 / 1010) * PX / (TX + 273) 'PX=1010, TX=10    Total Refraction    Constant was 0.28019802
        Raddl = r - RstdTP
        ''    Rstd = RstdTP       'to make the proper Main correction print     removed in 5.1.5
        If (GYear <= 2003 And hainMinutes >= 596) Or (GYear >= 2004 And hainMinutes >= 595) Then Rstd = RstdA2
    End Sub

    Public Function DipCalc() As Double
        Dim Dip As Double = 0
        HE = Val(txtHE.Text)
        If cboHE.Text = "ft" Then HEinFeet = HE
        If cboHE.Text = "m " Then HEinFeet = HE * 3.28095
        If cboHE.Text = "in" Then HEinFeet = HE / 12
        If cboHE.Text = "cm" Then HEinFeet = HE * 0.0328095
        If cboHE.Text = "ft" Or cboHE.Text = "m " Then HE = Int(HE * 10 + 0.5) / 10
        If cboHE.Text = "in" Then HE = Int((HE / 12) * 10 + 0.5) / 10
        If cboHE.Text = "cm" Then HE = Int((HE / 100) * 10 + 0.50000001) / 10

        DipShortDist = Val(txtDsDist.Text)
        'Convert distance to dip short horizon to nautical miles
        If cboDsUnit.Text = "feet" Then DipShortDist = DipShortDist / 6076.1
        If cboDsUnit.Text = "yards" Then DipShortDist = DipShortDist * 3 / 6076.1
        If cboDsUnit.Text = "meters" Then DipShortDist = DipShortDist / 1852
        If cboDsUnit.Text = "statute miles" Then DipShortDist = DipShortDist * 5280 / 6076.1
        'Check if dip short distance is greater than distance to natural horizon
        If optHorizonDipShort.Checked = True And DipShortDist > 1.169 * System.Math.Sqrt(HEinFeet) Then
            ErrorMsgBox("Dip short distance exceeded distance to natural horizon.  Natural horizon will be used.", "Input Error", MessageBoxButtons.OK)
            optHorizonNatural.Checked = True
            txtDsDist.Text = ""
        End If
        If optHorizonDipShort.Checked = True Then Dip = (10800 / Pi) * System.Math.Atan(HEinFeet / (6076.1 * DipShortDist) + 0.8321 * DipShortDist / 6880.2)
        'Convert C to F
        Temperature = Val(txtTemperature.Text)
        If cboTemperature.Text = "C " Then Temperature = (5 / 9) * (Temperature - 32)
        'Convert mbar to in Hg
        Pressure = Val(txtPressure.Text)
        If cboPressure.Text = "mbar" Then Pressure = 33.858532 * Pressure
        'Calculate dip
        If optHorizonNatural.Checked = True And (cboHE.Text = "ft" Or cboHE.Text = "in") Then
            Select Case HE
                Case Is < 2
                    Dip = 0.7 * HE
                Case Is <= 3.9
                    Dip = 1.4 + (HE - 2.0) * 0.25
                Case Is <= 5.9
                    Dip = 1.9 + (HE - 4.0) * 0.25
                Case Is <= 7.6
                    Dip = 2.4 + (HE - 6.0) * 0.15
                Case Is >= 7.7
                    Dip = 0.970003 * System.Math.Sqrt(HE)
            End Select
        End If
        If optHorizonNatural.Checked = True And (cboHE.Text = "m " Or cboHE.Text = "cm") Then
            Select Case HE
                Case Is < 1
                    Dip = 1.79 * HE
                Case Is <= 1.6
                    Dip = 1.79 * System.Math.Sqrt(HE)
                Case Is >= 1.7
                    Dip = 1.76 * System.Math.Sqrt(HE)
            End Select
        End If
        Dip = Int(Dip * 10 + 0.5) / 10
        Return Dip
    End Function

    Private Sub optHorizonArtificial_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optHorizonArtificial.CheckedChanged
        If eventSender.Checked Then
            If optHorizonArtificial.Checked = True Then
                lblHE.Visible = False
                txtHE.Visible = False
                'txtHE.Enabled = False
                cboHE.Visible = False
                'cboHE.Enabled = False
                lblDsDist.Visible = False
                txtDsDist.Visible = False
                'txtDsDist.Enabled = False
                cboDsUnit.Visible = False
                'cboDsUnit.Enabled = False
                'optCenter.Visible = True
            End If
        End If
    End Sub

    Private Sub optHorizonDipShort_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optHorizonDipShort.CheckedChanged
        If eventSender.Checked Then
            If optHorizonDipShort.Checked = True Then
                lblHE.Visible = True
                txtHE.Visible = True
                'txtHE.Enabled = True
                cboHE.Visible = True
                'cboHE.Enabled = True
                lblDsDist.Visible = True
                txtDsDist.Visible = True
                'txtDsDist.Enabled = True
                cboDsUnit.Visible = True
                'cboDsUnit.Enabled = True
                'optCenter.Visible = False
            End If

            If optCenter.Checked = True Then
                SendMsgBx("Caution:  Improper combination of limb and horizon.")
            End If

        End If
    End Sub

    Private Sub optHorizonNatural_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optHorizonNatural.CheckedChanged
        If eventSender.Checked Then
            If optHorizonNatural.Checked = True Then
                lblHE.Visible = True
                txtHE.Visible = True
                'txtHE.Enabled = True
                cboHE.Visible = True
                'cboHE.Enabled = True
                lblDsDist.Visible = False
                txtDsDist.Visible = False
                'txtDsDist.Enabled = False
                cboDsUnit.Visible = False
                'cboDsUnit.Enabled = False
                'optCenter.Visible = False
            End If

            If optCenter.Checked = True Then
                SendMsgBx("Caution:  Improper combination of limb and horizon.")
            End If

        End If
    End Sub

    Private Sub optHsDMm_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optHsDMm.CheckedChanged
        If eventSender.Checked Then
            If optHsDMm.Checked = True Then
                txtHsSec.Visible = False
                lblHsSec.Visible = False
                'txtHsSec.Enabled = False
                txtIESec.Visible = False
                lblIEsec.Visible = False
                'txtIESec.Enabled = False
                txtHsMin.Text = ""
                txtIEmin.Text = ""
            End If
        End If
    End Sub

    Private Sub optHsDMS_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optHsDMS.CheckedChanged
        If eventSender.Checked Then
            If optHsDMS.Checked = True Then
                txtHsSec.Visible = True
                lblHsSec.Visible = True
                'txtHsSec.Enabled = True
                txtIESec.Visible = True
                lblIEsec.Visible = True
                'txtIESec.Enabled = True
                txtHsMin.Text = ""
                txtIEmin.Text = ""
                txtHsSec.Text = ""
                txtIESec.Text = ""
            End If
        End If
    End Sub

    Public Function LatCalc() As Integer
        'TotDE = TotDecDegrees + TotDecMinutes / 60
        ZenithDistinDeg = ZenithDistDeg + ZenithDistMin / 60
        SunAzN = False
        SunAzS = False
        If optAzN.Checked = True Then SunAzN = True
        If optAzS.Checked = True Then SunAzS = True
        If optDRL.Checked = True Then Latitude()
        If optDRL.Checked = True And DRL >= TotDE Then SunAzS = True
        If optDRL.Checked = True And DRL < TotDE Then SunAzN = True
        If SunAzN = True And TotDE >= 0 And ZenithDistinDeg < System.Math.Abs(TotDE) Then
            Lat = System.Math.Abs(TotDE) - ZenithDistinDeg
            LH = g_LatN
            dh = "-"
        End If
        If SunAzN = True And TotDE >= 0 And ZenithDistinDeg >= System.Math.Abs(TotDE) Then
            Lat = ZenithDistinDeg - System.Math.Abs(TotDE)
            LH = g_LatS
            dh = "-"
        End If
        If SunAzN = True And TotDE < 0 Then
            Lat = ZenithDistinDeg + System.Math.Abs(TotDE)
            LH = g_LatS
            dh = "+"
        End If
        If SunAzS = True And TotDE >= 0 Then
            Lat = System.Math.Abs(TotDE) + ZenithDistinDeg
            LH = g_LatN
            dh = "+"
        End If
        If SunAzS = True And TotDE < 0 And ZenithDistinDeg >= System.Math.Abs(TotDE) Then
            Lat = ZenithDistinDeg - System.Math.Abs(TotDE)
            LH = g_LatN
            dh = "-"
        End If
        If SunAzS = True And TotDE < 0 And ZenithDistinDeg < System.Math.Abs(TotDE) Then
            Lat = System.Math.Abs(TotDE) - ZenithDistinDeg
            LH = g_LatS
            dh = "-"
        End If
        If Lat = 0 Then LH = " "
        'Lat = Abs(Lat)
        If LH = g_LatS Then Lat = -Lat
        LDeg = Int(System.Math.Abs(Lat))
        LMin = (System.Math.Abs(Lat) - LDeg) * 60
        If LMin = 60 Then
            LMin = 0
            LDeg += +1
        End If
        If System.Math.Sign(Lat) = System.Math.Sign(DRL) Then
            Ldiff = System.Math.Abs(Lat - DRL)
        End If
        If System.Math.Sign(Lat) <> System.Math.Sign(DRL) Then
            Ldiff = System.Math.Abs(Lat) + System.Math.Abs(DRL)
        End If
        Ldiff = 60 * Ldiff
        Return True
    End Function
    Private Sub DisplayAlmanacData()
        DGAlm.Visible = True
        Dim AltHdr As String() = {"Category", "Info1"}
        Dim DataSet1 As DataSet = New DataSet()
        DataSet1.Tables.Add("Table1")
        DataSet1.DataSetName = "Table1"
        DGAlm.DataSource = DataSet1
        For i As Integer = 0 To UBound(AltHdr)
            DataSet1.Tables("Table1").Columns.Add(AltHdr(i))
            DataSet1.Tables("Table1").Columns(i).AllowDBNull = False
            DataSet1.Tables("Table1").Columns(i).DefaultValue = ""
        Next
        DGAlm.DataSource = DataSet1.Tables(0).DefaultView
        For i As Integer = 0 To DGAlm.Columns.Count - 1
            DGAlm.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            DGAlm.Columns(i).MinimumWidth = 104
            'DGAlm.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGAlm.Columns(i).DefaultCellStyle.Font = New Font("Arial", 8, FontStyle.Regular)
        Next
        DGAlm.ColumnHeadersVisible = False
        DGAlm.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DGAlm.DefaultCellStyle.Font = New Font("Arial", 8, FontStyle.Regular)
        DGAlm.DefaultCellStyle.BackColor = Color.LightGray
        DGAlm.DefaultCellStyle.SelectionBackColor = Color.LightGray
        DGAlm.DefaultCellStyle.SelectionForeColor = DGLAN.DefaultCellStyle.ForeColor
        DGAlm.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DGAlm.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        DGAlm.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'DGAlm.Columns(0).MinimumWidth = 85
        'DGAlm.Columns(1).MinimumWidth = 85
        'DGAlm.Columns(1).MinimumWidth = 85

        'Dim tempstr1 As String = ""
        Dim tempstr2 As String = ""
        Dim tempstr3 As String = ""
        ' alamanc text box  formatting - alignment is centered

        AlmanacTxtBx.Text = "ALMANAC - Dec"
        AlmanacTxtBx.TextAlign = HorizontalAlignment.Center

        tempstr2 = "Dec " & GHour.ToString("00") & Space(2) & "hr"
        tempstr3 = (System.Math.Abs(DecDegrees)).ToString("0") & Chr(176) & DecMinutes.ToString("00.0") & "'"
        If DE * 60 >= 0.05 Then
            tempstr3 &= g_LatN
        End If
        If System.Math.Abs(DE * 60) < 0.05 Then
            tempstr3 &= " "
        End If
        If DE * 60 < 0.05 Then
            tempstr3 &= g_LatS
        End If
        DataSet1.Tables("Table1").Rows.Add(tempstr2, tempstr3)

        tempstr3 = ""
        tempstr2 = "d ("
        If Signdvalue = 0 Then
            tempstr2 &= " ) "
        ElseIf Signdvalue = 1 Then
            tempstr2 &= " +) "
        ElseIf Signdvalue = -1 Then
            tempstr2 &= "-) "
        End If
        tempstr2 &= Space(1) & (System.Math.Abs(dvalue)).ToString("0.0") & "'"
        DataSet1.Tables("Table1").Rows.Add(tempstr2, tempstr3)

        tempstr3 = ""
        tempstr2 = Space(3) & "d corr ("
        If Signdvalue = 0 Then
            tempstr2 &= " ) "
        ElseIf Signdvalue = 1 Then
            tempstr2 &= "+) "
        ElseIf Signdvalue = -1 Then
            tempstr2 &= "-) "
        End If
        tempstr3 = Space(6) & dcorr.ToString("0.0") & "'"
        DataSet1.Tables("Table1").Rows.Add(tempstr2, tempstr3)

        tempstr2 = "Dec"
        tempstr3 = (System.Math.Abs(TotDecDegrees)).ToString("0") & Chr(176) & TotDecMinutes.ToString("00.0") & "'"
        If TotDE > 0 Then
            tempstr3 &= g_LatN
        End If
        If TotDE = 0 Then
            tempstr3 &= " "
        End If
        If TotDE < 0 Then
            tempstr3 &= g_LatS
        End If
        DataSet1.Tables("Table1").Rows.Add(tempstr2, tempstr3)

        DataSet1.Dispose()
        DGAlm.ClearSelection()
        DGAlm.CurrentCell = Nothing
        Exit Sub
    End Sub
    Private Sub DisplayLatitudeData()
        DGLat.Visible = True
        Dim AltHdr As String() = {"Category", "Info1"}
        Dim DataSet1 As DataSet = New DataSet()
        DataSet1.Tables.Add("Table1")
        DataSet1.DataSetName = "Table1"
        DGLat.DataSource = DataSet1
        For i As Integer = 0 To UBound(AltHdr)
            DataSet1.Tables("Table1").Columns.Add(AltHdr(i))
            DataSet1.Tables("Table1").Columns(i).AllowDBNull = False
            DataSet1.Tables("Table1").Columns(i).DefaultValue = ""
        Next
        DGLat.DataSource = DataSet1.Tables(0).DefaultView
        For i As Integer = 0 To DGLat.Columns.Count - 1
            DGLat.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            DGLat.Columns(i).MinimumWidth = 114
            DGLat.Columns(i).DefaultCellStyle.Font = New Font("Arial", 8, FontStyle.Regular)
        Next
        DGLat.ColumnHeadersVisible = False
        DGLat.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DGLat.DefaultCellStyle.Font = New Font("Arial", 8, FontStyle.Regular)
        DGLat.DefaultCellStyle.BackColor = Color.LightGray
        DGLat.DefaultCellStyle.SelectionBackColor = Color.LightGray
        DGLat.DefaultCellStyle.SelectionForeColor = DGLAN.DefaultCellStyle.ForeColor
        DGLat.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DGLat.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGLat.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        'DGLat.Columns(1).MinimumWidth = 85

        Dim tempstr1 As String = ""
        Dim tempstr2 As String = ""

        'Now format Latitude Text Box
        LatitudeTxtBx.ResetText()

        Dim TextString As String = ""
        If OldFormBtn.Checked = True Then
            LatitudeTxtBx.Text = "Latitude Computation"
            tempstr1 = "Z "
            tempstr2 = "89" & Chr(176) & "60.0'"
            DataSet1.Tables("Table1").Rows.Add(tempstr1, tempstr2)

            tempstr1 = "Ho (-)"
            If System.Math.Sign(HoinMinutes) = -1 Then
                tempstr2 = "-"
            End If
            tempstr2 &= (System.Math.Abs(HoDeg)).ToString("0") & Chr(176) & HoMin.ToString("00.0") & "'"
            DataSet1.Tables("Table1").Rows.Add(tempstr1, tempstr2)

            tempstr1 = "z"
            tempstr2 = ZenithDistDeg.ToString("0") & Chr(176) & ZenithDistMin.ToString("00.0") & "'"
            DataSet1.Tables("Table1").Rows.Add(tempstr1, tempstr2)

            tempstr1 = "Dec (" & dh & ")"
            TextString = TotDecDegrees.ToString("0") & Chr(176) & TotDecMinutes.ToString("00.0") & "'"
            If TotDE > 0 Then TextString &= g_LatN
            If TotDE = 0 Then TextString &= " "
            If TotDE < 0 Then TextString &= g_LatS
            tempstr2 = TextString
            TextString = vbNull
            DataSet1.Tables("Table1").Rows.Add(tempstr1, tempstr2)

            tempstr1 = "Lat"
            tempstr2 = LDeg.ToString("0") & Chr(176) & LMin.ToString("00.0") & "'" & LH
            DataSet1.Tables("Table1").Rows.Add(tempstr1, tempstr2)

            If optDRL.Checked = True Then
                tempstr1 = "DR Lat"
                tempstr2 = Val(txtDRLDeg.Text).ToString("0") & Chr(176) & Val(DRLMin).ToString("00.0") & "'" & cboDRL.Text
                DataSet1.Tables("Table1").Rows.Add(tempstr1, tempstr2)
            End If

            If optDRL.Checked = True Then
                tempstr1 = "l diff"
                tempstr2 = Space(4) & Ldiff.ToString("##0.0") & "'"
                DataSet1.Tables("Table1").Rows.Add(tempstr1, tempstr2)
            End If
        End If
        If NewFormBtn.Checked = True Then
            LatitudeTxtBx.Text = "LATITUDE BY MERIDIAN TRANSIT"

            tempstr1 = "90" & Chr(176) & "="
            tempstr2 = "89" & Chr(176) & "60.0'"
            DataSet1.Tables("Table1").Rows.Add(tempstr1, tempstr2)

            tempstr1 = "-Ho"
            tempstr2 = (System.Math.Abs(HoDeg)).ToString("0") & Chr(176) & HoMin.ToString("00.0") & "'"
            DataSet1.Tables("Table1").Rows.Add(tempstr1, tempstr2)

            tempstr1 = "Co-Alt=90" & Chr(176) & "-Ho"
            tempstr2 = ZenithDistDeg.ToString("0") & Chr(176) & ZenithDistMin.ToString("00.0") & "'"
            If TotDE < Lat Then tempstr2 &= g_LatN
            If TotDE > Lat Then tempstr2 &= g_LatS
            If TotDE = Lat Then tempstr2 &= " "
            DataSet1.Tables("Table1").Rows.Add(tempstr1, tempstr2)

            tempstr1 = "Dec"
            TextString = TotDecDegrees.ToString("0") & Chr(176) & TotDecMinutes.ToString("00.0") & "'"
            If TotDE > 0 Then TextString &= g_LatN
            If TotDE = 0 Then TextString &= " "
            If TotDE < 0 Then TextString &= g_LatS
            tempstr2 = TextString
            DataSet1.Tables("Table1").Rows.Add(tempstr1, tempstr2)
            TextString = vbNull

            tempstr1 = "L=Dec+Co-Alt"
            tempstr2 = LDeg.ToString("0") & Chr(176) & LMin.ToString("00.0") & "'" & LH
            DataSet1.Tables("Table1").Rows.Add(tempstr1, tempstr2)

            If optDRL.Checked = True Then
                tempstr1 = "DR Lat"
                tempstr2 = Val(txtDRLDeg.Text).ToString("0") & Chr(176) & Val(DRLMin).ToString("00.0") & "'" & cboDRL.Text
                DataSet1.Tables("Table1").Rows.Add(tempstr1, tempstr2)
                tempstr1 = "Diff between L and DR L in nm:"
                tempstr2 = Ldiff.ToString("##0.0") & " nm"
                DataSet1.Tables("Table1").Rows.Add(tempstr1, tempstr2)
            End If


        End If
        DataSet1.Dispose()
        DGLat.ClearSelection()
        DGLat.CurrentCell = Nothing
        Exit Sub
    End Sub
    Private Sub DisplayAltitudeData()
        DGAlt.Visible = True
        Dim AltHdr As String() = {"Category", "Info1", "Info2"}
        Dim DataSet1 As DataSet = New DataSet()
        DataSet1.Tables.Add("Table1")
        DataSet1.DataSetName = "Table1"
        DGAlt.DataSource = DataSet1
        For i As Integer = 0 To UBound(AltHdr)
            DataSet1.Tables("Table1").Columns.Add(AltHdr(i))
            DataSet1.Tables("Table1").Columns(i).AllowDBNull = False
            DataSet1.Tables("Table1").Columns(i).DefaultValue = ""
        Next
        DGAlt.DataSource = DataSet1.Tables(0).DefaultView
        For i As Integer = 0 To DGAlt.Columns.Count - 1
            DGAlt.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            DGAlt.Columns(i).MinimumWidth = 69
            DGAlt.Columns(i).DefaultCellStyle.Font = New Font("Arial", 8, FontStyle.Regular)
        Next
        DGAlt.ColumnHeadersVisible = False
        DGAlt.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DGAlt.DefaultCellStyle.Font = New Font("Arial", 8, FontStyle.Regular)
        DGAlt.DefaultCellStyle.BackColor = Color.LightGray
        DGAlt.DefaultCellStyle.SelectionBackColor = Color.LightGray
        DGAlt.DefaultCellStyle.SelectionForeColor = DGLAN.DefaultCellStyle.ForeColor
        DGAlt.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DGAlt.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
        DGAlt.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        DGAlt.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight

        'DGAlt.Columns(0).MinimumWidth = 85
        'DGAlt.Columns(1).MinimumWidth = 85
        'DGAlt.Columns(1).MinimumWidth = 85

        Dim tempstr1 As String = ""
        Dim tempstr2 As String = ""
        Dim tempstr3 As String = ""

        AltitudeTxtBx.AppendText("ALTITUDE")
        tempstr1 = "Ht of eye"
        tempstr2 = HE.ToString("0.0")
        If cboHE.Text.ToString = "ft" Or cboHE.Text = "in" Then
            tempstr2 &= " ft"
        ElseIf cboHE.Text = "m " Or cboHE.Text = "cm" Then
            tempstr2 &= " m"
        Else
            tempstr2 &= " ft"
        End If
        tempstr3 = ""
        DataSet1.Tables("Table1").Rows.Add(tempstr1, tempstr2, tempstr3)

        tempstr1 = "hs"
        tempstr2 = ""
        tempstr3 = txtHsDeg.Text.ToString.Trim & Chr(176) & HsMin.ToString("00.0") & "'"

        If optHsDMS.Checked = True Then
            tempstr3 &= txtHsSec.Text.ToString.Trim
        End If
        DataSet1.Tables("Table1").Rows.Add(tempstr1, tempstr2, tempstr3)

        tempstr1 = "   IC"
        tempstr2 = "("
        If ICinMinutes = 0 Then
            tempstr2 &= " "
        ElseIf cboIE.Text = "on the arc" And ICinMinutes <> 0 Then
            tempstr2 &= "-"
        ElseIf (cboIE.Text = "off the arc (rdg.)" Or cboIE.Text = "off the arc (val.)") And ICinMinutes <> 0 Then
            tempstr2 &= "+"
        End If
        tempstr2 &= ")" & Space(1)
        Dim TempIEDeg As String = txtIEdeg.Text.ToString
        If TempIEDeg = "" Then
            TempIEDeg = "0"
        End If
        tempstr2 &= TempIEDeg.ToString
        tempstr2 &= Chr(176) & ICMin.ToString("00.0") & "'"
        tempstr3 = ""
        DataSet1.Tables("Table1").Rows.Add(tempstr1, tempstr2, tempstr3)

        If optHorizonArtificial.Checked = False Then
            tempstr1 = "   Dip"
            Dim LcLDip As Double = DipCalc()
            tempstr2 = "(-)" & Space(7 - LcLDip.ToString.Length) & LcLDip.ToString("##0.0") & "'"
            tempstr3 = ""
            DataSet1.Tables("Table1").Rows.Add(tempstr1, tempstr2, tempstr3)
        Else
            tempstr1 = ""
            tempstr2 = ""
            tempstr3 = ""
        End If


        tempstr1 = "      Corr"
        tempstr2 = "("
        If Corr1 > 0 Then tempstr2 &= "+"
        If Corr1 = 0 Then tempstr2 &= " "
        If Corr1 < 0 Then tempstr2 &= "-"
        tempstr2 &= ")" & Space(1) & Corr1Deg.ToString("0") & Chr(176) & Corr1Min.ToString("00.0") & "'"
        tempstr3 = ""
        DataSet1.Tables("Table1").Rows.Add(tempstr1, tempstr2, tempstr3)

        tempstr1 = "ha"
        tempstr2 = ""
        tempstr3 = ""
        If System.Math.Sign(hainMinutes) = -1 Then
            tempstr3 = "-"
        Else
            tempstr3 = " "
        End If
        tempstr3 &= (System.Math.Abs(haDeg)).ToString("0").Trim & Chr(176) & haMin.ToString("00.0") & "'"
        DataSet1.Tables("Table1").Rows.Add(tempstr1, tempstr2, tempstr3)

        tempstr1 = ""
        tempstr2 = ""
        tempstr3 = ""
        If optHoSRForm.Checked = True Then
            tempstr1 = Space(3) & "Main"
            tempstr2 = "("
            If Main_Renamed > 0 Then
                tempstr2 &= "+"
            End If
            If Main_Renamed = 0 Then
                tempstr2 &= " "
            End If
            If Main_Renamed < 0 Then
                tempstr2 &= "-"
            End If
            tempstr2 &= ")" & Space(3) & (Int(System.Math.Abs(Main_Renamed * 10) + 0.5) / 10).ToString("00.0") & "'"
            tempstr3 = ""
            DataSet1.Tables("Table1").Rows.Add(tempstr1, tempstr2, tempstr3)
        End If

        If optHoParameters.Checked Then
            tempstr1 = Space(3) & "Refraction"
            tempstr2 = "(-)" & Space(3) & (Int(r * 1000 + 0.5) / 1000).ToString("00.000") & "'"
            tempstr3 = ""
            DataSet1.Tables("Table1").Rows.Add(tempstr1, tempstr2, tempstr3)
        End If

        If optHoSRForm.Checked = True Then
            tempstr1 = Space(3) & "Add'l Ref"
            tempstr2 = ""
            tempstr3 = ""
            If optStdTPNo.Checked = True And System.Math.Sign(Raddl) = 1 Then
                tempstr2 = "(-)" & Space(3) & (System.Math.Abs(Raddl)).ToString("0.0") & "'"
            End If
            If optStdTPNo.Checked = True And System.Math.Sign(Raddl) = -1 Then
                tempstr2 = "(+)" & Space(3) & (System.Math.Abs(Raddl)).ToString("0.0") & "'"
            End If
            If OptStdTPYes.Checked = True Then
                tempstr2 = ""
            End If
            DataSet1.Tables("Table1").Rows.Add(tempstr1, tempstr2, tempstr3)
        End If

        If optHoParameters.Checked = True Then
            tempstr1 = Space(3) & "Parallax"
            tempstr2 = "(+)" & Space(3) & PA.ToString("00.000") & "'"
            tempstr3 = ""
            DataSet1.Tables("Table1").Rows.Add(tempstr1, tempstr2, tempstr3)
        End If

        If optHoParameters.Checked = True And optCenter.Checked = False Then
            tempstr1 = Space(3) & "Semi-diameter"
            tempstr2 = ""
            tempstr3 = ""
            If optLower.Checked = True Then
                tempstr2 = "(+)"
            End If
            If optUpper.Checked = True Then
                tempstr2 = "(-)"
            End If
            tempstr2 &= Space(3) & DI.ToString("00.000") & "'"
            DataSet1.Tables("Table1").Rows.Add(tempstr1, tempstr2, tempstr3)
        End If

        tempstr1 = Space(6) & "Corr"
        tempstr2 = "("
        If Corr2Min > 0 Then
            tempstr2 &= "+"
        End If
        If Corr2Min = 0 Then
            tempstr2 &= " "
        End If
        If Corr2Min < 0 Then
            tempstr2 &= "-"
        End If
        tempstr2 &= ")" & Space(3) & (System.Math.Abs(Corr2Min)).ToString("00.0") & "'"
        tempstr3 = ""
        DataSet1.Tables("Table1").Rows.Add(tempstr1, tempstr2, tempstr3)

        tempstr1 = "Ho"
        tempstr2 = ""

        If System.Math.Sign(HoinMinutes) = -1 Then
            tempstr3 = "-"
        Else
            tempstr3 = " "
        End If
        tempstr3 &= (System.Math.Abs(HoDeg)).ToString("0") & Chr(176) & HoMin.ToString("00.0") & "'"
        DataSet1.Tables("Table1").Rows.Add(tempstr1, tempstr2, tempstr3)

        tempstr1 = ""
        tempstr2 = ""
        If optHorizonArtificial.Checked = True Then
            tempstr1 = " ha adjusted for artificial horizon"
        End If
        If BackSight = True And optHorizonArtificial.Checked = False Then
            tempstr2 = "ha adjusted for back sight"
        End If
        If optHorizonArtificial.Checked = True Or BackSight = True Then
            DataSet1.Tables("Table1").Rows.Add(tempstr1, tempstr2, "")
        End If

        DataSet1.Dispose()
        DGAlt.ClearSelection()
        DGAlt.CurrentCell = Nothing
        Exit Sub
    End Sub
    Public Sub DisplayLANTime()
        DGLAN.Visible = True
        Dim LANHdr As String() = {"Category", "Info"}
        Dim DataSet1 As DataSet = New DataSet()
        DataSet1.Tables.Add("Table1")
        DataSet1.DataSetName = "Table1"
        DGLAN.DataSource = DataSet1
        For i As Integer = 0 To UBound(LANHdr)
            DataSet1.Tables("Table1").Columns.Add(LANHdr(i))
            DataSet1.Tables("Table1").Columns(i).AllowDBNull = False
            DataSet1.Tables("Table1").Columns(i).DefaultValue = ""
        Next
        DGLAN.DataSource = DataSet1.Tables(0).DefaultView
        For i As Integer = 0 To DGLAN.Columns.Count - 1
            DGLAN.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            DGLAN.Columns(i).DefaultCellStyle.Font = New Font("Arial", 8, FontStyle.Regular)
        Next
        DGLAN.Columns(0).MinimumWidth = 115
        DGLAN.Columns(1).MinimumWidth = 105

        DGLAN.ColumnHeadersVisible = False
        DGLAN.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DGLAN.DefaultCellStyle.Font = New Font("Arial", 8, FontStyle.Regular)
        DGLAN.DefaultCellStyle.BackColor = Color.LightGray
        DGLAN.DefaultCellStyle.SelectionBackColor = Color.LightGray
        DGLAN.DefaultCellStyle.SelectionForeColor = DGLAN.DefaultCellStyle.ForeColor
        DGLAN.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DGLAN.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        DGLAN.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        EqTFactor = CalcEqTFactor()
        EqTimeFactorMin = Int(System.Math.Abs(EqTFactor))
        EqTimeFactorSec = (System.Math.Abs(EqTFactor) - EqTimeFactorMin) * 60

        Dim Fld1Len As Integer = (LANTimeTxtBx.ToString.Length / 2)
        Dim TempStr1 As String = Space(Fld1Len)
        Dim TempStr2 As String = Space(Fld1Len)
        ZD = System.Math.Abs(Val(txtZDh.Text))
        If optZDManual.Checked = False Then
            ZDMan = ZD
        End If
        If optZDManual.Checked = True Then
            ZDMan = System.Math.Abs(ZD) + Val(cboZDm.Text) / 60
        End If
        If VB.Left(txtZDh.Text, 1) = "-" Then
            ZDMan = -ZDMan
            ZD = -ZD
        End If
        'GHour = GHour - 1   'corrects GHour for additional hour added in Greenwich
        If chkDST.CheckState = 1 Then
            ZD = ZD - 1
            ZDMan = ZDMan - 1 ': GHour = GHour - 1
        End If

        'NEED TO DO TEXT ALIGNMENT IF DO NOT WANT LEADING ZEROS ON Lo AND GHA
        If cboLo.Text = "W" Then
            LoforLAN = Lo
        Else
            LoforLAN = 360 - System.Math.Abs(Lo)
        End If

        LoforLANDeg = Int(LoforLAN)
        LoforLANMin = (LoforLAN - LoforLANDeg) * 60
        LoforLANMin = Int(LoforLANMin * 10 + 0.5) / 10

        LANTimeTxtBx.Text = "TIME OF LAN"

        If cboLo.Text = "E" Then
            TempStr1 = ("360" & Chr(176) & " - LoE")
        Else
            TempStr1 = ("LoW")
        End If
        TempStr2 = LoforLANDeg.ToString("##0") & Chr(176) & LoforLANMin.ToString("00.0") & "'"
        DataSet1.Tables("Table1").Rows.Add(TempStr1, TempStr2)

        TempStr1 = "GHA Sun " & GHourLAN.ToString("00") & " h"
        TempStr2 = GHADeg.ToString("000") & Chr(176) & GHAMin.ToString("00.0") & "'"
        DataSet1.Tables("Table1").Rows.Add(TempStr1, TempStr2)

        GHADiffDeg = Int(GHADiff)
        GHADiffMin = (GHADiff - GHADiffDeg) * 60
        GHADiffMin = Int(GHADiffMin * 10 + 0.5) / 10
        If GHADiffMin = 60 Then
            GHADiffMin = 0
            GHADiffDeg = GHADiffDeg + 1
        End If
        TempStr1 = "GHA Difference"
        TempStr2 = GHADiffDeg.ToString("##0") & Chr(176) & GHADiffMin.ToString("00.0") & "'"
        DataSet1.Tables("Table1").Rows.Add(TempStr1, TempStr2)
        FormatZTLAN()


        TempStr1 = "Actual Lo Corr:" & "(mm:ss)"
        TempStr2 = LANMinutes.ToString("00") & ":" & LANSeconds.ToString("00")
        DataSet1.Tables("Table1").Rows.Add(TempStr1, TempStr2)

        If cboLo.SelectedItem.ToString = "W" Then
            GHourLANDisplay = ZTofLANHours + ZD
        Else
            GHourLANDisplay = ZTofLANHours - ZD
        End If
        If GHourLANDisplay > 24 Then
            GHourLANDisplay -= 24
        End If
        If GHourLANDisplay < 0 Then
            GHourLANDisplay += 24
        End If
        TempStr1 = "UT of LAN"
        TempStr2 = GHourLANDisplay.ToString("00") & "-" & LANMinutes.ToString("00") & "-" & LANSeconds.ToString("00")
        DataSet1.Tables("Table1").Rows.Add(TempStr1, TempStr2)

        TempStr1 = "ZD" & "("
        If optZDManual.Checked = False Then
            If System.Math.Sign(ZD) = 1 Then 'LANTimeTxtLeft.AppendText
                TempStr1 &= "+"
            End If
            If System.Math.Sign(ZD) = -1 Then 'LANTimeTxtLeft.AppendText(
                TempStr1 &= "-"
            End If
            If System.Math.Sign(ZD) = 0 Then
                'LANTimeTxtLeft.AppendText
                TempStr1 &= " "
            End If
        End If
        If optZDManual.Checked = True Then
            If System.Math.Sign(ZDMan) = 1 Then
                TempStr1 &= "+"
            End If
            If System.Math.Sign(ZDMan) = -1 Then
                TempStr1 &= "-"
            End If
            If System.Math.Sign(ZDMan) = 0 Then
                TempStr1 &= " "
            End If
        End If
        TempStr1 &= ")"

        TempStr2 = Space(3 - (System.Math.Abs(ZD)).ToString.Length) & (System.Math.Abs(ZD)).ToString("#0") 'Format(Abs(Val(txtZDh.Text)), "00");
        If optZDManual.Checked = True And cboZDm.Text <> "00" Then
            TempStr2 &= "-" & cboZDm.Text
        End If
        If optZDManual.Checked = True And cboZDm.Text <> "00" Then
            TempStr2 &= "      (rev)"
        Else
            TempStr2 &= "      (rev)"
        End If
        DataSet1.Tables("Table1").Rows.Add(TempStr1, TempStr2)
        'FormatZTLAN()

        TempStr1 = "ZT of LAN"
        TempStr2 = ZTofLANHours.ToString("00") & "-" & ZTofLANMinutes.ToString("00") & "-" & ZTofLANSeconds.ToString("00")
        DataSet1.Tables("Table1").Rows.Add(TempStr1, TempStr2)

        TempStr1 = "EqTime Factor:" & "(mm:ss)"
        If EqTFactor < 0 Then
            TempStr2 = "-" & EqTimeFactorMin.ToString("00") & ":" & EqTimeFactorSec.ToString("00") & "(mm:ss)"
        Else
            TempStr2 = EqTimeFactorMin.ToString("00") & ":" & EqTimeFactorSec.ToString("00")
        End If
        DataSet1.Tables("Table1").Rows.Add(TempStr1, TempStr2)

        DGLAN.Refresh()
        DGLAN.ClearSelection()
        DGLAN.CurrentCell = Nothing
        DataSet1.Dispose()
        'txtTime.Text = ZTofLANHours.ToString("00") & ":" & ZTofLANMinutes.ToString("00") & ":" & ZTofLANSeconds.ToString("00")
        If System.Math.Abs(ZTofLANHours - DTNoonSight.Value.Hour) >= 2 Then
            txtZTLANWarn.Visible = True
        Else
            txtZTLANWarn.Visible = False
        End If
        Exit Sub
    End Sub
    Private Sub txtLoDeg_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtLoDeg.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtLoDeg.Text) > 180 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtLoMin_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtLoMin.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtLoMin.Text) > 59.9 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub

    Private Sub txtYear_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs)
        'Dim KeepFocus As Boolean = eventArgs.Cancel
        'If Len(txtYear.Text) <> 4 Or Val(txtYear.Text) < 1901 Or Val(txtYear.Text) > 2099 Then
        '    KeepFocus = True
        'End If
        'eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub cboDay_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs)
        Dim KeepFocus As Boolean = eventArgs.Cancel
        'If Val(txtDay.Text) > 31 Then
        '    KeepFocus = True
        'End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtZDh_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtZDh.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtZDh.Text) < -14 Or Val(txtZDh.Text) > 12 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub optStdTPYes_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles OptStdTPYes.CheckedChanged
        If eventSender.Checked And eventSender.Text <> "" Then
            lblTemperature.Visible = False
            txtTemperature.Visible = False
            lblTempDeg.Visible = False
            cboTemperature.Visible = False
            'cboTemperature.Enabled = False
            lblPressure.Visible = False
            txtPressure.Visible = False
            cboPressure.Visible = False
            'cboPressure.Enabled = False
            txtTemperature.Text = "50"
            cboTemperature.SelectedIndex = 0 '"F "
            txtPressure.Text = "29.83"
            cboPressure.SelectedIndex = 0 '"in Hg"
        End If
    End Sub
    Private Sub optStdTPNo_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optStdTPNo.CheckedChanged
        If eventSender.Checked And eventSender.Text <> "" Then
            lblTemperature.Visible = True
            txtTemperature.Visible = True
            lblTempDeg.Visible = True
            cboTemperature.Visible = True
            'cboTemperature.Enabled = True
            lblPressure.Visible = True
            txtPressure.Visible = True
            cboPressure.Visible = True
            'cboPressure.Enabled = True
        End If
    End Sub
    Private Sub cboTemperature_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboTemperature.SelectedIndexChanged
        If cboTemperature.Text = "F " Then txtTemperature.Text = "50"
        If cboTemperature.Text = "C " Then txtTemperature.Text = "10"
        txtTemperature_TextChanged(txtTemperature, New System.EventArgs())
    End Sub
    Private Sub cboPressure_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboPressure.SelectedIndexChanged
        If cboPressure.Text = "in Hg" Then txtPressure.Text = "29.83"
        If cboPressure.Text = "mbar" Then txtPressure.Text = "1010"
        txtPressure_TextChanged(txtPressure, New System.EventArgs())
    End Sub
    Private Sub txtPressure_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPressure.TextChanged
        'txtPressure.ForeColor = &H80000008
        txtPressure.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If cboPressure.Text = "in Hg" And ((Val(txtPressure.Text) < 28 Or Val(txtPressure.Text) > 32)) And Len(txtPressure.Text) >= 2 Then
            txtPressure.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("OutofRange", "Input Error", MessageBoxButtons.OK)
        End If
        If cboPressure.Text = "mbar" And (Val(txtPressure.Text) < 950 Or Val(txtPressure.Text) > 1100) And Len(txtPressure.Text) >= 4 And optStdTPNo.Checked = True Then 'optStdTPNo = True added for bug going back to standard
            txtPressure.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("OutofRange", "Input Error", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub txtPressure_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtPressure.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If cboPressure.Text = "mbar" Then
                    KeyAscii = 0
                    Beep()
                End If
                If InStr(txtPressure.Text, ".") Then
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
    Private Sub txtPressure_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtPressure.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        '    If cboPressure.Text = "in Hg" And (Val(txtPressure.Text) < 26 Or Val(txtPressure.Text) > 32) Then
        '        KeepFocus = True
        '    End If
        '    If cboPressure.Text = "mbar" And (Val(txtPressure.Text) < 950 Or Val(txtPressure.Text) > 1100) Then
        '        KeepFocus = True
        '    End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtPressure_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPressure.Enter
        SelectAllText(txtPressure)
    End Sub
    Private Sub txtTemperature_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTemperature.TextChanged
        'txtTemperature.ForeColor = &H80000008
        txtTemperature.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If cboTemperature.Text = "F " And (Val(txtTemperature.Text) < -40 Or Val(txtTemperature.Text) > 130) Then
            txtTemperature.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range", "Input Error", MessageBoxButtons.OK)
        End If
        If cboTemperature.Text = "C " And (Val(txtTemperature.Text) < -40 Or Val(txtTemperature.Text) > 55) Then
            txtTemperature.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range", "Input Error", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub txtTemperature_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTemperature.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Static bMinusSignAlready As Boolean
        '    bDecimalPointUsedUp = False
        bMinusSignAlready = False
        Select Case KeyAscii
            Case System.Windows.Forms.Keys.Back, System.Windows.Forms.Keys.Right, System.Windows.Forms.Keys.Left
                'do nothing
            Case Asc("0") To Asc("9")
                'do nothing
            Case Asc("-")
                'If Len(txtTemperature.Text) > 0 Then
                '    KeyAscii = 0
                '    Beep
                'End If

                If txtTemperature.SelectionStart <> 0 Or bMinusSignAlready Then
                    KeyAscii = 0
                    Beep()
                Else
                    bMinusSignAlready = True
                End If
            Case Asc(".") 'only allows one decimal point
                If InStr(txtTemperature.Text, ".") Then
                    If KeyAscii = 46 Then
                        KeyAscii = 0
                        Beep()
                    End If
                End If
                '        If bDecimalPointUsedUp Then
                '            KeyAscii = 0
                '            Beep
                '        Else
                '            bDecimalPointUsedUp = True
                '        End If
            Case Else
                KeyAscii = 0
                Beep()
        End Select
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Sub txtTemperature_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtTemperature.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        '    If cboTemperature.Text = "F " And (Val(txtTemperature.Text) < -40 Or Val(txtTemperature.Text) > 130) Then
        '        KeepFocus = True
        '    End If
        '    If cboTemperature.Text = "C " And (Val(txtTemperature.Text) < -40 Or Val(txtTemperature.Text) > 55) Then
        '        KeepFocus = True
        '    End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtTemperature_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTemperature.Enter
        SelectAllText(txtTemperature)
    End Sub
    Public Sub Latitude()
        'Next line for problem with commas as decimal points in Europe with Favorite Places, etc.
        'DRLMin = Replace(txtDRLMin.Text, ",", ".")
        DRLMin = txtDRLMin.Text.ToString.Replace(",", ".")
        DRL = Val(txtDRLDeg.Text) + Val(DRLMin) / 60
        If cboDRL.Text = "S" Then DRL = -DRL
    End Sub

    Public Sub DisplayMeridianDiagram()
        Dim TwoPi, i As Single
        Dim lcnt As Integer = -10
        TwoPi = 8 * System.Math.Atan(1)
        Dim DrawWidth As Integer = (MeridianPicBx.Width / 2) - 20
        bm = New Bitmap(MeridianPicBx.Width, MeridianPicBx.Height)
        meridgraphic = Graphics.FromImage(bm)
        meridgraphic.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        meridgraphic.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAliasGridFit
        meridgraphic.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
        meridgraphic.TranslateTransform(MeridianPicBx.Width / 2, MeridianPicBx.Height - 10)

        Dim DPen As Pen = New Pen(Color.Black, 1)
        DPen.DashStyle = Drawing2D.DashStyle.Solid
        Dim ptA As Point = New Point
        Dim ptB As Point = New Point
        If OldFormBtn.Checked = True Then
            lblN.Visible = True
            lblS.Visible = True
            lblZ.Visible = True
            ' set up and draw line across bottom of cirle arc
            ptA.X = -(DrawWidth)
            ptA.Y = 0
            ptB.X = (DrawWidth)
            ptB.Y = 0
            meridgraphic.DrawLine(DPen, ptA, ptB)
            '  setup and draw verticle Y axis to circle arc
            ptA.X = 0
            ptA.Y = 0
            ptB.X = 0
            ptB.Y = -DrawWidth
            meridgraphic.DrawLine(DPen, ptA, ptB)
            ' setup and draw tick marks on circle arc 
            Dim DrawFrom As Integer = (DrawWidth)
            Dim DrawTo As Integer = (DrawWidth) - 2
            DrawFrom = (DrawWidth)
            DrawTo = (DrawWidth) - 4
            For i = 0 To -TwoPi / 2 Step -TwoPi / 72
                ptA.X = DrawFrom * System.Math.Cos(i)
                ptA.Y = DrawFrom * System.Math.Sin(i)
                ptB.X = DrawTo * System.Math.Cos(i)
                ptB.Y = DrawTo * System.Math.Sin(i)
                meridgraphic.DrawLine(DPen, ptA, ptB)
            Next i
            DrawFrom = (DrawWidth)
            DrawTo = (DrawWidth) - 6
            For i = 0 To -TwoPi / 2 Step -TwoPi / 36
                ptA.X = DrawFrom * System.Math.Cos(i)
                ptA.Y = DrawFrom * System.Math.Sin(i)
                ptB.X = DrawTo * System.Math.Cos(i)
                ptB.Y = DrawTo * System.Math.Sin(i)
                meridgraphic.DrawLine(DPen, ptA, ptB)
            Next i
            meridgraphic.DrawArc(DPen, -DrawWidth, -DrawWidth, DrawWidth * 2, DrawWidth * 2, 0, -180)

            'Equator
            ptA.X = 0
            ptA.Y = 0
            ptB.X = (DrawWidth) * System.Math.Cos(-(90 - Lat) * Pi / 180)
            ptB.Y = (DrawWidth) * System.Math.Sin(-(90 - Lat) * Pi / 180)
            meridgraphic.DrawLine(DPen, ptA, ptB)
            If ptB.X > 0 Then
                ptB.Y -= 10
            Else
                ptB.X -= 10
                ptB.Y -= 10
            End If

            meridgraphic.DrawString("Q ", New Font("Arial", 7, FontStyle.Regular), Brushes.Black, ptB)
            If System.Math.Sign(Lat) = 1 Or System.Math.Sign(Lat) = 0 Then
                ptA.X = 0 'Me.Width / 2
                ptA.Y = 0
                ptB.X = (DrawWidth) * System.Math.Cos((-90 + (-90 + Lat)) * Pi / 180)
                ptB.Y = (DrawWidth) * System.Math.Sin((-90 + (-90 + Lat)) * Pi / 180)
                DPen.Brush = Brushes.DarkBlue
                meridgraphic.DrawLine(DPen, ptA, ptB)
                DPen.Brush = Brushes.Black
                If ptB.X > 0 Then
                    ptB.Y -= 10
                Else
                    ptB.X -= 10
                    ptB.Y -= 10
                End If
                meridgraphic.DrawString("Pn", New Font("Arial", 7, FontStyle.Regular), Brushes.DarkBlue, ptB)
            End If
            'South Pole
            DPen.DashStyle = Drawing2D.DashStyle.Solid
            If System.Math.Sign(Lat) = -1 Then
                DPen.DashStyle = Drawing2D.DashStyle.Dash
                ptA.X = 0 'me.Width / 2
                ptA.Y = 0
                ptB.X = -(DrawWidth) * System.Math.Cos(-90 + (-90 + Lat) * Pi / 180)
                ptB.Y = (DrawWidth) * System.Math.Sin(-90 + (-90 + Lat) * Pi / 180)
                DPen.Brush = Brushes.DarkBlue
                meridgraphic.DrawLine(DPen, ptA, ptB)
                DPen.Brush = Brushes.Black
                If ptB.X > 0 Then
                    ptB.Y -= 10
                Else
                    ptB.X -= 10
                    ptB.Y -= 10
                End If
                meridgraphic.DrawString("Ps", New Font("Arial", 7, FontStyle.Regular), Brushes.DarkBlue, ptB)
            End If
            'Sun
            If optAzS.Checked = True Or (optDRL.Checked = True And DRL >= DE) Then
                DPen.DashStyle = Drawing2D.DashStyle.Dash
                ptA.X = 0 'Me.Width / 2
                ptA.Y = 0
                ptB.X = (DrawWidth) * System.Math.Cos(-(HoinMinutes / 60) * Pi / 180)
                ptB.Y = (DrawWidth) * System.Math.Sin(-(HoinMinutes / 60) * Pi / 180)
                meridgraphic.DrawLine(DPen, ptA, ptB)
                DPen.DashStyle = Drawing2D.DashStyle.Solid
                If ptB.X > 0 Then
                    ptB.Y -= 10
                Else
                    ptB.X -= 10
                    ptB.Y -= 10
                End If
                meridgraphic.DrawString("O ", New Font("Arial", 7, FontStyle.Regular), Brushes.Red, ptB)
            End If
            If optAzN.Checked = True Or (optDRL.Checked = True And DRL < DE) Then
                DPen.DashStyle = Drawing2D.DashStyle.Dash
                ptA.X = 0
                ptA.Y = 0
                ptB.X = (DrawWidth) * System.Math.Cos(((-90 - (HoinMinutes / 60))) * Pi / 180)
                ptB.Y = (DrawWidth) * System.Math.Sin(((-90 - (HoinMinutes / 60))) * Pi / 180)
                DPen.Brush = Brushes.Red
                meridgraphic.DrawLine(DPen, ptA, ptB)
                DPen.Brush = Brushes.Black
                DPen.DashStyle = Drawing2D.DashStyle.Solid
                If ptB.X > 0 Then
                    ptB.Y -= 10
                Else
                    ptB.X -= 10
                    ptB.Y -= 10
                End If
                meridgraphic.DrawString("O ", New Font("Arial", 7, FontStyle.Regular), Brushes.Red, ptB)
            End If
        End If
        If NewFormBtn.Checked = True Then
            lblN.Visible = False
            lblS.Visible = False
            lblZ.Visible = False
            '  setup and draw verticle Y axis to circle arc
            ptA.X = 0
            ptA.Y = 0
            ptB.X = 0
            ptB.Y = -100
            meridgraphic.DrawLine(DPen, ptA, ptB)
            ptA.X = -10
            ptA.Y = 0
            ptB.X = +10
            ptB.Y = 0
            meridgraphic.DrawLine(DPen, ptA, ptB)
            ptB.X = -40
            ptB.Y = -4
            meridgraphic.DrawString("50" & Chr(176) & g_LatS, New Font("Arial", 7, FontStyle.Bold), Brushes.Black, ptB)
            ptA.X = -10
            ptA.Y = -100
            ptB.X = +10
            ptB.Y = -100
            meridgraphic.DrawLine(DPen, ptA, ptB)
            ptB.X = -40
            ptB.Y = -106
            meridgraphic.DrawString("50" & Chr(176) & g_LatN, New Font("Arial", 7, FontStyle.Bold), Brushes.Black, ptB)
            ptA.X = -10
            ptA.Y = -50
            ptB.X = +10
            ptB.Y = -50
            meridgraphic.DrawLine(DPen, ptA, ptB)
            ptB.X = +15
            ptB.Y = -54
            meridgraphic.DrawString("Equator", New Font("Arial", 7, FontStyle.Regular), Brushes.Black, ptB)
            ptB.X = -25
            meridgraphic.DrawString("0" & Chr(176), New Font("Arial", 7, FontStyle.Bold), Brushes.Black, ptB)
            ptA.X = 0
            ptA.Y = -10
            ptB.X = +10
            ptB.Y = -10

            lcnt = -10
            While lcnt > -100
                meridgraphic.DrawLine(DPen, ptA, ptB)
                lcnt += -10
                ptA.Y = lcnt
                ptB.Y = lcnt
                If lcnt = -50 Then
                    lcnt += -10
                    ptA.Y = lcnt
                    ptB.Y = lcnt
                End If
            End While

            Dim LHTemp As String = cboDRL.Text.ToString.Trim
            Dim TotLat As Integer = Convert.ToInt32(txtDRLDeg.Text) + Convert.ToDouble(DRLMin) / 60
            'Dim TotLat As Integer = LDeg + LMin / 60
            If LHTemp = g_LatN Then
                TotLat = -TotLat - 50
            End If
            If LHTemp = "" Then
                TotLat = -50
            End If
            If LHTemp = g_LatS Then
                TotLat = TotLat - 50
            End If
            ptB.X = +15
            ptB.Y = TotLat - 4
            meridgraphic.DrawString("Observer", New Font("Arial", 7, FontStyle.Regular), Brushes.Black, ptB)
            ptA.X = -25
            ptA.Y = TotLat
            ptB.X = -5
            ptB.Y = TotLat
            Dim ArrowPen As Pen = New Pen(Color.Blue)
            ArrowPen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor
            meridgraphic.DrawLine(ArrowPen, ptA, ptB)
            Dim TempStr1 As String = "DRLat=" & Val(txtDRLDeg.Text).ToString("0") & Chr(176) & Val(DRLMin).ToString("00.0") & "'" & cboDRL.Text
            Dim TempStrLen1 As Integer = TempStr1.Length
            ptA.X -= TempStrLen1 * 5
            meridgraphic.DrawString(TempStr1, New Font("Arial", 7, FontStyle.Regular), Brushes.Blue, ptA)

            Dim TotDec As Integer = TotDecDegrees + TotDecMinutes / 60
            If TotDE > 0 Then ' Dec is North
                TotDec = -TotDec - 50
            End If
            If TotDE = 0 Then ' Dec is at equator
                TotDec = -50
            End If
            If TotDE < 0 Then ' dec is South
                TotDec = TotDec - 50
            End If
            DPen.Color = Color.DarkRed
            meridgraphic.FillEllipse(DPen.Brush, -2, TotDec - 2, 4, 4)
            meridgraphic.DrawEllipse(DPen, -3, TotDec - 3, 6, 6)
            ptB.X = +15
            ptB.Y = TotDec - 4
            meridgraphic.DrawString("Sun", New Font("Arial", 7, FontStyle.Regular), Brushes.Black, ptB)
            ptA.X = -25
            ptA.Y = TotDec
            ptB.X = -5
            ptB.Y = TotDec
            meridgraphic.DrawLine(ArrowPen, ptA, ptB)
            Dim TempStr As String = "Dec=" & TotDecDegrees.ToString("0") & Chr(176) & TotDecMinutes.ToString("00.0") & "'"
            If TotDE > 0 Then TempStr &= g_LatN
            If TotDE = 0 Then TempStr &= " "
            If TotDE < 0 Then TempStr &= g_LatS
            Dim TempStrLen As Integer = TempStr.Length
            ptA.X -= TempStrLen * 5
            meridgraphic.DrawString(TempStr, New Font("Arial", 7, FontStyle.Regular), Brushes.Blue, ptA)
            ArrowPen.Dispose()

        End If
        DPen.DashStyle = Drawing2D.DashStyle.Solid
        If My.Computer.FileSystem.FileExists(BMFname) Then
            My.Computer.FileSystem.DeleteFile(BMFname)
        End If
        bm.Save(BMFname)
        MeridianPicBx.Visible = True
        MeridianPicBx.ImageLocation = BMFname
        MeridianPicBx.Refresh()

        DPen.Dispose()

    End Sub

    Public Sub IandC()
        'Flag2 = True 'added in V5.4.0 to prevent 120000 from being used in this calculation
        'Greenwich()
        'Flag2 = False

        dvalue = (System.Math.Abs(DE2) - System.Math.Abs(DE1)) * 60
        Signdvalue = System.Math.Sign(System.Math.Abs(DE2) - System.Math.Abs(DE1))
        'If dvalue < 0.05 Then Signdvalue = 0
        Signdvalue = 1
        If System.Math.Abs(DE2) < System.Math.Abs(DE1) Then
            Signdvalue = -1
        End If
        'If Sgn(DE2) <> Sgn(DE1) And Abs(DE2) > Abs(DE1) Then Signdvalue = -Signdvalue
        If System.Math.Sign(DE2) <> System.Math.Sign(DE1) And System.Math.Sign(DE2) <> 0 And System.Math.Sign(DE1) <> 0 Then
            Signdvalue = -1
        End If
        dvalue = System.Math.Abs(dvalue)
        If dvalue < 0.05 Then
            Signdvalue = 0
        End If
        dvalue = System.Math.Round(((System.Math.Abs(dvalue) * 10 + 0.5) / 10), 1, MidpointRounding.AwayFromZero)
        dcorr = dvalue * (GMinute + 0.5) / 60
        'dcorr = Int((System.Math.Abs(dcorr) * 10 + 0.50000000000001) / 10)
        dcorr = System.Math.Round(dcorr, 1, MidpointRounding.AwayFromZero)

        'TotDE = DE1 + Signdvalue * dcorr / 60
        TotDE = System.Math.Sign(DE1) * (System.Math.Abs(DE1) + Signdvalue * dcorr / 60)
        If Val(Strings.Left(txtTime.Text, 2)) > ZTofLANHours Then
            TotDE = System.Math.Sign(DE2) * (System.Math.Abs(DE2) + Signdvalue * dcorr / 60)
        End If

        If System.Math.Sign(DE1) <> System.Math.Sign(DE2) And System.Math.Abs(dcorr - System.Math.Abs(DE1 * 60)) >= 0.05 Then TotDE = DE1 - Signdvalue * dcorr / 60 '= Sgn(DE1) * (Abs(DE1) - Signdvalue * dcorr / 60)
        TotDecDegrees = Int(System.Math.Abs(TotDE))
        TotDecMinutes = (System.Math.Abs(TotDE) - TotDecDegrees) * 60
        TotDecMinutes = Int(TotDecMinutes * 10 + 0.5) / 10
        If TotDecMinutes = 60 Then
            TotDecMinutes = 0
            TotDecDegrees = TotDecDegrees + 1
        End If

        'Flag2 = False 'added in V5.4.0
    End Sub
    Public Function Delta_T() As Integer  'http://eclipse.gsfc.nasa.gov/SEhelp/deltatpoly2004.html
        DecYr = GYear + (GMonth - 0.5) / 12
        If GYear >= 1901 And GYear <= 1920 Then
            Theta = DecYr - 1900
            DeltaT = -2.79 + 1.494119 * Theta - 0.0598939 * Theta ^ 2 + 0.0061966 * Theta ^ 3 - 0.000197 * Theta ^ 4
        End If
        If GYear >= 1921 And GYear <= 1941 Then
            Theta = DecYr - 1920
            DeltaT = 21.2 + 0.84493 * Theta - 0.0761 * Theta ^ 2 + 0.0020936 * Theta ^ 3
        End If
        If GYear >= 1942 And GYear <= 1961 Then
            Theta = DecYr - 1950
            DeltaT = 29.07 + 0.407 * Theta - (Theta ^ 2) / 233 + (Theta ^ 3) / 2547
        End If
        If GYear >= 1962 And GYear <= 1986 Then
            Theta = DecYr - 1975
            DeltaT = 45.45 + 1.067 * Theta - (Theta ^ 2) / 260 - (Theta ^ 3) / 718
        End If
        If GYear >= 1987 And GYear <= 2005 Then
            Theta = DecYr - 2000
            DeltaT = 63.86 + 0.3345 * Theta - 0.060374 * Theta ^ 2 + 0.0017275 * Theta ^ 3 + 0.000651814 * Theta ^ 4 + 0.00002373599 * Theta ^ 5
        End If
        If GYear >= 2006 And GYear <= 2050 Then
            Theta = DecYr - 2000
            DeltaT = 62.92 + 0.32217 * Theta + 0.005589 * Theta ^ 2       'V5.6.1 could replace 2050 with 2009
        End If
        'Next line NOT added in V5.6.1.  For June 1, 2017, predicted DeltaT value 70.2481, measured DeltaT value 68.8033.  With this change predicted value becomes 68.7579
        'If GYear >= 2010 And GYear <= 2099 Then DeltaT = 66.0699 + (DecYr - 2010) * 0.3604 'DeltaT increasing an average of about 0.36 seconds per year since the beginning of 2010 (66.0699)
        If GYear >= 2051 And GYear <= 2099 Then
            DeltaT = -20 + 32 * ((DecYr - 1820) / 100) ^ 2 - 0.5628 * (2150 - DecYr)        'NOT removed in V5.6.1
        End If
        Return True
    End Function

    Public Function HourAnglesHour() As Integer
        SH = 360 - AR
        GHAAriesHour = 280.46061837 + 360.98564736629 * (JDHour - 2451545) + 0.000387933 * T * T - T * T * T / 38710000 'mean GHA of Aries, degrees
        GHAAriesHour = GHAAriesHour + NL * System.Math.Cos(OETrue * Pi / 180) 'true GHA of Aries, degrees
        If GHAAriesHour >= 360 Or GHAAriesHour < 0 Then GHAAriesHour = GHAAriesHour - Int(GHAAriesHour / 360) * 360
        GHAHour = SH + GHAAriesHour
        If GHAHour >= 360 Or GHAHour < 0 Then GHAHour = GHAHour - Int(GHAHour / 360) * 360
        Return True
    End Function

    Private Sub SelectAllText(ByRef TB As System.Windows.Forms.TextBox)
        TB.SelectionStart = 0
        TB.SelectionLength = Len(TB.Text)
    End Sub
    Public Sub ClearTextFields()
        MeridianPicBx.Visible = False

        LatitudeTxtBx.Text = ""
        AltitudeTxtBx.Text = ""
        AlmanacTxtBx.Text = ""
        LANTimeTxtBx.Text = ""

        DGAlt.Visible = False
        DGLAN.Visible = False
        DGAlm.Visible = False
        DGLat.Visible = False

        Exit Sub
    End Sub
    Public Sub ClearScreen()

        ClearTextFields()

        MeridianPicBx.Visible = False
        txtDRLDeg.Clear()
        txtDRLMin.Clear()
        txtLoDeg.Clear()
        txtLoMin.Clear()
        txtHsDeg.Clear()
        txtHsMin.Clear()
        txtHsSec.Clear()
        txtIEdeg.Clear()
        txtIEmin.Clear()
        txtHE.Clear()
        txtDsDist.Clear()
        txtTime.Clear()
        txtCalcHo.Clear()
        If InvokedBySightLog = False Then
            DTNoonSight.Value = DateTime.Now
        End If
        btnDisplayEQTData.Visible = False
        MeridianPicBx.Refresh()
        Refresh()
    End Sub
    Public Sub Cleanup()
        'CleanOutOldFiles()

        Exit Sub
    End Sub
    Private Sub ErrorMsgBox(ByVal ErrMsg As String, ByVal TitleStr As String, ByVal MsgBtn As MessageBoxButtons)
        System.Windows.Forms.MessageBox.Show(ErrMsg, TitleStr, MsgBtn,
                                                System.Windows.Forms.MessageBoxIcon.Error,
                                                System.Windows.Forms.MessageBoxDefaultButton.Button1,
                                                System.Windows.Forms.MessageBoxOptions.DefaultDesktopOnly)
        Exit Sub
    End Sub
    Private Sub optLower_CheckedChanged(sender As Object, e As EventArgs) Handles optLower.CheckedChanged
        'If Not FormNoonSightLoaded Then Exit Sub
        If optLower.Checked = True Then
            lblHE.Visible = True
            txtHE.Visible = True
            cboHE.Visible = True

            If optHorizonDipShort.Checked = True Then
                lblDsDist.Visible = True
                txtDsDist.Visible = True
                cboDsUnit.Visible = True
            End If

            If optHorizonBubble.Checked = True Then
                SendMsgBx("Caution:  Improper combination of lower limb and bubble horizon.")
            End If
        End If
    End Sub

    Private Sub optUpper_CheckedChanged(sender As Object, e As EventArgs) Handles optUpper.CheckedChanged
        'If Not FormNoonSightLoaded Then Exit Sub
        If optUpper.Checked = True Then
            lblHE.Visible = True
            txtHE.Visible = True
            cboHE.Visible = True

            If optHorizonDipShort.Checked = True Then
                lblDsDist.Visible = True
                txtDsDist.Visible = True
                cboDsUnit.Visible = True
            End If

            If optHorizonBubble.Checked = True Then
                SendMsgBx("Caution:  Improper combination of upper limb and bubble horizon.")
            End If
        End If

        Exit Sub
    End Sub

    Private Sub optCenter_CheckedChanged(sender As Object, e As EventArgs) Handles optCenter.CheckedChanged
        'If Not FormNoonSightLoaded Then Exit Sub
        If optCenter.Checked = True Then
            lblHE.Visible = False
            txtHE.Visible = False
            cboHE.Visible = False

            If optHorizonDipShort.Checked = True Then
                lblDsDist.Visible = False
                txtDsDist.Visible = False
                cboDsUnit.Visible = False
            End If

            If (optHorizonNatural.Checked = True Or optHorizonDipShort.Checked = True) Then
                    SendMsgBx("Caution:  Improper combination of center and natural or dip short horizon.")
                End If
            End If
    End Sub
    Public Sub SendMsgBx(ByVal SendStr As String)
        ' this subroutine is required because issuing a raw SendMsgBx call also trigger a Paint event for graphic box on form which cannot be handled properly in error conditions
        IssuingSendMsgBx = True
        System.Windows.Forms.MessageBox.Show(SendStr, "Input Error",
                                                System.Windows.Forms.MessageBoxButtons.OK,
                                                System.Windows.Forms.MessageBoxIcon.Error,
                                                System.Windows.Forms.MessageBoxDefaultButton.Button1,
                                                System.Windows.Forms.MessageBoxOptions.DefaultDesktopOnly)
        Me.Show()
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
    Private Function CalcEqTFactor() As Double
        ' this code is based on Ron Jones Celestial Navigation Workbook spreadsheet - Meridian Transit worksheet - Interlocked formula starting in cell P76
        Dim ToRad As Double = Pi / 180
        Dim ToDeg As Double = 180 / Pi
        Dim JC As Double = (JD - 2451545) / 36525 ' Julian Century
        Dim MeanOE As Double = 23 + (26 + ((21.448 - JC * (46.815 + JC * (0.00059 - JC * 0.001813)))) / 60) / 60 ' Mean Obliq Ecliptic
        Dim OECorr As Double = MeanOE + (0.00256) * System.Math.Cos((125.04 - 1934.136 * JC) * ToRad) ' Obliq Corr 
        Dim Vary As Double = System.Math.Tan((OECorr / 2) * ToRad) * System.Math.Tan((OECorr / 2) * ToRad) ' Var y factor 
        Dim GeoMeanLo As Double = (280.46646 + JC * (36000.76983 + JC * 0.0003032)) ' Gemoetric Mean Long of Sun
        If GeoMeanLo > 360 Then
            GeoMeanLo = Norm360(GeoMeanLo)
        End If
        Dim GeoMeanAnom As Double = NutM * ToDeg  '357.52911 + JC * (359999.05029 - 0.0001537 * JC)  Geometric Mean Anomaly of Sun 
        Dim Ecc1 As Double = 0.016708634 - JC * (0.000042037 + 0.0001537 * JC) ' Eccentricity of Earth  Orbit
        Dim Fctr1 As Double = Vary * System.Math.Sin(2 * GeoMeanLo * ToRad)
        Dim Fctr2 As Double = 2 * Ecc1 * System.Math.Sin(GeoMeanAnom * ToRad)
        Dim Fctr3 As Double = 4 * Ecc1 * Vary * System.Math.Sin(GeoMeanAnom * ToRad) * System.Math.Cos(2 * GeoMeanLo * ToRad)
        Dim Fctr4 As Double = 0.5 * Vary * Vary * System.Math.Sin(4 * GeoMeanLo * ToRad)
        Dim Fctr5 As Double = 1.25 * Ecc1 * Ecc1 * System.Math.Sin(2 * GeoMeanAnom * ToRad)
        Dim EqtMin As Double = 4 * ToDeg * (Fctr1 - Fctr2 + Fctr3 - Fctr4 - Fctr5)

        Return EqtMin
        Exit Function
    End Function
    Private Function Norm360(ByVal DegIn As Double) As Double
        Dim Tmp1 As Double = Int(DegIn / 360)
        Return (DegIn - (Tmp1 * 360))
    End Function
    Private Function Norm180(ByVal DegIn As Double) As Double
        Dim Tmp1 As Double = Int(DegIn / 180)
        Return (DegIn - (Tmp1 * 180))
    End Function

    Private Sub BuildEqtTable()
        Dim SaveDate As Date = DTNoonSight.Value
        Dim EqtYear As Integer = SaveDate.Year
        Dim EqtMonth As Integer = SaveDate.Month

        Dim EqTTemp As DateTime = New DateTime(EqtYear, 1, 1, 11, 59, 0)
        Dim EqtLimit As Integer = 365
        Dim DegStr As String = Chr(176)
        Dim TmpLat As Double = Convert.ToDouble(txtDRLDeg.Text) + Convert.ToDouble(txtDRLMin.Text) / 60

        Dim LatStr As String = TmpLat.ToString("00.00000") & cboDRL.Text.ToString.Trim
        If cboDRL.Text.ToString.Trim = g_LatS Then
            TmpLat = -1 * TmpLat
        End If
        Dim LatStrFName As String = txtDRLDeg.Text.ToString & cboDRL.Text.ToString.Trim
        Dim TempLo As Double = Lo
        If cboLo.Text.ToString.Trim = g_LongE Then
            TempLo = -Lo
        End If
        Dim LongStr As String = TempLo.ToString("##0.0000") & cboLo.Text.ToString.Trim
        Dim LongStrFName As String = txtLoDeg.Text.ToString & cboLo.Text.ToString.Trim
        If Date.IsLeapYear(EqtYear) = True Then
            EqtLimit += 1
        End If
        Dim EqtIndex As Integer = 0
        ReDim Preserve EqtTable(1)
        Dim FName As String = "./Graphics/EQTData.csv" ' & LatStrFName & LongStrFName & EqtYear.ToString & ".csv"
        Dim objWriter As New System.IO.StreamWriter(FName, False)
        objWriter.WriteLine("Lat,Long,EqtDate,LANTime,EqtFactor,SunDecl,CalcHo") ' write header line with column names in it
        Do While EqtIndex <= EqtLimit
            DTInput = EqTTemp
            LAN()
            GHourLAN = GHour
            GHourLANDisplay = GHour
            FormatZTLAN()
            EqtTable(EqtIndex).EqtLat = LatStr
            EqtTable(EqtIndex).EqtLong = LongStr
            EqtTable(EqtIndex).EqTimeDate = EqTTemp.ToShortDateString
            EqtTable(EqtIndex).EqTimeDec = DE.ToString("00.00000")
            EqtTable(EqtIndex).EqTimeFactor = CalcEqTFactor().ToString("00.00000")
            EqtTable(EqtIndex).EqTZTLAN = ZTofLANHours.ToString("00") & ZTofLANMinutes.ToString("00") & ZTofLANSeconds.ToString("00")
            Dim TempHo As Double = 90 - (TmpLat - DE)
            If cboDRL.Text.ToString.Trim = g_LatS Then
                TempHo = 180 - TempHo
            End If
            Dim TempHoStr As String = TempHo.ToString("##0.0000")
            EqtTable(EqtIndex).EqTimeHo = TempHoStr
            objWriter.WriteLine(LatStr & "," & LongStr & "," &
                                EqtTable(EqtIndex).EqTimeDate & "," &
                                EqtTable(EqtIndex).EqTZTLAN & "," &
                                EqtTable(EqtIndex).EqTimeFactor & "," &
                                EqtTable(EqtIndex).EqTimeDec & "," &
                                TempHoStr)
            EqtIndex += 1
            ReDim Preserve EqtTable(EqtIndex)
            EqTTemp = EqTTemp.AddDays(1)
        Loop

        objWriter.Flush()
        objWriter.Close()
        objWriter.Dispose()

        DTNoonSight.Value = SaveDate
        DTInput = SaveDate
        Exit Sub
    End Sub
    Private Sub BuildMeridianTransitTable()
        Dim SaveDate As Date = DTNoonSight.Value
        Dim EqtYear As Integer = SaveDate.Year
        Dim EqtMonth As Integer = SaveDate.Month

        Dim EqTTemp As DateTime = New DateTime(SaveDate.Year, SaveDate.Month, SaveDate.Day, ZTofLANHours, ZTofLANMinutes, ZTofLANSeconds)
        EqTTemp = EqTTemp.AddHours(-3)
        Dim EqtLimit As Integer = 26
        Dim DegStr As String = Chr(176)
        Dim TmpLat As Double = Convert.ToDouble(txtDRLDeg.Text) + Convert.ToDouble(txtDRLMin.Text) / 60

        Dim LatStr As String = TmpLat.ToString("00.00000") & cboDRL.Text.ToString.Trim
        If cboDRL.Text.ToString.Trim = g_LatS Then
            TmpLat = -1 * TmpLat
        End If
        Dim LatStrFName As String = txtDRLDeg.Text.ToString & cboDRL.Text.ToString.Trim
        Dim TempLo As Double = Lo
        If cboLo.Text.ToString.Trim = g_LongE Then
            TempLo = -Lo
        End If
        Dim LongStr As String = TempLo.ToString("##0.0000") & cboLo.Text.ToString.Trim
        Dim LongStrFName As String = txtLoDeg.Text.ToString & cboLo.Text.ToString.Trim
        If Date.IsLeapYear(EqtYear) = True Then
            EqtLimit += 1
        End If

        Dim EqtIndex As Integer = 0
        ReDim Preserve MTTable(1)
        Dim FName As String = "./Graphics/MeridianTransitData.csv" ' & LatStrFName & LongStrFName & EqtYear.ToString & ".csv"
        Dim objWriter As New System.IO.StreamWriter(FName, False)
        objWriter.WriteLine("Lat,Long,MTDate,LANTime,EqtFactor,SunDecl,CalcHo") ' write header line with column names in it
        'Dim SaveHSDeg As String = txtHsDeg.Text
        'Dim SaveHSMin As String = txtHsMin.Text
        Dim SaveDT As DateTime = DTNoonSight.Value
        Dim SaveTxtTime As String = txtTime.Text
        Do While EqtIndex <= EqtLimit
            DTInput = EqTTemp

            DTNoonSight.Value = EqTTemp
            txtTime.Text = EqTTemp.ToString("HH:mm:ss")
            CalcHoForMT()


            MTTable(EqtIndex).EqtLat = LatStr
            MTTable(EqtIndex).EqtLong = LongStr
            MTTable(EqtIndex).EqTimeDate = EqTTemp.ToShortDateString
            MTTable(EqtIndex).EqTimeDec = DE.ToString("00.00000")
            MTTable(EqtIndex).EqTimeFactor = EqTFactor.ToString("00.00000") 'CalcEqTFactor().ToString("00.00000")
            MTTable(EqtIndex).EqTZTLAN = EqTTemp.ToString("HHmmss") 'ZTofLANHours.ToString("00") & ZTofLANMinutes.ToString("00") & ZTofLANSeconds.ToString("00")

            TmpLat = Convert.ToDouble(txtDRLDeg.Text) + Convert.ToDouble(txtDRLMin.Text) / 60
            'If cboDRL.Items(cboDRL.SelectedIndex).ToString = g_LatS Then
            If cboDRL.Text.ToString.Trim = g_LatS Then
                TmpLat = -1 * TmpLat
            End If
            Dim TempHo As Double = 90 - (TmpLat - DE)
            If cboDRL.Text.ToString.Trim = g_LatS Then
                TempHo = 180 - TempHo
            End If
            Dim TempHoDeg As Integer = Int(TempHo)
            Dim TempHoMin As Double = ((TempHo - TempHoDeg) * 60)
            Dim TempHoStr As String = TempHoDeg.ToString("#0") & Chr(176) & " " & TempHoMin.ToString("#0.0") & "'"

            MTTable(EqtIndex).EqTimeHo = TempHoStr
            objWriter.WriteLine(LatStr & "," & LongStr & "," &
                                MTTable(EqtIndex).EqTimeDate & "," &
                                MTTable(EqtIndex).EqTZTLAN & "," &
                                MTTable(EqtIndex).EqTimeFactor & "," &
                                MTTable(EqtIndex).EqTimeDec & "," &
                                TempHoStr)
            EqtIndex += 1
            ReDim Preserve MTTable(EqtIndex)
            EqTTemp = EqTTemp.AddMinutes(15)
        Loop

        txtTime.Text = SaveTxtTime

        objWriter.Flush()
        objWriter.Close()
        objWriter.Dispose()

        DTNoonSight.Value = SaveDate
        DTInput = SaveDate
        Exit Sub
    End Sub
    Private Sub CalcHoForMT()
        ZDinSeconds = 3600 * System.Math.Sign(ZD) * Int(Lo / 15) 'goes back to normal ZD without (Lo + 1) correction in Greenwich
        'ZTinSeconds = 3600 * Val(VB.Left(txtTime.Text, 2)) + 60 * Val(Mid(txtTime.Text, 3, 2)) + Val(VB.Right(txtTime.Text, 2))
        ZTinSeconds = (3600 * DTInput.Hour) + (60 * DTInput.Minute) + DTInput.Second - ((ZD - ZDMan) * 3600)
        UTinSeconds = ZTinSeconds + (ZDinSeconds - ZDManinSeconds)
        If chkDST.CheckState = 1 Then
            UTinSeconds = UTinSeconds - 3600
        End If

        GHADec()
        IandC()
        AltitudeCorrection()

        Exit Sub
    End Sub
    Private Sub FormatZTLAN()
        GHADiffDeg = Int(GHADiff)
        GHADiffMin = (GHADiff - GHADiffDeg) * 60
        GHADiffMin = Int(GHADiffMin * 10 + 0.5) / 10
        If GHADiffMin = 60 Then
            GHADiffMin = 0
            GHADiffDeg = GHADiffDeg + 1
        End If

        'LANTime = 4 * (GHADiffDeg + GHADiffMin / 60) 'LANTime is a bad name
        LANTime = 4 * (GHADiffDeg + GHADiffMin / 60) 'LANTime is a bad name
        LANMinutes = Int(LANTime)
        LANSeconds = Int((LANTime - LANMinutes) * 60 + 0.5)

        While LANMinutes > 60
            GHourLANDisplay += 1
            LANMinutes -= 60
        End While

        ZTofLAN = (3600 * CInt(GHourLANDisplay) + 60 * CInt(LANMinutes) + CInt(LANSeconds) - 3600 * ZD) / 3600
        If ZTofLAN < 0 Then
            ZTofLAN = ZTofLAN + 24
        End If
        If ZTofLAN >= 24 Then
            ZTofLAN = ZTofLAN - 24
        End If
        If optZDManual.Checked = True Then
            ZTofLAN = (3600 * CInt(GHourLAN) + 60 * CInt(LANMinutes) + CInt(LANSeconds) - 3600 * ZDMan) / 3600 'Int(Lo / 15 + 0.5) is AutoZD
        End If
        ZTofLANHours = Int(ZTofLAN)
        ZTofLANMinutes = Int(((ZTofLAN - CInt(ZTofLANHours)) * 3600) / 60)
        ZTofLANSeconds = (ZTofLAN - CInt(ZTofLANHours)) * 3600 - ZTofLANMinutes * 60
        If ZTofLANSeconds >= 60 Then
            ZTofLANSeconds = ZTofLANSeconds - 60
            ZTofLANMinutes = ZTofLANMinutes + 1
        End If
        If ZTofLANMinutes >= 60 Then
            ZTofLANMinutes = ZTofLANMinutes - 60
            ZTofLANHours = ZTofLANHours + 1
        End If
        Exit Sub
    End Sub

End Class