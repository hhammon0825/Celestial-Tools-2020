Option Strict Off
Option Explicit On
Friend Class Form11
	Inherits System.Windows.Forms.Form
	Dim TimeOfFix, IL, i, FixIL As Short
	Dim Pi As Double
    Dim XZH(12) As Double
    Dim XZM(12) As Double
    Dim XZT(12) As Short
    Dim XZN(12) As Double
    Dim XMI(12) As Double
    Dim XL(12) As Double        'added in V5.6.1
    Dim XLo(12) As Double       'added in V5.6.1
    Dim BI, BF, LI, LF, BD, DF, BM As Double
	Dim EX, CX, AX, BX, DX, GX As Double
	'Dim XType(12) As Variant, XAPL(12) As Variant, XAPLo(12) As Variant
	Dim FD, CheckCount As Short
	Dim FM As Double
	Dim LH, BH As String
    Dim CourseAngleDeg, Lm, LatDiff, LongDiff, CourseAngle, Course As Double


    Dim XGHA(12) As Double          'added in V5.6.1
    Dim XDec(12) As Double          'added in V5.6.1
    Dim XHo(12) As Double        'added in V5.6.1
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

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
        Exit Sub
    End Sub
    Private Sub cmdFix_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFix.Click
        IL = 0
        If Check1.CheckState = 1 Then
            IL += 1
            XZH(IL) = Form8.FixData1.SFZH
            XZM(IL) = Form8.FixData1.SFZM
            XZT(IL) = Val(XZH(IL) + XZM(IL))
            XZN(IL) = Form8.FixData1.SFZN
            XMI(IL) = Form8.FixData1.SFMI
            XL(IL) = Form8.FixData1.SFL
            XLo(IL) = Form8.FixData1.SFLo ': XType(IL) = Form8.FixData1(10): XAPL(IL) = Form8.FixData1.SFZH: XAPLo(IL) = Form8.FixData1.SFGHA
            XGHA(IL) = Form8.FixData1.SFGHA   'added in V5.6.1
            XDec(IL) = Form8.FixData1.SFDec   'added in V5.6.1
            XHo(IL) = Form8.FixData1.SFHo 'added in V5.6.1
        End If

        If Check2.CheckState = 1 Then
            IL += 1
            XZH(IL) = Form8.FixData2.SFZH
            XZM(IL) = Form8.FixData2.SFZM
            XZT(IL) = Val(XZH(IL) + XZM(IL))
            XZN(IL) = Form8.FixData2.SFZN
            XMI(IL) = Form8.FixData2.SFMI
            XL(IL) = Form8.FixData2.SFL
            XLo(IL) = Form8.FixData2.SFLo ': XType(IL) = Form8.FixData2(10): XAPL(IL) = Form8.FixData2.SFZH: XAPLo(IL) = Form8.FixData2.SFGHA
            XGHA(IL) = Form8.FixData2.SFGHA   'added in V5.6.1
            XDec(IL) = Form8.FixData2.SFDec   'added in V5.6.1
            XHo(IL) = Form8.FixData2.SFHo 'added in V5.6.1
        End If

        If Check3.CheckState = 1 Then
            IL += 1
            XZH(IL) = Form8.FixData3.SFZH
            XZM(IL) = Form8.FixData3.SFZM
            XZT(IL) = Val(XZH(IL) + XZM(IL))
            XZN(IL) = Form8.FixData3.SFZN
            XMI(IL) = Form8.FixData3.SFMI
            XL(IL) = Form8.FixData3.SFL
            XLo(IL) = Form8.FixData3.SFLo
            XGHA(IL) = Form8.FixData3.SFGHA   'added in V5.6.1
            XDec(IL) = Form8.FixData3.SFDec   'added in V5.6.1
            XHo(IL) = Form8.FixData3.SFHo 'added in V5.6.1
        End If ': XType(IL) = Form8.FixData3(10): XAPL(IL) = Form8.FixData3.SFZH: XAPLo(IL) = Form8.FixData3.SFGHA

        If Check4.CheckState = 1 Then
            IL += 1
            XZH(IL) = Form8.FixData4.SFZH
            XZM(IL) = Form8.FixData4.SFZM
            XZT(IL) = Val(XZH(IL) + XZM(IL))
            XZN(IL) = Form8.FixData4.SFZN
            XMI(IL) = Form8.FixData4.SFMI
            XL(IL) = Form8.FixData4.SFL
            XLo(IL) = Form8.FixData4.SFLo
            XGHA(IL) = Form8.FixData4.SFGHA   'added in V5.6.1
            XDec(IL) = Form8.FixData4.SFDec   'added in V5.6.1
            XHo(IL) = Form8.FixData4.SFHo 'added in V5.6.1
        End If ': XType(IL) = Form8.FixData4(10): XAPL(IL) = Form8.FixData4.SFZH: XAPLo(IL) = Form8.FixData4.SFGHA

        If Check5.CheckState = 1 Then
            IL += 1
            XZH(IL) = Form8.FixData5.SFZH
            XZM(IL) = Form8.FixData5.SFZM
            XZT(IL) = Val(XZH(IL) + XZM(IL))
            XZN(IL) = Form8.FixData5.SFZN
            XMI(IL) = Form8.FixData5.SFMI
            XL(IL) = Form8.FixData5.SFL
            XLo(IL) = Form8.FixData5.SFLo
            XGHA(IL) = Form8.FixData5.SFGHA   'added in V5.6.1
            XDec(IL) = Form8.FixData5.SFDec   'added in V5.6.1
            XHo(IL) = Form8.FixData5.SFHo 'added in V5.6.1
        End If ': XType(IL) = Form8.FixData5(10): XAPL(IL) = Form8.FixData5.SFZH: XAPLo(IL) = Form8.FixData5.SFGHA

        If Check6.CheckState = 1 Then
            IL += 1
            XZH(IL) = Form8.FixData6.SFZH
            XZM(IL) = Form8.FixData6.SFZM
            XZT(IL) = Val(XZH(IL) + XZM(IL))
            XZN(IL) = Form8.FixData6.SFZN
            XMI(IL) = Form8.FixData6.SFMI
            XL(IL) = Form8.FixData6.SFL
            XLo(IL) = Form8.FixData6.SFLo
            XGHA(IL) = Form8.FixData6.SFGHA   'added in V5.6.1
            XDec(IL) = Form8.FixData6.SFDec   'added in V5.6.1
            XHo(IL) = Form8.FixData6.SFHo 'added in V5.6.1
        End If ': XType(IL) = Form8.FixData6(10): XAPL(IL) = Form8.FixData6.SFZH: XAPLo(IL) = Form8.FixData6.SFGHA

        If Check7.CheckState = 1 Then
            IL += 1
            XZH(IL) = Form8.FixData7.SFZH
            XZM(IL) = Form8.FixData7.SFZM
            XZT(IL) = Val(XZH(IL) + XZM(IL))
            XZN(IL) = Form8.FixData7.SFZN
            XMI(IL) = Form8.FixData7.SFMI
            XL(IL) = Form8.FixData7.SFL
            XLo(IL) = Form8.FixData7.SFLo
            XGHA(IL) = Form8.FixData7.SFGHA   'added in V5.6.1
            XDec(IL) = Form8.FixData7.SFDec   'added in V5.6.1
            XHo(IL) = Form8.FixData7.SFHo 'added in V5.6.1
        End If ': XType(IL) = Form8.FixData7(10): XAPL(IL) = Form8.FixData7.SFZH: XAPLo(IL) = Form8.FixData7.SFGHA

        If Check8.CheckState = 1 Then
            IL += 1
            XZH(IL) = Form8.FixData8.SFZH
            XZM(IL) = Form8.FixData8.SFZM
            XZT(IL) = Val(XZH(IL) + XZM(IL))
            XZN(IL) = Form8.FixData8.SFZN
            XMI(IL) = Form8.FixData8.SFMI
            XL(IL) = Form8.FixData8.SFL
            XLo(IL) = Form8.FixData8.SFLo
            XGHA(IL) = Form8.FixData8.SFGHA   'added in V5.6.1
            XDec(IL) = Form8.FixData8.SFDec   'added in V5.6.1
            XHo(IL) = Form8.FixData8.SFHo 'added in V5.6.1
        End If ': XType(IL) = Form8.FixData8(10): XAPL(IL) = Form8.FixData8.SFZH: XAPLo(IL) = Form8.FixData8.SFGHA

        If Check9.CheckState = 1 Then
            IL += 1
            XZH(IL) = Form8.FixData9.SFZH
            XZM(IL) = Form8.FixData9.SFZM
            XZT(IL) = Val(XZH(IL) + XZM(IL))
            XZN(IL) = Form8.FixData9.SFZN
            XMI(IL) = Form8.FixData9.SFMI
            XL(IL) = Form8.FixData9.SFL
            XLo(IL) = Form8.FixData9.SFLo
            XGHA(IL) = Form8.FixData9.SFGHA   'added in V5.6.1
            XDec(IL) = Form8.FixData9.SFDec   'added in V5.6.1
            XHo(IL) = Form8.FixData9.SFHo 'added in V5.6.1
        End If ': XType(IL) = Form8.FixData9(10): XAPL(IL) = Form8.FixData9.SFZH: XAPLo(IL) = Form8.FixData9.SFGHA

        If Check10.CheckState = 1 Then
            IL += 1
            XZH(IL) = Form8.FixData10.SFZH
            XZM(IL) = Form8.FixData10.SFZM
            XZT(IL) = Val(XZH(IL) + XZM(IL))
            XZN(IL) = Form8.FixData10.SFZN
            XMI(IL) = Form8.FixData10.SFMI
            XL(IL) = Form8.FixData10.SFL
            XLo(IL) = Form8.FixData10.SFLo
            XGHA(IL) = Form8.FixData10.SFGHA   'added in V5.6.1
            XDec(IL) = Form8.FixData10.SFDec   'added in V5.6.1
            XHo(IL) = Form8.FixData10.SFHo 'added in V5.6.1
        End If ': XType(IL) = Form8.FixData10(10): XAPL(IL) = Form8.FixData10.SFZH: XAPLo(IL) = Form8.FixData10.SFGHA

        If Check11.CheckState = 1 Then
            IL += 1
            XZH(IL) = Form8.FixData11.SFZH
            XZM(IL) = Form8.FixData11.SFZM
            XZT(IL) = Val(XZH(IL) + XZM(IL))
            XZN(IL) = Form8.FixData11.SFZN
            XMI(IL) = Form8.FixData11.SFMI
            XL(IL) = Form8.FixData11.SFL
            XLo(IL) = Form8.FixData11.SFLo
            XGHA(IL) = Form8.FixData11.SFGHA   'added in V5.6.1
            XDec(IL) = Form8.FixData11.SFDec   'added in V5.6.1
            XHo(IL) = Form8.FixData11.SFHo 'added in V5.6.1
        End If ': XType(IL) = Form8.FixData11(11): XAPL(IL) = Form8.FixData11.SFZH: XAPLo(IL) = Form8.FixData11.SFGHA

        If Check12.CheckState = 1 Then
            IL += 1
            XZH(IL) = Form8.FixData12.SFZH
            XZM(IL) = Form8.FixData12.SFZM
            XZT(IL) = Val(XZH(IL) + XZM(IL))
            XZN(IL) = Form8.FixData12.SFZN
            XMI(IL) = Form8.FixData12.SFMI
            XL(IL) = Form8.FixData12.SFL
            XLo(IL) = Form8.FixData12.SFLo
            XGHA(IL) = Form8.FixData12.SFGHA   'added in V5.6.1
            XDec(IL) = Form8.FixData12.SFDec   'added in V5.6.1
            XHo(IL) = Form8.FixData12.SFHo 'added in V5.6.1
        End If ': XType(IL) = Form8.FixData12(12): XAPL(IL) = Form8.FixData12.SFZH: XAPLo(IL) = Form8.FixData12.SFGHA

        Form8.WriteFixScreen()
        If IL < 2 Then
            ErrorMsgBox("You must select at least two sights.", "Error", MessageBoxButtons.OK)
            Exit Sub
        End If
        'Check if all sights have or do not have times
        '      CheckCount = 0
        'For i = 1 To IL
        '          If XZH(i) <> 0 Then CheckCount = CheckCount + 1
        '      Next i
        '      If CheckCount <> IL And CheckCount <> 0 Then
        '          ErrorMsgBox("Do not mix sights having times with sights not having times.", "Error", MessageBoxButtons.OK)
        '          Exit Sub
        '      End If

        'Time of fix is latest time of selected sights
        TimeOfFix = 0
        FixIL = 0
        For i = 1 To IL
            If XZT(i) > TimeOfFix Then
                TimeOfFix = XZT(i)
                FixIL = i
            End If
        Next i
        'L and Lo of latest of selected sights
        BF = XL(FixIL)
        LF = XLo(FixIL)

        'Rem  calculate fix
        Dim LoopCt As Integer = 0
