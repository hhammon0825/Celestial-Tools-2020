Option Strict Off
Option Explicit On
Friend Class FormDistances
    Inherits System.Windows.Forms.Form
    Dim fnumeral As String ', Location$, ChangeCount As Integer, VisibleFormCount As Integer
    Dim HE, Ho As Single
    Dim Pi As Double = System.Math.PI
    Dim HOinFeet, HEinFeet, Dist, hainDegrees, HEinNM As Double
    Dim hsinMinutes, Corr1, ICinMinutes, ICMin, Dip, Corr1Min, HsMin As Double
    Dim Corr1Deg As Short
    Dim B, A, haMinutes As Double
    Dim haDegrees As Short

    Private Sub cmdCalculate_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCalculate.Click
        Me.TextBoxFormDistances.Clear()
        HeightConversion()
        If optVertSeaTop.Checked = True And HEinFeet > HOinFeet Then
            ErrorMsgBox("Height of Eye cannot be greater than height of object.")
            Exit Sub
        End If
        If optDistHorizon.Checked = True Then
            Dist = 1.169497 * System.Math.Sqrt(HEinFeet)
            TextBoxFormDistances.AppendText("Distance of the Horizon: " & Strings.Format(Dist, "#0.0") & " nm = " & Strings.Format(Dist * 1.1507765, "#0.0") & " mi" & vbCrLf)
        End If
        If optGeogRange.Checked = True Then
            Dist = 1.169497 * (System.Math.Sqrt(HEinFeet) + System.Math.Sqrt(HOinFeet))
            TextBoxFormDistances.AppendText("Geographical Range of Visibility: " & Strings.Format(Dist, "#0.0") & " nm = " & Strings.Format(Dist * 1.1507765, "#0.0") & " mi" & vbCrLf)
        End If
        If optVertWaterTop.Checked = True Then 'Table 16 (Bowditch 2002)
            Dip = 0
            AltitudeCorrection()
            If hainDegrees <= 0 Then
                ErrorMsgBox("Corrected altitude must be greater than zero")
                Exit Sub
            End If
            If hainDegrees > 90 Then
                ErrorMsgBox("Corrected altitude cannot exceed 90º")
                Exit Sub
            End If
            Dist = HOinFeet / System.Math.Tan(hainDegrees * Pi / 180) 'feet
            Dist = Dist / 6076.1154 'nautical miles
            'Dist = Int(Dist * 100 + 0.5) / 100
            TextBoxFormDistances.AppendText("Distance to Object: " & Strings.Format(Dist, "#0.00") & " nm = " & Strings.Format(Dist * 1.1507765, "#0.00") & " mi" + vbCrLf)
        End If
        If optVertWaterSea.Checked = True Then 'Table 17 (Bowditch 2002)
            Dip = 0
            AltitudeCorrection()
            If hainDegrees <= 0 Then
                ErrorMsgBox("Corrected altitude must be greater than zero")
                Exit Sub
            End If
            If hainDegrees > 90 Then
                ErrorMsgBox("Corrected altitude cannot exceed 90º")
                Exit Sub
            End If
            HEinNM = HEinFeet / 6076.1154
            B = System.Math.Sqrt(2 * 0.8279 * (HEinNM / 3440.1))
            A = (System.Math.Tan(hainDegrees * Pi / 180) + B) * (1 - (System.Math.Tan(hainDegrees * Pi / 180)) * B)
            Dist = 2025.3718 * (A * 3440.1 - System.Math.Sqrt((A * 3440.1) ^ 2 - 2 * HEinNM * 3440.1 * 0.8279)) / 0.8279
            TextBoxFormDistances.AppendText("Distance to Object: " & Strings.Format(Dist, "#0") & " yards = " & Strings.Format(Dist / 2025.3718, "#0.00") & " nm = " &
                                     Strings.Format(Dist / 1760, "#0.00") & " mi" + vbCrLf)
        End If
        If optVertSeaTop.Checked = True Then 'Table 15 (Bowditch 2002)
            If cboHE.Text = "ft" Or cboHE.Text = "in" Then
                Select Case HE
                    Case Is < 2
                        Dip = 0.7 * HE
                    Case Is <= 3.9
                        Dip = 1.4 + (HE - 2) * 0.25
                    Case Is <= 5.9
                        Dip = 1.9 + (HE - 4) * 0.25
                    Case Is <= 7.6
                        Dip = 2.4 + (HE - 6) * 0.15
                    Case Is >= 7.7
                        Dip = 0.970003 * System.Math.Sqrt(HE)
                End Select
            End If
            If cboHE.Text = "m " Or cboHE.Text = "cm" Then
                Select Case HE
                    Case Is < 1
                        Dip = 1.79 * HE
                    Case Is <= 1.6
                        Dip = 1.79 * System.Math.Sqrt(HE)
                    Case Is >= 1.7
                        Dip = 1.76 * System.Math.Sqrt(HE)
                End Select
            End If
            AltitudeCorrection()
            If hainDegrees > 90 Then
                ErrorMsgBox("Corrected altitude cannot exceed 90º")
                Exit Sub
            End If
            Dist = System.Math.Sqrt((System.Math.Tan(hainDegrees * Pi / 180) / 0.0002419) ^ 2 + (HOinFeet - HEinFeet) / 0.7349) - System.Math.Tan(hainDegrees * Pi / 180) / 0.0002419
            TextBoxFormDistances.AppendText("Distance to Object: " & Strings.Format(Dist, "#0.0") & " nm = " & Strings.Format(Dist * 1.1507765, "#0.0") & " mi" & vbCrLf)
        End If
        If optVertWaterTop.Checked = True Or optVertWaterSea.Checked = True Or optVertSeaTop.Checked = True Then
            TextBoxFormDistances.AppendText("Corrected Vertical Angle: " & Strings.Format(Dist, "#0.0") & " nm = " & Strings.Format(Dist * 1.1507765, "#0.0") & " mi" & vbCrLf)
            If hainDegrees < 0 Then
                TextBoxFormDistances.AppendText("Corrected Vertical Angle: " & "-" & Strings.Format(haDegrees, "0") & Chr(176) & Strings.Format(haMinutes, "00.0") & vbCrLf)
            ElseIf haMinutes >= 60 Then
                haMinutes = haMinutes - 60
                haDegrees = haDegrees + 1
                TextBoxFormDistances.AppendText("Corrected Vertical Angle: " & Strings.Format(haDegrees, "0") & Chr(176) & Strings.Format(haMinutes, "00.0") & vbCrLf)
            Else
                TextBoxFormDistances.AppendText("Corrected Vertical Angle: " & Strings.Format(haDegrees, "0") & Chr(176) & Strings.Format(haMinutes, "00.0") & vbCrLf)
            End If
        End If
        Me.Refresh()
    End Sub
    Public Function HeightConversion() As Object
        Dim rtnObject As Integer = 0
        HE = Val(txtHE.Text)
        If cboHE.Text = "ft" Then HEinFeet = HE
        If cboHE.Text = "m " Then HEinFeet = HE * 3.28095
        If cboHE.Text = "in" Then HEinFeet = HE / 12
        If cboHE.Text = "cm" Then HEinFeet = HE * 0.0328095
        If cboHE.Text = "ft" Or cboHE.Text = "m " Then HE = Int(HE * 10 + 0.5) / 10
        Ho = Val(txtHO.Text)
        If cboHO.Text = "ft" Then HOinFeet = Ho
        If cboHO.Text = "m " Then HOinFeet = Ho * 3.28095
        Ho = Int(Ho * 10 + 0.5) / 10
        Return rtnObject
    End Function

    Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
        PrintScreen(Me.Bounds)
    End Sub

    Private Sub Form_Initialize_Renamed()
        'Pi = 4 * System.Math.Atan(1.0#)
    End Sub

    Private Sub FormDistances_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        cboIE.SelectedIndex = 0 '"on the arc"
        cboHE.SelectedIndex = 0 '"ft"
        cboHO.SelectedIndex = 0 '"ft"
    End Sub

    Private Sub optDistHorizon_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optDistHorizon.CheckedChanged
        If eventSender.Checked Then
            Me.TextBoxFormDistances.Clear()

            txtHE.Text = ""
            txtHO.Text = ""
            txtHsDeg.Text = ""
            txtHsMin.Text = ""
            txtHsSec.Text = ""
            txtIEdeg.Text = ""
            txtIEmin.Text = ""
            txtIESec.Text = ""
            lblHE.Visible = True
            txtHE.Visible = True
            cboHE.Visible = True
            lblHO.Visible = False
            txtHO.Visible = False
            cboHO.Visible = False
            lblHsFormat.Visible = False
            optHsDMm.Visible = False
            optHsDMS.Visible = False
            lblHs.Visible = False
            txtHsDeg.Visible = False
            lblHsDeg.Visible = False
            txtHsMin.Visible = False
            lblHsMin.Visible = False
            txtHsSec.Visible = False
            lblHsSec.Visible = False
            lblIE.Visible = False
            txtIEdeg.Visible = False
            lblIEdeg.Visible = False
            txtIEmin.Visible = False
            lblIEMin.Visible = False
            txtIESec.Visible = False
            lblIEsec.Visible = False
            cboIE.Visible = False
            Me.Refresh()

        End If
    End Sub

    Private Sub optGeogRange_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optGeogRange.CheckedChanged
        If eventSender.Checked Then

            Me.TextBoxFormDistances.Clear()
            txtHE.Text = ""
            txtHO.Text = ""
            txtHsDeg.Text = ""
            txtHsMin.Text = ""
            txtHsSec.Text = ""
            txtIEdeg.Text = ""
            txtIEmin.Text = ""
            txtIESec.Text = ""
            lblHE.Visible = True
            txtHE.Visible = True
            cboHE.Visible = True
            lblHO.Visible = True
            txtHO.Visible = True
            cboHO.Visible = True
            lblHsFormat.Visible = False
            optHsDMm.Visible = False
            optHsDMS.Visible = False
            lblHs.Visible = False
            txtHsDeg.Visible = False
            lblHsDeg.Visible = False
            txtHsMin.Visible = False
            lblHsMin.Visible = False
            txtHsSec.Visible = False
            lblHsSec.Visible = False
            lblIE.Visible = False
            txtIEdeg.Visible = False
            lblIEdeg.Visible = False
            txtIEmin.Visible = False
            lblIEMin.Visible = False
            txtIESec.Visible = False
            lblIEsec.Visible = False
            cboIE.Visible = False
            Me.Refresh()

        End If
    End Sub
    Private Sub optVertWaterTop_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optVertWaterTop.CheckedChanged
        If eventSender.Checked Then

            Me.TextBoxFormDistances.Clear()
            txtHE.Text = ""
            txtHO.Text = ""
            txtHsDeg.Text = ""
            txtHsMin.Text = ""
            txtHsSec.Text = ""
            txtIEdeg.Text = ""
            txtIEmin.Text = ""
            txtIESec.Text = ""
            lblHE.Visible = False
            txtHE.Visible = False
            cboHE.Visible = False
            lblHO.Visible = True
            txtHO.Visible = True
            cboHO.Visible = True
            lblHsFormat.Visible = True
            optHsDMm.Visible = True
            optHsDMS.Visible = True
            lblHs.Visible = True
            txtHsDeg.Visible = True
            lblHsDeg.Visible = True
            txtHsMin.Visible = True
            lblHsMin.Visible = True
            lblIE.Visible = True
            txtIEdeg.Visible = True
            lblIEdeg.Visible = True
            txtIEmin.Visible = True
            lblIEMin.Visible = True
            cboIE.Visible = True
            txtHsSec.Visible = False
            lblHsSec.Visible = False
            txtIESec.Visible = False
            lblIEsec.Visible = False
            If optHsDMS.Checked = True Then
                txtHsSec.Visible = True
                lblHsSec.Visible = True
                txtIESec.Visible = True
                lblIEsec.Visible = True
            End If
        End If
        Me.Refresh()

    End Sub
    Private Sub optVertWaterSea_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optVertWaterSea.CheckedChanged
        If eventSender.Checked Then

            Me.TextBoxFormDistances.Clear()
            txtHE.Text = ""
            txtHO.Text = ""
            txtHsDeg.Text = ""
            txtHsMin.Text = ""
            txtHsSec.Text = ""
            txtIEdeg.Text = ""
            txtIEmin.Text = ""
            txtIESec.Text = ""
            lblHE.Visible = True
            txtHE.Visible = True
            cboHE.Visible = True
            lblHO.Visible = False
            txtHO.Visible = False
            cboHO.Visible = False
            lblHsFormat.Visible = True
            optHsDMm.Visible = True
            optHsDMS.Visible = True
            lblHs.Visible = True
            txtHsDeg.Visible = True
            lblHsDeg.Visible = True
            txtHsMin.Visible = True
            lblHsMin.Visible = True
            lblIE.Visible = True
            txtIEdeg.Visible = True
            lblIEdeg.Visible = True
            txtIEmin.Visible = True
            lblIEMin.Visible = True
            cboIE.Visible = True
            txtHsSec.Visible = False
            lblHsSec.Visible = False
            txtIESec.Visible = False
            lblIEsec.Visible = False
            If optHsDMS.Checked = True Then
                txtHsSec.Visible = True
                lblHsSec.Visible = True
                txtIESec.Visible = True
                lblIEsec.Visible = True
            End If
        End If
        Me.Refresh()

    End Sub
    Private Sub optVertSeaTop_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optVertSeaTop.CheckedChanged
        If eventSender.Checked Then

            Me.TextBoxFormDistances.Clear()
            txtHE.Text = ""
            txtHO.Text = ""
            txtHsDeg.Text = ""
            txtHsMin.Text = ""
            txtHsSec.Text = ""
            txtIEdeg.Text = ""
            txtIEmin.Text = ""
            txtIESec.Text = ""
            lblHE.Visible = True
            txtHE.Visible = True
            cboHE.Visible = True
            lblHO.Visible = True
            txtHO.Visible = True
            cboHO.Visible = True
            lblHsFormat.Visible = True
            optHsDMm.Visible = True
            optHsDMS.Visible = True
            lblHs.Visible = True
            txtHsDeg.Visible = True
            lblHsDeg.Visible = True
            txtHsMin.Visible = True
            lblHsMin.Visible = True
            lblIE.Visible = True
            txtIEdeg.Visible = True
            lblIEdeg.Visible = True
            txtIEmin.Visible = True
            lblIEMin.Visible = True
            cboIE.Visible = True
            txtHsSec.Visible = False
            lblHsSec.Visible = False
            txtIESec.Visible = False
            lblIEsec.Visible = False
            If optHsDMS.Checked = True Then
                txtHsSec.Visible = True
                lblHsSec.Visible = True
                txtIESec.Visible = True
                lblIEsec.Visible = True
            End If
        End If
        Me.Refresh()

    End Sub

    Private Sub txtHE_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtHE.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtHE.Text, ".") Then
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
    Private Sub txtHE_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHE.Enter
        SelectAllText(txtHE)
    End Sub

    Private Sub txtHO_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtHO.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtHO.Text, ".") Then
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
    Private Sub txtHO_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHO.Enter
        SelectAllText(txtHO)
    End Sub

    Private Sub FormDistances_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'Cleanup()
    End Sub

    Private Sub txtHsDeg_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHsDeg.TextChanged
        txtHsDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtHsDeg.Text) > 89 Then
            txtHsDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
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
        If Val(txtHsDeg.Text) > 89 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtHsDeg_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHsDeg.Enter
        SelectAllText(txtHsDeg)
    End Sub

    Private Sub txtHsMin_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHsMin.TextChanged
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
        If optHsDMm.Checked = True And (Val(txtHsMin.Text) > 59.9 Or Val(txtHsMin.Text) < -59.9) Then
            KeepFocus = True
        End If
        If optHsDMS.Checked = True And (Val(txtHsMin.Text) > 59 Or Val(txtHsMin.Text) < -59.9) Then
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
        If Val(txtHsSec.Text) > 59 Or Val(txtHsSec.Text) < -59 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtHsSec_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHsSec.Enter
        SelectAllText(txtHsSec)
    End Sub

    Private Sub txtIEdeg_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtIEdeg.TextChanged
        'This is not really necessary since only one digit is allowed
        txtIEdeg.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtIEdeg.Text) > 9 Then
            txtIEdeg.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
    End Sub

    Private Sub txtIEdeg_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtIEdeg.KeyPress
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

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()

    End Sub

    Private Sub txtIEdeg_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtIEdeg.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        'This is not really necessary since only one digit is allowed
        If Val(txtIEdeg.Text) > 9 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtIEDeg_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtIEdeg.Enter
        SelectAllText(txtIEdeg)
    End Sub

    Private Sub txtIEmin_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtIEmin.TextChanged
        'txtIEmin.ForeColor = &H80000008
        txtIEmin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If optHsDMm.Checked = True And Val(txtIEmin.Text) > 59.9 Then
            txtIEmin.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
        If optHsDMS.Checked = True And Val(txtIEmin.Text) > 59 Then
            txtIEmin.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
    End Sub
    Private Sub txtIEmin_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtIEmin.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If optHsDMS.Checked = True Then
                    KeyAscii = 0
                    Beep()
                Else
                    If InStr(txtIEmin.Text, ".") Then
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

    Private Sub txtIEmin_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtIEmin.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If optHsDMm.Checked = True And Val(txtHsMin.Text) > 59.9 Then
            KeepFocus = True
        End If
        If optHsDMS.Checked = True And Val(txtIEmin.Text) > 59 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtIEmin_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtIEmin.Enter
        SelectAllText(txtIEmin)
    End Sub

    Private Sub txtIESec_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtIESec.TextChanged
        txtIESec.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtIESec.Text) > 59 Then
            txtIESec.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")
        End If
    End Sub

    Private Sub txtIESec_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtIESec.KeyPress
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

    Private Sub txtIESec_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtIESec.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtIESec.Text) > 59 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtIESec_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtIESec.Enter
        SelectAllText(txtIESec)
    End Sub

    Public Sub AltitudeCorrection()
        If optHsDMS.Checked = False Then
            txtHsSec.Text = ""
            txtIESec.Text = ""
        End If
        ICMin = Val(txtIEmin.Text) + Val(txtIESec.Text) / 60
        If cboIE.Text = "on the arc" Then
            ICinMinutes = -(Val(txtIEdeg.Text) * 60 + ICMin)
        End If
        If cboIE.Text = "off the arc (rdg.)" Then
            ICMin = 60 - ICMin
            If ICMin = 60 Then ICMin = 0
            ICinMinutes = (Val(txtIEdeg.Text) - 1) * 60 + ICMin
        End If
        If cboIE.Text = "off the arc (val.)" Then
            ICinMinutes = Val(txtIEdeg.Text) * 60 + ICMin
        End If
        Corr1 = ICinMinutes - Dip
        Corr1Deg = Int(System.Math.Abs(Corr1 / 60))
        Corr1Min = System.Math.Abs(Corr1) - 60 * Corr1Deg
        hsinMinutes = 60 * Val(txtHsDeg.Text) + Val(txtHsMin.Text) + Val(txtHsSec.Text) / 60
        HsMin = Val(txtHsMin.Text) + Val(txtHsSec.Text) / 60
        hainDegrees = (hsinMinutes + Corr1) / 60
        haDegrees = System.Math.Sign(hainDegrees) * Int(System.Math.Abs(hainDegrees)) : haMinutes = System.Math.Abs(hainDegrees - haDegrees) * 60 : haMinutes = Int(haMinutes * 10 + 0.5) / 10
    End Sub
    Private Sub optHsDMm_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optHsDMm.CheckedChanged
        If eventSender.Checked Then
            If optHsDMm.Checked = True Then
                txtHsSec.Visible = False
                lblHsSec.Visible = False
                txtIESec.Visible = False
                lblIEsec.Visible = False
                txtHsMin.Text = ""
                txtIEmin.Text = ""
            End If
        End If
    End Sub

    Private Sub optHsDMS_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optHsDMS.CheckedChanged
        If eventSender.Checked Then
            If optHsDMS.Checked = True Then
                txtHsSec.Visible = True
                lblHsSec.Visible = True
                txtIESec.Visible = True
                lblIEsec.Visible = True
                txtHsMin.Text = ""
                txtIEmin.Text = ""
                txtHsSec.Text = ""
                txtIESec.Text = ""
            End If
        End If
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