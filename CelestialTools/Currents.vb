Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class FormCurrents
    Inherits System.Windows.Forms.Form
    Dim Pi As Double
    Dim TimeFloodMinutes, TimeSlackBeforeFloodMinutes, TimeCount, TimeSlackBeforeEbbMinutes, TimeEbbMinutes As Short
    Dim LocTimeFloodMinutes, LocTimeSlackBeforeFloodMinutes, LocTimeSlackBeforeEbbMinutes, LocTimeEbbMinutes As Short
    Dim LocTimeSlackBeforeEbbHour, LocTimeSlackBeforeFloodHour, DesTimeMinutes, LocTimeSlackBeforeFloodMin, LocTimeSlackBeforeEbbMin As Short
    Dim LocTimeEbbHour, LocTimeFloodHour, LocTimeFloodMin, LocTimeEbbMin As Short
    Dim LocVelFlood, LocVelEbb As Single
    Dim Check3, Check1, CheckCount, Check2, Check4 As Short
    Dim TimeIntSlackMaxMinutes, SelectSlack, SelectMax, TimeIntSlackDesMinutes As Short
    Dim TimeIntSlackDesHour, TimeIntSlackMaxHour, TimeIntSlackMaxMin, TimeIntSlackDesMin As Short
    Dim TimeIntDesEbb, TimeIntDesFlood, i As Short
    Dim Ratio, Factor As Double
    Dim DurationStep As Single
    Dim Drift As Single
    Dim fnumeral As String
    Dim X3Hour, X2Hour, X1Hour, X0Hour, IntMin, X0Min, X1Min, X2Min, X3Min As Short
    Dim SelectMaxHour, SelectSlackHour, SelectSlackMin, SelectMaxMin As Short
    Dim Time2, Time0, Time1, Time3 As String
    Dim FormCurrentsLoaded As Boolean = False
    Dim DTTemp As Date = New Date(1901, 1, 1, 0, 0, 0)


    Private Sub chkE_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkE.CheckStateChanged
        If chkE.CheckState = 1 Then chkF.Enabled = False
        If chkF.CheckState = 0 And chkE.CheckState = 0 Then chkF.Enabled = True : chkE.Enabled = True
        If chkE.CheckState = 0 Then CheckDisable()
    End Sub

    Private Sub chkF_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkF.CheckStateChanged
        If chkF.CheckState = 1 Then chkE.Enabled = False
        If chkF.CheckState = 0 And chkE.CheckState = 0 Then chkF.Enabled = True : chkE.Enabled = True
        If chkF.CheckState = 0 Then CheckDisable()
    End Sub

    Private Sub chkSBE_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkSBE.CheckStateChanged
        If chkSBE.CheckState = 1 Then chkSBF.Enabled = False
        If chkSBF.CheckState = 0 And chkSBE.CheckState = 0 Then chkSBF.Enabled = True : chkSBE.Enabled = True
        If chkSBE.CheckState = 0 Then CheckDisable()
    End Sub

    Private Sub chkSBF_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkSBF.CheckStateChanged
        If chkSBF.CheckState = 1 Then chkSBE.Enabled = False
        If chkSBF.CheckState = 0 And chkSBE.CheckState = 0 Then chkSBF.Enabled = True : chkSBE.Enabled = True
        If chkSBF.CheckState = 0 Then CheckDisable()
    End Sub
    Private Sub CheckDisable()
        If DTTimeSlackBeforeFlood.Value.Hour = 0 And DTTimeSlackBeforeFlood.Value.Minute = 0 Then chkSBF.Enabled = False : chkSBF.CheckState = System.Windows.Forms.CheckState.Unchecked
        If DTTimeFlood.Value.Hour = 0 And DTTimeFlood.Value.Minute = 0 Then chkF.Enabled = False : chkF.CheckState = System.Windows.Forms.CheckState.Unchecked
        If DTTimeSlackBeforeEbb.Value.Hour = 0 And DTTimeSlackBeforeEbb.Value.Minute = 0 Then chkSBE.Enabled = False : chkSBE.CheckState = System.Windows.Forms.CheckState.Unchecked
        If DTTimeEbb.Value.Hour = 0 And DTTimeEbb.Value.Minute = 0 Then chkE.Enabled = False : chkE.CheckState = System.Windows.Forms.CheckState.Unchecked
    End Sub
    Private Sub cmdClear_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClear.Click
        txtLocation.Clear()
        txtLocNo.Clear()
        DTTides.Value = Now
        DTTimeSlackBeforeFlood.Value = DTTemp
        DTTimeFlood.Value = DTTemp
        DTTimeSlackBeforeEbb.Value = DTTemp
        DTTimeEbb.Value = DTTemp
        'txtDesTime.Clear()
        'cboDay.SelectedIndex = -1
        'cboMonth.SelectedIndex = -1
        'txtYear.Clear()
        txtRefSta.Clear()
        'txtTimeSlackBeforeFlood.Clear()
        'txtTimeFlood.Clear()
        txtVelFlood.Clear()
        'txtTimeSlackBeforeEbb.Clear()
        'txtTimeEbb.Clear()
        txtVelEbb.Clear()
        txtTab2SlackFHour.Clear()
        txtTab2SlackFMin.Clear()
        txtTab2SlackEHour.Clear()
        txtTab2SlackEMin.Clear()
        txtTab2FloodHour.Clear()
        txtTab2FloodMin.Clear()
        txtTab2FloodMult.Clear()
        txtTab2EbbHour.Clear()
        txtTab2EbbMin.Clear()
        txtTab2EbbMult.Clear()
        txtSubStaNo.Clear()
        txtSetFlood.Clear()
        txtSetEbb.Clear()
        chkSBF.CheckState = System.Windows.Forms.CheckState.Unchecked
        chkF.CheckState = System.Windows.Forms.CheckState.Unchecked
        chkSBE.CheckState = System.Windows.Forms.CheckState.Unchecked
        chkE.CheckState = System.Windows.Forms.CheckState.Unchecked
        ClearRptTextBox()

    End Sub
    Public Sub ClearRptTextBox()
        Curr1Txtbx.Clear()
        Curr2TxtBx.Clear()
        Curr3TxtBx.Clear()
        Curr4TxtBx.Clear()
        Curr5TxtBx.Clear()
        Curr6TxtBx.Clear()
        Curr7TxtBx.Clear()
        Curr8TxtBx.Clear()
        Curr10TxtBx.Clear()
        Curr11TxtBx.Clear()
        Curr12TxtBx.Clear()
        Curr13TxtBx.Clear()
        Curr14TxtBx.Clear()
        Curr15TxtBx.Clear()
        Curr16TxtBx.Clear()
        Curr17TxtBx.Clear()
        Curr18TxtBx.Clear()
        Curr19TxtBx.Clear()
        Curr20TxtBx.Clear()
        Exit Sub
    End Sub

    Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
        PrintScreen(Me.Bounds)
    End Sub

    Private Sub cmdCurrents_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCurrents.Click
        If Not FormCurrentsLoaded Then Exit Sub
        Pi = 4 * System.Math.Atan(1.0#)
        chkSBF.Enabled = False
        chkSBE.Enabled = False
        chkF.Enabled = False
        chkE.Enabled = False
        chkSBF.CheckState = System.Windows.Forms.CheckState.Unchecked
        chkSBE.CheckState = System.Windows.Forms.CheckState.Unchecked
        chkF.CheckState = System.Windows.Forms.CheckState.Unchecked
        chkE.CheckState = System.Windows.Forms.CheckState.Unchecked
        'CheckDate
        TimeCount = 0
        'If txtDesTime.Text = "" Then
        '    ErrorMsgBox("You must enter a Desired Time.")
        '    txtDesTime.Focus()
        '    Exit Sub
        'End If

        If DTTimeSlackBeforeFlood.Value.Hour <> 0 Or DTTimeSlackBeforeFlood.Value.Minute <> 0 Then
            TimeCount = TimeCount + 1 ' ErrorMsgBox ("You must enter a time of high tide."): txtTimeHigh.SetFocus: Exit Sub
        End If
        If DTTimeFlood.Value.Hour <> 0 Or DTTimeFlood.Value.Minute <> 0 Then
            TimeCount = TimeCount + 1 ' ErrorMsgBox ("You must enter a time of low tide."): txtTimeLow.SetFocus: Exit Sub
        End If
        If DTTimeSlackBeforeEbb.Value.Hour <> 0 Or DTTimeSlackBeforeEbb.Value.Minute <> 0 Then
            TimeCount = TimeCount + 1 ' ErrorMsgBox ("You must enter a time of high tide."): txtTimeHigh.SetFocus: Exit Sub
        End If
        If DTTimeEbb.Value.Hour <> 0 Or DTTimeEbb.Value.Minute <> 0 Then
            TimeCount = TimeCount + 1 ' ErrorMsgBox ("You must enter a time of low tide."): txtTimeLow.SetFocus: Exit Sub
        End If
        If TimeCount < 2 Then
            ErrorMsgBox("You must have at least one slack time and at least one flood or ebb time entered.")
            Exit Sub
        End If

        'If txtVelFlood = "" Then  ErrorMsgBox ("Max. Flood Velocity cannot be blank or zero."): Exit Sub
        'If txtVelEbb = "" Then  ErrorMsgBox ("Max. Ebb Velocity cannot be blank or zero."): Exit Sub
        If txtVelFlood.Text = "" And txtVelEbb.Text = "" Then
            ErrorMsgBox("At least one of the Flood or Ebb Velocities must be greater than zero.")
            Exit Sub
        End If
        If txtTab2SlackFHour.Text = "-" Then txtTab2SlackFHour.Text = "-0"
        If txtTab2SlackFHour.Text = "" Then txtTab2SlackFHour.Text = "+0"
        If txtTab2SlackFMin.Text = "" Then txtTab2SlackFHour.Text = "0"
        If txtTab2FloodHour.Text = "-" Then txtTab2FloodHour.Text = "-0"
        If txtTab2FloodHour.Text = "" Then txtTab2FloodHour.Text = "+0"
        If txtTab2FloodMin.Text = "" Then txtTab2FloodHour.Text = "0"
        If txtTab2FloodMult.Text = "" Then txtTab2FloodMult.Text = "1"
        If txtTab2SlackEHour.Text = "-" Then txtTab2SlackEHour.Text = "-0"
        If txtTab2SlackEHour.Text = "" Then txtTab2SlackEHour.Text = "+0"
        If txtTab2SlackEMin.Text = "" Then txtTab2SlackEHour.Text = "0"
        If txtTab2EbbHour.Text = "-" Then txtTab2EbbHour.Text = "-0"
        If txtTab2EbbHour.Text = "" Then txtTab2EbbHour.Text = "+0"
        If txtTab2EbbMin.Text = "" Then txtTab2EbbHour.Text = "0"
        If txtTab2EbbMult.Text = "" Then txtTab2EbbMult.Text = "1"

        TimeSlackBeforeFloodMinutes = 60 * DTTimeSlackBeforeFlood.Value.Hour + DTTimeSlackBeforeFlood.Value.Minute
        TimeSlackBeforeEbbMinutes = 60 * DTTimeSlackBeforeEbb.Value.Hour + DTTimeSlackBeforeEbb.Value.Minute
        TimeFloodMinutes = 60 * DTTimeFlood.Value.Hour + DTTimeFlood.Value.Minute
        TimeEbbMinutes = 60 * DTTimeEbb.Value.Hour + DTTimeEbb.Value.Minute
        'If Abs(TimeHighMinutes - TimeLowMinutes) > 720 Then
        '    If TimeHighMinutes < TimeLowMinutes Then TimeHighMinutes = TimeHighMinutes + 1440
        '    If TimeLowMinutes < TimeHighMinutes Then TimeLowMinutes = TimeLowMinutes + 1440
        'End If

        LocTimeSlackBeforeFloodMinutes = TimeSlackBeforeFloodMinutes + (60 * System.Math.Abs(Val(txtTab2SlackFHour.Text)) + Val(txtTab2SlackFMin.Text))

        If VB.Left(txtTab2SlackFHour.Text, 1) = "-" Then
            LocTimeSlackBeforeFloodMinutes = (60 * DTTimeSlackBeforeFlood.Value.Hour + DTTimeSlackBeforeFlood.Value.Minute) - (60 * Val(CStr(System.Math.Abs(CDbl(txtTab2SlackFHour.Text)))) + Val(txtTab2SlackFMin.Text))
        End If
        If LocTimeSlackBeforeFloodMinutes >= 1440 Then
            LocTimeSlackBeforeFloodMinutes = LocTimeSlackBeforeFloodMinutes - 1440
        End If
        If LocTimeSlackBeforeFloodMinutes < 0 Then
            LocTimeSlackBeforeFloodMinutes = LocTimeSlackBeforeFloodMinutes + 1440
        End If

        LocTimeSlackBeforeEbbMinutes = TimeSlackBeforeEbbMinutes + (60 * System.Math.Abs(Val(txtTab2SlackEHour.Text)) + Val(txtTab2SlackEMin.Text))

        If VB.Left(txtTab2SlackEHour.Text, 1) = "-" Then
            LocTimeSlackBeforeEbbMinutes = (60 * DTTimeSlackBeforeEbb.Value.Hour + DTTimeSlackBeforeEbb.Value.Minute) - (60 * Val(CStr(System.Math.Abs(CDbl(txtTab2SlackEHour.Text)))) + Val(txtTab2SlackEMin.Text))
        End If
        If LocTimeSlackBeforeEbbMinutes >= 1440 Then
            LocTimeSlackBeforeEbbMinutes = LocTimeSlackBeforeEbbMinutes - 1440
        End If
        If LocTimeSlackBeforeEbbMinutes < 0 Then
            LocTimeSlackBeforeEbbMinutes = LocTimeSlackBeforeEbbMinutes + 1440
        End If

        LocTimeFloodMinutes = TimeFloodMinutes + (60 * System.Math.Abs(Val(txtTab2FloodHour.Text)) + Val(txtTab2FloodMin.Text))

        If VB.Left(txtTab2FloodHour.Text, 1) = "-" Then
            LocTimeFloodMinutes = (60 * DTTimeFlood.Value.Hour + DTTimeFlood.Value.Minute) - (60 * Val(CStr(System.Math.Abs(CDbl(txtTab2FloodHour.Text)))) + Val(txtTab2FloodMin.Text))
        End If
        If LocTimeFloodMinutes >= 1440 Then
            LocTimeFloodMinutes = LocTimeFloodMinutes - 1440
        End If
        If LocTimeFloodMinutes < 0 Then
            LocTimeFloodMinutes = LocTimeFloodMinutes + 1440
        End If

        LocTimeEbbMinutes = TimeEbbMinutes + (60 * System.Math.Abs(Val(txtTab2EbbHour.Text)) + Val(txtTab2EbbMin.Text))

        If VB.Left(txtTab2EbbHour.Text, 1) = "-" Then
            LocTimeEbbMinutes = (60 * DTTimeEbb.Value.Hour + DTTimeEbb.Value.Minute) - (60 * Val(CStr(System.Math.Abs(CDbl(txtTab2EbbHour.Text)))) + Val(txtTab2EbbMin.Text))
        End If
        If LocTimeEbbMinutes >= 1440 Then
            LocTimeEbbMinutes = LocTimeEbbMinutes - 1440
        End If
        If LocTimeEbbMinutes < 0 Then
            LocTimeEbbMinutes = LocTimeEbbMinutes + 1440
        End If

        DesTimeMinutes = (60 * DTTides.Value.Day) + DTTides.Value.Minute

        LocTimeSlackBeforeFloodHour = Int(LocTimeSlackBeforeFloodMinutes / 60)
        LocTimeSlackBeforeFloodMin = Int(LocTimeSlackBeforeFloodMinutes - CInt(LocTimeSlackBeforeFloodHour) * 60)
        LocTimeSlackBeforeEbbHour = Int(LocTimeSlackBeforeEbbMinutes / 60)
        LocTimeSlackBeforeEbbMin = Int(LocTimeSlackBeforeEbbMinutes - CInt(LocTimeSlackBeforeEbbHour) * 60)
        LocTimeFloodHour = Int(LocTimeFloodMinutes / 60)
        LocTimeFloodMin = Int(LocTimeFloodMinutes - CInt(LocTimeFloodHour) * 60)
        LocTimeEbbHour = Int(LocTimeEbbMinutes / 60)
        LocTimeEbbMin = Int(LocTimeEbbMinutes - CInt(LocTimeEbbHour) * 60)

        LocVelFlood = Val(txtVelFlood.Text) * Val(txtTab2FloodMult.Text)

        If optRule.Checked = True Then
            LocVelFlood = Int(LocVelFlood * 10 + 0.5) / 10
        Else
            LocVelFlood = Int(LocVelFlood * 100 + 0.5) / 100
        End If

        LocVelEbb = Val(txtVelEbb.Text) * Val(txtTab2EbbMult.Text)

        If optRule.Checked = True Then
            LocVelEbb = Int(LocVelEbb * 10 + 0.5) / 10
        Else
            LocVelEbb = Int(LocVelEbb * 100 + 0.5) / 100
        End If

        chkSBF.Visible = True : chkF.Visible = True : chkSBE.Visible = True : chkE.Visible = True


        If LocTimeSlackBeforeFloodHour >= 24 Then LocTimeSlackBeforeFloodHour = LocTimeSlackBeforeFloodHour - 24
        If LocTimeSlackBeforeEbbHour >= 24 Then LocTimeSlackBeforeEbbHour = LocTimeSlackBeforeEbbHour - 24
        If LocTimeFloodHour >= 24 Then LocTimeFloodHour = LocTimeFloodHour - 24
        If LocTimeEbbHour >= 24 Then LocTimeEbbHour = LocTimeEbbHour - 24

        ClearRptTextBox()
        DisplayLocalizedData()

        CheckCount = 0
        If DTTimeSlackBeforeFlood.Value.Hour <> 0 Or DTTimeSlackBeforeFlood.Value.Minute <> 0 Then chkSBF.Enabled = True : CheckCount = CheckCount + 1
        If DTTimeFlood.Value.Hour <> 0 Or DTTimeFlood.Value.Minute <> 0 Then chkF.Enabled = True : CheckCount = CheckCount + 1
        If DTTimeSlackBeforeEbb.Value.Hour <> 0 Or DTTimeSlackBeforeEbb.Value.Minute <> 0 Then chkSBE.Enabled = True : CheckCount = CheckCount + 1
        If DTTimeEbb.Value.Hour <> 0 Or DTTimeEbb.Value.Minute <> 0 Then chkE.Enabled = True : CheckCount = CheckCount + 1
        'If txtTimeSlackBeforeFlood.Text <> "" Then chkSBF.Enabled = True : CheckCount = CheckCount + 1
        'If txtTimeFlood.Text <> "" Then chkF.Enabled = True : CheckCount = CheckCount + 1
        'If txtTimeSlackBeforeEbb.Text <> "" Then chkSBE.Enabled = True : CheckCount = CheckCount + 1
        'If txtTimeEbb.Text <> "" Then chkE.Enabled = True : CheckCount = CheckCount + 1

        If CheckCount = 2 Then
            If chkSBF.Enabled = True Then chkSBF.CheckState = System.Windows.Forms.CheckState.Checked
            If chkF.Enabled = True Then chkF.CheckState = System.Windows.Forms.CheckState.Checked
            If chkSBE.Enabled = True Then chkSBE.CheckState = System.Windows.Forms.CheckState.Checked
            If chkE.Enabled = True Then chkE.CheckState = System.Windows.Forms.CheckState.Checked
        End If


        'CONTINUE

        CheckCount = 0
        Check1 = 1 : Check2 = 1 : Check3 = 1 : Check4 = 1
        Do While CheckCount < 2
            System.Windows.Forms.Application.DoEvents()
            If chkSBF.CheckState = 1 And Check1 = 1 Then CheckCount = CheckCount + 1 : Check1 = 0
            If chkSBE.CheckState = 1 And Check2 = 1 Then CheckCount = CheckCount + 1 : Check2 = 0
            If chkF.CheckState = 1 And Check3 = 1 Then CheckCount = CheckCount + 1 : Check3 = 0
            If chkE.CheckState = 1 And Check4 = 1 Then CheckCount = CheckCount + 1 : Check4 = 0
        Loop

        If chkSBF.CheckState = 1 Then SelectSlack = LocTimeSlackBeforeFloodMinutes
        If chkSBE.CheckState = 1 Then SelectSlack = LocTimeSlackBeforeEbbMinutes
        If chkF.CheckState = 1 Then SelectMax = LocTimeFloodMinutes
        If chkE.CheckState = 1 Then SelectMax = LocTimeEbbMinutes

        If (chkSBF.CheckState = 1 Or chkSBE.CheckState = 1) And DesTimeMinutes = SelectSlack Then ErrorMsgBox("Check the data.  Desired Time must be between Localized Time of selected Flood and Localized Time of selected Maximum.") : Exit Sub
        If (chkF.CheckState = 1 Or chkE.CheckState = 1) And DesTimeMinutes = SelectMax Then ErrorMsgBox("Check the data.  Desired Time must be between Localized Time of selected Flood and Localized Time of selected Maximum.") : Exit Sub

        TimeIntSlackMaxMinutes = System.Math.Abs(SelectSlack - SelectMax) : If TimeIntSlackMaxMinutes > 720 Then TimeIntSlackMaxMinutes = System.Math.Abs(TimeIntSlackMaxMinutes - 1440)
        TimeIntSlackDesMinutes = System.Math.Abs(SelectSlack - DesTimeMinutes) : If TimeIntSlackDesMinutes > 720 Then TimeIntSlackDesMinutes = System.Math.Abs(TimeIntSlackDesMinutes - 1440)
        TimeIntSlackMaxHour = Int(TimeIntSlackMaxMinutes / 60)
        TimeIntSlackMaxMin = Int(TimeIntSlackMaxMinutes - CInt(TimeIntSlackMaxHour) * 60)
        TimeIntSlackDesHour = Int(TimeIntSlackDesMinutes / 60)
        TimeIntSlackDesMin = Int(TimeIntSlackDesMinutes - CInt(TimeIntSlackDesHour) * 60)

        TimeIntDesFlood = System.Math.Abs(DesTimeMinutes - LocTimeFloodMinutes)
        TimeIntDesEbb = System.Math.Abs(DesTimeMinutes - LocTimeEbbMinutes)

        If optA.Checked = True Or optB.Checked = True Then
            If TimeIntSlackMaxMin <= 9 Then TimeIntSlackMaxMinutes = 60 * TimeIntSlackMaxHour
            If TimeIntSlackMaxMin > 9 And TimeIntSlackMaxMin <= 29 Then TimeIntSlackMaxMinutes = 60 * TimeIntSlackMaxHour + 20
            If TimeIntSlackMaxMin > 29 And TimeIntSlackMaxMin <= 49 Then TimeIntSlackMaxMinutes = 60 * TimeIntSlackMaxHour + 40
            If TimeIntSlackMaxMin > 49 Then TimeIntSlackMaxMinutes = 60 * TimeIntSlackMaxHour + 60
            If TimeIntSlackDesMin <= 9 Then TimeIntSlackDesMinutes = 60 * TimeIntSlackDesHour
            If TimeIntSlackDesMin > 9 And TimeIntSlackDesMin <= 29 Then TimeIntSlackDesMinutes = 60 * TimeIntSlackDesHour + 20
            If TimeIntSlackDesMin > 29 And TimeIntSlackDesMin <= 49 Then TimeIntSlackDesMinutes = 60 * TimeIntSlackDesHour + 40
            If TimeIntSlackDesMin > 49 Then TimeIntSlackDesMinutes = 60 * TimeIntSlackDesHour + 60
        End If

        Ratio = TimeIntSlackDesMinutes / TimeIntSlackMaxMinutes
        If optCalc.Checked = True Or optA.Checked = True Or optB.Checked = True Then Factor = System.Math.Sin(Pi / 2 * Ratio)
        If optCalc.Checked = True Or optA.Checked = True Or optB.Checked = True Then Factor = Int(Factor * 10 + 0.5) / 10


        If optB.Checked = True Then
            Select Case Ratio
                Case Is <= 0.087
                    Factor = 0.2
                Case Is < 0.149
                    Factor = 0.3
                Case Is < 0.208
                    Factor = 0.4
                Case Is < 0.29
                    Factor = 0.5
                Case Is < 0.366
                    Factor = 0.6
                Case Is < 0.486
                    Factor = 0.7
                Case Is < 0.594
                    Factor = 0.8
                Case Is < 0.767
                    Factor = 0.9
                Case Else
                    Factor = 1
            End Select
            If TimeIntSlackDesMinutes = 60 And TimeIntSlackMaxMinutes = 100 Then Factor = 0.8 'This is an exception for Ratio + 0.6
        End If


        '50-90 Rule
        Static x(6) As Single
        Static Diff(6) As Single
        Static y(6) As Single
        If optRule.Checked = True Then
            DurationStep = TimeIntSlackMaxMinutes / 3
            DurationStep = Int(DurationStep + 0.5)
            If SelectSlack <= SelectMax Then x(0) = SelectSlack Else x(0) = SelectMax
            If SelectSlack <= SelectMax Then y(0) = SelectSlack Else y(0) = SelectMax
            Diff(0) = System.Math.Abs(x(0) - DesTimeMinutes)
            'This section determines the Time#1-4 values for display
            For i = 1 To 3
                y(i) = y(i - 1) + DurationStep
                Diff(i) = System.Math.Abs(y(i) - DesTimeMinutes)
            Next i
            'This section determines which Time# to use for the calculation
            For i = 1 To 3
                x(i) = x(i - 1) + DurationStep
                Diff(i) = System.Math.Abs(x(i) - DesTimeMinutes)
                If Diff(i) > Diff(i - 1) Then Exit For
            Next i
            i = i - 1
            'TimeDiff = Int(TimeDiff / 60 + 0.5)
            If i = 0 And SelectSlack <= SelectMax Then Factor = 0
            If i = 1 And SelectSlack <= SelectMax Then Factor = 0.5
            If i = 2 And SelectSlack <= SelectMax Then Factor = 0.9
            If i = 3 And SelectSlack <= SelectMax Then Factor = 1
            If i = 0 And SelectSlack > SelectMax Then Factor = 1
            If i = 1 And SelectSlack > SelectMax Then Factor = 0.9
            If i = 2 And SelectSlack > SelectMax Then Factor = 0.5
            If i = 3 And SelectSlack > SelectMax Then Factor = 0
            'Range = Int(Range + 0.5)
            'Correction = Range * Factor
            X0Hour = Int(y(0) / 60)
            X0Min = Int(y(0) - CInt(X0Hour) * 60)
            If X0Min >= 60 Then X0Min = X0Min - 60 : X0Hour = X0Hour + 1
            X1Hour = Int(y(1) / 60)
            X1Min = Int(y(1) - CInt(X1Hour) * 60)
            If X1Min >= 60 Then X1Min = X1Min - 60 : X1Hour = X1Hour + 1
            X2Hour = Int(y(2) / 60)
            X2Min = Int(y(2) - CInt(X2Hour) * 60)
            If X2Min >= 60 Then X2Min = X2Min - 60 : X2Hour = X2Hour + 1
            'Next two lines added so Time3 is a result of Time2+TimeDiff, rather than the later of the bracketed times
            X3Hour = Int(y(3) / 60)
            X3Min = Int(y(3) - CInt(X3Hour) * 60)
            If X3Min >= 60 Then X3Min = X3Min - 60 : X3Hour = X3Hour + 1
            Time0 = Strings.Format(X0Hour, "00") & Strings.Format(X0Min, "00")
            Time1 = Strings.Format(X1Hour, "00") & Strings.Format(X1Min, "00")
            Time2 = Strings.Format(X2Hour, "00") & Strings.Format(X2Min, "00")
            'These line changed so Time3 is a result of Time2+TimeDiff, rather than the later of the bracketed times
            '        SelectSlackHour = Int(SelectSlack / 60)
            '        SelectSlackMin = Int((SelectSlack - CLng(SelectSlackHour) * 60))
            '        SelectMaxHour = Int(SelectMax / 60)
            '        SelectMaxMin = Int((SelectMax - CLng(SelectMaxHour) * 60))
            '        If SelectSlack <= SelectMax Then Time3 = Strings.format(SelectMaxHour, "00") & Strings.format(SelectMaxMin, "00")   'Str$(SelectMaxHour) & Str$(SelectMaxMin)
            '        If SelectSlack > SelectMax Then Time3 = Strings.format(SelectSlackHour, "00") & Strings.format(SelectSlackMin, "00")                                                          'Str$(SelectSlackHour) & Str$(SelectSlackMin)
            Time3 = Strings.Format(X3Hour, "00") & Strings.Format(X3Min, "00")
        End If


        'Factor = Int(Factor * 10 + 0.5) / 10

        'If TimeIntDesFlood <= TimeIntDesEbb Then Drift = LocVelFlood * Factor
        'If TimeIntDesFlood > TimeIntDesEbb Then Drift = LocVelEbb * Factor
        If chkF.CheckState = 1 Then Drift = LocVelFlood * Factor
        If chkE.CheckState = 1 Then Drift = LocVelEbb * Factor




        ClearRptTextBox()
        DisplayLocalizedData()

        SetTxtBxBoldOn(Curr8TxtBx)

        If optA.Checked = True Or optB.Checked = True Then
            Curr8TxtBx.AppendText("  Entering Arguments for Table 3 (from Localized Data):")
        End If

        If optCalc.Checked = True Then
            Curr8TxtBx.AppendText("  Entering Arguments for Calculation:")
        End If

        If optRule.Checked = True Then
            Curr8TxtBx.AppendText("  Entering Arguments for 50-90 Rule:")
        End If
        SetTxtBxtoReg(Curr8TxtBx)
        Curr10TxtBx.AppendText(vbNewLine)
        Curr8TxtBx.AppendText("     Time Interval Between Selected Slack & Max.  " & vbNewLine)

        Curr10TxtBx.AppendText(CStr(TimeIntSlackMaxHour) & " h " & Strings.Format(TimeIntSlackMaxMin, "00") & " m" & " (" & Strings.Format(TimeIntSlackMaxMinutes, "#") & " m)" & vbNewLine)

        If optRule.Checked = False Then

            Curr8TxtBx.AppendText("     Time Interval Between Selected Slack & Desired Time  ")

            Curr10TxtBx.AppendText(CStr(TimeIntSlackDesHour) & " h " & Strings.Format(TimeIntSlackDesMin, "00") & " m")
        End If
        If optRule.Checked = True Then

            Curr8TxtBx.AppendText("     Time Interval Between Selected Slack & Max./3")

            Curr10TxtBx.AppendText(CStr(DurationStep) & "m")
        End If

        If optRule.Checked = True Then Curr8TxtBx.AppendText(vbNewLine & "     Time#1-4  " & Time0 & Space(1) & Time1 & Space(1) & Time2 & Space(1) & Time3 & Space(1))

        Curr11TxtBx.AppendText("Velocity Factor from ")

        If optA.Checked = True Or optB.Checked = True Then
            Curr11TxtBx.AppendText("Table 3")
        End If

        If optCalc.Checked = True Then
            Curr11TxtBx.AppendText("calculation")
        End If

        If optRule.Checked = True Then
            Curr11TxtBx.AppendText("50-90 Rule (as percent change)")
        End If

        If optRule.Checked = False Then
            Curr12TxtBx.AppendText(Strings.Format(Factor, "0.0"))
        End If

        If optRule.Checked = True Then
            Curr12TxtBx.AppendText(CStr(Factor * 100) & "%")
        End If

        SetTxtBxBoldOn(Curr13TxtBx)

        If optA.Checked = True Or optB.Checked = True Then
            Curr13TxtBx.AppendText("  Application of Table 3 Factor:")
        End If

        If optCalc.Checked = True Then
            Curr13TxtBx.AppendText("  Application of Calculated Factor:")
        End If

        If optRule.Checked = True Then
            Curr13TxtBx.AppendText("  Application of 50-90 Rule Factor:")
        End If
        SetTxtBxtoReg(Curr13TxtBx)
        Curr13TxtBx.AppendText(vbNewLine)

        Curr13TxtBx.AppendText("     Max. Velocity at Local (Table 2) Substation: ")
        'If TimeIntDesFlood <= TimeIntDesEbb Then FormCurrents.Font.Bold = True
        If chkF.CheckState = 1 Then
            SetTxtBxBoldOn(Curr13TxtBx)
        End If

        Curr13TxtBx.AppendText("Max. F")
        SetTxtBxtoReg(Curr13TxtBx)

        Curr13TxtBx.AppendText(" or ")
        'If TimeIntDesFlood > TimeIntDesEbb Then FormCurrents.Font.Bold = True
        If chkE.CheckState = 1 Then
            SetTxtBxBoldOn(Curr13TxtBx)
        End If
        Curr13TxtBx.AppendText("Max. E")
        SetTxtBxtoReg(Curr13TxtBx)
        Curr13TxtBx.AppendText(vbNewLine)

        'Print " whichever is closer in time";
        'If TimeIntDesFlood <= TimeIntDesEbb Then Print Tab(131); LocVelFlood; " kn"
        'If TimeIntDesFlood > TimeIntDesEbb Then Print Tab(131); LocVelEbb; " kn"
        If chkF.CheckState = 1 Then
            If optRule.Checked = False Then
                Curr14TxtBx.AppendText(Strings.Format(LocVelFlood, "0.00") & " kn")
            End If
            If optRule.Checked = True Then
                Curr14TxtBx.AppendText(Strings.Format(LocVelFlood, "0.0") & " kn")
            End If
            Curr14TxtBx.AppendText(vbNewLine)
        End If
        If chkE.CheckState = 1 Then
            If optRule.Checked = False Then
                Curr13TxtBx.AppendText(Strings.Format(LocVelEbb, "0.00") & " kn")
            End If
            If optRule.Checked = True Then
                Curr13TxtBx.AppendText(Strings.Format(LocVelEbb, "0.0") & " kn")
            End If
            Curr14TxtBx.AppendText(vbNewLine)
        End If
        If optCalc.Checked = False And optRule.Checked = False Then
            Curr13TxtBx.AppendText("     Table 3 Velocity Factor:")
        End If

        If optCalc.Checked = True Then Curr13TxtBx.AppendText("     Calculated Velocity Factor:")

        If optRule.Checked = True Then Curr13TxtBx.AppendText("     50-90 Rule Velocity Factor:")

        Curr13TxtBx.SelectionAlignment = HorizontalAlignment.Center
        Curr13TxtBx.AppendText("(Multiply)")
        Curr13TxtBx.SelectionAlignment = HorizontalAlignment.Left

        Curr14TxtBx.AppendText("x " & Strings.Format(Strings.Format(Factor, "0.0")))


        Curr15TxtBx.AppendText("  Predicted Tidal Current Velocity at Desired Time at Local (Table 2) Substation")
        Curr16TxtBx.AppendText("Drift = ")
        Curr17TxtBx.AppendText(Strings.Format(Drift, "0.0") & " kn")


        Curr18TxtBx.AppendText(" DIRECTION")
        Curr18TxtBx.SelectionAlignment = HorizontalAlignment.Center
        Curr18TxtBx.AppendText("Direction of Tidal Current (")
        If chkF.CheckState = 1 Then
            SetTxtBxBoldOn(Curr18TxtBx)
        End If

        Curr18TxtBx.AppendText("F")
        SetTxtBxtoReg(Curr18TxtBx)

        Curr18TxtBx.AppendText(" or ")
        If chkE.CheckState = 1 Then
            SetTxtBxBoldOn(Curr18TxtBx)
        End If

        Curr18TxtBx.AppendText(g_LongE)
        SetTxtBxtoReg(Curr18TxtBx)

        Curr18TxtBx.AppendText(") Desired")


        Curr18TxtBx.AppendText(" from Table 2")
        Curr18TxtBx.SelectionAlignment = HorizontalAlignment.Center
        Curr18TxtBx.AppendText("Time at Local (Table 2) Substation")
        Curr18TxtBx.SelectionAlignment = HorizontalAlignment.Left
        Curr19TxtBx.AppendText("Set = ")

        If chkF.CheckState = 1 Then Curr20TxtBx.AppendText(Strings.Format(Val(txtSetFlood.Text), "000") & Chr(176))

        If chkE.CheckState = 1 Then Curr20TxtBx.AppendText(Strings.Format(Val(txtSetEbb.Text), "000") & Chr(176))
        Exit Sub
    End Sub
    Public Sub DisplayLocalizedData()

        'DISPLAY LOCALIZED DATA
        Curr1Txtbx.AppendText("  Localized Data:  " & txtTab2Diff.Text)

        If DTTimeSlackBeforeFlood.Value.Hour <> 0 Or DTTimeSlackBeforeFlood.Value.Minute <> 0 Then
            Curr2TxtBx.AppendText(Strings.Format(LocTimeSlackBeforeFloodHour, "00") & Strings.Format(LocTimeSlackBeforeFloodMin, "00"))
        End If
        If DTTimeFlood.Value.Hour <> 0 Or DTTimeFlood.Value.Minute <> 0 Then
            Curr3TxtBx.AppendText(Strings.Format(LocTimeFloodHour, "00") & Strings.Format(LocTimeFloodMin, "00"))

            If optRule.Checked = False Then Curr4TxtBx.AppendText(Strings.Format(LocVelFlood, "0.00") & " kn")

            If optRule.Checked = True Then Curr4TxtBx.AppendText(Strings.Format(LocVelFlood, "0.0") & " kn")
        End If

        If DTTimeSlackBeforeEbb.Value.Hour <> 0 Or DTTimeSlackBeforeEbb.Value.Minute <> 0 Then
            Curr5TxtBx.AppendText(Strings.Format(LocTimeSlackBeforeEbbHour, "00") & Strings.Format(LocTimeSlackBeforeEbbMin, "00"))
        End If

        If DTTimeEbb.Value.Hour <> 0 Or DTTimeEbb.Value.Minute <> 0 Then
            Curr6TxtBx.AppendText(Strings.Format(LocTimeEbbHour, "00") & Strings.Format(LocTimeEbbMin, "00"))
            If optRule.Checked = False Then Curr7TxtBx.AppendText(Strings.Format(LocVelEbb, "0.00") & " kn")
            If optRule.Checked = True Then Curr7TxtBx.AppendText(Strings.Format(LocVelEbb, "0.0") & " kn")
        End If

        Exit Sub
    End Sub
    Private Sub optA_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optA.CheckedChanged
        If eventSender.Checked Then
            cmdCurrents_Click(cmdCurrents, New System.EventArgs())
        End If
    End Sub

    Private Sub optCalc_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optCalc.CheckedChanged
        If eventSender.Checked Then
            cmdCurrents_Click(cmdCurrents, New System.EventArgs())
        End If
    End Sub

    Private Sub optB_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optB.CheckedChanged
        If eventSender.Checked Then
            cmdCurrents_Click(cmdCurrents, New System.EventArgs())
        End If
    End Sub

    Private Sub optRule_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optRule.CheckedChanged
        If eventSender.Checked Then
            cmdCurrents_Click(cmdCurrents, New System.EventArgs())
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

    Private Sub txtSetFlood_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSetFlood.TextChanged
        If Val(txtSetFlood.Text) > 359 Then
            txtSetFlood.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
        If Val(txtSetFlood.Text) < 360 Then
            txtSetFlood.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        End If
    End Sub
    Private Sub txtSetFlood_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtSetFlood.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtSetFlood.Text) > 359 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtSetFlood_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSetFlood.Enter
        SelectAllText(txtSetFlood)
    End Sub

    Private Sub txtSetEbb_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSetEbb.TextChanged
        If Val(txtSetEbb.Text) > 359 Then
            txtSetEbb.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
        If Val(txtSetEbb.Text) < 360 Then
            txtSetEbb.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        End If
    End Sub
    Private Sub txtSetEbb_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtSetEbb.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtSetEbb.Text) > 359 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtSetEbb_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSetEbb.Enter
        SelectAllText(txtSetEbb)
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

    Private Sub txtTab2FloodHour_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTab2FloodHour.TextChanged
        'txtTime.ForeColor = &H80000008
        txtTab2FloodHour.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        'If Len(txtTime.text) = 6 And (Val(Left(txtTime.text, 2)) > 23 Or Val(Mid(txtTime.text, 3, 2)) > 59 Or Val(Mid(txtTime.text, 5, 2)) > 59) Then
        '    txtTime.BackColor = &HFF&
        '     ErrorMsgBox "Out of Range"
        'End If
    End Sub

    Private Sub txtTab2FloodHour_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTab2FloodHour.KeyPress
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
                If txtTab2FloodHour.SelectionStart <> 0 Or bMinusSignAlready Then
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

                If txtTab2FloodHour.SelectionStart <> 0 Or bPlusSignAlready Then
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

    Private Sub txtTab2FloodHour_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtTab2FloodHour.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        'If Val(Left(txtTime.text, 2)) > 23 Or Val(Mid(txtTime.text, 3, 2)) > 59 Or Val(Mid(txtTime.text, 5, 2)) > 59 Or Len(txtTime) <> 6 Then
        '    KeepFocus = True
        'End If
        'If Len(txtTime) = 0 Then
        '    KeepFocus = False
        'End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtTab2FloodHour_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTab2FloodHour.Enter
        SelectAllText(txtTab2FloodHour)
    End Sub

    Private Sub txtTab2FloodMin_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTab2FloodMin.TextChanged
        'txtTime.ForeColor = &H80000008
        txtTab2FloodMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Len(txtTab2FloodMin.Text) = 2 And Val(txtTab2FloodMin.Text) > 59 Then
            txtTab2FloodMin.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
    End Sub

    Private Sub txtTab2FloodMin_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTab2FloodMin.KeyPress
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

    Private Sub txtTab2FloodMin_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtTab2FloodMin.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtTab2FloodMin.Text) > 59 Then
            KeepFocus = True
        End If
        'If Len(txtTime) = 0 Then
        '    KeepFocus = False
        'End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtTab2FloodMin_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTab2FloodMin.Enter
        SelectAllText(txtTab2FloodMin)
    End Sub

    Private Sub txtTab2EbbHour_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTab2EbbHour.TextChanged
        'txtTime.ForeColor = &H80000008
        txtTab2EbbHour.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        'If Len(txtTime.text) = 6 And (Val(Left(txtTime.text, 2)) > 23 Or Val(Mid(txtTime.text, 3, 2)) > 59 Or Val(Mid(txtTime.text, 5, 2)) > 59) Then
        '    txtTime.BackColor = &HFF&
        '     ErrorMsgBox "Out of Range"
        'End If
    End Sub

    Private Sub txtTab2EbbHour_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTab2EbbHour.KeyPress
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
                If txtTab2EbbHour.SelectionStart <> 0 Or bMinusSignAlready Then
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

                If txtTab2EbbHour.SelectionStart <> 0 Or bPlusSignAlready Then
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

    Private Sub txtTab2EbbHour_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtTab2EbbHour.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        'If Val(Left(txtTime.text, 2)) > 23 Or Val(Mid(txtTime.text, 3, 2)) > 59 Or Val(Mid(txtTime.text, 5, 2)) > 59 Or Len(txtTime) <> 6 Then
        '    KeepFocus = True
        'End If
        'If Len(txtTime) = 0 Then
        '    KeepFocus = False
        'End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtTab2EbbHour_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTab2EbbHour.Enter
        SelectAllText(txtTab2EbbHour)
    End Sub

    Private Sub txtTab2EbbMin_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTab2EbbMin.TextChanged
        'txtTime.ForeColor = &H80000008
        txtTab2EbbMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Len(txtTab2EbbMin.Text) = 2 And Val(txtTab2EbbMin.Text) > 59 Then
            txtTab2EbbMin.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
    End Sub

    Private Sub txtTab2EbbMin_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTab2EbbMin.KeyPress
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

    Private Sub txtTab2EbbMin_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtTab2EbbMin.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtTab2EbbMin.Text) > 59 Then
            KeepFocus = True
        End If
        'If Len(txtTab2LowMins) = 0 Then
        '    KeepFocus = False
        'End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtTab2EbbMin_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTab2EbbMin.Enter
        SelectAllText(txtTab2EbbMin)
    End Sub

    Private Sub txtTab2SlackFHour_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTab2SlackFHour.KeyPress
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
                If txtTab2SlackFHour.SelectionStart <> 0 Or bMinusSignAlready Then
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

                If txtTab2SlackFHour.SelectionStart <> 0 Or bPlusSignAlready Then
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

    Private Sub txtTab2SlackFHour_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtTab2SlackFHour.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        'If Val(Left(txtTime.text, 2)) > 23 Or Val(Mid(txtTime.text, 3, 2)) > 59 Or Val(Mid(txtTime.text, 5, 2)) > 59 Or Len(txtTime) <> 6 Then
        '    KeepFocus = True
        'End If
        'If Len(txtTime) = 0 Then
        '    KeepFocus = False
        'End If
        eventArgs.Cancel = KeepFocus
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
        Exit Sub
    End Sub

    Private Sub txtTab2SlackFHour_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTab2SlackFHour.Enter
        SelectAllText(txtTab2SlackFHour)
    End Sub

    'UPGRADE_WARNING: Event txtTab2SlackFMin.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtTab2SlackFMin_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTab2SlackFMin.TextChanged
        'txtTime.ForeColor = &H80000008
        txtTab2SlackFMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Len(txtTab2SlackFMin.Text) = 2 And Val(txtTab2SlackFMin.Text) > 59 Then
            txtTab2SlackFMin.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
    End Sub

    Private Sub txtTab2SlackFMin_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTab2SlackFMin.KeyPress
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

    Private Sub FormCurrents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.Network.IsAvailable Then
            LinkNOAACurrentTides.Visible = True
            LinkNOAACurrentTides.Enabled = True
        Else
            LinkNOAACurrentTides.Visible = False
            LinkNOAACurrentTides.Enabled = False
        End If
        DTTides.Value = Now
        DTTimeSlackBeforeFlood.Value = DTTemp
        DTTimeFlood.Value = DTTemp
        DTTimeSlackBeforeEbb.Value = DTTemp
        DTTimeEbb.Value = DTTemp
        FormCurrentsLoaded = True
    End Sub

    Private Sub txtTab2SlackFMin_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtTab2SlackFMin.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtTab2SlackFMin.Text) > 59 Then
            KeepFocus = True
        End If
        'If Len(txtTab2LowMins) = 0 Then
        '    KeepFocus = False
        'End If
        eventArgs.Cancel = KeepFocus
    End Sub

    Private Sub LinkNOAACurrentTides_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkNOAACurrentTides.LinkClicked
        'Dim URLNOAATideCurr As String = "https://oceanservice.noaa.gov/navigation/tidesandcurrents/"
        Dim URLNOAATideCurr As String = "https://tidesandcurrents.noaa.gov/noaacurrents/Regions"
        System.Diagnostics.Process.Start(URLNOAATideCurr)
    End Sub

    Private Sub txtTab2SlackFMin_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTab2SlackFMin.Enter
        SelectAllText(txtTab2SlackFMin)
    End Sub

    Private Sub txtTab2SlackEHour_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTab2SlackEHour.KeyPress
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
                If txtTab2SlackEHour.SelectionStart <> 0 Or bMinusSignAlready Then
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

                If txtTab2SlackEHour.SelectionStart <> 0 Or bPlusSignAlready Then
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

    Private Sub txtTab2SlackEHour_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtTab2SlackEHour.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        'If Val(Left(txtTime.text, 2)) > 23 Or Val(Mid(txtTime.text, 3, 2)) > 59 Or Val(Mid(txtTime.text, 5, 2)) > 59 Or Len(txtTime) <> 6 Then
        '    KeepFocus = True
        'End If
        'If Len(txtTime) = 0 Then
        '    KeepFocus = False
        'End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtTab2SlackEHour_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTab2SlackEHour.Enter
        SelectAllText(txtTab2SlackEHour)
    End Sub

    Private Sub txtTab2SlackEMin_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTab2SlackEMin.TextChanged
        'txtTime.ForeColor = &H80000008
        txtTab2SlackEMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Len(txtTab2SlackEMin.Text) = 2 And Val(txtTab2SlackEMin.Text) > 59 Then
            txtTab2SlackEMin.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
    End Sub

    Private Sub txtTab2SlackEMin_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTab2SlackEMin.KeyPress
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

    Private Sub txtTab2SlackEMin_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtTab2SlackEMin.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtTab2SlackEMin.Text) > 59 Then
            KeepFocus = True
        End If
        'If Len(txtTab2LowMins) = 0 Then
        '    KeepFocus = False
        'End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtTab2SlackEMin_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTab2SlackEMin.Enter
        SelectAllText(txtTab2SlackEMin)
    End Sub

    Private Sub FormCurrents_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'Cleanup()
    End Sub

    Private Sub txtTab2FloodMult_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTab2FloodMult.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(Chr(8))
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtTab2FloodMult.Text, ".") Then
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

    Private Sub txtFloodMult_Validate(ByRef KeepFocus As Boolean)
        'If Val(Left(txtTime.text, 2)) > 23 Or Val(Mid(txtTime.text, 3, 2)) > 59 Or Val(Mid(txtTime.text, 5, 2)) > 59 Or Len(txtTime) <> 6 Then
        '    KeepFocus = True
        'End If
        'If Len(txtTime) = 0 Then
        '    KeepFocus = False
        'End If
    End Sub
    Private Sub txtTab2FloodMult_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTab2FloodMult.Enter
        SelectAllText(txtTab2FloodMult)
    End Sub

    Private Sub txtTab2EbbMult_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTab2EbbMult.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(Chr(8))
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtTab2EbbMult.Text, ".") Then
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

    Private Sub txtTab2EbbMult_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtTab2EbbMult.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        'If Val(Left(txtTime.text, 2)) > 23 Or Val(Mid(txtTime.text, 3, 2)) > 59 Or Val(Mid(txtTime.text, 5, 2)) > 59 Or Len(txtTime) <> 6 Then
        '    KeepFocus = True
        'End If
        'If Len(txtTime) = 0 Then
        '    KeepFocus = False
        'End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtTab2EbbMult_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTab2EbbMult.Enter
        SelectAllText(txtTab2EbbMult)
    End Sub

    'Private Sub txtTimeEbb_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
    '    'txtTime.ForeColor = &H80000008
    '    txtTimeEbb.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
    '    If Len(txtTimeEbb.Text) = 4 And (Val(VB.Left(txtTimeEbb.Text, 2)) > 23 Or Val(Mid(txtTimeEbb.Text, 3, 2)) > 59) Then
    '        txtTimeEbb.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
    '        ErrorMsgBox("Out of Range")
    '        Exit Sub
    '    End If
    'End Sub
    'Private Sub txtTimeEbb_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
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

    'Private Sub txtTimeEbb_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs)
    '    Dim KeepFocus As Boolean = eventArgs.Cancel
    '    If Val(VB.Left(txtTimeEbb.Text, 2)) > 23 Or Val(Mid(txtTimeEbb.Text, 3, 2)) > 59 Or Len(txtTimeEbb.Text) <> 4 Then
    '        KeepFocus = True
    '    End If
    '    If Len(txtTimeEbb.Text) = 0 Then
    '        KeepFocus = False
    '    End If
    '    eventArgs.Cancel = KeepFocus
    'End Sub
    'Private Sub txtTimeEbb_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
    '    SelectAllText(txtTimeEbb)
    'End Sub

    'Private Sub txtTimeFlood_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
    '    'txtTime.ForeColor = &H80000008
    '    txtTimeFlood.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
    '    If Len(txtTimeFlood.Text) = 4 And (Val(VB.Left(txtTimeFlood.Text, 2)) > 23 Or Val(Mid(txtTimeFlood.Text, 3, 2)) > 59) Then
    '        txtTimeFlood.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
    '        ErrorMsgBox("Out of Range")
    '        Exit Sub
    '    End If
    'End Sub
    'Private Sub txtTimeFlood_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
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

    'Private Sub txtTimeFlood_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs)
    '    Dim KeepFocus As Boolean = eventArgs.Cancel
    '    If Val(VB.Left(txtTimeFlood.Text, 2)) > 23 Or Val(Mid(txtTimeFlood.Text, 3, 2)) > 59 Or Len(txtTimeFlood.Text) <> 4 Then
    '        KeepFocus = True
    '    End If
    '    If Len(txtTimeFlood.Text) = 0 Then
    '        KeepFocus = False
    '    End If
    '    eventArgs.Cancel = KeepFocus
    'End Sub
    'Private Sub txtTimeFlood_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
    '    SelectAllText(txtTimeFlood)
    'End Sub

    'Private Sub txtTimeSlackBeforeEbb_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
    '    'txtTime.ForeColor = &H80000008
    '    txtTimeSlackBeforeEbb.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
    '    If Len(txtTimeSlackBeforeEbb.Text) = 4 And (Val(VB.Left(txtTimeSlackBeforeEbb.Text, 2)) > 23 Or Val(Mid(txtTimeSlackBeforeEbb.Text, 3, 2)) > 59) Then
    '        txtTimeSlackBeforeEbb.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
    '        ErrorMsgBox("Out of Range")
    '        Exit Sub
    '    End If
    'End Sub
    'Private Sub txtTimeSlackBeforeEbb_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
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

    'Private Sub txtTimeSlackBeforeEbb_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs)
    '    Dim KeepFocus As Boolean = eventArgs.Cancel
    '    If Val(VB.Left(txtTimeSlackBeforeEbb.Text, 2)) > 23 Or Val(Mid(txtTimeSlackBeforeEbb.Text, 3, 2)) > 59 Or Len(txtTimeSlackBeforeEbb.Text) <> 4 Then
    '        KeepFocus = True
    '    End If
    '    If Len(txtTimeSlackBeforeEbb.Text) = 0 Then
    '        KeepFocus = False
    '    End If
    '    eventArgs.Cancel = KeepFocus
    'End Sub
    'Private Sub txtTimeSlackBeforeEbb_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
    '    SelectAllText(txtTimeSlackBeforeEbb)
    'End Sub

    'Private Sub txtTimeSlackBeforeFlood_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
    '    'txtTime.ForeColor = &H80000008
    '    txtTimeSlackBeforeFlood.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
    '    If Len(txtTimeSlackBeforeFlood.Text) = 4 And (Val(VB.Left(txtTimeSlackBeforeFlood.Text, 2)) > 23 Or Val(Mid(txtTimeSlackBeforeFlood.Text, 3, 2)) > 59) Then
    '        txtTimeSlackBeforeFlood.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
    '        ErrorMsgBox("Out of Range")
    '        Exit Sub
    '    End If
    'End Sub
    'Private Sub txtTimeSlackBeforeFlood_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
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

    'Private Sub txtTimeSlackBeforeFlood_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs)
    '    Dim KeepFocus As Boolean = eventArgs.Cancel
    '    If Val(VB.Left(txtTimeSlackBeforeFlood.Text, 2)) > 23 Or Val(Mid(txtTimeSlackBeforeFlood.Text, 3, 2)) > 59 Or Len(txtTimeSlackBeforeFlood.Text) <> 4 Then
    '        KeepFocus = True
    '    End If
    '    If Len(txtTimeSlackBeforeFlood.Text) = 0 Then
    '        KeepFocus = False
    '    End If
    '    eventArgs.Cancel = KeepFocus
    'End Sub
    'Private Sub txtTimeSlackBeforeFlood_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
    '    SelectAllText(txtTimeSlackBeforeFlood)
    'End Sub

    Private Sub txtVelEbb_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtVelEbb.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(Chr(8))
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtVelEbb.Text, ".") Then
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
    Private Sub txtVelEbb_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVelEbb.Enter
        SelectAllText(txtVelEbb)
    End Sub

    Private Sub txtVelFlood_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtVelFlood.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(Chr(8))
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtVelFlood.Text, ".") Then
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
    Private Sub txtVelFlood_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVelFlood.Enter
        SelectAllText(txtVelFlood)
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
    ''Private Sub txtYear_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
    ''    SelectAllText(txtYear)
    ''End Sub

    Private Sub SelectAllText(ByRef TB As System.Windows.Forms.TextBox)
        TB.SelectionStart = 0
        TB.SelectionLength = Len(TB.Text)
        '
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