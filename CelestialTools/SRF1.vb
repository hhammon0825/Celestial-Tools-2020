'sighttxtOption 'Strict Off
'Option Explicit On
'Imports VB = Microsoft.VisualBasic
Imports System.Diagnostics.Eventing.Reader
Imports System.Diagnostics.Tracing
Imports System.IO

Friend Class FormSRF
    Inherits System.Windows.Forms.Form
    Public InvokedbySightLog As Boolean = False
    Public SightZoneDatetime As DateTime
    Public Lat, ZN, Hc, LHA, TotDE As Double
    Public FlagMD, FlagSRFLoCNASR As Boolean
    Public EstLoDeg, EstLDeg, EstL, DecimalDate, EstLo, EstLMin, EstLoMin As Double
    Public DecDegrees As Short
    Public DecMinutes As Double
    Public Pressure, HEinFeet, HE, Temperature, DipShortDist As Double
    Public hsinMinutes, ZD, Lo, ICinMinutes, hainMinutes As Double
    Public MonthDays, DateOfSight, SignZD, fnumeral, MonthList As String
    Public GDayOfYear, GMonth As Short
    Public RA(57), Dec(57) As Double
    Public PMRA(57), PMDec(57) As Double
    Public PlusCount, i As Short
    Public DeltaT As Double
    Public DecYr, Theta As Single 'Tdelta As Double, Theta As Double
    Public E, L0, PM, LP, P0, DecLOC As Double
    Public dHP, h3, H2, DSD, h4 As Double ',h4UL As Double, h4LL As Double,havg As Double
    Public AR, Pi, SH, DE As Double
    Public BN As Integer
    Public BNType As String
    Public BNBodyName As String
    Public DI, EA, NO, OE, NU, RN, AL As Double
    Public GHAAriesMin, GHAAries, GHAAriesHour As Double
    Public GHAAriesDeg As Short
    Public TotGHA, GHA, GHAMin, TotGHAMin As Double
    Public SaveGHA As Double
    Public GHADeg, TotGHADeg As Short
    Public LHADeg As Short
    Public LHAMin As Double
    Public RstdTP, Main_Corr, Rstd, PX, GHAHour, GHAMinSec, TX, Raddl, Addl, RstdA2 As Double
    Public BackSight As Boolean
    Public r, HP, PA, HPA As Double
    Public GHAHourDeg1, GHAHourDeg2 As Short
    Public GHAHourMin1, GHAHourMin2 As Double ', GHAMinSecDeg As Integer, GHAMinSecMin As Double
    Public y, x, S As Double
    Public HG As Double
    Public MA, TN, NL, M As Double
    Public NY As Double
    Public B, T, A, C, MS As Double
    Public LN, HoinMinutes As Double
    Public ZTinSeconds As Integer
    Public ZTSeconds, ZTHours, ZTMinutes, WEinSeconds As Short
    Public GHour As Short
    Public WTinSeconds, GMinute, GSecond, ZTTemp As Integer
    Public LocalYear, GYear, GDay, GYearJ, MonthNumber As Short
    Public MonthatG As String
    Public Corr1, Corr1Min As Double
    Public Corr1Deg, DayNumber As Short
    Public ZDinSeconds As Integer
    Public HoDeg, Corr2Min, HoMin, D As Double
    Public HD As String ', Hc As Double
    Public HcDeg As Short
    Public HsMin, HcMin, ICMin As Double
    Public L8, L6, L4, L2, L1, L3, L5, L7, Z As Double
    Public haDeg As Short
    Public SHdeg, haMin, SHmin As Double
    Public UTinSeconds As Integer
    Public PC, LR, XM, PCmin As Double
    Public XD, PCdeg As Short
    Public PD2, Aug As Double
    Public PL As String
    ' fix data index variables
    Public IU As Integer = 0
    Public IJ As Integer = 0
    Public II As Integer = 0
    Public IV, IW As Short
    Public THour1, DecimalDateHour1, DecimalDateHour2, THour2 As Double
    Public PCorr, Pola0min, Pola2, Pola0, Pola1, Pola0deg, LbyPol, LforPol As Double
    Public Ldiff, ldiffMin As Double
    Public ldiffDeg As Short
    Public LHAPol, TotGHAPol, TotGHAPolMin, LHAPolMin As Double
    Public TotGHAPolDeg, LHAPolDeg As Short
    Public MeanSHAPol, MeanDecPol As Double
    Public MonthPolaris As Short
    Public LeapYear, GLeapYear As Boolean
    Public DayG(12) As Short
    Public EqTinSeconds As Integer
    Public EqTminutes, EqTseconds As Single
    Public DateError As Boolean
    Public HourChange, vvalue As Double
    Public vcorr, k, GHAIncrement, GHAIncrementMin As Double
    Public GHAIncrementDeg As Short
    Public dvalue, DE1, DE2, dcorr As Double
    Public Signdvalue, SignHourChange As Short
    Public Lendcorr, TotDecDegrees, Lenvcorr, LenCorr2Min As Short
    Public TotDecMinutes As Double
    Public Intercept, GHAHour1, GHAHour2, L As Double
    Public AberrL, Ecc, PeriLo, AberrB As Double
    Public Pre2, JDHour2, JDHour, JD, JDHour1, Pre1, Pre3 As Double
    Public AberrRA, NutRA, NutDec, AberrDec As Double
    Public OETrue, Tfull As Double
    Public MSinA(59), MMprimeA(59), MDA(59), MMA(59), MFA(59), MCosA(59) As Double
    Public MFB(59), MMB(59), MDB(59), MMprimeB(59), MSinB(59) As Double
    Public A2, MF, MM, MLprime, MD, MMprime, A1, A3 As Double
    Public r0, KB, Delta, SigmaR, SigmaL, SigmaB, KA, B0, Tau As Double
    Public NutF, NutM, NutD, NutMprime, NutOmega As Double
    Public NCos(62), NSin(62), NF(62), NM(62), ND(62), NMprime(62), NOmega(62), NSinT(62), NCosT(62) As Double
    Public TFK5, DecDegrees2, DecMinutes2, Lprime As Double ', L0Sun As Double
    Public LMin, LoMin As String
    Public SunHourChange, SunGHACorr As Double
    Public Corr2forParallax As Double
    Public StarDayNumber As Short
    Public StarNAFlag As Boolean
    Public SHminDisplay, SHdegDisplay, DENA As Double
    Public FlagPlanets As Boolean
    Public DENA1, DENA2 As Double 'vvalueP As Double, dvalueP As Double, SigndvalueP As Integer

    Public bm As Bitmap
    Public BMFname As String = "./Graphics/SRF1.jpg"
    Public SRF1graphic As Graphics
    Public DrawWidth As Integer


    Public DPen As Pen
    Public ptA As Point
    Public ptB As Point
    Dim bMinusSignAlready As Boolean = False

    Private Sub EqTPicBx_Click(sender As Object, e As EventArgs) Handles EqTPicBx.Click
        SRFTimeDiagram.Show()
        SRFTimeDiagram.SetDesktopLocation(5,5) '
        SRFTimeDiagram.BringToFront()

        Exit Sub
    End Sub

    Private Sub btnExpandTimeDiag_Click(sender As Object, e As EventArgs) Handles btnExpandTimeDiag.Click
        SRFTimeDiagram.Show()
        SRFTimeDiagram.SetDesktopLocation(5,5) '
        SRFTimeDiagram.BringToFront()
    End Sub

    Dim FormSRFLoaded As Boolean = False
    'Dim TxtBxFont As Font = New Font("Arial", 8) ', FontStyle.Bold)
    ReadOnly TxtBxFont As Font = New Font("Courier New", 8) ', FontStyle.Bold)
    ReadOnly DGFont As Font = New Font("Arial", 8, FontStyle.Regular)
    Dim DrawBasicTimeDiagram As Boolean = False
    ReadOnly DrawEqTDiagram As Boolean = False
    Dim IssuingSendMsgBx As Boolean = False
    ' fix data fields - set SFixData structure below as it is shared with Form4 / Fix Form
    Public FZH(50) As Double
    Public FZM(50) As Double
    Public FZS(50) As Double
    Public FMI(50) As Double
    Public FZN(50) As Double
    Public FLD(50) As String
    Public FLM(50) As String
    Public FL(50) As Double
    Public FMD(50) As Double
    Public FMM(50) As Double
    Public FM(50) As String
    Public FZT(50) As Double
    Public FUT(50) As Double
    Public FD(50) As String
    Public BF(50) As String
    Public FLA(50) As String
    Public FLo(50) As Double
    Public FGHA(50) As Double
    Public FDec(50) As Double
    Public FHo(50) As Double    'added in V5.6.1
    Public FDTSight(50) As Date
    Public EP(50) As String
    Public PlotOut As CLSForm.PlotEntry
    Public LHAOriginal As Double
    Private Structure SunSDRec
        Public SunSDStart As Date
        Public SunSDEnd As Date
        Public SunSD As Double
        Public DailyChg As Double
    End Structure
    Private SunSDArray As SunSDRec()
    Public Sub Load_SunSDData()
        ReDim SunSDArray(11)
        SunSDArray(0) = New SunSDRec() With {.SunSDStart = New Date(2020, 1, 1), .SunSDEnd = New Date(2020, 2, 5), .SunSD = 16.3, .DailyChg = -0.00278}
        SunSDArray(1) = New SunSDRec() With {.SunSDStart = New Date(2020, 2, 6), .SunSDEnd = New Date(2020, 3, 2), .SunSD = 16.2, .DailyChg = -0.00385}
        SunSDArray(2) = New SunSDRec() With {.SunSDStart = New Date(2020, 3, 3), .SunSDEnd = New Date(2020, 3, 27), .SunSD = 16.1, .DailyChg = -0.00400}
        SunSDArray(3) = New SunSDRec() With {.SunSDStart = New Date(2020, 3, 28), .SunSDEnd = New Date(2020, 4, 17), .SunSD = 16.0, .DailyChg = -0.00476}
        SunSDArray(4) = New SunSDRec() With {.SunSDStart = New Date(2020, 4, 18), .SunSDEnd = New Date(2020, 5, 14), .SunSD = 15.9, .DailyChg = -0.0037}
        SunSDArray(5) = New SunSDRec() With {.SunSDStart = New Date(2020, 5, 15), .SunSDEnd = New Date(2020, 8, 24), .SunSD = 15.8, .DailyChg = +0.00098}
        SunSDArray(6) = New SunSDRec() With {.SunSDStart = New Date(2020, 8, 25), .SunSDEnd = New Date(2020, 9, 20), .SunSD = 15.9, .DailyChg = +0.003704}
        SunSDArray(7) = New SunSDRec() With {.SunSDStart = New Date(2020, 9, 21), .SunSDEnd = New Date(2020, 10, 11), .SunSD = 16.0, .DailyChg = +0.004762}
        SunSDArray(8) = New SunSDRec() With {.SunSDStart = New Date(2020, 10, 12), .SunSDEnd = New Date(2020, 11, 1), .SunSD = 16.1, .DailyChg = +0.004762}
        SunSDArray(9) = New SunSDRec() With {.SunSDStart = New Date(2020, 11, 2), .SunSDEnd = New Date(2020, 12, 1), .SunSD = 16.2, .DailyChg = +0.003333}
        SunSDArray(10) = New SunSDRec() With {.SunSDStart = New Date(2020, 12, 2), .SunSDEnd = New Date(2020, 12, 31), .SunSD = 16.3, .DailyChg = +0.0}
    End Sub
    Public Function GetSunSD(ByVal DateIn As Date) As Double
        For i As Integer = 0 To 11
            If DateIn >= SunSDArray(i).SunSDStart And DateIn <= SunSDArray(i).SunSDEnd Then
                If DateIn = SunSDArray(i).SunSDStart Then
                    Return SunSDArray(i).SunSD
                End If
                If DateIn = SunSDArray(i).SunSDEnd Then
                    Return SunSDArray(i + 1).SunSD
                End If
                Dim TS1 As TimeSpan = DateIn - SunSDArray(i).SunSDStart
                Dim TmpRtn As Double = SunSDArray(i).SunSD + TS1.Days * SunSDArray(i).DailyChg
                Return TmpRtn
            End If
        Next
        If DateIn.Month >= 4 And DateIn.Month <= 9 Then
            Return (15.859)
        Else
            Return (16.1968)
        End If
    End Function
    Public Structure BodyData
        Dim Bname As String
        Dim BIndex As Integer
        Dim BType As String
    End Structure

    Public BNData() As BodyData

    Public Sub LoadBNData()
        ReDim BNData(66)
        BNData.Initialize()
        ' CONVERSION from VB6 to DOTNET NOTE: the value of BIndex on each name below was determined in the original VB6 FRx file drop down list and in interlinked with the RA, DEC, and other table used in the
        ' LHA  / SHA  calculations. Because of the interlinking of the index with the order and use of RA / DEC calc tables these values must be preserved. DO NOT Change this table or 
        ' the Bname and BIndex values on any record. Reference file SRFcbobodyDropDownListBuilder.xlsx in visual studio project folder
        BNData(0) = New BodyData With {.Bname = "Loaded", .BIndex = 100, .BType = "Status"}
        BNData(1) = New BodyData With {.Bname = "Sun L.L.", .BIndex = 64, .BType = "Sun"}
        BNData(2) = New BodyData With {.Bname = "Sun U.L.", .BIndex = 65, .BType = "Sun"}
        BNData(3) = New BodyData With {.Bname = "Moon L.L.", .BIndex = 62, .BType = "Moon"}
        BNData(4) = New BodyData With {.Bname = "Moon U.L.", .BIndex = 63, .BType = "Moon"}
        BNData(5) = New BodyData With {.Bname = "Venus", .BIndex = 58, .BType = "Planets"}
        BNData(6) = New BodyData With {.Bname = "Mars", .BIndex = 59, .BType = "Planets"}
        BNData(7) = New BodyData With {.Bname = "Jupiter", .BIndex = 60, .BType = "Planets"}
        BNData(8) = New BodyData With {.Bname = "Saturn", .BIndex = 61, .BType = "Planets"}
        BNData(9) = New BodyData With {.Bname = "Acamar", .BIndex = 7, .BType = "Stars"}
        BNData(10) = New BodyData With {.Bname = "Achernar", .BIndex = 5, .BType = "Stars"}
        BNData(11) = New BodyData With {.Bname = "Acrux", .BIndex = 30, .BType = "Stars"}
        BNData(12) = New BodyData With {.Bname = "Adhara", .BIndex = 19, .BType = "Stars"}
        BNData(13) = New BodyData With {.Bname = "Aldebaran", .BIndex = 10, .BType = "Stars"}
        BNData(14) = New BodyData With {.Bname = "Alioth", .BIndex = 32, .BType = "Stars"}
        BNData(15) = New BodyData With {.Bname = "Alkaid", .BIndex = 34, .BType = "Stars"}
        BNData(16) = New BodyData With {.Bname = "Al Na'ir", .BIndex = 55, .BType = "Stars"}
        BNData(17) = New BodyData With {.Bname = "Alnilam", .BIndex = 15, .BType = "Stars"}
        BNData(18) = New BodyData With {.Bname = "Alphard", .BIndex = 25, .BType = "Stars"}
        BNData(19) = New BodyData With {.Bname = "Alphecca", .BIndex = 41, .BType = "Stars"}
        BNData(20) = New BodyData With {.Bname = "Alpheratz", .BIndex = 1, .BType = "Stars"}
        BNData(21) = New BodyData With {.Bname = "Altair", .BIndex = 51, .BType = "Stars"}
        BNData(22) = New BodyData With {.Bname = "Ankaa", .BIndex = 2, .BType = "Stars"}
        BNData(23) = New BodyData With {.Bname = "Antares", .BIndex = 42, .BType = "Stars"}
        BNData(24) = New BodyData With {.Bname = "Arcturus", .BIndex = 37, .BType = "Stars"}
        BNData(25) = New BodyData With {.Bname = "Atria", .BIndex = 43, .BType = "Stars"}
        BNData(26) = New BodyData With {.Bname = "Avior", .BIndex = 22, .BType = "Stars"}
        BNData(27) = New BodyData With {.Bname = "Bellatrix", .BIndex = 13, .BType = "Stars"}
        BNData(28) = New BodyData With {.Bname = "Betelgeuse", .BIndex = 16, .BType = "Stars"}
        BNData(29) = New BodyData With {.Bname = "Canopus", .BIndex = 17, .BType = "Stars"}
        BNData(30) = New BodyData With {.Bname = "Capella", .BIndex = 12, .BType = "Stars"}
        BNData(31) = New BodyData With {.Bname = "Deneb", .BIndex = 53, .BType = "Stars"}
        BNData(32) = New BodyData With {.Bname = "Denebola", .BIndex = 28, .BType = "Stars"}
        BNData(33) = New BodyData With {.Bname = "Diphda", .BIndex = 4, .BType = "Stars"}
        BNData(34) = New BodyData With {.Bname = "Dubhe", .BIndex = 27, .BType = "Stars"}
        BNData(35) = New BodyData With {.Bname = "Elnath", .BIndex = 14, .BType = "Stars"}
        BNData(36) = New BodyData With {.Bname = "Eltanin", .BIndex = 47, .BType = "Stars"}
        BNData(37) = New BodyData With {.Bname = "Enif", .BIndex = 54, .BType = "Stars"}
        BNData(38) = New BodyData With {.Bname = "Fomalhaut", .BIndex = 56, .BType = "Stars"}
        BNData(39) = New BodyData With {.Bname = "Gacrux", .BIndex = 31, .BType = "Stars"}
        BNData(40) = New BodyData With {.Bname = "Gienah", .BIndex = 29, .BType = "Stars"}
        BNData(41) = New BodyData With {.Bname = "Hadar", .BIndex = 35, .BType = "Stars"}
        BNData(42) = New BodyData With {.Bname = "Hamal", .BIndex = 6, .BType = "Stars"}
        BNData(43) = New BodyData With {.Bname = "Kaus Australis", .BIndex = 48, .BType = "Stars"}
        BNData(44) = New BodyData With {.Bname = "Kochab", .BIndex = 40, .BType = "Stars"}
        BNData(45) = New BodyData With {.Bname = "Markab", .BIndex = 57, .BType = "Stars"}
        BNData(46) = New BodyData With {.Bname = "Menkar", .BIndex = 8, .BType = "Stars"}
        BNData(47) = New BodyData With {.Bname = "Menkent", .BIndex = 36, .BType = "Stars"}
        BNData(48) = New BodyData With {.Bname = "Miaplacidus", .BIndex = 24, .BType = "Stars"}
        BNData(49) = New BodyData With {.Bname = "Mirfak", .BIndex = 9, .BType = "Stars"}
        BNData(50) = New BodyData With {.Bname = "Nunki", .BIndex = 50, .BType = "Stars"}
        BNData(51) = New BodyData With {.Bname = "Peacock", .BIndex = 52, .BType = "Stars"}
        BNData(52) = New BodyData With {.Bname = "Polaris", .BIndex = 0, .BType = "Stars"}
        BNData(53) = New BodyData With {.Bname = "Pollux", .BIndex = 21, .BType = "Stars"}
        BNData(54) = New BodyData With {.Bname = "Procyon", .BIndex = 20, .BType = "Stars"}
        BNData(55) = New BodyData With {.Bname = "Rasalhague", .BIndex = 46, .BType = "Stars"}
        BNData(56) = New BodyData With {.Bname = "Regulus", .BIndex = 26, .BType = "Stars"}
        BNData(57) = New BodyData With {.Bname = "Rigel", .BIndex = 11, .BType = "Stars"}
        BNData(58) = New BodyData With {.Bname = "Rigil Kentaurus", .BIndex = 38, .BType = "Stars"}
        BNData(59) = New BodyData With {.Bname = "Sabik", .BIndex = 44, .BType = "Stars"}
        BNData(60) = New BodyData With {.Bname = "Schedar", .BIndex = 3, .BType = "Stars"}
        BNData(61) = New BodyData With {.Bname = "Shaula", .BIndex = 45, .BType = "Stars"}
        BNData(62) = New BodyData With {.Bname = "Sirius", .BIndex = 18, .BType = "Stars"}
        BNData(63) = New BodyData With {.Bname = "Spica", .BIndex = 33, .BType = "Stars"}
        BNData(64) = New BodyData With {.Bname = "Suhail", .BIndex = 23, .BType = "Stars"}
        BNData(65) = New BodyData With {.Bname = "Vega", .BIndex = 49, .BType = "Stars"}
        BNData(66) = New BodyData With {.Bname = "Zubenelgenubi", .BIndex = 39, .BType = "Stars"}
        Exit Sub
    End Sub
    Public Function getBNIndex(ByVal BdyName As String) As Integer
        'this function uses the selected body name from the input form (or any body name sent into it) and returns the valid Index from the table above
        ' The Index is usually widely in the analysis and computational code in this module  as an table index into computation tables for RA, DEc, etc.
        Dim Limit As Integer = BNData.GetUpperBound(0)
        Dim I As Integer = 0
        ' first check to see if BNData has been loaded - this value set in form load / initiatilization routines - if for some reason this function gets called before 
        ' that load routine completes, then the load takes place here. This can occur as the form is initially loaded and form field events are fired off prior to load 
        If Not BNData(0).Bname = "Loaded" Then
            LoadBNData()
        End If
        For I = 0 To Limit
            If BNData(I).Bname = BdyName Then
                BN = BNData(I).BIndex
                BNType = BNData(I).BType
                BNBodyName = BNData(I).Bname
                Return BNData(I).BIndex
                Exit Function
            End If
        Next
        Return 999
    End Function
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        If CheckOpenWinForms("FormMeridianDiagram") = True Then
            FormMeridianDiagram.ExitBtn.PerformClick()
            FormMeridianDiagram.Close()
        End If
        If InvokedbySightLog = True Then
            SightLog.FormSRFLoaded = False
            InvokedbySightLog = False
        End If
        'Cleanup()
        Me.Close()
        Exit Sub
    End Sub
    Private Sub optLower_CheckedChanged(sender As Object, e As EventArgs) Handles optLower.CheckedChanged
        If Not FormSRFLoaded Then Exit Sub
        If sender.Checked Then
            If optHorizonBubble.Checked = True Then
                SendMsgBx("Caution:  Improper combination of limb and horizon. Lower limb cannot combine with Bubble horizon", MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub optUpper_CheckedChanged(sender As Object, e As EventArgs) Handles optUpper.CheckedChanged
        If Not FormSRFLoaded Then Exit Sub
        If sender.Checked Then
            If optHorizonBubble.Checked = True Then
                SendMsgBx("Caution:  Improper combination of limb and horizon. Upper limb cannot combine with Bubble horizon", MessageBoxIcon.Error)
            End If
        End If
        Exit Sub
    End Sub

    Private Sub optCenter_CheckedChanged(sender As Object, e As EventArgs) Handles optCenter.CheckedChanged
        If Not FormSRFLoaded Then Exit Sub
        If sender.Checked Then
            lblHE.Visible = False
            txtHE.Visible = False
            cboHE.Visible = False
            lblDsDist.Visible = False
            txtDsDist.Visible = False
            cboDsUnit.Visible = False
            If (optHorizonNatural.Checked = True Or optHorizonDipShort.Checked = True) Then
                SendMsgBx("Caution:  Improper combination of limb and horizon. Natural or Dip Short Horizon cannot combine with Center limb", MessageBoxIcon.Error)
            End If
        End If
    End Sub
    Public Sub GetValidBN()
        Dim SBName As String = cboBody.SelectedItem.ToString
        SBName = GetValidBodyName()
        BN = getBNIndex(SBName)
        If BN = 999 Then
            ' this error should mean that someone changed the form drop down list without syncing it to the internal table to get a valid BN
            SendMsgBx("Error: Invalid BN returned - check selection list on form to BN code in program", MessageBoxIcon.Stop)
        End If
        Exit Sub
    End Sub
    Public Function GetValidBodyName() As String
        Dim SBName As String = cboBody.SelectedItem.ToString
        Dim SunStr As String = "Sun"
        Dim MoonStr As String = "Moon"
        If SBName = SunStr Or SBName = MoonStr Then
            If optUpper.Checked Then
                SBName &= " U.L."
            ElseIf optLower.Checked Then
                SBName &= " L.L."
            Else
                SBName &= " L.L."
                'optLower.Checked = True
            End If
        End If
        Return SBName
        Exit Function
    End Function
    Private Sub optHorizonBubble_CheckedChanged(sender As Object, e As EventArgs) Handles optHorizonBubble.CheckedChanged
        If Not FormSRFLoaded Then Exit Sub
        If sender.Checked Then
            If optHorizonBubble.Checked = True Then
                lblHE.Visible = False
                txtHE.Visible = False
                cboHE.Visible = False
                lblDsDist.Visible = False
                txtDsDist.Visible = False
                cboDsUnit.Visible = False
            End If

            If optUpper.Checked = True Or optLower.Checked = True Then
                SendMsgBx("Caution:  Improper combination of limb and horizon.", MessageBoxIcon.Warning)
            End If

        End If
    End Sub

    Private Sub cboBody_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboBody.SelectedIndexChanged
        If Not FormSRFLoaded Then Exit Sub
        If cboBody.SelectedItem.ToString = "Polaris" Then
            cboPolaris.Visible = True
            cboPolaris.BringToFront()
            cboSun.Visible = False
            cboStars.Visible = False
            cboPlanets.Visible = False
            LimbTxt.Visible = False
            frmLimb.Visible = False
            optUpper.Visible = False
            optLower.Visible = False
            optCenter.Visible = False

        ElseIf cboBody.SelectedItem.ToString = "Sun" Then
            cboSun.Visible = True
            cboSun.BringToFront()
            cboPolaris.Visible = False
            cboStars.Visible = False
            cboPlanets.Visible = False
            LimbTxt.Visible = True
            frmLimb.Visible = True
            optUpper.Visible = True
            optLower.Visible = True
            optCenter.Visible = True

        ElseIf cboBody.SelectedItem.ToString = "Moon" Then
            cboSun.Visible = False
            cboPolaris.Visible = False
            cboStars.Visible = False
            cboPlanets.Visible = False
            LimbTxt.Visible = True
            frmLimb.Visible = True
            optUpper.Visible = True
            optLower.Visible = True
            optCenter.Visible = True

        ElseIf cboBody.SelectedItem.ToString <> "Polaris" And cboBody.SelectedItem.ToString <> "Sun" And cboBody.SelectedItem.ToString <> "Moon" Then
            cboPolaris.Visible = False
            cboSun.Visible = False
            cboStars.Visible = False
            cboPlanets.Visible = False
            lblDRL.Visible = True
            txtLDeg.Visible = True
            lblLDeg.Visible = True
            txtLMin.Visible = True
            lblLMin.Visible = True
            cboL.Visible = True
            If cboBody.SelectedItem.ToString <> "Polaris" Then
                cboPolaris.Text = "Latitude by altitude of Polaris"
            End If
            LimbTxt.Visible = False
            frmLimb.Visible = False
            optUpper.Visible = False
            optLower.Visible = False
            optCenter.Visible = False

        ElseIf cboBody.SelectedItem.ToString <> "Polaris" And cboBody.SelectedItem.ToString <> "Sun" And cboBody.SelectedItem.ToString <> "Moon" And cboBody.SelectedItem.ToString <> "Venus" And cboBody.SelectedItem.ToString <> "Mars" And cboBody.SelectedItem.ToString <> "Jupiter" And cboBody.SelectedItem.ToString <> "Saturn" Then 'stars othr than Polaris
            cboPolaris.Visible = False
            cboSun.Visible = False
            cboStars.Visible = True
            cboPlanets.Visible = False
            LimbTxt.Visible = False
            frmLimb.Visible = False
            optUpper.Visible = False
            optLower.Visible = False
            optCenter.Visible = False

        ElseIf cboBody.SelectedItem.ToString = "Venus" Or cboBody.SelectedItem.ToString = "Mars" Or cboBody.SelectedItem.ToString = "Jupiter" Or cboBody.SelectedItem.ToString = "Saturn" Then 'spelled Staurn before V5.4.1
            cboPolaris.Visible = False
            cboSun.Visible = False
            cboStars.Visible = False
            cboPlanets.Visible = True
            LimbTxt.Visible = False
            frmLimb.Visible = False
            optUpper.Visible = False
            optLower.Visible = False
            optCenter.Visible = False
        Else
            cboSun.Visible = True
            cboSun.BringToFront()
            cboPolaris.Visible = False
            cboStars.Visible = False
            cboPlanets.Visible = False
            LimbTxt.Visible = True
            frmLimb.Visible = True
            optUpper.Visible = True
            optLower.Visible = True
            optCenter.Visible = True
        End If
        GetValidBN()
        If BNType = "Moon" Or BNType = "Sun" Then 'Sun or Moon
            If optCenter.Checked = True And (optHorizonNatural.Checked = True Or optHorizonDipShort.Checked = True) Then
                SendMsgBx("Caution:  Improper combination of limb and horizon.", MessageBoxIcon.Warning) 'Sun or Moon
            End If
            If (optLower.Checked = True Or optUpper.Checked = True) And optHorizonBubble.Checked = True Then
                SendMsgBx("Caution:  Improper combination of limb and horizon.", MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub cboLo_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboLo.SelectedIndexChanged
        AutoZDCalc()
    End Sub

    Public Sub cboMonth_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        'If Not FormSRFLoaded Then Exit Sub
        'CheckDate()
    End Sub

    Private Sub cboPolaris_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboPolaris.SelectedIndexChanged
        If Not FormSRFLoaded Then Exit Sub
        If cboBody.SelectedItem.ToString <> "Polaris" Or cboPolaris.Text <> "Latitude by altitude of Polaris" Then
            lblDRL.Visible = True
            txtLDeg.Visible = True
            lblLDeg.Visible = True
            txtLMin.Visible = True
            lblLMin.Visible = True
            cboL.Visible = True
        End If
    End Sub

    Private Sub cboPressure_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboPressure.SelectedIndexChanged
        If cboPressure.Text = "in Hg" Then txtPressure.Text = "29.83"
        If cboPressure.Text = "mbar" Then txtPressure.Text = "1010"
        txtPressure_TextChanged(txtPressure, New System.EventArgs())
    End Sub

    Private Sub cboTemperature_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboTemperature.SelectedIndexChanged
        If cboTemperature.Text = "F " Then txtTemperature.Text = "50"
        If cboTemperature.Text = "C " Then txtTemperature.Text = "10"
        txtTemperature_TextChanged(txtTemperature, New System.EventArgs())
    End Sub

    Public Sub cmdFix_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFix.Click
        'Form4.IUPass = IU
        FixDG.IUPass = IU
        Dim temp As Integer = 0
        For temp = 1 To 12
            'Form4.FixDataArray(temp) = New Form4.SFixData With {.SFZH = FZH(temp), .SFZM = FZM(temp), .SFZS = FZS(temp),
            '.SFZN = FZN(temp), .SFMI = FMI(temp), .SFL = FL(temp), .SFLo = FLo(temp), .SBF = BF(temp),
            '.SFLD = FLD(temp), .SFLM = FLM(temp), .sFD = FD(temp), .SFMD = FMD(temp), .SFMM = FMM(temp),
            '.sFLA = FLA(temp), .SFM = FM(temp), .SFGHA = FGHA(temp), .SFDec = FDec(temp), .SFHo = FHo(temp)}
            FixDG.FixDataArray(temp) = New FixDG.SFixData With {.SFZH = FZH(temp), .SFZM = FZM(temp), .SFZS = FZS(temp),
                .SFZN = FZN(temp), .SFMI = FMI(temp), .SFL = FL(temp), .SFLo = FLo(temp), .SBF = BF(temp),
                .SFLD = FLD(temp), .SFLM = FLM(temp), .sFD = FD(temp), .SFMD = FMD(temp), .SFMM = FMM(temp),
                .sFLA = FLA(temp), .SFM = FM(temp), .SFGHA = FGHA(temp), .SFDec = FDec(temp), .SFHo = FHo(temp), .SDTSight = FDTSight(temp), .SEP = EP(temp)}
        Next
        'Form4.Show()
        FixDG.txtUserInfo.Text = Me.txtUserInfo.Text
        FixDG.Show()
        FixDG.SetDesktopLocation(5,5) '
        Exit Sub
    End Sub

    Public Sub cmdMerDiag_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdMerDiag.Click
        If CheckOpenWinForms("FormMeridianDiagram") = True Then
            FormMeridianDiagram.ExitBtn.PerformClick()
            FormMeridianDiagram.Close()
        End If
        If FlagMD = True Then
            ' sight reduction method form
            MainMenu.FormAltSRFlagMD = False
        End If
        FormMeridianDiagram.Show()
        FormSightPlan.SetDesktopLocation(5,5) '
        FormMeridianDiagram.FormSRFFlagMD = True
        FormMeridianDiagram.FormAltSRFlagMD = False
        FormMeridianDiagram.L = Lat
        FormMeridianDiagram.Ho = Hc
        FormMeridianDiagram.ZN = ZN
        FormMeridianDiagram.LHA = LHAOriginal  'FormSRF.LHADeg + FormSRF.LHAMin / 60
        FormMeridianDiagram.Dec = TotDE
        FormMeridianDiagram.BodyName = BNBodyName
        FormMeridianDiagram.DisplayMerDiag()
        FormMeridianDiagram.FormSRFFlagMD = False
        FormMeridianDiagram.FormAltSRFlagMD = False
        'cmdMerDiag.Enabled = False
        'cmdMerDiag.Visible = False

    End Sub

    Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
        'ScreenCapture()
        PrintScreen(Me.Bounds)
        Me.Focus()
        Exit Sub
    End Sub

    Private Sub ScreenCapture()
        Dim bmpScreenShot As Bitmap
        Dim gfxScreenshot As Graphics
        Dim filename As String = "./Graphics/SRFScreenCapture" & Now.ToString("yyyyMMddHHmmss") & ".jpg"
        bmpScreenShot = New Bitmap(Me.Bounds.Width, Me.Bounds.Height, Imaging.PixelFormat.Format32bppArgb)

        gfxScreenshot = Graphics.FromImage(bmpScreenShot)
        gfxScreenshot.CopyFromScreen(Me.Bounds.X, Me.Bounds.Y, 0, 0, Me.Bounds.Size, CopyPixelOperation.SourceCopy)
        If My.Computer.FileSystem.FileExists(filename) Then
            My.Computer.FileSystem.DeleteFile(filename)
        End If
        bmpScreenShot.Save(filename, Imaging.ImageFormat.Jpeg)
        IssuingSendMsgBx = True
        MessageBox.Show("Screen Capture can be found at:" & filename)

        IssuingSendMsgBx = False
        Exit Sub
    End Sub

    Private Sub cmdReduce_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdReduce.Click
        If Not FormSRFLoaded Then Exit Sub
        FlagSRFLoCNASR = True
        DateError = False
        'CheckDate()
        'If DateError = True Then
        '    DateError = False
        '    Exit Sub
        'End If
        If cboIE.Text = "off the arc (rdg.)" And Val(txtIEdeg.Text) = 0 Then
            cboIE.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            cboIE.Focus()
            SendMsgBx("For IE off the arc (rdg.), degree value cannot be zero.", MessageBoxIcon.Error)
            Exit Sub
        End If
        If optHorizonDipShort.Checked = True And Val(txtDsDist.Text) = 0 Then
            txtDsDist.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            txtDsDist.Focus()
            SendMsgBx("You must enter a non-zero value for Ds distance", MessageBoxIcon.Error)
            Exit Sub
        End If
        If cboTemperature.Text = "F " And (Val(txtTemperature.Text) < -40 Or Val(txtTemperature.Text) > 130) Then
            txtTemperature.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            txtTemperature.Focus()
            SendMsgBx("Temperature Out of Range", MessageBoxIcon.Error)
            Exit Sub
        End If
        If cboTemperature.Text = "C " And (Val(txtTemperature.Text) < -40 Or Val(txtTemperature.Text) > 55) Then
            txtTemperature.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            txtTemperature.Focus()
            SendMsgBx("Temperature Out of Range", MessageBoxIcon.Error)
            Exit Sub
        End If
        If cboPressure.Text = "in Hg" And (Val(txtPressure.Text) < 28 Or Val(txtPressure.Text) > 32) Then
            txtPressure.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            txtPressure.Focus()
            SendMsgBx("Pressure Out of Range", MessageBoxIcon.Error)
            Exit Sub
        End If
        If cboPressure.Text = "mbar" And (Val(txtPressure.Text) < 950 Or Val(txtPressure.Text) > 1100) Then
            txtPressure.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            txtPressure.Focus()
            SendMsgBx("Pressure Out of Range", MessageBoxIcon.Error)
            Exit Sub
        End If
        'BN is Body Number from the body selected on the drop down body list - goes back to the order of the drop down list in VB6 - ugh.
        'GetValidBN access cboBody name selected and then finds the associated valid BN number for processing in the rest of the program
        ' The BN is the body number  Associated with this function are the BNBodyType and the BNBodyName - See translation table at front of this module that GetValidBN uses
        GetValidBN()

        If (BNBodyName = "Polaris" And cboPolaris.Text = "Latitude by altitude of Polaris") Then
            LatByPolaris()
            If HoinMinutes > 4139.9 Then
                SendMsgBx("Approximate latitude exceeds range of Nautical Almanac Polaris Tables.  Calculation aborted.", MessageBoxIcon.Error)
                Exit Sub
            End If
            LatByPolaris() 'need to do LatByPolaris twice to make it work
            Exit Sub
        End If
        'next line added sun stuff in V5.3.1
        StarNAFlag = False
        If (BNType = "Stars" And cboStars.Text = "NA vals. of SHA/Dec") Or
            (BNType = "Planets" And cboPlanets.Text = "NA vals. of v/d") Or
            (BNType = "Sun" And cboSun.Text = "NA val. of hourly GHA/d") Or
            (BNType = "Moon" And cboSun.Text = "NA val. of hourly GHA/d") Then
            StarNAFlag = True
        End If

        If StarNAFlag = True Then '1st pass for 12h of middle day
            LatLong()
            ZoneTime()
            Greenwich()
            Delta_T()
            Julian()
            If BNType = "Stars" Then
                Stars()
                DENA = DE
                HourAngles()
            End If
            If (BNType = "Planets" Or BNType = "Sun" Or BNType = "Moon") Then
                T = THour1
                JDHour = JDHour1
                Nutation()
                Obliquity()
                JD = JDHour1
                If (BNType = "Planets") Then
                    Planets()
                End If
                If (BNType = "Sun" Or BNType = "Moon") Then
                    Sun()
                End If
                DENA1 = DE
                HourAnglesHour()
                GHAHour1 = GHAHour
                If (BNType = "Planets") Then
                    FlagPlanets = True
                End If
                Greenwich()
                Delta_T()
                Julian()
                T = THour2
                JDHour = JDHour2
                Nutation()
                Obliquity()
                JD = JDHour2
                If (BNType = "Planets") Then
                    Planets()
                End If
                If (BNType = "Sun" Or BNType = "Moon") Then
                    Sun()
                End If
                DENA2 = DE
                HourAnglesHour()
                GHAHour2 = GHAHour
                IandC()
                If (BNType = "Planets") Then
                    FlagPlanets = False
                End If
            End If
        End If

        StarNAFlag = False '2nd pass for date and time of sight
        LatLong()
        ZoneTime()
        Greenwich()
        Delta_T()
        Julian()
        If BNType = "Stars" Then
            Stars()
            DE1 = DE
            HourAngles()
        End If

        'Make StarNAFlag true again if necc.
        If (BNType = "Stars" And cboStars.Text = "NA vals. of SHA/Dec") Or
            (BNType = "Planets" And cboPlanets.Text = "NA vals. of v/d") Or
            (BNType = "Sun" And cboSun.Text = "NA val. of hourly GHA/d") Or
            (BNType = "Moon" And cboSun.Text = "NA val. of hourly GHA/d") Then
            StarNAFlag = True
        End If

        'all bodies; does Aries for stars
        T = THour1
        JDHour = JDHour1
        Nutation()
        Obliquity()
        If BNType = "Moon" Then
            Moon()
            If GMinute < 30 Then
                HPA = HP 'This is for nearest whole hour 'HPA = HP without GMinute<30 for using previous whole hour
            End If
        End If
        If BNType = "Sun" Then
            Sun()
        End If
        If BNType = "Planets" Then
            JD = JDHour1
            Planets()
        End If
        DE1 = DE
        HourAnglesHour()
        GHAHour1 = GHAHour
        'not for stars
        If BNType = "Planets" Or BNType = "Moon" Or BNType = "Sun" Then
            T = THour2
            JDHour = JDHour2
            Nutation()
            Obliquity()
            If BNType = "Moon" Then
                Moon()
                If GMinute >= 30 Then
                    HPA = HP 'This is for nearest whole hour
                End If
            End If
            If BNType = "Sun" Then
                Sun()
            End If
            If BNType = "Planets" Then
                JD = JDHour2
                Planets()
            End If

            DE2 = DE
            HourAnglesHour()
            GHAHour2 = GHAHour
        End If

        If (BNType = "Sun" And cboSun.Text = "NA val. of hourly GHA/d") Then 'for Nautical Almanac value of hourly GHA of Sun
            SunHourChange = GHAHour2 - GHAHour1
            If SunHourChange < 0 Then
                SunHourChange = SunHourChange + 360
            End If
            SunGHACorr = (15 - SunHourChange) / 2
            GHAHour1 = GHAHour1 - SunGHACorr
            GHAHourDeg1 = Int(GHAHour1)
            GHAHourMin1 = (GHAHour1 - GHAHourDeg1) * 60
            GHAHourMin1 = Int(GHAHourMin1 * 10 + 0.5) / 10
            If GHAHourMin1 = 60 Then
                GHAHourMin1 = 0
                GHAHourDeg1 = GHAHourDeg1 + 1
            End If
            TotGHA = GHAHourDeg1 + GHAHourMin1 / 60 + GHAIncrementDeg + GHAIncrementMin / 60 '+ Sgn(HourChange) * vcorr / 60
            TotGHADeg = Int(TotGHA)
            TotGHAMin = (TotGHA - TotGHADeg) * 60
            TotGHAMin = Int(TotGHAMin * 10 + 0.50000000001) / 10 'THIS MAKES ROUNDING COME OUT RIGHT BUT GHA BETTER WITHOUT IT
            If TotGHAMin = 60 Then
                TotGHAMin = 0
                TotGHADeg = TotGHADeg + 1
            End If

            If TotGHADeg >= 360 Then
                TotGHADeg = TotGHADeg - 360
            End If
            LHA = TotGHADeg + TotGHAMin / 60 - Lo
            If LHA >= 360 Then
                LHA = LHA - 360
            End If
            If LHA < 0 Then
                LHA = LHA + 360
            End If
            LHADeg = Int(LHA)
            LHAMin = (LHA - LHADeg) * 60
            If Int(LHAMin * 10 + 0.5) / 10 = 60 Then
                LHAMin = 0
                LHADeg = LHADeg + 1
            End If
        End If

        'IandC
        If (BNType = "Moon" Or BNType = "Sun" Or BNType = "Stars") Then
            IandC()
        End If
        If (BNType = "Planets") Then
            If cboPlanets.Text = "Accurate vals. of v/d" Then
                IandC()
            Else
                'If (BNType = "Planets" And cboPlanets.Text = "NA vals. of v/d") Then
                IandCP()
            End If
        End If
        'Parallax PA removed from AltitudeCorrection and done here in case Parameters is done before SR Form
        AltitudeCorrection()
        If BNType <> "Moon" Then
            HPA = HP
        End If
        PA = HPA * System.Math.Cos(((hainMinutes + Corr2forParallax) / 60) * Pi / 180) 'the next three lines are approximated by this
        AltitudeCorrection() 'this is needed if Parameters done first
        LawOfCosines()
        If BNType = "Moon" Then 'Moon
            PA = PA - 0.192 * System.Math.Sin(Lat * Pi / 180) * System.Math.Sin(Lat * Pi / 180) * System.Math.Cos(((hainMinutes + Corr2forParallax) / 60) * Pi / 180) + 0.192 * System.Math.Sin(2 * Lat * Pi / 180) * System.Math.Cos(ZN * Pi / 180) * System.Math.Sin(((hainMinutes + Corr2forParallax) / 60) * Pi / 180) 'Nautical Almanac formula
            If PA < 0 Then
                PA = 0
            End If
            LawOfCosines() 'in case oblateness made a difference
        End If
        SaveGHA = TotGHA
        EstimatedPosition()
        DisplaySR()
        DisplayLOC()
        btnCLSPlot.Visible = True
        btnCustomPlot.Visible = True
        cmdSave.Visible = True
        cmdMerDiag.Visible = True
        btnExpandTimeDiag.Visible = True
        cmdMerDiag.Enabled = True
        If InvokedbySightLog = True Then
            SightLog.SRFFormIntercept = Intercept
            SightLog.SRFFormZN = ZN
        End If
        Exit Sub
    End Sub

    Public Sub cmdSave_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSave.Click
        II += 1
        IU += 1
        If IU > 12 Then
            SendMsgBx("Fix Form can only handle 12 fixes - A 13th fix cannot be added", MessageBoxIcon.Error)
            Exit Sub
        End If
        If IU > 1 Then
            cmdFix.Visible = True
            cmdFix.Enabled = True
            cmdFix.Text = "Establish Fix for " & IU.ToString("#0") & " sights"
        End If
        FDTSight(II) = DTSight.Value
        FZT(II) = ZTTemp
        FZH(II) = ZTHours
        FZM(II) = ZTMinutes
        FZS(II) = ZTSeconds
        FUT(II) = UTinSeconds
        FMI(II) = Intercept
        FD(II) = "T"
        If Intercept > 0 Then
            FD(II) = "A"
        End If
        If Intercept = 0 Then
            FD(II) = " "
        End If
        FZN(II) = ZN
        BF(II) = GetValidBodyName()
        FL(II) = Lat
        FLD(II) = txtLDeg.Text
        FLM(II) = txtLMin.Text
        FLA(II) = cboL.Text
        FLo(II) = Lo
        FMD(II) = Convert.ToDouble(txtLoDeg.Text)
        If txtLoMin.Text = "" Then
            FMM(II) = 0.0
        Else
            FMM(II) = Convert.ToDouble(txtLoMin.Text)
        End If
        FM(II) = cboLo.Text
        cmdSave.Visible = False
        btnCLSPlot.Visible = False
        btnCustomPlot.Visible = False
        ' this if statement added 9/21/2019 by hhammond. TotGHA can be zeroed out or changed in AngleHours subroutine called in DrawTimeDiagram subroutine. TotGHA is protected in SaveGHA prior to that call
        FGHA(II) = SaveGHA
        FDec(II) = DE       'added in V5.6.1
        FHo(II) = HoinMinutes / 60      'added in V5.6.1
        EP(II) = PlotOut.PlotSLEP
        SendMsgBx("Sight reduction data saved - Enter new sight data", MessageBoxIcon.Information)
        Exit Sub
    End Sub

    Private Sub Form_Initialize_Renamed()
        Pi = System.Math.PI   '4 * System.Math.Atan(1.0#)
        If InvokedbySightLog = True And IU > 0 Then
            IU = IU
        Else
            IU = 0
        End If

        txtZDh.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000F)
        cboZDm.SelectedIndex = 0 ' "00"
        frmLimb.Visible = True
        optLower.Checked = True

        ReDim BNData(1)
        BNData(0).Bname = "Empty"
        BNData(0).BIndex = 999
        BNData(0).BType = "Empty"

        'RA is Right Ascension hours of stars
        RA = New Double() {2.53030102, 0.13979405, 0.43806971, 0.67512237, 0.72649196, 1.62856849, 2.11955753, 2.97102075, 3.03799227, 3.40538065,
        4.59867741, 5.24229787, 5.27815529, 5.41885085, 5.43819817, 5.60355929, 5.91952924, 6.39919719, 6.75247703, 6.97709679,
        7.65503287, 7.75526399, 8.37523211, 9.13326624, 9.21999319, 9.4597898, 10.13953074, 11.06213019, 11.81766044, 12.26343617,
        12.44330439, 12.51943314, 12.90048595, 13.41988313, 13.79234379, 14.06372347, 14.11137457, 14.26102008, 14.66013772, 14.84797587,
        14.84509067, 15.57813003, 16.49012803, 16.81108191, 17.1729687, 17.56014444, 17.58224182, 17.94343608, 18.4028662, 18.61564901,
        18.92109048, 19.84638861, 20.42846051, 20.69053187, 21.73643281, 22.13721819, 22.96084625, 23.07934827}
        'Dec is Declination degrees of stars
        Dec = New Double() {89.26410951, 29.09043199, -42.30598151, 56.53733109, -17.9866046, -57.23675749, 23.46242313, -40.30467242, 4.08973396, 49.86117959,
        16.50930139, -8.20164055, 45.99799111, 6.34970223, 28.60745001, -1.20191983, 7.40706274, -52.69566046, -16.71611582, -28.97208374,
        5.22499306, 28.02619862, -59.50948307, -43.43258935, -69.71720773, -8.65860253, 11.96720706, 61.7510332, 14.57206032, -17.54192947,
        -63.09909166, -57.11321169, 55.95982116, -11.16132203, 49.31326506, -60.37303931, -36.36995445, 19.18241331, -60.83397468, -16.04177818,
        74.15550491, 26.71469302, -26.43200249, -69.02771504, -15.72491023, -37.10382115, 12.56003477, 51.48889499, -34.38461611, 38.7836918,
        -26.29672225, 8.86832198, -56.7350901, 45.280338, 9.87501126, -46.96097543, -29.62223615, 15.20526442}
        'RA is Right Ascension hours of stars
        'RA = New Double() {2.53030102, 0.13979405, 0.43806971, 0.67512237, 0.72649196, 1.62856849, 2.11955753, 2.97102075, 3.03799227, 3.40538065, 4.59867741, 5.24229787, 5.27815529, 5.41885085, 5.43819817, 5.60355929, 5.91952924, 6.39919719, 6.75247703, 6.97709679, 7.65503287, 7.75526399, 8.37523211, 9.13326624, 9.21999319, 9.4597898, 10.13953074, 11.06213019, 11.81766044, 12.26343617, 12.44330439, 12.51943314, 12.90048595, 13.41988313, 13.79234379, 14.06372347, 14.11137457, 14.26102008, 14.66013772, 14.84797587, 14.84509067, 15.57813003, 16.49012803, 16.81108191, 17.1729687, 17.56014444, 17.58224182, 17.94343608, 18.4028662, 18.61564901, 18.92109048, 19.84638861, 20.42746051, 20.69053187, 21.73643281, 22.13721819, 22.96084625, 23.07934827} 'RA of Peacock was 20.42846051 before V5.4.1
        'Dec is Declination degrees of stars
        'Dec = New Double() {89.26410951, 29.09043199, -42.30598151, 56.53733109, -17.9866046, -57.23675749, 23.46242313, -40.30467242, 4.08973396, 49.86117959, 16.50930139, -8.20164055, 45.99799111, 6.34970223, 28.60745001, -1.20191983, 7.40706274, -52.69566046, -16.71611582, -28.97208374, 5.22499306, 28.02619862, -59.50948307, -43.43258935, -69.71720773, -8.65860253, 11.96720706, 61.7510332, 14.57206032, -17.54192947, -63.09909166, -57.11321169, 55.95982116, -11.16132203, 49.31326506, -60.37303931, -36.36995445, 19.18241331, -60.83397468, -16.04177818, 74.15550491, 26.71469302, -26.43200249, -69.02771504, -15.72491023, -37.10382115, 12.56003477, 51.48889499, -34.38461611, 38.7836918, -26.29672225, 8.86832198, -56.7350901, 45.280338, 9.87501126, -46.96097543, -29.62223615, 15.20526442}
        'Proper motion right ascension in seconds/century
        PMRA = New Double() {22.9526, 1.0351, 2.0982, 0.6089, 1.6317, 1.0843, 1.3861, -0.468, -0.0789, 0.2493, 0.4365, 0.0126, 0.7247, -0.0587, 0.1768, 0.0099, 0.1837, 0.2199, -3.8007, 0.02, -4.797, -4.7254, -0.3329, -0.2131, -3.032, -0.0977, -1.6996, -1.9221, -3.4374, -1.1158, -0.5212, 0.3431, 1.3308, -0.2888, -1.2397, -0.458, -4.2995, -7.718, -50.3145, -0.7331, -0.7884, 0.8984, -0.0756, 0.3325, 0.2851, -0.0744, 0.7519, -0.0912, -0.32, 1.7192, 0.1031, 3.6221, 0.0937, 0.0148, 0.2031, 1.2464, 2.5248, 0.4221}
        'Proper motion declination in arcseconds/century
        PMDec = New Double() {-1.1746, -16.295, -35.3638, -3.217, 3.2711, -4.0079, -14.5771, 2.571, -7.876, -2.601, -18.936, -0.056, -42.713, -1.328, -17.422, -0.106, 1.086, 2.367, -122.3076, 0.229, -103.4582, -4.5959, 2.272, 1.428, 10.8913, 3.325, 0.4909, -3.5251, 11.3783, 2.231, -1.473, -26.433, -0.8991, -3.173, -1.5561, -2.506, -51.7862, -199.9418, 48.2868, -6.9, 1.191, -8.944, -2.321, -3.292, 9.765, -2.995, -22.261, -2.305, -12.405, 28.7459, -5.265, 38.5538, -8.615, 0.155, 0.138, -14.7909, -16.4217, -4.256}
        'Moon
        'Table 47.A longitude and distance  +


        MDA = New Double() {0, 2, 2, 0, 0, 0, 2, 2, 2, 2, 0, 1, 0, 2, 0, 0, 4, 0, 4, 2, 2, 1, 1, 2, 2, 4, 2, 0, 2, 2, 1, 2, 0, 0, 2, 2, 2, 4, 0, 3, 2, 4, 0, 2, 2, 2, 4, 0, 4, 1, 2, 0, 1, 3, 4, 2, 0, 1, 2, 2}
        MMA = New Double() {0, 0, 0, 0, 1, 0, 0, -1, 0, -1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 1, 1, 0, 1, -1, 0, 0, 0, 1, 0, -1, 0, -2, 1, 2, -2, 0, 0, -1, 0, 0, 1, -1, 2, 2, 1, -1, 0, 0, -1, 0, 1, 0, 1, 0, 0, -1, 2, 1, 0, 0}
        MMprimeA = New Double() {1, -1, 0, 2, 0, 0, -2, -1, 1, 0, -1, 0, 1, 0, 1, 1, -1, 3, -2, -1, 0, -1, 0, 1, 2, 0, -3, -2, -1, -2, 1, 0, 2, 0, -1, 1, 0, -1, 2, -1, 1, -2, -1, -1, -2, 0, 1, 4, 0, -2, 0, 2, 1, -2, -3, 2, 1, -1, 3, -1}
        MFA = New Double() {0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, -2, 2, -2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, -2, 2, 0, 2, 0, 0, 0, 0, 0, 0, -2, 0, 0, 0, 0, -2, -2, 0, 0, 0, 0, 0, 0, 0, -2}
        MSinA = New Double() {6288774, 1274027, 658314, 213618, -185116, -114332, 58793, 57066, 53322, 45758, -40923, -34720, -30383, 15327, -12528, 10980, 10675, 10034, 8548, -7888, -6766, -5163, 4987, 4036, 3994, 3861, 3665, -2689, -2602, 2390, -2348, 2236, -2120, -2069, 2048, -1773, -1595, 1215, -1110, -892, -810, 759, -713, -700, 691, 596, 549, 537, 520, -487, -399, -381, 351, -340, 330, 327, -323, 299, 294, 0}
        MCosA = New Double() {-20905355, -3699111, -2955968, -569925, 48888, -3149, 246158, -152138, -170733, -204586, -129620, 108743, 104755, 10321, 0, 79661, -34782, -23210, -21636, 24208, 30824, -8379, -16675, -12831, -10445, -11650, 14403, -7003, 0, 10056, 6322, -9884, 5751, 0, -4950, 4130, 0, -3958, 0, 3258, 2616, -1897, -2117, 2354, 0, 0, -1423, -1117, -1571, -1739, 0, -4421, 0, 0, 0, 0, 1165, 0, 0, 8752}
        'Table 47.B latitude
        MDB = New Double() {0, 0, 0, 2, 2, 2, 2, 0, 2, 0, 2, 2, 2, 2, 2, 2, 2, 0, 4, 0, 0, 0, 1, 0, 0, 0, 1, 0, 4, 4, 0, 4, 2, 2, 2, 2, 0, 2, 2, 2, 2, 4, 2, 2, 0, 2, 1, 1, 0, 2, 1, 2, 0, 4, 4, 1, 4, 1, 4, 2}
        MMB = New Double() {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -1, 0, 0, 1, -1, -1, -1, 1, 0, 1, 0, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, -1, 0, 0, 0, 0, 1, 1, 0, -1, -2, 0, 1, 1, 1, 1, 1, 0, -1, 1, 0, -1, 0, 0, 0, -1, -2}
        MMprimeB = New Double() {0, 1, 1, 0, -1, -1, 0, 2, 1, 2, 0, -2, 1, 0, -1, 0, -1, -1, -1, 0, 0, -1, 0, 1, 1, 0, 0, 3, 0, -1, 1, -2, 0, 2, 1, -2, 3, 2, -3, -1, 0, 0, 1, 0, 1, 1, 0, 0, -2, -1, 1, -2, 2, -2, -1, 1, 1, -1, 0, 0}
        MFB = New Double() {1, 1, -1, -1, 1, -1, 1, 1, -1, -1, -1, -1, 1, -1, 1, 1, -1, -1, -1, 1, 3, 1, 1, 1, -1, -1, -1, 1, -1, 1, -3, 1, -3, -1, -1, 1, -1, 1, -1, 1, 1, 1, 1, -1, 3, -1, -1, 1, -1, -1, 1, -1, 1, -1, -1, -1, -1, -1, -1, 1}
        MSinB = New Double() {5128122, 280602, 277693, 173237, 55413, 46271, 32573, 17198, 9266, 8822, 8216, 4324, 4200, -3359, 2463, 2211, 2065, -1870, 1828, -1794, -1749, -1565, -1491, -1475, -1410, -1344, -1335, 1107, 1021, 833, 777, 671, 607, 596, 491, -451, 439, 422, 421, -366, -351, 331, 315, 302, -283, -229, 223, 223, -220, -220, -185, 181, -177, 176, 166, -164, 132, -119, 115, 107}
        'nutation in longitude and obliquity
        ND = New Double() {0, -2, 0, 0, 0, 0, -2, 0, 0, -2, -2, -2, 0, 2, 0, 2, 0, 0, -2, 0, 2, 0, 0, -2, 0, -2, 0, 0, 2, -2, 0, -2, 0, 0, 2, 2, 0, -2, 0, 2, 2, -2, -2, 2, 2, 0, -2, -2, 0, -2, -2, 0, -1, -2, 1, 0, 0, -1, 0, 0, 2, 0, 2}
        NM = New Double() {0, 0, 0, 0, 1, 0, 1, 0, 0, -1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 2, 1, 0, -1, 0, 0, 0, 1, 1, -1, 0, 0, 0, 0, 0, 0, -1, -1, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, -1, 1, -1, -1, 0, -1}
        NMprime = New Double() {0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 1, 0, -1, 0, 1, -1, -1, 1, 2, -2, 0, 2, 2, 1, 0, 0, -1, 0, -1, 0, 0, 1, 0, 2, -1, 1, 0, 1, 0, 0, 1, 2, 1, -2, 0, 1, 0, 0, 2, 2, 0, 1, 1, 0, 0, 1, -2, 1, 1, 1, -1, 3, 0}
        NF = New Double() {0, 2, 2, 0, 0, 0, 2, 2, 2, 2, 0, 2, 2, 0, 0, 2, 0, 2, 0, 2, 2, 2, 0, 2, 2, 2, 2, 0, 0, 2, 0, 0, 0, -2, 2, 2, 2, 0, 2, 2, 0, 2, 2, 0, 0, 0, 2, 0, 2, 0, 2, -2, 0, 0, 0, 2, 2, 0, 0, 2, 2, 2, 2}
        NOmega = New Double() {1, 2, 2, 2, 0, 0, 2, 1, 2, 2, 0, 1, 2, 0, 1, 2, 1, 1, 0, 1, 2, 2, 0, 2, 0, 0, 1, 0, 1, 2, 1, 1, 1, 0, 1, 2, 2, 0, 2, 1, 0, 2, 1, 1, 1, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 2, 0, 0, 2, 2, 2, 2}
        NSin = New Double() {-171996, -13187, -2274, 2062, 1426, 712, -517, -386, -301, 217, -158, 129, 123, 63, 63, -59, -58, -51, 48, 46, -38, -31, 29, 29, 26, -22, 21, 17, 16, -16, -15, -13, -12, 11, -10, -8, 7, -7, -7, -7, 6, 6, 6, -6, -6, 5, -5, -5, -5, 4, 4, 4, -4, -4, -4, 3, -3, -3, -3, -3, -3, -3, -3}
        NSinT = New Double() {-174.2, -1.6, -0.2, 0.2, -3.4, 0.1, 1.2, -0.4, 0, -0.5, 0, 0.1, 0, 0, 0.1, 0, -0.1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -0.1, 0, 0.1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        NCos = New Double() {92025, 5736, 977, -895, 54, -7, 224, 200, 129, -95, 0, -70, -53, 0, -33, 26, 32, 27, 0, -24, 16, 13, 0, -12, 0, 0, -10, 0, -8, 7, 9, 7, 6, 0, 5, 3, -3, 0, 3, 3, 0, -3, -3, 3, 3, 0, 3, 3, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        NCosT = New Double() {8.9, -3.1, -0.5, 0.5, -0.1, 0, -0.6, 0, -0.1, 0.3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}

    End Sub

    Private Sub FormSRF_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Form_Initialize_Renamed()
        DrawWidth = (EqTPicBx.Width / 2) - 20
        DPen = New Pen(Color.Black, 1)
        ptA = New Point
        ptB = New Point
        LoadBNData()
        Load_SunSDData()
        ClearScreen()
        If FavoriteLocations.SharedLocUse.EntryStatus = "Shared" Then
            Me.BringToFront()
            If FavoriteLocations.CommonYesNoMsgBox("Shared Location data is available - do you want to use it?") = True Then
                With FavoriteLocations.SharedLocUse
                    txtLDeg.Text = .DRLatDeg.ToString("00")
                    txtLMin.Text = .DRLatMin.ToString("00.0")
                    If .DRLatNS = g_LatN Then
                        cboL.SelectedIndex = 0
                    Else
                        cboL.SelectedIndex = 1
                    End If
                    txtLoDeg.Text = .DRLongDeg.ToString("00")
                    txtLoMin.Text = .DRLongMin.ToString("00.0")
                    If .DRLongEW = g_LongW Then
                        cboLo.SelectedIndex = 0
                    Else
                        cboLo.SelectedIndex = 1
                    End If
                    Select Case .HorType
                        Case "Dip Short"
                            optHorizonDipShort.Checked = True
                            txtDsDist.Text = .HorDist.ToString("##0.0")
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

                    txtHE.Text = .HE.ToString("#0.0")
                    cboHE.SelectedIndex = .HETypeIndex
                End With
            End If
        End If

        EqTPicBx.Visible = False
        CleanOutOldFiles()
        ' drawbasictimediagram causes an empty time diagram with only the verticle meridian line to be drawn
        DrawBasicTimeDiagram = True
        DisplayTimeDiagram()
        ' this toggle the boolean off so that call calls from here cause a full diagram to be drawn using data
        DrawBasicTimeDiagram = False

        EqTPicBx.Refresh()
        FormSRFLoaded = True
        frmLimb.Visible = True
        frmLimb.Refresh()

    End Sub

    Private Sub FormSRF_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'Cleanup()
    End Sub

    Private Sub optHoParameters_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optHoParameters.CheckedChanged
        If eventSender.Checked Then
            cmdReduce_Click(cmdReduce, New System.EventArgs())
        End If
    End Sub

    Private Sub optHorizonArtificial_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optHorizonArtificial.CheckedChanged
        If eventSender.Checked Then
            If optHorizonArtificial.Checked = True Then
                lblHE.Visible = False
                txtHE.Visible = False
                cboHE.Visible = False
                lblDsDist.Visible = False
                txtDsDist.Visible = False
                cboDsUnit.Visible = False
                optHorizonBubble.Checked = False
            End If
        End If
    End Sub

    Private Sub optHorizonDipShort_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optHorizonDipShort.CheckedChanged
        If eventSender.Checked Then
            If optHorizonDipShort.Checked = True Then
                lblHE.Visible = True
                txtHE.Visible = True
                cboHE.Visible = True
                lblDsDist.Visible = True
                txtDsDist.Visible = True
                cboDsUnit.Visible = True
                optHorizonBubble.Checked = False
            End If

            If optCenter.Checked = True Then
                SendMsgBx("Caution:  Improper combination of limb and horizon.", MessageBoxIcon.Warning)
            End If

        End If
    End Sub

    Private Sub optHorizonNatural_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optHorizonNatural.CheckedChanged
        If eventSender.Checked Then
            If optHorizonNatural.Checked = True Then
                lblHE.Visible = True
                txtHE.Visible = True
                cboHE.Visible = True
                lblDsDist.Visible = False
                txtDsDist.Visible = False
                cboDsUnit.Visible = False
                optHorizonBubble.Checked = False
            End If

            If optCenter.Checked = True Then
                SendMsgBx("Caution:  Improper combination of limb and horizon.", MessageBoxIcon.Warning)
            End If

        End If
    End Sub

    Private Sub optHoSRForm_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optHoSRForm.CheckedChanged
        If eventSender.Checked Then
            cmdReduce_Click(cmdReduce, New System.EventArgs())
        End If
    End Sub

    Private Sub optHsDMm_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optHsDMm.CheckedChanged
        If eventSender.Checked Then
            If optHsDMm.Checked = True Then
                txtHsSec.Visible = False
                lblHsSec.Visible = False
                txtIESec.Visible = False
                lblIEsec.Visible = False
                txtHsMin.Clear()
                txtIEmin.Clear()
            End If
        End If
    End Sub

    Private Sub optHsDMS_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optHsDMS.CheckedChanged
        If eventSender.Checked Then
            If optHsDMS.Checked = True Then
                txtHsSec.Visible = True
                lblHsSec.Visible = True
                txtIESec.Visible = True
                lblIEsec.Visible = True
                txtHsMin.Clear()
                txtIEmin.Clear()
                txtHsSec.Clear()
                txtIESec.Clear()
            End If
        End If
    End Sub

    Private Sub optStdTPYes_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optStdTPYes.CheckedChanged
        If eventSender.Checked Then
            lblTemperature.Visible = False
            txtTemperature.Visible = False
            lblTempDeg.Visible = False
            cboTemperature.Visible = False
            lblPressure.Visible = False
            txtPressure.Visible = False
            cboPressure.Visible = False
            txtTemperature.Text = "50"
            cboTemperature.SelectedIndex = 0 '"F "
            txtPressure.Text = "29.83"
            cboPressure.SelectedIndex = 0 '"in Hg"
        End If
    End Sub

    Private Sub optStdTPNo_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optStdTPNo.CheckedChanged
        If eventSender.Checked Then
            lblTemperature.Visible = True
            txtTemperature.Visible = True
            lblTempDeg.Visible = True
            cboTemperature.Visible = True
            lblPressure.Visible = True
            txtPressure.Visible = True
            cboPressure.Visible = True
        End If
    End Sub

    Private Sub optZDAuto_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optZDAuto.CheckedChanged
        If Not FormSRFLoaded Then Exit Sub
        If eventSender.Checked Then
            If optZDAuto.Checked = True Then
                txtZDh.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000B)
                txtZDh.Enabled = False
                lblZDh.Visible = False
                cboZDm.Visible = False
                chkDST.Visible = True
                lblZDDST.Visible = True
                lblZDm.Visible = False
                cboZDm.SelectedIndex = 0 '"00"
                AutoZDCalc()
            End If
        End If
    End Sub

    Private Sub optZDManual_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optZDManual.CheckedChanged
        If eventSender.Checked Then
            If optZDManual.Checked = True Then
                txtZDh.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
                txtZDh.Enabled = True
                lblZDh.Visible = True
                cboZDm.Visible = True
                chkDST.Visible = True
                lblZDDST.Visible = True
                lblZDm.Visible = True
            End If
        End If
    End Sub

    Private Sub optZDUT_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optZDUT.CheckedChanged
        If eventSender.Checked Then
            If optZDUT.Checked = True Then
                txtZDh.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000B)
                txtZDh.Enabled = False
                lblZDh.Visible = False
                cboZDm.Visible = False
                lblZDm.Visible = False
                chkDST.Visible = False
                lblZDDST.Visible = False
                chkDST.CheckState = System.Windows.Forms.CheckState.Unchecked
                txtZDh.Text = "0"
            End If
        End If
    End Sub

    Public Sub cboDay_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        'If Not FormSRFLoaded Then Exit Sub
        'CheckDate()
    End Sub

    Private Sub txtDsDist_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtDsDist.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtDsDist.Text, ".") Then
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
    Private Sub txtHE_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHE.Enter
        SelectAllText(txtHE)
    End Sub
    Private Sub txtHsDeg_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHsDeg.TextChanged
        'txtHsDeg.ForeColor = &H80000008
        txtHsDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtHsDeg.Text) > 145 Then
            txtHsDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            SendMsgBx("Out of Range", MessageBoxIcon.Error)
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
            SendMsgBx("Out of Range", MessageBoxIcon.Error)
        End If
        If optHsDMS.Checked = True And Val(txtHsMin.Text) > 59 Then
            txtHsMin.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            SendMsgBx("Out of Range", MessageBoxIcon.Error)
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
                        If KeyAscii = 46 Then KeyAscii = 0 : Beep()
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
        txtHsSec.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtHsSec.Text) > 59 Then
            txtHsSec.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            SendMsgBx("Out of Range", MessageBoxIcon.Error)
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
        txtIEdeg.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtIEdeg.Text) > 9 Then
            txtIEdeg.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            SendMsgBx("Out of Range", MessageBoxIcon.Error)
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
            SendMsgBx("Out of Range", MessageBoxIcon.Error)
        End If
        If optHsDMS.Checked = True And Val(txtIEmin.Text) > 59 Then
            txtIEmin.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            SendMsgBx("Out of Range", MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txtIEmin_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtIEmin.Enter
        SelectAllText(txtIEmin)
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
                        If KeyAscii = 46 Then KeyAscii = 0 : Beep()
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

    Private Sub txtIESec_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtIESec.TextChanged
        'txtIESec.ForeColor = &H80000008
        txtIESec.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtIESec.Text) > 59 Then
            txtIESec.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            SendMsgBx("Out of Range", MessageBoxIcon.Error)
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

    Private Sub txtLDeg_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLDeg.TextChanged
        If Val(txtLDeg.Text) <> 90 Then txtLMin.Enabled = True
        If Val(txtLDeg.Text) = 90 Then txtLMin.Clear() : txtLMin.Enabled = False : txtLMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000B)
        'txtLDeg.ForeColor = &H80000008
        txtLDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtLDeg.Text) > 90 Then
            txtLDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            SendMsgBx("Out of Range", MessageBoxIcon.Error)
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
            SendMsgBx("Out of Range", MessageBoxIcon.Error)
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
        If Val(txtLoDeg.Text) = 180 Then txtLoMin.Clear() : txtLoMin.Enabled = False : txtLoMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000B)
        txtLoDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtLoDeg.Text) > 180 Or (Val(txtLoDeg.Text) = 180 And Val(txtLoMin.Text) <> 0) Then
            txtLoDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            SendMsgBx("Out of Range", MessageBoxIcon.Error)
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
            SendMsgBx("Out of Range", MessageBoxIcon.Error)
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

    Private Sub txtSightNo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtSightNo.KeyPress
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
    Private Sub txtSightNo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSightNo.Enter
        SelectAllText(txtSightNo)
    End Sub

    Private Sub txtWEMin_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtWEMin.TextChanged
        txtWEMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtWEMin.Text) > 9 Then
            txtWEMin.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            SendMsgBx("Out of Range", MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txtWEMin_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtWEMin.KeyPress
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
    Private Sub txtWEMin_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtWEMin.Enter
        SelectAllText(txtWEMin)
    End Sub
    Private Sub txtMin_Change()
        ' nothing in this subroutine
    End Sub

    Private Sub txtPressure_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPressure.TextChanged
        txtPressure.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If cboPressure.Text = "in Hg" And ((Val(txtPressure.Text) < 28 Or Val(txtPressure.Text) > 32)) And Len(txtPressure.Text) >= 2 Then
            txtPressure.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            SendMsgBx("Out of Range", MessageBoxIcon.Error)
        End If

        If cboPressure.Text = "mbar" And (Val(txtPressure.Text) < 950 Or Val(txtPressure.Text) > 1100) And Len(txtPressure.Text) >= 4 And optStdTPNo.Checked = True Then 'optStdTPNo = True added for bug going back to standard
            txtPressure.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            SendMsgBx("Out of Range", MessageBoxIcon.Error)
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

    Private Sub txtPressure_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPressure.Enter
        SelectAllText(txtPressure)
    End Sub

    Private Sub txtWESec_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtWESec.TextChanged
        txtWESec.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtWESec.Text) > 59 Then
            txtWESec.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            SendMsgBx("Out of Range", MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txtWESec_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtWESec.KeyPress
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

    Private Sub txtWESec_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtWESec.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtWESec.Text) > 59 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtWESec_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtWESec.Enter
        SelectAllText(txtWESec)
    End Sub

    Private Sub txtTemperature_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTemperature.TextChanged
        txtTemperature.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If cboTemperature.Text = "F " And (Val(txtTemperature.Text) < -40 Or Val(txtTemperature.Text) > 130) Then
            txtTemperature.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            SendMsgBx("Out of Range", MessageBoxIcon.Error)
        End If
        If cboTemperature.Text = "C " And (Val(txtTemperature.Text) < -40 Or Val(txtTemperature.Text) > 55) Then
            txtTemperature.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            SendMsgBx("Out of Range", MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txtTemperature_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTemperature.Enter
        SelectAllText(txtTemperature)
    End Sub

    Private Sub txtTime_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        'txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        'If Len(txtTime.Text) = 6 And (Val(VB.Left(txtTime.Text, 2)) > 23 Or Val(Mid(txtTime.Text, 3, 2)) > 59 Or Val(Mid(txtTime.Text, 5, 2)) > 59) Then
        '    txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
        '    SendMsgBx("Out of Range")
        'End If
    End Sub

    Private Sub txtTime_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub txtTime_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs)
        'Dim KeepFocus As Boolean = eventArgs.Cancel
        'If Val(VB.Left(txtTime.Text, 2)) > 23 Or Val(Mid(txtTime.Text, 3, 2)) > 59 Or Val(Mid(txtTime.Text, 5, 2)) > 59 Or Len(txtTime.Text) <> 6 Then
        '    SendMsgBx("Invalid or Incomplete Time Entered")
        '    KeepFocus = True
        'End If
        'If Len(txtTime.Text) = 0 Then
        '    KeepFocus = False
        'End If
        'eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtTime_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        'SelectAllText(txtTime)
    End Sub
    Private Sub txtYear_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        'If Not FormSRFLoaded Then Exit Sub
        'txtYear.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        'If Len(txtYear.Text) = 4 And (Val(txtYear.Text) < 1901 Or Val(txtYear.Text) > 2099) Then
        '    txtYear.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
        '    SendMsgBx("Out of Range")
        'End If
        'CheckDate()
    End Sub

    Private Sub txtYear_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub txtYear_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs)
        'Dim KeepFocus As Boolean = eventArgs.Cancel
        'If Len(txtYear.Text) <> 4 Or Val(txtYear.Text) < 1901 Or Val(txtYear.Text) > 2099 Then
        '    KeepFocus = True
        'End If
        'eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtYear_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        'SelectAllText(txtYear)
    End Sub

    Private Sub txtZDh_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtZDh.TextChanged
        If optZDAuto.Checked = True Or optZDUT.Checked = True Then txtZDh.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000B)
        If optZDManual.Checked = True Then txtZDh.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If optZDManual.Checked = True And (Val(txtZDh.Text) < -14 Or Val(txtZDh.Text) > 12) Then
            txtZDh.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            SendMsgBx("Out of Range", MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txtZDh_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtZDh.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Static bPlusSignAlready As Boolean
        bMinusSignAlready = False
        bPlusSignAlready = False
        Select Case KeyAscii
            Case System.Windows.Forms.Keys.Back, System.Windows.Forms.Keys.Right, System.Windows.Forms.Keys.Left
                'do nothing
            Case Asc("0") To Asc("9")
                'do nothing
            Case Asc("-")
                If txtZDh.SelectionStart <> 0 Or bMinusSignAlready Then
                    KeyAscii = 0
                    Beep()
                Else
                    bMinusSignAlready = True
                End If
            Case Asc("+")
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

    Public Sub AutoZDCalc()
        If optZDAuto.Checked = True Then
            Lo = Val(txtLoDeg.Text) + Val(txtLoMin.Text) / 60
            ZD = Int(Lo / 15 + 0.5)
            If cboLo.Text = "E" Then
                ZD = -ZD
            End If
            If cboLo.Text = "E" Then
                SignZD = "-"
            Else
                SignZD = "+"
            End If
            txtZDh.Text = SignZD & System.Math.Abs(ZD)
        End If
        Exit Sub
    End Sub

    '    Public Sub CheckDate()
    '        On Error GoTo ErrorHandler
    '        If cboDay.Text = "" Or cboMonth.Text = "" Or txtYear.Text = "" Or Len(txtYear.Text) <> 4 Then
    '            Exit Sub
    '        Else
    '            'DateOfSight = cboDay.Text & "/" & cboMonth.SelectedItem & "/" & txtYear.Text
    '            'Dim TempTime As String = Mid(txtTime.Text, 1, 2) & ":" & Mid(txtTime.Text, 3, 2) & ":" & Mid(txtTime.Text, 5, 2)
    '            'SightZoneDatetime = Convert.ToDateTime(DateOfSight & " " & TempTime)
    '            DateOfSight = cboDay.Text & " " & cboMonth.SelectedItem & " " & txtYear.Text
    '            DateOfSight = CStr(DateValue(DateOfSight))
    '        End If
    '        Exit Sub
    'ErrorHandler:
    '        SendMsgBx("Invalid Date")
    '        DateError = True
    '        Exit Sub
    '    End Sub

    Private Sub cboDay_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs)
        Dim KeepFocus As Boolean = eventArgs.Cancel
        eventArgs.Cancel = KeepFocus
    End Sub
    Public Sub LatLong()
        'Next two lines for problem with commas as decimal points in Europe with Favorite Places, etc.
        LMin = Replace(txtLMin.Text, ",", ".")
        LoMin = Replace(txtLoMin.Text, ",", ".")
        Lat = Val(txtLDeg.Text) + Val(LMin) / 60
        If cboL.Text = "S" Then Lat = -Lat
        Lo = Val(txtLoDeg.Text) + Val(LoMin) / 60
        If cboLo.Text = "E" Then Lo = -Lo
    End Sub

    Public Sub ZoneTime()
        'WT = Watch Time, WE = Watch Error, ZT = Zone Time
        WTinSeconds = 3600 * DTSight.Value.Hour + 60 * DTSight.Value.Minute + DTSight.Value.Second
        WEinSeconds = 60 * Val(txtWEMin.Text) + Val(txtWESec.Text)
        If cboWE.Text = "fast" Then WEinSeconds = -WEinSeconds
        ZTinSeconds = WTinSeconds + WEinSeconds
        'Be sure Zone Time is not less than 0 or greater than 24 hours (86400 seconds)
        'Use ZTTemp as temporary variable
        ZTTemp = ZTinSeconds
        If ZTTemp > 86400 Then ZTTemp = ZTTemp - 86400
        If ZTTemp < 0 Then ZTTemp = ZTTemp + 86400
        ZTHours = Int(ZTTemp / 3600)
        ZTMinutes = Int((ZTTemp - CInt(ZTHours) * 3600) / 60)
        ZTSeconds = ZTTemp - CInt(ZTHours) * 3600 - ZTMinutes * 60
        Exit Sub
    End Sub

    Public Sub Greenwich()
        'Prefix (or suffix) G for Greenwich, UT = Universal Time
        MonthDays = "312831303130313130313031"
        'Check for local leap year

        LocalYear = DTSight.Value.Year

        'If (LocalYear Mod 4) = 0 Then
        '    LeapYear = True
        'End If
        'If (LocalYear Mod 100) = 0 And (LocalYear Mod 400) <> 0 Then
        '    LeapYear = False
        'End If
        LeapYear = DateTime.IsLeapYear(LocalYear)
        If LeapYear = True Then
            MonthDays = "312931303130313130313031"
        Else
            MonthDays = "312831303130313130313031"
        End If

        MonthNumber = DTSight.Value.Month
        DayNumber = DTSight.Value.Day
        For i = 1 To MonthNumber - 1
            DayNumber = Val(Mid(MonthDays, 2 * i - 1, 2)) + DayNumber
        Next i
        'If MonthNumber >= 3 And LeapYear = True Then ' this code commented out when if leapyear monthdays statements added June 2020 
        '    DayNumber = DayNumber + 1
        'End If
        'DayNumber = DTSight.Value.DayOfYear ' this does not work for some reason produces day of year one less than one provide by logic above

        ZD = System.Math.Abs(Val(txtZDh.Text))
        If optZDManual.Checked = True Then
            ZD = System.Math.Abs(ZD) + Val(cboZDm.Text) / 60
        End If
        If txtZDh.Text.Substring(0, 1) = "-" Then
            ZD = -ZD
        End If
        If chkDST.CheckState = 1 Then
            ZD = ZD - 1
        End If
        ZDinSeconds = 3600 * ZD
        UTinSeconds = ZTinSeconds + ZDinSeconds

        If StarNAFlag = True And BN <> 0 Then 'added And BN <> 0 in V5.3.1
            StarDayNumber = DayNumber Mod 3
            If StarDayNumber = 1 Then DayNumber = DayNumber + 1
            If StarDayNumber = 0 Then DayNumber = DayNumber - 1
            UTinSeconds = 43200 '12h
            If FlagPlanets = True Then UTinSeconds = 46800
        End If

        GHour = Int(UTinSeconds / 3600)
        GMinute = Int((UTinSeconds - CInt(GHour) * 3600) / 60)
        '    If (BN > 57 And BN < 62 And cboPlanets.text = "NA vals. of v/d") Then GMinuteP
        GSecond = UTinSeconds - CInt(GHour) * 3600 - GMinute * 60
        GYear = DTSight.Value.Year
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
        If GDayOfYear = 0 Then
            GYear = GYear - 1
        End If
        'Check for leap year at Greenwich
        'If (GYear Mod 4) = 0 Then
        '    GLeapYear = True
        'End If
        'If (GYear Mod 100) = 0 And (GYear Mod 400) <> 0 Then
        '    GLeapYear = False
        'End If
        GLeapYear = DateTime.IsLeapYear(GYear)
        'Days in year
        If GDayOfYear = 0 And GLeapYear = False Then
            GDayOfYear = 365
        End If
        If GDayOfYear = 0 And GLeapYear = True Then
            GDayOfYear = 366
        End If

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
        Exit Sub
    End Sub

    Public Sub Julian()
        If StarNAFlag = True And BN <> 0 Then
            GHour = 12
            GMinute = 0
            GSecond = 0 'added And BN <> 0 in V5.3.1
        End If

        DecimalDate = GDay + (GHour / 24) + (GMinute / 1440) + (GSecond / 86400.0!)
        DecimalDateHour1 = GDay + (GHour / 24)
        DecimalDateHour2 = GDay + ((GHour + 1) / 24)
        GYearJ = GYear
        If GMonth < 3 Then
            GYearJ = GYear - 1
            GMonth = GMonth + 12
        End If
        JD = Int(365.25 * (GYearJ + 4716)) + Int(30.6001 * (GMonth + 1)) + DecimalDate - 1537.5
        JDHour1 = Int(365.25 * (GYearJ + 4716)) + Int(30.6001 * (GMonth + 1)) + DecimalDateHour1 - 1537.5
        JDHour2 = Int(365.25 * (GYearJ + 4716)) + Int(30.6001 * (GMonth + 1)) + DecimalDateHour2 - 1537.5
        T = (JD - 2451545 + DeltaT / 86400) / 36525.0

        Tfull = T
        THour1 = (JDHour1 - 2451545 + DeltaT / 86400) / 36525.0
        THour2 = (JDHour2 - 2451545 + DeltaT / 86400) / 36525.0
        Exit Sub
    End Sub

    Public Sub DisplaySR()
        If cboBody.SelectedItem.ToString = "Polaris" And cboPolaris.Text = "Latitude by altitude of Polaris" Then
            'cmdEqT.Visible = False
        Else
            'cmdEqT.Visible = True
        End If
        FormatTimeTxtBx()
        FormatLHATxtBox()
        FormatSightTxtBx()
        FormatDecTxtBx()
        FormatAltitudeTxtBx()
        Exit Sub
    End Sub
    Public Sub FormatTimeTxtBx()

        DGTime.Visible = True
        Dim AltHdr As String() = {"Category", "Info1"}
        Dim DataSet1 As DataSet = New DataSet()
        DataSet1.Tables.Add("Table1")
        DataSet1.DataSetName = "Table1"
        DGTime.DataSource = DataSet1
        For i As Integer = 0 To UBound(AltHdr)
            DataSet1.Tables("Table1").Columns.Add(AltHdr(i))
            DataSet1.Tables("Table1").Columns(i).AllowDBNull = False
            DataSet1.Tables("Table1").Columns(i).DefaultValue = ""
        Next
        DGTime.DataSource = DataSet1.Tables(0).DefaultView
        For i As Integer = 0 To DGTime.Columns.Count - 1
            DGTime.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            DGTime.Columns(i).MinimumWidth = 112
            'DGTime.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DGTime.Columns(i).DefaultCellStyle.Font = DGFont 'New Font("Arial", 7, FontStyle.Regular)
        Next
        DGTime.ColumnHeadersVisible = False
        DGTime.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DGTime.DefaultCellStyle.Font = DGFont 'New Font("Arial", 7, FontStyle.Regular)
        DGTime.DefaultCellStyle.BackColor = Color.LightGray
        DGTime.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        DGTime.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGTime.DefaultCellStyle.SelectionBackColor = Color.LightGray
        DGTime.DefaultCellStyle.SelectionForeColor = DGTime.DefaultCellStyle.ForeColor
        'DGTime.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        'DGTime.Columns(0).MinimumWidth = 85
        'DGTime.Columns(1).MinimumWidth = 85
        'DGTime.Columns(1).MinimumWidth = 85

        'Dim tempstr1 As String = ""
        Dim tempstr2 As String = ""
        Dim tempstr3 As String = ""

        ' format TIME data text box
        TimeTxtBx.Clear()
        TimeTxtBx.Font = DGFont 'New Font("Arial", 7, FontStyle.Regular)
        TimeTxtBx.SelectionAlignment = HorizontalAlignment.Center
        TimeTxtBx.Text = "TIME"

        tempstr2 = "Date"
        tempstr3 = DTSight.Value.ToString("dd MMM yyyy")
        DataSet1.Tables("Table1").Rows.Add(tempstr2, tempstr3)

        tempstr2 = "WT"
        tempstr3 = DTSight.Value.ToString("HH-mm-ss")
        DataSet1.Tables("Table1").Rows.Add(tempstr2, tempstr3)

        tempstr2 = "WE" & Space(9) & "("
        If WEinSeconds <> 0 And cboWE.Text = "fast" Then
            tempstr2 &= "-)"
        End If
        If WEinSeconds <> 0 And cboWE.Text = "slow" Then
            tempstr2 &= "+)"
        End If
        If WEinSeconds = 0 Then
            tempstr2 &= " )"
        End If
        tempstr3 = Space(4) & txtWEMin.Text & "-" & Val(txtWESec.Text).ToString("00")
        DataSet1.Tables("Table1").Rows.Add(tempstr2, tempstr3)

        tempstr2 = "ZT"
        tempstr3 = ZTHours.ToString("00") & "-" & ZTMinutes.ToString("00") & "-" & ZTSeconds.ToString("00")
        DataSet1.Tables("Table1").Rows.Add(tempstr2, tempstr3)

        tempstr2 = "ZD" & Space(9) & "("
        If System.Math.Sign(ZD) = 1 Then
            tempstr2 &= "+)"
        End If
        If System.Math.Sign(ZD) = -1 Then
            tempstr2 &= "-)"
        End If
        If System.Math.Sign(ZD) = 0 Then
            tempstr2 &= " )"
        End If
        tempstr3 = Int(System.Math.Abs(ZD)).ToString("#0")

        If optZDManual.Checked = True And cboZDm.Text <> "00" Then
            tempstr3 &= "-" & cboZDm.Text
        End If
        DataSet1.Tables("Table1").Rows.Add(tempstr2, tempstr3)

        tempstr2 = "UT (GMT)" & Space(6)
        tempstr3 = GHour.ToString("00") & "-" & GMinute.ToString("00") & "-" & GSecond.ToString("00")
        DataSet1.Tables("Table1").Rows.Add(tempstr2, tempstr3)

        tempstr2 = "G Day/Mo/Yr" & Space(2)
        tempstr3 = Str(GDay) & Space(1) & MonthatG & Str(GYear)
        DataSet1.Tables("Table1").Rows.Add(tempstr2, tempstr3)

        DGTime.ClearSelection()
        DGTime.CurrentCell = Nothing
        DataSet1.Dispose()
        Exit Sub
    End Sub
    Public Sub FormatSightTxtBx()

        DGSight.Visible = True
        Dim AltHdr As String() = {"Category", "Info1"}
        Dim DataSet1 As DataSet = New DataSet()
        DataSet1.Tables.Add("Table1")
        DataSet1.DataSetName = "Table1"
        DGSight.DataSource = DataSet1
        For i As Integer = 0 To UBound(AltHdr)
            DataSet1.Tables("Table1").Columns.Add(AltHdr(i))
            DataSet1.Tables("Table1").Columns(i).AllowDBNull = False
            DataSet1.Tables("Table1").Columns(i).DefaultValue = ""
        Next
        DGSight.DataSource = DataSet1.Tables(0).DefaultView
        For i As Integer = 0 To DGSight.Columns.Count - 1
            DGSight.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            DGSight.Columns(i).MinimumWidth = 86
            'DGSight.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DGSight.Columns(i).DefaultCellStyle.Font = DGFont 'New Font("Arial", 7, FontStyle.Regular)
        Next
        DGSight.ColumnHeadersVisible = False
        DGSight.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DGSight.DefaultCellStyle.Font = DGFont 'New Font("Arial", 7, FontStyle.Regular)
        DGSight.DefaultCellStyle.BackColor = Color.LightGray
        DGSight.DefaultCellStyle.SelectionBackColor = Color.LightGray
        DGSight.DefaultCellStyle.SelectionForeColor = DGSight.DefaultCellStyle.ForeColor
        DGSight.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        DGSight.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'DGSight.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        'DGSight.Columns(0).MinimumWidth = 85
        'DGSight.Columns(1).MinimumWidth = 85
        'DGSight.Columns(1).MinimumWidth = 85

        'Dim tempstr1 As String = ""
        Dim tempstr2 As String = ""
        Dim tempstr3 As String = ""
        SightTxtBx.Clear()
        SightTxtBx.Font = TxtBxFont
        SightTxtBx.TextAlign = HorizontalAlignment.Center
        SightTxtBx.Font = DGFont 'New Font("Arial", 7, FontStyle.Regular)
        ' Format SIGHT Data text box
        SightTxtBx.Text = "SIGHT DATA"

        tempstr2 = "Sight No."
        tempstr3 = txtSightNo.Text
        DataSet1.Tables("Table1").Rows.Add(tempstr2, tempstr3)

        tempstr2 = "Body "
        tempstr3 = GetValidBodyName()
        DataSet1.Tables("Table1").Rows.Add(tempstr2, tempstr3)

        If BN <> 0 Or (BNBodyName = "Polaris" And cboPolaris.Text <> "Latitude by altitude of Polaris") Or (BNBodyName = "Polaris" And cboPolaris.Text = "Latitude by altitude of Polaris" And (txtLDeg.Text <> "" Or txtLMin.Text <> "")) Then
            tempstr2 = "DR L "
            tempstr3 = Strings.Format(Val(txtLDeg.Text), "0") & Chr(176) & Strings.Format(Val(LMin), "00.0") & "'" & cboL.Text
            DataSet1.Tables("Table1").Rows.Add(tempstr2, tempstr3)
        End If
        tempstr2 = "DR Lo"
        tempstr3 = Strings.Format(Val(txtLoDeg.Text), "0") & Chr(176) & Strings.Format(Val(LoMin), "00.0") & "'" & cboLo.Text
        DataSet1.Tables("Table1").Rows.Add(tempstr2, tempstr3)
        DGSight.ClearSelection()
        DGSight.CurrentCell = Nothing
        DataSet1.Dispose()

        Exit Sub
    End Sub

    Public Sub FormatAltitudeTxtBx()

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
            'DGAlt.Columns(i).MinimumWidth = 86
            'DGAlt.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DGAlt.Columns(i).DefaultCellStyle.Font = DGFont 'New Font("Arial", 7, FontStyle.Regular)
        Next
        DGAlt.ColumnHeadersVisible = False
        DGAlt.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DGAlt.DefaultCellStyle.Font = DGFont 'New Font("Arial", 7, FontStyle.Regular)
        DGAlt.DefaultCellStyle.BackColor = Color.LightGray
        DGAlt.DefaultCellStyle.SelectionBackColor = Color.LightGray
        DGAlt.DefaultCellStyle.SelectionForeColor = DGAlt.DefaultCellStyle.ForeColor
        DGAlt.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        DGAlt.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGAlt.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'DGAlt.DefaultCellStyle.WrapMode = DataGridViewTriState.True

        DGAlt.Columns(0).MinimumWidth = 85
        DGAlt.Columns(1).MinimumWidth = 85
        DGAlt.Columns(2).MinimumWidth = 85

        Dim tempstr1 As String = ""
        Dim tempstr2 As String = ""
        Dim tempstr3 As String = ""

        AltitudeTxtBx.Font = DGFont 'New Font("Arial", 7, FontStyle.Regular)
        ' Format ALTITUDE text box 
        AltitudeTxtBx.SelectionAlignment = HorizontalAlignment.Center
        AltitudeTxtBx.Text = "ALTITUDE"

        tempstr1 = "Ht of eye"
        If optHorizonArtificial.Checked = False Then
            tempstr2 = HE.ToString("0.0")
            If cboHE.Text = "ft" Or cboHE.Text = "in" Then tempstr2 &= "ft"
            If cboHE.Text = "m " Or cboHE.Text = "cm" Then tempstr2 &= "m"
        End If
        tempstr3 = ""
        DataSet1.Tables("Table1").Rows.Add(tempstr1, tempstr2, tempstr3)

        tempstr1 = "hs"
        tempstr2 = ""
        tempstr3 = ""
        tempstr3 = Val(txtHsDeg.Text).ToString("0") & Chr(176) & HsMin.ToString("00.0") & "'"
        DataSet1.Tables("Table1").Rows.Add(tempstr1, tempstr2, tempstr3)

        tempstr1 = Space(4) & "IC"
        tempstr2 = "("
        tempstr3 = ""
        If ICinMinutes = 0 Then
            tempstr2 &= " "
        End If
        If cboIE.Text = "on the arc" And ICinMinutes <> 0 Then
            tempstr2 &= "-"
        End If
        If (cboIE.Text = "off the arc (rdg.)" Or cboIE.Text = "off the arc (val.)") And ICinMinutes <> 0 Then
            tempstr2 &= "+"
        End If
        tempstr2 &= ")" & Space(1)
        If (cboIE.Text = "on the arc" Or cboIE.Text = "off the arc (val.)") Then
            tempstr2 &= Val(txtIEdeg.Text).ToString("0")
        ElseIf cboIE.Text = "off the arc (rdg.)" Then
            tempstr2 &= Val((txtIEdeg.Text) - 1).ToString("0")
        Else
            tempstr2 &= "0"
        End If
        tempstr2 &= Chr(176) & ICMin.ToString("00.0") & "'"
        DataSet1.Tables("Table1").Rows.Add(tempstr1, tempstr2, tempstr3)

        tempstr1 = Space(4) & "Dip"
        If optHorizonArtificial.Checked = False Then
            tempstr2 = "(-) 0" & Chr(176) & Dip().ToString("00.0") & "'"
        Else
            tempstr2 = ""
        End If
        tempstr3 = ""
        DataSet1.Tables("Table1").Rows.Add(tempstr1, tempstr2, tempstr3)

        tempstr1 = "Total Corr"
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
            tempstr3 &= "(-)"
        Else
            tempstr3 &= " "
        End If
        tempstr3 &= (System.Math.Abs(haDeg)).ToString("0") & Chr(176) & haMin.ToString("00.0") & "'"
        DataSet1.Tables("Table1").Rows.Add(tempstr1, tempstr2, tempstr3)

        tempstr1 = vbTab & "HP Moon"
        If BNType = "Moon" Then
            tempstr2 = ((HPA * 10 + 0.5) / 10).ToString("00.0") & "'"
        Else
            tempstr2 = ""
        End If
        tempstr3 = ""
        DataSet1.Tables("Table1").Rows.Add(tempstr1, tempstr2, tempstr3)

        If optHoParameters.Checked Then
            tempstr1 = Space(4) & "Refraction" & Space(4) &
            tempstr2 = "(-)" & Space(3 - (Int(System.Math.Abs(r))).ToString.Length) & (Int(System.Math.Abs(r) * 1000 + 0.5) / 1000).ToString("0.000") & "'"
            tempstr3 = ""
            DataSet1.Tables("Table1").Rows.Add(tempstr1, tempstr2, tempstr3)
        End If
        If optHoSRForm.Checked Then
            tempstr1 = Space(4) & "Main"
            tempstr2 = "("
        End If
        If optHoSRForm.Checked And Main_Corr > 0 Then
            tempstr2 &= "+"
        End If
        If optHoSRForm.Checked And Main_Corr = 0 Then
            tempstr2 &= " "
        End If
        If optHoSRForm.Checked And Main_Corr < 0 Then
            tempstr2 &= "-"
        End If
        If optHoSRForm.Checked Then
            tempstr2 &= ")"
            tempstr2 &= Space(4 - Len(Str(Int(Main_Corr)))) & System.Math.Round(System.Math.Abs(Main_Corr), 2, MidpointRounding.AwayFromZero).ToString("00.0") & "'"
            DataSet1.Tables("Table1").Rows.Add(tempstr1, tempstr2, tempstr3)
        End If
        If optHoParameters.Checked Then
            tempstr1 = Space(4) & "Parallax"
            tempstr2 = "(+)" & Space(4 - Len(Str(Int(PA)))) & PA.ToString("0.000") & "'"
            tempstr3 = ""
            DataSet1.Tables("Table1").Rows.Add(tempstr1, tempstr2, tempstr3)
        End If
        If optHoSRForm.Checked Then
            If (BNBodyName = "Venus" Or BNBodyName = "Mars" Or BNType = "Moon") Then ' for Mars, Venus, or the Moon
                tempstr1 = Space(4) & "Add'l (+)"
                tempstr2 = Addl.ToString("00.0") & "'"
                tempstr3 = ""
                DataSet1.Tables("Table1").Rows.Add(tempstr1, tempstr2, tempstr3)
            Else
                tempstr1 = ""
                tempstr2 = ""
                tempstr3 = ""
            End If
        End If

        If optCenter.Checked Then tempstr1 = ""
        If (optLower.Checked Or optUpper.Checked) And optHoParameters.Checked Then
            tempstr1 = Space(4) & "Semi-diameter" & Space(1) & "("
        End If
        If optHoParameters.Checked And (optLower.Checked Or optUpper.Checked) Then
            If (BN = 62 Or BN = 64) Then tempstr1 &= "+)" ' lower limb sun or moon
            If (BN = 63 Or BN = 65) Then tempstr1 &= "-)" ' upper limb sun or moon
            If (BN < 62 Or BN > 65) Then tempstr1 &= " )" 'planets or stars
            tempstr1 &= Space(1) & DI.ToString("00.000") & "'"
        End If
        If optHoSRForm.Checked And (BNType = "Moon") Then 'And chkAH.CheckState = 0 Then
            If optUpper.Checked Or optLower.Checked Then
                tempstr1 = Space(4) & "UL ( -30.0')" 'always prints label if SR format except if artificial horizon with superimposition

                If optUpper.Checked = True Then
                    tempstr2 = Space(3) & "(-)" & Space(3) & "30.0'"
                Else
                    tempstr2 = ""
                End If
                tempstr3 = ""
                DataSet1.Tables("Table1").Rows.Add(tempstr1, tempstr2, tempstr3)
            End If
        End If
        If optHoSRForm.Checked And (BNType = "Moon") And optHorizonArtificial.Checked And optCenter.Checked Then 'And chkAH.CheckState = 1 Then
            tempstr1 = Space(4) & "AH ( superimp." & "(-)" & Space(3) & "15.0'" 'artificial horizon with superimposition
        End If
        If optHoSRForm.Checked And (BNType = "Moon") And optHorizonArtificial.Checked = False And optCenter.Checked Then     'bubble sextant
            tempstr1 = Space(4) & "Bubble sextant" & "(-)" & Space(3) & "15.0'"
        End If

        'If optHoSRForm.Checked And (BNType <> "Moon") And (optUpper.Checked Or optLower.Checked) Then 'And chkAH.CheckState <> 1 Then
        '    tempstr1 &= ")"
        '    tempstr2 = ""
        '    tempstr3 = ""
        '    DataSet1.Tables("Table1").Rows.Add(tempstr1, tempstr2, tempstr3)
        'End If
        If optHoParameters.Checked And optCenter.Checked Then
            tempstr1 &= ")"
            tempstr2 = ""
            tempstr3 = ""
            DataSet1.Tables("Table1").Rows.Add(tempstr1, tempstr2, tempstr3)
        End If

        If optHoParameters.Checked And (BNType = "Moon") And (optLower.Checked Or optUpper.Checked) Then 'And chkAH.CheckState = 0 Then
            tempstr1 = Space(4) & "Augmentation"
            tempstr2 = "("
            If optHoParameters.Checked And BN = 62 Then tempstr2 &= "+)" ' Moon lower limb
            If optHoParameters.Checked And BN = 63 Then tempstr2 &= "-)" ' Moon upper limb
            If optHoParameters.Checked Then tempstr1 = Space(2) & Aug.ToString("0.000") & "'"
            DataSet1.Tables("Table1").Rows.Add(tempstr1, tempstr2, tempstr3)
        End If

        tempstr1 = ""
        tempstr2 = ""
        tempstr3 = ""
        If optHoParameters.Checked And BN = 65 And GYear >= 1954 And GYear <= 1969 Then tempstr1 = Space(4) & "Irradiation   (-)    1.2'"
        DataSet1.Tables("Table1").Rows.Add(tempstr1, tempstr2, tempstr3)

        'If optHoParameters.Checked And BN = 64 And GYear >= 1954 And GYear <= 1969 Then tempstr1 = 
        If optHoSRForm.Checked Then
            tempstr1 = Space(4) & "Add'l Ref"
            tempstr2 = ""
            tempstr3 = ""
            DataSet1.Tables("Table1").Rows.Add(tempstr1, tempstr2, tempstr3)
        End If
        If optHoSRForm.Checked And optStdTPNo.Checked = True Then
            tempstr1 = "T&B Corr"

            If System.Math.Sign(Raddl) = 1 Then
                tempstr2 = "(-)" & Space(4) & System.Math.Abs(Raddl).ToString("0.0") & "'"
            End If
            If System.Math.Sign(Raddl) = -1 Then
                tempstr2 = "(+)" & Space(4) & System.Math.Abs(Raddl).ToString("0.0") & "'"
            End If
            If System.Math.Sign(Raddl) = 0 Then
                tempstr2 = "( )" & Space(4) & System.Math.Abs(Raddl).ToString("0.0") & "'"
            End If
            tempstr3 = ""
            DataSet1.Tables("Table1").Rows.Add(tempstr1, tempstr2, tempstr3)
        End If
        'If optHoParameters.Checked And (GYear < 1954 Or GYear > 1969) Then
        '    DataSet1.Tables("Table1").Rows.Add(tempstr1, tempstr2, tempstr3)
        'End If

        tempstr1 = "Total Corr"
        tempstr2 = "("
        If Corr2Min > 0 Then tempstr2 &= "+"
        If Corr2Min = 0 Then tempstr2 &= " "
        If Corr2Min < 0 Then tempstr2 &= "-"
        LenCorr2Min = Len((System.Math.Abs(Corr2Min)).ToString("00.0"))
        If Corr2Min - Int(Corr2Min) = 0 Then
            LenCorr2Min = LenCorr2Min + 2
        End If
        If LenCorr2Min < 4 Then
            LenCorr2Min = 4
        End If
        tempstr2 &= ")" & Space(8 - LenCorr2Min) & System.Math.Abs(Corr2Min).ToString("00.0") & "'"
        DataSet1.Tables("Table1").Rows.Add(tempstr1, tempstr2, tempstr3)

        tempstr1 = "Ho"
        tempstr2 = ""
        tempstr3 = ""
        If System.Math.Sign(HoinMinutes) = -1 Then
            tempstr3 &= "-"
        Else
            tempstr3 &= " "
        End If
        tempstr3 = System.Math.Abs(HoDeg).ToString("0") & Chr(176) & System.Math.Abs(HoMin).ToString("00.0") & "'"
        DataSet1.Tables("Table1").Rows.Add(tempstr1, tempstr2, tempstr3)

        If optHorizonArtificial.Checked = True Then
            tempstr1 = "ha adjusted for artificial horizon"
            tempstr2 = ""
            tempstr3 = ""
            DataSet1.Tables("Table1").Rows.Add(tempstr1, tempstr2, tempstr3)
        End If
        If BackSight = True And optHorizonArtificial.Checked = False Then
            tempstr1 = "ha adjusted for back sight"
            tempstr2 = ""
            tempstr3 = ""
            DataSet1.Tables("Table1").Rows.Add(tempstr1, tempstr2, tempstr3)
        End If
        DGAlt.ClearSelection()
        DGAlt.CurrentCell = Nothing
        DataSet1.Dispose()

        Exit Sub
    End Sub
    Public Sub FormatLHATxtBox()

        DGLHA.Visible = True
        Dim AltHdr As String() = {"Category", "Info1"}
        Dim DataSet1 As DataSet = New DataSet()
        DataSet1.Tables.Add("Table1")
        DataSet1.DataSetName = "Table1"
        DGLHA.DataSource = DataSet1
        For i As Integer = 0 To UBound(AltHdr)
            DataSet1.Tables("Table1").Columns.Add(AltHdr(i))
            DataSet1.Tables("Table1").Columns(i).AllowDBNull = False
            DataSet1.Tables("Table1").Columns(i).DefaultValue = ""
        Next
        DGLHA.DataSource = DataSet1.Tables(0).DefaultView
        For i As Integer = 0 To DGLHA.Columns.Count - 1
            DGLHA.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            DGLHA.Columns(i).MinimumWidth = 112
            'DGLHA.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DGLHA.Columns(i).DefaultCellStyle.Font = DGFont 'New Font("Arial", 7, FontStyle.Regular)
        Next
        DGLHA.ColumnHeadersVisible = False
        DGLHA.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DGLHA.DefaultCellStyle.Font = DGFont 'New Font("Arial", 7, FontStyle.Regular)
        DGLHA.DefaultCellStyle.BackColor = Color.LightGray
        DGLHA.DefaultCellStyle.SelectionBackColor = Color.LightGray
        DGLHA.DefaultCellStyle.SelectionForeColor = DGLHA.DefaultCellStyle.ForeColor
        DGLHA.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        DGLHA.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'DGLHA.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        'DGLHA.Columns(0).MinimumWidth = 85
        'DGLHA.Columns(1).MinimumWidth = 85

        'Dim tempstr1 As String = ""
        Dim tempstr2 As String = ""
        Dim tempstr3 As String = ""

        LHATxtBx.Font = DGFont 'New Font("Arial", 7, FontStyle.Regular)
        ' format Almanac/LHA text box data
        LHATxtBx.SelectionAlignment = HorizontalAlignment.Center
        LHATxtBx.Text = "ALMANAC - LHA"

        tempstr2 = "SHA *"
        If BNType = "Stars" And BN <> 0 And StarNAFlag = True Then ' object is a star but not Polaris
            tempstr3 = SHdegDisplay.ToString("0") & Chr(176) & SHminDisplay.ToString("00.0") & "'"
        End If
        If BNType = "Stars" And BN <> 0 And StarNAFlag = False Then
            tempstr3 = SHdeg.ToString("0") & Chr(176) & SHmin.ToString("00.0") & "'"
        End If
        If BNBodyName = "Polaris" And cboPolaris.Text = "Full reduction of Polaris sight" Then
            tempstr3 = SHdeg.ToString("0") & Chr(176) & SHmin.ToString("00.0") & "'"
        End If
        DataSet1.Tables("Table1").Rows.Add(tempstr2, tempstr3)

        tempstr2 = "GHA "
        Select Case BNType
            Case "Stars"
                tempstr2 &= "Aries"
            Case "Planets"
                tempstr2 &= cboBody.SelectedItem.ToString
            Case "Moon"
                tempstr2 &= "Moon"
            Case "Sun"
                tempstr2 &= "Sun"
            Case Else
                tempstr2 &= "??? Type"
        End Select
        'If BNType = "Stars" Then
        '    tempstr2 &= "Aries"
        'End If
        'If BNType = "Planets" Then
        '    tempstr2 &= cboBody.SelectedItem.ToString
        'End If
        'If BNType = "Moon" Then
        '    tempstr2 &= "Moon"
        'End If
        'If BNType = "Sun" Then
        '    tempstr2 &= "Sun"
        'End If
        tempstr3 = ""
        DataSet1.Tables("Table1").Rows.Add(tempstr2, tempstr3)

        Dim fmtstrint As Integer = GHAHourDeg1.ToString("0").Length


        tempstr2 = GHour.ToString("00") & Space(1) & "hr"
        tempstr3 = GHAHourDeg1.ToString("#00") & Chr(176) & GHAHourMin1.ToString("00.0") & "'"
        DataSet1.Tables("Table1").Rows.Add(tempstr2, tempstr3)

        tempstr2 = Space(8) & GMinute.ToString("00") & Space(1) & "m" & Space(1) & GSecond.ToString("00") & Space(1) & "s"
        If (GMinute + GSecond <> 0) Then
            tempstr3 = Space(2) & GHAIncrementDeg.ToString("#00") & Chr(176) & GHAIncrementMin.ToString("00.0") & "'"
        Else
            tempstr3 = ""
        End If
        DataSet1.Tables("Table1").Rows.Add(tempstr2, tempstr3)

        tempstr2 = "v ("
        If SignHourChange = 0 Or ((BN = 64 Or BN = 65) And cboSun.Text = "NA val. of hourly GHA/d") Or BN <= 57 Or (GMinute = 0 And GSecond = 0) Then
            tempstr2 &= " ) "
        ElseIf SignHourChange = 1 Then
            tempstr2 &= "+) "
        ElseIf SignHourChange = -1 Then
            tempstr2 &= "-) "
        End If
        If ((BNType = "Sun" And cboSun.Text = "Accurate val. of hourly GHA") Or (BNType = "Planets" Or BNType = "Moon") And (GMinute + GSecond <> 0)) Then
            tempstr2 &= System.Math.Abs(vvalue).ToString("0.0") & "'" 'add this for no v or d for whole hour:  And (GMinute + GSecond <> 0)
        Else
            tempstr2 &= ""
        End If
        tempstr3 = ""
        DataSet1.Tables("Table1").Rows.Add(tempstr2, tempstr3)

        Lenvcorr = Len(Str(System.Math.Abs(vcorr)))
        If Lenvcorr < 4 Then Lenvcorr = 4
        tempstr2 = Space(7) & "v corr ("
        If SignHourChange = 0 Or ((BNType = "Sun") And cboSun.Text = "NA val. of hourly GHA/d") Or BNType = "Stars" Or (GMinute = 0 And GSecond = 0) Then 'add this for no v or d for whole hour:  Or (GMinute = 0 And GSecond = 0)
            tempstr2 &= " ) " 'Tab(40); "ALMANAC - Dec"    'sun or stars
        ElseIf SignHourChange = 1 Then
            tempstr2 &= "+) "
        ElseIf SignHourChange = -1 Then
            tempstr2 &= "-) "
        End If
        If ((BNType = "Sun") And cboSun.Text = "Accurate val. of hourly GHA") Or (BN > 57 And BN < 64) And (GMinute + GSecond <> 0) Then
            tempstr3 = Space(7) & System.Math.Abs(vcorr).ToString("0.0") & "'"
        End If
        DataSet1.Tables("Table1").Rows.Add(tempstr2, tempstr3)

        If BNBodyName = "Polaris" And cboPolaris.Text = "Latitude by altitude of Polaris" Then
            tempstr2 = "Tot GHA"
            tempstr3 = TotGHAPolDeg.ToString("0") & Chr(176) & TotGHAPolMin.ToString("00.0") & "'"
        Else
            tempstr2 = "Tot GHA"
            tempstr3 = TotGHADeg.ToString("0") & Chr(176) & TotGHAMin.ToString("00.0") & "'"
        End If
        DataSet1.Tables("Table1").Rows.Add(tempstr2, tempstr3)

        tempstr2 = "DR Lo ("
        If Lo <> 0 And cboLo.Text = "W" Then tempstr2 &= "-"
        If Lo <> 0 And cboLo.Text = "E" Then tempstr2 &= "+"
        If Lo = 0 Then tempstr2 &= " "
        tempstr2 &= ")"
        tempstr3 = Val(txtLoDeg.Text).ToString("0") & Chr(176) & Val(LoMin).ToString("00.0") & "'"
        If Lo <> 0 Then tempstr3 &= cboLo.Text
        DataSet1.Tables("Table1").Rows.Add(tempstr2, tempstr3)

        If BNBodyName = "Polaris" And cboPolaris.Text = "Latitude by altitude of Polaris" Then
            tempstr2 = "LHA"
            tempstr3 = LHAPolDeg.ToString("0") & Chr(176) & LHAPolMin.ToString("00.0") & "'"
        Else
            tempstr2 = "LHA"
            tempstr3 = LHADeg.ToString("0") & Chr(176) & LHAMin.ToString("00.0") & "'"
        End If
        DataSet1.Tables("Table1").Rows.Add(tempstr2, tempstr3)

        DGLHA.ClearSelection()
        DGLHA.CurrentCell = Nothing
        DataSet1.Dispose()
        Exit Sub
        'tempstr2 = vbNewLine)
    End Sub
    Public Sub FormatDecTxtBx()

        DGDec.Visible = True
        Dim AltHdr As String() = {"Category", "Info1"}
        Dim DataSet1 As DataSet = New DataSet()
        DataSet1.Tables.Add("Table1")
        DataSet1.DataSetName = "Table1"
        DGDec.DataSource = DataSet1
        For i As Integer = 0 To UBound(AltHdr)
            DataSet1.Tables("Table1").Columns.Add(AltHdr(i))
            DataSet1.Tables("Table1").Columns(i).AllowDBNull = False
            DataSet1.Tables("Table1").Columns(i).DefaultValue = ""
        Next
        DGDec.DataSource = DataSet1.Tables(0).DefaultView
        For i As Integer = 0 To DGDec.Columns.Count - 1
            DGDec.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            DGDec.Columns(i).MinimumWidth = 86
            'DGDec.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DGDec.Columns(i).DefaultCellStyle.Font = DGFont 'New Font("Arial", 7, FontStyle.Regular)
        Next
        DGDec.ColumnHeadersVisible = False
        DGDec.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DGDec.DefaultCellStyle.Font = DGFont 'New Font("Arial", 7, FontStyle.Regular)
        DGDec.DefaultCellStyle.BackColor = Color.LightGray
        DGDec.DefaultCellStyle.SelectionBackColor = Color.LightGray
        DGDec.DefaultCellStyle.SelectionForeColor = DGDec.DefaultCellStyle.ForeColor
        DGDec.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        DGDec.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'DGDec.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        'DGDec.Columns(0).MinimumWidth = 85
        'DGDec.Columns(1).MinimumWidth = 85
        'DGDec.Columns(1).MinimumWidth = 85

        'Dim tempstr1 As String = ""
        Dim tempstr2 As String = ""
        Dim tempstr3 As String = ""

        DecTxtBx.Clear()
        DecTxtBx.Font = DGFont 'New Font("Arial", 7, FontStyle.Regular)
        ' format Almanac DEC text box data
        DecTxtBx.TextAlign = HorizontalAlignment.Center
        DecTxtBx.Text = "ALMANAC - Dec"

        If BNType = "Stars" Then
            tempstr2 = "Dec " & Space(4) & "hr"
        Else
            tempstr2 = "Dec " & GHour.ToString("00") & " hr"
            tempstr3 = (System.Math.Abs(DecDegrees)).ToString("0") & Chr(176) & DecMinutes.ToString("00.0") & "'"
            If DE1 > 0 Then tempstr3 &= g_LatN
            If DE1 = 0 Then tempstr3 &= " "
            If DE1 < 0 Then tempstr3 &= g_LatS
        End If
        DataSet1.Tables("Table1").Rows.Add(tempstr2, tempstr3)

        tempstr2 = "d (" 'stars have no d correction
        If Signdvalue = 0 Or BN <= 57 Or (GMinute = 0 And GSecond = 0) Then 'add this for no v or d for whole hour:  Or (GMinute = 0 And GSecond = 0)
            tempstr2 &= " ) "
        ElseIf Signdvalue = 1 Then
            tempstr2 &= "+) "
        ElseIf Signdvalue = -1 Then
            tempstr2 &= "-) "
        End If
        If BNType <> "Stars" And (GMinute + GSecond <> 0) Then
            tempstr2 &= System.Math.Abs(dvalue).ToString("0.0") & "'"
        Else
            tempstr2 &= ""
        End If
        tempstr3 = ""
        DataSet1.Tables("Table1").Rows.Add(tempstr2, tempstr3)

        Lendcorr = Len(Str(dcorr))
        If Lendcorr < 4 Then
            Lendcorr = 4
        End If
        tempstr2 = Space(4) & "d corr ("
        If Signdvalue = 0 Or BN <= 57 Or (GMinute = 0 And GSecond = 0) Then 'add this for no v or d for whole hour:  Or (GMinute = 0 And GSecond = 0)
            tempstr2 &= " ) "
        ElseIf Signdvalue = 1 Then
            tempstr2 &= "+) "
        ElseIf Signdvalue = -1 Then
            tempstr2 &= "-) "
        End If
        If BNType <> "Stars" And (GMinute + GSecond <> 0) Then
            tempstr3 = Space(7 - Lendcorr) & dcorr.ToString("0.0") & "'" 'add this for no v or d for whole hour:  And (GMinute + GSecond <> 0)
        Else
            tempstr3 = ""
        End If
        DataSet1.Tables("Table1").Rows.Add(tempstr2, tempstr3)

        tempstr2 = "Dec"
        tempstr3 = System.Math.Abs(TotDecDegrees).ToString("0") & Chr(176) & TotDecMinutes.ToString("00.0") & "'"
        If TotDE > 0 Then tempstr3 &= g_LatN
        If TotDE = 0 Then tempstr3 &= " "
        If TotDE < 0 Then tempstr3 &= g_LatS

        DataSet1.Tables("Table1").Rows.Add(tempstr2, tempstr3)
        DGDec.ClearSelection()
        DGDec.CurrentCell = Nothing
        DataSet1.Dispose()

        Exit Sub
    End Sub

    Public Function Dip() As Double
        HE = Val(txtHE.Text)
        If cboHE.Text = "ft" Then
            HEinFeet = HE
        End If
        If cboHE.Text = "m " Then
            HEinFeet = HE * 3.28095
        End If
        If cboHE.Text = "in" Then
            HEinFeet = HE / 12
        End If
        If cboHE.Text = "cm" Then
            HEinFeet = HE * 0.0328095
        End If
        If cboHE.Text = "ft" Or cboHE.Text = "m " Then
            HE = Int(HE * 10 + 0.5) / 10
        End If
        If cboHE.Text = "in" Then
            HE = Int((HE / 12) * 10 + 0.5) / 10
        End If
        If cboHE.Text = "cm" Then
            HE = Int((HE / 100) * 10 + 0.50000001) / 10
        End If

        DipShortDist = Val(txtDsDist.Text)
        'Convert distance to dip short horizon to nautical miles
        If cboDsUnit.Text = "feet" Then
            DipShortDist = DipShortDist / 6076.1
        End If
        If cboDsUnit.Text = "yards" Then
            DipShortDist = DipShortDist * 3 / 6076.1
        End If
        If cboDsUnit.Text = "meters" Then
            DipShortDist = DipShortDist / 1852
        End If
        If cboDsUnit.Text = "statute miles" Then
            DipShortDist = DipShortDist * 5280 / 6076.1
        End If
        'Check if dip short distance is greater than distance to natural horizon
        If optHorizonDipShort.Checked = True And DipShortDist > 1.169 * System.Math.Sqrt(HEinFeet) Then
            SendMsgBx("Dip short distance exceeded distance to natural horizon.  Natural horizon will be used.", MessageBoxIcon.Information)
            optHorizonNatural.Checked = True
            txtDsDist.Clear()
        End If
        If optHorizonDipShort.Checked = True Then
            Dip = (10800 / Pi) * System.Math.Atan(HEinFeet / (6076.1 * DipShortDist) + 0.8321 * DipShortDist / 6880.2)
        End If

        'Convert C to F
        Temperature = Val(txtTemperature.Text)
        If cboTemperature.Text = "C " Then
            Temperature = (5 / 9) * (Temperature - 32)
        End If
        'Convert mbar to in Hg
        Pressure = Val(txtPressure.Text)
        If cboPressure.Text = "mbar" Then
            Pressure = 33.858532 * Pressure
        End If
        'Calculate dip
        If optHorizonNatural.Checked = True And (cboHE.Text = "ft" Or cboHE.Text = "in") Then
            Select Case HE
                Case Is < 2
                    Dip = 0.7 * HE
                Case Is <= 3.9
                    Dip = 1.4 + (HE - 2) * 0.25
                Case Is <= 5.9
                    Dip = 1.9 + (HE - 4) * 0.25
                Case Is <= 7.6
                    Dip = 2.4 + (HE - 6) * 0.15
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
        Dip = Int(Dip * 10 + 0.500000000001) / 10
    End Function

    Public Sub Obliquity()
        'Obliquity of the ecliptic
        OE = 84381.448 - 46.816 * T - 0.00059 * T * T + 0.001813 * T * T * T 'Mean obliquity of ecliptic, arcseconds
        OE = OE / 3600 'degrees
        OETrue = OE + NO 'degrees
        Exit Sub
    End Sub


    Public Sub Nutation()
        NL = 0 : NO = 0

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
    Public Sub Stars()
        AR = RA(BN)
        DE = Dec(BN)
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
        Exit Sub
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

    Public Sub EclipticToEquatorial()
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
        'AR = AR * 180 / Pi
        'DE = DE * 180 / Pi
    End Sub
    Public Sub Sun()
        Ecc = 0.016708634 - 0.000042037 * T - 0.0000001267 * T * T 'Ecc of Earth's orbit
        MS = 357.52911 + 35999.05029 * T - 0.0001537 * T * T 'mean anomaly of Sun, degrees
        If MS >= 360 Or MS < 0 Then MS = MS - Int(MS / 360) * 360
        C = (1.914602 - 0.004817 * T - 0.000014 * T * T) * System.Math.Sin(MS * Pi / 180) + (0.019993 - 0.000101 * T) * System.Math.Sin(2 * MS * Pi / 180) + 0.000289 * System.Math.Sin(3 * MS * Pi / 180) 'center of Sun, degrees
        NU = MS + C 'Sun's true anomaly, degrees
        RN = (1.000001018 * (1 - Ecc * Ecc)) / (1 + Ecc * System.Math.Cos(NU * Pi / 180)) 'Sun's radius vector (distance between centers of Sun and Earth), astronomical units
        L0 = 280.46646 + 36000.76983 * T + 0.0003032 * T * T 'geometric mean longitude of Sun, degrees
        If L0 >= 360 Or L0 < 0 Then L0 = L0 - Int(L0 / 360) * 360
        LN = L0 + C 'Sun's true longitude, degrees
        If BN <> 64 And BN <> 65 Then Exit Sub 'no need to go further if not sun sight
        T = T / 10
        ' Compute heliocentric, ecliptical Longitude L in radians
        L = Earth_L01(T) + Earth_L02(T) + Earth_L11(T) + Earth_L21(T) + Earth_L31(T) + Earth_L41(T) + Earth_L51(T) 'radians
        If System.Math.Abs(L) > (2 * Pi) Then L = L - 2 * Pi * Int(L / 2 / Pi)
        ' Compute heliocentric, ecliptical Latitude B in radians
        B = Earth_B01(T) + Earth_B11(T) + Earth_B21(T) + Earth_B31(T) + Earth_B41(T) 'radians
        ' Compute heliocentric distance R in AU
        r = Earth_R01(T) + Earth_R02(T) + Earth_R11(T) + Earth_R21(T) + Earth_R31(T) + Earth_R41(T) + Earth_R51(T)
        L1 = L + Pi 'geocentric longitude, radians
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
        DI = System.Math.Atan(0.00465424336 / RN) * 180 / Pi * 60
        'back to normal T
        T = 10 * T
    End Sub

    Public Sub HourAngles()
        SH = 360 - AR
        SHdeg = Int(SH)
        SHmin = (SH - SHdeg) * 60
        SHmin = Int(SHmin * 10 + 0.5) / 10
        If SHmin = 60 Then
            SHmin = 0
            SHdeg = SHdeg + 1
        End If

        If StarNAFlag = True Then 'this must be True for SHA to remain constant throughout a day
            SHdegDisplay = SHdeg
            SHminDisplay = SHmin
            'SH = SHdegDisplay + SHminDisplay / 60
        End If

        HG = UTinSeconds / 3600
        GHAAries = 280.46061837 + 360.98564736629 * (JD - 2451545) + 0.000387933 * T * T - T * T * T / 38710000 'mean GHA of Aries, degrees, only used for Time Diagram
        GHAAries = GHAAries + NL * System.Math.Cos(OETrue) 'true GHA of Aries, degrees
        If GHAAries >= 360 Or GHAAries < 0 Then
            GHAAries = GHAAries - Int(GHAAries / 360) * 360
        End If
        GHAAriesDeg = Int(GHAAries)
        GHAAriesMin = (GHAAries - GHAAriesDeg) * 60
        GHAAriesMin = Int(GHAAriesMin * 10 + 0.5) / 10
        If GHAAriesMin = 60 Then
            GHAAriesMin = 0
            GHAAriesDeg = GHAAriesDeg + 1
        End If

        'If BN <= 57 Then GHA = GHAAries Else GHA = SH + GHAAries
        'The next three V5.6.2 changes made to correct fixes when a body was a planet
        If BN <= 57 Then
            GHA = GHAAriesDeg + GHAAriesMin / 60            'V5.6.2
        End If
        'If BN<=58 and BN<=61 then use TotGHA from IandC or IandCP      'V5.6.2
        If BN > 61 Then
            GHA = SHdeg + SHmin / 60 + GHAAriesDeg + GHAAriesMin / 60       'V5.6.2
        End If
        If GHA >= 360 Or GHA < 0 Then
            GHA = GHA - Int(GHA / 360) * 360
        End If
        If BN <= 57 Then
            TotGHA = SH + GHA
        Else
            TotGHA = GHA
        End If
        If TotGHA >= 360 Or TotGHA < 0 Then
            TotGHA = TotGHA - Int(TotGHA / 360) * 360
        End If
        TotGHAPol = TotGHA - SH
        If TotGHAPol >= 360 Then
            TotGHAPol = TotGHAPol - 360
        End If
        If TotGHAPol < 0 Then
            TotGHAPol = TotGHAPol + 360
        End If
        TotGHAPolDeg = Int(TotGHAPol)
        TotGHAPolMin = (TotGHAPol - TotGHAPolDeg) * 60
        If Int(TotGHAPolMin * 10 + 0.5) / 10 = 60 Then
            TotGHAPolMin = 0
            TotGHAPolDeg = TotGHAPolDeg + 1
        End If
        LHA = TotGHA - Lo
        If LHA >= 360 Then
            LHA = LHA - 360
        End If
        If LHA < 0 Then
            LHA = LHA + 360
        End If
        LHAPol = LHA - SH
        If LHAPol >= 360 Then
            LHAPol = LHAPol - 360
        End If
        If LHAPol < 0 Then
            LHAPol = LHAPol + 360
        End If
        TotGHADeg = Int(TotGHA)
        TotGHAMin = (TotGHA - TotGHADeg) * 60
        If Int(TotGHAMin * 10 + 0.5) / 10 = 60 Then
            TotGHAMin = 0
            TotGHADeg = TotGHADeg + 1
        End If
        If TotGHADeg >= 360 Then
            TotGHADeg = TotGHADeg - 360
        End If
        LHADeg = Int(LHA)
        LHAMin = (LHA - LHADeg) * 60
        If Int(LHAMin * 10 + 0.5) / 10 = 60 Then
            LHAMin = 0
            LHADeg = LHADeg + 1
        End If
        LHAPolDeg = Int(LHAPol)
        LHAPolMin = (LHAPol - LHAPolDeg) * 60
        If Int(LHAPolMin * 10 + 0.5) / 10 = 60 Then
            LHAPolMin = 0
            LHAPolDeg = LHAPolDeg + 1
        End If
        If LHAPolDeg >= 360 Then
            LHAPolDeg = LHAPolDeg - 360
        End If
        Exit Sub
    End Sub

    Public Sub HourAnglesHour()
        SH = 360 - AR
        GHAAriesHour = 280.46061837 + 360.98564736629 * (JDHour - 2451545) + 0.000387933 * T * T - T * T * T / 38710000 'mean GHA of Aries, degrees
        GHAAriesHour = GHAAriesHour + NL * System.Math.Cos(OETrue * Pi / 180) 'true GHA of Aries, degrees
        If GHAAriesHour >= 360 Or GHAAriesHour < 0 Then
            GHAAriesHour = GHAAriesHour - Int(GHAAriesHour / 360) * 360
        End If
        If BN <= 57 Then
            GHAHour = GHAAriesHour
        Else
            GHAHour = SH + GHAAriesHour
        End If
        If GHAHour >= 360 Or GHAHour < 0 Then
            GHAHour = GHAHour - Int(GHAHour / 360) * 360
        End If
        Exit Sub
    End Sub


    Public Sub AltitudeCorrection()
        'If optHorizonNatural.Checked = True Or optHorizonDipShort.Checked = True Then chkAH.CheckState = System.Windows.Forms.CheckState.Unchecked 'Added in V5.1.7
        If optHsDMS.Checked = False Then
            txtHsSec.Clear()
            txtIESec.Clear()
        End If
        ICMin = Val(txtIEmin.Text) + Val(txtIESec.Text) / 60
        If cboIE.Text = "on the arc" Then
            ICinMinutes = -(Val(txtIEdeg.Text) * 60 + ICMin)
        End If
        If cboIE.Text = "off the arc (rdg.)" Then
            ICMin = 60 - ICMin
            If ICMin = 60 Then ICMin = 0
            ICinMinutes = (Val(txtIEdeg.Text) - 1) * 60 + ICMin
        End If
        If cboIE.Text = "off the arc (val.)" Then
            ICinMinutes = Val(txtIEdeg.Text) * 60 + ICMin
        End If
        Corr1 = ICinMinutes - Dip()
        Corr1Deg = Int(System.Math.Abs(Corr1 / 60))
        Corr1Min = System.Math.Abs(Corr1) - 60 * Corr1Deg
        hsinMinutes = 60 * Val(txtHsDeg.Text) + Val(txtHsMin.Text) + Val(txtHsSec.Text) / 60
        HsMin = Val(txtHsMin.Text) + Val(txtHsSec.Text) / 60
        hainMinutes = hsinMinutes + Corr1
        'SendMsgBx ("Back sight with artificial horizon not permitted."): BSwithAH = True: Exit Function
        If optHorizonArtificial.Checked = True Then
            hainMinutes = (hsinMinutes + ICinMinutes) / 2
        End If
        BackSight = False
        If hainMinutes >= 5400 Then
            hainMinutes = 10800 - hainMinutes
            BackSight = True
        End If
        Refraction()
        If BN = 64 Or BN = 65 Then
            HP = 60 * System.Math.Atan(0.0000426349651 / RN) * 180 / Pi '0.0000426349651 is radius of Earth in AU, RN is distance between centers of Earth and Sun in AU
        End If
        If BN = 58 Or BN = 59 Then
            HP = 60 * 180 / Pi * System.Math.Atan(6378.16 / (Delta * 149597871))
        End If
        If BN <= 57 Or BN = 60 Or BN = 61 Then
            HP = 0
        End If
        Dim S0 As Double
        If BN < 58 Then
            DI = 0 'stars
        End If
        If BN = 58 Then
            S0 = 8.41 / 60
        End If
        If BN = 59 Then
            S0 = 4.68 / 60
        End If
        If BN = 60 Then
            S0 = 95.25 / 60 'average of equatorial and polar values (new values) for Jupiter
        End If
        If BN = 61 Then
            S0 = 78.275 / 60 ''average of equatorial and polar values (new values) for Saturn
        End If
        If BN > 57 And BN < 62 Then
            DI = S0 / Delta
        End If
        'Semi-diameter of Moon is set in Moon sub
        If (BN = 64 Or BN = 65) And optHoSRForm.Checked Then
            'DI = GetSunSD(New Date(2020, GMonth, GDay)) 'Added 6/30/2020 copied Sun SD data from 2004 and 2020 almanacs and setup load sub and getSD functions using Gday and Gmonth - year is irrelevant 
            If GMonth >= 4 And GMonth <= 9 Then
                DI = 15.859
                PA = 0.145 * System.Math.Cos((hainMinutes / 60) * (Pi / 180)) 'average SD 15.859, median 15.9, Gary LaPook 15.95 (used until V5.4.0), Ron Jones 15.8583; 0.145 is average HP
            Else
                DI = 16.1968
                PA = 0.148 * System.Math.Cos((hainMinutes / 60) * (Pi / 180)) 'average SD 16.195 (used until V5.4.0) corrected to 16.1968, median 16.15, Gary LaPook 16.15, Ron Jones 16.2167; 0.148 is average HP
            End If
        End If

        If (BN = 62 Or BN = 63 Or BN = 64 Or BN = 65) And optCenter.Checked Then 'And chkAH.CheckState = 1 Then
            DI = 0
        End If
        If (BN = 62 Or BN = 63 Or BN = 64 Or BN = 65) And optCenter.Checked And optHoSRForm.Checked = True Then  'And chkAH.CheckState = 1
            PA = 0
        End If

        Corr2Min = -r 'Was If BN <= 57 Then Corr2Min = -r, but should apply refraction to all bodies.  Changed in V5.4.0

        'Augmentation of the semi-diameter of the moon
        Aug = 0 'Augmentation increases the size of the semi-diameter correction, whether positive or negative
        If BN = 62 Or BN = 63 Then
            Aug = (((1738 / 6378) * HPA / 60) / (1 - System.Math.Sin(HPA / 60 * Pi / 180) * System.Math.Sin((hainMinutes / 60) * Pi / 180)) - DI / 60) * 60
            Aug = Int(Aug * 1000 + 0.5) / 1000
        End If
        If (BN = 62 Or BN = 63) And optCenter.Checked Then 'And chkAH.CheckState = 1 Then
            Aug = 0
        End If
        If BN = 62 Or BN = 64 Then
            Corr2Min = DI - r '+ PA 'r from Refraction
        End If
        If BN = 63 Or BN = 65 Then
            Corr2Min = -DI - r '+ PA 'r from Refraction
        End If
        If BN = 62 Then
            Corr2Min = Corr2Min + Aug
        End If
        If BN = 63 Then
            Corr2Min = Corr2Min - Aug
        End If
        If optHoParameters.Checked And BN = 65 And GYear >= 1954 And GYear <= 1969 Then
            Corr2Min = Corr2Min - 1.2     'added in V5.6.2 when irradiation was removed from semi-diameter
        End If
        Corr2forParallax = Corr2Min
        Corr2Min = Corr2Min + PA 'previously calculated refraction + parallax

        'Corrections for SR Form format
        Main_Corr = 0
        Addl = 0
        If BN <= 57 Or BN = 60 Or BN = 61 Then 'stars, Jupiter, Saturn
            Main_Corr = -Rstd
            Addl = 0
        End If
        If BN = 58 Or BN = 59 Then 'Venus, Mars
            Main_Corr = -Rstd
            Addl = PA
        End If

        If BN = 64 And optHoSRForm.Checked Then
            Main_Corr = -Rstd + PA + DI
            Addl = 0
        End If
        If BN = 65 And optHoSRForm.Checked Then
            Main_Corr = -Rstd + PA - DI
            If GYear >= 1954 And GYear <= 1969 Then
                Main_Corr = Main_Corr - 1.2 '1.2' for irradiation
            End If
            Addl = 0
        End If
        ''double comments are original based on Frank Reed
        If BN = 62 Or BN = 63 Then 'Moon            57.7 better as 57.66
            h3 = 57.66 * System.Math.Cos((hainMinutes / 60) * Pi / 180)
            'Use refraction formulas from Nautical Almanac, standard temperature and pressure, dependent on year
            H2 = hainMinutes / 60 'ha in degrees
            If GYear <= 2003 Then
                r = H2 + 7.31 / (H2 + 4.4)
            Else
                r = H2 + 7.32 / (H2 + 4.32)
            End If
            r = r * Pi / 180
            r = 1.002 / System.Math.Tan(r) '1.002 is 0.0167º in minutes, actually 0.01666666.... becomes 1, but 1.002 makes it match moon table better
            Main_Corr = h3 - r + (0.2724 * 57.66) - 5
            h4 = Main_Corr 'h4 is Main before rounding
            Main_Corr = Int(Main_Corr * 10 + 0.5) / 10
        End If
        dHP = Int(HPA * 10 + 0.5) / 10 'rounds HP to 0.1'
        If BN = 62 Then Addl = dHP * System.Math.Cos(H2 * Pi / 180) - r + DI - h4
        If BN = 63 Then Addl = dHP * System.Math.Cos(H2 * Pi / 180) - r - DI + 30 - h4

        'If (BN = 62 Or BN = 63) And optHorizonArtificial.Checked = True Then 'And chkAH.CheckState = 1 Then
        If (BN = 62 Or BN = 63) And optCenter.Checked = True Then
            Addl = dHP * System.Math.Cos(H2 * Pi / 180) - r - h4 + 15
        End If

        Addl = Int(Addl * 10 + 0.5) / 10
        Raddl = Int(Raddl * 10 + 0.5) / 10
        If optHoSRForm.Checked Then
            Corr2Min = Main_Corr + Addl - Raddl
            If BNType = "Moon" And optUpper.Checked = True Then ' BN = 63 Then ' Moon UL
                Corr2Min = Corr2Min - 30
            End If
            If BNType = "Moon" And optCenter.Checked Then 'And chkAH.CheckState = 1 Then
                Corr2Min = Corr2Min - 15
            End If
        End If
        'Corr2Min = System.Math.Sign(Corr2Min) * Int(System.Math.Abs(Corr2Min) * 10 + 0.5) / 10
        'Totals
        HoinMinutes = hainMinutes + Corr2Min 'minutes
        HoDeg = Fix(HoinMinutes / 60) 'min to dec. deg.; Fix was Int
        HoMin = HoinMinutes - 60 * HoDeg
        HoMin = Int(HoMin * 10 + 0.5) / 10
        If HoMin = 60 Then
            HoMin = 0
            HoDeg = HoDeg + 1
        End If
        haDeg = Fix(hainMinutes / 60) 'min. to dec. deg
        haMin = System.Math.Abs(hainMinutes - 60 * haDeg)
        If Int(haMin * 10 + 0.5) / 10 = 60 Then
            haMin = 0
            haDeg = haDeg + 1
        End If
        Exit Sub
    End Sub

    Public Sub LawOfCosines()
        'DecLOC = Abs(TotDE)
        DecLOC = System.Math.Abs(TotDecDegrees + TotDecMinutes / 60)
        If System.Math.Sign(Lat) = -System.Math.Sign(TotDE) Then
            DecLOC = -DecLOC 'does not work of L=0
        End If
        If System.Math.Sign(Lat) = 0 And cboL.Text = "N" And TotDE <= 0 Then
            DecLOC = -DecLOC
        End If
        If System.Math.Sign(Lat) = 0 And cboL.Text = "S" And TotDE >= 0 Then
            DecLOC = -DecLOC
        End If

        L1 = System.Math.Cos(LHA * Pi / 180) * System.Math.Cos(System.Math.Abs(Lat) * Pi / 180) * System.Math.Cos(DecLOC * Pi / 180)
        L2 = System.Math.Sin(System.Math.Abs(Lat) * Pi / 180) * System.Math.Sin(DecLOC * Pi / 180)
        L3 = L1 + L2
        If System.Math.Abs(L3) >= 1 Then
            Hc = System.Math.Sign(L3) * Pi / 2
        Else
            Hc = System.Math.Atan(L3 / System.Math.Sqrt(-L3 * L3 + 1))
        End If
        Hc = Hc * 180 / Pi
        HcDeg = Fix(Hc)
        HcMin = (Hc - HcDeg) * 60
        HcMin = Int(HcMin * 10 + 0.5) / 10

        If HcMin = 60 Then
            HcMin = 0
            If HcDeg >= 0 Then HcDeg = HcDeg + 1
            If HcDeg < 0 Then HcDeg = HcDeg - 1
        End If
        Intercept = (60 * HcDeg + HcMin) - (60 * HoDeg + HoMin)
        Intercept = System.Math.Sign(Intercept) * Int(System.Math.Abs(Intercept) * 10 + 0.5) / 10
        L4 = System.Math.Sin(DecLOC * Pi / 180)
        L5 = System.Math.Sin(System.Math.Abs(Lat) * Pi / 180) * System.Math.Sin(Hc * Pi / 180)
        L6 = L4 - L5
        L7 = System.Math.Cos(System.Math.Abs(Lat) * Pi / 180) * System.Math.Cos(Hc * Pi / 180)
        L8 = L6 / L7
        If System.Math.Abs(L8) >= 1 Then
            Z = Pi
        Else
            Z = System.Math.Atan(-L8 / System.Math.Sqrt(-L8 * L8 + 1)) + Pi / 2
        End If
        Z = Z * 180 / Pi
        If cboL.Text = "N" And LHA > 180 Then
            ZN = Z
        End If
        If cboL.Text = "N" And LHA <= 180 Then
            ZN = 360 - Z
        End If
        If cboL.Text = "S" And LHA > 180 Then
            ZN = 180 - Z
        End If
        If cboL.Text = "S" And LHA <= 180 Then
            ZN = 180 + Z
        End If
        If BN <> 0 Or (BNBodyName = "Polaris" And cboPolaris.Text = "Full reduction of Polaris sight") Then
            ZN = Int(ZN + 0.5)
        End If
        If ZN = 360 Then
            ZN = 0
        End If
        Exit Sub
    End Sub

    Public Sub Refraction()
        'Atmospheric refraction
        TX = Val(txtTemperature.Text)
        If cboTemperature.Text = "F " Then TX = (5 / 9) * (TX - 32)
        PX = Val(txtPressure.Text)
        If cboPressure.Text = "in Hg" Then PX = 33.85853168 * PX

        If optHoSRForm.Checked = True Then
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
            If GYear <= 2003 Then
                r = y + 7.31 / (y + 4.4)
            Else
                r = y + 7.32 / (y + 4.32)
            End If
            r = r * Pi / 180
            r = 1 / System.Math.Tan(r)
            If GYear <= 2003 Then
                r = r - 0.06 * System.Math.Sin((14.7 * (r / 60) + 13) * Pi / 180) 'correction to improve accuracy from 0.07' to 0.015', 2004 or earlier
            End If
            Rstd = r 'added in 5.1.4
        End If
        RstdTP = r 'replaced previous line in 5.1.4
        If r < 0 Then
            r = 0 'This line added to get rid of negative values at very high altitudes under certain circumstances
        End If
        r = r * (283 / 1010) * PX / (TX + 273) 'PX=1010, TX=10    Total Refraction    Constant was 0.28019802
        Raddl = r - RstdTP
        If (GYear <= 2003 And hainMinutes >= 596) Or (GYear >= 2004 And hainMinutes >= 595) Then
            Rstd = RstdA2
        End If
    End Sub

    Public Sub EstimatedPosition()
        Intercept = System.Math.Sign(Intercept) * Int(System.Math.Abs(Intercept) * 10 + 0.5) / 10 'added in V4.0.0
        If cboPolaris.Text <> "Latitude by altitude of Polaris" Then
            ZN = Int(ZN + 0.5) 'changed above line to this in V4.3.1
        End If
        EstL = Lat - (Intercept / 60) * System.Math.Cos(ZN * Pi / 180)
        EstLo = Lo + (Intercept / 60) * System.Math.Sin(ZN * Pi / 180) / System.Math.Cos(Lat * Pi / 180)
        If System.Math.Abs(EstLo) > 180 Then
            EstLo = -System.Math.Sign(EstLo) * (360 - System.Math.Abs(EstLo))
        End If
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
    Public Sub Moon()
        MLprime = 218.3164477 + 481267.88123421 * T - 0.0015786 * T * T + T * T * T / 538841 - T * T * T * T / 65194000 'Moon's mean longitude, degrees
        If MLprime >= 360 Or MLprime < 0 Then MLprime = MLprime - Int(MLprime / 360) * 360
        MLprime = MLprime * Pi / 180
        MD = 297.8501921 + 445267.1114034 * T - 0.0018819 * T * T + T * T * T / 545868 - T * T * T * T / 113065000 'Moon'smean elongation, degrees
        If MD >= 360 Or MD < 0 Then MD = MD - Int(MD / 360) * 360
        MD = MD * Pi / 180 'radians
        MM = 357.5291092 + 35999.0502909 * T - 0.0001536 * T * T + T * T * T / 24490000 'Sun's mean anomaly, degrees
        If MM >= 360 Or MM < 0 Then MM = MM - Int(MM / 360) * 360
        MM = MM * Pi / 180 'radians
        MMprime = 134.9633964 + 477198.8675055 * T + 0.0087414 * T * T + T * T * T / 69699 - T * T * T * T / 14712000 'Moon's mean anomaly, degrees
        If MMprime >= 360 Or MMprime < 0 Then MMprime = MMprime - Int(MMprime / 360) * 360
        MMprime = MMprime * Pi / 180 'radians
        MF = 93.272095 + 483202.0175233 * T - 0.0036539 * T * T - T * T * T / 3526000 + T * T * T * T / 863310000 'Moon's argument of altitude, degrees
        If MF >= 360 Or MF < 0 Then MF = MF - Int(MF / 360) * 360
        MF = MF * Pi / 180 'radians
        A1 = 119.75 + 131.849 * T 'degrees
        If A1 >= 360 Or A1 < 0 Then A1 = A1 - Int(A1 / 360) * 360
        A1 = A1 * Pi / 180 'radians
        A2 = 53.09 + 479264.29 * T 'degrees
        If A2 >= 360 Or A2 < 0 Then A2 = A2 - Int(A2 / 360) * 360
        A2 = A2 * Pi / 180 'radians
        A3 = 313.45 + 481266.484 * T 'degrees
        If A3 >= 360 Or A3 < 0 Then A3 = A3 - Int(A3 / 360) * 360
        A3 = A3 * Pi / 180 'radians
        E = 1 - 0.002516 * T - 0.0000074 * T * T
        SigmaL = 0 : SigmaR = 0 : SigmaB = 0
        For i = 0 To 59
            KA = 1 : KB = 1
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
        DI = 5974556.667 / Delta 'this is geocentric semidiameter, simple formula from Meeus (was in arcseconds)
        HP = HP * 180 / Pi * 60 'arcminutes
        L1 = L1 + NL 'apparent longitude
        L1 = L1 * Pi / 180
        B = B * Pi / 180
        EclipticToEquatorial()
        AR = AR * 180 / Pi 'for Meeus ecl-to-eq
        DE = DE * 180 / Pi 'for Meeus ecl-to-eq
        Exit Sub
    End Sub
    Public Sub Planets()
        'L is heliocentric, ecliptic longitude, radians
        'B is heliocentric, ecliptic latitude, radians
        'r is heliocentric distance, astronomical units
        Delta = 0 : Tau = 0
        T = T / 10
        For i = 1 To 3
            If i > 1 Then T = (JD - 2451545 - Tau) / 365250
            If BN = 58 Then
                L = Venus_L01(T) + Venus_L11(T) + Venus_L21(T) + Venus_L31(T) + Venus_L41(T) + Venus_L51(T)
                If System.Math.Abs(L) > (2 * Pi) Then L = L - 2 * Pi * Int(L / 2 / Pi)
                B = Venus_B01(T) + Venus_B11(T) + Venus_B21(T) + Venus_B31(T) + Venus_B41(T) + Venus_B51(T)
                r = Venus_R01(T) + Venus_R11(T) + Venus_R21(T) + Venus_R31(T) + Venus_R41(T) + Venus_R51(T)
            End If
            If BN = 59 Then
                L = Mars_L01(T) + Mars_L02(T) + Mars_L03(T) + Mars_L11(T) + Mars_L12(T) + Mars_L21(T) + Mars_L31(T) + Mars_L41(T) + Mars_L51(T)
                If System.Math.Abs(L) > (2 * Pi) Then L = L - 2 * Pi * Int(L / 2 / Pi)
                B = Mars_B01(T) + Mars_B11(T) + Mars_B21(T) + Mars_B31(T) + Mars_B41(T) + Mars_B51(T)
                r = Mars_R01(T) + Mars_R02(T) + Mars_R03(T) + Mars_R11(T) + Mars_R12(T) + Mars_R21(T) + Mars_R31(T) + Mars_R41(T) + Mars_R51(T)
            End If
            If BN = 60 Then
                L = Jupiter_L01(T) + Jupiter_L02(T) + Jupiter_L11(T) + Jupiter_L21(T) + Jupiter_L31(T) + Jupiter_L41(T) + Jupiter_L51(T)
                If System.Math.Abs(L) > (2 * Pi) Then L = L - 2 * Pi * Int(L / 2 / Pi)
                B = Jupiter_B01(T) + Jupiter_B11(T) + Jupiter_B21(T) + Jupiter_B31(T) + Jupiter_B41(T) + Jupiter_B51(T)
                r = Jupiter_R01(T) + Jupiter_R02(T) + Jupiter_R11(T) + Jupiter_R21(T) + Jupiter_R31(T) + Jupiter_R41(T) + Jupiter_R51(T)
            End If
            If BN = 61 Then
                L = Saturn_L01(T) + Saturn_L02(T) + Saturn_L03(T) + Saturn_L11(T) + Saturn_L12(T) + Saturn_L21(T) + Saturn_L31(T) + Saturn_L41(T) + Saturn_L51(T)
                If System.Math.Abs(L) > (2 * Pi) Then L = L - 2 * Pi * Int(L / 2 / Pi)
                B = Saturn_B01(T) + Saturn_B02(T) + Saturn_B11(T) + Saturn_B21(T) + Saturn_B31(T) + Saturn_B41(T) + Saturn_B51(T)
                r = Saturn_R01(T) + Saturn_R02(T) + Saturn_R03(T) + Saturn_R11(T) + Saturn_R12(T) + Saturn_R21(T) + Saturn_R31(T) + Saturn_R41(T) + Saturn_R51(T)
            End If
            'convert from heliocentric to geocentric coordinates
            If i = 1 Then
                L0 = Earth_L01(T) + Earth_L02(T) + Earth_L11(T) + Earth_L21(T) + Earth_L31(T) + Earth_L41(T) + Earth_L51(T)
                If System.Math.Abs(L0) > (2 * Pi) Then L0 = L0 - 2 * Pi * Int(L0 / 2 / Pi)
                'L0Sun = L0
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
        If System.Math.Abs(x) < 9.999999E-21 Then x = 9.999999E-21
        L1 = System.Math.Atan(y / x) 'geocentric longitude, radians
        If x < 0 Then L1 = L1 + Pi
        If L1 >= 2 * Pi Or L1 < 0 Then L1 = L1 - Int(L1 / (2 * Pi)) * 2 * Pi
        B = System.Math.Atan(Z / System.Math.Sqrt(x * x + y * y)) 'geocentric latitude, radians

        'Back to normal times
        T = T * 10
        'Apply Aberration
        Sun() 'for LN, Ecc needed in AberrationLB
        AberrationLB()
        L1 = L1 + AberrL * Pi / 180 'radians
        B = B + AberrB * Pi / 180 'radians    'IS THIS LINE NEEDED????????????????????????????????????
        L1 = L1 + NL * Pi / 180 'apparent longitude
        EclipticToEquatorial()
        AR = AR * 180 / Pi
        DE = DE * 180 / Pi
        Exit Sub
    End Sub

    Public Sub LatByPolaris()
        PolarisMeans()
        LatLong()
        ZoneTime()
        Greenwich()
        Delta_T()
        Julian()
        Stars()
        DE1 = DE
        HourAngles()
        LR = GHAAries - Lo
        If LR < 0 Then LR = LR + 360
        If LR >= 360 Then LR = LR - 360
        XD = Int(LR)
        XM = (LR - XD) * 60
        XM = Int(XM * 10 + 0.5) / 10
        If XM = 60 Then
            XM = 0
            XD = XD + 1
        End If
        Pola0 = -(90 - MeanDecPol) * System.Math.Cos((LR + MeanSHAPol) * Pi / 180) + 0.5 * (90 - MeanDecPol) * System.Math.Sin((90 - MeanDecPol) * Pi / 180) * (System.Math.Sin((LR + MeanSHAPol) * Pi / 180)) ^ 2 * System.Math.Tan(50 * Pi / 180)
        Pola0 = 60 * Pola0 + 58.8
        Pola0deg = 0
        Pola0min = Pola0
        If Pola0 >= 60 Then
            Pola0deg = 1
            Pola0min = Pola0 - 60
        End If
        LforPol = Lat
        If (txtLDeg.Text = "" And txtLMin.Text = "") Then
            LforPol = HoinMinutes / 60 'Hoinminutes/60 is approximate latitude in degrees
        End If
        Select Case LforPol
            Case Is < 5
                LforPol = 0
            Case Is < 15
                LforPol = 10
            Case Is < 25
                LforPol = 20
            Case Is < 35
                LforPol = 30
            Case Is < 42.5
                LforPol = 40
            Case Is < 47.5
                LforPol = 45
            Case Is < 52.5
                LforPol = 50
            Case Is < 57.5
                LforPol = 55
            Case Is < 61
                LforPol = 60
            Case Is < 63
                LforPol = 62
            Case Is < 65
                LforPol = 64
            Case Is < 67
                LforPol = 66
            Case Is < 69
                LforPol = 68
        End Select
        Pola1 = 0.5 * (90 - DE) * System.Math.Sin((90 - DE) * Pi / 180) * (System.Math.Sin((LR + SH) * Pi / 180)) ^ 2 * (System.Math.Tan(LforPol * Pi / 180)) - 0.5 * (90 - MeanDecPol) * System.Math.Sin((90 - MeanDecPol) * Pi / 180) * (System.Math.Sin((LR + MeanSHAPol) * Pi / 180)) ^ 2 * (System.Math.Tan(50 * Pi / 180))
        Pola1 = 60 * Pola1 + 0.6
        Pola2 = (90 - MeanDecPol) * System.Math.Cos((LR + MeanSHAPol) * Pi / 180) - (90 - DE) * System.Math.Cos((LR + SH) * Pi / 180)
        Pola2 = 60 * Pola2 + 0.6
        Pola0min = Int(10 * Pola0min + 0.5) / 10
        Pola1 = Int(10 * Pola1 + 0.5) / 10
        Pola2 = Int(10 * Pola2 + 0.5) / 10
        PC = Pola0deg * 60 + Pola0min + Pola1 + Pola2
        PCdeg = 0
        PCmin = PC
        If PC >= 60 Then
            PCdeg = 1
            PCmin = PC - 60
        End If
        PCorr = PC - 60

        Stars()
        HourAngles()

        T = THour1
        JDHour = JDHour1 ': AR = AR1
        Obliquity()
        Nutation()
        HourAnglesHour()
        GHAHour1 = GHAHour
        IandC()
        AltitudeCorrection()
        LawOfCosines()
        LP = LHA * Pi / 180
        HD = g_LatN

        P0 = 90 - DE 'polar distance (degrees)
        '    'L0 = Ho
        L0 = HoinMinutes / 60
