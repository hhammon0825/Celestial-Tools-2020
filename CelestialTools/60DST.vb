Option Strict Off
Option Explicit On
'Imports Microsoft.VisualBasic.Compatibility.VB6

Friend Class Form60DST
    Inherits System.Windows.Forms.Form
    Dim Speed, Distance, Time As Double
    Dim TSpan As TimeSpan
    Dim TSpanDbl As Double
    Dim Flag1, Flag2 As Boolean
    Dim fnumeral As String

    Private Sub cmdClear_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClear.Click
        'Cls
        txtDistance.Clear()
        txtSpeed.Clear()
        txtTime.Clear()
        txtd.Clear()
        txth.Clear()
        txtm.Clear()
        Flag1 = False
        txtTime_TextChanged(txtTime, New System.EventArgs())
        txtd_TextChanged(txtd, New System.EventArgs())
        txth_TextChanged(txth, New System.EventArgs())
        txtm_TextChanged(txtm, New System.EventArgs())
        Refresh()
    End Sub
    Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
        PrintScreen(Me.Bounds)
    End Sub

    Private Sub cmdDistance_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDistance.Click
        Flag1 = True
        If txtTime.Text <> "" Then
            Distance = Val(txtSpeed.Text) * Val(txtTime.Text) / 60
        End If
        If txtTime.Text = "" Then
            Distance = Val(txtSpeed.Text) * (Val(txtd.Text) * 1440 + Val(txth.Text) * 60 + Val(txtm.Text)) / 60
        End If
        If Distance > 9999.9 Then
            txtDistance.Text = "------"
            ExceedsLimit()
            Exit Sub
        End If
        txtDistance.Text = (Int(Distance * 10 + 0.50000000000001) / 10).ToString("0.0")
        Flag1 = False
    End Sub

    Private Sub cmdSpeed_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSpeed.Click
        Flag1 = True
        If Val(txtTime.Text) = 0 And Val(txtd.Text) = 0 And Val(txth.Text) = 0 And Val(txtm.Text) = 0 Then
            ErrorMsgBox("Not enough or illegal inputs")
            Exit Sub
        End If
        If txtTime.Text <> "" Then Speed = 60 * Val(txtDistance.Text) / Val(txtTime.Text)
        If txtTime.Text = "" Then Speed = 60 * Val(txtDistance.Text) / ((Val(txtd.Text) * 1440 + Val(txth.Text) * 60 + Val(txtm.Text)))
        If Speed > 99.9 Then txtSpeed.Text = "-----" : ExceedsLimit() : Exit Sub
        txtSpeed.Text = (Int(Speed * 10 + 0.50000000000001) / 10).ToString("0.0")
        Flag1 = False
    End Sub

    Private Sub cmdTime_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdTime.Click

        Flag1 = True
        txtTime.Enabled = True
        txtd.Enabled = True
        txth.Enabled = True
        txtm.Enabled = True
        txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        txth.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        txtm.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtSpeed.Text) = 0 Then
            ErrorMsgBox("Not enough or illegal inputs")
            Exit Sub
        End If

        Time = 60 * Val(txtDistance.Text) / Val(txtSpeed.Text)

        If Time > 59999 Then txtTime.Text = "-----" : txth.Text = "---" : txtm.Text = "--" : ExceedsLimit() : Exit Sub
        TSpanDbl = Time + 0.50000000000001
        TSpan = TimeSpan.FromMinutes(TSpanDbl)
        txtTime.Text = Int(TSpanDbl).ToString("0")

        txtd.Text = TSpan.Days.ToString("0")
        txth.Text = TSpan.Hours.ToString("0")
        txtm.Text = TSpan.Minutes.ToString("0")

        Flag1 = False
    End Sub

    Private Sub txtTime_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTime.TextChanged
        If Flag1 = True Then Exit Sub
        Flag2 = True
        If txtTime.Text <> "" Then
            txtd.Enabled = False : txtd.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011) ': txtd.ForeColor = &H80000011
            txth.Enabled = False : txth.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011) ': txth.ForeColor = &H80000011
            txtm.Enabled = False : txtm.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011) ': txtm.ForeColor = &H80000011
            txtd.Clear() : txth.Clear() : txtm.Clear()
        Else
            txtd.Enabled = True : txtd.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005) ': txtd.ForeColor = &H80000005
            txth.Enabled = True : txth.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005) ': txth.ForeColor = &H80000005
            txtm.Enabled = True : txtm.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005) ': txtm.ForeColor = &H80000005
        End If
        If Val(txtTime.Text) > 59999 Then
            txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
        If Val(txtTime.Text) <= 59999 Then
            txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        End If
        Flag2 = False
    End Sub

    Private Sub txtTime_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTime.KeyPress
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

    Private Sub txtTime_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtTime.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtTime.Text) > 59999 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtTime_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTime.Enter
        SelectAllText(txtTime)
    End Sub

    Private Sub txtd_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtd.TextChanged
        If Flag1 = True Then Exit Sub
        If Flag2 = True Then Exit Sub
        If txtd.Text <> "" Or txth.Text <> "" Or txtm.Text <> "" Then
            txtTime.Enabled = False : txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011) ': txtTime = ""
        Else
            txtTime.Enabled = True : txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        End If
    End Sub

    Private Sub txtd_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtd.KeyPress
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
    Private Sub txtd_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtd.Enter
        SelectAllText(txtd)
    End Sub

    Private Sub txth_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txth.TextChanged
        If Flag1 = True Then Exit Sub
        If Flag2 = True Then Exit Sub
        'If txth.Enabled = False Then txth.Clear()
        If txth.Text <> "" Or txtm.Text <> "" Then
            txtTime.Enabled = False : txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011) ': txtTime = ""
        Else
            txtTime.Enabled = True : txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        End If
    End Sub
    Private Sub txth_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txth.KeyPress
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
    Private Sub txth_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txth.Enter
        SelectAllText(txth)
    End Sub

    Private Sub txtm_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtm.TextChanged
        If Flag1 = True Then Exit Sub
        If Flag2 = True Then Exit Sub
        'If txtm.Enabled = False Then txtm.Clear()
        If txth.Text <> "" Or txtm.Text <> "" Then
            txtTime.Enabled = False : txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000011) : txtTime.Clear()
        Else
            txtTime.Enabled = True : txtTime.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        End If
        If Val(txtm.Text) > 59 Then
            txtm.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
        If Val(txtm.Text) <= 59 Then txtm.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
    End Sub
    Private Sub txtm_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtm.KeyPress
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
    Private Sub txtm_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtm.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtm.Text) > 59 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtm_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtm.Enter
        SelectAllText(txtm)
    End Sub

    Private Sub txtDistance_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDistance.TextChanged
        If Val(txtDistance.Text) > 9999.9 Then
            txtDistance.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
        If Val(txtDistance.Text) <= 9999.9 Then txtDistance.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
    End Sub
    Private Sub txtDistance_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtDistance.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtDistance.Text, ".") Then
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
    Private Sub txtDistance_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDistance.Enter
        SelectAllText(txtDistance)
    End Sub

    Private Sub txtSpeed_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSpeed.TextChanged
        If Val(txtSpeed.Text) > 99.9 Then
            txtSpeed.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
        If Val(txtSpeed.Text) <= 99.9 Then txtSpeed.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
    End Sub
    Private Sub txtSpeed_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtSpeed.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtSpeed.Text, ".") Then
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
    Private Sub txtSpeed_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtSpeed.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtSpeed.Text) > 99.9 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtSpeed_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSpeed.Enter
        SelectAllText(txtSpeed)
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

    Private Sub ExceedsLimit()
        ErrorMsgBox("Calculated value exceeds allowed limit.")
    End Sub
    Private Sub Form60DST_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
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