Public Class FixDG

    Dim Pi As Double = System.Math.PI
    Dim DegtoRad As Double = System.Math.PI / 180
    Dim RadtoDeg As Double = 180 / System.Math.PI
    Dim i, IL, IV, FixIL As Short
    Dim TimeOfFix As Double

    Dim XSelected(13) As Boolean
    Dim XZH(13) As Double
    Dim XZM(13) As Double
    Dim XZS(13) As Double
    Dim XZT(13) As Double
    Dim XZN(13) As Double
    Dim XMI(13) As Double
    Dim DZT(13) As Double
    Dim DL(13) As Double
    Dim DLo(13) As Double
    Dim XLD(13) As Double
    Dim XLM(13) As Double
    Dim XMD(13) As Double
    Dim XMM(13) As Double
    Dim XL(13) As Double
    Dim XLo(13) As Double
    Dim XBF(13) As Double
    Dim XD(13) As Double
    Dim XLA(13) As Double
    Dim XM(13) As Double
    Dim XGHA(13) As Double          'added in V5.6.1
    Dim XDec(13) As Double          'added in V5.6.1
    Dim XHo(13) As Double        'added in V5.6.1
    Dim AF(13) As Double
    Dim EP(13) As String
    Dim XDTSight(13) As Date
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

    Public Structure SFixData
        Public SightSelect As Boolean
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
        Public SDTSight As Date
        Public SEP As String
    End Structure
    Public IUPass As Integer
    Public SelectedFix As Integer = 0
    Private FormLoaded As Boolean = False
    Public FixDataArray(13) As SFixData
    Public PlotOut As CLSForm.PlotEntry


    Private Sub FixDG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitLocalFixArray()
        'txtFixCalc.Clear()
        DGFix.Rows.Clear()
        IV = IUPass
        btnUseCLS.Visible = True
        btnCustomPlot.Visible = True
        WriteFixScreen()
        FormLoaded = True
        Exit Sub
    End Sub
    Private Sub InitLocalFixArray()
        For i = 0 To 12
            XSelected(i) = False
            XZH(i) = 0
            XZM(i) = 0
            XZS(i) = 0
            XZT(i) = 0
            XZN(i) = 0
            XMI(i) = 0
            DZT(i) = 0
            DL(i) = 0
            DLo(i) = 0
            XLD(i) = 0
            XLM(i) = 0
            XMD(i) = 0
            XMM(i) = 0
            XL(i) = 0
            XLo(i) = 0
            XBF(i) = 0
            XD(i) = 0
            XLA(i) = 0
            XM(i) = 0
            XGHA(i) = 0
            XDec(i) = 0
            XHo(i) = 0
            AF(i) = 0
            EP(i) = ""
        Next
        Exit Sub
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        If CheckOpenWinForms("CLSForm") = True Then
            CLSForm.ExitBtn.PerformClick()
        End If
        Me.Close()
        Exit Sub
    End Sub
    Public Function CheckOpenWinForms(ByVal FormNameIn As String) As Boolean
        For Each frm As Form In Application.OpenForms
            If frm.Name.Equals(FormNameIn) Then
                Return True
                Exit Function
            End If
        Next
        Return False
        Exit Function
    End Function
    Private Sub btnUseCLS_Click(sender As Object, e As EventArgs) Handles btnUseCLS.Click
        If CheckOpenWinForms("CLSForm") = True Then
            CLSForm.ExitBtn.PerformClick()
        End If
        Dim TempTA As String = "T"
        Dim SaveI As Integer = 0
        For i = 1 To IL
            If XSelected(i) = True Then
                PlotOut.PsnName = "CLS Plot Fix"
                PlotOut.SquadronName = "CLS Plot Fix"
                PlotOut.PlotType = "FixSight"
                PlotOut.PlotNumber = i.ToString("##0")
                PlotOut.PlotDT = FixDataArray(i).SDTSight
                PlotOut.PlotBody = FixDataArray(i).SBF
                PlotOut.PlotLat = FixDataArray(i).SFL
                PlotOut.PlotLatDeg = FixDataArray(i).SFLD
                PlotOut.PlotLatMin = FixDataArray(i).SFLM
                PlotOut.PlotLatSec = "0"
                PlotOut.PlotLatNS = FixDataArray(i).sFLA.Trim

                PlotOut.PlotLong = FixDataArray(i).SFLo
                PlotOut.PlotLongDeg = FixDataArray(i).SFMD.ToString("##0")
                PlotOut.PlotLongMin = FixDataArray(i).SFMM.ToString("00.0")
                PlotOut.PlotLongSec = "0"
                If FixDataArray(i).SFM = Nothing Then
                    PlotOut.PlotLongEW = vbNullString
                Else
                    PlotOut.PlotLongEW = FixDataArray(i).SFM.Trim
                End If
                'PlotOut.PlotLongEW = FixDataArray(i).SFM.Trim

                PlotOut.PlotAz = FixDataArray(i).SFZN.ToString("000") & Chr(176)
                TempTA = " Towards"
                If FixDataArray(i).SFMI > 0 Then
                    TempTA = "Away"
                End If
                PlotOut.PlotIntercept = System.Math.Abs(FixDataArray(i).SFMI).ToString("##0.0") & " nm " & TempTA

                PlotOut.PlotSLEP = FixDataArray(i).SEP ' "Fix Sight" & PlotOut.PlotNumber & " on " & FixDataArray(i).SDTSight.ToString("MM/dd/yyy HH:mm:ss")
                PlotOut.PlotExtendedLines = True
                CLSForm.AddPlotEntry(PlotOut)
                SaveI = i
            End If
        Next i

        PlotOut.PsnName = "CLS Plot Fix"
        PlotOut.SquadronName = "CLS Plot Fix"
        PlotOut.PlotType = "Fix"
        PlotOut.PlotNumber = (SaveI + 1).ToString("##0")

        PlotOut.PlotDT = FixDataArray(FixIL).SDTSight
        PlotOut.PlotBody = "Fix"
        PlotOut.PlotLat = BD + BM / 60
        PlotOut.PlotLatDeg = BD.ToString("#0")
        PlotOut.PlotLatMin = BM.ToString("00.0")
        PlotOut.PlotLatSec = "0"
        PlotOut.PlotLatNS = BH

        PlotOut.PlotLong = FD + FM / 60
        PlotOut.PlotLongDeg = FD.ToString("##0")
        PlotOut.PlotLongMin = FM.ToString("00.0")
        PlotOut.PlotLongSec = "0"
        PlotOut.PlotLongEW = LH
        TempTA = " Towards"
        If DF > 0 Then
            TempTA = " Away"
        End If
        PlotOut.PlotAz = Course.ToString("000") & Chr(176)
        PlotOut.PlotIntercept = System.Math.Abs(DF).ToString("##0.0") & " nm " & TempTA

        PlotOut.PlotSLEP = "Fix at ZT " & Strings.Format(XZH(FixIL), "00") & "-" & Strings.Format(XZM(FixIL), "00") & "-" & Strings.Format(XZS(FixIL), "00") &
            " Loc = " & Strings.Format(BD, "#0") & Chr(176) & Strings.Format(BM, "00.0") & "'" & BH & " " &
            Strings.Format(FD, "##0") & Chr(176) & Strings.Format(FM, "00.0") & "'" & LH & " " &
            "a= " & Strings.Format(DF, "##0.0") & TempTA & " Zn= " & Strings.Format(Course, "000") & Chr(176)

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
        If CheckOpenWinForms("CustomPlot") = True Then
            CustomPlot.ExitBtn.PerformClick()
        End If
        Dim TempTA As String = "T"
        Dim SaveI As Integer = 0
        For i = 1 To IL
            If XSelected(i) = True Then
                PlotOut.PsnName = "Custom Plot Fix"
                PlotOut.SquadronName = "Custom Plot Fix"
                PlotOut.PlotType = "FixSight"
                PlotOut.PlotNumber = i.ToString("##0")
                PlotOut.PlotDT = FixDataArray(i).SDTSight
                PlotOut.PlotBody = FixDataArray(i).SBF
                PlotOut.PlotLat = FixDataArray(i).SFL
                PlotOut.PlotLatDeg = FixDataArray(i).SFLD
                PlotOut.PlotLatMin = FixDataArray(i).SFLM
                PlotOut.PlotLatSec = "0"

                PlotOut.PlotLatNS = FixDataArray(i).sFLA.Trim

                PlotOut.PlotLong = FixDataArray(i).SFLo
                PlotOut.PlotLongDeg = FixDataArray(i).SFMD.ToString("##0")
                PlotOut.PlotLongMin = FixDataArray(i).SFMM.ToString("00.0")
                PlotOut.PlotLongSec = "0"
                If FixDataArray(i).SFM = Nothing Then
                    PlotOut.PlotLongEW = vbNullString
                Else
                    PlotOut.PlotLongEW = FixDataArray(i).SFM.Trim
                End If
                'PlotOut.PlotLongEW = FixDataArray(i).SFM.Trim

                PlotOut.PlotAz = FixDataArray(i).SFZN.ToString("000") & Chr(176)
                TempTA = " Towards"
                If FixDataArray(i).SFMI > 0 Then
                    TempTA = "Away"
                End If
                PlotOut.PlotIntercept = System.Math.Abs(FixDataArray(i).SFMI).ToString("##0.0") & " nm " & TempTA
                PlotOut.PlotExtendedLines = True
                PlotOut.PlotSLEP = FixDataArray(i).SEP '"Fix Sight" & PlotOut.PlotNumber & " on " & FixDataArray(i).SDTSight.ToString("MM/dd/yyy HH:mm:ss")
                CustomPlot.AddPlotEntry(PlotOut)
                SaveI = i
            End If
        Next i

        PlotOut.PsnName = "Custom Plot Fix"
        PlotOut.SquadronName = "Custom Plot Fix"
        PlotOut.PlotType = "Fix"
        PlotOut.PlotNumber = (SaveI + 1).ToString("##0")

        PlotOut.PlotDT = FixDataArray(FixIL).SDTSight
        PlotOut.PlotBody = "Fix"
        PlotOut.PlotLat = BD + BM / 60
        PlotOut.PlotLatDeg = BD.ToString("#0")
        PlotOut.PlotLatMin = BM.ToString("00.0")
        PlotOut.PlotLatSec = "0"
        PlotOut.PlotLatNS = BH

        PlotOut.PlotLong = FD + FM / 60
        PlotOut.PlotLongDeg = FD.ToString("##0")
        PlotOut.PlotLongMin = FM.ToString("00.0")
        PlotOut.PlotLongSec = "0"
        PlotOut.PlotLongEW = LH
        TempTA = " Towards"
        If DF > 0 Then
            TempTA = " Away"
        End If
        PlotOut.PlotAz = Course.ToString("000") & Chr(176)
        PlotOut.PlotIntercept = System.Math.Abs(DF).ToString("##0.0") & " nm " & TempTA

        PlotOut.PlotSLEP = "Fix at ZT " & Strings.Format(XZH(FixIL), "00") & "-" & Strings.Format(XZM(FixIL), "00") & "-" & Strings.Format(XZS(FixIL), "00") &
            " Loc = " & Strings.Format(BD, "#0") & Chr(176) & Strings.Format(BM, "00.0") & "'" & BH & " " &
            Strings.Format(FD, "##0") & Chr(176) & Strings.Format(FM, "00.0") & "'" & LH & " " &
            "a= " & Strings.Format(DF, "##0.0") & TempTA & " Zn= " & Strings.Format(Course, "000") & Chr(176)

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


    Private Sub DGFix_SelectionChanged(sender As Object, e As EventArgs) Handles DGFix.SelectionChanged
        If FormLoaded = False Then Exit Sub
        Dim n As Integer = DGFix.CurrentRow.Index
        ' The order of these variable and the integer indexs contained in each MUST match the order of the fields in the data grid
        Dim SelIndex As Integer = Convert.ToInt32(DGFix.Rows(n).Cells(1).Value)

        If DGFix.CurrentRow.Cells(0).Value = True Then
            FixDataArray(SelIndex).SightSelect = False

            XSelected(SelIndex) = False
            DGFix.CurrentRow.Cells(0).Value = False
        Else
            FixDataArray(SelIndex).SightSelect = True
            XSelected(SelIndex) = True
            DGFix.CurrentRow.Cells(0).Value = True
        End If
        Dim temp As Integer = 0
        For i = 1 To IUPass
            If XSelected(i) = True Then
                temp += 1
                ' restore the original ZN and Intercept in the event an item has been deselected and a prior 3 body sight was done
                XZH(i) = FixDataArray(i).SFZH
                XZM(i) = FixDataArray(i).SFZM
                XZS(i) = FixDataArray(i).SFZS
                XZT(i) = XZH(i) + XZM(i) / 60 + XZS(i) / 3600
                XZN(i) = FixDataArray(i).SFZN
                XMI(i) = FixDataArray(i).SFMI
                XL(i) = FixDataArray(i).SFL
                XLo(i) = FixDataArray(i).SFLo
                XGHA(i) = FixDataArray(i).SFGHA
                XDec(i) = FixDataArray(i).SFDec
                XHo(i) = FixDataArray(i).SFHo
                XDTSight(i) = FixDataArray(i).SDTSight
                EP(i) = FixDataArray(i).SEP

            End If
        Next i
        If temp < 2 Then
            ErrorMsgBox("Selection Rejected - At least two sights must be selected", "Selection Rejected - Too Few Sights Selected", MessageBoxButtons.OK)
            FixDataArray(SelIndex).SightSelect = True
            XSelected(SelIndex) = True
            DGFix.CurrentRow.Cells(0).Value = True
            DGFix.Refresh()
            Me.Refresh()
            Exit Sub
        End If

        CalculateFix()
        DGFix.Refresh()
        Me.Refresh()

        Exit Sub
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintScreen(Me.Bounds)
    End Sub

    Private Sub WriteFixScreen()
        'load up fix data from SRF1 form into Form4 / Fix form
        IV = IUPass
        For IW = 1 To IV
            i = IW
            DGFix.Rows.Add(True, IW.ToString, FixDataArray(IW).SBF, Strings.Format(FixDataArray(IW).SFZH, "00") & "-" & Strings.Format(FixDataArray(IW).SFZM, "00") & "-" & Strings.Format(FixDataArray(IW).SFZS, "00"),
                Strings.Format(System.Math.Abs(FixDataArray(IW).SFMI), "0.0") & " " & FixDataArray(IW).sFD,
                Strings.Format(FixDataArray(IW).SFZN, "000") & Chr(176),
                Strings.Format(Val(FixDataArray(IW).SFLD), "00") & Chr(176) & Strings.Format(Val(FixDataArray(IW).SFLM), "00.0") & "'" & FixDataArray(IW).sFLA,
                Strings.Format(Val(FixDataArray(IW).SFMD), "##0") & Chr(176) & Strings.Format(Val(FixDataArray(IW).SFMM), "00.0") & "'" & FixDataArray(IW).SFM)

            FixDataArray(IW).SightSelect = True
            XSelected(IW) = True
            XZH(IW) = FixDataArray(IW).SFZH
            XZM(IW) = FixDataArray(IW).SFZM
            XZS(IW) = FixDataArray(IW).SFZS
            XZT(IW) = XZH(IW) + XZM(IW) / 60 + XZS(IW) / 3600
            XZN(IW) = FixDataArray(IW).SFZN
            XMI(IW) = FixDataArray(IW).SFMI
            XL(IW) = FixDataArray(IW).SFL
            XLo(IW) = FixDataArray(IW).SFLo
            XGHA(IW) = FixDataArray(IW).SFGHA
            XDec(IW) = FixDataArray(IW).SFDec
            XHo(IW) = FixDataArray(IW).SFHo
            XDTSight(IW) = FixDataArray(IW).SDTSight
            EP(IW) = FixDataArray(IW).SEP
        Next IW
        'DGFix.ClearSelection()
        'DGFix.CurrentCell = Nothing
        DGFix.Refresh()
        CalculateFix()
        Me.Show()
        Exit Sub
    End Sub
    Private Sub CalculateFix()
        IL = IUPass
        TimeOfFix = 0
        FixIL = 0
        SelectedFix = 0
        For i = 1 To IL
            If XSelected(i) = True Then
                SelectedFix += 1
                If XZT(i) > TimeOfFix Then
                    TimeOfFix = XZT(i)
                    FixIL = i
                End If
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
            If XSelected(i) = True Then
                ZNinRads = XZN(i) * DegtoRad
                AX += (System.Math.Cos(ZNinRads)) ^ 2
                BX += System.Math.Cos(ZNinRads) * System.Math.Sin(ZNinRads)
                CX += (System.Math.Sin(ZNinRads)) ^ 2
                DX += (XMI(i) / 60) * System.Math.Cos(ZNinRads)
                EX += (XMI(i) / 60) * System.Math.Sin(ZNinRads)
            End If
        Next i
        GX = AX * CX - BX * BX
        If GX = 0 Then ' there is no convergence of the intercepts and azimuths for this fix
            GoTo Line2200
        End If
        BFinRads = BF * DegtoRad
        LI = LF + (AX * EX - BX * DX) / (GX * System.Math.Cos(BFinRads))
        BI = BF - ((CX * DX - BX * EX) / GX) 'Sign is correct for sign of XMI
        DF = 60 * System.Math.Sqrt(((LI - LF) ^ 2) * ((System.Math.Cos(BFinRads)) ^ 2) + (BI - BF) ^ 2)
        L = BI
        BF = BI
        Lo = LI
        LF = LI
        ' if there are only 2 sites to fix their position then the previous lines of code determine the intersection of the two intercepts and no more is needed
        If SelectedFix = 2 Then
            GoTo FixPosition
        End If
        'test if too many calc loops have been done
        LoopCt += 1
        If LoopCt > 1000 Then ' if DF value can not be resolved into 1000 iterations then this fix is a bust
            GoTo Line2200
        End If
        ' keep looping until the derived intercept length is within the equivalent of 0.01' roughly equal to 0'36" or 0.5 nm
        If DF > 0.001 Then
            Loc()  ' this faux law of cosines calc is only needed when three body fixes are done - two body fixes only require simple math above for intersection of intercepts
            GoTo Line1849      'NA says D>20.  Changed in V5.6.1 to 0.01, equivalent of 0.01'.  Ron uses 0.001
        End If
