Option Strict Off
Option Explicit On
Friend Class FormCTSSOA
    Inherits System.Windows.Forms.Form
    Dim DesiredCourse As Integer
    Dim CurrentSet As Double
    Dim CruisingSpeed, CurrentDrift As Double
    Dim CTS As Double
    Dim RequiredSpeed, SWC, SOA, Pi, SMG As Double
    Dim SetComp As Short
    Dim fnumeral As String
    Dim PortStarboard As Short
    Dim CTSwithLeeway As Single
    Dim Heading As Double
    Dim CMG, x, y, CMGWithLeeway As Double

    Private Sub cmdCalculate_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCalculate.Click
        If Val(txtDriftAngle.Text) <> 0 And cboWind.SelectedIndex = -1 Then
            ErrorMsgBox("'Wind from' cannot be blank if 'Drift Angle' is not zero.")
            Exit Sub
        End If
        Pi = System.Math.PI
        CurrentSet = Val(txtSet.Text)
        CurrentDrift = Val(txtDrift.Text)
        CruisingSpeed = Val(txtCS.Text)
        If CruisingSpeed = 0 Then
            With txtCS
                .Focus()
            End With
            MessageBox.Show("Cruising Speed cannot be 0.")
            Exit Sub
        End If
        If optCTSSOA.Checked = True Then
            DesiredCourse = Val(txtDC.Text)
            SetComp = 180 + CurrentSet
            If SetComp >= 360 Then
                SetComp = SetComp - 360
            End If
            SWC = (CurrentDrift / CruisingSpeed) * System.Math.Sin((SetComp - DesiredCourse) * Pi / 180)
            If System.Math.Abs(SWC) > 1 Then
                txtWindCurrent.Clear()
                txtWindCurrent.Text = "You cannot achieve the desired course under these conditions."
                Refresh()
                Exit Sub
            End If
            CTS = DesiredCourse + (System.Math.Atan(SWC / System.Math.Sqrt(-SWC * SWC + 1)) * 180 / Pi) 'desired course + correction angle
            If CTS < 0 Then
                CTS = CTS + 360
            End If
            If CTS >= 360 Then
                CTS = CTS - 360
            End If
            SOA = CruisingSpeed * System.Math.Sqrt(1 - SWC * SWC) - CurrentDrift * System.Math.Cos((SetComp - DesiredCourse) * Pi / 180)
            RequiredSpeed = (CruisingSpeed + CurrentDrift * System.Math.Cos((SetComp - DesiredCourse) * Pi / 180)) / System.Math.Sqrt(1 - SWC * SWC)
            CTS = Int(CTS + 0.5)
            SOA = Int(SOA * 10 + 0.5) / 10
            RequiredSpeed = Int(RequiredSpeed * 10 + 0.5) / 10
            If Val(txtDriftAngle.Text) <> 0 Then
                PortStarboard = DesiredCourse - Convert.ToInt32(Val(txtDriftAngle.Text))
            End If
            If PortStarboard < 0 Then
                PortStarboard = PortStarboard + 360
            End If
            If PortStarboard < 180 Then
                CTSwithLeeway = CTS - Val(txtDriftAngle.Text)
            Else
                CTSwithLeeway = CTS + Val(txtDriftAngle.Text)
            End If
            If cboWind.Text = "Port" Then
                CTSwithLeeway = CTS - Val(txtDriftAngle.Text)
            End If
            If cboWind.Text = "Starboard" Then
                CTSwithLeeway = CTS + Val(txtDriftAngle.Text)
            End If
            CTSwithLeeway = Int(CTSwithLeeway + 0.5)
            txtWindCurrent.Clear()
            txtWindCurrent.AppendText("Course to Steer (CTS) without leeway  " & Strings.Format(CTS, "000") & Chr(176) & vbNewLine) '; " *" '" True *"
            txtWindCurrent.AppendText("Course to Steer (CTS) with leeway       " & Strings.Format(CTSwithLeeway, "000") & Chr(176) & vbNewLine) '; " *" '" True *"
            txtWindCurrent.AppendText("Speed of Advance (SOA)  " & Strings.Format(SOA, "0.0") & " knots" & vbNewLine)
            txtWindCurrent.AppendText("Speed required to achieve planned cruising speed  " & Strings.Format(RequiredSpeed, "0.0") & " knots" & vbNewLine)
        End If
        If optCMGSMG.Checked = True Then
            Heading = Val(txtDC.Text)
            x = CruisingSpeed * System.Math.Sin(Heading * Pi / 180) + CurrentDrift * System.Math.Sin(CurrentSet * Pi / 180)
            y = CruisingSpeed * System.Math.Cos(Heading * Pi / 180) + CurrentDrift * System.Math.Cos(CurrentSet * Pi / 180)
            SMG = System.Math.Sqrt(x * x + y * y)
            CMG = 90 - System.Math.Atan(y / x) * 180 / Pi
            If x < 0 Then
                CMG = CMG + 180
            End If

            If CMG < 0 Then
                CMG = CMG + 360
            End If

            If CMG >= 360 Then
                CMG = CMG - 360
            End If

            SMG = Int(SMG * 10 + 0.5) / 10
            CMG = Int(CMG + 0.5)

            If Val(txtDriftAngle.Text) <> 0 Then
                PortStarboard = CMG - Val(txtDriftAngle.Text)
            End If

            If PortStarboard < 0 Then
                PortStarboard = PortStarboard + 360
            End If

            If PortStarboard < 180 Then
                CMGWithLeeway = CMG + Val(txtDriftAngle.Text)
            Else
                CMGWithLeeway = CMG - Val(txtDriftAngle.Text)
            End If

            If cboWind.Text = "Port" Then
                CMGWithLeeway = CMG + Val(txtDriftAngle.Text)
            End If

            If cboWind.Text = "Starboard" Then
                CMGWithLeeway = CMG - Val(txtDriftAngle.Text)
            End If

            CMGWithLeeway = Int(CMGWithLeeway + 0.5)

            txtWindCurrent.Clear()

            txtWindCurrent.AppendText("Course Made Good (CMG) without leeway " & Strings.Format(CMG, "000") & Chr(176) & vbNewLine)
            txtWindCurrent.AppendText("Course Made Good (CMG) with leeway " & Strings.Format(CMGWithLeeway, "000") & Chr(176) & vbNewLine)
            txtWindCurrent.AppendText("Speed Made Good (SMG)  " & Strings.Format(SMG, "0.0") & " knots" & vbNewLine)
        End If
        Refresh()
    End Sub

    Private Sub cmdClear_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClear.Click
        txtWindCurrent.Clear()
        txtDC.Text = ""
        txtCS.Text = ""
        txtSet.Text = ""
        txtDrift.Text = ""
        txtDriftAngle.Text = ""
        cboWind.SelectedIndex = -1
        Refresh()

    End Sub

    Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
        PrintScreen(Me.Bounds)
    End Sub
    Private Sub FormCTSSOA_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'Cleanup()
    End Sub
    Private Sub Form_Initialize_Renamed()
        Pi = System.Math.PI ' 4 * System.Math.Atan(1.0#)
        Label2.Visible = True
        Label4.Visible = True
        Label14.Visible = False
        Label1.Visible = False
    End Sub

    Private Sub optCTSSOA_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optCTSSOA.CheckedChanged
        If eventSender.Checked Then
            Label2.Visible = True
            Label4.Visible = True
            Label14.Visible = False
            Label1.Visible = False
        End If
    End Sub

    Private Sub optCMGSMG_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optCMGSMG.CheckedChanged
        If eventSender.Checked Then
            Label2.Visible = False
            Label4.Visible = False
            Label14.Visible = True
            Label1.Visible = True
        End If
    End Sub

    Private Sub txtCS_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCS.TextChanged
        If Val(txtCS.Text) > 99.9 Then 'Or Val(txtCS.Text) < 0.1 Then
            txtCS.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
        If Val(txtCS.Text) <= 99.9 And Val(txtCS.Text) >= 0.1 Then
            txtCS.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        End If
    End Sub
    Private Sub txtCS_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtCS.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtCS.Text, ".") Then
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
    Private Sub txtCS_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtCS.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtCS.Text) > 99.9 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtCS_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCS.Enter
        SelectAllText(txtCS)
    End Sub

    Private Sub txtDC_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDC.TextChanged
        If Val(txtDC.Text) > 359 Then
            txtDC.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
        If Val(txtDC.Text) < 359 Then
            txtDC.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        End If
    End Sub
    Private Sub txtDC_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtDC.KeyPress
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
    Private Sub txtDC_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtDC.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtDC.Text) > 359 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtDC_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDC.Enter
        SelectAllText(txtDC)
    End Sub

    Private Sub txtDrift_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDrift.TextChanged
        If Val(txtDrift.Text) > 99.9 Then
            txtDrift.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
        If Val(txtDrift.Text) <= 99.9 Then
            txtDrift.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        End If
    End Sub
    Private Sub txtDrift_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtDrift.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtDrift.Text, ".") Then
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
    Private Sub txtDrift_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtDrift.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtDrift.Text) > 99.9 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtDrift_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDrift.Enter
        SelectAllText(txtDrift)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()
        Exit Sub
    End Sub

    Private Sub txtDriftAngle_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDriftAngle.TextChanged
        If Val(txtDriftAngle.Text) > 90 Then
            txtSet.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
        If Val(txtSet.Text) <= 90 Then
            txtSet.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        End If
        If Val(txtDriftAngle.Text) <> 0 Then
            cboWind.Enabled = True
        Else
            cboWind.Enabled = False
            cboWind.SelectedIndex = -1
        End If
    End Sub
    Private Sub txtDriftAngle_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtDriftAngle.KeyPress
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
    Private Sub txtDriftAngle_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtDriftAngle.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtDriftAngle.Text) > 90 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtDriftAngle_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDriftAngle.Enter
        SelectAllText(txtDriftAngle)
    End Sub

    Private Sub txtSet_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSet.TextChanged
        If Val(txtSet.Text) > 359 Then
            txtSet.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
        If Val(txtSet.Text) < 359 Then
            txtSet.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        End If
    End Sub
    Private Sub txtSet_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtSet.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(Chr(8))
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".")
                If InStr(txtDrift.Text, ".") Then
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
    Private Sub txtSet_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtSet.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtSet.Text) > 359 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtSet_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSet.Enter
        SelectAllText(txtSet)
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