Option Strict Off
Option Explicit On
Friend Class Form7
    Inherits System.Windows.Forms.Form
    Dim fnumeral, Location_Renamed As String
    Dim ChangeCount, i, VisibleFormCount As Short
    Dim TypeHorizon As String = "NH"
    Private FavDir As String = "./Favorites/"
    Private Favorites As String()
    Private SLOpenFname As String = ""

    Private Sub cmdAddLocation_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAddLocation.Click

        If optHorizonNatural.Checked = True Then
            TypeHorizon = "NH"
            txtDsDist.Text = ""
        End If
        If optHorizonArtificial.Checked = True Then
            TypeHorizon = "AH"
            txtDsDist.Text = ""
        End If
        If optHorizonDipShort.Checked = True Then
            TypeHorizon = "DS"
        End If
        Location_Renamed = txtNewName.Text & Space(37 - Len(txtNewName.Text))
        Location_Renamed = Location_Renamed & Space(3 - Len(Str(Val(txtLDeg.Text)))) & Strings.Format(Val(txtLDeg.Text), "0") & Chr(176)
        Location_Renamed = Location_Renamed & Strings.Format(Val(txtLMin.Text), "00.0") & "'" & cboL.Text & Space(2)
        Location_Renamed = Location_Renamed & Space(4 - Len(Str(Val(txtLoDeg.Text)))) & Strings.Format(Val(txtLoDeg.Text), "0") & Chr(176)
        Location_Renamed = Location_Renamed & Strings.Format(Val(txtLoMin.Text), "00.0") & "'" & cboLo.Text & Space(4)
        Location_Renamed = Location_Renamed & Space(4 - Len(Str(Val(txtMinAz.Text)))) & Strings.Format(Val(txtMinAz.Text), "0") & Chr(176) & Space(5)
        Location_Renamed = Location_Renamed & Space(4 - Len(Str(Val(txtMaxAz.Text)))) & Strings.Format(Val(txtMaxAz.Text), "0") & Chr(176)
        Location_Renamed = Location_Renamed & Space(4) & TypeHorizon & Space(3)
        Location_Renamed = Location_Renamed & Space(6 - Len(Str(Val(txtDsDist.Text)))) & txtDsDist.Text & Space(1)
        If optHorizonDipShort.Checked = True Then
            Location_Renamed = Location_Renamed & cboDsUnit.Text
        End If
        If optHorizonDipShort.Checked = True And Val(txtDsDist.Text) = 0 Then
            With txtDsDist
                .Focus()
            End With
            ErrorMsgBox("You must enter a non-zero value for Ds distance")
            Exit Sub
        End If
        lstFavorites.Items.Add(Location_Renamed)
        ChangeCount = ChangeCount + 1
    End Sub

    Private Sub cmdRemoveLocation_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRemoveLocation.Click
        If lstFavorites.SelectedIndex = -1 Then
            ErrorMsgBox("No location selected")
            Exit Sub
        End If

        If System.Windows.Forms.MessageBox.Show("Are you sure? Delete No / Yes?", "Confirm Deletion",
                                                System.Windows.Forms.MessageBoxButtons.YesNo,
                                                System.Windows.Forms.MessageBoxIcon.Question,
                                                System.Windows.Forms.MessageBoxDefaultButton.Button2,
                                                System.Windows.Forms.MessageBoxOptions.DefaultDesktopOnly) = DialogResult.No Then
            Exit Sub
        End If

        lstFavorites.Items.RemoveAt(lstFavorites.SelectedIndex)
        ChangeCount = ChangeCount + 1
        Exit Sub
    End Sub

    Private Sub cmdSave_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSave.Click
        ExecFileSave()
        Exit Sub
    End Sub
    Private Sub ExecFileSave()
        Dim i As Integer = 0
        Dim iCnt As Integer = 0

        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        saveFileDialog1.Title = "Save an Favorites List Text File"
        saveFileDialog1.InitialDirectory = FavDir
        saveFileDialog1.FileName = SLOpenFname
        saveFileDialog1.ShowDialog()

        If saveFileDialog1.FileName <> "" Then
            SLOpenFname = saveFileDialog1.FileName
            Dim objWriter As New System.IO.StreamWriter(saveFileDialog1.FileName, False)
            i = 0
            For i = 0 To lstFavorites.Items.Count - 1
                objWriter.WriteLine(lstFavorites.Items(i))
            Next
            objWriter.Close()
            'objWriter.Dispose()
            ChangeCount = 0
        End If

        Exit Sub
    End Sub
    Private Sub ClearFavInfo()
        'With MainMenu.UseFav
        '    .UseThisFav = False
        '    .txtLDeg = vbNullString
        '    .txtLMin = vbNullString
        '    .txtLNS = vbNullString
        '    .txtLoDeg = vbNullString
        '    .txtLoMin = vbNullString
        '    .txtLoEW = vbNullString
        '    .txtLowAz = vbNullString
        '    .txtHighAz = vbNullString
        '    .txtHorizon = vbNullString
        '    .txtHorDist = vbNullString
        '    .txtHorUnit = vbNullString
        '    .HorUnitIdx = 0
        'End With
        Exit Sub
    End Sub
    Private Sub cmdUse_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdUse.Click
        If lstFavorites.SelectedIndex = -1 Then
            ErrorMsgBox("No location selected")
            Exit Sub
        End If
        'With MainMenu.UseFav
        '    .txtLDeg = Mid(lstFavorites.Text, 38, 2)
        '    .txtLMin = Mid(lstFavorites.Text, 41, 4)
        '    .txtLNS = Mid(lstFavorites.Text, 46, 1)
        '    .txtLoDeg = Mid(lstFavorites.Text, 50, 3)
        '    .txtLoMin = Mid(lstFavorites.Text, 54, 4)
        '    .txtLoEW = Mid(lstFavorites.Text, 59, 1)
        '    .txtLowAz = Mid(lstFavorites.Text, 65, 3)
        '    .txtHighAz = Mid(lstFavorites.Text, 74, 3)
        '    .txtHorizon = Mid(lstFavorites.Text, 82, 2)
        '    .txtHorDist = Mid(lstFavorites.Text, 87, 5)
        '    .txtHorUnit = Mid(lstFavorites.Text, 92, 15)

        '    Select Case Mid(lstFavorites.Text, 92, 15).Trim
        '        Case "feet"
        '            .HorUnitIdx = 0
        '        Case "yards"
        '            .HorUnitIdx = 1
        '        Case "meters"
        '            .HorUnitIdx = 2
        '        Case "statute miles"
        '            .HorUnitIdx = 3
        '        Case "nautical miles"
        '            .HorUnitIdx = 4
        '        Case Else
        '            .HorUnitIdx = 0
        '    End Select

        '    .UseThisFav = True

        'End With
        ' Now check if SRF / FormSRF is already open and being used
        'If Application.OpenForms().OfType(Of FormSRF).Any Then

        '    FormSRF.txtLDeg.Text = MainMenu.UseFav.txtLDeg
        '    FormSRF.txtLMin.Text = MainMenu.UseFav.txtLMin
        '    If MainMenu.UseFav.txtLNS = g_LatN Then
        '        FormSRF.cboL.SelectedIndex = 0
        '    Else
        '        FormSRF.cboL.SelectedIndex = 1
        '    End If
        '    FormSRF.txtLoDeg.Text = MainMenu.UseFav.txtLoDeg
        '    FormSRF.txtLoMin.Text = MainMenu.UseFav.txtLoMin
        '    If MainMenu.UseFav.txtLoEW = g_LongW Then
        '        FormSRF.cboLo.SelectedIndex = 0
        '    Else
        '        FormSRF.cboLo.SelectedIndex = 1
        '    End If
        '    Select Case MainMenu.UseFav.txtHorizon
        '        Case "DS"
        '            FormSRF.optHorizonDipShort.Checked = True
        '            FormSRF.txtDsDist.Text = MainMenu.UseFav.txtHorDist
        '            FormSRF.cboDsUnit.SelectedIndex = MainMenu.UseFav.HorUnitIdx
        '        Case "AH"
        '            FormSRF.optHorizonArtificial.Checked = True
        '        Case "NH"
        '            FormSRF.optHorizonNatural.Checked = True
        '        Case Else
        '            FormSRF.optHorizonNatural.Checked = True
        '    End Select
        'End If
        '' Now check if Plan1 / FormSightPlan is already open and in use
        'If Application.OpenForms().OfType(Of FormSightPlan).Any Then
        '    FormSightPlan.txtLDeg.Text = MainMenu.UseFav.txtLDeg
        '    FormSightPlan.txtLMin.Text = MainMenu.UseFav.txtLMin
        '    If MainMenu.UseFav.txtLNS = g_LatN Then
        '        FormSightPlan.cboL.SelectedIndex = 0
        '    Else
        '        FormSightPlan.cboL.SelectedIndex = 1
        '    End If
        '    FormSightPlan.txtLoDeg.Text = MainMenu.UseFav.txtLoDeg
        '    FormSightPlan.txtLoMin.Text = MainMenu.UseFav.txtLoMin
        '    If MainMenu.UseFav.txtLoEW = g_LongW Then
        '        FormSightPlan.cboLo.SelectedIndex = 0
        '    Else
        '        FormSightPlan.cboLo.SelectedIndex = 1
        '    End If
        '    FormSightPlan.txtLowAz.Text = MainMenu.UseFav.txtLowAz
        '    FormSightPlan.txtHighAz.Text = MainMenu.UseFav.txtHighAz
        '    FormSightPlan.txtLowAz.Visible = True
        '    FormSightPlan.txtHighAz.Visible = True
        'End If
        '' Now check if NoonSight / FormNoonSight is already open and in use
        'If Application.OpenForms().OfType(Of FormNoonSight).Any Then
        '    FormNoonSight.optDRL.Checked = True
        '    FormNoonSight.txtDRLDeg.Text = MainMenu.UseFav.txtLDeg
        '    FormNoonSight.txtDRLMin.Text = MainMenu.UseFav.txtLMin
        '    If MainMenu.UseFav.txtLNS = g_LatN Then
        '        FormNoonSight.cboDRL.SelectedIndex = 0
        '    Else
        '        FormNoonSight.cboDRL.SelectedIndex = 1
        '    End If

        '    FormNoonSight.txtLoDeg.Text = MainMenu.UseFav.txtLoDeg
        '    FormNoonSight.txtLoMin.Text = MainMenu.UseFav.txtLoMin
        '    If MainMenu.UseFav.txtLoEW = g_LongW Then
        '        FormNoonSight.cboLo.SelectedIndex = 0
        '    Else
        '        FormNoonSight.cboLo.SelectedIndex = 1
        '    End If

        '    Select Case MainMenu.UseFav.txtHorizon
        '        Case "DS"
        '            FormNoonSight.optHorizonDipShort.Checked = True
        '            FormNoonSight.txtDsDist.Text = MainMenu.UseFav.txtHorDist
        '            FormNoonSight.cboDsUnit.SelectedIndex = MainMenu.UseFav.HorUnitIdx
        '        Case "AH"
        '            FormNoonSight.optHorizonArtificial.Checked = True
        '        Case "NH"
        '            FormNoonSight.optHorizonNatural.Checked = True
        '        Case Else
        '            FormNoonSight.optHorizonNatural.Checked = True
        '    End Select
        'End If
        '' Now check if SRMethods / FormAltSR is already open and in use
        'If Application.OpenForms().OfType(Of FormAltSR).Any Then
        '    FormAltSR.txtLDeg.Text = MainMenu.UseFav.txtLDeg
        '    FormAltSR.txtLMin.Text = MainMenu.UseFav.txtLMin
        '    If MainMenu.UseFav.txtLNS = g_LatN Then
        '        FormAltSR.cboL.SelectedIndex = 0
        '    Else
        '        FormAltSR.cboL.SelectedIndex = 1
        '    End If
        '    FormAltSR.txtLoDeg.Text = MainMenu.UseFav.txtLoDeg
        '    FormAltSR.txtLoMin.Text = MainMenu.UseFav.txtLoMin
        '    If MainMenu.UseFav.txtLoEW = g_LongW Then
        '        FormAltSR.cboLo.SelectedIndex = 0
        '    Else
        '        FormAltSR.cboLo.SelectedIndex = 1
        '    End If
        'End If
        Exit Sub
    End Sub
    Private Sub Form7_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        ChangeCount = 0
        'On Error GoTo DiskErrorHandler
        cboL.SelectedIndex = 0 ' g_LatN    '0
        cboLo.SelectedIndex = 0 ' g_LongW   '0
        cboDsUnit.SelectedIndex = 1 ' "yards"   '1
        lstFavorites.Items.Clear()
        ClearFavInfo()

        'i = 0
        'Dim favorite(0) As Object 'Was (0 to 25) How to change this on the fly?????
        'FileOpen(1, "Favorite_Places.txt", OpenMode.Input)
        'Do Until EOF(1)
        '    favorite(i) = LineInput(1)
        '    lstFavorites.Items.Insert(i - 1, favorite(i))
        'Loop
        'FileClose(1)
        'Exit Sub
        'DiskErrorHandler:
        'Select Case Err.Number
        '	Case 53
        '		FileOpen(1, "Favorite_Places.txt", OpenMode.Output)
        '		FileClose(1)
        '	Case Else
        'End Select
        'Resume
        Exit Sub
    End Sub

    Private Sub Form7_FormClosing(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim Cancel As Boolean = eventArgs.Cancel
        Dim UnloadMode As System.Windows.Forms.CloseReason = eventArgs.CloseReason
        If ChangeCount = 0 Then
            'Cleanup()
            Exit Sub
        End If
        Me.Focus()
        If System.Windows.Forms.MessageBox.Show("Save Location List?  No / Yes", "Save File?",
                                                System.Windows.Forms.MessageBoxButtons.YesNo,
                                                System.Windows.Forms.MessageBoxIcon.Question,
                                                System.Windows.Forms.MessageBoxDefaultButton.Button1,
                                                System.Windows.Forms.MessageBoxOptions.DefaultDesktopOnly) = DialogResult.Yes Then
            ExecFileSave()
            Cancel = False
            Exit Sub
        End If
        eventArgs.Cancel = Cancel
        Exit Sub
    End Sub

    Private Sub Form7_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'Cleanup()
    End Sub

    Private Sub lstFavorites_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstFavorites.DoubleClick
        cmdUse_Click(cmdUse, New System.EventArgs())
    End Sub

    Private Sub optHorizonArtificial_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optHorizonArtificial.CheckedChanged
        If eventSender.Checked Then
            If optHorizonArtificial.Checked = True Then
                lblDsDist.Visible = False
                txtDsDist.Visible = False
                cboDsUnit.Visible = False
            End If
        End If
    End Sub

    Private Sub optHorizonDipShort_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optHorizonDipShort.CheckedChanged
        If eventSender.Checked Then
            If optHorizonDipShort.Checked = True Then
                lblDsDist.Visible = True
                txtDsDist.Visible = True
                cboDsUnit.Visible = True
            End If
        End If
    End Sub

    Private Sub optHorizonNatural_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optHorizonNatural.CheckedChanged
        If eventSender.Checked Then
            If optHorizonNatural.Checked = True Then
                lblDsDist.Visible = False
                txtDsDist.Visible = False
                cboDsUnit.Visible = False
            End If
        End If
    End Sub

    Private Sub txtDsDist_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtDsDist.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Select Case KeyAscii
            Case Asc("0") To Asc("9")
                fnumeral = fnumeral & Chr(KeyAscii)
            Case Asc(".") 'only allows one decimal point
                If InStr(txtDsDist.Text, ".") Then
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
    Private Sub txtDsDist_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDsDist.Enter
        SelectAllText(txtDsDist)
    End Sub

    Private Sub txtLDeg_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLDeg.TextChanged
        If Val(txtLDeg.Text) <> 90 Then
            txtLMin.Enabled = True
        End If
        If Val(txtLDeg.Text) = 90 Then
            txtLMin.Text = ""
            txtLMin.Enabled = False
            txtLMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000B)
        End If
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
        txtLoDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtLoDeg.Text) > 180 Then
            txtLoDeg.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")

        End If
        If Val(txtLoDeg.Text) = 180 Then
            txtLoMin.Text = ""
            txtLoMin.Enabled = False
            txtLoMin.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000B)
        End If
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

    Private Sub txtMinAz_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMinAz.TextChanged
        txtMinAz.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtMinAz.Text) > 360 Then
            txtMinAz.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")

        End If
    End Sub

    Private Sub txtMinAz_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtMinAz.KeyPress
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

    Private Sub txtMinAz_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtMinAz.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtMinAz.Text) > 360 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub
    Private Sub txtMinAz_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMinAz.Enter
        SelectAllText(txtMinAz)
    End Sub

    Private Sub txtMaxAz_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMaxAz.TextChanged
        txtMaxAz.BackColor = System.Drawing.ColorTranslator.FromOle(&H80000005)
        If Val(txtMaxAz.Text) > 360 Then
            txtMaxAz.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            ErrorMsgBox("Out of Range")

        End If
        Exit Sub
    End Sub

    Private Sub txtMaxAz_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtMaxAz.KeyPress
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

    Private Sub txtMaxAz_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtMaxAz.Validating
        Dim KeepFocus As Boolean = eventArgs.Cancel
        If Val(txtMaxAz.Text) > 360 Then
            KeepFocus = True
        End If
        eventArgs.Cancel = KeepFocus
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

    Private Sub btnOpenLocList_Click(sender As Object, e As EventArgs) Handles btnOpenLocList.Click
        Dim myStream As System.IO.StreamReader = Nothing
        Dim openFileDialog1 As New OpenFileDialog()
        Dim rdline As String = vbNullString
        Dim Ictr As Integer = 0
        lstFavorites.Items.Clear()

        openFileDialog1.InitialDirectory = FavDir
        openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        openFileDialog1.Title = "Open Favorites List File"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            If openFileDialog1.FileName = vbNullString Then
                Exit Sub
            End If
            Try
                myStream = New System.IO.StreamReader(openFileDialog1.FileName)
                If (myStream IsNot Nothing) Then
                    SLOpenFname = openFileDialog1.FileName
                    Do While myStream.Peek() >= 0
                        rdline = myStream.ReadLine()
                        If rdline <> vbNullString Then
                            lstFavorites.Items.Insert(Ictr, rdline)
                        End If
                    Loop
                    myStream.Close()
                End If
                myStream.Dispose()
                ClearFavInfo()

            Catch Ex As Exception
                ErrorMsgBox("Cannot read file from disk. Original error: " & Ex.Message)
            Finally
                ' Check this again, since we need to make sure we didn't throw an exception on open.
                If (myStream IsNot Nothing) Then
                    myStream.Close()
                End If
            End Try
        End If
        Exit Sub
    End Sub

    Private Sub txtMaxAz_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMaxAz.Enter
        SelectAllText(txtMaxAz)
    End Sub
    Private Sub txtNewName_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtNewName.Enter
        SelectAllText(txtNewName)
    End Sub
    Private Sub SelectAllText(ByRef TB As System.Windows.Forms.TextBox)
        TB.SelectionStart = 0
        TB.SelectionLength = Len(TB.Text)
        Exit Sub
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