Option Strict Off
Option Explicit On
Friend Class FormTVMDC
    Inherits System.Windows.Forms.Form
    ' this boolean is shared with DevTable FormDevTable_frm which is set by FormDevTable_frm to signal yes / no it is loaded and open for business
    ' this is an alternative to the boolean FormDevTable_frmOpen that is located and maintained inside of FormDevTable_frm program. It is safer to maintain boolean signal in this program
    Public FormDevTable_frmHasOpenedForBusiness As Boolean = False
    Public ClearInputFieldsCounter As Integer = 0
    Dim ChartedVariation, CorrVar As Double
    Dim Variation, AnnualChange, Years 'Deviation As Integer
    Dim Change As Integer
    Dim valtxtDeviation, valtxtVariation, valtxtTrue, valtxtMagnetic, valtxtCompass As Double
    Dim FlagC As Boolean = False
    Dim FlagM As Boolean = False
    Dim Index As Integer = 0
    Dim U1 As Double = 0
    Dim FormTVMDCLoaded As Boolean = False
    Dim TextMagChgd As Boolean = False
    Dim FieldInit As Boolean = False
    Private Sub Form_Initialize_Renamed()
        ClearInputFields()
    End Sub

    Private Sub ClearInputFields()
        FieldInit = True
        ' clear out input test fields
        txtTrue.Clear()
        txtMagnetic.Clear()
        txtCompass.Clear()
        txtVariation.Clear()
        txtDeviation.Clear()
        ' clear out the local variables which hold the text field values
        valtxtTrue = 0
        valtxtVariation = 0
        valtxtMagnetic = 0
        valtxtDeviation = 0
        valtxtCompass = 0
        ' reset background color of all input fields to default color
        txtCompass.BackColor = DefaultBackColor
        txtTrue.BackColor = DefaultBackColor
        txtMagnetic.BackColor = DefaultBackColor
        txtVariation.BackColor = DefaultBackColor
        txtDeviation.BackColor = DefaultBackColor
        FieldInit = False
        Exit Sub
    End Sub
    Private Sub InitChartVarFields()
        txtCY.Clear()
        txtCVDeg.Clear()
        txtCVMin.Clear()
        txtChange.Clear()
        txtYI.Clear()
        txtCorrVar.Clear()
        txtEW.Clear()
        cboCV.SelectedIndex = 0 'g_LongW
        cboIncDec.SelectedIndex = 0 '"Increasing"
        txtYI.Text = CStr(Year(Today))
        ' when the chart variation calc fields are initialized, the checkbox to use calc'd chart var is turned off
        chkChartVar.Checked = False
        Exit Sub
    End Sub
    Private Sub cboCV_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCV.SelectedIndexChanged
    End Sub

    Private Sub cboIncDec_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboIncDec.SelectedIndexChanged
    End Sub

    Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
        PrintScreen(Me.Bounds)
    End Sub

    Private Sub FormTVMDC_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim CompFlag As Boolean
        Dim MagFlag As Boolean
        Dim TrueFlag As Boolean
        cboV.SelectedIndex = 0 'g_LongW
        cboD.SelectedIndex = 0 'g_LongW

        ClearInputFields()
        InitChartVarFields()

        TrueFlag = False
        MagFlag = False
        CompFlag = False
        chkDev.Checked = False
        optDown.Checked = True
        optUp.Checked = False
        FormTVMDCLoaded = True
    End Sub

    Private Sub CorrectedVariation()
        ChartedVariation = 60 * Val(txtCVDeg.Text) + Val(txtCVMin.Text)
        AnnualChange = Val(txtChange.Text)
        If cboIncDec.Text = "Decreasing" Then
            AnnualChange = -AnnualChange
        End If
        Years = Val(txtYI.Text) - Val(txtCY.Text)
        Change = CInt(AnnualChange) * Years
        CorrVar = ChartedVariation + Change
        CorrVar = CorrVar / 60
        CorrVar = Int(CorrVar + 0.5)
        If cboCV.SelectedIndex = 0 Then
            txtEW.Text = g_LongW
        Else
            txtEW.Text = g_LongE
        End If
        'txtEW.Text = cboCV.Text
        If CorrVar < 0 And cboCV.Text = "E" Then txtEW.Text = g_LongW
        If CorrVar < 0 And cboCV.Text = "W" Then txtEW.Text = g_LongE
        If System.Math.Abs(CorrVar) > 99 Then
            txtCorrVar.BackColor = System.Drawing.ColorTranslator.FromOle(&HC8FF)
        Else
            txtCorrVar.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
        End If
        If System.Math.Abs(CorrVar) > 99 Then
            txtEW.BackColor = System.Drawing.ColorTranslator.FromOle(&HC8FF)
        Else
            txtEW.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
        End If
        txtCorrVar.Text = Str(System.Math.Abs(CorrVar))
    End Sub

    Private Sub txtChange_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtChange.TextChanged
        If FieldInit = True Then Exit Sub
        If txtChange.Text = "" Then
            txtChange.Text = "0"
        End If
        Dim ParseInt As Integer = 0
        If Integer.TryParse(txtChange.Text, ParseInt) Then

            If Val(txtChange.Text) > 59 Then
                txtChange.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
                ErrorMsgBox("Change Value too large - must be 0 to 59")
                Exit Sub
            End If
        Else
            txtChange.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Change Value must be numeric between 0 to 59")
            Exit Sub
        End If
        If Val(txtChange.Text) < 60 Then
            txtChange.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        End If
    End Sub
    Private Sub txtChange_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtChange.KeyPress
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
    Private Sub txtChange_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtChange.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtChange.Text) > 59 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtChange_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtChange.Enter
        SelectAllText(txtChange)
    End Sub
    Private Sub txtCVDeg_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCVDeg.TextChanged
    End Sub
    Private Sub txtCVDeg_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtCVDeg.KeyPress
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
    Private Sub txtCVDeg_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCVDeg.Enter
        SelectAllText(txtCVDeg)
    End Sub

    Private Sub txtCVMin_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCVMin.TextChanged
        If FieldInit = True Then Exit Sub
        If txtCVMin.Text = "" Then
            txtCVMin.Text = "0"
        End If
        Dim ParseInt As Integer = 0
        If Integer.TryParse(txtCVMin.Text, ParseInt) Then

            If Val(txtCVMin.Text) > 59 Then
                txtCVMin.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
                ErrorMsgBox("CV Min Value too large - must be 0 to 59")
                Exit Sub
            End If
        Else
            txtCVMin.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("CV Min Value must be numeric between 0 to 59")
            Exit Sub
        End If
        If Val(txtCVMin.Text) < 60 Then
            txtCVMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        End If
    End Sub
    Private Sub txtCVMin_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtCVMin.KeyPress
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
    Private Sub txtCVMin_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtCVMin.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtCVMin.Text) > 59 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtCVMin_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCVMin.Enter
        SelectAllText(txtCVMin)
    End Sub

    Private Sub txtCY_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCY.TextChanged
    End Sub
    Private Sub txtCY_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtCY.KeyPress
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
    Private Sub txtCY_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCY.Enter
        SelectAllText(txtCY)
    End Sub

    Private Sub cboD_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboD.SelectedIndexChanged
        If Not FormTVMDCLoaded Then
            Exit Sub
        End If
        valtxtDeviation = Val(txtDeviation.Text)
        If cboD.Text = "E" Then
            valtxtDeviation = -valtxtDeviation
        End If

    End Sub

    Private Sub cboV_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboV.SelectedIndexChanged
        If Not FormTVMDCLoaded Then
            Exit Sub
        End If
        valtxtVariation = Val(txtVariation.Text)
        If cboV.Text = "E" Then
            valtxtVariation = -valtxtVariation
        End If
    End Sub
    Private Sub txtYI_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtYI.TextChanged
        If Not FormTVMDCLoaded Then Exit Sub
    End Sub
    Private Sub txtYI_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtYI.KeyPress
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
    Private Sub txtYI_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtYI.Enter
        SelectAllText(txtYI)
    End Sub

    Private Sub txtTrue_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTrue.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If Len(txtTrue.Text) = 3 And KeyAscii >= Asc("0") And KeyAscii <= Asc("9") Then
            KeyAscii = 0
        End If
        If KeyAscii >= Asc("0") And KeyAscii <= Asc("9") Then
            valtxtTrue = CSng(Val(txtTrue.Text) & Val(Chr(KeyAscii)))
        Else
            valtxtTrue = Val(txtTrue.Text)
        End If
        If (KeyAscii < Asc("0") Or KeyAscii > Asc("9")) And KeyAscii <> System.Windows.Forms.Keys.Back Then
            KeyAscii = 0
            Beep()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Sub txtTrue_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtTrue.KeyDown
    End Sub
    Private Sub txtTrue_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTrue.TextChanged
        If FieldInit = True Then Exit Sub
        If Val(txtTrue.Text) > 359 Then
            txtTrue.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("True Value too large - must be 0 to 359")
            Exit Sub
        End If
        If Val(txtTrue.Text) < 360 Then
            txtTrue.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        End If
        'DisplayT()
        Exit Sub
    End Sub
    Private Sub txtTrue_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtTrue.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtTrue.Text) > 359 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtTrue_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTrue.Enter
        If Not FormTVMDCLoaded Then Exit Sub
        If FieldInit = True Then Exit Sub
        SelectAllText(txtTrue)
    End Sub
    Private Sub txtTrue_Leave(sender As Object, e As EventArgs) Handles txtTrue.Leave
        If Not FormTVMDCLoaded Then Exit Sub
        Exit Sub
    End Sub

    Private Sub txtVariation_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtVariation.KeyPress
        If Not FormTVMDCLoaded Then Exit Sub
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If Len(txtVariation.Text) = 2 And KeyAscii >= Asc("0") And KeyAscii <= Asc("9") Then
            KeyAscii = 0
        End If
        If KeyAscii >= Asc("0") And KeyAscii <= Asc("9") Then
            valtxtVariation = Val(txtVariation.Text) & KeyAscii
        Else
            valtxtVariation = Val(txtVariation.Text)
        End If
        If cboV.Text = "E" Then
            valtxtVariation = -valtxtVariation
        End If

        If (KeyAscii < Asc("0") Or KeyAscii > Asc("9")) And KeyAscii <> System.Windows.Forms.Keys.Back Then
            KeyAscii = 0
            Beep()
        End If

        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Sub txtVariation_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtVariation.KeyDown
    End Sub
    Private Sub txtVariation_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVariation.Enter
        If Not FormTVMDCLoaded Then Exit Sub
        If FieldInit = True Then Exit Sub
        SelectAllText(txtVariation)
    End Sub
    Private Sub txtVariation_Leave(sender As Object, e As EventArgs) Handles txtVariation.Leave
        Exit Sub
    End Sub
    Private Sub txtVariation_TextChanged(sender As Object, e As EventArgs) Handles txtVariation.TextChanged
        Exit Sub
    End Sub
    Private Sub txtMagnetic_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtMagnetic.KeyPress
        If Not FormTVMDCLoaded Then Exit Sub
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If Len(txtMagnetic.Text) = 3 And KeyAscii >= Asc("0") And KeyAscii <= Asc("9") Then
            KeyAscii = 0
        End If
        If KeyAscii >= Asc("0") And KeyAscii <= Asc("9") Then
            valtxtMagnetic = CSng(Val(txtMagnetic.Text) & Val(Chr(KeyAscii)))
        Else
            valtxtMagnetic = Val(txtMagnetic.Text)
        End If

        If (KeyAscii < Asc("0") Or KeyAscii > Asc("9")) And KeyAscii <> System.Windows.Forms.Keys.Back Then
            KeyAscii = 0
            Beep()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Sub txtMagnetic_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtMagnetic.KeyDown
        TextMagChgd = True
    End Sub
    Private Sub txtMagnetic_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMagnetic.TextChanged
        If Not FormTVMDCLoaded Then Exit Sub
        If FieldInit = True Then Exit Sub
        If Val(txtMagnetic.Text) > 360 Then
            txtMagnetic.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Magnet value too large - must be 0 to 359")
            Exit Sub
        End If
        If Val(txtMagnetic.Text) < 360 Then
            txtMagnetic.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        End If
    End Sub
    Private Sub txtMagnetic_Leave(sender As Object, e As EventArgs) Handles txtMagnetic.Leave
        If Not FormTVMDCLoaded Then Exit Sub
        If Val(txtMagnetic.Text) > 360 Then
            txtMagnetic.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Magnetic Value too large - must be 0 to 359")
            Exit Sub
        End If
        If Val(txtMagnetic.Text) < 360 Then
            txtMagnetic.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        End If
    End Sub

    Private Sub txtMagnetic_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtMagnetic.Validating
        If Not FormTVMDCLoaded Then Exit Sub
        If FieldInit = True Then Exit Sub
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtMagnetic.Text) > 359 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtMagnetic_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMagnetic.Enter
        If Not FormTVMDCLoaded Then Exit Sub
        SelectAllText(txtMagnetic)
    End Sub

    Private Sub txtDeviation_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtDeviation.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If chkDev.Checked = True Then
            KeyAscii = 0
        End If
        If Len(txtDeviation.Text) = 1 And KeyAscii >= Asc("0") And KeyAscii <= Asc("9") Then
            KeyAscii = 0
        End If
        If KeyAscii >= Asc("0") And KeyAscii <= Asc("9") Then
            valtxtDeviation = CSng(Val(txtDeviation.Text) & Val(Chr(KeyAscii)))
        Else
            valtxtDeviation = Val(txtDeviation.Text)
        End If
        If cboD.Text = "E" Then valtxtDeviation = -valtxtDeviation
        If (KeyAscii < Asc("0") Or KeyAscii > Asc("9")) And KeyAscii <> System.Windows.Forms.Keys.Back Then
            KeyAscii = 0
            Beep()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Sub txtDeviation_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtDeviation.KeyDown
    End Sub
    Private Sub txtDeviation_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDeviation.Enter
        SelectAllText(txtDeviation)
    End Sub
    Private Sub txtDeviation_Leave(sender As Object, e As EventArgs) Handles txtDeviation.Leave
        Exit Sub
    End Sub
    Private Sub txtDeviation_TextChanged(sender As Object, e As EventArgs) Handles txtDeviation.TextChanged
        Exit Sub
    End Sub

    Private Sub txtCompass_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtCompass.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If Len(txtCompass.Text) = 3 And KeyAscii >= Asc("0") And KeyAscii <= Asc("9") Then
            KeyAscii = 0
        End If
        If KeyAscii >= Asc("0") And KeyAscii <= Asc("9") Then
            valtxtCompass = CSng(Val(txtCompass.Text) & Val(Chr(KeyAscii)))
        Else
            valtxtCompass = Val(txtCompass.Text)
        End If
        If (KeyAscii < Asc("0") Or KeyAscii > Asc("9")) And KeyAscii <> System.Windows.Forms.Keys.Back Then
            KeyAscii = 0
            Beep()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Sub txtCompass_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtCompass.KeyDown
    End Sub
    Private Sub txtCompass_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCompass.TextChanged
        If FieldInit = True Then Exit Sub
        ' do nothing since this event gets triggered by anything and cannot be relied on
        If Val(txtCompass.Text) > 360 Then
            txtCompass.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Compass Value too large - must be 0 to 359")
            Exit Sub
        End If
        If Val(txtCompass.Text) < 360 Then
            txtCompass.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        End If
    End Sub
    Private Sub txtCompass_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtCompass.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtCompass.Text) > 359 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtCompass_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCompass.Enter
        SelectAllText(txtCompass)
    End Sub
    Private Sub txtCompass_Leave(sender As Object, e As EventArgs) Handles txtCompass.Leave
        If Val(txtCompass.Text) > 360 Then
            txtCompass.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Compass Value too large - must be 0 to 359")
            Exit Sub
        End If
        If Val(txtCompass.Text) < 360 Then
            txtCompass.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        End If
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        If chkDev.Checked = True Then
            FormDevTable_frm.CloseFormDevTable_frm()
            chkDev.Checked = False
        End If
        Me.Close()
    End Sub

    Private Sub DisplayTVMDC()

        If optDown.Checked = True Then
            valtxtTrue = Val(txtTrue.Text)
            If chkChartVar.Checked = True Then
                txtVariation.Text = txtCorrVar.Text
                txtVariation.ReadOnly = True
                txtVariation.Enabled = False
                If txtEW.Text = g_LongW Then
                    cboV.SelectedIndex = 0
                Else
                    cboV.SelectedIndex = 1
                End If
                cboV.Enabled = False
            End If

            valtxtVariation = Val(txtVariation.Text)
            If cboV.Text = "E" Then
                valtxtVariation = -valtxtVariation
            End If

            valtxtMagnetic = valtxtTrue + valtxtVariation
            If valtxtMagnetic > 359 Then
                valtxtMagnetic = valtxtMagnetic - 360
            End If

            If chkDev.Checked = True Then
                FlagM = True
                FlagC = False
                DevInterpM()
            End If

            valtxtDeviation = Val(txtDeviation.Text)
            If cboD.Text = "E" Then
                valtxtDeviation = -valtxtDeviation
            End If


            If valtxtMagnetic < 0 Then
                valtxtMagnetic = valtxtMagnetic + 360
            End If
            txtMagnetic.Text = Strings.Format("#00", System.Math.Abs(valtxtMagnetic).ToString)

            valtxtCompass = valtxtMagnetic + valtxtDeviation

            If valtxtCompass > 359 Then
                valtxtCompass = valtxtCompass - 360
            End If
            If valtxtCompass < 0 Then
                valtxtCompass = valtxtCompass + 360
            End If
            txtCompass.Text = Strings.Format("#00", valtxtCompass.ToString)
        End If

        If optUp.Checked = True Then
            valtxtCompass = Val(txtCompass.Text)

            If chkDev.Checked = True Then
                FlagC = True
                FlagM = False
                DevInterpC()
            Else
                valtxtDeviation = Val(txtDeviation.Text)
                If cboD.Text = "E" Then
                    valtxtDeviation = -valtxtDeviation
                End If
            End If

            valtxtMagnetic = valtxtCompass - valtxtDeviation
            If valtxtMagnetic > 359 Then
                valtxtMagnetic = valtxtMagnetic - 360
            End If

            If valtxtMagnetic < 0 Then
                valtxtMagnetic = valtxtMagnetic + 360
            End If
            txtMagnetic.Text = Strings.Format("#00", System.Math.Abs(valtxtMagnetic).ToString)

            If chkChartVar.Checked = True Then
                txtVariation.Text = txtCorrVar.Text
                txtVariation.ReadOnly = True
                txtVariation.Enabled = False
                If txtEW.Text = g_LongW Then
                    cboV.SelectedIndex = 0
                Else
                    cboV.SelectedIndex = 1
                End If
                cboV.Enabled = False
            End If

            valtxtVariation = Val(txtVariation.Text)
            If cboV.Text = "E" Then
                valtxtVariation = -valtxtVariation
            End If

            valtxtTrue = valtxtMagnetic - valtxtVariation
            If valtxtTrue > 359 Then
                valtxtTrue = valtxtTrue - 360
            End If
            If valtxtTrue < 0 Then
                valtxtTrue = valtxtTrue + 360
            End If
            txtTrue.Text = Strings.Format("#00", valtxtTrue.ToString)
        End If
    End Sub

    Private Sub optDown_CheckedChanged(sender As Object, e As EventArgs) Handles optDown.CheckedChanged
        If optDown.Checked = True Then
            txtCompass.ReadOnly = True
            txtCompass.Enabled = False
            txtCompass.BackColor = Color.LightGray
        Else
            txtCompass.ReadOnly = False
            txtCompass.Enabled = True
            txtCompass.BackColor = DefaultBackColor
        End If
    End Sub
    Private Sub optUp_CheckedChanged(sender As Object, e As EventArgs) Handles optUp.CheckedChanged
        If optUp.Checked = True Then
            txtTrue.ReadOnly = True
            txtTrue.Enabled = False
            txtTrue.BackColor = Color.LightGray
        Else
            txtTrue.ReadOnly = False
            txtTrue.Enabled = True
            txtTrue.BackColor = DefaultBackColor
        End If
    End Sub
    Private Sub ProtectDeviation()
        If chkDev.Checked = True Then
            txtDeviation.ReadOnly = True
            txtDeviation.Enabled = False
            txtDeviation.BackColor = Color.LightGray
            txtDeviation.Clear()
        Else
            txtDeviation.ReadOnly = False
            txtDeviation.Enabled = True
            txtDeviation.BackColor = DefaultBackColor
        End If
    End Sub

    Private Sub chkDev_CheckedChanged(sender As Object, e As EventArgs) Handles chkDev.CheckedChanged
        ProcessChkDevChg()
        Exit Sub
    End Sub

    Private Sub CalcControl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CalcControl.SelectedIndexChanged
        If Not FormTVMDCLoaded Then Exit Sub
        If CalcControl.SelectedIndex = 0 Then
            PerformLoadTVMDC()
        Else
            CalcChartVariation()
        End If
        Exit Sub
    End Sub
    Private Sub PerformLoadTVMDC()
        If optDown.Checked = True Then
        End If
        If optUp.Checked = True Then
        End If
    End Sub

    Private Sub CalcChartVariation()
    End Sub

    Private Sub btnCalcTVMDC_Click(sender As Object, e As EventArgs) Handles btnCalcTVMDC.Click
        DisplayTVMDC()
        Exit Sub
    End Sub

    Private Sub btnCalcChartVar_Click(sender As Object, e As EventArgs) Handles btnCalcChartVar.Click
        CorrectedVariation()
        Exit Sub
    End Sub

    Private Sub btnClearChartVar_Click(sender As Object, e As EventArgs) Handles btnClearChartVar.Click
        InitChartVarFields()
        Exit Sub
    End Sub

    Private Sub chkChartVar_CheckedChanged(sender As Object, e As EventArgs) Handles chkChartVar.CheckedChanged
        If chkChartVar.Checked = True Then
            txtVariation.Text = txtCorrVar.Text
            txtVariation.ReadOnly = True
            txtVariation.Enabled = False
            If txtEW.Text = g_LongW Then
                cboV.SelectedIndex = 0
            Else
                cboV.SelectedIndex = 1
            End If
            cboV.Enabled = False
        Else
            txtVariation.Clear()
            txtVariation.Text = "0"
            valtxtVariation = 0
            txtVariation.ReadOnly = False
            txtVariation.Enabled = True
            cboV.SelectedIndex = 0
            cboV.Enabled = True
        End If

    End Sub

    Private Sub ProcessChkDevChg()
        Dim LocalIdx As Integer = 0
        If Not FormTVMDCLoaded Then Exit Sub
        If chkDev.CheckState = CheckState.Checked Then
            DevForm.Show()
            FormDevTable_frmHasOpenedForBusiness = True
            'FormDevTable_frm.Show()
            'Do
            '    LocalIdx = LocalIdx
            'Loop Until FormDevTable_frmHasOpenedForBusiness = True  ' This semaphore boolean must reside in this FormTVMDC and NOT the original FormDevTable_frm because if it resides in FormDevTable_frm it may not exist
            ProtectDeviation()
            Me.Show()
            If txtMagnetic.Text <> "" And txtMagnetic.Text <> "0" Then
                txtMagnetic_TextChanged(txtMagnetic, New System.EventArgs())
            End If
            'FlagMChange = True
        End If
        If chkDev.CheckState = CheckState.Unchecked Then
            If FormDevTable_frmHasOpenedForBusiness = True Then
                DevForm.SaveDevDataGrid()
                DevForm.Close()
                'FormDevTable_frm.CloseFormDevTable_frm()
                FormDevTable_frmHasOpenedForBusiness = False
            End If
            ProtectDeviation()
            Me.Show()
            If txtMagnetic.Text <> "" And txtMagnetic.Text <> "0" Then
                txtMagnetic_TextChanged(txtMagnetic, New System.EventArgs())
            End If
        End If
    End Sub

    Public Sub DevInterpM()
        If FlagC = True Then Exit Sub
        Dim DevRtn As DevForm.DeviationRec
        If FormDevTable_frmHasOpenedForBusiness = True Then
            DevRtn = DevForm.DevInterpolateMagnetic(Convert.ToInt32(valtxtMagnetic))
            txtDeviation.Text = Strings.Format("#00", System.Math.Abs(DevRtn.TblDev).ToString)
            valtxtDeviation = Convert.ToDouble(System.Math.Abs(DevRtn.TblDev))
            If DevRtn.TblDev < 0 Then
                cboD.SelectedIndex = 0
            Else
                cboD.SelectedIndex = 1
            End If
        Else
            DevForm.Show()
            FormDevTable_frmHasOpenedForBusiness = True
            DevRtn = DevForm.DevInterpolateMagnetic(Convert.ToInt32(valtxtMagnetic))
            txtDeviation.Text = Strings.Format("#00", System.Math.Abs(DevRtn.TblDev).ToString)
            valtxtDeviation = Convert.ToDouble(System.Math.Abs(DevRtn.TblDev))
            If DevRtn.TblDev < 0 Then
                cboD.SelectedIndex = 0
            Else
                cboD.SelectedIndex = 1
            End If
        End If
        Exit Sub
    End Sub

    Public Sub DevInterpC()
        If FlagM = True Then
            Exit Sub 'Or FlagMChange = True
        End If
        Dim DevRtn As DevForm.DeviationRec
        If FormDevTable_frmHasOpenedForBusiness = True Then
            DevRtn = DevForm.DevInterpolateMagnetic(Convert.ToInt32(txtCompass.Text))
            txtDeviation.Text = Strings.Format("#00", System.Math.Abs(DevRtn.TblDev).ToString)
            valtxtDeviation = Convert.ToDouble(System.Math.Abs(DevRtn.TblDev))
            If DevRtn.TblDev < 0 Then
                cboD.SelectedIndex = 0
            Else
                cboD.SelectedIndex = 1
            End If
        Else
            DevForm.Show()
            FormDevTable_frmHasOpenedForBusiness = True
            DevRtn = DevForm.DevInterpolateMagnetic(Convert.ToInt32(txtCompass.Text))
            txtDeviation.Text = Strings.Format("#00", System.Math.Abs(DevRtn.TblDev).ToString)
            valtxtDeviation = Convert.ToDouble(System.Math.Abs(DevRtn.TblDev))
            If DevRtn.TblDev < 0 Then
                cboD.SelectedIndex = 0
            Else
                cboD.SelectedIndex = 1
            End If
        End If
        Exit Sub
    End Sub

    Public Sub cmdClear_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClear.Click
        FieldInit = True
        Form_Initialize_Renamed()
        FieldInit = False
    End Sub
    Private Sub FormTVMDC_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
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