Option Strict Off
Option Explicit On
Imports System.Windows
Imports System.Windows.Documents
Imports VB = Microsoft.VisualBasic
Friend Class FormSightPlan
    Inherits System.Windows.Forms.Form

    'Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Integer)
    'Private Heart As Char = ChrW(&H2665)
    'Private SmileyFace As Char = Char.ConvertFromUtf32(&H1F600) ' this does not work
    Public IsMouseDown As Boolean = False
    Private i As Short
    Private k As Short
    Public PMRA(), RAStars(), DecStars(), PMDec() As Double
    Private GYearJ As Short
    Private JD As Double
    Private SH(57) As Double
    Private GA(57) As Double
    Private RA(57) As Double

    Private Body() As String
    Private Magnitude() As String
    Private Mag(63) As String
    Private BN As Integer
    Private HD(57) As String
    Private DF(57) As Double    'Integer
    Private C3(10) As String
    Private D3(10) As String
    Private fnumeral As String
    Private j As Short
    Private H As Double
    Private T0 As Double
    Private C30 As String
    Private ZN, PZ, ZN1 As Double
    Private Body1(27) As String
    Private Mag1(27) As String
    Private Z1(27) As Double
    Private TZ, TH As Double
    Private TB, TM As String
    Private Z2(34) As Double
    Private Body2(34) As String
    Private Mag2(34) As String
    Private H2A(34) As Double
    Private Z3(6) As Double
    Private Body3(6) As String
    Private Mag3(6) As String
    Private H3A(6) As Double
    Private bShowToolTips As Boolean
    Private q, CP As Double
    Private GRD(57) As Integer
    Private GRM(57) As Double   'Integer 'Not sure about (57)
    Private IC As Short
    Private CT, Lat, Pi, DE, TA As Double
    Private V, AR, Lo, ZD, GR, T1, N1 As Double
    Private HG, C2, TP As Double
    'Private N2, NT, X3 As String
    Private IB As Integer
    Private VM(57) As Double    'Integer
    Private VD(57) As Integer
    Private H1A(27) As Double
    Private NO, NL, LR As Double
    Private WD, QD As Short
    Private MV As Single
    Private WM, QM As Double
    Private MonthatG, SignZD, MonthList(), DateOfSight As String
    Private DeltaT As Double
    Private DecYr, Theta As Single 'Tdelta As Double, Theta As Double
    Private MonthDays As String
    Private MonthNumber, LocalYear, DayNumber As Short
    Private ZDinSeconds As Integer
    Private GMinute, ZTinSeconds, UTinSeconds, GSecond As Integer
    Private GHour As Short
    Private GMonth, GYear, GDayOfYear, GDay As Short
    Private GLeapYear, LeapYear As Boolean
    Private A, DecimalDate, T As Double
    Private OE, C, OETrue As Double
    Private I2, I3 As Short
    Private B, MS As Double
    Private RN, LN, NU As Double
    Private x, y As Double
    Private M, SQ As Double
    Private P As Short
    Private N, NY As Double
    Private KK0, I1, KK, IJ As Short
    Private KKFull, Ho As Double
    Private D, L1, E As Double
    Private L0 As Double    'also had SM as Double
    Private SM As Integer
    Private LowAz, HighAz As Short
    Private Z1Temp(27) As Double
    Private Z2Temp(34) As Double
    Private Z3Temp(6) As Double
    Private RotateX, ShiftX, AutoZD, ShiftAz, RotateY As Double
    Private rad As Single
    Private View As Boolean
    Private DMHelper(70), RSHelper(70), RDHelper(70), RMHelper(70), DDHelper(70), DSHelper(70) As Integer
    Private MagHelper(70) As Double
    Private DMHelper1, RSHelper1, RDHelper1, RMHelper1, DDHelper1, DSHelper1 As Integer
    Private MagH1(70) As Double
    Private ZH1(70) As Integer
    Private MagH2(70) As Double
    Private ZH2(70) As Integer
    Private MagH3(70) As Double
    Private ZH3(70) As Integer
    Private MagH4(70) As Double
    Private ZH4(70) As Integer
    Private HH1A(70) As Integer
    Private HH2A(70) As Integer
    Private HH3A(70) As Integer
    Private HH4A(70) As Integer
    Private NumberOfHelpers As Integer
    Private DateError, BlankTimeFlag As Boolean
    Private ZH1Temp(70) As Integer
    Private ZH2Temp(70) As Integer
    Private ZH3Temp(70) As Integer
    Private ZH4Temp(70) As Integer
    Private TempThird, TempFirst, TempSecond, AzTest As Boolean
    Private StartTime, EndTime As Integer
    Private SunMoon As Boolean
    Private HoSun, ZNSun, ZNMoon, HoMoon As Single
    Private FirstTime, LastTime As Double
    Private FT As Boolean
    Private LastTimeHours, FirstTimeHours, FirstTimeMinutes, LastTimeMinutes As Short
    Private LTHours, FTHours, FTMinutes, LTMinutes As String
    Private MoonPhaseFirst, MoonPhaseLast As Single
    Private ZNDiff As Short ', MoonPhase$
    Private ZNAmpSR, ZNSS, ZNSR, WhichWay, ZNAmpSS As Single
    Private Amp, ZNAmp As Double ', ZNAmpString$
    Private r As Double
    Private MMoon(3, 3) As Double
    Private A0, Z1Moon, Z, D0 As Double
    Private M8, W8 As Short ', HP As Double, DI As Double
    Private PMoon, SMoon, Z0, L5, TMoon, CMoon, L0Moon As Double
    Private C0Moon As Double
    Private K1, V2Moon, A2Moon, F1, F0, F2, D2Moon, T0Moon, L2 As Double
    Private D1Moon, H2Moon, H0Moon, H1Moon, H3Moon, V0Moon As Double
    Private D7, H7, EMoon, AMoon, BMoon, M3, N7, A7 As Double
    Private T3 As Double
    Private T3String As String ', A7String$
    Private NMoon, FMoon, LMoon, R5, A5, D5, MMMoon, DMoon, GMoon As Double
    Private PrintCount As Short
    Private KK1, WMoon, VMoon, UMoon, V1Moon, KK2 As Double
    Private MoonFlag, TwilightFlag As Boolean ', DSTFlag As Boolean
    Private SweepStep2, SweepStep3 As Single
    Private XTB3, XTB2, XTB1, YTB1, YTB2, YTB3 As Single
    Private XTB7, XTB6, XTB5, XTB4, YTB4, YTB5, YTB6, YTB7 As Single
    Private XTB11, XTB10, XTB9, XTB8, YTB8, YTB9, YTB10, YTB11 As Single
    Private XTB15, XTB14, XTB13, XTB12, YTB12, YTB13, YTB14, YTB15 As Single
    Private XTB16, YTB16 As Single ', XTB17 As Single, YTB17 As Single, XTB18 As Single, YTB18 As Single, XTB19 As Single, YTB19 As Single
    Private C36, C34, C32, Time, C33, C35, C37 As Short
    Private NutF, NutM, NutD, NutMprime, NutOmega As Double
    Private NCos(), NSin(), NF(), NM(), ND(), NMprime(), NOmega() As Integer
    Private NSinT(), NCosT() As Double
    Private LH, Ecc, HP As Double ', L0Sun As Double              'HP in Moon - not needed
    Private MSinA(), MMprimeA(), MDA(), MMA(), MFA(), MCosA() As Integer
    Private MFB(70), MMB(70), MDB(70), MMprimeB(70), MSinB(70) As Integer
    Private A2, MF, MM, MLprime, MD, MMprime, A1, A3 As Double
    Private r0, KB, Delta, SigmaR, SigmaL, SigmaB, KA, B0, Tau As Double
    Private Pre2, AberrDec, NutDec, PhaseAngle, NutRA, AberrRA, Pre1, Pre3 As Double
    Private cosi, AberrB, PeriLo, AberrL, L, xmag As Double
    Private BodiesFlag As Boolean
    Private LMin, LoMin As String
    Private bm As Bitmap
    Private BMFname As String = "./Graphics/PlanForm.jpg"
    Private Plan1graphic As Graphics
    'Private DrawWidth As Integer
    Private DPen As Pen
    Private ptA As Point = New Point
    Private ptB As Point = New Point
    Private FormSightPlanLoaded As Boolean = False
    Private DisplayInitialView As Boolean = True
    Private PhaseFlag As Boolean        'V5.4.1
    Private FlagSRSS As Boolean         'V5.6.2
    Public IssuingSendMsgBx As Boolean = False
    Public Structure BodyInfo
        Dim BodyName As String
        Dim BodyLoc As Point
        Dim BodyLocSz As Integer
        Dim BodyAlt As String
        Dim BodyAz As String
    End Structure
    Private VwBody1() As BodyInfo
    Private VwBody2() As BodyInfo
    Private VwBody3() As BodyInfo

    Private Sub chkDST_CheckedChanged(sender As Object, e As EventArgs) Handles chkDST.CheckedChanged
        If txtTime.Text <> "" Then ' The TxtTime field gets formatted when the cmdTwiLights button has been clicked already. chkDst being set before that time does not invoke button click
            cmdTwilights.PerformClick()
        End If

    End Sub

    Private Sub cboLineWidth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLineWidth.SelectedIndexChanged
        If Not FormSightPlanLoaded Then Exit Sub
        DisplaySunRiseSunSet()
        Exit Sub
    End Sub
    Private Sub chkNoonSightLAN_CheckedChanged(sender As Object, e As EventArgs) Handles chkNoonSightLAN.CheckedChanged
        If Not FormSightPlanLoaded Then Exit Sub
        If chkNoonSightLAN.Checked = True Then
            txtLAN.Visible = True
            GetLANtime()
        Else
            txtLAN.Text = ""
            txtLAN.Visible = False
        End If
    End Sub

    Private Sub DGMag1_SelectionChanged(sender As Object, e As EventArgs) Handles DGMag1.SelectionChanged
        Me.DGMag1.ClearSelection()
        Exit Sub
    End Sub
    Private Sub DGMag3_SelectionChanged(sender As Object, e As EventArgs) Handles DGMag3.SelectionChanged
        Me.DGMag3.ClearSelection()
        Exit Sub
    End Sub

    Private Sub DGMag2_SelectionChanged(sender As Object, e As EventArgs) Handles DGMag2.SelectionChanged
        Me.DGMag2.ClearSelection()
        Exit Sub
    End Sub


    Private Sub DTPlan_ValueChanged(sender As Object, e As EventArgs) Handles DTPlan.ValueChanged
        'If DTPlan.Value.IsDaylightSavingTime = True Then
        '    chkDST.Checked = True
        'End If
    End Sub
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        If System.Windows.Forms.Application.OpenForms().OfType(Of FormNoonSight).Any Then
            FormNoonSight.ExitNoonSight.PerformClick()
        End If
        Me.Close()
    End Sub
    Private Sub Plan1TabCntl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Plan1TabCntl.SelectedIndexChanged
        If Not FormSightPlanLoaded Then Exit Sub
        SelectTabToDisplay()
        Exit Sub
    End Sub
    Public Sub SelectTabToDisplay()
        Plan1TabCntl.Visible = True
        txtTime.Text = DTPlan.Value.Hour.ToString("00") & DTPlan.Value.Minute.ToString("00")
        lblLineWidth.Visible = False
        cboLineWidth.Visible = False
        cboLineWidth.Enabled = False
        Select Case Plan1TabCntl.SelectedIndex
            Case 0
                ListVisibleBodies()
            Case 1
                ViewVisibleBodies()
            Case 2
                StarFinder()
            Case 3
                lblLineWidth.Visible = True
                cboLineWidth.Visible = True
                cboLineWidth.Enabled = True
                DisplaySunRiseSunSet()
            Case Else
                ListVisibleBodies()
        End Select
        Plan1TabCntl.SelectedTab.Show()
        Exit Sub
    End Sub

    Private Sub SkyPicBx_MouseDown(sender As Object, e As MouseEventArgs) Handles SkyPicBx.MouseDown
        DisplayAzAltText(New Point(e.Location.X, e.Location.Y))
    End Sub
    Private Sub SkyPicBx_MouseUp(sender As Object, e As MouseEventArgs) Handles SkyPicBx.MouseUp
        lblAlt.Text = ""
        lblAz.Text = ""
        lblBodyName.Text = ""
    End Sub

    Private Sub SkyPicBx_MouseMove(sender As Object, e As MouseEventArgs) Handles SkyPicBx.MouseMove
        DisplayAzAltText(New Point(e.Location.X, e.Location.Y))
    End Sub

    Private Sub SkyPicBx_MouseEnter(sender As Object, e As EventArgs) Handles SkyPicBx.MouseEnter
        lblAlt.Text = ""
        lblAz.Text = ""
        lblBodyName.Text = ""
    End Sub

    Private Sub SkyPicBx_MouseLeave(sender As Object, e As EventArgs) Handles SkyPicBx.MouseLeave
        lblAlt.Text = ""
        lblAz.Text = ""
        lblBodyName.Text = ""
    End Sub

    Private Sub Calculate()

        ZTinSeconds = 3600 * DTPlan.Value.Hour + 60 * DTPlan.Value.Minute
        Greenwich(DTPlan.Value)
        Delta_T()
        Julian()
        Obliquity()
        Nutation()
        Aries()
        NY = (JD - 2451545.0) / 365.2425
        SolarSystem()
        Stars1()
        Sorting()
        BN = 0
        Helpers()
    End Sub
    Private Sub chkLimit_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkLimit.CheckStateChanged
        If Not FormSightPlanLoaded Then Exit Sub
        BlankTimeFlag = False
        ExecCmdTwilights()
        ViewVisibleBodies()
        Exit Sub
    End Sub
    Private Sub chkMoon_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        If Not FormSightPlanLoaded Then Exit Sub
        ExecCmdTwilights()
        SelectTabToDisplay()
        Exit Sub
    End Sub

    Private Sub cmdCW_MouseDown(sender As Object, e As MouseEventArgs) Handles cmdCW.MouseDown
        Dim RotIncr As Integer = Convert.ToInt32(RotateIncr.SelectedItem)
        WhichWay = RotIncr * Pi / 180
        IsMouseDown = True
        BestBodies()
    End Sub

    Private Sub cmdCCW_MouseDown(sender As Object, e As MouseEventArgs) Handles cmdCCW.MouseDown
        Dim RotIncr As Integer = Convert.ToInt32(RotateIncr.SelectedItem)
        WhichWay = -RotIncr * Pi / 180
        IsMouseDown = True
        BestBodies()
    End Sub

    Private Sub ResetRotateBtn_Click(sender As Object, e As EventArgs) Handles ResetRotateBtn.Click
        SweepStep2 = 0
        SweepStep3 = 0
        RotateIncr.SelectedIndex = 1
        DisplayView()
        Exit Sub
    End Sub
    Private Sub cmdCCW_MouseUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles cmdCCW.MouseUp
        IsMouseDown = False
        'System.Windows.Forms.Application.DoEvents()
    End Sub
    Private Sub cmdCW_MouseUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles cmdCW.MouseUp
        IsMouseDown = False
        'System.Windows.Forms.Application.DoEvents()
    End Sub
    Private Sub SunRiseSet_Paint(sender As Object, e As PaintEventArgs) Handles SunRiseSet.Paint
        Exit Sub
    End Sub
    Private Sub SkyPicBx_Paint(sender As Object, e As PaintEventArgs) Handles SkyPicBx.Paint
        If Not FormSightPlanLoaded Then Exit Sub
        If IssuingSendMsgBx = True Then
            IssuingSendMsgBx = False
            Exit Sub
        End If
        'SaveDisplayBMFname()

        If My.Computer.FileSystem.FileExists(BMFname) Then
            SkyPicBx.Load(BMFname)
        Else
            System.IO.File.Create(BMFname)
            SendMsgBx("Fatal Error: Error loading" & BMFname & " filename - Restarting default display no data", MessageBoxIcon.Hand)
            DisplayInitialView = True
            DisplayView()
            DisplayInitialView = False
        End If
        Exit Sub
    End Sub

    Public Sub StarFinder()
        If Not FormSightPlanLoaded Then Exit Sub
        BodiesFlag = True
        View = False
        BlankTimeFlag = False
        DateError = False
        CheckDate()

        Warning()
        StarMagnitudes()
        Calculate()
        DisplayData()
        BodiesFlag = False
    End Sub
    Private Sub SunMoonFix()
        SunMoon = True
        FirstTime = 0
        LastTime = 0
        FT = False
        LowAz = Val(txtLowAz.Text)
        HighAz = Val(txtHighAz.Text)
        'Convert sunrise time to minutes (and round up to nearest five?)
        StartTime = (60 * Val(VB.Left(C3(4), 2)) + Val(VB.Right(C3(4), 2))) * 60
        EndTime = (60 * Val(VB.Left(C3(5), 2)) + Val(VB.Right(C3(5), 2))) * 60
        'Increment in five minute intervals (300 seconds)
        For ZTinSeconds = StartTime To EndTime Step 300
            Dim TSTmp As TimeSpan = TimeSpan.FromSeconds(ZTinSeconds)
            Dim DTTmp As DateTime = New Date(DTPlan.Value.Year, DTPlan.Value.Month, DTPlan.Value.Day, TSTmp.Hours, TSTmp.Minutes, TSTmp.Seconds)
            Greenwich(DTTmp)
            Delta_T()
            Julian()
            Obliquity()
            Nutation()
            Aries()
            NY = (JD - 2451545.0) / 365.2425
            BN = 58
            Sun()
            AltAz()
            ZNSun = ZN
            HoSun = Ho
            Moon()
            MoonPhase()
            AltAz()
            ZNMoon = ZN
            HoMoon = Ho
            ZNDiff = System.Math.Abs(ZNSun - ZNMoon)
            If ZNDiff > 180 Then
                ZNDiff = ZNDiff - 180
            End If
            If FT = False And HoSun >= Val(txtMinimumAltitude.Text) And HoMoon >= Val(txtMinimumAltitude.Text) And ZNDiff >= 45 And ZNDiff <= 135 And ZNSun >= LowAz And ZNSun <= HighAz And ZNMoon >= LowAz And ZNMoon <= HighAz Then
                FirstTime = ZTinSeconds
                MoonPhaseFirst = KK
                FT = True 'And HoSun > 0 And HoMoon > 0 not needed since already determined in AltAz
            End If
            If HoSun >= Val(txtMinimumAltitude.Text) And HoMoon >= Val(txtMinimumAltitude.Text) And ZNDiff >= 45 And ZNDiff <= 135 And ZNSun >= LowAz And ZNSun <= HighAz And ZNMoon >= LowAz And ZNMoon <= HighAz Then
                LastTime = ZTinSeconds
                MoonPhaseLast = KK ' ZTinSeconds = EndTime 'HoSun > 0 And HoMoon > 0 And not needed since already determined in AltAz
            End If
        Next ZTinSeconds
        Dim TSFT As TimeSpan = TimeSpan.FromSeconds(FirstTime)
        If TSFT.Seconds >= 30 Then
            Dim tmpTS As TimeSpan = New TimeSpan(0, 1, 0)
            TSFT = TSFT.Add(tmpTS)

        End If
        FirstTimeHours = TSFT.Hours
        FirstTimeMinutes = TSFT.Minutes
        'FirstTime = FirstTime / 3600 'hours
        'FirstTimeHours = Int(FirstTime)
        'rstTimeMinutes = Int((FirstTime - FirstTimeHours) * 60 + 0.5) 'rounded to nearest minute
        FTHours = FirstTimeHours.ToString("00")
        FTMinutes = FirstTimeMinutes.ToString("00")

        Dim TSLT As TimeSpan = TimeSpan.FromSeconds(LastTime)
        If TSLT.Seconds >= 30 Then
            Dim tmpTS As TimeSpan = New TimeSpan(0, 1, 0)
            TSLT = TSLT.Add(tmpTS)

        End If
        LastTimeHours = TSLT.Hours
        LastTimeMinutes = TSLT.Minutes

        'LastTime = LastTime / 3600
        'LastTimeHours = Int(LastTime)
        'LastTimeMinutes = Int((LastTime - LastTimeHours) * 60 + 0.5) 'rounded to nearest minute
        LTHours = LastTimeHours.ToString("00")
        LTMinutes = LastTimeMinutes.ToString("00")
    End Sub
    Private Sub MoonData()
        MoonTxtBx.Clear()
        MoonTxtBxRight.Clear()
        DateError = False
        CheckDate()
        ZTinSeconds = 0 'Changing this does not seem to change anything
        LatLong()
        L5 = -Lo / 360
        Z0 = ZD / 24
        'If chkMoon.Checked = True Then L5 = 0 : Z0 = 0 'added in V5.3.0
        MoonFlag = True
        Dim DTTmp As DateTime = New Date(DTPlan.Value.Year, DTPlan.Value.Month, DTPlan.Value.Day, 0, 0, 0)
        Greenwich(DTTmp)     'THIS LINE WAS MAKING EAST LONGITUDE RISE And SET TIMES WRONG!!!!!Removed in 5.1.3        NO - NEEDED. PUT BACK IN v5.4.1
        GDay = DTPlan.Value.Day 'Val(cboDay.Text) 'was not in 3.1.0
        GHour = 0
        GMinute = 0
        GSecond = 0
        Julian()
        TMoon = JD - 2451545 '3.1.0 had +FF
        MoonFlag = False
        LST()
        TMoon = TMoon + Z0
        '   POSITION LOOP
        For i = 1 To 3
            FundamentalArguments()
            MMoon(i, 1) = A5
            MMoon(i, 2) = D5
            MMoon(i, 3) = R5
            TMoon = TMoon + 0.5
        Next
        If MMoon(2, 1) > MMoon(1, 1) Then GoTo Line85
        MMoon(2, 1) = MMoon(2, 1) + 2 * Pi
Line85:
        If MMoon(3, 1) > MMoon(2, 1) Then GoTo Line95
        MMoon(3, 1) = MMoon(3, 1) + 2 * Pi
Line95:
        Z1Moon = (Pi / 180) * (90.567 - 41.685 / MMoon(2, 3))
        SMoon = System.Math.Sin(Lat * Pi / 180)
        CMoon = System.Math.Cos(Lat * Pi / 180)
        Z = System.Math.Cos(Z1Moon)
        M8 = 0
        W8 = 0
        A0 = MMoon(1, 1)
        D0 = MMoon(1, 2)
        PrintCount = 0
        For C0Moon = 0 To 23 Step 1
            PMoon = (C0Moon + 1) / 24
            F0 = MMoon(1, 1)
            F1 = MMoon(2, 1)
            F2 = MMoon(3, 1)
            ThreePointInterpolation()
            A2Moon = FMoon
            F0 = MMoon(1, 2)
            F1 = MMoon(2, 2)
            F2 = MMoon(3, 2)
            ThreePointInterpolation()
            D2Moon = FMoon
            MoonPosition()
            A0 = A2Moon
            D0 = D2Moon
            V0Moon = V2Moon
        Next C0Moon
        'If DSTFlag = False Then SpecialMessages   'eliminated "If DSTFlag=False Then" in V2.7.3
        SpecialMessages()

        'Added next three lines in V5.1.3 so Moon phase shown for 1200 ZT instead of 0000 ZT, corrected in V5.4.1
        Dim DTTmp1 As DateTime = New Date(DTPlan.Value.Year, DTPlan.Value.Month, DTPlan.Value.Day, 12, 0, 0)
        Greenwich(DTTmp1)
        GDay = DTPlan.Value.Day
        PhaseFlag = True
        GHour = 12 + ZD
        GMinute = 0
        GSecond = 0
        Julian()
        'TMoon = JD - 2451545
        'PhaseFlag = False

        Moon()
        MoonPhase()
        KK1 = KKFull
        T = T + 0.00000001 'approx. 32 seconds (to determine if waxing or waning?)         was 0.00001 in 3.1.0
        Moon()
        MoonPhase()
        KK2 = KKFull
        KK0 = Int(KK1 * 100 + 0.5)
        MoonTxtBxRight.SelectionAlignment = HorizontalAlignment.Right
        MoonTxtBxRight.AppendText("Moon " & KK0 & "% illuminated, ")
        If KK2 < KK1 Then
            MoonTxtBxRight.AppendText("waning" & "  ")
        Else
            MoonTxtBxRight.AppendText("waxing" & "  ")
        End If
        Exit Sub
    End Sub
    Private Sub MoonPhase()
        'lowest accuracy version
        PhaseAngle = 180 - MD * 180 / Pi - 6.289 * System.Math.Sin(MMprime) + 2.1 * System.Math.Sin(MM) - 1.274 * System.Math.Sin(2 * MD - MMprime) - 0.658 * System.Math.Sin(2 * MD) - 0.214 * System.Math.Sin(2 * MMprime) - 0.11 * System.Math.Sin(MD) 'degrees
        KKFull = (1 + System.Math.Cos(PhaseAngle * Pi / 180)) / 2
        KK = Int(KKFull * 100 + 0.5)
        Exit Sub
    End Sub
    Private Sub LST()
        'LST at 0h zone time
        T0Moon = TMoon / 36525.0
        SMoon = 24110.5 + 8640184.813 * T0Moon
        SMoon = SMoon + 86636.6 * Z0 + 86400.0 * L5
        SMoon = SMoon / 86400.0
        SMoon = SMoon - Int(SMoon)
        T0Moon = SMoon * 360 * Pi / 180
        Exit Sub
    End Sub
    Private Sub ThreePointInterpolation()
        AMoon = F1 - F0
        BMoon = F2 - F1 - AMoon
        FMoon = F0 + PMoon * (2 * AMoon + BMoon * (2 * PMoon - 1))
        Exit Sub
    End Sub
    Private Sub SpecialMessages()
        If M8 = 0 And W8 = 0 Then
            GoTo Line475
        End If
        If M8 = 0 Then
            MoonTxtBx.AppendText("No moonrise this Date." & Space(4))
        End If
        If W8 = 0 Then
            MoonTxtBx.AppendText("No moonset  this Date." & Space(4))
        End If
        Exit Sub
Line475:
        If V2Moon < 0 Then
            MoonTxtBx.AppendText("Moon down all day." & Space(4))
        End If
        If V2Moon > 0 Then
            MoonTxtBx.AppendText("Moon up all day." & Space(4))
        End If
        Exit Sub
    End Sub
    Private Sub FundamentalArguments()

        LMoon = 0.606434 + 0.03660110129 * TMoon
        MMMoon = 0.374897 + 0.03629164709 * TMoon
        FMoon = 0.259091 + 0.0367481952 * TMoon
        DMoon = 0.827362 + 0.03386319198 * TMoon
        NMoon = 0.347343 - 0.00014709391 * TMoon
        GMoon = 0.993126 + 0.0027377785 * TMoon
        LMoon = LMoon - Int(LMoon)
        MMMoon = MMMoon - Int(MMMoon)
        FMoon = FMoon - Int(FMoon)
        DMoon = DMoon - Int(DMoon)
        NMoon = NMoon - Int(NMoon)
        GMoon = GMoon - Int(GMoon)
        LMoon = LMoon * 2 * Pi
        MMMoon = MMMoon * 2 * Pi
        FMoon = FMoon * 2 * Pi
        DMoon = DMoon * 2 * Pi
        NMoon = NMoon * 2 * Pi
        GMoon = GMoon * 2 * Pi
        VMoon = 0.39558 * System.Math.Sin(FMoon + NMoon) + 0.082 * System.Math.Sin(FMoon) + 0.03257 * System.Math.Sin(MMMoon - FMoon - NMoon) + 0.01092 * System.Math.Sin(MMMoon + FMoon + NMoon) + 0.00666 * System.Math.Sin(MMMoon - FMoon) - 0.00644 * System.Math.Sin(MMMoon + FMoon - 2 * DMoon + NMoon)
        VMoon = VMoon - 0.00331 * System.Math.Sin(FMoon - 2 * DMoon + NMoon) - 0.00304 * System.Math.Sin(FMoon - 2 * DMoon) - 0.0024 * System.Math.Sin(MMMoon - FMoon - 2 * DMoon - NMoon) + 0.00226 * System.Math.Sin(MMMoon + FMoon) - 0.00108 * System.Math.Sin(MMMoon + FMoon - 2 * DMoon)
        VMoon = VMoon - 0.00079 * System.Math.Sin(FMoon - NMoon) + 0.00078 * System.Math.Sin(FMoon + 2 * DMoon + NMoon)
        UMoon = 1 - 0.10828 * System.Math.Cos(MMMoon) - 0.0188 * System.Math.Cos(MMMoon - 2 * DMoon) - 0.01479 * System.Math.Cos(2 * DMoon) + 0.00181 * System.Math.Cos(2 * MMMoon - 2 * DMoon) - 0.00147 * System.Math.Cos(2 * MMMoon)
        UMoon = UMoon - 0.00105 * System.Math.Cos(2 * DMoon - GMoon) - 0.00075 * System.Math.Cos(MMMoon - 2 * DMoon + GMoon)
        WMoon = 0.10478 * System.Math.Sin(MMMoon) - 0.04105 * System.Math.Sin(2 * FMoon + 2 * NMoon) - 0.0213 * System.Math.Sin(MMMoon - 2 * DMoon) - 0.01779 * System.Math.Sin(2 * FMoon + NMoon) + 0.01774 * System.Math.Sin(NMoon)
        WMoon = WMoon + 0.00987 * System.Math.Sin(2 * DMoon) - 0.00338 * System.Math.Sin(MMMoon - 2 * FMoon - 2 * NMoon) - 0.00309 * System.Math.Sin(GMoon) - 0.0019 * System.Math.Sin(2 * FMoon) - 0.00144 * System.Math.Sin(MMMoon + NMoon)
        WMoon = WMoon - 0.00144 * System.Math.Sin(MMMoon - 2 * FMoon - NMoon) - 0.00113 * System.Math.Sin(MMMoon + 2 * FMoon + 2 * NMoon) - 0.00094 * System.Math.Sin(MMMoon - 2 * DMoon + GMoon) - 0.00092 * System.Math.Sin(2 * MMMoon - 2 * DMoon)
        'COMPUTE RA, DEC, DIST
        SMoon = WMoon / System.Math.Sqrt(UMoon - VMoon * VMoon)
        A5 = LMoon + System.Math.Atan(SMoon / System.Math.Sqrt(1 - SMoon * SMoon))
        SMoon = VMoon / System.Math.Sqrt(UMoon)
        D5 = System.Math.Atan(SMoon / System.Math.Sqrt(1 - SMoon * SMoon))
        R5 = 60.40974 * System.Math.Sqrt(UMoon)
        Exit Sub
    End Sub
    Private Sub MoonPosition()
        K1 = 15 * (Pi / 180) * 1.0027379
        L0Moon = T0Moon + C0Moon * K1
        L2 = L0Moon + K1
        If A2Moon < A0 Then
            A2Moon = A2Moon + 2 * Pi
        End If
        H0Moon = L0Moon - A0
        H2Moon = L2 - A2Moon
        H1Moon = (H2Moon + H0Moon) / 2 'HOUR ANGLE
        D1Moon = (D2Moon + D0) / 2 'DEC
        If C0Moon > 0 Then
            GoTo Line325
        End If
        V0Moon = SMoon * System.Math.Sin(D0) + CMoon * System.Math.Cos(D0) * System.Math.Cos(H0Moon) - Z