FixPosition:
        If System.Math.Abs(LI) > 180 Then
            LI = -System.Math.Sign(LI) * (360 - System.Math.Abs(LI)) Mod 180 'In case fix is on other side of IDL
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
        BH = g_LatN
        If XL(FixIL) < 0 Then
            BH = g_LatS
        End If
        If XL(FixIL) = 0 Then
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
        LH = g_LongW
        If XLo(FixIL) < 0 Then
            LH = g_LongE
        End If
        If XLo(FixIL) = 0 Then
            LH = " "
        End If
        'Calculate bearing using mid-latitude sailing
        LatDiff = BI - XL(FixIL)   'BF
        LongDiff = LI - XLo(FixIL) 'LF
        'Crossing IDL
        If System.Math.Abs(LongDiff) > 180 Then
            LongDiff = -System.Math.Sign(LongDiff) * (360 - System.Math.Abs(LongDiff))
        End If
        Lm = (BI + XL(FixIL)) / 2 'Mid-latitude   'XL(FixIL)
        If LatDiff = 0 Then
            CourseAngle = Pi / 2
        Else
            Dim tmpdbl As Double = LongDiff * 60 * System.Math.Cos(Lm * DegtoRad)
            CourseAngle = System.Math.Abs(System.Math.Atan(tmpdbl / (LatDiff * 60)))
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
        'DF = 60 * LatDiff / System.Math.Cos(CourseAngle)
        'DF = Int(System.Math.Abs(DF) * 10 + 0.5) / 10
        DF = System.Math.Round(System.Math.Abs(DF), 1, MidpointRounding.AwayFromZero)
        ' Course is the True Bearing frm DR to Fix
        'Course = Int(System.Math.Abs(Course) + 0.5)
        Course = System.Math.Round(Course, 0, MidpointRounding.AwayFromZero)
        If FixIL = 0 Then
            XZH(FixIL) = 0
            XZM(FixIL) = 0
            XZS(FixIL) = 0
        End If

        txtFixZT.Text = Strings.Format(XZH(FixIL), "00") & "-" & Strings.Format(XZM(FixIL), "00") & "-" & Strings.Format(XZS(FixIL), "00")
        txtFixLat.Text = Strings.Format(BD, "#0") & Chr(176) & Strings.Format(BM, "00.0") & "'" & BH
        txtFixLong.Text = Strings.Format(FD, "##0") & Chr(176) & Strings.Format(FM, "00.0") & "'" & LH
        txtFixIntercept.Text = Strings.Format(DF, "##0.0")
        txtFixBearing.Text = Strings.Format(Course, "000") & Chr(176)

        'txtFixCalc.Clear()
        'txtFixCalc.AppendText(vbNewLine & "Fix at ZT = " & Strings.Format(XZH(FixIL), "00") & "-" & Strings.Format(XZM(FixIL), "00") & "-" & Strings.Format(XZS(FixIL), "00") & vbNewLine)
        'txtFixCalc.AppendText("Fix L  =  " & Strings.Format(BD, "#0") & Chr(176) & Strings.Format(BM, "00.0") & "'" & BH & vbNewLine)
        'txtFixCalc.AppendText("Fix Lo = " & Strings.Format(FD, "##0") & Chr(176) & Strings.Format(FM, "00.0") & "'" & LH & vbNewLine)
        'txtFixCalc.AppendText("Fix is " & Strings.Format(DF, "##0.0") & " nm from " & Strings.Format(XZH(FixIL), "00") & "-" & Strings.Format(XZM(FixIL), "00") & "-" & Strings.Format(XZS(FixIL), "00") & " DR")
        ' txtFixCalc.AppendText(", at a bearing of " & Strings.Format(Course, "000") & Chr(176) & " True")
        Exit Sub
        ' Line2200 is error exit from Fix routine - error message says it all
