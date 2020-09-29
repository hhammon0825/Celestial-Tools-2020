Option Strict Off
Option Explicit On
Friend Class frmPointsOnRhumb
    Inherits System.Windows.Forms.Form

    Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
        'FormHeight = PixelsToTwipsY(Me.Height)
        'FormWidth = PixelsToTwipsX(Me.Width)
        PrintScreen(Me.Bounds)
    End Sub


    Private Sub cmdCalculate_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCalculate.Click
        Dim ExceedFlag As Boolean
        Dim Course, CourseAngle As Double
        Dim L As Double, Lo As Double
        Dim L1, L2, Lo1, Lo2, Distance As Double
        Dim LoWest, Lo1West, Lo2West As Double
        Dim LDeg As Short
        Dim LoDeg As Short
        Dim Sign As Short
        Dim LMin, LoMin As Double
        Dim DLo, LPoint, LoPoint As Double
        Dim Pi As Double


        ExceedFlag = False  ':LFlag = False: LoFlag = False
        Pi = 4 * System.Math.Atan(1.0#)
        L1 = Val(FormSailings.txtL1Deg.Text) + Val(FormSailings.txtL1Min.Text) / 60
        If FormSailings.cboL1.Text = "S" Then L1 = -L1
        Lo1 = Val(FormSailings.txtLo1Deg.Text) + Val(FormSailings.txtLo1Min.Text) / 60
        Lo1West = Lo1
        If FormSailings.cboLo1.Text = "E" Then Lo1 = -Lo1 : Lo1West = 360 - Lo1West
        '    L2 = Val(FormSailings.txtL2Deg.text) + Val(FormSailings.txtL2Min.text) / 60
        '    If FormSailings.cboL2 = "S" Then L2 = -L2
        '    Lo2 = Val(FormSailings.txtLo2Deg.text) + Val(FormSailings.txtLo2Min.text) / 60
        '    If FormSailings.cboLo2 = "E" Then Lo2 = -Lo2
        '    L1 = FormSailings.L1
        L2 = FormSailings.L2
        '   Lo1 = FormSailings.Lo1
        Lo2 = FormSailings.Lo2
        Lo2West = Lo2
        If Lo2West < 0 Then Lo2West = 360 - System.Math.Abs(Lo2West)
        L = Val(txtLDeg.Text) + Val(txtLMin.Text) / 60
        If cboL.Text = "S" Then L = -L
        Lo = Val(txtLoDeg.Text) + Val(txtLoMin.Text) / 60
        LoWest = Lo
        If cboLo.Text = "E" Then Lo = -Lo : LoWest = 360 - LoWest

        If FormSailings.optCD.Checked = True Or FormSailings.optSD.Checked = True Then CourseAngle = FormSailings.CourseAngle
        If FormSailings.optL2Lo2.Checked = True Then CourseAngle = FormSailings.CourseAngle * Pi / 180

        If txtLDeg.Text <> "" And txtLMin.Text <> "" Then
            If (L1 > L2 And (L > L1 Or L < L2)) Or (L2 > L1 And (L > L2 Or L < L1)) Then ExceedFlag = True  'LFlag = True 'MsgBox "Latitude exceeds limits of rhumb line.": Exit Sub
        End If
        If txtLoDeg.Text <> "" And txtLoMin.Text <> "" Then
            If System.Math.Abs(Lo2 - Lo1) <= 180 Then
                If (Lo1 > Lo2 And (Lo < Lo2 Or Lo > Lo1)) Or (Lo2 > Lo1 And (Lo < Lo1 Or Lo > Lo2)) Then ExceedFlag = True  'LoFlag = True 'MsgBox "Longitude exceeds limits of rhumb line.": Exit Sub
            End If
            If System.Math.Abs(Lo2 - Lo1) > 180 Then
                If (Lo1West > Lo2West And (LoWest > Lo1West Or LoWest < Lo2West)) Or (Lo2West > Lo1West And (LoWest > Lo2West Or LoWest < Lo1West)) Then ExceedFlag = True  'LoFlag = True 'MsgBox "Longitude exceeds limits of rhumb line.": Exit Sub
            End If
        End If
        'If LFlag = True And LoFlag = True Then Cls: MsgBox "Warning:  Latitude and longitude exceed limits of rhumb line route.": ExceedFlag = True ': Cls: Exit Sub
        'If LFlag = True And ExceedFlag = False Then Cls: MsgBox "Warning:  Latitude exceeds limits of rhumb line route." ': Exit Sub
        'If LoFlag = True And ExceedFlag = False Then Cls: MsgBox "Warning:  Longitude exceeds limits of rhumb line route." ': Exit Sub

        'Calculate latitude
        If txtLoDeg.Text <> "" Or txtLoMin.Text <> "" Then

            Sign = 1
            If FormSailings.txtCourse.Text = "" Then Course = FormSailings.Course Else Course = Val(FormSailings.txtCourse.Text)
            If LoWest > Lo1West And Course < 90 Then Sign = -1
            If LoWest < Lo1West And Course >= 90 And Course < 180 Then Sign = -1
            If LoWest > Lo1West And Course >= 180 And Course < 270 Then Sign = -1
            If LoWest < Lo1West And Course >= 270 And Course < 360 Then Sign = -1

            DLo = LoWest - Lo1West
            'Crossing IDL or shorter route
            If System.Math.Abs(DLo) > 180 Then DLo = -System.Math.Sign(DLo) * (360 - System.Math.Abs(DLo)) : Sign = -Sign

            Distance = System.Math.Abs(DLo * System.Math.Cos((L1 + L2) / 2 * Pi / 180) / System.Math.Sin(CourseAngle))
            LPoint = L1 + Sign * Distance * System.Math.Cos(CourseAngle)
            LDeg = Int(System.Math.Abs(LPoint))
            LMin = (System.Math.Abs(LPoint) - LDeg) * 60
            LMin = Int(LMin * 10 + 0.5) / 10
            If Int(LMin * 10 + 0.5) / 10 = 60 Then LMin = 0 : LDeg = LDeg + 1
            LPoint = System.Math.Sign(LPoint) * (LDeg + LMin / 60)
        End If

        'Calculate longitude
        If txtLDeg.Text <> "" Or txtLMin.Text <> "" Then
            Sign = 1
            If FormSailings.txtCourse.Text = "" Then Course = FormSailings.Course Else Course = Val(FormSailings.txtCourse.Text)
            If L > L1 And Course < 90 Then Sign = -1
            If L < L1 And Course >= 90 And Course < 180 Then Sign = -1
            If L > L1 And Course >= 180 And Course < 270 Then Sign = -1
            If L < L1 And Course >= 270 And Course < 360 Then Sign = -1
            Distance = System.Math.Abs((L1 - L) / System.Math.Cos(CourseAngle))
            DLo = Distance * System.Math.Sin(System.Math.Abs(CourseAngle)) / System.Math.Cos((L1 + L2) / 2 * Pi / 180)
            'Crossing IDL
            If System.Math.Abs(DLo) > 180 Then DLo = -System.Math.Sign(DLo) * (360 - System.Math.Abs(DLo))
            LoPoint = Lo1 + Sign * DLo
            If System.Math.Abs(LoPoint) > 180 Then LoPoint = -System.Math.Sign(LoPoint) * (360 - System.Math.Abs(LoPoint))
            LoDeg = Int(System.Math.Abs(LoPoint))
            LoMin = (System.Math.Abs(LoPoint) - LoDeg) * 60
            LoMin = Int(LoMin * 10 + 0.5) / 10
            If Int(LoMin * 10 + 0.5) / 10 = 60 Then LoMin = 0 : LoDeg = LoDeg + 1
            LoPoint = System.Math.Sign(LoPoint) * (LoDeg + LoMin / 60)
        End If
        '

        RhumbPointsTxtBx.Clear()

        RhumbPointsTxtBx.AppendText(Space(15) & "Longitude" & Space(43) & "Latitude" & vbNewLine)
        If txtLDeg.Text <> "" Or txtLMin.Text <> "" Then
            RhumbPointsTxtBx.AppendText(Space(14) & Strings.Format(LoDeg, "0") & Chr(176) & Strings.Format(LoMin, "00.0") & "'")
            If LoPoint > 0 And System.Math.Abs(LoPoint) <> 180 Then RhumbPointsTxtBx.AppendText(g_LongW)
            If LoPoint = 0 Or System.Math.Abs(LoPoint) = 180 Then RhumbPointsTxtBx.AppendText(g_StrSpace)
            If LoPoint < 0 And System.Math.Abs(LoPoint) <> 180 Then RhumbPointsTxtBx.AppendText(g_LongE)
        End If
        If txtLoDeg.Text <> "" Or txtLoMin.Text <> "" Then
            If txtLDeg.Text <> "" Or txtLMin.Text <> "" Then
                RhumbPointsTxtBx.AppendText(Space(41) & Strings.Format(LDeg, "0") & Chr(176) & Strings.Format(LMin, "00.0") & "'")
            End If
            If txtLDeg.Text = "" And txtLMin.Text = "" Then
                RhumbPointsTxtBx.AppendText(Space(66) & Strings.Format(LDeg, "0") & Chr(176) & Strings.Format(LMin, "00.0") & "'")
            End If
            If LPoint > 0 Then RhumbPointsTxtBx.AppendText(g_LatN)
            If LPoint = 0 Then RhumbPointsTxtBx.AppendText(g_StrSpace)
            If LPoint < 0 Then RhumbPointsTxtBx.AppendText(g_LatS)
        End If

        If txtLoDeg.Text = "" And txtLoMin.Text = "" Then RhumbPointsTxtBx.AppendText(vbNewLine)
        'If LFlag = True Or LoFlag = True Then Print Tab(11); "Point(s) beyond limits of rhumb line course."
        If ExceedFlag = True Then RhumbPointsTxtBx.AppendText(Space(7) & "Warning:  Point(s) beyond limits of rhumb line course.")

        FormSailings.cmdRhumbPoints.Enabled = False
    End Sub
    Private Sub txtLDeg_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLDeg.TextChanged
        If Val(txtLDeg.Text) <> 90 Then txtLMin.Enabled = True
        If Val(txtLDeg.Text) = 90 Then txtLMin.Clear() : txtLMin.Enabled = False : txtLMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000B)
        'txtLDeg.ForeColor = &H80000008
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
        Dim fnumeral As String = vbNullString
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
            ErrorMsgBox("Out of Range")
        End If
    End Sub

    Private Sub txtLMin_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtLMin.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Dim fnumeral As String = vbNullString
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
            ErrorMsgBox("Out of Range")
        End If
        If Val(txtLoDeg.Text) < 180 Then
            txtLoMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        End If
    End Sub

    Private Sub txtLoDeg_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtLoDeg.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Dim fnumeral As String = vbNullString
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
        Dim fnumeral As String = vbNullString
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


    Private Sub SelectAllText(ByRef TB As System.Windows.Forms.TextBox)
        TB.SelectionStart = 0
        TB.SelectionLength = Len(TB.Text)
    End Sub

    Private Sub frmPointsOnRhumb_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        'Next two lines center form on screen without StartUpPosition so form stays where last positioned despite graphics
        'Me.Left = (Screen.Width - Me.Width) / 2
        'Me.Top = (Screen.Height - Me.Height) / 2
        cboL.SelectedIndex = 0  '"N"
        cboLo.SelectedIndex = 0 '"W"
    End Sub

    Private Sub frmPointsOnRhumb_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'Cleanup()
    End Sub
    Private Sub ErrorMsgBox(ByVal ErrMsg As String)
        System.Windows.Forms.MessageBox.Show(ErrMsg, "Error",
                                                System.Windows.Forms.MessageBoxButtons.OK,
                                                System.Windows.Forms.MessageBoxIcon.Error,
                                                System.Windows.Forms.MessageBoxDefaultButton.Button1,
                                                System.Windows.Forms.MessageBoxOptions.DefaultDesktopOnly)
        Exit Sub
    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        txtLDeg.Text = ""
        txtLMin.Text = ""
        txtLoDeg.Text = ""
        txtLoMin.Text = ""
        RhumbPointsTxtBx.Clear()

    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub
End Class