Line9820:
        LbyPol = (HoDeg * 60 + HoMin + PCorr) / 60 'changed to this in V5.1.5 to make math work better
        If System.Math.Abs(LbyPol - L0) < 0.000001 Then GoTo Line9870
        L0 = LbyPol
        GoTo Line9820
Line9870:
        PD2 = Fix(LbyPol)
        PM = (LbyPol - PD2) * 60
        PM = Int(PM * 10 + 0.5) / 10
        If PM = 60 Then
            PM = 0
            PD2 = PD2 + 1
        End If

        Ldiff = System.Math.Abs(LbyPol - Lat)
        ldiffDeg = Int(Ldiff)
        ldiffMin = (Ldiff - ldiffDeg) * 60
        ldiffMin = Int(ldiffMin * 10 + 0.5) / 10
        If ldiffMin = 60 Then
            ldiffMin = 0
            ldiffDeg = ldiffDeg + 1
        End If

        EstimatedPosition()
        DisplaySR()
        DisplayPolaris()
        cmdSave.Visible = False
        btnCLSPlot.Visible = False
        btnCustomPlot.Visible = False
        cmdMerDiag.Visible = False
        btnExpandTimeDiag.Visible = False
        Exit Sub
    End Sub

    Public Sub DisplayPolaris()

        IntAzTxtBx.Clear()
        IntAzTxtBx.Font = New Font(IntAzTxtBx.Font, FontStyle.Bold)
        IntAzTxtBx.SelectionAlignment = HorizontalAlignment.Center
        IntAzTxtBx.AppendText("LATITUDE by ALTITUDE of POLARIS" & vbNewLine)
        IntAzTxtBx.SelectionAlignment = HorizontalAlignment.Left

        IntAzTxtBx.AppendText("LHA Aries      " & Strings.Format(XD, "##0") & Chr(176) & Strings.Format(XM, "00.0") & "'" & vbTab & "Polaris Correction" & vbTab & vbTab & "Latitude Computation" & vbNewLine)
        IntAzTxtBx.AppendText(vbTab & vbTab & vbTab & vbTab & "a0     " & Strings.Format(Pola0deg, "0") & Chr(176) & Strings.Format(Pola0min, "00.0") & "'" & vbTab & vbTab & "Ho     ")
        If System.Math.Sign(HoinMinutes) = -1 Then
            IntAzTxtBx.AppendText(Space(35 - (HoDeg.ToString.Length)) & "-")
        End If
        IntAzTxtBx.AppendText(Space(1) & Strings.Format(HoDeg, "##0") & Chr(176) & Strings.Format(HoMin, "00.0") & "'" & vbNewLine)

        IntAzTxtBx.AppendText(vbTab & vbTab & vbTab & vbTab & "a1       " & Strings.Format(Pola1, "00.0") & "'" & vbTab & vbTab & "Corr (")
        If PCorr = 0 Then
            IntAzTxtBx.AppendText(" )   00.0'") 'PCorr was PCorr2
        End If
        If PCorr > 0 Then
            IntAzTxtBx.AppendText("+)   ") 'PCorr was PCorr2
        End If
        If PCorr < 0 Then
            IntAzTxtBx.AppendText("-)   ") 'PCorr was PCorr2
        End If
        If PCorr <> 0 Then
            IntAzTxtBx.AppendText(Strings.Format(System.Math.Abs(PCorr), "00.0") & "'" & vbNewLine) 'PCorr was PCorr2
        End If

        PL = g_LatN
        If LbyPol < 0 Then
            PL = g_LatS
        End If
        If LbyPol = 0 Then
            PL = " "
        End If
        IntAzTxtBx.AppendText(vbTab & vbTab & vbTab & vbTab & "a2       " & Strings.Format(Pola2, "00.0") & "'" & vbTab & vbTab & "Lat     " _
                              & Space(6 - Len(Str(PD2))) & Strings.Format(System.Math.Abs(PD2), "#0") & Chr(176) & Strings.Format(System.Math.Abs(PM), "00.0") & "'" & PL & vbNewLine)

        IntAzTxtBx.AppendText(vbTab & vbTab & vbTab & vbTab & "Total" & Space(4 - Len(Str(PCdeg))) & Strings.Format(PCdeg, "0") & Chr(176) & Strings.Format(PCmin, "00.0") & "'" & vbTab & vbTab)
        If (BNBodyName = "Polaris" And cboPolaris.Text <> "Latitude by altitude of Polaris") Or (BNBodyName = "Polaris" And cboPolaris.Text = "Latitude by altitude of Polaris" And (txtLDeg.Text <> "" Or txtLMin.Text <> "")) Then
            IntAzTxtBx.AppendText("DR Lat   " & Space(5 - Len(Str(Val(txtLDeg.Text)))) & Strings.Format(Val(txtLDeg.Text), "0") & Chr(176) & Strings.Format(Val(txtLMin.Text), "00.0") & "'" & cboL.Text)
        End If
        IntAzTxtBx.AppendText(vbNewLine)

        IntAzTxtBx.AppendText(vbTab & vbTab & vbTab & vbTab & "    (-)1" & Chr(176) & "00.0'" & vbTab & vbTab)
        If (BNBodyName = "Polaris" And cboPolaris.Text <> "Latitude by altitude of Polaris") Or (BNBodyName = "Polaris" And cboPolaris.Text = "Latitude by altitude of Polaris" And (txtLDeg.Text <> "" Or txtLMin.Text <> "")) Then
            IntAzTxtBx.AppendText("l diff   " & Space(5 - Len(Str(ldiffDeg))) & Strings.Format(ldiffDeg, "0") & Chr(176) & Strings.Format(ldiffMin, "00.0") & "'")
        End If
        IntAzTxtBx.AppendText(vbNewLine)

        IntAzTxtBx.AppendText(vbTab & vbTab & vbTab & vbTab & "Corr(")
        If PCorr = 0 Then IntAzTxtBx.AppendText(" )  00.0'")
        If PCorr > 0 Then IntAzTxtBx.AppendText("+)  ")
        If PCorr < 0 Then IntAzTxtBx.AppendText("-)  ")
        If PCorr <> 0 Then IntAzTxtBx.AppendText(Strings.Format(System.Math.Abs(PCorr), "00.0") & "'" & vbTab & vbTab & "Zn       " & Space(5 - Len(Str(Int(ZN)))) & Strings.Format(Int(ZN * 10 + 0.5) / 10, "##0.0") & Chr(176) & vbNewLine)

        IntAzTxtBx.AppendText("EP L  " & Space(11 - Len(Str(PD2))) & Strings.Format(System.Math.Abs(PD2), "#0") & Chr(176) & Strings.Format(System.Math.Abs(PM), "00.0") & "'" & PL & vbNewLine)
        IntAzTxtBx.AppendText("EP Lo " & Space(11 - Len(Str(Val(txtLoDeg.Text)))) & Strings.Format(Val(txtLoDeg.Text), "0") & Chr(176) & Strings.Format(Val(txtLoMin.Text), "00.0") & "'" & cboLo.Text)

        Exit Sub
    End Sub

    Public Sub DisplayLOC()
        IntAzTxtBx.Clear()
        IntAzTxtBx.Font = TxtBxFont
        IntAzTxtBx.Font = New Font(IntAzTxtBx.Font, FontStyle.Bold)
        IntAzTxtBx.SelectionAlignment = HorizontalAlignment.Center
        IntAzTxtBx.AppendText("INTERCEPT and AZIMUTH by the LAW of COSINES METHOD" & vbNewLine)
        IntAzTxtBx.SelectionAlignment = HorizontalAlignment.Left
        LHAOriginal = LHADeg + LHAMin / 60
        IntAzTxtBx.AppendText(Space(25) &
                              "LHA" & Space(5 - Len(Str(LHADeg))) & Strings.Format(LHADeg, "0") & Chr(176) & Strings.Format(LHAMin, "00.0") & "'" & Space(2) & "-------> LHA" & Space(9 - Len(Str(LHADeg))) & Strings.Format(LHA, "0.00000") & Chr(176) & vbNewLine)
        IntAzTxtBx.AppendText(Space(25) _
                              & "Lat" & Space(5 - Len(Str(Val(txtLDeg.Text)))) & Strings.Format(Val(txtLDeg.Text), "0") & Chr(176) & Strings.Format(Val(LMin), "00.0") & "'" & cboL.Text & "-------> Lat (+)" & Space(5 - Len(Str(Val(txtLDeg.Text)))) & Strings.Format(System.Math.Abs(Lat), "0.00000") & Chr(176) & vbNewLine)
        IntAzTxtBx.AppendText(Space(25) _
                              & "Dec" & Space(5 - Len(Str(TotDecDegrees))) & Strings.Format(System.Math.Abs(TotDecDegrees), "0") & Chr(176) & Strings.Format(TotDecMinutes, "00.0") & "'")
        If TotDE > 0 Then
            IntAzTxtBx.AppendText(g_LatN)
        End If
        If TotDE = 0 Then
            IntAzTxtBx.AppendText(g_StrSpace)
        End If
        If TotDE < 0 Then
            IntAzTxtBx.AppendText(g_LatS)
        End If
        IntAzTxtBx.AppendText(" -------> Dec (")
        If (TotDE <= 0 And cboL.Text = "N") Or (TotDE >= 0 And cboL.Text = "S") Then
            IntAzTxtBx.AppendText("-)")
        Else
            IntAzTxtBx.AppendText("+)")
        End If
        IntAzTxtBx.AppendText(Space(5 - Len(Str(TotDecDegrees))) & Strings.Format(System.Math.Abs(TotDE), "0.00000") & Chr(176) & vbNewLine)

        IntAzTxtBx.AppendText(Space(5) & " (cos LHA x cos Lat x cos Dec) + (sin Lat x sin Dec) = sin Hc" & " ---->" & Space(3) &
        "Hc " & Strings.Format(Int(Hc * 100000 + 0.5) / 100000, "0.00000") & Chr(176) & vbNewLine)
        IntAzTxtBx.AppendText(Space(5) & " (sin Dec - (sin Lat x sin Hc)) / (cos Lat x cos Hc) = cos Z" & " ----->" & Space(3) &
                              "Z  " & cboL.Text & Strings.Format(Int(Z * 10 + 0.5) / 10, "0.0") & Chr(176))
        If LHA <= 180 Then
            IntAzTxtBx.AppendText(" W")
        End If
        If LHA > 180 Then
            IntAzTxtBx.AppendText(" E")
        End If
        IntAzTxtBx.AppendText(vbNewLine)


        IntAzTxtBx.AppendText(Space(25) & " Hc")
        If System.Math.Sign(Hc) = -1 Then
            IntAzTxtBx.AppendText(Space(4 - Len(Str(HcDeg))) & "-")
        End If
        IntAzTxtBx.AppendText(Space(5 - Len(Str(HcDeg))) & Strings.Format(System.Math.Abs(HcDeg), "0") & Chr(176) & Strings.Format(System.Math.Abs(HcMin), "00.0") & "'" & vbNewLine)

        IntAzTxtBx.AppendText(Space(25) & " Ho")
        If System.Math.Sign(HoinMinutes) = -1 Then
            IntAzTxtBx.AppendText(Space(4 - Len(Str(HoDeg))) & "-")
        End If
        IntAzTxtBx.AppendText(Space(5 - Len(Str(HoDeg))) & Strings.Format(System.Math.Abs(HoDeg), "0") & Chr(176) & Strings.Format(System.Math.Abs(HoMin), "00.0") & "'" & vbNewLine)
        i = Len(Str(Int(System.Math.Abs(Intercept) * 10 + 0.5)))
        If System.Math.Abs(Intercept) < 1 Then
            i = i + 1
        End If

        IntAzTxtBx.AppendText(Space(25) & " a =" & Space(9 - i) & Strings.Format((Int(System.Math.Abs(Intercept) * 10 + 0.5)) / 10, "0.0") & " nm ")
        PlotOut.PlotIntercept = Strings.Format((Int(System.Math.Abs(Intercept) * 10 + 0.5)) / 10, "0.0") & " nm "
        If Int(System.Math.Abs(Intercept) * 10 + 0.5) / 10 <> 0 And Intercept < 0 Then
            IntAzTxtBx.AppendText("T  Ho > Hc....Toward")
            PlotOut.PlotIntercept &= " Toward"
        End If
        If Int(System.Math.Abs(Intercept) * 10 + 0.5) / 10 <> 0 And Intercept > 0 Then
            IntAzTxtBx.AppendText("A  Hc > Ho....Away  ")
            PlotOut.PlotIntercept &= " Away"
        End If
        IntAzTxtBx.AppendText(Space(5) & "Zn = " & Strings.Format(ZN, "000") & Chr(176) & vbNewLine)
        PlotOut.PlotAz = Strings.Format(ZN, "000") & Chr(176)
        SightLog.SRFFormEP = ""
        IntAzTxtBx.AppendText(Space(25) & " EP L " & Strings.Format(EstLDeg, "0") & Chr(176) & Strings.Format(EstLMin, "00.0") & "'") 'Tab(10 - Len(Str$(EstLDeg)));
        SightLog.SRFFormEP = (" EP L " & Strings.Format(EstLDeg, "0") & Chr(176) & Strings.Format(EstLMin, "00.0") & "'")
        PlotOut.PlotSLEP = (" EP L " & Strings.Format(EstLDeg, "0") & Chr(176) & Strings.Format(EstLMin, "00.0") & "'")

        If EstL > 0 Then
            IntAzTxtBx.AppendText(g_LatN)
            SightLog.SRFFormEP &= g_LatN
            PlotOut.PlotSLEP &= g_LatN
        End If
        If EstL = 0 Then
            IntAzTxtBx.AppendText(g_StrSpace)
            SightLog.SRFFormEP &= " "
            PlotOut.PlotSLEP &= " "
        End If
        If EstL < 0 Then
            IntAzTxtBx.AppendText(g_LatS)
            SightLog.SRFFormEP &= g_LatS
            PlotOut.PlotSLEP &= g_LatS
        End If
        IntAzTxtBx.AppendText("   EP Lo " & Strings.Format(EstLoDeg, "0") & Chr(176) & Strings.Format(EstLoMin, "00.0") & "'") 'Tab(28 - Len(Str$(EstLoDeg)));
        SightLog.SRFFormEP &= "   EP Lo " & Strings.Format(EstLoDeg, "0") & Chr(176) & Strings.Format(EstLoMin, "00.0") & "'"
        PlotOut.PlotSLEP &= "   EP Lo " & Strings.Format(EstLoDeg, "0") & Chr(176) & Strings.Format(EstLoMin, "00.0") & "'"
        If EstLo > 0 Then
            IntAzTxtBx.AppendText(g_LongW)
            SightLog.SRFFormEP &= g_LongW
            PlotOut.PlotSLEP &= g_LongW
        End If
        If EstLo = 0 Then
            IntAzTxtBx.AppendText(g_StrSpace)
            SightLog.SRFFormEP &= " "
            PlotOut.PlotSLEP &= " "
        End If
        If EstLo < 0 Then
            IntAzTxtBx.AppendText(g_LongE)
            SightLog.SRFFormEP &= g_LongE
            PlotOut.PlotSLEP &= g_LongE

        End If
        DisplayTimeDiagram()
        Exit Sub
    End Sub
    ' THE FOLLOWING TWO SUB ROUTINES MOVED INTO THE FIX FORM 9/27/2019 BY H HAMMOND. RESTRUCTURED INTERFACE TO FIX FORM TO CLEAN UP AND MAKE FIX MORE INDEPENDENT OF SRF AND REUSABLE
    'Public Sub FixData()
    ' the various fix data element arrays are dim at 50 elements but only 12 are used reliably and the indexing starts 1 - artifact of original vb6 code that is strung between SRF FormSRF and Fix Form4
    'Dim temp As Integer = 0
    'For temp = 1 To 12
    '    Form4.FixDataArray(temp) = New Form4.SFixData With {.SFZH = FZH(temp), .SFZM = FZM(temp), .SFZS = FZS(temp),
    '            .SFZN = FZN(temp), .SFMI = FMI(temp), .SFL = FL(temp), .SFLo = FLo(temp), .SBF = BF(temp),
    '           .SFLD = FLD(temp), .SFLM = FLM(temp), .sFD = FD(temp), .SFMD = FMD(temp), .SFMM = FMM(temp),
    '            .sFLA = FLA(temp), .SFM = FM(temp), .SFGHA = FGHA(temp), .SFDec = FDec(temp), .SFHo = FHo(temp)}
    'Next
    'Added FGHA, FDec, and FHo om V5.6.1
    'FixData1 = New SFixData With {.SFZH = FZH(1), .SFZM = FZM(1), .SFZS = FZS(1), .SFZN = FZN(1), .SFMI = FMI(1), .SFL = FL(1), .SFLo = FLo(1), .SBF = BF(1), .SFLD = FLD(1), .SFLM = FLM(1), .sFD = FD(1), .SFMD = FMD(1), .SFMM = FMM(1), .sFLA = FLA(1), .SFM = FM(1), .SFGHA = FGHA(1), .SFDec = FDec(1), .SFHo = FHo(1)}
    'FixData2 = New SFixData With {.SFZH = FZH(2), .SFZM = FZM(2), .SFZS = FZS(2), .SFZN = FZN(2), .SFMI = FMI(2), .SFL = FL(2), .SFLo = FLo(2), .SBF = BF(2), .SFLD = FLD(2), .SFLM = FLM(2), .sFD = FD(2), .SFMD = FMD(2), .SFMM = FMM(2), .sFLA = FLA(2), .SFM = FM(2), .SFGHA = FGHA(2), .SFDec = FDec(2), .SFHo = FHo(2)}
    'FixData3 = New SFixData With {.SFZH = FZH(3), .SFZM = FZM(3), .SFZS = FZS(3), .SFZN = FZN(3), .SFMI = FMI(3), .SFL = FL(3), .SFLo = FLo(3), .SBF = BF(3), .SFLD = FLD(3), .SFLM = FLM(3), .sFD = FD(3), .SFMD = FMD(3), .SFMM = FMM(3), .sFLA = FLA(3), .SFM = FM(3), .SFGHA = FGHA(3), .SFDec = FDec(3), .SFHo = FHo(3)}
    'FixData4 = New SFixData With {.SFZH = FZH(4), .SFZM = FZM(4), .SFZS = FZS(4), .SFZN = FZN(4), .SFMI = FMI(4), .SFL = FL(4), .SFLo = FLo(4), .SBF = BF(4), .SFLD = FLD(4), .SFLM = FLM(4), .sFD = FD(4), .SFMD = FMD(4), .SFMM = FMM(4), .sFLA = FLA(4), .SFM = FM(4), .SFGHA = FGHA(4), .SFDec = FDec(4), .SFHo = FHo(4)}
    'FixData5 = New SFixData With {.SFZH = FZH(5), .SFZM = FZM(5), .SFZS = FZS(5), .SFZN = FZN(5), .SFMI = FMI(5), .SFL = FL(5), .SFLo = FLo(5), .SBF = BF(5), .SFLD = FLD(5), .SFLM = FLM(5), .sFD = FD(5), .SFMD = FMD(5), .SFMM = FMM(5), .sFLA = FLA(5), .SFM = FM(5), .SFGHA = FGHA(5), .SFDec = FDec(5), .SFHo = FHo(5)}
    'FixData6 = New SFixData With {.SFZH = FZH(6), .SFZM = FZM(6), .SFZS = FZS(6), .SFZN = FZN(6), .SFMI = FMI(6), .SFL = FL(6), .SFLo = FLo(6), .SBF = BF(6), .SFLD = FLD(6), .SFLM = FLM(6), .sFD = FD(6), .SFMD = FMD(6), .SFMM = FMM(6), .sFLA = FLA(6), .SFM = FM(6), .SFGHA = FGHA(6), .SFDec = FDec(6), .SFHo = FHo(6)}
    'FixData7 = New SFixData With {.SFZH = FZH(7), .SFZM = FZM(7), .SFZS = FZS(7), .SFZN = FZN(7), .SFMI = FMI(7), .SFL = FL(7), .SFLo = FLo(7), .SBF = BF(7), .SFLD = FLD(7), .SFLM = FLM(7), .sFD = FD(7), .SFMD = FMD(7), .SFMM = FMM(7), .sFLA = FLA(7), .SFM = FM(7), .SFGHA = FGHA(7), .SFDec = FDec(7), .SFHo = FHo(7)}
    'FixData8 = New SFixData With {.SFZH = FZH(8), .SFZM = FZM(8), .SFZS = FZS(8), .SFZN = FZN(8), .SFMI = FMI(8), .SFL = FL(8), .SFLo = FLo(8), .SBF = BF(8), .SFLD = FLD(8), .SFLM = FLM(8), .sFD = FD(8), .SFMD = FMD(8), .SFMM = FMM(8), .sFLA = FLA(8), .SFM = FM(8), .SFGHA = FGHA(8), .SFDec = FDec(8), .SFHo = FHo(8)}
    'FixData9 = New SFixData With {.SFZH = FZH(9), .SFZM = FZM(9), .SFZS = FZS(9), .SFZN = FZN(9), .SFMI = FMI(9), .SFL = FL(9), .SFLo = FLo(9), .SBF = BF(9), .SFLD = FLD(9), .SFLM = FLM(9), .sFD = FD(9), .SFMD = FMD(9), .SFMM = FMM(9), .sFLA = FLA(9), .SFM = FM(9), .SFGHA = FGHA(9), .SFDec = FDec(9), .SFHo = FHo(9)}
    'FixData10 = New SFixData With {.SFZH = FZH(10), .SFZM = FZM(10), .SFZS = FZS(10), .SFZN = FZN(10), .SFMI = FMI(10), .SFL = FL(10), .SFLo = FLo(10), .SBF = BF(10), .SFLD = FLD(10), .SFLM = FLM(10), .sFD = FD(10), .SFMD = FMD(10), .SFMM = FMM(10), .sFLA = FLA(10), .SFM = FM(10), .SFGHA = FGHA(10), .SFDec = FDec(10), .SFHo = FHo(10)}
    'FixData11 = New SFixData With {.SFZH = FZH(11), .SFZM = FZM(11), .SFZS = FZS(11), .SFZN = FZN(11), .SFMI = FMI(11), .SFL = FL(11), .SFLo = FLo(11), .SBF = BF(11), .SFLD = FLD(11), .SFLM = FLM(11), .sFD = FD(11), .SFMD = FMD(11), .SFMM = FMM(11), .sFLA = FLA(11), .SFM = FM(11), .SFGHA = FGHA(11), .SFDec = FDec(11), .SFHo = FHo(11)}
    'FixData12 = New SFixData With {.SFZH = FZH(12), .SFZM = FZM(12), .SFZS = FZS(12), .SFZN = FZN(12), .SFMI = FMI(12), .SFL = FL(12), .SFLo = FLo(12), .SBF = BF(12), .SFLD = FLD(12), .SFLM = FLM(12), .sFD = FD(12), .SFMD = FMD(12), .SFMM = FMM(12), .sFLA = FLA(12), .SFM = FM(12), .SFGHA = FGHA(12), .SFDec = FDec(12), .SFHo = FHo(12)}
    'Exit Sub
    'End Sub

    'Public Sub WriteFixScreen()
    '    'load up fix data from SRF1 form into Form4 / Fix form
    '    Form4.FixSelectTxtBx.Clear()

    '    IV = IU
    '    If IU > 12 Then
    '        IV = 12
    '    End If
    '    For IW = 1 To IV
    '        i = IW
    '        If IU > 12 Then
    '            i = IW + IU - Int((IU - 1) / 12) * 12
    '        End If
    '        Form4.FixSelectTxtBx.AppendText(BF(i) & vbTab & vbTab & Strings.Format(FZH(i), "00") & "-" & Strings.Format(FZM(i), "00") & "-" & Strings.Format(FZS(i), "00") _
    '        & vbTab & vbTab & Strings.Format(System.Math.Abs(FMI(i)), "0.0") & " " & FD(i) _
    '        & vbTab & Strings.Format(FZN(i), "000") & Chr(176) _
    '        & vbTab & Strings.Format(Val(FLD(i)), "00") & Chr(176) & Strings.Format(Val(FLM(i)), "00.0") & "'" & FLA(i) _
    '        & Space(4) & Strings.Format(Val(FMD(i)), "##0") & Chr(176) & Strings.Format(Val(FMM(i)), "00.0") & "'" & FM(i) & vbNewLine & vbNewLine)
    '    Next IW
    '    Form4.FixSelectTxtBx.Refresh()
    '    Form4.Show()
    '    Exit Sub
    'End Sub

    Public Sub DisplayTimeDiagram()
        Dim XTD1, YTD1 As Single
        Dim XTD2, YTD2 As Single
        Dim TwoPi, i As Single
        'FormSRF.Font.Name = "MS Sans Serif"
        TwoPi = 8 * System.Math.Atan(1)
        EqTPicBx.Enabled = True
        EqTPicBx.Visible = True
        'RecycleSRF1Jpg()

        'set up fresh / new bitmap and graphics drawwing object for diagram and later additions
        Dim DrawWidth As Integer = (EqTPicBx.Height / 2) - 20
        bm = New Bitmap(EqTPicBx.Width, EqTPicBx.Height)
        SRF1graphic = Graphics.FromImage(bm)
        SRF1graphic.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        SRF1graphic.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAliasGridFit
        SRF1graphic.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
        SRF1graphic.TranslateTransform(EqTPicBx.Width / 2, EqTPicBx.Height / 2)

        Dim DPen As Pen = New Pen(Color.Black, 1)
        Dim DFontArial7Reg As Font = New Font("Arial", 7, FontStyle.Regular)
        Dim DFontArial8Reg As Font = New Font("Arial", 8, FontStyle.Regular)
        DPen.DashStyle = Drawing2D.DashStyle.Solid
        Dim ptA As Point = New Point
        Dim ptB As Point = New Point

        Dim CircleRadii As Integer = DrawWidth + 5

        SRF1graphic.DrawEllipse(DPen, -(CircleRadii), -(CircleRadii), 2 * CircleRadii, 2 * CircleRadii)

        For i = 0 To TwoPi Step TwoPi / 72
            XTD1 = DrawWidth * System.Math.Cos(i) '600
            YTD1 = DrawWidth * System.Math.Sin(i) '600
            XTD2 = (DrawWidth + 5) * System.Math.Cos(i)
            YTD2 = (DrawWidth + 5) * System.Math.Sin(i)
            SRF1graphic.DrawLine(DPen, XTD1, YTD1, XTD2, YTD2)
        Next i
        For i = 0 To TwoPi Step TwoPi / 24
            XTD1 = (DrawWidth - 5) * System.Math.Cos(i) '600
            YTD1 = (DrawWidth - 5) * System.Math.Sin(i) '600
            XTD2 = (DrawWidth) * System.Math.Cos(i)
            YTD2 = (DrawWidth) * System.Math.Sin(i)
            SRF1graphic.DrawLine(DPen, XTD1, YTD1, XTD2, YTD2)
        Next i
        ' make M / m meridian lables appear
        ' draw meridian line to the top
        SRF1graphic.DrawLine(DPen, 0, 0, 0, -(CircleRadii))
        SRF1graphic.DrawString("M", DFontArial8Reg, Brushes.Black, -6, -CircleRadii - 15)
        ' draw lower meridian line
        DPen.DashStyle = Drawing2D.DashStyle.Dash
        SRF1graphic.DrawLine(DPen, 0, 0, 0, (CircleRadii))
        SRF1graphic.DrawString("m", DFontArial7Reg, Brushes.Black, -5, CircleRadii + 5)
        ' if only drawwing basic time circle for initial load then stop here and exit - set true in form load 
        If DrawBasicTimeDiagram = True Then
            DrawBasicTimeDiagram = False
            GoTo ExitDrawTime
        End If
        ' otherwise continue on drawwing rest of time diagram for sight reduction data entered
        'Greenwich lower branch
        XTD1 = CircleRadii * (System.Math.Cos((90 + Lo) * Pi / 180))
        YTD1 = CircleRadii * (System.Math.Sin((90 + Lo) * Pi / 180))
        SRF1graphic.DrawLine(DPen, 0, 0, XTD1, YTD1)

        Dim PtText As Point = New Point(XTD1, YTD1)
        PtText = SetPrintTextPt(PtText, 10, 10)
        SRF1graphic.DrawString("g", DFontArial7Reg, Brushes.Black, PtText)
        DPen.DashStyle = Drawing2D.DashStyle.Solid
        'Greenwich upper branch
        XTD1 = CircleRadii * (System.Math.Cos((-90 + Lo) * Pi / 180))
        YTD1 = CircleRadii * (System.Math.Sin((-90 + Lo) * Pi / 180))
        SRF1graphic.DrawLine(DPen, 0, 0, XTD1, YTD1)

        PtText = New Point(XTD1, YTD1)
        PtText = SetPrintTextPt(PtText, 10, 10)
        SRF1graphic.DrawString("G", DFontArial7Reg, Brushes.Black, PtText)

        'Aries (if star sight)
        If BN <= 57 Then
            XTD1 = CircleRadii * (System.Math.Cos((-90 + Lo - GHAAries) * Pi / 180))
            YTD1 = CircleRadii * (System.Math.Sin((-90 + Lo - GHAAries) * Pi / 180))
            SRF1graphic.DrawLine(DPen, 0, 0, XTD1, YTD1)
            PtText = New Point(XTD1, YTD1)
            PtText = SetPrintTextPt(PtText, 10, 10)
            SRF1graphic.DrawString(Aries_Uchar, DFontArial7Reg, Brushes.Black, PtText)
            'SRF1graphic.DrawString("V", DFontArial7Reg, Brushes.Black, PtText)
        End If

        Dim DString As String = vbNullString

        'Any body other than Sun
        If BN < 64 Then
            XTD1 = CircleRadii * (System.Math.Cos((-LHA - 90) * Pi / 180))
            YTD1 = CircleRadii * (System.Math.Sin((-LHA - 90) * Pi / 180))
            SRF1graphic.DrawLine(DPen, 0, 0, XTD1, YTD1)

            If BN <= 57 Then
                DString = Black_Star_Uchar.ToString '"*"
            End If
            If BN >= 58 And BN <= 61 Then
                Select Case BNBodyName
                    Case "Mercury"
                        DString = Mercury_Uchar
                    Case "Venus"
                        DString = Venus_Uchar
                    Case "Mars"
                        DString = Mars_Uchar
                    Case "Jupiter"
                        DString = Jupiter_Uchar
                    Case "Saturn"
                        DString = Saturn_Uchar
                    Case "Neptune"
                        DString = Neptune_Uchar
                    Case "Uranus"
                        DString = Uranus_Uchar
                    Case "Pluto"
                        DString = Pluto_Uchar
                    Case Else
                        DString = "P"
                End Select

            End If
            If BN = 62 Or BN = 63 Then
                Select Case BNBodyName
                    Case "Moon"
                        DString = Moon_FirstQtr_Uchar
                    Case Else
                        DString = "("
                End Select

            End If

            PtText = New Point(XTD1, YTD1)
            PtText = SetPrintTextPt(PtText, 10, 10)
            SRF1graphic.DrawString(DString, DFontArial7Reg, Brushes.Black, PtText)
        End If
        GetValidBN()
        'Mean Sun for all sights except sun
        If BNType <> "Sun" Then

            'If BN <= 63 Then
            'T = Tfull
            Sun()
            HourAngles()

            XTD1 = CircleRadii * (System.Math.Cos((90 + Lo - HG * 15) * Pi / 180))
            YTD1 = CircleRadii * (System.Math.Sin((90 + Lo - HG * 15) * Pi / 180))
            SRF1graphic.DrawLine(DPen, 0, 0, XTD1, YTD1)
            PtText = New Point(XTD1, YTD1)
            PtText = SetPrintTextPt(PtText, 10, 10)
            SRF1graphic.DrawString(Sun_Uchar.ToString, DFontArial8Reg, Brushes.Black, PtText)
        Else
            'GetValidBN()
            'Apparent sun for sun sight
            'If BN = 64 Or BN = 65 Then

            'T = Tfull
            Sun()
            HourAngles()

            XTD1 = CircleRadii * (System.Math.Cos((90 + Lo - HG * 15) * Pi / 180))
            YTD1 = CircleRadii * (System.Math.Sin((90 + Lo - HG * 15) * Pi / 180))
            SRF1graphic.DrawLine(DPen, 0, 0, XTD1, YTD1)
            PtText = New Point(XTD1, YTD1)
            PtText = SetPrintTextPt(PtText, 10, 10)
            SRF1graphic.DrawString(Sun_Uchar.ToString, DFontArial8Reg, Brushes.Black, PtText)

            XTD1 = CircleRadii * (System.Math.Cos((-90 + Lo - HG * 15) * Pi / 180))
            YTD1 = CircleRadii * (System.Math.Sin((-90 + Lo - HG * 15) * Pi / 180))
            'XTD1 = CircleRadii * (System.Math.Cos((-90 - LHA) * (Pi / 180)))
            'YTD1 = CircleRadii * (System.Math.Sin((-90 - LHA) * (Pi / 180)))
            SRF1graphic.DrawLine(DPen, 0, 0, XTD1, YTD1)
            PtText = New Point(XTD1, YTD1)
            PtText = SetPrintTextPt(PtText, 10, 10)
            SRF1graphic.DrawString(Sun_Uchar.ToString, DFontArial7Reg, Brushes.Blue, PtText)
        End If

        If DrawEqTDiagram = False Then
            GoTo ExitDrawTime
        End If

        JD = Int(365.25 * (GYearJ + 4716)) + Int(30.6001 * (GMonth + 1)) + DecimalDate - 1537.5 'or else JD incorrect for planets
        Dim x As Integer = 0
        Dim y As Integer = 0

        'Mean Sun for sun sight
        If BN = 64 Or BN = 65 Then
            Sun()
            HourAngles()
            DPen.DashStyle = Drawing2D.DashStyle.Solid
            EqTinSeconds = GHA * 240 - UTinSeconds
            Do While System.Math.Abs(EqTinSeconds) >= 1020 '17 minutes
                If EqTinSeconds >= 0 Then
                    EqTinSeconds = EqTinSeconds - 43200 '43200 is 12 hours in second
                    If EqTinSeconds < 0 Then Exit Do
                End If
                If EqTinSeconds < 0 Then
                    EqTinSeconds = EqTinSeconds + 43200 '43200 is 12 hours in seconds
                    If EqTinSeconds >= 0 Then Exit Do
                End If
            Loop
            Dim HGCalc As Double = (EqTinSeconds / 60)
            XTD1 = CircleRadii * (System.Math.Cos((-90 - LHA + HGCalc) * Pi / 180))
            YTD1 = CircleRadii * (System.Math.Sin((-90 - LHA + HGCalc) * Pi / 180))
            SRF1graphic.DrawLine(DPen, 0, 0, XTD1, YTD1)
            PtText = New Point(XTD1, YTD1)
            PtText = SetPrintTextPt(PtText, 10, 10)
            SRF1graphic.DrawString(Sun_Uchar.ToString.ToString, DFontArial8Reg, Brushes.Black, PtText)
            'SRF1graphic.DrawString("O", DFontArial7Reg, Brushes.Black, PtText)
        End If

        T = Tfull
        'Apparent sun for all sights except sun
        If BN <= 63 Then
            BN = 64
            Sun()
            HourAngles()
            DPen.DashStyle = Drawing2D.DashStyle.Solid
            XTD1 = CircleRadii * (System.Math.Cos((-LHA - 90) * Pi / 180))
            YTD1 = CircleRadii * (System.Math.Sin((-LHA - 90) * Pi / 180))
            SRF1graphic.DrawLine(DPen, 0, 0, XTD1, YTD1)
            PtText = New Point(XTD1, YTD1)
            PtText = SetPrintTextPt(PtText, 10, 10)
            SRF1graphic.DrawString(Sun_Uchar.ToString, DFontArial8Reg, Brushes.Black, PtText)
            'SRF1graphic.DrawString("o", DFontArial7Reg, Brushes.Black, PtText)
        End If
        'Get LHA Sun for EqT
        BN = 64
        Sun()
        HourAngles()
        'If GHA < 180 Then EqTinSeconds = GHA * 240 - (UTinSeconds - 43200) '43200 is 12 hours in seconds
        'If GHA >= 180 Then EqTinSeconds = GHA * 240 - (UTinSeconds + 43200) '43200 is 12 hours in seconds
        EqTinSeconds = GHA * 240 - UTinSeconds
        Do While System.Math.Abs(EqTinSeconds) >= 1020 '17 minutes
            If EqTinSeconds >= 0 Then
                EqTinSeconds = EqTinSeconds - 43200 '43200 is 12 hours in second
                If EqTinSeconds < 0 Then Exit Do
            End If
            If EqTinSeconds < 0 Then
                EqTinSeconds = EqTinSeconds + 43200 '43200 is 12 hours in seconds
                If EqTinSeconds >= 0 Then Exit Do
            End If
        Loop
        EqTminutes = Int(System.Math.Abs(EqTinSeconds / 60))
        EqTseconds = System.Math.Abs(EqTinSeconds) - EqTminutes * 60

        XTD1 = -(CircleRadii + 10)
        YTD1 = -(CircleRadii + 10)

        If System.Math.Sign(EqTinSeconds) = 1 Then DString = ("(+)")
        If System.Math.Sign(EqTinSeconds) = 0 Then DString = ("   ")
        If System.Math.Sign(EqTinSeconds) = -1 Then DString = ("(-)")
        DString &= (Strings.Format(EqTminutes, "00") & "m" & Strings.Format(EqTseconds, "00") & "s")
        SRF1graphic.DrawString(DString, DFontArial7Reg, Brushes.Black, XTD1, YTD1)
