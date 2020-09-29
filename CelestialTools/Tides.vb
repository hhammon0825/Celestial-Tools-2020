Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class FormTides
    Inherits System.Windows.Forms.Form
    Dim Pi As Double
    Dim LocTimeHighMinutes, TimeHighMinutes, TimeLowMinutes, LocTimeLowMinutes As Short
    Dim LocTimeHighMin, LocTimeHighHour, LocTimeLowHour, LocTimeLowMin As Short
    Dim LocHtHigh, LocHtLow As Double
    Dim TimeIntHighMinutes, DesTimeMinutes, TimeIntLowMinutes As Short
    Dim TimeIntLowMin, TimeIntHighMin, TimeIntHighHour, TimeIntLowHour, DurationMinutes As Short
    Dim DurationHour, DurationMin As Short
    Dim Factor, Range, RangeDisplay, Correction As Single
    Dim TimeDiff, i As Short
    Dim DurationStep As Single
    Dim fnumeral As String
    Public TideHeight As Single
    Public Flag As Boolean
    Dim FormTidesLoaded As Boolean = False

    Private Sub cmdClear_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClear.Click
        txtLocation.Clear()
        txtLocNo.Clear()
        DTTides.Value = Now
        DTTimeHigh.Value = Now
        DTTimeLow.Value = Now
        'txtDesTime.Clear()
        'cboDay.SelectedIndex = -1
        'cboMonth.SelectedIndex = -1
        'txtYear.Clear()
        txtRefSta.Clear()
        'txtTimeHigh.Clear()
        txtHtHigh.Clear()
        'txtTimeLow.Clear()
        txtHtLow.Clear()
        txtTab2Diff.Clear()
        txtSubStaNo.Clear()
        txtTab2HighHour.Clear()
        txtTab2HighMin.Clear()
        txtTab2HtHigh.Clear()
        txtTab2LowHour.Clear()
        txtTab2LowMin.Clear()
        txtTab2HtLow.Clear()
        Flag = False
        ClearTextBoxes()

        Exit Sub
    End Sub
    Public Sub ClearTextBoxes()
        Tides1Txt.Clear()
        Tides2Txt.Clear()
        Tides3Txt.Clear()
        Tides4Txt.Clear()
        Tides5Txt.Clear()
        Tides6Txt.Clear()
        Tides7Txt.Clear()
        Tides8Txt.Clear()
        Tides9Txt.Clear()
        Tides10Txt.Clear()
        Tides11Txt.Clear()
        Tides12Txt.Clear()
        Tides13Txt.Clear()
        Exit Sub
    End Sub

    Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
        PrintScreen(Me.Bounds)
    End Sub

    Private Sub cmdTides_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdTides.Click
        If Not FormTidesLoaded Then Exit Sub
        Flag = True 'used to check if a tide height has been calculated for Vertical Clearances
        Pi = 4 * System.Math.Atan(1.0#)
        'CheckDate
        'If txtDesTime.Text = "" Then
        '    ErrorMsgBox("You must enter a Desired Time.")
        '    txtDesTime.Focus()
        '    Exit Sub
        'End If


        TimeHighMinutes = DTTimeHigh.Value.Hour * 60 + DTTimeHigh.Value.Minute
        TimeLowMinutes = DTTimeLow.Value.Hour * 60 + DTTimeLow.Value.Minute
        'TimeHighMinutes = 60 * Val(VB.Left(txtTimeHigh.Text, 2)) + Val(VB.Right(txtTimeHigh.Text, 2))
        'TimeLowMinutes = 60 * Val(VB.Left(txtTimeLow.Text, 2)) + Val(VB.Right(txtTimeLow.Text, 2))
        If System.Math.Abs(TimeHighMinutes - TimeLowMinutes) > 720 Then
            If TimeHighMinutes < TimeLowMinutes Then TimeHighMinutes = TimeHighMinutes + 1440 Else TimeLowMinutes = TimeLowMinutes + 1440
        End If
        If txtHtHigh.Text = "" Then txtHtHigh.Text = "0"
        If txtHtHigh.Text = "-" Then txtHtHigh.Text = "-0"
        If txtHtLow.Text = "" Then txtHtLow.Text = "0"
        If txtHtLow.Text = "-" Then txtHtLow.Text = "-0"
        If txtTab2HighHour.Text = "-" Then txtTab2HighHour.Text = "-0"
        If txtTab2HighHour.Text = "" Then txtTab2HighHour.Text = "+0"
        If txtTab2HighMin.Text = "" Then txtTab2HighMin.Text = "0"
        If txtTab2HtHigh.Text = "" Then txtTab2HtHigh.Text = "0"
        If txtTab2HtHigh.Text = "-" Then txtTab2HtHigh.Text = "-0"
        If txtTab2LowHour.Text = "" Then txtTab2LowHour.Text = "+0"
        If txtTab2LowHour.Text = "-" Then txtTab2LowHour.Text = "-0"
        If txtTab2LowMin.Text = "" Then txtTab2LowMin.Text = "0"
        If txtTab2HtLow.Text = "" Then txtTab2HtLow.Text = "0"
        If txtTab2HtLow.Text = "-" Then txtTab2HtLow.Text = "-0"
        LocTimeHighMinutes = TimeHighMinutes + (60 * System.Math.Abs(Val(txtTab2HighHour.Text)) + Val(txtTab2HighMin.Text))
        If VB.Left(txtTab2HighHour.Text, 1) = "-" Then LocTimeHighMinutes = TimeHighMinutes - (60 * System.Math.Abs(Val(txtTab2HighHour.Text)) + Val(txtTab2HighMin.Text))
        LocTimeHighHour = Int(LocTimeHighMinutes / 60)
        LocTimeHighMin = Int(LocTimeHighMinutes - CInt(LocTimeHighHour) * 60)
        LocTimeLowMinutes = TimeLowMinutes + (60 * System.Math.Abs(Val(txtTab2LowHour.Text)) + Val(txtTab2LowMin.Text))
        If VB.Left(txtTab2LowHour.Text, 1) = "-" Then LocTimeLowMinutes = TimeLowMinutes - (60 * System.Math.Abs(Val(txtTab2LowHour.Text)) + Val(txtTab2LowMin.Text))
        LocTimeLowHour = Int(LocTimeLowMinutes / 60)
        LocTimeLowMin = Int(LocTimeLowMinutes - CInt(LocTimeLowHour) * 60)
        LocHtHigh = Val(txtHtHigh.Text) + Val(txtTab2HtHigh.Text)
        If VB.Left(txtTab2HtHigh.Text, 1) = "*" Then LocHtHigh = Val(txtHtHigh.Text) * Val(Mid(txtTab2HtHigh.Text, 2))
        LocHtHigh = Int(LocHtHigh * 10 + 0.5000000000001) / 10
        LocHtLow = Val(txtHtLow.Text) + Val(txtTab2HtLow.Text)
        If VB.Left(txtTab2HtLow.Text, 1) = "*" Then LocHtLow = Val(txtHtLow.Text) * Val(Mid(txtTab2HtLow.Text, 2))
        LocHtLow = Int(LocHtLow * 10 + 0.5000000000001) / 10
        If LocHtHigh <= LocHtLow Then ErrorMsgBox("Check the tide heights.") : Exit Sub
        DesTimeMinutes = (DTTides.Value.Hour * 60) + DTTides.Value.Minute '60 * Val(VB.Left(txtDesTime.Text, 2)) + Val(VB.Right(txtDesTime.Text, 2))
        TimeIntHighMinutes = System.Math.Abs(DesTimeMinutes - LocTimeHighMinutes)
        TimeIntLowMinutes = System.Math.Abs(DesTimeMinutes - LocTimeLowMinutes)
        TimeIntHighHour = Int(TimeIntHighMinutes / 60)
        TimeIntHighMin = Int(TimeIntHighMinutes - CInt(TimeIntHighHour) * 60)
        TimeIntLowHour = Int(TimeIntLowMinutes / 60)
        TimeIntLowMin = Int(TimeIntLowMinutes - CInt(TimeIntLowHour) * 60)
        'If LocTimeLowMinutes <= LocTimeHighMinutes And (DesTimeMinutes < LocTimeLowMinutes Or DesTimeMinutes > LocTimeHighMinutes) Then  ErrorMsgBox ("Check the data."): Exit Sub
        'If LocTimeLowMinutes > LocTimeHighMinutes And (DesTimeMinutes > LocTimeLowMinutes Or DesTimeMinutes < LocTimeHighMinutes) Then  ErrorMsgBox ("Check the data."): Exit Sub
        'If DesTimeMinutes = LocTimeLowMinutes Or DesTimeMinutes = LocTimeHighMinutes Then  ErrorMsgBox ("Desired Time must be between Localized Time of High and Localized Time of Low."): Exit Sub

        DurationMinutes = TimeIntHighMinutes + TimeIntLowMinutes
        If DurationMinutes = 0 Then ErrorMsgBox("Check the data.") : Exit Sub
        DurationHour = Int(DurationMinutes / 60)
        DurationMin = Int(DurationMinutes - CInt(DurationHour) * 60)
        If optTable3.Checked = True Then
            If DurationMin <= 9 Then DurationMinutes = 60 * DurationHour
            If DurationMin > 9 And DurationMin <= 29 Then DurationMinutes = 60 * DurationHour + 20
            If DurationMin > 29 And DurationMin <= 49 Then DurationMinutes = 60 * DurationHour + 40
            If DurationMin > 49 Then DurationMinutes = 60 * DurationHour + 60
        End If
        Range = System.Math.Abs(LocHtHigh - LocHtLow)
        RangeDisplay = Range
        If optTable3.Checked = True Then Range = Int(2 * Range + 0.5) / 2
        If TimeIntHighMinutes > TimeIntLowMinutes Then Factor = System.Math.Abs((DesTimeMinutes - LocTimeLowMinutes) / DurationMinutes)
        If TimeIntHighMinutes <= TimeIntLowMinutes Then Factor = System.Math.Abs((DesTimeMinutes - LocTimeHighMinutes) / DurationMinutes)
        If optTable3.Checked = True Then
            Factor = Factor * 30
            Factor = Int(Factor + 0.5)
            Factor = Factor / 30
        End If
        Correction = Range / 2 * (1 - System.Math.Cos(Pi * Factor))
        If optRule.Checked = True Then
            If LocTimeHighMinutes <= DesTimeMinutes Then TimeDiff = TimeIntHighMinutes
            If LocTimeLowMinutes < DesTimeMinutes Then TimeDiff = TimeIntLowMinutes
            TimeDiff = Int(TimeDiff / 60 + 0.5)
            If TimeDiff = 0 Then Factor = 0
            If TimeDiff = 1 Then Factor = 0.05
            If TimeDiff = 2 Then Factor = 0.25
            If TimeDiff = 3 Then Factor = 0.5
            If TimeDiff = 4 Then Factor = 0.75
            If TimeDiff = 5 Then Factor = 0.95
            If TimeDiff = 6 Then Factor = 1
            'Range = Int(Range + 0.5)
            Correction = Range * Factor
        End If
        Static x(6) As Single
        Static Diff(6) As Single
        'If optRule = True And Abs(DurationMinutes - 360) >= 60 Then
        If optAltRule.Checked = True Then
            DurationStep = DurationMinutes / 6
            If LocTimeHighMinutes <= DesTimeMinutes Then x(0) = LocTimeHighMinutes
            If LocTimeLowMinutes < DesTimeMinutes Then x(0) = LocTimeLowMinutes
            Diff(0) = System.Math.Abs(x(0) - DesTimeMinutes)
            For i = 1 To 6
                x(i) = x(i - 1) + DurationStep
                Diff(i) = System.Math.Abs(x(i) - DesTimeMinutes)
                If Diff(i) > Diff(i - 1) Then Exit For
            Next i
            i = i - 1
            'TimeDiff = Int(TimeDiff / 60 + 0.5)
            If i = 0 Then Factor = 0
            If i = 1 Then Factor = 0.05
            If i = 2 Then Factor = 0.25
            If i = 3 Then Factor = 0.5
            If i = 4 Then Factor = 0.75
            If i = 5 Then Factor = 0.95
            If i = 6 Then Factor = 1
            'Range = Int(Range + 0.5)
            Correction = Range * Factor
        End If
        Correction = Int(Correction * 10 + 0.500001) / 10
        'TideHeight = Range / 2 * Cos(Pi * (DesTimeMinutes - LocTimeHighMinutes) / DurationMinutes) + (LocHtHigh + LocHtLow) / 2
        If optCalc.Checked = True Or optTable3.Checked = True Then
            If TimeIntLowMinutes < TimeIntHighMinutes Then TideHeight = LocHtLow + Correction
            If TimeIntHighMinutes <= TimeIntLowMinutes Then TideHeight = LocHtHigh - Correction
        End If
        If optRule.Checked = True Or optAltRule.Checked = True Then
            If LocTimeLowMinutes < DesTimeMinutes Then TideHeight = LocHtLow + Correction
            If LocTimeHighMinutes <= DesTimeMinutes Then TideHeight = LocHtHigh - Correction
        End If
        'Correction = TideHeight - LocHtLow
        TideHeight = Int(TideHeight * 10 + 0.500001) / 10
        'clear form text boxes for reporting data
        ClearTextBoxes()
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> format tides1txt, tides2txt, and tides3txt boxes <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

        If LocTimeHighHour >= 24 Then LocTimeHighHour = LocTimeHighHour - 24
        If LocTimeLowHour >= 24 Then LocTimeLowHour = LocTimeLowHour - 24
        Tides1Txt.AppendText("  Localized Data:  " & txtTab2Diff.Text)
        Tides2Txt.AppendText(Strings.Format(LocTimeHighHour, "00") & Strings.Format(LocTimeHighMin, "00") & Space(6))
        If LocHtHigh < 0 Then Tides2Txt.AppendText("-")
        If LocHtHigh >= 0 Then Tides2Txt.AppendText("+")
        Tides2Txt.AppendText(Strings.Format(System.Math.Abs(LocHtHigh), "0.0"))
        Tides3Txt.AppendText(Strings.Format(LocTimeLowHour, "00") & Strings.Format(LocTimeLowMin, "00") & Space(6))
        If LocHtLow < 0 Then Tides3Txt.AppendText("-")
        If LocHtLow >= 0 Then Tides3Txt.AppendText("+")
        Tides3Txt.AppendText(Strings.Format(System.Math.Abs(LocHtLow), "0.0"))
        'If LocTimeLowMinutes <= LocTimeHighMinutes And (DesTimeMinutes < LocTimeLowMinutes Or DesTimeMinutes > LocTimeHighMinutes) Then ErrorMsgBox("Check the data.  Desired Time must be between Localized Time of High and Localized Time of Low.") : Exit Sub
        'If LocTimeLowMinutes > LocTimeHighMinutes And (DesTimeMinutes > LocTimeLowMinutes Or DesTimeMinutes < LocTimeHighMinutes) Then ErrorMsgBox("Check the data.  Desired Time must be between Localized Time of High and Localized Time of Low.") : Exit Sub
        'If DesTimeMinutes = LocTimeLowMinutes Or DesTimeMinutes = LocTimeHighMinutes Then ErrorMsgBox("Check the data.  Desired Time must be between Localized Time of High and Localized Time of Low.") : Exit Sub
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> format tides4txt and tides5txt boxes <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

        SetTxtBxBoldOn(Tides4Txt)
        Tides4Txt.AppendText("  Time Interval Between:")
        SetTxtBxtoReg(Tides4Txt)
        If optCalc.Checked = True Or optTable3.Checked = True Then
            Tides4Txt.AppendText("(Use smaller of the two.)" & vbNewLine)
            Tides5Txt.AppendText("Time Interval" & vbNewLine)
        Else
            Tides4Txt.AppendText(vbNewLine)
            Tides5Txt.AppendText(vbNewLine)
        End If
        If optCalc.Checked = True Or optTable3.Checked = True Then
            Tides4Txt.AppendText("     Desired Time & Time of Local High Tide  ")
            If TimeIntHighMinutes < TimeIntLowMinutes And optCalc.Checked = True Or optTable3.Checked = True Then
                SetTxtBxBoldOn(Tides4Txt)
            End If

            Tides4Txt.AppendText("DT~H")
            SetTxtBxtoReg(Tides4Txt)
            Tides4Txt.AppendText(vbNewLine)

            Tides5Txt.AppendText(CStr(TimeIntHighHour) & " h " & Strings.Format(TimeIntHighMin, "00") & " m")
            Tides5Txt.AppendText(vbNewLine)
            Tides4Txt.AppendText("     Desired Time & Time of Local Low Tide  ")
            If TimeIntHighMinutes > TimeIntLowMinutes Then
                SetTxtBxBoldOn(Tides4Txt)
            End If

            Tides4Txt.AppendText("DT~L")
            SetTxtBxtoReg(Tides4Txt)
            Tides4Txt.AppendText(vbNewLine)

            Tides5Txt.AppendText(CStr(TimeIntLowHour) & " h " & Strings.Format(TimeIntLowMin, "00") & " m")
            Tides5Txt.AppendText(vbNewLine)
        End If
        If optRule.Checked = True Or optAltRule.Checked = True Then

            Tides4Txt.AppendText("     Desired Time & Time of preceding Local ")
            If TimeIntHighMinutes <= TimeIntLowMinutes Then
                SetTxtBxBoldOn(Tides4Txt)
            End If

            Tides4Txt.AppendText("High")
            SetTxtBxtoReg(Tides4Txt)

            Tides4Txt.AppendText(" or ")
            If TimeIntHighMinutes > TimeIntLowMinutes Then
                SetTxtBxBoldOn(Tides4Txt)
            End If

            Tides4Txt.AppendText("Low")
            SetTxtBxtoReg(Tides4Txt)

            Tides4Txt.AppendText(" Tide")
            Tides4Txt.AppendText(vbNewLine)

            If TimeIntHighMinutes <= TimeIntLowMinutes Then
                Tides5Txt.AppendText(TimeIntHighHour.ToString & " h " & Strings.Format(TimeIntHighMin, "00") & " m")
            End If

            If TimeIntHighMinutes > TimeIntLowMinutes Then
                Tides5Txt.AppendText(TimeIntLowHour.ToString & " h " & Strings.Format(TimeIntLowMin, "00") & " m")
            End If
            Tides5Txt.AppendText(vbNewLine)

            Tides4Txt.AppendText("     Time of Local High Tide & Time of Local Low Tide  ")
            Tides4Txt.AppendText(vbNewLine)
            Tides5Txt.AppendText(CStr(DurationHour) & " h " & Strings.Format(DurationMin, "00") & " m")
            Tides5Txt.AppendText(vbNewLine)
        End If
        '>>>>>>>>>>>>>>>>>>>>>>>> format tides6txt and tides7txt boxes <<<<<<<<<<<<<<<<<<<<<<<<<<<<

        SetTxtBxBoldOn(Tides6Txt)
        If optTable3.Checked = True Then
            Tides6Txt.AppendText("  Entering Arguments for Table 3:")
        End If
        If optCalc.Checked = True Then
            Tides6Txt.AppendText("  Values for Calculation:")
        End If
        SetTxtBxtoReg(Tides6Txt)
        If optCalc.Checked = True Or optTable3.Checked = True Then

            Tides6Txt.AppendText("     Duration of ")
            If LocTimeLowMinutes <= DesTimeMinutes Then
                SetTxtBxBoldOn(Tides6Txt)
            End If

            Tides6Txt.AppendText("Rise (L-H)")
            SetTxtBxtoReg(Tides6Txt)

            Tides6Txt.AppendText(" or ")
            If LocTimeHighMinutes <= DesTimeMinutes Then
                SetTxtBxBoldOn(Tides6Txt)
            End If

            Tides6Txt.AppendText("Fall (H-L)")
            SetTxtBxtoReg(Tides6Txt)
            Tides6Txt.AppendText(vbNewLine)

            Tides7Txt.AppendText(CStr(DurationHour) & " h " & Strings.Format(DurationMin, "00") & " m")
            Tides7Txt.AppendText(vbNewLine)

            Tides6Txt.AppendText("     Time Interval of ")
            If TimeIntHighMinutes <= TimeIntLowMinutes Then
                SetTxtBxBoldOn(Tides6Txt)
            End If

            Tides6Txt.AppendText("H")
            SetTxtBxtoReg(Tides6Txt)

            Tides6Txt.AppendText(" or ")
            If TimeIntHighMinutes > TimeIntLowMinutes Then
                SetTxtBxBoldOn(Tides6Txt)
            End If

            Tides6Txt.AppendText("L")
            SetTxtBxtoReg(Tides6Txt)

            Tides6Txt.AppendText(" (whichever is closer)")
            Tides6Txt.AppendText(vbNewLine)

            If TimeIntHighMinutes <= TimeIntLowMinutes Then
                Tides7Txt.AppendText(CStr(TimeIntHighHour) & " h " & Strings.Format(TimeIntHighMin, "00") & " m")
            End If

            If TimeIntHighMinutes > TimeIntLowMinutes Then
                Tides7Txt.AppendText(CStr(TimeIntLowHour) & " h " & Strings.Format(TimeIntLowMin, "00") & " m")
            End If
            Tides7Txt.AppendText(vbNewLine)

        End If
        If optRule.Checked = True Or optAltRule.Checked = True Then
            SetTxtBxBoldOn(Tides6Txt)

            Tides6Txt.AppendText("  Values for Rule of Twelfths")

            If optAltRule.Checked = True Then
                Tides6Txt.AppendText(" (alternate)")
            End If

            Tides6Txt.AppendText(":")
            SetTxtBxtoReg(Tides6Txt)
            Tides6Txt.AppendText(vbNewLine)


            Tides6Txt.AppendText("     Time Interval from ")
            If LocTimeHighMinutes < DesTimeMinutes Then
                SetTxtBxBoldOn(Tides6Txt)
            End If

            Tides6Txt.AppendText("H")
            SetTxtBxtoReg(Tides6Txt)

            Tides6Txt.AppendText(" or ")
            If LocTimeLowMinutes < DesTimeMinutes Then
                SetTxtBxBoldOn(Tides6Txt)
            End If

            Tides6Txt.AppendText("L")
            SetTxtBxtoReg(Tides6Txt)

            Tides6Txt.AppendText(" (whichever precedes desired time)")
            Tides6Txt.AppendText(vbNewLine)
            'If LocTimeHighMinutes >= 1440 Then LocTimeHighMinutes = LocTimeHighMinutes - 1440
            'If LocTimeLowMinutes >= 1440 Then LocTimeLowMinutes = LocTimeLowMinutes - 1440

            If LocTimeHighMinutes < DesTimeMinutes Then
                Tides7Txt.AppendText(CStr(TimeIntHighHour) & " h " & Strings.Format(TimeIntHighMin, "00") & " m")
            End If

            If LocTimeLowMinutes < DesTimeMinutes Then
                Tides6Txt.AppendText(CStr(TimeIntLowHour) & " h " & Strings.Format(TimeIntLowMin, "00") & " m")
            End If
            Tides7Txt.AppendText(vbNewLine)

            Tides6Txt.AppendText("     Rounded Time Interval (as percent change)" & vbNewLine)
            Tides7Txt.AppendText(CStr(Factor * 100) & "%" & vbNewLine)
        End If
        Tides6Txt.AppendText("     Range of Tide at Local (Table 2) Substation")
        Tides7Txt.AppendText(Strings.Format(RangeDisplay, "0.0") & " ft")
        '>>>>>>>>>>>>>>>>>>>>>>>>> format tides8txt and tides9txt <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        Tides8Txt.AppendText("Height of Tide Correction from ")
        If optTable3.Checked = True Then
            Tides8Txt.AppendText("Table 3")
        End If
        If optCalc.Checked = True Then
            Tides8Txt.AppendText("calculation")
        End If
        If optRule.Checked = True Then
            Tides8Txt.AppendText("Rule of Twelfths")
        End If
        If optAltRule.Checked = True Then
            Tides8Txt.AppendText("Rule of Twelfths (alternate)")
        End If
        Tides9Txt.AppendText(Strings.Format(Correction, "0.0") & " ft")
        '>>>>>>>>>>>>>>>>>>> format tides10txt and tides11txt boxes <<<<<<<<<<<<<<<<<<<<<<
        SetTxtBxBoldOn(Tides10Txt)
        If optTable3.Checked = True Then
            Tides10Txt.AppendText("  Application of Table 3 Correction:")
        End If
        If optCalc.Checked = True Then
            Tides10Txt.AppendText("  Application of Calculated Correction:")
        End If
        If optRule.Checked = True Or optAltRule.Checked = True Then
            Tides10Txt.AppendText("  Application of Rule of Twelfths Correction:")
        End If
        SetTxtBxtoReg(Tides6Txt)
        Tides10Txt.AppendText(vbNewLine)
        Tides11Txt.AppendText(vbNewLine)
        If optCalc.Checked = True Or optTable3.Checked = True Then

            Tides10Txt.AppendText("     Ht. of Tide at Local Substation:  ")
            If TimeIntHighMinutes <= TimeIntLowMinutes Then
                SetTxtBxBoldOn(Tides10Txt)
            End If

            Tides10Txt.AppendText("H")
            SetTxtBxtoReg(Tides6Txt)

            Tides10Txt.AppendText(" or ")
            If TimeIntHighMinutes > TimeIntLowMinutes Then
                SetTxtBxBoldOn(Tides10Txt)
            End If

            Tides10Txt.AppendText("L")
            SetTxtBxtoReg(Tides6Txt)

            Tides10Txt.AppendText(" whichever is closer in time.")
            Tides10Txt.AppendText(vbNewLine)

            If TimeIntHighMinutes <= TimeIntLowMinutes Then
                If LocHtHigh < 0 Then Tides11Txt.AppendText("-")
                If LocHtHigh >= 0 Then Tides11Txt.AppendText("+")
                Tides11Txt.AppendText(Strings.Format(System.Math.Abs(LocHtHigh), "0.0") & " ft")
            End If
            If TimeIntHighMinutes > TimeIntLowMinutes Then
                If LocHtLow < 0 Then Tides11Txt.AppendText("-")
                If LocHtLow >= 0 Then Tides11Txt.AppendText("+")
                Tides11Txt.AppendText(Strings.Format(System.Math.Abs(LocHtLow), "0.0") & " ft")
            End If
            Tides11Txt.AppendText(vbNewLine)
        End If
        If optRule.Checked = True Or optAltRule.Checked = True Then
            Tides10Txt.AppendText("     Ht. of Tide at Local Substation:  ")
            If LocTimeHighMinutes <= DesTimeMinutes Then
                SetTxtBxBoldOn(Tides10Txt)
            End If

            Tides10Txt.AppendText("H")
            SetTxtBxtoReg(Tides6Txt)

            Tides10Txt.AppendText(" or ")
            If LocTimeLowMinutes < DesTimeMinutes Then
                SetTxtBxBoldOn(Tides10Txt)
            End If

            Tides10Txt.AppendText("L")
            SetTxtBxtoReg(Tides6Txt)

            Tides10Txt.AppendText(" whichever precedes desired time.")
            Tides10Txt.AppendText(vbNewLine)
            If LocTimeHighMinutes <= DesTimeMinutes Then
                If LocHtHigh < 0 Then
                    Tides11Txt.AppendText("-")
                End If
                If LocHtHigh >= 0 Then
                    Tides11Txt.AppendText("+")
                End If
                Tides11Txt.AppendText(Strings.Format(System.Math.Abs(LocHtHigh), "0.0") & " ft")
            End If
            If LocTimeLowMinutes < DesTimeMinutes Then
                If LocHtLow < 0 Then
                    Tides11Txt.AppendText("-")
                End If
                If LocHtLow >= 0 Then
                    Tides11Txt.AppendText("+")
                End If
                Tides11Txt.AppendText(Strings.Format(System.Math.Abs(LocHtLow), "0.0") & " ft")
            End If
            Tides11Txt.AppendText(vbNewLine)
        End If
        If optTable3.Checked = True Then
            Tides10Txt.AppendText("     Table 3 Correction:  ")
        End If
        If optCalc.Checked = True Then
            Tides10Txt.AppendText("     Calculated Correction:  ")
        End If
        If optRule.Checked = True Or optAltRule.Checked = True Then
            Tides10Txt.AppendText("     Rule of Twelfths Correction:  ")
        End If
        If optCalc.Checked = True Or optTable3.Checked = True Then
            If TimeIntHighMinutes <= TimeIntLowMinutes Then
                SetTxtBxBoldOn(Tides10Txt)
            End If

            Tides10Txt.AppendText(" Subtract from H")
            SetTxtBxtoReg(Tides6Txt)

            Tides10Txt.AppendText(" or ")
            If TimeIntHighMinutes > TimeIntLowMinutes Then
                SetTxtBxBoldOn(Tides10Txt)
            End If

            Tides10Txt.AppendText("Add to L")
            SetTxtBxtoReg(Tides6Txt)
            'Tides10Txt.AppendText(vbNewLine)

            If TimeIntHighMinutes <= TimeIntLowMinutes Then
                Tides11Txt.AppendText("-")
            End If
            If TimeIntHighMinutes > TimeIntLowMinutes Then
                Tides11Txt.AppendText("+")
            End If
            Tides11Txt.AppendText(Strings.Format(System.Math.Abs(Correction), "0.0") & " ft")
            'Tides11Txt.AppendText(vbNewLine)
        End If
        If optRule.Checked = True Or optAltRule.Checked = True Then
            If LocTimeHighMinutes <= DesTimeMinutes Then
                SetTxtBxBoldOn(Tides10Txt)
            End If

            Tides10Txt.AppendText(" Subtract from H")
            SetTxtBxtoReg(Tides6Txt)

            Tides10Txt.AppendText(" or ")
            If LocTimeLowMinutes < DesTimeMinutes Then
                SetTxtBxBoldOn(Tides10Txt)
            End If

            Tides10Txt.AppendText("Add to L")
            SetTxtBxtoReg(Tides6Txt)

            If LocTimeHighMinutes <= DesTimeMinutes Then
                Tides11Txt.AppendText("-")
            End If
            If LocTimeLowMinutes < DesTimeMinutes Then
                Tides11Txt.AppendText("+")
            End If
            Tides11Txt.AppendText(Strings.Format(System.Math.Abs(Correction), "0.0") & " ft")
        End If
        ' >>>>>>>>>>>>>>>>>>>>>>>>>>>>> format tides12txt and tides13txt boxes <<<<<<<<<<<<<<<<<<<<<<<<<<<<<

        Tides12Txt.AppendText("Predicted Height of Tide at Desired Time at Local (Table 2) Substation")
        If TideHeight < 0 Then Tides13Txt.AppendText("-")
        If TideHeight >= 0 Then Tides13Txt.AppendText("+")
        Tides13Txt.AppendText(Strings.Format(System.Math.Abs(TideHeight), "0.0") & " ft")
    End Sub


    Private Sub cmdVertical_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdVertical.Click
        If Flag = True Then FormVertical.txtHeight.Text = Strings.Format(Str(TideHeight), "0.0") Else FormVertical.txtHeight.Text = ""
        'FormVertical.cmdClear
        FormVertical.Show()
    End Sub

    Private Sub FormTides_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Flag = False
        If My.Computer.Network.IsAvailable Then
            LinkNOAATideCurr.Visible = True
            LinkNOAATideCurr.Enabled = True
        Else
            LinkNOAATideCurr.Visible = False
            LinkNOAATideCurr.Enabled = False
        End If
        DTTides.Value = Now
        FormTidesLoaded = True
    End Sub

    Private Sub optAltRule_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optAltRule.CheckedChanged
        If eventSender.Checked Then
            cmdTides_Click(cmdTides, New System.EventArgs())
        End If
    End Sub

    Private Sub optCalc_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optCalc.CheckedChanged
        If eventSender.Checked Then
            cmdTides_Click(cmdTides, New System.EventArgs())
        End If
    End Sub

    Private Sub optRule_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optRule.CheckedChanged
        If eventSender.Checked Then
            cmdTides_Click(cmdTides, New System.EventArgs())
        End If
    End Sub

    Private Sub optTable3_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optTable3.CheckedChanged
        If eventSender.Checked Then
            cmdTides_Click(cmdTides, New System.EventArgs())
        End If
    End Sub

    'Private Sub txtDesTime_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
    '    'txtTime.ForeColor = &H80000008
    '    txtDesTime.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
    '    If Len(txtDesTime.Text) = 4 And (Val(VB.Left(txtDesTime.Text, 2)) > 23 Or Val(Mid(txtDesTime.Text, 3, 2)) > 59) Then
    '        txtDesTime.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
    '        ErrorMsgBox("Out of Range")
    '        Exit Sub
    '    End If
    'End Sub

    'Private Sub txtDesTime_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
    '    Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
    '    Select Case KeyAscii
    '        Case Asc("0") To Asc("9")
    '            fnumeral = fnumeral & Chr(KeyAscii)
    '        Case Asc(Chr(8))
    '            fnumeral = fnumeral & Chr(KeyAscii)
    '        Case Else
    '            KeyAscii = 0
    '            Beep()
    '    End Select
    '    eventArgs.KeyChar = Chr(KeyAscii)
    '    If KeyAscii = 0 Then
    '        eventArgs.Handled = True
    '    End If
    'End Sub

    'Private Sub txtDesTime_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs)
    '    Dim KeepFocus As Boolean = eventArgs.Cancel
    '    If Val(VB.Left(txtDesTime.Text, 2)) > 23 Or Val(Mid(txtDesTime.Text, 3, 2)) > 59 Or Len(txtDesTime.Text) <> 4 Then
    '        KeepFocus = True
    '    End If
    '    If Len(txtDesTime.Text) = 0 Then
    '        KeepFocus = False
    '    End If
    '    eventArgs.Cancel = KeepFocus
    'End Sub
    'Private Sub txtDesTime_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
    '    SelectAllText(txtDesTime)
    'End Sub

    Private Sub txtLocation_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLocation.TextChanged
        txtTab2Diff.Text = txtLocation.Text
    End Sub
    Private Sub txtLocation_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLocation.Enter
        SelectAllText(txtLocation)
    End Sub

    Private Sub txtLocNo_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLocNo.TextChanged
        txtSubStaNo.Text = txtLocNo.Text
    End Sub
    Private Sub txtLocNo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtLocNo.KeyPress
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
    Private Sub txtLocNo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLocNo.Enter
        SelectAllText(txtLocNo)
    End Sub

    Private Sub txtRefSta_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtRefSta.Enter
        SelectAllText(txtRefSta)
    End Sub

    Private Sub txtSubStaNo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtSubStaNo.KeyPress
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

    'Private Sub txtTimeHigh_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
    '    'txtTime.ForeColor = &H80000008
    '    txtTimeHigh.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
    '    If Len(txtTimeHigh.Text) = 4 And (Val(VB.Left(txtTimeHigh.Text, 2)) > 23 Or Val(Mid(txtTimeHigh.Text, 3, 2)) > 59) Then
    '        txtTimeHigh.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
    '        ErrorMsgBox("Out of Range")
    '        Exit Sub
    '    End If
    'End Sub

    'Private Sub txtTimeHigh_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
    '    Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
    '    Select Case KeyAscii
    '        Case Asc("0") To Asc("9")
    '            fnumeral = fnumeral & Chr(KeyAscii)
    '        Case Asc(Chr(8))
    '            fnumeral = fnumeral & Chr(KeyAscii)
    '        Case Else
    '            KeyAscii = 0
    '            Beep()
    '    End Select
    '    eventArgs.KeyChar = Chr(KeyAscii)
    '    If KeyAscii = 0 Then
    '        eventArgs.Handled = True
    '    End If
    'End Sub

    'Private Sub txtTimeHigh_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs)
    '    Dim KeepFocus As Boolean = eventArgs.Cancel
    '    If Val(VB.Left(txtTimeHigh.Text, 2)) > 23 Or Val(Mid(txtTimeHigh.Text, 3, 2)) > 59 Or Len(txtTimeHigh.Text) <> 4 Then
    '        KeepFocus = True
    '    End If
    '    If Len(txtTimeHigh.Text) = 0 Then
    '        KeepFocus = False
    '    End If
    '    eventArgs.Cancel = KeepFocus
    'End Sub
    'Private Sub txtTimeHigh_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
    '    SelectAllText(txtTimeHigh)
    'End Sub

    'Private Sub txtTimeLow_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
    '    'txtTime.ForeColor = &H80000008
    '    txtTimeLow.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
    '    If Len(txtTimeLow.Text) = 4 And (Val(VB.Left(txtTimeLow.Text, 2)) > 23 Or Val(Mid(txtTimeLow.Text, 3, 2)) > 59) Then
    '        txtTimeLow.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
    '        ErrorMsgBox("Out of Range")
    '        Exit Sub
    '    End If
    'End Sub

    'Private Sub txtTimeLow_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
    '    Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
    '    Select Case KeyAscii
    '        Case Asc("0") To Asc("9")
    '            fnumeral = fnumeral & Chr(KeyAscii)
    '        Case Asc(Chr(8))
    '            fnumeral = fnumeral & Chr(KeyAscii)
    '        Case Else
    '            KeyAscii = 0
    '            Beep()
    '    End Select
    '    eventArgs.KeyChar = Chr(KeyAscii)
    '    If KeyAscii = 0 Then
    '        eventArgs.Handled = True
    '    End If
    'End Sub

    'Private Sub txtTimeLow_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs)
    '    Dim KeepFocus As Boolean = eventArgs.Cancel
    '    If Val(VB.Left(txtTimeLow.Text, 2)) > 23 Or Val(Mid(txtTimeLow.Text, 3, 2)) > 59 Or Len(txtTimeLow.Text) <> 4 Then
    '        KeepFocus = True
    '    End If
    '    If Len(txtTimeLow.Text) = 0 Then
    '        KeepFocus = False
    '    End If
    '    eventArgs.Cancel = KeepFocus
    'End Sub
    'Private Sub txtTimeLow_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
    '    SelectAllText(txtTimeLow)
    'End Sub

    Private Sub txtTab2HighHour_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTab2HighHour.TextChanged
        'txtTime.ForeColor = &H80000008
        txtTab2HighHour.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
    End Sub

    Private Sub txtTab2HighHour_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTab2HighHour.KeyPress
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
                If txtTab2HighHour.SelectionStart <> 0 Or bMinusSignAlready Then
                    KeyAscii = 0
                    Beep()
                Else
                    bMinusSignAlready = True
                End If
            Case Asc("+")

                If txtTab2HighHour.SelectionStart <> 0 Or bPlusSignAlready Then
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

    Private Sub txtTab2HighHour_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtTab2HighHour.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtTab2HighHour_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTab2HighHour.Enter
        SelectAllText(txtTab2HighHour)
    End Sub

    Private Sub txtTab2HighMin_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTab2HighMin.TextChanged
        'txtTime.ForeColor = &H80000008
        txtTab2HighMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Len(txtTab2HighMin.Text) = 2 And Val(txtTab2HighMin.Text) > 59 Then
            txtTab2HighMin.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
    End Sub

    Private Sub txtTab2HighMin_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTab2HighMin.KeyPress
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

    Private Sub txtTab2HighMin_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtTab2HighMin.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtTab2HighMin.Text) > 59 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtTab2HighMin_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTab2HighMin.Enter
        SelectAllText(txtTab2HighMin)
    End Sub

    Private Sub txtTab2LowHour_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTab2LowHour.TextChanged
        txtTab2LowHour.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
    End Sub

    Private Sub txtTab2LowHour_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTab2LowHour.KeyPress
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
                If txtTab2LowHour.SelectionStart <> 0 Or bMinusSignAlready Then
                    KeyAscii = 0
                    Beep()
                Else
                    bMinusSignAlready = True
                End If
            Case Asc("+")

                If txtTab2LowHour.SelectionStart <> 0 Or bPlusSignAlready Then
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

    Private Sub txtTab2LowHour_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtTab2LowHour.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtTab2LowHour_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTab2LowHour.Enter
        SelectAllText(txtTab2LowHour)
    End Sub

    Private Sub txtTab2LowMin_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTab2LowMin.TextChanged
        'txtTime.ForeColor = &H80000008
        txtTab2LowMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Len(txtTab2LowMin.Text) = 2 And Val(txtTab2LowMin.Text) > 59 Then
            txtTab2LowMin.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
    End Sub

    Private Sub txtTab2LowMin_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTab2LowMin.KeyPress
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

    Private Sub txtTab2LowMin_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtTab2LowMin.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtTab2LowMin.Text) > 59 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

    Private Sub txtTab2LowMin_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTab2LowMin.Enter
        SelectAllText(txtTab2LowMin)
    End Sub

    Private Sub txtHtHigh_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtHtHigh.KeyPress
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
                If txtHtHigh.SelectionStart <> 0 Or bMinusSignAlready Then
                    KeyAscii = 0
                    Beep()
                Else
                    bMinusSignAlready = True
                End If
            Case Asc("+")

                If txtHtHigh.SelectionStart <> 0 Or bPlusSignAlready Then
                    KeyAscii = 0
                    Beep()
                Else
                    bPlusSignAlready = True
                End If
            Case Asc(".") 'only allows one decimal point
                If InStr(txtHtHigh.Text, ".") Then
                    If KeyAscii = 46 Then KeyAscii = 0 : Beep()
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

    Private Sub DTTimeHigh_ValueChanged(sender As Object, e As EventArgs) Handles DTTimeHigh.ValueChanged

    End Sub

    Private Sub txtHtHigh_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtHtHigh.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        eventArgs.Cancel = KeepFocus
    End Sub

    Private Sub LinkNOAATideCurr_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkNOAATideCurr.LinkClicked
        'Dim URLNOAATideCurr As String = "https://oceanservice.noaa.gov/navigation/tidesandcurrents/"
        Dim URLNOAATideCurr As String = "https://tidesandcurrents.noaa.gov/tide_predictions.html"
        System.Diagnostics.Process.Start(URLNOAATideCurr)
        Exit Sub
    End Sub

    Private Sub txtHtHigh_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHtHigh.Enter
        SelectAllText(txtHtHigh)
    End Sub

    Private Sub txtHtLow_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtHtLow.KeyPress
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
                If txtHtLow.SelectionStart <> 0 Or bMinusSignAlready Then
                    KeyAscii = 0
                    Beep()
                Else
                    bMinusSignAlready = True
                End If
            Case Asc("+")

                If txtHtLow.SelectionStart <> 0 Or bPlusSignAlready Then
                    KeyAscii = 0
                    Beep()
                Else
                    bPlusSignAlready = True
                End If
            Case Asc(".") 'only allows one decimal point
                If InStr(txtHtLow.Text, ".") Then
                    If KeyAscii = 46 Then KeyAscii = 0 : Beep()
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
    Private Sub txtHtLow_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtHtLow.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtHtLow_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHtLow.Enter
        SelectAllText(txtHtLow)
    End Sub

    Private Sub txtTab2HtHigh_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTab2HtHigh.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Static bMinusSignAlready As Boolean
        Static bPlusSignAlready As Boolean
        Static bAsteriskAlready As Boolean
        bMinusSignAlready = False
        bPlusSignAlready = False
        bAsteriskAlready = False
        Select Case KeyAscii
            Case System.Windows.Forms.Keys.Back, System.Windows.Forms.Keys.Right, System.Windows.Forms.Keys.Left
                'do nothing
            Case Asc("0") To Asc("9")
                'do nothing
            Case Asc("-")
                If txtTab2HtHigh.SelectionStart <> 0 Or bMinusSignAlready Then
                    KeyAscii = 0
                    Beep()
                Else
                    bMinusSignAlready = True
                End If
            Case Asc("+")

                If txtTab2HtHigh.SelectionStart <> 0 Or bPlusSignAlready Then
                    KeyAscii = 0
                    Beep()
                Else
                    bPlusSignAlready = True
                End If
            Case Asc("*")

                If txtTab2HtHigh.SelectionStart <> 0 Or bAsteriskAlready Then
                    KeyAscii = 0
                    Beep()
                Else
                    bAsteriskAlready = True
                End If
            Case Asc(".") 'only allows one decimal point
                If InStr(txtTab2HtHigh.Text, ".") Then
                    If KeyAscii = 46 Then KeyAscii = 0 : Beep()
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
    Private Sub txtTab2HtHigh_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtTab2HtHigh.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtTab2HtHigh_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTab2HtHigh.Enter
        SelectAllText(txtTab2HtHigh)
    End Sub

    Private Sub txtTab2HtLow_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTab2HtLow.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Static bMinusSignAlready As Boolean
        Static bPlusSignAlready As Boolean
        Static bAsteriskAlready As Boolean
        bMinusSignAlready = False
        bPlusSignAlready = False
        bAsteriskAlready = False
        Select Case KeyAscii
            Case System.Windows.Forms.Keys.Back, System.Windows.Forms.Keys.Right, System.Windows.Forms.Keys.Left
                'do nothing
            Case Asc("0") To Asc("9")
                'do nothing
            Case Asc("-")
                If txtTab2HtLow.SelectionStart <> 0 Or bMinusSignAlready Then
                    KeyAscii = 0
                    Beep()
                Else
                    bMinusSignAlready = True
                End If
            Case Asc("+")

                If txtTab2HtLow.SelectionStart <> 0 Or bPlusSignAlready Then
                    KeyAscii = 0
                    Beep()
                Else
                    bPlusSignAlready = True
                End If
            Case Asc("*")

                If txtTab2HtLow.SelectionStart <> 0 Or bAsteriskAlready Then
                    KeyAscii = 0
                    Beep()
                Else
                    bAsteriskAlready = True
                End If
            Case Asc(".") 'only allows one decimal point
                If InStr(txtTab2HtLow.Text, ".") Then
                    If KeyAscii = 46 Then KeyAscii = 0 : Beep()
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
    Private Sub txtTab2HtLow_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtTab2HtLow.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtTab2HtLow_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTab2HtLow.Enter
        SelectAllText(txtTab2HtLow)
    End Sub

    Private Sub FormTides_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'Cleanup()
    End Sub

    'Private Sub txtYear_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
    '    Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
    '    Select Case KeyAscii
    '        Case Asc("0") To Asc("9")
    '            fnumeral = fnumeral & Chr(KeyAscii)
    '        Case Asc(Chr(8))
    '            fnumeral = fnumeral & Chr(KeyAscii)
    '        Case Else
    '            KeyAscii = 0
    '            Beep()
    '    End Select
    '    eventArgs.KeyChar = Chr(KeyAscii)
    '    If KeyAscii = 0 Then
    '        eventArgs.Handled = True
    '    End If
    'End Sub
    'Private Sub txtYear_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
    '    SelectAllText(txtYear)
    'End Sub

    Private Sub SelectAllText(ByRef TB As System.Windows.Forms.TextBox)
        TB.SelectionStart = 0
        TB.SelectionLength = Len(TB.Text)
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
    Private Sub ErrorMsgBox(ByVal ErrMsg As String)
        System.Windows.Forms.MessageBox.Show(ErrMsg, "Error",
                                                System.Windows.Forms.MessageBoxButtons.OK,
                                                System.Windows.Forms.MessageBoxIcon.Error,
                                                System.Windows.Forms.MessageBoxDefaultButton.Button1,
                                                System.Windows.Forms.MessageBoxOptions.DefaultDesktopOnly)
        Exit Sub
    End Sub
End Class