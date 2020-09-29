Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class FormNavMath
    Inherits System.Windows.Forms.Form
    'Dim U4, U2, U1, U3, U5 As Single
    Dim fnumeral As String
    Dim Degrees, Time, DecimalMinutes As Double
    Dim Angle3, Angle1, Angle2, result As Double
    Dim ResultDeg As Short
    Dim ResultMin As Single
    Dim ResultMinute As String
    Dim Time1inSeconds As Integer
    Dim TimeResult As Single
    Dim TimeResultHours, TimeResultMinutes, Days As Short
    Dim T1Seconds As Single
    ' Dim TimeInSeconds As Double ',H1 As Single, M1 As Single, S1 As Single, H2 As Single, M2 As Single, S2 As Single
    'Dim TimeMinutes, TimeDays, TimeHours, TimeSeconds As Single
    Dim ZD1, Lo, ZD, ZD2 As Double
    Dim SignZD As String
    Dim ZD1inseconds, ZD2inseconds As Integer
    Dim UTinSeconds As Single
    'Dim S, H, D, M, As String
    'Dim LocADT As Date
    'Dim LocBDT As Date
    Dim LocADTPicked As Boolean = False
    'Dim TZA As TimeZoneInfo
    'Dim TZASelected As Boolean = False
    'Dim TZAID As String
    'Dim TZB As TimeZoneInfo
    'Dim TZBId As String
    Dim TZBSelected As Boolean = False



    Private Sub cboZDm1_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboZDm1.SelectedIndexChanged
        txtTimeResult.Clear()
        txtDays.Clear()
    End Sub

    Private Sub cboZDm2_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboZDm2.SelectedIndexChanged
        txtTimeResult.Clear()
        txtDays.Clear()
    End Sub

    Private Sub chkDST1_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkDST1.CheckedChanged
        txtTimeResult.Clear()
        txtDays.Clear()
    End Sub

    Private Sub chkDST2_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkDST2.CheckStateChanged
        txtTimeResult.Clear()
        txtDays.Clear()
    End Sub

    'Private Sub cmdClear_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) 
    '    txtC1.Clear()
    '    txtC2.Clear()
    '    txtC3.Clear()
    '    txtR1.Clear()
    '    txtR2.Clear()
    '    txtR3.Clear()
    '    txtK1.Clear()
    '    txtK2.Clear()
    '    txtK3.Clear()
    '    txtK4.Clear()
    '    txtU1.Clear()
    '    txtU2.Clear()
    '    txtU3.Clear()
    '    txtU4.Clear()
    '    txtU5.Clear()
    'End Sub

    Private Sub cmdClearAddSubtract_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClearAddSubtract.Click
        txtDeg1.Clear()
        txtMin1.Clear()
        txtDeg2.Clear()
        txtMin2.Clear()
        txtDeg3.Clear()
        txtMin3.Clear()
        txtResult.Clear()
    End Sub

    Private Sub cmdClearConverter_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClearConverter.Click
        txtHsDeg.Clear()
        txtHsMin.Clear()
        txtHsSec.Clear()
        'txtTime.Clear()
        txtAngle.Clear()
        txtConvertedTime.Clear()
        dtTime.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
    End Sub

    Private Sub cmdClearTZ_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClearTZ.Click
        txtLoDeg.Clear()
        txtLoMin.Clear()
        txtZD.Clear()
    End Sub

    Private Sub cmdConvert_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdConvert.Click
        Degrees = Val(txtHsDeg.Text) + Val(txtHsMin.Text) / 60 + Val(txtHsSec.Text) / 3600
        Degrees = Int(Degrees * 100000 + 0.5) / 100000
        'Time = Val(VB.Left(txtTime.Text, 2)) + Val(Mid(txtTime.Text, 3, 2)) / 60 + Val(VB.Right(txtTime.Text, 2)) / 3600
        Time = dtTime.Value.Hour + dtTime.Value.Minute / 60 + dtTime.Value.Second / 3600
        DecimalMinutes = dtTime.Value.Minute + dtTime.Value.Second / 60
        'DecimalMinutes = Val(Mid(txtTime.Text, 3, 2)) + Val(VB.Right(txtTime.Text, 2)) / 60
        'DecimalMinutes = Int(DecimalMinutes * 100000 + 0.5) / 100000
        'Time = Int(Time * 100000 + 0.5) / 100000
        txtAngle.Text = Str(Degrees) & " degrees"
        txtConvertedTime.Text = Time.ToString("#0.00") & " h or " & dtTime.Value.Hour.ToString("#0") & " h " & DecimalMinutes.ToString("#0.00") & " m"
    End Sub

    'Private Sub cmdInterpolate_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) 
    '    txtU1.Clear() : txtU2.Clear() : txtU3.Clear() : txtU4.Clear() : txtU5.Clear()
    '    If txtK1.Text = "" Then ErrorMsgBox("Not enough data.") : Exit Sub
    '    If txtK2.Text = "" And txtK3.Text = "" Then ErrorMsgBox("Not enough data.") : Exit Sub
    '    If Val(txtC1.Text) = Val(txtC3.Text) And txtC1.Text <> "" Then ErrorMsgBox("Check for incorrect C value(s).") : Exit Sub
    '    If Val(txtC1.Text) < Val(txtC3.Text) And (Val(txtC2.Text) <= Val(txtC1.Text) Or Val(txtC2.Text) >= Val(txtC3.Text)) Then ErrorMsgBox("Check for incorrect C value(s).") : Exit Sub
    '    If Val(txtC1.Text) > Val(txtC3.Text) And (Val(txtC2.Text) <= Val(txtC3.Text) Or Val(txtC2.Text) >= Val(txtC1.Text)) Then ErrorMsgBox("Check for incorrect C value(s).") : Exit Sub
    '    If Val(txtR1.Text) = Val(txtR3.Text) And txtR1.Text <> "" Then ErrorMsgBox("Check for incorrect R value(s).") : Exit Sub
    '    If Val(txtR1.Text) < Val(txtR3.Text) And (Val(txtR2.Text) <= Val(txtR1.Text) Or Val(txtR2.Text) >= Val(txtR3.Text)) Then ErrorMsgBox("Check for incorrect R value(s).") : Exit Sub
    '    If Val(txtR1.Text) > Val(txtR3.Text) And (Val(txtR2.Text) <= Val(txtR3.Text) Or Val(txtR2.Text) >= Val(txtR1.Text)) Then ErrorMsgBox("Check for incorrect R value(s).") : Exit Sub
    '    If txtK4.Text = "" And (txtK2.Text = "" Or txtK3.Text = "") Then InterpType = "Single" Else InterpType = "Double"
    '    If InterpType = "Double" Then
    '        If Val(txtK1.Text) < Val(txtK2.Text) And Val(txtK3.Text) > Val(txtK4.Text) Then ErrorMsgBox("Check for incorrect K value(s).") : Exit Sub
    '        If Val(txtK1.Text) > Val(txtK2.Text) And Val(txtK3.Text) < Val(txtK4.Text) Then ErrorMsgBox("Check for incorrect K value(s).") : Exit Sub
    '        If Val(txtK1.Text) < Val(txtK3.Text) And Val(txtK2.Text) > Val(txtK4.Text) Then ErrorMsgBox("Check for incorrect K value(s).") : Exit Sub
    '        If Val(txtK1.Text) > Val(txtK2.Text) And Val(txtK2.Text) < Val(txtK4.Text) Then ErrorMsgBox("Check for incorrect K value(s).") : Exit Sub
    '        If txtC1.Text = "" Or txtC2.Text = "" Or txtC3.Text = "" Or txtR1.Text = "" Or txtR2.Text = "" Or txtR3.Text = "" Then ErrorMsgBox("Not enough data.") : Exit Sub
    '        U1 = (Val(txtC2.Text) - Val(txtC1.Text)) * (Val(txtK3.Text) - Val(txtK1.Text)) / (Val(txtC3.Text) - Val(txtC1.Text))
    '        U1 = Val(txtK1.Text) + U1
    '        U1 = System.Math.Sign(U1) * Int(System.Math.Abs(U1) * 100000 + 0.5) / 100000                 'Int(U1 * 100000 + 0.5) / 100000  Changed in V5.5.0
    '        U2 = (Val(txtC2.Text) - Val(txtC1.Text)) * (Val(txtK4.Text) - Val(txtK2.Text)) / (Val(txtC3.Text) - Val(txtC1.Text))
    '        U2 = Val(txtK2.Text) + U2
    '        U2 = System.Math.Sign(U2) * Int(System.Math.Abs(U2) * 100000 + 0.5) / 100000                 'Int(U2 * 100000 + 0.5) / 100000  Changed in V5.5.0
    '        txtU1.Text = Str(U1)
    '        txtU2.Text = Str(U2)
    '        U3 = (Val(txtR2.Text) - Val(txtR1.Text)) * (Val(txtK2.Text) - Val(txtK1.Text)) / (Val(txtR3.Text) - Val(txtR1.Text))
    '        U3 = Val(txtK1.Text) + U3
    '        U3 = System.Math.Sign(U3) * Int(System.Math.Abs(U3) * 100000 + 0.5) / 100000                'Int(U3 * 100000 + 0.5) / 100000  Changed in V5.5.0
    '        U4 = (Val(txtR2.Text) - Val(txtR1.Text)) * (Val(txtK4.Text) - Val(txtK3.Text)) / (Val(txtR3.Text) - Val(txtR1.Text))
    '        U4 = Val(txtK3.Text) + U4
    '        U4 = System.Math.Sign(U4) * Int(System.Math.Abs(U4) * 100000 + 0.5) / 100000                'Int(U4 * 100000 + 0.5) / 100000  Changed in V5.5.0
    '        U5 = (Val(txtC2.Text) - Val(txtC1.Text)) * (U4 - U3) / (Val(txtC3.Text) - Val(txtC1.Text))
    '        U5 = U3 + U5
    '        U5 = System.Math.Sign(U5) * Int(System.Math.Abs(U5) * 100000 + 0.5) / 100000                'Int(U5 * 100000 + 0.5) / 100000  Changed in V5.5.0
    '        txtU3.Text = Str(U3)
    '        txtU4.Text = Str(U4)
    '        txtU5.Text = Str(U5)
    '        'End If
    '    End If
    '    If InterpType = "Single" Then
    '        If txtK2.Text = "" And txtK4.Text = "" Then 'Across
    '            If txtC1.Text = "" Or txtC2.Text = "" Or txtC3.Text = "" Then ErrorMsgBox("Not enough data.") : Exit Sub
    '            U1 = (Val(txtC2.Text) - Val(txtC1.Text)) * (Val(txtK3.Text) - Val(txtK1.Text)) / (Val(txtC3.Text) - Val(txtC1.Text))
    '            U1 = Val(txtK1.Text) + U1
    '            U1 = System.Math.Sign(U1) * Int(System.Math.Abs(U1) * 100000 + 0.5) / 100000                'Int(U1 * 100000 + 0.5) / 100000  Changed in V5.5.0
    '            txtU1.Text = Str(U1)
    '        End If
    '        If txtK3.Text = "" And txtK4.Text = "" Then 'Down
    '            If txtR1.Text = "" Or txtR2.Text = "" Or txtR3.Text = "" Then ErrorMsgBox("Not enough data.") : Exit Sub
    '            U3 = (Val(txtR2.Text) - Val(txtR1.Text)) * (Val(txtK2.Text) - Val(txtK1.Text)) / (Val(txtR3.Text) - Val(txtR1.Text))
    '            U3 = Val(txtK1.Text) + U3
    '            U3 = System.Math.Sign(U3) * Int(System.Math.Abs(U3) * 100000 + 0.5) / 100000                'Int(U3 * 100000 + 0.5) / 100000  Changed in V5.5.0
    '            txtU3.Text = Str(U3)
    '        End If
    '    End If
    'End Sub

    Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
        PrintScreen(Me.Bounds)
    End Sub

    Private Sub optAdd1_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optAdd1.CheckedChanged
        If eventSender.Checked Then
            'Calculate()
        End If
    End Sub

    Private Sub optAdd2_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optAdd2.CheckedChanged
        If eventSender.Checked Then
            'Calculate()
        End If
    End Sub

    Private Sub optAddTimes_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optAddTimes.CheckedChanged
        If eventSender.Checked Then
            'txtCalcTime1.Clear()
        End If
    End Sub

    Private Sub optAddToD_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optAddToD.CheckedChanged
        If eventSender.Checked Then
            txtTimeResult.Clear() : txtDays.Clear()
        End If
    End Sub

    Private Sub optHsDMm_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optHsDMm.CheckedChanged
        If eventSender.Checked Then
            If optHsDMm.Checked = True Then
                txtHsSec.Visible = False
                lblHsSec.Visible = False
                txtHsMin.Clear()
                txtHsSec.Clear()
            End If
        End If
    End Sub

    Private Sub optHsDMS_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optHsDMS.CheckedChanged
        If eventSender.Checked Then
            If optHsDMS.Checked = True Then
                txtHsSec.Visible = True
                lblHsSec.Visible = True
                txtHsMin.Clear()
                txtHsSec.Clear()
            End If
        End If
    End Sub

    Private Sub optSubtract1_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optSubtract1.CheckedChanged
        If eventSender.Checked Then
            'Calculate()
        End If
    End Sub

    Private Sub optSubtract2_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optSubtract2.CheckedChanged
        If eventSender.Checked Then
            'Calculate()
        End If
    End Sub

    Private Sub optSubtractTimes_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optSubtractTimes.CheckedChanged
        If eventSender.Checked Then
            'txtCalcTime1.Clear()

        End If
    End Sub

    Private Sub optSubtractToD_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optSubtractToD.CheckedChanged
        If eventSender.Checked Then
            txtTimeResult.Clear()
            txtDays.Clear()
        End If
    End Sub

    'Private Sub txtC1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) 
    '    Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
    '    Select Case KeyAscii
    '        Case Asc("0") To Asc("9")
    '            fnumeral = fnumeral & Chr(KeyAscii)
    '        Case Asc(".") 'only allows one decimal point
    '            If InStr(txtC1.Text, ".") Then
    '                If KeyAscii = 46 Then KeyAscii = 0 : Beep()
    '            End If
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
    'Private Sub txtC1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) 
    '    SelectAllText(txtC1)
    'End Sub

    'Private Sub txtC2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) 
    '    Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
    '    Select Case KeyAscii
    '        Case Asc("0") To Asc("9")
    '            fnumeral = fnumeral & Chr(KeyAscii)
    '        Case Asc(".") 'only allows one decimal point
    '            If InStr(txtC2.Text, ".") Then
    '                If KeyAscii = 46 Then KeyAscii = 0 : Beep()
    '            End If
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
    'Private Sub txtC2_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) 
    '    SelectAllText(txtC2)
    'End Sub

    'Private Sub txtC3_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) 
    '    Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
    '    Select Case KeyAscii
    '        Case Asc("0") To Asc("9")
    '            fnumeral = fnumeral & Chr(KeyAscii)
    '        Case Asc(".") 'only allows one decimal point
    '            If InStr(txtC3.Text, ".") Then
    '                If KeyAscii = 46 Then KeyAscii = 0 : Beep()
    '            End If
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
    'Private Sub txtC3_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) 
    '    SelectAllText(txtC3)
    'End Sub

    Private Sub txtHsDeg_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHsMin.TextChanged, txtHsDeg.TextChanged
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
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtHsDeg_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHsDeg.Enter
        SelectAllText(txtHsDeg)
    End Sub

    Private Sub txtHsMin_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        txtHsMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If optHsDMm.Checked = True And Val(txtHsMin.Text) > 59.9 Then
            txtHsMin.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
        If optHsDMS.Checked = True And Val(txtHsMin.Text) > 59 Then
            txtHsMin.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
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
            ErrorMsgBox("Out of Range")
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

    'Private Sub txtK1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) 
    '    Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
    '    Static bMinusSignAlready As Boolean
    '    bMinusSignAlready = False
    '    Select Case KeyAscii
    '        Case System.Windows.Forms.Keys.Back, System.Windows.Forms.Keys.Right, System.Windows.Forms.Keys.Left
    '            'do nothing
    '        Case Asc("0") To Asc("9")
    '            fnumeral = fnumeral & Chr(KeyAscii)
    '        Case Asc("-")
    '            If txtK1.SelectionStart <> 0 Or bMinusSignAlready Then
    '                KeyAscii = 0
    '                Beep()
    '            Else
    '                bMinusSignAlready = True
    '            End If

    '        Case Asc(".") 'only allows one decimal point
    '            If InStr(txtK1.Text, ".") Then
    '                If KeyAscii = 46 Then KeyAscii = 0 : Beep()
    '            End If
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
    'Private Sub txtK1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) 
    '    SelectAllText(txtK1)
    'End Sub

    'Private Sub txtK2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) 
    '    Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
    '    Static bMinusSignAlready As Boolean
    '    bMinusSignAlready = False
    '    Select Case KeyAscii
    '        Case Asc("0") To Asc("9")
    '            fnumeral = fnumeral & Chr(KeyAscii)
    '        Case Asc("-")
    '            If txtK2.SelectionStart <> 0 Or bMinusSignAlready Then
    '                KeyAscii = 0
    '                Beep()
    '            Else
    '                bMinusSignAlready = True
    '            End If

    '        Case Asc(".") 'only allows one decimal point
    '            If InStr(txtK2.Text, ".") Then
    '                If KeyAscii = 46 Then KeyAscii = 0 : Beep()
    '            End If
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
    'Private Sub txtK2_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) 
    '    SelectAllText(txtK2)
    'End Sub

    'Private Sub txtK3_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) 
    '    Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
    '    Static bMinusSignAlready As Boolean
    '    bMinusSignAlready = False
    '    Select Case KeyAscii
    '        Case Asc("0") To Asc("9")
    '            fnumeral = fnumeral & Chr(KeyAscii)
    '        Case Asc("-")
    '            If txtK3.SelectionStart <> 0 Or bMinusSignAlready Then
    '                KeyAscii = 0
    '                Beep()
    '            Else
    '                bMinusSignAlready = True
    '            End If

    '        Case Asc(".") 'only allows one decimal point
    '            If InStr(txtK3.Text, ".") Then
    '                If KeyAscii = 46 Then KeyAscii = 0 : Beep()
    '            End If
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
    'Private Sub txtK3_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) 
    '    SelectAllText(txtK3)
    'End Sub

    'Private Sub txtK4_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) 

    'End Sub
    'Private Sub txtK4_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) 
    '    SelectAllText(txtK4)
    'End Sub

    'Private Sub txtR1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) 
    '    Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
    '    Select Case KeyAscii
    '        Case Asc("0") To Asc("9")
    '            fnumeral = fnumeral & Chr(KeyAscii)
    '        Case Asc(".") 'only allows one decimal point
    '            If InStr(txtR1.Text, ".") Then
    '                If KeyAscii = 46 Then KeyAscii = 0 : Beep()
    '            End If
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
    'Private Sub txtR1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) 
    '    SelectAllText(txtR1)
    'End Sub

    'Private Sub txtR2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) 
    '    Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
    '    Select Case KeyAscii
    '        Case Asc("0") To Asc("9")
    '            fnumeral = fnumeral & Chr(KeyAscii)
    '        Case Asc(".") 'only allows one decimal point
    '            If InStr(txtR2.Text, ".") Then
    '                If KeyAscii = 46 Then KeyAscii = 0 : Beep()
    '            End If
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
    'Private Sub txtR2_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) 
    '    SelectAllText(txtR2)
    'End Sub

    'Private Sub txtR3_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) 
    '    Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
    '    Select Case KeyAscii
    '        Case Asc("0") To Asc("9")
    '            fnumeral = fnumeral & Chr(KeyAscii)
    '        Case Asc(".") 'only allows one decimal point
    '            If InStr(txtR3.Text, ".") Then
    '                If KeyAscii = 46 Then KeyAscii = 0 : Beep()
    '            End If
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
    'Private Sub txtR3_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) 
    '    SelectAllText(txtR3)
    'End Sub

    Private Sub FormNavMath_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        cboLo.SelectedIndex = 0 'g_LongW
        cboZDm1.SelectedIndex = 0 '"00"
        cboZDm2.SelectedIndex = 0 '"00"
        LocADTPicked = False
        dtTime.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        'lblLocB.Visible = False
        'Dim LocACollection As ObjectModel.ReadOnlyCollection(Of TimeZoneInfo) = TimeZoneInfo.GetSystemTimeZones
        'For Each TZT As TimeZoneInfo In LocACollection 'TimeZoneInfo.GetSystemTimeZones
        '    cbLocAZD.Items.Add(TZT)
        '    cbLocBZone.Items.Add(TZT)
        'Next

        'cbLocAZD.SelectedIndex = 0
        'cbLocBZone.SelectedIndex = 0

    End Sub

    Private Sub FormNavMath_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        'Cleanup()
    End Sub

    'Private Sub txtTime_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
    '    'txtTime.ForeColor = &H80000008
    '    txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
    '    If Len(txtTime.Text) = 6 And Val(Mid(txtTime.Text, 3, 2)) > 59 Or Val(Mid(txtTime.Text, 5, 2)) > 59 Then '(Val(Left(txtTime.Text, 2)) > 99 Or
    '        txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
    '        ErrorMsgBox("Out of Range")
    '    End If
    'End Sub

    'Private Sub txtTime_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
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

    'Private Sub txtTime_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs)
    '    Dim KeepFocus As Boolean = eventArgs.Cancel
    '    If Val(Mid(txtTime.Text, 3, 2)) > 59 Or Val(Mid(txtTime.Text, 5, 2)) > 59 Or Len(txtTime.Text) <> 6 Then 'Val(Left(txtTime.Text, 2)) > 23 Or
    '        KeepFocus = True
    '    End If
    '    If Len(txtTime.Text) = 0 Then
    '        KeepFocus = False
    '    End If
    '    eventArgs.Cancel = KeepFocus
    'End Sub
    'Private Sub txtTime_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
    '    SelectAllText(txtTime)
    'End Sub

    Private Sub AddSubtractCalculate()
        Angle1 = Val(txtDeg1.Text) + Val(txtMin1.Text) / 60
        Angle2 = Val(txtDeg2.Text) + Val(txtMin2.Text) / 60
        Angle3 = Val(txtDeg3.Text) + Val(txtMin3.Text) / 60
        If optAdd1.Checked = True And optAdd2.Checked = True Then result = Angle1 + Angle2 + Angle3
        If optAdd1.Checked = True And optSubtract2.Checked = True Then result = Angle1 + Angle2 - Angle3
        If optSubtract1.Checked = True And optAdd2.Checked = True Then result = Angle1 - Angle2 + Angle3
        If optSubtract1.Checked = True And optSubtract2.Checked = True Then result = Angle1 - Angle2 - Angle3
        While result >= 360
            result = result - 360
        End While
        While result < 0
            result = result + 360
        End While
        ResultDeg = Int(result)
        ResultMin = (result - ResultDeg) * 60
        ResultMin = Int(ResultMin * 10 + 0.5) / 10
        ResultMinute = Strings.Format(ResultMin, "00.0")
        txtResult.Text = Str(ResultDeg) & Chr(176) & ResultMinute & "'"
    End Sub

    Private Sub optAdd_Click()
        'Calculate()
    End Sub

    Private Sub optSubtract_Click()
        'Calculate()
    End Sub

    Private Sub txtDeg1_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDeg1.TextChanged
        'Calculate()
    End Sub

    Private Sub txtDeg1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtDeg1.KeyPress
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

    Private Sub txtDeg1_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtDeg1.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtDeg1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDeg1.Enter
        SelectAllText(txtDeg1)
    End Sub

    Private Sub txtMin1_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMin1.TextChanged
        txtMin1.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtMin1.Text) > 59.9 Then
            txtMin1.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
        'Calculate()
    End Sub

    Private Sub txtMin1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtMin1.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtMin1.Text, ".") Then
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

    Private Sub txtMin1_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtMin1.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtMin1.Text) > 59.9 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtMin1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMin1.Enter
        SelectAllText(txtMin1)
    End Sub

    Private Sub txtDeg2_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDeg2.TextChanged
        'Calculate()
    End Sub

    Private Sub txtDeg2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtDeg2.KeyPress
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

    Private Sub txtDeg2_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtDeg2.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtDeg2_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDeg2.Enter
        SelectAllText(txtDeg2)
    End Sub

    Private Sub txtMin2_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMin2.TextChanged
        txtMin2.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtMin2.Text) > 59.9 Then
            txtMin2.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
        'Calculate()
    End Sub

    Private Sub txtMin2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtMin2.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtMin2.Text, ".") Then
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

    Private Sub txtMin2_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtMin2.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtMin2.Text) > 59.9 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtMin2_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMin2.Enter
        SelectAllText(txtMin2)
    End Sub

    Private Sub txtDeg3_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDeg3.TextChanged
        'Calculate()
    End Sub

    Private Sub txtDeg3_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtDeg3.KeyPress
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

    Private Sub txtDeg3_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtDeg3.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtDeg3_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDeg3.Enter
        SelectAllText(txtDeg3)
    End Sub

    Private Sub txtMin3_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMin3.TextChanged
        'txtMin2.ForeColor = &H80000008
        txtMin3.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtMin3.Text) > 59.9 Then
            txtMin2.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
        'Calculate()
    End Sub

    Private Sub txtMin3_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtMin3.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtMin3.Text, ".") Then
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

    Private Sub txtMin3_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtMin3.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtMin3.Text) > 59.9 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtMin3_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        SelectAllText(txtMin3)
    End Sub

    Private Sub txtTime1_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTime1.TextChanged
        txtTimeResult.Clear() : txtDays.Clear()
        txtTime1.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Len(txtTime1.Text) = 4 And (Val(VB.Left(txtTime1.Text, 2)) > 23 Or Val(VB.Right(txtTime1.Text, 2)) > 59) Then
            txtTime1.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
    End Sub

    Private Sub txtTime1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTime1.KeyPress

    End Sub

    Private Sub txtTime1_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtTime1.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        'If Val(Left(txtTime1.text, 2)) > 23 Or Val(Mid(txtTime1.text, 3, 2)) > 59 Or Val(Mid(txtTime1.text, 5, 2)) > 59 Or Len(txtTime1) <> 6 Then
        If Val(VB.Left(txtTime1.Text, 2)) > 23 Or Val(VB.Right(txtTime1.Text, 2)) > 59 Or Len(txtTime1.Text) <> 4 Then
            KeepFocus = True
        End If
        If Len(txtTime1.Text) = 0 Then
            KeepFocus = False
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtTime1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMin3.Enter, txtTime1.Enter
        SelectAllText(txtTime1)
    End Sub

    Private Sub txtIntD_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtIntD.TextChanged
        txtTimeResult.Clear()
        txtDays.Clear()
    End Sub
    Private Sub txtIntD_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtIntD.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtIntD.Text, ".") Then
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
    Private Sub txtIntD_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtIntD.Enter
        SelectAllText(txtIntD)
    End Sub

    Private Sub txtIntH_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtIntH.TextChanged
        txtTimeResult.Clear() : txtDays.Clear()
    End Sub
    Private Sub txtIntH_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtIntH.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtIntH.Text, ".") Then
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
    Private Sub txtIntH_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtIntH.Enter
        SelectAllText(txtIntH)
    End Sub

    Private Sub txtIntM_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtIntM.TextChanged
        txtTimeResult.Clear() : txtDays.Clear()
    End Sub
    Private Sub txtIntM_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtIntM.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtIntM.Text, ".") Then
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
    Private Sub txtIntM_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtIntM.Enter
        SelectAllText(txtIntM)
    End Sub

    Private Sub txtZDh1_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtZDh1.TextChanged
        txtTimeResult.Clear() : txtDays.Clear()
        'txtZDh.ForeColor = &H80000008
        txtZDh1.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If (Val(txtZDh1.Text) < -13 Or Val(txtZDh1.Text) > 12) Then
            txtZDh1.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
    End Sub

    Private Sub txtZDh1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtZDh1.KeyPress
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
                If txtZDh1.SelectionStart <> 0 Or bMinusSignAlready Then
                    KeyAscii = 0
                    Beep()
                Else
                    bMinusSignAlready = True
                End If
            Case Asc("+")

                If txtZDh1.SelectionStart <> 0 Or bPlusSignAlready Then
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
    Private Sub txtZDh1_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtZDh1.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtZDh1.Text) < -13 Or Val(txtZDh1.Text) > 12 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtZDh1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtZDh1.Enter
        SelectAllText(txtZDh1)
    End Sub

    Private Sub btnMoveResult_Click(sender As Object, e As EventArgs) Handles btnMoveResult.Click

        DT1Days.Value = DTRDays.Value
        DT1Hours.Value = DTRHours.Value
        DT1Minutes.Value = DTRMinutes.Value
        DT1Seconds.Value = DTRSeconds.Value

        DTRDays.Value = 0
        DTRHours.Value = 0
        DTRMinutes.Value = 0
        DTRSeconds.Value = 0
        Exit Sub
    End Sub



    Private Sub txtZDh2_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtZDh2.TextChanged
        txtTimeResult.Clear() : txtDays.Clear()
        txtZDh2.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If (Val(txtZDh2.Text) < -13 Or Val(txtZDh2.Text) > 12) Then
            txtZDh1.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
    End Sub

    Private Sub txtZDh2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtZDh2.KeyPress
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
                If txtZDh2.SelectionStart <> 0 Or bMinusSignAlready Then
                    KeyAscii = 0
                    Beep()
                Else
                    bMinusSignAlready = True
                End If
            Case Asc("+")

                If txtZDh2.SelectionStart <> 0 Or bPlusSignAlready Then
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
    Private Sub txtZDh2_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs)
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtZDh2.Text) < -13 Or Val(txtZDh2.Text) > 12 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtZDh2_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtZDh2.Enter
        SelectAllText(txtZDh2)
    End Sub

    Private Sub cmdClearToD_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClearToD.Click
        txtTime1.Clear()
        txtZDh1.Clear()
        txtZDh2.Clear()
        txtIntD.Clear()
        txtIntH.Clear()
        txtIntM.Clear()
        txtTimeResult.Clear()
        txtDays.Visible = False

        'lblLocB.Visible = False
        'txtLocBDateTime.Clear()
        'txtLocBDateTime.Visible = False
        'cbLocAZD.SelectedIndex = 0
        'cbLocBZone.SelectedIndex = 0

        LocADTPicked = False
        'TZASelected = False
        TZBSelected = False
        chkDST1.CheckState = System.Windows.Forms.CheckState.Unchecked
        chkDST2.CheckState = System.Windows.Forms.CheckState.Unchecked
        cboZDm1.SelectedIndex = 0
        cboZDm2.SelectedIndex = 0
    End Sub

    Private Sub cmdCalculateToD_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCalculateToD.Click

        Time1inSeconds = 3600 * Val(VB.Left(txtTime1.Text, 2)) + 60 * Val(Mid(txtTime1.Text, 3, 2)) + Val(VB.Right(txtTime1.Text, 2))

        ZD1 = System.Math.Abs(Val(txtZDh1.Text)) + Val(cboZDm1.Text) / 60

        If VB.Left(txtZDh1.Text, 1) = "-" Then
            ZD1 = -ZD1
        End If
        If chkDST1.CheckState = 1 Then
            ZD1 = ZD1 - 1
        End If

        ZD1inseconds = 3600 * ZD1
        UTinSeconds = Time1inSeconds + ZD1inseconds
        T1Seconds = 86400 * Val(txtIntD.Text) + 3600 * Val(txtIntH.Text) + 60 * Val(txtIntM.Text) '+ Val(txtIntS.text)

        ZD2 = System.Math.Abs(Val(txtZDh2.Text)) + Val(cboZDm2.Text) / 60

        If VB.Left(txtZDh2.Text, 1) = "-" Then
            ZD2 = -ZD2
        End If
        If chkDST2.CheckState = 1 Then
            ZD2 = ZD2 - 1
        End If

        ZD2inseconds = 3600 * ZD2
        If optAddToD.Checked = True Then
            TimeResult = UTinSeconds + T1Seconds
        End If
        If optSubtractToD.Checked = True Then
            TimeResult = UTinSeconds - T1Seconds
        End If

        TimeResult = TimeResult - ZD2inseconds

        Days = 0
        While TimeResult >= 86399
            TimeResult = TimeResult - 86400
            Days = Days + 1
        End While
        While TimeResult < 0
            TimeResult = TimeResult + 86400
            Days = Days - 1
        End While
        TimeResultHours = Int(TimeResult / 3600)
        TimeResultMinutes = Int((TimeResult - CSng(TimeResultHours) * 3600) / 60)
        txtTimeResult.Text = TimeResultHours.ToString("00") & ":" & TimeResultMinutes.ToString("00") '& Strings.format(Str$(TimeResultSeconds), "00")

        'If LocADTPicked = True Then

        '    'LocADT = DTLocA.Value
        '    'DateTime.SpecifyKind(LocADT, DateTimeKind.Local)
        '    'DateTime.SpecifyKind(LocBDT, DateTimeKind.Local)
        '    'TZA = cbLocAZD.SelectedItem
        '    'TZB = cbLocBZone.SelectedItem
        '    LocBDT = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(LocADT, TZA.Id, TZB.Id)
        '    Dim IntDays As Integer = 0
        '    Dim IntHours As Integer = 0
        '    Dim IntMins As Integer = 0
        '    If txtIntD.Text <> vbNullString Then
        '        IntDays = Convert.ToInt32(txtIntD.Text)
        '    End If
        '    If txtIntH.Text <> vbNullString Then
        '        IntHours = Convert.ToInt32(txtIntH.Text)
        '    End If
        '    If txtIntM.Text <> vbNullString Then
        '        IntMins = Convert.ToInt32(txtIntM.Text)
        '    End If

        '    Dim Tspan As TimeSpan = New TimeSpan(IntDays, IntHours, IntMins, 0)
        '    If optAddToD.Checked = True Then
        '        LocBDT = LocBDT.Add(Tspan)
        '    End If
        '    If optSubtractToD.Checked = True Then
        '        LocBDT = LocBDT.Subtract(Tspan)
        '    End If

        '    lblLocB.Visible = True
        '    txtLocBDateTime.Text = LocBDT.ToString("ddd MM/dd/yyyy HH:mm")
        '    txtLocBDateTime.Visible = True

        'End If

        If Days = 1 Then
            txtDays.Text = "+ 1 day"
            txtDays.Visible = True
        End If
        If Days = -1 Then
            txtDays.Text = "- 1 day"
            txtDays.Visible = True
        End If
        If Days > 1 Then
            txtDays.Text = "+" & Str(System.Math.Abs(Days)) & " days"
            txtDays.Visible = True
        End If
        If Days < -1 Then
            txtDays.Text = "-" & Str(System.Math.Abs(Days)) & " days"
            txtDays.Visible = True
        End If

    End Sub

    'Private Sub txtD1_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
    '    txtCalcTime1.Clear()
    'End Sub

    'Private Sub txtD1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
    '    Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
    '    Select Case KeyAscii
    '        Case Asc("0") To Asc("9")
    '            fnumeral = fnumeral & Chr(KeyAscii)
    '        Case Asc(".") 'only allows one decimal point
    '            If InStr(txtD1.Text, ".") Then
    '                If KeyAscii = 46 Then KeyAscii = 0 : Beep()
    '            End If
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

    'Private Sub txtD1_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs)
    '    Dim KeepFocus As Boolean = eventArgs.Cancel
    '    eventArgs.Cancel = KeepFocus
    'End Sub
    'Private Sub txtD1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
    '    SelectAllText(txtD1)
    'End Sub

    'Private Sub txtH1_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
    '    txtCalcTime1.Clear()
    'End Sub

    'Private Sub txtH1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
    '    Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
    '    Select Case KeyAscii
    '        Case Asc("0") To Asc("9")
    '            fnumeral = fnumeral & Chr(KeyAscii)
    '        Case Asc(".") 'only allows one decimal point
    '            If InStr(txtH1.Text, ".") Then
    '                If KeyAscii = 46 Then KeyAscii = 0 : Beep()
    '            End If
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

    'Private Sub txtH1_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs)
    '    Dim KeepFocus As Boolean = eventArgs.Cancel
    '    eventArgs.Cancel = KeepFocus
    'End Sub
    'Private Sub txtH1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
    '    SelectAllText(txtH1)
    'End Sub

    'Private Sub txtM1_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
    '    txtCalcTime1.Clear()
    'End Sub

    'Private Sub txtM1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
    '    Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
    '    Select Case KeyAscii
    '        Case Asc("0") To Asc("9")
    '            fnumeral = fnumeral & Chr(KeyAscii)
    '        Case Asc(".") 'only allows one decimal point
    '            If InStr(txtM1.Text, ".") Then
    '                If KeyAscii = 46 Then KeyAscii = 0 : Beep()
    '            End If
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

    'Private Sub txtM1_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs)
    '    Dim KeepFocus As Boolean = eventArgs.Cancel
    '    eventArgs.Cancel = KeepFocus
    'End Sub
    'Private Sub txtM1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
    '    SelectAllText(txtM1)
    'End Sub

    'Private Sub txtS1_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
    '    txtCalcTime1.Clear()
    'End Sub

    'Private Sub txtS1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
    '    Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
    '    Select Case KeyAscii
    '        Case Asc("0") To Asc("9")
    '            fnumeral = fnumeral & Chr(KeyAscii)
    '        Case Asc(".") 'only allows one decimal point
    '            If InStr(txtS1.Text, ".") Then
    '                If KeyAscii = 46 Then KeyAscii = 0 : Beep()
    '            End If
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

    'Private Sub txtS1_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs)
    '    Dim KeepFocus As Boolean = eventArgs.Cancel
    '    eventArgs.Cancel = KeepFocus
    'End Sub
    'Private Sub txtS1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
    '    SelectAllText(txtS1)
    'End Sub

    'Private Sub txtD2_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
    '    txtCalcTime1.Clear()
    'End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()

    End Sub

    'Private Sub txtD2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
    '    Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
    '    Select Case KeyAscii
    '        Case Asc("0") To Asc("9")
    '            fnumeral = fnumeral & Chr(KeyAscii)
    '        Case Asc(".") 'only allows one decimal point
    '            If InStr(txtD2.Text, ".") Then
    '                If KeyAscii = 46 Then KeyAscii = 0 : Beep()
    '            End If
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

    'Private Sub DTLocA_ValueChanged(sender As Object, e As EventArgs)
    '    LocADT = DTLocA.Value
    '    LocADTPicked = True
    '    txtTime1.Text = LocADT.Hour.ToString("00") & LocADT.Minute.ToString("00")
    'End Sub

    'Private Sub cbLocAZD_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    TZA = cbLocAZD.SelectedItem
    '    TZAID = TZA.Id
    '    TZASelected = True
    '    Dim TempHr As Double = TZA.BaseUtcOffset.Hours
    '    Dim TempMin As Double = System.Math.Abs(TZA.BaseUtcOffset.Minutes)
    '    TempHr = -TempHr
    '    txtZDh1.Text = TempHr
    '    Select Case TempMin
    '        Case 30
    '            cboZDm1.SelectedIndex = 1
    '        Case 45
    '            cboZDm1.SelectedIndex = 2
    '    End Select
    'End Sub

    'Private Sub cbLocBZone_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    TZB = cbLocBZone.SelectedItem
    '    TZBId = TZB.Id
    '    TZBSelected = True
    '    Dim TempHr As Double = TZB.BaseUtcOffset.Hours
    '    Dim TempMin As Double = System.Math.Abs(TZB.BaseUtcOffset.Minutes)
    '    TempHr = -TempHr
    '    txtZDh2.Text = TempHr
    '    Select Case TempMin
    '        Case 30
    '            cboZDm2.SelectedIndex = 1
    '        Case 45
    '            cboZDm2.SelectedIndex = 2
    '    End Select
    'End Sub

    Private Sub btnAddSubtract_Click(sender As Object, e As EventArgs) Handles btnAddSubtract.Click
        AddSubtractCalculate()
    End Sub

    Private Sub btnZDCalc_Click(sender As Object, e As EventArgs) Handles btnZDCalc.Click
        ZDCalc()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 1 Then
            DT1Days.Value = 0
            DT1Hours.Value = 0
            DT1Minutes.Value = 0
            DT1Seconds.Value = 0

            DT2Days.Value = 0
            DT2Hours.Value = 0
            DT2Minutes.Value = 0
            DT2Seconds.Value = 0

            DTRDays.Value = 0
            DTRHours.Value = 0
            DTRMinutes.Value = 0
            DTRSeconds.Value = 0

        End If

        Exit Sub
    End Sub

    Private Sub txtD2_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs)
        Dim KeepFocus As Boolean = eventArgs.Cancel
        eventArgs.Cancel = KeepFocus
    End Sub

    Private Sub cmdCalculateTimes_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCalculateTimes.Click

        Dim T1span As TimeSpan = New TimeSpan(DT1Days.Value, DT1Hours.Value, DT1Minutes.Value, DT1Seconds.Value)
        Dim T2span As TimeSpan = New TimeSpan(DT2Days.Value, DT2Hours.Value, DT2Minutes.Value, DT2Seconds.Value)

        Dim T3span As TimeSpan
        If optAddTimes.Checked = True Then T3span = T1span.Add(T2span)
        If optSubtractTimes.Checked = True Then T3span = T1span.Subtract(T2span)
        DTRDays.Value = T3span.Days
        DTRHours.Value = T3span.Hours
        DTRMinutes.Value = T3span.Minutes
        DTRSeconds.Value = T3span.Seconds

        If DTRDays.Value > DT1Days.Value Then
            DT1Days.Maximum = 2 * DTRDays.Value
            DT2Days.Maximum = 2 * DTRDays.Value
        End If

        Exit Sub
    End Sub

    Private Sub cmdClearTimes_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClearTimes.Click
        DT1Days.Value = 0
        DT1Hours.Value = 0
        DT1Minutes.Value = 0
        DT1Seconds.Value = 0

        DT2Days.Value = 0
        DT2Hours.Value = 0
        DT2Minutes.Value = 0
        DT2Seconds.Value = 0

        DTRDays.Value = 0
        DTRHours.Value = 0
        DTRMinutes.Value = 0
        DTRSeconds.Value = 0
        Exit Sub
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
        'AutoZDCalc()
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
            ErrorMsgBox("Out of Range")
        End If
        'AutoZDCalc()
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

    Private Sub cboLo_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboLo.SelectedIndexChanged
        'AutoZDCalc()
    End Sub

    Public Sub ZDCalc()
        Lo = Val(txtLoDeg.Text) + Val(txtLoMin.Text) / 60
        ZD = Int(Lo / 15 + 0.5)
        If cboLo.Text = "E" Then ZD = -ZD
        SignZD = "+" : If cboLo.Text = "E" Then SignZD = "-"
        txtZD.Text = SignZD & System.Math.Abs(ZD)
    End Sub
    Private Sub SelectAllText(ByRef TB As System.Windows.Forms.TextBox)
        TB.SelectionStart = 0
        TB.SelectionLength = Len(TB.Text)
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