Line2200:
        'txtFixCalc.Clear()
        'txtFixCalc.AppendText("Fix cannot be established.")
        'txtFixCalc.AppendText("Selected sights have unacceptable cuts or excessively large intercepts.")
        ErrorMsgBox("Selected sights have unacceptable cuts or excessively large intercepts.", "Fix cannot be established.", MessageBoxButtons.OK)
        Exit Sub
    End Sub


    Private Sub ErrorMsgBox(ByVal ErrMsg As String, ByVal TitleStr As String, ByVal MsgBtn As MessageBoxButtons)
        System.Windows.Forms.MessageBox.Show(ErrMsg, TitleStr, MsgBtn,
                                                System.Windows.Forms.MessageBoxIcon.Error,
                                                System.Windows.Forms.MessageBoxDefaultButton.Button1,
                                                System.Windows.Forms.MessageBoxOptions.DefaultDesktopOnly)
        Exit Sub
    End Sub

    Private Sub Loc()
        For i = 1 To IL
            If XSelected(i) = True Then
                GHA = XGHA(i)
                DE = XDec(i)
                Ho = XHo(i)
                LHA = GHA - Lo
                If LHA >= 360 Then LHA = LHA - 360
                If LHA < 0 Then LHA = LHA + 360
                L1 = System.Math.Cos(LHA * DegtoRad) * System.Math.Cos(L * DegtoRad) * System.Math.Cos(DE * DegtoRad)
                L2 = System.Math.Sin(L * DegtoRad) * System.Math.Sin(DE * DegtoRad)
                L3 = L1 + L2
                If System.Math.Abs(L3) >= 1 Then
                    Hc = System.Math.Sign(L3) * Pi / 2
                Else
                    Hc = System.Math.Atan(L3 / System.Math.Sqrt(-L3 * L3 + 1))
                End If
                Hc = Hc * 180 / Pi

                A = 60 * (Hc - Ho)      'Ho>Hc (T) is -
                L4 = System.Math.Sin(DE * DegtoRad)
                L5 = System.Math.Sin(L * DegtoRad) * System.Math.Sin(Hc * DegtoRad)
                L6 = L4 - L5
                L7 = System.Math.Cos(L * DegtoRad) * System.Math.Cos(Hc * DegtoRad)
                L8 = L6 / L7
                If System.Math.Abs(L8) >= 1 Then
                    Z = Pi
                Else
                    Z = System.Math.Atan(-L8 / System.Math.Sqrt(-L8 * L8 + 1)) + Pi / 2      'This is really Zc, not Z (always determined from north pole
                End If
                Z = Z * 180 / Pi

                If LHA > 180 Then ZN = Z
                If LHA <= 180 Then ZN = 360 - Z

                If ZN = 360 Then ZN = 0
                XZN(i) = ZN
                XMI(i) = A
            End If

        Next i
    End Sub
End Class