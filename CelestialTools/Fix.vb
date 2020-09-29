Option Strict Off
Option Explicit On
Friend Class Form4
    Inherits System.Windows.Forms.Form
    Dim Pi As Double = System.Math.PI
    Dim DegtoRad As Double = System.Math.PI / 180.0
    Dim RadtoDeg As Double = 180.0 / System.Math.PI
    Dim i, IL, IV, FixIL As Short
    Dim TimeOfFix As Double ',IX As Integer,
    Dim XZH(12) As Double
    Dim XZM(12) As Double
    Dim XZS(12) As Double
    Dim XZT(12) As Double
    Dim XZN(12) As Double
    Dim XMI(12) As Double
    Dim DZT(12) As Double
    Dim DL(12) As Double
    Dim DLo(12) As Double
    Dim XLD(12) As Double
    Dim XLM(12) As Double
    Dim XMD(12) As Double
    Dim XMM(12) As Double
    Dim XL(12) As Double
    Dim XLo(12) As Double
    Dim XBF(12) As Double
    Dim XD(12) As Double
    Dim XLA(12) As Double
    Dim XM(12) As Double
    Dim XGHA(12) As Double          'added in V5.6.1
    Dim XDec(12) As Double          'added in V5.6.1
    Dim XHo(12) As Double        'added in V5.6.1
    Dim AF(12) As Double
    Dim EX, CX, AX, BX, DX, GX As Double
    Dim BI, BF, LI, LF, BD, DF, BM As Double
    Dim FD As Double
    Dim FM As Double
    Dim LH, BH As String
    Dim IA, II As Short
    Dim CourseAngleDeg, Lm, LatDiff, LongDiff, CourseAngle, Course As Double
    ' Following variables added for changes for 5.6.1 for LoC subroutine
    Dim L As Double
    Dim Lo As Double
    Dim GHA As Double
    Dim DE As Double
    Dim Ho As Double
    Dim LHA As Double
    Dim L1, L2, L3, L4, L5, L6, L7, L8 As Double
    Dim A, Z, ZN As Double
    Dim Hc As Double
    Public CalcFixError As Boolean = False

    Public FixDataArray(13) As SFixData

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
    End Structure

    Public IUPass As Integer

    Private Sub WriteFixScreen()
        'load up fix data from SRF1 form into Form4 / Fix form
        FixSelectTxtBx.Clear()

        IV = IUPass
        If IUPass > 1 Then Check1.Visible = True : Check2.Visible = True ': Check2.Enabled = True
        If IUPass > 2 Then Check3.Visible = True ': Check3.Enabled = True
        If IUPass > 3 Then Check4.Visible = True ': Check4.Enabled = True
        If IUPass > 4 Then Check5.Visible = True ': Check5.Enabled = True
        If IUPass > 5 Then Check6.Visible = True ': Check6.Enabled = True
        If IUPass > 6 Then Check7.Visible = True ': Check7.Enabled = True
        If IUPass > 7 Then Check8.Visible = True ': Check8.Enabled = True
        If IUPass > 8 Then Check9.Visible = True ': Check9.Enabled = True
        If IUPass > 9 Then Check10.Visible = True ': Check10.Enabled = True
        If IUPass > 10 Then Check11.Visible = True ': Check11.Enabled = True
        If IUPass > 11 Then Check12.Visible = True ': Check12.Enabled = True
        If IUPass > 12 Then i = IUPass + 12
        If IUPass > 12 Then
            IV = 12
        End If
        For IW = 1 To IV
            i = IW
            If IUPass > 12 Then
                i = IW + IUPass - Int((IUPass - 1) / 12) * 12
            End If

            FixSelectTxtBx.AppendText(FixDataArray(IW).SBF & vbTab & vbTab & Strings.Format(FixDataArray(IW).SFZH, "00") & "-" & Strings.Format(FixDataArray(IW).SFZM, "00") & "-" & Strings.Format(FixDataArray(IW).SFZS, "00") _
            & vbTab & vbTab & Strings.Format(System.Math.Abs(FixDataArray(IW).SFMI), "0.0") & " " & FixDataArray(IW).sFD _
            & vbTab & Strings.Format(FixDataArray(IW).SFZN, "000") & Chr(176) _
            & vbTab & Strings.Format(Val(FixDataArray(IW).SFLD), "00") & Chr(176) & Strings.Format(Val(FixDataArray(IW).SFLM), "00.0") & "'" & FixDataArray(IW).sFLA _
            & Space(4) & Strings.Format(Val(FixDataArray(IW).SFMD), "##0") & Chr(176) & Strings.Format(Val(FixDataArray(IW).SFMM), "00.0") & "'" & FixDataArray(IW).SFM & vbNewLine & vbNewLine)

        Next IW
        FixSelectTxtBx.Refresh()
        Me.Show()
        Exit Sub
    End Sub

    Private Sub cmdFix_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFix.Click
        txtFix.Clear()
        IL = 0
        If Check1.CheckState = 1 Then
            IL = IL + 1
            XZH(IL) = FixDataArray(IL).SFZH
            XZM(IL) = FixDataArray(IL).SFZM
            XZS(IL) = FixDataArray(IL).SFZS
            XZT(IL) = XZH(IL) + XZM(IL) / 60 + XZS(IL) / 3600
            XZN(IL) = FixDataArray(IL).SFZN
            XMI(IL) = FixDataArray(IL).SFMI
            XL(IL) = FixDataArray(IL).SFL
            XLo(IL) = FixDataArray(IL).SFLo
            XGHA(IL) = FixDataArray(IL).SFGHA   'added in V5.6.1
            XDec(IL) = FixDataArray(IL).SFDec   'added in V5.6.1
            XHo(IL) = FixDataArray(IL).SFHo 'added in V5.6.1
        End If
        If Check2.CheckState = 1 Then
            IL = IL + 1
            XZH(IL) = FixDataArray(IL).SFZH
            XZM(IL) = FixDataArray(IL).SFZM
            XZS(IL) = FixDataArray(IL).SFZS
            XZT(IL) = XZH(IL) + XZM(IL) / 60 + XZS(IL) / 3600
            XZN(IL) = FixDataArray(IL).SFZN
            XMI(IL) = FixDataArray(IL).SFMI
            XL(IL) = FixDataArray(IL).SFL
            XLo(IL) = FixDataArray(IL).SFLo
            XGHA(IL) = FixDataArray(IL).SFGHA   'added in V5.6.1
            XDec(IL) = FixDataArray(IL).SFDec   'added in V5.6.1
            XHo(IL) = FixDataArray(IL).SFHo 'added in V5.6.1
        End If
        If Check3.CheckState = 1 Then
            IL = IL + 1
            XZH(IL) = FixDataArray(IL).SFZH
            XZM(IL) = FixDataArray(IL).SFZM
            XZS(IL) = FixDataArray(IL).SFZS
            XZT(IL) = XZH(IL) + XZM(IL) / 60 + XZS(IL) / 3600
            XZN(IL) = FixDataArray(IL).SFZN
            XMI(IL) = FixDataArray(IL).SFMI
            XL(IL) = FixDataArray(IL).SFL
            XLo(IL) = FixDataArray(IL).SFLo
            XGHA(IL) = FixDataArray(IL).SFGHA   'added in V5.6.1
            XDec(IL) = FixDataArray(IL).SFDec   'added in V5.6.1
            XHo(IL) = FixDataArray(IL).SFHo 'added in V5.6.1
        End If
        If Check4.CheckState = 1 Then
            IL = IL + 1
            XZH(IL) = FixDataArray(IL).SFZH
            XZM(IL) = FixDataArray(IL).SFZM
            XZS(IL) = FixDataArray(IL).SFZS
            XZT(IL) = XZH(IL) + XZM(IL) / 60 + XZS(IL) / 3600
            XZN(IL) = FixDataArray(IL).SFZN
            XMI(IL) = FixDataArray(IL).SFMI
            XL(IL) = FixDataArray(IL).SFL
            XLo(IL) = FixDataArray(IL).SFLo
            XGHA(IL) = FixDataArray(IL).SFGHA   'added in V5.6.1
            XDec(IL) = FixDataArray(IL).SFDec   'added in V5.6.1
            XHo(IL) = FixDataArray(IL).SFHo 'added in V5.6.1
        End If
        If Check5.CheckState = 1 Then
            IL = IL + 1
            XZH(IL) = FixDataArray(IL).SFZH
            XZM(IL) = FixDataArray(IL).SFZM
            XZS(IL) = FixDataArray(IL).SFZS
            XZT(IL) = XZH(IL) + XZM(IL) / 60 + XZS(IL) / 3600
            XZN(IL) = FixDataArray(IL).SFZN
            XMI(IL) = FixDataArray(IL).SFMI
            XL(IL) = FixDataArray(IL).SFL
            XLo(IL) = FixDataArray(IL).SFLo
            XGHA(IL) = FixDataArray(IL).SFGHA   'added in V5.6.1
            XDec(IL) = FixDataArray(IL).SFDec   'added in V5.6.1
            XHo(IL) = FixDataArray(IL).SFHo 'added in V5.6.1
        End If
        If Check6.CheckState = 1 Then
            IL = IL + 1
            XZH(IL) = FixDataArray(IL).SFZH
            XZM(IL) = FixDataArray(IL).SFZM
            XZS(IL) = FixDataArray(IL).SFZS
            XZT(IL) = XZH(IL) + XZM(IL) / 60 + XZS(IL) / 3600
            XZN(IL) = FixDataArray(IL).SFZN
            XMI(IL) = FixDataArray(IL).SFMI
            XL(IL) = FixDataArray(IL).SFL
            XLo(IL) = FixDataArray(IL).SFLo
            XGHA(IL) = FixDataArray(IL).SFGHA   'added in V5.6.1
            XDec(IL) = FixDataArray(IL).SFDec   'added in V5.6.1
            XHo(IL) = FixDataArray(IL).SFHo 'added in V5.6.1
        End If
        If Check7.CheckState = 1 Then
            IL = IL + 1
            XZH(IL) = FixDataArray(IL).SFZH
            XZM(IL) = FixDataArray(IL).SFZM
            XZS(IL) = FixDataArray(IL).SFZS
            XZT(IL) = XZH(IL) + XZM(IL) / 60 + XZS(IL) / 3600
            XZN(IL) = FixDataArray(IL).SFZN
            XMI(IL) = FixDataArray(IL).SFMI
            XL(IL) = FixDataArray(IL).SFL
            XLo(IL) = FixDataArray(IL).SFLo
            XGHA(IL) = FixDataArray(IL).SFGHA   'added in V5.6.1
            XDec(IL) = FixDataArray(IL).SFDec   'added in V5.6.1
            XHo(IL) = FixDataArray(IL).SFHo 'added in V5.6.1
        End If
        If Check8.CheckState = 1 Then
            IL = IL + 1
            XZH(IL) = FixDataArray(IL).SFZH
            XZM(IL) = FixDataArray(IL).SFZM
            XZS(IL) = FixDataArray(IL).SFZS
            XZT(IL) = XZH(IL) + XZM(IL) / 60 + XZS(IL) / 3600
            XZN(IL) = FixDataArray(IL).SFZN
            XMI(IL) = FixDataArray(IL).SFMI
            XL(IL) = FixDataArray(IL).SFL
            XLo(IL) = FixDataArray(IL).SFLo
            XGHA(IL) = FixDataArray(IL).SFGHA   'added in V5.6.1
            XDec(IL) = FixDataArray(IL).SFDec   'added in V5.6.1
            XHo(IL) = FixDataArray(IL).SFHo 'added in V5.6.1
        End If
        If Check9.CheckState = 1 Then
            IL = IL + 1
            XZH(IL) = FixDataArray(IL).SFZH
            XZM(IL) = FixDataArray(IL).SFZM
            XZS(IL) = FixDataArray(IL).SFZS
            XZT(IL) = XZH(IL) + XZM(IL) / 60 + XZS(IL) / 3600
            XZN(IL) = FixDataArray(IL).SFZN
            XMI(IL) = FixDataArray(IL).SFMI
            XL(IL) = FixDataArray(IL).SFL
            XLo(IL) = FixDataArray(IL).SFLo
            XGHA(IL) = FixDataArray(IL).SFGHA   'added in V5.6.1
            XDec(IL) = FixDataArray(IL).SFDec   'added in V5.6.1
            XHo(IL) = FixDataArray(IL).SFHo 'added in V5.6.1
        End If
        If Check10.CheckState = 1 Then
            IL = IL + 1
            XZH(IL) = FixDataArray(IL).SFZH
            XZM(IL) = FixDataArray(IL).SFZM
            XZS(IL) = FixDataArray(IL).SFZS
            XZT(IL) = XZH(IL) + XZM(IL) / 60 + XZS(IL) / 3600
            XZN(IL) = FixDataArray(IL).SFZN
            XMI(IL) = FixDataArray(IL).SFMI
            XL(IL) = FixDataArray(IL).SFL
            XLo(IL) = FixDataArray(IL).SFLo
            XGHA(IL) = FixDataArray(IL).SFGHA   'added in V5.6.1
            XDec(IL) = FixDataArray(IL).SFDec   'added in V5.6.1
            XHo(IL) = FixDataArray(IL).SFHo 'added in V5.6.1
        End If
        If Check11.CheckState = 1 Then
            IL = IL + 1
            XZH(IL) = FixDataArray(IL).SFZH
            XZM(IL) = FixDataArray(IL).SFZM
            XZS(IL) = FixDataArray(IL).SFZS
            XZT(IL) = XZH(IL) + XZM(IL) / 60 + XZS(IL) / 3600
            XZN(IL) = FixDataArray(IL).SFZN
            XMI(IL) = FixDataArray(IL).SFMI
            XL(IL) = FixDataArray(IL).SFL
            XLo(IL) = FixDataArray(IL).SFLo
            XGHA(IL) = FixDataArray(IL).SFGHA   'added in V5.6.1
            XDec(IL) = FixDataArray(IL).SFDec   'added in V5.6.1
            XHo(IL) = FixDataArray(IL).SFHo 'added in V5.6.1
        End If
        If Check12.CheckState = 1 Then
            IL = IL + 1
            XZH(IL) = FixDataArray(IL).SFZH
            XZM(IL) = FixDataArray(IL).SFZM
            XZS(IL) = FixDataArray(IL).SFZS
            XZT(IL) = XZH(IL) + XZM(IL) / 60 + XZS(IL) / 3600
            XZN(IL) = FixDataArray(IL).SFZN
            XMI(IL) = FixDataArray(IL).SFMI
            XL(IL) = FixDataArray(IL).SFL
            XLo(IL) = FixDataArray(IL).SFLo
            XGHA(IL) = FixDataArray(IL).SFGHA   'added in V5.6.1
            XDec(IL) = FixDataArray(IL).SFDec   'added in V5.6.1
            XHo(IL) = FixDataArray(IL).SFHo 'added in V5.6.1
        End If

        WriteFixScreen()

        If IL < 2 Then
            ErrorMsgBox("You must select at least two sights.", "Error", MessageBoxButtons.OK)
            Exit Sub
        End If
        TimeOfFix = 0
        FixIL = 0
        For i = 1 To IL
            If XZT(i) > TimeOfFix Then
                TimeOfFix = XZT(i)
                FixIL = i
            End If
        Next i
        'L and Lo of the sight with the most recent (largest) time and will be the basis of the fix calculation
        BF = XL(FixIL)
        LF = XLo(FixIL)
        Dim BFinRads As Double = 0.0 'BF * DegtoRad

        Dim LoopCt As Integer = 0
        Dim ZNinRads As Double = 0.0