ExitDrawTime:
        If System.IO.File.Exists(BMFname) Then
            System.IO.File.Delete(BMFname)
        End If
        bm.Save(BMFname)
        EqTPicBx.ImageLocation = BMFname

        EqTPicBx.Refresh()
        bm.Dispose()
        DPen.Dispose()
        DFontArial7Reg.Dispose()
        DFontArial8Reg.Dispose()
        Exit Sub
    End Sub

    '    Public Sub SaveDisplayBMFname()
    '        Try
    '            RecycleSRF1Jpg()
    '            bm.Save(BMFname)
    '            EqTPicBx.Refresh()
    '            Exit Sub
    '        Catch ex1 As System.Runtime.InteropServices.ExternalException
    '            Exit Sub
    '        Catch ex As Exception
    '            Dim file As System.IO.StreamWriter
    '            file = My.Computer.FileSystem.OpenTextFileWriter("SRF1Log.txt", True)
    '            file.WriteLine(Now.ToLongDateString & Space(2) & Now.ToLongTimeString & " - " & "Try #1 - Exception on BM Save: Name = " & BMFname & Space(2) & "  Exception: " & ex.ToString)
    '            file.Close()
    '            GoTo TryAgain
    '        Finally
    '        End Try
    'TryAgain:
    '        Try
    '            RecycleSRF1Jpg()
    '            bm.Save(BMFname)
    '            EqTPicBx.Refresh()
    '            Exit Sub
    '        Catch ex1 As System.Runtime.InteropServices.ExternalException
    '            Exit Sub
    '        Catch ex As Exception
    '            Dim file As System.IO.StreamWriter
    '            file = My.Computer.FileSystem.OpenTextFileWriter("SRF1Log.txt", True)
    '            file.WriteLine(Now.ToLongDateString & Space(2) & Now.ToLongTimeString & " - " & "Try #2 - Exception on BM Save: Name =" & BMFname & "Exception: " & ex.ToString)
    '            file.Close()
    '            Exit Sub
    '        End Try
    '        EqTPicBx.Refresh()
    '        Exit Sub
    '    End Sub
    'Public Sub RecycleSRF1Jpg()
    '    Dim NowTimeStr As String = Now.ToLongTimeString.Replace(":", "").Replace(" ", "").Replace("-", "").Replace("/", "").Trim
    '    Randomize()
    '    Dim RandomInt As Single = Rnd().ToString("####0")
    '    BMFname = "./Graphics/SRFForm" & NowTimeStr & RandomInt.ToString.Replace(".", "") + ".jpg"
    '    Exit Sub
    'End Sub

    Public Sub PolarisMeans()
        MeanSHAPol = 0
        MeanDecPol = 0 ': GHour = 12 : GMinute = 0: GSecond = 0
        For MonthPolaris = 1 To 12
            GreenwichForPolaris()
            Delta_T()
            JulianForPolaris()
            '        Obliquity
            '        Nutation
            Stars()
            HourAngles()
            MeanSHAPol = MeanSHAPol + SH
            MeanDecPol = MeanDecPol + DE
        Next MonthPolaris
        MeanSHAPol = (MeanSHAPol / 12) '- 0.033333       'without -0.033333 MeanSHAPol averages about 2' greater than stated on page 256 of the Nautical Almanac (2009-2015 tested)
        MeanDecPol = (MeanDecPol / 12)
        Exit Sub
    End Sub

    Public Sub GreenwichForPolaris()
        'Prefix (or suffix) G for Greenwich, UT = Universal Time
        MonthDays = "312831303130313130313031"
        'Check for local leap year
        LocalYear = DTSight.Value.Year

        'If (LocalYear Mod 4) = 0 Then
        '    LeapYear = True
        'End If
        'If (LocalYear Mod 100) = 0 And (LocalYear Mod 400) <> 0 Then
        '    LeapYear = False
        'End If
        LeapYear = DateTime.IsLeapYear(LocalYear)
        If LeapYear = True Then
            MonthDays = "312931303130313130313031"
        Else
            MonthDays = "312831303130313130313031"
        End If
        DayNumber = 0
        For i = 1 To MonthPolaris - 1
            DayNumber = Val(Mid(MonthDays, 2 * i - 1, 2)) + DayNumber
        Next i
        If MonthPolaris >= 3 And LeapYear = True Then
            DayNumber = DayNumber + 1
        End If
        GYear = DTSight.Value.Year
        GDayOfYear = DayNumber
        If (GDayOfYear = 366 And LeapYear = False) Or GDayOfYear = 367 Then
            GDayOfYear = 1
            GYear = GYear + 1
            GoTo GreenwichDate
        End If
        'Check for leap year at Greenwich
        'If (GYear Mod 4) = 0 Then
        '    GLeapYear = True
        'End If
        'If (GYear Mod 100) = 0 And (GYear Mod 400) <> 0 Then
        '    GLeapYear = False
        'End If
        GLeapYear = DateTime.IsLeapYear(GYear)
        'Days in year
        If GDayOfYear = 0 And GLeapYear = False Then
            GDayOfYear = 365
        End If
        If GDayOfYear = 0 And GLeapYear = True Then
            GDayOfYear = 366
        End If

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
        Exit Sub
    End Sub

    Public Sub JulianForPolaris()  'UNFINISHED?
        DecimalDate = GDay + (GHour / 24) + (GMinute / 1440) + (GSecond / 86400.0!)
        DecimalDateHour1 = GDay + (GHour / 24)
        DecimalDateHour2 = GDay + ((GHour + 1) / 24)
        GYearJ = GYear
        GMonth = MonthPolaris
        If GMonth < 3 Then GYearJ = GYear - 1
        GMonth = GMonth + 12
        JD = Int(365.25 * (GYearJ + 4716)) + Int(30.6001 * (GMonth + 1)) + DecimalDate - 1537.5
        T = (JD - 2451545 + DeltaT / 86400) / 36525.0!
        Exit Sub
    End Sub

    Public Sub Delta_T()
        ' reference this URL: http://eclipse.gsfc.nasa.gov/SEhelp/deltatpoly2004.html for concepts for this code
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
        If GYear >= 2006 And GYear <= 2050 Then             'V5.6.1 could replace 2050 with 2009
            Theta = DecYr - 2000
            DeltaT = 62.92 + 0.32217 * Theta + 0.005589 * Theta ^ 2
        End If
        'Next line NOT added in V5.6.1.  For June 1, 2017, predicted DeltaT value 70.2481, measured DeltaT value 68.8033.  With this change predicted value becomes 68.7579
        'If GYear >= 2010 And GYear <= 2099 Then DeltaT = 66.0699 + (DecYr - 2010) * 0.3604 'DeltaT increasing an average of about 0.36 seconds per year since the beginning of 2010 (66.0699)
        If GYear >= 2051 And GYear <= 2099 Then
            DeltaT = -20 + 32 * ((DecYr - 1820) / 100) ^ 2 - 0.5628 * (2150 - DecYr)        'NOT removed in V5.6.1
        End If
        Exit Sub
    End Sub

    Public Sub IandC()
        Select Case BN
            Case 0 To 57 ' is this a star sight
                k = g_AriesHrDeg
                'k = 15.04106864
            Case 58 To 61 ' is this a planet sight
                k = g_SunPlanetsHrDeg
                'k = 15
            Case 62, 63 ' is this a moon sight
                k = g_MoonHrDeg
                'k = 14 + 19 / 60
            Case 64, 65 ' is this a sun sight UL or LL
                k = g_SunPlanetsHrDeg
                'k = 15
        End Select
        ' is this a moon sight (BN = 62 or 63),use rounded values
        If BN = 62 Or BN = 63 Then
            GHAHourDeg1 = Int(GHAHour1)
            GHAHourMin1 = (GHAHour1 - GHAHourDeg1) * 60
            GHAHourMin1 = Int(GHAHourMin1 * 10 + 0.5) / 10
            If GHAHourMin1 = 60 Then
                GHAHourMin1 = 0
                GHAHourDeg1 = GHAHourDeg1 + 1
            End If
            GHAHourDeg2 = Int(GHAHour2)
            GHAHourMin2 = (GHAHour2 - GHAHourDeg2) * 60
            GHAHourMin2 = Int(GHAHourMin2 * 10 + 0.5) / 10
            If GHAHourMin2 = 60 Then
                GHAHourMin2 = 0
                GHAHourDeg2 = GHAHourDeg2 + 1
            End If
            HourChange = (GHAHourDeg2 + GHAHourMin2 / 60) - (GHAHourDeg1 + GHAHourMin1 / 60)
        End If

        'not moon
        If BN <> 62 And BN <> 63 Then
            HourChange = GHAHour2 - GHAHour1
        End If
        If HourChange < 0 Then
            HourChange = HourChange + 360
        End If
        vvalue = HourChange - k
        vvalue = vvalue * 60
        vvalue = Int(vvalue * 10 + 0.5) / 10 'This line was lower
        If (BN <= 57 And BN >= 62) Or (BN > 57 And BN < 62 And cboPlanets.Text = "Accurate vals. of v/d") And GMinute = 0 And GSecond = 0 Then
            vvalue = 0
        End If

        SignHourChange = System.Math.Sign(vvalue)
        GHAIncrement = k * (GMinute + GSecond / 60) / 60
        vcorr = vvalue * (GMinute + 0.5) / 60

        GHAIncrementDeg = Int(GHAIncrement)
        GHAIncrementMin = (GHAIncrement - GHAIncrementDeg) * 60
        GHAIncrementMin = Int(GHAIncrementMin * 10 + 0.500000000001) / 10
        'vvalue = Int(vvalue * 10 + 0.5) / 10
        'vcorr = Int(vcorr * 10 + 0.50000000000001) / 10
        vcorr = System.Math.Sign(vcorr) * Int(System.Math.Abs(vcorr) * 10 + 0.50000000000001) / 10
        If (GMinute = 22 And vvalue = 2.8) Then
            vcorr = 1.0
        End If
        If (GMinute = 22 And vvalue = 16.4) Then
            vcorr = 6.1
        End If
        If (GMinute = 42 And vvalue = 15.6) Then
            vcorr = 11.1
        End If
        If (GMinute = 52 And vvalue = 13.2) Then
            vcorr = 11.6
        End If
        If (GMinute = 52 And vvalue = 17.2) Then
            vcorr = 15.1
        End If
        If (GMinute = 55 And vvalue = 18) Then
            vcorr = 16.7
        End If
        If (GMinute = 57 And vvalue = 13.2) Then
            vcorr = 12.7
        End If
        If GMinute = 0 And GSecond = 0 Then
            vcorr = 0 'Add this line to not add correction to whole hour value
        End If

        If GYear <= 2001 And (GMinute = 22 And vvalue = 2.8) Then
            vcorr = 1.0
        End If
        If GYear <= 2001 And (GMinute = 22 And vvalue = 16.4) Then
            vcorr = 6.1
        End If
        If GYear <= 2001 And (GMinute = 52 And vvalue = 9.2) Then
            vcorr = 8.1
        End If
        If GYear <= 2001 And (GMinute = 52 And vvalue = 16.4) Then
            vcorr = 14.4
        End If

        GHAHourDeg1 = Int(GHAHour1)
        GHAHourMin1 = (GHAHour1 - GHAHourDeg1) * 60
        GHAHourMin1 = Int(GHAHourMin1 * 10 + 0.5) / 10
        If GHAHourMin1 = 60 Then
            GHAHourMin1 = 0
            GHAHourDeg1 = GHAHourDeg1 + 1
        End If

        If BN <= 57 Then
            If StarNAFlag = False Then
                TotGHA = SHdeg + SHmin / 60 + GHAHourDeg1 + GHAHourMin1 / 60 + GHAIncrementDeg + GHAIncrementMin / 60
            End If
            If StarNAFlag = True Then
                TotGHA = SHdegDisplay + SHminDisplay / 60 + GHAHourDeg1 + GHAHourMin1 / 60 + GHAIncrementDeg + GHAIncrementMin / 60
            End If
        End If

        If BN >= 58 Then
            TotGHA = GHAHourDeg1 + GHAHourMin1 / 60 + GHAIncrementDeg + GHAIncrementMin / 60 '+ Sgn(HourChange) * vcorr / 60
            If BN <> 64 And BN <> 65 Or ((BN = 64 Or BN = 65) And cboSun.Text = "Accurate val. of hourly GHA") Then
                TotGHA = TotGHA + System.Math.Sign(HourChange) * vcorr / 60
            End If

        End If
        'If BN >= 58 Then TotGHA = GHAHourDeg1 * 60 + GHAHourMin1 + Int(GHAIncrement * 600 + 0.5) / 10 + Sgn(HourChange) * vcorr: TotGHA = TotGHA / 60
        TotGHADeg = Int(TotGHA)
        TotGHAMin = (TotGHA - TotGHADeg) * 60
        TotGHAMin = Int(TotGHAMin * 10 + 0.50000000001) / 10 'THIS MAKES ROUNDING COME OUT RIGHT BUT GHA BETTER WITHOUT IT
        If TotGHAMin = 60 Then
            TotGHAMin = 0
            TotGHADeg = TotGHADeg + 1
        End If
        If TotGHADeg >= 360 Then
            TotGHADeg = TotGHADeg - 360
        End If
        'LHA = TotGHA - Lo
        LHA = TotGHADeg + TotGHAMin / 60 - Lo
        If LHA >= 360 Then
            LHA = LHA - 360
        End If
        If LHA < 0 Then LHA = LHA + 360
        LHADeg = Int(LHA)
        LHAMin = (LHA - LHADeg) * 60
        If Int(LHAMin * 10 + 0.5) / 10 = 60 Then
            LHAMin = 0
            LHADeg = LHADeg + 1
        End If

        If BN = 62 Or BN = 63 Then 'moon, use rounded values
            DecDegrees = Int(System.Math.Abs(DE1))
            DecMinutes = (System.Math.Abs(DE1) - DecDegrees) * 60
            DecMinutes = Int(DecMinutes * 10 + 0.5) / 10
            If Int(DecMinutes * 10 + 0.5) / 10 = 60 Then
                DecMinutes = 0
                DecDegrees = DecDegrees + 1
            End If
            DecDegrees2 = Int(System.Math.Abs(DE2))
            DecMinutes2 = (System.Math.Abs(DE2) - DecDegrees2) * 60
            DecMinutes2 = Int(DecMinutes2 * 10 + 0.5) / 10
            If Int(DecMinutes2 * 10 + 0.5) / 10 = 60 Then
                DecMinutes2 = 0
                DecDegrees2 = DecDegrees2 + 1
            End If
            dvalue = (System.Math.Sign(DE2) * (DecDegrees2 + DecMinutes2 / 60) - System.Math.Sign(DE1) * (DecDegrees + DecMinutes / 60)) * 60
        End If
        'not moon
        If BN <> 62 And BN <> 63 Then
            dvalue = (DE2 - DE1) * 60
        End If
        'next line added sun stuff in V5.3.1
        If ((BN > 57 And BN < 62) And cboPlanets.Text = "NA vals. of v/d") Or (BN = 64 Or BN = 65 And cboSun.Text = "NA val. of hourly GHA/d") Then
            dvalue = (DENA2 - DENA1) * 60
        End If
        dvalue = Int(System.Math.Abs(dvalue) * 10 + 0.5) / 10 'This line was lower
        Signdvalue = 1
        If System.Math.Abs(DE2) < System.Math.Abs(DE1) Then
            Signdvalue = -1
        End If
        DecDegrees = Int(System.Math.Abs(DE1))
        DecMinutes = (System.Math.Abs(DE1) - DecDegrees) * 60
        If Int(DecMinutes * 10 + 0.5) / 10 = 60 Then
            DecMinutes = 0
            DecDegrees = DecDegrees + 1
        End If

        If System.Math.Sign(DE2) <> System.Math.Sign(DE1) And System.Math.Sign(DE2) <> 0 And System.Math.Sign(DE1) <> 0 Then
            Signdvalue = -1
        End If
        dvalue = System.Math.Abs(dvalue)
        If GMinute = 0 And GSecond = 0 Then dvalue = 0 'Add this line to not add correction to whole hour value
        If dvalue < 0.05 Then Signdvalue = 0
        dcorr = dvalue * (GMinute + 0.5) / 60
        dcorr = Int(System.Math.Abs(dcorr) * 10 + 0.50000000000001) / 10
        If GMinute = 0 And GSecond = 0 Then
            dcorr = 0 'Add this line to not add correction to whole hour value
        End If

        If GYear <= 2001 And (GMinute = 22 And dvalue = 2.8) Then
            dcorr = 1.0#
        End If
        If GYear <= 2001 And (GMinute = 22 And dvalue = 16.4) Then
            dcorr = 6.1
        End If
        If GYear <= 2001 And (GMinute = 52 And dvalue = 9.2) Then
            dcorr = 8.1
        End If
        If GYear <= 2001 And (GMinute = 52 And dvalue = 16.4) Then
            dcorr = 14.4
        End If
        If BN <= 57 And StarNAFlag = False Then
            TotDE = DE1
        End If
        If BN <= 57 And StarNAFlag = True Then
            TotDE = DENA
        End If
        If BN > 57 Then
            TotDE = System.Math.Sign(DE1) * (Int(System.Math.Abs(DE1) * 600 + 0.5) / 10 + Signdvalue * dcorr)
            TotDE = TotDE / 60
        End If
        TotDecDegrees = Int(System.Math.Abs(TotDE))
        TotDecMinutes = (System.Math.Abs(TotDE) - TotDecDegrees) * 60
        TotDecMinutes = Int(TotDecMinutes * 10 + 0.5) / 10
        If TotDecMinutes = 60 Then
            TotDecMinutes = 0
            TotDecDegrees = TotDecDegrees + 1
        End If
    End Sub
    Public Sub IandCP()
        SignHourChange = System.Math.Sign(vvalue)
        GHAIncrement = 15 * (GMinute + GSecond / 60) / 60
        GHAIncrementDeg = Int(GHAIncrement)
        GHAIncrementMin = (GHAIncrement - GHAIncrementDeg) * 60
        GHAIncrementMin = Int(GHAIncrementMin * 10 + 0.500000000001) / 10
        vcorr = vvalue * (GMinute + 0.5) / 60
        vcorr = System.Math.Sign(vcorr) * Int(System.Math.Abs(vcorr) * 10 + 0.50000000000001) / 10
        If (GMinute = 22 And vvalue = 2.8) Then
            vcorr = 1.0#
        End If
        If (GMinute = 22 And vvalue = 16.4) Then
            vcorr = 6.1
        End If
        If (GMinute = 42 And vvalue = 15.6) Then
            vcorr = 11.1
        End If
        If (GMinute = 52 And vvalue = 13.2) Then
            vcorr = 11.6
        End If
        If (GMinute = 52 And vvalue = 17.2) Then
            vcorr = 15.1
        End If
        If (GMinute = 55 And vvalue = 18) Then
            vcorr = 16.7
        End If
        If (GMinute = 57 And vvalue = 13.2) Then
            vcorr = 12.7
        End If
        If GMinute = 0 And GSecond = 0 Then
            vcorr = 0 'Add this line to not add correction to whole hour value
        End If

        If GYear <= 2001 And (GMinute = 22 And vvalue = 2.8) Then
            vcorr = 1.0#
        End If
        If GYear <= 2001 And (GMinute = 22 And vvalue = 16.4) Then
            vcorr = 6.1
        End If
        If GYear <= 2001 And (GMinute = 52 And vvalue = 9.2) Then
            vcorr = 8.1
        End If
        If GYear <= 2001 And (GMinute = 52 And vvalue = 16.4) Then
            vcorr = 14.4
        End If

        GHAHourDeg1 = Int(GHAHour1)
        GHAHourMin1 = (GHAHour1 - GHAHourDeg1) * 60
        GHAHourMin1 = Int(GHAHourMin1 * 10 + 0.5) / 10
        If GHAHourMin1 = 60 Then
            GHAHourMin1 = 0
            GHAHourDeg1 = GHAHourDeg1 + 1
        End If

        TotGHA = GHAHourDeg1 + GHAHourMin1 / 60 + GHAIncrementDeg + GHAIncrementMin / 60 '+ Sgn(HourChange) * vcorr / 60
        TotGHA = TotGHA + System.Math.Sign(HourChange) * vcorr / 60
        TotGHADeg = Int(TotGHA)
        TotGHAMin = (TotGHA - TotGHADeg) * 60
        TotGHAMin = Int(TotGHAMin * 10 + 0.50000000001) / 10 'THIS MAKES ROUNDING COME OUT RIGHT BUT GHA BETTER WITHOUT IT
        If TotGHAMin = 60 Then
            TotGHAMin = 0
            TotGHADeg = TotGHADeg + 1
        End If
        If TotGHADeg >= 360 Then
            TotGHADeg = TotGHADeg - 360
        End If
        'LHA = TotGHA - Lo
        LHA = TotGHADeg + TotGHAMin / 60 - Lo
        If LHA >= 360 Then
            LHA = LHA - 360
        End If
        If LHA < 0 Then
            LHA = LHA + 360
        End If
        LHADeg = Int(LHA)
        LHAMin = (LHA - LHADeg) * 60
        If Int(LHAMin * 10 + 0.5) / 10 = 60 Then
            LHAMin = 0
            LHADeg = LHADeg + 1
        End If

        'next two lines try to fix Egbert's problem of 2/20/2016
        DecDegrees = Int(System.Math.Abs(DE1))
        DecMinutes = (System.Math.Abs(DE1) - DecDegrees) * 60
        If Int(DecMinutes * 10 + 0.5) / 10 = 60 Then
            DecMinutes = 0
            DecDegrees = DecDegrees + 1
        End If

        dvalue = (DENA2 - DENA1) * 60
        dvalue = Int(System.Math.Abs(dvalue) * 10 + 0.5) / 10 'This line was lower
        Signdvalue = 1
        If System.Math.Abs(DE2) < System.Math.Abs(DE1) Then
            Signdvalue = -1
        End If

        If System.Math.Sign(DE2) <> System.Math.Sign(DE1) And System.Math.Sign(DE2) <> 0 And System.Math.Sign(DE1) <> 0 Then
            Signdvalue = -1
        End If
        dvalue = System.Math.Abs(dvalue)
        If GMinute = 0 And GSecond = 0 Then
            dvalue = 0 'Add this line to not add correction to whole hour value
        End If
        If dvalue < 0.05 Then
            Signdvalue = 0
        End If
        dcorr = dvalue * (GMinute + 0.5) / 60
        dcorr = Int(System.Math.Abs(dcorr) * 10 + 0.50000000000001) / 10
        If GMinute = 0 And GSecond = 0 Then
            dcorr = 0 'Add this line to not add correction to whole hour value
        End If

        If GYear <= 2001 And (GMinute = 22 And dvalue = 2.8) Then
            dcorr = 1.0#
        End If
        If GYear <= 2001 And (GMinute = 22 And dvalue = 16.4) Then
            dcorr = 6.1
        End If
        If GYear <= 2001 And (GMinute = 52 And dvalue = 9.2) Then
            dcorr = 8.1
        End If
        If GYear <= 2001 And (GMinute = 52 And dvalue = 16.4) Then
            dcorr = 14.4
        End If
        TotDE = System.Math.Sign(DE1) * (Int(System.Math.Abs(DE1) * 600 + 0.5) / 10 + Signdvalue * dcorr)
        TotDE = TotDE / 60
        TotDecDegrees = Int(System.Math.Abs(TotDE))
        TotDecMinutes = (System.Math.Abs(TotDE) - TotDecDegrees) * 60
        TotDecMinutes = Int(TotDecMinutes * 10 + 0.5) / 10
        If TotDecMinutes = 60 Then
            TotDecMinutes = 0
            TotDecDegrees = TotDecDegrees + 1
        End If
        Exit Sub
    End Sub
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
        If D >= 2 * Pi Or D < 0 Then
            D = D - Int(D / (2 * Pi)) * 2 * Pi
        End If
        AR = D + Pre2 'radians
        DE = System.Math.Atan(C / (System.Math.Sqrt(-C * C + 1) + 9.999999E-21)) 'arcsin(C), radians
        Exit Sub
    End Sub
    Private Sub SelectAllText(ByRef TB As System.Windows.Forms.TextBox)
        TB.SelectionStart = 0
        TB.SelectionLength = Len(TB.Text)
    End Sub

    Public Sub SetTxtBxUlineOn(ByRef TB As System.Windows.Forms.TextBox)
        TB.Font = New Font(TB.Font, FontStyle.Underline)
    End Sub
    Public Sub SetTxtBxBoldOn(ByRef TB As System.Windows.Forms.TextBox)
        TB.Font = New Font(TB.Font, FontStyle.Bold)
    End Sub
    Public Sub SetTxtBxtoReg(ByRef TB As System.Windows.Forms.TextBox)
        TB.Font = New Font(TB.Font, FontStyle.Regular)
    End Sub
    Public Sub CleanOutOldFiles()
        On Error GoTo ErrorExit
        For Each foundFile As String In My.Computer.FileSystem.GetFiles(My.Computer.FileSystem.CurrentDirectory & "./Graphics",
            Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, "SRF*.jpg")
            My.Computer.FileSystem.DeleteFile(foundFile)
        Next
        BMFname = "./Graphics/SRF1.jpg"
