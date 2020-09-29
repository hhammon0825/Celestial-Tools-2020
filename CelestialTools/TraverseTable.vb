Public Class TraverseTable
    Private fnumeral As String
    Private L1, Lo1, Distance As Double  'L2,Lo2,CourseAngle,
    Private Lm, LatDiff, DLo As Double
    Private L2Deg, Lo2Deg As Integer
    Private Lo2Min, L2Min As Double
    Private BadCLS As Boolean
    Private dphi, q As Double
    Private Fix1L, Fix1Lo As Double
    Private Prefix, Suffix As String
    Private Departure, Factor, CompC, LmMin As Single
    Private IntLmMin, IntLatDiff, LmDeg, IntDLo As Integer
    Private CourseAngle, L2, Lo2 As Double
    Private Sub cmdCalculate_Click(sender As Object, e As EventArgs) Handles cmdCalculate.Click
        LatLong()
        Dim CString As String = txtCourse.Text & Chr(176)
        If Val(txtCourse.Text) >= 0 And Val(txtCourse.Text) < 90 Then
            CourseAngle = Val(txtCourse.Text)
            Prefix = g_LatN
            Suffix = g_LongE
        End If
        If Val(txtCourse.Text) >= 90 And Val(txtCourse.Text) < 180 Then
            CourseAngle = 180 - Val(txtCourse.Text)
            CString = "180" & Chr(176) & "-" & txtCourse.Text & Chr(176)
            Prefix = g_LatS
            Suffix = g_LongE
        End If
        If Val(txtCourse.Text) >= 180 And Val(txtCourse.Text) < 270 Then
            CourseAngle = Val(txtCourse.Text) - 180
            CString = CString & "- 180" & Chr(176)
            Prefix = g_LatS
            Suffix = g_LongW
        End If
        If Val(txtCourse.Text) >= 270 And Val(txtCourse.Text) < 360 Then
            CourseAngle = 360 - Val(txtCourse.Text)
            CString = "360" & Chr(176) & "-" & txtCourse.Text & Chr(176)
            Prefix = g_LatN
            Suffix = g_LongW
        End If

        If Math.Abs(L2) > 90 Then
            ErrorMsgBox("Distance too large.  Cannot go this far along this rhumb line.")
            Exit Sub
        End If
        Distance = Val(txtDist.Text)
        Factor = Math.Abs(Math.Cos(CourseAngle * System.Math.PI / 180))
        Factor = Int(Factor * 10 + 0.5) / 10
        Dim Cfactor As Double = Int((Math.Cos(CourseAngle * System.Math.PI / 180) * 10 + 0.5) / 10)
        LatDiff = Distance * Factor
        LatDiff = Int(LatDiff * 10 + 0.5) / 10
        IntLatDiff = Int(LatDiff + 0.5)

        txtSailings.Clear()
        txtSailings.AppendText(vbTab & vbTab & vbTab & " Simplified Traverse Table Worksheet" & vbNewLine & vbNewLine)
        txtSailings.SelectionAlignment = HorizontalAlignment.Left
        txtSailings.WordWrap = True

        txtSailings.AppendText("1." & vbTab & "Course: " & CString & "T => C = " & Prefix & " " &
                               (Math.Abs(CourseAngle)).ToString & Chr(176) & " " & Suffix &
                               vbTab & vbTab & "factor (C) = " & Math.Abs(Factor).ToString & vbNewLine)
        Cfactor = Factor
        CompC = 90 - CourseAngle
        Factor = Math.Abs(Math.Cos(CompC * System.Math.PI / 180))
        Factor = Int(Factor * 10 + 0.5) / 10

        Departure = Distance * Factor
        Departure = Int(Departure * 10 + 0.5) / 10

        txtSailings.AppendText("2." & vbTab & "Complement C = 90" & Chr(176) & "- C " & vbNewLine &
            "   " & vbTab & vbTab & "= 90" & Chr(176) & "-" & CourseAngle.ToString("##0") & vbNewLine &
            "   " & vbTab & vbTab & "= " & CompC.ToString & Chr(176) & vbTab & vbTab & vbTab & vbTab & "factor (Comp C) = " & Factor.ToString & vbNewLine)

        txtSailings.AppendText("3." & vbTab & "Diff Lat = D x factor(C) " & vbNewLine &
                               "   " & vbTab & vbTab & "= " & Distance.ToString("##0.0") & " nm x " & Cfactor.ToString("#0.0") & vbNewLine &
                               "   " & vbTab & vbTab & "= " & LatDiff.ToString("#0.0") & "'" & " rounded to " & IntLatDiff.ToString("#0") & "'" & vbNewLine)

        txtSailings.AppendText("4." & vbTab & "Departure = D x factor(Comp C) " & vbNewLine &
                               "   " & vbTab & vbTab & "= " & Distance.ToString("##0.0") & " nm x " & Factor.ToString("#0.0") & vbNewLine &
                               "   " & vbTab & vbTab & "= " & Math.Abs(Departure).ToString("#0.0") & " nm" & vbNewLine)
        Dim PlusMinusStr As String = "+"
        If Val(txtCourse.Text) > 90 And Val(txtCourse.Text) < 270 Then
            IntLatDiff = -IntLatDiff
            PlusMinusStr = "-"
        End If
        L2 = L1 + IntLatDiff / 60
        If Math.Abs(L2) >= 85 Then
            ErrorMsgBox("Latitude too high for Simplified Traverse Table, a form of mid-latitude sailing.")
            Exit Sub
        End If
        L2Deg = Int(Math.Abs(L2))
        L2Min = (Math.Abs(L2) - L2Deg) * 60
        L2Min = Int(L2Min + 0.5)
        If L2Min = 60 Then
            L2Min = 0
            L2Deg = L2Deg + 1
        End If
        If Lo2Min = 60 Then
            Lo2Min = 0
            Lo2Deg = Lo2Deg + 1
        End If

        txtSailings.AppendText("5." & vbTab & "L2 = L1 (+/-) Diff Lat" & vbNewLine &
                               "   " & vbTab & vbTab & "= " & txtL1Deg.Text.ToString & Chr(176) & txtL1Min.Text & "'" & cboL1.Text & " " & PlusMinusStr & " " & Math.Abs(IntLatDiff).ToString("0") & "'" & vbNewLine &
                               "   " & vbTab & vbTab & "= " & L2Deg.ToString("0") & Chr(176) & Format(L2Min, "00") & "'")
        If Math.Abs(L2) < 0.01 Then
            L2 = 0
            txtSailings.AppendText("")
        End If

        If L2 > 0 And Math.Abs(L2) > 0.01 Then
            txtSailings.AppendText(g_LatN)
        End If
        If L2 < 0 And Math.Abs(L2) > 0.01 Then
            txtSailings.AppendText(g_LatS)
        End If
        txtSailings.AppendText(vbNewLine)
        L2 = Math.Sign(L2) * (L2Deg + L2Min / 60)
        Lm = (L1 + L2) / 2 'Mid-latitude
        Factor = Math.Abs(Math.Cos(Lm * System.Math.PI / 180))
        Factor = Int(Factor * 10 + 0.5) / 10
        LmDeg = Int(Math.Abs(Lm))
        LmMin = (Math.Abs(Lm) - LmDeg) * 60
        LmMin = Int(LmMin * 10 + 0.5) / 10
        IntLmMin = Int(LmMin + 0.5)

        txtSailings.AppendText("6." & vbTab & "Mid Lat = L1 (+/-) (Diff Lat / 2) " & vbNewLine &
                               "   " & vbTab & vbTab & "= " & txtL1Deg.Text.ToString & Chr(176) & txtL1Min.Text & "'" & cboL1.Text & " " & PlusMinusStr & " " & Math.Abs(IntLatDiff).ToString("0") & "/2'" & vbNewLine &
                               "   " & vbTab & vbTab & "= " & Format(LmDeg, "0") & Chr(176) & Format(LmMin, "00.0") & "'")

        If Lm >= 0 Then
            txtSailings.AppendText(g_LatN)
        End If

        If Lm < 0 Then
            txtSailings.AppendText(g_LatS)
        End If

        txtSailings.AppendText(" rounded to " & Format(LmDeg, "0") & Chr(176) & Format(IntLmMin, "00") & "'")

        If Lm >= 0 Then
            txtSailings.AppendText(g_LatN)
        End If

        If Lm < 0 Then
            txtSailings.AppendText(g_LatS)
        End If

        'txtSailings.AppendText(vbNewLine)
        txtSailings.AppendText(vbTab & "factor (Mid-Lat) = " & Factor.ToString & vbNewLine)
        DLo = Int(Departure / Factor * 10 + 0.5) / 10
        IntDLo = Math.Sign(DLo) * Int(Math.Abs(DLo) + 0.5)

        txtSailings.AppendText("7." & vbTab & "Diff Lo = Departure / factor (Mid-Lat)" & vbNewLine &
                               "   " & vbTab & vbTab & "= " & Departure.ToString("#0.0") & " / " & Factor.ToString & vbNewLine &
                               "   " & vbTab & vbTab & "= " & DLo.ToString("#0.0") & "' rounded to " & IntDLo.ToString & "'" & vbNewLine)
        If Val(txtCourse.Text) > 0 And Val(txtCourse.Text) < 180 Then
            IntDLo = -IntDLo
        End If
        PlusMinusStr = " + "
        If IntDLo < 0 Then
            PlusMinusStr = " - "
        End If
        Lo2 = Lo1 + IntDLo / 60
        Do While Lo2 >= 360
            Lo2 = Lo2 - 360
        Loop
        'Crossing IDL
        If Math.Abs(Lo2) > 180 Then
            Lo2 = -Math.Sign(Lo2) * (360 - Math.Abs(Lo2))
        End If
        Lo2Deg = Int(Math.Abs(Lo2))
        Lo2Min = (Math.Abs(Lo2) - Lo2Deg) * 60
        Lo2Min = Int(Lo2Min + 0.5)

        txtSailings.AppendText("8." & vbTab & "Lo2 = Lo1 (+/-) Diff Lo" & vbNewLine &
                               "   " & vbTab & vbTab & "= " & txtLo1Deg.Text & Chr(176) & " " & txtLo1Min.Text & "'" & cboLo1.Text & " " & PlusMinusStr & Math.Abs(IntDLo).ToString & vbNewLine &
                               "   " & vbTab & vbTab & "= " & Format(Lo2Deg, "0") & Chr(176) & Format(Lo2Min, "00") & "'")
        If Math.Abs(Lo2) < 0.01 Then
            Lo2 = 0

            txtSailings.AppendText("")
        End If

        If Math.Abs(Lo2) > 179.999 Then txtSailings.AppendText("")

        If Lo2 > 0 And Math.Abs(Lo2) < 179.999 Then
            txtSailings.AppendText(g_LongW)
        End If

        If Lo2 < 0 And Math.Abs(Lo2) < 179.999 Then
            txtSailings.AppendText(g_LongE)
        End If
        txtSailings.AppendText(vbNewLine)
        txtSailings.AppendText(vbNewLine)

        txtSailings.AppendText("Arrival Position" & vbTab & "L2: " & Format(L2Deg, "0")  & Chr(176) & Format(L2Min, "00") & "'")
        If Math.Abs(L2) < 0.01 Then
            L2 = 0
            txtSailings.AppendText("")
        End If

        If L2 > 0 And Math.Abs(L2) > 0.01 Then
            txtSailings.AppendText(g_LatN)
        End If

        If L2 < 0 And Math.Abs(L2) > 0.01 Then
            txtSailings.AppendText(g_LatS)
        End If

        txtSailings.AppendText(vbTab & "Lo2: " & Format(Lo2Deg, "0") & Chr(176) & Format(Lo2Min, "00") & "'")
        If Math.Abs(Lo2) < 0.01 Then
            Lo2 = 0
            txtSailings.AppendText("")
        End If

        If Math.Abs(Lo2) > 179.999 Then
            txtSailings.AppendText("")
        End If

        If Lo2 > 0 And Math.Abs(Lo2) < 179.999 Then
            txtSailings.AppendText(g_LongW)
        End If

        If Lo2 < 0 And Math.Abs(Lo2) < 179.999 Then
            txtSailings.AppendText(g_LongE)
        End If
        txtTraverseTbl.Clear()

        txtTraverseTbl.AppendText(vbTab & vbTab & vbTab & "Simplified Traverse Table" & vbNewLine)
        txtTraverseTbl.AppendText(Space(5) & "Angle  0" & Chr(176) & Space(5) & "18" & Chr(176) & Space(5) & "31" & Chr(176) & Space(5) & "41" & Chr(176) & Space(5) & "49" & Chr(176) & Space(5) & "56" & Chr(176) & Space(5) & "63" & Chr(176) & Space(5) & "69" & Chr(176) & Space(5) & "75" & Chr(176) & Space(5) & "81" & Chr(176) & Space(5) & "87" & Chr(176) & Space(5) & "90" & Chr(176))
        txtTraverseTbl.AppendText(vbNewLine)
        txtTraverseTbl.AppendText(Space(5) & "Factor" & Space(5) & "1.0" & Space(6) & "0.9" & Space(5) & "0.8" & Space(6) & "0.7" & Space(5) & "0.6" & Space(6) & "0.5" & Space(5) & "0.4" & Space(6) & "0.3" & Space(5) & "0.2" & Space(6) & "0.1" & Space(5) & "0.0")
        'if txtDist.Text = "" Then
        '    txtSailings.AppendText("Distance   " & Format(Distance, "##0.0") & " nm")
        'End If
    End Sub
    Public Sub LatLong()
        BadCLS = False
        L1 = Val(txtL1Deg.Text) + Val(txtL1Min.Text) / 60
        If cboL1.Text = "S" Then L1 = -L1
        Lo1 = Val(txtLo1Deg.Text) + Val(txtLo1Min.Text) / 60
        If cboLo1.Text = "E" Then Lo1 = -Lo1
        'L2 = Val(txtL2Deg.Text) + Val(txtL2Min.Text) / 60
        'If cboL2.Text = "S" Then L2 = -L2
        'Lo2 = Val(txtLo2Deg.Text) + Val(txtLo2Min.Text) / 60
        'If cboLo2.Text = "E" Then Lo2 = -Lo2
        'If optMidLat.Checked = True And chkML.CheckState = 1 Then
        '    If (optCD.Checked = True Or optSD.Checked = True) And Math.Abs(L1 - L2) > 1 Then
        '        ErrorMsgBox("Maximum difference in latitude for CLS SAPS plot is 1º.")
        '        BadCLS = True
        '        Exit Sub
        '    End If
        '    If (optCD.Checked = True Or optSD.Checked = True) And Math.Abs(Lo1 - Lo2) > 1 Then
        '        ErrorMsgBox("Maximum difference in longitude for CLS SAPS plot is 1º.")
        '        BadCLS = True
        '        Exit Sub
        '    End If
        '    LmML = Val(txtMLDeg.Text) + Val(cboMLmin.Text) / 60
        '    If cboML.Text = "S" Then
        '        LmML = -LmML
        '    End If
        '    TestML()
        'End If

        'Fix1L = Val(txtFix1LD.Text) + Val(txtFix1LM.Text) / 60
        'If cboFix1L.Text = "S" Then
        '    Fix1L = -Fix1L
        'End If
        'Fix1Lo = Val(txtFix1LoD.Text) + Val(txtFix1LoM.Text) / 60
        'If cboFix1Lo.Text = "E" Then
        '    Fix1Lo = -Fix1Lo
        'End If

    End Sub
    Private Sub txtL1Deg_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtL1Deg.TextChanged
        txtL1Deg.BackColor = System.Drawing.SystemColors.Window
        If Val(txtL1Deg.Text) > 89 Then 'Or (Val(txtL1Deg.Text) = 90 And Val(txtL1Min.Text) <> 0) Then
            txtL1Deg.BackColor = Color.Red
            ErrorMsgBox("Out of Range")
        End If
        If Val(txtL1Deg.Text) <= 89 Then
            txtL1Min.BackColor = System.Drawing.SystemColors.Window
        End If

    End Sub

    Private Sub txtL1Deg_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtL1Deg.KeyPress
        Dim KeyAscii As Integer = Asc(eventArgs.KeyChar)
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

    Private Sub txtL1Deg_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtL1Deg.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtL1Deg.Text) > 89 Then
            KeepFocus = True
        End If

        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtL1Deg_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtL1Deg.Enter
        SelectAllText(txtL1Deg)
    End Sub

    Private Sub txtL1Min_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtL1Min.TextChanged
        txtL1Min.BackColor = System.Drawing.SystemColors.Window
        If Val(txtL1Min.Text) > 59.9 Then
            txtL1Min.BackColor = Color.Red
            ErrorMsgBox("Out of Range")
        End If
    End Sub

    Private Sub txtL1Min_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtL1Min.KeyPress
        Dim KeyAscii As Integer = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtL1Min.Text, ".") Then
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

    Private Sub txtL1Min_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtL1Min.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtL1Min.Text) > 59.9 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtL1Min_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtL1Min.Enter
        SelectAllText(txtL1Min)
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

    Private Sub txtLo1Deg_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLo1Deg.TextChanged
        If Val(txtLo1Deg.Text) <> 180 Then
            txtLo1Min.Enabled = True
        End If
        If Val(txtLo1Deg.Text) = 180 Then
            txtLo1Min.Text = ""
            txtLo1Min.Enabled = False
            txtLo1Min.BackColor = ColorTranslator.FromOle(&H8000000B)
        End If
        txtLo1Deg.BackColor = System.Drawing.SystemColors.Window
        If Val(txtLo1Deg.Text) > 180 Or (Val(txtLo1Deg.Text) = 180 And Val(txtLo1Min.Text) <> 0) Then
            txtLo1Deg.BackColor = Color.Red
            ErrorMsgBox("Out of Range")
        End If
        If Val(txtLo1Deg.Text) < 180 Then
            txtLo1Min.BackColor = System.Drawing.SystemColors.Window
        End If
    End Sub
    Private FormLoading As Boolean = False
    Private Sub TraverseTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormLoading = True
        cboL1.SelectedIndex = 0
        cboLo1.SelectedIndex = 0

        FormLoading = False
        Exit Sub
    End Sub

    Private Sub btnPrintScreen_Click(sender As Object, e As EventArgs) Handles btnPrintScreen.Click
        'ScreenCapture()
        PrintScreen(Me.Bounds)
        Me.Focus()
        Exit Sub
    End Sub

    Private Sub txtLo1Deg_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtLo1Deg.KeyPress
        Dim KeyAscii As Integer = Asc(eventArgs.KeyChar)
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

    Private Sub txtLo1Deg_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtLo1Deg.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtLo1Deg.Text) > 180 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtLo1Deg_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLo1Deg.Enter
        SelectAllText(txtLo1Deg)
    End Sub

    Private Sub txtLo1Min_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLo1Min.TextChanged
        txtLo1Min.BackColor = System.Drawing.SystemColors.Window
        If Val(txtLo1Min.Text) > 59.9 Then
            txtLo1Min.BackColor = Color.Red
            ErrorMsgBox("Out of Range")
        End If
    End Sub

    Private Sub txtLo1Min_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtLo1Min.KeyPress
        Dim KeyAscii As Integer = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtLo1Min.Text, ".") Then
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

    Private Sub txtLo1Min_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtLo1Min.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtLo1Min.Text) > 59.9 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtLo1Min_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLo1Min.Enter
        SelectAllText(txtLo1Min)
    End Sub
    Private Sub txtCourse_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCourse.TextChanged
        If Val(txtCourse.Text) > 359.9 Then
            txtCourse.BackColor = Color.Red
            ErrorMsgBox("Out of Range")
        End If
        If Val(txtCourse.Text) < 359.9 Then
            txtCourse.BackColor = System.Drawing.SystemColors.Window
        End If
    End Sub
    Private Sub txtCourse_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtCourse.KeyPress
        Dim KeyAscii As Integer = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtCourse.Text, ".") Then
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
    Private Sub txtCourse_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtCourse.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtCourse.Text) > 359.9 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtCourse_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCourse.Enter
        SelectAllText(txtCourse)
    End Sub

    Private Sub txtDist_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDist.TextChanged

        If Val(txtDist.Text) > 10800 Then
            txtDist.BackColor = Color.Red
            ErrorMsgBox("Out of Range")
        End If
        If Val(txtDist.Text) <= 10800 Then
            'txtDist.ForeColor = &H80000008
            txtDist.BackColor = System.Drawing.SystemColors.Window
        End If
    End Sub
    Private Sub txtDist_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtDist.KeyPress
        Dim KeyAscii As Integer = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtDist.Text, ".") Then
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
    Private Sub txtDist_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtDist.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtDist_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDist.Enter
        SelectAllText(txtDist)
    End Sub
    Private Shared Sub SelectAllText(ByRef TB As System.Windows.Forms.TextBox)
        TB.SelectionStart = 0
        TB.SelectionLength = TB.Text.ToString.Length
    End Sub
    Private Shared Sub ErrorMsgBox(ByVal ErrMsg As String)
        MessageBox.Show(ErrMsg, "Error",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Error,
                                                MessageBoxDefaultButton.Button1,
                                                MessageBoxOptions.DefaultDesktopOnly)
        Exit Sub
    End Sub
End Class