Line1849:
        AX = 0.0
        BX = 0.0
        CX = 0.0
        DX = 0.0
        EX = 0.0
        GX = 0.0
        For i = 1 To IL
            ZNinRads = XZN(i) * DegtoRad
            AX += (System.Math.Cos(ZNinRads)) ^ 2
            BX += System.Math.Cos(ZNinRads) * System.Math.Sin(ZNinRads)
            CX += (System.Math.Sin(ZNinRads)) ^ 2
            DX += (XMI(i) / 60) * System.Math.Cos(ZNinRads)
            EX += (XMI(i) / 60) * System.Math.Sin(ZNinRads)
        Next i
        GX = AX * CX - BX * BX
        If GX = 0 Then
            GoTo Line2200
        End If
        BFinRads = BF * DegtoRad
        LI = LF + (AX * EX - BX * DX) / (GX * System.Math.Cos(BFinRads))
        BI = BF - (CX * DX - BX * EX) / GX 'Sign is correct for sign of XMI
        DF = 60 * System.Math.Sqrt(((LI - LF) ^ 2) * ((System.Math.Cos(BFinRads)) ^ 2) + (BI - BF) ^ 2)
        LoopCt += 1
        If LoopCt > 1000 Then ' if DF value can not be resolved into 1000 iterations then this fix is a bust
            GoTo Line2200
        End If
        L = BI
        BF = BI
        Lo = LI
        LF = LI
        LoC()
        If DF > 0.01 Then
            GoTo Line1849      'NA says D>20.  Changed in V5.6.1 to 0.01, equivalent of 0.01'.  Ron uses 0.001
        End If
        If System.Math.Abs(LI) > 180 Then
            LI = -System.Math.Sign(LI) * (360 - System.Math.Abs(LI)) 'In case fix is on other side of IDL
        End If
        'What if fix is on other side of equator?
        ' extract latitude minutes from calculated fix latitude BF
        BD = Int(System.Math.Abs(BI))
        BM = (System.Math.Abs(BI) - BD) * 60.0
        If BM >= 60 Then
            BM = BM - 60
            BD += 1
        End If
        BM = System.Math.Round(BM, 1, MidpointRounding.AwayFromZero)
        BH = "N"
        If BI < 0 Then
            BH = "S"
        End If
        If BI = 0 Then
            BH = " "
        End If
        ' extract longitude minutes from calculated fix longitude LI
        FD = Int(System.Math.Abs(LI))
        FM = (System.Math.Abs(LI) - FD) * 60.0
        If FM >= 60 Then
            FM = FM - 60
            FD = FD + 1
        End If
        FM = System.Math.Round(FM, 1, MidpointRounding.AwayFromZero)
        LH = "W"
        If LI < 0 Then
            LH = "E"
        End If
        If LI = 0 Then
            LH = " "
        End If
        'Calculate bearing using mid-latitude sailing
        LatDiff = BI - XL(FixIL)   'BF
        LongDiff = LI - XLo(FixIL) 'LF
        'Crossing IDL
        If System.Math.Abs(LongDiff) > 180 Then
            LongDiff = -System.Math.Sign(LongDiff) * (360 - System.Math.Abs(LongDiff))
        End If
        Lm = (System.Math.Round(BF, 2) + XL(FixIL)) / 2 'Mid-latitude   'XL(FixIL)
        If LatDiff = 0 Then
            CourseAngle = Pi / 2
        Else
            CourseAngle = System.Math.Atan(((LongDiff * 60) * (System.Math.Cos(Lm * DegtoRad))) / (LatDiff * 60))
        End If
        CourseAngleDeg = CourseAngle * RadtoDeg
        'CourseAngleDeg = CourseAngle * 180 / Pi
        If LatDiff >= 0 And LongDiff < 0 Then
            Course = CourseAngleDeg 'Added Abs to CourseAngleDeg
        End If
        If LatDiff >= 0 And LongDiff >= 0 Then
            Course = 360 - CourseAngleDeg 'Added Abs to CourseAngleDeg
        End If
        If LatDiff < 0 And LongDiff < 0 Then
            Course = 180 - CourseAngleDeg 'Added Abs to CourseAngleDeg
        End If
        If LatDiff < 0 And LongDiff >= 0 Then
            Course = 180 + CourseAngleDeg 'Added Abs to CourseAngleDeg
        End If
        ' DF is distance from DR to Fix 
        DF = 60 * LatDiff / System.Math.Cos(CourseAngle)
        'DF = Int(System.Math.Abs(DF) * 10 + 0.5) / 10
        DF = System.Math.Round(System.Math.Abs(DF), 1, MidpointRounding.AwayFromZero)
        ' Course is the True Bearing frm DR to Fix
        'Course = Int(System.Math.Abs(Course) + 0.5)
        Course = System.Math.Round(System.Math.Abs(Course), 0, MidpointRounding.AwayFromZero)
        If FixIL = 0 Then
            XZH(FixIL) = 0
            XZM(FixIL) = 0
            XZS(FixIL) = 0
        End If

        txtFix.AppendText("Fix at ZT = " & Strings.Format(XZH(FixIL), "00") & "-" & Strings.Format(XZM(FixIL), "00") & "-" & Strings.Format(XZS(FixIL), "00") & vbNewLine)
        txtFix.AppendText("Fix L  =  " & Strings.Format(BD, "#0") & Chr(176) & Strings.Format(BM, "00.0") & "'" & BH & vbNewLine)
        txtFix.AppendText("Fix Lo = " & Strings.Format(FD, "##0") & Chr(176) & Strings.Format(FM, "00.0") & "'" & LH & vbNewLine)
        txtFix.AppendText("Fix is " & Strings.Format(DF, "##0.0") & " nautical miles from " & Strings.Format(XZH(FixIL), "00") & "-" & Strings.Format(XZM(FixIL), "00") & "-" & Strings.Format(XZS(FixIL), "00") & " DR")
        If DF <> 0 Then txtFix.AppendText(", at a bearing of " & Strings.Format(Course, "000") & Chr(176) & " True")
        Exit Sub
        ' Line2200 is error exit from Fix routine - error message says it all