Line1849:
        AX = 0
        BX = 0
        CX = 0
        DX = 0
        EX = 0
        GX = 0
        For i = 1 To IL
            AX = AX + (System.Math.Cos(XZN(i) * Pi / 180)) ^ 2
            BX = BX + System.Math.Cos(XZN(i) * Pi / 180) * System.Math.Sin(XZN(i) * Pi / 180)
            CX = CX + (System.Math.Sin(XZN(i) * Pi / 180)) ^ 2
            DX = DX + (XMI(i) / 60) * System.Math.Cos(XZN(i) * Pi / 180) 'XMI(I) was AF(I)
            EX = EX + (XMI(i) / 60) * System.Math.Sin(XZN(i) * Pi / 180) 'XMI(I) was AF(I)
        Next i
        GX = AX * CX - BX * BX
        If GX = 0 Then
            GoTo Line2200
        End If

        LoopCt += 1
        If LoopCt > 100 Then
            GoTo Line2200
        End If
        LI = LF + (AX * EX - BX * DX) / (GX * System.Math.Cos(BF * Pi / 180))
        BI = BF - (CX * DX - BX * EX) / GX 'Sign is correct for sign of XMI
        DF = 60 * System.Math.Sqrt((LI - LF) ^ 2 * (System.Math.Cos(BF * Pi / 180)) ^ 2 + (BI - BF) ^ 2)
        L = BI
        Lo = LI
        LF = LI
        BF = BI
        Call LoC()
        If DF > 0.01 Then
            GoTo Line1849
        End If
        'NA says D>20.  Changed in V5.6.1 to 0.01, equivalent of 0.01'.  Ron uses 0.001
        'DF = Int(DF * 10 + 0.5) / 10
        If System.Math.Abs(LI) > 180 Then
            LI = -System.Math.Sign(LI) * (360 - System.Math.Abs(LI)) 'In case fix is on other side of IDL
        End If
        BD = Int(System.Math.Abs(BI))
        BM = (System.Math.Abs(BI) - BD) * 60
        BM = Int(BM * 10 + 0.5) / 10
        If BM = 60 Then
            BM = 0
            BD = BD + 1
        End If
        BH = "N"
        If BI < 0 Then BH = "S"
        If BI = 0 Then BH = " "
        FD = Int(System.Math.Abs(LI))
        FM = (System.Math.Abs(LI) - FD) * 60
        FM = Int(FM * 10 + 0.5) / 10
        If FM = 60 Then
            FM = 0
            FD = FD + 1
        End If
        LH = "W"
        If LI < 0 Then LH = "E"
        If LI = 0 Then LH = " "
        LatDiff = BI - XL(FixIL) 'BF
        LongDiff = LI - XLo(FixIL) 'LF
        If System.Math.Abs(LongDiff) > 180 Then
            LongDiff = -System.Math.Sign(LongDiff) * (360 - System.Math.Abs(LongDiff))
        End If
        Lm = (System.Math.Round(BF, 2) + XL(FixIL)) / 2 'Mid-latitude       BF WAS BD BEFORE V4.2.0
        If LatDiff = 0 Then
            CourseAngle = Pi / 2
        Else
            CourseAngle = System.Math.Abs(System.Math.Atan((LongDiff * 60 * System.Math.Cos(Lm * Pi / 180)) / (LatDiff * 60)))
        End If
        CourseAngleDeg = CourseAngle * 180 / Pi
        'CourseAngleDeg = CourseAngle * 180 / Pi
        If LatDiff >= 0 And LongDiff < 0 Then Course = System.Math.Abs(CourseAngleDeg) 'Added Abs to CourseAngleDeg
        If LatDiff >= 0 And LongDiff >= 0 Then Course = 360 - System.Math.Abs(CourseAngleDeg) 'Added Abs to CourseAngleDeg
        If LatDiff < 0 And LongDiff < 0 Then Course = 180 - System.Math.Abs(CourseAngleDeg) 'Added Abs to CourseAngleDeg
        If LatDiff < 0 And LongDiff >= 0 Then Course = 180 + System.Math.Abs(CourseAngleDeg) 'Added Abs to CourseAngleDeg
        Course = Int(Course + 0.5)
        txtLoCFix.Clear()
        'DF = System.Math.Round(DF, 1, MidpointRounding.AwayFromZero)
        txtLoCFix.AppendText(("Fix at Time = " & Strings.Format(XZH(FixIL), "00") & Strings.Format(XZM(FixIL), "00")) & vbNewLine)
        txtLoCFix.AppendText(("Fix L  =  " & Strings.Format(BD, "#0") & Chr(176) & Strings.Format(BM, "00.0") & "'" & BH) & vbNewLine)
        txtLoCFix.AppendText(("Fix Lo = " & Strings.Format(FD, "##0") & Chr(176) & Strings.Format(FM, "00.0") & "'" & LH) & vbNewLine)
        txtLoCFix.AppendText(("Fix is " & Strings.Format(DF, "##0.0") & " nautical miles from DR"))
        txtLoCFix.AppendText((", at a bearing of " & Strings.Format(Course, "000") & Chr(176) & " True"))

        Exit Sub
        'If IH = 2 Then Print #2,: Print #2,: IH = 1: GoTo 1915
