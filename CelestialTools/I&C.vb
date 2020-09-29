Option Strict Off
Option Explicit On
Friend Class FormIandC
    Inherits System.Windows.Forms.Form
    Dim fnumeral As String
    Dim vcorr, dcorr, k, GHAIncrement, GHAIncrementMin As Double
    Dim GHAIncrementDeg As Short
    Dim Time, TimeSec As Double
    Dim TimeMin As Short
    'Dim corr2k As Double
    'Dim Flag As Boolean
    Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
        PrintScreen(Me.Bounds)
    End Sub

    Private Sub FormIandC_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        'Calculate()
    End Sub

    Private Sub optAries_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optAries.CheckedChanged
        If eventSender.Checked Then
            txtDeg_TextChanged(txtDeg, New System.EventArgs())
            txtMin_TextChanged(txtMin, New System.EventArgs())
        End If
        Calculate()
    End Sub

    Private Sub optMoon_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optMoon.CheckedChanged
        If eventSender.Checked Then
            txtDeg_TextChanged(txtDeg, New System.EventArgs())
            txtMin_TextChanged(txtMin, New System.EventArgs())
        End If
        Calculate()
    End Sub

    Private Sub optSunPlanets_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optSunPlanets.CheckedChanged
        If eventSender.Checked Then
            txtDeg_TextChanged(txtDeg, New System.EventArgs())
            txtMin_TextChanged(txtMin, New System.EventArgs())
        End If
        Calculate()
    End Sub
    Private Sub optFwd_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optFwd.CheckedChanged
        If eventSender.Checked Then
            If optFwd.Checked = True Then
                txtv.Clear()
                txtd.Clear()
                txtUTm.Clear()
                txtUTs.Clear()

                txtUTm.ReadOnly = False
                txtUTs.ReadOnly = False
                txtv.ReadOnly = False
                txtd.ReadOnly = False

                txtUTm.Enabled = True
                txtUTs.Enabled = True
                txtv.Enabled = True
                txtd.Enabled = True

                txtDeg.Clear()
                txtMin.Clear()
                txtvcorr.Clear()
                txtdcorr.Clear()

                txtDeg.ReadOnly = True
                txtMin.ReadOnly = True
                txtvcorr.ReadOnly = True
                txtdcorr.ReadOnly = True

                txtDeg.Enabled = False
                txtMin.Enabled = False
                txtvcorr.Enabled = False
                txtdcorr.Enabled = False

                txtv.Visible = True
                txtd.Visible = True
                txtvcorr.Visible = True
                txtdcorr.Visible = True
                Label4.Visible = True
                Label5.Visible = True
                Label6.Visible = True
                Label10.Visible = True
                Label11.Visible = True
                Label12.Visible = True
                Label13.Visible = True
                Label14.Visible = True
            End If
        End If
    End Sub
    Private Sub optBack_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optBack.CheckedChanged
        If eventSender.Checked Then
            If optBack.Checked = True Then
                txtv.Clear()
                txtd.Clear()
                txtUTm.Clear()
                txtUTs.Clear()

                txtUTm.ReadOnly = True
                txtUTs.ReadOnly = True
                txtv.ReadOnly = True
                txtd.ReadOnly = True

                txtUTm.Enabled = False
                txtUTs.Enabled = False
                txtv.Enabled = False
                txtd.Enabled = False

                txtDeg.Clear()
                txtMin.Clear()
                txtvcorr.Clear()
                txtdcorr.Clear()

                txtDeg.ReadOnly = False
                txtMin.ReadOnly = False
                txtvcorr.ReadOnly = True
                txtdcorr.ReadOnly = True

                txtDeg.Enabled = True
                txtMin.Enabled = True
                txtvcorr.Enabled = False
                txtdcorr.Enabled = False

                txtv.Visible = False
                txtd.Visible = False
                txtvcorr.Visible = False
                txtdcorr.Visible = False
                Label4.Visible = False
                Label5.Visible = False
                Label6.Visible = False
                Label10.Visible = False
                Label11.Visible = False
                Label12.Visible = False
                Label13.Visible = False
                Label14.Visible = False

            End If
            'Calculate
        End If
    End Sub

    Private Sub txtUTm_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtUTm.TextChanged
        txtUTm.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtUTm.Text) > 59 Then
            txtUTm.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            txtUTm.Focus()
            ErrorMsgBox("Out of Range")
            Exit Sub
        End If
    End Sub
    Private Sub txtUTm_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtUTm.KeyPress
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

    Private Sub txtUTm_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtUTm.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtUTm.Text) > 59 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtUTm_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtUTm.Enter
        SelectAllText(txtUTm)
    End Sub

    Private Sub txtUTs_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtUTs.TextChanged
        txtUTs.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtUTs.Text) > 60 Then
            txtUTs.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            txtUTs.Focus()
            ErrorMsgBox("Out of Range") : Exit Sub
        End If
        'Calculate()
    End Sub
    Private Sub txtUTs_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtUTs.KeyPress
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

    Private Sub txtUTs_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtUTs.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtUTs.Text) > 60 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtUTs_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtUTs.Enter
        SelectAllText(txtUTs)
    End Sub

    Private Sub txtvd_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtv.TextChanged
        txtv.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtv.Text) > 18 Then
            txtv.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            txtv.Focus()
            ErrorMsgBox("Value must be <= 18")
            Exit Sub
        End If
    End Sub

    Private Sub txtvd_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtv.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtv.Text, ".") Then
                    If KeyAscii = 46 Then KeyAscii = 0 : 
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

    Private Sub txtvd_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtv.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtv.Text) > 18 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtvd_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtv.Enter
        SelectAllText(txtv)
    End Sub

    Private Sub Calculate()

        Dim FlagV As Boolean = False 'this and corr2k used for pre-2001 values of the four corrections that changed in 2001
        Dim FlagD As Boolean = False
        Dim corr2kv As Double = 0
        Dim corr2kd As Double = 0

        txtvcorrx.Visible = False
        txtdcorrx.Visible = False
        txtvcorrx.Clear()
        txtdcorrx.Clear()

        If (optSunPlanets.Checked = False And optAries.Checked = False And optMoon.Checked = False) And ((optFwd.Checked = True And (txtUTm.Text <> "" Or txtUTs.Text <> "" Or txtv.Text <> "")) Or (optBack.Checked = True And (txtDeg.Text <> "" Or txtMin.Text <> ""))) Then
            ErrorMsgBox("You must select an object.")
            Exit Sub
        End If
        If optSunPlanets.Checked = True Then
            'k = 15
            k = g_SunPlanetsHrDeg
        End If
        If optAries.Checked = True Then
            k = g_AriesHrDeg
            'k = 15.04106864 ' same as value used in SRF FormSRF code
            'k = 15 + (36000 / 36535) / 24            '=15.0410677618... but this works
        End If
        If optMoon.Checked = True Then
            k = g_MoonHrDeg
            'k = 14 + 19 / 60
        End If
        If optFwd.Checked = True Then ' optFwd is the UTC to GHA I&C conversion
            ' UTHrs  = (UTMin + UTSec/60)/60
            ' GHA Incr = Body 1 hr Degrees Factor(k) * UTHrs 
            GHAIncrement = k * (Val(txtUTm.Text) + Val(txtUTs.Text) / 60) / 60
            ' Corr factor = Daily page factor * (UTMin + 0.5) / 60
            vcorr = Val(txtv.Text) * (Val(txtUTm.Text) + 0.5) / 60
            dcorr = Val(txtd.Text) * (Val(txtUTm.Text) + 0.5) / 60
            ' Arcane rounding of vcorr and dcorr to make certain they match almanac values
            vcorr = Int(vcorr * 10 + 0.50000000000001) / 10
            dcorr = Int(dcorr * 10 + 0.50000000000001) / 10

            GHAIncrementDeg = Int(GHAIncrement)
            GHAIncrementMin = (GHAIncrement - GHAIncrementDeg) * 60
            GHAIncrementMin = Int(GHAIncrementMin * 10 + 0.500000000001) / 10

            If (Val(txtUTm.Text) = 22 And Val(txtv.Text) = 2.8) Then
                vcorr = 1.0
                corr2kv = 1.1
                FlagV = True
            End If
            If (Val(txtUTm.Text) = 22 And Val(txtv.Text) = 16.4) Then
                vcorr = 6.1
                corr2kv = 6.2
                FlagV = True
            End If
            If (Val(txtUTm.Text) = 42 And Val(txtv.Text) = 15.6) Then
                vcorr = 11.1
            End If
            If (Val(txtUTm.Text) = 52 And Val(txtv.Text) = 13.2) Then
                vcorr = 11.6
            End If
            If (Val(txtUTm.Text) = 52 And Val(txtv.Text) = 17.2) Then
                vcorr = 15.1
            End If
            If (Val(txtUTm.Text) = 55 And Val(txtv.Text) = 18) Then
                vcorr = 16.7
            End If
            If (Val(txtUTm.Text) = 57 And Val(txtv.Text) = 13.2) Then
                vcorr = 12.7
            End If
            If (Val(txtUTm.Text) = 52 And Val(txtv.Text) = 9.2) Then
                corr2kv = 8.1
                FlagV = True
            End If
            If (Val(txtUTm.Text) = 52 And Val(txtv.Text) = 16.4) Then
                corr2kv = 14.4
                FlagV = True
            End If

            If (Val(txtUTm.Text) = 22 And Val(txtd.Text) = 16.4) Then
                dcorr = 6.1
                corr2kd = 6.2
                FlagD = True
            End If
            If (Val(txtUTm.Text) = 42 And Val(txtd.Text) = 15.6) Then
                dcorr = 11.1
            End If
            If (Val(txtUTm.Text) = 52 And Val(txtd.Text) = 13.2) Then
                dcorr = 11.6
            End If
            If (Val(txtUTm.Text) = 52 And Val(txtd.Text) = 17.2) Then
                dcorr = 15.1
            End If
            If (Val(txtUTm.Text) = 55 And Val(txtd.Text) = 18) Then
                dcorr = 16.7
            End If
            If (Val(txtUTm.Text) = 57 And Val(txtd.Text) = 13.2) Then
                dcorr = 12.7
            End If
            If (Val(txtUTm.Text) = 52 And Val(txtd.Text) = 9.2) Then
                corr2kd = 8.1
                FlagD = True
            End If
            If (Val(txtUTm.Text) = 52 And Val(txtd.Text) = 16.4) Then
                corr2kd = 14.4
                FlagD = True
            End If
            txtDeg.Text = GHAIncrementDeg.ToString("0", CultureInfo.CurrentCulture)
            txtMin.Text = GHAIncrementMin.ToString("00.0", CultureInfo.CurrentCulture)
            txtvcorr.Text = vcorr.ToString("0.0", CultureInfo.CurrentCulture)
            txtdcorr.Text = dcorr.ToString("0.0", CultureInfo.CurrentCulture)

            If FlagV = True Then
                txtvcorrx.Text = "v-corr value is Post-2001. Pre-2001 value is " & Strings.Format(corr2kv, "0.0")
                txtvcorrx.Visible = True
            Else
                txtvcorrx.Clear()
                txtvcorrx.Visible = False
            End If

            If FlagD = True Then
                txtdcorrx.Text = "d-corr value is Post-2001. Pre-2001 value is " & Strings.Format(corr2kd, "0.0")
                txtdcorrx.Visible = True
            Else
                txtdcorrx.Clear()
                txtdcorrx.Visible = False
            End If

        End If
        If optBack.Checked = True Then
            Time = (60 * (Val(txtDeg.Text) + Val(txtMin.Text) / 60)) / k
            TimeMin = Int(Time)
            TimeSec = Int((Time - TimeMin) * 60 + 0.5)
            txtUTm.Text = TimeMin.ToString("0", CultureInfo.CurrentCulture)
            txtUTs.Text = TimeSec.ToString("00", CultureInfo.CurrentCulture)
            txtv.Clear()
            txtd.Clear()

            'txtIC.AppendText("Time " & Strings.Format(TimeMin, "0") & "m" & Strings.Format(TimeSec, "00") & g_LatS)
        End If
    End Sub
    Private Sub txtDeg_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDeg.TextChanged
        txtDeg.BackColor = Control.DefaultBackColor
        If (optMoon.Checked = False And Val(txtDeg.Text) > 15) Or (optMoon.Checked = True And Val(txtDeg.Text) > 14) Then
            txtDeg.BackColor = Color.Red 'System.Drawing.ColorTranslator.FromOle(&HFF)
            txtDeg.Focus()
            ErrorMsgBox("Degree value must between 0 to 15 for Sun/Aries or Planets or 0 to 14 for Moon")
            Exit Sub
        End If
    End Sub
    Private Sub txtDeg_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtDeg.KeyPress
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

    Private Sub txtDeg_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtDeg.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If (optMoon.Checked = False And Val(txtDeg.Text) > 15) Or (optMoon.Checked = True And Val(txtDeg.Text) > 14) Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtDeg_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDeg.Enter
        SelectAllText(txtDeg)
    End Sub

    Private Sub txtMin_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMin.TextChanged
        txtMin.BackColor = Control.DefaultBackColor    'System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtMin.Text) > 59.9 Then
            txtMin.BackColor = Color.Red     'System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Minutes value must be between 0 and 59.9")
            Exit Sub
        End If
        If (optSunPlanets.Checked = True And Val(txtDeg.Text) = 15 And Val(txtMin.Text) <> 0) Then
            txtMin.BackColor = Color.Red     'System.Drawing.ColorTranslator.FromOle(&HFF)
            txtMin.Focus()
            ErrorMsgBox("For Sun/Planets and Degrees = 15, the Minutes value must be 0")
            Exit Sub
        ElseIf (optAries.Checked = True And Val(txtDeg.Text) = 15 And Val(txtMin.Text) > 2.5) Then
            txtMin.BackColor = Color.Red     'System.Drawing.ColorTranslator.FromOle(&HFF)
            txtMin.Focus()
            ErrorMsgBox("For Aries and Degrees = 15, the Minutes must be 0")
            Exit Sub
        ElseIf (optMoon.Checked = True And Val(txtDeg.Text) = 14 And Val(txtMin.Text) > 19) Then
            txtMin.BackColor = Color.Red     'System.Drawing.ColorTranslator.FromOle(&HFF)
            txtMin.Focus()
            ErrorMsgBox("For Moon and Degrees = 14, the Minutes must be <= 19")
            Exit Sub
        End If

        Exit Sub
    End Sub
    Private Sub txtMin_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtMin.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtMin.Text, ".") Then
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

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

    Private Sub txtMin_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtMin.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtMin.Text) > 59.9 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub

    Private Sub btnClearFields_Click(sender As Object, e As EventArgs) Handles btnClearFields.Click
        txtv.Clear()
        txtd.Clear()
        txtUTm.Clear()
        txtUTs.Clear()

        txtDeg.Clear()
        txtMin.Clear()
        txtvcorr.Clear()
        txtdcorr.Clear()
    End Sub

    Private Sub txtd_Enter(sender As Object, e As EventArgs) Handles txtd.Enter
        SelectAllText(txtd)
    End Sub

    Private Sub txtd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtd.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtd.Text, ".") Then
                    If KeyAscii = 46 Then KeyAscii = 0
                    Beep()
                End If
            Case Asc(Chr(8))
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Else
                KeyAscii = 0
                Beep()
        End Select
        e.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtd_TextChanged(sender As Object, e As EventArgs) Handles txtd.TextChanged
        txtd.BackColor = Control.DefaultBackColor   'System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtd.Text) > 18 Then
            txtd.BackColor = Color.Red    'System.Drawing.ColorTranslator.FromOle(&HFF)
            txtd.Focus()
            ErrorMsgBox("Value must be <= 18")
            Exit Sub
        End If
    End Sub

    Private Sub txtd_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtd.Validating
        Dim KeepFocus As Boolean = e.Cancel
        If Val(txtd.Text) > 18 Then
            KeepFocus = True
        End If
        e.Cancel = KeepFocus
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Calculate()
    End Sub

    Private Sub txtMin_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMin.Enter
        SelectAllText(txtMin)
    End Sub

    Private Sub FormIandC_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'Cleanup()
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