Line325:
        V2Moon = SMoon * System.Math.Sin(D2Moon) + CMoon * System.Math.Cos(D2Moon) * System.Math.Cos(H2Moon) - Z
        If System.Math.Sign(V0Moon) = System.Math.Sign(V2Moon) Then
            Exit Sub
        End If
        V1Moon = SMoon * System.Math.Sin(D1Moon) + CMoon * System.Math.Cos(D1Moon) * System.Math.Cos(H1Moon) - Z
        AMoon = 2 * V2Moon - 4 * V1Moon + 2 * V0Moon
        BMoon = 4 * V1Moon - 3 * V0Moon - V2Moon
        DMoon = BMoon * BMoon - 4 * AMoon * V0Moon
        If DMoon < 0 Then
            Exit Sub
        End If
        DMoon = System.Math.Sqrt(DMoon)
        If V0Moon < 0 And V2Moon > 0 Then
            MoonTxtBx.AppendText("Moonrise at ZT ")
            M8 = 1
        End If
        If V0Moon > 0 And V2Moon < 0 Then
            MoonTxtBx.AppendText("Moonset  at ZT ")
            W8 = 1
        End If

        EMoon = (-BMoon + DMoon) / (2 * AMoon)
        If EMoon > 1 Or EMoon < 0 Then
            EMoon = (-BMoon - DMoon) / (2 * AMoon)
        End If
        T3 = C0Moon + EMoon + 1 / 120 'ROUND OFF, tried eliminating 1/120 in V2.7.3, sometimes better, sometimes worse
        Dim TS As TimeSpan = TimeSpan.FromHours(T3)
        H3Moon = TS.Hours
        M3 = TS.Minutes

        If chkDST.Checked = True And TwilightFlag = False Then
            H3Moon += 1
        End If
        T3String = H3Moon.ToString("00") & M3.ToString("00")

        'H3Moon = Int(CDbl(T3))
        'M3 = Int((T3 - H3Moon) * 60)
        'T3 = H3Moon * 100 + M3
        'If chkMoon.Checked = True Then
        '    T3 = T3 - Int((ZD * 15 - Lo) * 4 + 0.5) 'added in V5.3.0
        'End If
        'If CDbl(VB.Right(Str(T3), 2)) >= 60 Then
        '    T3 = T3 + 40 'added in V5.3.0 - prevents times like 1060
        'End If
        'T3String = Str(10000 + T3)
        'If chkDST.Checked = True And TwilightFlag = False Then
        '    T3String = Str(10100 + T3)
        'End If
        'T3String = VB.Right(T3String, 4)

        MoonTxtBx.AppendText(T3String)
        'Print(T3String)
        H7 = H0Moon + EMoon * (H2Moon - H0Moon)
        N7 = -System.Math.Cos(D1Moon) * System.Math.Sin(H7)
        D7 = CMoon * System.Math.Sin(D1Moon) - SMoon * System.Math.Cos(D1Moon) * System.Math.Cos(H7)
        A7 = System.Math.Atan(N7 / D7) / (Pi / 180)
        If D7 < 0 Then
            A7 = A7 + 180
        End If
        If A7 < 0 Then
            A7 = A7 + 360
        End If
        If A7 > 360 Then
            A7 = A7 - 360
        End If
        A7 = Int(A7 * 10 + 0.5) / 10

        If V0Moon < 0 And V2Moon > 0 Then
            Amp = (System.Math.Sin(D1Moon) - System.Math.Sin(Lat * Pi / 180) * System.Math.Sin(0.365 * Pi / 180)) / (System.Math.Cos(Lat * Pi / 180) * System.Math.Cos(0.365 * Pi / 180))
            If Amp > 1 Then Amp = 1 'added in V5.4.0 to avoid Dec. 21 90ºS type error
            Amp = System.Math.Atan(Amp / (System.Math.Sqrt(-Amp * Amp + 1) + 9.999999E-21)) 'arcsin
            Amp = Amp * 180 / Pi
            ZNAmp = 90 - Amp
            ZNAmp = Int(ZNAmp * 10 + 0.5) / 10
        End If

        If V0Moon > 0 And V2Moon < 0 Then
            Amp = (System.Math.Sin(D1Moon) - System.Math.Sin(Lat * Pi / 180) * System.Math.Sin(0.365 * Pi / 180)) / (System.Math.Cos(Lat * Pi / 180) * System.Math.Cos(0.365 * Pi / 180))
            If Amp < -1 Then Amp = -1 'added in V5.4.0 to avoid Dec. 21 90ºN type error
            Amp = System.Math.Atan(Amp / (System.Math.Sqrt(-Amp * Amp + 1) + 9.999999E-21)) 'arcsin
            Amp = Amp * 180 / Pi
            ZNAmp = 270 + Amp
            ZNAmp = Int(ZNAmp * 10 + 0.5) / 10
        End If
        If optLimb.Checked = True Then
            MoonTxtBx.AppendText(", Zn " & Strings.Format(A7, "000") & Chr(176) & Space(4))
            PrintCount = PrintCount + 1
        End If 'was "000" before V5.1.5
        If optCenter.Checked = True Then
            MoonTxtBx.AppendText(", Zn " & Strings.Format(ZNAmp, "000") & Chr(176) & Space(4))
            PrintCount = PrintCount + 1
        End If
        If PrintCount = 2 Then TwilightFlag = False
        Exit Sub
    End Sub
    Public Sub ViewVisibleBodies()
        If Not FormSightPlanLoaded Then
            Exit Sub
        End If
        BodiesFlag = True
        BlankTimeFlag = False
        DateError = False
        CheckDate()
        Shape1.Visible = False
        SkyPicBx.Visible = True
        SkyPicBx.Cursor = Cursors.Cross
        View = True
        BuildMagnitudes()
        Warning()
        Calculate()
        If optHorizon.Checked = False Then
            DisplayView()
        Else
            DisplayHorizonView()
        End If
        BodiesFlag = False
        Exit Sub
    End Sub
    Private Sub BuildMagnitudes()
        If GYear <= 2005 Then
            Magnitude = New String() {" 2.1", " 2.2", " 2.4", " 2.5", " 2.2", " 0.6", " 2.2", " 3.1", " 2.8", " 1.9",
                " 1.1", " 0.3", " 0.2", " 1.7", " 1.8", " 1.8", " 0.1 - 1.2", " -0.9", " -1.6",
                " 1.6", " 0.5", " 1.2", " 1.7", " 2.2", " 1.8", " 2.2", " 1.3", " 2.0", " 2.2",
                " 2.8", " 1.1", " 1.6", " 1.7", " 1.2", " 1.9", " 0.9", " 2.3", " 0.2", " 0.1",
                " 2.9", " 2.2", " 2.3", " 1.2", " 1.9", " 2.6", " 1.7", " 2.1", " 2.4", " 2.0",
                " 0.1", " 2.1", " 0.9", " 2.1", " 1.3", " 2.5", " 2.2", " 1.3", " 2.6"}
        Else
            Magnitude = New String() {" 2.1", " 2.1", " 2.4", " 2.2", " 2.0", " 0.5", " 2.0", " 3.2", " 2.5", " 1.8",
                " 0.9", " 0.1", " 0.1", " 1.6", " 1.7", " 1.7", " 0.1 - 1.2", " -0.7", " -1.5",
                " 1.5", " 0.4", " 1.1", " 1.9", " 2.2", " 1.7", " 2.0", " 1.4", " 1.8", " 2.1",
                " 2.6", " 1.3", " 1.6", " 1.8", " 1.0", " 1.9", " 0.6", " 2.1", " 0.0", " -0.3",
                " 2.8", " 2.1", " 2.2", " 1.0", " 1.9", " 2.4", " 1.6", " 2.1", " 2.2", " 1.9",
                " 0.0", " 2.0", " 0.8", " 1.9", " 1.3", " 2.4", " 1.7", " 1.2", " 2.5"}
        End If
        For i = 0 To 57
            Mag(i) = Magnitude(i)
        Next i
        Exit Sub
    End Sub
    Public Sub ListVisibleBodies()
        If Not FormSightPlanLoaded Then Exit Sub
        BodiesFlag = True
        View = False
        BlankTimeFlag = False
        DateError = False
        CheckDate()
        BuildMagnitudes()
        Greenwich(DTPlan.Value)
        Delta_T()
        Julian()
        Warning()
        Calculate()
        SunMoonFix()
        DisplayFirst()
        DisplaySecond()
        DisplayThird()
        Shape1.Clear()
        DisplaySunMoon()
        DGMag1.Refresh()
        DGMag2.Refresh()
        DGMag3.Refresh()

        BodiesFlag = False
    End Sub

    Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
        Dim temp As Rect = New Rect(Me.Location.X, Me.Location.Y, Me.Width + 40, Me.Height)
        PrintScreen(temp)
    End Sub

    Private Sub cmdTwilights_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdTwilights.Click
        ExecCmdTwilights()
        txtTime.Text = DTPlan.Value.Hour.ToString("00") & DTPlan.Value.Minute.ToString("00")
        If chkNoonSightLAN.Checked = True Then
            txtLAN.Visible = True
            GetLANtime()
        Else
            txtLAN.Visible = False
            txtLAN.Text = ""
        End If
        SelectTabToDisplay()
        Exit Sub
    End Sub
    Public Sub ExecCmdTwilights()
        txtTime.Text = DTPlan.Value.Hour.ToString("00") & DTPlan.Value.Minute.ToString("00")
        BodiesFlag = False
        txtWarning.Visible = False
        TwilightFlag = True
        DateError = False
        CheckDate()
        If txtLDeg.Text = "" Then
            txtLDeg.Text = g_TextZero
        End If
        If txtLMin.Text = "" Then
            txtLMin.Text = g_TextZero
        End If
        If txtLoDeg.Text = "" Then
            txtLoDeg.Text = g_TextZero
        End If
        If txtLoMin.Text = "" Then
            txtLoMin.Text = g_TextZero
        End If
        'If DateError = True Then
        '    DateError = False
        '    Exit Sub
        'End If
        ZTinSeconds = 6 * 3600 ' set hour at 6am and convert to seconds * 3600
        Dim TSTmp As TimeSpan = TimeSpan.FromSeconds(ZTinSeconds)
        LatLong()
        Dim DTTmp As DateTime = New Date(DTPlan.Value.Year, DTPlan.Value.Month, DTPlan.Value.Day, TSTmp.Hours, TSTmp.Minutes, TSTmp.Seconds)
        Greenwich(DTTmp)
        Delta_T()
        Julian()
        Twilights()
        DisplayTwilights()
        'If BlankTimeFlag = True Then
        '    txtTime.Text = ""
        'End If
        'BlankTimeFlag = True
        MoonData()
        BodiesFlag = True
    End Sub
    Private Sub Form_Initialize_Renamed()
        'DSTFlag = False    'eliminated in V2.7.3
        Pi = System.Math.PI  '4 * System.Math.Atan(1.0)
        'NT = "00010203040506070809101112131415161718192021222324252627282930"
        'NT = NT & "3132333435363738394041424344454647484950515253545556575859"
        cboL.SelectedIndex = 0 ' g_LatN
        cboLo.SelectedIndex = 0 ' g_LongW
        'lblZDh.Visible = False
        txtZDh.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000F)
        cboZDm.SelectedIndex = 0 ' "00"

        'RA is Right Ascension hours of stars
        RAStars = New Double() {2.53030102, 0.13979405, 0.43806971, 0.67512237, 0.72649196, 1.62856849, 2.11955753, 2.97102075, 3.03799227, 3.40538065, 4.59867741, 5.24229787, 5.27815529, 5.41885085, 5.43819817, 5.60355929, 5.91952924, 6.39919719, 6.75247703, 6.97709679, 7.65503287, 7.75526399, 8.37523211, 9.13326624, 9.21999319, 9.4597898, 10.13953074, 11.06213019, 11.81766044, 12.26343617, 12.44330439, 12.51943314, 12.90048595, 13.41988313, 13.79234379, 14.06372347, 14.11137457, 14.26102008, 14.66013772, 14.84797587, 14.84509067, 15.57813003, 16.49012803, 16.81108191, 17.1729687, 17.56014444, 17.58224182, 17.94343608, 18.4028662, 18.61564901, 18.92109048, 19.84638861, 20.42746051, 20.69053187, 21.73643281, 22.13721819, 22.96084625, 23.07934827}    'RA of Peacock was 20.42846051 before V5.4.1

        'Dec is Declination degrees of stars
        DecStars = New Double() {89.26410951, 29.09043199, -42.30598151, 56.53733109, -17.9866046, -57.23675749, 23.46242313, -40.30467242, 4.08973396, 49.86117959, 16.50930139, -8.20164055, 45.99799111, 6.34970223, 28.60745001, -1.20191983, 7.40706274, -52.69566046, -16.71611582, -28.97208374, 5.22499306, 28.02619862, -59.50948307, -43.43258935, -69.71720773, -8.65860253, 11.96720706, 61.7510332, 14.57206032, -17.54192947, -63.09909166, -57.11321169, 55.95982116, -11.16132203, 49.31326506, -60.37303931, -36.36995445, 19.18241331, -60.83397468, -16.04177818, 74.15550491, 26.71469302, -26.43200249, -69.02771504, -15.72491023, -37.10382115, 12.56003477, 51.48889499, -34.38461611, 38.7836918, -26.29672225, 8.86832198, -56.7350901, 45.280338, 9.87501126, -46.96097543, -29.62223615, 15.20526442}
        ' body names in BN order - Polaris is BN = 0, stars are BN 1 thru 57 and Sun, moon, venus, mars, Jupiter, saturn are 58, 59, 60, 61, 62, 63
        Body = New String() {"Polaris", "Alpheratz", "Ankaa", "Schedar", "Diphda", "Achernar", "Hamal", "Acamar", "Menkar", "Mirfak", "Aldebaran", "Rigel", "Capella", "Bellatrix", "Elnath", "Alnilam", "Betelgeuse", "Canopus", "Sirius", "Adhara", "Procyon", "Pollux", "Avior", "Suhail", "Miaplacidus", "Alphard", "Regulus", "Dubhe", "Denebola", "Gienah", "Acrux", "Gacrux", "Alioth", "Spica", "Alkaid", "Hadar", "Menkent", "Arcturus", "Rigil Kentaurus", "Zubenelgenubi", "Kochab", "Alphecca", "Antares", "Atria", "Sabik", "Shaula", "Rasalhague", "Eltanin", "Kaus Australis", "Vega", "Nunki", "Altair", "Peacock", "Deneb", "Enif", "Al Na'ir", "Fomalhaut", "Markab", "Sun", "Moon", "Venus", "Mars", "Jupiter", "Saturn"}
        'Proper motion right ascension in seconds/century
        PMRA = New Double() {22.9526, 1.0351, 2.0982, 0.6089, 1.6317, 1.0843, 1.3861, -0.468, -0.0789, 0.2493, 0.4365, 0.0126, 0.7247, -0.0587, 0.1768, 0.0099, 0.1837, 0.2199, -3.8007, 0.02, -4.797, -4.7254, -0.3329, -0.2131, -3.032, -0.0977, -1.6996, -1.9221, -3.4374, -1.1158, -0.5212, 0.3431, 1.3308, -0.2888, -1.2397, -0.458, -4.2995, -7.718, -50.3145, -0.7331, -0.7884, 0.8984, -0.0756, 0.3325, 0.2851, -0.0744, 0.7519, -0.0912, -0.32, 1.7192, 0.1031, 3.6221, 0.0937, 0.0148, 0.2031, 1.2464, 2.5248, 0.4221}
        'Proper motion declination in arcseconds/century
        PMDec = New Double() {-1.1746, -16.295, -35.3638, -3.217, 3.2711, -4.0079, -14.5771, 2.571, -7.876, -2.601, -18.936, -0.056, -42.713, -1.328, -17.422, -0.106, 1.086, 2.367, -122.3076, 0.229, -103.4582, -4.5959, 2.272, 1.428, 10.8913, 3.325, 0.4909, -3.5251, 11.3783, 2.231, -1.473, -26.433, -0.8991, -3.173, -1.5561, -2.506, -51.7862, -199.9418, 48.2868, -6.9, 1.191, -8.944, -2.321, -3.292, 9.765, -2.995, -22.261, -2.305, -12.405, 28.7459, -5.265, 38.5538, -8.615, 0.155, 0.138, -14.7909, -16.4217, -4.256}
        'Star magnitudes were here
        'nutation in longitude and obliquity
        ND = New Integer() {0, -2, 0, 0, 0, 0, -2, 0, 0, -2, -2, -2, 0, 2, 0, 2, 0, 0, -2, 0, 2, 0, 0, -2, 0, -2, 0, 0, 2, -2, 0, -2, 0, 0, 2, 2, 0, -2, 0, 2, 2, -2, -2, 2, 2, 0, -2, -2, 0, -2, -2, 0, -1, -2, 1, 0, 0, -1, 0, 0, 2, 0, 2}
        NM = New Integer() {0, 0, 0, 0, 1, 0, 1, 0, 0, -1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 2, 1, 0, -1, 0, 0, 0, 1, 1, -1, 0, 0, 0, 0, 0, 0, -1, -1, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, -1, 1, -1, -1, 0, -1}
        NMprime = New Integer() {0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 1, 0, -1, 0, 1, -1, -1, 1, 2, -2, 0, 2, 2, 1, 0, 0, -1, 0, -1, 0, 0, 1, 0, 2, -1, 1, 0, 1, 0, 0, 1, 2, 1, -2, 0, 1, 0, 0, 2, 2, 0, 1, 1, 0, 0, 1, -2, 1, 1, 1, -1, 3, 0}
        NF = New Integer() {0, 2, 2, 0, 0, 0, 2, 2, 2, 2, 0, 2, 2, 0, 0, 2, 0, 2, 0, 2, 2, 2, 0, 2, 2, 2, 2, 0, 0, 2, 0, 0, 0, -2, 2, 2, 2, 0, 2, 2, 0, 2, 2, 0, 0, 0, 2, 0, 2, 0, 2, -2, 0, 0, 0, 2, 2, 0, 0, 2, 2, 2, 2}
        NOmega = New Integer() {1, 2, 2, 2, 0, 0, 2, 1, 2, 2, 0, 1, 2, 0, 1, 2, 1, 1, 0, 1, 2, 2, 0, 2, 0, 0, 1, 0, 1, 2, 1, 1, 1, 0, 1, 2, 2, 0, 2, 1, 0, 2, 1, 1, 1, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 2, 0, 0, 2, 2, 2, 2}
        NSin = New Integer() {-171996, -13187, -2274, 2062, 1426, 712, -517, -386, -301, 217, -158, 129, 123, 63, 63, -59, -58, -51, 48, 46, -38, -31, 29, 29, 26, -22, 21, 17, 16, -16, -15, -13, -12, 11, -10, -8, 7, -7, -7, -7, 6, 6, 6, -6, -6, 5, -5, -5, -5, 4, 4, 4, -4, -4, -4, 3, -3, -3, -3, -3, -3, -3, -3}
        NSinT = New Double() {-174.2, -1.6, -0.2, 0.2, -3.4, 0.1, 1.2, -0.4, 0, -0.5, 0, 0.1, 0, 0, 0.1, 0, -0.1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -0.1, 0, 0.1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        NCos = New Integer() {92025, 5736, 977, -895, 54, -7, 224, 200, 129, -95, 0, -70, -53, 0, -33, 26, 32, 27, 0, -24, 16, 13, 0, -12, 0, 0, -10, 0, -8, 7, 9, 7, 6, 0, 5, 3, -3, 0, 3, 3, 0, -3, -3, 3, 3, 0, 3, 3, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        NCosT = New Double() {8.9, -3.1, -0.5, 0.5, -0.1, 0, -0.6, 0, -0.1, 0.3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        'Moon
        'Table 47.A longitude and distance
        MDA = New Integer() {0, 2, 2, 0, 0, 0, 2, 2, 2, 2, 0, 1, 0, 2, 0, 0, 4, 0, 4, 2, 2, 1, 1, 2, 2, 4, 2, 0, 2, 2, 1, 2, 0, 0, 2, 2, 2, 4, 0, 3, 2, 4, 0, 2, 2, 2, 4, 0, 4, 1, 2, 0, 1, 3, 4, 2, 0, 1, 2, 2}
        MMA = New Integer() {0, 0, 0, 0, 1, 0, 0, -1, 0, -1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 1, 1, 0, 1, -1, 0, 0, 0, 1, 0, -1, 0, -2, 1, 2, -2, 0, 0, -1, 0, 0, 1, -1, 2, 2, 1, -1, 0, 0, -1, 0, 1, 0, 1, 0, 0, -1, 2, 1, 0, 0}
        MMprimeA = New Integer() {1, -1, 0, 2, 0, 0, -2, -1, 1, 0, -1, 0, 1, 0, 1, 1, -1, 3, -2, -1, 0, -1, 0, 1, 2, 0, -3, -2, -1, -2, 1, 0, 2, 0, -1, 1, 0, -1, 2, -1, 1, -2, -1, -1, -2, 0, 1, 4, 0, -2, 0, 2, 1, -2, -3, 2, 1, -1, 3, -1}
        MFA = New Integer() {0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, -2, 2, -2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, -2, 2, 0, 2, 0, 0, 0, 0, 0, 0, -2, 0, 0, 0, 0, -2, -2, 0, 0, 0, 0, 0, 0, 0, -2}
        MSinA = New Integer() {6288774, 1274027, 658314, 213618, -185116, -114332, 58793, 57066, 53322, 45758, -40923, -34720, -30383, 15327, -12528, 10980, 10675, 10034, 8548, -7888, -6766, -5163, 4987, 4036, 3994, 3861, 3665, -2689, -2602, 2390, -2348, 2236, -2120, -2069, 2048, -1773, -1595, 1215, -1110, -892, -810, 759, -713, -700, 691, 596, 549, 537, 520, -487, -399, -381, 351, -340, 330, 327, -323, 299, 294, 0}
        MCosA = New Integer() {-20905355, -3699111, -2955968, -569925, 48888, -3149, 246158, -152138, -170733, -204586, -129620, 108743, 104755, 10321, 0, 79661, -34782, -23210, -21636, 24208, 30824, -8379, -16675, -12831, -10445, -11650, 14403, -7003, 0, 10056, 6322, -9884, 5751, 0, -4950, 4130, 0, -3958, 0, 3258, 2616, -1897, -2117, 2354, 0, 0, -1423, -1117, -1571, -1739, 0, -4421, 0, 0, 0, 0, 1165, 0, 0, 8752}
        'Table 47.B latitude
        MDB = New Integer() {0, 0, 0, 2, 2, 2, 2, 0, 2, 0, 2, 2, 2, 2, 2, 2, 2, 0, 4, 0, 0, 0, 1, 0, 0, 0, 1, 0, 4, 4, 0, 4, 2, 2, 2, 2, 0, 2, 2, 2, 2, 4, 2, 2, 0, 2, 1, 1, 0, 2, 1, 2, 0, 4, 4, 1, 4, 1, 4, 2}
        MMB = New Integer() {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -1, 0, 0, 1, -1, -1, -1, 1, 0, 1, 0, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, -1, 0, 0, 0, 0, 1, 1, 0, -1, -2, 0, 1, 1, 1, 1, 1, 0, -1, 1, 0, -1, 0, 0, 0, -1, -2}
        MMprimeB = New Integer() {0, 1, 1, 0, -1, -1, 0, 2, 1, 2, 0, -2, 1, 0, -1, 0, -1, -1, -1, 0, 0, -1, 0, 1, 1, 0, 0, 3, 0, -1, 1, -2, 0, 2, 1, -2, 3, 2, -3, -1, 0, 0, 1, 0, 1, 1, 0, 0, -2, -1, 1, -2, 2, -2, -1, 1, 1, -1, 0, 0}
        MFB = New Integer() {1, 1, -1, -1, 1, -1, 1, 1, -1, -1, -1, -1, 1, -1, 1, 1, -1, -1, -1, 1, 3, 1, 1, 1, -1, -1, -1, 1, -1, 1, -3, 1, -3, -1, -1, 1, -1, 1, -1, 1, 1, 1, 1, -1, 3, -1, -1, 1, -1, -1, 1, -1, 1, -1, -1, -1, -1, -1, -1, 1}
        MSinB = New Integer() {5128122, 280602, 277693, 173237, 55413, 46271, 32573, 17198, 9266, 8822, 8216, 4324, 4200, -3359, 2463, 2211, 2065, -1870, 1828, -1794, -1749, -1565, -1491, -1475, -1410, -1344, -1335, 1107, 1021, 833, 777, 671, 607, 596, 491, -451, 439, 422, 421, -366, -351, 331, 315, 302, -283, -229, 223, 223, -220, -220, -185, 181, -177, 176, 166, -164, 132, -119, 115, 107}
        'Helper stars
        NumberOfHelpers = 70
        RDHelper = New Integer() {11, 11, 12, 13, 15, 16, 15, 16, 17, 0, 0, 1, 1, 23, 0, 5, 5, 5, 5, 7, 19, 20, 19, 20, 19, 12, 12, 12, 12, 12, 16, 16, 15, 16, 16, 16, 17, 17, 17, 15, 15, 15, 15, 15, 10, 11, 9, 10, 9, 11, 18, 18, 18, 19, 19, 18, 18, 19, 4, 4, 4, 5, 19, 19, 19, 19, 19, 20, 1, 2}
        RMHelper = New Integer() {1, 53, 15, 23, 20, 17, 44, 45, 32, 9, 56, 25, 54, 3, 13, 40, 32, 47, 35, 34, 30, 22, 44, 46, 56, 34, 29, 10, 47, 15, 5, 0, 58, 35, 50, 51, 12, 37, 42, 27, 32, 55, 57, 42, 19, 14, 45, 16, 45, 14, 5, 21, 27, 2, 9, 17, 45, 6, 28, 19, 28, 37, 55, 46, 5, 6, 25, 11, 9, 3}
        RSHelper = New Integer() {50, 50, 26, 56, 44, 30, 3, 58, 13, 11, 42, 49, 24, 46, 14, 46, 0, 45, 26, 36, 43, 14, 58, 13, 18, 23, 52, 7, 43, 9, 26, 20, 51, 53, 10, 52, 9, 19, 29, 50, 56, 48, 35, 45, 58, 6, 51, 41, 51, 14, 48, 0, 58, 37, 46, 38, 39, 56, 37, 48, 40, 39, 19, 15, 24, 15, 30, 18, 44, 54}
        DDHelper = New Integer() {56, 53, 57, 54, 71, 75, 77, 82, 86, 59, 60, 60, 63, 28, 15, -1, -0, -9, -5, 31, 27, 40, 45, 33, 35, -23, -16, -22, -59, -58, -19, -22, -26, -28, -34, -38, -43, -42, -39, 29, 31, 26, 26, 26, 19, 20, 23, 23, 23, 15, -30, -29, -25, -29, -21, -36, -26, -27, 19, 15, 15, 21, 6, 10, 13, -4, 3, -0, 35, 42}
        DMHelper = New Integer() {22, 41, 1, 55, 50, 45, 47, 2, 35, 8, 43, 14, 40, 4, 11, 56, -17, 40, 54, 53, 57, 15, 7, 58, 5, 23, 30, 37, 41, 44, 48, 37, 6, 12, 17, 2, 14, 59, 1, 6, 21, 4, 52, 17, 50, 31, 46, 25, 46, 25, 25, 49, 25, 52, 1, 45, 59, 40, 10, 37, 52, 8, 24, 36, 51, 52, 6, -49, 37, 19}
        DSHelper = New Integer() {56, 41, 57, 31, 2, 19, 40, 14, 11, 59, 0, 7, 13, 58, 1, 34, 57, 11, 36, 18, 35, 24, 51, 13, 0, 48, 55, 11, 19, 55, 19, 18, 50, 58, 36, 51, 21, 52, 48, 20, 32, 49, 40, 44, 30, 25, 27, 2, 27, 46, 26, 42, 18, 49, 25, 42, 27, 13, 49, 39, 15, 33, 24, 48, 48, 57, 53, 17, 14, 47}
        MagHelper = New Double() {2.4, 2.4, 3.3, 2.3, 3.1, 5, 4.3, 4.2, 4.4, 2.3, 2.5, 2.7, 3.4, 2.4, 2.8, 1.8, 2.2, 2.1, 2.8, 1.6, 3.1, 2.2, 2.9, 2.5, 3.9, 2.7, 3, 3, 1.3, 2.8, 2.6, 2.3, 2.9, 2.8, 2.3, 3, 3.3, 1.9, 2.4, 3.7, 4.1, 5.5, 4.2, 3.8, 2.3, 2.6, 3, 3.4, 3, 3.3, 3, 2.7, 2.8, 3, 2.9, 3.1, 3.2, 3.3, 3.5, 3.7, 3.4, 3, 3.7, 2.7, 3, 3.4, 3.4, 3.2, 2.1, 2.2}
        'Big Dipper 4, Little Dipper 5, Cassiopeia 4
        'Pegasus 2, Orion 4, Gemini 1, Cygnus 5, Corvus 3, Crux 2
        'Scorpius 9, Corona Borealis 5
        'Leo 6, Sagittarius 8
        'Taurus 4, Aquila 6, Andromeda 2
        MoonFlag = False 'is this necessary?
        ReDim VwBody1(0)
        ReDim VwBody2(0)
        ReDim VwBody3(0)

        bShowToolTips = False ' set to true to display body name tooltip
    End Sub

    Private Sub FormSightPlan_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim DrawWidth As Integer = (SkyPicBx.Width / 2) - 25
        DPen = New Pen(Color.Black, 1)
        DTPlan.Value = DateTime.Now
        cboLineWidth.SelectedIndex = 1 ' Rising/Setting Line Width = 2 Regular Width
        'cboDay.SelectedIndex = DateAndTime.Today.Day - 1
        MonthList = New String() {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"}
        'cboMonth.Text = MonthList(DateAndTime.Today.Month - 1)
        'txtYear.Text = DateAndTime.Today.Year.ToString      'CStr(Year(Today))
        cboL.SelectedIndex = 0 'g_LatN
        cboLo.SelectedIndex = 0 'g_LongW
        RotateIncr.SelectedIndex = 2
        cboLineWidth.SelectedIndex = 2
        SweepStep2 = 0
        SweepStep3 = 0
        IsMouseDown = False
        ' delete graphics files from last Plan Form session
        CleanOutOldFiles()

        ToolTip1.Active = True

        bm = New Bitmap(SkyPicBx.Width, SkyPicBx.Height)
        Plan1graphic = Graphics.FromImage(bm)
        Plan1graphic.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        Plan1graphic.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAliasGridFit
        Plan1graphic.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
        Plan1graphic.TranslateTransform(SkyPicBx.Width / 2, SkyPicBx.Height / 2)

        SkyPicBx.Visible = True
        DisplayInitialView = True
        DisplayView()
        DisplayInitialView = False
        SkyPicBx.Visible = False
        lblN.Visible = False
        lblE.Visible = False
        lblS.Visible = False
        lblW.Visible = False

        'lblMinimumAltitude.Visible = False
        'txtMinimumAltitude.Visible = False
        'lblAz1.Visible = False
        'lblAzDeg.Visible = False
        'Label2.Visible = False
        'Label3.Visible = False
        'txtLowAz.Visible = False
        'txtHighAz.Visible = False
        'lblAltDeg.Visible = False
        ' FormSightPlan Plan load event code
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

                    txtLowAz.Text = .FromAZ.ToString
                    txtHighAz.Text = .ToAZ.ToString
                    txtLowAz.Visible = True
                    txtHighAz.Visible = True
                    If .DST = "X" Then
                        chkDST.Checked = True
                    Else
                        chkDST.Checked = False
                    End If

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


        Plan1TabCntl.SelectedIndex = 0
        Plan1TabCntl.Visible = False
        FormSightPlanLoaded = True
        Me.BringToFront()
        Me.Refresh()
        Exit Sub
    End Sub
    Private Sub cboDay_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        CheckDate()
    End Sub

    Private Sub cboDay_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Sub cboMonth_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        CheckDate()
    End Sub
    Private Sub FormSightPlan_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        bm.Dispose()
        'Cleanup()
    End Sub
    Private Sub optCenter_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optCenter.CheckedChanged
        If Not FormSightPlanLoaded Then Exit Sub
        If eventSender.Checked Then
            ExecCmdTwilights()
            SelectTabToDisplay()
        End If
        Exit Sub
    End Sub

    Private Sub optHorizon_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optHorizon.CheckedChanged
        If Not FormSightPlanLoaded Then Exit Sub
        If eventSender.Checked Then
            FrameDirection.Visible = True
            If optN.Checked = True Then optN_CheckedChanged(optN, New System.EventArgs())
            If optS.Checked = True Then optS_CheckedChanged(optS, New System.EventArgs())
            If optE.Checked = True Then optE_CheckedChanged(optE, New System.EventArgs())
            If optW.Checked = True Then optW_CheckedChanged(optW, New System.EventArgs())
            ViewVisibleBodies()
        End If
    End Sub
    Private Sub optOverhead_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optOverhead.CheckedChanged
        If Not FormSightPlanLoaded Then Exit Sub
        If eventSender.Checked Then
            FrameDirection.Visible = True 'False
            If optN.Checked = True Then optN_CheckedChanged(optN, New System.EventArgs())
            If optS.Checked = True Then optS_CheckedChanged(optS, New System.EventArgs())
            If optE.Checked = True Then optE_CheckedChanged(optE, New System.EventArgs())
            If optW.Checked = True Then optW_CheckedChanged(optW, New System.EventArgs())
            BlankTimeFlag = False
            ViewVisibleBodies()
        End If
        Exit Sub
    End Sub
    Private Sub optLimb_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optLimb.CheckedChanged
        If Not FormSightPlanLoaded Then Exit Sub
        If eventSender.Checked Then
            ExecCmdTwilights()
            SelectTabToDisplay()
        End If
        Exit Sub
    End Sub
    Private Sub optN_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optN.CheckedChanged
        If Not FormSightPlanLoaded Then Exit Sub
        If eventSender.Checked Then
            If optHorizon.Checked = True Then
                ShiftAz = 270 '180
                lblN.Visible = False
                lblE.Visible = False
                lblS.Visible = True
                lblW.Visible = False
                lblSRight.Visible = True
                lblSLeft.Visible = True
                lblS.Text = g_LatN
                lblSRight.Text = g_LongE
                lblSLeft.Text = g_LongW
            Else
                RotateX = 180
                RotateY = 180
                lblN.Visible = True
                lblE.Visible = True
                lblS.Visible = True
                lblW.Visible = True
                lblSRight.Visible = False
                lblSLeft.Visible = False

                If optStarFinder.Checked = True Then
                    lblN.Text = g_LatS
                    lblE.Text = g_LongE
                    lblS.Text = g_LatN
                    lblW.Text = g_LongW
                Else
                    lblN.Text = g_LatS
                    lblE.Text = g_LongW
                    lblS.Text = g_LatN
                    lblW.Text = g_LongE
                End If
            End If
            BlankTimeFlag = False
            ExecCmdTwilights()
            ViewVisibleBodies()
        End If
    End Sub

    Private Sub optS_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optS.CheckedChanged
        If Not FormSightPlanLoaded Then Exit Sub
        If eventSender.Checked Then
            If optHorizon.Checked = True Then
                ShiftAz = 90 '0
                'DisplayTwilights
                lblN.Visible = False
                lblE.Visible = False
                lblS.Visible = True
                lblW.Visible = False
                lblSRight.Visible = True
                lblSLeft.Visible = True
                lblS.Text = g_LatS
                lblSRight.Text = g_LongW
                lblSLeft.Text = g_LongE
            Else
                RotateX = 0
                RotateY = 0
                lblN.Visible = True
                lblE.Visible = True
                lblS.Visible = True
                lblW.Visible = True
                lblSRight.Visible = False
                lblSLeft.Visible = False

                If optStarFinder.Checked = True Then
                    lblN.Text = g_LatN
                    lblE.Text = g_LongW
                    lblS.Text = g_LatS
                    lblW.Text = g_LongE
                Else
                    lblN.Text = g_LatN
                    lblE.Text = g_LongE
                    lblS.Text = g_LatS
                    lblW.Text = g_LongW
                End If
            End If
            BlankTimeFlag = False
            ExecCmdTwilights()
            ViewVisibleBodies()
        End If
    End Sub
    Private Sub optE_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optE.CheckedChanged
        If Not FormSightPlanLoaded Then Exit Sub
        If eventSender.Checked Then

            If optHorizon.Checked = True Then
                ShiftX = 0 '1620
                ShiftAz = 0 '-90
                'DisplayTwilights
                lblN.Visible = False
                lblE.Visible = False
                lblS.Visible = True
                lblW.Visible = False
                lblSRight.Visible = True
                lblSLeft.Visible = True
                lblS.Text = g_LongE
                lblSRight.Text = g_LatS
                lblSLeft.Text = g_LatN
            Else
                RotateX = 90
                RotateY = 90
                lblN.Visible = True
                lblE.Visible = True
                lblS.Visible = True
                lblW.Visible = True
                lblSRight.Visible = False
                lblSLeft.Visible = False
                lblN.Text = g_LongW
                lblE.Text = g_LatN
                lblS.Text = g_LongE
                lblW.Text = g_LatS
                If optStarFinder.Checked = True Then
                    RotateX = 270
                    RotateY = 270
                Else
                    ' nothing
                End If
            End If
            'Warning
            BlankTimeFlag = False
            ExecCmdTwilights()
            ViewVisibleBodies()
        End If
    End Sub
    Private Sub optW_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optW.CheckedChanged
        If Not FormSightPlanLoaded Then Exit Sub
        If eventSender.Checked Then
            'ScaleFormSightPlan()

            If optHorizon.Checked = True Then
                ShiftAz = 180 '90
                lblN.Visible = False
                lblE.Visible = False
                lblS.Visible = True
                lblW.Visible = False
                lblSRight.Visible = True
                lblSLeft.Visible = True
                lblS.Text = g_LongW
                lblSRight.Text = g_LatN
                lblSLeft.Text = g_LatS
            Else
                RotateX = 270
                RotateY = 270
                lblN.Visible = True
                lblE.Visible = True
                lblS.Visible = True
                lblW.Visible = True
                lblSRight.Visible = False
                lblSLeft.Visible = False
                lblN.Text = g_LongE
                lblE.Text = g_LatS
                lblS.Text = g_LongW
                lblW.Text = g_LatN
                If optStarFinder.Checked = True Then
                    RotateX = 90
                    RotateY = 90
                Else
                    'Nothing
                End If
            End If
            BlankTimeFlag = False
            ExecCmdTwilights()
            ViewVisibleBodies()

        End If
    End Sub
    Private Sub optStarFinder_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optStarFinder.CheckedChanged
        If Not FormSightPlanLoaded Then Exit Sub
        If eventSender.Checked Then
            FrameDirection.Visible = True 'False
            If optN.Checked = True Then optN_CheckedChanged(optN, New System.EventArgs())
            If optS.Checked = True Then optS_CheckedChanged(optS, New System.EventArgs())
            If optE.Checked = True Then optE_CheckedChanged(optE, New System.EventArgs())
            If optW.Checked = True Then optW_CheckedChanged(optW, New System.EventArgs())
            BlankTimeFlag = False
            ExecCmdTwilights()
            ViewVisibleBodies()
        End If
    End Sub
    Private Sub optThreeBoat_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optThreeBoat.CheckedChanged
        If eventSender.Checked Then
            cmdCW.Enabled = True
            cmdCCW.Enabled = True
            ResetRotateBtn.Enabled = True
            RotateIncr.Enabled = True
            ViewVisibleBodies()
        End If
    End Sub
    Private Sub optThreeBeach_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optThreeBeach.CheckedChanged
        If eventSender.Checked Then
            cmdCW.Enabled = True
            cmdCCW.Enabled = True
            ResetRotateBtn.Enabled = True
            RotateIncr.Enabled = True
            ViewVisibleBodies()
        End If
    End Sub
    Private Sub optTwo_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optTwo.CheckedChanged
        If eventSender.Checked Then
            cmdCW.Enabled = True
            cmdCCW.Enabled = True
            ResetRotateBtn.Enabled = True
            RotateIncr.Enabled = True
            ViewVisibleBodies()
        End If
    End Sub
    Private Sub optOff_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optOff.CheckedChanged
        If eventSender.Checked Then
            'ScaleFormSightPlan()
            ViewVisibleBodies()
            cmdCW.Enabled = False
            cmdCCW.Enabled = False
            ResetRotateBtn.Enabled = False
            RotateIncr.Enabled = False
        End If
    End Sub


    Public Sub DisplayAzAltText(ByVal MousePos As Point)
        Dim bBodyFound As Boolean
        Dim DrawWidth As Integer = (SkyPicBx.Width / 2) - 25
        Dim MidX As Integer = (SkyPicBx.Width / 2)
        Dim MidY As Integer = (SkyPicBx.Height / 2)
        Dim MaxRad As Integer = DrawWidth
        Dim PosX As Integer = (MousePos).X
        Dim PosY As Integer = (MousePos).Y

        If optHorizon.Checked = False Then
            PosX = PosX - MidX
            PosY = PosY - MidY
            rad = System.Math.Sqrt((System.Math.Abs(PosX)) ^ 2 + (System.Math.Abs(PosY)) ^ 2)
            If rad > MaxRad Or View = False Then
                SkyPicBx.Cursor = Cursors.Default
                lblAlt.Text = ""
                lblAz.Text = ""
                lblBodyName.Text = ""
            Else
                SkyPicBx.Cursor = Cursors.Cross
                lblAlt.Text = CStr(System.Math.Round((DrawWidth - rad) * (90 / DrawWidth)))
                If PosX = 0 And PosY >= 0 Then lblAz.Text = "180"
                If PosX = 0 And PosY < 0 Then lblAz.Text = "0"
                'If optOverhead.Checked = True Then
                If PosX > 0 And PosY > 0 Then
                    lblAz.Text = CStr(System.Math.Round(270 - System.Math.Atan((PosY) / (PosX)) * 180 / Pi))
                ElseIf PosX < 0 And PosY > 0 Then
                    lblAz.Text = CStr(System.Math.Round(90 - (System.Math.Atan((PosY) / (PosX)) * 180 / Pi)))
                ElseIf PosX < 0 And PosY < 0 Then
                    lblAz.Text = CStr(System.Math.Round(90 - (System.Math.Atan((PosY) / (PosX)) * 180 / Pi)))
                ElseIf PosX > 0 And PosY < 0 Then
                    lblAz.Text = CStr(System.Math.Round(270 - (System.Math.Atan((PosY) / (PosX)) * 180 / Pi)))
                ElseIf PosX = 0 And PosY > 0 Then
                    lblAz.Text = "0"
                ElseIf PosX = 0 And PosY < 0 Then
                    lblAz.Text = "180"
                ElseIf PosX > 0 And PosY = 0 Then
                    lblAz.Text = "90"
                ElseIf PosX < 0 And PosY = 0 Then
                    lblAz.Text = "270"
                End If
                'End If
                If optStarFinder.Checked = True Then
                    lblAz.Text = CStr(CDbl(lblAz.Text) + 270)
                End If
                If optS.Checked = True Then
                    lblAz.Text = lblAz.Text
                End If
                If optN.Checked = True Then
                    lblAz.Text = CStr(CDbl(lblAz.Text) + 180)
                End If
                If optE.Checked = True Then
                    lblAz.Text = CStr(CDbl(lblAz.Text) + 270)
                End If
                If optW.Checked = True Then
                    lblAz.Text = CStr(CDbl(lblAz.Text) + 90)
                End If
                ' now see if mouse position matches to any of the bodies projected on the visible view
                bBodyFound = False
                For i = 0 To UBound(VwBody1, 1)
                    If IsBodyInLoc(VwBody1(i), PosX, PosY) Then
                        lblBodyName.Text = VwBody1(i).BodyName
                        lblAlt.Text = VwBody1(i).BodyAlt
                        lblAz.Text = VwBody1(i).BodyAz
                        bBodyFound = True
                        Exit For
                    End If
                Next i
                If Not bBodyFound Then
                    For i = 0 To UBound(VwBody2, 1)
                        If IsBodyInLoc(VwBody2(i), PosX, PosY) Then
                            lblBodyName.Text = VwBody2(i).BodyName
                            lblAlt.Text = VwBody2(i).BodyAlt
                            lblAz.Text = VwBody2(i).BodyAz
                            bBodyFound = True
                            Exit For
                        End If
                    Next i
                End If
                If Not bBodyFound Then
                    For i = 0 To UBound(VwBody3, 1)
                        If IsBodyInLoc(VwBody3(i), PosX, PosY) Then
                            lblBodyName.Text = VwBody3(i).BodyName
                            lblAlt.Text = VwBody3(i).BodyAlt
                            lblAz.Text = VwBody3(i).BodyAz
                            bBodyFound = True
                            Exit For
                        End If
                    Next i
                End If
                If Not bBodyFound Then
                    lblBodyName.Text = ""
                End If
            End If
        Else 'for Horizon View
            lblAlt.Text = CStr(System.Math.Round(90 - ((PosY) / ((SkyPicBx.Width - 10) / 90))))
            lblAz.Text = CStr(System.Math.Round((PosX) / (SkyPicBx.Width / 180)) + ShiftAz)
            If Val(lblAz.Text) >= 360 Then lblAz.Text = CStr(Val(lblAz.Text) - 360)
            If Val(lblAz.Text) < 0 Then lblAz.Text = CStr(Val(lblAz.Text) + 360)
            bBodyFound = False
            For i = 0 To UBound(VwBody1, 1)
                If IsBodyInLoc(VwBody1(i), PosX, PosY) Then
                    lblBodyName.Text = VwBody1(i).BodyName
                    lblAlt.Text = VwBody1(i).BodyAlt
                    lblAz.Text = VwBody1(i).BodyAz
                    bBodyFound = True
                    Exit For
                End If
            Next i
            If Not bBodyFound Then
                For i = 0 To UBound(VwBody2, 1)
                    If IsBodyInLoc(VwBody2(i), PosX, PosY) Then
                        lblBodyName.Text = VwBody2(i).BodyName
                        lblAlt.Text = VwBody2(i).BodyAlt
                        lblAz.Text = VwBody2(i).BodyAz
                        bBodyFound = True
                        Exit For
                    End If
                Next i
            End If
            If Not bBodyFound Then
                For i = 0 To UBound(VwBody3, 1)
                    If IsBodyInLoc(VwBody3(i), PosX, PosY) Then
                        lblBodyName.Text = VwBody3(i).BodyName
                        lblAlt.Text = VwBody3(i).BodyAlt
                        lblAz.Text = VwBody3(i).BodyAz
                        bBodyFound = True
                        Exit For
                    End If
                Next i
            End If
            If Not bBodyFound Then
                lblBodyName.Text = ""
            End If
        End If
    End Sub
    Public Shared Function IsBodyInLoc(ByVal BodyInf As BodyInfo, ByVal locx As Integer, ByVal locy As Integer) As Boolean
        If locx >= BodyInf.BodyLoc.X And locx <= BodyInf.BodyLoc.X + BodyInf.BodyLocSz And locy >= BodyInf.BodyLoc.Y And locy <= BodyInf.BodyLoc.Y + BodyInf.BodyLocSz Then
            Return True
        Else
            Return False
        End If
        Exit Function
    End Function
    Private Sub txtMinimumAltitude_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMinimumAltitude.TextChanged
        txtMinimumAltitude.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtMinimumAltitude.Text) > 90 Then 'Or Val(txtMinimumAltitude.Text) < 1 Then     90 was 15
            txtMinimumAltitude.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range", "Entry Error", MessageBoxButtons.OK)
        End If
        txtTime_TextChanged(eventSender, eventArgs)
    End Sub
    Private Sub txtMinimumAltitude_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtMinimumAltitude.KeyPress
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
    Private Sub txtMinimumAltitude_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtMinimumAltitude.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtMinimumAltitude.Text) > 90 Then 'Or Val(txtMinimumAltitude.Text) < 1 Then     90 was 15
            KeepFocus = True
            If txtMinimumAltitude.Text = "" Then KeepFocus = False
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtMinimumAltitude_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMinimumAltitude.Enter
        SelectAllText(txtMinimumAltitude)
        txtTime_TextChanged(eventSender, eventArgs)
    End Sub
    Private Sub txtTime_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTime.TextChanged
    End Sub
    Private Sub txtTime_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTime.KeyPress
    End Sub
    Private Sub txtTime_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtTime.Validating
    End Sub
    Private Sub txtTime_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTime.Enter
    End Sub


    Private Sub txtLDeg_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLDeg.TextChanged
        If Val(txtLDeg.Text) <> 90 Then
            txtLMin.Enabled = True
        End If
        If Val(txtLDeg.Text) = 90 Then
            txtLMin.Text = ""
            txtLMin.Enabled = False
            txtLMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000B)
        End If
        txtLDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtLDeg.Text) > 90 Then
            txtLDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range", "Entry Error", MessageBoxButtons.OK)
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
        txtLMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtLMin.Text) > 59.9 Then
            txtLMin.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range", "Entry Error", MessageBoxButtons.OK)
        End If
    End Sub
    Private Sub txtLMin_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtLMin.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtLMin.Text, ".") Then
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
        If Val(txtLoDeg.Text) <> 180 Then txtLoMin.Enabled = True
        If Val(txtLoDeg.Text) = 180 Then
            txtLoMin.Text = ""
            txtLoMin.Enabled = False
            txtLoMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000B)
        End If
        txtLoDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtLoDeg.Text) > 180 Or (Val(txtLoDeg.Text) = 180 And Val(txtLoMin.Text) <> 0) Then
            txtLoDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range", "Entry Error", MessageBoxButtons.OK)
        End If
        If Val(txtLoDeg.Text) < 180 Then
            txtLoMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        End If
        AutoZDCalc()
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
            ErrorMsgBox("Out of Range", "Entry Error", MessageBoxButtons.OK)
        End If
        AutoZDCalc()
    End Sub
    Private Sub txtLoMin_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtLoMin.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtLoMin.Text, ".") Then
                    If KeyAscii = 46 Then KeyAscii = 0 : Beep()
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
    Public Function Twilights() As Boolean
        j = -1
        T0 = 6 'J=-1 am phenomena; T0 is 0600 (6AM) for initial estimate
        H = -18 'am astronomical twilight
        C3(1) = Times()

        H = -12 'am nautical twilight
        C3(2) = Times()

        H = -6 'am civil twilight
        C3(3) = Times()

        H = -0.833 'sunrise
        C3(4) = Times()
        ZTinSeconds = 3600 * N1 + 60 * C2 'these lines added for azimuth of sunrise
        SRSSAz(ZTinSeconds)
        ZNSR = ZN

        H = -0.7 'center of sun on visible horizon
        C3(9) = Times()
        ZTinSeconds = 3600 * N1 + 60 * C2
        SRSSAz(ZTinSeconds)
        ZNAmpSR = ZN1

        j = 1
        T0 = 18 'J=1 pm phenomena; T0 is 1800 (6PM) for initial estimate
        H = -0.833 'sunset
        C3(5) = Times()
        ZTinSeconds = 3600 * N1 + 60 * C2 'these lines added for azimuth of sunset
        SRSSAz(ZTinSeconds)
        ZNSS = ZN

        H = -0.7 'center of sun on visible horizon
        C3(10) = Times()
        ZTinSeconds = 3600 * N1 + 60 * C2
        SRSSAz(ZTinSeconds)
        ZNAmpSS = ZN1

        H = -6 'pm civil twilight
        Times()
        C3(6) = C30

        H = -12 'pm nautical twilight
        C3(7) = Times()

        H = -18 'pm astronomical twilight
        C3(8) = Times()

        D3(1) = C3(1)
        D3(2) = C3(2)
        D3(3) = C3(3)
        D3(4) = C3(4)
        D3(5) = C3(5)
        D3(6) = C3(6)
        D3(7) = C3(7)
        D3(8) = C3(8)
        D3(9) = C3(9)
        D3(10) = C3(10)
        If D3(1) = D3(2) Then
            C3(1) = "----"
            C3(2) = "----"
        End If
        If D3(2) = D3(3) Then
            C3(2) = "----"
            C3(3) = "----"
        End If
        If D3(3) = D3(4) Then
            C3(3) = "----"
            C3(4) = "----"
        End If
        If D3(8) = D3(7) Then
            C3(8) = "----"
            C3(7) = "----"
        End If
        If D3(7) = D3(6) Then
            C3(7) = "----"
            C3(6) = "----"
        End If
        If D3(6) = D3(5) Then
            C3(6) = "----"
            C3(5) = "----"
        End If
        If D3(1) = D3(8) Then
            C3(1) = "----"
            C3(8) = "----"
        End If

        If C3(4) = "----" Then
            C3(9) = "----" 'these two lines assume if there is no sunrise or sunset there is no corresponding amplitude
        End If
        If C3(5) = "----" Then
            C3(10) = "----"
        End If
        Return True
    End Function
    Public Function SRSSAz(ByVal ZTSecIn As Integer) As Boolean
        FlagSRSS = True
        Dim TSTmp As TimeSpan = TimeSpan.FromSeconds(ZTSecIn)
        Dim DTTmp As DateTime = New Date(DTPlan.Value.Year, DTPlan.Value.Month, DTPlan.Value.Day, TSTmp.Hours, TSTmp.Minutes, TSTmp.Seconds)
        Greenwich(DTTmp)
        Delta_T()
        Julian()
        Obliquity()
        Nutation()
        Aries()
        NY = (JD - 2451545.0!) / 365.2425
        Sun()
        GHADec()
        AltAz()
        FlagSRSS = False
        Return True
    End Function
    Public Function Times() As String
        IC = 0