Line2200:
        txtLoCFix.Clear()
        txtLoCFix.AppendText(("Fix cannot be established.") & vbNewLine)
        txtLoCFix.AppendText(("Selected sights have unacceptable cuts or excessively large intercepts."))
        ErrorMsgBox("Selected sights have unacceptable cuts or excessively large intercepts.", "Fix cannot be established.", MessageBoxButtons.OK)
        Exit Sub
    End Sub

    Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
        PrintScreen(Me.Bounds)
    End Sub

    Private Sub Form_Initialize_Renamed()
        Pi = 4 * System.Math.Atan(1.0#)
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
    End Sub

    Private Sub Form11_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        ' nothing here so far
    End Sub

    Private Sub Form11_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'Cleanup()
    End Sub

    Private Sub ErrorMsgBox(ByVal ErrMsg As String, ByVal TitleStr As String, ByVal MsgBtn As MessageBoxButtons)
        System.Windows.Forms.MessageBox.Show(ErrMsg, TitleStr, MsgBtn,
                                                System.Windows.Forms.MessageBoxIcon.Error,
                                                System.Windows.Forms.MessageBoxDefaultButton.Button1,
                                                System.Windows.Forms.MessageBoxOptions.DefaultDesktopOnly)
        Exit Sub
    End Sub
    Private Sub LoC()
        Dim i As Integer = 0
        For i = 1 To IL
            GHA = XGHA(i)
            DE = XDec(i)
            Ho = XHo(i)
            LHA = GHA - Lo
            If LHA < 0 Then
                LHA = 360 - LHA
            End If
            L1 = System.Math.Cos(LHA * Pi / 180) * System.Math.Cos(L * Pi / 180) * System.Math.Cos(DE * Pi / 180)
            L2 = System.Math.Sin(L * Pi / 180) * System.Math.Sin(DE * Pi / 180)
            L3 = L1 + L2
            If System.Math.Abs(L3) >= 1 Then
                Hc = System.Math.Sign(L3) * Pi / 2
            Else
                Hc = System.Math.Atan(L3 / System.Math.Sqrt(-L3 * L3 + 1))
            End If
            Hc = Hc * 180 / Pi

            A = 60 * (Hc - Ho)      'Ho>Hc (T) is -
            L4 = System.Math.Sin(DE * Pi / 180)
            L5 = System.Math.Sin(L * Pi / 180) * System.Math.Sin(Hc * Pi / 180)
            L6 = L4 - L5
            L7 = System.Math.Cos(L * Pi / 180) * System.Math.Cos(Hc * Pi / 180)
            L8 = L6 / L7
            If System.Math.Abs(L8) >= 1 Then
                Z = Pi
            Else
                Z = System.Math.Atan(-L8 / System.Math.Sqrt(-L8 * L8 + 1)) + Pi / 2      'This is really Zc, not Z (always determined from north pole)
            End If
            Z = Z * 180 / Pi

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
    End Sub
End Class