Line2200:
        txtFix.AppendText("Fix cannot be established.")
        txtFix.AppendText("Selected sights have unacceptable cuts or excessively large intercepts.")
        ErrorMsgBox("Selected sights have unacceptable cuts or excessively large intercepts.", "Fix cannot be established.", MessageBoxButtons.OK)
        Exit Sub
    End Sub
    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
        PrintScreen(Me.Bounds)
    End Sub
    Private Sub Form_Initialize_Renamed()
        'Pi = 4 * System.Math.Atan(1.0#)
        Pi = System.Math.PI
        DegtoRad = System.Math.PI / 180.0
        RadtoDeg = 180.0 / System.Math.PI

        Check1.Visible = False ': Check1.Enabled = False
        Check2.Visible = False ': Check2.Enabled = False
        Check3.Visible = False ': Check3.Enabled = False
        Check4.Visible = False ': Check4.Enabled = False
        Check5.Visible = False ': Check5.Enabled = False
        Check6.Visible = False ': Check6.Enabled = False
        Check7.Visible = False ': Check7.Enabled = False
        Check8.Visible = False ': Check8.Enabled = False
        Check9.Visible = False ': Check9.Enabled = False
        Check10.Visible = False ': Check10.Enabled = False
        Check11.Visible = False ': Check11.Enabled = False
        Check12.Visible = False ': Check12.Enabled = False
        'WriteFixScreen()
        Exit Sub
    End Sub

    Private Sub Form4_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Form_Initialize_Renamed()
        txtFix.Clear()
        Pi = System.Math.PI
        WriteFixScreen()
        Me.Refresh()
    End Sub

    Private Sub Form4_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'Cleanup()
    End Sub
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

    Private Sub ErrorMsgBox(ByVal ErrMsg As String, ByVal TitleStr As String, ByVal MsgBtn As MessageBoxButtons)
        System.Windows.Forms.MessageBox.Show(ErrMsg, TitleStr, MsgBtn,
                                                System.Windows.Forms.MessageBoxIcon.Error,
                                                System.Windows.Forms.MessageBoxDefaultButton.Button1,
                                                System.Windows.Forms.MessageBoxOptions.DefaultDesktopOnly)
        Exit Sub
    End Sub
    Private Sub LoC()

        For i = 1 To IL
            GHA = XGHA(i)
            DE = XDec(i)
            Ho = XHo(i)
            LHA = GHA - Lo
            If LHA < 0 Then
                LHA = 360 - LHA
            End If

            L1 = System.Math.Cos(LHA * DegtoRad) * System.Math.Cos(L * DegtoRad) * System.Math.Cos(DE * DegtoRad)
            L2 = System.Math.Sin(L * DegtoRad) * System.Math.Sin(DE * DegtoRad)
            L3 = L1 + L2
            If System.Math.Abs(L3) >= 1 Then
                Hc = System.Math.Sign(L3) * Pi / 2
            Else
                Hc = System.Math.Atan(L3 / System.Math.Sqrt(-L3 * L3 + 1))
            End If
            If Hc < 0 Then
                Hc = -1 * Hc
            End If
            Hc *= RadtoDeg

            A = 60.0 * (Hc - Ho)

            L4 = System.Math.Sin(DE * DegtoRad)
            L5 = System.Math.Sin(L * DegtoRad) * System.Math.Sin(Hc * DegtoRad)
            L6 = L4 - L5
            L7 = System.Math.Cos(L * DegtoRad) * System.Math.Cos(Hc * DegtoRad)
            L8 = L6 / L7
            If System.Math.Abs(L8) >= 1 Then
                Z = Pi
            Else
                Z = System.Math.Atan(-L8 / System.Math.Sqrt(-L8 * L8 + 1)) + Pi / 2      'This is really Zc, not Z (always determined from north pole)
            End If
            Z *= RadtoDeg

            If LHA > 180 Then
                ZN = Z
            End If
            If LHA <= 180 Then
                ZN = 360 - Z
            End If
            If ZN = 360 Then
                ZN = 0
            End If

            XZN(i) = ZN
            XMI(i) = A
        Next i
        Exit Sub
    End Sub

End Class