ErrorExit:
        Exit Sub
    End Sub
    Public Sub ClearScreen()
        Dim g As Graphics = EqTPicBx.CreateGraphics()
        g.Clear(Color.Empty)
        g.Dispose()
        EqTPicBx.Visible = False
        EqTPicBx.Enabled = False

        ClearTextBoxes()
        CleanOutOldFiles()
        EqTPicBx.Refresh()
        'cboDay.SelectedIndex = VB.Day(Today) - 1 '-1 because ListIndex starts with 0
        MonthList = "JanFebMarAprMayJunJulAugSepOctNovDec"
        ' only preset Sight DT to Now IF FormSRF is not yet loaded - on the initial form load. If it is loaded then leave this field as it is
        If FormSRFLoaded = False Then
            DTSight.Value = DateTime.Now
            cboPolaris.SelectedIndex = 0 '"Latitude by altitude of Polaris"
            cboSun.SelectedIndex = 0 '"NA val. of hourly GHA/d"
            cboStars.SelectedIndex = 0 '"NA val. of SHA and Dec"
            cboPlanets.SelectedIndex = 0 'NA val. of v/d
            cboWE.SelectedIndex = 0 '"fast"
            cboL.SelectedIndex = 0 '"N"
            cboLo.SelectedIndex = 0 '"W"
            cboIE.SelectedIndex = 0 '"on the arc"
            cboHE.SelectedIndex = 0 '"ft"
            cboDsUnit.SelectedIndex = 1 '"yards"
            cboTemperature.SelectedIndex = 0 '"F "
            cboPressure.SelectedIndex = 0 '"in Hg"
            cboBody.SelectedIndex = 0 '"Sun"
            cboSun.Visible = True
            cboSun.BringToFront()
            cboSun.SelectedIndex = 0
            optLower.Checked = True
            frmLimb.Visible = True
            frmLimb.Refresh()
        End If
        Me.Refresh()
        Exit Sub
    End Sub
    Public Sub ClearTextBoxes()
        TimeTxtBx.Clear()
        LHATxtBx.Clear()
        SightTxtBx.Clear()
        DecTxtBx.Clear()
        AltitudeTxtBx.Clear()
        IntAzTxtBx.Clear()

        DGTime.Visible = False
        DGLHA.Visible = False
        DGSight.Visible = False
        DGDec.Visible = False
        DGAlt.Visible = False

        Exit Sub
    End Sub

    Private Sub ClearAllBtn_Click(sender As Object, e As EventArgs) Handles ClearAllBtn.Click
        FormSRF_Load(sender, e)
        'ClearScreen()
    End Sub
    Private Sub EqTPicBx_Paint(sender As Object, e As PaintEventArgs) Handles EqTPicBx.Paint
        'If IssuingSendMsgBx = True Then
        '    IssuingSendMsgBx = False
        '    Exit Sub
        'End If
        'If My.Computer.FileSystem.FileExists(BMFname) Then
        '    EqTPicBx.Load(BMFname)
        'Else
        '    System.IO.File.Create(BMFname)
        '    'EqTPicBx.Load(BMFname)
        'End If
        'Exit Sub
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
    Private Sub btnCLSPlot_Click(sender As Object, e As EventArgs) Handles btnCLSPlot.Click
        PlotOut.PsnName = "SRF Sight"
        PlotOut.SquadronName = "SRF Sight Reduction"
        PlotOut.PlotType = "Sight"
        PlotOut.PlotNumber = txtSightNo.Text
        PlotOut.PlotDT = DTSight.Value
        PlotOut.PlotBody = cboBody.Items(cboBody.SelectedIndex).ToString
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
        PlotOut.PlotLLoBy = cboLLoBy.Text.ToString
        PlotOut.PlotExtendedLines = False
        ' the formatting of these next three fields is done in the routine that formats the intaztxtbx 
        'PlotOut.PlotAz = PlotAzimuth
        'PlotOut.PlotIntercept = PlotIntercept

        'PlotOut.PlotSLEP = txtSRFEP.Text.ToString

        CLSForm.AddPlotEntry(PlotOut)
        CLSForm.txtUserInfo.Text = Me.txtUserInfo.Text
        If CLSForm.PlotSight() = True Then
            CLSForm.Show()
            CLSForm.SetDesktopLocation(5,5) '
            CLSForm.BringToFront()
        Else
            'If CheckOpenWinForms("CLSForm") = True Then
            'CLSForm.ExitBtn.PerformClick()
            'End If
        End If

        Exit Sub
    End Sub
    Private Sub btnCustomPlot_Click(sender As Object, e As EventArgs) Handles btnCustomPlot.Click
        PlotOut.PsnName = "SRF Sight"
        PlotOut.SquadronName = "SRF Sight Reduction"
        PlotOut.PlotType = "Sight"
        PlotOut.PlotNumber = txtSightNo.Text
        PlotOut.PlotDT = DTSight.Value
        PlotOut.PlotBody = cboBody.Items(cboBody.SelectedIndex).ToString
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
        PlotOut.PlotLLoBy = cboLLoBy.Text.ToString
        PlotOut.PlotExtendedLines = False
        ' the formatting of these next three fields is done in the routine that formats the intaztxtbx 
        'PlotOut.PlotAz = PlotAzimuth
        'PlotOut.PlotIntercept = PlotIntercept

        'PlotOut.PlotSLEP = txtSRFEP.Text.ToString

        CustomPlot.AddPlotEntry(PlotOut)
        CustomPlot.txtUserInfo.Text = Me.txtUserInfo.Text
        If CustomPlot.PlotSight() = True Then
            CustomPlot.Show()
            CustomPlot.SetDesktopLocation(5,5) '
            CustomPlot.BringToFront()
        Else
            'If CheckOpenWinForms("CLSForm") = True Then
            'CLSForm.ExitBtn.PerformClick()
            'End If
        End If

        Exit Sub
    End Sub
    Public Function CheckOpenWinForms(ByVal FormNameIn As String) As Boolean
        For Each frm As Form In Application.OpenForms
            If frm.Name.Equals(FormNameIn, StringComparison.CurrentCultureIgnoreCase) Then
                Return True
                Exit Function
            End If
        Next
        Return False
        Exit Function
    End Function

    Private Sub DGTime_SelectionChanged(sender As Object, e As EventArgs) Handles DGTime.SelectionChanged
        Me.DGTime.ClearSelection()
        Exit Sub
    End Sub

    Private Sub DGLHA_SelectionChanged(sender As Object, e As EventArgs) Handles DGLHA.SelectionChanged
        Me.DGLHA.ClearSelection()
        Exit Sub
    End Sub

    Private Sub DGSight_SelectionChanged(sender As Object, e As EventArgs) Handles DGSight.SelectionChanged
        Me.DGSight.ClearSelection()
        Exit Sub
    End Sub

    Private Sub DGDec_SelectionChanged(sender As Object, e As EventArgs) Handles DGDec.SelectionChanged
        Me.DGDec.ClearSelection()
        Exit Sub
    End Sub

    Private Sub DGAlt_SelectionChanged(sender As Object, e As EventArgs) Handles DGAlt.SelectionChanged
        Me.DGAlt.ClearSelection()
        Exit Sub
    End Sub

End Class