Line2202:
        If IC = 4 Then
            C30 = "----"
            Return True
            Exit Function 'V1.0.5 had IC = 3
        End If
        ZTinSeconds = T0 * 3600
        Dim TSTmp1 As TimeSpan = TimeSpan.FromSeconds(ZTinSeconds)
        Dim DTTmp1 As DateTime = New Date(DTPlan.Value.Year, DTPlan.Value.Month, DTPlan.Value.Day, TSTmp1.Hours, TSTmp1.Minutes, TSTmp1.Seconds)
        Greenwich(DTTmp1)
        Delta_T()
        Julian()
        Nutation()
        Obliquity()
        Aries()
        Sun()
        CT = (System.Math.Sin(H * Pi / 180) - System.Math.Sin(Lat * Pi / 180) * System.Math.Sin(DE * Pi / 180)) / (System.Math.Cos(Lat * Pi / 180) * System.Math.Cos(DE * Pi / 180))
        If CT >= 1 Then
            TA = 0
            GoTo Line2250
        End If
        If CT <= -1 Then
            TA = 180
            GoTo Line2250
        End If
        TA = -System.Math.Atan(CT / System.Math.Sqrt(-CT * CT + 1)) + Pi / 2
        TA = TA * 180 / Pi
Line2250:
        T1 = T0 + ZD + (j * TA + Lo - GR + AR) / 15

        If T1 >= (24 + 2 * 0.008000001) Or T1 < 0 Then
            T1 = T1 - Int(T1 / 24) * 24 'THIS WAS ORIGINALLY 24, THEN CHANGED TO 25, BUT THAT CAUSED THE PROBLEM FIXED IN V3.4.1, FIXED BY CHANGING BACK TO 24 - NO - FIXED(?) BY MAKING IT (24 + 2*0.008000001)
        End If

        If System.Math.Abs(T1 - T0) > 0.008000001 Then
            T0 = T1
            IC = IC + 1
            GoTo Line2202
        End If

        V = T1 - ZD
        If V < 0 Then
            V = V + 24
        End If
        If V >= 24 Then
            V = V - 24
        End If
        Dim TS As TimeSpan = TimeSpan.FromHours(V)
        If TS.Seconds >= 30 Then
            Dim TmpTS As TimeSpan = New TimeSpan(0, 1, 0)
            TS = TS.Add(TmpTS)
        End If
        N1 = TS.Hours
        C2 = TS.Minutes
        C30 = N1.ToString("00") & C2.ToString("00")
        Return C30
    End Function

    Public Function Aries() As Boolean
        HG = UTinSeconds / 3600 : TP = (JD - 2451545.0! - HG / 24) / 36525.0!
        GR = 6.69737456 + 0.000000000000004 + (2400.051336 * TP)
        GR = GR + (0.0000258622 * TP * TP) + (1.002737909 * HG)
        GR = GR * 15 '  convert hours to degrees
        If GRM(IB) = 60 Then
            GRM(IB) = 0
            GRD(IB) = GRD(IB) + 1
        End If
        If GRD(IB) = 360 Then
            GRD(IB) = 0
        End If
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
        If VM(IB) = 60 Then
            VM(IB) = 0
            VD(IB) = VD(IB) + 1
        End If
        If VD(IB) = 360 Then
            VD(IB) = 0
        End If

        WD = Int(GR)
        WM = (GR - WD) * 60
        WM = Int(WM * 10 + 0.5) / 10
        If WM = 60 Then WM = 0 : 
        WD = WD + 1

        If WD = 360 Then
            WD = 0
        End If

        QD = Int(LR)
        QM = (LR - QD) * 60
        QM = Int(QM * 10 + 0.5) / 10

        If QM = 60 Then
            QM = 0
            QD = QD + 1
        End If

        If QD = 360 Then
            QD = 0
        End If

        Return True
    End Function
    Private Sub cboLo_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboLo.SelectedIndexChanged
        If optZDAuto.Checked = True Then txtZDh.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000B)
        AutoZDCalc()
    End Sub
    Private Sub optZDAuto_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optZDAuto.CheckedChanged
        If Not FormSightPlanLoaded Then Exit Sub
        If eventSender.Checked Then
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
        If Not FormSightPlanLoaded Then Exit Sub
        If eventSender.Checked Then
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
        If Not FormSightPlanLoaded Then Exit Sub
        If eventSender.Checked Then
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
    Private Sub txtZDh_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtZDh.TextChanged
        If optZDAuto.Checked = True Or optZDUT.Checked = True Then txtZDh.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000B)
        If optZDManual.Checked = True Then txtZDh.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If optZDManual.Checked = True And (Val(txtZDh.Text) < -14 Or Val(txtZDh.Text) > 12) Then
            txtZDh.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range", "Entry Error", MessageBoxButtons.OK)
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
                '    Case Asc(".")
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
    Private Sub txtZDh_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtZDh.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtZDh.Text) < -14 Or Val(txtZDh.Text) > 12 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtZDh_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtZDh.Enter
        SelectAllText(txtZDh)
    End Sub
    Public Function AutoZDCalc() As Boolean
        If optZDAuto.Checked = True Then
            txtZDh.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000B)
            Lo = Val(txtLoDeg.Text) + Val(txtLoMin.Text) / 60
            ZD = Int(Lo / 15 + 0.5) 'ZD = Round(Lo / 15)
            If cboLo.Text = "E" Then
                ZD = -ZD
            End If
            AutoZD = ZD
            SignZD = "+"
            If cboLo.Text = "E" Then
                SignZD = "-"
            End If
            txtZDh.Text = SignZD & System.Math.Abs(ZD)
        End If
        Return True
    End Function
    Public Sub DisplayTwilights()

        Shape1.Visible = False
        'lblAltitude.Visible = False
        'lblAzimuth.Visible = False
        'lblAz.Visible = False
        'lblAlt.Visible = False
        'Label5.Visible = False
        'Label7.Visible = False
        'lblN.Visible = False
        'lblE.Visible = False
        'lblS.Visible = False
        'lblW.Visible = False
        'lblBody.Visible = False
        'lblBodyName.Visible = False
        'chkFirst.Visible = False
        'chkSecond.Visible = False
        'chkThird.Visible = False
        'chkNames.Visible = False
        'chkLimit.Visible = False
        'chkHelper.Visible = False
        'FrameView.Visible = False
        'FrameDirection.Visible = False
        'FrameBest.Visible = False
        'Me.Font = New Font("Arial", 8, FontStyle.Bold)
        'CurrentY = 1100
        'Me.Font = FontChangeBold(Me.Font, True)
        SunTxtBx.Clear()

        SunTxtBx.SelectionAlignment = HorizontalAlignment.Left
        SetTxtBxBoldOn(SunTxtBx)
        SunTxtBx.AppendText("Sun Rising and Setting Phenomena and Moon Data for " & DTPlan.Value.ToString("dd MMMM yyyy") & " at L " & Strings.Format(Val(txtLDeg.Text), "0") & Chr(176) & Strings.Format(Val(LMin), "00.0") & "'" & cboL.Text & ", Lo " & Strings.Format(Val(txtLoDeg.Text), "0") & Chr(176) & Strings.Format(Val(LoMin), "00.0") & "'" & cboLo.Text & vbNewLine)
        SunTxtBx.SelectionAlignment = HorizontalAlignment.Center
        SetTxtBxtoReg(SunTxtBx)
        'SunTxtBx.AppendText(vbNewLine)
        SunTxtBx.SelectionAlignment = HorizontalAlignment.Left
        SunTxtBx.SelectionFont = New Font(SunTxtBx.Font, Drawing.FontStyle.Underline)
        SunTxtBx.AppendText("Morning Phenomena") '  & vbTab & vbTab &  & vbTab & vbTab & "Approx. ZT" & vbNewLine)
        SunTxtBx.SelectionFont = New Font(SunTxtBx.Font, Drawing.FontStyle.Regular)
        SunTxtBx.AppendText(vbTab & vbTab)
        SunTxtBx.SelectionFont = New Font(SunTxtBx.Font, Drawing.FontStyle.Underline)
        SunTxtBx.AppendText("Approx. ZT")
        SunTxtBx.SelectionFont = New Font(SunTxtBx.Font, Drawing.FontStyle.Regular)
        SunTxtBx.AppendText(vbTab & vbTab)
        SunTxtBx.SelectionFont = New Font(SunTxtBx.Font, Drawing.FontStyle.Underline)
        SunTxtBx.AppendText("Evening Phenomena")
        SunTxtBx.SelectionFont = New Font(SunTxtBx.Font, Drawing.FontStyle.Regular)
        SunTxtBx.AppendText(vbTab & vbTab)
        SunTxtBx.SelectionFont = New Font(SunTxtBx.Font, Drawing.FontStyle.Underline)
        SunTxtBx.AppendText("Approx. ZT")
        SunTxtBx.SelectionFont = New Font(SunTxtBx.Font, Drawing.FontStyle.Regular)
        SunTxtBx.AppendText(vbNewLine)

        SunTxtBx.AppendText("Start Of AM Astronomical Twilight" & vbTab & C3(1) & vbTab & vbTab & vbTab & "Sunset" & vbTab & vbTab & vbTab & vbTab & C3(5))
        If (C3(5) <> "----" And optLimb.Checked = True) Then
            SunTxtBx.AppendText(" (Zn " & Strings.Format(ZNSS, "000") & "º)")
        Else
            ' nothing
        End If
        If (C3(5) <> "----" And optCenter.Checked = True) Then
            SunTxtBx.AppendText(" (Zn " & Strings.Format(ZNAmpSS, "000") & "º)")
        Else
            ' nothing
        End If
        SunTxtBx.AppendText(vbNewLine)

        SunTxtBx.AppendText("Start Of AM Nautical Twilight" & vbTab & vbTab & C3(2) & vbTab & vbTab & vbTab & "End Of PM Civil Twilight" & vbTab & vbTab & C3(6) & vbNewLine)
        SunTxtBx.AppendText("Start Of AM Civil Twilight" & vbTab & vbTab & C3(3) & vbTab & vbTab & vbTab & "End Of PM Nautical Twilight" & vbTab & vbTab & C3(7) & vbNewLine)
        'Print("Start of AM Civil Twilight", TAB(44), C3(3), TAB(80), "End of PM Nautical Twilight", TAB(124), C3(7))
        SunTxtBx.AppendText("Sunrise" & vbTab & vbTab & vbTab & vbTab & C3(4))

        If (C3(4) <> "----" And optLimb.Checked = True) Then
            SunTxtBx.AppendText(" (Zn " & Strings.Format(ZNSR, "000") & "º)") 'was "000" before V5.1.5
        Else
            SunTxtBx.AppendText(vbTab)
        End If
        If (C3(4) <> "----" And optCenter.Checked = True) Then
            SunTxtBx.AppendText(" (Zn " & Strings.Format(ZNAmpSR, "000") & "º)")
        Else
            SunTxtBx.AppendText(vbTab)
        End If

        '    If C3(4) <> "----" Then Print " (Zn "; Strings.format(ZNAmpSR, "000.0"); "º)";

        SunTxtBx.AppendText(vbTab & "End Of PM Astronomical Twilight" & vbTab & C3(8))
        lblEnterTime.Visible = True
        lblEnterTime.ForeColor = System.Drawing.ColorTranslator.FromOle(&H80000012)
        txtTime.Visible = True
        'txtTime.Enabled = True
        txtTime.ForeColor = System.Drawing.ColorTranslator.FromOle(&H80000012)
        lblMinimumAltitude.Visible = True
        txtMinimumAltitude.Visible = True
        lblAz1.Visible = True
        lblAzDeg.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        txtLowAz.Visible = True
        txtHighAz.Visible = True
        lblAltDeg.Visible = True
        'txtTime.Text = ""
        Plan1TabCntl.Visible = True
        If txtTime.Text <> "" Then
            SelectTabToDisplay()
        End If


    End Sub

    Public Sub LatLong()
        'Next two lines for problem with commas as decimal points in Europe with Favorite Places, etc.
        LMin = Replace(txtLMin.Text, ",", ".")
        LoMin = Replace(txtLoMin.Text, ",", ".")
        Lat = Val(txtLDeg.Text) + Val(LMin) / 60
        If Lat = 90 Then Lat = 89.999999999
        If cboL.Text = "S" Then Lat = -Lat
        Lo = Val(txtLoDeg.Text) + Val(LoMin) / 60
        If cboLo.Text = "E" Then Lo = -Lo
    End Sub
    Public Function Greenwich(ByVal DTin As DateTime) As Boolean
        'Prefix (or suffix) G for Greenwich, UT = Universal Time
        Dim DayG(12) As Short
        MonthDays = "312831303130313130313031"
        'Check for local leap year
        LocalYear = DTin.Year
        LeapYear = DateTime.IsLeapYear(DTin.Year)
        'If DateTime.IsLeapYear(DTIn.Year) Then
        '    LeapYear = True
        'End If
        'If (LocalYear Mod 4) = 0 Then LeapYear = True
        'If (LocalYear Mod 100) = 0 And (LocalYear Mod 400) <> 0 Then
        'LeapYear = False
        'End If 
        If LeapYear = True Then
            MonthDays = "312931303130313130313031"
        Else
            MonthDays = "312831303130313130313031"
        End If
        MonthNumber = DTin.Month 'cboMonth.SelectedIndex + 1
        DayNumber = 0 'DTIn.DayOfYear
        For i = 1 To MonthNumber - 1
            DayNumber += Val(Mid(MonthDays, 2 * i - 1, 2)) '+ DayNumber
        Next i
        'If MonthNumber >= 3 And LeapYear = True Then DayNumber = DayNumber + 1
        DayNumber = DayNumber + DTin.Day 'Val(cboDay.Text)
        ZD = System.Math.Abs(Val(txtZDh.Text))
        If optZDManual.Checked = True Then
            ZD = System.Math.Abs(ZD) + Val(cboZDm.Text) / 60
        End If
        'If Val(txtZDh.Text) < 0 Then ZD = -ZD
        If VB.Left(txtZDh.Text, 1) = "-" Then
            ZD = -ZD
        End If
        '''''If Sgn(Val(txtZDh.Text)) = -1 Then ZD = -ZD
        If chkDST.Checked = True And MoonFlag = False Then
            ZD = ZD - 1
        End If
        ZDinSeconds = 3600 * ZD
        UTinSeconds = ZTinSeconds + ZDinSeconds
        Dim ts As TimeSpan = TimeSpan.FromSeconds(UTinSeconds)
        GHour = ts.Hours
        GMinute = ts.Minutes
        GSecond = ts.Seconds

        'GHour = UTinSeconds / 3600
        'GMinute = (UTinSeconds - (GHour * 3600)) / 60
        'GSecond = UTinSeconds = GHour * 3600 - GMinute * 60
        'GMinute = Int((UTinSeconds - CInt(GHour) * 3600) / 60)
        'GSecond = UTinSeconds - CInt(GHour) * 3600 - GMinute * 60

        GYear = DTin.Year
        GDayOfYear = DayNumber

        'If GHour >= 24 Then
        '    GHour = GHour - 24
        '    GDayOfYear = GDayOfYear + 1
        'End If
        'If (GDayOfYear = 366 And LeapYear = False) Or GDayOfYear = 367 Then
        '    GDayOfYear = 1
        '    GYear = GYear + 1
        '    GoTo GreenwichDate
        'End If
        'If GHour < 0 Then
        '    GHour = GHour + 24
        '    GDayOfYear = GDayOfYear - 1
        'End If
        'If GDayOfYear = 0 Then GYear = GYear - 1

        GLeapYear = DateTime.IsLeapYear(GYear)

        'Check for leap year at Greenwich
        'If (GYear Mod 4) = 0 Then GLeapYear = True
        'If (GYear Mod 100) = 0 And (GYear Mod 400) <> 0 Then GLeapYear = False
        'Days in year
        'If GDayOfYear = 0 And GLeapYear = False Then GDayOfYear = 365
        'If GDayOfYear = 0 And GLeapYear = True Then GDayOfYear = 366

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
        'MonthList$ = "JanFebMarAprMayJunJulAugSepOctNovDec"
        MonthatG = MonthList(GMonth - 1).ToString
        Return True
    End Function
    Public Function Julian() As Boolean
        DecimalDate = GDay + (GHour / 24) + (GMinute / 1440) + (GSecond / 86400.0!)
        GYearJ = GYear
        If GMonth < 3 Then
            GYearJ = GYear - 1
            GMonth = GMonth + 12
        End If
        JD = Int(365.25 * (GYearJ + 4716)) + Int(30.6001 * (GMonth + 1)) + DecimalDate - 1537.5
        If BN = 58 Then
            T = (JD - 2451545) / 36525.0
        Else
            T = (JD - 2451545 + DeltaT / 86400) / 36525.0
        End If

        Return True
    End Function

    Public Function Obliquity() As Boolean
        'Obliquity of the ecliptic
        OE = 84381.448 - 46.816 * T - 0.00059 * T * T + 0.001813 * T * T * T 'Mean obliquity of ecliptic, arcseconds
        OE = OE / 3600 'degrees
        OETrue = OE + NO 'degrees
        Return True
    End Function

    Public Function Nutation() As Boolean
        'Nutation
        NL = 0 : NO = 0

        NutD = 297.85036 + 445267.11148 * T - 0.0019142 * T * T + T * T * T / 189474 'mean elongation of moon from sun, degrees
        If NutD >= 360 Or NutD < 0 Then
            NutD = NutD - Int(NutD / 360) * 360
        End If
        NutD = NutD * Pi / 180 'radians

        NutM = 357.52772 + 35999.05034 * T - 0.0001603 * T * T - T * T * T / 300000 'mean anomaly of the sun (Earth), degrees
        If NutM >= 360 Or NutM < 0 Then
            NutM = NutM - Int(NutM / 360) * 360
        End If
        NutM = NutM * Pi / 180 'radians

        NutMprime = 134.96298 + 477198.867398 * T + 0.0086972 * T * T + T * T * T / 56250 'mean anomaly of the moon, degrees
        If NutMprime >= 360 Or NutMprime < 0 Then
            NutMprime = NutMprime - Int(NutMprime / 360) * 360
        End If
        NutMprime = NutMprime * Pi / 180 'radians

        NutF = 93.27191 + 483202.017538 * T - 0.0036825 * T * T + T * T * T / 327270 'moon's argument of latitude, degrees
        If NutF >= 360 Or NutF < 0 Then
            NutF = NutF - Int(NutF / 360) * 360
        End If
        NutF = NutF * Pi / 180 'radians

        NutOmega = 125.04452 - 1934.136261 * T + 0.0020708 * T * T + T * T * T / 450000 'longitude of ascending node of moon..., degrees
        If NutOmega >= 360 Or NutOmega < 0 Then
            NutOmega = NutOmega - Int(NutOmega / 360) * 360
        End If
        NutOmega = NutOmega * Pi / 180 'radians

        For i = 0 To 62
            NL = NL + (NSin(i) + NSinT(i) * T) * System.Math.Sin(ND(i) * NutD + NM(i) * NutM + NMprime(i) * NutMprime + NF(i) * NutF + NOmega(i) * NutOmega) 'arcseconds x 10000
            NO = NO + (NCos(i) + NCosT(i) * T) * System.Math.Cos(ND(i) * NutD + NM(i) * NutM + NMprime(i) * NutMprime + NF(i) * NutF + NOmega(i) * NutOmega) 'arcseconds x 10000
        Next i
        NL = (NL / 10000) / 3600 'degrees
        NO = (NO / 10000) / 3600 'degrees
        Return True
    End Function
    Public Sub Sun()
        Ecc = 0.016708634 - 0.000042037 * T - 0.0000001267 * T * T 'Ecc of Earth's orbit oO0
        MS = 357.52911 + 35999.05029 * T - 0.0001537 * T * T 'mean anomaly of Sun, degrees
        'MS=357.52772 + 35999.05034 * T + 0.0001603 * T * T +T*T*T/30000                   'mean anomaly of Sun, degrees
        If MS >= 360 Or MS < 0 Then
            MS = MS - Int(MS / 360) * 360
        End If
        C = (1.914602 - 0.004817 * T - 0.000014 * T * T) * System.Math.Sin(MS * Pi / 180) + (0.019993 - 0.000101 * T) * System.Math.Sin(2 * MS * Pi / 180) + 0.000289 * System.Math.Sin(3 * MS * Pi / 180) 'center of Sun, degrees
        NU = MS + C 'Sun's true anomaly, degrees
        RN = (1.000001018 * (1 - Ecc * Ecc)) / (1 + Ecc * System.Math.Cos(NU * Pi / 180)) 'Sun's radius vector (distance between centers of Sun and Earth), astronomical units
        L0 = 280.46646 + 36000.76983 * T + 0.0003032 * T * T 'geometric mean longitude of Sun, degrees
        If L0 >= 360 Or L0 < 0 Then
            L0 = L0 - Int(L0 / 360) * 360
        End If
        LN = L0 + C 'Sun's true longitude, degrees

        If TwilightFlag = False And BN <> 58 Then
            Exit Sub 'do not go further if not twilights and not sun sight
        End If
        If TwilightFlag = True And (BN >= 60 And BN <= 63) Then
            Exit Sub 'do not go further if twilights and planets
        End If
        If BodiesFlag = True And TwilightFlag = True And BN <= 57 Then
            Exit Sub 'want this line only for list, not for twilights
        End If

        T = T / 10
        ' Compute heliocentric, ecliptical Longitude L in radians
        LH = Earth_L01(T) + Earth_L02(T) + Earth_L11(T) + Earth_L21(T) + Earth_L31(T) + Earth_L41(T) + Earth_L51(T) 'radians
        If System.Math.Abs(LH) > (2 * Pi) Then
            LH = LH - 2 * Pi * Int(LH / 2 / Pi)
        End If
        ' Compute heliocentric, ecliptical Latitude B in radians
        B = Earth_B01(T) + Earth_B11(T) + Earth_B21(T) + Earth_B31(T) + Earth_B41(T) 'radians
        ' Compute heliocentric distance r in AU
        r = Earth_R01(T) + Earth_R02(T) + Earth_R11(T) + Earth_R21(T) + Earth_R31(T) + Earth_R41(T) + Earth_R51(T)

        L1 = LH + Pi 'geocentric longitude, radians
        B = -B 'geocentric latitude, radians

        L1 = L1 * 180 / Pi 'geocentric longitude, degrees
        'add nutation to get apparent positions
        L1 = L1 + NL 'degrees
        'add aberration
        L1 = L1 - (20.4898 / 3600) / r 'apparent longitude, degrees
        'back to radians
        L1 = L1 * Pi / 180

        EclipticToEquatorial()
        AR = AR * 180 / Pi 'for Meeus ecl-to-eq
        DE = DE * 180 / Pi 'for Meeus ecl-to-eq

        T = 10 * T
    End Sub

    Public Function EclipticToEquatorial() As Boolean
        AR = System.Math.Atan((System.Math.Sin(L1) * System.Math.Cos(OETrue * Pi / 180) - System.Math.Tan(B) * System.Math.Sin(OETrue * Pi / 180)) / System.Math.Cos(L1)) 'radians
        If System.Math.Cos(L1) < 0 Then
            AR = AR + Pi
        End If
        If AR >= 2 * Pi Then
            AR = AR - 2 * Pi
        End If
        If AR < 0 Then
            AR = AR + 2 * Pi
        End If
        x = System.Math.Sin(B) * System.Math.Cos(OETrue * Pi / 180) + System.Math.Cos(B) * System.Math.Sin(OETrue * Pi / 180) * System.Math.Sin(L1)
        DE = System.Math.Atan(x / (System.Math.Sqrt(-x * x + 1) + 9.999999E-21)) 'arcsin, radians
        Return True
    End Function

    Public Function SolarSystem() As Boolean
        I1 = 0
        'PlanOrbEl
        For BN = 58 To 63
            If BN = 58 Then
                Sun()
                Mag(58) = -26.8
                'GoTo Line2406
                'End If 'sun
            ElseIf BN = 59 Then
                T = (JD - 2451545) / 36525
                Moon()
                MoonPhase()
                Mag(59) = KK & "% ill."
                'GoTo Line2406
                'End If 'moon
            Else
                Planets() 'planets
                PlanetMags()
            End If

Line2406:
            IB = BN - 57
            GHADec()
            AltAz()
            If Ho > 0 Then
                First_Mag()
            End If
        Next BN
        Return True
    End Function

    Public Function Moon() As Boolean
        'T = (JD - 2451545) / 36525
        MLprime = 218.3164477 + 481267.88123421 * T - 0.0015786 * T * T + T * T * T / 538841 - T * T * T * T / 65194000 'Moon's mean longitude, degrees
        If MLprime >= 360 Or MLprime < 0 Then
            MLprime = MLprime - Int(MLprime / 360) * 360
        End If
        MLprime = MLprime * Pi / 180
        MD = 297.8501921 + 445267.1114034 * T - 0.0018819 * T * T + T * T * T / 545868 - T * T * T * T / 113065000 'Moon's mean elongation, degrees
        If MD >= 360 Or MD < 0 Then
            MD = MD - Int(MD / 360) * 360
        End If
        MD = MD * Pi / 180 'radians
        MM = 357.5291092 + 35999.0502909 * T - 0.0001536 * T * T + T * T * T / 24490000 'Sun's mean anomaly, degrees
        If MM >= 360 Or MM < 0 Then
            MM = MM - Int(MM / 360) * 360
        End If
        MM = MM * Pi / 180 'radians
        MMprime = 134.9633964 + 477198.8675055 * T + 0.0087414 * T * T + T * T * T / 69699 - T * T * T * T / 14712000 'Moon's mean anomaly, degrees
        If MMprime >= 360 Or MMprime < 0 Then
            MMprime = MMprime - Int(MMprime / 360) * 360
        End If
        MMprime = MMprime * Pi / 180 'radians
        MF = 93.272095 + 483202.0175233 * T - 0.0036539 * T * T - T * T * T / 3526000 + T * T * T * T / 863310000 'Moon's argument of altitude, degrees
        If MF >= 360 Or MF < 0 Then
            MF = MF - Int(MF / 360) * 360
        End If
        MF = MF * Pi / 180 'radians
        A1 = 119.75 + 131.849 * T 'degrees
        If A1 >= 360 Or A1 < 0 Then
            A1 = A1 - Int(A1 / 360) * 360
        End If
        A1 = A1 * Pi / 180 'radians
        A2 = 53.09 + 479264.29 * T 'degrees
        If A2 >= 360 Or A2 < 0 Then
            A2 = A2 - Int(A2 / 360) * 360
        End If
        A2 = A2 * Pi / 180 'radians
        A3 = 313.45 + 481266.484 * T 'degrees
        If A3 >= 360 Or A3 < 0 Then
            A3 = A3 - Int(A3 / 360) * 360
        End If
        A3 = A3 * Pi / 180 'radians
        E = 1 - 0.002516 * T - 0.0000074 * T * T
        SigmaL = 0
        SigmaR = 0
        SigmaB = 0
        For i = 0 To 59
            KA = 1
            KB = 1
            If MMA(i) = 1 Or MMA(i) = -1 Then KA = E
            If MMB(i) = 1 Or MMB(i) = -1 Then KB = E
            If MMA(i) = 2 Or MMA(i) = -2 Then KA = E * E
            If MMB(i) = 2 Or MMB(i) = -2 Then KB = E * E
            SigmaL = SigmaL + KA * MSinA(i) * System.Math.Sin(MDA(i) * MD + MMA(i) * MM + MMprimeA(i) * MMprime + MFA(i) * MF)
            SigmaR = SigmaR + KA * MCosA(i) * System.Math.Cos(MDA(i) * MD + MMA(i) * MM + MMprimeA(i) * MMprime + MFA(i) * MF)
            SigmaB = SigmaB + KB * MSinB(i) * System.Math.Sin(MDB(i) * MD + MMB(i) * MM + MMprimeB(i) * MMprime + MFB(i) * MF)
        Next i
        SigmaL = SigmaL + 3958 * System.Math.Sin(A1) + 1962 * System.Math.Sin(MLprime - MF) + 318 * System.Math.Sin(A2)
        SigmaB = SigmaB - 2235 * System.Math.Sin(MLprime) + 382 * System.Math.Sin(A3) + 175 * System.Math.Sin(A1 - MF) + 175 * System.Math.Sin(A1 + MF) + 127 * System.Math.Sin(MLprime - MMprime) - 115 * System.Math.Sin(MLprime + MMprime)
        L1 = MLprime * 180 / Pi + SigmaL / 1000000 'geocentric longitude, degrees
        B = SigmaB / 1000000 'geocentric latitude, degrees
        Delta = 385000.56 + SigmaR / 1000 'distance between centers of Earth and Moon, kilometers
        x = 6378.14 / Delta
        HP = System.Math.Atan(x / System.Math.Sqrt(-x * x + 1)) 'radians   arcsine
        HP = HP * 180 / Pi * 60 'arcminutes
        L1 = L1 + NL 'apparent longitude
        L1 = L1 * Pi / 180
        B = B * Pi / 180
        EclipticToEquatorial()
        AR = AR * 180 / Pi 'for Meeus ecl-to-eq
        DE = DE * 180 / Pi 'for Meeus ecl-to-eq
        Return True
    End Function

    Public Function Planets() As Boolean
        'L is heliocentric, ecliptic longitude, radians
        'B is heliocentric, ecliptic latitude, radians
        'r is heliocentric distance, astronomical units
        Delta = 0 : Tau = 0
        T = T / 10
        'For BN = 60 To 63
        For i = 1 To 3
            If i > 1 Then
                T = (JD - 2451545 - Tau) / 365250
            End If
            If BN = 60 Then
                L = Venus_L01(T) + Venus_L11(T) + Venus_L21(T) + Venus_L31(T) + Venus_L41(T) + Venus_L51(T)
                If System.Math.Abs(L) > (2 * Pi) Then
                    L = L - 2 * Pi * Int(L / 2 / Pi)
                End If
                B = Venus_B01(T) + Venus_B11(T) + Venus_B21(T) + Venus_B31(T) + Venus_B41(T) + Venus_B51(T)
                r = Venus_R01(T) + Venus_R11(T) + Venus_R21(T) + Venus_R31(T) + Venus_R41(T) + Venus_R51(T)
            End If
            If BN = 61 Then
                L = Mars_L01(T) + Mars_L02(T) + Mars_L03(T) + Mars_L11(T) + Mars_L12(T) + Mars_L21(T) + Mars_L31(T) + Mars_L41(T) + Mars_L51(T)
                If System.Math.Abs(L) > (2 * Pi) Then
                    L = L - 2 * Pi * Int(L / 2 / Pi)
                End If
                B = Mars_B01(T) + Mars_B11(T) + Mars_B21(T) + Mars_B31(T) + Mars_B41(T) + Mars_B51(T)
                r = Mars_R01(T) + Mars_R02(T) + Mars_R03(T) + Mars_R11(T) + Mars_R12(T) + Mars_R21(T) + Mars_R31(T) + Mars_R41(T) + Mars_R51(T)
            End If
            If BN = 62 Then
                L = Jupiter_L01(T) + Jupiter_L02(T) + Jupiter_L11(T) + Jupiter_L21(T) + Jupiter_L31(T) + Jupiter_L41(T) + Jupiter_L51(T)
                If System.Math.Abs(L) > (2 * Pi) Then
                    L = L - 2 * Pi * Int(L / 2 / Pi)
                End If
                B = Jupiter_B01(T) + Jupiter_B11(T) + Jupiter_B21(T) + Jupiter_B31(T) + Jupiter_B41(T) + Jupiter_B51(T)
                r = Jupiter_R01(T) + Jupiter_R02(T) + Jupiter_R11(T) + Jupiter_R21(T) + Jupiter_R31(T) + Jupiter_R41(T) + Jupiter_R51(T)
            End If
            If BN = 63 Then
                L = Saturn_L01(T) + Saturn_L02(T) + Saturn_L03(T) + Saturn_L11(T) + Saturn_L12(T) + Saturn_L21(T) + Saturn_L31(T) + Saturn_L41(T) + Saturn_L51(T)
                If System.Math.Abs(L) > (2 * Pi) Then
                    L = L - 2 * Pi * Int(L / 2 / Pi)
                End If
                B = Saturn_B01(T) + Saturn_B02(T) + Saturn_B11(T) + Saturn_B21(T) + Saturn_B31(T) + Saturn_B41(T) + Saturn_B51(T)
                r = Saturn_R01(T) + Saturn_R02(T) + Saturn_R03(T) + Saturn_R11(T) + Saturn_R12(T) + Saturn_R21(T) + Saturn_R31(T) + Saturn_R41(T) + Saturn_R51(T)
            End If
            'convert from heliocentric to geocentric coordinates
            If i = 1 Then
                L0 = Earth_L01(T) + Earth_L02(T) + Earth_L11(T) + Earth_L21(T) + Earth_L31(T) + Earth_L41(T) + Earth_L51(T)
                'L0Sun = L0
                If System.Math.Abs(L0) > (2 * Pi) Then
                    L0 = L0 - 2 * Pi * Int(L0 / 2 / Pi)
                End If
                B0 = Earth_B01(T) + Earth_B11(T) + Earth_B21(T) + Earth_B31(T) + Earth_B41(T)
                r0 = Earth_R01(T) + Earth_R02(T) + Earth_R11(T) + Earth_R21(T) + Earth_R31(T) + Earth_R41(T) + Earth_R51(T)
            End If
            x = r * System.Math.Cos(B) * System.Math.Cos(L) - r0 * System.Math.Cos(B0) * System.Math.Cos(L0)
            y = r * System.Math.Cos(B) * System.Math.Sin(L) - r0 * System.Math.Cos(B0) * System.Math.Sin(L0)
            Z = r * System.Math.Sin(B) - r0 * System.Math.Sin(B0)

            'Effect of light-time
            Delta = System.Math.Sqrt(x * x + y * y + Z * Z)
            Tau = 0.0057755183 * Delta
        Next i
        'geocentric longitude and latitude
        If System.Math.Abs(x) < 9.999999E-21 Then
            x = 9.999999E-21
        End If
        L1 = System.Math.Atan(y / x) 'geocentric longitude, radians
        If x < 0 Then
            L1 = L1 + Pi
        End If
        If L1 >= 2 * Pi Or L1 < 0 Then
            L1 = L1 - Int(L1 / (2 * Pi)) * 2 * Pi
        End If
        B = System.Math.Atan(Z / System.Math.Sqrt(x * x + y * y)) 'geocentric latitude, radians

        'Back to normal times
        T = T * 10
        'Apply Aberration
        Sun() 'for LN, Ecc needed in AberrationLB


        'LN = L0Sun
        AberrationLB()
        L1 = L1 + AberrL * Pi / 180 'radians
        B = B + AberrB * Pi / 180 'radians    'IS THIS LINE NEEDED????????????????????????????????????

        'apply nutation in longitude and obliquity; NL and NO come in as degrees
        L1 = L1 + NL * Pi / 180 'apparent longitude

        xmag = x 'used in PlanetMags so x does not get changed by EclipticToEquatorial

        EclipticToEquatorial()
        AR = AR * 180 / Pi
        DE = DE * 180 / Pi
        Return True
    End Function
    Private Sub PlanetMags()
        cosi = (xmag * System.Math.Cos(B) * System.Math.Cos(L) + y * System.Math.Cos(B) * System.Math.Sin(L) + Z * System.Math.Sin(B)) / Delta
        x = (-cosi * cosi + 1)
        If x <= 0 Then
            x = 9.999999E-21
        End If
        PhaseAngle = System.Math.Atan(-cosi / System.Math.Sqrt(x)) + Pi / 2 'phase angle, arc cosine
        PhaseAngle = PhaseAngle * 180 / Pi
        If GYear >= 1984 Then
            If BN = 60 Then Mag(BN) = -4.4 + 5 * System.Math.Log(r * Delta) / System.Math.Log(10) + 0.0009 * PhaseAngle + 0.000239 * PhaseAngle * PhaseAngle - 0.00000065 * PhaseAngle * PhaseAngle * PhaseAngle
            If BN = 61 Then Mag(BN) = -1.52 + 5 * System.Math.Log(r * Delta) / System.Math.Log(10) + 0.016 * PhaseAngle
            If BN = 62 Then Mag(BN) = -9.4 + 5 * System.Math.Log(r * Delta) / System.Math.Log(10) + 0.005 * PhaseAngle
            If BN = 63 Then Mag(BN) = -8.88 + 5 * System.Math.Log(r * Delta) / System.Math.Log(10) + 0.044 * PhaseAngle - 2.6 * System.Math.Sin(17 * Pi / 180) + 1.25 * System.Math.Sin(17 * Pi / 180) * System.Math.Sin(17 * Pi / 180) 'Gross approximation
        End If
        If GYear < 1984 Then
            If BN = 60 Then Mag(BN) = -4 + 5 * System.Math.Log(r * Delta) / System.Math.Log(10) + 0.01322 * PhaseAngle - 0.0000004247 * PhaseAngle * PhaseAngle * PhaseAngle
            If BN = 61 Then Mag(BN) = -1.3 + 5 * System.Math.Log(r * Delta) / System.Math.Log(10) + 0.01486 * PhaseAngle
            If BN = 62 Then Mag(BN) = -8.93 + 5 * System.Math.Log(r * Delta) / System.Math.Log(10)
            If BN = 63 Then Mag(BN) = -8.68 + 5 * System.Math.Log(r * Delta) / System.Math.Log(10) + 0.044 * PhaseAngle - 2.6 * System.Math.Sin(17 * Pi / 180) + 1.25 * System.Math.Sin(17 * Pi / 180) * System.Math.Sin(17 * Pi / 180) 'Gross approximation
        End If
        Mag(BN) = Int(Mag(BN) * 10 + 0.5) / 10
        SM = System.Math.Sign(Val(Mag(BN)))
        Mag(BN) = 10.01 + System.Math.Abs(Val(Mag(BN)))
        If SM = 1 Then Mag(BN) = " " + Mid$(Str$(Mag(BN)), 3, 3)
        If SM = -1 Then Mag(BN) = "-" + Mid$(Str$(Mag(BN)), 3, 3)
        If SM = 0 Then Mag(BN) = " 0.0"
    End Sub
    Public Function GHADec() As Boolean
        SH(IB) = 360 - AR
        GA(IB) = GR - AR
        If GA(IB) >= 360 Or GA(IB) < 0 Then
            GA(IB) = GA(IB) - Int(GA(IB) / 360) * 360
        End If
        SH(IB) = Int(SH(IB) * 10 + 0.5) / 10
        GRD(IB) = Int(AR)
        GRM(IB) = (AR - GRD(IB)) * 60
        GRM(IB) = Int(GRM(IB) * 10 + 0.5) / 10
        If GRM(IB) = 60 Then
            GRM(IB) = 0
            GRD(IB) = GRD(IB) + 1
        End If
        RA(IB) = Int(AR * 10 + 0.5) / 10
        If DE = 0 Then
            HD(IB) = " "
        End If
        If DE > 0 Then
            HD(IB) = g_LatN
        End If
        If DE < 0 Then
            HD(IB) = g_LatS
        End If
        DF(IB) = Int(System.Math.Abs(DE) * 10 + 0.5) / 10
        VD(IB) = Int(CDbl(GA(IB)))
        VM(IB) = (GA(IB) - VD(IB)) * 60
        VM(IB) = Int(VM(IB) * 10 + 0.5) / 10
        If VM(IB) = 60 Then
            VM(IB) = 0
            VD(IB) = VD(IB) + 1
        End If
        If VD(IB) = 360 Then
            VD(IB) = 0
        End If
        Return True
    End Function

    Public Function AltAz() As Boolean
        SQ = System.Math.Sin(DE * Pi / 180) * System.Math.Sin(Lat * Pi / 180) + System.Math.Cos(DE * Pi / 180) * System.Math.Cos(Lat * Pi / 180) * System.Math.Cos((GR - Lo - AR) * Pi / 180)
        q = System.Math.Atan(SQ / (System.Math.Sqrt(-SQ * SQ + 1) + 9.999999E-21))
        If TwilightFlag = False And q < 0 Then
            Ho = -1
            Return True
            Exit Function
        End If
        A = System.Math.Cos(Lat * Pi / 180) * System.Math.Cos(q)
        If A < 9.999999E-21 Then
            A = 9.999999E-21
        End If
        CP = (System.Math.Sin(DE * Pi / 180) - (System.Math.Sin(Lat * Pi / 180) * SQ)) / A
        If CP > 1 Then
            CP = 1 'added in V5.4.0 to avoid Dec. 21 90ºN type of error
        End If
        If CP < -1 Then
            CP = -1 'added in V5.4.0 to avoid Dec. 21 90ºN type of error
        End If
        PZ = System.Math.Atan(-CP / (System.Math.Sqrt(-CP * CP + 1) + 9.999999E-21)) + Pi / 2
        If System.Math.Sin((GR - Lo - AR) * Pi / 180) > 0 Then PZ = 2 * Pi - PZ
        ZN = PZ * 180 / Pi
        Ho = q * 180 / Pi
        Ho = Int(Ho + 0.5)
        ZN1 = Int(ZN * 10 + 0.5) / 10
        If FlagSRSS = True Then ZN = ZN1 Else ZN = Int(ZN + 0.5)    'V5.6.2
        Return True
    End Function

    Public Function Stars1() As Boolean
        I2 = 0
        I3 = 0 'stars
        For BN = 0 To 57
            Stars2()
            AltAz()
            MV = Val(Mag(BN))
            If Ho > 0 And MV < 1.55 Then
                First_Mag()
            End If
            If Ho > 0 And MV > 1.55 And MV < 2.55 Then
                Second_Mag()
            End If
            If Ho > 0 And MV > 2.55 Then
                Third_Mag()
            End If
        Next BN
        Return True
    End Function

    Public Function Stars2() As Boolean
        AR = RAStars(BN)
        DE = DecStars(BN)
        AR = AR * 15 'converts AR to degrees
        NY = (JD - 2451545.0!) / 365.25
        'Add Proper Motion
        AR = AR + PMRA(BN) * NY * 15 / 360000 ''PMRA(BN) in seconds/century - divide by 100 to get seconds/year, by 3600 to get hours, mult. by 15 to get degrees
        DE = DE + PMDec(BN) * NY / 360000 'PMDec(BN) arcseconds/century - divide by 100 to get arcseconds/year, by 3600 to get degrees
        'Precession
        Precession() 'this is the rigorous method; goes in with degrees, comes back as radians
        Sun() 'for sun's (mean longitude, L0, used in Nutation, and) true longitude, LN, in degrees, and Eccentricity, both used in AberrationRADec
        Nutation() 'returns nutation in longitude (NL) and nutation in obliquity (NO), both in degrees
        Obliquity() 'returns mean obliquity of the ecliptic (OE) and true obliquity (OETrue), both in degrees
        AberrationRADec() 'returns Aberration corrections to RA and Dec, AberrRA and AberrDec, both in degrees
        OETrue = OETrue * Pi / 180 'radians
        NutRA = (System.Math.Cos(OETrue) + System.Math.Sin(OETrue) * System.Math.Sin(AR) * System.Math.Tan(DE)) * NL - (System.Math.Cos(AR) * System.Math.Tan(DE)) * NO 'nutation correction to RA, degrees
        NutDec = (System.Math.Sin(OETrue) * System.Math.Cos(AR)) * NL + System.Math.Sin(AR) * NO 'nutation correction to Dec, degrees
        AR = AR * 180 / Pi + NutRA + AberrRA 'RA corrected for nutation and Aberration, degrees
        DE = DE * 180 / Pi + NutDec + AberrDec 'Dec corrected for nutation and Aberration, degrees
        Return True
    End Function

    Public Function Sorting() As Boolean
        If I1 <= 1 Then
            GoTo Line2720
        End If
        For i = 1 To I1 - 1 : P = i
            For IJ = i + 1 To I1
                If Z1(P) > Z1(IJ) Then P = IJ
            Next IJ
            TZ = Z1(i)
            Z1(i) = Z1(P)
            Z1(P) = TZ
            TB = Body1(i)
            Body1(i) = Body1(P)
            Body1(P) = TB
            TM = Mag1(i)
            Mag1(i) = Mag1(P)
            Mag1(P) = TM
            TH = H1A(i)
            H1A(i) = H1A(P)
            H1A(P) = TH
        Next i
Line2720:
        If I2 <= 1 Then
            GoTo Line2740
        End If
        For i = 1 To I2 - 1 : P = i
            For IJ = i + 1 To I2
                If Z2(P) > Z2(IJ) Then P = IJ
            Next IJ
            TZ = Z2(i)
            Z2(i) = Z2(P)
            Z2(P) = TZ
            TB = Body2(i)
            Body2(i) = Body2(P)
            Body2(P) = TB
            TM = Mag2(i)
            Mag2(i) = Mag2(P)
            Mag2(P) = TM
            TH = H2A(i)
            H2A(i) = H2A(P)
            H2A(P) = TH
        Next i
Line2740:
        If I3 <= 1 Then
            GoTo Line2760
        End If
        For i = 1 To I3 - 1 : P = i
            For IJ = i + 1 To I3
                If Z3(P) > Z3(IJ) Then P = IJ
            Next IJ
            TZ = Z3(i)
            Z3(i) = Z3(P)
            Z3(P) = TZ
            TB = Body3(i)
            Body3(i) = Body3(P)
            Body3(P) = TB
            TM = Mag3(i)
            Mag3(i) = Mag3(P)
            Mag3(P) = TM
            TH = H3A(i)
            H3A(i) = H3A(P)
            H3A(P) = TH
        Next i
Line2760:
        For i = 1 To I1
            Z1(i) = VB.Right(Str(1000 + Z1(i)), 3)
        Next i
        For i = 1 To I2
            Z2(i) = VB.Right(Str(1000 + Z2(i)), 3)
        Next i
        For i = 1 To I3
            Z3(i) = VB.Right(Str(1000 + Z3(i)), 3)
        Next i

        Return True
    End Function

    Public Sub DisplayFirst()
        Dim Mag1Hdr As String() = {"Body", "Zn" & Chr(176), "h" & Chr(176), "Mag."}
        Dim DataSet1 As DataSet = New DataSet()
        DataSet1.Tables.Add("Table1")
        DataSet1.DataSetName = "Table1"
        DGMag1.DataSource = DataSet1
        For i As Integer = 0 To UBound(Mag1Hdr)
            DataSet1.Tables("Table1").Columns.Add(Mag1Hdr(i))
            DataSet1.Tables("Table1").Columns(i).AllowDBNull = False
            DataSet1.Tables("Table1").Columns(i).DefaultValue = ""
        Next
        DGMag1.DataSource = DataSet1.Tables(0).DefaultView
        For i As Integer = 0 To DGMag1.Columns.Count - 1
            DGMag1.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            DGMag1.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGMag1.Columns(i).DefaultCellStyle.WrapMode = DataGridViewTriState.True
            DGMag1.Columns(i).SortMode = DataGridViewColumnSortMode.Programmatic
        Next
        DGMag1.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DGMag1.DefaultCellStyle.SelectionBackColor = DGMag1.DefaultCellStyle.BackColor
        DGMag1.DefaultCellStyle.SelectionForeColor = DGMag1.DefaultCellStyle.ForeColor

        DGMag1.Columns(0).MinimumWidth = 90
        DGMag1.Columns(1).MinimumWidth = 15
        DGMag1.Columns(2).MinimumWidth = 15
        DGMag1.Columns(3).MinimumWidth = 30

        LowAz = Val(txtLowAz.Text)
        HighAz = Val(txtHighAz.Text)
        If LowAz > HighAz Then
            HighAz = HighAz + 360
        End If
        Dim RowCt As Integer = 0
        For i = 1 To I1
            Z1Temp(i) = Z1(i)
            If Z1(i) < LowAz Then
                Z1Temp(i) = Z1(i) + 360
            End If
            If Z1Temp(i) >= LowAz And Z1Temp(i) <= HighAz Then
                DataSet1.Tables("Table1").Rows.Add(Body1(i), Strings.Format(Z1(i), "000") & Chr(176), Strings.Format(H1A(i), "00") & Chr(176), Mag1(i))
                If H1A(i) >= 15 And H1A(i) <= 75 Then
                    Select Case Body1(i).ToString.Trim
                        Case "Sun"
                            DGMag1.Rows(RowCt).DefaultCellStyle.Font = New Font("Times New Roman", 8, Drawing.FontStyle.Bold)
                            DGMag1.Rows(RowCt).DefaultCellStyle.BackColor = Color.Yellow
                        Case "Jupiter", "Moon", "Mars", "Saturn", "Venus"
                            DGMag1.Rows(RowCt).DefaultCellStyle.Font = New Font("Times New Roman", 8, Drawing.FontStyle.Bold)
                            DGMag1.Rows(RowCt).DefaultCellStyle.BackColor = Color.LightGreen
                        Case Else
                            DGMag1.Rows(RowCt).DefaultCellStyle.Font = New Font("Times New Roman", 8, Drawing.FontStyle.Bold)
                            DGMag1.Rows(RowCt).DefaultCellStyle.BackColor = Color.LightGray
                    End Select
                Else
                    Select Case Body1(i).ToString.Trim
                        Case "Sun"
                            DGMag1.Rows(RowCt).DefaultCellStyle.Font = New Font("Times New Roman", 8, Drawing.FontStyle.Regular)
                            DGMag1.Rows(RowCt).DefaultCellStyle.BackColor = Color.Yellow
                        Case "Jupiter", "Moon", "Mars", "Saturn", "Venus"
                            DGMag1.Rows(RowCt).DefaultCellStyle.Font = New Font("Times New Roman", 8, Drawing.FontStyle.Regular)
                            DGMag1.Rows(RowCt).DefaultCellStyle.BackColor = Color.AntiqueWhite
                        Case Else
                            DGMag1.Rows(RowCt).DefaultCellStyle.Font = New Font("Times New Roman", 8, Drawing.FontStyle.Regular)
                            DGMag1.Rows(RowCt).DefaultCellStyle.BackColor = Color.White
                    End Select
                End If
                RowCt += 1
            End If

        Next i
        DataSet1.Dispose()
        DGMag1.ClearSelection()
        DGMag1.CurrentCell = Nothing
        Exit Sub
    End Sub

    Public Sub DisplaySecond()
        Dim Mag1Hdr As String() = {"Body", "Zn" & Chr(176), "h" & Chr(176), "Mag."}
        Dim Dataset2 As DataSet = New DataSet()
        Dataset2.Tables.Add("Table1")
        Dataset2.DataSetName = "Table1"
        DGMag2.DataSource = Dataset2
        For i As Integer = 0 To UBound(Mag1Hdr)
            Dataset2.Tables("Table1").Columns.Add(Mag1Hdr(i))
            Dataset2.Tables("Table1").Columns(i).AllowDBNull = False
            Dataset2.Tables("Table1").Columns(i).DefaultValue = ""
        Next
        DGMag2.DataSource = Dataset2.Tables(0).DefaultView
        For i As Integer = 0 To DGMag2.Columns.Count - 1
            DGMag2.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            DGMag2.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGMag2.Columns(i).DefaultCellStyle.WrapMode = DataGridViewTriState.True
            DGMag2.Columns(i).SortMode = DataGridViewColumnSortMode.Programmatic
        Next
        DGMag2.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DGMag2.DefaultCellStyle.SelectionBackColor = DGMag2.DefaultCellStyle.BackColor
        DGMag2.DefaultCellStyle.SelectionForeColor = DGMag2.DefaultCellStyle.ForeColor
        DGMag2.Columns(0).MinimumWidth = 90
        DGMag2.Columns(1).MinimumWidth = 15
        DGMag2.Columns(2).MinimumWidth = 15
        DGMag2.Columns(3).MinimumWidth = 30


        LowAz = Val(txtLowAz.Text)
        HighAz = Val(txtHighAz.Text)
        If LowAz > HighAz Then
            HighAz = HighAz + 360
        End If
        Dim rowct As Integer = 0
        For i = 1 To I2
            Z2Temp(i) = Z2(i)
            If Z2(i) < LowAz Then
                Z2Temp(i) = Z2(i) + 360
            End If
            If Z2Temp(i) >= LowAz And Z2Temp(i) <= HighAz Then
                Dataset2.Tables("Table1").Rows.Add(Body2(i), Strings.Format(Z2(i), "000") & Chr(176), Strings.Format(H2A(i), "00") & Chr(176), Mag2(i))
                If H2A(i) >= 15 And H2A(i) <= 75 Then
                    DGMag2.Rows(rowct).DefaultCellStyle.Font = New Font("Times New Roman", 8, Drawing.FontStyle.Bold)
                    DGMag2.Rows(rowct).DefaultCellStyle.BackColor = Color.LightGray
                Else
                    DGMag2.Rows(rowct).DefaultCellStyle.Font = New Font("Times New Roman", 8, Drawing.FontStyle.Regular)
                    DGMag2.Rows(rowct).DefaultCellStyle.BackColor = Color.White
                End If
                rowct += 1
            End If
            Dataset2.Dispose()
        Next i
        DGMag2.ClearSelection()
        DGMag2.CurrentCell = Nothing
        Exit Sub

    End Sub

    Public Sub DisplayThird()

        Dim Mag1Hdr As String() = {"Body", "Zn" & Chr(176), "h" & Chr(176), "Mag."}
        Dim Dataset3 As DataSet = New DataSet()
        Dataset3.Tables.Add("Table1")
        Dataset3.DataSetName = "Table1"
        DGMag3.DataSource = Dataset3
        For i As Integer = 0 To UBound(Mag1Hdr)
            Dataset3.Tables("Table1").Columns.Add(Mag1Hdr(i))
            Dataset3.Tables("Table1").Columns(i).AllowDBNull = False
            Dataset3.Tables("Table1").Columns(i).DefaultValue = ""
        Next
        DGMag3.DataSource = Dataset3.Tables(0).DefaultView
        For i As Integer = 0 To DGMag3.Columns.Count - 1
            DGMag3.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            DGMag3.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGMag3.Columns(i).DefaultCellStyle.WrapMode = DataGridViewTriState.True
            DGMag3.Columns(i).SortMode = DataGridViewColumnSortMode.Programmatic
        Next
        DGMag3.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DGMag3.DefaultCellStyle.SelectionBackColor = DGMag3.DefaultCellStyle.BackColor
        DGMag3.DefaultCellStyle.SelectionForeColor = DGMag3.DefaultCellStyle.ForeColor
        DGMag3.Columns(0).MinimumWidth = 90
        DGMag3.Columns(1).MinimumWidth = 15
        DGMag3.Columns(2).MinimumWidth = 15
        DGMag3.Columns(3).MinimumWidth = 30


        LowAz = Val(txtLowAz.Text)
        HighAz = Val(txtHighAz.Text)
        If LowAz > HighAz Then
            HighAz = HighAz + 360
        End If
        Dim rowct As Integer = 0
        For i = 1 To I3
            Z3Temp(i) = Z3(i)
            If Z3(i) < LowAz Then
                Z3Temp(i) = Z3(i) + 360
            End If
            If Z3Temp(i) >= LowAz And Z3Temp(i) <= HighAz Then
                Dataset3.Tables("Table1").Rows.Add(Body3(i), Strings.Format(Z3(i), "000") & Chr(176), Strings.Format(H3A(i), "00") & Chr(176), Mag3(i))
                If H3A(i) >= 15 And H3A(i) <= 75 Then
                    DGMag3.Rows(rowct).DefaultCellStyle.Font = New Font("Times New Roman", 8, Drawing.FontStyle.Bold)
                    DGMag3.Rows(rowct).DefaultCellStyle.BackColor = Color.LightGray
                Else
                    DGMag3.Rows(rowct).DefaultCellStyle.Font = New Font("Times New Roman", 8, Drawing.FontStyle.Regular)
                    DGMag3.Rows(rowct).DefaultCellStyle.BackColor = Color.White
                End If
                rowct += 1
            End If
            Dataset3.Dispose()
        Next i
        DGMag3.ClearSelection()
        DGMag3.CurrentCell = Nothing
        Exit Sub
    End Sub

    Public Sub DisplayData()
        ReportTxtBx.Visible = True
        ReportTxtBx.BringToFront()

        ReportTxtBx.Clear()

        ReportTxtBx.AppendText("Date" & vbTab & vbTab & DTPlan.Value.ToString("dd MMM yyyy") & vbTab & vbTab & "DR L" & Space(5 + (3 - txtLDeg.Text.Length)) & Strings.Format(Val(txtLDeg.Text), "0") & Chr(176) & Strings.Format(Val(LMin), "00.0") & "'" & cboL.Text & vbNewLine)
        ReportTxtBx.AppendText("ZT" & vbTab & vbTab & txtTime.Text & vbTab & vbTab & vbTab & "DR Lo" & Space(5 + (3 - txtLoDeg.Text.Length)) & Strings.Format(Val(txtLoDeg.Text), "0") & Chr(176) & Strings.Format(Val(LoMin), "00.0") & "'" & cboLo.Text & vbNewLine)
        ReportTxtBx.AppendText("ZD" & vbTab & vbTab & "(")
        If System.Math.Sign(ZD) = 1 Then ReportTxtBx.AppendText("+")
        If System.Math.Sign(ZD) = -1 Then ReportTxtBx.AppendText("-")
        If System.Math.Sign(ZD) = 0 Then ReportTxtBx.AppendText(g_StrSpace)
        ReportTxtBx.AppendText(")" & Space(1) & Strings.Format(System.Math.Abs(ZD), "00")) 'Strings.format(Abs(Val(txtZDh.Text)), "00");
        If optZDManual.Checked = True And cboZDm.Text <> "00" Then
            ReportTxtBx.AppendText(cboZDm.Text & vbNewLine)
        Else
            ReportTxtBx.AppendText(vbNewLine)
        End If
        ReportTxtBx.AppendText("UT (GMT)" & vbTab & vbTab & Strings.Format(GHour, "00") & Strings.Format(GMinute, "00") & vbNewLine)
        ReportTxtBx.AppendText("G Day/Mo/Yr" & vbTab & Str(GDay) & Space(1) & MonthatG & Str(GYear) & vbNewLine)
        ReportTxtBx.AppendText(vbNewLine)
        ReportTxtBx.AppendText("GHA Aries     " & vbTab & Strings.Format(WD, "##0") & Chr(176) & Strings.Format(WM, "00.0") & "'" & vbNewLine)
        If System.Math.Sign(Lo) = 1 Then ReportTxtBx.AppendText("DR Lo       (-)")
        If System.Math.Sign(Lo) = -1 Then ReportTxtBx.AppendText("DR Lo       (+)")
        If System.Math.Sign(Lo) = 0 Then ReportTxtBx.AppendText("DR Lo       ( )")
        ReportTxtBx.AppendText(vbTab & Strings.Format(Val(txtLoDeg.Text), "0") & Chr(176) & Strings.Format(Val(LoMin), "00.0") & "'" & cboLo.Text & vbNewLine)
        ReportTxtBx.AppendText("LHA Aries     " & vbTab & Strings.Format(QD, "##0") & Chr(176) & Strings.Format(QM, "00.0") & "' = " & Strings.Format(LR, "##0.0") & Chr(176) & vbNewLine)
        ReportTxtBx.AppendText(vbNewLine)
        ReportTxtBx.AppendText("GHA Sun       " & vbTab & Strings.Format(VD(1), "##0") & Chr(176) & Strings.Format(VM(1), "00.0") & "'" & vbTab & vbTab & "GHA Moon       " & Space(4 - Len(Str(VD(2)))) & Strings.Format(VD(2), "##0") & Chr(176) & Strings.Format(VM(2), "00.0") & "'" & vbNewLine)
        ReportTxtBx.AppendText("RA  Sun       " & vbTab & Strings.Format(GRD(1), "##0") & Chr(176) & Strings.Format(GRM(1), "00.0") & "' = " & Strings.Format(RA(1), "##0.0") & Chr(176) & vbTab & "RA  Moon       " & Space(4 - Len(Str(GRD(2)))) & Strings.Format(GRD(2), "##0") & Chr(176) & Strings.Format(GRM(2), "00.0") & "' = " & Strings.Format(RA(2), "##0.0") & Chr(176) & vbNewLine)
        ReportTxtBx.AppendText("Dec Sun       " & vbTab & Strings.Format(DF(1), "0.0") & Chr(176) & HD(1) & vbTab & vbTab & "Dec Moon       " & vbTab & Strings.Format(DF(2), "0.0") & Chr(176) & HD(2) & vbNewLine)
        ReportTxtBx.AppendText(vbNewLine)
        ReportTxtBx.AppendText("Planet " & vbTab & "SHA" & vbTab & vbTab & "RA" & vbTab & vbTab & "Dec" & vbNewLine)
        ReportTxtBx.AppendText("Venus  " & vbTab & Strings.Format(SH(3), "##0.0") & Chr(176) & vbTab & vbTab & Strings.Format(RA(3), "##0.0") & Chr(176) & vbTab & vbTab & Strings.Format(DF(3), "#0.0") & Chr(176) & HD(3) & vbNewLine)
        ReportTxtBx.AppendText("Mars   " & vbTab & Strings.Format(SH(4), "##0.0") & Chr(176) & vbTab & vbTab & Strings.Format(RA(4), "##0.0") & Chr(176) & vbTab & vbTab & Strings.Format(DF(4), "#0.0") & Chr(176) & HD(4) & vbNewLine)
        ReportTxtBx.AppendText("Jupiter" & vbTab & Strings.Format(SH(5), "##0.0") & Chr(176) & vbTab & vbTab & Strings.Format(RA(5), "##0.0") & Chr(176) & vbTab & vbTab & Strings.Format(DF(5), "#0.0") & Chr(176) & HD(5) & vbNewLine)
        ReportTxtBx.AppendText("Saturn " & vbTab & Strings.Format(SH(6), "##0.0") & Chr(176) & vbTab & vbTab & Strings.Format(RA(6), "##0.0") & Chr(176) & vbTab & vbTab & Strings.Format(DF(6), "#0.0") & Chr(176) & HD(6) & vbNewLine)
        Exit Sub
    End Sub

    Public Function First_Mag() As Boolean
        I1 = I1 + 1
        Body1(I1) = Body(BN)
        Mag1(I1) = Mag(BN)
        Z1(I1) = ZN
        H1A(I1) = Ho
        Return True
    End Function
    Public Function Second_Mag() As Boolean
        I2 = I2 + 1
        Body2(I2) = Body(BN)
        Mag2(I2) = Mag(BN)
        Z2(I2) = ZN
        H2A(I2) = Ho
        Return True
    End Function

    Public Function Third_Mag() As Boolean 'was Sub2523
        I3 = I3 + 1
        Body3(I3) = Body(BN)
        Mag3(I3) = Mag(BN)
        Z3(I3) = ZN
        H3A(I3) = Ho
        Return True
    End Function
    Public Function CheckDate() As Boolean
        DateOfSight = DTPlan.Value.ToString("dd MMMM yyyy")
        Return False
        Exit Function
    End Function
    Private Sub txtLowAz_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLowAz.TextChanged
        'txtLowAz.ForeColor = &H80000008
        txtLowAz.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtLowAz.Text) > 360 Then
            txtLowAz.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range", "Entry Error", MessageBoxButtons.OK)
        End If
        'ExecCmdTwilights()
        'SelectTabToDisplay()
    End Sub

    Private Sub txtLowAz_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtLowAz.KeyPress
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

    Private Sub txtLowAz_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtLowAz.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtLowAz.Text) > 360 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtLowAz_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLowAz.Enter
        SelectAllText(txtLowAz)
        ExecCmdTwilights()
        SelectTabToDisplay()
    End Sub
    Private Sub txtLowAz_Leave(sender As Object, e As EventArgs) Handles txtLowAz.Leave
        If txtTime.Text <> "" Then
            SelectAllText(txtLowAz)
            ExecCmdTwilights()
            SelectTabToDisplay()
        End If
    End Sub
    Private Sub txtHighAz_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHighAz.TextChanged
        'txtHighAz.ForeColor = &H80000008
        txtHighAz.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtHighAz.Text) > 360 Then
            txtHighAz.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range", "Entry Error", MessageBoxButtons.OK)
        End If
        'ExecCmdTwilights()
        'SelectTabToDisplay()
    End Sub

    Private Sub txtHighAz_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtHighAz.KeyPress
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

    Private Sub txtHighAz_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtHighAz.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtHighAz.Text) > 360 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtHighAz_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHighAz.Enter
        If txtTime.Text <> "" Then
            SelectAllText(txtHighAz)
            ExecCmdTwilights()
            SelectTabToDisplay()
        End If
    End Sub

    Private Sub StarMagnitudes()
        If GYear <= 2005 Then
            Magnitude = New String() {" 2.1", " 2.2", " 2.4", " 2.5", " 2.2", " 0.6", " 2.2", " 3.1", " 2.8", " 1.9", " 1.1", " 0.3", " 0.2", " 1.7", " 1.8", " 1.8", " 0.1 - 1.2", " -0.9", " -1.6", " 1.6", " 0.5", " 1.2", " 1.7", " 2.2", " 1.8", " 2.2", " 1.3", " 2.0", " 2.2", " 2.8", " 1.1", " 1.6", " 1.7", " 1.2", " 1.9", " 0.9", " 2.3", " 0.2", " 0.1", " 2.9", " 2.2", " 2.3", " 1.2", " 1.9", " 2.6", " 1.7", " 2.1", " 2.4", " 2.0", " 0.1", " 2.1", " 0.9", " 2.1", " 1.3", " 2.5", " 2.2", " 1.3", " 2.6"}
        Else
            Magnitude = New String() {" 2.1", " 2.1", " 2.4", " 2.2", " 2.0", " 0.5", " 2.0", " 3.2", " 2.5", " 1.8", " 0.9", " 0.1", " 0.1", " 1.6", " 1.7", " 1.7", " 0.1 - 1.2", " -0.7", " -1.5", " 1.5", " 0.4", " 1.1", " 1.9", " 2.2", " 1.7", " 2.0", " 1.4", " 1.8", " 2.1", " 2.6", " 1.3", " 1.6", " 1.8", " 1.0", " 1.9", " 0.6", " 2.1", " 0.0", " -0.3", " 2.8", " 2.1", " 2.2", " 1.0", " 1.9", " 2.4", " 1.6", " 2.1", " 2.2", " 1.9", " 0.0", " 2.0", " 0.8", " 1.9", " 1.3", " 2.4", " 1.7", " 1.2", " 2.5"}
        End If
        For i = 0 To UBound(Magnitude, 1)
            Mag(i) = Magnitude(i)
        Next i
    End Sub
    Public Sub DrawCelestialCircles()
        Dim DPen As Pen = New Pen(Color.Black, 1)
        DPen.DashStyle = Drawing2D.DashStyle.Solid
        Dim DrawWidth As Double = (SkyPicBx.Width / 2) - 25
        Dim CircleDiam As Integer = DrawWidth
        Dim XTD1, YTD1 As Single
        Dim XTD2, YTD2 As Single
        Dim TwoPi, i As Single
        ' redefined from global variables for local use 
        Dim x As Integer = 0
        Dim y As Integer = 0

        TwoPi = 8 * System.Math.Atan(1)

        DPen.DashStyle = Drawing2D.DashStyle.Dot

        For i = 0 To TwoPi Step TwoPi / 24
            XTD1 = -(DrawWidth) * System.Math.Cos(i)
            YTD1 = -(DrawWidth) * System.Math.Sin(i)
            XTD2 = DrawWidth * System.Math.Cos(i)
            YTD2 = DrawWidth * System.Math.Sin(i)
            Plan1graphic.DrawLine(DPen, XTD1, YTD1, XTD2, YTD2)
            'Plan1graphic.DrawString(i.ToString, DFont2, DPen.Brush, XTD2, YTD2) 'debugging statement to allow visualization of rotation direction
        Next i

        Dim CircleDiamDelta As Integer = DrawWidth / 6 ' every 15 degrees from horizon to zenith = 6 circles

        Plan1graphic.DrawEllipse(DPen, -CircleDiam, CircleDiam, 2 * CircleDiam, -(2 * CircleDiam)) ' horizon circle
        CircleDiam -= CircleDiamDelta
        Plan1graphic.DrawEllipse(DPen, -CircleDiam, CircleDiam, 2 * CircleDiam, -(2 * CircleDiam)) ' 15 degree circle
        CircleDiam -= CircleDiamDelta

        DPen.DashStyle = Drawing2D.DashStyle.Dot

        Plan1graphic.DrawEllipse(DPen, -CircleDiam, CircleDiam, 2 * CircleDiam, -(2 * CircleDiam)) ' 30 degree circle
        CircleDiam -= CircleDiamDelta
        Plan1graphic.DrawEllipse(DPen, -CircleDiam, CircleDiam, 2 * CircleDiam, -(2 * CircleDiam)) ' 45 degree circle
        CircleDiam -= CircleDiamDelta
        Plan1graphic.DrawEllipse(DPen, -CircleDiam, CircleDiam, 2 * CircleDiam, -(2 * CircleDiam)) ' 60 degree circle
        CircleDiam -= CircleDiamDelta

        DPen.DashStyle = Drawing2D.DashStyle.Solid

        Plan1graphic.DrawEllipse(DPen, -CircleDiam, CircleDiam, 2 * CircleDiam, -(2 * CircleDiam)) ' 75 degree circle
        Plan1graphic.FillEllipse(Brushes.White, -(CircleDiam - 1), CircleDiam - 1, 2 * (CircleDiam - 1), -(2 * CircleDiam - 1)) ' cler out circle 75 - 90 degree circle
        Exit Sub
    End Sub
    Public Sub DisplayView()

        Dim ttx As Integer = 0
        Dim tty As Integer = 0
        Warning()
        If DisplayInitialView = False Then 'GoTo skipVisibles
            lblAltitude.Visible = True
            lblAzimuth.Visible = True
            lblAz.Visible = True
            lblAlt.Visible = True
            Label5.Visible = True
            Label7.Visible = True

            lblBody.Visible = True
            lblBodyName.Visible = True

            chkFirst.Visible = True
            chkSecond.Visible = True
            chkThird.Visible = True
            chkNames.Visible = True
            chkLimit.Visible = True
            chkHelper.Visible = True
            FrameView.Visible = True
            FrameDirection.Visible = True
            FrameBest.Visible = True
            bShowToolTips = True
        End If

skipVisibles:

        lblN.Visible = True
        lblE.Visible = True
        lblS.Visible = True
        lblW.Visible = True
        lblSRight.Visible = False
        lblSLeft.Visible = False

        If optOff.Checked = False Then
            cmdCCW.Enabled = True
            cmdCW.Enabled = True
            ResetRotateBtn.Enabled = True
            RotateIncr.Enabled = True
        End If

        Dim TwoPi, i As Single
        ' redefined from global variables for local use 
        Dim x As Integer = 0
        Dim y As Integer = 0

        TwoPi = 8 * System.Math.Atan(1)
        Dim DFont1 As Font = New Font("Times New Roman", 10)
        Dim DFont2 As Font = New Font("Times New Roman", 8)
        Dim DFont3 As Font = New Font("Times New Roman", 6)

        'RecyclePlan1Jpg()

        'set up fresh / new bitmap and graphics drawwing object for diagram and later additions
        Dim DrawWidth As Double = (SkyPicBx.Width / 2) - 25
        bm = New Bitmap(SkyPicBx.Width, SkyPicBx.Height)
        SkyPicBx.ImageLocation = Nothing
        Plan1graphic = Graphics.FromImage(bm)
        Plan1graphic.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        Plan1graphic.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAliasGridFit
        Plan1graphic.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
        Plan1graphic.TranslateTransform(SkyPicBx.Width / 2, SkyPicBx.Height / 2)

        Dim DPen As Pen = New Pen(Color.Black)
        DPen.DashStyle = Drawing2D.DashStyle.Solid
        Dim ptA As Point = New Point
        Dim ptB As Point = New Point

        DrawCelestialCircles()

        ' on form load, an initial display of the basic celestial circle is drawn with nothing else
        If DisplayInitialView = True Then
            DisplayInitialView = False
            GoTo SaveBMandDisplay
        End If
        ' otherwise we are drawwing the visible stars and objects
        DPen.DashStyle = Drawing2D.DashStyle.Solid
        DPen.Brush = Brushes.Black

        LowAz = Val(txtLowAz.Text)
        HighAz = Val(txtHighAz.Text)
        If LowAz > HighAz Then HighAz = HighAz + 360

        'First magnitude bodies
        For i = 0 To UBound(VwBody1, 1)
            VwBody1.Initialize()
        Next i

        Dim Lpt As Point = New Point
        Lpt.X = Plan1TabCntl.Location.X + SkyPicBx.Location.X
        Lpt.Y = Plan1TabCntl.ItemSize.Height + Plan1TabCntl.Location.Y + SkyPicBx.Location.Y

        If chkFirst.Checked = True Then
            ReDim VwBody1(I1)
            For i = 1 To I1
                rad = DrawWidth * (1 - H1A(i) / 90)
                Z1(i) = Val(Z1(i))
                Z1Temp(i) = Z1(i)
                If Z1(i) < LowAz Then
                    Z1Temp(i) = Z1(i) + 360
                End If
                ' Z1(i) is the ZN measured clockwise to the east from due north. This graphic starts its rotation due East and rotates counter clockwise
                ' so Zn must be made negative and reduced by 90 degress to get the proper rotation and proper north orientation for start. The Rotate X
                ' and RotateY corrections are due to selections of east up, south up and west up for diagram and should be rotated negative the same as the other angles
                ' These corrections and math should be true for all x / y calculations for DisplayView and DisplayHorizonView angles
                x = rad * System.Math.Cos(-1 * (Z1(i) + 90 + RotateX) * Pi / 180)
                y = rad * System.Math.Sin(-1 * (Z1(i) + 90 + RotateY) * Pi / 180)
                If optStarFinder.Checked = True And (optN.Checked = True Or optS.Checked = True) Then
                    x = -x
                End If
                If optStarFinder.Checked = True And (optE.Checked = True Or optW.Checked = True) Then
                    y = -y
                End If

                Dim Mag1size As Integer = DFont1.SizeInPoints
                Dim Mag1delta As Integer = Mag1size / 2
                Dim UleftX As Integer = x - Mag1delta
                Dim UleftY As Integer = y - Mag1delta

                If chkLimit.Checked = True And Z1Temp(i) >= LowAz And Z1Temp(i) <= HighAz Then
                    Plan1graphic.DrawEllipse(DPen, UleftX, UleftY, Mag1size, Mag1size)
                    If Body1(i).ToString = "Sun" Then
                        Plan1graphic.FillEllipse(Brushes.Yellow, UleftX, UleftY, Mag1size, Mag1size)
                    ElseIf Body1(i).ToString = "Moon" Then
                        Plan1graphic.FillEllipse(Brushes.LightGreen, UleftX, UleftY, Mag1size, Mag1size)
                    ElseIf Body1(i).ToString = "Venus" Or Body1(i).ToString = "Mars" Or Body1(i).ToString = "Jupiter" Or Body1(i).ToString = "Saturn" Then
                        Plan1graphic.FillEllipse(Brushes.Red, UleftX, UleftY, Mag1size, Mag1size)
                    Else
                        Plan1graphic.FillEllipse(Brushes.Blue, UleftX, UleftY, Mag1size, Mag1size)
                    End If
                End If

                If chkLimit.Checked = False Then
                    Plan1graphic.DrawEllipse(DPen, UleftX, UleftY, Mag1size, Mag1size)
                    If Body1(i).ToString = "Sun" Then
                        Plan1graphic.FillEllipse(Brushes.Yellow, UleftX, UleftY, Mag1size, Mag1size)
                    ElseIf Body1(i).ToString = "Moon" Then
                        Plan1graphic.FillEllipse(Brushes.LightGreen, UleftX, UleftY, Mag1size, Mag1size)
                    ElseIf Body1(i).ToString = "Venus" Or Body1(i).ToString = "Mars" Or Body1(i).ToString = "Jupiter" Or Body1(i).ToString = "Saturn" Then
                        Plan1graphic.FillEllipse(Brushes.Red, UleftX, UleftY, Mag1size, Mag1size)
                    Else
                        Plan1graphic.FillEllipse(Brushes.Blue, UleftX, UleftY, Mag1size, Mag1size)
                    End If

                End If
                VwBody1(i) = New BodyInfo
                VwBody1(i).BodyName = Body1(i)
                VwBody1(i).BodyLoc.X = UleftX
                VwBody1(i).BodyLoc.Y = UleftY
                VwBody1(i).BodyLocSz = 12
                VwBody1(i).BodyAlt = H1A(i).ToString
                VwBody1(i).BodyAz = Z1(i).ToString
                If (chkNames.Checked = True And Z1Temp(i) >= LowAz And Z1Temp(i) <= HighAz) Or (chkNames.Checked = True And chkLimit.Checked = False) Then
                    Plan1graphic.DrawString(Body1(i).ToString,
                                            New Font("Arial", 7, Drawing.FontStyle.Regular), Brushes.Blue, x + Mag1delta, y + Mag1delta)
                    Plan1graphic.DrawString("Az:" & Z1(i).ToString & Chr(176) & " Alt:" & H1A(i).ToString & Chr(176),
                    New Font("Arial", 7, Drawing.FontStyle.Regular), Brushes.Blue, x + Mag1delta, y + 3 * Mag1delta)
                End If
            Next i
        End If

        'Second magnitude bodies
        For i = 0 To UBound(VwBody2, 1)
            VwBody2.Initialize()
        Next i
        If chkSecond.Checked = True Then
            ReDim VwBody2(I2)
            For i = 1 To I2
                rad = DrawWidth * (1 - H2A(i) / 90)
                Z2(i) = Val(Z2(i))
                Z2Temp(i) = Z2(i)
                If Z2(i) < LowAz Then Z2Temp(i) = Z2(i) + 360
                x = rad * System.Math.Cos(-1 * (Z2(i) + 90 + RotateX) * Pi / 180)
                y = rad * System.Math.Sin(-1 * (Z2(i) + 90 + RotateY) * Pi / 180)
                If optStarFinder.Checked = True And (optN.Checked = True Or optS.Checked = True) Then
                    x = -x
                End If
                If optStarFinder.Checked = True And (optE.Checked = True Or optW.Checked = True) Then
                    y = -y
                End If

                Dim Mag1size As Integer = DFont2.SizeInPoints
                Dim Mag1delta As Integer = Mag1size / 2
                Dim UleftX As Integer = x - Mag1delta
                Dim UleftY As Integer = y - Mag1delta

                If chkLimit.Checked = True And Z2Temp(i) >= LowAz And Z2Temp(i) <= HighAz Then
                    Plan1graphic.DrawEllipse(DPen, UleftX, UleftY, Mag1size, Mag1size)
                    Plan1graphic.FillEllipse(Brushes.DarkGray, UleftX, UleftY, Mag1size, Mag1size)
                End If

                If chkLimit.Checked = False Then
                    Plan1graphic.DrawEllipse(DPen, UleftX, UleftY, Mag1size, Mag1size)
                    Plan1graphic.FillEllipse(Brushes.DarkGray, UleftX, UleftY, Mag1size, Mag1size)
                End If

                VwBody2(i) = New BodyInfo
                VwBody2(i).BodyName = Body2(i)
                VwBody2(i).BodyLoc.X = UleftX
                VwBody2(i).BodyLoc.Y = UleftY
                VwBody2(i).BodyLocSz = 12
                VwBody2(i).BodyAlt = H2A(i).ToString
                VwBody2(i).BodyAz = Z2(i).ToString

                If (chkNames.Checked = True And chkLimit.Checked = True And Z2Temp(i) >= LowAz And Z2Temp(i) <= HighAz) Or (chkNames.Checked = True And chkLimit.Checked = False) Then
                    Plan1graphic.DrawString(Body2(i).ToString,
                                            New Font("Arial", 7, Drawing.FontStyle.Regular), Brushes.DarkGray, x + Mag1delta, y + Mag1delta)
                    Plan1graphic.DrawString("Az:" & Z2(i).ToString & Chr(176) & " Alt:" & H2A(i).ToString & Chr(176),
                    New Font("Arial", 7, Drawing.FontStyle.Regular), Brushes.DarkGray, x + Mag1delta, y + 3 * Mag1delta)
                End If
            Next i
        End If
        'Third magnitude bodies
        For i = 0 To UBound(VwBody3, 1)
            VwBody3.Initialize()
        Next i

        If chkThird.Checked = True Then
            ReDim VwBody3(I3)
            For i = 1 To I3
                rad = DrawWidth * (1 - H3A(i) / 90)
                Z3(i) = Val(Z3(i))
                Z3Temp(i) = Z3(i)
                If Z3(i) < LowAz Then Z3Temp(i) = Z3(i) + 360
                x = rad * System.Math.Cos(-1 * (Z3(i) + 90 + RotateX) * Pi / 180)
                y = rad * System.Math.Sin(-1 * (Z3(i) + 90 + RotateY) * Pi / 180)
                If optStarFinder.Checked = True And (optN.Checked = True Or optS.Checked = True) Then
                    x = -x
                End If
                If optStarFinder.Checked = True And (optE.Checked = True Or optW.Checked = True) Then
                    y = -y
                End If

                Dim Mag1size As Integer = DFont3.SizeInPoints
                Dim Mag1delta As Integer = 3
                Dim UleftX As Integer = x - Mag1delta
                Dim UleftY As Integer = y - Mag1delta

                If chkLimit.Checked = True And Z3Temp(i) >= LowAz And Z3Temp(i) <= HighAz Then
                    Plan1graphic.DrawEllipse(DPen, UleftX, UleftY, Mag1size, Mag1size)
                    Plan1graphic.FillEllipse(Brushes.LightGray, UleftX, UleftY, Mag1size, Mag1size)
                End If

                If chkLimit.Checked = False Then
                    Plan1graphic.DrawEllipse(DPen, UleftX, UleftY, Mag1size, Mag1size)
                    Plan1graphic.FillEllipse(Brushes.LightGray, UleftX, UleftY, Mag1size, Mag1size)
                End If

                VwBody3(i) = New BodyInfo
                VwBody3(i).BodyName = Body3(i)
                VwBody3(i).BodyLoc.X = UleftX
                VwBody3(i).BodyLoc.Y = UleftY
                VwBody3(i).BodyLocSz = 12
                VwBody3(i).BodyAlt = H3A(i).ToString
                VwBody3(i).BodyAz = Z3(i).ToString

                If (chkNames.Checked = True And Z3Temp(i) >= LowAz And Z3Temp(i) <= HighAz) Or (chkNames.Checked = True And chkLimit.Checked = False) Then
                    Plan1graphic.DrawString(Body3(i).ToString,
                                            New Font("Arial", 6, Drawing.FontStyle.Regular), Brushes.LightGray, x + Mag1delta, y + Mag1delta)
                    Plan1graphic.DrawString("Az:" & Z3(i).ToString & Chr(176) & " Alt:" & H3A(i).ToString & Chr(176),
                    New Font("Arial", 6, Drawing.FontStyle.Regular), Brushes.LightGray, x + Mag1delta, y + 3 * Mag1delta)
                End If
            Next i
        End If
        DPen.Brush = Brushes.Transparent
        DPen.DashStyle = Drawing2D.DashStyle.Dash

        If chkHelper.Checked = True Then
            'First magnitude Helper stars
            For i = 0 To NumberOfHelpers - 1
                rad = 2400 * (1 - HH1A(i) / 90)
                ZH1Temp(i) = ZH1(i)
                If ZH1(i) < LowAz Then ZH1Temp(i) = ZH1(i) + 360
                x = rad * System.Math.Cos(-1 * (ZH1(i) + 90 + RotateX) * Pi / 180)
                y = rad * System.Math.Sin(-1 * (ZH1(i) + 90 + RotateY) * Pi / 180)
                If optStarFinder.Checked = True And (optN.Checked = True Or optS.Checked = True) Then x = -x
                If optStarFinder.Checked = True And (optE.Checked = True Or optW.Checked = True) Then y = -y

                Dim Mag1size As Integer = 8
                Dim Mag1delta As Integer = Mag1size / 2
                Dim UleftX As Integer = x - Mag1delta
                Dim UleftY As Integer = y - Mag1delta

                If chkLimit.Checked = True And ZH1Temp(i) >= LowAz And ZH1Temp(i) <= HighAz And HH1A(i) <> 0 Then
                    Plan1graphic.DrawEllipse(DPen, UleftX, UleftY, Mag1size, Mag1size)
                End If
                If chkLimit.Checked = False And HH1A(i) <> 0 Then
                    Plan1graphic.DrawEllipse(DPen, UleftX, UleftY, Mag1size, Mag1size)
                End If
            Next i
            'Second magnitude Helper stars
            For i = 0 To NumberOfHelpers - 1
                rad = 2400 * (1 - HH2A(i) / 90)
                ZH2Temp(i) = ZH2(i)
                If ZH2(i) < LowAz Then ZH2Temp(i) = ZH2(i) + 360
                x = rad * System.Math.Cos(-1 * (ZH2(i) + 90 + RotateX) * Pi / 180)
                y = rad * System.Math.Sin(-1 * (ZH2(i) + 90 + RotateY) * Pi / 180)
                If optStarFinder.Checked = True And (optN.Checked = True Or optS.Checked = True) Then x = -x
                If optStarFinder.Checked = True And (optE.Checked = True Or optW.Checked = True) Then y = -y

                Dim Mag1size As Integer = 6
                Dim Mag1delta As Integer = Mag1size / 2
                Dim UleftX As Integer = x - Mag1delta
                Dim UleftY As Integer = y - Mag1delta

                If chkLimit.Checked = True And ZH2Temp(i) >= LowAz And ZH2Temp(i) <= HighAz And HH2A(i) <> 0 Then
                    Plan1graphic.DrawEllipse(DPen, UleftX, UleftY, Mag1size, Mag1size)
                End If
                If chkLimit.Checked = False And HH2A(i) <> 0 Then
                    Plan1graphic.DrawEllipse(DPen, UleftX, UleftY, Mag1size, Mag1size)
                End If
            Next i
            'Third magnitude Helper stars
            For i = 0 To NumberOfHelpers - 1
                rad = 2400 * (1 - HH3A(i) / 90)
                ZH3Temp(i) = ZH3(i)
                If ZH3(i) < LowAz Then ZH3Temp(i) = ZH3(i) + 360
                x = rad * System.Math.Cos(-1 * (ZH3(i) + 90 + RotateX) * Pi / 180)
                y = rad * System.Math.Sin(-1 * (ZH3(i) + 90 + RotateY) * Pi / 180)
                If optStarFinder.Checked = True And (optN.Checked = True Or optS.Checked = True) Then x = -x
                If optStarFinder.Checked = True And (optE.Checked = True Or optW.Checked = True) Then y = -y

                Dim Mag1size As Integer = 4
                Dim Mag1delta As Integer = Mag1size / 2
                Dim UleftX As Integer = x - Mag1delta
                Dim UleftY As Integer = y - Mag1delta

                If chkLimit.Checked = True And ZH3Temp(i) >= LowAz And ZH3Temp(i) <= HighAz And HH3A(i) <> 0 Then
                    Plan1graphic.DrawEllipse(DPen, UleftX, UleftY, Mag1size, Mag1size)
                End If
                If chkLimit.Checked = False And HH3A(i) <> 0 Then
                    Plan1graphic.DrawEllipse(DPen, UleftX, UleftY, Mag1size, Mag1size)
                End If
            Next i
            'Fourth+ magnitude Helper stars
            For i = 0 To NumberOfHelpers - 1
                rad = 2400 * (1 - HH4A(i) / 90)
                ZH4Temp(i) = ZH4(i)
                If ZH4(i) < LowAz Then ZH4Temp(i) = ZH4(i) + 360
                x = rad * System.Math.Cos(-1 * (ZH4(i) + 90 + RotateX) * Pi / 180)
                y = rad * System.Math.Sin(-1 * (ZH4(i) + 90 + RotateY) * Pi / 180)
                If optStarFinder.Checked = True And (optN.Checked = True Or optS.Checked = True) Then x = -x
                If optStarFinder.Checked = True And (optE.Checked = True Or optW.Checked = True) Then y = -y

                Dim Mag1size As Integer = 4
                Dim Mag1delta As Integer = Mag1size / 2
                Dim UleftX As Integer = x - Mag1delta
                Dim UleftY As Integer = y - Mag1delta

                If chkLimit.Checked = True And ZH4Temp(i) >= LowAz And ZH4Temp(i) <= HighAz And HH4A(i) <> 0 Then
                    Plan1graphic.DrawEllipse(DPen, UleftX, UleftY, Mag1size, Mag1size)
                End If
                If chkLimit.Checked = False And HH4A(i) <> 0 Then
                    Plan1graphic.DrawEllipse(DPen, UleftX, UleftY, Mag1size, Mag1size)
                End If
            Next i
        End If
        ' now draw 2 and 3 body best fix lines if the options are selected
        DPen = New Pen(Color.Red, 2)
        Plan1graphic.RotateTransform(-90)
        If optHorizon.Checked = False And optTwo.Checked = True Then
            DPen.DashStyle = Drawing2D.DashStyle.Solid
            XTB1 = DrawWidth * System.Math.Cos(SweepStep2)
            YTB1 = DrawWidth * System.Math.Sin(SweepStep2)
            XTB2 = DrawWidth * System.Math.Cos(SweepStep2 + Pi / 2)
            YTB2 = DrawWidth * System.Math.Sin(SweepStep2 + Pi / 2)
            Plan1graphic.DrawLine(DPen, 0, 0, XTB1, YTB1)
            Plan1graphic.DrawLine(DPen, 0, 0, XTB2, YTB2)
            XTB4 = DrawWidth * System.Math.Cos(SweepStep2 - Pi / 8)
            YTB4 = DrawWidth * System.Math.Sin(SweepStep2 - Pi / 8)
            XTB5 = DrawWidth * System.Math.Cos(SweepStep2 + Pi / 8)
            YTB5 = DrawWidth * System.Math.Sin(SweepStep2 + Pi / 8)
            XTB6 = DrawWidth * System.Math.Cos(SweepStep2 + Pi / 2 - Pi / 8)
            YTB6 = DrawWidth * System.Math.Sin(SweepStep2 + Pi / 2 - Pi / 8)
            XTB7 = DrawWidth * System.Math.Cos(SweepStep2 + Pi / 2 + Pi / 8)
            YTB7 = DrawWidth * System.Math.Sin(SweepStep2 + Pi / 2 + Pi / 8)
            DPen.DashStyle = Drawing2D.DashStyle.Dash
            Plan1graphic.DrawLine(DPen, 0, 0, XTB4, YTB4)
            Plan1graphic.DrawLine(DPen, 0, 0, XTB5, YTB5)
            DPen.DashStyle = Drawing2D.DashStyle.DashDot
            Plan1graphic.DrawLine(DPen, 0, 0, XTB6, YTB6)
            Plan1graphic.DrawLine(DPen, 0, 0, XTB7, YTB7)
        End If
        If optHorizon.Checked = False And (optThreeBoat.Checked = True Or optThreeBeach.Checked = True) Then
            XTB1 = DrawWidth * System.Math.Cos(SweepStep3)
            YTB1 = DrawWidth * System.Math.Sin(SweepStep3)
            XTB2 = DrawWidth * System.Math.Cos(SweepStep3 + 2 * Pi / 3)
            YTB2 = DrawWidth * System.Math.Sin(SweepStep3 + 2 * Pi / 3)
            XTB3 = DrawWidth * System.Math.Cos(SweepStep3 + 4 * Pi / 3)
            YTB3 = DrawWidth * System.Math.Sin(SweepStep3 + 4 * Pi / 3)
            XTB8 = DrawWidth * System.Math.Cos(SweepStep3 + Pi)
            YTB8 = DrawWidth * System.Math.Sin(SweepStep3 + Pi)
            XTB9 = DrawWidth * System.Math.Cos(SweepStep3 - Pi / 12)
            YTB9 = DrawWidth * System.Math.Sin(SweepStep3 - Pi / 12)
            XTB10 = DrawWidth * System.Math.Cos(SweepStep3 + Pi / 12)
            YTB10 = DrawWidth * System.Math.Sin(SweepStep3 + Pi / 12)
            XTB11 = DrawWidth * System.Math.Cos(SweepStep3 + 2 * Pi / 3 - Pi / 12)
            YTB11 = DrawWidth * System.Math.Sin(SweepStep3 + 2 * Pi / 3 - Pi / 12)
            XTB12 = DrawWidth * System.Math.Cos(SweepStep3 + 2 * Pi / 3 + Pi / 12)
            YTB12 = DrawWidth * System.Math.Sin(SweepStep3 + 2 * Pi / 3 + Pi / 12)
            XTB13 = DrawWidth * System.Math.Cos(SweepStep3 + 4 * Pi / 3 - Pi / 12)
            YTB13 = DrawWidth * System.Math.Sin(SweepStep3 + 4 * Pi / 3 - Pi / 12)
            XTB14 = DrawWidth * System.Math.Cos(SweepStep3 + 4 * Pi / 3 + Pi / 12)
            YTB14 = DrawWidth * System.Math.Sin(SweepStep3 + 4 * Pi / 3 + Pi / 12)
            XTB15 = DrawWidth * System.Math.Cos(SweepStep3 + Pi - Pi / 12)
            YTB15 = DrawWidth * System.Math.Sin(SweepStep3 + Pi - Pi / 12)
            XTB16 = DrawWidth * System.Math.Cos(SweepStep3 + Pi + Pi / 12)
            YTB16 = DrawWidth * System.Math.Sin(SweepStep3 + Pi + Pi / 12)
            DPen.DashStyle = Drawing2D.DashStyle.Solid
            Plan1graphic.DrawLine(DPen, 0, 0, XTB2, YTB2)
            Plan1graphic.DrawLine(DPen, 0, 0, XTB3, YTB3)
            If optThreeBoat.Checked = True Then
                DPen.DashStyle = Drawing2D.DashStyle.Solid
                DPen.Color = Color.Red
                Plan1graphic.DrawLine(DPen, 0, 0, XTB1, YTB1)
                DPen.DashStyle = Drawing2D.DashStyle.Dash
                Plan1graphic.DrawLine(DPen, 0, 0, XTB9, YTB9)
                Plan1graphic.DrawLine(DPen, 0, 0, XTB10, YTB10)
                DPen.DashStyle = Drawing2D.DashStyle.DashDot
                Plan1graphic.DrawLine(DPen, 0, 0, XTB11, YTB11)
                Plan1graphic.DrawLine(DPen, 0, 0, XTB12, YTB12)
                DPen.DashStyle = Drawing2D.DashStyle.DashDotDot
                Plan1graphic.DrawLine(DPen, 0, 0, XTB13, YTB13)
                Plan1graphic.DrawLine(DPen, 0, 0, XTB14, YTB14)
            End If
            If optThreeBeach.Checked = True Then
                DPen.DashStyle = Drawing2D.DashStyle.Solid
                DPen.Color = Color.Red
                Plan1graphic.DrawLine(DPen, 0, 0, XTB8, YTB8)
                DPen.DashStyle = Drawing2D.DashStyle.Dash
                Plan1graphic.DrawLine(DPen, 0, 0, XTB11, YTB11)
                Plan1graphic.DrawLine(DPen, 0, 0, XTB14, YTB14)
            End If
        End If
SaveBMandDisplay:
        SaveDisplayBMFname()
        Exit Sub
    End Sub
    Private Sub DisplayHorizonView()
        Warning()

        Dim DFont1 As Font = New Font("Times New Roman", 10)
        Dim DFont2 As Font = New Font("Times New Roman", 8)
        Dim DFont3 As Font = New Font("Times New Roman", 8)

        'RecyclePlan1Jpg()

        'set up fresh / new bitmap and graphics drawwing object for diagram and later additions
        Dim DrawWidth As Integer = (SkyPicBx.Width) - 10
        bm = New Bitmap(SkyPicBx.Width, SkyPicBx.Height)
        SkyPicBx.ImageLocation = Nothing
        Plan1graphic = Graphics.FromImage(bm)
        Plan1graphic.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        Plan1graphic.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAliasGridFit
        Plan1graphic.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
        'Plan1graphic.TranslateTransform(15, 0)

        Dim DPen As Pen = New Pen(Color.Black, 1)
        DPen.DashStyle = Drawing2D.DashStyle.Solid
        Dim ptA As Point = New Point
        Dim ptB As Point = New Point

        Dim x As Integer = 0
        Dim y As Integer = 0

        lblAltitude.Visible = True
        lblAzimuth.Visible = True
        lblAz.Visible = True
        lblAlt.Visible = True
        Label5.Visible = True
        Label7.Visible = True
        lblBody.Visible = True
        lblBodyName.Visible = True

        'lblOverhead.Visible = True
        chkFirst.Visible = True
        chkSecond.Visible = True
        chkThird.Visible = True
        chkNames.Visible = True
        chkLimit.Visible = True
        chkHelper.Visible = True
        FrameView.Visible = True
        FrameDirection.Visible = True
        lblN.Visible = False
        lblS.Visible = True
        lblSRight.Visible = True
        lblSLeft.Visible = True
        lblE.Visible = False
        lblW.Visible = False
        FrameBest.Visible = False

        Dim i As Single 'TwoPi,
        Dim Xdiv As Integer = 20
        Dim Ydiv As Integer = 6
        Dim drawYdelta As Integer = DrawWidth / Ydiv
        Dim drawY As Integer = 0
        Dim drawXdelta As Integer = DrawWidth / Xdiv
        Dim drawX As Integer = drawXdelta
        Dim MinZn As Integer = 0
        Dim MaxZn As Integer = 0
        Dim XPlotDelta As Integer = 180 / Xdiv
        Dim YPlotDelta As Integer = 90 / Ydiv


        Dim Lpt As Point = New Point()
        Lpt = New Point(SkyPicBx.Location.X, SkyPicBx.Location.Y)

        Plan1graphic.DrawRectangle(DPen, 0, 0, DrawWidth, DrawWidth)
        drawY += drawYdelta
        Plan1graphic.DrawLine(DPen, 0, drawY, DrawWidth, drawY)  '75 degree altitude line
        Plan1graphic.DrawString("75" & Chr(176), DFont3, DPen.Brush, DrawWidth - 18, drawY)
        Plan1graphic.DrawString("75" & Chr(176), DFont3, DPen.Brush, +3, drawY)
        drawY += drawYdelta
        DPen.DashStyle = Drawing2D.DashStyle.Dot
        Plan1graphic.DrawLine(DPen, 0, drawY, DrawWidth, drawY) '60 degree altitude line
        Plan1graphic.DrawString("60" & Chr(176), DFont3, DPen.Brush, DrawWidth - 18, drawY)
        Plan1graphic.DrawString("60" & Chr(176), DFont3, DPen.Brush, +3, drawY)
        drawY += drawYdelta
        Plan1graphic.DrawLine(DPen, 0, drawY, DrawWidth, drawY)  '45 degree altitude line
        Plan1graphic.DrawString("45" & Chr(176), DFont3, DPen.Brush, DrawWidth - 18, drawY)
        Plan1graphic.DrawString("45" & Chr(176), DFont3, DPen.Brush, +3, drawY)
        drawY += drawYdelta
        Plan1graphic.DrawLine(DPen, 0, drawY, DrawWidth, drawY)  '30 degree altitude line
        Plan1graphic.DrawString("30" & Chr(176), DFont3, DPen.Brush, DrawWidth - 18, drawY)
        Plan1graphic.DrawString("30" & Chr(176), DFont3, DPen.Brush, +3, drawY)
        DPen.DashStyle = Drawing2D.DashStyle.Solid
        drawY += drawYdelta
        Plan1graphic.DrawLine(DPen, 0, drawY, DrawWidth, drawY)  '15 degree altitude line
        Plan1graphic.DrawString("15" & Chr(176), DFont3, DPen.Brush, DrawWidth - 18, drawY)
        Plan1graphic.DrawString("15" & Chr(176), DFont3, DPen.Brush, +3, drawY)
        DPen.DashStyle = Drawing2D.DashStyle.Dot

        For i = 1 To Xdiv
            Plan1graphic.DrawLine(DPen, drawX, 0, drawX, DrawWidth)
            drawX += drawXdelta
        Next i

        If optE.Checked = True Then
            MinZn = 0
            MaxZn = 180
        End If
        If optW.Checked = True Then
            MinZn = 180
            MaxZn = 360
        End If
        If optN.Checked = True Then
            MinZn = 270
            MaxZn = 90
        End If
        If optS.Checked = True Then
            MinZn = 90
            MaxZn = 270
        End If

        DPen.DashStyle = Drawing2D.DashStyle.Solid
        DPen.Brush = Brushes.Black
        LowAz = Val(txtLowAz.Text)
        HighAz = Val(txtHighAz.Text)

        If LowAz > HighAz Then
            HighAz = HighAz + 360
        End If
        For i = 0 To UBound(VwBody1, 1)
            VwBody1.Initialize()
        Next i
        'First magnitude bodies
        If chkFirst.Checked = True Then
            ReDim VwBody1(I1)
            For i = 1 To I1
                Z1(i) = Val(Z1(i))
                Z1Temp(i) = Z1(i)
                If Z1(i) < LowAz Then
                    Z1Temp(i) = Z1(i) + 360
                End If

                If optN.Checked = True Then
                    If (Z1(i) >= MinZn And Z1(i) <= 360) Then
                        x = ((Z1(i) - MinZn) / XPlotDelta) * drawXdelta
                    ElseIf (Z1(i) >= 0 And Z1(i) <= MaxZn) Then
                        x = ((Z1(i) + 90) / XPlotDelta) * drawXdelta
                    Else
                        GoTo Next1Mag
                    End If
                Else
                    If Z1(i) < MinZn Or Z1(i) > MaxZn Then
                        GoTo Next1Mag
                    End If
                    x = ((Z1(i) - MinZn) / XPlotDelta) * drawXdelta
                End If

                y = ((90 - H1A(i)) / YPlotDelta) * drawYdelta

                Dim Mag1size As Integer = 10
                Dim UleftX As Integer = x - 5
                Dim UleftY As Integer = y - 5

                Plan1graphic.DrawEllipse(DPen, UleftX, UleftY, Mag1size, Mag1size)
                If Body1(i).ToString = "Sun" Then
                    Plan1graphic.FillEllipse(Brushes.Yellow, UleftX, UleftY, Mag1size, Mag1size)
                ElseIf Body1(i).ToString = "Moon" Then
                    Plan1graphic.FillEllipse(Brushes.LawnGreen, UleftX, UleftY, Mag1size, Mag1size)
                ElseIf Body1(i).ToString = "Venus" Or Body1(i).ToString = "Mars" Or Body1(i).ToString = "Jupiter" Or Body1(i).ToString = "Saturn" Then
                    Plan1graphic.FillEllipse(Brushes.Red, UleftX, UleftY, Mag1size, Mag1size)
                Else
                    Plan1graphic.FillEllipse(Brushes.Blue, UleftX, UleftY, Mag1size, Mag1size)
                End If

                VwBody1(i) = New BodyInfo
                VwBody1(i).BodyName = Body1(i)
                VwBody1(i).BodyLoc.X = x
                VwBody1(i).BodyLoc.Y = y
                VwBody1(i).BodyLocSz = 10
                VwBody1(i).BodyAlt = H1A(i).ToString
                VwBody1(i).BodyAz = Z1(i).ToString
                If chkNames.Checked = True And chkLimit.Checked = False Then
                    Plan1graphic.DrawString(Body1(i).ToString,
                                            New Font("Arial", 7, Drawing.FontStyle.Regular), Brushes.Blue, x + 5, y + 5)
                    Plan1graphic.DrawString("Az:" & Z1(i).ToString & Chr(176) & " Alt:" & H1A(i).ToString & Chr(176),
                    New Font("Arial", 7, Drawing.FontStyle.Regular), Brushes.Blue, x + 5, y + (5 + DFont1.Height))
                End If
Next1Mag:
            Next i
        End If

        For i = 0 To UBound(VwBody2, 1)
            VwBody2.Initialize()
        Next i
        'Second magnitude bodies
        If chkSecond.Checked = True Then
            ReDim VwBody2(I2)
            For i = 1 To I2
                Z2(i) = Val(Z2(i))
                Z2Temp(i) = Z2(i)
                If Z2(i) < LowAz Then Z2Temp(i) = Z2(i) + 360

                If optN.Checked = True Then
                    If (Z2(i) >= MinZn And Z2(i) <= 360) Then
                        x = ((Z2(i) - MinZn) / XPlotDelta) * drawXdelta
                    ElseIf (Z2(i) >= 0 And Z2(i) <= MaxZn) Then
                        x = ((Z2(i) + 90) / XPlotDelta) * drawXdelta
                    Else
                        GoTo Next2Mag
                    End If
                Else
                    If Z2(i) < MinZn Or Z2(i) > MaxZn Then
                        GoTo Next2Mag
                    End If
                    x = ((Z2(i) - MinZn) / XPlotDelta) * drawXdelta
                End If
                y = ((90 - H2A(i)) / YPlotDelta) * drawYdelta

                Dim Mag1size As Integer = 8
                Dim UleftX As Integer = x - 4
                Dim UleftY As Integer = y - 4

                Plan1graphic.DrawEllipse(DPen, UleftX, UleftY, Mag1size, Mag1size)
                Plan1graphic.FillEllipse(Brushes.DarkGray, UleftX, UleftY, Mag1size, Mag1size)

                VwBody2(i) = New BodyInfo
                VwBody2(i).BodyName = Body2(i)
                VwBody2(i).BodyLoc.X = x
                VwBody2(i).BodyLoc.Y = y
                VwBody2(i).BodyLocSz = 10
                VwBody2(i).BodyAlt = H2A(i).ToString
                VwBody2(i).BodyAz = Z2(i).ToString

                If chkNames.Checked = True And chkLimit.Checked = False Then
                    Plan1graphic.DrawString(Body2(i).ToString,
                                            New Font("Arial", 7, Drawing.FontStyle.Regular), Brushes.DarkGray, x + 5, y + 5)
                    Plan1graphic.DrawString("Az:" & Z2(i).ToString & Chr(176) & " Alt:" & H2A(i).ToString & Chr(176),
                    New Font("Arial", 7, Drawing.FontStyle.Regular), Brushes.DarkGray, x + 5, y + (5 + DFont1.Height))
                End If
Next2Mag:
            Next i
        End If
        'Third magnitude bodies
        For i = 0 To UBound(VwBody3, 1)
            VwBody3.Initialize()
        Next i

        If chkThird.Checked = True Then
            ReDim VwBody3(I3)
            For i = 1 To I3
                Z3(i) = Val(Z3(i))
                Z3Temp(i) = Z3(i)
                If Z3(i) < LowAz Then
                    Z3Temp(i) = Z3(i) + 360
                End If

                If optN.Checked = True Then
                    If (Z3(i) >= MinZn And Z3(i) <= 360) Then
                        x = ((Z3(i) - MinZn) / XPlotDelta) * drawXdelta
                    ElseIf (Z3(i) >= 0 And Z3(i) <= MaxZn) Then
                        x = ((Z3(i) + 90) / XPlotDelta) * drawXdelta
                    Else
                        GoTo Next3Mag
                    End If
                Else
                    If Z3(i) < MinZn Or Z3(i) > MaxZn Then
                        GoTo Next3Mag
                    End If
                    x = ((Z3(i) - MinZn) / XPlotDelta) * drawXdelta
                End If
                y = ((90 - H3A(i)) / YPlotDelta) * drawYdelta
                Plan1graphic.DrawEllipse(DPen, x, y, 6, 6)
                Plan1graphic.FillEllipse(Brushes.LightGray, x, y, 6, 6)

                VwBody3(i) = New BodyInfo
                VwBody3(i).BodyName = Body3(i)
                VwBody3(i).BodyLoc.X = x
                VwBody3(i).BodyLoc.Y = y
                VwBody3(i).BodyLocSz = 10
                VwBody3(i).BodyAlt = H3A(i).ToString
                VwBody3(i).BodyAz = Z3(i).ToString

                If chkNames.Checked = True And chkLimit.Checked = False Then
                    Plan1graphic.DrawString(Body3(i).ToString,
                                            New Font("Arial", 7, Drawing.FontStyle.Regular), Brushes.LightGray, x + 5, y + 5)
                    Plan1graphic.DrawString("Az:" & Z3(i).ToString & Chr(176) & " Alt:" & H3A(i).ToString & Chr(176),
                    New Font("Arial", 7, Drawing.FontStyle.Regular), Brushes.LightGray, x + 5, y + (5 + DFont1.Height))
                End If
Next3Mag:
            Next i
        End If

        ' See if Helper stars need to be shown
        If chkHelper.Checked = True Then
            'First magnitude Helper stars
            For i = 0 To NumberOfHelpers - 1
                ZH1Temp(i) = ZH1(i)
                If ZH1(i) < LowAz Then
                    ZH1Temp(i) = ZH1(i) + 360
                End If

                If optN.Checked = True Then
                    If (ZH1(i) >= MinZn And ZH1(i) <= 360) Then
                        x = ((ZH1(i) - MinZn) / XPlotDelta) * drawXdelta
                    ElseIf (ZH1(i) >= 0 And ZH1(i) <= MaxZn) Then
                        x = ((ZH1(i) + 90) / XPlotDelta) * drawXdelta
                    Else
                        GoTo Next1MagHelp
                    End If
                Else
                    If ZH1(i) < MinZn Or ZH1(i) > MaxZn Then
                        GoTo Next1MagHelp
                    End If
                    x = ((ZH1(i) - MinZn) / XPlotDelta) * drawXdelta
                End If
                y = ((90 - HH1A(i)) / YPlotDelta) * drawYdelta
                Plan1graphic.DrawEllipse(DPen, x, y, 6, 6)
                Plan1graphic.FillEllipse(DPen.Brush, x, y, 6, 6)

Next1MagHelp:
            Next i

            'Second magnitude Helper stars
            For i = 0 To NumberOfHelpers - 1
                ZH2Temp(i) = ZH2(i)
                If ZH2(i) < LowAz Then
                    ZH2Temp(i) = ZH2(i) + 360
                End If

                If optN.Checked = True Then
                    If (ZH2(i) >= MinZn And ZH2(i) <= 360) Then
                        x = ((ZH2(i) - MinZn) / XPlotDelta) * drawXdelta
                    ElseIf (ZH2(i) >= 0 And ZH2(i) <= MaxZn) Then
                        x = ((ZH2(i) + 90) / XPlotDelta) * drawXdelta
                    Else
                        GoTo Next2MagHelp
                    End If
                Else
                    If ZH2(i) < MinZn Or ZH2(i) > MaxZn Then
                        GoTo Next2MagHelp
                    End If
                    x = ((ZH2(i) - MinZn) / XPlotDelta) * drawXdelta
                End If
                y = ((90 - HH2A(i)) / YPlotDelta) * drawYdelta
                Plan1graphic.DrawEllipse(DPen, x, y, 6, 6)
                Plan1graphic.FillEllipse(DPen.Brush, x, y, 6, 6)

Next2MagHelp:
            Next i

            'Third magnitude Helper stars
            For i = 0 To NumberOfHelpers - 1
                ZH3Temp(i) = ZH3(i)
                If ZH3(i) < LowAz Then
                    ZH3Temp(i) = ZH3(i) + 360
                End If

                If optN.Checked = True Then
                    If (ZH3(i) >= MinZn And ZH3(i) <= 360) Then
                        x = ((ZH3(i) - MinZn) / XPlotDelta) * drawXdelta
                    ElseIf (ZH3(i) >= 0 And ZH3(i) <= MaxZn) Then
                        x = ((ZH3(i) + 90) / XPlotDelta) * drawXdelta
                    Else
                        GoTo Next3MagHelp
                    End If
                Else
                    If ZH3(i) < MinZn Or ZH3(i) > MaxZn Then
                        GoTo Next3MagHelp
                    End If
                    x = ((ZH3(i) - MinZn) / XPlotDelta) * drawXdelta
                End If
                y = ((90 - HH3A(i)) / YPlotDelta) * drawYdelta
                Plan1graphic.DrawEllipse(DPen, x, y, 6, 6)
                Plan1graphic.FillEllipse(DPen.Brush, x, y, 6, 6)

Next3MagHelp:
            Next i
            'Fourth+ magnitude Helper stars
            For i = 0 To NumberOfHelpers - 1
                ZH4Temp(i) = ZH4(i)
                If ZH4(i) < LowAz Then
                    ZH4Temp(i) = ZH4(i) + 360
                End If

                If optN.Checked = True Then
                    If (ZH4(i) >= MinZn And ZH3(i) <= 360) Then
                        x = ((ZH3(i) - MinZn) / XPlotDelta) * drawXdelta
                    ElseIf (ZH3(i) >= 0 And ZH3(i) <= MaxZn) Then
                        x = ((ZH3(i) + 90) / XPlotDelta) * drawXdelta
                    Else
                        GoTo Next4MagHelp
                    End If
                Else
                    If ZH3(i) < MinZn Or ZH3(i) > MaxZn Then
                        GoTo Next4MagHelp
                    End If
                    x = ((ZH3(i) - MinZn) / XPlotDelta) * drawXdelta
                End If
                y = ((90 - HH4A(i)) / YPlotDelta) * drawYdelta
                Plan1graphic.DrawEllipse(DPen, x, y, 6, 6)
                Plan1graphic.FillEllipse(DPen.Brush, x, y, 6, 6)
Next4MagHelp:
            Next i
        End If
EndofDisHorizon:
        SaveDisplayBMFname()
        Exit Sub
    End Sub
    Public Sub SaveDisplayBMFname()
        'Try
        If System.IO.File.Exists(BMFname) Then
            If C_IsFileInUse(BMFname) = True Then
                RecyclePlan1Jpg()
            Else
                System.IO.File.Delete(BMFname)
                RecyclePlan1Jpg()
            End If
        End If
        bm.Save(BMFname)
        SkyPicBx.ImageLocation = BMFname
        'bm.Save(BMFname)
        SkyPicBx.Refresh()
        ViewVisiblePg.Refresh()
        SkyPicBx.Image = Nothing
        bm.Dispose()
        Exit Sub
        '        Catch ex1 As System.Runtime.InteropServices.ExternalException
        '            Exit Sub
        '        Catch ex As Exception
        '            Dim file As System.IO.StreamWriter
        '            file = My.Computer.FileSystem.OpenTextFileWriter("Plan1Log.txt", True)
        '            file.WriteLine(Now.ToLongDateString & Space(2) & Now.ToLongTimeString & " - " & "Try #1 - Exception on BM Save: Name = " & BMFname & Space(2) & "  Exception: " & ex.ToString)
        '            file.Close()
        '            GoTo TryAgain
        '        Finally

        '        End Try
        'TryAgain:
        '        Try
        '            RecyclePlan1Jpg()
        '            bm.Save(BMFname)
        '            SkyPicBx.Refresh()
        '            ViewVisiblePg.Refresh()
        '            Exit Sub
        '        Catch ex1 As System.Runtime.InteropServices.ExternalException
        '            Exit Sub
        '        Catch ex As Exception
        '            Dim file As System.IO.StreamWriter
        '            file = My.Computer.FileSystem.OpenTextFileWriter("Plan1Log.txt", True)
        '            file.WriteLine(Now.ToLongDateString & Space(2) & Now.ToLongTimeString & " - " & "Try #2 - Exception on BM Save: Name =" & BMFname & "Exception: " & ex.ToString)
        '            file.Close()
        '            Exit Sub
        '        End Try
        '        SkyPicBx.Refresh()
        '        ViewVisiblePg.Refresh()
        '        Exit Sub
    End Sub
    Public Function MouseX(Optional ByVal hWnd As Integer = 0) As Integer
        Return (PointToClient(MousePosition)).X
    End Function

    Public Function MouseY(Optional ByVal hWnd As Integer = 0) As Integer
        Return (PointToClient(MousePosition)).Y
    End Function
    Private Sub chkNames_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkNames.CheckStateChanged
        If Not FormSightPlanLoaded Then Exit Sub
        BlankTimeFlag = False
        ExecCmdTwilights()
        ViewVisibleBodies()

    End Sub
    Private Sub chkFirst_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkFirst.CheckStateChanged
        If Not FormSightPlanLoaded Then Exit Sub
        BlankTimeFlag = False
        ExecCmdTwilights()
        ViewVisibleBodies()
    End Sub
    Private Sub chkSecond_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkSecond.CheckStateChanged
        If Not FormSightPlanLoaded Then Exit Sub
        BlankTimeFlag = False
        ExecCmdTwilights()
        ViewVisibleBodies()
    End Sub
    Private Sub chkThird_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkThird.CheckStateChanged
        If Not FormSightPlanLoaded Then Exit Sub
        BlankTimeFlag = False
        ExecCmdTwilights()
        ViewVisibleBodies()
    End Sub

    Public Function Helpers() As Boolean
        For k = 0 To NumberOfHelpers - 1
            RDHelper1 = RDHelper(k)
            RMHelper1 = RMHelper(k)
            RSHelper1 = RSHelper(k)
            DDHelper1 = DDHelper(k)
            DMHelper1 = DMHelper(k)
            DSHelper1 = DSHelper(k)
            AR = RDHelper1 + RMHelper1 / 60 + RSHelper1 / 3600
            DE = System.Math.Abs(DDHelper1) + System.Math.Abs(DMHelper1) / 60 + System.Math.Abs(DSHelper1) / 3600
            If System.Math.Sign(DDHelper1) = -1 Or System.Math.Sign(DMHelper1) = -1 Or System.Math.Sign(DSHelper1) = -1 Then
                DE = -DE
            End If
            AR = AR * 15 ': AR = AR * Pi / 180: DE = DE * Pi / 180
            'Precession
            Precession() 'this is the rigorous method; goes in with degrees, comes back as radians
            Sun() 'for sun's (mean longitude, L0, used in Nutation, and) true longitude, LN, in degrees, and Eccentricity, both used in AberrationRADec
            Nutation() 'returns nutation in longitude (NL) and nutation in obliquity (NO), both in degrees
            Obliquity() 'returns mean obliquity of the ecliptic (OE) and true obliquity (OETrue), both in degrees
            AberrationRADec() 'returns Aberration corrections to RA and Dec, AberrRA and AberrDec, both in degrees
            OETrue = OETrue * Pi / 180 'radians
            NutRA = (System.Math.Cos(OETrue) + System.Math.Sin(OETrue) * System.Math.Sin(AR) * System.Math.Tan(DE)) * NL - (System.Math.Cos(AR) * System.Math.Tan(DE)) * NO 'nutation correction to RA, degrees
            NutDec = (System.Math.Sin(OETrue) * System.Math.Cos(AR)) * NL + System.Math.Sin(AR) * NO 'nutation correction to Dec, degrees
            AR = AR * 180 / Pi + NutRA + AberrRA 'RA corrected for nutation and Aberration, degrees
            DE = DE * 180 / Pi + NutDec + AberrDec 'Dec corrected for nutation and Aberration, degrees

            For j = 0 To NumberOfHelpers - 1
                MagH1(k) = 0
                ZH1(k) = 0
                HH1A(k) = 0
                MagH2(k) = 0
                ZH2(k) = 0
                HH2A(k) = 0
                MagH3(k) = 0
                ZH3(k) = 0
                HH3A(k) = 0
                MagH4(k) = 0
                ZH4(k) = 0
                HH4A(k) = 0
            Next j
            AltAz() 'go in with degrees
            If Ho > 0 And MagHelper(k) < 1.55 Then
                MagH1(k) = MagHelper(k)
                ZH1(k) = ZN
                HH1A(k) = Ho
            End If
            If Ho > 0 And MagHelper(k) > 1.55 And MagHelper(k) < 2.55 Then
                MagH2(k) = MagHelper(k)
                ZH2(k) = ZN
                HH2A(k) = Ho
            End If
            If Ho > 0 And MagHelper(k) > 2.55 And MagHelper(k) < 3.55 Then
                MagH3(k) = MagHelper(k)
                ZH3(k) = ZN
                HH3A(k) = Ho
            End If
            If Ho > 0 And MagHelper(k) > 3.55 Then
                MagH4(k) = MagHelper(k)
                ZH4(k) = ZN
                HH4A(k) = Ho
            End If
        Next k
        Return True
    End Function
    Private Sub chkHelper_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkHelper.CheckStateChanged
        If Not FormSightPlanLoaded Then Exit Sub

        If chkHelper.Checked = True Then
            TempFirst = chkFirst.CheckState
            TempSecond = chkSecond.CheckState
            TempThird = chkThird.CheckState
            chkFirst.CheckState = System.Windows.Forms.CheckState.Checked
            chkFirst.Enabled = False
            chkSecond.CheckState = System.Windows.Forms.CheckState.Checked
            chkSecond.Enabled = False
            chkThird.CheckState = System.Windows.Forms.CheckState.Checked
            chkThird.Enabled = False
        End If
        If chkHelper.Checked = False Then
            chkFirst.Enabled = True
            If TempFirst = True Then
                chkFirst.CheckState = System.Windows.Forms.CheckState.Checked
            Else
                chkFirst.CheckState = System.Windows.Forms.CheckState.Unchecked
            End If
            chkSecond.Enabled = True
            If TempSecond = True Then
                chkSecond.CheckState = System.Windows.Forms.CheckState.Checked
            Else
                chkSecond.CheckState = System.Windows.Forms.CheckState.Unchecked
            End If
            chkThird.Enabled = True
            If TempThird = True Then
                chkThird.CheckState = System.Windows.Forms.CheckState.Checked
            Else
                chkThird.CheckState = System.Windows.Forms.CheckState.Unchecked
            End If
        End If
        BlankTimeFlag = False
        ExecCmdTwilights()
        ViewVisibleBodies()
        Exit Sub
    End Sub

    Public Sub DisplaySunMoon()
        Shape1.Visible = True
        Shape1.Clear()
        If FirstTime <> 0 Then
            Shape1.Text = "Acceptable Sun-Moon fix from " & FTHours & FTMinutes & " To " & LTHours & LTMinutes & vbNewLine
            Shape1.AppendText("Moon from " & Strings.Format(MoonPhaseFirst, "#0") & "% to " & Strings.Format(MoonPhaseLast, "#0") & "% illuminated" & vbNewLine)
        End If
        If FirstTime = 0 Then
            Shape1.Text = "No acceptable Sun-Moon fix this Date, location," & vbNewLine & "azimuth range, and minimum altitude "
        End If
    End Sub

    Public Sub Warning()
        If Not FormSightPlanLoaded Then Exit Sub
        txtTime.Text = DTPlan.Value.Hour.ToString("00") & DTPlan.Value.Minute.ToString("00")

        'If txtTime.Text = "" Then
        'rMsgBox("You must enter a desired ZT for body visibility Or Star Finder Data.", "Entry Error", MessageBoxButtons.OK)
        'txtTime.Focus()
        'Exit Sub
        'End If
        txtWarning.Visible = True


        'Calculate AutoZD
        AutoZD = Int(Lo / 15 + 0.5)

        Time = 60 * Val(VB.Left(txtTime.Text, 2)) + Val(VB.Right(txtTime.Text, 2)) - (AutoZD - ZD) * 60
        If Time < 0 Then Time = Time + 1440
        If Time > 1440 Then Time = Time - 1440
        C32 = 60 * Val(VB.Left(C3(2), 2)) + Val(VB.Right(C3(2), 2)) - (AutoZD - ZD) * 60
        C33 = 60 * Val(VB.Left(C3(3), 2)) + Val(VB.Right(C3(3), 2)) - (AutoZD - ZD) * 60
        C34 = 60 * Val(VB.Left(C3(4), 2)) + Val(VB.Right(C3(4), 2)) - (AutoZD - ZD) * 60
        C35 = 60 * Val(VB.Left(C3(5), 2)) + Val(VB.Right(C3(5), 2)) - (AutoZD - ZD) * 60
        C36 = 60 * Val(VB.Left(C3(6), 2)) + Val(VB.Right(C3(6), 2)) - (AutoZD - ZD) * 60
        C37 = 60 * Val(VB.Left(C3(7), 2)) + Val(VB.Right(C3(7), 2)) - (AutoZD - ZD) * 60
        If C32 > 1440 Then C32 = C32 - 1440
        If C33 > 1440 Then C33 = C33 - 1440
        If C34 > 1440 Then C34 = C34 - 1440
        If C35 < 0 Then C35 = C35 + 1440
        If C36 < 0 Then C36 = C36 + 1440
        If C37 < 0 Then C37 = C37 + 1440
        If Time < C32 Or Time >= C37 Then
            txtWarning.ForeColor = System.Drawing.Color.White
            txtWarning.BackColor = System.Drawing.Color.Black
            txtWarning.Text = "Night" 'Else
        End If
        If Time >= C34 And Time < C35 Then
            txtWarning.ForeColor = System.Drawing.Color.Black
            txtWarning.BackColor = System.Drawing.Color.Yellow
            txtWarning.Text = "Day" 'Else
        End If
        If (Time >= C32 And Time < C34) Or (Time >= C35 And Time < C37) Then
            txtWarning.ForeColor = System.Drawing.Color.White
            txtWarning.BackColor = System.Drawing.Color.Blue
            txtWarning.Text = "Twilight"
        End If

        txtWarning.Refresh()


    End Sub
    Public Function Delta_T() As Boolean
        DecYr = GYear + (GMonth - 0.5) / 12
        If GYear >= 1901 And GYear <= 1920 Then Theta = DecYr - 1900 : DeltaT = -2.79 + 1.494119 * Theta - 0.0598939 * Theta ^ 2 + 0.0061966 * Theta ^ 3 - 0.000197 * Theta ^ 4
        If GYear >= 1921 And GYear <= 1941 Then Theta = DecYr - 1920 : DeltaT = 21.2 + 0.84493 * Theta - 0.0761 * Theta ^ 2 + 0.0020936 * Theta ^ 3
        If GYear >= 1942 And GYear <= 1961 Then Theta = DecYr - 1950 : DeltaT = 29.07 + 0.407 * Theta - (Theta ^ 2) / 233 + (Theta ^ 3) / 2547
        If GYear >= 1962 And GYear <= 1986 Then Theta = DecYr - 1975 : DeltaT = 45.45 + 1.067 * Theta - (Theta ^ 2) / 260 - (Theta ^ 3) / 718
        If GYear >= 1987 And GYear <= 2005 Then Theta = DecYr - 2000 : DeltaT = 63.86 + 0.3345 * Theta - 0.060374 * Theta ^ 2 + 0.0017275 * Theta ^ 3 + 0.000651814 * Theta ^ 4 + 0.00002373599 * Theta ^ 5
        If GYear >= 2006 And GYear <= 2050 Then Theta = DecYr - 2000 : DeltaT = 62.92 + 0.32217 * Theta + 0.005589 * Theta ^ 2       'V5.6.1 could replace 2050 with 2009
        'Next line NOT added in V5.6.1.  For June 1, 2017, predicted DeltaT value 70.2481, measured DeltaT value 68.8033.  With this change predicted value becomes 68.7579
        'If GYear >= 2010 And GYear <= 2099 Then DeltaT = 66.0699 + (DecYr - 2010) * 0.3604 'DeltaT increasing an average of about 0.36 seconds per year since the beginning of 2010 (66.0699)
        If GYear >= 2051 And GYear <= 2099 Then DeltaT = -20 + 32 * ((DecYr - 1820) / 100) ^ 2 - 0.5628 * (2150 - DecYr)        'NOT removed in V5.6.1
        Return True
    End Function
    Private Sub Precession()
        'coming in AR in degrees, DE in degrees
        AR = AR * Pi / 180 'convert to radians
        DE = DE * Pi / 180
        T = (JD - 2451545) / 36525
        Pre1 = 2306.2181 * T + 0.30188 * T * T + 0.017998 * T * T * T : Pre1 = Pre1 * Pi / 648000 'radians (/3600 gives degress, *Pi/180 gives radians)
        Pre2 = 2306.2181 * T + 1.09468 * T * T + 0.018203 * T * T * T : Pre2 = Pre2 * Pi / 648000 'radians (/3600 gives degress, *Pi/180 gives radians)
        Pre3 = 2004.3109 * T - 0.42665 * T * T - 0.041833 * T * T * T : Pre3 = Pre3 * Pi / 648000 'radians (/3600 gives degress, *Pi/180 gives radians)
        A = System.Math.Cos(DE) * System.Math.Sin(AR + Pre1)
        B = System.Math.Cos(Pre3) * System.Math.Cos(DE) * System.Math.Cos(AR + Pre1) - System.Math.Sin(Pre3) * System.Math.Sin(DE)
        C = System.Math.Sin(Pre3) * System.Math.Cos(DE) * System.Math.Cos(AR + Pre1) + System.Math.Cos(Pre3) * System.Math.Sin(DE)
        D = System.Math.Atan(A / B) : If B < 0 Then D = D + Pi
        If D >= 2 * Pi Or D < 0 Then D = D - Int(D / (2 * Pi)) * 2 * Pi
        AR = D + Pre2 'radians
        DE = System.Math.Atan(C / (System.Math.Sqrt(-C * C + 1) + 9.999999E-21)) 'arcsin(C), radians
        'AR = AR * 180 / Pi
        'DE = DE * 180 / Pi

    End Sub
    Public Sub AberrationRADec()
        'Ecc comes from Sun
        PeriLo = 102.93735 + 1.71946 * T + 0.00046 * T * T 'Meeus pi in degrees
        PeriLo = PeriLo * Pi / 180 'in radians
        'Kappa = 20.49552" (/3600) = 0.0056932º
        AberrRA = -0.0056932 * (System.Math.Cos(AR) * System.Math.Cos(LN * Pi / 180) * System.Math.Cos(OETrue * Pi / 180) + System.Math.Sin(AR) * System.Math.Sin(LN * Pi / 180)) / System.Math.Cos(DE) + Ecc * 0.0056932 * (System.Math.Cos(AR) * System.Math.Cos(PeriLo) * System.Math.Cos(OETrue * Pi / 180) + System.Math.Sin(AR) * System.Math.Sin(PeriLo)) / System.Math.Cos(DE) 'degrees
        AberrDec = -0.0056932 * (System.Math.Cos(LN * Pi / 180) * System.Math.Cos(OETrue * Pi / 180) * (System.Math.Tan(OETrue * Pi / 180) * System.Math.Cos(DE) - System.Math.Sin(AR) * System.Math.Sin(DE)) + System.Math.Cos(AR) * System.Math.Sin(DE) * System.Math.Sin(LN * Pi / 180)) + Ecc * 0.0056932 * (System.Math.Cos(PeriLo) * System.Math.Cos(OETrue * Pi / 180) * (System.Math.Tan(OETrue * Pi / 180) * System.Math.Cos(DE) - System.Math.Sin(AR) * System.Math.Sin(DE)) + System.Math.Cos(AR) * System.Math.Sin(DE) * System.Math.Sin(PeriLo)) 'degrees
    End Sub
    Public Sub AberrationLB()
        'Ecc comes from Sun
        PeriLo = 102.93735 + 1.71946 * T + 0.00046 * T * T 'Meeus pi in degrees
        PeriLo = PeriLo * Pi / 180 'in radians
        'Kappa = 20.49552" (/3600) = 0.0056932º
        AberrL = (-0.0056932 * System.Math.Cos(LN * Pi / 180 - L1) + 0.0056932 * Ecc * System.Math.Cos(PeriLo - L1)) / System.Math.Cos(B) 'degrees
        AberrB = -0.0056932 * System.Math.Sin(B) * (System.Math.Sin(LN * Pi / 180 - L1) - Ecc * System.Math.Sin(PeriLo - L1)) 'degrees
    End Sub

    Public Sub BestBodies()
        If Not FormSightPlanLoaded Then Exit Sub
        'IsMouseDown = True
        Me.Activate()
        SweepStep2 = SweepStep2 + WhichWay
        SweepStep3 = SweepStep3 + WhichWay
        BlankTimeFlag = False
        'ExecCmdTwilights()
        DisplayView()
        System.Windows.Forms.Application.DoEvents()
        Do While IsMouseDown = True
            SweepStep2 = SweepStep2 + WhichWay
            SweepStep3 = SweepStep3 + WhichWay
            BlankTimeFlag = False
            DisplayView()
            Me.Show()
            System.Windows.Forms.Application.DoEvents()
            SkyPicBx.Focus()
            System.Threading.Thread.Sleep(100)
        Loop
        Exit Sub
    End Sub

    Private Sub SelectAllText(ByRef TB As System.Windows.Forms.TextBox)
        TB.SelectionStart = 0
        TB.SelectionLength = Len(TB.Text)
    End Sub
    Public Sub ScaleFormSightPlanVar(SZ As SizeF)
        Me.Scale(SZ)
    End Sub
    Public Sub SetTxtBxUlineOn(ByRef TB As System.Windows.Forms.RichTextBox)
        TB.SelectionFont = New Font(TB.Font, Drawing.FontStyle.Underline)
    End Sub
    Public Sub SetTxtBxBoldOn(ByRef TB As System.Windows.Forms.RichTextBox)
        TB.SelectionFont = New Font(TB.Font, Drawing.FontStyle.Bold)
    End Sub
    Public Sub SetTxtBxtoReg(ByRef TB As System.Windows.Forms.RichTextBox)
        TB.SelectionFont = New Font(TB.Font, Drawing.FontStyle.Regular)
    End Sub
    Public Sub RecyclePlan1Jpg()
        'Dim NowTimeStr As String = Now.ToLongTimeString.Replace(":", "").Replace(" ", "").Replace("-", "").Replace("/", "").Trim
        Dim NowTimeStr As String = Now.ToString("HHmmssff")
        Randomize()
        Dim RandomInt As Single = Rnd().ToString("0000")
        BMFname = "./Graphics/PlanForm" & NowTimeStr & RandomInt.ToString.Replace(".", "") + ".jpg"
        Exit Sub
    End Sub
    Public Sub CleanOutOldFiles()
        On Error GoTo ErrorExit
        For Each foundFile As String In My.Computer.FileSystem.GetFiles(
            My.Computer.FileSystem.CurrentDirectory & "/Graphics",
            Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, "PlanForm*.jpg")
            My.Computer.FileSystem.DeleteFile(foundFile)
        Next
ErrorExit:
        Exit Sub
    End Sub
    Private Sub ErrorMsgBox(ByVal ErrMsg As String, ByVal TitleStr As String, ByVal MsgBtn As MessageBoxButtons)
        System.Windows.Forms.MessageBox.Show(ErrMsg, TitleStr, MsgBtn,
                                                System.Windows.Forms.MessageBoxIcon.Error,
                                                System.Windows.Forms.MessageBoxDefaultButton.Button1,
                                                System.Windows.Forms.MessageBoxOptions.DefaultDesktopOnly)
        Exit Sub
    End Sub

    Public Sub SendMsgBx(ByVal SendStr As String, ByVal IconType As MessageBoxIcon)
        ' this subroutine is required because issuing a raw SendMsgBx call also trigger a Paint event for graphic box on form which cannot be handled properly in error conditions
        IssuingSendMsgBx = True
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

    Private Sub DisplaySunRiseSunSet()
        Dim SRSSGraphic As Graphics
        Dim SRSSFileName As String = "./Graphics/SunRiseSunSet.jpg"
        Dim bmsrss As Bitmap
        Dim XTD1, YTD1 As Short
        Dim XTD2, YTD2 As Short
        Dim TwoPi, i As Double
        'FormSRF.Font.Name = "MS Sans Serif"
        TwoPi = 8 * System.Math.Atan(1)
        SunRiseSet.Enabled = True
        SunRiseSet.Visible = True
        'set up fresh / new bitmap and graphics drawwing object for diagram and later additions
        Dim DrawWidth As Double = (SunRiseSet.Height / 2) - 20
        bmsrss = New Bitmap(SunRiseSet.Width, SunRiseSet.Height)
        SRSSGraphic = Graphics.FromImage(bmsrss)
        SRSSGraphic.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        SRSSGraphic.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAliasGridFit
        SRSSGraphic.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
        SRSSGraphic.TranslateTransform(SunRiseSet.Width / 2, SunRiseSet.Height / 2)
        Dim DPen As Pen = New Pen(Color.Black, 1)
        DPen.DashStyle = Drawing2D.DashStyle.Solid
        Dim ptA As Point = New Point
        Dim ptB As Point = New Point
        ' standard code intro to any of the 4 major processing routines for this form.
        CheckDate()
        Warning()
        StarMagnitudes()
        Calculate()
        ' Now display the sunrise / sunset data 
        Dim CircleRadii As Integer = DrawWidth + 5
        SRSSGraphic.DrawEllipse(DPen, -(CircleRadii), -(CircleRadii), 2 * CircleRadii, 2 * CircleRadii)
        SRSSGraphic.FillEllipse(Brushes.LightGoldenrodYellow, -(CircleRadii), -(CircleRadii), 2 * CircleRadii, 2 * CircleRadii)
        Dim Hr As Integer = 18
        Dim StrFormat As StringFormat = New StringFormat()
        StrFormat.Alignment = StringAlignment.Center
        StrFormat.LineAlignment = StringAlignment.Center

        For i = 0 To TwoPi Step TwoPi / 24
            XTD1 = (DrawWidth - 5) * System.Math.Cos(i)
            YTD1 = (DrawWidth - 5) * System.Math.Sin(i)
            XTD2 = (DrawWidth + 5) * System.Math.Cos(i)
            YTD2 = (DrawWidth + 5) * System.Math.Sin(i)
            SRSSGraphic.DrawLine(DPen, XTD1, YTD1, XTD2, YTD2)
            XTD1 = (DrawWidth - 10) * System.Math.Cos(i)
            YTD1 = (DrawWidth - 10) * System.Math.Sin(i)
            SRSSGraphic.DrawString(Hr.ToString("00") & "Hr", New Font("Arial", 8.25, Drawing.FontStyle.Bold), Brushes.Black, XTD1, YTD1, StrFormat)
            Hr += 1
            If Hr > 24 Then
                Hr -= 24
            End If
        Next i

        For i = 0 To TwoPi Step TwoPi / 96
            XTD1 = (DrawWidth + 2) * System.Math.Cos(i) '600
            YTD1 = (DrawWidth + 2) * System.Math.Sin(i) '600
            XTD2 = (DrawWidth + 5) * System.Math.Cos(i)
            YTD2 = (DrawWidth + 5) * System.Math.Sin(i)
            SRSSGraphic.DrawLine(DPen, XTD1, YTD1, XTD2, YTD2)
        Next i
        SRSSGraphic.DrawLine(DPen, 0, 0, 0, -(CircleRadii))
        SRSSGraphic.DrawString("Noon", New Font("Arial", 8.25, Drawing.FontStyle.Bold), Brushes.Black, 0, -CircleRadii - 8.25, StrFormat)

        SRSSGraphic.DrawLine(DPen, 0, 0, 0, (CircleRadii))
        SRSSGraphic.DrawString("MidNight", New Font("Arial", 8.25, Drawing.FontStyle.Bold), Brushes.Black, 0, CircleRadii + 8.25, StrFormat)

        SRSSGraphic.DrawLine(DPen, 0, 0, -(CircleRadii), 0)
        SRSSGraphic.DrawString("6am", New Font("Arial", 8.25, Drawing.FontStyle.Bold), Brushes.Black, -CircleRadii - 25, 0, StrFormat)

        SRSSGraphic.DrawLine(DPen, 0, 0, (CircleRadii), 0)
        SRSSGraphic.DrawString("6pm", New Font("Arial", 8.25, Drawing.FontStyle.Bold), Brushes.Black, CircleRadii + 25, 0, StrFormat)

        Select Case cboLineWidth.SelectedIndex
            Case 0
                DPen.Width = 1 ' Thin
            Case 1
                DPen.Width = 2 ' Regular
            Case 2
                DPen.Width = 3 ' Large
            Case 3
                DPen.Width = 4 ' X-Large
            Case Else
                DPen.Width = 1 ' Oops
        End Select

        DPen.EndCap = Drawing2D.LineCap.ArrowAnchor
        DPen.StartCap = Drawing2D.LineCap.RoundAnchor
        Dim TStr As String = ""
        Dim Angle As Double = 0
        Dim Dashes4 As String = "----"

        If C3(1) <> Dashes4 Then
            Angle = CTimetoAngle(C3(1))
            XTD1 = (DrawWidth) * System.Math.Cos(Angle)
            YTD1 = (DrawWidth) * System.Math.Sin(Angle)
            DPen.Color = Color.Navy
            SRSSGraphic.DrawLine(DPen, 0, 0, XTD1, YTD1)
            XTD1 = 1.1 * (DrawWidth) * System.Math.Cos(Angle)
            YTD1 = 1.1 * (DrawWidth) * System.Math.Sin(Angle)
            TStr = "AM Astro Twilight: " & C3(1)
            SRSSGraphic.DrawString(TStr, New Font("Arial", 8.25, Drawing.FontStyle.Bold), Brushes.Navy, XTD1 - TStr.Length() * 5, YTD1)
        End If

        If C3(2) <> Dashes4 Then
            Angle = CTimetoAngle(C3(2))
            XTD1 = (DrawWidth) * System.Math.Cos(Angle)
            YTD1 = (DrawWidth) * System.Math.Sin(Angle)
            DPen.Color = Color.DarkViolet
            SRSSGraphic.DrawLine(DPen, 0, 0, XTD1, YTD1)
            XTD1 = 1.1 * (DrawWidth) * System.Math.Cos(Angle)
            YTD1 = 1.1 * (DrawWidth) * System.Math.Sin(Angle)
            TStr = "AM Nautical Twilight: " & C3(2)
            SRSSGraphic.DrawString(TStr, New Font("Arial", 8.25, Drawing.FontStyle.Bold), Brushes.DarkViolet, XTD1 - TStr.Length() * 5, YTD1)
        End If

        If C3(3) <> Dashes4 Then
            Angle = CTimetoAngle(C3(3))
            XTD1 = (DrawWidth) * System.Math.Cos(Angle)
            YTD1 = (DrawWidth) * System.Math.Sin(Angle)
            DPen.Color = Color.BlueViolet
            SRSSGraphic.DrawLine(DPen, 0, 0, XTD1, YTD1)
            XTD1 = 1.1 * (DrawWidth) * System.Math.Cos(Angle)
            YTD1 = 1.1 * (DrawWidth) * System.Math.Sin(Angle)
            TStr = "AM Civil Twilight: " & C3(3)
            SRSSGraphic.DrawString(TStr, New Font("Arial", 8.25, Drawing.FontStyle.Bold), Brushes.BlueViolet, XTD1 - TStr.Length() * 5, YTD1)
        End If

        Dim AMSunRise As Double = 0
        Dim PMSunSet As Double = 0

        If C3(4) <> Dashes4 Then
            Angle = CTimetoAngle(C3(4))
            XTD1 = (DrawWidth) * System.Math.Cos(Angle)
            YTD1 = (DrawWidth) * System.Math.Sin(Angle)
            DPen.Color = Color.Blue
            SRSSGraphic.DrawLine(DPen, 0, 0, XTD1, YTD1)
            XTD1 = 1.1 * (DrawWidth) * System.Math.Cos(Angle)
            YTD1 = 1.1 * (DrawWidth) * System.Math.Sin(Angle)
            TStr = "AM Sunrise: " & C3(4)
            SRSSGraphic.DrawString(TStr, New Font("Arial", 8.25, Drawing.FontStyle.Bold), Brushes.Blue, XTD1 - TStr.Length() * 5, YTD1)
            AMSunRise = Angle
        End If

        If C3(5) <> Dashes4 Then
            Angle = CTimetoAngle(C3(5))
            XTD1 = (DrawWidth) * System.Math.Cos(Angle)
            YTD1 = (DrawWidth) * System.Math.Sin(Angle)
            DPen.Color = Color.Blue
            SRSSGraphic.DrawLine(DPen, 0, 0, XTD1, YTD1)
            XTD1 = 1.1 * (DrawWidth) * System.Math.Cos(Angle)
            YTD1 = 1.1 * (DrawWidth) * System.Math.Sin(Angle)
            SRSSGraphic.DrawString("PM Sunset: " & C3(5), New Font("Arial", 8.25, Drawing.FontStyle.Bold), Brushes.Blue, XTD1, YTD1)
            PMSunSet = Angle
        End If

        If C3(6) <> Dashes4 Then
            Angle = CTimetoAngle(C3(6))
            XTD1 = (DrawWidth) * System.Math.Cos(Angle)
            YTD1 = (DrawWidth) * System.Math.Sin(Angle)
            DPen.Color = Color.BlueViolet
            SRSSGraphic.DrawLine(DPen, 0, 0, XTD1, YTD1)
            XTD1 = 1.1 * (DrawWidth) * System.Math.Cos(Angle)
            YTD1 = 1.1 * (DrawWidth) * System.Math.Sin(Angle)
            SRSSGraphic.DrawString("PM Civil Twilight: " & C3(6), New Font("Arial", 8.25, Drawing.FontStyle.Bold), Brushes.BlueViolet, XTD1, YTD1)
        End If

        If C3(7) <> Dashes4 Then
            Angle = CTimetoAngle(C3(7))
            XTD1 = (DrawWidth) * System.Math.Cos(Angle)
            YTD1 = (DrawWidth) * System.Math.Sin(Angle)
            DPen.Color = Color.DarkViolet
            SRSSGraphic.DrawLine(DPen, 0, 0, XTD1, YTD1)
            XTD1 = 1.1 * (DrawWidth) * System.Math.Cos(Angle)
            YTD1 = 1.1 * (DrawWidth) * System.Math.Sin(Angle)
            SRSSGraphic.DrawString("PM Nautical Twilight: " & C3(7), New Font("Arial", 8.25, Drawing.FontStyle.Bold), Brushes.DarkViolet, XTD1, YTD1)
        End If

        If C3(8) <> Dashes4 Then
            Angle = CTimetoAngle(C3(8))
            XTD1 = (DrawWidth) * System.Math.Cos(Angle)
            YTD1 = (DrawWidth) * System.Math.Sin(Angle)
            DPen.Color = Color.Navy
            SRSSGraphic.DrawLine(DPen, 0, 0, XTD1, YTD1)
            XTD1 = 1.1 * (DrawWidth) * System.Math.Cos(Angle)
            YTD1 = 1.1 * (DrawWidth) * System.Math.Sin(Angle)
            SRSSGraphic.DrawString("PM Astro Twilight: " & C3(8), New Font("Arial", 8.25, Drawing.FontStyle.Bold), Brushes.Navy, XTD1, YTD1)
        End If

        ' Get moonrise and moonset data from text field on form and then parse out the time fields on it
        Dim MoonStr As String = MoonTxtBx.Text.ToString
        Dim MoonRiseFixed As String = "Moonrise at ZT "
        Dim MoonSetFixed As String = "Moonset  at ZT "
        Dim MoonRiseLoc As Integer = MoonStr.IndexOf(MoonRiseFixed)
        Dim MoonSetLoc As Integer = MoonStr.IndexOf(MoonSetFixed)
        Dim MoonRiseAngle As Double = 0
        Dim MoonSetAngle As Double = 0
        Dim MoonRisePt As Point
        Dim MoonSetPt As Point

        ' Now parse out moonrise time and draw it

        If MoonRiseLoc <> -1 Then
            Dim MoonRiseTime As String = MoonStr.Substring(MoonRiseLoc + MoonRiseFixed.Length, 4)
            Angle = CTimetoAngle(MoonRiseTime)
            MoonRiseAngle = Angle
            XTD1 = (DrawWidth) * System.Math.Cos(Angle)
            YTD1 = (DrawWidth) * System.Math.Sin(Angle)
            DPen.Color = Color.Red
            SRSSGraphic.DrawLine(DPen, 0, 0, XTD1, YTD1)
            MoonRisePt = New Point(XTD1, YTD1)
            XTD1 = 1.1 * (DrawWidth) * System.Math.Cos(Angle)
            YTD1 = 1.1 * (DrawWidth) * System.Math.Sin(Angle)
            TStr = "Moonrise at: " & MoonRiseTime
            Dim AngleDeg As Double = Angle * 180 / Pi
            If AngleDeg > 90 And AngleDeg < 270 Then
                SRSSGraphic.DrawString(TStr, New Font("Arial", 8.25, Drawing.FontStyle.Bold), Brushes.Red, XTD1 - TStr.Length() * 5, YTD1)
            Else
                SRSSGraphic.DrawString(TStr, New Font("Arial", 8.25, Drawing.FontStyle.Bold), Brushes.Red, XTD1, YTD1)
            End If
        Else
            SRSSGraphic.DrawString("No MoonRise for this Date & time", New Font("Arial", 8.25, Drawing.FontStyle.Bold), Brushes.Red, -((SunRiseSet.Width / 2) - 40), -((SunRiseSet.Height / 2) - 40))
        End If
        ' now parse out moonset time and draw it
        If MoonSetLoc <> -1 Then
            Dim MoonSetTime As String = MoonStr.Substring(MoonSetLoc + MoonSetFixed.Length, 4)
            Angle = CTimetoAngle(MoonSetTime)
            MoonSetAngle = Angle
            XTD1 = (DrawWidth) * System.Math.Cos(Angle)
            YTD1 = (DrawWidth) * System.Math.Sin(Angle)
            DPen.Color = Color.Red
            SRSSGraphic.DrawLine(DPen, 0, 0, XTD1, YTD1)
            MoonSetPt = New Point(XTD1, YTD1)
            XTD1 = 1.1 * (DrawWidth) * System.Math.Cos(Angle)
            YTD1 = 1.1 * (DrawWidth) * System.Math.Sin(Angle)
            TStr = "Moonset at: " & MoonSetTime
            Dim AngleDeg As Double = Angle * 180 / Pi
            If AngleDeg > 90 And AngleDeg < 270 Then
                SRSSGraphic.DrawString(TStr, New Font("Arial", 8.25, Drawing.FontStyle.Bold), Brushes.Red, XTD1 - TStr.Length() * 5, YTD1)
            Else
                SRSSGraphic.DrawString(TStr, New Font("Arial", 8.25, Drawing.FontStyle.Bold), Brushes.Red, XTD1, YTD1)
            End If
        Else
            SRSSGraphic.DrawString("No MoonSet for this Date & time", New Font("Arial", 8.25, Drawing.FontStyle.Bold), Brushes.Red, -((SunRiseSet.Width / 2) - 40), -((SunRiseSet.Height / 2) - 50))
        End If
        ' draw arc from moonrise to moonset to illustrate when moon is visible
        Dim MRDeg As Integer = MoonRiseAngle * 180 / Pi
        If MRDeg > 360 Then
            MRDeg = MRDeg - 360
        End If
        Dim MSDeg As Integer = MoonSetAngle * 180 / Pi
        If MSDeg > 360 Then
            MSDeg = MSDeg - 360
        End If
        Dim Quad As Double = Pi / 2
        If MoonRiseLoc <> -1 And MoonSetLoc <> -1 Then
            Dim Rect As RectangleF = New RectangleF(-(CircleRadii / 2), -(CircleRadii / 2), CircleRadii, CircleRadii)
            Dim Sweep As Single = 0 '-1 *( Convert.ToSingle(MoonRiseAngle * 180 / Pi) - Convert.ToSingle(MoonSetAngle * 180 / Pi))

            If MRDeg > 270 And MRDeg <= 359 Then
                MRDeg = MRDeg - 360
            End If
            If MSDeg > 270 And MSDeg <= 359 Then
                MSDeg = MSDeg - 360
            End If

            Sweep = 360 - ((MRDeg - MSDeg))
            If Sweep >= 360 Then
                Sweep = System.Math.Abs(360 - Sweep)
            End If

            'If MSDeg < MRDeg Then
            '    If MRDeg > 270 And MRDeg < 360 Then
            '        Sweep = MRDeg - MSDeg
            '    Else
            '        Sweep = -1 * (MRDeg - MSDeg)
            '    End If
            'Else
            '    If MRDeg > 270 And MRDeg < 360 Then
            '        Sweep = MRDeg - MSDeg
            '    Else
            '        Sweep = -1 * ((MRDeg - MSDeg))
            '    End If
            'End If

            DPen.Color = Color.Red
            If Sweep > 0 Then
                Sweep = Sweep - 2
            Else
                Sweep = Sweep + 2
            End If
            SRSSGraphic.DrawArc(DPen, Rect, Convert.ToSingle(MoonRiseAngle * 180 / Pi), Sweep)
            Dim WrtPt As Point
            If MRDeg >= 0 And MRDeg < 90 Then
                WrtPt = New Point(-(CircleRadii / 3), (CircleRadii / 3))
                Quad = Pi / 2
            ElseIf MRDeg >= 90 And MRDeg < 180 Then
                WrtPt = New Point(-(CircleRadii / 3), -(CircleRadii / 3))
                Quad = Pi
            Else
                WrtPt = New Point((CircleRadii / 3), (CircleRadii / 3))
                Quad = 3 * Pi / 2
            End If
            SRSSGraphic.DrawString("Moon is Visible", New Font("Arial", 8.25, Drawing.FontStyle.Bold), Brushes.Red, WrtPt.X, WrtPt.Y)
        End If
        Dim LanAngle As Double = 0
        If chkNoonSightLAN.Checked = True Then
            Dim TmpTime As String()
            ReDim TmpTime(3)
            TmpTime = txtLAN.Text.ToString.Split(":")
            Dim TS As TimeSpan = New TimeSpan(Convert.ToInt32(TmpTime(0)), Convert.ToInt32(TmpTime(1)), Convert.ToInt32(TmpTime(2)))
            If TS.Seconds >= 30 Then
                TS = TS.Add(New TimeSpan(0, 1, 0))
            End If
            Dim TSStr As String = TS.ToString("hhmm")
            Angle = CTimetoAngle(TSStr)
            XTD1 = (DrawWidth) * System.Math.Cos(Angle)
            YTD1 = (DrawWidth) * System.Math.Sin(Angle)
            DPen.Color = Color.Blue
            SRSSGraphic.DrawLine(DPen, 0, 0, XTD1, YTD1)
            LanAngle = Angle
            XTD1 = 1.1 * (DrawWidth) * System.Math.Cos(Angle)
            YTD1 = 1.1 * (DrawWidth) * System.Math.Sin(Angle)
            TStr = "LAN Time: " & TSStr
            Dim AngleDeg As Double = Angle * 180 / Pi
            If AngleDeg > 90 And AngleDeg < 270 Then
                SRSSGraphic.DrawString(TStr, New Font("Arial", 8.25, Drawing.FontStyle.Bold), Brushes.Blue, XTD1 - TStr.Length() * 5, YTD1)
            Else
                SRSSGraphic.DrawString(TStr, New Font("Arial", 8.25, Drawing.FontStyle.Bold), Brushes.Blue, XTD1, YTD1)
            End If
        End If

        Dim SRDeg As Double = AMSunRise * 180 / Pi
        If SRDeg > 360 Then
            SRDeg = SRDeg - 360
        End If
        Dim SSDeg As Double = PMSunSet * 180 / Pi
        If MSDeg > 360 Then
            MSDeg = MSDeg - 360
        End If
        DPen.EndCap = Drawing2D.LineCap.ArrowAnchor
        DPen.StartCap = Drawing2D.LineCap.RoundAnchor
        Dim Rect1 As RectangleF = New RectangleF(-(CircleRadii / 3), -(CircleRadii / 3), CircleRadii * (2 / 3), CircleRadii * (2 / 3))
        Dim Sweep1 As Single = Convert.ToSingle(PMSunSet * 180 / Pi) - Convert.ToSingle(AMSunRise * 180 / Pi)
        If SSDeg < SRDeg Then
            Sweep1 = -1 * (360 - (SRDeg - SSDeg))
        Else
            Sweep1 = -1 * (SRDeg - SSDeg)
        End If
        '    Sweep1 = Convert.ToSingle(360 - (AMSunRise * 180 / Pi)) + Convert.ToSingle(PMSunSet * 180 / Pi)
        'Else
        '    Sweep1 = Convert.ToSingle(PMSunSet * 180 / Pi) - Convert.ToSingle(AMSunRise * 180 / Pi)
        'End If
        DPen.Color = Color.Blue
        If Sweep1 > 0 Then
            Sweep1 = Sweep1 - 3
        Else
            Sweep1 = Sweep1 + 3
        End If
        SRSSGraphic.DrawArc(DPen, Rect1, Convert.ToSingle(AMSunRise * 180 / Pi), Sweep1)

        Dim WrtPt1 As Point = New Point(-35, -(CircleRadii / 3) + 15)
        SRSSGraphic.DrawString("DayLight Hours", New Font("Arial", 8.25, Drawing.FontStyle.Bold), Brushes.Blue, WrtPt1.X, WrtPt1.Y)

        ' draw mini-sun on line in yellow rimmed in blue to illustrate where sun rises and sets
        If chkNoonSightLAN.Checked = True Then
            DPen.Color = Color.Blue
            XTD1 = (1 / 3) * (DrawWidth) * System.Math.Cos(LanAngle)
            YTD1 = (1 / 3) * (DrawWidth) * System.Math.Sin(LanAngle)
            Dim SunRect As Rectangle = New Rectangle(XTD1 - 4, YTD1 - 4, 8, 8)
            SRSSGraphic.DrawEllipse(DPen, SunRect)
            SRSSGraphic.FillEllipse(Brushes.Yellow, SunRect)
        End If
        ' draw mini-sun on line in yellow rimmed in blue to illustrate where sun rises and sets
        DPen.Color = Color.Blue
        XTD1 = (1 / 3) * (DrawWidth) * System.Math.Cos(AMSunRise)
        YTD1 = (1 / 3) * (DrawWidth) * System.Math.Sin(AMSunRise)
        Dim SunRect1 As Rectangle = New Rectangle(XTD1 - 4, YTD1 - 4, 8, 8)
        SRSSGraphic.DrawEllipse(DPen, SunRect1)
        SRSSGraphic.FillEllipse(Brushes.Yellow, SunRect1)
        ' draw mini-sun on line in yellow rimmed in blue to illustrate where sun rises and sets
        DPen.Color = Color.Blue
        XTD1 = (1 / 3) * (DrawWidth) * System.Math.Cos(PMSunSet)
        YTD1 = (1 / 3) * (DrawWidth) * System.Math.Sin(PMSunSet)
        Dim SunRect2 As Rectangle = New Rectangle(XTD1 - 4, YTD1 - 4, 8, 8)
        SRSSGraphic.DrawEllipse(DPen, SunRect2)
        SRSSGraphic.FillEllipse(Brushes.Yellow, SunRect2)

        ' draw mini-moon on line in yellow rimmed in blue to illustrate where moon rises and sets
        'DPen.Color = Color.Red
        'XTD1 = (1 / 2) * (CircleRadii) * System.Math.Cos(Quad)
        'YTD1 = (1 / 2) * (CircleRadii) * System.Math.Sin(Quad)
        'Dim moonRect As Rectangle = New Rectangle(XTD1 - 4, YTD1 - 4, 8, 8)
        'SRSSGraphic.DrawEllipse(DPen, moonRect)
        'SRSSGraphic.FillEllipse(Brushes.Cyan, moonRect)
        ' draw mini-moon on line in yellow rimmed in blue to illustrate where moon rises and sets
        DPen.Color = Color.Red
        XTD1 = (1 / 2) * (CircleRadii) * System.Math.Cos(MoonRiseAngle)
        YTD1 = (1 / 2) * (CircleRadii) * System.Math.Sin(MoonRiseAngle)
        Dim moonRect1 As Rectangle = New Rectangle(XTD1 - 4, YTD1 - 4, 8, 8)
        SRSSGraphic.DrawEllipse(DPen, moonRect1)
        SRSSGraphic.FillEllipse(Brushes.Cyan, moonRect1)
        ' draw mini-moon on line in yellow rimmed in blue to illustrate where moon rises and sets
        DPen.Color = Color.Red
        XTD1 = (1 / 2) * (CircleRadii) * System.Math.Cos(MoonSetAngle)
        YTD1 = (1 / 2) * (CircleRadii) * System.Math.Sin(MoonSetAngle)
        Dim moonRect2 As Rectangle = New Rectangle(XTD1 - 4, YTD1 - 4, 8, 8)
        SRSSGraphic.DrawEllipse(DPen, moonRect2)
        SRSSGraphic.FillEllipse(Brushes.Cyan, moonRect2)

        If FileIO.FileSystem.FileExists(SRSSFileName) Then
            FileIO.FileSystem.DeleteFile(SRSSFileName)
        End If
        bmsrss.Save(SRSSFileName)
        SunRiseSet.ImageLocation = SRSSFileName
        SunRiseSet.Visible = True
        SunRiseSet.Refresh()
        bmsrss.Dispose()

        Exit Sub
    End Sub
    Public Function SetPrintTextPt(ByVal Ptin As Point, ByVal CxIn As Integer, ByVal CyIn As Integer) As Point
        Dim PtOut As Point = New Point(0, 0)
        If Ptin.X >= 0 Then
            If Ptin.Y >= 0 Then
                PtOut.X = Ptin.X + CxIn / 2
                PtOut.Y = Ptin.Y + CyIn / 2
            Else
                PtOut.X = Ptin.X + CxIn / 2
                PtOut.Y = Ptin.Y - CyIn
            End If
        Else
            If Ptin.Y >= 0 Then
                PtOut.X = Ptin.X - CxIn
                PtOut.Y = Ptin.Y + CyIn / 2
            Else
                PtOut.X = Ptin.X - CxIn
                PtOut.Y = Ptin.Y - CyIn
            End If
        End If

        Return PtOut
    End Function
    Private Function CTimetoAngle(ByVal StrIn As String) As Double
        Dim TwoPi As Double = 8 * System.Math.Atan(1)
        Dim HrIn As Double = Convert.ToDouble(StrIn.Substring(0, 2))
        Dim MinIn As Double = Convert.ToDouble(StrIn.Substring(2, 2))
        Dim Time As Double = HrIn + MinIn / 60.0
        Dim TimeRad As Double = Time * TwoPi / 24 + (90 * Pi / 180)
        Return TimeRad
    End Function
    Private Sub GetLANtime()
        ' first check that Lat and Long degrees / minutes are entered
        If txtLDeg.Text = "" Or txtLMin.Text = "" Or txtLoDeg.Text = "" Or txtLoMin.Text = "" Then
            SendMsgBx("Lat or Long Degrees or Minutes Are Missing - Must Enter all values to access LAN from NoonSight", MessageBoxIcon.Error)
            chkNoonSightLAN.CheckState = CheckState.Unchecked
            Exit Sub
        End If
        ' if NoonSight FormNoonSight is already open then exec clear button click to clear out form
        If System.Windows.Forms.Application.OpenForms().OfType(Of FormNoonSight).Any Then
            FormNoonSight.ClearScrBtn.PerformClick()
        End If
        FormNoonSight.Show()
        FormNoonSight.DTNoonSight.Value = Me.DTPlan.Value
        FormNoonSight.txtDRLDeg.Text = Me.txtLDeg.Text
        FormNoonSight.txtDRLMin.Text = Me.txtLMin.Text
        FormNoonSight.cboDRL.SelectedIndex = Me.cboL.SelectedIndex
        FormNoonSight.txtLoDeg.Text = Me.txtLoDeg.Text
        FormNoonSight.txtLoMin.Text = Me.txtLoMin.Text
        FormNoonSight.cboLo.SelectedIndex = Me.cboLo.SelectedIndex
        If Me.chkDST.Checked = True Then
            FormNoonSight.chkDST.Checked = True
        Else
            FormNoonSight.chkDST.Checked = False
        End If

        FormNoonSight.cmdLAN.PerformClick()
        ' sleep this program / thread for 2 seconds
        Thread.Sleep(500)

        Me.txtLAN.Text = FormNoonSight.txtTime.Text
        FormNoonSight.Refresh()

        'FormNoonSight.Close()
        Me.Show()
        Exit Sub
    End Sub
    Private Sub btnAdd1Month_Click(sender As Object, e As EventArgs) Handles btnAdd1Month.Click
        If Not FormSightPlanLoaded Then Exit Sub
        DTPlan.Value = DTPlan.Value.AddMonths(+1)
        cmdTwilights.PerformClick()
    End Sub

    Private Sub btnAdd1Year_Click(sender As Object, e As EventArgs) Handles btnAdd1Year.Click
        If Not FormSightPlanLoaded Then Exit Sub
        DTPlan.Value = DTPlan.Value.AddYears(+1)
        cmdTwilights.PerformClick()
    End Sub

    Private Sub btnSub30Min_Click(sender As Object, e As EventArgs) Handles btnSub30Min.Click
        If Not FormSightPlanLoaded Then Exit Sub
        DTPlan.Value = DTPlan.Value.AddMinutes(-30)
        cmdTwilights.PerformClick()
    End Sub

    Private Sub btnSub1Hour_Click(sender As Object, e As EventArgs) Handles btnSub1Hour.Click
        If Not FormSightPlanLoaded Then Exit Sub
        DTPlan.Value = DTPlan.Value.AddHours(-1)
        cmdTwilights.PerformClick()
    End Sub

    Private Sub btnSub1Day_Click(sender As Object, e As EventArgs) Handles btnSub1Day.Click
        DTPlan.Value = DTPlan.Value.AddDays(-1)
        cmdTwilights.PerformClick()
    End Sub

    Private Sub btnSub1Week_Click(sender As Object, e As EventArgs) Handles btnSub1Week.Click
        If Not FormSightPlanLoaded Then Exit Sub
        DTPlan.Value = DTPlan.Value.AddDays(-7)
        cmdTwilights.PerformClick()
    End Sub

    Private Sub btnSub1Month_Click(sender As Object, e As EventArgs) Handles btnSub1Month.Click
        If Not FormSightPlanLoaded Then Exit Sub
        DTPlan.Value = DTPlan.Value.AddMonths(-1)
        cmdTwilights.PerformClick()
    End Sub

    Private Sub btnSub1Year_Click(sender As Object, e As EventArgs) Handles btnSub1Year.Click
        If Not FormSightPlanLoaded Then Exit Sub
        DTPlan.Value = DTPlan.Value.AddYears(-1)
        cmdTwilights.PerformClick()
    End Sub

    Private Sub btnAdd1Week_Click(sender As Object, e As EventArgs) Handles btnAdd1Week.Click
        If Not FormSightPlanLoaded Then Exit Sub
        DTPlan.Value = DTPlan.Value.AddDays(+7)
        cmdTwilights.PerformClick()
    End Sub

    Private Sub btnAdd1Day_Click(sender As Object, e As EventArgs) Handles btnAdd1Day.Click
        If Not FormSightPlanLoaded Then Exit Sub
        DTPlan.Value = DTPlan.Value.AddDays(+1)
        cmdTwilights.PerformClick()
    End Sub

    Private Sub btnAdd1Hour_Click(sender As Object, e As EventArgs) Handles btnAdd1Hour.Click
        If Not FormSightPlanLoaded Then Exit Sub
        DTPlan.Value = DTPlan.Value.AddHours(+1)
        cmdTwilights.PerformClick()
    End Sub

    Private Sub btnAdd30Min_Click(sender As Object, e As EventArgs) Handles btnAdd30Min.Click
        If Not FormSightPlanLoaded Then Exit Sub
        DTPlan.Value = DTPlan.Value.AddMinutes(+30)
        cmdTwilights.PerformClick()
    End Sub

    Private Sub btnResetDTtoNow_Click(sender As Object, e As EventArgs) Handles btnResetDTtoNow.Click
        DTPlan.Value = DateTime.Now
        cmdTwilights.PerformClick()
    End Sub


End Class